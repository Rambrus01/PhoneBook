using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Model
{
    public class PhoneNumberManager
    {
        private List<PhoneNumber> phoneNumbers = new List<PhoneNumber>();

        private static PhoneNumberManager instance;
        public static PhoneNumberManager Instance()
        {
            if (instance == null)
            {
                instance = new PhoneNumberManager();
            }
            return instance;
        }

        public PhoneNumberManager()
        {
        }

        public void AddPhoneNumber(PhoneNumber phoneNumber)
        {
            phoneNumbers.Add(phoneNumber);
        }

        public void DeletePhoneNumber(PhoneNumber phoneNumber)
        {
            phoneNumbers.Remove(phoneNumber);
        }

        public List<PhoneNumber> getAllNumber()
        {
            return this.phoneNumbers;
        }
    }
}
