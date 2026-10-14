using System;
using System.Globalization;
using System.Windows.Data;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x0200003B RID: 59
	internal class RmcPasswordStringConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x060000B5 RID: 181 RVA: 0x0000C230 File Offset: 0x0000A430
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 9;
			short num = (short)916258816;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)293472042;
				short num3 = num;
				num = (short)1089603370;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1877671936;
					if (num != 0)
					{
					}
					num = (short)1793720320;
					short num4 = num;
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_B0;
						}
						continue;
					case 1:
						num = (short)456589315;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_125;
					case 3:
						if (value.ToString() != global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("ꆠ", a_))
						{
							num = (short)207028226;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_127;
					}
					break;
				}
				}
				IL_B0:
				if (value == null)
				{
					goto IL_127;
				}
				num = (short)191037441;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_125:
			return global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("讠", a_);
			IL_127:
			num = (short)1959788545;
			if (num != 0)
			{
			}
			return string.Empty;
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x0000C390 File Offset: 0x0000A590
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1779368878;
			short num2 = num;
			num = (short)2127168430;
			switch (num2 == num)
			{
			}
			num = (short)1356464128;
			short num3 = num;
			num = (short)1615790080;
			if (num != 0)
			{
			}
			num = (short)2085486593;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
