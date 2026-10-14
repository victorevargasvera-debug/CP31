using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList;
using Motorola.MackinawCPS.CoreFeatures.DVRSProfiles;
using Motorola.MackinawCPS.CoreFeatures.DVRSWide;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;

namespace Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality
{
	// Token: 0x020005C2 RID: 1474
	[global::System.Serializable]
	public class General : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600C746 RID: 51014 RVA: 0x00BA7578 File Offset: 0x00BA5778
		public General(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x0600C747 RID: 51015 RVA: 0x00BA7594 File Offset: 0x00BA5794
		protected General(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600C748 RID: 51016 RVA: 0x00BA75AC File Offset: 0x00BA57AC
		public override void Init()
		{
			int a_ = 15;
			short num = (short)818745469;
			short num2 = num;
			num = (short)1816989821;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1116995584;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2039021568;
			if (num != 0)
			{
			}
			num = (short)1908080641;
			if (num != 0)
			{
			}
			this.cnvPerGeneralConventionalPersonalityName_A12660 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("鏏병ꋓ蛕뷗꣙鯛믝軟蟡難蟥蓧ꧩ菫胭蛯韱髳苵釷闹鋻鿽泿刁愃琅笇攉戋漍簏笑怓漕嘗笙焛笝缟挡ᔣᐥḧᰩᰫ", a_), global::CommonResources.AcgResources.ID_CONVENTIONALPERSONALITYNAME, 14);
			this.cnvPerGeneralConventionalPersonalityName_A12660.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.cnvPerGeneralConventionalPersonalityName_A12660.DataTransferOrder = 66;
			this.cnvPerGeneralTalkgroupTextList_A19822 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("鏏병ꋓ蛕뷗꣙鯛믝軟蟡難蟥蓧뻩跫苭鯯闱蛳駵跷諹ꣻ鯽磿瘁䠃漅笇縉匋伍ℏ⬑Ⱃ␕⨗", a_), global::CommonResources.AcgResources.ID_TALKGROUPTEXTLIST, null, null, true, false);
			this.cnvPerGeneralTalkgroupTextList_A19822.IgnoreOnCompare = true;
			this.cnvPerGeneralTalkgroupTextList_A19822.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvPerGeneralTalkgroupTextList_A19822.DataTransferOrder = -1;
			this.cnvPerFeaturesDVRSProf_A41794 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("鏏병ꋓ蛕뷗꣙髛믝臟雡釣铥跧駩꣫룭ꋯꇱꓳ蓵韷鳹ꏻ뿽㓿㌁㌃㼅㰇", a_), global::CommonResources.AcgResources.ID_DVRSPROFILESELECTION, new string[]
			{
				global::CommonResources.AcgResources.ID_DVRSDISABLED
			}, new int[1], true, false);
			this.cnvPerFeaturesDVRSProf_A41794.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvPerFeaturesDVRSProf_A41794.DataTransferOrder = 185;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("韏럑뫓돕꫗믙냛", a_);
			base.Id = 10150;
			base.UIName = global::CommonResources.AcgResources.ID_GENERAL;
			base.DataTransferOrder = 6;
		}

		// Token: 0x0600C749 RID: 51017 RVA: 0x00BA7760 File Offset: 0x00BA5960
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 3;
			short num = (short)958857224;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_271;
				case 1:
					goto IL_233;
				case 2:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蟃ꣅ뻇髉꧋볍雏럑뗓ꋕ귗꣙맛귝ꓟ듡뛣뗥룧飩菫裭꿯돱샳쟵쿷쏹죻", a_)))
					{
						goto IL_2A2;
					}
					goto IL_368;
				case 3:
					goto IL_135;
				case 4:
					this.cnvPerGeneralConventionalPersonalityName_A12660 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("蟃ꣅ뻇髉꧋볍韏럑뫓돕꫗믙냛鷝迟賡鋣菥蛧黩藫臭黯鏱飳꛵鷷裹迻釽滿持栃漅簇猉䈋漍紏眑䬓圕⤗⠙⨛⠝ဟ", a_), global::CommonResources.AcgResources.ID_CONVENTIONALPERSONALITYNAME, 14);
					this.cnvPerGeneralConventionalPersonalityName_A12660.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.cnvPerGeneralConventionalPersonalityName_A12660.DataTransferOrder = 66;
					num = (short)1556217857;
					if (num != 0)
					{
					}
					num = (short)401604611;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
				{
					this.cnvPerGeneralTalkgroupTextList_A19822 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("蟃ꣅ뻇髉꧋볍韏럑뫓돕꫗믙냛諝臟軡迣臥髧藩駫黭ꓯ韱賳苵듷鏹迻諽忿䌁㔃㼅〇㠉㸋", a_), global::CommonResources.AcgResources.ID_TALKGROUPTEXTLIST, null, null, true, false);
					this.cnvPerGeneralTalkgroupTextList_A19822.IgnoreOnCompare = true;
					this.cnvPerGeneralTalkgroupTextList_A19822.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvPerGeneralTalkgroupTextList_A19822.DataTransferOrder = -1;
					num = (short)1671288379;
					short num3 = num;
					num = (short)678286907;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_2A2;
					default:
						num = (short)1796079616;
						if (num != 0)
						{
						}
						num = (short)533528576;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 6:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蟃ꣅ뻇髉꧋볍韏럑뫓돕꫗믙냛諝臟軡迣臥髧藩駫黭ꓯ韱賳苵듷鏹迻諽忿䌁㔃㼅〇㠉㸋", a_)))
					{
						num = (short)936640517;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_271;
				case 7:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蟃ꣅ뻇髉꧋볍韏럑뫓돕꫗믙냛鷝迟賡鋣菥蛧黩藫臭黯鏱飳꛵鷷裹迻釽滿持栃漅簇猉䈋漍紏眑䬓圕⤗⠙⨛⠝ဟ", a_)))
					{
						num = (short)760348676;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_135;
				case 8:
					switch (0)
					{
					case 0:
						goto IL_63;
					}
					continue;
				case 9:
					num = (short)1794113547;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					this.cnvPerFeaturesDVRSProf_A41794 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("蟃ꣅ뻇髉꧋볍雏럑뗓ꋕ귗꣙맛귝ꓟ듡뛣뗥룧飩菫裭꿯돱샳쟵쿷쏹죻", a_), global::CommonResources.AcgResources.ID_DVRSPROFILESELECTION, new string[]
					{
						global::CommonResources.AcgResources.ID_DVRSDISABLED
					}, new int[1], true, false);
					this.cnvPerFeaturesDVRSProf_A41794.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvPerFeaturesDVRSProf_A41794.DataTransferOrder = 185;
					num = (short)2089222145;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					if (producerFields != null)
					{
						num = (short)997720076;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_368;
				case 12:
					num = (short)92471303;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_63:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1403322377;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_135:
				num = (short)1661075462;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_271:
				num = (short)285212674;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2A2:
				num = (short)139984896;
				short num4 = num;
				num = (short)1203961866;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_233:
			IL_368:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("菃ꏅꛇ꿉뻋꿍볏", a_);
			base.Id = 10150;
			base.UIName = global::CommonResources.AcgResources.ID_GENERAL;
			base.DataTransferOrder = 6;
		}

		// Token: 0x0600C74A RID: 51018 RVA: 0x00BA7B08 File Offset: 0x00BA5D08
		public override void PopulateReferences()
		{
			short num = (short)1124663297;
			if (num != 0)
			{
			}
			num = (short)837222400;
			short num2 = num;
			num = (short)1970653441;
			short num3 = num;
			num = (short)592759041;
			switch (num3 == num)
			{
			}
			num = (short)2089746432;
			if (num != 0)
			{
			}
			this.cnvPerGeneralTalkgroupTextList_A19822.SetRecset(this.a(2062));
			this.cnvPerFeaturesDVRSProf_A41794.SetRecset(this.a(4143));
		}

		// Token: 0x0600C74B RID: 51019 RVA: 0x00BA7BDC File Offset: 0x00BA5DDC
		public override void DropReferences()
		{
			short num = (short)1041957357;
			short num2 = num;
			num = (short)2146632173;
			switch (num2 == num)
			{
			default:
			{
				num = (short)999161856;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1268580353;
			if (num != 0)
			{
			}
			num = (short)1446117376;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600C74C RID: 51020 RVA: 0x00BA7C84 File Offset: 0x00BA5E84
		public override void SetConstraints()
		{
			short num = (short)81867972;
			short num2 = num;
			num = (short)366818500;
			switch (num2 == num)
			{
			default:
			{
				num = (short)759037952;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1821376513;
			if (num != 0)
			{
			}
			num = (short)2056847360;
			if (num != 0)
			{
			}
			this.cnvPerGeneralTalkgroupTextList_A19822.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConAstroRxSigEnabledAndCnvTlkGrpEnIsEnabled);
			this.cnvPerGeneralTalkgroupTextList_A19822.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.conReturnFalse);
			this.cnvPerFeaturesDVRSProf_A41794.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConDVRSHardWareIsEnabled);
			this.cnvPerFeaturesDVRSProf_A41794.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConDVRSProfileSelectionIsValid);
		}

		// Token: 0x0600C74D RID: 51021 RVA: 0x00BA7D88 File Offset: 0x00BA5F88
		public override void SetupDependencies()
		{
			short num = (short)1423207237;
			short num2 = num;
			num = (short)745040709;
			switch (num2 == num)
			{
			default:
			{
				num = (short)580190208;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2141585409;
			if (num != 0)
			{
			}
			num = (short)1128792064;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality = base.Parent as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality;
			conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.AddDependentObject(this.cnvPerGeneralTalkgroupTextList_A19822);
			conventionalPersonality.ASTROTalkgroup.CnvPerASTROTalkgroupOptionsTalkGroupEnable_A9272.AddDependentObject(this.cnvPerGeneralTalkgroupTextList_A19822);
			this.RefDVRSWide.General.RadErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911.AddDependentObject(this.cnvPerFeaturesDVRSProf_A41794);
			this.RefRadioWide.Location.RadWideLocationLocationEnable_A8448.AddDependentObject(this.cnvPerFeaturesDVRSProf_A41794);
			conventionalPersonality.Signaling.CnvPerSignalingASTROSystem_A7498.AddDependentObject(this.cnvPerFeaturesDVRSProf_A41794);
		}

		// Token: 0x170063EC RID: 25580
		// (get) Token: 0x0600C74E RID: 51022 RVA: 0x00BA7EB8 File Offset: 0x00BA60B8
		public global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.ASTROTalkgroupList ASTROTalkgroupListForCnvPerGeneralTalkgroupTextList_A19822
		{
			get
			{
				short num = (short)735418696;
				short num2 = num;
				num = (short)622696776;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1491730432;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2139160577;
				if (num != 0)
				{
				}
				num = (short)1915355136;
				if (num != 0)
				{
				}
				return this.cnvPerGeneralTalkgroupTextList_A19822.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.ASTROTalkgroupList;
			}
		}

		// Token: 0x170063ED RID: 25581
		// (get) Token: 0x0600C74F RID: 51023 RVA: 0x00BA7F74 File Offset: 0x00BA6174
		public global::Motorola.MackinawCPS.CoreFeatures.DVRSProfiles.DVRSProfiles DVRSProfilesForCnvPerFeaturesDVRSProf_A41794
		{
			get
			{
				short num = (short)1790333624;
				short num2 = num;
				num = (short)1329681080;
				switch (num2 == num)
				{
				default:
				{
					num = (short)531234816;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)454885376;
				if (num != 0)
				{
				}
				num = (short)1010040833;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesDVRSProf_A41794.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.DVRSProfiles.DVRSProfiles;
			}
		}

		// Token: 0x170063EE RID: 25582
		// (get) Token: 0x0600C750 RID: 51024 RVA: 0x00BA802C File Offset: 0x00BA622C
		public bool HasDiffs
		{
			get
			{
				short num = (short)885456494;
				short num2 = num;
				num = (short)829685358;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2030632960;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2113208321;
				if (num != 0)
				{
				}
				num = (short)1298137088;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x170063EF RID: 25583
		// (get) Token: 0x0600C751 RID: 51025 RVA: 0x00BA80DC File Offset: 0x00BA62DC
		// (set) Token: 0x0600C752 RID: 51026 RVA: 0x00BA8190 File Offset: 0x00BA6390
		public string CnvPerGeneralConventionalPersonalityName_A12660Value
		{
			get
			{
				short num = (short)156839347;
				short num2 = num;
				num = (short)854601139;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1320812544;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1928462337;
				if (num != 0)
				{
				}
				num = (short)1250951168;
				if (num != 0)
				{
				}
				return this.cnvPerGeneralConventionalPersonalityName_A12660.Value;
			}
			set
			{
				short num = (short)866254848;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_31;
						}
						continue;
					case 1:
						this.cnvPerGeneralConventionalPersonalityName_A12660.Value = value;
						num = (short)1360134146;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_77;
					}
					goto IL_31;
					IL_3E:
					num = (short)1708785665;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_77:
					num = (short)1948265953;
					short num3 = num;
					num = (short)32845281;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_3E;
					default:
						goto IL_AC;
					}
					IL_31:
					if (!string.IsNullOrEmpty(value.Trim()))
					{
						goto IL_3E;
					}
					goto IL_77;
				}
				IL_AC:
				num = (short)699793408;
				short num4 = num;
				num = (short)5308417;
				if (num != 0)
				{
				}
				num = (short)1013055488;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x170063F0 RID: 25584
		// (get) Token: 0x0600C753 RID: 51027 RVA: 0x00BA82B0 File Offset: 0x00BA64B0
		// (set) Token: 0x0600C754 RID: 51028 RVA: 0x00BA8368 File Offset: 0x00BA6568
		public string CnvPerGeneralConventionalPersonalityName_A12660_UIValue
		{
			get
			{
				short num = (short)540046048;
				short num2 = num;
				num = (short)369455840;
				switch (num2 == num)
				{
				default:
				{
					num = (short)281542656;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1409875969;
				if (num != 0)
				{
				}
				num = (short)767295488;
				if (num != 0)
				{
				}
				return this.cnvPerGeneralConventionalPersonalityName_A12660.Value;
			}
			set
			{
				short num = (short)1237807781;
				short num2 = num;
				num = (short)1837331109;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1015087104;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1280704512;
				if (num != 0)
				{
				}
				num = (short)142737409;
				if (num != 0)
				{
				}
				this.cnvPerGeneralConventionalPersonalityName_A12660.Value = value;
			}
		}

		// Token: 0x170063F1 RID: 25585
		// (get) Token: 0x0600C755 RID: 51029 RVA: 0x00BA841C File Offset: 0x00BA661C
		public global::AcpBusinessLayer.AcpKeyField CnvPerGeneralConventionalPersonalityName_A12660
		{
			get
			{
				short num = (short)1555431425;
				if (num != 0)
				{
				}
				num = (short)1759444992;
				short num2 = num;
				num = (short)796986810;
				short num3 = num;
				num = (short)429067706;
				switch (num3 == num)
				{
				}
				num = (short)1188298752;
				if (num != 0)
				{
				}
				return this.cnvPerGeneralConventionalPersonalityName_A12660;
			}
		}

		// Token: 0x170063F2 RID: 25586
		// (get) Token: 0x0600C756 RID: 51030 RVA: 0x00BA84CC File Offset: 0x00BA66CC
		// (set) Token: 0x0600C757 RID: 51031 RVA: 0x00BA8584 File Offset: 0x00BA6784
		public bool CnvPerGeneralConventionalPersonalityName_A12660_Applicable
		{
			get
			{
				short num = (short)890643328;
				short num2 = num;
				num = (short)1588405120;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1101791232;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2009137152;
				if (num != 0)
				{
				}
				num = (short)39256065;
				if (num != 0)
				{
				}
				return this.cnvPerGeneralConventionalPersonalityName_A12660.Applicable;
			}
			set
			{
				short num = (short)855850804;
				short num2 = num;
				num = (short)1781022516;
				switch (num2 == num)
				{
				default:
				{
					num = (short)943194112;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1991049217;
				if (num != 0)
				{
				}
				num = (short)277282816;
				if (num != 0)
				{
				}
				this.cnvPerGeneralConventionalPersonalityName_A12660.Applicable = value;
			}
		}

		// Token: 0x170063F3 RID: 25587
		// (get) Token: 0x0600C758 RID: 51032 RVA: 0x00BA863C File Offset: 0x00BA683C
		// (set) Token: 0x0600C759 RID: 51033 RVA: 0x00BA86F4 File Offset: 0x00BA68F4
		public bool CnvPerGeneralConventionalPersonalityName_A12660_Valid
		{
			get
			{
				short num = (short)616925684;
				short num2 = num;
				num = (short)1315277300;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1254162432;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1067974657;
				if (num != 0)
				{
				}
				num = (short)514392064;
				if (num != 0)
				{
				}
				return this.cnvPerGeneralConventionalPersonalityName_A12660.Valid;
			}
			set
			{
				short num = (short)1868634957;
				short num2 = num;
				num = (short)653466445;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1136263168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1746534401;
				if (num != 0)
				{
				}
				num = (short)327155712;
				if (num != 0)
				{
				}
				this.cnvPerGeneralConventionalPersonalityName_A12660.Valid = value;
			}
		}

		// Token: 0x170063F4 RID: 25588
		// (get) Token: 0x0600C75A RID: 51034 RVA: 0x00BA87AC File Offset: 0x00BA69AC
		// (set) Token: 0x0600C75B RID: 51035 RVA: 0x00BA8864 File Offset: 0x00BA6A64
		public bool CnvPerGeneralConventionalPersonalityName_A12660_Visible
		{
			get
			{
				short num = (short)1300728072;
				short num2 = num;
				num = (short)1034389768;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1941176320;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)767361024;
				if (num != 0)
				{
				}
				num = (short)532283393;
				if (num != 0)
				{
				}
				return this.cnvPerGeneralConventionalPersonalityName_A12660.Visible;
			}
			set
			{
				short num = (short)580018355;
				short num2 = num;
				num = (short)1288724659;
				switch (num2 == num)
				{
				default:
				{
					num = (short)374210560;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1931673601;
				if (num != 0)
				{
				}
				num = (short)1820065792;
				if (num != 0)
				{
				}
				this.cnvPerGeneralConventionalPersonalityName_A12660.Visible = value;
			}
		}

		// Token: 0x170063F5 RID: 25589
		// (get) Token: 0x0600C75C RID: 51036 RVA: 0x00BA891C File Offset: 0x00BA6B1C
		// (set) Token: 0x0600C75D RID: 51037 RVA: 0x00BA89D0 File Offset: 0x00BA6BD0
		public bool CnvPerGeneralConventionalPersonalityName_A12660_Editable
		{
			get
			{
				short num = (short)1976292754;
				short num2 = num;
				num = (short)1498404242;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1038811136;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)764608513;
				if (num != 0)
				{
				}
				num = (short)1889730560;
				if (num != 0)
				{
				}
				return this.cnvPerGeneralConventionalPersonalityName_A12660.Editable;
			}
			set
			{
				short num = (short)1917287682;
				short num2 = num;
				num = (short)1089240322;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1435697152;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2100297729;
				if (num != 0)
				{
				}
				num = (short)1255997440;
				if (num != 0)
				{
				}
				this.cnvPerGeneralConventionalPersonalityName_A12660.Editable = value;
			}
		}

		// Token: 0x170063F6 RID: 25590
		// (get) Token: 0x0600C75E RID: 51038 RVA: 0x00BA8A84 File Offset: 0x00BA6C84
		internal string CnvPerGeneralConventionalPersonalityName_A12660_UILabel
		{
			get
			{
				short num = (short)519565247;
				short num2 = num;
				num = (short)1187901375;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1836908544;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)722206720;
				if (num != 0)
				{
				}
				num = (short)713555969;
				if (num != 0)
				{
				}
				return this.cnvPerGeneralConventionalPersonalityName_A12660.UIName;
			}
		}

		// Token: 0x170063F7 RID: 25591
		// (get) Token: 0x0600C75F RID: 51039 RVA: 0x00BA8B38 File Offset: 0x00BA6D38
		// (set) Token: 0x0600C760 RID: 51040 RVA: 0x00BA8BEC File Offset: 0x00BA6DEC
		internal bool CnvPerGeneralConventionalPersonalityName_A12660_HiddenStatic
		{
			get
			{
				short num = (short)264368722;
				short num2 = num;
				num = (short)259125842;
				switch (num2 == num)
				{
				default:
				{
					num = (short)618528768;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1429078017;
				if (num != 0)
				{
				}
				num = (short)1545994240;
				if (num != 0)
				{
				}
				return this.cnvPerGeneralConventionalPersonalityName_A12660.HiddenStatic;
			}
			set
			{
				short num = (short)954348258;
				short num2 = num;
				num = (short)1528902370;
				switch (num2 == num)
				{
				default:
				{
					num = (short)242614272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1147600896;
				if (num != 0)
				{
				}
				num = (short)1245052929;
				if (num != 0)
				{
				}
				this.cnvPerGeneralConventionalPersonalityName_A12660.HiddenStatic = value;
			}
		}

		// Token: 0x170063F8 RID: 25592
		// (get) Token: 0x0600C761 RID: 51041 RVA: 0x00BA8CA4 File Offset: 0x00BA6EA4
		// (set) Token: 0x0600C762 RID: 51042 RVA: 0x00BA8D58 File Offset: 0x00BA6F58
		internal bool CnvPerGeneralConventionalPersonalityName_A12660_HiddenDynamic
		{
			get
			{
				short num = (short)1469280044;
				short num2 = num;
				num = (short)629436204;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1073676288;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)544014337;
				if (num != 0)
				{
				}
				num = (short)809369600;
				if (num != 0)
				{
				}
				return this.cnvPerGeneralConventionalPersonalityName_A12660.HiddenDynamic;
			}
			set
			{
				short num = (short)1697506964;
				short num2 = num;
				num = (short)775349908;
				switch (num2 == num)
				{
				default:
				{
					num = (short)830799872;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)121503745;
				if (num != 0)
				{
				}
				num = (short)1754464256;
				if (num != 0)
				{
				}
				this.cnvPerGeneralConventionalPersonalityName_A12660.HiddenDynamic = value;
			}
		}

		// Token: 0x170063F9 RID: 25593
		// (get) Token: 0x0600C763 RID: 51043 RVA: 0x00BA8E0C File Offset: 0x00BA700C
		public bool CnvPerGeneralConventionalPersonalityName_A12660_HasDiffs
		{
			get
			{
				short num = (short)2095554831;
				short num2 = num;
				num = (short)294297871;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1931935744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1518469121;
				if (num != 0)
				{
				}
				num = (short)1246429184;
				if (num != 0)
				{
				}
				return this.cnvPerGeneralConventionalPersonalityName_A12660._HasDiffs;
			}
		}

		// Token: 0x170063FA RID: 25594
		// (get) Token: 0x0600C764 RID: 51044 RVA: 0x00BA8EC0 File Offset: 0x00BA70C0
		// (set) Token: 0x0600C765 RID: 51045 RVA: 0x00BA8F74 File Offset: 0x00BA7174
		public int CnvPerGeneralTalkgroupTextList_A19822Value
		{
			get
			{
				short num = (short)1808501438;
				short num2 = num;
				num = (short)149916350;
				switch (num2 == num)
				{
				default:
				{
					num = (short)519045120;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)583467009;
				if (num != 0)
				{
				}
				num = (short)446365696;
				if (num != 0)
				{
				}
				return this.cnvPerGeneralTalkgroupTextList_A19822.Value;
			}
			set
			{
				short num = (short)1307112674;
				short num2 = num;
				num = (short)1480717538;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1684930560;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)78118913;
				if (num != 0)
				{
				}
				num = (short)695992320;
				if (num != 0)
				{
				}
				this.cnvPerGeneralTalkgroupTextList_A19822.Value = value;
			}
		}

		// Token: 0x170063FB RID: 25595
		// (get) Token: 0x0600C766 RID: 51046 RVA: 0x00BA9028 File Offset: 0x00BA7228
		// (set) Token: 0x0600C767 RID: 51047 RVA: 0x00BA90E0 File Offset: 0x00BA72E0
		public string CnvPerGeneralTalkgroupTextList_A19822_UIValue
		{
			get
			{
				short num = (short)1869869422;
				short num2 = num;
				num = (short)576778606;
				switch (num2 == num)
				{
				default:
				{
					num = (short)153616384;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)473956353;
				if (num != 0)
				{
				}
				num = (short)1515847680;
				if (num != 0)
				{
				}
				return this.cnvPerGeneralTalkgroupTextList_A19822.UIValue;
			}
			set
			{
				short num = (short)1056336922;
				short num2 = num;
				num = (short)850750490;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1519845376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1391591424;
				if (num != 0)
				{
				}
				num = (short)1808138241;
				if (num != 0)
				{
				}
				this.cnvPerGeneralTalkgroupTextList_A19822.UIValue = value;
			}
		}

		// Token: 0x170063FC RID: 25596
		// (get) Token: 0x0600C768 RID: 51048 RVA: 0x00BA9194 File Offset: 0x00BA7394
		public global::AcpBusinessLayer.AcpRecRefField CnvPerGeneralTalkgroupTextList_A19822
		{
			get
			{
				short num = (short)1597662429;
				short num2 = num;
				num = (short)151217373;
				switch (num2 == num)
				{
				default:
				{
					num = (short)410845184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1481637889;
				if (num != 0)
				{
				}
				num = (short)1919090688;
				if (num != 0)
				{
				}
				return this.cnvPerGeneralTalkgroupTextList_A19822;
			}
		}

		// Token: 0x170063FD RID: 25597
		// (get) Token: 0x0600C769 RID: 51049 RVA: 0x00BA9244 File Offset: 0x00BA7444
		// (set) Token: 0x0600C76A RID: 51050 RVA: 0x00BA92FC File Offset: 0x00BA74FC
		public bool CnvPerGeneralTalkgroupTextList_A19822_Applicable
		{
			get
			{
				short num = (short)380262537;
				short num2 = num;
				num = (short)1278433417;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1192296448;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)278200321;
				if (num != 0)
				{
				}
				num = (short)1815085056;
				if (num != 0)
				{
				}
				return this.cnvPerGeneralTalkgroupTextList_A19822.Applicable;
			}
			set
			{
				short num = (short)1617512640;
				short num2 = num;
				num = (short)631785664;
				switch (num2 == num)
				{
				default:
				{
					num = (short)955777024;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)678559745;
				if (num != 0)
				{
				}
				num = (short)1454964736;
				if (num != 0)
				{
				}
				this.cnvPerGeneralTalkgroupTextList_A19822.Applicable = value;
			}
		}

		// Token: 0x170063FE RID: 25598
		// (get) Token: 0x0600C76B RID: 51051 RVA: 0x00BA93B4 File Offset: 0x00BA75B4
		// (set) Token: 0x0600C76C RID: 51052 RVA: 0x00BA9468 File Offset: 0x00BA7668
		public bool CnvPerGeneralTalkgroupTextList_A19822_Valid
		{
			get
			{
				short num = (short)1492318471;
				short num2 = num;
				num = (short)839842055;
				switch (num2 == num)
				{
				default:
				{
					num = (short)41156608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1706491904;
				if (num != 0)
				{
				}
				num = (short)613351425;
				if (num != 0)
				{
				}
				return this.cnvPerGeneralTalkgroupTextList_A19822.Valid;
			}
			set
			{
				short num = (short)1170924246;
				short num2 = num;
				num = (short)1657332438;
				switch (num2 == num)
				{
				default:
				{
					num = (short)52297728;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)550174721;
				if (num != 0)
				{
				}
				num = (short)2051735552;
				if (num != 0)
				{
				}
				this.cnvPerGeneralTalkgroupTextList_A19822.Valid = value;
			}
		}

		// Token: 0x170063FF RID: 25599
		// (get) Token: 0x0600C76D RID: 51053 RVA: 0x00BA951C File Offset: 0x00BA771C
		// (set) Token: 0x0600C76E RID: 51054 RVA: 0x00BA95D4 File Offset: 0x00BA77D4
		public bool CnvPerGeneralTalkgroupTextList_A19822_Visible
		{
			get
			{
				short num = (short)1483669505;
				if (num != 0)
				{
				}
				num = (short)570621952;
				short num2 = num;
				num = (short)376364950;
				short num3 = num;
				num = (short)788062102;
				switch (num3 == num)
				{
				}
				num = (short)2050555904;
				if (num != 0)
				{
				}
				return this.cnvPerGeneralTalkgroupTextList_A19822.Visible;
			}
			set
			{
				short num = (short)1662869938;
				short num2 = num;
				num = (short)2103140786;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1915289600;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1947533313;
				if (num != 0)
				{
				}
				num = (short)1606483968;
				if (num != 0)
				{
				}
				this.cnvPerGeneralTalkgroupTextList_A19822.Visible = value;
			}
		}

		// Token: 0x17006400 RID: 25600
		// (get) Token: 0x0600C76F RID: 51055 RVA: 0x00BA9688 File Offset: 0x00BA7888
		// (set) Token: 0x0600C770 RID: 51056 RVA: 0x00BA973C File Offset: 0x00BA793C
		public bool CnvPerGeneralTalkgroupTextList_A19822_Editable
		{
			get
			{
				short num = (short)1590611589;
				short num2 = num;
				num = (short)1162399365;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1300627456;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1011482625;
				if (num != 0)
				{
				}
				num = (short)854458368;
				if (num != 0)
				{
				}
				return this.cnvPerGeneralTalkgroupTextList_A19822.Editable;
			}
			set
			{
				short num = (short)2069809473;
				short num2 = num;
				num = (short)1769654593;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1699414016;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1974075393;
				if (num != 0)
				{
				}
				num = (short)797507584;
				if (num != 0)
				{
				}
				this.cnvPerGeneralTalkgroupTextList_A19822.Editable = value;
			}
		}

		// Token: 0x17006401 RID: 25601
		// (get) Token: 0x0600C771 RID: 51057 RVA: 0x00BA97F4 File Offset: 0x00BA79F4
		internal string CnvPerGeneralTalkgroupTextList_A19822_UILabel
		{
			get
			{
				short num = (short)886928105;
				short num2 = num;
				num = (short)2001236713;
				switch (num2 == num)
				{
				default:
				{
					num = (short)756613120;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1736376321;
				if (num != 0)
				{
				}
				num = (short)1224081408;
				if (num != 0)
				{
				}
				return this.cnvPerGeneralTalkgroupTextList_A19822.UIName;
			}
		}

		// Token: 0x17006402 RID: 25602
		// (get) Token: 0x0600C772 RID: 51058 RVA: 0x00BA98AC File Offset: 0x00BA7AAC
		// (set) Token: 0x0600C773 RID: 51059 RVA: 0x00BA9960 File Offset: 0x00BA7B60
		internal bool CnvPerGeneralTalkgroupTextList_A19822_HiddenStatic
		{
			get
			{
				short num = (short)200416931;
				short num2 = num;
				num = (short)1755586211;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1608908800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1651965953;
				if (num != 0)
				{
				}
				num = (short)791216128;
				if (num != 0)
				{
				}
				return this.cnvPerGeneralTalkgroupTextList_A19822.HiddenStatic;
			}
			set
			{
				short num = (short)330000868;
				short num2 = num;
				num = (short)1760717284;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2093940736;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)94437376;
				if (num != 0)
				{
				}
				num = (short)2005270529;
				if (num != 0)
				{
				}
				this.cnvPerGeneralTalkgroupTextList_A19822.HiddenStatic = value;
			}
		}

		// Token: 0x17006403 RID: 25603
		// (get) Token: 0x0600C774 RID: 51060 RVA: 0x00BA9A14 File Offset: 0x00BA7C14
		// (set) Token: 0x0600C775 RID: 51061 RVA: 0x00BA9AC8 File Offset: 0x00BA7CC8
		internal bool CnvPerGeneralTalkgroupTextList_A19822_HiddenDynamic
		{
			get
			{
				short num = (short)803518307;
				short num2 = num;
				num = (short)1737930595;
				switch (num2 == num)
				{
				default:
				{
					num = (short)339148800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)844038145;
				if (num != 0)
				{
				}
				num = (short)696975360;
				if (num != 0)
				{
				}
				return this.cnvPerGeneralTalkgroupTextList_A19822.HiddenDynamic;
			}
			set
			{
				short num = (short)637313821;
				short num2 = num;
				num = (short)671327005;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1046675456;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2043936769;
				if (num != 0)
				{
				}
				num = (short)2090860544;
				if (num != 0)
				{
				}
				this.cnvPerGeneralTalkgroupTextList_A19822.HiddenDynamic = value;
			}
		}

		// Token: 0x17006404 RID: 25604
		// (get) Token: 0x0600C776 RID: 51062 RVA: 0x00BA9B80 File Offset: 0x00BA7D80
		public bool CnvPerGeneralTalkgroupTextList_A19822_HasDiffs
		{
			get
			{
				short num = (short)956956673;
				if (num != 0)
				{
				}
				num = (short)9109504;
				short num2 = num;
				num = (short)2057127215;
				short num3 = num;
				num = (short)850478383;
				switch (num3 == num)
				{
				}
				num = (short)688914432;
				if (num != 0)
				{
				}
				return this.cnvPerGeneralTalkgroupTextList_A19822._HasDiffs;
			}
		}

		// Token: 0x17006405 RID: 25605
		// (get) Token: 0x0600C777 RID: 51063 RVA: 0x00BA9C34 File Offset: 0x00BA7E34
		// (set) Token: 0x0600C778 RID: 51064 RVA: 0x00BA9CE4 File Offset: 0x00BA7EE4
		public int CnvPerFeaturesDVRSProf_A41794Value
		{
			get
			{
				short num = (short)1297324076;
				short num2 = num;
				num = (short)1960613932;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1169489920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1424031745;
				if (num != 0)
				{
				}
				num = (short)1605173248;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesDVRSProf_A41794.Value;
			}
			set
			{
				short num = (short)1217225004;
				short num2 = num;
				num = (short)1326407980;
				switch (num2 == num)
				{
				default:
				{
					num = (short)407896064;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)224198657;
				if (num != 0)
				{
				}
				num = (short)1461387264;
				if (num != 0)
				{
				}
				this.cnvPerFeaturesDVRSProf_A41794.Value = value;
			}
		}

		// Token: 0x17006406 RID: 25606
		// (get) Token: 0x0600C779 RID: 51065 RVA: 0x00BA9D98 File Offset: 0x00BA7F98
		// (set) Token: 0x0600C77A RID: 51066 RVA: 0x00BA9E50 File Offset: 0x00BA8050
		public string CnvPerFeaturesDVRSProf_A41794_UIValue
		{
			get
			{
				short num = (short)2146057757;
				short num2 = num;
				num = (short)602619421;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1307770880;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)259391489;
				if (num != 0)
				{
				}
				num = (short)400949248;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesDVRSProf_A41794.UIValue;
			}
			set
			{
				short num = (short)388087272;
				short num2 = num;
				num = (short)232701416;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1276641280;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1408958464;
				if (num != 0)
				{
				}
				num = (short)1175715841;
				if (num != 0)
				{
				}
				this.cnvPerFeaturesDVRSProf_A41794.UIValue = value;
			}
		}

		// Token: 0x17006407 RID: 25607
		// (get) Token: 0x0600C77B RID: 51067 RVA: 0x00BA9F04 File Offset: 0x00BA8104
		public global::AcpBusinessLayer.AcpRecRefField CnvPerFeaturesDVRSProf_A41794
		{
			get
			{
				short num = (short)1263764501;
				short num2 = num;
				num = (short)1079542805;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2035286016;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)783679489;
				if (num != 0)
				{
				}
				num = (short)609615872;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesDVRSProf_A41794;
			}
		}

		// Token: 0x17006408 RID: 25608
		// (get) Token: 0x0600C77C RID: 51068 RVA: 0x00BA9FB4 File Offset: 0x00BA81B4
		// (set) Token: 0x0600C77D RID: 51069 RVA: 0x00BAA06C File Offset: 0x00BA826C
		public bool CnvPerFeaturesDVRSProf_A41794_Applicable
		{
			get
			{
				short num = (short)739829773;
				short num2 = num;
				num = (short)816703501;
				switch (num2 == num)
				{
				default:
				{
					num = (short)50331648;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)778371073;
				if (num != 0)
				{
				}
				num = (short)635305984;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesDVRSProf_A41794.Applicable;
			}
			set
			{
				short num = (short)1455030273;
				if (num != 0)
				{
				}
				num = (short)999620608;
				short num2 = num;
				num = (short)111712290;
				short num3 = num;
				num = (short)70686754;
				switch (num3 == num)
				{
				}
				num = (short)1214840832;
				if (num != 0)
				{
				}
				this.cnvPerFeaturesDVRSProf_A41794.Applicable = value;
			}
		}

		// Token: 0x17006409 RID: 25609
		// (get) Token: 0x0600C77E RID: 51070 RVA: 0x00BAA120 File Offset: 0x00BA8320
		// (set) Token: 0x0600C77F RID: 51071 RVA: 0x00BAA1D4 File Offset: 0x00BA83D4
		public bool CnvPerFeaturesDVRSProf_A41794_Valid
		{
			get
			{
				short num = (short)539128778;
				short num2 = num;
				num = (short)1538552778;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1521680384;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1284374529;
				if (num != 0)
				{
				}
				num = (short)210108416;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesDVRSProf_A41794.Valid;
			}
			set
			{
				short num = (short)1831572346;
				short num2 = num;
				num = (short)2123666298;
				switch (num2 == num)
				{
				default:
				{
					num = (short)685244416;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)785186817;
				if (num != 0)
				{
				}
				num = (short)1565523968;
				if (num != 0)
				{
				}
				this.cnvPerFeaturesDVRSProf_A41794.Valid = value;
			}
		}

		// Token: 0x1700640A RID: 25610
		// (get) Token: 0x0600C780 RID: 51072 RVA: 0x00BAA28C File Offset: 0x00BA848C
		// (set) Token: 0x0600C781 RID: 51073 RVA: 0x00BAA340 File Offset: 0x00BA8540
		public bool CnvPerFeaturesDVRSProf_A41794_Visible
		{
			get
			{
				short num = (short)442361468;
				short num2 = num;
				num = (short)678094460;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1484324864;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1021837313;
				if (num != 0)
				{
				}
				num = (short)1416298496;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesDVRSProf_A41794.Visible;
			}
			set
			{
				short num = (short)2095634095;
				short num2 = num;
				num = (short)1343477423;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1329004544;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)27656193;
				if (num != 0)
				{
				}
				num = (short)1404960768;
				if (num != 0)
				{
				}
				this.cnvPerFeaturesDVRSProf_A41794.Visible = value;
			}
		}

		// Token: 0x1700640B RID: 25611
		// (get) Token: 0x0600C782 RID: 51074 RVA: 0x00BAA3F8 File Offset: 0x00BA85F8
		// (set) Token: 0x0600C783 RID: 51075 RVA: 0x00BAA4AC File Offset: 0x00BA86AC
		public bool CnvPerFeaturesDVRSProf_A41794_Editable
		{
			get
			{
				short num = (short)1345900299;
				short num2 = num;
				num = (short)1939132171;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1594818560;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)391446529;
				if (num != 0)
				{
				}
				num = (short)808321024;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesDVRSProf_A41794.Editable;
			}
			set
			{
				short num = (short)1234370561;
				if (num != 0)
				{
				}
				num = (short)626130944;
				short num2 = num;
				num = (short)1937229207;
				short num3 = num;
				num = (short)1020970391;
				switch (num3 == num)
				{
				}
				num = (short)608567296;
				if (num != 0)
				{
				}
				this.cnvPerFeaturesDVRSProf_A41794.Editable = value;
			}
		}

		// Token: 0x1700640C RID: 25612
		// (get) Token: 0x0600C784 RID: 51076 RVA: 0x00BAA560 File Offset: 0x00BA8760
		internal string CnvPerFeaturesDVRSProf_A41794_UILabel
		{
			get
			{
				short num = (short)455902384;
				short num2 = num;
				num = (short)654476464;
				switch (num2 == num)
				{
				default:
				{
					num = (short)362545152;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)551747585;
				if (num != 0)
				{
				}
				num = (short)598474752;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesDVRSProf_A41794.UIName;
			}
		}

		// Token: 0x1700640D RID: 25613
		// (get) Token: 0x0600C785 RID: 51077 RVA: 0x00BAA614 File Offset: 0x00BA8814
		// (set) Token: 0x0600C786 RID: 51078 RVA: 0x00BAA6CC File Offset: 0x00BA88CC
		internal bool CnvPerFeaturesDVRSProf_A41794_HiddenStatic
		{
			get
			{
				short num = (short)36763705;
				short num2 = num;
				num = (short)218429497;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1798569984;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)910360576;
				if (num != 0)
				{
				}
				num = (short)1957822465;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesDVRSProf_A41794.HiddenStatic;
			}
			set
			{
				short num = (short)1096337402;
				short num2 = num;
				num = (short)360957946;
				switch (num2 == num)
				{
				default:
				{
					num = (short)945881088;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)887357441;
				if (num != 0)
				{
				}
				num = (short)1429733376;
				if (num != 0)
				{
				}
				this.cnvPerFeaturesDVRSProf_A41794.HiddenStatic = value;
			}
		}

		// Token: 0x1700640E RID: 25614
		// (get) Token: 0x0600C787 RID: 51079 RVA: 0x00BAA780 File Offset: 0x00BA8980
		// (set) Token: 0x0600C788 RID: 51080 RVA: 0x00BAA830 File Offset: 0x00BA8A30
		internal bool CnvPerFeaturesDVRSProf_A41794_HiddenDynamic
		{
			get
			{
				short num = (short)1926171019;
				short num2 = num;
				num = (short)384698763;
				switch (num2 == num)
				{
				default:
				{
					num = (short)189071360;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1951727616;
				if (num != 0)
				{
				}
				num = (short)1208680449;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesDVRSProf_A41794.HiddenDynamic;
			}
			set
			{
				short num = (short)2027895876;
				short num2 = num;
				num = (short)1155677252;
				switch (num2 == num)
				{
				default:
				{
					num = (short)716374016;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1447886848;
				if (num != 0)
				{
				}
				num = (short)1683816449;
				if (num != 0)
				{
				}
				this.cnvPerFeaturesDVRSProf_A41794.HiddenDynamic = value;
			}
		}

		// Token: 0x1700640F RID: 25615
		// (get) Token: 0x0600C789 RID: 51081 RVA: 0x00BAA8E4 File Offset: 0x00BA8AE4
		public bool CnvPerFeaturesDVRSProf_A41794_HasDiffs
		{
			get
			{
				short num = (short)501727686;
				short num2 = num;
				num = (short)426557894;
				switch (num2 == num)
				{
				default:
				{
					num = (short)146079744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)896794624;
				if (num != 0)
				{
				}
				num = (short)780664833;
				if (num != 0)
				{
				}
				return this.cnvPerFeaturesDVRSProf_A41794._HasDiffs;
			}
		}

		// Token: 0x17006410 RID: 25616
		// (get) Token: 0x0600C78A RID: 51082 RVA: 0x00BAA998 File Offset: 0x00BA8B98
		public global::Motorola.MackinawCPS.CoreFeatures.DVRSWide.DVRSWide RefDVRSWide
		{
			get
			{
				short num = (short)162598402;
				short num2 = num;
				num = (short)916721154;
				switch (num2 == num)
				{
				default:
				{
					num = (short)899022848;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2026700801;
				if (num != 0)
				{
				}
				num = (short)85393408;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(4142)[0] as global::Motorola.MackinawCPS.CoreFeatures.DVRSWide.DVRSWide;
			}
		}

		// Token: 0x17006411 RID: 25617
		// (get) Token: 0x0600C78B RID: 51083 RVA: 0x00BAAA58 File Offset: 0x00BA8C58
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide RefRadioWide
		{
			get
			{
				short num = (short)1495472668;
				short num2 = num;
				num = (short)642456092;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1498087424;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1840119809;
				if (num != 0)
				{
				}
				num = (short)335675392;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
			}
		}

		// Token: 0x0600C78C RID: 51084 RVA: 0x00BAAB18 File Offset: 0x00BA8D18
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_00:
				switch (0)
				{
				case 0:
					goto IL_24;
				}
				int num;
				short num2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
					{
						num2 = (short)1041825792;
						short num3 = num2;
						num2 = (short)559924474;
						short num4 = num2;
						num2 = (short)1878050042;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num2 = (short)387907585;
							if (num2 != 0)
							{
							}
							num2 = (short)685965312;
							if (num2 != 0)
							{
							}
							num2 = (short)243859458;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 1:
						result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
						num2 = (short)1068761092;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
						if (base.ParentRecset.ContainerDoc != null)
						{
							num2 = (short)367525889;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					case 3:
						if (base.ParentRecset != null)
						{
							num2 = (short)1805778944;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					case 4:
						return result;
					}
					break;
				}
				IL_24:
				result = null;
				num2 = (short)395771907;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			return result;
		}

		// Token: 0x040064AE RID: 25774
		private global::AcpBusinessLayer.AcpKeyField cnvPerGeneralConventionalPersonalityName_A12660;

		// Token: 0x040064AF RID: 25775
		private global::AcpBusinessLayer.AcpRecRefField cnvPerGeneralTalkgroupTextList_A19822;

		// Token: 0x040064B0 RID: 25776
		private global::AcpBusinessLayer.AcpRecRefField cnvPerFeaturesDVRSProf_A41794;
	}
}
