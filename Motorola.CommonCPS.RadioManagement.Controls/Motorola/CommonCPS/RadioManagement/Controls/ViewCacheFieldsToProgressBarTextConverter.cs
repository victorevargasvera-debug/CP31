using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using Motorola.CommonCPS.ResourceRepository;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x02000036 RID: 54
	internal class ViewCacheFieldsToProgressBarTextConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x060000A6 RID: 166 RVA: 0x0000B6A8 File Offset: 0x000098A8
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1625489408;
			switch (num)
			{
			default:
			{
				num = (short)1017091377;
				short num2 = num;
				num = (short)339776817;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_1B8:
					num = (short)1603207171;
					num3 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)290914304;
					if (num != 0)
					{
					}
					num = (short)572456960;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				object obj;
				int num4;
				int num5;
				global::System.TimeSpan? timeSpan;
				for (;;)
				{
					switch (num3)
					{
					case 0:
						num = (short)1140654081;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_D6;
						}
						continue;
					case 1:
						goto IL_1B8;
					case 2:
						goto IL_1D5;
					case 3:
						if (!string.IsNullOrEmpty(obj.ToString()))
						{
							num = (short)238878725;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_FD;
					case 4:
						if (values[3] != null)
						{
							num = (short)1651900417;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_FD;
					case 5:
						goto IL_235;
					case 6:
						num = (short)147718146;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_12D;
					}
					IL_D6:
					if (values[0] == global::System.Windows.DependencyProperty.UnsetValue)
					{
						num = (short)1359282182;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					obj = values[3];
					num = (short)2113667076;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_FD:
					num4 = (int)values[0];
					num5 = (int)values[1];
					timeSpan = (global::System.TimeSpan?)values[2];
					num = (short)1604976647;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_12D:
				return string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_RMDatagrid_ProgressBarText, num5, num4, (timeSpan == null) ? 0 : global::System.Convert.ToInt32(timeSpan.Value.TotalSeconds));
				IL_1D5:
				return string.Empty;
				IL_235:
				num = (short)1632436224;
				short num6 = num;
				return obj;
			}
			}
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x0000B8FC File Offset: 0x00009AFC
		public object[] ConvertBack(object value, global::System.Type[] targetTypes, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1056135388;
			short num2 = num;
			num = (short)1984387292;
			switch (num2 == num)
			{
			}
			num = (short)2118123520;
			if (num != 0)
			{
			}
			num = (short)509345792;
			short num3 = num;
			num = (short)1451884545;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
