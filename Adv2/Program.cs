using System;
using System.Collections.Generic;

namespace Adv2
{
    #region Models
    //public class Product
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public string Category { get; set; }
    //    public double Price { get; set; }
    //    public int Stock { get; set; }
    //}
    #endregion

    internal class Program
    {
        #region Catalog Data
        //static List<Product> catalog = new List<Product>
        //{
        //    new Product { Id = 1, Name = "Laptop", Category = "Electronics", Price = 1200, Stock = 10 },
        //    new Product { Id = 2, Name = "Phone", Category = "Electronics", Price = 800, Stock = 25 },
        //    new Product { Id = 3, Name = "T-Shirt", Category = "Clothing", Price = 30, Stock = 100 },
        //    new Product { Id = 4, Name = "Jeans", Category = "Clothing", Price = 60, Stock = 50 },
        //    new Product { Id = 5, Name = "Chocolate", Category = "Food", Price = 5, Stock = 200 },
        //    new Product { Id = 6, Name = "Coffee Beans", Category = "Food", Price = 15, Stock = 80 },
        //    new Product { Id = 7, Name = "C# Book", Category = "Books", Price = 45, Stock = 30 },
        //    new Product { Id = 8, Name = "Novel", Category = "Books", Price = 20, Stock = 60 },
        //    new Product { Id = 9, Name = "Headphones", Category = "Electronics", Price = 150, Stock = 40 },
        //    new Product { Id = 10, Name = "Jacket", Category = "Clothing", Price = 120, Stock = 15 }
        //};
        #endregion

        #region Delegate Methods

        #region Task 01 - Search Products Method
        // Func<Product, bool> is used to accept a filter condition that takes a Product and returns bool.
        //static List<Product> SearchProducts(List<Product> products, Func<Product, bool> filter)
        //{
        //    List<Product> result = new List<Product>();

        //    foreach (Product product in products)
        //    {
        //        if (filter(product))
        //        {
        //            result.Add(product);
        //        }
        //    }

        //    return result;
        //}
        #endregion

        #region Task 03.1 - Print Report Method
        // Action<Product> is used because it performs an action (printing) on each product and returns void.
        //static void PrintReport(List<Product> products, Action<Product> action)
        //{
        //    foreach (Product product in products)
        //    {
        //        action(product);
        //    }
        //}
        #endregion

        #region Task 03.2 - Transform Products Method
        // Func<Product, string> is used to transform a Product into a new string representation.
        //static List<string> TransformProducts(List<Product> products, Func<Product, string> transform)
        //{
        //    List<string> result = new List<string>();

        //    foreach (Product product in products)
        //    {
        //        result.Add(transform(product));
        //    }

        //    return result;
        //}
        #endregion

        #region Task 03.3 - Filter Products Method
        // Predicate<Product> is a built-in delegate specifically designed for condition testing (returns bool).
        //static List<Product> FilterProducts(List<Product> products, Predicate<Product> predicate)
        //{
        //    List<Product> result = new List<Product>();

        //    foreach (Product product in products)
        //    {
        //        if (predicate(product))
        //        {
        //            result.Add(product);
        //        }
        //    }

        //    return result;
        //}
        #endregion

        #endregion

        static void Main(string[] args)
        {
            #region Task 01 - Smart Product Search Execution

            //Console.WriteLine("--- Electronics ---");
            //List<Product> electronics = SearchProducts(
            //    catalog,
            //    product => product.Category == "Electronics"
            //);
            //foreach (Product product in electronics)
            //{
            //    Console.WriteLine($"{product.Name} - ${product.Price} (Stock: {product.Stock})");
            //}

            //Console.WriteLine();

            //Console.WriteLine("--- Under $50 ---");
            //List<Product> under50 = SearchProducts(
            //    catalog,
            //    product => product.Price < 50
            //);
            //foreach (Product product in under50)
            //{
            //    Console.WriteLine($"{product.Name} - ${product.Price} (Stock: {product.Stock})");
            //}

            //Console.WriteLine();

            //Console.WriteLine("--- In Stock ---");
            //List<Product> inStock = SearchProducts(
            //    catalog,
            //    product => product.Stock > 0
            //);
            //foreach (Product product in inStock)
            //{
            //    Console.WriteLine($"{product.Name} - ${product.Price} (Stock: {product.Stock})");
            //}

            //Console.WriteLine();

            //Console.WriteLine("--- Clothing Under $100 ---");
            //List<Product> clothingUnder100 = SearchProducts(
            //    catalog,
            //    product => product.Category == "Clothing" && product.Price < 100
            //);
            //foreach (Product product in clothingUnder100)
            //{
            //    Console.WriteLine($"{product.Name} - ${product.Price} (Stock: {product.Stock})");
            //}

            //Console.WriteLine();

            #endregion

            #region Task 03.1 - Print Reports Execution

            //Console.WriteLine("--- Short Report ---");
            //PrintReport(
            //    catalog,
            //    product => Console.WriteLine($"{product.Name} - ${product.Price}")
            //);

            //Console.WriteLine();

            //Console.WriteLine("--- Detailed Report ---");
            //PrintReport(
            //    catalog,
            //    product => Console.WriteLine(
            //        $"[{product.Category}] {product.Name} | Price: ${product.Price} | Stock: {product.Stock}"
            //    )
            //);

            //Console.WriteLine();

            //#endregion

            //#region Task 03.2 - Transform Products Execution

            //Console.WriteLine("--- Summary List ---");
            //List<string> summaryList = TransformProducts(
            //    catalog,
            //    product => $"{product.Name} (${product.Price})"
            //);
            //foreach (string item in summaryList)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine();

            //Console.WriteLine("--- Price Labels ---");
            //List<string> priceLabels = TransformProducts(
            //    catalog,
            //    product => $"{product.Name}: {(product.Price > 100 ? "Expensive!" : "Affordable")}"
            //);
            //foreach (string item in priceLabels)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine();

            #endregion

            #region Task 03.3 - Filter Products Execution

            Console.WriteLine("--- Low-Stock Alert ---");
            List<Product> lowStockProducts = FilterProducts(
                catalog,
                product => product.Stock < 20
            );

            foreach (Product product in lowStockProducts)
            {
                Console.WriteLine($"[LOW STOCK] {product.Name}: only {product.Stock} left!");
            }

            #endregion

            Console.ReadKey();
        }
    }
}