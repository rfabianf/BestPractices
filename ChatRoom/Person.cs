using System;
using System.Collections.Generic;
using System.Text;

namespace ChatRoom
{
    public class Person
    {
        public string Name;
        public List<string> ChatLog = new List<string>();
        public ChatRoom Room;

        public Person(string name)
        {
            Name = name;
        }

        public void Say(string message)
        {
            Room.Broadcast(Name, message);
        }

        public void PrivateMessage(string who,string message)
        {
            Room.Message(Name, who, message);
        }

        public void Receive(string sender,string message)
        {
            string s = $"{sender}: '{message}'";
            ChatLog.Add(s);
            Console.WriteLine($"[{Name}'s chat session] {s}");
        }
    }

}
