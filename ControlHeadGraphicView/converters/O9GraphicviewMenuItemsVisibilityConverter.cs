using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using AcpBusinessLayer;

namespace ControlHeadGraphicView.converters
{
	// Token: 0x02000014 RID: 20
	public class O9GraphicviewMenuItemsVisibilityConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x06000D48 RID: 3400 RVA: 0x000C7200 File Offset: 0x000C5400
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1353973768;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::AcpBusinessLayer.AcpListField acpListField;
				switch (num2)
				{
				case 0:
					goto IL_C2;
				case 1:
					if (acpListField.Visible)
					{
						num = (short)789184518;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_194;
				case 2:
					num = (short)423100421;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					acpListField.CalculateVisibility();
					num = (short)220069889;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
				{
					num = (short)1496121344;
					short num3 = num;
					if (values[1] != global::System.Windows.DependencyProperty.UnsetValue)
					{
						num = (short)757137410;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_21C;
				}
				case 5:
					if (values[2] != global::System.Windows.DependencyProperty.UnsetValue)
					{
						num = (short)150863872;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_21C;
				case 6:
					goto IL_217;
				case 7:
					if (acpListField != null)
					{
						num = (short)1822031875;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_21C;
				case 8:
					switch (0)
					{
					case 0:
						goto IL_4C;
					}
					continue;
				case 9:
				{
					num = (short)1881286584;
					short num4 = num;
					num = (short)1989093304;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_C2;
					default:
						num = (short)392298496;
						if (num != 0)
						{
						}
						num = (short)552796161;
						if (num != 0)
						{
						}
						num = (short)181338116;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				IL_4C:
				if (values[0] != global::System.Windows.DependencyProperty.UnsetValue)
				{
					num = (short)701825033;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_21C;
				IL_C2:
				acpListField = (values[1] as global::AcpBusinessLayer.AcpListField);
				num = (short)1554317319;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_194:
			return global::System.Windows.Visibility.Hidden;
			IL_217:
			return global::System.Windows.Visibility.Visible;
			IL_21C:
			return global::System.Windows.Visibility.Hidden;
		}

		// Token: 0x06000D49 RID: 3401 RVA: 0x000C7430 File Offset: 0x000C5630
		public object[] ConvertBack(object value, global::System.Type[] targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 11;
			short num = (short)1161445391;
			short num2 = num;
			num = (short)650723343;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1251868672;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1245184001;
			if (num != 0)
			{
			}
			num = (short)1347420160;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException(global::ControlHeadGraphicView.converters.O9GraphicviewMenuItemsVisibilityConverter.b("笵崷丹吻儽␿扁⩃⥅㱇橉╋⍍⁏㹑ㅓ㭕㵗㑙⡛㭝џ", a_));
		}

		// Token: 0x06000D4B RID: 3403 RVA: 0x000C7508 File Offset: 0x000C5708
		internal static string b(string A_0, int A_1)
		{
			char[] array = A_0.ToCharArray();
			int num = (int)((global::System.IntPtr)(883281681 + A_1) + (global::System.IntPtr)83 + (global::System.IntPtr)57 + (global::System.IntPtr)52 + (global::System.IntPtr)83 + (global::System.IntPtr)6);
			int num3;
			int num2;
			if ((num2 = (num3 = 0)) < 1)
			{
				goto IL_6A;
			}
			IL_37:
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
			IL_6A:
			if ((num2 = num3) >= array.Length)
			{
				return string.Intern(new string(array));
			}
			goto IL_37;
		}
	}
}
