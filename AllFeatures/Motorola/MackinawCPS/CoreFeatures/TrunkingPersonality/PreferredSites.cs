using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality
{
	// Token: 0x020000C9 RID: 201
	[global::System.Serializable]
	public class PreferredSites : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06001BC6 RID: 7110 RVA: 0x001BEE30 File Offset: 0x001BD030
		public PreferredSites(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.PreferredSitesInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x06001BC7 RID: 7111 RVA: 0x001BEE70 File Offset: 0x001BD070
		protected PreferredSites(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06001BC8 RID: 7112 RVA: 0x001BEE88 File Offset: 0x001BD088
		public override void Init()
		{
			int a_ = 15;
			short num = (short)1739587584;
			short num2 = num;
			num = (short)2000927760;
			short num3 = num;
			num = (short)1046461456;
			switch (num3 == num)
			{
			}
			num = (short)1113915393;
			if (num != 0)
			{
			}
			num = (short)823984128;
			if (num != 0)
			{
			}
			this.trkPerPreferredSitesIgnoreSiteResourcePreference_A8239 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("蓏ꃑ뿓蛕뷗꣙賛곝藟蓡臣铥髧迩裫뷭駯蛱釳藵뇷鷹鋻釽狿朁圃漅簇漉帋欍挏紑愓搕笗缙䰛氝䔟䐡䄣吥䴧䐩伫䬭漯猱ళеଷ̹", a_), global::CommonResources.AcgResources.ID_IGNORESITERESOURCEPREFERENCE);
			this.trkPerPreferredSitesIgnoreSiteResourcePreference_A8239.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.trkPerPreferredSitesIgnoreSiteResourcePreference_A8239.DataTransferOrder = 44;
			this.trkPerPreferredSitesSiteListType_A43581 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("蓏ꃑ뿓蛕뷗꣙賛곝藟蓡臣铥髧迩裫뷭駯蛱釳藵꯷鏹裻鯽䳿欁眃爅將猉簋欍伏匑–┕ⴗ∙ⴛ", a_), global::CommonResources.AcgResources.ID_SITELISTTYPE, global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.LOVs.TrkPerPreferredSitesSiteListType_A43581LovStrs);
			this.trkPerPreferredSitesSiteListType_A43581.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.trkPerPreferredSitesSiteListType_A43581.DataTransferOrder = 74;
			this.trkPerPreferredSitesAllowEmergencyAtBlockedSite_44910 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("蓏ꃑ뿓蛕뷗꣙賛곝藟蓡臣铥髧迩裫뷭駯蛱釳藵맷雹郻釽矿䜁椃挅稇洉椋怍猏欑唓戕娗瘙猛紝䬟䜡䀣甥䄧帩䤫焭Яرളܵ࠷", a_), global::CommonResources.AcgResources.ID_ALLOW_EMERGENCY_AT_BLOCKED_SITE);
			this.trkPerPreferredSitesAllowEmergencyAtBlockedSite_44910.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.trkPerPreferredSitesAllowEmergencyAtBlockedSite_44910.DataTransferOrder = 75;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("胏ꃑ뇓냕뷗꣙껛믝蓟싡럣迥鳧迩鿫", a_);
			base.Id = 10182;
			base.UIName = global::CommonResources.AcgResources.ID_PREFERREDSITES;
			base.DataTransferOrder = 6;
		}

		// Token: 0x06001BC9 RID: 7113 RVA: 0x001BF020 File Offset: 0x001BD220
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 13;
			short num = (short)17104896;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_62;
					}
					continue;
				case 1:
					this.trkPerPreferredSitesAllowEmergencyAtBlockedSite_44910 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("髍ꋏ맑蓓돕꫗諙껛믝蛟蟡難铥跧軩뿫蟭蓯韱蟳럵铷雹鏻觽䗿漁愃琅漇漉戋洍椏匑怓吕琗甙缛甝䔟䘡眣伥尧伩猫ᨭЯ଱Գص", a_), global::CommonResources.AcgResources.ID_ALLOW_EMERGENCY_AT_BLOCKED_SITE);
					this.trkPerPreferredSitesAllowEmergencyAtBlockedSite_44910.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.trkPerPreferredSitesAllowEmergencyAtBlockedSite_44910.DataTransferOrder = 75;
					num = (short)1682046979;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_2A6;
				case 3:
					goto IL_267;
				case 4:
					num = (short)5439498;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					this.trkPerPreferredSitesIgnoreSiteResourcePreference_A8239 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("髍ꋏ맑蓓돕꫗諙껛믝蛟蟡難铥跧軩뿫蟭蓯韱蟳뿵鿷铹鏻賽旿儁洃爅洇堉椋納缏朑易甕紗䨙減笝䘟䜡嘣䌥䘧䤩䤫焭焯਱سԵķ", a_), global::CommonResources.AcgResources.ID_IGNORESITERESOURCEPREFERENCE);
					this.trkPerPreferredSitesIgnoreSiteResourcePreference_A8239.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.trkPerPreferredSitesIgnoreSiteResourcePreference_A8239.DataTransferOrder = 44;
					num = (short)1313800203;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
				{
					num = (short)1058799616;
					short num3 = num;
					this.trkPerPreferredSitesSiteListType_A43581 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("髍ꋏ맑蓓돕꫗諙껛믝蛟蟡難铥跧軩뿫蟭蓯韱蟳ꗵ釷軹駻닽槿焁瀃刅焇稉椋儍儏☑✓⌕‗⬙", a_), global::CommonResources.AcgResources.ID_SITELISTTYPE, global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.LOVs.TrkPerPreferredSitesSiteListType_A43581LovStrs);
					this.trkPerPreferredSitesSiteListType_A43581.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.trkPerPreferredSitesSiteListType_A43581.DataTransferOrder = 74;
					num = (short)118882306;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 7:
				{
					num = (short)1142804837;
					short num4 = num;
					num = (short)604623205;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_284;
					default:
						num = (short)1984233472;
						if (num != 0)
						{
						}
						num = (short)1820721160;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 8:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("髍ꋏ맑蓓돕꫗諙껛믝蛟蟡難铥跧軩뿫蟭蓯韱蟳뿵鿷铹鏻賽旿儁洃爅洇堉椋納缏朑易甕紗䨙減笝䘟䜡嘣䌥䘧䤩䤫焭焯਱سԵķ", a_)))
					{
						num = (short)1744961541;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_DF;
				case 9:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("髍ꋏ맑蓓돕꫗諙껛믝蛟蟡難铥跧軩뿫蟭蓯韱蟳럵铷雹鏻觽䗿漁愃琅漇漉戋洍椏匑怓吕琗甙缛甝䔟䘡眣伥尧伩猫ᨭЯ଱Գص", a_)))
					{
						num = (short)614662145;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_346;
				case 10:
					goto IL_284;
				case 11:
					goto IL_DF;
				case 12:
					num = (short)621346817;
					if (num != 0)
					{
					}
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("髍ꋏ맑蓓돕꫗諙껛믝蛟蟡難铥跧軩뿫蟭蓯韱蟳ꗵ釷軹駻닽槿焁瀃刅焇稉椋儍儏☑✓⌕‗⬙", a_)))
					{
						num = (short)377028614;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2A6;
				}
				IL_62:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)60751876;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_DF:
				num = (short)221052940;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_284:
				if (producerFields != null)
				{
					num = (short)1693974535;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_2A6:
				num = (short)171442185;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_267:
			IL_346:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("黍ꋏ럑닓돕꫗꣙맛뫝샟뇡跣鋥跧駩", a_);
			base.Id = 10182;
			base.UIName = global::CommonResources.AcgResources.ID_PREFERREDSITES;
			base.DataTransferOrder = 6;
		}

		// Token: 0x06001BCA RID: 7114 RVA: 0x001BF3A4 File Offset: 0x001BD5A4
		public override void PopulateReferences()
		{
			short num = (short)2087153314;
			short num2 = num;
			num = (short)463761058;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1569390592;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)892928001;
			if (num != 0)
			{
			}
			num = (short)1062535168;
			if (num != 0)
			{
			}
		}

		// Token: 0x06001BCB RID: 7115 RVA: 0x001BF44C File Offset: 0x001BD64C
		public override void DropReferences()
		{
			short num = (short)447961349;
			short num2 = num;
			num = (short)1482053893;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2095316992;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)21364737;
			if (num != 0)
			{
			}
			num = (short)1569390592;
			if (num != 0)
			{
			}
		}

		// Token: 0x06001BCC RID: 7116 RVA: 0x001BF4F4 File Offset: 0x001BD6F4
		public override void SetConstraints()
		{
			short num = (short)866998629;
			short num2 = num;
			num = (short)1401903461;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1557790720;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)588775425;
			if (num != 0)
			{
			}
			num = (short)1021444096;
			if (num != 0)
			{
			}
			this.trkPerPreferredSitesIgnoreSiteResourcePreference_A8239.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.ConTrkSysAmssIsSmartZone);
			this.trkPerPreferredSitesSiteListType_A43581.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.ConTrkSysAmssIsSmartZone);
			this.trkPerPreferredSitesAllowEmergencyAtBlockedSite_44910.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.TrkPreferredSitesAllowEmergencyAtBlockedSiteApplicable);
		}

		// Token: 0x06001BCD RID: 7117 RVA: 0x001BF5E0 File Offset: 0x001BD7E0
		public override void SetupDependencies()
		{
			short num = (short)979553509;
			short num2 = num;
			num = (short)1758186725;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2030567424;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1575092225;
			if (num != 0)
			{
			}
			num = (short)2108751872;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality trunkingPersonality = base.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality;
			trunkingPersonality.General.TrkPerGeneralSystem_A9237.AddDependentObject(this.trkPerPreferredSitesIgnoreSiteResourcePreference_A8239);
			trunkingPersonality.General.TrkPerGeneralSystem_A9237.AddDependentObject(this.trkPerPreferredSitesSiteListType_A43581);
			trunkingPersonality.General.TrkPerGeneralSystem_A9237.AddDependentObject(this.trkPerPreferredSitesAllowEmergencyAtBlockedSite_44910);
		}

		// Token: 0x17000E02 RID: 3586
		// (get) Token: 0x06001BCE RID: 7118 RVA: 0x001BF6D8 File Offset: 0x001BD8D8
		public bool HasDiffs
		{
			get
			{
				short num = (short)297227549;
				short num2 = num;
				num = (short)733238557;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1433075712;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)707002369;
				if (num != 0)
				{
				}
				num = (short)1974599680;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17000E03 RID: 3587
		// (get) Token: 0x06001BCF RID: 7119 RVA: 0x001BF78C File Offset: 0x001BD98C
		// (set) Token: 0x06001BD0 RID: 7120 RVA: 0x001BF840 File Offset: 0x001BDA40
		public bool TrkPerPreferredSitesIgnoreSiteResourcePreference_A8239Value
		{
			get
			{
				short num = (short)2104445679;
				short num2 = num;
				num = (short)1459309295;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1592918016;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)486604800;
				if (num != 0)
				{
				}
				num = (short)1149632513;
				if (num != 0)
				{
				}
				return this.trkPerPreferredSitesIgnoreSiteResourcePreference_A8239.Value;
			}
			set
			{
				short num = (short)1910113318;
				short num2 = num;
				num = (short)1640563750;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2089811968;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1945698305;
				if (num != 0)
				{
				}
				num = (short)430309376;
				if (num != 0)
				{
				}
				this.trkPerPreferredSitesIgnoreSiteResourcePreference_A8239.Value = value;
			}
		}

		// Token: 0x17000E04 RID: 3588
		// (get) Token: 0x06001BD1 RID: 7121 RVA: 0x001BF8F4 File Offset: 0x001BDAF4
		public global::AcpBusinessLayer.AcpField<bool> TrkPerPreferredSitesIgnoreSiteResourcePreference_A8239
		{
			get
			{
				short num = (short)1235041036;
				short num2 = num;
				num = (short)296827660;
				switch (num2 == num)
				{
				default:
				{
					num = (short)74711040;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)596901889;
				if (num != 0)
				{
				}
				num = (short)1585774592;
				if (num != 0)
				{
				}
				return this.trkPerPreferredSitesIgnoreSiteResourcePreference_A8239;
			}
		}

		// Token: 0x17000E05 RID: 3589
		// (get) Token: 0x06001BD2 RID: 7122 RVA: 0x001BF9A4 File Offset: 0x001BDBA4
		// (set) Token: 0x06001BD3 RID: 7123 RVA: 0x001BFA5C File Offset: 0x001BDC5C
		public bool TrkPerPreferredSitesIgnoreSiteResourcePreference_A8239_UIValue
		{
			get
			{
				short num = (short)331411239;
				short num2 = num;
				num = (short)710799143;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1974861824;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1912995840;
				if (num != 0)
				{
				}
				num = (short)1449263105;
				if (num != 0)
				{
				}
				return this.trkPerPreferredSitesIgnoreSiteResourcePreference_A8239.Value;
			}
			set
			{
				short num = (short)363361429;
				short num2 = num;
				num = (short)1267823765;
				switch (num2 == num)
				{
				default:
				{
					num = (short)794427392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2141716481;
				if (num != 0)
				{
				}
				num = (short)560988160;
				if (num != 0)
				{
				}
				this.trkPerPreferredSitesIgnoreSiteResourcePreference_A8239.Value = value;
			}
		}

		// Token: 0x17000E06 RID: 3590
		// (get) Token: 0x06001BD4 RID: 7124 RVA: 0x001BFB14 File Offset: 0x001BDD14
		// (set) Token: 0x06001BD5 RID: 7125 RVA: 0x001BFBC4 File Offset: 0x001BDDC4
		public bool TrkPerPreferredSitesIgnoreSiteResourcePreference_A8239_Applicable
		{
			get
			{
				short num = (short)1959045630;
				short num2 = num;
				num = (short)278833662;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1353973760;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)193724416;
				if (num != 0)
				{
				}
				num = (short)328138753;
				if (num != 0)
				{
				}
				return this.trkPerPreferredSitesIgnoreSiteResourcePreference_A8239.Applicable;
			}
			set
			{
				short num = (short)301146595;
				short num2 = num;
				num = (short)1586438627;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1916469248;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)198508545;
				if (num != 0)
				{
				}
				num = (short)1311703040;
				if (num != 0)
				{
				}
				this.trkPerPreferredSitesIgnoreSiteResourcePreference_A8239.Applicable = value;
			}
		}

		// Token: 0x17000E07 RID: 3591
		// (get) Token: 0x06001BD6 RID: 7126 RVA: 0x001BFC78 File Offset: 0x001BDE78
		// (set) Token: 0x06001BD7 RID: 7127 RVA: 0x001BFD2C File Offset: 0x001BDF2C
		public bool TrkPerPreferredSitesIgnoreSiteResourcePreference_A8239_Valid
		{
			get
			{
				short num = (short)1785458840;
				short num2 = num;
				num = (short)114815128;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1137246208;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)511639552;
				if (num != 0)
				{
				}
				num = (short)1054801921;
				if (num != 0)
				{
				}
				return this.trkPerPreferredSitesIgnoreSiteResourcePreference_A8239.Valid;
			}
			set
			{
				short num = (short)823079983;
				short num2 = num;
				num = (short)1317155887;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1878458368;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)43581441;
				if (num != 0)
				{
				}
				num = (short)1712324608;
				if (num != 0)
				{
				}
				this.trkPerPreferredSitesIgnoreSiteResourcePreference_A8239.Valid = value;
			}
		}

		// Token: 0x17000E08 RID: 3592
		// (get) Token: 0x06001BD8 RID: 7128 RVA: 0x001BFDE4 File Offset: 0x001BDFE4
		// (set) Token: 0x06001BD9 RID: 7129 RVA: 0x001BFE98 File Offset: 0x001BE098
		public bool TrkPerPreferredSitesIgnoreSiteResourcePreference_A8239_Visible
		{
			get
			{
				short num = (short)341114881;
				if (num != 0)
				{
				}
				num = (short)642646016;
				short num2 = num;
				num = (short)1624694028;
				short num3 = num;
				num = (short)1805442316;
				switch (num3 == num)
				{
				}
				num = (short)712966144;
				if (num != 0)
				{
				}
				return this.trkPerPreferredSitesIgnoreSiteResourcePreference_A8239.Visible;
			}
			set
			{
				short num = (short)704839722;
				short num2 = num;
				num = (short)410976298;
				switch (num2 == num)
				{
				default:
				{
					num = (short)568524800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1427767296;
				if (num != 0)
				{
				}
				num = (short)1337655297;
				if (num != 0)
				{
				}
				this.trkPerPreferredSitesIgnoreSiteResourcePreference_A8239.Visible = value;
			}
		}

		// Token: 0x17000E09 RID: 3593
		// (get) Token: 0x06001BDA RID: 7130 RVA: 0x001BFF50 File Offset: 0x001BE150
		// (set) Token: 0x06001BDB RID: 7131 RVA: 0x001C0004 File Offset: 0x001BE204
		public bool TrkPerPreferredSitesIgnoreSiteResourcePreference_A8239_Editable
		{
			get
			{
				short num = (short)1618623194;
				short num2 = num;
				num = (short)1280195290;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1070661632;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)999161857;
				if (num != 0)
				{
				}
				num = (short)809238528;
				if (num != 0)
				{
				}
				return this.trkPerPreferredSitesIgnoreSiteResourcePreference_A8239.Editable;
			}
			set
			{
				short num = (short)1211039745;
				if (num != 0)
				{
				}
				num = (short)837877760;
				short num2 = num;
				num = (short)777083594;
				short num3 = num;
				num = (short)1659329226;
				switch (num3 == num)
				{
				}
				num = (short)1912930304;
				if (num != 0)
				{
				}
				this.trkPerPreferredSitesIgnoreSiteResourcePreference_A8239.Editable = value;
			}
		}

		// Token: 0x17000E0A RID: 3594
		// (get) Token: 0x06001BDC RID: 7132 RVA: 0x001C00BC File Offset: 0x001BE2BC
		internal string TrkPerPreferredSitesIgnoreSiteResourcePreference_A8239_UILabel
		{
			get
			{
				short num = (short)135593985;
				if (num != 0)
				{
				}
				num = (short)1202126848;
				short num2 = num;
				num = (short)1148682878;
				short num3 = num;
				num = (short)132612734;
				switch (num3 == num)
				{
				}
				num = (short)447873024;
				if (num != 0)
				{
				}
				return this.trkPerPreferredSitesIgnoreSiteResourcePreference_A8239.UIName;
			}
		}

		// Token: 0x17000E0B RID: 3595
		// (get) Token: 0x06001BDD RID: 7133 RVA: 0x001C0170 File Offset: 0x001BE370
		// (set) Token: 0x06001BDE RID: 7134 RVA: 0x001C0224 File Offset: 0x001BE424
		internal bool TrkPerPreferredSitesIgnoreSiteResourcePreference_A8239_HiddenStatic
		{
			get
			{
				short num = (short)2059469457;
				short num2 = num;
				num = (short)1263272593;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1030488064;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1219100672;
				if (num != 0)
				{
				}
				num = (short)1780350977;
				if (num != 0)
				{
				}
				return this.trkPerPreferredSitesIgnoreSiteResourcePreference_A8239.HiddenStatic;
			}
			set
			{
				short num = (short)1034015462;
				short num2 = num;
				num = (short)862376678;
				switch (num2 == num)
				{
				default:
				{
					num = (short)325451776;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1896349696;
				if (num != 0)
				{
				}
				num = (short)1592852481;
				if (num != 0)
				{
				}
				this.trkPerPreferredSitesIgnoreSiteResourcePreference_A8239.HiddenStatic = value;
			}
		}

		// Token: 0x17000E0C RID: 3596
		// (get) Token: 0x06001BDF RID: 7135 RVA: 0x001C02D8 File Offset: 0x001BE4D8
		// (set) Token: 0x06001BE0 RID: 7136 RVA: 0x001C0394 File Offset: 0x001BE594
		internal bool TrkPerPreferredSitesIgnoreSiteResourcePreference_A8239_HiddenDynamic
		{
			get
			{
				short num = (short)425455575;
				short num2 = num;
				num = (short)1481764823;
				switch (num2 == num)
				{
				default:
				{
					num = (short)818151424;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)622592000;
				if (num != 0)
				{
				}
				num = (short)2088173569;
				if (num != 0)
				{
				}
				return this.trkPerPreferredSitesIgnoreSiteResourcePreference_A8239.HiddenDynamic;
			}
			set
			{
				short num = (short)851026226;
				short num2 = num;
				num = (short)352428338;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2135490560;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1479147521;
				if (num != 0)
				{
				}
				num = (short)996016128;
				if (num != 0)
				{
				}
				this.trkPerPreferredSitesIgnoreSiteResourcePreference_A8239.HiddenDynamic = value;
			}
		}

		// Token: 0x17000E0D RID: 3597
		// (get) Token: 0x06001BE1 RID: 7137 RVA: 0x001C044C File Offset: 0x001BE64C
		public bool TrkPerPreferredSitesIgnoreSiteResourcePreference_A8239_HasDiffs
		{
			get
			{
				short num = (short)1551709552;
				short num2 = num;
				num = (short)285291888;
				switch (num2 == num)
				{
				default:
				{
					num = (short)366018560;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)22282241;
				if (num != 0)
				{
				}
				num = (short)1322385408;
				if (num != 0)
				{
				}
				return this.trkPerPreferredSitesIgnoreSiteResourcePreference_A8239._HasDiffs;
			}
		}

		// Token: 0x17000E0E RID: 3598
		// (get) Token: 0x06001BE2 RID: 7138 RVA: 0x001C0500 File Offset: 0x001BE700
		// (set) Token: 0x06001BE3 RID: 7139 RVA: 0x001C05B4 File Offset: 0x001BE7B4
		public int TrkPerPreferredSitesSiteListType_A43581Value
		{
			get
			{
				short num = (short)2020130321;
				short num2 = num;
				num = (short)1622130193;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1969160192;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)96796672;
				if (num != 0)
				{
				}
				num = (short)301858817;
				if (num != 0)
				{
				}
				return this.trkPerPreferredSitesSiteListType_A43581.Value;
			}
			set
			{
				short num = (short)1032125386;
				short num2 = num;
				num = (short)355990474;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1556611072;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)524484609;
				if (num != 0)
				{
				}
				num = (short)439681024;
				if (num != 0)
				{
				}
				this.trkPerPreferredSitesSiteListType_A43581.Value = value;
			}
		}

		// Token: 0x17000E0F RID: 3599
		// (get) Token: 0x06001BE4 RID: 7140 RVA: 0x001C0670 File Offset: 0x001BE870
		// (set) Token: 0x06001BE5 RID: 7141 RVA: 0x001C0724 File Offset: 0x001BE924
		public string TrkPerPreferredSitesSiteListType_A43581_UIValue
		{
			get
			{
				short num = (short)81549293;
				short num2 = num;
				num = (short)1579767789;
				switch (num2 == num)
				{
				default:
				{
					num = (short)598867968;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)549060609;
				if (num != 0)
				{
				}
				num = (short)1442119680;
				if (num != 0)
				{
				}
				return this.trkPerPreferredSitesSiteListType_A43581.UIValue;
			}
			set
			{
				short num = (short)192199937;
				short num2 = num;
				num = (short)258718977;
				switch (num2 == num)
				{
				default:
				{
					num = (short)169934848;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)542900225;
				if (num != 0)
				{
				}
				num = (short)682098688;
				if (num != 0)
				{
				}
				this.trkPerPreferredSitesSiteListType_A43581.UIValue = value;
			}
		}

		// Token: 0x17000E10 RID: 3600
		// (get) Token: 0x06001BE6 RID: 7142 RVA: 0x001C07DC File Offset: 0x001BE9DC
		public global::AcpBusinessLayer.AcpListField TrkPerPreferredSitesSiteListType_A43581
		{
			get
			{
				short num = (short)457447267;
				short num2 = num;
				num = (short)1507792739;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1180368896;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1188364289;
				if (num != 0)
				{
				}
				num = (short)1395130368;
				if (num != 0)
				{
				}
				return this.trkPerPreferredSitesSiteListType_A43581;
			}
		}

		// Token: 0x17000E11 RID: 3601
		// (get) Token: 0x06001BE7 RID: 7143 RVA: 0x001C088C File Offset: 0x001BEA8C
		// (set) Token: 0x06001BE8 RID: 7144 RVA: 0x001C0944 File Offset: 0x001BEB44
		public bool TrkPerPreferredSitesSiteListType_A43581_Applicable
		{
			get
			{
				short num = (short)2141157096;
				short num2 = num;
				num = (short)711554792;
				switch (num2 == num)
				{
				default:
				{
					num = (short)466812928;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)790102016;
				if (num != 0)
				{
				}
				num = (short)1052180481;
				if (num != 0)
				{
				}
				return this.trkPerPreferredSitesSiteListType_A43581.Applicable;
			}
			set
			{
				short num = (short)1222316622;
				short num2 = num;
				num = (short)21303886;
				switch (num2 == num)
				{
				default:
				{
					num = (short)302317568;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)344522753;
				if (num != 0)
				{
				}
				num = (short)2017918976;
				if (num != 0)
				{
				}
				this.trkPerPreferredSitesSiteListType_A43581.Applicable = value;
			}
		}

		// Token: 0x17000E12 RID: 3602
		// (get) Token: 0x06001BE9 RID: 7145 RVA: 0x001C09F8 File Offset: 0x001BEBF8
		// (set) Token: 0x06001BEA RID: 7146 RVA: 0x001C0AAC File Offset: 0x001BECAC
		public bool TrkPerPreferredSitesSiteListType_A43581_Valid
		{
			get
			{
				short num = (short)1210928580;
				short num2 = num;
				num = (short)753618372;
				switch (num2 == num)
				{
				default:
				{
					num = (short)283901952;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1228210177;
				if (num != 0)
				{
				}
				num = (short)1957298176;
				if (num != 0)
				{
				}
				return this.trkPerPreferredSitesSiteListType_A43581.Valid;
			}
			set
			{
				short num = (short)122838613;
				short num2 = num;
				num = (short)1739546197;
				switch (num2 == num)
				{
				default:
				{
					num = (short)518520832;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1804992512;
				if (num != 0)
				{
				}
				num = (short)736886785;
				if (num != 0)
				{
				}
				this.trkPerPreferredSitesSiteListType_A43581.Valid = value;
			}
		}

		// Token: 0x17000E13 RID: 3603
		// (get) Token: 0x06001BEB RID: 7147 RVA: 0x001C0B60 File Offset: 0x001BED60
		// (set) Token: 0x06001BEC RID: 7148 RVA: 0x001C0C14 File Offset: 0x001BEE14
		public bool TrkPerPreferredSitesSiteListType_A43581_Visible
		{
			get
			{
				short num = (short)1632705774;
				short num2 = num;
				num = (short)326573294;
				switch (num2 == num)
				{
				default:
				{
					num = (short)145096704;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2054881281;
				if (num != 0)
				{
				}
				num = (short)351928320;
				if (num != 0)
				{
				}
				return this.trkPerPreferredSitesSiteListType_A43581.Visible;
			}
			set
			{
				short num = (short)527098557;
				short num2 = num;
				num = (short)1273160381;
				switch (num2 == num)
				{
				default:
				{
					num = (short)698351616;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1513226240;
				if (num != 0)
				{
				}
				num = (short)527892481;
				if (num != 0)
				{
				}
				this.trkPerPreferredSitesSiteListType_A43581.Visible = value;
			}
		}

		// Token: 0x17000E14 RID: 3604
		// (get) Token: 0x06001BED RID: 7149 RVA: 0x001C0CC8 File Offset: 0x001BEEC8
		// (set) Token: 0x06001BEE RID: 7150 RVA: 0x001C0D7C File Offset: 0x001BEF7C
		public bool TrkPerPreferredSitesSiteListType_A43581_Editable
		{
			get
			{
				short num = (short)400392991;
				short num2 = num;
				num = (short)1245545247;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1427243008;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1233846273;
				if (num != 0)
				{
				}
				num = (short)1150156800;
				if (num != 0)
				{
				}
				return this.trkPerPreferredSitesSiteListType_A43581.Editable;
			}
			set
			{
				short num = (short)1140909319;
				short num2 = num;
				num = (short)459203847;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1881735168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1530658816;
				if (num != 0)
				{
				}
				num = (short)769327105;
				if (num != 0)
				{
				}
				this.trkPerPreferredSitesSiteListType_A43581.Editable = value;
			}
		}

		// Token: 0x17000E15 RID: 3605
		// (get) Token: 0x06001BEF RID: 7151 RVA: 0x001C0E34 File Offset: 0x001BF034
		internal string TrkPerPreferredSitesSiteListType_A43581_UILabel
		{
			get
			{
				short num = (short)1549460375;
				short num2 = num;
				num = (short)1358291863;
				switch (num2 == num)
				{
				default:
				{
					num = 0;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)659030017;
				if (num != 0)
				{
				}
				num = (short)1195966464;
				if (num != 0)
				{
				}
				return this.trkPerPreferredSitesSiteListType_A43581.UIName;
			}
		}

		// Token: 0x17000E16 RID: 3606
		// (get) Token: 0x06001BF0 RID: 7152 RVA: 0x001C0EEC File Offset: 0x001BF0EC
		// (set) Token: 0x06001BF1 RID: 7153 RVA: 0x001C0FA0 File Offset: 0x001BF1A0
		internal bool TrkPerPreferredSitesSiteListType_A43581_HiddenStatic
		{
			get
			{
				short num = (short)1808007169;
				if (num != 0)
				{
				}
				num = (short)1229586432;
				short num2 = num;
				num = (short)946829905;
				short num3 = num;
				num = (short)1747352145;
				switch (num3 == num)
				{
				}
				num = (short)1985282048;
				if (num != 0)
				{
				}
				return this.trkPerPreferredSitesSiteListType_A43581.HiddenStatic;
			}
			set
			{
				short num = (short)1212295191;
				short num2 = num;
				num = (short)1543448599;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1753612288;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1518403584;
				if (num != 0)
				{
				}
				num = (short)600768513;
				if (num != 0)
				{
				}
				this.trkPerPreferredSitesSiteListType_A43581.HiddenStatic = value;
			}
		}

		// Token: 0x17000E17 RID: 3607
		// (get) Token: 0x06001BF2 RID: 7154 RVA: 0x001C1054 File Offset: 0x001BF254
		// (set) Token: 0x06001BF3 RID: 7155 RVA: 0x001C1108 File Offset: 0x001BF308
		internal bool TrkPerPreferredSitesSiteListType_A43581_HiddenDynamic
		{
			get
			{
				short num = (short)999730020;
				short num2 = num;
				num = (short)1871096676;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1620574208;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)939524097;
				if (num != 0)
				{
				}
				num = (short)962920448;
				if (num != 0)
				{
				}
				return this.trkPerPreferredSitesSiteListType_A43581.HiddenDynamic;
			}
			set
			{
				short num = (short)424226896;
				short num2 = num;
				num = (short)751972432;
				switch (num2 == num)
				{
				default:
				{
					num = (short)205324288;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1312358401;
				if (num != 0)
				{
				}
				num = (short)1907818496;
				if (num != 0)
				{
				}
				this.trkPerPreferredSitesSiteListType_A43581.HiddenDynamic = value;
			}
		}

		// Token: 0x17000E18 RID: 3608
		// (get) Token: 0x06001BF4 RID: 7156 RVA: 0x001C11C0 File Offset: 0x001BF3C0
		public bool TrkPerPreferredSitesSiteListType_A43581_HasDiffs
		{
			get
			{
				short num = (short)643497985;
				if (num != 0)
				{
				}
				num = (short)2138832896;
				short num2 = num;
				num = (short)2066198529;
				short num3 = num;
				num = (short)400732161;
				switch (num3 == num)
				{
				}
				num = (short)90177536;
				if (num != 0)
				{
				}
				return this.trkPerPreferredSitesSiteListType_A43581._HasDiffs;
			}
		}

		// Token: 0x17000E19 RID: 3609
		// (get) Token: 0x06001BF5 RID: 7157 RVA: 0x001C1278 File Offset: 0x001BF478
		// (set) Token: 0x06001BF6 RID: 7158 RVA: 0x001C132C File Offset: 0x001BF52C
		public bool TrkPerPreferredSitesAllowEmergencyAtBlockedSite_44910Value
		{
			get
			{
				short num = (short)1770258132;
				short num2 = num;
				num = (short)1080229588;
				switch (num2 == num)
				{
				default:
				{
					num = (short)301596672;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)27197441;
				if (num != 0)
				{
				}
				num = (short)2119827456;
				if (num != 0)
				{
				}
				return this.trkPerPreferredSitesAllowEmergencyAtBlockedSite_44910.Value;
			}
			set
			{
				short num = (short)968191470;
				short num2 = num;
				num = (short)1397976558;
				switch (num2 == num)
				{
				default:
				{
					num = (short)10813440;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)847511552;
				if (num != 0)
				{
				}
				num = (short)1891631105;
				if (num != 0)
				{
				}
				this.trkPerPreferredSitesAllowEmergencyAtBlockedSite_44910.Value = value;
			}
		}

		// Token: 0x17000E1A RID: 3610
		// (get) Token: 0x06001BF7 RID: 7159 RVA: 0x001C13E4 File Offset: 0x001BF5E4
		public global::AcpBusinessLayer.AcpField<bool> TrkPerPreferredSitesAllowEmergencyAtBlockedSite_44910
		{
			get
			{
				short num = (short)1173290720;
				short num2 = num;
				num = (short)1168834272;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2056257536;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)807469056;
				if (num != 0)
				{
				}
				num = (short)1276116993;
				if (num != 0)
				{
				}
				return this.trkPerPreferredSitesAllowEmergencyAtBlockedSite_44910;
			}
		}

		// Token: 0x17000E1B RID: 3611
		// (get) Token: 0x06001BF8 RID: 7160 RVA: 0x001C1494 File Offset: 0x001BF694
		// (set) Token: 0x06001BF9 RID: 7161 RVA: 0x001C154C File Offset: 0x001BF74C
		public bool TrkPerPreferredSitesAllowEmergencyAtBlockedSite_44910_UIValue
		{
			get
			{
				short num = (short)353359676;
				short num2 = num;
				num = (short)669636412;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1196425216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1468530689;
				if (num != 0)
				{
				}
				num = (short)238485504;
				if (num != 0)
				{
				}
				return this.trkPerPreferredSitesAllowEmergencyAtBlockedSite_44910.Value;
			}
			set
			{
				short num = (short)486664440;
				short num2 = num;
				num = (short)161802488;
				switch (num2 == num)
				{
				default:
				{
					num = (short)501350400;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1400897537;
				if (num != 0)
				{
				}
				num = (short)523239424;
				if (num != 0)
				{
				}
				this.trkPerPreferredSitesAllowEmergencyAtBlockedSite_44910.Value = value;
			}
		}

		// Token: 0x17000E1C RID: 3612
		// (get) Token: 0x06001BFA RID: 7162 RVA: 0x001C1604 File Offset: 0x001BF804
		// (set) Token: 0x06001BFB RID: 7163 RVA: 0x001C16B8 File Offset: 0x001BF8B8
		public bool TrkPerPreferredSitesAllowEmergencyAtBlockedSite_44910_Applicable
		{
			get
			{
				short num = (short)1187291141;
				short num2 = num;
				num = (short)796106757;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2109341696;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)703856640;
				if (num != 0)
				{
				}
				num = (short)1180303361;
				if (num != 0)
				{
				}
				return this.trkPerPreferredSitesAllowEmergencyAtBlockedSite_44910.Applicable;
			}
			set
			{
				short num = (short)2089379480;
				short num2 = num;
				num = (short)511600280;
				switch (num2 == num)
				{
				default:
				{
					num = (short)434503680;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)985923585;
				if (num != 0)
				{
				}
				num = (short)516554752;
				if (num != 0)
				{
				}
				this.trkPerPreferredSitesAllowEmergencyAtBlockedSite_44910.Applicable = value;
			}
		}

		// Token: 0x17000E1D RID: 3613
		// (get) Token: 0x06001BFC RID: 7164 RVA: 0x001C1770 File Offset: 0x001BF970
		// (set) Token: 0x06001BFD RID: 7165 RVA: 0x001C1824 File Offset: 0x001BFA24
		public bool TrkPerPreferredSitesAllowEmergencyAtBlockedSite_44910_Valid
		{
			get
			{
				short num = (short)62002839;
				short num2 = num;
				num = (short)899421847;
				switch (num2 == num)
				{
				default:
				{
					num = (short)741146624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1166606337;
				if (num != 0)
				{
				}
				num = (short)2136997888;
				if (num != 0)
				{
				}
				return this.trkPerPreferredSitesAllowEmergencyAtBlockedSite_44910.Valid;
			}
			set
			{
				short num = (short)206918595;
				short num2 = num;
				num = (short)24662979;
				switch (num2 == num)
				{
				default:
				{
					num = (short)99811328;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)952827905;
				if (num != 0)
				{
				}
				num = (short)98828288;
				if (num != 0)
				{
				}
				this.trkPerPreferredSitesAllowEmergencyAtBlockedSite_44910.Valid = value;
			}
		}

		// Token: 0x17000E1E RID: 3614
		// (get) Token: 0x06001BFE RID: 7166 RVA: 0x001C18D8 File Offset: 0x001BFAD8
		// (set) Token: 0x06001BFF RID: 7167 RVA: 0x001C198C File Offset: 0x001BFB8C
		public bool TrkPerPreferredSitesAllowEmergencyAtBlockedSite_44910_Visible
		{
			get
			{
				short num = (short)527327992;
				short num2 = num;
				num = (short)197812984;
				switch (num2 == num)
				{
				default:
				{
					num = (short)436207616;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)897974273;
				if (num != 0)
				{
				}
				num = (short)712441856;
				if (num != 0)
				{
				}
				return this.trkPerPreferredSitesAllowEmergencyAtBlockedSite_44910.Visible;
			}
			set
			{
				short num = (short)128104831;
				short num2 = num;
				num = (short)1180612991;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1055850496;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)210960385;
				if (num != 0)
				{
				}
				num = (short)540999680;
				if (num != 0)
				{
				}
				this.trkPerPreferredSitesAllowEmergencyAtBlockedSite_44910.Visible = value;
			}
		}

		// Token: 0x17000E1F RID: 3615
		// (get) Token: 0x06001C00 RID: 7168 RVA: 0x001C1A48 File Offset: 0x001BFC48
		// (set) Token: 0x06001C01 RID: 7169 RVA: 0x001C1AFC File Offset: 0x001BFCFC
		public bool TrkPerPreferredSitesAllowEmergencyAtBlockedSite_44910_Editable
		{
			get
			{
				short num = (short)310378111;
				short num2 = num;
				num = (short)1642200703;
				switch (num2 == num)
				{
				default:
				{
					num = (short)727187456;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2141847553;
				if (num != 0)
				{
				}
				num = (short)783286272;
				if (num != 0)
				{
				}
				return this.trkPerPreferredSitesAllowEmergencyAtBlockedSite_44910.Editable;
			}
			set
			{
				short num = (short)1340243659;
				short num2 = num;
				num = (short)63733451;
				switch (num2 == num)
				{
				default:
				{
					num = (short)486211584;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1803812864;
				if (num != 0)
				{
				}
				num = (short)2001469441;
				if (num != 0)
				{
				}
				this.trkPerPreferredSitesAllowEmergencyAtBlockedSite_44910.Editable = value;
			}
		}

		// Token: 0x17000E20 RID: 3616
		// (get) Token: 0x06001C02 RID: 7170 RVA: 0x001C1BB4 File Offset: 0x001BFDB4
		internal string TrkPerPreferredSitesAllowEmergencyAtBlockedSite_44910_UILabel
		{
			get
			{
				short num = (short)2088632321;
				if (num != 0)
				{
				}
				num = (short)87472083;
				short num2 = num;
				num = (short)191215571;
				switch (num2 == num)
				{
				}
				num = (short)93192192;
				if (num != 0)
				{
				}
				num = (short)321847296;
				short num3 = num;
				return this.trkPerPreferredSitesAllowEmergencyAtBlockedSite_44910.UIName;
			}
		}

		// Token: 0x17000E21 RID: 3617
		// (get) Token: 0x06001C03 RID: 7171 RVA: 0x001C1C68 File Offset: 0x001BFE68
		// (set) Token: 0x06001C04 RID: 7172 RVA: 0x001C1D1C File Offset: 0x001BFF1C
		internal bool TrkPerPreferredSitesAllowEmergencyAtBlockedSite_44910_HiddenStatic
		{
			get
			{
				short num = (short)2108620801;
				if (num != 0)
				{
				}
				num = (short)764093429;
				short num2 = num;
				num = (short)792470517;
				switch (num2 == num)
				{
				}
				num = (short)750977024;
				if (num != 0)
				{
				}
				num = (short)85786624;
				short num3 = num;
				return this.trkPerPreferredSitesAllowEmergencyAtBlockedSite_44910.HiddenStatic;
			}
			set
			{
				short num = (short)288820948;
				short num2 = num;
				num = (short)18550484;
				switch (num2 == num)
				{
				}
				num = (short)2045837313;
				if (num != 0)
				{
				}
				num = (short)1500315648;
				if (num != 0)
				{
				}
				num = (short)1098252288;
				short num3 = num;
				this.trkPerPreferredSitesAllowEmergencyAtBlockedSite_44910.HiddenStatic = value;
			}
		}

		// Token: 0x17000E22 RID: 3618
		// (get) Token: 0x06001C05 RID: 7173 RVA: 0x001C1DD0 File Offset: 0x001BFFD0
		// (set) Token: 0x06001C06 RID: 7174 RVA: 0x001C1E88 File Offset: 0x001C0088
		internal bool TrkPerPreferredSitesAllowEmergencyAtBlockedSite_44910_HiddenDynamic
		{
			get
			{
				short num = (short)1710643538;
				short num2 = num;
				num = (short)930306386;
				switch (num2 == num)
				{
				}
				num = (short)1191378945;
				if (num != 0)
				{
				}
				num = (short)1475477504;
				if (num != 0)
				{
				}
				num = (short)1503920128;
				short num3 = num;
				return this.trkPerPreferredSitesAllowEmergencyAtBlockedSite_44910.HiddenDynamic;
			}
			set
			{
				short num = (short)928117506;
				short num2 = num;
				num = (short)527430402;
				switch (num2 == num)
				{
				}
				num = (short)1628897281;
				if (num != 0)
				{
				}
				num = (short)960561152;
				if (num != 0)
				{
				}
				num = (short)1967194112;
				short num3 = num;
				this.trkPerPreferredSitesAllowEmergencyAtBlockedSite_44910.HiddenDynamic = value;
			}
		}

		// Token: 0x17000E23 RID: 3619
		// (get) Token: 0x06001C07 RID: 7175 RVA: 0x001C1F3C File Offset: 0x001C013C
		public bool TrkPerPreferredSitesAllowEmergencyAtBlockedSite_44910_HasDiffs
		{
			get
			{
				short num = (short)412942337;
				if (num != 0)
				{
				}
				num = (short)1386825509;
				short num2 = num;
				num = (short)1455114021;
				switch (num2 == num)
				{
				}
				num = (short)1701249024;
				if (num != 0)
				{
				}
				num = (short)511311872;
				short num3 = num;
				return this.trkPerPreferredSitesAllowEmergencyAtBlockedSite_44910._HasDiffs;
			}
		}

		// Token: 0x06001C08 RID: 7176 RVA: 0x001C1FF0 File Offset: 0x001C01F0
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			global::AcpCommonLib.IAcpRecordset result;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)1416298500;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (base.ParentRecset != null)
					{
						num2 = (short)646840323;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_13F;
				case 2:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)1031667712;
						short num3 = num2;
						num2 = (short)1367343104;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_13F;
				case 3:
					goto IL_D3;
				case 4:
				{
					num2 = (short)1598956457;
					short num4 = num2;
					num2 = (short)1086530473;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_D3;
					default:
						goto IL_BC;
					}
					break;
				}
				}
				goto IL_24;
				IL_D3:
				num2 = (short)2018574338;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_BC:
			num2 = (short)1786249216;
			if (num2 != 0)
			{
			}
			IL_13F:
			num2 = (short)83820545;
			if (num2 != 0)
			{
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)1767964673;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x040008F6 RID: 2294
		private global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.PreferredSitesInnerRecset innerRecset;

		// Token: 0x040008F7 RID: 2295
		private global::AcpBusinessLayer.AcpField<bool> trkPerPreferredSitesIgnoreSiteResourcePreference_A8239;

		// Token: 0x040008F8 RID: 2296
		private global::AcpBusinessLayer.AcpListField trkPerPreferredSitesSiteListType_A43581;

		// Token: 0x040008F9 RID: 2297
		private global::AcpBusinessLayer.AcpField<bool> trkPerPreferredSitesAllowEmergencyAtBlockedSite_44910;
	}
}
