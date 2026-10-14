using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ConventionalWide
{
	// Token: 0x02000543 RID: 1347
	[global::System.Serializable]
	public class ASTROGroupIDListInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600B4C2 RID: 46274 RVA: 0x00A76FA0 File Offset: 0x00A751A0
		public ASTROGroupIDListInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x0600B4C3 RID: 46275 RVA: 0x00A76FBC File Offset: 0x00A751BC
		protected ASTROGroupIDListInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600B4C4 RID: 46276 RVA: 0x00A76FD4 File Offset: 0x00A751D4
		public override void Init()
		{
			int a_ = 0;
			short num = (short)1943188720;
			short num2 = num;
			num = (short)959493360;
			switch (num2 == num)
			{
			}
			num = (short)457506816;
			if (num != 0)
			{
			}
			num = (short)450297856;
			short num3 = num;
			num = (short)1597833217;
			if (num != 0)
			{
			}
			this.cnvWideASTROGroupIDGroupID1_A7480 = new global::AcpBusinessLayer.AcpSimpleRangeField(10000000, this, global::AllFeatures.CodeplugGuid.b("苀귂도郆ꃈ꿊꣌軎苐蟒蟔飖默꧚닜꫞釠ꫢꇤꃦ鯨蓪飬鿮룰럲쓴ꣶ룸쳺짼쟾㄀", a_), global::CommonResources.AcgResources.ID_GROUPID, 10000000, 16777214, null, null, 0, 1);
			this.cnvWideASTROGroupIDGroupID1_A7480.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvWideASTROGroupIDGroupID1_A7480.DataTransferOrder = 12;
			this.cnvWideASTROGroupIDGroupID1_A7480.ShowHexValue = true;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("胀郂釄闆蛈諌뷎뻐ꛒꗔ郘鿚﷜鏞裠郢釤", a_);
			base.Id = 10054;
			base.UIName = global::CommonResources.AcgResources.ID_ASTROGROUPIDLIST;
			base.DataTransferOrder = 1;
		}

		// Token: 0x0600B4C5 RID: 46277 RVA: 0x00A77110 File Offset: 0x00A75310
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 16;
			for (;;)
			{
				IL_09:
				short num = (short)50593797;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)478478339;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						num = (short)192610305;
						if (num != 0)
						{
						}
						if (producerFields != null)
						{
							num = (short)1716322304;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1F6;
					case 2:
						goto IL_FD;
					case 3:
					{
						num = (short)1042732421;
						short num3 = num;
						num = (short)1653331333;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_09;
						default:
							num = (short)428736512;
							if (num != 0)
							{
							}
							if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鋐뷒ꏔ胖냘뿚룜點닠럢럤꣦껨駪苬髮臰뫲뇴냶诸铺裼迾䠀䜂㐄堆䠈㰊㤌㜎ℐ", a_)))
							{
								num = (short)2050228228;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1F6;
						}
						break;
					}
					case 4:
						this.cnvWideASTROGroupIDGroupID1_A7480 = new global::AcpBusinessLayer.AcpSimpleRangeField(10000000, this, global::AllFeatures.CodeplugGuid.b("鋐뷒ꏔ胖냘뿚룜點닠럢럤꣦껨駪苬髮臰뫲뇴냶诸铺裼迾䠀䜂㐄堆䠈㰊㤌㜎ℐ", a_), global::CommonResources.AcgResources.ID_GROUPID, null, null, 0, 1);
						this.cnvWideASTROGroupIDGroupID1_A7480.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
						this.cnvWideASTROGroupIDGroupID1_A7480.DataTransferOrder = 12;
						this.cnvWideASTROGroupIDGroupID1_A7480.ShowHexValue = true;
						num = (short)1845821442;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						switch (0)
						{
						case 0:
							goto IL_49;
						}
						continue;
					case 6:
						num = (short)352518145;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_49:
					if (!global::AcpCommonLib.AppInfoManager.DropOperation)
					{
						goto IL_1F6;
					}
					num = (short)1624702976;
					short num4 = num;
					num = (short)2098855942;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_FD:
			IL_1F6:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("郐胒臔藖雘ﯚ髜귞軠離闤쟦ꃨ꿪췬ꏮ飰胲致", a_);
			base.Id = 10054;
			base.UIName = global::CommonResources.AcgResources.ID_ASTROGROUPIDLIST;
			base.DataTransferOrder = 1;
		}

		// Token: 0x0600B4C6 RID: 46278 RVA: 0x00A77344 File Offset: 0x00A75544
		public override void PopulateReferences()
		{
			short num = (short)1822097409;
			if (num != 0)
			{
			}
			num = (short)78123482;
			short num2 = num;
			num = (short)2102333914;
			switch (num2 == num)
			{
			}
			num = (short)1656946688;
			short num3 = num;
			num = (short)534315008;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600B4C7 RID: 46279 RVA: 0x00A773F4 File Offset: 0x00A755F4
		public override void DropReferences()
		{
			short num = (short)223692542;
			short num2 = num;
			num = (short)1161512702;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1323040768;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2108162049;
			if (num != 0)
			{
			}
			num = (short)323878912;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600B4C8 RID: 46280 RVA: 0x00A774A0 File Offset: 0x00A756A0
		public override void SetConstraints()
		{
			short num = (short)1412920232;
			short num2 = num;
			num = (short)1344762792;
			switch (num2 == num)
			{
			default:
			{
				num = (short)504496128;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)332726273;
			if (num != 0)
			{
			}
			num = (short)453967872;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600B4C9 RID: 46281 RVA: 0x00A77548 File Offset: 0x00A75748
		public override void SetupDependencies()
		{
			short num = (short)2077163521;
			if (num != 0)
			{
			}
			num = (short)598736896;
			short num2 = num;
			num = (short)1296533131;
			short num3 = num;
			num = (short)1617528459;
			switch (num3 == num)
			{
			}
			num = (short)589168640;
			if (num != 0)
			{
			}
		}

		// Token: 0x17005AA8 RID: 23208
		// (get) Token: 0x0600B4CA RID: 46282 RVA: 0x00A775F0 File Offset: 0x00A757F0
		public bool HasDiffs
		{
			get
			{
				short num = (short)770518319;
				short num2 = num;
				num = (short)718220591;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1403060224;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)37486593;
				if (num != 0)
				{
				}
				num = (short)2064384000;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17005AA9 RID: 23209
		// (get) Token: 0x0600B4CB RID: 46283 RVA: 0x00A776A0 File Offset: 0x00A758A0
		// (set) Token: 0x0600B4CC RID: 46284 RVA: 0x00A77754 File Offset: 0x00A75954
		public int CnvWideASTROGroupIDGroupID1_A7480Value
		{
			get
			{
				short num = (short)1653032075;
				short num2 = num;
				num = (short)1486832779;
				switch (num2 == num)
				{
				default:
				{
					num = (short)41418752;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1334181889;
				if (num != 0)
				{
				}
				num = (short)964886528;
				if (num != 0)
				{
				}
				return this.cnvWideASTROGroupIDGroupID1_A7480.Value;
			}
			set
			{
				short num = (short)2092839915;
				short num2 = num;
				num = (short)1637495787;
				switch (num2 == num)
				{
				default:
				{
					num = (short)157483008;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)410255361;
				if (num != 0)
				{
				}
				num = (short)1363935232;
				if (num != 0)
				{
				}
				this.cnvWideASTROGroupIDGroupID1_A7480.Value = value;
			}
		}

		// Token: 0x17005AAA RID: 23210
		// (get) Token: 0x0600B4CD RID: 46285 RVA: 0x00A7780C File Offset: 0x00A75A0C
		public global::AcpBusinessLayer.AcpSimpleRangeField CnvWideASTROGroupIDGroupID1_A7480
		{
			get
			{
				short num = (short)1335897913;
				short num2 = num;
				num = (short)32976697;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1992294400;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1853685761;
				if (num != 0)
				{
				}
				num = (short)1581776896;
				if (num != 0)
				{
				}
				return this.cnvWideASTROGroupIDGroupID1_A7480;
			}
		}

		// Token: 0x17005AAB RID: 23211
		// (get) Token: 0x0600B4CE RID: 46286 RVA: 0x00A778BC File Offset: 0x00A75ABC
		// (set) Token: 0x0600B4CF RID: 46287 RVA: 0x00A77970 File Offset: 0x00A75B70
		public string CnvWideASTROGroupIDGroupID1_A7480_UIValue
		{
			get
			{
				short num = (short)1680891104;
				short num2 = num;
				num = (short)2086821088;
				switch (num2 == num)
				{
				default:
				{
					num = (short)400556032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)972685313;
				if (num != 0)
				{
				}
				num = (short)1947074560;
				if (num != 0)
				{
				}
				return this.cnvWideASTROGroupIDGroupID1_A7480.UIValue;
			}
			set
			{
				short num = (short)488766728;
				short num2 = num;
				num = (short)640154888;
				switch (num2 == num)
				{
				default:
				{
					num = (short)637009920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1660092416;
				if (num != 0)
				{
				}
				num = (short)1729429505;
				if (num != 0)
				{
				}
				this.cnvWideASTROGroupIDGroupID1_A7480.UIValue = value;
			}
		}

		// Token: 0x17005AAC RID: 23212
		// (get) Token: 0x0600B4D0 RID: 46288 RVA: 0x00A77A24 File Offset: 0x00A75C24
		// (set) Token: 0x0600B4D1 RID: 46289 RVA: 0x00A77AD8 File Offset: 0x00A75CD8
		public string CnvWideASTROGroupIDGroupID1_A7480_HexUIValue
		{
			get
			{
				short num = (short)1587116768;
				short num2 = num;
				num = (short)450984672;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1525153792;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)394919937;
				if (num != 0)
				{
				}
				num = (short)1330642944;
				if (num != 0)
				{
				}
				return this.cnvWideASTROGroupIDGroupID1_A7480.HexUIValue;
			}
			set
			{
				short num = (short)1202463594;
				short num2 = num;
				num = (short)1108550506;
				switch (num2 == num)
				{
				default:
				{
					num = (short)557449216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)212795392;
				if (num != 0)
				{
				}
				num = (short)1213595649;
				if (num != 0)
				{
				}
				this.cnvWideASTROGroupIDGroupID1_A7480.HexUIValue = value;
			}
		}

		// Token: 0x17005AAD RID: 23213
		// (get) Token: 0x0600B4D2 RID: 46290 RVA: 0x00A77B90 File Offset: 0x00A75D90
		// (set) Token: 0x0600B4D3 RID: 46291 RVA: 0x00A77C44 File Offset: 0x00A75E44
		internal int CnvWideASTROGroupIDGroupID1_A7480Min
		{
			get
			{
				short num = (short)1466588953;
				short num2 = num;
				num = (short)1797087001;
				switch (num2 == num)
				{
				default:
				{
					num = (short)645791744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1704394753;
				if (num != 0)
				{
				}
				num = (short)1473380352;
				if (num != 0)
				{
				}
				return this.cnvWideASTROGroupIDGroupID1_A7480.Min;
			}
			set
			{
				short num = (short)831980460;
				short num2 = num;
				num = (short)1036387244;
				switch (num2 == num)
				{
				default:
				{
					num = (short)701300736;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1971650561;
				if (num != 0)
				{
				}
				num = (short)1506803712;
				if (num != 0)
				{
				}
				this.cnvWideASTROGroupIDGroupID1_A7480.Min = value;
			}
		}

		// Token: 0x17005AAE RID: 23214
		// (get) Token: 0x0600B4D4 RID: 46292 RVA: 0x00A77CF8 File Offset: 0x00A75EF8
		// (set) Token: 0x0600B4D5 RID: 46293 RVA: 0x00A77DB0 File Offset: 0x00A75FB0
		internal int CnvWideASTROGroupIDGroupID1_A7480Max
		{
			get
			{
				short num = (short)662999482;
				short num2 = num;
				num = (short)1951764922;
				switch (num2 == num)
				{
				default:
				{
					num = (short)578420736;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1102053377;
				if (num != 0)
				{
				}
				num = (short)1529937920;
				if (num != 0)
				{
				}
				return this.cnvWideASTROGroupIDGroupID1_A7480.Max;
			}
			set
			{
				short num = (short)1470566775;
				short num2 = num;
				num = (short)892080503;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1969291264;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)680067073;
				if (num != 0)
				{
				}
				num = (short)946405376;
				if (num != 0)
				{
				}
				this.cnvWideASTROGroupIDGroupID1_A7480.Max = value;
			}
		}

		// Token: 0x17005AAF RID: 23215
		// (get) Token: 0x0600B4D6 RID: 46294 RVA: 0x00A77E64 File Offset: 0x00A76064
		// (set) Token: 0x0600B4D7 RID: 46295 RVA: 0x00A77F18 File Offset: 0x00A76118
		internal int CnvWideASTROGroupIDGroupID1_A7480Step
		{
			get
			{
				short num = (short)534970369;
				if (num != 0)
				{
				}
				num = (short)1409744896;
				short num2 = num;
				num = (short)1488063479;
				short num3 = num;
				num = (short)93457399;
				switch (num3 == num)
				{
				}
				num = (short)1022296064;
				if (num != 0)
				{
				}
				return this.cnvWideASTROGroupIDGroupID1_A7480.StepSize;
			}
			set
			{
				short num = (short)1654764360;
				short num2 = num;
				num = (short)51163976;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1021181952;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1977090049;
				if (num != 0)
				{
				}
				num = (short)435879936;
				if (num != 0)
				{
				}
				this.cnvWideASTROGroupIDGroupID1_A7480.StepSize = value;
			}
		}

		// Token: 0x17005AB0 RID: 23216
		// (get) Token: 0x0600B4D8 RID: 46296 RVA: 0x00A77FCC File Offset: 0x00A761CC
		// (set) Token: 0x0600B4D9 RID: 46297 RVA: 0x00A78080 File Offset: 0x00A76280
		public bool CnvWideASTROGroupIDGroupID1_A7480_Applicable
		{
			get
			{
				short num = (short)944037615;
				short num2 = num;
				num = (short)210886383;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1713307648;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1565196289;
				if (num != 0)
				{
				}
				num = (short)363659264;
				if (num != 0)
				{
				}
				return this.cnvWideASTROGroupIDGroupID1_A7480.Applicable;
			}
			set
			{
				short num = (short)501399752;
				short num2 = num;
				num = (short)1059307720;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1078067200;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)671481857;
				if (num != 0)
				{
				}
				num = (short)1565917184;
				if (num != 0)
				{
				}
				this.cnvWideASTROGroupIDGroupID1_A7480.Applicable = value;
			}
		}

		// Token: 0x17005AB1 RID: 23217
		// (get) Token: 0x0600B4DA RID: 46298 RVA: 0x00A78134 File Offset: 0x00A76334
		// (set) Token: 0x0600B4DB RID: 46299 RVA: 0x00A781E8 File Offset: 0x00A763E8
		public bool CnvWideASTROGroupIDGroupID1_A7480_Valid
		{
			get
			{
				short num = (short)1077413313;
				short num2 = num;
				num = (short)2139686337;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1486225408;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1645608960;
				if (num != 0)
				{
				}
				num = (short)411828225;
				if (num != 0)
				{
				}
				return this.cnvWideASTROGroupIDGroupID1_A7480.Valid;
			}
			set
			{
				short num = (short)418414496;
				short num2 = num;
				num = (short)1743814560;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1031012352;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)194576384;
				if (num != 0)
				{
				}
				num = (short)1365049345;
				if (num != 0)
				{
				}
				this.cnvWideASTROGroupIDGroupID1_A7480.Valid = value;
			}
		}

		// Token: 0x17005AB2 RID: 23218
		// (get) Token: 0x0600B4DC RID: 46300 RVA: 0x00A7829C File Offset: 0x00A7649C
		// (set) Token: 0x0600B4DD RID: 46301 RVA: 0x00A78354 File Offset: 0x00A76554
		public bool CnvWideASTROGroupIDGroupID1_A7480_Visible
		{
			get
			{
				short num = (short)1154157174;
				short num2 = num;
				num = (short)1778518646;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1392050176;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1688928257;
				if (num != 0)
				{
				}
				num = (short)1076166656;
				if (num != 0)
				{
				}
				return this.cnvWideASTROGroupIDGroupID1_A7480.Visible;
			}
			set
			{
				short num = (short)1715504014;
				short num2 = num;
				num = (short)637240206;
				switch (num2 == num)
				{
				default:
				{
					num = (short)30867456;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2056781825;
				if (num != 0)
				{
				}
				num = (short)1243676672;
				if (num != 0)
				{
				}
				this.cnvWideASTROGroupIDGroupID1_A7480.Visible = value;
			}
		}

		// Token: 0x17005AB3 RID: 23219
		// (get) Token: 0x0600B4DE RID: 46302 RVA: 0x00A78408 File Offset: 0x00A76608
		// (set) Token: 0x0600B4DF RID: 46303 RVA: 0x00A784B8 File Offset: 0x00A766B8
		public bool CnvWideASTROGroupIDGroupID1_A7480_Editable
		{
			get
			{
				short num = (short)1041891329;
				if (num != 0)
				{
				}
				num = (short)84672512;
				short num2 = num;
				num = (short)1015493258;
				short num3 = num;
				num = (short)729363082;
				switch (num3 == num)
				{
				}
				num = (short)1982988288;
				if (num != 0)
				{
				}
				return this.cnvWideASTROGroupIDGroupID1_A7480.Editable;
			}
			set
			{
				short num = (short)1756072033;
				short num2 = num;
				num = (short)969377889;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1272381440;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)900595713;
				if (num != 0)
				{
				}
				num = (short)85393408;
				if (num != 0)
				{
				}
				this.cnvWideASTROGroupIDGroupID1_A7480.Editable = value;
			}
		}

		// Token: 0x17005AB4 RID: 23220
		// (get) Token: 0x0600B4E0 RID: 46304 RVA: 0x00A78570 File Offset: 0x00A76770
		internal string CnvWideASTROGroupIDGroupID1_A7480_UILabel
		{
			get
			{
				short num = (short)658343050;
				short num2 = num;
				num = (short)438731914;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1315766272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1876426752;
				if (num != 0)
				{
				}
				num = (short)1585184769;
				if (num != 0)
				{
				}
				return this.cnvWideASTROGroupIDGroupID1_A7480.UIName;
			}
		}

		// Token: 0x17005AB5 RID: 23221
		// (get) Token: 0x0600B4E1 RID: 46305 RVA: 0x00A78624 File Offset: 0x00A76824
		// (set) Token: 0x0600B4E2 RID: 46306 RVA: 0x00A786DC File Offset: 0x00A768DC
		internal bool CnvWideASTROGroupIDGroupID1_A7480_HiddenStatic
		{
			get
			{
				short num = (short)1065740034;
				short num2 = num;
				num = (short)597485314;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1069678592;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1870135297;
				if (num != 0)
				{
				}
				num = (short)627441664;
				if (num != 0)
				{
				}
				return this.cnvWideASTROGroupIDGroupID1_A7480.HiddenStatic;
			}
			set
			{
				short num = (short)1000070153;
				short num2 = num;
				num = (short)729472009;
				switch (num2 == num)
				{
				default:
				{
					num = (short)834207744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)201850881;
				if (num != 0)
				{
				}
				num = (short)497876992;
				if (num != 0)
				{
				}
				this.cnvWideASTROGroupIDGroupID1_A7480.HiddenStatic = value;
			}
		}

		// Token: 0x17005AB6 RID: 23222
		// (get) Token: 0x0600B4E3 RID: 46307 RVA: 0x00A78790 File Offset: 0x00A76990
		// (set) Token: 0x0600B4E4 RID: 46308 RVA: 0x00A78844 File Offset: 0x00A76A44
		internal bool CnvWideASTROGroupIDGroupID1_A7480_HiddenDynamic
		{
			get
			{
				short num = (short)1115382933;
				short num2 = num;
				num = (short)318530709;
				switch (num2 == num)
				{
				default:
				{
					num = (short)131661824;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2104492033;
				if (num != 0)
				{
				}
				num = (short)37224448;
				if (num != 0)
				{
				}
				return this.cnvWideASTROGroupIDGroupID1_A7480.HiddenDynamic;
			}
			set
			{
				short num = (short)240884264;
				short num2 = num;
				num = (short)1853004328;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2113339392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1056374785;
				if (num != 0)
				{
				}
				num = (short)1197342720;
				if (num != 0)
				{
				}
				this.cnvWideASTROGroupIDGroupID1_A7480.HiddenDynamic = value;
			}
		}

		// Token: 0x17005AB7 RID: 23223
		// (get) Token: 0x0600B4E5 RID: 46309 RVA: 0x00A788F8 File Offset: 0x00A76AF8
		public bool CnvWideASTROGroupIDGroupID1_A7480_HasDiffs
		{
			get
			{
				short num = (short)1623999028;
				short num2 = num;
				num = (short)374227508;
				switch (num2 == num)
				{
				default:
				{
					num = (short)410583040;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)385024000;
				if (num != 0)
				{
				}
				num = (short)1901985793;
				if (num != 0)
				{
				}
				return this.cnvWideASTROGroupIDGroupID1_A7480._HasDiffs;
			}
		}

		// Token: 0x0600B4E6 RID: 46310 RVA: 0x00A789AC File Offset: 0x00A76BAC
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			short num2;
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_00:
				switch (0)
				{
				case 0:
					goto IL_24;
				}
				int num;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						num2 = (short)1086586884;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 1:
						goto IL_B4;
					case 2:
						if (base.ParentRecset != null)
						{
							num2 = (short)362217472;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					case 3:
					{
						num2 = (short)641794048;
						short num3 = num2;
						result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
						num2 = (short)1480065025;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 4:
					{
						if (base.ParentRecset.ContainerDoc == null)
						{
							return result;
						}
						num2 = (short)1868513820;
						short num4 = num2;
						num2 = (short)2127184412;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num2 = (short)1710555136;
							if (num2 != 0)
							{
							}
							num2 = (short)1041235971;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					}
					break;
				}
				IL_24:
				result = null;
				num2 = (short)1339883522;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			IL_B4:
			num2 = (short)1175584769;
			if (num2 != 0)
			{
			}
			return result;
		}

		// Token: 0x040057BA RID: 22458
		private global::AcpBusinessLayer.AcpSimpleRangeField cnvWideASTROGroupIDGroupID1_A7480;
	}
}
