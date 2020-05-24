using System;

namespace FacetedBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            var pb = new PersonBuilder();
            Person person = pb
                .Lives
                .At("Urb. San Isidro Mzna W Lote 41")
                .WithPostCode("044")
                .In("Trujillo")
                .Works
                .At("Everis")
                .AsA("Develop")
                .Earning(53900);

            Console.WriteLine(person);
        }
    }
}
