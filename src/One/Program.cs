using System;
using System.IO;
using System.Linq;

namespace One
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("MassData.txt");

            var masses = lines.ToList().Select(x => int.Parse(x));

            var fuels = masses.Select(mass => Calculator.GetFinalFuelForFuel(Calculator.GetFuel(mass)));

            var totalInitialFuel = fuels.Sum();

            Console.WriteLine($"Fuel Required for Mass: {totalInitialFuel}");
        }
    }
}