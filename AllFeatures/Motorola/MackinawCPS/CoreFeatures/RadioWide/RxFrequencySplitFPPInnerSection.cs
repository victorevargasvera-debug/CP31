using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.RadioWide
{
	// Token: 0x02000184 RID: 388
	[global::System.Serializable]
	public class RxFrequencySplitFPPInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06003E6A RID: 15978 RVA: 0x003AE34C File Offset: 0x003AC54C
		public RxFrequencySplitFPPInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06003E6B RID: 15979 RVA: 0x003AE368 File Offset: 0x003AC568
		protected RxFrequencySplitFPPInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06003E6C RID: 15980 RVA: 0x003AE380 File Offset: 0x003AC580
		public override void Init()
		{
			int a_ = 7;
			short num = (short)858914646;
			short num2 = num;
			num = (short)668204886;
			switch (num2 == num)
			{
			}
			num = (short)862519296;
			short num3 = num;
			num = (short)868614145;
			if (num != 0)
			{
			}
			num = (short)301072384;
			if (num != 0)
			{
			}
			this.radWideLabtoolRxEndFrequencySplit_A9015 = new global::AcpBusinessLayer.AcpFrequencyField(0, this, global::AllFeatures.CodeplugGuid.b("髇ꯉ꣋駍맏뛑뇓髕맗룙꣛뇝迟軡뛣黥귧蓩裫꣭苯韱藳菵鷷铹鿻蟽叿爁栃漅簇唉䴋㜍‏⌑ℓ", a_), global::CommonResources.AcgResources.ID_RXENDFREQUENCYSPLIT, 0, int.MaxValue, 1);
			this.radWideLabtoolRxEndFrequencySplit_A9015.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radWideLabtoolRxEndFrequencySplit_A9015.DataTransferOrder = -1;
			this.radWideLabtoolRxStartFrequencySplit_A9032 = new global::AcpBusinessLayer.AcpFrequencyField(0, this, global::AllFeatures.CodeplugGuid.b("髇ꯉ꣋駍맏뛑뇓髕맗룙꣛뇝迟軡뛣黥믧黩跫鳭蓯등蛳鏵觷迹駻都揿笁圃瘅搇按砋儍儏⬑␓┕⨗", a_), global::CommonResources.AcgResources.ID_RXSTARTFREQUENCYSPLIT, 0, int.MaxValue, 1);
			this.radWideLabtoolRxStartFrequencySplit_A9032.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radWideLabtoolRxStartFrequencySplit_A9032.DataTransferOrder = -1;
			this.radWideLabtoolRxBandSplitName_A24797 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_VHF, this, global::AllFeatures.CodeplugGuid.b("髇ꯉ꣋駍맏뛑뇓髕맗룙꣛뇝迟軡뛣黥ꫧ诩苫諭ꏯ英飳鿵賷듹鷻鏽旿崁䔃㐅㰇㴉㔋㤍", a_), global::CommonResources.AcgResources.ID_RXBANDSPLITNAME, 100);
			this.radWideLabtoolRxBandSplitName_A24797.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radWideLabtoolRxBandSplitName_A24797.DataTransferOrder = -1;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("髇닉裍ꋏ럑ꗓꏕ뷗듙뿛꟝샟뇡铣諥臧黩쳫웭뛯ꋱꓳ\udff5", a_);
			base.Id = 10097;
			base.UIName = global::CommonResources.AcgResources.ID_RXFREQUENCYSPLITFPP;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06003E6D RID: 15981 RVA: 0x003AE520 File Offset: 0x003AC720
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 9;
			short num = (short)1569718277;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_23B;
				case 1:
					num = (short)1130364934;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_27A;
				case 3:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("飉귋꫍蟏믑냓돕铗믙뻛ꫝ迟跡裣듥郧맩飫迭苯蛱닳蓵鷷诹觻鯽滿愁紃唅砇昉攋稍伏匑ⴓ☕⬗⠙", a_)))
					{
						num = (short)185139212;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_27A;
				case 4:
					if (producerFields != null)
					{
						num = (short)1029242881;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_31A;
				case 5:
					num = (short)1215561729;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_8A;
					}
					continue;
				case 6:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("飉귋꫍蟏믑냓돕铗믙뻛ꫝ迟跡裣듥郧꿩苫諭뛯胱釳蟵跷鿹鋻鷽秿儁球樅愇縉匋伍⤏∑┓⌕", a_)))
					{
						num = (short)1516109831;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_14F;
				case 7:
					this.radWideLabtoolRxEndFrequencySplit_A9015 = new global::AcpBusinessLayer.AcpFrequencyField(0, this, global::AllFeatures.CodeplugGuid.b("飉귋꫍蟏믑냓돕铗믙뻛ꫝ迟跡裣듥郧꿩苫諭뛯胱釳蟵跷鿹鋻鷽秿儁球樅愇縉匋伍⤏∑┓⌕", a_), global::CommonResources.AcgResources.ID_RXENDFREQUENCYSPLIT);
					this.radWideLabtoolRxEndFrequencySplit_A9015.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radWideLabtoolRxEndFrequencySplit_A9015.DataTransferOrder = -1;
					num = (short)873398282;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("飉귋꫍蟏믑냓돕铗믙뻛ꫝ迟跡裣듥郧꣩跫胭铯ꇱ蓳髵釷軹닻鿽淿朁嬃䜅㨇㸉㬋㜍✏", a_)))
					{
						num = (short)1609367561;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_31A;
				case 9:
					this.radWideLabtoolRxBandSplitName_A24797 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_VHF, this, global::AllFeatures.CodeplugGuid.b("飉귋꫍蟏믑냓돕铗믙뻛ꫝ迟跡裣듥郧꣩跫胭铯ꇱ蓳髵釷軹닻鿽淿朁嬃䜅㨇㸉㬋㜍✏", a_), global::CommonResources.AcgResources.ID_RXBANDSPLITNAME, 100);
					this.radWideLabtoolRxBandSplitName_A24797.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radWideLabtoolRxBandSplitName_A24797.DataTransferOrder = -1;
					num = (short)540475392;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					goto IL_14F;
				case 11:
					num = (short)2051407876;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					this.radWideLabtoolRxStartFrequencySplit_A9032 = new global::AcpBusinessLayer.AcpFrequencyField(0, this, global::AllFeatures.CodeplugGuid.b("飉귋꫍蟏믑냓돕铗믙뻛ꫝ迟跡裣듥郧맩飫迭苯蛱닳蓵鷷诹觻鯽滿愁紃唅砇昉攋稍伏匑ⴓ☕⬗⠙", a_), global::CommonResources.AcgResources.ID_RXSTARTFREQUENCYSPLIT);
					this.radWideLabtoolRxStartFrequencySplit_A9032.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radWideLabtoolRxStartFrequencySplit_A9032.DataTransferOrder = -1;
					num = (short)281804802;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_8A:
				if (!global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					break;
				}
				num = (short)745773076;
				short num3 = num;
				num = (short)584226836;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_27A;
				default:
					num = (short)1693843456;
					if (num != 0)
					{
					}
					num = (short)2043805707;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_14F:
				num = (short)921174019;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_27A:
				num = (short)1939079176;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_23B:
			IL_31A:
			num = (short)645201920;
			short num4 = num;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("飉듋雏ꃑ뇓ꟕ귗뿙닛뷝駟싡럣雥蓧菩飫컭\ud8ef등ꓳ꛵퇷", a_);
			base.Id = 10097;
			base.UIName = global::CommonResources.AcgResources.ID_RXFREQUENCYSPLITFPP;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06003E6E RID: 15982 RVA: 0x003AE8A4 File Offset: 0x003ACAA4
		public override void PopulateReferences()
		{
			short num = (short)1771044865;
			if (num != 0)
			{
			}
			num = (short)1982800562;
			short num2 = num;
			num = (short)52175538;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1649606656;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1673134080;
			if (num != 0)
			{
			}
		}

		// Token: 0x06003E6F RID: 15983 RVA: 0x003AE94C File Offset: 0x003ACB4C
		public override void DropReferences()
		{
			short num = (short)2134474538;
			short num2 = num;
			num = (short)123043626;
			switch (num2 == num)
			{
			}
			num = (short)570556416;
			short num3 = num;
			num = (short)1057292288;
			if (num != 0)
			{
			}
			num = (short)830996481;
			if (num != 0)
			{
			}
		}

		// Token: 0x06003E70 RID: 15984 RVA: 0x003AE9F8 File Offset: 0x003ACBF8
		public override void SetConstraints()
		{
			short num = (short)1068942727;
			short num2 = num;
			num = (short)1392100743;
			switch (num2 == num)
			{
			}
			num = (short)1720385536;
			short num3 = num;
			num = (short)1020723201;
			if (num != 0)
			{
			}
			num = (short)2069889024;
			if (num != 0)
			{
			}
			this.radWideLabtoolRxBandSplitName_A24797.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
		}

		// Token: 0x06003E71 RID: 15985 RVA: 0x003AEAB4 File Offset: 0x003ACCB4
		public override void SetupDependencies()
		{
			short num = (short)704963228;
			short num2 = num;
			num = (short)1788142236;
			switch (num2 == num)
			{
			}
			num = (short)943063040;
			short num3 = num;
			num = (short)1064435713;
			if (num != 0)
			{
			}
			num = (short)1235353600;
			if (num != 0)
			{
			}
		}

		// Token: 0x17001FFB RID: 8187
		// (get) Token: 0x06003E72 RID: 15986 RVA: 0x003AEB60 File Offset: 0x003ACD60
		public bool HasDiffs
		{
			get
			{
				short num = (short)1741694148;
				short num2 = num;
				num = (short)1705911492;
				switch (num2 == num)
				{
				}
				num = (short)242810880;
				short num3 = num;
				num = (short)1038024705;
				if (num != 0)
				{
				}
				num = (short)36962304;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17001FFC RID: 8188
		// (get) Token: 0x06003E73 RID: 15987 RVA: 0x003AEC10 File Offset: 0x003ACE10
		// (set) Token: 0x06003E74 RID: 15988 RVA: 0x003AECC4 File Offset: 0x003ACEC4
		public int RadWideLabtoolRxEndFrequencySplit_A9015Value
		{
			get
			{
				short num = (short)980025345;
				if (num != 0)
				{
				}
				num = (short)301116726;
				short num2 = num;
				num = (short)1496952118;
				switch (num2 == num)
				{
				default:
				{
					num = (short)610861056;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1742733312;
				if (num != 0)
				{
				}
				return this.radWideLabtoolRxEndFrequencySplit_A9015.Value;
			}
			set
			{
				short num = (short)1077163317;
				short num2 = num;
				num = (short)1514681653;
				switch (num2 == num)
				{
				}
				num = (short)1060175872;
				short num3 = num;
				num = (short)97386497;
				if (num != 0)
				{
				}
				num = (short)24838144;
				if (num != 0)
				{
				}
				this.radWideLabtoolRxEndFrequencySplit_A9015.Value = value;
			}
		}

		// Token: 0x17001FFD RID: 8189
		// (get) Token: 0x06003E75 RID: 15989 RVA: 0x003AED7C File Offset: 0x003ACF7C
		// (set) Token: 0x06003E76 RID: 15990 RVA: 0x003AEE34 File Offset: 0x003AD034
		public string RadWideLabtoolRxEndFrequencySplit_A9015_UIValue
		{
			get
			{
				short num = (short)1554397174;
				short num2 = num;
				num = (short)1142503414;
				switch (num2 == num)
				{
				}
				num = (short)272760832;
				short num3 = num;
				num = (short)1554251776;
				if (num != 0)
				{
				}
				num = (short)1350828033;
				if (num != 0)
				{
				}
				return this.radWideLabtoolRxEndFrequencySplit_A9015.UIValue;
			}
			set
			{
				short num = (short)1096708888;
				short num2 = num;
				num = (short)36270872;
				switch (num2 == num)
				{
				}
				num = (short)1572470784;
				short num3 = num;
				num = (short)1217789952;
				if (num != 0)
				{
				}
				num = (short)540672001;
				if (num != 0)
				{
				}
				this.radWideLabtoolRxEndFrequencySplit_A9015.UIValue = value;
			}
		}

		// Token: 0x17001FFE RID: 8190
		// (get) Token: 0x06003E77 RID: 15991 RVA: 0x003AEEE8 File Offset: 0x003AD0E8
		public global::AcpBusinessLayer.AcpFrequencyField RadWideLabtoolRxEndFrequencySplit_A9015
		{
			get
			{
				short num = (short)1782958509;
				short num2 = num;
				num = (short)1779091885;
				switch (num2 == num)
				{
				}
				num = (short)470089728;
				short num3 = num;
				num = (short)668598273;
				if (num != 0)
				{
				}
				num = (short)1531772928;
				if (num != 0)
				{
				}
				return this.radWideLabtoolRxEndFrequencySplit_A9015;
			}
		}

		// Token: 0x17001FFF RID: 8191
		// (get) Token: 0x06003E78 RID: 15992 RVA: 0x003AEF98 File Offset: 0x003AD198
		// (set) Token: 0x06003E79 RID: 15993 RVA: 0x003AF04C File Offset: 0x003AD24C
		internal int RadWideLabtoolRxEndFrequencySplit_A9015Min
		{
			get
			{
				short num = (short)2044561468;
				short num2 = num;
				num = (short)809732156;
				switch (num2 == num)
				{
				}
				num = (short)166920192;
				short num3 = num;
				num = (short)1040449536;
				if (num != 0)
				{
				}
				num = (short)1225457665;
				if (num != 0)
				{
				}
				return this.radWideLabtoolRxEndFrequencySplit_A9015.Min;
			}
			set
			{
				short num = (short)1491133855;
				short num2 = num;
				num = (short)1199826335;
				switch (num2 == num)
				{
				}
				num = (short)1104871424;
				short num3 = num;
				num = (short)1965162497;
				if (num != 0)
				{
				}
				num = (short)200474624;
				if (num != 0)
				{
				}
				this.radWideLabtoolRxEndFrequencySplit_A9015.Min = value;
			}
		}

		// Token: 0x17002000 RID: 8192
		// (get) Token: 0x06003E7A RID: 15994 RVA: 0x003AF104 File Offset: 0x003AD304
		// (set) Token: 0x06003E7B RID: 15995 RVA: 0x003AF1B8 File Offset: 0x003AD3B8
		internal int RadWideLabtoolRxEndFrequencySplit_A9015Max
		{
			get
			{
				short num = (short)1098537599;
				short num2 = num;
				num = (short)2032753279;
				switch (num2 == num)
				{
				}
				num = (short)427819008;
				short num3 = num;
				num = (short)352059392;
				if (num != 0)
				{
				}
				num = (short)1855193089;
				if (num != 0)
				{
				}
				return this.radWideLabtoolRxEndFrequencySplit_A9015.Max;
			}
			set
			{
				short num = (short)1070596096;
				short num2 = num;
				num = (short)327922862;
				short num3 = num;
				num = (short)877507758;
				switch (num3 == num)
				{
				}
				num = (short)1137508353;
				if (num != 0)
				{
				}
				num = (short)627965952;
				if (num != 0)
				{
				}
				this.radWideLabtoolRxEndFrequencySplit_A9015.Max = value;
			}
		}

		// Token: 0x17002001 RID: 8193
		// (get) Token: 0x06003E7C RID: 15996 RVA: 0x003AF274 File Offset: 0x003AD474
		// (set) Token: 0x06003E7D RID: 15997 RVA: 0x003AF328 File Offset: 0x003AD528
		internal int RadWideLabtoolRxEndFrequencySplit_A9015Step
		{
			get
			{
				short num = (short)864092160;
				short num2 = num;
				num = (short)1228198857;
				short num3 = num;
				num = (short)911987657;
				switch (num3 == num)
				{
				}
				num = (short)1545797633;
				if (num != 0)
				{
				}
				num = (short)964165632;
				if (num != 0)
				{
				}
				return this.radWideLabtoolRxEndFrequencySplit_A9015.StepSize;
			}
			set
			{
				short num = (short)991363072;
				short num2 = num;
				num = (short)1433630902;
				short num3 = num;
				num = (short)1132886198;
				switch (num3 == num)
				{
				}
				num = (short)222560257;
				if (num != 0)
				{
				}
				num = (short)2036662272;
				if (num != 0)
				{
				}
				this.radWideLabtoolRxEndFrequencySplit_A9015.StepSize = value;
			}
		}

		// Token: 0x17002002 RID: 8194
		// (get) Token: 0x06003E7E RID: 15998 RVA: 0x003AF3DC File Offset: 0x003AD5DC
		// (set) Token: 0x06003E7F RID: 15999 RVA: 0x003AF490 File Offset: 0x003AD690
		public bool RadWideLabtoolRxEndFrequencySplit_A9015_Applicable
		{
			get
			{
				short num = (short)1853227008;
				short num2 = num;
				num = (short)1741094913;
				if (num != 0)
				{
				}
				num = (short)1057488331;
				short num3 = num;
				num = (short)760937931;
				switch (num3 == num)
				{
				}
				num = (short)212140032;
				if (num != 0)
				{
				}
				return this.radWideLabtoolRxEndFrequencySplit_A9015.Applicable;
			}
			set
			{
				short num = (short)1745813504;
				short num2 = num;
				num = (short)362012767;
				short num3 = num;
				num = (short)1744625759;
				switch (num3 == num)
				{
				}
				num = (short)208666625;
				if (num != 0)
				{
				}
				num = (short)1000013824;
				if (num != 0)
				{
				}
				this.radWideLabtoolRxEndFrequencySplit_A9015.Applicable = value;
			}
		}

		// Token: 0x17002003 RID: 8195
		// (get) Token: 0x06003E80 RID: 16000 RVA: 0x003AF544 File Offset: 0x003AD744
		// (set) Token: 0x06003E81 RID: 16001 RVA: 0x003AF5F8 File Offset: 0x003AD7F8
		public bool RadWideLabtoolRxEndFrequencySplit_A9015_Valid
		{
			get
			{
				short num = (short)918028288;
				short num2 = num;
				num = (short)1759686193;
				short num3 = num;
				num = (short)1990700593;
				switch (num3 == num)
				{
				}
				num = (short)707919872;
				if (num != 0)
				{
				}
				num = (short)1358757889;
				if (num != 0)
				{
				}
				return this.radWideLabtoolRxEndFrequencySplit_A9015.Valid;
			}
			set
			{
				short num = (short)901120000;
				short num2 = num;
				num = (short)152880926;
				short num3 = num;
				num = (short)195938078;
				switch (num3 == num)
				{
				}
				num = (short)1462108161;
				if (num != 0)
				{
				}
				num = (short)477560832;
				if (num != 0)
				{
				}
				this.radWideLabtoolRxEndFrequencySplit_A9015.Valid = value;
			}
		}

		// Token: 0x17002004 RID: 8196
		// (get) Token: 0x06003E82 RID: 16002 RVA: 0x003AF6AC File Offset: 0x003AD8AC
		// (set) Token: 0x06003E83 RID: 16003 RVA: 0x003AF760 File Offset: 0x003AD960
		public bool RadWideLabtoolRxEndFrequencySplit_A9015_Visible
		{
			get
			{
				short num = (short)502726656;
				short num2 = num;
				num = (short)1536098305;
				if (num != 0)
				{
				}
				num = (short)987733460;
				short num3 = num;
				num = (short)1770757588;
				switch (num3 == num)
				{
				}
				num = (short)592642048;
				if (num != 0)
				{
				}
				return this.radWideLabtoolRxEndFrequencySplit_A9015.Visible;
			}
			set
			{
				short num = (short)634781696;
				short num2 = num;
				num = (short)2010073643;
				short num3 = num;
				num = (short)850807339;
				switch (num3 == num)
				{
				}
				num = (short)975110145;
				if (num != 0)
				{
				}
				num = (short)336068608;
				if (num != 0)
				{
				}
				this.radWideLabtoolRxEndFrequencySplit_A9015.Visible = value;
			}
		}

		// Token: 0x17002005 RID: 8197
		// (get) Token: 0x06003E84 RID: 16004 RVA: 0x003AF814 File Offset: 0x003ADA14
		// (set) Token: 0x06003E85 RID: 16005 RVA: 0x003AF8C8 File Offset: 0x003ADAC8
		public bool RadWideLabtoolRxEndFrequencySplit_A9015_Editable
		{
			get
			{
				short num = (short)1545535488;
				short num2 = num;
				num = (short)1695431982;
				short num3 = num;
				num = (short)36257070;
				switch (num3 == num)
				{
				}
				num = (short)455540736;
				if (num != 0)
				{
				}
				num = (short)868220929;
				if (num != 0)
				{
				}
				return this.radWideLabtoolRxEndFrequencySplit_A9015.Editable;
			}
			set
			{
				short num = (short)2114387968;
				short num2 = num;
				num = (short)2101412997;
				short num3 = num;
				num = (short)1165689989;
				switch (num3 == num)
				{
				}
				num = (short)1101922305;
				if (num != 0)
				{
				}
				num = (short)495976448;
				if (num != 0)
				{
				}
				this.radWideLabtoolRxEndFrequencySplit_A9015.Editable = value;
			}
		}

		// Token: 0x17002006 RID: 8198
		// (get) Token: 0x06003E86 RID: 16006 RVA: 0x003AF97C File Offset: 0x003ADB7C
		internal string RadWideLabtoolRxEndFrequencySplit_A9015_UILabel
		{
			get
			{
				short num = (short)217579520;
				short num2 = num;
				num = (short)762996951;
				short num3 = num;
				num = (short)56846551;
				switch (num3 == num)
				{
				}
				num = (short)731119617;
				if (num != 0)
				{
				}
				num = (short)764608512;
				if (num != 0)
				{
				}
				return this.radWideLabtoolRxEndFrequencySplit_A9015.UIName;
			}
		}

		// Token: 0x17002007 RID: 8199
		// (get) Token: 0x06003E87 RID: 16007 RVA: 0x003AFA30 File Offset: 0x003ADC30
		// (set) Token: 0x06003E88 RID: 16008 RVA: 0x003AFAE4 File Offset: 0x003ADCE4
		internal bool RadWideLabtoolRxEndFrequencySplit_A9015_HiddenStatic
		{
			get
			{
				short num = (short)1086455808;
				short num2 = num;
				num = (short)1846844925;
				short num3 = num;
				num = (short)65576445;
				switch (num3 == num)
				{
				}
				num = (short)1854013441;
				if (num != 0)
				{
				}
				num = (short)1122566144;
				if (num != 0)
				{
				}
				return this.radWideLabtoolRxEndFrequencySplit_A9015.HiddenStatic;
			}
			set
			{
				short num = (short)199229440;
				short num2 = num;
				num = (short)623608529;
				short num3 = num;
				num = (short)450134737;
				switch (num3 == num)
				{
				}
				num = (short)1175912449;
				if (num != 0)
				{
				}
				num = (short)1209335808;
				if (num != 0)
				{
				}
				this.radWideLabtoolRxEndFrequencySplit_A9015.HiddenStatic = value;
			}
		}

		// Token: 0x17002008 RID: 8200
		// (get) Token: 0x06003E89 RID: 16009 RVA: 0x003AFB98 File Offset: 0x003ADD98
		// (set) Token: 0x06003E8A RID: 16010 RVA: 0x003AFC50 File Offset: 0x003ADE50
		internal bool RadWideLabtoolRxEndFrequencySplit_A9015_HiddenDynamic
		{
			get
			{
				short num = (short)1817837568;
				short num2 = num;
				num = (short)1158019323;
				short num3 = num;
				num = (short)150534395;
				switch (num3 == num)
				{
				}
				num = (short)883818496;
				if (num != 0)
				{
				}
				num = (short)1955659777;
				if (num != 0)
				{
				}
				return this.radWideLabtoolRxEndFrequencySplit_A9015.HiddenDynamic;
			}
			set
			{
				short num = (short)246284288;
				short num2 = num;
				num = (short)1995388165;
				short num3 = num;
				num = (short)1486632197;
				switch (num3 == num)
				{
				}
				num = (short)1339752449;
				if (num != 0)
				{
				}
				num = (short)91684864;
				if (num != 0)
				{
				}
				this.radWideLabtoolRxEndFrequencySplit_A9015.HiddenDynamic = value;
			}
		}

		// Token: 0x17002009 RID: 8201
		// (get) Token: 0x06003E8B RID: 16011 RVA: 0x003AFD04 File Offset: 0x003ADF04
		public bool RadWideLabtoolRxEndFrequencySplit_A9015_HasDiffs
		{
			get
			{
				short num = (short)676134912;
				short num2 = num;
				num = (short)497549313;
				if (num != 0)
				{
				}
				num = (short)1378134978;
				short num3 = num;
				num = (short)1843243970;
				switch (num3 == num)
				{
				}
				num = (short)415039488;
				if (num != 0)
				{
				}
				return this.radWideLabtoolRxEndFrequencySplit_A9015._HasDiffs;
			}
		}

		// Token: 0x1700200A RID: 8202
		// (get) Token: 0x06003E8C RID: 16012 RVA: 0x003AFDB8 File Offset: 0x003ADFB8
		// (set) Token: 0x06003E8D RID: 16013 RVA: 0x003AFE6C File Offset: 0x003AE06C
		public int RadWideLabtoolRxStartFrequencySplit_A9032Value
		{
			get
			{
				short num = (short)1745420288;
				short num2 = num;
				num = (short)1064770419;
				short num3 = num;
				num = (short)1152392051;
				switch (num3 == num)
				{
				}
				num = (short)1674182657;
				if (num != 0)
				{
				}
				num = (short)240058368;
				if (num != 0)
				{
				}
				return this.radWideLabtoolRxStartFrequencySplit_A9032.Value;
			}
			set
			{
				short num = (short)689766400;
				short num2 = num;
				num = (short)996298578;
				short num3 = num;
				num = (short)1016287058;
				switch (num3 == num)
				{
				}
				num = (short)1661337601;
				if (num != 0)
				{
				}
				num = (short)765263872;
				if (num != 0)
				{
				}
				this.radWideLabtoolRxStartFrequencySplit_A9032.Value = value;
			}
		}

		// Token: 0x1700200B RID: 8203
		// (get) Token: 0x06003E8E RID: 16014 RVA: 0x003AFF20 File Offset: 0x003AE120
		// (set) Token: 0x06003E8F RID: 16015 RVA: 0x003AFFD8 File Offset: 0x003AE1D8
		public string RadWideLabtoolRxStartFrequencySplit_A9032_UIValue
		{
			get
			{
				short num = (short)1965096960;
				short num2 = num;
				num = (short)770244216;
				short num3 = num;
				num = (short)499842680;
				switch (num3 == num)
				{
				}
				num = (short)454361089;
				if (num != 0)
				{
				}
				num = (short)1673068544;
				if (num != 0)
				{
				}
				return this.radWideLabtoolRxStartFrequencySplit_A9032.UIValue;
			}
			set
			{
				short num = (short)561643520;
				short num2 = num;
				num = (short)2004760623;
				short num3 = num;
				num = (short)550320175;
				switch (num3 == num)
				{
				}
				num = (short)206045184;
				if (num != 0)
				{
				}
				num = (short)951123969;
				if (num != 0)
				{
				}
				this.radWideLabtoolRxStartFrequencySplit_A9032.UIValue = value;
			}
		}

		// Token: 0x1700200C RID: 8204
		// (get) Token: 0x06003E90 RID: 16016 RVA: 0x003B008C File Offset: 0x003AE28C
		public global::AcpBusinessLayer.AcpFrequencyField RadWideLabtoolRxStartFrequencySplit_A9032
		{
			get
			{
				short num = (short)1236205568;
				short num2 = num;
				num = (short)529266068;
				short num3 = num;
				num = (short)1110111636;
				switch (num3 == num)
				{
				}
				num = (short)1423310849;
				if (num != 0)
				{
				}
				num = (short)1127153664;
				if (num != 0)
				{
				}
				return this.radWideLabtoolRxStartFrequencySplit_A9032;
			}
		}

		// Token: 0x1700200D RID: 8205
		// (get) Token: 0x06003E91 RID: 16017 RVA: 0x003B0138 File Offset: 0x003AE338
		// (set) Token: 0x06003E92 RID: 16018 RVA: 0x003B01E8 File Offset: 0x003AE3E8
		internal int RadWideLabtoolRxStartFrequencySplit_A9032Min
		{
			get
			{
				short num = (short)783548416;
				short num2 = num;
				num = (short)830144513;
				if (num != 0)
				{
				}
				num = (short)140223026;
				short num3 = num;
				num = (short)1318298162;
				switch (num3 == num)
				{
				}
				num = (short)1749483520;
				if (num != 0)
				{
				}
				return this.radWideLabtoolRxStartFrequencySplit_A9032.Min;
			}
			set
			{
				short num = (short)387055616;
				short num2 = num;
				num = (short)995973935;
				short num3 = num;
				num = (short)902322991;
				switch (num3 == num)
				{
				}
				num = (short)1004470273;
				if (num != 0)
				{
				}
				num = (short)1031536640;
				if (num != 0)
				{
				}
				this.radWideLabtoolRxStartFrequencySplit_A9032.Min = value;
			}
		}

		// Token: 0x1700200E RID: 8206
		// (get) Token: 0x06003E93 RID: 16019 RVA: 0x003B02A0 File Offset: 0x003AE4A0
		// (set) Token: 0x06003E94 RID: 16020 RVA: 0x003B0358 File Offset: 0x003AE558
		internal int RadWideLabtoolRxStartFrequencySplit_A9032Max
		{
			get
			{
				short num = (short)1589772288;
				short num2 = num;
				num = (short)969794067;
				short num3 = num;
				num = (short)1197859347;
				switch (num3 == num)
				{
				}
				num = (short)11141121;
				if (num != 0)
				{
				}
				num = (short)516161536;
				if (num != 0)
				{
				}
				return this.radWideLabtoolRxStartFrequencySplit_A9032.Max;
			}
			set
			{
				short num = (short)2090598400;
				short num2 = num;
				num = (short)434182787;
				short num3 = num;
				num = (short)1733040771;
				switch (num3 == num)
				{
				}
				num = (short)615055361;
				if (num != 0)
				{
				}
				num = (short)88932352;
				if (num != 0)
				{
				}
				this.radWideLabtoolRxStartFrequencySplit_A9032.Max = value;
			}
		}

		// Token: 0x1700200F RID: 8207
		// (get) Token: 0x06003E95 RID: 16021 RVA: 0x003B040C File Offset: 0x003AE60C
		// (set) Token: 0x06003E96 RID: 16022 RVA: 0x003B04C0 File Offset: 0x003AE6C0
		internal int RadWideLabtoolRxStartFrequencySplit_A9032Step
		{
			get
			{
				short num = (short)315621376;
				short num2 = num;
				num = (short)89413273;
				short num3 = num;
				num = (short)248862361;
				switch (num3 == num)
				{
				}
				num = (short)1986789377;
				if (num != 0)
				{
				}
				num = (short)866254848;
				if (num != 0)
				{
				}
				return this.radWideLabtoolRxStartFrequencySplit_A9032.StepSize;
			}
			set
			{
				short num = (short)2129461248;
				short num2 = num;
				num = (short)487300116;
				short num3 = num;
				num = (short)1279630356;
				switch (num3 == num)
				{
				}
				num = (short)1610678273;
				if (num != 0)
				{
				}
				num = (short)1825177600;
				if (num != 0)
				{
				}
				this.radWideLabtoolRxStartFrequencySplit_A9032.StepSize = value;
			}
		}

		// Token: 0x17002010 RID: 8208
		// (get) Token: 0x06003E97 RID: 16023 RVA: 0x003B0578 File Offset: 0x003AE778
		// (set) Token: 0x06003E98 RID: 16024 RVA: 0x003B062C File Offset: 0x003AE82C
		public bool RadWideLabtoolRxStartFrequencySplit_A9032_Applicable
		{
			get
			{
				short num = (short)224460800;
				short num2 = num;
				num = (short)895591807;
				short num3 = num;
				num = (short)1718199679;
				switch (num3 == num)
				{
				}
				num = (short)518717440;
				if (num != 0)
				{
				}
				num = (short)738721793;
				if (num != 0)
				{
				}
				return this.radWideLabtoolRxStartFrequencySplit_A9032.Applicable;
			}
			set
			{
				short num = (short)1240596480;
				short num2 = num;
				num = (short)649998301;
				short num3 = num;
				num = (short)1045376989;
				switch (num3 == num)
				{
				}
				num = (short)198508545;
				if (num != 0)
				{
				}
				num = (short)1546846208;
				if (num != 0)
				{
				}
				this.radWideLabtoolRxStartFrequencySplit_A9032.Applicable = value;
			}
		}

		// Token: 0x17002011 RID: 8209
		// (get) Token: 0x06003E99 RID: 16025 RVA: 0x003B06E0 File Offset: 0x003AE8E0
		// (set) Token: 0x06003E9A RID: 16026 RVA: 0x003B0794 File Offset: 0x003AE994
		public bool RadWideLabtoolRxStartFrequencySplit_A9032_Valid
		{
			get
			{
				short num = (short)65929216;
				short num2 = num;
				num = (short)1617070877;
				short num3 = num;
				num = (short)1935772445;
				switch (num3 == num)
				{
				}
				num = (short)2017132545;
				if (num != 0)
				{
				}
				num = (short)1836646400;
				if (num != 0)
				{
				}
				return this.radWideLabtoolRxStartFrequencySplit_A9032.Valid;
			}
			set
			{
				short num = (short)841875456;
				short num2 = num;
				num = (short)967876280;
				short num3 = num;
				num = (short)344235704;
				switch (num3 == num)
				{
				}
				num = (short)1127940097;
				if (num != 0)
				{
				}
				num = (short)618594304;
				if (num != 0)
				{
				}
				this.radWideLabtoolRxStartFrequencySplit_A9032.Valid = value;
			}
		}

		// Token: 0x17002012 RID: 8210
		// (get) Token: 0x06003E9B RID: 16027 RVA: 0x003B0848 File Offset: 0x003AEA48
		// (set) Token: 0x06003E9C RID: 16028 RVA: 0x003B08FC File Offset: 0x003AEAFC
		public bool RadWideLabtoolRxStartFrequencySplit_A9032_Visible
		{
			get
			{
				short num = (short)1696268288;
				short num2 = num;
				num = (short)862102051;
				short num3 = num;
				num = (short)1954193955;
				switch (num3 == num)
				{
				}
				num = (short)231669761;
				if (num != 0)
				{
				}
				num = (short)57802752;
				if (num != 0)
				{
				}
				return this.radWideLabtoolRxStartFrequencySplit_A9032.Visible;
			}
			set
			{
				short num = (short)622067712;
				short num2 = num;
				num = (short)934376737;
				short num3 = num;
				num = (short)1542026529;
				switch (num3 == num)
				{
				}
				num = (short)1724973056;
				if (num != 0)
				{
				}
				num = (short)934543361;
				if (num != 0)
				{
				}
				this.radWideLabtoolRxStartFrequencySplit_A9032.Visible = value;
			}
		}

		// Token: 0x17002013 RID: 8211
		// (get) Token: 0x06003E9D RID: 16029 RVA: 0x003B09B4 File Offset: 0x003AEBB4
		// (set) Token: 0x06003E9E RID: 16030 RVA: 0x003B0A64 File Offset: 0x003AEC64
		public bool RadWideLabtoolRxStartFrequencySplit_A9032_Editable
		{
			get
			{
				short num = (short)1792868352;
				short num2 = num;
				num = (short)38715411;
				short num3 = num;
				num = (short)348110867;
				switch (num3 == num)
				{
				}
				num = (short)2018639873;
				if (num != 0)
				{
				}
				num = (short)1437925376;
				if (num != 0)
				{
				}
				return this.radWideLabtoolRxStartFrequencySplit_A9032.Editable;
			}
			set
			{
				short num = (short)1425014784;
				short num2 = num;
				num = (short)2028539149;
				short num3 = num;
				num = (short)581766413;
				switch (num3 == num)
				{
				}
				num = (short)1685127168;
				if (num != 0)
				{
				}
				num = (short)1514799105;
				if (num != 0)
				{
				}
				this.radWideLabtoolRxStartFrequencySplit_A9032.Editable = value;
			}
		}

		// Token: 0x17002014 RID: 8212
		// (get) Token: 0x06003E9F RID: 16031 RVA: 0x003B0B18 File Offset: 0x003AED18
		internal string RadWideLabtoolRxStartFrequencySplit_A9032_UILabel
		{
			get
			{
				short num = (short)862453760;
				short num2 = num;
				num = (short)420770800;
				short num3 = num;
				num = (short)1885434864;
				switch (num3 == num)
				{
				}
				num = (short)1625358336;
				if (num != 0)
				{
				}
				num = (short)1074921473;
				if (num != 0)
				{
				}
				return this.radWideLabtoolRxStartFrequencySplit_A9032.UIName;
			}
		}

		// Token: 0x17002015 RID: 8213
		// (get) Token: 0x06003EA0 RID: 16032 RVA: 0x003B0BCC File Offset: 0x003AEDCC
		// (set) Token: 0x06003EA1 RID: 16033 RVA: 0x003B0C7C File Offset: 0x003AEE7C
		internal bool RadWideLabtoolRxStartFrequencySplit_A9032_HiddenStatic
		{
			get
			{
				short num = (short)325976064;
				short num2 = num;
				num = (short)1053332002;
				short num3 = num;
				num = (short)479892002;
				switch (num3 == num)
				{
				}
				num = (short)1105592321;
				if (num != 0)
				{
				}
				num = (short)30474240;
				if (num != 0)
				{
				}
				return this.radWideLabtoolRxStartFrequencySplit_A9032.HiddenStatic;
			}
			set
			{
				short num = (short)2101739520;
				short num2 = num;
				num = (short)1571283230;
				short num3 = num;
				num = (short)1862263070;
				switch (num3 == num)
				{
				}
				num = (short)2059206656;
				if (num != 0)
				{
				}
				num = (short)1152450561;
				if (num != 0)
				{
				}
				this.radWideLabtoolRxStartFrequencySplit_A9032.HiddenStatic = value;
			}
		}

		// Token: 0x17002016 RID: 8214
		// (get) Token: 0x06003EA2 RID: 16034 RVA: 0x003B0D30 File Offset: 0x003AEF30
		// (set) Token: 0x06003EA3 RID: 16035 RVA: 0x003B0DE0 File Offset: 0x003AEFE0
		internal bool RadWideLabtoolRxStartFrequencySplit_A9032_HiddenDynamic
		{
			get
			{
				short num = (short)460783616;
				short num2 = num;
				num = (short)1816070668;
				short num3 = num;
				num = (short)904595980;
				switch (num3 == num)
				{
				}
				num = (short)2072510465;
				if (num != 0)
				{
				}
				num = (short)1589182464;
				if (num != 0)
				{
				}
				return this.radWideLabtoolRxStartFrequencySplit_A9032.HiddenDynamic;
			}
			set
			{
				short num = (short)431947776;
				short num2 = num;
				num = (short)1414477879;
				short num3 = num;
				num = (short)2005547063;
				switch (num3 == num)
				{
				}
				num = (short)1336606720;
				if (num != 0)
				{
				}
				num = (short)1612644353;
				if (num != 0)
				{
				}
				this.radWideLabtoolRxStartFrequencySplit_A9032.HiddenDynamic = value;
			}
		}

		// Token: 0x17002017 RID: 8215
		// (get) Token: 0x06003EA4 RID: 16036 RVA: 0x003B0E98 File Offset: 0x003AF098
		public bool RadWideLabtoolRxStartFrequencySplit_A9032_HasDiffs
		{
			get
			{
				short num = (short)1519648768;
				short num2 = num;
				num = (short)161086016;
				short num3 = num;
				num = (short)120781376;
				switch (num3 == num)
				{
				}
				num = (short)816185344;
				if (num != 0)
				{
				}
				num = (short)393217;
				if (num != 0)
				{
				}
				return this.radWideLabtoolRxStartFrequencySplit_A9032._HasDiffs;
			}
		}

		// Token: 0x17002018 RID: 8216
		// (get) Token: 0x06003EA5 RID: 16037 RVA: 0x003B0F48 File Offset: 0x003AF148
		// (set) Token: 0x06003EA6 RID: 16038 RVA: 0x003B0FFC File Offset: 0x003AF1FC
		public string RadWideLabtoolRxBandSplitName_A24797Value
		{
			get
			{
				short num = (short)1662582784;
				short num2 = num;
				num = (short)557504646;
				short num3 = num;
				num = (short)2011093126;
				switch (num3 == num)
				{
				}
				num = (short)1764818945;
				if (num != 0)
				{
				}
				num = (short)2062221312;
				if (num != 0)
				{
				}
				return this.radWideLabtoolRxBandSplitName_A24797.Value;
			}
			set
			{
				short num = (short)1639055360;
				short num2 = num;
				num = (short)761872892;
				short num3 = num;
				num = (short)333201916;
				switch (num3 == num)
				{
				}
				num = (short)219348992;
				if (num != 0)
				{
				}
				num = (short)480247809;
				if (num != 0)
				{
				}
				this.radWideLabtoolRxBandSplitName_A24797.Value = value;
			}
		}

		// Token: 0x17002019 RID: 8217
		// (get) Token: 0x06003EA7 RID: 16039 RVA: 0x003B10B0 File Offset: 0x003AF2B0
		public global::AcpBusinessLayer.AcpField<string> RadWideLabtoolRxBandSplitName_A24797
		{
			get
			{
				short num = (short)2123628544;
				short num2 = num;
				num = (short)160022785;
				short num3 = num;
				num = (short)740540673;
				switch (num3 == num)
				{
				}
				num = (short)570687488;
				if (num != 0)
				{
				}
				num = (short)1285029889;
				if (num != 0)
				{
				}
				return this.radWideLabtoolRxBandSplitName_A24797;
			}
		}

		// Token: 0x1700201A RID: 8218
		// (get) Token: 0x06003EA8 RID: 16040 RVA: 0x003B1164 File Offset: 0x003AF364
		// (set) Token: 0x06003EA9 RID: 16041 RVA: 0x003B1218 File Offset: 0x003AF418
		public string RadWideLabtoolRxBandSplitName_A24797_UIValue
		{
			get
			{
				short num = (short)1270218752;
				short num2 = num;
				num = (short)1532656068;
				short num3 = num;
				num = (short)377977284;
				switch (num3 == num)
				{
				}
				num = (short)1238106112;
				if (num != 0)
				{
				}
				num = (short)1332019201;
				if (num != 0)
				{
				}
				return this.radWideLabtoolRxBandSplitName_A24797.Value;
			}
			set
			{
				short num = (short)775356416;
				short num2 = num;
				num = (short)1502774983;
				short num3 = num;
				num = (short)1312786119;
				switch (num3 == num)
				{
				}
				num = (short)659161089;
				if (num != 0)
				{
				}
				num = (short)1799487488;
				if (num != 0)
				{
				}
				this.radWideLabtoolRxBandSplitName_A24797.Value = value;
			}
		}

		// Token: 0x1700201B RID: 8219
		// (get) Token: 0x06003EAA RID: 16042 RVA: 0x003B12D0 File Offset: 0x003AF4D0
		// (set) Token: 0x06003EAB RID: 16043 RVA: 0x003B1388 File Offset: 0x003AF588
		public bool RadWideLabtoolRxBandSplitName_A24797_Applicable
		{
			get
			{
				short num = (short)1517158400;
				short num2 = num;
				num = (short)667429477;
				short num3 = num;
				num = (short)528886373;
				switch (num3 == num)
				{
				}
				num = (short)1951268865;
				if (num != 0)
				{
				}
				num = (short)805109760;
				if (num != 0)
				{
				}
				return this.radWideLabtoolRxBandSplitName_A24797.Applicable;
			}
			set
			{
				short num = (short)2038038528;
				short num2 = num;
				num = (short)1092500538;
				short num3 = num;
				num = (short)381631546;
				switch (num3 == num)
				{
				}
				num = (short)1982922753;
				if (num != 0)
				{
				}
				num = (short)192413696;
				if (num != 0)
				{
				}
				this.radWideLabtoolRxBandSplitName_A24797.Applicable = value;
			}
		}

		// Token: 0x1700201C RID: 8220
		// (get) Token: 0x06003EAC RID: 16044 RVA: 0x003B143C File Offset: 0x003AF63C
		// (set) Token: 0x06003EAD RID: 16045 RVA: 0x003B14F0 File Offset: 0x003AF6F0
		public bool RadWideLabtoolRxBandSplitName_A24797_Valid
		{
			get
			{
				short num = (short)758185984;
				short num2 = num;
				num = (short)255525617;
				short num3 = num;
				num = (short)622658289;
				switch (num3 == num)
				{
				}
				num = (short)1066336257;
				if (num != 0)
				{
				}
				num = (short)1598554112;
				if (num != 0)
				{
				}
				return this.radWideLabtoolRxBandSplitName_A24797.Valid;
			}
			set
			{
				short num = (short)748421120;
				short num2 = num;
				num = (short)1628489558;
				short num3 = num;
				num = (short)1257621334;
				switch (num3 == num)
				{
				}
				num = (short)1955397632;
				if (num != 0)
				{
				}
				num = (short)2016411649;
				if (num != 0)
				{
				}
				this.radWideLabtoolRxBandSplitName_A24797.Valid = value;
			}
		}

		// Token: 0x1700201D RID: 8221
		// (get) Token: 0x06003EAE RID: 16046 RVA: 0x003B15A8 File Offset: 0x003AF7A8
		// (set) Token: 0x06003EAF RID: 16047 RVA: 0x003B165C File Offset: 0x003AF85C
		public bool RadWideLabtoolRxBandSplitName_A24797_Visible
		{
			get
			{
				short num = (short)1737687040;
				short num2 = num;
				num = (short)1626517050;
				short num3 = num;
				num = (short)1972350522;
				switch (num3 == num)
				{
				}
				num = (short)1078788097;
				if (num != 0)
				{
				}
				num = (short)793247744;
				if (num != 0)
				{
				}
				return this.radWideLabtoolRxBandSplitName_A24797.Visible;
			}
			set
			{
				short num = (short)2081423360;
				short num2 = num;
				num = (short)124205290;
				short num3 = num;
				num = (short)2056599786;
				switch (num3 == num)
				{
				}
				num = (short)791478273;
				if (num != 0)
				{
				}
				num = (short)882114560;
				if (num != 0)
				{
				}
				this.radWideLabtoolRxBandSplitName_A24797.Visible = value;
			}
		}

		// Token: 0x1700201E RID: 8222
		// (get) Token: 0x06003EB0 RID: 16048 RVA: 0x003B1710 File Offset: 0x003AF910
		// (set) Token: 0x06003EB1 RID: 16049 RVA: 0x003B17C4 File Offset: 0x003AF9C4
		public bool RadWideLabtoolRxBandSplitName_A24797_Editable
		{
			get
			{
				short num = (short)1456472064;
				short num2 = num;
				num = (short)564717351;
				short num3 = num;
				num = (short)1864034087;
				switch (num3 == num)
				{
				}
				num = (short)1675165697;
				if (num != 0)
				{
				}
				num = (short)1466892288;
				if (num != 0)
				{
				}
				return this.radWideLabtoolRxBandSplitName_A24797.Editable;
			}
			set
			{
				short num = (short)1437401088;
				short num2 = num;
				num = (short)357695489;
				if (num != 0)
				{
				}
				num = (short)189080143;
				short num3 = num;
				num = (short)1195844175;
				switch (num3 == num)
				{
				}
				num = (short)577306624;
				if (num != 0)
				{
				}
				this.radWideLabtoolRxBandSplitName_A24797.Editable = value;
			}
		}

		// Token: 0x1700201F RID: 8223
		// (get) Token: 0x06003EB2 RID: 16050 RVA: 0x003B187C File Offset: 0x003AFA7C
		internal string RadWideLabtoolRxBandSplitName_A24797_UILabel
		{
			get
			{
				short num = (short)1029177344;
				short num2 = num;
				num = (short)1653128986;
				short num3 = num;
				num = (short)1769586458;
				switch (num3 == num)
				{
				}
				num = (short)676331521;
				if (num != 0)
				{
				}
				num = (short)1214447616;
				if (num != 0)
				{
				}
				return this.radWideLabtoolRxBandSplitName_A24797.UIName;
			}
		}

		// Token: 0x17002020 RID: 8224
		// (get) Token: 0x06003EB3 RID: 16051 RVA: 0x003B1934 File Offset: 0x003AFB34
		// (set) Token: 0x06003EB4 RID: 16052 RVA: 0x003B19E8 File Offset: 0x003AFBE8
		internal bool RadWideLabtoolRxBandSplitName_A24797_HiddenStatic
		{
			get
			{
				short num = (short)1663578519;
				short num2 = num;
				num = (short)288043415;
				switch (num2 == num)
				{
				}
				num = (short)1517748225;
				if (num != 0)
				{
				}
				num = (short)222363648;
				if (num != 0)
				{
				}
				num = (short)1107427328;
				short num3 = num;
				return this.radWideLabtoolRxBandSplitName_A24797.HiddenStatic;
			}
			set
			{
				short num = (short)251993479;
				short num2 = num;
				num = (short)315694471;
				switch (num2 == num)
				{
				}
				num = (short)1365508096;
				if (num != 0)
				{
				}
				num = (short)724828161;
				if (num != 0)
				{
				}
				num = (short)727973888;
				short num3 = num;
				this.radWideLabtoolRxBandSplitName_A24797.HiddenStatic = value;
			}
		}

		// Token: 0x17002021 RID: 8225
		// (get) Token: 0x06003EB5 RID: 16053 RVA: 0x003B1AA0 File Offset: 0x003AFCA0
		// (set) Token: 0x06003EB6 RID: 16054 RVA: 0x003B1B58 File Offset: 0x003AFD58
		internal bool RadWideLabtoolRxBandSplitName_A24797_HiddenDynamic
		{
			get
			{
				short num = (short)947723192;
				short num2 = num;
				num = (short)559619000;
				switch (num2 == num)
				{
				}
				num = (short)875036673;
				if (num != 0)
				{
				}
				num = (short)1385627648;
				if (num != 0)
				{
				}
				num = (short)419627008;
				short num3 = num;
				return this.radWideLabtoolRxBandSplitName_A24797.HiddenDynamic;
			}
			set
			{
				short num = (short)797492700;
				short num2 = num;
				num = (short)1828439516;
				switch (num2 == num)
				{
				}
				num = (short)1996881921;
				if (num != 0)
				{
				}
				num = (short)299827200;
				if (num != 0)
				{
				}
				num = (short)1875836928;
				short num3 = num;
				this.radWideLabtoolRxBandSplitName_A24797.HiddenDynamic = value;
			}
		}

		// Token: 0x17002022 RID: 8226
		// (get) Token: 0x06003EB7 RID: 16055 RVA: 0x003B1C0C File Offset: 0x003AFE0C
		public bool RadWideLabtoolRxBandSplitName_A24797_HasDiffs
		{
			get
			{
				short num = (short)1547655063;
				short num2 = num;
				num = (short)1523275671;
				switch (num2 == num)
				{
				}
				num = (short)173473793;
				if (num != 0)
				{
				}
				num = (short)934871040;
				if (num != 0)
				{
				}
				num = (short)285736960;
				short num3 = num;
				return this.radWideLabtoolRxBandSplitName_A24797._HasDiffs;
			}
		}

		// Token: 0x06003EB8 RID: 16056 RVA: 0x003B1CC4 File Offset: 0x003AFEC4
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
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)1172504580;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_B3;
				case 2:
				{
					if (base.ParentRecset.ContainerDoc == null)
					{
						goto IL_141;
					}
					num2 = (short)2139040522;
					short num3 = num2;
					num2 = (short)1340418826;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_B3;
					default:
						num2 = (short)1066926080;
						if (num2 != 0)
						{
						}
						num2 = (short)182386688;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 3:
					if (base.ParentRecset != null)
					{
						num2 = (short)1329528832;
						short num4 = num2;
						num2 = (short)1282080769;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_141;
				case 4:
					goto IL_AE;
				}
				goto IL_24;
				IL_B3:
				num2 = (short)1991704578;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_AE:
			IL_141:
			num2 = (short)1930821633;
			if (num2 != 0)
			{
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)1979777027;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x040019E9 RID: 6633
		private global::AcpBusinessLayer.AcpFrequencyField radWideLabtoolRxEndFrequencySplit_A9015;

		// Token: 0x040019EA RID: 6634
		private global::AcpBusinessLayer.AcpFrequencyField radWideLabtoolRxStartFrequencySplit_A9032;

		// Token: 0x040019EB RID: 6635
		private global::AcpBusinessLayer.AcpField<string> radWideLabtoolRxBandSplitName_A24797;
	}
}
