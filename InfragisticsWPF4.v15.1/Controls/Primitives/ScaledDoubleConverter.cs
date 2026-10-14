using System;
using System.Globalization;
using System.Windows.Data;

namespace Infragistics.Controls.Primitives
{
	// Token: 0x02000095 RID: 149
	public class ScaledDoubleConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x060005D9 RID: 1497 RVA: 0x0001621A File Offset: 0x0001441A
		// (set) Token: 0x060005DA RID: 1498 RVA: 0x00016222 File Offset: 0x00014422
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

		// Token: 0x060005DB RID: 1499 RVA: 0x00016248 File Offset: 0x00014448
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			if (value is double)
			{
				return (double)value * this._scaleFactor;
			}
			if (value is double?)
			{
				double? num = value as double?;
				if (num != null)
				{
					return num.Value * this._scaleFactor;
				}
				return null;
			}
			else
			{
				if (value is decimal || (value != null && value.GetType().IsPrimitive))
				{
					value = global::System.Convert.ToDouble(value, culture);
					return this.Convert(value, targetType, parameter, culture);
				}
				return value;
			}
		}

		// Token: 0x060005DC RID: 1500 RVA: 0x000162D8 File Offset: 0x000144D8
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
			else if (value is double?)
			{
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
			else
			{
				if (value != null && value.GetType().IsPrimitive)
				{
					value = global::System.Convert.ToDouble(value, culture);
					return this.ConvertBack(value, targetType, parameter, culture);
				}
				return value;
			}
		}

		// Token: 0x04000224 RID: 548
		private double _scaleFactor = 1.0;
	}
}
