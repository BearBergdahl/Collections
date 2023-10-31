using Collections.Models;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person Bear = new Person("Björn", "Lärare", "Gäddvägen", 36);
            Person AnyPerson = new Person("Someone", "Student", "CalleCalle", 99);
            Person toPlaywith = Bear;
            toPlaywith.Name = AnyPerson.Name;
            Console.WriteLine(toPlaywith.Name);
            Console.WriteLine(Bear.Name);
            Console.WriteLine(AnyPerson.Name);
            List<Person> list = new List<Person>();
            list.Add(toPlaywith);
            list.Add(Bear); 
            list.Add(AnyPerson);
            foreach (Person person in list)
            {
                person.Name = "A name";
                Console.WriteLine(person.Name);
                Console.WriteLine(person.Description);
            }
            Console.WriteLine(toPlaywith.Name);
            Console.WriteLine(toPlaywith.Description);

            DemoClass.DemoObjects();
            DemoClass.DemoArrayList();
        }
    }
}