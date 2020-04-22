using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Shop
{
    class Computer
    {
        private int id;
        private string company;
        private string processor;
        private string hardType;
        private int hardSize;
        private int price;
        private int quantity;



        public Computer(int id)
        {
            this.id = id;
        }

        public Computer(int id, string company, string processor, string hardType, int hardSize, int price, int quantity)
        {
            this.id = id;
            this.company = company;
            this.processor = processor;
            this.hardType = hardType;
            this.hardSize = hardSize;
            this.price = price;
            this.quantity = quantity;
        }

        public int Id { get => id; }
        public string Company { get => company; set => company = value; }
        public string Processor { get => processor; set => processor = value; }
        public string HardType { get => hardType; set => hardType = value; }
        public int HardSize { get => hardSize; set => hardSize = value; }
        public int Price { get => price; set => price = value; }
        public int Quantity { get => quantity; set => quantity = value; }

        public override string ToString()
        {
            return "\nComputer Id: " + this.id + "\n" +
                "company: " + this.company + "\n" +
                "processor: " + this.processor + "\n" +
                "hardType: " + this.hardType + "\n" +
                "hardSize: " + this.hardSize + "\n" +
                "price: " + this.price + "\n" +
                "quantity: " + this.quantity + "\n" +
                "==============================";
        }
    }


}