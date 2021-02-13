using System;
using System.Globalization;

namespace SmartCOPDrinks
{
    public class Beer : Drink
    {
        public double AlcoholContent;
        public bool IsDraft;
        public Beer() : base()
        {
            this.Name = "Budweiser";
            this.IsDraft = false;
            this.AlcoholContent = 5;
            this.IsCarbonated = true;
            this.Title = this.Name.ToUpper();
        }

        public Beer(string beerName, bool draft, double alcContent, bool carbonation, int tempFahrenheit)
        {
            this.Name = beerName;
            this.IsDraft = draft;
            this.AlcoholContent = alcContent;
            this.IsCarbonated = carbonation;
            if (IsDraft)
            {
                this.HasLid = false;
            }
            else
            {
                this.HasLid = true;
            }
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
            if (this.IsDraft)
            {
                Console.Write($"\n{this.Title}: draft, {this.AlcoholContent}% ABV, ");
            }
            else
            {
                Console.Write($"\n{this.Title}: not draft, {this.AlcoholContent}% ABV, ");
            }

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