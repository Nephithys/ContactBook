using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ContactBook
{
    class dictoinaryTemp 
    {

        
        public virtual void saveContacts()
        {

            StreamWriter sw = new StreamWriter("group.txt");
            
            sw.Write("411");
            
            Console.WriteLine("Saving...");
            sw.Close();

        }
    }
}
