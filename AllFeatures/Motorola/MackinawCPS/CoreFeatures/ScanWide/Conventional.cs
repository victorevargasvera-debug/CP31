using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ScanWide
{
	// Token: 0x02000107 RID: 263
	[global::System.Serializable]
	public class Conventional : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600264D RID: 9805 RVA: 0x002575CC File Offset: 0x002557CC
		public Conventional(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x0600264E RID: 9806 RVA: 0x002575E8 File Offset: 0x002557E8
		protected Conventional(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600264F RID: 9807 RVA: 0x00257600 File Offset: 0x00255800
		public override void Init()
		{
			int a_ = 0;
			short num = (short)565146384;
			short num2 = num;
			num = (short)155218704;
			switch (num2 == num)
			{
			default:
			{
				num = (short)847118336;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)748683265;
			if (num != 0)
			{
			}
			num = (short)1357053952;
			if (num != 0)
			{
			}
			this.scanWideConventionalCarrierDetectRequired_A7611 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鋀ꃂ꓄꧆黈ꋊ꧌꫎鋐볒믔ꇖ볘뗚꧜뛞軠跢蓤详ꫨ諪鿬鷮飰雲蟴돶鳸迺飼鳾甀儂怄瘆簈戊缌樎甐䰒吔‖⼘⨚Ⱌ", a_), global::CommonResources.AcgResources.ID_CARRIERDETECTREQUIRED);
			this.scanWideConventionalCarrierDetectRequired_A7611.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.scanWideConventionalCarrierDetectRequired_A7611.DataTransferOrder = 2;
			this.scanWideConventionalMonitorHoldTimesec_A8543 = new global::AcpBusinessLayer.AcpSimpleRangeField(6, this, global::AllFeatures.CodeplugGuid.b("鋀ꃂ꓄꧆黈ꋊ꧌꫎鋐볒믔ꇖ볘뗚꧜뛞軠跢蓤详ꓨ蓪菬蛮藰鳲蟴뿶雸韺駼꯾栀渂怄理氈栊刌与⤐☒℔␖", a_), global::CommonResources.AcgResources.ID_MONITORHOLDTIMESEC, 0, 255, null, null, 0, 1);
			this.scanWideConventionalMonitorHoldTimesec_A8543.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.scanWideConventionalMonitorHoldTimesec_A8543.DataTransferOrder = 10;
			this.scanWideConventionalMonitorHoldTimesec_A8543.ShowHexValue = false;
			this.scanWideConventionalPriorityChannelMarking_A8750 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鋀ꃂ꓄꧆黈ꋊ꧌꫎鋐볒믔ꇖ볘뗚꧜뛞軠跢蓤详맨駪蓬胮菰髲致軶뫸鏺鳼釾漀昂椄䨆栈礊昌明缐琒䨔嘖℘Ⱊ⠜⼞", a_), global::CommonResources.AcgResources.ID_PRIORITYCHANNELMARKING);
			this.scanWideConventionalPriorityChannelMarking_A8750.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.scanWideConventionalPriorityChannelMarking_A8750.DataTransferOrder = 3;
			this.scanWideConventionalRSSIVotingThreshold_A8997 = new global::AcpBusinessLayer.AcpSimpleRangeField(87, this, global::AllFeatures.CodeplugGuid.b("鋀ꃂ꓄꧆黈ꋊ꧌꫎鋐볒믔ꇖ볘뗚꧜뛞軠跢蓤详믨룪뻬ꛮ꟰鳲致黶韸鳺ꧼ韾猀昂瘄漆昈朊椌倎倐⬒Ⱄ⸖⸘", a_), global::CommonResources.AcgResources.ID_RSSIVOTINGTHRESHOLD, 0, 255, null, null, 0, 1);
			this.scanWideConventionalRSSIVotingThreshold_A8997.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.scanWideConventionalRSSIVotingThreshold_A8997.DataTransferOrder = 4;
			this.scanWideConventionalRSSIVotingThreshold_A8997.ShowHexValue = true;
			this.scanWideConventionalTimeBetweenPrioritySamplesms_A9376 = new global::AcpBusinessLayer.AcpSimpleRangeField(22, this, global::AllFeatures.CodeplugGuid.b("鋀ꃂ꓄꧆黈ꋊ꧌꫎鋐볒믔ꇖ볘뗚꧜뛞軠跢蓤详뷨苪胬諮돰雲致胶鳸黺鏼꿾猀樂樄甆怈缊琌導瀐縒攔笖簘栚瀜氞縠戢ᰤᐦḨᴪ", a_), global::CommonResources.AcgResources.ID_TIMEBETWEENPRIORITYSAMPLESMS, 10, 255, null, null, 0, 25);
			this.scanWideConventionalTimeBetweenPrioritySamplesms_A9376.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.scanWideConventionalTimeBetweenPrioritySamplesms_A9376.DataTransferOrder = 8;
			this.scanWideConventionalTimeBetweenPrioritySamplesms_A9376.ShowHexValue = false;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("苀곂ꯄ뇆곈ꗊ만ꛎ뻐뷒듔믖", a_);
			base.Id = 10048;
			base.UIName = global::CommonResources.AcgResources.ID_CONVENTIONAL;
			base.DataTransferOrder = 2;
		}

		// Token: 0x06002650 RID: 9808 RVA: 0x00257844 File Offset: 0x00255A44
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 11;
			short num = (short)240779279;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					this.scanWideConventionalRSSIVotingThreshold_A8997 = new global::AcpBusinessLayer.AcpSimpleRangeField(87, this, global::AllFeatures.CodeplugGuid.b("鿋귍뇏병菓뿕볗뿙鿛뇝軟铡臣裥鳧菩菫胭釯黱꛳ꗵ꯷돹꫻釽瓿欁樃愅將戉縋欍挏稑笓稕簗䔙崛☝᤟ᬡጣ", a_), global::CommonResources.AcgResources.ID_RSSIVOTINGTHRESHOLD, null, null, 0, 1);
					this.scanWideConventionalRSSIVotingThreshold_A8997.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.scanWideConventionalRSSIVotingThreshold_A8997.DataTransferOrder = 4;
					this.scanWideConventionalRSSIVotingThreshold_A8997.ShowHexValue = true;
					num = (short)594542604;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鿋귍뇏병菓뿕볗뿙鿛뇝軟铡臣裥鳧菩菫胭釯黱럳韵諷裹闻鯽狿䘁愃爅洇椉砋對甏挑愓缕樗缙砛䄝感ᔡሣᜥᤧ", a_)))
					{
						num = (short)855310338;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_434;
				case 2:
				{
					num = (short)1875574784;
					short num3 = num;
					this.scanWideConventionalCarrierDetectRequired_A7611 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鿋귍뇏병菓뿕볗뿙鿛뇝軟铡臣裥鳧菩菫胭釯黱럳韵諷裹闻鯽狿䘁愃爅洇椉砋對甏挑愓缕樗缙砛䄝感ᔡሣᜥᤧ", a_), global::CommonResources.AcgResources.ID_CARRIERDETECTREQUIRED);
					this.scanWideConventionalCarrierDetectRequired_A7611.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.scanWideConventionalCarrierDetectRequired_A7611.DataTransferOrder = 2;
					num = (short)1485766674;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
					if (producerFields != null)
					{
						num = (short)1926168587;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_480;
				case 4:
					this.scanWideConventionalTimeBetweenPrioritySamplesms_A9376 = new global::AcpBusinessLayer.AcpSimpleRangeField(22, this, global::AllFeatures.CodeplugGuid.b("鿋귍뇏병菓뿕볗뿙鿛뇝軟铡臣裥鳧菩菫胭釯黱ꃳ鿵闷鿹뻻鯽瓿甁愃挅昇娉縋服缏怑紓戕愗䤙紛猝借両䄣唥䔧天猫漭यı̳5", a_), global::CommonResources.AcgResources.ID_TIMEBETWEENPRIORITYSAMPLESMS, null, null, 0, 25);
					this.scanWideConventionalTimeBetweenPrioritySamplesms_A9376.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.scanWideConventionalTimeBetweenPrioritySamplesms_A9376.DataTransferOrder = 8;
					this.scanWideConventionalTimeBetweenPrioritySamplesms_A9376.ShowHexValue = false;
					num = (short)1227096074;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鿋귍뇏병菓뿕볗뿙鿛뇝軟铡臣裥鳧菩菫胭釯黱ꓳ蓵釷闹軻韽瓿笁䜃清椇搉戋欍簏弑甓搕猗猙爛礝缟挡ᰣᄥᴧᨩ", a_)))
					{
						num = (short)1462370310;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_9E;
				case 6:
					this.scanWideConventionalPriorityChannelMarking_A8750 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鿋귍뇏병菓뿕볗뿙鿛뇝軟铡臣裥鳧菩菫胭釯黱ꓳ蓵釷闹軻韽瓿笁䜃清椇搉戋欍簏弑甓搕猗猙爛礝缟挡ᰣᄥᴧᨩ", a_), global::CommonResources.AcgResources.ID_PRIORITYCHANNELMARKING);
					this.scanWideConventionalPriorityChannelMarking_A8750.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.scanWideConventionalPriorityChannelMarking_A8750.DataTransferOrder = 3;
					num = (short)1032388625;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鿋귍뇏병菓뿕볗뿙鿛뇝軟铡臣裥鳧菩菫胭釯黱맳駵雷鏹裻釽狿䨁欃樅氇帉攋挍甏愑焓甕䜗嬙␛⬝ᐟᄡ", a_)))
					{
						num = (short)1506541577;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_EB;
				case 8:
					goto IL_EB;
				case 9:
					this.scanWideConventionalMonitorHoldTimesec_A8543 = new global::AcpBusinessLayer.AcpSimpleRangeField(6, this, global::AllFeatures.CodeplugGuid.b("鿋귍뇏병菓뿕볗뿙鿛뇝軟铡臣裥鳧菩菫胭釯黱맳駵雷鏹裻釽狿䨁欃樅氇帉攋挍甏愑焓甕䜗嬙␛⬝ᐟᄡ", a_), global::CommonResources.AcgResources.ID_MONITORHOLDTIMESEC, null, null, 0, 1);
					this.scanWideConventionalMonitorHoldTimesec_A8543.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.scanWideConventionalMonitorHoldTimesec_A8543.DataTransferOrder = 10;
					this.scanWideConventionalMonitorHoldTimesec_A8543.ShowHexValue = false;
					num = (short)1487601672;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					goto IL_322;
				case 11:
					num = (short)816513025;
					if (num != 0)
					{
					}
					num = (short)772538369;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					goto IL_1AB;
				case 13:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鿋귍뇏병菓뿕볗뿙鿛뇝軟铡臣裥鳧菩菫胭釯黱꛳ꗵ꯷돹꫻釽瓿欁樃愅將戉縋欍挏稑笓稕簗䔙崛☝᤟ᬡጣ", a_)))
					{
						num = (short)336723968;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1AB;
				case 14:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鿋귍뇏병菓뿕볗뿙鿛뇝軟铡臣裥鳧菩菫胭釯黱ꃳ鿵闷鿹뻻鯽瓿甁愃挅昇娉縋服缏怑紓戕愗䤙紛猝借両䄣唥䔧天猫漭यı̳5", a_)))
					{
						num = (short)1277493252;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_480;
				case 15:
					switch (0)
					{
					case 0:
						goto IL_7A;
					}
					continue;
				case 16:
					num = (short)1356136451;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					goto IL_9E;
				case 18:
					goto IL_434;
				}
				IL_7A:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)674889744;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_9E:
				num = (short)2081947661;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_EB:
				num = (short)1388969989;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1AB:
				num = (short)259457038;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_434:
				num = (short)1524891655;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_322:
			IL_480:
			num = (short)730966330;
			short num4 = num;
			num = (short)2075044154;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_322;
			default:
				num = (short)1596915712;
				if (num != 0)
				{
				}
				base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("迋ꇍ뻏ꓑ뇓룕곗동돛냝臟軡", a_);
				base.Id = 10048;
				base.UIName = global::CommonResources.AcgResources.ID_CONVENTIONAL;
				base.DataTransferOrder = 2;
				return;
			}
		}

		// Token: 0x06002651 RID: 9809 RVA: 0x00257D4C File Offset: 0x00255F4C
		public override void PopulateReferences()
		{
			short num = (short)2042085800;
			short num2 = num;
			num = (short)1081131432;
			switch (num2 == num)
			{
			}
			num = (short)1305804800;
			short num3 = num;
			num = (short)1761083392;
			if (num != 0)
			{
			}
			num = (short)1488060417;
			if (num != 0)
			{
			}
		}

		// Token: 0x06002652 RID: 9810 RVA: 0x00257DF4 File Offset: 0x00255FF4
		public override void DropReferences()
		{
			short num = (short)665905774;
			short num2 = num;
			num = (short)1595665006;
			switch (num2 == num)
			{
			}
			num = (short)2104623104;
			short num3 = num;
			num = (short)1811808257;
			if (num != 0)
			{
			}
			num = (short)940179456;
			if (num != 0)
			{
			}
		}

		// Token: 0x06002653 RID: 9811 RVA: 0x00257E9C File Offset: 0x0025609C
		public override void SetConstraints()
		{
			short num = (short)1599167515;
			short num2 = num;
			num = (short)169434139;
			switch (num2 == num)
			{
			}
			num = (short)634716160;
			short num3 = num;
			num = (short)1219297280;
			if (num != 0)
			{
			}
			num = (short)1306656769;
			if (num != 0)
			{
			}
		}

		// Token: 0x06002654 RID: 9812 RVA: 0x00257F44 File Offset: 0x00256144
		public override void SetupDependencies()
		{
			short num = (short)757570348;
			short num2 = num;
			num = (short)1303616300;
			switch (num2 == num)
			{
			}
			num = (short)2110717952;
			short num3 = num;
			num = (short)640286720;
			if (num != 0)
			{
			}
			num = (short)975962113;
			if (num != 0)
			{
			}
		}

		// Token: 0x1700132D RID: 4909
		// (get) Token: 0x06002655 RID: 9813 RVA: 0x00257FEC File Offset: 0x002561EC
		public bool HasDiffs
		{
			get
			{
				short num = (short)740558145;
				short num2 = num;
				num = (short)1885340993;
				switch (num2 == num)
				{
				}
				num = (short)2008416256;
				short num3 = num;
				num = (short)159711232;
				if (num != 0)
				{
				}
				num = (short)1113456641;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x1700132E RID: 4910
		// (get) Token: 0x06002656 RID: 9814 RVA: 0x0025809C File Offset: 0x0025629C
		// (set) Token: 0x06002657 RID: 9815 RVA: 0x00258150 File Offset: 0x00256350
		public bool ScanWideConventionalCarrierDetectRequired_A7611Value
		{
			get
			{
				short num = (short)901921608;
				short num2 = num;
				num = (short)2041002824;
				switch (num2 == num)
				{
				}
				num = (short)1570308096;
				short num3 = num;
				num = (short)1463549953;
				if (num != 0)
				{
				}
				num = (short)1238892544;
				if (num != 0)
				{
				}
				return this.scanWideConventionalCarrierDetectRequired_A7611.Value;
			}
			set
			{
				short num = (short)1299098207;
				short num2 = num;
				num = (short)283486815;
				switch (num2 == num)
				{
				}
				num = (short)2103836672;
				short num3 = num;
				num = (short)1955463169;
				if (num != 0)
				{
				}
				num = (short)562626560;
				if (num != 0)
				{
				}
				this.scanWideConventionalCarrierDetectRequired_A7611.Value = value;
			}
		}

		// Token: 0x1700132F RID: 4911
		// (get) Token: 0x06002658 RID: 9816 RVA: 0x00258204 File Offset: 0x00256404
		public global::AcpBusinessLayer.AcpField<bool> ScanWideConventionalCarrierDetectRequired_A7611
		{
			get
			{
				short num = (short)1105765638;
				short num2 = num;
				num = (short)1620354310;
				switch (num2 == num)
				{
				}
				num = (short)499449856;
				short num3 = num;
				num = (short)204734465;
				if (num != 0)
				{
				}
				num = (short)701693952;
				if (num != 0)
				{
				}
				return this.scanWideConventionalCarrierDetectRequired_A7611;
			}
		}

		// Token: 0x17001330 RID: 4912
		// (get) Token: 0x06002659 RID: 9817 RVA: 0x002582B4 File Offset: 0x002564B4
		// (set) Token: 0x0600265A RID: 9818 RVA: 0x0025836C File Offset: 0x0025656C
		public bool ScanWideConventionalCarrierDetectRequired_A7611_UIValue
		{
			get
			{
				short num = (short)363435563;
				short num2 = num;
				num = (short)686069291;
				switch (num2 == num)
				{
				}
				num = (short)875167744;
				short num3 = num;
				num = (short)1196032001;
				if (num != 0)
				{
				}
				num = (short)585433088;
				if (num != 0)
				{
				}
				return this.scanWideConventionalCarrierDetectRequired_A7611.Value;
			}
			set
			{
				short num = (short)1783310314;
				short num2 = num;
				num = (short)2078681066;
				switch (num2 == num)
				{
				}
				num = (short)859570176;
				short num3 = num;
				num = (short)1719140353;
				if (num != 0)
				{
				}
				num = (short)1659305984;
				if (num != 0)
				{
				}
				this.scanWideConventionalCarrierDetectRequired_A7611.Value = value;
			}
		}

		// Token: 0x17001331 RID: 4913
		// (get) Token: 0x0600265B RID: 9819 RVA: 0x00258424 File Offset: 0x00256624
		// (set) Token: 0x0600265C RID: 9820 RVA: 0x002584D8 File Offset: 0x002566D8
		public bool ScanWideConventionalCarrierDetectRequired_A7611_Applicable
		{
			get
			{
				short num = (short)956783590;
				short num2 = num;
				num = (short)1781488614;
				switch (num2 == num)
				{
				}
				num = (short)953548800;
				short num3 = num;
				num = (short)1441398785;
				if (num != 0)
				{
				}
				num = (short)1267662848;
				if (num != 0)
				{
				}
				return this.scanWideConventionalCarrierDetectRequired_A7611.Applicable;
			}
			set
			{
				short num = (short)697625706;
				short num2 = num;
				num = (short)1441066090;
				switch (num2 == num)
				{
				}
				num = (short)993984512;
				short num3 = num;
				num = (short)1223294977;
				if (num != 0)
				{
				}
				num = (short)1784283136;
				if (num != 0)
				{
				}
				this.scanWideConventionalCarrierDetectRequired_A7611.Applicable = value;
			}
		}

		// Token: 0x17001332 RID: 4914
		// (get) Token: 0x0600265D RID: 9821 RVA: 0x00258590 File Offset: 0x00256790
		// (set) Token: 0x0600265E RID: 9822 RVA: 0x00258644 File Offset: 0x00256844
		public bool ScanWideConventionalCarrierDetectRequired_A7611_Valid
		{
			get
			{
				short num = (short)737613889;
				short num2 = num;
				num = (short)1917589569;
				switch (num2 == num)
				{
				}
				num = (short)1192951808;
				short num3 = num;
				num = (short)441253888;
				if (num != 0)
				{
				}
				num = (short)1779826689;
				if (num != 0)
				{
				}
				return this.scanWideConventionalCarrierDetectRequired_A7611.Valid;
			}
			set
			{
				short num = (short)390090434;
				short num2 = num;
				num = (short)55332546;
				switch (num2 == num)
				{
				}
				num = (short)1726873600;
				short num3 = num;
				num = (short)1931214849;
				if (num != 0)
				{
				}
				num = (short)1577648128;
				if (num != 0)
				{
				}
				this.scanWideConventionalCarrierDetectRequired_A7611.Valid = value;
			}
		}

		// Token: 0x17001333 RID: 4915
		// (get) Token: 0x0600265F RID: 9823 RVA: 0x002586F8 File Offset: 0x002568F8
		// (set) Token: 0x06002660 RID: 9824 RVA: 0x002587AC File Offset: 0x002569AC
		public bool ScanWideConventionalCarrierDetectRequired_A7611_Visible
		{
			get
			{
				short num = (short)1774293883;
				short num2 = num;
				num = (short)1452249979;
				switch (num2 == num)
				{
				}
				num = (short)679936000;
				short num3 = num;
				num = (short)1020526593;
				if (num != 0)
				{
				}
				num = (short)351666176;
				if (num != 0)
				{
				}
				return this.scanWideConventionalCarrierDetectRequired_A7611.Visible;
			}
			set
			{
				short num = (short)1971473844;
				short num2 = num;
				num = (short)1047285172;
				switch (num2 == num)
				{
				}
				num = (short)1816592384;
				short num3 = num;
				num = (short)465502208;
				if (num != 0)
				{
				}
				num = (short)1697579009;
				if (num != 0)
				{
				}
				this.scanWideConventionalCarrierDetectRequired_A7611.Visible = value;
			}
		}

		// Token: 0x17001334 RID: 4916
		// (get) Token: 0x06002661 RID: 9825 RVA: 0x00258860 File Offset: 0x00256A60
		// (set) Token: 0x06002662 RID: 9826 RVA: 0x00258914 File Offset: 0x00256B14
		public bool ScanWideConventionalCarrierDetectRequired_A7611_Editable
		{
			get
			{
				short num = (short)546829359;
				short num2 = num;
				num = (short)29357103;
				switch (num2 == num)
				{
				}
				num = (short)901644288;
				short num3 = num;
				num = (short)150601729;
				if (num != 0)
				{
				}
				num = (short)1956839424;
				if (num != 0)
				{
				}
				return this.scanWideConventionalCarrierDetectRequired_A7611.Editable;
			}
			set
			{
				short num = (short)1688862721;
				if (num != 0)
				{
				}
				num = (short)364706252;
				short num2 = num;
				num = (short)1326905804;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1670643712;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)70844416;
				if (num != 0)
				{
				}
				this.scanWideConventionalCarrierDetectRequired_A7611.Editable = value;
			}
		}

		// Token: 0x17001335 RID: 4917
		// (get) Token: 0x06002663 RID: 9827 RVA: 0x002589C8 File Offset: 0x00256BC8
		internal string ScanWideConventionalCarrierDetectRequired_A7611_UILabel
		{
			get
			{
				short num = (short)934362390;
				short num2 = num;
				num = (short)1546730774;
				switch (num2 == num)
				{
				}
				num = (short)1923940352;
				short num3 = num;
				num = (short)257425409;
				if (num != 0)
				{
				}
				num = (short)774504448;
				if (num != 0)
				{
				}
				return this.scanWideConventionalCarrierDetectRequired_A7611.UIName;
			}
		}

		// Token: 0x17001336 RID: 4918
		// (get) Token: 0x06002664 RID: 9828 RVA: 0x00258A7C File Offset: 0x00256C7C
		// (set) Token: 0x06002665 RID: 9829 RVA: 0x00258B30 File Offset: 0x00256D30
		internal bool ScanWideConventionalCarrierDetectRequired_A7611_HiddenStatic
		{
			get
			{
				short num = (short)1013383955;
				short num2 = num;
				num = (short)1581384467;
				switch (num2 == num)
				{
				}
				num = (short)319619072;
				short num3 = num;
				num = (short)768081921;
				if (num != 0)
				{
				}
				num = (short)491782144;
				if (num != 0)
				{
				}
				return this.scanWideConventionalCarrierDetectRequired_A7611.HiddenStatic;
			}
			set
			{
				short num = (short)280478129;
				short num2 = num;
				num = (short)1064157617;
				switch (num2 == num)
				{
				}
				num = (short)2113601536;
				short num3 = num;
				num = (short)1381761024;
				if (num != 0)
				{
				}
				num = (short)1875902465;
				if (num != 0)
				{
				}
				this.scanWideConventionalCarrierDetectRequired_A7611.HiddenStatic = value;
			}
		}

		// Token: 0x17001337 RID: 4919
		// (get) Token: 0x06002666 RID: 9830 RVA: 0x00258BE8 File Offset: 0x00256DE8
		// (set) Token: 0x06002667 RID: 9831 RVA: 0x00258C9C File Offset: 0x00256E9C
		internal bool ScanWideConventionalCarrierDetectRequired_A7611_HiddenDynamic
		{
			get
			{
				short num = (short)307363841;
				if (num != 0)
				{
				}
				num = (short)32853301;
				short num2 = num;
				num = (short)428821813;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1337720832;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1216151552;
				if (num != 0)
				{
				}
				return this.scanWideConventionalCarrierDetectRequired_A7611.HiddenDynamic;
			}
			set
			{
				short num = (short)284701867;
				short num2 = num;
				num = (short)193934507;
				switch (num2 == num)
				{
				}
				num = (short)1871904768;
				short num3 = num;
				num = (short)228786177;
				if (num != 0)
				{
				}
				num = (short)1105330176;
				if (num != 0)
				{
				}
				this.scanWideConventionalCarrierDetectRequired_A7611.HiddenDynamic = value;
			}
		}

		// Token: 0x17001338 RID: 4920
		// (get) Token: 0x06002668 RID: 9832 RVA: 0x00258D50 File Offset: 0x00256F50
		public bool ScanWideConventionalCarrierDetectRequired_A7611_HasDiffs
		{
			get
			{
				short num = (short)331530784;
				short num2 = num;
				num = (short)1210040864;
				switch (num2 == num)
				{
				}
				num = (short)599654400;
				short num3 = num;
				num = (short)1627914240;
				if (num != 0)
				{
				}
				num = (short)1763180545;
				if (num != 0)
				{
				}
				return this.scanWideConventionalCarrierDetectRequired_A7611._HasDiffs;
			}
		}

		// Token: 0x17001339 RID: 4921
		// (get) Token: 0x06002669 RID: 9833 RVA: 0x00258E04 File Offset: 0x00257004
		// (set) Token: 0x0600266A RID: 9834 RVA: 0x00258EB8 File Offset: 0x002570B8
		public int ScanWideConventionalMonitorHoldTimesec_A8543Value
		{
			get
			{
				short num = (short)1235056793;
				short num2 = num;
				num = (short)1512011929;
				switch (num2 == num)
				{
				}
				num = (short)2092302336;
				short num3 = num;
				num = (short)1758789633;
				if (num != 0)
				{
				}
				num = (short)27131904;
				if (num != 0)
				{
				}
				return this.scanWideConventionalMonitorHoldTimesec_A8543.Value;
			}
			set
			{
				short num = (short)993939026;
				short num2 = num;
				num = (short)1182355026;
				switch (num2 == num)
				{
				}
				num = (short)356712448;
				short num3 = num;
				num = (short)1033895937;
				if (num != 0)
				{
				}
				num = (short)1447428096;
				if (num != 0)
				{
				}
				this.scanWideConventionalMonitorHoldTimesec_A8543.Value = value;
			}
		}

		// Token: 0x1700133A RID: 4922
		// (get) Token: 0x0600266B RID: 9835 RVA: 0x00258F6C File Offset: 0x0025716C
		public global::AcpBusinessLayer.AcpSimpleRangeField ScanWideConventionalMonitorHoldTimesec_A8543
		{
			get
			{
				short num = (short)1330423107;
				short num2 = num;
				num = (short)752723267;
				switch (num2 == num)
				{
				}
				num = (short)339738624;
				short num3 = num;
				num = (short)295239681;
				if (num != 0)
				{
				}
				num = (short)1581580288;
				if (num != 0)
				{
				}
				return this.scanWideConventionalMonitorHoldTimesec_A8543;
			}
		}

		// Token: 0x1700133B RID: 4923
		// (get) Token: 0x0600266C RID: 9836 RVA: 0x0025901C File Offset: 0x0025721C
		// (set) Token: 0x0600266D RID: 9837 RVA: 0x002590D4 File Offset: 0x002572D4
		public string ScanWideConventionalMonitorHoldTimesec_A8543_UIValue
		{
			get
			{
				short num = (short)836017927;
				short num2 = num;
				num = (short)1653382919;
				switch (num2 == num)
				{
				}
				num = (short)1228144640;
				short num3 = num;
				num = (short)1800732672;
				if (num != 0)
				{
				}
				num = (short)1665597441;
				if (num != 0)
				{
				}
				return this.scanWideConventionalMonitorHoldTimesec_A8543.UIValue;
			}
			set
			{
				short num = (short)949015305;
				short num2 = num;
				num = (short)1915015945;
				switch (num2 == num)
				{
				}
				num = (short)1031536640;
				short num3 = num;
				num = (short)940900353;
				if (num != 0)
				{
				}
				num = (short)280625152;
				if (num != 0)
				{
				}
				this.scanWideConventionalMonitorHoldTimesec_A8543.UIValue = value;
			}
		}

		// Token: 0x1700133C RID: 4924
		// (get) Token: 0x0600266E RID: 9838 RVA: 0x00259188 File Offset: 0x00257388
		// (set) Token: 0x0600266F RID: 9839 RVA: 0x0025923C File Offset: 0x0025743C
		internal int ScanWideConventionalMonitorHoldTimesec_A8543Min
		{
			get
			{
				short num = (short)1149259171;
				short num2 = num;
				num = (short)694111651;
				switch (num2 == num)
				{
				}
				num = (short)105119744;
				short num3 = num;
				num = (short)1184038913;
				if (num != 0)
				{
				}
				num = (short)1769537536;
				if (num != 0)
				{
				}
				return this.scanWideConventionalMonitorHoldTimesec_A8543.Min;
			}
			set
			{
				short num = (short)2034891433;
				short num2 = num;
				num = (short)1065155241;
				switch (num2 == num)
				{
				}
				num = (short)349831168;
				short num3 = num;
				num = (short)1411448833;
				if (num != 0)
				{
				}
				num = (short)1216544768;
				if (num != 0)
				{
				}
				this.scanWideConventionalMonitorHoldTimesec_A8543.Min = value;
			}
		}

		// Token: 0x1700133D RID: 4925
		// (get) Token: 0x06002670 RID: 9840 RVA: 0x002592F0 File Offset: 0x002574F0
		// (set) Token: 0x06002671 RID: 9841 RVA: 0x002593A8 File Offset: 0x002575A8
		internal int ScanWideConventionalMonitorHoldTimesec_A8543Max
		{
			get
			{
				short num = (short)456480142;
				short num2 = num;
				num = (short)1621841294;
				switch (num2 == num)
				{
				}
				num = (short)319029248;
				short num3 = num;
				num = (short)519831552;
				if (num != 0)
				{
				}
				num = (short)1211039745;
				if (num != 0)
				{
				}
				return this.scanWideConventionalMonitorHoldTimesec_A8543.Max;
			}
			set
			{
				short num = (short)327276938;
				short num2 = num;
				num = (short)703519114;
				switch (num2 == num)
				{
				}
				num = (short)691208192;
				short num3 = num;
				num = (short)1086324737;
				if (num != 0)
				{
				}
				num = (short)131989504;
				if (num != 0)
				{
				}
				this.scanWideConventionalMonitorHoldTimesec_A8543.Max = value;
			}
		}

		// Token: 0x1700133E RID: 4926
		// (get) Token: 0x06002672 RID: 9842 RVA: 0x0025945C File Offset: 0x0025765C
		// (set) Token: 0x06002673 RID: 9843 RVA: 0x00259514 File Offset: 0x00257714
		internal int ScanWideConventionalMonitorHoldTimesec_A8543Step
		{
			get
			{
				short num = (short)313482852;
				short num2 = num;
				num = (short)1551523428;
				switch (num2 == num)
				{
				}
				num = (short)1692925952;
				short num3 = num;
				num = (short)147390465;
				if (num != 0)
				{
				}
				num = (short)1722089472;
				if (num != 0)
				{
				}
				return this.scanWideConventionalMonitorHoldTimesec_A8543.StepSize;
			}
			set
			{
				short num = (short)1816933195;
				short num2 = num;
				num = (short)1467364171;
				switch (num2 == num)
				{
				}
				num = (short)67698688;
				short num3 = num;
				num = (short)1267728384;
				if (num != 0)
				{
				}
				num = (short)346554369;
				if (num != 0)
				{
				}
				this.scanWideConventionalMonitorHoldTimesec_A8543.StepSize = value;
			}
		}

		// Token: 0x1700133F RID: 4927
		// (get) Token: 0x06002674 RID: 9844 RVA: 0x002595CC File Offset: 0x002577CC
		// (set) Token: 0x06002675 RID: 9845 RVA: 0x0025967C File Offset: 0x0025787C
		public bool ScanWideConventionalMonitorHoldTimesec_A8543_Applicable
		{
			get
			{
				short num = (short)2010261036;
				short num2 = num;
				num = (short)711403052;
				switch (num2 == num)
				{
				}
				num = (short)1014824960;
				short num3 = num;
				num = (short)1670709248;
				if (num != 0)
				{
				}
				num = (short)1698758657;
				if (num != 0)
				{
				}
				return this.scanWideConventionalMonitorHoldTimesec_A8543.Applicable;
			}
			set
			{
				short num = (short)886094075;
				short num2 = num;
				num = (short)1549646075;
				switch (num2 == num)
				{
				}
				num = (short)1894645760;
				short num3 = num;
				num = (short)1472528385;
				if (num != 0)
				{
				}
				num = (short)923009024;
				if (num != 0)
				{
				}
				this.scanWideConventionalMonitorHoldTimesec_A8543.Applicable = value;
			}
		}

		// Token: 0x17001340 RID: 4928
		// (get) Token: 0x06002676 RID: 9846 RVA: 0x00259734 File Offset: 0x00257934
		// (set) Token: 0x06002677 RID: 9847 RVA: 0x002597E8 File Offset: 0x002579E8
		public bool ScanWideConventionalMonitorHoldTimesec_A8543_Valid
		{
			get
			{
				short num = (short)1416501739;
				short num2 = num;
				num = (short)457120235;
				switch (num2 == num)
				{
				}
				num = (short)1469775872;
				short num3 = num;
				num = (short)1337524225;
				if (num != 0)
				{
				}
				num = (short)1713700864;
				if (num != 0)
				{
				}
				return this.scanWideConventionalMonitorHoldTimesec_A8543.Valid;
			}
			set
			{
				short num = (short)1454506974;
				short num2 = num;
				num = (short)229835742;
				switch (num2 == num)
				{
				}
				num = (short)797048832;
				short num3 = num;
				num = (short)1382416384;
				if (num != 0)
				{
				}
				num = (short)87883777;
				if (num != 0)
				{
				}
				this.scanWideConventionalMonitorHoldTimesec_A8543.Valid = value;
			}
		}

		// Token: 0x17001341 RID: 4929
		// (get) Token: 0x06002678 RID: 9848 RVA: 0x002598A0 File Offset: 0x00257AA0
		// (set) Token: 0x06002679 RID: 9849 RVA: 0x00259954 File Offset: 0x00257B54
		public bool ScanWideConventionalMonitorHoldTimesec_A8543_Visible
		{
			get
			{
				short num = (short)1500577793;
				if (num != 0)
				{
				}
				num = (short)945800967;
				short num2 = num;
				num = (short)711247623;
				switch (num2 == num)
				{
				default:
				{
					num = (short)734396416;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)931659776;
				if (num != 0)
				{
				}
				return this.scanWideConventionalMonitorHoldTimesec_A8543.Visible;
			}
			set
			{
				short num = (short)20556417;
				short num2 = num;
				num = (short)1444784769;
				switch (num2 == num)
				{
				}
				num = (short)2066874368;
				short num3 = num;
				num = (short)1236664321;
				if (num != 0)
				{
				}
				num = (short)1628831744;
				if (num != 0)
				{
				}
				this.scanWideConventionalMonitorHoldTimesec_A8543.Visible = value;
			}
		}

		// Token: 0x17001342 RID: 4930
		// (get) Token: 0x0600267A RID: 9850 RVA: 0x00259A0C File Offset: 0x00257C0C
		// (set) Token: 0x0600267B RID: 9851 RVA: 0x00259ABC File Offset: 0x00257CBC
		public bool ScanWideConventionalMonitorHoldTimesec_A8543_Editable
		{
			get
			{
				short num = (short)1528262308;
				short num2 = num;
				num = (short)1027698340;
				switch (num2 == num)
				{
				}
				num = (short)979566592;
				short num3 = num;
				num = (short)782696449;
				if (num != 0)
				{
				}
				num = (short)512425984;
				if (num != 0)
				{
				}
				return this.scanWideConventionalMonitorHoldTimesec_A8543.Editable;
			}
			set
			{
				short num = (short)758489120;
				short num2 = num;
				num = (short)1173528608;
				switch (num2 == num)
				{
				}
				num = (short)306315264;
				short num3 = num;
				num = (short)829947905;
				if (num != 0)
				{
				}
				num = (short)796655616;
				if (num != 0)
				{
				}
				this.scanWideConventionalMonitorHoldTimesec_A8543.Editable = value;
			}
		}

		// Token: 0x17001343 RID: 4931
		// (get) Token: 0x0600267C RID: 9852 RVA: 0x00259B70 File Offset: 0x00257D70
		internal string ScanWideConventionalMonitorHoldTimesec_A8543_UILabel
		{
			get
			{
				short num = (short)1093521058;
				short num2 = num;
				num = (short)2003553954;
				switch (num2 == num)
				{
				}
				num = (short)401670144;
				short num3 = num;
				num = (short)530382848;
				if (num != 0)
				{
				}
				num = (short)307757057;
				if (num != 0)
				{
				}
				return this.scanWideConventionalMonitorHoldTimesec_A8543.UIName;
			}
		}

		// Token: 0x17001344 RID: 4932
		// (get) Token: 0x0600267D RID: 9853 RVA: 0x00259C24 File Offset: 0x00257E24
		// (set) Token: 0x0600267E RID: 9854 RVA: 0x00259CD4 File Offset: 0x00257ED4
		internal bool ScanWideConventionalMonitorHoldTimesec_A8543_HiddenStatic
		{
			get
			{
				short num = (short)781792451;
				short num2 = num;
				num = (short)1490040003;
				switch (num2 == num)
				{
				}
				num = (short)1368981504;
				short num3 = num;
				num = (short)1233387520;
				if (num != 0)
				{
				}
				num = (short)55902209;
				if (num != 0)
				{
				}
				return this.scanWideConventionalMonitorHoldTimesec_A8543.HiddenStatic;
			}
			set
			{
				short num = (short)91750401;
				if (num != 0)
				{
				}
				num = (short)1732013744;
				short num2 = num;
				num = (short)368799408;
				switch (num2 == num)
				{
				default:
				{
					num = (short)506855424;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1376321536;
				if (num != 0)
				{
				}
				this.scanWideConventionalMonitorHoldTimesec_A8543.HiddenStatic = value;
			}
		}

		// Token: 0x17001345 RID: 4933
		// (get) Token: 0x0600267F RID: 9855 RVA: 0x00259D8C File Offset: 0x00257F8C
		// (set) Token: 0x06002680 RID: 9856 RVA: 0x00259E40 File Offset: 0x00258040
		internal bool ScanWideConventionalMonitorHoldTimesec_A8543_HiddenDynamic
		{
			get
			{
				short num = (short)740884481;
				if (num != 0)
				{
				}
				num = (short)1147647153;
				short num2 = num;
				num = (short)668251313;
				switch (num2 == num)
				{
				default:
				{
					num = (short)472121344;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)292552704;
				if (num != 0)
				{
				}
				return this.scanWideConventionalMonitorHoldTimesec_A8543.HiddenDynamic;
			}
			set
			{
				short num = (short)487222906;
				short num2 = num;
				num = (short)1216179834;
				switch (num2 == num)
				{
				}
				num = (short)525139968;
				short num3 = num;
				num = (short)38141953;
				if (num != 0)
				{
				}
				num = (short)861732864;
				if (num != 0)
				{
				}
				this.scanWideConventionalMonitorHoldTimesec_A8543.HiddenDynamic = value;
			}
		}

		// Token: 0x17001346 RID: 4934
		// (get) Token: 0x06002681 RID: 9857 RVA: 0x00259EF4 File Offset: 0x002580F4
		public bool ScanWideConventionalMonitorHoldTimesec_A8543_HasDiffs
		{
			get
			{
				short num = (short)1975617151;
				short num2 = num;
				num = (short)1751025279;
				switch (num2 == num)
				{
				}
				num = (short)1142882304;
				short num3 = num;
				num = (short)1533935617;
				if (num != 0)
				{
				}
				num = (short)370475008;
				if (num != 0)
				{
				}
				return this.scanWideConventionalMonitorHoldTimesec_A8543._HasDiffs;
			}
		}

		// Token: 0x17001347 RID: 4935
		// (get) Token: 0x06002682 RID: 9858 RVA: 0x00259FA8 File Offset: 0x002581A8
		// (set) Token: 0x06002683 RID: 9859 RVA: 0x0025A05C File Offset: 0x0025825C
		public bool ScanWideConventionalPriorityChannelMarking_A8750Value
		{
			get
			{
				short num = (short)1614741505;
				if (num != 0)
				{
				}
				num = (short)415128245;
				short num2 = num;
				num = (short)1078352565;
				switch (num2 == num)
				{
				}
				num = (short)1608908800;
				short num3 = num;
				num = (short)5701632;
				if (num != 0)
				{
				}
				return this.scanWideConventionalPriorityChannelMarking_A8750.Value;
			}
			set
			{
				short num = (short)1377894241;
				short num2 = num;
				num = (short)1993277281;
				switch (num2 == num)
				{
				}
				num = (short)1542062081;
				if (num != 0)
				{
				}
				num = (short)1549664256;
				short num3 = num;
				num = (short)313262080;
				if (num != 0)
				{
				}
				this.scanWideConventionalPriorityChannelMarking_A8750.Value = value;
			}
		}

		// Token: 0x17001348 RID: 4936
		// (get) Token: 0x06002684 RID: 9860 RVA: 0x0025A110 File Offset: 0x00258310
		public global::AcpBusinessLayer.AcpField<bool> ScanWideConventionalPriorityChannelMarking_A8750
		{
			get
			{
				short num = (short)303169537;
				if (num != 0)
				{
				}
				num = (short)1140669662;
				short num2 = num;
				num = (short)96353502;
				switch (num2 == num)
				{
				}
				num = (short)113377280;
				short num3 = num;
				num = (short)1326907392;
				if (num != 0)
				{
				}
				return this.scanWideConventionalPriorityChannelMarking_A8750;
			}
		}

		// Token: 0x17001349 RID: 4937
		// (get) Token: 0x06002685 RID: 9861 RVA: 0x0025A1C0 File Offset: 0x002583C0
		// (set) Token: 0x06002686 RID: 9862 RVA: 0x0025A278 File Offset: 0x00258478
		public bool ScanWideConventionalPriorityChannelMarking_A8750_UIValue
		{
			get
			{
				short num = (short)865402881;
				if (num != 0)
				{
				}
				num = (short)1821537071;
				short num2 = num;
				num = (short)946434863;
				switch (num2 == num)
				{
				}
				num = (short)1017970688;
				short num3 = num;
				num = (short)518127616;
				if (num != 0)
				{
				}
				return this.scanWideConventionalPriorityChannelMarking_A8750.Value;
			}
			set
			{
				short num = (short)274231293;
				short num2 = num;
				num = (short)618950653;
				switch (num2 == num)
				{
				}
				num = (short)688914433;
				if (num != 0)
				{
				}
				num = (short)1029898240;
				short num3 = num;
				num = (short)1095237632;
				if (num != 0)
				{
				}
				this.scanWideConventionalPriorityChannelMarking_A8750.Value = value;
			}
		}

		// Token: 0x1700134A RID: 4938
		// (get) Token: 0x06002687 RID: 9863 RVA: 0x0025A330 File Offset: 0x00258530
		// (set) Token: 0x06002688 RID: 9864 RVA: 0x0025A3E8 File Offset: 0x002585E8
		public bool ScanWideConventionalPriorityChannelMarking_A8750_Applicable
		{
			get
			{
				short num = (short)831514504;
				short num2 = num;
				num = (short)1455679368;
				switch (num2 == num)
				{
				}
				num = (short)1481768960;
				if (num != 0)
				{
				}
				num = (short)87883776;
				short num3 = num;
				num = (short)2070478849;
				if (num != 0)
				{
				}
				return this.scanWideConventionalPriorityChannelMarking_A8750.Applicable;
			}
			set
			{
				short num = (short)1511814258;
				short num2 = num;
				num = (short)1696625778;
				switch (num2 == num)
				{
				}
				num = (short)1148583936;
				if (num != 0)
				{
				}
				num = (short)65732608;
				short num3 = num;
				num = (short)441450497;
				if (num != 0)
				{
				}
				this.scanWideConventionalPriorityChannelMarking_A8750.Applicable = value;
			}
		}

		// Token: 0x1700134B RID: 4939
		// (get) Token: 0x06002689 RID: 9865 RVA: 0x0025A49C File Offset: 0x0025869C
		// (set) Token: 0x0600268A RID: 9866 RVA: 0x0025A554 File Offset: 0x00258754
		public bool ScanWideConventionalPriorityChannelMarking_A8750_Valid
		{
			get
			{
				short num = (short)1326560707;
				short num2 = num;
				num = (short)1921693123;
				switch (num2 == num)
				{
				}
				num = (short)1881210881;
				if (num != 0)
				{
				}
				num = (short)1370554368;
				short num3 = num;
				num = (short)757596160;
				if (num != 0)
				{
				}
				return this.scanWideConventionalPriorityChannelMarking_A8750.Valid;
			}
			set
			{
				short num = (short)1538038267;
				short num2 = num;
				num = (short)1876662779;
				switch (num2 == num)
				{
				}
				num = (short)1434320896;
				if (num != 0)
				{
				}
				num = (short)1551302656;
				short num3 = num;
				num = (short)1527971841;
				if (num != 0)
				{
				}
				this.scanWideConventionalPriorityChannelMarking_A8750.Valid = value;
			}
		}

		// Token: 0x1700134C RID: 4940
		// (get) Token: 0x0600268B RID: 9867 RVA: 0x0025A60C File Offset: 0x0025880C
		// (set) Token: 0x0600268C RID: 9868 RVA: 0x0025A6C4 File Offset: 0x002588C4
		public bool ScanWideConventionalPriorityChannelMarking_A8750_Visible
		{
			get
			{
				short num = (short)163652242;
				short num2 = num;
				num = (short)456532626;
				switch (num2 == num)
				{
				}
				num = (short)656211968;
				if (num != 0)
				{
				}
				num = (short)2074345472;
				short num3 = num;
				num = (short)436469761;
				if (num != 0)
				{
				}
				return this.scanWideConventionalPriorityChannelMarking_A8750.Visible;
			}
			set
			{
				short num = (short)1685632750;
				short num2 = num;
				num = (short)579188462;
				switch (num2 == num)
				{
				}
				num = (short)1273036801;
				if (num != 0)
				{
				}
				num = (short)1194196992;
				short num3 = num;
				num = (short)1593180160;
				if (num != 0)
				{
				}
				this.scanWideConventionalPriorityChannelMarking_A8750.Visible = value;
			}
		}

		// Token: 0x1700134D RID: 4941
		// (get) Token: 0x0600268D RID: 9869 RVA: 0x0025A780 File Offset: 0x00258980
		// (set) Token: 0x0600268E RID: 9870 RVA: 0x0025A834 File Offset: 0x00258A34
		public bool ScanWideConventionalPriorityChannelMarking_A8750_Editable
		{
			get
			{
				short num = (short)1066833413;
				short num2 = num;
				num = (short)706057733;
				switch (num2 == num)
				{
				}
				num = (short)1035010048;
				if (num != 0)
				{
				}
				num = (short)1592066048;
				short num3 = num;
				num = (short)1885667329;
				if (num != 0)
				{
				}
				return this.scanWideConventionalPriorityChannelMarking_A8750.Editable;
			}
			set
			{
				short num = (short)684526423;
				short num2 = num;
				num = (short)1387203415;
				switch (num2 == num)
				{
				}
				num = (short)767426561;
				if (num != 0)
				{
				}
				num = (short)161284096;
				short num3 = num;
				num = (short)1711734784;
				if (num != 0)
				{
				}
				this.scanWideConventionalPriorityChannelMarking_A8750.Editable = value;
			}
		}

		// Token: 0x1700134E RID: 4942
		// (get) Token: 0x0600268F RID: 9871 RVA: 0x0025A8EC File Offset: 0x00258AEC
		internal string ScanWideConventionalPriorityChannelMarking_A8750_UILabel
		{
			get
			{
				short num = (short)1814680060;
				short num2 = num;
				num = (short)833540604;
				switch (num2 == num)
				{
				}
				num = (short)1866465280;
				if (num != 0)
				{
				}
				num = (short)1088880640;
				short num3 = num;
				num = (short)536870913;
				if (num != 0)
				{
				}
				return this.scanWideConventionalPriorityChannelMarking_A8750.UIName;
			}
		}

		// Token: 0x1700134F RID: 4943
		// (get) Token: 0x06002690 RID: 9872 RVA: 0x0025A9A4 File Offset: 0x00258BA4
		// (set) Token: 0x06002691 RID: 9873 RVA: 0x0025AA54 File Offset: 0x00258C54
		internal bool ScanWideConventionalPriorityChannelMarking_A8750_HiddenStatic
		{
			get
			{
				short num = (short)1948534919;
				short num2 = num;
				num = (short)1511147655;
				switch (num2 == num)
				{
				}
				num = (short)1197080577;
				if (num != 0)
				{
				}
				num = (short)1348141056;
				short num3 = num;
				num = (short)1362821120;
				if (num != 0)
				{
				}
				return this.scanWideConventionalPriorityChannelMarking_A8750.HiddenStatic;
			}
			set
			{
				short num = (short)872033601;
				short num2 = num;
				num = (short)1665805633;
				switch (num2 == num)
				{
				}
				num = (short)1274675201;
				if (num != 0)
				{
				}
				num = (short)552337408;
				short num3 = num;
				num = (short)761135104;
				if (num != 0)
				{
				}
				this.scanWideConventionalPriorityChannelMarking_A8750.HiddenStatic = value;
			}
		}

		// Token: 0x17001350 RID: 4944
		// (get) Token: 0x06002692 RID: 9874 RVA: 0x0025AB0C File Offset: 0x00258D0C
		// (set) Token: 0x06002693 RID: 9875 RVA: 0x0025ABC0 File Offset: 0x00258DC0
		internal bool ScanWideConventionalPriorityChannelMarking_A8750_HiddenDynamic
		{
			get
			{
				short num = (short)22611543;
				short num2 = num;
				num = (short)1554646615;
				switch (num2 == num)
				{
				}
				num = (short)605290497;
				if (num != 0)
				{
				}
				num = (short)673710080;
				short num3 = num;
				num = (short)1143078912;
				if (num != 0)
				{
				}
				return this.scanWideConventionalPriorityChannelMarking_A8750.HiddenDynamic;
			}
			set
			{
				short num = (short)1473975008;
				short num2 = num;
				num = (short)771363552;
				switch (num2 == num)
				{
				}
				num = (short)1111359488;
				if (num != 0)
				{
				}
				num = (short)1111556096;
				short num3 = num;
				num = (short)1772158977;
				if (num != 0)
				{
				}
				this.scanWideConventionalPriorityChannelMarking_A8750.HiddenDynamic = value;
			}
		}

		// Token: 0x17001351 RID: 4945
		// (get) Token: 0x06002694 RID: 9876 RVA: 0x0025AC78 File Offset: 0x00258E78
		public bool ScanWideConventionalPriorityChannelMarking_A8750_HasDiffs
		{
			get
			{
				short num = (short)108706268;
				short num2 = num;
				num = (short)1625012700;
				switch (num2 == num)
				{
				}
				num = (short)2139881473;
				if (num != 0)
				{
				}
				num = (short)220004352;
				short num3 = num;
				num = (short)654049280;
				if (num != 0)
				{
				}
				return this.scanWideConventionalPriorityChannelMarking_A8750._HasDiffs;
			}
		}

		// Token: 0x17001352 RID: 4946
		// (get) Token: 0x06002695 RID: 9877 RVA: 0x0025AD2C File Offset: 0x00258F2C
		// (set) Token: 0x06002696 RID: 9878 RVA: 0x0025ADE0 File Offset: 0x00258FE0
		public int ScanWideConventionalRSSIVotingThreshold_A8997Value
		{
			get
			{
				short num = (short)98376566;
				short num2 = num;
				num = (short)1803361142;
				switch (num2 == num)
				{
				}
				num = (short)861863937;
				if (num != 0)
				{
				}
				num = (short)668794880;
				short num3 = num;
				num = (short)286064640;
				if (num != 0)
				{
				}
				return this.scanWideConventionalRSSIVotingThreshold_A8997.Value;
			}
			set
			{
				short num = (short)554331470;
				short num2 = num;
				num = (short)941059406;
				switch (num2 == num)
				{
				}
				num = (short)1494745088;
				if (num != 0)
				{
				}
				num = (short)641925120;
				short num3 = num;
				num = (short)582156289;
				if (num != 0)
				{
				}
				this.scanWideConventionalRSSIVotingThreshold_A8997.Value = value;
			}
		}

		// Token: 0x17001353 RID: 4947
		// (get) Token: 0x06002697 RID: 9879 RVA: 0x0025AE94 File Offset: 0x00259094
		public global::AcpBusinessLayer.AcpSimpleRangeField ScanWideConventionalRSSIVotingThreshold_A8997
		{
			get
			{
				short num = (short)508400825;
				short num2 = num;
				num = (short)1636930745;
				switch (num2 == num)
				{
				}
				num = (short)1251672065;
				if (num != 0)
				{
				}
				num = (short)1674444800;
				short num3 = num;
				num = (short)595263488;
				if (num != 0)
				{
				}
				return this.scanWideConventionalRSSIVotingThreshold_A8997;
			}
		}

		// Token: 0x17001354 RID: 4948
		// (get) Token: 0x06002698 RID: 9880 RVA: 0x0025AF44 File Offset: 0x00259144
		// (set) Token: 0x06002699 RID: 9881 RVA: 0x0025AFFC File Offset: 0x002591FC
		public string ScanWideConventionalRSSIVotingThreshold_A8997_UIValue
		{
			get
			{
				short num = (short)1158086657;
				if (num != 0)
				{
				}
				num = (short)1546312259;
				short num2 = num;
				num = (short)702732867;
				switch (num2 == num)
				{
				}
				num = (short)1412431872;
				short num3 = num;
				num = (short)1971847168;
				if (num != 0)
				{
				}
				return this.scanWideConventionalRSSIVotingThreshold_A8997.UIValue;
			}
			set
			{
				short num = (short)1480130561;
				if (num != 0)
				{
				}
				num = (short)573437421;
				short num2 = num;
				num = (short)1767372269;
				switch (num2 == num)
				{
				}
				num = (short)419299328;
				short num3 = num;
				num = (short)360644608;
				if (num != 0)
				{
				}
				this.scanWideConventionalRSSIVotingThreshold_A8997.UIValue = value;
			}
		}

		// Token: 0x17001355 RID: 4949
		// (get) Token: 0x0600269A RID: 9882 RVA: 0x0025B0B0 File Offset: 0x002592B0
		// (set) Token: 0x0600269B RID: 9883 RVA: 0x0025B164 File Offset: 0x00259364
		public string ScanWideConventionalRSSIVotingThreshold_A8997_HexUIValue
		{
			get
			{
				short num = (short)1034450447;
				short num2 = num;
				num = (short)728725007;
				switch (num2 == num)
				{
				}
				num = (short)679673857;
				if (num != 0)
				{
				}
				num = (short)1278476288;
				short num3 = num;
				num = (short)173801472;
				if (num != 0)
				{
				}
				return this.scanWideConventionalRSSIVotingThreshold_A8997.HexUIValue;
			}
			set
			{
				short num = (short)712595601;
				short num2 = num;
				num = (short)422992017;
				switch (num2 == num)
				{
				}
				num = (short)250675200;
				if (num != 0)
				{
				}
				num = (short)517275648;
				short num3 = num;
				num = (short)1159593985;
				if (num != 0)
				{
				}
				this.scanWideConventionalRSSIVotingThreshold_A8997.HexUIValue = value;
			}
		}

		// Token: 0x17001356 RID: 4950
		// (get) Token: 0x0600269C RID: 9884 RVA: 0x0025B218 File Offset: 0x00259418
		// (set) Token: 0x0600269D RID: 9885 RVA: 0x0025B2CC File Offset: 0x002594CC
		internal int ScanWideConventionalRSSIVotingThreshold_A8997Min
		{
			get
			{
				short num = (short)1444041484;
				short num2 = num;
				num = (short)199054092;
				switch (num2 == num)
				{
				}
				num = (short)1399259137;
				if (num != 0)
				{
				}
				num = (short)1528102912;
				short num3 = num;
				num = (short)1621229568;
				if (num != 0)
				{
				}
				return this.scanWideConventionalRSSIVotingThreshold_A8997.Min;
			}
			set
			{
				short num = (short)338734357;
				short num2 = num;
				num = (short)1052028181;
				switch (num2 == num)
				{
				}
				num = (short)1025638401;
				if (num != 0)
				{
				}
				num = (short)547028992;
				short num3 = num;
				num = (short)1597112320;
				if (num != 0)
				{
				}
				this.scanWideConventionalRSSIVotingThreshold_A8997.Min = value;
			}
		}

		// Token: 0x17001357 RID: 4951
		// (get) Token: 0x0600269E RID: 9886 RVA: 0x0025B384 File Offset: 0x00259584
		// (set) Token: 0x0600269F RID: 9887 RVA: 0x0025B43C File Offset: 0x0025963C
		internal int ScanWideConventionalRSSIVotingThreshold_A8997Max
		{
			get
			{
				short num = (short)1614046728;
				short num2 = num;
				num = (short)632514056;
				switch (num2 == num)
				{
				}
				num = (short)849281025;
				if (num != 0)
				{
				}
				num = (short)71696384;
				short num3 = num;
				num = (short)1656684544;
				if (num != 0)
				{
				}
				return this.scanWideConventionalRSSIVotingThreshold_A8997.Max;
			}
			set
			{
				short num = (short)1460505948;
				short num2 = num;
				num = (short)448499036;
				switch (num2 == num)
				{
				}
				num = (short)713293824;
				if (num != 0)
				{
				}
				num = (short)70385664;
				short num3 = num;
				num = (short)243269633;
				if (num != 0)
				{
				}
				this.scanWideConventionalRSSIVotingThreshold_A8997.Max = value;
			}
		}

		// Token: 0x17001358 RID: 4952
		// (get) Token: 0x060026A0 RID: 9888 RVA: 0x0025B4F0 File Offset: 0x002596F0
		// (set) Token: 0x060026A1 RID: 9889 RVA: 0x0025B5A8 File Offset: 0x002597A8
		internal int ScanWideConventionalRSSIVotingThreshold_A8997Step
		{
			get
			{
				short num = (short)1653148136;
				short num2 = num;
				num = (short)1335429608;
				switch (num2 == num)
				{
				}
				num = (short)1032519681;
				if (num != 0)
				{
				}
				num = (short)1538195456;
				short num3 = num;
				num = (short)1547960320;
				if (num != 0)
				{
				}
				return this.scanWideConventionalRSSIVotingThreshold_A8997.StepSize;
			}
			set
			{
				short num = (short)1259706785;
				short num2 = num;
				num = (short)978033057;
				switch (num2 == num)
				{
				}
				num = (short)554172417;
				if (num != 0)
				{
				}
				num = (short)1442250752;
				short num3 = num;
				num = (short)1575419904;
				if (num != 0)
				{
				}
				this.scanWideConventionalRSSIVotingThreshold_A8997.StepSize = value;
			}
		}

		// Token: 0x17001359 RID: 4953
		// (get) Token: 0x060026A2 RID: 9890 RVA: 0x0025B660 File Offset: 0x00259860
		// (set) Token: 0x060026A3 RID: 9891 RVA: 0x0025B714 File Offset: 0x00259914
		public bool ScanWideConventionalRSSIVotingThreshold_A8997_Applicable
		{
			get
			{
				short num = (short)2010644481;
				if (num != 0)
				{
				}
				num = (short)856307400;
				short num2 = num;
				num = (short)2131310280;
				switch (num2 == num)
				{
				}
				num = (short)529072128;
				short num3 = num;
				num = (short)2028732416;
				if (num != 0)
				{
				}
				return this.scanWideConventionalRSSIVotingThreshold_A8997.Applicable;
			}
			set
			{
				short num = (short)676665480;
				short num2 = num;
				num = (short)405477512;
				switch (num2 == num)
				{
				}
				num = (short)131137537;
				if (num != 0)
				{
				}
				num = (short)94306304;
				short num3 = num;
				num = (short)856752128;
				if (num != 0)
				{
				}
				this.scanWideConventionalRSSIVotingThreshold_A8997.Applicable = value;
			}
		}

		// Token: 0x1700135A RID: 4954
		// (get) Token: 0x060026A4 RID: 9892 RVA: 0x0025B7D0 File Offset: 0x002599D0
		// (set) Token: 0x060026A5 RID: 9893 RVA: 0x0025B884 File Offset: 0x00259A84
		public bool ScanWideConventionalRSSIVotingThreshold_A8997_Valid
		{
			get
			{
				short num = (short)957315155;
				short num2 = num;
				num = (short)1814919251;
				switch (num2 == num)
				{
				}
				num = (short)622788609;
				if (num != 0)
				{
				}
				num = (short)1476788224;
				short num3 = num;
				num = (short)99024896;
				if (num != 0)
				{
				}
				return this.scanWideConventionalRSSIVotingThreshold_A8997.Valid;
			}
			set
			{
				short num = (short)882527809;
				short num2 = num;
				num = (short)910249537;
				switch (num2 == num)
				{
				}
				num = (short)4194304;
				if (num != 0)
				{
				}
				num = (short)1260781568;
				short num3 = num;
				num = (short)88932353;
				if (num != 0)
				{
				}
				this.scanWideConventionalRSSIVotingThreshold_A8997.Valid = value;
			}
		}

		// Token: 0x1700135B RID: 4955
		// (get) Token: 0x060026A6 RID: 9894 RVA: 0x0025B938 File Offset: 0x00259B38
		// (set) Token: 0x060026A7 RID: 9895 RVA: 0x0025B9F0 File Offset: 0x00259BF0
		public bool ScanWideConventionalRSSIVotingThreshold_A8997_Visible
		{
			get
			{
				short num = (short)1575992778;
				short num2 = num;
				num = (short)1634516426;
				switch (num2 == num)
				{
				}
				num = (short)1114701825;
				if (num != 0)
				{
				}
				num = (short)1235877888;
				short num3 = num;
				num = (short)866254848;
				if (num != 0)
				{
				}
				return this.scanWideConventionalRSSIVotingThreshold_A8997.Visible;
			}
			set
			{
				short num = (short)529195615;
				short num2 = num;
				num = (short)742253151;
				switch (num2 == num)
				{
				}
				num = (short)1250557952;
				if (num != 0)
				{
				}
				num = (short)1238564864;
				short num3 = num;
				num = (short)867106817;
				if (num != 0)
				{
				}
				this.scanWideConventionalRSSIVotingThreshold_A8997.Visible = value;
			}
		}

		// Token: 0x1700135C RID: 4956
		// (get) Token: 0x060026A8 RID: 9896 RVA: 0x0025BAA8 File Offset: 0x00259CA8
		// (set) Token: 0x060026A9 RID: 9897 RVA: 0x0025BB60 File Offset: 0x00259D60
		public bool ScanWideConventionalRSSIVotingThreshold_A8997_Editable
		{
			get
			{
				short num = (short)1404135820;
				short num2 = num;
				num = (short)15886732;
				switch (num2 == num)
				{
				}
				num = (short)1519648769;
				if (num != 0)
				{
				}
				num = (short)84082688;
				short num3 = num;
				num = (short)1801060352;
				if (num != 0)
				{
				}
				return this.scanWideConventionalRSSIVotingThreshold_A8997.Editable;
			}
			set
			{
				short num = (short)729904860;
				short num2 = num;
				num = (short)64124636;
				switch (num2 == num)
				{
				}
				num = (short)639696897;
				if (num != 0)
				{
				}
				num = (short)1478885376;
				short num3 = num;
				num = (short)1585774592;
				if (num != 0)
				{
				}
				this.scanWideConventionalRSSIVotingThreshold_A8997.Editable = value;
			}
		}

		// Token: 0x1700135D RID: 4957
		// (get) Token: 0x060026AA RID: 9898 RVA: 0x0025BC18 File Offset: 0x00259E18
		internal string ScanWideConventionalRSSIVotingThreshold_A8997_UILabel
		{
			get
			{
				short num = (short)1779613400;
				short num2 = num;
				num = (short)392609496;
				switch (num2 == num)
				{
				}
				num = (short)72351745;
				if (num != 0)
				{
				}
				num = (short)224722944;
				short num3 = num;
				num = (short)757858304;
				if (num != 0)
				{
				}
				return this.scanWideConventionalRSSIVotingThreshold_A8997.UIName;
			}
		}

		// Token: 0x1700135E RID: 4958
		// (get) Token: 0x060026AB RID: 9899 RVA: 0x0025BCCC File Offset: 0x00259ECC
		// (set) Token: 0x060026AC RID: 9900 RVA: 0x0025BD84 File Offset: 0x00259F84
		internal bool ScanWideConventionalRSSIVotingThreshold_A8997_HiddenStatic
		{
			get
			{
				short num = (short)891514984;
				short num2 = num;
				num = (short)2099671144;
				switch (num2 == num)
				{
				}
				num = (short)2133590017;
				if (num != 0)
				{
				}
				num = (short)1168441344;
				short num3 = num;
				num = (short)1236008960;
				if (num != 0)
				{
				}
				return this.scanWideConventionalRSSIVotingThreshold_A8997.HiddenStatic;
			}
			set
			{
				short num = (short)1823874815;
				short num2 = num;
				num = (short)1951014655;
				switch (num2 == num)
				{
				}
				num = (short)1462042625;
				if (num != 0)
				{
				}
				num = (short)121307136;
				short num3 = num;
				num = (short)1891827712;
				if (num != 0)
				{
				}
				this.scanWideConventionalRSSIVotingThreshold_A8997.HiddenStatic = value;
			}
		}

		// Token: 0x1700135F RID: 4959
		// (get) Token: 0x060026AD RID: 9901 RVA: 0x0025BE3C File Offset: 0x0025A03C
		// (set) Token: 0x060026AE RID: 9902 RVA: 0x0025BEF4 File Offset: 0x0025A0F4
		internal bool ScanWideConventionalRSSIVotingThreshold_A8997_HiddenDynamic
		{
			get
			{
				short num = (short)734066520;
				short num2 = num;
				num = (short)849803096;
				switch (num2 == num)
				{
				}
				num = (short)881655809;
				if (num != 0)
				{
				}
				num = (short)1171259392;
				short num3 = num;
				num = (short)1102643200;
				if (num != 0)
				{
				}
				return this.scanWideConventionalRSSIVotingThreshold_A8997.HiddenDynamic;
			}
			set
			{
				short num = (short)1043090672;
				short num2 = num;
				num = (short)1234128112;
				switch (num2 == num)
				{
				}
				num = (short)797704193;
				if (num != 0)
				{
				}
				num = (short)1971716096;
				short num3 = num;
				num = (short)407961600;
				if (num != 0)
				{
				}
				this.scanWideConventionalRSSIVotingThreshold_A8997.HiddenDynamic = value;
			}
		}

		// Token: 0x17001360 RID: 4960
		// (get) Token: 0x060026AF RID: 9903 RVA: 0x0025BFA8 File Offset: 0x0025A1A8
		public bool ScanWideConventionalRSSIVotingThreshold_A8997_HasDiffs
		{
			get
			{
				short num = (short)1419837441;
				if (num != 0)
				{
				}
				num = (short)1241919746;
				short num2 = num;
				num = (short)1082601730;
				switch (num2 == num)
				{
				}
				num = (short)781582336;
				short num3 = num;
				num = (short)1614151680;
				if (num != 0)
				{
				}
				return this.scanWideConventionalRSSIVotingThreshold_A8997._HasDiffs;
			}
		}

		// Token: 0x17001361 RID: 4961
		// (get) Token: 0x060026B0 RID: 9904 RVA: 0x0025C05C File Offset: 0x0025A25C
		// (set) Token: 0x060026B1 RID: 9905 RVA: 0x0025C110 File Offset: 0x0025A310
		public int ScanWideConventionalTimeBetweenPrioritySamplesms_A9376Value
		{
			get
			{
				short num = (short)1908317994;
				short num2 = num;
				num = (short)1409982250;
				switch (num2 == num)
				{
				}
				num = (short)1919614976;
				if (num != 0)
				{
				}
				num = (short)1491927040;
				short num3 = num;
				num = (short)819331073;
				if (num != 0)
				{
				}
				return this.scanWideConventionalTimeBetweenPrioritySamplesms_A9376.Value;
			}
			set
			{
				short num = (short)1912446119;
				short num2 = num;
				num = (short)321690791;
				switch (num2 == num)
				{
				}
				num = (short)802029569;
				if (num != 0)
				{
				}
				num = (short)1352597504;
				short num3 = num;
				num = (short)1759182848;
				if (num != 0)
				{
				}
				this.scanWideConventionalTimeBetweenPrioritySamplesms_A9376.Value = value;
			}
		}

		// Token: 0x17001362 RID: 4962
		// (get) Token: 0x060026B2 RID: 9906 RVA: 0x0025C1C8 File Offset: 0x0025A3C8
		public global::AcpBusinessLayer.AcpSimpleRangeField ScanWideConventionalTimeBetweenPrioritySamplesms_A9376
		{
			get
			{
				short num = (short)1955223448;
				short num2 = num;
				num = (short)1160140696;
				switch (num2 == num)
				{
				}
				num = (short)431226881;
				if (num != 0)
				{
				}
				num = (short)1254752256;
				short num3 = num;
				num = (short)1649344512;
				if (num != 0)
				{
				}
				return this.scanWideConventionalTimeBetweenPrioritySamplesms_A9376;
			}
		}

		// Token: 0x17001363 RID: 4963
		// (get) Token: 0x060026B3 RID: 9907 RVA: 0x0025C27C File Offset: 0x0025A47C
		// (set) Token: 0x060026B4 RID: 9908 RVA: 0x0025C330 File Offset: 0x0025A530
		public string ScanWideConventionalTimeBetweenPrioritySamplesms_A9376_UIValue
		{
			get
			{
				short num = (short)472490337;
				short num2 = num;
				num = (short)1177461089;
				switch (num2 == num)
				{
				}
				num = (short)8257537;
				if (num != 0)
				{
				}
				num = (short)1371078656;
				short num3 = num;
				num = (short)1530724352;
				if (num != 0)
				{
				}
				return this.scanWideConventionalTimeBetweenPrioritySamplesms_A9376.UIValue;
			}
			set
			{
				short num = (short)305475180;
				short num2 = num;
				num = (short)871509612;
				switch (num2 == num)
				{
				}
				num = (short)564527104;
				if (num != 0)
				{
				}
				num = (short)1542586368;
				short num3 = num;
				num = (short)1556348929;
				if (num != 0)
				{
				}
				this.scanWideConventionalTimeBetweenPrioritySamplesms_A9376.UIValue = value;
			}
		}

		// Token: 0x17001364 RID: 4964
		// (get) Token: 0x060026B5 RID: 9909 RVA: 0x0025C3E8 File Offset: 0x0025A5E8
		// (set) Token: 0x060026B6 RID: 9910 RVA: 0x0025C49C File Offset: 0x0025A69C
		internal int ScanWideConventionalTimeBetweenPrioritySamplesms_A9376Min
		{
			get
			{
				short num = (short)1081999361;
				if (num != 0)
				{
				}
				num = (short)899767248;
				short num2 = num;
				num = (short)1392008144;
				switch (num2 == num)
				{
				}
				num = (short)840695808;
				short num3 = num;
				num = (short)1226440704;
				if (num != 0)
				{
				}
				return this.scanWideConventionalTimeBetweenPrioritySamplesms_A9376.Min;
			}
			set
			{
				short num = (short)1831664341;
				short num2 = num;
				num = (short)1189608149;
				switch (num2 == num)
				{
				}
				num = (short)1664614401;
				if (num != 0)
				{
				}
				num = (short)2013396992;
				short num3 = num;
				num = (short)1450770432;
				if (num != 0)
				{
				}
				this.scanWideConventionalTimeBetweenPrioritySamplesms_A9376.Min = value;
			}
		}

		// Token: 0x17001365 RID: 4965
		// (get) Token: 0x060026B7 RID: 9911 RVA: 0x0025C554 File Offset: 0x0025A754
		// (set) Token: 0x060026B8 RID: 9912 RVA: 0x0025C608 File Offset: 0x0025A808
		internal int ScanWideConventionalTimeBetweenPrioritySamplesms_A9376Max
		{
			get
			{
				short num = (short)799866881;
				if (num != 0)
				{
				}
				num = (short)1797804803;
				short num2 = num;
				num = (short)861754115;
				switch (num2 == num)
				{
				}
				num = (short)1580531712;
				if (num != 0)
				{
				}
				num = (short)1094189056;
				short num3 = num;
				return this.scanWideConventionalTimeBetweenPrioritySamplesms_A9376.Max;
			}
			set
			{
				short num = (short)1847662896;
				short num2 = num;
				num = (short)1843730736;
				switch (num2 == num)
				{
				}
				num = (short)537591809;
				if (num != 0)
				{
				}
				num = (short)2077163520;
				if (num != 0)
				{
				}
				num = (short)1733951488;
				short num3 = num;
				this.scanWideConventionalTimeBetweenPrioritySamplesms_A9376.Max = value;
			}
		}

		// Token: 0x17001366 RID: 4966
		// (get) Token: 0x060026B9 RID: 9913 RVA: 0x0025C6BC File Offset: 0x0025A8BC
		// (set) Token: 0x060026BA RID: 9914 RVA: 0x0025C76C File Offset: 0x0025A96C
		internal int ScanWideConventionalTimeBetweenPrioritySamplesms_A9376Step
		{
			get
			{
				short num = (short)1987102203;
				short num2 = num;
				num = (short)2089403899;
				switch (num2 == num)
				{
				}
				num = (short)1356529665;
				if (num != 0)
				{
				}
				num = (short)1933705216;
				if (num != 0)
				{
				}
				num = (short)251133952;
				short num3 = num;
				return this.scanWideConventionalTimeBetweenPrioritySamplesms_A9376.StepSize;
			}
			set
			{
				short num = (short)1051600158;
				short num2 = num;
				num = (short)1764304158;
				switch (num2 == num)
				{
				}
				num = (short)986578945;
				if (num != 0)
				{
				}
				num = (short)264503296;
				if (num != 0)
				{
				}
				num = (short)1615527936;
				short num3 = num;
				this.scanWideConventionalTimeBetweenPrioritySamplesms_A9376.StepSize = value;
			}
		}

		// Token: 0x17001367 RID: 4967
		// (get) Token: 0x060026BB RID: 9915 RVA: 0x0025C824 File Offset: 0x0025AA24
		// (set) Token: 0x060026BC RID: 9916 RVA: 0x0025C8D8 File Offset: 0x0025AAD8
		public bool ScanWideConventionalTimeBetweenPrioritySamplesms_A9376_Applicable
		{
			get
			{
				short num = (short)2090288881;
				short num2 = num;
				num = (short)1313359601;
				switch (num2 == num)
				{
				}
				num = (short)1347878912;
				if (num != 0)
				{
				}
				num = (short)1898708993;
				if (num != 0)
				{
				}
				num = (short)1282146304;
				short num3 = num;
				return this.scanWideConventionalTimeBetweenPrioritySamplesms_A9376.Applicable;
			}
			set
			{
				short num = (short)1269824799;
				short num2 = num;
				num = (short)802290975;
				switch (num2 == num)
				{
				}
				num = (short)2106654720;
				if (num != 0)
				{
				}
				num = (short)1065549825;
				if (num != 0)
				{
				}
				num = (short)1881210880;
				short num3 = num;
				this.scanWideConventionalTimeBetweenPrioritySamplesms_A9376.Applicable = value;
			}
		}

		// Token: 0x17001368 RID: 4968
		// (get) Token: 0x060026BD RID: 9917 RVA: 0x0025C990 File Offset: 0x0025AB90
		// (set) Token: 0x060026BE RID: 9918 RVA: 0x0025CA44 File Offset: 0x0025AC44
		public bool ScanWideConventionalTimeBetweenPrioritySamplesms_A9376_Valid
		{
			get
			{
				short num = (short)387389291;
				short num2 = num;
				num = (short)127670123;
				switch (num2 == num)
				{
				}
				num = (short)1824718849;
				if (num != 0)
				{
				}
				num = (short)695271424;
				if (num != 0)
				{
				}
				num = (short)1553530880;
				short num3 = num;
				return this.scanWideConventionalTimeBetweenPrioritySamplesms_A9376.Valid;
			}
			set
			{
				short num = (short)1721209980;
				short num2 = num;
				num = (short)291607676;
				switch (num2 == num)
				{
				}
				num = (short)600899585;
				if (num != 0)
				{
				}
				num = (short)956825600;
				if (num != 0)
				{
				}
				num = (short)2037121024;
				short num3 = num;
				this.scanWideConventionalTimeBetweenPrioritySamplesms_A9376.Valid = value;
			}
		}

		// Token: 0x17001369 RID: 4969
		// (get) Token: 0x060026BF RID: 9919 RVA: 0x0025CAFC File Offset: 0x0025ACFC
		// (set) Token: 0x060026C0 RID: 9920 RVA: 0x0025CBB0 File Offset: 0x0025ADB0
		public bool ScanWideConventionalTimeBetweenPrioritySamplesms_A9376_Visible
		{
			get
			{
				short num = (short)835452929;
				if (num != 0)
				{
				}
				num = (short)380421981;
				short num2 = num;
				num = (short)1460193117;
				switch (num2 == num)
				{
				}
				num = (short)813367296;
				if (num != 0)
				{
				}
				num = (short)1700528128;
				short num3 = num;
				return this.scanWideConventionalTimeBetweenPrioritySamplesms_A9376.Visible;
			}
			set
			{
				short num = (short)1373437953;
				if (num != 0)
				{
				}
				num = (short)542396346;
				short num2 = num;
				num = (short)2028163002;
				switch (num2 == num)
				{
				}
				num = (short)787283968;
				if (num != 0)
				{
				}
				num = (short)1651965952;
				short num3 = num;
				this.scanWideConventionalTimeBetweenPrioritySamplesms_A9376.Visible = value;
			}
		}

		// Token: 0x1700136A RID: 4970
		// (get) Token: 0x060026C1 RID: 9921 RVA: 0x0025CC68 File Offset: 0x0025AE68
		// (set) Token: 0x060026C2 RID: 9922 RVA: 0x0025CD1C File Offset: 0x0025AF1C
		public bool ScanWideConventionalTimeBetweenPrioritySamplesms_A9376_Editable
		{
			get
			{
				short num = (short)949030046;
				short num2 = num;
				num = (short)1655114910;
				switch (num2 == num)
				{
				}
				num = (short)1155989504;
				if (num != 0)
				{
				}
				num = (short)1215758337;
				if (num != 0)
				{
				}
				num = (short)75825152;
				short num3 = num;
				return this.scanWideConventionalTimeBetweenPrioritySamplesms_A9376.Editable;
			}
			set
			{
				short num = (short)480385194;
				short num2 = num;
				num = (short)367990954;
				switch (num2 == num)
				{
				}
				num = (short)1969356801;
				if (num != 0)
				{
				}
				num = (short)2051997696;
				if (num != 0)
				{
				}
				num = (short)974979072;
				short num3 = num;
				this.scanWideConventionalTimeBetweenPrioritySamplesms_A9376.Editable = value;
			}
		}

		// Token: 0x1700136B RID: 4971
		// (get) Token: 0x060026C3 RID: 9923 RVA: 0x0025CDD0 File Offset: 0x0025AFD0
		internal string ScanWideConventionalTimeBetweenPrioritySamplesms_A9376_UILabel
		{
			get
			{
				short num = (short)1527709697;
				if (num != 0)
				{
				}
				num = (short)2095127885;
				short num2 = num;
				num = (short)809835853;
				switch (num2 == num)
				{
				}
				num = (short)1287716864;
				if (num != 0)
				{
				}
				num = (short)243007488;
				short num3 = num;
				return this.scanWideConventionalTimeBetweenPrioritySamplesms_A9376.UIName;
			}
		}

		// Token: 0x1700136C RID: 4972
		// (get) Token: 0x060026C4 RID: 9924 RVA: 0x0025CE88 File Offset: 0x0025B088
		// (set) Token: 0x060026C5 RID: 9925 RVA: 0x0025CF3C File Offset: 0x0025B13C
		internal bool ScanWideConventionalTimeBetweenPrioritySamplesms_A9376_HiddenStatic
		{
			get
			{
				short num = (short)1758420796;
				short num2 = num;
				num = (short)1351049020;
				switch (num2 == num)
				{
				}
				num = (short)982974464;
				if (num != 0)
				{
				}
				num = (short)2108948481;
				if (num != 0)
				{
				}
				num = (short)1234370560;
				short num3 = num;
				return this.scanWideConventionalTimeBetweenPrioritySamplesms_A9376.HiddenStatic;
			}
			set
			{
				short num = (short)634388481;
				if (num != 0)
				{
				}
				num = (short)700248782;
				short num2 = num;
				num = (short)882963150;
				switch (num2 == num)
				{
				}
				num = (short)730791936;
				if (num != 0)
				{
				}
				num = (short)2104623104;
				short num3 = num;
				this.scanWideConventionalTimeBetweenPrioritySamplesms_A9376.HiddenStatic = value;
			}
		}

		// Token: 0x1700136D RID: 4973
		// (get) Token: 0x060026C6 RID: 9926 RVA: 0x0025CFF4 File Offset: 0x0025B1F4
		// (set) Token: 0x060026C7 RID: 9927 RVA: 0x0025D0A8 File Offset: 0x0025B2A8
		internal bool ScanWideConventionalTimeBetweenPrioritySamplesms_A9376_HiddenDynamic
		{
			get
			{
				short num = (short)2099599784;
				short num2 = num;
				num = (short)1430608296;
				switch (num2 == num)
				{
				}
				num = (short)1374093313;
				if (num != 0)
				{
				}
				num = (short)1840185344;
				if (num != 0)
				{
				}
				num = (short)958857216;
				short num3 = num;
				return this.scanWideConventionalTimeBetweenPrioritySamplesms_A9376.HiddenDynamic;
			}
			set
			{
				short num = (short)1874459206;
				short num2 = num;
				num = (short)1408236102;
				switch (num2 == num)
				{
				}
				num = (short)264830977;
				if (num != 0)
				{
				}
				num = (short)2010185728;
				if (num != 0)
				{
				}
				num = (short)2016346112;
				short num3 = num;
				this.scanWideConventionalTimeBetweenPrioritySamplesms_A9376.HiddenDynamic = value;
			}
		}

		// Token: 0x1700136E RID: 4974
		// (get) Token: 0x060026C8 RID: 9928 RVA: 0x0025D160 File Offset: 0x0025B360
		public bool ScanWideConventionalTimeBetweenPrioritySamplesms_A9376_HasDiffs
		{
			get
			{
				short num = (short)1951334401;
				if (num != 0)
				{
				}
				num = (short)515927926;
				short num2 = num;
				num = (short)1280536438;
				switch (num2 == num)
				{
				}
				num = (short)815661056;
				if (num != 0)
				{
				}
				num = (short)1823932416;
				short num3 = num;
				return this.scanWideConventionalTimeBetweenPrioritySamplesms_A9376._HasDiffs;
			}
		}

		// Token: 0x060026C9 RID: 9929 RVA: 0x0025D218 File Offset: 0x0025B418
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_9A;
			}
			short num;
			int num4;
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_0A:
				num = (short)690496503;
				short num2 = num;
				num = (short)1909662711;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_FF;
				case 1:
					break;
				default:
				{
					num = (short)809697280;
					short num3 = num;
					break;
				}
				}
				num = (short)854654976;
				if (num != 0)
				{
				}
				switch (num4)
				{
				case 0:
					goto IL_FF;
				case 1:
					num = (short)1789001729;
					if (num != 0)
					{
					}
					if (base.ParentRecset != null)
					{
						num = (short)401932292;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 2:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num = (short)338100224;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 3:
					return result;
				case 4:
					num = (short)2062614530;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_9A;
				IL_FF:
				result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
				num = (short)1335427075;
				num4 = (int)((global::System.IntPtr)num);
			}
			return result;
			IL_9A:
			result = null;
			num = (short)1682243585;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x04000E58 RID: 3672
		private global::AcpBusinessLayer.AcpField<bool> scanWideConventionalCarrierDetectRequired_A7611;

		// Token: 0x04000E59 RID: 3673
		private global::AcpBusinessLayer.AcpSimpleRangeField scanWideConventionalMonitorHoldTimesec_A8543;

		// Token: 0x04000E5A RID: 3674
		private global::AcpBusinessLayer.AcpField<bool> scanWideConventionalPriorityChannelMarking_A8750;

		// Token: 0x04000E5B RID: 3675
		private global::AcpBusinessLayer.AcpSimpleRangeField scanWideConventionalRSSIVotingThreshold_A8997;

		// Token: 0x04000E5C RID: 3676
		private global::AcpBusinessLayer.AcpSimpleRangeField scanWideConventionalTimeBetweenPrioritySamplesms_A9376;
	}
}
