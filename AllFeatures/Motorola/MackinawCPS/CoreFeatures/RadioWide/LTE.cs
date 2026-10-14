using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.RadioWide
{
	// Token: 0x0200017B RID: 379
	[global::System.Serializable]
	public class LTE : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06003DD8 RID: 15832 RVA: 0x003995A8 File Offset: 0x003977A8
		public LTE(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06003DD9 RID: 15833 RVA: 0x003995C4 File Offset: 0x003977C4
		protected LTE(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06003DDA RID: 15834 RVA: 0x003995DC File Offset: 0x003977DC
		public override void Init()
		{
			int a_ = 0;
			short num = (short)2106523648;
			short num2 = num;
			num = (short)1640199888;
			short num3 = num;
			num = (short)136935120;
			switch (num3 == num)
			{
			}
			num = (short)2008088576;
			if (num != 0)
			{
			}
			num = (short)558366721;
			if (num != 0)
			{
			}
			this.radWideLabtoolLTEUsed_A42064 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌菎냐뇒ꇔ룖뛘럚釜诞ꓠ뛢雤苦跨듪곬\udbee쏰쏲쏴쏶", a_), global::CommonResources.AcgResources.ID_LTEUSED);
			this.radWideLabtoolLTEUsed_A42064.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radWideLabtoolLTEUsed_A42064.DataTransferOrder = -1;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("跀韂胄", a_);
			base.Id = 10772;
			base.UIName = global::CommonResources.AcgResources.ID_LTE;
			base.DataTransferOrder = 20;
		}

		// Token: 0x06003DDB RID: 15835 RVA: 0x003996FC File Offset: 0x003978FC
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 9;
			short num = (short)1668218880;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_4B;
					}
					continue;
				case 1:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("飉귋꫍蟏믑냓돕铗믙뻛ꫝ迟跡裣ꫥ볧꿩맫鷭闯雱꯳럵쳷죹쳻죽㓿", a_)))
					{
						num = (short)629407750;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1E0;
				case 2:
					goto IL_6A;
				case 3:
					goto IL_110;
				case 4:
					if (producerFields != null)
					{
						num = (short)1413480453;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1E0;
				case 5:
				{
					num = (short)1986121993;
					short num3 = num;
					num = (short)1715130633;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_6A;
					default:
						num = (short)363724800;
						if (num != 0)
						{
						}
						num = (short)125566977;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 6:
					this.radWideLabtoolLTEUsed_A42064 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("飉귋꫍蟏믑냓돕铗믙뻛ꫝ迟跡裣ꫥ볧꿩맫鷭闯雱꯳럵쳷죹쳻죽㓿", a_), global::CommonResources.AcgResources.ID_LTEUSED);
					this.radWideLabtoolLTEUsed_A42064.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radWideLabtoolLTEUsed_A42064.DataTransferOrder = -1;
					num = (short)1943207939;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_4B:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1125318658;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_6A:
				num = (short)1931476992;
				short num4 = num;
				num = (short)1693843457;
				if (num != 0)
				{
				}
				num = (short)1783300100;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_110:
			IL_1E0:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("蛉飋词", a_);
			base.Id = 10772;
			base.UIName = global::CommonResources.AcgResources.ID_LTE;
			base.DataTransferOrder = 20;
		}

		// Token: 0x06003DDC RID: 15836 RVA: 0x0039991C File Offset: 0x00397B1C
		public override void PopulateReferences()
		{
			short num = (short)61014016;
			short num2 = num;
			num = (short)1237116151;
			short num3 = num;
			num = (short)1588782327;
			switch (num3 == num)
			{
			}
			num = (short)977534977;
			if (num != 0)
			{
			}
			num = (short)1904738304;
			if (num != 0)
			{
			}
		}

		// Token: 0x06003DDD RID: 15837 RVA: 0x003999C4 File Offset: 0x00397BC4
		public override void DropReferences()
		{
			short num = (short)1742340096;
			short num2 = num;
			num = (short)818005734;
			short num3 = num;
			num = (short)2040252134;
			switch (num3 == num)
			{
			}
			num = (short)1826095105;
			if (num != 0)
			{
			}
			num = (short)2113929216;
			if (num != 0)
			{
			}
		}

		// Token: 0x06003DDE RID: 15838 RVA: 0x00399A6C File Offset: 0x00397C6C
		public override void SetConstraints()
		{
			short num = (short)687865856;
			short num2 = num;
			num = (short)774163475;
			short num3 = num;
			num = (short)1693043731;
			switch (num3 == num)
			{
			}
			num = (short)1568014336;
			if (num != 0)
			{
			}
			num = (short)1904345089;
			if (num != 0)
			{
			}
			this.radWideLabtoolLTEUsed_A42064.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
		}

		// Token: 0x06003DDF RID: 15839 RVA: 0x00399B2C File Offset: 0x00397D2C
		public override void SetupDependencies()
		{
			short num = (short)1223491584;
			short num2 = num;
			num = (short)1810532017;
			short num3 = num;
			num = (short)926385841;
			switch (num3 == num)
			{
			}
			num = (short)655228928;
			if (num != 0)
			{
			}
			num = (short)441450497;
			if (num != 0)
			{
			}
		}

		// Token: 0x17001FC8 RID: 8136
		// (get) Token: 0x06003DE0 RID: 15840 RVA: 0x00399BD8 File Offset: 0x00397DD8
		public bool HasDiffs
		{
			get
			{
				short num = (short)1826553856;
				short num2 = num;
				num = (short)572890923;
				short num3 = num;
				num = (short)1079811883;
				switch (num3 == num)
				{
				}
				num = (short)1862664193;
				if (num != 0)
				{
				}
				num = (short)1684471808;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17001FC9 RID: 8137
		// (get) Token: 0x06003DE1 RID: 15841 RVA: 0x00399C88 File Offset: 0x00397E88
		// (set) Token: 0x06003DE2 RID: 15842 RVA: 0x00399D3C File Offset: 0x00397F3C
		public bool RadWideLabtoolLTEUsed_A42064Value
		{
			get
			{
				short num = (short)1285619712;
				short num2 = num;
				num = (short)143341696;
				short num3 = num;
				num = (short)1524643968;
				switch (num3 == num)
				{
				}
				num = (short)1802960897;
				if (num != 0)
				{
				}
				num = (short)1043660800;
				if (num != 0)
				{
				}
				return this.radWideLabtoolLTEUsed_A42064.Value;
			}
			set
			{
				short num = (short)1572339712;
				short num2 = num;
				num = (short)1727856641;
				if (num != 0)
				{
				}
				num = (short)1429638819;
				short num3 = num;
				num = (short)1048284835;
				switch (num3 == num)
				{
				}
				num = (short)845217792;
				if (num != 0)
				{
				}
				this.radWideLabtoolLTEUsed_A42064.Value = value;
			}
		}

		// Token: 0x17001FCA RID: 8138
		// (get) Token: 0x06003DE3 RID: 15843 RVA: 0x00399DF4 File Offset: 0x00397FF4
		public global::AcpBusinessLayer.AcpField<bool> RadWideLabtoolLTEUsed_A42064
		{
			get
			{
				short num = (short)1029701632;
				short num2 = num;
				num = (short)2055405569;
				if (num != 0)
				{
				}
				num = (short)1112825890;
				short num3 = num;
				num = (short)2143445026;
				switch (num3 == num)
				{
				}
				num = (short)965017600;
				if (num != 0)
				{
				}
				return this.radWideLabtoolLTEUsed_A42064;
			}
		}

		// Token: 0x17001FCB RID: 8139
		// (get) Token: 0x06003DE4 RID: 15844 RVA: 0x00399EA4 File Offset: 0x003980A4
		// (set) Token: 0x06003DE5 RID: 15845 RVA: 0x00399F58 File Offset: 0x00398158
		public bool RadWideLabtoolLTEUsed_A42064_UIValue
		{
			get
			{
				short num = (short)1672019968;
				short num2 = num;
				num = (short)1524349018;
				short num3 = num;
				num = (short)1398716506;
				switch (num3 == num)
				{
				}
				num = (short)1580335105;
				if (num != 0)
				{
				}
				num = (short)1549008896;
				if (num != 0)
				{
				}
				return this.radWideLabtoolLTEUsed_A42064.Value;
			}
			set
			{
				short num = (short)442302464;
				short num2 = num;
				num = (short)1953096747;
				short num3 = num;
				num = (short)558818347;
				switch (num3 == num)
				{
				}
				num = (short)1382219777;
				if (num != 0)
				{
				}
				num = (short)936116224;
				if (num != 0)
				{
				}
				this.radWideLabtoolLTEUsed_A42064.Value = value;
			}
		}

		// Token: 0x17001FCC RID: 8140
		// (get) Token: 0x06003DE6 RID: 15846 RVA: 0x0039A010 File Offset: 0x00398210
		// (set) Token: 0x06003DE7 RID: 15847 RVA: 0x0039A0C8 File Offset: 0x003982C8
		public bool RadWideLabtoolLTEUsed_A42064_Applicable
		{
			get
			{
				short num = (short)1642594304;
				short num2 = num;
				num = (short)22481103;
				short num3 = num;
				num = (short)1539115215;
				switch (num3 == num)
				{
				}
				num = (short)653918209;
				if (num != 0)
				{
				}
				num = (short)356974592;
				if (num != 0)
				{
				}
				return this.radWideLabtoolLTEUsed_A42064.Applicable;
			}
			set
			{
				short num = (short)1677197312;
				short num2 = num;
				num = (short)1523580929;
				if (num != 0)
				{
				}
				num = (short)1048590025;
				short num3 = num;
				num = (short)119944905;
				switch (num3 == num)
				{
				}
				num = (short)11862016;
				if (num != 0)
				{
				}
				this.radWideLabtoolLTEUsed_A42064.Applicable = value;
			}
		}

		// Token: 0x17001FCD RID: 8141
		// (get) Token: 0x06003DE8 RID: 15848 RVA: 0x0039A180 File Offset: 0x00398380
		// (set) Token: 0x06003DE9 RID: 15849 RVA: 0x0039A238 File Offset: 0x00398438
		public bool RadWideLabtoolLTEUsed_A42064_Valid
		{
			get
			{
				short num = (short)1044840448;
				short num2 = num;
				num = (short)883490212;
				short num3 = num;
				num = (short)2077883812;
				switch (num3 == num)
				{
				}
				num = (short)2003173377;
				if (num != 0)
				{
				}
				num = (short)707919872;
				if (num != 0)
				{
				}
				return this.radWideLabtoolLTEUsed_A42064.Valid;
			}
			set
			{
				short num = (short)1203437568;
				short num2 = num;
				num = (short)1188442429;
				short num3 = num;
				num = (short)1122382141;
				switch (num3 == num)
				{
				}
				num = (short)2067267585;
				if (num != 0)
				{
				}
				num = (short)60096512;
				if (num != 0)
				{
				}
				this.radWideLabtoolLTEUsed_A42064.Valid = value;
			}
		}

		// Token: 0x17001FCE RID: 8142
		// (get) Token: 0x06003DEA RID: 15850 RVA: 0x0039A2EC File Offset: 0x003984EC
		// (set) Token: 0x06003DEB RID: 15851 RVA: 0x0039A3A4 File Offset: 0x003985A4
		public bool RadWideLabtoolLTEUsed_A42064_Visible
		{
			get
			{
				short num = (short)2066808832;
				short num2 = num;
				num = (short)133409995;
				short num3 = num;
				num = (short)1660136651;
				switch (num3 == num)
				{
				}
				num = (short)1464598528;
				if (num != 0)
				{
				}
				num = (short)68747265;
				if (num != 0)
				{
				}
				return this.radWideLabtoolLTEUsed_A42064.Visible;
			}
			set
			{
				short num = (short)2044395520;
				short num2 = num;
				num = (short)1993658999;
				short num3 = num;
				num = (short)667538039;
				switch (num3 == num)
				{
				}
				num = (short)864485377;
				if (num != 0)
				{
				}
				num = (short)1629487104;
				if (num != 0)
				{
				}
				this.radWideLabtoolLTEUsed_A42064.Visible = value;
			}
		}

		// Token: 0x17001FCF RID: 8143
		// (get) Token: 0x06003DEC RID: 15852 RVA: 0x0039A45C File Offset: 0x0039865C
		// (set) Token: 0x06003DED RID: 15853 RVA: 0x0039A510 File Offset: 0x00398710
		public bool RadWideLabtoolLTEUsed_A42064_Editable
		{
			get
			{
				short num = (short)1406795776;
				short num2 = num;
				num = (short)1087751386;
				short num3 = num;
				num = (short)1428931802;
				switch (num3 == num)
				{
				}
				num = (short)1283391489;
				if (num != 0)
				{
				}
				num = (short)1983774720;
				if (num != 0)
				{
				}
				return this.radWideLabtoolLTEUsed_A42064.Editable;
			}
			set
			{
				short num = (short)263847936;
				short num2 = num;
				num = (short)668668026;
				short num3 = num;
				num = (short)1050415226;
				switch (num3 == num)
				{
				}
				num = (short)473432065;
				if (num != 0)
				{
				}
				num = (short)1643184128;
				if (num != 0)
				{
				}
				this.radWideLabtoolLTEUsed_A42064.Editable = value;
			}
		}

		// Token: 0x17001FD0 RID: 8144
		// (get) Token: 0x06003DEE RID: 15854 RVA: 0x0039A5C8 File Offset: 0x003987C8
		internal string RadWideLabtoolLTEUsed_A42064_UILabel
		{
			get
			{
				short num = (short)1751842816;
				short num2 = num;
				num = (short)95602116;
				short num3 = num;
				num = (short)1748092356;
				switch (num3 == num)
				{
				}
				num = (short)262209537;
				if (num != 0)
				{
				}
				num = (short)333381632;
				if (num != 0)
				{
				}
				return this.radWideLabtoolLTEUsed_A42064.UIName;
			}
		}

		// Token: 0x17001FD1 RID: 8145
		// (get) Token: 0x06003DEF RID: 15855 RVA: 0x0039A678 File Offset: 0x00398878
		// (set) Token: 0x06003DF0 RID: 15856 RVA: 0x0039A72C File Offset: 0x0039892C
		internal bool RadWideLabtoolLTEUsed_A42064_HiddenStatic
		{
			get
			{
				short num = (short)1860894720;
				short num2 = num;
				num = (short)1741901493;
				short num3 = num;
				num = (short)6442677;
				switch (num3 == num)
				{
				}
				num = (short)1922695168;
				if (num != 0)
				{
				}
				num = (short)1712521217;
				if (num != 0)
				{
				}
				return this.radWideLabtoolLTEUsed_A42064.HiddenStatic;
			}
			set
			{
				short num = (short)1099169792;
				short num2 = num;
				num = (short)1913192449;
				if (num != 0)
				{
				}
				num = (short)479764105;
				short num3 = num;
				num = (short)960405129;
				switch (num3 == num)
				{
				}
				num = (short)1143537664;
				if (num != 0)
				{
				}
				this.radWideLabtoolLTEUsed_A42064.HiddenStatic = value;
			}
		}

		// Token: 0x17001FD2 RID: 8146
		// (get) Token: 0x06003DF1 RID: 15857 RVA: 0x0039A7E4 File Offset: 0x003989E4
		// (set) Token: 0x06003DF2 RID: 15858 RVA: 0x0039A89C File Offset: 0x00398A9C
		internal bool RadWideLabtoolLTEUsed_A42064_HiddenDynamic
		{
			get
			{
				short num = (short)1051066368;
				short num2 = num;
				num = (short)1511510845;
				short num3 = num;
				num = (short)642241341;
				switch (num3 == num)
				{
				}
				num = (short)1132593153;
				if (num != 0)
				{
				}
				num = (short)719126528;
				if (num != 0)
				{
				}
				return this.radWideLabtoolLTEUsed_A42064.HiddenDynamic;
			}
			set
			{
				short num = (short)1042546688;
				short num2 = num;
				num = (short)1693658880;
				short num3 = num;
				num = (short)1712402176;
				switch (num3 == num)
				{
				}
				num = (short)1262747648;
				if (num != 0)
				{
				}
				num = (short)1608908801;
				if (num != 0)
				{
				}
				this.radWideLabtoolLTEUsed_A42064.HiddenDynamic = value;
			}
		}

		// Token: 0x17001FD3 RID: 8147
		// (get) Token: 0x06003DF3 RID: 15859 RVA: 0x0039A950 File Offset: 0x00398B50
		public bool RadWideLabtoolLTEUsed_A42064_HasDiffs
		{
			get
			{
				short num = (short)661585920;
				short num2 = num;
				num = (short)474151528;
				short num3 = num;
				num = (short)1993865832;
				switch (num3 == num)
				{
				}
				num = (short)768016385;
				if (num != 0)
				{
				}
				num = (short)102891520;
				if (num != 0)
				{
				}
				return this.radWideLabtoolLTEUsed_A42064._HasDiffs;
			}
		}

		// Token: 0x06003DF4 RID: 15860 RVA: 0x0039AA04 File Offset: 0x00398C04
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_00:
				switch (0)
				{
				case 0:
					goto IL_4D;
				}
				short num;
				int num3;
				for (;;)
				{
					IL_0A:
					num = (short)723124224;
					short num2 = num;
					switch (num3)
					{
					case 0:
						if (base.ParentRecset != null)
						{
							num = (short)204734465;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 1:
						num = (short)1730543620;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						return result;
					case 3:
						result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
						num = (short)1647247362;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						num = (short)1035075585;
						if (num != 0)
						{
						}
						if (base.ParentRecset.ContainerDoc == null)
						{
							return result;
						}
						num = (short)1533206038;
						short num4 = num;
						num = (short)717610518;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num = (short)84213760;
							if (num != 0)
							{
							}
							num = (short)1757347843;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					break;
				}
				IL_4D:
				result = null;
				num = (short)1298137088;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}
			return result;
		}

		// Token: 0x0400121E RID: 4638
		private global::AcpBusinessLayer.AcpField<bool> radWideLabtoolLTEUsed_A42064;
	}
}
