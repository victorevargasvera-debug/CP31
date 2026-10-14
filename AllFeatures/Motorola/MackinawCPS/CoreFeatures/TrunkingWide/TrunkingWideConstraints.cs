using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using AcpBusinessLayer;
using AcpCommonLib;
using Motorola.MackinawCPS.CoreFeatures.TrunkingSystem;

namespace Motorola.MackinawCPS.CoreFeatures.TrunkingWide
{
	// Token: 0x02000059 RID: 89
	public static class TrunkingWideConstraints
	{
		// Token: 0x060005A9 RID: 1449 RVA: 0x0005F094 File Offset: 0x0005D294
		internal static bool ConIsPhase2ScramblingDisableApplicable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1901264897;
			if (num != 0)
			{
			}
			num = (short)158269440;
			short num2 = num;
			global::System.Collections.ObjectModel.Collection<global::AcpBusinessLayer.FeatureNode> collection = global::AcpCommonLib.FeatureManager.GetFeature(2064) as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemRecset;
			bool result = false;
			global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = collection.GetEnumerator();
			try
			{
				num = (short)1503330312;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)1316880390;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
						num = (short)855244807;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						goto IL_20A;
					case 2:
						goto IL_13C;
					case 3:
					{
						global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
						if ((acpFeatureNode[10162] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO26).TrkSysASTRO25Phase2VoiceCapable_A37972.Value)
						{
							num = (short)821493765;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 4:
						goto IL_1EE;
					case 5:
					{
						result = true;
						num = (short)1394639348;
						short num4 = num;
						num = (short)926515700;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_13C;
						default:
							num = (short)294518784;
							if (num != 0)
							{
							}
							num = (short)286326788;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 6:
						num = (short)1425539073;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
					{
						global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
						if ((acpFeatureNode[10157] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.General).TrkSysGeneralSystemType_A9252.Value == 3)
						{
							num = (short)1843593218;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 8:
						switch (0)
						{
						case 0:
							goto IL_B1;
						}
						continue;
					}
					IL_101:
					num = (short)250544128;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_B1:
					goto IL_101;
					IL_13C:
					num = (short)1964965891;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_1EE:
				IL_20A:;
			}
			finally
			{
				num = (short)172294146;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						enumerator.Dispose();
						num = (short)12582913;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_270;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_23D;
						}
						continue;
					}
					IL_23D:
					if (enumerator == null)
					{
						break;
					}
					num = (short)672202752;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_270:;
			}
			return result;
		}
	}
}
