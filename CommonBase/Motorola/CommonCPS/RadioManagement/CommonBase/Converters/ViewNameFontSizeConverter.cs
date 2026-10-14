using System;
using System.Globalization;
using System.Windows.Data;

namespace Motorola.CommonCPS.RadioManagement.CommonBase.Converters
{
	// Token: 0x0200001F RID: 31
	public class ViewNameFontSizeConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x060000C9 RID: 201 RVA: 0x00017AE8 File Offset: 0x00015CE8
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1919549441;
			int num2 = (int)((global::System.IntPtr)num);
			double num3;
			double num5;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_4B;
				case 1:
					goto IL_14;
				case 2:
				{
					if (double.TryParse((string)parameter, out num3))
					{
						num = (short)1697775619;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)264202824;
					short num4 = num;
					num = (short)1827695176;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_14;
					default:
						goto IL_F4;
					}
					break;
				}
				case 3:
					goto IL_95;
				}
				goto IL_34;
				IL_14:
				switch (0)
				{
				case 0:
					IL_34:
					if (value == null)
					{
						num = (short)307232768;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num5 = (double)value;
						num = (short)1817378818;
						num2 = (int)((global::System.IntPtr)num);
					}
					break;
				}
			}
			IL_4B:
			return null;
			IL_95:
			num = (short)1467809793;
			if (num != 0)
			{
			}
			return num5 + num3;
			IL_F4:
			num = (short)1454768128;
			if (num != 0)
			{
			}
			num = (short)901251072;
			short num6 = num;
			return num5;
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00017C2C File Offset: 0x00015E2C
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)2059137193;
			short num2 = num;
			num = (short)631107753;
			switch (num2 == num)
			{
			default:
			{
				num = (short)613613568;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)367067137;
			if (num != 0)
			{
			}
			num = (short)1337065472;
			if (num != 0)
			{
			}
			return value;
		}
	}
}
