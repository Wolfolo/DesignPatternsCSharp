using System.Collections.Generic;

namespace DesignPatternsExercise.StructuralPatterns.Facade.Mocks
{
    internal class Cake : ICake
    {
        private List<string> log;

        public Cake(List<string> log)
        {
            this.log = log;
        }

        public void Decorate()
        {
            this.log.Add("Decorated!");
        }

        public void Pack()
        {
            this.log.Add("Packed for delivery!");
        }

        public void PrepareBase()
        {
            this.log.Add("Prepared the base!");
        }

        public void PutInFridge()
        {
            this.log.Add("Put in the fridge!");
        }

        public void PutInOven()
        {
            this.log.Add("Put in the oven!");
        }

        public void ShopForIngredients()
        {
            this.log.Add("Purchased the ingredients!");
        }

        public void Wait()
        {
            this.log.Add("Waiting...");
        }
    }
}