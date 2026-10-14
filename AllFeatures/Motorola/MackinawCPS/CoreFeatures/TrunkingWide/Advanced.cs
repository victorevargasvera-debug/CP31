using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using ConstraintHelper;

namespace Motorola.MackinawCPS.CoreFeatures.TrunkingWide
{
	// Token: 0x02000057 RID: 87
	[global::System.Serializable]
	public class Advanced : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600040F RID: 1039 RVA: 0x0004BD28 File Offset: 0x00049F28
		public Advanced(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x0004BD44 File Offset: 0x00049F44
		protected Advanced(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x0004BD5C File Offset: 0x00049F5C
		public override void Init()
		{
			int a_ = 18;
			short num = (short)1417164319;
			short num2 = num;
			num = (short)1014642207;
			switch (num2 == num)
			{
			}
			num = (short)543686657;
			if (num != 0)
			{
			}
			num = (short)637665280;
			short num3 = num;
			num = (short)1376256;
			if (num != 0)
			{
			}
			this.trkWideAdvancedAffiliationHoldOffsec_A7412 = new global::AcpBusinessLayer.AcpSparseLOVField(255, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.TrunkingWide.LOVs.indexTrkWideAdvancedAffiliationHoldOffsec_A7412LovStrs, global::Motorola.MackinawCPS.CoreFeatures.TrunkingWide.LOVs.idTrkWideAdvancedAffiliationHoldOffsec_A7412LovStrs), this, global::AllFeatures.CodeplugGuid.b("蟒꟔볖軘닚맜뫞ꃠ蟢鏤蛦蟨裪裬诮냰闲鏴黶闸鋺鳼课栀氂欄伆昈朊椌䀎眐甒昔爖稘䐚尜⠞ᔠሢᜤ", a_), global::CommonResources.AcgResources.ID_SMARTZONEAFFILIATIONHOLDOFFSEC, global::Motorola.MackinawCPS.CoreFeatures.TrunkingWide.LOVs.TrkWideAdvancedAffiliationHoldOffsec_A7412LovStrs);
			this.trkWideAdvancedAffiliationHoldOffsec_A7412.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.trkWideAdvancedAffiliationHoldOffsec_A7412.DataTransferOrder = 31;
			this.trkWideAdvancedFailsoftInactivitysec_A8010 = new global::AcpBusinessLayer.AcpSimpleRangeField(120, this, global::AllFeatures.CodeplugGuid.b("蟒꟔볖軘닚맜뫞ꃠ蟢鏤蛦蟨裪裬诮런鋲鳴鯶諸铺鯼课䠀洂搄搆紈戊笌明攐樒昔爖稘䐚尜✞ᄠሢᔤ", a_), global::CommonResources.AcgResources.ID_SMARTZONEFAILSOFTINACTIVITYSEC, 0, 255, null, null, 0, 1);
			this.trkWideAdvancedFailsoftInactivitysec_A8010.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.trkWideAdvancedFailsoftInactivitysec_A8010.DataTransferOrder = 26;
			this.trkWideAdvancedFailsoftInactivitysec_A8010.ShowHexValue = false;
			this.trkWideAdvancedFullSpectrumControlChannelScan_A8161 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("蟒꟔볖軘닚맜뫞ꃠ蟢鏤蛦蟨裪裬诮런蛲駴鯶꫸诺飼鳾甀焂瀄樆䨈搊挌笎挐簒礔吖焘稚猜焞䐠伢瘤䐦䠨䔪爬渮रȲ̴ض", a_), global::CommonResources.AcgResources.ID_SMARTZONEFULLSPECTRUMCONTROLCHANNELSCAN);
			this.trkWideAdvancedFullSpectrumControlChannelScan_A8161.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.trkWideAdvancedFullSpectrumControlChannelScan_A8161.DataTransferOrder = 32;
			this.trkWideAdvancedInternalRadioHoldoffmin_A8309 = new global::AcpBusinessLayer.AcpSimpleRangeField(10, this, global::AllFeatures.CodeplugGuid.b("蟒꟔볖軘닚맜뫞ꃠ蟢鏤蛦蟨裪裬诮룰鷲致鋶诸闺鳼鏾匀戂愄渆昈䌊戌挎甐簒猔焖琘爚猜䀞怠ᬢᘤᜦဨ", a_), global::CommonResources.AcgResources.ID_SMARTZONEINTERNALRADIOHOLDOFFMIN, 0, 60, null, null, 0, 1);
			this.trkWideAdvancedInternalRadioHoldoffmin_A8309.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.trkWideAdvancedInternalRadioHoldoffmin_A8309.DataTransferOrder = 29;
			this.trkWideAdvancedInternalRadioHoldoffmin_A8309.ShowHexValue = false;
			this.trkWideAdvancedISWWindowAdjustment_A8358 = new global::AcpBusinessLayer.AcpSimpleRangeField(65077, this, global::AllFeatures.CodeplugGuid.b("蟒꟔볖軘닚맜뫞ꃠ蟢鏤蛦蟨裪裬诮룰ꃲꋴꃶ郸闺駼郾瘀䈂愄洆簈砊礌戎琐紒愔䠖堘⌚⸜⨞ᤠ", a_), global::CommonResources.AcgResources.ID_ISWWINDOWADJUSTMENT, 0, 65535, null, null, 0, 1);
			this.trkWideAdvancedISWWindowAdjustment_A8358.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.trkWideAdvancedISWWindowAdjustment_A8358.DataTransferOrder = -1;
			this.trkWideAdvancedISWWindowAdjustment_A8358.ShowHexValue = true;
			this.trkWideAdvancedFullSpectrumControlChannelScanTimersec_A8162 = new global::AcpBusinessLayer.AcpSimpleRangeField(10, this, global::AllFeatures.CodeplugGuid.b("蟒꟔볖軘닚맜뫞ꃠ蟢鏤蛦蟨裪裬诮런蛲駴鯶꫸诺飼鳾甀焂瀄樆䨈搊挌笎挐簒礔吖焘稚猜焞䐠伢瘤䐦䠨䔪礬䘮尰嘲䜴䐶尸堺戼績祀牂獄畆", a_), global::CommonResources.AcgResources.ID_SMARTZONEFULLSPECTRUMCONTROLCHANNELSCANTIMERSEC, 5, 31, null, null, 0, 1);
			this.trkWideAdvancedFullSpectrumControlChannelScanTimersec_A8162.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.trkWideAdvancedFullSpectrumControlChannelScanTimersec_A8162.DataTransferOrder = 27;
			this.trkWideAdvancedFullSpectrumControlChannelScanTimersec_A8162.ShowHexValue = false;
			this.trkWideAdvancedHoldoffDelaysec_A8201 = new global::AcpBusinessLayer.AcpSimpleRangeField(10, this, global::AllFeatures.CodeplugGuid.b("蟒꟔볖軘닚맜뫞ꃠ蟢鏤蛦蟨裪裬诮맰鳲駴鏶雸鷺鯼믾搀漂搄縆稈渊渌倎倐⬒✔✖⠘", a_), global::CommonResources.AcgResources.ID_SMARTZONEHOLDOFFDELAYSEC, 5, 60, null, null, 0, 1);
			this.trkWideAdvancedHoldoffDelaysec_A8201.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.trkWideAdvancedHoldoffDelaysec_A8201.DataTransferOrder = 28;
			this.trkWideAdvancedHoldoffDelaysec_A8201.ShowHexValue = false;
			this.trkWideAdvancedVirtualPartnerCallActivityTime_A43675 = new global::AcpBusinessLayer.AcpSimpleRangeField(5, this, global::AllFeatures.CodeplugGuid.b("蟒꟔볖軘닚맜뫞ꃠ蟢鏤蛦蟨裪裬诮꟰髲蟴菶賸髺釼꿾怀焂焄椆氈礊丌渎紐缒吔琖洘爚欜瘞唠娢焤並䐨个爬渮԰2̴6స", a_), global::CommonResources.AcgResources.ID_VPCALLACTIVITYTIMESEC, 5, 30, null, null, 0, 1);
			this.trkWideAdvancedVirtualPartnerCallActivityTime_A43675.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.trkWideAdvancedVirtualPartnerCallActivityTime_A43675.DataTransferOrder = 36;
			this.trkWideAdvancedVirtualPartnerCallActivityTime_A43675.ShowHexValue = false;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鋒뇔ꇖ룘뗚뻜뫞藠", a_);
			base.Id = 10059;
			base.UIName = global::CommonResources.AcgResources.ID_ADVANCED;
			base.DataTransferOrder = 5;
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x0004C09C File Offset: 0x0004A29C
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 0;
			short num = (short)695336964;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_3AC;
				case 1:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("闀뇂껄郆ꃈ꿊꣌軎뗐ꗒ듔맖뫘뻚맜觞裠釢釤鋦裨蟪뷬軮菰蟲鯴鋶诸룺鳼鏾洀䈂昄猆怈紊搌笎栐䜒簔稖簘䐚尜⬞ሠᔢሤሦ", a_)))
					{
						num = (short)908525574;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_72F;
				case 2:
					goto IL_110;
				case 3:
					num = (short)835321865;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_9D;
					}
					continue;
				case 5:
					this.trkWideAdvancedFullSpectrumControlChannelScan_A8161 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("闀뇂껄郆ꃈ꿊꣌軎뗐ꗒ듔맖뫘뻚맜駞铠迢觤듦駨軪軬鯮菰蛲飴듶雸闺觼跾渀漂䘄漆栈攊挌樎紐䀒瘔瘖眘䐚尜✞ဠᔢᐤ", a_), global::CommonResources.AcgResources.ID_SMARTZONEFULLSPECTRUMCONTROLCHANNELSCAN);
					this.trkWideAdvancedFullSpectrumControlChannelScan_A8161.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.trkWideAdvancedFullSpectrumControlChannelScan_A8161.DataTransferOrder = 32;
					num = (short)469499904;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
				{
					num = (short)1335322055;
					short num3 = num;
					num = (short)578577863;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_6AA;
					default:
						num = (short)1586692096;
						if (num != 0)
						{
						}
						num = (short)880148481;
						if (num != 0)
						{
						}
						this.trkWideAdvancedVirtualPartnerCallActivityTime_A43675 = new global::AcpBusinessLayer.AcpSimpleRangeField(5, this, global::AllFeatures.CodeplugGuid.b("闀뇂껄郆ꃈ꿊꣌軎뗐ꗒ듔맖뫘뻚맜觞裠釢釤鋦裨蟪뷬軮菰蟲鯴鋶诸룺鳼鏾洀䈂昄猆怈紊搌笎栐䜒簔稖簘䐚尜⬞ሠᔢሤሦ", a_), global::CommonResources.AcgResources.ID_VPCALLACTIVITYTIMESEC, null, null, 0, 1);
						this.trkWideAdvancedVirtualPartnerCallActivityTime_A43675.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
						this.trkWideAdvancedVirtualPartnerCallActivityTime_A43675.DataTransferOrder = 36;
						this.trkWideAdvancedVirtualPartnerCallActivityTime_A43675.ShowHexValue = false;
						num = (short)210173969;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 7:
					this.trkWideAdvancedFullSpectrumControlChannelScanTimersec_A8162 = new global::AcpBusinessLayer.AcpSimpleRangeField(10, this, global::AllFeatures.CodeplugGuid.b("闀뇂껄郆ꃈ꿊꣌軎뗐ꗒ듔맖뫘뻚맜駞铠迢觤듦駨軪軬鯮菰蛲飴듶雸闺觼跾渀漂䘄漆栈攊挌樎紐䀒瘔瘖眘会琜爞䐠儢嘤䈦䨨琪氬ᜮ0Բܴ", a_), global::CommonResources.AcgResources.ID_SMARTZONEFULLSPECTRUMCONTROLCHANNELSCANTIMERSEC, null, null, 0, 1);
					this.trkWideAdvancedFullSpectrumControlChannelScanTimersec_A8162.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.trkWideAdvancedFullSpectrumControlChannelScanTimersec_A8162.DataTransferOrder = 27;
					this.trkWideAdvancedFullSpectrumControlChannelScanTimersec_A8162.ShowHexValue = false;
					num = (short)1528823819;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("闀뇂껄郆ꃈ꿊꣌軎뗐ꗒ듔맖뫘뻚맜雞迠韢胤闦蟨諪臬뷮郰韲鳴飶뇸铺釼鯾渀攂挄樆怈攊刌与⤐‒└⸖", a_)))
					{
						num = (short)1769486;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_110;
				case 9:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("闀뇂껄郆ꃈ꿊꣌軎뗐ꗒ듔맖뫘뻚맜點蟠藢賤详胨諪駬蛮黰鷲뷴飶闸鿺닼駾最瀂怄搆嘈䨊㨌㬎‐ℒ", a_)))
					{
						num = (short)2079784982;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_185;
				case 10:
					goto IL_C3;
				case 11:
					goto IL_460;
				case 12:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("闀뇂껄郆ꃈ꿊꣌軎뗐ꗒ듔맖뫘뻚맜雞닠듢다軦蟨迪苬飮냰韲鿴苶諸迺郼髾漀眂娄䘆ㄈ㠊㠌㜎", a_)))
					{
						num = (short)1491795994;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_C3;
				case 13:
					num = (short)2055733263;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					this.trkWideAdvancedInternalRadioHoldoffmin_A8309 = new global::AcpBusinessLayer.AcpSimpleRangeField(10, this, global::AllFeatures.CodeplugGuid.b("闀뇂껄郆ꃈ꿊꣌軎뗐ꗒ듔맖뫘뻚맜雞迠韢胤闦蟨諪臬뷮郰韲鳴飶뇸铺釼鯾渀攂挄樆怈攊刌与⤐‒└⸖", a_), global::CommonResources.AcgResources.ID_SMARTZONEINTERNALRADIOHOLDOFFMIN, null, null, 0, 1);
					this.trkWideAdvancedInternalRadioHoldoffmin_A8309.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.trkWideAdvancedInternalRadioHoldoffmin_A8309.DataTransferOrder = 29;
					this.trkWideAdvancedInternalRadioHoldoffmin_A8309.ShowHexValue = false;
					goto IL_6AA;
				case 15:
					if (producerFields != null)
					{
						num = (short)1834483715;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_72F;
				case 16:
					goto IL_2EE;
				case 17:
					goto IL_50F;
				case 18:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("闀뇂껄郆ꃈ꿊꣌軎뗐ꗒ듔맖뫘뻚맜駞铠迢觤듦駨軪軬鯮菰蛲飴듶雸闺觼跾渀漂䘄漆栈攊挌樎紐䀒瘔瘖眘会琜爞䐠儢嘤䈦䨨琪氬ᜮ0Բܴ", a_)))
					{
						num = (short)914882567;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_460;
				case 19:
					this.trkWideAdvancedFailsoftInactivitysec_A8010 = new global::AcpBusinessLayer.AcpSimpleRangeField(120, this, global::AllFeatures.CodeplugGuid.b("闀뇂껄郆ꃈ꿊꣌軎뗐ꗒ듔맖뫘뻚맜駞胠諢觤铦蛨跪駬ꛮ鿰鋲雴菶郸跺铼课砀瀂怄搆嘈䨊㔌㼎‐⌒", a_), global::CommonResources.AcgResources.ID_SMARTZONEFAILSOFTINACTIVITYSEC, null, null, 0, 1);
					this.trkWideAdvancedFailsoftInactivitysec_A8010.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.trkWideAdvancedFailsoftInactivitysec_A8010.DataTransferOrder = 26;
					this.trkWideAdvancedFailsoftInactivitysec_A8010.ShowHexValue = false;
					num = (short)1098448923;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 20:
					goto IL_185;
				case 21:
					this.trkWideAdvancedHoldoffDelaysec_A8201 = new global::AcpBusinessLayer.AcpSimpleRangeField(10, this, global::AllFeatures.CodeplugGuid.b("闀뇂껄郆ꃈ꿊꣌軎뗐ꗒ듔맖뫘뻚맜韞軠迢臤裦迨跪ꧬ諮鷰鋲賴蓶鳸飺ꋼ뻾㤀㄂㔄㘆", a_), global::CommonResources.AcgResources.ID_SMARTZONEHOLDOFFDELAYSEC, null, null, 0, 1);
					this.trkWideAdvancedHoldoffDelaysec_A8201.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.trkWideAdvancedHoldoffDelaysec_A8201.DataTransferOrder = 28;
					this.trkWideAdvancedHoldoffDelaysec_A8201.ShowHexValue = false;
					num = (short)810614800;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 22:
					this.trkWideAdvancedAffiliationHoldOffsec_A7412 = new global::AcpBusinessLayer.AcpSparseLOVField(255, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.TrunkingWide.LOVs.indexTrkWideAdvancedAffiliationHoldOffsec_A7412LovStrs, global::Motorola.MackinawCPS.CoreFeatures.TrunkingWide.LOVs.idTrkWideAdvancedAffiliationHoldOffsec_A7412LovStrs), this, global::AllFeatures.CodeplugGuid.b("闀뇂껄郆ꃈ꿊꣌軎뗐ꗒ듔맖뫘뻚맜點蟠藢賤详胨諪駬蛮黰鷲뷴飶闸鿺닼駾最瀂怄搆嘈䨊㨌㬎‐ℒ", a_), global::CommonResources.AcgResources.ID_SMARTZONEAFFILIATIONHOLDOFFSEC, global::Motorola.MackinawCPS.CoreFeatures.TrunkingWide.LOVs.TrkWideAdvancedAffiliationHoldOffsec_A7412LovStrs);
					this.trkWideAdvancedAffiliationHoldOffsec_A7412.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.trkWideAdvancedAffiliationHoldOffsec_A7412.DataTransferOrder = 31;
					num = (short)1784348692;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 23:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("闀뇂껄郆ꃈ꿊꣌軎뗐ꗒ듔맖뫘뻚맜駞胠諢觤铦蛨跪駬ꛮ鿰鋲雴菶郸跺铼课砀瀂怄搆嘈䨊㔌㼎‐⌒", a_)))
					{
						num = (short)1967915027;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_514;
				case 24:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("闀뇂껄郆ꃈ꿊꣌軎뗐ꗒ듔맖뫘뻚맜駞铠迢觤듦駨軪軬鯮菰蛲飴듶雸闺觼跾渀漂䘄漆栈攊挌樎紐䀒瘔瘖眘䐚尜✞ဠᔢᐤ", a_)))
					{
						num = (short)433258501;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3AC;
				case 25:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("闀뇂껄郆ꃈ꿊꣌軎뗐ꗒ듔맖뫘뻚맜韞軠迢臤裦迨跪ꧬ諮鷰鋲賴蓶鳸飺ꋼ뻾㤀㄂㔄㘆", a_)))
					{
						num = (short)747503637;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2EE;
				case 26:
				{
					num = (short)1104347136;
					short num4 = num;
					this.trkWideAdvancedISWWindowAdjustment_A8358 = new global::AcpBusinessLayer.AcpSimpleRangeField(65077, this, global::AllFeatures.CodeplugGuid.b("闀뇂껄郆ꃈ꿊꣌軎뗐ꗒ듔맖뫘뻚맜雞닠듢다軦蟨迪苬飮냰韲鿴苶諸迺郼髾漀眂娄䘆ㄈ㠊㠌㜎", a_), global::CommonResources.AcgResources.ID_ISWWINDOWADJUSTMENT, null, null, 0, 1);
					this.trkWideAdvancedISWWindowAdjustment_A8358.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.trkWideAdvancedISWWindowAdjustment_A8358.DataTransferOrder = -1;
					this.trkWideAdvancedISWWindowAdjustment_A8358.ShowHexValue = true;
					num = (short)1531576330;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 27:
					goto IL_514;
				}
				IL_9D:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)603193357;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_C3:
				num = (short)2039939090;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_110:
				num = (short)1682505740;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_185:
				num = (short)281739287;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2EE:
				num = (short)1588920321;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3AC:
				num = (short)907739144;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_460:
				num = (short)761135129;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_514:
				num = (short)1453457432;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_6AA:
				num = (short)2140078082;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_50F:
			IL_72F:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("胀Ꟃ도ꛆꟈ꣊꣌ꯎ", a_);
			base.Id = 10059;
			base.UIName = global::CommonResources.AcgResources.ID_ADVANCED;
			base.DataTransferOrder = 5;
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x0004C80C File Offset: 0x0004AA0C
		public override void PopulateReferences()
		{
			short num = (short)875707846;
			short num2 = num;
			num = (short)435961286;
			switch (num2 == num)
			{
			}
			num = (short)474611713;
			if (num != 0)
			{
			}
			num = (short)1621032960;
			short num3 = num;
			num = (short)1110507520;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x0004C8B8 File Offset: 0x0004AAB8
		public override void DropReferences()
		{
			short num = (short)461766657;
			if (num != 0)
			{
			}
			num = (short)560787729;
			short num2 = num;
			num = (short)276230417;
			switch (num2 == num)
			{
			}
			num = (short)740294656;
			short num3 = num;
			num = (short)1469972480;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x0004C960 File Offset: 0x0004AB60
		public override void SetConstraints()
		{
			short num = (short)744759583;
			short num2 = num;
			num = (short)1368138015;
			switch (num2 == num)
			{
			}
			num = (short)761528320;
			if (num != 0)
			{
			}
			num = (short)1389035520;
			short num3 = num;
			num = (short)696188929;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x0004CA0C File Offset: 0x0004AC0C
		public override void SetupDependencies()
		{
			short num = (short)1556651653;
			short num2 = num;
			num = (short)362258053;
			switch (num2 == num)
			{
			}
			num = (short)2075983873;
			if (num != 0)
			{
			}
			num = (short)978190336;
			short num3 = num;
			num = (short)1746010112;
			if (num != 0)
			{
			}
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x06000417 RID: 1047 RVA: 0x0004CAB4 File Offset: 0x0004ACB4
		public bool HasDiffs
		{
			get
			{
				short num = (short)1014104065;
				if (num != 0)
				{
				}
				num = (short)385630924;
				short num2 = num;
				num = (short)116015820;
				switch (num2 == num)
				{
				}
				num = (short)444137472;
				short num3 = num;
				num = (short)1965228032;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x06000418 RID: 1048 RVA: 0x0004CB60 File Offset: 0x0004AD60
		// (set) Token: 0x06000419 RID: 1049 RVA: 0x0004CC14 File Offset: 0x0004AE14
		public int TrkWideAdvancedAffiliationHoldOffsec_A7412Value
		{
			get
			{
				short num = (short)1801608916;
				short num2 = num;
				num = (short)1352949460;
				switch (num2 == num)
				{
				}
				num = (short)413466625;
				if (num != 0)
				{
				}
				num = (short)1350303744;
				short num3 = num;
				num = (short)769654784;
				if (num != 0)
				{
				}
				return this.trkWideAdvancedAffiliationHoldOffsec_A7412.Value;
			}
			set
			{
				short num = (short)2005976274;
				short num2 = num;
				num = (short)273990866;
				switch (num2 == num)
				{
				}
				num = (short)943259649;
				if (num != 0)
				{
				}
				num = (short)938278912;
				short num3 = num;
				num = (short)1843003392;
				if (num != 0)
				{
				}
				this.trkWideAdvancedAffiliationHoldOffsec_A7412.Value = value;
			}
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x0600041A RID: 1050 RVA: 0x0004CCCC File Offset: 0x0004AECC
		// (set) Token: 0x0600041B RID: 1051 RVA: 0x0004CD80 File Offset: 0x0004AF80
		public string TrkWideAdvancedAffiliationHoldOffsec_A7412_UIValue
		{
			get
			{
				short num = (short)155427413;
				short num2 = num;
				num = (short)273850965;
				switch (num2 == num)
				{
				}
				num = (short)1430388737;
				if (num != 0)
				{
				}
				num = (short)571604992;
				short num3 = num;
				num = (short)2041970688;
				if (num != 0)
				{
				}
				return this.trkWideAdvancedAffiliationHoldOffsec_A7412.UIValue;
			}
			set
			{
				short num = (short)1053519650;
				short num2 = num;
				num = (short)213675810;
				switch (num2 == num)
				{
				}
				num = (short)1498087425;
				if (num != 0)
				{
				}
				num = (short)1092943872;
				short num3 = num;
				num = (short)1797390336;
				if (num != 0)
				{
				}
				this.trkWideAdvancedAffiliationHoldOffsec_A7412.UIValue = value;
			}
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x0600041C RID: 1052 RVA: 0x0004CE34 File Offset: 0x0004B034
		public global::AcpBusinessLayer.AcpListField TrkWideAdvancedAffiliationHoldOffsec_A7412
		{
			get
			{
				short num = (short)528849248;
				short num2 = num;
				num = (short)1622645088;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1243152384;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1311637505;
				if (num != 0)
				{
				}
				num = (short)859963392;
				if (num != 0)
				{
				}
				return this.trkWideAdvancedAffiliationHoldOffsec_A7412;
			}
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x0600041D RID: 1053 RVA: 0x0004CEE4 File Offset: 0x0004B0E4
		// (set) Token: 0x0600041E RID: 1054 RVA: 0x0004CF98 File Offset: 0x0004B198
		public bool TrkWideAdvancedAffiliationHoldOffsec_A7412_Applicable
		{
			get
			{
				short num = (short)1551608305;
				short num2 = num;
				num = (short)518629873;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1279262720;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)309002240;
				if (num != 0)
				{
				}
				num = (short)1280901121;
				if (num != 0)
				{
				}
				return this.trkWideAdvancedAffiliationHoldOffsec_A7412.Applicable;
			}
			set
			{
				short num = (short)585307444;
				short num2 = num;
				num = (short)1706169652;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1974730752;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1330446337;
				if (num != 0)
				{
				}
				num = (short)75038720;
				if (num != 0)
				{
				}
				this.trkWideAdvancedAffiliationHoldOffsec_A7412.Applicable = value;
			}
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x0600041F RID: 1055 RVA: 0x0004D050 File Offset: 0x0004B250
		// (set) Token: 0x06000420 RID: 1056 RVA: 0x0004D104 File Offset: 0x0004B304
		public bool TrkWideAdvancedAffiliationHoldOffsec_A7412_Valid
		{
			get
			{
				short num = (short)1441996224;
				short num2 = num;
				num = (short)1025580480;
				switch (num2 == num)
				{
				default:
				{
					num = (short)727646208;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1674182657;
				if (num != 0)
				{
				}
				num = (short)974520320;
				if (num != 0)
				{
				}
				return this.trkWideAdvancedAffiliationHoldOffsec_A7412.Valid;
			}
			set
			{
				short num = (short)921221149;
				short num2 = num;
				num = (short)1650047005;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1663041536;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)619249664;
				if (num != 0)
				{
				}
				num = (short)741933057;
				if (num != 0)
				{
				}
				this.trkWideAdvancedAffiliationHoldOffsec_A7412.Valid = value;
			}
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x06000421 RID: 1057 RVA: 0x0004D1BC File Offset: 0x0004B3BC
		// (set) Token: 0x06000422 RID: 1058 RVA: 0x0004D270 File Offset: 0x0004B470
		public bool TrkWideAdvancedAffiliationHoldOffsec_A7412_Visible
		{
			get
			{
				short num = (short)1858779740;
				short num2 = num;
				num = (short)292993628;
				switch (num2 == num)
				{
				default:
				{
					num = (short)651034624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1385103360;
				if (num != 0)
				{
				}
				num = (short)2129395713;
				if (num != 0)
				{
				}
				return this.trkWideAdvancedAffiliationHoldOffsec_A7412.Visible;
			}
			set
			{
				short num = (short)1582356362;
				short num2 = num;
				num = (short)434231178;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1053032448;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1228537857;
				if (num != 0)
				{
				}
				num = (short)1677524992;
				if (num != 0)
				{
				}
				this.trkWideAdvancedAffiliationHoldOffsec_A7412.Visible = value;
			}
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x06000423 RID: 1059 RVA: 0x0004D324 File Offset: 0x0004B524
		// (set) Token: 0x06000424 RID: 1060 RVA: 0x0004D3D8 File Offset: 0x0004B5D8
		public bool TrkWideAdvancedAffiliationHoldOffsec_A7412_Editable
		{
			get
			{
				short num = (short)511044874;
				short num2 = num;
				num = (short)223997194;
				switch (num2 == num)
				{
				default:
				{
					num = (short)494534656;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)963837952;
				if (num != 0)
				{
				}
				num = (short)429522945;
				if (num != 0)
				{
				}
				return this.trkWideAdvancedAffiliationHoldOffsec_A7412.Editable;
			}
			set
			{
				short num = (short)1127623379;
				short num2 = num;
				num = (short)1762405075;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1861419008;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1132003328;
				if (num != 0)
				{
				}
				num = (short)1764229121;
				if (num != 0)
				{
				}
				this.trkWideAdvancedAffiliationHoldOffsec_A7412.Editable = value;
			}
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x06000425 RID: 1061 RVA: 0x0004D48C File Offset: 0x0004B68C
		internal string TrkWideAdvancedAffiliationHoldOffsec_A7412_UILabel
		{
			get
			{
				short num = (short)1742194736;
				short num2 = num;
				num = (short)1676462128;
				switch (num2 == num)
				{
				default:
				{
					num = (short)47120384;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)313851905;
				if (num != 0)
				{
				}
				num = (short)339476480;
				if (num != 0)
				{
				}
				return this.trkWideAdvancedAffiliationHoldOffsec_A7412.UIName;
			}
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x06000426 RID: 1062 RVA: 0x0004D540 File Offset: 0x0004B740
		// (set) Token: 0x06000427 RID: 1063 RVA: 0x0004D5F4 File Offset: 0x0004B7F4
		internal bool TrkWideAdvancedAffiliationHoldOffsec_A7412_HiddenStatic
		{
			get
			{
				short num = (short)132751716;
				short num2 = num;
				num = (short)1220452708;
				switch (num2 == num)
				{
				default:
				{
					num = (short)982253568;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1165557760;
				if (num != 0)
				{
				}
				num = (short)584515585;
				if (num != 0)
				{
				}
				return this.trkWideAdvancedAffiliationHoldOffsec_A7412.HiddenStatic;
			}
			set
			{
				short num = (short)326002974;
				short num2 = num;
				num = (short)1424779550;
				switch (num2 == num)
				{
				default:
				{
					num = (short)431423488;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)284098560;
				if (num != 0)
				{
				}
				num = (short)1576861697;
				if (num != 0)
				{
				}
				this.trkWideAdvancedAffiliationHoldOffsec_A7412.HiddenStatic = value;
			}
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x06000428 RID: 1064 RVA: 0x0004D6AC File Offset: 0x0004B8AC
		// (set) Token: 0x06000429 RID: 1065 RVA: 0x0004D760 File Offset: 0x0004B960
		internal bool TrkWideAdvancedAffiliationHoldOffsec_A7412_HiddenDynamic
		{
			get
			{
				short num = (short)370378707;
				short num2 = num;
				num = (short)132614099;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1295450112;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1579352065;
				if (num != 0)
				{
				}
				num = (short)1658060800;
				if (num != 0)
				{
				}
				return this.trkWideAdvancedAffiliationHoldOffsec_A7412.HiddenDynamic;
			}
			set
			{
				short num = (short)1821058634;
				short num2 = num;
				num = (short)1411262026;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1110966272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1722155008;
				if (num != 0)
				{
				}
				num = (short)1316618241;
				if (num != 0)
				{
				}
				this.trkWideAdvancedAffiliationHoldOffsec_A7412.HiddenDynamic = value;
			}
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x0600042A RID: 1066 RVA: 0x0004D814 File Offset: 0x0004BA14
		public bool TrkWideAdvancedAffiliationHoldOffsec_A7412_HasDiffs
		{
			get
			{
				short num = (short)309879133;
				short num2 = num;
				num = (short)2002805085;
				switch (num2 == num)
				{
				default:
				{
					num = (short)641400832;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1770389505;
				if (num != 0)
				{
				}
				num = (short)1513816064;
				if (num != 0)
				{
				}
				return this.trkWideAdvancedAffiliationHoldOffsec_A7412._HasDiffs;
			}
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x0600042B RID: 1067 RVA: 0x0004D8CC File Offset: 0x0004BACC
		// (set) Token: 0x0600042C RID: 1068 RVA: 0x0004D980 File Offset: 0x0004BB80
		public int TrkWideAdvancedFailsoftInactivitysec_A8010Value
		{
			get
			{
				short num = (short)1874742650;
				short num2 = num;
				num = (short)1957973370;
				switch (num2 == num)
				{
				default:
				{
					num = (short)687013888;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1178796033;
				if (num != 0)
				{
				}
				num = (short)1848901632;
				if (num != 0)
				{
				}
				return this.trkWideAdvancedFailsoftInactivitysec_A8010.Value;
			}
			set
			{
				short num = (short)65760089;
				short num2 = num;
				num = (short)1788570457;
				switch (num2 == num)
				{
				default:
				{
					num = (short)382402560;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)448528385;
				if (num != 0)
				{
				}
				num = (short)1005060096;
				if (num != 0)
				{
				}
				this.trkWideAdvancedFailsoftInactivitysec_A8010.Value = value;
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x0600042D RID: 1069 RVA: 0x0004DA34 File Offset: 0x0004BC34
		public global::AcpBusinessLayer.AcpSimpleRangeField TrkWideAdvancedFailsoftInactivitysec_A8010
		{
			get
			{
				short num = (short)987913804;
				short num2 = num;
				num = (short)1807179340;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1729888256;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)386531329;
				if (num != 0)
				{
				}
				num = (short)1634074624;
				if (num != 0)
				{
				}
				return this.trkWideAdvancedFailsoftInactivitysec_A8010;
			}
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x0600042E RID: 1070 RVA: 0x0004DAE0 File Offset: 0x0004BCE0
		// (set) Token: 0x0600042F RID: 1071 RVA: 0x0004DB94 File Offset: 0x0004BD94
		public string TrkWideAdvancedFailsoftInactivitysec_A8010_UIValue
		{
			get
			{
				short num = (short)2040202878;
				short num2 = num;
				num = (short)618661502;
				switch (num2 == num)
				{
				default:
				{
					num = (short)718602240;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1439236096;
				if (num != 0)
				{
				}
				num = (short)490930177;
				if (num != 0)
				{
				}
				return this.trkWideAdvancedFailsoftInactivitysec_A8010.UIValue;
			}
			set
			{
				short num = (short)1935037183;
				short num2 = num;
				num = (short)518214399;
				switch (num2 == num)
				{
				default:
				{
					num = (short)790757376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1149698048;
				if (num != 0)
				{
				}
				num = (short)908001281;
				if (num != 0)
				{
				}
				this.trkWideAdvancedFailsoftInactivitysec_A8010.UIValue = value;
			}
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x06000430 RID: 1072 RVA: 0x0004DC48 File Offset: 0x0004BE48
		// (set) Token: 0x06000431 RID: 1073 RVA: 0x0004DCFC File Offset: 0x0004BEFC
		internal int TrkWideAdvancedFailsoftInactivitysec_A8010Min
		{
			get
			{
				short num = (short)1373614254;
				short num2 = num;
				num = (short)1421486;
				switch (num2 == num)
				{
				default:
				{
					num = (short)849936384;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)950468609;
				if (num != 0)
				{
				}
				num = (short)323354624;
				if (num != 0)
				{
				}
				return this.trkWideAdvancedFailsoftInactivitysec_A8010.Min;
			}
			set
			{
				short num = (short)1214587351;
				short num2 = num;
				num = (short)325591511;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1605173248;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1593180160;
				if (num != 0)
				{
				}
				num = (short)1420754945;
				if (num != 0)
				{
				}
				this.trkWideAdvancedFailsoftInactivitysec_A8010.Min = value;
			}
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x06000432 RID: 1074 RVA: 0x0004DDB4 File Offset: 0x0004BFB4
		// (set) Token: 0x06000433 RID: 1075 RVA: 0x0004DE68 File Offset: 0x0004C068
		internal int TrkWideAdvancedFailsoftInactivitysec_A8010Max
		{
			get
			{
				short num = (short)1199848105;
				short num2 = num;
				num = (short)1659779753;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1384710144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1429471233;
				if (num != 0)
				{
				}
				num = (short)31522816;
				if (num != 0)
				{
				}
				return this.trkWideAdvancedFailsoftInactivitysec_A8010.Max;
			}
			set
			{
				short num = (short)1021373648;
				short num2 = num;
				num = (short)1781722320;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1228996608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)355991553;
				if (num != 0)
				{
				}
				num = (short)2060320768;
				if (num != 0)
				{
				}
				this.trkWideAdvancedFailsoftInactivitysec_A8010.Max = value;
			}
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x06000434 RID: 1076 RVA: 0x0004DF20 File Offset: 0x0004C120
		// (set) Token: 0x06000435 RID: 1077 RVA: 0x0004DFD8 File Offset: 0x0004C1D8
		internal int TrkWideAdvancedFailsoftInactivitysec_A8010Step
		{
			get
			{
				short num = (short)432119514;
				short num2 = num;
				num = (short)407150298;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1747124224;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)678100992;
				if (num != 0)
				{
				}
				num = (short)1085931521;
				if (num != 0)
				{
				}
				return this.trkWideAdvancedFailsoftInactivitysec_A8010.StepSize;
			}
			set
			{
				short num = (short)1061731974;
				short num2 = num;
				num = (short)1937882758;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1798504448;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)52297728;
				if (num != 0)
				{
				}
				num = (short)330563585;
				if (num != 0)
				{
				}
				this.trkWideAdvancedFailsoftInactivitysec_A8010.StepSize = value;
			}
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x06000436 RID: 1078 RVA: 0x0004E08C File Offset: 0x0004C28C
		// (set) Token: 0x06000437 RID: 1079 RVA: 0x0004E140 File Offset: 0x0004C340
		public bool TrkWideAdvancedFailsoftInactivitysec_A8010_Applicable
		{
			get
			{
				short num = (short)708599398;
				short num2 = num;
				num = (short)1116167782;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1354956800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1011810305;
				if (num != 0)
				{
				}
				num = (short)225837056;
				if (num != 0)
				{
				}
				return this.trkWideAdvancedFailsoftInactivitysec_A8010.Applicable;
			}
			set
			{
				short num = (short)1952806922;
				short num2 = num;
				num = (short)524711946;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1654063104;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2054422529;
				if (num != 0)
				{
				}
				num = (short)628490240;
				if (num != 0)
				{
				}
				this.trkWideAdvancedFailsoftInactivitysec_A8010.Applicable = value;
			}
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x06000438 RID: 1080 RVA: 0x0004E1F4 File Offset: 0x0004C3F4
		// (set) Token: 0x06000439 RID: 1081 RVA: 0x0004E2A8 File Offset: 0x0004C4A8
		public bool TrkWideAdvancedFailsoftInactivitysec_A8010_Valid
		{
			get
			{
				short num = (short)1099175669;
				short num2 = num;
				num = (short)1392449269;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1286209536;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2085027841;
				if (num != 0)
				{
				}
				num = (short)1359347712;
				if (num != 0)
				{
				}
				return this.trkWideAdvancedFailsoftInactivitysec_A8010.Valid;
			}
			set
			{
				short num = (short)1748303873;
				if (num != 0)
				{
				}
				num = (short)129892352;
				short num2 = num;
				num = (short)465733090;
				short num3 = num;
				num = (short)570197474;
				switch (num3 == num)
				{
				}
				num = (short)1415905280;
				if (num != 0)
				{
				}
				this.trkWideAdvancedFailsoftInactivitysec_A8010.Valid = value;
			}
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x0600043A RID: 1082 RVA: 0x0004E360 File Offset: 0x0004C560
		// (set) Token: 0x0600043B RID: 1083 RVA: 0x0004E418 File Offset: 0x0004C618
		public bool TrkWideAdvancedFailsoftInactivitysec_A8010_Visible
		{
			get
			{
				short num = (short)1136918529;
				if (num != 0)
				{
				}
				num = (short)789905408;
				short num2 = num;
				num = (short)1543081742;
				short num3 = num;
				num = (short)108105486;
				switch (num3 == num)
				{
				}
				num = (short)950140928;
				if (num != 0)
				{
				}
				return this.trkWideAdvancedFailsoftInactivitysec_A8010.Visible;
			}
			set
			{
				short num = (short)639795688;
				short num2 = num;
				num = (short)1063682536;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1355743232;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)277676033;
				if (num != 0)
				{
				}
				num = (short)1746599936;
				if (num != 0)
				{
				}
				this.trkWideAdvancedFailsoftInactivitysec_A8010.Visible = value;
			}
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x0600043C RID: 1084 RVA: 0x0004E4D0 File Offset: 0x0004C6D0
		// (set) Token: 0x0600043D RID: 1085 RVA: 0x0004E580 File Offset: 0x0004C780
		public bool TrkWideAdvancedFailsoftInactivitysec_A8010_Editable
		{
			get
			{
				short num = (short)549476200;
				short num2 = num;
				num = (short)1503156072;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2074083328;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1487470592;
				if (num != 0)
				{
				}
				num = (short)924975105;
				if (num != 0)
				{
				}
				return this.trkWideAdvancedFailsoftInactivitysec_A8010.Editable;
			}
			set
			{
				short num = (short)55865722;
				short num2 = num;
				num = (short)1737847162;
				switch (num2 == num)
				{
				default:
				{
					num = (short)965869568;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1835663361;
				if (num != 0)
				{
				}
				num = (short)697761792;
				if (num != 0)
				{
				}
				this.trkWideAdvancedFailsoftInactivitysec_A8010.Editable = value;
			}
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x0600043E RID: 1086 RVA: 0x0004E638 File Offset: 0x0004C838
		internal string TrkWideAdvancedFailsoftInactivitysec_A8010_UILabel
		{
			get
			{
				short num = (short)773973074;
				short num2 = num;
				num = (short)1978066002;
				switch (num2 == num)
				{
				default:
				{
					num = (short)909574144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)492306433;
				if (num != 0)
				{
				}
				num = (short)1841561600;
				if (num != 0)
				{
				}
				return this.trkWideAdvancedFailsoftInactivitysec_A8010.UIName;
			}
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x0600043F RID: 1087 RVA: 0x0004E6EC File Offset: 0x0004C8EC
		// (set) Token: 0x06000440 RID: 1088 RVA: 0x0004E7A0 File Offset: 0x0004C9A0
		internal bool TrkWideAdvancedFailsoftInactivitysec_A8010_HiddenStatic
		{
			get
			{
				short num = (short)902837514;
				short num2 = num;
				num = (short)906573066;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2131427328;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)338362368;
				if (num != 0)
				{
				}
				num = (short)873594881;
				if (num != 0)
				{
				}
				return this.trkWideAdvancedFailsoftInactivitysec_A8010.HiddenStatic;
			}
			set
			{
				short num = (short)631916018;
				short num2 = num;
				num = (short)12338674;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1575223296;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)827916289;
				if (num != 0)
				{
				}
				num = (short)1631584256;
				if (num != 0)
				{
				}
				this.trkWideAdvancedFailsoftInactivitysec_A8010.HiddenStatic = value;
			}
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x06000441 RID: 1089 RVA: 0x0004E858 File Offset: 0x0004CA58
		// (set) Token: 0x06000442 RID: 1090 RVA: 0x0004E90C File Offset: 0x0004CB0C
		internal bool TrkWideAdvancedFailsoftInactivitysec_A8010_HiddenDynamic
		{
			get
			{
				short num = (short)1410594295;
				short num2 = num;
				num = (short)1109915127;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1317273600;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1617231873;
				if (num != 0)
				{
				}
				num = (short)924712960;
				if (num != 0)
				{
				}
				return this.trkWideAdvancedFailsoftInactivitysec_A8010.HiddenDynamic;
			}
			set
			{
				short num = (short)2043009912;
				short num2 = num;
				num = (short)1515445112;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2046033920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)907476992;
				if (num != 0)
				{
				}
				num = (short)878379009;
				if (num != 0)
				{
				}
				this.trkWideAdvancedFailsoftInactivitysec_A8010.HiddenDynamic = value;
			}
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x06000443 RID: 1091 RVA: 0x0004E9C0 File Offset: 0x0004CBC0
		public bool TrkWideAdvancedFailsoftInactivitysec_A8010_HasDiffs
		{
			get
			{
				short num = (short)92330972;
				short num2 = num;
				num = (short)1871109084;
				switch (num2 == num)
				{
				default:
				{
					num = (short)416874496;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1773928449;
				if (num != 0)
				{
				}
				num = (short)1465778176;
				if (num != 0)
				{
				}
				return this.trkWideAdvancedFailsoftInactivitysec_A8010._HasDiffs;
			}
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x06000444 RID: 1092 RVA: 0x0004EA74 File Offset: 0x0004CC74
		// (set) Token: 0x06000445 RID: 1093 RVA: 0x0004EB28 File Offset: 0x0004CD28
		public bool TrkWideAdvancedFullSpectrumControlChannelScan_A8161Value
		{
			get
			{
				short num = (short)1490432205;
				short num2 = num;
				num = (short)1715220685;
				switch (num2 == num)
				{
				default:
				{
					num = (short)355074048;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1545797633;
				if (num != 0)
				{
				}
				num = (short)1206976512;
				if (num != 0)
				{
				}
				return this.trkWideAdvancedFullSpectrumControlChannelScan_A8161.Value;
			}
			set
			{
				short num = (short)226170739;
				short num2 = num;
				num = (short)1745950579;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1376452608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)470417409;
				if (num != 0)
				{
				}
				num = (short)755499008;
				if (num != 0)
				{
				}
				this.trkWideAdvancedFullSpectrumControlChannelScan_A8161.Value = value;
			}
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x06000446 RID: 1094 RVA: 0x0004EBDC File Offset: 0x0004CDDC
		public global::AcpBusinessLayer.AcpField<bool> TrkWideAdvancedFullSpectrumControlChannelScan_A8161
		{
			get
			{
				short num = (short)1014739349;
				short num2 = num;
				num = (short)1009693077;
				switch (num2 == num)
				{
				default:
				{
					num = (short)38535168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1711407104;
				if (num != 0)
				{
				}
				num = (short)899022849;
				if (num != 0)
				{
				}
				return this.trkWideAdvancedFullSpectrumControlChannelScan_A8161;
			}
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x06000447 RID: 1095 RVA: 0x0004EC8C File Offset: 0x0004CE8C
		// (set) Token: 0x06000448 RID: 1096 RVA: 0x0004ED3C File Offset: 0x0004CF3C
		public bool TrkWideAdvancedFullSpectrumControlChannelScan_A8161_UIValue
		{
			get
			{
				short num = (short)1441202177;
				if (num != 0)
				{
				}
				num = (short)1802240000;
				short num2 = num;
				num = (short)1256386946;
				short num3 = num;
				num = (short)582087042;
				switch (num3 == num)
				{
				}
				num = (short)1085800448;
				if (num != 0)
				{
				}
				return this.trkWideAdvancedFullSpectrumControlChannelScan_A8161.Value;
			}
			set
			{
				short num = (short)1598985403;
				short num2 = num;
				num = (short)2138936507;
				switch (num2 == num)
				{
				default:
				{
					num = (short)984219648;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1819672577;
				if (num != 0)
				{
				}
				num = (short)764674048;
				if (num != 0)
				{
				}
				this.trkWideAdvancedFullSpectrumControlChannelScan_A8161.Value = value;
			}
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x06000449 RID: 1097 RVA: 0x0004EDF0 File Offset: 0x0004CFF0
		// (set) Token: 0x0600044A RID: 1098 RVA: 0x0004EEA0 File Offset: 0x0004D0A0
		public bool TrkWideAdvancedFullSpectrumControlChannelScan_A8161_Applicable
		{
			get
			{
				short num = (short)1589116072;
				short num2 = num;
				num = (short)1112800424;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1084358656;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1752301569;
				if (num != 0)
				{
				}
				num = (short)1877147648;
				if (num != 0)
				{
				}
				return this.trkWideAdvancedFullSpectrumControlChannelScan_A8161.Applicable;
			}
			set
			{
				short num = (short)1026930162;
				short num2 = num;
				num = (short)103003634;
				switch (num2 == num)
				{
				default:
				{
					num = (short)178978816;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1323368448;
				if (num != 0)
				{
				}
				num = (short)15466497;
				if (num != 0)
				{
				}
				this.trkWideAdvancedFullSpectrumControlChannelScan_A8161.Applicable = value;
			}
		}

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x0600044B RID: 1099 RVA: 0x0004EF54 File Offset: 0x0004D154
		// (set) Token: 0x0600044C RID: 1100 RVA: 0x0004F00C File Offset: 0x0004D20C
		public bool TrkWideAdvancedFullSpectrumControlChannelScan_A8161_Valid
		{
			get
			{
				short num = (short)1708706503;
				short num2 = num;
				num = (short)540986055;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1909260288;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1920139265;
				if (num != 0)
				{
				}
				num = (short)951844864;
				if (num != 0)
				{
				}
				return this.trkWideAdvancedFullSpectrumControlChannelScan_A8161.Valid;
			}
			set
			{
				short num = (short)826654657;
				short num2 = num;
				num = (short)741457857;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1241055232;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2086338561;
				if (num != 0)
				{
				}
				num = (short)2092302336;
				if (num != 0)
				{
				}
				this.trkWideAdvancedFullSpectrumControlChannelScan_A8161.Valid = value;
			}
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x0600044D RID: 1101 RVA: 0x0004F0C4 File Offset: 0x0004D2C4
		// (set) Token: 0x0600044E RID: 1102 RVA: 0x0004F17C File Offset: 0x0004D37C
		public bool TrkWideAdvancedFullSpectrumControlChannelScan_A8161_Visible
		{
			get
			{
				short num = (short)55070986;
				short num2 = num;
				num = (short)814305546;
				switch (num2 == num)
				{
				default:
				{
					num = (short)16646144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1189740544;
				if (num != 0)
				{
				}
				num = (short)855703553;
				if (num != 0)
				{
				}
				return this.trkWideAdvancedFullSpectrumControlChannelScan_A8161.Visible;
			}
			set
			{
				short num = (short)187094898;
				short num2 = num;
				num = (short)1326307186;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1699938304;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)661323776;
				if (num != 0)
				{
				}
				num = (short)446627841;
				if (num != 0)
				{
				}
				this.trkWideAdvancedFullSpectrumControlChannelScan_A8161.Visible = value;
			}
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x0600044F RID: 1103 RVA: 0x0004F230 File Offset: 0x0004D430
		// (set) Token: 0x06000450 RID: 1104 RVA: 0x0004F2E8 File Offset: 0x0004D4E8
		public bool TrkWideAdvancedFullSpectrumControlChannelScan_A8161_Editable
		{
			get
			{
				short num = (short)1990066177;
				if (num != 0)
				{
				}
				num = (short)46923776;
				short num2 = num;
				num = (short)2080768136;
				short num3 = num;
				num = (short)226623624;
				switch (num3 == num)
				{
				}
				num = (short)1348272128;
				if (num != 0)
				{
				}
				return this.trkWideAdvancedFullSpectrumControlChannelScan_A8161.Editable;
			}
			set
			{
				short num = (short)1017232979;
				short num2 = num;
				num = (short)72793683;
				switch (num2 == num)
				{
				default:
				{
					num = (short)990314496;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2063663104;
				if (num != 0)
				{
				}
				num = (short)850984961;
				if (num != 0)
				{
				}
				this.trkWideAdvancedFullSpectrumControlChannelScan_A8161.Editable = value;
			}
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x06000451 RID: 1105 RVA: 0x0004F3A0 File Offset: 0x0004D5A0
		internal string TrkWideAdvancedFullSpectrumControlChannelScan_A8161_UILabel
		{
			get
			{
				short num = (short)571756374;
				short num2 = num;
				num = (short)1217220438;
				switch (num2 == num)
				{
				}
				num = (short)102498304;
				short num3 = num;
				num = (short)1336016897;
				if (num != 0)
				{
				}
				num = (short)99942400;
				if (num != 0)
				{
				}
				return this.trkWideAdvancedFullSpectrumControlChannelScan_A8161.UIName;
			}
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x06000452 RID: 1106 RVA: 0x0004F454 File Offset: 0x0004D654
		// (set) Token: 0x06000453 RID: 1107 RVA: 0x0004F504 File Offset: 0x0004D704
		internal bool TrkWideAdvancedFullSpectrumControlChannelScan_A8161_HiddenStatic
		{
			get
			{
				short num = (short)1830993523;
				short num2 = num;
				num = (short)911588979;
				switch (num2 == num)
				{
				}
				num = (short)1918238720;
				short num3 = num;
				num = (short)2110128129;
				if (num != 0)
				{
				}
				num = (short)291307520;
				if (num != 0)
				{
				}
				return this.trkWideAdvancedFullSpectrumControlChannelScan_A8161.HiddenStatic;
			}
			set
			{
				short num = (short)1120958345;
				short num2 = num;
				num = (short)606959497;
				switch (num2 == num)
				{
				}
				num = (short)529334272;
				short num3 = num;
				num = (short)987758593;
				if (num != 0)
				{
				}
				num = (short)296288256;
				if (num != 0)
				{
				}
				this.trkWideAdvancedFullSpectrumControlChannelScan_A8161.HiddenStatic = value;
			}
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x06000454 RID: 1108 RVA: 0x0004F5BC File Offset: 0x0004D7BC
		// (set) Token: 0x06000455 RID: 1109 RVA: 0x0004F670 File Offset: 0x0004D870
		internal bool TrkWideAdvancedFullSpectrumControlChannelScan_A8161_HiddenDynamic
		{
			get
			{
				short num = (short)478310216;
				short num2 = num;
				num = (short)1659924296;
				switch (num2 == num)
				{
				}
				num = (short)1261568000;
				short num3 = num;
				num = (short)706215937;
				if (num != 0)
				{
				}
				num = (short)1542193152;
				if (num != 0)
				{
				}
				return this.trkWideAdvancedFullSpectrumControlChannelScan_A8161.HiddenDynamic;
			}
			set
			{
				short num = (short)565848163;
				short num2 = num;
				num = (short)948119651;
				switch (num2 == num)
				{
				}
				num = (short)1608253440;
				short num3 = num;
				num = (short)1402601472;
				if (num != 0)
				{
				}
				num = (short)584187905;
				if (num != 0)
				{
				}
				this.trkWideAdvancedFullSpectrumControlChannelScan_A8161.HiddenDynamic = value;
			}
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x06000456 RID: 1110 RVA: 0x0004F724 File Offset: 0x0004D924
		public bool TrkWideAdvancedFullSpectrumControlChannelScan_A8161_HasDiffs
		{
			get
			{
				short num = (short)552632037;
				short num2 = num;
				num = (short)2101051109;
				switch (num2 == num)
				{
				}
				num = (short)363593728;
				short num3 = num;
				num = (short)1742733312;
				if (num != 0)
				{
				}
				num = (short)1093861377;
				if (num != 0)
				{
				}
				return this.trkWideAdvancedFullSpectrumControlChannelScan_A8161._HasDiffs;
			}
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x06000457 RID: 1111 RVA: 0x0004F7DC File Offset: 0x0004D9DC
		// (set) Token: 0x06000458 RID: 1112 RVA: 0x0004F890 File Offset: 0x0004DA90
		public int TrkWideAdvancedInternalRadioHoldoffmin_A8309Value
		{
			get
			{
				short num = (short)941554070;
				short num2 = num;
				num = (short)1618868630;
				switch (num2 == num)
				{
				}
				num = (short)19529728;
				short num3 = num;
				num = (short)903872512;
				if (num != 0)
				{
				}
				num = (short)492503041;
				if (num != 0)
				{
				}
				return this.trkWideAdvancedInternalRadioHoldoffmin_A8309.Value;
			}
			set
			{
				short num = (short)2031967222;
				short num2 = num;
				num = (short)1514167286;
				switch (num2 == num)
				{
				}
				num = (short)1070071808;
				short num3 = num;
				num = (short)851378177;
				if (num != 0)
				{
				}
				num = (short)651886592;
				if (num != 0)
				{
				}
				this.trkWideAdvancedInternalRadioHoldoffmin_A8309.Value = value;
			}
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x06000459 RID: 1113 RVA: 0x0004F944 File Offset: 0x0004DB44
		public global::AcpBusinessLayer.AcpSimpleRangeField TrkWideAdvancedInternalRadioHoldoffmin_A8309
		{
			get
			{
				short num = (short)1298595841;
				if (num != 0)
				{
				}
				num = (short)1776115584;
				short num2 = num;
				num = (short)428695424;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1510277120;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1159397376;
				if (num != 0)
				{
				}
				return this.trkWideAdvancedInternalRadioHoldoffmin_A8309;
			}
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x0600045A RID: 1114 RVA: 0x0004F9F4 File Offset: 0x0004DBF4
		// (set) Token: 0x0600045B RID: 1115 RVA: 0x0004FAA8 File Offset: 0x0004DCA8
		public string TrkWideAdvancedInternalRadioHoldoffmin_A8309_UIValue
		{
			get
			{
				short num = (short)557110805;
				short num2 = num;
				num = (short)591779349;
				switch (num2 == num)
				{
				}
				num = (short)252248064;
				short num3 = num;
				num = (short)1929641985;
				if (num != 0)
				{
				}
				num = (short)2067202048;
				if (num != 0)
				{
				}
				return this.trkWideAdvancedInternalRadioHoldoffmin_A8309.UIValue;
			}
			set
			{
				short num = (short)550020337;
				short num2 = num;
				num = (short)1648534769;
				switch (num2 == num)
				{
				}
				num = (short)1007616000;
				short num3 = num;
				num = (short)910229505;
				if (num != 0)
				{
				}
				num = (short)72220672;
				if (num != 0)
				{
				}
				this.trkWideAdvancedInternalRadioHoldoffmin_A8309.UIValue = value;
			}
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x0600045C RID: 1116 RVA: 0x0004FB60 File Offset: 0x0004DD60
		// (set) Token: 0x0600045D RID: 1117 RVA: 0x0004FC14 File Offset: 0x0004DE14
		internal int TrkWideAdvancedInternalRadioHoldoffmin_A8309Min
		{
			get
			{
				short num = (short)765081889;
				short num2 = num;
				num = (short)759249185;
				switch (num2 == num)
				{
				}
				num = (short)902496256;
				short num3 = num;
				num = (short)1065418753;
				if (num != 0)
				{
				}
				num = (short)1053622272;
				if (num != 0)
				{
				}
				return this.trkWideAdvancedInternalRadioHoldoffmin_A8309.Min;
			}
			set
			{
				short num = (short)252059515;
				short num2 = num;
				num = (short)2137005947;
				switch (num2 == num)
				{
				}
				num = (short)722993152;
				short num3 = num;
				num = (short)1520828417;
				if (num != 0)
				{
				}
				num = (short)622919680;
				if (num != 0)
				{
				}
				this.trkWideAdvancedInternalRadioHoldoffmin_A8309.Min = value;
			}
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x0600045E RID: 1118 RVA: 0x0004FCC8 File Offset: 0x0004DEC8
		// (set) Token: 0x0600045F RID: 1119 RVA: 0x0004FD7C File Offset: 0x0004DF7C
		internal int TrkWideAdvancedInternalRadioHoldoffmin_A8309Max
		{
			get
			{
				short num = (short)1135153589;
				short num2 = num;
				num = (short)429658549;
				switch (num2 == num)
				{
				}
				num = (short)1182924800;
				short num3 = num;
				num = (short)95748096;
				if (num != 0)
				{
				}
				num = (short)1192558593;
				if (num != 0)
				{
				}
				return this.trkWideAdvancedInternalRadioHoldoffmin_A8309.Max;
			}
			set
			{
				short num = (short)2123038721;
				if (num != 0)
				{
				}
				num = (short)1627330137;
				short num2 = num;
				num = (short)1980175961;
				switch (num2 == num)
				{
				default:
				{
					num = (short)527040512;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)148045824;
				if (num != 0)
				{
				}
				this.trkWideAdvancedInternalRadioHoldoffmin_A8309.Max = value;
			}
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x06000460 RID: 1120 RVA: 0x0004FE34 File Offset: 0x0004E034
		// (set) Token: 0x06000461 RID: 1121 RVA: 0x0004FEEC File Offset: 0x0004E0EC
		internal int TrkWideAdvancedInternalRadioHoldoffmin_A8309Step
		{
			get
			{
				short num = (short)1859273208;
				short num2 = num;
				num = (short)194527736;
				switch (num2 == num)
				{
				}
				num = (short)231604224;
				short num3 = num;
				num = (short)53477377;
				if (num != 0)
				{
				}
				num = (short)1235025920;
				if (num != 0)
				{
				}
				return this.trkWideAdvancedInternalRadioHoldoffmin_A8309.StepSize;
			}
			set
			{
				short num = (short)1068248147;
				short num2 = num;
				num = (short)989801555;
				switch (num2 == num)
				{
				}
				num = (short)249298944;
				short num3 = num;
				num = (short)1103429633;
				if (num != 0)
				{
				}
				num = (short)1709375488;
				if (num != 0)
				{
				}
				this.trkWideAdvancedInternalRadioHoldoffmin_A8309.StepSize = value;
			}
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x06000462 RID: 1122 RVA: 0x0004FFA0 File Offset: 0x0004E1A0
		// (set) Token: 0x06000463 RID: 1123 RVA: 0x00050058 File Offset: 0x0004E258
		public bool TrkWideAdvancedInternalRadioHoldoffmin_A8309_Applicable
		{
			get
			{
				short num = (short)1733953416;
				short num2 = num;
				num = (short)1024591752;
				switch (num2 == num)
				{
				}
				num = (short)186384384;
				short num3 = num;
				num = (short)1504641024;
				if (num != 0)
				{
				}
				num = (short)1247084545;
				if (num != 0)
				{
				}
				return this.trkWideAdvancedInternalRadioHoldoffmin_A8309.Applicable;
			}
			set
			{
				short num = (short)1855223138;
				short num2 = num;
				num = (short)297760098;
				switch (num2 == num)
				{
				}
				num = (short)2045313024;
				short num3 = num;
				num = (short)910229505;
				if (num != 0)
				{
				}
				num = (short)609615872;
				if (num != 0)
				{
				}
				this.trkWideAdvancedInternalRadioHoldoffmin_A8309.Applicable = value;
			}
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x06000464 RID: 1124 RVA: 0x00050110 File Offset: 0x0004E310
		// (set) Token: 0x06000465 RID: 1125 RVA: 0x000501C4 File Offset: 0x0004E3C4
		public bool TrkWideAdvancedInternalRadioHoldoffmin_A8309_Valid
		{
			get
			{
				short num = (short)549159635;
				short num2 = num;
				num = (short)1849262803;
				switch (num2 == num)
				{
				}
				num = (short)1857290240;
				short num3 = num;
				num = (short)1677852673;
				if (num != 0)
				{
				}
				num = (short)109969408;
				if (num != 0)
				{
				}
				return this.trkWideAdvancedInternalRadioHoldoffmin_A8309.Valid;
			}
			set
			{
				short num = (short)439233186;
				short num2 = num;
				num = (short)1117072034;
				switch (num2 == num)
				{
				}
				num = (short)753270784;
				short num3 = num;
				num = (short)654966785;
				if (num != 0)
				{
				}
				num = (short)1062076416;
				if (num != 0)
				{
				}
				this.trkWideAdvancedInternalRadioHoldoffmin_A8309.Valid = value;
			}
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x06000466 RID: 1126 RVA: 0x0005027C File Offset: 0x0004E47C
		// (set) Token: 0x06000467 RID: 1127 RVA: 0x00050330 File Offset: 0x0004E530
		public bool TrkWideAdvancedInternalRadioHoldoffmin_A8309_Visible
		{
			get
			{
				short num = (short)232989233;
				short num2 = num;
				num = (short)356721201;
				switch (num2 == num)
				{
				}
				num = (short)1227030528;
				short num3 = num;
				num = (short)166592513;
				if (num != 0)
				{
				}
				num = (short)220528640;
				if (num != 0)
				{
				}
				return this.trkWideAdvancedInternalRadioHoldoffmin_A8309.Visible;
			}
			set
			{
				short num = (short)445421883;
				short num2 = num;
				num = (short)983210299;
				switch (num2 == num)
				{
				}
				num = (short)160825344;
				short num3 = num;
				num = (short)149422081;
				if (num != 0)
				{
				}
				num = (short)492044288;
				if (num != 0)
				{
				}
				this.trkWideAdvancedInternalRadioHoldoffmin_A8309.Visible = value;
			}
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x06000468 RID: 1128 RVA: 0x000503E8 File Offset: 0x0004E5E8
		// (set) Token: 0x06000469 RID: 1129 RVA: 0x0005049C File Offset: 0x0004E69C
		public bool TrkWideAdvancedInternalRadioHoldoffmin_A8309_Editable
		{
			get
			{
				short num = (short)5373953;
				if (num != 0)
				{
				}
				num = (short)1161982017;
				short num2 = num;
				num = (short)1839099969;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1250033664;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1606287360;
				if (num != 0)
				{
				}
				return this.trkWideAdvancedInternalRadioHoldoffmin_A8309.Editable;
			}
			set
			{
				short num = (short)1310785537;
				if (num != 0)
				{
				}
				num = (short)1051609382;
				short num2 = num;
				num = (short)1470908710;
				switch (num2 == num)
				{
				default:
				{
					num = (short)221249536;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)924647424;
				if (num != 0)
				{
				}
				this.trkWideAdvancedInternalRadioHoldoffmin_A8309.Editable = value;
			}
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x0600046A RID: 1130 RVA: 0x00050550 File Offset: 0x0004E750
		internal string TrkWideAdvancedInternalRadioHoldoffmin_A8309_UILabel
		{
			get
			{
				short num = (short)2013550613;
				short num2 = num;
				num = (short)1194743829;
				switch (num2 == num)
				{
				}
				num = (short)1543110656;
				short num3 = num;
				num = (short)740229120;
				if (num != 0)
				{
				}
				num = (short)593756161;
				if (num != 0)
				{
				}
				return this.trkWideAdvancedInternalRadioHoldoffmin_A8309.UIName;
			}
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x0600046B RID: 1131 RVA: 0x00050604 File Offset: 0x0004E804
		// (set) Token: 0x0600046C RID: 1132 RVA: 0x000506B8 File Offset: 0x0004E8B8
		internal bool TrkWideAdvancedInternalRadioHoldoffmin_A8309_HiddenStatic
		{
			get
			{
				short num = (short)428188210;
				short num2 = num;
				num = (short)570270258;
				switch (num2 == num)
				{
				}
				num = (short)736165888;
				short num3 = num;
				num = (short)255721473;
				if (num != 0)
				{
				}
				num = (short)1816788992;
				if (num != 0)
				{
				}
				return this.trkWideAdvancedInternalRadioHoldoffmin_A8309.HiddenStatic;
			}
			set
			{
				short num = (short)755892225;
				if (num != 0)
				{
				}
				num = (short)1824655507;
				short num2 = num;
				num = (short)1081280659;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1888616448;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)185335808;
				if (num != 0)
				{
				}
				this.trkWideAdvancedInternalRadioHoldoffmin_A8309.HiddenStatic = value;
			}
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x0600046D RID: 1133 RVA: 0x00050770 File Offset: 0x0004E970
		// (set) Token: 0x0600046E RID: 1134 RVA: 0x00050824 File Offset: 0x0004EA24
		internal bool TrkWideAdvancedInternalRadioHoldoffmin_A8309_HiddenDynamic
		{
			get
			{
				short num = (short)1202257921;
				if (num != 0)
				{
				}
				num = (short)1282511774;
				short num2 = num;
				num = (short)645174174;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1761280000;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)674299904;
				if (num != 0)
				{
				}
				return this.trkWideAdvancedInternalRadioHoldoffmin_A8309.HiddenDynamic;
			}
			set
			{
				short num = (short)463714377;
				short num2 = num;
				num = (short)855291977;
				switch (num2 == num)
				{
				}
				num = (short)2042691584;
				short num3 = num;
				num = (short)2063466497;
				if (num != 0)
				{
				}
				num = (short)886833152;
				if (num != 0)
				{
				}
				this.trkWideAdvancedInternalRadioHoldoffmin_A8309.HiddenDynamic = value;
			}
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x0600046F RID: 1135 RVA: 0x000508D8 File Offset: 0x0004EAD8
		public bool TrkWideAdvancedInternalRadioHoldoffmin_A8309_HasDiffs
		{
			get
			{
				short num = (short)663668202;
				short num2 = num;
				num = (short)710657514;
				switch (num2 == num)
				{
				}
				num = (short)52953088;
				short num3 = num;
				num = (short)1974140929;
				if (num != 0)
				{
				}
				num = (short)701431808;
				if (num != 0)
				{
				}
				return this.trkWideAdvancedInternalRadioHoldoffmin_A8309._HasDiffs;
			}
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x06000470 RID: 1136 RVA: 0x0005098C File Offset: 0x0004EB8C
		// (set) Token: 0x06000471 RID: 1137 RVA: 0x00050A44 File Offset: 0x0004EC44
		public int TrkWideAdvancedISWWindowAdjustment_A8358Value
		{
			get
			{
				short num = (short)1784610817;
				if (num != 0)
				{
				}
				num = (short)560770672;
				short num2 = num;
				num = (short)1085320816;
				switch (num2 == num)
				{
				default:
				{
					num = (short)411500544;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)990773248;
				if (num != 0)
				{
				}
				return this.trkWideAdvancedISWWindowAdjustment_A8358.Value;
			}
			set
			{
				short num = (short)843484806;
				short num2 = num;
				num = (short)642420358;
				switch (num2 == num)
				{
				}
				num = (short)1684865024;
				short num3 = num;
				num = (short)315162624;
				if (num != 0)
				{
				}
				num = (short)1565392897;
				if (num != 0)
				{
				}
				this.trkWideAdvancedISWWindowAdjustment_A8358.Value = value;
			}
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x06000472 RID: 1138 RVA: 0x00050AF8 File Offset: 0x0004ECF8
		public global::AcpBusinessLayer.AcpSimpleRangeField TrkWideAdvancedISWWindowAdjustment_A8358
		{
			get
			{
				short num = (short)381535125;
				short num2 = num;
				num = (short)1455539093;
				switch (num2 == num)
				{
				}
				num = (short)1810694144;
				short num3 = num;
				num = (short)1211301888;
				if (num != 0)
				{
				}
				num = (short)237043713;
				if (num != 0)
				{
				}
				return this.trkWideAdvancedISWWindowAdjustment_A8358;
			}
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x06000473 RID: 1139 RVA: 0x00050BA8 File Offset: 0x0004EDA8
		// (set) Token: 0x06000474 RID: 1140 RVA: 0x00050C60 File Offset: 0x0004EE60
		public string TrkWideAdvancedISWWindowAdjustment_A8358_UIValue
		{
			get
			{
				short num = (short)129239058;
				short num2 = num;
				num = (short)958990354;
				switch (num2 == num)
				{
				}
				num = (short)624951296;
				short num3 = num;
				num = (short)803143681;
				if (num != 0)
				{
				}
				num = (short)2036072448;
				if (num != 0)
				{
				}
				return this.trkWideAdvancedISWWindowAdjustment_A8358.UIValue;
			}
			set
			{
				short num = (short)406696710;
				short num2 = num;
				num = (short)2143269638;
				switch (num2 == num)
				{
				}
				num = (short)1040449536;
				short num3 = num;
				num = (short)1456078848;
				if (num != 0)
				{
				}
				num = (short)1586364417;
				if (num != 0)
				{
				}
				this.trkWideAdvancedISWWindowAdjustment_A8358.UIValue = value;
			}
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x06000475 RID: 1141 RVA: 0x00050D14 File Offset: 0x0004EF14
		// (set) Token: 0x06000476 RID: 1142 RVA: 0x00050DCC File Offset: 0x0004EFCC
		public string TrkWideAdvancedISWWindowAdjustment_A8358_HexUIValue
		{
			get
			{
				short num = (short)1194355913;
				short num2 = num;
				num = (short)582642889;
				switch (num2 == num)
				{
				}
				num = (short)1753284608;
				short num3 = num;
				num = (short)844955648;
				if (num != 0)
				{
				}
				num = (short)666501121;
				if (num != 0)
				{
				}
				return this.trkWideAdvancedISWWindowAdjustment_A8358.HexUIValue;
			}
			set
			{
				short num = (short)372032961;
				short num2 = num;
				num = (short)1576912321;
				switch (num2 == num)
				{
				}
				num = (short)1416232960;
				short num3 = num;
				num = (short)1443364865;
				if (num != 0)
				{
				}
				num = (short)1325596672;
				if (num != 0)
				{
				}
				this.trkWideAdvancedISWWindowAdjustment_A8358.HexUIValue = value;
			}
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x06000477 RID: 1143 RVA: 0x00050E80 File Offset: 0x0004F080
		// (set) Token: 0x06000478 RID: 1144 RVA: 0x00050F34 File Offset: 0x0004F134
		internal int TrkWideAdvancedISWWindowAdjustment_A8358Min
		{
			get
			{
				short num = (short)69410191;
				short num2 = num;
				num = (short)555097487;
				switch (num2 == num)
				{
				}
				num = (short)1922105344;
				short num3 = num;
				num = (short)1387134977;
				if (num != 0)
				{
				}
				num = (short)143130624;
				if (num != 0)
				{
				}
				return this.trkWideAdvancedISWWindowAdjustment_A8358.Min;
			}
			set
			{
				short num = (short)746813201;
				short num2 = num;
				num = (short)917862161;
				switch (num2 == num)
				{
				}
				num = (short)1006698496;
				short num3 = num;
				num = (short)651886592;
				if (num != 0)
				{
				}
				num = (short)795213825;
				if (num != 0)
				{
				}
				this.trkWideAdvancedISWWindowAdjustment_A8358.Min = value;
			}
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x06000479 RID: 1145 RVA: 0x00050FE8 File Offset: 0x0004F1E8
		// (set) Token: 0x0600047A RID: 1146 RVA: 0x0005109C File Offset: 0x0004F29C
		internal int TrkWideAdvancedISWWindowAdjustment_A8358Max
		{
			get
			{
				short num = (short)1083310081;
				if (num != 0)
				{
				}
				num = (short)379118050;
				short num2 = num;
				num = (short)1007411682;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1073676288;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)680329216;
				if (num != 0)
				{
				}
				return this.trkWideAdvancedISWWindowAdjustment_A8358.Max;
			}
			set
			{
				short num = (short)522551269;
				short num2 = num;
				num = (short)951615461;
				switch (num2 == num)
				{
				}
				num = (short)681705472;
				short num3 = num;
				num = (short)473628673;
				if (num != 0)
				{
				}
				num = (short)1084227584;
				if (num != 0)
				{
				}
				this.trkWideAdvancedISWWindowAdjustment_A8358.Max = value;
			}
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x0600047B RID: 1147 RVA: 0x00051154 File Offset: 0x0004F354
		// (set) Token: 0x0600047C RID: 1148 RVA: 0x00051208 File Offset: 0x0004F408
		internal int TrkWideAdvancedISWWindowAdjustment_A8358Step
		{
			get
			{
				short num = (short)492753229;
				short num2 = num;
				num = (short)1171575117;
				switch (num2 == num)
				{
				}
				num = (short)1395392512;
				short num3 = num;
				num = (short)610598913;
				if (num != 0)
				{
				}
				num = (short)1507524608;
				if (num != 0)
				{
				}
				return this.trkWideAdvancedISWWindowAdjustment_A8358.StepSize;
			}
			set
			{
				short num = (short)1059733854;
				short num2 = num;
				num = (short)597246302;
				switch (num2 == num)
				{
				}
				num = (short)1406271488;
				short num3 = num;
				num = (short)196345857;
				if (num != 0)
				{
				}
				num = (short)126091264;
				if (num != 0)
				{
				}
				this.trkWideAdvancedISWWindowAdjustment_A8358.StepSize = value;
			}
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x0600047D RID: 1149 RVA: 0x000512C0 File Offset: 0x0004F4C0
		// (set) Token: 0x0600047E RID: 1150 RVA: 0x00051378 File Offset: 0x0004F578
		public bool TrkWideAdvancedISWWindowAdjustment_A8358_Applicable
		{
			get
			{
				short num = (short)1714490532;
				short num2 = num;
				num = (short)685903012;
				switch (num2 == num)
				{
				}
				num = (short)1610088448;
				short num3 = num;
				num = (short)1468727297;
				if (num != 0)
				{
				}
				num = (short)1858076672;
				if (num != 0)
				{
				}
				return this.trkWideAdvancedISWWindowAdjustment_A8358.Applicable;
			}
			set
			{
				short num = (short)366262368;
				short num2 = num;
				num = (short)2073737312;
				switch (num2 == num)
				{
				}
				num = (short)815595520;
				short num3 = num;
				num = (short)93388801;
				if (num != 0)
				{
				}
				num = (short)1268645888;
				if (num != 0)
				{
				}
				this.trkWideAdvancedISWWindowAdjustment_A8358.Applicable = value;
			}
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x0600047F RID: 1151 RVA: 0x0005142C File Offset: 0x0004F62C
		// (set) Token: 0x06000480 RID: 1152 RVA: 0x000514E0 File Offset: 0x0004F6E0
		public bool TrkWideAdvancedISWWindowAdjustment_A8358_Valid
		{
			get
			{
				short num = (short)278099263;
				short num2 = num;
				num = (short)1476031807;
				switch (num2 == num)
				{
				}
				num = (short)526254080;
				short num3 = num;
				num = (short)1497038849;
				if (num != 0)
				{
				}
				num = (short)2067005440;
				if (num != 0)
				{
				}
				return this.trkWideAdvancedISWWindowAdjustment_A8358.Valid;
			}
			set
			{
				short num = (short)169601778;
				short num2 = num;
				num = (short)116648690;
				switch (num2 == num)
				{
				}
				num = (short)57999360;
				short num3 = num;
				num = (short)73728001;
				if (num != 0)
				{
				}
				num = (short)865665024;
				if (num != 0)
				{
				}
				this.trkWideAdvancedISWWindowAdjustment_A8358.Valid = value;
			}
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x06000481 RID: 1153 RVA: 0x00051594 File Offset: 0x0004F794
		// (set) Token: 0x06000482 RID: 1154 RVA: 0x0005164C File Offset: 0x0004F84C
		public bool TrkWideAdvancedISWWindowAdjustment_A8358_Visible
		{
			get
			{
				short num = (short)1353818009;
				short num2 = num;
				num = (short)580034457;
				switch (num2 == num)
				{
				}
				num = (short)1377239040;
				short num3 = num;
				num = (short)129236992;
				if (num != 0)
				{
				}
				num = (short)1209073665;
				if (num != 0)
				{
				}
				return this.trkWideAdvancedISWWindowAdjustment_A8358.Visible;
			}
			set
			{
				short num = (short)1920174287;
				short num2 = num;
				num = (short)1981647055;
				switch (num2 == num)
				{
				}
				num = (short)829161472;
				short num3 = num;
				num = (short)1569193985;
				if (num != 0)
				{
				}
				num = (short)1608450048;
				if (num != 0)
				{
				}
				this.trkWideAdvancedISWWindowAdjustment_A8358.Visible = value;
			}
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x06000483 RID: 1155 RVA: 0x00051704 File Offset: 0x0004F904
		// (set) Token: 0x06000484 RID: 1156 RVA: 0x000517B8 File Offset: 0x0004F9B8
		public bool TrkWideAdvancedISWWindowAdjustment_A8358_Editable
		{
			get
			{
				short num = (short)1513919341;
				short num2 = num;
				num = (short)661033837;
				switch (num2 == num)
				{
				}
				num = (short)1112604672;
				short num3 = num;
				num = (short)1650589697;
				if (num != 0)
				{
				}
				num = (short)927793152;
				if (num != 0)
				{
				}
				return this.trkWideAdvancedISWWindowAdjustment_A8358.Editable;
			}
			set
			{
				short num = (short)1688881538;
				short num2 = num;
				num = (short)1851083138;
				switch (num2 == num)
				{
				}
				num = (short)487718912;
				short num3 = num;
				num = (short)1991835648;
				if (num != 0)
				{
				}
				num = (short)859373569;
				if (num != 0)
				{
				}
				this.trkWideAdvancedISWWindowAdjustment_A8358.Editable = value;
			}
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x06000485 RID: 1157 RVA: 0x00051870 File Offset: 0x0004FA70
		internal string TrkWideAdvancedISWWindowAdjustment_A8358_UILabel
		{
			get
			{
				short num = (short)601842191;
				short num2 = num;
				num = (short)55337487;
				switch (num2 == num)
				{
				}
				num = (short)686096384;
				short num3 = num;
				num = (short)1006895105;
				if (num != 0)
				{
				}
				num = (short)439091200;
				if (num != 0)
				{
				}
				return this.trkWideAdvancedISWWindowAdjustment_A8358.UIName;
			}
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x06000486 RID: 1158 RVA: 0x00051928 File Offset: 0x0004FB28
		// (set) Token: 0x06000487 RID: 1159 RVA: 0x000519DC File Offset: 0x0004FBDC
		internal bool TrkWideAdvancedISWWindowAdjustment_A8358_HiddenStatic
		{
			get
			{
				short num = (short)1515224500;
				short num2 = num;
				num = (short)1362722228;
				switch (num2 == num)
				{
				}
				num = (short)936574976;
				if (num != 0)
				{
				}
				num = (short)1004535808;
				short num3 = num;
				num = (short)2134638593;
				if (num != 0)
				{
				}
				return this.trkWideAdvancedISWWindowAdjustment_A8358.HiddenStatic;
			}
			set
			{
				short num = (short)2008322992;
				short num2 = num;
				num = (short)1916310448;
				switch (num2 == num)
				{
				}
				num = (short)1635450881;
				if (num != 0)
				{
				}
				num = (short)1186529280;
				short num3 = num;
				num = (short)1566113792;
				if (num != 0)
				{
				}
				this.trkWideAdvancedISWWindowAdjustment_A8358.HiddenStatic = value;
			}
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x06000488 RID: 1160 RVA: 0x00051A90 File Offset: 0x0004FC90
		// (set) Token: 0x06000489 RID: 1161 RVA: 0x00051B44 File Offset: 0x0004FD44
		internal bool TrkWideAdvancedISWWindowAdjustment_A8358_HiddenDynamic
		{
			get
			{
				short num = (short)1396387108;
				short num2 = num;
				num = (short)1777282340;
				switch (num2 == num)
				{
				}
				num = (short)1473118209;
				if (num != 0)
				{
				}
				num = (short)1246298112;
				short num3 = num;
				num = (short)1445855232;
				if (num != 0)
				{
				}
				return this.trkWideAdvancedISWWindowAdjustment_A8358.HiddenDynamic;
			}
			set
			{
				short num = (short)1395195905;
				if (num != 0)
				{
				}
				num = (short)2107254072;
				short num2 = num;
				num = (short)674178360;
				switch (num2 == num)
				{
				}
				num = (short)1343553536;
				short num3 = num;
				num = (short)1396703232;
				if (num != 0)
				{
				}
				this.trkWideAdvancedISWWindowAdjustment_A8358.HiddenDynamic = value;
			}
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x0600048A RID: 1162 RVA: 0x00051BF8 File Offset: 0x0004FDF8
		public bool TrkWideAdvancedISWWindowAdjustment_A8358_HasDiffs
		{
			get
			{
				short num = (short)1810106184;
				short num2 = num;
				num = (short)2098726728;
				switch (num2 == num)
				{
				}
				num = (short)1623785473;
				if (num != 0)
				{
				}
				num = (short)38731776;
				short num3 = num;
				num = (short)566558720;
				if (num != 0)
				{
				}
				return this.trkWideAdvancedISWWindowAdjustment_A8358._HasDiffs;
			}
		}

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x0600048B RID: 1163 RVA: 0x00051CAC File Offset: 0x0004FEAC
		// (set) Token: 0x0600048C RID: 1164 RVA: 0x00051D60 File Offset: 0x0004FF60
		public int TrkWideAdvancedFullSpectrumControlChannelScanTimersec_A8162Value
		{
			get
			{
				short num = (short)80225825;
				short num2 = num;
				num = (short)995698209;
				switch (num2 == num)
				{
				}
				num = (short)975175681;
				if (num != 0)
				{
				}
				num = (short)1065484288;
				short num3 = num;
				num = (short)852623360;
				if (num != 0)
				{
				}
				return this.trkWideAdvancedFullSpectrumControlChannelScanTimersec_A8162.Value;
			}
			set
			{
				short num = (short)1523580929;
				if (num != 0)
				{
				}
				num = (short)1061998670;
				short num2 = num;
				num = (short)554815566;
				switch (num2 == num)
				{
				}
				num = (short)74252288;
				short num3 = num;
				num = (short)687996928;
				if (num != 0)
				{
				}
				this.trkWideAdvancedFullSpectrumControlChannelScanTimersec_A8162.Value = value;
			}
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x0600048D RID: 1165 RVA: 0x00051E14 File Offset: 0x00050014
		public global::AcpBusinessLayer.AcpSimpleRangeField TrkWideAdvancedFullSpectrumControlChannelScanTimersec_A8162
		{
			get
			{
				short num = (short)1610734771;
				short num2 = num;
				num = (short)2068438195;
				switch (num2 == num)
				{
				}
				num = (short)610926593;
				if (num != 0)
				{
				}
				num = (short)112132096;
				short num3 = num;
				num = (short)1091698688;
				if (num != 0)
				{
				}
				return this.trkWideAdvancedFullSpectrumControlChannelScanTimersec_A8162;
			}
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x0600048E RID: 1166 RVA: 0x00051EC4 File Offset: 0x000500C4
		// (set) Token: 0x0600048F RID: 1167 RVA: 0x00051F7C File Offset: 0x0005017C
		public string TrkWideAdvancedFullSpectrumControlChannelScanTimersec_A8162_UIValue
		{
			get
			{
				short num = (short)1290989826;
				short num2 = num;
				num = (short)2104619266;
				switch (num2 == num)
				{
				}
				num = (short)173604864;
				if (num != 0)
				{
				}
				num = (short)1951989760;
				short num3 = num;
				num = (short)26214401;
				if (num != 0)
				{
				}
				return this.trkWideAdvancedFullSpectrumControlChannelScanTimersec_A8162.UIValue;
			}
			set
			{
				short num = (short)1998506071;
				short num2 = num;
				num = (short)173000791;
				switch (num2 == num)
				{
				}
				num = (short)1054081025;
				if (num != 0)
				{
				}
				num = (short)248184832;
				short num3 = num;
				num = (short)354811904;
				if (num != 0)
				{
				}
				this.trkWideAdvancedFullSpectrumControlChannelScanTimersec_A8162.UIValue = value;
			}
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x06000490 RID: 1168 RVA: 0x00052030 File Offset: 0x00050230
		// (set) Token: 0x06000491 RID: 1169 RVA: 0x000520E8 File Offset: 0x000502E8
		internal int TrkWideAdvancedFullSpectrumControlChannelScanTimersec_A8162Min
		{
			get
			{
				short num = (short)96315190;
				short num2 = num;
				num = (short)1341237046;
				switch (num2 == num)
				{
				}
				num = (short)1034158080;
				if (num != 0)
				{
				}
				num = (short)584122368;
				short num3 = num;
				num = (short)288227329;
				if (num != 0)
				{
				}
				return this.trkWideAdvancedFullSpectrumControlChannelScanTimersec_A8162.Min;
			}
			set
			{
				short num = (short)929173546;
				short num2 = num;
				num = (short)1573457962;
				switch (num2 == num)
				{
				}
				num = (short)40108033;
				if (num != 0)
				{
				}
				num = (short)216203264;
				short num3 = num;
				num = (short)1556086784;
				if (num != 0)
				{
				}
				this.trkWideAdvancedFullSpectrumControlChannelScanTimersec_A8162.Min = value;
			}
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x06000492 RID: 1170 RVA: 0x0005219C File Offset: 0x0005039C
		// (set) Token: 0x06000493 RID: 1171 RVA: 0x00052254 File Offset: 0x00050454
		internal int TrkWideAdvancedFullSpectrumControlChannelScanTimersec_A8162Max
		{
			get
			{
				short num = (short)429717120;
				short num2 = num;
				num = (short)1736439424;
				switch (num2 == num)
				{
				}
				num = (short)1204027393;
				if (num != 0)
				{
				}
				num = (short)1522597888;
				short num3 = num;
				num = (short)1825112064;
				if (num != 0)
				{
				}
				return this.trkWideAdvancedFullSpectrumControlChannelScanTimersec_A8162.Max;
			}
			set
			{
				short num = (short)1572907675;
				short num2 = num;
				num = (short)2136124059;
				switch (num2 == num)
				{
				}
				num = (short)1421803521;
				if (num != 0)
				{
				}
				num = (short)1802174464;
				short num3 = num;
				num = (short)140967936;
				if (num != 0)
				{
				}
				this.trkWideAdvancedFullSpectrumControlChannelScanTimersec_A8162.Max = value;
			}
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x06000494 RID: 1172 RVA: 0x00052308 File Offset: 0x00050508
		// (set) Token: 0x06000495 RID: 1173 RVA: 0x000523BC File Offset: 0x000505BC
		internal int TrkWideAdvancedFullSpectrumControlChannelScanTimersec_A8162Step
		{
			get
			{
				short num = (short)4742118;
				short num2 = num;
				num = (short)434002918;
				switch (num2 == num)
				{
				}
				num = (short)1795817473;
				if (num != 0)
				{
				}
				num = (short)1544880128;
				short num3 = num;
				num = (short)209715200;
				if (num != 0)
				{
				}
				return this.trkWideAdvancedFullSpectrumControlChannelScanTimersec_A8162.StepSize;
			}
			set
			{
				short num = (short)1361775011;
				short num2 = num;
				num = (short)1487276451;
				switch (num2 == num)
				{
				}
				num = (short)150011904;
				if (num != 0)
				{
				}
				num = (short)700055552;
				short num3 = num;
				num = (short)1473642497;
				if (num != 0)
				{
				}
				this.trkWideAdvancedFullSpectrumControlChannelScanTimersec_A8162.StepSize = value;
			}
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x06000496 RID: 1174 RVA: 0x00052470 File Offset: 0x00050670
		// (set) Token: 0x06000497 RID: 1175 RVA: 0x00052528 File Offset: 0x00050728
		public bool TrkWideAdvancedFullSpectrumControlChannelScanTimersec_A8162_Applicable
		{
			get
			{
				short num = (short)1569743698;
				short num2 = num;
				num = (short)538075986;
				switch (num2 == num)
				{
				}
				num = (short)1195180033;
				if (num != 0)
				{
				}
				num = (short)1854930944;
				short num3 = num;
				num = (short)1591410688;
				if (num != 0)
				{
				}
				return this.trkWideAdvancedFullSpectrumControlChannelScanTimersec_A8162.Applicable;
			}
			set
			{
				short num = (short)236639534;
				short num2 = num;
				num = (short)977392942;
				switch (num2 == num)
				{
				}
				num = (short)326107137;
				if (num != 0)
				{
				}
				num = (short)2135162880;
				short num3 = num;
				num = (short)288620544;
				if (num != 0)
				{
				}
				this.trkWideAdvancedFullSpectrumControlChannelScanTimersec_A8162.Applicable = value;
			}
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x06000498 RID: 1176 RVA: 0x000525DC File Offset: 0x000507DC
		// (set) Token: 0x06000499 RID: 1177 RVA: 0x00052694 File Offset: 0x00050894
		public bool TrkWideAdvancedFullSpectrumControlChannelScanTimersec_A8162_Valid
		{
			get
			{
				short num = (short)243492497;
				short num2 = num;
				num = (short)1025730193;
				switch (num2 == num)
				{
				}
				num = (short)1379467265;
				if (num != 0)
				{
				}
				num = (short)629473280;
				short num3 = num;
				num = (short)311492608;
				if (num != 0)
				{
				}
				return this.trkWideAdvancedFullSpectrumControlChannelScanTimersec_A8162.Valid;
			}
			set
			{
				short num = (short)953412088;
				short num2 = num;
				num = (short)1682762232;
				switch (num2 == num)
				{
				}
				num = (short)2017329153;
				if (num != 0)
				{
				}
				num = (short)2124087296;
				short num3 = num;
				num = (short)217972736;
				if (num != 0)
				{
				}
				this.trkWideAdvancedFullSpectrumControlChannelScanTimersec_A8162.Valid = value;
			}
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x0600049A RID: 1178 RVA: 0x00052748 File Offset: 0x00050948
		// (set) Token: 0x0600049B RID: 1179 RVA: 0x000527FC File Offset: 0x000509FC
		public bool TrkWideAdvancedFullSpectrumControlChannelScanTimersec_A8162_Visible
		{
			get
			{
				short num = (short)1570438736;
				short num2 = num;
				num = (short)653852240;
				switch (num2 == num)
				{
				}
				num = (short)1431109633;
				if (num != 0)
				{
				}
				num = (short)650575872;
				short num3 = num;
				num = (short)199032832;
				if (num != 0)
				{
				}
				return this.trkWideAdvancedFullSpectrumControlChannelScanTimersec_A8162.Visible;
			}
			set
			{
				short num = (short)1295884529;
				short num2 = num;
				num = (short)2025758961;
				switch (num2 == num)
				{
				}
				num = (short)1233190913;
				if (num != 0)
				{
				}
				num = (short)944373760;
				short num3 = num;
				num = (short)1480785920;
				if (num != 0)
				{
				}
				this.trkWideAdvancedFullSpectrumControlChannelScanTimersec_A8162.Visible = value;
			}
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x0600049C RID: 1180 RVA: 0x000528B4 File Offset: 0x00050AB4
		// (set) Token: 0x0600049D RID: 1181 RVA: 0x00052968 File Offset: 0x00050B68
		public bool TrkWideAdvancedFullSpectrumControlChannelScanTimersec_A8162_Editable
		{
			get
			{
				short num = (short)540125884;
				short num2 = num;
				num = (short)1843767996;
				switch (num2 == num)
				{
				}
				num = (short)1808269312;
				if (num != 0)
				{
				}
				num = (short)1571094528;
				short num3 = num;
				num = (short)641925121;
				if (num != 0)
				{
				}
				return this.trkWideAdvancedFullSpectrumControlChannelScanTimersec_A8162.Editable;
			}
			set
			{
				short num = (short)1099190500;
				short num2 = num;
				num = (short)1156862180;
				switch (num2 == num)
				{
				}
				num = (short)1587281920;
				if (num != 0)
				{
				}
				num = (short)751501312;
				short num3 = num;
				num = (short)1513553921;
				if (num != 0)
				{
				}
				this.trkWideAdvancedFullSpectrumControlChannelScanTimersec_A8162.Editable = value;
			}
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x0600049E RID: 1182 RVA: 0x00052A20 File Offset: 0x00050C20
		internal string TrkWideAdvancedFullSpectrumControlChannelScanTimersec_A8162_UILabel
		{
			get
			{
				short num = (short)936073181;
				short num2 = num;
				num = (short)298473437;
				switch (num2 == num)
				{
				}
				num = (short)777650176;
				if (num != 0)
				{
				}
				num = (short)653590528;
				short num3 = num;
				num = (short)1615593473;
				if (num != 0)
				{
				}
				return this.trkWideAdvancedFullSpectrumControlChannelScanTimersec_A8162.UIName;
			}
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x0600049F RID: 1183 RVA: 0x00052AD8 File Offset: 0x00050CD8
		// (set) Token: 0x060004A0 RID: 1184 RVA: 0x00052B8C File Offset: 0x00050D8C
		internal bool TrkWideAdvancedFullSpectrumControlChannelScanTimersec_A8162_HiddenStatic
		{
			get
			{
				short num = (short)163931036;
				short num2 = num;
				num = (short)2073060252;
				switch (num2 == num)
				{
				}
				num = (short)1569128448;
				if (num != 0)
				{
				}
				num = (short)1684799488;
				short num3 = num;
				num = (short)1637023745;
				if (num != 0)
				{
				}
				return this.trkWideAdvancedFullSpectrumControlChannelScanTimersec_A8162.HiddenStatic;
			}
			set
			{
				short num = (short)871010501;
				short num2 = num;
				num = (short)455577797;
				switch (num2 == num)
				{
				}
				num = (short)267059201;
				if (num != 0)
				{
				}
				num = (short)314441728;
				short num3 = num;
				num = (short)2135752704;
				if (num != 0)
				{
				}
				this.trkWideAdvancedFullSpectrumControlChannelScanTimersec_A8162.HiddenStatic = value;
			}
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x060004A1 RID: 1185 RVA: 0x00052C40 File Offset: 0x00050E40
		// (set) Token: 0x060004A2 RID: 1186 RVA: 0x00052CF4 File Offset: 0x00050EF4
		internal bool TrkWideAdvancedFullSpectrumControlChannelScanTimersec_A8162_HiddenDynamic
		{
			get
			{
				short num = (short)1963188950;
				short num2 = num;
				num = (short)1141760726;
				switch (num2 == num)
				{
				}
				num = (short)693895169;
				if (num != 0)
				{
				}
				num = (short)99090432;
				short num3 = num;
				num = (short)1749680128;
				if (num != 0)
				{
				}
				return this.trkWideAdvancedFullSpectrumControlChannelScanTimersec_A8162.HiddenDynamic;
			}
			set
			{
				short num = (short)1408743231;
				short num2 = num;
				num = (short)1177859903;
				switch (num2 == num)
				{
				}
				num = (short)2040266753;
				if (num != 0)
				{
				}
				num = (short)161218560;
				short num3 = num;
				num = (short)807141376;
				if (num != 0)
				{
				}
				this.trkWideAdvancedFullSpectrumControlChannelScanTimersec_A8162.HiddenDynamic = value;
			}
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x060004A3 RID: 1187 RVA: 0x00052DA8 File Offset: 0x00050FA8
		public bool TrkWideAdvancedFullSpectrumControlChannelScanTimersec_A8162_HasDiffs
		{
			get
			{
				short num = (short)1360750842;
				short num2 = num;
				num = (short)370895098;
				switch (num2 == num)
				{
				}
				num = (short)164167681;
				if (num != 0)
				{
				}
				num = (short)567934976;
				short num3 = num;
				num = (short)1200095232;
				if (num != 0)
				{
				}
				return this.trkWideAdvancedFullSpectrumControlChannelScanTimersec_A8162._HasDiffs;
			}
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x060004A4 RID: 1188 RVA: 0x00052E58 File Offset: 0x00051058
		// (set) Token: 0x060004A5 RID: 1189 RVA: 0x00052F10 File Offset: 0x00051110
		public int TrkWideAdvancedHoldoffDelaysec_A8201Value
		{
			get
			{
				short num = (short)1358760655;
				short num2 = num;
				num = (short)1535314639;
				switch (num2 == num)
				{
				}
				num = (short)1648033792;
				if (num != 0)
				{
				}
				num = (short)1119748096;
				short num3 = num;
				num = (short)1979645953;
				if (num != 0)
				{
				}
				return this.trkWideAdvancedHoldoffDelaysec_A8201.Value;
			}
			set
			{
				short num = (short)633545947;
				short num2 = num;
				num = (short)1446192347;
				switch (num2 == num)
				{
				}
				num = (short)1537540097;
				if (num != 0)
				{
				}
				num = (short)1066663936;
				short num3 = num;
				num = (short)1893793792;
				if (num != 0)
				{
				}
				this.trkWideAdvancedHoldoffDelaysec_A8201.Value = value;
			}
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x060004A6 RID: 1190 RVA: 0x00052FC8 File Offset: 0x000511C8
		public global::AcpBusinessLayer.AcpSimpleRangeField TrkWideAdvancedHoldoffDelaysec_A8201
		{
			get
			{
				short num = (short)271154279;
				short num2 = num;
				num = (short)917077095;
				switch (num2 == num)
				{
				}
				num = (short)1936982017;
				if (num != 0)
				{
				}
				num = (short)957939712;
				short num3 = num;
				num = (short)1785200640;
				if (num != 0)
				{
				}
				return this.trkWideAdvancedHoldoffDelaysec_A8201;
			}
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x060004A7 RID: 1191 RVA: 0x00053078 File Offset: 0x00051278
		// (set) Token: 0x060004A8 RID: 1192 RVA: 0x0005312C File Offset: 0x0005132C
		public string TrkWideAdvancedHoldoffDelaysec_A8201_UIValue
		{
			get
			{
				short num = (short)2005814368;
				short num2 = num;
				num = (short)1849248864;
				switch (num2 == num)
				{
				}
				num = (short)1419378688;
				if (num != 0)
				{
				}
				num = (short)217251840;
				short num3 = num;
				num = (short)2021851137;
				if (num != 0)
				{
				}
				return this.trkWideAdvancedHoldoffDelaysec_A8201.UIValue;
			}
			set
			{
				short num = (short)35918034;
				short num2 = num;
				num = (short)1346048210;
				switch (num2 == num)
				{
				}
				num = (short)170196993;
				if (num != 0)
				{
				}
				num = (short)26279936;
				short num3 = num;
				num = (short)752484352;
				if (num != 0)
				{
				}
				this.trkWideAdvancedHoldoffDelaysec_A8201.UIValue = value;
			}
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x060004A9 RID: 1193 RVA: 0x000531E4 File Offset: 0x000513E4
		// (set) Token: 0x060004AA RID: 1194 RVA: 0x00053298 File Offset: 0x00051498
		internal int TrkWideAdvancedHoldoffDelaysec_A8201Min
		{
			get
			{
				short num = (short)865677284;
				short num2 = num;
				num = (short)589574116;
				switch (num2 == num)
				{
				}
				num = (short)914358273;
				if (num != 0)
				{
				}
				num = (short)2111242240;
				short num3 = num;
				num = (short)931004416;
				if (num != 0)
				{
				}
				return this.trkWideAdvancedHoldoffDelaysec_A8201.Min;
			}
			set
			{
				short num = (short)1231280877;
				short num2 = num;
				num = (short)1788730093;
				switch (num2 == num)
				{
				}
				num = (short)1594753024;
				if (num != 0)
				{
				}
				num = (short)460390400;
				short num3 = num;
				num = (short)902955009;
				if (num != 0)
				{
				}
				this.trkWideAdvancedHoldoffDelaysec_A8201.Min = value;
			}
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x060004AB RID: 1195 RVA: 0x0005334C File Offset: 0x0005154C
		// (set) Token: 0x060004AC RID: 1196 RVA: 0x000533FC File Offset: 0x000515FC
		internal int TrkWideAdvancedHoldoffDelaysec_A8201Max
		{
			get
			{
				short num = (short)1949011406;
				short num2 = num;
				num = (short)1916440014;
				switch (num2 == num)
				{
				}
				num = (short)1053753344;
				if (num != 0)
				{
				}
				num = (short)72548352;
				short num3 = num;
				num = (short)1526988801;
				if (num != 0)
				{
				}
				return this.trkWideAdvancedHoldoffDelaysec_A8201.Max;
			}
			set
			{
				short num = (short)1970300289;
				short num2 = num;
				num = (short)549873025;
				switch (num2 == num)
				{
				}
				num = (short)991494145;
				if (num != 0)
				{
				}
				num = (short)173735936;
				short num3 = num;
				num = (short)1078132736;
				if (num != 0)
				{
				}
				this.trkWideAdvancedHoldoffDelaysec_A8201.Max = value;
			}
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x060004AD RID: 1197 RVA: 0x000534B0 File Offset: 0x000516B0
		// (set) Token: 0x060004AE RID: 1198 RVA: 0x00053568 File Offset: 0x00051768
		internal int TrkWideAdvancedHoldoffDelaysec_A8201Step
		{
			get
			{
				short num = (short)529833887;
				short num2 = num;
				num = (short)1958977439;
				switch (num2 == num)
				{
				}
				num = (short)1198653440;
				if (num != 0)
				{
				}
				num = (short)1729101824;
				short num3 = num;
				num = (short)1026162689;
				if (num != 0)
				{
				}
				return this.trkWideAdvancedHoldoffDelaysec_A8201.StepSize;
			}
			set
			{
				short num = (short)1640451393;
				short num2 = num;
				num = (short)1243106625;
				switch (num2 == num)
				{
				}
				num = (short)2145124353;
				if (num != 0)
				{
				}
				num = (short)1100414976;
				short num3 = num;
				num = (short)956825600;
				if (num != 0)
				{
				}
				this.trkWideAdvancedHoldoffDelaysec_A8201.StepSize = value;
			}
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x060004AF RID: 1199 RVA: 0x00053620 File Offset: 0x00051820
		// (set) Token: 0x060004B0 RID: 1200 RVA: 0x000536D8 File Offset: 0x000518D8
		public bool TrkWideAdvancedHoldoffDelaysec_A8201_Applicable
		{
			get
			{
				short num = (short)1087478365;
				short num2 = num;
				num = (short)643144285;
				switch (num2 == num)
				{
				}
				num = (short)1315241985;
				if (num != 0)
				{
				}
				num = (short)363462656;
				short num3 = num;
				num = (short)753467392;
				if (num != 0)
				{
				}
				return this.trkWideAdvancedHoldoffDelaysec_A8201.Applicable;
			}
			set
			{
				short num = (short)1864102111;
				short num2 = num;
				num = (short)1214509279;
				switch (num2 == num)
				{
				}
				num = (short)1737555969;
				if (num != 0)
				{
				}
				num = (short)1924530176;
				short num3 = num;
				num = (short)877658112;
				if (num != 0)
				{
				}
				this.trkWideAdvancedHoldoffDelaysec_A8201.Applicable = value;
			}
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x060004B1 RID: 1201 RVA: 0x00053790 File Offset: 0x00051990
		// (set) Token: 0x060004B2 RID: 1202 RVA: 0x00053844 File Offset: 0x00051A44
		public bool TrkWideAdvancedHoldoffDelaysec_A8201_Valid
		{
			get
			{
				short num = (short)479133697;
				if (num != 0)
				{
				}
				num = (short)801748878;
				short num2 = num;
				num = (short)1724430222;
				switch (num2 == num)
				{
				}
				num = (short)434044928;
				short num3 = num;
				num = (short)2071658496;
				if (num != 0)
				{
				}
				return this.trkWideAdvancedHoldoffDelaysec_A8201.Valid;
			}
			set
			{
				short num = (short)2047683094;
				short num2 = num;
				num = (short)1684154902;
				switch (num2 == num)
				{
				}
				num = (short)1357250560;
				if (num != 0)
				{
				}
				num = (short)191758336;
				short num3 = num;
				num = (short)1739522049;
				if (num != 0)
				{
				}
				this.trkWideAdvancedHoldoffDelaysec_A8201.Valid = value;
			}
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x060004B3 RID: 1203 RVA: 0x000538F8 File Offset: 0x00051AF8
		// (set) Token: 0x060004B4 RID: 1204 RVA: 0x000539B0 File Offset: 0x00051BB0
		public bool TrkWideAdvancedHoldoffDelaysec_A8201_Visible
		{
			get
			{
				short num = (short)1279602995;
				short num2 = num;
				num = (short)186134835;
				switch (num2 == num)
				{
				}
				num = (short)106430465;
				if (num != 0)
				{
				}
				num = (short)1661992960;
				short num3 = num;
				num = (short)405929984;
				if (num != 0)
				{
				}
				return this.trkWideAdvancedHoldoffDelaysec_A8201.Visible;
			}
			set
			{
				short num = (short)1335498276;
				short num2 = num;
				num = (short)1480726052;
				switch (num2 == num)
				{
				}
				num = (short)1139998721;
				if (num != 0)
				{
				}
				num = (short)1771962368;
				short num3 = num;
				num = (short)119078912;
				if (num != 0)
				{
				}
				this.trkWideAdvancedHoldoffDelaysec_A8201.Visible = value;
			}
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x060004B5 RID: 1205 RVA: 0x00053A64 File Offset: 0x00051C64
		// (set) Token: 0x060004B6 RID: 1206 RVA: 0x00053B18 File Offset: 0x00051D18
		public bool TrkWideAdvancedHoldoffDelaysec_A8201_Editable
		{
			get
			{
				short num = (short)646316033;
				if (num != 0)
				{
				}
				num = (short)473238981;
				short num2 = num;
				num = (short)354291141;
				switch (num2 == num)
				{
				}
				num = (short)633733120;
				short num3 = num;
				num = (short)1256325120;
				if (num != 0)
				{
				}
				return this.trkWideAdvancedHoldoffDelaysec_A8201.Editable;
			}
			set
			{
				short num = (short)1424890200;
				short num2 = num;
				num = (short)1994070360;
				switch (num2 == num)
				{
				}
				num = (short)239534080;
				if (num != 0)
				{
				}
				num = (short)1044578304;
				short num3 = num;
				num = (short)1658454017;
				if (num != 0)
				{
				}
				this.trkWideAdvancedHoldoffDelaysec_A8201.Editable = value;
			}
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x060004B7 RID: 1207 RVA: 0x00053BCC File Offset: 0x00051DCC
		internal string TrkWideAdvancedHoldoffDelaysec_A8201_UILabel
		{
			get
			{
				short num = (short)68084047;
				short num2 = num;
				num = (short)1782243663;
				switch (num2 == num)
				{
				}
				num = (short)677773312;
				if (num != 0)
				{
				}
				num = (short)1929510912;
				short num3 = num;
				num = (short)1751187457;
				if (num != 0)
				{
				}
				return this.trkWideAdvancedHoldoffDelaysec_A8201.UIName;
			}
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x060004B8 RID: 1208 RVA: 0x00053C80 File Offset: 0x00051E80
		// (set) Token: 0x060004B9 RID: 1209 RVA: 0x00053D38 File Offset: 0x00051F38
		internal bool TrkWideAdvancedHoldoffDelaysec_A8201_HiddenStatic
		{
			get
			{
				short num = (short)502873158;
				short num2 = num;
				num = (short)853883974;
				switch (num2 == num)
				{
				}
				num = (short)1258946561;
				if (num != 0)
				{
				}
				num = (short)888209408;
				short num3 = num;
				num = (short)6488064;
				if (num != 0)
				{
				}
				return this.trkWideAdvancedHoldoffDelaysec_A8201.HiddenStatic;
			}
			set
			{
				short num = (short)2079372192;
				short num2 = num;
				num = (short)865776544;
				switch (num2 == num)
				{
				}
				num = (short)1947533312;
				if (num != 0)
				{
				}
				num = (short)1102249984;
				short num3 = num;
				num = (short)78774273;
				if (num != 0)
				{
				}
				this.trkWideAdvancedHoldoffDelaysec_A8201.HiddenStatic = value;
			}
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x060004BA RID: 1210 RVA: 0x00053DF0 File Offset: 0x00051FF0
		// (set) Token: 0x060004BB RID: 1211 RVA: 0x00053EA4 File Offset: 0x000520A4
		internal bool TrkWideAdvancedHoldoffDelaysec_A8201_HiddenDynamic
		{
			get
			{
				short num = (short)1281961179;
				short num2 = num;
				num = (short)993406171;
				switch (num2 == num)
				{
				}
				num = (short)745734145;
				if (num != 0)
				{
				}
				num = (short)2108358656;
				short num3 = num;
				num = (short)1387593728;
				if (num != 0)
				{
				}
				return this.trkWideAdvancedHoldoffDelaysec_A8201.HiddenDynamic;
			}
			set
			{
				short num = (short)969629578;
				short num2 = num;
				num = (short)480403338;
				switch (num2 == num)
				{
				}
				num = (short)837615616;
				if (num != 0)
				{
				}
				num = (short)1504182272;
				short num3 = num;
				num = (short)539754497;
				if (num != 0)
				{
				}
				this.trkWideAdvancedHoldoffDelaysec_A8201.HiddenDynamic = value;
			}
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x060004BC RID: 1212 RVA: 0x00053F58 File Offset: 0x00052158
		public bool TrkWideAdvancedHoldoffDelaysec_A8201_HasDiffs
		{
			get
			{
				short num = (short)1342464959;
				short num2 = num;
				num = (short)707027903;
				switch (num2 == num)
				{
				}
				num = (short)906428416;
				if (num != 0)
				{
				}
				num = (short)185466880;
				short num3 = num;
				num = (short)2050162689;
				if (num != 0)
				{
				}
				return this.trkWideAdvancedHoldoffDelaysec_A8201._HasDiffs;
			}
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x060004BD RID: 1213 RVA: 0x0005400C File Offset: 0x0005220C
		// (set) Token: 0x060004BE RID: 1214 RVA: 0x000540BC File Offset: 0x000522BC
		public int TrkWideAdvancedVirtualPartnerCallActivityTime_A43675Value
		{
			get
			{
				short num = (short)605805762;
				short num2 = num;
				num = (short)1708317890;
				switch (num2 == num)
				{
				}
				num = (short)1525153793;
				if (num != 0)
				{
				}
				num = (short)1281884160;
				short num3 = num;
				num = (short)188416000;
				if (num != 0)
				{
				}
				return this.trkWideAdvancedVirtualPartnerCallActivityTime_A43675.Value;
			}
			set
			{
				short num = (short)568846580;
				short num2 = num;
				num = (short)1569908980;
				switch (num2 == num)
				{
				}
				num = (short)520028161;
				if (num != 0)
				{
				}
				num = (short)1957363712;
				short num3 = num;
				num = (short)1124663296;
				if (num != 0)
				{
				}
				this.trkWideAdvancedVirtualPartnerCallActivityTime_A43675.Value = value;
			}
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x060004BF RID: 1215 RVA: 0x00054170 File Offset: 0x00052370
		public global::AcpBusinessLayer.AcpSimpleRangeField TrkWideAdvancedVirtualPartnerCallActivityTime_A43675
		{
			get
			{
				short num = (short)577166400;
				short num2 = num;
				num = (short)1301208128;
				switch (num2 == num)
				{
				}
				num = (short)137953281;
				if (num != 0)
				{
				}
				num = (short)1938161664;
				short num3 = num;
				num = (short)1697644544;
				if (num != 0)
				{
				}
				return this.trkWideAdvancedVirtualPartnerCallActivityTime_A43675;
			}
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x060004C0 RID: 1216 RVA: 0x00054220 File Offset: 0x00052420
		// (set) Token: 0x060004C1 RID: 1217 RVA: 0x000542D4 File Offset: 0x000524D4
		public string TrkWideAdvancedVirtualPartnerCallActivityTime_A43675_UIValue
		{
			get
			{
				short num = (short)456117595;
				short num2 = num;
				num = (short)503369051;
				switch (num2 == num)
				{
				}
				num = (short)1094123521;
				if (num != 0)
				{
				}
				num = (short)59768832;
				short num3 = num;
				num = (short)1361379328;
				if (num != 0)
				{
				}
				return this.trkWideAdvancedVirtualPartnerCallActivityTime_A43675.UIValue;
			}
			set
			{
				short num = (short)1204003755;
				short num2 = num;
				num = (short)1660986283;
				switch (num2 == num)
				{
				}
				num = (short)1562247169;
				if (num != 0)
				{
				}
				num = (short)1706033152;
				short num3 = num;
				num = (short)1262616576;
				if (num != 0)
				{
				}
				this.trkWideAdvancedVirtualPartnerCallActivityTime_A43675.UIValue = value;
			}
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x060004C2 RID: 1218 RVA: 0x00054388 File Offset: 0x00052588
		// (set) Token: 0x060004C3 RID: 1219 RVA: 0x0005443C File Offset: 0x0005263C
		internal int TrkWideAdvancedVirtualPartnerCallActivityTime_A43675Min
		{
			get
			{
				short num = (short)1873319260;
				short num2 = num;
				num = (short)383554908;
				switch (num2 == num)
				{
				}
				num = (short)558366720;
				if (num != 0)
				{
				}
				num = (short)752746496;
				short num3 = num;
				num = (short)1385824257;
				if (num != 0)
				{
				}
				return this.trkWideAdvancedVirtualPartnerCallActivityTime_A43675.Min;
			}
			set
			{
				short num = (short)899476856;
				short num2 = num;
				num = (short)1615129976;
				switch (num2 == num)
				{
				}
				num = (short)169738241;
				if (num != 0)
				{
				}
				num = (short)500039680;
				short num3 = num;
				num = (short)301793280;
				if (num != 0)
				{
				}
				this.trkWideAdvancedVirtualPartnerCallActivityTime_A43675.Min = value;
			}
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x060004C4 RID: 1220 RVA: 0x000544F4 File Offset: 0x000526F4
		// (set) Token: 0x060004C5 RID: 1221 RVA: 0x000545AC File Offset: 0x000527AC
		internal int TrkWideAdvancedVirtualPartnerCallActivityTime_A43675Max
		{
			get
			{
				short num = (short)1684537345;
				if (num != 0)
				{
				}
				num = (short)547890548;
				short num2 = num;
				num = (short)1618945396;
				switch (num2 == num)
				{
				}
				num = (short)1853030400;
				short num3 = num;
				num = (short)119275520;
				if (num != 0)
				{
				}
				return this.trkWideAdvancedVirtualPartnerCallActivityTime_A43675.Max;
			}
			set
			{
				short num = (short)1995409416;
				short num2 = num;
				num = (short)100239368;
				switch (num2 == num)
				{
				}
				num = (short)1347878913;
				if (num != 0)
				{
				}
				num = (short)2086141952;
				short num3 = num;
				num = (short)2070347776;
				if (num != 0)
				{
				}
				this.trkWideAdvancedVirtualPartnerCallActivityTime_A43675.Max = value;
			}
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x060004C6 RID: 1222 RVA: 0x00054660 File Offset: 0x00052860
		// (set) Token: 0x060004C7 RID: 1223 RVA: 0x00054714 File Offset: 0x00052914
		internal int TrkWideAdvancedVirtualPartnerCallActivityTime_A43675Step
		{
			get
			{
				short num = (short)1316863367;
				short num2 = num;
				num = (short)1005370759;
				switch (num2 == num)
				{
				}
				num = (short)458883073;
				if (num != 0)
				{
				}
				num = (short)1224409088;
				short num3 = num;
				num = (short)1903427584;
				if (num != 0)
				{
				}
				return this.trkWideAdvancedVirtualPartnerCallActivityTime_A43675.StepSize;
			}
			set
			{
				short num = (short)55083611;
				short num2 = num;
				num = (short)527139419;
				switch (num2 == num)
				{
				}
				num = (short)224526337;
				if (num != 0)
				{
				}
				num = (short)351666176;
				short num3 = num;
				num = (short)923729920;
				if (num != 0)
				{
				}
				this.trkWideAdvancedVirtualPartnerCallActivityTime_A43675.StepSize = value;
			}
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x060004C8 RID: 1224 RVA: 0x000547C4 File Offset: 0x000529C4
		// (set) Token: 0x060004C9 RID: 1225 RVA: 0x0005487C File Offset: 0x00052A7C
		public bool TrkWideAdvancedVirtualPartnerCallActivityTime_A43675_Applicable
		{
			get
			{
				short num = (short)1061917635;
				short num2 = num;
				num = (short)562729923;
				switch (num2 == num)
				{
				}
				num = (short)783482880;
				if (num != 0)
				{
				}
				num = (short)391708672;
				short num3 = num;
				num = (short)2013724673;
				if (num != 0)
				{
				}
				return this.trkWideAdvancedVirtualPartnerCallActivityTime_A43675.Applicable;
			}
			set
			{
				short num = (short)1879484959;
				short num2 = num;
				num = (short)550480415;
				switch (num2 == num)
				{
				}
				num = (short)145620992;
				if (num != 0)
				{
				}
				num = (short)1595801600;
				short num3 = num;
				num = (short)64225281;
				if (num != 0)
				{
				}
				this.trkWideAdvancedVirtualPartnerCallActivityTime_A43675.Applicable = value;
			}
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x060004CA RID: 1226 RVA: 0x00054930 File Offset: 0x00052B30
		// (set) Token: 0x060004CB RID: 1227 RVA: 0x000549E4 File Offset: 0x00052BE4
		public bool TrkWideAdvancedVirtualPartnerCallActivityTime_A43675_Valid
		{
			get
			{
				short num = (short)22387145;
				short num2 = num;
				num = (short)1343789513;
				switch (num2 == num)
				{
				}
				num = (short)890241025;
				if (num != 0)
				{
				}
				num = (short)1702494208;
				short num3 = num;
				num = (short)339869696;
				if (num != 0)
				{
				}
				return this.trkWideAdvancedVirtualPartnerCallActivityTime_A43675.Valid;
			}
			set
			{
				short num = (short)1492189185;
				if (num != 0)
				{
				}
				num = (short)1736059905;
				short num2 = num;
				num = (short)1864838145;
				switch (num2 == num)
				{
				}
				num = (short)1718353920;
				short num3 = num;
				num = (short)767688704;
				if (num != 0)
				{
				}
				this.trkWideAdvancedVirtualPartnerCallActivityTime_A43675.Valid = value;
			}
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x060004CC RID: 1228 RVA: 0x00054A9C File Offset: 0x00052C9C
		// (set) Token: 0x060004CD RID: 1229 RVA: 0x00054B50 File Offset: 0x00052D50
		public bool TrkWideAdvancedVirtualPartnerCallActivityTime_A43675_Visible
		{
			get
			{
				short num = (short)1990405814;
				short num2 = num;
				num = (short)2698934;
				switch (num2 == num)
				{
				}
				num = (short)395444224;
				if (num != 0)
				{
				}
				num = (short)365035520;
				short num3 = num;
				num = (short)1123483649;
				if (num != 0)
				{
				}
				return this.trkWideAdvancedVirtualPartnerCallActivityTime_A43675.Visible;
			}
			set
			{
				short num = (short)332125572;
				short num2 = num;
				num = (short)388552068;
				switch (num2 == num)
				{
				}
				num = (short)342294529;
				if (num != 0)
				{
				}
				num = (short)2133000192;
				short num3 = num;
				num = (short)487981056;
				if (num != 0)
				{
				}
				this.trkWideAdvancedVirtualPartnerCallActivityTime_A43675.Visible = value;
			}
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x060004CE RID: 1230 RVA: 0x00054C08 File Offset: 0x00052E08
		// (set) Token: 0x060004CF RID: 1231 RVA: 0x00054CC0 File Offset: 0x00052EC0
		public bool TrkWideAdvancedVirtualPartnerCallActivityTime_A43675_Editable
		{
			get
			{
				short num = (short)1779462061;
				short num2 = num;
				num = (short)1644392365;
				switch (num2 == num)
				{
				}
				num = (short)1629290496;
				if (num != 0)
				{
				}
				num = (short)224067584;
				short num3 = num;
				num = (short)1345060865;
				if (num != 0)
				{
				}
				return this.trkWideAdvancedVirtualPartnerCallActivityTime_A43675.Editable;
			}
			set
			{
				short num = (short)1012385522;
				short num2 = num;
				num = (short)2019870450;
				switch (num2 == num)
				{
				}
				num = (short)1779695617;
				if (num != 0)
				{
				}
				num = (short)1900740608;
				short num3 = num;
				num = (short)1131282432;
				if (num != 0)
				{
				}
				this.trkWideAdvancedVirtualPartnerCallActivityTime_A43675.Editable = value;
			}
		}

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x060004D0 RID: 1232 RVA: 0x00054D74 File Offset: 0x00052F74
		internal string TrkWideAdvancedVirtualPartnerCallActivityTime_A43675_UILabel
		{
			get
			{
				short num = (short)1225956535;
				short num2 = num;
				num = (short)300981431;
				switch (num2 == num)
				{
				}
				num = (short)556597249;
				if (num != 0)
				{
				}
				num = (short)654376960;
				short num3 = num;
				num = (short)1622802432;
				if (num != 0)
				{
				}
				return this.trkWideAdvancedVirtualPartnerCallActivityTime_A43675.UIName;
			}
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x060004D1 RID: 1233 RVA: 0x00054E28 File Offset: 0x00053028
		// (set) Token: 0x060004D2 RID: 1234 RVA: 0x00054EE0 File Offset: 0x000530E0
		internal bool TrkWideAdvancedVirtualPartnerCallActivityTime_A43675_HiddenStatic
		{
			get
			{
				short num = (short)184509427;
				short num2 = num;
				num = (short)1652450291;
				switch (num2 == num)
				{
				}
				num = (short)308805633;
				if (num != 0)
				{
				}
				num = (short)198115328;
				short num3 = num;
				num = (short)1525481472;
				if (num != 0)
				{
				}
				return this.trkWideAdvancedVirtualPartnerCallActivityTime_A43675.HiddenStatic;
			}
			set
			{
				short num = (short)1226506241;
				if (num != 0)
				{
				}
				num = (short)1415426066;
				short num2 = num;
				num = (short)1852485650;
				switch (num2 == num)
				{
				}
				num = (short)1642790912;
				short num3 = num;
				num = (short)647692288;
				if (num != 0)
				{
				}
				this.trkWideAdvancedVirtualPartnerCallActivityTime_A43675.HiddenStatic = value;
			}
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x060004D3 RID: 1235 RVA: 0x00054F98 File Offset: 0x00053198
		// (set) Token: 0x060004D4 RID: 1236 RVA: 0x00055050 File Offset: 0x00053250
		internal bool TrkWideAdvancedVirtualPartnerCallActivityTime_A43675_HiddenDynamic
		{
			get
			{
				short num = (short)541913902;
				short num2 = num;
				num = (short)1497101102;
				switch (num2 == num)
				{
				}
				num = (short)1320681472;
				if (num != 0)
				{
				}
				num = (short)1194328064;
				short num3 = num;
				num = (short)1705836545;
				if (num != 0)
				{
				}
				return this.trkWideAdvancedVirtualPartnerCallActivityTime_A43675.HiddenDynamic;
			}
			set
			{
				short num = (short)377946113;
				if (num != 0)
				{
				}
				num = (short)2122458830;
				short num2 = num;
				num = (short)1562650318;
				switch (num2 == num)
				{
				}
				num = (short)1342767104;
				short num3 = num;
				num = (short)250216448;
				if (num != 0)
				{
				}
				this.trkWideAdvancedVirtualPartnerCallActivityTime_A43675.HiddenDynamic = value;
			}
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x060004D5 RID: 1237 RVA: 0x00055104 File Offset: 0x00053304
		public bool TrkWideAdvancedVirtualPartnerCallActivityTime_A43675_HasDiffs
		{
			get
			{
				short num = (short)2102077097;
				short num2 = num;
				num = (short)892217001;
				switch (num2 == num)
				{
				}
				num = (short)203358209;
				if (num != 0)
				{
				}
				num = (short)1085276160;
				short num3 = num;
				num = (short)1867317248;
				if (num != 0)
				{
				}
				return this.trkWideAdvancedVirtualPartnerCallActivityTime_A43675._HasDiffs;
			}
		}

		// Token: 0x060004D6 RID: 1238 RVA: 0x000551BC File Offset: 0x000533BC
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
					num2 = (short)1191398776;
					short num3 = num2;
					num2 = (short)540822904;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_95;
					default:
						num2 = (short)1480589312;
						if (num2 != 0)
						{
						}
						if (base.ParentRecset.ContainerDoc != null)
						{
							num2 = (short)2101018627;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					}
					break;
				}
				case 1:
					return result;
				case 2:
					if (base.ParentRecset != null)
					{
						num2 = (short)1691156481;
						if (num2 != 0)
						{
						}
						num2 = (short)1500381188;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 3:
				{
					num2 = (short)1519583232;
					short num4 = num2;
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					goto IL_95;
				}
				case 4:
					num2 = (short)1501167616;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_24;
				IL_95:
				num2 = (short)1742405633;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)1109983234;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x040001E6 RID: 486
		private global::AcpBusinessLayer.AcpListField trkWideAdvancedAffiliationHoldOffsec_A7412;

		// Token: 0x040001E7 RID: 487
		private global::AcpBusinessLayer.AcpSimpleRangeField trkWideAdvancedFailsoftInactivitysec_A8010;

		// Token: 0x040001E8 RID: 488
		private global::AcpBusinessLayer.AcpField<bool> trkWideAdvancedFullSpectrumControlChannelScan_A8161;

		// Token: 0x040001E9 RID: 489
		private global::AcpBusinessLayer.AcpSimpleRangeField trkWideAdvancedInternalRadioHoldoffmin_A8309;

		// Token: 0x040001EA RID: 490
		private global::AcpBusinessLayer.AcpSimpleRangeField trkWideAdvancedISWWindowAdjustment_A8358;

		// Token: 0x040001EB RID: 491
		private global::AcpBusinessLayer.AcpSimpleRangeField trkWideAdvancedFullSpectrumControlChannelScanTimersec_A8162;

		// Token: 0x040001EC RID: 492
		private global::AcpBusinessLayer.AcpSimpleRangeField trkWideAdvancedHoldoffDelaysec_A8201;

		// Token: 0x040001ED RID: 493
		private global::AcpBusinessLayer.AcpSimpleRangeField trkWideAdvancedVirtualPartnerCallActivityTime_A43675;
	}
}
