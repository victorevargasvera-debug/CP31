using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.DataWide
{
	// Token: 0x020004E3 RID: 1251
	[global::System.Serializable]
	public class LabtoolDATA_CFG : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600A645 RID: 42565 RVA: 0x009ADEA8 File Offset: 0x009AC0A8
		public LabtoolDATA_CFG(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x0600A646 RID: 42566 RVA: 0x009ADEC4 File Offset: 0x009AC0C4
		protected LabtoolDATA_CFG(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600A647 RID: 42567 RVA: 0x009ADEDC File Offset: 0x009AC0DC
		public override void Init()
		{
			int a_ = 17;
			short num = (short)214757359;
			short num2 = num;
			num = (short)967372783;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1367670784;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1501167617;
			if (num != 0)
			{
			}
			num = (short)570228736;
			if (num != 0)
			{
			}
			this.labtoolContextActivationHoldoffTimerSec = new global::AcpBusinessLayer.AcpSimpleRangeField(300, this, global::AllFeatures.CodeplugGuid.b("黑뗓듕곗뗙돛닝ꏟ跡諣鋥跧鋩飫꿭鏯蛱鷳胵駷軹闻釽滿䨁欃樅氇攉樋栍䐏笑礓猕樗䤙礛紝", a_), global::CommonResources.AcgResources.ID_CONTEXTACTIVATIONHOLDOFFTIMERSEC, 1, 300, null, null, 0, 1);
			this.labtoolContextActivationHoldoffTimerSec.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Depot;
			this.labtoolContextActivationHoldoffTimerSec.DataTransferOrder = -1;
			this.labtoolContextActivationHoldoffTimerSec.ShowHexValue = false;
			this.dataWideLabtoolDATA_CFGOTAPDefaultInactivityTimer_A8668 = new global::AcpBusinessLayer.AcpSimpleRangeField(60, this, global::AllFeatures.CodeplugGuid.b("雑뗓ꋕ맗跙뗛뫝藟껡藣蓥鳧藩菫苭듯돱ꃳ럵ꟷ맹뫻맽俿嘁䔃嘅䰇漉樋漍攏縑怓引瘗笙缛樝䤟吡䴣別儧縩䔫䌭唯䀱欳眵7హ਻ؽ", a_), global::CommonResources.AcgResources.ID_OTAPDEFAULTINACTIVITYTIMER, 0, 255, null, null, 0, 1);
			this.dataWideLabtoolDATA_CFGOTAPDefaultInactivityTimer_A8668.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.dataWideLabtoolDATA_CFGOTAPDefaultInactivityTimer_A8668.DataTransferOrder = -1;
			this.dataWideLabtoolDATA_CFGOTAPDefaultInactivityTimer_A8668.ShowHexValue = false;
			this.labtoolContextRenewalTimerMin = new global::AcpBusinessLayer.AcpSimpleRangeField(30, this, global::AllFeatures.CodeplugGuid.b("黑뗓듕곗뗙돛닝ꏟ跡諣鋥跧鋩飫볭闯鳱釳臵駷雹ꣻ韽淿朁瘃䬅愇搉", a_), global::CommonResources.AcgResources.ID_CONTEXTRENEWALTIMERMIN, 1, 120, null, null, 0, 1);
			this.labtoolContextRenewalTimerMin.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.labtoolContextRenewalTimerMin.DataTransferOrder = 50;
			this.labtoolContextRenewalTimerMin.ShowHexValue = false;
			this.dataWideLabtoolDATA_CFGPacketDataActivateWaitTimerSec_A8686 = new global::AcpBusinessLayer.AcpSimpleRangeField(60, this, global::AllFeatures.CodeplugGuid.b("雑뗓ꋕ맗跙뗛뫝藟껡藣蓥鳧藩菫苭듯돱ꃳ럵ꟷ맹뫻맽僿持會洅洇縉䠋漍搏猑唓甕気猙樛缝吟䜡猣䜥䄧帩砫䜭崯圱䘳攵崷夹挻缽砿瑁籃灅", a_), global::CommonResources.AcgResources.ID_PACKETDATAACTIVATEWAITTIMERSEC, 1, 300, null, null, 0, 1);
			this.dataWideLabtoolDATA_CFGPacketDataActivateWaitTimerSec_A8686.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.dataWideLabtoolDATA_CFGPacketDataActivateWaitTimerSec_A8686.DataTransferOrder = 51;
			this.dataWideLabtoolDATA_CFGPacketDataActivateWaitTimerSec_A8686.ShowHexValue = false;
			this.labtoolDefaultReadyTimerSec = new global::AcpBusinessLayer.AcpSimpleRangeField(10, this, global::AllFeatures.CodeplugGuid.b("黑뗓듕곗뗙돛닝ꓟ蟡苣蟥鷧蛩飫볭闯鏱郳迵곷鏹釻鯽狿儁愃攅", a_), global::CommonResources.AcgResources.ID_DEFAULTREADYTIMERSEC, 1, 255, null, null, 0, 1);
			this.labtoolDefaultReadyTimerSec.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Depot;
			this.labtoolDefaultReadyTimerSec.DataTransferOrder = 52;
			this.labtoolDefaultReadyTimerSec.ShowHexValue = false;
			this.dataWideDVRSActWaitTime_A40128 = new global::AcpBusinessLayer.AcpSimpleRangeField(180, this, global::AllFeatures.CodeplugGuid.b("雑뗓ꋕ맗跙뗛뫝藟ꛡ닣듥믧ꯩ迫髭꟯鏱鷳苵곷鏹釻鯽忿䌁〃㘅㤇㠉㐋", a_), global::CommonResources.AcgResources.ID_DVRSACTIVATIONWAITTIMESEC, 1, 600, null, null, 0, 1);
			this.dataWideDVRSActWaitTime_A40128.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.dataWideDVRSActWaitTime_A40128.DataTransferOrder = -1;
			this.dataWideDVRSActWaitTime_A40128.ShowHexValue = false;
			this.randomAccessAckTimerMsec_42016 = new global::AcpBusinessLayer.AcpSimpleRangeField(195, this, global::AllFeatures.CodeplugGuid.b("胑뗓룕볗뗙뇛鿝菟臡臣闥鯧ꯩ迫藭ꓯ鯱駳鏵諷럹迻鯽揿崁〃㐅㠇㬉㨋", a_), global::CommonResources.AcgResources.ID_ENHANCEDDATARANDOMACCESSACKTIMERMSEC, 0, 511, null, null, 0, 1);
			this.randomAccessAckTimerMsec_42016.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.randomAccessAckTimerMsec_42016.DataTransferOrder = -1;
			this.randomAccessAckTimerMsec_42016.ShowHexValue = false;
			this.dataWideLabtoolDeviceProvisioningServiceIDScope_43553 = new global::AcpBusinessLayer.AcpStringField(global::AllFeatures.CodeplugGuid.b("뫓돕ꋟ\udae1퇣꟥", a_), this, global::AllFeatures.CodeplugGuid.b("雑뗓ꋕ맗跙뗛뫝藟껡藣蓥鳧藩菫苭듯韱苳鿵鯷鿹곻賽濿琁洃甅愇攉戋服縏甑䜓猕樗氙甛紝䔟次怣甥䬧䔩尫䬭漯ر̵ܳഷह", a_), global::CommonResources.AcgResources.ID_DATAWIDELABTOOLDEVICEPROVISIONINGSERVICEIDSCOPE, 128);
			this.dataWideLabtoolDeviceProvisioningServiceIDScope_43553.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.dataWideLabtoolDeviceProvisioningServiceIDScope_43553.DataTransferOrder = 53;
			this.cloudRegion_43554 = new global::AcpBusinessLayer.AcpStringField(global::AllFeatures.CodeplugGuid.b("蟑蟓뇕럗곙", a_), this, global::AllFeatures.CodeplugGuid.b("金룓맕귗뻙軛믝蟟诡诣裥럧\udee9\udfeb\udbed엯웱", a_), global::CommonResources.AcgResources.ID_DATAWIDECLOUDREGION, 6);
			this.cloudRegion_43554.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.cloudRegion_43554.DataTransferOrder = 54;
			this.dataWideLabtoolDeviceProvisioningServiceURI_43555 = new global::AcpBusinessLayer.AcpStringField(global::AllFeatures.CodeplugGuid.b("뗑룓맕뫗믙냛臟飡釣铥跧쟩裫语蛯鯱音鏵请ퟹ賻賽濿琁洃甅愇攉戋服縏甑㨓砕紗渙", a_), this, global::AllFeatures.CodeplugGuid.b("雑뗓ꋕ맗跙뗛뫝藟껡藣蓥鳧藩菫苭듯韱苳鿵鯷鿹곻賽濿琁洃甅愇攉戋服縏甑䜓猕樗氙甛紝䔟眡瘣漥眧ḩἫᬭԯܱ", a_), global::CommonResources.AcgResources.ID_DATAWIDELABTOOLDEVICEPROVISIONINGSERVICEURI, 256);
			this.dataWideLabtoolDeviceProvisioningServiceURI_43555.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.dataWideLabtoolDeviceProvisioningServiceURI_43555.DataTransferOrder = 55;
			this.dataWideIdentityManagementGatewayHostname_43556 = new global::AcpBusinessLayer.AcpStringField(global::AllFeatures.CodeplugGuid.b("믑냓믕동뇛꧝컟迡诣鋥蟧飩菫苭釯臱鯳髵跷軹闻釽滿焁⨃攅朇有", a_), this, global::AllFeatures.CodeplugGuid.b("雑뗓ꋕ맗跙뗛뫝藟ꯡ胣菥蛧黩藫髭觯뿱闳飵駷鷹駻鏽旿氁瀃䄅椇縉椋礍焏欑尓礕欗渙爛缝䴟䜡笣ሥᬧἩᤫᠭ", a_), global::CommonResources.AcgResources.ID_DATAWIDEIDENTITYMANAGEMENTGATEWAYHOSTNAME, 255);
			this.dataWideIdentityManagementGatewayHostname_43556.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.dataWideIdentityManagementGatewayHostname_43556.DataTransferOrder = 56;
			this.dataWideVirtualPartnerGatewayHostname_43557 = new global::AcpBusinessLayer.AcpStringField(global::AllFeatures.CodeplugGuid.b("돑ꓓ뿕뿛뇝跟迡藣裥賧觩觫胭蓯胱闳髵훷駹鏻鏽", a_), this, global::AllFeatures.CodeplugGuid.b("雑뗓ꋕ맗跙뗛뫝藟듡跣铥鳧鿩跫苭ꃯ鏱蛳苵雷鿹軻맽懿瘁愃焅椇猉䐋愍挏昑稓眕甗缙䌛⨝ጟᜡᄣᄥ", a_), global::CommonResources.AcgResources.ID_DATAWIDEVIRTUALPARTNERGATEWAYHOSTNAME, 255);
			this.dataWideVirtualPartnerGatewayHostname_43557.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.dataWideVirtualPartnerGatewayHostname_43557.DataTransferOrder = 57;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("黑뗓듕곗뗙돛닝샟쿡쓣ꋥꧧ뻩귫뇭돯등돳", a_);
			base.Id = 10073;
			base.UIName = global::CommonResources.AcgResources.ID_LABTOOLDATA_CFG;
			base.DataTransferOrder = 6;
		}

		// Token: 0x0600A648 RID: 42568 RVA: 0x009AE368 File Offset: 0x009AC568
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 10;
			short num = (short)1653014549;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1430519808;
					short num3 = num;
					this.cloudRegion_43554 = new global::AcpBusinessLayer.AcpStringField(global::AllFeatures.CodeplugGuid.b("黊黌꣎뻐ꗒ", a_), this, global::AllFeatures.CodeplugGuid.b("裊ꇌꃎꓐ럒蟔닖뻘닚닜뇞뻠ퟢ훤틦\udce8\udfea", a_), global::CommonResources.AcgResources.ID_DATAWIDECLOUDREGION, 6);
					this.cloudRegion_43554.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.cloudRegion_43554.DataTransferOrder = 54;
					num = (short)378929157;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("迊곌믎냐蓒볔돖볘韚볜뷞闠賢諤详귨ꫪ맬껮껰냲돴냶뛸꿺볼꿾䔀昂挄昆簈朊礌䘎缐爒瘔挖瀘洚琜欞堠眢䰤䨦䰨太爬渮रԲ̴༶", a_)))
					{
						num = (short)1680146447;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5FC;
				case 2:
					this.dataWideLabtoolDATA_CFGPacketDataActivateWaitTimerSec_A8686 = new global::AcpBusinessLayer.AcpSimpleRangeField(60, this, global::AllFeatures.CodeplugGuid.b("迊곌믎냐蓒볔돖볘韚볜뷞闠賢諤详귨ꫪ맬껮껰냲돴냶꧸髺黼链搀眂䄄昆紈樊䰌氎攐稒挔瘖洘縚䨜縞䠠圢焤並䐨个弬簮吰倲樴瘶ĸഺԼा", a_), global::CommonResources.AcgResources.ID_PACKETDATAACTIVATEWAITTIMERSEC, null, null, 0, 1);
					this.dataWideLabtoolDATA_CFGPacketDataActivateWaitTimerSec_A8686.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.dataWideLabtoolDATA_CFGPacketDataActivateWaitTimerSec_A8686.DataTransferOrder = 51;
					this.dataWideLabtoolDATA_CFGPacketDataActivateWaitTimerSec_A8686.ShowHexValue = false;
					num = (short)1612578840;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
				{
					this.dataWideDVRSActWaitTime_A40128 = new global::AcpBusinessLayer.AcpSimpleRangeField(180, this, global::AllFeatures.CodeplugGuid.b("迊곌믎냐蓒볔돖볘鿚诜跞닠ꋢ蛤鏦뻨諪蓬鯮ꗰ髲飴鋶꛸뫺짼쿾\u3000㄂㴄", a_), global::CommonResources.AcgResources.ID_DVRSACTIVATIONWAITTIMESEC, null, null, 0, 1);
					this.dataWideDVRSActWaitTime_A40128.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.dataWideDVRSActWaitTime_A40128.DataTransferOrder = -1;
					this.dataWideDVRSActWaitTime_A40128.ShowHexValue = false;
					num = (short)128409802;
					short num4 = num;
					num = (short)922443978;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_7C6;
					default:
						num = (short)1880358912;
						if (num != 0)
						{
						}
						num = (short)2114781204;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 4:
					this.randomAccessAckTimerMsec_42016 = new global::AcpBusinessLayer.AcpSimpleRangeField(195, this, global::AllFeatures.CodeplugGuid.b("駊곌ꇎ뗐볒룔雖뫘룚룜곞鋠ꋢ蛤賦뷨苪胬諮菰뻲蛴鋶髸ꓺ짼췾㄀㈂㌄", a_), global::CommonResources.AcgResources.ID_ENHANCEDDATARANDOMACCESSACKTIMERMSEC, null, null, 0, 1);
					this.randomAccessAckTimerMsec_42016.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.randomAccessAckTimerMsec_42016.DataTransferOrder = -1;
					this.randomAccessAckTimerMsec_42016.ShowHexValue = false;
					num = (short)2078736397;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_95E;
				case 6:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蟊곌귎ꗐ볒뫔믖高듚돜ꯞ蓠鯢釤뗦賨藪裬飮郰鿲ꇴ黶铸黺迼닾栀洂", a_)))
					{
						num = (short)709754910;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_8C4;
				case 7:
					goto IL_570;
				case 8:
					goto IL_F7;
				case 9:
					goto IL_8C4;
				case 10:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蟊곌귎ꗐ볒뫔믖高듚돜ꯞ蓠鯢釤ꛦ諨鿪蓬駮郰蟲鳴飶韸돺鋼鏾攀氂挄愆崈戊怌樎挐䀒瀔琖", a_)))
					{
						num = (short)1250623516;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_64A;
				case 11:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("迊곌믎냐蓒볔돖볘韚볜뷞闠賢諤详귨ꫪ맬껮껰냲돴냶꧸髺黼链搀眂䄄昆紈樊䰌氎攐稒挔瘖洘縚䨜縞䠠圢焤並䐨个弬簮吰倲樴瘶ĸഺԼा", a_)))
					{
						num = (short)1962213378;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_575;
				case 12:
					this.dataWideIdentityManagementGatewayHostname_43556 = new global::AcpBusinessLayer.AcpStringField(global::AllFeatures.CodeplugGuid.b("ꋊ꧌ꋎ￐뫒룔ꃖ뛚닜ꯞ軠釢諤详裨飪苬菮蓰蟲鳴飶韸裺폼鳾渀渂", a_), this, global::AllFeatures.CodeplugGuid.b("迊곌믎냐蓒볔돖볘鋚맜뫞迠韢賤鏦部ꛪ賬臮郰铲郴髶鳸闺觼룾怀眂怄瀆栈爊䔌怎成朒笔瘖琘縚䈜⬞ሠᘢဤᄦ", a_), global::CommonResources.AcgResources.ID_DATAWIDEIDENTITYMANAGEMENTGATEWAYHOSTNAME, 255);
					this.dataWideIdentityManagementGatewayHostname_43556.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.dataWideIdentityManagementGatewayHostname_43556.DataTransferOrder = 56;
					num = (short)606208038;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					goto IL_878;
				case 14:
					goto IL_4C2;
				case 15:
					this.dataWideLabtoolDATA_CFGOTAPDefaultInactivityTimer_A8668 = new global::AcpBusinessLayer.AcpSimpleRangeField(60, this, global::AllFeatures.CodeplugGuid.b("迊곌믎냐蓒볔돖볘韚볜뷞闠賢諤详귨ꫪ맬껮껰냲돴냶뛸꿺볼꿾䔀昂挄昆簈朊礌䘎缐爒瘔挖瀘洚琜欞堠眢䰤䨦䰨太爬渮रԲ̴༶", a_), global::CommonResources.AcgResources.ID_OTAPDEFAULTINACTIVITYTIMER, null, null, 0, 1);
					this.dataWideLabtoolDATA_CFGOTAPDefaultInactivityTimer_A8668.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.dataWideLabtoolDATA_CFGOTAPDefaultInactivityTimer_A8668.DataTransferOrder = -1;
					this.dataWideLabtoolDATA_CFGOTAPDefaultInactivityTimer_A8668.ShowHexValue = false;
					num = (short)1734344741;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
					this.dataWideVirtualPartnerGatewayHostname_43557 = new global::AcpBusinessLayer.AcpStringField(global::AllFeatures.CodeplugGuid.b("꫊뷌ꛎ﷒뛔룖듘뛚볜뇞藠胢胤触鷨駪賬菮\udff0郲髴髶", a_), this, global::AllFeatures.CodeplugGuid.b("迊곌믎냐蓒볔돖볘跚드귞闠離蓤详맨諪鿬鯮鿰雲蟴냶飸迺飼裾怀稂䴄栆稈缊挌渎簐瘒䨔⌖⨘⸚⠜⠞", a_), global::CommonResources.AcgResources.ID_DATAWIDEVIRTUALPARTNERGATEWAYHOSTNAME, 255);
					this.dataWideVirtualPartnerGatewayHostname_43557.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.dataWideVirtualPartnerGatewayHostname_43557.DataTransferOrder = 57;
					num = (short)909508615;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					num = (short)1756692519;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 18:
					goto IL_7C6;
				case 19:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("迊곌믎냐蓒볔돖볘鋚맜뫞迠韢賤鏦部ꛪ賬臮郰铲郴髶鳸闺觼룾怀眂怄瀆栈爊䔌怎成朒笔瘖琘縚䈜⬞ሠᘢဤᄦ", a_)))
					{
						num = (short)1063911436;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_35B;
				case 20:
					goto IL_16E;
				case 21:
					switch (0)
					{
					case 0:
						goto IL_CF;
					}
					continue;
				case 22:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("裊ꇌꃎꓐ럒蟔닖뻘닚닜뇞뻠ퟢ훤틦\udce8\udfea", a_)))
					{
						num = (short)646381568;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_95E;
				case 23:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("迊곌믎냐蓒볔돖볘韚볜뷞闠賢諤详귨軪鯬蛮鋰雲ꗴ藶雸跺铼賾栀氂欄渆月氊希樎挐攒簔琖簘业伜嘞縠ᜢᘤሦᰨḪ", a_)))
					{
						num = (short)1642856474;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4C2;
				case 24:
					goto IL_575;
				case 25:
					goto IL_64A;
				case 26:
					num = (short)235143169;
					if (num != 0)
					{
					}
					this.dataWideLabtoolDeviceProvisioningServiceURI_43555 = new global::AcpBusinessLayer.AcpStringField(global::AllFeatures.CodeplugGuid.b("곊ꇌꃎ돐닒맔淪룘ꇚ꣜귞蓠컢臤苦鿨苪軬諮苰\udef2藴藶雸跺铼賾栀氂欄渆月氊⌌愎琐朒", a_), this, global::AllFeatures.CodeplugGuid.b("迊곌믎냐蓒볔돖볘韚볜뷞闠賢諤详귨軪鯬蛮鋰雲ꗴ藶雸跺铼賾栀氂欄渆月氊希樎挐攒簔琖簘业伜嘞縠ᜢᘤሦᰨḪ", a_), global::CommonResources.AcgResources.ID_DATAWIDELABTOOLDEVICEPROVISIONINGSERVICEURI, 256);
					this.dataWideLabtoolDeviceProvisioningServiceURI_43555.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.dataWideLabtoolDeviceProvisioningServiceURI_43555.DataTransferOrder = 55;
					num = (short)681050126;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 27:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蟊곌귎ꗐ볒뫔믖鷘뻚믜뻞铠迢釤뗦賨諪觬雮ꗰ髲飴鋶诸꣺飼鳾", a_)))
					{
						num = (short)1196687378;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_82A;
				case 28:
					this.labtoolContextActivationHoldoffTimerSec = new global::AcpBusinessLayer.AcpSimpleRangeField(300, this, global::AllFeatures.CodeplugGuid.b("蟊곌귎ꗐ볒뫔믖高듚돜ꯞ蓠鯢釤ꛦ諨鿪蓬駮郰蟲鳴飶韸돺鋼鏾攀氂挄愆崈戊怌樎挐䀒瀔琖", a_), global::CommonResources.AcgResources.ID_CONTEXTACTIVATIONHOLDOFFTIMERSEC, null, null, 0, 1);
					this.labtoolContextActivationHoldoffTimerSec.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Depot;
					this.labtoolContextActivationHoldoffTimerSec.DataTransferOrder = -1;
					this.labtoolContextActivationHoldoffTimerSec.ShowHexValue = false;
					num = (short)354746393;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 29:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("迊곌믎냐蓒볔돖볘韚볜뷞闠賢諤详귨軪鯬蛮鋰雲ꗴ藶雸跺铼賾栀氂欄渆月氊希樎挐攒簔琖簘刚夜䰞䈠䰢唤䈦瘨ἪḬᨮа2", a_)))
					{
						num = (short)2002059298;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_F7;
				case 30:
					this.labtoolContextRenewalTimerMin = new global::AcpBusinessLayer.AcpSimpleRangeField(30, this, global::AllFeatures.CodeplugGuid.b("蟊곌귎ꗐ볒뫔믖高듚돜ꯞ蓠鯢釤뗦賨藪裬飮郰鿲ꇴ黶铸黺迼닾栀洂", a_), global::CommonResources.AcgResources.ID_CONTEXTRENEWALTIMERMIN, null, null, 0, 1);
					this.labtoolContextRenewalTimerMin.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.labtoolContextRenewalTimerMin.DataTransferOrder = 50;
					this.labtoolContextRenewalTimerMin.ShowHexValue = false;
					num = (short)1264058377;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 31:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("迊곌믎냐蓒볔돖볘鿚诜跞닠ꋢ蛤鏦뻨諪蓬鯮ꗰ髲飴鋶꛸뫺짼쿾\u3000㄂㴄", a_)))
					{
						num = (short)738459651;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_16E;
				case 32:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("迊곌믎냐蓒볔돖볘跚드귞闠離蓤详맨諪鿬鯮鿰雲蟴냶飸迺飼裾怀稂䴄栆稈缊挌渎簐瘒䨔⌖⨘⸚⠜⠞", a_)))
					{
						num = (short)172163088;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A3C;
				case 33:
					num = (short)613875722;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 34:
					this.dataWideLabtoolDeviceProvisioningServiceIDScope_43553 = new global::AcpBusinessLayer.AcpStringField(global::AllFeatures.CodeplugGuid.b("﯊ꏌ꫎鯘點", a_), this, global::AllFeatures.CodeplugGuid.b("迊곌믎냐蓒볔돖볘韚볜뷞闠賢諤详귨軪鯬蛮鋰雲ꗴ藶雸跺铼賾栀氂欄渆月氊希樎挐攒簔琖簘刚夜䰞䈠䰢唤䈦瘨ἪḬᨮа2", a_), global::CommonResources.AcgResources.ID_DATAWIDELABTOOLDEVICEPROVISIONINGSERVICEIDSCOPE, 128);
					this.dataWideLabtoolDeviceProvisioningServiceIDScope_43553.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.dataWideLabtoolDeviceProvisioningServiceIDScope_43553.DataTransferOrder = 53;
					num = (short)241958920;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 35:
					goto IL_82A;
				case 36:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("駊곌ꇎ뗐볒룔雖뫘룚룜곞鋠ꋢ蛤賦뷨苪胬諮菰뻲蛴鋶髸ꓺ짼췾㄀㈂㌄", a_)))
					{
						num = (short)473956356;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_878;
				case 37:
					goto IL_5FC;
				case 38:
					goto IL_35B;
				case 39:
					if (producerFields != null)
					{
						num = (short)1784283169;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A3C;
				}
				IL_CF:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)518848529;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_F7:
				num = (short)2050490390;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_16E:
				num = (short)585236516;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_35B:
				num = (short)1945174048;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_4C2:
				num = (short)843841555;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_575:
				num = (short)417005595;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_5FC:
				num = (short)2001534982;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_64A:
				num = (short)1541931009;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_7C6:
				this.labtoolDefaultReadyTimerSec = new global::AcpBusinessLayer.AcpSimpleRangeField(10, this, global::AllFeatures.CodeplugGuid.b("蟊곌귎ꗐ볒뫔믖鷘뻚믜뻞铠迢釤뗦賨諪觬雮ꗰ髲飴鋶诸꣺飼鳾", a_), global::CommonResources.AcgResources.ID_DEFAULTREADYTIMERSEC, null, null, 0, 1);
				this.labtoolDefaultReadyTimerSec.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Depot;
				this.labtoolDefaultReadyTimerSec.DataTransferOrder = 52;
				this.labtoolDefaultReadyTimerSec.ShowHexValue = false;
				num = (short)359202851;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_82A:
				num = (short)2094858271;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_878:
				num = (short)2005598237;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_8C4:
				num = (short)1484128267;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_95E:
				num = (short)1798963223;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_570:
			IL_A3C:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("蟊곌귎ꗐ볒뫔믖律﷜鯞ꃠ럢ꓤ룦ꫨ귪ꫬ", a_);
			base.Id = 10073;
			base.UIName = global::CommonResources.AcgResources.ID_LABTOOLDATA_CFG;
			base.DataTransferOrder = 6;
		}

		// Token: 0x0600A649 RID: 42569 RVA: 0x009AEDE4 File Offset: 0x009ACFE4
		public override void PopulateReferences()
		{
			short num = (short)1966164911;
			short num2 = num;
			num = (short)1615088559;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1367474176;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1304821760;
			if (num != 0)
			{
			}
			num = (short)1242431489;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600A64A RID: 42570 RVA: 0x009AEE8C File Offset: 0x009AD08C
		public override void DropReferences()
		{
			short num = (short)82117263;
			short num2 = num;
			num = (short)1125057167;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1345650688;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)250150913;
			if (num != 0)
			{
			}
			num = (short)987758592;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600A64B RID: 42571 RVA: 0x009AEF38 File Offset: 0x009AD138
		public override void SetConstraints()
		{
			short num = (short)1000509898;
			short num2 = num;
			num = (short)2039648714;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1974665216;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1631387649;
			if (num != 0)
			{
			}
			num = (short)1576534016;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600A64C RID: 42572 RVA: 0x009AEFE0 File Offset: 0x009AD1E0
		public override void SetupDependencies()
		{
			short num = (short)1711634474;
			short num2 = num;
			num = (short)1106081834;
			switch (num2 == num)
			{
			default:
			{
				num = (short)938475520;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1459945473;
			if (num != 0)
			{
			}
			num = (short)116523008;
			if (num != 0)
			{
			}
		}

		// Token: 0x17005370 RID: 21360
		// (get) Token: 0x0600A64D RID: 42573 RVA: 0x009AF08C File Offset: 0x009AD28C
		public bool HasDiffs
		{
			get
			{
				short num = (short)1176897809;
				short num2 = num;
				num = (short)1216743697;
				switch (num2 == num)
				{
				default:
				{
					num = (short)66846720;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)816840704;
				if (num != 0)
				{
				}
				num = (short)155910145;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17005371 RID: 21361
		// (get) Token: 0x0600A64E RID: 42574 RVA: 0x009AF13C File Offset: 0x009AD33C
		// (set) Token: 0x0600A64F RID: 42575 RVA: 0x009AF1F4 File Offset: 0x009AD3F4
		public int LabtoolContextActivationHoldoffTimerSecValue
		{
			get
			{
				short num = (short)2007234022;
				short num2 = num;
				num = (short)1436743142;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1663500288;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)648019969;
				if (num != 0)
				{
				}
				num = (short)399507456;
				if (num != 0)
				{
				}
				return this.labtoolContextActivationHoldoffTimerSec.Value;
			}
			set
			{
				short num = (short)1492419575;
				short num2 = num;
				num = (short)883393527;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1966604288;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2006581248;
				if (num != 0)
				{
				}
				num = (short)926089217;
				if (num != 0)
				{
				}
				this.labtoolContextActivationHoldoffTimerSec.Value = value;
			}
		}

		// Token: 0x17005372 RID: 21362
		// (get) Token: 0x0600A650 RID: 42576 RVA: 0x009AF2AC File Offset: 0x009AD4AC
		public global::AcpBusinessLayer.AcpSimpleRangeField LabtoolContextActivationHoldoffTimerSec
		{
			get
			{
				short num = (short)492689849;
				short num2 = num;
				num = (short)1410718137;
				switch (num2 == num)
				{
				default:
				{
					num = (short)18415616;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)104333313;
				if (num != 0)
				{
				}
				num = (short)1315700736;
				if (num != 0)
				{
				}
				return this.labtoolContextActivationHoldoffTimerSec;
			}
		}

		// Token: 0x17005373 RID: 21363
		// (get) Token: 0x0600A651 RID: 42577 RVA: 0x009AF35C File Offset: 0x009AD55C
		// (set) Token: 0x0600A652 RID: 42578 RVA: 0x009AF410 File Offset: 0x009AD610
		public string LabtoolContextActivationHoldoffTimerSec_UIValue
		{
			get
			{
				short num = (short)542422631;
				short num2 = num;
				num = (short)1248245351;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1371209728;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)962723841;
				if (num != 0)
				{
				}
				num = (short)832569344;
				if (num != 0)
				{
				}
				return this.labtoolContextActivationHoldoffTimerSec.UIValue;
			}
			set
			{
				short num = (short)421797147;
				short num2 = num;
				num = (short)1570774299;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1868103680;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2022178817;
				if (num != 0)
				{
				}
				num = (short)1307901952;
				if (num != 0)
				{
				}
				this.labtoolContextActivationHoldoffTimerSec.UIValue = value;
			}
		}

		// Token: 0x17005374 RID: 21364
		// (get) Token: 0x0600A653 RID: 42579 RVA: 0x009AF4C8 File Offset: 0x009AD6C8
		// (set) Token: 0x0600A654 RID: 42580 RVA: 0x009AF57C File Offset: 0x009AD77C
		internal int LabtoolContextActivationHoldoffTimerSecMin
		{
			get
			{
				short num = (short)1217267178;
				short num2 = num;
				num = (short)896796138;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1216151552;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1057947649;
				if (num != 0)
				{
				}
				num = (short)1715339264;
				if (num != 0)
				{
				}
				return this.labtoolContextActivationHoldoffTimerSec.Min;
			}
			set
			{
				short num = (short)93206649;
				short num2 = num;
				num = (short)303577209;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1103167488;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)168558593;
				if (num != 0)
				{
				}
				num = (short)1889927168;
				if (num != 0)
				{
				}
				this.labtoolContextActivationHoldoffTimerSec.Min = value;
			}
		}

		// Token: 0x17005375 RID: 21365
		// (get) Token: 0x0600A655 RID: 42581 RVA: 0x009AF634 File Offset: 0x009AD834
		// (set) Token: 0x0600A656 RID: 42582 RVA: 0x009AF6E8 File Offset: 0x009AD8E8
		internal int LabtoolContextActivationHoldoffTimerSecMax
		{
			get
			{
				short num = (short)1773326297;
				short num2 = num;
				num = (short)1001508825;
				switch (num2 == num)
				{
				default:
				{
					num = (short)967639040;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)227016705;
				if (num != 0)
				{
				}
				num = (short)292225024;
				if (num != 0)
				{
				}
				return this.labtoolContextActivationHoldoffTimerSec.Max;
			}
			set
			{
				short num = (short)225591970;
				short num2 = num;
				num = (short)1832469154;
				switch (num2 == num)
				{
				default:
				{
					num = (short)112590848;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1854603265;
				if (num != 0)
				{
				}
				num = (short)1419116544;
				if (num != 0)
				{
				}
				this.labtoolContextActivationHoldoffTimerSec.Max = value;
			}
		}

		// Token: 0x17005376 RID: 21366
		// (get) Token: 0x0600A657 RID: 42583 RVA: 0x009AF7A0 File Offset: 0x009AD9A0
		// (set) Token: 0x0600A658 RID: 42584 RVA: 0x009AF858 File Offset: 0x009ADA58
		internal int LabtoolContextActivationHoldoffTimerSecStep
		{
			get
			{
				short num = (short)1319168677;
				short num2 = num;
				num = (short)148826789;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1376387072;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)900202497;
				if (num != 0)
				{
				}
				num = (short)1269366784;
				if (num != 0)
				{
				}
				return this.labtoolContextActivationHoldoffTimerSec.StepSize;
			}
			set
			{
				short num = (short)1743817907;
				short num2 = num;
				num = (short)309169331;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1730084864;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)417529857;
				if (num != 0)
				{
				}
				num = (short)1689321472;
				if (num != 0)
				{
				}
				this.labtoolContextActivationHoldoffTimerSec.StepSize = value;
			}
		}

		// Token: 0x17005377 RID: 21367
		// (get) Token: 0x0600A659 RID: 42585 RVA: 0x009AF90C File Offset: 0x009ADB0C
		// (set) Token: 0x0600A65A RID: 42586 RVA: 0x009AF9C0 File Offset: 0x009ADBC0
		public bool LabtoolContextActivationHoldoffTimerSec_Applicable
		{
			get
			{
				short num = (short)1219747291;
				short num2 = num;
				num = (short)2089606619;
				switch (num2 == num)
				{
				default:
				{
					num = (short)321323008;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2111045633;
				if (num != 0)
				{
				}
				num = (short)1952382976;
				if (num != 0)
				{
				}
				return this.labtoolContextActivationHoldoffTimerSec.Applicable;
			}
			set
			{
				short num = (short)736886785;
				if (num != 0)
				{
				}
				num = (short)1407778816;
				short num2 = num;
				num = (short)1653124532;
				short num3 = num;
				num = (short)1048751540;
				switch (num3 == num)
				{
				}
				num = (short)541786112;
				if (num != 0)
				{
				}
				this.labtoolContextActivationHoldoffTimerSec.Applicable = value;
			}
		}

		// Token: 0x17005378 RID: 21368
		// (get) Token: 0x0600A65B RID: 42587 RVA: 0x009AFA78 File Offset: 0x009ADC78
		// (set) Token: 0x0600A65C RID: 42588 RVA: 0x009AFB2C File Offset: 0x009ADD2C
		public bool LabtoolContextActivationHoldoffTimerSec_Valid
		{
			get
			{
				short num = (short)1667920474;
				short num2 = num;
				num = (short)84046426;
				switch (num2 == num)
				{
				default:
				{
					num = (short)251068416;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1775697920;
				if (num != 0)
				{
				}
				num = (short)1764360193;
				if (num != 0)
				{
				}
				return this.labtoolContextActivationHoldoffTimerSec.Valid;
			}
			set
			{
				short num = (short)1681954289;
				short num2 = num;
				num = (short)1055036913;
				switch (num2 == num)
				{
				default:
				{
					num = (short)134873088;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1463156736;
				if (num != 0)
				{
				}
				num = (short)1373634561;
				if (num != 0)
				{
				}
				this.labtoolContextActivationHoldoffTimerSec.Valid = value;
			}
		}

		// Token: 0x17005379 RID: 21369
		// (get) Token: 0x0600A65D RID: 42589 RVA: 0x009AFBE0 File Offset: 0x009ADDE0
		// (set) Token: 0x0600A65E RID: 42590 RVA: 0x009AFC94 File Offset: 0x009ADE94
		public bool LabtoolContextActivationHoldoffTimerSec_Visible
		{
			get
			{
				short num = (short)913506305;
				if (num != 0)
				{
				}
				num = (short)1154220032;
				short num2 = num;
				num = (short)1090300139;
				short num3 = num;
				num = (short)1881909483;
				switch (num3 == num)
				{
				}
				num = (short)1388314624;
				if (num != 0)
				{
				}
				return this.labtoolContextActivationHoldoffTimerSec.Visible;
			}
			set
			{
				short num = (short)143712853;
				short num2 = num;
				num = (short)1224598101;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1727725568;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)356384769;
				if (num != 0)
				{
				}
				num = (short)476839936;
				if (num != 0)
				{
				}
				this.labtoolContextActivationHoldoffTimerSec.Visible = value;
			}
		}

		// Token: 0x1700537A RID: 21370
		// (get) Token: 0x0600A65F RID: 42591 RVA: 0x009AFD48 File Offset: 0x009ADF48
		// (set) Token: 0x0600A660 RID: 42592 RVA: 0x009AFDFC File Offset: 0x009ADFFC
		public bool LabtoolContextActivationHoldoffTimerSec_Editable
		{
			get
			{
				short num = (short)1703097612;
				short num2 = num;
				num = (short)1665611020;
				switch (num2 == num)
				{
				default:
				{
					num = (short)720633856;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)532742144;
				if (num != 0)
				{
				}
				num = (short)1957429249;
				if (num != 0)
				{
				}
				return this.labtoolContextActivationHoldoffTimerSec.Editable;
			}
			set
			{
				short num = (short)772465950;
				short num2 = num;
				num = (short)838788382;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2008547328;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)625278976;
				if (num != 0)
				{
				}
				num = (short)1350828033;
				if (num != 0)
				{
				}
				this.labtoolContextActivationHoldoffTimerSec.Editable = value;
			}
		}

		// Token: 0x1700537B RID: 21371
		// (get) Token: 0x0600A661 RID: 42593 RVA: 0x009AFEB0 File Offset: 0x009AE0B0
		internal string LabtoolContextActivationHoldoffTimerSec_UILabel
		{
			get
			{
				short num = (short)113311744;
				short num2 = num;
				num = (short)892862465;
				if (num != 0)
				{
				}
				num = (short)202358754;
				short num3 = num;
				num = (short)2022162402;
				switch (num3 == num)
				{
				}
				num = (short)2119892992;
				if (num != 0)
				{
				}
				return this.labtoolContextActivationHoldoffTimerSec.UIName;
			}
		}

		// Token: 0x1700537C RID: 21372
		// (get) Token: 0x0600A662 RID: 42594 RVA: 0x009AFF64 File Offset: 0x009AE164
		// (set) Token: 0x0600A663 RID: 42595 RVA: 0x009B0018 File Offset: 0x009AE218
		internal bool LabtoolContextActivationHoldoffTimerSec_HiddenStatic
		{
			get
			{
				short num = (short)1916534784;
				short num2 = num;
				num = (short)1426319291;
				short num3 = num;
				num = (short)289662907;
				switch (num3 == num)
				{
				}
				num = (short)148963329;
				if (num != 0)
				{
				}
				num = (short)178978816;
				if (num != 0)
				{
				}
				return this.labtoolContextActivationHoldoffTimerSec.HiddenStatic;
			}
			set
			{
				short num = (short)274399232;
				short num2 = num;
				num = (short)553023894;
				short num3 = num;
				num = (short)2073000342;
				switch (num3 == num)
				{
				}
				num = (short)2071789569;
				if (num != 0)
				{
				}
				num = (short)526647296;
				if (num != 0)
				{
				}
				this.labtoolContextActivationHoldoffTimerSec.HiddenStatic = value;
			}
		}

		// Token: 0x1700537D RID: 21373
		// (get) Token: 0x0600A664 RID: 42596 RVA: 0x009B00D0 File Offset: 0x009AE2D0
		// (set) Token: 0x0600A665 RID: 42597 RVA: 0x009B0188 File Offset: 0x009AE388
		internal bool LabtoolContextActivationHoldoffTimerSec_HiddenDynamic
		{
			get
			{
				short num = (short)357498880;
				short num2 = num;
				num = (short)1343955913;
				short num3 = num;
				num = (short)394077129;
				switch (num3 == num)
				{
				}
				num = (short)1569914880;
				if (num != 0)
				{
				}
				num = (short)1266417665;
				if (num != 0)
				{
				}
				return this.labtoolContextActivationHoldoffTimerSec.HiddenDynamic;
			}
			set
			{
				short num = (short)1386283008;
				short num2 = num;
				num = (short)1160126761;
				short num3 = num;
				num = (short)1735926057;
				switch (num3 == num)
				{
				}
				num = (short)1760034817;
				if (num != 0)
				{
				}
				num = (short)40566784;
				if (num != 0)
				{
				}
				this.labtoolContextActivationHoldoffTimerSec.HiddenDynamic = value;
			}
		}

		// Token: 0x1700537E RID: 21374
		// (get) Token: 0x0600A666 RID: 42598 RVA: 0x009B0240 File Offset: 0x009AE440
		public bool LabtoolContextActivationHoldoffTimerSec_HasDiffs
		{
			get
			{
				short num = (short)994181120;
				short num2 = num;
				num = (short)1223541349;
				short num3 = num;
				num = (short)236700261;
				switch (num3 == num)
				{
				}
				num = (short)513146880;
				if (num != 0)
				{
				}
				num = (short)1672544257;
				if (num != 0)
				{
				}
				return this.labtoolContextActivationHoldoffTimerSec._HasDiffs;
			}
		}

		// Token: 0x1700537F RID: 21375
		// (get) Token: 0x0600A667 RID: 42599 RVA: 0x009B02F4 File Offset: 0x009AE4F4
		// (set) Token: 0x0600A668 RID: 42600 RVA: 0x009B03A8 File Offset: 0x009AE5A8
		public int DataWideLabtoolDATA_CFGOTAPDefaultInactivityTimer_A8668Value
		{
			get
			{
				short num = (short)2056060928;
				short num2 = num;
				num = (short)1359299872;
				short num3 = num;
				num = (short)175523104;
				switch (num3 == num)
				{
				}
				num = (short)1503854593;
				if (num != 0)
				{
				}
				num = (short)1364787200;
				if (num != 0)
				{
				}
				return this.dataWideLabtoolDATA_CFGOTAPDefaultInactivityTimer_A8668.Value;
			}
			set
			{
				short num = (short)1119289344;
				short num2 = num;
				num = (short)1274685612;
				short num3 = num;
				num = (short)958802092;
				switch (num3 == num)
				{
				}
				num = (short)1689190401;
				if (num != 0)
				{
				}
				num = (short)201850880;
				if (num != 0)
				{
				}
				this.dataWideLabtoolDATA_CFGOTAPDefaultInactivityTimer_A8668.Value = value;
			}
		}

		// Token: 0x17005380 RID: 21376
		// (get) Token: 0x0600A669 RID: 42601 RVA: 0x009B045C File Offset: 0x009AE65C
		public global::AcpBusinessLayer.AcpSimpleRangeField DataWideLabtoolDATA_CFGOTAPDefaultInactivityTimer_A8668
		{
			get
			{
				short num = (short)808910848;
				short num2 = num;
				num = (short)1243048736;
				short num3 = num;
				num = (short)1431464736;
				switch (num3 == num)
				{
				}
				num = (short)38404096;
				if (num != 0)
				{
				}
				num = (short)653131777;
				if (num != 0)
				{
				}
				return this.dataWideLabtoolDATA_CFGOTAPDefaultInactivityTimer_A8668;
			}
		}

		// Token: 0x17005381 RID: 21377
		// (get) Token: 0x0600A66A RID: 42602 RVA: 0x009B050C File Offset: 0x009AE70C
		// (set) Token: 0x0600A66B RID: 42603 RVA: 0x009B05C0 File Offset: 0x009AE7C0
		public string DataWideLabtoolDATA_CFGOTAPDefaultInactivityTimer_A8668_UIValue
		{
			get
			{
				short num = (short)857866240;
				short num2 = num;
				num = (short)946536449;
				if (num != 0)
				{
				}
				num = (short)15514775;
				short num3 = num;
				num = (short)597212311;
				switch (num3 == num)
				{
				}
				num = (short)1999568896;
				if (num != 0)
				{
				}
				return this.dataWideLabtoolDATA_CFGOTAPDefaultInactivityTimer_A8668.UIValue;
			}
			set
			{
				short num = (short)1660354560;
				short num2 = num;
				num = (short)797286748;
				short num3 = num;
				num = (short)1218814300;
				switch (num3 == num)
				{
				}
				num = (short)1690894336;
				if (num != 0)
				{
				}
				num = (short)809893889;
				if (num != 0)
				{
				}
				this.dataWideLabtoolDATA_CFGOTAPDefaultInactivityTimer_A8668.UIValue = value;
			}
		}

		// Token: 0x17005382 RID: 21378
		// (get) Token: 0x0600A66C RID: 42604 RVA: 0x009B0678 File Offset: 0x009AE878
		// (set) Token: 0x0600A66D RID: 42605 RVA: 0x009B072C File Offset: 0x009AE92C
		internal int DataWideLabtoolDATA_CFGOTAPDefaultInactivityTimer_A8668Min
		{
			get
			{
				short num = (short)169410560;
				short num2 = num;
				num = (short)860291073;
				if (num != 0)
				{
				}
				num = (short)445739395;
				short num3 = num;
				num = (short)139293059;
				switch (num3 == num)
				{
				}
				num = (short)678100992;
				if (num != 0)
				{
				}
				return this.dataWideLabtoolDATA_CFGOTAPDefaultInactivityTimer_A8668.Min;
			}
			set
			{
				short num = (short)137756672;
				short num2 = num;
				num = (short)477063125;
				short num3 = num;
				num = (short)1002792917;
				switch (num3 == num)
				{
				}
				num = (short)400293889;
				if (num != 0)
				{
				}
				num = (short)98762752;
				if (num != 0)
				{
				}
				this.dataWideLabtoolDATA_CFGOTAPDefaultInactivityTimer_A8668.Min = value;
			}
		}

		// Token: 0x17005383 RID: 21379
		// (get) Token: 0x0600A66E RID: 42606 RVA: 0x009B07E4 File Offset: 0x009AE9E4
		// (set) Token: 0x0600A66F RID: 42607 RVA: 0x009B089C File Offset: 0x009AEA9C
		internal int DataWideLabtoolDATA_CFGOTAPDefaultInactivityTimer_A8668Max
		{
			get
			{
				short num = (short)911409152;
				short num2 = num;
				num = (short)284848408;
				short num3 = num;
				num = (short)2102554904;
				switch (num3 == num)
				{
				}
				num = (short)65732609;
				if (num != 0)
				{
				}
				num = (short)761659392;
				if (num != 0)
				{
				}
				return this.dataWideLabtoolDATA_CFGOTAPDefaultInactivityTimer_A8668.Max;
			}
			set
			{
				short num = (short)1636433920;
				short num2 = num;
				num = (short)12655870;
				short num3 = num;
				num = (short)925637886;
				switch (num3 == num)
				{
				}
				num = (short)654770176;
				if (num != 0)
				{
				}
				num = (short)1176698881;
				if (num != 0)
				{
				}
				this.dataWideLabtoolDATA_CFGOTAPDefaultInactivityTimer_A8668.Max = value;
			}
		}

		// Token: 0x17005384 RID: 21380
		// (get) Token: 0x0600A670 RID: 42608 RVA: 0x009B0950 File Offset: 0x009AEB50
		// (set) Token: 0x0600A671 RID: 42609 RVA: 0x009B0A08 File Offset: 0x009AEC08
		internal int DataWideLabtoolDATA_CFGOTAPDefaultInactivityTimer_A8668Step
		{
			get
			{
				short num = (short)613023744;
				short num2 = num;
				num = (short)1821816248;
				short num3 = num;
				num = (short)1772598712;
				switch (num3 == num)
				{
				}
				num = (short)596705281;
				if (num != 0)
				{
				}
				num = (short)574226432;
				if (num != 0)
				{
				}
				return this.dataWideLabtoolDATA_CFGOTAPDefaultInactivityTimer_A8668.StepSize;
			}
			set
			{
				short num = (short)793772032;
				short num2 = num;
				num = (short)1605767011;
				short num3 = num;
				num = (short)1023283043;
				switch (num3 == num)
				{
				}
				num = (short)1058603008;
				if (num != 0)
				{
				}
				num = (short)1874526209;
				if (num != 0)
				{
				}
				this.dataWideLabtoolDATA_CFGOTAPDefaultInactivityTimer_A8668.StepSize = value;
			}
		}

		// Token: 0x17005385 RID: 21381
		// (get) Token: 0x0600A672 RID: 42610 RVA: 0x009B0ABC File Offset: 0x009AECBC
		// (set) Token: 0x0600A673 RID: 42611 RVA: 0x009B0B70 File Offset: 0x009AED70
		public bool DataWideLabtoolDATA_CFGOTAPDefaultInactivityTimer_A8668_Applicable
		{
			get
			{
				short num = (short)1688207360;
				short num2 = num;
				num = (short)633862163;
				short num3 = num;
				num = (short)1150023699;
				switch (num3 == num)
				{
				}
				num = (short)1232994305;
				if (num != 0)
				{
				}
				num = (short)1955332096;
				if (num != 0)
				{
				}
				return this.dataWideLabtoolDATA_CFGOTAPDefaultInactivityTimer_A8668.Applicable;
			}
			set
			{
				short num = (short)1584857088;
				short num2 = num;
				num = (short)2143187603;
				short num3 = num;
				num = (short)1548645011;
				switch (num3 == num)
				{
				}
				num = (short)739246081;
				if (num != 0)
				{
				}
				num = (short)2228224;
				if (num != 0)
				{
				}
				this.dataWideLabtoolDATA_CFGOTAPDefaultInactivityTimer_A8668.Applicable = value;
			}
		}

		// Token: 0x17005386 RID: 21382
		// (get) Token: 0x0600A674 RID: 42612 RVA: 0x009B0C24 File Offset: 0x009AEE24
		// (set) Token: 0x0600A675 RID: 42613 RVA: 0x009B0CD8 File Offset: 0x009AEED8
		public bool DataWideLabtoolDATA_CFGOTAPDefaultInactivityTimer_A8668_Valid
		{
			get
			{
				short num = (short)953417728;
				short num2 = num;
				num = (short)431120446;
				short num3 = num;
				num = (short)2074435646;
				switch (num3 == num)
				{
				}
				num = (short)1772552193;
				if (num != 0)
				{
				}
				num = (short)1863450624;
				if (num != 0)
				{
				}
				return this.dataWideLabtoolDATA_CFGOTAPDefaultInactivityTimer_A8668.Valid;
			}
			set
			{
				short num = (short)934739968;
				short num2 = num;
				num = (short)678716171;
				short num3 = num;
				num = (short)1836606219;
				switch (num3 == num)
				{
				}
				num = (short)1883176961;
				if (num != 0)
				{
				}
				num = (short)384434176;
				if (num != 0)
				{
				}
				this.dataWideLabtoolDATA_CFGOTAPDefaultInactivityTimer_A8668.Valid = value;
			}
		}

		// Token: 0x17005387 RID: 21383
		// (get) Token: 0x0600A676 RID: 42614 RVA: 0x009B0D90 File Offset: 0x009AEF90
		// (set) Token: 0x0600A677 RID: 42615 RVA: 0x009B0E44 File Offset: 0x009AF044
		public bool DataWideLabtoolDATA_CFGOTAPDefaultInactivityTimer_A8668_Visible
		{
			get
			{
				short num = (short)867696640;
				short num2 = num;
				num = (short)1053250970;
				short num3 = num;
				num = (short)1255363994;
				switch (num3 == num)
				{
				}
				num = (short)1968570369;
				if (num != 0)
				{
				}
				num = (short)1562574848;
				if (num != 0)
				{
				}
				return this.dataWideLabtoolDATA_CFGOTAPDefaultInactivityTimer_A8668.Visible;
			}
			set
			{
				short num = (short)1425080320;
				short num2 = num;
				num = (short)841358354;
				short num3 = num;
				num = (short)623844370;
				switch (num3 == num)
				{
				}
				num = (short)1134493697;
				if (num != 0)
				{
				}
				num = (short)1545207808;
				if (num != 0)
				{
				}
				this.dataWideLabtoolDATA_CFGOTAPDefaultInactivityTimer_A8668.Visible = value;
			}
		}

		// Token: 0x17005388 RID: 21384
		// (get) Token: 0x0600A678 RID: 42616 RVA: 0x009B0EFC File Offset: 0x009AF0FC
		// (set) Token: 0x0600A679 RID: 42617 RVA: 0x009B0FB0 File Offset: 0x009AF1B0
		public bool DataWideLabtoolDATA_CFGOTAPDefaultInactivityTimer_A8668_Editable
		{
			get
			{
				short num = (short)2045575168;
				short num2 = num;
				num = (short)525795329;
				if (num != 0)
				{
				}
				num = (short)1731312879;
				short num3 = num;
				num = (short)367246575;
				switch (num3 == num)
				{
				}
				num = (short)1974665216;
				if (num != 0)
				{
				}
				return this.dataWideLabtoolDATA_CFGOTAPDefaultInactivityTimer_A8668.Editable;
			}
			set
			{
				short num = (short)1893466112;
				short num2 = num;
				num = (short)139654711;
				short num3 = num;
				num = (short)738653751;
				switch (num3 == num)
				{
				}
				num = (short)2055929857;
				if (num != 0)
				{
				}
				num = (short)2129133568;
				if (num != 0)
				{
				}
				this.dataWideLabtoolDATA_CFGOTAPDefaultInactivityTimer_A8668.Editable = value;
			}
		}

		// Token: 0x17005389 RID: 21385
		// (get) Token: 0x0600A67A RID: 42618 RVA: 0x009B1064 File Offset: 0x009AF264
		internal string DataWideLabtoolDATA_CFGOTAPDefaultInactivityTimer_A8668_UILabel
		{
			get
			{
				short num = (short)437518336;
				short num2 = num;
				num = (short)1718758658;
				short num3 = num;
				num = (short)523382018;
				switch (num3 == num)
				{
				}
				num = (short)718274561;
				if (num != 0)
				{
				}
				num = (short)1295974400;
				if (num != 0)
				{
				}
				return this.dataWideLabtoolDATA_CFGOTAPDefaultInactivityTimer_A8668.UIName;
			}
		}

		// Token: 0x1700538A RID: 21386
		// (get) Token: 0x0600A67B RID: 42619 RVA: 0x009B111C File Offset: 0x009AF31C
		// (set) Token: 0x0600A67C RID: 42620 RVA: 0x009B11D0 File Offset: 0x009AF3D0
		internal bool DataWideLabtoolDATA_CFGOTAPDefaultInactivityTimer_A8668_HiddenStatic
		{
			get
			{
				short num = (short)1460535296;
				short num2 = num;
				num = (short)181981680;
				short num3 = num;
				num = (short)1712574960;
				switch (num3 == num)
				{
				}
				num = (short)1140457473;
				if (num != 0)
				{
				}
				num = (short)2135293952;
				if (num != 0)
				{
				}
				return this.dataWideLabtoolDATA_CFGOTAPDefaultInactivityTimer_A8668.HiddenStatic;
			}
			set
			{
				short num = (short)1343946752;
				short num2 = num;
				num = (short)1115542441;
				short num3 = num;
				num = (short)881775529;
				switch (num3 == num)
				{
				}
				num = (short)1929510912;
				if (num != 0)
				{
				}
				num = (short)1636040705;
				if (num != 0)
				{
				}
				this.dataWideLabtoolDATA_CFGOTAPDefaultInactivityTimer_A8668.HiddenStatic = value;
			}
		}

		// Token: 0x1700538B RID: 21387
		// (get) Token: 0x0600A67D RID: 42621 RVA: 0x009B1284 File Offset: 0x009AF484
		// (set) Token: 0x0600A67E RID: 42622 RVA: 0x009B1334 File Offset: 0x009AF534
		internal bool DataWideLabtoolDATA_CFGOTAPDefaultInactivityTimer_A8668_HiddenDynamic
		{
			get
			{
				short num = (short)1107099648;
				short num2 = num;
				num = (short)583317815;
				short num3 = num;
				num = (short)59619639;
				switch (num3 == num)
				{
				}
				num = (short)1223688193;
				if (num != 0)
				{
				}
				num = (short)763297792;
				if (num != 0)
				{
				}
				return this.dataWideLabtoolDATA_CFGOTAPDefaultInactivityTimer_A8668.HiddenDynamic;
			}
			set
			{
				short num = (short)978714624;
				short num2 = num;
				num = (short)1426807294;
				short num3 = num;
				num = (short)178543102;
				switch (num3 == num)
				{
				}
				num = (short)1280180225;
				if (num != 0)
				{
				}
				num = (short)2026504192;
				if (num != 0)
				{
				}
				this.dataWideLabtoolDATA_CFGOTAPDefaultInactivityTimer_A8668.HiddenDynamic = value;
			}
		}

		// Token: 0x1700538C RID: 21388
		// (get) Token: 0x0600A67F RID: 42623 RVA: 0x009B13EC File Offset: 0x009AF5EC
		public bool DataWideLabtoolDATA_CFGOTAPDefaultInactivityTimer_A8668_HasDiffs
		{
			get
			{
				short num = (short)1877934080;
				short num2 = num;
				num = (short)1221179358;
				short num3 = num;
				num = (short)654424030;
				switch (num3 == num)
				{
				}
				num = (short)1010499584;
				if (num != 0)
				{
				}
				num = (short)2053701633;
				if (num != 0)
				{
				}
				return this.dataWideLabtoolDATA_CFGOTAPDefaultInactivityTimer_A8668._HasDiffs;
			}
		}

		// Token: 0x1700538D RID: 21389
		// (get) Token: 0x0600A680 RID: 42624 RVA: 0x009B14A0 File Offset: 0x009AF6A0
		// (set) Token: 0x0600A681 RID: 42625 RVA: 0x009B1550 File Offset: 0x009AF750
		public int LabtoolContextRenewalTimerMinValue
		{
			get
			{
				short num = (short)1124007936;
				short num2 = num;
				num = (short)430401882;
				short num3 = num;
				num = (short)1656121690;
				switch (num3 == num)
				{
				}
				num = (short)1243348993;
				if (num != 0)
				{
				}
				num = (short)1191378944;
				if (num != 0)
				{
				}
				return this.labtoolContextRenewalTimerMin.Value;
			}
			set
			{
				short num = (short)1419378688;
				short num2 = num;
				num = (short)1907019138;
				short num3 = num;
				num = (short)1745145218;
				switch (num3 == num)
				{
				}
				num = (short)1608056833;
				if (num != 0)
				{
				}
				num = (short)997523456;
				if (num != 0)
				{
				}
				this.labtoolContextRenewalTimerMin.Value = value;
			}
		}

		// Token: 0x1700538E RID: 21390
		// (get) Token: 0x0600A682 RID: 42626 RVA: 0x009B1604 File Offset: 0x009AF804
		public global::AcpBusinessLayer.AcpSimpleRangeField LabtoolContextRenewalTimerMin
		{
			get
			{
				short num = (short)446889984;
				short num2 = num;
				num = (short)1998630060;
				short num3 = num;
				num = (short)1148431532;
				switch (num3 == num)
				{
				}
				num = (short)1673003009;
				if (num != 0)
				{
				}
				num = (short)864354304;
				if (num != 0)
				{
				}
				return this.labtoolContextRenewalTimerMin;
			}
		}

		// Token: 0x1700538F RID: 21391
		// (get) Token: 0x0600A683 RID: 42627 RVA: 0x009B16B4 File Offset: 0x009AF8B4
		// (set) Token: 0x0600A684 RID: 42628 RVA: 0x009B176C File Offset: 0x009AF96C
		public string LabtoolContextRenewalTimerMin_UIValue
		{
			get
			{
				short num = (short)1831796736;
				short num2 = num;
				num = (short)1320138823;
				short num3 = num;
				num = (short)1665841223;
				switch (num3 == num)
				{
				}
				num = (short)1676607489;
				if (num != 0)
				{
				}
				num = (short)1394147328;
				if (num != 0)
				{
				}
				return this.labtoolContextRenewalTimerMin.UIValue;
			}
			set
			{
				short num = (short)1895038976;
				short num2 = num;
				num = (short)1817059670;
				short num3 = num;
				num = (short)754524502;
				switch (num3 == num)
				{
				}
				num = (short)1920794625;
				if (num != 0)
				{
				}
				num = (short)1950613504;
				if (num != 0)
				{
				}
				this.labtoolContextRenewalTimerMin.UIValue = value;
			}
		}

		// Token: 0x17005390 RID: 21392
		// (get) Token: 0x0600A685 RID: 42629 RVA: 0x009B1824 File Offset: 0x009AFA24
		// (set) Token: 0x0600A686 RID: 42630 RVA: 0x009B18D8 File Offset: 0x009AFAD8
		internal int LabtoolContextRenewalTimerMinMin
		{
			get
			{
				short num = (short)1228865536;
				short num2 = num;
				num = (short)199195728;
				short num3 = num;
				num = (short)57310288;
				switch (num3 == num)
				{
				}
				num = (short)1825177601;
				if (num != 0)
				{
				}
				num = (short)691863552;
				if (num != 0)
				{
				}
				return this.labtoolContextRenewalTimerMin.Min;
			}
			set
			{
				short num = (short)65273856;
				short num2 = num;
				num = (short)1004363822;
				short num3 = num;
				num = (short)1142841390;
				switch (num3 == num)
				{
				}
				num = (short)649723904;
				if (num != 0)
				{
				}
				num = (short)1911554049;
				if (num != 0)
				{
				}
				this.labtoolContextRenewalTimerMin.Min = value;
			}
		}

		// Token: 0x17005391 RID: 21393
		// (get) Token: 0x0600A687 RID: 42631 RVA: 0x009B1990 File Offset: 0x009AFB90
		// (set) Token: 0x0600A688 RID: 42632 RVA: 0x009B1A4C File Offset: 0x009AFC4C
		internal int LabtoolContextRenewalTimerMinMax
		{
			get
			{
				short num = (short)494010368;
				short num2 = num;
				num = (short)37355521;
				if (num != 0)
				{
				}
				num = (short)1354938511;
				short num3 = num;
				num = (short)1255979151;
				switch (num3 == num)
				{
				}
				num = (short)1724383232;
				if (num != 0)
				{
				}
				return this.labtoolContextRenewalTimerMin.Max;
			}
			set
			{
				short num = (short)1313406976;
				short num2 = num;
				num = (short)937030658;
				short num3 = num;
				num = (short)379515906;
				switch (num3 == num)
				{
				}
				num = (short)1803157504;
				if (num != 0)
				{
				}
				num = (short)1447952385;
				if (num != 0)
				{
				}
				this.labtoolContextRenewalTimerMin.Max = value;
			}
		}

		// Token: 0x17005392 RID: 21394
		// (get) Token: 0x0600A689 RID: 42633 RVA: 0x009B1B04 File Offset: 0x009AFD04
		// (set) Token: 0x0600A68A RID: 42634 RVA: 0x009B1BB8 File Offset: 0x009AFDB8
		internal int LabtoolContextRenewalTimerMinStep
		{
			get
			{
				short num = (short)844300288;
				short num2 = num;
				num = (short)136042490;
				short num3 = num;
				num = (short)302438394;
				switch (num3 == num)
				{
				}
				num = (short)1412300801;
				if (num != 0)
				{
				}
				num = (short)1094385664;
				if (num != 0)
				{
				}
				return this.labtoolContextRenewalTimerMin.StepSize;
			}
			set
			{
				short num = (short)75104256;
				short num2 = num;
				num = (short)425123133;
				short num3 = num;
				num = (short)2134564157;
				switch (num3 == num)
				{
				}
				num = (short)606601216;
				if (num != 0)
				{
				}
				num = (short)1319174145;
				if (num != 0)
				{
				}
				this.labtoolContextRenewalTimerMin.StepSize = value;
			}
		}

		// Token: 0x17005393 RID: 21395
		// (get) Token: 0x0600A68B RID: 42635 RVA: 0x009B1C70 File Offset: 0x009AFE70
		// (set) Token: 0x0600A68C RID: 42636 RVA: 0x009B1D28 File Offset: 0x009AFF28
		public bool LabtoolContextRenewalTimerMin_Applicable
		{
			get
			{
				short num = (short)1270874112;
				short num2 = num;
				num = (short)1319619929;
				short num3 = num;
				num = (short)1852493145;
				switch (num3 == num)
				{
				}
				num = (short)117768193;
				if (num != 0)
				{
				}
				num = (short)2115305472;
				if (num != 0)
				{
				}
				return this.labtoolContextRenewalTimerMin.Applicable;
			}
			set
			{
				short num = (short)677576704;
				short num2 = num;
				num = (short)1690309442;
				short num3 = num;
				num = (short)709890882;
				switch (num3 == num)
				{
				}
				num = (short)1774845953;
				if (num != 0)
				{
				}
				num = (short)695205888;
				if (num != 0)
				{
				}
				this.labtoolContextRenewalTimerMin.Applicable = value;
			}
		}

		// Token: 0x17005394 RID: 21396
		// (get) Token: 0x0600A68D RID: 42637 RVA: 0x009B1DE0 File Offset: 0x009AFFE0
		// (set) Token: 0x0600A68E RID: 42638 RVA: 0x009B1E94 File Offset: 0x009B0094
		public bool LabtoolContextRenewalTimerMin_Valid
		{
			get
			{
				short num = (short)1589641216;
				short num2 = num;
				num = (short)288530757;
				short num3 = num;
				num = (short)588357957;
				switch (num3 == num)
				{
				}
				num = (short)1453719553;
				if (num != 0)
				{
				}
				num = (short)1156644864;
				if (num != 0)
				{
				}
				return this.labtoolContextRenewalTimerMin.Valid;
			}
			set
			{
				short num = (short)1262092288;
				short num2 = num;
				num = (short)48658722;
				short num3 = num;
				num = (short)357136674;
				switch (num3 == num)
				{
				}
				num = (short)2086600705;
				if (num != 0)
				{
				}
				num = (short)1831206912;
				if (num != 0)
				{
				}
				this.labtoolContextRenewalTimerMin.Valid = value;
			}
		}

		// Token: 0x17005395 RID: 21397
		// (get) Token: 0x0600A68F RID: 42639 RVA: 0x009B1F48 File Offset: 0x009B0148
		// (set) Token: 0x0600A690 RID: 42640 RVA: 0x009B1FFC File Offset: 0x009B01FC
		public bool LabtoolContextRenewalTimerMin_Visible
		{
			get
			{
				short num = (short)218693632;
				short num2 = num;
				num = (short)1739859166;
				short num3 = num;
				num = (short)610608350;
				switch (num3 == num)
				{
				}
				num = (short)124518400;
				if (num != 0)
				{
				}
				num = (short)314048513;
				if (num != 0)
				{
				}
				return this.labtoolContextRenewalTimerMin.Visible;
			}
			set
			{
				short num = (short)2074083328;
				short num2 = num;
				num = (short)1232235715;
				short num3 = num;
				num = (short)1326607555;
				switch (num3 == num)
				{
				}
				num = (short)1924333569;
				if (num != 0)
				{
				}
				num = (short)1394343936;
				if (num != 0)
				{
				}
				this.labtoolContextRenewalTimerMin.Visible = value;
			}
		}

		// Token: 0x17005396 RID: 21398
		// (get) Token: 0x0600A691 RID: 42641 RVA: 0x009B20B0 File Offset: 0x009B02B0
		// (set) Token: 0x0600A692 RID: 42642 RVA: 0x009B2164 File Offset: 0x009B0364
		public bool LabtoolContextRenewalTimerMin_Editable
		{
			get
			{
				short num = (short)525205504;
				short num2 = num;
				num = (short)1554747573;
				short num3 = num;
				num = (short)80253109;
				switch (num3 == num)
				{
				}
				num = (short)1074987009;
				if (num != 0)
				{
				}
				num = (short)1469317120;
				if (num != 0)
				{
				}
				return this.labtoolContextRenewalTimerMin.Editable;
			}
			set
			{
				short num = (short)2021720064;
				short num2 = num;
				num = (short)831241377;
				short num3 = num;
				num = (short)2001910945;
				switch (num3 == num)
				{
				}
				num = (short)849412097;
				if (num != 0)
				{
				}
				num = (short)96731136;
				if (num != 0)
				{
				}
				this.labtoolContextRenewalTimerMin.Editable = value;
			}
		}

		// Token: 0x17005397 RID: 21399
		// (get) Token: 0x0600A693 RID: 42643 RVA: 0x009B2218 File Offset: 0x009B0418
		internal string LabtoolContextRenewalTimerMin_UILabel
		{
			get
			{
				short num = (short)2099838976;
				short num2 = num;
				num = (short)1549698702;
				short num3 = num;
				num = (short)388335246;
				switch (num3 == num)
				{
				}
				num = (short)750845952;
				if (num != 0)
				{
				}
				num = (short)2008678401;
				if (num != 0)
				{
				}
				return this.labtoolContextRenewalTimerMin.UIName;
			}
		}

		// Token: 0x17005398 RID: 21400
		// (get) Token: 0x0600A694 RID: 42644 RVA: 0x009B22CC File Offset: 0x009B04CC
		// (set) Token: 0x0600A695 RID: 42645 RVA: 0x009B2380 File Offset: 0x009B0580
		internal bool LabtoolContextRenewalTimerMin_HiddenStatic
		{
			get
			{
				short num = (short)1932394496;
				short num2 = num;
				num = (short)888910040;
				short num3 = num;
				num = (short)523612376;
				switch (num3 == num)
				{
				}
				num = (short)2090729473;
				if (num != 0)
				{
				}
				num = (short)68812800;
				if (num != 0)
				{
				}
				return this.labtoolContextRenewalTimerMin.HiddenStatic;
			}
			set
			{
				short num = (short)1913585664;
				short num2 = num;
				num = (short)1330737089;
				short num3 = num;
				num = (short)390426561;
				switch (num3 == num)
				{
				}
				num = (short)413925376;
				if (num != 0)
				{
				}
				num = (short)1186791425;
				if (num != 0)
				{
				}
				this.labtoolContextRenewalTimerMin.HiddenStatic = value;
			}
		}

		// Token: 0x17005399 RID: 21401
		// (get) Token: 0x0600A696 RID: 42646 RVA: 0x009B2434 File Offset: 0x009B0634
		// (set) Token: 0x0600A697 RID: 42647 RVA: 0x009B24E8 File Offset: 0x009B06E8
		internal bool LabtoolContextRenewalTimerMin_HiddenDynamic
		{
			get
			{
				short num = (short)2001928192;
				short num2 = num;
				num = (short)576115918;
				short num3 = num;
				num = (short)1917768910;
				switch (num3 == num)
				{
				}
				num = (short)799145985;
				if (num != 0)
				{
				}
				num = (short)595197952;
				if (num != 0)
				{
				}
				return this.labtoolContextRenewalTimerMin.HiddenDynamic;
			}
			set
			{
				short num = (short)1678901248;
				short num2 = num;
				num = (short)1637384722;
				short num3 = num;
				num = (short)762348050;
				switch (num3 == num)
				{
				}
				num = (short)1763835904;
				if (num != 0)
				{
				}
				num = (short)726335489;
				if (num != 0)
				{
				}
				this.labtoolContextRenewalTimerMin.HiddenDynamic = value;
			}
		}

		// Token: 0x1700539A RID: 21402
		// (get) Token: 0x0600A698 RID: 42648 RVA: 0x009B259C File Offset: 0x009B079C
		public bool LabtoolContextRenewalTimerMin_HasDiffs
		{
			get
			{
				short num = (short)1745747968;
				short num2 = num;
				num = (short)660302408;
				short num3 = num;
				num = (short)890399304;
				switch (num3 == num)
				{
				}
				num = (short)278659073;
				if (num != 0)
				{
				}
				num = (short)41877504;
				if (num != 0)
				{
				}
				return this.labtoolContextRenewalTimerMin._HasDiffs;
			}
		}

		// Token: 0x1700539B RID: 21403
		// (get) Token: 0x0600A699 RID: 42649 RVA: 0x009B2650 File Offset: 0x009B0850
		// (set) Token: 0x0600A69A RID: 42650 RVA: 0x009B2704 File Offset: 0x009B0904
		public int DataWideLabtoolDATA_CFGPacketDataActivateWaitTimerSec_A8686Value
		{
			get
			{
				short num = (short)1423179776;
				short num2 = num;
				num = (short)1360841640;
				short num3 = num;
				num = (short)2010368936;
				switch (num3 == num)
				{
				}
				num = (short)132448257;
				if (num != 0)
				{
				}
				num = (short)893452288;
				if (num != 0)
				{
				}
				return this.dataWideLabtoolDATA_CFGPacketDataActivateWaitTimerSec_A8686.Value;
			}
			set
			{
				short num = (short)1523712000;
				short num2 = num;
				num = (short)1829092518;
				short num3 = num;
				num = (short)2108341414;
				switch (num3 == num)
				{
				}
				num = (short)1526988801;
				if (num != 0)
				{
				}
				num = (short)1458765824;
				if (num != 0)
				{
				}
				this.dataWideLabtoolDATA_CFGPacketDataActivateWaitTimerSec_A8686.Value = value;
			}
		}

		// Token: 0x1700539C RID: 21404
		// (get) Token: 0x0600A69B RID: 42651 RVA: 0x009B27BC File Offset: 0x009B09BC
		public global::AcpBusinessLayer.AcpSimpleRangeField DataWideLabtoolDATA_CFGPacketDataActivateWaitTimerSec_A8686
		{
			get
			{
				short num = (short)1921974272;
				short num2 = num;
				num = (short)710225297;
				short num3 = num;
				num = (short)156315025;
				switch (num3 == num)
				{
				}
				num = (short)610533377;
				if (num != 0)
				{
				}
				num = (short)1324679168;
				if (num != 0)
				{
				}
				return this.dataWideLabtoolDATA_CFGPacketDataActivateWaitTimerSec_A8686;
			}
		}

		// Token: 0x1700539D RID: 21405
		// (get) Token: 0x0600A69C RID: 42652 RVA: 0x009B2868 File Offset: 0x009B0A68
		// (set) Token: 0x0600A69D RID: 42653 RVA: 0x009B291C File Offset: 0x009B0B1C
		public string DataWideLabtoolDATA_CFGPacketDataActivateWaitTimerSec_A8686_UIValue
		{
			get
			{
				short num = (short)1111949312;
				short num2 = num;
				num = (short)1636499457;
				if (num != 0)
				{
				}
				num = (short)256242727;
				short num3 = num;
				num = (short)1245639719;
				switch (num3 == num)
				{
				}
				num = (short)1161166848;
				if (num != 0)
				{
				}
				return this.dataWideLabtoolDATA_CFGPacketDataActivateWaitTimerSec_A8686.UIValue;
			}
			set
			{
				short num = (short)120651776;
				short num2 = num;
				num = (short)994373748;
				short num3 = num;
				num = (short)1236725876;
				switch (num3 == num)
				{
				}
				num = (short)1284046849;
				if (num != 0)
				{
				}
				num = (short)393936896;
				if (num != 0)
				{
				}
				this.dataWideLabtoolDATA_CFGPacketDataActivateWaitTimerSec_A8686.UIValue = value;
			}
		}

		// Token: 0x1700539E RID: 21406
		// (get) Token: 0x0600A69E RID: 42654 RVA: 0x009B29D4 File Offset: 0x009B0BD4
		// (set) Token: 0x0600A69F RID: 42655 RVA: 0x009B2A8C File Offset: 0x009B0C8C
		internal int DataWideLabtoolDATA_CFGPacketDataActivateWaitTimerSec_A8686Min
		{
			get
			{
				short num = (short)1279590400;
				short num2 = num;
				num = (short)329150839;
				short num3 = num;
				num = (short)161444215;
				switch (num3 == num)
				{
				}
				num = (short)1010040833;
				if (num != 0)
				{
				}
				num = (short)763822080;
				if (num != 0)
				{
				}
				return this.dataWideLabtoolDATA_CFGPacketDataActivateWaitTimerSec_A8686.Min;
			}
			set
			{
				short num = (short)1948385280;
				short num2 = num;
				num = (short)484798325;
				short num3 = num;
				num = (short)1900506997;
				switch (num3 == num)
				{
				}
				num = (short)317128705;
				if (num != 0)
				{
				}
				num = (short)1579483136;
				if (num != 0)
				{
				}
				this.dataWideLabtoolDATA_CFGPacketDataActivateWaitTimerSec_A8686.Min = value;
			}
		}

		// Token: 0x1700539F RID: 21407
		// (get) Token: 0x0600A6A0 RID: 42656 RVA: 0x009B2B44 File Offset: 0x009B0D44
		// (set) Token: 0x0600A6A1 RID: 42657 RVA: 0x009B2BF8 File Offset: 0x009B0DF8
		internal int DataWideLabtoolDATA_CFGPacketDataActivateWaitTimerSec_A8686Max
		{
			get
			{
				short num = (short)2055274496;
				short num2 = num;
				num = (short)1470370081;
				short num3 = num;
				num = (short)588124449;
				switch (num3 == num)
				{
				}
				num = (short)898695169;
				if (num != 0)
				{
				}
				num = (short)1431437312;
				if (num != 0)
				{
				}
				return this.dataWideLabtoolDATA_CFGPacketDataActivateWaitTimerSec_A8686.Max;
			}
			set
			{
				short num = (short)824311808;
				short num2 = num;
				num = (short)264504505;
				short num3 = num;
				num = (short)561906873;
				switch (num3 == num)
				{
				}
				num = (short)35454977;
				if (num != 0)
				{
				}
				num = (short)367263744;
				if (num != 0)
				{
				}
				this.dataWideLabtoolDATA_CFGPacketDataActivateWaitTimerSec_A8686.Max = value;
			}
		}

		// Token: 0x170053A0 RID: 21408
		// (get) Token: 0x0600A6A2 RID: 42658 RVA: 0x009B2CAC File Offset: 0x009B0EAC
		// (set) Token: 0x0600A6A3 RID: 42659 RVA: 0x009B2D60 File Offset: 0x009B0F60
		internal int DataWideLabtoolDATA_CFGPacketDataActivateWaitTimerSec_A8686Step
		{
			get
			{
				short num = (short)1344339968;
				short num2 = num;
				num = (short)1986738177;
				short num3 = num;
				num = (short)491599873;
				switch (num3 == num)
				{
				}
				num = (short)2054225921;
				if (num != 0)
				{
				}
				num = (short)1339949056;
				if (num != 0)
				{
				}
				return this.dataWideLabtoolDATA_CFGPacketDataActivateWaitTimerSec_A8686.StepSize;
			}
			set
			{
				short num = (short)428015616;
				short num2 = num;
				num = (short)265266176;
				short num3 = num;
				num = (short)243966976;
				switch (num3 == num)
				{
				}
				num = (short)803143681;
				if (num != 0)
				{
				}
				num = (short)917831680;
				if (num != 0)
				{
				}
				this.dataWideLabtoolDATA_CFGPacketDataActivateWaitTimerSec_A8686.StepSize = value;
			}
		}

		// Token: 0x170053A1 RID: 21409
		// (get) Token: 0x0600A6A4 RID: 42660 RVA: 0x009B2E14 File Offset: 0x009B1014
		// (set) Token: 0x0600A6A5 RID: 42661 RVA: 0x009B2EC8 File Offset: 0x009B10C8
		public bool DataWideLabtoolDATA_CFGPacketDataActivateWaitTimerSec_A8686_Applicable
		{
			get
			{
				short num = (short)1118240768;
				short num2 = num;
				num = (short)1856897025;
				if (num != 0)
				{
				}
				num = (short)52280104;
				short num3 = num;
				num = (short)257276712;
				switch (num3 == num)
				{
				}
				num = (short)1808138240;
				if (num != 0)
				{
				}
				return this.dataWideLabtoolDATA_CFGPacketDataActivateWaitTimerSec_A8686.Applicable;
			}
			set
			{
				short num = (short)1818820608;
				short num2 = num;
				num = (short)908376272;
				short num3 = num;
				num = (short)57063632;
				switch (num3 == num)
				{
				}
				num = (short)721485824;
				if (num != 0)
				{
				}
				num = (short)2138636289;
				if (num != 0)
				{
				}
				this.dataWideLabtoolDATA_CFGPacketDataActivateWaitTimerSec_A8686.Applicable = value;
			}
		}

		// Token: 0x170053A2 RID: 21410
		// (get) Token: 0x0600A6A6 RID: 42662 RVA: 0x009B2F7C File Offset: 0x009B117C
		// (set) Token: 0x0600A6A7 RID: 42663 RVA: 0x009B3030 File Offset: 0x009B1230
		public bool DataWideLabtoolDATA_CFGPacketDataActivateWaitTimerSec_A8686_Valid
		{
			get
			{
				short num = (short)1277165568;
				short num2 = num;
				num = (short)331283368;
				short num3 = num;
				num = (short)1257896872;
				switch (num3 == num)
				{
				}
				num = (short)390135809;
				if (num != 0)
				{
				}
				num = (short)1730412544;
				if (num != 0)
				{
				}
				return this.dataWideLabtoolDATA_CFGPacketDataActivateWaitTimerSec_A8686.Valid;
			}
			set
			{
				short num = (short)119668736;
				short num2 = num;
				num = (short)901003623;
				short num3 = num;
				num = (short)1643067751;
				switch (num3 == num)
				{
				}
				num = (short)1654194177;
				if (num != 0)
				{
				}
				num = (short)680132608;
				if (num != 0)
				{
				}
				this.dataWideLabtoolDATA_CFGPacketDataActivateWaitTimerSec_A8686.Valid = value;
			}
		}

		// Token: 0x170053A3 RID: 21411
		// (get) Token: 0x0600A6A8 RID: 42664 RVA: 0x009B30E4 File Offset: 0x009B12E4
		// (set) Token: 0x0600A6A9 RID: 42665 RVA: 0x009B3198 File Offset: 0x009B1398
		public bool DataWideLabtoolDATA_CFGPacketDataActivateWaitTimerSec_A8686_Visible
		{
			get
			{
				short num = (short)1448607744;
				short num2 = num;
				num = (short)407175169;
				if (num != 0)
				{
				}
				num = (short)1054912308;
				short num3 = num;
				num = (short)536981300;
				switch (num3 == num)
				{
				}
				num = (short)609615872;
				if (num != 0)
				{
				}
				return this.dataWideLabtoolDATA_CFGPacketDataActivateWaitTimerSec_A8686.Visible;
			}
			set
			{
				short num = (short)717422592;
				short num2 = num;
				num = (short)724909955;
				short num3 = num;
				num = (short)370229123;
				switch (num3 == num)
				{
				}
				num = (short)382140417;
				if (num != 0)
				{
				}
				num = (short)1851064320;
				if (num != 0)
				{
				}
				this.dataWideLabtoolDATA_CFGPacketDataActivateWaitTimerSec_A8686.Visible = value;
			}
		}

		// Token: 0x170053A4 RID: 21412
		// (get) Token: 0x0600A6AA RID: 42666 RVA: 0x009B324C File Offset: 0x009B144C
		// (set) Token: 0x0600A6AB RID: 42667 RVA: 0x009B3300 File Offset: 0x009B1500
		public bool DataWideLabtoolDATA_CFGPacketDataActivateWaitTimerSec_A8686_Editable
		{
			get
			{
				short num = (short)726204416;
				short num2 = num;
				num = (short)1953070736;
				short num3 = num;
				num = (short)1076723344;
				switch (num3 == num)
				{
				}
				num = (short)2074017792;
				if (num != 0)
				{
				}
				num = (short)1279918081;
				if (num != 0)
				{
				}
				return this.dataWideLabtoolDATA_CFGPacketDataActivateWaitTimerSec_A8686.Editable;
			}
			set
			{
				short num = (short)169672704;
				short num2 = num;
				num = (short)134318147;
				short num3 = num;
				num = (short)142968899;
				switch (num3 == num)
				{
				}
				num = (short)85721089;
				if (num != 0)
				{
				}
				num = (short)425984000;
				if (num != 0)
				{
				}
				this.dataWideLabtoolDATA_CFGPacketDataActivateWaitTimerSec_A8686.Editable = value;
			}
		}

		// Token: 0x170053A5 RID: 21413
		// (get) Token: 0x0600A6AC RID: 42668 RVA: 0x009B33B4 File Offset: 0x009B15B4
		internal string DataWideLabtoolDATA_CFGPacketDataActivateWaitTimerSec_A8686_UILabel
		{
			get
			{
				short num = (short)671481856;
				short num2 = num;
				num = (short)2107737549;
				short num3 = num;
				num = (short)1383499213;
				switch (num3 == num)
				{
				}
				num = (short)658046977;
				if (num != 0)
				{
				}
				num = (short)1507655680;
				if (num != 0)
				{
				}
				return this.dataWideLabtoolDATA_CFGPacketDataActivateWaitTimerSec_A8686.UIName;
			}
		}

		// Token: 0x170053A6 RID: 21414
		// (get) Token: 0x0600A6AD RID: 42669 RVA: 0x009B3470 File Offset: 0x009B1670
		// (set) Token: 0x0600A6AE RID: 42670 RVA: 0x009B3524 File Offset: 0x009B1724
		internal bool DataWideLabtoolDATA_CFGPacketDataActivateWaitTimerSec_A8686_HiddenStatic
		{
			get
			{
				short num = (short)1658388480;
				short num2 = num;
				num = (short)708872257;
				short num3 = num;
				num = (short)944736321;
				switch (num3 == num)
				{
				}
				num = (short)1035599872;
				if (num != 0)
				{
				}
				num = (short)957415425;
				if (num != 0)
				{
				}
				return this.dataWideLabtoolDATA_CFGPacketDataActivateWaitTimerSec_A8686.HiddenStatic;
			}
			set
			{
				short num = (short)1134493696;
				short num2 = num;
				num = (short)1941178576;
				short num3 = num;
				num = (short)597756112;
				switch (num3 == num)
				{
				}
				num = (short)1013907456;
				if (num != 0)
				{
				}
				num = (short)1092222977;
				if (num != 0)
				{
				}
				this.dataWideLabtoolDATA_CFGPacketDataActivateWaitTimerSec_A8686.HiddenStatic = value;
			}
		}

		// Token: 0x170053A7 RID: 21415
		// (get) Token: 0x0600A6AF RID: 42671 RVA: 0x009B35D8 File Offset: 0x009B17D8
		// (set) Token: 0x0600A6B0 RID: 42672 RVA: 0x009B368C File Offset: 0x009B188C
		internal bool DataWideLabtoolDATA_CFGPacketDataActivateWaitTimerSec_A8686_HiddenDynamic
		{
			get
			{
				short num = (short)1319698432;
				short num2 = num;
				num = (short)470293417;
				short num3 = num;
				num = (short)742726569;
				switch (num3 == num)
				{
				}
				num = (short)1705181184;
				if (num != 0)
				{
				}
				num = (short)652148737;
				if (num != 0)
				{
				}
				return this.dataWideLabtoolDATA_CFGPacketDataActivateWaitTimerSec_A8686.HiddenDynamic;
			}
			set
			{
				short num = (short)7733248;
				short num2 = num;
				num = (short)49773845;
				short num3 = num;
				num = (short)606895381;
				switch (num3 == num)
				{
				}
				num = (short)918683648;
				if (num != 0)
				{
				}
				num = (short)818741249;
				if (num != 0)
				{
				}
				this.dataWideLabtoolDATA_CFGPacketDataActivateWaitTimerSec_A8686.HiddenDynamic = value;
			}
		}

		// Token: 0x170053A8 RID: 21416
		// (get) Token: 0x0600A6B1 RID: 42673 RVA: 0x009B3744 File Offset: 0x009B1944
		public bool DataWideLabtoolDATA_CFGPacketDataActivateWaitTimerSec_A8686_HasDiffs
		{
			get
			{
				short num = (short)1977286656;
				short num2 = num;
				num = (short)1093142563;
				short num3 = num;
				num = (short)1158809635;
				switch (num3 == num)
				{
				}
				num = (short)1045299201;
				if (num != 0)
				{
				}
				num = (short)753598464;
				if (num != 0)
				{
				}
				return this.dataWideLabtoolDATA_CFGPacketDataActivateWaitTimerSec_A8686._HasDiffs;
			}
		}

		// Token: 0x170053A9 RID: 21417
		// (get) Token: 0x0600A6B2 RID: 42674 RVA: 0x009B37F8 File Offset: 0x009B19F8
		// (set) Token: 0x0600A6B3 RID: 42675 RVA: 0x009B38AC File Offset: 0x009B1AAC
		public int LabtoolDefaultReadyTimerSecValue
		{
			get
			{
				short num = (short)56426496;
				short num2 = num;
				num = (short)761554221;
				short num3 = num;
				num = (short)903832877;
				switch (num3 == num)
				{
				}
				num = (short)878837761;
				if (num != 0)
				{
				}
				num = (short)1330249728;
				if (num != 0)
				{
				}
				return this.labtoolDefaultReadyTimerSec.Value;
			}
			set
			{
				short num = (short)266731520;
				short num2 = num;
				num = (short)1869103859;
				short num3 = num;
				num = (short)932528883;
				switch (num3 == num)
				{
				}
				num = (short)161873921;
				if (num != 0)
				{
				}
				num = (short)912719872;
				if (num != 0)
				{
				}
				this.labtoolDefaultReadyTimerSec.Value = value;
			}
		}

		// Token: 0x170053AA RID: 21418
		// (get) Token: 0x0600A6B4 RID: 42676 RVA: 0x009B3964 File Offset: 0x009B1B64
		public global::AcpBusinessLayer.AcpSimpleRangeField LabtoolDefaultReadyTimerSec
		{
			get
			{
				short num = (short)1309278208;
				short num2 = num;
				num = (short)873529345;
				if (num != 0)
				{
				}
				num = (short)604044437;
				short num3 = num;
				num = (short)180419733;
				switch (num3 == num)
				{
				}
				num = (short)989593600;
				if (num != 0)
				{
				}
				return this.labtoolDefaultReadyTimerSec;
			}
		}

		// Token: 0x170053AB RID: 21419
		// (get) Token: 0x0600A6B5 RID: 42677 RVA: 0x009B3A14 File Offset: 0x009B1C14
		// (set) Token: 0x0600A6B6 RID: 42678 RVA: 0x009B3ACC File Offset: 0x009B1CCC
		public string LabtoolDefaultReadyTimerSec_UIValue
		{
			get
			{
				short num = (short)1928003584;
				short num2 = num;
				num = (short)361091952;
				short num3 = num;
				num = (short)75289456;
				switch (num3 == num)
				{
				}
				num = (short)1159856129;
				if (num != 0)
				{
				}
				num = (short)2118778880;
				if (num != 0)
				{
				}
				return this.labtoolDefaultReadyTimerSec.UIValue;
			}
			set
			{
				short num = (short)1232011264;
				short num2 = num;
				num = (short)413665030;
				short num3 = num;
				num = (short)862914310;
				switch (num3 == num)
				{
				}
				num = (short)1630535681;
				if (num != 0)
				{
				}
				num = (short)239992832;
				if (num != 0)
				{
				}
				this.labtoolDefaultReadyTimerSec.UIValue = value;
			}
		}

		// Token: 0x170053AC RID: 21420
		// (get) Token: 0x0600A6B7 RID: 42679 RVA: 0x009B3B80 File Offset: 0x009B1D80
		// (set) Token: 0x0600A6B8 RID: 42680 RVA: 0x009B3C34 File Offset: 0x009B1E34
		internal int LabtoolDefaultReadyTimerSecMin
		{
			get
			{
				short num = (short)185597952;
				short num2 = num;
				num = (short)1870199193;
				short num3 = num;
				num = (short)974649753;
				switch (num3 == num)
				{
				}
				num = (short)850264065;
				if (num != 0)
				{
				}
				num = (short)923860992;
				if (num != 0)
				{
				}
				return this.labtoolDefaultReadyTimerSec.Min;
			}
			set
			{
				short num = (short)241827840;
				short num2 = num;
				num = (short)78577665;
				if (num != 0)
				{
				}
				num = (short)1188427955;
				short num3 = num;
				num = (short)158070963;
				switch (num3 == num)
				{
				}
				num = (short)782761984;
				if (num != 0)
				{
				}
				this.labtoolDefaultReadyTimerSec.Min = value;
			}
		}

		// Token: 0x170053AD RID: 21421
		// (get) Token: 0x0600A6B9 RID: 42681 RVA: 0x009B3CE8 File Offset: 0x009B1EE8
		// (set) Token: 0x0600A6BA RID: 42682 RVA: 0x009B3D9C File Offset: 0x009B1F9C
		internal int LabtoolDefaultReadyTimerSecMax
		{
			get
			{
				short num = (short)1251278848;
				short num2 = num;
				num = (short)1405102745;
				short num3 = num;
				num = (short)941894297;
				switch (num3 == num)
				{
				}
				num = (short)283377665;
				if (num != 0)
				{
				}
				num = (short)1913978880;
				if (num != 0)
				{
				}
				return this.labtoolDefaultReadyTimerSec.Max;
			}
			set
			{
				short num = (short)1387593728;
				short num2 = num;
				num = (short)2142457343;
				short num3 = num;
				num = (short)444616191;
				switch (num3 == num)
				{
				}
				num = (short)1936326656;
				if (num != 0)
				{
				}
				num = (short)2124808193;
				if (num != 0)
				{
				}
				this.labtoolDefaultReadyTimerSec.Max = value;
			}
		}

		// Token: 0x170053AE RID: 21422
		// (get) Token: 0x0600A6BB RID: 42683 RVA: 0x009B3E54 File Offset: 0x009B2054
		// (set) Token: 0x0600A6BC RID: 42684 RVA: 0x009B3F0C File Offset: 0x009B210C
		internal int LabtoolDefaultReadyTimerSecStep
		{
			get
			{
				short num = (short)701759488;
				short num2 = num;
				num = (short)971330989;
				short num3 = num;
				num = (short)1879659949;
				switch (num3 == num)
				{
				}
				num = (short)2005532672;
				if (num != 0)
				{
				}
				num = (short)1605959681;
				if (num != 0)
				{
				}
				return this.labtoolDefaultReadyTimerSec.StepSize;
			}
			set
			{
				short num = (short)214368256;
				short num2 = num;
				num = (short)136708097;
				if (num != 0)
				{
				}
				num = (short)538296233;
				short num3 = num;
				num = (short)801750953;
				switch (num3 == num)
				{
				}
				num = (short)774701056;
				if (num != 0)
				{
				}
				this.labtoolDefaultReadyTimerSec.StepSize = value;
			}
		}

		// Token: 0x170053AF RID: 21423
		// (get) Token: 0x0600A6BD RID: 42685 RVA: 0x009B3FBC File Offset: 0x009B21BC
		// (set) Token: 0x0600A6BE RID: 42686 RVA: 0x009B4070 File Offset: 0x009B2270
		public bool LabtoolDefaultReadyTimerSec_Applicable
		{
			get
			{
				short num = (short)792002560;
				short num2 = num;
				num = (short)743178241;
				if (num != 0)
				{
				}
				num = (short)236139165;
				short num3 = num;
				num = (short)1894593181;
				switch (num3 == num)
				{
				}
				num = (short)1076756480;
				if (num != 0)
				{
				}
				return this.labtoolDefaultReadyTimerSec.Applicable;
			}
			set
			{
				short num = (short)746455040;
				short num2 = num;
				num = (short)1795081319;
				short num3 = num;
				num = (short)1044956263;
				switch (num3 == num)
				{
				}
				num = (short)1130430464;
				if (num != 0)
				{
				}
				num = (short)700710913;
				if (num != 0)
				{
				}
				this.labtoolDefaultReadyTimerSec.Applicable = value;
			}
		}

		// Token: 0x170053B0 RID: 21424
		// (get) Token: 0x0600A6BF RID: 42687 RVA: 0x009B4128 File Offset: 0x009B2328
		// (set) Token: 0x0600A6C0 RID: 42688 RVA: 0x009B41DC File Offset: 0x009B23DC
		public bool LabtoolDefaultReadyTimerSec_Valid
		{
			get
			{
				short num = (short)1815937024;
				short num2 = num;
				num = (short)58721166;
				short num3 = num;
				num = (short)2121859982;
				switch (num3 == num)
				{
				}
				num = (short)840368129;
				if (num != 0)
				{
				}
				num = (short)1670578176;
				if (num != 0)
				{
				}
				return this.labtoolDefaultReadyTimerSec.Valid;
			}
			set
			{
				short num = (short)621019136;
				short num2 = num;
				num = (short)89548419;
				short num3 = num;
				num = (short)1894803075;
				switch (num3 == num)
				{
				}
				num = (short)1127743488;
				if (num != 0)
				{
				}
				num = (short)1675231233;
				if (num != 0)
				{
				}
				this.labtoolDefaultReadyTimerSec.Valid = value;
			}
		}

		// Token: 0x170053B1 RID: 21425
		// (get) Token: 0x0600A6C1 RID: 42689 RVA: 0x009B4294 File Offset: 0x009B2494
		// (set) Token: 0x0600A6C2 RID: 42690 RVA: 0x009B4348 File Offset: 0x009B2548
		public bool LabtoolDefaultReadyTimerSec_Visible
		{
			get
			{
				short num = (short)1652817920;
				short num2 = num;
				num = (short)92368328;
				short num3 = num;
				num = (short)624979400;
				switch (num3 == num)
				{
				}
				num = (short)29360129;
				if (num != 0)
				{
				}
				num = (short)579665920;
				if (num != 0)
				{
				}
				return this.labtoolDefaultReadyTimerSec.Visible;
			}
			set
			{
				short num = (short)1405288448;
				short num2 = num;
				num = (short)669498423;
				short num3 = num;
				num = (short)1866710071;
				switch (num3 == num)
				{
				}
				num = (short)237830145;
				if (num != 0)
				{
				}
				num = (short)1729953792;
				if (num != 0)
				{
				}
				this.labtoolDefaultReadyTimerSec.Visible = value;
			}
		}

		// Token: 0x170053B2 RID: 21426
		// (get) Token: 0x0600A6C3 RID: 42691 RVA: 0x009B4400 File Offset: 0x009B2600
		// (set) Token: 0x0600A6C4 RID: 42692 RVA: 0x009B44B8 File Offset: 0x009B26B8
		public bool LabtoolDefaultReadyTimerSec_Editable
		{
			get
			{
				short num = (short)1555038208;
				short num2 = num;
				num = (short)1072300033;
				if (num != 0)
				{
				}
				num = (short)700255880;
				short num3 = num;
				num = (short)962596488;
				switch (num3 == num)
				{
				}
				num = (short)114622464;
				if (num != 0)
				{
				}
				return this.labtoolDefaultReadyTimerSec.Editable;
			}
			set
			{
				short num = (short)1013317632;
				short num2 = num;
				num = (short)1747740996;
				short num3 = num;
				num = (short)226191684;
				switch (num3 == num)
				{
				}
				num = (short)556662784;
				if (num != 0)
				{
				}
				num = (short)803602433;
				if (num != 0)
				{
				}
				this.labtoolDefaultReadyTimerSec.Editable = value;
			}
		}

		// Token: 0x170053B3 RID: 21427
		// (get) Token: 0x0600A6C5 RID: 42693 RVA: 0x009B456C File Offset: 0x009B276C
		internal string LabtoolDefaultReadyTimerSec_UILabel
		{
			get
			{
				short num = (short)48562176;
				short num2 = num;
				num = (short)1268700449;
				short num3 = num;
				num = (short)1615254817;
				switch (num3 == num)
				{
				}
				num = (short)741408768;
				if (num != 0)
				{
				}
				num = (short)127139841;
				if (num != 0)
				{
				}
				return this.labtoolDefaultReadyTimerSec.UIName;
			}
		}

		// Token: 0x170053B4 RID: 21428
		// (get) Token: 0x0600A6C6 RID: 42694 RVA: 0x009B4624 File Offset: 0x009B2824
		// (set) Token: 0x0600A6C7 RID: 42695 RVA: 0x009B46DC File Offset: 0x009B28DC
		internal bool LabtoolDefaultReadyTimerSec_HiddenStatic
		{
			get
			{
				short num = (short)429588480;
				short num2 = num;
				num = (short)1530292662;
				short num3 = num;
				num = (short)2110089654;
				switch (num3 == num)
				{
				}
				num = (short)1677066241;
				if (num != 0)
				{
				}
				num = (short)1281490944;
				if (num != 0)
				{
				}
				return this.labtoolDefaultReadyTimerSec.HiddenStatic;
			}
			set
			{
				short num = (short)2036793344;
				short num2 = num;
				num = (short)1992143858;
				short num3 = num;
				num = (short)1954919410;
				switch (num3 == num)
				{
				}
				num = (short)355663873;
				if (num != 0)
				{
				}
				num = (short)1604517888;
				if (num != 0)
				{
				}
				this.labtoolDefaultReadyTimerSec.HiddenStatic = value;
			}
		}

		// Token: 0x170053B5 RID: 21429
		// (get) Token: 0x0600A6C8 RID: 42696 RVA: 0x009B4794 File Offset: 0x009B2994
		// (set) Token: 0x0600A6C9 RID: 42697 RVA: 0x009B4848 File Offset: 0x009B2A48
		internal bool LabtoolDefaultReadyTimerSec_HiddenDynamic
		{
			get
			{
				short num = (short)526423308;
				short num2 = num;
				num = (short)1909298444;
				switch (num2 == num)
				{
				}
				num = (short)1144389632;
				if (num != 0)
				{
				}
				num = (short)2136211456;
				short num3 = num;
				num = (short)173998081;
				if (num != 0)
				{
				}
				return this.labtoolDefaultReadyTimerSec.HiddenDynamic;
			}
			set
			{
				short num = (short)610271233;
				if (num != 0)
				{
				}
				num = (short)1572045626;
				short num2 = num;
				num = (short)1442284346;
				switch (num2 == num)
				{
				}
				num = (short)1464139776;
				short num3 = num;
				num = (short)1327562752;
				if (num != 0)
				{
				}
				this.labtoolDefaultReadyTimerSec.HiddenDynamic = value;
			}
		}

		// Token: 0x170053B6 RID: 21430
		// (get) Token: 0x0600A6CA RID: 42698 RVA: 0x009B48FC File Offset: 0x009B2AFC
		public bool LabtoolDefaultReadyTimerSec_HasDiffs
		{
			get
			{
				short num = (short)683464537;
				short num2 = num;
				num = (short)2075252569;
				switch (num2 == num)
				{
				}
				num = (short)2018050048;
				if (num != 0)
				{
				}
				num = (short)712900608;
				short num3 = num;
				num = (short)1893203969;
				if (num != 0)
				{
				}
				return this.labtoolDefaultReadyTimerSec._HasDiffs;
			}
		}

		// Token: 0x170053B7 RID: 21431
		// (get) Token: 0x0600A6CB RID: 42699 RVA: 0x009B49B0 File Offset: 0x009B2BB0
		// (set) Token: 0x0600A6CC RID: 42700 RVA: 0x009B4A64 File Offset: 0x009B2C64
		public int DataWideDVRSActWaitTime_A40128Value
		{
			get
			{
				short num = (short)1711567188;
				short num2 = num;
				num = (short)918581588;
				switch (num2 == num)
				{
				}
				num = (short)1669726208;
				if (num != 0)
				{
				}
				num = (short)1334640640;
				short num3 = num;
				num = (short)413532161;
				if (num != 0)
				{
				}
				return this.dataWideDVRSActWaitTime_A40128.Value;
			}
			set
			{
				short num = (short)1050145072;
				short num2 = num;
				num = (short)1792864560;
				switch (num2 == num)
				{
				}
				num = (short)1175191553;
				if (num != 0)
				{
				}
				num = (short)794820608;
				short num3 = num;
				num = (short)1998651392;
				if (num != 0)
				{
				}
				this.dataWideDVRSActWaitTime_A40128.Value = value;
			}
		}

		// Token: 0x170053B8 RID: 21432
		// (get) Token: 0x0600A6CD RID: 42701 RVA: 0x009B4B1C File Offset: 0x009B2D1C
		public global::AcpBusinessLayer.AcpSimpleRangeField DataWideDVRSActWaitTime_A40128
		{
			get
			{
				short num = (short)1000210433;
				if (num != 0)
				{
				}
				num = (short)800541835;
				short num2 = num;
				num = (short)1099648139;
				switch (num2 == num)
				{
				}
				num = (short)1551237120;
				short num3 = num;
				num = (short)183697408;
				if (num != 0)
				{
				}
				return this.dataWideDVRSActWaitTime_A40128;
			}
		}

		// Token: 0x170053B9 RID: 21433
		// (get) Token: 0x0600A6CE RID: 42702 RVA: 0x009B4BCC File Offset: 0x009B2DCC
		// (set) Token: 0x0600A6CF RID: 42703 RVA: 0x009B4C80 File Offset: 0x009B2E80
		public string DataWideDVRSActWaitTime_A40128_UIValue
		{
			get
			{
				short num = (short)1615264836;
				short num2 = num;
				num = (short)1716124740;
				switch (num2 == num)
				{
				}
				num = (short)1459290113;
				if (num != 0)
				{
				}
				num = (short)1366687744;
				short num3 = num;
				num = (short)114032640;
				if (num != 0)
				{
				}
				return this.dataWideDVRSActWaitTime_A40128.UIValue;
			}
			set
			{
				short num = (short)156557830;
				short num2 = num;
				num = (short)2115166726;
				switch (num2 == num)
				{
				}
				num = (short)813891585;
				if (num != 0)
				{
				}
				num = (short)40566784;
				short num3 = num;
				num = (short)340656128;
				if (num != 0)
				{
				}
				this.dataWideDVRSActWaitTime_A40128.UIValue = value;
			}
		}

		// Token: 0x170053BA RID: 21434
		// (get) Token: 0x0600A6D0 RID: 42704 RVA: 0x009B4D34 File Offset: 0x009B2F34
		// (set) Token: 0x0600A6D1 RID: 42705 RVA: 0x009B4DE8 File Offset: 0x009B2FE8
		internal int DataWideDVRSActWaitTime_A40128Min
		{
			get
			{
				short num = (short)206553816;
				short num2 = num;
				num = (short)97501912;
				switch (num2 == num)
				{
				}
				num = (short)1921712129;
				if (num != 0)
				{
				}
				num = (short)223543296;
				short num3 = num;
				num = (short)1336016896;
				if (num != 0)
				{
				}
				return this.dataWideDVRSActWaitTime_A40128.Min;
			}
			set
			{
				short num = (short)643145980;
				short num2 = num;
				num = (short)243638524;
				switch (num2 == num)
				{
				}
				num = (short)89915393;
				if (num != 0)
				{
				}
				num = (short)1722286080;
				short num3 = num;
				num = (short)1439039488;
				if (num != 0)
				{
				}
				this.dataWideDVRSActWaitTime_A40128.Min = value;
			}
		}

		// Token: 0x170053BB RID: 21435
		// (get) Token: 0x0600A6D2 RID: 42706 RVA: 0x009B4E9C File Offset: 0x009B309C
		// (set) Token: 0x0600A6D3 RID: 42707 RVA: 0x009B4F54 File Offset: 0x009B3154
		internal int DataWideDVRSActWaitTime_A40128Max
		{
			get
			{
				short num = (short)339390588;
				short num2 = num;
				num = (short)1553051772;
				switch (num2 == num)
				{
				}
				num = (short)870252544;
				if (num != 0)
				{
				}
				num = (short)1885732864;
				short num3 = num;
				num = (short)44302337;
				if (num != 0)
				{
				}
				return this.dataWideDVRSActWaitTime_A40128.Max;
			}
			set
			{
				short num = (short)1004203012;
				short num2 = num;
				num = (short)2131684356;
				switch (num2 == num)
				{
				}
				num = (short)262995969;
				if (num != 0)
				{
				}
				num = (short)1579155456;
				short num3 = num;
				num = (short)1126432768;
				if (num != 0)
				{
				}
				this.dataWideDVRSActWaitTime_A40128.Max = value;
			}
		}

		// Token: 0x170053BC RID: 21436
		// (get) Token: 0x0600A6D4 RID: 42708 RVA: 0x009B5008 File Offset: 0x009B3208
		// (set) Token: 0x0600A6D5 RID: 42709 RVA: 0x009B50BC File Offset: 0x009B32BC
		internal int DataWideDVRSActWaitTime_A40128Step
		{
			get
			{
				short num = (short)963742535;
				short num2 = num;
				num = (short)672435015;
				switch (num2 == num)
				{
				}
				num = (short)1111293953;
				if (num != 0)
				{
				}
				num = (short)1282932736;
				short num3 = num;
				num = (short)1787297792;
				if (num != 0)
				{
				}
				return this.dataWideDVRSActWaitTime_A40128.StepSize;
			}
			set
			{
				short num = (short)104410755;
				short num2 = num;
				num = (short)2008034947;
				switch (num2 == num)
				{
				}
				num = (short)312279040;
				if (num != 0)
				{
				}
				num = (short)308150272;
				short num3 = num;
				num = (short)1210449921;
				if (num != 0)
				{
				}
				this.dataWideDVRSActWaitTime_A40128.StepSize = value;
			}
		}

		// Token: 0x170053BD RID: 21437
		// (get) Token: 0x0600A6D6 RID: 42710 RVA: 0x009B5170 File Offset: 0x009B3370
		// (set) Token: 0x0600A6D7 RID: 42711 RVA: 0x009B5224 File Offset: 0x009B3424
		public bool DataWideDVRSActWaitTime_A40128_Applicable
		{
			get
			{
				short num = (short)1329463297;
				if (num != 0)
				{
				}
				num = (short)1403089632;
				short num2 = num;
				num = (short)86078176;
				switch (num2 == num)
				{
				}
				num = (short)610467840;
				short num3 = num;
				num = (short)1405550592;
				if (num != 0)
				{
				}
				return this.dataWideDVRSActWaitTime_A40128.Applicable;
			}
			set
			{
				short num = (short)10436017;
				short num2 = num;
				num = (short)1519271345;
				switch (num2 == num)
				{
				}
				num = (short)1588068353;
				if (num != 0)
				{
				}
				num = (short)91881472;
				short num3 = num;
				num = (short)1417936896;
				if (num != 0)
				{
				}
				this.dataWideDVRSActWaitTime_A40128.Applicable = value;
			}
		}

		// Token: 0x170053BE RID: 21438
		// (get) Token: 0x0600A6D8 RID: 42712 RVA: 0x009B52DC File Offset: 0x009B34DC
		// (set) Token: 0x0600A6D9 RID: 42713 RVA: 0x009B5394 File Offset: 0x009B3594
		public bool DataWideDVRSActWaitTime_A40128_Valid
		{
			get
			{
				short num = (short)1187511731;
				short num2 = num;
				num = (short)1390017971;
				switch (num2 == num)
				{
				}
				num = (short)190316544;
				if (num != 0)
				{
				}
				num = (short)812449792;
				short num3 = num;
				num = (short)817627137;
				if (num != 0)
				{
				}
				return this.dataWideDVRSActWaitTime_A40128.Valid;
			}
			set
			{
				short num = (short)699678312;
				short num2 = num;
				num = (short)991444584;
				switch (num2 == num)
				{
				}
				num = (short)595329025;
				if (num != 0)
				{
				}
				num = (short)892731392;
				short num3 = num;
				num = (short)1804337152;
				if (num != 0)
				{
				}
				this.dataWideDVRSActWaitTime_A40128.Valid = value;
			}
		}

		// Token: 0x170053BF RID: 21439
		// (get) Token: 0x0600A6DA RID: 42714 RVA: 0x009B544C File Offset: 0x009B364C
		// (set) Token: 0x0600A6DB RID: 42715 RVA: 0x009B5500 File Offset: 0x009B3700
		public bool DataWideDVRSActWaitTime_A40128_Visible
		{
			get
			{
				short num = (short)1024502604;
				short num2 = num;
				num = (short)640723788;
				switch (num2 == num)
				{
				}
				num = (short)744292353;
				if (num != 0)
				{
				}
				num = (short)1578827776;
				short num3 = num;
				num = (short)1722613760;
				if (num != 0)
				{
				}
				return this.dataWideDVRSActWaitTime_A40128.Visible;
			}
			set
			{
				short num = (short)2106364047;
				short num2 = num;
				num = (short)161910927;
				switch (num2 == num)
				{
				}
				num = (short)1056440321;
				if (num != 0)
				{
				}
				num = (short)343867392;
				short num3 = num;
				num = (short)214106112;
				if (num != 0)
				{
				}
				this.dataWideDVRSActWaitTime_A40128.Visible = value;
			}
		}

		// Token: 0x170053C0 RID: 21440
		// (get) Token: 0x0600A6DC RID: 42716 RVA: 0x009B55B8 File Offset: 0x009B37B8
		// (set) Token: 0x0600A6DD RID: 42717 RVA: 0x009B566C File Offset: 0x009B386C
		public bool DataWideDVRSActWaitTime_A40128_Editable
		{
			get
			{
				short num = (short)869100241;
				short num2 = num;
				num = (short)854616785;
				switch (num2 == num)
				{
				}
				num = (short)1673789440;
				if (num != 0)
				{
				}
				num = (short)1552023552;
				short num3 = num;
				num = (short)535166977;
				if (num != 0)
				{
				}
				return this.dataWideDVRSActWaitTime_A40128.Editable;
			}
			set
			{
				short num = (short)1358669307;
				short num2 = num;
				num = (short)1325377019;
				switch (num2 == num)
				{
				}
				num = (short)671023105;
				if (num != 0)
				{
				}
				num = (short)1446248448;
				short num3 = num;
				num = (short)137625600;
				if (num != 0)
				{
				}
				this.dataWideDVRSActWaitTime_A40128.Editable = value;
			}
		}

		// Token: 0x170053C1 RID: 21441
		// (get) Token: 0x0600A6DE RID: 42718 RVA: 0x009B5724 File Offset: 0x009B3924
		internal string DataWideDVRSActWaitTime_A40128_UILabel
		{
			get
			{
				short num = (short)848460221;
				short num2 = num;
				num = (short)1945139645;
				switch (num2 == num)
				{
				}
				num = (short)1533018113;
				if (num != 0)
				{
				}
				num = (short)1149501440;
				short num3 = num;
				num = (short)1751056384;
				if (num != 0)
				{
				}
				return this.dataWideDVRSActWaitTime_A40128.UIName;
			}
		}

		// Token: 0x170053C2 RID: 21442
		// (get) Token: 0x0600A6DF RID: 42719 RVA: 0x009B57D8 File Offset: 0x009B39D8
		// (set) Token: 0x0600A6E0 RID: 42720 RVA: 0x009B588C File Offset: 0x009B3A8C
		internal bool DataWideDVRSActWaitTime_A40128_HiddenStatic
		{
			get
			{
				short num = (short)809008279;
				short num2 = num;
				num = (short)2045934743;
				switch (num2 == num)
				{
				}
				num = (short)1384841216;
				if (num != 0)
				{
				}
				num = (short)1400504320;
				short num3 = num;
				num = (short)725811201;
				if (num != 0)
				{
				}
				return this.dataWideDVRSActWaitTime_A40128.HiddenStatic;
			}
			set
			{
				short num = (short)1047690012;
				short num2 = num;
				num = (short)1256487708;
				switch (num2 == num)
				{
				}
				num = (short)1132724225;
				if (num != 0)
				{
				}
				num = (short)1201143808;
				short num3 = num;
				num = (short)2005794816;
				if (num != 0)
				{
				}
				this.dataWideDVRSActWaitTime_A40128.HiddenStatic = value;
			}
		}

		// Token: 0x170053C3 RID: 21443
		// (get) Token: 0x0600A6E1 RID: 42721 RVA: 0x009B5940 File Offset: 0x009B3B40
		// (set) Token: 0x0600A6E2 RID: 42722 RVA: 0x009B59F4 File Offset: 0x009B3BF4
		internal bool DataWideDVRSActWaitTime_A40128_HiddenDynamic
		{
			get
			{
				short num = (short)2084731650;
				short num2 = num;
				num = (short)1185381122;
				switch (num2 == num)
				{
				}
				num = (short)1693122561;
				if (num != 0)
				{
				}
				num = (short)1104347136;
				short num3 = num;
				num = (short)1087963136;
				if (num != 0)
				{
				}
				return this.dataWideDVRSActWaitTime_A40128.HiddenDynamic;
			}
			set
			{
				short num = (short)2032804288;
				short num2 = num;
				num = (short)30876096;
				switch (num2 == num)
				{
				}
				num = (short)1178730497;
				if (num != 0)
				{
				}
				num = (short)1290993664;
				short num3 = num;
				num = (short)1867513856;
				if (num != 0)
				{
				}
				this.dataWideDVRSActWaitTime_A40128.HiddenDynamic = value;
			}
		}

		// Token: 0x170053C4 RID: 21444
		// (get) Token: 0x0600A6E3 RID: 42723 RVA: 0x009B5AA8 File Offset: 0x009B3CA8
		public bool DataWideDVRSActWaitTime_A40128_HasDiffs
		{
			get
			{
				short num = (short)1261180933;
				short num2 = num;
				num = (short)175314949;
				switch (num2 == num)
				{
				}
				num = (short)587464704;
				if (num != 0)
				{
				}
				num = (short)826015744;
				short num3 = num;
				num = (short)152502273;
				if (num != 0)
				{
				}
				return this.dataWideDVRSActWaitTime_A40128._HasDiffs;
			}
		}

		// Token: 0x170053C5 RID: 21445
		// (get) Token: 0x0600A6E4 RID: 42724 RVA: 0x009B5B60 File Offset: 0x009B3D60
		// (set) Token: 0x0600A6E5 RID: 42725 RVA: 0x009B5C14 File Offset: 0x009B3E14
		public int RandomAccessAckTimerMsec_42016Value
		{
			get
			{
				short num = (short)780717066;
				short num2 = num;
				num = (short)152095754;
				switch (num2 == num)
				{
				}
				num = (short)1182662657;
				if (num != 0)
				{
				}
				num = (short)1349189632;
				short num3 = num;
				num = (short)276627456;
				if (num != 0)
				{
				}
				return this.randomAccessAckTimerMsec_42016.Value;
			}
			set
			{
				short num = (short)1108933191;
				short num2 = num;
				num = (short)1311242823;
				switch (num2 == num)
				{
				}
				num = (short)1389232128;
				if (num != 0)
				{
				}
				num = (short)1741029376;
				short num3 = num;
				num = (short)1741488129;
				if (num != 0)
				{
				}
				this.randomAccessAckTimerMsec_42016.Value = value;
			}
		}

		// Token: 0x170053C6 RID: 21446
		// (get) Token: 0x0600A6E6 RID: 42726 RVA: 0x009B5CC8 File Offset: 0x009B3EC8
		public global::AcpBusinessLayer.AcpSimpleRangeField RandomAccessAckTimerMsec_42016
		{
			get
			{
				short num = (short)1927656037;
				short num2 = num;
				num = (short)1096987237;
				switch (num2 == num)
				{
				}
				num = (short)1045430272;
				if (num != 0)
				{
				}
				num = (short)1385168896;
				short num3 = num;
				num = (short)954925057;
				if (num != 0)
				{
				}
				return this.randomAccessAckTimerMsec_42016;
			}
		}

		// Token: 0x170053C7 RID: 21447
		// (get) Token: 0x0600A6E7 RID: 42727 RVA: 0x009B5D74 File Offset: 0x009B3F74
		// (set) Token: 0x0600A6E8 RID: 42728 RVA: 0x009B5E28 File Offset: 0x009B4028
		public string RandomAccessAckTimerMsec_42016_UIValue
		{
			get
			{
				short num = (short)1257963521;
				if (num != 0)
				{
				}
				num = (short)924887027;
				short num2 = num;
				num = (short)2109777907;
				switch (num2 == num)
				{
				}
				num = (short)1413677056;
				short num3 = num;
				num = (short)2121793536;
				if (num != 0)
				{
				}
				return this.randomAccessAckTimerMsec_42016.UIValue;
			}
			set
			{
				short num = (short)745447021;
				short num2 = num;
				num = (short)401776237;
				switch (num2 == num)
				{
				}
				num = (short)1613561856;
				if (num != 0)
				{
				}
				num = (short)700055552;
				short num3 = num;
				num = (short)786235393;
				if (num != 0)
				{
				}
				this.randomAccessAckTimerMsec_42016.UIValue = value;
			}
		}

		// Token: 0x170053C8 RID: 21448
		// (get) Token: 0x0600A6E9 RID: 42729 RVA: 0x009B5EDC File Offset: 0x009B40DC
		// (set) Token: 0x0600A6EA RID: 42730 RVA: 0x009B5F90 File Offset: 0x009B4190
		internal int RandomAccessAckTimerMsec_42016Min
		{
			get
			{
				short num = (short)1256108346;
				short num2 = num;
				num = (short)521187642;
				switch (num2 == num)
				{
				}
				num = (short)1290862593;
				if (num != 0)
				{
				}
				num = (short)1318715392;
				short num3 = num;
				num = (short)525008896;
				if (num != 0)
				{
				}
				return this.randomAccessAckTimerMsec_42016.Min;
			}
			set
			{
				short num = (short)680439271;
				short num2 = num;
				num = (short)1018736103;
				switch (num2 == num)
				{
				}
				num = (short)1135542273;
				if (num != 0)
				{
				}
				num = (short)1438908416;
				short num3 = num;
				num = (short)1314193408;
				if (num != 0)
				{
				}
				this.randomAccessAckTimerMsec_42016.Min = value;
			}
		}

		// Token: 0x170053C9 RID: 21449
		// (get) Token: 0x0600A6EB RID: 42731 RVA: 0x009B6048 File Offset: 0x009B4248
		// (set) Token: 0x0600A6EC RID: 42732 RVA: 0x009B6100 File Offset: 0x009B4300
		internal int RandomAccessAckTimerMsec_42016Max
		{
			get
			{
				short num = (short)626786305;
				if (num != 0)
				{
				}
				num = (short)204634458;
				short num2 = num;
				num = (short)789412186;
				switch (num2 == num)
				{
				}
				num = (short)1066467328;
				short num3 = num;
				num = (short)504496128;
				if (num != 0)
				{
				}
				return this.randomAccessAckTimerMsec_42016.Max;
			}
			set
			{
				short num = (short)1034091542;
				short num2 = num;
				num = (short)2027748374;
				switch (num2 == num)
				{
				}
				num = (short)564920320;
				if (num != 0)
				{
				}
				num = (short)1271529472;
				short num3 = num;
				num = (short)1595539457;
				if (num != 0)
				{
				}
				this.randomAccessAckTimerMsec_42016.Max = value;
			}
		}

		// Token: 0x170053CA RID: 21450
		// (get) Token: 0x0600A6ED RID: 42733 RVA: 0x009B61B4 File Offset: 0x009B43B4
		// (set) Token: 0x0600A6EE RID: 42734 RVA: 0x009B6268 File Offset: 0x009B4468
		internal int RandomAccessAckTimerMsec_42016Step
		{
			get
			{
				short num = (short)1303418289;
				short num2 = num;
				num = (short)213161393;
				switch (num2 == num)
				{
				}
				num = (short)913571841;
				if (num != 0)
				{
				}
				num = (short)1188298752;
				short num3 = num;
				num = (short)78315520;
				if (num != 0)
				{
				}
				return this.randomAccessAckTimerMsec_42016.StepSize;
			}
			set
			{
				short num = (short)1760034817;
				if (num != 0)
				{
				}
				num = (short)308152424;
				short num2 = num;
				num = (short)1695352936;
				switch (num2 == num)
				{
				}
				num = (short)1174929408;
				short num3 = num;
				num = (short)1859387392;
				if (num != 0)
				{
				}
				this.randomAccessAckTimerMsec_42016.StepSize = value;
			}
		}

		// Token: 0x170053CB RID: 21451
		// (get) Token: 0x0600A6EF RID: 42735 RVA: 0x009B631C File Offset: 0x009B451C
		// (set) Token: 0x0600A6F0 RID: 42736 RVA: 0x009B63D4 File Offset: 0x009B45D4
		public bool RandomAccessAckTimerMsec_42016_Applicable
		{
			get
			{
				short num = (short)151977985;
				if (num != 0)
				{
				}
				num = (short)2017176616;
				short num2 = num;
				num = (short)1698999336;
				switch (num2 == num)
				{
				}
				num = (short)1971191808;
				short num3 = num;
				num = (short)737673216;
				if (num != 0)
				{
				}
				return this.randomAccessAckTimerMsec_42016.Applicable;
			}
			set
			{
				short num = (short)826158676;
				short num2 = num;
				num = (short)2092510804;
				switch (num2 == num)
				{
				}
				num = (short)1377173505;
				if (num != 0)
				{
				}
				num = (short)2079719424;
				short num3 = num;
				num = (short)1525940224;
				if (num != 0)
				{
				}
				this.randomAccessAckTimerMsec_42016.Applicable = value;
			}
		}

		// Token: 0x170053CC RID: 21452
		// (get) Token: 0x0600A6F1 RID: 42737 RVA: 0x009B6488 File Offset: 0x009B4688
		// (set) Token: 0x0600A6F2 RID: 42738 RVA: 0x009B653C File Offset: 0x009B473C
		public bool RandomAccessAckTimerMsec_42016_Valid
		{
			get
			{
				short num = (short)156396536;
				short num2 = num;
				num = (short)591293432;
				switch (num2 == num)
				{
				}
				num = (short)1866858497;
				if (num != 0)
				{
				}
				num = (short)1043988480;
				short num3 = num;
				num = (short)376373248;
				if (num != 0)
				{
				}
				return this.randomAccessAckTimerMsec_42016.Valid;
			}
			set
			{
				short num = (short)1928893140;
				short num2 = num;
				num = (short)5935828;
				switch (num2 == num)
				{
				}
				num = (short)878641153;
				if (num != 0)
				{
				}
				num = (short)1194459136;
				short num3 = num;
				num = (short)1163984896;
				if (num != 0)
				{
				}
				this.randomAccessAckTimerMsec_42016.Valid = value;
			}
		}

		// Token: 0x170053CD RID: 21453
		// (get) Token: 0x0600A6F3 RID: 42739 RVA: 0x009B65F4 File Offset: 0x009B47F4
		// (set) Token: 0x0600A6F4 RID: 42740 RVA: 0x009B66A8 File Offset: 0x009B48A8
		public bool RandomAccessAckTimerMsec_42016_Visible
		{
			get
			{
				short num = (short)1013194413;
				short num2 = num;
				num = (short)428875437;
				switch (num2 == num)
				{
				}
				num = (short)1914044417;
				if (num != 0)
				{
				}
				num = (short)1804992512;
				short num3 = num;
				num = (short)539426816;
				if (num != 0)
				{
				}
				return this.randomAccessAckTimerMsec_42016.Visible;
			}
			set
			{
				short num = (short)61702688;
				short num2 = num;
				num = (short)62947872;
				switch (num2 == num)
				{
				}
				num = (short)1976369153;
				if (num != 0)
				{
				}
				num = (short)708837376;
				short num3 = num;
				num = (short)1030094848;
				if (num != 0)
				{
				}
				this.randomAccessAckTimerMsec_42016.Visible = value;
			}
		}

		// Token: 0x170053CE RID: 21454
		// (get) Token: 0x0600A6F5 RID: 42741 RVA: 0x009B6760 File Offset: 0x009B4960
		// (set) Token: 0x0600A6F6 RID: 42742 RVA: 0x009B6814 File Offset: 0x009B4A14
		public bool RandomAccessAckTimerMsec_42016_Editable
		{
			get
			{
				short num = (short)1504237666;
				short num2 = num;
				num = (short)1891031138;
				switch (num2 == num)
				{
				}
				num = (short)365690881;
				if (num != 0)
				{
				}
				num = (short)94371840;
				short num3 = num;
				num = (short)2144993280;
				if (num != 0)
				{
				}
				return this.randomAccessAckTimerMsec_42016.Editable;
			}
			set
			{
				short num = (short)1828878407;
				short num2 = num;
				num = (short)2052225095;
				switch (num2 == num)
				{
				}
				num = (short)1137836032;
				if (num != 0)
				{
				}
				num = (short)315949056;
				short num3 = num;
				num = (short)439615489;
				if (num != 0)
				{
				}
				this.randomAccessAckTimerMsec_42016.Editable = value;
			}
		}

		// Token: 0x170053CF RID: 21455
		// (get) Token: 0x0600A6F7 RID: 42743 RVA: 0x009B68C8 File Offset: 0x009B4AC8
		internal string RandomAccessAckTimerMsec_42016_UILabel
		{
			get
			{
				short num = (short)117899265;
				if (num != 0)
				{
				}
				num = (short)249182207;
				short num2 = num;
				num = (short)340408319;
				switch (num2 == num)
				{
				}
				num = (short)141950976;
				short num3 = num;
				num = (short)666959872;
				if (num != 0)
				{
				}
				return this.randomAccessAckTimerMsec_42016.UIName;
			}
		}

		// Token: 0x170053D0 RID: 21456
		// (get) Token: 0x0600A6F8 RID: 42744 RVA: 0x009B697C File Offset: 0x009B4B7C
		// (set) Token: 0x0600A6F9 RID: 42745 RVA: 0x009B6A30 File Offset: 0x009B4C30
		internal bool RandomAccessAckTimerMsec_42016_HiddenStatic
		{
			get
			{
				short num = (short)1400568551;
				short num2 = num;
				num = (short)681769703;
				switch (num2 == num)
				{
				}
				num = (short)314310657;
				if (num != 0)
				{
				}
				num = (short)731906048;
				short num3 = num;
				num = (short)83886080;
				if (num != 0)
				{
				}
				return this.randomAccessAckTimerMsec_42016.HiddenStatic;
			}
			set
			{
				short num = (short)856850053;
				short num2 = num;
				num = (short)781745797;
				switch (num2 == num)
				{
				}
				num = (short)1523056641;
				if (num != 0)
				{
				}
				num = (short)874905600;
				short num3 = num;
				num = (short)270270464;
				if (num != 0)
				{
				}
				this.randomAccessAckTimerMsec_42016.HiddenStatic = value;
			}
		}

		// Token: 0x170053D1 RID: 21457
		// (get) Token: 0x0600A6FA RID: 42746 RVA: 0x009B6AE8 File Offset: 0x009B4CE8
		// (set) Token: 0x0600A6FB RID: 42747 RVA: 0x009B6B9C File Offset: 0x009B4D9C
		internal bool RandomAccessAckTimerMsec_42016_HiddenDynamic
		{
			get
			{
				short num = (short)1744310485;
				short num2 = num;
				num = (short)1010110677;
				switch (num2 == num)
				{
				}
				num = (short)1892548609;
				if (num != 0)
				{
				}
				num = (short)906231808;
				short num3 = num;
				num = (short)1822359552;
				if (num != 0)
				{
				}
				return this.randomAccessAckTimerMsec_42016.HiddenDynamic;
			}
			set
			{
				short num = (short)1306405595;
				short num2 = num;
				num = (short)1812867803;
				switch (num2 == num)
				{
				}
				num = (short)57278465;
				if (num != 0)
				{
				}
				num = (short)1641021440;
				short num3 = num;
				num = (short)1171652608;
				if (num != 0)
				{
				}
				this.randomAccessAckTimerMsec_42016.HiddenDynamic = value;
			}
		}

		// Token: 0x170053D2 RID: 21458
		// (get) Token: 0x0600A6FC RID: 42748 RVA: 0x009B6C50 File Offset: 0x009B4E50
		public bool RandomAccessAckTimerMsec_42016_HasDiffs
		{
			get
			{
				short num = (short)1010772436;
				short num2 = num;
				num = (short)365570516;
				switch (num2 == num)
				{
				}
				num = (short)1101791233;
				if (num != 0)
				{
				}
				num = (short)756678656;
				short num3 = num;
				num = (short)99155968;
				if (num != 0)
				{
				}
				return this.randomAccessAckTimerMsec_42016._HasDiffs;
			}
		}

		// Token: 0x170053D3 RID: 21459
		// (get) Token: 0x0600A6FD RID: 42749 RVA: 0x009B6D04 File Offset: 0x009B4F04
		// (set) Token: 0x0600A6FE RID: 42750 RVA: 0x009B6DB8 File Offset: 0x009B4FB8
		public string DataWideLabtoolDeviceProvisioningServiceIDScope_43553Value
		{
			get
			{
				short num = (short)1190320422;
				short num2 = num;
				num = (short)261282086;
				switch (num2 == num)
				{
				}
				num = (short)1284243456;
				if (num != 0)
				{
				}
				num = (short)959840256;
				short num3 = num;
				num = (short)733609985;
				if (num != 0)
				{
				}
				return this.dataWideLabtoolDeviceProvisioningServiceIDScope_43553.Value;
			}
			set
			{
				short num = (short)1759267105;
				short num2 = num;
				num = (short)1368869153;
				switch (num2 == num)
				{
				}
				num = (short)217513985;
				if (num != 0)
				{
				}
				num = (short)857276416;
				short num3 = num;
				num = (short)1219100672;
				if (num != 0)
				{
				}
				this.dataWideLabtoolDeviceProvisioningServiceIDScope_43553.Value = value;
			}
		}

		// Token: 0x170053D4 RID: 21460
		// (get) Token: 0x0600A6FF RID: 42751 RVA: 0x009B6E6C File Offset: 0x009B506C
		public global::AcpBusinessLayer.AcpField<string> DataWideLabtoolDeviceProvisioningServiceIDScope_43553
		{
			get
			{
				short num = (short)1548873488;
				short num2 = num;
				num = (short)199946000;
				switch (num2 == num)
				{
				}
				num = (short)196476929;
				if (num != 0)
				{
				}
				num = (short)398393344;
				short num3 = num;
				num = (short)2140536832;
				if (num != 0)
				{
				}
				return this.dataWideLabtoolDeviceProvisioningServiceIDScope_43553;
			}
		}

		// Token: 0x170053D5 RID: 21461
		// (get) Token: 0x0600A700 RID: 42752 RVA: 0x009B6F1C File Offset: 0x009B511C
		// (set) Token: 0x0600A701 RID: 42753 RVA: 0x009B6FD0 File Offset: 0x009B51D0
		public string DataWideLabtoolDeviceProvisioningServiceIDScope_43553_UIValue
		{
			get
			{
				short num = (short)444402044;
				short num2 = num;
				num = (short)1047726460;
				switch (num2 == num)
				{
				}
				num = (short)1367277568;
				if (num != 0)
				{
				}
				num = (short)1013317632;
				short num3 = num;
				num = (short)924647425;
				if (num != 0)
				{
				}
				return this.dataWideLabtoolDeviceProvisioningServiceIDScope_43553.Value;
			}
			set
			{
				short num = (short)991976130;
				short num2 = num;
				num = (short)230185666;
				switch (num2 == num)
				{
				}
				num = (short)673644544;
				if (num != 0)
				{
				}
				num = (short)1460731904;
				short num3 = num;
				num = (short)44105729;
				if (num != 0)
				{
				}
				this.dataWideLabtoolDeviceProvisioningServiceIDScope_43553.Value = value;
			}
		}

		// Token: 0x170053D6 RID: 21462
		// (get) Token: 0x0600A702 RID: 42754 RVA: 0x009B7084 File Offset: 0x009B5284
		// (set) Token: 0x0600A703 RID: 42755 RVA: 0x009B7138 File Offset: 0x009B5338
		public bool DataWideLabtoolDeviceProvisioningServiceIDScope_43553_Applicable
		{
			get
			{
				short num = (short)716830264;
				short num2 = num;
				num = (short)1483798072;
				switch (num2 == num)
				{
				}
				num = (short)2015625217;
				if (num != 0)
				{
				}
				num = (short)1705705472;
				short num3 = num;
				num = (short)910491648;
				if (num != 0)
				{
				}
				return this.dataWideLabtoolDeviceProvisioningServiceIDScope_43553.Applicable;
			}
			set
			{
				short num = (short)977434158;
				short num2 = num;
				num = (short)1634563630;
				switch (num2 == num)
				{
				}
				num = (short)685834240;
				if (num != 0)
				{
				}
				num = (short)2082471936;
				short num3 = num;
				num = (short)614203393;
				if (num != 0)
				{
				}
				this.dataWideLabtoolDeviceProvisioningServiceIDScope_43553.Applicable = value;
			}
		}

		// Token: 0x170053D7 RID: 21463
		// (get) Token: 0x0600A704 RID: 42756 RVA: 0x009B71EC File Offset: 0x009B53EC
		// (set) Token: 0x0600A705 RID: 42757 RVA: 0x009B72A0 File Offset: 0x009B54A0
		public bool DataWideLabtoolDeviceProvisioningServiceIDScope_43553_Valid
		{
			get
			{
				short num = (short)714812106;
				short num2 = num;
				num = (short)1309551306;
				switch (num2 == num)
				{
				}
				num = (short)1952776192;
				short num3 = num;
				num = (short)879493120;
				if (num != 0)
				{
				}
				num = (short)675479553;
				if (num != 0)
				{
				}
				return this.dataWideLabtoolDeviceProvisioningServiceIDScope_43553.Valid;
			}
			set
			{
				short num = (short)972874815;
				short num2 = num;
				num = (short)2025251903;
				switch (num2 == num)
				{
				}
				num = (short)1736638464;
				short num3 = num;
				num = (short)1194328065;
				if (num != 0)
				{
				}
				num = (short)1176829952;
				if (num != 0)
				{
				}
				this.dataWideLabtoolDeviceProvisioningServiceIDScope_43553.Valid = value;
			}
		}

		// Token: 0x170053D8 RID: 21464
		// (get) Token: 0x0600A706 RID: 42758 RVA: 0x009B7358 File Offset: 0x009B5558
		// (set) Token: 0x0600A707 RID: 42759 RVA: 0x009B7410 File Offset: 0x009B5610
		public bool DataWideLabtoolDeviceProvisioningServiceIDScope_43553_Visible
		{
			get
			{
				short num = (short)387126780;
				short num2 = num;
				num = (short)196089340;
				switch (num2 == num)
				{
				}
				num = (short)269156352;
				short num3 = num;
				num = (short)1270218752;
				if (num != 0)
				{
				}
				num = (short)315621377;
				if (num != 0)
				{
				}
				return this.dataWideLabtoolDeviceProvisioningServiceIDScope_43553.Visible;
			}
			set
			{
				short num = (short)2009581712;
				short num2 = num;
				num = (short)1479133328;
				switch (num2 == num)
				{
				}
				num = (short)525795328;
				short num3 = num;
				num = (short)445972480;
				if (num != 0)
				{
				}
				num = (short)272039937;
				if (num != 0)
				{
				}
				this.dataWideLabtoolDeviceProvisioningServiceIDScope_43553.Visible = value;
			}
		}

		// Token: 0x170053D9 RID: 21465
		// (get) Token: 0x0600A708 RID: 42760 RVA: 0x009B74C8 File Offset: 0x009B56C8
		// (set) Token: 0x0600A709 RID: 42761 RVA: 0x009B757C File Offset: 0x009B577C
		public bool DataWideLabtoolDeviceProvisioningServiceIDScope_43553_Editable
		{
			get
			{
				short num = (short)1110371990;
				short num2 = num;
				num = (short)1243868822;
				switch (num2 == num)
				{
				}
				num = (short)113377280;
				short num3 = num;
				num = (short)1787363329;
				if (num != 0)
				{
				}
				num = (short)1540292608;
				if (num != 0)
				{
				}
				return this.dataWideLabtoolDeviceProvisioningServiceIDScope_43553.Editable;
			}
			set
			{
				short num = (short)768542856;
				short num2 = num;
				num = (short)510789768;
				switch (num2 == num)
				{
				}
				num = (short)497418240;
				short num3 = num;
				num = (short)1110900736;
				if (num != 0)
				{
				}
				num = (short)69599233;
				if (num != 0)
				{
				}
				this.dataWideLabtoolDeviceProvisioningServiceIDScope_43553.Editable = value;
			}
		}

		// Token: 0x170053DA RID: 21466
		// (get) Token: 0x0600A70A RID: 42762 RVA: 0x009B7630 File Offset: 0x009B5830
		internal string DataWideLabtoolDeviceProvisioningServiceIDScope_43553_UILabel
		{
			get
			{
				short num = (short)476007831;
				short num2 = num;
				num = (short)1702382999;
				switch (num2 == num)
				{
				}
				num = (short)1662976000;
				short num3 = num;
				num = (short)214040576;
				if (num != 0)
				{
				}
				num = (short)298385409;
				if (num != 0)
				{
				}
				return this.dataWideLabtoolDeviceProvisioningServiceIDScope_43553.UIName;
			}
		}

		// Token: 0x170053DB RID: 21467
		// (get) Token: 0x0600A70B RID: 42763 RVA: 0x009B76E4 File Offset: 0x009B58E4
		// (set) Token: 0x0600A70C RID: 42764 RVA: 0x009B77A0 File Offset: 0x009B59A0
		internal bool DataWideLabtoolDeviceProvisioningServiceIDScope_43553_HiddenStatic
		{
			get
			{
				short num = (short)1905252876;
				short num2 = num;
				num = (short)486922764;
				switch (num2 == num)
				{
				}
				num = (short)282001408;
				short num3 = num;
				num = (short)1607598081;
				if (num != 0)
				{
				}
				num = (short)1888419840;
				if (num != 0)
				{
				}
				return this.dataWideLabtoolDeviceProvisioningServiceIDScope_43553.HiddenStatic;
			}
			set
			{
				short num = (short)1401323676;
				short num2 = num;
				num = (short)1744928924;
				switch (num2 == num)
				{
				}
				num = (short)1623261184;
				short num3 = num;
				num = (short)395640833;
				if (num != 0)
				{
				}
				num = (short)1923874816;
				if (num != 0)
				{
				}
				this.dataWideLabtoolDeviceProvisioningServiceIDScope_43553.HiddenStatic = value;
			}
		}

		// Token: 0x170053DC RID: 21468
		// (get) Token: 0x0600A70D RID: 42765 RVA: 0x009B7854 File Offset: 0x009B5A54
		// (set) Token: 0x0600A70E RID: 42766 RVA: 0x009B7908 File Offset: 0x009B5B08
		internal bool DataWideLabtoolDeviceProvisioningServiceIDScope_43553_HiddenDynamic
		{
			get
			{
				short num = (short)2102655365;
				short num2 = num;
				num = (short)1572600197;
				switch (num2 == num)
				{
				}
				num = (short)1888878592;
				short num3 = num;
				num = (short)2051997696;
				if (num != 0)
				{
				}
				num = (short)1423704065;
				if (num != 0)
				{
				}
				return this.dataWideLabtoolDeviceProvisioningServiceIDScope_43553.HiddenDynamic;
			}
			set
			{
				short num = (short)939606426;
				short num2 = num;
				num = (short)949109146;
				switch (num2 == num)
				{
				}
				num = (short)804454400;
				short num3 = num;
				num = (short)914227200;
				if (num != 0)
				{
				}
				num = (short)1050411009;
				if (num != 0)
				{
				}
				this.dataWideLabtoolDeviceProvisioningServiceIDScope_43553.HiddenDynamic = value;
			}
		}

		// Token: 0x170053DD RID: 21469
		// (get) Token: 0x0600A70F RID: 42767 RVA: 0x009B79C0 File Offset: 0x009B5BC0
		public bool DataWideLabtoolDeviceProvisioningServiceIDScope_43553_HasDiffs
		{
			get
			{
				short num = (short)1823238145;
				short num2 = num;
				num = (short)1081960449;
				switch (num2 == num)
				{
				}
				num = (short)34275328;
				short num3 = num;
				num = (short)1756233729;
				if (num != 0)
				{
				}
				num = (short)705560576;
				if (num != 0)
				{
				}
				return this.dataWideLabtoolDeviceProvisioningServiceIDScope_43553._HasDiffs;
			}
		}

		// Token: 0x170053DE RID: 21470
		// (get) Token: 0x0600A710 RID: 42768 RVA: 0x009B7A74 File Offset: 0x009B5C74
		// (set) Token: 0x0600A711 RID: 42769 RVA: 0x009B7B2C File Offset: 0x009B5D2C
		public string CloudRegion_43554Value
		{
			get
			{
				short num = (short)399441921;
				if (num != 0)
				{
				}
				num = (short)785528320;
				short num2 = num;
				num = (short)1093481984;
				switch (num2 == num)
				{
				default:
				{
					num = (short)182059008;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2009661440;
				if (num != 0)
				{
				}
				return this.cloudRegion_43554.Value;
			}
			set
			{
				short num = (short)434110244;
				short num2 = num;
				num = (short)966393636;
				switch (num2 == num)
				{
				}
				num = (short)672268288;
				short num3 = num;
				num = (short)1698955265;
				if (num != 0)
				{
				}
				num = (short)745275392;
				if (num != 0)
				{
				}
				this.cloudRegion_43554.Value = value;
			}
		}

		// Token: 0x170053DF RID: 21471
		// (get) Token: 0x0600A712 RID: 42770 RVA: 0x009B7BE0 File Offset: 0x009B5DE0
		public global::AcpBusinessLayer.AcpField<string> CloudRegion_43554
		{
			get
			{
				short num = (short)1317495354;
				short num2 = num;
				num = (short)1313628730;
				switch (num2 == num)
				{
				}
				num = (short)818348032;
				short num3 = num;
				num = (short)1398210561;
				if (num != 0)
				{
				}
				num = (short)1242234880;
				if (num != 0)
				{
				}
				return this.cloudRegion_43554;
			}
		}

		// Token: 0x170053E0 RID: 21472
		// (get) Token: 0x0600A713 RID: 42771 RVA: 0x009B7C90 File Offset: 0x009B5E90
		// (set) Token: 0x0600A714 RID: 42772 RVA: 0x009B7D48 File Offset: 0x009B5F48
		public string CloudRegion_43554_UIValue
		{
			get
			{
				short num = (short)999816920;
				short num2 = num;
				num = (short)145620696;
				switch (num2 == num)
				{
				}
				num = (short)1090912256;
				short num3 = num;
				num = (short)961740801;
				if (num != 0)
				{
				}
				num = (short)1419837440;
				if (num != 0)
				{
				}
				return this.cloudRegion_43554.Value;
			}
			set
			{
				short num = (short)908333862;
				short num2 = num;
				num = (short)1972572966;
				switch (num2 == num)
				{
				}
				num = (short)315817984;
				short num3 = num;
				num = (short)137625601;
				if (num != 0)
				{
				}
				num = (short)2098528256;
				if (num != 0)
				{
				}
				this.cloudRegion_43554.Value = value;
			}
		}

		// Token: 0x170053E1 RID: 21473
		// (get) Token: 0x0600A715 RID: 42773 RVA: 0x009B7DFC File Offset: 0x009B5FFC
		// (set) Token: 0x0600A716 RID: 42774 RVA: 0x009B7EB0 File Offset: 0x009B60B0
		public bool CloudRegion_43554_Applicable
		{
			get
			{
				short num = (short)1378245392;
				short num2 = num;
				num = (short)1386765072;
				switch (num2 == num)
				{
				}
				num = (short)863633408;
				short num3 = num;
				num = (short)434438144;
				if (num != 0)
				{
				}
				num = (short)308281345;
				if (num != 0)
				{
				}
				return this.cloudRegion_43554.Applicable;
			}
			set
			{
				short num = (short)1932982902;
				short num2 = num;
				num = (short)2067397238;
				switch (num2 == num)
				{
				}
				num = (short)1865744384;
				short num3 = num;
				num = (short)1962278912;
				if (num != 0)
				{
				}
				num = (short)1723006977;
				if (num != 0)
				{
				}
				this.cloudRegion_43554.Applicable = value;
			}
		}

		// Token: 0x170053E2 RID: 21474
		// (get) Token: 0x0600A717 RID: 42775 RVA: 0x009B7F64 File Offset: 0x009B6164
		// (set) Token: 0x0600A718 RID: 42776 RVA: 0x009B8018 File Offset: 0x009B6218
		public bool CloudRegion_43554_Valid
		{
			get
			{
				short num = (short)949527225;
				short num2 = num;
				num = (short)1680581305;
				switch (num2 == num)
				{
				}
				num = (short)19070976;
				short num3 = num;
				num = (short)1109655553;
				if (num != 0)
				{
				}
				num = (short)30081024;
				if (num != 0)
				{
				}
				return this.cloudRegion_43554.Valid;
			}
			set
			{
				short num = (short)1193935547;
				short num2 = num;
				num = (short)1823736507;
				switch (num2 == num)
				{
				}
				num = (short)2144010240;
				short num3 = num;
				num = (short)282394625;
				if (num != 0)
				{
				}
				num = (short)582287360;
				if (num != 0)
				{
				}
				this.cloudRegion_43554.Valid = value;
			}
		}

		// Token: 0x170053E3 RID: 21475
		// (get) Token: 0x0600A719 RID: 42777 RVA: 0x009B80D0 File Offset: 0x009B62D0
		// (set) Token: 0x0600A71A RID: 42778 RVA: 0x009B8184 File Offset: 0x009B6384
		public bool CloudRegion_43554_Visible
		{
			get
			{
				short num = (short)1150216641;
				short num2 = num;
				num = (short)555870657;
				switch (num2 == num)
				{
				}
				num = (short)68485120;
				short num3 = num;
				num = (short)1890844673;
				if (num != 0)
				{
				}
				num = (short)1697316864;
				if (num != 0)
				{
				}
				return this.cloudRegion_43554.Visible;
			}
			set
			{
				short num = (short)100080925;
				short num2 = num;
				num = (short)2056592669;
				switch (num2 == num)
				{
				}
				num = (short)2049376256;
				short num3 = num;
				num = (short)1555693569;
				if (num != 0)
				{
				}
				num = (short)2023358464;
				if (num != 0)
				{
				}
				this.cloudRegion_43554.Visible = value;
			}
		}

		// Token: 0x170053E4 RID: 21476
		// (get) Token: 0x0600A71B RID: 42779 RVA: 0x009B823C File Offset: 0x009B643C
		// (set) Token: 0x0600A71C RID: 42780 RVA: 0x009B82F0 File Offset: 0x009B64F0
		public bool CloudRegion_43554_Editable
		{
			get
			{
				short num = (short)936070532;
				short num2 = num;
				num = (short)2073775492;
				switch (num2 == num)
				{
				}
				num = (short)1244987392;
				short num3 = num;
				num = (short)1699282944;
				if (num != 0)
				{
				}
				num = (short)46399489;
				if (num != 0)
				{
				}
				return this.cloudRegion_43554.Editable;
			}
			set
			{
				short num = (short)1157556593;
				short num2 = num;
				num = (short)800450929;
				switch (num2 == num)
				{
				}
				num = (short)509280256;
				short num3 = num;
				num = (short)223019009;
				if (num != 0)
				{
				}
				num = (short)1032192000;
				if (num != 0)
				{
				}
				this.cloudRegion_43554.Editable = value;
			}
		}

		// Token: 0x170053E5 RID: 21477
		// (get) Token: 0x0600A71D RID: 42781 RVA: 0x009B83A8 File Offset: 0x009B65A8
		internal string CloudRegion_43554_UILabel
		{
			get
			{
				short num = (short)1420527498;
				short num2 = num;
				num = (short)415467402;
				switch (num2 == num)
				{
				}
				num = (short)1653145600;
				short num3 = num;
				num = (short)293797889;
				if (num != 0)
				{
				}
				num = (short)1124466688;
				if (num != 0)
				{
				}
				return this.cloudRegion_43554.UIName;
			}
		}

		// Token: 0x170053E6 RID: 21478
		// (get) Token: 0x0600A71E RID: 42782 RVA: 0x009B845C File Offset: 0x009B665C
		// (set) Token: 0x0600A71F RID: 42783 RVA: 0x009B8510 File Offset: 0x009B6710
		internal bool CloudRegion_43554_HiddenStatic
		{
			get
			{
				short num = (short)941194782;
				short num2 = num;
				num = (short)591953438;
				switch (num2 == num)
				{
				}
				num = (short)529596416;
				short num3 = num;
				num = (short)1063714817;
				if (num != 0)
				{
				}
				num = (short)98631680;
				if (num != 0)
				{
				}
				return this.cloudRegion_43554.HiddenStatic;
			}
			set
			{
				short num = (short)1571603782;
				short num2 = num;
				num = (short)546227526;
				switch (num2 == num)
				{
				}
				num = (short)904265728;
				short num3 = num;
				num = (short)935919616;
				if (num != 0)
				{
				}
				num = (short)2014969857;
				if (num != 0)
				{
				}
				this.cloudRegion_43554.HiddenStatic = value;
			}
		}

		// Token: 0x170053E7 RID: 21479
		// (get) Token: 0x0600A720 RID: 42784 RVA: 0x009B85C8 File Offset: 0x009B67C8
		// (set) Token: 0x0600A721 RID: 42785 RVA: 0x009B867C File Offset: 0x009B687C
		internal bool CloudRegion_43554_HiddenDynamic
		{
			get
			{
				short num = (short)1062627352;
				short num2 = num;
				num = (short)2041407512;
				switch (num2 == num)
				{
				}
				num = (short)853803008;
				short num3 = num;
				num = (short)1689452544;
				if (num != 0)
				{
				}
				num = (short)1754464257;
				if (num != 0)
				{
				}
				return this.cloudRegion_43554.HiddenDynamic;
			}
			set
			{
				short num = (short)894287574;
				short num2 = num;
				num = (short)507494102;
				switch (num2 == num)
				{
				}
				num = (short)1124073472;
				short num3 = num;
				num = (short)2067791873;
				if (num != 0)
				{
				}
				num = (short)1672609792;
				if (num != 0)
				{
				}
				this.cloudRegion_43554.HiddenDynamic = value;
			}
		}

		// Token: 0x170053E8 RID: 21480
		// (get) Token: 0x0600A722 RID: 42786 RVA: 0x009B8738 File Offset: 0x009B6938
		public bool CloudRegion_43554_HasDiffs
		{
			get
			{
				short num = (short)979857374;
				short num2 = num;
				num = (short)801796062;
				switch (num2 == num)
				{
				}
				num = (short)435421184;
				short num3 = num;
				num = (short)1355218945;
				if (num != 0)
				{
				}
				num = (short)1408303104;
				if (num != 0)
				{
				}
				return this.cloudRegion_43554._HasDiffs;
			}
		}

		// Token: 0x170053E9 RID: 21481
		// (get) Token: 0x0600A723 RID: 42787 RVA: 0x009B87EC File Offset: 0x009B69EC
		// (set) Token: 0x0600A724 RID: 42788 RVA: 0x009B88A0 File Offset: 0x009B6AA0
		public string DataWideLabtoolDeviceProvisioningServiceURI_43555Value
		{
			get
			{
				short num = (short)138256724;
				short num2 = num;
				num = (short)216572244;
				switch (num2 == num)
				{
				}
				num = (short)1218379776;
				short num3 = num;
				num = (short)469893120;
				if (num != 0)
				{
				}
				num = (short)1263599617;
				if (num != 0)
				{
				}
				return this.dataWideLabtoolDeviceProvisioningServiceURI_43555.Value;
			}
			set
			{
				short num = (short)274243448;
				short num2 = num;
				num = (short)669294456;
				switch (num2 == num)
				{
				}
				num = (short)487260160;
				short num3 = num;
				num = (short)786104321;
				if (num != 0)
				{
				}
				num = (short)418447360;
				if (num != 0)
				{
				}
				this.dataWideLabtoolDeviceProvisioningServiceURI_43555.Value = value;
			}
		}

		// Token: 0x170053EA RID: 21482
		// (get) Token: 0x0600A725 RID: 42789 RVA: 0x009B8958 File Offset: 0x009B6B58
		public global::AcpBusinessLayer.AcpField<string> DataWideLabtoolDeviceProvisioningServiceURI_43555
		{
			get
			{
				short num = (short)1155633721;
				short num2 = num;
				num = (short)1199084089;
				switch (num2 == num)
				{
				}
				num = (short)2107244544;
				short num3 = num;
				num = (short)2081554433;
				if (num != 0)
				{
				}
				num = (short)1981677568;
				if (num != 0)
				{
				}
				return this.dataWideLabtoolDeviceProvisioningServiceURI_43555;
			}
		}

		// Token: 0x170053EB RID: 21483
		// (get) Token: 0x0600A726 RID: 42790 RVA: 0x009B8A08 File Offset: 0x009B6C08
		// (set) Token: 0x0600A727 RID: 42791 RVA: 0x009B8AB8 File Offset: 0x009B6CB8
		public string DataWideLabtoolDeviceProvisioningServiceURI_43555_UIValue
		{
			get
			{
				short num = (short)1381663070;
				short num2 = num;
				num = (short)2115273054;
				switch (num2 == num)
				{
				}
				num = (short)1329135616;
				short num3 = num;
				num = (short)1216806913;
				if (num != 0)
				{
				}
				num = (short)1549991936;
				if (num != 0)
				{
				}
				return this.dataWideLabtoolDeviceProvisioningServiceURI_43555.Value;
			}
			set
			{
				short num = (short)1164528149;
				short num2 = num;
				num = (short)1389316629;
				switch (num2 == num)
				{
				}
				num = (short)1647640576;
				short num3 = num;
				num = (short)574423040;
				if (num != 0)
				{
				}
				num = (short)608763905;
				if (num != 0)
				{
				}
				this.dataWideLabtoolDeviceProvisioningServiceURI_43555.Value = value;
			}
		}

		// Token: 0x170053EC RID: 21484
		// (get) Token: 0x0600A728 RID: 42792 RVA: 0x009B8B70 File Offset: 0x009B6D70
		// (set) Token: 0x0600A729 RID: 42793 RVA: 0x009B8C24 File Offset: 0x009B6E24
		public bool DataWideLabtoolDeviceProvisioningServiceURI_43555_Applicable
		{
			get
			{
				short num = (short)25056763;
				short num2 = num;
				num = (short)247420411;
				switch (num2 == num)
				{
				}
				num = (short)1404829696;
				short num3 = num;
				num = (short)88211457;
				if (num != 0)
				{
				}
				num = (short)1691418624;
				if (num != 0)
				{
				}
				return this.dataWideLabtoolDeviceProvisioningServiceURI_43555.Applicable;
			}
			set
			{
				short num = (short)186305092;
				short num2 = num;
				num = (short)677300804;
				switch (num2 == num)
				{
				}
				num = (short)216465408;
				short num3 = num;
				num = (short)1987182593;
				if (num != 0)
				{
				}
				num = (short)1262616576;
				if (num != 0)
				{
				}
				this.dataWideLabtoolDeviceProvisioningServiceURI_43555.Applicable = value;
			}
		}

		// Token: 0x170053ED RID: 21485
		// (get) Token: 0x0600A72A RID: 42794 RVA: 0x009B8CDC File Offset: 0x009B6EDC
		// (set) Token: 0x0600A72B RID: 42795 RVA: 0x009B8D90 File Offset: 0x009B6F90
		public bool DataWideLabtoolDeviceProvisioningServiceURI_43555_Valid
		{
			get
			{
				short num = (short)1915957270;
				short num2 = num;
				num = (short)1694445590;
				switch (num2 == num)
				{
				}
				num = (short)1918435328;
				short num3 = num;
				num = (short)2067070976;
				if (num != 0)
				{
				}
				num = (short)1793982465;
				if (num != 0)
				{
				}
				return this.dataWideLabtoolDeviceProvisioningServiceURI_43555.Valid;
			}
			set
			{
				short num = (short)317815191;
				short num2 = num;
				num = (short)1487501719;
				switch (num2 == num)
				{
				}
				num = (short)2043478016;
				short num3 = num;
				num = (short)1433927681;
				if (num != 0)
				{
				}
				num = (short)837484544;
				if (num != 0)
				{
				}
				this.dataWideLabtoolDeviceProvisioningServiceURI_43555.Valid = value;
			}
		}

		// Token: 0x170053EE RID: 21486
		// (get) Token: 0x0600A72C RID: 42796 RVA: 0x009B8E44 File Offset: 0x009B7044
		// (set) Token: 0x0600A72D RID: 42797 RVA: 0x009B8EF8 File Offset: 0x009B70F8
		public bool DataWideLabtoolDeviceProvisioningServiceURI_43555_Visible
		{
			get
			{
				short num = (short)752454347;
				short num2 = num;
				num = (short)860719819;
				switch (num2 == num)
				{
				}
				num = (short)1674641408;
				short num3 = num;
				num = (short)213647361;
				if (num != 0)
				{
				}
				num = (short)1495269376;
				if (num != 0)
				{
				}
				return this.dataWideLabtoolDeviceProvisioningServiceURI_43555.Visible;
			}
			set
			{
				short num = (short)163356218;
				short num2 = num;
				num = (short)1695915578;
				switch (num2 == num)
				{
				}
				num = (short)758906880;
				short num3 = num;
				num = (short)1402404865;
				if (num != 0)
				{
				}
				num = (short)545718272;
				if (num != 0)
				{
				}
				this.dataWideLabtoolDeviceProvisioningServiceURI_43555.Visible = value;
			}
		}

		// Token: 0x170053EF RID: 21487
		// (get) Token: 0x0600A72E RID: 42798 RVA: 0x009B8FAC File Offset: 0x009B71AC
		// (set) Token: 0x0600A72F RID: 42799 RVA: 0x009B9060 File Offset: 0x009B7260
		public bool DataWideLabtoolDeviceProvisioningServiceURI_43555_Editable
		{
			get
			{
				short num = (short)1981658979;
				short num2 = num;
				num = (short)663205731;
				switch (num2 == num)
				{
				}
				num = (short)1210908672;
				short num3 = num;
				num = (short)2112946177;
				if (num != 0)
				{
				}
				num = (short)607322112;
				if (num != 0)
				{
				}
				return this.dataWideLabtoolDeviceProvisioningServiceURI_43555.Editable;
			}
			set
			{
				short num = (short)1774518626;
				short num2 = num;
				num = (short)1215168866;
				switch (num2 == num)
				{
				}
				num = (short)1647509504;
				short num3 = num;
				num = (short)2025521153;
				if (num != 0)
				{
				}
				num = (short)1828519936;
				if (num != 0)
				{
				}
				this.dataWideLabtoolDeviceProvisioningServiceURI_43555.Editable = value;
			}
		}

		// Token: 0x170053F0 RID: 21488
		// (get) Token: 0x0600A730 RID: 42800 RVA: 0x009B9114 File Offset: 0x009B7314
		internal string DataWideLabtoolDeviceProvisioningServiceURI_43555_UILabel
		{
			get
			{
				short num = (short)701054187;
				short num2 = num;
				num = (short)408567019;
				switch (num2 == num)
				{
				}
				num = (short)1417216000;
				short num3 = num;
				num = (short)664469504;
				if (num != 0)
				{
				}
				num = (short)707067905;
				if (num != 0)
				{
				}
				return this.dataWideLabtoolDeviceProvisioningServiceURI_43555.UIName;
			}
		}

		// Token: 0x170053F1 RID: 21489
		// (get) Token: 0x0600A731 RID: 42801 RVA: 0x009B91C8 File Offset: 0x009B73C8
		// (set) Token: 0x0600A732 RID: 42802 RVA: 0x009B927C File Offset: 0x009B747C
		internal bool DataWideLabtoolDeviceProvisioningServiceURI_43555_HiddenStatic
		{
			get
			{
				short num = (short)1949608147;
				short num2 = num;
				num = (short)1428859091;
				switch (num2 == num)
				{
				}
				num = (short)91815936;
				short num3 = num;
				num = (short)752353280;
				if (num != 0)
				{
				}
				num = (short)563281921;
				if (num != 0)
				{
				}
				return this.dataWideLabtoolDeviceProvisioningServiceURI_43555.HiddenStatic;
			}
			set
			{
				short num = (short)1853093083;
				short num2 = num;
				num = (short)773911771;
				switch (num2 == num)
				{
				}
				num = (short)246022144;
				short num3 = num;
				num = (short)1607532545;
				if (num != 0)
				{
				}
				num = (short)1197670400;
				if (num != 0)
				{
				}
				this.dataWideLabtoolDeviceProvisioningServiceURI_43555.HiddenStatic = value;
			}
		}

		// Token: 0x170053F2 RID: 21490
		// (get) Token: 0x0600A733 RID: 42803 RVA: 0x009B9330 File Offset: 0x009B7530
		// (set) Token: 0x0600A734 RID: 42804 RVA: 0x009B93E4 File Offset: 0x009B75E4
		internal bool DataWideLabtoolDeviceProvisioningServiceURI_43555_HiddenDynamic
		{
			get
			{
				short num = (short)1498415104;
				short num2 = num;
				num = (short)237775536;
				short num3 = num;
				num = (short)1013590704;
				switch (num3 == num)
				{
				}
				num = (short)1649803264;
				if (num != 0)
				{
				}
				num = (short)471662593;
				if (num != 0)
				{
				}
				return this.dataWideLabtoolDeviceProvisioningServiceURI_43555.HiddenDynamic;
			}
			set
			{
				short num = (short)717422592;
				short num2 = num;
				num = (short)1845589740;
				short num3 = num;
				num = (short)215643884;
				switch (num3 == num)
				{
				}
				num = (short)30277633;
				if (num != 0)
				{
				}
				num = (short)2100625408;
				if (num != 0)
				{
				}
				this.dataWideLabtoolDeviceProvisioningServiceURI_43555.HiddenDynamic = value;
			}
		}

		// Token: 0x170053F3 RID: 21491
		// (get) Token: 0x0600A735 RID: 42805 RVA: 0x009B9498 File Offset: 0x009B7698
		public bool DataWideLabtoolDeviceProvisioningServiceURI_43555_HasDiffs
		{
			get
			{
				short num = (short)734003200;
				short num2 = num;
				num = (short)823806536;
				short num3 = num;
				num = (short)100616776;
				switch (num3 == num)
				{
				}
				num = (short)1400242177;
				if (num != 0)
				{
				}
				num = (short)1700659200;
				if (num != 0)
				{
				}
				return this.dataWideLabtoolDeviceProvisioningServiceURI_43555._HasDiffs;
			}
		}

		// Token: 0x170053F4 RID: 21492
		// (get) Token: 0x0600A736 RID: 42806 RVA: 0x009B954C File Offset: 0x009B774C
		// (set) Token: 0x0600A737 RID: 42807 RVA: 0x009B9600 File Offset: 0x009B7800
		public string DataWideIdentityManagementGatewayHostname_43556Value
		{
			get
			{
				short num = (short)1867186176;
				short num2 = num;
				num = (short)300932073;
				short num3 = num;
				num = (short)598006761;
				switch (num3 == num)
				{
				}
				num = (short)978124800;
				if (num != 0)
				{
				}
				num = (short)1239547905;
				if (num != 0)
				{
				}
				return this.dataWideIdentityManagementGatewayHostname_43556.Value;
			}
			set
			{
				short num = (short)1511522304;
				short num2 = num;
				num = (short)1725804140;
				short num3 = num;
				num = (short)355970668;
				switch (num3 == num)
				{
				}
				num = (short)904331264;
				if (num != 0)
				{
				}
				num = (short)1291321345;
				if (num != 0)
				{
				}
				this.dataWideIdentityManagementGatewayHostname_43556.Value = value;
			}
		}

		// Token: 0x170053F5 RID: 21493
		// (get) Token: 0x0600A738 RID: 42808 RVA: 0x009B96B8 File Offset: 0x009B78B8
		public global::AcpBusinessLayer.AcpField<string> DataWideIdentityManagementGatewayHostname_43556
		{
			get
			{
				short num = (short)531628032;
				short num2 = num;
				num = (short)1522728961;
				if (num != 0)
				{
				}
				num = (short)1808162892;
				short num3 = num;
				num = (short)2138529868;
				switch (num3 == num)
				{
				}
				num = (short)1943994368;
				if (num != 0)
				{
				}
				return this.dataWideIdentityManagementGatewayHostname_43556;
			}
		}

		// Token: 0x170053F6 RID: 21494
		// (get) Token: 0x0600A739 RID: 42809 RVA: 0x009B9768 File Offset: 0x009B7968
		// (set) Token: 0x0600A73A RID: 42810 RVA: 0x009B9818 File Offset: 0x009B7A18
		public string DataWideIdentityManagementGatewayHostname_43556_UIValue
		{
			get
			{
				short num = (short)73859072;
				short num2 = num;
				num = (short)2039742465;
				if (num != 0)
				{
				}
				num = (short)1484346239;
				short num3 = num;
				num = (short)1651069823;
				switch (num3 == num)
				{
				}
				num = (short)1257504768;
				if (num != 0)
				{
				}
				return this.dataWideIdentityManagementGatewayHostname_43556.Value;
			}
			set
			{
				short num = (short)1274544128;
				short num2 = num;
				num = (short)1555067762;
				short num3 = num;
				num = (short)627274610;
				switch (num3 == num)
				{
				}
				num = (short)1399390209;
				if (num != 0)
				{
				}
				num = (short)680460288;
				if (num != 0)
				{
				}
				this.dataWideIdentityManagementGatewayHostname_43556.Value = value;
			}
		}

		// Token: 0x170053F7 RID: 21495
		// (get) Token: 0x0600A73B RID: 42811 RVA: 0x009B98CC File Offset: 0x009B7ACC
		// (set) Token: 0x0600A73C RID: 42812 RVA: 0x009B9980 File Offset: 0x009B7B80
		public bool DataWideIdentityManagementGatewayHostname_43556_Applicable
		{
			get
			{
				short num = (short)615120896;
				short num2 = num;
				num = (short)561791241;
				short num3 = num;
				num = (short)2043953417;
				switch (num3 == num)
				{
				}
				num = (short)365166593;
				if (num != 0)
				{
				}
				num = (short)50462720;
				if (num != 0)
				{
				}
				return this.dataWideIdentityManagementGatewayHostname_43556.Applicable;
			}
			set
			{
				short num = (short)1552941056;
				short num2 = num;
				num = (short)524142369;
				short num3 = num;
				num = (short)788121377;
				switch (num3 == num)
				{
				}
				num = (short)1757478912;
				if (num != 0)
				{
				}
				num = (short)590413825;
				if (num != 0)
				{
				}
				this.dataWideIdentityManagementGatewayHostname_43556.Applicable = value;
			}
		}

		// Token: 0x170053F8 RID: 21496
		// (get) Token: 0x0600A73D RID: 42813 RVA: 0x009B9A38 File Offset: 0x009B7C38
		// (set) Token: 0x0600A73E RID: 42814 RVA: 0x009B9AEC File Offset: 0x009B7CEC
		public bool DataWideIdentityManagementGatewayHostname_43556_Valid
		{
			get
			{
				short num = (short)836698112;
				short num2 = num;
				num = (short)1020919809;
				if (num != 0)
				{
				}
				num = (short)1100466296;
				short num3 = num;
				num = (short)766167160;
				switch (num3 == num)
				{
				}
				num = (short)314900480;
				if (num != 0)
				{
				}
				return this.dataWideIdentityManagementGatewayHostname_43556.Valid;
			}
			set
			{
				short num = (short)1245773824;
				short num2 = num;
				num = (short)257744670;
				short num3 = num;
				num = (short)932831006;
				switch (num3 == num)
				{
				}
				num = (short)452395009;
				if (num != 0)
				{
				}
				num = (short)267976704;
				if (num != 0)
				{
				}
				this.dataWideIdentityManagementGatewayHostname_43556.Valid = value;
			}
		}

		// Token: 0x170053F9 RID: 21497
		// (get) Token: 0x0600A73F RID: 42815 RVA: 0x009B9BA4 File Offset: 0x009B7DA4
		// (set) Token: 0x0600A740 RID: 42816 RVA: 0x009B9C58 File Offset: 0x009B7E58
		public bool DataWideIdentityManagementGatewayHostname_43556_Visible
		{
			get
			{
				short num = (short)1835794432;
				short num2 = num;
				num = (short)765617932;
				short num3 = num;
				num = (short)1605723916;
				switch (num3 == num)
				{
				}
				num = (short)2130771969;
				if (num != 0)
				{
				}
				num = (short)488570880;
				if (num != 0)
				{
				}
				return this.dataWideIdentityManagementGatewayHostname_43556.Visible;
			}
			set
			{
				short num = (short)449970176;
				short num2 = num;
				num = (short)136118273;
				if (num != 0)
				{
				}
				num = (short)1078102634;
				short num3 = num;
				num = (short)807832170;
				switch (num3 == num)
				{
				}
				num = (short)1097334784;
				if (num != 0)
				{
				}
				this.dataWideIdentityManagementGatewayHostname_43556.Visible = value;
			}
		}

		// Token: 0x170053FA RID: 21498
		// (get) Token: 0x0600A741 RID: 42817 RVA: 0x009B9D10 File Offset: 0x009B7F10
		// (set) Token: 0x0600A742 RID: 42818 RVA: 0x009B9DC4 File Offset: 0x009B7FC4
		public bool DataWideIdentityManagementGatewayHostname_43556_Editable
		{
			get
			{
				short num = (short)248971264;
				short num2 = num;
				num = (short)49086465;
				if (num != 0)
				{
				}
				num = (short)2007664721;
				short num3 = num;
				num = (short)1255180369;
				switch (num3 == num)
				{
				}
				num = (short)788201472;
				if (num != 0)
				{
				}
				return this.dataWideIdentityManagementGatewayHostname_43556.Editable;
			}
			set
			{
				short num = (short)400818176;
				short num2 = num;
				num = (short)1028878835;
				short num3 = num;
				num = (short)1759474163;
				switch (num3 == num)
				{
				}
				num = (short)1374158849;
				if (num != 0)
				{
				}
				num = (short)985137152;
				if (num != 0)
				{
				}
				this.dataWideIdentityManagementGatewayHostname_43556.Editable = value;
			}
		}

		// Token: 0x170053FB RID: 21499
		// (get) Token: 0x0600A743 RID: 42819 RVA: 0x009B9E7C File Offset: 0x009B807C
		internal string DataWideIdentityManagementGatewayHostname_43556_UILabel
		{
			get
			{
				short num = (short)742391808;
				short num2 = num;
				num = (short)711786497;
				if (num != 0)
				{
				}
				num = (short)442745285;
				short num3 = num;
				num = (short)938983877;
				switch (num3 == num)
				{
				}
				num = (short)1376124928;
				if (num != 0)
				{
				}
				return this.dataWideIdentityManagementGatewayHostname_43556.UIName;
			}
		}

		// Token: 0x170053FC RID: 21500
		// (get) Token: 0x0600A744 RID: 42820 RVA: 0x009B9F30 File Offset: 0x009B8130
		// (set) Token: 0x0600A745 RID: 42821 RVA: 0x009B9FE0 File Offset: 0x009B81E0
		internal bool DataWideIdentityManagementGatewayHostname_43556_HiddenStatic
		{
			get
			{
				short num = (short)1916010496;
				short num2 = num;
				num = (short)1233422759;
				short num3 = num;
				num = (short)462064039;
				switch (num3 == num)
				{
				}
				num = (short)1124532224;
				if (num != 0)
				{
				}
				num = (short)1374683137;
				if (num != 0)
				{
				}
				return this.dataWideIdentityManagementGatewayHostname_43556.HiddenStatic;
			}
			set
			{
				short num = (short)1740439552;
				short num2 = num;
				num = (short)1201840198;
				short num3 = num;
				num = (short)1610784838;
				switch (num3 == num)
				{
				}
				num = (short)602341376;
				if (num != 0)
				{
				}
				num = (short)345309185;
				if (num != 0)
				{
				}
				this.dataWideIdentityManagementGatewayHostname_43556.HiddenStatic = value;
			}
		}

		// Token: 0x170053FD RID: 21501
		// (get) Token: 0x0600A746 RID: 42822 RVA: 0x009BA094 File Offset: 0x009B8294
		// (set) Token: 0x0600A747 RID: 42823 RVA: 0x009BA144 File Offset: 0x009B8344
		internal bool DataWideIdentityManagementGatewayHostname_43556_HiddenDynamic
		{
			get
			{
				short num = (short)121962496;
				short num2 = num;
				num = (short)429246601;
				short num3 = num;
				num = (short)393005193;
				switch (num3 == num)
				{
				}
				num = (short)1894449153;
				if (num != 0)
				{
				}
				num = (short)1162018816;
				if (num != 0)
				{
				}
				return this.dataWideIdentityManagementGatewayHostname_43556.HiddenDynamic;
			}
			set
			{
				short num = (short)798556160;
				short num2 = num;
				num = (short)1384948678;
				short num3 = num;
				num = (short)1455465414;
				switch (num3 == num)
				{
				}
				num = (short)1845493760;
				if (num != 0)
				{
				}
				num = (short)1080688641;
				if (num != 0)
				{
				}
				this.dataWideIdentityManagementGatewayHostname_43556.HiddenDynamic = value;
			}
		}

		// Token: 0x170053FE RID: 21502
		// (get) Token: 0x0600A748 RID: 42824 RVA: 0x009BA1FC File Offset: 0x009B83FC
		public bool DataWideIdentityManagementGatewayHostname_43556_HasDiffs
		{
			get
			{
				short num = (short)1706885120;
				short num2 = num;
				num = (short)2053406150;
				short num3 = num;
				num = (short)2103868870;
				switch (num3 == num)
				{
				}
				num = (short)1859452929;
				if (num != 0)
				{
				}
				num = (short)1296564224;
				if (num != 0)
				{
				}
				return this.dataWideIdentityManagementGatewayHostname_43556._HasDiffs;
			}
		}

		// Token: 0x170053FF RID: 21503
		// (get) Token: 0x0600A749 RID: 42825 RVA: 0x009BA2B0 File Offset: 0x009B84B0
		// (set) Token: 0x0600A74A RID: 42826 RVA: 0x009BA364 File Offset: 0x009B8564
		public string DataWideVirtualPartnerGatewayHostname_43557Value
		{
			get
			{
				short num = (short)590086144;
				short num2 = num;
				num = (short)875173924;
				short num3 = num;
				num = (short)1000740900;
				switch (num3 == num)
				{
				}
				num = (short)521469953;
				if (num != 0)
				{
				}
				num = (short)1364656128;
				if (num != 0)
				{
				}
				return this.dataWideVirtualPartnerGatewayHostname_43557.Value;
			}
			set
			{
				short num = (short)1867186176;
				short num2 = num;
				num = (short)2056300764;
				short num3 = num;
				num = (short)866298076;
				switch (num3 == num)
				{
				}
				num = (short)1949106177;
				if (num != 0)
				{
				}
				num = (short)477495296;
				if (num != 0)
				{
				}
				this.dataWideVirtualPartnerGatewayHostname_43557.Value = value;
			}
		}

		// Token: 0x17005400 RID: 21504
		// (get) Token: 0x0600A74B RID: 42827 RVA: 0x009BA41C File Offset: 0x009B861C
		public global::AcpBusinessLayer.AcpField<string> DataWideVirtualPartnerGatewayHostname_43557
		{
			get
			{
				short num = (short)1233780736;
				short num2 = num;
				num = (short)2032093410;
				short num3 = num;
				num = (short)942950626;
				switch (num3 == num)
				{
				}
				num = (short)659030016;
				if (num != 0)
				{
				}
				num = (short)1147142145;
				if (num != 0)
				{
				}
				return this.dataWideVirtualPartnerGatewayHostname_43557;
			}
		}

		// Token: 0x17005401 RID: 21505
		// (get) Token: 0x0600A74C RID: 42828 RVA: 0x009BA4D0 File Offset: 0x009B86D0
		// (set) Token: 0x0600A74D RID: 42829 RVA: 0x009BA584 File Offset: 0x009B8784
		public string DataWideVirtualPartnerGatewayHostname_43557_UIValue
		{
			get
			{
				short num = (short)1054212096;
				short num2 = num;
				num = (short)267922169;
				short num3 = num;
				num = (short)532097785;
				switch (num3 == num)
				{
				}
				num = (short)2094465024;
				if (num != 0)
				{
				}
				num = (short)1801715713;
				if (num != 0)
				{
				}
				return this.dataWideVirtualPartnerGatewayHostname_43557.Value;
			}
			set
			{
				short num = (short)1251475456;
				short num2 = num;
				num = (short)222658782;
				short num3 = num;
				num = (short)2069004510;
				switch (num3 == num)
				{
				}
				num = (short)842530817;
				if (num != 0)
				{
				}
				num = (short)247070720;
				if (num != 0)
				{
				}
				this.dataWideVirtualPartnerGatewayHostname_43557.Value = value;
			}
		}

		// Token: 0x17005402 RID: 21506
		// (get) Token: 0x0600A74E RID: 42830 RVA: 0x009BA63C File Offset: 0x009B883C
		// (set) Token: 0x0600A74F RID: 42831 RVA: 0x009BA6EC File Offset: 0x009B88EC
		public bool DataWideVirtualPartnerGatewayHostname_43557_Applicable
		{
			get
			{
				short num = (short)82903040;
				short num2 = num;
				num = (short)1264261101;
				short num3 = num;
				num = (short)1525749741;
				switch (num3 == num)
				{
				}
				num = (short)1984888832;
				if (num != 0)
				{
				}
				num = (short)23068673;
				if (num != 0)
				{
				}
				return this.dataWideVirtualPartnerGatewayHostname_43557.Applicable;
			}
			set
			{
				short num = (short)1226833920;
				short num2 = num;
				num = (short)267281537;
				short num3 = num;
				num = (short)1948673153;
				switch (num3 == num)
				{
				}
				num = (short)1366228993;
				if (num != 0)
				{
				}
				num = (short)2069495808;
				if (num != 0)
				{
				}
				this.dataWideVirtualPartnerGatewayHostname_43557.Applicable = value;
			}
		}

		// Token: 0x17005403 RID: 21507
		// (get) Token: 0x0600A750 RID: 42832 RVA: 0x009BA7A0 File Offset: 0x009B89A0
		// (set) Token: 0x0600A751 RID: 42833 RVA: 0x009BA854 File Offset: 0x009B8A54
		public bool DataWideVirtualPartnerGatewayHostname_43557_Valid
		{
			get
			{
				short num = (short)931790848;
				short num2 = num;
				num = (short)1475490397;
				short num3 = num;
				num = (short)73478749;
				switch (num3 == num)
				{
				}
				num = (short)840237057;
				if (num != 0)
				{
				}
				num = (short)1590820864;
				if (num != 0)
				{
				}
				return this.dataWideVirtualPartnerGatewayHostname_43557.Valid;
			}
			set
			{
				short num = (short)1985937408;
				short num2 = num;
				num = (short)1557535675;
				short num3 = num;
				num = (short)790371259;
				switch (num3 == num)
				{
				}
				num = (short)1051852800;
				if (num != 0)
				{
				}
				num = (short)601489409;
				if (num != 0)
				{
				}
				this.dataWideVirtualPartnerGatewayHostname_43557.Valid = value;
			}
		}

		// Token: 0x17005404 RID: 21508
		// (get) Token: 0x0600A752 RID: 42834 RVA: 0x009BA908 File Offset: 0x009B8B08
		// (set) Token: 0x0600A753 RID: 42835 RVA: 0x009BA9C0 File Offset: 0x009B8BC0
		public bool DataWideVirtualPartnerGatewayHostname_43557_Visible
		{
			get
			{
				short num = (short)203882496;
				short num2 = num;
				num = (short)25886721;
				if (num != 0)
				{
				}
				num = (short)904335513;
				short num3 = num;
				num = (short)1876889753;
				switch (num3 == num)
				{
				}
				num = (short)1726152704;
				if (num != 0)
				{
				}
				return this.dataWideVirtualPartnerGatewayHostname_43557.Visible;
			}
			set
			{
				short num = (short)314834944;
				short num2 = num;
				num = (short)1437810845;
				short num3 = num;
				num = (short)2063089821;
				switch (num3 == num)
				{
				}
				num = (short)807993345;
				if (num != 0)
				{
				}
				num = (short)1179516928;
				if (num != 0)
				{
				}
				this.dataWideVirtualPartnerGatewayHostname_43557.Visible = value;
			}
		}

		// Token: 0x17005405 RID: 21509
		// (get) Token: 0x0600A754 RID: 42836 RVA: 0x009BAA74 File Offset: 0x009B8C74
		// (set) Token: 0x0600A755 RID: 42837 RVA: 0x009BAB2C File Offset: 0x009B8D2C
		public bool DataWideVirtualPartnerGatewayHostname_43557_Editable
		{
			get
			{
				short num = (short)166395904;
				short num2 = num;
				num = (short)356422319;
				short num3 = num;
				num = (short)298554031;
				switch (num3 == num)
				{
				}
				num = (short)907542528;
				if (num != 0)
				{
				}
				num = (short)2125004801;
				if (num != 0)
				{
				}
				return this.dataWideVirtualPartnerGatewayHostname_43557.Editable;
			}
			set
			{
				short num = (short)1610022912;
				short num2 = num;
				num = (short)496259950;
				short num3 = num;
				num = (short)1426805614;
				switch (num3 == num)
				{
				}
				num = (short)116064256;
				if (num != 0)
				{
				}
				num = (short)111804417;
				if (num != 0)
				{
				}
				this.dataWideVirtualPartnerGatewayHostname_43557.Editable = value;
			}
		}

		// Token: 0x17005406 RID: 21510
		// (get) Token: 0x0600A756 RID: 42838 RVA: 0x009BABE0 File Offset: 0x009B8DE0
		internal string DataWideVirtualPartnerGatewayHostname_43557_UILabel
		{
			get
			{
				short num = (short)927399936;
				short num2 = num;
				num = (short)474828377;
				short num3 = num;
				num = (short)737365593;
				switch (num3 == num)
				{
				}
				num = (short)612433921;
				if (num != 0)
				{
				}
				num = (short)1184563200;
				if (num != 0)
				{
				}
				return this.dataWideVirtualPartnerGatewayHostname_43557.UIName;
			}
		}

		// Token: 0x17005407 RID: 21511
		// (get) Token: 0x0600A757 RID: 42839 RVA: 0x009BAC98 File Offset: 0x009B8E98
		// (set) Token: 0x0600A758 RID: 42840 RVA: 0x009BAD48 File Offset: 0x009B8F48
		internal bool DataWideVirtualPartnerGatewayHostname_43557_HiddenStatic
		{
			get
			{
				short num = (short)95617024;
				short num2 = num;
				num = (short)1988165633;
				if (num != 0)
				{
				}
				num = (short)1416109519;
				short num3 = num;
				num = (short)1610423759;
				switch (num3 == num)
				{
				}
				num = (short)607780864;
				if (num != 0)
				{
				}
				return this.dataWideVirtualPartnerGatewayHostname_43557.HiddenStatic;
			}
			set
			{
				short num = (short)1093992448;
				short num2 = num;
				num = (short)2138694380;
				short num3 = num;
				num = (short)1974657772;
				switch (num3 == num)
				{
				}
				num = (short)158859265;
				if (num != 0)
				{
				}
				num = (short)1441988608;
				if (num != 0)
				{
				}
				this.dataWideVirtualPartnerGatewayHostname_43557.HiddenStatic = value;
			}
		}

		// Token: 0x17005408 RID: 21512
		// (get) Token: 0x0600A759 RID: 42841 RVA: 0x009BAE00 File Offset: 0x009B9000
		// (set) Token: 0x0600A75A RID: 42842 RVA: 0x009BAEB4 File Offset: 0x009B90B4
		internal bool DataWideVirtualPartnerGatewayHostname_43557_HiddenDynamic
		{
			get
			{
				short num = (short)1057554432;
				short num2 = num;
				num = (short)1158529393;
				short num3 = num;
				num = (short)860864881;
				switch (num3 == num)
				{
				}
				num = (short)978518017;
				if (num != 0)
				{
				}
				num = (short)1284177920;
				if (num != 0)
				{
				}
				return this.dataWideVirtualPartnerGatewayHostname_43557.HiddenDynamic;
			}
			set
			{
				short num = (short)1683030016;
				short num2 = num;
				num = (short)1296777479;
				short num3 = num;
				num = (short)1387086087;
				switch (num3 == num)
				{
				}
				num = (short)840237056;
				if (num != 0)
				{
				}
				num = (short)897843201;
				if (num != 0)
				{
				}
				this.dataWideVirtualPartnerGatewayHostname_43557.HiddenDynamic = value;
			}
		}

		// Token: 0x17005409 RID: 21513
		// (get) Token: 0x0600A75B RID: 42843 RVA: 0x009BAF68 File Offset: 0x009B9168
		public bool DataWideVirtualPartnerGatewayHostname_43557_HasDiffs
		{
			get
			{
				short num = (short)907345920;
				short num2 = num;
				num = (short)224480249;
				short num3 = num;
				num = (short)937577465;
				switch (num3 == num)
				{
				}
				num = (short)1570308097;
				if (num != 0)
				{
				}
				num = (short)1581449216;
				if (num != 0)
				{
				}
				return this.dataWideVirtualPartnerGatewayHostname_43557._HasDiffs;
			}
		}

		// Token: 0x0600A75C RID: 42844 RVA: 0x009BB01C File Offset: 0x009B921C
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
						num2 = (short)1751121924;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 1:
				{
					num2 = (short)254738432;
					short num3 = num2;
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)829161475;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					goto IL_110;
				case 3:
					goto IL_D0;
				case 4:
				{
					num2 = (short)874127046;
					short num4 = num2;
					num2 = (short)923606726;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_110;
					default:
						num2 = (short)989003776;
						if (num2 != 0)
						{
						}
						num2 = (short)105054210;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_24;
				IL_110:
				if (base.ParentRecset.ContainerDoc == null)
				{
					return result;
				}
				num2 = (short)58589185;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_D0:
			num2 = (short)1215561729;
			if (num2 != 0)
			{
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)204996608;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0400511E RID: 20766
		private global::AcpBusinessLayer.AcpSimpleRangeField labtoolContextActivationHoldoffTimerSec;

		// Token: 0x0400511F RID: 20767
		private global::AcpBusinessLayer.AcpSimpleRangeField dataWideLabtoolDATA_CFGOTAPDefaultInactivityTimer_A8668;

		// Token: 0x04005120 RID: 20768
		private global::AcpBusinessLayer.AcpSimpleRangeField labtoolContextRenewalTimerMin;

		// Token: 0x04005121 RID: 20769
		private global::AcpBusinessLayer.AcpSimpleRangeField dataWideLabtoolDATA_CFGPacketDataActivateWaitTimerSec_A8686;

		// Token: 0x04005122 RID: 20770
		private global::AcpBusinessLayer.AcpSimpleRangeField labtoolDefaultReadyTimerSec;

		// Token: 0x04005123 RID: 20771
		private global::AcpBusinessLayer.AcpSimpleRangeField dataWideDVRSActWaitTime_A40128;

		// Token: 0x04005124 RID: 20772
		private global::AcpBusinessLayer.AcpSimpleRangeField randomAccessAckTimerMsec_42016;

		// Token: 0x04005125 RID: 20773
		private global::AcpBusinessLayer.AcpField<string> dataWideLabtoolDeviceProvisioningServiceIDScope_43553;

		// Token: 0x04005126 RID: 20774
		private global::AcpBusinessLayer.AcpField<string> cloudRegion_43554;

		// Token: 0x04005127 RID: 20775
		private global::AcpBusinessLayer.AcpField<string> dataWideLabtoolDeviceProvisioningServiceURI_43555;

		// Token: 0x04005128 RID: 20776
		private global::AcpBusinessLayer.AcpField<string> dataWideIdentityManagementGatewayHostname_43556;

		// Token: 0x04005129 RID: 20777
		private global::AcpBusinessLayer.AcpField<string> dataWideVirtualPartnerGatewayHostname_43557;
	}
}
