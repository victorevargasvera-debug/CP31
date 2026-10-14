using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using Common;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment
{
	// Token: 0x02000047 RID: 71
	[global::System.Serializable]
	public class ZoneChannelAssignment : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x060001E6 RID: 486 RVA: 0x0002B6E4 File Offset: 0x000298E4
		public ZoneChannelAssignment(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 2;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("駂꫄꧆곈軌꟎냐뷒믔닖뗘ﯚ鳜곞鋠諢苤触蓨軪菬鯮", a_);
			base.UIName = global::CommonResources.AcgResources.ID_ZONECHANNELASSIGNMENT;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("苂꧄ꯆ迈껊곌믎ꓐꇒ냔ꓖ飚닜닞釠賢诤苦蟨鿪뇬뗮黰鷲郴ퟶ뫸鏺鳼釾漀昂椄✆䠈砊縌明瘐紒研爖眘漚䄜䔞丠䴢䀤搦䄨䨪䌬䄮吰弲琴䐶䨸刺娼儾ⱀ♂⭄㍆杈㍊ⱌ≎㵐", a_);
			global::Common.CodeplugStatus status = global::Common.CodeplugStatusManager.Status;
			global::Common.CodeplugStatusManager.Status = global::Common.CodeplugStatus.Opening;
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.Zone(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.RSI(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.FPPProtection(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.Channels(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.Labtool(this));
			global::Common.CodeplugStatusManager.Status = status;
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x0002B780 File Offset: 0x00029980
		protected ZoneChannelAssignment(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 10;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("释ꋌꇎ듐雔뿖룘뗚돜뫞跠쏢ꓤ铦髨苪諬臮鳰雲鯴菶", a_);
			base.UIName = global::CommonResources.AcgResources.ID_ZONECHANNELASSIGNMENT;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("諊ꇌꏎ韐뛒듔ꏖ곘꧚룜곞\udae0ꃢ諤諦駨蓪菬諮鿰蟲꧴귶雸闺飼\udffe䈀欂搄椆月渊愌⼎倐怒昔縖縘甚瀜稞传圢礤紦䘨䔪䠬氮夰刲嬴夶尸场簼䰾㉀⩂≄⥆⑈⹊⍌㭎罐⭒㑔㩖㕘", a_);
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x060001E8 RID: 488 RVA: 0x0002B7D4 File Offset: 0x000299D4
		public global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.Zone Zone
		{
			get
			{
				short num = (short)557921555;
				short num2 = num;
				num = (short)2049717523;
				switch (num2 == num)
				{
				}
				num = (short)1693908993;
				if (num != 0)
				{
				}
				num = (short)1464139776;
				if (num != 0)
				{
				}
				num = (short)1157103616;
				short num3 = num;
				return (global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.Zone)base[10116];
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x060001E9 RID: 489 RVA: 0x0002B88C File Offset: 0x00029A8C
		public global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.RSI RSI
		{
			get
			{
				short num = (short)2120155137;
				if (num != 0)
				{
				}
				num = (short)717002965;
				short num2 = num;
				num = (short)1185192149;
				switch (num2 == num)
				{
				}
				num = (short)791085056;
				if (num != 0)
				{
				}
				num = (short)1422393344;
				short num3 = num;
				return (global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.RSI)base[10760];
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x060001EA RID: 490 RVA: 0x0002B948 File Offset: 0x00029B48
		public global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.FPPProtection FPPProtection
		{
			get
			{
				short num = (short)1982752861;
				short num2 = num;
				num = (short)760637533;
				switch (num2 == num)
				{
				}
				num = (short)385875969;
				if (num != 0)
				{
				}
				num = (short)587333632;
				if (num != 0)
				{
				}
				num = (short)803667968;
				short num3 = num;
				return (global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.FPPProtection)base[10117];
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x060001EB RID: 491 RVA: 0x0002BA00 File Offset: 0x00029C00
		public global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.Channels Channels
		{
			get
			{
				short num = (short)343717647;
				short num2 = num;
				num = (short)1238939407;
				switch (num2 == num)
				{
				}
				num = (short)2065563648;
				if (num != 0)
				{
				}
				num = (short)1532755969;
				if (num != 0)
				{
				}
				num = (short)1323302912;
				short num3 = num;
				return (global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.Channels)base[10114];
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x060001EC RID: 492 RVA: 0x0002BAB8 File Offset: 0x00029CB8
		public global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.Labtool Labtool
		{
			get
			{
				short num = (short)81621009;
				short num2 = num;
				num = (short)1826451473;
				switch (num2 == num)
				{
				}
				num = (short)1602945025;
				if (num != 0)
				{
				}
				num = (short)1686437888;
				if (num != 0)
				{
				}
				num = (short)1539833856;
				short num3 = num;
				return (global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.Labtool)base[10711];
			}
		}

		// Token: 0x060001ED RID: 493 RVA: 0x0002BB74 File Offset: 0x00029D74
		public static global::AcpCommonLib.IAcpFeatureNode GetZoneChannelAssignment()
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
					goto IL_104;
				case 1:
					result = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2051)[0];
					num2 = (short)11010048;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_104;
				case 3:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
					{
						goto IL_90;
					}
					result = global::AcpCommonLib.FeatureManager.GetFeature(2051)[0];
					num2 = (short)937623554;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_20;
				IL_90:
				num2 = (short)1069809665;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_104:
				num2 = (short)752633830;
				short num3 = num2;
				num2 = (short)763185126;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_90;
				default:
					goto IL_13B;
				}
			}
			IL_13B:
			num2 = (short)1941766144;
			if (num2 != 0)
			{
			}
			return result;
			IL_20:
			result = null;
			num2 = (short)159973376;
			short num4 = num2;
			num2 = (short)979304449;
			if (num2 != 0)
			{
			}
			num2 = (short)1370488835;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x060001EE RID: 494 RVA: 0x0002BCD4 File Offset: 0x00029ED4
		public override string ReferenceKey
		{
			get
			{
				int a_ = 14;
				short num = (short)331743235;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)833683457;
						if (num != 0)
						{
						}
						num = (short)924955476;
						short num3 = num;
						num = (short)1329509204;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						case 1:
							goto IL_C3;
						}
						goto Block_2;
					}
					case 1:
						num = (short)432603138;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (this.Zone.ZnChanCfgZoneZoneName_A9724 != null)
						{
							num = (short)1234894848;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_172;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_3F;
						}
						continue;
					}
					IL_3F:
					if (this.Zone == null)
					{
						goto IL_172;
					}
					num = (short)1144717313;
					num2 = (int)((global::System.IntPtr)num);
				}
				Block_2:
				num = (short)1248788480;
				short num4 = num;
				IL_C3:
				num = (short)1619591168;
				if (num != 0)
				{
				}
				return base.Position.ToString() + global::AllFeatures.CodeplugGuid.b("", a_) + this.Zone.ZnChanCfgZoneZoneName_A9724.ToString();
				IL_172:
				return base.Position.ToString() + global::AllFeatures.CodeplugGuid.b("", a_) + base.FeatureName;
			}
		}
	}
}
