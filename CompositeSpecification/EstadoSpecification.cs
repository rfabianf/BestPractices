using System;
using System.Collections.Generic;
using System.Text;

namespace CompositeSpecification
{
    public class EstadoSpecification : ISpecification<Persona>
    {
        private ECivil estado;

        public EstadoSpecification(ECivil estado)
        {
            this.estado = estado;
        }
        public bool IsSatisfied(Persona t)
        {
            return t.estado == estado;
        }
    }
}
