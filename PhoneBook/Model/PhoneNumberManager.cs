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
    }
}
