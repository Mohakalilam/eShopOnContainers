using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace eShopOnContainers.Core.Converters
{
    class IndianCurrencyConverter: IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                RegionInfo India = new RegionInfo("IN");
                return String.Format("{0} {1:N}", India.CurrencySymbol, value);
                //return "₹" + " \u20B9" + value;
            }

            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
