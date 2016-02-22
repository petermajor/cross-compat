using System;
using System.Globalization;
using Android.Text;
using Cirrious.CrossCore.Converters;

namespace CrossCompat.Android.Converters
{
	public sealed class TextToSpannableValueConverter : IMvxValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo cultureInfo)
		{
			var valueTyped = value as string;

			if (valueTyped == null)
				return null;

			return Html.FromHtml(valueTyped);
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo cultureInfo)
		{
			throw new NotSupportedException();
		}
	}
}

