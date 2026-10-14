using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.FactoryOverrides
{
	// Token: 0x0200045C RID: 1116
	[global::System.Serializable]
	public class RxSSIClockRateTXModeInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06009480 RID: 38016 RVA: 0x008BD070 File Offset: 0x008BB270
		public RxSSIClockRateTXModeInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06009481 RID: 38017 RVA: 0x008BD08C File Offset: 0x008BB28C
		protected RxSSIClockRateTXModeInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06009482 RID: 38018 RVA: 0x008BD0A4 File Offset: 0x008BB2A4
		public override void Init()
		{
			int a_ = 12;
			short num = (short)397769333;
			short num2 = num;
			num = (short)101939829;
			switch (num2 == num)
			{
			}
			num = (short)1666842625;
			if (num != 0)
			{
			}
			num = (short)757858304;
			short num3 = num;
			num = (short)218759168;
			if (num != 0)
			{
			}
			this.fctOrdsRxSSIClockRateListTxModeTxFrequencyMHz_A42777 = new global::AcpBusinessLayer.AcpFrequencyField(161202500, this, global::AllFeatures.CodeplugGuid.b("诌곎ꗐ鳒꟔돖꫘觚ꗜ賞닠ꫢꛤ详蛨裪蛬뷮郰蟲郴믶郸裺觼꯾礀丂樄挆氈弊甌䤎挐瘒搔或簘甚縜昞氠欢弤砦栨ἪἬᠮذв", a_), global::CommonResources.AcgResources.ID_TXFREQUENCYMHZ, 0, int.MaxValue, 1);
			this.fctOrdsRxSSIClockRateListTxModeTxFrequencyMHz_A42777.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.fctOrdsRxSSIClockRateListTxModeTxFrequencyMHz_A42777.DataTransferOrder = 300;
			this.fctOrdsRxSSIClockRateTxModeRxSSIClockRateMHz_A42780 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("诌곎ꗐ鳒꟔돖꫘觚ꗜ賞닠ꫢꛤ详蛨裪蛬뷮郰蟲郴ꏶ臸뛺鋼鯾搀儂約吆娈䈊丌挎縐瀒縔䔖砘漚砜刞椠夢稤昦ᴨᤪᨬᜮİ", a_), global::CommonResources.AcgResources.ID_RXSSICLOCKRATEMHZ, global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.LOVs.FctOrdsRxSSIClockRateTxModeRxSSIClockRateMHz_A42780LovStrs);
			this.fctOrdsRxSSIClockRateTxModeRxSSIClockRateMHz_A42780.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.fctOrdsRxSSIClockRateTxModeRxSSIClockRateMHz_A42780.DataTransferOrder = 303;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鿌럎胒蛔黖律飚뇜냞苠裢엤뗦裨鿪裬쿮뷰髲蛴菶\ud9f8쇺\uddfc꯾礀⌂䠄栆洈渊", a_);
			base.Id = 10802;
			base.UIName = global::CommonResources.AcgResources.ID_RXSSICLOCKRATELISTTXMODE;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06009483 RID: 38019 RVA: 0x008BD210 File Offset: 0x008BB410
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 17;
			for (;;)
			{
				IL_09:
				short num = (short)1320681474;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_255;
					case 1:
						this.fctOrdsRxSSIClockRateListTxModeTxFrequencyMHz_A42777 = new global::AcpBusinessLayer.AcpFrequencyField(161202500, this, global::AllFeatures.CodeplugGuid.b("铑럓ꋕ韗꣙룛귝닟髡럣뗥ꇧꧩ胫臭鏯駱꛳韵賷鿹냻韽珿瘁倃縅䔇攉栋欍䐏樑刓搕紗欙椛笝丟䄡崣欥性倩猫漭Я1̳ĵ༷", a_), global::CommonResources.AcgResources.ID_TXFREQUENCYMHZ);
						this.fctOrdsRxSSIClockRateListTxModeTxFrequencyMHz_A42777.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
						this.fctOrdsRxSSIClockRateListTxModeTxFrequencyMHz_A42777.DataTransferOrder = 300;
						num = (short)1854472199;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						num = (short)932119682;
						short num3 = num;
						num = (short)630523010;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_09;
						default:
						{
							num = (short)1768488960;
							short num4 = num;
							num = (short)910229504;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_CE;
							}
							continue;
						}
						}
						break;
					}
					case 3:
						num = (short)1609629701;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						this.fctOrdsRxSSIClockRateTxModeRxSSIClockRateMHz_A42780 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("铑럓ꋕ韗꣙룛귝닟髡럣뗥ꇧꧩ胫臭鏯駱꛳韵賷鿹ꣻ蛽䷿洁怃挅娇爉弋崍夏儑砓礕笗焙丛缝吟䜡椣渥刧甩洫ᨭȯԱళص", a_), global::CommonResources.AcgResources.ID_RXSSICLOCKRATEMHZ, global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.LOVs.FctOrdsRxSSIClockRateTxModeRxSSIClockRateMHz_A42780LovStrs);
						this.fctOrdsRxSSIClockRateTxModeRxSSIClockRateMHz_A42780.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
						this.fctOrdsRxSSIClockRateTxModeRxSSIClockRateMHz_A42780.DataTransferOrder = 303;
						num = (short)1707147264;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (producerFields != null)
						{
							num = (short)2137653254;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2A3;
					case 6:
						num = (short)1766916105;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_F2;
					case 8:
						if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("铑럓ꋕ韗꣙룛귝닟髡럣뗥ꇧꧩ胫臭鏯駱꛳韵賷鿹ꣻ蛽䷿洁怃挅娇爉弋崍夏儑砓礕笗焙丛缝吟䜡椣渥刧甩洫ᨭȯԱళص", a_)))
						{
							num = (short)1254621188;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2A3;
					case 9:
						if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("铑럓ꋕ韗꣙룛귝닟髡럣뗥ꇧꧩ胫臭鏯駱꛳韵賷鿹냻韽珿瘁倃縅䔇攉栋欍䐏樑刓搕紗欙椛笝丟䄡崣欥性倩猫漭Я1̳ĵ༷", a_)))
						{
							num = (short)934871041;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F2;
					}
					IL_CE:
					if (global::AcpCommonLib.AppInfoManager.DropOperation)
					{
						num = (short)1488125955;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2A3;
					IL_F2:
					num = (short)2047606785;
					if (num != 0)
					{
					}
					num = (short)77594632;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_255:
			IL_2A3:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("胑곓诗觙闛ﻝꏟ軡诣藥菧쫩뻫迭蓯韱퓳뫵釷觹裻\udefd㫿∁倃縅⠇䜉挋樍甏", a_);
			base.Id = 10802;
			base.UIName = global::CommonResources.AcgResources.ID_RXSSICLOCKRATELISTTXMODE;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06009484 RID: 38020 RVA: 0x008BD4F4 File Offset: 0x008BB6F4
		public override void PopulateReferences()
		{
			short num = (short)1262157825;
			if (num != 0)
			{
			}
			num = (short)1762280267;
			short num2 = num;
			num = (short)1960919883;
			switch (num2 == num)
			{
			}
			num = (short)1534001152;
			short num3 = num;
			num = (short)572981248;
			if (num != 0)
			{
			}
		}

		// Token: 0x06009485 RID: 38021 RVA: 0x008BD59C File Offset: 0x008BB79C
		public override void DropReferences()
		{
			short num = (short)1225785345;
			if (num != 0)
			{
			}
			num = (short)942809329;
			short num2 = num;
			num = (short)1207509233;
			switch (num2 == num)
			{
			}
			num = (short)1064239104;
			short num3 = num;
			num = (short)1003814912;
			if (num != 0)
			{
			}
		}

		// Token: 0x06009486 RID: 38022 RVA: 0x008BD648 File Offset: 0x008BB848
		public override void SetConstraints()
		{
			short num = (short)1552547841;
			if (num != 0)
			{
			}
			num = (short)1117811164;
			short num2 = num;
			num = (short)905146844;
			switch (num2 == num)
			{
			}
			num = (short)242483200;
			short num3 = num;
			num = (short)678297600;
			if (num != 0)
			{
			}
			this.fctOrdsRxSSIClockRateListTxModeTxFrequencyMHz_A42777.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.FactoryOverridesConstraints.ConFactoryOverridesEnableIsChecked);
			this.fctOrdsRxSSIClockRateListTxModeTxFrequencyMHz_A42777.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.FactoryOverridesConstraints.ConFacOvrrdRxSSITXModeTxFreqMHzIsValid);
			this.fctOrdsRxSSIClockRateTxModeRxSSIClockRateMHz_A42780.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.FactoryOverridesConstraints.ConFactoryOverridesEnableIsChecked);
		}

		// Token: 0x06009487 RID: 38023 RVA: 0x008BD734 File Offset: 0x008BB934
		public override void SetupDependencies()
		{
			short num = (short)526066784;
			short num2 = num;
			num = (short)1625957472;
			switch (num2 == num)
			{
			}
			num = (short)1952907265;
			if (num != 0)
			{
			}
			num = (short)170852352;
			short num3 = num;
			num = (short)1026555904;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.FactoryOverrides factoryOverrides = base.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.FactoryOverrides;
			factoryOverrides.General.RadWideAdvancedFactoryOverrides_A8004.AddDependentObject(this.fctOrdsRxSSIClockRateListTxModeTxFrequencyMHz_A42777);
			factoryOverrides.General.RadWideAdvancedFactoryOverrides_A8004.AddDependentObject(this.fctOrdsRxSSIClockRateTxModeRxSSIClockRateMHz_A42780);
		}

		// Token: 0x17004ABA RID: 19130
		// (get) Token: 0x06009488 RID: 38024 RVA: 0x008BD820 File Offset: 0x008BBA20
		public bool HasDiffs
		{
			get
			{
				short num = (short)680609022;
				short num2 = num;
				num = (short)202065150;
				switch (num2 == num)
				{
				}
				num = (short)1256718336;
				if (num != 0)
				{
				}
				num = (short)418185216;
				short num3 = num;
				num = (short)1634271233;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17004ABB RID: 19131
		// (get) Token: 0x06009489 RID: 38025 RVA: 0x008BD8D0 File Offset: 0x008BBAD0
		// (set) Token: 0x0600948A RID: 38026 RVA: 0x008BD984 File Offset: 0x008BBB84
		public int FctOrdsRxSSIClockRateListTxModeTxFrequencyMHz_A42777Value
		{
			get
			{
				short num = (short)757162318;
				short num2 = num;
				num = (short)1740464462;
				switch (num2 == num)
				{
				}
				num = (short)235274241;
				if (num != 0)
				{
				}
				num = (short)942407680;
				short num3 = num;
				num = (short)726663168;
				if (num != 0)
				{
				}
				return this.fctOrdsRxSSIClockRateListTxModeTxFrequencyMHz_A42777.Value;
			}
			set
			{
				short num = (short)1786516560;
				short num2 = num;
				num = (short)1322718288;
				switch (num2 == num)
				{
				}
				num = (short)718405632;
				if (num != 0)
				{
				}
				num = (short)1579417600;
				short num3 = num;
				num = (short)1522794497;
				if (num != 0)
				{
				}
				this.fctOrdsRxSSIClockRateListTxModeTxFrequencyMHz_A42777.Value = value;
			}
		}

		// Token: 0x17004ABC RID: 19132
		// (get) Token: 0x0600948B RID: 38027 RVA: 0x008BDA3C File Offset: 0x008BBC3C
		// (set) Token: 0x0600948C RID: 38028 RVA: 0x008BDAF0 File Offset: 0x008BBCF0
		public string FctOrdsRxSSIClockRateListTxModeTxFrequencyMHz_A42777_UIValue
		{
			get
			{
				short num = (short)982515713;
				if (num != 0)
				{
				}
				num = (short)2016558462;
				short num2 = num;
				num = (short)1477590398;
				switch (num2 == num)
				{
				}
				num = (short)1607729152;
				short num3 = num;
				num = (short)2005729280;
				if (num != 0)
				{
				}
				return this.fctOrdsRxSSIClockRateListTxModeTxFrequencyMHz_A42777.UIValue;
			}
			set
			{
				short num = (short)181591564;
				short num2 = num;
				num = (short)1413013004;
				switch (num2 == num)
				{
				}
				num = (short)55705601;
				if (num != 0)
				{
				}
				num = (short)773586944;
				short num3 = num;
				num = (short)1132527616;
				if (num != 0)
				{
				}
				this.fctOrdsRxSSIClockRateListTxModeTxFrequencyMHz_A42777.UIValue = value;
			}
		}

		// Token: 0x17004ABD RID: 19133
		// (get) Token: 0x0600948D RID: 38029 RVA: 0x008BDBA4 File Offset: 0x008BBDA4
		public global::AcpBusinessLayer.AcpFrequencyField FctOrdsRxSSIClockRateListTxModeTxFrequencyMHz_A42777
		{
			get
			{
				short num = (short)925499393;
				if (num != 0)
				{
				}
				num = (short)390173441;
				short num2 = num;
				num = (short)562402049;
				switch (num2 == num)
				{
				}
				num = (short)1628897280;
				short num3 = num;
				num = (short)1942159360;
				if (num != 0)
				{
				}
				return this.fctOrdsRxSSIClockRateListTxModeTxFrequencyMHz_A42777;
			}
		}

		// Token: 0x17004ABE RID: 19134
		// (get) Token: 0x0600948E RID: 38030 RVA: 0x008BDC54 File Offset: 0x008BBE54
		// (set) Token: 0x0600948F RID: 38031 RVA: 0x008BDD0C File Offset: 0x008BBF0C
		internal int FctOrdsRxSSIClockRateListTxModeTxFrequencyMHz_A42777Min
		{
			get
			{
				short num = (short)1868762611;
				short num2 = num;
				num = (short)669453811;
				switch (num2 == num)
				{
				}
				num = (short)1865678848;
				if (num != 0)
				{
				}
				num = (short)1646067712;
				short num3 = num;
				num = (short)814219265;
				if (num != 0)
				{
				}
				return this.fctOrdsRxSSIClockRateListTxModeTxFrequencyMHz_A42777.Min;
			}
			set
			{
				short num = (short)646538180;
				short num2 = num;
				num = (short)1618305988;
				switch (num2 == num)
				{
				}
				num = (short)736624641;
				if (num != 0)
				{
				}
				num = (short)981139456;
				if (num != 0)
				{
				}
				num = (short)2029060096;
				short num3 = num;
				this.fctOrdsRxSSIClockRateListTxModeTxFrequencyMHz_A42777.Min = value;
			}
		}

		// Token: 0x17004ABF RID: 19135
		// (get) Token: 0x06009490 RID: 38032 RVA: 0x008BDDC0 File Offset: 0x008BBFC0
		// (set) Token: 0x06009491 RID: 38033 RVA: 0x008BDE78 File Offset: 0x008BC078
		internal int FctOrdsRxSSIClockRateListTxModeTxFrequencyMHz_A42777Max
		{
			get
			{
				short num = (short)677955398;
				short num2 = num;
				num = (short)75745094;
				switch (num2 == num)
				{
				}
				num = (short)21364737;
				if (num != 0)
				{
				}
				num = (short)146538496;
				if (num != 0)
				{
				}
				num = (short)1153433600;
				short num3 = num;
				return this.fctOrdsRxSSIClockRateListTxModeTxFrequencyMHz_A42777.Max;
			}
			set
			{
				short num = (short)1260326013;
				short num2 = num;
				num = (short)878709885;
				switch (num2 == num)
				{
				}
				num = (short)2114453504;
				if (num != 0)
				{
				}
				num = (short)483000321;
				if (num != 0)
				{
				}
				num = (short)988807168;
				short num3 = num;
				this.fctOrdsRxSSIClockRateListTxModeTxFrequencyMHz_A42777.Max = value;
			}
		}

		// Token: 0x17004AC0 RID: 19136
		// (get) Token: 0x06009492 RID: 38034 RVA: 0x008BDF2C File Offset: 0x008BC12C
		// (set) Token: 0x06009493 RID: 38035 RVA: 0x008BDFE0 File Offset: 0x008BC1E0
		internal int FctOrdsRxSSIClockRateListTxModeTxFrequencyMHz_A42777Step
		{
			get
			{
				short num = (short)1567982720;
				short num2 = num;
				num = (short)1893106816;
				switch (num2 == num)
				{
				}
				num = (short)258277376;
				if (num != 0)
				{
				}
				num = (short)1296629761;
				if (num != 0)
				{
				}
				num = (short)1734934528;
				short num3 = num;
				return this.fctOrdsRxSSIClockRateListTxModeTxFrequencyMHz_A42777.StepSize;
			}
			set
			{
				short num = (short)1817520370;
				short num2 = num;
				num = (short)1714432242;
				switch (num2 == num)
				{
				}
				num = (short)1080360961;
				if (num != 0)
				{
				}
				num = (short)1944584192;
				if (num != 0)
				{
				}
				num = (short)773849088;
				short num3 = num;
				this.fctOrdsRxSSIClockRateListTxModeTxFrequencyMHz_A42777.StepSize = value;
			}
		}

		// Token: 0x17004AC1 RID: 19137
		// (get) Token: 0x06009494 RID: 38036 RVA: 0x008BE094 File Offset: 0x008BC294
		// (set) Token: 0x06009495 RID: 38037 RVA: 0x008BE148 File Offset: 0x008BC348
		public bool FctOrdsRxSSIClockRateListTxModeTxFrequencyMHz_A42777_Applicable
		{
			get
			{
				short num = (short)1194457384;
				short num2 = num;
				num = (short)406911272;
				switch (num2 == num)
				{
				}
				num = (short)1464401921;
				if (num != 0)
				{
				}
				num = (short)1265762304;
				if (num != 0)
				{
				}
				num = (short)1539178496;
				short num3 = num;
				return this.fctOrdsRxSSIClockRateListTxModeTxFrequencyMHz_A42777.Applicable;
			}
			set
			{
				short num = (short)1389812418;
				short num2 = num;
				num = (short)844618434;
				switch (num2 == num)
				{
				}
				num = (short)1923481600;
				if (num != 0)
				{
				}
				num = (short)200671233;
				if (num != 0)
				{
				}
				num = (short)1849294848;
				short num3 = num;
				this.fctOrdsRxSSIClockRateListTxModeTxFrequencyMHz_A42777.Applicable = value;
			}
		}

		// Token: 0x17004AC2 RID: 19138
		// (get) Token: 0x06009496 RID: 38038 RVA: 0x008BE1FC File Offset: 0x008BC3FC
		// (set) Token: 0x06009497 RID: 38039 RVA: 0x008BE2B0 File Offset: 0x008BC4B0
		public bool FctOrdsRxSSIClockRateListTxModeTxFrequencyMHz_A42777_Valid
		{
			get
			{
				short num = (short)355389323;
				short num2 = num;
				num = (short)1551486859;
				switch (num2 == num)
				{
				}
				num = (short)511508480;
				if (num != 0)
				{
				}
				num = (short)1136984065;
				if (num != 0)
				{
				}
				num = (short)618856448;
				short num3 = num;
				return this.fctOrdsRxSSIClockRateListTxModeTxFrequencyMHz_A42777.Valid;
			}
			set
			{
				short num = (short)1227554092;
				short num2 = num;
				num = (short)986119468;
				switch (num2 == num)
				{
				}
				num = (short)261292033;
				if (num != 0)
				{
				}
				num = (short)1387986944;
				if (num != 0)
				{
				}
				num = (short)34537472;
				short num3 = num;
				this.fctOrdsRxSSIClockRateListTxModeTxFrequencyMHz_A42777.Valid = value;
			}
		}

		// Token: 0x17004AC3 RID: 19139
		// (get) Token: 0x06009498 RID: 38040 RVA: 0x008BE360 File Offset: 0x008BC560
		// (set) Token: 0x06009499 RID: 38041 RVA: 0x008BE414 File Offset: 0x008BC614
		public bool FctOrdsRxSSIClockRateListTxModeTxFrequencyMHz_A42777_Visible
		{
			get
			{
				short num = (short)96979679;
				short num2 = num;
				num = (short)1771948767;
				switch (num2 == num)
				{
				}
				num = (short)547946497;
				if (num != 0)
				{
				}
				num = (short)76480512;
				if (num != 0)
				{
				}
				num = (short)1540947968;
				short num3 = num;
				return this.fctOrdsRxSSIClockRateListTxModeTxFrequencyMHz_A42777.Visible;
			}
			set
			{
				short num = (short)802619393;
				if (num != 0)
				{
				}
				num = (short)751025225;
				short num2 = num;
				num = (short)575716425;
				switch (num2 == num)
				{
				}
				num = (short)776208384;
				if (num != 0)
				{
				}
				num = (short)514457600;
				short num3 = num;
				this.fctOrdsRxSSIClockRateListTxModeTxFrequencyMHz_A42777.Visible = value;
			}
		}

		// Token: 0x17004AC4 RID: 19140
		// (get) Token: 0x0600949A RID: 38042 RVA: 0x008BE4C8 File Offset: 0x008BC6C8
		// (set) Token: 0x0600949B RID: 38043 RVA: 0x008BE57C File Offset: 0x008BC77C
		public bool FctOrdsRxSSIClockRateListTxModeTxFrequencyMHz_A42777_Editable
		{
			get
			{
				short num = (short)187957249;
				if (num != 0)
				{
				}
				num = (short)1550956675;
				short num2 = num;
				num = (short)1485027459;
				switch (num2 == num)
				{
				}
				num = (short)2081357824;
				if (num != 0)
				{
				}
				num = (short)204210176;
				short num3 = num;
				return this.fctOrdsRxSSIClockRateListTxModeTxFrequencyMHz_A42777.Editable;
			}
			set
			{
				short num = (short)357629953;
				if (num != 0)
				{
				}
				num = (short)1126098993;
				short num2 = num;
				num = (short)1429465137;
				switch (num2 == num)
				{
				}
				num = (short)1113915392;
				if (num != 0)
				{
				}
				num = (short)1151795200;
				short num3 = num;
				this.fctOrdsRxSSIClockRateListTxModeTxFrequencyMHz_A42777.Editable = value;
			}
		}

		// Token: 0x17004AC5 RID: 19141
		// (get) Token: 0x0600949C RID: 38044 RVA: 0x008BE630 File Offset: 0x008BC830
		internal string FctOrdsRxSSIClockRateListTxModeTxFrequencyMHz_A42777_UILabel
		{
			get
			{
				short num = (short)512525808;
				short num2 = num;
				num = (short)1209107952;
				switch (num2 == num)
				{
				}
				num = (short)434831360;
				if (num != 0)
				{
				}
				num = (short)170328065;
				if (num != 0)
				{
				}
				num = (short)1428881408;
				short num3 = num;
				return this.fctOrdsRxSSIClockRateListTxModeTxFrequencyMHz_A42777.UIName;
			}
		}

		// Token: 0x17004AC6 RID: 19142
		// (get) Token: 0x0600949D RID: 38045 RVA: 0x008BE6E8 File Offset: 0x008BC8E8
		// (set) Token: 0x0600949E RID: 38046 RVA: 0x008BE7A0 File Offset: 0x008BC9A0
		internal bool FctOrdsRxSSIClockRateListTxModeTxFrequencyMHz_A42777_HiddenStatic
		{
			get
			{
				short num = (short)1779603588;
				short num2 = num;
				num = (short)1192401028;
				switch (num2 == num)
				{
				}
				num = (short)2103705601;
				if (num != 0)
				{
				}
				num = (short)1562771456;
				if (num != 0)
				{
				}
				num = (short)1777860608;
				short num3 = num;
				return this.fctOrdsRxSSIClockRateListTxModeTxFrequencyMHz_A42777.HiddenStatic;
			}
			set
			{
				short num = (short)2118844417;
				if (num != 0)
				{
				}
				num = (short)1092488802;
				short num2 = num;
				num = (short)1678118498;
				switch (num2 == num)
				{
				}
				num = (short)335020032;
				if (num != 0)
				{
				}
				num = (short)418316288;
				short num3 = num;
				this.fctOrdsRxSSIClockRateListTxModeTxFrequencyMHz_A42777.HiddenStatic = value;
			}
		}

		// Token: 0x17004AC7 RID: 19143
		// (get) Token: 0x0600949F RID: 38047 RVA: 0x008BE854 File Offset: 0x008BCA54
		// (set) Token: 0x060094A0 RID: 38048 RVA: 0x008BE908 File Offset: 0x008BCB08
		internal bool FctOrdsRxSSIClockRateListTxModeTxFrequencyMHz_A42777_HiddenDynamic
		{
			get
			{
				short num = (short)1265927259;
				short num2 = num;
				num = (short)1421444187;
				switch (num2 == num)
				{
				}
				num = (short)1285685248;
				if (num != 0)
				{
				}
				num = (short)361824257;
				if (num != 0)
				{
				}
				num = (short)1563688960;
				short num3 = num;
				return this.fctOrdsRxSSIClockRateListTxModeTxFrequencyMHz_A42777.HiddenDynamic;
			}
			set
			{
				short num = (short)1691807107;
				short num2 = num;
				num = (short)447606147;
				switch (num2 == num)
				{
				}
				num = (short)1990328321;
				if (num != 0)
				{
				}
				num = (short)175439872;
				if (num != 0)
				{
				}
				num = (short)1024065536;
				short num3 = num;
				this.fctOrdsRxSSIClockRateListTxModeTxFrequencyMHz_A42777.HiddenDynamic = value;
			}
		}

		// Token: 0x17004AC8 RID: 19144
		// (get) Token: 0x060094A1 RID: 38049 RVA: 0x008BE9C0 File Offset: 0x008BCBC0
		public bool FctOrdsRxSSIClockRateListTxModeTxFrequencyMHz_A42777_HasDiffs
		{
			get
			{
				short num = (short)27722365;
				short num2 = num;
				num = (short)1001390717;
				switch (num2 == num)
				{
				}
				num = (short)664862721;
				if (num != 0)
				{
				}
				num = (short)927072256;
				if (num != 0)
				{
				}
				num = (short)1036517376;
				short num3 = num;
				return this.fctOrdsRxSSIClockRateListTxModeTxFrequencyMHz_A42777._HasDiffs;
			}
		}

		// Token: 0x17004AC9 RID: 19145
		// (get) Token: 0x060094A2 RID: 38050 RVA: 0x008BEA78 File Offset: 0x008BCC78
		// (set) Token: 0x060094A3 RID: 38051 RVA: 0x008BEB30 File Offset: 0x008BCD30
		public int FctOrdsRxSSIClockRateTxModeRxSSIClockRateMHz_A42780Value
		{
			get
			{
				short num = (short)376539385;
				short num2 = num;
				num = (short)814582009;
				switch (num2 == num)
				{
				}
				num = (short)1766981633;
				if (num != 0)
				{
				}
				num = (short)736624640;
				if (num != 0)
				{
				}
				num = (short)624820224;
				short num3 = num;
				return this.fctOrdsRxSSIClockRateTxModeRxSSIClockRateMHz_A42780.Value;
			}
			set
			{
				short num = (short)1551802186;
				short num2 = num;
				num = (short)1321377610;
				switch (num2 == num)
				{
				}
				num = (short)294912001;
				if (num != 0)
				{
				}
				num = (short)16515072;
				if (num != 0)
				{
				}
				num = (short)1597767680;
				short num3 = num;
				this.fctOrdsRxSSIClockRateTxModeRxSSIClockRateMHz_A42780.Value = value;
			}
		}

		// Token: 0x17004ACA RID: 19146
		// (get) Token: 0x060094A4 RID: 38052 RVA: 0x008BEBE8 File Offset: 0x008BCDE8
		// (set) Token: 0x060094A5 RID: 38053 RVA: 0x008BEC9C File Offset: 0x008BCE9C
		public string FctOrdsRxSSIClockRateTxModeRxSSIClockRateMHz_A42780_UIValue
		{
			get
			{
				short num = (short)360195643;
				short num2 = num;
				num = (short)1434920507;
				switch (num2 == num)
				{
				}
				num = (short)2137718785;
				if (num != 0)
				{
				}
				num = (short)490471424;
				if (num != 0)
				{
				}
				num = (short)1676869632;
				short num3 = num;
				return this.fctOrdsRxSSIClockRateTxModeRxSSIClockRateMHz_A42780.UIValue;
			}
			set
			{
				short num = (short)1176436737;
				if (num != 0)
				{
				}
				num = (short)1111114689;
				short num2 = num;
				num = (short)688341953;
				switch (num2 == num)
				{
				}
				num = (short)1719861248;
				if (num != 0)
				{
				}
				num = (short)418906112;
				short num3 = num;
				this.fctOrdsRxSSIClockRateTxModeRxSSIClockRateMHz_A42780.UIValue = value;
			}
		}

		// Token: 0x17004ACB RID: 19147
		// (get) Token: 0x060094A6 RID: 38054 RVA: 0x008BED58 File Offset: 0x008BCF58
		public global::AcpBusinessLayer.AcpListField FctOrdsRxSSIClockRateTxModeRxSSIClockRateMHz_A42780
		{
			get
			{
				short num = (short)903836049;
				short num2 = num;
				num = (short)577335697;
				switch (num2 == num)
				{
				}
				num = (short)1744437249;
				if (num != 0)
				{
				}
				num = (short)643956736;
				if (num != 0)
				{
				}
				num = (short)1202388992;
				short num3 = num;
				return this.fctOrdsRxSSIClockRateTxModeRxSSIClockRateMHz_A42780;
			}
		}

		// Token: 0x17004ACC RID: 19148
		// (get) Token: 0x060094A7 RID: 38055 RVA: 0x008BEE08 File Offset: 0x008BD008
		// (set) Token: 0x060094A8 RID: 38056 RVA: 0x008BEEB8 File Offset: 0x008BD0B8
		public bool FctOrdsRxSSIClockRateTxModeRxSSIClockRateMHz_A42780_Applicable
		{
			get
			{
				short num = (short)2023127137;
				short num2 = num;
				num = (short)2142402657;
				switch (num2 == num)
				{
				}
				num = (short)2086076417;
				if (num != 0)
				{
				}
				num = (short)837615616;
				if (num != 0)
				{
				}
				num = (short)1093074944;
				short num3 = num;
				return this.fctOrdsRxSSIClockRateTxModeRxSSIClockRateMHz_A42780.Applicable;
			}
			set
			{
				short num = (short)2098635718;
				short num2 = num;
				num = (short)678011846;
				switch (num2 == num)
				{
				}
				num = (short)814678017;
				if (num != 0)
				{
				}
				num = (short)1542258688;
				if (num != 0)
				{
				}
				num = (short)595591168;
				short num3 = num;
				this.fctOrdsRxSSIClockRateTxModeRxSSIClockRateMHz_A42780.Applicable = value;
			}
		}

		// Token: 0x17004ACD RID: 19149
		// (get) Token: 0x060094A9 RID: 38057 RVA: 0x008BEF70 File Offset: 0x008BD170
		// (set) Token: 0x060094AA RID: 38058 RVA: 0x008BF024 File Offset: 0x008BD224
		public bool FctOrdsRxSSIClockRateTxModeRxSSIClockRateMHz_A42780_Valid
		{
			get
			{
				short num = (short)1840996032;
				short num2 = num;
				num = (short)1474453184;
				switch (num2 == num)
				{
				}
				num = (short)1499725825;
				if (num != 0)
				{
				}
				num = (short)1634467840;
				if (num != 0)
				{
				}
				num = (short)1532887040;
				short num3 = num;
				return this.fctOrdsRxSSIClockRateTxModeRxSSIClockRateMHz_A42780.Valid;
			}
			set
			{
				short num = (short)1113587713;
				if (num != 0)
				{
				}
				num = (short)561409387;
				short num2 = num;
				num = (short)465988971;
				switch (num2 == num)
				{
				}
				num = (short)23330816;
				if (num != 0)
				{
				}
				num = (short)1708785664;
				short num3 = num;
				this.fctOrdsRxSSIClockRateTxModeRxSSIClockRateMHz_A42780.Valid = value;
			}
		}

		// Token: 0x17004ACE RID: 19150
		// (get) Token: 0x060094AB RID: 38059 RVA: 0x008BF0DC File Offset: 0x008BD2DC
		// (set) Token: 0x060094AC RID: 38060 RVA: 0x008BF190 File Offset: 0x008BD390
		public bool FctOrdsRxSSIClockRateTxModeRxSSIClockRateMHz_A42780_Visible
		{
			get
			{
				short num = (short)502741071;
				short num2 = num;
				num = (short)1366571087;
				switch (num2 == num)
				{
				}
				num = (short)1727135744;
				if (num != 0)
				{
				}
				num = (short)8519681;
				if (num != 0)
				{
				}
				num = (short)673775616;
				short num3 = num;
				return this.fctOrdsRxSSIClockRateTxModeRxSSIClockRateMHz_A42780.Visible;
			}
			set
			{
				short num = (short)937434322;
				short num2 = num;
				num = (short)1443765458;
				switch (num2 == num)
				{
				}
				num = (short)990183424;
				if (num != 0)
				{
				}
				num = (short)203161601;
				if (num != 0)
				{
				}
				num = (short)189202432;
				short num3 = num;
				this.fctOrdsRxSSIClockRateTxModeRxSSIClockRateMHz_A42780.Visible = value;
			}
		}

		// Token: 0x17004ACF RID: 19151
		// (get) Token: 0x060094AD RID: 38061 RVA: 0x008BF248 File Offset: 0x008BD448
		// (set) Token: 0x060094AE RID: 38062 RVA: 0x008BF2FC File Offset: 0x008BD4FC
		public bool FctOrdsRxSSIClockRateTxModeRxSSIClockRateMHz_A42780_Editable
		{
			get
			{
				short num = (short)1164628305;
				short num2 = num;
				num = (short)97964369;
				switch (num2 == num)
				{
				}
				num = (short)1149960193;
				if (num != 0)
				{
				}
				num = (short)1067188224;
				if (num != 0)
				{
				}
				num = (short)745734144;
				short num3 = num;
				return this.fctOrdsRxSSIClockRateTxModeRxSSIClockRateMHz_A42780.Editable;
			}
			set
			{
				short num = (short)348647009;
				short num2 = num;
				num = (short)817491553;
				switch (num2 == num)
				{
				}
				num = (short)2136604672;
				if (num != 0)
				{
				}
				num = (short)1811087361;
				if (num != 0)
				{
				}
				num = (short)1427832832;
				short num3 = num;
				this.fctOrdsRxSSIClockRateTxModeRxSSIClockRateMHz_A42780.Editable = value;
			}
		}

		// Token: 0x17004AD0 RID: 19152
		// (get) Token: 0x060094AF RID: 38063 RVA: 0x008BF3B4 File Offset: 0x008BD5B4
		internal string FctOrdsRxSSIClockRateTxModeRxSSIClockRateMHz_A42780_UILabel
		{
			get
			{
				short num = (short)1547361053;
				short num2 = num;
				num = (short)1322638109;
				switch (num2 == num)
				{
				}
				num = (short)1970077697;
				if (num != 0)
				{
				}
				num = (short)1634402304;
				if (num != 0)
				{
				}
				num = (short)150274048;
				short num3 = num;
				return this.fctOrdsRxSSIClockRateTxModeRxSSIClockRateMHz_A42780.UIName;
			}
		}

		// Token: 0x17004AD1 RID: 19153
		// (get) Token: 0x060094B0 RID: 38064 RVA: 0x008BF468 File Offset: 0x008BD668
		// (set) Token: 0x060094B1 RID: 38065 RVA: 0x008BF520 File Offset: 0x008BD720
		internal bool FctOrdsRxSSIClockRateTxModeRxSSIClockRateMHz_A42780_HiddenStatic
		{
			get
			{
				short num = (short)1132070959;
				short num2 = num;
				num = (short)769001519;
				switch (num2 == num)
				{
				}
				num = (short)1126039552;
				if (num != 0)
				{
				}
				num = (short)207683585;
				if (num != 0)
				{
				}
				num = (short)1213726720;
				short num3 = num;
				return this.fctOrdsRxSSIClockRateTxModeRxSSIClockRateMHz_A42780.HiddenStatic;
			}
			set
			{
				short num = (short)887083756;
				short num2 = num;
				num = (short)144560876;
				switch (num2 == num)
				{
				}
				num = (short)1507262465;
				if (num != 0)
				{
				}
				num = (short)524550144;
				if (num != 0)
				{
				}
				num = (short)2123890688;
				short num3 = num;
				this.fctOrdsRxSSIClockRateTxModeRxSSIClockRateMHz_A42780.HiddenStatic = value;
			}
		}

		// Token: 0x17004AD2 RID: 19154
		// (get) Token: 0x060094B2 RID: 38066 RVA: 0x008BF5D8 File Offset: 0x008BD7D8
		// (set) Token: 0x060094B3 RID: 38067 RVA: 0x008BF690 File Offset: 0x008BD890
		internal bool FctOrdsRxSSIClockRateTxModeRxSSIClockRateMHz_A42780_HiddenDynamic
		{
			get
			{
				short num = (short)1557155703;
				short num2 = num;
				num = (short)996953975;
				switch (num2 == num)
				{
				}
				num = (short)725549057;
				if (num != 0)
				{
				}
				num = (short)2019622912;
				if (num != 0)
				{
				}
				num = (short)1081737216;
				short num3 = num;
				return this.fctOrdsRxSSIClockRateTxModeRxSSIClockRateMHz_A42780.HiddenDynamic;
			}
			set
			{
				short num = (short)1500010892;
				short num2 = num;
				num = (short)662985100;
				switch (num2 == num)
				{
				}
				num = (short)199032832;
				short num3 = num;
				num = (short)1649672192;
				if (num != 0)
				{
				}
				num = (short)1855586305;
				if (num != 0)
				{
				}
				this.fctOrdsRxSSIClockRateTxModeRxSSIClockRateMHz_A42780.HiddenDynamic = value;
			}
		}

		// Token: 0x17004AD3 RID: 19155
		// (get) Token: 0x060094B4 RID: 38068 RVA: 0x008BF744 File Offset: 0x008BD944
		public bool FctOrdsRxSSIClockRateTxModeRxSSIClockRateMHz_A42780_HasDiffs
		{
			get
			{
				short num = (short)909358667;
				short num2 = num;
				num = (short)2002105931;
				switch (num2 == num)
				{
				}
				num = (short)969146368;
				short num3 = num;
				num = (short)1826029569;
				if (num != 0)
				{
				}
				num = (short)1485111296;
				if (num != 0)
				{
				}
				return this.fctOrdsRxSSIClockRateTxModeRxSSIClockRateMHz_A42780._HasDiffs;
			}
		}

		// Token: 0x060094B5 RID: 38069 RVA: 0x008BF7F8 File Offset: 0x008BD9F8
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_70;
			}
			short num;
			int num3;
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_0A:
				num = (short)1405587267;
				short num2 = num;
				num = (short)385912643;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)713752576;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
						return result;
					case 1:
					{
						num = (short)550764544;
						short num4 = num;
						if (base.ParentRecset.ContainerDoc != null)
						{
							num = (short)29556738;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					case 2:
						result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
						num = (short)101580800;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						num = (short)1626669057;
						if (num != 0)
						{
						}
						if (base.ParentRecset != null)
						{
							num = (short)1817706500;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 4:
						goto IL_D1;
					}
					goto IL_70;
				}
				IL_D1:
				num = (short)1578696705;
				num3 = (int)((global::System.IntPtr)num);
			}
			return result;
			IL_70:
			result = null;
			num = (short)856621059;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x040049F1 RID: 18929
		private global::AcpBusinessLayer.AcpFrequencyField fctOrdsRxSSIClockRateListTxModeTxFrequencyMHz_A42777;

		// Token: 0x040049F2 RID: 18930
		private global::AcpBusinessLayer.AcpListField fctOrdsRxSSIClockRateTxModeRxSSIClockRateMHz_A42780;
	}
}
