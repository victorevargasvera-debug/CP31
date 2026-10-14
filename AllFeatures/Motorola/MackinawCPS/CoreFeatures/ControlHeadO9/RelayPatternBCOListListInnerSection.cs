using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using ConstraintHelper;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO9
{
	// Token: 0x02000381 RID: 897
	[global::System.Serializable]
	public class RelayPatternBCOListListInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600842F RID: 33839 RVA: 0x007ACA04 File Offset: 0x007AAC04
		public RelayPatternBCOListListInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06008430 RID: 33840 RVA: 0x007ACA20 File Offset: 0x007AAC20
		protected RelayPatternBCOListListInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06008431 RID: 33841 RVA: 0x007ACA38 File Offset: 0x007AAC38
		public override void Init()
		{
			int a_ = 6;
			short num = (short)1845520198;
			short num2 = num;
			num = (short)1740400454;
			switch (num2 == num)
			{
			}
			num = (short)2064056320;
			if (num != 0)
			{
			}
			num = (short)1031471105;
			if (num != 0)
			{
			}
			num = (short)1115488256;
			short num3 = num;
			this.rdEgoO9DirLtbarPatternBcoListBco_A36661 = new global::AcpBusinessLayer.AcpSparseLOVField(160, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.indexRdEgoO9DirLtbarPatternBcoListBco_A36661LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.idRdEgoO9DirLtbarPatternBcoListBco_A36661LovStrs), this, global::AllFeatures.CodeplugGuid.b("闆귈車꫌ꃎ黐釔뻖ꯘ韚꧜뷞胠釢뗤蛦鷨鿪裬鷮鿰뇲雴飶뗸鋺軼课䌀怂樄堆䠈㠊㬌㤎✐−", a_), global::CommonResources.AcgResources.ID_BCO, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.RdEgoO9DirLtbarPatternBcoListBco_A36661LovStrs);
			this.rdEgoO9DirLtbarPatternBcoListBco_A36661.IgnoreOnCompare = true;
			this.rdEgoO9DirLtbarPatternBcoListBco_A36661.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.rdEgoO9DirLtbarPatternBcoListBco_A36661.DataTransferOrder = -1;
			this.rdEgoO9DirLtbarPatternBcoListIndex_A36707 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("闆귈車꫌ꃎ黐釔뻖ꯘ韚꧜뷞胠釢뗤蛦鷨鿪裬鷮鿰뇲雴飶뗸鋺軼课䠀洂愄戆焈吊䰌㰎✐␒└‖", a_), global::CommonResources.AcgResources.ID_INDEX, new string[]
			{
				global::CommonResources.AcgResources.ID_UNASSIGNED
			}, new int[1], true, false);
			this.rdEgoO9DirLtbarPatternBcoListIndex_A36707.IgnoreOnCompare = true;
			this.rdEgoO9DirLtbarPatternBcoListIndex_A36707.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.rdEgoO9DirLtbarPatternBcoListIndex_A36707.DataTransferOrder = -1;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("闆곈ꟊ곌뛎菒듔ꏖ귘뻚꿜뇞쇠ꇢꛤ꣦짨꟪蓬鳮藰", a_);
			base.Id = 10621;
			base.UIName = global::CommonResources.AcgResources.ID_RELAYPATTERNBCOLIST;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06008432 RID: 33842 RVA: 0x007ACBD0 File Offset: 0x007AADD0
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 15;
			short num = (short)238288897;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_2D2;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_57;
					}
					continue;
				case 2:
					num = (short)159449092;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					num = (short)366542849;
					if (num != 0)
					{
					}
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("苏뛑釓뇕럗闙髝觟郡꣣鋥諧诩黫뻭釯蛱胳鏵諷铹뻻鷽濿丁洃甅簇䌉戋樍甏樑䬓圕⬗Ⱉ⬛⸝ᜟ", a_)))
					{
						num = (short)1721499656;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2D7;
				case 4:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("苏뛑釓뇕럗闙髝觟郡꣣鋥諧诩黫뻭釯蛱胳鏵諷铹뻻鷽濿丁洃甅簇䠉漋愍伏匑✓―⸗Ⱉⴛ", a_)))
					{
						num = (short)535756800;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A2;
				case 5:
				{
					num = (short)1004870306;
					short num3 = num;
					num = (short)1126439586;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_2D2;
					default:
						goto IL_271;
					}
					break;
				}
				case 6:
					if (producerFields != null)
					{
						num = (short)1479868418;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2D7;
				case 7:
					num = (short)561709062;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					this.rdEgoO9DirLtbarPatternBcoListIndex_A36707 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("苏뛑釓뇕럗闙髝觟郡꣣鋥諧诩黫뻭釯蛱胳鏵諷铹뻻鷽濿丁洃甅簇䌉戋樍甏樑䬓圕⬗Ⱉ⬛⸝ᜟ", a_), global::CommonResources.AcgResources.ID_INDEX, new string[]
					{
						global::CommonResources.AcgResources.ID_UNASSIGNED
					}, new int[1], true, false);
					this.rdEgoO9DirLtbarPatternBcoListIndex_A36707.IgnoreOnCompare = true;
					this.rdEgoO9DirLtbarPatternBcoListIndex_A36707.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.rdEgoO9DirLtbarPatternBcoListIndex_A36707.DataTransferOrder = -1;
					num = (short)388497413;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					goto IL_A2;
				}
				IL_57:
				num = (short)2043215872;
				short num4 = num;
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)337838087;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_2D7;
				IL_A2:
				num = (short)753598467;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2D2:
				this.rdEgoO9DirLtbarPatternBcoListBco_A36661 = new global::AcpBusinessLayer.AcpSparseLOVField(160, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.indexRdEgoO9DirLtbarPatternBcoListBco_A36661LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.idRdEgoO9DirLtbarPatternBcoListBco_A36661LovStrs), this, global::AllFeatures.CodeplugGuid.b("苏뛑釓뇕럗闙髝觟郡꣣鋥諧诩黫뻭釯蛱胳鏵諷铹뻻鷽濿丁洃甅簇䠉漋愍伏匑✓―⸗Ⱉⴛ", a_), global::CommonResources.AcgResources.ID_BCO, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.RdEgoO9DirLtbarPatternBcoListBco_A36661LovStrs);
				this.rdEgoO9DirLtbarPatternBcoListBco_A36661.IgnoreOnCompare = true;
				this.rdEgoO9DirLtbarPatternBcoListBco_A36661.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
				this.rdEgoO9DirLtbarPatternBcoListBco_A36661.DataTransferOrder = -1;
				num = (short)2083061769;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_271:
			num = (short)423821312;
			if (num != 0)
			{
			}
			IL_2D7:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("苏럑룓럕ꇗ龎賛뿝铟雡臣铥蛧쫩껫귭뿯틱룳鿵请軹", a_);
			base.Id = 10621;
			base.UIName = global::CommonResources.AcgResources.ID_RELAYPATTERNBCOLIST;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06008433 RID: 33843 RVA: 0x007ACEE8 File Offset: 0x007AB0E8
		public override void PopulateReferences()
		{
			short num = (short)510240781;
			short num2 = num;
			num = (short)326019085;
			switch (num2 == num)
			{
			}
			num = (short)1370357761;
			if (num != 0)
			{
			}
			num = (short)1526398976;
			if (num != 0)
			{
			}
			num = (short)1773535232;
			short num3 = num;
			this.rdEgoO9DirLtbarPatternBcoListIndex_A36707.SetRecset(this.a(2045)[0][10604].EmbeddedRecset);
		}

		// Token: 0x06008434 RID: 33844 RVA: 0x007ACFBC File Offset: 0x007AB1BC
		public override void DropReferences()
		{
			short num = (short)243531777;
			if (num != 0)
			{
			}
			num = (short)253195193;
			short num2 = num;
			num = (short)830370745;
			switch (num2 == num)
			{
			}
			num = (short)1127088128;
			if (num != 0)
			{
			}
			num = (short)156172288;
			short num3 = num;
		}

		// Token: 0x06008435 RID: 33845 RVA: 0x007AD068 File Offset: 0x007AB268
		public override void SetConstraints()
		{
			short num = (short)160628737;
			if (num != 0)
			{
			}
			num = (short)648124874;
			short num2 = num;
			num = (short)1659804106;
			switch (num2 == num)
			{
			}
			num = (short)7143424;
			if (num != 0)
			{
			}
			num = (short)1457717248;
			short num3 = num;
		}

		// Token: 0x06008436 RID: 33846 RVA: 0x007AD110 File Offset: 0x007AB310
		public override void SetupDependencies()
		{
			short num = (short)1693154779;
			short num2 = num;
			num = (short)1492024795;
			switch (num2 == num)
			{
			}
			num = (short)635568129;
			if (num != 0)
			{
			}
			num = (short)642580480;
			if (num != 0)
			{
			}
			num = (short)1016659968;
			short num3 = num;
		}

		// Token: 0x17004345 RID: 17221
		// (get) Token: 0x06008437 RID: 33847 RVA: 0x007AD1BC File Offset: 0x007AB3BC
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInner GeneralLightbarPatternInnerSectionForRdEgoO9DirLtbarPatternBcoListIndex_A36707
		{
			get
			{
				short num = (short)124840231;
				short num2 = num;
				num = (short)1157884199;
				switch (num2 == num)
				{
				}
				num = (short)1127546880;
				if (num != 0)
				{
				}
				num = (short)1947860993;
				if (num != 0)
				{
				}
				num = (short)728694784;
				short num3 = num;
				return this.rdEgoO9DirLtbarPatternBcoListIndex_A36707.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInner;
			}
		}

		// Token: 0x17004346 RID: 17222
		// (get) Token: 0x06008438 RID: 33848 RVA: 0x007AD274 File Offset: 0x007AB474
		public bool HasDiffs
		{
			get
			{
				short num = (short)144700511;
				short num2 = num;
				num = (short)2132603999;
				switch (num2 == num)
				{
				}
				num = (short)1356398592;
				if (num != 0)
				{
				}
				num = (short)42860545;
				if (num != 0)
				{
				}
				num = (short)2115108864;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x17004347 RID: 17223
		// (get) Token: 0x06008439 RID: 33849 RVA: 0x007AD320 File Offset: 0x007AB520
		// (set) Token: 0x0600843A RID: 33850 RVA: 0x007AD3D4 File Offset: 0x007AB5D4
		public int RdEgoO9DirLtbarPatternBcoListBco_A36661Value
		{
			get
			{
				short num = (short)1658371264;
				short num2 = num;
				num = (short)288668864;
				switch (num2 == num)
				{
				}
				num = (short)298713089;
				if (num != 0)
				{
				}
				num = (short)1177354240;
				if (num != 0)
				{
				}
				num = (short)18939904;
				short num3 = num;
				return this.rdEgoO9DirLtbarPatternBcoListBco_A36661.Value;
			}
			set
			{
				short num = (short)1332543489;
				if (num != 0)
				{
				}
				num = (short)604293418;
				short num2 = num;
				num = (short)1906100522;
				switch (num2 == num)
				{
				}
				num = (short)1466236928;
				if (num != 0)
				{
				}
				num = (short)1896939520;
				short num3 = num;
				this.rdEgoO9DirLtbarPatternBcoListBco_A36661.Value = value;
			}
		}

		// Token: 0x17004348 RID: 17224
		// (get) Token: 0x0600843B RID: 33851 RVA: 0x007AD48C File Offset: 0x007AB68C
		// (set) Token: 0x0600843C RID: 33852 RVA: 0x007AD540 File Offset: 0x007AB740
		public string RdEgoO9DirLtbarPatternBcoListBco_A36661_UIValue
		{
			get
			{
				short num = (short)467317617;
				short num2 = num;
				num = (short)1020834673;
				switch (num2 == num)
				{
				}
				num = (short)1324220417;
				if (num != 0)
				{
				}
				num = (short)1144389632;
				if (num != 0)
				{
				}
				num = (short)940507136;
				short num3 = num;
				return this.rdEgoO9DirLtbarPatternBcoListBco_A36661.UIValue;
			}
			set
			{
				short num = (short)1762543800;
				short num2 = num;
				num = (short)820463800;
				switch (num2 == num)
				{
				}
				num = (short)187170817;
				if (num != 0)
				{
				}
				num = (short)144048128;
				if (num != 0)
				{
				}
				num = (short)1446707200;
				short num3 = num;
				this.rdEgoO9DirLtbarPatternBcoListBco_A36661.UIValue = value;
			}
		}

		// Token: 0x17004349 RID: 17225
		// (get) Token: 0x0600843D RID: 33853 RVA: 0x007AD5F4 File Offset: 0x007AB7F4
		public global::AcpBusinessLayer.AcpListField RdEgoO9DirLtbarPatternBcoListBco_A36661
		{
			get
			{
				short num = (short)1116820417;
				short num2 = num;
				num = (short)75781057;
				switch (num2 == num)
				{
				}
				num = (short)1823211520;
				if (num != 0)
				{
				}
				num = (short)940507137;
				if (num != 0)
				{
				}
				num = (short)1748303872;
				short num3 = num;
				return this.rdEgoO9DirLtbarPatternBcoListBco_A36661;
			}
		}

		// Token: 0x1700434A RID: 17226
		// (get) Token: 0x0600843E RID: 33854 RVA: 0x007AD6A4 File Offset: 0x007AB8A4
		// (set) Token: 0x0600843F RID: 33855 RVA: 0x007AD758 File Offset: 0x007AB958
		public bool RdEgoO9DirLtbarPatternBcoListBco_A36661_Applicable
		{
			get
			{
				short num = (short)559275969;
				short num2 = num;
				num = (short)13688769;
				switch (num2 == num)
				{
				}
				num = (short)1522597889;
				if (num != 0)
				{
				}
				num = (short)1062862848;
				if (num != 0)
				{
				}
				num = (short)1549074432;
				short num3 = num;
				return this.rdEgoO9DirLtbarPatternBcoListBco_A36661.Applicable;
			}
			set
			{
				short num = (short)2136574749;
				short num2 = num;
				num = (short)1356368669;
				switch (num2 == num)
				{
				}
				num = (short)366018561;
				if (num != 0)
				{
				}
				num = (short)179044352;
				if (num != 0)
				{
				}
				num = (short)1845428224;
				short num3 = num;
				this.rdEgoO9DirLtbarPatternBcoListBco_A36661.Applicable = value;
			}
		}

		// Token: 0x1700434B RID: 17227
		// (get) Token: 0x06008440 RID: 33856 RVA: 0x007AD810 File Offset: 0x007ABA10
		// (set) Token: 0x06008441 RID: 33857 RVA: 0x007AD8C4 File Offset: 0x007ABAC4
		public bool RdEgoO9DirLtbarPatternBcoListBco_A36661_Valid
		{
			get
			{
				short num = (short)668559738;
				short num2 = num;
				num = (short)1812359546;
				switch (num2 == num)
				{
				}
				num = (short)1733361665;
				if (num != 0)
				{
				}
				num = (short)279117824;
				if (num != 0)
				{
				}
				num = (short)1461256192;
				short num3 = num;
				return this.rdEgoO9DirLtbarPatternBcoListBco_A36661.Valid;
			}
			set
			{
				short num = (short)1612512403;
				short num2 = num;
				num = (short)1990917267;
				switch (num2 == num)
				{
				}
				num = (short)2074017793;
				if (num != 0)
				{
				}
				num = (short)2075197440;
				if (num != 0)
				{
				}
				num = (short)584646656;
				short num3 = num;
				this.rdEgoO9DirLtbarPatternBcoListBco_A36661.Valid = value;
			}
		}

		// Token: 0x1700434C RID: 17228
		// (get) Token: 0x06008442 RID: 33858 RVA: 0x007AD97C File Offset: 0x007ABB7C
		// (set) Token: 0x06008443 RID: 33859 RVA: 0x007ADA30 File Offset: 0x007ABC30
		public bool RdEgoO9DirLtbarPatternBcoListBco_A36661_Visible
		{
			get
			{
				short num = (short)648559970;
				short num2 = num;
				num = (short)1440628066;
				switch (num2 == num)
				{
				}
				num = (short)1632239616;
				if (num != 0)
				{
				}
				num = (short)239992833;
				if (num != 0)
				{
				}
				num = (short)730202112;
				short num3 = num;
				return this.rdEgoO9DirLtbarPatternBcoListBco_A36661.Visible;
			}
			set
			{
				short num = (short)1002176513;
				if (num != 0)
				{
				}
				num = (short)381589969;
				short num2 = num;
				num = (short)1095080401;
				switch (num2 == num)
				{
				}
				num = (short)521928704;
				if (num != 0)
				{
				}
				num = (short)642580480;
				short num3 = num;
				this.rdEgoO9DirLtbarPatternBcoListBco_A36661.Visible = value;
			}
		}

		// Token: 0x1700434D RID: 17229
		// (get) Token: 0x06008444 RID: 33860 RVA: 0x007ADAE4 File Offset: 0x007ABCE4
		// (set) Token: 0x06008445 RID: 33861 RVA: 0x007ADB98 File Offset: 0x007ABD98
		public bool RdEgoO9DirLtbarPatternBcoListBco_A36661_Editable
		{
			get
			{
				short num = (short)845967928;
				short num2 = num;
				num = (short)1058173496;
				switch (num2 == num)
				{
				}
				num = (short)832176129;
				if (num != 0)
				{
				}
				num = (short)2007040000;
				if (num != 0)
				{
				}
				num = (short)1282998272;
				short num3 = num;
				return this.rdEgoO9DirLtbarPatternBcoListBco_A36661.Editable;
			}
			set
			{
				short num = (short)2025317760;
				short num2 = num;
				num = (short)1769399680;
				switch (num2 == num)
				{
				}
				num = (short)34930689;
				if (num != 0)
				{
				}
				num = (short)2007891968;
				if (num != 0)
				{
				}
				num = (short)891486208;
				short num3 = num;
				this.rdEgoO9DirLtbarPatternBcoListBco_A36661.Editable = value;
			}
		}

		// Token: 0x1700434E RID: 17230
		// (get) Token: 0x06008446 RID: 33862 RVA: 0x007ADC4C File Offset: 0x007ABE4C
		internal string RdEgoO9DirLtbarPatternBcoListBco_A36661_UILabel
		{
			get
			{
				short num = (short)18917901;
				short num2 = num;
				num = (short)1764862477;
				switch (num2 == num)
				{
				}
				num = (short)1359609856;
				if (num != 0)
				{
				}
				num = (short)70844417;
				if (num != 0)
				{
				}
				num = (short)1052311552;
				short num3 = num;
				return this.rdEgoO9DirLtbarPatternBcoListBco_A36661.UIName;
			}
		}

		// Token: 0x1700434F RID: 17231
		// (get) Token: 0x06008447 RID: 33863 RVA: 0x007ADD00 File Offset: 0x007ABF00
		// (set) Token: 0x06008448 RID: 33864 RVA: 0x007ADDB4 File Offset: 0x007ABFB4
		internal bool RdEgoO9DirLtbarPatternBcoListBco_A36661_HiddenStatic
		{
			get
			{
				short num = (short)406043602;
				short num2 = num;
				num = (short)442416082;
				switch (num2 == num)
				{
				}
				num = (short)694484993;
				if (num != 0)
				{
				}
				num = (short)1224278016;
				if (num != 0)
				{
				}
				num = (short)1000013824;
				short num3 = num;
				return this.rdEgoO9DirLtbarPatternBcoListBco_A36661.HiddenStatic;
			}
			set
			{
				short num = (short)1508114433;
				if (num != 0)
				{
				}
				num = (short)1412870961;
				short num2 = num;
				num = (short)1190376241;
				switch (num2 == num)
				{
				}
				num = (short)280887296;
				if (num != 0)
				{
				}
				num = (short)1780219904;
				short num3 = num;
				this.rdEgoO9DirLtbarPatternBcoListBco_A36661.HiddenStatic = value;
			}
		}

		// Token: 0x17004350 RID: 17232
		// (get) Token: 0x06008449 RID: 33865 RVA: 0x007ADE70 File Offset: 0x007AC070
		// (set) Token: 0x0600844A RID: 33866 RVA: 0x007ADF24 File Offset: 0x007AC124
		internal bool RdEgoO9DirLtbarPatternBcoListBco_A36661_HiddenDynamic
		{
			get
			{
				short num = (short)1550305942;
				short num2 = num;
				num = (short)2097138326;
				switch (num2 == num)
				{
				}
				num = (short)1600847873;
				if (num != 0)
				{
				}
				num = (short)1261109248;
				if (num != 0)
				{
				}
				num = (short)1769275392;
				short num3 = num;
				return this.rdEgoO9DirLtbarPatternBcoListBco_A36661.HiddenDynamic;
			}
			set
			{
				short num = (short)914586820;
				short num2 = num;
				num = (short)158432452;
				switch (num2 == num)
				{
				}
				num = (short)1569652736;
				if (num != 0)
				{
				}
				num = (short)1778647041;
				if (num != 0)
				{
				}
				num = (short)1754333184;
				short num3 = num;
				this.rdEgoO9DirLtbarPatternBcoListBco_A36661.HiddenDynamic = value;
			}
		}

		// Token: 0x17004351 RID: 17233
		// (get) Token: 0x0600844B RID: 33867 RVA: 0x007ADFDC File Offset: 0x007AC1DC
		public bool RdEgoO9DirLtbarPatternBcoListBco_A36661_HasDiffs
		{
			get
			{
				short num = (short)1714085209;
				short num2 = num;
				num = (short)565828953;
				switch (num2 == num)
				{
				}
				num = (short)1062404097;
				if (num != 0)
				{
				}
				num = (short)1726939136;
				if (num != 0)
				{
				}
				num = (short)1405485056;
				short num3 = num;
				return this.rdEgoO9DirLtbarPatternBcoListBco_A36661._HasDiffs;
			}
		}

		// Token: 0x17004352 RID: 17234
		// (get) Token: 0x0600844C RID: 33868 RVA: 0x007AE090 File Offset: 0x007AC290
		// (set) Token: 0x0600844D RID: 33869 RVA: 0x007AE144 File Offset: 0x007AC344
		public int RdEgoO9DirLtbarPatternBcoListIndex_A36707Value
		{
			get
			{
				short num = (short)962917842;
				short num2 = num;
				num = (short)2079913426;
				switch (num2 == num)
				{
				}
				num = (short)527302657;
				if (num != 0)
				{
				}
				num = (short)1906376704;
				if (num != 0)
				{
				}
				num = (short)1930756096;
				short num3 = num;
				return this.rdEgoO9DirLtbarPatternBcoListIndex_A36707.Value;
			}
			set
			{
				short num = (short)1000583019;
				short num2 = num;
				num = (short)1736290155;
				switch (num2 == num)
				{
				}
				num = (short)1568473088;
				if (num != 0)
				{
				}
				num = (short)1137901569;
				if (num != 0)
				{
				}
				num = (short)1929445376;
				short num3 = num;
				this.rdEgoO9DirLtbarPatternBcoListIndex_A36707.Value = value;
			}
		}

		// Token: 0x17004353 RID: 17235
		// (get) Token: 0x0600844E RID: 33870 RVA: 0x007AE1F8 File Offset: 0x007AC3F8
		// (set) Token: 0x0600844F RID: 33871 RVA: 0x007AE2AC File Offset: 0x007AC4AC
		public string RdEgoO9DirLtbarPatternBcoListIndex_A36707_UIValue
		{
			get
			{
				short num = (short)2035393862;
				short num2 = num;
				num = (short)401712454;
				switch (num2 == num)
				{
				}
				num = (short)491847681;
				if (num != 0)
				{
				}
				num = (short)1481900032;
				if (num != 0)
				{
				}
				num = (short)1145176064;
				short num3 = num;
				return this.rdEgoO9DirLtbarPatternBcoListIndex_A36707.UIValue;
			}
			set
			{
				short num = (short)994115585;
				if (num != 0)
				{
				}
				num = (short)1318132836;
				short num2 = num;
				num = (short)960306276;
				switch (num2 == num)
				{
				}
				num = (short)2143813632;
				if (num != 0)
				{
				}
				num = (short)1389821952;
				short num3 = num;
				this.rdEgoO9DirLtbarPatternBcoListIndex_A36707.UIValue = value;
			}
		}

		// Token: 0x17004354 RID: 17236
		// (get) Token: 0x06008450 RID: 33872 RVA: 0x007AE364 File Offset: 0x007AC564
		public global::AcpBusinessLayer.AcpRecRefField RdEgoO9DirLtbarPatternBcoListIndex_A36707
		{
			get
			{
				short num = (short)317808391;
				short num2 = num;
				num = (short)944660231;
				switch (num2 == num)
				{
				}
				num = (short)2040987648;
				if (num != 0)
				{
				}
				num = (short)1835794433;
				if (num != 0)
				{
				}
				num = (short)1446182912;
				short num3 = num;
				return this.rdEgoO9DirLtbarPatternBcoListIndex_A36707;
			}
		}

		// Token: 0x17004355 RID: 17237
		// (get) Token: 0x06008451 RID: 33873 RVA: 0x007AE414 File Offset: 0x007AC614
		// (set) Token: 0x06008452 RID: 33874 RVA: 0x007AE4C8 File Offset: 0x007AC6C8
		public bool RdEgoO9DirLtbarPatternBcoListIndex_A36707_Applicable
		{
			get
			{
				short num = (short)749338625;
				if (num != 0)
				{
				}
				num = (short)989038656;
				short num2 = num;
				num = (short)647137344;
				switch (num2 == num)
				{
				}
				num = (short)1486487552;
				if (num != 0)
				{
				}
				num = (short)563544064;
				short num3 = num;
				return this.rdEgoO9DirLtbarPatternBcoListIndex_A36707.Applicable;
			}
			set
			{
				short num = (short)1421143498;
				short num2 = num;
				num = (short)255454666;
				switch (num2 == num)
				{
				}
				num = (short)733216769;
				if (num != 0)
				{
				}
				num = (short)769851392;
				if (num != 0)
				{
				}
				num = (short)2035286016;
				short num3 = num;
				this.rdEgoO9DirLtbarPatternBcoListIndex_A36707.Applicable = value;
			}
		}

		// Token: 0x17004356 RID: 17238
		// (get) Token: 0x06008453 RID: 33875 RVA: 0x007AE57C File Offset: 0x007AC77C
		// (set) Token: 0x06008454 RID: 33876 RVA: 0x007AE62C File Offset: 0x007AC82C
		public bool RdEgoO9DirLtbarPatternBcoListIndex_A36707_Valid
		{
			get
			{
				short num = (short)2002496923;
				short num2 = num;
				num = (short)1626189211;
				switch (num2 == num)
				{
				}
				num = (short)1855979520;
				if (num != 0)
				{
				}
				num = (short)1792737281;
				if (num != 0)
				{
				}
				num = (short)1591934976;
				short num3 = num;
				return this.rdEgoO9DirLtbarPatternBcoListIndex_A36707.Valid;
			}
			set
			{
				short num = (short)561160742;
				short num2 = num;
				num = (short)360751654;
				switch (num2 == num)
				{
				}
				num = (short)1113718784;
				if (num != 0)
				{
				}
				num = (short)1551171585;
				if (num != 0)
				{
				}
				num = (short)77791232;
				short num3 = num;
				this.rdEgoO9DirLtbarPatternBcoListIndex_A36707.Valid = value;
			}
		}

		// Token: 0x17004357 RID: 17239
		// (get) Token: 0x06008455 RID: 33877 RVA: 0x007AE6E0 File Offset: 0x007AC8E0
		// (set) Token: 0x06008456 RID: 33878 RVA: 0x007AE794 File Offset: 0x007AC994
		public bool RdEgoO9DirLtbarPatternBcoListIndex_A36707_Visible
		{
			get
			{
				short num = (short)1353360072;
				short num2 = num;
				num = (short)701866696;
				switch (num2 == num)
				{
				}
				num = (short)1741488128;
				if (num != 0)
				{
				}
				num = (short)860487681;
				if (num != 0)
				{
				}
				num = (short)617545728;
				short num3 = num;
				return this.rdEgoO9DirLtbarPatternBcoListIndex_A36707.Visible;
			}
			set
			{
				short num = (short)425901957;
				short num2 = num;
				num = (short)1899544453;
				switch (num2 == num)
				{
				}
				num = (short)756678657;
				if (num != 0)
				{
				}
				num = (short)337707008;
				if (num != 0)
				{
				}
				num = (short)1994784768;
				short num3 = num;
				this.rdEgoO9DirLtbarPatternBcoListIndex_A36707.Visible = value;
			}
		}

		// Token: 0x17004358 RID: 17240
		// (get) Token: 0x06008457 RID: 33879 RVA: 0x007AE848 File Offset: 0x007ACA48
		// (set) Token: 0x06008458 RID: 33880 RVA: 0x007AE8FC File Offset: 0x007ACAFC
		public bool RdEgoO9DirLtbarPatternBcoListIndex_A36707_Editable
		{
			get
			{
				short num = (short)816431239;
				short num2 = num;
				num = (short)2056831111;
				switch (num2 == num)
				{
				}
				num = (short)1542062080;
				if (num != 0)
				{
				}
				num = (short)854196225;
				if (num != 0)
				{
				}
				num = (short)1587216384;
				short num3 = num;
				return this.rdEgoO9DirLtbarPatternBcoListIndex_A36707.Editable;
			}
			set
			{
				short num = (short)2046080451;
				short num2 = num;
				num = (short)993572291;
				switch (num2 == num)
				{
				}
				num = (short)346292225;
				if (num != 0)
				{
				}
				num = (short)1215365120;
				if (num != 0)
				{
				}
				num = (short)957284352;
				short num3 = num;
				this.rdEgoO9DirLtbarPatternBcoListIndex_A36707.Editable = value;
			}
		}

		// Token: 0x17004359 RID: 17241
		// (get) Token: 0x06008459 RID: 33881 RVA: 0x007AE9B0 File Offset: 0x007ACBB0
		internal string RdEgoO9DirLtbarPatternBcoListIndex_A36707_UILabel
		{
			get
			{
				short num = (short)1524809735;
				short num2 = num;
				num = (short)540262407;
				switch (num2 == num)
				{
				}
				num = (short)153747457;
				if (num != 0)
				{
				}
				num = (short)1744371712;
				if (num != 0)
				{
				}
				num = (short)1925316608;
				short num3 = num;
				return this.rdEgoO9DirLtbarPatternBcoListIndex_A36707.UIName;
			}
		}

		// Token: 0x1700435A RID: 17242
		// (get) Token: 0x0600845A RID: 33882 RVA: 0x007AEA64 File Offset: 0x007ACC64
		// (set) Token: 0x0600845B RID: 33883 RVA: 0x007AEB18 File Offset: 0x007ACD18
		internal bool RdEgoO9DirLtbarPatternBcoListIndex_A36707_HiddenStatic
		{
			get
			{
				short num = (short)142544269;
				short num2 = num;
				num = (short)574557581;
				switch (num2 == num)
				{
				}
				num = (short)1194328065;
				if (num != 0)
				{
				}
				num = (short)239665152;
				if (num != 0)
				{
				}
				num = (short)1810694144;
				short num3 = num;
				return this.rdEgoO9DirLtbarPatternBcoListIndex_A36707.HiddenStatic;
			}
			set
			{
				short num = (short)617499156;
				short num2 = num;
				num = (short)817973780;
				switch (num2 == num)
				{
				}
				num = (short)1794637824;
				if (num != 0)
				{
				}
				num = (short)1123614721;
				if (num != 0)
				{
				}
				num = (short)1669464064;
				short num3 = num;
				this.rdEgoO9DirLtbarPatternBcoListIndex_A36707.HiddenStatic = value;
			}
		}

		// Token: 0x1700435B RID: 17243
		// (get) Token: 0x0600845C RID: 33884 RVA: 0x007AEBD0 File Offset: 0x007ACDD0
		// (set) Token: 0x0600845D RID: 33885 RVA: 0x007AEC84 File Offset: 0x007ACE84
		internal bool RdEgoO9DirLtbarPatternBcoListIndex_A36707_HiddenDynamic
		{
			get
			{
				short num = (short)1291714561;
				if (num != 0)
				{
				}
				num = (short)677410212;
				short num2 = num;
				num = (short)424506788;
				switch (num2 == num)
				{
				}
				num = (short)615055360;
				if (num != 0)
				{
				}
				num = (short)660930560;
				short num3 = num;
				return this.rdEgoO9DirLtbarPatternBcoListIndex_A36707.HiddenDynamic;
			}
			set
			{
				short num = (short)1255711710;
				short num2 = num;
				num = (short)1657971678;
				switch (num2 == num)
				{
				}
				num = (short)1201143809;
				if (num != 0)
				{
				}
				num = (short)160956416;
				if (num != 0)
				{
				}
				num = (short)1288765440;
				short num3 = num;
				this.rdEgoO9DirLtbarPatternBcoListIndex_A36707.HiddenDynamic = value;
			}
		}

		// Token: 0x1700435C RID: 17244
		// (get) Token: 0x0600845E RID: 33886 RVA: 0x007AED38 File Offset: 0x007ACF38
		public bool RdEgoO9DirLtbarPatternBcoListIndex_A36707_HasDiffs
		{
			get
			{
				short num = (short)1380031456;
				short num2 = num;
				num = (short)451255264;
				switch (num2 == num)
				{
				}
				num = (short)1593638913;
				if (num != 0)
				{
				}
				num = (short)1780678656;
				if (num != 0)
				{
				}
				num = (short)1462108160;
				short num3 = num;
				return this.rdEgoO9DirLtbarPatternBcoListIndex_A36707._HasDiffs;
			}
		}

		// Token: 0x0600845F RID: 33887 RVA: 0x007AEDF0 File Offset: 0x007ACFF0
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
					num2 = (short)447021056;
					short num3 = num2;
					num2 = (short)1484674340;
					short num4 = num2;
					num2 = (short)230053156;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_3A;
					default:
						num2 = (short)1249705984;
						if (num2 != 0)
						{
						}
						result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
						num2 = (short)1275789315;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
					goto IL_3A;
				case 2:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)742785025;
						if (num2 != 0)
						{
						}
						num2 = (short)1538064384;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 3:
					return result;
				case 4:
					num2 = (short)830799874;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_24;
				IL_3A:
				if (base.ParentRecset == null)
				{
					break;
				}
				num2 = (short)581238788;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)1512701953;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04003E70 RID: 15984
		private global::AcpBusinessLayer.AcpListField rdEgoO9DirLtbarPatternBcoListBco_A36661;

		// Token: 0x04003E71 RID: 15985
		private global::AcpBusinessLayer.AcpRecRefField rdEgoO9DirLtbarPatternBcoListIndex_A36707;
	}
}
