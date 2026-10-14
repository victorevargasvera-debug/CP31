using System;
using AcpCommonLib;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures
{
	// Token: 0x0200000F RID: 15
	public class LastSetJobUuidHelper
	{
		// Token: 0x06000034 RID: 52 RVA: 0x00007328 File Offset: 0x00005528
		public static void SetLastSetJobUuidField(string guidToSet = null)
		{
			int a_ = 2;
			short num = (short)382402561;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Guid guid;
				switch (num2)
				{
				case 0:
					num = (short)986120196;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
				{
					num = (short)1503068160;
					short num3 = num;
					num = (short)1692890673;
					short num4 = num;
					num = (short)307000881;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_CD;
					default:
						num = (short)1040711680;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_B3;
						}
						continue;
					}
					break;
				}
				case 2:
					goto IL_CD;
				case 3:
					goto IL_12E;
				case 4:
					if (!global::System.Guid.TryParse(guidToSet, out guid))
					{
						num = (short)1866596354;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_16D;
				}
				IL_B3:
				if (guidToSet != null)
				{
					num = (short)1768095744;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_CD:
				num = (short)2088763393;
				if (num != 0)
				{
				}
				guid = global::System.Guid.NewGuid();
				guidToSet = guid.ToString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쮄", a_)).ToUpper();
				num = (short)764542979;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_12E:
			IL_16D:
			(global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide).Labtool.RadWideLabtoolRCLastJobSetUUIDValue = guidToSet;
		}
	}
}
