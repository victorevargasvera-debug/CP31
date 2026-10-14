using System;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Globalization;
using System.Reflection;
using System.Security;
using MS.Internal;

namespace Microsoft.Windows.Controls
{
	// Token: 0x0200006A RID: 106
	public class DataGridLengthConverter : global::System.ComponentModel.TypeConverter
	{
		// Token: 0x060007BA RID: 1978 RVA: 0x00022824 File Offset: 0x00020A24
		public override bool CanConvertFrom(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Type sourceType)
		{
			switch (global::System.Type.GetTypeCode(sourceType))
			{
			case global::System.TypeCode.Byte:
			case global::System.TypeCode.Int16:
			case global::System.TypeCode.UInt16:
			case global::System.TypeCode.Int32:
			case global::System.TypeCode.UInt32:
			case global::System.TypeCode.Int64:
			case global::System.TypeCode.UInt64:
			case global::System.TypeCode.Single:
			case global::System.TypeCode.Double:
			case global::System.TypeCode.Decimal:
			case global::System.TypeCode.String:
				return true;
			}
			return false;
		}

		// Token: 0x060007BB RID: 1979 RVA: 0x0002287B File Offset: 0x00020A7B
		public override bool CanConvertTo(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Type destinationType)
		{
			return destinationType == typeof(string) || destinationType == typeof(global::System.ComponentModel.Design.Serialization.InstanceDescriptor);
		}

		// Token: 0x060007BC RID: 1980 RVA: 0x0002289C File Offset: 0x00020A9C
		public override object ConvertFrom(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Globalization.CultureInfo culture, object value)
		{
			if (value != null)
			{
				string text = value as string;
				if (text != null)
				{
					return global::Microsoft.Windows.Controls.DataGridLengthConverter.ConvertFromString(text, culture);
				}
				double num = global::System.Convert.ToDouble(value, culture);
				global::Microsoft.Windows.Controls.DataGridLengthUnitType type;
				if (global::MS.Internal.DoubleUtil.IsNaN(num))
				{
					num = 1.0;
					type = global::Microsoft.Windows.Controls.DataGridLengthUnitType.Auto;
				}
				else
				{
					type = global::Microsoft.Windows.Controls.DataGridLengthUnitType.Pixel;
				}
				if (!double.IsInfinity(num))
				{
					return new global::Microsoft.Windows.Controls.DataGridLength(num, type);
				}
			}
			throw base.GetConvertFromException(value);
		}

		// Token: 0x060007BD RID: 1981 RVA: 0x00022900 File Offset: 0x00020B00
		[global::System.Security.SecurityCritical]
		public override object ConvertTo(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Globalization.CultureInfo culture, object value, global::System.Type destinationType)
		{
			if (destinationType == null)
			{
				throw new global::System.ArgumentNullException("destinationType");
			}
			if (value != null && value is global::Microsoft.Windows.Controls.DataGridLength)
			{
				global::Microsoft.Windows.Controls.DataGridLength length = (global::Microsoft.Windows.Controls.DataGridLength)value;
				if (destinationType == typeof(string))
				{
					return global::Microsoft.Windows.Controls.DataGridLengthConverter.ConvertToString(length, culture);
				}
				if (destinationType == typeof(global::System.ComponentModel.Design.Serialization.InstanceDescriptor))
				{
					global::System.Reflection.ConstructorInfo constructor = typeof(global::Microsoft.Windows.Controls.DataGridLength).GetConstructor(new global::System.Type[]
					{
						typeof(double),
						typeof(global::Microsoft.Windows.Controls.DataGridLengthUnitType)
					});
					return new global::System.ComponentModel.Design.Serialization.InstanceDescriptor(constructor, new object[]
					{
						length.Value,
						length.UnitType
					});
				}
			}
			throw base.GetConvertToException(value, destinationType);
		}

