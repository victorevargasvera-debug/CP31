using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using Motorola.CommonCPS.RadioManagement.Global;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x02000045 RID: 69
	public class SetDebuggerToVisibilityConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x060000D1 RID: 209 RVA: 0x0000B6B4 File Offset: 0x000098B4
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)2100232192;
			short num2 = num;
			num = (short)888864769;
			int num3 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num3)
				{
				case 0:
				{
					if (!global::Motorola.CommonCPS.RadioManagement.Global.SetDebugger.IsShowAllSetsInSetMode)
					{
						goto IL_135;
					}
					num = (short)2032862462;
					short num4 = num;
					num = (short)2032796926;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_68;
					default:
						num = (short)1936588801;
						if (num != 0)
						{
						}
						num = (short)389152768;
						if (num != 0)
						{
						}
						num = (short)1680474115;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					switch (0)
					{
					case 0:
						goto IL_5D;
					}
					continue;
				case 2:
					num = (short)1161428992;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_130;
				}
				goto IL_5D;
				IL_68:
				num = (short)362020866;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_5D:
				if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ModeIdentifier == global::Motorola.CommonCPS.RadioManagement.Global.ModeIdentifier.Configuration)
				{
					goto IL_68;
				}
				goto IL_135;
			}
			IL_130:
			return global::System.Windows.Visibility.Visible;
			IL_135:
			return global::System.Windows.Visibility.Collapsed;
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x0000B7FC File Offset: 0x000099FC
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1762163323;
			short num2 = num;
			num = (short)709393019;
			switch (num2 == num)
			{
			}
			num = (short)813236225;
			if (num != 0)
			{
			}
			num = (short)2086141952;
			short num3 = num;
			num = (short)1991245824;
			if (num != 0)
			{
			}
			return new global::System.NotImplementedException();
		}
	}
}
