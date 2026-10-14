using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using Motorola.CommonCPS.RadioManagement.Global;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x02000095 RID: 149
	public class ModuleNameToVisibilityConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x060001C3 RID: 451 RVA: 0x00017348 File Offset: 0x00015548
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1663696897;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_11A;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_34;
					}
					continue;
				case 2:
					goto IL_117;
				case 3:
					goto IL_132;
				}
				IL_34:
				num = (short)958529537;
				if (num != 0)
				{
				}
				if ((string)parameter == global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainModule)
				{
					num = (short)1905000450;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)673316864;
				short num3 = num;
				num = (short)633582398;
				short num4 = num;
				num = (short)763015998;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1315307520;
					if (num != 0)
					{
					}
					num = (short)1410662400;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_11A:
				num = (short)204996611;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_117:
			global::System.Windows.Visibility visibility = global::System.Windows.Visibility.Visible;
			goto IL_135;
			IL_132:
			visibility = global::System.Windows.Visibility.Collapsed;
			IL_135:
			return visibility;
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x00017490 File Offset: 0x00015690
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1463635325;
			short num2 = num;
			num = (short)1753828733;
			switch (num2 == num)
			{
			}
			num = (short)539623424;
			short num3 = num;
			num = (short)2067857409;
			if (num != 0)
			{
			}
			num = (short)232521728;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
