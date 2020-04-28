using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaPersonala.Objects
{
    public class Activity
    {
        public string Name;
        public string Description;
        public DateTime BeginningDate;
        public DateTime EndDate;

        public Activity(string name, string description, DateTime beginningDate, DateTime endDate)
        {
            Name = name;
            Description = description;
            BeginningDate = beginningDate;
            EndDate = endDate;
        }
    }
}
