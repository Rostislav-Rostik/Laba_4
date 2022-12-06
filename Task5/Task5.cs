using System.Security.AccessControl;
using System.Transactions;
using System.Xml;

internal class Task5
{
    class Dough
    {
        private string flour;
        private string technics;
        private double mass;
        private double k = 0;
        
        public void SetDough()
        {
            double mflour;
            double mtechnics;
            Console.WriteLine("Enter a flour: ");
            flour = Console.ReadLine();
            if (flour == "white")
            {
                mflour = 1.5;
            }
            else if (flour == "wholegrain")
            {
                mflour = 1.0;
            }
            else
            {
                Console.WriteLine("Incorrect flour, your default value is 1.5");
                mflour = 1.5;
            }
            Console.WriteLine("Enter a technic: ");
            technics = Console.ReadLine();
            if (technics == "crispy")
            {
                mtechnics = 0.9;
            }
            else if (technics == "chewy")
            {
                mtechnics = 1.1;
            }
            else if (technics == "homemade")
            {
                mtechnics = 1.0;
            }
            else
            {
                Console.WriteLine("Incorrect technic");
                mtechnics = 0.9;
            }

            Console.WriteLine("Enter a dough mass: ");
            mass = double.Parse(Console.ReadLine());
            if (mass < 1 || mass > 200)
            {
                Console.WriteLine("Dough weight should be in the range [1 - 200], your default value is 100");
                mass = 100;
            }
            k = (2 * mass) * mflour * mtechnics;
            
        }
        public double GetK()
        {
            return k;
        }
    }
    class Topping 
    {
        private string topp;
        private double m;
        private int weight;
        public void SetTopping()
        {
            double mtopp;
            Console.WriteLine("Enter a topping: ");
            topp = Console.ReadLine();
            if (topp == "meat")
            {
                mtopp = 1.2;
            }
            else if(topp == "veggies")
            {
                mtopp = 0.8;
            }
            else if (topp == "cheese")
            {
                mtopp = 1.1;
            }
            else if (topp == "sauce")
            {
                mtopp = 0.9;
            }
            else
            {
                Console.WriteLine("Incorrect value");
                mtopp = 2;
            }
            Console.WriteLine("Enter a weight: ");
            weight = int.Parse(Console.ReadLine());
            if (weight<1 || weight > 50)
            {
                Console.WriteLine("Meat weight should be in the range [1 - 50], default maet weight is 35");
                weight = 35;
            }
            m = 2 * weight * mtopp;
            
        }
        public double GetM()
        {
            return m;
        }
    }
    class Pizza
    {
        private string name;
        private int count;
        private Dough flour = new Dough();
        private Topping topp = new Topping();
        private double k = 0;
        public void SetPizza()
        {
            Console.WriteLine("Enter a pizza name: ");
            name = Console.ReadLine();
            if (name.Length > 15 || name.Length < 1)
            {
                
                bool temp = false;
                while (temp == false)
                {
                    Console.WriteLine("Incorrect name");
                    SetPizza();
                    if (name.Length < 15 && name.Length > 1)
                    {
                        temp = true;
                    }
                }
            }
            flour.SetDough();
            k += flour.GetK();  
            Console.WriteLine("Enter a count: ");
            count = int.Parse(Console.ReadLine());
            if (count < 0 || count > 10)
            {
                Console.WriteLine("Number of toppings should be in range [0-10], default value is 0");
                count = 0;
            }
            for (int i = 0; i < count; i++)
            {
                topp.SetTopping();
                k += topp.GetM();
            }
        }
        public void GetPizza()
        {
            Console.WriteLine(name + " - " + k + " Calories.");
        }
    }
    static void Main()
    {
        
        Pizza pizza = new Pizza();
        pizza.SetPizza();
        pizza.GetPizza();
    }
}