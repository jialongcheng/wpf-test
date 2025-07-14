using System;
using System.Globalization;
using System.Security;
using System.Windows.Data;
using System.Windows.Media;

namespace Microsoft.Test.Controls
{
    /// <summary>
    /// AgeToForegroundConverter
    /// </summary>
    [SecurityCritical]
    public class AgeToForegroundConverter : IValueConverter
    {
        #region IValueConverter Members


        [SecurityCritical]
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (targetType != typeof(Brush)) return null;
            int age = int.Parse(value.ToString());
            return (age > 25 ? Brushes.Red : Brushes.Black);
        }


        [SecurityCritical]
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
