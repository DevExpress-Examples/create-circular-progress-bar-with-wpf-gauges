using System;
using System.Windows.Data;
using System.Windows.Markup;

namespace CircularProgressBar.Converters
{
    public class ThicknessToOffsetConverter : MarkupExtension, IValueConverter
    {
        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this;
        }

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            int factor = 1;
            if (parameter is null && value is null)
                return 0;

            var param = (string)parameter;
            var val = (int)value;
            if(!int.TryParse(param, out factor))
                return 0;

            return - (val + 7) * (factor - 1);
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
