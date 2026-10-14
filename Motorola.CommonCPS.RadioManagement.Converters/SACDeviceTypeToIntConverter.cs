using System;
using System.Globalization;
using System.Windows.Data;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x02000041 RID: 65
	public class SACDeviceTypeToIntConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x060000C5 RID: 197 RVA: 0x0000AA8C File Offset: 0x00008C8C
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 7;
			switch (0)
			{
			case 0:
				goto IL_25;
			}
			int num;
			short num2;
			global::Motorola.CommonCPS.Server.CommonDBConstants.SACDeviceType sacdeviceType;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1137069399;
					short num3 = num2;
					num2 = (short)1082412375;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_EE;
					default:
						num2 = (short)463994880;
						if (num2 != 0)
						{
						}
						num2 = (short)1607204865;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
					goto IL_10D;
				case 2:
					num2 = (short)108789761;
					if (num2 != 0)
					{
					}
					switch (sacdeviceType)
					{
					case global::Motorola.CommonCPS.Server.CommonDBConstants.SACDeviceType.MOTOROLADEVICE:
						goto IL_10F;
					case global::Motorola.CommonCPS.Server.CommonDBConstants.SACDeviceType.NONMOTOROLARADIO:
						goto IL_13E;
					case global::Motorola.CommonCPS.Server.CommonDBConstants.SACDeviceType.CONSOLE:
						goto IL_EE;
					case global::Motorola.CommonCPS.Server.CommonDBConstants.SACDeviceType.VOICEGATEWAY:
						goto IL_145;
					case global::Motorola.CommonCPS.Server.CommonDBConstants.SACDeviceType.DATAGATEWAY:
						goto IL_E7;
					default:
						num2 = (short)904855552;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				goto IL_25;
			}
			IL_E7:
			return 3;
			IL_EE:
			return 1;
			IL_10D:
			throw new global::System.NotImplementedException(global::Motorola.CommonCPS.RadioManagement.Converters.ZeroBasedAccessTextToOneBasedAccessText.b("韱蛳蓵韷裹", a_));
			IL_10F:
			num2 = (short)1732706304;
			short num4 = num2;
			return 4;
			IL_13E:
			return 0;
			IL_145:
			return 2;
			IL_25:
			sacdeviceType = (global::Motorola.CommonCPS.Server.CommonDBConstants.SACDeviceType)value;
			num2 = (short)1887371266;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x0000ABF8 File Offset: 0x00008DF8
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 6;
			switch (0)
			{
			case 0:
				goto IL_25;
			}
			int num;
			short num2;
			int num4;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1230244171;
					short num3 = num2;
					num2 = (short)592644427;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_E8;
					default:
						num2 = (short)1019215872;
						if (num2 != 0)
						{
						}
						num2 = (short)354615297;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
					goto IL_108;
				case 2:
					switch (num4)
					{
					case 0:
						goto IL_13A;
					case 1:
						goto IL_E8;
					case 2:
						goto IL_141;
					case 3:
						goto IL_BA;
					case 4:
						goto IL_10A;
					default:
						num2 = (short)1900412928;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				goto IL_25;
			}
			IL_BA:
			num2 = (short)262733825;
			if (num2 != 0)
			{
			}
			return global::Motorola.CommonCPS.Server.CommonDBConstants.SACDeviceType.DATAGATEWAY;
			IL_E8:
			return global::Motorola.CommonCPS.Server.CommonDBConstants.SACDeviceType.CONSOLE;
			IL_108:
			throw new global::System.NotImplementedException(global::Motorola.CommonCPS.RadioManagement.Converters.ZeroBasedAccessTextToOneBasedAccessText.b("铰臲蟴飶诸", a_));
			IL_10A:
			num2 = (short)2033057792;
			short num5 = num2;
			return global::Motorola.CommonCPS.Server.CommonDBConstants.SACDeviceType.MOTOROLADEVICE;
			IL_13A:
			return global::Motorola.CommonCPS.Server.CommonDBConstants.SACDeviceType.NONMOTOROLARADIO;
			IL_141:
			return global::Motorola.CommonCPS.Server.CommonDBConstants.SACDeviceType.VOICEGATEWAY;
			IL_25:
			num4 = (int)value;
			num2 = (short)1465974786;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}
	}
}
