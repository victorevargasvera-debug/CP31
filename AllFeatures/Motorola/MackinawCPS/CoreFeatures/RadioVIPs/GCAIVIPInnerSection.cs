using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using ConstraintHelper;
using Motorola.MackinawCPS.CoreFeatures.DVRSWide;
using Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;

namespace Motorola.MackinawCPS.CoreFeatures.RadioVIPs
{
	// Token: 0x020002EA RID: 746
	[global::System.Serializable]
	public class GCAIVIPInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x060078E5 RID: 30949 RVA: 0x006DFAB4 File Offset: 0x006DDCB4
		public GCAIVIPInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x060078E6 RID: 30950 RVA: 0x006DFAD0 File Offset: 0x006DDCD0
		protected GCAIVIPInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x060078E7 RID: 30951 RVA: 0x006DFAE8 File Offset: 0x006DDCE8
		public override void Init()
		{
			int a_ = 10;
			short num = (short)36700161;
			if (num != 0)
			{
			}
			num = (short)12510290;
			short num2 = num;
			num = (short)591586386;
			switch (num2 == num)
			{
			}
			num = (short)770506752;
			if (num != 0)
			{
			}
			num = (short)694157312;
			short num3 = num;
			this.gCAIVipInputBCO_42620 = new global::AcpBusinessLayer.AcpSparseLOVField(224, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.LOVs.indexGCAIVipInputBCO_42620LovStrs, global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.LOVs.idGCAIVipInputBCO_42620LovStrs), this, global::AllFeatures.CodeplugGuid.b("賊軌軎飐藒볔Ꟗ郘뗚규꫞闠ꇢꛤ꣦뛨\udfea\udfec\ud9ee쏰쏲", a_), global::CommonResources.AcgResources.ID_INPUTBCO, global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.LOVs.GCAIVipInputBCO_42620LovStrs);
			this.gCAIVipInputBCO_42620.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.gCAIVipInputBCO_42620.DataTransferOrder = -1;
			this.radioGCAIVIPKey_42621 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("駊곌ꯎ룐볒鋔铖飘鋚诜雞뇠꣢胤黦뛨\udfea\udfec\ud9ee쏰싲", a_), global::CommonResources.AcgResources.ID_KEY, 14);
			this.radioGCAIVIPKey_42621.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radioGCAIVIPKey_42621.DataTransferOrder = -1;
			this.radioGCAIVipName_42622 = new global::AcpBusinessLayer.AcpStringField(global::AllFeatures.CodeplugGuid.b("響", a_), this, global::AllFeatures.CodeplugGuid.b("駊곌ꯎ룐볒鋔铖飘鋚诜뛞釠귢蓤諦賨듪\ud9ec\uddee쟰쇲쟴", a_), global::CommonResources.AcgResources.ID_NAME, 100);
			this.radioGCAIVipName_42622.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radioGCAIVipName_42622.DataTransferOrder = -1;
			this.gCAIVipInputFeature_42623 = new global::AcpBusinessLayer.AcpSparseLOVField(38, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.LOVs.indexGCAIVipInputFeature_42623LovStrs, global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.LOVs.idGCAIVipInputFeature_42623LovStrs), this, global::AllFeatures.CodeplugGuid.b("賊軌軎飐藒볔Ꟗ郘뗚규꫞闠ꗢ胤蛦鷨黪鿬諮껰쟲쟴쇶쯸죺", a_), global::CommonResources.AcgResources.ID_INPUTFEATURE, true, global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.LOVs.GCAIVipInputFeature_42623LovStrs);
			this.gCAIVipInputFeature_42623.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.gCAIVipInputFeature_42623.DataTransferOrder = 50;
			this.gCAIVipInputFeature_42623.ValidateAcrossRecset = true;
			this.radioVIPGeneralShortPressTime = new global::AcpBusinessLayer.AcpSimpleRangeField(255, this, global::AllFeatures.CodeplugGuid.b("駊곌ꯎ룐볒菔黖觘鳚룜뇞蓠釢蓤详뫨菪苬鷮藰ꏲ蟴鋶諸裺ꧼ雾氀昂", a_), global::CommonResources.AcgResources.ID_SHORTPRESSTIME, 0, 124, null, null, 0, 50);
			this.radioVIPGeneralShortPressTime.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radioVIPGeneralShortPressTime.DataTransferOrder = -1;
			this.radioVIPGeneralShortPressTime.AddCustomValue(255, global::CommonResources.AcgResources.ID_RADIOWIDE);
			this.radioVIPGeneralShortPressTime.ShowHexValue = false;
			this.radioVIPGeneralShortPressTime.ValidateAcrossRecset = true;
			this.radioVIPGeneralLongPressTime = new global::AcpBusinessLayer.AcpSimpleRangeField(255, this, global::AllFeatures.CodeplugGuid.b("駊곌ꯎ룐볒菔黖觘鳚룜뇞蓠釢蓤详ꗨ蓪菬裮ꇰ臲郴蓶諸꿺铼鋾搀", a_), global::CommonResources.AcgResources.ID_LONGPRESSTIME, 0, 25, null, null, 0, 250);
			this.radioVIPGeneralLongPressTime.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radioVIPGeneralLongPressTime.DataTransferOrder = -1;
			((global::AcpBusinessLayer.AcpSimpleRangeField)this.radioVIPGeneralLongPressTime).AddCustomValue(255, global::CommonResources.AcgResources.ID_RADIOWIDE);
			this.radioVIPGeneralLongPressTime.ShowHexValue = false;
			this.radioVIPGeneralLongPressTime.ValidateAcrossRecset = true;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("賊軌軎飐菔黖觘ﯚ觜뻞菠迢胤", a_);
			base.Id = 10798;
			base.UIName = global::CommonResources.AcgResources.ID_GCAIVIPTABLE;
			base.DataTransferOrder = 2;
		}

		// Token: 0x060078E8 RID: 30952 RVA: 0x006DFDE0 File Offset: 0x006DDFE0
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 5;
			short num = (short)910819330;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					this.radioVIPGeneralLongPressTime = new global::AcpBusinessLayer.AcpSimpleRangeField(255, this, global::AllFeatures.CodeplugGuid.b("铅꧇껉ꗋꇍ蛏鯑蓓釕뷗듙맛곝臟軡꣣觥蛧跩볫鳭闯臱蟳ꋵ釷韹駻", a_), global::CommonResources.AcgResources.ID_LONGPRESSTIME, 0, 25, null, null, 0, 250);
					this.radioVIPGeneralLongPressTime.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radioVIPGeneralLongPressTime.DataTransferOrder = -1;
					((global::AcpBusinessLayer.AcpSimpleRangeField)this.radioVIPGeneralLongPressTime).AddCustomValue(255, global::CommonResources.AcgResources.ID_RADIOWIDE);
					this.radioVIPGeneralLongPressTime.ShowHexValue = false;
					this.radioVIPGeneralLongPressTime.ValidateAcrossRecset = true;
					num = (short)1148321796;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_A9;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_85;
					}
					continue;
				case 3:
					num = (short)1520697349;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_3D7;
				case 5:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("臅诇诉藋飍맏ꋑ鷓룕꣗꿙꣛鳝ꏟ귡믣틥\udae7\udce9\udeeb\udeed", a_)))
					{
						num = (short)858325011;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_42C;
				case 6:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("铅꧇껉ꗋꇍ蛏鯑蓓釕뷗듙맛곝臟軡럣軥蟧飩飫뻭苯韱蟳藵곷鏹釻鯽", a_)))
					{
						num = (short)78774284;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_211;
				case 7:
					goto IL_505;
				case 8:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("铅꧇껉ꗋꇍ韏金闓鿕軗鏙賛闝藟鯡믣틥\udae7\udce9\udeeb\udfed", a_)))
					{
						goto IL_45A;
					}
					goto IL_3DC;
				case 9:
				{
					num = (short)1064211942;
					short num3 = num;
					num = (short)933402086;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_45A;
					default:
						num = (short)247791616;
						if (num != 0)
						{
						}
						this.radioGCAIVipName_42622 = new global::AcpBusinessLayer.AcpStringField(global::AllFeatures.CodeplugGuid.b("", a_), this, global::AllFeatures.CodeplugGuid.b("铅꧇껉ꗋꇍ韏金闓鿕軗동곛郝臟迡臣맥\udce7\ud8e9\udaeb\udced싯", a_), global::CommonResources.AcgResources.ID_NAME, 100);
						this.radioGCAIVipName_42622.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
						this.radioGCAIVipName_42622.DataTransferOrder = -1;
						num = (short)580976647;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 10:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("铅꧇껉ꗋꇍ蛏鯑蓓釕뷗듙맛곝臟軡꣣觥蛧跩볫鳭闯臱蟳ꋵ釷韹駻", a_)))
					{
						num = (short)186449920;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_60A;
				case 11:
					goto IL_42C;
				case 12:
					this.radioVIPGeneralShortPressTime = new global::AcpBusinessLayer.AcpSimpleRangeField(255, this, global::AllFeatures.CodeplugGuid.b("铅꧇껉ꗋꇍ蛏鯑蓓釕뷗듙맛곝臟軡럣軥蟧飩飫뻭苯韱蟳藵곷鏹釻鯽", a_), global::CommonResources.AcgResources.ID_SHORTPRESSTIME, 0, 124, null, null, 0, 50);
					this.radioVIPGeneralShortPressTime.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radioVIPGeneralShortPressTime.DataTransferOrder = -1;
					this.radioVIPGeneralShortPressTime.AddCustomValue(255, global::CommonResources.AcgResources.ID_RADIOWIDE);
					this.radioVIPGeneralShortPressTime.ShowHexValue = false;
					this.radioVIPGeneralShortPressTime.ValidateAcrossRecset = true;
					num = (short)1449918484;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					this.gCAIVipInputFeature_42623 = new global::AcpBusinessLayer.AcpSparseLOVField(38, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.LOVs.indexGCAIVipInputFeature_42623LovStrs, global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.LOVs.idGCAIVipInputFeature_42623LovStrs), this, global::AllFeatures.CodeplugGuid.b("臅诇诉藋飍맏ꋑ鷓룕꣗꿙꣛飝藟菡郣鏥髧迩돫\udaed싯쓱웳엵", a_), global::CommonResources.AcgResources.ID_INPUTFEATURE, true, global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.LOVs.GCAIVipInputFeature_42623LovStrs);
					this.gCAIVipInputFeature_42623.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.gCAIVipInputFeature_42623.DataTransferOrder = 50;
					this.gCAIVipInputFeature_42623.ValidateAcrossRecset = true;
					num = (short)2049507329;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
				{
					num = (short)1964441600;
					short num4 = num;
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("臅诇诉藋飍맏ꋑ鷓룕꣗꿙꣛飝藟菡郣鏥髧迩돫\udaed싯쓱웳엵", a_)))
					{
						num = (short)24313869;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A9;
				}
				case 15:
					goto IL_3DC;
				case 16:
					if (producerFields != null)
					{
						num = (short)1989279747;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_60A;
				case 17:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("铅꧇껉ꗋꇍ韏金闓鿕軗동곛郝臟迡臣맥\udce7\ud8e9\udaeb\udced싯", a_)))
					{
						num = (short)295895049;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_505;
				case 18:
					this.radioGCAIVIPKey_42621 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("铅꧇껉ꗋꇍ韏金闓鿕軗鏙賛闝藟鯡믣틥\udae7\udce9\udeeb\udfed", a_), global::CommonResources.AcgResources.ID_KEY, 14);
					this.radioGCAIVIPKey_42621.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radioGCAIVIPKey_42621.DataTransferOrder = -1;
					num = (short)1475805199;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 19:
					num = (short)309133313;
					if (num != 0)
					{
					}
					this.gCAIVipInputBCO_42620 = new global::AcpBusinessLayer.AcpSparseLOVField(224, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.LOVs.indexGCAIVipInputBCO_42620LovStrs, global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.LOVs.idGCAIVipInputBCO_42620LovStrs), this, global::AllFeatures.CodeplugGuid.b("臅诇诉藋飍맏ꋑ鷓룕꣗꿙꣛鳝ꏟ귡믣틥\udae7\udce9\udeeb\udeed", a_), global::CommonResources.AcgResources.ID_INPUTBCO, global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.LOVs.GCAIVipInputBCO_42620LovStrs);
					this.gCAIVipInputBCO_42620.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.gCAIVipInputBCO_42620.DataTransferOrder = -1;
					num = (short)2072576011;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 20:
					goto IL_211;
				case 21:
					num = (short)822149136;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_85:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)483262485;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_A9:
				num = (short)1328742406;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_211:
				num = (short)1042087946;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3DC:
				num = (short)1104150545;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_42C:
				num = (short)122617864;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_45A:
				num = (short)1744699410;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_505:
				num = (short)1286275086;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_3D7:
			IL_60A:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("臅诇诉藋蛏鯑蓓賗믙뻛닝藟", a_);
			base.Id = 10798;
			base.UIName = global::CommonResources.AcgResources.ID_GCAIVIPTABLE;
			base.DataTransferOrder = 2;
		}

		// Token: 0x060078E9 RID: 30953 RVA: 0x006E0428 File Offset: 0x006DE628
		public override void PopulateReferences()
		{
			short num = (short)1124335617;
			if (num != 0)
			{
			}
			num = (short)1527233946;
			short num2 = num;
			num = (short)1906032026;
			switch (num2 == num)
			{
			}
			num = (short)1495597056;
			if (num != 0)
			{
			}
			num = (short)1862729728;
			short num3 = num;
		}

		// Token: 0x060078EA RID: 30954 RVA: 0x006E04D0 File Offset: 0x006DE6D0
		public override void DropReferences()
		{
			short num = (short)1117190846;
			short num2 = num;
			num = (short)1330903742;
			switch (num2 == num)
			{
			}
			num = (short)679542784;
			if (num != 0)
			{
			}
			num = (short)149684225;
			if (num != 0)
			{
			}
			num = (short)1672806400;
			short num3 = num;
		}

		// Token: 0x060078EB RID: 30955 RVA: 0x006E057C File Offset: 0x006DE77C
		public override void SetConstraints()
		{
			short num = (short)975256765;
			short num2 = num;
			num = (short)1570258109;
			switch (num2 == num)
			{
			}
			num = (short)796459008;
			if (num != 0)
			{
			}
			num = (short)2100101121;
			if (num != 0)
			{
			}
			num = (short)1267007488;
			short num3 = num;
			this.radioGCAIVipName_42622.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.gCAIVipInputFeature_42623.ValidateAcrossRecset = true;
			this.gCAIVipInputFeature_42623.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPsConstraints.conGCAIVipInputSelectIsApplicable);
			this.gCAIVipInputFeature_42623.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPsConstraints.ConGCAIVIPInputFeatureSelectValid);
		}

		// Token: 0x060078EC RID: 30956 RVA: 0x006E0678 File Offset: 0x006DE878
		public override void SetupDependencies()
		{
			short num = (short)1492586684;
			short num2 = num;
			num = (short)1398018236;
			switch (num2 == num)
			{
			}
			num = (short)578027521;
			if (num != 0)
			{
			}
			num = (short)1846870016;
			if (num != 0)
			{
			}
			num = (short)1927020544;
			short num3 = num;
			this.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.AddDependentObject(this.gCAIVipInputFeature_42623);
			this.RefRadioErgonomicsWide.Advanced.RadErgoWideAdvancedConsoletteEnable_A37231.AddDependentObject(this.gCAIVipInputFeature_42623);
			this.RefDVRSWide.General.RadErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911.AddDependentObject(this.gCAIVipInputFeature_42623);
			this.RefRadioErgonomicsWide.Advanced.RadErgoWideAdvancedLogicalSwitch2_A7756.AddDependentObject(this.gCAIVipInputFeature_42623);
		}

		// Token: 0x17003E20 RID: 15904
		// (get) Token: 0x060078ED RID: 30957 RVA: 0x006E0794 File Offset: 0x006DE994
		public bool HasDiffs
		{
			get
			{
				short num = (short)22118003;
				short num2 = num;
				num = (short)734166643;
				switch (num2 == num)
				{
				}
				num = (short)548536321;
				if (num != 0)
				{
				}
				num = (short)451149824;
				if (num != 0)
				{
				}
				num = (short)1636499456;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x17003E21 RID: 15905
		// (get) Token: 0x060078EE RID: 30958 RVA: 0x006E0848 File Offset: 0x006DEA48
		// (set) Token: 0x060078EF RID: 30959 RVA: 0x006E08FC File Offset: 0x006DEAFC
		public int GCAIVipInputBCO_42620Value
		{
			get
			{
				short num = (short)1448073891;
				short num2 = num;
				num = (short)536664739;
				switch (num2 == num)
				{
				}
				num = (short)1252720641;
				if (num != 0)
				{
				}
				num = (short)152764416;
				if (num != 0)
				{
				}
				num = (short)1956446208;
				short num3 = num;
				return this.gCAIVipInputBCO_42620.Value;
			}
			set
			{
				short num = (short)1490157569;
				if (num != 0)
				{
				}
				num = (short)1221284531;
				short num2 = num;
				num = (short)1950438067;
				switch (num2 == num)
				{
				}
				num = (short)125304832;
				if (num != 0)
				{
				}
				num = (short)1128726528;
				short num3 = num;
				this.gCAIVipInputBCO_42620.Value = value;
			}
		}

		// Token: 0x17003E22 RID: 15906
		// (get) Token: 0x060078F0 RID: 30960 RVA: 0x006E09B4 File Offset: 0x006DEBB4
		// (set) Token: 0x060078F1 RID: 30961 RVA: 0x006E0A68 File Offset: 0x006DEC68
		public string GCAIVipInputBCO_42620_UIValue
		{
			get
			{
				short num = (short)705213634;
				short num2 = num;
				num = (short)1993454786;
				switch (num2 == num)
				{
				}
				num = (short)1552154625;
				if (num != 0)
				{
				}
				num = (short)1225785344;
				short num3 = num;
				num = (short)1643249664;
				if (num != 0)
				{
				}
				return this.gCAIVipInputBCO_42620.UIValue;
			}
			set
			{
				short num = (short)896565205;
				short num2 = num;
				num = (short)1071611861;
				switch (num2 == num)
				{
				}
				num = (short)251265025;
				if (num != 0)
				{
				}
				num = (short)675545088;
				short num3 = num;
				num = (short)1014431744;
				if (num != 0)
				{
				}
				this.gCAIVipInputBCO_42620.UIValue = value;
			}
		}

		// Token: 0x17003E23 RID: 15907
		// (get) Token: 0x060078F2 RID: 30962 RVA: 0x006E0B1C File Offset: 0x006DED1C
		public global::AcpBusinessLayer.AcpListField GCAIVipInputBCO_42620
		{
			get
			{
				short num = (short)720023243;
				short num2 = num;
				num = (short)243969739;
				switch (num2 == num)
				{
				}
				num = (short)1946550273;
				if (num != 0)
				{
				}
				num = (short)482213888;
				short num3 = num;
				num = (short)1069285376;
				if (num != 0)
				{
				}
				return this.gCAIVipInputBCO_42620;
			}
		}

		// Token: 0x17003E24 RID: 15908
		// (get) Token: 0x060078F3 RID: 30963 RVA: 0x006E0BC8 File Offset: 0x006DEDC8
		// (set) Token: 0x060078F4 RID: 30964 RVA: 0x006E0C7C File Offset: 0x006DEE7C
		public bool GCAIVipInputBCO_42620_Applicable
		{
			get
			{
				short num = (short)1229553277;
				short num2 = num;
				num = (short)436108925;
				switch (num2 == num)
				{
				}
				num = (short)1152122880;
				if (num != 0)
				{
				}
				num = (short)1018953728;
				short num3 = num;
				num = (short)690618369;
				if (num != 0)
				{
				}
				return this.gCAIVipInputBCO_42620.Applicable;
			}
			set
			{
				short num = (short)1467695589;
				short num2 = num;
				num = (short)1285308901;
				switch (num2 == num)
				{
				}
				num = (short)1613496321;
				if (num != 0)
				{
				}
				num = (short)854458368;
				short num3 = num;
				num = (short)1226833920;
				if (num != 0)
				{
				}
				this.gCAIVipInputBCO_42620.Applicable = value;
			}
		}

		// Token: 0x17003E25 RID: 15909
		// (get) Token: 0x060078F5 RID: 30965 RVA: 0x006E0D34 File Offset: 0x006DEF34
		// (set) Token: 0x060078F6 RID: 30966 RVA: 0x006E0DE8 File Offset: 0x006DEFE8
		public bool GCAIVipInputBCO_42620_Valid
		{
			get
			{
				short num = (short)1059742881;
				short num2 = num;
				num = (short)562521249;
				switch (num2 == num)
				{
				}
				num = (short)826343425;
				if (num != 0)
				{
				}
				num = (short)1499987968;
				short num3 = num;
				num = (short)576651264;
				if (num != 0)
				{
				}
				return this.gCAIVipInputBCO_42620.Valid;
			}
			set
			{
				short num = (short)2051342337;
				if (num != 0)
				{
				}
				num = (short)1416786245;
				short num2 = num;
				num = (short)26112325;
				switch (num2 == num)
				{
				}
				num = (short)1272578048;
				short num3 = num;
				num = (short)900399104;
				if (num != 0)
				{
				}
				this.gCAIVipInputBCO_42620.Valid = value;
			}
		}

		// Token: 0x17003E26 RID: 15910
		// (get) Token: 0x060078F7 RID: 30967 RVA: 0x006E0EA0 File Offset: 0x006DF0A0
		// (set) Token: 0x060078F8 RID: 30968 RVA: 0x006E0F54 File Offset: 0x006DF154
		public bool GCAIVipInputBCO_42620_Visible
		{
			get
			{
				short num = (short)391623338;
				short num2 = num;
				num = (short)787133098;
				switch (num2 == num)
				{
				}
				num = (short)488374273;
				if (num != 0)
				{
				}
				num = (short)566755328;
				short num3 = num;
				num = (short)276365312;
				if (num != 0)
				{
				}
				return this.gCAIVipInputBCO_42620.Visible;
			}
			set
			{
				short num = (short)550687027;
				short num2 = num;
				num = (short)1950404915;
				switch (num2 == num)
				{
				}
				num = (short)315949057;
				if (num != 0)
				{
				}
				num = (short)1025572864;
				short num3 = num;
				num = (short)2117074944;
				if (num != 0)
				{
				}
				this.gCAIVipInputBCO_42620.Visible = value;
			}
		}

		// Token: 0x17003E27 RID: 15911
		// (get) Token: 0x060078F9 RID: 30969 RVA: 0x006E1008 File Offset: 0x006DF208
		// (set) Token: 0x060078FA RID: 30970 RVA: 0x006E10BC File Offset: 0x006DF2BC
		public bool GCAIVipInputBCO_42620_Editable
		{
			get
			{
				short num = (short)1178927105;
				if (num != 0)
				{
				}
				num = (short)1785823379;
				short num2 = num;
				num = (short)655261843;
				switch (num2 == num)
				{
				}
				num = (short)3997696;
				short num3 = num;
				num = (short)336461824;
				if (num != 0)
				{
				}
				return this.gCAIVipInputBCO_42620.Editable;
			}
			set
			{
				short num = (short)2090895192;
				short num2 = num;
				num = (short)433096536;
				switch (num2 == num)
				{
				}
				num = (short)1750532097;
				if (num != 0)
				{
				}
				num = (short)574160896;
				short num3 = num;
				num = (short)3670016;
				if (num != 0)
				{
				}
				this.gCAIVipInputBCO_42620.Editable = value;
			}
		}

		// Token: 0x17003E28 RID: 15912
		// (get) Token: 0x060078FB RID: 30971 RVA: 0x006E1174 File Offset: 0x006DF374
		internal string GCAIVipInputBCO_42620_UILabel
		{
			get
			{
				short num = (short)837027015;
				short num2 = num;
				num = (short)1244202183;
				switch (num2 == num)
				{
				}
				num = (short)586022912;
				if (num != 0)
				{
				}
				num = (short)693960704;
				short num3 = num;
				num = (short)1433337857;
				if (num != 0)
				{
				}
				return this.gCAIVipInputBCO_42620.UIName;
			}
		}

		// Token: 0x17003E29 RID: 15913
		// (get) Token: 0x060078FC RID: 30972 RVA: 0x006E1228 File Offset: 0x006DF428
		// (set) Token: 0x060078FD RID: 30973 RVA: 0x006E12DC File Offset: 0x006DF4DC
		internal bool GCAIVipInputBCO_42620_HiddenStatic
		{
			get
			{
				short num = (short)517337590;
				short num2 = num;
				num = (short)1023013366;
				switch (num2 == num)
				{
				}
				num = (short)1930297345;
				if (num != 0)
				{
				}
				num = (short)2093350912;
				short num3 = num;
				num = (short)131989504;
				if (num != 0)
				{
				}
				return this.gCAIVipInputBCO_42620.HiddenStatic;
			}
			set
			{
				short num = (short)28480221;
				short num2 = num;
				num = (short)1147376349;
				switch (num2 == num)
				{
				}
				num = (short)116654081;
				if (num != 0)
				{
				}
				num = (short)2063073280;
				short num3 = num;
				num = (short)299171840;
				if (num != 0)
				{
				}
				this.gCAIVipInputBCO_42620.HiddenStatic = value;
			}
		}

		// Token: 0x17003E2A RID: 15914
		// (get) Token: 0x060078FE RID: 30974 RVA: 0x006E1390 File Offset: 0x006DF590
		// (set) Token: 0x060078FF RID: 30975 RVA: 0x006E1444 File Offset: 0x006DF644
		internal bool GCAIVipInputBCO_42620_HiddenDynamic
		{
			get
			{
				short num = (short)688354804;
				short num2 = num;
				num = (short)20608500;
				switch (num2 == num)
				{
				}
				num = (short)171704321;
				if (num != 0)
				{
				}
				num = (short)1029898240;
				short num3 = num;
				num = (short)1786314752;
				if (num != 0)
				{
				}
				return this.gCAIVipInputBCO_42620.HiddenDynamic;
			}
			set
			{
				short num = (short)742455754;
				short num2 = num;
				num = (short)1400895946;
				switch (num2 == num)
				{
				}
				num = (short)1192034304;
				if (num != 0)
				{
				}
				num = (short)902561792;
				short num3 = num;
				num = (short)1114046465;
				if (num != 0)
				{
				}
				this.gCAIVipInputBCO_42620.HiddenDynamic = value;
			}
		}

		// Token: 0x17003E2B RID: 15915
		// (get) Token: 0x06007900 RID: 30976 RVA: 0x006E14F8 File Offset: 0x006DF6F8
		public bool GCAIVipInputBCO_42620_HasDiffs
		{
			get
			{
				short num = (short)576438098;
				short num2 = num;
				num = (short)1535950674;
				switch (num2 == num)
				{
				}
				num = (short)609681409;
				if (num != 0)
				{
				}
				num = (short)1296302080;
				short num3 = num;
				num = (short)179372032;
				if (num != 0)
				{
				}
				return this.gCAIVipInputBCO_42620._HasDiffs;
			}
		}

		// Token: 0x17003E2C RID: 15916
		// (get) Token: 0x06007901 RID: 30977 RVA: 0x006E15AC File Offset: 0x006DF7AC
		// (set) Token: 0x06007902 RID: 30978 RVA: 0x006E1660 File Offset: 0x006DF860
		public string RadioGCAIVIPKey_42621Value
		{
			get
			{
				short num = (short)910764278;
				short num2 = num;
				num = (short)88156406;
				switch (num2 == num)
				{
				}
				num = (short)1162018817;
				if (num != 0)
				{
				}
				num = (short)337969152;
				short num3 = num;
				num = (short)1510998016;
				if (num != 0)
				{
				}
				return this.radioGCAIVIPKey_42621.Value;
			}
			set
			{
				short num = (short)714338075;
				short num2 = num;
				num = (short)153022235;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_C6:
					num = (short)1103953921;
					if (num != 0)
					{
					}
					this.radioGCAIVIPKey_42621.Value = value;
					num = (short)996737026;
					num3 = (int)((global::System.IntPtr)num);
					break;
				default:
				{
					num = (short)978321408;
					if (num != 0)
					{
					}
					num = (short)1624375296;
					short num4 = num;
					num = (short)1070006273;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				}
				for (;;)
				{
					switch (num3)
					{
					case 0:
						goto IL_C6;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_A4;
						}
						continue;
					case 2:
						return;
					}
					IL_A4:
					if (string.IsNullOrEmpty(value.Trim()))
					{
						break;
					}
					num = (short)112918528;
					num3 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x17003E2D RID: 15917
		// (get) Token: 0x06007903 RID: 30979 RVA: 0x006E1780 File Offset: 0x006DF980
		// (set) Token: 0x06007904 RID: 30980 RVA: 0x006E1834 File Offset: 0x006DFA34
		public string RadioGCAIVIPKey_42621_UIValue
		{
			get
			{
				short num = (short)340131841;
				if (num != 0)
				{
				}
				num = (short)1801221397;
				short num2 = num;
				num = (short)739079445;
				switch (num2 == num)
				{
				}
				num = (short)183304192;
				short num3 = num;
				num = (short)1019543552;
				if (num != 0)
				{
				}
				return this.radioGCAIVIPKey_42621.Value;
			}
			set
			{
				short num = (short)722826705;
				short num2 = num;
				num = (short)1690072529;
				switch (num2 == num)
				{
				}
				num = (short)68747265;
				if (num != 0)
				{
				}
				num = (short)2013003776;
				short num3 = num;
				num = (short)1962082304;
				if (num != 0)
				{
				}
				this.radioGCAIVIPKey_42621.Value = value;
			}
		}

		// Token: 0x17003E2E RID: 15918
		// (get) Token: 0x06007905 RID: 30981 RVA: 0x006E18EC File Offset: 0x006DFAEC
		public global::AcpBusinessLayer.AcpKeyField RadioGCAIVIPKey_42621
		{
			get
			{
				short num = (short)457968206;
				short num2 = num;
				num = (short)587008590;
				switch (num2 == num)
				{
				}
				num = (short)896991232;
				if (num != 0)
				{
				}
				num = (short)1484652544;
				short num3 = num;
				num = (short)1058930689;
				if (num != 0)
				{
				}
				return this.radioGCAIVIPKey_42621;
			}
		}

		// Token: 0x17003E2F RID: 15919
		// (get) Token: 0x06007906 RID: 30982 RVA: 0x006E19A0 File Offset: 0x006DFBA0
		// (set) Token: 0x06007907 RID: 30983 RVA: 0x006E1A54 File Offset: 0x006DFC54
		public bool RadioGCAIVIPKey_42621_Applicable
		{
			get
			{
				short num = (short)177639670;
				short num2 = num;
				num = (short)683249910;
				switch (num2 == num)
				{
				}
				num = (short)1985347585;
				if (num != 0)
				{
				}
				num = (short)551813120;
				short num3 = num;
				num = (short)2083258368;
				if (num != 0)
				{
				}
				return this.radioGCAIVIPKey_42621.Applicable;
			}
			set
			{
				short num = (short)590452870;
				short num2 = num;
				num = (short)1813551238;
				switch (num2 == num)
				{
				}
				num = (short)901185537;
				if (num != 0)
				{
				}
				num = (short)1362100224;
				short num3 = num;
				num = (short)1065091072;
				if (num != 0)
				{
				}
				this.radioGCAIVIPKey_42621.Applicable = value;
			}
		}

		// Token: 0x17003E30 RID: 15920
		// (get) Token: 0x06007908 RID: 30984 RVA: 0x006E1B0C File Offset: 0x006DFD0C
		// (set) Token: 0x06007909 RID: 30985 RVA: 0x006E1BC4 File Offset: 0x006DFDC4
		public bool RadioGCAIVIPKey_42621_Valid
		{
			get
			{
				short num = (short)1025450342;
				short num2 = num;
				num = (short)1509171558;
				switch (num2 == num)
				{
				}
				num = (short)969277440;
				if (num != 0)
				{
				}
				num = (short)1023475712;
				short num3 = num;
				num = (short)50462721;
				if (num != 0)
				{
				}
				return this.radioGCAIVIPKey_42621.Valid;
			}
			set
			{
				short num = (short)2038506900;
				short num2 = num;
				num = (short)1967728020;
				switch (num2 == num)
				{
				}
				num = (short)1054801920;
				if (num != 0)
				{
				}
				num = (short)829095936;
				short num3 = num;
				num = (short)1433206785;
				if (num != 0)
				{
				}
				this.radioGCAIVIPKey_42621.Valid = value;
			}
		}

		// Token: 0x17003E31 RID: 15921
		// (get) Token: 0x0600790A RID: 30986 RVA: 0x006E1C78 File Offset: 0x006DFE78
		// (set) Token: 0x0600790B RID: 30987 RVA: 0x006E1D2C File Offset: 0x006DFF2C
		public bool RadioGCAIVIPKey_42621_Visible
		{
			get
			{
				short num = (short)1062731777;
				if (num != 0)
				{
				}
				num = (short)130771178;
				short num2 = num;
				num = (short)1902471402;
				switch (num2 == num)
				{
				}
				num = (short)597164032;
				short num3 = num;
				num = (short)421068800;
				if (num != 0)
				{
				}
				return this.radioGCAIVIPKey_42621.Visible;
			}
			set
			{
				short num = (short)128210051;
				short num2 = num;
				num = (short)2050053251;
				switch (num2 == num)
				{
				}
				num = (short)1259339777;
				if (num != 0)
				{
				}
				num = (short)1211891712;
				short num3 = num;
				num = (short)1963261952;
				if (num != 0)
				{
				}
				this.radioGCAIVIPKey_42621.Visible = value;
			}
		}

		// Token: 0x17003E32 RID: 15922
		// (get) Token: 0x0600790C RID: 30988 RVA: 0x006E1DE0 File Offset: 0x006DFFE0
		// (set) Token: 0x0600790D RID: 30989 RVA: 0x006E1E94 File Offset: 0x006E0094
		public bool RadioGCAIVIPKey_42621_Editable
		{
			get
			{
				short num = (short)1957888001;
				if (num != 0)
				{
				}
				num = (short)530068501;
				short num2 = num;
				num = (short)242168853;
				switch (num2 == num)
				{
				}
				num = (short)693895168;
				short num3 = num;
				num = (short)13500416;
				if (num != 0)
				{
				}
				return this.radioGCAIVIPKey_42621.Editable;
			}
			set
			{
				short num = (short)1149874710;
				short num2 = num;
				num = (short)116437526;
				switch (num2 == num)
				{
				}
				num = (short)335937537;
				if (num != 0)
				{
				}
				num = (short)1598488576;
				short num3 = num;
				num = (short)460980224;
				if (num != 0)
				{
				}
				this.radioGCAIVIPKey_42621.Editable = value;
			}
		}

		// Token: 0x17003E33 RID: 15923
		// (get) Token: 0x0600790E RID: 30990 RVA: 0x006E1F48 File Offset: 0x006E0148
		internal string RadioGCAIVIPKey_42621_UILabel
		{
			get
			{
				short num = (short)1367157933;
				short num2 = num;
				num = (short)1105669293;
				switch (num2 == num)
				{
				}
				num = (short)1547304960;
				if (num != 0)
				{
				}
				num = (short)961019904;
				short num3 = num;
				num = (short)990445569;
				if (num != 0)
				{
				}
				return this.radioGCAIVIPKey_42621.UIName;
			}
		}

		// Token: 0x17003E34 RID: 15924
		// (get) Token: 0x0600790F RID: 30991 RVA: 0x006E1FFC File Offset: 0x006E01FC
		// (set) Token: 0x06007910 RID: 30992 RVA: 0x006E20B4 File Offset: 0x006E02B4
		internal bool RadioGCAIVIPKey_42621_HiddenStatic
		{
			get
			{
				short num = (short)1472186907;
				short num2 = num;
				num = (short)850643483;
				switch (num2 == num)
				{
				}
				num = (short)89915393;
				if (num != 0)
				{
				}
				num = (short)1577713664;
				short num3 = num;
				num = (short)58720256;
				if (num != 0)
				{
				}
				return this.radioGCAIVIPKey_42621.HiddenStatic;
			}
			set
			{
				short num = (short)531828875;
				short num2 = num;
				num = (short)402985099;
				switch (num2 == num)
				{
				}
				num = (short)2029846529;
				if (num != 0)
				{
				}
				num = (short)2058747904;
				short num3 = num;
				num = (short)230227968;
				if (num != 0)
				{
				}
				this.radioGCAIVIPKey_42621.HiddenStatic = value;
			}
		}

		// Token: 0x17003E35 RID: 15925
		// (get) Token: 0x06007911 RID: 30993 RVA: 0x006E216C File Offset: 0x006E036C
		// (set) Token: 0x06007912 RID: 30994 RVA: 0x006E2224 File Offset: 0x006E0424
		internal bool RadioGCAIVIPKey_42621_HiddenDynamic
		{
			get
			{
				short num = (short)1881997313;
				if (num != 0)
				{
				}
				num = (short)598855557;
				short num2 = num;
				num = (short)2008076165;
				switch (num2 == num)
				{
				}
				num = (short)1996095488;
				short num3 = num;
				num = (short)428539904;
				if (num != 0)
				{
				}
				return this.radioGCAIVIPKey_42621.HiddenDynamic;
			}
			set
			{
				short num = (short)175439873;
				if (num != 0)
				{
				}
				num = (short)1073695833;
				short num2 = num;
				num = (short)863063129;
				switch (num2 == num)
				{
				}
				num = (short)1148387328;
				short num3 = num;
				num = (short)1268973568;
				if (num != 0)
				{
				}
				this.radioGCAIVIPKey_42621.HiddenDynamic = value;
			}
		}

		// Token: 0x17003E36 RID: 15926
		// (get) Token: 0x06007913 RID: 30995 RVA: 0x006E22D8 File Offset: 0x006E04D8
		public bool RadioGCAIVIPKey_42621_HasDiffs
		{
			get
			{
				short num = (short)1670431156;
				short num2 = num;
				num = (short)1692975540;
				switch (num2 == num)
				{
				}
				num = (short)1889337345;
				if (num != 0)
				{
				}
				num = (short)942342144;
				short num3 = num;
				num = (short)2111045632;
				if (num != 0)
				{
				}
				return this.radioGCAIVIPKey_42621._HasDiffs;
			}
		}

		// Token: 0x17003E37 RID: 15927
		// (get) Token: 0x06007914 RID: 30996 RVA: 0x006E238C File Offset: 0x006E058C
		// (set) Token: 0x06007915 RID: 30997 RVA: 0x006E243C File Offset: 0x006E063C
		public string RadioGCAIVipName_42622Value
		{
			get
			{
				short num = (short)98435073;
				if (num != 0)
				{
				}
				num = (short)1443602090;
				short num2 = num;
				num = (short)829333162;
				switch (num2 == num)
				{
				}
				num = (short)700579840;
				short num3 = num;
				num = (short)310116352;
				if (num != 0)
				{
				}
				return this.radioGCAIVipName_42622.Value;
			}
			set
			{
				short num = (short)1149983374;
				short num2 = num;
				num = (short)354638478;
				switch (num2 == num)
				{
				}
				num = (short)590610433;
				if (num != 0)
				{
				}
				num = (short)1792475136;
				short num3 = num;
				num = (short)1138229248;
				if (num != 0)
				{
				}
				this.radioGCAIVipName_42622.Value = value;
			}
		}

		// Token: 0x17003E38 RID: 15928
		// (get) Token: 0x06007916 RID: 30998 RVA: 0x006E24F8 File Offset: 0x006E06F8
		public global::AcpBusinessLayer.AcpField<string> RadioGCAIVipName_42622
		{
			get
			{
				short num = (short)409815567;
				short num2 = num;
				num = (short)1086540303;
				switch (num2 == num)
				{
				}
				num = (short)1550319616;
				if (num != 0)
				{
				}
				num = (short)2100166656;
				short num3 = num;
				num = (short)1159004161;
				if (num != 0)
				{
				}
				return this.radioGCAIVipName_42622;
			}
		}

		// Token: 0x17003E39 RID: 15929
		// (get) Token: 0x06007917 RID: 30999 RVA: 0x006E25A8 File Offset: 0x006E07A8
		// (set) Token: 0x06007918 RID: 31000 RVA: 0x006E265C File Offset: 0x006E085C
		public string RadioGCAIVipName_42622_UIValue
		{
			get
			{
				short num = (short)699670613;
				short num2 = num;
				num = (short)286597205;
				switch (num2 == num)
				{
				}
				num = (short)1897988097;
				if (num != 0)
				{
				}
				num = (short)1982201856;
				short num3 = num;
				num = (short)10813440;
				if (num != 0)
				{
				}
				return this.radioGCAIVipName_42622.Value;
			}
			set
			{
				short num = (short)1287472846;
				short num2 = num;
				num = (short)543770318;
				switch (num2 == num)
				{
				}
				num = (short)1248133120;
				if (num != 0)
				{
				}
				num = (short)1041170432;
				short num3 = num;
				num = (short)824967169;
				if (num != 0)
				{
				}
				this.radioGCAIVipName_42622.Value = value;
			}
		}

		// Token: 0x17003E3A RID: 15930
		// (get) Token: 0x06007919 RID: 31001 RVA: 0x006E2710 File Offset: 0x006E0910
		// (set) Token: 0x0600791A RID: 31002 RVA: 0x006E27C4 File Offset: 0x006E09C4
		public bool RadioGCAIVipName_42622_Applicable
		{
			get
			{
				short num = (short)1320960925;
				short num2 = num;
				num = (short)2139636637;
				switch (num2 == num)
				{
				}
				num = (short)906166273;
				if (num != 0)
				{
				}
				num = (short)726138880;
				short num3 = num;
				num = (short)519110656;
				if (num != 0)
				{
				}
				return this.radioGCAIVipName_42622.Applicable;
			}
			set
			{
				short num = (short)972270455;
				short num2 = num;
				num = (short)16296823;
				switch (num2 == num)
				{
				}
				num = (short)457244673;
				if (num != 0)
				{
				}
				num = (short)1876623360;
				short num3 = num;
				num = (short)2130640896;
				if (num != 0)
				{
				}
				this.radioGCAIVipName_42622.Applicable = value;
			}
		}

		// Token: 0x17003E3B RID: 15931
		// (get) Token: 0x0600791B RID: 31003 RVA: 0x006E2878 File Offset: 0x006E0A78
		// (set) Token: 0x0600791C RID: 31004 RVA: 0x006E292C File Offset: 0x006E0B2C
		public bool RadioGCAIVipName_42622_Valid
		{
			get
			{
				short num = (short)2081770675;
				short num2 = num;
				num = (short)1377324211;
				switch (num2 == num)
				{
				}
				num = (short)614072320;
				if (num != 0)
				{
				}
				num = (short)1996488704;
				short num3 = num;
				num = (short)1405943809;
				if (num != 0)
				{
				}
				return this.radioGCAIVipName_42622.Valid;
			}
			set
			{
				short num = (short)2062327256;
				short num2 = num;
				num = (short)1853988312;
				switch (num2 == num)
				{
				}
				num = (short)653787136;
				if (num != 0)
				{
				}
				num = (short)395247616;
				short num3 = num;
				num = (short)321650689;
				if (num != 0)
				{
				}
				this.radioGCAIVipName_42622.Valid = value;
			}
		}

		// Token: 0x17003E3C RID: 15932
		// (get) Token: 0x0600791D RID: 31005 RVA: 0x006E29E0 File Offset: 0x006E0BE0
		// (set) Token: 0x0600791E RID: 31006 RVA: 0x006E2A94 File Offset: 0x006E0C94
		public bool RadioGCAIVipName_42622_Visible
		{
			get
			{
				short num = (short)1803368183;
				short num2 = num;
				num = (short)1971009271;
				switch (num2 == num)
				{
				}
				num = (short)581369857;
				if (num != 0)
				{
				}
				num = (short)1283915776;
				short num3 = num;
				num = (short)1343684608;
				if (num != 0)
				{
				}
				return this.radioGCAIVipName_42622.Visible;
			}
			set
			{
				short num = (short)1520366172;
				short num2 = num;
				num = (short)1335816796;
				switch (num2 == num)
				{
				}
				num = (short)2129461248;
				if (num != 0)
				{
				}
				num = (short)252968960;
				short num3 = num;
				num = (short)117374977;
				if (num != 0)
				{
				}
				this.radioGCAIVipName_42622.Visible = value;
			}
		}

		// Token: 0x17003E3D RID: 15933
		// (get) Token: 0x0600791F RID: 31007 RVA: 0x006E2B48 File Offset: 0x006E0D48
		// (set) Token: 0x06007920 RID: 31008 RVA: 0x006E2BFC File Offset: 0x006E0DFC
		public bool RadioGCAIVipName_42622_Editable
		{
			get
			{
				short num = (short)731841288;
				short num2 = num;
				num = (short)1916732168;
				switch (num2 == num)
				{
				}
				num = (short)346226689;
				if (num != 0)
				{
				}
				num = (short)938999808;
				short num3 = num;
				num = (short)18481152;
				if (num != 0)
				{
				}
				return this.radioGCAIVipName_42622.Editable;
			}
			set
			{
				short num = (short)1515079589;
				short num2 = num;
				num = (short)338249637;
				switch (num2 == num)
				{
				}
				num = (short)772407296;
				if (num != 0)
				{
				}
				num = (short)1200816128;
				short num3 = num;
				num = (short)464191489;
				if (num != 0)
				{
				}
				this.radioGCAIVipName_42622.Editable = value;
			}
		}

		// Token: 0x17003E3E RID: 15934
		// (get) Token: 0x06007921 RID: 31009 RVA: 0x006E2CB0 File Offset: 0x006E0EB0
		internal string RadioGCAIVipName_42622_UILabel
		{
			get
			{
				short num = (short)202965235;
				short num2 = num;
				num = (short)245432563;
				switch (num2 == num)
				{
				}
				num = (short)116523008;
				if (num != 0)
				{
				}
				num = (short)1189019648;
				short num3 = num;
				num = (short)2125529089;
				if (num != 0)
				{
				}
				return this.radioGCAIVipName_42622.UIName;
			}
		}

		// Token: 0x17003E3F RID: 15935
		// (get) Token: 0x06007922 RID: 31010 RVA: 0x006E2D68 File Offset: 0x006E0F68
		// (set) Token: 0x06007923 RID: 31011 RVA: 0x006E2E1C File Offset: 0x006E101C
		internal bool RadioGCAIVipName_42622_HiddenStatic
		{
			get
			{
				short num = (short)1983315969;
				if (num != 0)
				{
				}
				num = (short)92568938;
				short num2 = num;
				num = (short)274824554;
				switch (num2 == num)
				{
				}
				num = (short)458948608;
				short num3 = num;
				num = (short)312213504;
				if (num != 0)
				{
				}
				return this.radioGCAIVipName_42622.HiddenStatic;
			}
			set
			{
				short num = (short)2042429441;
				if (num != 0)
				{
				}
				num = (short)900655046;
				short num2 = num;
				num = (short)2120607686;
				switch (num2 == num)
				{
				}
				num = (short)1206845440;
				short num3 = num;
				num = (short)494075904;
				if (num != 0)
				{
				}
				this.radioGCAIVipName_42622.HiddenStatic = value;
			}
		}

		// Token: 0x17003E40 RID: 15936
		// (get) Token: 0x06007924 RID: 31012 RVA: 0x006E2ED4 File Offset: 0x006E10D4
		// (set) Token: 0x06007925 RID: 31013 RVA: 0x006E2F88 File Offset: 0x006E1188
		internal bool RadioGCAIVipName_42622_HiddenDynamic
		{
			get
			{
				short num = (short)446730071;
				short num2 = num;
				num = (short)9932631;
				switch (num2 == num)
				{
				}
				num = (short)1128660992;
				if (num != 0)
				{
				}
				num = (short)1589248000;
				short num3 = num;
				num = (short)1053687809;
				if (num != 0)
				{
				}
				return this.radioGCAIVipName_42622.HiddenDynamic;
			}
			set
			{
				short num = (short)1715404801;
				if (num != 0)
				{
				}
				num = (short)219637134;
				short num2 = num;
				num = (short)165963150;
				switch (num2 == num)
				{
				}
				num = (short)998703104;
				short num3 = num;
				num = (short)1829634048;
				if (num != 0)
				{
				}
				this.radioGCAIVipName_42622.HiddenDynamic = value;
			}
		}

		// Token: 0x17003E41 RID: 15937
		// (get) Token: 0x06007926 RID: 31014 RVA: 0x006E3040 File Offset: 0x006E1240
		public bool RadioGCAIVipName_42622_HasDiffs
		{
			get
			{
				short num = (short)1878318306;
				short num2 = num;
				num = (short)1456463074;
				switch (num2 == num)
				{
				}
				num = (short)1571028992;
				if (num != 0)
				{
				}
				num = (short)289734656;
				short num3 = num;
				num = (short)1470889985;
				if (num != 0)
				{
				}
				return this.radioGCAIVipName_42622._HasDiffs;
			}
		}

		// Token: 0x17003E42 RID: 15938
		// (get) Token: 0x06007927 RID: 31015 RVA: 0x006E30F4 File Offset: 0x006E12F4
		// (set) Token: 0x06007928 RID: 31016 RVA: 0x006E31AC File Offset: 0x006E13AC
		public int GCAIVipInputFeature_42623Value
		{
			get
			{
				short num = (short)734177907;
				short num2 = num;
				num = (short)15510131;
				switch (num2 == num)
				{
				}
				num = (short)1980432385;
				if (num != 0)
				{
				}
				num = (short)1324482560;
				short num3 = num;
				num = (short)442236928;
				if (num != 0)
				{
				}
				return this.gCAIVipInputFeature_42623.Value;
			}
			set
			{
				short num = (short)1611656926;
				short num2 = num;
				num = (short)606727902;
				switch (num2 == num)
				{
				}
				num = (short)526254080;
				if (num != 0)
				{
				}
				num = (short)39452672;
				short num3 = num;
				num = (short)1982201857;
				if (num != 0)
				{
				}
				this.gCAIVipInputFeature_42623.Value = value;
			}
		}

		// Token: 0x17003E43 RID: 15939
		// (get) Token: 0x06007929 RID: 31017 RVA: 0x006E3260 File Offset: 0x006E1460
		// (set) Token: 0x0600792A RID: 31018 RVA: 0x006E3314 File Offset: 0x006E1514
		public string GCAIVipInputFeature_42623_UIValue
		{
			get
			{
				short num = (short)1950094917;
				short num2 = num;
				num = (short)200021573;
				switch (num2 == num)
				{
				}
				num = (short)1611464704;
				if (num != 0)
				{
				}
				num = (short)327417856;
				short num3 = num;
				num = (short)84934657;
				if (num != 0)
				{
				}
				return this.gCAIVipInputFeature_42623.UIValue;
			}
			set
			{
				short num = (short)1069112599;
				short num2 = num;
				num = (short)805264663;
				switch (num2 == num)
				{
				}
				num = (short)105512960;
				if (num != 0)
				{
				}
				num = (short)1566507008;
				short num3 = num;
				num = (short)1977024513;
				if (num != 0)
				{
				}
				this.gCAIVipInputFeature_42623.UIValue = value;
			}
		}

		// Token: 0x17003E44 RID: 15940
		// (get) Token: 0x0600792B RID: 31019 RVA: 0x006E33C8 File Offset: 0x006E15C8
		public global::AcpBusinessLayer.AcpListField GCAIVipInputFeature_42623
		{
			get
			{
				short num = (short)2060196945;
				short num2 = num;
				num = (short)1085676625;
				switch (num2 == num)
				{
				}
				num = (short)1266614272;
				if (num != 0)
				{
				}
				num = (short)361758721;
				if (num != 0)
				{
				}
				num = (short)326172672;
				short num3 = num;
				return this.gCAIVipInputFeature_42623;
			}
		}

		// Token: 0x17003E45 RID: 15941
		// (get) Token: 0x0600792C RID: 31020 RVA: 0x006E3478 File Offset: 0x006E1678
		// (set) Token: 0x0600792D RID: 31021 RVA: 0x006E352C File Offset: 0x006E172C
		public bool GCAIVipInputFeature_42623_Applicable
		{
			get
			{
				short num = (short)680197047;
				short num2 = num;
				num = (short)503577527;
				switch (num2 == num)
				{
				}
				num = (short)782106625;
				if (num != 0)
				{
				}
				num = (short)1813315584;
				if (num != 0)
				{
				}
				num = (short)454426624;
				short num3 = num;
				return this.gCAIVipInputFeature_42623.Applicable;
			}
			set
			{
				short num = (short)1867979970;
				short num2 = num;
				num = (short)731323586;
				switch (num2 == num)
				{
				}
				num = (short)861011969;
				if (num != 0)
				{
				}
				num = (short)439091200;
				if (num != 0)
				{
				}
				num = (short)626327552;
				short num3 = num;
				this.gCAIVipInputFeature_42623.Applicable = value;
			}
		}

		// Token: 0x17003E46 RID: 15942
		// (get) Token: 0x0600792E RID: 31022 RVA: 0x006E35E0 File Offset: 0x006E17E0
		// (set) Token: 0x0600792F RID: 31023 RVA: 0x006E3694 File Offset: 0x006E1894
		public bool GCAIVipInputFeature_42623_Valid
		{
			get
			{
				short num = (short)272334484;
				short num2 = num;
				num = (short)39616148;
				switch (num2 == num)
				{
				}
				num = (short)484376577;
				if (num != 0)
				{
				}
				num = (short)1238237184;
				if (num != 0)
				{
				}
				num = (short)15925248;
				short num3 = num;
				return this.gCAIVipInputFeature_42623.Valid;
			}
			set
			{
				short num = (short)2082873116;
				short num2 = num;
				num = (short)2100305692;
				switch (num2 == num)
				{
				}
				num = (short)2095316993;
				if (num != 0)
				{
				}
				num = (short)1985937408;
				if (num != 0)
				{
				}
				num = (short)261226496;
				short num3 = num;
				this.gCAIVipInputFeature_42623.Valid = value;
			}
		}

		// Token: 0x17003E47 RID: 15943
		// (get) Token: 0x06007930 RID: 31024 RVA: 0x006E3748 File Offset: 0x006E1948
		// (set) Token: 0x06007931 RID: 31025 RVA: 0x006E37FC File Offset: 0x006E19FC
		public bool GCAIVipInputFeature_42623_Visible
		{
			get
			{
				short num = (short)1763922918;
				short num2 = num;
				num = (short)61166566;
				switch (num2 == num)
				{
				}
				num = (short)734134273;
				if (num != 0)
				{
				}
				num = (short)677773312;
				if (num != 0)
				{
				}
				num = (short)1509359616;
				short num3 = num;
				return this.gCAIVipInputFeature_42623.Visible;
			}
			set
			{
				short num = (short)2118958396;
				short num2 = num;
				num = (short)1170783548;
				switch (num2 == num)
				{
				}
				num = (short)1615069184;
				if (num != 0)
				{
				}
				num = (short)38535169;
				if (num != 0)
				{
				}
				num = (short)2048524288;
				short num3 = num;
				this.gCAIVipInputFeature_42623.Visible = value;
			}
		}

		// Token: 0x17003E48 RID: 15944
		// (get) Token: 0x06007932 RID: 31026 RVA: 0x006E38B4 File Offset: 0x006E1AB4
		// (set) Token: 0x06007933 RID: 31027 RVA: 0x006E396C File Offset: 0x006E1B6C
		public bool GCAIVipInputFeature_42623_Editable
		{
			get
			{
				short num = (short)2018243644;
				short num2 = num;
				num = (short)1692922940;
				switch (num2 == num)
				{
				}
				num = (short)246611969;
				if (num != 0)
				{
				}
				num = (short)860618752;
				if (num != 0)
				{
				}
				num = (short)203161600;
				short num3 = num;
				return this.gCAIVipInputFeature_42623.Editable;
			}
			set
			{
				short num = (short)1895375472;
				short num2 = num;
				num = (short)181215856;
				switch (num2 == num)
				{
				}
				num = (short)1302921217;
				if (num != 0)
				{
				}
				num = (short)590020608;
				if (num != 0)
				{
				}
				num = (short)1224146944;
				short num3 = num;
				this.gCAIVipInputFeature_42623.Editable = value;
			}
		}

		// Token: 0x17003E49 RID: 15945
		// (get) Token: 0x06007934 RID: 31028 RVA: 0x006E3A20 File Offset: 0x006E1C20
		internal string GCAIVipInputFeature_42623_UILabel
		{
			get
			{
				short num = (short)1492600452;
				short num2 = num;
				num = (short)1782990468;
				switch (num2 == num)
				{
				}
				num = (short)1671233537;
				if (num != 0)
				{
				}
				num = (short)824639488;
				if (num != 0)
				{
				}
				num = (short)927268864;
				short num3 = num;
				return this.gCAIVipInputFeature_42623.UIName;
			}
		}

		// Token: 0x17003E4A RID: 15946
		// (get) Token: 0x06007935 RID: 31029 RVA: 0x006E3ADC File Offset: 0x006E1CDC
		// (set) Token: 0x06007936 RID: 31030 RVA: 0x006E3B94 File Offset: 0x006E1D94
		internal bool GCAIVipInputFeature_42623_HiddenStatic
		{
			get
			{
				short num = (short)550745151;
				short num2 = num;
				num = (short)1914811455;
				switch (num2 == num)
				{
				}
				num = (short)288489472;
				if (num != 0)
				{
				}
				num = (short)1509163009;
				if (num != 0)
				{
				}
				num = (short)422182912;
				short num3 = num;
				return this.gCAIVipInputFeature_42623.HiddenStatic;
			}
			set
			{
				short num = (short)1721129760;
				short num2 = num;
				num = (short)497441568;
				switch (num2 == num)
				{
				}
				num = (short)358285312;
				if (num != 0)
				{
				}
				num = (short)1106575361;
				if (num != 0)
				{
				}
				num = (short)11796480;
				short num3 = num;
				this.gCAIVipInputFeature_42623.HiddenStatic = value;
			}
		}

		// Token: 0x17003E4B RID: 15947
		// (get) Token: 0x06007937 RID: 31031 RVA: 0x006E3C4C File Offset: 0x006E1E4C
		// (set) Token: 0x06007938 RID: 31032 RVA: 0x006E3D00 File Offset: 0x006E1F00
		internal bool GCAIVipInputFeature_42623_HiddenDynamic
		{
			get
			{
				short num = (short)150863873;
				if (num != 0)
				{
				}
				num = (short)237790403;
				short num2 = num;
				num = (short)1159554243;
				switch (num2 == num)
				{
				}
				num = (short)1226309632;
				if (num != 0)
				{
				}
				num = (short)1647575040;
				short num3 = num;
				return this.gCAIVipInputFeature_42623.HiddenDynamic;
			}
			set
			{
				short num = (short)1718869734;
				short num2 = num;
				num = (short)1155849958;
				switch (num2 == num)
				{
				}
				num = (short)1698168832;
				if (num != 0)
				{
				}
				num = (short)461766657;
				if (num != 0)
				{
				}
				num = (short)1318387712;
				short num3 = num;
				this.gCAIVipInputFeature_42623.HiddenDynamic = value;
			}
		}

		// Token: 0x17003E4C RID: 15948
		// (get) Token: 0x06007939 RID: 31033 RVA: 0x006E3DB4 File Offset: 0x006E1FB4
		public bool GCAIVipInputFeature_42623_HasDiffs
		{
			get
			{
				short num = (short)1563479750;
				short num2 = num;
				num = (short)767282886;
				switch (num2 == num)
				{
				}
				num = (short)1183383553;
				if (num != 0)
				{
				}
				num = (short)1995964416;
				if (num != 0)
				{
				}
				num = (short)586678272;
				short num3 = num;
				return this.gCAIVipInputFeature_42623._HasDiffs;
			}
		}

		// Token: 0x17003E4D RID: 15949
		// (get) Token: 0x0600793A RID: 31034 RVA: 0x006E3E68 File Offset: 0x006E2068
		// (set) Token: 0x0600793B RID: 31035 RVA: 0x006E3F20 File Offset: 0x006E2120
		public int RadioVIPGeneralShortPressTimeValue
		{
			get
			{
				short num = (short)2044014150;
				short num2 = num;
				num = (short)230960710;
				switch (num2 == num)
				{
				}
				num = (short)1420623873;
				if (num != 0)
				{
				}
				num = (short)815464448;
				if (num != 0)
				{
				}
				num = (short)977797120;
				short num3 = num;
				return this.radioVIPGeneralShortPressTime.Value;
			}
			set
			{
				short num = (short)780022324;
				short num2 = num;
				num = (short)592851508;
				switch (num2 == num)
				{
				}
				num = (short)843120640;
				if (num != 0)
				{
				}
				num = (short)455016449;
				if (num != 0)
				{
				}
				num = (short)316669952;
				short num3 = num;
				this.radioVIPGeneralShortPressTime.Value = value;
			}
		}

		// Token: 0x17003E4E RID: 15950
		// (get) Token: 0x0600793C RID: 31036 RVA: 0x006E3FD8 File Offset: 0x006E21D8
		// (set) Token: 0x0600793D RID: 31037 RVA: 0x006E408C File Offset: 0x006E228C
		public string RadioVIPGeneralShortPressTime_UIValue
		{
			get
			{
				short num = (short)466509527;
				short num2 = num;
				num = (short)1612603095;
				switch (num2 == num)
				{
				}
				num = (short)207421441;
				if (num != 0)
				{
				}
				num = (short)203030528;
				if (num != 0)
				{
				}
				num = (short)96600064;
				short num3 = num;
				return this.radioVIPGeneralShortPressTime.UIValue;
			}
			set
			{
				short num = (short)162546755;
				short num2 = num;
				num = (short)347161667;
				switch (num2 == num)
				{
				}
				num = (short)1142620161;
				if (num != 0)
				{
				}
				num = (short)527040512;
				if (num != 0)
				{
				}
				num = (short)1608384512;
				short num3 = num;
				this.radioVIPGeneralShortPressTime.UIValue = value;
			}
		}

		// Token: 0x17003E4F RID: 15951
		// (get) Token: 0x0600793E RID: 31038 RVA: 0x006E4140 File Offset: 0x006E2340
		public global::AcpBusinessLayer.AcpSimpleRangeField RadioVIPGeneralShortPressTime
		{
			get
			{
				short num = (short)665516718;
				short num2 = num;
				num = (short)2143943342;
				switch (num2 == num)
				{
				}
				num = (short)1908539393;
				if (num != 0)
				{
				}
				num = (short)1782054912;
				if (num != 0)
				{
				}
				num = (short)1267204096;
				short num3 = num;
				return this.radioVIPGeneralShortPressTime;
			}
		}

		// Token: 0x17003E50 RID: 15952
		// (get) Token: 0x0600793F RID: 31039 RVA: 0x006E41F0 File Offset: 0x006E23F0
		// (set) Token: 0x06007940 RID: 31040 RVA: 0x006E42A4 File Offset: 0x006E24A4
		internal int RadioVIPGeneralShortPressTimeMin
		{
			get
			{
				short num = (short)248441454;
				short num2 = num;
				num = (short)219605614;
				switch (num2 == num)
				{
				}
				num = (short)1348337665;
				if (num != 0)
				{
				}
				num = (short)147128320;
				if (num != 0)
				{
				}
				num = (short)991232000;
				short num3 = num;
				return this.radioVIPGeneralShortPressTime.Min;
			}
			set
			{
				short num = (short)1615134721;
				if (num != 0)
				{
				}
				num = (short)1027420983;
				short num2 = num;
				num = (short)1058878263;
				switch (num2 == num)
				{
				}
				num = (short)852099072;
				if (num != 0)
				{
				}
				num = (short)2022047744;
				short num3 = num;
				this.radioVIPGeneralShortPressTime.Min = value;
			}
		}

		// Token: 0x17003E51 RID: 15953
		// (get) Token: 0x06007941 RID: 31041 RVA: 0x006E435C File Offset: 0x006E255C
		// (set) Token: 0x06007942 RID: 31042 RVA: 0x006E4414 File Offset: 0x006E2614
		internal int RadioVIPGeneralShortPressTimeMax
		{
			get
			{
				short num = (short)222689;
				short num2 = num;
				num = (short)27551201;
				switch (num2 == num)
				{
				}
				num = (short)1354760192;
				if (num != 0)
				{
				}
				num = (short)943849473;
				if (num != 0)
				{
				}
				num = (short)1492910080;
				short num3 = num;
				return this.radioVIPGeneralShortPressTime.Max;
			}
			set
			{
				short num = (short)2076839133;
				short num2 = num;
				num = (short)584060125;
				switch (num2 == num)
				{
				}
				num = (short)871694336;
				if (num != 0)
				{
				}
				num = (short)1829437441;
				if (num != 0)
				{
				}
				num = (short)991625216;
				short num3 = num;
				this.radioVIPGeneralShortPressTime.Max = value;
			}
		}

		// Token: 0x17003E52 RID: 15954
		// (get) Token: 0x06007943 RID: 31043 RVA: 0x006E44C8 File Offset: 0x006E26C8
		// (set) Token: 0x06007944 RID: 31044 RVA: 0x006E457C File Offset: 0x006E277C
		internal int RadioVIPGeneralShortPressTimeStep
		{
			get
			{
				short num = (short)602813218;
				short num2 = num;
				num = (short)20984610;
				switch (num2 == num)
				{
				}
				num = (short)1362886657;
				if (num != 0)
				{
				}
				num = (short)457048064;
				if (num != 0)
				{
				}
				num = (short)1904345088;
				short num3 = num;
				return this.radioVIPGeneralShortPressTime.StepSize;
			}
			set
			{
				short num = (short)961150977;
				if (num != 0)
				{
				}
				num = (short)1260926123;
				short num2 = num;
				num = (short)405746859;
				switch (num2 == num)
				{
				}
				num = (short)966328320;
				if (num != 0)
				{
				}
				num = (short)902365184;
				short num3 = num;
				this.radioVIPGeneralShortPressTime.StepSize = value;
			}
		}

		// Token: 0x17003E53 RID: 15955
		// (get) Token: 0x06007945 RID: 31045 RVA: 0x006E4634 File Offset: 0x006E2834
		// (set) Token: 0x06007946 RID: 31046 RVA: 0x006E46E8 File Offset: 0x006E28E8
		public bool RadioVIPGeneralShortPressTime_Applicable
		{
			get
			{
				short num = (short)20792550;
				short num2 = num;
				num = (short)1683113190;
				switch (num2 == num)
				{
				}
				num = (short)1569914880;
				if (num != 0)
				{
				}
				num = (short)2133458945;
				if (num != 0)
				{
				}
				num = (short)441384960;
				short num3 = num;
				return this.radioVIPGeneralShortPressTime.Applicable;
			}
			set
			{
				short num = (short)1689008836;
				short num2 = num;
				num = (short)1937390276;
				switch (num2 == num)
				{
				}
				num = (short)1058930689;
				if (num != 0)
				{
				}
				num = (short)368508928;
				if (num != 0)
				{
				}
				num = (short)1701249024;
				short num3 = num;
				this.radioVIPGeneralShortPressTime.Applicable = value;
			}
		}

		// Token: 0x17003E54 RID: 15956
		// (get) Token: 0x06007947 RID: 31047 RVA: 0x006E47A0 File Offset: 0x006E29A0
		// (set) Token: 0x06007948 RID: 31048 RVA: 0x006E4858 File Offset: 0x006E2A58
		public bool RadioVIPGeneralShortPressTime_Valid
		{
			get
			{
				short num = (short)841657085;
				short num2 = num;
				num = (short)1673636605;
				switch (num2 == num)
				{
				}
				num = (short)864288769;
				if (num != 0)
				{
				}
				num = (short)1134690304;
				if (num != 0)
				{
				}
				num = (short)1045233664;
				short num3 = num;
				return this.radioVIPGeneralShortPressTime.Valid;
			}
			set
			{
				short num = (short)1114829475;
				short num2 = num;
				num = (short)1140322979;
				switch (num2 == num)
				{
				}
				num = (short)2013069313;
				if (num != 0)
				{
				}
				num = (short)1051000832;
				if (num != 0)
				{
				}
				num = (short)2129723392;
				short num3 = num;
				this.radioVIPGeneralShortPressTime.Valid = value;
			}
		}

		// Token: 0x17003E55 RID: 15957
		// (get) Token: 0x06007949 RID: 31049 RVA: 0x006E490C File Offset: 0x006E2B0C
		// (set) Token: 0x0600794A RID: 31050 RVA: 0x006E49C4 File Offset: 0x006E2BC4
		public bool RadioVIPGeneralShortPressTime_Visible
		{
			get
			{
				short num = (short)2012389861;
				short num2 = num;
				num = (short)485597669;
				switch (num2 == num)
				{
				}
				num = (short)1762066432;
				if (num != 0)
				{
				}
				num = (short)992149505;
				if (num != 0)
				{
				}
				num = (short)1700069376;
				short num3 = num;
				return this.radioVIPGeneralShortPressTime.Visible;
			}
			set
			{
				short num = (short)1542771414;
				short num2 = num;
				num = (short)1739051734;
				switch (num2 == num)
				{
				}
				num = (short)1645346817;
				if (num != 0)
				{
				}
				num = (short)1496121344;
				if (num != 0)
				{
				}
				num = (short)921632768;
				short num3 = num;
				this.radioVIPGeneralShortPressTime.Visible = value;
			}
		}

		// Token: 0x17003E56 RID: 15958
		// (get) Token: 0x0600794B RID: 31051 RVA: 0x006E4A78 File Offset: 0x006E2C78
		// (set) Token: 0x0600794C RID: 31052 RVA: 0x006E4B2C File Offset: 0x006E2D2C
		public bool RadioVIPGeneralShortPressTime_Editable
		{
			get
			{
				short num = (short)1376976897;
				if (num != 0)
				{
				}
				num = (short)1717799013;
				short num2 = num;
				num = (short)903972965;
				switch (num2 == num)
				{
				}
				num = (short)1108606976;
				if (num != 0)
				{
				}
				num = (short)711458816;
				short num3 = num;
				return this.radioVIPGeneralShortPressTime.Editable;
			}
			set
			{
				short num = (short)897383799;
				short num2 = num;
				num = (short)1389231479;
				switch (num2 == num)
				{
				}
				num = (short)1097007104;
				if (num != 0)
				{
				}
				num = (short)83755009;
				if (num != 0)
				{
				}
				num = (short)1450377216;
				short num3 = num;
				this.radioVIPGeneralShortPressTime.Editable = value;
			}
		}

		// Token: 0x17003E57 RID: 15959
		// (get) Token: 0x0600794D RID: 31053 RVA: 0x006E4BE0 File Offset: 0x006E2DE0
		internal string RadioVIPGeneralShortPressTime_UILabel
		{
			get
			{
				short num = (short)1848520126;
				short num2 = num;
				num = (short)221326782;
				switch (num2 == num)
				{
				}
				num = (short)1697054720;
				if (num != 0)
				{
				}
				num = (short)700841985;
				if (num != 0)
				{
				}
				num = (short)171769856;
				short num3 = num;
				return this.radioVIPGeneralShortPressTime.UIName;
			}
		}

		// Token: 0x17003E58 RID: 15960
		// (get) Token: 0x0600794E RID: 31054 RVA: 0x006E4C90 File Offset: 0x006E2E90
		// (set) Token: 0x0600794F RID: 31055 RVA: 0x006E4D44 File Offset: 0x006E2F44
		internal bool RadioVIPGeneralShortPressTime_HiddenStatic
		{
			get
			{
				short num = (short)2100634781;
				short num2 = num;
				num = (short)926426269;
				switch (num2 == num)
				{
				}
				num = (short)1707671553;
				if (num != 0)
				{
				}
				num = (short)1694564352;
				if (num != 0)
				{
				}
				num = (short)354418688;
				short num3 = num;
				return this.radioVIPGeneralShortPressTime.HiddenStatic;
			}
			set
			{
				short num = (short)1360931340;
				short num2 = num;
				num = (short)2076781068;
				switch (num2 == num)
				{
				}
				num = (short)1315831809;
				if (num != 0)
				{
				}
				num = (short)1605697536;
				if (num != 0)
				{
				}
				num = (short)1064632320;
				short num3 = num;
				this.radioVIPGeneralShortPressTime.HiddenStatic = value;
			}
		}

		// Token: 0x17003E59 RID: 15961
		// (get) Token: 0x06007950 RID: 31056 RVA: 0x006E4DFC File Offset: 0x006E2FFC
		// (set) Token: 0x06007951 RID: 31057 RVA: 0x006E4EB0 File Offset: 0x006E30B0
		internal bool RadioVIPGeneralShortPressTime_HiddenDynamic
		{
			get
			{
				short num = (short)1119864072;
				short num2 = num;
				num = (short)445695240;
				switch (num2 == num)
				{
				}
				num = (short)1658322944;
				if (num != 0)
				{
				}
				num = (short)1103888385;
				if (num != 0)
				{
				}
				num = (short)970260480;
				short num3 = num;
				return this.radioVIPGeneralShortPressTime.HiddenDynamic;
			}
			set
			{
				short num = (short)528583770;
				short num2 = num;
				num = (short)2090044506;
				switch (num2 == num)
				{
				}
				num = (short)1926561793;
				if (num != 0)
				{
				}
				num = (short)354942976;
				if (num != 0)
				{
				}
				num = (short)138674176;
				short num3 = num;
				this.radioVIPGeneralShortPressTime.HiddenDynamic = value;
			}
		}

		// Token: 0x17003E5A RID: 15962
		// (get) Token: 0x06007952 RID: 31058 RVA: 0x006E4F64 File Offset: 0x006E3164
		public bool RadioVIPGeneralShortPressTime_HasDiffs
		{
			get
			{
				short num = (short)1123547340;
				short num2 = num;
				num = (short)1114372300;
				switch (num2 == num)
				{
				}
				num = (short)41091072;
				if (num != 0)
				{
				}
				num = (short)204472321;
				if (num != 0)
				{
				}
				num = (short)2107441152;
				short num3 = num;
				return this.radioVIPGeneralShortPressTime._HasDiffs;
			}
		}

		// Token: 0x17003E5B RID: 15963
		// (get) Token: 0x06007953 RID: 31059 RVA: 0x006E5018 File Offset: 0x006E3218
		// (set) Token: 0x06007954 RID: 31060 RVA: 0x006E50CC File Offset: 0x006E32CC
		public int RadioVIPGeneralLongPressTimeValue
		{
			get
			{
				short num = (short)2066538651;
				short num2 = num;
				num = (short)460578971;
				switch (num2 == num)
				{
				}
				num = (short)51380224;
				if (num != 0)
				{
				}
				num = (short)1018494977;
				if (num != 0)
				{
				}
				num = (short)1949761536;
				short num3 = num;
				return this.radioVIPGeneralLongPressTime.Value;
			}
			set
			{
				short num = (short)1846690491;
				short num2 = num;
				num = (short)273892027;
				switch (num2 == num)
				{
				}
				num = (short)1475018752;
				if (num != 0)
				{
				}
				num = (short)454819841;
				if (num != 0)
				{
				}
				num = (short)897712128;
				short num3 = num;
				this.radioVIPGeneralLongPressTime.Value = value;
			}
		}

		// Token: 0x17003E5C RID: 15964
		// (get) Token: 0x06007955 RID: 31061 RVA: 0x006E5180 File Offset: 0x006E3380
		// (set) Token: 0x06007956 RID: 31062 RVA: 0x006E5238 File Offset: 0x006E3438
		public string RadioVIPGeneralLongPressTime_UIValue
		{
			get
			{
				short num = (short)1364774891;
				short num2 = num;
				num = (short)442945515;
				switch (num2 == num)
				{
				}
				num = (short)1617821697;
				if (num != 0)
				{
				}
				num = (short)2028929024;
				if (num != 0)
				{
				}
				num = (short)1889796096;
				short num3 = num;
				return this.radioVIPGeneralLongPressTime.UIValue;
			}
			set
			{
				short num = (short)289079297;
				if (num != 0)
				{
				}
				num = (short)1451211907;
				short num2 = num;
				num = (short)1425849475;
				switch (num2 == num)
				{
				}
				num = (short)1762525184;
				if (num != 0)
				{
				}
				num = (short)1578696704;
				short num3 = num;
				this.radioVIPGeneralLongPressTime.UIValue = value;
			}
		}

		// Token: 0x17003E5D RID: 15965
		// (get) Token: 0x06007957 RID: 31063 RVA: 0x006E52EC File Offset: 0x006E34EC
		public global::AcpBusinessLayer.AcpCustomRangeField RadioVIPGeneralLongPressTime
		{
			get
			{
				short num = (short)680366950;
				short num2 = num;
				num = (short)2145162086;
				switch (num2 == num)
				{
				}
				num = (short)596639744;
				if (num != 0)
				{
				}
				num = (short)1271070721;
				if (num != 0)
				{
				}
				num = (short)1110966272;
				short num3 = num;
				return this.radioVIPGeneralLongPressTime;
			}
		}

		// Token: 0x17003E5E RID: 15966
		// (get) Token: 0x06007958 RID: 31064 RVA: 0x006E539C File Offset: 0x006E359C
		// (set) Token: 0x06007959 RID: 31065 RVA: 0x006E5450 File Offset: 0x006E3650
		public bool RadioVIPGeneralLongPressTime_Applicable
		{
			get
			{
				short num = (short)1910636545;
				if (num != 0)
				{
				}
				num = (short)1818338771;
				short num2 = num;
				num = (short)171156947;
				switch (num2 == num)
				{
				}
				num = (short)2022572032;
				if (num != 0)
				{
				}
				num = (short)1300889600;
				short num3 = num;
				return this.radioVIPGeneralLongPressTime.Applicable;
			}
			set
			{
				short num = (short)521469953;
				if (num != 0)
				{
				}
				num = (short)2109675687;
				short num2 = num;
				num = (short)1343363239;
				switch (num2 == num)
				{
				}
				num = (short)1386020864;
				if (num != 0)
				{
				}
				num = (short)740884480;
				short num3 = num;
				this.radioVIPGeneralLongPressTime.Applicable = value;
			}
		}

		// Token: 0x17003E5F RID: 15967
		// (get) Token: 0x0600795A RID: 31066 RVA: 0x006E5504 File Offset: 0x006E3704
		// (set) Token: 0x0600795B RID: 31067 RVA: 0x006E55BC File Offset: 0x006E37BC
		public bool RadioVIPGeneralLongPressTime_Valid
		{
			get
			{
				short num = (short)1042155743;
				short num2 = num;
				num = (short)960825567;
				switch (num2 == num)
				{
				}
				num = (short)829161473;
				if (num != 0)
				{
				}
				num = (short)1184104448;
				if (num != 0)
				{
				}
				num = (short)1512505344;
				short num3 = num;
				return this.radioVIPGeneralLongPressTime.Valid;
			}
			set
			{
				short num = (short)573882512;
				short num2 = num;
				num = (short)1654898832;
				switch (num2 == num)
				{
				}
				num = (short)1739390977;
				if (num != 0)
				{
				}
				num = (short)1922564096;
				if (num != 0)
				{
				}
				num = (short)1835401216;
				short num3 = num;
				this.radioVIPGeneralLongPressTime.Valid = value;
			}
		}

		// Token: 0x17003E60 RID: 15968
		// (get) Token: 0x0600795C RID: 31068 RVA: 0x006E5670 File Offset: 0x006E3870
		// (set) Token: 0x0600795D RID: 31069 RVA: 0x006E5724 File Offset: 0x006E3924
		public bool RadioVIPGeneralLongPressTime_Visible
		{
			get
			{
				short num = (short)54802247;
				short num2 = num;
				num = (short)81606471;
				switch (num2 == num)
				{
				}
				num = (short)1074462721;
				if (num != 0)
				{
				}
				num = (short)674365440;
				if (num != 0)
				{
				}
				num = (short)1568276480;
				short num3 = num;
				return this.radioVIPGeneralLongPressTime.Visible;
			}
			set
			{
				short num = (short)949791406;
				short num2 = num;
				num = (short)1006086830;
				switch (num2 == num)
				{
				}
				num = (short)2047410176;
				if (num != 0)
				{
				}
				num = (short)82051073;
				if (num != 0)
				{
				}
				num = (short)1657536512;
				short num3 = num;
				this.radioVIPGeneralLongPressTime.Visible = value;
			}
		}

		// Token: 0x17003E61 RID: 15969
		// (get) Token: 0x0600795E RID: 31070 RVA: 0x006E57D8 File Offset: 0x006E39D8
		// (set) Token: 0x0600795F RID: 31071 RVA: 0x006E588C File Offset: 0x006E3A8C
		public bool RadioVIPGeneralLongPressTime_Editable
		{
			get
			{
				short num = (short)1026706332;
				short num2 = num;
				num = (short)211897244;
				switch (num2 == num)
				{
				}
				num = (short)2007105537;
				if (num != 0)
				{
				}
				num = (short)212336640;
				if (num != 0)
				{
				}
				num = (short)84803584;
				short num3 = num;
				return this.radioVIPGeneralLongPressTime.Editable;
			}
			set
			{
				short num = (short)1446816411;
				short num2 = num;
				num = (short)886090395;
				switch (num2 == num)
				{
				}
				num = (short)1951399937;
				if (num != 0)
				{
				}
				num = (short)1882456064;
				if (num != 0)
				{
				}
				num = (short)2041184256;
				short num3 = num;
				this.radioVIPGeneralLongPressTime.Editable = value;
			}
		}

		// Token: 0x17003E62 RID: 15970
		// (get) Token: 0x06007960 RID: 31072 RVA: 0x006E5940 File Offset: 0x006E3B40
		internal string RadioVIPGeneralLongPressTime_UILabel
		{
			get
			{
				short num = (short)786766742;
				short num2 = num;
				num = (short)341973910;
				switch (num2 == num)
				{
				}
				num = (short)1206976513;
				if (num != 0)
				{
				}
				num = (short)1161494528;
				if (num != 0)
				{
				}
				num = (short)257622016;
				short num3 = num;
				return this.radioVIPGeneralLongPressTime.UIName;
			}
		}

		// Token: 0x17003E63 RID: 15971
		// (get) Token: 0x06007961 RID: 31073 RVA: 0x006E59F4 File Offset: 0x006E3BF4
		// (set) Token: 0x06007962 RID: 31074 RVA: 0x006E5AA8 File Offset: 0x006E3CA8
		internal bool RadioVIPGeneralLongPressTime_HiddenStatic
		{
			get
			{
				short num = (short)147681960;
				short num2 = num;
				num = (short)1965519528;
				switch (num2 == num)
				{
				}
				num = (short)556007425;
				if (num != 0)
				{
				}
				num = (short)1437597696;
				if (num != 0)
				{
				}
				num = (short)1299906560;
				short num3 = num;
				return this.radioVIPGeneralLongPressTime.HiddenStatic;
			}
			set
			{
				short num = (short)1944185114;
				short num2 = num;
				num = (short)1562241306;
				switch (num2 == num)
				{
				}
				num = (short)804978688;
				if (num != 0)
				{
				}
				num = (short)1447690241;
				if (num != 0)
				{
				}
				num = (short)1180762112;
				short num3 = num;
				this.radioVIPGeneralLongPressTime.HiddenStatic = value;
			}
		}

		// Token: 0x17003E64 RID: 15972
		// (get) Token: 0x06007963 RID: 31075 RVA: 0x006E5B5C File Offset: 0x006E3D5C
		// (set) Token: 0x06007964 RID: 31076 RVA: 0x006E5C14 File Offset: 0x006E3E14
		internal bool RadioVIPGeneralLongPressTime_HiddenDynamic
		{
			get
			{
				short num = (short)1068498944;
				short num2 = num;
				num = (short)1968412118;
				short num3 = num;
				num = (short)708285910;
				switch (num3 == num)
				{
				}
				num = (short)1547436032;
				if (num != 0)
				{
				}
				num = (short)479657985;
				if (num != 0)
				{
				}
				return this.radioVIPGeneralLongPressTime.HiddenDynamic;
			}
			set
			{
				short num = (short)1345585152;
				short num2 = num;
				num = (short)824250340;
				short num3 = num;
				num = (short)1007030244;
				switch (num3 == num)
				{
				}
				num = (short)282329089;
				if (num != 0)
				{
				}
				num = (short)325910528;
				if (num != 0)
				{
				}
				this.radioVIPGeneralLongPressTime.HiddenDynamic = value;
			}
		}

		// Token: 0x17003E65 RID: 15973
		// (get) Token: 0x06007965 RID: 31077 RVA: 0x006E5CC8 File Offset: 0x006E3EC8
		public bool RadioVIPGeneralLongPressTime_HasDiffs
		{
			get
			{
				short num = (short)2070413312;
				short num2 = num;
				num = (short)1093815154;
				short num3 = num;
				num = (short)1023101810;
				switch (num3 == num)
				{
				}
				num = (short)947060737;
				if (num != 0)
				{
				}
				num = (short)2016018432;
				if (num != 0)
				{
				}
				return this.radioVIPGeneralLongPressTime._HasDiffs;
			}
		}

		// Token: 0x17003E66 RID: 15974
		// (get) Token: 0x06007966 RID: 31078 RVA: 0x006E5D7C File Offset: 0x006E3F7C
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide RefRadioWide
		{
			get
			{
				short num = (short)1241710592;
				short num2 = num;
				num = (short)116517488;
				short num3 = num;
				num = (short)1851976304;
				switch (num3 == num)
				{
				}
				num = (short)1248919553;
				if (num != 0)
				{
				}
				num = (short)21037056;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
			}
		}

		// Token: 0x17003E67 RID: 15975
		// (get) Token: 0x06007967 RID: 31079 RVA: 0x006E5E38 File Offset: 0x006E4038
		public global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide RefRadioErgonomicsWide
		{
			get
			{
				short num = (short)586153984;
				short num2 = num;
				num = (short)1358499583;
				short num3 = num;
				num = (short)1177358079;
				switch (num3 == num)
				{
				}
				num = (short)949288961;
				if (num != 0)
				{
				}
				num = (short)1240662016;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2033)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide;
			}
		}

		// Token: 0x17003E68 RID: 15976
		// (get) Token: 0x06007968 RID: 31080 RVA: 0x006E5EF4 File Offset: 0x006E40F4
		public global::Motorola.MackinawCPS.CoreFeatures.DVRSWide.DVRSWide RefDVRSWide
		{
			get
			{
				short num = (short)927596544;
				short num2 = num;
				num = (short)404587128;
				short num3 = num;
				num = (short)23233144;
				switch (num3 == num)
				{
				}
				num = (short)1539178497;
				if (num != 0)
				{
				}
				num = (short)2034958336;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(4142)[0] as global::Motorola.MackinawCPS.CoreFeatures.DVRSWide.DVRSWide;
			}
		}

		// Token: 0x06007969 RID: 31081 RVA: 0x006E5FB4 File Offset: 0x006E41B4
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
					if (base.ParentRecset != null)
					{
						num2 = (short)2031812609;
						if (num2 != 0)
						{
						}
						num2 = (short)876347394;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 1:
				{
					num2 = (short)201064448;
					short num3 = num2;
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)2001338371;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					num2 = (short)214433796;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					return result;
				case 4:
				{
					if (base.ParentRecset.ContainerDoc == null)
					{
						return result;
					}
					num2 = (short)851200319;
					short num4 = num2;
					num2 = (short)2027440447;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)1344929792;
						if (num2 != 0)
						{
						}
						num2 = (short)1699938305;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_24;
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)471924736;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0400334F RID: 13135
		private global::AcpBusinessLayer.AcpListField gCAIVipInputBCO_42620;

		// Token: 0x04003350 RID: 13136
		private global::AcpBusinessLayer.AcpKeyField radioGCAIVIPKey_42621;

		// Token: 0x04003351 RID: 13137
		private global::AcpBusinessLayer.AcpField<string> radioGCAIVipName_42622;

		// Token: 0x04003352 RID: 13138
		private global::AcpBusinessLayer.AcpListField gCAIVipInputFeature_42623;

		// Token: 0x04003353 RID: 13139
		private global::AcpBusinessLayer.AcpSimpleRangeField radioVIPGeneralShortPressTime;

		// Token: 0x04003354 RID: 13140
		private global::AcpBusinessLayer.AcpCustomRangeField radioVIPGeneralLongPressTime;
	}
}
