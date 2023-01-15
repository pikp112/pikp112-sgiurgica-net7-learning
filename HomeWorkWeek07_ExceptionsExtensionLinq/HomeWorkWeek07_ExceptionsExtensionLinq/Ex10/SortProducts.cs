namespace HomeWorkWeek07_ExceptionsExtensionLinq.Ex10
{
    internal static class SortProducts
    {
        public static void Start()
        {
            var products = new List<Product>
            {
              new Product { Name = "Product 1", Category = "Category 1", Price = 10 },
              new Product { Name = "Product 2", Category = "Category 2", Price = 20 },
              new Product { Name = "Product 3", Category = "Category 1", Price = 15 },
              new Product { Name = "Product 4", Category = "Category 3", Price = 5 },
              new Product { Name = "Product 5", Category = "Category 3", Price = 5 }
            };

            var sortedListByPriceAsc = products.OrderBy(product => product.Price).ToList();
            Console.WriteLine("Sorted list by price in ascending order: ");
            PrintInfo(sortedListByPriceAsc);

            var sortedListByNameAlphab = products.OrderBy(product => product.Name).ToList();
            Console.WriteLine("Sorted list by name in alphabetical order:");
            PrintInfo(sortedListByNameAlphab);

            //Exercise 11:
            //the average price of the products in each category
            var averagePriceProductsByCategory1 = products.Where(product => product.Category == "Category 1")
                .Select(product => product.Price)
                .Average();
            Console.WriteLine($"For Category 1, average prices is {averagePriceProductsByCategory1}.");

            var averagePriceProductsByCategory2 = products.Where(product => product.Category == "Category 2")
                .Select(product => product.Price)
                .Average();
            Console.WriteLine($"For Category 2, average prices is {averagePriceProductsByCategory2}.");

            var averagePriceProductsByCategory3 = products.Where(product => product.Category == "Category 3")
                .Select(product => product.Price)
                .Average();
            Console.WriteLine($"For Category 3, average prices is {averagePriceProductsByCategory3}.");

            // a list of the categories sorted by average price in descending order
            //var sortedCategoriesByAveragePrices = products.Select(product => produ)
           
        }

        private static void PrintInfo(List<Product> sortedListByPriceAsc)
        {
            foreach (var product in sortedListByPriceAsc)
            {
                Console.WriteLine($"{product.Name} and {product.Price}");
            }
        }
    }
}
