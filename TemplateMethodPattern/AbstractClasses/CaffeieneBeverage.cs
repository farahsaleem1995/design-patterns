namespace TemplateMethodPattern.AbstractClasses
{
    public abstract class CaffeieneBeverage
    {
        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            if (IsCondimentsWanted())
            {
                AddCondiments();
            }
        }

        protected void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }

        protected void PourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }

        protected virtual bool IsCondimentsWanted()
        {
            return true;
        }

        protected abstract void AddCondiments();

        protected abstract void Brew();
    }
}