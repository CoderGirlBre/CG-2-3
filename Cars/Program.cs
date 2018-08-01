using System;

namespace Cars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the year of your first car: ");
            string year = Console.ReadLine();

            Console.Write("Enter the make of your first car: ");
            string make = Console.ReadLine();

            Console.Write("Enter the model name of your first car: ");
            string model = Console.ReadLine();

            Console.WriteLine("Your first car was a " + year + " " + make + " " + model + ".");
            Console.ReadLine();
        }
    }
}
