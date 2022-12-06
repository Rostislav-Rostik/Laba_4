using System.ComponentModel.DataAnnotations;

internal class Program
{
    class Box
    {
        private double length;
        private double width;
        private double height;

        public double Length { get; set; }
        public double Width { get; set; }
        public int Height { get; set; }

        public void Scale(double length, double width, double height)
        {
            double surface_area = 2.0 * length * width + 2.0 * height * length + 2.0 * width * height;
            double lateral_surface_area = 2.0 * length * height + 2.0 * width * height;
            double volume = (double) length * width * height;
            Console.WriteLine("\nSurface area: " + Math.Round(surface_area, 2) + "\nLateral surface area: " + Math.Round(lateral_surface_area, 2) + "\nVolume: " + Math.Round(volume, 2));

        }
    }
    static void Main()
    {
        Box box = new Box();
        double length = double.Parse(Console.ReadLine());
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());
        
        box.Scale(length, width, height);
    }
}