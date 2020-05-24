using System;

namespace AbstractFactoryFake
{
    class Program
    {
        static void Main(string[] args)
        {
            var machine = new MachineSkillFactory();
            var factory = machine.Make(Skill.Phyton, 4);
            factory.Code();
            
        }
    }
}
