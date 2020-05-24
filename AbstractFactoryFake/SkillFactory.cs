using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryFake
{
    internal class CSharpFactory : ISkillFactory
    {
        public ISkill Learn(int experience)
        {
            Console.WriteLine($"Se aprende con {experience} años de experiencia y trabajo en casa");
            return new CSharp();
        }
    }

    internal class JavaFactory : ISkillFactory
    {
        public ISkill Learn(int experience)
        {
            Console.WriteLine($"Se aprende con {experience} años de experiencia y trabajos de la Universidad");
            return new Java();
        }
    }

    internal class PhytonFactory : ISkillFactory
    {
        public ISkill Learn(int experience)
        {
            Console.WriteLine($"Se cuenta con {experience} años de experiencia y estudio autodidacta");
            return new Phyton();
        }
    }
}
