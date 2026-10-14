using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ScanList
{
	// Token: 0x0200011A RID: 282
	[global::System.Serializable]
	public class Labtool : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x060029A3 RID: 10659 RVA: 0x00289418 File Offset: 0x00287618
		public Labtool(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x060029A4 RID: 10660 RVA: 0x00289434 File Offset: 0x00287634
		protected Labtool(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x060029A5 RID: 10661 RVA: 0x0028944C File Offset: 0x0028764C
		public override void Init()
		{
			int a_ = 2;
			short num = (short)1191331017;
			short num2 = num;
			num = (short)1700742345;
			switch (num2 == num)
			{
			default:
			{
				num = (short)167116800;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1054867456;
			if (num != 0)
			{
			}
			num = (short)1774190593;
			if (num != 0)
			{
			}
			this.scanLstLabtoolLastVotedChannel_A8419 = new global::AcpBusinessLayer.AcpSimpleRangeField(0, this, global::AllFeatures.CodeplugGuid.b("郂ꛄꛆꟈ蟊뻌믎鷐닒럔ꏖ뛘듚뇜鏞胠郢釤뇦蛨鿪裬诮닰鯲铴駶韸黺釼ꃾ䀀㬂㄄㘆〈", a_), global::CommonResources.AcgResources.ID_LASTVOTEDCHANNEL, 0, 65535, null, null, 0, 1);
			this.scanLstLabtoolLastVotedChannel_A8419.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.scanLstLabtoolLastVotedChannel_A8419.DataTransferOrder = -1;
			this.scanLstLabtoolLastVotedChannel_A8419.ShowHexValue = false;
			this.scanLstLabtoolLastVotedZone_A8420 = new global::AcpBusinessLayer.AcpSimpleRangeField(0, this, global::AllFeatures.CodeplugGuid.b("郂ꛄꛆꟈ蟊뻌믎鷐닒럔ꏖ뛘듚뇜鏞胠郢釤뇦蛨鿪裬诮꯰鳲鯴鋶꛸뫺염쯾㌀㌂", a_), global::CommonResources.AcgResources.ID_LASTVOTEDZONE, 0, 65535, null, null, 0, 1);
			this.scanLstLabtoolLastVotedZone_A8420.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.scanLstLabtoolLastVotedZone_A8420.DataTransferOrder = -1;
			this.scanLstLabtoolLastVotedZone_A8420.ShowHexValue = false;
			this.scanLstLabtoolLTEInterferingFreqPresent_A42197 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("郂ꛄꛆꟈ蟊뻌믎鷐닒럔ꏖ뛘듚뇜鏞뗠ꛢ곤触鷨軪鿬觮铰臲鳴駶黸뷺迼髾瀀匂眄戆稈渊挌笎丐划℔┖⠘√⨜", a_), global::CommonResources.AcgResources.ID_LTEINTERFERINGFREQPRESENTINMEMBERLIST);
			this.scanLstLabtoolLTEInterferingFreqPresent_A42197.IgnoreOnCompare = true;
			this.scanLstLabtoolLTEInterferingFreqPresent_A42197.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.scanLstLabtoolLTEInterferingFreqPresent_A42197.DataTransferOrder = -1;
			this.scanLstLabtoolLTEInterferingFreqPresent_A42197.EvaluateRecRefs = true;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("迂꓄ꗆ뷈꓊ꋌꏎ", a_);
			base.Id = 10129;
			base.UIName = global::CommonResources.AcgResources.ID_LABTOOL;
			base.DataTransferOrder = 4;
		}

		// Token: 0x060029A6 RID: 10662 RVA: 0x0028961C File Offset: 0x0028781C
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 10;
			short num = (short)2112159746;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1370036930;
				short num3 = num;
				num = (short)1527913154;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1965359104;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						this.scanLstLabtoolLastVotedZone_A8420 = new global::AcpBusinessLayer.AcpSimpleRangeField(0, this, global::AllFeatures.CodeplugGuid.b("飊껌껎뿐鿒ꛔꏖ闘뫚뿜ꯞ軠賢觤ꯦ裨飪駬맮黰蟲郴鏶ꏸ铺鏼髾帀䈂㴄㌆㬈㬊", a_), global::CommonResources.AcgResources.ID_LASTVOTEDZONE, null, null, 0, 1);
						this.scanLstLabtoolLastVotedZone_A8420.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
						this.scanLstLabtoolLastVotedZone_A8420.DataTransferOrder = -1;
						this.scanLstLabtoolLastVotedZone_A8420.ShowHexValue = false;
						num = (short)1096679434;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						this.scanLstLabtoolLastVotedChannel_A8419 = new global::AcpBusinessLayer.AcpSimpleRangeField(0, this, global::AllFeatures.CodeplugGuid.b("飊껌껎뿐鿒ꛔꏖ闘뫚뿜ꯞ軠賢觤ꯦ裨飪駬맮黰蟲郴鏶뫸鏺鳼釾漀昂椄堆䠈㌊㤌㸎⠐", a_), global::CommonResources.AcgResources.ID_LASTVOTEDCHANNEL, null, null, 0, 1);
						this.scanLstLabtoolLastVotedChannel_A8419.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
						this.scanLstLabtoolLastVotedChannel_A8419.DataTransferOrder = -1;
						this.scanLstLabtoolLastVotedChannel_A8419.ShowHexValue = false;
						num = (short)2066481163;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_AC;
						}
						continue;
					case 3:
						if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("飊껌껎뿐鿒ꛔꏖ闘뫚뿜ꯞ軠賢觤ꯦ裨飪駬맮黰蟲郴鏶뫸鏺鳼釾漀昂椄堆䠈㌊㤌㸎⠐", a_)))
						{
							num = (short)377421825;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_15F;
					case 4:
						goto IL_2A3;
					case 5:
						if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("飊껌껎뿐鿒ꛔꏖ闘뫚뿜ꯞ軠賢觤ꯦ裨飪駬맮黰蟲郴鏶ꏸ铺鏼髾帀䈂㴄㌆㬈㬊", a_)))
						{
							num = (short)1990721536;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2C6;
					case 6:
						this.scanLstLabtoolLTEInterferingFreqPresent_A42197 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("飊껌껎뿐鿒ꛔꏖ闘뫚뿜ꯞ軠賢觤ꯦ뷨껪ꓬ臮藰雲蟴釶鳸觺铼釾昀䔂眄戆砈嬊缌樎成瘒笔挖䘘娚⤜ⴞဠᨢሤ", a_), global::CommonResources.AcgResources.ID_LTEINTERFERINGFREQPRESENTINMEMBERLIST);
						this.scanLstLabtoolLTEInterferingFreqPresent_A42197.IgnoreOnCompare = true;
						this.scanLstLabtoolLTEInterferingFreqPresent_A42197.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
						this.scanLstLabtoolLTEInterferingFreqPresent_A42197.DataTransferOrder = -1;
						this.scanLstLabtoolLTEInterferingFreqPresent_A42197.EvaluateRecRefs = true;
						num = (short)1003225100;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						num = (short)1458372612;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						num = (short)415760387;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("飊껌껎뿐鿒ꛔꏖ闘뫚뿜ꯞ軠賢觤ꯦ뷨껪ꓬ臮藰雲蟴釶鳸觺铼釾昀䔂眄戆砈嬊缌樎成瘒笔挖䘘娚⤜ⴞဠᨢሤ", a_)))
						{
							num = (short)1721237510;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_378;
					case 10:
						goto IL_2C6;
					case 11:
						goto IL_15F;
					case 12:
						goto IL_260;
					}
					IL_AC:
					num = (short)2006515712;
					short num4 = num;
					if (global::AcpCommonLib.AppInfoManager.DropOperation)
					{
						num = (short)1697906695;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_378;
					IL_15F:
					num = (short)242810885;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2C6:
					num = (short)783548425;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_2A3:
				if (producerFields == null)
				{
					goto IL_378;
				}
				num = (short)1854406664;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_260:
			num = (short)1756758017;
			if (num != 0)
			{
			}
			IL_378:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("蟊곌귎ꗐ볒뫔믖", a_);
			base.Id = 10129;
			base.UIName = global::CommonResources.AcgResources.ID_LABTOOL;
			base.DataTransferOrder = 4;
		}

		// Token: 0x060029A7 RID: 10663 RVA: 0x002899D4 File Offset: 0x00287BD4
		public override void PopulateReferences()
		{
			short num = (short)807923090;
			short num2 = num;
			num = (short)2104421778;
			switch (num2 == num)
			{
			default:
			{
				num = (short)193069056;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)916193281;
			if (num != 0)
			{
			}
			num = (short)1011023872;
			if (num != 0)
			{
			}
		}

		// Token: 0x060029A8 RID: 10664 RVA: 0x00289A80 File Offset: 0x00287C80
		public override void DropReferences()
		{
			short num = (short)1368586422;
			short num2 = num;
			num = (short)338163894;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1138294784;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)493551617;
			if (num != 0)
			{
			}
			num = (short)358481920;
			if (num != 0)
			{
			}
		}

		// Token: 0x060029A9 RID: 10665 RVA: 0x00289B28 File Offset: 0x00287D28
		public override void SetConstraints()
		{
			short num = (short)1805637622;
			short num2 = num;
			num = (short)2133841910;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1581645824;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2129002497;
			if (num != 0)
			{
			}
			num = (short)425590784;
			if (num != 0)
			{
			}
			this.scanLstLabtoolLTEInterferingFreqPresent_A42197.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
		}

		// Token: 0x060029AA RID: 10666 RVA: 0x00289BE4 File Offset: 0x00287DE4
		public override void SetupDependencies()
		{
			short num = (short)2039408229;
			short num2 = num;
			num = (short)697624165;
			switch (num2 == num)
			{
			default:
			{
				num = (short)732758016;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1863909376;
			if (num != 0)
			{
			}
			num = (short)1194328065;
			if (num != 0)
			{
			}
		}

		// Token: 0x170014E1 RID: 5345
		// (get) Token: 0x060029AB RID: 10667 RVA: 0x00289C8C File Offset: 0x00287E8C
		public bool HasDiffs
		{
			get
			{
				short num = (short)1799125878;
				short num2 = num;
				num = (short)1820359542;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1582235648;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)302645249;
				if (num != 0)
				{
				}
				num = (short)1905131520;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x170014E2 RID: 5346
		// (get) Token: 0x060029AC RID: 10668 RVA: 0x00289D3C File Offset: 0x00287F3C
		// (set) Token: 0x060029AD RID: 10669 RVA: 0x00289DF0 File Offset: 0x00287FF0
		public int ScanLstLabtoolLastVotedChannel_A8419Value
		{
			get
			{
				short num = (short)1004208129;
				if (num != 0)
				{
				}
				num = (short)497287168;
				short num2 = num;
				num = (short)665530003;
				short num3 = num;
				num = (short)575811219;
				switch (num3 == num)
				{
				}
				num = (short)236322816;
				if (num != 0)
				{
				}
				return this.scanLstLabtoolLastVotedChannel_A8419.Value;
			}
			set
			{
				short num = (short)462922777;
				short num2 = num;
				num = (short)1809753113;
				switch (num2 == num)
				{
				default:
				{
					num = (short)71303168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1260060673;
				if (num != 0)
				{
				}
				num = (short)402784256;
				if (num != 0)
				{
				}
				this.scanLstLabtoolLastVotedChannel_A8419.Value = value;
			}
		}

		// Token: 0x170014E3 RID: 5347
		// (get) Token: 0x060029AE RID: 10670 RVA: 0x00289EA4 File Offset: 0x002880A4
		public global::AcpBusinessLayer.AcpSimpleRangeField ScanLstLabtoolLastVotedChannel_A8419
		{
			get
			{
				short num = (short)698230063;
				short num2 = num;
				num = (short)983770415;
				switch (num2 == num)
				{
				default:
				{
					num = (short)484179968;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)698875904;
				if (num != 0)
				{
				}
				num = (short)1036976129;
				if (num != 0)
				{
				}
				return this.scanLstLabtoolLastVotedChannel_A8419;
			}
		}

		// Token: 0x170014E4 RID: 5348
		// (get) Token: 0x060029AF RID: 10671 RVA: 0x00289F50 File Offset: 0x00288150
		// (set) Token: 0x060029B0 RID: 10672 RVA: 0x0028A004 File Offset: 0x00288204
		public string ScanLstLabtoolLastVotedChannel_A8419_UIValue
		{
			get
			{
				short num = (short)1568145409;
				if (num != 0)
				{
				}
				num = (short)1249968128;
				short num2 = num;
				num = (short)1999024393;
				short num3 = num;
				num = (short)827896073;
				switch (num3 == num)
				{
				}
				num = (short)73269248;
				if (num != 0)
				{
				}
				return this.scanLstLabtoolLastVotedChannel_A8419.UIValue;
			}
			set
			{
				short num = (short)1929563357;
				short num2 = num;
				num = (short)1928645853;
				switch (num2 == num)
				{
				default:
				{
					num = (short)617611264;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)363659265;
				if (num != 0)
				{
				}
				num = (short)1641807872;
				if (num != 0)
				{
				}
				this.scanLstLabtoolLastVotedChannel_A8419.UIValue = value;
			}
		}

		// Token: 0x170014E5 RID: 5349
		// (get) Token: 0x060029B1 RID: 10673 RVA: 0x0028A0BC File Offset: 0x002882BC
		// (set) Token: 0x060029B2 RID: 10674 RVA: 0x0028A170 File Offset: 0x00288370
		internal int ScanLstLabtoolLastVotedChannel_A8419Min
		{
			get
			{
				short num = (short)1771708094;
				short num2 = num;
				num = (short)606215870;
				switch (num2 == num)
				{
				default:
				{
					num = (short)67305472;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1848705025;
				if (num != 0)
				{
				}
				num = (short)1937244160;
				if (num != 0)
				{
				}
				return this.scanLstLabtoolLastVotedChannel_A8419.Min;
			}
			set
			{
				short num = (short)1161691137;
				if (num != 0)
				{
				}
				num = (short)1958805504;
				short num2 = num;
				num = (short)1727301108;
				short num3 = num;
				num = (short)638617076;
				switch (num3 == num)
				{
				}
				num = (short)1637154816;
				if (num != 0)
				{
				}
				this.scanLstLabtoolLastVotedChannel_A8419.Min = value;
			}
		}

		// Token: 0x170014E6 RID: 5350
		// (get) Token: 0x060029B3 RID: 10675 RVA: 0x0028A224 File Offset: 0x00288424
		// (set) Token: 0x060029B4 RID: 10676 RVA: 0x0028A2DC File Offset: 0x002884DC
		internal int ScanLstLabtoolLastVotedChannel_A8419Max
		{
			get
			{
				short num = (short)815754545;
				short num2 = num;
				num = (short)512847153;
				switch (num2 == num)
				{
				default:
				{
					num = (short)500367360;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)860815360;
				if (num != 0)
				{
				}
				num = (short)405143553;
				if (num != 0)
				{
				}
				return this.scanLstLabtoolLastVotedChannel_A8419.Max;
			}
			set
			{
				short num = (short)575816737;
				short num2 = num;
				num = (short)1311327265;
				switch (num2 == num)
				{
				default:
				{
					num = (short)945225728;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)985464833;
				if (num != 0)
				{
				}
				num = (short)553844736;
				if (num != 0)
				{
				}
				this.scanLstLabtoolLastVotedChannel_A8419.Max = value;
			}
		}

		// Token: 0x170014E7 RID: 5351
		// (get) Token: 0x060029B5 RID: 10677 RVA: 0x0028A390 File Offset: 0x00288590
		// (set) Token: 0x060029B6 RID: 10678 RVA: 0x0028A444 File Offset: 0x00288644
		internal int ScanLstLabtoolLastVotedChannel_A8419Step
		{
			get
			{
				short num = (short)516280918;
				short num2 = num;
				num = (short)1477169750;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1980039168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1324548097;
				if (num != 0)
				{
				}
				num = (short)1394212864;
				if (num != 0)
				{
				}
				return this.scanLstLabtoolLastVotedChannel_A8419.StepSize;
			}
			set
			{
				short num = (short)2065701771;
				short num2 = num;
				num = (short)1217797003;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1132462080;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2058878976;
				if (num != 0)
				{
				}
				num = (short)1733754881;
				if (num != 0)
				{
				}
				this.scanLstLabtoolLastVotedChannel_A8419.StepSize = value;
			}
		}

		// Token: 0x170014E8 RID: 5352
		// (get) Token: 0x060029B7 RID: 10679 RVA: 0x0028A4FC File Offset: 0x002886FC
		// (set) Token: 0x060029B8 RID: 10680 RVA: 0x0028A5B0 File Offset: 0x002887B0
		public bool ScanLstLabtoolLastVotedChannel_A8419_Applicable
		{
			get
			{
				short num = (short)885666560;
				short num2 = num;
				num = (short)876294912;
				switch (num2 == num)
				{
				default:
				{
					num = (short)72941568;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1889796096;
				if (num != 0)
				{
				}
				num = (short)1596784641;
				if (num != 0)
				{
				}
				return this.scanLstLabtoolLastVotedChannel_A8419.Applicable;
			}
			set
			{
				short num = (short)1294579185;
				short num2 = num;
				num = (short)958182897;
				switch (num2 == num)
				{
				default:
				{
					num = (short)608960512;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)888340481;
				if (num != 0)
				{
				}
				num = (short)1867317248;
				if (num != 0)
				{
				}
				this.scanLstLabtoolLastVotedChannel_A8419.Applicable = value;
			}
		}

		// Token: 0x170014E9 RID: 5353
		// (get) Token: 0x060029B9 RID: 10681 RVA: 0x0028A664 File Offset: 0x00288864
		// (set) Token: 0x060029BA RID: 10682 RVA: 0x0028A714 File Offset: 0x00288914
		public bool ScanLstLabtoolLastVotedChannel_A8419_Valid
		{
			get
			{
				short num = (short)1010130968;
				short num2 = num;
				num = (short)1807114264;
				switch (num2 == num)
				{
				default:
				{
					num = (short)737214464;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1529020417;
				if (num != 0)
				{
				}
				num = (short)30343168;
				if (num != 0)
				{
				}
				return this.scanLstLabtoolLastVotedChannel_A8419.Valid;
			}
			set
			{
				short num = (short)1916989550;
				short num2 = num;
				num = (short)1270542446;
				switch (num2 == num)
				{
				default:
				{
					num = (short)88604672;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)267452417;
				if (num != 0)
				{
				}
				num = (short)516554752;
				if (num != 0)
				{
				}
				this.scanLstLabtoolLastVotedChannel_A8419.Valid = value;
			}
		}

		// Token: 0x170014EA RID: 5354
		// (get) Token: 0x060029BB RID: 10683 RVA: 0x0028A7C8 File Offset: 0x002889C8
		// (set) Token: 0x060029BC RID: 10684 RVA: 0x0028A87C File Offset: 0x00288A7C
		public bool ScanLstLabtoolLastVotedChannel_A8419_Visible
		{
			get
			{
				short num = (short)592780453;
				short num2 = num;
				num = (short)1700338853;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1588985856;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1521745921;
				if (num != 0)
				{
				}
				num = (short)1460207616;
				if (num != 0)
				{
				}
				return this.scanLstLabtoolLastVotedChannel_A8419.Visible;
			}
			set
			{
				short num = (short)2058461188;
				short num2 = num;
				num = (short)1355915268;
				switch (num2 == num)
				{
				default:
				{
					num = (short)12910592;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1652752384;
				if (num != 0)
				{
				}
				num = (short)2078932993;
				if (num != 0)
				{
				}
				this.scanLstLabtoolLastVotedChannel_A8419.Visible = value;
			}
		}

		// Token: 0x170014EB RID: 5355
		// (get) Token: 0x060029BD RID: 10685 RVA: 0x0028A930 File Offset: 0x00288B30
		// (set) Token: 0x060029BE RID: 10686 RVA: 0x0028A9E8 File Offset: 0x00288BE8
		public bool ScanLstLabtoolLastVotedChannel_A8419_Editable
		{
			get
			{
				short num = (short)458036408;
				short num2 = num;
				num = (short)982127800;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1103036416;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1553924097;
				if (num != 0)
				{
				}
				num = (short)1075183616;
				if (num != 0)
				{
				}
				return this.scanLstLabtoolLastVotedChannel_A8419.Editable;
			}
			set
			{
				short num = (short)1443685998;
				short num2 = num;
				num = (short)1304749678;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1394081792;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)629735425;
				if (num != 0)
				{
				}
				num = (short)449118208;
				if (num != 0)
				{
				}
				this.scanLstLabtoolLastVotedChannel_A8419.Editable = value;
			}
		}

		// Token: 0x170014EC RID: 5356
		// (get) Token: 0x060029BF RID: 10687 RVA: 0x0028AAA0 File Offset: 0x00288CA0
		internal string ScanLstLabtoolLastVotedChannel_A8419_UILabel
		{
			get
			{
				short num = (short)1663449223;
				short num2 = num;
				num = (short)1433417863;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1279328256;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)567738368;
				if (num != 0)
				{
				}
				num = (short)2002452481;
				if (num != 0)
				{
				}
				return this.scanLstLabtoolLastVotedChannel_A8419.UIName;
			}
		}

		// Token: 0x170014ED RID: 5357
		// (get) Token: 0x060029C0 RID: 10688 RVA: 0x0028AB54 File Offset: 0x00288D54
		// (set) Token: 0x060029C1 RID: 10689 RVA: 0x0028AC0C File Offset: 0x00288E0C
		internal bool ScanLstLabtoolLastVotedChannel_A8419_HiddenStatic
		{
			get
			{
				short num = (short)1613846367;
				short num2 = num;
				num = (short)1957713759;
				switch (num2 == num)
				{
				default:
				{
					num = (short)19660800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1213399040;
				if (num != 0)
				{
				}
				num = (short)494796801;
				if (num != 0)
				{
				}
				return this.scanLstLabtoolLastVotedChannel_A8419.HiddenStatic;
			}
			set
			{
				short num = (short)957999640;
				short num2 = num;
				num = (short)847374872;
				switch (num2 == num)
				{
				default:
				{
					num = (short)744554496;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1109196800;
				if (num != 0)
				{
				}
				num = (short)1583874049;
				if (num != 0)
				{
				}
				this.scanLstLabtoolLastVotedChannel_A8419.HiddenStatic = value;
			}
		}

		// Token: 0x170014EE RID: 5358
		// (get) Token: 0x060029C2 RID: 10690 RVA: 0x0028ACC0 File Offset: 0x00288EC0
		// (set) Token: 0x060029C3 RID: 10691 RVA: 0x0028AD74 File Offset: 0x00288F74
		internal bool ScanLstLabtoolLastVotedChannel_A8419_HiddenDynamic
		{
			get
			{
				short num = (short)631818320;
				short num2 = num;
				num = (short)954779728;
				switch (num2 == num)
				{
				default:
				{
					num = (short)884736000;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)908066817;
				if (num != 0)
				{
				}
				num = (short)1638465536;
				if (num != 0)
				{
				}
				return this.scanLstLabtoolLastVotedChannel_A8419.HiddenDynamic;
			}
			set
			{
				short num = (short)1167786393;
				short num2 = num;
				num = (short)818348441;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1481703424;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)7012352;
				if (num != 0)
				{
				}
				num = (short)1069809665;
				if (num != 0)
				{
				}
				this.scanLstLabtoolLastVotedChannel_A8419.HiddenDynamic = value;
			}
		}

		// Token: 0x170014EF RID: 5359
		// (get) Token: 0x060029C4 RID: 10692 RVA: 0x0028AE28 File Offset: 0x00289028
		public bool ScanLstLabtoolLastVotedChannel_A8419_HasDiffs
		{
			get
			{
				short num = (short)1281463833;
				short num2 = num;
				num = (short)1745131033;
				switch (num2 == num)
				{
				default:
				{
					num = (short)411303936;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)224591873;
				if (num != 0)
				{
				}
				num = (short)126681088;
				if (num != 0)
				{
				}
				return this.scanLstLabtoolLastVotedChannel_A8419._HasDiffs;
			}
		}

		// Token: 0x170014F0 RID: 5360
		// (get) Token: 0x060029C5 RID: 10693 RVA: 0x0028AEE0 File Offset: 0x002890E0
		// (set) Token: 0x060029C6 RID: 10694 RVA: 0x0028AF94 File Offset: 0x00289194
		public int ScanLstLabtoolLastVotedZone_A8420Value
		{
			get
			{
				short num = (short)607985737;
				short num2 = num;
				num = (short)421273673;
				switch (num2 == num)
				{
				default:
				{
					num = (short)50528256;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1439956992;
				if (num != 0)
				{
				}
				num = (short)1613430785;
				if (num != 0)
				{
				}
				return this.scanLstLabtoolLastVotedZone_A8420.Value;
			}
			set
			{
				short num = (short)2080118319;
				short num2 = num;
				num = (short)799282735;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1884422144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)237371393;
				if (num != 0)
				{
				}
				num = (short)766967808;
				if (num != 0)
				{
				}
				this.scanLstLabtoolLastVotedZone_A8420.Value = value;
			}
		}

		// Token: 0x170014F1 RID: 5361
		// (get) Token: 0x060029C7 RID: 10695 RVA: 0x0028B048 File Offset: 0x00289248
		public global::AcpBusinessLayer.AcpSimpleRangeField ScanLstLabtoolLastVotedZone_A8420
		{
			get
			{
				short num = (short)419241626;
				short num2 = num;
				num = (short)989273754;
				switch (num2 == num)
				{
				default:
				{
					num = (short)380239872;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)98828289;
				if (num != 0)
				{
				}
				num = (short)245366784;
				if (num != 0)
				{
				}
				return this.scanLstLabtoolLastVotedZone_A8420;
			}
		}

		// Token: 0x170014F2 RID: 5362
		// (get) Token: 0x060029C8 RID: 10696 RVA: 0x0028B0F4 File Offset: 0x002892F4
		// (set) Token: 0x060029C9 RID: 10697 RVA: 0x0028B1A8 File Offset: 0x002893A8
		public string ScanLstLabtoolLastVotedZone_A8420_UIValue
		{
			get
			{
				short num = (short)1697054723;
				short num2 = num;
				num = (short)1613430787;
				switch (num2 == num)
				{
				default:
				{
					num = (short)305528832;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)504954881;
				if (num != 0)
				{
				}
				num = (short)547422208;
				if (num != 0)
				{
				}
				return this.scanLstLabtoolLastVotedZone_A8420.UIValue;
			}
			set
			{
				short num = (short)1611593459;
				short num2 = num;
				num = (short)2132014835;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1783824384;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)294715392;
				if (num != 0)
				{
				}
				num = (short)192544769;
				if (num != 0)
				{
				}
				this.scanLstLabtoolLastVotedZone_A8420.UIValue = value;
			}
		}

		// Token: 0x170014F3 RID: 5363
		// (get) Token: 0x060029CA RID: 10698 RVA: 0x0028B25C File Offset: 0x0028945C
		// (set) Token: 0x060029CB RID: 10699 RVA: 0x0028B310 File Offset: 0x00289510
		internal int ScanLstLabtoolLastVotedZone_A8420Min
		{
			get
			{
				short num = (short)376527997;
				short num2 = num;
				num = (short)1133665405;
				switch (num2 == num)
				{
				default:
				{
					num = (short)677773312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1083572225;
				if (num != 0)
				{
				}
				num = (short)517341184;
				if (num != 0)
				{
				}
				return this.scanLstLabtoolLastVotedZone_A8420.Min;
			}
			set
			{
				short num = (short)1188500776;
				short num2 = num;
				num = (short)1436554536;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1580728320;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1082589185;
				if (num != 0)
				{
				}
				num = (short)393805824;
				if (num != 0)
				{
				}
				this.scanLstLabtoolLastVotedZone_A8420.Min = value;
			}
		}

		// Token: 0x170014F4 RID: 5364
		// (get) Token: 0x060029CC RID: 10700 RVA: 0x0028B3C4 File Offset: 0x002895C4
		// (set) Token: 0x060029CD RID: 10701 RVA: 0x0028B478 File Offset: 0x00289678
		internal int ScanLstLabtoolLastVotedZone_A8420Max
		{
			get
			{
				short num = (short)252641674;
				short num2 = num;
				num = (short)1061224842;
				switch (num2 == num)
				{
				default:
				{
					num = (short)786104320;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1560477697;
				if (num != 0)
				{
				}
				num = (short)1883766784;
				if (num != 0)
				{
				}
				return this.scanLstLabtoolLastVotedZone_A8420.Max;
			}
			set
			{
				short num = (short)1359279368;
				short num2 = num;
				num = (short)902296840;
				switch (num2 == num)
				{
				default:
				{
					num = (short)926482432;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)304873472;
				if (num != 0)
				{
				}
				num = (short)1549598721;
				if (num != 0)
				{
				}
				this.scanLstLabtoolLastVotedZone_A8420.Max = value;
			}
		}

		// Token: 0x170014F5 RID: 5365
		// (get) Token: 0x060029CE RID: 10702 RVA: 0x0028B52C File Offset: 0x0028972C
		// (set) Token: 0x060029CF RID: 10703 RVA: 0x0028B5E0 File Offset: 0x002897E0
		internal int ScanLstLabtoolLastVotedZone_A8420Step
		{
			get
			{
				short num = (short)942528486;
				short num2 = num;
				num = (short)1455020006;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1744633856;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1120403456;
				if (num != 0)
				{
				}
				num = (short)27197441;
				if (num != 0)
				{
				}
				return this.scanLstLabtoolLastVotedZone_A8420.StepSize;
			}
			set
			{
				short num = (short)1978991605;
				short num2 = num;
				num = (short)841810933;
				switch (num2 == num)
				{
				default:
				{
					num = (short)748617728;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1504641025;
				if (num != 0)
				{
				}
				num = (short)347602944;
				if (num != 0)
				{
				}
				this.scanLstLabtoolLastVotedZone_A8420.StepSize = value;
			}
		}

		// Token: 0x170014F6 RID: 5366
		// (get) Token: 0x060029D0 RID: 10704 RVA: 0x0028B694 File Offset: 0x00289894
		// (set) Token: 0x060029D1 RID: 10705 RVA: 0x0028B748 File Offset: 0x00289948
		public bool ScanLstLabtoolLastVotedZone_A8420_Applicable
		{
			get
			{
				short num = (short)175719880;
				short num2 = num;
				num = (short)1715422664;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1586823168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1394343937;
				if (num != 0)
				{
				}
				num = (short)1971388416;
				if (num != 0)
				{
				}
				return this.scanLstLabtoolLastVotedZone_A8420.Applicable;
			}
			set
			{
				short num = (short)679280641;
				if (num != 0)
				{
				}
				num = (short)1081409536;
				short num2 = num;
				num = (short)870693276;
				short num3 = num;
				num = (short)619952540;
				switch (num3 == num)
				{
				}
				num = (short)23724032;
				if (num != 0)
				{
				}
				this.scanLstLabtoolLastVotedZone_A8420.Applicable = value;
			}
		}

		// Token: 0x170014F7 RID: 5367
		// (get) Token: 0x060029D2 RID: 10706 RVA: 0x0028B800 File Offset: 0x00289A00
		// (set) Token: 0x060029D3 RID: 10707 RVA: 0x0028B8B4 File Offset: 0x00289AB4
		public bool ScanLstLabtoolLastVotedZone_A8420_Valid
		{
			get
			{
				short num = (short)1960378369;
				if (num != 0)
				{
				}
				num = (short)1140260864;
				short num2 = num;
				num = (short)1480808913;
				short num3 = num;
				num = (short)583752145;
				switch (num3 == num)
				{
				}
				num = (short)1716715520;
				if (num != 0)
				{
				}
				return this.scanLstLabtoolLastVotedZone_A8420.Valid;
			}
			set
			{
				short num = (short)817076609;
				short num2 = num;
				num = (short)623417729;
				switch (num2 == num)
				{
				}
				num = (short)241827841;
				if (num != 0)
				{
				}
				num = (short)556072960;
				if (num != 0)
				{
				}
				num = (short)1782317056;
				short num3 = num;
				this.scanLstLabtoolLastVotedZone_A8420.Valid = value;
			}
		}

		// Token: 0x170014F8 RID: 5368
		// (get) Token: 0x060029D4 RID: 10708 RVA: 0x0028B968 File Offset: 0x00289B68
		// (set) Token: 0x060029D5 RID: 10709 RVA: 0x0028BA1C File Offset: 0x00289C1C
		public bool ScanLstLabtoolLastVotedZone_A8420_Visible
		{
			get
			{
				short num = (short)1540323339;
				short num2 = num;
				num = (short)771061771;
				switch (num2 == num)
				{
				}
				num = (short)998899712;
				if (num != 0)
				{
				}
				num = (short)1856110593;
				if (num != 0)
				{
				}
				num = (short)2076573696;
				short num3 = num;
				return this.scanLstLabtoolLastVotedZone_A8420.Visible;
			}
			set
			{
				short num = (short)1876473485;
				short num2 = num;
				num = (short)621065869;
				switch (num2 == num)
				{
				}
				num = (short)348520449;
				if (num != 0)
				{
				}
				num = (short)2016215040;
				if (num != 0)
				{
				}
				num = (short)1051721728;
				short num3 = num;
				this.scanLstLabtoolLastVotedZone_A8420.Visible = value;
			}
		}

		// Token: 0x170014F9 RID: 5369
		// (get) Token: 0x060029D6 RID: 10710 RVA: 0x0028BAD0 File Offset: 0x00289CD0
		// (set) Token: 0x060029D7 RID: 10711 RVA: 0x0028BB84 File Offset: 0x00289D84
		public bool ScanLstLabtoolLastVotedZone_A8420_Editable
		{
			get
			{
				short num = (short)959119956;
				short num2 = num;
				num = (short)805241428;
				switch (num2 == num)
				{
				}
				num = (short)432603136;
				if (num != 0)
				{
				}
				num = (short)1897201665;
				if (num != 0)
				{
				}
				num = (short)645332992;
				short num3 = num;
				return this.scanLstLabtoolLastVotedZone_A8420.Editable;
			}
			set
			{
				short num = (short)1609564161;
				if (num != 0)
				{
				}
				num = (short)220148467;
				short num2 = num;
				num = (short)1399927539;
				switch (num2 == num)
				{
				}
				num = (short)1362558976;
				if (num != 0)
				{
				}
				num = (short)516882432;
				short num3 = num;
				this.scanLstLabtoolLastVotedZone_A8420.Editable = value;
			}
		}

		// Token: 0x170014FA RID: 5370
		// (get) Token: 0x060029D8 RID: 10712 RVA: 0x0028BC38 File Offset: 0x00289E38
		internal string ScanLstLabtoolLastVotedZone_A8420_UILabel
		{
			get
			{
				short num = (short)1950154753;
				if (num != 0)
				{
				}
				num = (short)1949302148;
				short num2 = num;
				num = (short)210369924;
				switch (num2 == num)
				{
				}
				num = (short)762183680;
				if (num != 0)
				{
				}
				num = (short)1036517376;
				short num3 = num;
				return this.scanLstLabtoolLastVotedZone_A8420.UIName;
			}
		}

		// Token: 0x170014FB RID: 5371
		// (get) Token: 0x060029D9 RID: 10713 RVA: 0x0028BCF0 File Offset: 0x00289EF0
		// (set) Token: 0x060029DA RID: 10714 RVA: 0x0028BDA4 File Offset: 0x00289FA4
		internal bool ScanLstLabtoolLastVotedZone_A8420_HiddenStatic
		{
			get
			{
				short num = (short)1469829250;
				short num2 = num;
				num = (short)1493553282;
				switch (num2 == num)
				{
				}
				num = (short)1324417024;
				if (num != 0)
				{
				}
				num = (short)597884929;
				if (num != 0)
				{
				}
				num = (short)470745088;
				short num3 = num;
				return this.scanLstLabtoolLastVotedZone_A8420.HiddenStatic;
			}
			set
			{
				short num = (short)602275583;
				short num2 = num;
				num = (short)360906495;
				switch (num2 == num)
				{
				}
				num = (short)161218560;
				if (num != 0)
				{
				}
				num = (short)261357569;
				if (num != 0)
				{
				}
				num = (short)1778712576;
				short num3 = num;
				this.scanLstLabtoolLastVotedZone_A8420.HiddenStatic = value;
			}
		}

		// Token: 0x170014FC RID: 5372
		// (get) Token: 0x060029DB RID: 10715 RVA: 0x0028BE5C File Offset: 0x0028A05C
		// (set) Token: 0x060029DC RID: 10716 RVA: 0x0028BF10 File Offset: 0x0028A110
		internal bool ScanLstLabtoolLastVotedZone_A8420_HiddenDynamic
		{
			get
			{
				short num = (short)973628554;
				short num2 = num;
				num = (short)1804756106;
				switch (num2 == num)
				{
				}
				num = (short)1143341057;
				if (num != 0)
				{
				}
				num = (short)1491402752;
				if (num != 0)
				{
				}
				num = (short)287899648;
				short num3 = num;
				return this.scanLstLabtoolLastVotedZone_A8420.HiddenDynamic;
			}
			set
			{
				short num = (short)1030968410;
				short num2 = num;
				num = (short)95507546;
				switch (num2 == num)
				{
				}
				num = (short)941096961;
				if (num != 0)
				{
				}
				num = (short)2030501888;
				if (num != 0)
				{
				}
				num = (short)1296236544;
				short num3 = num;
				this.scanLstLabtoolLastVotedZone_A8420.HiddenDynamic = value;
			}
		}

		// Token: 0x170014FD RID: 5373
		// (get) Token: 0x060029DD RID: 10717 RVA: 0x0028BFC8 File Offset: 0x0028A1C8
		public bool ScanLstLabtoolLastVotedZone_A8420_HasDiffs
		{
			get
			{
				short num = (short)1618214429;
				short num2 = num;
				num = (short)777780765;
				switch (num2 == num)
				{
				}
				num = 1;
				if (num != 0)
				{
				}
				num = (short)1114112000;
				if (num != 0)
				{
				}
				num = (short)1477246976;
				short num3 = num;
				return this.scanLstLabtoolLastVotedZone_A8420._HasDiffs;
			}
		}

		// Token: 0x170014FE RID: 5374
		// (get) Token: 0x060029DE RID: 10718 RVA: 0x0028C07C File Offset: 0x0028A27C
		// (set) Token: 0x060029DF RID: 10719 RVA: 0x0028C130 File Offset: 0x0028A330
		public bool ScanLstLabtoolLTEInterferingFreqPresent_A42197Value
		{
			get
			{
				short num = (short)1997557133;
				short num2 = num;
				num = (short)157765005;
				switch (num2 == num)
				{
				}
				num = (short)1165950977;
				if (num != 0)
				{
				}
				num = (short)195624960;
				if (num != 0)
				{
				}
				num = (short)967639040;
				short num3 = num;
				return this.scanLstLabtoolLTEInterferingFreqPresent_A42197.Value;
			}
			set
			{
				short num = (short)1133175806;
				short num2 = num;
				num = (short)1130488830;
				switch (num2 == num)
				{
				}
				num = (short)349569024;
				if (num != 0)
				{
				}
				num = (short)1132068865;
				if (num != 0)
				{
				}
				num = (short)1365377024;
				short num3 = num;
				this.scanLstLabtoolLTEInterferingFreqPresent_A42197.Value = value;
			}
		}

		// Token: 0x170014FF RID: 5375
		// (get) Token: 0x060029E0 RID: 10720 RVA: 0x0028C1E4 File Offset: 0x0028A3E4
		public global::AcpBusinessLayer.AcpField<bool> ScanLstLabtoolLTEInterferingFreqPresent_A42197
		{
			get
			{
				short num = (short)1589510145;
				if (num != 0)
				{
				}
				num = (short)928117128;
				short num2 = num;
				num = (short)1396175240;
				switch (num2 == num)
				{
				}
				num = (short)837091328;
				if (num != 0)
				{
				}
				num = (short)1796997120;
				short num3 = num;
				return this.scanLstLabtoolLTEInterferingFreqPresent_A42197;
			}
		}

		// Token: 0x17001500 RID: 5376
		// (get) Token: 0x060029E1 RID: 10721 RVA: 0x0028C294 File Offset: 0x0028A494
		// (set) Token: 0x060029E2 RID: 10722 RVA: 0x0028C348 File Offset: 0x0028A548
		public bool ScanLstLabtoolLTEInterferingFreqPresent_A42197_UIValue
		{
			get
			{
				short num = (short)987934174;
				short num2 = num;
				num = (short)1708109278;
				switch (num2 == num)
				{
				}
				num = (short)1209991168;
				if (num != 0)
				{
				}
				num = (short)644677633;
				if (num != 0)
				{
				}
				num = (short)866254848;
				short num3 = num;
				return this.scanLstLabtoolLTEInterferingFreqPresent_A42197.Value;
			}
			set
			{
				short num = (short)558572567;
				short num2 = num;
				num = (short)733029399;
				switch (num2 == num)
				{
				}
				num = (short)1734541313;
				if (num != 0)
				{
				}
				num = (short)2028273664;
				if (num != 0)
				{
				}
				num = (short)852099072;
				short num3 = num;
				this.scanLstLabtoolLTEInterferingFreqPresent_A42197.Value = value;
			}
		}

		// Token: 0x17001501 RID: 5377
		// (get) Token: 0x060029E3 RID: 10723 RVA: 0x0028C3FC File Offset: 0x0028A5FC
		// (set) Token: 0x060029E4 RID: 10724 RVA: 0x0028C4B4 File Offset: 0x0028A6B4
		public bool ScanLstLabtoolLTEInterferingFreqPresent_A42197_Applicable
		{
			get
			{
				short num = (short)842810491;
				short num2 = num;
				num = (short)468010107;
				switch (num2 == num)
				{
				}
				num = (short)1017446401;
				if (num != 0)
				{
				}
				num = (short)792920064;
				if (num != 0)
				{
				}
				num = (short)995360768;
				short num3 = num;
				return this.scanLstLabtoolLTEInterferingFreqPresent_A42197.Applicable;
			}
			set
			{
				short num = (short)1826020296;
				short num2 = num;
				num = (short)1870977992;
				switch (num2 == num)
				{
				}
				num = (short)1314193408;
				if (num != 0)
				{
				}
				num = (short)848297985;
				if (num != 0)
				{
				}
				num = (short)725876736;
				short num3 = num;
				this.scanLstLabtoolLTEInterferingFreqPresent_A42197.Applicable = value;
			}
		}

		// Token: 0x17001502 RID: 5378
		// (get) Token: 0x060029E5 RID: 10725 RVA: 0x0028C568 File Offset: 0x0028A768
		// (set) Token: 0x060029E6 RID: 10726 RVA: 0x0028C61C File Offset: 0x0028A81C
		public bool ScanLstLabtoolLTEInterferingFreqPresent_A42197_Valid
		{
			get
			{
				short num = (short)603258881;
				if (num != 0)
				{
				}
				num = (short)805315478;
				short num2 = num;
				num = (short)620241814;
				switch (num2 == num)
				{
				}
				num = (short)972226560;
				if (num != 0)
				{
				}
				num = (short)1603731456;
				short num3 = num;
				return this.scanLstLabtoolLTEInterferingFreqPresent_A42197.Valid;
			}
			set
			{
				short num = (short)2041715440;
				short num2 = num;
				num = (short)1990335216;
				switch (num2 == num)
				{
				}
				num = (short)1185284097;
				if (num != 0)
				{
				}
				num = (short)2121531392;
				if (num != 0)
				{
				}
				num = (short)1415118848;
				short num3 = num;
				this.scanLstLabtoolLTEInterferingFreqPresent_A42197.Valid = value;
			}
		}

		// Token: 0x17001503 RID: 5379
		// (get) Token: 0x060029E7 RID: 10727 RVA: 0x0028C6D0 File Offset: 0x0028A8D0
		// (set) Token: 0x060029E8 RID: 10728 RVA: 0x0028C780 File Offset: 0x0028A980
		public bool ScanLstLabtoolLTEInterferingFreqPresent_A42197_Visible
		{
			get
			{
				short num = (short)19049620;
				short num2 = num;
				num = (short)893955220;
				switch (num2 == num)
				{
				}
				num = (short)650838017;
				if (num != 0)
				{
				}
				num = (short)64487424;
				if (num != 0)
				{
				}
				num = (short)1769865216;
				short num3 = num;
				return this.scanLstLabtoolLTEInterferingFreqPresent_A42197.Visible;
			}
			set
			{
				short num = (short)564660366;
				short num2 = num;
				num = (short)259786894;
				switch (num2 == num)
				{
				}
				num = (short)1907294208;
				if (num != 0)
				{
				}
				num = (short)221446145;
				if (num != 0)
				{
				}
				num = (short)503644160;
				short num3 = num;
				this.scanLstLabtoolLTEInterferingFreqPresent_A42197.Visible = value;
			}
		}

		// Token: 0x17001504 RID: 5380
		// (get) Token: 0x060029E9 RID: 10729 RVA: 0x0028C838 File Offset: 0x0028AA38
		// (set) Token: 0x060029EA RID: 10730 RVA: 0x0028C8EC File Offset: 0x0028AAEC
		public bool ScanLstLabtoolLTEInterferingFreqPresent_A42197_Editable
		{
			get
			{
				short num = (short)2144429913;
				short num2 = num;
				num = (short)1187669849;
				switch (num2 == num)
				{
				}
				num = (short)1584857088;
				if (num != 0)
				{
				}
				num = (short)898695169;
				if (num != 0)
				{
				}
				num = (short)30212096;
				short num3 = num;
				return this.scanLstLabtoolLTEInterferingFreqPresent_A42197.Editable;
			}
			set
			{
				short num = (short)653749550;
				short num2 = num;
				num = (short)977693998;
				switch (num2 == num)
				{
				}
				num = (short)1307836417;
				if (num != 0)
				{
				}
				num = (short)42663936;
				if (num != 0)
				{
				}
				num = (short)659881984;
				short num3 = num;
				this.scanLstLabtoolLTEInterferingFreqPresent_A42197.Editable = value;
			}
		}

		// Token: 0x17001505 RID: 5381
		// (get) Token: 0x060029EB RID: 10731 RVA: 0x0028C9A4 File Offset: 0x0028ABA4
		internal string ScanLstLabtoolLTEInterferingFreqPresent_A42197_UILabel
		{
			get
			{
				short num = (short)680152365;
				short num2 = num;
				num = (short)420695341;
				switch (num2 == num)
				{
				}
				num = (short)1467613184;
				if (num != 0)
				{
				}
				num = (short)1269628929;
				if (num != 0)
				{
				}
				num = (short)1444085760;
				short num3 = num;
				return this.scanLstLabtoolLTEInterferingFreqPresent_A42197.UIName;
			}
		}

		// Token: 0x17001506 RID: 5382
		// (get) Token: 0x060029EC RID: 10732 RVA: 0x0028CA58 File Offset: 0x0028AC58
		// (set) Token: 0x060029ED RID: 10733 RVA: 0x0028CB0C File Offset: 0x0028AD0C
		internal bool ScanLstLabtoolLTEInterferingFreqPresent_A42197_HiddenStatic
		{
			get
			{
				short num = (short)611218904;
				short num2 = num;
				num = (short)102397400;
				switch (num2 == num)
				{
				}
				num = (short)870449153;
				if (num != 0)
				{
				}
				num = (short)976683008;
				if (num != 0)
				{
				}
				num = (short)865206272;
				short num3 = num;
				return this.scanLstLabtoolLTEInterferingFreqPresent_A42197.HiddenStatic;
			}
			set
			{
				short num = (short)699795043;
				short num2 = num;
				num = (short)1488782947;
				switch (num2 == num)
				{
				}
				num = (short)1681784833;
				if (num != 0)
				{
				}
				num = (short)662372352;
				if (num != 0)
				{
				}
				num = (short)1930559488;
				short num3 = num;
				this.scanLstLabtoolLTEInterferingFreqPresent_A42197.HiddenStatic = value;
			}
		}

		// Token: 0x17001507 RID: 5383
		// (get) Token: 0x060029EE RID: 10734 RVA: 0x0028CBC4 File Offset: 0x0028ADC4
		// (set) Token: 0x060029EF RID: 10735 RVA: 0x0028CC78 File Offset: 0x0028AE78
		internal bool ScanLstLabtoolLTEInterferingFreqPresent_A42197_HiddenDynamic
		{
			get
			{
				short num = (short)1006645621;
				short num2 = num;
				num = (short)220082549;
				switch (num2 == num)
				{
				}
				num = (short)1822097409;
				if (num != 0)
				{
				}
				num = (short)571473920;
				if (num != 0)
				{
				}
				num = (short)1100873728;
				short num3 = num;
				return this.scanLstLabtoolLTEInterferingFreqPresent_A42197.HiddenDynamic;
			}
			set
			{
				short num = (short)163561704;
				short num2 = num;
				num = (short)1037746408;
				switch (num2 == num)
				{
				}
				num = (short)315424769;
				if (num != 0)
				{
				}
				num = (short)1457520640;
				if (num != 0)
				{
				}
				num = (short)324993024;
				short num3 = num;
				this.scanLstLabtoolLTEInterferingFreqPresent_A42197.HiddenDynamic = value;
			}
		}

		// Token: 0x17001508 RID: 5384
		// (get) Token: 0x060029F0 RID: 10736 RVA: 0x0028CD30 File Offset: 0x0028AF30
		public bool ScanLstLabtoolLTEInterferingFreqPresent_A42197_HasDiffs
		{
			get
			{
				short num = (short)1518110769;
				short num2 = num;
				num = (short)1383630897;
				switch (num2 == num)
				{
				}
				num = (short)415956993;
				if (num != 0)
				{
				}
				num = (short)1130102784;
				if (num != 0)
				{
				}
				num = (short)1539506176;
				short num3 = num;
				return this.scanLstLabtoolLTEInterferingFreqPresent_A42197._HasDiffs;
			}
		}

		// Token: 0x060029F1 RID: 10737 RVA: 0x0028CDE4 File Offset: 0x0028AFE4
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			int num;
			short num2;
			global::AcpCommonLib.IAcpRecordset result;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
					{
						num2 = (short)1343614073;
						short num3 = num2;
						num2 = (short)1912532089;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_26;
						default:
						{
							num2 = (short)1838088193;
							if (num2 != 0)
							{
							}
							num2 = (short)717357056;
							if (num2 != 0)
							{
							}
							num2 = (short)1917714432;
							short num4 = num2;
							result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
							num2 = (short)1820393474;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						}
						break;
					}
					case 1:
						if (base.ParentRecset.ContainerDoc != null)
						{
							num2 = (short)343212032;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					case 2:
						return result;
					case 3:
						if (base.ParentRecset != null)
						{
							num2 = (short)537329668;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					case 4:
						num2 = (short)840237057;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_24;
				}
				return result;
			}
			IL_24:
			result = null;
			IL_26:
			num2 = (short)1031077891;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04000F03 RID: 3843
		private global::AcpBusinessLayer.AcpSimpleRangeField scanLstLabtoolLastVotedChannel_A8419;

		// Token: 0x04000F04 RID: 3844
		private global::AcpBusinessLayer.AcpSimpleRangeField scanLstLabtoolLastVotedZone_A8420;

		// Token: 0x04000F05 RID: 3845
		private global::AcpBusinessLayer.AcpField<bool> scanLstLabtoolLTEInterferingFreqPresent_A42197;
	}
}
