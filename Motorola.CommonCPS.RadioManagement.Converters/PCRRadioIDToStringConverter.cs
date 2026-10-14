using System;
using System.Globalization;
using System.Windows.Data;
using Motorola.CommonCPS.ResourceRepository;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x02000065 RID: 101
	public class PCRRadioIDToStringConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000133 RID: 307 RVA: 0x00010AC8 File Offset: 0x0000ECC8
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1607991298;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_4B;
				case 1:
				{
					if (int.Parse(value.ToString(), global::System.Globalization.CultureInfo.InvariantCulture) != -1)
					{
						goto IL_13A;
					}
					num = (short)1468727296;
					short num3 = num;
					num = (short)2124778785;
					short num4 = num;
					num = (short)1767476513;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num = (short)777977856;
						if (num != 0)
						{
						}
						num = (short)1550254083;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
					switch (0)
					{
					case 0:
						goto IL_34;
					}
					continue;
				case 3:
					goto IL_133;
				}
				IL_34:
				if (value == null)
				{
					num = (short)7471104;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)503709697;
					if (num != 0)
					{
					}
					num = (short)1592262657;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_4B:
			return null;
			IL_133:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.Not_Applicable;
			IL_13A:
			return value.ToString();
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00010C18 File Offset: 0x0000EE18
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)260964355;
			int num2 = (int)((global::System.IntPtr)num);
			string text;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (string.Compare(text, global::Motorola.CommonCPS.ResourceRepository.Resources.Not_Applicable, global::System.StringComparison.OrdinalIgnoreCase) == 0)
					{
						num = (short)399114242;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_186;
				case 1:
					if (string.IsNullOrEmpty(text))
					{
						num = (short)875429893;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)300941312;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_BD;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_3C;
					}
					continue;
				case 4:
					goto IL_56;
				case 5:
					goto IL_181;
				}
				IL_3C:
				if (value != null)
				{
					text = value.ToString();
					num = (short)1410295884;
					short num3 = num;
					num = (short)443574348;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)206110720;
						if (num != 0)
						{
						}
						num = (short)2010841089;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
				}
				num = (short)1613234180;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_56:
			num = (short)1152581633;
			if (num != 0)
			{
			}
			num = (short)268763136;
			short num4 = num;
			return null;
			IL_BD:
			return -1;
			IL_181:
			return null;
			IL_186:
			return int.Parse(text, global::System.Globalization.CultureInfo.CurrentCulture);
		}
	}
}
