using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using ConstraintHelper;

namespace Motorola.MackinawCPS.CoreFeatures.Switches
{
	// Token: 0x020002B8 RID: 696
	[global::System.Serializable]
	public class MFKAssignmentControlInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06007502 RID: 29954 RVA: 0x006991E4 File Offset: 0x006973E4
		public MFKAssignmentControlInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06007503 RID: 29955 RVA: 0x00699200 File Offset: 0x00697400
		protected MFKAssignmentControlInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06007504 RID: 29956 RVA: 0x00699218 File Offset: 0x00697418
		public override void Init()
		{
			int a_ = 4;
			short num = (short)1156348766;
			short num2 = num;
			num = (short)1250589534;
			switch (num2 == num)
			{
			}
			num = (short)26738688;
			if (num != 0)
			{
			}
			num = (short)1255669761;
			if (num != 0)
			{
			}
			num = (short)1756364800;
			short num3 = num;
			this.radErgoControlSwitchsMFKFeatureAssignment_A38514 = new global::AcpBusinessLayer.AcpSparseLOVField(29, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.indexRadErgoControlSwitchsMFKFeatureAssignment_A38514LovStrs, global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.idRadErgoControlSwitchsMFKFeatureAssignment_A38514LovStrs), this, global::AllFeatures.CodeplugGuid.b("韄ꛆ귈車뿌꣎뻐郒뫔맖귘꧚닜돞닠铢賤鏦諨菪黬ꋮ런룲돴鋶飸迺裼跾搀䈂瘄理怈氊挌戎琐紒愔䠖堘⠚├⨞ဠᜢ", a_), global::CommonResources.AcgResources.ID_FEATURE, true, global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.RadErgoControlSwitchsMFKFeatureAssignment_A38514LovStrs);
			this.radErgoControlSwitchsMFKFeatureAssignment_A38514.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgoControlSwitchsMFKFeatureAssignment_A38514.DataTransferOrder = 1;
			this.radErgoControlSwitchsMFKFeatureAssignment_A38514.ValidateAcrossRecset = true;
			this.switchMFKAssignmentControlName_A38529 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_PRIMARYFUNCTION, this, global::AllFeatures.CodeplugGuid.b("雄냆ꃈ뿊껌꟎鳐闒黔雖꫘꣚드룞迠転胤触鷨꣪苬臮藰臲髴鯶럸髺郼髾帀䈂㘄㼆㰈㤊㐌", a_), global::CommonResources.AcgResources.ID_NAME, 100);
			this.switchMFKAssignmentControlName_A38529.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.switchMFKAssignmentControlName_A38529.DataTransferOrder = -1;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("裄臆苈鿌ꃎꗐ닒꟔껖律飚닜뇞闠釢諤详", a_);
			base.Id = 10638;
			base.UIName = global::CommonResources.AcgResources.ID_MFKROTARYCONTROL;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06007505 RID: 29957 RVA: 0x00699398 File Offset: 0x00697598
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 17;
			short num = (short)736296968;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					this.radErgoControlSwitchsMFKFeatureAssignment_A38514 = new global::AcpBusinessLayer.AcpSparseLOVField(29, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.indexRadErgoControlSwitchsMFKFeatureAssignment_A38514LovStrs, global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.idRadErgoControlSwitchsMFKFeatureAssignment_A38514LovStrs), this, global::AllFeatures.CodeplugGuid.b("胑뗓닕鷗꣙믛뇝ꏟ跡諣鋥髧藩胫뷭蟯鯱胳闵郷觹뇻룽䯿䐁愃朅簇缉縋欍儏愑朓缕缗琙焛笝丟嘡笣朥ᬧሩᤫἭЯ", a_), global::CommonResources.AcgResources.ID_FEATURE, true, global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.RadErgoControlSwitchsMFKFeatureAssignment_A38514LovStrs);
					this.radErgoControlSwitchsMFKFeatureAssignment_A38514.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radErgoControlSwitchsMFKFeatureAssignment_A38514.DataTransferOrder = 1;
					this.radErgoControlSwitchsMFKFeatureAssignment_A38514.ValidateAcrossRecset = true;
					num = (short)16646153;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("臑ꏓ뿕곗맙듛鏝ꛟꧡꗣ闥鯧菩诫胭鷯韱髳苵믷闹鋻諽狿洁栃䠅椇有椋儍儏ℑⰓ⌕⨗⌙", a_)))
					{
						num = (short)42663941;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2B8;
				case 2:
					num = (short)861732867;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("胑뗓닕鷗꣙믛뇝ꏟ跡諣鋥髧藩胫뷭蟯鯱胳闵郷觹뇻룽䯿䐁愃朅簇缉縋欍儏愑朓缕缗琙焛笝丟嘡笣朥ᬧሩᤫἭЯ", a_)))
					{
						num = (short)1474166784;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_79;
				case 4:
					if (producerFields != null)
					{
						num = (short)572063746;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2B8;
				case 5:
				{
					num = (short)947166470;
					short num3 = num;
					num = (short)607362310;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num = (short)493158401;
						if (num != 0)
						{
						}
						num = (short)312934400;
						if (num != 0)
						{
						}
						this.switchMFKAssignmentControlName_A38529 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_PRIMARYFUNCTION, this, global::AllFeatures.CodeplugGuid.b("臑ꏓ뿕곗맙듛鏝ꛟꧡꗣ闥鯧菩诫胭鷯韱髳苵믷闹鋻諽狿洁栃䠅椇有椋儍儏ℑⰓ⌕⨗⌙", a_), global::CommonResources.AcgResources.ID_NAME, 100);
						this.switchMFKAssignmentControlName_A38529.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
						this.switchMFKAssignmentControlName_A38529.DataTransferOrder = -1;
						num = (short)1465188359;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 6:
				{
					num = (short)729219072;
					short num4 = num;
					num = (short)28049412;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 7:
					goto IL_269;
				case 8:
					switch (0)
					{
					case 0:
						goto IL_56;
					}
					continue;
				case 9:
					goto IL_79;
				}
				IL_56:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1747386374;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_79:
				num = (short)1568210945;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_269:
			IL_2B8:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鿑鋓鷕裙돛ꫝ臟郡鷣웥ꯧ藩苫髭苯鷱飳", a_);
			base.Id = 10638;
			base.UIName = global::CommonResources.AcgResources.ID_MFKROTARYCONTROL;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06007506 RID: 29958 RVA: 0x00699690 File Offset: 0x00697890
		public override void PopulateReferences()
		{
			short num = (short)286321170;
			short num2 = num;
			num = (short)995944978;
			switch (num2 == num)
			{
			default:
			{
				num = (short)35979264;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1267531777;
			if (num != 0)
			{
			}
			num = (short)905510912;
			if (num != 0)
			{
			}
		}

		// Token: 0x06007507 RID: 29959 RVA: 0x0069973C File Offset: 0x0069793C
		public override void DropReferences()
		{
			short num = (short)1654878585;
			short num2 = num;
			num = (short)219312505;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2100625408;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1762263040;
			if (num != 0)
			{
			}
			num = (short)1627979777;
			if (num != 0)
			{
			}
		}

		// Token: 0x06007508 RID: 29960 RVA: 0x006997E4 File Offset: 0x006979E4
		public override void SetConstraints()
		{
			short num = (short)144209591;
			short num2 = num;
			num = (short)1145337527;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1053294592;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1150484480;
			if (num != 0)
			{
			}
			num = (short)347734017;
			if (num != 0)
			{
			}
			this.radErgoControlSwitchsMFKFeatureAssignment_A38514.ValidateAcrossRecset = true;
			this.radErgoControlSwitchsMFKFeatureAssignment_A38514.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.Switches.SwitchesConstraints.conPrimaryFunctionIsNonBlank);
			this.radErgoControlSwitchsMFKFeatureAssignment_A38514.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.Switches.SwitchesConstraints.conValidityMFKAssignControl);
			this.radErgoControlSwitchsMFKFeatureAssignment_A38514.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.Switches.SwitchesConstraints.ConSynO2AndO7MFKWithSwitchMFK);
			this.switchMFKAssignmentControlName_A38529.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
		}

		// Token: 0x06007509 RID: 29961 RVA: 0x006998F8 File Offset: 0x00697AF8
		public override void SetupDependencies()
		{
			short num = (short)303533816;
			short num2 = num;
			num = (short)1270451960;
			switch (num2 == num)
			{
			default:
			{
				num = (short)16252928;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)419102721;
			if (num != 0)
			{
			}
			num = (short)2008088576;
			if (num != 0)
			{
			}
		}

		// Token: 0x17003C4C RID: 15436
		// (get) Token: 0x0600750A RID: 29962 RVA: 0x006999A0 File Offset: 0x00697BA0
		public bool HasDiffs
		{
			get
			{
				short num = (short)175549088;
				short num2 = num;
				num = (short)3123872;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1920335872;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1994522625;
				if (num != 0)
				{
				}
				num = (short)1965424640;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17003C4D RID: 15437
		// (get) Token: 0x0600750B RID: 29963 RVA: 0x00699A50 File Offset: 0x00697C50
		// (set) Token: 0x0600750C RID: 29964 RVA: 0x00699B04 File Offset: 0x00697D04
		public int RadErgoControlSwitchsMFKFeatureAssignment_A38514Value
		{
			get
			{
				short num = (short)481595816;
				short num2 = num;
				num = (short)1897435560;
				switch (num2 == num)
				{
				default:
				{
					num = (short)719060992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1313669121;
				if (num != 0)
				{
				}
				num = (short)759037952;
				if (num != 0)
				{
				}
				return this.radErgoControlSwitchsMFKFeatureAssignment_A38514.Value;
			}
			set
			{
				short num = (short)20932293;
				short num2 = num;
				num = (short)1322542789;
				switch (num2 == num)
				{
				default:
				{
					num = (short)818741248;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1421934592;
				if (num != 0)
				{
				}
				num = (short)2131558401;
				if (num != 0)
				{
				}
				this.radErgoControlSwitchsMFKFeatureAssignment_A38514.Value = value;
			}
		}

		// Token: 0x17003C4E RID: 15438
		// (get) Token: 0x0600750D RID: 29965 RVA: 0x00699BBC File Offset: 0x00697DBC
		// (set) Token: 0x0600750E RID: 29966 RVA: 0x00699C74 File Offset: 0x00697E74
		public string RadErgoControlSwitchsMFKFeatureAssignment_A38514_UIValue
		{
			get
			{
				short num = (short)1840277585;
				short num2 = num;
				num = (short)1164142673;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1307049984;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1552023552;
				if (num != 0)
				{
				}
				num = (short)1666646017;
				if (num != 0)
				{
				}
				return this.radErgoControlSwitchsMFKFeatureAssignment_A38514.UIValue;
			}
			set
			{
				short num = (short)1442954345;
				short num2 = num;
				num = (short)1708244073;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1450639360;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1861156865;
				if (num != 0)
				{
				}
				num = (short)1499398144;
				if (num != 0)
				{
				}
				this.radErgoControlSwitchsMFKFeatureAssignment_A38514.UIValue = value;
			}
		}

		// Token: 0x17003C4F RID: 15439
		// (get) Token: 0x0600750F RID: 29967 RVA: 0x00699D2C File Offset: 0x00697F2C
		public global::AcpBusinessLayer.AcpListField RadErgoControlSwitchsMFKFeatureAssignment_A38514
		{
			get
			{
				short num = (short)583502172;
				short num2 = num;
				num = (short)1576307036;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2133590016;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1316814849;
				if (num != 0)
				{
				}
				num = (short)1258422272;
				if (num != 0)
				{
				}
				return this.radErgoControlSwitchsMFKFeatureAssignment_A38514;
			}
		}

		// Token: 0x17003C50 RID: 15440
		// (get) Token: 0x06007510 RID: 29968 RVA: 0x00699DDC File Offset: 0x00697FDC
		// (set) Token: 0x06007511 RID: 29969 RVA: 0x00699E94 File Offset: 0x00698094
		public bool RadErgoControlSwitchsMFKFeatureAssignment_A38514_Applicable
		{
			get
			{
				short num = (short)514260993;
				if (num != 0)
				{
				}
				num = (short)249561088;
				short num2 = num;
				num = (short)2036977585;
				short num3 = num;
				num = (short)1876807601;
				switch (num3 == num)
				{
				}
				num = (short)500629504;
				if (num != 0)
				{
				}
				return this.radErgoControlSwitchsMFKFeatureAssignment_A38514.Applicable;
			}
			set
			{
				short num = (short)820902172;
				short num2 = num;
				num = (short)509409564;
				switch (num2 == num)
				{
				default:
				{
					num = (short)299958272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)809631745;
				if (num != 0)
				{
				}
				num = (short)193462272;
				if (num != 0)
				{
				}
				this.radErgoControlSwitchsMFKFeatureAssignment_A38514.Applicable = value;
			}
		}

		// Token: 0x17003C51 RID: 15441
		// (get) Token: 0x06007512 RID: 29970 RVA: 0x00699F48 File Offset: 0x00698148
		// (set) Token: 0x06007513 RID: 29971 RVA: 0x00699FFC File Offset: 0x006981FC
		public bool RadErgoControlSwitchsMFKFeatureAssignment_A38514_Valid
		{
			get
			{
				short num = (short)1924985933;
				short num2 = num;
				num = (short)1592980557;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1832910848;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2086010880;
				if (num != 0)
				{
				}
				num = (short)168361985;
				if (num != 0)
				{
				}
				return this.radErgoControlSwitchsMFKFeatureAssignment_A38514.Valid;
			}
			set
			{
				short num = (short)1869110244;
				short num2 = num;
				num = (short)52190180;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1042219008;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2103443457;
				if (num != 0)
				{
				}
				num = (short)1708064768;
				if (num != 0)
				{
				}
				this.radErgoControlSwitchsMFKFeatureAssignment_A38514.Valid = value;
			}
		}

		// Token: 0x17003C52 RID: 15442
		// (get) Token: 0x06007514 RID: 29972 RVA: 0x0069A0B0 File Offset: 0x006982B0
		// (set) Token: 0x06007515 RID: 29973 RVA: 0x0069A160 File Offset: 0x00698360
		public bool RadErgoControlSwitchsMFKFeatureAssignment_A38514_Visible
		{
			get
			{
				short num = (short)146800641;
				if (num != 0)
				{
				}
				num = (short)237830144;
				short num2 = num;
				num = (short)1113148345;
				short num3 = num;
				num = (short)1675054009;
				switch (num3 == num)
				{
				}
				num = (short)1551433728;
				if (num != 0)
				{
				}
				return this.radErgoControlSwitchsMFKFeatureAssignment_A38514.Visible;
			}
			set
			{
				short num = (short)1272887729;
				short num2 = num;
				num = (short)1493023153;
				switch (num2 == num)
				{
				default:
				{
					num = (short)289734656;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)295632897;
				if (num != 0)
				{
				}
				num = (short)1605697536;
				if (num != 0)
				{
				}
				this.radErgoControlSwitchsMFKFeatureAssignment_A38514.Visible = value;
			}
		}

		// Token: 0x17003C53 RID: 15443
		// (get) Token: 0x06007516 RID: 29974 RVA: 0x0069A214 File Offset: 0x00698414
		// (set) Token: 0x06007517 RID: 29975 RVA: 0x0069A2C4 File Offset: 0x006984C4
		public bool RadErgoControlSwitchsMFKFeatureAssignment_A38514_Editable
		{
			get
			{
				short num = (short)2103643237;
				short num2 = num;
				num = (short)1662651493;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1997537280;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1889533953;
				if (num != 0)
				{
				}
				num = (short)1098317824;
				if (num != 0)
				{
				}
				return this.radErgoControlSwitchsMFKFeatureAssignment_A38514.Editable;
			}
			set
			{
				short num = (short)1446597347;
				short num2 = num;
				num = (short)1806193379;
				switch (num2 == num)
				{
				default:
				{
					num = (short)758972416;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)711786497;
				if (num != 0)
				{
				}
				num = (short)1694236672;
				if (num != 0)
				{
				}
				this.radErgoControlSwitchsMFKFeatureAssignment_A38514.Editable = value;
			}
		}

		// Token: 0x17003C54 RID: 15444
		// (get) Token: 0x06007518 RID: 29976 RVA: 0x0069A37C File Offset: 0x0069857C
		internal string RadErgoControlSwitchsMFKFeatureAssignment_A38514_UILabel
		{
			get
			{
				short num = (short)319390915;
				short num2 = num;
				num = (short)546276547;
				switch (num2 == num)
				{
				default:
				{
					num = (short)500760576;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)928776192;
				if (num != 0)
				{
				}
				num = (short)2025127937;
				if (num != 0)
				{
				}
				return this.radErgoControlSwitchsMFKFeatureAssignment_A38514.UIName;
			}
		}

		// Token: 0x17003C55 RID: 15445
		// (get) Token: 0x06007519 RID: 29977 RVA: 0x0069A430 File Offset: 0x00698630
		// (set) Token: 0x0600751A RID: 29978 RVA: 0x0069A4E4 File Offset: 0x006986E4
		internal bool RadErgoControlSwitchsMFKFeatureAssignment_A38514_HiddenStatic
		{
			get
			{
				short num = (short)1786751015;
				short num2 = num;
				num = (short)1934075943;
				switch (num2 == num)
				{
				default:
				{
					num = (short)734724096;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)105250816;
				if (num != 0)
				{
				}
				num = (short)1088094209;
				if (num != 0)
				{
				}
				return this.radErgoControlSwitchsMFKFeatureAssignment_A38514.HiddenStatic;
			}
			set
			{
				short num = (short)857669633;
				if (num != 0)
				{
				}
				num = (short)387186688;
				short num2 = num;
				num = (short)1577033895;
				short num3 = num;
				num = (short)1132961959;
				switch (num3 == num)
				{
				}
				num = (short)1860632576;
				if (num != 0)
				{
				}
				this.radErgoControlSwitchsMFKFeatureAssignment_A38514.HiddenStatic = value;
			}
		}

		// Token: 0x17003C56 RID: 15446
		// (get) Token: 0x0600751B RID: 29979 RVA: 0x0069A59C File Offset: 0x0069879C
		// (set) Token: 0x0600751C RID: 29980 RVA: 0x0069A650 File Offset: 0x00698850
		internal bool RadErgoControlSwitchsMFKFeatureAssignment_A38514_HiddenDynamic
		{
			get
			{
				short num = (short)714545223;
				short num2 = num;
				num = (short)274864199;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1385299968;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)865796097;
				if (num != 0)
				{
				}
				num = (short)1006960640;
				if (num != 0)
				{
				}
				return this.radErgoControlSwitchsMFKFeatureAssignment_A38514.HiddenDynamic;
			}
			set
			{
				short num = (short)30497165;
				short num2 = num;
				num = (short)1056528781;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1917124608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1862729729;
				if (num != 0)
				{
				}
				num = (short)121962496;
				if (num != 0)
				{
				}
				this.radErgoControlSwitchsMFKFeatureAssignment_A38514.HiddenDynamic = value;
			}
		}

		// Token: 0x17003C57 RID: 15447
		// (get) Token: 0x0600751D RID: 29981 RVA: 0x0069A704 File Offset: 0x00698904
		public bool RadErgoControlSwitchsMFKFeatureAssignment_A38514_HasDiffs
		{
			get
			{
				short num = (short)1384905898;
				short num2 = num;
				num = (short)73268394;
				switch (num2 == num)
				{
				default:
				{
					num = (short)920453120;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1032585217;
				if (num != 0)
				{
				}
				num = (short)1154351104;
				if (num != 0)
				{
				}
				return this.radErgoControlSwitchsMFKFeatureAssignment_A38514._HasDiffs;
			}
		}

		// Token: 0x17003C58 RID: 15448
		// (get) Token: 0x0600751E RID: 29982 RVA: 0x0069A7B8 File Offset: 0x006989B8
		// (set) Token: 0x0600751F RID: 29983 RVA: 0x0069A86C File Offset: 0x00698A6C
		public string SwitchMFKAssignmentControlName_A38529Value
		{
			get
			{
				short num = (short)1272956095;
				short num2 = num;
				num = (short)376620223;
				switch (num2 == num)
				{
				default:
				{
					num = (short)360448000;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)198311937;
				if (num != 0)
				{
				}
				num = (short)130416640;
				if (num != 0)
				{
				}
				return this.switchMFKAssignmentControlName_A38529.Value;
			}
			set
			{
				short num = (short)1161166268;
				short num2 = num;
				num = (short)947912124;
				switch (num2 == num)
				{
				default:
				{
					num = (short)321519616;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1303773184;
				if (num != 0)
				{
				}
				num = (short)173015041;
				if (num != 0)
				{
				}
				this.switchMFKAssignmentControlName_A38529.Value = value;
			}
		}

		// Token: 0x17003C59 RID: 15449
		// (get) Token: 0x06007520 RID: 29984 RVA: 0x0069A920 File Offset: 0x00698B20
		public global::AcpBusinessLayer.AcpField<string> SwitchMFKAssignmentControlName_A38529
		{
			get
			{
				short num = (short)1950571176;
				short num2 = num;
				num = (short)1765300904;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1976107008;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)633733121;
				if (num != 0)
				{
				}
				num = (short)1900675072;
				if (num != 0)
				{
				}
				return this.switchMFKAssignmentControlName_A38529;
			}
		}

		// Token: 0x17003C5A RID: 15450
		// (get) Token: 0x06007521 RID: 29985 RVA: 0x0069A9D0 File Offset: 0x00698BD0
		// (set) Token: 0x06007522 RID: 29986 RVA: 0x0069AA84 File Offset: 0x00698C84
		public string SwitchMFKAssignmentControlName_A38529_UIValue
		{
			get
			{
				short num = (short)205910846;
				short num2 = num;
				num = (short)330625854;
				switch (num2 == num)
				{
				default:
				{
					num = (short)724893696;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)15007744;
				if (num != 0)
				{
				}
				num = (short)2049507329;
				if (num != 0)
				{
				}
				return this.switchMFKAssignmentControlName_A38529.Value;
			}
			set
			{
				short num = (short)482335748;
				short num2 = num;
				num = (short)1662180356;
				switch (num2 == num)
				{
				}
				num = (short)2042757120;
				short num3 = num;
				num = (short)1554251777;
				if (num != 0)
				{
				}
				num = (short)174981120;
				if (num != 0)
				{
				}
				this.switchMFKAssignmentControlName_A38529.Value = value;
			}
		}

		// Token: 0x17003C5B RID: 15451
		// (get) Token: 0x06007523 RID: 29987 RVA: 0x0069AB3C File Offset: 0x00698D3C
		// (set) Token: 0x06007524 RID: 29988 RVA: 0x0069ABF4 File Offset: 0x00698DF4
		public bool SwitchMFKAssignmentControlName_A38529_Applicable
		{
			get
			{
				short num = (short)935389419;
				short num2 = num;
				num = (short)1820911851;
				switch (num2 == num)
				{
				}
				num = (short)2029715456;
				short num3 = num;
				num = (short)302579713;
				if (num != 0)
				{
				}
				num = (short)965410816;
				if (num != 0)
				{
				}
				return this.switchMFKAssignmentControlName_A38529.Applicable;
			}
			set
			{
				short num = (short)3904585;
				short num2 = num;
				num = (short)495096905;
				switch (num2 == num)
				{
				}
				num = (short)288489472;
				short num3 = num;
				num = (short)1495203840;
				if (num != 0)
				{
				}
				num = (short)359661569;
				if (num != 0)
				{
				}
				this.switchMFKAssignmentControlName_A38529.Applicable = value;
			}
		}

		// Token: 0x17003C5C RID: 15452
		// (get) Token: 0x06007525 RID: 29989 RVA: 0x0069ACAC File Offset: 0x00698EAC
		// (set) Token: 0x06007526 RID: 29990 RVA: 0x0069AD60 File Offset: 0x00698F60
		public bool SwitchMFKAssignmentControlName_A38529_Valid
		{
			get
			{
				short num = (short)384218247;
				short num2 = num;
				num = (short)107525255;
				switch (num2 == num)
				{
				}
				num = (short)336265216;
				short num3 = num;
				num = (short)2112159745;
				if (num != 0)
				{
				}
				num = (short)1718026240;
				if (num != 0)
				{
				}
				return this.switchMFKAssignmentControlName_A38529.Valid;
			}
			set
			{
				short num = (short)85852183;
				short num2 = num;
				num = (short)1249378327;
				switch (num2 == num)
				{
				}
				num = (short)1639317504;
				short num3 = num;
				num = (short)1713963009;
				if (num != 0)
				{
				}
				num = (short)885653504;
				if (num != 0)
				{
				}
				this.switchMFKAssignmentControlName_A38529.Valid = value;
			}
		}

		// Token: 0x17003C5D RID: 15453
		// (get) Token: 0x06007527 RID: 29991 RVA: 0x0069AE14 File Offset: 0x00699014
		// (set) Token: 0x06007528 RID: 29992 RVA: 0x0069AEC8 File Offset: 0x006990C8
		public bool SwitchMFKAssignmentControlName_A38529_Visible
		{
			get
			{
				short num = (short)429928798;
				short num2 = num;
				num = (short)494809438;
				switch (num2 == num)
				{
				}
				num = (short)811532288;
				short num3 = num;
				num = (short)1136525312;
				if (num != 0)
				{
				}
				num = (short)1932722177;
				if (num != 0)
				{
				}
				return this.switchMFKAssignmentControlName_A38529.Visible;
			}
			set
			{
				short num = (short)1241746837;
				short num2 = num;
				num = (short)1541246357;
				switch (num2 == num)
				{
				}
				num = (short)1862074368;
				short num3 = num;
				num = (short)65994753;
				if (num != 0)
				{
				}
				num = (short)162070528;
				if (num != 0)
				{
				}
				this.switchMFKAssignmentControlName_A38529.Visible = value;
			}
		}

		// Token: 0x17003C5E RID: 15454
		// (get) Token: 0x06007529 RID: 29993 RVA: 0x0069AF7C File Offset: 0x0069917C
		// (set) Token: 0x0600752A RID: 29994 RVA: 0x0069B030 File Offset: 0x00699230
		public bool SwitchMFKAssignmentControlName_A38529_Editable
		{
			get
			{
				short num = (short)1512154655;
				short num2 = num;
				num = (short)553887263;
				switch (num2 == num)
				{
				}
				num = (short)1372585984;
				short num3 = num;
				num = (short)1041432577;
				if (num != 0)
				{
				}
				num = (short)840368128;
				if (num != 0)
				{
				}
				return this.switchMFKAssignmentControlName_A38529.Editable;
			}
			set
			{
				short num = (short)1147863041;
				if (num != 0)
				{
				}
				num = (short)1268033637;
				short num2 = num;
				num = (short)1931913317;
				switch (num2 == num)
				{
				default:
				{
					num = (short)875626496;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)635043840;
				if (num != 0)
				{
				}
				this.switchMFKAssignmentControlName_A38529.Editable = value;
			}
		}

		// Token: 0x17003C5F RID: 15455
		// (get) Token: 0x0600752B RID: 29995 RVA: 0x0069B0E4 File Offset: 0x006992E4
		internal string SwitchMFKAssignmentControlName_A38529_UILabel
		{
			get
			{
				short num = (short)1586966983;
				short num2 = num;
				num = (short)1458450887;
				switch (num2 == num)
				{
				}
				num = (short)1851654144;
				short num3 = num;
				num = (short)703266817;
				if (num != 0)
				{
				}
				num = (short)1610022912;
				if (num != 0)
				{
				}
				return this.switchMFKAssignmentControlName_A38529.UIName;
			}
		}

		// Token: 0x17003C60 RID: 15456
		// (get) Token: 0x0600752C RID: 29996 RVA: 0x0069B198 File Offset: 0x00699398
		// (set) Token: 0x0600752D RID: 29997 RVA: 0x0069B24C File Offset: 0x0069944C
		internal bool SwitchMFKAssignmentControlName_A38529_HiddenStatic
		{
			get
			{
				short num = (short)1865670435;
				short num2 = num;
				num = (short)766762787;
				switch (num2 == num)
				{
				}
				num = (short)3735552;
				short num3 = num;
				num = (short)1725497345;
				if (num != 0)
				{
				}
				num = (short)1340211200;
				if (num != 0)
				{
				}
				return this.switchMFKAssignmentControlName_A38529.HiddenStatic;
			}
			set
			{
				short num = (short)1780841080;
				short num2 = num;
				num = (short)1429109368;
				switch (num2 == num)
				{
				}
				num = (short)830341120;
				short num3 = num;
				num = (short)1784545281;
				if (num != 0)
				{
				}
				num = (short)1927020544;
				if (num != 0)
				{
				}
				this.switchMFKAssignmentControlName_A38529.HiddenStatic = value;
			}
		}

		// Token: 0x17003C61 RID: 15457
		// (get) Token: 0x0600752E RID: 29998 RVA: 0x0069B300 File Offset: 0x00699500
		// (set) Token: 0x0600752F RID: 29999 RVA: 0x0069B3B4 File Offset: 0x006995B4
		internal bool SwitchMFKAssignmentControlName_A38529_HiddenDynamic
		{
			get
			{
				short num = (short)1056243713;
				if (num != 0)
				{
				}
				num = (short)984919958;
				short num2 = num;
				num = (short)1904914326;
				switch (num2 == num)
				{
				default:
				{
					num = (short)504561664;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)12582912;
				if (num != 0)
				{
				}
				return this.switchMFKAssignmentControlName_A38529.HiddenDynamic;
			}
			set
			{
				short num = (short)372113409;
				if (num != 0)
				{
				}
				num = (short)948203996;
				short num2 = num;
				num = (short)2043310556;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2132738048;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1654063104;
				if (num != 0)
				{
				}
				this.switchMFKAssignmentControlName_A38529.HiddenDynamic = value;
			}
		}

		// Token: 0x17003C62 RID: 15458
		// (get) Token: 0x06007530 RID: 30000 RVA: 0x0069B46C File Offset: 0x0069966C
		public bool SwitchMFKAssignmentControlName_A38529_HasDiffs
		{
			get
			{
				short num = (short)216504564;
				short num2 = num;
				num = (short)1182177524;
				switch (num2 == num)
				{
				}
				num = (short)974061568;
				short num3 = num;
				num = (short)1631715328;
				if (num != 0)
				{
				}
				num = (short)1430585345;
				if (num != 0)
				{
				}
				return this.switchMFKAssignmentControlName_A38529._HasDiffs;
			}
		}

		// Token: 0x06007531 RID: 30001 RVA: 0x0069B524 File Offset: 0x00699724
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_00:
				switch (0)
				{
				case 0:
					goto IL_6E;
				}
				short num;
				int num3;
				for (;;)
				{
					IL_0A:
					num = (short)1809709275;
					short num2 = num;
					num = (short)2035284187;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_00;
					default:
						num = (short)1487273984;
						if (num != 0)
						{
						}
						switch (num3)
						{
						case 0:
							return result;
						case 1:
							if (base.ParentRecset != null)
							{
								num = (short)1383596036;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							return result;
						case 2:
							if (base.ParentRecset.ContainerDoc != null)
							{
								num = (short)1103495171;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							return result;
						case 3:
						{
							num = (short)1237778433;
							if (num != 0)
							{
							}
							result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
							num = (short)673316864;
							short num4 = num;
							num = (short)2069889024;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							num = (short)1552678914;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6E;
					}
				}
				IL_6E:
				result = null;
				num = (short)746913793;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}
			return result;
		}

		// Token: 0x04002F7D RID: 12157
		private global::AcpBusinessLayer.AcpListField radErgoControlSwitchsMFKFeatureAssignment_A38514;

		// Token: 0x04002F7E RID: 12158
		private global::AcpBusinessLayer.AcpField<string> switchMFKAssignmentControlName_A38529;
	}
}
