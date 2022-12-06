using System.Security.Cryptography.X509Certificates;

internal class Task3
{
    class Chicken 
    {
        private string name;
        private int age;
        private int egg;

        public Chicken()
        {
            name = "Noname";
            age = 0;
        }
        public void SetChicken()
        {
            Console.WriteLine("Enter a name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter an age: ");
            age = int.Parse(Console.ReadLine());
        }
        
        public void Check()
        {
            if (name == " " || name == "")
            {
                bool check = false;
                while (check == false)
                {
                    Console.WriteLine("Name cannot be null, empty or whitespace\n");
                    SetChicken();
                    if (name != " " || name == "")
                    {
                        check = true;
                    }
                }
            }
            if (age <= 0 || age>15)
            {
                bool check = false;
                while (check == false)
                {
                    Console.WriteLine("Age cannot be negative or more than 15\n");
                    SetChicken();
                    if (age >= 0 && age<=15)
                    {
                        check = true;
                    }
                }
            }
        }
        public void ProductPerDay()
        {
            Random count = new Random();
            egg = count.Next(0, 10);
        }
        public void GetChicken()
        {
            Console.WriteLine("\nChicken " + name + " (age " + age + " ) can produce " + egg + " eggs per day.");
        }
    }

    static void Main()
    {
        Chicken chicken = new Chicken();
        chicken.SetChicken();
        chicken.Check();
        
        chicken.ProductPerDay();
        chicken.GetChicken();
    }
}