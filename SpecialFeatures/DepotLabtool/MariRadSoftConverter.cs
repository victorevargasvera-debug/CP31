using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.DepotLabtool
{
	// Token: 0x02000138 RID: 312
	public class MariRadSoftConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x0600104C RID: 4172 RVA: 0x0016CD00 File Offset: 0x0016AF00
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 6;
			short num = (short)159121412;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)17956865;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
				{
					if (values.Length != 1)
					{
						goto IL_18F;
					}
					num = (short)2067403683;
					short num3 = num;
					num = (short)975508387;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
					{
						num = (short)1408499713;
						if (num != 0)
						{
						}
						num = (short)773324800;
						short num4 = num;
						num = (short)347930624;
						if (num != 0)
						{
						}
						num = (short)1058537475;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 2:
					goto IL_B6;
				case 3:
					num = (short)272039941;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_45;
					}
					continue;
				case 5:
					if (values[0].ToString().Equals(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쒈릊뾌쒎슐삒겔잖캘ꪚ\udc9c톞", a_)))
					{
						num = (short)34930690;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_18F;
				}
				IL_45:
				if (values == null)
				{
					goto IL_18F;
				}
				num = (short)47841280;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_B6:
			return global::System.Windows.Visibility.Visible;
			IL_18F:
			return global::System.Windows.Visibility.Hidden;
		}

		// Token: 0x0600104D RID: 4173 RVA: 0x0016CEA4 File Offset: 0x0016B0A4
		public object[] ConvertBack(object value, global::System.Type[] targetTypes, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)300220417;
			if (num != 0)
			{
			}
			num = (short)1864761668;
			short num2 = num;
			num = (short)1954873668;
			switch (num2 == num)
			{
			}
			num = (short)560398336;
			short num3 = num;
			num = (short)2033451008;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
