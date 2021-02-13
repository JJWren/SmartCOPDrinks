using System;
using System.Globalization;

namespace SmartCOPDrinks
{
    public class Juice : Drink
    {
        public string Fruit;
        public Juice() : base()
        {
            this.Fruit = "orange";
            this.Name = this.Fruit + " juice";
            this.Title = this.Name.ToUpper();
        }

        public Juice(string fruitMakeup, bool carbonation, bool hasALid, int tempFahrenheit)
        {
            this.Fruit = fruitMakeup;
            this.Name = this.Fruit + " juice";
            this.IsCarbonated = carbonation;
            this.HasLid = hasALid;
            this.Temperature = tempFahrenheit;

            if (IsCarbonated)
            {
                this.Title = $"carbonated {this.Name}";
            }
            else
            {
                this.Title = this.Name;
            }

            this.Title = this.Title.ToUpper();
        }

        public override void Description()
        {
            // doesn't account for strange user input
            // grape and banana => grape and bananas | No plurality for 'grape'
            Console.Write($"\n{this.Title}: made from {this.Fruit}s, ");

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
        }
    }
}