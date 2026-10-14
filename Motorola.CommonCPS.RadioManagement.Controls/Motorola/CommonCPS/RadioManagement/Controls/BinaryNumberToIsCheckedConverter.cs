using System;
using System.Globalization;
using System.Windows.Data;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x020000C7 RID: 199
	internal class BinaryNumberToIsCheckedConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000592 RID: 1426 RVA: 0x0005938C File Offset: 0x0005758C
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 15;
			short num = (short)1091326017;
			short num2 = num;
			num = (short)530731073;
			switch (num2 == num)
			{
			default:
			{
				num = (short)553582592;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1266352129;
			if (num != 0)
			{
			}
			num = (short)374931456;
			if (num != 0)
			{
			}
			return value.ToString() == global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("隦", a_);
		}

		// Token: 0x06000593 RID: 1427 RVA: 0x0005945C File Offset: 0x0005765C
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1532166144;
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
					goto IL_126;
				case 2:
					goto IL_109;
				case 3:
					num = (short)814481409;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_34:
				num = (short)1268187057;
				short num3 = num;
				num = (short)924385201;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)739966977;
					if (num != 0)
					{
					}
					num = (short)260571136;
					if (num != 0)
					{
					}
					num = (short)851968;
					short num4 = num;
					if (!(bool)value)
					{
						num = (short)1192230915;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				num = (short)585564162;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_109:
			char c = '1';
			goto IL_12A;
			IL_126:
			c = '0';
			IL_12A:
			return c;
		}
	}
}
