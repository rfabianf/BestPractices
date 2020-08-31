using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicDecoratorComposition
{
    class Program
    {
        static void Main(string[] args)
        {
            var square = new Square(1.23f);
            Console.WriteLine(square.AsString());

            var redSquare = new ColoredShape(square, "blue");
            Console.WriteLine(redSquare.AsString());

            var redHalfTansparentSquare = new TransparentShape(redSquare, 0.5f);
            Console.WriteLine(redHalfTansparentSquare.AsString());
        }
    }
}
