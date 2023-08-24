using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phonebook.Models
{
    public record Person
    {
        public string FirstName { get; init; }

        public string LastName { get; init; }

        public string Name => FirstName + " " + LastName;

        public string Company { get; init; }

        public Person(string firstName, string lastName, string company)
        {
            FirstName = firstName;
            LastName = lastName;
            Company = company;
        }
    }
}
