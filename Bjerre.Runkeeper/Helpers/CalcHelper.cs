using System;
using System.Globalization;

namespace Bjerre.Runkeeper.Helpers
{
    public static class CalcHelper
    {
        public static decimal CalcMileSpeed(decimal runDistance, long elapsedSeconds)
        {
            var miles = runDistance / 10;
            var seconds = elapsedSeconds;
            var secondsPerMile = seconds / miles;
            var mileSpeedMinutes = Math.Floor(secondsPerMile / 60);
            var mileSpeedSeconds = secondsPerMile - mileSpeedMinutes * 60;
            var mileSpeedSecondsInt = Convert.ToInt32(Math.Round(mileSpeedSeconds, 0));
            var mileSpeed = string.Format("{0}.{1}", mileSpeedMinutes, mileSpeedSecondsInt);

            var s = mileSpeed.ToString(CultureInfo.InvariantCulture);
            return decimal.Parse(s, CultureInfo.InvariantCulture);
            //return Convert.ToDecimal(mileSpeed);
        }

        public static decimal GetElapsedMinutes(long elapsedSeconds)
        {
            var minutes = Convert.ToDecimal(elapsedSeconds) / 60;
            var minutesInt = Math.Floor(minutes);
            var seconds = elapsedSeconds - 60 * minutesInt;
            var elapsedMinutes = string.Format("{0}.{1}", minutesInt, seconds);
            var s = elapsedMinutes.ToString(CultureInfo.InvariantCulture);
            return decimal.Parse(s, CultureInfo.InvariantCulture);
        }
    }
}
