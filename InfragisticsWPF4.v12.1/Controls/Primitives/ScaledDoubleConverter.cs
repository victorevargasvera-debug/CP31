using System;
using System.Globalization;
using System.Windows.Data;

namespace Infragistics.Controls.Primitives
{
	// Token: 0x0200007E RID: 126
	public class ScaledDoubleConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x06000516 RID: 1302 RVA: 0x0001381A File Offset: 0x00011A1A
		// (set) Token: 0x06000517 RID: 1303 RVA: 0x00013822 File Offset: 0x00011A22
		public double ScaleFactor
		{
			get
			{
				return this._scaleFactor;
			}
			set
			{
				if (value != this._scaleFactor)
				{
					global::Infragistics.CoreUtilities.ValidateIsNotNan(value);
					global::Infragistics.CoreUtilities.ValidateIsNotNegative(value);
					global::Infragistics.CoreUtilities.ValidateIsNotInfinity(value);
					this._scaleFactor = value;
				}
			}
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x00013848 File Offset: 0x00011A48
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			if (value is double)
			{
				return (double)value * this._scaleFactor;
			}
			if (!(value is double?))
			{
				return value;
			}
			double? num = value as double?;
			if (num != null)
			{
				return num.Value * this._scaleFactor;
			}
			return null;
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x000138A4 File Offset: 0x00011AA4
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			if (value is double)
			{
				if (this._scaleFactor == 0.0)
				{
					return value;
				}
				return (double)value / this._scaleFactor;
			}
			else
			{
				if (!(value is double?))
				{
					return value;
				}
				double? num = value as double?;
				if (num == null)
				{
					return null;
				}
				if (this._scaleFactor == 0.0)
				{
					return num.Value;
				}
				return num.Value / this._scaleFactor;
			}
		}

		// Token: 0x040001AE RID: 430
		private double _scaleFactor = 1.0;
	}
}
