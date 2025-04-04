using System;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Étel> etterem = new List<Étel>
            {
                new Levesek(50, 200, "Husleves", true),
                new Levesek(30, 150, "paradicsomleves", false),
                new Levesek(40, 180, "Lencseleves", true),
                new Kenyérfélék(60, 250, "feher", false),
                new Kenyérfélék(60, 250, "barna", false),
                new Kenyérfélék(60, 250, "banan", false),
                new SültHúsok(80, 300, "Sült csirke", true),
                new SültHúsok(90, 350, "Sült marha", false),
                new SültHúsok(100, 400, "Sült sertés", true),
            };

            double totalCalories = SumCalories(etterem);
            Console.WriteLine($"Az ételek összkalóriája: {totalCalories} kcal");

            List<Étel> dairyFreeFoods = FilterDairyFree(etterem);

            Console.WriteLine("Tejmentes ételek:");
            foreach (var food in dairyFreeFoods)
            {
                Console.WriteLine($"{food.Name} - {food.CountCalories()} kcal");
            }

            double totalDairyFreeCalories = SumCalories(dairyFreeFoods);
            Console.WriteLine($"A tejmentes ételek összkalóriája: {totalDairyFreeCalories} kcal");
        }

        static double SumCalories(List<Étel> foods)
        {
            return foods.Sum(food => food.CountCalories());
        }

        static List<Étel> FilterDairyFree(List<Étel> foods)
        {
            return foods.Where(food => food.IsItDairyFree).ToList();
        }
    }
}