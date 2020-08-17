using System;
using System.Reactive.Linq;

namespace ObserverSpecialInterfaces
{
    public class Program : IObserver<Event>
    {
        public Program()
        {
            var person = new Person();
            IDisposable sub = person.Subscribe(this);

            //---------Con Extension Reactiva---------------
            //-----------------------------------------------
            //person.OfType<FallsIllEvent>().Subscribe(args =>
            //Console.WriteLine($"A doctor is required in address {args.Address}"));

            person.FallsIll();
            sub.Dispose();

        }
        static void Main(string[] args)
        {
            new Program();
        }

        public void OnCompleted()
        {
            throw new NotImplementedException();
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnNext(Event value)
        {
            if (value is FallsIllEvent args)
            {
                Console.WriteLine($"A doctor is required in address {args.Address}");
            }
        }
    }
}
