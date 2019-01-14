using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NathanSacconAssignment5.NSUtilityClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NSSail.Models
{
    [ModelMetadataType(typeof(NSMemberMetadata))]

    public partial class Member : IValidatableObject
    {
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            // First Name
            if (FirstName == null || FirstName.Trim() == "")
            {
                yield return new ValidationResult("First Name cannot be empty.",
                    new[] { nameof(FirstName) });
                FirstName = "";
            }
            else
            {
                FirstName = NSValidations.NSCapitalize(FirstName.Trim());
            }
            // Last Name
            if (LastName == null || LastName.Trim() == "")
            {
                yield return new ValidationResult("Last Name cannot be empty.",
                    new[] { nameof(LastName) });
                LastName = "";
            }
            else
            {
                LastName = NSValidations.NSCapitalize(LastName.Trim());
            }
            // Capitalization
            SpouseFirstName = NSValidations.NSCapitalize(SpouseFirstName);
            SpouseLastName = NSValidations.NSCapitalize(SpouseLastName);
            Street = NSValidations.NSCapitalize(Street);
            City = NSValidations.NSCapitalize(City);
            // Full Name
            if(FirstName.Trim() != "" && LastName.Trim() != "")
            {
                FullName = NSValidations.NSFullName(FirstName, LastName, SpouseFirstName, SpouseLastName);
            }

            //Access To Context

            SailContext _context;
            var optionsBuilder = new DbContextOptionsBuilder<SailContext>();
            optionsBuilder.UseSqlServer(@"Data Source=LAPTOP-55PDBKAC\SQLEXPRESSNS;Initial Catalog=Sail;Integrated Security=True");

            _context = new SailContext(optionsBuilder.Options);

            // Province Code
            Province currentRecord = null;
            if (!String.IsNullOrEmpty(ProvinceCode))
            {
                bool error = false;
                try
                {
                    currentRecord = _context.Province.Where(x => x.ProvinceCode == ProvinceCode).ToArray()[0];
                }
                catch (Exception)
                {
                    error = true;
                }
                if (error)
                {
                    yield return new ValidationResult("Province Code must be a valid province.",
                    new[] { nameof(ProvinceCode) });
                    ProvinceCode = "";
                }
            }
            // Postal Code
            if (!String.IsNullOrEmpty(PostalCode) && String.IsNullOrEmpty(ProvinceCode))
            {
                yield return new ValidationResult("To enter a postal code, you must enter a valid province code.",
                    new[] { nameof(PostalCode) });
            } else if(!String.IsNullOrEmpty(PostalCode))
            {
                if(currentRecord.CountryCode == "CA" && NSValidations.NSPostalCodeValidation(PostalCode))
                {
                    PostalCode = NSValidations.NSPostalCodeFormat(PostalCode);
                } else if(currentRecord.CountryCode == "US" && NSValidations.NSZipCodeValidation(PostalCode))
                {
                    PostalCode = NSValidations.NSZipCodeFormat(PostalCode);
                }
                else
                {
                    yield return new ValidationResult("Postal Code must be valid.",
                    new[] { nameof(ProvinceCode) });
                }
            }

            // Home Phone

            if(String.IsNullOrEmpty(HomePhone) || !NSValidations.TelephoneNumberValidate(HomePhone))
            {
                yield return new ValidationResult("Phone number must be valid.",
                    new[] { nameof(HomePhone) });
            } else
            {
                HomePhone = NSValidations.TelephoneNumberFormat(HomePhone);
            }

            // Email
            if (!String.IsNullOrEmpty(Email) && !NSValidations.NSValidEmail(Email))
            {
                yield return new ValidationResult("Email must be valid.",
                    new[] { nameof(Email) });
            }

            //Year Joined
            bool isEdit = false;
            try
            {
                Member checkEdit = _context.Member.Where(x => x.MemberId == MemberId).ToArray()[0];
                isEdit = true;
            }
            catch (Exception)
            {

            }
            if (isEdit)
            {
                if (YearJoined != null && !NSValidations.NSYearValidation(YearJoined))
                {
                    yield return new ValidationResult("Year joined cannot be in the future.",
                    new[] { nameof(YearJoined) });
                }
            }else
            {
                if (!NSValidations.NSYearValidation(YearJoined))
                {
                    yield return new ValidationResult("Year joined is required and cannot be in the future.",
                    new[] { nameof(YearJoined) });
                }
            }
            // Canada Post
            if (!UseCanadaPost && Email == null)
            {
                yield return new ValidationResult("If you will not use Canada Post, you must enter an email.",
                    new[] { nameof(Email), nameof(UseCanadaPost) });
            }
            if (UseCanadaPost)
            {
                if(Street == null || Street.Trim() == "")
                {
                    yield return new ValidationResult("If you will use Canada Post, you must enter a street.",
                    new[] { nameof(Street), nameof(UseCanadaPost) });
                }
                if (City == null || City.Trim() == "")
                {
                    yield return new ValidationResult("If you will use Canada Post, you must enter a city.",
                    new[] { nameof(City), nameof(UseCanadaPost) });
                }
                if (ProvinceCode == null || ProvinceCode.Trim() == "")
                {
                    yield return new ValidationResult("If you will use Canada Post, you must enter a Province Code.",
                    new[] { nameof(ProvinceCode), nameof(UseCanadaPost) });
                }
                if (PostalCode == null || PostalCode.Trim() == "")
                {
                    yield return new ValidationResult("If you will use Canada Post, you must enter a Postal Code.",
                    new[] { nameof(PostalCode), nameof(UseCanadaPost) });
                }
            }
            


        }
    }

    public class NSMemberMetadata
    {
        
        public int MemberId { get; set; }

        public string FullName { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Spouse First Name")]
        public string SpouseFirstName { get; set; }

        [Display(Name = "Spouse Last Name")]
        public string SpouseLastName { get; set; }

        [Display(Name = "Street Address")]
        public string Street { get; set; }
        
        public string City { get; set; }

        [Display(Name = "Province Code")]
        public string ProvinceCode { get; set; }

        [Display(Name = "Postal Code")]
        public string PostalCode { get; set; }

        [Display(Name = "Home Phone")]
        public string HomePhone { get; set; }

        public string Email { get; set; }

        [Display(Name = "Year Joined")]
        public int? YearJoined { get; set; }

        public string Comment { get; set; }

        public bool TaskExempt { get; set; }

        public bool UseCanadaPost { get; set; }

    }
}
