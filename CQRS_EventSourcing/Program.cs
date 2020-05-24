using System;

namespace CQRS_EventSourcing
{
    class Program
    {
        static void Main(string[] args)
        {
            var eb = new EventBroker();
            var p = new Person(eb);
            eb.Command(new ChangeAgeCommand(p, 123));

            foreach (var item in eb.AllEvents)
            {
                Console.WriteLine(item);
            }

            int age;
            age= eb.Query<int>(new AgeQuery { target = p });
            Console.WriteLine(age);

            eb.UndoLast();

            foreach (var item in eb.AllEvents)
            {
                Console.WriteLine(item);
            }

            age = eb.Query<int>(new AgeQuery { target = p });
            Console.WriteLine(age);

        }
    }
}
