using Collections.Models;
using System.ComponentModel.Design;

namespace Collections
{
    internal class Program
    {
        public delegate void Callback(string message);
        
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
            List<string> stringList = new List<string> { "Hej", "Världen" };
            PrintTypeOfElement(stringList);
            List<ScoreCard> scoreList = new List<ScoreCard> { new ScoreCard { PersonId = Guid.NewGuid(), CompetitionId = 1, Score = 2 }, new ScoreCard { PersonId = Guid.NewGuid(), CompetitionId = 2, Score = 3 } };
            PrintTypeOfElement(scoreList);

            Callback handler = DelegateMethod;
            handler("Hej Världen");
            handler("Hello!");
            handler = PrintHelloName;
            handler("Jimmie");

            TestHandler(handler);
        }

        private static void TestHandler(Callback handler)
        {
            handler("Complex stuff happens");
        }

        public static void PrintTypeOfElement<T>(List<T> listOfElement)
        {
            foreach (T element in listOfElement)
            {
                Console.WriteLine(typeof(T).Name);
                if (element.GetType().Equals(typeof(ScoreCard)))
                {
                    ScoreCard scoreElement = element as ScoreCard;                    
                }
            }
        }

        public static void DelegateMethod(string message)
        {
            Console.WriteLine(message);
        } 

        public static void PrintHelloName(string message) { Console.WriteLine("Hello "+message);}
    }
}