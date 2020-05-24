using System;

namespace MonoState
{
    class Program
    {
        static void Main(string[] args)
        {
            var ceo1 = new CEO();
            ceo1.Age = 29;
            ceo1.Name = "Roberto";

            var ceo2 = new CEO();
            Console.WriteLine(ceo2);
        }
    }
}
