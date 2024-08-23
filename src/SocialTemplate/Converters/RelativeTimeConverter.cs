using SocialTemplate.Resources;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace SocialTemplate.Converters
{
    /// <summary>
    /// Returns the relative time from a date to the present.
    /// <seealso href="https://docs.microsoft.com/en-us/xamarin/xamarin-forms/app-fundamentals/data-binding/converters"/>
    /// </summary>
    public class RelativeTimeConverter : IValueConverter
    {
        const int SECOND = 1;
        const int MINUTE = 60 * SECOND;
        const int HOUR = 60 * MINUTE;
        const int DAY = 24 * HOUR;
        const int MONTH = 30 * DAY;


        /// <param name="value">Date (DateTime)</param>
        /// <param name="targetType">Unused</param>
        /// <param name="parameter">Unused</param>
        /// <param name="culture">Unused</param>
        /// <returns>Relative time from a date</returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null) return string.Empty;

            var date = (DateTime)value;

            var ts = new TimeSpan(DateTime.UtcNow.Ticks - date.Ticks);
            double delta = Math.Abs(ts.TotalSeconds);

            if (delta < 1 * MINUTE)
                return ts.Seconds == 1 ? AppResources.OneSecondAgo : ts.Seconds + AppResources.SecondsAgo;

            if (delta < 2 * MINUTE)
                return AppResources.AMinuteAgo;

            if (delta < 45 * MINUTE)
                return ts.Minutes + AppResources.MinutesAgo;

            if (delta < 90 * MINUTE)
                return AppResources.AnHourAgo;

            if (delta < 24 * HOUR)
                return ts.Hours + AppResources.HoursAgo;

            if (delta < 48 * HOUR)
                return AppResources.Yesterday;

            if (delta < 30 * DAY)
                return ts.Days + AppResources.DaysAgo;

            if (delta < 12 * MONTH)
            {
                int months = System.Convert.ToInt32(Math.Floor((double)ts.Days / 30));
                return months <= 1 ? AppResources.OneMonthAgo : months + AppResources.MonthsAgo;
            }
            else
            {
                int years = System.Convert.ToInt32(Math.Floor((double)ts.Days / 365));
                return years <= 1 ? AppResources.OneYearAgo : years + AppResources.YearsAgo;
            }
        }

        /// <summary>
        /// It is unnecessary to implement.
        /// </summary>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
