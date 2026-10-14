using System;
using System.Globalization;
using System.Windows.Controls;
using System.Windows.Data;

namespace DevComponents.WpfRibbon.Converters
{
	// Token: 0x020000D5 RID: 213
	public class ImagePositionToDockConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x060008C8 RID: 2248 RVA: 0x000C8584 File Offset: 0x000C6784
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			switch (0)
			{
			case 0:
				goto IL_66;
			}
			short num;
			int num2;
			global::DevComponents.WpfRibbon.eButtonImagePosition eButtonImagePosition;
			for (;;)
			{
				IL_0A:
				num = (short)1543045121;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
					goto IL_AB;
				case 1:
					num = (short)1344667650;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
				{
					num = (short)1792768220;
					short num3 = num;
					num = (short)1084389596;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_11D;
					default:
					{
						num = (short)1704984576;
						if (num != 0)
						{
						}
						num = (short)1378418688;
						short num4 = num;
						if (eButtonImagePosition == global::DevComponents.WpfRibbon.eButtonImagePosition.Bottom)
						{
							num = (short)1490223111;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)132972552;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 3:
					if (targetType == typeof(global::System.Windows.Controls.Dock))
					{
						num = (short)1103691777;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_279;
				case 4:
					goto IL_17F;
				case 5:
					goto IL_11D;
				case 6:
					goto IL_274;
				case 7:
					goto IL_23A;
				case 8:
					if (eButtonImagePosition == global::DevComponents.WpfRibbon.eButtonImagePosition.Left)
					{
						num = (short)740425734;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1699086347;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					goto IL_13C;
				case 10:
					if (targetType == typeof(string))
					{
						num = (short)542769152;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)398852099;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					if (eButtonImagePosition == global::DevComponents.WpfRibbon.eButtonImagePosition.Right)
					{
						num = (short)525467652;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)897122309;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_66;
				IL_11D:
				if (eButtonImagePosition != global::DevComponents.WpfRibbon.eButtonImagePosition.Top)
				{
					goto IL_279;
				}
				num = (short)2093219849;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_AB:
			return eButtonImagePosition.ToString();
			IL_13C:
			return global::System.Windows.Controls.Dock.Top;
			IL_17F:
			return global::System.Windows.Controls.Dock.Right;
			IL_23A:
			return global::System.Windows.Controls.Dock.Bottom;
			IL_274:
			return global::System.Windows.Controls.Dock.Left;
			IL_279:
			return null;
			IL_66:
			eButtonImagePosition = (global::DevComponents.WpfRibbon.eButtonImagePosition)value;
			num = (short)815398922;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x060008C9 RID: 2249 RVA: 0x000C880C File Offset: 0x000C6A0C
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)806791475;
			short num2 = num;
			num = (short)362850611;
			switch (num2 == num)
			{
			}
			num = (short)747175937;
			if (num != 0)
			{
			}
			num = (short)1977942016;
			if (num != 0)
			{
			}
			num = (short)1104150528;
			short num3 = num;
			return (global::DevComponents.WpfRibbon.eButtonImagePosition)global::System.Enum.Parse(typeof(global::DevComponents.WpfRibbon.eButtonImagePosition), value.ToString());
		}
	}
}
