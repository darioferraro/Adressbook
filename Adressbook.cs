using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adressbook
{
    class Adressbook
    {
        private String fileName = @"..\..\Adressbook.csv";
        private List<Person> myAdressbook = new List<Person>();

        public bool ContainPerson(Person aPerson)
        {
            //////// überprüft in der Liste myAdressbook, ob die Person schon existiert
            /// /////////////////////////////////////////////////
            /// Aufgabe 4
            /// 
            ////////////////////////////////////////////////
            ///
            return false;
        }
        public void addPerson(Person aPerson)
        {
            if (!ContainPerson(aPerson))
            {
                myAdressbook.Add(aPerson);
            }
            

        }

        public void PrintAdressBook()
        {
            /////////////////////////////////////////////////
            /// Aufgabe 2
            /// 
            ////////////////////////////////////////////////
        }

        public void WriteToFile()
        {
          
            try 
            {
                /////////////////////////////////////////////////
                /// Aufgabe 1
                /// 
                ////////////////////////////////////////////////
            }
            catch(Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);

            }
            

        }

        public void ReadFromFile()
        {
            try
            {
                /////////////////////////////////////////////////
                /// Aufgabe 3
                /// 
                ////////////////////////////////////////////////
            }
            catch (Exception e)
            {
                
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }
    }
}
