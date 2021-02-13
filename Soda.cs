using System;
using System.Globalization;

namespace SmartCOPDrinks
{
    public class Soda : Drink
    {
        public Soda() : base()
        {
            this.Name = "Pepsi";
            this.IsCarbonated = true;
            this.Title = this.Name.ToUpper();
        }

        public Soda(string sodaName, bool carbonation, bool hasALid, int tempFahrenheit) : base(sodaName, carbonation, hasALid, tempFahrenheit)
        {
            this.Name = sodaName;
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
    }
}