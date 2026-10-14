using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x020000E1 RID: 225
	internal class BoolToVisibilityConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x0600063A RID: 1594 RVA: 0x00063B9C File Offset: 0x00061D9C
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)474480640;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_34;
					}
					continue;
				case 1:
					goto IL_124;
				case 2:
					num = (short)1323106305;
					if (num != 0)
					{
					}
					goto IL_10D;
				case 3:
					goto IL_10A;
				}
				IL_34:
				if (!(bool)value)
				{
					num = (short)770048002;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)935855950;
				short num3 = num;
				num = (short)993724238;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)606404608;
					short num4 = num;
					num = (short)893386752;
					if (num != 0)
					{
					}
					num = (short)1637285891;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_10D:
				num = (short)2052521985;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_10A:
			global::System.Windows.Visibility visibility = global::System.Windows.Visibility.Visible;
			goto IL_127;
			IL_124:
			visibility = global::System.Windows.Visibility.Hidden;
			IL_127:
			return visibility;
		}

		// Token: 0x0600063B RID: 1595 RVA: 0x00063CD8 File Offset: 0x00061ED8
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)987561985;
			if (num != 0)
			{
			}
			num = (short)935348276;
			short num2 = num;
			num = (short)548161588;
			switch (num2 == num)
			{
			}
			num = (short)2015166464;
			short num3 = num;
			num = (short)2014314496;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
