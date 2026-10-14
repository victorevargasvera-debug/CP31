using System;
using System.Globalization;
using System.Windows.Data;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x0200002F RID: 47
	public class ExtendedFeatureStatusConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x0600008F RID: 143 RVA: 0x0000892C File Offset: 0x00006B2C
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 10;
			switch (0)
			{
			case 0:
				goto IL_29;
			}
			int num;
			short num2;
			global::Motorola.CommonCPS.Server.CommonDBConstants.RadioFeatureStatus radioFeatureStatus;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1226079800;
					short num3 = num2;
					num2 = (short)409304632;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)1904672768;
						if (num2 != 0)
						{
						}
						if (radioFeatureStatus < global::Motorola.CommonCPS.Server.CommonDBConstants.RadioFeatureStatus.RadioPermanentlyEnabled)
						{
							goto IL_101;
						}
						break;
					}
					num2 = (short)2019229698;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					if (radioFeatureStatus > global::Motorola.CommonCPS.Server.CommonDBConstants.RadioFeatureStatus.RadioAvailableAndNotUsed)
					{
						num2 = (short)91029507;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_14C;
				case 2:
					num2 = (short)309985281;
					if (num2 != 0)
					{
					}
					num2 = (short)193462273;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					goto IL_14A;
				}
				goto IL_29;
			}
			IL_101:
			throw new global::System.ArgumentOutOfRangeException(global::Motorola.CommonCPS.RadioManagement.Converters.ZeroBasedAccessTextToOneBasedAccessText.b("냴迶跸黺鏼鯾搀朂┄䄆氈樊礌税挐瘒㔔䐖洘稚検樞删̢䰤否न䐪堬嬮ᄰ尲匴᜶䬸娺匼堾⑀浂", a_));
			IL_14A:
			goto IL_101;
			IL_14C:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.ResourceManager.GetString(radioFeatureStatus.ToString(), culture);
			IL_29:
			radioFeatureStatus = (global::Motorola.CommonCPS.Server.CommonDBConstants.RadioFeatureStatus)value;
			num2 = (short)1634598912;
			short num4 = num2;
			num2 = (short)1983578112;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00008AA0 File Offset: 0x00006CA0
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1587675137;
			if (num != 0)
			{
			}
			num = (short)2089920554;
			short num2 = num;
			num = (short)1024632874;
			switch (num2 == num)
			{
			}
			num = (short)1949368320;
			if (num != 0)
			{
			}
			num = (short)1966211072;
			short num3 = num;
			throw new global::System.NotImplementedException();
		}
	}
}
