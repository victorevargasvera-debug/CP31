using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using ConstraintHelper;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO7
{
	// Token: 0x020003A7 RID: 935
	[global::System.Serializable]
	public class O7NavigationControlsTableInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600883D RID: 34877 RVA: 0x007EC3F4 File Offset: 0x007EA5F4
		public O7NavigationControlsTableInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x0600883E RID: 34878 RVA: 0x007EC410 File Offset: 0x007EA610
		protected O7NavigationControlsTableInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600883F RID: 34879 RVA: 0x007EC428 File Offset: 0x007EA628
		public override void Init()
		{
			int a_ = 5;
			short num = (short)2137435591;
			short num2 = num;
			num = (short)46050759;
			switch (num2 == num)
			{
			default:
			{
				num = (short)50790400;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)756678656;
			if (num != 0)
			{
			}
			num = (short)1752039425;
			if (num != 0)
			{
			}
			this.o7UpDownButtonName_A41292 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_UPBUTTON, this, global::AllFeatures.CodeplugGuid.b("觅ￇ鿉볋諍뿏ꗑ뫓铕귗껙꣛뇝軟곡藣该跧뗩귫\udaed쇯샱췳쓵", a_), global::CommonResources.AcgResources.ID_NAME, 100);
			this.o7UpDownButtonName_A41292.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.o7UpDownButtonName_A41292.DataTransferOrder = -1;
			this.radErgoControlO7UpDownButton_A41293 = new global::AcpBusinessLayer.AcpSparseLOVField(143, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.LOVs.indexRadErgoControlO7UpDownButton_A41293LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.LOVs.idRadErgoControlO7UpDownButton_A41293LovStrs), this, global::AllFeatures.CodeplugGuid.b("铅꧇껉觋볍럏뷑韓맕뛗껙껛뇝賟귡폣돥飧껩菫駭黯냱至苵賷闹鋻ꇽ䇿㘁㔃㐅ㄇ㤉", a_), global::CommonResources.AcgResources.ID_FEATURE, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.LOVs.RadErgoControlO7UpDownButton_A41293LovStrs);
			this.radErgoControlO7UpDownButton_A41293.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgoControlO7UpDownButton_A41293.DataTransferOrder = 1;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("装꧇볉ꗋ꧍뇏ꛑ뷓맕뛗龎鿛뇝軟雡難觥蓧駩", a_);
			base.Id = 10728;
			base.UIName = global::CommonResources.AcgResources.ID_NAVIGATIONCONTROLS;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06008840 RID: 34880 RVA: 0x007EC59C File Offset: 0x007EA79C
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 14;
			short num = (short)1978793993;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)324403201;
					if (num != 0)
					{
					}
					num = (short)736559111;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_A1;
				case 2:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("胎蛒ꗔ鏖뛘곚돜鷞铠韢釤裦蟨ꗪ賬苮铰곲듴쏶죸짺쓼췾", a_)))
					{
						num = (short)913440776;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A1;
				case 3:
					goto IL_234;
				case 4:
				{
					num = (short)1889219352;
					short num3 = num;
					num = (short)1845506840;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_177;
					default:
						num = (short)1016791040;
						if (num != 0)
						{
						}
						this.radErgoControlO7UpDownButton_A41293 = new global::AcpBusinessLayer.AcpSparseLOVField(143, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.LOVs.indexRadErgoControlO7UpDownButton_A41293LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.LOVs.idRadErgoControlO7UpDownButton_A41293LovStrs), this, global::AllFeatures.CodeplugGuid.b("鷎냐럒郔ꗖ뻘듚黜냞迠韢韤裦藨ꓪ\udaec뫮臰럲髴胶韸맺裼课甀氂欄堆䠈㼊㰌㴎⠐‒", a_), global::CommonResources.AcgResources.ID_FEATURE, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.LOVs.RadErgoControlO7UpDownButton_A41293LovStrs);
						this.radErgoControlO7UpDownButton_A41293.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
						this.radErgoControlO7UpDownButton_A41293.DataTransferOrder = 1;
						num = (short)731316227;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 5:
				{
					num = (short)154271744;
					short num4 = num;
					num = (short)123535362;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 6:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷎냐럒郔ꗖ뻘듚黜냞迠韢韤裦藨ꓪ\udaec뫮臰럲髴胶韸맺裼课甀氂欄堆䠈㼊㰌㴎⠐‒", a_)))
					{
						num = (short)2053373956;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2AD;
				case 7:
					if (producerFields != null)
					{
						num = (short)1534132229;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2AD;
				case 8:
					this.o7UpDownButtonName_A41292 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_UPBUTTON, this, global::AllFeatures.CodeplugGuid.b("胎蛒ꗔ鏖뛘곚돜鷞铠韢釤裦蟨ꗪ賬苮铰곲듴쏶죸짺쓼췾", a_), global::CommonResources.AcgResources.ID_NAME, 100);
					this.o7UpDownButtonName_A41292.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.o7UpDownButtonName_A41292.DataTransferOrder = -1;
					goto IL_177;
				case 9:
					switch (0)
					{
					case 0:
						goto IL_55;
					}
					continue;
				}
				IL_55:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)627245056;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_A1:
				num = (short)1716912134;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_177:
				num = (short)1467940865;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_234:
			IL_2AD:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("臎냐ꗒ볔냖룘꿚드냞迠쏢ꛤ裦蟨鿪鿬胮鷰胲", a_);
			base.Id = 10728;
			base.UIName = global::CommonResources.AcgResources.ID_NAVIGATIONCONTROLS;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06008841 RID: 34881 RVA: 0x007EC888 File Offset: 0x007EAA88
		public override void PopulateReferences()
		{
			short num = (short)1478195091;
			short num2 = num;
			num = (short)671578003;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1675689984;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)8126465;
			if (num != 0)
			{
			}
			num = (short)1356857344;
			if (num != 0)
			{
			}
		}

		// Token: 0x06008842 RID: 34882 RVA: 0x007EC934 File Offset: 0x007EAB34
		public override void DropReferences()
		{
			short num = (short)1086689505;
			short num2 = num;
			num = (short)2006749409;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1712193536;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1036124161;
			if (num != 0)
			{
			}
			num = (short)1760428032;
			if (num != 0)
			{
			}
		}

		// Token: 0x06008843 RID: 34883 RVA: 0x007EC9E0 File Offset: 0x007EABE0
		public override void SetConstraints()
		{
			short num = (short)1038077151;
			short num2 = num;
			num = (short)1147653343;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1136984064;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1007812609;
			if (num != 0)
			{
			}
			num = (short)1163264000;
			if (num != 0)
			{
			}
			this.o7UpDownButtonName_A41292.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.radErgoControlO7UpDownButton_A41293.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7Constraints.conDownButtonApplicable);
			this.radErgoControlO7UpDownButton_A41293.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7Constraints.ConSyncUpDownBtnFeature);
		}

		// Token: 0x06008844 RID: 34884 RVA: 0x007ECAD0 File Offset: 0x007EACD0
		public override void SetupDependencies()
		{
			short num = (short)994284149;
			short num2 = num;
			num = (short)1262129781;
			switch (num2 == num)
			{
			default:
			{
				num = (short)784465920;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)784203777;
			if (num != 0)
			{
			}
			num = (short)269287424;
			if (num != 0)
			{
			}
		}

		// Token: 0x17004540 RID: 17728
		// (get) Token: 0x06008845 RID: 34885 RVA: 0x007ECB78 File Offset: 0x007EAD78
		public bool HasDiffs
		{
			get
			{
				short num = (short)89045034;
				short num2 = num;
				num = (short)1192343594;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1775042560;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)527040512;
				if (num != 0)
				{
				}
				num = (short)1407582209;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17004541 RID: 17729
		// (get) Token: 0x06008846 RID: 34886 RVA: 0x007ECC28 File Offset: 0x007EAE28
		// (set) Token: 0x06008847 RID: 34887 RVA: 0x007ECCDC File Offset: 0x007EAEDC
		public string O7UpDownButtonName_A41292Value
		{
			get
			{
				short num = (short)1694566789;
				short num2 = num;
				num = (short)1737558405;
				switch (num2 == num)
				{
				default:
				{
					num = (short)707395584;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1070530561;
				if (num != 0)
				{
				}
				num = (short)1777664000;
				if (num != 0)
				{
				}
				return this.o7UpDownButtonName_A41292.Value;
			}
			set
			{
				short num = (short)546400434;
				short num2 = num;
				num = (short)18049202;
				switch (num2 == num)
				{
				default:
				{
					num = (short)42795008;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2140602369;
				if (num != 0)
				{
				}
				num = (short)664797184;
				if (num != 0)
				{
				}
				this.o7UpDownButtonName_A41292.Value = value;
			}
		}

		// Token: 0x17004542 RID: 17730
		// (get) Token: 0x06008848 RID: 34888 RVA: 0x007ECD94 File Offset: 0x007EAF94
		public global::AcpBusinessLayer.AcpField<string> O7UpDownButtonName_A41292
		{
			get
			{
				short num = (short)2121225446;
				short num2 = num;
				num = (short)910578918;
				switch (num2 == num)
				{
				default:
				{
					num = (short)546832384;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2126446593;
				if (num != 0)
				{
				}
				num = (short)423493632;
				if (num != 0)
				{
				}
				return this.o7UpDownButtonName_A41292;
			}
		}

		// Token: 0x17004543 RID: 17731
		// (get) Token: 0x06008849 RID: 34889 RVA: 0x007ECE44 File Offset: 0x007EB044
		// (set) Token: 0x0600884A RID: 34890 RVA: 0x007ECEF8 File Offset: 0x007EB0F8
		public string O7UpDownButtonName_A41292_UIValue
		{
			get
			{
				short num = (short)380326826;
				short num2 = num;
				num = (short)372396970;
				switch (num2 == num)
				{
				default:
				{
					num = (short)391184384;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2032402432;
				if (num != 0)
				{
				}
				num = (short)47906817;
				if (num != 0)
				{
				}
				return this.o7UpDownButtonName_A41292.Value;
			}
			set
			{
				short num = (short)1687692951;
				short num2 = num;
				num = (short)942089879;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1767178240;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)467402753;
				if (num != 0)
				{
				}
				num = (short)1386872832;
				if (num != 0)
				{
				}
				this.o7UpDownButtonName_A41292.Value = value;
			}
		}

		// Token: 0x17004544 RID: 17732
		// (get) Token: 0x0600884B RID: 34891 RVA: 0x007ECFB0 File Offset: 0x007EB1B0
		// (set) Token: 0x0600884C RID: 34892 RVA: 0x007ED064 File Offset: 0x007EB264
		public bool O7UpDownButtonName_A41292_Applicable
		{
			get
			{
				short num = (short)197263361;
				if (num != 0)
				{
				}
				num = (short)461963264;
				short num2 = num;
				num = (short)1152747460;
				short num3 = num;
				num = (short)605718468;
				switch (num3 == num)
				{
				}
				num = (short)522977280;
				if (num != 0)
				{
				}
				return this.o7UpDownButtonName_A41292.Applicable;
			}
			set
			{
				short num = (short)758606763;
				short num2 = num;
				num = (short)965700523;
				switch (num2 == num)
				{
				default:
				{
					num = (short)919863296;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1238171649;
				if (num != 0)
				{
				}
				num = (short)1501233152;
				if (num != 0)
				{
				}
				this.o7UpDownButtonName_A41292.Applicable = value;
			}
		}

		// Token: 0x17004545 RID: 17733
		// (get) Token: 0x0600884D RID: 34893 RVA: 0x007ED11C File Offset: 0x007EB31C
		// (set) Token: 0x0600884E RID: 34894 RVA: 0x007ED1D4 File Offset: 0x007EB3D4
		public bool O7UpDownButtonName_A41292_Valid
		{
			get
			{
				short num = (short)905409885;
				short num2 = num;
				num = (short)898659677;
				switch (num2 == num)
				{
				default:
				{
					num = (short)743505920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1399914497;
				if (num != 0)
				{
				}
				num = (short)1320550400;
				if (num != 0)
				{
				}
				return this.o7UpDownButtonName_A41292.Valid;
			}
			set
			{
				short num = (short)343343105;
				if (num != 0)
				{
				}
				num = (short)683409408;
				short num2 = num;
				num = (short)616943112;
				short num3 = num;
				num = (short)168939016;
				switch (num3 == num)
				{
				}
				num = (short)456982528;
				if (num != 0)
				{
				}
				this.o7UpDownButtonName_A41292.Valid = value;
			}
		}

		// Token: 0x17004546 RID: 17734
		// (get) Token: 0x0600884F RID: 34895 RVA: 0x007ED288 File Offset: 0x007EB488
		// (set) Token: 0x06008850 RID: 34896 RVA: 0x007ED33C File Offset: 0x007EB53C
		public bool O7UpDownButtonName_A41292_Visible
		{
			get
			{
				short num = (short)18808833;
				if (num != 0)
				{
				}
				num = (short)239992832;
				short num2 = num;
				num = (short)1565116492;
				short num3 = num;
				num = (short)691980364;
				switch (num3 == num)
				{
				}
				num = (short)1891762176;
				if (num != 0)
				{
				}
				return this.o7UpDownButtonName_A41292.Visible;
			}
			set
			{
				short num = (short)1627332660;
				short num2 = num;
				num = (short)971579444;
				switch (num2 == num)
				{
				default:
				{
					num = (short)712835072;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1770192897;
				if (num != 0)
				{
				}
				num = (short)993001472;
				if (num != 0)
				{
				}
				this.o7UpDownButtonName_A41292.Visible = value;
			}
		}

		// Token: 0x17004547 RID: 17735
		// (get) Token: 0x06008851 RID: 34897 RVA: 0x007ED3F0 File Offset: 0x007EB5F0
		// (set) Token: 0x06008852 RID: 34898 RVA: 0x007ED4A4 File Offset: 0x007EB6A4
		public bool O7UpDownButtonName_A41292_Editable
		{
			get
			{
				short num = (short)752891413;
				short num2 = num;
				num = (short)1199060501;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1669201920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)565051393;
				if (num != 0)
				{
				}
				num = (short)608436224;
				if (num != 0)
				{
				}
				return this.o7UpDownButtonName_A41292.Editable;
			}
			set
			{
				short num = (short)2035643063;
				short num2 = num;
				num = (short)1541239479;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1301151744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)247791616;
				if (num != 0)
				{
				}
				num = (short)1690107905;
				if (num != 0)
				{
				}
				this.o7UpDownButtonName_A41292.Editable = value;
			}
		}

		// Token: 0x17004548 RID: 17736
		// (get) Token: 0x06008853 RID: 34899 RVA: 0x007ED55C File Offset: 0x007EB75C
		internal string O7UpDownButtonName_A41292_UILabel
		{
			get
			{
				short num = (short)466083126;
				short num2 = num;
				num = (short)280550710;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1508311040;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)603717632;
				if (num != 0)
				{
				}
				num = (short)2021392385;
				if (num != 0)
				{
				}
				return this.o7UpDownButtonName_A41292.UIName;
			}
		}

		// Token: 0x17004549 RID: 17737
		// (get) Token: 0x06008854 RID: 34900 RVA: 0x007ED610 File Offset: 0x007EB810
		// (set) Token: 0x06008855 RID: 34901 RVA: 0x007ED6C4 File Offset: 0x007EB8C4
		internal bool O7UpDownButtonName_A41292_HiddenStatic
		{
			get
			{
				short num = (short)816310958;
				short num2 = num;
				num = (short)821291694;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1055129600;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2137522177;
				if (num != 0)
				{
				}
				num = (short)1789657088;
				if (num != 0)
				{
				}
				return this.o7UpDownButtonName_A41292.HiddenStatic;
			}
			set
			{
				short num = (short)1694155758;
				short num2 = num;
				num = (short)630834158;
				switch (num2 == num)
				{
				default:
				{
					num = (short)689111040;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)492961792;
				if (num != 0)
				{
				}
				num = (short)727842817;
				if (num != 0)
				{
				}
				this.o7UpDownButtonName_A41292.HiddenStatic = value;
			}
		}

		// Token: 0x1700454A RID: 17738
		// (get) Token: 0x06008856 RID: 34902 RVA: 0x007ED77C File Offset: 0x007EB97C
		// (set) Token: 0x06008857 RID: 34903 RVA: 0x007ED830 File Offset: 0x007EBA30
		internal bool O7UpDownButtonName_A41292_HiddenDynamic
		{
			get
			{
				short num = (short)705512536;
				short num2 = num;
				num = (short)1082868824;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1744044032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)231407617;
				if (num != 0)
				{
				}
				num = (short)146014208;
				if (num != 0)
				{
				}
				return this.o7UpDownButtonName_A41292.HiddenDynamic;
			}
			set
			{
				short num = (short)1556569970;
				short num2 = num;
				num = (short)1081630578;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1876033536;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)716242944;
				if (num != 0)
				{
				}
				num = (short)648282113;
				if (num != 0)
				{
				}
				this.o7UpDownButtonName_A41292.HiddenDynamic = value;
			}
		}

		// Token: 0x1700454B RID: 17739
		// (get) Token: 0x06008858 RID: 34904 RVA: 0x007ED8E4 File Offset: 0x007EBAE4
		public bool O7UpDownButtonName_A41292_HasDiffs
		{
			get
			{
				short num = (short)478626932;
				short num2 = num;
				num = (short)1871463540;
				switch (num2 == num)
				{
				default:
				{
					num = (short)497156096;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)4718592;
				if (num != 0)
				{
				}
				num = (short)351535105;
				if (num != 0)
				{
				}
				return this.o7UpDownButtonName_A41292._HasDiffs;
			}
		}

		// Token: 0x1700454C RID: 17740
		// (get) Token: 0x06008859 RID: 34905 RVA: 0x007ED99C File Offset: 0x007EBB9C
		// (set) Token: 0x0600885A RID: 34906 RVA: 0x007EDA54 File Offset: 0x007EBC54
		public int RadErgoControlO7UpDownButton_A41293Value
		{
			get
			{
				short num = (short)567017473;
				if (num != 0)
				{
				}
				num = (short)1509425152;
				short num2 = num;
				num = (short)76211859;
				short num3 = num;
				num = (short)519759507;
				switch (num3 == num)
				{
				}
				num = (short)777781248;
				if (num != 0)
				{
				}
				return this.radErgoControlO7UpDownButton_A41293.Value;
			}
			set
			{
				short num = (short)1155271469;
				short num2 = num;
				num = (short)1245907757;
				switch (num2 == num)
				{
				default:
				{
					num = (short)212336640;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)131073;
				if (num != 0)
				{
				}
				num = (short)43384832;
				if (num != 0)
				{
				}
				this.radErgoControlO7UpDownButton_A41293.Value = value;
			}
		}

		// Token: 0x1700454D RID: 17741
		// (get) Token: 0x0600885B RID: 34907 RVA: 0x007EDB08 File Offset: 0x007EBD08
		// (set) Token: 0x0600885C RID: 34908 RVA: 0x007EDBBC File Offset: 0x007EBDBC
		public string RadErgoControlO7UpDownButton_A41293_UIValue
		{
			get
			{
				short num = (short)216857778;
				short num2 = num;
				num = (short)1901722802;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1198194688;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1143406593;
				if (num != 0)
				{
				}
				num = (short)600375296;
				if (num != 0)
				{
				}
				return this.radErgoControlO7UpDownButton_A41293.UIValue;
			}
			set
			{
				short num = (short)1355895289;
				short num2 = num;
				num = (short)1262834169;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1859584000;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1754202113;
				if (num != 0)
				{
				}
				num = (short)181534720;
				if (num != 0)
				{
				}
				this.radErgoControlO7UpDownButton_A41293.UIValue = value;
			}
		}

		// Token: 0x1700454E RID: 17742
		// (get) Token: 0x0600885D RID: 34909 RVA: 0x007EDC70 File Offset: 0x007EBE70
		public global::AcpBusinessLayer.AcpListField RadErgoControlO7UpDownButton_A41293
		{
			get
			{
				short num = (short)2096693249;
				if (num != 0)
				{
				}
				num = (short)826277888;
				short num2 = num;
				num = (short)678812827;
				short num3 = num;
				num = (short)1321524379;
				switch (num3 == num)
				{
				}
				num = (short)1904803840;
				if (num != 0)
				{
				}
				return this.radErgoControlO7UpDownButton_A41293;
			}
		}

		// Token: 0x1700454F RID: 17743
		// (get) Token: 0x0600885E RID: 34910 RVA: 0x007EDD24 File Offset: 0x007EBF24
		// (set) Token: 0x0600885F RID: 34911 RVA: 0x007EDDD8 File Offset: 0x007EBFD8
		public bool RadErgoControlO7UpDownButton_A41293_Applicable
		{
			get
			{
				short num = (short)228943754;
				short num2 = num;
				num = (short)249653130;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1815478272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2129068032;
				if (num != 0)
				{
				}
				num = (short)1391263745;
				if (num != 0)
				{
				}
				return this.radErgoControlO7UpDownButton_A41293.Applicable;
			}
			set
			{
				short num = (short)1497294383;
				short num2 = num;
				num = (short)343008815;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1106706432;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1926103041;
				if (num != 0)
				{
				}
				num = (short)1530920960;
				if (num != 0)
				{
				}
				this.radErgoControlO7UpDownButton_A41293.Applicable = value;
			}
		}

		// Token: 0x17004550 RID: 17744
		// (get) Token: 0x06008860 RID: 34912 RVA: 0x007EDE90 File Offset: 0x007EC090
		// (set) Token: 0x06008861 RID: 34913 RVA: 0x007EDF48 File Offset: 0x007EC148
		public bool RadErgoControlO7UpDownButton_A41293_Valid
		{
			get
			{
				short num = (short)848131134;
				short num2 = num;
				num = (short)1251177534;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1277558784;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1843396608;
				if (num != 0)
				{
				}
				num = (short)1264254977;
				if (num != 0)
				{
				}
				return this.radErgoControlO7UpDownButton_A41293.Valid;
			}
			set
			{
				short num = (short)1641283585;
				if (num != 0)
				{
				}
				num = (short)40763392;
				short num2 = num;
				num = (short)2119627330;
				short num3 = num;
				num = (short)651096642;
				switch (num3 == num)
				{
				}
				num = (short)1687158784;
				if (num != 0)
				{
				}
				this.radErgoControlO7UpDownButton_A41293.Valid = value;
			}
		}

		// Token: 0x17004551 RID: 17745
		// (get) Token: 0x06008862 RID: 34914 RVA: 0x007EDFFC File Offset: 0x007EC1FC
		// (set) Token: 0x06008863 RID: 34915 RVA: 0x007EE0B0 File Offset: 0x007EC2B0
		public bool RadErgoControlO7UpDownButton_A41293_Visible
		{
			get
			{
				short num = (short)1143196057;
				short num2 = num;
				num = (short)886098329;
				switch (num2 == num)
				{
				}
				num = (short)1382547456;
				short num3 = num;
				num = (short)72220673;
				if (num != 0)
				{
				}
				num = (short)1272840192;
				if (num != 0)
				{
				}
				return this.radErgoControlO7UpDownButton_A41293.Visible;
			}
			set
			{
				short num = (short)1866900258;
				short num2 = num;
				num = (short)198550306;
				switch (num2 == num)
				{
				}
				num = (short)773718016;
				short num3 = num;
				num = (short)1312030721;
				if (num != 0)
				{
				}
				num = (short)1308688384;
				if (num != 0)
				{
				}
				this.radErgoControlO7UpDownButton_A41293.Visible = value;
			}
		}

		// Token: 0x17004552 RID: 17746
		// (get) Token: 0x06008864 RID: 34916 RVA: 0x007EE164 File Offset: 0x007EC364
		// (set) Token: 0x06008865 RID: 34917 RVA: 0x007EE218 File Offset: 0x007EC418
		public bool RadErgoControlO7UpDownButton_A41293_Editable
		{
			get
			{
				short num = (short)299776222;
				short num2 = num;
				num = (short)1646082270;
				switch (num2 == num)
				{
				}
				num = (short)1933639680;
				short num3 = num;
				num = (short)2125922305;
				if (num != 0)
				{
				}
				num = (short)684720128;
				if (num != 0)
				{
				}
				return this.radErgoControlO7UpDownButton_A41293.Editable;
			}
			set
			{
				short num = (short)1087204852;
				short num2 = num;
				num = (short)198012404;
				switch (num2 == num)
				{
				}
				num = (short)1889271808;
				short num3 = num;
				num = (short)832438273;
				if (num != 0)
				{
				}
				num = (short)740163584;
				if (num != 0)
				{
				}
				this.radErgoControlO7UpDownButton_A41293.Editable = value;
			}
		}

		// Token: 0x17004553 RID: 17747
		// (get) Token: 0x06008866 RID: 34918 RVA: 0x007EE2D0 File Offset: 0x007EC4D0
		internal string RadErgoControlO7UpDownButton_A41293_UILabel
		{
			get
			{
				short num = (short)996672314;
				short num2 = num;
				num = (short)1213465402;
				switch (num2 == num)
				{
				}
				num = (short)1668415488;
				short num3 = num;
				num = (short)1873543169;
				if (num != 0)
				{
				}
				num = (short)840433664;
				if (num != 0)
				{
				}
				return this.radErgoControlO7UpDownButton_A41293.UIName;
			}
		}

		// Token: 0x17004554 RID: 17748
		// (get) Token: 0x06008867 RID: 34919 RVA: 0x007EE384 File Offset: 0x007EC584
		// (set) Token: 0x06008868 RID: 34920 RVA: 0x007EE438 File Offset: 0x007EC638
		internal bool RadErgoControlO7UpDownButton_A41293_HiddenStatic
		{
			get
			{
				short num = (short)1910636545;
				if (num != 0)
				{
				}
				num = (short)1289348372;
				short num2 = num;
				num = (short)2012013844;
				switch (num2 == num)
				{
				default:
				{
					num = (short)30146560;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)29229056;
				if (num != 0)
				{
				}
				return this.radErgoControlO7UpDownButton_A41293.HiddenStatic;
			}
			set
			{
				short num = (short)1305333501;
				short num2 = num;
				num = (short)497798909;
				switch (num2 == num)
				{
				}
				num = (short)2098462720;
				short num3 = num;
				num = (short)789053440;
				if (num != 0)
				{
				}
				num = (short)1706557441;
				if (num != 0)
				{
				}
				this.radErgoControlO7UpDownButton_A41293.HiddenStatic = value;
			}
		}

		// Token: 0x17004555 RID: 17749
		// (get) Token: 0x06008869 RID: 34921 RVA: 0x007EE4F0 File Offset: 0x007EC6F0
		// (set) Token: 0x0600886A RID: 34922 RVA: 0x007EE5A4 File Offset: 0x007EC7A4
		internal bool RadErgoControlO7UpDownButton_A41293_HiddenDynamic
		{
			get
			{
				short num = (short)889551999;
				short num2 = num;
				num = (short)997620863;
				switch (num2 == num)
				{
				}
				num = (short)1960443904;
				short num3 = num;
				num = (short)562692096;
				if (num != 0)
				{
				}
				num = (short)15597569;
				if (num != 0)
				{
				}
				return this.radErgoControlO7UpDownButton_A41293.HiddenDynamic;
			}
			set
			{
				short num = (short)1627717633;
				if (num != 0)
				{
				}
				num = (short)1543681374;
				short num2 = num;
				num = (short)439465310;
				switch (num2 == num)
				{
				default:
				{
					num = (short)158531584;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)655294464;
				if (num != 0)
				{
				}
				this.radErgoControlO7UpDownButton_A41293.HiddenDynamic = value;
			}
		}

		// Token: 0x17004556 RID: 17750
		// (get) Token: 0x0600886B RID: 34923 RVA: 0x007EE658 File Offset: 0x007EC858
		public bool RadErgoControlO7UpDownButton_A41293_HasDiffs
		{
			get
			{
				short num = (short)652270240;
				short num2 = num;
				num = (short)586078880;
				switch (num2 == num)
				{
				}
				num = (short)947847168;
				short num3 = num;
				num = (short)928907264;
				if (num != 0)
				{
				}
				num = (short)1329004545;
				if (num != 0)
				{
				}
				return this.radErgoControlO7UpDownButton_A41293._HasDiffs;
			}
		}

		// Token: 0x0600886C RID: 34924 RVA: 0x007EE70C File Offset: 0x007EC90C
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
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)1788018692;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 2:
				{
					num2 = (short)303824896;
					short num3 = num2;
					if (base.ParentRecset == null)
					{
						return result;
					}
					num2 = (short)1065394752;
					short num4 = num2;
					num2 = (short)968467008;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_D4;
					default:
						num2 = (short)1746206720;
						if (num2 != 0)
						{
						}
						num2 = (short)746651651;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 3:
					num2 = (short)1026424833;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					goto IL_D4;
				}
				goto IL_24;
				IL_D4:
				result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
				num2 = (short)1656619009;
				if (num2 != 0)
				{
				}
				num2 = (short)1690370048;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)382795778;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04004006 RID: 16390
		private global::AcpBusinessLayer.AcpField<string> o7UpDownButtonName_A41292;

		// Token: 0x04004007 RID: 16391
		private global::AcpBusinessLayer.AcpListField radErgoControlO7UpDownButton_A41293;
	}
}
