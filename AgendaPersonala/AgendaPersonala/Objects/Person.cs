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

        public void AddActivity(Activity activity)
        {
            PersonAgenda.Activities.Add(activity);
        }

        public List<Activity> FindPersonActivity(string name)
        {
            List<Activity> foundActivities = new List<Activity>();
            foreach (var activity in PersonAgenda.Activities)
            {
                if (activity.Name.Contains(name) == true) foundActivities.Add(activity);
            }
            return foundActivities;
        }

        public void DeletePersonActivity (string name)
        {
            List<Activity> foundActivities = new List<Activity>();
            PersonAgenda.Activities.RemoveAll(x => x.Name.Contains(name));
        }

        public void DeletePersonAgenda ()
        {
            foreach (var activity in PersonAgenda.Activities)
            {
                PersonAgenda.Activities.Remove(activity);
            }
            PersonAgenda = null;
        }

        public List<Activity> PersonActivitiesByTimeInterval(DateTime beginningDate, DateTime endingDate)
        {
            List<Activity> foundActivities = new List<Activity>();

            foreach (var activity in PersonAgenda.Activities)
            {
                if (activity.BeginningDate > beginningDate && activity.EndDate < endingDate) foundActivities.Add(activity);
            }
            return foundActivities;
        }

    }
}
