using System.Collections.Generic;

namespace DesignPatternsExercise.StructuralPatterns.Facade.Mocks
{
    class CakeFacade
    {
        public List<string> Make(bool decorateBeforeBaking)
        {
            List<string> log = new List<string>();

            ICake food = new Cake(log);

            food.ShopForIngredients();
            food.PrepareBase();

            if (decorateBeforeBaking)
            {
                food.Decorate();
                food.PutInOven();
                food.Wait();
            }
            else
            {
                food.PutInOven();
                food.Wait();
                food.Decorate();
                food.PutInFridge();
                food.Wait();
            }
            
            food.Pack();

            return log;
        }
    }
}
