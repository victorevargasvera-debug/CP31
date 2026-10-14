using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x0200000A RID: 10
	public class BoolToVisibilityHiddenConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000017 RID: 23 RVA: 0x00002F94 File Offset: 0x00001194
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)335806467;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_121;
				case 1:
					num = (short)1164902400;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
				{
					num = (short)329383937;
					if (num != 0)
					{
					}
					num = (short)1041824336;
					short num3 = num;
					num = (short)1217264208;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_14;
					default:
						goto IL_F2;
					}
					break;
				}
				case 3:
					goto IL_14;
				}
				goto IL_34;
				IL_14:
				switch (0)
				{
				case 0:
					IL_34:
					if (!(bool)value)
					{
						num = (short)1568669697;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)670892032;
						short num4 = num;
						num = (short)638582786;
						num2 = (int)((global::System.IntPtr)num);
					}
					break;
				}
			}
			IL_F2:
			num = (short)866648064;
			if (num != 0)
			{
			}
			global::System.Windows.Visibility visibility = global::System.Windows.Visibility.Visible;
			goto IL_124;
			IL_121:
			visibility = global::System.Windows.Visibility.Hidden;
			IL_124:
			return visibility;
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000030CC File Offset: 0x000012CC
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1830223872;
			short num2 = num;
			num = (short)1407019099;
			short num3 = num;
			num = (short)684288091;
			switch (num3 == num)
			{
			}
			num = (short)1328349185;
			if (num != 0)
			{
			}
			num = (short)524484608;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
