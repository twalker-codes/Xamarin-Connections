using SocialTemplate.MaterialDesign;
using SocialTemplate.Models;
using SocialTemplate.Resources;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace SocialTemplate.Converters
{
    /// <summary>
    /// Returns the associated icon by value.
    /// <seealso href="https://docs.microsoft.com/en-us/xamarin/xamarin-forms/app-fundamentals/data-binding/converters"/>
    /// </summary>
    public class NotifyIconConverter : IValueConverter
    {
        /// <param name="value">NotifyIcon</param>
        /// <param name="targetType">Unused</param>
        /// <param name="parameter">Unused</param>
        /// <param name="culture">Unused</param>
        /// <returns>The Unicode string of an associated Material icon</returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch ((NotifyIcon)value)
            {
                case NotifyIcon.Cake:
                    return Icons.Cake;
                case NotifyIcon.Favorite:
                    return Icons.Favorite;
                case NotifyIcon.Message:
                    return Icons.Message;
                case NotifyIcon.QuestionMark:
                    return Icons.CropSquare;
                default:
                    return Icons.Error;

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
