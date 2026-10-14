using System;
using System.Globalization;
using System.Windows.Data;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x0200003E RID: 62
	public class IPProgramSystemTypeToIntConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x060000BC RID: 188 RVA: 0x0000A36C File Offset: 0x0000856C
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 4;
			switch (0)
			{
			case 0:
				goto IL_4C;
			}
			short num;
			int num2;
			global::Motorola.CommonCPS.Server.CommonDBConstants.IPProgramSystemType ipprogramSystemType;
			for (;;)
			{
				IL_13:
				num = (short)1365377025;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
				{
					num = (short)1470098653;
					short num3 = num;
					num = (short)1219488989;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_69;
					case 1:
						break;
					default:
					{
						num = (short)1945698304;
						short num4 = num;
						break;
					}
					}
					num = (short)2102198272;
					if (num != 0)
					{
					}
					num = (short)1130102785;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					goto IL_12E;
				case 2:
					goto IL_69;
				}
				goto IL_4C;
				IL_69:
				switch (ipprogramSystemType)
				{
				case global::Motorola.CommonCPS.Server.CommonDBConstants.IPProgramSystemType.Other:
					goto IL_99;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.IPProgramSystemType.DMR3:
					goto IL_92;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.IPProgramSystemType.LE:
					goto IL_130;
				default:
					num = (short)461570048;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_92:
			return 1;
			IL_99:
			return 0;
			IL_12E:
			throw new global::System.NotImplementedException(global::Motorola.CommonCPS.RadioManagement.Converters.ZeroBasedAccessTextToOneBasedAccessText.b("諮菰臲髴藶", a_));
			IL_130:
			return 2;
			IL_4C:
			ipprogramSystemType = (global::Motorola.CommonCPS.Server.CommonDBConstants.IPProgramSystemType)value;
			num = (short)2002649090;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_13;
		}

		// Token: 0x060000BD RID: 189 RVA: 0x0000A4C4 File Offset: 0x000086C4
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 7;
			switch (0)
			{
			case 0:
				goto IL_4B;
			}
			short num;
			int num2;
			int num5;
			for (;;)
			{
				IL_13:
				num = (short)454819841;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
				{
					num = (short)2130991238;
					short num3 = num;
					num = (short)568088710;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_67;
					case 1:
						break;
					default:
					{
						num = (short)83099648;
						short num4 = num;
						break;
					}
					}
					num = (short)107544576;
					if (num != 0)
					{
					}
					num = (short)583729153;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					goto IL_12A;
				case 2:
					goto IL_67;
				}
				goto IL_4B;
				IL_67:
				switch (num5)
				{
				case 0:
					goto IL_97;
				case 1:
					goto IL_90;
				case 2:
					goto IL_12C;
				default:
					num = (short)1816920064;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_90:
			return global::Motorola.CommonCPS.Server.CommonDBConstants.IPProgramSystemType.DMR3;
			IL_97:
			return global::Motorola.CommonCPS.Server.CommonDBConstants.IPProgramSystemType.Other;
			IL_12A:
			throw new global::System.NotImplementedException(global::Motorola.CommonCPS.RadioManagement.Converters.ZeroBasedAccessTextToOneBasedAccessText.b("韱蛳蓵韷裹", a_));
			IL_12C:
			return global::Motorola.CommonCPS.Server.CommonDBConstants.IPProgramSystemType.LE;
			IL_4B:
			num5 = (int)value;
			num = (short)487653378;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_13;
		}
	}
}
