using System.Collections.Generic;

namespace CompositeSpecification
{
    public class PersonFilter
    {
        public IEnumerable<Persona> GetPersonasBySexo(IEnumerable<Persona> personas, Sexo sexo)
        {
            foreach (var item in personas)
                if (item.sexo == sexo)
                    yield return item;
        }
    }
}