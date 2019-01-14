using System.IO;
namespace NathanSacconAssignment1.Models
{
    public class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Contact()
        {
            string[] names = ReadContact();
            FirstName = names[0];
            LastName = names[1];
        }
        public static string[] ReadContact()
        {
            // Read from file contact.txt
            string contact = File.ReadAllText(@"C:\OIC\Data\Contact.txt");
            char[] seperator = {' '};
            return contact.Split(seperator);
        }
        public static void WriteContact(string first, string last)
        {
            File.WriteAllText(@"C:\OIC\Data\Contact.txt", first + " " + last);
        }
    }
}