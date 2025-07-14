using System;
using System.Collections.Generic;
using System.Security;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;

namespace WpfControlToolkit
{
    [SecurityCritical]
    public class ColorConverter : IValueConverter
    {
        [SecurityCritical]
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            UIElement c = value as UIElement;
            Panel p = (Panel)VisualTreeHelper.GetParent(c);
            ItemsControl _parent = ((ItemsControl)((FrameworkElement)VisualTreeHelper.GetParent(p)).TemplatedParent);
            int index = _parent.ItemContainerGenerator.IndexFromContainer(c);
            Random r = new Random((int)index);
            Color color = Color.FromScRgb(1.0f, (float)r.NextDouble(), (float)r.NextDouble(), (float)r.NextDouble());
            return new SolidColorBrush(color);
        }

        [SecurityCritical]
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new Exception("The method or operation is not implemented.");
        }
    }
}
