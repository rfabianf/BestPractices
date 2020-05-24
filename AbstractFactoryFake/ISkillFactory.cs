using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryFake
{
    public interface ISkillFactory
    {
        ISkill Learn(int experience);
    }
}
