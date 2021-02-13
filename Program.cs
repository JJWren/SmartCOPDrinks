using System;
using System.Collections.Generic;

// namespace links each class together via 'SmartCOPDrinks'
namespace SmartCOPDrinks
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create list of drink instances
            List<Drink> drinks = new List<Drink>()
            {
                new Soda(),
                new Beer(),
                new Juice(),
                new Soda("Sprite", true, true, 38),
                new Beer("Yuengling", true, 4.4, false, 32),
                new Juice("grape", true, false, 212)
            };
            // Output description for each drink instance
            foreach (var drink in drinks)
            {
                drink.Description();
            }
            // The above drink method will log each description on a new line. If it is necessary to be on a single line, the Console.WriteLine() can be changed to a Console.Write() instead.
        }
    }
}
