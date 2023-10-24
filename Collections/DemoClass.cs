using Collections.Models;
using System;
using Newtonsoft;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Collections
{
    public static class DemoClass
    {
        public static void DemoArrayList()
        {
            ArrayList simpleList = new ArrayList();
            simpleList.Add(1);
            simpleList.Add(2);
            simpleList.Add(3);
            simpleList.Add(4);
            foreach(int i in simpleList)
            {
                Console.WriteLine(i);
            }
            ArrayList butWhatHappensIf = new ArrayList();
            butWhatHappensIf.Add(new Person("Donny", "Golfer", "Longroad", 99));
            butWhatHappensIf.Add(new Person("Jonny", "Golfer", "Longroad", 97));
            butWhatHappensIf.Add(new Person("Ronny", "Golfer", "Longroad", 95));
            foreach (var person in butWhatHappensIf)
            {
                Console.WriteLine(person.ToString());
                Person asPerson = person as Person;
                Console.WriteLine(asPerson.Name + " " + asPerson.Id );

            }
            Console.WriteLine("What happens if we add something else? By mistakte?");
            Competition competition = new Competition
            {
                CompetitionId = 1,
                Name = "CompetetsCup",
                Description = "Hitting ball least times competition.",
                Winner = null,
                Participants = butWhatHappensIf
            };
            competition.Participants.Add(new ScoreCard { CompetitionId = 1, PersonId = Guid.NewGuid(), Score =  99 });
            competition.Participants.Add(new Competition { CompetitionId = 2, Description = "Running Donkeys quickly around a track", Name = "Donkeyrun", Participants = null, Winner = new Person("Ior", "Depressed donkey", "SevenStrides forrest", 1) });
            competition.Participants.AddRange(new ArrayList{1,3,6});
            Console.WriteLine("How do we loop throug this...");
            foreach (var maybePerson in competition.Participants)
            {
                Console.WriteLine(maybePerson.GetType().FullName);
                Console.WriteLine(JsonConvert.SerializeObject(maybePerson));
            }
            Console.WriteLine("That was almost ok...");
        }

        public static void DemoObjects()
        {
            Competition competition = new Competition();
            competition.Description = "Övningsuppgift";
            competition.Name = "Dagens övning";  
            competition.Participants = null; // Add your names
            competition.CompetitionId = 1;
            competition.Winner = null; //add person
            Console.WriteLine("Skriv ett enkelt konsol eller WPF-program som skapar en tävling, låter användaren ange namn mm och sedan lägger till tävlande.");
            Console.WriteLine("När deltagare är klara, skapa upp scorecards för varje deltagare i ett nytt attribut i tävlingen. Ta bort vinnare som ett attribut på tävling och välj istället ut en vinnare baserad på deltagarnas scorecards.");
            Console.WriteLine("Presentera en lista med deltagarna i sorterade iordning efter poäng på deras scorecard. (välj själv vad man vinner på. Endast Arrayer & ArrayList får användas!");
        }
    }
}
