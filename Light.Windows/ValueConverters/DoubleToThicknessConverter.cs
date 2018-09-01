using Light.Windows.ValueConverters.Base;
using System;
using System.Globalization;
using System.Windows;

namespace Light.Windows.ValueConverters
{
	public class DoubleToThicknessConverter : BaseValueConverter<DoubleToThicknessConverter>
	{
		public override object Convert( object value, Type targetType, object parameter, CultureInfo culture )
		{
			if ( value == null )
				return null;

			return new Thickness( (double) value );
		}

		public override object ConvertBack( object value, Type targetType, object parameter, CultureInfo culture ) => throw new NotImplementedException();
	}
}
