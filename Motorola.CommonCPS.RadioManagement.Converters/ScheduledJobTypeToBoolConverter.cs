using System;
using System.Globalization;
using System.Windows.Data;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x0200009A RID: 154
	public class ScheduledJobTypeToBoolConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x060001D2 RID: 466 RVA: 0x00018218 File Offset: 0x00016418
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1610883112;
			short num2 = num;
			num = (short)483729448;
			switch (num2 == num)
			{
			}
			num = (short)1666252801;
			if (num != 0)
			{
			}
			num = (short)1388445696;
			if (num != 0)
			{
			}
			num = (short)1838350336;
			short num3 = num;
			return value.ToString() == (string)parameter;
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x000182D8 File Offset: 0x000164D8
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 9;
			switch (0)
			{
			case 0:
				goto IL_3D;
			}
			short num2;
			string a;
			for (;;)
			{
				IL_13:
				int num;
				switch (num)
				{
				case 0:
					num2 = (short)48562177;
					if (num2 != 0)
					{
					}
					num2 = (short)2126643201;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (!(a == global::Motorola.CommonCPS.RadioManagement.Converters.ZeroBasedAccessTextToOneBasedAccessText.b("닳韵鯷軹鏻賽秿倁愃甅洇縉", a_)))
					{
						num2 = (short)1123352580;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_15D;
				case 2:
					if (!(a == global::Motorola.CommonCPS.RadioManagement.Converters.ZeroBasedAccessTextToOneBasedAccessText.b("꛳鏵駷黹", a_)))
					{
						num2 = (short)1044774919;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_E0;
				case 3:
					if (!(a == global::Motorola.CommonCPS.RadioManagement.Converters.ZeroBasedAccessTextToOneBasedAccessText.b("ꏳ蓵釷軹駻", a_)))
					{
						num2 = (short)1311768576;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1DC;
				case 4:
					goto IL_246;
				case 5:
					goto IL_1FC;
				case 6:
					if (!(a == global::Motorola.CommonCPS.RadioManagement.Converters.ZeroBasedAccessTextToOneBasedAccessText.b("ꟳ臵釷軹鿻雽濿琁愃琅", a_)))
					{
						num2 = (short)32374792;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_D9;
				case 7:
					num2 = (short)66846726;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
				{
					num2 = (short)1586429952;
					short num3 = num2;
					num2 = (short)402325507;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_3D;
			}
			IL_D9:
			return global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduledJobType.Switchover;
			IL_E0:
			return global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduledJobType.Read;
			IL_15D:
			return global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduledJobType.FactoryReset;
			IL_1DC:
			return global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduledJobType.Write;
			IL_1FC:
			return null;
			IL_3D:
			a = (string)parameter;
			num2 = (short)1593856255;
			short num4 = num2;
			num2 = (short)1287344383;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_246:
				num2 = (short)965017605;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			default:
			{
				num2 = (short)2074804224;
				if (num2 != 0)
				{
				}
				num2 = (short)1608122370;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			}
		}
	}
}
