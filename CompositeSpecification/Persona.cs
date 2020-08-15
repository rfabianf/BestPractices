using System;
using System.Collections.Generic;
using System.Text;

namespace CompositeSpecification
{
    public enum ECivil
    {
        Soltero,Casado,Divorciado
    }

    public enum Sexo
    {
        Masculino, Femenino
    }

    public class Persona
    {
        public string nombre { get; set; }
        public ECivil estado { get; set; }
        public Sexo sexo { get; set; }
    }
}
