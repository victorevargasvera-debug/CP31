using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.DataProfiles
{
	// Token: 0x02000516 RID: 1302
	[global::System.Serializable]
	public class TrunkingGroupIDListInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600B0FD RID: 45309 RVA: 0x00A41B58 File Offset: 0x00A3FD58
		public TrunkingGroupIDListInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x0600B0FE RID: 45310 RVA: 0x00A41B74 File Offset: 0x00A3FD74
		protected TrunkingGroupIDListInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600B0FF RID: 45311 RVA: 0x00A41B8C File Offset: 0x00A3FD8C
		public override void Init()
		{
			int a_ = 14;
			short num = (short)475004928;
			short num2 = num;
			num = (short)154240377;
			short num3 = num;
			num = (short)900760953;
			switch (num3 == num)
			{
			}
			num = (short)107347969;
			if (num != 0)
			{
			}
			num = (short)1114177536;
			if (num != 0)
			{
			}
			this.dataProfilesTrunkingGroupID_ASTRO25DataGroupID_A36204 = new global::AcpBusinessLayer.AcpSimpleRangeField(10000000, this, global::AllFeatures.CodeplugGuid.b("诎냐꟒듔蟖ꯘ듚믜뛞跠蛢雤돦鯨黪菬蓮飰鷲鋴냶诸铺裼迾䠀䜂娄䘆娈弊弌䀎⌐☒儔瘖洘稚娜洞丠嘢唤渦洨琪氬ᰮܰĲԴ̶", a_), global::CommonResources.AcgResources.ID_ASTRO25DATAGROUPID, 10000000, 16777214, null, null, 0, 1);
			this.dataProfilesTrunkingGroupID_ASTRO25DataGroupID_A36204.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.dataProfilesTrunkingGroupID_ASTRO25DataGroupID_A36204.DataTransferOrder = 37;
			this.dataProfilesTrunkingGroupID_ASTRO25DataGroupID_A36204.ValidateAcrossRecset = true;
			this.dataProfilesTrunkingGroupID_ASTRO25DataGroupID_A36204.ShowHexValue = true;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鯎ꏐꛒ믔볖냘뗚뫜￞ꛠ釢諤鋦駨쯪ꓬ꯮퇰뿲鳴蓶跸", a_);
			base.Id = 10507;
			base.UIName = global::CommonResources.AcgResources.ID_TRUNKINGGROUPIDLIST;
			base.DataTransferOrder = 1;
		}

		// Token: 0x0600B100 RID: 45312 RVA: 0x00A41CD4 File Offset: 0x00A3FED4
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 7;
			short num = (short)1702035457;
			if (num != 0)
			{
			}
			num = (short)108225442;
			short num2 = num;
			num = (short)451568546;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1217921024;
				if (num != 0)
				{
				}
				num = (short)270270465;
				num3 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				switch (num3)
				{
				case 0:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("資ꯉ룋꿍胏ꃑ믓냕뇗뛙맛귝듟郡釣裥菧菩苫觭럯胱鯳菵裷돹룻ꇽ䇿儁倃吅䜇㠉㤋䨍焏昑甓儕樗甙椛渝椟昡笣朥ᬧᰩḫḭЯ", a_)))
					{
						num = (short)433979396;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1FB;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_BA;
					}
					continue;
				case 2:
				{
					num = (short)791216128;
					short num4 = num;
					num = (short)1571553280;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
					if (producerFields != null)
					{
						num = (short)632291330;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1FB;
				case 4:
					this.dataProfilesTrunkingGroupID_ASTRO25DataGroupID_A36204 = new global::AcpBusinessLayer.AcpSimpleRangeField(10000000, this, global::AllFeatures.CodeplugGuid.b("資ꯉ룋꿍胏ꃑ믓냕뇗뛙맛귝듟郡釣裥菧菩苫觭럯胱鯳菵裷돹룻ꇽ䇿儁倃吅䜇㠉㤋䨍焏昑甓儕樗甙椛渝椟昡笣朥ᬧᰩḫḭЯ", a_), global::CommonResources.AcgResources.ID_ASTRO25DATAGROUPID, null, null, 0, 1);
					this.dataProfilesTrunkingGroupID_ASTRO25DataGroupID_A36204.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.dataProfilesTrunkingGroupID_ASTRO25DataGroupID_A36204.DataTransferOrder = 37;
					this.dataProfilesTrunkingGroupID_ASTRO25DataGroupID_A36204.ValidateAcrossRecset = true;
					this.dataProfilesTrunkingGroupID_ASTRO25DataGroupID_A36204.ShowHexValue = true;
					num = (short)680394757;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_14D;
				case 6:
					num = (short)1544159235;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_BA:
				if (!global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					break;
				}
				num = (short)574160902;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_14D:
			IL_1FB:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鳇룉맋ꃍ믏믑뫓뇕鷙껛뇝闟鋡쓣꿥곧쫩ꃫ蟭華蛱", a_);
			base.Id = 10507;
			base.UIName = global::CommonResources.AcgResources.ID_TRUNKINGGROUPIDLIST;
			base.DataTransferOrder = 1;
		}

		// Token: 0x0600B101 RID: 45313 RVA: 0x00A41F10 File Offset: 0x00A40110
		public override void PopulateReferences()
		{
			short num = (short)1157562368;
			short num2 = num;
			num = (short)646540570;
			short num3 = num;
			num = (short)1981312282;
			switch (num3 == num)
			{
			}
			num = (short)1402142721;
			if (num != 0)
			{
			}
			num = (short)506003456;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600B102 RID: 45314 RVA: 0x00A41FB8 File Offset: 0x00A401B8
		public override void DropReferences()
		{
			short num = (short)101384192;
			short num2 = num;
			num = (short)1053403232;
			short num3 = num;
			num = (short)1902291040;
			switch (num3 == num)
			{
			}
			num = (short)1357971456;
			if (num != 0)
			{
			}
			num = (short)1055391745;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600B103 RID: 45315 RVA: 0x00A42064 File Offset: 0x00A40264
		public override void SetConstraints()
		{
			short num = (short)897449984;
			short num2 = num;
			num = (short)1923011952;
			short num3 = num;
			num = (short)1344853360;
			switch (num3 == num)
			{
			}
			num = (short)2054160385;
			if (num != 0)
			{
			}
			num = (short)1400307712;
			if (num != 0)
			{
			}
			this.dataProfilesTrunkingGroupID_ASTRO25DataGroupID_A36204.ValidateAcrossRecset = true;
			this.dataProfilesTrunkingGroupID_ASTRO25DataGroupID_A36204.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.conDataProfileTypeTrunking);
			this.dataProfilesTrunkingGroupID_ASTRO25DataGroupID_A36204.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.conDataProfileGroupIDIsUnique);
		}

		// Token: 0x0600B104 RID: 45316 RVA: 0x00A42148 File Offset: 0x00A40348
		public override void SetupDependencies()
		{
			short num = (short)2115567616;
			short num2 = num;
			num = (short)1956970497;
			if (num != 0)
			{
			}
			num = (short)412844702;
			short num3 = num;
			num = (short)1153139358;
			switch (num3 == num)
			{
			}
			num = (short)1425604608;
			if (num != 0)
			{
			}
			(base.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles).General.DataProfGeneralDataProfileType_A21320.AddDependentObject(this.dataProfilesTrunkingGroupID_ASTRO25DataGroupID_A36204);
		}

		// Token: 0x170058E3 RID: 22755
		// (get) Token: 0x0600B105 RID: 45317 RVA: 0x00A4221C File Offset: 0x00A4041C
		public bool HasDiffs
		{
			get
			{
				short num = (short)1481637888;
				short num2 = num;
				num = (short)2101993879;
				short num3 = num;
				num = (short)1737351575;
				switch (num3 == num)
				{
				}
				num = (short)703135744;
				if (num != 0)
				{
				}
				num = (short)1310588929;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x170058E4 RID: 22756
		// (get) Token: 0x0600B106 RID: 45318 RVA: 0x00A422CC File Offset: 0x00A404CC
		// (set) Token: 0x0600B107 RID: 45319 RVA: 0x00A42380 File Offset: 0x00A40580
		public int DataProfilesTrunkingGroupID_ASTRO25DataGroupID_A36204Value
		{
			get
			{
				short num = (short)1909260288;
				short num2 = num;
				num = (short)1835661935;
				short num3 = num;
				num = (short)1728576111;
				switch (num3 == num)
				{
				}
				num = (short)333774849;
				if (num != 0)
				{
				}
				num = (short)1164378112;
				if (num != 0)
				{
				}
				return this.dataProfilesTrunkingGroupID_ASTRO25DataGroupID_A36204.Value;
			}
			set
			{
				short num = (short)1994129408;
				short num2 = num;
				num = (short)975503361;
				if (num != 0)
				{
				}
				num = (short)176283071;
				short num3 = num;
				num = (short)1347149247;
				switch (num3 == num)
				{
				}
				num = (short)1405288448;
				if (num != 0)
				{
				}
				this.dataProfilesTrunkingGroupID_ASTRO25DataGroupID_A36204.Value = value;
			}
		}

		// Token: 0x170058E5 RID: 22757
		// (get) Token: 0x0600B108 RID: 45320 RVA: 0x00A42434 File Offset: 0x00A40634
		public global::AcpBusinessLayer.AcpSimpleRangeField DataProfilesTrunkingGroupID_ASTRO25DataGroupID_A36204
		{
			get
			{
				short num = (short)2077425664;
				short num2 = num;
				num = (short)212227783;
				short num3 = num;
				num = (short)376788679;
				switch (num3 == num)
				{
				}
				num = (short)1526267904;
				if (num != 0)
				{
				}
				num = (short)81199105;
				if (num != 0)
				{
				}
				return this.dataProfilesTrunkingGroupID_ASTRO25DataGroupID_A36204;
			}
		}

		// Token: 0x170058E6 RID: 22758
		// (get) Token: 0x0600B109 RID: 45321 RVA: 0x00A424E4 File Offset: 0x00A406E4
		// (set) Token: 0x0600B10A RID: 45322 RVA: 0x00A4259C File Offset: 0x00A4079C
		public string DataProfilesTrunkingGroupID_ASTRO25DataGroupID_A36204_UIValue
		{
			get
			{
				short num = (short)1213464576;
				short num2 = num;
				num = (short)979632129;
				if (num != 0)
				{
				}
				num = (short)138924965;
				short num3 = num;
				num = (short)534172581;
				switch (num3 == num)
				{
				}
				num = (short)798425088;
				if (num != 0)
				{
				}
				return this.dataProfilesTrunkingGroupID_ASTRO25DataGroupID_A36204.UIValue;
			}
			set
			{
				short num = (short)926351360;
				short num2 = num;
				num = (short)753381906;
				short num3 = num;
				num = (short)1571205650;
				switch (num3 == num)
				{
				}
				num = (short)1528823809;
				if (num != 0)
				{
				}
				num = (short)1078460416;
				if (num != 0)
				{
				}
				this.dataProfilesTrunkingGroupID_ASTRO25DataGroupID_A36204.UIValue = value;
			}
		}

		// Token: 0x170058E7 RID: 22759
		// (get) Token: 0x0600B10B RID: 45323 RVA: 0x00A42650 File Offset: 0x00A40850
		// (set) Token: 0x0600B10C RID: 45324 RVA: 0x00A42704 File Offset: 0x00A40904
		public string DataProfilesTrunkingGroupID_ASTRO25DataGroupID_A36204_HexUIValue
		{
			get
			{
				short num = (short)279904256;
				short num2 = num;
				num = (short)857677587;
				short num3 = num;
				num = (short)929636115;
				switch (num3 == num)
				{
				}
				num = (short)1108213760;
				if (num != 0)
				{
				}
				num = (short)431882241;
				if (num != 0)
				{
				}
				return this.dataProfilesTrunkingGroupID_ASTRO25DataGroupID_A36204.HexUIValue;
			}
			set
			{
				short num = (short)1330118656;
				short num2 = num;
				num = (short)497476725;
				short num3 = num;
				num = (short)886826101;
				switch (num3 == num)
				{
				}
				num = (short)167182336;
				if (num != 0)
				{
				}
				num = (short)2095579137;
				if (num != 0)
				{
				}
				this.dataProfilesTrunkingGroupID_ASTRO25DataGroupID_A36204.HexUIValue = value;
			}
		}

		// Token: 0x170058E8 RID: 22760
		// (get) Token: 0x0600B10D RID: 45325 RVA: 0x00A427BC File Offset: 0x00A409BC
		// (set) Token: 0x0600B10E RID: 45326 RVA: 0x00A42870 File Offset: 0x00A40A70
		internal int DataProfilesTrunkingGroupID_ASTRO25DataGroupID_A36204Min
		{
			get
			{
				short num = (short)1519321088;
				short num2 = num;
				num = (short)1329869052;
				short num3 = num;
				num = (short)2069901564;
				switch (num3 == num)
				{
				}
				num = (short)1574895616;
				if (num != 0)
				{
				}
				num = (short)1371340801;
				if (num != 0)
				{
				}
				return this.dataProfilesTrunkingGroupID_ASTRO25DataGroupID_A36204.Min;
			}
			set
			{
				short num = (short)470482944;
				short num2 = num;
				num = (short)455737345;
				if (num != 0)
				{
				}
				num = (short)1541892578;
				short num3 = num;
				num = (short)114452962;
				switch (num3 == num)
				{
				}
				num = (short)2071920640;
				if (num != 0)
				{
				}
				this.dataProfilesTrunkingGroupID_ASTRO25DataGroupID_A36204.Min = value;
			}
		}

		// Token: 0x170058E9 RID: 22761
		// (get) Token: 0x0600B10F RID: 45327 RVA: 0x00A42924 File Offset: 0x00A40B24
		// (set) Token: 0x0600B110 RID: 45328 RVA: 0x00A429D8 File Offset: 0x00A40BD8
		internal int DataProfilesTrunkingGroupID_ASTRO25DataGroupID_A36204Max
		{
			get
			{
				short num = (short)1055457280;
				short num2 = num;
				num = (short)1101774502;
				short num3 = num;
				num = (short)25607846;
				switch (num3 == num)
				{
				}
				num = (short)2119172097;
				if (num != 0)
				{
				}
				num = (short)116719616;
				if (num != 0)
				{
				}
				return this.dataProfilesTrunkingGroupID_ASTRO25DataGroupID_A36204.Max;
			}
			set
			{
				short num = (short)2091384832;
				short num2 = num;
				num = (short)1172756507;
				short num3 = num;
				num = (short)1620432923;
				switch (num3 == num)
				{
				}
				num = (short)1127219201;
				if (num != 0)
				{
				}
				num = (short)1116733440;
				if (num != 0)
				{
				}
				this.dataProfilesTrunkingGroupID_ASTRO25DataGroupID_A36204.Max = value;
			}
		}

		// Token: 0x170058EA RID: 22762
		// (get) Token: 0x0600B111 RID: 45329 RVA: 0x00A42A90 File Offset: 0x00A40C90
		// (set) Token: 0x0600B112 RID: 45330 RVA: 0x00A42B44 File Offset: 0x00A40D44
		internal int DataProfilesTrunkingGroupID_ASTRO25DataGroupID_A36204Step
		{
			get
			{
				short num = (short)384172032;
				short num2 = num;
				num = (short)65959800;
				short num3 = num;
				num = (short)1744926584;
				switch (num3 == num)
				{
				}
				num = (short)461897729;
				if (num != 0)
				{
				}
				num = (short)572588032;
				if (num != 0)
				{
				}
				return this.dataProfilesTrunkingGroupID_ASTRO25DataGroupID_A36204.StepSize;
			}
			set
			{
				short num = (short)893583360;
				short num2 = num;
				num = (short)106829890;
				short num3 = num;
				num = (short)899160130;
				switch (num3 == num)
				{
				}
				num = (short)524484609;
				if (num != 0)
				{
				}
				num = (short)430899200;
				if (num != 0)
				{
				}
				this.dataProfilesTrunkingGroupID_ASTRO25DataGroupID_A36204.StepSize = value;
			}
		}

		// Token: 0x170058EB RID: 22763
		// (get) Token: 0x0600B113 RID: 45331 RVA: 0x00A42BF8 File Offset: 0x00A40DF8
		// (set) Token: 0x0600B114 RID: 45332 RVA: 0x00A42CAC File Offset: 0x00A40EAC
		public bool DataProfilesTrunkingGroupID_ASTRO25DataGroupID_A36204_Applicable
		{
			get
			{
				short num = (short)554106880;
				short num2 = num;
				num = (short)1619833429;
				short num3 = num;
				num = (short)186233429;
				switch (num3 == num)
				{
				}
				num = (short)1553596416;
				if (num != 0)
				{
				}
				num = (short)772079617;
				if (num != 0)
				{
				}
				return this.dataProfilesTrunkingGroupID_ASTRO25DataGroupID_A36204.Applicable;
			}
			set
			{
				short num = (short)660471808;
				short num2 = num;
				num = (short)502901396;
				short num3 = num;
				num = (short)1220848276;
				switch (num3 == num)
				{
				}
				num = (short)2020933633;
				if (num != 0)
				{
				}
				num = (short)642121728;
				if (num != 0)
				{
				}
				this.dataProfilesTrunkingGroupID_ASTRO25DataGroupID_A36204.Applicable = value;
			}
		}

		// Token: 0x170058EC RID: 22764
		// (get) Token: 0x0600B115 RID: 45333 RVA: 0x00A42D64 File Offset: 0x00A40F64
		// (set) Token: 0x0600B116 RID: 45334 RVA: 0x00A42E1C File Offset: 0x00A4101C
		public bool DataProfilesTrunkingGroupID_ASTRO25DataGroupID_A36204_Valid
		{
			get
			{
				short num = (short)1269563392;
				short num2 = num;
				num = (short)1584452055;
				short num3 = num;
				num = (short)944951767;
				switch (num3 == num)
				{
				}
				num = (short)1991573504;
				if (num != 0)
				{
				}
				num = (short)194707457;
				if (num != 0)
				{
				}
				return this.dataProfilesTrunkingGroupID_ASTRO25DataGroupID_A36204.Valid;
			}
			set
			{
				short num = (short)323682304;
				short num2 = num;
				num = (short)1275422975;
				short num3 = num;
				num = (short)1286170879;
				switch (num3 == num)
				{
				}
				num = (short)869990401;
				if (num != 0)
				{
				}
				num = (short)564527104;
				if (num != 0)
				{
				}
				this.dataProfilesTrunkingGroupID_ASTRO25DataGroupID_A36204.Valid = value;
			}
		}

		// Token: 0x170058ED RID: 22765
		// (get) Token: 0x0600B117 RID: 45335 RVA: 0x00A42ED4 File Offset: 0x00A410D4
		// (set) Token: 0x0600B118 RID: 45336 RVA: 0x00A42F88 File Offset: 0x00A41188
		public bool DataProfilesTrunkingGroupID_ASTRO25DataGroupID_A36204_Visible
		{
			get
			{
				short num = (short)323485696;
				short num2 = num;
				num = (short)1704657645;
				short num3 = num;
				num = (short)1448084205;
				switch (num3 == num)
				{
				}
				num = (short)656080897;
				if (num != 0)
				{
				}
				num = (short)1466302464;
				if (num != 0)
				{
				}
				return this.dataProfilesTrunkingGroupID_ASTRO25DataGroupID_A36204.Visible;
			}
			set
			{
				short num = (short)1201602560;
				short num2 = num;
				num = (short)1934545895;
				short num3 = num;
				num = (short)689230823;
				switch (num3 == num)
				{
				}
				num = (short)1657536513;
				if (num != 0)
				{
				}
				num = (short)1703936;
				if (num != 0)
				{
				}
				this.dataProfilesTrunkingGroupID_ASTRO25DataGroupID_A36204.Visible = value;
			}
		}

		// Token: 0x170058EE RID: 22766
		// (get) Token: 0x0600B119 RID: 45337 RVA: 0x00A4303C File Offset: 0x00A4123C
		// (set) Token: 0x0600B11A RID: 45338 RVA: 0x00A430F0 File Offset: 0x00A412F0
		public bool DataProfilesTrunkingGroupID_ASTRO25DataGroupID_A36204_Editable
		{
			get
			{
				short num = (short)1897201664;
				short num2 = num;
				num = (short)1316602788;
				short num3 = num;
				num = (short)1006748580;
				switch (num3 == num)
				{
				}
				num = (short)1692663809;
				if (num != 0)
				{
				}
				num = (short)646971392;
				if (num != 0)
				{
				}
				return this.dataProfilesTrunkingGroupID_ASTRO25DataGroupID_A36204.Editable;
			}
			set
			{
				short num = (short)1332477952;
				short num2 = num;
				num = (short)580873234;
				short num3 = num;
				num = (short)437677074;
				switch (num3 == num)
				{
				}
				num = (short)1491402752;
				if (num != 0)
				{
				}
				num = (short)1912340481;
				if (num != 0)
				{
				}
				this.dataProfilesTrunkingGroupID_ASTRO25DataGroupID_A36204.Editable = value;
			}
		}

		// Token: 0x170058EF RID: 22767
		// (get) Token: 0x0600B11B RID: 45339 RVA: 0x00A431A8 File Offset: 0x00A413A8
		internal string DataProfilesTrunkingGroupID_ASTRO25DataGroupID_A36204_UILabel
		{
			get
			{
				short num = (short)302317568;
				short num2 = num;
				num = (short)56393624;
				short num3 = num;
				num = (short)1230143384;
				switch (num3 == num)
				{
				}
				num = (short)1455423488;
				if (num != 0)
				{
				}
				num = (short)211288065;
				if (num != 0)
				{
				}
				return this.dataProfilesTrunkingGroupID_ASTRO25DataGroupID_A36204.UIName;
			}
		}

		// Token: 0x170058F0 RID: 22768
		// (get) Token: 0x0600B11C RID: 45340 RVA: 0x00A4325C File Offset: 0x00A4145C
		// (set) Token: 0x0600B11D RID: 45341 RVA: 0x00A43310 File Offset: 0x00A41510
		internal bool DataProfilesTrunkingGroupID_ASTRO25DataGroupID_A36204_HiddenStatic
		{
			get
			{
				short num = (short)1833893888;
				short num2 = num;
				num = (short)14286849;
				if (num != 0)
				{
				}
				num = (short)80087754;
				short num3 = num;
				num = (short)536545994;
				switch (num3 == num)
				{
				}
				num = (short)1514143744;
				if (num != 0)
				{
				}
				return this.dataProfilesTrunkingGroupID_ASTRO25DataGroupID_A36204.HiddenStatic;
			}
			set
			{
				short num = (short)432996352;
				short num2 = num;
				num = (short)2027742044;
				short num3 = num;
				num = (short)829154140;
				switch (num3 == num)
				{
				}
				num = (short)592510976;
				if (num != 0)
				{
				}
				num = (short)99483649;
				if (num != 0)
				{
				}
				this.dataProfilesTrunkingGroupID_ASTRO25DataGroupID_A36204.HiddenStatic = value;
			}
		}

		// Token: 0x170058F1 RID: 22769
		// (get) Token: 0x0600B11E RID: 45342 RVA: 0x00A433C4 File Offset: 0x00A415C4
		// (set) Token: 0x0600B11F RID: 45343 RVA: 0x00A4347C File Offset: 0x00A4167C
		internal bool DataProfilesTrunkingGroupID_ASTRO25DataGroupID_A36204_HiddenDynamic
		{
			get
			{
				short num = (short)1972502528;
				short num2 = num;
				num = (short)239433422;
				short num3 = num;
				num = (short)695236302;
				switch (num3 == num)
				{
				}
				num = (short)1496776705;
				if (num != 0)
				{
				}
				num = (short)49807360;
				if (num != 0)
				{
				}
				return this.dataProfilesTrunkingGroupID_ASTRO25DataGroupID_A36204.HiddenDynamic;
			}
			set
			{
				short num = (short)956159673;
				short num2 = num;
				num = (short)1953552057;
				switch (num2 == num)
				{
				}
				num = (short)1412169729;
				if (num != 0)
				{
				}
				num = (short)660733952;
				if (num != 0)
				{
				}
				num = (short)1806434304;
				short num3 = num;
				this.dataProfilesTrunkingGroupID_ASTRO25DataGroupID_A36204.HiddenDynamic = value;
			}
		}

		// Token: 0x170058F2 RID: 22770
		// (get) Token: 0x0600B120 RID: 45344 RVA: 0x00A43530 File Offset: 0x00A41730
		public bool DataProfilesTrunkingGroupID_ASTRO25DataGroupID_A36204_HasDiffs
		{
			get
			{
				short num = (short)1833238529;
				if (num != 0)
				{
				}
				num = (short)936850123;
				short num2 = num;
				num = (short)814691019;
				switch (num2 == num)
				{
				}
				num = (short)1686503424;
				if (num != 0)
				{
				}
				num = (short)731316224;
				short num3 = num;
				return this.dataProfilesTrunkingGroupID_ASTRO25DataGroupID_A36204._HasDiffs;
			}
		}

		// Token: 0x0600B121 RID: 45345 RVA: 0x00A435E4 File Offset: 0x00A417E4
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
					num2 = (short)202637313;
					if (num2 != 0)
					{
					}
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)1347298128;
					short num3 = num2;
					num2 = (short)1362764624;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_122;
					default:
						num2 = (short)1375862784;
						if (num2 != 0)
						{
						}
						num2 = (short)1755316225;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
					return result;
				case 2:
					num2 = (short)1479081987;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					if (base.ParentRecset.ContainerDoc != null)
					{
						goto IL_122;
					}
					return result;
				case 4:
					if (base.ParentRecset != null)
					{
						num2 = (short)1329659906;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				goto IL_24;
				IL_122:
				num2 = (short)2100625408;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)52166656;
			short num4 = num2;
			num2 = (short)1493893124;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x040053F7 RID: 21495
		private global::AcpBusinessLayer.AcpSimpleRangeField dataProfilesTrunkingGroupID_ASTRO25DataGroupID_A36204;
	}
}
