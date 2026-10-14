using System;
using AcpCommonLib;
using ConstraintHelper;
using Motorola.MackinawCPS.CoreFeatures.DVRSWide;
using SpecialFeatures.AcpReportManagerLib;
using SpecialFeatures.DVRSXML;

namespace SpecialFeatures.Clone_Configuration.Common
{
	// Token: 0x0200018D RID: 397
	public class DVRSXmlUtil
	{
		// Token: 0x06001320 RID: 4896 RVA: 0x001BAD78 File Offset: 0x001B8F78
		public static int ExportDVRSAfterClone(string serialNumber)
		{
			int a_ = 17;
			short num = (short)1814953984;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)2147221505;
				if (num != 0)
				{
				}
				num = (short)1858469888;
				short num3 = num;
				switch (0)
				{
				case 0:
					goto IL_B0;
				}
				global::SpecialFeatures.DVRSXML.DvrsMsuDataSync dvrsMsuDataSync;
				int result;
				global::Motorola.MackinawCPS.CoreFeatures.DVRSWide.DVRSWide dvrswide;
				for (;;)
				{
					IL_81:
					int num4;
					switch (num2)
					{
					case 0:
						num4 = 1;
						goto IL_1CB;
					case 1:
						if (dvrsMsuDataSync != null)
						{
							num = (short)134479878;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 2:
						goto IL_1EA;
					case 3:
					{
						string xmlFullPath;
						if (!dvrsMsuDataSync.ExportToXmlDoc(xmlFullPath))
						{
							num = (short)1128857605;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_114;
					}
					case 4:
						if (dvrswide.General.RadErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911.Value)
						{
							num = (short)1620246535;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1EA;
					case 5:
						num = (short)1363279880;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
					{
						string xmlFullPath = string.Format(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꚕ욙꾝\udd9f", a_), global::ConstraintHelper.UtilityMack.DVRSExportPath, dvrsMsuDataSync.BuildFileName(serialNumber));
						num = (short)10420227;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
					{
						dvrsMsuDataSync = new global::SpecialFeatures.DVRSXML.DvrsMsuDataSync();
						uint num5 = dvrsMsuDataSync.CalculateHashCode();
						dvrswide.General.DVRSWideLabtoolDVRSSyncFieldsHash_A41811.SetValue((long)((ulong)num5));
						num = (short)1425997826;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
					{
						num = (short)1217158689;
						short num6 = num;
						num = (short)1825463841;
						switch ((num6 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_114;
						default:
							num = (short)249167872;
							if (num != 0)
							{
							}
							num4 = 0;
							goto IL_1CB;
						}
						break;
					}
					case 9:
						return result;
					}
					goto IL_B0;
					IL_114:
					num = (short)111476736;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1CB:
					result = num4;
					num = (short)1963655177;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1EA:
					num = (short)1926103041;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_B0:
				result = -1;
				dvrsMsuDataSync = null;
				dvrswide = (global::AcpCommonLib.FeatureManager.GetFeature(4142)[0] as global::Motorola.MackinawCPS.CoreFeatures.DVRSWide.DVRSWide);
				num = (short)1990852612;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_81;
			}
			}
		}
	}
}
