using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adressbook
{
    class Adress
    {
        private String street;
        private UInt16 zip_code;
        private String city;

        public string Street
        {
            get
            {
                return street;
            }

            set
            {
                street = value;
            }
        }

        public ushort Zip_code
        {
            get
            {
                return zip_code;
            }

            set
            {
                zip_code = value;
            }
        }

        public string City
        {
            get
            {
                return city;
            }

            set
            {
                city = value;
            }
        }

        public void printAdress()
        {
            Console.WriteLine(Street);
            Console.WriteLine(Zip_code);
            Console.WriteLine(City);
        }

        public Adress(String street, UInt16 zip_code, String city)
        {
            this.Street = street;
            this.Zip_code = zip_code;
            this.City = city;
        }
    }
}
