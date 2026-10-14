using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using Motorola.MackinawCPS.CoreFeatures.ActionConsolidation;

namespace Motorola.MackinawCPS.CoreFeatures.PersonnelAccountability
{
	// Token: 0x0200024A RID: 586
	[global::System.Serializable]
	public class PerAccListTableInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600687E RID: 26750 RVA: 0x005D8230 File Offset: 0x005D6430
		public PerAccListTableInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x0600687F RID: 26751 RVA: 0x005D824C File Offset: 0x005D644C
		protected PerAccListTableInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06006880 RID: 26752 RVA: 0x005D8264 File Offset: 0x005D6464
		public override void Init()
		{
			int a_ = 8;
			short num = (short)1731099834;
			short num2 = num;
			num = (short)1252490426;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1978335232;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)159318017;
			if (num != 0)
			{
			}
			num = (short)158990336;
			if (num != 0)
			{
			}
			this.radioErgoConfigACReference_A42911 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("鯈꫊꧌ꛎ뻐雒꟔냖뛘飚닜뇞蟠諢苤ꛦꫨ맪裬觮铰臲郴駶髸黺ꋼ뻾㔀㄂㰄㘆㠈", a_), global::CommonResources.AcgResources.ID_ACLISTSELECTION, new string[]
			{
				global::CommonResources.AcgResources.ID_DISABLED
			}, new int[1], true, false);
			this.radioErgoConfigACReference_A42911.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radioErgoConfigACReference_A42911.DataTransferOrder = 12;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("駈껊뿌볎뻐뷒믔닖뗘ﯚ鳜볞苠賢郤触鷨諪迬蛮鷰髲致軶\ud9f8럺铼賾甀", a_);
			base.Id = 10814;
			base.UIName = global::CommonResources.AcgResources.ID_PERSONNELACCOUNTABILITYLIST;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06006881 RID: 26753 RVA: 0x005D8394 File Offset: 0x005D6594
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 3;
			short num = (short)353959939;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					this.radioErgoConfigACReference_A42911 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("雃Ʂ곇ꏉꏋ词ꋏ뗑믓闕럗듙뫛럝蟟ꏡ꟣듥跧賩觫鳭闯鳱音鏵ꟷ믹죻쳽㧿㌁㔃", a_), global::CommonResources.AcgResources.ID_ACLISTSELECTION, new string[]
					{
						global::CommonResources.AcgResources.ID_DISABLED
					}, new int[1], true, false);
					this.radioErgoConfigACReference_A42911.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radioErgoConfigACReference_A42911.DataTransferOrder = 12;
					num = (short)1001127938;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
				{
					num = (short)156330432;
					short num3 = num;
					num = (short)86862272;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_54;
					default:
						num = (short)787415040;
						if (num != 0)
						{
						}
						if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("雃Ʂ곇ꏉꏋ词ꋏ뗑믓闕럗듙뫛럝蟟ꏡ꟣듥跧賩觫鳭闯鳱音鏵ꟷ믹죻쳽㧿㌁㔃", a_)))
						{
							num = (short)1432551424;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1F4;
					}
					break;
				}
				case 2:
					goto IL_D4;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_4A;
					}
					continue;
				case 4:
				{
					num = (short)1479999489;
					if (num != 0)
					{
					}
					num = (short)623902720;
					short num4 = num;
					num = (short)1493893121;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 5:
					num = (short)693829638;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					if (producerFields != null)
					{
						num = (short)369360900;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1F4;
				}
				goto IL_4A;
				IL_54:
				num = (short)789643269;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_4A:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					goto IL_54;
				}
				break;
			}
			IL_D4:
			IL_1F4:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("铃ꏅ뫇막ꏋꃍ뻏럑룓駗맙뿛뇝闟賡郣蟥諧菩胫蟭蓯诱퓳뫵釷觹裻", a_);
			base.Id = 10814;
			base.UIName = global::CommonResources.AcgResources.ID_PERSONNELACCOUNTABILITYLIST;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06006882 RID: 26754 RVA: 0x005D85C8 File Offset: 0x005D67C8
		public override void PopulateReferences()
		{
			short num = (short)1451138891;
			short num2 = num;
			num = (short)1372888907;
			switch (num2 == num)
			{
			default:
			{
				num = (short)350289920;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1495597057;
			if (num != 0)
			{
			}
			num = (short)1325268992;
			if (num != 0)
			{
			}
			this.radioErgoConfigACReference_A42911.SetRecset(this.a(4008));
		}

		// Token: 0x06006883 RID: 26755 RVA: 0x005D8688 File Offset: 0x005D6888
		public override void DropReferences()
		{
			short num = (short)2094306896;
			short num2 = num;
			num = (short)256022096;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1510014976;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)113967105;
			if (num != 0)
			{
			}
			num = (short)555548672;
			if (num != 0)
			{
			}
		}

		// Token: 0x06006884 RID: 26756 RVA: 0x005D8730 File Offset: 0x005D6930
		public override void SetConstraints()
		{
			short num = (short)541449270;
			short num2 = num;
			num = (short)1425792054;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1080295424;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1455947777;
			if (num != 0)
			{
			}
			num = (short)2050883584;
			if (num != 0)
			{
			}
			this.radioErgoConfigACReference_A42911.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.PersonnelAccountability.PersonnelAccountabilityConstraints.ConACListSelectionIsIndex);
		}

		// Token: 0x06006885 RID: 26757 RVA: 0x005D87F0 File Offset: 0x005D69F0
		public override void SetupDependencies()
		{
			short num = (short)1286092306;
			short num2 = num;
			num = (short)1095185938;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1672151040;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)936706049;
			if (num != 0)
			{
			}
			num = (short)1195835392;
			if (num != 0)
			{
			}
		}

		// Token: 0x17003629 RID: 13865
		// (get) Token: 0x06006886 RID: 26758 RVA: 0x005D8898 File Offset: 0x005D6A98
		public global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidation ActionConsolidationForRadioErgoConfigACReference_A42911
		{
			get
			{
				short num = (short)955231270;
				short num2 = num;
				num = (short)1023061030;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1845821440;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1035468801;
				if (num != 0)
				{
				}
				num = (short)183631872;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACReference_A42911.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidation;
			}
		}

		// Token: 0x1700362A RID: 13866
		// (get) Token: 0x06006887 RID: 26759 RVA: 0x005D8950 File Offset: 0x005D6B50
		public bool HasDiffs
		{
			get
			{
				short num = (short)223497759;
				short num2 = num;
				num = (short)1326796319;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2037972992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1774977024;
				if (num != 0)
				{
				}
				num = (short)1102512129;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x1700362B RID: 13867
		// (get) Token: 0x06006888 RID: 26760 RVA: 0x005D8A00 File Offset: 0x005D6C00
		// (set) Token: 0x06006889 RID: 26761 RVA: 0x005D8AB8 File Offset: 0x005D6CB8
		public int RadioErgoConfigACReference_A42911Value
		{
			get
			{
				short num = (short)2090620120;
				short num2 = num;
				num = (short)1336366296;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2059599872;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1552678913;
				if (num != 0)
				{
				}
				num = (short)412483584;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACReference_A42911.Value;
			}
			set
			{
				short num = (short)886523257;
				short num2 = num;
				num = (short)744113529;
				switch (num2 == num)
				{
				default:
				{
					num = (short)806617088;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)469237761;
				if (num != 0)
				{
				}
				num = (short)159842304;
				if (num != 0)
				{
				}
				this.radioErgoConfigACReference_A42911.Value = value;
			}
		}

		// Token: 0x1700362C RID: 13868
		// (get) Token: 0x0600688A RID: 26762 RVA: 0x005D8B6C File Offset: 0x005D6D6C
		// (set) Token: 0x0600688B RID: 26763 RVA: 0x005D8C24 File Offset: 0x005D6E24
		public string RadioErgoConfigACReference_A42911_UIValue
		{
			get
			{
				short num = (short)589990031;
				short num2 = num;
				num = (short)706840719;
				switch (num2 == num)
				{
				default:
				{
					num = (short)739770368;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)254148608;
				if (num != 0)
				{
				}
				num = (short)1244725249;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACReference_A42911.UIValue;
			}
			set
			{
				short num = (short)1785624147;
				short num2 = num;
				num = (short)1170765395;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1499136000;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1852768257;
				if (num != 0)
				{
				}
				num = (short)1252786176;
				if (num != 0)
				{
				}
				this.radioErgoConfigACReference_A42911.UIValue = value;
			}
		}

		// Token: 0x1700362D RID: 13869
		// (get) Token: 0x0600688C RID: 26764 RVA: 0x005D8CDC File Offset: 0x005D6EDC
		public global::AcpBusinessLayer.AcpRecRefField RadioErgoConfigACReference_A42911
		{
			get
			{
				short num = (short)1297713952;
				short num2 = num;
				num = (short)652512032;
				switch (num2 == num)
				{
				default:
				{
					num = (short)978190336;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)954400768;
				if (num != 0)
				{
				}
				num = (short)699006977;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACReference_A42911;
			}
		}

		// Token: 0x1700362E RID: 13870
		// (get) Token: 0x0600688D RID: 26765 RVA: 0x005D8D8C File Offset: 0x005D6F8C
		// (set) Token: 0x0600688E RID: 26766 RVA: 0x005D8E44 File Offset: 0x005D7044
		public bool RadioErgoConfigACReference_A42911_Applicable
		{
			get
			{
				short num = (short)1251310701;
				short num2 = num;
				num = (short)1737522285;
				switch (num2 == num)
				{
				default:
				{
					num = (short)976486400;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1648558081;
				if (num != 0)
				{
				}
				num = (short)1960443904;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACReference_A42911.Applicable;
			}
			set
			{
				short num = (short)1699369966;
				short num2 = num;
				num = (short)2035831790;
				switch (num2 == num)
				{
				default:
				{
					num = (short)637665280;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1797849089;
				if (num != 0)
				{
				}
				num = (short)587857920;
				if (num != 0)
				{
				}
				this.radioErgoConfigACReference_A42911.Applicable = value;
			}
		}

		// Token: 0x1700362F RID: 13871
		// (get) Token: 0x0600688F RID: 26767 RVA: 0x005D8EFC File Offset: 0x005D70FC
		// (set) Token: 0x06006890 RID: 26768 RVA: 0x005D8FB0 File Offset: 0x005D71B0
		public bool RadioErgoConfigACReference_A42911_Valid
		{
			get
			{
				short num = (short)418400738;
				short num2 = num;
				num = (short)1201228258;
				switch (num2 == num)
				{
				default:
				{
					num = (short)458752;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1134100480;
				if (num != 0)
				{
				}
				num = (short)1128005633;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACReference_A42911.Valid;
			}
			set
			{
				short num = (short)558154952;
				short num2 = num;
				num = (short)89244872;
				switch (num2 == num)
				{
				default:
				{
					num = (short)657784832;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)326041601;
				if (num != 0)
				{
				}
				num = (short)1264582656;
				if (num != 0)
				{
				}
				this.radioErgoConfigACReference_A42911.Valid = value;
			}
		}

		// Token: 0x17003630 RID: 13872
		// (get) Token: 0x06006891 RID: 26769 RVA: 0x005D9064 File Offset: 0x005D7264
		// (set) Token: 0x06006892 RID: 26770 RVA: 0x005D911C File Offset: 0x005D731C
		public bool RadioErgoConfigACReference_A42911_Visible
		{
			get
			{
				short num = (short)148671521;
				short num2 = num;
				num = (short)2087291937;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1808400384;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1945042945;
				if (num != 0)
				{
				}
				num = (short)582877184;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACReference_A42911.Visible;
			}
			set
			{
				short num = (short)1338016492;
				short num2 = num;
				num = (short)1655276268;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1773797376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)715653121;
				if (num != 0)
				{
				}
				num = (short)1236664320;
				if (num != 0)
				{
				}
				this.radioErgoConfigACReference_A42911.Visible = value;
			}
		}

		// Token: 0x17003631 RID: 13873
		// (get) Token: 0x06006893 RID: 26771 RVA: 0x005D91D4 File Offset: 0x005D73D4
		// (set) Token: 0x06006894 RID: 26772 RVA: 0x005D9288 File Offset: 0x005D7488
		public bool RadioErgoConfigACReference_A42911_Editable
		{
			get
			{
				short num = (short)496274373;
				short num2 = num;
				num = (short)1652394949;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1507721216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1896022017;
				if (num != 0)
				{
				}
				num = (short)1816920064;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACReference_A42911.Editable;
			}
			set
			{
				short num = (short)1785464850;
				short num2 = num;
				num = (short)976488466;
				switch (num2 == num)
				{
				default:
				{
					num = (short)422641664;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1879900161;
				if (num != 0)
				{
				}
				num = (short)530317312;
				if (num != 0)
				{
				}
				this.radioErgoConfigACReference_A42911.Editable = value;
			}
		}

		// Token: 0x17003632 RID: 13874
		// (get) Token: 0x06006895 RID: 26773 RVA: 0x005D9340 File Offset: 0x005D7540
		internal string RadioErgoConfigACReference_A42911_UILabel
		{
			get
			{
				short num = (short)796772273;
				short num2 = num;
				num = (short)377735089;
				switch (num2 == num)
				{
				default:
				{
					num = (short)509870080;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)344915969;
				if (num != 0)
				{
				}
				num = (short)218038272;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACReference_A42911.UIName;
			}
		}

		// Token: 0x17003633 RID: 13875
		// (get) Token: 0x06006896 RID: 26774 RVA: 0x005D93F4 File Offset: 0x005D75F4
		// (set) Token: 0x06006897 RID: 26775 RVA: 0x005D94A8 File Offset: 0x005D76A8
		internal bool RadioErgoConfigACReference_A42911_HiddenStatic
		{
			get
			{
				short num = (short)1652785746;
				short num2 = num;
				num = (short)723550802;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1475477504;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1823735809;
				if (num != 0)
				{
				}
				num = (short)960954368;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACReference_A42911.HiddenStatic;
			}
			set
			{
				short num = (short)762201073;
				short num2 = num;
				num = (short)2089829361;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1217265664;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)212402177;
				if (num != 0)
				{
				}
				num = (short)1078525952;
				if (num != 0)
				{
				}
				this.radioErgoConfigACReference_A42911.HiddenStatic = value;
			}
		}

		// Token: 0x17003634 RID: 13876
		// (get) Token: 0x06006898 RID: 26776 RVA: 0x005D955C File Offset: 0x005D775C
		// (set) Token: 0x06006899 RID: 26777 RVA: 0x005D9610 File Offset: 0x005D7810
		internal bool RadioErgoConfigACReference_A42911_HiddenDynamic
		{
			get
			{
				short num = (short)2071821373;
				short num2 = num;
				num = (short)1477409853;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1530855424;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1429536768;
				if (num != 0)
				{
				}
				num = (short)798556161;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACReference_A42911.HiddenDynamic;
			}
			set
			{
				short num = (short)1553358523;
				short num2 = num;
				num = (short)1067146939;
				switch (num2 == num)
				{
				default:
				{
					num = (short)908722176;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1257504768;
				if (num != 0)
				{
				}
				num = (short)841482241;
				if (num != 0)
				{
				}
				this.radioErgoConfigACReference_A42911.HiddenDynamic = value;
			}
		}

		// Token: 0x17003635 RID: 13877
		// (get) Token: 0x0600689A RID: 26778 RVA: 0x005D96C4 File Offset: 0x005D78C4
		public bool RadioErgoConfigACReference_A42911_HasDiffs
		{
			get
			{
				short num = (short)1824749339;
				short num2 = num;
				num = (short)701986587;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1000341504;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)702611457;
				if (num != 0)
				{
				}
				num = (short)1294139392;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACReference_A42911._HasDiffs;
			}
		}

		// Token: 0x0600689B RID: 26779 RVA: 0x005D9778 File Offset: 0x005D7978
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
					num2 = (short)1081081860;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_FF;
				case 2:
				{
					num2 = (short)337522377;
					short num3 = num2;
					num2 = (short)1425092297;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)916062208;
						if (num2 != 0)
						{
						}
						result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
						break;
					}
					num2 = (short)519831553;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
					if (base.ParentRecset != null)
					{
						num2 = (short)1817378816;
						short num4 = num2;
						num2 = (short)1676148736;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 4:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)239403010;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				goto IL_24;
			}
			IL_FF:
			num2 = (short)1899429889;
			if (num2 != 0)
			{
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)1414987779;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04002917 RID: 10519
		private global::AcpBusinessLayer.AcpRecRefField radioErgoConfigACReference_A42911;
	}
}
