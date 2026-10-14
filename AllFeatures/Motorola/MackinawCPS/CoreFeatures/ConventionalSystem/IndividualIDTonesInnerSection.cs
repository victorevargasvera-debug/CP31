using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using Features.Converters;

namespace Motorola.MackinawCPS.CoreFeatures.ConventionalSystem
{
	// Token: 0x02000574 RID: 1396
	[global::System.Serializable]
	public class IndividualIDTonesInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600BDA9 RID: 48553 RVA: 0x00AF59A4 File Offset: 0x00AF3BA4
		public IndividualIDTonesInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x0600BDAA RID: 48554 RVA: 0x00AF59C0 File Offset: 0x00AF3BC0
		protected IndividualIDTonesInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600BDAB RID: 48555 RVA: 0x00AF59D8 File Offset: 0x00AF3BD8
		public override void Init()
		{
			int a_ = 8;
			short num = (short)2000377393;
			short num2 = num;
			num = (short)2015188529;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2140733440;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1449525249;
			if (num != 0)
			{
			}
			num = (short)1125253120;
			if (num != 0)
			{
			}
			this.cnvSysGeneralQc2Name_A42231 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_TONEA, this, global::AllFeatures.CodeplugGuid.b("諈ꗊ믌鳎꣐ꃒ鋔닖럘뻚꿜뻞跠닢蛤헦꟨諪胬諮껰닲쇴엶쯸죺쳼", a_), global::CommonResources.AcgResources.ID_NAME, 100);
			this.cnvSysGeneralQc2Name_A42231.IgnoreOnCompare = true;
			this.cnvSysGeneralQc2Name_A42231.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.cnvSysGeneralQc2Name_A42231.DataTransferOrder = -1;
			this.cnvSysGeneralQc2Freq_A42232 = new global::AcpBusinessLayer.AcpCustomRangeField(3586, new global::Features.Converters.UnpackFactorDblAndPackFactorDblWith10ForCustomRange(), this, global::AllFeatures.CodeplugGuid.b("諈ꗊ믌鳎꣐ꃒ鋔닖럘뻚꿜뻞跠닢蛤헦꿨駪裬黮껰닲쇴엶쯸죺쿼", a_), global::CommonResources.AcgResources.ID_FREQHZ, 2885, 30860, 1, null, null);
			this.cnvSysGeneralQc2Freq_A42232.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.cnvSysGeneralQc2Freq_A42232.DataTransferOrder = 202;
			this.cnvSysGeneralQc2Freq_A42232.ShowHexValue = false;
			this.cnvSysGeneralQc2Code_A42234 = new global::AcpBusinessLayer.AcpListField(10, this, global::AllFeatures.CodeplugGuid.b("諈ꗊ믌鳎꣐ꃒ鋔닖럘뻚꿜뻞跠닢蛤헦ꫨ蓪觬諮껰닲쇴엶쯸죺짼", a_), global::CommonResources.AcgResources.ID_CODE, global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.LOVs.CnvSysGeneralQc2Code_A42234LovStrs);
			this.cnvSysGeneralQc2Code_A42234.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.cnvSysGeneralQc2Code_A42234.DataTransferOrder = 203;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("胈ꗊ꧌ꛎꟐ뫒뇔ꋖ룘럚﷜雞ꗠ쏢뇤裦蟨軪黬", a_);
			base.Id = 10783;
			base.UIName = global::CommonResources.AcgResources.ID_INDIVIDUALIDTONES;
			base.DataTransferOrder = 80;
		}

		// Token: 0x0600BDAC RID: 48556 RVA: 0x00AF5BA8 File Offset: 0x00AF3DA8
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 18;
			short num = (short)1339949066;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_210;
				case 1:
					if (producerFields != null)
					{
						num = (short)996147208;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_375;
				case 2:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("郒믔ꇖ諘ꋚ껜飞蓠跢胤闦裨蟪볬賮쏰뗲蟴鋶裸ꓺ볼쯾㌀㄂㘄㔆", a_)))
					{
						num = (short)2093023236;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2C0;
				case 3:
					this.cnvSysGeneralQc2Code_A42234 = new global::AcpBusinessLayer.AcpListField(10, this, global::AllFeatures.CodeplugGuid.b("郒믔ꇖ諘ꋚ껜飞蓠跢胤闦裨蟪볬賮쏰냲髴鏶鳸ꓺ볼쯾㌀㄂㘄㌆", a_), global::CommonResources.AcgResources.ID_CODE, global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.LOVs.CnvSysGeneralQc2Code_A42234LovStrs);
					this.cnvSysGeneralQc2Code_A42234.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.cnvSysGeneralQc2Code_A42234.DataTransferOrder = 203;
					num = (short)14680064;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					this.cnvSysGeneralQc2Freq_A42232 = new global::AcpBusinessLayer.AcpCustomRangeField(3586, new global::Features.Converters.UnpackFactorDblAndPackFactorDblWith10ForCustomRange(), this, global::AllFeatures.CodeplugGuid.b("郒믔ꇖ諘ꋚ껜飞蓠跢胤闦裨蟪볬賮쏰뗲蟴鋶裸ꓺ볼쯾㌀㄂㘄㔆", a_), global::CommonResources.AcgResources.ID_FREQHZ, null, null);
					this.cnvSysGeneralQc2Freq_A42232.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.cnvSysGeneralQc2Freq_A42232.DataTransferOrder = 202;
					this.cnvSysGeneralQc2Freq_A42232.ShowHexValue = false;
					num = (short)1495334921;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					num = (short)511836161;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					num = (short)1698234369;
					if (num != 0)
					{
					}
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("郒믔ꇖ諘ꋚ껜飞蓠跢胤闦裨蟪볬賮쏰뷲铴髶鳸ꓺ볼쯾㌀㄂㘄㘆", a_)))
					{
						num = (short)2068840459;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_F7;
				case 7:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("郒믔ꇖ諘ꋚ껜飞蓠跢胤闦裨蟪볬賮쏰냲髴鏶鳸ꓺ볼쯾㌀㄂㘄㌆", a_)))
					{
						num = (short)836632579;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_375;
				case 8:
				{
					num = (short)990527067;
					short num3 = num;
					num = (short)46087771;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_F7;
					default:
					{
						num = (short)1267400704;
						if (num != 0)
						{
						}
						num = (short)2078408704;
						short num4 = num;
						num = (short)1381433350;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 9:
					goto IL_2C0;
				case 10:
					switch (0)
					{
					case 0:
						goto IL_63;
					}
					continue;
				case 11:
					this.cnvSysGeneralQc2Name_A42231 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_TONEA, this, global::AllFeatures.CodeplugGuid.b("郒믔ꇖ諘ꋚ껜飞蓠跢胤闦裨蟪볬賮쏰뷲铴髶鳸ꓺ볼쯾㌀㄂㘄㘆", a_), global::CommonResources.AcgResources.ID_NAME, 100);
					this.cnvSysGeneralQc2Name_A42231.IgnoreOnCompare = true;
					this.cnvSysGeneralQc2Name_A42231.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.cnvSysGeneralQc2Name_A42231.DataTransferOrder = -1;
					num = (short)334364684;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					goto IL_F7;
				}
				IL_63:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1661206533;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_F7:
				num = (short)1824325634;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2C0:
				num = (short)24969223;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_210:
			IL_375:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("髒믔돖냘귚드믞铠苢觤쟦ꃨ꿪췬믮黰鷲郴蓶", a_);
			base.Id = 10783;
			base.UIName = global::CommonResources.AcgResources.ID_INDIVIDUALIDTONES;
			base.DataTransferOrder = 80;
		}

		// Token: 0x0600BDAD RID: 48557 RVA: 0x00AF5F5C File Offset: 0x00AF415C
		public override void PopulateReferences()
		{
			short num = (short)1634938805;
			short num2 = num;
			num = (short)931999669;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1302396928;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1137442817;
			if (num != 0)
			{
			}
			num = (short)875298816;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600BDAE RID: 48558 RVA: 0x00AF6008 File Offset: 0x00AF4208
		public override void DropReferences()
		{
			short num = (short)1860443547;
			short num2 = num;
			num = (short)788405659;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1688993792;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)434962433;
			if (num != 0)
			{
			}
			num = (short)983367680;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600BDAF RID: 48559 RVA: 0x00AF60B0 File Offset: 0x00AF42B0
		public override void SetConstraints()
		{
			short num = (short)1405344252;
			short num2 = num;
			num = (short)1511512572;
			switch (num2 == num)
			{
			default:
			{
				num = (short)247201792;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)352714753;
			if (num != 0)
			{
			}
			num = (short)79364096;
			if (num != 0)
			{
			}
			this.cnvSysGeneralQc2Name_A42231.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConIsVisibleSystemTypeIsQC2ORMDC);
			this.cnvSysGeneralQc2Name_A42231.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.cnvSysGeneralQc2Name_A42231.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConIsVisibleSystemTypeIsQC2ORMDC);
			this.cnvSysGeneralQc2Freq_A42232.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.conCallFormatIncludeCorD);
			this.cnvSysGeneralQc2Freq_A42232.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConIsVisibleSystemTypeIsQC2ORMDC);
			this.cnvSysGeneralQc2Freq_A42232.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.conSyncFreqtoCode);
			this.cnvSysGeneralQc2Code_A42234.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.conCallFormatIncludeCorD);
			this.cnvSysGeneralQc2Code_A42234.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.conCodeIsNotNoneFreqPair);
			this.cnvSysGeneralQc2Code_A42234.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConIsVisibleSystemTypeIsQC2ORMDC);
			this.cnvSysGeneralQc2Code_A42234.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.conSyncCodetoFreq);
		}

		// Token: 0x0600BDB0 RID: 48560 RVA: 0x00AF6240 File Offset: 0x00AF4440
		public override void SetupDependencies()
		{
			short num = (short)601980365;
			short num2 = num;
			num = (short)1795259853;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1986265088;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1646723073;
			if (num != 0)
			{
			}
			num = (short)1185677312;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem = base.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem;
			conventionalSystem.General.CnvSysGeneralSystemType_A13262.AddDependentObject(this.cnvSysGeneralQc2Name_A42231);
			conventionalSystem.General.CnvSysGeneralSystemType_A13262.AddDependentObject(this.cnvSysGeneralQc2Freq_A42232);
			conventionalSystem.QuikCallII.CnvSysGeneralQc2CallFormat_A42230.AddDependentObject(this.cnvSysGeneralQc2Freq_A42232);
			conventionalSystem.General.CnvSysGeneralSystemType_A13262.AddDependentObject(this.cnvSysGeneralQc2Code_A42234);
			conventionalSystem.QuikCallII.CnvSysGeneralQc2CallFormat_A42230.AddDependentObject(this.cnvSysGeneralQc2Code_A42234);
		}

		// Token: 0x17005F30 RID: 24368
		// (get) Token: 0x0600BDB1 RID: 48561 RVA: 0x00AF6370 File Offset: 0x00AF4570
		public bool HasDiffs
		{
			get
			{
				short num = (short)343012600;
				short num2 = num;
				num = (short)2074866936;
				switch (num2 == num)
				{
				default:
				{
					num = (short)353239040;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1852112897;
				if (num != 0)
				{
				}
				num = (short)473104384;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17005F31 RID: 24369
		// (get) Token: 0x0600BDB2 RID: 48562 RVA: 0x00AF6420 File Offset: 0x00AF4620
		// (set) Token: 0x0600BDB3 RID: 48563 RVA: 0x00AF64D4 File Offset: 0x00AF46D4
		public string CnvSysGeneralQc2Name_A42231Value
		{
			get
			{
				short num = (short)37900544;
				short num2 = num;
				num = (short)1570394368;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1487536128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1747976192;
				if (num != 0)
				{
				}
				num = (short)1301217281;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralQc2Name_A42231.Value;
			}
			set
			{
				short num = (short)614347409;
				short num2 = num;
				num = (short)332542609;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1300365312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1879113728;
				if (num != 0)
				{
				}
				num = (short)1450508289;
				if (num != 0)
				{
				}
				this.cnvSysGeneralQc2Name_A42231.Value = value;
			}
		}

		// Token: 0x17005F32 RID: 24370
		// (get) Token: 0x0600BDB4 RID: 48564 RVA: 0x00AF658C File Offset: 0x00AF478C
		public global::AcpBusinessLayer.AcpField<string> CnvSysGeneralQc2Name_A42231
		{
			get
			{
				short num = (short)2125463553;
				if (num != 0)
				{
				}
				num = (short)1720254464;
				short num2 = num;
				num = (short)1305399476;
				short num3 = num;
				num = (short)1273352372;
				switch (num3 == num)
				{
				}
				num = (short)300810240;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralQc2Name_A42231;
			}
		}

		// Token: 0x17005F33 RID: 24371
		// (get) Token: 0x0600BDB5 RID: 48565 RVA: 0x00AF6640 File Offset: 0x00AF4840
		// (set) Token: 0x0600BDB6 RID: 48566 RVA: 0x00AF66F8 File Offset: 0x00AF48F8
		public string CnvSysGeneralQc2Name_A42231_UIValue
		{
			get
			{
				short num = (short)1899000417;
				short num2 = num;
				num = (short)1215328865;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1779630080;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1727135744;
				if (num != 0)
				{
				}
				num = (short)93650945;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralQc2Name_A42231.Value;
			}
			set
			{
				short num = (short)878362014;
				short num2 = num;
				num = (short)1563147678;
				switch (num2 == num)
				{
				default:
				{
					num = (short)646905856;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1186725889;
				if (num != 0)
				{
				}
				num = (short)1473839104;
				if (num != 0)
				{
				}
				this.cnvSysGeneralQc2Name_A42231.Value = value;
			}
		}

		// Token: 0x17005F34 RID: 24372
		// (get) Token: 0x0600BDB7 RID: 48567 RVA: 0x00AF67B0 File Offset: 0x00AF49B0
		// (set) Token: 0x0600BDB8 RID: 48568 RVA: 0x00AF6860 File Offset: 0x00AF4A60
		public bool CnvSysGeneralQc2Name_A42231_Applicable
		{
			get
			{
				short num = (short)385369881;
				short num2 = num;
				num = (short)1821853465;
				switch (num2 == num)
				{
				default:
				{
					num = (short)897253376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)505282560;
				if (num != 0)
				{
				}
				num = (short)1712390145;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralQc2Name_A42231.Applicable;
			}
			set
			{
				short num = (short)191864793;
				short num2 = num;
				num = (short)269656025;
				switch (num2 == num)
				{
				default:
				{
					num = (short)855703552;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)277872640;
				if (num != 0)
				{
				}
				num = (short)2142175233;
				if (num != 0)
				{
				}
				this.cnvSysGeneralQc2Name_A42231.Applicable = value;
			}
		}

		// Token: 0x17005F35 RID: 24373
		// (get) Token: 0x0600BDB9 RID: 48569 RVA: 0x00AF6914 File Offset: 0x00AF4B14
		// (set) Token: 0x0600BDBA RID: 48570 RVA: 0x00AF69C8 File Offset: 0x00AF4BC8
		public bool CnvSysGeneralQc2Name_A42231_Valid
		{
			get
			{
				short num = (short)490737112;
				short num2 = num;
				num = (short)1518407128;
				switch (num2 == num)
				{
				default:
				{
					num = (short)721813504;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1254817793;
				if (num != 0)
				{
				}
				num = (short)221773824;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralQc2Name_A42231.Valid;
			}
			set
			{
				short num = (short)1054550916;
				short num2 = num;
				num = (short)1175333764;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1473839104;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)526778369;
				if (num != 0)
				{
				}
				num = (short)288358400;
				if (num != 0)
				{
				}
				this.cnvSysGeneralQc2Name_A42231.Valid = value;
			}
		}

		// Token: 0x17005F36 RID: 24374
		// (get) Token: 0x0600BDBB RID: 48571 RVA: 0x00AF6A7C File Offset: 0x00AF4C7C
		// (set) Token: 0x0600BDBC RID: 48572 RVA: 0x00AF6B34 File Offset: 0x00AF4D34
		public bool CnvSysGeneralQc2Name_A42231_Visible
		{
			get
			{
				short num = (short)225559555;
				short num2 = num;
				num = (short)224904195;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1030750208;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)916717569;
				if (num != 0)
				{
				}
				num = (short)17104896;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralQc2Name_A42231.Visible;
			}
			set
			{
				short num = (short)2096716013;
				short num2 = num;
				num = (short)848779501;
				switch (num2 == num)
				{
				default:
				{
					num = (short)291504128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1011548160;
				if (num != 0)
				{
				}
				num = (short)1521221633;
				if (num != 0)
				{
				}
				this.cnvSysGeneralQc2Name_A42231.Visible = value;
			}
		}

		// Token: 0x17005F37 RID: 24375
		// (get) Token: 0x0600BDBD RID: 48573 RVA: 0x00AF6BE8 File Offset: 0x00AF4DE8
		// (set) Token: 0x0600BDBE RID: 48574 RVA: 0x00AF6CA0 File Offset: 0x00AF4EA0
		public bool CnvSysGeneralQc2Name_A42231_Editable
		{
			get
			{
				short num = (short)346072005;
				short num2 = num;
				num = (short)1817551813;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1996947456;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1686831105;
				if (num != 0)
				{
				}
				num = (short)1967652864;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralQc2Name_A42231.Editable;
			}
			set
			{
				short num = (short)987824129;
				if (num != 0)
				{
				}
				num = (short)1478492160;
				short num2 = num;
				num = (short)1943294929;
				short num3 = num;
				num = (short)1246450641;
				switch (num3 == num)
				{
				}
				num = (short)214368256;
				if (num != 0)
				{
				}
				this.cnvSysGeneralQc2Name_A42231.Editable = value;
			}
		}

		// Token: 0x17005F38 RID: 24376
		// (get) Token: 0x0600BDBF RID: 48575 RVA: 0x00AF6D54 File Offset: 0x00AF4F54
		internal string CnvSysGeneralQc2Name_A42231_UILabel
		{
			get
			{
				short num = (short)832132017;
				short num2 = num;
				num = (short)687166385;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1068040192;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1362034688;
				if (num != 0)
				{
				}
				num = (short)760283137;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralQc2Name_A42231.UIName;
			}
		}

		// Token: 0x17005F39 RID: 24377
		// (get) Token: 0x0600BDC0 RID: 48576 RVA: 0x00AF6E08 File Offset: 0x00AF5008
		// (set) Token: 0x0600BDC1 RID: 48577 RVA: 0x00AF6EBC File Offset: 0x00AF50BC
		internal bool CnvSysGeneralQc2Name_A42231_HiddenStatic
		{
			get
			{
				short num = (short)1620626214;
				short num2 = num;
				num = (short)1333775142;
				switch (num2 == num)
				{
				default:
				{
					num = (short)749862912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1149894657;
				if (num != 0)
				{
				}
				num = (short)24707072;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralQc2Name_A42231.HiddenStatic;
			}
			set
			{
				short num = (short)845414401;
				if (num != 0)
				{
				}
				num = (short)1441660928;
				short num2 = num;
				num = (short)318534735;
				short num3 = num;
				num = (short)1704686671;
				switch (num3 == num)
				{
				}
				num = (short)1442971648;
				if (num != 0)
				{
				}
				this.cnvSysGeneralQc2Name_A42231.HiddenStatic = value;
			}
		}

		// Token: 0x17005F3A RID: 24378
		// (get) Token: 0x0600BDC2 RID: 48578 RVA: 0x00AF6F74 File Offset: 0x00AF5174
		// (set) Token: 0x0600BDC3 RID: 48579 RVA: 0x00AF702C File Offset: 0x00AF522C
		internal bool CnvSysGeneralQc2Name_A42231_HiddenDynamic
		{
			get
			{
				short num = (short)272534705;
				short num2 = num;
				num = (short)284527793;
				switch (num2 == num)
				{
				default:
				{
					num = (short)925630464;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1719402497;
				if (num != 0)
				{
				}
				num = (short)147914752;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralQc2Name_A42231.HiddenDynamic;
			}
			set
			{
				short num = (short)755562276;
				short num2 = num;
				num = (short)1315305252;
				switch (num2 == num)
				{
				default:
				{
					num = (short)519569408;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1627914241;
				if (num != 0)
				{
				}
				num = (short)737673216;
				if (num != 0)
				{
				}
				this.cnvSysGeneralQc2Name_A42231.HiddenDynamic = value;
			}
		}

		// Token: 0x17005F3B RID: 24379
		// (get) Token: 0x0600BDC4 RID: 48580 RVA: 0x00AF70E4 File Offset: 0x00AF52E4
		public bool CnvSysGeneralQc2Name_A42231_HasDiffs
		{
			get
			{
				short num = (short)2059171741;
				short num2 = num;
				num = (short)1074689949;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1909981184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)895680512;
				if (num != 0)
				{
				}
				num = (short)961413121;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralQc2Name_A42231._HasDiffs;
			}
		}

		// Token: 0x17005F3C RID: 24380
		// (get) Token: 0x0600BDC5 RID: 48581 RVA: 0x00AF7198 File Offset: 0x00AF5398
		// (set) Token: 0x0600BDC6 RID: 48582 RVA: 0x00AF724C File Offset: 0x00AF544C
		public int CnvSysGeneralQc2Freq_A42232Value
		{
			get
			{
				short num = (short)96737851;
				short num2 = num;
				num = (short)1134041659;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1340801024;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)265355265;
				if (num != 0)
				{
				}
				num = (short)1347747840;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralQc2Freq_A42232.Value;
			}
			set
			{
				short num = (short)1566159771;
				short num2 = num;
				num = (short)170505115;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1564278784;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)621412353;
				if (num != 0)
				{
				}
				num = (short)804978688;
				if (num != 0)
				{
				}
				this.cnvSysGeneralQc2Freq_A42232.Value = value;
			}
		}

		// Token: 0x17005F3D RID: 24381
		// (get) Token: 0x0600BDC7 RID: 48583 RVA: 0x00AF7300 File Offset: 0x00AF5500
		public global::AcpBusinessLayer.AcpCustomRangeField CnvSysGeneralQc2Freq_A42232
		{
			get
			{
				short num = (short)1769000932;
				short num2 = num;
				num = (short)1575800804;
				switch (num2 == num)
				{
				default:
				{
					num = (short)785580032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1722613760;
				if (num != 0)
				{
				}
				num = (short)1920663553;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralQc2Freq_A42232;
			}
		}

		// Token: 0x17005F3E RID: 24382
		// (get) Token: 0x0600BDC8 RID: 48584 RVA: 0x00AF73B0 File Offset: 0x00AF55B0
		// (set) Token: 0x0600BDC9 RID: 48585 RVA: 0x00AF7468 File Offset: 0x00AF5668
		public string CnvSysGeneralQc2Freq_A42232_UIValue
		{
			get
			{
				short num = (short)99467853;
				short num2 = num;
				num = (short)1303364173;
				switch (num2 == num)
				{
				default:
				{
					num = (short)597688320;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1236992000;
				if (num != 0)
				{
				}
				num = (short)404684801;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralQc2Freq_A42232.UIValue;
			}
			set
			{
				short num = (short)66546445;
				short num2 = num;
				num = (short)1226402573;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1112997888;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1368129537;
				if (num != 0)
				{
				}
				num = (short)861143040;
				if (num != 0)
				{
				}
				this.cnvSysGeneralQc2Freq_A42232.UIValue = value;
			}
		}

		// Token: 0x17005F3F RID: 24383
		// (get) Token: 0x0600BDCA RID: 48586 RVA: 0x00AF751C File Offset: 0x00AF571C
		// (set) Token: 0x0600BDCB RID: 48587 RVA: 0x00AF75D0 File Offset: 0x00AF57D0
		internal int CnvSysGeneralQc2Freq_A42232Min
		{
			get
			{
				short num = (short)1300955137;
				if (num != 0)
				{
				}
				num = (short)658505728;
				short num2 = num;
				num = (short)1439976174;
				short num3 = num;
				num = (short)1432308462;
				switch (num3 == num)
				{
				}
				num = (short)636420096;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralQc2Freq_A42232.Min;
			}
			set
			{
				short num = (short)814874625;
				if (num != 0)
				{
				}
				num = (short)226623488;
				short num2 = num;
				num = (short)789867528;
				short num3 = num;
				num = (short)873884680;
				switch (num3 == num)
				{
				}
				num = (short)1519779840;
				if (num != 0)
				{
				}
				this.cnvSysGeneralQc2Freq_A42232.Min = value;
			}
		}

		// Token: 0x17005F40 RID: 24384
		// (get) Token: 0x0600BDCC RID: 48588 RVA: 0x00AF7684 File Offset: 0x00AF5884
		// (set) Token: 0x0600BDCD RID: 48589 RVA: 0x00AF773C File Offset: 0x00AF593C
		internal int CnvSysGeneralQc2Freq_A42232Max
		{
			get
			{
				short num = (short)1597439198;
				short num2 = num;
				num = (short)1729428702;
				switch (num2 == num)
				{
				default:
				{
					num = (short)855506944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1405616128;
				if (num != 0)
				{
				}
				num = (short)2107310081;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralQc2Freq_A42232.Max;
			}
			set
			{
				short num = (short)413943427;
				short num2 = num;
				num = (short)1579566723;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1601830912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)314179585;
				if (num != 0)
				{
				}
				num = (short)258801664;
				if (num != 0)
				{
				}
				this.cnvSysGeneralQc2Freq_A42232.Max = value;
			}
		}

		// Token: 0x17005F41 RID: 24385
		// (get) Token: 0x0600BDCE RID: 48590 RVA: 0x00AF77F4 File Offset: 0x00AF59F4
		// (set) Token: 0x0600BDCF RID: 48591 RVA: 0x00AF78AC File Offset: 0x00AF5AAC
		internal int CnvSysGeneralQc2Freq_A42232Step
		{
			get
			{
				short num = (short)981840023;
				short num2 = num;
				num = (short)1414770839;
				switch (num2 == num)
				{
				default:
				{
					num = (short)310706176;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)624754689;
				if (num != 0)
				{
				}
				num = (short)1243283456;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralQc2Freq_A42232.StepSize;
			}
			set
			{
				short num = (short)1667201543;
				short num2 = num;
				num = (short)1203599879;
				switch (num2 == num)
				{
				}
				num = (short)498860032;
				short num3 = num;
				num = (short)1384054785;
				if (num != 0)
				{
				}
				num = (short)896401408;
				if (num != 0)
				{
				}
				this.cnvSysGeneralQc2Freq_A42232.StepSize = value;
			}
		}

		// Token: 0x17005F42 RID: 24386
		// (get) Token: 0x0600BDD0 RID: 48592 RVA: 0x00AF7960 File Offset: 0x00AF5B60
		// (set) Token: 0x0600BDD1 RID: 48593 RVA: 0x00AF7A14 File Offset: 0x00AF5C14
		public bool CnvSysGeneralQc2Freq_A42232_Applicable
		{
			get
			{
				short num = (short)1542979585;
				if (num != 0)
				{
				}
				num = (short)180688688;
				short num2 = num;
				num = (short)1269176112;
				switch (num2 == num)
				{
				default:
				{
					num = (short)538968064;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1445265408;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralQc2Freq_A42232.Applicable;
			}
			set
			{
				short num = (short)288252244;
				short num2 = num;
				num = (short)526278996;
				switch (num2 == num)
				{
				}
				num = (short)629014528;
				short num3 = num;
				num = (short)1554251776;
				if (num != 0)
				{
				}
				num = (short)1049231361;
				if (num != 0)
				{
				}
				this.cnvSysGeneralQc2Freq_A42232.Applicable = value;
			}
		}

		// Token: 0x17005F43 RID: 24387
		// (get) Token: 0x0600BDD2 RID: 48594 RVA: 0x00AF7AC8 File Offset: 0x00AF5CC8
		// (set) Token: 0x0600BDD3 RID: 48595 RVA: 0x00AF7B80 File Offset: 0x00AF5D80
		public bool CnvSysGeneralQc2Freq_A42232_Valid
		{
			get
			{
				short num = (short)2082788983;
				short num2 = num;
				num = (short)140498551;
				switch (num2 == num)
				{
				}
				num = (short)2060910592;
				short num3 = num;
				num = (short)2143748097;
				if (num != 0)
				{
				}
				num = (short)2108489728;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralQc2Freq_A42232.Valid;
			}
			set
			{
				short num = (short)189661185;
				if (num != 0)
				{
				}
				num = (short)1955337696;
				short num2 = num;
				num = (short)1528829408;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2139553792;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2051014656;
				if (num != 0)
				{
				}
				this.cnvSysGeneralQc2Freq_A42232.Valid = value;
			}
		}

		// Token: 0x17005F44 RID: 24388
		// (get) Token: 0x0600BDD4 RID: 48596 RVA: 0x00AF7C38 File Offset: 0x00AF5E38
		// (set) Token: 0x0600BDD5 RID: 48597 RVA: 0x00AF7CF0 File Offset: 0x00AF5EF0
		public bool CnvSysGeneralQc2Freq_A42232_Visible
		{
			get
			{
				short num = (short)1730686230;
				short num2 = num;
				num = (short)1954098454;
				switch (num2 == num)
				{
				}
				num = (short)1683554304;
				short num3 = num;
				num = (short)1815281665;
				if (num != 0)
				{
				}
				num = (short)1461780480;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralQc2Freq_A42232.Visible;
			}
			set
			{
				short num = (short)238944257;
				if (num != 0)
				{
				}
				num = (short)180928254;
				short num2 = num;
				num = (short)1033617150;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1450246144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2111111168;
				if (num != 0)
				{
				}
				this.cnvSysGeneralQc2Freq_A42232.Visible = value;
			}
		}

		// Token: 0x17005F45 RID: 24389
		// (get) Token: 0x0600BDD6 RID: 48598 RVA: 0x00AF7DA4 File Offset: 0x00AF5FA4
		// (set) Token: 0x0600BDD7 RID: 48599 RVA: 0x00AF7E5C File Offset: 0x00AF605C
		public bool CnvSysGeneralQc2Freq_A42232_Editable
		{
			get
			{
				short num = (short)853247567;
				short num2 = num;
				num = (short)2087880271;
				switch (num2 == num)
				{
				}
				num = (short)2019229696;
				short num3 = num;
				num = (short)1749483520;
				if (num != 0)
				{
				}
				num = (short)1164181505;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralQc2Freq_A42232.Editable;
			}
			set
			{
				short num = (short)1085007517;
				short num2 = num;
				num = (short)615966365;
				switch (num2 == num)
				{
				}
				num = (short)1406926848;
				short num3 = num;
				num = (short)2045181952;
				if (num != 0)
				{
				}
				num = (short)1336803329;
				if (num != 0)
				{
				}
				this.cnvSysGeneralQc2Freq_A42232.Editable = value;
			}
		}

		// Token: 0x17005F46 RID: 24390
		// (get) Token: 0x0600BDD8 RID: 48600 RVA: 0x00AF7F14 File Offset: 0x00AF6114
		internal string CnvSysGeneralQc2Freq_A42232_UILabel
		{
			get
			{
				short num = (short)1978606802;
				short num2 = num;
				num = (short)646784210;
				switch (num2 == num)
				{
				}
				num = (short)224526336;
				short num3 = num;
				num = (short)285671424;
				if (num != 0)
				{
				}
				num = (short)1188626433;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralQc2Freq_A42232.UIName;
			}
		}

		// Token: 0x17005F47 RID: 24391
		// (get) Token: 0x0600BDD9 RID: 48601 RVA: 0x00AF7FC8 File Offset: 0x00AF61C8
		// (set) Token: 0x0600BDDA RID: 48602 RVA: 0x00AF807C File Offset: 0x00AF627C
		internal bool CnvSysGeneralQc2Freq_A42232_HiddenStatic
		{
			get
			{
				short num = (short)1667430642;
				short num2 = num;
				num = (short)1473444082;
				switch (num2 == num)
				{
				}
				num = (short)1435828224;
				short num3 = num;
				num = (short)1898250240;
				if (num != 0)
				{
				}
				num = (short)1646264321;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralQc2Freq_A42232.HiddenStatic;
			}
			set
			{
				short num = (short)1454094250;
				short num2 = num;
				num = (short)1423620010;
				switch (num2 == num)
				{
				}
				num = (short)363331584;
				short num3 = num;
				num = (short)868024321;
				if (num != 0)
				{
				}
				num = (short)583991296;
				if (num != 0)
				{
				}
				this.cnvSysGeneralQc2Freq_A42232.HiddenStatic = value;
			}
		}

		// Token: 0x17005F48 RID: 24392
		// (get) Token: 0x0600BDDB RID: 48603 RVA: 0x00AF8130 File Offset: 0x00AF6330
		// (set) Token: 0x0600BDDC RID: 48604 RVA: 0x00AF81E8 File Offset: 0x00AF63E8
		internal bool CnvSysGeneralQc2Freq_A42232_HiddenDynamic
		{
			get
			{
				short num = (short)2102049959;
				short num2 = num;
				num = (short)791395495;
				switch (num2 == num)
				{
				}
				num = (short)214892544;
				short num3 = num;
				num = (short)1859911680;
				if (num != 0)
				{
				}
				num = (short)1233846273;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralQc2Freq_A42232.HiddenDynamic;
			}
			set
			{
				short num = (short)631007687;
				short num2 = num;
				num = (short)1732667847;
				switch (num2 == num)
				{
				}
				num = (short)2080243712;
				short num3 = num;
				num = (short)886046720;
				if (num != 0)
				{
				}
				num = (short)45285377;
				if (num != 0)
				{
				}
				this.cnvSysGeneralQc2Freq_A42232.HiddenDynamic = value;
			}
		}

		// Token: 0x17005F49 RID: 24393
		// (get) Token: 0x0600BDDD RID: 48605 RVA: 0x00AF829C File Offset: 0x00AF649C
		public bool CnvSysGeneralQc2Freq_A42232_HasDiffs
		{
			get
			{
				short num = (short)40576549;
				short num2 = num;
				num = (short)1589847589;
				switch (num2 == num)
				{
				}
				num = (short)289603584;
				short num3 = num;
				num = (short)1484652544;
				if (num != 0)
				{
				}
				num = (short)1923809281;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralQc2Freq_A42232._HasDiffs;
			}
		}

		// Token: 0x17005F4A RID: 24394
		// (get) Token: 0x0600BDDE RID: 48606 RVA: 0x00AF8350 File Offset: 0x00AF6550
		// (set) Token: 0x0600BDDF RID: 48607 RVA: 0x00AF8404 File Offset: 0x00AF6604
		public int CnvSysGeneralQc2Code_A42234Value
		{
			get
			{
				short num = (short)134004667;
				short num2 = num;
				num = (short)1643954107;
				switch (num2 == num)
				{
				}
				num = (short)1440743424;
				short num3 = num;
				num = (short)1179189249;
				if (num != 0)
				{
				}
				num = (short)496041984;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralQc2Code_A42234.Value;
			}
			set
			{
				short num = (short)752913622;
				short num2 = num;
				num = (short)861048022;
				switch (num2 == num)
				{
				}
				num = (short)1250689024;
				short num3 = num;
				num = (short)1082130432;
				if (num != 0)
				{
				}
				num = (short)718667777;
				if (num != 0)
				{
				}
				this.cnvSysGeneralQc2Code_A42234.Value = value;
			}
		}

		// Token: 0x17005F4B RID: 24395
		// (get) Token: 0x0600BDE0 RID: 48608 RVA: 0x00AF84B8 File Offset: 0x00AF66B8
		// (set) Token: 0x0600BDE1 RID: 48609 RVA: 0x00AF8570 File Offset: 0x00AF6770
		public string CnvSysGeneralQc2Code_A42234_UIValue
		{
			get
			{
				short num = (short)1524032246;
				short num2 = num;
				num = (short)418636534;
				switch (num2 == num)
				{
				}
				num = (short)1501757440;
				short num3 = num;
				num = (short)1663041536;
				if (num != 0)
				{
				}
				num = (short)1145241601;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralQc2Code_A42234.UIValue;
			}
			set
			{
				short num = (short)731162306;
				short num2 = num;
				num = (short)1635362498;
				switch (num2 == num)
				{
				}
				num = (short)1007484928;
				short num3 = num;
				num = (short)1215889409;
				if (num != 0)
				{
				}
				num = (short)1846542336;
				if (num != 0)
				{
				}
				this.cnvSysGeneralQc2Code_A42234.UIValue = value;
			}
		}

		// Token: 0x17005F4C RID: 24396
		// (get) Token: 0x0600BDE2 RID: 48610 RVA: 0x00AF8628 File Offset: 0x00AF6828
		public global::AcpBusinessLayer.AcpListField CnvSysGeneralQc2Code_A42234
		{
			get
			{
				short num = (short)1410138113;
				if (num != 0)
				{
				}
				num = (short)430476042;
				short num2 = num;
				num = (short)868518666;
				switch (num2 == num)
				{
				default:
				{
					num = (short)635371520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1528496128;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralQc2Code_A42234;
			}
		}

		// Token: 0x17005F4D RID: 24397
		// (get) Token: 0x0600BDE3 RID: 48611 RVA: 0x00AF86D8 File Offset: 0x00AF68D8
		// (set) Token: 0x0600BDE4 RID: 48612 RVA: 0x00AF878C File Offset: 0x00AF698C
		public bool CnvSysGeneralQc2Code_A42234_Applicable
		{
			get
			{
				short num = (short)871483916;
				short num2 = num;
				num = (short)1159973388;
				switch (num2 == num)
				{
				}
				num = (short)310181888;
				short num3 = num;
				num = (short)909377537;
				if (num != 0)
				{
				}
				num = (short)777125888;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralQc2Code_A42234.Applicable;
			}
			set
			{
				short num = (short)1777574660;
				short num2 = num;
				num = (short)679650052;
				switch (num2 == num)
				{
				}
				num = (short)1768554496;
				short num3 = num;
				num = (short)20250625;
				if (num != 0)
				{
				}
				num = (short)44564480;
				if (num != 0)
				{
				}
				this.cnvSysGeneralQc2Code_A42234.Applicable = value;
			}
		}

		// Token: 0x17005F4E RID: 24398
		// (get) Token: 0x0600BDE5 RID: 48613 RVA: 0x00AF8844 File Offset: 0x00AF6A44
		// (set) Token: 0x0600BDE6 RID: 48614 RVA: 0x00AF88F8 File Offset: 0x00AF6AF8
		public bool CnvSysGeneralQc2Code_A42234_Valid
		{
			get
			{
				short num = (short)1204233846;
				short num2 = num;
				num = (short)921314934;
				switch (num2 == num)
				{
				}
				num = (short)557056000;
				short num3 = num;
				num = (short)374800384;
				if (num != 0)
				{
				}
				num = (short)578945025;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralQc2Code_A42234.Valid;
			}
			set
			{
				short num = (short)719348319;
				short num2 = num;
				num = (short)1848205919;
				switch (num2 == num)
				{
				}
				num = (short)1177157632;
				short num3 = num;
				num = (short)201719809;
				if (num != 0)
				{
				}
				num = (short)484114432;
				if (num != 0)
				{
				}
				this.cnvSysGeneralQc2Code_A42234.Valid = value;
			}
		}

		// Token: 0x17005F4F RID: 24399
		// (get) Token: 0x0600BDE7 RID: 48615 RVA: 0x00AF89B0 File Offset: 0x00AF6BB0
		// (set) Token: 0x0600BDE8 RID: 48616 RVA: 0x00AF8A64 File Offset: 0x00AF6C64
		public bool CnvSysGeneralQc2Code_A42234_Visible
		{
			get
			{
				short num = (short)1267229585;
				short num2 = num;
				num = (short)2144101265;
				switch (num2 == num)
				{
				}
				num = (short)303104000;
				short num3 = num;
				num = (short)1456472065;
				if (num != 0)
				{
				}
				num = (short)1518665728;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralQc2Code_A42234.Visible;
			}
			set
			{
				short num = (short)116605277;
				short num2 = num;
				num = (short)1585856861;
				switch (num2 == num)
				{
				}
				num = (short)2141585408;
				short num3 = num;
				num = (short)707002369;
				if (num != 0)
				{
				}
				num = (short)1004666880;
				if (num != 0)
				{
				}
				this.cnvSysGeneralQc2Code_A42234.Visible = value;
			}
		}

		// Token: 0x17005F50 RID: 24400
		// (get) Token: 0x0600BDE9 RID: 48617 RVA: 0x00AF8B1C File Offset: 0x00AF6D1C
		// (set) Token: 0x0600BDEA RID: 48618 RVA: 0x00AF8BD0 File Offset: 0x00AF6DD0
		public bool CnvSysGeneralQc2Code_A42234_Editable
		{
			get
			{
				short num = (short)555450651;
				short num2 = num;
				num = (short)1271234843;
				switch (num2 == num)
				{
				}
				num = (short)2103574528;
				short num3 = num;
				num = (short)1964376065;
				if (num != 0)
				{
				}
				num = (short)831324160;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralQc2Code_A42234.Editable;
			}
			set
			{
				short num = (short)625737729;
				if (num != 0)
				{
				}
				num = (short)1486909507;
				short num2 = num;
				num = (short)397176899;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1783693312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2046885888;
				if (num != 0)
				{
				}
				this.cnvSysGeneralQc2Code_A42234.Editable = value;
			}
		}

		// Token: 0x17005F51 RID: 24401
		// (get) Token: 0x0600BDEB RID: 48619 RVA: 0x00AF8C84 File Offset: 0x00AF6E84
		internal string CnvSysGeneralQc2Code_A42234_UILabel
		{
			get
			{
				short num = (short)2146723239;
				short num2 = num;
				num = (short)632448423;
				switch (num2 == num)
				{
				}
				num = (short)2016542720;
				short num3 = num;
				num = (short)2113077249;
				if (num != 0)
				{
				}
				num = (short)1892679680;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralQc2Code_A42234.UIName;
			}
		}

		// Token: 0x17005F52 RID: 24402
		// (get) Token: 0x0600BDEC RID: 48620 RVA: 0x00AF8D34 File Offset: 0x00AF6F34
		// (set) Token: 0x0600BDED RID: 48621 RVA: 0x00AF8DE8 File Offset: 0x00AF6FE8
		internal bool CnvSysGeneralQc2Code_A42234_HiddenStatic
		{
			get
			{
				short num = (short)1815684978;
				short num2 = num;
				num = (short)412034930;
				switch (num2 == num)
				{
				}
				num = (short)660668416;
				short num3 = num;
				num = (short)1686503425;
				if (num != 0)
				{
				}
				num = (short)636813312;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralQc2Code_A42234.HiddenStatic;
			}
			set
			{
				short num = (short)697061781;
				short num2 = num;
				num = (short)217403797;
				switch (num2 == num)
				{
				}
				num = (short)103874560;
				short num3 = num;
				num = (short)1590296577;
				if (num != 0)
				{
				}
				num = (short)1390608384;
				if (num != 0)
				{
				}
				this.cnvSysGeneralQc2Code_A42234.HiddenStatic = value;
			}
		}

		// Token: 0x17005F53 RID: 24403
		// (get) Token: 0x0600BDEE RID: 48622 RVA: 0x00AF8EA0 File Offset: 0x00AF70A0
		// (set) Token: 0x0600BDEF RID: 48623 RVA: 0x00AF8F50 File Offset: 0x00AF7150
		internal bool CnvSysGeneralQc2Code_A42234_HiddenDynamic
		{
			get
			{
				short num = (short)1026490369;
				if (num != 0)
				{
				}
				num = (short)1467697723;
				short num2 = num;
				num = (short)2102544955;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2127626240;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1480065024;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralQc2Code_A42234.HiddenDynamic;
			}
			set
			{
				short num = (short)700471638;
				short num2 = num;
				num = (short)250829142;
				switch (num2 == num)
				{
				}
				num = (short)670629888;
				short num3 = num;
				num = (short)1594818561;
				if (num != 0)
				{
				}
				num = (short)563478528;
				if (num != 0)
				{
				}
				this.cnvSysGeneralQc2Code_A42234.HiddenDynamic = value;
			}
		}

		// Token: 0x17005F54 RID: 24404
		// (get) Token: 0x0600BDF0 RID: 48624 RVA: 0x00AF9004 File Offset: 0x00AF7204
		public bool CnvSysGeneralQc2Code_A42234_HasDiffs
		{
			get
			{
				short num = (short)250961217;
				short num2 = num;
				num = (short)442981697;
				switch (num2 == num)
				{
				}
				num = (short)39190528;
				short num3 = num;
				num = (short)683474945;
				if (num != 0)
				{
				}
				num = (short)566755328;
				if (num != 0)
				{
				}
				return this.cnvSysGeneralQc2Code_A42234._HasDiffs;
			}
		}

		// Token: 0x0600BDF1 RID: 48625 RVA: 0x00AF90BC File Offset: 0x00AF72BC
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
					return result;
				case 1:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)1972043776;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					while (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)718319997;
						short num3 = num2;
						num2 = (short)1263251837;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num2 = (short)441647104;
							if (num2 != 0)
							{
							}
							num2 = (short)909967361;
							if (num2 != 0)
							{
							}
							num2 = (short)323747841;
							num = (int)((global::System.IntPtr)num2);
							goto IL_0A;
						}
					}
					return result;
				case 3:
					if (base.ParentRecset != null)
					{
						num2 = (short)2033254400;
						short num4 = num2;
						num2 = (short)1385693188;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 4:
					num2 = (short)737476610;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_24;
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)1311440899;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04005C2B RID: 23595
		private global::AcpBusinessLayer.AcpField<string> cnvSysGeneralQc2Name_A42231;

		// Token: 0x04005C2C RID: 23596
		private global::AcpBusinessLayer.AcpCustomRangeField cnvSysGeneralQc2Freq_A42232;

		// Token: 0x04005C2D RID: 23597
		private global::AcpBusinessLayer.AcpListField cnvSysGeneralQc2Code_A42234;
	}
}