		// Token: 0x060007BE RID: 1982 RVA: 0x000229C0 File Offset: 0x00020BC0
		internal static string ConvertToString(global::Microsoft.Windows.Controls.DataGridLength length, global::System.Globalization.CultureInfo cultureInfo)
		{
			switch (length.UnitType)
			{
			case global::Microsoft.Windows.Controls.DataGridLengthUnitType.Auto:
			case global::Microsoft.Windows.Controls.DataGridLengthUnitType.SizeToCells:
			case global::Microsoft.Windows.Controls.DataGridLengthUnitType.SizeToHeader:
				return length.UnitType.ToString();
			case global::Microsoft.Windows.Controls.DataGridLengthUnitType.Star:
				if (!global::MS.Internal.DoubleUtil.IsOne(length.Value))
				{
					return global::System.Convert.ToString(length.Value, cultureInfo) + "*";
				}
				return "*";
			}
			return global::System.Convert.ToString(length.Value, cultureInfo);
		}

		// Token: 0x060007BF RID: 1983 RVA: 0x00022A3C File Offset: 0x00020C3C
		private static global::Microsoft.Windows.Controls.DataGridLength ConvertFromString(string s, global::System.Globalization.CultureInfo cultureInfo)
		{
			string text = s.Trim().ToLowerInvariant();
			for (int i = 0; i < 3; i++)
			{
				string b = global::Microsoft.Windows.Controls.DataGridLengthConverter._unitStrings[i];
				if (text == b)
				{
					return new global::Microsoft.Windows.Controls.DataGridLength(1.0, (global::Microsoft.Windows.Controls.DataGridLengthUnitType)i);
				}
			}
			double value = 0.0;
			global::Microsoft.Windows.Controls.DataGridLengthUnitType dataGridLengthUnitType = global::Microsoft.Windows.Controls.DataGridLengthUnitType.Pixel;
			int length = text.Length;
			int num = 0;
			double num2 = 1.0;
			int num3 = global::Microsoft.Windows.Controls.DataGridLengthConverter._unitStrings.Length;
			for (int j = 3; j < num3; j++)
			{
				string text2 = global::Microsoft.Windows.Controls.DataGridLengthConverter._unitStrings[j];
				if (text.EndsWith(text2, global::System.StringComparison.Ordinal))
				{
					num = text2.Length;
					dataGridLengthUnitType = (global::Microsoft.Windows.Controls.DataGridLengthUnitType)j;
					break;
				}
			}
			if (num == 0)
			{
				num3 = global::Microsoft.Windows.Controls.DataGridLengthConverter._nonStandardUnitStrings.Length;
				for (int k = 0; k < num3; k++)
				{
					string text3 = global::Microsoft.Windows.Controls.DataGridLengthConverter._nonStandardUnitStrings[k];
					if (text.EndsWith(text3, global::System.StringComparison.Ordinal))
					{
						num = text3.Length;
						num2 = global::Microsoft.Windows.Controls.DataGridLengthConverter._pixelUnitFactors[k];
						break;
					}
				}
			}
			if (length == num)
			{
				if (dataGridLengthUnitType == global::Microsoft.Windows.Controls.DataGridLengthUnitType.Star)
				{
					value = 1.0;
				}
			}
			else
			{
				string value2 = text.Substring(0, length - num);
				value = global::System.Convert.ToDouble(value2, cultureInfo) * num2;
			}
			return new global::Microsoft.Windows.Controls.DataGridLength(value, dataGridLengthUnitType);
		}

		// Token: 0x04000274 RID: 628
		private const int NumDescriptiveUnits = 3;

		// Token: 0x04000275 RID: 629
		private static string[] _unitStrings = new string[]
		{
			"auto",
			"px",
			"sizetocells",
			"sizetoheader",
			"*"
		};

		// Token: 0x04000276 RID: 630
		private static string[] _nonStandardUnitStrings = new string[]
		{
			"in",
			"cm",
			"pt"
		};

		// Token: 0x04000277 RID: 631
		private static double[] _pixelUnitFactors = new double[]
		{
			96.0,
			37.79527559055118,
			1.3333333333333333
		};
	}
}
