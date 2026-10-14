using System;
using System.Globalization;
using System.Windows.Data;

namespace AcpBusinessLayer.ValueConverters
{
	// Token: 0x02000045 RID: 69
	public class UInt16FactorByConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x060004C6 RID: 1222 RVA: 0x00067350 File Offset: 0x00065550
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)625959964;
			short num2 = num;
			num = (short)1422156828;
			switch (num2 == num)
			{
			}
			num = (short)1024524288;
			short num3 = num;
			num = (short)283115521;
			if (num != 0)
			{
			}
			num = (short)203685888;
			if (num != 0)
			{
			}
			return (int)((ushort)value * this.a);
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x00067410 File Offset: 0x00065610
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)990887908;
			short num2 = num;
			num = (short)1826471908;
			switch (num2 == num)
			{
			}
			num = (short)837746688;
			short num3 = num;
			num = (short)1808269312;
			if (num != 0)
			{
			}
			num = (short)858259457;
			if (num != 0)
			{
			}
			return (int)(global::System.Convert.ToUInt16(value) / this.a);
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x000674CC File Offset: 0x000656CC
		public UInt16FactorByConverter(ushort x)
		{
			this.a = x;
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x000674E8 File Offset: 0x000656E8
		internal UInt16FactorByConverter()
		{
			this.a = 1;
		}

		// Token: 0x0400014B RID: 331
		private ushort a;
	}
}
