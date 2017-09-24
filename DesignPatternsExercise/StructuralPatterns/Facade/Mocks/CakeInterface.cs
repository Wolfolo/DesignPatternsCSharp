namespace DesignPatternsExercise.StructuralPatterns.Facade.Mocks
{
    interface ICake
    {
        void ShopForIngredients();

        void PrepareBase();

        void Wait();

        void PutInFridge();

        void PutInOven();

        void Decorate();

        void Pack();
    }
}
