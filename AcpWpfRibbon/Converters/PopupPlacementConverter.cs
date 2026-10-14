using System;
using System.Globalization;
using System.Windows.Controls.Primitives;
using System.Windows.Data;

namespace DevComponents.WpfRibbon.Converters
{
	// Token: 0x020000D8 RID: 216
	public class PopupPlacementConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x060008D1 RID: 2257 RVA: 0x000C8C78 File Offset: 0x000C6E78
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			switch (0)
			{
			case 0:
				goto IL_48;
			}
			int num;
			short num2;
			global::DevComponents.WpfRibbon.ePopupPlacement ePopupPlacement;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)721223681;
					if (num2 != 0)
					{
					}
					if (targetType == typeof(global::System.Windows.Controls.Primitives.PlacementMode))
					{
						num2 = (short)46989321;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2CE;
				case 1:
					goto IL_27E;
				case 2:
				{
					num2 = (short)569180463;
					short num3 = num2;
					num2 = (short)184680751;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_151;
					default:
						num2 = (short)842661888;
						if (num2 != 0)
						{
						}
						if (ePopupPlacement == global::DevComponents.WpfRibbon.ePopupPlacement.Top)
						{
							num2 = (short)1486749701;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)1113522184;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 3:
					if (ePopupPlacement == global::DevComponents.WpfRibbon.ePopupPlacement.Right)
					{
						num2 = (short)688455687;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)144703490;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					goto IL_8F;
				case 5:
					goto IL_117;
				case 6:
					goto IL_1C7;
				case 7:
					goto IL_151;
				case 8:
					if (ePopupPlacement == global::DevComponents.WpfRibbon.ePopupPlacement.Custom)
					{
						num2 = (short)2029125638;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2CE;
				case 9:
					num2 = (short)490143755;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					if (ePopupPlacement == global::DevComponents.WpfRibbon.ePopupPlacement.Left)
					{
						num2 = (short)2013462529;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)940834819;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
					if (ePopupPlacement == global::DevComponents.WpfRibbon.ePopupPlacement.Bottom)
					{
						num2 = (short)1550909453;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)778895370;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 12:
					if (targetType == typeof(string))
					{
						num2 = (short)751697924;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)286457856;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 13:
					goto IL_18C;
				}
				goto IL_48;
			}
			IL_8F:
			return ePopupPlacement.ToString();
			IL_117:
			return global::System.Windows.Controls.Primitives.PlacementMode.Top;
			IL_151:
			return global::System.Windows.Controls.Primitives.PlacementMode.Right;
			IL_18C:
			return global::System.Windows.Controls.Primitives.PlacementMode.Bottom;
			IL_1C7:
			return global::System.Windows.Controls.Primitives.PlacementMode.Absolute;
			IL_27E:
			num2 = (short)1760624640;
			short num4 = num2;
			return global::System.Windows.Controls.Primitives.PlacementMode.Left;
			IL_2CE:
			return null;
			IL_48:
			ePopupPlacement = (global::DevComponents.WpfRibbon.ePopupPlacement)value;
			num2 = (short)1203437580;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060008D2 RID: 2258 RVA: 0x000C8F54 File Offset: 0x000C7154
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			switch (0)
			{
			case 0:
				goto IL_30;
			}
			int num;
			global::System.Windows.Controls.Primitives.PlacementMode placementMode;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_1C0;
				case 1:
					goto IL_69;
				case 2:
					goto IL_12F;
				case 3:
					if (placementMode == global::System.Windows.Controls.Primitives.PlacementMode.Top)
					{
						num2 = (short)441516037;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)99680260;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
				{
					if (placementMode != global::System.Windows.Controls.Primitives.PlacementMode.Bottom)
					{
						goto IL_1CC;
					}
					num2 = (short)1924139196;
					short num3 = num2;
					num2 = (short)861472956;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_53;
					default:
						num2 = (short)1324875776;
						if (num2 != 0)
						{
						}
						num2 = (short)30277632;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 5:
					goto IL_FA;
				case 6:
					if (placementMode == global::System.Windows.Controls.Primitives.PlacementMode.Left)
					{
						goto IL_53;
					}
					num2 = (short)879755271;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
				{
					if (placementMode == global::System.Windows.Controls.Primitives.PlacementMode.Right)
					{
						num2 = (short)641728514;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1644888064;
					short num4 = num2;
					num2 = (short)189661187;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_30;
				IL_53:
				num2 = (short)219283457;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_69:
			num2 = (short)438894593;
			if (num2 != 0)
			{
			}
			return global::DevComponents.WpfRibbon.ePopupPlacement.Left;
			IL_FA:
			return global::DevComponents.WpfRibbon.ePopupPlacement.Top;
			IL_12F:
			return global::DevComponents.WpfRibbon.ePopupPlacement.Right;
			IL_1C0:
			return global::DevComponents.WpfRibbon.ePopupPlacement.Bottom;
			IL_1CC:
			return global::DevComponents.WpfRibbon.ePopupPlacement.Custom;
			IL_30:
			placementMode = (global::System.Windows.Controls.Primitives.PlacementMode)value;
			num2 = (short)1168834566;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060008D4 RID: 2260 RVA: 0x000C9148 File Offset: 0x000C7348
		internal static string b(string A_0, int A_1)
		{
			char[] array = A_0.ToCharArray();
			int num = (int)((global::System.IntPtr)(783821126 + A_1) + (global::System.IntPtr)93 + (global::System.IntPtr)47 + (global::System.IntPtr)55 + (global::System.IntPtr)78);
			int num3;
			int num2;
			if ((num2 = (num3 = 0)) < 1)
			{
				goto IL_63;
			}
			IL_30:
			int num5;
			int num4 = num5 = num2;
			char[] array2 = array;
			int num6 = num5;
			char c = array[num5];
			byte b = (byte)((int)(c & 'ÿ') ^ num++);
			byte b2 = (byte)((int)(c >> 8) ^ num++);
			byte b3 = b2;
			b2 = b;
			b = b3;
			array2[num6] = (ushort)((int)b2 << 8 | (int)b);
			num3 = num4 + 1;
			IL_63:
			if ((num2 = num3) >= array.Length)
			{
				return string.Intern(new string(array));
			}
			goto IL_30;
		}
	}
}
