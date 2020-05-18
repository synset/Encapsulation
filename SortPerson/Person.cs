using System;
using System.Collections.Generic;
using System.Text;

namespace SortPerson
{
    class Person
    {
        private string firstName { get; set; }
        private string lastName { get; set; }
        private int age { get; set; }

        public Person(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        public string FirstName { get { return this.firstName; } }
        public string LastName { get { return this.lastName; } }
        public int Age { get { return this.age; } }

        public override string ToString()
        {
            return $"{FirstName} {LastName} is {Age} years old."; 
        }
    }
}
