﻿using System;
using System.Globalization;
using System.Windows.Data;

namespace UsefulThings.WPF.TypeConverters
{
    // Mostly got it from here: http://stackoverflow.com/questions/3985876/wpf-binding-a-listbox-to-an-enum-displaying-the-description-attribute
    public class EnumDescriptionConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return null;

            Enum theEnum = (Enum)value;
            string description = UsefulDotNetThings.General.Misc.GetEnumDescription(theEnum);
            return description;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
