using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Shop
{
    class Shop
    {
        private int id;
        private string name;
        private Address address;
        private int size;
        private Person manager;
        private int totalPrice;
        private int numberOfInventory = 0;
        private List<Computer> computers;

        public Shop(int id)
        {
            this.id = id;
        }

        public Shop(int id, string name, Address address, int size, Person manager, List<Computer> computers)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.size = size;
            this.manager = manager;
            this.computers = computers;
        }

        public int Id { get => id; }
        public string Name { get => name; set => name = value; }
        public int Size { get => size; set => size = value; }
        public int TotalPrice { get => totalPrice; set => totalPrice = value; }
        public int NumberOfInventory { get => numberOfInventory; set => numberOfInventory = value; }
        internal Address Address { get => address; set => address = value; }
        internal Person Manager { get => manager; set => manager = value; }
        internal List<Computer> Computers { get => computers; set => computers = value; }

        public override string ToString()
        {
            string output = "";
            foreach (Computer item in this.computers)
            {
                output += item.ToString();
            }
            return "\nShop Id: " + this.id + "\n" +
                "Shop Name: " + this.name + "\n" +
                "Shop address: " + this.address.ToString() + "\n" +
                "Shop Size: " + this.size + "\n" +
                "Shop Manager->  \n" + this.manager.ToString() + "\n" +
                "Total Price: " + this.totalPrice + "\n" +
                "Inventory: \n" + "==============================" + output;

        }
    }
}