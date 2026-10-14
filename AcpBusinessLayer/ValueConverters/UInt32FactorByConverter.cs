using System;
using System.Globalization;
using System.Windows.Data;

namespace AcpBusinessLayer.ValueConverters
{
	// Token: 0x02000046 RID: 70
	public class UInt32FactorByConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x060004CA RID: 1226 RVA: 0x00067504 File Offset: 0x00065704
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)750714880;
			short num2 = num;
			num = (short)634810070;
			short num3 = num;
			num = (short)1916956374;
			switch (num3 == num)
			{
			}
			num = (short)1422065665;
			if (num != 0)
			{
			}
			num = (short)35586048;
			if (num != 0)
			{
			}
			return (uint)value * this.a;
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x000675C0 File Offset: 0x000657C0
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1382940672;
			short num2 = num;
			num = (short)57848276;
			short num3 = num;
			num = (short)552514004;
			switch (num3 == num)
			{
			}
			num = (short)2043543553;
			if (num != 0)
			{
			}
			num = (short)1814495232;
			if (num != 0)
			{
			}
			return global::System.Convert.ToUInt32(value) / this.a;
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x00067678 File Offset: 0x00065878
		public UInt32FactorByConverter(uint x)
		{
			this.a = x;
		}

		// Token: 0x0400014C RID: 332
		private uint a;
	}
}
