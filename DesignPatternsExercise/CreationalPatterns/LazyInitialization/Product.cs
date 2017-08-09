using System.Collections.Generic;

namespace DesignPatternsExercise.CreationalPatterns.LazyInitialization
{
    class Product
    {
        public string Name { get; private set; }

        private static Dictionary<string, Product> products = new Dictionary<string, Product>();

        private Product(string name)
        {
            Name = name;
        }

        public static Product GetProduct(string name)
        {
            if (products.ContainsKey(name))
            {
                return products[name];
            }

            var product = new Product(name);

            products.Add(name, product);

            return product;
        }

        public static List<Product> GetProducts()
        {
            var list = new List<Product>();

            foreach (Product p in products.Values)
            {
                list.Add(p);
            }

            return list;
        }

        /// <summary>
        /// This method is for testing only, since this is a global object and needs to be clean up
        /// </summary>
        public static void _Cleanup()
        {
            products.Clear();
        }
    }

}
