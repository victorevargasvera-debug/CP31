using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList;

namespace Motorola.MackinawCPS.CoreFeatures.DataProfiles
{
	// Token: 0x0200050C RID: 1292
	[global::System.Serializable]
	public class EnhancedData : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600AAE5 RID: 43749 RVA: 0x009F610C File Offset: 0x009F430C
		public EnhancedData(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x0600AAE6 RID: 43750 RVA: 0x009F6128 File Offset: 0x009F4328
		protected EnhancedData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600AAE7 RID: 43751 RVA: 0x009F6140 File Offset: 0x009F4340
		public override void Init()
		{
			int a_ = 16;
			short num = (short)390751664;
			short num2 = num;
			num = (short)29910448;
			switch (num2 == num)
			{
			}
			num = (short)536150017;
			if (num != 0)
			{
			}
			num = (short)325779456;
			short num3 = num;
			num = (short)668729344;
			if (num != 0)
			{
			}
			this.datProFeaturesPortListSelection_A42011 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("闐닒ꇔ蟖ꯘ듚鯜뫞胠韢郤闦賨飪뷬胮菰蟲맴黶諸迺껼髾洀昂昄猆怈搊挌倎倐✒✔✖⠘⨚", a_), global::CommonResources.AcgResources.ID_PORTLISTSELECTION, new string[]
			{
				global::CommonResources.AcgResources.ID_DISABLED
			}, new int[1], true, false);
			this.datProFeaturesPortListSelection_A42011.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.datProFeaturesPortListSelection_A42011.DataTransferOrder = 50;
			this.datProFeaturesPortListSelection_A42011.EvaluateRecRefs = true;
			this.allowEnhancedDataToBeSentOnClassicDataChannel_42014 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("郐뿒맔룖께黚돜럞胠跢蛤苦跨꿪賬鯮郰ꟲ髴뗶鳸꣺飼釾甀䰂欄䐆攈樊縌簎砐瀒儔瘖洘稚帜眞䀠䴢䬤䈦䔨琪᤬ᴮİȲĴ", a_), global::CommonResources.AcgResources.ID_ALLOWENHANCEDDATAONCLASSICDATACHANNEL);
			this.allowEnhancedDataToBeSentOnClassicDataChannel_42014.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.allowEnhancedDataToBeSentOnClassicDataChannel_42014.DataTransferOrder = 51;
			this.queueDwellTimerSec_42015 = new global::AcpBusinessLayer.AcpSimpleRangeField(15, this, global::AllFeatures.CodeplugGuid.b("胐ꛒ냔ꋖ볘鿚ꫜ뫞跠迢뇤軦蓨軪鿬볮铰郲ꫴ쏶쯸쯺쳼쫾", a_), global::CommonResources.AcgResources.ID_ENHANCEDDATAQUEUEDWELLTIMERSEC, 5, 120, null, null, 0, 1);
			this.queueDwellTimerSec_42015.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.queueDwellTimerSec_42015.DataTransferOrder = 52;
			this.queueDwellTimerSec_42015.ShowHexValue = false;
			this.datProSendDataDurEmerHangtime_A43103 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("闐닒ꇔ蟖ꯘ듚軜뫞迠蟢ꇤ蛦鷨諪ꧬ髮菰뛲飴鋶诸돺鳼釾昀眂氄樆氈吊䰌㬎∐−└␖", a_), global::CommonResources.AcgResources.ID_SENDDATADURINGEMERGENCYHANGTIME);
			this.datProSendDataDurEmerHangtime_A43103.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.datProSendDataDurEmerHangtime_A43103.DataTransferOrder = 76;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("铐뷒뷔뛖럘룚룜믞쇠꟢蓤鏦裨", a_);
			base.Id = 10770;
			base.UIName = global::CommonResources.AcgResources.ID_ENHANCEDDATA;
			base.DataTransferOrder = 8;
		}

		// Token: 0x0600AAE8 RID: 43752 RVA: 0x009F6340 File Offset: 0x009F4540
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 9;
			short num = (short)304087053;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_334;
				case 1:
				{
					num = (short)972675697;
					short num3 = num;
					num = (short)318757489;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_131;
					default:
						num = (short)1886846976;
						if (num != 0)
						{
						}
						this.datProFeaturesPortListSelection_A42011 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("軉귋뫍胏ꃑ믓郕뷗믙꣛ꯝ鋟蟡韣뛥蟧飩飫ꋭ駯臱胳ꗵ鷷雹駻鷽瓿欁欃栅圇䬉㠋㰍‏⌑┓", a_), global::CommonResources.AcgResources.ID_PORTLISTSELECTION, new string[]
						{
							global::CommonResources.AcgResources.ID_DISABLED
						}, new int[1], true, false);
						this.datProFeaturesPortListSelection_A42011.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
						this.datProFeaturesPortListSelection_A42011.DataTransferOrder = 50;
						this.datProFeaturesPortListSelection_A42011.EvaluateRecRefs = true;
						num = (short)1060896768;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鯉맋ꯍꗏ럑郓ꇕ뷗뛙냛諝觟迡臣铥믧迩迫뇭쓯샱쓳쟵췷", a_)))
					{
						num = (short)897974283;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1E4;
				case 3:
					num = (short)1569914881;
					if (num != 0)
					{
					}
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("軉귋뫍胏ꃑ믓藕뷗듙룛髝臟雡藣ꋥ鷧飩ꧫ菭闯胱볳韵雷鷹裻韽淿朁嬃䜅㰇㤉㴋㸍⌏", a_)))
					{
						num = (short)1973616649;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_422;
				case 4:
					num = (short)1272184846;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_32F;
				case 6:
					goto IL_292;
				case 7:
					num = (short)150601738;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					goto IL_1E4;
				case 9:
					this.datProSendDataDurEmerHangtime_A43103 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("軉귋뫍胏ꃑ믓藕뷗듙룛髝臟雡藣ꋥ鷧飩ꧫ菭闯胱볳韵雷鷹裻韽淿朁嬃䜅㰇㤉㴋㸍⌏", a_), global::CommonResources.AcgResources.ID_SENDDATADURINGEMERGENCYHANGTIME);
					this.datProSendDataDurEmerHangtime_A43103.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.datProSendDataDurEmerHangtime_A43103.DataTransferOrder = 76;
					num = (short)258277381;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					if (producerFields != null)
					{
						num = (short)941031428;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_422;
				case 11:
					this.queueDwellTimerSec_42015 = new global::AcpBusinessLayer.AcpSimpleRangeField(15, this, global::AllFeatures.CodeplugGuid.b("鯉맋ꯍꗏ럑郓ꇕ뷗뛙냛諝觟迡臣铥믧迩迫뇭쓯샱쓳쟵췷", a_), global::CommonResources.AcgResources.ID_ENHANCEDDATAQUEUEDWELLTIMERSEC, null, null, 0, 1);
					this.queueDwellTimerSec_42015.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.queueDwellTimerSec_42015.DataTransferOrder = 52;
					this.queueDwellTimerSec_42015.ShowHexValue = false;
					num = (short)1729232904;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("诉ꃋꋍ뿏ꗑ釓룕냗믙닛뷝藟蛡ꃣ蟥鳧诩룫臭닯韱ꟳ鏵雷軹돻都䏿渁攃甅笇按漋䨍焏昑甓唕瀗笙爛瀝䔟両笣ሥᨧᨩᴫᨭ", a_)))
					{
						num = (short)879362063;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_292;
				case 13:
					switch (0)
					{
					case 0:
						goto IL_6D;
					}
					continue;
				case 14:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("軉귋뫍胏ꃑ믓郕뷗믙꣛ꯝ鋟蟡韣뛥蟧飩飫ꋭ駯臱胳ꗵ鷷雹駻鷽瓿欁欃栅圇䬉㠋㰍‏⌑┓", a_)))
					{
						num = (short)724238337;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_334;
				case 15:
					this.allowEnhancedDataToBeSentOnClassicDataChannel_42014 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("诉ꃋꋍ뿏ꗑ釓룕냗믙닛뷝藟蛡ꃣ蟥鳧诩룫臭닯韱ꟳ鏵雷軹돻都䏿渁攃甅笇按漋䨍焏昑甓唕瀗笙爛瀝䔟両笣ሥᨧᨩᴫᨭ", a_), global::CommonResources.AcgResources.ID_ALLOWENHANCEDDATAONCLASSICDATACHANNEL);
					this.allowEnhancedDataToBeSentOnClassicDataChannel_42014.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.allowEnhancedDataToBeSentOnClassicDataChannel_42014.DataTransferOrder = 51;
					goto IL_131;
				}
				IL_6D:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)742588423;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_131:
				num = (short)105906182;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1E4:
				num = (short)11337731;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_292:
				num = (short)280297474;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_334:
				num = (short)527040512;
				short num4 = num;
				num = (short)34340876;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_32F:
			IL_422:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("迉ꋋꛍ뇏병럓돕볗龎飛뿝铟菡", a_);
			base.Id = 10770;
			base.UIName = global::CommonResources.AcgResources.ID_ENHANCEDDATA;
			base.DataTransferOrder = 8;
		}

		// Token: 0x0600AAE9 RID: 43753 RVA: 0x009F67A0 File Offset: 0x009F49A0
		public override void PopulateReferences()
		{
			short num = (short)592490454;
			short num2 = num;
			num = (short)1447866326;
			switch (num2 == num)
			{
			}
			num = (short)199163905;
			if (num != 0)
			{
			}
			num = (short)1534918656;
			short num3 = num;
			num = (short)1352597504;
			if (num != 0)
			{
			}
			this.datProFeaturesPortListSelection_A42011.SetRecset(this.a(4148));
		}

		// Token: 0x0600AAEA RID: 43754 RVA: 0x009F6860 File Offset: 0x009F4A60
		public override void DropReferences()
		{
			short num = (short)1529450097;
			short num2 = num;
			num = (short)1622052465;
			switch (num2 == num)
			{
			}
			num = (short)707788801;
			if (num != 0)
			{
			}
			num = (short)81526784;
			short num3 = num;
			num = (short)884342784;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600AAEB RID: 43755 RVA: 0x009F6908 File Offset: 0x009F4B08
		public override void SetConstraints()
		{
			short num = (short)380848899;
			short num2 = num;
			num = (short)897338115;
			switch (num2 == num)
			{
			}
			num = (short)1583808512;
			if (num != 0)
			{
			}
			num = (short)529006592;
			short num3 = num;
			num = (short)82247681;
			if (num != 0)
			{
			}
			this.datProFeaturesPortListSelection_A42011.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.conTrkSysTypeIsTrunking);
			this.allowEnhancedDataToBeSentOnClassicDataChannel_42014.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.conEnhancedDataApplicable);
			this.queueDwellTimerSec_42015.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.conEnhancedDataApplicable);
			this.datProSendDataDurEmerHangtime_A43103.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.conSendDataDurEmerHangtimeIsApplicable);
			this.datProSendDataDurEmerHangtime_A43103.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.conSendDataDurEmerHangtimeIsVisible);
		}

		// Token: 0x0600AAEC RID: 43756 RVA: 0x009F6A24 File Offset: 0x009F4C24
		public override void SetupDependencies()
		{
			short num = (short)1670963429;
			short num2 = num;
			num = (short)433709285;
			switch (num2 == num)
			{
			}
			num = (short)1529217024;
			if (num != 0)
			{
			}
			num = (short)317521920;
			short num3 = num;
			num = (short)1470562305;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles = base.Parent as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles;
			dataProfiles.General.DataProfGeneralDataProfileType_A21320.AddDependentObject(this.datProFeaturesPortListSelection_A42011);
			dataProfiles.General.DataProfGeneralDataProfileType_A21320.AddDependentObject(this.allowEnhancedDataToBeSentOnClassicDataChannel_42014);
			this.datProFeaturesPortListSelection_A42011.AddDependentObject(this.allowEnhancedDataToBeSentOnClassicDataChannel_42014);
			dataProfiles.General.DataProfGeneralDataProfileType_A21320.AddDependentObject(this.queueDwellTimerSec_42015);
			this.datProFeaturesPortListSelection_A42011.AddDependentObject(this.queueDwellTimerSec_42015);
			dataProfiles.General.DataProfGeneralDataProfileType_A21320.AddDependentObject(this.datProSendDataDurEmerHangtime_A43103);
			this.datProFeaturesPortListSelection_A42011.AddDependentObject(this.datProSendDataDurEmerHangtime_A43103);
		}

		// Token: 0x17005584 RID: 21892
		// (get) Token: 0x0600AAED RID: 43757 RVA: 0x009F6B6C File Offset: 0x009F4D6C
		public global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortList EnhancedDataPortListForDatProFeaturesPortListSelection_A42011
		{
			get
			{
				short num = (short)716136893;
				short num2 = num;
				num = (short)737305021;
				switch (num2 == num)
				{
				}
				num = (short)358809601;
				if (num != 0)
				{
				}
				num = (short)1369702400;
				short num3 = num;
				num = (short)1349779456;
				if (num != 0)
				{
				}
				return this.datProFeaturesPortListSelection_A42011.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortList;
			}
		}

		// Token: 0x17005585 RID: 21893
		// (get) Token: 0x0600AAEE RID: 43758 RVA: 0x009F6C24 File Offset: 0x009F4E24
		public bool HasDiffs
		{
			get
			{
				short num = (short)427151649;
				short num2 = num;
				num = (short)362205473;
				switch (num2 == num)
				{
				}
				num = (short)1767636992;
				if (num != 0)
				{
				}
				num = (short)1712914432;
				short num3 = num;
				num = (short)2022965249;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17005586 RID: 21894
		// (get) Token: 0x0600AAEF RID: 43759 RVA: 0x009F6CD4 File Offset: 0x009F4ED4
		// (set) Token: 0x0600AAF0 RID: 43760 RVA: 0x009F6D88 File Offset: 0x009F4F88
		public int DatProFeaturesPortListSelection_A42011Value
		{
			get
			{
				short num = (short)1133551679;
				short num2 = num;
				num = (short)1890951231;
				switch (num2 == num)
				{
				}
				num = (short)485359617;
				if (num != 0)
				{
				}
				num = (short)1884028928;
				short num3 = num;
				num = (short)2063007744;
				if (num != 0)
				{
				}
				return this.datProFeaturesPortListSelection_A42011.Value;
			}
			set
			{
				short num = (short)1595223143;
				short num2 = num;
				num = (short)2080779367;
				switch (num2 == num)
				{
				}
				num = (short)1819541505;
				if (num != 0)
				{
				}
				num = (short)974323712;
				short num3 = num;
				num = (short)637730816;
				if (num != 0)
				{
				}
				this.datProFeaturesPortListSelection_A42011.Value = value;
			}
		}

		// Token: 0x17005587 RID: 21895
		// (get) Token: 0x0600AAF1 RID: 43761 RVA: 0x009F6E3C File Offset: 0x009F503C
		// (set) Token: 0x0600AAF2 RID: 43762 RVA: 0x009F6EF0 File Offset: 0x009F50F0
		public string DatProFeaturesPortListSelection_A42011_UIValue
		{
			get
			{
				short num = (short)1835572919;
				short num2 = num;
				num = (short)1466998455;
				switch (num2 == num)
				{
				}
				num = (short)676331521;
				if (num != 0)
				{
				}
				num = (short)419430400;
				if (num != 0)
				{
				}
				num = (short)825425920;
				short num3 = num;
				return this.datProFeaturesPortListSelection_A42011.UIValue;
			}
			set
			{
				short num = (short)1880204006;
				short num2 = num;
				num = (short)483959526;
				switch (num2 == num)
				{
				}
				num = (short)696844289;
				if (num != 0)
				{
				}
				num = (short)1167785984;
				if (num != 0)
				{
				}
				num = (short)1285292032;
				short num3 = num;
				this.datProFeaturesPortListSelection_A42011.UIValue = value;
			}
		}

		// Token: 0x17005588 RID: 21896
		// (get) Token: 0x0600AAF3 RID: 43763 RVA: 0x009F6FA8 File Offset: 0x009F51A8
		public global::AcpBusinessLayer.AcpRecRefField DatProFeaturesPortListSelection_A42011
		{
			get
			{
				short num = (short)534079055;
				short num2 = num;
				num = (short)22963791;
				switch (num2 == num)
				{
				}
				num = (short)706281472;
				if (num != 0)
				{
				}
				num = (short)1412628481;
				if (num != 0)
				{
				}
				num = (short)266797056;
				short num3 = num;
				return this.datProFeaturesPortListSelection_A42011;
			}
		}

		// Token: 0x17005589 RID: 21897
		// (get) Token: 0x0600AAF4 RID: 43764 RVA: 0x009F7058 File Offset: 0x009F5258
		// (set) Token: 0x0600AAF5 RID: 43765 RVA: 0x009F710C File Offset: 0x009F530C
		public bool DatProFeaturesPortListSelection_A42011_Applicable
		{
			get
			{
				short num = (short)1805013472;
				short num2 = num;
				num = (short)702894560;
				switch (num2 == num)
				{
				}
				num = (short)1514405888;
				if (num != 0)
				{
				}
				num = (short)1969029121;
				if (num != 0)
				{
				}
				num = (short)1476263936;
				short num3 = num;
				return this.datProFeaturesPortListSelection_A42011.Applicable;
			}
			set
			{
				short num = (short)1574005491;
				short num2 = num;
				num = (short)1484679923;
				switch (num2 == num)
				{
				}
				num = (short)249167873;
				if (num != 0)
				{
				}
				num = (short)1376256000;
				if (num != 0)
				{
				}
				num = (short)1880621056;
				short num3 = num;
				this.datProFeaturesPortListSelection_A42011.Applicable = value;
			}
		}

		// Token: 0x1700558A RID: 21898
		// (get) Token: 0x0600AAF6 RID: 43766 RVA: 0x009F71C0 File Offset: 0x009F53C0
		// (set) Token: 0x0600AAF7 RID: 43767 RVA: 0x009F7274 File Offset: 0x009F5474
		public bool DatProFeaturesPortListSelection_A42011_Valid
		{
			get
			{
				short num = (short)972322042;
				short num2 = num;
				num = (short)891450618;
				switch (num2 == num)
				{
				}
				num = (short)1565065217;
				if (num != 0)
				{
				}
				num = (short)306905088;
				if (num != 0)
				{
				}
				num = (short)238944256;
				short num3 = num;
				return this.datProFeaturesPortListSelection_A42011.Valid;
			}
			set
			{
				short num = (short)824967169;
				if (num != 0)
				{
				}
				num = (short)339345735;
				short num2 = num;
				num = (short)881328455;
				switch (num2 == num)
				{
				}
				num = (short)804978688;
				if (num != 0)
				{
				}
				num = (short)136708096;
				short num3 = num;
				this.datProFeaturesPortListSelection_A42011.Valid = value;
			}
		}

		// Token: 0x1700558B RID: 21899
		// (get) Token: 0x0600AAF8 RID: 43768 RVA: 0x009F732C File Offset: 0x009F552C
		// (set) Token: 0x0600AAF9 RID: 43769 RVA: 0x009F73E0 File Offset: 0x009F55E0
		public bool DatProFeaturesPortListSelection_A42011_Visible
		{
			get
			{
				short num = (short)1016622280;
				short num2 = num;
				num = (short)973696200;
				switch (num2 == num)
				{
				}
				num = (short)1018363905;
				if (num != 0)
				{
				}
				num = (short)1929052160;
				if (num != 0)
				{
				}
				num = (short)126156800;
				short num3 = num;
				return this.datProFeaturesPortListSelection_A42011.Visible;
			}
			set
			{
				short num = (short)1801348231;
				short num2 = num;
				num = (short)2009556103;
				switch (num2 == num)
				{
				}
				num = (short)668336128;
				if (num != 0)
				{
				}
				num = (short)708247553;
				if (num != 0)
				{
				}
				num = (short)1973616640;
				short num3 = num;
				this.datProFeaturesPortListSelection_A42011.Visible = value;
			}
		}

		// Token: 0x1700558C RID: 21900
		// (get) Token: 0x0600AAFA RID: 43770 RVA: 0x009F7494 File Offset: 0x009F5694
		// (set) Token: 0x0600AAFB RID: 43771 RVA: 0x009F7548 File Offset: 0x009F5748
		public bool DatProFeaturesPortListSelection_A42011_Editable
		{
			get
			{
				short num = (short)855265414;
				short num2 = num;
				num = (short)1331843206;
				switch (num2 == num)
				{
				}
				num = (short)778502145;
				if (num != 0)
				{
				}
				num = (short)1224671232;
				if (num != 0)
				{
				}
				num = (short)1683619840;
				short num3 = num;
				return this.datProFeaturesPortListSelection_A42011.Editable;
			}
			set
			{
				short num = (short)377014309;
				short num2 = num;
				num = (short)1023658021;
				switch (num2 == num)
				{
				}
				num = (short)828964864;
				if (num != 0)
				{
				}
				num = (short)15007745;
				if (num != 0)
				{
				}
				num = (short)1559691264;
				short num3 = num;
				this.datProFeaturesPortListSelection_A42011.Editable = value;
			}
		}

		// Token: 0x1700558D RID: 21901
		// (get) Token: 0x0600AAFC RID: 43772 RVA: 0x009F75F8 File Offset: 0x009F57F8
		internal string DatProFeaturesPortListSelection_A42011_UILabel
		{
			get
			{
				short num = (short)2082117575;
				short num2 = num;
				num = (short)922523591;
				switch (num2 == num)
				{
				}
				num = (short)1095565313;
				if (num != 0)
				{
				}
				num = (short)1565720576;
				if (num != 0)
				{
				}
				num = (short)1473642496;
				short num3 = num;
				return this.datProFeaturesPortListSelection_A42011.UIName;
			}
		}

		// Token: 0x1700558E RID: 21902
		// (get) Token: 0x0600AAFD RID: 43773 RVA: 0x009F76AC File Offset: 0x009F58AC
		// (set) Token: 0x0600AAFE RID: 43774 RVA: 0x009F775C File Offset: 0x009F595C
		internal bool DatProFeaturesPortListSelection_A42011_HiddenStatic
		{
			get
			{
				short num = (short)1545433857;
				short num2 = num;
				num = (short)538080001;
				switch (num2 == num)
				{
				}
				num = (short)850657280;
				if (num != 0)
				{
				}
				num = (short)1440743425;
				if (num != 0)
				{
				}
				num = (short)911147008;
				short num3 = num;
				return this.datProFeaturesPortListSelection_A42011.HiddenStatic;
			}
			set
			{
				short num = (short)1192822399;
				short num2 = num;
				num = (short)1776027263;
				switch (num2 == num)
				{
				}
				num = (short)935002113;
				if (num != 0)
				{
				}
				num = (short)232849408;
				if (num != 0)
				{
				}
				num = (short)681246720;
				short num3 = num;
				this.datProFeaturesPortListSelection_A42011.HiddenStatic = value;
			}
		}

		// Token: 0x1700558F RID: 21903
		// (get) Token: 0x0600AAFF RID: 43775 RVA: 0x009F7814 File Offset: 0x009F5A14
		// (set) Token: 0x0600AB00 RID: 43776 RVA: 0x009F78C8 File Offset: 0x009F5AC8
		internal bool DatProFeaturesPortListSelection_A42011_HiddenDynamic
		{
			get
			{
				short num = (short)790565502;
				short num2 = num;
				num = (short)608768638;
				switch (num2 == num)
				{
				}
				num = (short)208142337;
				if (num != 0)
				{
				}
				num = (short)1961295872;
				if (num != 0)
				{
				}
				num = (short)1796014080;
				short num3 = num;
				return this.datProFeaturesPortListSelection_A42011.HiddenDynamic;
			}
			set
			{
				short num = (short)712528553;
				short num2 = num;
				num = (short)1407341225;
				switch (num2 == num)
				{
				}
				num = (short)2045968385;
				if (num != 0)
				{
				}
				num = (short)878247936;
				if (num != 0)
				{
				}
				num = (short)82837504;
				short num3 = num;
				this.datProFeaturesPortListSelection_A42011.HiddenDynamic = value;
			}
		}

		// Token: 0x17005590 RID: 21904
		// (get) Token: 0x0600AB01 RID: 43777 RVA: 0x009F7980 File Offset: 0x009F5B80
		public bool DatProFeaturesPortListSelection_A42011_HasDiffs
		{
			get
			{
				short num = (short)1625836848;
				short num2 = num;
				num = (short)28462384;
				switch (num2 == num)
				{
				}
				num = (short)2021916673;
				if (num != 0)
				{
				}
				num = (short)1579614208;
				if (num != 0)
				{
				}
				num = (short)1564082176;
				short num3 = num;
				return this.datProFeaturesPortListSelection_A42011._HasDiffs;
			}
		}

		// Token: 0x17005591 RID: 21905
		// (get) Token: 0x0600AB02 RID: 43778 RVA: 0x009F7A34 File Offset: 0x009F5C34
		// (set) Token: 0x0600AB03 RID: 43779 RVA: 0x009F7AEC File Offset: 0x009F5CEC
		public bool AllowEnhancedDataToBeSentOnClassicDataChannel_42014Value
		{
			get
			{
				short num = (short)1506607105;
				if (num != 0)
				{
				}
				num = (short)2091595655;
				short num2 = num;
				num = (short)1059927943;
				switch (num2 == num)
				{
				}
				num = (short)777388032;
				if (num != 0)
				{
				}
				num = (short)1792540672;
				short num3 = num;
				return this.allowEnhancedDataToBeSentOnClassicDataChannel_42014.Value;
			}
			set
			{
				short num = (short)2052271038;
				short num2 = num;
				num = (short)1952852926;
				switch (num2 == num)
				{
				}
				num = (short)339148801;
				if (num != 0)
				{
				}
				num = (short)731119616;
				if (num != 0)
				{
				}
				num = (short)1858011136;
				short num3 = num;
				this.allowEnhancedDataToBeSentOnClassicDataChannel_42014.Value = value;
			}
		}

		// Token: 0x17005592 RID: 21906
		// (get) Token: 0x0600AB04 RID: 43780 RVA: 0x009F7BA0 File Offset: 0x009F5DA0
		public global::AcpBusinessLayer.AcpField<bool> AllowEnhancedDataToBeSentOnClassicDataChannel_42014
		{
			get
			{
				short num = (short)1264662486;
				short num2 = num;
				num = (short)956381142;
				switch (num2 == num)
				{
				}
				num = (short)530448385;
				if (num != 0)
				{
				}
				num = (short)1580531712;
				if (num != 0)
				{
				}
				num = (short)847904768;
				short num3 = num;
				return this.allowEnhancedDataToBeSentOnClassicDataChannel_42014;
			}
		}

		// Token: 0x17005593 RID: 21907
		// (get) Token: 0x0600AB05 RID: 43781 RVA: 0x009F7C50 File Offset: 0x009F5E50
		// (set) Token: 0x0600AB06 RID: 43782 RVA: 0x009F7D08 File Offset: 0x009F5F08
		public bool AllowEnhancedDataToBeSentOnClassicDataChannel_42014_UIValue
		{
			get
			{
				short num = (short)128798644;
				short num2 = num;
				num = (short)108154804;
				switch (num2 == num)
				{
				}
				num = (short)41615361;
				if (num != 0)
				{
				}
				num = (short)1645215744;
				if (num != 0)
				{
				}
				num = (short)873332736;
				short num3 = num;
				return this.allowEnhancedDataToBeSentOnClassicDataChannel_42014.Value;
			}
			set
			{
				short num = (short)580254033;
				short num2 = num;
				num = (short)1030289745;
				switch (num2 == num)
				{
				}
				num = (short)367788032;
				if (num != 0)
				{
				}
				num = (short)982843393;
				if (num != 0)
				{
				}
				num = (short)1468268544;
				short num3 = num;
				this.allowEnhancedDataToBeSentOnClassicDataChannel_42014.Value = value;
			}
		}

		// Token: 0x17005594 RID: 21908
		// (get) Token: 0x0600AB07 RID: 43783 RVA: 0x009F7DC0 File Offset: 0x009F5FC0
		// (set) Token: 0x0600AB08 RID: 43784 RVA: 0x009F7E74 File Offset: 0x009F6074
		public bool AllowEnhancedDataToBeSentOnClassicDataChannel_42014_Applicable
		{
			get
			{
				short num = (short)2038344784;
				short num2 = num;
				num = (short)870362192;
				switch (num2 == num)
				{
				}
				num = (short)452395008;
				if (num != 0)
				{
				}
				num = (short)2021785601;
				if (num != 0)
				{
				}
				num = (short)1361379328;
				short num3 = num;
				return this.allowEnhancedDataToBeSentOnClassicDataChannel_42014.Applicable;
			}
			set
			{
				short num = (short)888898407;
				short num2 = num;
				num = (short)785679207;
				switch (num2 == num)
				{
				}
				num = (short)2084306944;
				if (num != 0)
				{
				}
				num = (short)1878458369;
				if (num != 0)
				{
				}
				num = (short)1745092608;
				short num3 = num;
				this.allowEnhancedDataToBeSentOnClassicDataChannel_42014.Applicable = value;
			}
		}

		// Token: 0x17005595 RID: 21909
		// (get) Token: 0x0600AB09 RID: 43785 RVA: 0x009F7F2C File Offset: 0x009F612C
		// (set) Token: 0x0600AB0A RID: 43786 RVA: 0x009F7FE4 File Offset: 0x009F61E4
		public bool AllowEnhancedDataToBeSentOnClassicDataChannel_42014_Valid
		{
			get
			{
				short num = (short)1661665281;
				if (num != 0)
				{
				}
				num = (short)1209739904;
				short num2 = num;
				num = (short)1972775552;
				switch (num2 == num)
				{
				}
				num = (short)602406912;
				if (num != 0)
				{
				}
				num = (short)637599744;
				short num3 = num;
				return this.allowEnhancedDataToBeSentOnClassicDataChannel_42014.Valid;
			}
			set
			{
				short num = (short)558690874;
				short num2 = num;
				num = (short)392426042;
				switch (num2 == num)
				{
				}
				num = (short)354025473;
				if (num != 0)
				{
				}
				num = (short)1607598080;
				if (num != 0)
				{
				}
				num = (short)417792000;
				short num3 = num;
				this.allowEnhancedDataToBeSentOnClassicDataChannel_42014.Valid = value;
			}
		}

		// Token: 0x17005596 RID: 21910
		// (get) Token: 0x0600AB0B RID: 43787 RVA: 0x009F8098 File Offset: 0x009F6298
		// (set) Token: 0x0600AB0C RID: 43788 RVA: 0x009F8150 File Offset: 0x009F6350
		public bool AllowEnhancedDataToBeSentOnClassicDataChannel_42014_Visible
		{
			get
			{
				short num = (short)379439294;
				short num2 = num;
				num = (short)1453902014;
				switch (num2 == num)
				{
				}
				num = (short)872611840;
				if (num != 0)
				{
				}
				num = (short)1114046465;
				if (num != 0)
				{
				}
				num = (short)1369243648;
				short num3 = num;
				return this.allowEnhancedDataToBeSentOnClassicDataChannel_42014.Visible;
			}
			set
			{
				short num = (short)649112465;
				short num2 = num;
				num = (short)2033494929;
				switch (num2 == num)
				{
				}
				num = (short)596967424;
				if (num != 0)
				{
				}
				num = (short)1107689473;
				if (num != 0)
				{
				}
				num = (short)691404800;
				short num3 = num;
				this.allowEnhancedDataToBeSentOnClassicDataChannel_42014.Visible = value;
			}
		}

		// Token: 0x17005597 RID: 21911
		// (get) Token: 0x0600AB0D RID: 43789 RVA: 0x009F8208 File Offset: 0x009F6408
		// (set) Token: 0x0600AB0E RID: 43790 RVA: 0x009F82BC File Offset: 0x009F64BC
		public bool AllowEnhancedDataToBeSentOnClassicDataChannel_42014_Editable
		{
			get
			{
				short num = (short)1561619863;
				short num2 = num;
				num = (short)1825271191;
				switch (num2 == num)
				{
				}
				num = (short)617414657;
				if (num != 0)
				{
				}
				num = (short)150667264;
				if (num != 0)
				{
				}
				num = (short)1217527808;
				short num3 = num;
				return this.allowEnhancedDataToBeSentOnClassicDataChannel_42014.Editable;
			}
			set
			{
				short num = (short)395683171;
				short num2 = num;
				num = (short)637183331;
				switch (num2 == num)
				{
				}
				num = (short)455147521;
				if (num != 0)
				{
				}
				num = (short)610664448;
				if (num != 0)
				{
				}
				num = (short)609157120;
				short num3 = num;
				this.allowEnhancedDataToBeSentOnClassicDataChannel_42014.Editable = value;
			}
		}

		// Token: 0x17005598 RID: 21912
		// (get) Token: 0x0600AB0F RID: 43791 RVA: 0x009F8370 File Offset: 0x009F6570
		internal string AllowEnhancedDataToBeSentOnClassicDataChannel_42014_UILabel
		{
			get
			{
				short num = (short)336950212;
				short num2 = num;
				num = (short)755725252;
				switch (num2 == num)
				{
				}
				num = (short)791871489;
				if (num != 0)
				{
				}
				num = (short)1480851456;
				if (num != 0)
				{
				}
				num = (short)841089024;
				short num3 = num;
				return this.allowEnhancedDataToBeSentOnClassicDataChannel_42014.UIName;
			}
		}

		// Token: 0x17005599 RID: 21913
		// (get) Token: 0x0600AB10 RID: 43792 RVA: 0x009F8420 File Offset: 0x009F6620
		// (set) Token: 0x0600AB11 RID: 43793 RVA: 0x009F84D4 File Offset: 0x009F66D4
		internal bool AllowEnhancedDataToBeSentOnClassicDataChannel_42014_HiddenStatic
		{
			get
			{
				short num = (short)1059061761;
				if (num != 0)
				{
				}
				num = (short)326444406;
				short num2 = num;
				num = (short)375989622;
				switch (num2 == num)
				{
				}
				num = (short)1678704640;
				if (num != 0)
				{
				}
				num = (short)786169856;
				short num3 = num;
				return this.allowEnhancedDataToBeSentOnClassicDataChannel_42014.HiddenStatic;
			}
			set
			{
				short num = (short)161094454;
				short num2 = num;
				num = (short)1481513782;
				switch (num2 == num)
				{
				}
				num = (short)299237377;
				if (num != 0)
				{
				}
				num = (short)80216064;
				if (num != 0)
				{
				}
				num = (short)878837760;
				short num3 = num;
				this.allowEnhancedDataToBeSentOnClassicDataChannel_42014.HiddenStatic = value;
			}
		}

		// Token: 0x1700559A RID: 21914
		// (get) Token: 0x0600AB12 RID: 43794 RVA: 0x009F8588 File Offset: 0x009F6788
		// (set) Token: 0x0600AB13 RID: 43795 RVA: 0x009F863C File Offset: 0x009F683C
		internal bool AllowEnhancedDataToBeSentOnClassicDataChannel_42014_HiddenDynamic
		{
			get
			{
				short num = (short)520417145;
				short num2 = num;
				num = (short)1319300985;
				switch (num2 == num)
				{
				}
				num = (short)559939584;
				if (num != 0)
				{
				}
				num = (short)412024833;
				if (num != 0)
				{
				}
				num = (short)737411072;
				short num3 = num;
				return this.allowEnhancedDataToBeSentOnClassicDataChannel_42014.HiddenDynamic;
			}
			set
			{
				short num = (short)167920654;
				short num2 = num;
				num = (short)810370062;
				switch (num2 == num)
				{
				}
				num = (short)262930433;
				if (num != 0)
				{
				}
				num = (short)1829699584;
				if (num != 0)
				{
				}
				num = (short)1354891264;
				short num3 = num;
				this.allowEnhancedDataToBeSentOnClassicDataChannel_42014.HiddenDynamic = value;
			}
		}

		// Token: 0x1700559B RID: 21915
		// (get) Token: 0x0600AB14 RID: 43796 RVA: 0x009F86F4 File Offset: 0x009F68F4
		public bool AllowEnhancedDataToBeSentOnClassicDataChannel_42014_HasDiffs
		{
			get
			{
				short num = (short)62685486;
				short num2 = num;
				num = (short)388006190;
				switch (num2 == num)
				{
				}
				num = (short)1197932544;
				if (num != 0)
				{
				}
				num = (short)1478688769;
				if (num != 0)
				{
				}
				num = (short)578289664;
				short num3 = num;
				return this.allowEnhancedDataToBeSentOnClassicDataChannel_42014._HasDiffs;
			}
		}

		// Token: 0x1700559C RID: 21916
		// (get) Token: 0x0600AB15 RID: 43797 RVA: 0x009F87AC File Offset: 0x009F69AC
		// (set) Token: 0x0600AB16 RID: 43798 RVA: 0x009F8860 File Offset: 0x009F6A60
		public int QueueDwellTimerSec_42015Value
		{
			get
			{
				short num = (short)1432879105;
				if (num != 0)
				{
				}
				num = (short)1934360229;
				short num2 = num;
				num = (short)207027877;
				switch (num2 == num)
				{
				}
				num = (short)1676541952;
				if (num != 0)
				{
				}
				num = (short)792657920;
				short num3 = num;
				return this.queueDwellTimerSec_42015.Value;
			}
			set
			{
				short num = (short)2043084801;
				if (num != 0)
				{
				}
				num = (short)2081262279;
				short num2 = num;
				num = (short)405441223;
				switch (num2 == num)
				{
				}
				num = (short)1234239488;
				if (num != 0)
				{
				}
				num = (short)1828978688;
				short num3 = num;
				this.queueDwellTimerSec_42015.Value = value;
			}
		}

		// Token: 0x1700559D RID: 21917
		// (get) Token: 0x0600AB17 RID: 43799 RVA: 0x009F8918 File Offset: 0x009F6B18
		public global::AcpBusinessLayer.AcpSimpleRangeField QueueDwellTimerSec_42015
		{
			get
			{
				short num = (short)1489309206;
				short num2 = num;
				num = (short)1229393430;
				switch (num2 == num)
				{
				}
				num = (short)989986817;
				if (num != 0)
				{
				}
				num = (short)553910272;
				if (num != 0)
				{
				}
				num = (short)1237254144;
				short num3 = num;
				return this.queueDwellTimerSec_42015;
			}
		}

		// Token: 0x1700559E RID: 21918
		// (get) Token: 0x0600AB18 RID: 43800 RVA: 0x009F89C4 File Offset: 0x009F6BC4
		// (set) Token: 0x0600AB19 RID: 43801 RVA: 0x009F8A74 File Offset: 0x009F6C74
		public string QueueDwellTimerSec_42015_UIValue
		{
			get
			{
				short num = (short)213975041;
				if (num != 0)
				{
				}
				num = (short)672349798;
				short num2 = num;
				num = (short)1210072678;
				switch (num2 == num)
				{
				}
				num = (short)1287454720;
				if (num != 0)
				{
				}
				num = (short)998047744;
				short num3 = num;
				return this.queueDwellTimerSec_42015.UIValue;
			}
			set
			{
				short num = (short)579634288;
				short num2 = num;
				num = (short)144802928;
				switch (num2 == num)
				{
				}
				num = (short)308084737;
				if (num != 0)
				{
				}
				num = (short)926285824;
				if (num != 0)
				{
				}
				num = (short)79953920;
				short num3 = num;
				this.queueDwellTimerSec_42015.UIValue = value;
			}
		}

		// Token: 0x1700559F RID: 21919
		// (get) Token: 0x0600AB1A RID: 43802 RVA: 0x009F8B28 File Offset: 0x009F6D28
		// (set) Token: 0x0600AB1B RID: 43803 RVA: 0x009F8BDC File Offset: 0x009F6DDC
		internal int QueueDwellTimerSec_42015Min
		{
			get
			{
				short num = (short)1546264185;
				short num2 = num;
				num = (short)1987583609;
				switch (num2 == num)
				{
				}
				num = (short)2050883585;
				if (num != 0)
				{
				}
				num = (short)625541120;
				if (num != 0)
				{
				}
				num = (short)891158528;
				short num3 = num;
				return this.queueDwellTimerSec_42015.Min;
			}
			set
			{
				short num = (short)511262888;
				short num2 = num;
				num = (short)1852063912;
				switch (num2 == num)
				{
				}
				num = (short)25690113;
				if (num != 0)
				{
				}
				num = (short)741539840;
				if (num != 0)
				{
				}
				num = (short)457572352;
				short num3 = num;
				this.queueDwellTimerSec_42015.Min = value;
			}
		}

		// Token: 0x170055A0 RID: 21920
		// (get) Token: 0x0600AB1C RID: 43804 RVA: 0x009F8C90 File Offset: 0x009F6E90
		// (set) Token: 0x0600AB1D RID: 43805 RVA: 0x009F8D44 File Offset: 0x009F6F44
		internal int QueueDwellTimerSec_42015Max
		{
			get
			{
				short num = (short)140115969;
				if (num != 0)
				{
				}
				num = (short)191955667;
				short num2 = num;
				num = (short)998900435;
				switch (num2 == num)
				{
				}
				num = (short)25755648;
				if (num != 0)
				{
				}
				num = (short)859701248;
				short num3 = num;
				return this.queueDwellTimerSec_42015.Max;
			}
			set
			{
				short num = (short)1317557729;
				short num2 = num;
				num = (short)1545164257;
				switch (num2 == num)
				{
				}
				num = (short)1630601217;
				if (num != 0)
				{
				}
				num = (short)308412416;
				if (num != 0)
				{
				}
				num = (short)1716060160;
				short num3 = num;
				this.queueDwellTimerSec_42015.Max = value;
			}
		}

		// Token: 0x170055A1 RID: 21921
		// (get) Token: 0x0600AB1E RID: 43806 RVA: 0x009F8DFC File Offset: 0x009F6FFC
		// (set) Token: 0x0600AB1F RID: 43807 RVA: 0x009F8EB0 File Offset: 0x009F70B0
		internal int QueueDwellTimerSec_42015Step
		{
			get
			{
				short num = (short)982765033;
				short num2 = num;
				num = (short)449826281;
				switch (num2 == num)
				{
				}
				num = (short)1399193601;
				if (num != 0)
				{
				}
				num = (short)2070740992;
				if (num != 0)
				{
				}
				num = (short)483590144;
				short num3 = num;
				return this.queueDwellTimerSec_42015.StepSize;
			}
			set
			{
				short num = (short)1238132591;
				short num2 = num;
				num = (short)1117611887;
				switch (num2 == num)
				{
				}
				num = (short)19070977;
				if (num != 0)
				{
				}
				num = (short)1297809408;
				if (num != 0)
				{
				}
				num = (short)26279936;
				short num3 = num;
				this.queueDwellTimerSec_42015.StepSize = value;
			}
		}

		// Token: 0x170055A2 RID: 21922
		// (get) Token: 0x0600AB20 RID: 43808 RVA: 0x009F8F68 File Offset: 0x009F7168
		// (set) Token: 0x0600AB21 RID: 43809 RVA: 0x009F901C File Offset: 0x009F721C
		public bool QueueDwellTimerSec_42015_Applicable
		{
			get
			{
				short num = (short)382511447;
				short num2 = num;
				num = (short)832088407;
				switch (num2 == num)
				{
				}
				num = (short)1501888513;
				if (num != 0)
				{
				}
				num = (short)506855424;
				if (num != 0)
				{
				}
				num = (short)412286976;
				short num3 = num;
				return this.queueDwellTimerSec_42015.Applicable;
			}
			set
			{
				short num = (short)489716723;
				short num2 = num;
				num = (short)399473651;
				switch (num2 == num)
				{
				}
				num = (short)1094909953;
				if (num != 0)
				{
				}
				num = (short)1434320896;
				if (num != 0)
				{
				}
				num = (short)549715968;
				short num3 = num;
				this.queueDwellTimerSec_42015.Applicable = value;
			}
		}

		// Token: 0x170055A3 RID: 21923
		// (get) Token: 0x0600AB22 RID: 43810 RVA: 0x009F90D0 File Offset: 0x009F72D0
		// (set) Token: 0x0600AB23 RID: 43811 RVA: 0x009F9188 File Offset: 0x009F7388
		public bool QueueDwellTimerSec_42015_Valid
		{
			get
			{
				short num = (short)215152730;
				short num2 = num;
				num = (short)104921178;
				switch (num2 == num)
				{
				}
				num = (short)734461952;
				if (num != 0)
				{
				}
				num = (short)1945174017;
				if (num != 0)
				{
				}
				num = (short)17367040;
				short num3 = num;
				return this.queueDwellTimerSec_42015.Valid;
			}
			set
			{
				short num = (short)1105040308;
				short num2 = num;
				num = (short)277124020;
				switch (num2 == num)
				{
				}
				num = (short)982515713;
				if (num != 0)
				{
				}
				num = (short)1946615808;
				if (num != 0)
				{
				}
				num = (short)609681408;
				short num3 = num;
				this.queueDwellTimerSec_42015.Valid = value;
			}
		}

		// Token: 0x170055A4 RID: 21924
		// (get) Token: 0x0600AB24 RID: 43812 RVA: 0x009F923C File Offset: 0x009F743C
		// (set) Token: 0x0600AB25 RID: 43813 RVA: 0x009F92F0 File Offset: 0x009F74F0
		public bool QueueDwellTimerSec_42015_Visible
		{
			get
			{
				short num = (short)233777718;
				short num2 = num;
				num = (short)1026435638;
				switch (num2 == num)
				{
				}
				num = (short)1233518593;
				if (num != 0)
				{
				}
				num = (short)1044840448;
				if (num != 0)
				{
				}
				num = (short)1151401984;
				short num3 = num;
				return this.queueDwellTimerSec_42015.Visible;
			}
			set
			{
				short num = (short)995075427;
				short num2 = num;
				num = (short)1765385571;
				switch (num2 == num)
				{
				}
				num = (short)1341128705;
				if (num != 0)
				{
				}
				num = (short)1129775104;
				if (num != 0)
				{
				}
				num = (short)2119630848;
				short num3 = num;
				this.queueDwellTimerSec_42015.Visible = value;
			}
		}

		// Token: 0x170055A5 RID: 21925
		// (get) Token: 0x0600AB26 RID: 43814 RVA: 0x009F93A8 File Offset: 0x009F75A8
		// (set) Token: 0x0600AB27 RID: 43815 RVA: 0x009F945C File Offset: 0x009F765C
		public bool QueueDwellTimerSec_42015_Editable
		{
			get
			{
				short num = (short)1735878760;
				short num2 = num;
				num = (short)256141416;
				switch (num2 == num)
				{
				}
				num = (short)2073231360;
				if (num != 0)
				{
				}
				num = (short)1616052225;
				if (num != 0)
				{
				}
				num = (short)1872363520;
				short num3 = num;
				return this.queueDwellTimerSec_42015.Editable;
			}
			set
			{
				short num = (short)1396890803;
				short num2 = num;
				num = (short)50191539;
				switch (num2 == num)
				{
				}
				num = (short)464584705;
				if (num != 0)
				{
				}
				num = (short)2104360960;
				if (num != 0)
				{
				}
				num = (short)1413677056;
				short num3 = num;
				this.queueDwellTimerSec_42015.Editable = value;
			}
		}

		// Token: 0x170055A6 RID: 21926
		// (get) Token: 0x0600AB28 RID: 43816 RVA: 0x009F9510 File Offset: 0x009F7710
		internal string QueueDwellTimerSec_42015_UILabel
		{
			get
			{
				short num = (short)1403888997;
				short num2 = num;
				num = (short)1886430565;
				switch (num2 == num)
				{
				}
				num = (short)1596063745;
				if (num != 0)
				{
				}
				num = (short)1502412800;
				if (num != 0)
				{
				}
				num = (short)330760192;
				short num3 = num;
				return this.queueDwellTimerSec_42015.UIName;
			}
		}

		// Token: 0x170055A7 RID: 21927
		// (get) Token: 0x0600AB29 RID: 43817 RVA: 0x009F95C8 File Offset: 0x009F77C8
		// (set) Token: 0x0600AB2A RID: 43818 RVA: 0x009F967C File Offset: 0x009F787C
		internal bool QueueDwellTimerSec_42015_HiddenStatic
		{
			get
			{
				short num = (short)328267414;
				short num2 = num;
				num = (short)795866774;
				switch (num2 == num)
				{
				}
				num = (short)1687289857;
				if (num != 0)
				{
				}
				num = (short)1647706112;
				if (num != 0)
				{
				}
				num = (short)1601372160;
				short num3 = num;
				return this.queueDwellTimerSec_42015.HiddenStatic;
			}
			set
			{
				short num = (short)1829626600;
				short num2 = num;
				num = (short)759554792;
				switch (num2 == num)
				{
				}
				num = (short)664535040;
				if (num != 0)
				{
				}
				num = (short)1244004353;
				if (num != 0)
				{
				}
				num = (short)2099773440;
				short num3 = num;
				this.queueDwellTimerSec_42015.HiddenStatic = value;
			}
		}

		// Token: 0x170055A8 RID: 21928
		// (get) Token: 0x0600AB2B RID: 43819 RVA: 0x009F9730 File Offset: 0x009F7930
		// (set) Token: 0x0600AB2C RID: 43820 RVA: 0x009F97E4 File Offset: 0x009F79E4
		internal bool QueueDwellTimerSec_42015_HiddenDynamic
		{
			get
			{
				short num = (short)1550722912;
				short num2 = num;
				num = (short)373303136;
				switch (num2 == num)
				{
				}
				num = (short)1150746624;
				if (num != 0)
				{
				}
				num = (short)1997144065;
				if (num != 0)
				{
				}
				num = (short)1675427840;
				short num3 = num;
				return this.queueDwellTimerSec_42015.HiddenDynamic;
			}
			set
			{
				short num = (short)1459714233;
				short num2 = num;
				num = (short)970750137;
				switch (num2 == num)
				{
				}
				num = (short)1441793;
				if (num != 0)
				{
				}
				num = (short)1623392256;
				if (num != 0)
				{
				}
				num = (short)398000128;
				short num3 = num;
				this.queueDwellTimerSec_42015.HiddenDynamic = value;
			}
		}

		// Token: 0x170055A9 RID: 21929
		// (get) Token: 0x0600AB2D RID: 43821 RVA: 0x009F989C File Offset: 0x009F7A9C
		public bool QueueDwellTimerSec_42015_HasDiffs
		{
			get
			{
				short num = (short)1819913275;
				short num2 = num;
				num = (short)732212283;
				switch (num2 == num)
				{
				}
				num = (short)62783489;
				if (num != 0)
				{
				}
				num = (short)693501952;
				if (num != 0)
				{
				}
				num = (short)1252065280;
				short num3 = num;
				return this.queueDwellTimerSec_42015._HasDiffs;
			}
		}

		// Token: 0x170055AA RID: 21930
		// (get) Token: 0x0600AB2E RID: 43822 RVA: 0x009F9950 File Offset: 0x009F7B50
		// (set) Token: 0x0600AB2F RID: 43823 RVA: 0x009F9A04 File Offset: 0x009F7C04
		public bool DatProSendDataDurEmerHangtime_A43103Value
		{
			get
			{
				short num = (short)1513379254;
				short num2 = num;
				num = (short)338449846;
				switch (num2 == num)
				{
				}
				num = (short)481296385;
				if (num != 0)
				{
				}
				num = (short)96010240;
				if (num != 0)
				{
				}
				num = (short)1513422848;
				short num3 = num;
				return this.datProSendDataDurEmerHangtime_A43103.Value;
			}
			set
			{
				short num = (short)303169328;
				short num2 = num;
				num = (short)377749296;
				switch (num2 == num)
				{
				}
				num = (short)1273167872;
				if (num != 0)
				{
				}
				num = (short)1231486977;
				if (num != 0)
				{
				}
				num = (short)1569325056;
				short num3 = num;
				this.datProSendDataDurEmerHangtime_A43103.Value = value;
			}
		}

		// Token: 0x170055AB RID: 21931
		// (get) Token: 0x0600AB30 RID: 43824 RVA: 0x009F9ABC File Offset: 0x009F7CBC
		public global::AcpBusinessLayer.AcpField<bool> DatProSendDataDurEmerHangtime_A43103
		{
			get
			{
				short num = (short)1468317476;
				short num2 = num;
				num = (short)949993252;
				switch (num2 == num)
				{
				}
				num = (short)1739653121;
				if (num != 0)
				{
				}
				num = (short)609878016;
				if (num != 0)
				{
				}
				num = (short)1674051584;
				short num3 = num;
				return this.datProSendDataDurEmerHangtime_A43103;
			}
		}

		// Token: 0x170055AC RID: 21932
		// (get) Token: 0x0600AB31 RID: 43825 RVA: 0x009F9B70 File Offset: 0x009F7D70
		// (set) Token: 0x0600AB32 RID: 43826 RVA: 0x009F9C28 File Offset: 0x009F7E28
		public bool DatProSendDataDurEmerHangtime_A43103_UIValue
		{
			get
			{
				short num = (short)853138626;
				short num2 = num;
				num = (short)1540218050;
				switch (num2 == num)
				{
				}
				num = (short)832241665;
				if (num != 0)
				{
				}
				num = (short)829685760;
				if (num != 0)
				{
				}
				num = (short)696647680;
				short num3 = num;
				return this.datProSendDataDurEmerHangtime_A43103.Value;
			}
			set
			{
				short num = (short)563520175;
				short num2 = num;
				num = (short)215655087;
				switch (num2 == num)
				{
				}
				num = (short)1390804992;
				if (num != 0)
				{
				}
				num = (short)1930821633;
				if (num != 0)
				{
				}
				num = (short)651165696;
				short num3 = num;
				this.datProSendDataDurEmerHangtime_A43103.Value = value;
			}
		}

		// Token: 0x170055AD RID: 21933
		// (get) Token: 0x0600AB33 RID: 43827 RVA: 0x009F9CE0 File Offset: 0x009F7EE0
		// (set) Token: 0x0600AB34 RID: 43828 RVA: 0x009F9D94 File Offset: 0x009F7F94
		public bool DatProSendDataDurEmerHangtime_A43103_Applicable
		{
			get
			{
				short num = (short)1652194448;
				short num2 = num;
				num = (short)664763536;
				switch (num2 == num)
				{
				}
				num = (short)1292697601;
				if (num != 0)
				{
				}
				num = (short)1362755584;
				if (num != 0)
				{
				}
				num = (short)996081664;
				short num3 = num;
				return this.datProSendDataDurEmerHangtime_A43103.Applicable;
			}
			set
			{
				short num = (short)1900412929;
				if (num != 0)
				{
				}
				num = (short)1694925704;
				short num2 = num;
				num = (short)585794440;
				switch (num2 == num)
				{
				}
				num = (short)799670272;
				if (num != 0)
				{
				}
				num = (short)2048983040;
				short num3 = num;
				this.datProSendDataDurEmerHangtime_A43103.Applicable = value;
			}
		}

		// Token: 0x170055AE RID: 21934
		// (get) Token: 0x0600AB35 RID: 43829 RVA: 0x009F9E4C File Offset: 0x009F804C
		// (set) Token: 0x0600AB36 RID: 43830 RVA: 0x009F9F00 File Offset: 0x009F8100
		public bool DatProSendDataDurEmerHangtime_A43103_Valid
		{
			get
			{
				short num = (short)1016906353;
				short num2 = num;
				num = (short)1433322097;
				switch (num2 == num)
				{
				}
				num = (short)1729036289;
				if (num != 0)
				{
				}
				num = (short)120127488;
				if (num != 0)
				{
				}
				num = (short)508035072;
				short num3 = num;
				return this.datProSendDataDurEmerHangtime_A43103.Valid;
			}
			set
			{
				short num = (short)1167561039;
				short num2 = num;
				num = (short)788107599;
				switch (num2 == num)
				{
				}
				num = (short)1431896065;
				if (num != 0)
				{
				}
				num = (short)1922564096;
				if (num != 0)
				{
				}
				num = (short)643760128;
				short num3 = num;
				this.datProSendDataDurEmerHangtime_A43103.Valid = value;
			}
		}

		// Token: 0x170055AF RID: 21935
		// (get) Token: 0x0600AB37 RID: 43831 RVA: 0x009F9FB8 File Offset: 0x009F81B8
		// (set) Token: 0x0600AB38 RID: 43832 RVA: 0x009FA070 File Offset: 0x009F8270
		public bool DatProSendDataDurEmerHangtime_A43103_Visible
		{
			get
			{
				short num = (short)220921857;
				if (num != 0)
				{
				}
				num = (short)2642947;
				short num2 = num;
				num = (short)924406787;
				switch (num2 == num)
				{
				}
				num = (short)388497408;
				if (num != 0)
				{
				}
				num = (short)1712259072;
				short num3 = num;
				return this.datProSendDataDurEmerHangtime_A43103.Visible;
			}
			set
			{
				short num = (short)444252777;
				short num2 = num;
				num = (short)805683817;
				switch (num2 == num)
				{
				}
				num = (short)2106458113;
				if (num != 0)
				{
				}
				num = (short)951451648;
				if (num != 0)
				{
				}
				num = (short)742785024;
				short num3 = num;
				this.datProSendDataDurEmerHangtime_A43103.Visible = value;
			}
		}

		// Token: 0x170055B0 RID: 21936
		// (get) Token: 0x0600AB39 RID: 43833 RVA: 0x009FA124 File Offset: 0x009F8324
		// (set) Token: 0x0600AB3A RID: 43834 RVA: 0x009FA1D8 File Offset: 0x009F83D8
		public bool DatProSendDataDurEmerHangtime_A43103_Editable
		{
			get
			{
				short num = (short)708847984;
				short num2 = num;
				num = (short)1669998960;
				switch (num2 == num)
				{
				}
				num = (short)1218248705;
				if (num != 0)
				{
				}
				num = (short)23396352;
				if (num != 0)
				{
				}
				num = (short)1985282048;
				short num3 = num;
				return this.datProSendDataDurEmerHangtime_A43103.Editable;
			}
			set
			{
				short num = (short)500559191;
				short num2 = num;
				num = (short)1682697559;
				switch (num2 == num)
				{
				}
				num = (short)634781697;
				if (num != 0)
				{
				}
				num = (short)40239104;
				if (num != 0)
				{
				}
				num = (short)1247019008;
				short num3 = num;
				this.datProSendDataDurEmerHangtime_A43103.Editable = value;
			}
		}

		// Token: 0x170055B1 RID: 21937
		// (get) Token: 0x0600AB3B RID: 43835 RVA: 0x009FA28C File Offset: 0x009F848C
		internal string DatProSendDataDurEmerHangtime_A43103_UILabel
		{
			get
			{
				short num = (short)1759313921;
				if (num != 0)
				{
				}
				num = (short)2121446246;
				short num2 = num;
				num = (short)1911141222;
				switch (num2 == num)
				{
				}
				num = (short)341180416;
				if (num != 0)
				{
				}
				num = (short)173277184;
				short num3 = num;
				return this.datProSendDataDurEmerHangtime_A43103.UIName;
			}
		}

		// Token: 0x170055B2 RID: 21938
		// (get) Token: 0x0600AB3C RID: 43836 RVA: 0x009FA340 File Offset: 0x009F8540
		// (set) Token: 0x0600AB3D RID: 43837 RVA: 0x009FA3F4 File Offset: 0x009F85F4
		internal bool DatProSendDataDurEmerHangtime_A43103_HiddenStatic
		{
			get
			{
				short num = (short)1172045825;
				if (num != 0)
				{
				}
				num = (short)911618363;
				short num2 = num;
				num = (short)1624846651;
				switch (num2 == num)
				{
				}
				num = (short)1952317440;
				if (num != 0)
				{
				}
				num = (short)1472397312;
				short num3 = num;
				return this.datProSendDataDurEmerHangtime_A43103.HiddenStatic;
			}
			set
			{
				short num = (short)1551349929;
				short num2 = num;
				num = (short)1165277353;
				switch (num2 == num)
				{
				}
				num = (short)1827733505;
				if (num != 0)
				{
				}
				num = (short)1041039360;
				if (num != 0)
				{
				}
				num = (short)431292416;
				short num3 = num;
				this.datProSendDataDurEmerHangtime_A43103.HiddenStatic = value;
			}
		}

		// Token: 0x170055B3 RID: 21939
		// (get) Token: 0x0600AB3E RID: 43838 RVA: 0x009FA4AC File Offset: 0x009F86AC
		// (set) Token: 0x0600AB3F RID: 43839 RVA: 0x009FA564 File Offset: 0x009F8764
		internal bool DatProSendDataDurEmerHangtime_A43103_HiddenDynamic
		{
			get
			{
				short num = (short)770156924;
				short num2 = num;
				num = (short)2085661052;
				switch (num2 == num)
				{
				}
				num = (short)322371584;
				if (num != 0)
				{
				}
				num = (short)1686306817;
				if (num != 0)
				{
				}
				num = (short)1544552448;
				short num3 = num;
				return this.datProSendDataDurEmerHangtime_A43103.HiddenDynamic;
			}
			set
			{
				short num = (short)1522544005;
				short num2 = num;
				num = (short)323628421;
				switch (num2 == num)
				{
				}
				num = (short)791478273;
				if (num != 0)
				{
				}
				num = (short)94961664;
				if (num != 0)
				{
				}
				num = (short)872611840;
				short num3 = num;
				this.datProSendDataDurEmerHangtime_A43103.HiddenDynamic = value;
			}
		}

		// Token: 0x170055B4 RID: 21940
		// (get) Token: 0x0600AB40 RID: 43840 RVA: 0x009FA618 File Offset: 0x009F8818
		public bool DatProSendDataDurEmerHangtime_A43103_HasDiffs
		{
			get
			{
				short num = (short)757226647;
				short num2 = num;
				num = (short)1680039063;
				switch (num2 == num)
				{
				}
				num = (short)2424833;
				if (num != 0)
				{
				}
				num = (short)7208960;
				if (num != 0)
				{
				}
				num = (short)1420886016;
				short num3 = num;
				return this.datProSendDataDurEmerHangtime_A43103._HasDiffs;
			}
		}

		// Token: 0x0600AB41 RID: 43841 RVA: 0x009FA6CC File Offset: 0x009F88CC
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
					num2 = (short)930676738;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)1155530753;
						if (num2 != 0)
						{
						}
						num2 = (short)1152974848;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 2:
					return result;
				case 3:
					num2 = (short)1428881409;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (base.ParentRecset != null)
					{
						num2 = (short)1700659203;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				goto IL_24;
			}
			return result;
			for (;;)
			{
				IL_24:
				result = null;
				num2 = (short)1732807370;
				short num3 = num2;
				num2 = (short)871336650;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_5C;
				}
			}
			IL_5C:
			num2 = (short)1358561280;
			if (num2 != 0)
			{
			}
			num2 = (short)674103296;
			short num4 = num2;
			num2 = (short)950927364;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x040053AB RID: 21419
		private global::AcpBusinessLayer.AcpRecRefField datProFeaturesPortListSelection_A42011;

		// Token: 0x040053AC RID: 21420
		private global::AcpBusinessLayer.AcpField<bool> allowEnhancedDataToBeSentOnClassicDataChannel_42014;

		// Token: 0x040053AD RID: 21421
		private global::AcpBusinessLayer.AcpSimpleRangeField queueDwellTimerSec_42015;

		// Token: 0x040053AE RID: 21422
		private global::AcpBusinessLayer.AcpField<bool> datProSendDataDurEmerHangtime_A43103;
	}
}
