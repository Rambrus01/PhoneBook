using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Model
{
    public class PhoneNumber
    {

        public String number { get; private set; }
        public String owner { get; private set; }

        public PhoneNumber(String number, String owner)
        {
            this.number = number;
            this.owner = owner;
        }
    }

}
