using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Shop
{
    class Address
    {
        private string city;
        private string street;
        private int apartment;


        public Address(string city, string street, int apartment)
        {
            this.city = city;
            this.street = street;
            this.apartment = apartment;
        }

        public string City { get => city; set => city = value; }
        public string Street { get => street; set => street = value; }
        public int Apartment { get => apartment; set => apartment = value; }

        public override string ToString()
        {
            return this.city + ", " + this.street + " " + this.apartment;
        }

    }
}
