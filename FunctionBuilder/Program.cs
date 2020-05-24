using System;

namespace FunctionBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Roberto";
            var person = new PersonBuilder().
                Called(name).
                WorkAs("Developer").
                Build();
            Console.WriteLine($"Persona {person.Name} es {person.Position}");

            var product = new ProductBuilder("Persona")
                .AddField("Name", "string")
                .AddField("Age", "int");
            Console.WriteLine(product);
                //.Called("Sublime")
                //.Category("Chocolate")
                //.HowMuch(100)
                //.CompanyOf(new Company() { Marca = "Nestlé", CompanyName = "Alicorp" })
                //.Build();
            //Console.WriteLine($" Product: {product.product} de Marca: {product.Company.Marca} se vende a un precio de: {product.price} por la empresa: {product.Company.CompanyName}");

        }
    }
}
