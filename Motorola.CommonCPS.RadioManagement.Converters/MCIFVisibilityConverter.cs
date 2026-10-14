using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using Motorola.Common.Communication.CommonUtil;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x02000013 RID: 19
	public class MCIFVisibilityConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000036 RID: 54 RVA: 0x000045E0 File Offset: 0x000027E0
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1418788865;
			if (num != 0)
			{
			}
			num = (short)611385344;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_3D;
				case 1:
					goto IL_130;
				case 2:
					num = (short)1358299139;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
				{
					if (!global::Motorola.Common.Communication.CommonUtil.PbbDeviceInfoConverters.IsMCIFSupportedByDevice(value.ToString()))
					{
						goto IL_135;
					}
					num = (short)2085606986;
					short num3 = num;
					num = (short)1596839498;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_3D;
					default:
					{
						num = (short)422379520;
						if (num != 0)
						{
						}
						num = (short)117702656;
						short num4 = num;
						num = (short)673775617;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				}
				goto IL_5D;
				IL_3D:
				switch (0)
				{
				case 0:
					IL_5D:
					if (value == null)
					{
						goto IL_135;
					}
					num = (short)842268674;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_130:
			return global::System.Windows.Visibility.Visible;
			IL_135:
			return global::System.Windows.Visibility.Collapsed;
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00004728 File Offset: 0x00002928
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1625358336;
			short num2 = num;
			num = (short)1171259393;
			if (num != 0)
			{
			}
			num = (short)1821517802;
			short num3 = num;
			num = (short)1137649642;
			switch (num3 == num)
			{
			}
			num = (short)968294400;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
