using System;

namespace Numeric_Types_2_5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //part 2
            Console.WriteLine("The area of the rectangle is " + Program.RectangleArea());
            Console.ReadLine();
        }

        public static int RectangleArea()
        {
            Console.WriteLine("Enter the length of the rectangle:");
            string inputLength = Console.ReadLine();
            Console.WriteLine("Enter the width of the rectangle:");
            string inputWidth = Console.ReadLine();
            int length = Int32.Parse(inputLength);
            int width = Int32.Parse(inputWidth);
            return length * width;
        }
    }
}
