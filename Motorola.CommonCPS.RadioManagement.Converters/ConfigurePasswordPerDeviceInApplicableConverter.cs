using System;
using System.Globalization;
using System.Windows.Data;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x02000052 RID: 82
	public class ConfigurePasswordPerDeviceInApplicableConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x060000F9 RID: 249 RVA: 0x0000DE00 File Offset: 0x0000C000
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			switch (0)
			{
			case 0:
				goto IL_30;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_61;
				case 1:
					if ((global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily)value != global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.MNIS)
					{
						num2 = (short)1899167751;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_15F;
				case 2:
					if ((global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily)value == global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.VRC)
					{
						num2 = (short)198377477;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1CC;
				case 3:
					if ((global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily)value != global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.DMR3Controller)
					{
						num2 = (short)1358692356;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_15F;
				case 4:
				{
					num2 = (short)1086652416;
					short num3 = num2;
					num2 = (short)1302265857;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 5:
					goto IL_A2;
				case 6:
					if (value == null)
					{
						num2 = (short)1507328000;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)981270531;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					num2 = (short)719847426;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_30;
			}
			IL_61:
			return false;
			IL_A2:
			num2 = (short)914343972;
			short num4 = num2;
			num2 = (short)284543012;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_61;
			default:
				num2 = (short)1399324672;
				if (num2 != 0)
				{
				}
				break;
			}
			IL_15F:
			num2 = (short)863698945;
			if (num2 != 0)
			{
			}
			return true;
			IL_1CC:
			return false;
			IL_30:
			num2 = (short)507183110;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060000FA RID: 250 RVA: 0x0000DFE0 File Offset: 0x0000C1E0
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1362692817;
			short num2 = num;
			num = (short)1644825297;
			switch (num2 == num)
			{
			}
			num = (short)1309212673;
			if (num != 0)
			{
			}
			num = (short)1256521728;
			if (num != 0)
			{
			}
			num = (short)215941120;
			short num3 = num;
			throw new global::System.NotImplementedException();
		}
	}
}
