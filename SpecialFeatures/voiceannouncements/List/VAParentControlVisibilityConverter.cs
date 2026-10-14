using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using AcpCommonLib;

namespace SpecialFeatures.VoiceAnnouncements.List
{
	// Token: 0x0200002E RID: 46
	public class VAParentControlVisibilityConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x0600066B RID: 1643 RVA: 0x0005DEA8 File Offset: 0x0005C0A8
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1445003275;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1236533257;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_D2;
				case 2:
					if (values[4] != global::System.Windows.DependencyProperty.UnsetValue)
					{
						num = (short)881917956;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_370;
				case 3:
					if (!bool.Parse(values[4].ToString()))
					{
						num = (short)1457848321;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_15E;
				case 4:
					num = (short)1985282056;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					num = (short)1459945484;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					if (values[1] != global::System.Windows.DependencyProperty.UnsetValue)
					{
						num = (short)432996366;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_370;
				case 7:
					num = (short)525598733;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					if ((global::AcpCommonLib.ApplicationMode)values[0] == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num = (short)1011875845;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1E7;
				case 9:
					if (values[3] != global::System.Windows.DependencyProperty.UnsetValue)
					{
						num = (short)1143603216;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_370;
				case 10:
					num = (short)268304390;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					switch (0)
					{
					case 0:
						goto IL_6C;
					}
					continue;
				case 12:
					if (bool.Parse(values[1].ToString()))
					{
						num = (short)27983879;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1E7;
				case 13:
					if (bool.Parse(values[2].ToString()))
					{
						num = (short)1082654735;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_15E;
				case 14:
				{
					num = (short)1333854208;
					short num3 = num;
					num = (short)1549205521;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 15:
				{
					num = (short)108331009;
					if (num != 0)
					{
					}
					num = (short)1789508559;
					short num4 = num;
					num = (short)1675934671;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_135;
					default:
						num = (short)1631649792;
						if (num != 0)
						{
						}
						num = (short)1863843843;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 16:
					num = (short)1406926850;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					goto IL_135;
				}
				IL_6C:
				if (values[0] != global::System.Windows.DependencyProperty.UnsetValue)
				{
					num = (short)218628106;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_370;
				IL_135:
				if (values[2] == global::System.Windows.DependencyProperty.UnsetValue)
				{
					goto IL_370;
				}
				num = (short)692322304;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_D2:
			return false;
			IL_15E:
			return bool.Parse(values[3].ToString());
			IL_1E7:
			return bool.Parse(values[3].ToString());
			IL_370:
			return false;
		}

		// Token: 0x0600066C RID: 1644 RVA: 0x0005E22C File Offset: 0x0005C42C
		public object[] ConvertBack(object value, global::System.Type[] targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1687976958;
			short num2 = num;
			num = (short)308509694;
			switch (num2 == num)
			{
			}
			num = (short)635633664;
			if (num != 0)
			{
			}
			num = (short)274792449;
			if (num != 0)
			{
			}
			num = (short)1570963456;
			short num3 = num;
			throw new global::System.NotImplementedException();
		}
	}
}
