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
            Activity activityOne = new Activity("Concert", "rock", new DateTime(2000, 01, 05), new DateTime(2000, 03, 05));
            Activity activityTwo = new Activity("Camp", "rock", new DateTime(2001, 01, 05), new DateTime(2002, 03, 05));

            List<Activity> activities = new List<Activity>();

            activities.Add(activityOne);
            activities.Add(activityTwo);

            Agenda agendaPerson1 = new Agenda(activities);

            Person person = new Person("Ionel", "Marin", DateTime.Now, "ionel.marin@gmail.com", agendaPerson1);

            

        }
    }
}
