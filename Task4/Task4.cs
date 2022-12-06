using System;

internal class Program
{
    class Person
    {
        private string name;
        private double money;
        private string bag = "Empty";

        public void SetPerson()
        {
            Console.WriteLine("Enter a name: ");
            name = Console.ReadLine();
            if (name == " " || name == "")
            {
                bool b = false;
                while (b == false)
                {
                    Console.WriteLine("Name can not be empty: ");
                    SetPerson();
                    if (name != "" && name != " ")
                    {
                        b = true;
                    }
                }
            }
            Console.WriteLine("Enter a money: ");
            money = double.Parse(Console.ReadLine());
            if (money <= 0)
            {
                bool b = false;
                while (b == false)
                {
                    Console.WriteLine("Money can not be negative: ");
                    money = int.Parse(Console.ReadLine());
                    if (money > 0)
                    {
                       b = true;
                    }
                }
            }
        }

        public string GetName()
        {
            return name;
        }

        public void SetBag(Product b)
        {
            if (money - b.GetPrice() >= 0)
            {
                if (bag == "Empty")
                {
                    bag = name + " - ";
                }
                money -= b.GetPrice();
                bag += b.GetName() + " ";
            }
        }

        public double GetMoney()
        {
            return money;
        }

        public void GetBag()
        {
            if (bag == "Empty")
            {
                Console.WriteLine(name + " " + bag + "\n");
            }
            else
            {
                Console.WriteLine(bag + "\n");
            }
        }
    }
    class Product
    {
        private string name;
        private double price;


        public void SetProduct()
        {
            Console.WriteLine("Enter a product name: ");
            name = Console.ReadLine();
            if (name == " " || name == "")
            {
                bool b = false;
                while (b == false)
                {
                    Console.WriteLine("Name can not be empty: ");
                    SetProduct();
                    if (name != "" && name != " ")
                    {
                        b = true;
                    }
                }
            }
            Console.WriteLine("Enter a product price: ");
            price = double.Parse(Console.ReadLine());
            if (price <= 0)
            {
                bool b = false;
                while (b == false)
                {
                    Console.WriteLine("Price can not be negative: ");
                    SetProduct();
                    if (price > 0)
                    {
                        b = true;
                    }
                }
            }
        }

        public string GetName()
        {
            return name;
        }

        public double GetPrice()
        {
            return price;
        }
    }
    static void Main()
    {
        Console.WriteLine("Enter a count of people: ");
        int n = int.Parse(Console.ReadLine());
        Person[] person = new Person[n];

        for (int i = 0; i != n; i++)
        {
            person[i] = new Person();
            person[i].SetPerson();
            Console.WriteLine();
        }
        
        Console.WriteLine("Enter a count of product: ");
        n = int.Parse(Console.ReadLine());
        Product[] product = new Product[n];

        for (int i = 0; i != n; i++)
        {
            product[i] = new Product();
            product[i].SetProduct();
            Console.WriteLine();
        }
        while (true)
        {
            Console.WriteLine("Enter a person name: ");
            string temp_name = Console.ReadLine();
            int numberpersonu = -1;
            for (int i = 0; i != person.Length; i++)
            {
                if (temp_name == person[i].GetName())
                {
                    numberpersonu = i;
                }
            }
            if (numberpersonu == -1)
            {
                Console.WriteLine("Incorrect name");
                break;
            }
            else
            {
                Console.WriteLine("Enter a product name: ");
                string temp_name_product = Console.ReadLine();
                int numberproduct = -1;
                for (int i = 0; i != product.Length; i++)
                {
                    if (temp_name_product == product[i].GetName())
                    {
                        numberproduct = i;
                    }
                }
                if (numberproduct == -1)
                {
                    Console.WriteLine("Incorrect");
                    break;
                }
                else
                {
                    if (person[numberpersonu].GetMoney() - product[numberproduct].GetPrice() >= 0)
                    {
                        Console.WriteLine(person[numberpersonu].GetName() + " bought " + product[numberproduct].GetName() + "\n");
                        person[numberpersonu].SetBag(product[numberproduct]);
                    }
                    else
                    {
                        Console.WriteLine(person[numberpersonu].GetName() + " can not afford " + product[numberproduct].GetName() + "\n");
                    }
                }
            }
        }
        
        for (int i = 0; i != person.Length; i++)
        {
            person[i].GetBag();
            Console.WriteLine("\n");
        }

    }
}
