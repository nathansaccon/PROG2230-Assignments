using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
// NSValidations.cs
//
// Purpose: to obtain a validations class to use moving forward in the program.
//
//
namespace NathanSacconAssignment5.NSUtilityClasses
{
    public static class NSValidations
    {
        #region 1. Capitalization

        /// <summary>
        /// Returns the string with all words capitalized.
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static String NSCapitalize(String str)
        {
            str = (str + "").Trim().ToLower();

            if (str != "")
            {
                string fixedText = "";

                for (int i = 0; i < str.Length; i++)
                {
                    // If first char is letter capitalize it.
                    if (i == 0 && Char.IsLetter(str[i]))
                    {
                        fixedText += str[i].ToString().ToUpper();
                    }
                    // If previous char is a space capitalize the following char
                    else if ((i != 0) && (str[i - 1] == ' ') && (Char.IsLetter(str[i])))
                    {
                        fixedText += str[i].ToString().ToUpper();
                    }
                    // Not eligible for capitalization.
                    else
                    {
                        fixedText += str[i];
                    }
                }
                return fixedText;
            }
            else
            {
                return null;
            }
        }

        #endregion

        #region 2. Extract Digits
        /// <summary>
        /// Returns all the numbers from the String value as a string.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static String NSExtractDigits(String value)
        {
            value = (value + "").Trim();
            String newValue = "";
            if (value != "") // If starting value is not null.
            {
                for (int i = 0; i < value.Length; i++)
                {
                    if (IsInteger(value[i])) // Add integer values to newValue
                    {
                        newValue += value[i];
                    }
                }
                if (newValue != "") // If new value is not empty return it.
                {
                    return newValue;
                }
                else // Return null if newValue is empty.
                {
                    return null;
                }
            }
            else // If starting value is null return null.
            {
                return null;
            }
        }

        #endregion

        #region 3. Canada Postal Code Validation
        /// <summary>
        /// Returns a boolean based on is Value is a Canadian Postal Code
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Boolean NSPostalCodeValidation(String value)
        {
            if (String.IsNullOrEmpty(value))
            {
                return true;
            }
            value = NSPostalCodeFormat(value);
            if (value == null)
            {
                return false;
            }else
            {
                return true;
            }
        }
        #endregion

        #region 4. Canadian Postal Code Format
        /// <summary>
        /// Returns String value reformatted as a Canadian postal code, or null otherwise.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static String NSPostalCodeFormat(String value)
        {
            value = (value + "").Trim().ToUpper();
            Regex pattern = new Regex(@"^[ABCEGHJKLMNPRSTVXY][0-9][ABCEGHJKLMNPRSTVWXYZ][- ]?[0-9][ABCEGHJKLMNPRSTVWXYZ][0-9]$");
            if (!pattern.IsMatch(value)) // Return null if this isn't a postal code.
            {
                return null;
            }
            else
            {
                String newValue = "";
                // Use loop to remove any extra chars to format newValue as A0A0A0.
                for (int i = 0; i < value.Length; i++)
                {
                    if (Char.IsLetterOrDigit(value[i]))
                    {
                        newValue += value[i];
                    }
                }
                return newValue.Insert(3, " "); //Insert space into correct spot.
            }
        }

        #endregion

        #region 5. USA ZIP Code Validation
        /// <summary>
        /// Returns a boolean based on is Value is a USA ZIP Code
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// RETURNS TRUE WHEN GIVEN NULL TO STAY CONSISTENT WITH POSTAL CODE
        public static Boolean NSZipCodeValidation(String value)
        {
            if (String.IsNullOrEmpty(value))
            {
                return true;
            }
            string tempValue = NSZipCodeFormat(value);
            if (value == null)
            {
                return false;
            }else
            {
                value = NSZipCodeFormat(value);
                return true;
            }
        }

        #endregion

        #region 6. American ZIP Code Format
        /// <summary>
        /// Returns String value reformatted as a USA zip code, or null otherwise.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static String NSZipCodeFormat(String value)
        {
            value = NSExtractDigits(value);
            if (value == null || (value.Length != 5 && value.Length != 9))
            {
                return null;
            }
            else
            {
                if (value.Length == 5)
                {
                    return value;
                }
                else
                {
                    return value.Insert(5, "-");
                }
            }
        }

        #endregion

        #region 7. Full Name

        public static string NSFullName(string first, string last, string sFirst, string sLast)
        {

            if (String.IsNullOrEmpty(sFirst))
            {
                return (last + ", " + first);
            }
            else if (String.IsNullOrEmpty(sLast) || (sLast == last))
            {
                return last + ", " + first + " && " + sFirst;
            }
            else
            {
                return last + ", " + first + " && " + sLast + ", " + sFirst;
            }
        }

        #endregion

        #region 8. Telephone Number Validate
        /// <summary>
        /// Returns a boolean based on is Value is a Phone Number
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// /// RETURNS TRUE WHEN GIVEN NULL TO STAY CONSISTENT WITH POSTAL CODE
        public static Boolean TelephoneNumberValidate(String value)
        {
            if (String.IsNullOrEmpty(value))
            {
                return true;
            }
            value = TelephoneNumberFormat(value);
            if (value == null)
            {
                return false;
            }
            else if (value.Length == 12) // 12 because above method adds dashes
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion

        #region 9. Telephone Format
        /// <summary>
        /// Returns String value reformatted as a telephone number, or null otherwise.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static String TelephoneNumberFormat(String value)
        {
            value = NSExtractDigits(value);
            if (value == null)
            {
                return value;
            }
            else if (value.Length != 7 && value.Length != 10)
            {
                return null;
            }
            else
            {
                if (value.Length == 7)
                {
                    value = value.Insert(3, "-");
                    return value;
                }
                else
                {
                    value = value.Insert(3, "-").Insert(7, "-");
                    return value;
                }
            }
        }

        #endregion

        #region 10. Email Validation

        public static bool NSValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }

        #endregion

        #region 11. Year Joined Validation

        public static bool NSYearValidation(int? year)
        {
            try
            {
                return year <= DateTime.Today.Year;
            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion
        
        #region 12. IsInteger
        /// <summary>
        /// Returns true if the value is an integer.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Boolean IsInteger(String value)
        {
            return IsNumeric(value) && !value.Contains(".");
        }
        /// <summary>
        /// Returns true if the value is an integer.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Boolean IsInteger(Double value)
        {
            return IsInteger(value.ToString());
        }
        /// <summary>
        /// Returns true if the value is an integer.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Boolean IsInteger(Object value)
        {
            return IsInteger(value.ToString());
        }
        /// <summary>
        /// Returns true if the value is an integer.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Boolean IsInteger(Char value)
        {
            return IsInteger(value.ToString());
        }
        #endregion

        #region 13. IsNumeric
        /// <summary>
        /// Returns true if the value given is numeric.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Boolean IsNumeric(String value)
        {
            Regex pattern = new Regex(@"^-?(\d+\.?\d*|\.\d+)$");
            return pattern.IsMatch(value);
        }
        /// <summary>
        /// Returns true is the value given is numeric.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Boolean IsNumeric(Object value)
        {
            return IsNumeric(value.ToString());
        }
        #endregion

    }
}
