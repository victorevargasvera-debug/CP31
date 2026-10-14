using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using Common;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality
{
	// Token: 0x020000C6 RID: 198
	[global::System.Serializable]
	public class TrunkingPersonality : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x06001936 RID: 6454 RVA: 0x0019EB14 File Offset: 0x0019CD14
		public TrunkingPersonality(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 10;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("鿊뿌뫎뿐룒볔맖뻘ﯚ跜뫞鏠郢諤触裨蟪蓬鯮裰", a_);
			base.UIName = global::CommonResources.AcgResources.ID_TRUNKINGPERSONALITY;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("諊ꇌꏎ韐뛒듔ꏖ곘꧚룜곞\udae0ꃢ諤諦駨蓪菬諮鿰蟲꧴ꏶ诸軺鏼链栀洂戄✆䨈搊挌椎砐琒怔攖砘漚琜瀞传缢焤唦尨䔪䘬䘮弰吲ᔴ朶尸䤺丼倾⽀≂⥄⹆㵈㉊ᅌ᭎⍐♒㭔㱖じ㕚㩜ཞѠᅢᙤࡦݨ੪Ŭٮհੲ孴ྲྀᡸᙺᅼ", a_);
			global::Common.CodeplugStatus status = global::Common.CodeplugStatusManager.Status;
			global::Common.CodeplugStatusManager.Status = global::Common.CodeplugStatus.Opening;
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.General(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.AnnouncementGroup(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.Talkgroup(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.CallPage(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.Features(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.PreferredSites(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.Labtool(this));
			global::Common.CodeplugStatusManager.Status = status;
		}

		// Token: 0x06001937 RID: 6455 RVA: 0x0019EBC8 File Offset: 0x0019CDC8
		protected TrunkingPersonality(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 14;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("鯎ꏐꛒ믔볖냘뗚뫜￞뇠蛢韤铦蛨藪賬菮飰蟲賴", a_);
			base.UIName = global::CommonResources.AcgResources.ID_TRUNKINGPERSONALITY;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("軎뷐뿒鏔닖룘꿚꣜귞蓠郢\udee4ꓦ蛨蛪鷬胮鿰雲鯴菶ꗸ꿺迼諾漀栂氄椆済⬊丌怎缐甒簔瀖氘椚簜欞䠠䰢䬤符紨太堬䄮娰娲嬴倶ᤸ欺堼䴾㉀ⱂ⭄♆╈≊㥌㙎൐ݒ❔≖㝘ず㑜ㅞ٠㍢dᕦᩨѪͬ๮ᵰᩲŴ๶坸ͺᱼቾ", a_);
		}

		// Token: 0x17000C90 RID: 3216
		// (get) Token: 0x06001938 RID: 6456 RVA: 0x0019EC1C File Offset: 0x0019CE1C
		public global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.General General
		{
			get
			{
				short num = (short)941424640;
				short num2 = num;
				num = (short)1802308700;
				short num3 = num;
				num = (short)1360989276;
				switch (num3 == num)
				{
				}
				num = (short)191365120;
				if (num != 0)
				{
				}
				num = (short)57081857;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.General)base[10178];
			}
		}

		// Token: 0x17000C91 RID: 3217
		// (get) Token: 0x06001939 RID: 6457 RVA: 0x0019ECD4 File Offset: 0x0019CED4
		public global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.AnnouncementGroup AnnouncementGroup
		{
			get
			{
				short num = (short)1133182976;
				short num2 = num;
				num = (short)871653362;
				short num3 = num;
				num = (short)1841913842;
				switch (num3 == num)
				{
				}
				num = (short)1505820672;
				if (num != 0)
				{
				}
				num = (short)782827521;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.AnnouncementGroup)base[10176];
			}
		}

		// Token: 0x17000C92 RID: 3218
		// (get) Token: 0x0600193A RID: 6458 RVA: 0x0019ED90 File Offset: 0x0019CF90
		public global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.Talkgroup Talkgroup
		{
			get
			{
				short num = (short)2101411840;
				short num2 = num;
				num = (short)1144048247;
				short num3 = num;
				num = (short)416467575;
				switch (num3 == num)
				{
				}
				num = (short)65142784;
				if (num != 0)
				{
				}
				num = (short)585170945;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.Talkgroup)base[10179];
			}
		}

		// Token: 0x17000C93 RID: 3219
		// (get) Token: 0x0600193B RID: 6459 RVA: 0x0019EE48 File Offset: 0x0019D048
		public global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.CallPage CallPage
		{
			get
			{
				short num = (short)1584267264;
				short num2 = num;
				num = (short)1755273755;
				short num3 = num;
				num = (short)546789915;
				switch (num3 == num)
				{
				}
				num = (short)1202585601;
				if (num != 0)
				{
				}
				num = (short)1009188864;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.CallPage)base[10181];
			}
		}

		// Token: 0x17000C94 RID: 3220
		// (get) Token: 0x0600193C RID: 6460 RVA: 0x0019EF00 File Offset: 0x0019D100
		public global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.Features Features
		{
			get
			{
				short num = (short)1573519360;
				short num2 = num;
				num = (short)716173290;
				short num3 = num;
				num = (short)1638330346;
				switch (num3 == num)
				{
				}
				num = (short)1809776641;
				if (num != 0)
				{
				}
				num = (short)1039859712;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.Features)base[10175];
			}
		}

		// Token: 0x17000C95 RID: 3221
		// (get) Token: 0x0600193D RID: 6461 RVA: 0x0019EFBC File Offset: 0x0019D1BC
		public global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.PreferredSites PreferredSites
		{
			get
			{
				short num = (short)805502976;
				short num2 = num;
				num = (short)741277697;
				if (num != 0)
				{
				}
				num = (short)1994821882;
				short num3 = num;
				num = (short)1010602234;
				switch (num3 == num)
				{
				}
				num = (short)1499463680;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.PreferredSites)base[10182];
			}
		}

		// Token: 0x17000C96 RID: 3222
		// (get) Token: 0x0600193E RID: 6462 RVA: 0x0019F078 File Offset: 0x0019D278
		public global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.Labtool Labtool
		{
			get
			{
				short num = (short)1308753920;
				short num2 = num;
				num = (short)201785345;
				if (num != 0)
				{
				}
				num = (short)1242870012;
				short num3 = num;
				num = (short)975417596;
				switch (num3 == num)
				{
				}
				num = (short)844234752;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.Labtool)base[10177];
			}
		}

		// Token: 0x0600193F RID: 6463 RVA: 0x0019F134 File Offset: 0x0019D334
		public static global::AcpCommonLib.IAcpFeatureNode GetTrunkingPersonality()
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			short num2;
			global::AcpCommonLib.IAcpFeatureNode result;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
					{
						num2 = (short)232718337;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)29097984;
					short num3 = num2;
					result = global::AcpCommonLib.FeatureManager.GetFeature(2072)[0];
					num2 = (short)518514131;
					short num4 = num2;
					num2 = (short)157738451;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_F9;
					default:
						num2 = (short)1601372160;
						if (num2 != 0)
						{
						}
						num2 = (short)753729538;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
					goto IL_F9;
				case 2:
					return result;
				case 3:
					return result;
				}
				goto IL_20;
				IL_F9:
				result = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2072)[0];
				num2 = (short)1747517441;
				if (num2 != 0)
				{
				}
				num2 = (short)1354760195;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_20:
			result = null;
			num2 = (short)2088632320;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}
	}
}
