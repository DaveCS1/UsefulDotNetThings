using System;
using System.Windows.Data;

namespace UsefulThings.WPF.TypeConverters
{
    public class ByteSizeToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value == null)
                return "0b";

            dynamic number = value;

            // KFreon: Yeah...an entire class file for this. A little frustration for WPF.
            double size = (double)number;
            return UsefulDotNetThings.General.IO.GetFileSizeAsString(size);
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
