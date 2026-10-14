using System;
using System.Globalization;
using System.Windows.Controls;
using System.Windows.Data;

namespace DevComponents.WpfRibbon.Converters
{
	// Token: 0x020000D4 RID: 212
	public class ExpandPositionToDockConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x060008C5 RID: 2245 RVA: 0x000C8220 File Offset: 0x000C6420
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			switch (0)
			{
			case 0:
				goto IL_40;
			}
			int num;
			short num2;
			global::DevComponents.WpfRibbon.eExpandPosition eExpandPosition;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_82;
				case 1:
					num2 = (short)834469889;
					if (num2 != 0)
					{
					}
					num2 = (short)1059389442;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
				{
					num2 = (short)809123204;
					short num3 = num2;
					num2 = (short)1629568388;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_11B;
					default:
					{
						num2 = (short)312410112;
						if (num2 != 0)
						{
						}
						num2 = (short)480444416;
						short num4 = num2;
						if (eExpandPosition == global::DevComponents.WpfRibbon.eExpandPosition.Bottom)
						{
							num2 = (short)1900478471;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)163119112;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 3:
					if (targetType == typeof(global::System.Windows.Controls.Dock))
					{
						num2 = (short)820248577;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_279;
				case 4:
					goto IL_17E;
				case 5:
					goto IL_11B;
				case 6:
					goto IL_274;
				case 7:
					goto IL_238;
				case 8:
					if (eExpandPosition == global::DevComponents.WpfRibbon.eExpandPosition.Left)
					{
						num2 = (short)298450950;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1445068811;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					goto IL_13B;
				case 10:
					if (targetType == typeof(string))
					{
						num2 = (short)1092878336;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)97124355;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
					if (eExpandPosition == global::DevComponents.WpfRibbon.eExpandPosition.Right)
					{
						num2 = (short)96010244;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1299447813;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_40;
				IL_11B:
				if (eExpandPosition != global::DevComponents.WpfRibbon.eExpandPosition.Top)
				{
					goto IL_279;
				}
				num2 = (short)2065301513;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_82:
			return eExpandPosition.ToString();
			IL_13B:
			return global::System.Windows.Controls.Dock.Top;
			IL_17E:
			return global::System.Windows.Controls.Dock.Right;
			IL_238:
			return global::System.Windows.Controls.Dock.Bottom;
			IL_274:
			return global::System.Windows.Controls.Dock.Left;
			IL_279:
			return null;
			IL_40:
			eExpandPosition = (global::DevComponents.WpfRibbon.eExpandPosition)value;
			num2 = (short)544342026;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060008C6 RID: 2246 RVA: 0x000C84A8 File Offset: 0x000C66A8
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1228636013;
			short num2 = num;
			num = (short)762609517;
			switch (num2 == num)
			{
			}
			num = (short)1366687744;
			if (num != 0)
			{
			}
			num = (short)1155137537;
			if (num != 0)
			{
			}
			num = (short)1128464384;
			short num3 = num;
			return (global::DevComponents.WpfRibbon.eExpandPosition)global::System.Enum.Parse(typeof(global::DevComponents.WpfRibbon.eExpandPosition), value.ToString());
		}
	}
}
