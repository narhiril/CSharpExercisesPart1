using System;

namespace Numeric_Types_2_5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //part 3
            Console.WriteLine("Enter how many miles you drove:");
            float inputMiles = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter how many gallons of gas you used:");
            float inputGas = float.Parse(Console.ReadLine());
            Console.WriteLine($"You got {Program.MilesPerGallon(inputGas, inputMiles)} miles per gallon");
            Console.ReadLine();
        }

        public static double MilesPerGallon(float gas, float miles) //part 3
        {
            return Math.Truncate(((double)miles / (double)gas) * 100d) / 100d;
        }
    }
}
