using System;
using System.Collections.Generic;

namespace FirstAndReserveTeam
{
    class Team
    {
        private string name;
        private List<Person> firstTeam;
        private List<Person> reserveTeam;
        public List<Person> FirstTeam 
        {
            get { return this.firstTeam; }
        }
        public List<Person> ReserveTeam
        {
            get { return this.reserveTeam; }
        }

        public Team(string name)
        {
            this.name = name;
            this.firstTeam = new List<Person>();
            this.reserveTeam = new List<Person>();
        }

        public void AddPlayer(Person person)
        {
            if(person.Age < 40)
            {
                firstTeam.Add(person);
            }
            else
            {
                reserveTeam.Add(person);
            }
        }

        public void ShowPlayers(Team team)
        {
            foreach (Person person in team.FirstTeam)
            {
                Console.WriteLine(person.FirstName + " play in the First Team");
            }
            foreach (Person person in team.ReserveTeam)
            {
                Console.WriteLine(person.FirstName + " play in the Reserve Team");
            }
        }
    }
}
