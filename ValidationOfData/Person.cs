using System;

namespace ValidationOfData
{
    class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private decimal salary;

        public Person(string firstName, string lastName, int age, decimal salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Salary = salary;
        }

        public string FirstName
        {
            get { return this.firstName; }

            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Firstname must be at least 3 characters long");
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }

            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Lastname must be at least 3 characters long");
                }
                this.lastName = value;
            }
        }

        public int Age
        {
            get { return this.age; }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Age cannot be less than 1 year!");
                }
                this.age = value;
            }
        }

        public decimal Salary
        {
            get { return this.salary; }

            set
            {
                if (value < 460)
                {
                    throw new ArgumentException("Salary cannot be less than 460 dollar!");
                }
                this.salary = value;
            }
        }

        public override string ToString()
        {
            return $"{this.firstName} {this.LastName} receives {this.Salary} dollars";
        }
    }
}
