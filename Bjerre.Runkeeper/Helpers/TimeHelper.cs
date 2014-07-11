using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bjerre.Runkeeper.Helpers
{
    public static class TimeHelper
    {
        public static List<string> GetAllDates(DateTime startDateTime)
        {
            var endDateTime = DateTime.Now;
            var output = new List<string>();
            while (startDateTime <= endDateTime)
            {
                var currentDate = startDateTime.ToString("MMM-dd-yyyy", CultureInfo.CreateSpecificCulture("en-US"));
                output.Add(currentDate);
                startDateTime = startDateTime.AddMonths(1);
            }
            return output;
        }

        public static string GetRunkeeperYear(string runkeeperDate)
        {
            var runkeeperDateTime = Convert.ToDateTime(runkeeperDate);
            return runkeeperDateTime.ToString("yyyy", CultureInfo.CreateSpecificCulture("en-US"));
        }

        public static string GetRunkeeperMonth(string runkeeperDate)
        {
            var runkeeperDateTime = Convert.ToDateTime(runkeeperDate);
            return runkeeperDateTime.ToString("MMM", CultureInfo.CreateSpecificCulture("en-US"));
        }
    }
}
