using System;
using System.Globalization;

namespace SmartCOPDrinks
{
    abstract class Drink
    {
        // Fields
        protected string Name;
        protected bool IsCarbonated;
        public bool HasLid;
        protected int Temperature;
        protected string Title;

        // Constructor with default values
        protected Drink()
        {
            this.Name = "water";
            this.IsCarbonated = false;
            this.HasLid = true;
            this.Temperature = 40;
            this.Title = this.Name.ToUpper();
        }

        // Method: Gives description of drink
        // 'virtual' allows for override on subclasses of 'Drink'
        internal virtual void Description()
        {
            Console.Write($"\n{this.Title}: ");

            if (this.HasLid)
            {
                Console.Write("has lid, ");
            }
            else
            {
                Console.Write("no lid, ");
            }

            if (this.Temperature >= 212)
            {
                Console.Write("BOILING HOT");
            }
            else if (this.Temperature >= 100 && this.Temperature < 212)
            {
                Console.Write("kind of hot");
            }
            else if (this.Temperature >= 60 && this.Temperature < 100)
            {
                Console.Write("warm");
            }
            else if (this.Temperature > 32)
            {
                Console.Write("cold");
            }
            else
            {
                Console.Write("FREEZING");
            }

            if (this.IsCarbonated && this.Temperature >= 60)
            {
                Console.WriteLine(", was carbonated before it got too hot.");
            }
            else if (this.IsCarbonated && this.Temperature <= 32)
            {
                Console.WriteLine(", was carbonated before it froze.");
            }
            else
            {
                Console.WriteLine(".");
            }
            // Afterthought: Could refactor temperature and carbonation checks together...
        }
    }
}