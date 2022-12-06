internal class Task2
{
    class Box
    {
        private double length;
        private double width;
        private double height;

        public void Setbox()
        {
            Console.WriteLine("Enter a length: ");
            length = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter a width: ");
            width = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter a height: ");
            height = double.Parse(Console.ReadLine());
        }
        public void Getbox()
        {
            Console.WriteLine("Length: " + length + "\nWidth: " + width + "\nHeight: " + height);
        }
        public void Check()
        {
            if (length <= 0)
            {
                bool check = false;
                while (check == false)
                {
                    Console.WriteLine("Length cannot be zero or negative\n");
                    Setbox();
                    if (length > 0)
                    {
                        check = true;
                    }
                }
            }
            if (width <= 0)
            {
                bool check = false;
                while (check == false)
                {
                    Console.WriteLine("Width cannot be zero or negative\n");
                    Console.WriteLine("Vvedit zanovo peremennyy: ");
                    Setbox();
                    if (width > 0)
                    {
                        check = true;
                    }
                }
            }
            if (height <= 0)
            {
                bool check = false;
                while (check == false)
                {
                    Console.WriteLine("height cannot be zero or negative\n");
                    Setbox();
                    if (height > 0)
                    {
                        check = true;
                    }
                }
            }
        }
        public void Scale()
        {
            double surface_area = 2 * length * width + 2 * height * length + 2 * width * height;
            double lateral_surface_area = 2 * length * height + 2 * width * height;
            double volume = length * width * height;
            Console.WriteLine("\nSurface area: " + Math.Round(surface_area, 2) + "\nLateral surface area: " + Math.Round(lateral_surface_area, 2) + "\nVolume: " + Math.Round(volume, 2));

        }
    }
    static void Main()
    {
        Box box = new Box();
        box.Setbox();
        box.Getbox();
        box.Check();
        box.Scale();
    }
}