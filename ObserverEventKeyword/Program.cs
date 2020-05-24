using System;

namespace ObserverEventKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            var Person = new Person();

            Person.FallsIll += CallDoctor;


            Person.CatchACold();
            Person.FallsIll -= CallDoctor;
        }

        private static void CallDoctor(object sender, FallsIllEventArgs eventArgs)
        {
            Console.WriteLine($"A doctor has been calles from {eventArgs.Address}");
        }
    }
}
