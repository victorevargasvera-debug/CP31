using System;
using System.Globalization;
using System.Windows.Data;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x02000030 RID: 48
	public class IPProgramSystemTypeToStringConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000092 RID: 146 RVA: 0x00008B64 File Offset: 0x00006D64
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 13;
			switch (0)
			{
			case 0:
				goto IL_25;
			}
			int num;
			short num2;
			global::Motorola.CommonCPS.Server.CommonDBConstants.IPProgramSystemType ipprogramSystemType;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1903427008;
					short num3 = num2;
					num2 = (short)1400700352;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)582418432;
						if (num2 != 0)
						{
						}
						switch (ipprogramSystemType)
						{
						case global::Motorola.CommonCPS.Server.CommonDBConstants.IPProgramSystemType.Other:
							goto IL_E4;
						case global::Motorola.CommonCPS.Server.CommonDBConstants.IPProgramSystemType.DMR3:
							goto IL_DE;
						case global::Motorola.CommonCPS.Server.CommonDBConstants.IPProgramSystemType.LE:
							goto IL_129;
						}
						break;
					}
					num2 = (short)192741377;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					num2 = (short)1878392833;
					if (num2 != 0)
					{
					}
					num2 = (short)673841154;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_127;
				}
				goto IL_25;
			}
			IL_DE:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_IPProgramSystem_DMR3;
			IL_E4:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_IPProgramSystem_Other;
			IL_127:
			throw new global::System.NotImplementedException(global::Motorola.CommonCPS.RadioManagement.Converters.ZeroBasedAccessTextToOneBasedAccessText.b("鷷裹軻釽狿", a_));
			IL_129:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_IPProgramSystem_LE;
			IL_25:
			ipprogramSystemType = (global::Motorola.CommonCPS.Server.CommonDBConstants.IPProgramSystemType)value;
			num2 = (short)615972864;
			short num4 = num2;
			num2 = (short)978190336;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00008CB4 File Offset: 0x00006EB4
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1325334529;
			if (num != 0)
			{
			}
			num = (short)403716593;
			short num2 = num;
			num = (short)520960497;
			switch (num2 == num)
			{
			}
			num = (short)1004339200;
			if (num != 0)
			{
			}
			num = (short)1291452416;
			short num3 = num;
			throw new global::System.NotSupportedException();
		}
	}
}
