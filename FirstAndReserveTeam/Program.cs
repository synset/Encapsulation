using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace FirstAndReserveTeam
{
    class Program
    {
        public static void Main()
        {
            var persons = new List<Person>();

            Person p = new Person("Anna", "Eriksson", 33);
            Person p2 = new Person("Heidi", "Andersson", 44);
            Person p3 = new Person("Gunnar", "Gustavsson", 30);
            Person p4 = new Person("Nils", "Persson", 50);

            persons.Add(p);
            persons.Add(p2);
            persons.Add(p3);
            persons.Add(p4);

            Team team = new Team("Lexicon");

            foreach (Person person in persons)
            {
                team.AddPlayer(person);
            }

            team.ShowPlayers(team);
        }
    }
}
