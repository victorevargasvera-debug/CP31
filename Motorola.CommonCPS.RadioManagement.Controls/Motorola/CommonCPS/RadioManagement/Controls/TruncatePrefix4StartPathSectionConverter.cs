using System;
using System.Globalization;
using System.Windows.Data;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x020000AE RID: 174
	public class TruncatePrefix4StartPathSectionConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000467 RID: 1127 RVA: 0x00048474 File Offset: 0x00046674
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 6;
			switch (0)
			{
			case 0:
				goto IL_5B;
			}
			short num;
			int num2;
			string text;
			string text2;
			for (;;)
			{
				IL_13:
				num = (short)306839553;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
					return text;
				case 1:
					if (text != null)
					{
						num = (short)300875779;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					text = string.Empty;
					num = (short)334168066;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
				{
					num = (short)1352062658;
					short num3 = num;
					num = (short)2098714306;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_190;
					case 1:
						goto IL_124;
					}
					goto Block_2;
				}
				case 3:
					num = (short)1481900036;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (text.Contains(text2))
					{
						goto IL_190;
					}
					return text;
				case 5:
					text = text.Substring(text2.Length, text.Length - text2.Length);
					num = (short)977076224;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_5B;
				IL_190:
				num = (short)1491468293;
				num2 = (int)((global::System.IntPtr)num);
			}
			Block_2:
			num = (short)1713831936;
			short num4 = num;
			IL_124:
			num = (short)1286340608;
			if (num != 0)
			{
			}
			return text;
			IL_5B:
			text = (value as string);
			text2 = global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("\ude9dﾟ肣풥趧쾩쪫趭\ud9af첱첳", a_);
			num = (short)390856705;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_13;
		}

		// Token: 0x06000468 RID: 1128 RVA: 0x0004862C File Offset: 0x0004682C
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)882835457;
			if (num != 0)
			{
			}
			num = (short)2063851010;
			short num2 = num;
			num = (short)1386012162;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2018050048;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2089091072;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
