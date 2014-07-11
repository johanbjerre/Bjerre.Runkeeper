using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Helpers;
using System.Web.Script.Serialization;
using Bjerre.Runkeeper.ValueObjects;


namespace Bjerre.Runkeeper.Helpers
{
    public static class CollectStats
    {
        public static List<MonthActivities> GetAllActivities(string username, string password, string startDate)
        {
            var urlEncodedUserName = HttpUtility.UrlEncode(username);
            var urlEncodedPassword = HttpUtility.UrlEncode(password);
            var startDateTime = Convert.ToDateTime(startDate);
            var scraper = new Scraper.Scraper();

            Login(ref scraper, urlEncodedUserName, urlEncodedPassword);

            var homeContent = EnterHome(ref scraper);
            var userId = GetUserIdFromHome(homeContent);

            var allPeriods = TimeHelper.GetAllDates(startDateTime);
            var allActivities = new List<MonthActivities>();
            foreach (var period in allPeriods)
            {
                var periodData = GetPeriodData(ref scraper, userId, period);
                periodData = AdjustRunkeeperJson(periodData, period);

                var des = new JavaScriptSerializer().Deserialize<RunkeeperActivities>(periodData);
                if (des.Activities.Year == null)
                    continue;
                allActivities.AddRange(des.Activities.Year.MonthActivities);
            }
            return allActivities;
        }

        private static string AdjustRunkeeperJson(string periodData, string period)
        {
            var year = TimeHelper.GetRunkeeperYear(period);
            var month = TimeHelper.GetRunkeeperMonth(period);
            periodData = ReplaceFirst(periodData, year, "Year");
            periodData = ReplaceFirst(periodData, month, "MonthActivities");
            periodData = ReplaceFirst(periodData, "activities", "Activities");
            return periodData;
        }

        public static string ReplaceFirst(string text, string search, string replace)
        {
            var pos = text.IndexOf(search);
            if (pos < 0)
                return text;
            return text.Substring(0, pos) + replace + text.Substring(pos + search.Length);
        }

        private static string Login(ref Scraper.Scraper scraper, string username, string password)
        {
            var lastContent = scraper.PerformRequest(Constants.RunkeeperConstants.URL_START);
            var postdata = "_eventName=submit&email=" + username + "&password=" + password;
            lastContent = scraper.PerformRequest(Constants.RunkeeperConstants.URL_LOGIN, postdata);
            return lastContent;
        }

        private static string EnterHome(ref Scraper.Scraper scraper)
        {
            var lastContent = scraper.PerformRequest(Constants.RunkeeperConstants.URL_HOME, null);
            return lastContent;
        }

        private static string GetUserIdFromHome(string home)
        {
            var re = new Regex(@"user\/([0-9]+)\/profile");
            var match = re.Match(home);
            return match.Success ? match.Groups[1].Value : null;
        }

        private static string GetPeriodData(ref Scraper.Scraper scraper, string userName, string period)
        {
            var url = "http://runkeeper.com/activitiesByDateRange?userName=" + userName + "&startDate=" + period;
            var lastContent = scraper.PerformRequest(url, null);
            return lastContent;
        }
    }
}
