using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bjerre.Runkeeper.ValueObjects
{
    public class MonthActivities
    {
        public string distance { get; set; }
        public string distanceUnits { get; set; }
        public string username { get; set; }
        public int activity_id { get; set; }
        public string monthNum { get; set; }
        public string dayOfMonth { get; set; }
        public string month { get; set; }
        public string year { get; set; }
        public string type { get; set; }
        public string elapsedTime { get; set; }
        public string mainText { get; set; }
        public bool live { get; set; }
    }

    public class Year
    {
        public List<MonthActivities> MonthActivities { get; set; }
    }

    public class Activities
    {
        public Year Year { get; set; }
    }

    public class RunkeeperActivities
    {
        public Activities Activities { get; set; }
    }
}
