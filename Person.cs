using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adressbook
{
    class Person
    {
        private  string name;
        private  ushort age;
        private Adress myAdress;

        public Adress MyAdress
        {
            get
            {
                return myAdress;
            }

            set
            {
                myAdress = value;
            }
        }

        public ushort Age { get => age;  }
        public string Name { get => name;  }

        public void printPerson()
        {
            Console.WriteLine(name);
            Console.WriteLine(age);
            MyAdress.printAdress();
            Console.WriteLine("*********************************\n");

        }


        public Person (string name, ushort age)
        {
            this.name = name;
            this.age = age;
            MyAdress = new Adress("N/A",0, "N/A");
        }
    }
}
