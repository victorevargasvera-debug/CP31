using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using ConstraintHelper;
using Motorola.MackinawCPS.CoreFeatures.ActionConsolidation;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO9
{
	// Token: 0x0200034D RID: 845
	[global::System.Serializable]
	public class ConsolidatedActionBCOListInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06008122 RID: 33058 RVA: 0x007685AC File Offset: 0x007667AC
		public ConsolidatedActionBCOListInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06008123 RID: 33059 RVA: 0x007685C8 File Offset: 0x007667C8
		protected ConsolidatedActionBCOListInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06008124 RID: 33060 RVA: 0x007685E0 File Offset: 0x007667E0
		public override void Init()
		{
			int a_ = 18;
			short num = (short)1725140120;
			short num2 = num;
			num = (short)1950977176;
			switch (num2 == num)
			{
			}
			num = (short)187498497;
			if (num != 0)
			{
			}
			num = (short)1881341952;
			short num3 = num;
			num = (short)46596096;
			if (num != 0)
			{
			}
			this.radErgoControlO9ACBCOListBco_A36666 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.indexRadErgoControlO9ACBCOListBco_A36666LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.idRadErgoControlO9ACBCOListBco_A36666LovStrs), this, global::AllFeatures.CodeplugGuid.b("臒듔돖鳘꧚뫜냞ꋠ賢诤鏦鯨蓪臬ꃮ죰닲뛴뗶뫸듺뇼雾爀眂䜄搆昈吊䰌㰎✐┒⌔№", a_), global::CommonResources.AcgResources.ID_BCO, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.RadErgoControlO9ACBCOListBco_A36666LovStrs);
			this.radErgoControlO9ACBCOListBco_A36666.IgnoreOnCompare = true;
			this.radErgoControlO9ACBCOListBco_A36666.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radErgoControlO9ACBCOListBco_A36666.DataTransferOrder = -1;
			this.radErgoControlO9ACBCOListIndex_A36668 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("臒듔돖鳘꧚뫜냞ꋠ賢诤鏦鯨蓪臬ꃮ죰닲뛴뗶뫸듺뇼雾爀眂䰄椆洈渊甌倎倐‒⌔№⼘⌚", a_), global::CommonResources.AcgResources.ID_CONSOLIDATEDACTIONLISTINDEX, new string[]
			{
				global::CommonResources.AcgResources.ID_UNASSIGNED
			}, new int[1], true, false);
			this.radErgoControlO9ACBCOListIndex_A36668.IgnoreOnCompare = true;
			this.radErgoControlO9ACBCOListIndex_A36668.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radErgoControlO9ACBCOListIndex_A36668.DataTransferOrder = -1;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("郒뫔맖꫘듚뇜뛞藠苢釤苦跨쯪곬賮藰髲髴駶\ud9f8맺뻼냾℀伂氄理紈", a_);
			base.Id = 10623;
			base.UIName = global::CommonResources.AcgResources.ID_CONSOLIDATEDACTIONBCOLIST;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06008125 RID: 33061 RVA: 0x00768778 File Offset: 0x00766978
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 1;
			short num = (short)151715848;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					this.radErgoControlO9ACBCOListIndex_A36668 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ跇룉ꯋꇍ鏏뷑뫓ꋕ꫗뗙냛針\ud9dfꏡ꟣ꓥꯧꗩꃫ蟭華蛱뷳飵鳷鿹蓻ꇽ䇿㄁㈃々㸇㈉", a_), global::CommonResources.AcgResources.ID_CONSOLIDATEDACTIONLISTINDEX, new string[]
					{
						global::CommonResources.AcgResources.ID_UNASSIGNED
					}, new int[1], true, false);
					this.radErgoControlO9ACBCOListIndex_A36668.IgnoreOnCompare = true;
					this.radErgoControlO9ACBCOListIndex_A36668.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radErgoControlO9ACBCOListIndex_A36668.DataTransferOrder = -1;
					num = (short)1749352452;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (producerFields != null)
					{
						num = (short)216989701;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2CD;
				case 2:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ跇룉ꯋꇍ鏏뷑뫓ꋕ꫗뗙냛針\ud9dfꏡ꟣ꓥꯧꗩꃫ蟭華蛱뛳闵韷ꗹ뷻췽㛿㐁㈃々", a_)))
					{
						num = (short)973864963;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_C3;
				case 3:
					this.radErgoControlO9ACBCOListBco_A36666 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.indexRadErgoControlO9ACBCOListBco_A36666LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.idRadErgoControlO9ACBCOListBco_A36666LovStrs), this, global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ跇룉ꯋꇍ鏏뷑뫓ꋕ꫗뗙냛針\ud9dfꏡ꟣ꓥꯧꗩꃫ蟭華蛱뛳闵韷ꗹ뷻췽㛿㐁㈃々", a_), global::CommonResources.AcgResources.ID_BCO, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.RadErgoControlO9ACBCOListBco_A36666LovStrs);
					this.radErgoControlO9ACBCOListBco_A36666.IgnoreOnCompare = true;
					this.radErgoControlO9ACBCOListBco_A36666.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radErgoControlO9ACBCOListBco_A36666.DataTransferOrder = -1;
					num = (short)1375600646;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_27B;
				case 5:
					num = (short)640221186;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					goto IL_C3;
				case 7:
					num = (short)687341569;
					if (num != 0)
					{
					}
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ跇룉ꯋꇍ鏏뷑뫓ꋕ꫗뗙냛針\ud9dfꏡ꟣ꓥꯧꗩꃫ蟭華蛱뷳飵鳷鿹蓻ꇽ䇿㄁㈃々㸇㈉", a_)))
					{
						num = (short)803078144;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2CD;
				case 8:
					switch (0)
					{
					case 0:
						goto IL_56;
					}
					continue;
				case 9:
				{
					num = (short)1351998112;
					short num3 = num;
					num = (short)567270048;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1361707008;
						if (num != 0)
						{
						}
						break;
					}
					num = (short)1506607104;
					short num4 = num;
					num = (short)300351489;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_56:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1616969737;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_C3:
				num = (short)1502674951;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_27B:
			IL_2CD:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("臁ꯃꣅ믇ꗉꃋꟍ듏돑ꃓ돕볗龎鷛뷝铟诡诣裥죧꣩꿫ꇭ탯뻱鷳藵賷", a_);
			base.Id = 10623;
			base.UIName = global::CommonResources.AcgResources.ID_CONSOLIDATEDACTIONBCOLIST;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06008126 RID: 33062 RVA: 0x00768A84 File Offset: 0x00766C84
		public override void PopulateReferences()
		{
			short num = (short)1485129420;
			short num2 = num;
			num = (short)317277900;
			switch (num2 == num)
			{
			}
			num = (short)1483866113;
			if (num != 0)
			{
			}
			num = (short)219086848;
			short num3 = num;
			num = (short)320602112;
			if (num != 0)
			{
			}
			this.radErgoControlO9ACBCOListIndex_A36668.SetRecset(this.a(4008));
		}

		// Token: 0x06008127 RID: 33063 RVA: 0x00768B44 File Offset: 0x00766D44
		public override void DropReferences()
		{
			short num = (short)1913882658;
			short num2 = num;
			num = (short)590120994;
			switch (num2 == num)
			{
			}
			num = (short)1196883968;
			if (num != 0)
			{
			}
			num = (short)715259904;
			short num3 = num;
			num = (short)1243414529;
			if (num != 0)
			{
			}
		}

		// Token: 0x06008128 RID: 33064 RVA: 0x00768BF0 File Offset: 0x00766DF0
		public override void SetConstraints()
		{
			short num = (short)654767621;
			short num2 = num;
			num = (short)1228207621;
			switch (num2 == num)
			{
			}
			num = (short)9961473;
			if (num != 0)
			{
			}
			num = (short)1343750144;
			short num3 = num;
			num = (short)2106851328;
			if (num != 0)
			{
			}
			this.radErgoControlO9ACBCOListIndex_A36668.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Constraints.ConValueSetIfDataCnvIndexChanged);
		}

		// Token: 0x06008129 RID: 33065 RVA: 0x00768CB4 File Offset: 0x00766EB4
		public override void SetupDependencies()
		{
			short num = (short)1681214036;
			short num2 = num;
			num = (short)247220820;
			switch (num2 == num)
			{
			}
			num = (short)1217331201;
			if (num != 0)
			{
			}
			num = (short)820707328;
			short num3 = num;
			num = (short)150470656;
			if (num != 0)
			{
			}
		}

		// Token: 0x170041FB RID: 16891
		// (get) Token: 0x0600812A RID: 33066 RVA: 0x00768D5C File Offset: 0x00766F5C
		public global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidation ActionConsolidationForRadErgoControlO9ACBCOListIndex_A36668
		{
			get
			{
				short num = (short)178556285;
				short num2 = num;
				num = (short)2040040829;
				switch (num2 == num)
				{
				}
				num = (short)512098305;
				if (num != 0)
				{
				}
				num = (short)467533824;
				short num3 = num;
				num = (short)1684602880;
				if (num != 0)
				{
				}
				return this.radErgoControlO9ACBCOListIndex_A36668.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidation;
			}
		}

		// Token: 0x170041FC RID: 16892
		// (get) Token: 0x0600812B RID: 33067 RVA: 0x00768E14 File Offset: 0x00767014
		public bool HasDiffs
		{
			get
			{
				short num = (short)577110017;
				if (num != 0)
				{
				}
				num = (short)924279059;
				short num2 = num;
				num = (short)1306943763;
				switch (num2 == num)
				{
				}
				num = (short)641531904;
				short num3 = num;
				num = (short)1815805952;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x170041FD RID: 16893
		// (get) Token: 0x0600812C RID: 33068 RVA: 0x00768EC4 File Offset: 0x007670C4
		// (set) Token: 0x0600812D RID: 33069 RVA: 0x00768F78 File Offset: 0x00767178
		public int RadErgoControlO9ACBCOListBco_A36666Value
		{
			get
			{
				short num = (short)248860540;
				short num2 = num;
				num = (short)1004294012;
				switch (num2 == num)
				{
				}
				num = (short)1560346624;
				if (num != 0)
				{
				}
				num = (short)1021181952;
				short num3 = num;
				num = (short)448856065;
				if (num != 0)
				{
				}
				return this.radErgoControlO9ACBCOListBco_A36666.Value;
			}
			set
			{
				short num = (short)666543958;
				short num2 = num;
				num = (short)1916446550;
				switch (num2 == num)
				{
				}
				num = (short)994312192;
				if (num != 0)
				{
				}
				num = (short)878575616;
				short num3 = num;
				num = (short)1490223105;
				if (num != 0)
				{
				}
				this.radErgoControlO9ACBCOListBco_A36666.Value = value;
			}
		}

		// Token: 0x170041FE RID: 16894
		// (get) Token: 0x0600812E RID: 33070 RVA: 0x0076902C File Offset: 0x0076722C
		// (set) Token: 0x0600812F RID: 33071 RVA: 0x007690E0 File Offset: 0x007672E0
		public string RadErgoControlO9ACBCOListBco_A36666_UIValue
		{
			get
			{
				short num = (short)1166492520;
				short num2 = num;
				num = (short)64373608;
				switch (num2 == num)
				{
				}
				num = (short)560726016;
				if (num != 0)
				{
				}
				num = (short)532611072;
				short num3 = num;
				num = (short)1144848385;
				if (num != 0)
				{
				}
				return this.radErgoControlO9ACBCOListBco_A36666.UIValue;
			}
			set
			{
				short num = (short)2023323818;
				short num2 = num;
				num = (short)2142337194;
				switch (num2 == num)
				{
				}
				num = (short)934412289;
				if (num != 0)
				{
				}
				num = (short)738983936;
				short num3 = num;
				num = (short)1055653888;
				if (num != 0)
				{
				}
				this.radErgoControlO9ACBCOListBco_A36666.UIValue = value;
			}
		}

		// Token: 0x170041FF RID: 16895
		// (get) Token: 0x06008130 RID: 33072 RVA: 0x00769198 File Offset: 0x00767398
		public global::AcpBusinessLayer.AcpListField RadErgoControlO9ACBCOListBco_A36666
		{
			get
			{
				short num = (short)1212676634;
				short num2 = num;
				num = (short)1940847130;
				switch (num2 == num)
				{
				}
				num = (short)256966656;
				if (num != 0)
				{
				}
				num = (short)1220739072;
				short num3 = num;
				num = (short)1240596481;
				if (num != 0)
				{
				}
				return this.radErgoControlO9ACBCOListBco_A36666;
			}
		}

		// Token: 0x17004200 RID: 16896
		// (get) Token: 0x06008131 RID: 33073 RVA: 0x00769248 File Offset: 0x00767448
		// (set) Token: 0x06008132 RID: 33074 RVA: 0x007692FC File Offset: 0x007674FC
		public bool RadErgoControlO9ACBCOListBco_A36666_Applicable
		{
			get
			{
				short num = (short)1068389407;
				short num2 = num;
				num = (short)621433887;
				switch (num2 == num)
				{
				}
				num = (short)1925971969;
				if (num != 0)
				{
				}
				num = (short)1134428160;
				short num3 = num;
				num = (short)2111307776;
				if (num != 0)
				{
				}
				return this.radErgoControlO9ACBCOListBco_A36666.Applicable;
			}
			set
			{
				short num = (short)1119037377;
				short num2 = num;
				num = (short)774055873;
				switch (num2 == num)
				{
				}
				num = (short)35061761;
				if (num != 0)
				{
				}
				num = (short)134676480;
				short num3 = num;
				num = (short)1423638528;
				if (num != 0)
				{
				}
				this.radErgoControlO9ACBCOListBco_A36666.Applicable = value;
			}
		}

		// Token: 0x17004201 RID: 16897
		// (get) Token: 0x06008133 RID: 33075 RVA: 0x007693B0 File Offset: 0x007675B0
		// (set) Token: 0x06008134 RID: 33076 RVA: 0x00769464 File Offset: 0x00767664
		public bool RadErgoControlO9ACBCOListBco_A36666_Valid
		{
			get
			{
				short num = (short)933429249;
				if (num != 0)
				{
				}
				num = (short)747332195;
				short num2 = num;
				num = (short)119693923;
				switch (num2 == num)
				{
				}
				num = (short)318832640;
				short num3 = num;
				num = (short)1616183296;
				if (num != 0)
				{
				}
				return this.radErgoControlO9ACBCOListBco_A36666.Valid;
			}
			set
			{
				short num = (short)1562805253;
				short num2 = num;
				num = (short)1420002309;
				switch (num2 == num)
				{
				}
				num = (short)1000538113;
				if (num != 0)
				{
				}
				num = (short)465895424;
				short num3 = num;
				num = (short)1803550720;
				if (num != 0)
				{
				}
				this.radErgoControlO9ACBCOListBco_A36666.Valid = value;
			}
		}

		// Token: 0x17004202 RID: 16898
		// (get) Token: 0x06008135 RID: 33077 RVA: 0x00769518 File Offset: 0x00767718
		// (set) Token: 0x06008136 RID: 33078 RVA: 0x007695CC File Offset: 0x007677CC
		public bool RadErgoControlO9ACBCOListBco_A36666_Visible
		{
			get
			{
				short num = (short)1384248390;
				short num2 = num;
				num = (short)625341510;
				switch (num2 == num)
				{
				}
				num = (short)1345126400;
				if (num != 0)
				{
				}
				num = (short)1346043904;
				short num3 = num;
				num = (short)537788417;
				if (num != 0)
				{
				}
				return this.radErgoControlO9ACBCOListBco_A36666.Visible;
			}
			set
			{
				short num = (short)68789227;
				short num2 = num;
				num = (short)303735787;
				switch (num2 == num)
				{
				}
				num = (short)902692865;
				if (num != 0)
				{
				}
				num = (short)2067333120;
				short num3 = num;
				num = (short)1665466368;
				if (num != 0)
				{
				}
				this.radErgoControlO9ACBCOListBco_A36666.Visible = value;
			}
		}

		// Token: 0x17004203 RID: 16899
		// (get) Token: 0x06008137 RID: 33079 RVA: 0x00769684 File Offset: 0x00767884
		// (set) Token: 0x06008138 RID: 33080 RVA: 0x00769738 File Offset: 0x00767938
		public bool RadErgoControlO9ACBCOListBco_A36666_Editable
		{
			get
			{
				short num = (short)652607489;
				if (num != 0)
				{
				}
				num = (short)1634975579;
				short num2 = num;
				num = (short)420134747;
				switch (num2 == num)
				{
				}
				num = (short)653131776;
				short num3 = num;
				num = (short)882180096;
				if (num != 0)
				{
				}
				return this.radErgoControlO9ACBCOListBco_A36666.Editable;
			}
			set
			{
				short num = (short)94815649;
				short num2 = num;
				num = (short)92587425;
				switch (num2 == num)
				{
				}
				num = (short)1017446401;
				if (num != 0)
				{
				}
				num = (short)1939734528;
				short num3 = num;
				num = (short)373030912;
				if (num != 0)
				{
				}
				this.radErgoControlO9ACBCOListBco_A36666.Editable = value;
			}
		}

		// Token: 0x17004204 RID: 16900
		// (get) Token: 0x06008139 RID: 33081 RVA: 0x007697F0 File Offset: 0x007679F0
		internal string RadErgoControlO9ACBCOListBco_A36666_UILabel
		{
			get
			{
				short num = (short)1543040303;
				short num2 = num;
				num = (short)67759407;
				switch (num2 == num)
				{
				}
				num = (short)1527382016;
				if (num != 0)
				{
				}
				num = (short)1248329728;
				short num3 = num;
				num = (short)1437728769;
				if (num != 0)
				{
				}
				return this.radErgoControlO9ACBCOListBco_A36666.UIName;
			}
		}

		// Token: 0x17004205 RID: 16901
		// (get) Token: 0x0600813A RID: 33082 RVA: 0x007698A4 File Offset: 0x00767AA4
		// (set) Token: 0x0600813B RID: 33083 RVA: 0x00769958 File Offset: 0x00767B58
		internal bool RadErgoControlO9ACBCOListBco_A36666_HiddenStatic
		{
			get
			{
				short num = (short)664611172;
				short num2 = num;
				num = (short)850602340;
				switch (num2 == num)
				{
				}
				num = (short)1880162305;
				if (num != 0)
				{
				}
				num = (short)273481728;
				short num3 = num;
				num = (short)449445888;
				if (num != 0)
				{
				}
				return this.radErgoControlO9ACBCOListBco_A36666.HiddenStatic;
			}
			set
			{
				short num = (short)613651182;
				short num2 = num;
				num = (short)1137283822;
				switch (num2 == num)
				{
				}
				num = (short)591134721;
				if (num != 0)
				{
				}
				num = (short)1517617152;
				short num3 = num;
				num = (short)547618816;
				if (num != 0)
				{
				}
				this.radErgoControlO9ACBCOListBco_A36666.HiddenStatic = value;
			}
		}

		// Token: 0x17004206 RID: 16902
		// (get) Token: 0x0600813C RID: 33084 RVA: 0x00769A10 File Offset: 0x00767C10
		// (set) Token: 0x0600813D RID: 33085 RVA: 0x00769AC8 File Offset: 0x00767CC8
		internal bool RadErgoControlO9ACBCOListBco_A36666_HiddenDynamic
		{
			get
			{
				short num = (short)1160249345;
				if (num != 0)
				{
				}
				num = (short)887927268;
				short num2 = num;
				num = (short)1503179236;
				switch (num2 == num)
				{
				}
				num = (short)1020919808;
				short num3 = num;
				num = (short)1163919360;
				if (num != 0)
				{
				}
				return this.radErgoControlO9ACBCOListBco_A36666.HiddenDynamic;
			}
			set
			{
				short num = (short)728154999;
				short num2 = num;
				num = (short)117162871;
				switch (num2 == num)
				{
				}
				num = (short)1418985473;
				if (num != 0)
				{
				}
				num = (short)1078984704;
				short num3 = num;
				num = (short)1844183040;
				if (num != 0)
				{
				}
				this.radErgoControlO9ACBCOListBco_A36666.HiddenDynamic = value;
			}
		}

		// Token: 0x17004207 RID: 16903
		// (get) Token: 0x0600813E RID: 33086 RVA: 0x00769B7C File Offset: 0x00767D7C
		public bool RadErgoControlO9ACBCOListBco_A36666_HasDiffs
		{
			get
			{
				short num = (short)674359104;
				short num2 = num;
				num = (short)1436804928;
				switch (num2 == num)
				{
				}
				num = (short)1985740801;
				if (num != 0)
				{
				}
				num = (short)1931411456;
				short num3 = num;
				num = (short)81723392;
				if (num != 0)
				{
				}
				return this.radErgoControlO9ACBCOListBco_A36666._HasDiffs;
			}
		}

		// Token: 0x17004208 RID: 16904
		// (get) Token: 0x0600813F RID: 33087 RVA: 0x00769C30 File Offset: 0x00767E30
		// (set) Token: 0x06008140 RID: 33088 RVA: 0x00769CE4 File Offset: 0x00767EE4
		public int RadErgoControlO9ACBCOListIndex_A36668Value
		{
			get
			{
				short num = (short)301902224;
				short num2 = num;
				num = (short)416065936;
				switch (num2 == num)
				{
				}
				num = (short)1591738369;
				if (num != 0)
				{
				}
				num = (short)1122500608;
				short num3 = num;
				num = (short)1706819584;
				if (num != 0)
				{
				}
				return this.radErgoControlO9ACBCOListIndex_A36668.Value;
			}
			set
			{
				short num = (short)1544840875;
				short num2 = num;
				num = (short)1561880235;
				switch (num2 == num)
				{
				}
				num = (short)182255616;
				if (num != 0)
				{
				}
				num = (short)421658624;
				short num3 = num;
				num = (short)1371537409;
				if (num != 0)
				{
				}
				this.radErgoControlO9ACBCOListIndex_A36668.Value = value;
			}
		}

		// Token: 0x17004209 RID: 16905
		// (get) Token: 0x06008141 RID: 33089 RVA: 0x00769D9C File Offset: 0x00767F9C
		// (set) Token: 0x06008142 RID: 33090 RVA: 0x00769E54 File Offset: 0x00768054
		public string RadErgoControlO9ACBCOListIndex_A36668_UIValue
		{
			get
			{
				short num = (short)925884566;
				short num2 = num;
				num = (short)538763414;
				switch (num2 == num)
				{
				}
				num = (short)1458634753;
				if (num != 0)
				{
				}
				num = (short)2130706432;
				short num3 = num;
				num = (short)274792448;
				if (num != 0)
				{
				}
				return this.radErgoControlO9ACBCOListIndex_A36668.UIValue;
			}
			set
			{
				short num = (short)1746054923;
				short num2 = num;
				num = (short)1185984267;
				switch (num2 == num)
				{
				}
				num = (short)1717174273;
				if (num != 0)
				{
				}
				num = (short)742064128;
				short num3 = num;
				num = (short)90046464;
				if (num != 0)
				{
				}
				this.radErgoControlO9ACBCOListIndex_A36668.UIValue = value;
			}
		}

		// Token: 0x1700420A RID: 16906
		// (get) Token: 0x06008143 RID: 33091 RVA: 0x00769F0C File Offset: 0x0076810C
		public global::AcpBusinessLayer.AcpRecRefField RadErgoControlO9ACBCOListIndex_A36668
		{
			get
			{
				short num = (short)1130294891;
				short num2 = num;
				num = (short)508620395;
				switch (num2 == num)
				{
				}
				num = (short)333578241;
				if (num != 0)
				{
				}
				num = (short)343670784;
				short num3 = num;
				num = (short)143458304;
				if (num != 0)
				{
				}
				return this.radErgoControlO9ACBCOListIndex_A36668;
			}
		}

		// Token: 0x1700420B RID: 16907
		// (get) Token: 0x06008144 RID: 33092 RVA: 0x00769FBC File Offset: 0x007681BC
		// (set) Token: 0x06008145 RID: 33093 RVA: 0x0076A070 File Offset: 0x00768270
		public bool RadErgoControlO9ACBCOListIndex_A36668_Applicable
		{
			get
			{
				short num = (short)200605697;
				if (num != 0)
				{
				}
				num = (short)960679511;
				short num2 = num;
				num = (short)1954664023;
				switch (num2 == num)
				{
				}
				num = (short)220004352;
				short num3 = num;
				num = (short)18022400;
				if (num != 0)
				{
				}
				return this.radErgoControlO9ACBCOListIndex_A36668.Applicable;
			}
			set
			{
				short num = (short)1473332183;
				short num2 = num;
				num = (short)1340097495;
				switch (num2 == num)
				{
				}
				num = (short)1573912577;
				if (num != 0)
				{
				}
				num = (short)1377370112;
				short num3 = num;
				num = (short)1726283776;
				if (num != 0)
				{
				}
				this.radErgoControlO9ACBCOListIndex_A36668.Applicable = value;
			}
		}

		// Token: 0x1700420C RID: 16908
		// (get) Token: 0x06008146 RID: 33094 RVA: 0x0076A124 File Offset: 0x00768324
		// (set) Token: 0x06008147 RID: 33095 RVA: 0x0076A1DC File Offset: 0x007683DC
		public bool RadErgoControlO9ACBCOListIndex_A36668_Valid
		{
			get
			{
				short num = (short)2108536586;
				short num2 = num;
				num = (short)1300412170;
				switch (num2 == num)
				{
				}
				num = (short)1206714368;
				if (num != 0)
				{
				}
				num = (short)136052736;
				short num3 = num;
				num = (short)1238302721;
				if (num != 0)
				{
				}
				return this.radErgoControlO9ACBCOListIndex_A36668.Valid;
			}
			set
			{
				short num = (short)1339542828;
				short num2 = num;
				num = (short)172281132;
				switch (num2 == num)
				{
				}
				num = (short)356777985;
				if (num != 0)
				{
				}
				num = (short)436731904;
				short num3 = num;
				num = (short)2012676096;
				if (num != 0)
				{
				}
				this.radErgoControlO9ACBCOListIndex_A36668.Valid = value;
			}
		}

		// Token: 0x1700420D RID: 16909
		// (get) Token: 0x06008148 RID: 33096 RVA: 0x0076A294 File Offset: 0x00768494
		// (set) Token: 0x06008149 RID: 33097 RVA: 0x0076A34C File Offset: 0x0076854C
		public bool RadErgoControlO9ACBCOListIndex_A36668_Visible
		{
			get
			{
				short num = (short)772800513;
				if (num != 0)
				{
				}
				num = (short)1334646930;
				short num2 = num;
				num = (short)191240338;
				switch (num2 == num)
				{
				}
				num = (short)637272064;
				short num3 = num;
				num = (short)1758199808;
				if (num != 0)
				{
				}
				return this.radErgoControlO9ACBCOListIndex_A36668.Visible;
			}
			set
			{
				short num = (short)16646145;
				if (num != 0)
				{
				}
				num = (short)1970164500;
				short num2 = num;
				num = (short)48386836;
				switch (num2 == num)
				{
				}
				num = (short)643432448;
				short num3 = num;
				num = (short)153550848;
				if (num != 0)
				{
				}
				this.radErgoControlO9ACBCOListIndex_A36668.Visible = value;
			}
		}

		// Token: 0x1700420E RID: 16910
		// (get) Token: 0x0600814A RID: 33098 RVA: 0x0076A400 File Offset: 0x00768600
		// (set) Token: 0x0600814B RID: 33099 RVA: 0x0076A4B4 File Offset: 0x007686B4
		public bool RadErgoControlO9ACBCOListIndex_A36668_Editable
		{
			get
			{
				short num = (short)961814153;
				short num2 = num;
				num = (short)567484041;
				switch (num2 == num)
				{
				}
				num = (short)1064239105;
				if (num != 0)
				{
				}
				num = (short)1956839424;
				short num3 = num;
				num = (short)2098462720;
				if (num != 0)
				{
				}
				return this.radErgoControlO9ACBCOListIndex_A36668.Editable;
			}
			set
			{
				short num = (short)216652550;
				short num2 = num;
				num = (short)1075895046;
				switch (num2 == num)
				{
				}
				num = (short)328728577;
				if (num != 0)
				{
				}
				num = (short)974913536;
				short num3 = num;
				num = (short)1610088448;
				if (num != 0)
				{
				}
				this.radErgoControlO9ACBCOListIndex_A36668.Editable = value;
			}
		}

		// Token: 0x1700420F RID: 16911
		// (get) Token: 0x0600814C RID: 33100 RVA: 0x0076A56C File Offset: 0x0076876C
		internal string RadErgoControlO9ACBCOListIndex_A36668_UILabel
		{
			get
			{
				short num = (short)635063398;
				short num2 = num;
				num = (short)642468966;
				switch (num2 == num)
				{
				}
				num = (short)338624513;
				if (num != 0)
				{
				}
				num = (short)1104740352;
				short num3 = num;
				num = (short)441319424;
				if (num != 0)
				{
				}
				return this.radErgoControlO9ACBCOListIndex_A36668.UIName;
			}
		}

		// Token: 0x17004210 RID: 16912
		// (get) Token: 0x0600814D RID: 33101 RVA: 0x0076A620 File Offset: 0x00768820
		// (set) Token: 0x0600814E RID: 33102 RVA: 0x0076A6D8 File Offset: 0x007688D8
		internal bool RadErgoControlO9ACBCOListIndex_A36668_HiddenStatic
		{
			get
			{
				short num = (short)1643466142;
				short num2 = num;
				num = (short)276516254;
				switch (num2 == num)
				{
				}
				num = (short)1802305536;
				if (num != 0)
				{
				}
				num = (short)1122959360;
				short num3 = num;
				num = (short)1429602305;
				if (num != 0)
				{
				}
				return this.radErgoControlO9ACBCOListIndex_A36668.HiddenStatic;
			}
			set
			{
				short num = (short)116523009;
				if (num != 0)
				{
				}
				num = (short)1289323171;
				short num2 = num;
				num = (short)927433379;
				switch (num2 == num)
				{
				}
				num = (short)95879168;
				short num3 = num;
				num = (short)830472192;
				if (num != 0)
				{
				}
				this.radErgoControlO9ACBCOListIndex_A36668.HiddenStatic = value;
			}
		}

		// Token: 0x17004211 RID: 16913
		// (get) Token: 0x0600814F RID: 33103 RVA: 0x0076A790 File Offset: 0x00768990
		// (set) Token: 0x06008150 RID: 33104 RVA: 0x0076A844 File Offset: 0x00768A44
		internal bool RadErgoControlO9ACBCOListIndex_A36668_HiddenDynamic
		{
			get
			{
				short num = (short)331347327;
				short num2 = num;
				num = (short)338294143;
				switch (num2 == num)
				{
				}
				num = (short)138477569;
				if (num != 0)
				{
				}
				num = (short)1272578048;
				short num3 = num;
				num = (short)1379532800;
				if (num != 0)
				{
				}
				return this.radErgoControlO9ACBCOListIndex_A36668.HiddenDynamic;
			}
			set
			{
				short num = (short)688842211;
				short num2 = num;
				num = (short)455730659;
				switch (num2 == num)
				{
				}
				num = (short)533594112;
				if (num != 0)
				{
				}
				num = (short)1090191360;
				short num3 = num;
				num = (short)251592705;
				if (num != 0)
				{
				}
				this.radErgoControlO9ACBCOListIndex_A36668.HiddenDynamic = value;
			}
		}

		// Token: 0x17004212 RID: 16914
		// (get) Token: 0x06008151 RID: 33105 RVA: 0x0076A8FC File Offset: 0x00768AFC
		public bool RadErgoControlO9ACBCOListIndex_A36668_HasDiffs
		{
			get
			{
				short num = (short)23925354;
				short num2 = num;
				num = (short)334303850;
				switch (num2 == num)
				{
				}
				num = (short)1594753024;
				if (num != 0)
				{
				}
				num = (short)1789526016;
				short num3 = num;
				num = (short)166854657;
				if (num != 0)
				{
				}
				return this.radErgoControlO9ACBCOListIndex_A36668._HasDiffs;
			}
		}

		// Token: 0x06008152 RID: 33106 RVA: 0x0076A9B0 File Offset: 0x00768BB0
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			short num = (short)351207424;
			short num2 = num;
			switch (0)
			{
			case 0:
				goto IL_4D;
			}
			int num3;
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_33:
				switch (num3)
				{
				case 0:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num = (short)1325989891;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 1:
					if (base.ParentRecset != null)
					{
						num = (short)1073676290;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 2:
					num = (short)807403521;
					if (num != 0)
					{
					}
					num = (short)1651113984;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num = (short)650444804;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					return result;
				}
				goto IL_4D;
			}
			return result;
			for (;;)
			{
				IL_4D:
				result = null;
				num = (short)278553784;
				short num4 = num;
				num = (short)1376543928;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_85;
				}
			}
			IL_85:
			num = (short)1702166528;
			if (num != 0)
			{
			}
			num = (short)1808990209;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_33;
		}

		// Token: 0x040039D4 RID: 14804
		private global::AcpBusinessLayer.AcpListField radErgoControlO9ACBCOListBco_A36666;

		// Token: 0x040039D5 RID: 14805
		private global::AcpBusinessLayer.AcpRecRefField radErgoControlO9ACBCOListIndex_A36668;
	}
}
