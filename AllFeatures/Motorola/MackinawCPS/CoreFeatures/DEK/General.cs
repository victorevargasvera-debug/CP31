using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.DEK
{
	// Token: 0x02000342 RID: 834
	[global::System.Serializable]
	public class General : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06008005 RID: 32773 RVA: 0x0075B488 File Offset: 0x00759688
		public General(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x06008006 RID: 32774 RVA: 0x0075B4C8 File Offset: 0x007596C8
		protected General(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06008007 RID: 32775 RVA: 0x0075B4E0 File Offset: 0x007596E0
		public override void Init()
		{
			int a_ = 3;
			short num = (short)725286913;
			if (num != 0)
			{
			}
			num = (short)1714833232;
			short num2 = num;
			num = (short)159795024;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1349910528;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)93454336;
			if (num != 0)
			{
			}
			this.dEKNumberofDEKBoxes_A8579 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("胃菅菇蓉맋ꏍ닏럑ꛓ맕뻗黙駛闝ꋟ跡鳣菥鯧뗩귫훭엯엱췳", a_), global::CommonResources.AcgResources.ID_NUMBEROFDEKBOXES, global::Motorola.MackinawCPS.CoreFeatures.DEK.LOVs.DEKNumberofDEKBoxes_A8579LovStrs);
			this.dEKNumberofDEKBoxes_A8579.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.dEKNumberofDEKBoxes_A8579.DataTransferOrder = 1;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("菃ꏅꛇ꿉뻋꿍볏", a_);
			base.Id = 10232;
			base.UIName = global::CommonResources.AcgResources.ID_GENERAL;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06008008 RID: 32776 RVA: 0x0075B600 File Offset: 0x00759800
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 17;
			short num = (short)1176436740;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1382940673;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("雑釓鷕雗꿙뇛볝藟郡诣胥곧꿩꟫곭鿯諱釳藵ꟷ믹쓻쯽㟿㬁", a_)))
					{
						num = (short)288817157;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1DE;
				case 2:
					num = (short)200015878;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
				{
					num = (short)451792399;
					short num3 = num;
					num = (short)1959972367;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_149;
					}
					break;
				}
				case 4:
					switch (0)
					{
					case 0:
						goto IL_4B;
					}
					continue;
				case 5:
					this.dEKNumberofDEKBoxes_A8579 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("雑釓鷕雗꿙뇛볝藟郡诣胥곧꿩꟫곭鿯諱釳藵ꟷ믹쓻쯽㟿㬁", a_), global::CommonResources.AcgResources.ID_NUMBEROFDEKBOXES, global::Motorola.MackinawCPS.CoreFeatures.DEK.LOVs.DEKNumberofDEKBoxes_A8579LovStrs);
					this.dEKNumberofDEKBoxes_A8579.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.dEKNumberofDEKBoxes_A8579.DataTransferOrder = 1;
					num = (short)765591555;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					if (producerFields != null)
					{
						num = (short)936509440;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1DE;
				}
				IL_4B:
				num = (short)1292632065;
				if (num != 0)
				{
				}
				num = (short)2045509632;
				short num4 = num;
				if (!global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					goto IL_1DE;
				}
				num = (short)740294658;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_149:
			num = (short)1577517056;
			if (num != 0)
			{
			}
			IL_1DE:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("闑뇓룕뷗꣙뷛닝", a_);
			base.Id = 10232;
			base.UIName = global::CommonResources.AcgResources.ID_GENERAL;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06008009 RID: 32777 RVA: 0x0075B81C File Offset: 0x00759A1C
		public override void PopulateReferences()
		{
			short num = (short)1198784513;
			if (num != 0)
			{
			}
			num = (short)929128217;
			short num2 = num;
			num = (short)103571225;
			switch (num2 == num)
			{
			default:
			{
				num = (short)852230144;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1488388096;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600800A RID: 32778 RVA: 0x0075B8C4 File Offset: 0x00759AC4
		public override void DropReferences()
		{
			short num = (short)692886821;
			short num2 = num;
			num = (short)926784805;
			switch (num2 == num)
			{
			}
			num = (short)327024640;
			short num3 = num;
			num = (short)1150353409;
			if (num != 0)
			{
			}
			num = (short)1191706624;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600800B RID: 32779 RVA: 0x0075B96C File Offset: 0x00759B6C
		public override void SetConstraints()
		{
			short num = (short)1898415777;
			short num2 = num;
			num = (short)395413153;
			switch (num2 == num)
			{
			}
			num = (short)448724992;
			short num3 = num;
			num = (short)1869414401;
			if (num != 0)
			{
			}
			num = (short)1058078720;
			if (num != 0)
			{
			}
			this.dEKNumberofDEKBoxes_A8579.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKConstraints.ConValueSetOfDEKBoxNum);
		}

		// Token: 0x0600800C RID: 32780 RVA: 0x0075BA2C File Offset: 0x00759C2C
		public override void SetupDependencies()
		{
			short num = (short)632604011;
			short num2 = num;
			num = (short)271238507;
			switch (num2 == num)
			{
			}
			num = (short)1772290048;
			short num3 = num;
			num = (short)901709825;
			if (num != 0)
			{
			}
			num = (short)569376768;
			if (num != 0)
			{
			}
		}

		// Token: 0x17004178 RID: 16760
		// (get) Token: 0x0600800D RID: 32781 RVA: 0x0075BAD4 File Offset: 0x00759CD4
		public bool HasDiffs
		{
			get
			{
				short num = (short)23955401;
				short num2 = num;
				num = (short)133859273;
				switch (num2 == num)
				{
				}
				num = (short)262340608;
				short num3 = num;
				num = (short)649723904;
				if (num != 0)
				{
				}
				num = (short)1708392449;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17004179 RID: 16761
		// (get) Token: 0x0600800E RID: 32782 RVA: 0x0075BB88 File Offset: 0x00759D88
		// (set) Token: 0x0600800F RID: 32783 RVA: 0x0075BC40 File Offset: 0x00759E40
		public int DEKNumberofDEKBoxes_A8579Value
		{
			get
			{
				short num = (short)1537209827;
				short num2 = num;
				num = (short)477427171;
				switch (num2 == num)
				{
				}
				num = (short)87293952;
				short num3 = num;
				num = (short)285605889;
				if (num != 0)
				{
				}
				num = (short)9568256;
				if (num != 0)
				{
				}
				return this.dEKNumberofDEKBoxes_A8579.Value;
			}
			set
			{
				short num = (short)822263827;
				short num2 = num;
				num = (short)1639563283;
				switch (num2 == num)
				{
				}
				num = (short)1726742528;
				short num3 = num;
				num = (short)1599864832;
				if (num != 0)
				{
				}
				num = (short)984023041;
				if (num != 0)
				{
				}
				this.dEKNumberofDEKBoxes_A8579.Value = value;
			}
		}

		// Token: 0x1700417A RID: 16762
		// (get) Token: 0x06008010 RID: 32784 RVA: 0x0075BCF4 File Offset: 0x00759EF4
		// (set) Token: 0x06008011 RID: 32785 RVA: 0x0075BDA8 File Offset: 0x00759FA8
		public string DEKNumberofDEKBoxes_A8579_UIValue
		{
			get
			{
				short num = (short)934151152;
				short num2 = num;
				num = (short)1409614832;
				switch (num2 == num)
				{
				}
				num = (short)427229184;
				short num3 = num;
				num = (short)394657793;
				if (num != 0)
				{
				}
				num = (short)513409024;
				if (num != 0)
				{
				}
				return this.dEKNumberofDEKBoxes_A8579.UIValue;
			}
			set
			{
				short num = (short)225707733;
				short num2 = num;
				num = (short)1933838037;
				switch (num2 == num)
				{
				}
				num = (short)1501102080;
				short num3 = num;
				num = (short)2008547329;
				if (num != 0)
				{
				}
				num = (short)1534066688;
				if (num != 0)
				{
				}
				this.dEKNumberofDEKBoxes_A8579.UIValue = value;
			}
		}

		// Token: 0x1700417B RID: 16763
		// (get) Token: 0x06008012 RID: 32786 RVA: 0x0075BE5C File Offset: 0x0075A05C
		public global::AcpBusinessLayer.AcpListField DEKNumberofDEKBoxes_A8579
		{
			get
			{
				short num = (short)523856577;
				short num2 = num;
				num = (short)349924033;
				switch (num2 == num)
				{
				}
				num = (short)1361707008;
				short num3 = num;
				num = (short)212467712;
				if (num != 0)
				{
				}
				num = (short)1919746049;
				if (num != 0)
				{
				}
				return this.dEKNumberofDEKBoxes_A8579;
			}
		}

		// Token: 0x1700417C RID: 16764
		// (get) Token: 0x06008013 RID: 32787 RVA: 0x0075BF0C File Offset: 0x0075A10C
		// (set) Token: 0x06008014 RID: 32788 RVA: 0x0075BFC0 File Offset: 0x0075A1C0
		public bool DEKNumberofDEKBoxes_A8579_Applicable
		{
			get
			{
				short num = (short)929103873;
				if (num != 0)
				{
				}
				num = (short)618263795;
				short num2 = num;
				num = (short)280360179;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1031340032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)528285696;
				if (num != 0)
				{
				}
				return this.dEKNumberofDEKBoxes_A8579.Applicable;
			}
			set
			{
				short num = (short)1260072718;
				short num2 = num;
				num = (short)170536718;
				switch (num2 == num)
				{
				}
				num = (short)973799424;
				short num3 = num;
				num = (short)1715404801;
				if (num != 0)
				{
				}
				num = (short)656211968;
				if (num != 0)
				{
				}
				this.dEKNumberofDEKBoxes_A8579.Applicable = value;
			}
		}

		// Token: 0x1700417D RID: 16765
		// (get) Token: 0x06008015 RID: 32789 RVA: 0x0075C078 File Offset: 0x0075A278
		// (set) Token: 0x06008016 RID: 32790 RVA: 0x0075C12C File Offset: 0x0075A32C
		public bool DEKNumberofDEKBoxes_A8579_Valid
		{
			get
			{
				short num = (short)1195036404;
				short num2 = num;
				num = (short)165990132;
				switch (num2 == num)
				{
				}
				num = (short)997916672;
				short num3 = num;
				num = (short)545980416;
				if (num != 0)
				{
				}
				num = (short)1867972609;
				if (num != 0)
				{
				}
				return this.dEKNumberofDEKBoxes_A8579.Valid;
			}
			set
			{
				short num = (short)33264799;
				short num2 = num;
				num = (short)2120586399;
				switch (num2 == num)
				{
				}
				num = (short)1190789120;
				short num3 = num;
				num = (short)283836417;
				if (num != 0)
				{
				}
				num = (short)1193934848;
				if (num != 0)
				{
				}
				this.dEKNumberofDEKBoxes_A8579.Valid = value;
			}
		}

		// Token: 0x1700417E RID: 16766
		// (get) Token: 0x06008017 RID: 32791 RVA: 0x0075C1E0 File Offset: 0x0075A3E0
		// (set) Token: 0x06008018 RID: 32792 RVA: 0x0075C294 File Offset: 0x0075A494
		public bool DEKNumberofDEKBoxes_A8579_Visible
		{
			get
			{
				short num = (short)213154923;
				short num2 = num;
				num = (short)868514923;
				switch (num2 == num)
				{
				}
				num = (short)813760512;
				short num3 = num;
				num = (short)1759641600;
				if (num != 0)
				{
				}
				num = (short)261357569;
				if (num != 0)
				{
				}
				return this.dEKNumberofDEKBoxes_A8579.Visible;
			}
			set
			{
				short num = (short)1044562334;
				short num2 = num;
				num = (short)885965214;
				switch (num2 == num)
				{
				}
				num = (short)1174405120;
				short num3 = num;
				num = (short)450101249;
				if (num != 0)
				{
				}
				num = (short)339935232;
				if (num != 0)
				{
				}
				this.dEKNumberofDEKBoxes_A8579.Visible = value;
			}
		}

		// Token: 0x1700417F RID: 16767
		// (get) Token: 0x06008019 RID: 32793 RVA: 0x0075C348 File Offset: 0x0075A548
		// (set) Token: 0x0600801A RID: 32794 RVA: 0x0075C400 File Offset: 0x0075A600
		public bool DEKNumberofDEKBoxes_A8579_Editable
		{
			get
			{
				short num = (short)633380672;
				short num2 = num;
				num = (short)903257920;
				switch (num2 == num)
				{
				}
				num = (short)993132544;
				short num3 = num;
				num = (short)47251457;
				if (num != 0)
				{
				}
				num = (short)1992425472;
				if (num != 0)
				{
				}
				return this.dEKNumberofDEKBoxes_A8579.Editable;
			}
			set
			{
				short num = (short)1353776892;
				short num2 = num;
				num = (short)1089666812;
				switch (num2 == num)
				{
				}
				num = (short)1179385856;
				short num3 = num;
				num = (short)1015152640;
				if (num != 0)
				{
				}
				num = (short)839122945;
				if (num != 0)
				{
				}
				this.dEKNumberofDEKBoxes_A8579.Editable = value;
			}
		}

		// Token: 0x17004180 RID: 16768
		// (get) Token: 0x0600801B RID: 32795 RVA: 0x0075C4B4 File Offset: 0x0075A6B4
		internal string DEKNumberofDEKBoxes_A8579_UILabel
		{
			get
			{
				short num = (short)345073924;
				short num2 = num;
				num = (short)710764804;
				switch (num2 == num)
				{
				}
				num = (short)1746796544;
				short num3 = num;
				num = (short)953679872;
				if (num != 0)
				{
				}
				num = (short)887488513;
				if (num != 0)
				{
				}
				return this.dEKNumberofDEKBoxes_A8579.UIName;
			}
		}

		// Token: 0x17004181 RID: 16769
		// (get) Token: 0x0600801C RID: 32796 RVA: 0x0075C568 File Offset: 0x0075A768
		// (set) Token: 0x0600801D RID: 32797 RVA: 0x0075C61C File Offset: 0x0075A81C
		internal bool DEKNumberofDEKBoxes_A8579_HiddenStatic
		{
			get
			{
				short num = (short)87778723;
				short num2 = num;
				num = (short)1457612195;
				switch (num2 == num)
				{
				}
				num = (short)158924800;
				short num3 = num;
				num = (short)2042429441;
				if (num != 0)
				{
				}
				num = (short)2113732608;
				if (num != 0)
				{
				}
				return this.dEKNumberofDEKBoxes_A8579.HiddenStatic;
			}
			set
			{
				short num = (short)49056232;
				short num2 = num;
				num = (short)287476200;
				switch (num2 == num)
				{
				}
				num = (short)302710784;
				short num3 = num;
				num = (short)232521728;
				if (num != 0)
				{
				}
				num = (short)1070137345;
				if (num != 0)
				{
				}
				this.dEKNumberofDEKBoxes_A8579.HiddenStatic = value;
			}
		}

		// Token: 0x17004182 RID: 16770
		// (get) Token: 0x0600801E RID: 32798 RVA: 0x0075C6D4 File Offset: 0x0075A8D4
		// (set) Token: 0x0600801F RID: 32799 RVA: 0x0075C788 File Offset: 0x0075A988
		internal bool DEKNumberofDEKBoxes_A8579_HiddenDynamic
		{
			get
			{
				short num = (short)1638622523;
				short num2 = num;
				num = (short)926180667;
				switch (num2 == num)
				{
				}
				num = (short)411697152;
				short num3 = num;
				num = (short)116850688;
				if (num != 0)
				{
				}
				num = (short)592445441;
				if (num != 0)
				{
				}
				return this.dEKNumberofDEKBoxes_A8579.HiddenDynamic;
			}
			set
			{
				short num = (short)2036841094;
				short num2 = num;
				num = (short)923384454;
				switch (num2 == num)
				{
				}
				num = (short)762314752;
				short num3 = num;
				num = (short)1823604736;
				if (num != 0)
				{
				}
				num = (short)852557825;
				if (num != 0)
				{
				}
				this.dEKNumberofDEKBoxes_A8579.HiddenDynamic = value;
			}
		}

		// Token: 0x17004183 RID: 16771
		// (get) Token: 0x06008020 RID: 32800 RVA: 0x0075C840 File Offset: 0x0075AA40
		public bool DEKNumberofDEKBoxes_A8579_HasDiffs
		{
			get
			{
				short num = (short)858317842;
				short num2 = num;
				num = (short)380363794;
				switch (num2 == num)
				{
				}
				num = (short)1803419648;
				short num3 = num;
				num = (short)1619918848;
				if (num != 0)
				{
				}
				num = (short)1065156609;
				if (num != 0)
				{
				}
				return this.dEKNumberofDEKBoxes_A8579._HasDiffs;
			}
		}

		// Token: 0x06008021 RID: 32801 RVA: 0x0075C8F8 File Offset: 0x0075AAF8
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			short num = (short)1717698560;
			short num2 = num;
			switch (0)
			{
			case 0:
				goto IL_97;
			}
			int num4;
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_34:
				num = (short)609771739;
				short num3 = num;
				num = (short)411066587;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)841678848;
					if (num != 0)
					{
					}
					switch (num4)
					{
					case 0:
						return result;
					case 1:
						num = (short)1720188931;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (base.ParentRecset != null)
						{
							goto IL_E2;
						}
						return result;
					case 3:
						if (base.ParentRecset.ContainerDoc != null)
						{
							num = (short)102629380;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 4:
						result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
						num = (short)1709965312;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_97;
				}
				IL_E2:
				num = (short)1213988865;
				num4 = (int)((global::System.IntPtr)num);
			}
			return result;
			IL_97:
			result = null;
			num = (short)1866858497;
			if (num != 0)
			{
			}
			num = (short)1587544066;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_34;
		}

		// Token: 0x040039B9 RID: 14777
		private global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInnerRecset innerRecset;

		// Token: 0x040039BA RID: 14778
		private global::AcpBusinessLayer.AcpListField dEKNumberofDEKBoxes_A8579;
	}
}
