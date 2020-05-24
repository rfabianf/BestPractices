using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClose
{
    public class SexSpecification : ISpecification<Persona>
    {
        private Sexo sexo;

        public SexSpecification(Sexo sexo)
        {
            this.sexo = sexo;
        }
        public bool IsSatisfied(Persona t)
        {
            return t.sexo == sexo;
        }
    }
}
