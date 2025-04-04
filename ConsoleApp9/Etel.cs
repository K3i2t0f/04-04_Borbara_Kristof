namespace ConsoleApp9
{
    public abstract class Étel
    {
        double caloriesPerDkg;
        double weight;
        string name;

        protected Étel(double caloriesPerDkg, double weight, string name)
        {
            this.caloriesPerDkg = caloriesPerDkg;
            this.weight = weight;
            this.name = name;
            this.IsItDairyFree = false;
        }

        public bool IsItDairyFree { get; set; }
        public double CaloriesPerDkg { get => caloriesPerDkg; }
        public double Weight { get => weight; }
        public string Name { get => name; }

        public abstract double CountCalories();
    }
}