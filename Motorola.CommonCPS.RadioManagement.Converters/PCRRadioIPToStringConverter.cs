using System;
using System.Globalization;
using System.Windows.Data;
using Motorola.CommonCPS.ResourceRepository;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x0200001A RID: 26
	public class PCRRadioIPToStringConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x0600004E RID: 78 RVA: 0x00005798 File Offset: 0x00003998
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 19;
			short num = (short)299531657;
			short num2 = num;
			num = (short)1956674953;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_F6:
				num = (short)501153794;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)1961689088;
				if (num != 0)
				{
				}
				num = (short)1692729345;
				num3 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				switch (num3)
				{
				case 0:
					goto IL_141;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_88;
					}
					continue;
				case 2:
					if (string.Compare((string)value, global::Motorola.CommonCPS.RadioManagement.Converters.ZeroBasedAccessTextToOneBasedAccessText.b("컽⻿㈁⨃㘅☇㨉", a_), global::System.StringComparison.OrdinalIgnoreCase) == 0)
					{
						num = (short)23658496;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_145;
				case 3:
					goto IL_EE;
				}
				IL_88:
				num = (short)368902145;
				if (num != 0)
				{
				}
				num = (short)1733885952;
				short num4 = num;
				if (value != null)
				{
					goto IL_F6;
				}
				num = (short)604438531;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_EE:
			return null;
			IL_141:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.Not_Applicable;
			IL_145:
			return value.ToString();
		}

		// Token: 0x0600004F RID: 79 RVA: 0x000058F0 File Offset: 0x00003AF0
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 16;
			short num = (short)390051050;
			short num2 = num;
			num = (short)1625404650;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_DD:
				num = (short)168820738;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)431751168;
				if (num != 0)
				{
				}
				num = (short)1293221889;
				num3 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				switch (num3)
				{
				case 0:
					goto IL_142;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_8A;
					}
					continue;
				case 2:
					num = (short)295436289;
					if (num != 0)
					{
					}
					if (string.Compare((string)value, global::Motorola.CommonCPS.ResourceRepository.Resources.Not_Applicable, global::System.StringComparison.OrdinalIgnoreCase) == 0)
					{
						num = (short)1057554432;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return value;
				case 3:
					goto IL_CC;
				}
				IL_8A:
				if (value != null)
				{
					goto IL_DD;
				}
				num = (short)443285504;
				short num4 = num;
				num = (short)521994243;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_CC:
			return null;
			IL_142:
			return global::Motorola.CommonCPS.RadioManagement.Converters.ZeroBasedAccessTextToOneBasedAccessText.b("쯺폼쿾⼀㌂⬄㜆", a_);
		}
	}
}
