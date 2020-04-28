using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaPersonala.Objects
{
    public class Agenda
    {
        public List<Activity> Activities;
        public Agenda(List<Activity> activities)
        {
            Activities.AddRange(activities);
        }
    }
}
