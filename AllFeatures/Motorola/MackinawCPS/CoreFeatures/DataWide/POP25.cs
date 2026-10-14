using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using ConstraintHelper;

namespace Motorola.MackinawCPS.CoreFeatures.DataWide
{
	// Token: 0x020004E9 RID: 1257
	[global::System.Serializable]
	public class POP25 : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600A89E RID: 43166 RVA: 0x009CA2A0 File Offset: 0x009C84A0
		public POP25(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x0600A89F RID: 43167 RVA: 0x009CA2BC File Offset: 0x009C84BC
		protected POP25(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600A8A0 RID: 43168 RVA: 0x009CA2D4 File Offset: 0x009C84D4
		public override void Init()
		{
			int a_ = 0;
			short num = (short)1373817270;
			short num2 = num;
			num = (short)429443510;
			switch (num2 == num)
			{
			}
			num = (short)1619525632;
			if (num != 0)
			{
			}
			num = (short)1372323841;
			if (num != 0)
			{
			}
			num = (short)1854341120;
			short num3 = num;
			this.dataWidePOP25OTAPIndications_A8670 = new global::AcpBusinessLayer.AcpSparseLOVField(1, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.DataWide.LOVs.indexDataWidePOP25OTAPIndications_A8670LovStrs, global::Motorola.MackinawCPS.CoreFeatures.DataWide.LOVs.idDataWidePOP25OTAPIndications_A8670LovStrs), this, global::AllFeatures.CodeplugGuid.b("藀ꋂ뇄ꛆ黈ꋊ꧌꫎臐鳒藔铚觜點뇠ꫢ诤菦胨裪賬鯮飰鳲鯴蓶꛸뫺염짾㘀㌂", a_), global::CommonResources.AcgResources.ID_INDICATIONS, global::Motorola.MackinawCPS.CoreFeatures.DataWide.LOVs.DataWidePOP25OTAPIndications_A8670LovStrs);
			this.dataWidePOP25OTAPIndications_A8670.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.dataWidePOP25OTAPIndications_A8670.DataTransferOrder = 4;
			this.dataWidePOP25OTAPRejectEnable_A8671 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("藀ꋂ뇄ꛆ黈ꋊ꧌꫎臐鳒藔铚觜點뇠뇢胤跦賨裪駬ꫮ鿰鋲韴鯶鳸ꓺ볼쟾㜀㐂㐄", a_), global::CommonResources.AcgResources.ID_REJECTENABLE);
			this.dataWidePOP25OTAPRejectEnable_A8671.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.dataWidePOP25OTAPRejectEnable_A8671.DataTransferOrder = 12;
			this.dataWidePOP25AutoResetEnable_A37221 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("藀ꋂ뇄ꛆ黈ꋊ꧌꫎臐鳒藔髚꣜ꯞ軠뇢胤铦賨鿪꣬臮郰釲駴鋶꛸뫺컼죾㌀㄂㐄", a_), global::CommonResources.AcgResources.ID_AUTORESETENABLE);
			this.dataWidePOP25AutoResetEnable_A37221.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.dataWidePOP25AutoResetEnable_A37221.DataTransferOrder = 25;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("釀賂闄ﳈ蛐뫒꟔닖뗘뻚껜곞쇠돢韤裦軨駪賬苮鳰髲鯴郶", a_);
			base.Id = 10065;
			base.UIName = global::CommonResources.AcgResources.ID_POP25WIRELESSPROGRAMMING;
			base.DataTransferOrder = 2;
		}

		// Token: 0x0600A8A1 RID: 43169 RVA: 0x009CA474 File Offset: 0x009C8674
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 2;
			short num = (short)589824005;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蟂꓄돆꣈鳊꓌ꯎ듐菒體蟖鋜诞ꃠ돢곤触跨苪軬軮藰髲髴駶諸ꓺ볼쟾㜀㐂㔄", a_)))
					{
						num = (short)1067843596;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_127;
				case 1:
					goto IL_127;
				case 2:
					this.dataWidePOP25AutoResetEnable_A37221 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("蟂꓄돆꣈鳊꓌ꯎ듐菒體蟖鳜꫞闠賢럤苦髨軪駬ꫮ鿰鋲韴鯶鳸ꓺ볼쳾㘀㄂㜄㘆", a_), global::CommonResources.AcgResources.ID_AUTORESETENABLE);
					this.dataWidePOP25AutoResetEnable_A37221.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.dataWidePOP25AutoResetEnable_A37221.DataTransferOrder = 25;
					num = (short)1330708486;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					this.dataWidePOP25OTAPRejectEnable_A8671 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("蟂꓄돆꣈鳊꓌ꯎ듐菒體蟖鋜诞ꃠ돢럤苦菨軪軬鯮듰鷲铴闶闸黺ꋼ뻾㤀㔂㈄㘆", a_), global::CommonResources.AcgResources.ID_REJECTENABLE);
					this.dataWidePOP25OTAPRejectEnable_A8671.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.dataWidePOP25OTAPRejectEnable_A8671.DataTransferOrder = 12;
					num = (short)397475844;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
				{
					num = (short)476299884;
					short num3 = num;
					num = (short)1482474092;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_22B;
					default:
						num = (short)1712914432;
						if (num != 0)
						{
						}
						goto IL_276;
					}
					break;
				}
				case 5:
					switch (0)
					{
					case 0:
						goto IL_63;
					}
					continue;
				case 6:
					goto IL_20F;
				case 7:
				{
					num = (short)57606144;
					short num4 = num;
					num = (short)1552089088;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 8:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蟂꓄돆꣈鳊꓌ꯎ듐菒體蟖鋜诞ꃠ돢럤苦菨軪軬鯮듰鷲铴闶闸黺ꋼ뻾㤀㔂㈄㘆", a_)))
					{
						num = (short)2106654723;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_276;
				case 9:
					goto IL_22B;
				case 10:
					num = (short)1670905865;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蟂꓄돆꣈鳊꓌ꯎ듐菒體蟖鳜꫞闠賢럤苦髨軪駬ꫮ鿰鋲韴鯶鳸ꓺ볼쳾㘀㄂㜄㘆", a_)))
					{
						num = (short)40632322;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_351;
				case 12:
					this.dataWidePOP25OTAPIndications_A8670 = new global::AcpBusinessLayer.AcpSparseLOVField(1, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.DataWide.LOVs.indexDataWidePOP25OTAPIndications_A8670LovStrs, global::Motorola.MackinawCPS.CoreFeatures.DataWide.LOVs.idDataWidePOP25OTAPIndications_A8670LovStrs), this, global::AllFeatures.CodeplugGuid.b("蟂꓄돆꣈鳊꓌ꯎ듐菒體蟖鋜诞ꃠ돢곤触跨苪軬軮藰髲髴駶諸ꓺ볼쟾㜀㐂㔄", a_), global::CommonResources.AcgResources.ID_INDICATIONS, global::Motorola.MackinawCPS.CoreFeatures.DataWide.LOVs.DataWidePOP25OTAPIndications_A8670LovStrs);
					this.dataWidePOP25OTAPIndications_A8670.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.dataWidePOP25OTAPIndications_A8670.DataTransferOrder = 4;
					num = (short)204144641;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_63:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1411121162;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_127:
				num = (short)1918238728;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_22B:
				if (producerFields != null)
				{
					num = (short)1673396231;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_276:
				num = (short)1185087489;
				if (num != 0)
				{
				}
				num = (short)266665995;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_20F:
			IL_351:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鏂諄韆﯈ﻊ蓒볔ꗖ볘럚룜곞鋠쏢뗤闦蛨質鿬軮鳰黲鳴駶黸", a_);
			base.Id = 10065;
			base.UIName = global::CommonResources.AcgResources.ID_POP25WIRELESSPROGRAMMING;
			base.DataTransferOrder = 2;
		}

		// Token: 0x0600A8A2 RID: 43170 RVA: 0x009CA804 File Offset: 0x009C8A04
		public override void PopulateReferences()
		{
			short num = (short)1860842871;
			short num2 = num;
			num = (short)1768240503;
			switch (num2 == num)
			{
			}
			num = (short)1766588417;
			if (num != 0)
			{
			}
			num = (short)1690763264;
			if (num != 0)
			{
			}
			num = (short)1458765824;
			short num3 = num;
		}

		// Token: 0x0600A8A3 RID: 43171 RVA: 0x009CA8AC File Offset: 0x009C8AAC
		public override void DropReferences()
		{
			short num = (short)377077096;
			short num2 = num;
			num = (short)308526440;
			switch (num2 == num)
			{
			}
			num = (short)1927741441;
			if (num != 0)
			{
			}
			num = (short)706609152;
			if (num != 0)
			{
			}
			num = (short)823394304;
			short num3 = num;
		}

		// Token: 0x0600A8A4 RID: 43172 RVA: 0x009CA958 File Offset: 0x009C8B58
		public override void SetConstraints()
		{
			short num = (short)1438580737;
			if (num != 0)
			{
			}
			num = (short)1435886974;
			short num2 = num;
			num = (short)1990059390;
			switch (num2 == num)
			{
			}
			num = (short)1821769728;
			if (num != 0)
			{
			}
			num = (short)1971060736;
			short num3 = num;
			this.dataWidePOP25OTAPRejectEnable_A8671.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.ConListinfoRadWideOtapIndicationsIsAlertDisplay);
		}

		// Token: 0x0600A8A5 RID: 43173 RVA: 0x009CAA18 File Offset: 0x009C8C18
		public override void SetupDependencies()
		{
			short num = (short)534338498;
			short num2 = num;
			num = (short)1640520642;
			switch (num2 == num)
			{
			}
			num = (short)1257504769;
			if (num != 0)
			{
			}
			num = (short)1268121600;
			if (num != 0)
			{
			}
			num = (short)901120000;
			short num3 = num;
			this.dataWidePOP25OTAPIndications_A8670.AddDependentObject(this.dataWidePOP25OTAPRejectEnable_A8671);
		}

		// Token: 0x170054AD RID: 21677
		// (get) Token: 0x0600A8A6 RID: 43174 RVA: 0x009CAAD8 File Offset: 0x009C8CD8
		public bool HasDiffs
		{
			get
			{
				short num = (short)1152125073;
				short num2 = num;
				num = (short)1426131089;
				switch (num2 == num)
				{
				}
				num = (short)446038016;
				if (num != 0)
				{
				}
				num = (short)1485897729;
				if (num != 0)
				{
				}
				num = (short)1163788288;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x170054AE RID: 21678
		// (get) Token: 0x0600A8A7 RID: 43175 RVA: 0x009CAB88 File Offset: 0x009C8D88
		// (set) Token: 0x0600A8A8 RID: 43176 RVA: 0x009CAC38 File Offset: 0x009C8E38
		public int DataWidePOP25OTAPIndications_A8670Value
		{
			get
			{
				short num = (short)1124466689;
				if (num != 0)
				{
				}
				num = (short)1326774660;
				short num2 = num;
				num = (short)1568930180;
				switch (num2 == num)
				{
				}
				num = (short)1585250304;
				if (num != 0)
				{
				}
				num = (short)396165120;
				short num3 = num;
				return this.dataWidePOP25OTAPIndications_A8670.Value;
			}
			set
			{
				short num = (short)1881142840;
				short num2 = num;
				num = (short)1652946488;
				switch (num2 == num)
				{
				}
				num = (short)311296000;
				if (num != 0)
				{
				}
				num = (short)270139393;
				if (num != 0)
				{
				}
				num = (short)1371996160;
				short num3 = num;
				this.dataWidePOP25OTAPIndications_A8670.Value = value;
			}
		}

		// Token: 0x170054AF RID: 21679
		// (get) Token: 0x0600A8A9 RID: 43177 RVA: 0x009CACF0 File Offset: 0x009C8EF0
		// (set) Token: 0x0600A8AA RID: 43178 RVA: 0x009CADA8 File Offset: 0x009C8FA8
		public string DataWidePOP25OTAPIndications_A8670_UIValue
		{
			get
			{
				short num = (short)1123287041;
				if (num != 0)
				{
				}
				num = (short)1898245992;
				short num2 = num;
				num = (short)844230504;
				switch (num2 == num)
				{
				}
				num = (short)556007424;
				if (num != 0)
				{
				}
				num = (short)1904345088;
				short num3 = num;
				return this.dataWidePOP25OTAPIndications_A8670.UIValue;
			}
			set
			{
				short num = (short)1111002902;
				short num2 = num;
				num = (short)665751318;
				switch (num2 == num)
				{
				}
				num = (short)1181483008;
				if (num != 0)
				{
				}
				num = (short)1538785281;
				if (num != 0)
				{
				}
				num = (short)160563200;
				short num3 = num;
				this.dataWidePOP25OTAPIndications_A8670.UIValue = value;
			}
		}

		// Token: 0x170054B0 RID: 21680
		// (get) Token: 0x0600A8AB RID: 43179 RVA: 0x009CAE5C File Offset: 0x009C905C
		public global::AcpBusinessLayer.AcpListField DataWidePOP25OTAPIndications_A8670
		{
			get
			{
				short num = (short)805302048;
				short num2 = num;
				num = (short)1565257504;
				switch (num2 == num)
				{
				}
				num = (short)1776222208;
				if (num != 0)
				{
				}
				num = (short)1928593409;
				if (num != 0)
				{
				}
				num = (short)1846804480;
				short num3 = num;
				return this.dataWidePOP25OTAPIndications_A8670;
			}
		}

		// Token: 0x170054B1 RID: 21681
		// (get) Token: 0x0600A8AC RID: 43180 RVA: 0x009CAF0C File Offset: 0x009C910C
		// (set) Token: 0x0600A8AD RID: 43181 RVA: 0x009CAFC4 File Offset: 0x009C91C4
		public bool DataWidePOP25OTAPIndications_A8670_Applicable
		{
			get
			{
				short num = (short)1287837120;
				short num2 = num;
				num = (short)1086576064;
				switch (num2 == num)
				{
				}
				num = (short)923533313;
				if (num != 0)
				{
				}
				num = (short)2141978624;
				if (num != 0)
				{
				}
				num = (short)1264713728;
				short num3 = num;
				return this.dataWidePOP25OTAPIndications_A8670.Applicable;
			}
			set
			{
				short num = (short)982921682;
				short num2 = num;
				num = (short)450572754;
				switch (num2 == num)
				{
				}
				num = (short)777322497;
				if (num != 0)
				{
				}
				num = (short)1138819072;
				if (num != 0)
				{
				}
				num = (short)2021588992;
				short num3 = num;
				this.dataWidePOP25OTAPIndications_A8670.Applicable = value;
			}
		}

		// Token: 0x170054B2 RID: 21682
		// (get) Token: 0x0600A8AE RID: 43182 RVA: 0x009CB078 File Offset: 0x009C9278
		// (set) Token: 0x0600A8AF RID: 43183 RVA: 0x009CB12C File Offset: 0x009C932C
		public bool DataWidePOP25OTAPIndications_A8670_Valid
		{
			get
			{
				short num = (short)1680909000;
				short num2 = num;
				num = (short)1105633992;
				switch (num2 == num)
				{
				}
				num = (short)1514143745;
				if (num != 0)
				{
				}
				num = (short)679084032;
				if (num != 0)
				{
				}
				num = (short)485163008;
				short num3 = num;
				return this.dataWidePOP25OTAPIndications_A8670.Valid;
			}
			set
			{
				short num = (short)1513847683;
				short num2 = num;
				num = (short)576355203;
				switch (num2 == num)
				{
				}
				num = (short)1599143936;
				if (num != 0)
				{
				}
				num = (short)383385601;
				if (num != 0)
				{
				}
				num = (short)1478098944;
				short num3 = num;
				this.dataWidePOP25OTAPIndications_A8670.Valid = value;
			}
		}

		// Token: 0x170054B3 RID: 21683
		// (get) Token: 0x0600A8B0 RID: 43184 RVA: 0x009CB1E0 File Offset: 0x009C93E0
		// (set) Token: 0x0600A8B1 RID: 43185 RVA: 0x009CB294 File Offset: 0x009C9494
		public bool DataWidePOP25OTAPIndications_A8670_Visible
		{
			get
			{
				short num = (short)1728821864;
				short num2 = num;
				num = (short)840809064;
				switch (num2 == num)
				{
				}
				num = (short)1095630849;
				if (num != 0)
				{
				}
				num = (short)418316288;
				if (num != 0)
				{
				}
				num = (short)1052966912;
				short num3 = num;
				return this.dataWidePOP25OTAPIndications_A8670.Visible;
			}
			set
			{
				short num = (short)1696268289;
				if (num != 0)
				{
				}
				num = (short)1154023992;
				short num2 = num;
				num = (short)1882849848;
				switch (num2 == num)
				{
				}
				num = (short)1118371840;
				if (num != 0)
				{
				}
				num = (short)251068416;
				short num3 = num;
				this.dataWidePOP25OTAPIndications_A8670.Visible = value;
			}
		}

		// Token: 0x170054B4 RID: 21684
		// (get) Token: 0x0600A8B2 RID: 43186 RVA: 0x009CB34C File Offset: 0x009C954C
		// (set) Token: 0x0600A8B3 RID: 43187 RVA: 0x009CB404 File Offset: 0x009C9604
		public bool DataWidePOP25OTAPIndications_A8670_Editable
		{
			get
			{
				short num = (short)1484409996;
				short num2 = num;
				num = (short)1553616012;
				switch (num2 == num)
				{
				}
				num = (short)1198063617;
				if (num != 0)
				{
				}
				num = (short)1915158528;
				if (num != 0)
				{
				}
				num = (short)998572032;
				short num3 = num;
				return this.dataWidePOP25OTAPIndications_A8670.Editable;
			}
			set
			{
				short num = (short)2092864747;
				short num2 = num;
				num = (short)2002031851;
				switch (num2 == num)
				{
				}
				num = (short)244973568;
				if (num != 0)
				{
				}
				num = (short)640942081;
				if (num != 0)
				{
				}
				num = (short)957743104;
				short num3 = num;
				this.dataWidePOP25OTAPIndications_A8670.Editable = value;
			}
		}

		// Token: 0x170054B5 RID: 21685
		// (get) Token: 0x0600A8B4 RID: 43188 RVA: 0x009CB4B8 File Offset: 0x009C96B8
		internal string DataWidePOP25OTAPIndications_A8670_UILabel
		{
			get
			{
				short num = (short)743505921;
				if (num != 0)
				{
				}
				num = (short)1469286052;
				short num2 = num;
				num = (short)1461356196;
				switch (num2 == num)
				{
				}
				num = (short)884342784;
				if (num != 0)
				{
				}
				num = (short)1501954048;
				short num3 = num;
				return this.dataWidePOP25OTAPIndications_A8670.UIName;
			}
		}

		// Token: 0x170054B6 RID: 21686
		// (get) Token: 0x0600A8B5 RID: 43189 RVA: 0x009CB570 File Offset: 0x009C9770
		// (set) Token: 0x0600A8B6 RID: 43190 RVA: 0x009CB628 File Offset: 0x009C9828
		internal bool DataWidePOP25OTAPIndications_A8670_HiddenStatic
		{
			get
			{
				short num = (short)922818403;
				short num2 = num;
				num = (short)1948587875;
				switch (num2 == num)
				{
				}
				num = (short)462815232;
				if (num != 0)
				{
				}
				num = (short)2015297537;
				if (num != 0)
				{
				}
				num = (short)1582891008;
				short num3 = num;
				return this.dataWidePOP25OTAPIndications_A8670.HiddenStatic;
			}
			set
			{
				short num = (short)1354612769;
				short num2 = num;
				num = (short)1364901921;
				switch (num2 == num)
				{
				}
				num = (short)1407057921;
				if (num != 0)
				{
				}
				num = (short)643956736;
				if (num != 0)
				{
				}
				num = (short)452853760;
				short num3 = num;
				this.dataWidePOP25OTAPIndications_A8670.HiddenStatic = value;
			}
		}

		// Token: 0x170054B7 RID: 21687
		// (get) Token: 0x0600A8B7 RID: 43191 RVA: 0x009CB6DC File Offset: 0x009C98DC
		// (set) Token: 0x0600A8B8 RID: 43192 RVA: 0x009CB790 File Offset: 0x009C9990
		internal bool DataWidePOP25OTAPIndications_A8670_HiddenDynamic
		{
			get
			{
				short num = (short)339718834;
				short num2 = num;
				num = (short)1436857010;
				switch (num2 == num)
				{
				}
				num = (short)269484032;
				if (num != 0)
				{
				}
				num = (short)178323457;
				if (num != 0)
				{
				}
				num = (short)263782400;
				short num3 = num;
				return this.dataWidePOP25OTAPIndications_A8670.HiddenDynamic;
			}
			set
			{
				short num = (short)575066054;
				short num2 = num;
				num = (short)935251910;
				switch (num2 == num)
				{
				}
				num = (short)195952641;
				if (num != 0)
				{
				}
				num = (short)2054356992;
				if (num != 0)
				{
				}
				num = (short)394854400;
				short num3 = num;
				this.dataWidePOP25OTAPIndications_A8670.HiddenDynamic = value;
			}
		}

		// Token: 0x170054B8 RID: 21688
		// (get) Token: 0x0600A8B9 RID: 43193 RVA: 0x009CB844 File Offset: 0x009C9A44
		public bool DataWidePOP25OTAPIndications_A8670_HasDiffs
		{
			get
			{
				short num = (short)1249001155;
				short num2 = num;
				num = (short)1795047107;
				switch (num2 == num)
				{
				}
				num = (short)652410881;
				if (num != 0)
				{
				}
				num = (short)307757056;
				if (num != 0)
				{
				}
				num = (short)568721408;
				short num3 = num;
				return this.dataWidePOP25OTAPIndications_A8670._HasDiffs;
			}
		}

		// Token: 0x170054B9 RID: 21689
		// (get) Token: 0x0600A8BA RID: 43194 RVA: 0x009CB8FC File Offset: 0x009C9AFC
		// (set) Token: 0x0600A8BB RID: 43195 RVA: 0x009CB9B0 File Offset: 0x009C9BB0
		public bool DataWidePOP25OTAPRejectEnable_A8671Value
		{
			get
			{
				short num = (short)1989983333;
				short num2 = num;
				num = (short)1733147749;
				switch (num2 == num)
				{
				}
				num = (short)1119879169;
				if (num != 0)
				{
				}
				num = (short)505544704;
				if (num != 0)
				{
				}
				num = (short)42270720;
				short num3 = num;
				return this.dataWidePOP25OTAPRejectEnable_A8671.Value;
			}
			set
			{
				short num = (short)140651676;
				short num2 = num;
				num = (short)1637297308;
				switch (num2 == num)
				{
				}
				num = (short)1006043136;
				if (num != 0)
				{
				}
				num = (short)1838546945;
				if (num != 0)
				{
				}
				num = (short)442171392;
				short num3 = num;
				this.dataWidePOP25OTAPRejectEnable_A8671.Value = value;
			}
		}

		// Token: 0x170054BA RID: 21690
		// (get) Token: 0x0600A8BC RID: 43196 RVA: 0x009CBA68 File Offset: 0x009C9C68
		public global::AcpBusinessLayer.AcpField<bool> DataWidePOP25OTAPRejectEnable_A8671
		{
			get
			{
				short num = (short)1590690541;
				short num2 = num;
				num = (short)1431110381;
				switch (num2 == num)
				{
				}
				num = (short)249757696;
				if (num != 0)
				{
				}
				num = (short)2013528065;
				if (num != 0)
				{
				}
				num = (short)1085538304;
				short num3 = num;
				return this.dataWidePOP25OTAPRejectEnable_A8671;
			}
		}

		// Token: 0x170054BB RID: 21691
		// (get) Token: 0x0600A8BD RID: 43197 RVA: 0x009CBB18 File Offset: 0x009C9D18
		// (set) Token: 0x0600A8BE RID: 43198 RVA: 0x009CBBD0 File Offset: 0x009C9DD0
		public bool DataWidePOP25OTAPRejectEnable_A8671_UIValue
		{
			get
			{
				short num = (short)1618358255;
				short num2 = num;
				num = (short)1707814895;
				switch (num2 == num)
				{
				}
				num = (short)601030657;
				if (num != 0)
				{
				}
				num = (short)310181888;
				if (num != 0)
				{
				}
				num = (short)1757675520;
				short num3 = num;
				return this.dataWidePOP25OTAPRejectEnable_A8671.Value;
			}
			set
			{
				short num = (short)1485677183;
				short num2 = num;
				num = (short)421044863;
				switch (num2 == num)
				{
				}
				num = (short)443023361;
				if (num != 0)
				{
				}
				num = (short)900923392;
				if (num != 0)
				{
				}
				num = (short)173539328;
				short num3 = num;
				this.dataWidePOP25OTAPRejectEnable_A8671.Value = value;
			}
		}

		// Token: 0x170054BC RID: 21692
		// (get) Token: 0x0600A8BF RID: 43199 RVA: 0x009CBC84 File Offset: 0x009C9E84
		// (set) Token: 0x0600A8C0 RID: 43200 RVA: 0x009CBD3C File Offset: 0x009C9F3C
		public bool DataWidePOP25OTAPRejectEnable_A8671_Applicable
		{
			get
			{
				short num = (short)210688710;
				short num2 = num;
				num = (short)1384241862;
				switch (num2 == num)
				{
				}
				num = (short)1359609857;
				if (num != 0)
				{
				}
				num = (short)739049472;
				if (num != 0)
				{
				}
				num = (short)1173880832;
				short num3 = num;
				return this.dataWidePOP25OTAPRejectEnable_A8671.Applicable;
			}
			set
			{
				short num = (short)1494302171;
				short num2 = num;
				num = (short)724581851;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1119420416;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)116981761;
				if (num != 0)
				{
				}
				num = (short)1765736448;
				if (num != 0)
				{
				}
				this.dataWidePOP25OTAPRejectEnable_A8671.Applicable = value;
			}
		}

		// Token: 0x170054BD RID: 21693
		// (get) Token: 0x0600A8C1 RID: 43201 RVA: 0x009CBDF4 File Offset: 0x009C9FF4
		// (set) Token: 0x0600A8C2 RID: 43202 RVA: 0x009CBEAC File Offset: 0x009CA0AC
		public bool DataWidePOP25OTAPRejectEnable_A8671_Valid
		{
			get
			{
				short num = (short)68341278;
				short num2 = num;
				num = (short)278122014;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1109327872;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1867644929;
				if (num != 0)
				{
				}
				num = (short)1851064320;
				if (num != 0)
				{
				}
				return this.dataWidePOP25OTAPRejectEnable_A8671.Valid;
			}
			set
			{
				short num = (short)517001537;
				short num2 = num;
				num = (short)1649267009;
				switch (num2 == num)
				{
				default:
				{
					num = (short)558497792;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)330104832;
				if (num != 0)
				{
				}
				num = (short)1395195905;
				if (num != 0)
				{
				}
				this.dataWidePOP25OTAPRejectEnable_A8671.Valid = value;
			}
		}

		// Token: 0x170054BE RID: 21694
		// (get) Token: 0x0600A8C3 RID: 43203 RVA: 0x009CBF60 File Offset: 0x009CA160
		// (set) Token: 0x0600A8C4 RID: 43204 RVA: 0x009CC018 File Offset: 0x009CA218
		public bool DataWidePOP25OTAPRejectEnable_A8671_Visible
		{
			get
			{
				short num = (short)714179557;
				short num2 = num;
				num = (short)869368805;
				switch (num2 == num)
				{
				default:
				{
					num = (short)539033600;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1838743553;
				if (num != 0)
				{
				}
				num = (short)1949827072;
				if (num != 0)
				{
				}
				return this.dataWidePOP25OTAPRejectEnable_A8671.Visible;
			}
			set
			{
				short num = (short)702884898;
				short num2 = num;
				num = (short)198978594;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2091515904;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)272891905;
				if (num != 0)
				{
				}
				num = (short)1630339072;
				if (num != 0)
				{
				}
				this.dataWidePOP25OTAPRejectEnable_A8671.Visible = value;
			}
		}

		// Token: 0x170054BF RID: 21695
		// (get) Token: 0x0600A8C5 RID: 43205 RVA: 0x009CC0CC File Offset: 0x009CA2CC
		// (set) Token: 0x0600A8C6 RID: 43206 RVA: 0x009CC180 File Offset: 0x009CA380
		public bool DataWidePOP25OTAPRejectEnable_A8671_Editable
		{
			get
			{
				short num = (short)1885898326;
				short num2 = num;
				num = (short)1769375318;
				switch (num2 == num)
				{
				default:
				{
					num = (short)270139392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)850001920;
				if (num != 0)
				{
				}
				num = (short)1947205633;
				if (num != 0)
				{
				}
				return this.dataWidePOP25OTAPRejectEnable_A8671.Editable;
			}
			set
			{
				short num = (short)321030614;
				short num2 = num;
				num = (short)825264598;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1471676416;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)505151489;
				if (num != 0)
				{
				}
				num = (short)688259072;
				if (num != 0)
				{
				}
				this.dataWidePOP25OTAPRejectEnable_A8671.Editable = value;
			}
		}

		// Token: 0x170054C0 RID: 21696
		// (get) Token: 0x0600A8C7 RID: 43207 RVA: 0x009CC234 File Offset: 0x009CA434
		internal string DataWidePOP25OTAPRejectEnable_A8671_UILabel
		{
			get
			{
				short num = (short)1260203291;
				short num2 = num;
				num = (short)1623338267;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1302069248;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1845166080;
				if (num != 0)
				{
				}
				num = (short)995426305;
				if (num != 0)
				{
				}
				return this.dataWidePOP25OTAPRejectEnable_A8671.UIName;
			}
		}

		// Token: 0x170054C1 RID: 21697
		// (get) Token: 0x0600A8C8 RID: 43208 RVA: 0x009CC2E8 File Offset: 0x009CA4E8
		// (set) Token: 0x0600A8C9 RID: 43209 RVA: 0x009CC39C File Offset: 0x009CA59C
		internal bool DataWidePOP25OTAPRejectEnable_A8671_HiddenStatic
		{
			get
			{
				short num = (short)136676716;
				short num2 = num;
				num = (short)1393395052;
				switch (num2 == num)
				{
				default:
				{
					num = (short)572719104;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1782972416;
				if (num != 0)
				{
				}
				num = (short)1295056897;
				if (num != 0)
				{
				}
				return this.dataWidePOP25OTAPRejectEnable_A8671.HiddenStatic;
			}
			set
			{
				short num = (short)1713491243;
				short num2 = num;
				num = (short)952618283;
				switch (num2 == num)
				{
				default:
				{
					num = (short)499253248;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1208680449;
				if (num != 0)
				{
				}
				num = (short)1594621952;
				if (num != 0)
				{
				}
				this.dataWidePOP25OTAPRejectEnable_A8671.HiddenStatic = value;
			}
		}

		// Token: 0x170054C2 RID: 21698
		// (get) Token: 0x0600A8CA RID: 43210 RVA: 0x009CC450 File Offset: 0x009CA650
		// (set) Token: 0x0600A8CB RID: 43211 RVA: 0x009CC504 File Offset: 0x009CA704
		internal bool DataWidePOP25OTAPRejectEnable_A8671_HiddenDynamic
		{
			get
			{
				short num = (short)1186916987;
				short num2 = num;
				num = (short)2089937531;
				switch (num2 == num)
				{
				default:
				{
					num = (short)556204032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)562167809;
				if (num != 0)
				{
				}
				num = (short)1416495104;
				if (num != 0)
				{
				}
				return this.dataWidePOP25OTAPRejectEnable_A8671.HiddenDynamic;
			}
			set
			{
				short num = (short)802304896;
				short num2 = num;
				num = (short)299447168;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1215365120;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)32636929;
				if (num != 0)
				{
				}
				num = (short)1325072384;
				if (num != 0)
				{
				}
				this.dataWidePOP25OTAPRejectEnable_A8671.HiddenDynamic = value;
			}
		}

		// Token: 0x170054C3 RID: 21699
		// (get) Token: 0x0600A8CC RID: 43212 RVA: 0x009CC5B8 File Offset: 0x009CA7B8
		public bool DataWidePOP25OTAPRejectEnable_A8671_HasDiffs
		{
			get
			{
				short num = (short)1689913695;
				short num2 = num;
				num = (short)2078673247;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1892876288;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1727528961;
				if (num != 0)
				{
				}
				num = (short)224788480;
				if (num != 0)
				{
				}
				return this.dataWidePOP25OTAPRejectEnable_A8671._HasDiffs;
			}
		}

		// Token: 0x170054C4 RID: 21700
		// (get) Token: 0x0600A8CD RID: 43213 RVA: 0x009CC66C File Offset: 0x009CA86C
		// (set) Token: 0x0600A8CE RID: 43214 RVA: 0x009CC720 File Offset: 0x009CA920
		public bool DataWidePOP25AutoResetEnable_A37221Value
		{
			get
			{
				short num = (short)668147441;
				short num2 = num;
				num = (short)460922609;
				switch (num2 == num)
				{
				default:
				{
					num = (short)175702016;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)179372033;
				if (num != 0)
				{
				}
				num = (short)485556224;
				if (num != 0)
				{
				}
				return this.dataWidePOP25AutoResetEnable_A37221.Value;
			}
			set
			{
				short num = (short)838270977;
				if (num != 0)
				{
				}
				num = (short)1744044032;
				short num2 = num;
				num = (short)151137246;
				short num3 = num;
				num = (short)916532190;
				switch (num3 == num)
				{
				}
				num = (short)63963136;
				if (num != 0)
				{
				}
				this.dataWidePOP25AutoResetEnable_A37221.Value = value;
			}
		}

		// Token: 0x170054C5 RID: 21701
		// (get) Token: 0x0600A8CF RID: 43215 RVA: 0x009CC7D4 File Offset: 0x009CA9D4
		public global::AcpBusinessLayer.AcpField<bool> DataWidePOP25AutoResetEnable_A37221
		{
			get
			{
				short num = (short)2051538945;
				if (num != 0)
				{
				}
				num = (short)106168320;
				short num2 = num;
				num = (short)1798243152;
				short num3 = num;
				num = (short)738263888;
				switch (num3 == num)
				{
				}
				num = (short)153944064;
				if (num != 0)
				{
				}
				return this.dataWidePOP25AutoResetEnable_A37221;
			}
		}

		// Token: 0x170054C6 RID: 21702
		// (get) Token: 0x0600A8D0 RID: 43216 RVA: 0x009CC880 File Offset: 0x009CAA80
		// (set) Token: 0x0600A8D1 RID: 43217 RVA: 0x009CC934 File Offset: 0x009CAB34
		public bool DataWidePOP25AutoResetEnable_A37221_UIValue
		{
			get
			{
				short num = (short)260840741;
				short num2 = num;
				num = (short)1030495525;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1525284864;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)415891456;
				if (num != 0)
				{
				}
				num = (short)1078853633;
				if (num != 0)
				{
				}
				return this.dataWidePOP25AutoResetEnable_A37221.Value;
			}
			set
			{
				short num = (short)1750920580;
				short num2 = num;
				num = (short)103280004;
				switch (num2 == num)
				{
				default:
				{
					num = (short)949288960;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1096744960;
				if (num != 0)
				{
				}
				num = (short)771948545;
				if (num != 0)
				{
				}
				this.dataWidePOP25AutoResetEnable_A37221.Value = value;
			}
		}

		// Token: 0x170054C7 RID: 21703
		// (get) Token: 0x0600A8D2 RID: 43218 RVA: 0x009CC9E8 File Offset: 0x009CABE8
		// (set) Token: 0x0600A8D3 RID: 43219 RVA: 0x009CCA9C File Offset: 0x009CAC9C
		public bool DataWidePOP25AutoResetEnable_A37221_Applicable
		{
			get
			{
				short num = (short)1763619955;
				short num2 = num;
				num = (short)1164555379;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1687420928;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)633536513;
				if (num != 0)
				{
				}
				num = (short)898826240;
				if (num != 0)
				{
				}
				return this.dataWidePOP25AutoResetEnable_A37221.Applicable;
			}
			set
			{
				short num = (short)172422715;
				short num2 = num;
				num = (short)86439483;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1186136064;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)661323777;
				if (num != 0)
				{
				}
				num = (short)726073344;
				if (num != 0)
				{
				}
				this.dataWidePOP25AutoResetEnable_A37221.Applicable = value;
			}
		}

		// Token: 0x170054C8 RID: 21704
		// (get) Token: 0x0600A8D4 RID: 43220 RVA: 0x009CCB50 File Offset: 0x009CAD50
		// (set) Token: 0x0600A8D5 RID: 43221 RVA: 0x009CCC08 File Offset: 0x009CAE08
		public bool DataWidePOP25AutoResetEnable_A37221_Valid
		{
			get
			{
				short num = (short)805809154;
				short num2 = num;
				num = (short)1574677506;
				switch (num2 == num)
				{
				default:
				{
					num = (short)156434432;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1189150721;
				if (num != 0)
				{
				}
				num = (short)768868352;
				if (num != 0)
				{
				}
				return this.dataWidePOP25AutoResetEnable_A37221.Valid;
			}
			set
			{
				short num = (short)1998756452;
				short num2 = num;
				num = (short)178100836;
				switch (num2 == num)
				{
				default:
				{
					num = (short)862912512;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1852178433;
				if (num != 0)
				{
				}
				num = (short)500891648;
				if (num != 0)
				{
				}
				this.dataWidePOP25AutoResetEnable_A37221.Valid = value;
			}
		}

		// Token: 0x170054C9 RID: 21705
		// (get) Token: 0x0600A8D6 RID: 43222 RVA: 0x009CCCC0 File Offset: 0x009CAEC0
		// (set) Token: 0x0600A8D7 RID: 43223 RVA: 0x009CCD74 File Offset: 0x009CAF74
		public bool DataWidePOP25AutoResetEnable_A37221_Visible
		{
			get
			{
				short num = (short)192537281;
				short num2 = num;
				num = (short)845079233;
				switch (num2 == num)
				{
				default:
				{
					num = (short)50724864;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)20512769;
				if (num != 0)
				{
				}
				num = (short)2025259008;
				if (num != 0)
				{
				}
				return this.dataWidePOP25AutoResetEnable_A37221.Visible;
			}
			set
			{
				short num = (short)611385345;
				if (num != 0)
				{
				}
				num = (short)1488912384;
				short num2 = num;
				num = (short)1205121619;
				short num3 = num;
				num = (short)755479123;
				switch (num3 == num)
				{
				}
				num = (short)1367343104;
				if (num != 0)
				{
				}
				this.dataWidePOP25AutoResetEnable_A37221.Visible = value;
			}
		}

		// Token: 0x170054CA RID: 21706
		// (get) Token: 0x0600A8D8 RID: 43224 RVA: 0x009CCE2C File Offset: 0x009CB02C
		// (set) Token: 0x0600A8D9 RID: 43225 RVA: 0x009CCEE0 File Offset: 0x009CB0E0
		public bool DataWidePOP25AutoResetEnable_A37221_Editable
		{
			get
			{
				short num = (short)998113867;
				short num2 = num;
				num = (short)1825178187;
				switch (num2 == num)
				{
				default:
				{
					num = (short)402128896;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1928724481;
				if (num != 0)
				{
				}
				num = (short)1797259264;
				if (num != 0)
				{
				}
				return this.dataWidePOP25AutoResetEnable_A37221.Editable;
			}
			set
			{
				short num = (short)1440056005;
				short num2 = num;
				num = (short)1771995845;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1056899072;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1988689921;
				if (num != 0)
				{
				}
				num = (short)1975123968;
				if (num != 0)
				{
				}
				this.dataWidePOP25AutoResetEnable_A37221.Editable = value;
			}
		}

		// Token: 0x170054CB RID: 21707
		// (get) Token: 0x0600A8DA RID: 43226 RVA: 0x009CCF94 File Offset: 0x009CB194
		internal string DataWidePOP25AutoResetEnable_A37221_UILabel
		{
			get
			{
				short num = (short)2053893537;
				short num2 = num;
				num = (short)745008545;
				switch (num2 == num)
				{
				default:
				{
					num = (short)334168064;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1308426241;
				if (num != 0)
				{
				}
				num = (short)1046478848;
				if (num != 0)
				{
				}
				return this.dataWidePOP25AutoResetEnable_A37221.UIName;
			}
		}

		// Token: 0x170054CC RID: 21708
		// (get) Token: 0x0600A8DB RID: 43227 RVA: 0x009CD04C File Offset: 0x009CB24C
		// (set) Token: 0x0600A8DC RID: 43228 RVA: 0x009CD100 File Offset: 0x009CB300
		internal bool DataWidePOP25AutoResetEnable_A37221_HiddenStatic
		{
			get
			{
				short num = (short)1606723259;
				short num2 = num;
				num = (short)1966712507;
				switch (num2 == num)
				{
				default:
				{
					num = (short)685309952;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1207107585;
				if (num != 0)
				{
				}
				num = (short)212008960;
				if (num != 0)
				{
				}
				return this.dataWidePOP25AutoResetEnable_A37221.HiddenStatic;
			}
			set
			{
				short num = (short)708878172;
				short num2 = num;
				num = (short)1395236700;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1964572672;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1816985600;
				if (num != 0)
				{
				}
				num = (short)506003457;
				if (num != 0)
				{
				}
				this.dataWidePOP25AutoResetEnable_A37221.HiddenStatic = value;
			}
		}

		// Token: 0x170054CD RID: 21709
		// (get) Token: 0x0600A8DD RID: 43229 RVA: 0x009CD1B4 File Offset: 0x009CB3B4
		// (set) Token: 0x0600A8DE RID: 43230 RVA: 0x009CD26C File Offset: 0x009CB46C
		internal bool DataWidePOP25AutoResetEnable_A37221_HiddenDynamic
		{
			get
			{
				short num = (short)386259957;
				short num2 = num;
				num = (short)2102057973;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1683685376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1880686592;
				if (num != 0)
				{
				}
				num = (short)1886257153;
				if (num != 0)
				{
				}
				return this.dataWidePOP25AutoResetEnable_A37221.HiddenDynamic;
			}
			set
			{
				short num = (short)12842646;
				short num2 = num;
				num = (short)1752692374;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1566179328;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)519962625;
				if (num != 0)
				{
				}
				num = (short)904069120;
				if (num != 0)
				{
				}
				this.dataWidePOP25AutoResetEnable_A37221.HiddenDynamic = value;
			}
		}

		// Token: 0x170054CE RID: 21710
		// (get) Token: 0x0600A8DF RID: 43231 RVA: 0x009CD320 File Offset: 0x009CB520
		public bool DataWidePOP25AutoResetEnable_A37221_HasDiffs
		{
			get
			{
				short num = (short)526763592;
				short num2 = num;
				num = (short)1884341832;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1266024448;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2028273665;
				if (num != 0)
				{
				}
				num = (short)251920384;
				if (num != 0)
				{
				}
				return this.dataWidePOP25AutoResetEnable_A37221._HasDiffs;
			}
		}

		// Token: 0x0600A8E0 RID: 43232 RVA: 0x009CD3D4 File Offset: 0x009CB5D4
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
					num2 = (short)1575682049;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_111;
				case 2:
					if (base.ParentRecset != null)
					{
						num2 = (short)484507648;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_13C;
				case 3:
				{
					num2 = (short)723209448;
					short num3 = num2;
					num2 = (short)1876905192;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_111;
					default:
						goto IL_BA;
					}
					break;
				}
				case 4:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)1885732867;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_24;
				IL_111:
				if (base.ParentRecset.ContainerDoc == null)
				{
					goto IL_13C;
				}
				num2 = (short)184745988;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_BA:
			num2 = (short)59310081;
			if (num2 != 0)
			{
			}
			num2 = (short)191496192;
			if (num2 != 0)
			{
			}
			IL_13C:
			num2 = (short)1335951360;
			short num4 = num2;
			return result;
			IL_24:
			result = null;
			num2 = (short)516685826;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0400513C RID: 20796
		private global::AcpBusinessLayer.AcpListField dataWidePOP25OTAPIndications_A8670;

		// Token: 0x0400513D RID: 20797
		private global::AcpBusinessLayer.AcpField<bool> dataWidePOP25OTAPRejectEnable_A8671;

		// Token: 0x0400513E RID: 20798
		private global::AcpBusinessLayer.AcpField<bool> dataWidePOP25AutoResetEnable_A37221;
	}
}
