using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryFake
{
    public enum Skill
    {
        Java,CSharp,Phyton
    }
    public class MachineSkillFactory
    {
        private Dictionary<Skill, ISkillFactory> factories = new Dictionary<Skill, ISkillFactory>();

        public MachineSkillFactory()
        {
            foreach(Skill skill in Enum.GetValues(typeof(Skill)))
            {
                factories.Add(skill, (ISkillFactory) Activator.CreateInstance(Type.GetType(
                    "AbstractFactoryFake." + Enum.GetName(typeof(Skill),skill) + "Factory")));
            }
        }

        public ISkill Make(Skill skill, int años)
        {
            return factories[skill].Learn(años);
        }
    }
}
