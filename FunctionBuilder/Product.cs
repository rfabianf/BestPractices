using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FunctionBuilder
{
    public class Product
    {
        public string product { get; set; }

        public double price { get; set; }

        public string Category { get; set; }

        public Company Company { get; set; }
        
    }

 

    //public sealed class ProductBuilder
    //{
    //    public readonly List<Func<Product, Product>> actions = new List<Func<Product, Product>>();

    //    public ProductBuilder Called(string name) => Do(p => p.product = name);

    //    public ProductBuilder Do(Action<Product> action) => AddAction(action);

    //    public ProductBuilder AddAction(Action<Product> action)
    //    {
    //        actions.Add(p =>
    //       {
    //           action(p);
    //           return p;
    //       });

    //        return this;
    //    }

    //    public Product Build() => actions.Aggregate(new Product(), (p, f) => f(p));

    //}

    public static class ProductBuilderExtension
    {
        public static ProductBuilder HowMuch(this ProductBuilder builder, int price) => builder.Do(p => p.price = price);

        public static ProductBuilder Category(this ProductBuilder builder, string category) => builder.Do(p => p.Category = category);

        public static ProductBuilder CompanyOf(this ProductBuilder builder, Company company) => builder.Do(p => p.Company = company);
    }
}
