using System;
using System.Collections.Generic;

namespace AgendaPersonala.Objects
{
    public class Person
    {
        public string FirstName;
        public string LastName;
        public DateTime BirthDate;
        public string EmailAddress;
        public Agenda PersonAgenda;

        public Person(string firstName, string lastName, DateTime birthDate, string emailAddress, Agenda personAgenda)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            EmailAddress = emailAddress;
            PersonAgenda = personAgenda;
        }

    }
}
