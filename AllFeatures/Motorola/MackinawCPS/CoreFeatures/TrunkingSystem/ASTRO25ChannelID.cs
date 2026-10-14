using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.TrunkingSystem
{
	// Token: 0x02000063 RID: 99
	[global::System.Serializable]
	public class ASTRO25ChannelID : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06000836 RID: 2102 RVA: 0x0007F898 File Offset: 0x0007DA98
		public ASTRO25ChannelID(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO25ChannelIDInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x06000837 RID: 2103 RVA: 0x0007F8D8 File Offset: 0x0007DAD8
		protected ASTRO25ChannelID(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06000838 RID: 2104 RVA: 0x0007F8F0 File Offset: 0x0007DAF0
		public override void Init()
		{
			int a_ = 10;
			short num = (short)185535008;
			short num2 = num;
			num = (short)175573536;
			switch (num2 == num)
			{
			}
			num = (short)1803157505;
			if (num != 0)
			{
			}
			num = (short)1595146240;
			if (num != 0)
			{
			}
			num = (short)1510932480;
			short num3 = num;
			this.trkSysLTEInterferingFreqPresent_A42198 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鿊뿌꓎苐꫒ꛔ鯖跘黚铜뇞闠蛢韤臦賨駪蓬臮雰뗲蟴鋶裸꯺迼髾爀昂欄猆嘈䨊㤌㴎‐⨒ⴔ", a_), global::CommonResources.AcgResources.ID_LTEINTERFERENCEFREQPRESENT);
			this.trkSysLTEInterferingFreqPresent_A42198.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.trkSysLTEInterferingFreqPresent_A42198.DataTransferOrder = 125;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("諊黌鯎菐鳒ﯚ黜럞胠跢诤苦藨쯪ꓬ꯮", a_);
			base.Id = 10160;
			base.UIName = global::CommonResources.AcgResources.ID_ASTRO25CHANNELID;
			base.DataTransferOrder = 2;
		}

		// Token: 0x06000839 RID: 2105 RVA: 0x0007FA10 File Offset: 0x0007DC10
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 5;
			short num = (short)1498152964;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鋅뫇ꇉ鿋럍ꏏ黑胓鏕釗듙꣛믝鋟蓡臣铥臧蓩诫꣭苯韱藳꛵諷鿹迻鯽滿瘁嬃䜅㰇㠉㴋㜍⠏", a_)))
					{
						num = (short)1074659333;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1E0;
				case 1:
					num = (short)10092544;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
				{
					num = (short)500179455;
					short num3 = num;
					num = (short)1462182399;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num = (short)563216385;
						if (num != 0)
						{
						}
						num = (short)626196480;
						if (num != 0)
						{
						}
						num = (short)1251213318;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 3:
					goto IL_E7;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_49;
					}
					continue;
				case 5:
					this.trkSysLTEInterferingFreqPresent_A42198 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鋅뫇ꇉ鿋럍ꏏ黑胓鏕釗듙꣛믝鋟蓡臣铥臧蓩诫꣭苯韱藳꛵諷鿹迻鯽滿瘁嬃䜅㰇㠉㴋㜍⠏", a_), global::CommonResources.AcgResources.ID_LTEINTERFERENCEFREQPRESENT);
					this.trkSysLTEInterferingFreqPresent_A42198.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.trkSysLTEInterferingFreqPresent_A42198.DataTransferOrder = 125;
					num = (short)631242755;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					if (producerFields != null)
					{
						num = (short)1227161601;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1E0;
				}
				IL_49:
				num = (short)406257664;
				short num4 = num;
				if (!global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					break;
				}
				num = (short)2044133378;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_E7:
			IL_1E0:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("蟅鯇黉黋臍鯗닙뷛냝軟蟡裣웥ꇧ껩", a_);
			base.Id = 10160;
			base.UIName = global::CommonResources.AcgResources.ID_ASTRO25CHANNELID;
			base.DataTransferOrder = 2;
		}

		// Token: 0x0600083A RID: 2106 RVA: 0x0007FC30 File Offset: 0x0007DE30
		public override void PopulateReferences()
		{
			short num = (short)968853598;
			short num2 = num;
			num = (short)91129950;
			switch (num2 == num)
			{
			}
			num = (short)1154220032;
			if (num != 0)
			{
			}
			num = (short)1666777089;
			if (num != 0)
			{
			}
			num = (short)311885824;
			short num3 = num;
		}

		// Token: 0x0600083B RID: 2107 RVA: 0x0007FCD8 File Offset: 0x0007DED8
		public override void DropReferences()
		{
			short num = (short)389832598;
			short num2 = num;
			num = (short)1348689814;
			switch (num2 == num)
			{
			}
			num = (short)459931649;
			if (num != 0)
			{
			}
			num = (short)1069154304;
			if (num != 0)
			{
			}
			num = (short)1886453760;
			short num3 = num;
		}

		// Token: 0x0600083C RID: 2108 RVA: 0x0007FD84 File Offset: 0x0007DF84
		public override void SetConstraints()
		{
			short num = (short)1803255556;
			short num2 = num;
			num = (short)477265668;
			switch (num2 == num)
			{
			}
			num = (short)1701249025;
			if (num != 0)
			{
			}
			num = (short)710213632;
			if (num != 0)
			{
			}
			num = (short)126746624;
			short num3 = num;
			this.trkSysLTEInterferingFreqPresent_A42198.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
		}

		// Token: 0x0600083D RID: 2109 RVA: 0x0007FE48 File Offset: 0x0007E048
		public override void SetupDependencies()
		{
			short num = (short)1029593770;
			short num2 = num;
			num = (short)498490026;
			switch (num2 == num)
			{
			}
			num = (short)1741684737;
			if (num != 0)
			{
			}
			num = (short)1189543936;
			if (num != 0)
			{
			}
			num = (short)197394432;
			short num3 = num;
		}

		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x0600083E RID: 2110 RVA: 0x0007FEF0 File Offset: 0x0007E0F0
		public bool HasDiffs
		{
			get
			{
				short num = (short)1147610256;
				short num2 = num;
				num = (short)1613898896;
				switch (num2 == num)
				{
				}
				num = (short)1480720384;
				if (num != 0)
				{
				}
				num = (short)92143617;
				if (num != 0)
				{
				}
				num = (short)1522335744;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x0600083F RID: 2111 RVA: 0x0007FFA0 File Offset: 0x0007E1A0
		// (set) Token: 0x06000840 RID: 2112 RVA: 0x00080054 File Offset: 0x0007E254
		public bool TrkSysLTEInterferingFreqPresent_A42198Value
		{
			get
			{
				short num = (short)1061264137;
				short num2 = num;
				num = (short)994810633;
				switch (num2 == num)
				{
				}
				num = (short)1235025921;
				if (num != 0)
				{
				}
				num = (short)25034752;
				if (num != 0)
				{
				}
				num = (short)1242234880;
				short num3 = num;
				return this.trkSysLTEInterferingFreqPresent_A42198.Value;
			}
			set
			{
				short num = (short)722862081;
				if (num != 0)
				{
				}
				num = (short)718599025;
				short num2 = num;
				num = (short)1636561777;
				switch (num2 == num)
				{
				}
				num = (short)1460600832;
				short num3 = num;
				num = (short)1613561856;
				if (num != 0)
				{
				}
				this.trkSysLTEInterferingFreqPresent_A42198.Value = value;
			}
		}

		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x06000841 RID: 2113 RVA: 0x00080108 File Offset: 0x0007E308
		public global::AcpBusinessLayer.AcpField<bool> TrkSysLTEInterferingFreqPresent_A42198
		{
			get
			{
				short num = (short)164223103;
				short num2 = num;
				num = (short)1719523455;
				switch (num2 == num)
				{
				}
				num = (short)357040129;
				if (num != 0)
				{
				}
				num = (short)2139750400;
				short num3 = num;
				num = (short)2144993280;
				if (num != 0)
				{
				}
				return this.trkSysLTEInterferingFreqPresent_A42198;
			}
		}

		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x06000842 RID: 2114 RVA: 0x000801B8 File Offset: 0x0007E3B8
		// (set) Token: 0x06000843 RID: 2115 RVA: 0x0008026C File Offset: 0x0007E46C
		public bool TrkSysLTEInterferingFreqPresent_A42198_UIValue
		{
			get
			{
				short num = (short)1058766554;
				short num2 = num;
				num = (short)1281851098;
				switch (num2 == num)
				{
				}
				num = (short)415629312;
				if (num != 0)
				{
				}
				num = (short)540409856;
				short num3 = num;
				num = (short)144900097;
				if (num != 0)
				{
				}
				return this.trkSysLTEInterferingFreqPresent_A42198.Value;
			}
			set
			{
				short num = (short)865174542;
				short num2 = num;
				num = (short)711623694;
				switch (num2 == num)
				{
				}
				num = (short)573636609;
				if (num != 0)
				{
				}
				num = (short)602144768;
				short num3 = num;
				num = (short)1128333312;
				if (num != 0)
				{
				}
				this.trkSysLTEInterferingFreqPresent_A42198.Value = value;
			}
		}

		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x06000844 RID: 2116 RVA: 0x00080324 File Offset: 0x0007E524
		// (set) Token: 0x06000845 RID: 2117 RVA: 0x000803DC File Offset: 0x0007E5DC
		public bool TrkSysLTEInterferingFreqPresent_A42198_Applicable
		{
			get
			{
				short num = (short)1354994277;
				short num2 = num;
				num = (short)1722716773;
				switch (num2 == num)
				{
				}
				num = (short)184221697;
				if (num != 0)
				{
				}
				num = (short)466812928;
				short num3 = num;
				num = (short)766312448;
				if (num != 0)
				{
				}
				return this.trkSysLTEInterferingFreqPresent_A42198.Applicable;
			}
			set
			{
				short num = (short)247085576;
				short num2 = num;
				num = (short)1475164680;
				switch (num2 == num)
				{
				}
				num = (short)728629249;
				if (num != 0)
				{
				}
				num = (short)1440415744;
				short num3 = num;
				num = (short)1995440128;
				if (num != 0)
				{
				}
				this.trkSysLTEInterferingFreqPresent_A42198.Applicable = value;
			}
		}

		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x06000846 RID: 2118 RVA: 0x00080490 File Offset: 0x0007E690
		// (set) Token: 0x06000847 RID: 2119 RVA: 0x00080548 File Offset: 0x0007E748
		public bool TrkSysLTEInterferingFreqPresent_A42198_Valid
		{
			get
			{
				short num = (short)623514222;
				short num2 = num;
				num = (short)412422766;
				switch (num2 == num)
				{
				}
				num = (short)2101149697;
				if (num != 0)
				{
				}
				num = (short)542310400;
				short num3 = num;
				num = (short)503382016;
				if (num != 0)
				{
				}
				return this.trkSysLTEInterferingFreqPresent_A42198.Valid;
			}
			set
			{
				short num = (short)426846110;
				short num2 = num;
				num = (short)1944856478;
				switch (num2 == num)
				{
				}
				num = (short)2009661441;
				if (num != 0)
				{
				}
				num = (short)352714752;
				short num3 = num;
				num = (short)1191313408;
				if (num != 0)
				{
				}
				this.trkSysLTEInterferingFreqPresent_A42198.Valid = value;
			}
		}

		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x06000848 RID: 2120 RVA: 0x00080600 File Offset: 0x0007E800
		// (set) Token: 0x06000849 RID: 2121 RVA: 0x000806B4 File Offset: 0x0007E8B4
		public bool TrkSysLTEInterferingFreqPresent_A42198_Visible
		{
			get
			{
				short num = (short)924127581;
				short num2 = num;
				num = (short)2067665245;
				switch (num2 == num)
				{
				}
				num = (short)849870849;
				if (num != 0)
				{
				}
				num = (short)1691222016;
				short num3 = num;
				num = (short)183238656;
				if (num != 0)
				{
				}
				return this.trkSysLTEInterferingFreqPresent_A42198.Visible;
			}
			set
			{
				short num = (short)1061133381;
				short num2 = num;
				num = (short)299146309;
				switch (num2 == num)
				{
				}
				num = (short)1427767297;
				if (num != 0)
				{
				}
				num = (short)279576576;
				short num3 = num;
				num = (short)808714240;
				if (num != 0)
				{
				}
				this.trkSysLTEInterferingFreqPresent_A42198.Visible = value;
			}
		}

		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x0600084A RID: 2122 RVA: 0x00080768 File Offset: 0x0007E968
		// (set) Token: 0x0600084B RID: 2123 RVA: 0x0008081C File Offset: 0x0007EA1C
		public bool TrkSysLTEInterferingFreqPresent_A42198_Editable
		{
			get
			{
				short num = (short)1194812646;
				short num2 = num;
				num = (short)726230246;
				switch (num2 == num)
				{
				}
				num = (short)663158784;
				if (num != 0)
				{
				}
				num = (short)444006400;
				short num3 = num;
				num = (short)1331757057;
				if (num != 0)
				{
				}
				return this.trkSysLTEInterferingFreqPresent_A42198.Editable;
			}
			set
			{
				short num = (short)584450049;
				if (num != 0)
				{
				}
				num = (short)2019789801;
				short num2 = num;
				num = (short)1343065065;
				switch (num2 == num)
				{
				}
				num = (short)1544421376;
				short num3 = num;
				num = (short)205193216;
				if (num != 0)
				{
				}
				this.trkSysLTEInterferingFreqPresent_A42198.Editable = value;
			}
		}

		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x0600084C RID: 2124 RVA: 0x000808D4 File Offset: 0x0007EAD4
		internal string TrkSysLTEInterferingFreqPresent_A42198_UILabel
		{
			get
			{
				short num = (short)478772941;
				short num2 = num;
				num = (short)1098153677;
				switch (num2 == num)
				{
				}
				num = (short)632750081;
				if (num != 0)
				{
				}
				num = (short)1839595520;
				short num3 = num;
				num = (short)1691353088;
				if (num != 0)
				{
				}
				return this.trkSysLTEInterferingFreqPresent_A42198.UIName;
			}
		}

		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x0600084D RID: 2125 RVA: 0x00080988 File Offset: 0x0007EB88
		// (set) Token: 0x0600084E RID: 2126 RVA: 0x00080A3C File Offset: 0x0007EC3C
		internal bool TrkSysLTEInterferingFreqPresent_A42198_HiddenStatic
		{
			get
			{
				short num = (short)645791745;
				if (num != 0)
				{
				}
				num = (short)168138399;
				short num2 = num;
				num = (short)1289066143;
				switch (num2 == num)
				{
				}
				num = (short)749207552;
				short num3 = num;
				num = (short)1085865984;
				if (num != 0)
				{
				}
				return this.trkSysLTEInterferingFreqPresent_A42198.HiddenStatic;
			}
			set
			{
				short num = (short)897796230;
				short num2 = num;
				num = (short)2091206790;
				switch (num2 == num)
				{
				}
				num = (short)418054144;
				if (num != 0)
				{
				}
				num = (short)478412800;
				short num3 = num;
				num = (short)1245118465;
				if (num != 0)
				{
				}
				this.trkSysLTEInterferingFreqPresent_A42198.HiddenStatic = value;
			}
		}

		// Token: 0x17000407 RID: 1031
		// (get) Token: 0x0600084F RID: 2127 RVA: 0x00080AF0 File Offset: 0x0007ECF0
		// (set) Token: 0x06000850 RID: 2128 RVA: 0x00080BA4 File Offset: 0x0007EDA4
		internal bool TrkSysLTEInterferingFreqPresent_A42198_HiddenDynamic
		{
			get
			{
				short num = (short)940976676;
				short num2 = num;
				num = (short)639183396;
				switch (num2 == num)
				{
				}
				num = (short)1452015616;
				if (num != 0)
				{
				}
				num = (short)290979840;
				short num3 = num;
				num = (short)372834305;
				if (num != 0)
				{
				}
				return this.trkSysLTEInterferingFreqPresent_A42198.HiddenDynamic;
			}
			set
			{
				short num = (short)1500530881;
				short num2 = num;
				num = (short)942098625;
				switch (num2 == num)
				{
				}
				num = (short)2014904321;
				if (num != 0)
				{
				}
				num = (short)527171584;
				short num3 = num;
				num = (short)686096384;
				if (num != 0)
				{
				}
				this.trkSysLTEInterferingFreqPresent_A42198.HiddenDynamic = value;
			}
		}

		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x06000851 RID: 2129 RVA: 0x00080C54 File Offset: 0x0007EE54
		public bool TrkSysLTEInterferingFreqPresent_A42198_HasDiffs
		{
			get
			{
				short num = (short)2135182927;
				short num2 = num;
				num = (short)1601850959;
				switch (num2 == num)
				{
				}
				num = (short)1654194176;
				if (num != 0)
				{
				}
				num = (short)581369856;
				short num3 = num;
				num = (short)425984001;
				if (num != 0)
				{
				}
				return this.trkSysLTEInterferingFreqPresent_A42198._HasDiffs;
			}
		}

		// Token: 0x06000852 RID: 2130 RVA: 0x00080D08 File Offset: 0x0007EF08
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
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)406257666;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 1:
					return result;
				case 2:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)821035009;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
				{
					num2 = (short)257450022;
					short num3 = num2;
					num2 = (short)2097176614;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return result;
					default:
					{
						num2 = (short)809631744;
						if (num2 != 0)
						{
						}
						num2 = (short)1491337216;
						short num4 = num2;
						num2 = (short)1733754880;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 4:
					num2 = (short)174915585;
					if (num2 != 0)
					{
					}
					if (base.ParentRecset != null)
					{
						num2 = (short)614596611;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				goto IL_24;
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)660996100;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04000324 RID: 804
		private global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO25ChannelIDInnerRecset innerRecset;

		// Token: 0x04000325 RID: 805
		private global::AcpBusinessLayer.AcpField<bool> trkSysLTEInterferingFreqPresent_A42198;
	}
}
