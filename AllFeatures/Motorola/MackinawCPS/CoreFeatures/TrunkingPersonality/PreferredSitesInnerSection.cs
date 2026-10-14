using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality
{
	// Token: 0x020000CC RID: 204
	[global::System.Serializable]
	public class PreferredSitesInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06001C18 RID: 7192 RVA: 0x001C29F8 File Offset: 0x001C0BF8
		public PreferredSitesInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06001C19 RID: 7193 RVA: 0x001C2A14 File Offset: 0x001C0C14
		protected PreferredSitesInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06001C1A RID: 7194 RVA: 0x001C2A2C File Offset: 0x001C0C2C
		public override void Init()
		{
			int a_ = 19;
			short num = (short)2019514156;
			short num2 = num;
			num = (short)1733646124;
			switch (num2 == num)
			{
			}
			num = (short)870449153;
			if (num != 0)
			{
			}
			num = (short)590020608;
			if (num != 0)
			{
			}
			num = (short)2062155776;
			short num3 = num;
			this.trkPerPreferredSitesPreferredStatus_A8734 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("胓ꓕ돗諙맛곝냟郡臣胥跧飩黫语铯ꇱ鷳苵鷷觹곻賽旿搁愃琅稇漉栋崍搏猑怓挕欗䔙崛☝ᜟᄡဣ", a_), global::CommonResources.AcgResources.ID_PREFERREDSTATUS, global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.LOVs.TrkPerPreferredSitesPreferredStatus_A8734LovStrs);
			this.trkPerPreferredSitesPreferredStatus_A8734.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkPerPreferredSitesPreferredStatus_A8734.DataTransferOrder = 41;
			this.trkPerPreferredSitesSiteID_A9151 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("胓ꓕ돗諙맛곝냟郡臣胥跧飩黫语铯ꇱ鷳苵鷷觹꿻韽瓿朁䴃䈅圇䬉㔋㼍┏⌑", a_), global::CommonResources.AcgResources.ID_SITEID, 1, 254, null, null, 0, 1);
			this.trkPerPreferredSitesSiteID_A9151.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.trkPerPreferredSitesSiteID_A9151.DataTransferOrder = 48;
			this.trkPerPreferredSitesSiteID_A9151.ShowHexValue = true;
			this.trkPerPreferredSitesSystemIDRFSSID_A9240 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("胓ꓕ돗諙맛곝냟郡臣胥跧飩黫语铯ꇱ鷳苵鷷觹꿻蟽珿瘁愃欅䄇三帋䠍䌏䄑崓刕䜗嬙┛Ⱍᐟሡ", a_), global::CommonResources.AcgResources.ID_RFSSID, 1, 254, null, null, 0, 1);
			this.trkPerPreferredSitesSystemIDRFSSID_A9240.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.trkPerPreferredSitesSystemIDRFSSID_A9240.DataTransferOrder = 43;
			this.trkPerPreferredSitesSystemIDRFSSID_A9240.ShowHexValue = true;
			this.trkPerPreferredSitesSystemID_A19466 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("胓ꓕ돗諙맛곝냟郡臣胥跧飩黫语铯ꇱ鷳苵鷷觹꿻蟽珿瘁愃欅䄇三匋伍ℏ⬑–―⸗", a_), global::CommonResources.AcgResources.ID_SYSTEMID, 0, 65534, null, null, 0, 1);
			this.trkPerPreferredSitesSystemID_A19466.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.trkPerPreferredSitesSystemID_A19466.DataTransferOrder = 23;
			this.trkPerPreferredSitesSystemID_A19466.ShowHexValue = true;
			this.trkPerPreferredSitesSystemID_A19466.ShowLeadingZeros = true;
			this.trkPerPreferredSitesRASWACNID_A20445 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("胓ꓕ돗諙맛곝냟郡臣胥跧飩黫语铯ꇱ鷳苵鷷觹껻뿽叿唁䔃䔅䘇䌉䠋儍儏‑␓∕Ⱇ⼙", a_), global::CommonResources.AcgResources.ID_RASWACNID, 0, 1048574, null, null, 0, 1);
			this.trkPerPreferredSitesRASWACNID_A20445.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.trkPerPreferredSitesRASWACNID_A20445.DataTransferOrder = 31;
			this.trkPerPreferredSitesRASWACNID_A20445.ShowHexValue = true;
			this.trkPerPreferredSitesRASWACNID_A20445.ShowLeadingZeros = true;
			this.trkPerPreferredSitesWildcard_A43586 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("胓ꓕ돗諙맛곝냟郡臣胥跧飩黫语铯ꇱ鷳苵鷷觹꯻韽泿昁會朅稇渉匋伍␏ℑℓ⸕⸗", a_), global::CommonResources.AcgResources.ID_WILDCARD, global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.LOVs.TrkPerPreferredSitesWildcard_A43586LovStrs);
			this.trkPerPreferredSitesWildcard_A43586.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.trkPerPreferredSitesWildcard_A43586.DataTransferOrder = 75;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("蓓ꓕ뷗볙맛곝鋟蟡胣웥믧菩飫语華", a_);
			base.Id = 10183;
			base.UIName = global::CommonResources.AcgResources.ID_PREFERREDSITES;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06001C1B RID: 7195 RVA: 0x001C2CE0 File Offset: 0x001C0EE0
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 3;
			short num = (short)598016013;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("郃듅ꏇ髉꧋볍胏ꃑ뇓냕뷗꣙껛믝蓟뇡跣鋥跧駩뿫韭華蛱釳鯵뇷뻹ꏻ뿽ㇿ㬁〃々㸇", a_)))
					{
						num = (short)438370319;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_AA;
				case 1:
					this.trkPerPreferredSitesWildcard_A43586 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("郃듅ꏇ髉꧋볍胏ꃑ뇓냕뷗꣙껛믝蓟뇡跣鋥跧駩믫蟭鳯雱音韵諷黹ꏻ뿽㓿㄁㄃㸅㸇", a_), global::CommonResources.AcgResources.ID_WILDCARD, global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.LOVs.TrkPerPreferredSitesWildcard_A43586LovStrs);
					this.trkPerPreferredSitesWildcard_A43586.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.trkPerPreferredSitesWildcard_A43586.DataTransferOrder = 75;
					num = (short)138608652;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("郃듅ꏇ髉꧋볍胏ꃑ뇓냕뷗꣙껛믝蓟뇡跣鋥跧駩믫蟭鳯雱音韵諷黹ꏻ뿽㓿㄁㄃㸅㸇", a_)))
					{
						num = (short)2005270529;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_585;
				case 3:
					if (producerFields != null)
					{
						num = (short)1938292754;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_585;
				case 4:
					this.trkPerPreferredSitesRASWACNID_A20445 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("郃듅ꏇ髉꧋볍胏ꃑ뇓냕뷗꣙껛믝蓟뇡跣鋥跧駩뻫꿭ꏯꗱ뗳뗵뛷돹룻ꇽ䇿、㐃㈅㰇㼉", a_), global::CommonResources.AcgResources.ID_RASWACNID, null, null, 0, 1);
					this.trkPerPreferredSitesRASWACNID_A20445.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.trkPerPreferredSitesRASWACNID_A20445.DataTransferOrder = 31;
					this.trkPerPreferredSitesRASWACNID_A20445.ShowHexValue = true;
					this.trkPerPreferredSitesRASWACNID_A20445.ShowLeadingZeros = true;
					num = (short)227999752;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_4E5;
				case 6:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("郃듅ꏇ髉꧋볍胏ꃑ뇓냕뷗꣙껛믝蓟뇡跣鋥跧駩뻫꿭ꏯꗱ뗳뗵뛷돹룻ꇽ䇿、㐃㈅㰇㼉", a_)))
					{
						num = (short)969277444;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1B8;
				case 7:
					goto IL_44F;
				case 8:
					goto IL_1B8;
				case 9:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("郃듅ꏇ髉꧋볍胏ꃑ뇓냕뷗꣙껛믝蓟뇡跣鋥跧駩뿫蟭蓯韱뷳답ꟷ믹엻쿽㗿㌁", a_)))
					{
						num = (short)1375404043;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_31C;
				case 10:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("郃듅ꏇ髉꧋볍胏ꃑ뇓냕뷗꣙껛믝蓟뇡跣鋥跧駩뿫韭華蛱釳鯵뇷뻹껻룽叿儁䴃䈅圇䬉㔋㰍␏∑", a_)))
					{
						num = (short)978518032;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_44F;
				case 11:
					num = (short)479461377;
					if (num != 0)
					{
					}
					this.trkPerPreferredSitesSiteID_A9151 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("郃듅ꏇ髉꧋볍胏ꃑ뇓냕뷗꣙껛믝蓟뇡跣鋥跧駩뿫蟭蓯韱뷳답ꟷ믹엻쿽㗿㌁", a_), global::CommonResources.AcgResources.ID_SITEID, null, null, 0, 1);
					this.trkPerPreferredSitesSiteID_A9151.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.trkPerPreferredSitesSiteID_A9151.DataTransferOrder = 48;
					this.trkPerPreferredSitesSiteID_A9151.ShowHexValue = true;
					num = (short)210960401;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					goto IL_317;
				case 13:
					switch (0)
					{
					case 0:
						goto IL_86;
					}
					continue;
				case 14:
					goto IL_36A;
				case 15:
					this.trkPerPreferredSitesSystemID_A19466 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("郃듅ꏇ髉꧋볍胏ꃑ뇓냕뷗꣙껛믝蓟뇡跣鋥跧駩뿫韭華蛱釳鯵뇷뻹ꏻ뿽ㇿ㬁〃々㸇", a_), global::CommonResources.AcgResources.ID_SYSTEMID, null, null, 0, 1);
					this.trkPerPreferredSitesSystemID_A19466.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.trkPerPreferredSitesSystemID_A19466.DataTransferOrder = 23;
					this.trkPerPreferredSitesSystemID_A19466.ShowHexValue = true;
					this.trkPerPreferredSitesSystemID_A19466.ShowLeadingZeros = true;
					num = (short)871759893;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
					this.trkPerPreferredSitesSystemIDRFSSID_A9240 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("郃듅ꏇ髉꧋볍胏ꃑ뇓냕뷗꣙껛믝蓟뇡跣鋥跧駩뿫韭華蛱釳鯵뇷뻹껻룽叿儁䴃䈅圇䬉㔋㰍␏∑", a_), global::CommonResources.AcgResources.ID_RFSSID, null, null, 0, 1);
					this.trkPerPreferredSitesSystemIDRFSSID_A9240.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.trkPerPreferredSitesSystemIDRFSSID_A9240.DataTransferOrder = 43;
					this.trkPerPreferredSitesSystemIDRFSSID_A9240.ShowHexValue = true;
					num = (short)1193607175;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					goto IL_31C;
				case 18:
					num = (short)659357716;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 19:
					this.trkPerPreferredSitesPreferredStatus_A8734 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("郃듅ꏇ髉꧋볍胏ꃑ뇓냕뷗꣙껛믝蓟뇡跣鋥跧駩볫鳭闯铱釳蓵諷鿹飻귽瓿持瀃猅笇唉䴋㘍✏ℑ–", a_), global::CommonResources.AcgResources.ID_PREFERREDSTATUS, global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.LOVs.TrkPerPreferredSitesPreferredStatus_A8734LovStrs);
					this.trkPerPreferredSitesPreferredStatus_A8734.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkPerPreferredSitesPreferredStatus_A8734.DataTransferOrder = 41;
					num = (short)349700110;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 20:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("郃듅ꏇ髉꧋볍胏ꃑ뇓냕뷗꣙껛믝蓟뇡跣鋥跧駩볫鳭闯铱釳蓵諷鿹飻귽瓿持瀃猅笇唉䴋㘍✏ℑ–", a_)))
					{
						num = (short)380502035;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_36A;
				case 21:
					goto IL_AA;
				}
				IL_86:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1123614725;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_AA:
				num = (short)1259929606;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1B8:
				num = (short)65077250;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_31C:
				num = (short)163774474;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_36A:
				num = (short)1155334153;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_44F:
				num = (short)1807590038;
				short num3 = num;
				num = (short)2043060886;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_4E5:
					num = (short)908591107;
					num2 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)224198656;
					if (num != 0)
					{
					}
					num = (short)2031681536;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_317:
			IL_585:
			num = (short)747700224;
			short num4 = num;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("铃듅귇곉꧋볍ꋏ럑냓诗동꣛믝鏟", a_);
			base.Id = 10183;
			base.UIName = global::CommonResources.AcgResources.ID_PREFERREDSITES;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06001C1C RID: 7196 RVA: 0x001C32CC File Offset: 0x001C14CC
		public override void PopulateReferences()
		{
			short num = (short)1420246998;
			short num2 = num;
			num = (short)936918998;
			switch (num2 == num)
			{
			}
			num = (short)1524170753;
			if (num != 0)
			{
			}
			num = (short)1590099968;
			if (num != 0)
			{
			}
			num = (short)155451392;
			short num3 = num;
		}

		// Token: 0x06001C1D RID: 7197 RVA: 0x001C3374 File Offset: 0x001C1574
		public override void DropReferences()
		{
			short num = (short)342205021;
			short num2 = num;
			num = (short)2143724125;
			switch (num2 == num)
			{
			}
			num = (short)278331393;
			if (num != 0)
			{
			}
			num = (short)434438144;
			if (num != 0)
			{
			}
			num = (short)833814528;
			short num3 = num;
		}

		// Token: 0x06001C1E RID: 7198 RVA: 0x001C341C File Offset: 0x001C161C
		public override void SetConstraints()
		{
			short num = (short)1449838465;
			short num2 = num;
			num = (short)791791489;
			switch (num2 == num)
			{
			}
			num = (short)2046689281;
			if (num != 0)
			{
			}
			num = (short)1469513728;
			if (num != 0)
			{
			}
			num = (short)1951334400;
			short num3 = num;
			this.trkPerPreferredSitesPreferredStatus_A8734.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.ConTrkSysAmssIsSmartZoneEnabled);
			this.trkPerPreferredSitesSiteID_A9151.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.ConTrkSysAmssIsSmartZoneNoWildcard);
			this.trkPerPreferredSitesSiteID_A9151.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.conValidateSiteIDRangeBasedOnProtocolType);
			this.trkPerPreferredSitesSystemIDRFSSID_A9240.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.ConTrkSysAmssIsSmartZoneAndOmniLinkForAstro25);
			this.trkPerPreferredSitesSystemID_A19466.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.ConSystemIDBasedOnSystemTypeAndCovType);
			this.trkPerPreferredSitesSystemID_A19466.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.conValidateRangeForPrefSiteSystemIDBasedOnSystemType);
			this.trkPerPreferredSitesRASWACNID_A20445.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.ConWacnIDBasedOnSystemTypeAndCovType);
			this.trkPerPreferredSitesWildcard_A43586.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.ConTrkSysAmssIsSmartZone);
			this.trkPerPreferredSitesWildcard_A43586.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.conValidateWildcardTypeForPrefSiteWildcardBasedOnCoverageType);
		}

		// Token: 0x06001C1F RID: 7199 RVA: 0x001C3594 File Offset: 0x001C1794
		public override void SetupDependencies()
		{
			short num = (short)1825750833;
			short num2 = num;
			num = (short)1081392945;
			switch (num2 == num)
			{
			}
			num = (short)931725312;
			if (num != 0)
			{
			}
			num = (short)1614086145;
			if (num != 0)
			{
			}
			num = (short)264110080;
			short num3 = num;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality trunkingPersonality = base.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality;
			trunkingPersonality.General.TrkPerGeneralSystem_A9237.AddDependentObject(this.trkPerPreferredSitesPreferredStatus_A8734);
			trunkingPersonality.General.TrkPerGeneralProtocolType_A8767.AddDependentObject(this.trkPerPreferredSitesSiteID_A9151);
			trunkingPersonality.General.TrkPerGeneralSystem_A9237.AddDependentObject(this.trkPerPreferredSitesSiteID_A9151);
			this.trkPerPreferredSitesWildcard_A43586.AddDependentObject(this.trkPerPreferredSitesSiteID_A9151);
			trunkingPersonality.General.TrkPerGeneralSystem_A9237.AddDependentObject(this.trkPerPreferredSitesSystemIDRFSSID_A9240);
			trunkingPersonality.General.TrkPerGeneralProtocolType_A8767.AddDependentObject(this.trkPerPreferredSitesSystemIDRFSSID_A9240);
			this.trkPerPreferredSitesWildcard_A43586.AddDependentObject(this.trkPerPreferredSitesSystemIDRFSSID_A9240);
			trunkingPersonality.General.TrkPerGeneralSystem_A9237.AddDependentObject(this.trkPerPreferredSitesSystemID_A19466);
			trunkingPersonality.General.TrkPerGeneralProtocolType_A8767.AddDependentObject(this.trkPerPreferredSitesSystemID_A19466);
			this.trkPerPreferredSitesWildcard_A43586.AddDependentObject(this.trkPerPreferredSitesSystemID_A19466);
			trunkingPersonality.General.TrkPerGeneralSystem_A9237.AddDependentObject(this.trkPerPreferredSitesRASWACNID_A20445);
			trunkingPersonality.General.TrkPerGeneralProtocolType_A8767.AddDependentObject(this.trkPerPreferredSitesRASWACNID_A20445);
			trunkingPersonality.General.TrkPerGeneralSystem_A9237.AddDependentObject(this.trkPerPreferredSitesWildcard_A43586);
		}

		// Token: 0x17000E2A RID: 3626
		// (get) Token: 0x06001C20 RID: 7200 RVA: 0x001C376C File Offset: 0x001C196C
		public bool HasDiffs
		{
			get
			{
				short num = (short)1736975502;
				short num2 = num;
				num = (short)630465678;
				switch (num2 == num)
				{
				}
				num = (short)427294720;
				if (num != 0)
				{
				}
				num = (short)1340014592;
				short num3 = num;
				num = (short)896335873;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17000E2B RID: 3627
		// (get) Token: 0x06001C21 RID: 7201 RVA: 0x001C381C File Offset: 0x001C1A1C
		// (set) Token: 0x06001C22 RID: 7202 RVA: 0x001C38D0 File Offset: 0x001C1AD0
		public int TrkPerPreferredSitesPreferredStatus_A8734Value
		{
			get
			{
				short num = (short)1756524276;
				short num2 = num;
				num = (short)1483697908;
				switch (num2 == num)
				{
				}
				num = (short)2065104897;
				if (num != 0)
				{
				}
				num = (short)1120731136;
				short num3 = num;
				num = (short)6094848;
				if (num != 0)
				{
				}
				return this.trkPerPreferredSitesPreferredStatus_A8734.Value;
			}
			set
			{
				short num = (short)528882939;
				short num2 = num;
				num = (short)1568283899;
				switch (num2 == num)
				{
				}
				num = (short)1736769537;
				if (num != 0)
				{
				}
				num = (short)681443328;
				short num3 = num;
				num = (short)55443456;
				if (num != 0)
				{
				}
				this.trkPerPreferredSitesPreferredStatus_A8734.Value = value;
			}
		}

		// Token: 0x17000E2C RID: 3628
		// (get) Token: 0x06001C23 RID: 7203 RVA: 0x001C3984 File Offset: 0x001C1B84
		// (set) Token: 0x06001C24 RID: 7204 RVA: 0x001C3A38 File Offset: 0x001C1C38
		public string TrkPerPreferredSitesPreferredStatus_A8734_UIValue
		{
			get
			{
				short num = (short)1133883594;
				short num2 = num;
				num = (short)1210036426;
				switch (num2 == num)
				{
				}
				num = (short)92995584;
				if (num != 0)
				{
				}
				num = (short)1574240256;
				short num3 = num;
				num = (short)821624833;
				if (num != 0)
				{
				}
				return this.trkPerPreferredSitesPreferredStatus_A8734.UIValue;
			}
			set
			{
				short num = (short)382427217;
				short num2 = num;
				num = (short)196829265;
				switch (num2 == num)
				{
				}
				num = (short)1200488449;
				if (num != 0)
				{
				}
				num = (short)52166656;
				short num3 = num;
				num = (short)2120613888;
				if (num != 0)
				{
				}
				this.trkPerPreferredSitesPreferredStatus_A8734.UIValue = value;
			}
		}

		// Token: 0x17000E2D RID: 3629
		// (get) Token: 0x06001C25 RID: 7205 RVA: 0x001C3AEC File Offset: 0x001C1CEC
		public global::AcpBusinessLayer.AcpListField TrkPerPreferredSitesPreferredStatus_A8734
		{
			get
			{
				short num = (short)1336000138;
				short num2 = num;
				num = (short)394247818;
				switch (num2 == num)
				{
				}
				num = (short)370278400;
				if (num != 0)
				{
				}
				num = (short)2006056960;
				short num3 = num;
				num = (short)1476853761;
				if (num != 0)
				{
				}
				return this.trkPerPreferredSitesPreferredStatus_A8734;
			}
		}

		// Token: 0x17000E2E RID: 3630
		// (get) Token: 0x06001C26 RID: 7206 RVA: 0x001C3B98 File Offset: 0x001C1D98
		// (set) Token: 0x06001C27 RID: 7207 RVA: 0x001C3C4C File Offset: 0x001C1E4C
		public bool TrkPerPreferredSitesPreferredStatus_A8734_Applicable
		{
			get
			{
				short num = (short)2059862017;
				if (num != 0)
				{
				}
				num = (short)1467476683;
				short num2 = num;
				num = (short)1854401227;
				switch (num2 == num)
				{
				}
				num = (short)751828992;
				short num3 = num;
				num = (short)1489895424;
				if (num != 0)
				{
				}
				return this.trkPerPreferredSitesPreferredStatus_A8734.Applicable;
			}
			set
			{
				short num = (short)289645782;
				short num2 = num;
				num = (short)237741270;
				switch (num2 == num)
				{
				}
				num = (short)2094923777;
				if (num != 0)
				{
				}
				num = (short)1770848256;
				short num3 = num;
				num = (short)150798336;
				if (num != 0)
				{
				}
				this.trkPerPreferredSitesPreferredStatus_A8734.Applicable = value;
			}
		}

		// Token: 0x17000E2F RID: 3631
		// (get) Token: 0x06001C28 RID: 7208 RVA: 0x001C3D04 File Offset: 0x001C1F04
		// (set) Token: 0x06001C29 RID: 7209 RVA: 0x001C3DB8 File Offset: 0x001C1FB8
		public bool TrkPerPreferredSitesPreferredStatus_A8734_Valid
		{
			get
			{
				short num = (short)1875648111;
				short num2 = num;
				num = (short)1613045359;
				switch (num2 == num)
				{
				}
				num = (short)1393885184;
				if (num != 0)
				{
				}
				num = (short)1396637696;
				short num3 = num;
				num = (short)1485701121;
				if (num != 0)
				{
				}
				return this.trkPerPreferredSitesPreferredStatus_A8734.Valid;
			}
			set
			{
				short num = (short)1149108225;
				if (num != 0)
				{
				}
				num = (short)332424177;
				short num2 = num;
				num = (short)1087005681;
				switch (num2 == num)
				{
				}
				num = (short)428343296;
				short num3 = num;
				num = (short)1580990464;
				if (num != 0)
				{
				}
				this.trkPerPreferredSitesPreferredStatus_A8734.Valid = value;
			}
		}

		// Token: 0x17000E30 RID: 3632
		// (get) Token: 0x06001C2A RID: 7210 RVA: 0x001C3E6C File Offset: 0x001C206C
		// (set) Token: 0x06001C2B RID: 7211 RVA: 0x001C3F20 File Offset: 0x001C2120
		public bool TrkPerPreferredSitesPreferredStatus_A8734_Visible
		{
			get
			{
				short num = (short)1652869963;
				short num2 = num;
				num = (short)59820875;
				switch (num2 == num)
				{
				}
				num = (short)119209985;
				if (num != 0)
				{
				}
				num = (short)1745682432;
				short num3 = num;
				num = (short)77004800;
				if (num != 0)
				{
				}
				return this.trkPerPreferredSitesPreferredStatus_A8734.Visible;
			}
			set
			{
				short num = (short)1603191058;
				short num2 = num;
				num = (short)357155090;
				switch (num2 == num)
				{
				}
				num = (short)579600384;
				if (num != 0)
				{
				}
				num = (short)1518010368;
				short num3 = num;
				num = (short)88408065;
				if (num != 0)
				{
				}
				this.trkPerPreferredSitesPreferredStatus_A8734.Visible = value;
			}
		}

		// Token: 0x17000E31 RID: 3633
		// (get) Token: 0x06001C2C RID: 7212 RVA: 0x001C3FD4 File Offset: 0x001C21D4
		// (set) Token: 0x06001C2D RID: 7213 RVA: 0x001C4088 File Offset: 0x001C2288
		public bool TrkPerPreferredSitesPreferredStatus_A8734_Editable
		{
			get
			{
				short num = (short)693633025;
				if (num != 0)
				{
				}
				num = (short)104977603;
				short num2 = num;
				num = (short)1839846595;
				switch (num2 == num)
				{
				}
				num = (short)1145307136;
				short num3 = num;
				num = (short)1158610944;
				if (num != 0)
				{
				}
				return this.trkPerPreferredSitesPreferredStatus_A8734.Editable;
			}
			set
			{
				short num = (short)739844350;
				short num2 = num;
				num = (short)1592074494;
				switch (num2 == num)
				{
				}
				num = (short)1527644161;
				if (num != 0)
				{
				}
				num = (short)1095565312;
				short num3 = num;
				num = (short)1325203456;
				if (num != 0)
				{
				}
				this.trkPerPreferredSitesPreferredStatus_A8734.Editable = value;
			}
		}

		// Token: 0x17000E32 RID: 3634
		// (get) Token: 0x06001C2E RID: 7214 RVA: 0x001C4140 File Offset: 0x001C2340
		internal string TrkPerPreferredSitesPreferredStatus_A8734_UILabel
		{
			get
			{
				short num = (short)767505684;
				short num2 = num;
				num = (short)209925396;
				switch (num2 == num)
				{
				}
				num = (short)1746141184;
				if (num != 0)
				{
				}
				num = (short)113770496;
				short num3 = num;
				num = (short)349044737;
				if (num != 0)
				{
				}
				return this.trkPerPreferredSitesPreferredStatus_A8734.UIName;
			}
		}

		// Token: 0x17000E33 RID: 3635
		// (get) Token: 0x06001C2F RID: 7215 RVA: 0x001C41F8 File Offset: 0x001C23F8
		// (set) Token: 0x06001C30 RID: 7216 RVA: 0x001C42B0 File Offset: 0x001C24B0
		internal bool TrkPerPreferredSitesPreferredStatus_A8734_HiddenStatic
		{
			get
			{
				short num = (short)1289093121;
				if (num != 0)
				{
				}
				num = (short)1324049471;
				short num2 = num;
				num = (short)466773055;
				switch (num2 == num)
				{
				}
				num = (short)270467072;
				short num3 = num;
				num = (short)1879572480;
				if (num != 0)
				{
				}
				return this.trkPerPreferredSitesPreferredStatus_A8734.HiddenStatic;
			}
			set
			{
				short num = (short)1333464230;
				short num2 = num;
				num = (short)1946356902;
				switch (num2 == num)
				{
				}
				num = (short)485359617;
				if (num != 0)
				{
				}
				num = (short)1959002112;
				short num3 = num;
				num = (short)12058624;
				if (num != 0)
				{
				}
				this.trkPerPreferredSitesPreferredStatus_A8734.HiddenStatic = value;
			}
		}

		// Token: 0x17000E34 RID: 3636
		// (get) Token: 0x06001C31 RID: 7217 RVA: 0x001C4364 File Offset: 0x001C2564
		// (set) Token: 0x06001C32 RID: 7218 RVA: 0x001C4418 File Offset: 0x001C2618
		internal bool TrkPerPreferredSitesPreferredStatus_A8734_HiddenDynamic
		{
			get
			{
				short num = (short)1486108610;
				short num2 = num;
				num = (short)1259747266;
				switch (num2 == num)
				{
				}
				num = (short)307757057;
				if (num != 0)
				{
				}
				num = (short)219086848;
				short num3 = num;
				num = (short)1913126912;
				if (num != 0)
				{
				}
				return this.trkPerPreferredSitesPreferredStatus_A8734.HiddenDynamic;
			}
			set
			{
				short num = (short)1343724685;
				short num2 = num;
				num = (short)1480825997;
				switch (num2 == num)
				{
				}
				num = (short)504365057;
				if (num != 0)
				{
				}
				num = (short)1748303872;
				short num3 = num;
				num = (short)1353842688;
				if (num != 0)
				{
				}
				this.trkPerPreferredSitesPreferredStatus_A8734.HiddenDynamic = value;
			}
		}

		// Token: 0x17000E35 RID: 3637
		// (get) Token: 0x06001C33 RID: 7219 RVA: 0x001C44D0 File Offset: 0x001C26D0
		public bool TrkPerPreferredSitesPreferredStatus_A8734_HasDiffs
		{
			get
			{
				short num = (short)1890390451;
				short num2 = num;
				num = (short)1632047539;
				switch (num2 == num)
				{
				}
				num = (short)1067712513;
				if (num != 0)
				{
				}
				num = (short)1176502272;
				short num3 = num;
				num = (short)670236672;
				if (num != 0)
				{
				}
				return this.trkPerPreferredSitesPreferredStatus_A8734._HasDiffs;
			}
		}

		// Token: 0x17000E36 RID: 3638
		// (get) Token: 0x06001C34 RID: 7220 RVA: 0x001C4588 File Offset: 0x001C2788
		// (set) Token: 0x06001C35 RID: 7221 RVA: 0x001C463C File Offset: 0x001C283C
		public int TrkPerPreferredSitesSiteID_A9151Value
		{
			get
			{
				short num = (short)1996831570;
				short num2 = num;
				num = (short)1513044818;
				switch (num2 == num)
				{
				}
				num = (short)1460011009;
				if (num != 0)
				{
				}
				num = (short)1922498560;
				short num3 = num;
				num = (short)123142144;
				if (num != 0)
				{
				}
				return this.trkPerPreferredSitesSiteID_A9151.Value;
			}
			set
			{
				short num = (short)995820435;
				short num2 = num;
				num = (short)1297023891;
				switch (num2 == num)
				{
				}
				num = (short)978911233;
				if (num != 0)
				{
				}
				num = (short)416743424;
				short num3 = num;
				num = (short)1048182784;
				if (num != 0)
				{
				}
				this.trkPerPreferredSitesSiteID_A9151.Value = value;
			}
		}

		// Token: 0x17000E37 RID: 3639
		// (get) Token: 0x06001C36 RID: 7222 RVA: 0x001C46F4 File Offset: 0x001C28F4
		public global::AcpBusinessLayer.AcpSimpleRangeField TrkPerPreferredSitesSiteID_A9151
		{
			get
			{
				short num = (short)176134022;
				short num2 = num;
				num = (short)1168611206;
				switch (num2 == num)
				{
				}
				num = (short)1030946817;
				if (num != 0)
				{
				}
				num = (short)724434944;
				short num3 = num;
				num = (short)1649868800;
				if (num != 0)
				{
				}
				return this.trkPerPreferredSitesSiteID_A9151;
			}
		}

		// Token: 0x17000E38 RID: 3640
		// (get) Token: 0x06001C37 RID: 7223 RVA: 0x001C47A4 File Offset: 0x001C29A4
		// (set) Token: 0x06001C38 RID: 7224 RVA: 0x001C4858 File Offset: 0x001C2A58
		public string TrkPerPreferredSitesSiteID_A9151_UIValue
		{
			get
			{
				short num = (short)1478051351;
				short num2 = num;
				num = (short)402802199;
				switch (num2 == num)
				{
				}
				num = (short)1236140033;
				if (num != 0)
				{
				}
				num = (short)1502281728;
				short num3 = num;
				num = (short)853803008;
				if (num != 0)
				{
				}
				return this.trkPerPreferredSitesSiteID_A9151.UIValue;
			}
			set
			{
				short num = (short)1937329014;
				short num2 = num;
				num = (short)443763574;
				switch (num2 == num)
				{
				}
				num = (short)497614849;
				if (num != 0)
				{
				}
				num = (short)2022703104;
				short num3 = num;
				num = (short)165019648;
				if (num != 0)
				{
				}
				this.trkPerPreferredSitesSiteID_A9151.UIValue = value;
			}
		}

		// Token: 0x17000E39 RID: 3641
		// (get) Token: 0x06001C39 RID: 7225 RVA: 0x001C4908 File Offset: 0x001C2B08
		// (set) Token: 0x06001C3A RID: 7226 RVA: 0x001C49BC File Offset: 0x001C2BBC
		public string TrkPerPreferredSitesSiteID_A9151_HexUIValue
		{
			get
			{
				short num = (short)947371859;
				short num2 = num;
				num = (short)506314579;
				switch (num2 == num)
				{
				}
				num = (short)1318584321;
				if (num != 0)
				{
				}
				num = (short)905707520;
				short num3 = num;
				num = (short)686751744;
				if (num != 0)
				{
				}
				return this.trkPerPreferredSitesSiteID_A9151.HexUIValue;
			}
			set
			{
				short num = (short)459502409;
				short num2 = num;
				num = (short)715486025;
				switch (num2 == num)
				{
				}
				num = (short)1958281217;
				if (num != 0)
				{
				}
				num = (short)414187520;
				short num3 = num;
				num = (short)1636696064;
				if (num != 0)
				{
				}
				this.trkPerPreferredSitesSiteID_A9151.HexUIValue = value;
			}
		}

		// Token: 0x17000E3A RID: 3642
		// (get) Token: 0x06001C3B RID: 7227 RVA: 0x001C4A70 File Offset: 0x001C2C70
		// (set) Token: 0x06001C3C RID: 7228 RVA: 0x001C4B24 File Offset: 0x001C2D24
		internal int TrkPerPreferredSitesSiteID_A9151Min
		{
			get
			{
				short num = (short)2106984593;
				short num2 = num;
				num = (short)295700625;
				switch (num2 == num)
				{
				}
				num = (short)1167654913;
				if (num != 0)
				{
				}
				num = (short)485556224;
				short num3 = num;
				num = (short)1554972672;
				if (num != 0)
				{
				}
				return this.trkPerPreferredSitesSiteID_A9151.Min;
			}
			set
			{
				short num = (short)1158505042;
				short num2 = num;
				num = (short)1365271122;
				switch (num2 == num)
				{
				}
				num = (short)424083456;
				if (num != 0)
				{
				}
				num = (short)630980608;
				short num3 = num;
				num = (short)573571073;
				if (num != 0)
				{
				}
				this.trkPerPreferredSitesSiteID_A9151.Min = value;
			}
		}

		// Token: 0x17000E3B RID: 3643
		// (get) Token: 0x06001C3D RID: 7229 RVA: 0x001C4BDC File Offset: 0x001C2DDC
		// (set) Token: 0x06001C3E RID: 7230 RVA: 0x001C4C90 File Offset: 0x001C2E90
		internal int TrkPerPreferredSitesSiteID_A9151Max
		{
			get
			{
				short num = (short)473848809;
				short num2 = num;
				num = (short)644963305;
				switch (num2 == num)
				{
				}
				num = (short)1682046976;
				if (num != 0)
				{
				}
				num = (short)1898840064;
				short num3 = num;
				num = (short)838139905;
				if (num != 0)
				{
				}
				return this.trkPerPreferredSitesSiteID_A9151.Max;
			}
			set
			{
				short num = (short)1957576436;
				short num2 = num;
				num = (short)819412724;
				switch (num2 == num)
				{
				}
				num = (short)1049952257;
				if (num != 0)
				{
				}
				num = (short)1181286400;
				short num3 = num;
				num = (short)805568512;
				if (num != 0)
				{
				}
				this.trkPerPreferredSitesSiteID_A9151.Max = value;
			}
		}

		// Token: 0x17000E3C RID: 3644
		// (get) Token: 0x06001C3F RID: 7231 RVA: 0x001C4D48 File Offset: 0x001C2F48
		// (set) Token: 0x06001C40 RID: 7232 RVA: 0x001C4DFC File Offset: 0x001C2FFC
		internal int TrkPerPreferredSitesSiteID_A9151Step
		{
			get
			{
				short num = (short)632755573;
				short num2 = num;
				num = (short)819402101;
				switch (num2 == num)
				{
				}
				num = (short)1972699136;
				if (num != 0)
				{
				}
				num = (short)1516109824;
				short num3 = num;
				num = (short)2011037697;
				if (num != 0)
				{
				}
				return this.trkPerPreferredSitesSiteID_A9151.StepSize;
			}
			set
			{
				short num = (short)229334131;
				short num2 = num;
				num = (short)1421630579;
				switch (num2 == num)
				{
				}
				num = (short)1944715264;
				if (num != 0)
				{
				}
				num = (short)1039138816;
				short num3 = num;
				num = (short)1099694081;
				if (num != 0)
				{
				}
				this.trkPerPreferredSitesSiteID_A9151.StepSize = value;
			}
		}

		// Token: 0x17000E3D RID: 3645
		// (get) Token: 0x06001C41 RID: 7233 RVA: 0x001C4EB0 File Offset: 0x001C30B0
		// (set) Token: 0x06001C42 RID: 7234 RVA: 0x001C4F68 File Offset: 0x001C3168
		public bool TrkPerPreferredSitesSiteID_A9151_Applicable
		{
			get
			{
				short num = (short)1543786402;
				short num2 = num;
				num = (short)210063266;
				switch (num2 == num)
				{
				}
				num = (short)1941241856;
				if (num != 0)
				{
				}
				num = (short)1421869056;
				short num3 = num;
				num = (short)905314305;
				if (num != 0)
				{
				}
				return this.trkPerPreferredSitesSiteID_A9151.Applicable;
			}
			set
			{
				short num = (short)668677316;
				short num2 = num;
				num = (short)1623930052;
				switch (num2 == num)
				{
				}
				num = (short)1044643841;
				if (num != 0)
				{
				}
				num = (short)1343815680;
				short num3 = num;
				num = (short)1572470784;
				if (num != 0)
				{
				}
				this.trkPerPreferredSitesSiteID_A9151.Applicable = value;
			}
		}

		// Token: 0x17000E3E RID: 3646
		// (get) Token: 0x06001C43 RID: 7235 RVA: 0x001C501C File Offset: 0x001C321C
		// (set) Token: 0x06001C44 RID: 7236 RVA: 0x001C50D4 File Offset: 0x001C32D4
		public bool TrkPerPreferredSitesSiteID_A9151_Valid
		{
			get
			{
				short num = (short)1330217997;
				short num2 = num;
				num = (short)324633613;
				switch (num2 == num)
				{
				}
				num = (short)1065811968;
				if (num != 0)
				{
				}
				num = (short)1763442688;
				short num3 = num;
				num = (short)238288897;
				if (num != 0)
				{
				}
				return this.trkPerPreferredSitesSiteID_A9151.Valid;
			}
			set
			{
				short num = (short)1224813097;
				short num2 = num;
				num = (short)1119169065;
				switch (num2 == num)
				{
				}
				num = (short)276037632;
				if (num != 0)
				{
				}
				num = (short)1646526464;
				short num3 = num;
				num = (short)1685454849;
				if (num != 0)
				{
				}
				this.trkPerPreferredSitesSiteID_A9151.Valid = value;
			}
		}

		// Token: 0x17000E3F RID: 3647
		// (get) Token: 0x06001C45 RID: 7237 RVA: 0x001C518C File Offset: 0x001C338C
		// (set) Token: 0x06001C46 RID: 7238 RVA: 0x001C5244 File Offset: 0x001C3444
		public bool TrkPerPreferredSitesSiteID_A9151_Visible
		{
			get
			{
				short num = (short)1295938270;
				short num2 = num;
				num = (short)972059358;
				switch (num2 == num)
				{
				}
				num = (short)1034485760;
				if (num != 0)
				{
				}
				num = (short)1111162880;
				short num3 = num;
				num = (short)689307649;
				if (num != 0)
				{
				}
				return this.trkPerPreferredSitesSiteID_A9151.Visible;
			}
			set
			{
				short num = (short)842078189;
				short num2 = num;
				num = (short)1009260525;
				switch (num2 == num)
				{
				}
				num = (short)597360641;
				if (num != 0)
				{
				}
				num = (short)1527119872;
				short num3 = num;
				num = (short)683933696;
				if (num != 0)
				{
				}
				this.trkPerPreferredSitesSiteID_A9151.Visible = value;
			}
		}

		// Token: 0x17000E40 RID: 3648
		// (get) Token: 0x06001C47 RID: 7239 RVA: 0x001C52F8 File Offset: 0x001C34F8
		// (set) Token: 0x06001C48 RID: 7240 RVA: 0x001C53AC File Offset: 0x001C35AC
		public bool TrkPerPreferredSitesSiteID_A9151_Editable
		{
			get
			{
				short num = (short)970040252;
				short num2 = num;
				num = (short)493921212;
				switch (num2 == num)
				{
				}
				num = (short)1310326785;
				if (num != 0)
				{
				}
				num = (short)268566528;
				short num3 = num;
				num = (short)2058485760;
				if (num != 0)
				{
				}
				return this.trkPerPreferredSitesSiteID_A9151.Editable;
			}
			set
			{
				short num = (short)1024655361;
				if (num != 0)
				{
				}
				num = (short)646082927;
				short num2 = num;
				num = (short)248476015;
				switch (num2 == num)
				{
				}
				num = (short)2052915200;
				short num3 = num;
				num = (short)1785069568;
				if (num != 0)
				{
				}
				this.trkPerPreferredSitesSiteID_A9151.Editable = value;
			}
		}

		// Token: 0x17000E41 RID: 3649
		// (get) Token: 0x06001C49 RID: 7241 RVA: 0x001C5464 File Offset: 0x001C3664
		internal string TrkPerPreferredSitesSiteID_A9151_UILabel
		{
			get
			{
				short num = (short)1537810104;
				short num2 = num;
				num = (short)1541217976;
				switch (num2 == num)
				{
				}
				num = (short)880607233;
				if (num != 0)
				{
				}
				num = (short)751370240;
				short num3 = num;
				num = (short)2092236800;
				if (num != 0)
				{
				}
				return this.trkPerPreferredSitesSiteID_A9151.UIName;
			}
		}

		// Token: 0x17000E42 RID: 3650
		// (get) Token: 0x06001C4A RID: 7242 RVA: 0x001C5518 File Offset: 0x001C3718
		// (set) Token: 0x06001C4B RID: 7243 RVA: 0x001C55CC File Offset: 0x001C37CC
		internal bool TrkPerPreferredSitesSiteID_A9151_HiddenStatic
		{
			get
			{
				short num = (short)1746318649;
				short num2 = num;
				num = (short)1647359289;
				switch (num2 == num)
				{
				}
				num = (short)1299120128;
				if (num != 0)
				{
				}
				num = (short)1745682432;
				short num3 = num;
				num = (short)907804673;
				if (num != 0)
				{
				}
				return this.trkPerPreferredSitesSiteID_A9151.HiddenStatic;
			}
			set
			{
				short num = (short)381414784;
				short num2 = num;
				num = (short)69397888;
				switch (num2 == num)
				{
				}
				num = (short)2079064065;
				if (num != 0)
				{
				}
				num = (short)1054736384;
				short num3 = num;
				num = (short)1857028096;
				if (num != 0)
				{
				}
				this.trkPerPreferredSitesSiteID_A9151.HiddenStatic = value;
			}
		}

		// Token: 0x17000E43 RID: 3651
		// (get) Token: 0x06001C4C RID: 7244 RVA: 0x001C5680 File Offset: 0x001C3880
		// (set) Token: 0x06001C4D RID: 7245 RVA: 0x001C5738 File Offset: 0x001C3938
		internal bool TrkPerPreferredSitesSiteID_A9151_HiddenDynamic
		{
			get
			{
				short num = (short)470650529;
				short num2 = num;
				num = (short)189828769;
				switch (num2 == num)
				{
				}
				num = (short)1591672833;
				if (num != 0)
				{
				}
				num = (short)616169472;
				short num3 = num;
				num = (short)2049507328;
				if (num != 0)
				{
				}
				return this.trkPerPreferredSitesSiteID_A9151.HiddenDynamic;
			}
			set
			{
				short num = (short)1179146767;
				short num2 = num;
				num = (short)1751996943;
				switch (num2 == num)
				{
				}
				num = (short)845217793;
				if (num != 0)
				{
				}
				num = (short)1645215744;
				short num3 = num;
				num = (short)14745600;
				if (num != 0)
				{
				}
				this.trkPerPreferredSitesSiteID_A9151.HiddenDynamic = value;
			}
		}

		// Token: 0x17000E44 RID: 3652
		// (get) Token: 0x06001C4E RID: 7246 RVA: 0x001C57EC File Offset: 0x001C39EC
		public bool TrkPerPreferredSitesSiteID_A9151_HasDiffs
		{
			get
			{
				short num = (short)481591935;
				short num2 = num;
				num = (short)1932100223;
				switch (num2 == num)
				{
				}
				num = (short)2103574528;
				if (num != 0)
				{
				}
				num = (short)1438908416;
				short num3 = num;
				num = (short)1861615617;
				if (num != 0)
				{
				}
				return this.trkPerPreferredSitesSiteID_A9151._HasDiffs;
			}
		}

		// Token: 0x17000E45 RID: 3653
		// (get) Token: 0x06001C4F RID: 7247 RVA: 0x001C58A0 File Offset: 0x001C3AA0
		// (set) Token: 0x06001C50 RID: 7248 RVA: 0x001C5950 File Offset: 0x001C3B50
		public int TrkPerPreferredSitesSystemIDRFSSID_A9240Value
		{
			get
			{
				short num = (short)1307688826;
				short num2 = num;
				num = (short)1067761530;
				switch (num2 == num)
				{
				}
				num = (short)237109249;
				if (num != 0)
				{
				}
				num = (short)370606080;
				short num3 = num;
				num = (short)1487470592;
				if (num != 0)
				{
				}
				return this.trkPerPreferredSitesSystemIDRFSSID_A9240.Value;
			}
			set
			{
				short num = (short)1943414098;
				short num2 = num;
				num = (short)1230251346;
				switch (num2 == num)
				{
				}
				num = (short)267386881;
				if (num != 0)
				{
				}
				num = (short)838533120;
				short num3 = num;
				num = (short)1958215680;
				if (num != 0)
				{
				}
				this.trkPerPreferredSitesSystemIDRFSSID_A9240.Value = value;
			}
		}

		// Token: 0x17000E46 RID: 3654
		// (get) Token: 0x06001C51 RID: 7249 RVA: 0x001C5A04 File Offset: 0x001C3C04
		public global::AcpBusinessLayer.AcpSimpleRangeField TrkPerPreferredSitesSystemIDRFSSID_A9240
		{
			get
			{
				short num = (short)506655469;
				short num2 = num;
				num = (short)1272574701;
				switch (num2 == num)
				{
				}
				num = (short)1103101953;
				if (num != 0)
				{
				}
				num = (short)1485438976;
				short num3 = num;
				num = (short)1407254528;
				if (num != 0)
				{
				}
				return this.trkPerPreferredSitesSystemIDRFSSID_A9240;
			}
		}

		// Token: 0x17000E47 RID: 3655
		// (get) Token: 0x06001C52 RID: 7250 RVA: 0x001C5AB4 File Offset: 0x001C3CB4
		// (set) Token: 0x06001C53 RID: 7251 RVA: 0x001C5B68 File Offset: 0x001C3D68
		public string TrkPerPreferredSitesSystemIDRFSSID_A9240_UIValue
		{
			get
			{
				short num = (short)529634799;
				short num2 = num;
				num = (short)437491183;
				switch (num2 == num)
				{
				}
				num = (short)219086849;
				if (num != 0)
				{
				}
				num = (short)1220608000;
				short num3 = num;
				num = (short)238026752;
				if (num != 0)
				{
				}
				return this.trkPerPreferredSitesSystemIDRFSSID_A9240.UIValue;
			}
			set
			{
				short num = (short)1985349651;
				short num2 = num;
				num = (short)1400113171;
				switch (num2 == num)
				{
				}
				num = (short)892796929;
				if (num != 0)
				{
				}
				num = (short)1585971200;
				short num3 = num;
				num = (short)608174080;
				if (num != 0)
				{
				}
				this.trkPerPreferredSitesSystemIDRFSSID_A9240.UIValue = value;
			}
		}

		// Token: 0x17000E48 RID: 3656
		// (get) Token: 0x06001C54 RID: 7252 RVA: 0x001C5C1C File Offset: 0x001C3E1C
		// (set) Token: 0x06001C55 RID: 7253 RVA: 0x001C5CD0 File Offset: 0x001C3ED0
		public string TrkPerPreferredSitesSystemIDRFSSID_A9240_HexUIValue
		{
			get
			{
				short num = (short)588054529;
				if (num != 0)
				{
				}
				num = (short)642319824;
				short num2 = num;
				num = (short)1158415824;
				switch (num2 == num)
				{
				}
				num = (short)523829248;
				short num3 = num;
				num = (short)54132736;
				if (num != 0)
				{
				}
				return this.trkPerPreferredSitesSystemIDRFSSID_A9240.HexUIValue;
			}
			set
			{
				short num = (short)1604761037;
				short num2 = num;
				num = (short)1981199821;
				switch (num2 == num)
				{
				}
				num = (short)1739128833;
				if (num != 0)
				{
				}
				num = (short)1056243712;
				short num3 = num;
				num = (short)245366784;
				if (num != 0)
				{
				}
				this.trkPerPreferredSitesSystemIDRFSSID_A9240.HexUIValue = value;
			}
		}

		// Token: 0x17000E49 RID: 3657
		// (get) Token: 0x06001C56 RID: 7254 RVA: 0x001C5D84 File Offset: 0x001C3F84
		// (set) Token: 0x06001C57 RID: 7255 RVA: 0x001C5E38 File Offset: 0x001C4038
		internal int TrkPerPreferredSitesSystemIDRFSSID_A9240Min
		{
			get
			{
				short num = (short)323978207;
				short num2 = num;
				num = (short)769754079;
				switch (num2 == num)
				{
				}
				num = (short)1220739073;
				if (num != 0)
				{
				}
				num = (short)1036713984;
				short num3 = num;
				num = (short)987430912;
				if (num != 0)
				{
				}
				return this.trkPerPreferredSitesSystemIDRFSSID_A9240.Min;
			}
			set
			{
				short num = (short)113123579;
				short num2 = num;
				num = (short)1062150395;
				switch (num2 == num)
				{
				}
				num = (short)1450311681;
				if (num != 0)
				{
				}
				num = (short)1462960128;
				if (num != 0)
				{
				}
				num = (short)1513422848;
				short num3 = num;
				this.trkPerPreferredSitesSystemIDRFSSID_A9240.Min = value;
			}
		}

		// Token: 0x17000E4A RID: 3658
		// (get) Token: 0x06001C58 RID: 7256 RVA: 0x001C5EF0 File Offset: 0x001C40F0
		// (set) Token: 0x06001C59 RID: 7257 RVA: 0x001C5FA4 File Offset: 0x001C41A4
		internal int TrkPerPreferredSitesSystemIDRFSSID_A9240Max
		{
			get
			{
				short num = (short)1958074222;
				short num2 = num;
				num = (short)834197358;
				switch (num2 == num)
				{
				}
				num = (short)1920466945;
				if (num != 0)
				{
				}
				num = (short)181469184;
				if (num != 0)
				{
				}
				num = (short)252968960;
				short num3 = num;
				return this.trkPerPreferredSitesSystemIDRFSSID_A9240.Max;
			}
			set
			{
				short num = (short)935329793;
				if (num != 0)
				{
				}
				num = (short)1896142563;
				short num2 = num;
				num = (short)2014238435;
				switch (num2 == num)
				{
				}
				num = (short)101974016;
				if (num != 0)
				{
				}
				num = (short)109838336;
				short num3 = num;
				this.trkPerPreferredSitesSystemIDRFSSID_A9240.Max = value;
			}
		}

		// Token: 0x17000E4B RID: 3659
		// (get) Token: 0x06001C5A RID: 7258 RVA: 0x001C605C File Offset: 0x001C425C
		// (set) Token: 0x06001C5B RID: 7259 RVA: 0x001C6110 File Offset: 0x001C4310
		internal int TrkPerPreferredSitesSystemIDRFSSID_A9240Step
		{
			get
			{
				short num = (short)1146709332;
				short num2 = num;
				num = (short)1918920020;
				switch (num2 == num)
				{
				}
				num = (short)1785724929;
				if (num != 0)
				{
				}
				num = (short)24117248;
				if (num != 0)
				{
				}
				num = (short)1387986944;
				short num3 = num;
				return this.trkPerPreferredSitesSystemIDRFSSID_A9240.StepSize;
			}
			set
			{
				short num = (short)1583546369;
				if (num != 0)
				{
				}
				num = (short)257270013;
				short num2 = num;
				num = (short)1589158141;
				switch (num2 == num)
				{
				}
				num = (short)1393623040;
				if (num != 0)
				{
				}
				num = (short)233504768;
				short num3 = num;
				this.trkPerPreferredSitesSystemIDRFSSID_A9240.StepSize = value;
			}
		}

		// Token: 0x17000E4C RID: 3660
		// (get) Token: 0x06001C5C RID: 7260 RVA: 0x001C61C4 File Offset: 0x001C43C4
		// (set) Token: 0x06001C5D RID: 7261 RVA: 0x001C6278 File Offset: 0x001C4478
		public bool TrkPerPreferredSitesSystemIDRFSSID_A9240_Applicable
		{
			get
			{
				short num = (short)1536314177;
				short num2 = num;
				num = (short)1394101057;
				switch (num2 == num)
				{
				}
				num = (short)1055784961;
				if (num != 0)
				{
				}
				num = (short)1551106048;
				if (num != 0)
				{
				}
				num = (short)1558904832;
				short num3 = num;
				return this.trkPerPreferredSitesSystemIDRFSSID_A9240.Applicable;
			}
			set
			{
				short num = (short)1674371641;
				short num2 = num;
				num = (short)1749803577;
				switch (num2 == num)
				{
				}
				num = (short)294125569;
				if (num != 0)
				{
				}
				num = (short)1405222912;
				if (num != 0)
				{
				}
				num = (short)1507917824;
				short num3 = num;
				this.trkPerPreferredSitesSystemIDRFSSID_A9240.Applicable = value;
			}
		}

		// Token: 0x17000E4D RID: 3661
		// (get) Token: 0x06001C5E RID: 7262 RVA: 0x001C6334 File Offset: 0x001C4534
		// (set) Token: 0x06001C5F RID: 7263 RVA: 0x001C63E8 File Offset: 0x001C45E8
		public bool TrkPerPreferredSitesSystemIDRFSSID_A9240_Valid
		{
			get
			{
				short num = (short)1345864323;
				short num2 = num;
				num = (short)956318339;
				switch (num2 == num)
				{
				}
				num = (short)1786642433;
				if (num != 0)
				{
				}
				num = (short)1284964352;
				if (num != 0)
				{
				}
				num = (short)1009188864;
				short num3 = num;
				return this.trkPerPreferredSitesSystemIDRFSSID_A9240.Valid;
			}
			set
			{
				short num = (short)1247134342;
				short num2 = num;
				num = (short)1595130502;
				switch (num2 == num)
				{
				}
				num = (short)1548877824;
				if (num != 0)
				{
				}
				num = (short)206962689;
				if (num != 0)
				{
				}
				num = (short)431620096;
				short num3 = num;
				this.trkPerPreferredSitesSystemIDRFSSID_A9240.Valid = value;
			}
		}

		// Token: 0x17000E4E RID: 3662
		// (get) Token: 0x06001C60 RID: 7264 RVA: 0x001C649C File Offset: 0x001C469C
		// (set) Token: 0x06001C61 RID: 7265 RVA: 0x001C6550 File Offset: 0x001C4750
		public bool TrkPerPreferredSitesSystemIDRFSSID_A9240_Visible
		{
			get
			{
				short num = (short)1731470588;
				short num2 = num;
				num = (short)268051708;
				switch (num2 == num)
				{
				}
				num = (short)1290665984;
				if (num != 0)
				{
				}
				num = (short)463208449;
				if (num != 0)
				{
				}
				num = (short)1506279424;
				short num3 = num;
				return this.trkPerPreferredSitesSystemIDRFSSID_A9240.Visible;
			}
			set
			{
				short num = (short)2049357270;
				short num2 = num;
				num = (short)1737668054;
				switch (num2 == num)
				{
				}
				num = (short)2106261505;
				if (num != 0)
				{
				}
				num = (short)616169472;
				if (num != 0)
				{
				}
				num = (short)1136918528;
				short num3 = num;
				this.trkPerPreferredSitesSystemIDRFSSID_A9240.Visible = value;
			}
		}

		// Token: 0x17000E4F RID: 3663
		// (get) Token: 0x06001C62 RID: 7266 RVA: 0x001C6604 File Offset: 0x001C4804
		// (set) Token: 0x06001C63 RID: 7267 RVA: 0x001C66B8 File Offset: 0x001C48B8
		public bool TrkPerPreferredSitesSystemIDRFSSID_A9240_Editable
		{
			get
			{
				short num = (short)505635999;
				short num2 = num;
				num = (short)1532060831;
				switch (num2 == num)
				{
				}
				num = (short)1797849088;
				if (num != 0)
				{
				}
				num = (short)1408040961;
				if (num != 0)
				{
				}
				num = (short)1260912640;
				short num3 = num;
				return this.trkPerPreferredSitesSystemIDRFSSID_A9240.Editable;
			}
			set
			{
				short num = (short)693536032;
				short num2 = num;
				num = (short)526157088;
				switch (num2 == num)
				{
				}
				num = (short)1725628417;
				if (num != 0)
				{
				}
				num = (short)1131479040;
				if (num != 0)
				{
				}
				num = (short)869335040;
				short num3 = num;
				this.trkPerPreferredSitesSystemIDRFSSID_A9240.Editable = value;
			}
		}

		// Token: 0x17000E50 RID: 3664
		// (get) Token: 0x06001C64 RID: 7268 RVA: 0x001C676C File Offset: 0x001C496C
		internal string TrkPerPreferredSitesSystemIDRFSSID_A9240_UILabel
		{
			get
			{
				short num = (short)798223418;
				short num2 = num;
				num = (short)1021570106;
				switch (num2 == num)
				{
				}
				num = (short)1390936065;
				if (num != 0)
				{
				}
				num = (short)1036779520;
				if (num != 0)
				{
				}
				num = (short)716832768;
				short num3 = num;
				return this.trkPerPreferredSitesSystemIDRFSSID_A9240.UIName;
			}
		}

		// Token: 0x17000E51 RID: 3665
		// (get) Token: 0x06001C65 RID: 7269 RVA: 0x001C6824 File Offset: 0x001C4A24
		// (set) Token: 0x06001C66 RID: 7270 RVA: 0x001C68DC File Offset: 0x001C4ADC
		internal bool TrkPerPreferredSitesSystemIDRFSSID_A9240_HiddenStatic
		{
			get
			{
				short num = (short)1187754246;
				short num2 = num;
				num = (short)315535622;
				switch (num2 == num)
				{
				}
				num = (short)1280573440;
				if (num != 0)
				{
				}
				num = (short)1492320257;
				if (num != 0)
				{
				}
				num = (short)1882390528;
				short num3 = num;
				return this.trkPerPreferredSitesSystemIDRFSSID_A9240.HiddenStatic;
			}
			set
			{
				short num = (short)1353792021;
				short num2 = num;
				num = (short)1110456853;
				switch (num2 == num)
				{
				}
				num = (short)1016463361;
				if (num != 0)
				{
				}
				num = (short)910426112;
				if (num != 0)
				{
				}
				num = (short)96862208;
				short num3 = num;
				this.trkPerPreferredSitesSystemIDRFSSID_A9240.HiddenStatic = value;
			}
		}

		// Token: 0x17000E52 RID: 3666
		// (get) Token: 0x06001C67 RID: 7271 RVA: 0x001C6994 File Offset: 0x001C4B94
		// (set) Token: 0x06001C68 RID: 7272 RVA: 0x001C6A48 File Offset: 0x001C4C48
		internal bool TrkPerPreferredSitesSystemIDRFSSID_A9240_HiddenDynamic
		{
			get
			{
				short num = (short)1562548680;
				short num2 = num;
				num = (short)212310472;
				switch (num2 == num)
				{
				}
				num = (short)974782465;
				if (num != 0)
				{
				}
				num = (short)546570240;
				if (num != 0)
				{
				}
				num = (short)505741312;
				short num3 = num;
				return this.trkPerPreferredSitesSystemIDRFSSID_A9240.HiddenDynamic;
			}
			set
			{
				short num = (short)1442381825;
				if (num != 0)
				{
				}
				num = (short)542646229;
				short num2 = num;
				num = (short)1165434837;
				switch (num2 == num)
				{
				}
				num = (short)397410304;
				if (num != 0)
				{
				}
				num = (short)1037500416;
				short num3 = num;
				this.trkPerPreferredSitesSystemIDRFSSID_A9240.HiddenDynamic = value;
			}
		}

		// Token: 0x17000E53 RID: 3667
		// (get) Token: 0x06001C69 RID: 7273 RVA: 0x001C6B00 File Offset: 0x001C4D00
		public bool TrkPerPreferredSitesSystemIDRFSSID_A9240_HasDiffs
		{
			get
			{
				short num = (short)1693646849;
				if (num != 0)
				{
				}
				num = (short)683079888;
				short num2 = num;
				num = (short)1607727312;
				switch (num2 == num)
				{
				}
				num = (short)1117716480;
				if (num != 0)
				{
				}
				num = (short)594411520;
				short num3 = num;
				return this.trkPerPreferredSitesSystemIDRFSSID_A9240._HasDiffs;
			}
		}

		// Token: 0x17000E54 RID: 3668
		// (get) Token: 0x06001C6A RID: 7274 RVA: 0x001C6BB4 File Offset: 0x001C4DB4
		// (set) Token: 0x06001C6B RID: 7275 RVA: 0x001C6C68 File Offset: 0x001C4E68
		public int TrkPerPreferredSitesSystemID_A19466Value
		{
			get
			{
				short num = (short)1567662148;
				short num2 = num;
				num = (short)2088673348;
				switch (num2 == num)
				{
				}
				num = (short)1273036801;
				if (num != 0)
				{
				}
				num = (short)1812267008;
				if (num != 0)
				{
				}
				num = (short)1105330176;
				short num3 = num;
				return this.trkPerPreferredSitesSystemID_A19466.Value;
			}
			set
			{
				short num = (short)1158749337;
				short num2 = num;
				num = (short)1438194841;
				switch (num2 == num)
				{
				}
				num = (short)489816064;
				if (num != 0)
				{
				}
				num = (short)82247681;
				if (num != 0)
				{
				}
				num = (short)769785856;
				short num3 = num;
				this.trkPerPreferredSitesSystemID_A19466.Value = value;
			}
		}

		// Token: 0x17000E55 RID: 3669
		// (get) Token: 0x06001C6C RID: 7276 RVA: 0x001C6D20 File Offset: 0x001C4F20
		public global::AcpBusinessLayer.AcpSimpleRangeField TrkPerPreferredSitesSystemID_A19466
		{
			get
			{
				short num = (short)109858393;
				short num2 = num;
				num = (short)993873497;
				switch (num2 == num)
				{
				}
				num = (short)755630080;
				if (num != 0)
				{
				}
				num = (short)215810049;
				if (num != 0)
				{
				}
				num = (short)1283194880;
				short num3 = num;
				return this.trkPerPreferredSitesSystemID_A19466;
			}
		}

		// Token: 0x17000E56 RID: 3670
		// (get) Token: 0x06001C6D RID: 7277 RVA: 0x001C6DCC File Offset: 0x001C4FCC
		// (set) Token: 0x06001C6E RID: 7278 RVA: 0x001C6E80 File Offset: 0x001C5080
		public string TrkPerPreferredSitesSystemID_A19466_UIValue
		{
			get
			{
				short num = (short)1785899525;
				short num2 = num;
				num = (short)1449634309;
				switch (num2 == num)
				{
				}
				num = (short)1161035777;
				if (num != 0)
				{
				}
				num = (short)1893793792;
				if (num != 0)
				{
				}
				num = (short)454885376;
				short num3 = num;
				return this.trkPerPreferredSitesSystemID_A19466.UIValue;
			}
			set
			{
				short num = (short)1364244342;
				short num2 = num;
				num = (short)35370870;
				switch (num2 == num)
				{
				}
				num = (short)873660416;
				if (num != 0)
				{
				}
				num = (short)847970305;
				if (num != 0)
				{
				}
				num = (short)1950220288;
				short num3 = num;
				this.trkPerPreferredSitesSystemID_A19466.UIValue = value;
			}
		}

		// Token: 0x17000E57 RID: 3671
		// (get) Token: 0x06001C6F RID: 7279 RVA: 0x001C6F34 File Offset: 0x001C5134
		// (set) Token: 0x06001C70 RID: 7280 RVA: 0x001C6FE8 File Offset: 0x001C51E8
		public string TrkPerPreferredSitesSystemID_A19466_HexUIValue
		{
			get
			{
				short num = (short)1053356391;
				short num2 = num;
				num = (short)144306535;
				switch (num2 == num)
				{
				}
				num = (short)2044919809;
				if (num != 0)
				{
				}
				num = (short)355663872;
				if (num != 0)
				{
				}
				num = (short)526188544;
				short num3 = num;
				return this.trkPerPreferredSitesSystemID_A19466.HexUIValue;
			}
			set
			{
				short num = (short)1699298516;
				short num2 = num;
				num = (short)484392148;
				switch (num2 == num)
				{
				}
				num = (short)811859968;
				if (num != 0)
				{
				}
				num = (short)1325858817;
				if (num != 0)
				{
				}
				num = (short)614072320;
				short num3 = num;
				this.trkPerPreferredSitesSystemID_A19466.HexUIValue = value;
			}
		}

		// Token: 0x17000E58 RID: 3672
		// (get) Token: 0x06001C71 RID: 7281 RVA: 0x001C709C File Offset: 0x001C529C
		// (set) Token: 0x06001C72 RID: 7282 RVA: 0x001C7150 File Offset: 0x001C5350
		internal int TrkPerPreferredSitesSystemID_A19466Min
		{
			get
			{
				short num = (short)1643118593;
				if (num != 0)
				{
				}
				num = (short)1459925966;
				short num2 = num;
				num = (short)1049670606;
				switch (num2 == num)
				{
				}
				num = (short)1402667008;
				if (num != 0)
				{
				}
				num = (short)1394212864;
				short num3 = num;
				return this.trkPerPreferredSitesSystemID_A19466.Min;
			}
			set
			{
				short num = (short)1147724607;
				short num2 = num;
				num = (short)1989468991;
				switch (num2 == num)
				{
				}
				num = (short)324534273;
				if (num != 0)
				{
				}
				num = (short)1807941632;
				if (num != 0)
				{
				}
				num = (short)611975168;
				short num3 = num;
				this.trkPerPreferredSitesSystemID_A19466.Min = value;
			}
		}

		// Token: 0x17000E59 RID: 3673
		// (get) Token: 0x06001C73 RID: 7283 RVA: 0x001C7204 File Offset: 0x001C5404
		// (set) Token: 0x06001C74 RID: 7284 RVA: 0x001C72B8 File Offset: 0x001C54B8
		internal int TrkPerPreferredSitesSystemID_A19466Max
		{
			get
			{
				short num = (short)576286565;
				short num2 = num;
				num = (short)2058252133;
				switch (num2 == num)
				{
				}
				num = (short)468320257;
				if (num != 0)
				{
				}
				num = (short)320929792;
				if (num != 0)
				{
				}
				num = (short)88801280;
				short num3 = num;
				return this.trkPerPreferredSitesSystemID_A19466.Max;
			}
			set
			{
				short num = (short)1709295097;
				short num2 = num;
				num = (short)770688505;
				switch (num2 == num)
				{
				}
				num = (short)705626113;
				if (num != 0)
				{
				}
				num = (short)382074880;
				if (num != 0)
				{
				}
				num = (short)1632763904;
				short num3 = num;
				this.trkPerPreferredSitesSystemID_A19466.Max = value;
			}
		}

		// Token: 0x17000E5A RID: 3674
		// (get) Token: 0x06001C75 RID: 7285 RVA: 0x001C7370 File Offset: 0x001C5570
		// (set) Token: 0x06001C76 RID: 7286 RVA: 0x001C7424 File Offset: 0x001C5624
		internal int TrkPerPreferredSitesSystemID_A19466Step
		{
			get
			{
				short num = (short)1919563489;
				short num2 = num;
				num = (short)1174877921;
				switch (num2 == num)
				{
				}
				num = (short)1268908032;
				if (num != 0)
				{
				}
				num = (short)605290497;
				if (num != 0)
				{
				}
				num = (short)74186752;
				short num3 = num;
				return this.trkPerPreferredSitesSystemID_A19466.StepSize;
			}
			set
			{
				short num = (short)86577061;
				short num2 = num;
				num = (short)505941925;
				switch (num2 == num)
				{
				}
				num = (short)1882456065;
				if (num != 0)
				{
				}
				num = (short)1625817088;
				if (num != 0)
				{
				}
				num = (short)738000896;
				short num3 = num;
				this.trkPerPreferredSitesSystemID_A19466.StepSize = value;
			}
		}

		// Token: 0x17000E5B RID: 3675
		// (get) Token: 0x06001C77 RID: 7287 RVA: 0x001C74DC File Offset: 0x001C56DC
		// (set) Token: 0x06001C78 RID: 7288 RVA: 0x001C7590 File Offset: 0x001C5790
		public bool TrkPerPreferredSitesSystemID_A19466_Applicable
		{
			get
			{
				short num = (short)1969071781;
				short num2 = num;
				num = (short)1610131109;
				switch (num2 == num)
				{
				}
				num = (short)1119617025;
				if (num != 0)
				{
				}
				num = (short)1322778624;
				if (num != 0)
				{
				}
				num = (short)1437532160;
				short num3 = num;
				return this.trkPerPreferredSitesSystemID_A19466.Applicable;
			}
			set
			{
				short num = (short)1653787587;
				short num2 = num;
				num = (short)1620822979;
				switch (num2 == num)
				{
				}
				num = (short)1901985793;
				if (num != 0)
				{
				}
				num = (short)1362558976;
				if (num != 0)
				{
				}
				num = (short)502923264;
				short num3 = num;
				this.trkPerPreferredSitesSystemID_A19466.Applicable = value;
			}
		}

		// Token: 0x17000E5C RID: 3676
		// (get) Token: 0x06001C79 RID: 7289 RVA: 0x001C7648 File Offset: 0x001C5848
		// (set) Token: 0x06001C7A RID: 7290 RVA: 0x001C76FC File Offset: 0x001C58FC
		public bool TrkPerPreferredSitesSystemID_A19466_Valid
		{
			get
			{
				short num = (short)970653697;
				if (num != 0)
				{
				}
				num = (short)1435898824;
				short num2 = num;
				num = (short)834474952;
				switch (num2 == num)
				{
				}
				num = (short)1478164480;
				if (num != 0)
				{
				}
				num = (short)1192493056;
				short num3 = num;
				return this.trkPerPreferredSitesSystemID_A19466.Valid;
			}
			set
			{
				short num = (short)858369183;
				short num2 = num;
				num = (short)560245919;
				switch (num2 == num)
				{
				}
				num = (short)1218445313;
				if (num != 0)
				{
				}
				num = (short)42270720;
				if (num != 0)
				{
				}
				num = (short)1718091776;
				short num3 = num;
				this.trkPerPreferredSitesSystemID_A19466.Valid = value;
			}
		}

		// Token: 0x17000E5D RID: 3677
		// (get) Token: 0x06001C7B RID: 7291 RVA: 0x001C77B0 File Offset: 0x001C59B0
		// (set) Token: 0x06001C7C RID: 7292 RVA: 0x001C7864 File Offset: 0x001C5A64
		public bool TrkPerPreferredSitesSystemID_A19466_Visible
		{
			get
			{
				short num = (short)557077317;
				short num2 = num;
				num = (short)262755141;
				switch (num2 == num)
				{
				}
				num = (short)1862729728;
				if (num != 0)
				{
				}
				num = (short)1685848065;
				if (num != 0)
				{
				}
				num = (short)1263665152;
				short num3 = num;
				return this.trkPerPreferredSitesSystemID_A19466.Visible;
			}
			set
			{
				short num = (short)376901001;
				short num2 = num;
				num = (short)1380257161;
				switch (num2 == num)
				{
				}
				num = (short)1054867457;
				if (num != 0)
				{
				}
				num = (short)1972633600;
				if (num != 0)
				{
				}
				num = (short)188088320;
				short num3 = num;
				this.trkPerPreferredSitesSystemID_A19466.Visible = value;
			}
		}

		// Token: 0x17000E5E RID: 3678
		// (get) Token: 0x06001C7D RID: 7293 RVA: 0x001C791C File Offset: 0x001C5B1C
		// (set) Token: 0x06001C7E RID: 7294 RVA: 0x001C79CC File Offset: 0x001C5BCC
		public bool TrkPerPreferredSitesSystemID_A19466_Editable
		{
			get
			{
				short num = (short)1046968048;
				short num2 = num;
				num = (short)735999728;
				switch (num2 == num)
				{
				}
				num = (short)998375425;
				if (num != 0)
				{
				}
				num = (short)2098266112;
				if (num != 0)
				{
				}
				num = (short)341639168;
				short num3 = num;
				return this.trkPerPreferredSitesSystemID_A19466.Editable;
			}
			set
			{
				short num = (short)1192908923;
				short num2 = num;
				num = (short)1559124091;
				switch (num2 == num)
				{
				}
				num = (short)1028653057;
				if (num != 0)
				{
				}
				num = (short)101187584;
				if (num != 0)
				{
				}
				num = (short)4980736;
				short num3 = num;
				this.trkPerPreferredSitesSystemID_A19466.Editable = value;
			}
		}

		// Token: 0x17000E5F RID: 3679
		// (get) Token: 0x06001C7F RID: 7295 RVA: 0x001C7A84 File Offset: 0x001C5C84
		internal string TrkPerPreferredSitesSystemID_A19466_UILabel
		{
			get
			{
				short num = (short)254906165;
				short num2 = num;
				num = (short)22646581;
				switch (num2 == num)
				{
				}
				num = (short)516947969;
				if (num != 0)
				{
				}
				num = (short)183435264;
				if (num != 0)
				{
				}
				num = (short)1088225280;
				short num3 = num;
				return this.trkPerPreferredSitesSystemID_A19466.UIName;
			}
		}

		// Token: 0x17000E60 RID: 3680
		// (get) Token: 0x06001C80 RID: 7296 RVA: 0x001C7B38 File Offset: 0x001C5D38
		// (set) Token: 0x06001C81 RID: 7297 RVA: 0x001C7BEC File Offset: 0x001C5DEC
		internal bool TrkPerPreferredSitesSystemID_A19466_HiddenStatic
		{
			get
			{
				short num = (short)1168366644;
				short num2 = num;
				num = (short)216194100;
				switch (num2 == num)
				{
				}
				num = (short)1995833344;
				if (num != 0)
				{
				}
				num = (short)1408565249;
				if (num != 0)
				{
				}
				num = (short)1690304512;
				short num3 = num;
				return this.trkPerPreferredSitesSystemID_A19466.HiddenStatic;
			}
			set
			{
				short num = (short)1493430963;
				short num2 = num;
				num = (short)1189868211;
				switch (num2 == num)
				{
				}
				num = (short)846790656;
				if (num != 0)
				{
				}
				num = (short)231800833;
				if (num != 0)
				{
				}
				num = (short)788332544;
				short num3 = num;
				this.trkPerPreferredSitesSystemID_A19466.HiddenStatic = value;
			}
		}

		// Token: 0x17000E61 RID: 3681
		// (get) Token: 0x06001C82 RID: 7298 RVA: 0x001C7CA0 File Offset: 0x001C5EA0
		// (set) Token: 0x06001C83 RID: 7299 RVA: 0x001C7D54 File Offset: 0x001C5F54
		internal bool TrkPerPreferredSitesSystemID_A19466_HiddenDynamic
		{
			get
			{
				short num = (short)1112393859;
				short num2 = num;
				num = (short)531089539;
				switch (num2 == num)
				{
				}
				num = (short)1739784193;
				if (num != 0)
				{
				}
				num = (short)1600061440;
				if (num != 0)
				{
				}
				num = (short)586416128;
				short num3 = num;
				return this.trkPerPreferredSitesSystemID_A19466.HiddenDynamic;
			}
			set
			{
				short num = (short)2024593611;
				short num2 = num;
				num = (short)1066391755;
				switch (num2 == num)
				{
				}
				num = (short)801767425;
				if (num != 0)
				{
				}
				num = (short)2096037888;
				if (num != 0)
				{
				}
				num = (short)643956736;
				short num3 = num;
				this.trkPerPreferredSitesSystemID_A19466.HiddenDynamic = value;
			}
		}

		// Token: 0x17000E62 RID: 3682
		// (get) Token: 0x06001C84 RID: 7300 RVA: 0x001C7E08 File Offset: 0x001C6008
		public bool TrkPerPreferredSitesSystemID_A19466_HasDiffs
		{
			get
			{
				short num = (short)1011021168;
				short num2 = num;
				num = (short)495646064;
				switch (num2 == num)
				{
				}
				num = (short)310968321;
				if (num != 0)
				{
				}
				num = (short)2023686144;
				if (num != 0)
				{
				}
				num = (short)544997376;
				short num3 = num;
				return this.trkPerPreferredSitesSystemID_A19466._HasDiffs;
			}
		}

		// Token: 0x17000E63 RID: 3683
		// (get) Token: 0x06001C85 RID: 7301 RVA: 0x001C7EC0 File Offset: 0x001C60C0
		// (set) Token: 0x06001C86 RID: 7302 RVA: 0x001C7F74 File Offset: 0x001C6174
		public int TrkPerPreferredSitesRASWACNID_A20445Value
		{
			get
			{
				short num = (short)2134048094;
				short num2 = num;
				num = (short)908197214;
				switch (num2 == num)
				{
				}
				num = (short)1358168065;
				if (num != 0)
				{
				}
				num = (short)2045116416;
				if (num != 0)
				{
				}
				num = (short)1739390976;
				short num3 = num;
				return this.trkPerPreferredSitesRASWACNID_A20445.Value;
			}
			set
			{
				short num = (short)1271267329;
				if (num != 0)
				{
				}
				num = (short)543347520;
				short num2 = num;
				num = (short)873190208;
				switch (num2 == num)
				{
				}
				num = (short)1619918848;
				if (num != 0)
				{
				}
				num = (short)311951360;
				short num3 = num;
				this.trkPerPreferredSitesRASWACNID_A20445.Value = value;
			}
		}

		// Token: 0x17000E64 RID: 3684
		// (get) Token: 0x06001C87 RID: 7303 RVA: 0x001C8028 File Offset: 0x001C6228
		public global::AcpBusinessLayer.AcpSimpleRangeField TrkPerPreferredSitesRASWACNID_A20445
		{
			get
			{
				short num = (short)464614475;
				short num2 = num;
				num = (short)1309111371;
				switch (num2 == num)
				{
				}
				num = (short)198967297;
				if (num != 0)
				{
				}
				num = (short)2037579776;
				if (num != 0)
				{
				}
				num = (short)1638334464;
				short num3 = num;
				return this.trkPerPreferredSitesRASWACNID_A20445;
			}
		}

		// Token: 0x17000E65 RID: 3685
		// (get) Token: 0x06001C88 RID: 7304 RVA: 0x001C80D8 File Offset: 0x001C62D8
		// (set) Token: 0x06001C89 RID: 7305 RVA: 0x001C818C File Offset: 0x001C638C
		public string TrkPerPreferredSitesRASWACNID_A20445_UIValue
		{
			get
			{
				short num = (short)1553643735;
				short num2 = num;
				num = (short)211335383;
				switch (num2 == num)
				{
				}
				num = (short)1241972737;
				if (num != 0)
				{
				}
				num = (short)1967259648;
				if (num != 0)
				{
				}
				num = (short)724041728;
				short num3 = num;
				return this.trkPerPreferredSitesRASWACNID_A20445.UIValue;
			}
			set
			{
				short num = (short)1711864870;
				short num2 = num;
				num = (short)466091046;
				switch (num2 == num)
				{
				}
				num = (short)1344864257;
				if (num != 0)
				{
				}
				num = (short)709492736;
				if (num != 0)
				{
				}
				num = (short)57278464;
				short num3 = num;
				this.trkPerPreferredSitesRASWACNID_A20445.UIValue = value;
			}
		}

		// Token: 0x17000E66 RID: 3686
		// (get) Token: 0x06001C8A RID: 7306 RVA: 0x001C8240 File Offset: 0x001C6440
		// (set) Token: 0x06001C8B RID: 7307 RVA: 0x001C82F4 File Offset: 0x001C64F4
		public string TrkPerPreferredSitesRASWACNID_A20445_HexUIValue
		{
			get
			{
				short num = (short)1337255997;
				short num2 = num;
				num = (short)2102585405;
				switch (num2 == num)
				{
				}
				num = (short)1977810945;
				if (num != 0)
				{
				}
				num = (short)25362432;
				if (num != 0)
				{
				}
				num = (short)29425664;
				short num3 = num;
				return this.trkPerPreferredSitesRASWACNID_A20445.HexUIValue;
			}
			set
			{
				short num = (short)1836187649;
				if (num != 0)
				{
				}
				num = (short)1829965055;
				short num2 = num;
				num = (short)606997759;
				switch (num2 == num)
				{
				}
				num = (short)1780547584;
				if (num != 0)
				{
				}
				num = (short)451477504;
				short num3 = num;
				this.trkPerPreferredSitesRASWACNID_A20445.HexUIValue = value;
			}
		}

		// Token: 0x17000E67 RID: 3687
		// (get) Token: 0x06001C8C RID: 7308 RVA: 0x001C83AC File Offset: 0x001C65AC
		// (set) Token: 0x06001C8D RID: 7309 RVA: 0x001C8460 File Offset: 0x001C6660
		internal int TrkPerPreferredSitesRASWACNID_A20445Min
		{
			get
			{
				short num = (short)1082327041;
				if (num != 0)
				{
				}
				num = (short)1827280265;
				short num2 = num;
				num = (short)995628425;
				switch (num2 == num)
				{
				}
				num = (short)1432289280;
				if (num != 0)
				{
				}
				num = (short)1694892032;
				short num3 = num;
				return this.trkPerPreferredSitesRASWACNID_A20445.Min;
			}
			set
			{
				short num = (short)519530309;
				short num2 = num;
				num = (short)1901946693;
				switch (num2 == num)
				{
				}
				num = (short)310509569;
				if (num != 0)
				{
				}
				num = (short)1476853760;
				if (num != 0)
				{
				}
				num = (short)42336256;
				short num3 = num;
				this.trkPerPreferredSitesRASWACNID_A20445.Min = value;
			}
		}

		// Token: 0x17000E68 RID: 3688
		// (get) Token: 0x06001C8E RID: 7310 RVA: 0x001C8518 File Offset: 0x001C6718
		// (set) Token: 0x06001C8F RID: 7311 RVA: 0x001C85CC File Offset: 0x001C67CC
		internal int TrkPerPreferredSitesRASWACNID_A20445Max
		{
			get
			{
				short num = (short)1847382690;
				short num2 = num;
				num = (short)369873570;
				switch (num2 == num)
				{
				}
				num = (short)1742602241;
				if (num != 0)
				{
				}
				num = (short)1112276992;
				if (num != 0)
				{
				}
				num = (short)1998127104;
				short num3 = num;
				return this.trkPerPreferredSitesRASWACNID_A20445.Max;
			}
			set
			{
				short num = (short)1887317352;
				short num2 = num;
				num = (short)473705832;
				switch (num2 == num)
				{
				}
				num = (short)1844183041;
				if (num != 0)
				{
				}
				num = (short)1790246912;
				if (num != 0)
				{
				}
				num = (short)1446248448;
				short num3 = num;
				this.trkPerPreferredSitesRASWACNID_A20445.Max = value;
			}
		}

		// Token: 0x17000E69 RID: 3689
		// (get) Token: 0x06001C90 RID: 7312 RVA: 0x001C8680 File Offset: 0x001C6880
		// (set) Token: 0x06001C91 RID: 7313 RVA: 0x001C8734 File Offset: 0x001C6934
		internal int TrkPerPreferredSitesRASWACNID_A20445Step
		{
			get
			{
				short num = (short)848822273;
				if (num != 0)
				{
				}
				num = (short)231612269;
				short num2 = num;
				num = (short)2000494445;
				switch (num2 == num)
				{
				}
				num = (short)1357119488;
				if (num != 0)
				{
				}
				num = (short)1492647936;
				short num3 = num;
				return this.trkPerPreferredSitesRASWACNID_A20445.StepSize;
			}
			set
			{
				short num = (short)149517293;
				short num2 = num;
				num = (short)1978430445;
				switch (num2 == num)
				{
				}
				num = (short)682164225;
				if (num != 0)
				{
				}
				num = (short)276037632;
				if (num != 0)
				{
				}
				num = (short)1179648000;
				short num3 = num;
				this.trkPerPreferredSitesRASWACNID_A20445.StepSize = value;
			}
		}

		// Token: 0x17000E6A RID: 3690
		// (get) Token: 0x06001C92 RID: 7314 RVA: 0x001C87E8 File Offset: 0x001C69E8
		// (set) Token: 0x06001C93 RID: 7315 RVA: 0x001C889C File Offset: 0x001C6A9C
		public bool TrkPerPreferredSitesRASWACNID_A20445_Applicable
		{
			get
			{
				short num = (short)1135436841;
				short num2 = num;
				num = (short)1565221929;
				switch (num2 == num)
				{
				}
				num = (short)1666187265;
				if (num != 0)
				{
				}
				num = (short)1246953472;
				if (num != 0)
				{
				}
				num = (short)592052224;
				short num3 = num;
				return this.trkPerPreferredSitesRASWACNID_A20445.Applicable;
			}
			set
			{
				short num = (short)33789810;
				short num2 = num;
				num = (short)252417906;
				switch (num2 == num)
				{
				}
				num = (short)2144206849;
				if (num != 0)
				{
				}
				num = (short)1599275008;
				if (num != 0)
				{
				}
				num = (short)610140160;
				short num3 = num;
				this.trkPerPreferredSitesRASWACNID_A20445.Applicable = value;
			}
		}

		// Token: 0x17000E6B RID: 3691
		// (get) Token: 0x06001C94 RID: 7316 RVA: 0x001C8950 File Offset: 0x001C6B50
		// (set) Token: 0x06001C95 RID: 7317 RVA: 0x001C8A04 File Offset: 0x001C6C04
		public bool TrkPerPreferredSitesRASWACNID_A20445_Valid
		{
			get
			{
				short num = (short)2002190074;
				short num2 = num;
				num = (short)1517944570;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2020343808;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)223477761;
				if (num != 0)
				{
				}
				num = (short)1849950208;
				if (num != 0)
				{
				}
				return this.trkPerPreferredSitesRASWACNID_A20445.Valid;
			}
			set
			{
				short num = (short)686609182;
				short num2 = num;
				num = (short)1615319838;
				switch (num2 == num)
				{
				default:
				{
					num = (short)628031488;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1233321984;
				if (num != 0)
				{
				}
				num = (short)396886017;
				if (num != 0)
				{
				}
				this.trkPerPreferredSitesRASWACNID_A20445.Valid = value;
			}
		}

		// Token: 0x17000E6C RID: 3692
		// (get) Token: 0x06001C96 RID: 7318 RVA: 0x001C8AB8 File Offset: 0x001C6CB8
		// (set) Token: 0x06001C97 RID: 7319 RVA: 0x001C8B6C File Offset: 0x001C6D6C
		public bool TrkPerPreferredSitesRASWACNID_A20445_Visible
		{
			get
			{
				short num = (short)2016869516;
				short num2 = num;
				num = (short)1193147532;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1675100160;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1553661953;
				if (num != 0)
				{
				}
				num = (short)809369600;
				if (num != 0)
				{
				}
				return this.trkPerPreferredSitesRASWACNID_A20445.Visible;
			}
			set
			{
				short num = (short)178520065;
				if (num != 0)
				{
				}
				num = (short)441843712;
				short num2 = num;
				num = (short)1592389147;
				short num3 = num;
				num = (short)692383259;
				switch (num3 == num)
				{
				}
				num = (short)105119744;
				if (num != 0)
				{
				}
				this.trkPerPreferredSitesRASWACNID_A20445.Visible = value;
			}
		}

		// Token: 0x17000E6D RID: 3693
		// (get) Token: 0x06001C98 RID: 7320 RVA: 0x001C8C24 File Offset: 0x001C6E24
		// (set) Token: 0x06001C99 RID: 7321 RVA: 0x001C8CD4 File Offset: 0x001C6ED4
		public bool TrkPerPreferredSitesRASWACNID_A20445_Editable
		{
			get
			{
				short num = (short)52995632;
				short num2 = num;
				num = (short)1106683440;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1491795968;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1098186752;
				if (num != 0)
				{
				}
				num = (short)1411186689;
				if (num != 0)
				{
				}
				return this.trkPerPreferredSitesRASWACNID_A20445.Editable;
			}
			set
			{
				short num = (short)1366801913;
				short num2 = num;
				num = (short)215662073;
				switch (num2 == num)
				{
				default:
				{
					num = (short)13434880;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)41287681;
				if (num != 0)
				{
				}
				num = (short)2031747072;
				if (num != 0)
				{
				}
				this.trkPerPreferredSitesRASWACNID_A20445.Editable = value;
			}
		}

		// Token: 0x17000E6E RID: 3694
		// (get) Token: 0x06001C9A RID: 7322 RVA: 0x001C8D88 File Offset: 0x001C6F88
		internal string TrkPerPreferredSitesRASWACNID_A20445_UILabel
		{
			get
			{
				short num = (short)268500993;
				if (num != 0)
				{
				}
				num = (short)18153472;
				short num2 = num;
				num = (short)557168988;
				short num3 = num;
				num = (short)1248704860;
				switch (num3 == num)
				{
				}
				num = (short)2133721088;
				if (num != 0)
				{
				}
				return this.trkPerPreferredSitesRASWACNID_A20445.UIName;
			}
		}

		// Token: 0x17000E6F RID: 3695
		// (get) Token: 0x06001C9B RID: 7323 RVA: 0x001C8E3C File Offset: 0x001C703C
		// (set) Token: 0x06001C9C RID: 7324 RVA: 0x001C8EF0 File Offset: 0x001C70F0
		internal bool TrkPerPreferredSitesRASWACNID_A20445_HiddenStatic
		{
			get
			{
				short num = (short)473169921;
				if (num != 0)
				{
				}
				num = (short)222101504;
				short num2 = num;
				num = (short)921819249;
				short num3 = num;
				num = (short)141351025;
				switch (num3 == num)
				{
				}
				num = (short)948961280;
				if (num != 0)
				{
				}
				return this.trkPerPreferredSitesRASWACNID_A20445.HiddenStatic;
			}
			set
			{
				short num = (short)1987970151;
				short num2 = num;
				num = (short)1009845351;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1796800512;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)50855937;
				if (num != 0)
				{
				}
				num = (short)1596981248;
				if (num != 0)
				{
				}
				this.trkPerPreferredSitesRASWACNID_A20445.HiddenStatic = value;
			}
		}

		// Token: 0x17000E70 RID: 3696
		// (get) Token: 0x06001C9D RID: 7325 RVA: 0x001C8FA8 File Offset: 0x001C71A8
		// (set) Token: 0x06001C9E RID: 7326 RVA: 0x001C905C File Offset: 0x001C725C
		internal bool TrkPerPreferredSitesRASWACNID_A20445_HiddenDynamic
		{
			get
			{
				short num = (short)930604751;
				short num2 = num;
				num = (short)1550182095;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1790246912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)968884225;
				if (num != 0)
				{
				}
				num = (short)1037238272;
				if (num != 0)
				{
				}
				return this.trkPerPreferredSitesRASWACNID_A20445.HiddenDynamic;
			}
			set
			{
				short num = (short)368806974;
				short num2 = num;
				num = (short)950373438;
				switch (num2 == num)
				{
				default:
				{
					num = (short)604438528;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1106837505;
				if (num != 0)
				{
				}
				num = (short)1093730304;
				if (num != 0)
				{
				}
				this.trkPerPreferredSitesRASWACNID_A20445.HiddenDynamic = value;
			}
		}

		// Token: 0x17000E71 RID: 3697
		// (get) Token: 0x06001C9F RID: 7327 RVA: 0x001C9110 File Offset: 0x001C7310
		public bool TrkPerPreferredSitesRASWACNID_A20445_HasDiffs
		{
			get
			{
				short num = (short)1518512357;
				short num2 = num;
				num = (short)595699941;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2109407232;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)655949824;
				if (num != 0)
				{
				}
				num = (short)1944453121;
				if (num != 0)
				{
				}
				return this.trkPerPreferredSitesRASWACNID_A20445._HasDiffs;
			}
		}

		// Token: 0x17000E72 RID: 3698
		// (get) Token: 0x06001CA0 RID: 7328 RVA: 0x001C91C4 File Offset: 0x001C73C4
		// (set) Token: 0x06001CA1 RID: 7329 RVA: 0x001C927C File Offset: 0x001C747C
		public int TrkPerPreferredSitesWildcard_A43586Value
		{
			get
			{
				short num = (short)1413062741;
				short num2 = num;
				num = (short)357736533;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1343750144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)744620033;
				if (num != 0)
				{
				}
				num = (short)1805516800;
				if (num != 0)
				{
				}
				return this.trkPerPreferredSitesWildcard_A43586.Value;
			}
			set
			{
				short num = (short)589955073;
				if (num != 0)
				{
				}
				num = (short)251330560;
				short num2 = num;
				num = (short)1894977806;
				short num3 = num;
				num = (short)805572878;
				switch (num3 == num)
				{
				}
				num = (short)1454833664;
				if (num != 0)
				{
				}
				this.trkPerPreferredSitesWildcard_A43586.Value = value;
			}
		}

		// Token: 0x17000E73 RID: 3699
		// (get) Token: 0x06001CA2 RID: 7330 RVA: 0x001C9330 File Offset: 0x001C7530
		// (set) Token: 0x06001CA3 RID: 7331 RVA: 0x001C93E4 File Offset: 0x001C75E4
		public string TrkPerPreferredSitesWildcard_A43586_UIValue
		{
			get
			{
				short num = (short)585498625;
				if (num != 0)
				{
				}
				num = (short)692191232;
				short num2 = num;
				num = (short)1065893988;
				short num3 = num;
				num = (short)54345828;
				switch (num3 == num)
				{
				}
				num = (short)1612382208;
				if (num != 0)
				{
				}
				return this.trkPerPreferredSitesWildcard_A43586.UIValue;
			}
			set
			{
				short num = (short)414014373;
				short num2 = num;
				num = (short)1038375845;
				switch (num2 == num)
				{
				default:
				{
					num = (short)35651584;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)399704064;
				if (num != 0)
				{
				}
				num = (short)1379139585;
				if (num != 0)
				{
				}
				this.trkPerPreferredSitesWildcard_A43586.UIValue = value;
			}
		}

		// Token: 0x17000E74 RID: 3700
		// (get) Token: 0x06001CA4 RID: 7332 RVA: 0x001C949C File Offset: 0x001C769C
		public global::AcpBusinessLayer.AcpListField TrkPerPreferredSitesWildcard_A43586
		{
			get
			{
				short num = (short)753787266;
				short num2 = num;
				num = (short)441049474;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1769799680;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)589824001;
				if (num != 0)
				{
				}
				num = (short)520749056;
				if (num != 0)
				{
				}
				return this.trkPerPreferredSitesWildcard_A43586;
			}
		}

		// Token: 0x17000E75 RID: 3701
		// (get) Token: 0x06001CA5 RID: 7333 RVA: 0x001C954C File Offset: 0x001C774C
		// (set) Token: 0x06001CA6 RID: 7334 RVA: 0x001C9604 File Offset: 0x001C7804
		public bool TrkPerPreferredSitesWildcard_A43586_Applicable
		{
			get
			{
				short num = (short)1344986794;
				short num2 = num;
				num = (short)1617288874;
				switch (num2 == num)
				{
				default:
				{
					num = (short)209584128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)411172865;
				if (num != 0)
				{
				}
				num = (short)177340416;
				if (num != 0)
				{
				}
				return this.trkPerPreferredSitesWildcard_A43586.Applicable;
			}
			set
			{
				short num = (short)1339227127;
				short num2 = num;
				num = (short)2130115575;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1221066752;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1660616704;
				if (num != 0)
				{
				}
				num = (short)1466499073;
				if (num != 0)
				{
				}
				this.trkPerPreferredSitesWildcard_A43586.Applicable = value;
			}
		}

		// Token: 0x17000E76 RID: 3702
		// (get) Token: 0x06001CA7 RID: 7335 RVA: 0x001C96B8 File Offset: 0x001C78B8
		// (set) Token: 0x06001CA8 RID: 7336 RVA: 0x001C9770 File Offset: 0x001C7970
		public bool TrkPerPreferredSitesWildcard_A43586_Valid
		{
			get
			{
				short num = (short)1402027893;
				short num2 = num;
				num = (short)744701813;
				switch (num2 == num)
				{
				default:
				{
					num = (short)776994816;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1591083009;
				if (num != 0)
				{
				}
				num = (short)386269184;
				if (num != 0)
				{
				}
				return this.trkPerPreferredSitesWildcard_A43586.Valid;
			}
			set
			{
				short num = (short)279437454;
				short num2 = num;
				num = (short)916316302;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1111097344;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2073231360;
				if (num != 0)
				{
				}
				num = (short)913113089;
				if (num != 0)
				{
				}
				this.trkPerPreferredSitesWildcard_A43586.Valid = value;
			}
		}

		// Token: 0x17000E77 RID: 3703
		// (get) Token: 0x06001CA9 RID: 7337 RVA: 0x001C9824 File Offset: 0x001C7A24
		// (set) Token: 0x06001CAA RID: 7338 RVA: 0x001C98D8 File Offset: 0x001C7AD8
		public bool TrkPerPreferredSitesWildcard_A43586_Visible
		{
			get
			{
				short num = (short)14839539;
				short num2 = num;
				num = (short)414478067;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1710686208;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)677838848;
				if (num != 0)
				{
				}
				num = (short)92864513;
				if (num != 0)
				{
				}
				return this.trkPerPreferredSitesWildcard_A43586.Visible;
			}
			set
			{
				short num = (short)669759117;
				short num2 = num;
				num = (short)1743763085;
				switch (num2 == num)
				{
				default:
				{
					num = (short)715063296;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)132579329;
				if (num != 0)
				{
				}
				num = (short)1701117952;
				if (num != 0)
				{
				}
				this.trkPerPreferredSitesWildcard_A43586.Visible = value;
			}
		}

		// Token: 0x17000E78 RID: 3704
		// (get) Token: 0x06001CAB RID: 7339 RVA: 0x001C9990 File Offset: 0x001C7B90
		// (set) Token: 0x06001CAC RID: 7340 RVA: 0x001C9A48 File Offset: 0x001C7C48
		public bool TrkPerPreferredSitesWildcard_A43586_Editable
		{
			get
			{
				short num = (short)1029163475;
				short num2 = num;
				num = (short)2131085779;
				switch (num2 == num)
				{
				default:
				{
					num = (short)988479488;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)56492032;
				if (num != 0)
				{
				}
				num = (short)1070268417;
				if (num != 0)
				{
				}
				return this.trkPerPreferredSitesWildcard_A43586.Editable;
			}
			set
			{
				short num = (short)1271025316;
				short num2 = num;
				num = (short)602164900;
				switch (num2 == num)
				{
				default:
				{
					num = (short)689963008;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1439956993;
				if (num != 0)
				{
				}
				num = (short)1588592640;
				if (num != 0)
				{
				}
				this.trkPerPreferredSitesWildcard_A43586.Editable = value;
			}
		}

		// Token: 0x17000E79 RID: 3705
		// (get) Token: 0x06001CAD RID: 7341 RVA: 0x001C9B00 File Offset: 0x001C7D00
		internal string TrkPerPreferredSitesWildcard_A43586_UILabel
		{
			get
			{
				short num = (short)545718950;
				short num2 = num;
				num = (short)2066088614;
				switch (num2 == num)
				{
				default:
				{
					num = (short)998637568;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)592445441;
				if (num != 0)
				{
				}
				num = (short)1557528576;
				if (num != 0)
				{
				}
				return this.trkPerPreferredSitesWildcard_A43586.UIName;
			}
		}

		// Token: 0x17000E7A RID: 3706
		// (get) Token: 0x06001CAE RID: 7342 RVA: 0x001C9BB4 File Offset: 0x001C7DB4
		// (set) Token: 0x06001CAF RID: 7343 RVA: 0x001C9C68 File Offset: 0x001C7E68
		internal bool TrkPerPreferredSitesWildcard_A43586_HiddenStatic
		{
			get
			{
				short num = (short)1214746908;
				short num2 = num;
				num = (short)2091815196;
				switch (num2 == num)
				{
				default:
				{
					num = (short)50397184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)792526849;
				if (num != 0)
				{
				}
				num = (short)1692729344;
				if (num != 0)
				{
				}
				return this.trkPerPreferredSitesWildcard_A43586.HiddenStatic;
			}
			set
			{
				short num = (short)1711957118;
				short num2 = num;
				num = (short)1906533502;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1012465664;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1761411073;
				if (num != 0)
				{
				}
				num = (short)158203904;
				if (num != 0)
				{
				}
				this.trkPerPreferredSitesWildcard_A43586.HiddenStatic = value;
			}
		}

		// Token: 0x17000E7B RID: 3707
		// (get) Token: 0x06001CB0 RID: 7344 RVA: 0x001C9D1C File Offset: 0x001C7F1C
		// (set) Token: 0x06001CB1 RID: 7345 RVA: 0x001C9DD0 File Offset: 0x001C7FD0
		internal bool TrkPerPreferredSitesWildcard_A43586_HiddenDynamic
		{
			get
			{
				short num = (short)299254054;
				short num2 = num;
				num = (short)1664827686;
				switch (num2 == num)
				{
				default:
				{
					num = (short)139526144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1711407105;
				if (num != 0)
				{
				}
				num = (short)1905262592;
				if (num != 0)
				{
				}
				return this.trkPerPreferredSitesWildcard_A43586.HiddenDynamic;
			}
			set
			{
				short num = (short)386170679;
				short num2 = num;
				num = (short)1460764471;
				switch (num2 == num)
				{
				default:
				{
					num = (short)435355648;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)639959040;
				if (num != 0)
				{
				}
				num = (short)890634241;
				if (num != 0)
				{
				}
				this.trkPerPreferredSitesWildcard_A43586.HiddenDynamic = value;
			}
		}

		// Token: 0x17000E7C RID: 3708
		// (get) Token: 0x06001CB2 RID: 7346 RVA: 0x001C9E84 File Offset: 0x001C8084
		public bool TrkPerPreferredSitesWildcard_A43586_HasDiffs
		{
			get
			{
				short num = (short)435565527;
				short num2 = num;
				num = (short)1093153751;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1966080;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1890320384;
				if (num != 0)
				{
				}
				num = (short)99811329;
				if (num != 0)
				{
				}
				return this.trkPerPreferredSitesWildcard_A43586._HasDiffs;
			}
		}

		// Token: 0x06001CB3 RID: 7347 RVA: 0x001C9F3C File Offset: 0x001C813C
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			short num2;
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)1990197249;
					if (num2 != 0)
					{
					}
					num2 = (short)778764290;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_AD;
				case 2:
				{
					if (base.ParentRecset.ContainerDoc == null)
					{
						goto IL_13E;
					}
					num2 = (short)1752013212;
					short num3 = num2;
					num2 = (short)1460967836;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_13E;
					default:
						num2 = (short)1217724416;
						if (num2 != 0)
						{
						}
						num2 = (short)151453699;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 3:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)1925709825;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (base.ParentRecset != null)
					{
						num2 = (short)1283129344;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_13E;
				}
				goto IL_24;
			}
			IL_AD:
			IL_13E:
			num2 = (short)819396608;
			short num4 = num2;
			return result;
			IL_24:
			result = null;
			num2 = (short)1976172548;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x040008FF RID: 2303
		private global::AcpBusinessLayer.AcpListField trkPerPreferredSitesPreferredStatus_A8734;

		// Token: 0x04000900 RID: 2304
		private global::AcpBusinessLayer.AcpSimpleRangeField trkPerPreferredSitesSiteID_A9151;

		// Token: 0x04000901 RID: 2305
		private global::AcpBusinessLayer.AcpSimpleRangeField trkPerPreferredSitesSystemIDRFSSID_A9240;

		// Token: 0x04000902 RID: 2306
		private global::AcpBusinessLayer.AcpSimpleRangeField trkPerPreferredSitesSystemID_A19466;

		// Token: 0x04000903 RID: 2307
		private global::AcpBusinessLayer.AcpSimpleRangeField trkPerPreferredSitesRASWACNID_A20445;

		// Token: 0x04000904 RID: 2308
		private global::AcpBusinessLayer.AcpListField trkPerPreferredSitesWildcard_A43586;
	}
}
