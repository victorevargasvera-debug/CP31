using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using Common;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.DVRSWide
{
	// Token: 0x020004AF RID: 1199
	[global::System.Serializable]
	public class DVRSWide : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x06009DB3 RID: 40371 RVA: 0x00935378 File Offset: 0x00933578
		public DVRSWide(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 13;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("諍蛏胑蟓迗동룛믝", a_);
			base.UIName = global::CommonResources.AcgResources.ID_DVRSWIDE;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("迍볏뻑鋓돕맗껙꧛곝藟釡\udfe3ꗥ蟧蟩鳫臭黯韱髳苵ꓷ뻹꫻곽叿∁䜃椅昇氉攋植攏怑甓戕焗甙爛䈝搟琡瘣甥ࠧ紩䔫䨭唯渱瀳怵樷椹欻圽␿❁橃㹅⥇❉⁋", a_);
			global::Common.CodeplugStatus status = global::Common.CodeplugStatusManager.Status;
			global::Common.CodeplugStatusManager.Status = global::Common.CodeplugStatus.Opening;
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.DVRSWide.General(this));
			global::Common.CodeplugStatusManager.Status = status;
		}

		// Token: 0x06009DB4 RID: 40372 RVA: 0x009353E4 File Offset: 0x009335E4
		protected DVRSWide(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 15;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("铏蓑蛓藕跙뗛뫝藟", a_);
			base.UIName = global::CommonResources.AcgResources.ID_DVRSWIDE;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("量뻑룓郕뷗믙꣛ꯝ鋟蟡韣\udde5ꯧ藩臫黭鿯鳱釳飵賷꛹룻ꣽ勿儁␃䔅朇搉樋服眏朑易眕気猙猛瀝簟昡爣琥笧਩笫䜭启圱栳爵渷根漻椽⤿♁⅃桅ぇ⭉⅋≍", a_);
		}

		// Token: 0x17004F30 RID: 20272
		// (get) Token: 0x06009DB5 RID: 40373 RVA: 0x00935438 File Offset: 0x00933638
		public global::Motorola.MackinawCPS.CoreFeatures.DVRSWide.General General
		{
			get
			{
				short num = (short)2040135681;
				if (num != 0)
				{
				}
				num = (short)94575345;
				short num2 = num;
				num = (short)1429478129;
				switch (num2 == num)
				{
				}
				num = (short)1941045248;
				short num3 = num;
				num = (short)761135104;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.DVRSWide.General)base[10758];
			}
		}

		// Token: 0x06009DB6 RID: 40374 RVA: 0x009354F0 File Offset: 0x009336F0
		public static global::AcpCommonLib.IAcpFeatureNode GetDVRSWide()
		{
			int num;
			global::AcpCommonLib.IAcpFeatureNode result;
			short num2;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						return result;
					case 1:
						if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
						{
							num2 = (short)92995587;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						result = global::AcpCommonLib.FeatureManager.GetFeature(4142)[0];
						num2 = (short)875626498;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
						return result;
					case 3:
					{
						result = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(4142)[0];
						num2 = (short)80740352;
						short num3 = num2;
						num2 = (short)1285632805;
						short num4 = num2;
						num2 = (short)1151939365;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_22;
						default:
							num2 = (short)1691615232;
							if (num2 != 0)
							{
							}
							num2 = (short)1275985921;
							if (num2 != 0)
							{
							}
							num2 = (short)2133655552;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					}
					goto IL_20;
				}
				return result;
			}
			IL_20:
			result = null;
			IL_22:
			num2 = (short)253100033;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}
	}
}
