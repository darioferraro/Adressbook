using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Adressbook
{
    class Program
    {
        static void Main(string[] args)
        {
            Adressbook ab = new Adressbook();
            string name,street,city;
            ushort zipCode,age ;

            do
            {
                Console.Clear();
                Console.WriteLine("Möchten Sie eine Person erfassen? (j/n)");
                if (Console.ReadKey(true).Key == ConsoleKey.J)
                {
                    Console.Write("Name: ");
                    name = Console.ReadLine();
                    Console.Write("Age: ");
                    age = Convert.ToUInt16(Console.ReadLine());
                    Console.Write("Street: ");
                    street = Console.ReadLine();
                    Console.Write("ZipCode: ");
                    zipCode = Convert.ToUInt16(Console.ReadLine());
                    Console.Write("City: ");
                    city = Console.ReadLine();

                    Person aPerson = new Person(name, age);
                    aPerson.MyAdress.Street = street;
                    aPerson.MyAdress.Zip_code = zipCode;
                    aPerson.MyAdress.City = city;
                    ab.addPerson(aPerson);
                }

                Console.Clear();
                Console.WriteLine("Möchten Sie den Speicher der erfassten Personen anzeigen? (j/n)");
                if (Console.ReadKey(true).Key == ConsoleKey.J)
                {
                    ab.PrintAdressBook();
                    Console.ReadLine();

                }

                Console.Clear();
                Console.WriteLine("Möchten Sie die erfassten Personen abspeichern? (j/n)");
                if (Console.ReadKey(true).Key == ConsoleKey.J)
                {
                    ab.WriteToFile();
                }

                Console.Clear();
                Console.WriteLine("Möchten Sie die abgespeicherten Personen lesen? (j/n)");
                if (Console.ReadKey(true).Key != ConsoleKey.J)
                {
                    Console.WriteLine("Drücken sie 'A' um zu beenden");
                }
                else
                {
                    ab.ReadFromFile();
                    ab.PrintAdressBook();
                }



            } while (Console.ReadKey(true).Key != ConsoleKey.A);

            Console.WriteLine("und tschüss ....");
            System.Threading.Thread.Sleep(1000);


        }
    }
}
