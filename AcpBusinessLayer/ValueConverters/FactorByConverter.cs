using System;
using System.Globalization;
using System.Windows.Data;
using AcpCommonResources;

namespace AcpBusinessLayer.ValueConverters
{
	// Token: 0x0200004A RID: 74
	public class FactorByConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x060004D6 RID: 1238 RVA: 0x00067B50 File Offset: 0x00065D50
		private FactorByConverter()
		{
		}

		// Token: 0x060004D7 RID: 1239 RVA: 0x00067B64 File Offset: 0x00065D64
		public FactorByConverter(int factor, int uiOffset)
		{
			this.a = factor;
			this.b = uiOffset;
		}

		// Token: 0x060004D8 RID: 1240 RVA: 0x00067B88 File Offset: 0x00065D88
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1339424768;
			short num2 = num;
			num = (short)1449607606;
			short num3 = num;
			num = (short)713376182;
			switch (num3 == num)
			{
			}
			num = (short)1280704513;
			if (num != 0)
			{
			}
			num = (short)700121088;
			if (num != 0)
			{
			}
			return (this.b + (int)value * this.a).ToString();
		}

		// Token: 0x060004D9 RID: 1241 RVA: 0x00067C50 File Offset: 0x00065E50
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1324744704;
			short num2 = num;
			num = (short)1819738113;
			if (num != 0)
			{
			}
			num = (short)154616277;
			short num3 = num;
			num = (short)1841054165;
			switch (num3 == num)
			{
			}
			num = (short)504233984;
			if (num != 0)
			{
			}
			int num4 = int.Parse(value.ToString());
			if (num4 < this.b)
			{
				throw new global::System.ArgumentException(global::AcpCommonResources.AcpResources.UI_Value_Below_Offset);
			}
			int num5 = num4 - this.b;
			if (num5 % this.a != 0)
			{
				throw new global::System.ArgumentException(global::AcpCommonResources.AcpResources.UI_Value_Not_On_Step);
			}
			return num5 / this.a;
		}

		// Token: 0x0400014D RID: 333
		private int a;

		// Token: 0x0400014E RID: 334
		private int b;
	}
}
