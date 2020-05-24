using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryFake
{
    internal class CSharp : ISkill
    {
        public void Code()
        {
            Console.WriteLine("Code C# at Work since Version 6.0");
        }
    }

    internal class Java : ISkill
    {
        public void Code()
        {
            Console.WriteLine("Code Java just at the Tesis's presentation for University");
        }
    }

    internal class Phyton : ISkill
    {
        public void Code()
        {
            Console.WriteLine("Code Phyton at home for Off-shore's Projects");
        }
    }
}
