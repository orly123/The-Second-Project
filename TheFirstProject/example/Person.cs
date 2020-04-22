using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Shop
{
    class Person
    {
        private int id;
        private string firstName;
        private string lastName;
        private Address address;

        public Person(int id, string firstName, string lastName, Address address)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
        }

        public int Id { get => id; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        internal Address Address { get => address; set => address = value; }

        public override string ToString()
        {
            return "Manager Id: " + this.id + "\n" +
                "Manager Name: " + this.firstName + " " + this.lastName + "\n" +
                "Manager Address: " + this.address.ToString();
        }

    }
}
