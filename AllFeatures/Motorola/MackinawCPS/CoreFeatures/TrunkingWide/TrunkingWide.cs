using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using Common;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.TrunkingWide
{
	// Token: 0x0200005C RID: 92
	[global::System.Serializable]
	public class TrunkingWide : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x060005AB RID: 1451 RVA: 0x0005F524 File Offset: 0x0005D724
		public TrunkingWide(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 11;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("飋볍ꗏ병뿓뿕뛗뷙ﳛ觝觟蛡臣", a_);
			base.UIName = global::CommonResources.AcgResources.ID_TRUNKINGWIDE;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("跋ꋍ볏铑뇓럕곗꿙껛믝鏟\ud9e1꟣觥藧髩菫胭闯鳱胳ꫵ곷裹觻都毿欁樃愅⠇䤉挋怍瘏笑猓挕樗笙栛眝伟䰡砣爥娧弩䈫䔭夯就匳ᘵ漷匹堻嬽᰿ᙁ㙃㍅♇ⅉ╋⁍㝏Ց㵓㉕㵗瑙⑛㽝ൟ๡", a_);
			global::Common.CodeplugStatus status = global::Common.CodeplugStatusManager.Status;
			global::Common.CodeplugStatusManager.Status = global::Common.CodeplugStatus.Opening;
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.TrunkingWide.General(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.TrunkingWide.FilterConstants(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.TrunkingWide.RSSIThresholds(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.TrunkingWide.CAIData(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.TrunkingWide.Advanced(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.TrunkingWide.Labtool(this));
			global::Common.CodeplugStatusManager.Status = status;
		}

		// Token: 0x060005AC RID: 1452 RVA: 0x0005F5CC File Offset: 0x0005D7CC
		protected TrunkingWide(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 10;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("鿊뿌뫎뿐룒볔맖뻘ﯚ諜뛞藠蛢", a_);
			base.UIName = global::CommonResources.AcgResources.ID_TRUNKINGWIDE;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("諊ꇌꏎ韐뛒듔ꏖ곘꧚룜곞\udae0ꃢ諤諦駨蓪菬諮鿰蟲꧴ꏶ诸軺鏼链栀洂戄✆䨈搊挌椎砐琒怔攖砘漚琜瀞传缢焤唦尨䔪䘬䘮弰吲ᔴ怶倸强堼挾ᕀㅂい⥆≈≊⍌⡎ِ㩒ㅔ㉖睘⍚㱜㉞ൠ", a_);
		}

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x060005AD RID: 1453 RVA: 0x0005F620 File Offset: 0x0005D820
		public global::Motorola.MackinawCPS.CoreFeatures.TrunkingWide.General General
		{
			get
			{
				short num = (short)665369992;
				short num2 = num;
				num = (short)1761852808;
				switch (num2 == num)
				{
				}
				num = (short)1278803969;
				if (num != 0)
				{
				}
				num = (short)881786880;
				short num3 = num;
				num = (short)320995328;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.TrunkingWide.General)base[10062];
			}
		}

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x060005AE RID: 1454 RVA: 0x0005F6D8 File Offset: 0x0005D8D8
		public global::Motorola.MackinawCPS.CoreFeatures.TrunkingWide.FilterConstants FilterConstants
		{
			get
			{
				short num = (short)80122430;
				short num2 = num;
				num = (short)1791791678;
				switch (num2 == num)
				{
				}
				num = (short)1515520000;
				if (num != 0)
				{
				}
				num = (short)1535705088;
				short num3 = num;
				num = (short)1937702913;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.TrunkingWide.FilterConstants)base[10063];
			}
		}

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x060005AF RID: 1455 RVA: 0x0005F794 File Offset: 0x0005D994
		public global::Motorola.MackinawCPS.CoreFeatures.TrunkingWide.RSSIThresholds RSSIThresholds
		{
			get
			{
				short num = (short)1444011587;
				short num2 = num;
				num = (short)851500611;
				switch (num2 == num)
				{
				}
				num = (short)1250295808;
				if (num != 0)
				{
				}
				num = (short)2111438848;
				short num3 = num;
				num = (short)2121465857;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.TrunkingWide.RSSIThresholds)base[10061];
			}
		}

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x060005B0 RID: 1456 RVA: 0x0005F84C File Offset: 0x0005DA4C
		public global::Motorola.MackinawCPS.CoreFeatures.TrunkingWide.CAIData CAIData
		{
			get
			{
				short num = (short)1123650847;
				short num2 = num;
				num = (short)476220703;
				switch (num2 == num)
				{
				}
				num = (short)138018817;
				if (num != 0)
				{
				}
				num = (short)1883176960;
				short num3 = num;
				num = (short)98238464;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.TrunkingWide.CAIData)base[10064];
			}
		}

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x060005B1 RID: 1457 RVA: 0x0005F904 File Offset: 0x0005DB04
		public global::Motorola.MackinawCPS.CoreFeatures.TrunkingWide.Advanced Advanced
		{
			get
			{
				short num = (short)2128896662;
				short num2 = num;
				num = (short)2008310422;
				switch (num2 == num)
				{
				}
				num = (short)1133314049;
				if (num != 0)
				{
				}
				num = (short)1155661824;
				short num3 = num;
				num = (short)1677066240;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.TrunkingWide.Advanced)base[10059];
			}
		}

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x060005B2 RID: 1458 RVA: 0x0005F9BC File Offset: 0x0005DBBC
		public global::Motorola.MackinawCPS.CoreFeatures.TrunkingWide.Labtool Labtool
		{
			get
			{
				short num = (short)1278372508;
				short num2 = num;
				num = (short)1442933404;
				switch (num2 == num)
				{
				}
				num = (short)1694629888;
				if (num != 0)
				{
				}
				num = (short)994181120;
				short num3 = num;
				num = (short)819134465;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.TrunkingWide.Labtool)base[10060];
			}
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x0005FA74 File Offset: 0x0005DC74
		public static global::AcpCommonLib.IAcpFeatureNode GetTrunkingWide()
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
					return result;
				case 1:
					result = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2027)[0];
					goto IL_132;
				case 2:
					return result;
				case 3:
				{
					num2 = (short)1448131148;
					short num3 = num2;
					num2 = (short)424262220;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_132;
					default:
					{
						num2 = (short)1692860416;
						if (num2 != 0)
						{
						}
						num2 = (short)1357774848;
						short num4 = num2;
						num2 = (short)893124609;
						if (num2 != 0)
						{
						}
						if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
						{
							num2 = (short)2092302337;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						result = global::AcpCommonLib.FeatureManager.GetFeature(2027)[0];
						num2 = (short)303366144;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				}
				goto IL_20;
				IL_132:
				num2 = (short)857407490;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_20:
			result = null;
			num2 = (short)2000027651;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}
	}
}
