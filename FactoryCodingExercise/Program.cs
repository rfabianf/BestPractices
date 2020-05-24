namespace FactoryCodingExercise
{
    public class Program
    { 
        static void Main(string[] args)
        {
            var Person = new PersonaFactory();
            var Person1 = Person.CreatePerson("Roberto");
            var Person2 = Person.CreatePerson("Tefy");
            var Person3 = Person.CreatePerson("Joel");

            var Personx2 = new PersonaFactory();
            var Personx21 = Personx2.CreatePerson("Tio");
            var Personx22 = Personx2.CreatePerson("Tia");

        }
    }
}