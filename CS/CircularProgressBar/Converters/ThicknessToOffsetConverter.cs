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

            if (value is int val && parameter is string param && int.TryParse(param, out factor))
            {
                return -(val * (factor - 1)) - (7 * (factor - 1));
            }
            return 0;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
