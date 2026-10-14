using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using ConstraintHelper;

namespace Motorola.MackinawCPS.CoreFeatures.RadioWide
{
	// Token: 0x02000173 RID: 371
	[global::System.Serializable]
	public class General : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06003402 RID: 13314 RVA: 0x00320494 File Offset: 0x0031E694
		public General(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06003403 RID: 13315 RVA: 0x003204B0 File Offset: 0x0031E6B0
		protected General(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06003404 RID: 13316 RVA: 0x003204C8 File Offset: 0x0031E6C8
		public override void Init()
		{
			int a_ = 15;
			short num = (short)1913913344;
			short num2 = num;
			num = (short)1060985981;
			short num3 = num;
			num = (short)683236477;
			switch (num3 == num)
			{
			}
			num = (short)351076353;
			if (num != 0)
			{
			}
			num = (short)2072444928;
			if (num != 0)
			{
			}
			this.radWideGeneralDateFormat_A7802 = new global::AcpBusinessLayer.AcpSparseLOVField(1, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.indexRadWideGeneralDateFormat_A7802LovStrs, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.idRadWideGeneralDateFormat_A7802LovStrs), this, global::AllFeatures.CodeplugGuid.b("苏돑냓臕뇗뻙맛駝藟賡臣铥觧蛩꣫迭蓯韱닳駵諷韹鷻諽忿䌁㌃㸅㠇㠉", a_), global::CommonResources.AcgResources.ID_DATEFORMAT, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideGeneralDateFormat_A7802LovStrs);
			this.radWideGeneralDateFormat_A7802.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radWideGeneralDateFormat_A7802.DataTransferOrder = 21;
			this.radWideAdvancedMaximumTxDeviation_A8480 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.indexRadWideAdvancedMaximumTxDeviation_A8480LovStrs, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.idRadWideAdvancedMaximumTxDeviation_A8480LovStrs), this, global::AllFeatures.CodeplugGuid.b("苏돑냓臕뇗뻙맛鿝蓟铡藣裥诧迩裫ꏭ釯諱鷳鯵跷韹ꣻ蛽䓿朁爃漅椇縉攋愍縏䴑唓⸕Ⱇ∙Ⱋ", a_), global::CommonResources.AcgResources.ID_MAXIMUMTXDEVIATION, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideAdvancedMaximumTxDeviation_A8480LovStrs);
			this.radWideAdvancedMaximumTxDeviation_A8480.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radWideAdvancedMaximumTxDeviation_A8480.DataTransferOrder = 28;
			this.radInfoGeneralMotorcycleRadio_A8546 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("苏돑냓鿕뛗볙돛駝藟賡臣铥觧蛩ꇫ臭蓯鷱蛳闵臷駹郻鯽勿持怃漅朇唉䴋㘍┏☑∓", a_), global::CommonResources.AcgResources.ID_MOTORCYCLERADIO);
			this.radInfoGeneralMotorcycleRadio_A8546.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radInfoGeneralMotorcycleRadio_A8546.DataTransferOrder = -1;
			this.radWideGeneralTimeFormat_A9377 = new global::AcpBusinessLayer.AcpListField(1, this, global::AllFeatures.CodeplugGuid.b("苏돑냓臕뇗뻙맛駝藟賡臣铥觧蛩룫蟭鷯韱닳駵諷韹鷻諽忿䌁㴃㔅㼇㴉", a_), global::CommonResources.AcgResources.ID_TIMEFORMAT, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideGeneralTimeFormat_A9377LovStrs);
			this.radWideGeneralTimeFormat_A9377.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radWideGeneralTimeFormat_A9377.DataTransferOrder = 40;
			this.radWideAdvancedUltraNarrowIntermediateFreqFilter_A9592 = new global::AcpBusinessLayer.AcpListField(1, this, global::AllFeatures.CodeplugGuid.b("苏돑냓臕뇗뻙맛鿝蓟铡藣裥诧迩裫믭鳯蛱蛳韵뛷鯹軻賽濿甁䴃栅簇漉縋挍甏瘑紓眕気缙娛氝䔟匡戣伥䐧帩䤫尭漯猱ള̵ķ࠹", a_), global::CommonResources.AcgResources.ID_ULTRANARROWINTERMEDIATEFREQFILTER, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideAdvancedUltraNarrowIntermediateFreqFilter_A9592LovStrs);
			this.radWideAdvancedUltraNarrowIntermediateFreqFilter_A9592.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.radWideAdvancedUltraNarrowIntermediateFreqFilter_A9592.DataTransferOrder = 42;
			this.radWideGeneralLogDisp_A9756 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("苏돑냓臕뇗뻙맛駝藟賡臣铥觧蛩ꃫ臭韯뛱鷳藵裷ꗹ뷻쟽㟿㜁㈃", a_), global::CommonResources.AcgResources.ID_LOGDISPATCHCALLSENABLE);
			this.radWideGeneralLogDisp_A9756.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radWideGeneralLogDisp_A9756.DataTransferOrder = 14;
			this.radWideGeneralASKRequired_A37152 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("苏돑냓臕뇗뻙맛駝藟賡臣铥觧蛩귫뷭믯ꃱ釳蟵跷鏹軻鯽擿崁䔃㔅㼇㬉㤋㰍", a_), global::CommonResources.AcgResources.ID_ASKREQUIRED);
			this.radWideGeneralASKRequired_A37152.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radWideGeneralASKRequired_A37152.DataTransferOrder = 147;
			this.radWideGeneralOwnerSystemID_A37153 = new global::AcpBusinessLayer.AcpSimpleRangeField(0, this, global::AllFeatures.CodeplugGuid.b("苏돑냓臕뇗뻙맛駝藟賡臣铥觧蛩ꏫ駭黯韱蛳ꗵ臷觹裻鯽淿䬁䀃夅䤇㤉㬋㼍┏ℑ", a_), global::CommonResources.AcgResources.ID_OWNERSYSTEMID, 0, 65535, null, null, 0, 1);
			this.radWideGeneralOwnerSystemID_A37153.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radWideGeneralOwnerSystemID_A37153.DataTransferOrder = 157;
			this.radWideGeneralOwnerSystemID_A37153.ShowHexValue = true;
			this.radWideGeneralOwnerWACNID_A38656 = new global::AcpBusinessLayer.AcpSimpleRangeField(0, this, global::AllFeatures.CodeplugGuid.b("苏돑냓臕뇗뻙맛駝藟賡臣铥觧蛩ꏫ駭黯韱蛳ꇵ맷맹닻럽䓿崁䔃㔅〇㰉㤋㠍", a_), global::CommonResources.AcgResources.ID_OWNERWACNID, 0, 1048574, null, null, 0, 1);
			this.radWideGeneralOwnerWACNID_A38656.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radWideGeneralOwnerWACNID_A38656.DataTransferOrder = 158;
			this.radWideGeneralOwnerWACNID_A38656.ShowHexValue = true;
			this.radWideGeneralOwnerAdvancedKeyType_A38663 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("苏돑냓臕뇗뻙맛駝藟賡臣铥觧蛩ꏫ駭黯韱蛳럵鳷賹鷻都揿朁怃䴅洇猉堋眍怏眑䬓圕⬗∙⨛⠝ጟ", a_), global::CommonResources.AcgResources.ID_OWNERADVANCEDKEYTYPE, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideGeneralOwnerAdvancedKeyType_A38663LovStrs);
			this.radWideGeneralOwnerAdvancedKeyType_A38663.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radWideGeneralOwnerAdvancedKeyType_A38663.DataTransferOrder = 148;
			this.radWideGeneralPskId_44840 = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::AllFeatures.CodeplugGuid.b("苏돑냓臕뇗뻙맛駝藟賡臣铥觧蛩볫鷭鯯믱郳꧵쳷컹쓻쫽ヿ", a_), global::CommonResources.AcgResources.ID_ONPREM_CDA_PSKID_FLD, 16);
			this.radWideGeneralPskId_44840.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radWideGeneralPskId_44840.DataTransferOrder = 159;
			this.radWideGeneralTlsPsk_44841 = new global::AcpBusinessLayer.AcpStringField(global::AllFeatures.CodeplugGuid.b("탟틡퓣훥\ud8e7\udae9\udceb\udeed샯싱쓳웵죷쫹쳻컽ヿ㈁㐃㘅㠇㨉㰋㸍", a_), this, global::AllFeatures.CodeplugGuid.b("苏돑냓臕뇗뻙맛駝藟賡臣铥觧蛩룫苭華ꋱ蟳鷵ꟷ컹죻웽㓿㌁", a_), global::CommonResources.AcgResources.ID_ONPREM_CDA_PSKDATA_FLD, 32);
			this.radWideGeneralTlsPsk_44841.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radWideGeneralTlsPsk_44841.DataTransferOrder = 160;
			this.radWideGeneralTlsPskPort_44842 = new global::AcpBusinessLayer.AcpSimpleRangeField(8053, this, global::AllFeatures.CodeplugGuid.b("苏돑냓臕뇗뻙맛駝藟賡臣铥觧蛩룫苭華ꋱ蟳鷵ꣷ闹軻諽忿㘁〃㸅㰇㠉", a_), global::CommonResources.AcgResources.ID_ONPREM_CDA_TLSPSK_PORT_FLD, 0, 65535, null, null, 0, 1);
			this.radWideGeneralTlsPskPort_44842.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radWideGeneralTlsPskPort_44842.DataTransferOrder = 161;
			this.radWideGeneralDnsSdAddress_44843 = new global::AcpBusinessLayer.AcpStringField(global::AllFeatures.CodeplugGuid.b("틟ퟡ헣", a_), this, global::AllFeatures.CodeplugGuid.b("苏돑냓臕뇗뻙맛駝藟賡臣铥觧蛩꣫胭華ꇱ郳럵鳷黹軻鯽珿焁嬃㈅㰇㈉㠋㴍", a_), global::CommonResources.AcgResources.ID_ONPREM_CDA_DNSSD_ADDRESS_FLD, 255);
			this.radWideGeneralDnsSdAddress_44843.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radWideGeneralDnsSdAddress_44843.DataTransferOrder = 162;
			this.radWideGeneralDnsSdPort_44844 = new global::AcpBusinessLayer.AcpSimpleRangeField(5353, this, global::AllFeatures.CodeplugGuid.b("苏돑냓臕뇗뻙맛駝藟賡臣铥觧蛩꣫胭華ꇱ郳꛵韷裹裻ꇽ㓿㘁㰃㈅㰇", a_), global::CommonResources.AcgResources.ID_ONPREM_CDA_DNSSDPORT_FLD, 0, 65535, null, null, 0, 1);
			this.radWideGeneralDnsSdPort_44844.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radWideGeneralDnsSdPort_44844.DataTransferOrder = 163;
			this.radWideGeneralProgrammingPath_44845 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("苏돑냓臕뇗뻙맛駝藟賡臣铥觧蛩볫鳭鿯闱蛳韵闷韹闻都柿刁攃爅怇唉㠋㨍⠏☑ℓ", a_), global::CommonResources.AcgResources.ID_ONPREM_CDA_OnPremOnlyFlag_FLD, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideGeneralProgrammingPathLovStrs);
			this.radWideGeneralProgrammingPath_44845.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.radWideGeneralProgrammingPath_44845.DataTransferOrder = -1;
			this.radErgoWideAdvancedModeSelTxName = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("苏돑냓鏕꫗뷙돛觝觟蛡臣꟥賧鳩跫胭鏯韱郳믵韷黹駻귽旿渁倃縅䘇欉愋欍", a_), global::CommonResources.AcgResources.ID_MODESELTXNAME, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadErgoWideAdvancedModeSelTxNameLovStrs);
			this.radErgoWideAdvancedModeSelTxName.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.radErgoWideAdvancedModeSelTxName.DataTransferOrder = 164;
			this.radWideRecentCallListDeleteEnable = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("苏돑냓臕뇗뻙맛賝藟臡臣裥鳧ꧩ跫苭鳯뻱鷳藵賷뻹駻鋽旿瘁愃䌅昇欉渋戍甏", a_), global::CommonResources.AcgResources.ID_RECENTCALLDELENABLE);
			this.radWideRecentCallListDeleteEnable.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radWideRecentCallListDeleteEnable.DataTransferOrder = 166;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("韏럑뫓돕꫗믙냛", a_);
			base.Id = 10099;
			base.UIName = global::CommonResources.AcgResources.ID_GENERAL;
			base.DataTransferOrder = 6;
		}

		// Token: 0x06003405 RID: 13317 RVA: 0x00320A7C File Offset: 0x0031EC7C
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 8;
			short num = (short)1611857967;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					this.radWideGeneralDateFormat_A7802 = new global::AcpBusinessLayer.AcpSparseLOVField(1, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.indexRadWideGeneralDateFormat_A7802LovStrs, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.idRadWideGeneralDateFormat_A7802LovStrs), this, global::AllFeatures.CodeplugGuid.b("鯈꫊꧌风룐럒냔郖볘뗚룜귞胠迢ꇤ蛦鷨軪꯬胮菰黲铴菶꛸뫺쫼쟾㄀㄂", a_), global::CommonResources.AcgResources.ID_DATEFORMAT, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideGeneralDateFormat_A7802LovStrs);
					this.radWideGeneralDateFormat_A7802.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radWideGeneralDateFormat_A7802.DataTransferOrder = 21;
					num = (short)1338245137;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					this.radWideGeneralOwnerWACNID_A38656 = new global::AcpBusinessLayer.AcpSimpleRangeField(0, this, global::AllFeatures.CodeplugGuid.b("鯈꫊꧌风룐럒냔郖볘뗚룜귞胠迢ꫤ郦蟨軪鿬룮냰냲믴뻶뷸ꓺ볼쳾㤀㔂〄ㄆ", a_), global::CommonResources.AcgResources.ID_OWNERWACNID, null, null, 0, 1);
					this.radWideGeneralOwnerWACNID_A38656.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radWideGeneralOwnerWACNID_A38656.DataTransferOrder = 158;
					this.radWideGeneralOwnerWACNID_A38656.ShowHexValue = true;
					num = (short)45482025;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					this.radWideGeneralDnsSdAddress_44843 = new global::AcpBusinessLayer.AcpStringField(global::AllFeatures.CodeplugGuid.b("﯈流琉﷒淪", a_), this, global::AllFeatures.CodeplugGuid.b("鯈꫊꧌风룐럒냔郖볘뗚룜귞胠迢ꇤ触髨룪觬껮闰韲蟴鋶諸裺ꋼ쯾㔀㬂㄄㐆", a_), global::CommonResources.AcgResources.ID_ONPREM_CDA_DNSSD_ADDRESS_FLD, 255);
					this.radWideGeneralDnsSdAddress_44843.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radWideGeneralDnsSdAddress_44843.DataTransferOrder = 162;
					num = (short)866910263;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鯈꫊꧌风룐럒냔郖볘뗚룜귞胠迢뇤详髨믪黬蓮ꇰ鳲蟴菶꛸쿺짼쟾㔀㄂", a_)))
					{
						num = (short)1124663323;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_DF9;
				case 4:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鯈꫊꧌风룐럒냔雖뷘귚볜뇞苠蛢臤ꫦ裨鏪蓬苮蓰黲ꇴ迶뷸黺诼雾怀眂氄栆月吊䰌㜎┐⬒└", a_)))
					{
						num = (short)351010849;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_60E;
				case 5:
					this.radWideGeneralLogDisp_A9756 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鯈꫊꧌风룐럒냔郖볘뗚룜귞胠迢ꧤ裦軨꿪蓬鳮臰곲듴컶컸컺쯼", a_), global::CommonResources.AcgResources.ID_LOGDISPATCHCALLSENABLE);
					this.radWideGeneralLogDisp_A9756.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radWideGeneralLogDisp_A9756.DataTransferOrder = 14;
					num = (short)832241688;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
				{
					if (!producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鯈꫊꧌风룐럒냔郖볘뗚룜귞胠迢뗤铦苨ꋪ觬냮연쟲췴쏶째", a_)))
					{
						goto IL_84C;
					}
					num = (short)1533357770;
					short num3 = num;
					num = (short)23342794;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_A69;
					default:
						num = (short)291635200;
						if (num != 0)
						{
						}
						num = (short)2029387806;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 7:
					num = (short)743309313;
					if (num != 0)
					{
					}
					this.radWideGeneralTlsPsk_44841 = new global::AcpBusinessLayer.AcpStringField(global::AllFeatures.CodeplugGuid.b("杻﯊﷌ￎ퇠폢헤ퟦ\ud9e8\udbea\uddec\udfee쇰쏲열쟶째쯺췼쿾㄀㌂㔄㜆", a_), this, global::AllFeatures.CodeplugGuid.b("鯈꫊꧌风룐럒냔郖볘뗚룜귞胠迢뇤详髨믪黬蓮껰쟲쇴쿶췸쫺", a_), global::CommonResources.AcgResources.ID_ONPREM_CDA_PSKDATA_FLD, 32);
					this.radWideGeneralTlsPsk_44841.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radWideGeneralTlsPsk_44841.DataTransferOrder = 160;
					num = (short)1470234663;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鯈꫊꧌风룐럒냔郖볘뗚룜귞胠迢ꇤ触髨룪觬껮闰韲蟴鋶諸裺ꋼ쯾㔀㬂㄄㐆", a_)))
					{
						num = (short)1401618434;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_932;
				case 9:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鯈꫊꧌风룐럒냔藖볘룚룜뇞闠ꃢ蓤详藨꟪蓬鳮藰럲郴鯶鳸迺飼뫾漀戂朄欆氈", a_)))
					{
						num = (short)609615928;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_E46;
				case 10:
					this.radWideGeneralOwnerAdvancedKeyType_A38663 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鯈꫊꧌风룐럒냔郖볘뗚룜귞胠迢ꫤ郦蟨軪鿬껮闰藲铴駶髸黺駼듾搀稂億縆礈渊刌与∐⬒⌔№⨘", a_), global::CommonResources.AcgResources.ID_OWNERADVANCEDKEYTYPE, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideGeneralOwnerAdvancedKeyType_A38663LovStrs);
					this.radWideGeneralOwnerAdvancedKeyType_A38663.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radWideGeneralOwnerAdvancedKeyType_A38663.DataTransferOrder = 148;
					num = (short)1855914000;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
				{
					num = (short)924975104;
					short num4 = num;
					this.radWideGeneralProgrammingPath_44845 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鯈꫊꧌风룐럒냔郖볘뗚룜귞胠迢뗤闦蛨質鿬軮鳰黲鳴駶黸꯺鳼课椀専㄄㌆ㄈ㼊㠌", a_), global::CommonResources.AcgResources.ID_ONPREM_CDA_OnPremOnlyFlag_FLD, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideGeneralProgrammingPathLovStrs);
					this.radWideGeneralProgrammingPath_44845.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.radWideGeneralProgrammingPath_44845.DataTransferOrder = -1;
					num = (short)923271194;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 12:
					goto IL_CB3;
				case 13:
					goto IL_60E;
				case 14:
					goto IL_C65;
				case 15:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鯈꫊꧌风룐럒냔郖볘뗚룜귞胠迢ꫤ郦蟨軪鿬룮냰냲믴뻶뷸ꓺ볼쳾㤀㔂〄ㄆ", a_)))
					{
						num = (short)465305601;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3CA;
				case 16:
					goto IL_B18;
				case 17:
					goto IL_A20;
				case 18:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鯈꫊꧌风룐럒냔郖볘뗚룜귞胠迢뇤详髨믪黬蓮껰쟲쇴쿶췸쫺", a_)))
					{
						num = (short)463405063;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_13C;
				case 19:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鯈꫊꧌风룐럒냔郖볘뗚룜귞胠迢ꇤ蛦鷨軪꯬胮菰黲铴菶꛸뫺쫼쟾㄀㄂", a_)))
					{
						num = (short)200278016;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A20;
				case 20:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鯈꫊꧌风룐럒냔郖볘뗚룜귞胠迢ꫤ郦蟨軪鿬볮裰胲致鋶铸닺맼ꃾ䀀。㈄㘆㰈㠊", a_)))
					{
						num = (short)168689695;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_C65;
				case 21:
					goto IL_6B7;
				case 22:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鯈꫊꧌风룐럒냔雖뷘귚볜뇞苠蛢臤닦藨鿪鿬軮뿰鋲蟴藶雸賺듼釾甀昂眄樆氈漊搌渎攐瘒匔攖簘樚嬜瘞䴠圢䀤唦瘨横ᐬᨮ࠰Ĳ", a_)))
					{
						num = (short)1032323110;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_899;
				case 23:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鯈꫊꧌蛎뿐뗒뫔郖볘뗚룜귞胠迢꣤裦鷨蓪鿬賮裰郲駴鋶꯸髺駼雾渀専䐄㼆㰈㼊㬌", a_)))
					{
						num = (short)1379598371;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1E7;
				case 24:
					goto IL_9D3;
				case 25:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鯈꫊꧌风룐럒냔郖볘뗚룜귞胠迢ꓤ듦ꋨ맪裬黮蓰髲蟴鋶鷸ꓺ볼쳾㘀㈂〄㔆", a_)))
					{
						num = (short)1741815837;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_797;
				case 26:
					goto IL_C1A;
				case 27:
					this.radWideGeneralTlsPskPort_44842 = new global::AcpBusinessLayer.AcpSimpleRangeField(8053, this, global::AllFeatures.CodeplugGuid.b("鯈꫊꧌风룐럒냔郖볘뗚룜귞胠迢뇤详髨믪黬蓮ꇰ鳲蟴菶꛸쿺짼쟾㔀㄂", a_), global::CommonResources.AcgResources.ID_ONPREM_CDA_TLSPSK_PORT_FLD, 0, 65535, null, null, 0, 1);
					this.radWideGeneralTlsPskPort_44842.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radWideGeneralTlsPskPort_44842.DataTransferOrder = 161;
					num = (short)420151333;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 28:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鯈꫊꧌风룐럒냔郖볘뗚룜귞胠迢ꫤ郦蟨軪鿬껮闰藲铴駶髸黺駼듾搀稂億縆礈渊刌与∐⬒⌔№⨘", a_)))
					{
						num = (short)1097138186;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_B18;
				case 29:
					this.radWideGeneralASKRequired_A37152 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鯈꫊꧌风룐럒냔郖볘뗚룜귞胠迢ꓤ듦ꋨ맪裬黮蓰髲蟴鋶鷸ꓺ볼쳾㘀㈂〄㔆", a_), global::CommonResources.AcgResources.ID_ASKREQUIRED);
					this.radWideGeneralASKRequired_A37152.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radWideGeneralASKRequired_A37152.DataTransferOrder = 147;
					num = (short)23658549;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 30:
					this.radWideGeneralPskId_44840 = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::AllFeatures.CodeplugGuid.b("鯈꫊꧌风룐럒냔郖볘뗚룜귞胠迢뗤铦苨ꋪ觬냮연쟲췴쏶째", a_), global::CommonResources.AcgResources.ID_ONPREM_CDA_PSKID_FLD, 16);
					this.radWideGeneralPskId_44840.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radWideGeneralPskId_44840.DataTransferOrder = 159;
					num = (short)140836898;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 31:
					this.radWideGeneralOwnerSystemID_A37153 = new global::AcpBusinessLayer.AcpSimpleRangeField(0, this, global::AllFeatures.CodeplugGuid.b("鯈꫊꧌风룐럒냔郖볘뗚룜귞胠迢ꫤ郦蟨軪鿬볮裰胲致鋶铸닺맼ꃾ䀀。㈄㘆㰈㠊", a_), global::CommonResources.AcgResources.ID_OWNERSYSTEMID, null, null, 0, 1);
					this.radWideGeneralOwnerSystemID_A37153.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radWideGeneralOwnerSystemID_A37153.DataTransferOrder = 157;
					this.radWideGeneralOwnerSystemID_A37153.ShowHexValue = true;
					num = (short)1279000590;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 32:
					this.radWideGeneralTimeFormat_A9377 = new global::AcpBusinessLayer.AcpListField(1, this, global::AllFeatures.CodeplugGuid.b("鯈꫊꧌风룐럒냔郖볘뗚룜귞胠迢뇤軦蓨軪꯬胮菰黲铴菶꛸뫺쓼쳾㘀㐂", a_), global::CommonResources.AcgResources.ID_TIMEFORMAT, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideGeneralTimeFormat_A9377LovStrs);
					this.radWideGeneralTimeFormat_A9377.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radWideGeneralTimeFormat_A9377.DataTransferOrder = 40;
					num = (short)714670116;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 33:
					goto IL_A69;
				case 34:
					goto IL_84C;
				case 35:
					this.radInfoGeneralMotorcycleRadio_A8546 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鯈꫊꧌蛎뿐뗒뫔郖볘뗚룜귞胠迢꣤裦鷨蓪鿬賮裰郲駴鋶꯸髺駼雾渀専䐄㼆㰈㼊㬌", a_), global::CommonResources.AcgResources.ID_MOTORCYCLERADIO);
					this.radInfoGeneralMotorcycleRadio_A8546.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radInfoGeneralMotorcycleRadio_A8546.DataTransferOrder = -1;
					num = (short)1847722035;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 36:
					goto IL_8E6;
				case 37:
					goto IL_DF9;
				case 38:
					this.radWideAdvancedUltraNarrowIntermediateFreqFilter_A9592 = new global::AcpBusinessLayer.AcpListField(1, this, global::AllFeatures.CodeplugGuid.b("鯈꫊꧌风룐럒냔雖뷘귚볜뇞苠蛢臤닦藨鿪鿬軮뿰鋲蟴藶雸賺듼釾甀昂眄樆氈漊搌渎攐瘒匔攖簘樚嬜瘞䴠圢䀤唦瘨横ᐬᨮ࠰Ĳ", a_), global::CommonResources.AcgResources.ID_ULTRANARROWINTERMEDIATEFREQFILTER, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideAdvancedUltraNarrowIntermediateFreqFilter_A9592LovStrs);
					this.radWideAdvancedUltraNarrowIntermediateFreqFilter_A9592.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.radWideAdvancedUltraNarrowIntermediateFreqFilter_A9592.DataTransferOrder = 42;
					num = (short)1172504616;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 39:
					goto IL_13C;
				case 40:
					goto IL_899;
				case 41:
					goto IL_3CA;
				case 42:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鯈꫊꧌风룐럒냔郖볘뗚룜귞胠迢뇤軦蓨軪꯬胮菰黲铴菶꛸뫺쓼쳾㘀㐂", a_)))
					{
						num = (short)838139936;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_8E6;
				case 43:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鯈꫊꧌諎ꏐ듒뫔胖냘뿚룜點藠闢蓤触諨軪觬ꋮ黰韲郴ꓶ鳸韺ꧼ蟾伀戂栄戆", a_)))
					{
						num = (short)97386546;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_CB3;
				case 44:
					num = (short)1486356526;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 45:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鯈꫊꧌风룐럒냔郖볘뗚룜귞胠迢뗤闦蛨質鿬軮鳰黲鳴駶黸꯺鳼课椀専㄄㌆ㄈ㼊㠌", a_)))
					{
						num = (short)318177291;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_C1A;
				case 46:
					if (producerFields != null)
					{
						num = (short)630980657;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_E46;
				case 47:
					switch (0)
					{
					case 0:
						goto IL_115;
					}
					continue;
				case 48:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鯈꫊꧌风룐럒냔郖볘뗚룜귞胠迢ꧤ裦軨꿪蓬鳮臰곲듴컶컸컺쯼", a_)))
					{
						num = (short)2068709381;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_9D3;
				case 49:
					num = (short)246939667;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 50:
					this.radErgoWideAdvancedModeSelTxName = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鯈꫊꧌諎ꏐ듒뫔胖냘뿚룜點藠闢蓤触諨軪觬ꋮ黰韲郴ꓶ鳸韺ꧼ蟾伀戂栄戆", a_), global::CommonResources.AcgResources.ID_MODESELTXNAME, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadErgoWideAdvancedModeSelTxNameLovStrs);
					this.radErgoWideAdvancedModeSelTxName.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.radErgoWideAdvancedModeSelTxName.DataTransferOrder = 164;
					num = (short)1587937292;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 51:
					goto IL_1E7;
				case 52:
					goto IL_51F;
				case 53:
					goto IL_797;
				case 54:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鯈꫊꧌风룐럒냔郖볘뗚룜귞胠迢ꇤ触髨룪觬뿮黰臲致ꣶ췸쿺염쯾㔀", a_)))
					{
						num = (short)1609760825;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_6B7;
				case 55:
					goto IL_932;
				case 56:
					this.radWideRecentCallListDeleteEnable = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鯈꫊꧌风룐럒냔藖볘룚룜뇞闠ꃢ蓤详藨꟪蓬鳮藰럲郴鯶鳸迺飼뫾漀戂朄欆氈", a_), global::CommonResources.AcgResources.ID_RECENTCALLDELENABLE);
					this.radWideRecentCallListDeleteEnable.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radWideRecentCallListDeleteEnable.DataTransferOrder = 166;
					num = (short)1485439028;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 57:
					this.radWideGeneralDnsSdPort_44844 = new global::AcpBusinessLayer.AcpSimpleRangeField(5353, this, global::AllFeatures.CodeplugGuid.b("鯈꫊꧌风룐럒냔郖볘뗚룜귞胠迢ꇤ触髨룪觬뿮黰臲致ꣶ췸쿺염쯾㔀", a_), global::CommonResources.AcgResources.ID_ONPREM_CDA_DNSSDPORT_FLD, 0, 65535, null, null, 0, 1);
					this.radWideGeneralDnsSdPort_44844.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radWideGeneralDnsSdPort_44844.DataTransferOrder = 163;
					num = (short)410058773;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_115:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)640942124;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_13C:
				num = (short)635568131;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1E7:
				num = (short)1114374186;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3CA:
				num = (short)1634205724;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_60E:
				num = (short)496566295;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_6B7:
				num = (short)1819148333;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_797:
				num = (short)264568852;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_84C:
				num = (short)635699218;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_899:
				num = (short)209584176;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_8E6:
				num = (short)1737621526;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_932:
				num = (short)2094137398;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_9D3:
				num = (short)481558553;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_A20:
				num = (short)262602756;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_A69:
				this.radWideAdvancedMaximumTxDeviation_A8480 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.indexRadWideAdvancedMaximumTxDeviation_A8480LovStrs, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.idRadWideAdvancedMaximumTxDeviation_A8480LovStrs), this, global::AllFeatures.CodeplugGuid.b("鯈꫊꧌风룐럒냔雖뷘귚볜뇞苠蛢臤ꫦ裨鏪蓬苮蓰黲ꇴ迶뷸黺诼雾怀眂氄栆月吊䰌㜎┐⬒└", a_), global::CommonResources.AcgResources.ID_MAXIMUMTXDEVIATION, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideAdvancedMaximumTxDeviation_A8480LovStrs);
				this.radWideAdvancedMaximumTxDeviation_A8480.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
				this.radWideAdvancedMaximumTxDeviation_A8480.DataTransferOrder = 28;
				num = (short)54853645;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_B18:
				num = (short)365035526;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_C1A:
				num = (short)163971115;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_C65:
				num = (short)1509097487;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_CB3:
				num = (short)1972764681;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_DF9:
				num = (short)2078998536;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_51F:
			IL_E46:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("軈껊ꏌ꫎ꏐ닒맔", a_);
			base.Id = 10099;
			base.UIName = global::CommonResources.AcgResources.ID_GENERAL;
			base.DataTransferOrder = 6;
		}

		// Token: 0x06003406 RID: 13318 RVA: 0x00321900 File Offset: 0x0031FB00
		public override void PopulateReferences()
		{
			short num = (short)105578496;
			short num2 = num;
			num = (short)822532699;
			short num3 = num;
			num = (short)1214044763;
			switch (num3 == num)
			{
			}
			num = (short)256638977;
			if (num != 0)
			{
			}
			num = (short)756940800;
			if (num != 0)
			{
			}
		}

		// Token: 0x06003407 RID: 13319 RVA: 0x003219AC File Offset: 0x0031FBAC
		public override void DropReferences()
		{
			short num = (short)1179451392;
			short num2 = num;
			num = (short)1328523845;
			short num3 = num;
			num = (short)851421765;
			switch (num3 == num)
			{
			}
			num = (short)1699610625;
			if (num != 0)
			{
			}
			num = (short)312016896;
			if (num != 0)
			{
			}
		}

		// Token: 0x06003408 RID: 13320 RVA: 0x00321A54 File Offset: 0x0031FC54
		public override void SetConstraints()
		{
			short num = (short)318439424;
			short num2 = num;
			num = (short)200678680;
			short num3 = num;
			num = (short)495656216;
			switch (num3 == num)
			{
			}
			num = (short)909508609;
			if (num != 0)
			{
			}
			num = (short)326893568;
			if (num != 0)
			{
			}
			this.radInfoGeneralMotorcycleRadio_A8546.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.radWideGeneralOwnerSystemID_A37153.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConAdvancedKeyTypeIsASK);
			this.radWideGeneralOwnerWACNID_A38656.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConAdvancedKeyTypeIsAWK);
			this.radWideGeneralProgrammingPath_44845.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
		}

		// Token: 0x06003409 RID: 13321 RVA: 0x00321B5C File Offset: 0x0031FD5C
		public override void SetupDependencies()
		{
			short num = (short)1994784768;
			short num2 = num;
			num = (short)1225882388;
			short num3 = num;
			num = (short)422345492;
			switch (num3 == num)
			{
			}
			num = (short)1836253185;
			if (num != 0)
			{
			}
			num = (short)1115750400;
			if (num != 0)
			{
			}
			this.radWideGeneralOwnerAdvancedKeyType_A38663.AddDependentObject(this.radWideGeneralOwnerWACNID_A38656);
		}

		// Token: 0x17001A43 RID: 6723
		// (get) Token: 0x0600340A RID: 13322 RVA: 0x00321C18 File Offset: 0x0031FE18
		public bool HasDiffs
		{
			get
			{
				short num = (short)2098200576;
				short num2 = num;
				num = (short)1053663881;
				short num3 = num;
				num = (short)1142137481;
				switch (num3 == num)
				{
				}
				num = (short)547291136;
				if (num != 0)
				{
				}
				num = (short)505872385;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17001A44 RID: 6724
		// (get) Token: 0x0600340B RID: 13323 RVA: 0x00321CC8 File Offset: 0x0031FEC8
		// (set) Token: 0x0600340C RID: 13324 RVA: 0x00321D80 File Offset: 0x0031FF80
		public int RadWideGeneralDateFormat_A7802Value
		{
			get
			{
				short num = (short)931266560;
				short num2 = num;
				num = (short)1610057293;
				short num3 = num;
				num = (short)2078639693;
				switch (num3 == num)
				{
				}
				num = (short)314638337;
				if (num != 0)
				{
				}
				num = (short)1430585344;
				if (num != 0)
				{
				}
				return this.radWideGeneralDateFormat_A7802.Value;
			}
			set
			{
				short num = (short)887160832;
				short num2 = num;
				num = (short)1288672537;
				short num3 = num;
				num = (short)1951503641;
				switch (num3 == num)
				{
				}
				num = (short)978124800;
				if (num != 0)
				{
				}
				num = (short)631701505;
				if (num != 0)
				{
				}
				this.radWideGeneralDateFormat_A7802.Value = value;
			}
		}

		// Token: 0x17001A45 RID: 6725
		// (get) Token: 0x0600340D RID: 13325 RVA: 0x00321E34 File Offset: 0x00320034
		// (set) Token: 0x0600340E RID: 13326 RVA: 0x00321EEC File Offset: 0x003200EC
		public string RadWideGeneralDateFormat_A7802_UIValue
		{
			get
			{
				short num = (short)1683816448;
				short num2 = num;
				num = (short)1894656839;
				short num3 = num;
				num = (short)162671431;
				switch (num3 == num)
				{
				}
				num = (short)1555628033;
				if (num != 0)
				{
				}
				num = (short)2047541248;
				if (num != 0)
				{
				}
				return this.radWideGeneralDateFormat_A7802.UIValue;
			}
			set
			{
				short num = (short)1461780480;
				short num2 = num;
				num = (short)2006470580;
				short num3 = num;
				num = (short)339300276;
				switch (num3 == num)
				{
				}
				num = (short)741081088;
				if (num != 0)
				{
				}
				num = (short)1189347329;
				if (num != 0)
				{
				}
				this.radWideGeneralDateFormat_A7802.UIValue = value;
			}
		}

		// Token: 0x17001A46 RID: 6726
		// (get) Token: 0x0600340F RID: 13327 RVA: 0x00321FA4 File Offset: 0x003201A4
		public global::AcpBusinessLayer.AcpListField RadWideGeneralDateFormat_A7802
		{
			get
			{
				short num = (short)1847787520;
				short num2 = num;
				num = (short)1445477015;
				short num3 = num;
				num = (short)580926103;
				switch (num3 == num)
				{
				}
				num = (short)546832384;
				if (num != 0)
				{
				}
				num = (short)225640449;
				if (num != 0)
				{
				}
				return this.radWideGeneralDateFormat_A7802;
			}
		}

		// Token: 0x17001A47 RID: 6727
		// (get) Token: 0x06003410 RID: 13328 RVA: 0x00322050 File Offset: 0x00320250
		// (set) Token: 0x06003411 RID: 13329 RVA: 0x00322104 File Offset: 0x00320304
		public bool RadWideGeneralDateFormat_A7802_Applicable
		{
			get
			{
				short num = (short)1849425920;
				short num2 = num;
				num = (short)1224315064;
				short num3 = num;
				num = (short)2045874360;
				switch (num3 == num)
				{
				}
				num = (short)1545994241;
				if (num != 0)
				{
				}
				num = (short)2090008576;
				if (num != 0)
				{
				}
				return this.radWideGeneralDateFormat_A7802.Applicable;
			}
			set
			{
				short num = (short)285278208;
				short num2 = num;
				num = (short)190351906;
				short num3 = num;
				num = (short)1545308706;
				switch (num3 == num)
				{
				}
				num = (short)616759296;
				if (num != 0)
				{
				}
				num = (short)1101332481;
				if (num != 0)
				{
				}
				this.radWideGeneralDateFormat_A7802.Applicable = value;
			}
		}

		// Token: 0x17001A48 RID: 6728
		// (get) Token: 0x06003412 RID: 13330 RVA: 0x003221B8 File Offset: 0x003203B8
		// (set) Token: 0x06003413 RID: 13331 RVA: 0x00322270 File Offset: 0x00320470
		public bool RadWideGeneralDateFormat_A7802_Valid
		{
			get
			{
				short num = (short)694747136;
				short num2 = num;
				num = (short)1278006189;
				short num3 = num;
				num = (short)1145295789;
				switch (num3 == num)
				{
				}
				num = (short)1864040449;
				if (num != 0)
				{
				}
				num = (short)1995112448;
				if (num != 0)
				{
				}
				return this.radWideGeneralDateFormat_A7802.Valid;
			}
			set
			{
				short num = (short)1804992512;
				short num2 = num;
				num = (short)1471381286;
				short num3 = num;
				num = (short)1627160358;
				switch (num3 == num)
				{
				}
				num = (short)1467023360;
				if (num != 0)
				{
				}
				num = (short)1306853377;
				if (num != 0)
				{
				}
				this.radWideGeneralDateFormat_A7802.Valid = value;
			}
		}

		// Token: 0x17001A49 RID: 6729
		// (get) Token: 0x06003414 RID: 13332 RVA: 0x00322328 File Offset: 0x00320528
		// (set) Token: 0x06003415 RID: 13333 RVA: 0x003223DC File Offset: 0x003205DC
		public bool RadWideGeneralDateFormat_A7802_Visible
		{
			get
			{
				short num = (short)1129316352;
				short num2 = num;
				num = (short)1758906532;
				short num3 = num;
				num = (short)991283364;
				switch (num3 == num)
				{
				}
				num = (short)1155268609;
				if (num != 0)
				{
				}
				num = (short)800129024;
				if (num != 0)
				{
				}
				return this.radWideGeneralDateFormat_A7802.Visible;
			}
			set
			{
				short num = (short)1534590976;
				short num2 = num;
				num = (short)1496060603;
				short num3 = num;
				num = (short)248320699;
				switch (num3 == num)
				{
				}
				num = (short)1243938817;
				if (num != 0)
				{
				}
				num = (short)1805123584;
				if (num != 0)
				{
				}
				this.radWideGeneralDateFormat_A7802.Visible = value;
			}
		}

		// Token: 0x17001A4A RID: 6730
		// (get) Token: 0x06003416 RID: 13334 RVA: 0x00322490 File Offset: 0x00320690
		// (set) Token: 0x06003417 RID: 13335 RVA: 0x00322544 File Offset: 0x00320744
		public bool RadWideGeneralDateFormat_A7802_Editable
		{
			get
			{
				short num = (short)531300352;
				short num2 = num;
				num = (short)2133367873;
				short num3 = num;
				num = (short)463641665;
				switch (num3 == num)
				{
				}
				num = (short)1729036289;
				if (num != 0)
				{
				}
				num = (short)1811480576;
				if (num != 0)
				{
				}
				return this.radWideGeneralDateFormat_A7802.Editable;
			}
			set
			{
				short num = (short)453967872;
				short num2 = num;
				num = (short)172273304;
				short num3 = num;
				num = (short)1288416920;
				switch (num3 == num)
				{
				}
				num = (short)1213267969;
				if (num != 0)
				{
				}
				num = (short)333709312;
				if (num != 0)
				{
				}
				this.radWideGeneralDateFormat_A7802.Editable = value;
			}
		}

		// Token: 0x17001A4B RID: 6731
		// (get) Token: 0x06003418 RID: 13336 RVA: 0x003225F8 File Offset: 0x003207F8
		internal string RadWideGeneralDateFormat_A7802_UILabel
		{
			get
			{
				short num = (short)1834811392;
				short num2 = num;
				num = (short)996148391;
				short num3 = num;
				num = (short)173933735;
				switch (num3 == num)
				{
				}
				num = (short)558432257;
				if (num != 0)
				{
				}
				num = (short)1094516736;
				if (num != 0)
				{
				}
				return this.radWideGeneralDateFormat_A7802.UIName;
			}
		}

		// Token: 0x17001A4C RID: 6732
		// (get) Token: 0x06003419 RID: 13337 RVA: 0x003226AC File Offset: 0x003208AC
		// (set) Token: 0x0600341A RID: 13338 RVA: 0x00322760 File Offset: 0x00320960
		internal bool RadWideGeneralDateFormat_A7802_HiddenStatic
		{
			get
			{
				short num = (short)1542324224;
				short num2 = num;
				num = (short)1593891043;
				short num3 = num;
				num = (short)1308285155;
				switch (num3 == num)
				{
				}
				num = (short)1338048512;
				if (num != 0)
				{
				}
				num = (short)396623873;
				if (num != 0)
				{
				}
				return this.radWideGeneralDateFormat_A7802.HiddenStatic;
			}
			set
			{
				short num = (short)318767104;
				short num2 = num;
				num = (short)380617334;
				short num3 = num;
				num = (short)1450885750;
				switch (num3 == num)
				{
				}
				num = (short)1699872769;
				if (num != 0)
				{
				}
				num = (short)534642688;
				if (num != 0)
				{
				}
				this.radWideGeneralDateFormat_A7802.HiddenStatic = value;
			}
		}

		// Token: 0x17001A4D RID: 6733
		// (get) Token: 0x0600341B RID: 13339 RVA: 0x00322818 File Offset: 0x00320A18
		// (set) Token: 0x0600341C RID: 13340 RVA: 0x003228CC File Offset: 0x00320ACC
		internal bool RadWideGeneralDateFormat_A7802_HiddenDynamic
		{
			get
			{
				short num = (short)356712448;
				short num2 = num;
				num = (short)729575378;
				short num3 = num;
				num = (short)602894290;
				switch (num3 == num)
				{
				}
				num = (short)1392574464;
				if (num != 0)
				{
				}
				num = (short)1475411969;
				if (num != 0)
				{
				}
				return this.radWideGeneralDateFormat_A7802.HiddenDynamic;
			}
			set
			{
				short num = (short)146472960;
				short num2 = num;
				num = (short)571505950;
				short num3 = num;
				num = (short)502037790;
				switch (num3 == num)
				{
				}
				num = (short)20054016;
				if (num != 0)
				{
				}
				num = (short)512229377;
				if (num != 0)
				{
				}
				this.radWideGeneralDateFormat_A7802.HiddenDynamic = value;
			}
		}

		// Token: 0x17001A4E RID: 6734
		// (get) Token: 0x0600341D RID: 13341 RVA: 0x00322980 File Offset: 0x00320B80
		public bool RadWideGeneralDateFormat_A7802_HasDiffs
		{
			get
			{
				short num = (short)1707671552;
				short num2 = num;
				num = (short)1638518907;
				short num3 = num;
				num = (short)1030279291;
				switch (num3 == num)
				{
				}
				num = (short)627245056;
				if (num != 0)
				{
				}
				num = (short)1275461633;
				if (num != 0)
				{
				}
				return this.radWideGeneralDateFormat_A7802._HasDiffs;
			}
		}

		// Token: 0x17001A4F RID: 6735
		// (get) Token: 0x0600341E RID: 13342 RVA: 0x00322A34 File Offset: 0x00320C34
		// (set) Token: 0x0600341F RID: 13343 RVA: 0x00322AE8 File Offset: 0x00320CE8
		public int RadWideAdvancedMaximumTxDeviation_A8480Value
		{
			get
			{
				short num = (short)1513684992;
				short num2 = num;
				num = (short)1644756993;
				if (num != 0)
				{
				}
				num = (short)1559422725;
				short num3 = num;
				num = (short)1169024773;
				switch (num3 == num)
				{
				}
				num = (short)1107492864;
				if (num != 0)
				{
				}
				return this.radWideAdvancedMaximumTxDeviation_A8480.Value;
			}
			set
			{
				short num = (short)651165696;
				short num2 = num;
				num = (short)1106255281;
				short num3 = num;
				num = (short)793320881;
				switch (num3 == num)
				{
				}
				num = (short)444989440;
				if (num != 0)
				{
				}
				num = (short)375128065;
				if (num != 0)
				{
				}
				this.radWideAdvancedMaximumTxDeviation_A8480.Value = value;
			}
		}

		// Token: 0x17001A50 RID: 6736
		// (get) Token: 0x06003420 RID: 13344 RVA: 0x00322B9C File Offset: 0x00320D9C
		// (set) Token: 0x06003421 RID: 13345 RVA: 0x00322C50 File Offset: 0x00320E50
		public string RadWideAdvancedMaximumTxDeviation_A8480_UIValue
		{
			get
			{
				short num = (short)785027637;
				short num2 = num;
				num = (short)409834037;
				switch (num2 == num)
				{
				default:
				{
					num = (short)906362880;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1971257345;
				if (num != 0)
				{
				}
				num = (short)86769664;
				if (num != 0)
				{
				}
				return this.radWideAdvancedMaximumTxDeviation_A8480.UIValue;
			}
			set
			{
				short num = (short)1721616213;
				short num2 = num;
				num = (short)146392917;
				switch (num2 == num)
				{
				default:
				{
					num = (short)900792320;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)983826433;
				if (num != 0)
				{
				}
				num = (short)903610368;
				if (num != 0)
				{
				}
				this.radWideAdvancedMaximumTxDeviation_A8480.UIValue = value;
			}
		}

		// Token: 0x17001A51 RID: 6737
		// (get) Token: 0x06003422 RID: 13346 RVA: 0x00322D08 File Offset: 0x00320F08
		public global::AcpBusinessLayer.AcpListField RadWideAdvancedMaximumTxDeviation_A8480
		{
			get
			{
				short num = (short)1887047476;
				short num2 = num;
				num = (short)1939083060;
				switch (num2 == num)
				{
				default:
				{
					num = (short)155058176;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1653866497;
				if (num != 0)
				{
				}
				num = (short)1900347392;
				if (num != 0)
				{
				}
				return this.radWideAdvancedMaximumTxDeviation_A8480;
			}
		}

		// Token: 0x17001A52 RID: 6738
		// (get) Token: 0x06003423 RID: 13347 RVA: 0x00322DB8 File Offset: 0x00320FB8
		// (set) Token: 0x06003424 RID: 13348 RVA: 0x00322E70 File Offset: 0x00321070
		public bool RadWideAdvancedMaximumTxDeviation_A8480_Applicable
		{
			get
			{
				short num = (short)769859205;
				short num2 = num;
				num = (short)1113464453;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1351286784;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1262026752;
				if (num != 0)
				{
				}
				num = (short)566231041;
				if (num != 0)
				{
				}
				return this.radWideAdvancedMaximumTxDeviation_A8480.Applicable;
			}
			set
			{
				short num = (short)392232961;
				if (num != 0)
				{
				}
				num = (short)2021392384;
				short num2 = num;
				num = (short)1674127707;
				short num3 = num;
				num = (short)33106267;
				switch (num3 == num)
				{
				}
				num = (short)912850944;
				if (num != 0)
				{
				}
				this.radWideAdvancedMaximumTxDeviation_A8480.Applicable = value;
			}
		}

		// Token: 0x17001A53 RID: 6739
		// (get) Token: 0x06003425 RID: 13349 RVA: 0x00322F24 File Offset: 0x00321124
		// (set) Token: 0x06003426 RID: 13350 RVA: 0x00322FD8 File Offset: 0x003211D8
		public bool RadWideAdvancedMaximumTxDeviation_A8480_Valid
		{
			get
			{
				short num = (short)866393782;
				short num2 = num;
				num = (short)44768950;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1869611008;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1574699009;
				if (num != 0)
				{
				}
				num = (short)122159104;
				if (num != 0)
				{
				}
				return this.radWideAdvancedMaximumTxDeviation_A8480.Valid;
			}
			set
			{
				short num = (short)1518493104;
				short num2 = num;
				num = (short)280059312;
				switch (num2 == num)
				{
				default:
				{
					num = (short)974323712;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)115867649;
				if (num != 0)
				{
				}
				num = (short)630390784;
				if (num != 0)
				{
				}
				this.radWideAdvancedMaximumTxDeviation_A8480.Valid = value;
			}
		}

		// Token: 0x17001A54 RID: 6740
		// (get) Token: 0x06003427 RID: 13351 RVA: 0x0032308C File Offset: 0x0032128C
		// (set) Token: 0x06003428 RID: 13352 RVA: 0x00323144 File Offset: 0x00321344
		public bool RadWideAdvancedMaximumTxDeviation_A8480_Visible
		{
			get
			{
				short num = (short)174391297;
				if (num != 0)
				{
				}
				num = (short)22478848;
				short num2 = num;
				num = (short)379280458;
				short num3 = num;
				num = (short)115629130;
				switch (num3 == num)
				{
				}
				num = (short)1449787392;
				if (num != 0)
				{
				}
				return this.radWideAdvancedMaximumTxDeviation_A8480.Visible;
			}
			set
			{
				short num = (short)1085079553;
				if (num != 0)
				{
				}
				num = (short)1385431040;
				short num2 = num;
				num = (short)1098560505;
				short num3 = num;
				num = (short)1940435961;
				switch (num3 == num)
				{
				}
				num = (short)690356224;
				if (num != 0)
				{
				}
				this.radWideAdvancedMaximumTxDeviation_A8480.Visible = value;
			}
		}

		// Token: 0x17001A55 RID: 6741
		// (get) Token: 0x06003429 RID: 13353 RVA: 0x003231F8 File Offset: 0x003213F8
		// (set) Token: 0x0600342A RID: 13354 RVA: 0x003232AC File Offset: 0x003214AC
		public bool RadWideAdvancedMaximumTxDeviation_A8480_Editable
		{
			get
			{
				short num = (short)380220527;
				short num2 = num;
				num = (short)449098863;
				switch (num2 == num)
				{
				default:
				{
					num = (short)309985280;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)260374528;
				if (num != 0)
				{
				}
				num = (short)1774125057;
				if (num != 0)
				{
				}
				return this.radWideAdvancedMaximumTxDeviation_A8480.Editable;
			}
			set
			{
				short num = (short)1729474504;
				short num2 = num;
				num = (short)1274982344;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1915813888;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1922433025;
				if (num != 0)
				{
				}
				num = (short)2092367872;
				if (num != 0)
				{
				}
				this.radWideAdvancedMaximumTxDeviation_A8480.Editable = value;
			}
		}

		// Token: 0x17001A56 RID: 6742
		// (get) Token: 0x0600342B RID: 13355 RVA: 0x00323360 File Offset: 0x00321560
		internal string RadWideAdvancedMaximumTxDeviation_A8480_UILabel
		{
			get
			{
				short num = (short)785392361;
				short num2 = num;
				num = (short)1178215145;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1270415360;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1758199809;
				if (num != 0)
				{
				}
				num = (short)2101084160;
				if (num != 0)
				{
				}
				return this.radWideAdvancedMaximumTxDeviation_A8480.UIName;
			}
		}

		// Token: 0x17001A57 RID: 6743
		// (get) Token: 0x0600342C RID: 13356 RVA: 0x00323414 File Offset: 0x00321614
		// (set) Token: 0x0600342D RID: 13357 RVA: 0x003234CC File Offset: 0x003216CC
		internal bool RadWideAdvancedMaximumTxDeviation_A8480_HiddenStatic
		{
			get
			{
				short num = (short)1992937838;
				short num2 = num;
				num = (short)317182318;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1982529536;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)558432257;
				if (num != 0)
				{
				}
				num = (short)375259136;
				if (num != 0)
				{
				}
				return this.radWideAdvancedMaximumTxDeviation_A8480.HiddenStatic;
			}
			set
			{
				short num = (short)365174588;
				short num2 = num;
				num = (short)1858412348;
				switch (num2 == num)
				{
				default:
				{
					num = (short)3407872;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)600047617;
				if (num != 0)
				{
				}
				num = (short)854130688;
				if (num != 0)
				{
				}
				this.radWideAdvancedMaximumTxDeviation_A8480.HiddenStatic = value;
			}
		}

		// Token: 0x17001A58 RID: 6744
		// (get) Token: 0x0600342E RID: 13358 RVA: 0x00323580 File Offset: 0x00321780
		// (set) Token: 0x0600342F RID: 13359 RVA: 0x00323634 File Offset: 0x00321834
		internal bool RadWideAdvancedMaximumTxDeviation_A8480_HiddenDynamic
		{
			get
			{
				short num = (short)646643713;
				if (num != 0)
				{
				}
				num = (short)1466564608;
				short num2 = num;
				num = (short)1408524488;
				short num3 = num;
				num = (short)1577148616;
				switch (num3 == num)
				{
				}
				num = (short)1233453056;
				if (num != 0)
				{
				}
				return this.radWideAdvancedMaximumTxDeviation_A8480.HiddenDynamic;
			}
			set
			{
				short num = (short)1019672467;
				short num2 = num;
				num = (short)1039988627;
				switch (num2 == num)
				{
				default:
				{
					num = (short)755499008;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1587806209;
				if (num != 0)
				{
				}
				num = (short)1411842048;
				if (num != 0)
				{
				}
				this.radWideAdvancedMaximumTxDeviation_A8480.HiddenDynamic = value;
			}
		}

		// Token: 0x17001A59 RID: 6745
		// (get) Token: 0x06003430 RID: 13360 RVA: 0x003236E8 File Offset: 0x003218E8
		public bool RadWideAdvancedMaximumTxDeviation_A8480_HasDiffs
		{
			get
			{
				short num = (short)1589917956;
				short num2 = num;
				num = (short)867055876;
				switch (num2 == num)
				{
				default:
				{
					num = (short)666632192;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1010302977;
				if (num != 0)
				{
				}
				num = (short)1063190528;
				if (num != 0)
				{
				}
				return this.radWideAdvancedMaximumTxDeviation_A8480._HasDiffs;
			}
		}

		// Token: 0x17001A5A RID: 6746
		// (get) Token: 0x06003431 RID: 13361 RVA: 0x0032379C File Offset: 0x0032199C
		// (set) Token: 0x06003432 RID: 13362 RVA: 0x00323850 File Offset: 0x00321A50
		public bool RadInfoGeneralMotorcycleRadio_A8546Value
		{
			get
			{
				short num = (short)1941504769;
				short num2 = num;
				num = (short)915145473;
				switch (num2 == num)
				{
				default:
				{
					num = (short)223150080;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)741474305;
				if (num != 0)
				{
				}
				num = (short)732495872;
				if (num != 0)
				{
				}
				return this.radInfoGeneralMotorcycleRadio_A8546.Value;
			}
			set
			{
				short num = (short)1155508824;
				short num2 = num;
				num = (short)740797016;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1295777792;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)987824129;
				if (num != 0)
				{
				}
				num = (short)1842020352;
				if (num != 0)
				{
				}
				this.radInfoGeneralMotorcycleRadio_A8546.Value = value;
			}
		}

		// Token: 0x17001A5B RID: 6747
		// (get) Token: 0x06003433 RID: 13363 RVA: 0x0032390C File Offset: 0x00321B0C
		public global::AcpBusinessLayer.AcpField<bool> RadInfoGeneralMotorcycleRadio_A8546
		{
			get
			{
				short num = (short)16859023;
				short num2 = num;
				num = (short)1982939023;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1631649792;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1210712065;
				if (num != 0)
				{
				}
				num = (short)431095808;
				if (num != 0)
				{
				}
				return this.radInfoGeneralMotorcycleRadio_A8546;
			}
		}

		// Token: 0x17001A5C RID: 6748
		// (get) Token: 0x06003434 RID: 13364 RVA: 0x003239B8 File Offset: 0x00321BB8
		// (set) Token: 0x06003435 RID: 13365 RVA: 0x00323A70 File Offset: 0x00321C70
		public bool RadInfoGeneralMotorcycleRadio_A8546_UIValue
		{
			get
			{
				short num = (short)1905378360;
				short num2 = num;
				num = (short)689226808;
				switch (num2 == num)
				{
				default:
				{
					num = (short)971702272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2128347137;
				if (num != 0)
				{
				}
				num = (short)1699151872;
				if (num != 0)
				{
				}
				return this.radInfoGeneralMotorcycleRadio_A8546.Value;
			}
			set
			{
				short num = (short)186084806;
				short num2 = num;
				num = (short)1903455686;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1274019840;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1959002113;
				if (num != 0)
				{
				}
				num = (short)860553216;
				if (num != 0)
				{
				}
				this.radInfoGeneralMotorcycleRadio_A8546.Value = value;
			}
		}

		// Token: 0x17001A5D RID: 6749
		// (get) Token: 0x06003436 RID: 13366 RVA: 0x00323B24 File Offset: 0x00321D24
		// (set) Token: 0x06003437 RID: 13367 RVA: 0x00323BD8 File Offset: 0x00321DD8
		public bool RadInfoGeneralMotorcycleRadio_A8546_Applicable
		{
			get
			{
				short num = (short)1152909313;
				if (num != 0)
				{
				}
				num = (short)1100939264;
				short num2 = num;
				num = (short)945554575;
				short num3 = num;
				num = (short)2066154639;
				switch (num3 == num)
				{
				}
				num = (short)1655308288;
				if (num != 0)
				{
				}
				return this.radInfoGeneralMotorcycleRadio_A8546.Applicable;
			}
			set
			{
				short num = (short)1599228834;
				short num2 = num;
				num = (short)451365794;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1431437312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1727397888;
				if (num != 0)
				{
				}
				num = (short)2098790401;
				if (num != 0)
				{
				}
				this.radInfoGeneralMotorcycleRadio_A8546.Applicable = value;
			}
		}

		// Token: 0x17001A5E RID: 6750
		// (get) Token: 0x06003438 RID: 13368 RVA: 0x00323C8C File Offset: 0x00321E8C
		// (set) Token: 0x06003439 RID: 13369 RVA: 0x00323D44 File Offset: 0x00321F44
		public bool RadInfoGeneralMotorcycleRadio_A8546_Valid
		{
			get
			{
				short num = (short)809459733;
				short num2 = num;
				num = (short)1391484949;
				switch (num2 == num)
				{
				default:
				{
					num = (short)858849280;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)858193920;
				if (num != 0)
				{
				}
				num = (short)2127298561;
				if (num != 0)
				{
				}
				return this.radInfoGeneralMotorcycleRadio_A8546.Valid;
			}
			set
			{
				short num = (short)163470959;
				short num2 = num;
				num = (short)1075928687;
				switch (num2 == num)
				{
				default:
				{
					num = (short)601423872;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)205389824;
				if (num != 0)
				{
				}
				num = (short)626262017;
				if (num != 0)
				{
				}
				this.radInfoGeneralMotorcycleRadio_A8546.Valid = value;
			}
		}

		// Token: 0x17001A5F RID: 6751
		// (get) Token: 0x0600343A RID: 13370 RVA: 0x00323DFC File Offset: 0x00321FFC
		// (set) Token: 0x0600343B RID: 13371 RVA: 0x00323EB0 File Offset: 0x003220B0
		public bool RadInfoGeneralMotorcycleRadio_A8546_Visible
		{
			get
			{
				short num = (short)36889164;
				short num2 = num;
				num = (short)173728332;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1672151040;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1099366401;
				if (num != 0)
				{
				}
				num = (short)720240640;
				if (num != 0)
				{
				}
				return this.radInfoGeneralMotorcycleRadio_A8546.Visible;
			}
			set
			{
				short num = (short)1554678682;
				short num2 = num;
				num = (short)768508826;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1556807680;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1611792385;
				if (num != 0)
				{
				}
				num = (short)2100494336;
				if (num != 0)
				{
				}
				this.radInfoGeneralMotorcycleRadio_A8546.Visible = value;
			}
		}

		// Token: 0x17001A60 RID: 6752
		// (get) Token: 0x0600343C RID: 13372 RVA: 0x00323F64 File Offset: 0x00322164
		// (set) Token: 0x0600343D RID: 13373 RVA: 0x00324018 File Offset: 0x00322218
		public bool RadInfoGeneralMotorcycleRadio_A8546_Editable
		{
			get
			{
				short num = (short)240348243;
				short num2 = num;
				num = (short)953314387;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1701969920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1380712449;
				if (num != 0)
				{
				}
				num = (short)1574240256;
				if (num != 0)
				{
				}
				return this.radInfoGeneralMotorcycleRadio_A8546.Editable;
			}
			set
			{
				short num = (short)914516617;
				short num2 = num;
				num = (short)1870293641;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1045299200;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)937558017;
				if (num != 0)
				{
				}
				num = (short)1904934912;
				if (num != 0)
				{
				}
				this.radInfoGeneralMotorcycleRadio_A8546.Editable = value;
			}
		}

		// Token: 0x17001A61 RID: 6753
		// (get) Token: 0x0600343E RID: 13374 RVA: 0x003240CC File Offset: 0x003222CC
		internal string RadInfoGeneralMotorcycleRadio_A8546_UILabel
		{
			get
			{
				short num = (short)891694375;
				short num2 = num;
				num = (short)443755815;
				switch (num2 == num)
				{
				default:
				{
					num = (short)303759360;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)687865857;
				if (num != 0)
				{
				}
				num = (short)1483866112;
				if (num != 0)
				{
				}
				return this.radInfoGeneralMotorcycleRadio_A8546.UIName;
			}
		}

		// Token: 0x17001A62 RID: 6754
		// (get) Token: 0x0600343F RID: 13375 RVA: 0x00324180 File Offset: 0x00322380
		// (set) Token: 0x06003440 RID: 13376 RVA: 0x00324230 File Offset: 0x00322430
		internal bool RadInfoGeneralMotorcycleRadio_A8546_HiddenStatic
		{
			get
			{
				short num = (short)228281501;
				short num2 = num;
				num = (short)1801997469;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1655177216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)574488577;
				if (num != 0)
				{
				}
				num = (short)1561067520;
				if (num != 0)
				{
				}
				return this.radInfoGeneralMotorcycleRadio_A8546.HiddenStatic;
			}
			set
			{
				short num = (short)810587151;
				short num2 = num;
				num = (short)603558927;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2003369984;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)448397313;
				if (num != 0)
				{
				}
				num = (short)1679097856;
				if (num != 0)
				{
				}
				this.radInfoGeneralMotorcycleRadio_A8546.HiddenStatic = value;
			}
		}

		// Token: 0x17001A63 RID: 6755
		// (get) Token: 0x06003441 RID: 13377 RVA: 0x003242E8 File Offset: 0x003224E8
		// (set) Token: 0x06003442 RID: 13378 RVA: 0x0032439C File Offset: 0x0032259C
		internal bool RadInfoGeneralMotorcycleRadio_A8546_HiddenDynamic
		{
			get
			{
				short num = (short)1426293975;
				short num2 = num;
				num = (short)225084631;
				switch (num2 == num)
				{
				default:
				{
					num = (short)533725184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)334823424;
				if (num != 0)
				{
				}
				num = (short)1626669057;
				if (num != 0)
				{
				}
				return this.radInfoGeneralMotorcycleRadio_A8546.HiddenDynamic;
			}
			set
			{
				short num = (short)43906072;
				short num2 = num;
				num = (short)1403843608;
				switch (num2 == num)
				{
				default:
				{
					num = (short)461832192;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)69533697;
				if (num != 0)
				{
				}
				num = (short)285868032;
				if (num != 0)
				{
				}
				this.radInfoGeneralMotorcycleRadio_A8546.HiddenDynamic = value;
			}
		}

		// Token: 0x17001A64 RID: 6756
		// (get) Token: 0x06003443 RID: 13379 RVA: 0x00324450 File Offset: 0x00322650
		public bool RadInfoGeneralMotorcycleRadio_A8546_HasDiffs
		{
			get
			{
				short num = (short)1888275908;
				short num2 = num;
				num = (short)1126223300;
				switch (num2 == num)
				{
				default:
				{
					num = (short)302186496;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1262288897;
				if (num != 0)
				{
				}
				num = (short)1008205824;
				if (num != 0)
				{
				}
				return this.radInfoGeneralMotorcycleRadio_A8546._HasDiffs;
			}
		}

		// Token: 0x17001A65 RID: 6757
		// (get) Token: 0x06003444 RID: 13380 RVA: 0x00324504 File Offset: 0x00322704
		// (set) Token: 0x06003445 RID: 13381 RVA: 0x003245B8 File Offset: 0x003227B8
		public int RadWideGeneralTimeFormat_A9377Value
		{
			get
			{
				short num = (short)533994515;
				short num2 = num;
				num = (short)159980563;
				switch (num2 == num)
				{
				default:
				{
					num = (short)633929728;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1107951616;
				if (num != 0)
				{
				}
				num = (short)410845185;
				if (num != 0)
				{
				}
				return this.radWideGeneralTimeFormat_A9377.Value;
			}
			set
			{
				short num = (short)1632776495;
				short num2 = num;
				num = (short)1069625647;
				switch (num2 == num)
				{
				default:
				{
					num = (short)279183360;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1145700352;
				if (num != 0)
				{
				}
				num = (short)846921729;
				if (num != 0)
				{
				}
				this.radWideGeneralTimeFormat_A9377.Value = value;
			}
		}

		// Token: 0x17001A66 RID: 6758
		// (get) Token: 0x06003446 RID: 13382 RVA: 0x00324668 File Offset: 0x00322868
		// (set) Token: 0x06003447 RID: 13383 RVA: 0x0032471C File Offset: 0x0032291C
		public string RadWideGeneralTimeFormat_A9377_UIValue
		{
			get
			{
				short num = (short)1874137404;
				short num2 = num;
				num = (short)1376325948;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1033633792;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)47841281;
				if (num != 0)
				{
				}
				num = (short)912523264;
				if (num != 0)
				{
				}
				return this.radWideGeneralTimeFormat_A9377.UIValue;
			}
			set
			{
				short num = (short)420508162;
				short num2 = num;
				num = (short)353202690;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1033306112;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)452198400;
				if (num != 0)
				{
				}
				num = (short)1829109761;
				if (num != 0)
				{
				}
				this.radWideGeneralTimeFormat_A9377.UIValue = value;
			}
		}

		// Token: 0x17001A67 RID: 6759
		// (get) Token: 0x06003448 RID: 13384 RVA: 0x003247D4 File Offset: 0x003229D4
		public global::AcpBusinessLayer.AcpListField RadWideGeneralTimeFormat_A9377
		{
			get
			{
				short num = (short)388508785;
				short num2 = num;
				num = (short)171650161;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2007040000;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)974258177;
				if (num != 0)
				{
				}
				num = (short)1681653760;
				if (num != 0)
				{
				}
				return this.radWideGeneralTimeFormat_A9377;
			}
		}

		// Token: 0x17001A68 RID: 6760
		// (get) Token: 0x06003449 RID: 13385 RVA: 0x00324884 File Offset: 0x00322A84
		// (set) Token: 0x0600344A RID: 13386 RVA: 0x0032493C File Offset: 0x00322B3C
		public bool RadWideGeneralTimeFormat_A9377_Applicable
		{
			get
			{
				short num = (short)862549859;
				short num2 = num;
				num = (short)1407940451;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1414201344;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1998061569;
				if (num != 0)
				{
				}
				num = (short)495648768;
				if (num != 0)
				{
				}
				return this.radWideGeneralTimeFormat_A9377.Applicable;
			}
			set
			{
				short num = (short)1533528877;
				short num2 = num;
				num = (short)1694747437;
				switch (num2 == num)
				{
				default:
				{
					num = (short)738983936;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1305477120;
				if (num != 0)
				{
				}
				num = (short)455671809;
				if (num != 0)
				{
				}
				this.radWideGeneralTimeFormat_A9377.Applicable = value;
			}
		}

		// Token: 0x17001A69 RID: 6761
		// (get) Token: 0x0600344B RID: 13387 RVA: 0x003249F4 File Offset: 0x00322BF4
		// (set) Token: 0x0600344C RID: 13388 RVA: 0x00324AA8 File Offset: 0x00322CA8
		public bool RadWideGeneralTimeFormat_A9377_Valid
		{
			get
			{
				short num = (short)773461045;
				short num2 = num;
				num = (short)1776030773;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1917517824;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1906311169;
				if (num != 0)
				{
				}
				num = (short)1870528512;
				if (num != 0)
				{
				}
				return this.radWideGeneralTimeFormat_A9377.Valid;
			}
			set
			{
				short num = (short)2046386931;
				short num2 = num;
				num = (short)542466803;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1163526144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)469237761;
				if (num != 0)
				{
				}
				num = (short)2144665600;
				if (num != 0)
				{
				}
				this.radWideGeneralTimeFormat_A9377.Valid = value;
			}
		}

		// Token: 0x17001A6A RID: 6762
		// (get) Token: 0x0600344D RID: 13389 RVA: 0x00324B5C File Offset: 0x00322D5C
		// (set) Token: 0x0600344E RID: 13390 RVA: 0x00324C10 File Offset: 0x00322E10
		public bool RadWideGeneralTimeFormat_A9377_Visible
		{
			get
			{
				short num = (short)592214359;
				short num2 = num;
				num = (short)409237847;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1502281728;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1571618817;
				if (num != 0)
				{
				}
				num = (short)664141824;
				if (num != 0)
				{
				}
				return this.radWideGeneralTimeFormat_A9377.Visible;
			}
			set
			{
				short num = (short)951967018;
				short num2 = num;
				num = (short)198106410;
				switch (num2 == num)
				{
				}
				num = (short)982646784;
				short num3 = num;
				num = (short)547815424;
				if (num != 0)
				{
				}
				num = (short)2073624577;
				if (num != 0)
				{
				}
				this.radWideGeneralTimeFormat_A9377.Visible = value;
			}
		}

		// Token: 0x17001A6B RID: 6763
		// (get) Token: 0x0600344F RID: 13391 RVA: 0x00324CC4 File Offset: 0x00322EC4
		// (set) Token: 0x06003450 RID: 13392 RVA: 0x00324D78 File Offset: 0x00322F78
		public bool RadWideGeneralTimeFormat_A9377_Editable
		{
			get
			{
				short num = (short)1084941675;
				short num2 = num;
				num = (short)1821631851;
				switch (num2 == num)
				{
				}
				num = (short)2054422528;
				short num3 = num;
				num = (short)1215954944;
				if (num != 0)
				{
				}
				num = (short)1284767745;
				if (num != 0)
				{
				}
				return this.radWideGeneralTimeFormat_A9377.Editable;
			}
			set
			{
				short num = (short)1216444442;
				short num2 = num;
				num = (short)771651610;
				switch (num2 == num)
				{
				}
				num = (short)795279360;
				short num3 = num;
				num = (short)1410465792;
				if (num != 0)
				{
				}
				num = (short)1723006977;
				if (num != 0)
				{
				}
				this.radWideGeneralTimeFormat_A9377.Editable = value;
			}
		}

		// Token: 0x17001A6C RID: 6764
		// (get) Token: 0x06003451 RID: 13393 RVA: 0x00324E2C File Offset: 0x0032302C
		internal string RadWideGeneralTimeFormat_A9377_UILabel
		{
			get
			{
				short num = (short)1455672035;
				short num2 = num;
				num = (short)403098339;
				switch (num2 == num)
				{
				}
				num = (short)924450816;
				short num3 = num;
				num = (short)1326055425;
				if (num != 0)
				{
				}
				num = (short)1324285952;
				if (num != 0)
				{
				}
				return this.radWideGeneralTimeFormat_A9377.UIName;
			}
		}

		// Token: 0x17001A6D RID: 6765
		// (get) Token: 0x06003452 RID: 13394 RVA: 0x00324EE0 File Offset: 0x003230E0
		// (set) Token: 0x06003453 RID: 13395 RVA: 0x00324F94 File Offset: 0x00323194
		internal bool RadWideGeneralTimeFormat_A9377_HiddenStatic
		{
			get
			{
				short num = (short)1209022157;
				short num2 = num;
				num = (short)1239496397;
				switch (num2 == num)
				{
				}
				num = (short)1600913408;
				short num3 = num;
				num = (short)948830209;
				if (num != 0)
				{
				}
				num = (short)1355808768;
				if (num != 0)
				{
				}
				return this.radWideGeneralTimeFormat_A9377.HiddenStatic;
			}
			set
			{
				short num = (short)2087877148;
				short num2 = num;
				num = (short)343570972;
				switch (num2 == num)
				{
				}
				num = (short)317521920;
				short num3 = num;
				num = (short)22085633;
				if (num != 0)
				{
				}
				num = (short)630718464;
				if (num != 0)
				{
				}
				this.radWideGeneralTimeFormat_A9377.HiddenStatic = value;
			}
		}

		// Token: 0x17001A6E RID: 6766
		// (get) Token: 0x06003454 RID: 13396 RVA: 0x0032504C File Offset: 0x0032324C
		// (set) Token: 0x06003455 RID: 13397 RVA: 0x00325100 File Offset: 0x00323300
		internal bool RadWideGeneralTimeFormat_A9377_HiddenDynamic
		{
			get
			{
				short num = (short)1819158050;
				short num2 = num;
				num = (short)1831609890;
				switch (num2 == num)
				{
				}
				num = (short)1781465088;
				short num3 = num;
				num = (short)189005824;
				if (num != 0)
				{
				}
				num = (short)1454374913;
				if (num != 0)
				{
				}
				return this.radWideGeneralTimeFormat_A9377.HiddenDynamic;
			}
			set
			{
				short num = (short)1852221301;
				short num2 = num;
				num = (short)1164420981;
				switch (num2 == num)
				{
				}
				num = (short)324927488;
				short num3 = num;
				num = (short)1383858177;
				if (num != 0)
				{
				}
				num = (short)2111307776;
				if (num != 0)
				{
				}
				this.radWideGeneralTimeFormat_A9377.HiddenDynamic = value;
			}
		}

		// Token: 0x17001A6F RID: 6767
		// (get) Token: 0x06003456 RID: 13398 RVA: 0x003251B4 File Offset: 0x003233B4
		public bool RadWideGeneralTimeFormat_A9377_HasDiffs
		{
			get
			{
				short num = (short)399858041;
				short num2 = num;
				num = (short)1884641657;
				switch (num2 == num)
				{
				}
				num = (short)888668160;
				short num3 = num;
				num = (short)1104216065;
				if (num != 0)
				{
				}
				num = (short)1917583360;
				if (num != 0)
				{
				}
				return this.radWideGeneralTimeFormat_A9377._HasDiffs;
			}
		}

		// Token: 0x17001A70 RID: 6768
		// (get) Token: 0x06003457 RID: 13399 RVA: 0x00325268 File Offset: 0x00323468
		// (set) Token: 0x06003458 RID: 13400 RVA: 0x0032531C File Offset: 0x0032351C
		public int RadWideAdvancedUltraNarrowIntermediateFreqFilter_A9592Value
		{
			get
			{
				short num = (short)1700668527;
				short num2 = num;
				num = (short)1829446767;
				switch (num2 == num)
				{
				}
				num = (short)1227751424;
				short num3 = num;
				num = (short)1088290816;
				if (num != 0)
				{
				}
				num = (short)1795948545;
				if (num != 0)
				{
				}
				return this.radWideAdvancedUltraNarrowIntermediateFreqFilter_A9592.Value;
			}
			set
			{
				short num = (short)19120837;
				short num2 = num;
				num = (short)352830149;
				switch (num2 == num)
				{
				}
				num = (short)2056126464;
				short num3 = num;
				num = (short)716767233;
				if (num != 0)
				{
				}
				num = (short)976486400;
				if (num != 0)
				{
				}
				this.radWideAdvancedUltraNarrowIntermediateFreqFilter_A9592.Value = value;
			}
		}

		// Token: 0x17001A71 RID: 6769
		// (get) Token: 0x06003459 RID: 13401 RVA: 0x003253D4 File Offset: 0x003235D4
		// (set) Token: 0x0600345A RID: 13402 RVA: 0x00325488 File Offset: 0x00323688
		public string RadWideAdvancedUltraNarrowIntermediateFreqFilter_A9592_UIValue
		{
			get
			{
				short num = (short)1161085841;
				short num2 = num;
				num = (short)973063057;
				switch (num2 == num)
				{
				}
				num = (short)74973184;
				short num3 = num;
				num = (short)1604255745;
				if (num != 0)
				{
				}
				num = (short)764870656;
				if (num != 0)
				{
				}
				return this.radWideAdvancedUltraNarrowIntermediateFreqFilter_A9592.UIValue;
			}
			set
			{
				short num = (short)1238548079;
				short num2 = num;
				num = (short)259440239;
				switch (num2 == num)
				{
				}
				num = (short)156827648;
				short num3 = num;
				num = (short)253886465;
				if (num != 0)
				{
				}
				num = (short)1657339904;
				if (num != 0)
				{
				}
				this.radWideAdvancedUltraNarrowIntermediateFreqFilter_A9592.UIValue = value;
			}
		}

		// Token: 0x17001A72 RID: 6770
		// (get) Token: 0x0600345B RID: 13403 RVA: 0x0032553C File Offset: 0x0032373C
		public global::AcpBusinessLayer.AcpListField RadWideAdvancedUltraNarrowIntermediateFreqFilter_A9592
		{
			get
			{
				short num = (short)1012976364;
				short num2 = num;
				num = (short)1332464364;
				switch (num2 == num)
				{
				}
				num = (short)1982267392;
				short num3 = num;
				num = (short)2130903041;
				if (num != 0)
				{
				}
				num = (short)1933836288;
				if (num != 0)
				{
				}
				return this.radWideAdvancedUltraNarrowIntermediateFreqFilter_A9592;
			}
		}

		// Token: 0x17001A73 RID: 6771
		// (get) Token: 0x0600345C RID: 13404 RVA: 0x003255F0 File Offset: 0x003237F0
		// (set) Token: 0x0600345D RID: 13405 RVA: 0x003256A8 File Offset: 0x003238A8
		public bool RadWideAdvancedUltraNarrowIntermediateFreqFilter_A9592_Applicable
		{
			get
			{
				short num = (short)1304771689;
				short num2 = num;
				num = (short)1440627817;
				switch (num2 == num)
				{
				}
				num = (short)524681216;
				short num3 = num;
				num = (short)682098689;
				if (num != 0)
				{
				}
				num = (short)1080033280;
				if (num != 0)
				{
				}
				return this.radWideAdvancedUltraNarrowIntermediateFreqFilter_A9592.Applicable;
			}
			set
			{
				short num = (short)124770837;
				short num2 = num;
				num = (short)715774485;
				switch (num2 == num)
				{
				}
				num = (short)1505165312;
				short num3 = num;
				num = (short)1716584448;
				if (num != 0)
				{
				}
				num = (short)264044545;
				if (num != 0)
				{
				}
				this.radWideAdvancedUltraNarrowIntermediateFreqFilter_A9592.Applicable = value;
			}
		}

		// Token: 0x17001A74 RID: 6772
		// (get) Token: 0x0600345E RID: 13406 RVA: 0x00325760 File Offset: 0x00323960
		// (set) Token: 0x0600345F RID: 13407 RVA: 0x00325814 File Offset: 0x00323A14
		public bool RadWideAdvancedUltraNarrowIntermediateFreqFilter_A9592_Valid
		{
			get
			{
				short num = (short)1999433718;
				short num2 = num;
				num = (short)165539830;
				switch (num2 == num)
				{
				}
				num = (short)720240640;
				short num3 = num;
				num = (short)124977153;
				if (num != 0)
				{
				}
				num = (short)1719533568;
				if (num != 0)
				{
				}
				return this.radWideAdvancedUltraNarrowIntermediateFreqFilter_A9592.Valid;
			}
			set
			{
				short num = (short)1353337199;
				short num2 = num;
				num = (short)1266108783;
				switch (num2 == num)
				{
				}
				num = (short)218759168;
				short num3 = num;
				num = (short)1021378561;
				if (num != 0)
				{
				}
				num = (short)1553530880;
				if (num != 0)
				{
				}
				this.radWideAdvancedUltraNarrowIntermediateFreqFilter_A9592.Valid = value;
			}
		}

		// Token: 0x17001A75 RID: 6773
		// (get) Token: 0x06003460 RID: 13408 RVA: 0x003258C8 File Offset: 0x00323AC8
		// (set) Token: 0x06003461 RID: 13409 RVA: 0x00325980 File Offset: 0x00323B80
		public bool RadWideAdvancedUltraNarrowIntermediateFreqFilter_A9592_Visible
		{
			get
			{
				short num = (short)1694271303;
				short num2 = num;
				num = (short)1027180359;
				switch (num2 == num)
				{
				}
				num = (short)1381105664;
				short num3 = num;
				num = (short)2123759617;
				if (num != 0)
				{
				}
				num = (short)561053696;
				if (num != 0)
				{
				}
				return this.radWideAdvancedUltraNarrowIntermediateFreqFilter_A9592.Visible;
			}
			set
			{
				short num = (short)1830118187;
				short num2 = num;
				num = (short)310403883;
				switch (num2 == num)
				{
				}
				num = (short)314507264;
				short num3 = num;
				num = (short)895025152;
				if (num != 0)
				{
				}
				num = (short)773324801;
				if (num != 0)
				{
				}
				this.radWideAdvancedUltraNarrowIntermediateFreqFilter_A9592.Visible = value;
			}
		}

		// Token: 0x17001A76 RID: 6774
		// (get) Token: 0x06003462 RID: 13410 RVA: 0x00325A34 File Offset: 0x00323C34
		// (set) Token: 0x06003463 RID: 13411 RVA: 0x00325AEC File Offset: 0x00323CEC
		public bool RadWideAdvancedUltraNarrowIntermediateFreqFilter_A9592_Editable
		{
			get
			{
				short num = (short)600674010;
				short num2 = num;
				num = (short)142708442;
				switch (num2 == num)
				{
				}
				num = (short)1924923392;
				short num3 = num;
				num = (short)1858928640;
				if (num != 0)
				{
				}
				num = (short)1278410753;
				if (num != 0)
				{
				}
				return this.radWideAdvancedUltraNarrowIntermediateFreqFilter_A9592.Editable;
			}
			set
			{
				short num = (short)796478614;
				short num2 = num;
				num = (short)645614742;
				switch (num2 == num)
				{
				}
				num = (short)545521664;
				short num3 = num;
				num = (short)1958608896;
				if (num != 0)
				{
				}
				num = (short)1693450241;
				if (num != 0)
				{
				}
				this.radWideAdvancedUltraNarrowIntermediateFreqFilter_A9592.Editable = value;
			}
		}

		// Token: 0x17001A77 RID: 6775
		// (get) Token: 0x06003464 RID: 13412 RVA: 0x00325BA4 File Offset: 0x00323DA4
		internal string RadWideAdvancedUltraNarrowIntermediateFreqFilter_A9592_UILabel
		{
			get
			{
				short num = (short)1401039651;
				short num2 = num;
				num = (short)1241656099;
				switch (num2 == num)
				{
				}
				num = (short)1732378624;
				short num3 = num;
				num = (short)1667563520;
				if (num != 0)
				{
				}
				num = (short)2040594433;
				if (num != 0)
				{
				}
				return this.radWideAdvancedUltraNarrowIntermediateFreqFilter_A9592.UIName;
			}
		}

		// Token: 0x17001A78 RID: 6776
		// (get) Token: 0x06003465 RID: 13413 RVA: 0x00325C58 File Offset: 0x00323E58
		// (set) Token: 0x06003466 RID: 13414 RVA: 0x00325D0C File Offset: 0x00323F0C
		internal bool RadWideAdvancedUltraNarrowIntermediateFreqFilter_A9592_HiddenStatic
		{
			get
			{
				short num = (short)872780548;
				short num2 = num;
				num = (short)47158020;
				switch (num2 == num)
				{
				}
				num = (short)1729953792;
				short num3 = num;
				num = (short)28770304;
				if (num != 0)
				{
				}
				num = (short)321650689;
				if (num != 0)
				{
				}
				return this.radWideAdvancedUltraNarrowIntermediateFreqFilter_A9592.HiddenStatic;
			}
			set
			{
				short num = (short)974379903;
				short num2 = num;
				num = (short)1648941951;
				switch (num2 == num)
				{
				}
				num = (short)1313865728;
				short num3 = num;
				num = (short)1207828481;
				if (num != 0)
				{
				}
				num = (short)1348534272;
				if (num != 0)
				{
				}
				this.radWideAdvancedUltraNarrowIntermediateFreqFilter_A9592.HiddenStatic = value;
			}
		}

		// Token: 0x17001A79 RID: 6777
		// (get) Token: 0x06003467 RID: 13415 RVA: 0x00325DC4 File Offset: 0x00323FC4
		// (set) Token: 0x06003468 RID: 13416 RVA: 0x00325E78 File Offset: 0x00324078
		internal bool RadWideAdvancedUltraNarrowIntermediateFreqFilter_A9592_HiddenDynamic
		{
			get
			{
				short num = (short)500697045;
				short num2 = num;
				num = (short)1304954837;
				switch (num2 == num)
				{
				}
				num = (short)940179456;
				short num3 = num;
				num = (short)226557953;
				if (num != 0)
				{
				}
				num = (short)489291776;
				if (num != 0)
				{
				}
				return this.radWideAdvancedUltraNarrowIntermediateFreqFilter_A9592.HiddenDynamic;
			}
			set
			{
				short num = (short)1650586053;
				short num2 = num;
				num = (short)224195013;
				switch (num2 == num)
				{
				}
				num = (short)1586888704;
				short num3 = num;
				num = (short)59768833;
				if (num != 0)
				{
				}
				num = (short)1307770880;
				if (num != 0)
				{
				}
				this.radWideAdvancedUltraNarrowIntermediateFreqFilter_A9592.HiddenDynamic = value;
			}
		}

		// Token: 0x17001A7A RID: 6778
		// (get) Token: 0x06003469 RID: 13417 RVA: 0x00325F30 File Offset: 0x00324130
		public bool RadWideAdvancedUltraNarrowIntermediateFreqFilter_A9592_HasDiffs
		{
			get
			{
				short num = (short)824981590;
				short num2 = num;
				num = (short)1853765718;
				switch (num2 == num)
				{
				}
				num = (short)744161280;
				short num3 = num;
				num = (short)362020865;
				if (num != 0)
				{
				}
				num = (short)688652288;
				if (num != 0)
				{
				}
				return this.radWideAdvancedUltraNarrowIntermediateFreqFilter_A9592._HasDiffs;
			}
		}

		// Token: 0x17001A7B RID: 6779
		// (get) Token: 0x0600346A RID: 13418 RVA: 0x00325FE4 File Offset: 0x003241E4
		// (set) Token: 0x0600346B RID: 13419 RVA: 0x00326098 File Offset: 0x00324298
		public int RadErgoWideAdvancedModeSelTxNameValue
		{
			get
			{
				short num = (short)1780945693;
				short num2 = num;
				num = (short)1835537181;
				switch (num2 == num)
				{
				}
				num = (short)1062993920;
				short num3 = num;
				num = (short)805109761;
				if (num != 0)
				{
				}
				num = (short)500891648;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedModeSelTxName.Value;
			}
			set
			{
				short num = (short)441011412;
				short num2 = num;
				num = (short)823807188;
				switch (num2 == num)
				{
				}
				num = (short)195297280;
				short num3 = num;
				num = (short)1903362049;
				if (num != 0)
				{
				}
				num = (short)1358299136;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedModeSelTxName.Value = value;
			}
		}

		// Token: 0x17001A7C RID: 6780
		// (get) Token: 0x0600346C RID: 13420 RVA: 0x0032614C File Offset: 0x0032434C
		// (set) Token: 0x0600346D RID: 13421 RVA: 0x00326200 File Offset: 0x00324400
		public string RadErgoWideAdvancedModeSelTxName_UIValue
		{
			get
			{
				short num = (short)1723310745;
				short num2 = num;
				num = (short)49980057;
				switch (num2 == num)
				{
				}
				num = (short)281346048;
				short num3 = num;
				num = (short)1909719041;
				if (num != 0)
				{
				}
				num = (short)229769216;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedModeSelTxName.UIValue;
			}
			set
			{
				short num = (short)1689055322;
				short num2 = num;
				num = (short)517599322;
				switch (num2 == num)
				{
				}
				num = (short)28114944;
				short num3 = num;
				num = (short)1491009536;
				if (num != 0)
				{
				}
				num = (short)1321598977;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedModeSelTxName.UIValue = value;
			}
		}

		// Token: 0x17001A7D RID: 6781
		// (get) Token: 0x0600346E RID: 13422 RVA: 0x003262B8 File Offset: 0x003244B8
		public global::AcpBusinessLayer.AcpListField RadErgoWideAdvancedModeSelTxName
		{
			get
			{
				short num = (short)1851451567;
				short num2 = num;
				num = (short)3467439;
				switch (num2 == num)
				{
				}
				num = (short)790036480;
				short num3 = num;
				num = (short)263454720;
				if (num != 0)
				{
				}
				num = (short)213909505;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedModeSelTxName;
			}
		}

		// Token: 0x17001A7E RID: 6782
		// (get) Token: 0x0600346F RID: 13423 RVA: 0x00326368 File Offset: 0x00324568
		// (set) Token: 0x06003470 RID: 13424 RVA: 0x0032641C File Offset: 0x0032461C
		public bool RadErgoWideAdvancedModeSelTxName_Applicable
		{
			get
			{
				short num = (short)391243453;
				short num2 = num;
				num = (short)645981885;
				switch (num2 == num)
				{
				}
				num = (short)2086469632;
				short num3 = num;
				num = (short)1794703361;
				if (num != 0)
				{
				}
				num = (short)1231486976;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedModeSelTxName.Applicable;
			}
			set
			{
				short num = (short)808878405;
				short num2 = num;
				num = (short)511279429;
				switch (num2 == num)
				{
				}
				num = (short)684457984;
				short num3 = num;
				num = (short)1359675392;
				if (num != 0)
				{
				}
				num = (short)397410305;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedModeSelTxName.Applicable = value;
			}
		}

		// Token: 0x17001A7F RID: 6783
		// (get) Token: 0x06003471 RID: 13425 RVA: 0x003264D4 File Offset: 0x003246D4
		// (set) Token: 0x06003472 RID: 13426 RVA: 0x0032658C File Offset: 0x0032478C
		public bool RadErgoWideAdvancedModeSelTxName_Valid
		{
			get
			{
				short num = (short)1387396321;
				short num2 = num;
				num = (short)1813970145;
				switch (num2 == num)
				{
				}
				num = (short)1002635264;
				short num3 = num;
				num = (short)1434976257;
				if (num != 0)
				{
				}
				num = (short)1979777024;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedModeSelTxName.Valid;
			}
			set
			{
				short num = (short)1656359807;
				short num2 = num;
				num = (short)1233455999;
				switch (num2 == num)
				{
				}
				num = (short)1174863872;
				short num3 = num;
				num = (short)2079064065;
				if (num != 0)
				{
				}
				num = (short)1586167808;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedModeSelTxName.Valid = value;
			}
		}

		// Token: 0x17001A80 RID: 6784
		// (get) Token: 0x06003473 RID: 13427 RVA: 0x00326640 File Offset: 0x00324840
		// (set) Token: 0x06003474 RID: 13428 RVA: 0x003266F4 File Offset: 0x003248F4
		public bool RadErgoWideAdvancedModeSelTxName_Visible
		{
			get
			{
				short num = (short)1994236271;
				short num2 = num;
				num = (short)416260463;
				switch (num2 == num)
				{
				}
				num = (short)589299712;
				short num3 = num;
				num = (short)371982337;
				if (num != 0)
				{
				}
				num = (short)897056768;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedModeSelTxName.Visible;
			}
			set
			{
				short num = (short)1751515137;
				if (num != 0)
				{
				}
				num = (short)264123323;
				short num2 = num;
				num = (short)575091643;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2110521344;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1683619840;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedModeSelTxName.Visible = value;
			}
		}

		// Token: 0x17001A81 RID: 6785
		// (get) Token: 0x06003475 RID: 13429 RVA: 0x003267AC File Offset: 0x003249AC
		// (set) Token: 0x06003476 RID: 13430 RVA: 0x00326860 File Offset: 0x00324A60
		public bool RadErgoWideAdvancedModeSelTxName_Editable
		{
			get
			{
				short num = (short)1810628609;
				if (num != 0)
				{
				}
				num = (short)2090382090;
				short num2 = num;
				num = (short)1087943434;
				switch (num2 == num)
				{
				default:
				{
					num = (short)637403136;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1228472320;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedModeSelTxName.Editable;
			}
			set
			{
				short num = (short)1833641594;
				short num2 = num;
				num = (short)151332474;
				switch (num2 == num)
				{
				}
				num = (short)249167872;
				short num3 = num;
				num = (short)1291124736;
				if (num != 0)
				{
				}
				num = (short)444661761;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedModeSelTxName.Editable = value;
			}
		}

		// Token: 0x17001A82 RID: 6786
		// (get) Token: 0x06003477 RID: 13431 RVA: 0x00326914 File Offset: 0x00324B14
		internal string RadErgoWideAdvancedModeSelTxName_UILabel
		{
			get
			{
				short num = (short)1958997145;
				short num2 = num;
				num = (short)636087449;
				switch (num2 == num)
				{
				}
				num = (short)493420544;
				short num3 = num;
				num = (short)1150287872;
				if (num != 0)
				{
				}
				num = (short)1942487041;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedModeSelTxName.UIName;
			}
		}

		// Token: 0x17001A83 RID: 6787
		// (get) Token: 0x06003478 RID: 13432 RVA: 0x003269C8 File Offset: 0x00324BC8
		// (set) Token: 0x06003479 RID: 13433 RVA: 0x00326A7C File Offset: 0x00324C7C
		internal bool RadErgoWideAdvancedModeSelTxName_HiddenStatic
		{
			get
			{
				short num = (short)216542046;
				short num2 = num;
				num = (short)352136030;
				switch (num2 == num)
				{
				}
				num = (short)62128128;
				short num3 = num;
				num = (short)752353281;
				if (num != 0)
				{
				}
				num = (short)1782448128;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedModeSelTxName.HiddenStatic;
			}
			set
			{
				short num = (short)1250938793;
				short num2 = num;
				num = (short)204066729;
				switch (num2 == num)
				{
				}
				num = (short)1102774272;
				short num3 = num;
				num = (short)1283457025;
				if (num != 0)
				{
				}
				num = (short)28835840;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedModeSelTxName.HiddenStatic = value;
			}
		}

		// Token: 0x17001A84 RID: 6788
		// (get) Token: 0x0600347A RID: 13434 RVA: 0x00326B34 File Offset: 0x00324D34
		// (set) Token: 0x0600347B RID: 13435 RVA: 0x00326BEC File Offset: 0x00324DEC
		internal bool RadErgoWideAdvancedModeSelTxName_HiddenDynamic
		{
			get
			{
				short num = (short)1388972798;
				short num2 = num;
				num = (short)2107706110;
				switch (num2 == num)
				{
				}
				num = (short)963903488;
				short num3 = num;
				num = (short)471138305;
				if (num != 0)
				{
				}
				num = (short)1198194688;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedModeSelTxName.HiddenDynamic;
			}
			set
			{
				short num = (short)1096964225;
				short num2 = num;
				num = (short)14178433;
				switch (num2 == num)
				{
				}
				num = (short)1090322432;
				short num3 = num;
				num = (short)1491075073;
				if (num != 0)
				{
				}
				num = (short)1593573376;
				if (num != 0)
				{
				}
				this.radErgoWideAdvancedModeSelTxName.HiddenDynamic = value;
			}
		}

		// Token: 0x17001A85 RID: 6789
		// (get) Token: 0x0600347C RID: 13436 RVA: 0x00326CA4 File Offset: 0x00324EA4
		public bool RadErgoWideAdvancedModeSelTxName_HasDiffs
		{
			get
			{
				short num = (short)178942655;
				short num2 = num;
				num = (short)1065382591;
				switch (num2 == num)
				{
				}
				num = (short)1919221760;
				short num3 = num;
				num = (short)1617690624;
				if (num != 0)
				{
				}
				num = (short)1980956673;
				if (num != 0)
				{
				}
				return this.radErgoWideAdvancedModeSelTxName._HasDiffs;
			}
		}

		// Token: 0x17001A86 RID: 6790
		// (get) Token: 0x0600347D RID: 13437 RVA: 0x00326D58 File Offset: 0x00324F58
		// (set) Token: 0x0600347E RID: 13438 RVA: 0x00326E0C File Offset: 0x0032500C
		public bool RadWideGeneralLogDisp_A9756Value
		{
			get
			{
				short num = (short)1337607760;
				short num2 = num;
				num = (short)384779856;
				switch (num2 == num)
				{
				}
				num = (short)963444736;
				short num3 = num;
				num = (short)1152188417;
				if (num != 0)
				{
				}
				num = (short)1577517056;
				if (num != 0)
				{
				}
				return this.radWideGeneralLogDisp_A9756.Value;
			}
			set
			{
				short num = (short)1262826904;
				short num2 = num;
				num = (short)460993944;
				switch (num2 == num)
				{
				}
				num = (short)680394752;
				short num3 = num;
				num = (short)525467648;
				if (num != 0)
				{
				}
				num = (short)808845313;
				if (num != 0)
				{
				}
				this.radWideGeneralLogDisp_A9756.Value = value;
			}
		}

		// Token: 0x17001A87 RID: 6791
		// (get) Token: 0x0600347F RID: 13439 RVA: 0x00326EC4 File Offset: 0x003250C4
		public global::AcpBusinessLayer.AcpField<bool> RadWideGeneralLogDisp_A9756
		{
			get
			{
				short num = (short)1691963996;
				short num2 = num;
				num = (short)186536540;
				switch (num2 == num)
				{
				}
				num = (short)2108620800;
				short num3 = num;
				num = (short)1173553152;
				if (num != 0)
				{
				}
				num = (short)1437335553;
				if (num != 0)
				{
				}
				return this.radWideGeneralLogDisp_A9756;
			}
		}

		// Token: 0x17001A88 RID: 6792
		// (get) Token: 0x06003480 RID: 13440 RVA: 0x00326F74 File Offset: 0x00325174
		// (set) Token: 0x06003481 RID: 13441 RVA: 0x00327028 File Offset: 0x00325228
		public bool RadWideGeneralLogDisp_A9756_UIValue
		{
			get
			{
				short num = (short)1380681580;
				short num2 = num;
				num = (short)535594860;
				switch (num2 == num)
				{
				}
				num = (short)726990848;
				short num3 = num;
				num = (short)1131479040;
				if (num != 0)
				{
				}
				num = (short)1354891265;
				if (num != 0)
				{
				}
				return this.radWideGeneralLogDisp_A9756.Value;
			}
			set
			{
				short num = (short)693928381;
				short num2 = num;
				num = (short)1806795197;
				switch (num2 == num)
				{
				}
				num = (short)2082209792;
				short num3 = num;
				num = (short)1259798529;
				if (num != 0)
				{
				}
				num = (short)696516608;
				if (num != 0)
				{
				}
				this.radWideGeneralLogDisp_A9756.Value = value;
			}
		}

		// Token: 0x17001A89 RID: 6793
		// (get) Token: 0x06003482 RID: 13442 RVA: 0x003270DC File Offset: 0x003252DC
		// (set) Token: 0x06003483 RID: 13443 RVA: 0x00327190 File Offset: 0x00325390
		public bool RadWideGeneralLogDisp_A9756_Applicable
		{
			get
			{
				short num = (short)122785005;
				short num2 = num;
				num = (short)74222829;
				switch (num2 == num)
				{
				}
				num = (short)1997144064;
				if (num != 0)
				{
				}
				num = (short)1664024576;
				short num3 = num;
				num = (short)1732116481;
				if (num != 0)
				{
				}
				return this.radWideGeneralLogDisp_A9756.Applicable;
			}
			set
			{
				short num = (short)2039414727;
				short num2 = num;
				num = (short)542048199;
				switch (num2 == num)
				{
				}
				num = (short)1404502017;
				if (num != 0)
				{
				}
				num = (short)1373044736;
				short num3 = num;
				num = (short)292290560;
				if (num != 0)
				{
				}
				this.radWideGeneralLogDisp_A9756.Applicable = value;
			}
		}

		// Token: 0x17001A8A RID: 6794
		// (get) Token: 0x06003484 RID: 13444 RVA: 0x00327244 File Offset: 0x00325444
		// (set) Token: 0x06003485 RID: 13445 RVA: 0x003272FC File Offset: 0x003254FC
		public bool RadWideGeneralLogDisp_A9756_Valid
		{
			get
			{
				short num = (short)665184893;
				short num2 = num;
				num = (short)796781181;
				switch (num2 == num)
				{
				}
				num = (short)1668939777;
				if (num != 0)
				{
				}
				num = (short)402653184;
				short num3 = num;
				num = (short)1814364160;
				if (num != 0)
				{
				}
				return this.radWideGeneralLogDisp_A9756.Valid;
			}
			set
			{
				short num = (short)979501057;
				if (num != 0)
				{
				}
				num = (short)736399507;
				short num2 = num;
				num = (short)1329959059;
				switch (num2 == num)
				{
				}
				num = (short)769327104;
				short num3 = num;
				num = (short)982712320;
				if (num != 0)
				{
				}
				this.radWideGeneralLogDisp_A9756.Valid = value;
			}
		}

		// Token: 0x17001A8B RID: 6795
		// (get) Token: 0x06003486 RID: 13446 RVA: 0x003273B4 File Offset: 0x003255B4
		// (set) Token: 0x06003487 RID: 13447 RVA: 0x00327468 File Offset: 0x00325668
		public bool RadWideGeneralLogDisp_A9756_Visible
		{
			get
			{
				short num = (short)248643585;
				if (num != 0)
				{
				}
				num = (short)887798343;
				short num2 = num;
				num = (short)613530183;
				switch (num2 == num)
				{
				}
				num = (short)1403060224;
				short num3 = num;
				num = (short)1510014976;
				if (num != 0)
				{
				}
				return this.radWideGeneralLogDisp_A9756.Visible;
			}
			set
			{
				short num = (short)2042160406;
				short num2 = num;
				num = (short)1314252054;
				switch (num2 == num)
				{
				}
				num = (short)1525088257;
				if (num != 0)
				{
				}
				num = (short)1370750976;
				short num3 = num;
				num = (short)213385216;
				if (num != 0)
				{
				}
				this.radWideGeneralLogDisp_A9756.Visible = value;
			}
		}

		// Token: 0x17001A8C RID: 6796
		// (get) Token: 0x06003488 RID: 13448 RVA: 0x0032751C File Offset: 0x0032571C
		// (set) Token: 0x06003489 RID: 13449 RVA: 0x003275D0 File Offset: 0x003257D0
		public bool RadWideGeneralLogDisp_A9756_Editable
		{
			get
			{
				short num = (short)2055139172;
				short num2 = num;
				num = (short)1173876580;
				switch (num2 == num)
				{
				}
				num = (short)1468203008;
				if (num != 0)
				{
				}
				num = (short)1994784768;
				short num3 = num;
				num = (short)131923969;
				if (num != 0)
				{
				}
				return this.radWideGeneralLogDisp_A9756.Editable;
			}
			set
			{
				short num = (short)649604856;
				short num2 = num;
				num = (short)1380462328;
				switch (num2 == num)
				{
				}
				num = (short)467271681;
				if (num != 0)
				{
				}
				num = (short)1472856064;
				short num3 = num;
				num = (short)1357119488;
				if (num != 0)
				{
				}
				this.radWideGeneralLogDisp_A9756.Editable = value;
			}
		}

		// Token: 0x17001A8D RID: 6797
		// (get) Token: 0x0600348A RID: 13450 RVA: 0x00327684 File Offset: 0x00325884
		internal string RadWideGeneralLogDisp_A9756_UILabel
		{
			get
			{
				short num = (short)877889623;
				short num2 = num;
				num = (short)2106493015;
				switch (num2 == num)
				{
				}
				num = (short)481361921;
				if (num != 0)
				{
				}
				num = (short)1609695232;
				short num3 = num;
				num = (short)321388544;
				if (num != 0)
				{
				}
				return this.radWideGeneralLogDisp_A9756.UIName;
			}
		}

		// Token: 0x17001A8E RID: 6798
		// (get) Token: 0x0600348B RID: 13451 RVA: 0x00327738 File Offset: 0x00325938
		// (set) Token: 0x0600348C RID: 13452 RVA: 0x003277EC File Offset: 0x003259EC
		internal bool RadWideGeneralLogDisp_A9756_HiddenStatic
		{
			get
			{
				short num = (short)1918430667;
				short num2 = num;
				num = (short)885517771;
				switch (num2 == num)
				{
				}
				num = (short)632684545;
				if (num != 0)
				{
				}
				num = (short)2123628544;
				short num3 = num;
				num = (short)543883264;
				if (num != 0)
				{
				}
				return this.radWideGeneralLogDisp_A9756.HiddenStatic;
			}
			set
			{
				short num = (short)1003721815;
				short num2 = num;
				num = (short)1705022551;
				switch (num2 == num)
				{
				}
				num = (short)2127298560;
				if (num != 0)
				{
				}
				num = (short)157548544;
				short num3 = num;
				num = (short)938213377;
				if (num != 0)
				{
				}
				this.radWideGeneralLogDisp_A9756.HiddenStatic = value;
			}
		}

		// Token: 0x17001A8F RID: 6799
		// (get) Token: 0x0600348D RID: 13453 RVA: 0x003278A0 File Offset: 0x00325AA0
		// (set) Token: 0x0600348E RID: 13454 RVA: 0x00327958 File Offset: 0x00325B58
		internal bool RadWideGeneralLogDisp_A9756_HiddenDynamic
		{
			get
			{
				short num = (short)184093860;
				short num2 = num;
				num = (short)591006884;
				switch (num2 == num)
				{
				}
				num = (short)1518731264;
				if (num != 0)
				{
				}
				num = (short)931266560;
				short num3 = num;
				num = (short)1936588801;
				if (num != 0)
				{
				}
				return this.radWideGeneralLogDisp_A9756.HiddenDynamic;
			}
			set
			{
				short num = (short)1776976341;
				short num2 = num;
				num = (short)1722188245;
				switch (num2 == num)
				{
				}
				num = (short)946536449;
				if (num != 0)
				{
				}
				num = (short)1526792192;
				short num3 = num;
				num = (short)654114816;
				if (num != 0)
				{
				}
				this.radWideGeneralLogDisp_A9756.HiddenDynamic = value;
			}
		}

		// Token: 0x17001A90 RID: 6800
		// (get) Token: 0x0600348F RID: 13455 RVA: 0x00327A10 File Offset: 0x00325C10
		public bool RadWideGeneralLogDisp_A9756_HasDiffs
		{
			get
			{
				short num = (short)1017369195;
				short num2 = num;
				num = (short)78893675;
				switch (num2 == num)
				{
				}
				num = (short)1522335744;
				if (num != 0)
				{
				}
				num = (short)447414272;
				short num3 = num;
				num = (short)1420361729;
				if (num != 0)
				{
				}
				return this.radWideGeneralLogDisp_A9756._HasDiffs;
			}
		}

		// Token: 0x17001A91 RID: 6801
		// (get) Token: 0x06003490 RID: 13456 RVA: 0x00327AC8 File Offset: 0x00325CC8
		// (set) Token: 0x06003491 RID: 13457 RVA: 0x00327B80 File Offset: 0x00325D80
		public bool RadWideGeneralASKRequired_A37152Value
		{
			get
			{
				short num = (short)1321196258;
				short num2 = num;
				num = (short)621796066;
				switch (num2 == num)
				{
				}
				num = (short)797835265;
				if (num != 0)
				{
				}
				num = (short)1792737280;
				short num3 = num;
				num = (short)2114453504;
				if (num != 0)
				{
				}
				return this.radWideGeneralASKRequired_A37152.Value;
			}
			set
			{
				short num = (short)1886050225;
				short num2 = num;
				num = (short)819058609;
				switch (num2 == num)
				{
				}
				num = (short)57212928;
				if (num != 0)
				{
				}
				num = (short)432078848;
				short num3 = num;
				num = (short)1831206913;
				if (num != 0)
				{
				}
				this.radWideGeneralASKRequired_A37152.Value = value;
			}
		}

		// Token: 0x17001A92 RID: 6802
		// (get) Token: 0x06003492 RID: 13458 RVA: 0x00327C34 File Offset: 0x00325E34
		public global::AcpBusinessLayer.AcpField<bool> RadWideGeneralASKRequired_A37152
		{
			get
			{
				short num = (short)581061031;
				short num2 = num;
				num = (short)945572263;
				switch (num2 == num)
				{
				}
				num = (short)2029125633;
				if (num != 0)
				{
				}
				num = (short)2026307584;
				short num3 = num;
				num = (short)1370488832;
				if (num != 0)
				{
				}
				return this.radWideGeneralASKRequired_A37152;
			}
		}

		// Token: 0x17001A93 RID: 6803
		// (get) Token: 0x06003493 RID: 13459 RVA: 0x00327CE4 File Offset: 0x00325EE4
		// (set) Token: 0x06003494 RID: 13460 RVA: 0x00327D9C File Offset: 0x00325F9C
		public bool RadWideGeneralASKRequired_A37152_UIValue
		{
			get
			{
				short num = (short)899235720;
				short num2 = num;
				num = (short)290471816;
				switch (num2 == num)
				{
				}
				num = (short)677576704;
				if (num != 0)
				{
				}
				num = (short)1029701632;
				short num3 = num;
				num = (short)2138243073;
				if (num != 0)
				{
				}
				return this.radWideGeneralASKRequired_A37152.Value;
			}
			set
			{
				short num = (short)1492373142;
				short num2 = num;
				num = (short)219860630;
				switch (num2 == num)
				{
				}
				num = (short)148963329;
				if (num != 0)
				{
				}
				num = (short)1456865280;
				short num3 = num;
				num = (short)66256896;
				if (num != 0)
				{
				}
				this.radWideGeneralASKRequired_A37152.Value = value;
			}
		}

		// Token: 0x17001A94 RID: 6804
		// (get) Token: 0x06003495 RID: 13461 RVA: 0x00327E50 File Offset: 0x00326050
		// (set) Token: 0x06003496 RID: 13462 RVA: 0x00327F04 File Offset: 0x00326104
		public bool RadWideGeneralASKRequired_A37152_Applicable
		{
			get
			{
				short num = (short)2131512967;
				short num2 = num;
				num = (short)1963282055;
				switch (num2 == num)
				{
				}
				num = (short)788004865;
				if (num != 0)
				{
				}
				num = (short)2034237440;
				short num3 = num;
				num = (short)556531712;
				if (num != 0)
				{
				}
				return this.radWideGeneralASKRequired_A37152.Applicable;
			}
			set
			{
				short num = (short)883627443;
				short num2 = num;
				num = (short)1044780467;
				switch (num2 == num)
				{
				}
				num = (short)1900412929;
				if (num != 0)
				{
				}
				num = (short)1954938880;
				short num3 = num;
				num = (short)45744128;
				if (num != 0)
				{
				}
				this.radWideGeneralASKRequired_A37152.Applicable = value;
			}
		}

		// Token: 0x17001A95 RID: 6805
		// (get) Token: 0x06003497 RID: 13463 RVA: 0x00327FBC File Offset: 0x003261BC
		// (set) Token: 0x06003498 RID: 13464 RVA: 0x00328070 File Offset: 0x00326270
		public bool RadWideGeneralASKRequired_A37152_Valid
		{
			get
			{
				short num = (short)1379980348;
				short num2 = num;
				num = (short)1798624316;
				switch (num2 == num)
				{
				}
				num = (short)947781633;
				if (num != 0)
				{
				}
				num = (short)1342111744;
				short num3 = num;
				num = (short)670171136;
				if (num != 0)
				{
				}
				return this.radWideGeneralASKRequired_A37152.Valid;
			}
			set
			{
				short num = (short)1899510960;
				short num2 = num;
				num = (short)604322992;
				switch (num2 == num)
				{
				}
				num = (short)1432682497;
				if (num != 0)
				{
				}
				num = (short)1094516736;
				short num3 = num;
				num = (short)1566113792;
				if (num != 0)
				{
				}
				this.radWideGeneralASKRequired_A37152.Valid = value;
			}
		}

		// Token: 0x17001A96 RID: 6806
		// (get) Token: 0x06003499 RID: 13465 RVA: 0x00328124 File Offset: 0x00326324
		// (set) Token: 0x0600349A RID: 13466 RVA: 0x003281D8 File Offset: 0x003263D8
		public bool RadWideGeneralASKRequired_A37152_Visible
		{
			get
			{
				short num = (short)273088513;
				if (num != 0)
				{
				}
				num = (short)1808966208;
				short num2 = num;
				num = (short)497394240;
				switch (num2 == num)
				{
				}
				num = (short)992608256;
				short num3 = num;
				num = (short)417857536;
				if (num != 0)
				{
				}
				return this.radWideGeneralASKRequired_A37152.Visible;
			}
			set
			{
				short num = (short)1284448568;
				short num2 = num;
				num = (short)1316561208;
				switch (num2 == num)
				{
				}
				num = (short)1933180929;
				if (num != 0)
				{
				}
				num = (short)1647050752;
				short num3 = num;
				num = (short)366936064;
				if (num != 0)
				{
				}
				this.radWideGeneralASKRequired_A37152.Visible = value;
			}
		}

		// Token: 0x17001A97 RID: 6807
		// (get) Token: 0x0600349B RID: 13467 RVA: 0x0032828C File Offset: 0x0032648C
		// (set) Token: 0x0600349C RID: 13468 RVA: 0x00328344 File Offset: 0x00326544
		public bool RadWideGeneralASKRequired_A37152_Editable
		{
			get
			{
				short num = (short)1320115066;
				short num2 = num;
				num = (short)263805818;
				switch (num2 == num)
				{
				}
				num = (short)1125318657;
				if (num != 0)
				{
				}
				num = (short)590741504;
				short num3 = num;
				num = (short)394985472;
				if (num != 0)
				{
				}
				return this.radWideGeneralASKRequired_A37152.Editable;
			}
			set
			{
				short num = (short)1031929857;
				if (num != 0)
				{
				}
				num = (short)612337669;
				short num2 = num;
				num = (short)80578565;
				switch (num2 == num)
				{
				}
				num = (short)1072824320;
				short num3 = num;
				num = (short)434176000;
				if (num != 0)
				{
				}
				this.radWideGeneralASKRequired_A37152.Editable = value;
			}
		}

		// Token: 0x17001A98 RID: 6808
		// (get) Token: 0x0600349D RID: 13469 RVA: 0x003283FC File Offset: 0x003265FC
		internal string RadWideGeneralASKRequired_A37152_UILabel
		{
			get
			{
				short num = (short)1478132477;
				short num2 = num;
				num = (short)1895596797;
				switch (num2 == num)
				{
				}
				num = (short)231997440;
				if (num != 0)
				{
				}
				num = (short)1434451968;
				short num3 = num;
				num = (short)401539073;
				if (num != 0)
				{
				}
				return this.radWideGeneralASKRequired_A37152.UIName;
			}
		}

		// Token: 0x17001A99 RID: 6809
		// (get) Token: 0x0600349E RID: 13470 RVA: 0x003284B0 File Offset: 0x003266B0
		// (set) Token: 0x0600349F RID: 13471 RVA: 0x00328568 File Offset: 0x00326768
		internal bool RadWideGeneralASKRequired_A37152_HiddenStatic
		{
			get
			{
				short num = (short)1650824469;
				short num2 = num;
				num = (short)962237717;
				switch (num2 == num)
				{
				}
				num = (short)432996353;
				if (num != 0)
				{
				}
				num = (short)487391232;
				short num3 = num;
				num = (short)819068928;
				if (num != 0)
				{
				}
				return this.radWideGeneralASKRequired_A37152.HiddenStatic;
			}
			set
			{
				short num = (short)2022091636;
				short num2 = num;
				num = (short)849587060;
				switch (num2 == num)
				{
				}
				num = (short)662044673;
				if (num != 0)
				{
				}
				num = (short)1850277888;
				short num3 = num;
				num = (short)188743680;
				if (num != 0)
				{
				}
				this.radWideGeneralASKRequired_A37152.HiddenStatic = value;
			}
		}

		// Token: 0x17001A9A RID: 6810
		// (get) Token: 0x060034A0 RID: 13472 RVA: 0x0032861C File Offset: 0x0032681C
		// (set) Token: 0x060034A1 RID: 13473 RVA: 0x003286D0 File Offset: 0x003268D0
		internal bool RadWideGeneralASKRequired_A37152_HiddenDynamic
		{
			get
			{
				short num = (short)123273918;
				short num2 = num;
				num = (short)1452933822;
				switch (num2 == num)
				{
				}
				num = (short)1939013633;
				if (num != 0)
				{
				}
				num = (short)2101018624;
				short num3 = num;
				num = (short)2120876032;
				if (num != 0)
				{
				}
				return this.radWideGeneralASKRequired_A37152.HiddenDynamic;
			}
			set
			{
				short num = (short)757973185;
				short num2 = num;
				num = (short)1952563393;
				switch (num2 == num)
				{
				}
				num = (short)2040791040;
				if (num != 0)
				{
				}
				num = (short)498991104;
				short num3 = num;
				num = (short)262602753;
				if (num != 0)
				{
				}
				this.radWideGeneralASKRequired_A37152.HiddenDynamic = value;
			}
		}

		// Token: 0x17001A9B RID: 6811
		// (get) Token: 0x060034A2 RID: 13474 RVA: 0x00328784 File Offset: 0x00326984
		public bool RadWideGeneralASKRequired_A37152_HasDiffs
		{
			get
			{
				short num = (short)803980648;
				short num2 = num;
				num = (short)506053992;
				switch (num2 == num)
				{
				}
				num = (short)2097807361;
				if (num != 0)
				{
				}
				num = (short)1012400128;
				short num3 = num;
				num = (short)1944453120;
				if (num != 0)
				{
				}
				return this.radWideGeneralASKRequired_A37152._HasDiffs;
			}
		}

		// Token: 0x17001A9C RID: 6812
		// (get) Token: 0x060034A3 RID: 13475 RVA: 0x0032883C File Offset: 0x00326A3C
		// (set) Token: 0x060034A4 RID: 13476 RVA: 0x003288F4 File Offset: 0x00326AF4
		public int RadWideGeneralOwnerSystemID_A37153Value
		{
			get
			{
				short num = (short)185737435;
				short num2 = num;
				num = (short)1098457307;
				switch (num2 == num)
				{
				}
				num = (short)702087169;
				if (num != 0)
				{
				}
				num = (short)1015676928;
				short num3 = num;
				num = (short)1045037056;
				if (num != 0)
				{
				}
				return this.radWideGeneralOwnerSystemID_A37153.Value;
			}
			set
			{
				short num = (short)1533895532;
				short num2 = num;
				num = (short)772432748;
				switch (num2 == num)
				{
				}
				num = (short)116785152;
				if (num != 0)
				{
				}
				num = (short)1572339712;
				short num3 = num;
				num = (short)770965505;
				if (num != 0)
				{
				}
				this.radWideGeneralOwnerSystemID_A37153.Value = value;
			}
		}

		// Token: 0x17001A9D RID: 6813
		// (get) Token: 0x060034A5 RID: 13477 RVA: 0x003289A8 File Offset: 0x00326BA8
		public global::AcpBusinessLayer.AcpSimpleRangeField RadWideGeneralOwnerSystemID_A37153
		{
			get
			{
				short num = (short)581626087;
				short num2 = num;
				num = (short)369158375;
				switch (num2 == num)
				{
				}
				num = (short)1425670145;
				if (num != 0)
				{
				}
				num = (short)1076690944;
				short num3 = num;
				num = (short)1117847552;
				if (num != 0)
				{
				}
				return this.radWideGeneralOwnerSystemID_A37153;
			}
		}

		// Token: 0x17001A9E RID: 6814
		// (get) Token: 0x060034A6 RID: 13478 RVA: 0x00328A58 File Offset: 0x00326C58
		// (set) Token: 0x060034A7 RID: 13479 RVA: 0x00328B0C File Offset: 0x00326D0C
		public string RadWideGeneralOwnerSystemID_A37153_UIValue
		{
			get
			{
				short num = (short)572588033;
				if (num != 0)
				{
				}
				num = (short)1251474496;
				short num2 = num;
				num = (short)1888549952;
				switch (num2 == num)
				{
				}
				num = (short)560857088;
				short num3 = num;
				num = (short)833552384;
				if (num != 0)
				{
				}
				return this.radWideGeneralOwnerSystemID_A37153.UIValue;
			}
			set
			{
				short num = (short)917827761;
				short num2 = num;
				num = (short)27717809;
				switch (num2 == num)
				{
				}
				num = (short)1831927808;
				if (num != 0)
				{
				}
				num = (short)1581252608;
				short num3 = num;
				num = (short)2115960833;
				if (num != 0)
				{
				}
				this.radWideGeneralOwnerSystemID_A37153.UIValue = value;
			}
		}

		// Token: 0x17001A9F RID: 6815
		// (get) Token: 0x060034A8 RID: 13480 RVA: 0x00328BC4 File Offset: 0x00326DC4
		// (set) Token: 0x060034A9 RID: 13481 RVA: 0x00328C78 File Offset: 0x00326E78
		public string RadWideGeneralOwnerSystemID_A37153_HexUIValue
		{
			get
			{
				short num = (short)1949057689;
				short num2 = num;
				num = (short)313410201;
				switch (num2 == num)
				{
				}
				num = (short)605552641;
				if (num != 0)
				{
				}
				num = (short)968949760;
				short num3 = num;
				num = (short)1143799808;
				if (num != 0)
				{
				}
				return this.radWideGeneralOwnerSystemID_A37153.HexUIValue;
			}
			set
			{
				short num = (short)62193665;
				if (num != 0)
				{
				}
				num = (short)351020649;
				short num2 = num;
				num = (short)695805545;
				switch (num2 == num)
				{
				}
				num = (short)897581056;
				short num3 = num;
				num = (short)1818361856;
				if (num != 0)
				{
				}
				this.radWideGeneralOwnerSystemID_A37153.HexUIValue = value;
			}
		}

		// Token: 0x17001AA0 RID: 6816
		// (get) Token: 0x060034AA RID: 13482 RVA: 0x00328D2C File Offset: 0x00326F2C
		// (set) Token: 0x060034AB RID: 13483 RVA: 0x00328DE4 File Offset: 0x00326FE4
		internal int RadWideGeneralOwnerSystemID_A37153Min
		{
			get
			{
				short num = (short)184287232;
				short num2 = num;
				num = (short)1401074187;
				short num3 = num;
				num = (short)255373835;
				switch (num3 == num)
				{
				}
				num = (short)1448280065;
				if (num != 0)
				{
				}
				num = (short)210501632;
				if (num != 0)
				{
				}
				return this.radWideGeneralOwnerSystemID_A37153.Min;
			}
			set
			{
				short num = (short)1662451712;
				short num2 = num;
				num = (short)971179203;
				short num3 = num;
				num = (short)1075446979;
				switch (num3 == num)
				{
				}
				num = (short)955383808;
				if (num != 0)
				{
				}
				num = (short)1073676289;
				if (num != 0)
				{
				}
				this.radWideGeneralOwnerSystemID_A37153.Min = value;
			}
		}

		// Token: 0x17001AA1 RID: 6817
		// (get) Token: 0x060034AC RID: 13484 RVA: 0x00328E98 File Offset: 0x00327098
		// (set) Token: 0x060034AD RID: 13485 RVA: 0x00328F50 File Offset: 0x00327150
		internal int RadWideGeneralOwnerSystemID_A37153Max
		{
			get
			{
				short num = (short)165412864;
				short num2 = num;
				num = (short)354953907;
				short num3 = num;
				num = (short)249768627;
				switch (num3 == num)
				{
				}
				num = (short)1572405249;
				if (num != 0)
				{
				}
				num = (short)339214336;
				if (num != 0)
				{
				}
				return this.radWideGeneralOwnerSystemID_A37153.Max;
			}
			set
			{
				short num = (short)2044985344;
				short num2 = num;
				num = (short)1381185711;
				short num3 = num;
				num = (short)1963145391;
				switch (num3 == num)
				{
				}
				num = (short)1450049537;
				if (num != 0)
				{
				}
				num = (short)2082603008;
				if (num != 0)
				{
				}
				this.radWideGeneralOwnerSystemID_A37153.Max = value;
			}
		}

		// Token: 0x17001AA2 RID: 6818
		// (get) Token: 0x060034AE RID: 13486 RVA: 0x00329008 File Offset: 0x00327208
		// (set) Token: 0x060034AF RID: 13487 RVA: 0x003290C0 File Offset: 0x003272C0
		internal int RadWideGeneralOwnerSystemID_A37153Step
		{
			get
			{
				short num = (short)2125791232;
				short num2 = num;
				num = (short)1048926274;
				short num3 = num;
				num = (short)1448630338;
				switch (num3 == num)
				{
				}
				num = (short)1051983872;
				if (num != 0)
				{
				}
				num = (short)568590337;
				if (num != 0)
				{
				}
				return this.radWideGeneralOwnerSystemID_A37153.StepSize;
			}
			set
			{
				short num = (short)1486422016;
				short num2 = num;
				num = (short)698556089;
				short num3 = num;
				num = (short)985407161;
				switch (num3 == num)
				{
				}
				num = (short)1871577089;
				if (num != 0)
				{
				}
				num = (short)2124283904;
				if (num != 0)
				{
				}
				this.radWideGeneralOwnerSystemID_A37153.StepSize = value;
			}
		}

		// Token: 0x17001AA3 RID: 6819
		// (get) Token: 0x060034B0 RID: 13488 RVA: 0x00329174 File Offset: 0x00327374
		// (set) Token: 0x060034B1 RID: 13489 RVA: 0x00329228 File Offset: 0x00327428
		public bool RadWideGeneralOwnerSystemID_A37153_Applicable
		{
			get
			{
				short num = (short)2047737856;
				short num2 = num;
				num = (short)518062081;
				if (num != 0)
				{
				}
				num = (short)658329043;
				short num3 = num;
				num = (short)1836338643;
				switch (num3 == num)
				{
				}
				num = (short)1467285504;
				if (num != 0)
				{
				}
				return this.radWideGeneralOwnerSystemID_A37153.Applicable;
			}
			set
			{
				short num = (short)268369920;
				short num2 = num;
				num = (short)10893459;
				short num3 = num;
				num = (short)1917335699;
				switch (num3 == num)
				{
				}
				num = (short)1742209024;
				if (num != 0)
				{
				}
				num = (short)855900161;
				if (num != 0)
				{
				}
				this.radWideGeneralOwnerSystemID_A37153.Applicable = value;
			}
		}

		// Token: 0x17001AA4 RID: 6820
		// (get) Token: 0x060034B2 RID: 13490 RVA: 0x003292E0 File Offset: 0x003274E0
		// (set) Token: 0x060034B3 RID: 13491 RVA: 0x00329398 File Offset: 0x00327598
		public bool RadWideGeneralOwnerSystemID_A37153_Valid
		{
			get
			{
				short num = (short)629669888;
				short num2 = num;
				num = (short)27328513;
				if (num != 0)
				{
				}
				num = (short)898596255;
				short num3 = num;
				num = (short)1041726879;
				switch (num3 == num)
				{
				}
				num = (short)1560674304;
				if (num != 0)
				{
				}
				return this.radWideGeneralOwnerSystemID_A37153.Valid;
			}
			set
			{
				short num = (short)1947009024;
				short num2 = num;
				num = (short)1421122317;
				short num3 = num;
				num = (short)779590413;
				switch (num3 == num)
				{
				}
				num = (short)953417728;
				if (num != 0)
				{
				}
				num = (short)1014628353;
				if (num != 0)
				{
				}
				this.radWideGeneralOwnerSystemID_A37153.Valid = value;
			}
		}

		// Token: 0x17001AA5 RID: 6821
		// (get) Token: 0x060034B4 RID: 13492 RVA: 0x00329450 File Offset: 0x00327650
		// (set) Token: 0x060034B5 RID: 13493 RVA: 0x00329504 File Offset: 0x00327704
		public bool RadWideGeneralOwnerSystemID_A37153_Visible
		{
			get
			{
				short num = (short)1079836672;
				short num2 = num;
				num = (short)366411777;
				if (num != 0)
				{
				}
				num = (short)2117926057;
				short num3 = num;
				num = (short)199687337;
				switch (num3 == num)
				{
				}
				num = (short)590610432;
				if (num != 0)
				{
				}
				return this.radWideGeneralOwnerSystemID_A37153.Visible;
			}
			set
			{
				short num = (short)1512833024;
				short num2 = num;
				num = (short)620361231;
				short num3 = num;
				num = (short)88274447;
				switch (num3 == num)
				{
				}
				num = (short)1288241152;
				if (num != 0)
				{
				}
				num = (short)1654521857;
				if (num != 0)
				{
				}
				this.radWideGeneralOwnerSystemID_A37153.Visible = value;
			}
		}

		// Token: 0x17001AA6 RID: 6822
		// (get) Token: 0x060034B6 RID: 13494 RVA: 0x003295B8 File Offset: 0x003277B8
		// (set) Token: 0x060034B7 RID: 13495 RVA: 0x0032966C File Offset: 0x0032786C
		public bool RadWideGeneralOwnerSystemID_A37153_Editable
		{
			get
			{
				short num = (short)1711865856;
				short num2 = num;
				num = (short)735216582;
				short num3 = num;
				num = (short)1923449798;
				switch (num3 == num)
				{
				}
				num = (short)1138229249;
				if (num != 0)
				{
				}
				num = (short)231997440;
				if (num != 0)
				{
				}
				return this.radWideGeneralOwnerSystemID_A37153.Editable;
			}
			set
			{
				short num = (short)480903168;
				short num2 = num;
				num = (short)1773484261;
				short num3 = num;
				num = (short)382023909;
				switch (num3 == num)
				{
				}
				num = (short)2001862657;
				if (num != 0)
				{
				}
				num = (short)1984430080;
				if (num != 0)
				{
				}
				this.radWideGeneralOwnerSystemID_A37153.Editable = value;
			}
		}

		// Token: 0x17001AA7 RID: 6823
		// (get) Token: 0x060034B8 RID: 13496 RVA: 0x00329724 File Offset: 0x00327924
		internal string RadWideGeneralOwnerSystemID_A37153_UILabel
		{
			get
			{
				short num = (short)1297022976;
				short num2 = num;
				num = (short)120155145;
				short num3 = num;
				num = (short)1688431625;
				switch (num3 == num)
				{
				}
				num = (short)1167589377;
				if (num != 0)
				{
				}
				num = (short)1557790720;
				if (num != 0)
				{
				}
				return this.radWideGeneralOwnerSystemID_A37153.UIName;
			}
		}

		// Token: 0x17001AA8 RID: 6824
		// (get) Token: 0x060034B9 RID: 13497 RVA: 0x003297D8 File Offset: 0x003279D8
		// (set) Token: 0x060034BA RID: 13498 RVA: 0x00329890 File Offset: 0x00327A90
		internal bool RadWideGeneralOwnerSystemID_A37153_HiddenStatic
		{
			get
			{
				short num = (short)1751252992;
				short num2 = num;
				num = (short)2139142320;
				short num3 = num;
				num = (short)572897456;
				switch (num3 == num)
				{
				}
				num = (short)42795009;
				if (num != 0)
				{
				}
				num = (short)966852608;
				if (num != 0)
				{
				}
				return this.radWideGeneralOwnerSystemID_A37153.HiddenStatic;
			}
			set
			{
				short num = (short)39583744;
				short num2 = num;
				num = (short)952746775;
				short num3 = num;
				num = (short)373867287;
				switch (num3 == num)
				{
				}
				num = (short)1128857600;
				if (num != 0)
				{
				}
				num = (short)736952321;
				if (num != 0)
				{
				}
				this.radWideGeneralOwnerSystemID_A37153.HiddenStatic = value;
			}
		}

		// Token: 0x17001AA9 RID: 6825
		// (get) Token: 0x060034BB RID: 13499 RVA: 0x00329944 File Offset: 0x00327B44
		// (set) Token: 0x060034BC RID: 13500 RVA: 0x003299F8 File Offset: 0x00327BF8
		internal bool RadWideGeneralOwnerSystemID_A37153_HiddenDynamic
		{
			get
			{
				short num = (short)1823080448;
				short num2 = num;
				num = (short)1238845500;
				short num3 = num;
				num = (short)2130659388;
				switch (num3 == num)
				{
				}
				num = (short)1795489793;
				if (num != 0)
				{
				}
				num = (short)1218576384;
				if (num != 0)
				{
				}
				return this.radWideGeneralOwnerSystemID_A37153.HiddenDynamic;
			}
			set
			{
				short num = (short)1102905344;
				short num2 = num;
				num = (short)1522757467;
				short num3 = num;
				num = (short)1245540187;
				switch (num3 == num)
				{
				}
				num = (short)338821120;
				if (num != 0)
				{
				}
				num = (short)775749633;
				if (num != 0)
				{
				}
				this.radWideGeneralOwnerSystemID_A37153.HiddenDynamic = value;
			}
		}

		// Token: 0x17001AAA RID: 6826
		// (get) Token: 0x060034BD RID: 13501 RVA: 0x00329AAC File Offset: 0x00327CAC
		public bool RadWideGeneralOwnerSystemID_A37153_HasDiffs
		{
			get
			{
				short num = (short)2075983872;
				short num2 = num;
				num = (short)272457421;
				short num3 = num;
				num = (short)1680105165;
				switch (num3 == num)
				{
				}
				num = (short)254607360;
				if (num != 0)
				{
				}
				num = (short)1410203649;
				if (num != 0)
				{
				}
				return this.radWideGeneralOwnerSystemID_A37153._HasDiffs;
			}
		}

		// Token: 0x17001AAB RID: 6827
		// (get) Token: 0x060034BE RID: 13502 RVA: 0x00329B64 File Offset: 0x00327D64
		// (set) Token: 0x060034BF RID: 13503 RVA: 0x00329C18 File Offset: 0x00327E18
		public int RadWideGeneralOwnerWACNID_A38656Value
		{
			get
			{
				short num = (short)84606976;
				short num2 = num;
				num = (short)1153957889;
				if (num != 0)
				{
				}
				num = (short)1291672848;
				short num3 = num;
				num = (short)860970256;
				switch (num3 == num)
				{
				}
				num = (short)302514176;
				if (num != 0)
				{
				}
				return this.radWideGeneralOwnerWACNID_A38656.Value;
			}
			set
			{
				short num = (short)1135804416;
				short num2 = num;
				num = (short)1659109377;
				if (num != 0)
				{
				}
				num = (short)787246182;
				short num3 = num;
				num = (short)513829990;
				switch (num3 == num)
				{
				}
				num = (short)1975189504;
				if (num != 0)
				{
				}
				this.radWideGeneralOwnerWACNID_A38656.Value = value;
			}
		}

		// Token: 0x17001AAC RID: 6828
		// (get) Token: 0x060034C0 RID: 13504 RVA: 0x00329CD0 File Offset: 0x00327ED0
		public global::AcpBusinessLayer.AcpSimpleRangeField RadWideGeneralOwnerWACNID_A38656
		{
			get
			{
				short num = (short)1946025984;
				short num2 = num;
				num = (short)1090099682;
				short num3 = num;
				num = (short)1312397794;
				switch (num3 == num)
				{
				}
				num = (short)434896897;
				if (num != 0)
				{
				}
				num = (short)1443561472;
				if (num != 0)
				{
				}
				return this.radWideGeneralOwnerWACNID_A38656;
			}
		}

		// Token: 0x17001AAD RID: 6829
		// (get) Token: 0x060034C1 RID: 13505 RVA: 0x00329D80 File Offset: 0x00327F80
		// (set) Token: 0x060034C2 RID: 13506 RVA: 0x00329E38 File Offset: 0x00328038
		public string RadWideGeneralOwnerWACNID_A38656_UIValue
		{
			get
			{
				short num = (short)1354563584;
				short num2 = num;
				num = (short)1276370146;
				short num3 = num;
				num = (short)256892130;
				switch (num3 == num)
				{
				}
				num = (short)603389953;
				if (num != 0)
				{
				}
				num = (short)896401408;
				if (num != 0)
				{
				}
				return this.radWideGeneralOwnerWACNID_A38656.UIValue;
			}
			set
			{
				short num = (short)1844314112;
				short num2 = num;
				num = (short)1701702413;
				short num3 = num;
				num = (short)1531702029;
				switch (num3 == num)
				{
				}
				num = (short)1320288256;
				if (num != 0)
				{
				}
				num = (short)67174401;
				if (num != 0)
				{
				}
				this.radWideGeneralOwnerWACNID_A38656.UIValue = value;
			}
		}

		// Token: 0x17001AAE RID: 6830
		// (get) Token: 0x060034C3 RID: 13507 RVA: 0x00329EF0 File Offset: 0x003280F0
		// (set) Token: 0x060034C4 RID: 13508 RVA: 0x00329FA4 File Offset: 0x003281A4
		public string RadWideGeneralOwnerWACNID_A38656_HexUIValue
		{
			get
			{
				short num = (short)1239678976;
				short num2 = num;
				num = (short)1434058753;
				if (num != 0)
				{
				}
				num = (short)2012074902;
				short num3 = num;
				num = (short)1159451542;
				switch (num3 == num)
				{
				}
				num = (short)1089732608;
				if (num != 0)
				{
				}
				return this.radWideGeneralOwnerWACNID_A38656.HexUIValue;
			}
			set
			{
				short num = (short)116850688;
				short num2 = num;
				num = (short)359089980;
				short num3 = num;
				num = (short)1191855932;
				switch (num3 == num)
				{
				}
				num = (short)1053491201;
				if (num != 0)
				{
				}
				num = (short)1917714432;
				if (num != 0)
				{
				}
				this.radWideGeneralOwnerWACNID_A38656.HexUIValue = value;
			}
		}

		// Token: 0x17001AAF RID: 6831
		// (get) Token: 0x060034C5 RID: 13509 RVA: 0x0032A05C File Offset: 0x0032825C
		// (set) Token: 0x060034C6 RID: 13510 RVA: 0x0032A110 File Offset: 0x00328310
		internal int RadWideGeneralOwnerWACNID_A38656Min
		{
			get
			{
				short num = (short)652935168;
				short num2 = num;
				num = (short)1325949178;
				short num3 = num;
				num = (short)126116090;
				switch (num3 == num)
				{
				}
				num = (short)1014169601;
				if (num != 0)
				{
				}
				num = (short)1561460736;
				if (num != 0)
				{
				}
				return this.radWideGeneralOwnerWACNID_A38656.Min;
			}
			set
			{
				short num = (short)2122317824;
				short num2 = num;
				num = (short)1932619518;
				short num3 = num;
				num = (short)903442174;
				switch (num3 == num)
				{
				}
				num = (short)2002386944;
				if (num != 0)
				{
				}
				num = (short)696451073;
				if (num != 0)
				{
				}
				this.radWideGeneralOwnerWACNID_A38656.Min = value;
			}
		}

		// Token: 0x17001AB0 RID: 6832
		// (get) Token: 0x060034C7 RID: 13511 RVA: 0x0032A1C8 File Offset: 0x003283C8
		// (set) Token: 0x060034C8 RID: 13512 RVA: 0x0032A27C File Offset: 0x0032847C
		internal int RadWideGeneralOwnerWACNID_A38656Max
		{
			get
			{
				short num = (short)476839937;
				if (num != 0)
				{
				}
				num = (short)1023865338;
				short num2 = num;
				num = (short)1596322298;
				switch (num2 == num)
				{
				}
				num = (short)492109824;
				short num3 = num;
				num = (short)2141126656;
				if (num != 0)
				{
				}
				return this.radWideGeneralOwnerWACNID_A38656.Max;
			}
			set
			{
				short num = (short)895015793;
				short num2 = num;
				num = (short)1539365745;
				switch (num2 == num)
				{
				}
				num = (short)2110980096;
				if (num != 0)
				{
				}
				num = (short)1988624384;
				short num3 = num;
				num = (short)546832385;
				if (num != 0)
				{
				}
				this.radWideGeneralOwnerWACNID_A38656.Max = value;
			}
		}

		// Token: 0x17001AB1 RID: 6833
		// (get) Token: 0x060034C9 RID: 13513 RVA: 0x0032A334 File Offset: 0x00328534
		// (set) Token: 0x060034CA RID: 13514 RVA: 0x0032A3EC File Offset: 0x003285EC
		internal int RadWideGeneralOwnerWACNID_A38656Step
		{
			get
			{
				short num = (short)230906101;
				short num2 = num;
				num = (short)662329589;
				switch (num2 == num)
				{
				}
				num = (short)292945921;
				if (num != 0)
				{
				}
				num = (short)864550912;
				short num3 = num;
				num = (short)1174405120;
				if (num != 0)
				{
				}
				return this.radWideGeneralOwnerWACNID_A38656.StepSize;
			}
			set
			{
				short num = (short)1271463150;
				short num2 = num;
				num = (short)898825454;
				switch (num2 == num)
				{
				}
				num = (short)677511169;
				if (num != 0)
				{
				}
				num = (short)2031747072;
				short num3 = num;
				num = (short)1680146432;
				if (num != 0)
				{
				}
				this.radWideGeneralOwnerWACNID_A38656.StepSize = value;
			}
		}

		// Token: 0x17001AB2 RID: 6834
		// (get) Token: 0x060034CB RID: 13515 RVA: 0x0032A4A0 File Offset: 0x003286A0
		// (set) Token: 0x060034CC RID: 13516 RVA: 0x0032A558 File Offset: 0x00328758
		public bool RadWideGeneralOwnerWACNID_A38656_Applicable
		{
			get
			{
				short num = (short)1476896812;
				short num2 = num;
				num = (short)833857580;
				switch (num2 == num)
				{
				}
				num = (short)388497409;
				if (num != 0)
				{
				}
				num = (short)123404288;
				short num3 = num;
				num = (short)1101135872;
				if (num != 0)
				{
				}
				return this.radWideGeneralOwnerWACNID_A38656.Applicable;
			}
			set
			{
				short num = (short)176856187;
				short num2 = num;
				num = (short)502242427;
				switch (num2 == num)
				{
				}
				num = (short)1836515329;
				if (num != 0)
				{
				}
				num = (short)1783037952;
				short num3 = num;
				num = (short)215089152;
				if (num != 0)
				{
				}
				this.radWideGeneralOwnerWACNID_A38656.Applicable = value;
			}
		}

		// Token: 0x17001AB3 RID: 6835
		// (get) Token: 0x060034CD RID: 13517 RVA: 0x0032A60C File Offset: 0x0032880C
		// (set) Token: 0x060034CE RID: 13518 RVA: 0x0032A6C0 File Offset: 0x003288C0
		public bool RadWideGeneralOwnerWACNID_A38656_Valid
		{
			get
			{
				short num = (short)1840713968;
				short num2 = num;
				num = (short)2135822576;
				switch (num2 == num)
				{
				}
				num = (short)947978241;
				if (num != 0)
				{
				}
				num = (short)703856640;
				short num3 = num;
				num = (short)520683520;
				if (num != 0)
				{
				}
				return this.radWideGeneralOwnerWACNID_A38656.Valid;
			}
			set
			{
				short num = (short)1436723593;
				short num2 = num;
				num = (short)1959111049;
				switch (num2 == num)
				{
				}
				num = (short)625278977;
				if (num != 0)
				{
				}
				num = (short)225247232;
				short num3 = num;
				num = (short)148242432;
				if (num != 0)
				{
				}
				this.radWideGeneralOwnerWACNID_A38656.Valid = value;
			}
		}

		// Token: 0x17001AB4 RID: 6836
		// (get) Token: 0x060034CF RID: 13519 RVA: 0x0032A774 File Offset: 0x00328974
		// (set) Token: 0x060034D0 RID: 13520 RVA: 0x0032A828 File Offset: 0x00328A28
		public bool RadWideGeneralOwnerWACNID_A38656_Visible
		{
			get
			{
				short num = (short)471467009;
				short num2 = num;
				num = (short)11142145;
				switch (num2 == num)
				{
				}
				num = (short)1917517824;
				if (num != 0)
				{
				}
				num = (short)1667497984;
				short num3 = num;
				num = (short)2032271361;
				if (num != 0)
				{
				}
				return this.radWideGeneralOwnerWACNID_A38656.Visible;
			}
			set
			{
				short num = (short)2033142270;
				short num2 = num;
				num = (short)830949886;
				switch (num2 == num)
				{
				}
				num = (short)1178599425;
				if (num != 0)
				{
				}
				num = (short)1489502208;
				short num3 = num;
				num = (short)377815040;
				if (num != 0)
				{
				}
				this.radWideGeneralOwnerWACNID_A38656.Visible = value;
			}
		}

		// Token: 0x17001AB5 RID: 6837
		// (get) Token: 0x060034D1 RID: 13521 RVA: 0x0032A8E0 File Offset: 0x00328AE0
		// (set) Token: 0x060034D2 RID: 13522 RVA: 0x0032A998 File Offset: 0x00328B98
		public bool RadWideGeneralOwnerWACNID_A38656_Editable
		{
			get
			{
				short num = (short)1925382782;
				short num2 = num;
				num = (short)1703084670;
				switch (num2 == num)
				{
				}
				num = (short)1928003585;
				if (num != 0)
				{
				}
				num = (short)665190400;
				short num3 = num;
				num = (short)1192493056;
				if (num != 0)
				{
				}
				return this.radWideGeneralOwnerWACNID_A38656.Editable;
			}
			set
			{
				short num = (short)1374096806;
				short num2 = num;
				num = (short)1973226918;
				switch (num2 == num)
				{
				}
				num = (short)2014838785;
				if (num != 0)
				{
				}
				num = (short)1676869632;
				short num3 = num;
				num = (short)963379200;
				if (num != 0)
				{
				}
				this.radWideGeneralOwnerWACNID_A38656.Editable = value;
			}
		}

		// Token: 0x17001AB6 RID: 6838
		// (get) Token: 0x060034D3 RID: 13523 RVA: 0x0032AA50 File Offset: 0x00328C50
		internal string RadWideGeneralOwnerWACNID_A38656_UILabel
		{
			get
			{
				short num = (short)1767788402;
				short num2 = num;
				num = (short)1581076338;
				switch (num2 == num)
				{
				}
				num = (short)261226497;
				if (num != 0)
				{
				}
				num = (short)658440192;
				short num3 = num;
				num = (short)1347682304;
				if (num != 0)
				{
				}
				return this.radWideGeneralOwnerWACNID_A38656.UIName;
			}
		}

		// Token: 0x17001AB7 RID: 6839
		// (get) Token: 0x060034D4 RID: 13524 RVA: 0x0032AB04 File Offset: 0x00328D04
		// (set) Token: 0x060034D5 RID: 13525 RVA: 0x0032ABB8 File Offset: 0x00328DB8
		internal bool RadWideGeneralOwnerWACNID_A38656_HiddenStatic
		{
			get
			{
				short num = (short)159057246;
				short num2 = num;
				num = (short)52888926;
				switch (num2 == num)
				{
				}
				num = (short)1090060288;
				if (num != 0)
				{
				}
				num = (short)368115712;
				short num3 = num;
				num = (short)412024833;
				if (num != 0)
				{
				}
				return this.radWideGeneralOwnerWACNID_A38656.HiddenStatic;
			}
			set
			{
				short num = (short)1648425480;
				short num2 = num;
				num = (short)1306393096;
				switch (num2 == num)
				{
				}
				num = (short)1749876737;
				if (num != 0)
				{
				}
				num = (short)167837696;
				short num3 = num;
				num = (short)1946812416;
				if (num != 0)
				{
				}
				this.radWideGeneralOwnerWACNID_A38656.HiddenStatic = value;
			}
		}

		// Token: 0x17001AB8 RID: 6840
		// (get) Token: 0x060034D6 RID: 13526 RVA: 0x0032AC70 File Offset: 0x00328E70
		// (set) Token: 0x060034D7 RID: 13527 RVA: 0x0032AD24 File Offset: 0x00328F24
		internal bool RadWideGeneralOwnerWACNID_A38656_HiddenDynamic
		{
			get
			{
				short num = (short)1006284491;
				short num2 = num;
				num = (short)1816309451;
				switch (num2 == num)
				{
				}
				num = (short)687865857;
				if (num != 0)
				{
				}
				num = (short)1228406784;
				short num3 = num;
				num = (short)1791361024;
				if (num != 0)
				{
				}
				return this.radWideGeneralOwnerWACNID_A38656.HiddenDynamic;
			}
			set
			{
				short num = (short)650316974;
				short num2 = num;
				num = (short)1369574574;
				switch (num2 == num)
				{
				}
				num = (short)808189953;
				if (num != 0)
				{
				}
				num = (short)204537856;
				short num3 = num;
				num = (short)1450442752;
				if (num != 0)
				{
				}
				this.radWideGeneralOwnerWACNID_A38656.HiddenDynamic = value;
			}
		}

		// Token: 0x17001AB9 RID: 6841
		// (get) Token: 0x060034D8 RID: 13528 RVA: 0x0032ADD8 File Offset: 0x00328FD8
		public bool RadWideGeneralOwnerWACNID_A38656_HasDiffs
		{
			get
			{
				short num = (short)1675443451;
				short num2 = num;
				num = (short)860962043;
				switch (num2 == num)
				{
				}
				num = (short)416612353;
				if (num != 0)
				{
				}
				num = (short)1344405504;
				short num3 = num;
				num = (short)1371013120;
				if (num != 0)
				{
				}
				return this.radWideGeneralOwnerWACNID_A38656._HasDiffs;
			}
		}

		// Token: 0x17001ABA RID: 6842
		// (get) Token: 0x060034D9 RID: 13529 RVA: 0x0032AE8C File Offset: 0x0032908C
		// (set) Token: 0x060034DA RID: 13530 RVA: 0x0032AF40 File Offset: 0x00329140
		public int RadWideGeneralOwnerAdvancedKeyType_A38663Value
		{
			get
			{
				short num = (short)940477570;
				short num2 = num;
				num = (short)670403714;
				switch (num2 == num)
				{
				}
				num = (short)1613758464;
				if (num != 0)
				{
				}
				num = (short)255328256;
				short num3 = num;
				num = (short)1030488065;
				if (num != 0)
				{
				}
				return this.radWideGeneralOwnerAdvancedKeyType_A38663.Value;
			}
			set
			{
				short num = (short)65975505;
				short num2 = num;
				num = (short)53064913;
				switch (num2 == num)
				{
				}
				num = (short)946012161;
				if (num != 0)
				{
				}
				num = (short)969998336;
				short num3 = num;
				num = (short)1890648064;
				if (num != 0)
				{
				}
				this.radWideGeneralOwnerAdvancedKeyType_A38663.Value = value;
			}
		}

		// Token: 0x17001ABB RID: 6843
		// (get) Token: 0x060034DB RID: 13531 RVA: 0x0032AFF8 File Offset: 0x003291F8
		// (set) Token: 0x060034DC RID: 13532 RVA: 0x0032B0AC File Offset: 0x003292AC
		public string RadWideGeneralOwnerAdvancedKeyType_A38663_UIValue
		{
			get
			{
				short num = (short)81439419;
				short num2 = num;
				num = (short)1146989243;
				switch (num2 == num)
				{
				}
				num = (short)328663041;
				if (num != 0)
				{
				}
				num = (short)1308622848;
				short num3 = num;
				num = (short)1439105024;
				if (num != 0)
				{
				}
				return this.radWideGeneralOwnerAdvancedKeyType_A38663.UIValue;
			}
			set
			{
				short num = (short)123217360;
				short num2 = num;
				num = (short)1667769808;
				switch (num2 == num)
				{
				}
				num = (short)825753601;
				if (num != 0)
				{
				}
				num = (short)1636040704;
				short num3 = num;
				num = (short)1078460416;
				if (num != 0)
				{
				}
				this.radWideGeneralOwnerAdvancedKeyType_A38663.UIValue = value;
			}
		}

		// Token: 0x17001ABC RID: 6844
		// (get) Token: 0x060034DD RID: 13533 RVA: 0x0032B164 File Offset: 0x00329364
		public global::AcpBusinessLayer.AcpListField RadWideGeneralOwnerAdvancedKeyType_A38663
		{
			get
			{
				short num = (short)202945539;
				short num2 = num;
				num = (short)201896963;
				switch (num2 == num)
				{
				}
				num = (short)1976827904;
				if (num != 0)
				{
				}
				num = (short)228392960;
				short num3 = num;
				num = (short)898564097;
				if (num != 0)
				{
				}
				return this.radWideGeneralOwnerAdvancedKeyType_A38663;
			}
		}

		// Token: 0x17001ABD RID: 6845
		// (get) Token: 0x060034DE RID: 13534 RVA: 0x0032B214 File Offset: 0x00329414
		// (set) Token: 0x060034DF RID: 13535 RVA: 0x0032B2C8 File Offset: 0x003294C8
		public bool RadWideGeneralOwnerAdvancedKeyType_A38663_Applicable
		{
			get
			{
				short num = (short)157450582;
				short num2 = num;
				num = (short)476217686;
				switch (num2 == num)
				{
				}
				num = (short)1740177408;
				if (num != 0)
				{
				}
				num = (short)1566441472;
				short num3 = num;
				num = (short)1239875585;
				if (num != 0)
				{
				}
				return this.radWideGeneralOwnerAdvancedKeyType_A38663.Applicable;
			}
			set
			{
				short num = (short)912712652;
				short num2 = num;
				num = (short)1550246860;
				switch (num2 == num)
				{
				}
				num = (short)1580990465;
				if (num != 0)
				{
				}
				num = (short)1472069632;
				short num3 = num;
				num = (short)774307840;
				if (num != 0)
				{
				}
				this.radWideGeneralOwnerAdvancedKeyType_A38663.Applicable = value;
			}
		}

		// Token: 0x17001ABE RID: 6846
		// (get) Token: 0x060034E0 RID: 13536 RVA: 0x0032B380 File Offset: 0x00329580
		// (set) Token: 0x060034E1 RID: 13537 RVA: 0x0032B434 File Offset: 0x00329634
		public bool RadWideGeneralOwnerAdvancedKeyType_A38663_Valid
		{
			get
			{
				short num = (short)373948417;
				if (num != 0)
				{
				}
				num = (short)374786392;
				short num2 = num;
				num = (short)1203751256;
				switch (num2 == num)
				{
				}
				num = (short)1617756160;
				short num3 = num;
				num = (short)251461632;
				if (num != 0)
				{
				}
				return this.radWideGeneralOwnerAdvancedKeyType_A38663.Valid;
			}
			set
			{
				short num = (short)1654343076;
				short num2 = num;
				num = (short)214517156;
				switch (num2 == num)
				{
				}
				num = (short)1453260801;
				if (num != 0)
				{
				}
				num = (short)663027712;
				short num3 = num;
				num = (short)961150976;
				if (num != 0)
				{
				}
				this.radWideGeneralOwnerAdvancedKeyType_A38663.Valid = value;
			}
		}

		// Token: 0x17001ABF RID: 6847
		// (get) Token: 0x060034E2 RID: 13538 RVA: 0x0032B4E8 File Offset: 0x003296E8
		// (set) Token: 0x060034E3 RID: 13539 RVA: 0x0032B598 File Offset: 0x00329798
		public bool RadWideGeneralOwnerAdvancedKeyType_A38663_Visible
		{
			get
			{
				short num = (short)733178593;
				short num2 = num;
				num = (short)1027042017;
				switch (num2 == num)
				{
				}
				num = (short)1596653569;
				if (num != 0)
				{
				}
				num = (short)1771175936;
				short num3 = num;
				num = (short)36306944;
				if (num != 0)
				{
				}
				return this.radWideGeneralOwnerAdvancedKeyType_A38663.Visible;
			}
			set
			{
				short num = (short)587484624;
				short num2 = num;
				num = (short)1428180432;
				switch (num2 == num)
				{
				}
				num = (short)419299328;
				if (num != 0)
				{
				}
				num = (short)1772486656;
				short num3 = num;
				num = (short)2115436545;
				if (num != 0)
				{
				}
				this.radWideGeneralOwnerAdvancedKeyType_A38663.Visible = value;
			}
		}

		// Token: 0x17001AC0 RID: 6848
		// (get) Token: 0x060034E4 RID: 13540 RVA: 0x0032B64C File Offset: 0x0032984C
		// (set) Token: 0x060034E5 RID: 13541 RVA: 0x0032B6FC File Offset: 0x003298FC
		public bool RadWideGeneralOwnerAdvancedKeyType_A38663_Editable
		{
			get
			{
				short num = (short)116084130;
				short num2 = num;
				num = (short)960187810;
				switch (num2 == num)
				{
				}
				num = (short)333185025;
				if (num != 0)
				{
				}
				num = (short)1318322176;
				short num3 = num;
				num = (short)811991040;
				if (num != 0)
				{
				}
				return this.radWideGeneralOwnerAdvancedKeyType_A38663.Editable;
			}
			set
			{
				short num = (short)1908835500;
				short num2 = num;
				num = (short)1730512044;
				switch (num2 == num)
				{
				}
				num = (short)2024341505;
				if (num != 0)
				{
				}
				num = (short)162660352;
				short num3 = num;
				num = (short)1399193600;
				if (num != 0)
				{
				}
				this.radWideGeneralOwnerAdvancedKeyType_A38663.Editable = value;
			}
		}

		// Token: 0x17001AC1 RID: 6849
		// (get) Token: 0x060034E6 RID: 13542 RVA: 0x0032B7B0 File Offset: 0x003299B0
		internal string RadWideGeneralOwnerAdvancedKeyType_A38663_UILabel
		{
			get
			{
				short num = (short)1502467965;
				short num2 = num;
				num = (short)304011133;
				switch (num2 == num)
				{
				}
				num = (short)419692545;
				if (num != 0)
				{
				}
				num = (short)821231616;
				short num3 = num;
				num = (short)326041600;
				if (num != 0)
				{
				}
				return this.radWideGeneralOwnerAdvancedKeyType_A38663.UIName;
			}
		}

		// Token: 0x17001AC2 RID: 6850
		// (get) Token: 0x060034E7 RID: 13543 RVA: 0x0032B868 File Offset: 0x00329A68
		// (set) Token: 0x060034E8 RID: 13544 RVA: 0x0032B920 File Offset: 0x00329B20
		internal bool RadWideGeneralOwnerAdvancedKeyType_A38663_HiddenStatic
		{
			get
			{
				short num = (short)397274329;
				short num2 = num;
				num = (short)784788697;
				switch (num2 == num)
				{
				}
				num = (short)660406272;
				if (num != 0)
				{
				}
				num = (short)827129856;
				short num3 = num;
				num = (short)1912274945;
				if (num != 0)
				{
				}
				return this.radWideGeneralOwnerAdvancedKeyType_A38663.HiddenStatic;
			}
			set
			{
				short num = (short)1092077973;
				short num2 = num;
				num = (short)1648871829;
				switch (num2 == num)
				{
				}
				num = (short)1460666368;
				if (num != 0)
				{
				}
				num = (short)829685760;
				short num3 = num;
				num = (short)34340865;
				if (num != 0)
				{
				}
				this.radWideGeneralOwnerAdvancedKeyType_A38663.HiddenStatic = value;
			}
		}

		// Token: 0x17001AC3 RID: 6851
		// (get) Token: 0x060034E9 RID: 13545 RVA: 0x0032B9D8 File Offset: 0x00329BD8
		// (set) Token: 0x060034EA RID: 13546 RVA: 0x0032BA8C File Offset: 0x00329C8C
		internal bool RadWideGeneralOwnerAdvancedKeyType_A38663_HiddenDynamic
		{
			get
			{
				short num = (short)489226241;
				if (num != 0)
				{
				}
				num = (short)1717865380;
				short num2 = num;
				num = (short)1156090788;
				switch (num2 == num)
				{
				}
				num = (short)984416256;
				short num3 = num;
				num = (short)1069023232;
				if (num != 0)
				{
				}
				return this.radWideGeneralOwnerAdvancedKeyType_A38663.HiddenDynamic;
			}
			set
			{
				short num = (short)1477296028;
				short num2 = num;
				num = (short)1604698012;
				switch (num2 == num)
				{
				}
				num = (short)1080950785;
				if (num != 0)
				{
				}
				num = (short)1557331968;
				short num3 = num;
				num = (short)746455040;
				if (num != 0)
				{
				}
				this.radWideGeneralOwnerAdvancedKeyType_A38663.HiddenDynamic = value;
			}
		}

		// Token: 0x17001AC4 RID: 6852
		// (get) Token: 0x060034EB RID: 13547 RVA: 0x0032BB40 File Offset: 0x00329D40
		public bool RadWideGeneralOwnerAdvancedKeyType_A38663_HasDiffs
		{
			get
			{
				short num = (short)309502899;
				short num2 = num;
				num = (short)736797619;
				switch (num2 == num)
				{
				}
				num = (short)1210449921;
				if (num != 0)
				{
				}
				num = (short)2049245184;
				short num3 = num;
				num = (short)2138898432;
				if (num != 0)
				{
				}
				return this.radWideGeneralOwnerAdvancedKeyType_A38663._HasDiffs;
			}
		}

		// Token: 0x17001AC5 RID: 6853
		// (get) Token: 0x060034EC RID: 13548 RVA: 0x0032BBF8 File Offset: 0x00329DF8
		// (set) Token: 0x060034ED RID: 13549 RVA: 0x0032BCB0 File Offset: 0x00329EB0
		public string RadWideGeneralPskId_44840Value
		{
			get
			{
				short num = (short)838727968;
				short num2 = num;
				num = (short)525269280;
				switch (num2 == num)
				{
				}
				num = (short)2143813633;
				if (num != 0)
				{
				}
				num = (short)1098907648;
				short num3 = num;
				num = (short)1545338880;
				if (num != 0)
				{
				}
				return this.radWideGeneralPskId_44840.Value;
			}
			set
			{
				short num = (short)1690950553;
				short num2 = num;
				num = (short)1087822745;
				switch (num2 == num)
				{
				}
				num = (short)656408576;
				if (num != 0)
				{
				}
				num = (short)132513793;
				if (num != 0)
				{
				}
				num = (short)1782972416;
				short num3 = num;
				this.radWideGeneralPskId_44840.Value = value;
			}
		}

		// Token: 0x17001AC6 RID: 6854
		// (get) Token: 0x060034EE RID: 13550 RVA: 0x0032BD64 File Offset: 0x00329F64
		// (set) Token: 0x060034EF RID: 13551 RVA: 0x0032BE1C File Offset: 0x0032A01C
		public string RadWideGeneralPskId_44840_UIValue
		{
			get
			{
				short num = (short)1277624321;
				if (num != 0)
				{
				}
				num = (short)1766693993;
				short num2 = num;
				num = (short)1150131305;
				switch (num2 == num)
				{
				}
				num = (short)1551826944;
				if (num != 0)
				{
				}
				num = (short)1429143552;
				short num3 = num;
				return this.radWideGeneralPskId_44840.Value;
			}
			set
			{
				short num = (short)590610433;
				if (num != 0)
				{
				}
				num = (short)213408537;
				short num2 = num;
				num = (short)366566169;
				switch (num2 == num)
				{
				}
				num = (short)905117696;
				if (num != 0)
				{
				}
				num = (short)749010944;
				short num3 = num;
				this.radWideGeneralPskId_44840.Value = value;
			}
		}

		// Token: 0x17001AC7 RID: 6855
		// (get) Token: 0x060034F0 RID: 13552 RVA: 0x0032BED4 File Offset: 0x0032A0D4
		public global::AcpBusinessLayer.AcpStringField RadWideGeneralPskId_44840
		{
			get
			{
				short num = (short)1590362113;
				if (num != 0)
				{
				}
				num = (short)1310199591;
				short num2 = num;
				num = (short)1665732391;
				switch (num2 == num)
				{
				}
				num = (short)1589968896;
				if (num != 0)
				{
				}
				num = (short)936706048;
				short num3 = num;
				return this.radWideGeneralPskId_44840;
			}
		}

		// Token: 0x17001AC8 RID: 6856
		// (get) Token: 0x060034F1 RID: 13553 RVA: 0x0032BF84 File Offset: 0x0032A184
		// (set) Token: 0x060034F2 RID: 13554 RVA: 0x0032C038 File Offset: 0x0032A238
		public bool RadWideGeneralPskId_44840_Applicable
		{
			get
			{
				short num = (short)1249771521;
				if (num != 0)
				{
				}
				num = (short)866565910;
				short num2 = num;
				num = (short)1262075670;
				switch (num2 == num)
				{
				}
				num = (short)1249968128;
				if (num != 0)
				{
				}
				num = (short)1127940096;
				short num3 = num;
				return this.radWideGeneralPskId_44840.Applicable;
			}
			set
			{
				short num = (short)1204682302;
				short num2 = num;
				num = (short)588709438;
				switch (num2 == num)
				{
				}
				num = (short)242417664;
				if (num != 0)
				{
				}
				num = (short)1287192577;
				if (num != 0)
				{
				}
				num = (short)1001717760;
				short num3 = num;
				this.radWideGeneralPskId_44840.Applicable = value;
			}
		}

		// Token: 0x17001AC9 RID: 6857
		// (get) Token: 0x060034F3 RID: 13555 RVA: 0x0032C0F0 File Offset: 0x0032A2F0
		// (set) Token: 0x060034F4 RID: 13556 RVA: 0x0032C1A4 File Offset: 0x0032A3A4
		public bool RadWideGeneralPskId_44840_Valid
		{
			get
			{
				short num = (short)292449500;
				short num2 = num;
				num = (short)1453812956;
				switch (num2 == num)
				{
				}
				num = (short)720371713;
				if (num != 0)
				{
				}
				num = (short)1500315648;
				if (num != 0)
				{
				}
				num = (short)1527513088;
				short num3 = num;
				return this.radWideGeneralPskId_44840.Valid;
			}
			set
			{
				short num = (short)127422758;
				short num2 = num;
				num = (short)473125158;
				switch (num2 == num)
				{
				}
				num = (short)1953628161;
				if (num != 0)
				{
				}
				num = (short)195297280;
				if (num != 0)
				{
				}
				num = (short)1314193408;
				short num3 = num;
				this.radWideGeneralPskId_44840.Valid = value;
			}
		}

		// Token: 0x17001ACA RID: 6858
		// (get) Token: 0x060034F5 RID: 13557 RVA: 0x0032C258 File Offset: 0x0032A458
		// (set) Token: 0x060034F6 RID: 13558 RVA: 0x0032C30C File Offset: 0x0032A50C
		public bool RadWideGeneralPskId_44840_Visible
		{
			get
			{
				short num = (short)1816858014;
				short num2 = num;
				num = (short)1139674526;
				switch (num2 == num)
				{
				}
				num = (short)324861952;
				if (num != 0)
				{
				}
				num = (short)1135935489;
				if (num != 0)
				{
				}
				num = (short)1505230848;
				short num3 = num;
				return this.radWideGeneralPskId_44840.Visible;
			}
			set
			{
				short num = (short)1081960200;
				short num2 = num;
				num = (short)1555654408;
				switch (num2 == num)
				{
				}
				num = (short)923402241;
				if (num != 0)
				{
				}
				num = (short)181862400;
				if (num != 0)
				{
				}
				num = (short)1543110656;
				short num3 = num;
				this.radWideGeneralPskId_44840.Visible = value;
			}
		}

		// Token: 0x17001ACB RID: 6859
		// (get) Token: 0x060034F7 RID: 13559 RVA: 0x0032C3C4 File Offset: 0x0032A5C4
		// (set) Token: 0x060034F8 RID: 13560 RVA: 0x0032C478 File Offset: 0x0032A678
		public bool RadWideGeneralPskId_44840_Editable
		{
			get
			{
				short num = (short)362938369;
				if (num != 0)
				{
				}
				num = (short)584622042;
				short num2 = num;
				num = (short)800104410;
				switch (num2 == num)
				{
				}
				num = (short)1724383232;
				if (num != 0)
				{
				}
				num = (short)1545601024;
				short num3 = num;
				return this.radWideGeneralPskId_44840.Editable;
			}
			set
			{
				short num = (short)2124492310;
				short num2 = num;
				num = (short)1031876118;
				switch (num2 == num)
				{
				}
				num = (short)1905590273;
				if (num != 0)
				{
				}
				num = (short)212664320;
				if (num != 0)
				{
				}
				num = (short)1735458816;
				short num3 = num;
				this.radWideGeneralPskId_44840.Editable = value;
			}
		}

		// Token: 0x17001ACC RID: 6860
		// (get) Token: 0x060034F9 RID: 13561 RVA: 0x0032C52C File Offset: 0x0032A72C
		internal string RadWideGeneralPskId_44840_UILabel
		{
			get
			{
				short num = (short)1645019137;
				if (num != 0)
				{
				}
				num = (short)1717034590;
				short num2 = num;
				num = (short)660790878;
				switch (num2 == num)
				{
				}
				num = (short)489881600;
				if (num != 0)
				{
				}
				num = (short)937951232;
				short num3 = num;
				return this.radWideGeneralPskId_44840.UIName;
			}
		}

		// Token: 0x17001ACD RID: 6861
		// (get) Token: 0x060034FA RID: 13562 RVA: 0x0032C5E0 File Offset: 0x0032A7E0
		// (set) Token: 0x060034FB RID: 13563 RVA: 0x0032C694 File Offset: 0x0032A894
		internal bool RadWideGeneralPskId_44840_HiddenStatic
		{
			get
			{
				short num = (short)1286248090;
				short num2 = num;
				num = (short)1944491674;
				switch (num2 == num)
				{
				}
				num = (short)537657345;
				if (num != 0)
				{
				}
				num = (short)831062016;
				if (num != 0)
				{
				}
				num = (short)945029120;
				short num3 = num;
				return this.radWideGeneralPskId_44840.HiddenStatic;
			}
			set
			{
				short num = (short)1844755129;
				short num2 = num;
				num = (short)394443449;
				switch (num2 == num)
				{
				}
				num = (short)584122369;
				if (num != 0)
				{
				}
				num = (short)1340145664;
				if (num != 0)
				{
				}
				num = (short)453574656;
				short num3 = num;
				this.radWideGeneralPskId_44840.HiddenStatic = value;
			}
		}

		// Token: 0x17001ACE RID: 6862
		// (get) Token: 0x060034FC RID: 13564 RVA: 0x0032C74C File Offset: 0x0032A94C
		// (set) Token: 0x060034FD RID: 13565 RVA: 0x0032C800 File Offset: 0x0032AA00
		internal bool RadWideGeneralPskId_44840_HiddenDynamic
		{
			get
			{
				short num = (short)423275560;
				short num2 = num;
				num = (short)709078056;
				switch (num2 == num)
				{
				}
				num = (short)1229586433;
				if (num != 0)
				{
				}
				num = (short)265945088;
				if (num != 0)
				{
				}
				num = (short)1505296384;
				short num3 = num;
				return this.radWideGeneralPskId_44840.HiddenDynamic;
			}
			set
			{
				short num = (short)609666114;
				short num2 = num;
				num = (short)2138293314;
				switch (num2 == num)
				{
				}
				num = (short)741015553;
				if (num != 0)
				{
				}
				num = (short)1287585792;
				if (num != 0)
				{
				}
				num = (short)167706624;
				short num3 = num;
				this.radWideGeneralPskId_44840.HiddenDynamic = value;
			}
		}

		// Token: 0x17001ACF RID: 6863
		// (get) Token: 0x060034FE RID: 13566 RVA: 0x0032C8B8 File Offset: 0x0032AAB8
		public bool RadWideGeneralPskId_44840_HasDiffs
		{
			get
			{
				short num = (short)254725162;
				short num2 = num;
				num = (short)957467690;
				switch (num2 == num)
				{
				}
				num = (short)1092222977;
				if (num != 0)
				{
				}
				num = (short)1837236224;
				if (num != 0)
				{
				}
				num = (short)1193345024;
				short num3 = num;
				return this.radWideGeneralPskId_44840._HasDiffs;
			}
		}

		// Token: 0x17001AD0 RID: 6864
		// (get) Token: 0x060034FF RID: 13567 RVA: 0x0032C968 File Offset: 0x0032AB68
		// (set) Token: 0x06003500 RID: 13568 RVA: 0x0032CA20 File Offset: 0x0032AC20
		public string RadWideGeneralTlsPsk_44841Value
		{
			get
			{
				short num = (short)2082154349;
				short num2 = num;
				num = (short)296626029;
				switch (num2 == num)
				{
				}
				num = (short)1499856896;
				if (num != 0)
				{
				}
				num = (short)1321009153;
				if (num != 0)
				{
				}
				num = (short)39911424;
				short num3 = num;
				return this.radWideGeneralTlsPsk_44841.Value;
			}
			set
			{
				short num = (short)1225119647;
				short num2 = num;
				num = (short)1028118431;
				switch (num2 == num)
				{
				}
				num = (short)276561921;
				if (num != 0)
				{
				}
				num = (short)78839808;
				if (num != 0)
				{
				}
				num = (short)95092736;
				short num3 = num;
				this.radWideGeneralTlsPsk_44841.Value = value;
			}
		}

		// Token: 0x17001AD1 RID: 6865
		// (get) Token: 0x06003501 RID: 13569 RVA: 0x0032CAD4 File Offset: 0x0032ACD4
		// (set) Token: 0x06003502 RID: 13570 RVA: 0x0032CB88 File Offset: 0x0032AD88
		public string RadWideGeneralTlsPsk_44841_UIValue
		{
			get
			{
				short num = (short)925106177;
				if (num != 0)
				{
				}
				num = (short)531306786;
				short num2 = num;
				num = (short)1029445922;
				switch (num2 == num)
				{
				}
				num = (short)2113142784;
				if (num != 0)
				{
				}
				num = (short)663617536;
				short num3 = num;
				return this.radWideGeneralTlsPsk_44841.Value;
			}
			set
			{
				short num = (short)1101782739;
				short num2 = num;
				num = (short)339599059;
				switch (num2 == num)
				{
				}
				num = (short)605487105;
				if (num != 0)
				{
				}
				num = (short)2060124160;
				if (num != 0)
				{
				}
				num = (short)252510208;
				short num3 = num;
				this.radWideGeneralTlsPsk_44841.Value = value;
			}
		}

		// Token: 0x17001AD2 RID: 6866
		// (get) Token: 0x06003503 RID: 13571 RVA: 0x0032CC3C File Offset: 0x0032AE3C
		public global::AcpBusinessLayer.AcpStringField RadWideGeneralTlsPsk_44841
		{
			get
			{
				short num = (short)1035927553;
				if (num != 0)
				{
				}
				num = (short)1782666966;
				short num2 = num;
				num = (short)368006870;
				switch (num2 == num)
				{
				}
				num = (short)146931712;
				if (num != 0)
				{
				}
				num = (short)1635909632;
				short num3 = num;
				return this.radWideGeneralTlsPsk_44841;
			}
		}

		// Token: 0x17001AD3 RID: 6867
		// (get) Token: 0x06003504 RID: 13572 RVA: 0x0032CCEC File Offset: 0x0032AEEC
		// (set) Token: 0x06003505 RID: 13573 RVA: 0x0032CDA0 File Offset: 0x0032AFA0
		public bool RadWideGeneralTlsPsk_44841_Applicable
		{
			get
			{
				short num = (short)2048894478;
				short num2 = num;
				num = (short)1746511374;
				switch (num2 == num)
				{
				}
				num = (short)329842689;
				if (num != 0)
				{
				}
				num = (short)49152000;
				if (num != 0)
				{
				}
				num = (short)567541760;
				short num3 = num;
				return this.radWideGeneralTlsPsk_44841.Applicable;
			}
			set
			{
				short num = (short)124148664;
				short num2 = num;
				num = (short)32922552;
				switch (num2 == num)
				{
				}
				num = (short)704380929;
				if (num != 0)
				{
				}
				num = (short)1151729664;
				if (num != 0)
				{
				}
				num = (short)174325760;
				short num3 = num;
				this.radWideGeneralTlsPsk_44841.Applicable = value;
			}
		}

		// Token: 0x17001AD4 RID: 6868
		// (get) Token: 0x06003506 RID: 13574 RVA: 0x0032CE54 File Offset: 0x0032B054
		// (set) Token: 0x06003507 RID: 13575 RVA: 0x0032CF08 File Offset: 0x0032B108
		public bool RadWideGeneralTlsPsk_44841_Valid
		{
			get
			{
				short num = (short)562280030;
				short num2 = num;
				num = (short)1437513310;
				switch (num2 == num)
				{
				}
				num = (short)1153040385;
				if (num != 0)
				{
				}
				num = (short)1468596224;
				if (num != 0)
				{
				}
				num = (short)496041984;
				short num3 = num;
				return this.radWideGeneralTlsPsk_44841.Valid;
			}
			set
			{
				short num = (short)143508818;
				short num2 = num;
				num = (short)557892946;
				switch (num2 == num)
				{
				}
				num = (short)492044288;
				if (num != 0)
				{
				}
				num = (short)1447755777;
				if (num != 0)
				{
				}
				num = (short)1991311360;
				short num3 = num;
				this.radWideGeneralTlsPsk_44841.Valid = value;
			}
		}

		// Token: 0x17001AD5 RID: 6869
		// (get) Token: 0x06003508 RID: 13576 RVA: 0x0032CFC0 File Offset: 0x0032B1C0
		// (set) Token: 0x06003509 RID: 13577 RVA: 0x0032D074 File Offset: 0x0032B274
		public bool RadWideGeneralTlsPsk_44841_Visible
		{
			get
			{
				short num = (short)117713665;
				short num2 = num;
				num = (short)794503937;
				switch (num2 == num)
				{
				}
				num = (short)1537605633;
				if (num != 0)
				{
				}
				num = (short)264699904;
				if (num != 0)
				{
				}
				num = (short)1700724736;
				short num3 = num;
				return this.radWideGeneralTlsPsk_44841.Visible;
			}
			set
			{
				short num = (short)693248205;
				short num2 = num;
				num = (short)1695490253;
				switch (num2 == num)
				{
				}
				num = (short)1874853889;
				if (num != 0)
				{
				}
				num = (short)1043398656;
				if (num != 0)
				{
				}
				num = (short)1411776512;
				short num3 = num;
				this.radWideGeneralTlsPsk_44841.Visible = value;
			}
		}

		// Token: 0x17001AD6 RID: 6870
		// (get) Token: 0x0600350A RID: 13578 RVA: 0x0032D128 File Offset: 0x0032B328
		// (set) Token: 0x0600350B RID: 13579 RVA: 0x0032D1E0 File Offset: 0x0032B3E0
		public bool RadWideGeneralTlsPsk_44841_Editable
		{
			get
			{
				short num = (short)1423869405;
				short num2 = num;
				num = (short)1456178653;
				switch (num2 == num)
				{
				}
				num = (short)349896705;
				if (num != 0)
				{
				}
				num = (short)1604714496;
				if (num != 0)
				{
				}
				num = (short)1193410560;
				short num3 = num;
				return this.radWideGeneralTlsPsk_44841.Editable;
			}
			set
			{
				short num = (short)183269817;
				short num2 = num;
				num = (short)1604876729;
				switch (num2 == num)
				{
				}
				num = (short)1828847616;
				if (num != 0)
				{
				}
				num = (short)632029185;
				if (num != 0)
				{
				}
				num = (short)737804288;
				short num3 = num;
				this.radWideGeneralTlsPsk_44841.Editable = value;
			}
		}

		// Token: 0x17001AD7 RID: 6871
		// (get) Token: 0x0600350C RID: 13580 RVA: 0x0032D298 File Offset: 0x0032B498
		internal string RadWideGeneralTlsPsk_44841_UILabel
		{
			get
			{
				short num = (short)286014059;
				short num2 = num;
				num = (short)516176491;
				switch (num2 == num)
				{
				}
				num = (short)606208001;
				if (num != 0)
				{
				}
				num = (short)1621229568;
				if (num != 0)
				{
				}
				num = (short)764608512;
				short num3 = num;
				return this.radWideGeneralTlsPsk_44841.UIName;
			}
		}

		// Token: 0x17001AD8 RID: 6872
		// (get) Token: 0x0600350D RID: 13581 RVA: 0x0032D34C File Offset: 0x0032B54C
		// (set) Token: 0x0600350E RID: 13582 RVA: 0x0032D400 File Offset: 0x0032B600
		internal bool RadWideGeneralTlsPsk_44841_HiddenStatic
		{
			get
			{
				short num = (short)1726417688;
				short num2 = num;
				num = (short)1907100440;
				switch (num2 == num)
				{
				}
				num = (short)713818113;
				if (num != 0)
				{
				}
				num = (short)522911744;
				if (num != 0)
				{
				}
				num = (short)1518600192;
				short num3 = num;
				return this.radWideGeneralTlsPsk_44841.HiddenStatic;
			}
			set
			{
				short num = (short)1540035470;
				short num2 = num;
				num = (short)205198222;
				switch (num2 == num)
				{
				}
				num = (short)1981939713;
				if (num != 0)
				{
				}
				num = (short)413990912;
				if (num != 0)
				{
				}
				num = (short)1160380416;
				short num3 = num;
				this.radWideGeneralTlsPsk_44841.HiddenStatic = value;
			}
		}

		// Token: 0x17001AD9 RID: 6873
		// (get) Token: 0x0600350F RID: 13583 RVA: 0x0032D4B8 File Offset: 0x0032B6B8
		// (set) Token: 0x06003510 RID: 13584 RVA: 0x0032D568 File Offset: 0x0032B768
		internal bool RadWideGeneralTlsPsk_44841_HiddenDynamic
		{
			get
			{
				short num = (short)768041314;
				short num2 = num;
				num = (short)392061282;
				switch (num2 == num)
				{
				}
				num = (short)2090598401;
				if (num != 0)
				{
				}
				num = (short)1096810496;
				if (num != 0)
				{
				}
				num = (short)527368192;
				short num3 = num;
				return this.radWideGeneralTlsPsk_44841.HiddenDynamic;
			}
			set
			{
				short num = (short)2088693785;
				short num2 = num;
				num = (short)606728217;
				switch (num2 == num)
				{
				}
				num = (short)1818230784;
				if (num != 0)
				{
				}
				num = (short)2102460417;
				if (num != 0)
				{
				}
				num = (short)1412300800;
				short num3 = num;
				this.radWideGeneralTlsPsk_44841.HiddenDynamic = value;
			}
		}

		// Token: 0x17001ADA RID: 6874
		// (get) Token: 0x06003511 RID: 13585 RVA: 0x0032D620 File Offset: 0x0032B820
		public bool RadWideGeneralTlsPsk_44841_HasDiffs
		{
			get
			{
				short num = (short)177166776;
				short num2 = num;
				num = (short)752507320;
				switch (num2 == num)
				{
				}
				num = (short)1598423041;
				if (num != 0)
				{
				}
				num = (short)1524563968;
				if (num != 0)
				{
				}
				num = (short)215023616;
				short num3 = num;
				return this.radWideGeneralTlsPsk_44841._HasDiffs;
			}
		}

		// Token: 0x17001ADB RID: 6875
		// (get) Token: 0x06003512 RID: 13586 RVA: 0x0032D6D4 File Offset: 0x0032B8D4
		// (set) Token: 0x06003513 RID: 13587 RVA: 0x0032D788 File Offset: 0x0032B988
		public int RadWideGeneralTlsPskPort_44842Value
		{
			get
			{
				short num = (short)872848276;
				short num2 = num;
				num = (short)1145150356;
				switch (num2 == num)
				{
				}
				num = (short)254869505;
				if (num != 0)
				{
				}
				num = (short)1652031488;
				if (num != 0)
				{
				}
				num = (short)1335033856;
				short num3 = num;
				return this.radWideGeneralTlsPskPort_44842.Value;
			}
			set
			{
				short num = (short)154232505;
				short num2 = num;
				num = (short)938895033;
				switch (num2 == num)
				{
				}
				num = (short)950272001;
				if (num != 0)
				{
				}
				num = (short)653721600;
				if (num != 0)
				{
				}
				num = (short)2060910592;
				short num3 = num;
				this.radWideGeneralTlsPskPort_44842.Value = value;
			}
		}

		// Token: 0x17001ADC RID: 6876
		// (get) Token: 0x06003514 RID: 13588 RVA: 0x0032D840 File Offset: 0x0032BA40
		// (set) Token: 0x06003515 RID: 13589 RVA: 0x0032D8F4 File Offset: 0x0032BAF4
		public int RadWideGeneralTlsPskPort_44842_UIValue
		{
			get
			{
				short num = (short)1565308356;
				short num2 = num;
				num = (short)1795929540;
				switch (num2 == num)
				{
				}
				num = (short)1672347648;
				if (num != 0)
				{
				}
				num = (short)971571201;
				if (num != 0)
				{
				}
				num = (short)1240858624;
				short num3 = num;
				return this.radWideGeneralTlsPskPort_44842.Value;
			}
			set
			{
				short num = (short)936711289;
				short num2 = num;
				num = (short)639374457;
				switch (num2 == num)
				{
				}
				num = (short)1001783296;
				if (num != 0)
				{
				}
				num = (short)899547137;
				if (num != 0)
				{
				}
				num = (short)484704256;
				short num3 = num;
				this.radWideGeneralTlsPskPort_44842.Value = value;
			}
		}

		// Token: 0x17001ADD RID: 6877
		// (get) Token: 0x06003516 RID: 13590 RVA: 0x0032D9AC File Offset: 0x0032BBAC
		public global::AcpBusinessLayer.AcpSimpleRangeField RadWideGeneralTlsPskPort_44842
		{
			get
			{
				short num = (short)362910374;
				short num2 = num;
				num = (short)2078773926;
				switch (num2 == num)
				{
				}
				num = (short)1495334912;
				if (num != 0)
				{
				}
				num = (short)1407713281;
				if (num != 0)
				{
				}
				num = (short)1740308480;
				short num3 = num;
				return this.radWideGeneralTlsPskPort_44842;
			}
		}

		// Token: 0x17001ADE RID: 6878
		// (get) Token: 0x06003517 RID: 13591 RVA: 0x0032DA5C File Offset: 0x0032BC5C
		// (set) Token: 0x06003518 RID: 13592 RVA: 0x0032DB14 File Offset: 0x0032BD14
		internal int RadWideGeneralTlsPskPort_44842Min
		{
			get
			{
				short num = (short)1505213370;
				short num2 = num;
				num = (short)538557370;
				switch (num2 == num)
				{
				}
				num = (short)1951793153;
				if (num != 0)
				{
				}
				num = (short)1884028928;
				if (num != 0)
				{
				}
				num = (short)333512704;
				short num3 = num;
				return this.radWideGeneralTlsPskPort_44842.Min;
			}
			set
			{
				short num = (short)2104680092;
				short num2 = num;
				num = (short)1237638812;
				switch (num2 == num)
				{
				}
				num = (short)1540423681;
				if (num != 0)
				{
				}
				num = (short)513343488;
				if (num != 0)
				{
				}
				num = (short)73203712;
				short num3 = num;
				this.radWideGeneralTlsPskPort_44842.Min = value;
			}
		}

		// Token: 0x17001ADF RID: 6879
		// (get) Token: 0x06003519 RID: 13593 RVA: 0x0032DBCC File Offset: 0x0032BDCC
		// (set) Token: 0x0600351A RID: 13594 RVA: 0x0032DC80 File Offset: 0x0032BE80
		internal int RadWideGeneralTlsPskPort_44842Max
		{
			get
			{
				short num = (short)418761479;
				short num2 = num;
				num = (short)1461177095;
				switch (num2 == num)
				{
				}
				num = (short)2097741825;
				if (num != 0)
				{
				}
				num = (short)1218510848;
				if (num != 0)
				{
				}
				num = (short)1110900736;
				short num3 = num;
				return this.radWideGeneralTlsPskPort_44842.Max;
			}
			set
			{
				short num = (short)1329799098;
				short num2 = num;
				num = (short)901062586;
				switch (num2 == num)
				{
				}
				num = (short)1481441281;
				if (num != 0)
				{
				}
				num = (short)1759510528;
				if (num != 0)
				{
				}
				num = (short)1491664896;
				short num3 = num;
				this.radWideGeneralTlsPskPort_44842.Max = value;
			}
		}

		// Token: 0x17001AE0 RID: 6880
		// (get) Token: 0x0600351B RID: 13595 RVA: 0x0032DD34 File Offset: 0x0032BF34
		// (set) Token: 0x0600351C RID: 13596 RVA: 0x0032DDE8 File Offset: 0x0032BFE8
		internal int RadWideGeneralTlsPskPort_44842Step
		{
			get
			{
				short num = (short)1567452996;
				short num2 = num;
				num = (short)1921806148;
				switch (num2 == num)
				{
				}
				num = (short)798818305;
				if (num != 0)
				{
				}
				num = (short)2110783488;
				if (num != 0)
				{
				}
				num = (short)1399324672;
				short num3 = num;
				return this.radWideGeneralTlsPskPort_44842.StepSize;
			}
			set
			{
				short num = (short)1304821761;
				if (num != 0)
				{
				}
				num = (short)1320349201;
				short num2 = num;
				num = (short)1808920081;
				switch (num2 == num)
				{
				}
				num = (short)1234567168;
				if (num != 0)
				{
				}
				num = (short)241696768;
				short num3 = num;
				this.radWideGeneralTlsPskPort_44842.StepSize = value;
			}
		}

		// Token: 0x17001AE1 RID: 6881
		// (get) Token: 0x0600351D RID: 13597 RVA: 0x0032DEA0 File Offset: 0x0032C0A0
		// (set) Token: 0x0600351E RID: 13598 RVA: 0x0032DF54 File Offset: 0x0032C154
		public bool RadWideGeneralTlsPskPort_44842_Applicable
		{
			get
			{
				short num = (short)1125915843;
				short num2 = num;
				num = (short)1220811971;
				switch (num2 == num)
				{
				}
				num = (short)499515393;
				if (num != 0)
				{
				}
				num = (short)1686765568;
				if (num != 0)
				{
				}
				num = (short)1701183488;
				short num3 = num;
				return this.radWideGeneralTlsPskPort_44842.Applicable;
			}
			set
			{
				short num = (short)1672233136;
				short num2 = num;
				num = (short)1798979760;
				switch (num2 == num)
				{
				}
				num = (short)1254817793;
				if (num != 0)
				{
				}
				num = (short)558563328;
				if (num != 0)
				{
				}
				num = (short)1733754880;
				short num3 = num;
				this.radWideGeneralTlsPskPort_44842.Applicable = value;
			}
		}

		// Token: 0x17001AE2 RID: 6882
		// (get) Token: 0x0600351F RID: 13599 RVA: 0x0032E008 File Offset: 0x0032C208
		// (set) Token: 0x06003520 RID: 13600 RVA: 0x0032E0BC File Offset: 0x0032C2BC
		public bool RadWideGeneralTlsPskPort_44842_Valid
		{
			get
			{
				short num = (short)950797650;
				short num2 = num;
				num = (short)1981678930;
				switch (num2 == num)
				{
				}
				num = (short)1946812417;
				if (num != 0)
				{
				}
				num = (short)1644429312;
				if (num != 0)
				{
				}
				num = (short)412942336;
				short num3 = num;
				return this.radWideGeneralTlsPskPort_44842.Valid;
			}
			set
			{
				short num = (short)219725689;
				short num2 = num;
				num = (short)2140127097;
				switch (num2 == num)
				{
				}
				num = (short)845479937;
				if (num != 0)
				{
				}
				num = (short)751501312;
				if (num != 0)
				{
				}
				num = (short)1655701504;
				short num3 = num;
				this.radWideGeneralTlsPskPort_44842.Valid = value;
			}
		}

		// Token: 0x17001AE3 RID: 6883
		// (get) Token: 0x06003521 RID: 13601 RVA: 0x0032E174 File Offset: 0x0032C374
		// (set) Token: 0x06003522 RID: 13602 RVA: 0x0032E228 File Offset: 0x0032C428
		public bool RadWideGeneralTlsPskPort_44842_Visible
		{
			get
			{
				short num = (short)1516410926;
				short num2 = num;
				num = (short)718641198;
				switch (num2 == num)
				{
				}
				num = (short)818020353;
				if (num != 0)
				{
				}
				num = (short)1319501824;
				if (num != 0)
				{
				}
				num = (short)481689600;
				short num3 = num;
				return this.radWideGeneralTlsPskPort_44842.Visible;
			}
			set
			{
				short num = (short)1623051283;
				short num2 = num;
				num = (short)650562579;
				switch (num2 == num)
				{
				}
				num = (short)1219362816;
				if (num != 0)
				{
				}
				num = (short)1449525249;
				if (num != 0)
				{
				}
				num = (short)897843200;
				short num3 = num;
				this.radWideGeneralTlsPskPort_44842.Visible = value;
			}
		}

		// Token: 0x17001AE4 RID: 6884
		// (get) Token: 0x06003523 RID: 13603 RVA: 0x0032E2DC File Offset: 0x0032C4DC
		// (set) Token: 0x06003524 RID: 13604 RVA: 0x0032E394 File Offset: 0x0032C594
		public bool RadWideGeneralTlsPskPort_44842_Editable
		{
			get
			{
				short num = (short)1583144958;
				short num2 = num;
				num = (short)1939202046;
				switch (num2 == num)
				{
				}
				num = (short)962592769;
				if (num != 0)
				{
				}
				num = (short)2101805056;
				if (num != 0)
				{
				}
				num = (short)710082560;
				short num3 = num;
				return this.radWideGeneralTlsPskPort_44842.Editable;
			}
			set
			{
				short num = (short)1982659781;
				short num2 = num;
				num = (short)401931461;
				switch (num2 == num)
				{
				}
				num = (short)1312882689;
				if (num != 0)
				{
				}
				num = (short)984219648;
				if (num != 0)
				{
				}
				num = (short)84148224;
				short num3 = num;
				this.radWideGeneralTlsPskPort_44842.Editable = value;
			}
		}

		// Token: 0x17001AE5 RID: 6885
		// (get) Token: 0x06003525 RID: 13605 RVA: 0x0032E44C File Offset: 0x0032C64C
		internal string RadWideGeneralTlsPskPort_44842_UILabel
		{
			get
			{
				short num = (short)1137001874;
				short num2 = num;
				num = (short)929514898;
				switch (num2 == num)
				{
				}
				num = (short)1478688768;
				if (num != 0)
				{
				}
				num = (short)536608769;
				if (num != 0)
				{
				}
				num = (short)813432832;
				short num3 = num;
				return this.radWideGeneralTlsPskPort_44842.UIName;
			}
		}

		// Token: 0x17001AE6 RID: 6886
		// (get) Token: 0x06003526 RID: 13606 RVA: 0x0032E500 File Offset: 0x0032C700
		// (set) Token: 0x06003527 RID: 13607 RVA: 0x0032E5B8 File Offset: 0x0032C7B8
		internal bool RadWideGeneralTlsPskPort_44842_HiddenStatic
		{
			get
			{
				short num = (short)1653454090;
				short num2 = num;
				num = (short)147174666;
				switch (num2 == num)
				{
				}
				num = (short)20054017;
				if (num != 0)
				{
				}
				num = (short)1129709568;
				if (num != 0)
				{
				}
				num = (short)1312751616;
				short num3 = num;
				return this.radWideGeneralTlsPskPort_44842.HiddenStatic;
			}
			set
			{
				short num = (short)1411167087;
				short num2 = num;
				num = (short)1859957615;
				switch (num2 == num)
				{
				}
				num = (short)210501632;
				if (num != 0)
				{
				}
				num = (short)1292042241;
				if (num != 0)
				{
				}
				num = (short)110624768;
				short num3 = num;
				this.radWideGeneralTlsPskPort_44842.HiddenStatic = value;
			}
		}

		// Token: 0x17001AE7 RID: 6887
		// (get) Token: 0x06003528 RID: 13608 RVA: 0x0032E670 File Offset: 0x0032C870
		// (set) Token: 0x06003529 RID: 13609 RVA: 0x0032E724 File Offset: 0x0032C924
		internal bool RadWideGeneralTlsPskPort_44842_HiddenDynamic
		{
			get
			{
				short num = (short)534055095;
				short num2 = num;
				num = (short)2113407159;
				switch (num2 == num)
				{
				}
				num = (short)195035136;
				if (num != 0)
				{
				}
				num = (short)1876492289;
				if (num != 0)
				{
				}
				num = (short)657719296;
				short num3 = num;
				return this.radWideGeneralTlsPskPort_44842.HiddenDynamic;
			}
			set
			{
				short num = (short)279576577;
				if (num != 0)
				{
				}
				num = (short)383203564;
				short num2 = num;
				num = (short)1136933100;
				switch (num2 == num)
				{
				}
				num = (short)522649600;
				if (num != 0)
				{
				}
				num = (short)99942400;
				short num3 = num;
				this.radWideGeneralTlsPskPort_44842.HiddenDynamic = value;
			}
		}

		// Token: 0x17001AE8 RID: 6888
		// (get) Token: 0x0600352A RID: 13610 RVA: 0x0032E7D8 File Offset: 0x0032C9D8
		public bool RadWideGeneralTlsPskPort_44842_HasDiffs
		{
			get
			{
				short num = (short)9388507;
				short num2 = num;
				num = (short)336347611;
				switch (num2 == num)
				{
				}
				num = (short)1710882816;
				if (num != 0)
				{
				}
				num = (short)413597697;
				if (num != 0)
				{
				}
				num = (short)1269235712;
				short num3 = num;
				return this.radWideGeneralPskId_44840._HasDiffs;
			}
		}

		// Token: 0x17001AE9 RID: 6889
		// (get) Token: 0x0600352B RID: 13611 RVA: 0x0032E88C File Offset: 0x0032CA8C
		// (set) Token: 0x0600352C RID: 13612 RVA: 0x0032E940 File Offset: 0x0032CB40
		public string RadWideGeneralDnsSdAddress_44843Value
		{
			get
			{
				short num = (short)117321817;
				short num2 = num;
				num = (short)2047488089;
				switch (num2 == num)
				{
				}
				num = (short)1613168641;
				if (num != 0)
				{
				}
				num = (short)1669267456;
				if (num != 0)
				{
				}
				num = (short)845283328;
				short num3 = num;
				return this.radWideGeneralDnsSdAddress_44843.Value;
			}
			set
			{
				short num = (short)1947305920;
				short num2 = num;
				num = (short)1622116288;
				switch (num2 == num)
				{
				}
				num = (short)2014969857;
				if (num != 0)
				{
				}
				num = (short)1370357760;
				if (num != 0)
				{
				}
				num = (short)1879834624;
				short num3 = num;
				this.radWideGeneralDnsSdAddress_44843.Value = value;
			}
		}

		// Token: 0x17001AEA RID: 6890
		// (get) Token: 0x0600352D RID: 13613 RVA: 0x0032E9F4 File Offset: 0x0032CBF4
		// (set) Token: 0x0600352E RID: 13614 RVA: 0x0032EAAC File Offset: 0x0032CCAC
		public string RadWideGeneralDnsSdAddress_44843_UIValue
		{
			get
			{
				short num = (short)53341518;
				short num2 = num;
				num = (short)1577184590;
				switch (num2 == num)
				{
				}
				num = (short)627179521;
				if (num != 0)
				{
				}
				num = (short)1334706176;
				if (num != 0)
				{
				}
				num = (short)2002190336;
				short num3 = num;
				return this.radWideGeneralDnsSdAddress_44843.Value;
			}
			set
			{
				short num = (short)1155360110;
				short num2 = num;
				num = (short)1216046446;
				switch (num2 == num)
				{
				}
				num = (short)1076822017;
				if (num != 0)
				{
				}
				num = (short)1178075136;
				if (num != 0)
				{
				}
				num = (short)1034813440;
				short num3 = num;
				this.radWideGeneralDnsSdAddress_44843.Value = value;
			}
		}

		// Token: 0x17001AEB RID: 6891
		// (get) Token: 0x0600352F RID: 13615 RVA: 0x0032EB64 File Offset: 0x0032CD64
		public global::AcpBusinessLayer.AcpStringField RadWideGeneralDnsSdAddress_44843
		{
			get
			{
				short num = (short)1358373630;
				short num2 = num;
				num = (short)605102846;
				switch (num2 == num)
				{
				}
				num = (short)251592705;
				if (num != 0)
				{
				}
				num = (short)1145372672;
				if (num != 0)
				{
				}
				num = (short)1106378752;
				short num3 = num;
				return this.radWideGeneralDnsSdAddress_44843;
			}
		}

		// Token: 0x17001AEC RID: 6892
		// (get) Token: 0x06003530 RID: 13616 RVA: 0x0032EC14 File Offset: 0x0032CE14
		// (set) Token: 0x06003531 RID: 13617 RVA: 0x0032ECC8 File Offset: 0x0032CEC8
		public bool RadWideGeneralDnsSdAddress_44843_Applicable
		{
			get
			{
				short num = (short)1010748112;
				short num2 = num;
				num = (short)875547344;
				switch (num2 == num)
				{
				}
				num = (short)372441088;
				if (num != 0)
				{
				}
				num = (short)1550974977;
				if (num != 0)
				{
				}
				num = (short)600375296;
				short num3 = num;
				return this.radWideGeneralDnsSdAddress_44843.Applicable;
			}
			set
			{
				short num = (short)476788024;
				short num2 = num;
				num = (short)1149973816;
				switch (num2 == num)
				{
				}
				num = (short)287899648;
				if (num != 0)
				{
				}
				num = (short)1446182913;
				if (num != 0)
				{
				}
				num = (short)467795968;
				short num3 = num;
				this.radWideGeneralDnsSdAddress_44843.Applicable = value;
			}
		}

		// Token: 0x17001AED RID: 6893
		// (get) Token: 0x06003532 RID: 13618 RVA: 0x0032ED80 File Offset: 0x0032CF80
		// (set) Token: 0x06003533 RID: 13619 RVA: 0x0032EE34 File Offset: 0x0032D034
		public bool RadWideGeneralDnsSdAddress_44843_Valid
		{
			get
			{
				short num = (short)1247922848;
				short num2 = num;
				num = (short)759810720;
				switch (num2 == num)
				{
				}
				num = (short)2132738048;
				if (num != 0)
				{
				}
				num = (short)953810945;
				if (num != 0)
				{
				}
				num = (short)720371712;
				short num3 = num;
				return this.radWideGeneralDnsSdAddress_44843.Valid;
			}
			set
			{
				short num = (short)1065833071;
				short num2 = num;
				num = (short)428757615;
				switch (num2 == num)
				{
				}
				num = (short)1167720448;
				if (num != 0)
				{
				}
				num = (short)1826226177;
				if (num != 0)
				{
				}
				num = (short)1086193664;
				short num3 = num;
				this.radWideGeneralDnsSdAddress_44843.Valid = value;
			}
		}

		// Token: 0x17001AEE RID: 6894
		// (get) Token: 0x06003534 RID: 13620 RVA: 0x0032EEEC File Offset: 0x0032D0EC
		// (set) Token: 0x06003535 RID: 13621 RVA: 0x0032EF9C File Offset: 0x0032D19C
		public bool RadWideGeneralDnsSdAddress_44843_Visible
		{
			get
			{
				short num = (short)412559534;
				short num2 = num;
				num = (short)1316890798;
				switch (num2 == num)
				{
				}
				num = (short)1617166337;
				if (num != 0)
				{
				}
				num = (short)278528000;
				if (num != 0)
				{
				}
				num = (short)1903296512;
				short num3 = num;
				return this.radWideGeneralDnsSdAddress_44843.Visible;
			}
			set
			{
				short num = (short)813393264;
				short num2 = num;
				num = (short)771122544;
				switch (num2 == num)
				{
				}
				num = (short)1309605888;
				if (num != 0)
				{
				}
				num = (short)1678442497;
				if (num != 0)
				{
				}
				num = (short)1655177216;
				short num3 = num;
				this.radWideGeneralDnsSdAddress_44843.Visible = value;
			}
		}

		// Token: 0x17001AEF RID: 6895
		// (get) Token: 0x06003536 RID: 13622 RVA: 0x0032F054 File Offset: 0x0032D254
		// (set) Token: 0x06003537 RID: 13623 RVA: 0x0032F108 File Offset: 0x0032D308
		public bool RadWideGeneralDnsSdAddress_44843_Editable
		{
			get
			{
				short num = (short)77594625;
				if (num != 0)
				{
				}
				num = (short)1036349864;
				short num2 = num;
				num = (short)1709339048;
				switch (num2 == num)
				{
				}
				num = (short)1497759744;
				if (num != 0)
				{
				}
				num = (short)1030619136;
				short num3 = num;
				return this.radWideGeneralDnsSdAddress_44843.Editable;
			}
			set
			{
				short num = (short)546292518;
				short num2 = num;
				num = (short)571196198;
				switch (num2 == num)
				{
				}
				num = (short)65011712;
				if (num != 0)
				{
				}
				num = (short)1199570945;
				if (num != 0)
				{
				}
				num = (short)2039808000;
				short num3 = num;
				this.radWideGeneralDnsSdAddress_44843.Editable = value;
			}
		}

		// Token: 0x17001AF0 RID: 6896
		// (get) Token: 0x06003538 RID: 13624 RVA: 0x0032F1C0 File Offset: 0x0032D3C0
		internal string RadWideGeneralDnsSdAddress_44843_UILabel
		{
			get
			{
				short num = (short)164464252;
				short num2 = num;
				num = (short)1653966460;
				switch (num2 == num)
				{
				}
				num = (short)911015937;
				if (num != 0)
				{
				}
				num = (short)1319829504;
				if (num != 0)
				{
				}
				num = (short)1208942592;
				short num3 = num;
				return this.radWideGeneralDnsSdAddress_44843.UIName;
			}
		}

		// Token: 0x17001AF1 RID: 6897
		// (get) Token: 0x06003539 RID: 13625 RVA: 0x0032F274 File Offset: 0x0032D474
		// (set) Token: 0x0600353A RID: 13626 RVA: 0x0032F328 File Offset: 0x0032D528
		internal bool RadWideGeneralDnsSdAddress_44843_HiddenStatic
		{
			get
			{
				short num = (short)459603969;
				if (num != 0)
				{
				}
				num = (short)1037378328;
				short num2 = num;
				num = (short)1499341592;
				switch (num2 == num)
				{
				}
				num = (short)917438464;
				if (num != 0)
				{
				}
				num = (short)469630976;
				short num3 = num;
				return this.radWideGeneralDnsSdAddress_44843.HiddenStatic;
			}
			set
			{
				short num = (short)1753643066;
				short num2 = num;
				num = (short)462125114;
				switch (num2 == num)
				{
				}
				num = (short)270467072;
				if (num != 0)
				{
				}
				num = (short)1428160513;
				if (num != 0)
				{
				}
				num = (short)1310916608;
				short num3 = num;
				this.radWideGeneralDnsSdAddress_44843.HiddenStatic = value;
			}
		}

		// Token: 0x17001AF2 RID: 6898
		// (get) Token: 0x0600353B RID: 13627 RVA: 0x0032F3E0 File Offset: 0x0032D5E0
		// (set) Token: 0x0600353C RID: 13628 RVA: 0x0032F494 File Offset: 0x0032D694
		internal bool RadWideGeneralDnsSdAddress_44843_HiddenDynamic
		{
			get
			{
				short num = (short)1190517511;
				short num2 = num;
				num = (short)2088229639;
				switch (num2 == num)
				{
				}
				num = (short)1437270017;
				if (num != 0)
				{
				}
				num = (short)1624178688;
				if (num != 0)
				{
				}
				num = (short)946929664;
				short num3 = num;
				return this.radWideGeneralDnsSdAddress_44843.HiddenDynamic;
			}
			set
			{
				short num = (short)977419262;
				short num2 = num;
				num = (short)159595518;
				switch (num2 == num)
				{
				}
				num = (short)1991573505;
				if (num != 0)
				{
				}
				num = (short)1219362816;
				if (num != 0)
				{
				}
				num = (short)2015100928;
				short num3 = num;
				this.radWideGeneralDnsSdAddress_44843.HiddenDynamic = value;
			}
		}

		// Token: 0x17001AF3 RID: 6899
		// (get) Token: 0x0600353D RID: 13629 RVA: 0x0032F54C File Offset: 0x0032D74C
		public bool RadWideGeneralDnsSdAddress_44843_HasDiffs
		{
			get
			{
				short num = (short)612583194;
				short num2 = num;
				num = (short)933906202;
				switch (num2 == num)
				{
				}
				num = (short)1068040192;
				if (num != 0)
				{
				}
				num = (short)297533441;
				if (num != 0)
				{
				}
				num = (short)483328000;
				short num3 = num;
				return this.radWideGeneralDnsSdAddress_44843._HasDiffs;
			}
		}

		// Token: 0x17001AF4 RID: 6900
		// (get) Token: 0x0600353E RID: 13630 RVA: 0x0032F600 File Offset: 0x0032D800
		// (set) Token: 0x0600353F RID: 13631 RVA: 0x0032F6B4 File Offset: 0x0032D8B4
		public int RadWideGeneralDnsSdPort_44844Value
		{
			get
			{
				short num = (short)336582464;
				short num2 = num;
				num = (short)1636423488;
				switch (num2 == num)
				{
				}
				num = (short)2103574529;
				if (num != 0)
				{
				}
				num = (short)1956642816;
				if (num != 0)
				{
				}
				num = (short)660537344;
				short num3 = num;
				return this.radWideGeneralDnsSdPort_44844.Value;
			}
			set
			{
				short num = (short)582356542;
				short num2 = num;
				num = (short)1171918398;
				switch (num2 == num)
				{
				}
				num = (short)1953366016;
				if (num != 0)
				{
				}
				num = (short)4849665;
				if (num != 0)
				{
				}
				num = (short)659488768;
				short num3 = num;
				this.radWideGeneralDnsSdPort_44844.Value = value;
			}
		}

		// Token: 0x17001AF5 RID: 6901
		// (get) Token: 0x06003540 RID: 13632 RVA: 0x0032F768 File Offset: 0x0032D968
		// (set) Token: 0x06003541 RID: 13633 RVA: 0x0032F81C File Offset: 0x0032DA1C
		public int RadWideGeneralDnsSdPort_44844_UIValue
		{
			get
			{
				short num = (short)1977868316;
				short num2 = num;
				num = (short)313909276;
				switch (num2 == num)
				{
				}
				num = (short)676921344;
				if (num != 0)
				{
				}
				num = (short)1609695233;
				if (num != 0)
				{
				}
				num = (short)297598976;
				short num3 = num;
				return this.radWideGeneralDnsSdPort_44844.Value;
			}
			set
			{
				short num = (short)1964605578;
				short num2 = num;
				num = (short)1549369482;
				switch (num2 == num)
				{
				}
				num = (short)1298071552;
				if (num != 0)
				{
				}
				num = (short)1583218689;
				if (num != 0)
				{
				}
				num = (short)1546256384;
				short num3 = num;
				this.radWideGeneralDnsSdPort_44844.Value = value;
			}
		}

		// Token: 0x17001AF6 RID: 6902
		// (get) Token: 0x06003542 RID: 13634 RVA: 0x0032F8D4 File Offset: 0x0032DAD4
		public global::AcpBusinessLayer.AcpSimpleRangeField RadWideGeneralDnsSdPort_44844
		{
			get
			{
				short num = (short)682754049;
				if (num != 0)
				{
				}
				num = (short)99924543;
				short num2 = num;
				num = (short)368753215;
				switch (num2 == num)
				{
				}
				num = (short)861470720;
				if (num != 0)
				{
				}
				num = (short)1901985792;
				short num3 = num;
				return this.radWideGeneralDnsSdPort_44844;
			}
		}

		// Token: 0x17001AF7 RID: 6903
		// (get) Token: 0x06003543 RID: 13635 RVA: 0x0032F984 File Offset: 0x0032DB84
		// (set) Token: 0x06003544 RID: 13636 RVA: 0x0032FA34 File Offset: 0x0032DC34
		internal int RadWideGeneralDnsSdPort_44844Min
		{
			get
			{
				short num = (short)1746075649;
				if (num != 0)
				{
				}
				num = (short)1365549628;
				short num2 = num;
				num = (short)1852940860;
				switch (num2 == num)
				{
				}
				num = (short)1972830208;
				if (num != 0)
				{
				}
				num = (short)628817920;
				short num3 = num;
				return this.radWideGeneralDnsSdPort_44844.Min;
			}
			set
			{
				short num = (short)314064644;
				short num2 = num;
				num = (short)840777476;
				switch (num2 == num)
				{
				}
				num = (short)1056964609;
				if (num != 0)
				{
				}
				num = (short)391380992;
				if (num != 0)
				{
				}
				num = (short)1356201984;
				short num3 = num;
				this.radWideGeneralDnsSdPort_44844.Min = value;
			}
		}

		// Token: 0x17001AF8 RID: 6904
		// (get) Token: 0x06003545 RID: 13637 RVA: 0x0032FAEC File Offset: 0x0032DCEC
		// (set) Token: 0x06003546 RID: 13638 RVA: 0x0032FBA0 File Offset: 0x0032DDA0
		internal int RadWideGeneralDnsSdPort_44844Max
		{
			get
			{
				short num = (short)1668297615;
				short num2 = num;
				num = (short)577123215;
				switch (num2 == num)
				{
				}
				num = (short)1236140032;
				if (num != 0)
				{
				}
				num = (short)280428545;
				if (num != 0)
				{
				}
				num = (short)1242234880;
				short num3 = num;
				return this.radWideGeneralDnsSdPort_44844.Max;
			}
			set
			{
				short num = (short)594764956;
				short num2 = num;
				num = (short)241001628;
				switch (num2 == num)
				{
				}
				num = (short)1026228225;
				if (num != 0)
				{
				}
				num = (short)2022375424;
				if (num != 0)
				{
				}
				num = (short)1229979648;
				short num3 = num;
				this.radWideGeneralDnsSdPort_44844.Max = value;
			}
		}

		// Token: 0x17001AF9 RID: 6905
		// (get) Token: 0x06003547 RID: 13639 RVA: 0x0032FC54 File Offset: 0x0032DE54
		// (set) Token: 0x06003548 RID: 13640 RVA: 0x0032FD08 File Offset: 0x0032DF08
		internal int RadWideGeneralDnsSdPort_44844Step
		{
			get
			{
				short num = (short)828877446;
				short num2 = num;
				num = (short)235645574;
				switch (num2 == num)
				{
				}
				num = (short)559349760;
				if (num != 0)
				{
				}
				num = (short)216072193;
				if (num != 0)
				{
				}
				num = (short)9961472;
				short num3 = num;
				return this.radWideGeneralDnsSdPort_44844.StepSize;
			}
			set
			{
				short num = (short)314834945;
				if (num != 0)
				{
				}
				num = (short)119973038;
				short num2 = num;
				num = (short)852403374;
				switch (num2 == num)
				{
				}
				num = (short)1378484224;
				if (num != 0)
				{
				}
				num = (short)1705377792;
				short num3 = num;
				this.radWideGeneralDnsSdPort_44844.StepSize = value;
			}
		}

		// Token: 0x17001AFA RID: 6906
		// (get) Token: 0x06003549 RID: 13641 RVA: 0x0032FDBC File Offset: 0x0032DFBC
		// (set) Token: 0x0600354A RID: 13642 RVA: 0x0032FE74 File Offset: 0x0032E074
		public bool RadWideGeneralDnsSdPort_44844_Applicable
		{
			get
			{
				short num = (short)1484056612;
				short num2 = num;
				num = (short)749201444;
				switch (num2 == num)
				{
				}
				num = (short)1770586112;
				if (num != 0)
				{
				}
				num = (short)1118371841;
				if (num != 0)
				{
				}
				num = (short)1923612672;
				short num3 = num;
				return this.radWideGeneralDnsSdPort_44844.Applicable;
			}
			set
			{
				short num = (short)1764122114;
				short num2 = num;
				num = (short)2139643394;
				switch (num2 == num)
				{
				}
				num = (short)261095424;
				if (num != 0)
				{
				}
				num = (short)20971521;
				if (num != 0)
				{
				}
				num = (short)1210843136;
				short num3 = num;
				this.radWideGeneralDnsSdPort_44844.Applicable = value;
			}
		}

		// Token: 0x17001AFB RID: 6907
		// (get) Token: 0x0600354B RID: 13643 RVA: 0x0032FF28 File Offset: 0x0032E128
		// (set) Token: 0x0600354C RID: 13644 RVA: 0x0032FFE0 File Offset: 0x0032E1E0
		public bool RadWideGeneralDnsSdPort_44844_Valid
		{
			get
			{
				short num = (short)1203338456;
				short num2 = num;
				num = (short)352877784;
				switch (num2 == num)
				{
				}
				num = (short)1019215872;
				if (num != 0)
				{
				}
				num = (short)524484609;
				if (num != 0)
				{
				}
				num = (short)1671692288;
				short num3 = num;
				return this.radWideGeneralDnsSdPort_44844.Valid;
			}
			set
			{
				short num = (short)1121702557;
				short num2 = num;
				num = (short)58708637;
				switch (num2 == num)
				{
				}
				num = (short)1597767680;
				if (num != 0)
				{
				}
				num = (short)697434113;
				if (num != 0)
				{
				}
				num = (short)394395648;
				short num3 = num;
				this.radWideGeneralDnsSdPort_44844.Valid = value;
			}
		}

		// Token: 0x17001AFC RID: 6908
		// (get) Token: 0x0600354D RID: 13645 RVA: 0x00330094 File Offset: 0x0032E294
		// (set) Token: 0x0600354E RID: 13646 RVA: 0x00330148 File Offset: 0x0032E348
		public bool RadWideGeneralDnsSdPort_44844_Visible
		{
			get
			{
				short num = (short)1337745997;
				short num2 = num;
				num = (short)1353605709;
				switch (num2 == num)
				{
				}
				num = (short)319553537;
				if (num != 0)
				{
				}
				num = (short)1124859904;
				if (num != 0)
				{
				}
				num = (short)1038942208;
				short num3 = num;
				return this.radWideGeneralDnsSdPort_44844.Visible;
			}
			set
			{
				short num = (short)530251777;
				if (num != 0)
				{
				}
				num = (short)241447930;
				short num2 = num;
				num = (short)2064004090;
				switch (num2 == num)
				{
				}
				num = (short)254279680;
				if (num != 0)
				{
				}
				num = (short)1964310528;
				short num3 = num;
				this.radWideGeneralDnsSdPort_44844.Visible = value;
			}
		}

		// Token: 0x17001AFD RID: 6909
		// (get) Token: 0x0600354F RID: 13647 RVA: 0x003301FC File Offset: 0x0032E3FC
		// (set) Token: 0x06003550 RID: 13648 RVA: 0x003302B4 File Offset: 0x0032E4B4
		public bool RadWideGeneralDnsSdPort_44844_Editable
		{
			get
			{
				short num = (short)471789902;
				short num2 = num;
				num = (short)1747382606;
				switch (num2 == num)
				{
				}
				num = (short)1282015233;
				if (num != 0)
				{
				}
				num = (short)1015087104;
				if (num != 0)
				{
				}
				num = (short)2045771776;
				short num3 = num;
				return this.radWideGeneralDnsSdPort_44844.Editable;
			}
			set
			{
				short num = (short)1525573017;
				short num2 = num;
				num = (short)1928619417;
				switch (num2 == num)
				{
				}
				num = (short)1342898177;
				if (num != 0)
				{
				}
				num = (short)456785920;
				if (num != 0)
				{
				}
				num = (short)957284352;
				short num3 = num;
				this.radWideGeneralDnsSdPort_44844.Editable = value;
			}
		}

		// Token: 0x17001AFE RID: 6910
		// (get) Token: 0x06003551 RID: 13649 RVA: 0x00330368 File Offset: 0x0032E568
		internal string RadWideGeneralDnsSdPort_44844_UILabel
		{
			get
			{
				short num = (short)26672315;
				short num2 = num;
				num = (short)416611515;
				switch (num2 == num)
				{
				}
				num = (short)1967325184;
				if (num != 0)
				{
				}
				num = (short)825425921;
				if (num != 0)
				{
				}
				num = (short)1010827264;
				short num3 = num;
				return this.radWideGeneralDnsSdPort_44844.UIName;
			}
		}

		// Token: 0x17001AFF RID: 6911
		// (get) Token: 0x06003552 RID: 13650 RVA: 0x00330418 File Offset: 0x0032E618
		// (set) Token: 0x06003553 RID: 13651 RVA: 0x003304CC File Offset: 0x0032E6CC
		internal bool RadWideGeneralDnsSdPort_44844_HiddenStatic
		{
			get
			{
				short num = (short)1619197952;
				short num2 = num;
				num = (short)928883828;
				short num3 = num;
				num = (short)8430708;
				switch (num3 == num)
				{
				}
				num = (short)738066433;
				if (num != 0)
				{
				}
				num = (short)525795328;
				if (num != 0)
				{
				}
				return this.radWideGeneralDnsSdPort_44844.HiddenStatic;
			}
			set
			{
				short num = (short)1428815872;
				short num2 = num;
				num = (short)1815591129;
				short num3 = num;
				num = (short)661960921;
				switch (num3 == num)
				{
				}
				num = (short)1957691393;
				if (num != 0)
				{
				}
				num = (short)94961664;
				if (num != 0)
				{
				}
				this.radWideGeneralDnsSdPort_44844.HiddenStatic = value;
			}
		}

		// Token: 0x17001B00 RID: 6912
		// (get) Token: 0x06003554 RID: 13652 RVA: 0x00330580 File Offset: 0x0032E780
		// (set) Token: 0x06003555 RID: 13653 RVA: 0x00330634 File Offset: 0x0032E834
		internal bool RadWideGeneralDnsSdPort_44844_HiddenDynamic
		{
			get
			{
				short num = (short)1726480384;
				short num2 = num;
				num = (short)1932349986;
				short num3 = num;
				num = (short)2039501346;
				switch (num3 == num)
				{
				}
				num = (short)889651200;
				if (num != 0)
				{
				}
				num = (short)898433025;
				if (num != 0)
				{
				}
				return this.radWideGeneralDnsSdPort_44844.HiddenDynamic;
			}
			set
			{
				short num = (short)256638976;
				short num2 = num;
				num = (short)582676032;
				short num3 = num;
				num = (short)1175907904;
				switch (num3 == num)
				{
				}
				num = (short)1970995201;
				if (num != 0)
				{
				}
				num = (short)942735360;
				if (num != 0)
				{
				}
				this.radWideGeneralDnsSdPort_44844.HiddenDynamic = value;
			}
		}

		// Token: 0x17001B01 RID: 6913
		// (get) Token: 0x06003556 RID: 13654 RVA: 0x003306EC File Offset: 0x0032E8EC
		public bool RadWideGeneralDnsSdPort_44844_HasDiffs
		{
			get
			{
				short num = (short)1093730304;
				short num2 = num;
				num = (short)407690404;
				short num3 = num;
				num = (short)698473636;
				switch (num3 == num)
				{
				}
				num = (short)895877120;
				if (num != 0)
				{
				}
				num = (short)783679489;
				if (num != 0)
				{
				}
				return this.radWideGeneralDnsSdPort_44844._HasDiffs;
			}
		}

		// Token: 0x17001B02 RID: 6914
		// (get) Token: 0x06003557 RID: 13655 RVA: 0x003307A4 File Offset: 0x0032E9A4
		// (set) Token: 0x06003558 RID: 13656 RVA: 0x00330858 File Offset: 0x0032EA58
		public int RadWideGeneralProgrammingPath_44845Value
		{
			get
			{
				short num = (short)1168703488;
				short num2 = num;
				num = (short)492591624;
				short num3 = num;
				num = (short)1575836168;
				switch (num3 == num)
				{
				}
				num = (short)620494849;
				if (num != 0)
				{
				}
				num = (short)1815609344;
				if (num != 0)
				{
				}
				return this.radWideGeneralProgrammingPath_44845.Value;
			}
			set
			{
				short num = (short)1067122688;
				short num2 = num;
				num = (short)803939974;
				short num3 = num;
				num = (short)1565468294;
				switch (num3 == num)
				{
				}
				num = (short)834404353;
				if (num != 0)
				{
				}
				num = (short)1545338880;
				if (num != 0)
				{
				}
				this.radWideGeneralProgrammingPath_44845.Value = value;
			}
		}

		// Token: 0x17001B03 RID: 6915
		// (get) Token: 0x06003559 RID: 13657 RVA: 0x00330910 File Offset: 0x0032EB10
		// (set) Token: 0x0600355A RID: 13658 RVA: 0x003309C4 File Offset: 0x0032EBC4
		public string RadWideGeneralProgrammingPath_44845_UIValue
		{
			get
			{
				short num = (short)572194816;
				short num2 = num;
				num = (short)693436417;
				if (num != 0)
				{
				}
				num = (short)2044987629;
				short num3 = num;
				num = (short)142870765;
				switch (num3 == num)
				{
				}
				num = (short)398589952;
				if (num != 0)
				{
				}
				return this.radWideGeneralProgrammingPath_44845.UIValue;
			}
			set
			{
				short num = (short)1176240128;
				short num2 = num;
				num = (short)1075730818;
				short num3 = num;
				num = (short)1019435394;
				switch (num3 == num)
				{
				}
				num = (short)573767681;
				if (num != 0)
				{
				}
				num = (short)695533568;
				if (num != 0)
				{
				}
				this.radWideGeneralProgrammingPath_44845.UIValue = value;
			}
		}

		// Token: 0x17001B04 RID: 6916
		// (get) Token: 0x0600355B RID: 13659 RVA: 0x00330A78 File Offset: 0x0032EC78
		public global::AcpBusinessLayer.AcpListField RadWideGeneralProgrammingPath_44845
		{
			get
			{
				short num = (short)2121728000;
				short num2 = num;
				num = (short)1593104813;
				short num3 = num;
				num = (short)586930605;
				switch (num3 == num)
				{
				}
				num = (short)1404502017;
				if (num != 0)
				{
				}
				num = (short)514326528;
				if (num != 0)
				{
				}
				return this.radWideGeneralProgrammingPath_44845;
			}
		}

		// Token: 0x17001B05 RID: 6917
		// (get) Token: 0x0600355C RID: 13660 RVA: 0x00330B24 File Offset: 0x0032ED24
		// (set) Token: 0x0600355D RID: 13661 RVA: 0x00330BD8 File Offset: 0x0032EDD8
		public bool RadWideGeneralProgrammingPath_44845_Applicable
		{
			get
			{
				short num = (short)1981677568;
				short num2 = num;
				num = (short)1376256001;
				if (num != 0)
				{
				}
				num = (short)188337496;
				short num3 = num;
				num = (short)336448856;
				switch (num3 == num)
				{
				}
				num = (short)1561198592;
				if (num != 0)
				{
				}
				return this.radWideGeneralProgrammingPath_44845.Applicable;
			}
			set
			{
				short num = (short)1576271872;
				short num2 = num;
				num = (short)752343554;
				short num3 = num;
				num = (short)358078978;
				switch (num3 == num)
				{
				}
				num = (short)1904934913;
				if (num != 0)
				{
				}
				num = (short)1521876992;
				if (num != 0)
				{
				}
				this.radWideGeneralProgrammingPath_44845.Applicable = value;
			}
		}

		// Token: 0x17001B06 RID: 6918
		// (get) Token: 0x0600355E RID: 13662 RVA: 0x00330C90 File Offset: 0x0032EE90
		// (set) Token: 0x0600355F RID: 13663 RVA: 0x00330D48 File Offset: 0x0032EF48
		public bool RadWideGeneralProgrammingPath_44845_Valid
		{
			get
			{
				short num = (short)2146041856;
				short num2 = num;
				num = (short)1424228353;
				if (num != 0)
				{
				}
				num = (short)1344829297;
				short num3 = num;
				num = (short)2144302961;
				switch (num3 == num)
				{
				}
				num = (short)1614544896;
				if (num != 0)
				{
				}
				return this.radWideGeneralProgrammingPath_44845.Valid;
			}
			set
			{
				short num = (short)1109852160;
				short num2 = num;
				num = (short)563724700;
				short num3 = num;
				num = (short)623886748;
				switch (num3 == num)
				{
				}
				num = (short)2079850496;
				if (num != 0)
				{
				}
				num = (short)388628481;
				if (num != 0)
				{
				}
				this.radWideGeneralProgrammingPath_44845.Valid = value;
			}
		}

		// Token: 0x17001B07 RID: 6919
		// (get) Token: 0x06003560 RID: 13664 RVA: 0x00330E00 File Offset: 0x0032F000
		// (set) Token: 0x06003561 RID: 13665 RVA: 0x00330EB4 File Offset: 0x0032F0B4
		public bool RadWideGeneralProgrammingPath_44845_Visible
		{
			get
			{
				short num = (short)82640896;
				short num2 = num;
				num = (short)1687970220;
				short num3 = num;
				num = (short)1649435052;
				switch (num3 == num)
				{
				}
				num = (short)505085953;
				if (num != 0)
				{
				}
				num = (short)234553344;
				if (num != 0)
				{
				}
				return this.radWideGeneralProgrammingPath_44845.Visible;
			}
			set
			{
				short num = (short)2076377088;
				short num2 = num;
				num = (short)1416442781;
				short num3 = num;
				num = (short)1857303453;
				switch (num3 == num)
				{
				}
				num = (short)116064256;
				if (num != 0)
				{
				}
				num = (short)79233025;
				if (num != 0)
				{
				}
				this.radWideGeneralProgrammingPath_44845.Visible = value;
			}
		}

		// Token: 0x17001B08 RID: 6920
		// (get) Token: 0x06003562 RID: 13666 RVA: 0x00330F68 File Offset: 0x0032F168
		// (set) Token: 0x06003563 RID: 13667 RVA: 0x0033101C File Offset: 0x0032F21C
		public bool RadWideGeneralProgrammingPath_44845_Editable
		{
			get
			{
				short num = (short)161021952;
				short num2 = num;
				num = (short)2051493948;
				short num3 = num;
				num = (short)442847292;
				switch (num3 == num)
				{
				}
				num = (short)1784545281;
				if (num != 0)
				{
				}
				num = (short)1603469312;
				if (num != 0)
				{
				}
				return this.radWideGeneralProgrammingPath_44845.Editable;
			}
			set
			{
				short num = (short)825491456;
				short num2 = num;
				num = (short)1996949301;
				short num3 = num;
				num = (short)1259669301;
				switch (num3 == num)
				{
				}
				num = (short)1371013121;
				if (num != 0)
				{
				}
				num = (short)158138368;
				if (num != 0)
				{
				}
				this.radWideGeneralProgrammingPath_44845.Editable = value;
			}
		}

		// Token: 0x17001B09 RID: 6921
		// (get) Token: 0x06003564 RID: 13668 RVA: 0x003310D0 File Offset: 0x0032F2D0
		internal string RadWideGeneralProgrammingPath_44845_UILabel
		{
			get
			{
				short num = (short)518193152;
				short num2 = num;
				num = (short)1366307598;
				short num3 = num;
				num = (short)2131637006;
				switch (num3 == num)
				{
				}
				num = (short)862781441;
				if (num != 0)
				{
				}
				num = (short)497221632;
				if (num != 0)
				{
				}
				return this.radWideGeneralProgrammingPath_44845.UIName;
			}
		}

		// Token: 0x17001B0A RID: 6922
		// (get) Token: 0x06003565 RID: 13669 RVA: 0x00331188 File Offset: 0x0032F388
		// (set) Token: 0x06003566 RID: 13670 RVA: 0x0033123C File Offset: 0x0032F43C
		internal bool RadWideGeneralProgrammingPath_44845_HiddenStatic
		{
			get
			{
				short num = (short)76546048;
				short num2 = num;
				num = (short)2139210545;
				short num3 = num;
				num = (short)932037425;
				switch (num3 == num)
				{
				}
				num = (short)833093633;
				if (num != 0)
				{
				}
				num = (short)1566507008;
				if (num != 0)
				{
				}
				return this.radWideGeneralProgrammingPath_44845.HiddenStatic;
			}
			set
			{
				short num = (short)1164050432;
				short num2 = num;
				num = (short)2045109241;
				short num3 = num;
				num = (short)956031993;
				switch (num3 == num)
				{
				}
				num = (short)2008875008;
				if (num != 0)
				{
				}
				num = (short)1123942401;
				if (num != 0)
				{
				}
				this.radWideGeneralProgrammingPath_44845.HiddenStatic = value;
			}
		}

		// Token: 0x17001B0B RID: 6923
		// (get) Token: 0x06003567 RID: 13671 RVA: 0x003312F0 File Offset: 0x0032F4F0
		// (set) Token: 0x06003568 RID: 13672 RVA: 0x003313A4 File Offset: 0x0032F5A4
		internal bool RadWideGeneralProgrammingPath_44845_HiddenDynamic
		{
			get
			{
				short num = (short)1448083456;
				short num2 = num;
				num = (short)802985792;
				short num3 = num;
				num = (short)1813288768;
				switch (num3 == num)
				{
				}
				num = (short)16449536;
				if (num != 0)
				{
				}
				num = (short)735248385;
				if (num != 0)
				{
				}
				return this.radWideGeneralProgrammingPath_44845.HiddenDynamic;
			}
			set
			{
				short num = (short)640811008;
				short num2 = num;
				num = (short)2142556316;
				short num3 = num;
				num = (short)1366085788;
				switch (num3 == num)
				{
				}
				num = (short)900399105;
				if (num != 0)
				{
				}
				num = (short)690552832;
				if (num != 0)
				{
				}
				this.radWideGeneralProgrammingPath_44845.HiddenDynamic = value;
			}
		}

		// Token: 0x17001B0C RID: 6924
		// (get) Token: 0x06003569 RID: 13673 RVA: 0x00331458 File Offset: 0x0032F658
		public bool RadWideGeneralProgrammingPath_44845_HasDiffs
		{
			get
			{
				short num = (short)1623457792;
				short num2 = num;
				num = (short)1036984346;
				short num3 = num;
				num = (short)425140250;
				switch (num3 == num)
				{
				}
				num = (short)1607598080;
				if (num != 0)
				{
				}
				num = (short)272302081;
				if (num != 0)
				{
				}
				return this.radWideGeneralProgrammingPath_44845._HasDiffs;
			}
		}

		// Token: 0x17001B0D RID: 6925
		// (get) Token: 0x0600356A RID: 13674 RVA: 0x00331510 File Offset: 0x0032F710
		// (set) Token: 0x0600356B RID: 13675 RVA: 0x003315C4 File Offset: 0x0032F7C4
		public bool RadWideRecentCallListDeleteEnableValue
		{
			get
			{
				short num = (short)376569856;
				short num2 = num;
				num = (short)1950985665;
				short num3 = num;
				num = (short)374517185;
				switch (num3 == num)
				{
				}
				num = (short)119341056;
				if (num != 0)
				{
				}
				num = (short)755499009;
				if (num != 0)
				{
				}
				return this.radWideRecentCallListDeleteEnable.Value;
			}
			set
			{
				short num = (short)1449328640;
				short num2 = num;
				num = (short)1911111817;
				short num3 = num;
				num = (short)1047150729;
				switch (num3 == num)
				{
				}
				num = (short)1999372288;
				if (num != 0)
				{
				}
				num = (short)1365704705;
				if (num != 0)
				{
				}
				this.radWideRecentCallListDeleteEnable.Value = value;
			}
		}

		// Token: 0x17001B0E RID: 6926
		// (get) Token: 0x0600356C RID: 13676 RVA: 0x0033167C File Offset: 0x0032F87C
		public global::AcpBusinessLayer.AcpField<bool> RadWideRecentCallListDeleteEnable
		{
			get
			{
				short num = (short)897908736;
				short num2 = num;
				num = (short)2112489326;
				short num3 = num;
				num = (short)1246431086;
				switch (num3 == num)
				{
				}
				num = (short)674955265;
				if (num != 0)
				{
				}
				num = (short)415891456;
				if (num != 0)
				{
				}
				return this.radWideRecentCallListDeleteEnable;
			}
		}

		// Token: 0x17001B0F RID: 6927
		// (get) Token: 0x0600356D RID: 13677 RVA: 0x0033172C File Offset: 0x0032F92C
		// (set) Token: 0x0600356E RID: 13678 RVA: 0x003317E0 File Offset: 0x0032F9E0
		public bool RadWideRecentCallListDeleteEnable_UIValue
		{
			get
			{
				short num = (short)909443072;
				short num2 = num;
				num = (short)429389008;
				short num3 = num;
				num = (short)680457424;
				switch (num3 == num)
				{
				}
				num = (short)227803137;
				if (num != 0)
				{
				}
				num = (short)1663434752;
				if (num != 0)
				{
				}
				return this.radWideRecentCallListDeleteEnable.Value;
			}
			set
			{
				short num = (short)835780608;
				short num2 = num;
				num = (short)265547912;
				short num3 = num;
				num = (short)731705480;
				switch (num3 == num)
				{
				}
				num = (short)2049572864;
				if (num != 0)
				{
				}
				num = (short)1170931713;
				if (num != 0)
				{
				}
				this.radWideRecentCallListDeleteEnable.Value = value;
			}
		}

		// Token: 0x17001B10 RID: 6928
		// (get) Token: 0x0600356F RID: 13679 RVA: 0x00331898 File Offset: 0x0032FA98
		// (set) Token: 0x06003570 RID: 13680 RVA: 0x0033194C File Offset: 0x0032FB4C
		public bool RadWideRecentCallListDeleteEnable_Applicable
		{
			get
			{
				short num = (short)1116667904;
				short num2 = num;
				num = (short)1946362926;
				short num3 = num;
				num = (short)574759982;
				switch (num3 == num)
				{
				}
				num = (short)1457192961;
				if (num != 0)
				{
				}
				num = (short)277348352;
				if (num != 0)
				{
				}
				return this.radWideRecentCallListDeleteEnable.Applicable;
			}
			set
			{
				short num = (short)899022848;
				short num2 = num;
				num = (short)439283486;
				short num3 = num;
				num = (short)997453598;
				switch (num3 == num)
				{
				}
				num = (short)1459683328;
				if (num != 0)
				{
				}
				num = (short)931069953;
				if (num != 0)
				{
				}
				this.radWideRecentCallListDeleteEnable.Applicable = value;
			}
		}

		// Token: 0x17001B11 RID: 6929
		// (get) Token: 0x06003571 RID: 13681 RVA: 0x00331A04 File Offset: 0x0032FC04
		// (set) Token: 0x06003572 RID: 13682 RVA: 0x00331ABC File Offset: 0x0032FCBC
		public bool RadWideRecentCallListDeleteEnable_Valid
		{
			get
			{
				short num = (short)356777984;
				short num2 = num;
				num = (short)629180140;
				short num3 = num;
				num = (short)2042791660;
				switch (num3 == num)
				{
				}
				num = (short)879886337;
				if (num != 0)
				{
				}
				num = (short)577961984;
				if (num != 0)
				{
				}
				return this.radWideRecentCallListDeleteEnable.Valid;
			}
			set
			{
				short num = (short)785252352;
				short num2 = num;
				num = (short)1889105262;
				short num3 = num;
				num = (short)385774958;
				switch (num3 == num)
				{
				}
				num = (short)39190528;
				if (num != 0)
				{
				}
				num = (short)2107965441;
				if (num != 0)
				{
				}
				this.radWideRecentCallListDeleteEnable.Valid = value;
			}
		}

		// Token: 0x17001B12 RID: 6930
		// (get) Token: 0x06003573 RID: 13683 RVA: 0x00331B70 File Offset: 0x0032FD70
		// (set) Token: 0x06003574 RID: 13684 RVA: 0x00331C24 File Offset: 0x0032FE24
		public bool RadWideRecentCallListDeleteEnable_Visible
		{
			get
			{
				short num = (short)502661120;
				short num2 = num;
				num = (short)1720794946;
				short num3 = num;
				num = (short)571031362;
				switch (num3 == num)
				{
				}
				num = (short)1322188801;
				if (num != 0)
				{
				}
				num = (short)1213333504;
				if (num != 0)
				{
				}
				return this.radWideRecentCallListDeleteEnable.Visible;
			}
			set
			{
				short num = (short)1205927936;
				short num2 = num;
				num = (short)460694182;
				short num3 = num;
				num = (short)1265803942;
				switch (num3 == num)
				{
				}
				num = (short)1128660993;
				if (num != 0)
				{
				}
				num = (short)1927086080;
				if (num != 0)
				{
				}
				this.radWideRecentCallListDeleteEnable.Visible = value;
			}
		}

		// Token: 0x17001B13 RID: 6931
		// (get) Token: 0x06003575 RID: 13685 RVA: 0x00331CD8 File Offset: 0x0032FED8
		// (set) Token: 0x06003576 RID: 13686 RVA: 0x00331D8C File Offset: 0x0032FF8C
		public bool RadWideRecentCallListDeleteEnable_Editable
		{
			get
			{
				short num = (short)1060962304;
				short num2 = num;
				num = (short)102047335;
				short num3 = num;
				num = (short)1007558247;
				switch (num3 == num)
				{
				}
				num = (short)1263140865;
				if (num != 0)
				{
				}
				num = (short)1172242432;
				if (num != 0)
				{
				}
				return this.radWideRecentCallListDeleteEnable.Editable;
			}
			set
			{
				short num = (short)1668087808;
				short num2 = num;
				num = (short)1958394907;
				short num3 = num;
				num = (short)1417985051;
				switch (num3 == num)
				{
				}
				num = (short)1714487296;
				if (num != 0)
				{
				}
				num = (short)667287553;
				if (num != 0)
				{
				}
				this.radWideRecentCallListDeleteEnable.Editable = value;
			}
		}

		// Token: 0x17001B14 RID: 6932
		// (get) Token: 0x06003577 RID: 13687 RVA: 0x00331E44 File Offset: 0x00330044
		internal string RadWideRecentCallListDeleteEnable_UILabel
		{
			get
			{
				short num = (short)417333248;
				short num2 = num;
				num = (short)2070802908;
				short num3 = num;
				num = (short)1465119196;
				switch (num3 == num)
				{
				}
				num = (short)497614849;
				if (num != 0)
				{
				}
				num = (short)218038272;
				if (num != 0)
				{
				}
				return this.radWideRecentCallListDeleteEnable.UIName;
			}
		}

		// Token: 0x17001B15 RID: 6933
		// (get) Token: 0x06003578 RID: 13688 RVA: 0x00331F00 File Offset: 0x00330100
		// (set) Token: 0x06003579 RID: 13689 RVA: 0x00331FB4 File Offset: 0x003301B4
		internal bool RadWideRecentCallListDeleteEnable_HiddenStatic
		{
			get
			{
				short num = (short)871170048;
				short num2 = num;
				num = (short)1373372417;
				if (num != 0)
				{
				}
				num = (short)387884006;
				short num3 = num;
				num = (short)1686021094;
				switch (num3 == num)
				{
				}
				num = (short)1593966592;
				if (num != 0)
				{
				}
				return this.radWideRecentCallListDeleteEnable.HiddenStatic;
			}
			set
			{
				short num = (short)247201792;
				short num2 = num;
				num = (short)1473601591;
				short num3 = num;
				num = (short)1534353463;
				switch (num3 == num)
				{
				}
				num = (short)639631361;
				if (num != 0)
				{
				}
				num = (short)171376640;
				if (num != 0)
				{
				}
				this.radWideRecentCallListDeleteEnable.HiddenStatic = value;
			}
		}

		// Token: 0x17001B16 RID: 6934
		// (get) Token: 0x0600357A RID: 13690 RVA: 0x00332068 File Offset: 0x00330268
		// (set) Token: 0x0600357B RID: 13691 RVA: 0x0033211C File Offset: 0x0033031C
		internal bool RadWideRecentCallListDeleteEnable_HiddenDynamic
		{
			get
			{
				short num = (short)895090688;
				short num2 = num;
				num = (short)2134080438;
				short num3 = num;
				num = (short)1446017974;
				switch (num3 == num)
				{
				}
				num = (short)1943928832;
				if (num != 0)
				{
				}
				num = (short)199426049;
				if (num != 0)
				{
				}
				return this.radWideRecentCallListDeleteEnable.HiddenDynamic;
			}
			set
			{
				short num = (short)953352192;
				short num2 = num;
				num = (short)2108241430;
				short num3 = num;
				num = (short)1916679702;
				switch (num3 == num)
				{
				}
				num = (short)315686913;
				if (num != 0)
				{
				}
				num = (short)1019936768;
				if (num != 0)
				{
				}
				this.radWideRecentCallListDeleteEnable.HiddenDynamic = value;
			}
		}

		// Token: 0x17001B17 RID: 6935
		// (get) Token: 0x0600357C RID: 13692 RVA: 0x003321D0 File Offset: 0x003303D0
		public bool RadWideRecentCallListDeleteEnable_HasDiffs
		{
			get
			{
				short num = (short)580321280;
				short num2 = num;
				num = (short)826006028;
				short num3 = num;
				num = (short)837474828;
				switch (num3 == num)
				{
				}
				num = (short)1260519425;
				if (num != 0)
				{
				}
				num = (short)1707147264;
				if (num != 0)
				{
				}
				return this.radWideRecentCallListDeleteEnable._HasDiffs;
			}
		}

		// Token: 0x0600357D RID: 13693 RVA: 0x00332284 File Offset: 0x00330484
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			short num = (short)2068643840;
			short num2 = num;
			switch (0)
			{
			case 0:
				goto IL_4E;
			}
			int num3;
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_34:
				switch (num3)
				{
				case 0:
				{
					num = (short)715754223;
					short num4 = num;
					num = (short)2087095023;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return result;
					default:
						num = (short)1376780288;
						if (num != 0)
						{
						}
						if (base.ParentRecset != null)
						{
							num = (short)29622273;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					break;
				}
				case 1:
					num = (short)87031811;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num = (short)596508676;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num = (short)1377763330;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 4:
					goto IL_FE;
				}
				goto IL_4E;
			}
			IL_FE:
			num = (short)353697793;
			if (num != 0)
			{
			}
			return result;
			IL_4E:
			result = null;
			num = (short)1413873664;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_34;
		}

		// Token: 0x0400119B RID: 4507
		private global::AcpBusinessLayer.AcpListField radWideGeneralDateFormat_A7802;

		// Token: 0x0400119C RID: 4508
		private global::AcpBusinessLayer.AcpListField radWideAdvancedMaximumTxDeviation_A8480;

		// Token: 0x0400119D RID: 4509
		private global::AcpBusinessLayer.AcpField<bool> radInfoGeneralMotorcycleRadio_A8546;

		// Token: 0x0400119E RID: 4510
		private global::AcpBusinessLayer.AcpListField radWideGeneralTimeFormat_A9377;

		// Token: 0x0400119F RID: 4511
		private global::AcpBusinessLayer.AcpListField radWideAdvancedUltraNarrowIntermediateFreqFilter_A9592;

		// Token: 0x040011A0 RID: 4512
		private global::AcpBusinessLayer.AcpListField radErgoWideAdvancedModeSelTxName;

		// Token: 0x040011A1 RID: 4513
		private global::AcpBusinessLayer.AcpField<bool> radWideGeneralLogDisp_A9756;

		// Token: 0x040011A2 RID: 4514
		private global::AcpBusinessLayer.AcpField<bool> radWideGeneralASKRequired_A37152;

		// Token: 0x040011A3 RID: 4515
		private global::AcpBusinessLayer.AcpSimpleRangeField radWideGeneralOwnerSystemID_A37153;

		// Token: 0x040011A4 RID: 4516
		private global::AcpBusinessLayer.AcpSimpleRangeField radWideGeneralOwnerWACNID_A38656;

		// Token: 0x040011A5 RID: 4517
		private global::AcpBusinessLayer.AcpListField radWideGeneralOwnerAdvancedKeyType_A38663;

		// Token: 0x040011A6 RID: 4518
		private global::AcpBusinessLayer.AcpStringField radWideGeneralPskId_44840;

		// Token: 0x040011A7 RID: 4519
		private global::AcpBusinessLayer.AcpStringField radWideGeneralTlsPsk_44841;

		// Token: 0x040011A8 RID: 4520
		private global::AcpBusinessLayer.AcpSimpleRangeField radWideGeneralTlsPskPort_44842;

		// Token: 0x040011A9 RID: 4521
		private global::AcpBusinessLayer.AcpStringField radWideGeneralDnsSdAddress_44843;

		// Token: 0x040011AA RID: 4522
		private global::AcpBusinessLayer.AcpSimpleRangeField radWideGeneralDnsSdPort_44844;

		// Token: 0x040011AB RID: 4523
		private global::AcpBusinessLayer.AcpListField radWideGeneralProgrammingPath_44845;

		// Token: 0x040011AC RID: 4524
		private global::AcpBusinessLayer.AcpField<bool> radWideRecentCallListDeleteEnable;
	}
}
