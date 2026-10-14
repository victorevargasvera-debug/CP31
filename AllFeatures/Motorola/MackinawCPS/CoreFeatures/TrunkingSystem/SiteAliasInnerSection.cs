using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.TrunkingSystem
{
	// Token: 0x020000A4 RID: 164
	[global::System.Serializable]
	public class SiteAliasInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x060013F5 RID: 5109 RVA: 0x0012BF48 File Offset: 0x0012A148
		public SiteAliasInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x060013F6 RID: 5110 RVA: 0x0012BF64 File Offset: 0x0012A164
		protected SiteAliasInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x060013F7 RID: 5111 RVA: 0x0012BF7C File Offset: 0x0012A17C
		public override void Init()
		{
			int a_ = 5;
			short num = (short)2041774081;
			if (num != 0)
			{
			}
			num = (short)314871889;
			short num2 = num;
			num = (short)328241233;
			switch (num2 == num)
			{
			}
			num = (short)239861760;
			short num3 = num;
			num = (short)920322048;
			if (num != 0)
			{
			}
			this.trkSysSiteAliasSiteAliasNumber_A9145 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("鋅뫇ꇉ鿋럍ꏏ臑뷓ꋕ뷗鯙냛럝臟釡럣迥鳧迩귫苭駯鏱蟳룵跷韹黻鯽狿崁䔃㼅㤇㸉㤋", a_), global::CommonResources.AcgResources.ID_SITEID, 1, 254, null, null, 0, 1);
			this.trkSysSiteAliasSiteAliasNumber_A9145.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.trkSysSiteAliasSiteAliasNumber_A9145.DataTransferOrder = 98;
			this.trkSysSiteAliasSiteAliasNumber_A9145.ShowHexValue = true;
			this.trkSysSiteAliasSiteAliasText_A9146 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_SITE1, this, global::AllFeatures.CodeplugGuid.b("鋅뫇ꇉ鿋럍ꏏ臑뷓ꋕ뷗鯙냛럝臟釡럣迥鳧迩귫苭駯鏱蟳ꋵ鷷苹裻ꇽ䇿㬁㔃㈅㸇", a_), global::CommonResources.AcgResources.ID_SITEALIASTEXT, 14);
			this.trkSysSiteAliasSiteAliasText_A9146.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.trkSysSiteAliasSiteAliasText_A9146.DataTransferOrder = 91;
			this.trkSysSiteAliasSystemNumber_A19669 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("鋅뫇ꇉ鿋럍ꏏ臑뷓ꋕ뷗鯙냛럝臟釡럣鿥鯧黩觫菭뻯蟱駳铵鷷裹ꏻ뿽ㇿ㬁㈃々ㄇ", a_), global::CommonResources.AcgResources.ID_SYSTEMNUMBER, 0, 65535, null, null, 0, 1);
			this.trkSysSiteAliasSystemNumber_A19669.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.trkSysSiteAliasSystemNumber_A19669.DataTransferOrder = 86;
			this.trkSysSiteAliasSystemNumber_A19669.ShowHexValue = true;
			this.trkSysSiteAliasHomeRASWACNNumber_A20169 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("鋅뫇ꇉ鿋럍ꏏ臑뷓ꋕ뷗鯙냛럝臟釡곣觥藧迩뻫꿭ꏯꗱ뗳뗵뛷듹觻鏽拿朁瘃夅䤇㠉㰋㼍☏⬑", a_), global::CommonResources.AcgResources.ID_HOMERASWACNNUMBER, 0, 1048574, null, null, 0, 1);
			this.trkSysSiteAliasHomeRASWACNNumber_A20169.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.trkSysSiteAliasHomeRASWACNNumber_A20169.DataTransferOrder = 87;
			this.trkSysSiteAliasHomeRASWACNNumber_A20169.ShowHexValue = true;
			this.trkSysSiteAliasHomeRASWACNNumber_A20169.ShowLeadingZeros = true;
			this.trkSysSiteAlias_A24071 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("鋅뫇ꇉ鿋럍ꏏ臑뷓ꋕ뷗鯙냛럝臟釡믣꟥\udae7\udee9\udceb\ud9ed쇯", a_), global::CommonResources.AcgResources.ID_POSITION);
			this.trkSysSiteAlias_A24071.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.trkSysSiteAlias_A24071.DataTransferOrder = -1;
			this.trkSysSiteAliasRFSSAliasNumber_A8978 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("鋅뫇ꇉ鿋럍ꏏ臑뷓ꋕ뷗鯙냛럝臟釡뛣ꃥ믧맩귫苭駯鏱蟳룵跷韹黻鯽狿崁䔃㸅ㄇ㴉㐋", a_), global::CommonResources.AcgResources.ID_RFSSALIASNUMBER, 1, 254, null, null, 0, 1);
			this.trkSysSiteAliasRFSSAliasNumber_A8978.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkSysSiteAliasRFSSAliasNumber_A8978.DataTransferOrder = 99;
			this.trkSysSiteAliasRFSSAliasNumber_A8978.ShowHexValue = false;
			this.trkSysSiteAliasSiteAliasType_A41343 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鋅뫇ꇉ鿋럍ꏏ臑뷓ꋕ뷗鯙냛럝臟釡럣迥鳧迩귫苭駯鏱蟳ꋵ臷諹駻ꇽ䇿㘁㔃㔅㰇㤉", a_), global::CommonResources.AcgResources.ID_SITEALIASTYPE, global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.LOVs.TrkSysSiteAliasSiteAliasType_A41343LovStrs);
			this.trkSysSiteAliasSiteAliasType_A41343.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.trkSysSiteAliasSiteAliasType_A41343.DataTransferOrder = 150;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("闅ꇇ뻉꧋量뻑뷓럕ꯗ", a_);
			base.Id = 10172;
			base.UIName = global::CommonResources.AcgResources.ID_SITEALIAS;
			base.DataTransferOrder = 1;
		}

		// Token: 0x060013F8 RID: 5112 RVA: 0x0012C260 File Offset: 0x0012A460
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 0;
			short num = (short)824442888;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)2056781828;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
				{
					num = (short)1172836360;
					short num3 = num;
					num = (short)1639780360;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_106;
					default:
						num = (short)258539521;
						if (num != 0)
						{
						}
						num = (short)951123968;
						if (num != 0)
						{
						}
						num = (short)1281818639;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
					this.trkSysSiteAlias_A24071 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("闀뇂껄铆냈룊黌ꛎꗐ뛒铔믖냘뫚껜胞ꃠ퇢퇤ퟦ\udee8\udaea", a_), global::CommonResources.AcgResources.ID_POSITION);
					this.trkSysSiteAlias_A24071.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.trkSysSiteAlias_A24071.DataTransferOrder = -1;
					num = (short)1331036169;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_365;
				case 4:
					if (producerFields != null)
					{
						num = (short)153681921;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_653;
				case 5:
					goto IL_5BC;
				case 6:
					this.trkSysSiteAliasSiteAliasText_A9146 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_SITE1, this, global::AllFeatures.CodeplugGuid.b("闀뇂껄铆냈룊黌ꛎꗐ뛒铔믖냘뫚껜賞裠韢胤ꛦ藨苪賬鳮ꗰ雲跴菶꛸뫺쓼컾㔀㔂", a_), global::CommonResources.AcgResources.ID_SITEALIASTEXT, 14);
					this.trkSysSiteAliasSiteAliasText_A9146.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.trkSysSiteAliasSiteAliasText_A9146.DataTransferOrder = 91;
					num = (short)1768947717;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("闀뇂껄铆냈룊黌ꛎꗐ뛒铔믖냘뫚껜跞꟠냢뛤ꛦ藨苪賬鳮뿰蛲飴闶鳸觺ꋼ뻾㤀㨂㈄㼆", a_)))
					{
						num = (short)1314586645;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_41F;
				case 8:
					switch (0)
					{
					case 0:
						goto IL_92;
					}
					continue;
				case 9:
					goto IL_106;
				case 10:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("闀뇂껄铆냈룊黌ꛎꗐ뛒铔믖냘뫚껜胞ꃠ퇢퇤ퟦ\udee8\udaea", a_)))
					{
						num = (short)361496578;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_46D;
				case 11:
					goto IL_41F;
				case 12:
					goto IL_607;
				case 13:
					this.trkSysSiteAliasSiteAliasType_A41343 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("闀뇂껄铆냈룊黌ꛎꗐ뛒铔믖냘뫚껜賞裠韢胤ꛦ藨苪賬鳮ꗰ諲藴鋶꛸뫺짼컾㈀㜂㘄", a_), global::CommonResources.AcgResources.ID_SITEALIASTYPE, global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.LOVs.TrkSysSiteAliasSiteAliasType_A41343LovStrs);
					this.trkSysSiteAliasSiteAliasType_A41343.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.trkSysSiteAliasSiteAliasType_A41343.DataTransferOrder = 150;
					num = (short)243204099;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					this.trkSysSiteAliasHomeRASWACNNumber_A20169 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("闀뇂껄铆냈룊黌ꛎꗐ뛒铔믖냘뫚껜韞軠転胤뗦꣨룪뫬껮닰뷲믴苶铸駺飼跾帀䈂㜄㜆㠈㴊㐌", a_), global::CommonResources.AcgResources.ID_HOMERASWACNNUMBER, null, null, 0, 1);
					this.trkSysSiteAliasHomeRASWACNNumber_A20169.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.trkSysSiteAliasHomeRASWACNNumber_A20169.DataTransferOrder = 87;
					this.trkSysSiteAliasHomeRASWACNNumber_A20169.ShowHexValue = true;
					this.trkSysSiteAliasHomeRASWACNNumber_A20169.ShowLeadingZeros = true;
					num = (short)136118290;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("闀뇂껄铆냈룊黌ꛎꗐ뛒铔믖냘뫚껜賞裠韢胤ꛦ藨苪賬鳮뿰蛲飴闶鳸觺ꋼ뻾㠀㈂㄄㈆", a_)))
					{
						num = (short)67764243;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3D1;
				case 16:
					this.trkSysSiteAliasSystemNumber_A19669 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("闀뇂껄铆냈룊黌ꛎꗐ뛒铔믖냘뫚껜賞飠郢釤苦蓨ꗪ飬苮鏰雲蟴ꣶ룸쫺쓼짾㜀㨂", a_), global::CommonResources.AcgResources.ID_SYSTEMNUMBER, null, null, 0, 1);
					this.trkSysSiteAliasSystemNumber_A19669.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.trkSysSiteAliasSystemNumber_A19669.DataTransferOrder = 86;
					this.trkSysSiteAliasSystemNumber_A19669.ShowHexValue = true;
					num = (short)1696464908;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					goto IL_3D1;
				case 18:
					goto IL_2C0;
				case 19:
				{
					num = (short)617414656;
					short num4 = num;
					this.trkSysSiteAliasSiteAliasNumber_A9145 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("闀뇂껄铆냈룊黌ꛎꗐ뛒铔믖냘뫚껜賞裠韢胤ꛦ藨苪賬鳮뿰蛲飴闶鳸觺ꋼ뻾㠀㈂㄄㈆", a_), global::CommonResources.AcgResources.ID_SITEID, null, null, 0, 1);
					this.trkSysSiteAliasSiteAliasNumber_A9145.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.trkSysSiteAliasSiteAliasNumber_A9145.DataTransferOrder = 98;
					this.trkSysSiteAliasSiteAliasNumber_A9145.ShowHexValue = true;
					num = (short)1819213841;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 20:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("闀뇂껄铆냈룊黌ꛎꗐ뛒铔믖냘뫚껜賞裠韢胤ꛦ藨苪賬鳮ꗰ諲藴鋶꛸뫺짼컾㈀㜂㘄", a_)))
					{
						num = (short)1895366669;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_653;
				case 21:
					this.trkSysSiteAliasRFSSAliasNumber_A8978 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("闀뇂껄铆냈룊黌ꛎꗐ뛒铔믖냘뫚껜跞꟠냢뛤ꛦ藨苪賬鳮뿰蛲飴闶鳸觺ꋼ뻾㤀㨂㈄㼆", a_), global::CommonResources.AcgResources.ID_RFSSALIASNUMBER, null, null, 0, 1);
					this.trkSysSiteAliasRFSSAliasNumber_A8978.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkSysSiteAliasRFSSAliasNumber_A8978.DataTransferOrder = 99;
					this.trkSysSiteAliasRFSSAliasNumber_A8978.ShowHexValue = false;
					num = (short)1879244811;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 22:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("闀뇂껄铆냈룊黌ꛎꗐ뛒铔믖냘뫚껜賞裠韢胤ꛦ藨苪賬鳮ꗰ雲跴菶꛸뫺쓼컾㔀㔂", a_)))
					{
						num = (short)1784545286;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5BC;
				case 23:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("闀뇂껄铆냈룊黌ꛎꗐ뛒铔믖냘뫚껜賞飠郢釤苦蓨ꗪ飬苮鏰雲蟴ꣶ룸쫺쓼짾㜀㨂", a_)))
					{
						num = (short)1607139344;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_607;
				case 24:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("闀뇂껄铆냈룊黌ꛎꗐ뛒铔믖냘뫚껜韞軠転胤뗦꣨룪뫬껮닰뷲믴苶铸駺飼跾帀䈂㜄㜆㠈㴊㐌", a_)))
					{
						num = (short)583860238;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2C0;
				}
				IL_92:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1405353984;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_2C0:
				num = (short)42926090;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3D1:
				num = (short)1631649814;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_41F:
				num = (short)215941140;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_46D:
				num = (short)900530183;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_106:
				goto IL_46D;
				IL_5BC:
				num = (short)748617751;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_607:
				num = (short)1108148248;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_365:
			IL_653:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鋀ꫂ뇄ꋆ諊ꇌꛎ냐ꃒ", a_);
			base.Id = 10172;
			base.UIName = global::CommonResources.AcgResources.ID_SITEALIAS;
			base.DataTransferOrder = 1;
		}

		// Token: 0x060013F9 RID: 5113 RVA: 0x0012C8F4 File Offset: 0x0012AAF4
		public override void PopulateReferences()
		{
			short num = (short)2081619968;
			short num2 = num;
			num = (short)125665196;
			short num3 = num;
			num = (short)143294380;
			switch (num3 == num)
			{
			}
			num = (short)1415053312;
			if (num != 0)
			{
			}
			num = (short)1818820609;
			if (num != 0)
			{
			}
		}

		// Token: 0x060013FA RID: 5114 RVA: 0x0012C99C File Offset: 0x0012AB9C
		public override void DropReferences()
		{
			short num = (short)1120600064;
			short num2 = num;
			num = (short)1082096110;
			short num3 = num;
			num = (short)307198446;
			switch (num3 == num)
			{
			}
			num = (short)1706491904;
			if (num != 0)
			{
			}
			num = (short)1162805249;
			if (num != 0)
			{
			}
		}

		// Token: 0x060013FB RID: 5115 RVA: 0x0012CA48 File Offset: 0x0012AC48
		public override void SetConstraints()
		{
			short num = (short)45940736;
			short num2 = num;
			num = (short)1738264336;
			short num3 = num;
			num = (short)1328205584;
			switch (num3 == num)
			{
			}
			num = (short)305922049;
			if (num != 0)
			{
			}
			num = (short)622198784;
			if (num != 0)
			{
			}
			this.trkSysSiteAliasSiteAliasNumber_A9145.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConSiteAlsIsEnabledAndApplicableAndSiteAliseTypeIsSite);
			this.trkSysSiteAliasSiteAliasNumber_A9145.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.conValidateSiteIDBasedOnSystemType);
			this.trkSysSiteAliasSiteAliasText_A9146.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConSiteAlsIsEnabledAndApplicable);
			this.trkSysSiteAliasSystemNumber_A19669.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConTrkSysApcoAndCvgTypIsIntraWACNRoamingAndSiteAlsEn);
			this.trkSysSiteAliasSystemNumber_A19669.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.conValidateRangeForSiteAliasSystemIDBasedOnSystemType);
			this.trkSysSiteAliasHomeRASWACNNumber_A20169.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConTrkSysApcoAndCvgTypIsSZOmnilinkOrIntraWACNAndSiteAlsEn);
			this.trkSysSiteAlias_A24071.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.trkSysSiteAliasRFSSAliasNumber_A8978.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConTrkSysApcoAndApcoOmnilinkAndAmssSelIsSmartZoneAndAliasIndicatorIsEnabled);
			this.trkSysSiteAliasRFSSAliasNumber_A8978.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConTrkSysApcoAndApcoOmnilinkAndAmssSelIsSmartZoneAndAliasIndicatorIsEnabledEdit);
			this.trkSysSiteAliasSiteAliasType_A41343.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConSiteAlsIsEnabledAndCovTypeIsInterWACNAndSysTypeIsA25);
		}

		// Token: 0x060013FC RID: 5116 RVA: 0x0012CBD8 File Offset: 0x0012ADD8
		public override void SetupDependencies()
		{
			short num = (short)215089152;
			short num2 = num;
			num = (short)1435319346;
			short num3 = num;
			num = (short)65158194;
			switch (num3 == num)
			{
			}
			num = (short)1969618945;
			if (num != 0)
			{
			}
			num = (short)1835401216;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem = base.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem;
			trunkingSystem.General.TrkSysGeneralSystemType_A9252.AddDependentObject(this.trkSysSiteAliasSiteAliasNumber_A9145);
			trunkingSystem.SiteAlias.TrkSysSiteAliasSiteAliasEnable_A9148.AddDependentObject(this.trkSysSiteAliasSiteAliasNumber_A9145);
			trunkingSystem.General.TrkSysGeneralCoverageType_A7782.AddDependentObject(this.trkSysSiteAliasSiteAliasNumber_A9145);
			this.trkSysSiteAliasSiteAliasType_A41343.AddDependentObject(this.trkSysSiteAliasSiteAliasNumber_A9145);
			trunkingSystem.SiteAlias.TrkSysSiteAliasSiteAliasEnable_A9148.AddDependentObject(this.trkSysSiteAliasSiteAliasText_A9146);
			trunkingSystem.General.TrkSysGeneralSystemType_A9252.AddDependentObject(this.trkSysSiteAliasSiteAliasText_A9146);
			trunkingSystem.General.TrkSysGeneralCoverageType_A7782.AddDependentObject(this.trkSysSiteAliasSiteAliasText_A9146);
			this.trkSysSiteAliasSiteAliasType_A41343.AddDependentObject(this.trkSysSiteAliasSiteAliasText_A9146);
			trunkingSystem.General.TrkSysGeneralSystemType_A9252.AddDependentObject(this.trkSysSiteAliasSystemNumber_A19669);
			trunkingSystem.SiteAlias.TrkSysSiteAliasSiteAliasEnable_A9148.AddDependentObject(this.trkSysSiteAliasSystemNumber_A19669);
			trunkingSystem.General.TrkSysGeneralCoverageType_A7782.AddDependentObject(this.trkSysSiteAliasSystemNumber_A19669);
			this.trkSysSiteAliasSiteAliasType_A41343.AddDependentObject(this.trkSysSiteAliasSystemNumber_A19669);
			trunkingSystem.SiteAlias.TrkSysSiteAliasSiteAliasEnable_A9148.AddDependentObject(this.trkSysSiteAliasHomeRASWACNNumber_A20169);
			trunkingSystem.General.TrkSysGeneralSystemType_A9252.AddDependentObject(this.trkSysSiteAliasHomeRASWACNNumber_A20169);
			trunkingSystem.General.TrkSysGeneralCoverageType_A7782.AddDependentObject(this.trkSysSiteAliasHomeRASWACNNumber_A20169);
			this.trkSysSiteAliasSiteAliasType_A41343.AddDependentObject(this.trkSysSiteAliasHomeRASWACNNumber_A20169);
			trunkingSystem.SiteAlias.TrkSysSiteAliasSiteAliasEnable_A9148.AddDependentObject(this.trkSysSiteAliasRFSSAliasNumber_A8978);
			trunkingSystem.General.TrkSysGeneralSystemType_A9252.AddDependentObject(this.trkSysSiteAliasRFSSAliasNumber_A8978);
			trunkingSystem.General.TrkSysGeneralCoverageType_A7782.AddDependentObject(this.trkSysSiteAliasRFSSAliasNumber_A8978);
			this.trkSysSiteAliasSiteAliasType_A41343.AddDependentObject(this.trkSysSiteAliasRFSSAliasNumber_A8978);
			trunkingSystem.SiteAlias.TrkSysSiteAliasSiteAliasEnable_A9148.AddDependentObject(this.trkSysSiteAliasSiteAliasType_A41343);
			trunkingSystem.General.TrkSysGeneralSystemType_A9252.AddDependentObject(this.trkSysSiteAliasSiteAliasType_A41343);
			trunkingSystem.General.TrkSysGeneralCoverageType_A7782.AddDependentObject(this.trkSysSiteAliasSiteAliasType_A41343);
			this.trkSysSiteAliasRFSSAliasNumber_A8978.AddDependentObject((base.ParentRecset.ParentSection.Parent[10157] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.General).TrkSysGeneralCoverageType_A7782);
			this.trkSysSiteAliasRFSSAliasNumber_A8978.AddDependentObject((base.ParentRecset.ParentSection.Parent[10157] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.General).TrkSysGeneralRFSSID_A8980);
		}

		// Token: 0x17000A0A RID: 2570
		// (get) Token: 0x060013FD RID: 5117 RVA: 0x0012CEF0 File Offset: 0x0012B0F0
		public bool HasDiffs
		{
			get
			{
				short num = (short)1625554944;
				short num2 = num;
				num = (short)609780172;
				short num3 = num;
				num = (short)1789231564;
				switch (num3 == num)
				{
				}
				num = (short)1042153473;
				if (num != 0)
				{
				}
				num = (short)618921984;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17000A0B RID: 2571
		// (get) Token: 0x060013FE RID: 5118 RVA: 0x0012CFA0 File Offset: 0x0012B1A0
		// (set) Token: 0x060013FF RID: 5119 RVA: 0x0012D058 File Offset: 0x0012B258
		public int TrkSysSiteAliasSiteAliasNumber_A9145Value
		{
			get
			{
				short num = (short)1821704192;
				short num2 = num;
				num = (short)54340617;
				short num3 = num;
				num = (short)122891273;
				switch (num3 == num)
				{
				}
				num = (short)774438913;
				if (num != 0)
				{
				}
				num = (short)431161344;
				if (num != 0)
				{
				}
				return this.trkSysSiteAliasSiteAliasNumber_A9145.Value;
			}
			set
			{
				short num = (short)961282048;
				short num2 = num;
				num = (short)698559153;
				short num3 = num;
				num = (short)1255942833;
				switch (num3 == num)
				{
				}
				num = (short)1500446720;
				if (num != 0)
				{
				}
				num = (short)1084424193;
				if (num != 0)
				{
				}
				this.trkSysSiteAliasSiteAliasNumber_A9145.Value = value;
			}
		}

		// Token: 0x17000A0C RID: 2572
		// (get) Token: 0x06001400 RID: 5120 RVA: 0x0012D10C File Offset: 0x0012B30C
		public global::AcpBusinessLayer.AcpSimpleRangeField TrkSysSiteAliasSiteAliasNumber_A9145
		{
			get
			{
				short num = (short)2095906816;
				short num2 = num;
				num = (short)1957167105;
				if (num != 0)
				{
				}
				num = (short)1365696219;
				short num3 = num;
				num = (short)1228988123;
				switch (num3 == num)
				{
				}
				num = (short)38076416;
				if (num != 0)
				{
				}
				return this.trkSysSiteAliasSiteAliasNumber_A9145;
			}
		}

		// Token: 0x17000A0D RID: 2573
		// (get) Token: 0x06001401 RID: 5121 RVA: 0x0012D1BC File Offset: 0x0012B3BC
		// (set) Token: 0x06001402 RID: 5122 RVA: 0x0012D270 File Offset: 0x0012B470
		public string TrkSysSiteAliasSiteAliasNumber_A9145_UIValue
		{
			get
			{
				short num = (short)1376124928;
				short num2 = num;
				num = (short)1116898699;
				short num3 = num;
				num = (short)1734116747;
				switch (num3 == num)
				{
				}
				num = (short)1099104257;
				if (num != 0)
				{
				}
				num = (short)1084555264;
				if (num != 0)
				{
				}
				return this.trkSysSiteAliasSiteAliasNumber_A9145.UIValue;
			}
			set
			{
				short num = (short)628555776;
				short num2 = num;
				num = (short)2091122689;
				if (num != 0)
				{
				}
				num = (short)2098819559;
				short num3 = num;
				num = (short)772764135;
				switch (num3 == num)
				{
				}
				num = (short)1328414720;
				if (num != 0)
				{
				}
				this.trkSysSiteAliasSiteAliasNumber_A9145.UIValue = value;
			}
		}

		// Token: 0x17000A0E RID: 2574
		// (get) Token: 0x06001403 RID: 5123 RVA: 0x0012D324 File Offset: 0x0012B524
		// (set) Token: 0x06001404 RID: 5124 RVA: 0x0012D3DC File Offset: 0x0012B5DC
		public string TrkSysSiteAliasSiteAliasNumber_A9145_HexUIValue
		{
			get
			{
				short num = (short)27787264;
				short num2 = num;
				num = (short)1561395470;
				short num3 = num;
				num = (short)1105002766;
				switch (num3 == num)
				{
				}
				num = (short)1456799745;
				if (num != 0)
				{
				}
				num = (short)1084227584;
				if (num != 0)
				{
				}
				return this.trkSysSiteAliasSiteAliasNumber_A9145.HexUIValue;
			}
			set
			{
				short num = (short)1324810240;
				short num2 = num;
				num = (short)69161138;
				short num3 = num;
				num = (short)281563314;
				switch (num3 == num)
				{
				}
				num = (short)760872960;
				if (num != 0)
				{
				}
				num = (short)1680998401;
				if (num != 0)
				{
				}
				this.trkSysSiteAliasSiteAliasNumber_A9145.HexUIValue = value;
			}
		}

		// Token: 0x17000A0F RID: 2575
		// (get) Token: 0x06001405 RID: 5125 RVA: 0x0012D490 File Offset: 0x0012B690
		// (set) Token: 0x06001406 RID: 5126 RVA: 0x0012D548 File Offset: 0x0012B748
		internal int TrkSysSiteAliasSiteAliasNumber_A9145Min
		{
			get
			{
				short num = (short)1735458816;
				short num2 = num;
				num = (short)1824718575;
				short num3 = num;
				num = (short)29884143;
				switch (num3 == num)
				{
				}
				num = (short)162136065;
				if (num != 0)
				{
				}
				num = (short)1868169216;
				if (num != 0)
				{
				}
				return this.trkSysSiteAliasSiteAliasNumber_A9145.Min;
			}
			set
			{
				short num = (short)774832128;
				short num2 = num;
				num = (short)175130397;
				short num3 = num;
				num = (short)1511474973;
				switch (num3 == num)
				{
				}
				num = (short)1801322497;
				if (num != 0)
				{
				}
				num = (short)1383858176;
				if (num != 0)
				{
				}
				this.trkSysSiteAliasSiteAliasNumber_A9145.Min = value;
			}
		}

		// Token: 0x17000A10 RID: 2576
		// (get) Token: 0x06001407 RID: 5127 RVA: 0x0012D5F8 File Offset: 0x0012B7F8
		// (set) Token: 0x06001408 RID: 5128 RVA: 0x0012D6AC File Offset: 0x0012B8AC
		internal int TrkSysSiteAliasSiteAliasNumber_A9145Max
		{
			get
			{
				short num = (short)1041825792;
				short num2 = num;
				num = (short)786377201;
				short num3 = num;
				num = (short)1454647793;
				switch (num3 == num)
				{
				}
				num = (short)1222508545;
				if (num != 0)
				{
				}
				num = (short)699203584;
				if (num != 0)
				{
				}
				return this.trkSysSiteAliasSiteAliasNumber_A9145.Max;
			}
			set
			{
				short num = (short)2122252288;
				short num2 = num;
				num = (short)1683762634;
				short num3 = num;
				num = (short)882388426;
				switch (num3 == num)
				{
				}
				num = (short)1698562048;
				if (num != 0)
				{
				}
				num = (short)1873215489;
				if (num != 0)
				{
				}
				this.trkSysSiteAliasSiteAliasNumber_A9145.Max = value;
			}
		}

		// Token: 0x17000A11 RID: 2577
		// (get) Token: 0x06001409 RID: 5129 RVA: 0x0012D764 File Offset: 0x0012B964
		// (set) Token: 0x0600140A RID: 5130 RVA: 0x0012D81C File Offset: 0x0012BA1C
		internal int TrkSysSiteAliasSiteAliasNumber_A9145Step
		{
			get
			{
				short num = (short)542572544;
				short num2 = num;
				num = (short)977120484;
				short num3 = num;
				num = (short)2005183716;
				switch (num3 == num)
				{
				}
				num = (short)2046033921;
				if (num != 0)
				{
				}
				num = (short)1989017600;
				if (num != 0)
				{
				}
				return this.trkSysSiteAliasSiteAliasNumber_A9145.StepSize;
			}
			set
			{
				short num = (short)1668677632;
				short num2 = num;
				num = (short)1815528725;
				short num3 = num;
				num = (short)1334756629;
				switch (num3 == num)
				{
				}
				num = (short)1745747968;
				if (num != 0)
				{
				}
				num = (short)1781006337;
				if (num != 0)
				{
				}
				this.trkSysSiteAliasSiteAliasNumber_A9145.StepSize = value;
			}
		}

		// Token: 0x17000A12 RID: 2578
		// (get) Token: 0x0600140B RID: 5131 RVA: 0x0012D8D4 File Offset: 0x0012BAD4
		// (set) Token: 0x0600140C RID: 5132 RVA: 0x0012D98C File Offset: 0x0012BB8C
		public bool TrkSysSiteAliasSiteAliasNumber_A9145_Applicable
		{
			get
			{
				short num = (short)1605566464;
				short num2 = num;
				num = (short)868524346;
				short num3 = num;
				num = (short)202613050;
				switch (num3 == num)
				{
				}
				num = (short)1507328;
				if (num != 0)
				{
				}
				num = (short)612171777;
				if (num != 0)
				{
				}
				return this.trkSysSiteAliasSiteAliasNumber_A9145.Applicable;
			}
			set
			{
				short num = (short)387907584;
				short num2 = num;
				num = (short)487624509;
				short num3 = num;
				num = (short)206016317;
				switch (num3 == num)
				{
				}
				num = (short)19726336;
				if (num != 0)
				{
				}
				num = (short)1625751553;
				if (num != 0)
				{
				}
				this.trkSysSiteAliasSiteAliasNumber_A9145.Applicable = value;
			}
		}

		// Token: 0x17000A13 RID: 2579
		// (get) Token: 0x0600140D RID: 5133 RVA: 0x0012DA44 File Offset: 0x0012BC44
		// (set) Token: 0x0600140E RID: 5134 RVA: 0x0012DAF8 File Offset: 0x0012BCF8
		public bool TrkSysSiteAliasSiteAliasNumber_A9145_Valid
		{
			get
			{
				short num = (short)164167680;
				short num2 = num;
				num = (short)392197117;
				short num3 = num;
				num = (short)1045263357;
				switch (num3 == num)
				{
				}
				num = (short)387383297;
				if (num != 0)
				{
				}
				num = (short)244121600;
				if (num != 0)
				{
				}
				return this.trkSysSiteAliasSiteAliasNumber_A9145.Valid;
			}
			set
			{
				short num = (short)2084700160;
				short num2 = num;
				num = (short)38300789;
				short num3 = num;
				num = (short)1257729141;
				switch (num3 == num)
				{
				}
				num = (short)120193025;
				if (num != 0)
				{
				}
				num = (short)1387790336;
				if (num != 0)
				{
				}
				this.trkSysSiteAliasSiteAliasNumber_A9145.Valid = value;
			}
		}

		// Token: 0x17000A14 RID: 2580
		// (get) Token: 0x0600140F RID: 5135 RVA: 0x0012DBAC File Offset: 0x0012BDAC
		// (set) Token: 0x06001410 RID: 5136 RVA: 0x0012DC60 File Offset: 0x0012BE60
		public bool TrkSysSiteAliasSiteAliasNumber_A9145_Visible
		{
			get
			{
				short num = (short)1400373248;
				short num2 = num;
				num = (short)455172018;
				short num3 = num;
				num = (short)1668964274;
				switch (num3 == num)
				{
				}
				num = (short)1320288256;
				if (num != 0)
				{
				}
				num = (short)1797128193;
				if (num != 0)
				{
				}
				return this.trkSysSiteAliasSiteAliasNumber_A9145.Visible;
			}
			set
			{
				short num = (short)1815674881;
				if (num != 0)
				{
				}
				num = (short)1832661725;
				short num2 = num;
				num = (short)1093612253;
				switch (num2 == num)
				{
				}
				num = (short)778829824;
				if (num != 0)
				{
				}
				num = (short)2071330816;
				short num3 = num;
				this.trkSysSiteAliasSiteAliasNumber_A9145.Visible = value;
			}
		}

		// Token: 0x17000A15 RID: 2581
		// (get) Token: 0x06001411 RID: 5137 RVA: 0x0012DD14 File Offset: 0x0012BF14
		// (set) Token: 0x06001412 RID: 5138 RVA: 0x0012DDC8 File Offset: 0x0012BFC8
		public bool TrkSysSiteAliasSiteAliasNumber_A9145_Editable
		{
			get
			{
				short num = (short)2122244007;
				short num2 = num;
				num = (short)847568807;
				switch (num2 == num)
				{
				}
				num = (short)1958477825;
				if (num != 0)
				{
				}
				num = (short)1617952768;
				if (num != 0)
				{
				}
				num = (short)94109696;
				short num3 = num;
				return this.trkSysSiteAliasSiteAliasNumber_A9145.Editable;
			}
			set
			{
				short num = (short)969984973;
				short num2 = num;
				num = (short)1628621773;
				switch (num2 == num)
				{
				}
				num = (short)1480851457;
				if (num != 0)
				{
				}
				num = (short)13434880;
				if (num != 0)
				{
				}
				num = (short)867368960;
				short num3 = num;
				this.trkSysSiteAliasSiteAliasNumber_A9145.Editable = value;
			}
		}

		// Token: 0x17000A16 RID: 2582
		// (get) Token: 0x06001413 RID: 5139 RVA: 0x0012DE7C File Offset: 0x0012C07C
		internal string TrkSysSiteAliasSiteAliasNumber_A9145_UILabel
		{
			get
			{
				short num = (short)295134472;
				short num2 = num;
				num = (short)1171350792;
				switch (num2 == num)
				{
				}
				num = (short)1978466305;
				if (num != 0)
				{
				}
				num = (short)1751056384;
				if (num != 0)
				{
				}
				num = (short)144113664;
				short num3 = num;
				return this.trkSysSiteAliasSiteAliasNumber_A9145.UIName;
			}
		}

		// Token: 0x17000A17 RID: 2583
		// (get) Token: 0x06001414 RID: 5140 RVA: 0x0012DF2C File Offset: 0x0012C12C
		// (set) Token: 0x06001415 RID: 5141 RVA: 0x0012DFE4 File Offset: 0x0012C1E4
		internal bool TrkSysSiteAliasSiteAliasNumber_A9145_HiddenStatic
		{
			get
			{
				short num = (short)801729696;
				short num2 = num;
				num = (short)1036283040;
				switch (num2 == num)
				{
				}
				num = (short)1930625024;
				if (num != 0)
				{
				}
				num = (short)1090191361;
				if (num != 0)
				{
				}
				num = (short)277086208;
				short num3 = num;
				return this.trkSysSiteAliasSiteAliasNumber_A9145.HiddenStatic;
			}
			set
			{
				short num = (short)365224022;
				short num2 = num;
				num = (short)1306255446;
				switch (num2 == num)
				{
				}
				num = (short)226885632;
				if (num != 0)
				{
				}
				num = (short)385351681;
				if (num != 0)
				{
				}
				num = (short)746061824;
				short num3 = num;
				this.trkSysSiteAliasSiteAliasNumber_A9145.HiddenStatic = value;
			}
		}

		// Token: 0x17000A18 RID: 2584
		// (get) Token: 0x06001416 RID: 5142 RVA: 0x0012E09C File Offset: 0x0012C29C
		// (set) Token: 0x06001417 RID: 5143 RVA: 0x0012E154 File Offset: 0x0012C354
		internal bool TrkSysSiteAliasSiteAliasNumber_A9145_HiddenDynamic
		{
			get
			{
				short num = (short)1792278529;
				if (num != 0)
				{
				}
				num = (short)1643204969;
				short num2 = num;
				num = (short)2023444841;
				switch (num2 == num)
				{
				}
				num = (short)1501757440;
				if (num != 0)
				{
				}
				num = (short)1940258816;
				short num3 = num;
				return this.trkSysSiteAliasSiteAliasNumber_A9145.HiddenDynamic;
			}
			set
			{
				short num = (short)82773790;
				short num2 = num;
				num = (short)1558382366;
				switch (num2 == num)
				{
				}
				num = (short)932708353;
				if (num != 0)
				{
				}
				num = (short)798097408;
				if (num != 0)
				{
				}
				num = (short)1144127488;
				short num3 = num;
				this.trkSysSiteAliasSiteAliasNumber_A9145.HiddenDynamic = value;
			}
		}

		// Token: 0x17000A19 RID: 2585
		// (get) Token: 0x06001418 RID: 5144 RVA: 0x0012E208 File Offset: 0x0012C408
		public bool TrkSysSiteAliasSiteAliasNumber_A9145_HasDiffs
		{
			get
			{
				short num = (short)1804018263;
				short num2 = num;
				num = (short)1599021655;
				switch (num2 == num)
				{
				}
				num = (short)1115947009;
				if (num != 0)
				{
				}
				num = (short)938672128;
				if (num != 0)
				{
				}
				num = (short)599064576;
				short num3 = num;
				return this.trkSysSiteAliasSiteAliasNumber_A9145._HasDiffs;
			}
		}

		// Token: 0x17000A1A RID: 2586
		// (get) Token: 0x06001419 RID: 5145 RVA: 0x0012E2BC File Offset: 0x0012C4BC
		// (set) Token: 0x0600141A RID: 5146 RVA: 0x0012E374 File Offset: 0x0012C574
		public string TrkSysSiteAliasSiteAliasText_A9146Value
		{
			get
			{
				short num = (short)1562710574;
				short num2 = num;
				num = (short)128586286;
				switch (num2 == num)
				{
				}
				num = (short)756350977;
				if (num != 0)
				{
				}
				num = (short)603652096;
				if (num != 0)
				{
				}
				num = (short)649265152;
				short num3 = num;
				return this.trkSysSiteAliasSiteAliasText_A9146.Value;
			}
			set
			{
				short num = (short)147753014;
				short num2 = num;
				num = (short)2007533622;
				switch (num2 == num)
				{
				}
				num = (short)1958543361;
				if (num != 0)
				{
				}
				num = (short)306118656;
				if (num != 0)
				{
				}
				num = (short)1969815552;
				short num3 = num;
				this.trkSysSiteAliasSiteAliasText_A9146.Value = value;
			}
		}

		// Token: 0x17000A1B RID: 2587
		// (get) Token: 0x0600141B RID: 5147 RVA: 0x0012E428 File Offset: 0x0012C628
		public global::AcpBusinessLayer.AcpField<string> TrkSysSiteAliasSiteAliasText_A9146
		{
			get
			{
				short num = (short)1871863007;
				short num2 = num;
				num = (short)1970232543;
				switch (num2 == num)
				{
				}
				num = (short)713490433;
				if (num != 0)
				{
				}
				num = (short)1880293376;
				if (num != 0)
				{
				}
				num = (short)1377173504;
				short num3 = num;
				return this.trkSysSiteAliasSiteAliasText_A9146;
			}
		}

		// Token: 0x17000A1C RID: 2588
		// (get) Token: 0x0600141C RID: 5148 RVA: 0x0012E4D4 File Offset: 0x0012C6D4
		// (set) Token: 0x0600141D RID: 5149 RVA: 0x0012E588 File Offset: 0x0012C788
		public string TrkSysSiteAliasSiteAliasText_A9146_UIValue
		{
			get
			{
				short num = (short)2138764324;
				short num2 = num;
				num = (short)1951200292;
				switch (num2 == num)
				{
				}
				num = (short)1140588545;
				if (num != 0)
				{
				}
				num = (short)1664679936;
				if (num != 0)
				{
				}
				num = (short)1556480000;
				short num3 = num;
				return this.trkSysSiteAliasSiteAliasText_A9146.Value;
			}
			set
			{
				short num = (short)884342785;
				if (num != 0)
				{
				}
				num = (short)1716120518;
				short num2 = num;
				num = (short)432270278;
				switch (num2 == num)
				{
				}
				num = (short)1107623936;
				if (num != 0)
				{
				}
				num = (short)2099118080;
				short num3 = num;
				this.trkSysSiteAliasSiteAliasText_A9146.Value = value;
			}
		}

		// Token: 0x17000A1D RID: 2589
		// (get) Token: 0x0600141E RID: 5150 RVA: 0x0012E63C File Offset: 0x0012C83C
		// (set) Token: 0x0600141F RID: 5151 RVA: 0x0012E6F0 File Offset: 0x0012C8F0
		public bool TrkSysSiteAliasSiteAliasText_A9146_Applicable
		{
			get
			{
				short num = (short)1358217698;
				short num2 = num;
				num = (short)1336984034;
				switch (num2 == num)
				{
				}
				num = (short)1128595456;
				if (num != 0)
				{
				}
				num = (short)2110586881;
				if (num != 0)
				{
				}
				num = (short)2063663104;
				short num3 = num;
				return this.trkSysSiteAliasSiteAliasText_A9146.Applicable;
			}
			set
			{
				short num = (short)118941428;
				short num2 = num;
				num = (short)2098259700;
				switch (num2 == num)
				{
				}
				num = (short)499122176;
				if (num != 0)
				{
				}
				num = (short)455409665;
				if (num != 0)
				{
				}
				num = (short)12189696;
				short num3 = num;
				this.trkSysSiteAliasSiteAliasText_A9146.Applicable = value;
			}
		}

		// Token: 0x17000A1E RID: 2590
		// (get) Token: 0x06001420 RID: 5152 RVA: 0x0012E7A4 File Offset: 0x0012C9A4
		// (set) Token: 0x06001421 RID: 5153 RVA: 0x0012E858 File Offset: 0x0012CA58
		public bool TrkSysSiteAliasSiteAliasText_A9146_Valid
		{
			get
			{
				short num = (short)1192162594;
				short num2 = num;
				num = (short)174781730;
				switch (num2 == num)
				{
				}
				num = (short)340656129;
				if (num != 0)
				{
				}
				num = (short)1014759424;
				if (num != 0)
				{
				}
				num = (short)1002373120;
				short num3 = num;
				return this.trkSysSiteAliasSiteAliasText_A9146.Valid;
			}
			set
			{
				short num = (short)1215638019;
				short num2 = num;
				num = (short)884746755;
				switch (num2 == num)
				{
				}
				num = (short)428474369;
				if (num != 0)
				{
				}
				num = (short)232849408;
				if (num != 0)
				{
				}
				num = (short)1389559808;
				short num3 = num;
				this.trkSysSiteAliasSiteAliasText_A9146.Valid = value;
			}
		}

		// Token: 0x17000A1F RID: 2591
		// (get) Token: 0x06001422 RID: 5154 RVA: 0x0012E90C File Offset: 0x0012CB0C
		// (set) Token: 0x06001423 RID: 5155 RVA: 0x0012E9C0 File Offset: 0x0012CBC0
		public bool TrkSysSiteAliasSiteAliasText_A9146_Visible
		{
			get
			{
				short num = (short)353375107;
				short num2 = num;
				num = (short)982258563;
				switch (num2 == num)
				{
				}
				num = (short)1516765184;
				if (num != 0)
				{
				}
				num = (short)1893531649;
				if (num != 0)
				{
				}
				num = (short)1166540800;
				short num3 = num;
				return this.trkSysSiteAliasSiteAliasText_A9146.Visible;
			}
			set
			{
				short num = (short)2069990394;
				short num2 = num;
				num = (short)1574079482;
				switch (num2 == num)
				{
				}
				num = (short)1701838848;
				if (num != 0)
				{
				}
				num = (short)2089222145;
				if (num != 0)
				{
				}
				num = (short)1201537024;
				short num3 = num;
				this.trkSysSiteAliasSiteAliasText_A9146.Visible = value;
			}
		}

		// Token: 0x17000A20 RID: 2592
		// (get) Token: 0x06001424 RID: 5156 RVA: 0x0012EA78 File Offset: 0x0012CC78
		// (set) Token: 0x06001425 RID: 5157 RVA: 0x0012EB2C File Offset: 0x0012CD2C
		public bool TrkSysSiteAliasSiteAliasText_A9146_Editable
		{
			get
			{
				short num = (short)555756358;
				short num2 = num;
				num = (short)1095117638;
				switch (num2 == num)
				{
				}
				num = (short)1012006913;
				if (num != 0)
				{
				}
				num = (short)1513488384;
				if (num != 0)
				{
				}
				num = (short)2046296064;
				short num3 = num;
				return this.trkSysSiteAliasSiteAliasText_A9146.Editable;
			}
			set
			{
				short num = (short)31551610;
				short num2 = num;
				num = (short)7368826;
				switch (num2 == num)
				{
				}
				num = (short)30212096;
				if (num != 0)
				{
				}
				num = (short)959250433;
				if (num != 0)
				{
				}
				num = (short)399441920;
				short num3 = num;
				this.trkSysSiteAliasSiteAliasText_A9146.Editable = value;
			}
		}

		// Token: 0x17000A21 RID: 2593
		// (get) Token: 0x06001426 RID: 5158 RVA: 0x0012EBE0 File Offset: 0x0012CDE0
		internal string TrkSysSiteAliasSiteAliasText_A9146_UILabel
		{
			get
			{
				short num = (short)759691102;
				short num2 = num;
				num = (short)56096606;
				switch (num2 == num)
				{
				}
				num = (short)2122186753;
				if (num != 0)
				{
				}
				num = (short)546177024;
				if (num != 0)
				{
				}
				num = (short)978780160;
				short num3 = num;
				return this.trkSysSiteAliasSiteAliasText_A9146.UIName;
			}
		}

		// Token: 0x17000A22 RID: 2594
		// (get) Token: 0x06001427 RID: 5159 RVA: 0x0012EC94 File Offset: 0x0012CE94
		// (set) Token: 0x06001428 RID: 5160 RVA: 0x0012ED48 File Offset: 0x0012CF48
		internal bool TrkSysSiteAliasSiteAliasText_A9146_HiddenStatic
		{
			get
			{
				short num = (short)1955004417;
				if (num != 0)
				{
				}
				num = (short)129445481;
				short num2 = num;
				num = (short)1739992681;
				switch (num2 == num)
				{
				}
				num = (short)872808448;
				if (num != 0)
				{
				}
				num = (short)264044544;
				short num3 = num;
				return this.trkSysSiteAliasSiteAliasText_A9146.HiddenStatic;
			}
			set
			{
				short num = (short)2001253148;
				short num2 = num;
				num = (short)1500885788;
				switch (num2 == num)
				{
				}
				num = (short)691077121;
				if (num != 0)
				{
				}
				num = (short)1343356928;
				if (num != 0)
				{
				}
				num = (short)1152843776;
				short num3 = num;
				this.trkSysSiteAliasSiteAliasText_A9146.HiddenStatic = value;
			}
		}

		// Token: 0x17000A23 RID: 2595
		// (get) Token: 0x06001429 RID: 5161 RVA: 0x0012EE00 File Offset: 0x0012D000
		// (set) Token: 0x0600142A RID: 5162 RVA: 0x0012EEB8 File Offset: 0x0012D0B8
		internal bool TrkSysSiteAliasSiteAliasText_A9146_HiddenDynamic
		{
			get
			{
				short num = (short)1736399238;
				short num2 = num;
				num = (short)279796102;
				switch (num2 == num)
				{
				}
				num = (short)1766064129;
				if (num != 0)
				{
				}
				num = (short)1288306688;
				if (num != 0)
				{
				}
				num = (short)183959552;
				short num3 = num;
				return this.trkSysSiteAliasSiteAliasText_A9146.HiddenDynamic;
			}
			set
			{
				short num = (short)962235908;
				short num2 = num;
				num = (short)2028113412;
				switch (num2 == num)
				{
				}
				num = (short)833355777;
				if (num != 0)
				{
				}
				num = (short)1432879104;
				if (num != 0)
				{
				}
				num = (short)1082982400;
				short num3 = num;
				this.trkSysSiteAliasSiteAliasText_A9146.HiddenDynamic = value;
			}
		}

		// Token: 0x17000A24 RID: 2596
		// (get) Token: 0x0600142B RID: 5163 RVA: 0x0012EF6C File Offset: 0x0012D16C
		public bool TrkSysSiteAliasSiteAliasText_A9146_HasDiffs
		{
			get
			{
				short num = (short)69861377;
				if (num != 0)
				{
				}
				num = (short)695191249;
				short num2 = num;
				num = (short)1961412305;
				switch (num2 == num)
				{
				}
				num = (short)2048196608;
				if (num != 0)
				{
				}
				num = (short)686227456;
				short num3 = num;
				return this.trkSysSiteAliasSiteAliasText_A9146._HasDiffs;
			}
		}

		// Token: 0x17000A25 RID: 2597
		// (get) Token: 0x0600142C RID: 5164 RVA: 0x0012F024 File Offset: 0x0012D224
		// (set) Token: 0x0600142D RID: 5165 RVA: 0x0012F0DC File Offset: 0x0012D2DC
		public int TrkSysSiteAliasSystemNumber_A19669Value
		{
			get
			{
				short num = (short)1274688717;
				short num2 = num;
				num = (short)1192506573;
				switch (num2 == num)
				{
				}
				num = (short)1054670848;
				if (num != 0)
				{
				}
				num = (short)2001272833;
				if (num != 0)
				{
				}
				num = (short)508624896;
				short num3 = num;
				return this.trkSysSiteAliasSystemNumber_A19669.Value;
			}
			set
			{
				short num = (short)736624641;
				if (num != 0)
				{
				}
				num = (short)731704985;
				short num2 = num;
				num = (short)1827597977;
				switch (num2 == num)
				{
				}
				num = (short)725352448;
				if (num != 0)
				{
				}
				num = (short)63438848;
				short num3 = num;
				this.trkSysSiteAliasSystemNumber_A19669.Value = value;
			}
		}

		// Token: 0x17000A26 RID: 2598
		// (get) Token: 0x0600142E RID: 5166 RVA: 0x0012F194 File Offset: 0x0012D394
		public global::AcpBusinessLayer.AcpSimpleRangeField TrkSysSiteAliasSystemNumber_A19669
		{
			get
			{
				short num = (short)1019937043;
				short num2 = num;
				num = (short)962658579;
				switch (num2 == num)
				{
				}
				num = (short)2686977;
				if (num != 0)
				{
				}
				num = (short)609288192;
				if (num != 0)
				{
				}
				num = (short)1030422528;
				short num3 = num;
				return this.trkSysSiteAliasSystemNumber_A19669;
			}
		}

		// Token: 0x17000A27 RID: 2599
		// (get) Token: 0x0600142F RID: 5167 RVA: 0x0012F248 File Offset: 0x0012D448
		// (set) Token: 0x06001430 RID: 5168 RVA: 0x0012F2FC File Offset: 0x0012D4FC
		public string TrkSysSiteAliasSystemNumber_A19669_UIValue
		{
			get
			{
				short num = (short)1394187275;
				short num2 = num;
				num = (short)112434187;
				switch (num2 == num)
				{
				}
				num = (short)324796417;
				if (num != 0)
				{
				}
				num = (short)468385792;
				if (num != 0)
				{
				}
				num = (short)1961492480;
				short num3 = num;
				return this.trkSysSiteAliasSystemNumber_A19669.UIValue;
			}
			set
			{
				short num = (short)2000098103;
				short num2 = num;
				num = (short)99881783;
				switch (num2 == num)
				{
				}
				num = (short)1492123648;
				if (num != 0)
				{
				}
				num = (short)970457089;
				if (num != 0)
				{
				}
				num = (short)345899008;
				short num3 = num;
				this.trkSysSiteAliasSystemNumber_A19669.UIValue = value;
			}
		}

		// Token: 0x17000A28 RID: 2600
		// (get) Token: 0x06001431 RID: 5169 RVA: 0x0012F3B0 File Offset: 0x0012D5B0
		// (set) Token: 0x06001432 RID: 5170 RVA: 0x0012F464 File Offset: 0x0012D664
		public string TrkSysSiteAliasSystemNumber_A19669_HexUIValue
		{
			get
			{
				short num = (short)434510395;
				short num2 = num;
				num = (short)1225988667;
				switch (num2 == num)
				{
				}
				num = (short)1351548929;
				if (num != 0)
				{
				}
				num = (short)1350500352;
				if (num != 0)
				{
				}
				num = (short)426311680;
				short num3 = num;
				return this.trkSysSiteAliasSystemNumber_A19669.HexUIValue;
			}
			set
			{
				short num = (short)1215601714;
				short num2 = num;
				num = (short)950049842;
				switch (num2 == num)
				{
				}
				num = (short)416808961;
				if (num != 0)
				{
				}
				num = (short)1003945984;
				if (num != 0)
				{
				}
				num = (short)887029760;
				short num3 = num;
				this.trkSysSiteAliasSystemNumber_A19669.HexUIValue = value;
			}
		}

		// Token: 0x17000A29 RID: 2601
		// (get) Token: 0x06001433 RID: 5171 RVA: 0x0012F51C File Offset: 0x0012D71C
		// (set) Token: 0x06001434 RID: 5172 RVA: 0x0012F5D4 File Offset: 0x0012D7D4
		internal int TrkSysSiteAliasSystemNumber_A19669Min
		{
			get
			{
				short num = (short)386793473;
				if (num != 0)
				{
				}
				num = (short)1378049162;
				short num2 = num;
				num = (short)930438282;
				switch (num2 == num)
				{
				}
				num = (short)1203109888;
				if (num != 0)
				{
				}
				num = (short)1138425856;
				short num3 = num;
				return this.trkSysSiteAliasSystemNumber_A19669.Min;
			}
			set
			{
				short num = (short)1566881279;
				short num2 = num;
				num = (short)1592309247;
				switch (num2 == num)
				{
				}
				num = (short)1315438593;
				if (num != 0)
				{
				}
				num = (short)2079129600;
				if (num != 0)
				{
				}
				num = (short)1815740416;
				short num3 = num;
				this.trkSysSiteAliasSystemNumber_A19669.Min = value;
			}
		}

		// Token: 0x17000A2A RID: 2602
		// (get) Token: 0x06001435 RID: 5173 RVA: 0x0012F688 File Offset: 0x0012D888
		// (set) Token: 0x06001436 RID: 5174 RVA: 0x0012F73C File Offset: 0x0012D93C
		internal int TrkSysSiteAliasSystemNumber_A19669Max
		{
			get
			{
				short num = (short)242992897;
				short num2 = num;
				num = (short)2132854529;
				switch (num2 == num)
				{
				}
				num = (short)1140654080;
				if (num != 0)
				{
				}
				num = (short)941031425;
				if (num != 0)
				{
				}
				num = (short)658243584;
				short num3 = num;
				return this.trkSysSiteAliasSystemNumber_A19669.Max;
			}
			set
			{
				short num = (short)1499250192;
				short num2 = num;
				num = (short)897629712;
				switch (num2 == num)
				{
				}
				num = (short)318898176;
				if (num != 0)
				{
				}
				num = (short)1768226817;
				if (num != 0)
				{
				}
				num = (short)380567552;
				short num3 = num;
				this.trkSysSiteAliasSystemNumber_A19669.Max = value;
			}
		}

		// Token: 0x17000A2B RID: 2603
		// (get) Token: 0x06001437 RID: 5175 RVA: 0x0012F7F4 File Offset: 0x0012D9F4
		// (set) Token: 0x06001438 RID: 5176 RVA: 0x0012F8AC File Offset: 0x0012DAAC
		internal int TrkSysSiteAliasSystemNumber_A19669Step
		{
			get
			{
				short num = (short)11140740;
				short num2 = num;
				num = (short)692387460;
				switch (num2 == num)
				{
				}
				num = (short)182845441;
				if (num != 0)
				{
				}
				num = (short)1886453760;
				if (num != 0)
				{
				}
				num = (short)30474240;
				short num3 = num;
				return this.trkSysSiteAliasSystemNumber_A19669.StepSize;
			}
			set
			{
				short num = (short)182924322;
				short num2 = num;
				num = (short)786117666;
				switch (num2 == num)
				{
				}
				num = (short)150470657;
				if (num != 0)
				{
				}
				num = (short)325844992;
				if (num != 0)
				{
				}
				num = (short)2092630016;
				short num3 = num;
				this.trkSysSiteAliasSystemNumber_A19669.StepSize = value;
			}
		}

		// Token: 0x17000A2C RID: 2604
		// (get) Token: 0x06001439 RID: 5177 RVA: 0x0012F964 File Offset: 0x0012DB64
		// (set) Token: 0x0600143A RID: 5178 RVA: 0x0012FA1C File Offset: 0x0012DC1C
		public bool TrkSysSiteAliasSystemNumber_A19669_Applicable
		{
			get
			{
				short num = (short)881486537;
				short num2 = num;
				num = (short)1273129673;
				switch (num2 == num)
				{
				}
				num = (short)1322647553;
				if (num != 0)
				{
				}
				num = (short)870187008;
				if (num != 0)
				{
				}
				num = (short)2041774080;
				short num3 = num;
				return this.trkSysSiteAliasSystemNumber_A19669.Applicable;
			}
			set
			{
				short num = (short)1904926391;
				short num2 = num;
				num = (short)1631444663;
				switch (num2 == num)
				{
				}
				num = (short)997916673;
				if (num != 0)
				{
				}
				num = (short)1742274560;
				if (num != 0)
				{
				}
				num = (short)1045364736;
				short num3 = num;
				this.trkSysSiteAliasSystemNumber_A19669.Applicable = value;
			}
		}

		// Token: 0x17000A2D RID: 2605
		// (get) Token: 0x0600143B RID: 5179 RVA: 0x0012FAD0 File Offset: 0x0012DCD0
		// (set) Token: 0x0600143C RID: 5180 RVA: 0x0012FB84 File Offset: 0x0012DD84
		public bool TrkSysSiteAliasSystemNumber_A19669_Valid
		{
			get
			{
				short num = (short)237780611;
				short num2 = num;
				num = (short)1319255683;
				switch (num2 == num)
				{
				}
				num = (short)1306918913;
				if (num != 0)
				{
				}
				num = (short)1360461824;
				if (num != 0)
				{
				}
				num = (short)546701312;
				short num3 = num;
				return this.trkSysSiteAliasSystemNumber_A19669.Valid;
			}
			set
			{
				short num = (short)705263288;
				short num2 = num;
				num = (short)1140684472;
				switch (num2 == num)
				{
				}
				num = (short)2029060097;
				if (num != 0)
				{
				}
				num = (short)299302912;
				if (num != 0)
				{
				}
				num = (short)870055936;
				short num3 = num;
				this.trkSysSiteAliasSystemNumber_A19669.Valid = value;
			}
		}

		// Token: 0x17000A2E RID: 2606
		// (get) Token: 0x0600143D RID: 5181 RVA: 0x0012FC3C File Offset: 0x0012DE3C
		// (set) Token: 0x0600143E RID: 5182 RVA: 0x0012FCF4 File Offset: 0x0012DEF4
		public bool TrkSysSiteAliasSystemNumber_A19669_Visible
		{
			get
			{
				short num = (short)1731258941;
				short num2 = num;
				num = (short)776661565;
				switch (num2 == num)
				{
				}
				num = (short)33947649;
				if (num != 0)
				{
				}
				num = (short)1884225536;
				if (num != 0)
				{
				}
				num = (short)1104281600;
				short num3 = num;
				return this.trkSysSiteAliasSystemNumber_A19669.Visible;
			}
			set
			{
				short num = (short)929183181;
				short num2 = num;
				num = (short)1333933517;
				switch (num2 == num)
				{
				}
				num = (short)166592513;
				if (num != 0)
				{
				}
				num = (short)741408768;
				if (num != 0)
				{
				}
				num = (short)178847744;
				short num3 = num;
				this.trkSysSiteAliasSystemNumber_A19669.Visible = value;
			}
		}

		// Token: 0x17000A2F RID: 2607
		// (get) Token: 0x0600143F RID: 5183 RVA: 0x0012FDAC File Offset: 0x0012DFAC
		// (set) Token: 0x06001440 RID: 5184 RVA: 0x0012FE64 File Offset: 0x0012E064
		public bool TrkSysSiteAliasSystemNumber_A19669_Editable
		{
			get
			{
				short num = (short)1454129667;
				short num2 = num;
				num = (short)313999875;
				switch (num2 == num)
				{
				}
				num = (short)341901313;
				if (num != 0)
				{
				}
				num = (short)841220096;
				if (num != 0)
				{
				}
				num = (short)773259264;
				short num3 = num;
				return this.trkSysSiteAliasSystemNumber_A19669.Editable;
			}
			set
			{
				short num = (short)1083042561;
				short num2 = num;
				num = (short)2119232257;
				switch (num2 == num)
				{
				}
				num = (short)513736705;
				if (num != 0)
				{
				}
				num = (short)69795840;
				if (num != 0)
				{
				}
				num = (short)424017920;
				short num3 = num;
				this.trkSysSiteAliasSystemNumber_A19669.Editable = value;
			}
		}

		// Token: 0x17000A30 RID: 2608
		// (get) Token: 0x06001441 RID: 5185 RVA: 0x0012FF18 File Offset: 0x0012E118
		internal string TrkSysSiteAliasSystemNumber_A19669_UILabel
		{
			get
			{
				short num = (short)1351081504;
				short num2 = num;
				num = (short)1050598944;
				switch (num2 == num)
				{
				}
				num = (short)1530855424;
				if (num != 0)
				{
				}
				num = (short)1389428737;
				if (num != 0)
				{
				}
				num = (short)309985280;
				short num3 = num;
				return this.trkSysSiteAliasSystemNumber_A19669.UIName;
			}
		}

		// Token: 0x17000A31 RID: 2609
		// (get) Token: 0x06001442 RID: 5186 RVA: 0x0012FFCC File Offset: 0x0012E1CC
		// (set) Token: 0x06001443 RID: 5187 RVA: 0x00130080 File Offset: 0x0012E280
		internal bool TrkSysSiteAliasSystemNumber_A19669_HiddenStatic
		{
			get
			{
				short num = (short)986885144;
				short num2 = num;
				num = (short)708029464;
				switch (num2 == num)
				{
				}
				num = (short)573177857;
				if (num != 0)
				{
				}
				num = (short)1551237120;
				if (num != 0)
				{
				}
				num = (short)715456512;
				short num3 = num;
				return this.trkSysSiteAliasSystemNumber_A19669.HiddenStatic;
			}
			set
			{
				short num = (short)59204921;
				short num2 = num;
				num = (short)765486393;
				switch (num2 == num)
				{
				}
				num = (short)947322880;
				if (num != 0)
				{
				}
				num = (short)723779585;
				if (num != 0)
				{
				}
				num = (short)1870659584;
				short num3 = num;
				this.trkSysSiteAliasSystemNumber_A19669.HiddenStatic = value;
			}
		}

		// Token: 0x17000A32 RID: 2610
		// (get) Token: 0x06001444 RID: 5188 RVA: 0x00130138 File Offset: 0x0012E338
		// (set) Token: 0x06001445 RID: 5189 RVA: 0x001301EC File Offset: 0x0012E3EC
		internal bool TrkSysSiteAliasSystemNumber_A19669_HiddenDynamic
		{
			get
			{
				short num = (short)1959354490;
				short num2 = num;
				num = (short)56189050;
				switch (num2 == num)
				{
				}
				num = (short)2082799617;
				if (num != 0)
				{
				}
				num = (short)1051197440;
				if (num != 0)
				{
				}
				num = (short)1275723776;
				short num3 = num;
				return this.trkSysSiteAliasSystemNumber_A19669.HiddenDynamic;
			}
			set
			{
				short num = (short)357818490;
				short num2 = num;
				num = (short)221175930;
				switch (num2 == num)
				{
				}
				num = (short)492306433;
				if (num != 0)
				{
				}
				num = (short)1063714816;
				if (num != 0)
				{
				}
				num = (short)1889009664;
				short num3 = num;
				this.trkSysSiteAliasSystemNumber_A19669.HiddenDynamic = value;
			}
		}

		// Token: 0x17000A33 RID: 2611
		// (get) Token: 0x06001446 RID: 5190 RVA: 0x001302A4 File Offset: 0x0012E4A4
		public bool TrkSysSiteAliasSystemNumber_A19669_HasDiffs
		{
			get
			{
				short num = (short)1419392108;
				short num2 = num;
				num = (short)2075014252;
				switch (num2 == num)
				{
				}
				num = (short)721354753;
				if (num != 0)
				{
				}
				num = (short)463470592;
				if (num != 0)
				{
				}
				num = (short)393150464;
				short num3 = num;
				return this.trkSysSiteAliasSystemNumber_A19669._HasDiffs;
			}
		}

		// Token: 0x17000A34 RID: 2612
		// (get) Token: 0x06001447 RID: 5191 RVA: 0x0013035C File Offset: 0x0012E55C
		// (set) Token: 0x06001448 RID: 5192 RVA: 0x00130410 File Offset: 0x0012E610
		public int TrkSysSiteAliasHomeRASWACNNumber_A20169Value
		{
			get
			{
				short num = (short)624542307;
				short num2 = num;
				num = (short)176079459;
				switch (num2 == num)
				{
				}
				num = (short)1436024833;
				if (num != 0)
				{
				}
				num = (short)1635254272;
				if (num != 0)
				{
				}
				num = (short)825229312;
				short num3 = num;
				return this.trkSysSiteAliasHomeRASWACNNumber_A20169.Value;
			}
			set
			{
				short num = (short)1980688457;
				short num2 = num;
				num = (short)1103095881;
				switch (num2 == num)
				{
				}
				num = (short)506003456;
				if (num != 0)
				{
				}
				num = (short)952369153;
				if (num != 0)
				{
				}
				num = (short)1475805184;
				short num3 = num;
				this.trkSysSiteAliasHomeRASWACNNumber_A20169.Value = value;
			}
		}

		// Token: 0x17000A35 RID: 2613
		// (get) Token: 0x06001449 RID: 5193 RVA: 0x001304C8 File Offset: 0x0012E6C8
		public global::AcpBusinessLayer.AcpSimpleRangeField TrkSysSiteAliasHomeRASWACNNumber_A20169
		{
			get
			{
				short num = (short)980983139;
				short num2 = num;
				num = (short)2076482915;
				switch (num2 == num)
				{
				}
				num = (short)59965441;
				if (num != 0)
				{
				}
				num = (short)2015625216;
				if (num != 0)
				{
				}
				num = (short)275906560;
				short num3 = num;
				return this.trkSysSiteAliasHomeRASWACNNumber_A20169;
			}
		}

		// Token: 0x17000A36 RID: 2614
		// (get) Token: 0x0600144A RID: 5194 RVA: 0x00130578 File Offset: 0x0012E778
		// (set) Token: 0x0600144B RID: 5195 RVA: 0x0013062C File Offset: 0x0012E82C
		public string TrkSysSiteAliasHomeRASWACNNumber_A20169_UIValue
		{
			get
			{
				short num = (short)1432551425;
				if (num != 0)
				{
				}
				num = (short)1014084075;
				short num2 = num;
				num = (short)1431548395;
				switch (num2 == num)
				{
				}
				num = (short)846528512;
				if (num != 0)
				{
				}
				num = (short)404488192;
				short num3 = num;
				return this.trkSysSiteAliasHomeRASWACNNumber_A20169.UIValue;
			}
			set
			{
				short num = (short)2122453785;
				short num2 = num;
				num = (short)1764365081;
				switch (num2 == num)
				{
				}
				num = (short)2084306945;
				if (num != 0)
				{
				}
				num = (short)1096220672;
				if (num != 0)
				{
				}
				num = (short)1912602624;
				short num3 = num;
				this.trkSysSiteAliasHomeRASWACNNumber_A20169.UIValue = value;
			}
		}

		// Token: 0x17000A37 RID: 2615
		// (get) Token: 0x0600144C RID: 5196 RVA: 0x001306E8 File Offset: 0x0012E8E8
		// (set) Token: 0x0600144D RID: 5197 RVA: 0x00130798 File Offset: 0x0012E998
		public string TrkSysSiteAliasHomeRASWACNNumber_A20169_HexUIValue
		{
			get
			{
				short num = (short)1109545554;
				short num2 = num;
				num = (short)1081561682;
				switch (num2 == num)
				{
				}
				num = (short)1317404673;
				if (num != 0)
				{
				}
				num = (short)494141440;
				if (num != 0)
				{
				}
				num = (short)785973248;
				short num3 = num;
				return this.trkSysSiteAliasHomeRASWACNNumber_A20169.HexUIValue;
			}
			set
			{
				short num = (short)1692205057;
				if (num != 0)
				{
				}
				num = (short)1107135127;
				short num2 = num;
				num = (short)1978043031;
				switch (num2 == num)
				{
				}
				num = (short)231145472;
				if (num != 0)
				{
				}
				num = (short)1427701760;
				short num3 = num;
				this.trkSysSiteAliasHomeRASWACNNumber_A20169.HexUIValue = value;
			}
		}

		// Token: 0x17000A38 RID: 2616
		// (get) Token: 0x0600144E RID: 5198 RVA: 0x0013084C File Offset: 0x0012EA4C
		// (set) Token: 0x0600144F RID: 5199 RVA: 0x00130900 File Offset: 0x0012EB00
		internal int TrkSysSiteAliasHomeRASWACNNumber_A20169Min
		{
			get
			{
				short num = (short)1907151440;
				short num2 = num;
				num = (short)1432539728;
				switch (num2 == num)
				{
				}
				num = (short)475332608;
				if (num != 0)
				{
				}
				num = (short)1858535425;
				if (num != 0)
				{
				}
				num = (short)359792640;
				short num3 = num;
				return this.trkSysSiteAliasHomeRASWACNNumber_A20169.Min;
			}
			set
			{
				short num = (short)779367357;
				short num2 = num;
				num = (short)2119644093;
				switch (num2 == num)
				{
				}
				num = (short)71892993;
				if (num != 0)
				{
				}
				num = (short)143785984;
				if (num != 0)
				{
				}
				num = (short)1735458816;
				short num3 = num;
				this.trkSysSiteAliasHomeRASWACNNumber_A20169.Min = value;
			}
		}

		// Token: 0x17000A39 RID: 2617
		// (get) Token: 0x06001450 RID: 5200 RVA: 0x001309B4 File Offset: 0x0012EBB4
		// (set) Token: 0x06001451 RID: 5201 RVA: 0x00130A68 File Offset: 0x0012EC68
		internal int TrkSysSiteAliasHomeRASWACNNumber_A20169Max
		{
			get
			{
				short num = (short)507772928;
				short num2 = num;
				num = (short)1017511937;
				if (num != 0)
				{
				}
				num = (short)1008406810;
				short num3 = num;
				num = (short)1569394970;
				switch (num3 == num)
				{
				}
				num = (short)1108082688;
				if (num != 0)
				{
				}
				return this.trkSysSiteAliasHomeRASWACNNumber_A20169.Max;
			}
			set
			{
				short num = (short)12779520;
				short num2 = num;
				num = (short)313781291;
				short num3 = num;
				num = (short)969796651;
				switch (num3 == num)
				{
				}
				num = (short)487653377;
				if (num != 0)
				{
				}
				num = (short)1578172416;
				if (num != 0)
				{
				}
				this.trkSysSiteAliasHomeRASWACNNumber_A20169.Max = value;
			}
		}

		// Token: 0x17000A3A RID: 2618
		// (get) Token: 0x06001452 RID: 5202 RVA: 0x00130B1C File Offset: 0x0012ED1C
		// (set) Token: 0x06001453 RID: 5203 RVA: 0x00130BD0 File Offset: 0x0012EDD0
		internal int TrkSysSiteAliasHomeRASWACNNumber_A20169Step
		{
			get
			{
				short num = (short)278200320;
				short num2 = num;
				num = (short)825706919;
				short num3 = num;
				num = (short)413419943;
				switch (num3 == num)
				{
				}
				num = (short)1019805697;
				if (num != 0)
				{
				}
				num = (short)1740963840;
				if (num != 0)
				{
				}
				return this.trkSysSiteAliasHomeRASWACNNumber_A20169.StepSize;
			}
			set
			{
				short num = (short)2121990144;
				short num2 = num;
				num = (short)221118465;
				if (num != 0)
				{
				}
				num = (short)905304553;
				short num3 = num;
				num = (short)1425594857;
				switch (num3 == num)
				{
				}
				num = (short)1953300480;
				if (num != 0)
				{
				}
				this.trkSysSiteAliasHomeRASWACNNumber_A20169.StepSize = value;
			}
		}

		// Token: 0x17000A3B RID: 2619
		// (get) Token: 0x06001454 RID: 5204 RVA: 0x00130C84 File Offset: 0x0012EE84
		// (set) Token: 0x06001455 RID: 5205 RVA: 0x00130D38 File Offset: 0x0012EF38
		public bool TrkSysSiteAliasHomeRASWACNNumber_A20169_Applicable
		{
			get
			{
				short num = (short)126943232;
				short num2 = num;
				num = (short)680480660;
				short num3 = num;
				num = (short)1413173140;
				switch (num3 == num)
				{
				}
				num = (short)1460928513;
				if (num != 0)
				{
				}
				num = (short)1381957632;
				if (num != 0)
				{
				}
				return this.trkSysSiteAliasHomeRASWACNNumber_A20169.Applicable;
			}
			set
			{
				short num = (short)200540160;
				short num2 = num;
				num = (short)2079483224;
				short num3 = num;
				num = (short)1504077144;
				switch (num3 == num)
				{
				}
				num = (short)1395720192;
				if (num != 0)
				{
				}
				num = (short)1248460801;
				if (num != 0)
				{
				}
				this.trkSysSiteAliasHomeRASWACNNumber_A20169.Applicable = value;
			}
		}

		// Token: 0x17000A3C RID: 2620
		// (get) Token: 0x06001456 RID: 5206 RVA: 0x00130DEC File Offset: 0x0012EFEC
		// (set) Token: 0x06001457 RID: 5207 RVA: 0x00130EA0 File Offset: 0x0012F0A0
		public bool TrkSysSiteAliasHomeRASWACNNumber_A20169_Valid
		{
			get
			{
				short num = (short)957218816;
				short num2 = num;
				num = (short)1201484020;
				short num3 = num;
				num = (short)656290036;
				switch (num3 == num)
				{
				}
				num = (short)1735720960;
				if (num != 0)
				{
				}
				num = (short)175112193;
				if (num != 0)
				{
				}
				return this.trkSysSiteAliasHomeRASWACNNumber_A20169.Valid;
			}
			set
			{
				short num = (short)507772928;
				short num2 = num;
				num = (short)1746939425;
				short num3 = num;
				num = (short)1426796065;
				switch (num3 == num)
				{
				}
				num = (short)1589051393;
				if (num != 0)
				{
				}
				num = (short)1947205632;
				if (num != 0)
				{
				}
				this.trkSysSiteAliasHomeRASWACNNumber_A20169.Valid = value;
			}
		}

		// Token: 0x17000A3D RID: 2621
		// (get) Token: 0x06001458 RID: 5208 RVA: 0x00130F54 File Offset: 0x0012F154
		// (set) Token: 0x06001459 RID: 5209 RVA: 0x00131008 File Offset: 0x0012F208
		public bool TrkSysSiteAliasHomeRASWACNNumber_A20169_Visible
		{
			get
			{
				short num = (short)396820480;
				short num2 = num;
				num = (short)956525555;
				short num3 = num;
				num = (short)1523477491;
				switch (num3 == num)
				{
				}
				num = (short)641662977;
				if (num != 0)
				{
				}
				num = (short)1937244160;
				if (num != 0)
				{
				}
				return this.trkSysSiteAliasHomeRASWACNNumber_A20169.Visible;
			}
			set
			{
				short num = (short)7733248;
				short num2 = num;
				num = (short)1115821311;
				short num3 = num;
				num = (short)1801393407;
				switch (num3 == num)
				{
				}
				num = (short)572653569;
				if (num != 0)
				{
				}
				num = (short)1730740224;
				if (num != 0)
				{
				}
				this.trkSysSiteAliasHomeRASWACNNumber_A20169.Visible = value;
			}
		}

		// Token: 0x17000A3E RID: 2622
		// (get) Token: 0x0600145A RID: 5210 RVA: 0x001310BC File Offset: 0x0012F2BC
		// (set) Token: 0x0600145B RID: 5211 RVA: 0x00131170 File Offset: 0x0012F370
		public bool TrkSysSiteAliasHomeRASWACNNumber_A20169_Editable
		{
			get
			{
				short num = (short)1891565568;
				short num2 = num;
				num = (short)513562584;
				short num3 = num;
				num = (short)432756696;
				switch (num3 == num)
				{
				}
				num = (short)1820852225;
				if (num != 0)
				{
				}
				num = (short)1212678144;
				if (num != 0)
				{
				}
				return this.trkSysSiteAliasHomeRASWACNNumber_A20169.Editable;
			}
			set
			{
				short num = (short)14090240;
				short num2 = num;
				num = (short)1947385980;
				short num3 = num;
				num = (short)930594940;
				switch (num3 == num)
				{
				}
				num = (short)361758720;
				if (num != 0)
				{
				}
				num = (short)1313341441;
				if (num != 0)
				{
				}
				this.trkSysSiteAliasHomeRASWACNNumber_A20169.Editable = value;
			}
		}

		// Token: 0x17000A3F RID: 2623
		// (get) Token: 0x0600145C RID: 5212 RVA: 0x00131224 File Offset: 0x0012F424
		internal string TrkSysSiteAliasHomeRASWACNNumber_A20169_UILabel
		{
			get
			{
				short num = (short)838074368;
				short num2 = num;
				num = (short)914657730;
				short num3 = num;
				num = (short)1787793858;
				switch (num3 == num)
				{
				}
				num = (short)1891368961;
				if (num != 0)
				{
				}
				num = (short)622395392;
				if (num != 0)
				{
				}
				return this.trkSysSiteAliasHomeRASWACNNumber_A20169.UIName;
			}
		}

		// Token: 0x17000A40 RID: 2624
		// (get) Token: 0x0600145D RID: 5213 RVA: 0x001312D8 File Offset: 0x0012F4D8
		// (set) Token: 0x0600145E RID: 5214 RVA: 0x0013138C File Offset: 0x0012F58C
		internal bool TrkSysSiteAliasHomeRASWACNNumber_A20169_HiddenStatic
		{
			get
			{
				short num = (short)263782400;
				short num2 = num;
				num = (short)922073306;
				short num3 = num;
				num = (short)129284314;
				switch (num3 == num)
				{
				}
				num = (short)443547648;
				if (num != 0)
				{
				}
				num = (short)413270017;
				if (num != 0)
				{
				}
				return this.trkSysSiteAliasHomeRASWACNNumber_A20169.HiddenStatic;
			}
			set
			{
				short num = (short)1366360064;
				short num2 = num;
				num = (short)1758967728;
				short num3 = num;
				num = (short)1110685616;
				switch (num3 == num)
				{
				}
				num = (short)772538369;
				if (num != 0)
				{
				}
				num = (short)1014628352;
				if (num != 0)
				{
				}
				this.trkSysSiteAliasHomeRASWACNNumber_A20169.HiddenStatic = value;
			}
		}

		// Token: 0x17000A41 RID: 2625
		// (get) Token: 0x0600145F RID: 5215 RVA: 0x00131440 File Offset: 0x0012F640
		// (set) Token: 0x06001460 RID: 5216 RVA: 0x001314F4 File Offset: 0x0012F6F4
		internal bool TrkSysSiteAliasHomeRASWACNNumber_A20169_HiddenDynamic
		{
			get
			{
				short num = (short)1579024384;
				short num2 = num;
				num = (short)787335390;
				short num3 = num;
				num = (short)762628318;
				switch (num3 == num)
				{
				}
				num = (short)1931739137;
				if (num != 0)
				{
				}
				num = (short)1860632576;
				if (num != 0)
				{
				}
				return this.trkSysSiteAliasHomeRASWACNNumber_A20169.HiddenDynamic;
			}
			set
			{
				short num = (short)1344798720;
				short num2 = num;
				num = (short)676275129;
				short num3 = num;
				num = (short)1950557113;
				switch (num3 == num)
				{
				}
				num = (short)1888944129;
				if (num != 0)
				{
				}
				num = (short)428015616;
				if (num != 0)
				{
				}
				this.trkSysSiteAliasHomeRASWACNNumber_A20169.HiddenDynamic = value;
			}
		}

		// Token: 0x17000A42 RID: 2626
		// (get) Token: 0x06001461 RID: 5217 RVA: 0x001315A8 File Offset: 0x0012F7A8
		public bool TrkSysSiteAliasHomeRASWACNNumber_A20169_HasDiffs
		{
			get
			{
				short num = (short)1437335552;
				short num2 = num;
				num = (short)1808288768;
				short num3 = num;
				num = (short)2135772160;
				switch (num3 == num)
				{
				}
				num = (short)705036288;
				if (num != 0)
				{
				}
				num = (short)1551302657;
				if (num != 0)
				{
				}
				return this.trkSysSiteAliasHomeRASWACNNumber_A20169._HasDiffs;
			}
		}

		// Token: 0x17000A43 RID: 2627
		// (get) Token: 0x06001462 RID: 5218 RVA: 0x0013165C File Offset: 0x0012F85C
		// (set) Token: 0x06001463 RID: 5219 RVA: 0x00131714 File Offset: 0x0012F914
		public string TrkSysSiteAlias_A24071Value
		{
			get
			{
				short num = (short)521076736;
				short num2 = num;
				num = (short)1841880016;
				short num3 = num;
				num = (short)1376181200;
				switch (num3 == num)
				{
				}
				num = (short)460652545;
				if (num != 0)
				{
				}
				num = (short)1900871680;
				if (num != 0)
				{
				}
				return this.trkSysSiteAlias_A24071.Value;
			}
			set
			{
				short num = (short)643170305;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_EE;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_30;
						}
						continue;
					case 2:
						this.trkSysSiteAlias_A24071.Value = value;
						num = (short)1239941120;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_30:
					num = (short)1951815341;
					short num3 = num;
					num = (short)1622890157;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
					{
						num = (short)1931083776;
						short num4 = num;
						num = (short)650444800;
						if (num != 0)
						{
						}
						if (string.IsNullOrEmpty(value.Trim()))
						{
							return;
						}
						num = (short)935002114;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					}
				}
				IL_EE:
				num = (short)299630593;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x17000A44 RID: 2628
		// (get) Token: 0x06001464 RID: 5220 RVA: 0x00131838 File Offset: 0x0012FA38
		// (set) Token: 0x06001465 RID: 5221 RVA: 0x001318EC File Offset: 0x0012FAEC
		public string TrkSysSiteAlias_A24071_UIValue
		{
			get
			{
				short num = (short)353894400;
				short num2 = num;
				num = (short)150094464;
				short num3 = num;
				num = (short)1434862208;
				switch (num3 == num)
				{
				}
				num = (short)1165688833;
				if (num != 0)
				{
				}
				num = (short)1868759040;
				if (num != 0)
				{
				}
				return this.trkSysSiteAlias_A24071.Value;
			}
			set
			{
				short num = (short)2014380032;
				short num2 = num;
				num = (short)133733338;
				short num3 = num;
				num = (short)1162779610;
				switch (num3 == num)
				{
				}
				num = (short)74645505;
				if (num != 0)
				{
				}
				num = (short)133300224;
				if (num != 0)
				{
				}
				this.trkSysSiteAlias_A24071.Value = value;
			}
		}

		// Token: 0x17000A45 RID: 2629
		// (get) Token: 0x06001466 RID: 5222 RVA: 0x001319A0 File Offset: 0x0012FBA0
		public global::AcpBusinessLayer.AcpKeyField TrkSysSiteAlias_A24071
		{
			get
			{
				short num = (short)444923904;
				short num2 = num;
				num = (short)1317813137;
				short num3 = num;
				num = (short)310459281;
				switch (num3 == num)
				{
				}
				num = (short)1308229633;
				if (num != 0)
				{
				}
				num = (short)550961152;
				if (num != 0)
				{
				}
				return this.trkSysSiteAlias_A24071;
			}
		}

		// Token: 0x17000A46 RID: 2630
		// (get) Token: 0x06001467 RID: 5223 RVA: 0x00131A4C File Offset: 0x0012FC4C
		// (set) Token: 0x06001468 RID: 5224 RVA: 0x00131AFC File Offset: 0x0012FCFC
		public bool TrkSysSiteAlias_A24071_Applicable
		{
			get
			{
				short num = (short)1808531456;
				short num2 = num;
				num = (short)1282618044;
				short num3 = num;
				num = (short)1574122172;
				switch (num3 == num)
				{
				}
				num = (short)1576468481;
				if (num != 0)
				{
				}
				num = (short)110297088;
				if (num != 0)
				{
				}
				return this.trkSysSiteAlias_A24071.Applicable;
			}
			set
			{
				short num = (short)2072117248;
				short num2 = num;
				num = (short)1367860686;
				short num3 = num;
				num = (short)1642522062;
				switch (num3 == num)
				{
				}
				num = (short)729743360;
				if (num != 0)
				{
				}
				num = (short)367525889;
				if (num != 0)
				{
				}
				this.trkSysSiteAlias_A24071.Applicable = value;
			}
		}

		// Token: 0x17000A47 RID: 2631
		// (get) Token: 0x06001469 RID: 5225 RVA: 0x00131BB4 File Offset: 0x0012FDB4
		// (set) Token: 0x0600146A RID: 5226 RVA: 0x00131C6C File Offset: 0x0012FE6C
		public bool TrkSysSiteAlias_A24071_Valid
		{
			get
			{
				short num = (short)804126720;
				short num2 = num;
				num = (short)769776079;
				short num3 = num;
				num = (short)2022037967;
				switch (num3 == num)
				{
				}
				num = (short)2094333953;
				if (num != 0)
				{
				}
				num = (short)1864237056;
				if (num != 0)
				{
				}
				return this.trkSysSiteAlias_A24071.Valid;
			}
			set
			{
				short num = (short)237764608;
				short num2 = num;
				num = (short)2006545472;
				short num3 = num;
				num = (short)1884386368;
				switch (num3 == num)
				{
				}
				num = (short)158728193;
				if (num != 0)
				{
				}
				num = (short)1559429120;
				if (num != 0)
				{
				}
				this.trkSysSiteAlias_A24071.Valid = value;
			}
		}

		// Token: 0x17000A48 RID: 2632
		// (get) Token: 0x0600146B RID: 5227 RVA: 0x00131D24 File Offset: 0x0012FF24
		// (set) Token: 0x0600146C RID: 5228 RVA: 0x00131DD8 File Offset: 0x0012FFD8
		public bool TrkSysSiteAlias_A24071_Visible
		{
			get
			{
				short num = (short)558301184;
				short num2 = num;
				num = (short)766711964;
				short num3 = num;
				num = (short)2110920860;
				switch (num3 == num)
				{
				}
				num = (short)1893728256;
				if (num != 0)
				{
				}
				num = (short)8585217;
				if (num != 0)
				{
				}
				return this.trkSysSiteAlias_A24071.Visible;
			}
			set
			{
				short num = (short)557121536;
				short num2 = num;
				num = (short)760943893;
				short num3 = num;
				num = (short)660411669;
				switch (num3 == num)
				{
				}
				num = (short)1155465217;
				if (num != 0)
				{
				}
				num = (short)1343160320;
				if (num != 0)
				{
				}
				this.trkSysSiteAlias_A24071.Visible = value;
			}
		}

		// Token: 0x17000A49 RID: 2633
		// (get) Token: 0x0600146D RID: 5229 RVA: 0x00131E90 File Offset: 0x00130090
		// (set) Token: 0x0600146E RID: 5230 RVA: 0x00131F44 File Offset: 0x00130144
		public bool TrkSysSiteAlias_A24071_Editable
		{
			get
			{
				short num = (short)1031471104;
				short num2 = num;
				num = (short)53521143;
				short num3 = num;
				num = (short)635087607;
				switch (num3 == num)
				{
				}
				num = (short)289406977;
				if (num != 0)
				{
				}
				num = (short)54657024;
				if (num != 0)
				{
				}
				return this.trkSysSiteAlias_A24071.Editable;
			}
			set
			{
				short num = (short)2111635456;
				short num2 = num;
				num = (short)1303948338;
				short num3 = num;
				num = (short)1771547698;
				switch (num3 == num)
				{
				}
				num = (short)831782912;
				if (num != 0)
				{
				}
				num = (short)1042153473;
				if (num != 0)
				{
				}
				this.trkSysSiteAlias_A24071.Editable = value;
			}
		}

		// Token: 0x17000A4A RID: 2634
		// (get) Token: 0x0600146F RID: 5231 RVA: 0x00131FFC File Offset: 0x001301FC
		internal string TrkSysSiteAlias_A24071_UILabel
		{
			get
			{
				short num = (short)658112512;
				short num2 = num;
				num = (short)989243786;
				short num3 = num;
				num = (short)789948810;
				switch (num3 == num)
				{
				}
				num = (short)1197735937;
				if (num != 0)
				{
				}
				num = (short)1436680192;
				if (num != 0)
				{
				}
				return this.trkSysSiteAlias_A24071.UIName;
			}
		}

		// Token: 0x17000A4B RID: 2635
		// (get) Token: 0x06001470 RID: 5232 RVA: 0x001320B0 File Offset: 0x001302B0
		// (set) Token: 0x06001471 RID: 5233 RVA: 0x00132164 File Offset: 0x00130364
		internal bool TrkSysSiteAlias_A24071_HiddenStatic
		{
			get
			{
				short num = (short)501809152;
				short num2 = num;
				num = (short)587569273;
				short num3 = num;
				num = (short)1097308281;
				switch (num3 == num)
				{
				}
				num = (short)652607489;
				if (num != 0)
				{
				}
				num = (short)420282368;
				if (num != 0)
				{
				}
				return this.trkSysSiteAlias_A24071.HiddenStatic;
			}
			set
			{
				short num = (short)997261312;
				short num2 = num;
				num = (short)1558424313;
				short num3 = num;
				num = (short)568057;
				switch (num3 == num)
				{
				}
				num = (short)372965376;
				if (num != 0)
				{
				}
				num = (short)1056374785;
				if (num != 0)
				{
				}
				this.trkSysSiteAlias_A24071.HiddenStatic = value;
			}
		}

		// Token: 0x17000A4C RID: 2636
		// (get) Token: 0x06001472 RID: 5234 RVA: 0x00132218 File Offset: 0x00130418
		// (set) Token: 0x06001473 RID: 5235 RVA: 0x001322CC File Offset: 0x001304CC
		internal bool TrkSysSiteAlias_A24071_HiddenDynamic
		{
			get
			{
				short num = (short)848560128;
				short num2 = num;
				num = (short)367013225;
				short num3 = num;
				num = (short)1497705833;
				switch (num3 == num)
				{
				}
				num = (short)615383041;
				if (num != 0)
				{
				}
				num = (short)792461312;
				if (num != 0)
				{
				}
				return this.trkSysSiteAlias_A24071.HiddenDynamic;
			}
			set
			{
				short num = (short)1132593152;
				short num2 = num;
				num = (short)54495885;
				short num3 = num;
				num = (short)2079689357;
				switch (num3 == num)
				{
				}
				num = (short)1005518849;
				if (num != 0)
				{
				}
				num = (short)1473380352;
				if (num != 0)
				{
				}
				this.trkSysSiteAlias_A24071.HiddenDynamic = value;
			}
		}

		// Token: 0x17000A4D RID: 2637
		// (get) Token: 0x06001474 RID: 5236 RVA: 0x00132384 File Offset: 0x00130584
		public bool TrkSysSiteAlias_A24071_HasDiffs
		{
			get
			{
				short num = (short)282198016;
				short num2 = num;
				num = (short)581017749;
				short num3 = num;
				num = (short)1305059477;
				switch (num3 == num)
				{
				}
				num = (short)1940652033;
				if (num != 0)
				{
				}
				num = (short)939655168;
				if (num != 0)
				{
				}
				return this.trkSysSiteAlias_A24071._HasDiffs;
			}
		}

		// Token: 0x17000A4E RID: 2638
		// (get) Token: 0x06001475 RID: 5237 RVA: 0x00132438 File Offset: 0x00130638
		// (set) Token: 0x06001476 RID: 5238 RVA: 0x001324EC File Offset: 0x001306EC
		public int TrkSysSiteAliasRFSSAliasNumber_A8978Value
		{
			get
			{
				short num = (short)26345472;
				short num2 = num;
				num = (short)354180067;
				short num3 = num;
				num = (short)85810147;
				switch (num3 == num)
				{
				}
				num = (short)1805844481;
				if (num != 0)
				{
				}
				num = (short)1239285760;
				if (num != 0)
				{
				}
				return this.trkSysSiteAliasRFSSAliasNumber_A8978.Value;
			}
			set
			{
				short num = (short)234291200;
				short num2 = num;
				num = (short)1511387759;
				short num3 = num;
				num = (short)69071471;
				switch (num3 == num)
				{
				}
				num = (short)101187584;
				if (num != 0)
				{
				}
				num = (short)601161729;
				if (num != 0)
				{
				}
				this.trkSysSiteAliasRFSSAliasNumber_A8978.Value = value;
			}
		}

		// Token: 0x17000A4F RID: 2639
		// (get) Token: 0x06001477 RID: 5239 RVA: 0x001325A4 File Offset: 0x001307A4
		public global::AcpBusinessLayer.AcpSimpleRangeField TrkSysSiteAliasRFSSAliasNumber_A8978
		{
			get
			{
				short num = (short)688259072;
				short num2 = num;
				num = (short)1770096040;
				short num3 = num;
				num = (short)1053394344;
				switch (num3 == num)
				{
				}
				num = (short)1855586305;
				if (num != 0)
				{
				}
				num = (short)1598226432;
				if (num != 0)
				{
				}
				return this.trkSysSiteAliasRFSSAliasNumber_A8978;
			}
		}

		// Token: 0x17000A50 RID: 2640
		// (get) Token: 0x06001478 RID: 5240 RVA: 0x00132654 File Offset: 0x00130854
		// (set) Token: 0x06001479 RID: 5241 RVA: 0x0013270C File Offset: 0x0013090C
		public string TrkSysSiteAliasRFSSAliasNumber_A8978_UIValue
		{
			get
			{
				short num = (short)1228406784;
				short num2 = num;
				num = (short)2110237996;
				short num3 = num;
				num = (short)1053994284;
				switch (num3 == num)
				{
				}
				num = (short)323223553;
				if (num != 0)
				{
				}
				num = (short)2117992448;
				if (num != 0)
				{
				}
				return this.trkSysSiteAliasRFSSAliasNumber_A8978.UIValue;
			}
			set
			{
				short num = (short)2116616192;
				short num2 = num;
				num = (short)1126694913;
				if (num != 0)
				{
				}
				num = (short)986349047;
				short num3 = num;
				num = (short)825851383;
				switch (num3 == num)
				{
				}
				num = (short)806158336;
				if (num != 0)
				{
				}
				this.trkSysSiteAliasRFSSAliasNumber_A8978.UIValue = value;
			}
		}

		// Token: 0x17000A51 RID: 2641
		// (get) Token: 0x0600147A RID: 5242 RVA: 0x001327C0 File Offset: 0x001309C0
		// (set) Token: 0x0600147B RID: 5243 RVA: 0x00132874 File Offset: 0x00130A74
		internal int TrkSysSiteAliasRFSSAliasNumber_A8978Min
		{
			get
			{
				short num = (short)981073920;
				short num2 = num;
				num = (short)1698101574;
				short num3 = num;
				num = (short)1801124166;
				switch (num3 == num)
				{
				}
				num = (short)2039152641;
				if (num != 0)
				{
				}
				num = (short)1990197248;
				if (num != 0)
				{
				}
				return this.trkSysSiteAliasRFSSAliasNumber_A8978.Min;
			}
			set
			{
				short num = (short)73269248;
				short num2 = num;
				num = (short)1178337281;
				if (num != 0)
				{
				}
				num = (short)968772474;
				short num3 = num;
				num = (short)363219834;
				switch (num3 == num)
				{
				}
				num = (short)437256192;
				if (num != 0)
				{
				}
				this.trkSysSiteAliasRFSSAliasNumber_A8978.Min = value;
			}
		}

		// Token: 0x17000A52 RID: 2642
		// (get) Token: 0x0600147C RID: 5244 RVA: 0x0013292C File Offset: 0x00130B2C
		// (set) Token: 0x0600147D RID: 5245 RVA: 0x001329E0 File Offset: 0x00130BE0
		internal int TrkSysSiteAliasRFSSAliasNumber_A8978Max
		{
			get
			{
				short num = (short)1434976256;
				short num2 = num;
				num = (short)70813858;
				short num3 = num;
				num = (short)2132707490;
				switch (num3 == num)
				{
				}
				num = (short)104595456;
				if (num != 0)
				{
				}
				num = (short)1676673025;
				if (num != 0)
				{
				}
				return this.trkSysSiteAliasRFSSAliasNumber_A8978.Max;
			}
			set
			{
				short num = (short)1398079488;
				short num2 = num;
				num = (short)1556378608;
				short num3 = num;
				num = (short)617378800;
				switch (num3 == num)
				{
				}
				num = (short)1472069633;
				if (num != 0)
				{
				}
				num = (short)1376124928;
				if (num != 0)
				{
				}
				this.trkSysSiteAliasRFSSAliasNumber_A8978.Max = value;
			}
		}

		// Token: 0x17000A53 RID: 2643
		// (get) Token: 0x0600147E RID: 5246 RVA: 0x00132A94 File Offset: 0x00130C94
		// (set) Token: 0x0600147F RID: 5247 RVA: 0x00132B4C File Offset: 0x00130D4C
		internal int TrkSysSiteAliasRFSSAliasNumber_A8978Step
		{
			get
			{
				short num = (short)861011968;
				short num2 = num;
				num = (short)1393307808;
				short num3 = num;
				num = (short)1002451104;
				switch (num3 == num)
				{
				}
				num = (short)2096693249;
				if (num != 0)
				{
				}
				num = (short)612433920;
				if (num != 0)
				{
				}
				return this.trkSysSiteAliasRFSSAliasNumber_A8978.StepSize;
			}
			set
			{
				short num = (short)1390280704;
				short num2 = num;
				num = (short)684863342;
				short num3 = num;
				num = (short)745877358;
				switch (num3 == num)
				{
				}
				num = (short)1923940352;
				if (num != 0)
				{
				}
				num = (short)736559105;
				if (num != 0)
				{
				}
				this.trkSysSiteAliasRFSSAliasNumber_A8978.StepSize = value;
			}
		}

		// Token: 0x17000A54 RID: 2644
		// (get) Token: 0x06001480 RID: 5248 RVA: 0x00132C00 File Offset: 0x00130E00
		// (set) Token: 0x06001481 RID: 5249 RVA: 0x00132CB8 File Offset: 0x00130EB8
		public bool TrkSysSiteAliasRFSSAliasNumber_A8978_Applicable
		{
			get
			{
				short num = (short)245694464;
				short num2 = num;
				num = (short)1511515570;
				short num3 = num;
				num = (short)896001458;
				switch (num3 == num)
				{
				}
				num = (short)488177664;
				if (num != 0)
				{
				}
				num = (short)258539521;
				if (num != 0)
				{
				}
				return this.trkSysSiteAliasRFSSAliasNumber_A8978.Applicable;
			}
			set
			{
				short num = (short)785973248;
				short num2 = num;
				num = (short)351594764;
				short num3 = num;
				num = (short)487975180;
				switch (num3 == num)
				{
				}
				num = (short)1230635008;
				if (num != 0)
				{
				}
				num = (short)1748369409;
				if (num != 0)
				{
				}
				this.trkSysSiteAliasRFSSAliasNumber_A8978.Applicable = value;
			}
		}

		// Token: 0x17000A55 RID: 2645
		// (get) Token: 0x06001482 RID: 5250 RVA: 0x00132D6C File Offset: 0x00130F6C
		// (set) Token: 0x06001483 RID: 5251 RVA: 0x00132E28 File Offset: 0x00131028
		public bool TrkSysSiteAliasRFSSAliasNumber_A8978_Valid
		{
			get
			{
				short num = (short)353632256;
				short num2 = num;
				num = (short)1096216415;
				short num3 = num;
				num = (short)1818488671;
				switch (num3 == num)
				{
				}
				num = (short)2079391745;
				if (num != 0)
				{
				}
				num = (short)878182400;
				if (num != 0)
				{
				}
				return this.trkSysSiteAliasRFSSAliasNumber_A8978.Valid;
			}
			set
			{
				short num = (short)595394560;
				short num2 = num;
				num = (short)619578961;
				short num3 = num;
				num = (short)820512337;
				switch (num3 == num)
				{
				}
				num = (short)2005532672;
				if (num != 0)
				{
				}
				num = (short)809369601;
				if (num != 0)
				{
				}
				this.trkSysSiteAliasRFSSAliasNumber_A8978.Valid = value;
			}
		}

		// Token: 0x17000A56 RID: 2646
		// (get) Token: 0x06001484 RID: 5252 RVA: 0x00132EE0 File Offset: 0x001310E0
		// (set) Token: 0x06001485 RID: 5253 RVA: 0x00132F94 File Offset: 0x00131194
		public bool TrkSysSiteAliasRFSSAliasNumber_A8978_Visible
		{
			get
			{
				short num = (short)80805888;
				short num2 = num;
				num = (short)191344326;
				short num3 = num;
				num = (short)1409003206;
				switch (num3 == num)
				{
				}
				num = (short)1988558849;
				if (num != 0)
				{
				}
				num = (short)1675821056;
				if (num != 0)
				{
				}
				return this.trkSysSiteAliasRFSSAliasNumber_A8978.Visible;
			}
			set
			{
				short num = (short)259457024;
				short num2 = num;
				num = (short)1403943842;
				short num3 = num;
				num = (short)601455522;
				switch (num3 == num)
				{
				}
				num = (short)484114432;
				if (num != 0)
				{
				}
				num = (short)380698625;
				if (num != 0)
				{
				}
				this.trkSysSiteAliasRFSSAliasNumber_A8978.Visible = value;
			}
		}

		// Token: 0x17000A57 RID: 2647
		// (get) Token: 0x06001486 RID: 5254 RVA: 0x0013304C File Offset: 0x0013124C
		// (set) Token: 0x06001487 RID: 5255 RVA: 0x00133100 File Offset: 0x00131300
		public bool TrkSysSiteAliasRFSSAliasNumber_A8978_Editable
		{
			get
			{
				short num = (short)219348992;
				short num2 = num;
				num = (short)1029632317;
				short num3 = num;
				num = (short)2105274685;
				switch (num3 == num)
				{
				}
				num = (short)1734541312;
				if (num != 0)
				{
				}
				num = (short)1753808897;
				if (num != 0)
				{
				}
				return this.trkSysSiteAliasRFSSAliasNumber_A8978.Editable;
			}
			set
			{
				short num = (short)871235584;
				short num2 = num;
				num = (short)1960146240;
				short num3 = num;
				num = (short)1274901824;
				switch (num3 == num)
				{
				}
				num = (short)646512641;
				if (num != 0)
				{
				}
				num = (short)134348800;
				if (num != 0)
				{
				}
				this.trkSysSiteAliasRFSSAliasNumber_A8978.Editable = value;
			}
		}

		// Token: 0x17000A58 RID: 2648
		// (get) Token: 0x06001488 RID: 5256 RVA: 0x001331B8 File Offset: 0x001313B8
		internal string TrkSysSiteAliasRFSSAliasNumber_A8978_UILabel
		{
			get
			{
				short num = (short)1850146816;
				short num2 = num;
				num = (short)690794650;
				short num3 = num;
				num = (short)400076954;
				switch (num3 == num)
				{
				}
				num = (short)980811776;
				if (num != 0)
				{
				}
				num = (short)1008664577;
				if (num != 0)
				{
				}
				return this.trkSysSiteAliasRFSSAliasNumber_A8978.UIName;
			}
		}

		// Token: 0x17000A59 RID: 2649
		// (get) Token: 0x06001489 RID: 5257 RVA: 0x0013326C File Offset: 0x0013146C
		// (set) Token: 0x0600148A RID: 5258 RVA: 0x00133320 File Offset: 0x00131520
		internal bool TrkSysSiteAliasRFSSAliasNumber_A8978_HiddenStatic
		{
			get
			{
				short num = (short)346685440;
				short num2 = num;
				num = (short)1775113963;
				short num3 = num;
				num = (short)943265515;
				switch (num3 == num)
				{
				}
				num = (short)621346817;
				if (num != 0)
				{
				}
				num = (short)1004535808;
				if (num != 0)
				{
				}
				return this.trkSysSiteAliasRFSSAliasNumber_A8978.HiddenStatic;
			}
			set
			{
				short num = (short)1405222912;
				short num2 = num;
				num = (short)1218901018;
				short num3 = num;
				num = (short)2023617562;
				switch (num3 == num)
				{
				}
				num = (short)2051997697;
				if (num != 0)
				{
				}
				num = (short)1035468800;
				if (num != 0)
				{
				}
				this.trkSysSiteAliasRFSSAliasNumber_A8978.HiddenStatic = value;
			}
		}

		// Token: 0x17000A5A RID: 2650
		// (get) Token: 0x0600148B RID: 5259 RVA: 0x001333D8 File Offset: 0x001315D8
		// (set) Token: 0x0600148C RID: 5260 RVA: 0x00133490 File Offset: 0x00131690
		internal bool TrkSysSiteAliasRFSSAliasNumber_A8978_HiddenDynamic
		{
			get
			{
				short num = (short)1608318976;
				short num2 = num;
				num = (short)2062382532;
				short num3 = num;
				num = (short)693466564;
				switch (num3 == num)
				{
				}
				num = (short)1264386049;
				if (num != 0)
				{
				}
				num = (short)776732672;
				if (num != 0)
				{
				}
				return this.trkSysSiteAliasRFSSAliasNumber_A8978.HiddenDynamic;
			}
			set
			{
				short num = (short)1063649280;
				short num2 = num;
				num = (short)538636567;
				short num3 = num;
				num = (short)1005515031;
				switch (num3 == num)
				{
				}
				num = (short)531103745;
				if (num != 0)
				{
				}
				num = (short)1230569472;
				if (num != 0)
				{
				}
				this.trkSysSiteAliasRFSSAliasNumber_A8978.HiddenDynamic = value;
			}
		}

		// Token: 0x17000A5B RID: 2651
		// (get) Token: 0x0600148D RID: 5261 RVA: 0x00133548 File Offset: 0x00131748
		public bool TrkSysSiteAliasRFSSAliasNumber_A8978_HasDiffs
		{
			get
			{
				short num = (short)1290469376;
				short num2 = num;
				num = (short)929765463;
				short num3 = num;
				num = (short)1321277527;
				switch (num3 == num)
				{
				}
				num = (short)581959680;
				if (num != 0)
				{
				}
				num = (short)1171128321;
				if (num != 0)
				{
				}
				return this.trkSysSiteAliasRFSSAliasNumber_A8978._HasDiffs;
			}
		}

		// Token: 0x17000A5C RID: 2652
		// (get) Token: 0x0600148E RID: 5262 RVA: 0x00133600 File Offset: 0x00131800
		// (set) Token: 0x0600148F RID: 5263 RVA: 0x001336B0 File Offset: 0x001318B0
		public int TrkSysSiteAliasSiteAliasType_A41343Value
		{
			get
			{
				short num = (short)78446592;
				short num2 = num;
				num = (short)511514891;
				short num3 = num;
				num = (short)1709971723;
				switch (num3 == num)
				{
				}
				num = (short)576061440;
				if (num != 0)
				{
				}
				num = (short)1104281601;
				if (num != 0)
				{
				}
				return this.trkSysSiteAliasSiteAliasType_A41343.Value;
			}
			set
			{
				short num = (short)397803520;
				short num2 = num;
				num = (short)1142030337;
				if (num != 0)
				{
				}
				num = (short)302825724;
				short num3 = num;
				num = (short)1925562620;
				switch (num3 == num)
				{
				}
				num = (short)1217069056;
				if (num != 0)
				{
				}
				this.trkSysSiteAliasSiteAliasType_A41343.Value = value;
			}
		}

		// Token: 0x17000A5D RID: 2653
		// (get) Token: 0x06001490 RID: 5264 RVA: 0x00133764 File Offset: 0x00131964
		// (set) Token: 0x06001491 RID: 5265 RVA: 0x00133818 File Offset: 0x00131A18
		public string TrkSysSiteAliasSiteAliasType_A41343_UIValue
		{
			get
			{
				short num = (short)168558592;
				short num2 = num;
				num = (short)1528916173;
				short num3 = num;
				num = (short)108488909;
				switch (num3 == num)
				{
				}
				num = (short)1698758656;
				if (num != 0)
				{
				}
				num = (short)2102198273;
				if (num != 0)
				{
				}
				return this.trkSysSiteAliasSiteAliasType_A41343.UIValue;
			}
			set
			{
				short num = (short)52953088;
				short num2 = num;
				num = (short)289123917;
				short num3 = num;
				num = (short)1453436493;
				switch (num3 == num)
				{
				}
				num = (short)1547304961;
				if (num != 0)
				{
				}
				num = (short)519897088;
				if (num != 0)
				{
				}
				this.trkSysSiteAliasSiteAliasType_A41343.UIValue = value;
			}
		}

		// Token: 0x17000A5E RID: 2654
		// (get) Token: 0x06001492 RID: 5266 RVA: 0x001338CC File Offset: 0x00131ACC
		public global::AcpBusinessLayer.AcpListField TrkSysSiteAliasSiteAliasType_A41343
		{
			get
			{
				short num = (short)184352768;
				short num2 = num;
				num = (short)865216515;
				short num3 = num;
				num = (short)466888707;
				switch (num3 == num)
				{
				}
				num = (short)188481537;
				if (num != 0)
				{
				}
				num = (short)686161920;
				if (num != 0)
				{
				}
				return this.trkSysSiteAliasSiteAliasType_A41343;
			}
		}

		// Token: 0x17000A5F RID: 2655
		// (get) Token: 0x06001493 RID: 5267 RVA: 0x0013397C File Offset: 0x00131B7C
		// (set) Token: 0x06001494 RID: 5268 RVA: 0x00133A34 File Offset: 0x00131C34
		public bool TrkSysSiteAliasSiteAliasType_A41343_Applicable
		{
			get
			{
				short num = (short)2104229888;
				short num2 = num;
				num = (short)2038556360;
				short num3 = num;
				num = (short)1858266824;
				switch (num3 == num)
				{
				}
				num = (short)99418112;
				if (num != 0)
				{
				}
				num = (short)1477771265;
				if (num != 0)
				{
				}
				return this.trkSysSiteAliasSiteAliasType_A41343.Applicable;
			}
			set
			{
				short num = (short)902234112;
				short num2 = num;
				num = (short)1821870961;
				short num3 = num;
				num = (short)1071876977;
				switch (num3 == num)
				{
				}
				num = (short)167313409;
				if (num != 0)
				{
				}
				num = (short)382205952;
				if (num != 0)
				{
				}
				this.trkSysSiteAliasSiteAliasType_A41343.Applicable = value;
			}
		}

		// Token: 0x17000A60 RID: 2656
		// (get) Token: 0x06001495 RID: 5269 RVA: 0x00133AE8 File Offset: 0x00131CE8
		// (set) Token: 0x06001496 RID: 5270 RVA: 0x00133B9C File Offset: 0x00131D9C
		public bool TrkSysSiteAliasSiteAliasType_A41343_Valid
		{
			get
			{
				short num = (short)65077248;
				short num2 = num;
				num = (short)1189871617;
				if (num != 0)
				{
				}
				num = (short)2145070371;
				short num3 = num;
				num = (short)82652451;
				switch (num3 == num)
				{
				}
				num = (short)1151270912;
				if (num != 0)
				{
				}
				return this.trkSysSiteAliasSiteAliasType_A41343.Valid;
			}
			set
			{
				short num = (short)1674772480;
				short num2 = num;
				num = (short)807807048;
				short num3 = num;
				num = (short)521480264;
				switch (num3 == num)
				{
				}
				num = (short)99090432;
				if (num != 0)
				{
				}
				num = (short)207552513;
				if (num != 0)
				{
				}
				this.trkSysSiteAliasSiteAliasType_A41343.Valid = value;
			}
		}

		// Token: 0x17000A61 RID: 2657
		// (get) Token: 0x06001497 RID: 5271 RVA: 0x00133C50 File Offset: 0x00131E50
		// (set) Token: 0x06001498 RID: 5272 RVA: 0x00133D04 File Offset: 0x00131F04
		public bool TrkSysSiteAliasSiteAliasType_A41343_Visible
		{
			get
			{
				short num = (short)124583936;
				short num2 = num;
				num = (short)345047041;
				if (num != 0)
				{
				}
				num = (short)94750678;
				short num3 = num;
				num = (short)654952406;
				switch (num3 == num)
				{
				}
				num = (short)890568704;
				if (num != 0)
				{
				}
				return this.trkSysSiteAliasSiteAliasType_A41343.Visible;
			}
			set
			{
				short num = (short)2080505856;
				short num2 = num;
				num = (short)1167743377;
				short num3 = num;
				num = (short)1871206801;
				switch (num3 == num)
				{
				}
				num = (short)1911029760;
				if (num != 0)
				{
				}
				num = (short)1492451329;
				if (num != 0)
				{
				}
				this.trkSysSiteAliasSiteAliasType_A41343.Visible = value;
			}
		}

		// Token: 0x17000A62 RID: 2658
		// (get) Token: 0x06001499 RID: 5273 RVA: 0x00133DB8 File Offset: 0x00131FB8
		// (set) Token: 0x0600149A RID: 5274 RVA: 0x00133E6C File Offset: 0x0013206C
		public bool TrkSysSiteAliasSiteAliasType_A41343_Editable
		{
			get
			{
				short num = (short)829947904;
				short num2 = num;
				num = (short)469784103;
				short num3 = num;
				num = (short)1533236775;
				switch (num3 == num)
				{
				}
				num = (short)764411905;
				if (num != 0)
				{
				}
				num = (short)441712640;
				if (num != 0)
				{
				}
				return this.trkSysSiteAliasSiteAliasType_A41343.Editable;
			}
			set
			{
				short num = (short)247595008;
				short num2 = num;
				num = (short)605006208;
				short num3 = num;
				num = (short)923642240;
				switch (num3 == num)
				{
				}
				num = (short)1459421185;
				if (num != 0)
				{
				}
				num = (short)1064566784;
				if (num != 0)
				{
				}
				this.trkSysSiteAliasSiteAliasType_A41343.Editable = value;
			}
		}

		// Token: 0x17000A63 RID: 2659
		// (get) Token: 0x0600149B RID: 5275 RVA: 0x00133F24 File Offset: 0x00132124
		internal string TrkSysSiteAliasSiteAliasType_A41343_UILabel
		{
			get
			{
				short num = (short)921305088;
				short num2 = num;
				num = (short)2011350153;
				short num3 = num;
				num = (short)1276429449;
				switch (num3 == num)
				{
				}
				num = (short)1197998081;
				if (num != 0)
				{
				}
				num = (short)1197670400;
				if (num != 0)
				{
				}
				return this.trkSysSiteAliasSiteAliasType_A41343.UIName;
			}
		}

		// Token: 0x17000A64 RID: 2660
		// (get) Token: 0x0600149C RID: 5276 RVA: 0x00133FD8 File Offset: 0x001321D8
		// (set) Token: 0x0600149D RID: 5277 RVA: 0x0013408C File Offset: 0x0013228C
		internal bool TrkSysSiteAliasSiteAliasType_A41343_HiddenStatic
		{
			get
			{
				short num = (short)1137246208;
				short num2 = num;
				num = (short)1599143937;
				if (num != 0)
				{
				}
				num = (short)126001812;
				short num3 = num;
				num = (short)1289331348;
				switch (num3 == num)
				{
				}
				num = (short)1009516544;
				if (num != 0)
				{
				}
				return this.trkSysSiteAliasSiteAliasType_A41343.HiddenStatic;
			}
			set
			{
				short num = (short)161546240;
				short num2 = num;
				num = (short)1009709078;
				short num3 = num;
				num = (short)715649046;
				switch (num3 == num)
				{
				}
				num = (short)959709185;
				if (num != 0)
				{
				}
				num = (short)1297350656;
				if (num != 0)
				{
				}
				this.trkSysSiteAliasSiteAliasType_A41343.HiddenStatic = value;
			}
		}

		// Token: 0x17000A65 RID: 2661
		// (get) Token: 0x0600149E RID: 5278 RVA: 0x00134140 File Offset: 0x00132340
		// (set) Token: 0x0600149F RID: 5279 RVA: 0x001341F4 File Offset: 0x001323F4
		internal bool TrkSysSiteAliasSiteAliasType_A41343_HiddenDynamic
		{
			get
			{
				short num = (short)481689600;
				short num2 = num;
				num = (short)961784346;
				short num3 = num;
				num = (short)741059098;
				switch (num3 == num)
				{
				}
				num = (short)1680932865;
				if (num != 0)
				{
				}
				num = (short)1595080704;
				if (num != 0)
				{
				}
				return this.trkSysSiteAliasSiteAliasType_A41343.HiddenDynamic;
			}
			set
			{
				short num = (short)1667366912;
				short num2 = num;
				num = (short)174981121;
				if (num != 0)
				{
				}
				num = (short)1698525662;
				short num3 = num;
				num = (short)784560606;
				switch (num3 == num)
				{
				}
				num = (short)1760231424;
				if (num != 0)
				{
				}
				this.trkSysSiteAliasSiteAliasType_A41343.HiddenDynamic = value;
			}
		}

		// Token: 0x17000A66 RID: 2662
		// (get) Token: 0x060014A0 RID: 5280 RVA: 0x001342A8 File Offset: 0x001324A8
		public bool TrkSysSiteAliasSiteAliasType_A41343_HasDiffs
		{
			get
			{
				short num = (short)2074476544;
				short num2 = num;
				num = (short)984066350;
				short num3 = num;
				num = (short)424913198;
				switch (num3 == num)
				{
				}
				num = (short)1953955840;
				if (num != 0)
				{
				}
				num = (short)1042153473;
				if (num != 0)
				{
				}
				return this.trkSysSiteAliasSiteAliasType_A41343._HasDiffs;
			}
		}

		// Token: 0x060014A1 RID: 5281 RVA: 0x0013435C File Offset: 0x0013255C
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			short num = (short)1574109184;
			short num2 = num;
			switch (0)
			{
			case 0:
				goto IL_4D;
			}
			int num3;
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_33:
				switch (num3)
				{
				case 0:
					if (base.ParentRecset != null)
					{
						num = (short)369491969;
						if (num != 0)
						{
						}
						num = (short)1413545986;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 1:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num = (short)993198083;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 2:
					num = (short)496762881;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
				{
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num = (short)1228752082;
					short num4 = num;
					num = (short)1777353938;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num = (short)1405550592;
						if (num != 0)
						{
						}
						num = (short)1013776388;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 4:
					return result;
				}
				goto IL_4D;
			}
			return result;
			IL_4D:
			result = null;
			num = (short)2106654720;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_33;
		}

		// Token: 0x0400046D RID: 1133
		private global::AcpBusinessLayer.AcpSimpleRangeField trkSysSiteAliasSiteAliasNumber_A9145;

		// Token: 0x0400046E RID: 1134
		private global::AcpBusinessLayer.AcpField<string> trkSysSiteAliasSiteAliasText_A9146;

		// Token: 0x0400046F RID: 1135
		private global::AcpBusinessLayer.AcpSimpleRangeField trkSysSiteAliasSystemNumber_A19669;

		// Token: 0x04000470 RID: 1136
		private global::AcpBusinessLayer.AcpSimpleRangeField trkSysSiteAliasHomeRASWACNNumber_A20169;

		// Token: 0x04000471 RID: 1137
		private global::AcpBusinessLayer.AcpKeyField trkSysSiteAlias_A24071;

		// Token: 0x04000472 RID: 1138
		private global::AcpBusinessLayer.AcpSimpleRangeField trkSysSiteAliasRFSSAliasNumber_A8978;

		// Token: 0x04000473 RID: 1139
		private global::AcpBusinessLayer.AcpListField trkSysSiteAliasSiteAliasType_A41343;
	}
}
