using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactBook
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneEx myPhoneEx = new PhoneEx();
            myPhoneEx.PhoneNumBook();
            myPhoneEx.saveContacts();
        }
    }
}
