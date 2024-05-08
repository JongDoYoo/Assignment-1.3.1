namespace Assignment_13._1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of the rectangle:");
            double length = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the width of the rectangle");
            double width = Convert.ToDouble(Console.ReadLine());

            double area= length * width;
            Console.WriteLine("The area of a rectangle is: " + area);
           
            // his example

        }   
        static double AreaOfTriangle(double width, double height)
        {
           return (width * height) / 2;
           
        }
        
        static double AreaOfSquare(double side) 
        {
            return side*side;
        }
        
        static double Area

    }
}
