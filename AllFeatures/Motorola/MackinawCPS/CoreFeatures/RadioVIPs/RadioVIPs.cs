using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using Common;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.RadioVIPs
{
	// Token: 0x020002E6 RID: 742
	[global::System.Serializable]
	public class RadioVIPs : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x060078C7 RID: 30919 RVA: 0x006DE77C File Offset: 0x006DC97C
		public RadioVIPs(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 5;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("铅꧇껉ꗋꇍ蓑鷓蛕ꯗ", a_);
			base.UIName = global::CommonResources.AcgResources.ID_RADIOVIPS;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("蟅꓇ꛉ請ꯍ뇏ꛑꇓꓕ뷗꧙鷝迟迡铣觥蛧迩苫髭곯ꃱ闳鋵釷闹\udcfb믽狿攁欃栅朇有攋洍挏㈑圓礕瘗簙甛礝唟倡䔣別䄧䔩䈫爭猯崱娳䈵䨷唹倻䴽᰿၁╃≅ⅇ╉汋ᡍ᥏ɑ❓੕੗㭙㡛㝝ཟ㑡ⵣ㙥᭧䑩ᑫ཭ᵯṱ", a_);
			global::Common.CodeplugStatus status = global::Common.CodeplugStatusManager.Status;
			global::Common.CodeplugStatusManager.Status = global::Common.CodeplugStatus.Opening;
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.General(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.GCAI(this));
			global::Common.CodeplugStatusManager.Status = status;
		}

		// Token: 0x060078C8 RID: 30920 RVA: 0x006DE7F4 File Offset: 0x006DC9F4
		protected RadioVIPs(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 12;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("鿌껎뗐뫒뫔还鋚跜곞", a_);
			base.UIName = global::CommonResources.AcgResources.ID_RADIOVIPS;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("賌ꏎ뷐闒냔뛖귘껚꿜뫞鋠\ud8e2ꛤ裦蓨鯪苬臮铰鷲致꯶꯸髺駼雾渀⌂䀄甆済搊挌怎簐稒瘔搖㤘堚爜焞䜠䨢䈤刦嬨䨪夬䘮帰崲椴琶嘸唺䤼䴾⹀⽂㙄ᭆᭈ⩊⥌♎㹐獒͔Ṗक़⡚Ŝ൞`ݢ౤ࡦ㽨≪㵬ᱮ彰୲ᑴ᩶ᕸ", a_);
		}

		// Token: 0x17003E17 RID: 15895
		// (get) Token: 0x060078C9 RID: 30921 RVA: 0x006DE848 File Offset: 0x006DCA48
		public global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.General General
		{
			get
			{
				short num = (short)1589075237;
				short num2 = num;
				num = (short)482434341;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1137311744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)525926401;
				if (num != 0)
				{
				}
				num = (short)1153433600;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.General)base[10218];
			}
		}

		// Token: 0x17003E18 RID: 15896
		// (get) Token: 0x060078CA RID: 30922 RVA: 0x006DE904 File Offset: 0x006DCB04
		public global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.GCAI GCAI
		{
			get
			{
				short num = (short)1761675750;
				short num2 = num;
				num = (short)694815206;
				switch (num2 == num)
				{
				default:
				{
					num = (short)122945536;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1753808896;
				if (num != 0)
				{
				}
				num = (short)1466630145;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.GCAI)base[10797];
			}
		}

		// Token: 0x060078CB RID: 30923 RVA: 0x006DE9BC File Offset: 0x006DCBBC
		public static global::AcpCommonLib.IAcpFeatureNode GetRadioVIPs()
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			global::AcpCommonLib.IAcpFeatureNode result;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					result = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2125)[0];
					goto IL_E6;
				case 1:
				{
					num2 = (short)1156251344;
					short num3 = num2;
					num2 = (short)36044496;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_E6;
					default:
						goto IL_134;
					}
					break;
				}
				case 2:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
					{
						num2 = (short)1871577088;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					result = global::AcpCommonLib.FeatureManager.GetFeature(2125)[0];
					num2 = (short)528416771;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					goto IL_A6;
				}
				goto IL_20;
				IL_E6:
				num2 = (short)1700462593;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_A6:
			num2 = (short)274857985;
			if (num2 != 0)
			{
			}
			return result;
			IL_134:
			num2 = (short)554172416;
			if (num2 != 0)
			{
			}
			return result;
			IL_20:
			num2 = (short)94699520;
			short num4 = num2;
			result = null;
			num2 = (short)2007236610;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}
	}
}
