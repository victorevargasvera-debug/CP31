using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.TrunkingSystem
{
	// Token: 0x0200009A RID: 154
	[global::System.Serializable]
	public class MessageAliasInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06001193 RID: 4499 RVA: 0x0010E450 File Offset: 0x0010C650
		public MessageAliasInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06001194 RID: 4500 RVA: 0x0010E46C File Offset: 0x0010C66C
		protected MessageAliasInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06001195 RID: 4501 RVA: 0x0010E484 File Offset: 0x0010C684
		public override void Init()
		{
			int a_ = 17;
			short num = (short)1481716452;
			short num2 = num;
			num = (short)1809986276;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1871642624;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1085800449;
			if (num != 0)
			{
			}
			num = (short)1572995072;
			if (num != 0)
			{
			}
			this.trkSysMessageAliasMessageAliasText_A8503 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_MESSAGE1, this, global::AllFeatures.CodeplugGuid.b("蛑ꛓ뷕诗ꏙ꿛鏝藟釡韣蟥迧迩귫苭駯鏱蟳믵鷷觹迻鿽柿朁䔃樅愇欉缋娍甏樑怓䤕夗∙⤛⸝ጟ", a_), global::CommonResources.AcgResources.ID_MESSAGEALIASTEXT, 14);
			this.trkSysMessageAliasMessageAliasText_A8503.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.trkSysMessageAliasMessageAliasText_A8503.DataTransferOrder = 39;
			this.trkSysMsgAlias_A24069 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("蛑ꛓ뷕诗ꏙ꿛鏝鏟藡ꗣ諥臧诩鿫뇭뇯샱샳웵컷쏹", a_), global::CommonResources.AcgResources.ID_POSITION);
			this.trkSysMsgAlias_A24069.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.trkSysMsgAlias_A24069.DataTransferOrder = -1;
			this.trkSysMessageAliasMessageAliasNumber_A8500 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("蛑ꛓ뷕诗ꏙ꿛鏝藟釡韣蟥迧迩귫苭駯鏱蟳믵鷷觹迻鿽柿朁䔃樅愇欉缋䀍攏缑瘓猕樗䔙崛☝ᔟሡᐣ", a_), global::CommonResources.AcgResources.ID_MESSAGEALIASNUMBER, 1, 16, null, null, 0, 1);
			this.trkSysMessageAliasMessageAliasNumber_A8500.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkSysMessageAliasMessageAliasNumber_A8500.DataTransferOrder = 85;
			this.trkSysMessageAliasMessageAliasNumber_A8500.ShowHexValue = false;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鿑뇓ꗕꯗ믙믛믝샟ꏡ裣迥觧駩", a_);
			base.Id = 10164;
			base.UIName = global::CommonResources.AcgResources.ID_MESSAGEALIAS;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06001196 RID: 4502 RVA: 0x0010E628 File Offset: 0x0010C828
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 2;
			short num = (short)336789516;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)683606020;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_16C;
				case 2:
				{
					num = (short)1408795494;
					short num3 = num;
					num = (short)658998118;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_16C;
					default:
						num = (short)690290688;
						if (num != 0)
						{
						}
						if (producerFields != null)
						{
							num = (short)835649536;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_354;
					}
					break;
				}
				case 3:
					goto IL_1D1;
				case 4:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("韂럄곆髈닊뻌苎듐ꃒꛔ뛖뻘뻚鳜돞裠苢雤ꫦ賨飪黬軮雰雲듴鯶郸髺軼꯾搀笂焄堆䠈㌊㠌㼎∐", a_)))
					{
						num = (short)850591745;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_DA;
				case 5:
					num = (short)1948385281;
					if (num != 0)
					{
					}
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("韂럄곆髈닊뻌苎듐ꃒꛔ뛖뻘뻚鳜돞裠苢雤ꫦ賨飪黬軮雰雲듴鯶郸髺軼뇾琀渂朄戆笈吊䰌㜎␐⌒└", a_)))
					{
						num = (short)1263206410;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_354;
				case 6:
					goto IL_25D;
				case 7:
					goto IL_DA;
				case 8:
					this.trkSysMsgAlias_A24069 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("韂럄곆髈닊뻌苎ꋐ듒铔믖냘뫚껜胞ꃠ퇢퇤ퟦ\udfe8틪", a_), global::CommonResources.AcgResources.ID_POSITION);
					this.trkSysMsgAlias_A24069.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.trkSysMsgAlias_A24069.DataTransferOrder = -1;
					num = (short)1444020230;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					num = (short)1118240770;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					this.trkSysMessageAliasMessageAliasNumber_A8500 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("韂럄곆髈닊뻌苎듐ꃒꛔ뛖뻘뻚鳜돞裠苢雤ꫦ賨飪黬軮雰雲듴鯶郸髺軼뇾琀渂朄戆笈吊䰌㜎␐⌒└", a_), global::CommonResources.AcgResources.ID_MESSAGEALIASNUMBER, null, null, 0, 1);
					this.trkSysMessageAliasMessageAliasNumber_A8500.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkSysMessageAliasMessageAliasNumber_A8500.DataTransferOrder = 85;
					this.trkSysMessageAliasMessageAliasNumber_A8500.ShowHexValue = false;
					num = (short)916520963;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("韂럄곆髈닊뻌苎ꋐ듒铔믖냘뫚껜胞ꃠ퇢퇤ퟦ\udfe8틪", a_)))
					{
						num = (short)1924923400;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_25D;
				case 12:
					switch (0)
					{
					case 0:
						goto IL_62;
					}
					continue;
				}
				IL_62:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1941241865;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_DA:
				num = (short)1659240459;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_16C:
				this.trkSysMessageAliasMessageAliasText_A8503 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_MESSAGE1, this, global::AllFeatures.CodeplugGuid.b("韂럄곆髈닊뻌苎듐ꃒꛔ뛖뻘뻚鳜돞裠苢雤ꫦ賨飪黬軮雰雲듴鯶郸髺軼꯾搀笂焄堆䠈㌊㠌㼎∐", a_), global::CommonResources.AcgResources.ID_MESSAGEALIASTEXT, 14);
				this.trkSysMessageAliasMessageAliasText_A8503.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
				this.trkSysMessageAliasMessageAliasText_A8503.DataTransferOrder = 39;
				num = (short)134610951;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_25D:
				num = (short)1870200832;
				short num4 = num;
				num = (short)1523056645;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_1D1:
			IL_354:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("軂ꃄ듆뫈꫊꫌꫎鋒맔뻖룘꣚", a_);
			base.Id = 10164;
			base.UIName = global::CommonResources.AcgResources.ID_MESSAGEALIAS;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06001197 RID: 4503 RVA: 0x0010E9BC File Offset: 0x0010CBBC
		public override void PopulateReferences()
		{
			short num = (short)592034761;
			short num2 = num;
			num = (short)1034664905;
			switch (num2 == num)
			{
			}
			num = (short)514785281;
			if (num != 0)
			{
			}
			num = (short)1105330176;
			short num3 = num;
			num = (short)1881931776;
			if (num != 0)
			{
			}
		}

		// Token: 0x06001198 RID: 4504 RVA: 0x0010EA64 File Offset: 0x0010CC64
		public override void DropReferences()
		{
			short num = (short)911664133;
			short num2 = num;
			num = (short)796845061;
			switch (num2 == num)
			{
			}
			num = (short)169410561;
			if (num != 0)
			{
			}
			num = (short)1568210944;
			short num3 = num;
			num = (short)130220032;
			if (num != 0)
			{
			}
		}

		// Token: 0x06001199 RID: 4505 RVA: 0x0010EB0C File Offset: 0x0010CD0C
		public override void SetConstraints()
		{
			short num = (short)413776738;
			short num2 = num;
			num = (short)85441378;
			switch (num2 == num)
			{
			}
			num = (short)1318584321;
			if (num != 0)
			{
			}
			num = (short)1773404160;
			short num3 = num;
			num = (short)1731133440;
			if (num != 0)
			{
			}
			this.trkSysMessageAliasMessageAliasText_A8503.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConBoolTrkSysTrkMsgAlsIndicatorIsEnableAndTrkSysTypeNotAstro25);
			this.trkSysMsgAlias_A24069.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.trkSysMessageAliasMessageAliasNumber_A8500.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConBoolTrkSysTrkMsgAlsIndicatorIsEnableAndTrkSysTypeNotAstro25);
		}

		// Token: 0x0600119A RID: 4506 RVA: 0x0010EBFC File Offset: 0x0010CDFC
		public override void SetupDependencies()
		{
			short num = (short)1252768375;
			short num2 = num;
			num = (short)60799607;
			switch (num2 == num)
			{
			}
			num = (short)374013953;
			if (num != 0)
			{
			}
			num = (short)57802752;
			short num3 = num;
			num = (short)1041432576;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem = base.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem;
			trunkingSystem.MessageAlias.TrkSysMessageAliasMessageAliasEnable_A8505.AddDependentObject(this.trkSysMessageAliasMessageAliasText_A8503);
			trunkingSystem.General.TrkSysGeneralSystemType_A9252.AddDependentObject(this.trkSysMessageAliasMessageAliasText_A8503);
			trunkingSystem.MessageAlias.TrkSysMessageAliasMessageAliasEnable_A8505.AddDependentObject(this.trkSysMessageAliasMessageAliasNumber_A8500);
			trunkingSystem.General.TrkSysGeneralSystemType_A9252.AddDependentObject(this.trkSysMessageAliasMessageAliasNumber_A8500);
		}

		// Token: 0x170008C6 RID: 2246
		// (get) Token: 0x0600119B RID: 4507 RVA: 0x0010ED14 File Offset: 0x0010CF14
		public bool HasDiffs
		{
			get
			{
				short num = (short)1470054229;
				short num2 = num;
				num = (short)1525366613;
				switch (num2 == num)
				{
				}
				num = (short)1716846593;
				if (num != 0)
				{
				}
				num = (short)1295384576;
				short num3 = num;
				num = (short)124911616;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x170008C7 RID: 2247
		// (get) Token: 0x0600119C RID: 4508 RVA: 0x0010EDC4 File Offset: 0x0010CFC4
		// (set) Token: 0x0600119D RID: 4509 RVA: 0x0010EE78 File Offset: 0x0010D078
		public string TrkSysMessageAliasMessageAliasText_A8503Value
		{
			get
			{
				short num = (short)1405685198;
				short num2 = num;
				num = (short)563023310;
				switch (num2 == num)
				{
				}
				num = (short)478674945;
				if (num != 0)
				{
				}
				num = (short)168689664;
				short num3 = num;
				num = (short)11272192;
				if (num != 0)
				{
				}
				return this.trkSysMessageAliasMessageAliasText_A8503.Value;
			}
			set
			{
				short num = (short)2106480996;
				short num2 = num;
				num = (short)705386852;
				switch (num2 == num)
				{
				}
				num = (short)537591809;
				if (num != 0)
				{
				}
				num = (short)936247296;
				short num3 = num;
				num = (short)847446016;
				if (num != 0)
				{
				}
				this.trkSysMessageAliasMessageAliasText_A8503.Value = value;
			}
		}

		// Token: 0x170008C8 RID: 2248
		// (get) Token: 0x0600119E RID: 4510 RVA: 0x0010EF2C File Offset: 0x0010D12C
		public global::AcpBusinessLayer.AcpField<string> TrkSysMessageAliasMessageAliasText_A8503
		{
			get
			{
				short num = (short)1367304442;
				short num2 = num;
				num = (short)1840670970;
				switch (num2 == num)
				{
				}
				num = (short)590151681;
				if (num != 0)
				{
				}
				num = (short)960626688;
				short num3 = num;
				num = (short)731054080;
				if (num != 0)
				{
				}
				return this.trkSysMessageAliasMessageAliasText_A8503;
			}
		}

		// Token: 0x170008C9 RID: 2249
		// (get) Token: 0x0600119F RID: 4511 RVA: 0x0010EFDC File Offset: 0x0010D1DC
		// (set) Token: 0x060011A0 RID: 4512 RVA: 0x0010F094 File Offset: 0x0010D294
		public string TrkSysMessageAliasMessageAliasText_A8503_UIValue
		{
			get
			{
				short num = (short)479738644;
				short num2 = num;
				num = (short)1000422164;
				switch (num2 == num)
				{
				}
				num = (short)1530855425;
				if (num != 0)
				{
				}
				num = (short)1844117504;
				short num3 = num;
				num = (short)234881024;
				if (num != 0)
				{
				}
				return this.trkSysMessageAliasMessageAliasText_A8503.Value;
			}
			set
			{
				short num = (short)772472833;
				if (num != 0)
				{
				}
				num = (short)1063697650;
				short num2 = num;
				num = (short)1362935026;
				switch (num2 == num)
				{
				}
				num = (short)1852047360;
				short num3 = num;
				num = (short)665845760;
				if (num != 0)
				{
				}
				this.trkSysMessageAliasMessageAliasText_A8503.Value = value;
			}
		}

		// Token: 0x170008CA RID: 2250
		// (get) Token: 0x060011A1 RID: 4513 RVA: 0x0010F14C File Offset: 0x0010D34C
		// (set) Token: 0x060011A2 RID: 4514 RVA: 0x0010F200 File Offset: 0x0010D400
		public bool TrkSysMessageAliasMessageAliasText_A8503_Applicable
		{
			get
			{
				short num = (short)1644934392;
				short num2 = num;
				num = (short)793621752;
				switch (num2 == num)
				{
				}
				num = (short)1083703297;
				if (num != 0)
				{
				}
				num = (short)455606272;
				short num3 = num;
				num = (short)508887040;
				if (num != 0)
				{
				}
				return this.trkSysMessageAliasMessageAliasText_A8503.Applicable;
			}
			set
			{
				short num = (short)1320812545;
				if (num != 0)
				{
				}
				num = (short)1876302158;
				short num2 = num;
				num = (short)703863118;
				switch (num2 == num)
				{
				}
				num = (short)56492032;
				short num3 = num;
				num = (short)703201280;
				if (num != 0)
				{
				}
				this.trkSysMessageAliasMessageAliasText_A8503.Applicable = value;
			}
		}

		// Token: 0x170008CB RID: 2251
		// (get) Token: 0x060011A3 RID: 4515 RVA: 0x0010F2B4 File Offset: 0x0010D4B4
		// (set) Token: 0x060011A4 RID: 4516 RVA: 0x0010F368 File Offset: 0x0010D568
		public bool TrkSysMessageAliasMessageAliasText_A8503_Valid
		{
			get
			{
				short num = (short)1808877051;
				short num2 = num;
				num = (short)1338459643;
				switch (num2 == num)
				{
				}
				num = (short)1762983936;
				if (num != 0)
				{
				}
				num = (short)142147584;
				short num3 = num;
				num = (short)1320681473;
				if (num != 0)
				{
				}
				return this.trkSysMessageAliasMessageAliasText_A8503.Valid;
			}
			set
			{
				short num = (short)1126350271;
				short num2 = num;
				num = (short)1377222079;
				switch (num2 == num)
				{
				}
				num = (short)152174592;
				if (num != 0)
				{
				}
				num = (short)844693504;
				short num3 = num;
				num = (short)220069889;
				if (num != 0)
				{
				}
				this.trkSysMessageAliasMessageAliasText_A8503.Valid = value;
			}
		}

		// Token: 0x170008CC RID: 2252
		// (get) Token: 0x060011A5 RID: 4517 RVA: 0x0010F41C File Offset: 0x0010D61C
		// (set) Token: 0x060011A6 RID: 4518 RVA: 0x0010F4D4 File Offset: 0x0010D6D4
		public bool TrkSysMessageAliasMessageAliasText_A8503_Visible
		{
			get
			{
				short num = (short)1320772960;
				short num2 = num;
				num = (short)1623156064;
				switch (num2 == num)
				{
				}
				num = (short)105119745;
				if (num != 0)
				{
				}
				num = (short)420478976;
				short num3 = num;
				num = (short)868483072;
				if (num != 0)
				{
				}
				return this.trkSysMessageAliasMessageAliasText_A8503.Visible;
			}
			set
			{
				short num = (short)521653064;
				short num2 = num;
				num = (short)1489685320;
				switch (num2 == num)
				{
				default:
				{
					num = (short)593362944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)92209153;
				if (num != 0)
				{
				}
				num = (short)911015936;
				if (num != 0)
				{
				}
				this.trkSysMessageAliasMessageAliasText_A8503.Visible = value;
			}
		}

		// Token: 0x170008CD RID: 2253
		// (get) Token: 0x060011A7 RID: 4519 RVA: 0x0010F588 File Offset: 0x0010D788
		// (set) Token: 0x060011A8 RID: 4520 RVA: 0x0010F640 File Offset: 0x0010D840
		public bool TrkSysMessageAliasMessageAliasText_A8503_Editable
		{
			get
			{
				short num = (short)309503254;
				short num2 = num;
				num = (short)179217686;
				switch (num2 == num)
				{
				default:
				{
					num = (short)956497920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2117664769;
				if (num != 0)
				{
				}
				num = (short)1231355904;
				if (num != 0)
				{
				}
				return this.trkSysMessageAliasMessageAliasText_A8503.Editable;
			}
			set
			{
				short num = (short)943835083;
				short num2 = num;
				num = (short)1326893003;
				switch (num2 == num)
				{
				default:
				{
					num = (short)39911424;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1000472577;
				if (num != 0)
				{
				}
				num = (short)1381236736;
				if (num != 0)
				{
				}
				this.trkSysMessageAliasMessageAliasText_A8503.Editable = value;
			}
		}

		// Token: 0x170008CE RID: 2254
		// (get) Token: 0x060011A9 RID: 4521 RVA: 0x0010F6F8 File Offset: 0x0010D8F8
		internal string TrkSysMessageAliasMessageAliasText_A8503_UILabel
		{
			get
			{
				short num = (short)1158248451;
				short num2 = num;
				num = (short)1613854723;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1369374720;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1795686401;
				if (num != 0)
				{
				}
				num = (short)836173824;
				if (num != 0)
				{
				}
				return this.trkSysMessageAliasMessageAliasText_A8503.UIName;
			}
		}

		// Token: 0x170008CF RID: 2255
		// (get) Token: 0x060011AA RID: 4522 RVA: 0x0010F7B0 File Offset: 0x0010D9B0
		// (set) Token: 0x060011AB RID: 4523 RVA: 0x0010F868 File Offset: 0x0010DA68
		internal bool TrkSysMessageAliasMessageAliasText_A8503_HiddenStatic
		{
			get
			{
				short num = (short)1308734690;
				short num2 = num;
				num = (short)686994658;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1148190720;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1444741121;
				if (num != 0)
				{
				}
				num = (short)931135488;
				if (num != 0)
				{
				}
				return this.trkSysMessageAliasMessageAliasText_A8503.HiddenStatic;
			}
			set
			{
				short num = (short)1715752653;
				short num2 = num;
				num = (short)1918324429;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1472724992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)958529537;
				if (num != 0)
				{
				}
				num = (short)1791623168;
				if (num != 0)
				{
				}
				this.trkSysMessageAliasMessageAliasText_A8503.HiddenStatic = value;
			}
		}

		// Token: 0x170008D0 RID: 2256
		// (get) Token: 0x060011AC RID: 4524 RVA: 0x0010F920 File Offset: 0x0010DB20
		// (set) Token: 0x060011AD RID: 4525 RVA: 0x0010F9D4 File Offset: 0x0010DBD4
		internal bool TrkSysMessageAliasMessageAliasText_A8503_HiddenDynamic
		{
			get
			{
				short num = (short)1737098446;
				short num2 = num;
				num = (short)930219214;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1732378624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1174667265;
				if (num != 0)
				{
				}
				num = (short)124059648;
				if (num != 0)
				{
				}
				return this.trkSysMessageAliasMessageAliasText_A8503.HiddenDynamic;
			}
			set
			{
				short num = (short)1268137384;
				short num2 = num;
				num = (short)222444968;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1416364032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2072903681;
				if (num != 0)
				{
				}
				num = (short)388235264;
				if (num != 0)
				{
				}
				this.trkSysMessageAliasMessageAliasText_A8503.HiddenDynamic = value;
			}
		}

		// Token: 0x170008D1 RID: 2257
		// (get) Token: 0x060011AE RID: 4526 RVA: 0x0010FA8C File Offset: 0x0010DC8C
		public bool TrkSysMessageAliasMessageAliasText_A8503_HasDiffs
		{
			get
			{
				short num = (short)1076110424;
				short num2 = num;
				num = (short)1526015064;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1297219584;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)902103041;
				if (num != 0)
				{
				}
				num = (short)1228865536;
				if (num != 0)
				{
				}
				return this.trkSysMessageAliasMessageAliasText_A8503._HasDiffs;
			}
		}

		// Token: 0x170008D2 RID: 2258
		// (get) Token: 0x060011AF RID: 4527 RVA: 0x0010FB44 File Offset: 0x0010DD44
		// (set) Token: 0x060011B0 RID: 4528 RVA: 0x0010FBF8 File Offset: 0x0010DDF8
		public string TrkSysMsgAlias_A24069Value
		{
			get
			{
				short num = (short)1165535208;
				short num2 = num;
				num = (short)1906943976;
				switch (num2 == num)
				{
				default:
				{
					num = (short)794820608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)289865729;
				if (num != 0)
				{
				}
				num = (short)1389494272;
				if (num != 0)
				{
				}
				return this.trkSysMsgAlias_A24069.Value;
			}
			set
			{
				short num = (short)991297536;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_30;
						}
						continue;
					case 1:
						for (;;)
						{
							num = (short)1642004480;
							short num3 = num;
							num = (short)1941438465;
							if (num != 0)
							{
							}
							this.trkSysMsgAlias_A24069.Value = value;
							num = (short)375012937;
							short num4 = num;
							num = (short)973487689;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								goto IL_E9;
							}
						}
						IL_E9:
						num = (short)452132864;
						if (num != 0)
						{
						}
						num = (short)1643577346;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						return;
					}
					IL_30:
					if (string.IsNullOrEmpty(value.Trim()))
					{
						break;
					}
					num = (short)1489436673;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x170008D3 RID: 2259
		// (get) Token: 0x060011B1 RID: 4529 RVA: 0x0010FD20 File Offset: 0x0010DF20
		// (set) Token: 0x060011B2 RID: 4530 RVA: 0x0010FDD4 File Offset: 0x0010DFD4
		public string TrkSysMsgAlias_A24069_UIValue
		{
			get
			{
				short num = (short)1863256970;
				short num2 = num;
				num = (short)539298698;
				switch (num2 == num)
				{
				default:
				{
					num = (short)71696384;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)998703104;
				if (num != 0)
				{
				}
				num = (short)1968701441;
				if (num != 0)
				{
				}
				return this.trkSysMsgAlias_A24069.Value;
			}
			set
			{
				short num = (short)1043267585;
				if (num != 0)
				{
				}
				num = (short)2129920000;
				short num2 = num;
				num = (short)814484879;
				short num3 = num;
				num = (short)77073807;
				switch (num3 == num)
				{
				}
				num = (short)1404698624;
				if (num != 0)
				{
				}
				this.trkSysMsgAlias_A24069.Value = value;
			}
		}

		// Token: 0x170008D4 RID: 2260
		// (get) Token: 0x060011B3 RID: 4531 RVA: 0x0010FE8C File Offset: 0x0010E08C
		public global::AcpBusinessLayer.AcpKeyField TrkSysMsgAlias_A24069
		{
			get
			{
				short num = (short)1071169863;
				short num2 = num;
				num = (short)112050503;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1488977920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1794899969;
				if (num != 0)
				{
				}
				num = (short)392691712;
				if (num != 0)
				{
				}
				return this.trkSysMsgAlias_A24069;
			}
		}

		// Token: 0x170008D5 RID: 2261
		// (get) Token: 0x060011B4 RID: 4532 RVA: 0x0010FF40 File Offset: 0x0010E140
		// (set) Token: 0x060011B5 RID: 4533 RVA: 0x0010FFF8 File Offset: 0x0010E1F8
		public bool TrkSysMsgAlias_A24069_Applicable
		{
			get
			{
				short num = (short)512257818;
				short num2 = num;
				num = (short)526085914;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2121400320;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1445658625;
				if (num != 0)
				{
				}
				num = (short)1988427776;
				if (num != 0)
				{
				}
				return this.trkSysMsgAlias_A24069.Applicable;
			}
			set
			{
				short num = (short)1771837825;
				short num2 = num;
				num = (short)2122520961;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1093926912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1988165632;
				if (num != 0)
				{
				}
				num = (short)1862729729;
				if (num != 0)
				{
				}
				this.trkSysMsgAlias_A24069.Applicable = value;
			}
		}

		// Token: 0x170008D6 RID: 2262
		// (get) Token: 0x060011B6 RID: 4534 RVA: 0x001100AC File Offset: 0x0010E2AC
		// (set) Token: 0x060011B7 RID: 4535 RVA: 0x00110160 File Offset: 0x0010E360
		public bool TrkSysMsgAlias_A24069_Valid
		{
			get
			{
				short num = (short)1201274795;
				short num2 = num;
				num = (short)955580331;
				switch (num2 == num)
				{
				default:
				{
					num = (short)238813184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)819200001;
				if (num != 0)
				{
				}
				num = (short)149356544;
				if (num != 0)
				{
				}
				return this.trkSysMsgAlias_A24069.Valid;
			}
			set
			{
				short num = (short)487948843;
				short num2 = num;
				num = (short)829981227;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1494876160;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)94830593;
				if (num != 0)
				{
				}
				num = (short)1538457600;
				if (num != 0)
				{
				}
				this.trkSysMsgAlias_A24069.Valid = value;
			}
		}

		// Token: 0x170008D7 RID: 2263
		// (get) Token: 0x060011B8 RID: 4536 RVA: 0x00110218 File Offset: 0x0010E418
		// (set) Token: 0x060011B9 RID: 4537 RVA: 0x001102D0 File Offset: 0x0010E4D0
		public bool TrkSysMsgAlias_A24069_Visible
		{
			get
			{
				short num = (short)1017079423;
				short num2 = num;
				num = (short)141846143;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1531904000;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1885995008;
				if (num != 0)
				{
				}
				num = (short)1171062785;
				if (num != 0)
				{
				}
				return this.trkSysMsgAlias_A24069.Visible;
			}
			set
			{
				short num = (short)1414637794;
				short num2 = num;
				num = (short)626305250;
				switch (num2 == num)
				{
				default:
				{
					num = (short)287703040;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1043857408;
				if (num != 0)
				{
				}
				num = (short)1132593153;
				if (num != 0)
				{
				}
				this.trkSysMsgAlias_A24069.Visible = value;
			}
		}

		// Token: 0x170008D8 RID: 2264
		// (get) Token: 0x060011BA RID: 4538 RVA: 0x00110384 File Offset: 0x0010E584
		// (set) Token: 0x060011BB RID: 4539 RVA: 0x00110438 File Offset: 0x0010E638
		public bool TrkSysMsgAlias_A24069_Editable
		{
			get
			{
				short num = (short)1449263105;
				if (num != 0)
				{
				}
				num = (short)2067136512;
				short num2 = num;
				num = (short)414138348;
				short num3 = num;
				num = (short)150159340;
				switch (num3 == num)
				{
				}
				num = (short)122290176;
				if (num != 0)
				{
				}
				return this.trkSysMsgAlias_A24069.Editable;
			}
			set
			{
				short num = (short)1461499415;
				short num2 = num;
				num = (short)532526615;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1401552896;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)981729281;
				if (num != 0)
				{
				}
				num = (short)217120768;
				if (num != 0)
				{
				}
				this.trkSysMsgAlias_A24069.Editable = value;
			}
		}

		// Token: 0x170008D9 RID: 2265
		// (get) Token: 0x060011BC RID: 4540 RVA: 0x001104F0 File Offset: 0x0010E6F0
		internal string TrkSysMsgAlias_A24069_UILabel
		{
			get
			{
				short num = (short)1750037104;
				short num2 = num;
				num = (short)532247152;
				switch (num2 == num)
				{
				default:
				{
					num = (short)895877120;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)753532928;
				if (num != 0)
				{
				}
				num = (short)1014890497;
				if (num != 0)
				{
				}
				return this.trkSysMsgAlias_A24069.UIName;
			}
		}

		// Token: 0x170008DA RID: 2266
		// (get) Token: 0x060011BD RID: 4541 RVA: 0x001105A4 File Offset: 0x0010E7A4
		// (set) Token: 0x060011BE RID: 4542 RVA: 0x0011065C File Offset: 0x0010E85C
		internal bool TrkSysMsgAlias_A24069_HiddenStatic
		{
			get
			{
				short num = (short)671219713;
				if (num != 0)
				{
				}
				num = (short)151060480;
				short num2 = num;
				num = (short)1687773969;
				short num3 = num;
				num = (short)1011573521;
				switch (num3 == num)
				{
				}
				num = (short)2111242240;
				if (num != 0)
				{
				}
				return this.trkSysMsgAlias_A24069.HiddenStatic;
			}
			set
			{
				short num = (short)100910896;
				short num2 = num;
				num = (short)756139824;
				switch (num2 == num)
				{
				default:
				{
					num = (short)182583296;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)424869889;
				if (num != 0)
				{
				}
				num = (short)2131820544;
				if (num != 0)
				{
				}
				this.trkSysMsgAlias_A24069.HiddenStatic = value;
			}
		}

		// Token: 0x170008DB RID: 2267
		// (get) Token: 0x060011BF RID: 4543 RVA: 0x00110714 File Offset: 0x0010E914
		// (set) Token: 0x060011C0 RID: 4544 RVA: 0x001107C8 File Offset: 0x0010E9C8
		internal bool TrkSysMsgAlias_A24069_HiddenDynamic
		{
			get
			{
				short num = (short)1759222782;
				short num2 = num;
				num = (short)669293566;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1679491072;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)146800641;
				if (num != 0)
				{
				}
				num = (short)1984036864;
				if (num != 0)
				{
				}
				return this.trkSysMsgAlias_A24069.HiddenDynamic;
			}
			set
			{
				short num = (short)554425850;
				short num2 = num;
				num = (short)1303174650;
				switch (num2 == num)
				{
				default:
				{
					num = (short)927727616;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)797769729;
				if (num != 0)
				{
				}
				num = (short)508559360;
				if (num != 0)
				{
				}
				this.trkSysMsgAlias_A24069.HiddenDynamic = value;
			}
		}

		// Token: 0x170008DC RID: 2268
		// (get) Token: 0x060011C1 RID: 4545 RVA: 0x00110880 File Offset: 0x0010EA80
		public bool TrkSysMsgAlias_A24069_HasDiffs
		{
			get
			{
				short num = (short)2071414376;
				short num2 = num;
				num = (short)1348224616;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1495334912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1967587329;
				if (num != 0)
				{
				}
				num = (short)501219328;
				if (num != 0)
				{
				}
				return this.trkSysMsgAlias_A24069._HasDiffs;
			}
		}

		// Token: 0x170008DD RID: 2269
		// (get) Token: 0x060011C2 RID: 4546 RVA: 0x00110938 File Offset: 0x0010EB38
		// (set) Token: 0x060011C3 RID: 4547 RVA: 0x001109EC File Offset: 0x0010EBEC
		public int TrkSysMessageAliasMessageAliasNumber_A8500Value
		{
			get
			{
				short num = (short)1587162933;
				short num2 = num;
				num = (short)1582509877;
				switch (num2 == num)
				{
				default:
				{
					num = (short)584712192;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)563675137;
				if (num != 0)
				{
				}
				num = (short)90636288;
				if (num != 0)
				{
				}
				return this.trkSysMessageAliasMessageAliasNumber_A8500.Value;
			}
			set
			{
				short num = (short)717148087;
				short num2 = num;
				num = (short)51105719;
				switch (num2 == num)
				{
				default:
				{
					num = (short)694288384;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1215627265;
				if (num != 0)
				{
				}
				num = (short)1535115264;
				if (num != 0)
				{
				}
				this.trkSysMessageAliasMessageAliasNumber_A8500.Value = value;
			}
		}

		// Token: 0x170008DE RID: 2270
		// (get) Token: 0x060011C4 RID: 4548 RVA: 0x00110AA4 File Offset: 0x0010ECA4
		public global::AcpBusinessLayer.AcpSimpleRangeField TrkSysMessageAliasMessageAliasNumber_A8500
		{
			get
			{
				short num = (short)1256920153;
				short num2 = num;
				num = (short)268178521;
				switch (num2 == num)
				{
				default:
				{
					num = (short)942538752;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1926823937;
				if (num != 0)
				{
				}
				num = (short)1181483008;
				if (num != 0)
				{
				}
				return this.trkSysMessageAliasMessageAliasNumber_A8500;
			}
		}

		// Token: 0x170008DF RID: 2271
		// (get) Token: 0x060011C5 RID: 4549 RVA: 0x00110B54 File Offset: 0x0010ED54
		// (set) Token: 0x060011C6 RID: 4550 RVA: 0x00110C0C File Offset: 0x0010EE0C
		public string TrkSysMessageAliasMessageAliasNumber_A8500_UIValue
		{
			get
			{
				short num = (short)919813897;
				short num2 = num;
				num = (short)606748425;
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
				num = (short)1087045633;
				if (num != 0)
				{
				}
				num = (short)125042688;
				if (num != 0)
				{
				}
				return this.trkSysMessageAliasMessageAliasNumber_A8500.UIValue;
			}
			set
			{
				short num = (short)1236454231;
				short num2 = num;
				num = (short)1811991383;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1985871872;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1090912257;
				if (num != 0)
				{
				}
				num = (short)895156224;
				if (num != 0)
				{
				}
				this.trkSysMessageAliasMessageAliasNumber_A8500.UIValue = value;
			}
		}

		// Token: 0x170008E0 RID: 2272
		// (get) Token: 0x060011C7 RID: 4551 RVA: 0x00110CC0 File Offset: 0x0010EEC0
		// (set) Token: 0x060011C8 RID: 4552 RVA: 0x00110D74 File Offset: 0x0010EF74
		internal int TrkSysMessageAliasMessageAliasNumber_A8500Min
		{
			get
			{
				short num = (short)528285697;
				if (num != 0)
				{
				}
				num = (short)1714814976;
				short num2 = num;
				num = (short)1732748208;
				short num3 = num;
				num = (short)275162032;
				switch (num3 == num)
				{
				}
				num = (short)1580335104;
				if (num != 0)
				{
				}
				return this.trkSysMessageAliasMessageAliasNumber_A8500.Min;
			}
			set
			{
				short num = (short)141169377;
				short num2 = num;
				num = (short)953488097;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1093992448;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1557463040;
				if (num != 0)
				{
				}
				num = (short)1851129857;
				if (num != 0)
				{
				}
				this.trkSysMessageAliasMessageAliasNumber_A8500.Min = value;
			}
		}

		// Token: 0x170008E1 RID: 2273
		// (get) Token: 0x060011C9 RID: 4553 RVA: 0x00110E28 File Offset: 0x0010F028
		// (set) Token: 0x060011CA RID: 4554 RVA: 0x00110EDC File Offset: 0x0010F0DC
		internal int TrkSysMessageAliasMessageAliasNumber_A8500Max
		{
			get
			{
				short num = (short)335994775;
				short num2 = num;
				num = (short)778952599;
				switch (num2 == num)
				{
				default:
				{
					num = (short)852492288;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)856621057;
				if (num != 0)
				{
				}
				num = (short)792330240;
				if (num != 0)
				{
				}
				return this.trkSysMessageAliasMessageAliasNumber_A8500.Max;
			}
			set
			{
				short num = (short)2076035804;
				short num2 = num;
				num = (short)1616562908;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2074869760;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)479330304;
				if (num != 0)
				{
				}
				num = (short)985530369;
				if (num != 0)
				{
				}
				this.trkSysMessageAliasMessageAliasNumber_A8500.Max = value;
			}
		}

		// Token: 0x170008E2 RID: 2274
		// (get) Token: 0x060011CB RID: 4555 RVA: 0x00110F90 File Offset: 0x0010F190
		// (set) Token: 0x060011CC RID: 4556 RVA: 0x00111044 File Offset: 0x0010F244
		internal int TrkSysMessageAliasMessageAliasNumber_A8500Step
		{
			get
			{
				short num = (short)336305266;
				short num2 = num;
				num = (short)1204919410;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1148059648;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2065629185;
				if (num != 0)
				{
				}
				num = (short)1506869248;
				if (num != 0)
				{
				}
				return this.trkSysMessageAliasMessageAliasNumber_A8500.StepSize;
			}
			set
			{
				short num = (short)867597825;
				short num2 = num;
				num = (short)2093645313;
				switch (num2 == num)
				{
				default:
				{
					num = (short)678559744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2002714624;
				if (num != 0)
				{
				}
				num = (short)1856503809;
				if (num != 0)
				{
				}
				this.trkSysMessageAliasMessageAliasNumber_A8500.StepSize = value;
			}
		}

		// Token: 0x170008E3 RID: 2275
		// (get) Token: 0x060011CD RID: 4557 RVA: 0x001110FC File Offset: 0x0010F2FC
		// (set) Token: 0x060011CE RID: 4558 RVA: 0x001111B4 File Offset: 0x0010F3B4
		public bool TrkSysMessageAliasMessageAliasNumber_A8500_Applicable
		{
			get
			{
				short num = (short)417660929;
				if (num != 0)
				{
				}
				num = (short)452001792;
				short num2 = num;
				num = (short)1463694488;
				short num3 = num;
				num = (short)457061528;
				switch (num3 == num)
				{
				}
				num = (short)1719009280;
				if (num != 0)
				{
				}
				return this.trkSysMessageAliasMessageAliasNumber_A8500.Applicable;
			}
			set
			{
				short num = (short)1614984955;
				short num2 = num;
				num = (short)1949218555;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1701904384;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)541720577;
				if (num != 0)
				{
				}
				num = (short)1561919488;
				if (num != 0)
				{
				}
				this.trkSysMessageAliasMessageAliasNumber_A8500.Applicable = value;
			}
		}

		// Token: 0x170008E4 RID: 2276
		// (get) Token: 0x060011CF RID: 4559 RVA: 0x0011126C File Offset: 0x0010F46C
		// (set) Token: 0x060011D0 RID: 4560 RVA: 0x00111320 File Offset: 0x0010F520
		public bool TrkSysMessageAliasMessageAliasNumber_A8500_Valid
		{
			get
			{
				short num = (short)1257701377;
				if (num != 0)
				{
				}
				num = (short)26214400;
				short num2 = num;
				num = (short)1183032924;
				short num3 = num;
				num = (short)1603839580;
				switch (num3 == num)
				{
				}
				num = (short)875888640;
				if (num != 0)
				{
				}
				return this.trkSysMessageAliasMessageAliasNumber_A8500.Valid;
			}
			set
			{
				short num = (short)124163850;
				short num2 = num;
				num = (short)369661706;
				switch (num2 == num)
				{
				default:
				{
					num = (short)612958208;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)164429824;
				if (num != 0)
				{
				}
				num = (short)1172963329;
				if (num != 0)
				{
				}
				this.trkSysMessageAliasMessageAliasNumber_A8500.Valid = value;
			}
		}

		// Token: 0x170008E5 RID: 2277
		// (get) Token: 0x060011D1 RID: 4561 RVA: 0x001113D8 File Offset: 0x0010F5D8
		// (set) Token: 0x060011D2 RID: 4562 RVA: 0x0011148C File Offset: 0x0010F68C
		public bool TrkSysMessageAliasMessageAliasNumber_A8500_Visible
		{
			get
			{
				short num = (short)1267077775;
				short num2 = num;
				num = (short)388174479;
				switch (num2 == num)
				{
				default:
				{
					num = (short)545325056;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)471662592;
				if (num != 0)
				{
				}
				num = (short)91881473;
				if (num != 0)
				{
				}
				return this.trkSysMessageAliasMessageAliasNumber_A8500.Visible;
			}
			set
			{
				short num = (short)1707278603;
				short num2 = num;
				num = (short)887750923;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2033057792;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)939524096;
				if (num != 0)
				{
				}
				num = (short)885456897;
				if (num != 0)
				{
				}
				this.trkSysMessageAliasMessageAliasNumber_A8500.Visible = value;
			}
		}

		// Token: 0x170008E6 RID: 2278
		// (get) Token: 0x060011D3 RID: 4563 RVA: 0x00111540 File Offset: 0x0010F740
		// (set) Token: 0x060011D4 RID: 4564 RVA: 0x001115F4 File Offset: 0x0010F7F4
		public bool TrkSysMessageAliasMessageAliasNumber_A8500_Editable
		{
			get
			{
				short num = (short)1776878148;
				short num2 = num;
				num = (short)1266025028;
				switch (num2 == num)
				{
				default:
				{
					num = (short)467730432;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)546832385;
				if (num != 0)
				{
				}
				num = (short)1395130368;
				if (num != 0)
				{
				}
				return this.trkSysMessageAliasMessageAliasNumber_A8500.Editable;
			}
			set
			{
				short num = (short)893602773;
				short num2 = num;
				num = (short)129321941;
				switch (num2 == num)
				{
				default:
				{
					num = (short)30408704;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)173342721;
				if (num != 0)
				{
				}
				num = (short)1716060160;
				if (num != 0)
				{
				}
				this.trkSysMessageAliasMessageAliasNumber_A8500.Editable = value;
			}
		}

		// Token: 0x170008E7 RID: 2279
		// (get) Token: 0x060011D5 RID: 4565 RVA: 0x001116A8 File Offset: 0x0010F8A8
		internal string TrkSysMessageAliasMessageAliasNumber_A8500_UILabel
		{
			get
			{
				short num = (short)1056745395;
				short num2 = num;
				num = (short)323659699;
				switch (num2 == num)
				{
				default:
				{
					num = (short)911212544;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)774242305;
				if (num != 0)
				{
				}
				num = (short)1831862272;
				if (num != 0)
				{
				}
				return this.trkSysMessageAliasMessageAliasNumber_A8500.UIName;
			}
		}

		// Token: 0x170008E8 RID: 2280
		// (get) Token: 0x060011D6 RID: 4566 RVA: 0x0011175C File Offset: 0x0010F95C
		// (set) Token: 0x060011D7 RID: 4567 RVA: 0x00111814 File Offset: 0x0010FA14
		internal bool TrkSysMessageAliasMessageAliasNumber_A8500_HiddenStatic
		{
			get
			{
				short num = (short)891931642;
				short num2 = num;
				num = (short)315608058;
				switch (num2 == num)
				{
				default:
				{
					num = (short)942276608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1979908096;
				if (num != 0)
				{
				}
				num = (short)2029191169;
				if (num != 0)
				{
				}
				return this.trkSysMessageAliasMessageAliasNumber_A8500.HiddenStatic;
			}
			set
			{
				short num = (short)1438819185;
				short num2 = num;
				num = (short)153330545;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1364000768;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)522846209;
				if (num != 0)
				{
				}
				num = (short)1176764416;
				if (num != 0)
				{
				}
				this.trkSysMessageAliasMessageAliasNumber_A8500.HiddenStatic = value;
			}
		}

		// Token: 0x170008E9 RID: 2281
		// (get) Token: 0x060011D8 RID: 4568 RVA: 0x001118CC File Offset: 0x0010FACC
		// (set) Token: 0x060011D9 RID: 4569 RVA: 0x00111980 File Offset: 0x0010FB80
		internal bool TrkSysMessageAliasMessageAliasNumber_A8500_HiddenDynamic
		{
			get
			{
				short num = (short)2008921420;
				short num2 = num;
				num = (short)1077196108;
				switch (num2 == num)
				{
				default:
				{
					num = (short)139460608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)697565185;
				if (num != 0)
				{
				}
				num = (short)1679425536;
				if (num != 0)
				{
				}
				return this.trkSysMessageAliasMessageAliasNumber_A8500.HiddenDynamic;
			}
			set
			{
				short num = (short)488308736;
				short num2 = num;
				num = (short)1650956067;
				short num3 = num;
				num = (short)1281398563;
				switch (num3 == num)
				{
				}
				num = (short)1388249089;
				if (num != 0)
				{
				}
				num = (short)1285881856;
				if (num != 0)
				{
				}
				this.trkSysMessageAliasMessageAliasNumber_A8500.HiddenDynamic = value;
			}
		}

		// Token: 0x170008EA RID: 2282
		// (get) Token: 0x060011DA RID: 4570 RVA: 0x00111A34 File Offset: 0x0010FC34
		public bool TrkSysMessageAliasMessageAliasNumber_A8500_HasDiffs
		{
			get
			{
				short num = (short)628162560;
				short num2 = num;
				num = (short)1222434683;
				short num3 = num;
				num = (short)338354043;
				switch (num3 == num)
				{
				}
				num = (short)1544421376;
				if (num != 0)
				{
				}
				num = (short)1372323841;
				if (num != 0)
				{
				}
				return this.trkSysMessageAliasMessageAliasNumber_A8500._HasDiffs;
			}
		}

		// Token: 0x060011DB RID: 4571 RVA: 0x00111AEC File Offset: 0x0010FCEC
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
				{
					num2 = (short)1526792192;
					short num3 = num2;
					if (base.ParentRecset != null)
					{
						num2 = (short)1058734084;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_117;
				}
				case 1:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)1084227587;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_117;
				case 2:
					goto IL_117;
				case 3:
					IL_115:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)1828847618;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					num2 = (short)1220411393;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_24;
				IL_117:
				num2 = (short)2013074652;
				short num4 = num2;
				num2 = (short)767825116;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_115;
				default:
					goto IL_14C;
				}
			}
			IL_14C:
			num2 = (short)711524352;
			if (num2 != 0)
			{
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)1789198337;
			if (num2 != 0)
			{
			}
			num2 = (short)1975320576;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04000446 RID: 1094
		private global::AcpBusinessLayer.AcpField<string> trkSysMessageAliasMessageAliasText_A8503;

		// Token: 0x04000447 RID: 1095
		private global::AcpBusinessLayer.AcpKeyField trkSysMsgAlias_A24069;

		// Token: 0x04000448 RID: 1096
		private global::AcpBusinessLayer.AcpSimpleRangeField trkSysMessageAliasMessageAliasNumber_A8500;
	}
}
