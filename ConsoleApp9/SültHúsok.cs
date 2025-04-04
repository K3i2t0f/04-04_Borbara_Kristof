using System;

namespace ConsoleApp9
{
    public class SültHúsok: Étel
    {
        public SültHúsok(double caloriesPerDkg, double weight, string name, bool isItDairyFree) : base(caloriesPerDkg, weight, name)
        {
            this.IsItDairyFree = isItDairyFree;
        }

        public override double CountCalories()
        {
            return (CaloriesPerDkg * Weight) / 100;
        }
    }
}