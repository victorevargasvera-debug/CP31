using System;
using System.Globalization;
using System.Windows.Data;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x02000092 RID: 146
	public class EmptyStringToNullValueConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x060001BA RID: 442 RVA: 0x00016A50 File Offset: 0x00014C50
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)192020251;
			short num2 = num;
			num = (short)2129919771;
			switch (num2 == num)
			{
			}
			num = (short)1979318272;
			short num3 = num;
			num = (short)1550647297;
			if (num != 0)
			{
			}
			num = (short)1062273024;
			if (num != 0)
			{
			}
			return value;
		}

		// Token: 0x060001BB RID: 443 RVA: 0x00016AFC File Offset: 0x00014CFC
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)336592899;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				string a;
				switch (num2)
				{
				case 0:
					a = null;
					goto IL_128;
				case 1:
					a = value.ToString();
					goto IL_128;
				case 2:
				{
					num = (short)1655177217;
					if (num != 0)
					{
					}
					num = (short)1107099648;
					short num3 = num;
					num = (short)1774845952;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
					switch (0)
					{
					case 0:
						goto IL_3C;
					}
					continue;
				case 4:
				{
					num = (short)1899445258;
					short num4 = num;
					num = (short)1251884042;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_C1;
					default:
						goto IL_110;
					}
					break;
				}
				case 5:
					goto IL_C1;
				}
				IL_3C:
				if (value == null)
				{
					num = (short)1246887938;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1660157953;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_C1:
				num = (short)1254817796;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_128:
				if (a == string.Empty)
				{
					goto IL_16F;
				}
				num = (short)428736517;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_110:
			num = (short)1367146496;
			if (num != 0)
			{
			}
			return value;
			IL_16F:
			return null;
		}
	}
}
