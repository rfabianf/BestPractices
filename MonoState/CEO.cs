using System;
using System.Collections.Generic;
using System.Text;

namespace MonoState
{
    public class CEO
    {
        public static string name;
        public static int age;

        public string Name
        {
            get => name;
            set => name = value;
        }

        public int Age
        {
            get => age;
            set => age = value;
        }

        public override string ToString()
        {
            return $"{nameof(name)}: {name}, {nameof(age)}: {age}";
        }
    }
}
