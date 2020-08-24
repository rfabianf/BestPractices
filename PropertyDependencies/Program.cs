using System;

namespace PropertyDependencies
{
    class Program
    {
        public static void Main(string[] args)
        {
            var p = new Person();
            p.PropertyChanged += (sender, EventArgs) =>
             {
                 Console.WriteLine($"{EventArgs.PropertyName} changed");
             };
            p.Age = 15;
            p.Citizen = true;
            p.Sex = "M";//No se encuentra en el árbol de expresion
        }
    }
}
