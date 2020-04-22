using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Computer_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shop> shopList = new List<Shop>();

            int id;
            bool flag;
            int shop = -1;
            int shopNotFound = -1;
            int shopId;
            int price = 0;
            string name;
            string city;
            string street;
            int apartment;
            int managerId;
            string managerFname;
            string managerLname;
            int shopCounter = 0;
            int addressInput;
            int addressOption1 = 1;
            int addressOption2 = 2;
            int addressOption3 = 3;
            int shopOption1 = 1;
            int shopOption2 = 2;
            int shopOption3 = 3;
            int shopOption4 = 4;
            int shopOption5 = 5;
            int shopOption6 = 6;
            int shopOption7 = 7;
            int shopExit = 8;
            int option1 = 1;
            int option2 = 2;
            int option3 = 3;
            int option4 = 4;
            int option5 = 5;
            int exit = 6;
            List<Computer> computers1 = new List<Computer>();
            Computer computer1 = new Computer(999, "Asus", "Intel i7", "SSD", 1024, 3000, 1);
            Computer computer2 = new Computer(998, "Lenovo", "Intel i5", "SATA", 2048, 1750, 1);
            computers1.Add(computer1);
            computers1.Add(computer2);
            Address address1 = new Address("Tel Aviv", "Balfur", 22);
            Address address2 = new Address("Beer Sheva", "Shahal", 9);
            Person manager1 = new Person(999999999, "Tester", "McTest", address1);
            Shop shop1 = new Shop(999, "Test Shop", address2, 55, manager1, computers1);
            shopList.Add(shop1);



            Console.WriteLine(
              "Please input your option -> \n\n" +
              "1-Add new shop \n" +
              "2-Show shop list \n" +
              "3-Show shop computers list\n" +
              "4-Find shop by address \n" +
              "5-Find all shops of the current manager \n" +
              "6-Manage shop by ID\n" +
              "7-Remove shop\n" +
              "8-Exit");


            int shopInput = int.Parse(Console.ReadLine());

            while (shopInput != shopExit)
            {
                if (shopInput < shopOption1 || shopInput > shopExit)
                {
                    Console.WriteLine("Invalid Key!");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    Console.Clear();

                }
                if (shopInput == shopOption1)
                {
                    shopList.Add(new Shop(shopCounter));

                    Console.Write("Input shop name: ");
                    shopList[shopCounter].Name = Console.ReadLine();
                    Console.Write("Input shop address -> \n");
                    Console.Write("Input City: ");
                    city = Console.ReadLine();
                    Console.Write("Input Street: ");
                    street = Console.ReadLine();
                    Console.Write("Input Apartment: ");
                    apartment = int.Parse(Console.ReadLine());
                    shopList[shopCounter].Address = new Address(city, street, apartment);

                    Console.Write("Input shop size: ");
                    shopList[shopCounter].Size = int.Parse(Console.ReadLine());

                    Console.WriteLine("Input shop manager -> \n");
                    Console.Write("Input Manager Id: ");
                    managerId = int.Parse(Console.ReadLine());
                    Console.Write("Input Manager First Name: ");
                    managerFname = Console.ReadLine();
                    Console.Write("Input Manager Last Name: ");
                    managerLname = Console.ReadLine();
                    Console.WriteLine("input manager address: \n");

                    Console.Write("Input City: ");
                    city = Console.ReadLine();
                    Console.Write("Input Street: ");
                    street = Console.ReadLine();
                    Console.Write("Input Apartment: ");
                    apartment = int.Parse(Console.ReadLine());

                    shopList[shopCounter].Manager = new Person(managerId, managerFname, managerLname, new Address(city, street, apartment));

                    shopList[shopCounter].Computers = new List<Computer>();

                    shopCounter++;

                    Console.WriteLine("\nA new shop has been added!");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    Console.Clear();

                }
                if (shopInput == shopOption2)
                {
                    for (int i = 0; i < shopList.Count; i++)
                    {
                        Console.WriteLine(shopList[i].ToString());
                    }
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                }

                if (shopInput == shopOption3)
                {
                    Console.Write("Input shop Id: ");
                    shopId = int.Parse(Console.ReadLine());
                    flag = true;
                    for (int i = 0; i < shopList.Count; i++)
                    {
                        if (shopList[i].Id == shopId)
                        {
                            for (int j = 0; j < shopList[i].Computers.Count; j++)
                            {
                                Console.WriteLine(shopList[i].Computers[j].ToString());
                            }
                            flag = false;
                        }
                        if (flag) Console.WriteLine("Shop Id not found");
                    }
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                }
                if (shopInput == shopOption4)
                {
                    Console.WriteLine("Choose Address detail: \n" +
                        "1->City \n" +
                        "2->Street \n" +
                        "3->Apartment number");

                    addressInput = int.Parse(Console.ReadLine());

                    if (addressInput == addressOption1)
                    {
                        Console.WriteLine("Input City name: ");
                        city = Console.ReadLine();
                        flag = true;
                        for (int i = 0; i < shopList.Count; i++)
                        {
                            if (shopList[i].Address.City == city) Console.WriteLine(shopList[i].ToString());
                            flag = false;
                        }
                        if (flag) Console.WriteLine(city + " Not found!");
                    }
                    if (addressInput == addressOption2)
                    {
                        Console.WriteLine("Input Street name: ");
                        street = Console.ReadLine();
                        flag = true;
                        for (int i = 0; i < shopList.Count; i++)
                        {
                            if (shopList[i].Address.Street == street) Console.WriteLine(shopList[i].ToString());
                            flag = false;
                        }
                        if (flag) Console.WriteLine(street + " Not found!");
                    }
                    if (addressInput == addressOption3)
                    {
                        Console.WriteLine("Input Apartment number: ");
                        apartment = int.Parse(Console.ReadLine());
                        flag = true;
                        for (int i = 0; i < shopList.Count; i++)
                        {
                            if (shopList[i].Address.Apartment == apartment) Console.WriteLine(shopList[i].ToString());
                            flag = false;
                        }
                        if (flag) Console.WriteLine(apartment + " Not found!");
                    }
                    if (addressInput < addressOption1 || addressInput > addressOption3) Console.WriteLine("Invalid key.");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                }
                if (shopInput == shopOption5)
                {
                    Console.WriteLine("Input Manager Id: ");
                    id = int.Parse(Console.ReadLine());
                    flag = true;
                    for (int i = 0; i < shopList.Count; i++)
                    {
                        if (shopList[i].Manager.Id == id)
                        {
                            Console.WriteLine(shopList[i].ToString());
                            flag = false;
                        }
                    }
                    if (flag)
                    {
                        Console.WriteLine("Manager not found");
                    }
                }

                if (shopInput == shopOption6)
                {

                    Console.WriteLine("Input Shop Id: ");
                    shopId = int.Parse(Console.ReadLine());

                    for (int i = 0; i < shopList.Count; i++)
                    {
                        if (shopList[i].Id == shopId)
                        {
                            shop = i;
                        }
                    }
                    if (shop != shopNotFound)
                    {
                        Console.WriteLine(
                            "Please input your option -> \n\n" +
                            "1->Add new computer \n" +
                            "2->Remove computer \n" +
                            "3->Print computer list by Company Name \n" +
                            "4->Print list of the computers \n" +
                            "5->Calculate the total price of the computers \n" +
                            "6->Exit");

                        int input = int.Parse(Console.ReadLine());

                        while (input != exit)
                        {
                            if (input == option1)
                            {
                                shopList[shop].Computers.Add(new Computer(shopList[shop].NumberOfInventory));

                                Console.Write("input company name: ");
                                shopList[shop].Computers[shopList[shop].NumberOfInventory].Company = Console.ReadLine();
                                Console.Write("Enter the processor type: ");
                                shopList[shop].Computers[shopList[shop].NumberOfInventory].Processor = Console.ReadLine();
                                Console.Write("Enter the hard disk type: ");
                                shopList[shop].Computers[shopList[shop].NumberOfInventory].HardType = Console.ReadLine();
                                Console.Write("Enter the  hard disk size: ");
                                shopList[shop].Computers[shopList[shop].NumberOfInventory].HardSize = int.Parse(Console.ReadLine());
                                Console.Write("Enter the price: ");
                                shopList[shop].Computers[shopList[shop].NumberOfInventory].Price = int.Parse(Console.ReadLine());
                                Console.Write("Enter the quantity: ");
                                shopList[shop].Computers[shopList[shop].NumberOfInventory].Quantity = int.Parse(Console.ReadLine());
                                shopList[shop].NumberOfInventory++;

                                shopList[shop].TotalPrice = shopList[shop].Computers[shopList[shop].NumberOfInventory].Price * shopList[shop].Computers[shopList[shop].NumberOfInventory].Quantity;
                                Console.WriteLine("\nA new computer has been added");
                                Console.WriteLine("Press any key to continue...");
                                Console.ReadKey();
                                Console.Clear();

                            }
                            if (input == option2)
                            {
                                if (shopList[shop].Computers.Count > 0)
                                {
                                    for (int i = 0; i < shopList[shop].Computers.Count; i++) Console.WriteLine(shopList[shop].Computers[i].ToString());

                                    Console.Write("Input the id of the computer you want to remove -> ");
                                    id = int.Parse(Console.ReadLine());
                                    for (int i = 0; i < shopList[shop].Computers.Count; i++)
                                    {
                                        if (shopList[shop].Computers[i].Id == id) shopList[shop].Computers.Remove(shopList[shop].Computers[i]);
                                    }

                                    if (shopList[shop].Computers.Count == 0)
                                    {
                                        Console.WriteLine("There is nothing on the list");
                                    }
                                    else
                                    {
                                        Console.WriteLine("\nThe list after the change: ");
                                        for (int i = 0; i < shopList[shop].Computers.Count; i++) Console.WriteLine(shopList[shop].Computers[i].ToString());
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("There is nothing on the list");
                                }
                                Console.WriteLine("Press any key to continue...");
                                Console.ReadKey();
                                Console.Clear();
                            }
                            if (input == option3)
                            {
                                Console.WriteLine("Enter the company name: ");
                                name = Console.ReadLine();
                                for (int i = 0; i < shopList[shop].Computers.Count; i++)
                                {
                                    if (shopList[shop].Computers[i].Company == name) Console.WriteLine(shopList[shop].Computers[i].ToString());
                                }
                            }
                            if (input == option4)
                            {
                                if (shopList[shop].Computers.Count > 0)
                                {
                                    for (int i = 0; i < shopList[shop].Computers.Count; i++) Console.WriteLine(shopList[shop].Computers[i].ToString());
                                }
                                else Console.WriteLine("There is nothing on the list");

                                Console.WriteLine("Press any key to continue...");
                                Console.ReadKey();
                                Console.Clear();
                            }

                            if (input == option5)
                            {
                                for (int i = 0; i < shopList[shop].Computers.Count; i++) price += shopList[shop].Computers[i].Price;
                                Console.WriteLine("The price is: " + price);
                                Console.WriteLine("Press any key to continue...");
                                Console.ReadKey();
                                Console.Clear();

                            }
                            Console.WriteLine(
                               "Please input your option -> \n\n" +
                               "1->Add new computer \n" +
                               "2->Remove computer \n" +
                               "3->Print computer list by Company Name \n" +
                               "4->Print list of the computers \n" +
                               "5->Calculate the total price of the computers \n" +
                               "6->Exit");

                            input = int.Parse(Console.ReadLine());
                        }
                        Console.Clear();
                    }
                }
                if (shopInput == shopOption7)
                {
                    if (shopList.Count > 0)
                    {
                        for (int i = 0; i < shopList.Count; i++) Console.WriteLine(shopList[i].ToString());

                        Console.Write("Input the id of the shop you want to remove -> ");
                        id = int.Parse(Console.ReadLine());
                        flag = true;
                        for (int i = 0; i < shopList.Count; i++)
                        {

                            if (shopList[i].Id == id)
                            {
                                shopList.Remove(shopList[i]);
                                flag = false;
                            }
                        }
                        if (flag) Console.WriteLine("Shop ID not found!");
                        else
                        {
                            if (shopList.Count == 0) Console.WriteLine("There are no Shops on the list anymore!");
                            else
                            {
                                Console.WriteLine("\nThe list after the change: \n");
                                for (int i = 0; i < shopList.Count; i++) Console.WriteLine(shopList[i].ToString());
                            }
                        }
                    }
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                }
                Console.WriteLine(
                       "Please input your option -> \n\n" +
                       "1-Add new shop \n" +
                       "2-Show shop list \n" +
                       "3-Show shop computers list\n" +
                       "4-Find shop by address \n" +
                       "5-Find all shops of the current manager \n" +
                       "6-Manage shop by ID\n" +
                       "7-Remove shop\n" +
                       "8-Exit");
                shopInput = int.Parse(Console.ReadLine());
            }
        }
    }
}

