using System;

namespace ChatRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            var room = new ChatRoom();
            var john = new Person("john");
            var jane = new Person("jane");

            room.Join(john);
            room.Join(jane);

            john.Say("hi");
            john.Say("oh, hey Jhon");

            var simon = new Person("Simon");
            room.Join(simon);
            simon.Say("hi everyoone");

            jane.PrivateMessage("Simon", "glad you could join us");
        }
    }
}
