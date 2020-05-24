using System;

namespace OpenClose
{
    class Program
    {
        static void Main(string[] args)
        {
            var person1 = new Persona() { nombre = "Roberto", estado = ECivil.Soltero, sexo = Sexo.Masculino };
            var person2 = new Persona() { nombre = "Amix", estado = ECivil.Soltero, sexo = Sexo.Femenino };
            var person3 = new Persona() { nombre = "Beto", estado = ECivil.Divorciado, sexo = Sexo.Masculino };

            Persona[] personas = { person1, person2, person3 };

            var filterPerson = new PersonFilter();

            Console.WriteLine($"Inicio Filter (old)");
            foreach(var item in filterPerson.GetPersonasBySexo(personas,Sexo.Masculino))
            {
                Console.WriteLine($"Persona con nombre: {item.nombre} y Estado civil: {item.estado}");
            }

            IFilter<Persona> bfilter = new BetterFilter();
            Console.WriteLine($"Inicio Filter sexo (new)");
            foreach (var item in bfilter.Filter(personas,new SexSpecification(Sexo.Masculino)))
            {
                Console.WriteLine($"Persona con nombre: {item.nombre} y Estado civil: {item.estado}");
            }

            Console.WriteLine($"Inicio Filter estado (new)");
            foreach (var item in bfilter.Filter(personas, new EstadoSpecification(ECivil.Soltero)))
            {
                Console.WriteLine($"Persona con nombre: {item.nombre} y Estado civil: {item.estado}");
            }

            Console.WriteLine($"Inicio Filter Sexo y Estado (new)");
            foreach (var item in bfilter.Filter(personas, 
                new AndSpecification<Persona>(new SexSpecification(Sexo.Masculino),new EstadoSpecification(ECivil.Divorciado))))
            {
                Console.WriteLine($"Persona con nombre: {item.nombre} y Estado civil: {item.estado}");
            }

        }
    }
}
