using StrategyPattern.Models;
using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ICar car = new Peoguet();

            if (args.Length > 0)
            {
                if(args[0] == "EL")
                    car = new Tesla();
            }

            Console.WriteLine($"Car name: {car.Make()}");

            Console.ReadLine();
        }
    }
}
