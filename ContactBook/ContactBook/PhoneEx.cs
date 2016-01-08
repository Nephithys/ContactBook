using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ContactBook
{
    class PhoneEx: dictoinaryTemp
    {
        SortedDictionary<string, string> myNumbers = new SortedDictionary<string, string>();
        public void PhoneNumBook()
        {

            
            myNumbers.Add("Belladon", "262-987-0543");
            myNumbers.Add("Veromos", "262-756-9532");
            myNumbers.Add("Lushen", "262-432-7294");
            myNumbers.Add("Wayne", "262-5302");
            myNumbers.Add("Jean", "262-091-2345");
            
        }

        public override void saveContacts()
        {
            StreamWriter sw = new StreamWriter("PhoneBook.txt");
            foreach (var contact in myNumbers)
            {
                sw.WriteLine(contact);
            }
            

            Console.WriteLine("Saving...");
            sw.Close();
        }

        //public string addContact()
        //{
        //    Console.WriteLine("Enter a name");
        //     string addedName= Console.ReadLine();
        //}
    }
}
