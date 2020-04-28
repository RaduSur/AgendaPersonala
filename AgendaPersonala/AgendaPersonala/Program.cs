using AgendaPersonala.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaPersonala
{
    class Program
    {
        static void Main(string[] args)
        {
            // creare activitati
            Activity activityOne = new Activity("Concert", "rock", new DateTime(2000, 01, 05), new DateTime(2000, 03, 05));
            Activity activityTwo = new Activity("Camp", "rock", new DateTime(2001, 01, 05), new DateTime(2002, 03, 05));

            List<Activity> activities = new List<Activity>();

            activities.Add(activityOne);
            activities.Add(activityTwo);

            //creare agenda
            Agenda agendaPerson1 = new Agenda(activities);

            //creare persoana
            Person person = new Person("Ionel", "Marin",new DateTime(2000,05,05), "ionel.marin@gmail.com", agendaPerson1);
            Person person2 = new Person("Maria", "Anica", new DateTime(2001,05,05), "maria.anica@gmail.com", agendaPerson1);

            Activity activityThree = new Activity("Tour", "rock", new DateTime(2002, 01, 05), new DateTime(2003, 03, 05));

            //adaugare unei acitivitati pentru o persoana
            person.AddActivity(activityThree);

            //cautare activitatea unei persoane dupa nume
            person.FindPersonActivity("Con");

            //stergere activitatea unei persoane
            person.DeletePersonActivity("Cam");

            //stergere agendei unei persoane
            person.DeletePersonAgenda();

            DateTime begDate = new DateTime();
            DateTime endDate = new DateTime();

            //actvitatile unei persoane dintrun interval de timp
            List<Activity> activities1 =  person.PersonActivitiesByTimeInterval(begDate, endDate);

            List<Person> persons = new List<Person>();
            persons.Add(person);
            persons.Add(person2);
            // meeting all persons
        }

        public void MeetingTimeAllPersons(List<Person> people)
        {
            DateTime end = people[1].PersonAgenda.Activities[1].EndDate;

            foreach (var person in people)
            {
                foreach (var activity in person.PersonAgenda.Activities)
                {
                    if (activity.EndDate < end) end = activity.EndDate;
                }
            }

            Console.WriteLine("Meeting time: " + end);
        }
    }
}
