using System;
using System.Globalization;
using System.Windows.Data;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x0200009F RID: 159
	public class IPAddressEditCharacterConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x060001E1 RID: 481 RVA: 0x00019064 File Offset: 0x00017264
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 19;
			short num = (short)590232637;
			short num2 = num;
			num = (short)1339702333;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1942421504;
				if (num != 0)
				{
				}
				num = (short)1798111234;
				num3 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				switch (num3)
				{
				case 0:
					goto IL_14E;
				case 1:
				{
					num = (short)1662058497;
					if (num != 0)
					{
					}
					num = (short)233177088;
					short num4 = num;
					num = (short)1402929155;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					switch (0)
					{
					case 0:
						goto IL_88;
					}
					continue;
				case 3:
					if (value.ToString() == global::Motorola.CommonCPS.RadioManagement.Converters.ZeroBasedAccessTextToOneBasedAccessText.b("폽", a_))
					{
						num = (short)467730432;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return value;
				}
				IL_88:
				if (value == null)
				{
					return value;
				}
				num = (short)1081933825;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_14E:
			return global::Motorola.CommonCPS.RadioManagement.Converters.ZeroBasedAccessTextToOneBasedAccessText.b("탽", a_);
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x000191C8 File Offset: 0x000173C8
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1935147009;
			if (num != 0)
			{
			}
			num = (short)2081751040;
			short num2 = num;
			num = (short)1487703423;
			short num3 = num;
			num = (short)1838976383;
			switch (num3 == num)
			{
			}
			num = (short)2110521344;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
