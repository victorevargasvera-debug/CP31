using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using ConstraintHelper;
using Motorola.MackinawCPS.CoreFeatures.EmergencyWide;

namespace Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles
{
	// Token: 0x020004A6 RID: 1190
	[global::System.Serializable]
	public class General : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06009B92 RID: 39826 RVA: 0x0091AC0C File Offset: 0x00918E0C
		public General(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06009B93 RID: 39827 RVA: 0x0091AC28 File Offset: 0x00918E28
		protected General(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06009B94 RID: 39828 RVA: 0x0091AC40 File Offset: 0x00918E40
		public override void Init()
		{
			int a_ = 15;
			short num = (short)526461314;
			short num2 = num;
			num = (short)1806313858;
			switch (num2 == num)
			{
			}
			num = (short)1859059712;
			short num3 = num;
			num = (short)2100035584;
			if (num != 0)
			{
			}
			num = (short)900136961;
			if (num != 0)
			{
			}
			this.cnvEmerProfGeneralAcknowledgeAlertTone_A7394 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("鏏병ꋓ鏕뗗뿙껛軝鋟跡苣ꇥ跧蓩觫鳭釯黱뗳闵鏷铹鏻觽泿朁怃愅洇䬉怋欍戏昑䀓礕瘗缙䌛弝ᜟᄡᴣሥ", a_), global::CommonResources.AcgResources.ID_ACKNOWLEDGEALERTTONE);
			this.cnvEmerProfGeneralAcknowledgeAlertTone_A7394.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvEmerProfGeneralAcknowledgeAlertTone_A7394.DataTransferOrder = 5;
			this.cnvEmerProfGeneralEmergencyType_A7960 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鏏병ꋓ鏕뗗뿙껛軝鋟跡苣ꇥ跧蓩觫鳭釯黱뇳鯵鷷裹鯻鯽滿愁紃刅焇稉椋儍儏┑ⴓ―⠗", a_), global::CommonResources.AcgResources.ID_EMERGENCYTYPE, global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.LOVs.CnvEmerProfGeneralEmergencyType_A7960LovStrs);
			this.cnvEmerProfGeneralEmergencyType_A7960.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvEmerProfGeneralEmergencyType_A7960.DataTransferOrder = 1;
			this.cnvEmerProfGeneralEnable3_A8171 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鏏병ꋓ鏕뗗뿙껛軝鋟跡苣ꇥ跧蓩觫鳭釯黱뇳飵駷飹郻鯽㏿崁䔃㸅㤇㴉㴋", a_), global::CommonResources.AcgResources.ID_TXMULTIPLIERTXMULTIPLIERENABLE);
			this.cnvEmerProfGeneralEnable3_A8171.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.cnvEmerProfGeneralEnable3_A8171.DataTransferOrder = 8;
			this.cnvEmerProfGeneralPoliteRetries_A8712 = new global::AcpBusinessLayer.AcpSimpleRangeField(5, this, global::AllFeatures.CodeplugGuid.b("鏏병ꋓ鏕뗗뿙껛軝鋟跡苣ꇥ跧蓩觫鳭釯黱ꓳ駵铷鏹裻鯽勿朁瀃琅愇漉缋儍儏⨑⌓✕⨗", a_), global::CommonResources.AcgResources.ID_POLITERETRIES, 0, 15, null, global::CommonResources.AcgResources.ID_INFINITE, 0, 1);
			this.cnvEmerProfGeneralPoliteRetries_A8712.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.cnvEmerProfGeneralPoliteRetries_A8712.DataTransferOrder = 11;
			this.cnvEmerProfGeneralPoliteRetries_A8712.ShowHexValue = false;
			this.cnvEmerProfGeneralFactor_A9548 = new global::AcpBusinessLayer.AcpListField(1, this, global::AllFeatures.CodeplugGuid.b("鏏병ꋓ鏕뗗뿙껛軝鋟跡苣ꇥ跧蓩觫鳭釯黱닳韵鯷軹鏻賽忿䌁㴃㌅㰇㈉", a_), global::CommonResources.AcgResources.ID_TXMULTIPLIERFACTOR, global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.LOVs.CnvEmerProfGeneralFactor_A9548LovStrs);
			this.cnvEmerProfGeneralFactor_A9548.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.cnvEmerProfGeneralFactor_A9548.DataTransferOrder = 15;
			this.cnvEmerProfGeneralkeyofConventionalEmergencyProfiles_A19418 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("鏏병ꋓ鏕뗗뿙껛軝鋟跡苣ꇥ跧蓩觫鳭釯黱鿳鏵臷闹髻뷽濿氁爃挅昇縉攋愍縏猑砓匕甗缙減礝䔟䰡䜣弥砧堩䌫䠭夯帱儳䔵朷笹഻ܽ琿獁籃", a_), global::CommonResources.AcgResources.ID_EMERGENCYPROFILENAME, 14);
			this.cnvEmerProfGeneralkeyofConventionalEmergencyProfiles_A19418.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.cnvEmerProfGeneralkeyofConventionalEmergencyProfiles_A19418.DataTransferOrder = 16;
			this.conEmerProEmergencyAutoTransmitMode_A22532 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.LOVs.indexConEmerProEmergencyAutoTransmitMode_A22532LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.LOVs.idConEmerProEmergencyAutoTransmitMode_A22532LovStrs), this, global::AllFeatures.CodeplugGuid.b("鏏뷑뫓鏕뗗뿙껛軝鋟跡ꇣ该跧飩诫语黯釱跳럵跷軹鏻꫽狿持樃甅攇按砋䌍缏瘑焓䤕夗⠙⸛⬝ጟအ", a_), global::CommonResources.AcgResources.ID_AUTOTRANSMITEMERGENCYAUTOTRANSMITMODE, global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.LOVs.ConEmerProEmergencyAutoTransmitMode_A22532LovStrs);
			this.conEmerProEmergencyAutoTransmitMode_A22532.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.conEmerProEmergencyAutoTransmitMode_A22532.DataTransferOrder = 4;
			this.cnvEmerProfGeneralTxPeriodsec1_A8212 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("鏏병ꋓ鏕뗗뿙껛軝鋟跡苣ꇥ跧蓩觫鳭釯黱ꃳ軵ꣷ鿹軻韽濿昁眃挅欇㬉匋伍⠏‑┓␕", a_), global::CommonResources.AcgResources.ID_AUTOTRANSMITHOTMICTXPERIODSECOLDFIELD, 1, 12, null, null, 0, 10);
			this.cnvEmerProfGeneralTxPeriodsec1_A8212.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvEmerProfGeneralTxPeriodsec1_A8212.DataTransferOrder = 9;
			this.cnvEmerProfGeneralTxPeriodsec1_A8212.ShowHexValue = false;
			this.cnvEmerProfGeneralImpoliteRetries_A8242 = new global::AcpBusinessLayer.AcpSimpleRangeField(15, this, global::AllFeatures.CodeplugGuid.b("鏏병ꋓ鏕뗗뿙껛軝鋟跡苣ꇥ跧蓩觫鳭釯黱뷳鯵裷闹郻韽瓿朁嘃挅簇砉攋欍挏䴑唓⸕⨗⸙⸛", a_), global::CommonResources.AcgResources.ID_IMPOLITERETRIES, 1, 15, null, null, 0, 1);
			this.cnvEmerProfGeneralImpoliteRetries_A8242.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.cnvEmerProfGeneralImpoliteRetries_A8242.DataTransferOrder = 10;
			this.cnvEmerProfGeneralImpoliteRetries_A8242.ShowHexValue = false;
			this.cnvEmerProfGeneralTxPeriodsec2_A9131 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("鏏병ꋓ鏕뗗뿙껛軝鋟跡苣ꇥ跧蓩觫鳭釯黱ꃳ軵ꣷ鿹軻韽濿昁眃挅欇㠉匋伍⤏⌑✓✕", a_), global::CommonResources.AcgResources.ID_AUTOTRANSMITSILENTAUDIOTXPERIODSEC, 1, 5, null, null, 0, 1);
			this.cnvEmerProfGeneralTxPeriodsec2_A9131.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvEmerProfGeneralTxPeriodsec2_A9131.DataTransferOrder = 13;
			this.cnvEmerProfGeneralTxPeriodsec2_A9131.ShowHexValue = false;
			this.cnvEmerProfGeneralConsoleAckRequired_A40167 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鏏병ꋓ鏕뗗뿙껛軝鋟跡苣ꇥ跧蓩觫鳭釯黱럳駵雷觹鏻鋽旿䌁會洅娇漉紋笍礏怑焓爕䜗嬙⠛⸝ᄟᐡጣ", a_), global::CommonResources.AcgResources.ID_CONSOLEACKREQUIREDDVRS);
			this.cnvEmerProfGeneralConsoleAckRequired_A40167.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvEmerProfGeneralConsoleAckRequired_A40167.DataTransferOrder = 3;
			this.cnvPerManDownEnable_42038 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("鏏병ꋓ蛕뷗꣙釛뿝軟ꛡ诣釥蛧꿩苫迭鋯黱釳꧵쳷죹쳻췽㣿", a_), global::CommonResources.AcgResources.ID_MANDOWNENABLE);
			this.cnvPerManDownEnable_42038.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.cnvPerManDownEnable_42038.DataTransferOrder = 18;
			this.cnvEmerProfEmergencyHotAuxMic_A42296 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.LOVs.indexCnvEmerProfEmergencyHotAuxMic_A42296LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.LOVs.idCnvEmerProfEmergencyHotAuxMic_A42296LovStrs), this, global::AllFeatures.CodeplugGuid.b("鏏병ꋓ鏕뗗뿙껛軝鋟跡苣ꏥ藧迩黫觭闯鳱音迵냷闹裻뿽痿稁䤃漅欇唉䴋㨍∏‑ⴓ―", a_), global::CommonResources.AcgResources.ID_AUTOTRANSMITHOTAUXMICACTIVATION, global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.LOVs.CnvEmerProfEmergencyHotAuxMic_A42296LovStrs);
			this.cnvEmerProfEmergencyHotAuxMic_A42296.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvEmerProfEmergencyHotAuxMic_A42296.DataTransferOrder = 30;
			this.cnvPerEMGFindMeTxEnable_42920 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鏏병ꋓ蛕뷗꣙駛鏝꟟ꓡ跣裥賧꟩觫뫭裯럱髳韵髷雹駻ꇽ㓿、㴃㐅㠇", a_), global::CommonResources.AcgResources.ID_EMERGENCYFINDMETRANSMITENABLE);
			this.cnvPerEMGFindMeTxEnable_42920.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.cnvPerEMGFindMeTxEnable_42920.DataTransferOrder = 25;
			this.cnvPerEMGFindMeRxEnable_42922 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鏏병ꋓ蛕뷗꣙駛鏝꟟ꓡ跣裥賧꟩觫볭裯럱髳韵髷雹駻ꇽ㓿、㴃㐅㨇", a_), global::CommonResources.AcgResources.ID_EMERGENCYFINDMERECEIVEENABLE);
			this.cnvPerEMGFindMeRxEnable_42922.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.cnvPerEMGFindMeRxEnable_42922.DataTransferOrder = 26;
			this.cnvEmerProfImpactDetectionEn_A43391 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("鏏병ꋓ鏕뗗뿙껛軝鋟跡苣꿥藧髩跫跭蓯뛱釳苵鷷駹裻韽濿氁䄃栅圇䬉㠋㴍⌏⬑┓", a_), global::CommonResources.AcgResources.ID_IMPACTDETECTIONENABLE);
			this.cnvEmerProfImpactDetectionEn_A43391.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvEmerProfImpactDetectionEn_A43391.DataTransferOrder = 22;
			this.emergencyExitOnChannelChange_43590 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("闏뿑뇓ꓕ뿗뿙닛뷝駟꟡鳣迥鳧ꗩ苫귭飯鏱髳飵鷷雹뿻雽懿氁挃挅圇㸉㼋㬍⤏∑", a_), global::CommonResources.AcgResources.ID_EMERGENCYEXITONCHANNELCHANGE);
			this.emergencyExitOnChannelChange_43590.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.emergencyExitOnChannelChange_43590.DataTransferOrder = 6;
			this.cnvEmerProfGeneralTxPeriodsec2_A43600 = new global::AcpBusinessLayer.AcpSimpleRangeField(10, this, global::AllFeatures.CodeplugGuid.b("鏏병ꋓ鏕뗗뿙껛軝鋟跡苣ꇥ跧蓩觫鳭釯黱ꃳ軵ꣷ鿹軻韽濿昁眃挅欇㠉匋伍␏ℑ∓☕⠗", a_), global::CommonResources.AcgResources.ID_AUTOTRANSMITHOTMICTXPERIODSEC, 1, 120, null, null, 0, 1);
			this.cnvEmerProfGeneralTxPeriodsec2_A43600.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvEmerProfGeneralTxPeriodsec2_A43600.DataTransferOrder = 17;
			this.cnvEmerProfGeneralTxPeriodsec2_A43600.ShowHexValue = false;
			this.cnvEmerProfGeneralRemoteActivationEmergency = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鏏병ꋓ鏕뗗뿙껛軝鋟跡苣ꇥ跧蓩觫鳭釯黱꛳鏵闷闹裻鯽䇿愁瀃漅縇欉砋服缏簑儓笕紗栙笛笝丟䄡崣", a_), global::CommonResources.AcgResources.ID_REMOTEEMERGENCYACTIVATION, global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.LOVs.CnvEmerProfGeneralRemoteActivationEmergencyLovStrs);
			this.cnvEmerProfGeneralRemoteActivationEmergency.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvEmerProfGeneralRemoteActivationEmergency.DataTransferOrder = 31;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("韏럑뫓돕꫗믙냛", a_);
			base.Id = 10184;
			base.UIName = global::CommonResources.AcgResources.ID_GENERAL;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06009B95 RID: 39829 RVA: 0x0091B1F8 File Offset: 0x009193F8
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 8;
			short num = (short)1013710891;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					this.cnvEmerProfGeneralImpoliteRetries_A8242 = new global::AcpBusinessLayer.AcpSimpleRangeField(15, this, global::AllFeatures.CodeplugGuid.b("諈ꗊ믌諎볐뛒꟔蟖ꯘ듚믜飞蓠跢胤闦裨蟪ꓬ苮臰鳲駴黶跸黺꿼髾甀焂氄戆稈吊䰌㜎⌐✒✔", a_), global::CommonResources.AcgResources.ID_IMPOLITERETRIES, null, null, 0, 1);
					this.cnvEmerProfGeneralImpoliteRetries_A8242.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.cnvEmerProfGeneralImpoliteRetries_A8242.DataTransferOrder = 10;
					this.cnvEmerProfGeneralImpoliteRetries_A8242.ShowHexValue = false;
					num = (short)131006497;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_A78;
				case 2:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("諈ꗊ믌諎볐뛒꟔蟖ꯘ듚믜飞蓠跢胤闦裨蟪꣬苮铰臲鋴鋶韸飺蓼꯾砀猂怄堆䠈㰊㐌㤎ℐ", a_)))
					{
						num = (short)1776877574;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_8E5;
				case 3:
					this.cnvEmerProfGeneralPoliteRetries_A8712 = new global::AcpBusinessLayer.AcpSimpleRangeField(5, this, global::AllFeatures.CodeplugGuid.b("諈ꗊ믌諎볐뛒꟔蟖ꯘ듚믜飞蓠跢胤闦裨蟪뷬胮鷰髲致鋶꯸黺觼跾栀昂瘄堆䠈㌊㨌㸎⌐", a_), global::CommonResources.AcgResources.ID_POLITERETRIES, null, global::CommonResources.AcgResources.ID_INFINITE, 0, 1);
					this.cnvEmerProfGeneralPoliteRetries_A8712.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.cnvEmerProfGeneralPoliteRetries_A8712.DataTransferOrder = 11;
					this.cnvEmerProfGeneralPoliteRetries_A8712.ShowHexValue = false;
					num = (short)547029020;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_682;
				case 5:
					this.cnvEmerProfEmergencyHotAuxMic_A42296 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.LOVs.indexCnvEmerProfEmergencyHotAuxMic_A42296LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.LOVs.idCnvEmerProfEmergencyHotAuxMic_A42296LovStrs), this, global::AllFeatures.CodeplugGuid.b("諈ꗊ믌諎볐뛒꟔蟖ꯘ듚믜髞賠蛢韤胦賨藪軬雮맰鳲致뛶賸菺냼雾戀専䐄㌆㬈㤊㐌㤎", a_), global::CommonResources.AcgResources.ID_AUTOTRANSMITHOTAUXMICACTIVATION, global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.LOVs.CnvEmerProfEmergencyHotAuxMic_A42296LovStrs);
					this.cnvEmerProfEmergencyHotAuxMic_A42296.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvEmerProfEmergencyHotAuxMic_A42296.DataTransferOrder = 30;
					num = (short)912523265;
					if (num != 0)
					{
					}
					num = (short)162856981;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					this.cnvEmerProfGeneralEmergencyType_A7960 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("諈ꗊ믌諎볐뛒꟔蟖ꯘ듚믜飞蓠跢胤闦裨蟪꣬苮铰臲鋴鋶韸飺蓼꯾砀猂怄堆䠈㰊㐌㤎ℐ", a_), global::CommonResources.AcgResources.ID_EMERGENCYTYPE, global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.LOVs.CnvEmerProfGeneralEmergencyType_A7960LovStrs);
					this.cnvEmerProfGeneralEmergencyType_A7960.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvEmerProfGeneralEmergencyType_A7960.DataTransferOrder = 1;
					num = (short)1818820652;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("諈ꗊ믌諎볐뛒꟔蟖ꯘ듚믜髞賠蛢韤胦賨藪軬雮맰鳲致뛶賸菺냼雾戀専䐄㌆㬈㤊㐌㤎", a_)))
					{
						num = (short)1584398341;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_173;
				case 8:
					this.cnvEmerProfGeneralTxPeriodsec2_A43600 = new global::AcpBusinessLayer.AcpSimpleRangeField(10, this, global::AllFeatures.CodeplugGuid.b("諈ꗊ믌諎볐뛒꟔蟖ꯘ듚믜飞蓠跢胤闦裨蟪맬韮ꇰ雲蟴黶雸鿺軼髾戀㄂娄䘆㴈㠊㬌㼎ℐ", a_), global::CommonResources.AcgResources.ID_AUTOTRANSMITHOTMICTXPERIODSEC, null, null, 0, 1);
					this.cnvEmerProfGeneralTxPeriodsec2_A43600.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvEmerProfGeneralTxPeriodsec2_A43600.DataTransferOrder = 17;
					this.cnvEmerProfGeneralTxPeriodsec2_A43600.ShowHexValue = false;
					num = (short)401997872;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					goto IL_71B;
				case 10:
					goto IL_1C1;
				case 11:
					goto IL_D67;
				case 12:
					if (producerFields != null)
					{
						num = (short)1802960936;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_EBC;
				case 13:
					this.conEmerProEmergencyAutoTransmitMode_A22532 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.LOVs.indexConEmerProEmergencyAutoTransmitMode_A22532LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.LOVs.idConEmerProEmergencyAutoTransmitMode_A22532LovStrs), this, global::AllFeatures.CodeplugGuid.b("諈꓊ꏌ諎볐뛒꟔蟖ꯘ듚飜닞蓠釢苤苦蟨裪铬껮蓰蟲髴ꏶ诸髺鏼賾氀樂焄䨆昈漊栌倎倐ℒ✔∖⨘⤚", a_), global::CommonResources.AcgResources.ID_AUTOTRANSMITEMERGENCYAUTOTRANSMITMODE, global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.LOVs.ConEmerProEmergencyAutoTransmitMode_A22532LovStrs);
					this.conEmerProEmergencyAutoTransmitMode_A22532.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.conEmerProEmergencyAutoTransmitMode_A22532.DataTransferOrder = 4;
					num = (short)56295470;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("諈ꗊ믌諎볐뛒꟔蟖ꯘ듚믜飞蓠跢胤闦裨蟪뷬胮鷰髲致鋶꯸黺觼跾栀昂瘄堆䠈㌊㨌㸎⌐", a_)))
					{
						num = (short)1002700803;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_43F;
				case 15:
					goto IL_A2B;
				case 16:
					this.cnvEmerProfGeneralTxPeriodsec2_A9131 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("諈ꗊ믌諎볐뛒꟔蟖ꯘ듚믜飞蓠跢胤闦裨蟪맬韮ꇰ雲蟴黶雸鿺軼髾戀㄂娄䘆〈㨊㸌㸎", a_), global::CommonResources.AcgResources.ID_AUTOTRANSMITSILENTAUDIOTXPERIODSEC, null, null, 0, 1);
					this.cnvEmerProfGeneralTxPeriodsec2_A9131.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvEmerProfGeneralTxPeriodsec2_A9131.DataTransferOrder = 13;
					this.cnvEmerProfGeneralTxPeriodsec2_A9131.ShowHexValue = false;
					num = (short)1354235914;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("諈ꗊ믌諎볐뛒꟔蟖ꯘ듚믜飞蓠跢胤闦裨蟪맬韮ꇰ雲蟴黶雸鿺軼髾戀㄂娄䘆㴈㠊㬌㼎ℐ", a_)))
					{
						num = (short)1468268552;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_C7E;
				case 18:
					this.cnvEmerProfImpactDetectionEn_A43391 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("諈ꗊ믌諎볐뛒꟔蟖ꯘ듚믜雞賠鏢蓤蓦鷨꿪裬鯮铰郲致黶雸闺룼釾帀䈂㄄㐆㨈㈊㰌", a_), global::CommonResources.AcgResources.ID_IMPACTDETECTIONENABLE);
					this.cnvEmerProfImpactDetectionEn_A43391.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvEmerProfImpactDetectionEn_A43391.DataTransferOrder = 22;
					num = (short)1193607207;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 19:
				{
					if (!producerFields.Contains(global::AllFeatures.CodeplugGuid.b("諈ꗊ믌諎볐뛒꟔蟖ꯘ듚믜飞蓠跢胤闦裨蟪뿬諮鳰鳲致鋶룸飺觼雾眀戂焄渆昈攊䠌戎琐愒爔爖眘砚搜", a_)))
					{
						goto IL_EBC;
					}
					num = (short)967908075;
					short num3 = num;
					num = (short)642259691;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_144;
					default:
						num = (short)1681784832;
						if (num != 0)
						{
						}
						num = (short)938082340;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 20:
					this.cnvEmerProfGeneralEnable3_A8171 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("諈ꗊ믌諎볐뛒꟔蟖ꯘ듚믜飞蓠跢胤闦裨蟪꣬臮郰釲駴鋶쫸ꓺ볼쟾\u3000㐂㐄", a_), global::CommonResources.AcgResources.ID_TXMULTIPLIERTXMULTIPLIERENABLE);
					this.cnvEmerProfGeneralEnable3_A8171.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.cnvEmerProfGeneralEnable3_A8171.DataTransferOrder = 8;
					num = (short)1507459102;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 21:
					goto IL_173;
				case 22:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("諈ꗊ믌諎볐뛒꟔蟖ꯘ듚믜飞蓠跢胤闦裨蟪꯬軮鋰蟲髴藶꛸뫺쓼쫾㔀㬂", a_)))
					{
						num = (short)1526661154;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_682;
				case 23:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("諈꓊ꏌ諎볐뛒꟔蟖ꯘ듚飜닞蓠釢苤苦蟨裪铬껮蓰蟲髴ꏶ诸髺鏼賾氀樂焄䨆昈漊栌倎倐ℒ✔∖⨘⤚", a_)))
					{
						num = (short)548274189;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_53D;
				case 24:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("賈ꛊ꣌뷎뛐뛒믔듖ꃘ黚ꗜ뛞闠곢诤ꓦ臨諪菬臮铰鿲뛴鿶飸闺髼髾帀㜂㘄㈆〈㬊", a_)))
					{
						num = (short)413401142;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_39D;
				case 25:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("諈ꗊ믌諎볐뛒꟔蟖ꯘ듚믜飞蓠跢胤闦裨蟪맬韮ꇰ雲蟴黶雸鿺軼髾戀㄂娄䘆〈㨊㸌㸎", a_)))
					{
						num = (short)2132541456;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1C1;
				case 26:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("諈ꗊ믌鿎듐ꇒ飔뛖럘鿚닜꣞迠ꛢ诤蛦诨蟪裬냮연쇲열쓶쇸", a_)))
					{
						num = (short)2040660028;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_E1A;
				case 27:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("諈ꗊ믌諎볐뛒꟔蟖ꯘ듚믜雞賠鏢蓤蓦鷨꿪裬鯮铰郲致黶雸闺룼釾帀䈂㄄㐆㨈㈊㰌", a_)))
					{
						num = (short)373096466;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_6CE;
				case 28:
					goto IL_43F;
				case 29:
					this.cnvPerEMGFindMeRxEnable_42922 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("諈ꗊ믌鿎듐ꇒ郔髖默鷚드뇞藠껢胤뗦釨껪菬軮鏰鿲郴ꣶ췸짺쓼췾㌀", a_), global::CommonResources.AcgResources.ID_EMERGENCYFINDMERECEIVEENABLE);
					this.cnvPerEMGFindMeRxEnable_42922.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.cnvPerEMGFindMeRxEnable_42922.DataTransferOrder = 26;
					num = (short)1136328757;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 30:
					goto IL_20E;
				case 31:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("諈ꗊ믌諎볐뛒꟔蟖ꯘ듚믜飞蓠跢胤闦裨蟪꣬臮郰釲駴鋶쫸ꓺ볼쟾\u3000㐂㐄", a_)))
					{
						num = (short)1188429844;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_20E;
				case 32:
					goto IL_144;
				case 33:
					goto IL_C31;
				case 34:
					this.cnvEmerProfGeneralFactor_A9548 = new global::AcpBusinessLayer.AcpListField(1, this, global::AllFeatures.CodeplugGuid.b("諈ꗊ믌諎볐뛒꟔蟖ꯘ듚믜飞蓠跢胤闦裨蟪꯬軮鋰蟲髴藶꛸뫺쓼쫾㔀㬂", a_), global::CommonResources.AcgResources.ID_TXMULTIPLIERFACTOR, global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.LOVs.CnvEmerProfGeneralFactor_A9548LovStrs);
					this.cnvEmerProfGeneralFactor_A9548.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.cnvEmerProfGeneralFactor_A9548.DataTransferOrder = 15;
					num = (short)1849556996;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 35:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("諈ꗊ믌諎볐뛒꟔蟖ꯘ듚믜飞蓠跢胤闦裨蟪ꓬ苮臰鳲駴黶跸黺꿼髾甀焂氄戆稈吊䰌㜎⌐✒✔", a_)))
					{
						num = (short)1126825984;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_C31;
				case 36:
					this.cnvEmerProfGeneralRemoteActivationEmergency = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("諈ꗊ믌諎볐뛒꟔蟖ꯘ듚믜飞蓠跢胤闦裨蟪뿬諮鳰鳲致鋶룸飺觼雾眀戂焄渆昈攊䠌戎琐愒爔爖眘砚搜", a_), global::CommonResources.AcgResources.ID_REMOTEEMERGENCYACTIVATION, global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.LOVs.CnvEmerProfGeneralRemoteActivationEmergencyLovStrs);
					this.cnvEmerProfGeneralRemoteActivationEmergency.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvEmerProfGeneralRemoteActivationEmergency.DataTransferOrder = 31;
					num = (short)1335951412;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 37:
					this.cnvEmerProfGeneralTxPeriodsec1_A8212 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("諈ꗊ믌諎볐뛒꟔蟖ꯘ듚믜飞蓠跢胤闦裨蟪맬韮ꇰ雲蟴黶雸鿺軼髾戀㈂娄䘆ㄈ㤊㰌㴎", a_), global::CommonResources.AcgResources.ID_AUTOTRANSMITHOTMICTXPERIODSECOLDFIELD, null, null, 0, 10);
					this.cnvEmerProfGeneralTxPeriodsec1_A8212.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvEmerProfGeneralTxPeriodsec1_A8212.DataTransferOrder = 9;
					this.cnvEmerProfGeneralTxPeriodsec1_A8212.ShowHexValue = false;
					num = (short)1175191567;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 38:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("諈ꗊ믌鿎듐ꇒ郔髖默鷚드뇞藠껢胤뗦釨껪菬軮鏰鿲郴ꣶ췸짺쓼췾㌀", a_)))
					{
						num = (short)737607709;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_934;
				case 39:
					goto IL_6CE;
				case 40:
					num = (short)1850933299;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 41:
					this.cnvEmerProfGeneralAcknowledgeAlertTone_A7394 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("諈ꗊ믌諎볐뛒꟔蟖ꯘ듚믜飞蓠跢胤闦裨蟪곬賮髰鷲髴胶闸黺駼飾搀䈂椄戆笈缊夌怎缐瘒䨔嘖⸘⠚␜⬞", a_), global::CommonResources.AcgResources.ID_ACKNOWLEDGEALERTTONE);
					this.cnvEmerProfGeneralAcknowledgeAlertTone_A7394.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvEmerProfGeneralAcknowledgeAlertTone_A7394.DataTransferOrder = 5;
					num = (short)91291659;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 42:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("諈ꗊ믌諎볐뛒꟔蟖ꯘ듚믜飞蓠跢胤闦裨蟪껬胮鿰胲髴鯶鳸뫺黼链匀昂琄爆怈礊栌欎丐划℔✖⠘ⴚ⨜", a_)))
					{
						num = (short)1594949682;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A78;
				case 43:
					switch (0)
					{
					case 0:
						goto IL_122;
					}
					continue;
				case 44:
					goto IL_8E5;
				case 45:
					goto IL_983;
				case 46:
					goto IL_53D;
				case 47:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("諈ꗊ믌鿎듐ꇒ郔髖默鷚드뇞藠껢胤돦釨껪菬軮鏰鿲郴ꣶ췸짺쓼췾㄀", a_)))
					{
						num = (short)1144389681;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_71B;
				case 48:
					goto IL_C7E;
				case 49:
					this.cnvPerEMGFindMeTxEnable_42920 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("諈ꗊ믌鿎듐ꇒ郔髖默鷚드뇞藠껢胤돦釨껪菬軮鏰鿲郴ꣶ췸짺쓼췾㄀", a_), global::CommonResources.AcgResources.ID_EMERGENCYFINDMETRANSMITENABLE);
					this.cnvPerEMGFindMeTxEnable_42920.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.cnvPerEMGFindMeTxEnable_42920.DataTransferOrder = 25;
					num = (short)855638025;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 50:
					this.cnvEmerProfGeneralConsoleAckRequired_A40167 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("諈ꗊ믌諎볐뛒꟔蟖ꯘ듚믜飞蓠跢胤闦裨蟪껬胮鿰胲髴鯶鳸뫺黼链匀昂琄爆怈礊栌欎丐划℔✖⠘ⴚ⨜", a_), global::CommonResources.AcgResources.ID_CONSOLEACKREQUIREDDVRS);
					this.cnvEmerProfGeneralConsoleAckRequired_A40167.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvEmerProfGeneralConsoleAckRequired_A40167.DataTransferOrder = 3;
					num = (short)1946025985;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 51:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("諈ꗊ믌諎볐뛒꟔蟖ꯘ듚믜飞蓠跢胤闦裨蟪곬賮髰鷲髴胶闸黺駼飾搀䈂椄戆笈缊夌怎缐瘒䨔嘖⸘⠚␜⬞", a_)))
					{
						num = (short)69992489;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_D67;
				case 52:
					goto IL_538;
				case 53:
					goto IL_934;
				case 54:
					this.emergencyExitOnChannelChange_43590 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("賈ꛊ꣌뷎뛐뛒믔듖ꃘ黚ꗜ뛞闠곢诤ꓦ臨諪菬臮铰鿲뛴鿶飸闺髼髾帀㜂㘄㈆〈㬊", a_), global::CommonResources.AcgResources.ID_EMERGENCYEXITONCHANNELCHANGE);
					this.emergencyExitOnChannelChange_43590.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.emergencyExitOnChannelChange_43590.DataTransferOrder = 6;
					num = (short)622067771;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 55:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("諈ꗊ믌諎볐뛒꟔蟖ꯘ듚믜飞蓠跢胤闦裨蟪蛬諮裰鳲鏴듶雸闺诼髾漀眂氄栆月樊愌䨎簐瘒朔瀖簘甚縜昞焠儢䨤䄦䀨䜪䠬尮渰爲дึസ਺Լ", a_)))
					{
						num = (short)559415354;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_983;
				case 56:
					goto IL_E1A;
				case 57:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("諈ꗊ믌諎볐뛒꟔蟖ꯘ듚믜飞蓠跢胤闦裨蟪맬韮ꇰ雲蟴黶雸鿺軼髾戀㈂娄䘆ㄈ㤊㰌㴎", a_)))
					{
						num = (short)617545765;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A2B;
				case 58:
					this.cnvEmerProfGeneralkeyofConventionalEmergencyProfiles_A19418 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("諈ꗊ믌諎볐뛒꟔蟖ꯘ듚믜飞蓠跢胤闦裨蟪蛬諮裰鳲鏴듶雸闺诼髾漀眂氄栆月樊愌䨎簐瘒朔瀖簘甚縜昞焠儢䨤䄦䀨䜪䠬尮渰爲дึസ਺Լ", a_), global::CommonResources.AcgResources.ID_EMERGENCYPROFILENAME, 14);
					this.cnvEmerProfGeneralkeyofConventionalEmergencyProfiles_A19418.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.cnvEmerProfGeneralkeyofConventionalEmergencyProfiles_A19418.DataTransferOrder = 16;
					num = (short)304218157;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 59:
					goto IL_39D;
				case 60:
					this.cnvPerManDownEnable_42038 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("諈ꗊ믌鿎듐ꇒ飔뛖럘鿚닜꣞迠ꛢ诤蛦诨蟪裬냮연쇲열쓶쇸", a_), global::CommonResources.AcgResources.ID_MANDOWNENABLE);
					this.cnvPerManDownEnable_42038.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.cnvPerManDownEnable_42038.DataTransferOrder = 18;
					num = (short)968163384;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_122:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)279511072;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_144:
				num = (short)1232404480;
				short num4 = num;
				num = (short)700776460;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_173:
				num = (short)1876230191;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1C1:
				num = (short)960299050;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_20E:
				num = (short)1806041102;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_39D:
				num = (short)1696530449;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_43F:
				num = (short)758775830;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_53D:
				num = (short)1739522105;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_682:
				num = (short)1492254775;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_6CE:
				num = (short)1842806808;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_71B:
				num = (short)72351782;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_8E5:
				num = (short)94896159;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_934:
				num = (short)327221275;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_983:
				num = (short)126877719;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_A2B:
				num = (short)1918697507;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_A78:
				num = (short)641990682;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_C31:
				num = (short)492961817;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_C7E:
				num = (short)2051473427;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_D67:
				num = (short)1059454978;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_E1A:
				num = (short)1001324551;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_538:
			IL_EBC:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("軈껊ꏌ꫎ꏐ닒맔", a_);
			base.Id = 10184;
			base.UIName = global::CommonResources.AcgResources.ID_GENERAL;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06009B96 RID: 39830 RVA: 0x0091C0F4 File Offset: 0x0091A2F4
		public override void PopulateReferences()
		{
			short num = (short)1290731520;
			short num2 = num;
			num = (short)1605311530;
			short num3 = num;
			num = (short)2035293226;
			switch (num3 == num)
			{
			}
			num = (short)1109196801;
			if (num != 0)
			{
			}
			num = (short)697827328;
			if (num != 0)
			{
			}
		}

		// Token: 0x06009B97 RID: 39831 RVA: 0x0091C19C File Offset: 0x0091A39C
		public override void DropReferences()
		{
			short num = (short)1521156096;
			short num2 = num;
			num = (short)1757380968;
			short num3 = num;
			num = (short)1824424296;
			switch (num3 == num)
			{
			}
			num = (short)1398996992;
			if (num != 0)
			{
			}
			num = (short)697499649;
			if (num != 0)
			{
			}
		}

		// Token: 0x06009B98 RID: 39832 RVA: 0x0091C248 File Offset: 0x0091A448
		public override void SetConstraints()
		{
			short num = (short)886833152;
			short num2 = num;
			num = (short)72866125;
			short num3 = num;
			num = (short)1217845581;
			switch (num3 == num)
			{
			}
			num = (short)2146828288;
			if (num != 0)
			{
			}
			num = (short)436994049;
			if (num != 0)
			{
			}
			this.conEmerProEmergencyAutoTransmitMode_A22532.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.ConventionalEmergencyProfilesConstraints.conEmerTypeIsAlarmAndCallValidity);
			this.cnvEmerProfGeneralTxPeriodsec1_A8212.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.ConventionalEmergencyProfilesConstraints.conEmerTypeIsAlarmAndCallAndAutoModeIsHotMic);
			this.cnvEmerProfGeneralTxPeriodsec2_A9131.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.ConventionalEmergencyProfilesConstraints.conEmerTypeIsAlarmAndCallAndAutoModeIsSilentAudio);
			this.cnvPerManDownEnable_42038.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.ConventionalEmergencyProfilesConstraints.ConPerEmerProfIsSelected);
			this.cnvEmerProfEmergencyHotAuxMic_A42296.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.ConventionalEmergencyProfilesConstraints.conAutoModeIsHotMicEmergencyForCVN);
			this.cnvEmerProfImpactDetectionEn_A43391.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.ConventionalEmergencyProfilesConstraints.conImpDetectApplicable);
			this.cnvEmerProfGeneralTxPeriodsec2_A43600.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.ConventionalEmergencyProfilesConstraints.conEmerTypeIsAlarmAndCallAndAutoModeIsHotMic);
			this.cnvEmerProfGeneralTxPeriodsec2_A43600.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.ConventionalEmergencyProfilesConstraints.conSetValueCnvHotMicTxPeriod);
		}

		// Token: 0x06009B99 RID: 39833 RVA: 0x0091C3A8 File Offset: 0x0091A5A8
		public override void SetupDependencies()
		{
			short num = (short)1889009664;
			short num2 = num;
			num = (short)1847590913;
			if (num != 0)
			{
			}
			num = (short)1496104734;
			short num3 = num;
			num = (short)882491166;
			switch (num3 == num)
			{
			}
			num = (short)105709568;
			if (num != 0)
			{
			}
			this.cnvEmerProfGeneralEmergencyType_A7960.AddDependentObject(this.conEmerProEmergencyAutoTransmitMode_A22532);
			this.cnvEmerProfGeneralEmergencyType_A7960.AddDependentObject(this.cnvEmerProfGeneralTxPeriodsec1_A8212);
			this.conEmerProEmergencyAutoTransmitMode_A22532.AddDependentObject(this.cnvEmerProfGeneralTxPeriodsec1_A8212);
			this.cnvEmerProfGeneralEmergencyType_A7960.AddDependentObject(this.cnvEmerProfGeneralTxPeriodsec2_A9131);
			this.conEmerProEmergencyAutoTransmitMode_A22532.AddDependentObject(this.cnvEmerProfGeneralTxPeriodsec2_A9131);
			this.RefEmergencyWide.ManDown.ManDownConfigurabilityGranularityLevel_42057.AddDependentObject(this.cnvPerManDownEnable_42038);
			this.RefEmergencyWide.ManDown.EmerWideManDownTrigger_A40001.AddDependentObject(this.cnvPerManDownEnable_42038);
			this.conEmerProEmergencyAutoTransmitMode_A22532.AddDependentObject(this.cnvEmerProfEmergencyHotAuxMic_A42296);
			this.RefEmergencyWide.EmergencyWideImpactDetection.EmerWideImpactDetectionConfigLevel_A43384.AddDependentObject(this.cnvEmerProfImpactDetectionEn_A43391);
			this.cnvEmerProfGeneralEmergencyType_A7960.AddDependentObject(this.cnvEmerProfGeneralTxPeriodsec2_A43600);
			this.conEmerProEmergencyAutoTransmitMode_A22532.AddDependentObject(this.cnvEmerProfGeneralTxPeriodsec2_A43600);
			this.cnvEmerProfGeneralTxPeriodsec1_A8212.AddDependentObject(this.cnvEmerProfGeneralTxPeriodsec2_A43600);
		}

		// Token: 0x17004E0F RID: 19983
		// (get) Token: 0x06009B9A RID: 39834 RVA: 0x0091C548 File Offset: 0x0091A748
		public bool HasDiffs
		{
			get
			{
				short num = (short)1830944768;
				short num2 = num;
				num = (short)1685904587;
				short num3 = num;
				num = (short)1340857547;
				switch (num3 == num)
				{
				}
				num = (short)419430401;
				if (num != 0)
				{
				}
				num = (short)574488576;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17004E10 RID: 19984
		// (get) Token: 0x06009B9B RID: 39835 RVA: 0x0091C5F8 File Offset: 0x0091A7F8
		// (set) Token: 0x06009B9C RID: 39836 RVA: 0x0091C6AC File Offset: 0x0091A8AC
		public bool CnvEmerProfGeneralAcknowledgeAlertTone_A7394Value
		{
			get
			{
				short num = (short)1326907392;
				short num2 = num;
				num = (short)1368419411;
				short num3 = num;
				num = (short)1769303123;
				switch (num3 == num)
				{
				}
				num = (short)1195507713;
				if (num != 0)
				{
				}
				num = (short)560398336;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralAcknowledgeAlertTone_A7394.Value;
			}
			set
			{
				short num = (short)602669056;
				short num2 = num;
				num = (short)1818740023;
				short num3 = num;
				num = (short)555730231;
				switch (num3 == num)
				{
				}
				num = (short)1817051136;
				if (num != 0)
				{
				}
				num = (short)1714356225;
				if (num != 0)
				{
				}
				this.cnvEmerProfGeneralAcknowledgeAlertTone_A7394.Value = value;
			}
		}

		// Token: 0x17004E11 RID: 19985
		// (get) Token: 0x06009B9D RID: 39837 RVA: 0x0091C760 File Offset: 0x0091A960
		public global::AcpBusinessLayer.AcpField<bool> CnvEmerProfGeneralAcknowledgeAlertTone_A7394
		{
			get
			{
				short num = (short)2043871232;
				short num2 = num;
				num = (short)1525903721;
				short num3 = num;
				num = (short)1838838121;
				switch (num3 == num)
				{
				}
				num = (short)1107230721;
				if (num != 0)
				{
				}
				num = (short)1413283840;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralAcknowledgeAlertTone_A7394;
			}
		}

		// Token: 0x17004E12 RID: 19986
		// (get) Token: 0x06009B9E RID: 39838 RVA: 0x0091C810 File Offset: 0x0091AA10
		// (set) Token: 0x06009B9F RID: 39839 RVA: 0x0091C8C4 File Offset: 0x0091AAC4
		public bool CnvEmerProfGeneralAcknowledgeAlertTone_A7394_UIValue
		{
			get
			{
				short num = (short)351993856;
				short num2 = num;
				num = (short)1937205346;
				short num3 = num;
				num = (short)756377698;
				switch (num3 == num)
				{
				}
				num = (short)1487601665;
				if (num != 0)
				{
				}
				num = (short)532742144;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralAcknowledgeAlertTone_A7394.Value;
			}
			set
			{
				short num = (short)22872064;
				short num2 = num;
				num = (short)905591935;
				short num3 = num;
				num = (short)829504639;
				switch (num3 == num)
				{
				}
				num = (short)797310977;
				if (num != 0)
				{
				}
				num = (short)414580736;
				if (num != 0)
				{
				}
				this.cnvEmerProfGeneralAcknowledgeAlertTone_A7394.Value = value;
			}
		}

		// Token: 0x17004E13 RID: 19987
		// (get) Token: 0x06009BA0 RID: 39840 RVA: 0x0091C978 File Offset: 0x0091AB78
		// (set) Token: 0x06009BA1 RID: 39841 RVA: 0x0091CA2C File Offset: 0x0091AC2C
		public bool CnvEmerProfGeneralAcknowledgeAlertTone_A7394_Applicable
		{
			get
			{
				short num = (short)1092157440;
				short num2 = num;
				num = (short)1576752826;
				short num3 = num;
				num = (short)1678202554;
				switch (num3 == num)
				{
				}
				num = (short)211288065;
				if (num != 0)
				{
				}
				num = (short)546963456;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralAcknowledgeAlertTone_A7394.Applicable;
			}
			set
			{
				short num = (short)1141309440;
				short num2 = num;
				num = (short)1799636589;
				short num3 = num;
				num = (short)40912493;
				switch (num3 == num)
				{
				}
				num = (short)1726545921;
				if (num != 0)
				{
				}
				num = (short)761462784;
				if (num != 0)
				{
				}
				this.cnvEmerProfGeneralAcknowledgeAlertTone_A7394.Applicable = value;
			}
		}

		// Token: 0x17004E14 RID: 19988
		// (get) Token: 0x06009BA2 RID: 39842 RVA: 0x0091CAE0 File Offset: 0x0091ACE0
		// (set) Token: 0x06009BA3 RID: 39843 RVA: 0x0091CB94 File Offset: 0x0091AD94
		public bool CnvEmerProfGeneralAcknowledgeAlertTone_A7394_Valid
		{
			get
			{
				short num = (short)1607335936;
				short num2 = num;
				num = (short)134816137;
				short num3 = num;
				num = (short)1851859337;
				switch (num3 == num)
				{
				}
				num = (short)592314368;
				if (num != 0)
				{
				}
				num = (short)88539137;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralAcknowledgeAlertTone_A7394.Valid;
			}
			set
			{
				short num = (short)1343553536;
				short num2 = num;
				num = (short)778327316;
				short num3 = num;
				num = (short)1970820372;
				switch (num3 == num)
				{
				}
				num = (short)1014038528;
				if (num != 0)
				{
				}
				num = (short)243859457;
				if (num != 0)
				{
				}
				this.cnvEmerProfGeneralAcknowledgeAlertTone_A7394.Valid = value;
			}
		}

		// Token: 0x17004E15 RID: 19989
		// (get) Token: 0x06009BA4 RID: 39844 RVA: 0x0091CC48 File Offset: 0x0091AE48
		// (set) Token: 0x06009BA5 RID: 39845 RVA: 0x0091CCFC File Offset: 0x0091AEFC
		public bool CnvEmerProfGeneralAcknowledgeAlertTone_A7394_Visible
		{
			get
			{
				short num = (short)1864368128;
				short num2 = num;
				num = (short)2073038210;
				short num3 = num;
				num = (short)161942914;
				switch (num3 == num)
				{
				}
				num = (short)4980737;
				if (num != 0)
				{
				}
				num = (short)2028994560;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralAcknowledgeAlertTone_A7394.Visible;
			}
			set
			{
				short num = (short)568262656;
				short num2 = num;
				num = (short)1396138729;
				short num3 = num;
				num = (short)1461281513;
				switch (num3 == num)
				{
				}
				num = (short)1692532736;
				if (num != 0)
				{
				}
				num = (short)124059649;
				if (num != 0)
				{
				}
				this.cnvEmerProfGeneralAcknowledgeAlertTone_A7394.Visible = value;
			}
		}

		// Token: 0x17004E16 RID: 19990
		// (get) Token: 0x06009BA6 RID: 39846 RVA: 0x0091CDB4 File Offset: 0x0091AFB4
		// (set) Token: 0x06009BA7 RID: 39847 RVA: 0x0091CE6C File Offset: 0x0091B06C
		public bool CnvEmerProfGeneralAcknowledgeAlertTone_A7394_Editable
		{
			get
			{
				short num = (short)312016896;
				short num2 = num;
				num = (short)1057578599;
				short num3 = num;
				num = (short)509763175;
				switch (num3 == num)
				{
				}
				num = (short)137035776;
				if (num != 0)
				{
				}
				num = (short)1539244033;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralAcknowledgeAlertTone_A7394.Editable;
			}
			set
			{
				short num = (short)127008768;
				short num2 = num;
				num = (short)1985464600;
				short num3 = num;
				num = (short)1374669080;
				switch (num3 == num)
				{
				}
				num = (short)207290369;
				if (num != 0)
				{
				}
				num = (short)1324875776;
				if (num != 0)
				{
				}
				this.cnvEmerProfGeneralAcknowledgeAlertTone_A7394.Editable = value;
			}
		}

		// Token: 0x17004E17 RID: 19991
		// (get) Token: 0x06009BA8 RID: 39848 RVA: 0x0091CF24 File Offset: 0x0091B124
		internal string CnvEmerProfGeneralAcknowledgeAlertTone_A7394_UILabel
		{
			get
			{
				short num = (short)1962868736;
				short num2 = num;
				num = (short)1786859075;
				short num3 = num;
				num = (short)678776387;
				switch (num3 == num)
				{
				}
				num = (short)1821376513;
				if (num != 0)
				{
				}
				num = (short)1810300928;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralAcknowledgeAlertTone_A7394.UIName;
			}
		}

		// Token: 0x17004E18 RID: 19992
		// (get) Token: 0x06009BA9 RID: 39849 RVA: 0x0091CFD8 File Offset: 0x0091B1D8
		// (set) Token: 0x06009BAA RID: 39850 RVA: 0x0091D090 File Offset: 0x0091B290
		internal bool CnvEmerProfGeneralAcknowledgeAlertTone_A7394_HiddenStatic
		{
			get
			{
				short num = (short)1411776512;
				short num2 = num;
				num = (short)869862633;
				short num3 = num;
				num = (short)1284639977;
				switch (num3 == num)
				{
				}
				num = (short)1697775616;
				if (num != 0)
				{
				}
				num = (short)1461846017;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralAcknowledgeAlertTone_A7394.HiddenStatic;
			}
			set
			{
				short num = (short)1287454720;
				short num2 = num;
				num = (short)2109385211;
				short num3 = num;
				num = (short)197962235;
				switch (num3 == num)
				{
				}
				num = (short)815529984;
				if (num != 0)
				{
				}
				num = (short)728498177;
				if (num != 0)
				{
				}
				this.cnvEmerProfGeneralAcknowledgeAlertTone_A7394.HiddenStatic = value;
			}
		}

		// Token: 0x17004E19 RID: 19993
		// (get) Token: 0x06009BAB RID: 39851 RVA: 0x0091D148 File Offset: 0x0091B348
		// (set) Token: 0x06009BAC RID: 39852 RVA: 0x0091D1FC File Offset: 0x0091B3FC
		internal bool CnvEmerProfGeneralAcknowledgeAlertTone_A7394_HiddenDynamic
		{
			get
			{
				short num = (short)649068544;
				short num2 = num;
				num = (short)1030418991;
				short num3 = num;
				num = (short)1470427695;
				switch (num3 == num)
				{
				}
				num = (short)1438056449;
				if (num != 0)
				{
				}
				num = (short)591396864;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralAcknowledgeAlertTone_A7394.HiddenDynamic;
			}
			set
			{
				short num = (short)185335808;
				short num2 = num;
				num = (short)1140138004;
				short num3 = num;
				num = (short)681386004;
				switch (num3 == num)
				{
				}
				num = (short)264896513;
				if (num != 0)
				{
				}
				num = (short)1417216000;
				if (num != 0)
				{
				}
				this.cnvEmerProfGeneralAcknowledgeAlertTone_A7394.HiddenDynamic = value;
			}
		}

		// Token: 0x17004E1A RID: 19994
		// (get) Token: 0x06009BAD RID: 39853 RVA: 0x0091D2B0 File Offset: 0x0091B4B0
		public bool CnvEmerProfGeneralAcknowledgeAlertTone_A7394_HasDiffs
		{
			get
			{
				short num = (short)2005991424;
				short num2 = num;
				num = (short)344939370;
				short num3 = num;
				num = (short)229923690;
				switch (num3 == num)
				{
				}
				num = (short)1373896705;
				if (num != 0)
				{
				}
				num = (short)309985280;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralAcknowledgeAlertTone_A7394._HasDiffs;
			}
		}

		// Token: 0x17004E1B RID: 19995
		// (get) Token: 0x06009BAE RID: 39854 RVA: 0x0091D364 File Offset: 0x0091B564
		// (set) Token: 0x06009BAF RID: 39855 RVA: 0x0091D418 File Offset: 0x0091B618
		public int CnvEmerProfGeneralEmergencyType_A7960Value
		{
			get
			{
				short num = (short)617236922;
				short num2 = num;
				num = (short)1974618554;
				switch (num2 == num)
				{
				}
				num = (short)1746403328;
				short num3 = num;
				num = (short)92340225;
				if (num != 0)
				{
				}
				num = (short)531759104;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralEmergencyType_A7960.Value;
			}
			set
			{
				short num = (short)609159091;
				short num2 = num;
				num = (short)756025267;
				switch (num2 == num)
				{
				}
				num = (short)1398538240;
				short num3 = num;
				num = (short)1204748288;
				if (num != 0)
				{
				}
				num = (short)1980628993;
				if (num != 0)
				{
				}
				this.cnvEmerProfGeneralEmergencyType_A7960.Value = value;
			}
		}

		// Token: 0x17004E1C RID: 19996
		// (get) Token: 0x06009BB0 RID: 39856 RVA: 0x0091D4CC File Offset: 0x0091B6CC
		// (set) Token: 0x06009BB1 RID: 39857 RVA: 0x0091D580 File Offset: 0x0091B780
		public string CnvEmerProfGeneralEmergencyType_A7960_UIValue
		{
			get
			{
				short num = (short)1610416129;
				if (num != 0)
				{
				}
				num = (short)1983804559;
				short num2 = num;
				num = (short)39875727;
				switch (num2 == num)
				{
				default:
				{
					num = (short)916586496;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)660996096;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralEmergencyType_A7960.UIValue;
			}
			set
			{
				short num = (short)552253007;
				short num2 = num;
				num = (short)1964422735;
				switch (num2 == num)
				{
				}
				num = (short)1241251840;
				short num3 = num;
				num = (short)1252327425;
				if (num != 0)
				{
				}
				num = (short)1963982848;
				if (num != 0)
				{
				}
				this.cnvEmerProfGeneralEmergencyType_A7960.UIValue = value;
			}
		}

		// Token: 0x17004E1D RID: 19997
		// (get) Token: 0x06009BB2 RID: 39858 RVA: 0x0091D638 File Offset: 0x0091B838
		public global::AcpBusinessLayer.AcpListField CnvEmerProfGeneralEmergencyType_A7960
		{
			get
			{
				short num = (short)2021326849;
				if (num != 0)
				{
				}
				num = (short)148095900;
				short num2 = num;
				num = (short)2057749404;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2043150336;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1231814656;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralEmergencyType_A7960;
			}
		}

		// Token: 0x17004E1E RID: 19998
		// (get) Token: 0x06009BB3 RID: 39859 RVA: 0x0091D6E8 File Offset: 0x0091B8E8
		// (set) Token: 0x06009BB4 RID: 39860 RVA: 0x0091D79C File Offset: 0x0091B99C
		public bool CnvEmerProfGeneralEmergencyType_A7960_Applicable
		{
			get
			{
				short num = (short)706479495;
				short num2 = num;
				num = (short)1876100487;
				switch (num2 == num)
				{
				}
				num = (short)1283588096;
				short num3 = num;
				num = (short)1252917249;
				if (num != 0)
				{
				}
				num = (short)1722613760;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralEmergencyType_A7960.Applicable;
			}
			set
			{
				short num = (short)1669071148;
				short num2 = num;
				num = (short)1907949868;
				switch (num2 == num)
				{
				}
				num = (short)834666496;
				short num3 = num;
				num = (short)1851195393;
				if (num != 0)
				{
				}
				num = (short)2037383168;
				if (num != 0)
				{
				}
				this.cnvEmerProfGeneralEmergencyType_A7960.Applicable = value;
			}
		}

		// Token: 0x17004E1F RID: 19999
		// (get) Token: 0x06009BB5 RID: 39861 RVA: 0x0091D850 File Offset: 0x0091BA50
		// (set) Token: 0x06009BB6 RID: 39862 RVA: 0x0091D904 File Offset: 0x0091BB04
		public bool CnvEmerProfGeneralEmergencyType_A7960_Valid
		{
			get
			{
				short num = (short)1200484407;
				short num2 = num;
				num = (short)2020077623;
				switch (num2 == num)
				{
				}
				num = (short)442040320;
				short num3 = num;
				num = (short)261685249;
				if (num != 0)
				{
				}
				num = (short)1542848512;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralEmergencyType_A7960.Valid;
			}
			set
			{
				short num = (short)2085512953;
				short num2 = num;
				num = (short)427517689;
				switch (num2 == num)
				{
				}
				num = (short)193724416;
				short num3 = num;
				num = (short)2053505025;
				if (num != 0)
				{
				}
				num = (short)2139095040;
				if (num != 0)
				{
				}
				this.cnvEmerProfGeneralEmergencyType_A7960.Valid = value;
			}
		}

		// Token: 0x17004E20 RID: 20000
		// (get) Token: 0x06009BB7 RID: 39863 RVA: 0x0091D9B8 File Offset: 0x0091BBB8
		// (set) Token: 0x06009BB8 RID: 39864 RVA: 0x0091DA70 File Offset: 0x0091BC70
		public bool CnvEmerProfGeneralEmergencyType_A7960_Visible
		{
			get
			{
				short num = (short)461221457;
				short num2 = num;
				num = (short)342928977;
				switch (num2 == num)
				{
				}
				num = (short)514523136;
				short num3 = num;
				num = (short)1074331649;
				if (num != 0)
				{
				}
				num = (short)1986985984;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralEmergencyType_A7960.Visible;
			}
			set
			{
				short num = (short)448993189;
				short num2 = num;
				num = (short)453842853;
				switch (num2 == num)
				{
				}
				num = (short)1294401536;
				short num3 = num;
				num = (short)100597761;
				if (num != 0)
				{
				}
				num = (short)179240960;
				if (num != 0)
				{
				}
				this.cnvEmerProfGeneralEmergencyType_A7960.Visible = value;
			}
		}

		// Token: 0x17004E21 RID: 20001
		// (get) Token: 0x06009BB9 RID: 39865 RVA: 0x0091DB24 File Offset: 0x0091BD24
		// (set) Token: 0x06009BBA RID: 39866 RVA: 0x0091DBD8 File Offset: 0x0091BDD8
		public bool CnvEmerProfGeneralEmergencyType_A7960_Editable
		{
			get
			{
				short num = (short)1089413041;
				short num2 = num;
				num = (short)1851137969;
				switch (num2 == num)
				{
				}
				num = (short)1318453248;
				short num3 = num;
				num = (short)746389504;
				if (num != 0)
				{
				}
				num = (short)215613441;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralEmergencyType_A7960.Editable;
			}
			set
			{
				short num = (short)1389363201;
				if (num != 0)
				{
				}
				num = (short)560782969;
				short num2 = num;
				num = (short)1267326585;
				switch (num2 == num)
				{
				default:
				{
					num = (short)876085248;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1150550016;
				if (num != 0)
				{
				}
				this.cnvEmerProfGeneralEmergencyType_A7960.Editable = value;
			}
		}

		// Token: 0x17004E22 RID: 20002
		// (get) Token: 0x06009BBB RID: 39867 RVA: 0x0091DC8C File Offset: 0x0091BE8C
		internal string CnvEmerProfGeneralEmergencyType_A7960_UILabel
		{
			get
			{
				short num = (short)173076016;
				short num2 = num;
				num = (short)1865477680;
				switch (num2 == num)
				{
				}
				num = (short)1616248832;
				short num3 = num;
				num = (short)78249984;
				if (num != 0)
				{
				}
				num = (short)925433857;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralEmergencyType_A7960.UIName;
			}
		}

		// Token: 0x17004E23 RID: 20003
		// (get) Token: 0x06009BBC RID: 39868 RVA: 0x0091DD40 File Offset: 0x0091BF40
		// (set) Token: 0x06009BBD RID: 39869 RVA: 0x0091DDF4 File Offset: 0x0091BFF4
		internal bool CnvEmerProfGeneralEmergencyType_A7960_HiddenStatic
		{
			get
			{
				short num = (short)1258846641;
				short num2 = num;
				num = (short)1528265137;
				switch (num2 == num)
				{
				}
				num = (short)1506344960;
				short num3 = num;
				num = (short)1048903681;
				if (num != 0)
				{
				}
				num = (short)2042036224;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralEmergencyType_A7960.HiddenStatic;
			}
			set
			{
				short num = (short)899946488;
				short num2 = num;
				num = (short)308549624;
				switch (num2 == num)
				{
				}
				num = (short)925368320;
				short num3 = num;
				num = (short)97714176;
				if (num != 0)
				{
				}
				num = (short)1390608385;
				if (num != 0)
				{
				}
				this.cnvEmerProfGeneralEmergencyType_A7960.HiddenStatic = value;
			}
		}

		// Token: 0x17004E24 RID: 20004
		// (get) Token: 0x06009BBE RID: 39870 RVA: 0x0091DEA8 File Offset: 0x0091C0A8
		// (set) Token: 0x06009BBF RID: 39871 RVA: 0x0091DF5C File Offset: 0x0091C15C
		internal bool CnvEmerProfGeneralEmergencyType_A7960_HiddenDynamic
		{
			get
			{
				short num = (short)1316784856;
				short num2 = num;
				num = (short)1151503064;
				switch (num2 == num)
				{
				}
				num = (short)1794899968;
				short num3 = num;
				num = (short)1307705345;
				if (num != 0)
				{
				}
				num = (short)1960640512;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralEmergencyType_A7960.HiddenDynamic;
			}
			set
			{
				short num = (short)2037827230;
				short num2 = num;
				num = (short)1273022110;
				switch (num2 == num)
				{
				}
				num = (short)1575026688;
				short num3 = num;
				num = (short)579731457;
				if (num != 0)
				{
				}
				num = (short)1922957312;
				if (num != 0)
				{
				}
				this.cnvEmerProfGeneralEmergencyType_A7960.HiddenDynamic = value;
			}
		}

		// Token: 0x17004E25 RID: 20005
		// (get) Token: 0x06009BC0 RID: 39872 RVA: 0x0091E010 File Offset: 0x0091C210
		public bool CnvEmerProfGeneralEmergencyType_A7960_HasDiffs
		{
			get
			{
				short num = (short)1900407948;
				short num2 = num;
				num = (short)340651148;
				switch (num2 == num)
				{
				}
				num = (short)654901248;
				short num3 = num;
				num = (short)6094848;
				if (num != 0)
				{
				}
				num = (short)1828847617;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralEmergencyType_A7960._HasDiffs;
			}
		}

		// Token: 0x17004E26 RID: 20006
		// (get) Token: 0x06009BC1 RID: 39873 RVA: 0x0091E0C4 File Offset: 0x0091C2C4
		// (set) Token: 0x06009BC2 RID: 39874 RVA: 0x0091E178 File Offset: 0x0091C378
		public bool CnvEmerProfGeneralEnable3_A8171Value
		{
			get
			{
				short num = (short)1376679470;
				short num2 = num;
				num = (short)2007529006;
				switch (num2 == num)
				{
				}
				num = (short)1902903296;
				short num3 = num;
				num = (short)613285889;
				if (num != 0)
				{
				}
				num = (short)938409984;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralEnable3_A8171.Value;
			}
			set
			{
				short num = (short)1428681791;
				short num2 = num;
				num = (short)142341183;
				switch (num2 == num)
				{
				}
				num = (short)649461760;
				short num3 = num;
				num = (short)697565185;
				if (num != 0)
				{
				}
				num = (short)1914503168;
				if (num != 0)
				{
				}
				this.cnvEmerProfGeneralEnable3_A8171.Value = value;
			}
		}

		// Token: 0x17004E27 RID: 20007
		// (get) Token: 0x06009BC3 RID: 39875 RVA: 0x0091E22C File Offset: 0x0091C42C
		public global::AcpBusinessLayer.AcpField<bool> CnvEmerProfGeneralEnable3_A8171
		{
			get
			{
				short num = (short)722709825;
				short num2 = num;
				num = (short)586788161;
				switch (num2 == num)
				{
				}
				num = (short)949944320;
				short num3 = num;
				num = (short)616038400;
				if (num != 0)
				{
				}
				num = (short)478937089;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralEnable3_A8171;
			}
		}

		// Token: 0x17004E28 RID: 20008
		// (get) Token: 0x06009BC4 RID: 39876 RVA: 0x0091E2DC File Offset: 0x0091C4DC
		// (set) Token: 0x06009BC5 RID: 39877 RVA: 0x0091E394 File Offset: 0x0091C594
		public bool CnvEmerProfGeneralEnable3_A8171_UIValue
		{
			get
			{
				short num = (short)1156067637;
				short num2 = num;
				num = (short)696987957;
				switch (num2 == num)
				{
				}
				num = (short)1458372608;
				short num3 = num;
				num = (short)1330184192;
				if (num != 0)
				{
				}
				num = (short)330891265;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralEnable3_A8171.Value;
			}
			set
			{
				short num = (short)893096488;
				short num2 = num;
				num = (short)1655280168;
				switch (num2 == num)
				{
				}
				num = (short)456851456;
				short num3 = num;
				num = (short)1900544001;
				if (num != 0)
				{
				}
				num = (short)1645346816;
				if (num != 0)
				{
				}
				this.cnvEmerProfGeneralEnable3_A8171.Value = value;
			}
		}

		// Token: 0x17004E29 RID: 20009
		// (get) Token: 0x06009BC6 RID: 39878 RVA: 0x0091E44C File Offset: 0x0091C64C
		// (set) Token: 0x06009BC7 RID: 39879 RVA: 0x0091E500 File Offset: 0x0091C700
		public bool CnvEmerProfGeneralEnable3_A8171_Applicable
		{
			get
			{
				short num = (short)424935425;
				if (num != 0)
				{
				}
				num = (short)607824034;
				short num2 = num;
				num = (short)1047701666;
				switch (num2 == num)
				{
				default:
				{
					num = (short)991428608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1006305280;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralEnable3_A8171.Applicable;
			}
			set
			{
				short num = (short)178089403;
				short num2 = num;
				num = (short)1601203643;
				switch (num2 == num)
				{
				}
				num = (short)1679884288;
				short num3 = num;
				num = (short)205389825;
				if (num != 0)
				{
				}
				num = (short)82051072;
				if (num != 0)
				{
				}
				this.cnvEmerProfGeneralEnable3_A8171.Applicable = value;
			}
		}

		// Token: 0x17004E2A RID: 20010
		// (get) Token: 0x06009BC8 RID: 39880 RVA: 0x0091E5B8 File Offset: 0x0091C7B8
		// (set) Token: 0x06009BC9 RID: 39881 RVA: 0x0091E66C File Offset: 0x0091C86C
		public bool CnvEmerProfGeneralEnable3_A8171_Valid
		{
			get
			{
				short num = (short)1689657502;
				short num2 = num;
				num = (short)1842094238;
				switch (num2 == num)
				{
				}
				num = (short)743374848;
				short num3 = num;
				num = (short)1785921537;
				if (num != 0)
				{
				}
				num = (short)2063663104;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralEnable3_A8171.Valid;
			}
			set
			{
				short num = (short)40828929;
				if (num != 0)
				{
				}
				num = (short)1443480659;
				short num2 = num;
				num = (short)2125055059;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1362690048;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1624637440;
				if (num != 0)
				{
				}
				this.cnvEmerProfGeneralEnable3_A8171.Valid = value;
			}
		}

		// Token: 0x17004E2B RID: 20011
		// (get) Token: 0x06009BCA RID: 39882 RVA: 0x0091E720 File Offset: 0x0091C920
		// (set) Token: 0x06009BCB RID: 39883 RVA: 0x0091E7D4 File Offset: 0x0091C9D4
		public bool CnvEmerProfGeneralEnable3_A8171_Visible
		{
			get
			{
				short num = (short)102583072;
				short num2 = num;
				num = (short)1995787040;
				switch (num2 == num)
				{
				}
				num = (short)1589968896;
				short num3 = num;
				num = (short)291176449;
				if (num != 0)
				{
				}
				num = (short)1977679872;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralEnable3_A8171.Visible;
			}
			set
			{
				short num = (short)10813441;
				if (num != 0)
				{
				}
				num = (short)275061912;
				short num2 = num;
				num = (short)1458052248;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1809252352;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1644691456;
				if (num != 0)
				{
				}
				this.cnvEmerProfGeneralEnable3_A8171.Visible = value;
			}
		}

		// Token: 0x17004E2C RID: 20012
		// (get) Token: 0x06009BCC RID: 39884 RVA: 0x0091E888 File Offset: 0x0091CA88
		// (set) Token: 0x06009BCD RID: 39885 RVA: 0x0091E940 File Offset: 0x0091CB40
		public bool CnvEmerProfGeneralEnable3_A8171_Editable
		{
			get
			{
				short num = (short)309227760;
				short num2 = num;
				num = (short)886075632;
				switch (num2 == num)
				{
				}
				num = (short)2071527424;
				short num3 = num;
				num = (short)1629159425;
				if (num != 0)
				{
				}
				num = (short)740884480;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralEnable3_A8171.Editable;
			}
			set
			{
				short num = (short)1963928059;
				short num2 = num;
				num = (short)507390459;
				switch (num2 == num)
				{
				}
				num = (short)1363279872;
				short num3 = num;
				num = (short)220987392;
				if (num != 0)
				{
				}
				num = (short)1870069761;
				if (num != 0)
				{
				}
				this.cnvEmerProfGeneralEnable3_A8171.Editable = value;
			}
		}

		// Token: 0x17004E2D RID: 20013
		// (get) Token: 0x06009BCE RID: 39886 RVA: 0x0091E9F4 File Offset: 0x0091CBF4
		internal string CnvEmerProfGeneralEnable3_A8171_UILabel
		{
			get
			{
				short num = (short)1587962196;
				short num2 = num;
				num = (short)1471242580;
				switch (num2 == num)
				{
				}
				num = (short)485883904;
				short num3 = num;
				num = (short)1012465665;
				if (num != 0)
				{
				}
				num = (short)1944453120;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralEnable3_A8171.UIName;
			}
		}

		// Token: 0x17004E2E RID: 20014
		// (get) Token: 0x06009BCF RID: 39887 RVA: 0x0091EAA8 File Offset: 0x0091CCA8
		// (set) Token: 0x06009BD0 RID: 39888 RVA: 0x0091EB60 File Offset: 0x0091CD60
		internal bool CnvEmerProfGeneralEnable3_A8171_HiddenStatic
		{
			get
			{
				short num = (short)355302883;
				short num2 = num;
				num = (short)1134656995;
				switch (num2 == num)
				{
				}
				num = (short)522846208;
				short num3 = num;
				num = (short)1748566017;
				if (num != 0)
				{
				}
				num = (short)368836608;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralEnable3_A8171.HiddenStatic;
			}
			set
			{
				short num = (short)1663923555;
				short num2 = num;
				num = (short)1512994147;
				switch (num2 == num)
				{
				}
				num = (short)316407808;
				short num3 = num;
				num = (short)1501691905;
				if (num != 0)
				{
				}
				num = (short)816775168;
				if (num != 0)
				{
				}
				this.cnvEmerProfGeneralEnable3_A8171.HiddenStatic = value;
			}
		}

		// Token: 0x17004E2F RID: 20015
		// (get) Token: 0x06009BD1 RID: 39889 RVA: 0x0091EC18 File Offset: 0x0091CE18
		// (set) Token: 0x06009BD2 RID: 39890 RVA: 0x0091ECD0 File Offset: 0x0091CED0
		internal bool CnvEmerProfGeneralEnable3_A8171_HiddenDynamic
		{
			get
			{
				short num = (short)1862784280;
				short num2 = num;
				num = (short)477746456;
				switch (num2 == num)
				{
				}
				num = (short)1196883968;
				short num3 = num;
				num = (short)457113601;
				if (num != 0)
				{
				}
				num = (short)133890048;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralEnable3_A8171.HiddenDynamic;
			}
			set
			{
				short num = (short)1254094788;
				short num2 = num;
				num = (short)283834308;
				switch (num2 == num)
				{
				}
				num = (short)1596850176;
				short num3 = num;
				num = (short)911540225;
				if (num != 0)
				{
				}
				num = (short)1731919872;
				if (num != 0)
				{
				}
				this.cnvEmerProfGeneralEnable3_A8171.HiddenDynamic = value;
			}
		}

		// Token: 0x17004E30 RID: 20016
		// (get) Token: 0x06009BD3 RID: 39891 RVA: 0x0091ED84 File Offset: 0x0091CF84
		public bool CnvEmerProfGeneralEnable3_A8171_HasDiffs
		{
			get
			{
				short num = (short)1042616040;
				short num2 = num;
				num = (short)60428008;
				switch (num2 == num)
				{
				}
				num = (short)1353711616;
				short num3 = num;
				num = (short)205127681;
				if (num != 0)
				{
				}
				num = (short)188481536;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralEnable3_A8171._HasDiffs;
			}
		}

		// Token: 0x17004E31 RID: 20017
		// (get) Token: 0x06009BD4 RID: 39892 RVA: 0x0091EE3C File Offset: 0x0091D03C
		// (set) Token: 0x06009BD5 RID: 39893 RVA: 0x0091EEF4 File Offset: 0x0091D0F4
		public int CnvEmerProfGeneralPoliteRetries_A8712Value
		{
			get
			{
				short num = (short)1254272460;
				short num2 = num;
				num = (short)2121772492;
				switch (num2 == num)
				{
				}
				num = (short)94175232;
				short num3 = num;
				num = (short)107085825;
				if (num != 0)
				{
				}
				num = (short)2030764032;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralPoliteRetries_A8712.Value;
			}
			set
			{
				short num = (short)2074108634;
				short num2 = num;
				num = (short)267805402;
				switch (num2 == num)
				{
				}
				num = (short)1742929920;
				short num3 = num;
				num = (short)1804992512;
				if (num != 0)
				{
				}
				num = (short)457310209;
				if (num != 0)
				{
				}
				this.cnvEmerProfGeneralPoliteRetries_A8712.Value = value;
			}
		}

		// Token: 0x17004E32 RID: 20018
		// (get) Token: 0x06009BD6 RID: 39894 RVA: 0x0091EFA8 File Offset: 0x0091D1A8
		public global::AcpBusinessLayer.AcpSimpleRangeField CnvEmerProfGeneralPoliteRetries_A8712
		{
			get
			{
				short num = (short)2032533505;
				if (num != 0)
				{
				}
				num = (short)571423571;
				short num2 = num;
				num = (short)456670035;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1563230208;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1351745536;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralPoliteRetries_A8712;
			}
		}

		// Token: 0x17004E33 RID: 20019
		// (get) Token: 0x06009BD7 RID: 39895 RVA: 0x0091F058 File Offset: 0x0091D258
		// (set) Token: 0x06009BD8 RID: 39896 RVA: 0x0091F108 File Offset: 0x0091D308
		public string CnvEmerProfGeneralPoliteRetries_A8712_UIValue
		{
			get
			{
				short num = (short)808124417;
				if (num != 0)
				{
				}
				num = (short)1741645442;
				short num2 = num;
				num = (short)1501587074;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1529151488;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2037186560;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralPoliteRetries_A8712.UIValue;
			}
			set
			{
				short num = (short)249028467;
				short num2 = num;
				num = (short)1185996659;
				switch (num2 == num)
				{
				}
				num = (short)1068236800;
				short num3 = num;
				num = (short)245891072;
				if (num != 0)
				{
				}
				num = (short)196609;
				if (num != 0)
				{
				}
				this.cnvEmerProfGeneralPoliteRetries_A8712.UIValue = value;
			}
		}

		// Token: 0x17004E34 RID: 20020
		// (get) Token: 0x06009BD9 RID: 39897 RVA: 0x0091F1BC File Offset: 0x0091D3BC
		// (set) Token: 0x06009BDA RID: 39898 RVA: 0x0091F270 File Offset: 0x0091D470
		internal int CnvEmerProfGeneralPoliteRetries_A8712Min
		{
			get
			{
				short num = (short)1873507128;
				short num2 = num;
				num = (short)1032745784;
				switch (num2 == num)
				{
				}
				num = (short)65929216;
				short num3 = num;
				num = (short)686227457;
				if (num != 0)
				{
				}
				num = (short)1431437312;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralPoliteRetries_A8712.Min;
			}
			set
			{
				short num = (short)871251311;
				short num2 = num;
				num = (short)1786920303;
				switch (num2 == num)
				{
				}
				num = (short)1752039424;
				short num3 = num;
				num = (short)293994496;
				if (num != 0)
				{
				}
				num = (short)787415041;
				if (num != 0)
				{
				}
				this.cnvEmerProfGeneralPoliteRetries_A8712.Min = value;
			}
		}

		// Token: 0x17004E35 RID: 20021
		// (get) Token: 0x06009BDB RID: 39899 RVA: 0x0091F328 File Offset: 0x0091D528
		// (set) Token: 0x06009BDC RID: 39900 RVA: 0x0091F3DC File Offset: 0x0091D5DC
		internal int CnvEmerProfGeneralPoliteRetries_A8712Max
		{
			get
			{
				short num = (short)2021780945;
				short num2 = num;
				num = (short)803401169;
				switch (num2 == num)
				{
				}
				num = (short)23461888;
				short num3 = num;
				num = (short)737738753;
				if (num != 0)
				{
				}
				num = (short)629669888;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralPoliteRetries_A8712.Max;
			}
			set
			{
				short num = (short)1248429168;
				short num2 = num;
				num = (short)2140963952;
				switch (num2 == num)
				{
				}
				num = (short)266272768;
				short num3 = num;
				num = (short)2014117888;
				if (num != 0)
				{
				}
				num = (short)111869953;
				if (num != 0)
				{
				}
				this.cnvEmerProfGeneralPoliteRetries_A8712.Max = value;
			}
		}

		// Token: 0x17004E36 RID: 20022
		// (get) Token: 0x06009BDD RID: 39901 RVA: 0x0091F490 File Offset: 0x0091D690
		// (set) Token: 0x06009BDE RID: 39902 RVA: 0x0091F548 File Offset: 0x0091D748
		internal int CnvEmerProfGeneralPoliteRetries_A8712Step
		{
			get
			{
				short num = (short)1136422967;
				short num2 = num;
				num = (short)1992257591;
				switch (num2 == num)
				{
				}
				num = (short)258277376;
				short num3 = num;
				num = (short)1364656128;
				if (num != 0)
				{
				}
				num = (short)2030764033;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralPoliteRetries_A8712.StepSize;
			}
			set
			{
				short num = (short)498749287;
				short num2 = num;
				num = (short)656363367;
				switch (num2 == num)
				{
				}
				num = (short)45547520;
				short num3 = num;
				num = (short)1017708545;
				if (num != 0)
				{
				}
				num = (short)1557069824;
				if (num != 0)
				{
				}
				this.cnvEmerProfGeneralPoliteRetries_A8712.StepSize = value;
			}
		}

		// Token: 0x17004E37 RID: 20023
		// (get) Token: 0x06009BDF RID: 39903 RVA: 0x0091F600 File Offset: 0x0091D800
		// (set) Token: 0x06009BE0 RID: 39904 RVA: 0x0091F6B4 File Offset: 0x0091D8B4
		public bool CnvEmerProfGeneralPoliteRetries_A8712_Applicable
		{
			get
			{
				short num = (short)5322314;
				short num2 = num;
				num = (short)226178634;
				switch (num2 == num)
				{
				}
				num = (short)1577517056;
				short num3 = num;
				num = (short)1995112448;
				if (num != 0)
				{
				}
				num = (short)1921908737;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralPoliteRetries_A8712.Applicable;
			}
			set
			{
				short num = (short)1573257217;
				if (num != 0)
				{
				}
				num = (short)1356825104;
				short num2 = num;
				num = (short)786006544;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1232207872;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)860028928;
				if (num != 0)
				{
				}
				this.cnvEmerProfGeneralPoliteRetries_A8712.Applicable = value;
			}
		}

		// Token: 0x17004E38 RID: 20024
		// (get) Token: 0x06009BE1 RID: 39905 RVA: 0x0091F768 File Offset: 0x0091D968
		// (set) Token: 0x06009BE2 RID: 39906 RVA: 0x0091F81C File Offset: 0x0091DA1C
		public bool CnvEmerProfGeneralPoliteRetries_A8712_Valid
		{
			get
			{
				short num = (short)704242524;
				short num2 = num;
				num = (short)1570431836;
				switch (num2 == num)
				{
				}
				num = (short)1789984768;
				short num3 = num;
				num = (short)486080513;
				if (num != 0)
				{
				}
				num = (short)691208192;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralPoliteRetries_A8712.Valid;
			}
			set
			{
				short num = (short)536348067;
				short num2 = num;
				num = (short)1069876643;
				switch (num2 == num)
				{
				}
				num = (short)1187315712;
				short num3 = num;
				num = (short)1644232705;
				if (num != 0)
				{
				}
				num = (short)385089536;
				if (num != 0)
				{
				}
				this.cnvEmerProfGeneralPoliteRetries_A8712.Valid = value;
			}
		}

		// Token: 0x17004E39 RID: 20025
		// (get) Token: 0x06009BE3 RID: 39907 RVA: 0x0091F8D0 File Offset: 0x0091DAD0
		// (set) Token: 0x06009BE4 RID: 39908 RVA: 0x0091F984 File Offset: 0x0091DB84
		public bool CnvEmerProfGeneralPoliteRetries_A8712_Visible
		{
			get
			{
				short num = (short)449292773;
				short num2 = num;
				num = (short)1182968293;
				switch (num2 == num)
				{
				}
				num = (short)805568512;
				short num3 = num;
				num = (short)121831425;
				if (num != 0)
				{
				}
				num = (short)1706557440;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralPoliteRetries_A8712.Visible;
			}
			set
			{
				short num = (short)298215211;
				short num2 = num;
				num = (short)1064724267;
				switch (num2 == num)
				{
				}
				num = (short)432537600;
				short num3 = num;
				num = (short)2129395713;
				if (num != 0)
				{
				}
				num = (short)865206272;
				if (num != 0)
				{
				}
				this.cnvEmerProfGeneralPoliteRetries_A8712.Visible = value;
			}
		}

		// Token: 0x17004E3A RID: 20026
		// (get) Token: 0x06009BE5 RID: 39909 RVA: 0x0091FA3C File Offset: 0x0091DC3C
		// (set) Token: 0x06009BE6 RID: 39910 RVA: 0x0091FAF0 File Offset: 0x0091DCF0
		public bool CnvEmerProfGeneralPoliteRetries_A8712_Editable
		{
			get
			{
				short num = (short)1882496120;
				short num2 = num;
				num = (short)1785240696;
				switch (num2 == num)
				{
				}
				num = (short)417005568;
				short num3 = num;
				num = (short)1835335680;
				if (num != 0)
				{
				}
				num = (short)1855782913;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralPoliteRetries_A8712.Editable;
			}
			set
			{
				short num = (short)1969280637;
				short num2 = num;
				num = (short)1732826749;
				switch (num2 == num)
				{
				}
				num = (short)1593638912;
				short num3 = num;
				num = (short)155648000;
				if (num != 0)
				{
				}
				num = (short)575537153;
				if (num != 0)
				{
				}
				this.cnvEmerProfGeneralPoliteRetries_A8712.Editable = value;
			}
		}

		// Token: 0x17004E3B RID: 20027
		// (get) Token: 0x06009BE7 RID: 39911 RVA: 0x0091FBA4 File Offset: 0x0091DDA4
		internal string CnvEmerProfGeneralPoliteRetries_A8712_UILabel
		{
			get
			{
				short num = (short)1950999143;
				short num2 = num;
				num = (short)1891951207;
				switch (num2 == num)
				{
				}
				num = (short)1939734528;
				short num3 = num;
				num = (short)708378625;
				if (num != 0)
				{
				}
				num = (short)1157890048;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralPoliteRetries_A8712.UIName;
			}
		}

		// Token: 0x17004E3C RID: 20028
		// (get) Token: 0x06009BE8 RID: 39912 RVA: 0x0091FC58 File Offset: 0x0091DE58
		// (set) Token: 0x06009BE9 RID: 39913 RVA: 0x0091FD0C File Offset: 0x0091DF0C
		internal bool CnvEmerProfGeneralPoliteRetries_A8712_HiddenStatic
		{
			get
			{
				short num = (short)740756908;
				short num2 = num;
				num = (short)1187646892;
				switch (num2 == num)
				{
				}
				num = (short)631242752;
				short num3 = num;
				num = (short)1389821953;
				if (num != 0)
				{
				}
				num = (short)1848311808;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralPoliteRetries_A8712.HiddenStatic;
			}
			set
			{
				short num = (short)1585993185;
				short num2 = num;
				num = (short)47142369;
				switch (num2 == num)
				{
				}
				num = (short)1657733120;
				short num3 = num;
				num = (short)1188757505;
				if (num != 0)
				{
				}
				num = (short)1579810816;
				if (num != 0)
				{
				}
				this.cnvEmerProfGeneralPoliteRetries_A8712.HiddenStatic = value;
			}
		}

		// Token: 0x17004E3D RID: 20029
		// (get) Token: 0x06009BEA RID: 39914 RVA: 0x0091FDC4 File Offset: 0x0091DFC4
		// (set) Token: 0x06009BEB RID: 39915 RVA: 0x0091FE78 File Offset: 0x0091E078
		internal bool CnvEmerProfGeneralPoliteRetries_A8712_HiddenDynamic
		{
			get
			{
				short num = (short)109372649;
				short num2 = num;
				num = (short)1258874089;
				switch (num2 == num)
				{
				}
				num = (short)38797312;
				short num3 = num;
				num = (short)58392577;
				if (num != 0)
				{
				}
				num = (short)821690368;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralPoliteRetries_A8712.HiddenDynamic;
			}
			set
			{
				short num = (short)2012363993;
				short num2 = num;
				num = (short)405290201;
				switch (num2 == num)
				{
				}
				num = (short)44105728;
				short num3 = num;
				num = (short)1083047937;
				if (num != 0)
				{
				}
				num = (short)319553536;
				if (num != 0)
				{
				}
				this.cnvEmerProfGeneralPoliteRetries_A8712.HiddenDynamic = value;
			}
		}

		// Token: 0x17004E3E RID: 20030
		// (get) Token: 0x06009BEC RID: 39916 RVA: 0x0091FF2C File Offset: 0x0091E12C
		public bool CnvEmerProfGeneralPoliteRetries_A8712_HasDiffs
		{
			get
			{
				short num = (short)360579073;
				if (num != 0)
				{
				}
				num = (short)1296999702;
				short num2 = num;
				num = (short)231253270;
				switch (num2 == num)
				{
				default:
				{
					num = (short)106627072;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1463287808;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralPoliteRetries_A8712._HasDiffs;
			}
		}

		// Token: 0x17004E3F RID: 20031
		// (get) Token: 0x06009BED RID: 39917 RVA: 0x0091FFE0 File Offset: 0x0091E1E0
		// (set) Token: 0x06009BEE RID: 39918 RVA: 0x00920094 File Offset: 0x0091E294
		public int CnvEmerProfGeneralFactor_A9548Value
		{
			get
			{
				short num = (short)651250273;
				short num2 = num;
				num = (short)1736133217;
				switch (num2 == num)
				{
				}
				num = (short)1970339840;
				short num3 = num;
				num = (short)680984577;
				if (num != 0)
				{
				}
				num = (short)87883776;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralFactor_A9548.Value;
			}
			set
			{
				short num = (short)1309490528;
				short num2 = num;
				num = (short)1238318432;
				switch (num2 == num)
				{
				}
				num = (short)938606592;
				short num3 = num;
				num = (short)618856449;
				if (num != 0)
				{
				}
				num = (short)1433796608;
				if (num != 0)
				{
				}
				this.cnvEmerProfGeneralFactor_A9548.Value = value;
			}
		}

		// Token: 0x17004E40 RID: 20032
		// (get) Token: 0x06009BEF RID: 39919 RVA: 0x00920148 File Offset: 0x0091E348
		// (set) Token: 0x06009BF0 RID: 39920 RVA: 0x009201FC File Offset: 0x0091E3FC
		public string CnvEmerProfGeneralFactor_A9548_UIValue
		{
			get
			{
				short num = (short)590540201;
				short num2 = num;
				num = (short)688057769;
				switch (num2 == num)
				{
				}
				num = (short)1402863616;
				short num3 = num;
				num = (short)755367937;
				if (num != 0)
				{
				}
				num = (short)122552320;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralFactor_A9548.UIValue;
			}
			set
			{
				short num = (short)1113701980;
				short num2 = num;
				num = (short)1028636252;
				switch (num2 == num)
				{
				}
				num = (short)692912128;
				short num3 = num;
				num = (short)1307639809;
				if (num != 0)
				{
				}
				num = (short)478806016;
				if (num != 0)
				{
				}
				this.cnvEmerProfGeneralFactor_A9548.UIValue = value;
			}
		}

		// Token: 0x17004E41 RID: 20033
		// (get) Token: 0x06009BF1 RID: 39921 RVA: 0x009202B0 File Offset: 0x0091E4B0
		public global::AcpBusinessLayer.AcpListField CnvEmerProfGeneralFactor_A9548
		{
			get
			{
				short num = (short)1319526550;
				short num2 = num;
				num = (short)1016815766;
				switch (num2 == num)
				{
				}
				num = (short)1537409024;
				short num3 = num;
				num = (short)577765377;
				if (num != 0)
				{
				}
				num = (short)1780219904;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralFactor_A9548;
			}
		}

		// Token: 0x17004E42 RID: 20034
		// (get) Token: 0x06009BF2 RID: 39922 RVA: 0x00920360 File Offset: 0x0091E560
		// (set) Token: 0x06009BF3 RID: 39923 RVA: 0x00920414 File Offset: 0x0091E614
		public bool CnvEmerProfGeneralFactor_A9548_Applicable
		{
			get
			{
				short num = (short)363100364;
				short num2 = num;
				num = (short)1094678732;
				switch (num2 == num)
				{
				}
				num = (short)1103560704;
				short num3 = num;
				num = (short)170328065;
				if (num != 0)
				{
				}
				num = (short)1680998400;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralFactor_A9548.Applicable;
			}
			set
			{
				short num = (short)331064473;
				short num2 = num;
				num = (short)551593113;
				switch (num2 == num)
				{
				}
				num = (short)422248448;
				short num3 = num;
				num = (short)359137281;
				if (num != 0)
				{
				}
				num = (short)1191575552;
				if (num != 0)
				{
				}
				this.cnvEmerProfGeneralFactor_A9548.Applicable = value;
			}
		}

		// Token: 0x17004E43 RID: 20035
		// (get) Token: 0x06009BF4 RID: 39924 RVA: 0x009204C8 File Offset: 0x0091E6C8
		// (set) Token: 0x06009BF5 RID: 39925 RVA: 0x00920578 File Offset: 0x0091E778
		public bool CnvEmerProfGeneralFactor_A9548_Valid
		{
			get
			{
				short num = (short)1047207988;
				short num2 = num;
				num = (short)1986011188;
				switch (num2 == num)
				{
				}
				num = (short)388497408;
				short num3 = num;
				num = (short)749273089;
				if (num != 0)
				{
				}
				num = (short)2075066368;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralFactor_A9548.Valid;
			}
			set
			{
				short num = (short)1662352368;
				short num2 = num;
				num = (short)1996258288;
				switch (num2 == num)
				{
				}
				num = (short)1932525568;
				short num3 = num;
				num = (short)1983447041;
				if (num != 0)
				{
				}
				num = (short)1760428032;
				if (num != 0)
				{
				}
				this.cnvEmerProfGeneralFactor_A9548.Valid = value;
			}
		}

		// Token: 0x17004E44 RID: 20036
		// (get) Token: 0x06009BF6 RID: 39926 RVA: 0x0092062C File Offset: 0x0091E82C
		// (set) Token: 0x06009BF7 RID: 39927 RVA: 0x009206E0 File Offset: 0x0091E8E0
		public bool CnvEmerProfGeneralFactor_A9548_Visible
		{
			get
			{
				short num = (short)1631394002;
				short num2 = num;
				num = (short)1576802514;
				switch (num2 == num)
				{
				}
				num = (short)5767168;
				short num3 = num;
				num = (short)1773862913;
				if (num != 0)
				{
				}
				num = (short)1113194496;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralFactor_A9548.Visible;
			}
			set
			{
				short num = (short)339904945;
				short num2 = num;
				num = (short)347376049;
				switch (num2 == num)
				{
				}
				num = (short)1802305536;
				short num3 = num;
				num = (short)1278017536;
				if (num != 0)
				{
				}
				num = (short)1466892289;
				if (num != 0)
				{
				}
				this.cnvEmerProfGeneralFactor_A9548.Visible = value;
			}
		}

		// Token: 0x17004E45 RID: 20037
		// (get) Token: 0x06009BF8 RID: 39928 RVA: 0x00920798 File Offset: 0x0091E998
		// (set) Token: 0x06009BF9 RID: 39929 RVA: 0x0092084C File Offset: 0x0091EA4C
		public bool CnvEmerProfGeneralFactor_A9548_Editable
		{
			get
			{
				short num = (short)1337998043;
				short num2 = num;
				num = (short)1313159899;
				switch (num2 == num)
				{
				}
				num = (short)154533888;
				short num3 = num;
				num = (short)2002059265;
				if (num != 0)
				{
				}
				num = (short)459800576;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralFactor_A9548.Editable;
			}
			set
			{
				short num = (short)1224015873;
				if (num != 0)
				{
				}
				num = (short)1596755388;
				short num2 = num;
				num = (short)911576508;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1360199680;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)485687296;
				if (num != 0)
				{
				}
				this.cnvEmerProfGeneralFactor_A9548.Editable = value;
			}
		}

		// Token: 0x17004E46 RID: 20038
		// (get) Token: 0x06009BFA RID: 39930 RVA: 0x00920900 File Offset: 0x0091EB00
		internal string CnvEmerProfGeneralFactor_A9548_UILabel
		{
			get
			{
				short num = (short)290115021;
				short num2 = num;
				num = (short)414174669;
				switch (num2 == num)
				{
				}
				num = (short)297861120;
				short num3 = num;
				num = (short)248840192;
				if (num != 0)
				{
				}
				num = (short)574750721;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralFactor_A9548.UIName;
			}
		}

		// Token: 0x17004E47 RID: 20039
		// (get) Token: 0x06009BFB RID: 39931 RVA: 0x009209B4 File Offset: 0x0091EBB4
		// (set) Token: 0x06009BFC RID: 39932 RVA: 0x00920A6C File Offset: 0x0091EC6C
		internal bool CnvEmerProfGeneralFactor_A9548_HiddenStatic
		{
			get
			{
				short num = (short)823115261;
				short num2 = num;
				num = (short)1146994173;
				switch (num2 == num)
				{
				}
				num = (short)954204160;
				short num3 = num;
				num = (short)851312641;
				if (num != 0)
				{
				}
				num = (short)1176829952;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralFactor_A9548.HiddenStatic;
			}
			set
			{
				short num = (short)954881208;
				short num2 = num;
				num = (short)736449720;
				switch (num2 == num)
				{
				}
				num = (short)72089600;
				short num3 = num;
				num = (short)764411905;
				if (num != 0)
				{
				}
				num = (short)612958208;
				if (num != 0)
				{
				}
				this.cnvEmerProfGeneralFactor_A9548.HiddenStatic = value;
			}
		}

		// Token: 0x17004E48 RID: 20040
		// (get) Token: 0x06009BFD RID: 39933 RVA: 0x00920B24 File Offset: 0x0091ED24
		// (set) Token: 0x06009BFE RID: 39934 RVA: 0x00920BD8 File Offset: 0x0091EDD8
		internal bool CnvEmerProfGeneralFactor_A9548_HiddenDynamic
		{
			get
			{
				short num = (short)1382529745;
				short num2 = num;
				num = (short)797817553;
				switch (num2 == num)
				{
				}
				num = (short)1580335104;
				short num3 = num;
				num = (short)1950220289;
				if (num != 0)
				{
				}
				num = (short)1766785024;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralFactor_A9548.HiddenDynamic;
			}
			set
			{
				short num = (short)2045045066;
				short num2 = num;
				num = (short)1470032202;
				switch (num2 == num)
				{
				}
				num = (short)1127546880;
				short num3 = num;
				num = (short)1350959105;
				if (num != 0)
				{
				}
				num = (short)959250432;
				if (num != 0)
				{
				}
				this.cnvEmerProfGeneralFactor_A9548.HiddenDynamic = value;
			}
		}

		// Token: 0x17004E49 RID: 20041
		// (get) Token: 0x06009BFF RID: 39935 RVA: 0x00920C90 File Offset: 0x0091EE90
		public bool CnvEmerProfGeneralFactor_A9548_HasDiffs
		{
			get
			{
				short num = (short)2103095399;
				short num2 = num;
				num = (short)2085531751;
				switch (num2 == num)
				{
				}
				num = (short)1158807552;
				short num3 = num;
				num = (short)1335623681;
				if (num != 0)
				{
				}
				num = (short)1526923264;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralFactor_A9548._HasDiffs;
			}
		}

		// Token: 0x17004E4A RID: 20042
		// (get) Token: 0x06009C00 RID: 39936 RVA: 0x00920D44 File Offset: 0x0091EF44
		// (set) Token: 0x06009C01 RID: 39937 RVA: 0x00920DF8 File Offset: 0x0091EFF8
		public string CnvEmerProfGeneralkeyofConventionalEmergencyProfiles_A19418Value
		{
			get
			{
				short num = (short)481391852;
				short num2 = num;
				num = (short)297432300;
				switch (num2 == num)
				{
				}
				num = (short)1768947712;
				short num3 = num;
				num = (short)2099249153;
				if (num != 0)
				{
				}
				num = (short)1870659584;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralkeyofConventionalEmergencyProfiles_A19418.Value;
			}
			set
			{
				short num = (short)49741824;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)1913459926;
						short num3 = num;
						num = (short)1728189654;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_E5;
						default:
							num = (short)2005008384;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_7B;
							}
							continue;
						}
						break;
					}
					case 1:
						this.cnvEmerProfGeneralkeyofConventionalEmergencyProfiles_A19418.Value = value;
						num = (short)1916272642;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_E5;
					}
					IL_7B:
					num = (short)1439694849;
					if (num != 0)
					{
					}
					if (string.IsNullOrEmpty(value.Trim()))
					{
						return;
					}
					num = (short)585629697;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_E5:
				num = (short)2045444096;
				short num4 = num;
			}
		}

		// Token: 0x17004E4B RID: 20043
		// (get) Token: 0x06009C02 RID: 39938 RVA: 0x00920F18 File Offset: 0x0091F118
		// (set) Token: 0x06009C03 RID: 39939 RVA: 0x00920FCC File Offset: 0x0091F1CC
		public string CnvEmerProfGeneralkeyofConventionalEmergencyProfiles_A19418_UIValue
		{
			get
			{
				short num = (short)317627015;
				short num2 = num;
				num = (short)1654692487;
				switch (num2 == num)
				{
				}
				num = (short)1452670976;
				short num3 = num;
				num = (short)1592459264;
				if (num != 0)
				{
				}
				num = (short)804388865;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralkeyofConventionalEmergencyProfiles_A19418.Value;
			}
			set
			{
				short num = (short)1857785236;
				short num2 = num;
				num = (short)336825748;
				switch (num2 == num)
				{
				}
				num = (short)408158208;
				short num3 = num;
				num = (short)570818560;
				if (num != 0)
				{
				}
				num = (short)55705601;
				if (num != 0)
				{
				}
				this.cnvEmerProfGeneralkeyofConventionalEmergencyProfiles_A19418.Value = value;
			}
		}

		// Token: 0x17004E4C RID: 20044
		// (get) Token: 0x06009C04 RID: 39940 RVA: 0x00921080 File Offset: 0x0091F280
		public global::AcpBusinessLayer.AcpKeyField CnvEmerProfGeneralkeyofConventionalEmergencyProfiles_A19418
		{
			get
			{
				short num = (short)1978606680;
				short num2 = num;
				num = (short)1942299736;
				switch (num2 == num)
				{
				}
				num = (short)270008320;
				short num3 = num;
				num = (short)1706360833;
				if (num != 0)
				{
				}
				num = (short)1229848576;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralkeyofConventionalEmergencyProfiles_A19418;
			}
		}

		// Token: 0x17004E4D RID: 20045
		// (get) Token: 0x06009C05 RID: 39941 RVA: 0x00921130 File Offset: 0x0091F330
		// (set) Token: 0x06009C06 RID: 39942 RVA: 0x009211E8 File Offset: 0x0091F3E8
		public bool CnvEmerProfGeneralkeyofConventionalEmergencyProfiles_A19418_Applicable
		{
			get
			{
				short num = (short)1681373038;
				short num2 = num;
				num = (short)1409595246;
				switch (num2 == num)
				{
				}
				num = (short)1501233152;
				short num3 = num;
				num = (short)1700397056;
				if (num != 0)
				{
				}
				num = (short)41549825;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralkeyofConventionalEmergencyProfiles_A19418.Applicable;
			}
			set
			{
				short num = (short)531044023;
				short num2 = num;
				num = (short)227219127;
				switch (num2 == num)
				{
				}
				num = (short)752615424;
				short num3 = num;
				num = (short)2120155137;
				if (num != 0)
				{
				}
				num = (short)33423360;
				if (num != 0)
				{
				}
				this.cnvEmerProfGeneralkeyofConventionalEmergencyProfiles_A19418.Applicable = value;
			}
		}

		// Token: 0x17004E4E RID: 20046
		// (get) Token: 0x06009C07 RID: 39943 RVA: 0x0092129C File Offset: 0x0091F49C
		// (set) Token: 0x06009C08 RID: 39944 RVA: 0x00921354 File Offset: 0x0091F554
		public bool CnvEmerProfGeneralkeyofConventionalEmergencyProfiles_A19418_Valid
		{
			get
			{
				short num = (short)1840371947;
				short num2 = num;
				num = (short)1552931051;
				switch (num2 == num)
				{
				}
				num = (short)1510211584;
				short num3 = num;
				num = (short)717684736;
				if (num != 0)
				{
				}
				num = (short)389414913;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralkeyofConventionalEmergencyProfiles_A19418.Valid;
			}
			set
			{
				short num = (short)787283610;
				short num2 = num;
				num = (short)1976041114;
				switch (num2 == num)
				{
				}
				num = (short)1819934720;
				short num3 = num;
				num = (short)1231355905;
				if (num != 0)
				{
				}
				num = (short)1220804608;
				if (num != 0)
				{
				}
				this.cnvEmerProfGeneralkeyofConventionalEmergencyProfiles_A19418.Valid = value;
			}
		}

		// Token: 0x17004E4F RID: 20047
		// (get) Token: 0x06009C09 RID: 39945 RVA: 0x00921408 File Offset: 0x0091F608
		// (set) Token: 0x06009C0A RID: 39946 RVA: 0x009214B8 File Offset: 0x0091F6B8
		public bool CnvEmerProfGeneralkeyofConventionalEmergencyProfiles_A19418_Visible
		{
			get
			{
				short num = (short)2105152861;
				short num2 = num;
				num = (short)1465521501;
				switch (num2 == num)
				{
				}
				num = (short)1235156992;
				short num3 = num;
				num = (short)2059075584;
				if (num != 0)
				{
				}
				num = (short)1949106177;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralkeyofConventionalEmergencyProfiles_A19418.Visible;
			}
			set
			{
				short num = (short)629408059;
				short num2 = num;
				num = (short)503644475;
				switch (num2 == num)
				{
				}
				num = (short)1699479552;
				short num3 = num;
				num = (short)292159488;
				if (num != 0)
				{
				}
				num = (short)1670184961;
				if (num != 0)
				{
				}
				this.cnvEmerProfGeneralkeyofConventionalEmergencyProfiles_A19418.Visible = value;
			}
		}

		// Token: 0x17004E50 RID: 20048
		// (get) Token: 0x06009C0B RID: 39947 RVA: 0x00921570 File Offset: 0x0091F770
		// (set) Token: 0x06009C0C RID: 39948 RVA: 0x00921628 File Offset: 0x0091F828
		public bool CnvEmerProfGeneralkeyofConventionalEmergencyProfiles_A19418_Editable
		{
			get
			{
				short num = (short)2077513706;
				short num2 = num;
				num = (short)1459509226;
				switch (num2 == num)
				{
				}
				num = (short)1858404352;
				short num3 = num;
				num = (short)771424257;
				if (num != 0)
				{
				}
				num = (short)666501120;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralkeyofConventionalEmergencyProfiles_A19418.Editable;
			}
			set
			{
				short num = (short)1278049776;
				short num2 = num;
				num = (short)1881177584;
				switch (num2 == num)
				{
				}
				num = (short)296878080;
				short num3 = num;
				num = (short)1125122049;
				if (num != 0)
				{
				}
				num = (short)1870331904;
				if (num != 0)
				{
				}
				this.cnvEmerProfGeneralkeyofConventionalEmergencyProfiles_A19418.Editable = value;
			}
		}

		// Token: 0x17004E51 RID: 20049
		// (get) Token: 0x06009C0D RID: 39949 RVA: 0x009216E0 File Offset: 0x0091F8E0
		internal string CnvEmerProfGeneralkeyofConventionalEmergencyProfiles_A19418_UILabel
		{
			get
			{
				short num = (short)1473511034;
				short num2 = num;
				num = (short)1161625210;
				switch (num2 == num)
				{
				}
				num = (short)318111744;
				short num3 = num;
				num = (short)747307008;
				if (num != 0)
				{
				}
				num = (short)504758273;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralkeyofConventionalEmergencyProfiles_A19418.UIName;
			}
		}

		// Token: 0x17004E52 RID: 20050
		// (get) Token: 0x06009C0E RID: 39950 RVA: 0x00921794 File Offset: 0x0091F994
		// (set) Token: 0x06009C0F RID: 39951 RVA: 0x00921848 File Offset: 0x0091FA48
		internal bool CnvEmerProfGeneralkeyofConventionalEmergencyProfiles_A19418_HiddenStatic
		{
			get
			{
				short num = (short)788267009;
				if (num != 0)
				{
				}
				num = (short)1945026923;
				short num2 = num;
				num = (short)619954539;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1031667712;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)173211648;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralkeyofConventionalEmergencyProfiles_A19418.HiddenStatic;
			}
			set
			{
				short num = (short)718050578;
				short num2 = num;
				num = (short)1475777810;
				switch (num2 == num)
				{
				}
				num = (short)646250496;
				short num3 = num;
				num = (short)1691090945;
				if (num != 0)
				{
				}
				num = (short)1593245696;
				if (num != 0)
				{
				}
				this.cnvEmerProfGeneralkeyofConventionalEmergencyProfiles_A19418.HiddenStatic = value;
			}
		}

		// Token: 0x17004E53 RID: 20051
		// (get) Token: 0x06009C10 RID: 39952 RVA: 0x00921900 File Offset: 0x0091FB00
		// (set) Token: 0x06009C11 RID: 39953 RVA: 0x009219B8 File Offset: 0x0091FBB8
		internal bool CnvEmerProfGeneralkeyofConventionalEmergencyProfiles_A19418_HiddenDynamic
		{
			get
			{
				short num = (short)1661875671;
				short num2 = num;
				num = (short)1034958295;
				switch (num2 == num)
				{
				}
				num = (short)1745158144;
				short num3 = num;
				num = (short)2126249985;
				if (num != 0)
				{
				}
				num = (short)1700397056;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralkeyofConventionalEmergencyProfiles_A19418.HiddenDynamic;
			}
			set
			{
				short num = (short)1135562693;
				short num2 = num;
				num = (short)1027755973;
				switch (num2 == num)
				{
				}
				num = (short)1844445184;
				short num3 = num;
				num = (short)1115684865;
				if (num != 0)
				{
				}
				num = (short)1804926976;
				if (num != 0)
				{
				}
				this.cnvEmerProfGeneralkeyofConventionalEmergencyProfiles_A19418.HiddenDynamic = value;
			}
		}

		// Token: 0x17004E54 RID: 20052
		// (get) Token: 0x06009C12 RID: 39954 RVA: 0x00921A70 File Offset: 0x0091FC70
		public bool CnvEmerProfGeneralkeyofConventionalEmergencyProfiles_A19418_HasDiffs
		{
			get
			{
				short num = (short)1476722689;
				if (num != 0)
				{
				}
				num = (short)1534799732;
				short num2 = num;
				num = (short)443821940;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1835335680;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2106327040;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralkeyofConventionalEmergencyProfiles_A19418._HasDiffs;
			}
		}

		// Token: 0x17004E55 RID: 20053
		// (get) Token: 0x06009C13 RID: 39955 RVA: 0x00921B24 File Offset: 0x0091FD24
		// (set) Token: 0x06009C14 RID: 39956 RVA: 0x00921BD8 File Offset: 0x0091FDD8
		public int ConEmerProEmergencyAutoTransmitMode_A22532Value
		{
			get
			{
				short num = (short)739976154;
				short num2 = num;
				num = (short)866264026;
				switch (num2 == num)
				{
				}
				num = (short)1626144768;
				short num3 = num;
				num = (short)1243611137;
				if (num != 0)
				{
				}
				num = (short)993525760;
				if (num != 0)
				{
				}
				return this.conEmerProEmergencyAutoTransmitMode_A22532.Value;
			}
			set
			{
				short num = (short)491059051;
				short num2 = num;
				num = (short)100333419;
				switch (num2 == num)
				{
				}
				num = (short)2063335424;
				short num3 = num;
				num = (short)1605894145;
				if (num != 0)
				{
				}
				num = (short)1514471424;
				if (num != 0)
				{
				}
				this.conEmerProEmergencyAutoTransmitMode_A22532.Value = value;
			}
		}

		// Token: 0x17004E56 RID: 20054
		// (get) Token: 0x06009C15 RID: 39957 RVA: 0x00921C8C File Offset: 0x0091FE8C
		// (set) Token: 0x06009C16 RID: 39958 RVA: 0x00921D44 File Offset: 0x0091FF44
		public string ConEmerProEmergencyAutoTransmitMode_A22532_UIValue
		{
			get
			{
				short num = (short)1273211597;
				short num2 = num;
				num = (short)253668045;
				switch (num2 == num)
				{
				}
				num = (short)2021785600;
				short num3 = num;
				num = (short)210894849;
				if (num != 0)
				{
				}
				num = (short)56819712;
				if (num != 0)
				{
				}
				return this.conEmerProEmergencyAutoTransmitMode_A22532.UIValue;
			}
			set
			{
				short num = (short)1973360149;
				short num2 = num;
				num = (short)1117722133;
				switch (num2 == num)
				{
				}
				num = (short)1298268160;
				short num3 = num;
				num = (short)1517289473;
				if (num != 0)
				{
				}
				num = (short)961413120;
				if (num != 0)
				{
				}
				this.conEmerProEmergencyAutoTransmitMode_A22532.UIValue = value;
			}
		}

		// Token: 0x17004E57 RID: 20055
		// (get) Token: 0x06009C17 RID: 39959 RVA: 0x00921DF8 File Offset: 0x0091FFF8
		public global::AcpBusinessLayer.AcpListField ConEmerProEmergencyAutoTransmitMode_A22532
		{
			get
			{
				short num = (short)149423648;
				short num2 = num;
				num = (short)437323296;
				switch (num2 == num)
				{
				}
				num = (short)666959872;
				short num3 = num;
				num = (short)418185216;
				if (num != 0)
				{
				}
				num = (short)1461321729;
				if (num != 0)
				{
				}
				return this.conEmerProEmergencyAutoTransmitMode_A22532;
			}
		}

		// Token: 0x17004E58 RID: 20056
		// (get) Token: 0x06009C18 RID: 39960 RVA: 0x00921EA8 File Offset: 0x009200A8
		// (set) Token: 0x06009C19 RID: 39961 RVA: 0x00921F60 File Offset: 0x00920160
		public bool ConEmerProEmergencyAutoTransmitMode_A22532_Applicable
		{
			get
			{
				short num = (short)1393674889;
				short num2 = num;
				num = (short)617073289;
				switch (num2 == num)
				{
				}
				num = (short)1979842560;
				short num3 = num;
				num = (short)1460928512;
				if (num != 0)
				{
				}
				num = (short)1246494721;
				if (num != 0)
				{
				}
				return this.conEmerProEmergencyAutoTransmitMode_A22532.Applicable;
			}
			set
			{
				short num = (short)2038266865;
				short num2 = num;
				num = (short)940473329;
				switch (num2 == num)
				{
				}
				num = (short)1889402880;
				short num3 = num;
				num = (short)1688928257;
				if (num != 0)
				{
				}
				num = (short)1704787968;
				if (num != 0)
				{
				}
				this.conEmerProEmergencyAutoTransmitMode_A22532.Applicable = value;
			}
		}

		// Token: 0x17004E59 RID: 20057
		// (get) Token: 0x06009C1A RID: 39962 RVA: 0x00922018 File Offset: 0x00920218
		// (set) Token: 0x06009C1B RID: 39963 RVA: 0x009220CC File Offset: 0x009202CC
		public bool ConEmerProEmergencyAutoTransmitMode_A22532_Valid
		{
			get
			{
				short num = (short)142606337;
				if (num != 0)
				{
				}
				num = (short)1550282506;
				short num2 = num;
				num = (short)1352560394;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1961164800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1584922624;
				if (num != 0)
				{
				}
				return this.conEmerProEmergencyAutoTransmitMode_A22532.Valid;
			}
			set
			{
				short num = (short)2076760430;
				short num2 = num;
				num = (short)1722472814;
				switch (num2 == num)
				{
				}
				num = (short)638058496;
				short num3 = num;
				num = (short)1104019457;
				if (num != 0)
				{
				}
				num = (short)1362493440;
				if (num != 0)
				{
				}
				this.conEmerProEmergencyAutoTransmitMode_A22532.Valid = value;
			}
		}

		// Token: 0x17004E5A RID: 20058
		// (get) Token: 0x06009C1C RID: 39964 RVA: 0x00922184 File Offset: 0x00920384
		// (set) Token: 0x06009C1D RID: 39965 RVA: 0x00922238 File Offset: 0x00920438
		public bool ConEmerProEmergencyAutoTransmitMode_A22532_Visible
		{
			get
			{
				short num = (short)452054699;
				short num2 = num;
				num = (short)1521012395;
				switch (num2 == num)
				{
				}
				num = (short)26542080;
				if (num != 0)
				{
				}
				num = (short)942145537;
				if (num != 0)
				{
				}
				num = (short)2109669376;
				short num3 = num;
				return this.conEmerProEmergencyAutoTransmitMode_A22532.Visible;
			}
			set
			{
				short num = (short)585898112;
				short num2 = num;
				num = (short)731519104;
				switch (num2 == num)
				{
				}
				num = (short)418381824;
				if (num != 0)
				{
				}
				num = (short)606404609;
				if (num != 0)
				{
				}
				num = (short)154533888;
				short num3 = num;
				this.conEmerProEmergencyAutoTransmitMode_A22532.Visible = value;
			}
		}

		// Token: 0x17004E5B RID: 20059
		// (get) Token: 0x06009C1E RID: 39966 RVA: 0x009222F0 File Offset: 0x009204F0
		// (set) Token: 0x06009C1F RID: 39967 RVA: 0x009223A4 File Offset: 0x009205A4
		public bool ConEmerProEmergencyAutoTransmitMode_A22532_Editable
		{
			get
			{
				short num = (short)1443138990;
				short num2 = num;
				num = (short)327257518;
				switch (num2 == num)
				{
				}
				num = (short)1637416960;
				if (num != 0)
				{
				}
				num = (short)270073857;
				if (num != 0)
				{
				}
				num = (short)585891840;
				short num3 = num;
				return this.conEmerProEmergencyAutoTransmitMode_A22532.Editable;
			}
			set
			{
				short num = (short)824791771;
				short num2 = num;
				num = (short)1963086555;
				switch (num2 == num)
				{
				}
				num = (short)127795200;
				if (num != 0)
				{
				}
				num = (short)1051394049;
				if (num != 0)
				{
				}
				num = (short)140509184;
				short num3 = num;
				this.conEmerProEmergencyAutoTransmitMode_A22532.Editable = value;
			}
		}

		// Token: 0x17004E5C RID: 20060
		// (get) Token: 0x06009C20 RID: 39968 RVA: 0x0092245C File Offset: 0x0092065C
		internal string ConEmerProEmergencyAutoTransmitMode_A22532_UILabel
		{
			get
			{
				short num = (short)1272512513;
				if (num != 0)
				{
				}
				num = (short)580742294;
				short num2 = num;
				num = (short)759196822;
				switch (num2 == num)
				{
				}
				num = (short)3735552;
				if (num != 0)
				{
				}
				num = (short)858062848;
				short num3 = num;
				return this.conEmerProEmergencyAutoTransmitMode_A22532.UIName;
			}
		}

		// Token: 0x17004E5D RID: 20061
		// (get) Token: 0x06009C21 RID: 39969 RVA: 0x00922510 File Offset: 0x00920710
		// (set) Token: 0x06009C22 RID: 39970 RVA: 0x009225C4 File Offset: 0x009207C4
		internal bool ConEmerProEmergencyAutoTransmitMode_A22532_HiddenStatic
		{
			get
			{
				short num = (short)1768371330;
				short num2 = num;
				num = (short)633484418;
				switch (num2 == num)
				{
				}
				num = (short)129302528;
				if (num != 0)
				{
				}
				num = (short)2033057793;
				if (num != 0)
				{
				}
				num = (short)1584463872;
				short num3 = num;
				return this.conEmerProEmergencyAutoTransmitMode_A22532.HiddenStatic;
			}
			set
			{
				short num = (short)1390004204;
				short num2 = num;
				num = (short)617859052;
				switch (num2 == num)
				{
				}
				num = (short)1185808384;
				if (num != 0)
				{
				}
				num = (short)825753601;
				if (num != 0)
				{
				}
				num = (short)274792448;
				short num3 = num;
				this.conEmerProEmergencyAutoTransmitMode_A22532.HiddenStatic = value;
			}
		}

		// Token: 0x17004E5E RID: 20062
		// (get) Token: 0x06009C23 RID: 39971 RVA: 0x0092267C File Offset: 0x0092087C
		// (set) Token: 0x06009C24 RID: 39972 RVA: 0x00922730 File Offset: 0x00920930
		internal bool ConEmerProEmergencyAutoTransmitMode_A22532_HiddenDynamic
		{
			get
			{
				short num = (short)56135744;
				short num2 = num;
				num = (short)802656320;
				switch (num2 == num)
				{
				}
				num = (short)202702849;
				if (num != 0)
				{
				}
				num = (short)1240727552;
				if (num != 0)
				{
				}
				num = (short)18546688;
				short num3 = num;
				return this.conEmerProEmergencyAutoTransmitMode_A22532.HiddenDynamic;
			}
			set
			{
				short num = (short)2104930265;
				short num2 = num;
				num = (short)280539097;
				switch (num2 == num)
				{
				}
				num = (short)166264833;
				if (num != 0)
				{
				}
				num = (short)1649410048;
				if (num != 0)
				{
				}
				num = (short)213975040;
				short num3 = num;
				this.conEmerProEmergencyAutoTransmitMode_A22532.HiddenDynamic = value;
			}
		}

		// Token: 0x17004E5F RID: 20063
		// (get) Token: 0x06009C25 RID: 39973 RVA: 0x009227E8 File Offset: 0x009209E8
		public bool ConEmerProEmergencyAutoTransmitMode_A22532_HasDiffs
		{
			get
			{
				short num = (short)632991692;
				short num2 = num;
				num = (short)101756876;
				switch (num2 == num)
				{
				}
				num = (short)928448513;
				if (num != 0)
				{
				}
				num = (short)1141637120;
				if (num != 0)
				{
				}
				num = (short)1411317760;
				short num3 = num;
				return this.conEmerProEmergencyAutoTransmitMode_A22532._HasDiffs;
			}
		}

		// Token: 0x17004E60 RID: 20064
		// (get) Token: 0x06009C26 RID: 39974 RVA: 0x0092289C File Offset: 0x00920A9C
		// (set) Token: 0x06009C27 RID: 39975 RVA: 0x00922950 File Offset: 0x00920B50
		public int CnvEmerProfGeneralTxPeriodsec1_A8212Value
		{
			get
			{
				short num = (short)799852881;
				short num2 = num;
				num = (short)1219807569;
				switch (num2 == num)
				{
				}
				num = (short)34996224;
				if (num != 0)
				{
				}
				num = (short)1550385153;
				if (num != 0)
				{
				}
				num = (short)994902016;
				short num3 = num;
				return this.cnvEmerProfGeneralTxPeriodsec1_A8212.Value;
			}
			set
			{
				short num = (short)898500334;
				short num2 = num;
				num = (short)1738540782;
				switch (num2 == num)
				{
				}
				num = (short)515047425;
				if (num != 0)
				{
				}
				num = (short)329252864;
				if (num != 0)
				{
				}
				num = (short)508493824;
				short num3 = num;
				this.cnvEmerProfGeneralTxPeriodsec1_A8212.Value = value;
			}
		}

		// Token: 0x17004E61 RID: 20065
		// (get) Token: 0x06009C28 RID: 39976 RVA: 0x00922A04 File Offset: 0x00920C04
		public global::AcpBusinessLayer.AcpSimpleRangeField CnvEmerProfGeneralTxPeriodsec1_A8212
		{
			get
			{
				short num = (short)447433182;
				short num2 = num;
				num = (short)681789918;
				switch (num2 == num)
				{
				}
				num = (short)1523253249;
				if (num != 0)
				{
				}
				num = (short)681508864;
				if (num != 0)
				{
				}
				num = (short)2077949952;
				short num3 = num;
				return this.cnvEmerProfGeneralTxPeriodsec1_A8212;
			}
		}

		// Token: 0x17004E62 RID: 20066
		// (get) Token: 0x06009C29 RID: 39977 RVA: 0x00922AB4 File Offset: 0x00920CB4
		// (set) Token: 0x06009C2A RID: 39978 RVA: 0x00922B68 File Offset: 0x00920D68
		public string CnvEmerProfGeneralTxPeriodsec1_A8212_UIValue
		{
			get
			{
				short num = (short)1545641952;
				short num2 = num;
				num = (short)866033632;
				switch (num2 == num)
				{
				}
				num = (short)1141178369;
				if (num != 0)
				{
				}
				num = (short)586743808;
				if (num != 0)
				{
				}
				num = (short)105775104;
				short num3 = num;
				return this.cnvEmerProfGeneralTxPeriodsec1_A8212.UIValue;
			}
			set
			{
				short num = (short)1835640319;
				short num2 = num;
				num = (short)1213507071;
				switch (num2 == num)
				{
				}
				num = (short)506986496;
				if (num != 0)
				{
				}
				num = (short)439353345;
				if (num != 0)
				{
				}
				num = (short)162988032;
				short num3 = num;
				this.cnvEmerProfGeneralTxPeriodsec1_A8212.UIValue = value;
			}
		}

		// Token: 0x17004E63 RID: 20067
		// (get) Token: 0x06009C2B RID: 39979 RVA: 0x00922C24 File Offset: 0x00920E24
		// (set) Token: 0x06009C2C RID: 39980 RVA: 0x00922CD8 File Offset: 0x00920ED8
		internal int CnvEmerProfGeneralTxPeriodsec1_A8212Min
		{
			get
			{
				short num = (short)1554647766;
				short num2 = num;
				num = (short)998378198;
				switch (num2 == num)
				{
				}
				num = (short)1365704705;
				if (num != 0)
				{
				}
				num = (short)76414976;
				if (num != 0)
				{
				}
				num = (short)1203175424;
				short num3 = num;
				return this.cnvEmerProfGeneralTxPeriodsec1_A8212.Min;
			}
			set
			{
				short num = (short)1953069749;
				short num2 = num;
				num = (short)1841265333;
				switch (num2 == num)
				{
				}
				num = (short)990838785;
				if (num != 0)
				{
				}
				num = (short)1498152960;
				if (num != 0)
				{
				}
				num = (short)103612416;
				short num3 = num;
				this.cnvEmerProfGeneralTxPeriodsec1_A8212.Min = value;
			}
		}

		// Token: 0x17004E64 RID: 20068
		// (get) Token: 0x06009C2D RID: 39981 RVA: 0x00922D8C File Offset: 0x00920F8C
		// (set) Token: 0x06009C2E RID: 39982 RVA: 0x00922E40 File Offset: 0x00921040
		internal int CnvEmerProfGeneralTxPeriodsec1_A8212Max
		{
			get
			{
				short num = (short)1141752040;
				short num2 = num;
				num = (short)1351794920;
				switch (num2 == num)
				{
				}
				num = (short)1298792448;
				if (num != 0)
				{
				}
				num = (short)1664548865;
				if (num != 0)
				{
				}
				num = (short)296026112;
				short num3 = num;
				return this.cnvEmerProfGeneralTxPeriodsec1_A8212.Max;
			}
			set
			{
				short num = (short)556207041;
				short num2 = num;
				num = (short)1475611585;
				switch (num2 == num)
				{
				}
				num = (short)1718353921;
				if (num != 0)
				{
				}
				num = (short)1498546176;
				if (num != 0)
				{
				}
				num = (short)1404043264;
				short num3 = num;
				this.cnvEmerProfGeneralTxPeriodsec1_A8212.Max = value;
			}
		}

		// Token: 0x17004E65 RID: 20069
		// (get) Token: 0x06009C2F RID: 39983 RVA: 0x00922EF4 File Offset: 0x009210F4
		// (set) Token: 0x06009C30 RID: 39984 RVA: 0x00922FA8 File Offset: 0x009211A8
		internal int CnvEmerProfGeneralTxPeriodsec1_A8212Step
		{
			get
			{
				short num = (short)1195719777;
				short num2 = num;
				num = (short)248265825;
				switch (num2 == num)
				{
				}
				num = (short)1612840961;
				if (num != 0)
				{
				}
				num = (short)1870921728;
				if (num != 0)
				{
				}
				num = (short)1154023424;
				short num3 = num;
				return this.cnvEmerProfGeneralTxPeriodsec1_A8212.StepSize;
			}
			set
			{
				short num = (short)357892097;
				if (num != 0)
				{
				}
				num = (short)726977616;
				short num2 = num;
				num = (short)1543883856;
				switch (num2 == num)
				{
				}
				num = (short)1050738688;
				if (num != 0)
				{
				}
				num = (short)1640955904;
				short num3 = num;
				this.cnvEmerProfGeneralTxPeriodsec1_A8212.StepSize = value;
			}
		}

		// Token: 0x17004E66 RID: 20070
		// (get) Token: 0x06009C31 RID: 39985 RVA: 0x0092305C File Offset: 0x0092125C
		// (set) Token: 0x06009C32 RID: 39986 RVA: 0x00923110 File Offset: 0x00921310
		public bool CnvEmerProfGeneralTxPeriodsec1_A8212_Applicable
		{
			get
			{
				short num = (short)1285699770;
				short num2 = num;
				num = (short)1696020666;
				switch (num2 == num)
				{
				}
				num = (short)1694564353;
				if (num != 0)
				{
				}
				num = (short)2035810304;
				if (num != 0)
				{
				}
				num = (short)1266548736;
				short num3 = num;
				return this.cnvEmerProfGeneralTxPeriodsec1_A8212.Applicable;
			}
			set
			{
				short num = (short)212174886;
				short num2 = num;
				num = (short)536053798;
				switch (num2 == num)
				{
				}
				num = (short)2117664768;
				if (num != 0)
				{
				}
				num = (short)509870081;
				if (num != 0)
				{
				}
				num = (short)283770880;
				short num3 = num;
				this.cnvEmerProfGeneralTxPeriodsec1_A8212.Applicable = value;
			}
		}

		// Token: 0x17004E67 RID: 20071
		// (get) Token: 0x06009C33 RID: 39987 RVA: 0x009231C8 File Offset: 0x009213C8
		// (set) Token: 0x06009C34 RID: 39988 RVA: 0x0092327C File Offset: 0x0092147C
		public bool CnvEmerProfGeneralTxPeriodsec1_A8212_Valid
		{
			get
			{
				short num = (short)981533939;
				short num2 = num;
				num = (short)102565107;
				switch (num2 == num)
				{
				}
				num = (short)1592459265;
				if (num != 0)
				{
				}
				num = (short)1321598976;
				if (num != 0)
				{
				}
				num = (short)486604800;
				short num3 = num;
				return this.cnvEmerProfGeneralTxPeriodsec1_A8212.Valid;
			}
			set
			{
				short num = (short)420776796;
				short num2 = num;
				num = (short)104106844;
				switch (num2 == num)
				{
				}
				num = (short)1694760961;
				if (num != 0)
				{
				}
				num = (short)917962752;
				if (num != 0)
				{
				}
				num = (short)381419520;
				short num3 = num;
				this.cnvEmerProfGeneralTxPeriodsec1_A8212.Valid = value;
			}
		}

		// Token: 0x17004E68 RID: 20072
		// (get) Token: 0x06009C35 RID: 39989 RVA: 0x00923334 File Offset: 0x00921534
		// (set) Token: 0x06009C36 RID: 39990 RVA: 0x009233E8 File Offset: 0x009215E8
		public bool CnvEmerProfGeneralTxPeriodsec1_A8212_Visible
		{
			get
			{
				short num = (short)753845616;
				short num2 = num;
				num = (short)936101232;
				switch (num2 == num)
				{
				}
				num = (short)507379713;
				if (num != 0)
				{
				}
				num = (short)2140733440;
				if (num != 0)
				{
				}
				num = (short)1398407168;
				short num3 = num;
				return this.cnvEmerProfGeneralTxPeriodsec1_A8212.Visible;
			}
			set
			{
				short num = (short)1222293756;
				short num2 = num;
				num = (short)1683011836;
				switch (num2 == num)
				{
				}
				num = (short)655163392;
				if (num != 0)
				{
				}
				num = (short)1528954881;
				if (num != 0)
				{
				}
				num = (short)295436288;
				short num3 = num;
				this.cnvEmerProfGeneralTxPeriodsec1_A8212.Visible = value;
			}
		}

		// Token: 0x17004E69 RID: 20073
		// (get) Token: 0x06009C37 RID: 39991 RVA: 0x0092349C File Offset: 0x0092169C
		// (set) Token: 0x06009C38 RID: 39992 RVA: 0x00923550 File Offset: 0x00921750
		public bool CnvEmerProfGeneralTxPeriodsec1_A8212_Editable
		{
			get
			{
				short num = (short)792840734;
				short num2 = num;
				num = (short)66243102;
				switch (num2 == num)
				{
				}
				num = (short)1868693504;
				if (num != 0)
				{
				}
				num = (short)301793281;
				if (num != 0)
				{
				}
				num = (short)10027008;
				short num3 = num;
				return this.cnvEmerProfGeneralTxPeriodsec1_A8212.Editable;
			}
			set
			{
				short num = (short)1261108928;
				short num2 = num;
				num = (short)711982784;
				switch (num2 == num)
				{
				}
				num = (short)918421505;
				if (num != 0)
				{
				}
				num = (short)1151860736;
				if (num != 0)
				{
				}
				num = (short)2080899072;
				short num3 = num;
				this.cnvEmerProfGeneralTxPeriodsec1_A8212.Editable = value;
			}
		}

		// Token: 0x17004E6A RID: 20074
		// (get) Token: 0x06009C39 RID: 39993 RVA: 0x00923604 File Offset: 0x00921804
		internal string CnvEmerProfGeneralTxPeriodsec1_A8212_UILabel
		{
			get
			{
				short num = (short)254514279;
				short num2 = num;
				num = (short)635999335;
				switch (num2 == num)
				{
				}
				num = (short)1357381633;
				if (num != 0)
				{
				}
				num = (short)174129152;
				if (num != 0)
				{
				}
				num = (short)2032599040;
				short num3 = num;
				return this.cnvEmerProfGeneralTxPeriodsec1_A8212.UIName;
			}
		}

		// Token: 0x17004E6B RID: 20075
		// (get) Token: 0x06009C3A RID: 39994 RVA: 0x009236B8 File Offset: 0x009218B8
		// (set) Token: 0x06009C3B RID: 39995 RVA: 0x00923768 File Offset: 0x00921968
		internal bool CnvEmerProfGeneralTxPeriodsec1_A8212_HiddenStatic
		{
			get
			{
				short num = (short)38388490;
				short num2 = num;
				num = (short)48546570;
				switch (num2 == num)
				{
				}
				num = (short)572784640;
				if (num != 0)
				{
				}
				num = (short)557514753;
				if (num != 0)
				{
				}
				num = (short)367591424;
				short num3 = num;
				return this.cnvEmerProfGeneralTxPeriodsec1_A8212.HiddenStatic;
			}
			set
			{
				short num = (short)384018534;
				short num2 = num;
				num = (short)890742886;
				switch (num2 == num)
				{
				}
				num = (short)1787953152;
				if (num != 0)
				{
				}
				num = (short)513540097;
				if (num != 0)
				{
				}
				num = (short)2087059456;
				short num3 = num;
				this.cnvEmerProfGeneralTxPeriodsec1_A8212.HiddenStatic = value;
			}
		}

		// Token: 0x17004E6C RID: 20076
		// (get) Token: 0x06009C3C RID: 39996 RVA: 0x00923820 File Offset: 0x00921A20
		// (set) Token: 0x06009C3D RID: 39997 RVA: 0x009238D8 File Offset: 0x00921AD8
		internal bool CnvEmerProfGeneralTxPeriodsec1_A8212_HiddenDynamic
		{
			get
			{
				short num = (short)398018660;
				short num2 = num;
				num = (short)2008303716;
				switch (num2 == num)
				{
				}
				num = (short)898105344;
				if (num != 0)
				{
				}
				num = (short)62062593;
				if (num != 0)
				{
				}
				num = (short)875626496;
				short num3 = num;
				return this.cnvEmerProfGeneralTxPeriodsec1_A8212.HiddenDynamic;
			}
			set
			{
				short num = (short)374734849;
				if (num != 0)
				{
				}
				num = (short)1954299209;
				short num2 = num;
				num = (short)945175881;
				switch (num2 == num)
				{
				}
				num = (short)1771044864;
				if (num != 0)
				{
				}
				num = (short)357105664;
				short num3 = num;
				this.cnvEmerProfGeneralTxPeriodsec1_A8212.HiddenDynamic = value;
			}
		}

		// Token: 0x17004E6D RID: 20077
		// (get) Token: 0x06009C3E RID: 39998 RVA: 0x0092398C File Offset: 0x00921B8C
		public bool CnvEmerProfGeneralTxPeriodsec1_A8212_HasDiffs
		{
			get
			{
				short num = (short)706740225;
				if (num != 0)
				{
				}
				num = (short)2081884736;
				short num2 = num;
				num = (short)252381760;
				switch (num2 == num)
				{
				}
				num = (short)1801519104;
				if (num != 0)
				{
				}
				num = (short)1501691904;
				short num3 = num;
				return this.cnvEmerProfGeneralTxPeriodsec1_A8212._HasDiffs;
			}
		}

		// Token: 0x17004E6E RID: 20078
		// (get) Token: 0x06009C3F RID: 39999 RVA: 0x00923A40 File Offset: 0x00921C40
		// (set) Token: 0x06009C40 RID: 40000 RVA: 0x00923AF4 File Offset: 0x00921CF4
		public int CnvEmerProfGeneralImpoliteRetries_A8242Value
		{
			get
			{
				short num = (short)626255385;
				short num2 = num;
				num = (short)614065689;
				switch (num2 == num)
				{
				}
				num = (short)640483329;
				if (num != 0)
				{
				}
				num = (short)1301086208;
				if (num != 0)
				{
				}
				num = (short)214499328;
				short num3 = num;
				return this.cnvEmerProfGeneralImpoliteRetries_A8242.Value;
			}
			set
			{
				short num = (short)803768239;
				short num2 = num;
				num = (short)1297975215;
				switch (num2 == num)
				{
				}
				num = (short)1850736640;
				if (num != 0)
				{
				}
				num = (short)1480327169;
				if (num != 0)
				{
				}
				num = (short)1837957120;
				short num3 = num;
				this.cnvEmerProfGeneralImpoliteRetries_A8242.Value = value;
			}
		}

		// Token: 0x17004E6F RID: 20079
		// (get) Token: 0x06009C41 RID: 40001 RVA: 0x00923BA8 File Offset: 0x00921DA8
		public global::AcpBusinessLayer.AcpSimpleRangeField CnvEmerProfGeneralImpoliteRetries_A8242
		{
			get
			{
				short num = (short)1851043424;
				short num2 = num;
				num = (short)223653472;
				switch (num2 == num)
				{
				default:
				{
					num = (short)421068800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)560267264;
				if (num != 0)
				{
				}
				num = (short)1577385985;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralImpoliteRetries_A8242;
			}
		}

		// Token: 0x17004E70 RID: 20080
		// (get) Token: 0x06009C42 RID: 40002 RVA: 0x00923C58 File Offset: 0x00921E58
		// (set) Token: 0x06009C43 RID: 40003 RVA: 0x00923D0C File Offset: 0x00921F0C
		public string CnvEmerProfGeneralImpoliteRetries_A8242_UIValue
		{
			get
			{
				short num = (short)1597369171;
				short num2 = num;
				num = (short)1008855891;
				switch (num2 == num)
				{
				default:
				{
					num = (short)764280832;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1697972225;
				if (num != 0)
				{
				}
				num = (short)1125711872;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralImpoliteRetries_A8242.UIValue;
			}
			set
			{
				short num = (short)435177838;
				short num2 = num;
				num = (short)71649646;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2141716480;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1831600129;
				if (num != 0)
				{
				}
				num = (short)325517312;
				if (num != 0)
				{
				}
				this.cnvEmerProfGeneralImpoliteRetries_A8242.UIValue = value;
			}
		}

		// Token: 0x17004E71 RID: 20081
		// (get) Token: 0x06009C44 RID: 40004 RVA: 0x00923DC4 File Offset: 0x00921FC4
		// (set) Token: 0x06009C45 RID: 40005 RVA: 0x00923E7C File Offset: 0x0092207C
		internal int CnvEmerProfGeneralImpoliteRetries_A8242Min
		{
			get
			{
				short num = (short)1508966401;
				if (num != 0)
				{
				}
				num = (short)1677000704;
				short num2 = num;
				num = (short)1858352781;
				short num3 = num;
				num = (short)1864906381;
				switch (num3 == num)
				{
				}
				num = (short)2102263808;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralImpoliteRetries_A8242.Min;
			}
			set
			{
				short num = (short)366162219;
				short num2 = num;
				num = (short)758526251;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2100035584;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)523436033;
				if (num != 0)
				{
				}
				num = (short)1673068544;
				if (num != 0)
				{
				}
				this.cnvEmerProfGeneralImpoliteRetries_A8242.Min = value;
			}
		}

		// Token: 0x17004E72 RID: 20082
		// (get) Token: 0x06009C46 RID: 40006 RVA: 0x00923F30 File Offset: 0x00922130
		// (set) Token: 0x06009C47 RID: 40007 RVA: 0x00923FE4 File Offset: 0x009221E4
		internal int CnvEmerProfGeneralImpoliteRetries_A8242Max
		{
			get
			{
				short num = (short)1199433017;
				short num2 = num;
				num = (short)352773433;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1090191360;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)370475008;
				if (num != 0)
				{
				}
				num = (short)804651009;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralImpoliteRetries_A8242.Max;
			}
			set
			{
				short num = (short)1311737354;
				short num2 = num;
				num = (short)1393591818;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1897922560;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1660289025;
				if (num != 0)
				{
				}
				num = (short)408485888;
				if (num != 0)
				{
				}
				this.cnvEmerProfGeneralImpoliteRetries_A8242.Max = value;
			}
		}

		// Token: 0x17004E73 RID: 20083
		// (get) Token: 0x06009C48 RID: 40008 RVA: 0x00924098 File Offset: 0x00922298
		// (set) Token: 0x06009C49 RID: 40009 RVA: 0x0092414C File Offset: 0x0092234C
		internal int CnvEmerProfGeneralImpoliteRetries_A8242Step
		{
			get
			{
				short num = (short)997426803;
				short num2 = num;
				num = (short)1813612147;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1454768128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1742798849;
				if (num != 0)
				{
				}
				num = (short)1414660096;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralImpoliteRetries_A8242.StepSize;
			}
			set
			{
				short num = (short)1725573254;
				short num2 = num;
				num = (short)1479944326;
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
				num = (short)1122828289;
				if (num != 0)
				{
				}
				num = (short)1231290368;
				if (num != 0)
				{
				}
				this.cnvEmerProfGeneralImpoliteRetries_A8242.StepSize = value;
			}
		}

		// Token: 0x17004E74 RID: 20084
		// (get) Token: 0x06009C4A RID: 40010 RVA: 0x00924200 File Offset: 0x00922400
		// (set) Token: 0x06009C4B RID: 40011 RVA: 0x009242B4 File Offset: 0x009224B4
		public bool CnvEmerProfGeneralImpoliteRetries_A8242_Applicable
		{
			get
			{
				short num = (short)810483712;
				short num2 = num;
				num = (short)1847319036;
				short num3 = num;
				num = (short)1567218172;
				switch (num3 == num)
				{
				}
				num = (short)1936195584;
				if (num != 0)
				{
				}
				num = (short)45416449;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralImpoliteRetries_A8242.Applicable;
			}
			set
			{
				short num = (short)1207959552;
				short num2 = num;
				num = (short)263585793;
				if (num != 0)
				{
				}
				num = (short)1448368010;
				short num3 = num;
				num = (short)594761610;
				switch (num3 == num)
				{
				}
				num = (short)377815040;
				if (num != 0)
				{
				}
				this.cnvEmerProfGeneralImpoliteRetries_A8242.Applicable = value;
			}
		}

		// Token: 0x17004E75 RID: 20085
		// (get) Token: 0x06009C4C RID: 40012 RVA: 0x00924368 File Offset: 0x00922568
		// (set) Token: 0x06009C4D RID: 40013 RVA: 0x0092441C File Offset: 0x0092261C
		public bool CnvEmerProfGeneralImpoliteRetries_A8242_Valid
		{
			get
			{
				short num = (short)890306560;
				short num2 = num;
				num = (short)1810171086;
				short num3 = num;
				num = (short)1331102926;
				switch (num3 == num)
				{
				}
				num = (short)1750925313;
				if (num != 0)
				{
				}
				num = (short)862322688;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralImpoliteRetries_A8242.Valid;
			}
			set
			{
				short num = (short)2010447872;
				short num2 = num;
				num = (short)739117887;
				short num3 = num;
				num = (short)827198271;
				switch (num3 == num)
				{
				}
				num = (short)1103298561;
				if (num != 0)
				{
				}
				num = (short)1736638464;
				if (num != 0)
				{
				}
				this.cnvEmerProfGeneralImpoliteRetries_A8242.Valid = value;
			}
		}

		// Token: 0x17004E76 RID: 20086
		// (get) Token: 0x06009C4E RID: 40014 RVA: 0x009244D4 File Offset: 0x009226D4
		// (set) Token: 0x06009C4F RID: 40015 RVA: 0x00924588 File Offset: 0x00922788
		public bool CnvEmerProfGeneralImpoliteRetries_A8242_Visible
		{
			get
			{
				short num = (short)1786839040;
				short num2 = num;
				num = (short)1812070401;
				if (num != 0)
				{
				}
				num = (short)1480690539;
				short num3 = num;
				num = (short)920947563;
				switch (num3 == num)
				{
				}
				num = (short)472711168;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralImpoliteRetries_A8242.Visible;
			}
			set
			{
				short num = (short)1228210176;
				short num2 = num;
				num = (short)844302753;
				short num3 = num;
				num = (short)1670646177;
				switch (num3 == num)
				{
				}
				num = (short)1421213696;
				if (num != 0)
				{
				}
				num = (short)708837377;
				if (num != 0)
				{
				}
				this.cnvEmerProfGeneralImpoliteRetries_A8242.Visible = value;
			}
		}

		// Token: 0x17004E77 RID: 20087
		// (get) Token: 0x06009C50 RID: 40016 RVA: 0x0092463C File Offset: 0x0092283C
		// (set) Token: 0x06009C51 RID: 40017 RVA: 0x009246F4 File Offset: 0x009228F4
		public bool CnvEmerProfGeneralImpoliteRetries_A8242_Editable
		{
			get
			{
				short num = (short)1203175424;
				short num2 = num;
				num = (short)153944065;
				if (num != 0)
				{
				}
				num = (short)183988272;
				short num3 = num;
				num = (short)474771504;
				switch (num3 == num)
				{
				}
				num = (short)973799424;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralImpoliteRetries_A8242.Editable;
			}
			set
			{
				short num = (short)676790272;
				short num2 = num;
				num = (short)1524445865;
				short num3 = num;
				num = (short)1582248617;
				switch (num3 == num)
				{
				}
				num = (short)434110465;
				if (num != 0)
				{
				}
				num = (short)1915813888;
				if (num != 0)
				{
				}
				this.cnvEmerProfGeneralImpoliteRetries_A8242.Editable = value;
			}
		}

		// Token: 0x17004E78 RID: 20088
		// (get) Token: 0x06009C52 RID: 40018 RVA: 0x009247AC File Offset: 0x009229AC
		internal string CnvEmerProfGeneralImpoliteRetries_A8242_UILabel
		{
			get
			{
				short num = (short)549847040;
				short num2 = num;
				num = (short)231931905;
				if (num != 0)
				{
				}
				num = (short)1292373277;
				short num3 = num;
				num = (short)1030819101;
				switch (num3 == num)
				{
				}
				num = (short)237109248;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralImpoliteRetries_A8242.UIName;
			}
		}

		// Token: 0x17004E79 RID: 20089
		// (get) Token: 0x06009C53 RID: 40019 RVA: 0x00924860 File Offset: 0x00922A60
		// (set) Token: 0x06009C54 RID: 40020 RVA: 0x00924914 File Offset: 0x00922B14
		internal bool CnvEmerProfGeneralImpoliteRetries_A8242_HiddenStatic
		{
			get
			{
				short num = (short)2105344000;
				short num2 = num;
				num = (short)697341424;
				short num3 = num;
				num = (short)1311413744;
				switch (num3 == num)
				{
				}
				num = (short)120258561;
				if (num != 0)
				{
				}
				num = (short)1468792832;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralImpoliteRetries_A8242.HiddenStatic;
			}
			set
			{
				short num = (short)2032730112;
				short num2 = num;
				num = (short)866451457;
				if (num != 0)
				{
				}
				num = (short)958763098;
				short num3 = num;
				num = (short)1316851802;
				switch (num3 == num)
				{
				}
				num = (short)7929856;
				if (num != 0)
				{
				}
				this.cnvEmerProfGeneralImpoliteRetries_A8242.HiddenStatic = value;
			}
		}

		// Token: 0x17004E7A RID: 20090
		// (get) Token: 0x06009C55 RID: 40021 RVA: 0x009249CC File Offset: 0x00922BCC
		// (set) Token: 0x06009C56 RID: 40022 RVA: 0x00924A80 File Offset: 0x00922C80
		internal bool CnvEmerProfGeneralImpoliteRetries_A8242_HiddenDynamic
		{
			get
			{
				short num = (short)570032128;
				short num2 = num;
				num = (short)723552442;
				short num3 = num;
				num = (short)1282771130;
				switch (num3 == num)
				{
				}
				num = (short)512557057;
				if (num != 0)
				{
				}
				num = (short)150077440;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralImpoliteRetries_A8242.HiddenDynamic;
			}
			set
			{
				short num = (short)1515847680;
				short num2 = num;
				num = (short)1620100990;
				short num3 = num;
				num = (short)2050803582;
				switch (num3 == num)
				{
				}
				num = (short)651034625;
				if (num != 0)
				{
				}
				num = (short)1406926848;
				if (num != 0)
				{
				}
				this.cnvEmerProfGeneralImpoliteRetries_A8242.HiddenDynamic = value;
			}
		}

		// Token: 0x17004E7B RID: 20091
		// (get) Token: 0x06009C57 RID: 40023 RVA: 0x00924B34 File Offset: 0x00922D34
		public bool CnvEmerProfGeneralImpoliteRetries_A8242_HasDiffs
		{
			get
			{
				short num = (short)147128320;
				short num2 = num;
				num = (short)1037608742;
				short num3 = num;
				num = (short)1306896166;
				switch (num3 == num)
				{
				}
				num = (short)986972161;
				if (num != 0)
				{
				}
				num = (short)419037184;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralImpoliteRetries_A8242._HasDiffs;
			}
		}

		// Token: 0x17004E7C RID: 20092
		// (get) Token: 0x06009C58 RID: 40024 RVA: 0x00924BE8 File Offset: 0x00922DE8
		// (set) Token: 0x06009C59 RID: 40025 RVA: 0x00924C9C File Offset: 0x00922E9C
		public int CnvEmerProfGeneralTxPeriodsec2_A9131Value
		{
			get
			{
				short num = (short)2010775552;
				short num2 = num;
				num = (short)1027177350;
				short num3 = num;
				num = (short)154106758;
				switch (num3 == num)
				{
				}
				num = (short)497876993;
				if (num != 0)
				{
				}
				num = (short)222691328;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralTxPeriodsec2_A9131.Value;
			}
			set
			{
				short num = (short)547422208;
				short num2 = num;
				num = (short)1134230990;
				short num3 = num;
				num = (short)900070862;
				switch (num3 == num)
				{
				}
				num = (short)1626472448;
				if (num != 0)
				{
				}
				num = (short)1492779009;
				if (num != 0)
				{
				}
				this.cnvEmerProfGeneralTxPeriodsec2_A9131.Value = value;
			}
		}

		// Token: 0x17004E7D RID: 20093
		// (get) Token: 0x06009C5A RID: 40026 RVA: 0x00924D50 File Offset: 0x00922F50
		public global::AcpBusinessLayer.AcpSimpleRangeField CnvEmerProfGeneralTxPeriodsec2_A9131
		{
			get
			{
				short num = (short)1785331712;
				short num2 = num;
				num = (short)1719505279;
				short num3 = num;
				num = (short)1635094911;
				switch (num3 == num)
				{
				}
				num = (short)990576641;
				if (num != 0)
				{
				}
				num = (short)1324548096;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralTxPeriodsec2_A9131;
			}
		}

		// Token: 0x17004E7E RID: 20094
		// (get) Token: 0x06009C5B RID: 40027 RVA: 0x00924E00 File Offset: 0x00923000
		// (set) Token: 0x06009C5C RID: 40028 RVA: 0x00924EB4 File Offset: 0x009230B4
		public string CnvEmerProfGeneralTxPeriodsec2_A9131_UIValue
		{
			get
			{
				short num = (short)1546584064;
				short num2 = num;
				num = (short)1958878066;
				short num3 = num;
				num = (short)1238834034;
				switch (num3 == num)
				{
				}
				num = (short)911212545;
				if (num != 0)
				{
				}
				num = (short)1729822720;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralTxPeriodsec2_A9131.UIValue;
			}
			set
			{
				short num = (short)1382350848;
				short num2 = num;
				num = (short)792456385;
				short num3 = num;
				num = (short)1308945601;
				switch (num3 == num)
				{
				}
				num = (short)411566081;
				if (num != 0)
				{
				}
				num = (short)41418752;
				if (num != 0)
				{
				}
				this.cnvEmerProfGeneralTxPeriodsec2_A9131.UIValue = value;
			}
		}

		// Token: 0x17004E7F RID: 20095
		// (get) Token: 0x06009C5D RID: 40029 RVA: 0x00924F68 File Offset: 0x00923168
		// (set) Token: 0x06009C5E RID: 40030 RVA: 0x0092501C File Offset: 0x0092321C
		internal int CnvEmerProfGeneralTxPeriodsec2_A9131Min
		{
			get
			{
				short num = (short)2025390080;
				short num2 = num;
				num = (short)421986305;
				if (num != 0)
				{
				}
				num = (short)1315184874;
				short num3 = num;
				num = (short)1889476842;
				switch (num3 == num)
				{
				}
				num = (short)821428224;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralTxPeriodsec2_A9131.Min;
			}
			set
			{
				short num = (short)1284440064;
				short num2 = num;
				num = (short)411287178;
				short num3 = num;
				num = (short)126008970;
				switch (num3 == num)
				{
				}
				num = (short)798359552;
				if (num != 0)
				{
				}
				num = (short)595787777;
				if (num != 0)
				{
				}
				this.cnvEmerProfGeneralTxPeriodsec2_A9131.Min = value;
			}
		}

		// Token: 0x17004E80 RID: 20096
		// (get) Token: 0x06009C5F RID: 40031 RVA: 0x009250D0 File Offset: 0x009232D0
		// (set) Token: 0x06009C60 RID: 40032 RVA: 0x00925184 File Offset: 0x00923384
		internal int CnvEmerProfGeneralTxPeriodsec2_A9131Max
		{
			get
			{
				short num = (short)655032320;
				short num2 = num;
				num = (short)1271205012;
				short num3 = num;
				num = (short)1676151956;
				switch (num3 == num)
				{
				}
				num = (short)922157057;
				if (num != 0)
				{
				}
				num = (short)515375104;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralTxPeriodsec2_A9131.Max;
			}
			set
			{
				short num = (short)357826560;
				short num2 = num;
				num = (short)1411356064;
				short num3 = num;
				num = (short)550475168;
				switch (num3 == num)
				{
				}
				num = (short)256573441;
				if (num != 0)
				{
				}
				num = (short)829358080;
				if (num != 0)
				{
				}
				this.cnvEmerProfGeneralTxPeriodsec2_A9131.Max = value;
			}
		}

		// Token: 0x17004E81 RID: 20097
		// (get) Token: 0x06009C61 RID: 40033 RVA: 0x00925238 File Offset: 0x00923438
		// (set) Token: 0x06009C62 RID: 40034 RVA: 0x009252EC File Offset: 0x009234EC
		internal int CnvEmerProfGeneralTxPeriodsec2_A9131Step
		{
			get
			{
				short num = (short)508035072;
				short num2 = num;
				num = (short)1757675521;
				if (num != 0)
				{
				}
				num = (short)834387941;
				short num3 = num;
				num = (short)1050263525;
				switch (num3 == num)
				{
				}
				num = (short)561709056;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralTxPeriodsec2_A9131.StepSize;
			}
			set
			{
				short num = (short)1601110016;
				short num2 = num;
				num = (short)810255143;
				short num3 = num;
				num = (short)740131623;
				switch (num3 == num)
				{
				}
				num = (short)762839040;
				if (num != 0)
				{
				}
				num = (short)1547894785;
				if (num != 0)
				{
				}
				this.cnvEmerProfGeneralTxPeriodsec2_A9131.StepSize = value;
			}
		}

		// Token: 0x17004E82 RID: 20098
		// (get) Token: 0x06009C63 RID: 40035 RVA: 0x009253A0 File Offset: 0x009235A0
		// (set) Token: 0x06009C64 RID: 40036 RVA: 0x00925458 File Offset: 0x00923658
		public bool CnvEmerProfGeneralTxPeriodsec2_A9131_Applicable
		{
			get
			{
				short num = (short)2061238272;
				short num2 = num;
				num = (short)1884605525;
				short num3 = num;
				num = (short)2108869717;
				switch (num3 == num)
				{
				}
				num = (short)1633615873;
				if (num != 0)
				{
				}
				num = (short)526778368;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralTxPeriodsec2_A9131.Applicable;
			}
			set
			{
				short num = (short)593100800;
				short num2 = num;
				num = (short)759551380;
				short num3 = num;
				num = (short)1149621652;
				switch (num3 == num)
				{
				}
				num = (short)303890433;
				if (num != 0)
				{
				}
				num = (short)243073024;
				if (num != 0)
				{
				}
				this.cnvEmerProfGeneralTxPeriodsec2_A9131.Applicable = value;
			}
		}

		// Token: 0x17004E83 RID: 20099
		// (get) Token: 0x06009C65 RID: 40037 RVA: 0x00925510 File Offset: 0x00923710
		// (set) Token: 0x06009C66 RID: 40038 RVA: 0x009255C4 File Offset: 0x009237C4
		public bool CnvEmerProfGeneralTxPeriodsec2_A9131_Valid
		{
			get
			{
				short num = (short)1493237760;
				short num2 = num;
				num = (short)164348498;
				short num3 = num;
				num = (short)1581630034;
				switch (num3 == num)
				{
				}
				num = (short)1165623296;
				if (num != 0)
				{
				}
				num = (short)1907425281;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralTxPeriodsec2_A9131.Valid;
			}
			set
			{
				short num = (short)1473643987;
				short num2 = num;
				num = (short)15140307;
				switch (num2 == num)
				{
				}
				num = (short)535822336;
				short num3 = num;
				num = (short)2002124801;
				if (num != 0)
				{
				}
				num = (short)906821632;
				if (num != 0)
				{
				}
				this.cnvEmerProfGeneralTxPeriodsec2_A9131.Valid = value;
			}
		}

		// Token: 0x17004E84 RID: 20100
		// (get) Token: 0x06009C67 RID: 40039 RVA: 0x00925678 File Offset: 0x00923878
		// (set) Token: 0x06009C68 RID: 40040 RVA: 0x0092572C File Offset: 0x0092392C
		public bool CnvEmerProfGeneralTxPeriodsec2_A9131_Visible
		{
			get
			{
				short num = (short)596220709;
				short num2 = num;
				num = (short)409443109;
				switch (num2 == num)
				{
				}
				num = (short)1755774976;
				short num3 = num;
				num = (short)1998913537;
				if (num != 0)
				{
				}
				num = (short)1894514688;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralTxPeriodsec2_A9131.Visible;
			}
			set
			{
				short num = (short)1195463553;
				short num2 = num;
				num = (short)1365595009;
				switch (num2 == num)
				{
				}
				num = (short)2141192192;
				short num3 = num;
				num = (short)1763377152;
				if (num != 0)
				{
				}
				num = (short)141164545;
				if (num != 0)
				{
				}
				this.cnvEmerProfGeneralTxPeriodsec2_A9131.Visible = value;
			}
		}

		// Token: 0x17004E85 RID: 20101
		// (get) Token: 0x06009C69 RID: 40041 RVA: 0x009257E4 File Offset: 0x009239E4
		// (set) Token: 0x06009C6A RID: 40042 RVA: 0x0092589C File Offset: 0x00923A9C
		public bool CnvEmerProfGeneralTxPeriodsec2_A9131_Editable
		{
			get
			{
				short num = (short)1740702235;
				short num2 = num;
				num = (short)515310107;
				switch (num2 == num)
				{
				}
				num = (short)1142095872;
				short num3 = num;
				num = (short)1432551425;
				if (num != 0)
				{
				}
				num = (short)74186752;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralTxPeriodsec2_A9131.Editable;
			}
			set
			{
				short num = (short)1876917887;
				short num2 = num;
				num = (short)222396031;
				switch (num2 == num)
				{
				}
				num = (short)669384704;
				short num3 = num;
				num = (short)314179585;
				if (num != 0)
				{
				}
				num = (short)1120206848;
				if (num != 0)
				{
				}
				this.cnvEmerProfGeneralTxPeriodsec2_A9131.Editable = value;
			}
		}

		// Token: 0x17004E86 RID: 20102
		// (get) Token: 0x06009C6B RID: 40043 RVA: 0x00925954 File Offset: 0x00923B54
		internal string CnvEmerProfGeneralTxPeriodsec2_A9131_UILabel
		{
			get
			{
				short num = (short)1020919809;
				if (num != 0)
				{
				}
				num = (short)2145280726;
				short num2 = num;
				num = (short)102720214;
				switch (num2 == num)
				{
				default:
				{
					num = (short)853147648;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1705902080;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralTxPeriodsec2_A9131.UIName;
			}
		}

		// Token: 0x17004E87 RID: 20103
		// (get) Token: 0x06009C6C RID: 40044 RVA: 0x00925A08 File Offset: 0x00923C08
		// (set) Token: 0x06009C6D RID: 40045 RVA: 0x00925ABC File Offset: 0x00923CBC
		internal bool CnvEmerProfGeneralTxPeriodsec2_A9131_HiddenStatic
		{
			get
			{
				short num = (short)613870451;
				short num2 = num;
				num = (short)895478643;
				switch (num2 == num)
				{
				}
				num = (short)1326710784;
				short num3 = num;
				num = (short)918683649;
				if (num != 0)
				{
				}
				num = (short)1098579968;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralTxPeriodsec2_A9131.HiddenStatic;
			}
			set
			{
				short num = (short)1355571569;
				short num2 = num;
				num = (short)1762353521;
				switch (num2 == num)
				{
				}
				num = (short)1904148480;
				short num3 = num;
				num = (short)2024865793;
				if (num != 0)
				{
				}
				num = (short)1937571840;
				if (num != 0)
				{
				}
				this.cnvEmerProfGeneralTxPeriodsec2_A9131.HiddenStatic = value;
			}
		}

		// Token: 0x17004E88 RID: 20104
		// (get) Token: 0x06009C6E RID: 40046 RVA: 0x00925B70 File Offset: 0x00923D70
		// (set) Token: 0x06009C6F RID: 40047 RVA: 0x00925C24 File Offset: 0x00923E24
		internal bool CnvEmerProfGeneralTxPeriodsec2_A9131_HiddenDynamic
		{
			get
			{
				short num = (short)482133327;
				short num2 = num;
				num = (short)1972421967;
				switch (num2 == num)
				{
				}
				num = (short)1429471232;
				short num3 = num;
				num = (short)670040065;
				if (num != 0)
				{
				}
				num = (short)214433792;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralTxPeriodsec2_A9131.HiddenDynamic;
			}
			set
			{
				short num = (short)311620481;
				short num2 = num;
				num = (short)827519873;
				switch (num2 == num)
				{
				}
				num = (short)1700659200;
				short num3 = num;
				num = (short)2062876673;
				if (num != 0)
				{
				}
				num = (short)1301217280;
				if (num != 0)
				{
				}
				this.cnvEmerProfGeneralTxPeriodsec2_A9131.HiddenDynamic = value;
			}
		}

		// Token: 0x17004E89 RID: 20105
		// (get) Token: 0x06009C70 RID: 40048 RVA: 0x00925CDC File Offset: 0x00923EDC
		public bool CnvEmerProfGeneralTxPeriodsec2_A9131_HasDiffs
		{
			get
			{
				short num = (short)2042626049;
				if (num != 0)
				{
				}
				num = (short)90573051;
				short num2 = num;
				num = (short)822085883;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1293156352;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)370081792;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralTxPeriodsec2_A9131._HasDiffs;
			}
		}

		// Token: 0x17004E8A RID: 20106
		// (get) Token: 0x06009C71 RID: 40049 RVA: 0x00925D94 File Offset: 0x00923F94
		// (set) Token: 0x06009C72 RID: 40050 RVA: 0x00925E48 File Offset: 0x00924048
		public bool CnvEmerProfGeneralConsoleAckRequired_A40167Value
		{
			get
			{
				short num = (short)1333198849;
				if (num != 0)
				{
				}
				num = (short)1663023465;
				short num2 = num;
				num = (short)222673257;
				switch (num2 == num)
				{
				default:
				{
					num = (short)262340608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1938096128;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralConsoleAckRequired_A40167.Value;
			}
			set
			{
				short num = (short)419510326;
				short num2 = num;
				num = (short)1096038454;
				switch (num2 == num)
				{
				}
				num = (short)2088828928;
				short num3 = num;
				num = (short)1083572224;
				if (num != 0)
				{
				}
				num = (short)1127940097;
				if (num != 0)
				{
				}
				this.cnvEmerProfGeneralConsoleAckRequired_A40167.Value = value;
			}
		}

		// Token: 0x17004E8B RID: 20107
		// (get) Token: 0x06009C73 RID: 40051 RVA: 0x00925F00 File Offset: 0x00924100
		public global::AcpBusinessLayer.AcpField<bool> CnvEmerProfGeneralConsoleAckRequired_A40167
		{
			get
			{
				short num = (short)1395201466;
				short num2 = num;
				num = (short)1313412538;
				switch (num2 == num)
				{
				}
				num = (short)2005336064;
				short num3 = num;
				num = (short)219152385;
				if (num != 0)
				{
				}
				num = (short)1489502208;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralConsoleAckRequired_A40167;
			}
		}

		// Token: 0x17004E8C RID: 20108
		// (get) Token: 0x06009C74 RID: 40052 RVA: 0x00925FAC File Offset: 0x009241AC
		// (set) Token: 0x06009C75 RID: 40053 RVA: 0x00926060 File Offset: 0x00924260
		public bool CnvEmerProfGeneralConsoleAckRequired_A40167_UIValue
		{
			get
			{
				short num = (short)566308908;
				short num2 = num;
				num = (short)1794125868;
				switch (num2 == num)
				{
				}
				num = (short)1733689344;
				short num3 = num;
				num = (short)365166592;
				if (num != 0)
				{
				}
				num = (short)1863254017;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralConsoleAckRequired_A40167.Value;
			}
			set
			{
				short num = (short)497054800;
				short num2 = num;
				num = (short)636384336;
				switch (num2 == num)
				{
				}
				num = (short)50855936;
				short num3 = num;
				num = (short)871497728;
				if (num != 0)
				{
				}
				num = (short)1990393857;
				if (num != 0)
				{
				}
				this.cnvEmerProfGeneralConsoleAckRequired_A40167.Value = value;
			}
		}

		// Token: 0x17004E8D RID: 20109
		// (get) Token: 0x06009C76 RID: 40054 RVA: 0x00926118 File Offset: 0x00924318
		// (set) Token: 0x06009C77 RID: 40055 RVA: 0x009261CC File Offset: 0x009243CC
		public bool CnvEmerProfGeneralConsoleAckRequired_A40167_Applicable
		{
			get
			{
				short num = (short)802182591;
				short num2 = num;
				num = (short)21583295;
				switch (num2 == num)
				{
				}
				num = (short)1426784256;
				short num3 = num;
				num = (short)515899393;
				if (num != 0)
				{
				}
				num = (short)309198848;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralConsoleAckRequired_A40167.Applicable;
			}
			set
			{
				short num = (short)1819868916;
				short num2 = num;
				num = (short)977010420;
				switch (num2 == num)
				{
				}
				num = (short)1665990656;
				short num3 = num;
				num = (short)334102529;
				if (num != 0)
				{
				}
				num = (short)18153472;
				if (num != 0)
				{
				}
				this.cnvEmerProfGeneralConsoleAckRequired_A40167.Applicable = value;
			}
		}

		// Token: 0x17004E8E RID: 20110
		// (get) Token: 0x06009C78 RID: 40056 RVA: 0x00926284 File Offset: 0x00924484
		// (set) Token: 0x06009C79 RID: 40057 RVA: 0x0092633C File Offset: 0x0092453C
		public bool CnvEmerProfGeneralConsoleAckRequired_A40167_Valid
		{
			get
			{
				short num = (short)545253089;
				short num2 = num;
				num = (short)2049042145;
				switch (num2 == num)
				{
				}
				num = (short)365297664;
				short num3 = num;
				num = (short)966197248;
				if (num != 0)
				{
				}
				num = (short)1121845249;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralConsoleAckRequired_A40167.Valid;
			}
			set
			{
				short num = (short)261506092;
				short num2 = num;
				num = (short)1859142700;
				switch (num2 == num)
				{
				}
				num = (short)10485760;
				short num3 = num;
				num = (short)1589248000;
				if (num != 0)
				{
				}
				num = (short)496893953;
				if (num != 0)
				{
				}
				this.cnvEmerProfGeneralConsoleAckRequired_A40167.Valid = value;
			}
		}

		// Token: 0x17004E8F RID: 20111
		// (get) Token: 0x06009C7A RID: 40058 RVA: 0x009263F4 File Offset: 0x009245F4
		// (set) Token: 0x06009C7B RID: 40059 RVA: 0x009264A8 File Offset: 0x009246A8
		public bool CnvEmerProfGeneralConsoleAckRequired_A40167_Visible
		{
			get
			{
				short num = (short)1392889319;
				short num2 = num;
				num = (short)1264242151;
				switch (num2 == num)
				{
				}
				num = (short)369885184;
				short num3 = num;
				num = (short)382992385;
				if (num != 0)
				{
				}
				num = (short)2071461888;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralConsoleAckRequired_A40167.Visible;
			}
			set
			{
				short num = (short)1363818686;
				short num2 = num;
				num = (short)209991870;
				switch (num2 == num)
				{
				}
				num = (short)1079312384;
				short num3 = num;
				num = (short)1840119809;
				if (num != 0)
				{
				}
				num = (short)347602944;
				if (num != 0)
				{
				}
				this.cnvEmerProfGeneralConsoleAckRequired_A40167.Visible = value;
			}
		}

		// Token: 0x17004E90 RID: 20112
		// (get) Token: 0x06009C7C RID: 40060 RVA: 0x00926560 File Offset: 0x00924760
		// (set) Token: 0x06009C7D RID: 40061 RVA: 0x00926614 File Offset: 0x00924814
		public bool CnvEmerProfGeneralConsoleAckRequired_A40167_Editable
		{
			get
			{
				short num = (short)2096603051;
				short num2 = num;
				num = (short)1266917291;
				switch (num2 == num)
				{
				}
				num = (short)1079246848;
				short num3 = num;
				num = (short)1421737985;
				if (num != 0)
				{
				}
				num = (short)1936654336;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralConsoleAckRequired_A40167.Editable;
			}
			set
			{
				short num = (short)646891974;
				short num2 = num;
				num = (short)308070854;
				switch (num2 == num)
				{
				}
				num = (short)1891500032;
				short num3 = num;
				num = (short)1273495553;
				if (num != 0)
				{
				}
				num = (short)2001731584;
				if (num != 0)
				{
				}
				this.cnvEmerProfGeneralConsoleAckRequired_A40167.Editable = value;
			}
		}

		// Token: 0x17004E91 RID: 20113
		// (get) Token: 0x06009C7E RID: 40062 RVA: 0x009266CC File Offset: 0x009248CC
		internal string CnvEmerProfGeneralConsoleAckRequired_A40167_UILabel
		{
			get
			{
				short num = (short)1561499977;
				short num2 = num;
				num = (short)128620873;
				switch (num2 == num)
				{
				}
				num = (short)1903165440;
				short num3 = num;
				num = (short)1183252480;
				if (num != 0)
				{
				}
				num = (short)343539713;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralConsoleAckRequired_A40167.UIName;
			}
		}

		// Token: 0x17004E92 RID: 20114
		// (get) Token: 0x06009C7F RID: 40063 RVA: 0x00926780 File Offset: 0x00924980
		// (set) Token: 0x06009C80 RID: 40064 RVA: 0x00926834 File Offset: 0x00924A34
		internal bool CnvEmerProfGeneralConsoleAckRequired_A40167_HiddenStatic
		{
			get
			{
				short num = (short)1452041609;
				short num2 = num;
				num = (short)1534158217;
				switch (num2 == num)
				{
				}
				num = (short)855506944;
				short num3 = num;
				num = (short)1169817601;
				if (num != 0)
				{
				}
				num = (short)1347158016;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralConsoleAckRequired_A40167.HiddenStatic;
			}
			set
			{
				short num = (short)883059196;
				short num2 = num;
				num = (short)1265003004;
				switch (num2 == num)
				{
				}
				num = (short)384303104;
				short num3 = num;
				num = (short)77201408;
				if (num != 0)
				{
				}
				num = (short)1587609601;
				if (num != 0)
				{
				}
				this.cnvEmerProfGeneralConsoleAckRequired_A40167.HiddenStatic = value;
			}
		}

		// Token: 0x17004E93 RID: 20115
		// (get) Token: 0x06009C81 RID: 40065 RVA: 0x009268E8 File Offset: 0x00924AE8
		// (set) Token: 0x06009C82 RID: 40066 RVA: 0x009269A0 File Offset: 0x00924BA0
		internal bool CnvEmerProfGeneralConsoleAckRequired_A40167_HiddenDynamic
		{
			get
			{
				short num = (short)308923751;
				short num2 = num;
				num = (short)1814023527;
				switch (num2 == num)
				{
				}
				num = (short)1946484736;
				short num3 = num;
				num = (short)2054815745;
				if (num != 0)
				{
				}
				num = (short)2108424192;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralConsoleAckRequired_A40167.HiddenDynamic;
			}
			set
			{
				short num = (short)1706213866;
				short num2 = num;
				num = (short)1102627306;
				switch (num2 == num)
				{
				}
				num = (short)1511260160;
				short num3 = num;
				num = (short)1080229889;
				if (num != 0)
				{
				}
				num = (short)1735393280;
				if (num != 0)
				{
				}
				this.cnvEmerProfGeneralConsoleAckRequired_A40167.HiddenDynamic = value;
			}
		}

		// Token: 0x17004E94 RID: 20116
		// (get) Token: 0x06009C83 RID: 40067 RVA: 0x00926A54 File Offset: 0x00924C54
		public bool CnvEmerProfGeneralConsoleAckRequired_A40167_HasDiffs
		{
			get
			{
				short num = (short)1714046185;
				short num2 = num;
				num = (short)402736361;
				switch (num2 == num)
				{
				}
				num = (short)837419008;
				short num3 = num;
				num = (short)592773121;
				if (num != 0)
				{
				}
				num = (short)1750335488;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralConsoleAckRequired_A40167._HasDiffs;
			}
		}

		// Token: 0x17004E95 RID: 20117
		// (get) Token: 0x06009C84 RID: 40068 RVA: 0x00926B08 File Offset: 0x00924D08
		// (set) Token: 0x06009C85 RID: 40069 RVA: 0x00926BBC File Offset: 0x00924DBC
		public bool CnvPerManDownEnable_42038Value
		{
			get
			{
				short num = (short)954828823;
				short num2 = num;
				num = (short)1644726295;
				switch (num2 == num)
				{
				}
				num = (short)1125384192;
				short num3 = num;
				num = (short)155779072;
				if (num != 0)
				{
				}
				num = (short)1749221377;
				if (num != 0)
				{
				}
				return this.cnvPerManDownEnable_42038.Value;
			}
			set
			{
				short num = (short)2006630166;
				short num2 = num;
				num = (short)5422870;
				switch (num2 == num)
				{
				}
				num = (short)353304576;
				short num3 = num;
				num = (short)2002845697;
				if (num != 0)
				{
				}
				num = (short)1943273472;
				if (num != 0)
				{
				}
				this.cnvPerManDownEnable_42038.Value = value;
			}
		}

		// Token: 0x17004E96 RID: 20118
		// (get) Token: 0x06009C86 RID: 40070 RVA: 0x00926C70 File Offset: 0x00924E70
		public global::AcpBusinessLayer.AcpField<bool> CnvPerManDownEnable_42038
		{
			get
			{
				short num = (short)1781347340;
				short num2 = num;
				num = (short)1372664844;
				switch (num2 == num)
				{
				}
				num = (short)254607360;
				short num3 = num;
				num = (short)739115009;
				if (num != 0)
				{
				}
				num = (short)1297088512;
				if (num != 0)
				{
				}
				return this.cnvPerManDownEnable_42038;
			}
		}

		// Token: 0x17004E97 RID: 20119
		// (get) Token: 0x06009C87 RID: 40071 RVA: 0x00926D20 File Offset: 0x00924F20
		// (set) Token: 0x06009C88 RID: 40072 RVA: 0x00926DD8 File Offset: 0x00924FD8
		public bool CnvPerManDownEnable_42038_UIValue
		{
			get
			{
				short num = (short)1825418717;
				short num2 = num;
				num = (short)1381608925;
				switch (num2 == num)
				{
				}
				num = (short)2095710208;
				short num3 = num;
				num = (short)1780940801;
				if (num != 0)
				{
				}
				num = (short)77004800;
				if (num != 0)
				{
				}
				return this.cnvPerManDownEnable_42038.Value;
			}
			set
			{
				short num = (short)1670589653;
				short num2 = num;
				num = (short)1197354197;
				switch (num2 == num)
				{
				}
				num = (short)207224832;
				short num3 = num;
				num = (short)90636288;
				if (num != 0)
				{
				}
				num = (short)1879638017;
				if (num != 0)
				{
				}
				this.cnvPerManDownEnable_42038.Value = value;
			}
		}

		// Token: 0x17004E98 RID: 20120
		// (get) Token: 0x06009C89 RID: 40073 RVA: 0x00926E8C File Offset: 0x0092508C
		// (set) Token: 0x06009C8A RID: 40074 RVA: 0x00926F40 File Offset: 0x00925140
		public bool CnvPerManDownEnable_42038_Applicable
		{
			get
			{
				short num = (short)1381462520;
				short num2 = num;
				num = (short)1983672824;
				switch (num2 == num)
				{
				}
				num = (short)1103626240;
				short num3 = num;
				num = (short)1781334017;
				if (num != 0)
				{
				}
				num = (short)677838848;
				if (num != 0)
				{
				}
				return this.cnvPerManDownEnable_42038.Applicable;
			}
			set
			{
				short num = (short)719536750;
				short num2 = num;
				num = (short)601113198;
				switch (num2 == num)
				{
				}
				num = (short)1776353281;
				if (num != 0)
				{
				}
				num = (short)1417740288;
				short num3 = num;
				num = (short)1099694080;
				if (num != 0)
				{
				}
				this.cnvPerManDownEnable_42038.Applicable = value;
			}
		}

		// Token: 0x17004E99 RID: 20121
		// (get) Token: 0x06009C8B RID: 40075 RVA: 0x00926FF4 File Offset: 0x009251F4
		// (set) Token: 0x06009C8C RID: 40076 RVA: 0x009270A8 File Offset: 0x009252A8
		public bool CnvPerManDownEnable_42038_Valid
		{
			get
			{
				short num = (short)168791615;
				short num2 = num;
				num = (short)1215598143;
				switch (num2 == num)
				{
				}
				num = (short)2090270721;
				if (num != 0)
				{
				}
				num = (short)1433010176;
				short num3 = num;
				num = (short)1219624960;
				if (num != 0)
				{
				}
				return this.cnvPerManDownEnable_42038.Valid;
			}
			set
			{
				short num = (short)437714945;
				if (num != 0)
				{
				}
				num = (short)1929972283;
				short num2 = num;
				num = (short)954665531;
				switch (num2 == num)
				{
				}
				num = (short)1249574912;
				short num3 = num;
				num = (short)943980544;
				if (num != 0)
				{
				}
				this.cnvPerManDownEnable_42038.Valid = value;
			}
		}

		// Token: 0x17004E9A RID: 20122
		// (get) Token: 0x06009C8D RID: 40077 RVA: 0x0092715C File Offset: 0x0092535C
		// (set) Token: 0x06009C8E RID: 40078 RVA: 0x00927210 File Offset: 0x00925410
		public bool CnvPerManDownEnable_42038_Visible
		{
			get
			{
				short num = (short)1051983873;
				if (num != 0)
				{
				}
				num = (short)1141859496;
				short num2 = num;
				num = (short)499082408;
				switch (num2 == num)
				{
				}
				num = (short)1689321472;
				short num3 = num;
				num = (short)316538880;
				if (num != 0)
				{
				}
				return this.cnvPerManDownEnable_42038.Visible;
			}
			set
			{
				short num = (short)264551347;
				short num2 = num;
				num = (short)49003443;
				switch (num2 == num)
				{
				}
				num = (short)331350016;
				if (num != 0)
				{
				}
				num = (short)657588224;
				short num3 = num;
				num = (short)2086731777;
				if (num != 0)
				{
				}
				this.cnvPerManDownEnable_42038.Visible = value;
			}
		}

		// Token: 0x17004E9B RID: 20123
		// (get) Token: 0x06009C8F RID: 40079 RVA: 0x009272C4 File Offset: 0x009254C4
		// (set) Token: 0x06009C90 RID: 40080 RVA: 0x00927378 File Offset: 0x00925578
		public bool CnvPerManDownEnable_42038_Editable
		{
			get
			{
				short num = (short)1461131796;
				short num2 = num;
				num = (short)1388321300;
				switch (num2 == num)
				{
				}
				num = (short)2104295425;
				if (num != 0)
				{
				}
				num = (short)1537867776;
				short num3 = num;
				num = (short)99287040;
				if (num != 0)
				{
				}
				return this.cnvPerManDownEnable_42038.Editable;
			}
			set
			{
				short num = (short)1006778494;
				short num2 = num;
				num = (short)1747400830;
				switch (num2 == num)
				{
				}
				num = (short)369229825;
				if (num != 0)
				{
				}
				num = (short)155779072;
				short num3 = num;
				num = (short)452788224;
				if (num != 0)
				{
				}
				this.cnvPerManDownEnable_42038.Editable = value;
			}
		}

		// Token: 0x17004E9C RID: 20124
		// (get) Token: 0x06009C91 RID: 40081 RVA: 0x00927430 File Offset: 0x00925630
		internal string CnvPerManDownEnable_42038_UILabel
		{
			get
			{
				short num = (short)2011405822;
				short num2 = num;
				num = (short)529571326;
				switch (num2 == num)
				{
				}
				num = (short)88735745;
				if (num != 0)
				{
				}
				num = (short)1797718016;
				short num3 = num;
				num = (short)987496448;
				if (num != 0)
				{
				}
				return this.cnvPerManDownEnable_42038.UIName;
			}
		}

		// Token: 0x17004E9D RID: 20125
		// (get) Token: 0x06009C92 RID: 40082 RVA: 0x009274E8 File Offset: 0x009256E8
		// (set) Token: 0x06009C93 RID: 40083 RVA: 0x0092759C File Offset: 0x0092579C
		internal bool CnvPerManDownEnable_42038_HiddenStatic
		{
			get
			{
				short num = (short)1427378806;
				short num2 = num;
				num = (short)1066406518;
				switch (num2 == num)
				{
				}
				num = (short)1684013057;
				if (num != 0)
				{
				}
				num = (short)2128936960;
				short num3 = num;
				num = (short)1803812864;
				if (num != 0)
				{
				}
				return this.cnvPerManDownEnable_42038.HiddenStatic;
			}
			set
			{
				short num = (short)141898583;
				short num2 = num;
				num = (short)474690391;
				switch (num2 == num)
				{
				}
				num = (short)192282625;
				if (num != 0)
				{
				}
				num = (short)794230784;
				short num3 = num;
				num = (short)119013376;
				if (num != 0)
				{
				}
				this.cnvPerManDownEnable_42038.HiddenStatic = value;
			}
		}

		// Token: 0x17004E9E RID: 20126
		// (get) Token: 0x06009C94 RID: 40084 RVA: 0x00927650 File Offset: 0x00925850
		// (set) Token: 0x06009C95 RID: 40085 RVA: 0x00927704 File Offset: 0x00925904
		internal bool CnvPerManDownEnable_42038_HiddenDynamic
		{
			get
			{
				short num = (short)1875896499;
				short num2 = num;
				num = (short)493021363;
				switch (num2 == num)
				{
				}
				num = (short)769589249;
				if (num != 0)
				{
				}
				num = (short)243990528;
				short num3 = num;
				num = (short)670302208;
				if (num != 0)
				{
				}
				return this.cnvPerManDownEnable_42038.HiddenDynamic;
			}
			set
			{
				short num = (short)1540466895;
				short num2 = num;
				num = (short)383822031;
				switch (num2 == num)
				{
				}
				num = (short)1101660161;
				if (num != 0)
				{
				}
				num = (short)1642594304;
				short num3 = num;
				num = (short)98369536;
				if (num != 0)
				{
				}
				this.cnvPerManDownEnable_42038.HiddenDynamic = value;
			}
		}

		// Token: 0x17004E9F RID: 20127
		// (get) Token: 0x06009C96 RID: 40086 RVA: 0x009277B8 File Offset: 0x009259B8
		public bool CnvPerManDownEnable_42038_HasDiffs
		{
			get
			{
				short num = (short)87022696;
				short num2 = num;
				num = (short)4119656;
				switch (num2 == num)
				{
				}
				num = (short)1762787329;
				if (num != 0)
				{
				}
				num = (short)1323958272;
				short num3 = num;
				num = (short)1468006400;
				if (num != 0)
				{
				}
				return this.cnvPerManDownEnable_42038._HasDiffs;
			}
		}

		// Token: 0x17004EA0 RID: 20128
		// (get) Token: 0x06009C97 RID: 40087 RVA: 0x00927870 File Offset: 0x00925A70
		// (set) Token: 0x06009C98 RID: 40088 RVA: 0x00927924 File Offset: 0x00925B24
		public int CnvEmerProfEmergencyHotAuxMic_A42296Value
		{
			get
			{
				short num = (short)327098704;
				short num2 = num;
				num = (short)1845895504;
				switch (num2 == num)
				{
				}
				num = (short)999489537;
				if (num != 0)
				{
				}
				num = (short)415825920;
				short num3 = num;
				num = (short)937295872;
				if (num != 0)
				{
				}
				return this.cnvEmerProfEmergencyHotAuxMic_A42296.Value;
			}
			set
			{
				short num = (short)1050503717;
				short num2 = num;
				num = (short)1852926501;
				switch (num2 == num)
				{
				}
				num = (short)895025153;
				if (num != 0)
				{
				}
				num = (short)1280770048;
				short num3 = num;
				num = (short)1563426816;
				if (num != 0)
				{
				}
				this.cnvEmerProfEmergencyHotAuxMic_A42296.Value = value;
			}
		}

		// Token: 0x17004EA1 RID: 20129
		// (get) Token: 0x06009C99 RID: 40089 RVA: 0x009279D8 File Offset: 0x00925BD8
		// (set) Token: 0x06009C9A RID: 40090 RVA: 0x00927A8C File Offset: 0x00925C8C
		public string CnvEmerProfEmergencyHotAuxMic_A42296_UIValue
		{
			get
			{
				short num = (short)1144095795;
				short num2 = num;
				num = (short)1370457139;
				switch (num2 == num)
				{
				}
				num = (short)1139539969;
				if (num != 0)
				{
				}
				num = (short)544800768;
				short num3 = num;
				num = (short)2142371840;
				if (num != 0)
				{
				}
				return this.cnvEmerProfEmergencyHotAuxMic_A42296.UIValue;
			}
			set
			{
				short num = (short)957212019;
				short num2 = num;
				num = (short)1941759347;
				switch (num2 == num)
				{
				}
				num = (short)2026045440;
				if (num != 0)
				{
				}
				num = (short)1966211072;
				short num3 = num;
				num = (short)957087745;
				if (num != 0)
				{
				}
				this.cnvEmerProfEmergencyHotAuxMic_A42296.UIValue = value;
			}
		}

		// Token: 0x17004EA2 RID: 20130
		// (get) Token: 0x06009C9B RID: 40091 RVA: 0x00927B40 File Offset: 0x00925D40
		public global::AcpBusinessLayer.AcpListField CnvEmerProfEmergencyHotAuxMic_A42296
		{
			get
			{
				short num = (short)1496224103;
				short num2 = num;
				num = (short)280990055;
				switch (num2 == num)
				{
				}
				num = (short)974454784;
				if (num != 0)
				{
				}
				num = (short)1745551360;
				short num3 = num;
				num = (short)1311637505;
				if (num != 0)
				{
				}
				return this.cnvEmerProfEmergencyHotAuxMic_A42296;
			}
		}

		// Token: 0x17004EA3 RID: 20131
		// (get) Token: 0x06009C9C RID: 40092 RVA: 0x00927BF0 File Offset: 0x00925DF0
		// (set) Token: 0x06009C9D RID: 40093 RVA: 0x00927CA8 File Offset: 0x00925EA8
		public bool CnvEmerProfEmergencyHotAuxMic_A42296_Applicable
		{
			get
			{
				short num = (short)1547695211;
				short num2 = num;
				num = (short)117372011;
				switch (num2 == num)
				{
				}
				num = (short)1137967105;
				if (num != 0)
				{
				}
				num = (short)344588288;
				short num3 = num;
				num = (short)2065694720;
				if (num != 0)
				{
				}
				return this.cnvEmerProfEmergencyHotAuxMic_A42296.Applicable;
			}
			set
			{
				short num = (short)73256212;
				short num2 = num;
				num = (short)596364564;
				switch (num2 == num)
				{
				}
				num = (short)308412417;
				if (num != 0)
				{
				}
				num = (short)1904410624;
				short num3 = num;
				num = (short)1022296064;
				if (num != 0)
				{
				}
				this.cnvEmerProfEmergencyHotAuxMic_A42296.Applicable = value;
			}
		}

		// Token: 0x17004EA4 RID: 20132
		// (get) Token: 0x06009C9E RID: 40094 RVA: 0x00927D60 File Offset: 0x00925F60
		// (set) Token: 0x06009C9F RID: 40095 RVA: 0x00927E14 File Offset: 0x00926014
		public bool CnvEmerProfEmergencyHotAuxMic_A42296_Valid
		{
			get
			{
				short num = (short)70777721;
				short num2 = num;
				num = (short)152238969;
				switch (num2 == num)
				{
				}
				num = (short)1159528449;
				if (num != 0)
				{
				}
				num = (short)407371776;
				short num3 = num;
				num = (short)779681792;
				if (num != 0)
				{
				}
				return this.cnvEmerProfEmergencyHotAuxMic_A42296.Valid;
			}
			set
			{
				short num = (short)357730747;
				short num2 = num;
				num = (short)2134542779;
				switch (num2 == num)
				{
				}
				num = (short)1801912321;
				if (num != 0)
				{
				}
				num = (short)528613376;
				short num3 = num;
				num = (short)1554055168;
				if (num != 0)
				{
				}
				this.cnvEmerProfEmergencyHotAuxMic_A42296.Valid = value;
			}
		}

		// Token: 0x17004EA5 RID: 20133
		// (get) Token: 0x06009CA0 RID: 40096 RVA: 0x00927ECC File Offset: 0x009260CC
		// (set) Token: 0x06009CA1 RID: 40097 RVA: 0x00927F80 File Offset: 0x00926180
		public bool CnvEmerProfEmergencyHotAuxMic_A42296_Visible
		{
			get
			{
				short num = (short)663578833;
				short num2 = num;
				num = (short)1051224273;
				switch (num2 == num)
				{
				}
				num = (short)1056505857;
				if (num != 0)
				{
				}
				num = (short)1846083584;
				short num3 = num;
				num = (short)120651776;
				if (num != 0)
				{
				}
				return this.cnvEmerProfEmergencyHotAuxMic_A42296.Visible;
			}
			set
			{
				short num = (short)1077483766;
				short num2 = num;
				num = (short)984291574;
				switch (num2 == num)
				{
				}
				num = (short)602800129;
				if (num != 0)
				{
				}
				num = (short)1120206848;
				short num3 = num;
				num = (short)346882048;
				if (num != 0)
				{
				}
				this.cnvEmerProfEmergencyHotAuxMic_A42296.Visible = value;
			}
		}

		// Token: 0x17004EA6 RID: 20134
		// (get) Token: 0x06009CA2 RID: 40098 RVA: 0x00928034 File Offset: 0x00926234
		// (set) Token: 0x06009CA3 RID: 40099 RVA: 0x009280E8 File Offset: 0x009262E8
		public bool CnvEmerProfEmergencyHotAuxMic_A42296_Editable
		{
			get
			{
				short num = (short)1272772826;
				short num2 = num;
				num = (short)1760164058;
				switch (num2 == num)
				{
				}
				num = (short)1804664833;
				if (num != 0)
				{
				}
				num = (short)1380909056;
				short num3 = num;
				num = (short)1467613184;
				if (num != 0)
				{
				}
				return this.cnvEmerProfEmergencyHotAuxMic_A42296.Editable;
			}
			set
			{
				short num = (short)675814923;
				short num2 = num;
				num = (short)1628511755;
				switch (num2 == num)
				{
				}
				num = (short)1060241409;
				if (num != 0)
				{
				}
				num = (short)1082982400;
				short num3 = num;
				num = (short)1087766528;
				if (num != 0)
				{
				}
				this.cnvEmerProfEmergencyHotAuxMic_A42296.Editable = value;
			}
		}

		// Token: 0x17004EA7 RID: 20135
		// (get) Token: 0x06009CA4 RID: 40100 RVA: 0x0092819C File Offset: 0x0092639C
		internal string CnvEmerProfEmergencyHotAuxMic_A42296_UILabel
		{
			get
			{
				short num = (short)1165205383;
				short num2 = num;
				num = (short)1607180167;
				switch (num2 == num)
				{
				}
				num = (short)1627914240;
				if (num != 0)
				{
				}
				num = (short)919601152;
				short num3 = num;
				num = (short)213909505;
				if (num != 0)
				{
				}
				return this.cnvEmerProfEmergencyHotAuxMic_A42296.UIName;
			}
		}

		// Token: 0x17004EA8 RID: 20136
		// (get) Token: 0x06009CA5 RID: 40101 RVA: 0x00928250 File Offset: 0x00926450
		// (set) Token: 0x06009CA6 RID: 40102 RVA: 0x00928304 File Offset: 0x00926504
		internal bool CnvEmerProfEmergencyHotAuxMic_A42296_HiddenStatic
		{
			get
			{
				short num = (short)1131642982;
				short num2 = num;
				num = (short)1091272806;
				switch (num2 == num)
				{
				}
				num = (short)1338376193;
				if (num != 0)
				{
				}
				num = (short)1974861824;
				short num3 = num;
				num = (short)2103705600;
				if (num != 0)
				{
				}
				return this.cnvEmerProfEmergencyHotAuxMic_A42296.HiddenStatic;
			}
			set
			{
				short num = (short)1928227689;
				short num2 = num;
				num = (short)876702569;
				switch (num2 == num)
				{
				}
				num = (short)932773888;
				if (num != 0)
				{
				}
				num = (short)901775360;
				short num3 = num;
				num = (short)1940193281;
				if (num != 0)
				{
				}
				this.cnvEmerProfEmergencyHotAuxMic_A42296.HiddenStatic = value;
			}
		}

		// Token: 0x17004EA9 RID: 20137
		// (get) Token: 0x06009CA7 RID: 40103 RVA: 0x009283B8 File Offset: 0x009265B8
		// (set) Token: 0x06009CA8 RID: 40104 RVA: 0x0092846C File Offset: 0x0092666C
		internal bool CnvEmerProfEmergencyHotAuxMic_A42296_HiddenDynamic
		{
			get
			{
				short num = (short)963463653;
				short num2 = num;
				num = (short)1716079077;
				switch (num2 == num)
				{
				}
				num = (short)563871745;
				if (num != 0)
				{
				}
				num = (short)1271463936;
				short num3 = num;
				num = (short)1237909504;
				if (num != 0)
				{
				}
				return this.cnvEmerProfEmergencyHotAuxMic_A42296.HiddenDynamic;
			}
			set
			{
				short num = (short)985957724;
				short num2 = num;
				num = (short)349341020;
				switch (num2 == num)
				{
				}
				num = (short)1736441857;
				if (num != 0)
				{
				}
				num = (short)727318528;
				short num3 = num;
				num = (short)1726742528;
				if (num != 0)
				{
				}
				this.cnvEmerProfEmergencyHotAuxMic_A42296.HiddenDynamic = value;
			}
		}

		// Token: 0x17004EAA RID: 20138
		// (get) Token: 0x06009CA9 RID: 40105 RVA: 0x00928524 File Offset: 0x00926724
		public bool CnvEmerProfEmergencyHotAuxMic_A42296_HasDiffs
		{
			get
			{
				short num = (short)1223264857;
				short num2 = num;
				num = (short)1369737817;
				switch (num2 == num)
				{
				}
				num = (short)654704641;
				if (num != 0)
				{
				}
				num = (short)711655424;
				short num3 = num;
				num = (short)58195968;
				if (num != 0)
				{
				}
				return this.cnvEmerProfEmergencyHotAuxMic_A42296._HasDiffs;
			}
		}

		// Token: 0x17004EAB RID: 20139
		// (get) Token: 0x06009CAA RID: 40106 RVA: 0x009285DC File Offset: 0x009267DC
		// (set) Token: 0x06009CAB RID: 40107 RVA: 0x00928690 File Offset: 0x00926890
		public bool CnvPerEMGFindMeTxEnable_42920Value
		{
			get
			{
				short num = (short)156166373;
				short num2 = num;
				num = (short)1775364325;
				switch (num2 == num)
				{
				}
				num = (short)453705729;
				if (num != 0)
				{
				}
				num = (short)623181824;
				short num3 = num;
				num = (short)791150592;
				if (num != 0)
				{
				}
				return this.cnvPerEMGFindMeTxEnable_42920.Value;
			}
			set
			{
				short num = (short)2019212852;
				short num2 = num;
				num = (short)68664884;
				switch (num2 == num)
				{
				}
				num = (short)698744833;
				if (num != 0)
				{
				}
				num = (short)1919614976;
				short num3 = num;
				num = (short)1362821120;
				if (num != 0)
				{
				}
				this.cnvPerEMGFindMeTxEnable_42920.Value = value;
			}
		}

		// Token: 0x17004EAC RID: 20140
		// (get) Token: 0x06009CAC RID: 40108 RVA: 0x00928748 File Offset: 0x00926948
		public global::AcpBusinessLayer.AcpField<bool> CnvPerEMGFindMeTxEnable_42920
		{
			get
			{
				short num = (short)1537225185;
				short num2 = num;
				num = (short)935277025;
				switch (num2 == num)
				{
				}
				num = (short)607649793;
				if (num != 0)
				{
				}
				num = (short)60882944;
				short num3 = num;
				num = (short)651165696;
				if (num != 0)
				{
				}
				return this.cnvPerEMGFindMeTxEnable_42920;
			}
		}

		// Token: 0x17004EAD RID: 20141
		// (get) Token: 0x06009CAD RID: 40109 RVA: 0x009287F8 File Offset: 0x009269F8
		// (set) Token: 0x06009CAE RID: 40110 RVA: 0x009288AC File Offset: 0x00926AAC
		public bool CnvPerEMGFindMeTxEnable_42920_UIValue
		{
			get
			{
				short num = (short)386203649;
				if (num != 0)
				{
				}
				num = (short)202229632;
				short num2 = num;
				num = (short)1720633216;
				switch (num2 == num)
				{
				}
				num = (short)1880948736;
				short num3 = num;
				num = (short)1598095360;
				if (num != 0)
				{
				}
				return this.cnvPerEMGFindMeTxEnable_42920.Value;
			}
			set
			{
				short num = (short)1176171704;
				short num2 = num;
				num = (short)1927738552;
				switch (num2 == num)
				{
				}
				num = (short)82771969;
				if (num != 0)
				{
				}
				num = (short)1813970944;
				short num3 = num;
				num = (short)1793064960;
				if (num != 0)
				{
				}
				this.cnvPerEMGFindMeTxEnable_42920.Value = value;
			}
		}

		// Token: 0x17004EAE RID: 20142
		// (get) Token: 0x06009CAF RID: 40111 RVA: 0x00928960 File Offset: 0x00926B60
		// (set) Token: 0x06009CB0 RID: 40112 RVA: 0x00928A14 File Offset: 0x00926C14
		public bool CnvPerEMGFindMeTxEnable_42920_Applicable
		{
			get
			{
				short num = (short)1614053944;
				short num2 = num;
				num = (short)356680248;
				switch (num2 == num)
				{
				}
				num = (short)1720057856;
				if (num != 0)
				{
				}
				num = (short)2048196608;
				short num3 = num;
				num = (short)1917976577;
				if (num != 0)
				{
				}
				return this.cnvPerEMGFindMeTxEnable_42920.Applicable;
			}
			set
			{
				short num = (short)2037876857;
				short num2 = num;
				num = (short)71796857;
				switch (num2 == num)
				{
				}
				num = (short)229965824;
				if (num != 0)
				{
				}
				num = (short)843186176;
				short num3 = num;
				num = (short)1342570497;
				if (num != 0)
				{
				}
				this.cnvPerEMGFindMeTxEnable_42920.Applicable = value;
			}
		}

		// Token: 0x17004EAF RID: 20143
		// (get) Token: 0x06009CB1 RID: 40113 RVA: 0x00928AC8 File Offset: 0x00926CC8
		// (set) Token: 0x06009CB2 RID: 40114 RVA: 0x00928B80 File Offset: 0x00926D80
		public bool CnvPerEMGFindMeTxEnable_42920_Valid
		{
			get
			{
				short num = (short)613659602;
				short num2 = num;
				num = (short)999273426;
				switch (num2 == num)
				{
				}
				num = (short)2081292288;
				if (num != 0)
				{
				}
				num = (short)572850176;
				short num3 = num;
				num = (short)2063532033;
				if (num != 0)
				{
				}
				return this.cnvPerEMGFindMeTxEnable_42920.Valid;
			}
			set
			{
				short num = (short)419627072;
				short num2 = num;
				num = (short)772407360;
				switch (num2 == num)
				{
				}
				num = (short)1576075264;
				if (num != 0)
				{
				}
				num = (short)843055104;
				short num3 = num;
				num = (short)1052573697;
				if (num != 0)
				{
				}
				this.cnvPerEMGFindMeTxEnable_42920.Valid = value;
			}
		}

		// Token: 0x17004EB0 RID: 20144
		// (get) Token: 0x06009CB3 RID: 40115 RVA: 0x00928C34 File Offset: 0x00926E34
		// (set) Token: 0x06009CB4 RID: 40116 RVA: 0x00928CE8 File Offset: 0x00926EE8
		public bool CnvPerEMGFindMeTxEnable_42920_Visible
		{
			get
			{
				short num = (short)860094893;
				short num2 = num;
				num = (short)664338861;
				switch (num2 == num)
				{
				}
				num = (short)2078670849;
				if (num != 0)
				{
				}
				num = (short)1452408832;
				short num3 = num;
				num = (short)1033568256;
				if (num != 0)
				{
				}
				return this.cnvPerEMGFindMeTxEnable_42920.Visible;
			}
			set
			{
				short num = (short)194623311;
				short num2 = num;
				num = (short)1902884687;
				switch (num2 == num)
				{
				}
				num = (short)1283129345;
				if (num != 0)
				{
				}
				num = (short)1935015936;
				short num3 = num;
				num = (short)555679744;
				if (num != 0)
				{
				}
				this.cnvPerEMGFindMeTxEnable_42920.Visible = value;
			}
		}

		// Token: 0x17004EB1 RID: 20145
		// (get) Token: 0x06009CB5 RID: 40117 RVA: 0x00928DA0 File Offset: 0x00926FA0
		// (set) Token: 0x06009CB6 RID: 40118 RVA: 0x00928E54 File Offset: 0x00927054
		public bool CnvPerEMGFindMeTxEnable_42920_Editable
		{
			get
			{
				short num = (short)1041130993;
				short num2 = num;
				num = (short)389113329;
				switch (num2 == num)
				{
				}
				num = (short)2098593793;
				if (num != 0)
				{
				}
				num = (short)1710424064;
				short num3 = num;
				num = (short)442236928;
				if (num != 0)
				{
				}
				return this.cnvPerEMGFindMeTxEnable_42920.Editable;
			}
			set
			{
				short num = (short)72876033;
				if (num != 0)
				{
				}
				num = (short)1243249877;
				short num2 = num;
				num = (short)131235029;
				switch (num2 == num)
				{
				}
				num = (short)2083717120;
				short num3 = num;
				num = (short)1221525504;
				if (num != 0)
				{
				}
				this.cnvPerEMGFindMeTxEnable_42920.Editable = value;
			}
		}

		// Token: 0x17004EB2 RID: 20146
		// (get) Token: 0x06009CB7 RID: 40119 RVA: 0x00928F0C File Offset: 0x0092710C
		internal string CnvPerEMGFindMeTxEnable_42920_UILabel
		{
			get
			{
				short num = (short)364298540;
				short num2 = num;
				num = (short)507887916;
				switch (num2 == num)
				{
				}
				num = (short)879230977;
				if (num != 0)
				{
				}
				num = (short)1766391808;
				short num3 = num;
				num = (short)1645805568;
				if (num != 0)
				{
				}
				return this.cnvPerEMGFindMeTxEnable_42920.UIName;
			}
		}

		// Token: 0x17004EB3 RID: 20147
		// (get) Token: 0x06009CB8 RID: 40120 RVA: 0x00928FC4 File Offset: 0x009271C4
		// (set) Token: 0x06009CB9 RID: 40121 RVA: 0x00929078 File Offset: 0x00927278
		internal bool CnvPerEMGFindMeTxEnable_42920_HiddenStatic
		{
			get
			{
				short num = (short)1629683713;
				if (num != 0)
				{
				}
				num = (short)674033919;
				short num2 = num;
				num = (short)1794109695;
				switch (num2 == num)
				{
				}
				num = (short)1258487808;
				short num3 = num;
				num = (short)27131904;
				if (num != 0)
				{
				}
				return this.cnvPerEMGFindMeTxEnable_42920.HiddenStatic;
			}
			set
			{
				short num = (short)406061057;
				if (num != 0)
				{
				}
				num = (short)2029232281;
				short num2 = num;
				num = (short)1585225881;
				switch (num2 == num)
				{
				}
				num = (short)1346699264;
				short num3 = num;
				num = (short)1630994432;
				if (num != 0)
				{
				}
				this.cnvPerEMGFindMeTxEnable_42920.HiddenStatic = value;
			}
		}

		// Token: 0x17004EB4 RID: 20148
		// (get) Token: 0x06009CBA RID: 40122 RVA: 0x00929130 File Offset: 0x00927330
		// (set) Token: 0x06009CBB RID: 40123 RVA: 0x009291E4 File Offset: 0x009273E4
		internal bool CnvPerEMGFindMeTxEnable_42920_HiddenDynamic
		{
			get
			{
				short num = (short)2125922305;
				if (num != 0)
				{
				}
				num = (short)321051331;
				short num2 = num;
				num = (short)871750339;
				switch (num2 == num)
				{
				}
				num = (short)1536950272;
				short num3 = num;
				num = (short)930283520;
				if (num != 0)
				{
				}
				return this.cnvPerEMGFindMeTxEnable_42920.HiddenDynamic;
			}
			set
			{
				short num = (short)1986135012;
				short num2 = num;
				num = (short)935592932;
				switch (num2 == num)
				{
				}
				num = (short)2013331457;
				if (num != 0)
				{
				}
				num = (short)1113063424;
				short num3 = num;
				num = (short)1850408960;
				if (num != 0)
				{
				}
				this.cnvPerEMGFindMeTxEnable_42920.HiddenDynamic = value;
			}
		}

		// Token: 0x17004EB5 RID: 20149
		// (get) Token: 0x06009CBC RID: 40124 RVA: 0x00929298 File Offset: 0x00927498
		public bool CnvPerEMGFindMeTxEnable_42920_HasDiffs
		{
			get
			{
				short num = (short)801560994;
				short num2 = num;
				num = (short)1910233506;
				switch (num2 == num)
				{
				}
				num = (short)345243649;
				if (num != 0)
				{
				}
				num = (short)1108869120;
				short num3 = num;
				num = (short)1065418752;
				if (num != 0)
				{
				}
				return this.cnvPerEMGFindMeTxEnable_42920._HasDiffs;
			}
		}

		// Token: 0x17004EB6 RID: 20150
		// (get) Token: 0x06009CBD RID: 40125 RVA: 0x0092934C File Offset: 0x0092754C
		// (set) Token: 0x06009CBE RID: 40126 RVA: 0x00929400 File Offset: 0x00927600
		public bool CnvPerEMGFindMeRxEnable_42922Value
		{
			get
			{
				short num = (short)230859429;
				short num2 = num;
				num = (short)1158718117;
				switch (num2 == num)
				{
				}
				num = (short)661192704;
				if (num != 0)
				{
				}
				num = (short)1784741888;
				short num3 = num;
				num = (short)2035744769;
				if (num != 0)
				{
				}
				return this.cnvPerEMGFindMeRxEnable_42922.Value;
			}
			set
			{
				short num = (short)2021720065;
				if (num != 0)
				{
				}
				num = (short)1305655666;
				short num2 = num;
				num = (short)417708402;
				switch (num2 == num)
				{
				}
				num = (short)407764992;
				short num3 = num;
				num = (short)1994260480;
				if (num != 0)
				{
				}
				this.cnvPerEMGFindMeRxEnable_42922.Value = value;
			}
		}

		// Token: 0x17004EB7 RID: 20151
		// (get) Token: 0x06009CBF RID: 40127 RVA: 0x009294B8 File Offset: 0x009276B8
		public global::AcpBusinessLayer.AcpField<bool> CnvPerEMGFindMeRxEnable_42922
		{
			get
			{
				short num = (short)1727094720;
				short num2 = num;
				num = (short)693854144;
				switch (num2 == num)
				{
				}
				num = (short)174456832;
				short num3 = num;
				num = (short)523632641;
				if (num != 0)
				{
				}
				num = (short)1778843648;
				if (num != 0)
				{
				}
				return this.cnvPerEMGFindMeRxEnable_42922;
			}
		}

		// Token: 0x17004EB8 RID: 20152
		// (get) Token: 0x06009CC0 RID: 40128 RVA: 0x0092956C File Offset: 0x0092776C
		// (set) Token: 0x06009CC1 RID: 40129 RVA: 0x00929620 File Offset: 0x00927820
		public bool CnvPerEMGFindMeRxEnable_42922_UIValue
		{
			get
			{
				short num = (short)388527742;
				short num2 = num;
				num = (short)1864857214;
				switch (num2 == num)
				{
				}
				num = (short)266731520;
				short num3 = num;
				num = (short)1902247937;
				if (num != 0)
				{
				}
				num = (short)1590886400;
				if (num != 0)
				{
				}
				return this.cnvPerEMGFindMeRxEnable_42922.Value;
			}
			set
			{
				short num = (short)397934593;
				if (num != 0)
				{
				}
				num = (short)290109619;
				short num2 = num;
				num = (short)44939443;
				switch (num2 == num)
				{
				default:
				{
					num = (short)759496704;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1825112064;
				if (num != 0)
				{
				}
				this.cnvPerEMGFindMeRxEnable_42922.Value = value;
			}
		}

		// Token: 0x17004EB9 RID: 20153
		// (get) Token: 0x06009CC2 RID: 40130 RVA: 0x009296D8 File Offset: 0x009278D8
		// (set) Token: 0x06009CC3 RID: 40131 RVA: 0x0092978C File Offset: 0x0092798C
		public bool CnvPerEMGFindMeRxEnable_42922_Applicable
		{
			get
			{
				short num = (short)546907501;
				short num2 = num;
				num = (short)2001413485;
				switch (num2 == num)
				{
				}
				num = (short)546177024;
				short num3 = num;
				num = (short)98697216;
				if (num != 0)
				{
				}
				num = (short)717553665;
				if (num != 0)
				{
				}
				return this.cnvPerEMGFindMeRxEnable_42922.Applicable;
			}
			set
			{
				short num = (short)1863840068;
				short num2 = num;
				num = (short)1789653316;
				switch (num2 == num)
				{
				}
				num = (short)941031424;
				short num3 = num;
				num = (short)1001455616;
				if (num != 0)
				{
				}
				num = (short)408551425;
				if (num != 0)
				{
				}
				this.cnvPerEMGFindMeRxEnable_42922.Applicable = value;
			}
		}

		// Token: 0x17004EBA RID: 20154
		// (get) Token: 0x06009CC4 RID: 40132 RVA: 0x00929840 File Offset: 0x00927A40
		// (set) Token: 0x06009CC5 RID: 40133 RVA: 0x009298F4 File Offset: 0x00927AF4
		public bool CnvPerEMGFindMeRxEnable_42922_Valid
		{
			get
			{
				short num = (short)646147021;
				short num2 = num;
				num = (short)122252237;
				switch (num2 == num)
				{
				}
				num = (short)260243456;
				short num3 = num;
				num = (short)1524563969;
				if (num != 0)
				{
				}
				num = (short)712704000;
				if (num != 0)
				{
				}
				return this.cnvPerEMGFindMeRxEnable_42922.Valid;
			}
			set
			{
				short num = (short)902995367;
				short num2 = num;
				num = (short)2146082215;
				switch (num2 == num)
				{
				}
				num = (short)404422656;
				short num3 = num;
				num = (short)255262721;
				if (num != 0)
				{
				}
				num = (short)208535552;
				if (num != 0)
				{
				}
				this.cnvPerEMGFindMeRxEnable_42922.Valid = value;
			}
		}

		// Token: 0x17004EBB RID: 20155
		// (get) Token: 0x06009CC6 RID: 40134 RVA: 0x009299AC File Offset: 0x00927BAC
		// (set) Token: 0x06009CC7 RID: 40135 RVA: 0x00929A60 File Offset: 0x00927C60
		public bool CnvPerEMGFindMeRxEnable_42922_Visible
		{
			get
			{
				short num = (short)307264140;
				short num2 = num;
				num = (short)333347468;
				switch (num2 == num)
				{
				}
				num = (short)1625489408;
				short num3 = num;
				num = (short)1363542017;
				if (num != 0)
				{
				}
				num = (short)1178402816;
				if (num != 0)
				{
				}
				return this.cnvPerEMGFindMeRxEnable_42922.Visible;
			}
			set
			{
				short num = (short)224376856;
				short num2 = num;
				num = (short)4438040;
				switch (num2 == num)
				{
				}
				num = (short)512229376;
				short num3 = num;
				num = (short)910622720;
				if (num != 0)
				{
				}
				num = (short)745144321;
				if (num != 0)
				{
				}
				this.cnvPerEMGFindMeRxEnable_42922.Visible = value;
			}
		}

		// Token: 0x17004EBC RID: 20156
		// (get) Token: 0x06009CC8 RID: 40136 RVA: 0x00929B10 File Offset: 0x00927D10
		// (set) Token: 0x06009CC9 RID: 40137 RVA: 0x00929BC4 File Offset: 0x00927DC4
		public bool CnvPerEMGFindMeRxEnable_42922_Editable
		{
			get
			{
				short num = (short)749417108;
				short num2 = num;
				num = (short)593965716;
				switch (num2 == num)
				{
				}
				num = (short)1868824576;
				short num3 = num;
				num = (short)1586102272;
				if (num != 0)
				{
				}
				num = (short)350355457;
				if (num != 0)
				{
				}
				return this.cnvPerEMGFindMeRxEnable_42922.Editable;
			}
			set
			{
				short num = (short)1289930897;
				short num2 = num;
				num = (short)726255761;
				switch (num2 == num)
				{
				}
				num = (short)110231552;
				short num3 = num;
				num = (short)138084353;
				if (num != 0)
				{
				}
				num = (short)1635319808;
				if (num != 0)
				{
				}
				this.cnvPerEMGFindMeRxEnable_42922.Editable = value;
			}
		}

		// Token: 0x17004EBD RID: 20157
		// (get) Token: 0x06009CCA RID: 40138 RVA: 0x00929C78 File Offset: 0x00927E78
		internal string CnvPerEMGFindMeRxEnable_42922_UILabel
		{
			get
			{
				short num = (short)1831644667;
				short num2 = num;
				num = (short)25079291;
				switch (num2 == num)
				{
				}
				num = (short)221642752;
				short num3 = num;
				num = (short)1462173697;
				if (num != 0)
				{
				}
				num = (short)1491730432;
				if (num != 0)
				{
				}
				return this.cnvPerEMGFindMeRxEnable_42922.UIName;
			}
		}

		// Token: 0x17004EBE RID: 20158
		// (get) Token: 0x06009CCB RID: 40139 RVA: 0x00929D30 File Offset: 0x00927F30
		// (set) Token: 0x06009CCC RID: 40140 RVA: 0x00929DE4 File Offset: 0x00927FE4
		internal bool CnvPerEMGFindMeRxEnable_42922_HiddenStatic
		{
			get
			{
				short num = (short)1587240538;
				short num2 = num;
				num = (short)100294234;
				switch (num2 == num)
				{
				}
				num = (short)595918848;
				short num3 = num;
				num = (short)1449197568;
				if (num != 0)
				{
				}
				num = (short)1169686529;
				if (num != 0)
				{
				}
				return this.cnvPerEMGFindMeRxEnable_42922.HiddenStatic;
			}
			set
			{
				short num = (short)1553645545;
				short num2 = num;
				num = (short)296337385;
				switch (num2 == num)
				{
				}
				num = (short)2025783296;
				short num3 = num;
				num = (short)1870790657;
				if (num != 0)
				{
				}
				num = (short)981794816;
				if (num != 0)
				{
				}
				this.cnvPerEMGFindMeRxEnable_42922.HiddenStatic = value;
			}
		}

		// Token: 0x17004EBF RID: 20159
		// (get) Token: 0x06009CCD RID: 40141 RVA: 0x00929E9C File Offset: 0x0092809C
		// (set) Token: 0x06009CCE RID: 40142 RVA: 0x00929F4C File Offset: 0x0092814C
		internal bool CnvPerEMGFindMeRxEnable_42922_HiddenDynamic
		{
			get
			{
				short num = (short)606011393;
				if (num != 0)
				{
				}
				num = (short)1301618228;
				short num2 = num;
				num = (short)1554128436;
				switch (num2 == num)
				{
				default:
				{
					num = (short)491388928;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)119537664;
				if (num != 0)
				{
				}
				return this.cnvPerEMGFindMeRxEnable_42922.HiddenDynamic;
			}
			set
			{
				short num = (short)1604911105;
				if (num != 0)
				{
				}
				num = (short)433975150;
				short num2 = num;
				num = (short)504098670;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1497628672;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1659568128;
				if (num != 0)
				{
				}
				this.cnvPerEMGFindMeRxEnable_42922.HiddenDynamic = value;
			}
		}

		// Token: 0x17004EC0 RID: 20160
		// (get) Token: 0x06009CCF RID: 40143 RVA: 0x0092A004 File Offset: 0x00928204
		public bool CnvPerEMGFindMeRxEnable_42922_HasDiffs
		{
			get
			{
				short num = (short)1179034277;
				short num2 = num;
				num = (short)516989605;
				switch (num2 == num)
				{
				}
				num = (short)1400111104;
				short num3 = num;
				num = (short)466878465;
				if (num != 0)
				{
				}
				num = (short)1086783488;
				if (num != 0)
				{
				}
				return this.cnvPerEMGFindMeRxEnable_42922._HasDiffs;
			}
		}

		// Token: 0x17004EC1 RID: 20161
		// (get) Token: 0x06009CD0 RID: 40144 RVA: 0x0092A0BC File Offset: 0x009282BC
		// (set) Token: 0x06009CD1 RID: 40145 RVA: 0x0092A170 File Offset: 0x00928370
		public bool CnvEmerProfImpactDetectionEn_A43391Value
		{
			get
			{
				short num = (short)1011715962;
				short num2 = num;
				num = (short)398167930;
				switch (num2 == num)
				{
				}
				num = (short)1441398784;
				short num3 = num;
				num = (short)1457782785;
				if (num != 0)
				{
				}
				num = (short)1909653504;
				if (num != 0)
				{
				}
				return this.cnvEmerProfImpactDetectionEn_A43391.Value;
			}
			set
			{
				short num = (short)1080189754;
				short num2 = num;
				num = (short)1855808314;
				switch (num2 == num)
				{
				}
				num = (short)1793392640;
				short num3 = num;
				num = (short)77135872;
				if (num != 0)
				{
				}
				num = (short)505741313;
				if (num != 0)
				{
				}
				this.cnvEmerProfImpactDetectionEn_A43391.Value = value;
			}
		}

		// Token: 0x17004EC2 RID: 20162
		// (get) Token: 0x06009CD2 RID: 40146 RVA: 0x0092A224 File Offset: 0x00928424
		public global::AcpBusinessLayer.AcpField<bool> CnvEmerProfImpactDetectionEn_A43391
		{
			get
			{
				short num = (short)2031028462;
				short num2 = num;
				num = (short)768346350;
				switch (num2 == num)
				{
				}
				num = (short)1585446912;
				short num3 = num;
				num = (short)1734606848;
				if (num != 0)
				{
				}
				num = (short)1742012417;
				if (num != 0)
				{
				}
				return this.cnvEmerProfImpactDetectionEn_A43391;
			}
		}

		// Token: 0x17004EC3 RID: 20163
		// (get) Token: 0x06009CD3 RID: 40147 RVA: 0x0092A2D4 File Offset: 0x009284D4
		// (set) Token: 0x06009CD4 RID: 40148 RVA: 0x0092A388 File Offset: 0x00928588
		public bool CnvEmerProfImpactDetectionEn_A43391_UIValue
		{
			get
			{
				short num = (short)706232472;
				short num2 = num;
				num = (short)1944862872;
				switch (num2 == num)
				{
				}
				num = (short)1583808512;
				short num3 = num;
				num = (short)303300609;
				if (num != 0)
				{
				}
				num = (short)431095808;
				if (num != 0)
				{
				}
				return this.cnvEmerProfImpactDetectionEn_A43391.Value;
			}
			set
			{
				short num = (short)1773849812;
				short num2 = num;
				num = (short)2016726228;
				switch (num2 == num)
				{
				}
				num = (short)1010565120;
				short num3 = num;
				num = (short)1145634817;
				if (num != 0)
				{
				}
				num = (short)775159808;
				if (num != 0)
				{
				}
				this.cnvEmerProfImpactDetectionEn_A43391.Value = value;
			}
		}

		// Token: 0x17004EC4 RID: 20164
		// (get) Token: 0x06009CD5 RID: 40149 RVA: 0x0092A43C File Offset: 0x0092863C
		// (set) Token: 0x06009CD6 RID: 40150 RVA: 0x0092A4F4 File Offset: 0x009286F4
		public bool CnvEmerProfImpactDetectionEn_A43391_Applicable
		{
			get
			{
				short num = (short)208533963;
				short num2 = num;
				num = (short)2085747147;
				switch (num2 == num)
				{
				}
				num = (short)767295488;
				short num3 = num;
				num = (short)1527775233;
				if (num != 0)
				{
				}
				num = (short)726335488;
				if (num != 0)
				{
				}
				return this.cnvEmerProfImpactDetectionEn_A43391.Applicable;
			}
			set
			{
				short num = (short)1202311787;
				short num2 = num;
				num = (short)809882219;
				switch (num2 == num)
				{
				}
				num = (short)647692288;
				short num3 = num;
				num = (short)1138294784;
				if (num != 0)
				{
				}
				num = (short)1837301761;
				if (num != 0)
				{
				}
				this.cnvEmerProfImpactDetectionEn_A43391.Applicable = value;
			}
		}

		// Token: 0x17004EC5 RID: 20165
		// (get) Token: 0x06009CD7 RID: 40151 RVA: 0x0092A5AC File Offset: 0x009287AC
		// (set) Token: 0x06009CD8 RID: 40152 RVA: 0x0092A660 File Offset: 0x00928860
		public bool CnvEmerProfImpactDetectionEn_A43391_Valid
		{
			get
			{
				short num = (short)1278607361;
				if (num != 0)
				{
				}
				num = (short)30147296;
				short num2 = num;
				num = (short)7078624;
				switch (num2 == num)
				{
				default:
				{
					num = (short)399704064;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1967259648;
				if (num != 0)
				{
				}
				return this.cnvEmerProfImpactDetectionEn_A43391.Valid;
			}
			set
			{
				short num = (short)1684380705;
				short num2 = num;
				num = (short)1206557729;
				switch (num2 == num)
				{
				}
				num = (short)179372032;
				short num3 = num;
				num = (short)205586433;
				if (num != 0)
				{
				}
				num = (short)1351680000;
				if (num != 0)
				{
				}
				this.cnvEmerProfImpactDetectionEn_A43391.Valid = value;
			}
		}

		// Token: 0x17004EC6 RID: 20166
		// (get) Token: 0x06009CD9 RID: 40153 RVA: 0x0092A718 File Offset: 0x00928918
		// (set) Token: 0x06009CDA RID: 40154 RVA: 0x0092A7D0 File Offset: 0x009289D0
		public bool CnvEmerProfImpactDetectionEn_A43391_Visible
		{
			get
			{
				short num = (short)445775873;
				if (num != 0)
				{
				}
				num = (short)251213741;
				short num2 = num;
				num = (short)1428043693;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1853161472;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1178009600;
				if (num != 0)
				{
				}
				return this.cnvEmerProfImpactDetectionEn_A43391.Visible;
			}
			set
			{
				short num = (short)758918412;
				short num2 = num;
				num = (short)1275604236;
				switch (num2 == num)
				{
				}
				num = (short)1251016704;
				short num3 = num;
				num = (short)1224474625;
				if (num != 0)
				{
				}
				num = (short)1260257280;
				if (num != 0)
				{
				}
				this.cnvEmerProfImpactDetectionEn_A43391.Visible = value;
			}
		}

		// Token: 0x17004EC7 RID: 20167
		// (get) Token: 0x06009CDB RID: 40155 RVA: 0x0092A888 File Offset: 0x00928A88
		// (set) Token: 0x06009CDC RID: 40156 RVA: 0x0092A93C File Offset: 0x00928B3C
		public bool CnvEmerProfImpactDetectionEn_A43391_Editable
		{
			get
			{
				short num = (short)1369374445;
				short num2 = num;
				num = (short)1978924781;
				switch (num2 == num)
				{
				}
				num = (short)1371209728;
				short num3 = num;
				num = (short)2027421696;
				if (num != 0)
				{
				}
				num = (short)1030029313;
				if (num != 0)
				{
				}
				return this.cnvEmerProfImpactDetectionEn_A43391.Editable;
			}
			set
			{
				short num = (short)1225106850;
				short num2 = num;
				num = (short)1922606498;
				switch (num2 == num)
				{
				}
				num = (short)917241856;
				short num3 = num;
				num = (short)1832845313;
				if (num != 0)
				{
				}
				num = (short)1397620736;
				if (num != 0)
				{
				}
				this.cnvEmerProfImpactDetectionEn_A43391.Editable = value;
			}
		}

		// Token: 0x17004EC8 RID: 20168
		// (get) Token: 0x06009CDD RID: 40157 RVA: 0x0092A9F0 File Offset: 0x00928BF0
		internal string CnvEmerProfImpactDetectionEn_A43391_UILabel
		{
			get
			{
				short num = (short)1548904325;
				short num2 = num;
				num = (short)41510789;
				switch (num2 == num)
				{
				}
				num = (short)904331264;
				short num3 = num;
				num = (short)1540358145;
				if (num != 0)
				{
				}
				num = (short)1145044992;
				if (num != 0)
				{
				}
				return this.cnvEmerProfImpactDetectionEn_A43391.UIName;
			}
		}

		// Token: 0x17004EC9 RID: 20169
		// (get) Token: 0x06009CDE RID: 40158 RVA: 0x0092AAA4 File Offset: 0x00928CA4
		// (set) Token: 0x06009CDF RID: 40159 RVA: 0x0092AB5C File Offset: 0x00928D5C
		internal bool CnvEmerProfImpactDetectionEn_A43391_HiddenStatic
		{
			get
			{
				short num = (short)1183739971;
				short num2 = num;
				num = (short)23294019;
				switch (num2 == num)
				{
				}
				num = (short)760545280;
				short num3 = num;
				num = (short)569245696;
				if (num != 0)
				{
				}
				num = (short)208797697;
				if (num != 0)
				{
				}
				return this.cnvEmerProfImpactDetectionEn_A43391.HiddenStatic;
			}
			set
			{
				short num = (short)311943863;
				short num2 = num;
				num = (short)933356215;
				switch (num2 == num)
				{
				}
				num = (short)1471152128;
				short num3 = num;
				num = (short)1080885248;
				if (num != 0)
				{
				}
				num = (short)1055326209;
				if (num != 0)
				{
				}
				this.cnvEmerProfImpactDetectionEn_A43391.HiddenStatic = value;
			}
		}

		// Token: 0x17004ECA RID: 20170
		// (get) Token: 0x06009CE0 RID: 40160 RVA: 0x0092AC10 File Offset: 0x00928E10
		// (set) Token: 0x06009CE1 RID: 40161 RVA: 0x0092ACC4 File Offset: 0x00928EC4
		internal bool CnvEmerProfImpactDetectionEn_A43391_HiddenDynamic
		{
			get
			{
				short num = (short)1994051815;
				short num2 = num;
				num = (short)654889191;
				switch (num2 == num)
				{
				}
				num = (short)1602617344;
				short num3 = num;
				num = (short)1091960833;
				if (num != 0)
				{
				}
				num = (short)1658191872;
				if (num != 0)
				{
				}
				return this.cnvEmerProfImpactDetectionEn_A43391.HiddenDynamic;
			}
			set
			{
				short num = (short)1983088933;
				short num2 = num;
				num = (short)1570933029;
				switch (num2 == num)
				{
				}
				num = (short)1238564864;
				short num3 = num;
				num = (short)1103167489;
				if (num != 0)
				{
				}
				num = (short)1033043968;
				if (num != 0)
				{
				}
				this.cnvEmerProfImpactDetectionEn_A43391.HiddenDynamic = value;
			}
		}

		// Token: 0x17004ECB RID: 20171
		// (get) Token: 0x06009CE2 RID: 40162 RVA: 0x0092AD78 File Offset: 0x00928F78
		public bool CnvEmerProfImpactDetectionEn_A43391_HasDiffs
		{
			get
			{
				short num = (short)958744501;
				short num2 = num;
				num = (short)606357429;
				switch (num2 == num)
				{
				}
				num = (short)1637613568;
				short num3 = num;
				num = (short)313065472;
				if (num != 0)
				{
				}
				num = (short)2025390081;
				if (num != 0)
				{
				}
				return this.cnvEmerProfImpactDetectionEn_A43391._HasDiffs;
			}
		}

		// Token: 0x17004ECC RID: 20172
		// (get) Token: 0x06009CE3 RID: 40163 RVA: 0x0092AE2C File Offset: 0x0092902C
		// (set) Token: 0x06009CE4 RID: 40164 RVA: 0x0092AEE0 File Offset: 0x009290E0
		public bool EmergencyExitOnChannelChange_43590Value
		{
			get
			{
				short num = (short)913471789;
				short num2 = num;
				num = (short)1570535725;
				switch (num2 == num)
				{
				}
				num = (short)474415104;
				short num3 = num;
				num = (short)1114898433;
				if (num != 0)
				{
				}
				num = (short)1785987072;
				if (num != 0)
				{
				}
				return this.emergencyExitOnChannelChange_43590.Value;
			}
			set
			{
				short num = (short)2023006738;
				short num2 = num;
				num = (short)1502323218;
				switch (num2 == num)
				{
				}
				num = (short)968818688;
				short num3 = num;
				num = (short)393543681;
				if (num != 0)
				{
				}
				num = (short)1668546560;
				if (num != 0)
				{
				}
				this.emergencyExitOnChannelChange_43590.Value = value;
			}
		}

		// Token: 0x17004ECD RID: 20173
		// (get) Token: 0x06009CE5 RID: 40165 RVA: 0x0092AF94 File Offset: 0x00929194
		public global::AcpBusinessLayer.AcpField<bool> EmergencyExitOnChannelChange_43590
		{
			get
			{
				short num = (short)1573913459;
				short num2 = num;
				num = (short)2112881523;
				switch (num2 == num)
				{
				}
				num = (short)325451776;
				short num3 = num;
				num = (short)2086600705;
				if (num != 0)
				{
				}
				num = (short)1103953920;
				if (num != 0)
				{
				}
				return this.emergencyExitOnChannelChange_43590;
			}
		}

		// Token: 0x17004ECE RID: 20174
		// (get) Token: 0x06009CE6 RID: 40166 RVA: 0x0092B040 File Offset: 0x00929240
		// (set) Token: 0x06009CE7 RID: 40167 RVA: 0x0092B0F4 File Offset: 0x009292F4
		public bool EmergencyExitOnChannelChange_43590_UIValue
		{
			get
			{
				short num = (short)1769150059;
				short num2 = num;
				num = (short)1612387947;
				switch (num2 == num)
				{
				}
				num = (short)1715535872;
				short num3 = num;
				num = (short)1857159169;
				if (num != 0)
				{
				}
				num = (short)212729856;
				if (num != 0)
				{
				}
				return this.emergencyExitOnChannelChange_43590.Value;
			}
			set
			{
				short num = (short)962456273;
				short num2 = num;
				num = (short)681634513;
				switch (num2 == num)
				{
				}
				num = (short)1228537856;
				short num3 = num;
				num = (short)1703673857;
				if (num != 0)
				{
				}
				num = (short)689438720;
				if (num != 0)
				{
				}
				this.emergencyExitOnChannelChange_43590.Value = value;
			}
		}

		// Token: 0x17004ECF RID: 20175
		// (get) Token: 0x06009CE8 RID: 40168 RVA: 0x0092B1AC File Offset: 0x009293AC
		// (set) Token: 0x06009CE9 RID: 40169 RVA: 0x0092B264 File Offset: 0x00929464
		public bool EmergencyExitOnChannelChange_43590_Applicable
		{
			get
			{
				short num = (short)630405445;
				short num2 = num;
				num = (short)254163269;
				switch (num2 == num)
				{
				}
				num = (short)836173824;
				short num3 = num;
				num = (short)334233601;
				if (num != 0)
				{
				}
				num = (short)788070400;
				if (num != 0)
				{
				}
				return this.emergencyExitOnChannelChange_43590.Applicable;
			}
			set
			{
				short num = (short)1759725607;
				short num2 = num;
				num = (short)13256743;
				switch (num2 == num)
				{
				}
				num = (short)1736638464;
				short num3 = num;
				num = (short)278659072;
				if (num != 0)
				{
				}
				num = (short)2009595905;
				if (num != 0)
				{
				}
				this.emergencyExitOnChannelChange_43590.Applicable = value;
			}
		}

		// Token: 0x17004ED0 RID: 20176
		// (get) Token: 0x06009CEA RID: 40170 RVA: 0x0092B31C File Offset: 0x0092951C
		// (set) Token: 0x06009CEB RID: 40171 RVA: 0x0092B3D0 File Offset: 0x009295D0
		public bool EmergencyExitOnChannelChange_43590_Valid
		{
			get
			{
				short num = (short)130535193;
				short num2 = num;
				num = (short)1214107417;
				switch (num2 == num)
				{
				}
				num = (short)330629120;
				short num3 = num;
				num = (short)386465792;
				if (num != 0)
				{
				}
				num = (short)53739521;
				if (num != 0)
				{
				}
				return this.emergencyExitOnChannelChange_43590.Valid;
			}
			set
			{
				short num = (short)1761996478;
				short num2 = num;
				num = (short)1642852030;
				switch (num2 == num)
				{
				}
				num = (short)482148352;
				short num3 = num;
				num = (short)922681344;
				if (num != 0)
				{
				}
				num = (short)369098753;
				if (num != 0)
				{
				}
				this.emergencyExitOnChannelChange_43590.Valid = value;
			}
		}

		// Token: 0x17004ED1 RID: 20177
		// (get) Token: 0x06009CEC RID: 40172 RVA: 0x0092B488 File Offset: 0x00929688
		// (set) Token: 0x06009CED RID: 40173 RVA: 0x0092B53C File Offset: 0x0092973C
		public bool EmergencyExitOnChannelChange_43590_Visible
		{
			get
			{
				short num = (short)810530806;
				short num2 = num;
				num = (short)1688385526;
				switch (num2 == num)
				{
				}
				num = (short)1628897280;
				short num3 = num;
				num = (short)1583939584;
				if (num != 0)
				{
				}
				num = (short)763101185;
				if (num != 0)
				{
				}
				return this.emergencyExitOnChannelChange_43590.Visible;
			}
			set
			{
				short num = (short)1793327105;
				if (num != 0)
				{
				}
				num = (short)1486946304;
				short num2 = num;
				num = (short)718872186;
				short num3 = num;
				num = (short)1248271994;
				switch (num3 == num)
				{
				}
				num = (short)1396834304;
				if (num != 0)
				{
				}
				this.emergencyExitOnChannelChange_43590.Visible = value;
			}
		}

		// Token: 0x17004ED2 RID: 20178
		// (get) Token: 0x06009CEE RID: 40174 RVA: 0x0092B5F4 File Offset: 0x009297F4
		// (set) Token: 0x06009CEF RID: 40175 RVA: 0x0092B6A8 File Offset: 0x009298A8
		public bool EmergencyExitOnChannelChange_43590_Editable
		{
			get
			{
				short num = (short)1896939843;
				short num2 = num;
				num = (short)793510211;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1829109760;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1022099457;
				if (num != 0)
				{
				}
				num = (short)758775808;
				if (num != 0)
				{
				}
				return this.emergencyExitOnChannelChange_43590.Editable;
			}
			set
			{
				short num = (short)669897419;
				short num2 = num;
				num = (short)231461579;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1988952064;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)51314688;
				if (num != 0)
				{
				}
				num = (short)760807425;
				if (num != 0)
				{
				}
				this.emergencyExitOnChannelChange_43590.Editable = value;
			}
		}

		// Token: 0x17004ED3 RID: 20179
		// (get) Token: 0x06009CF0 RID: 40176 RVA: 0x0092B75C File Offset: 0x0092995C
		internal string EmergencyExitOnChannelChange_43590_UILabel
		{
			get
			{
				short num = (short)908328961;
				if (num != 0)
				{
				}
				num = (short)80871424;
				short num2 = num;
				num = (short)223326506;
				short num3 = num;
				num = (short)242528554;
				switch (num3 == num)
				{
				}
				num = (short)662372352;
				if (num != 0)
				{
				}
				return this.emergencyExitOnChannelChange_43590.UIName;
			}
		}

		// Token: 0x17004ED4 RID: 20180
		// (get) Token: 0x06009CF1 RID: 40177 RVA: 0x0092B810 File Offset: 0x00929A10
		// (set) Token: 0x06009CF2 RID: 40178 RVA: 0x0092B8C4 File Offset: 0x00929AC4
		internal bool EmergencyExitOnChannelChange_43590_HiddenStatic
		{
			get
			{
				short num = (short)1991456798;
				short num2 = num;
				num = (short)105986078;
				switch (num2 == num)
				{
				default:
				{
					num = (short)31719424;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)797769729;
				if (num != 0)
				{
				}
				num = (short)298516480;
				if (num != 0)
				{
				}
				return this.emergencyExitOnChannelChange_43590.HiddenStatic;
			}
			set
			{
				short num = (short)712012905;
				short num2 = num;
				num = (short)1283880041;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1862926336;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1540161536;
				if (num != 0)
				{
				}
				num = (short)647626753;
				if (num != 0)
				{
				}
				this.emergencyExitOnChannelChange_43590.HiddenStatic = value;
			}
		}

		// Token: 0x17004ED5 RID: 20181
		// (get) Token: 0x06009CF3 RID: 40179 RVA: 0x0092B97C File Offset: 0x00929B7C
		// (set) Token: 0x06009CF4 RID: 40180 RVA: 0x0092BA30 File Offset: 0x00929C30
		internal bool EmergencyExitOnChannelChange_43590_HiddenDynamic
		{
			get
			{
				short num = (short)812480103;
				short num2 = num;
				num = (short)1075476071;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1018626048;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)629407744;
				if (num != 0)
				{
				}
				num = (short)1045102593;
				if (num != 0)
				{
				}
				return this.emergencyExitOnChannelChange_43590.HiddenDynamic;
			}
			set
			{
				short num = (short)1659345334;
				short num2 = num;
				num = (short)1035704758;
				switch (num2 == num)
				{
				default:
				{
					num = (short)40697856;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1287127040;
				if (num != 0)
				{
				}
				num = (short)588447745;
				if (num != 0)
				{
				}
				this.emergencyExitOnChannelChange_43590.HiddenDynamic = value;
			}
		}

		// Token: 0x17004ED6 RID: 20182
		// (get) Token: 0x06009CF5 RID: 40181 RVA: 0x0092BAE4 File Offset: 0x00929CE4
		public bool EmergencyExitOnChannelChange_43590_HasDiffs
		{
			get
			{
				short num = (short)1471051993;
				short num2 = num;
				num = (short)1323923673;
				switch (num2 == num)
				{
				default:
				{
					num = (short)28901376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1493041152;
				if (num != 0)
				{
				}
				num = (short)708247553;
				if (num != 0)
				{
				}
				return this.emergencyExitOnChannelChange_43590._HasDiffs;
			}
		}

		// Token: 0x17004ED7 RID: 20183
		// (get) Token: 0x06009CF6 RID: 40182 RVA: 0x0092BB98 File Offset: 0x00929D98
		// (set) Token: 0x06009CF7 RID: 40183 RVA: 0x0092BC48 File Offset: 0x00929E48
		public int CnvEmerProfGeneralTxPeriodsec2_A43600Value
		{
			get
			{
				short num = (short)150442731;
				short num2 = num;
				num = (short)824349419;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1063911424;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1837694976;
				if (num != 0)
				{
				}
				num = (short)1162674177;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralTxPeriodsec2_A43600.Value;
			}
			set
			{
				short num = (short)1739947187;
				short num2 = num;
				num = (short)2119793843;
				switch (num2 == num)
				{
				default:
				{
					num = (short)9240576;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1501364224;
				if (num != 0)
				{
				}
				num = (short)496369665;
				if (num != 0)
				{
				}
				this.cnvEmerProfGeneralTxPeriodsec2_A43600.Value = value;
			}
		}

		// Token: 0x17004ED8 RID: 20184
		// (get) Token: 0x06009CF8 RID: 40184 RVA: 0x0092BCFC File Offset: 0x00929EFC
		public global::AcpBusinessLayer.AcpSimpleRangeField CnvEmerProfGeneralTxPeriodsec2_A43600
		{
			get
			{
				short num = (short)560850503;
				short num2 = num;
				num = (short)2089936455;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1029177344;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1919287297;
				if (num != 0)
				{
				}
				num = (short)2061500416;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralTxPeriodsec2_A43600;
			}
		}

		// Token: 0x17004ED9 RID: 20185
		// (get) Token: 0x06009CF9 RID: 40185 RVA: 0x0092BDAC File Offset: 0x00929FAC
		// (set) Token: 0x06009CFA RID: 40186 RVA: 0x0092BE60 File Offset: 0x0092A060
		public string CnvEmerProfGeneralTxPeriodsec2_A43600_UIValue
		{
			get
			{
				short num = (short)1669145229;
				short num2 = num;
				num = (short)1104618125;
				switch (num2 == num)
				{
				default:
				{
					num = (short)204996608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)341442560;
				if (num != 0)
				{
				}
				num = (short)1704919041;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralTxPeriodsec2_A43600.UIValue;
			}
			set
			{
				short num = (short)1451447587;
				short num2 = num;
				num = (short)1060394275;
				switch (num2 == num)
				{
				default:
				{
					num = (short)329056256;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)306053121;
				if (num != 0)
				{
				}
				num = (short)1104347136;
				if (num != 0)
				{
				}
				this.cnvEmerProfGeneralTxPeriodsec2_A43600.UIValue = value;
			}
		}

		// Token: 0x17004EDA RID: 20186
		// (get) Token: 0x06009CFB RID: 40187 RVA: 0x0092BF18 File Offset: 0x0092A118
		// (set) Token: 0x06009CFC RID: 40188 RVA: 0x0092BFCC File Offset: 0x0092A1CC
		internal int CnvEmerProfGeneralTxPeriodsec2_A43600Min
		{
			get
			{
				short num = (short)1683043360;
				short num2 = num;
				num = (short)224212000;
				switch (num2 == num)
				{
				default:
				{
					num = (short)899547136;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1133314049;
				if (num != 0)
				{
				}
				num = (short)790626304;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralTxPeriodsec2_A43600.Min;
			}
			set
			{
				short num = (short)600076443;
				short num2 = num;
				num = (short)21000347;
				switch (num2 == num)
				{
				default:
				{
					num = (short)611909632;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)751042561;
				if (num != 0)
				{
				}
				num = (short)612564992;
				if (num != 0)
				{
				}
				this.cnvEmerProfGeneralTxPeriodsec2_A43600.Min = value;
			}
		}

		// Token: 0x17004EDB RID: 20187
		// (get) Token: 0x06009CFD RID: 40189 RVA: 0x0092C080 File Offset: 0x0092A280
		// (set) Token: 0x06009CFE RID: 40190 RVA: 0x0092C138 File Offset: 0x0092A338
		internal int CnvEmerProfGeneralTxPeriodsec2_A43600Max
		{
			get
			{
				short num = (short)213679006;
				short num2 = num;
				num = (short)1636465566;
				switch (num2 == num)
				{
				default:
				{
					num = (short)973930496;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1824325632;
				if (num != 0)
				{
				}
				num = (short)916324353;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralTxPeriodsec2_A43600.Max;
			}
			set
			{
				short num = (short)1055920757;
				short num2 = num;
				num = (short)1611731573;
				switch (num2 == num)
				{
				default:
				{
					num = (short)285212672;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)201129985;
				if (num != 0)
				{
				}
				num = (short)1133379584;
				if (num != 0)
				{
				}
				this.cnvEmerProfGeneralTxPeriodsec2_A43600.Max = value;
			}
		}

		// Token: 0x17004EDC RID: 20188
		// (get) Token: 0x06009CFF RID: 40191 RVA: 0x0092C1EC File Offset: 0x0092A3EC
		// (set) Token: 0x06009D00 RID: 40192 RVA: 0x0092C2A0 File Offset: 0x0092A4A0
		internal int CnvEmerProfGeneralTxPeriodsec2_A43600Step
		{
			get
			{
				short num = (short)68733710;
				short num2 = num;
				num = (short)1043712782;
				switch (num2 == num)
				{
				default:
				{
					num = (short)403308544;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1697120257;
				if (num != 0)
				{
				}
				num = (short)1467351040;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralTxPeriodsec2_A43600.StepSize;
			}
			set
			{
				short num = (short)101472334;
				short num2 = num;
				num = (short)246241358;
				switch (num2 == num)
				{
				default:
				{
					num = (short)771686400;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)217907201;
				if (num != 0)
				{
				}
				num = (short)1837039616;
				if (num != 0)
				{
				}
				this.cnvEmerProfGeneralTxPeriodsec2_A43600.StepSize = value;
			}
		}

		// Token: 0x17004EDD RID: 20189
		// (get) Token: 0x06009D01 RID: 40193 RVA: 0x0092C354 File Offset: 0x0092A554
		// (set) Token: 0x06009D02 RID: 40194 RVA: 0x0092C404 File Offset: 0x0092A604
		public bool CnvEmerProfGeneralTxPeriodsec2_A43600_Applicable
		{
			get
			{
				short num = (short)497470275;
				short num2 = num;
				num = (short)1358809923;
				switch (num2 == num)
				{
				default:
				{
					num = (short)316276736;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1440219136;
				if (num != 0)
				{
				}
				num = (short)1815937025;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralTxPeriodsec2_A43600.Applicable;
			}
			set
			{
				short num = (short)1374981491;
				short num2 = num;
				num = (short)1016302963;
				switch (num2 == num)
				{
				default:
				{
					num = (short)384630784;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)80084993;
				if (num != 0)
				{
				}
				num = (short)92798976;
				if (num != 0)
				{
				}
				this.cnvEmerProfGeneralTxPeriodsec2_A43600.Applicable = value;
			}
		}

		// Token: 0x17004EDE RID: 20190
		// (get) Token: 0x06009D03 RID: 40195 RVA: 0x0092C4C0 File Offset: 0x0092A6C0
		// (set) Token: 0x06009D04 RID: 40196 RVA: 0x0092C574 File Offset: 0x0092A774
		public bool CnvEmerProfGeneralTxPeriodsec2_A43600_Valid
		{
			get
			{
				short num = (short)223753924;
				short num2 = num;
				num = (short)2036020932;
				switch (num2 == num)
				{
				default:
				{
					num = (short)397344768;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)902823937;
				if (num != 0)
				{
				}
				num = (short)323354624;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralTxPeriodsec2_A43600.Valid;
			}
			set
			{
				short num = (short)1039783550;
				short num2 = num;
				num = (short)312530558;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1532821504;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1038155777;
				if (num != 0)
				{
				}
				num = (short)1953628160;
				if (num != 0)
				{
				}
				this.cnvEmerProfGeneralTxPeriodsec2_A43600.Valid = value;
			}
		}

		// Token: 0x17004EDF RID: 20191
		// (get) Token: 0x06009D05 RID: 40197 RVA: 0x0092C628 File Offset: 0x0092A828
		// (set) Token: 0x06009D06 RID: 40198 RVA: 0x0092C6DC File Offset: 0x0092A8DC
		public bool CnvEmerProfGeneralTxPeriodsec2_A43600_Visible
		{
			get
			{
				short num = (short)761427521;
				short num2 = num;
				num = (short)989754945;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2043346944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)482738176;
				if (num != 0)
				{
				}
				num = (short)1932525569;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralTxPeriodsec2_A43600.Visible;
			}
			set
			{
				short num = (short)1591541761;
				if (num != 0)
				{
				}
				num = (short)32571392;
				short num2 = num;
				num = (short)1606549650;
				short num3 = num;
				num = (short)1233125522;
				switch (num3 == num)
				{
				}
				num = (short)186777600;
				if (num != 0)
				{
				}
				this.cnvEmerProfGeneralTxPeriodsec2_A43600.Visible = value;
			}
		}

		// Token: 0x17004EE0 RID: 20192
		// (get) Token: 0x06009D07 RID: 40199 RVA: 0x0092C790 File Offset: 0x0092A990
		// (set) Token: 0x06009D08 RID: 40200 RVA: 0x0092C844 File Offset: 0x0092AA44
		public bool CnvEmerProfGeneralTxPeriodsec2_A43600_Editable
		{
			get
			{
				short num = (short)711196673;
				if (num != 0)
				{
				}
				num = (short)926089216;
				short num2 = num;
				num = (short)1702136838;
				short num3 = num;
				num = (short)541821958;
				switch (num3 == num)
				{
				}
				num = (short)617283584;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralTxPeriodsec2_A43600.Editable;
			}
			set
			{
				short num = (short)30166223;
				short num2 = num;
				num = (short)1761823951;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2022834176;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1699872768;
				if (num != 0)
				{
				}
				num = (short)305528833;
				if (num != 0)
				{
				}
				this.cnvEmerProfGeneralTxPeriodsec2_A43600.Editable = value;
			}
		}

		// Token: 0x17004EE1 RID: 20193
		// (get) Token: 0x06009D09 RID: 40201 RVA: 0x0092C8FC File Offset: 0x0092AAFC
		internal string CnvEmerProfGeneralTxPeriodsec2_A43600_UILabel
		{
			get
			{
				short num = (short)1651645980;
				short num2 = num;
				num = (short)1002774044;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1290797056;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)16318465;
				if (num != 0)
				{
				}
				num = (short)1740111872;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralTxPeriodsec2_A43600.UIName;
			}
		}

		// Token: 0x17004EE2 RID: 20194
		// (get) Token: 0x06009D0A RID: 40202 RVA: 0x0092C9B4 File Offset: 0x0092ABB4
		// (set) Token: 0x06009D0B RID: 40203 RVA: 0x0092CA68 File Offset: 0x0092AC68
		internal bool CnvEmerProfGeneralTxPeriodsec2_A43600_HiddenStatic
		{
			get
			{
				short num = (short)163381249;
				if (num != 0)
				{
				}
				num = (short)1236271104;
				short num2 = num;
				num = (short)543164242;
				short num3 = num;
				num = (short)1036912466;
				switch (num3 == num)
				{
				}
				num = (short)335478784;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralTxPeriodsec2_A43600.HiddenStatic;
			}
			set
			{
				short num = (short)2001306796;
				short num2 = num;
				num = (short)1065321644;
				switch (num2 == num)
				{
				default:
				{
					num = (short)903806976;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1531510785;
				if (num != 0)
				{
				}
				num = (short)571801600;
				if (num != 0)
				{
				}
				this.cnvEmerProfGeneralTxPeriodsec2_A43600.HiddenStatic = value;
			}
		}

		// Token: 0x17004EE3 RID: 20195
		// (get) Token: 0x06009D0C RID: 40204 RVA: 0x0092CB1C File Offset: 0x0092AD1C
		// (set) Token: 0x06009D0D RID: 40205 RVA: 0x0092CBD0 File Offset: 0x0092ADD0
		internal bool CnvEmerProfGeneralTxPeriodsec2_A43600_HiddenDynamic
		{
			get
			{
				short num = (short)1014180530;
				short num2 = num;
				num = (short)2130979506;
				switch (num2 == num)
				{
				default:
				{
					num = (short)702545920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1057816577;
				if (num != 0)
				{
				}
				num = (short)741015552;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralTxPeriodsec2_A43600.HiddenDynamic;
			}
			set
			{
				short num = (short)638648321;
				if (num != 0)
				{
				}
				num = (short)1192034304;
				short num2 = num;
				num = (short)260039597;
				short num3 = num;
				num = (short)1594287021;
				switch (num3 == num)
				{
				}
				num = (short)1346961408;
				if (num != 0)
				{
				}
				this.cnvEmerProfGeneralTxPeriodsec2_A43600.HiddenDynamic = value;
			}
		}

		// Token: 0x17004EE4 RID: 20196
		// (get) Token: 0x06009D0E RID: 40206 RVA: 0x0092CC84 File Offset: 0x0092AE84
		public bool CnvEmerProfGeneralTxPeriodsec2_A43600_HasDiffs
		{
			get
			{
				short num = (short)598756073;
				short num2 = num;
				num = (short)1487555305;
				switch (num2 == num)
				{
				default:
				{
					num = (short)952434688;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1920532481;
				if (num != 0)
				{
				}
				num = (short)1518993408;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralTxPeriodsec2_A43600._HasDiffs;
			}
		}

		// Token: 0x17004EE5 RID: 20197
		// (get) Token: 0x06009D0F RID: 40207 RVA: 0x0092CD38 File Offset: 0x0092AF38
		// (set) Token: 0x06009D10 RID: 40208 RVA: 0x0092CDEC File Offset: 0x0092AFEC
		public int CnvEmerProfGeneralRemoteActivationEmergencyValue
		{
			get
			{
				short num = (short)1207435265;
				if (num != 0)
				{
				}
				num = (short)2031353856;
				short num2 = num;
				num = (short)1584037286;
				short num3 = num;
				num = (short)1989246374;
				switch (num3 == num)
				{
				}
				num = (short)2100166656;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralRemoteActivationEmergency.Value;
			}
			set
			{
				short num = (short)2093823594;
				short num2 = num;
				num = (short)910964330;
				switch (num2 == num)
				{
				default:
				{
					num = (short)215416832;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)440074241;
				if (num != 0)
				{
				}
				num = (short)1191378944;
				if (num != 0)
				{
				}
				this.cnvEmerProfGeneralRemoteActivationEmergency.Value = value;
			}
		}

		// Token: 0x17004EE6 RID: 20198
		// (get) Token: 0x06009D11 RID: 40209 RVA: 0x0092CEA0 File Offset: 0x0092B0A0
		// (set) Token: 0x06009D12 RID: 40210 RVA: 0x0092CF58 File Offset: 0x0092B158
		public string CnvEmerProfGeneralRemoteActivationEmergency_UIValue
		{
			get
			{
				short num = (short)1721784896;
				short num2 = num;
				num = (short)483613248;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1379926016;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1564540929;
				if (num != 0)
				{
				}
				num = (short)928972800;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralRemoteActivationEmergency.UIValue;
			}
			set
			{
				short num = (short)1095192003;
				short num2 = num;
				num = (short)948915651;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1737883648;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1504903168;
				if (num != 0)
				{
				}
				num = (short)1217658881;
				if (num != 0)
				{
				}
				this.cnvEmerProfGeneralRemoteActivationEmergency.UIValue = value;
			}
		}

		// Token: 0x17004EE7 RID: 20199
		// (get) Token: 0x06009D13 RID: 40211 RVA: 0x0092D00C File Offset: 0x0092B20C
		public global::AcpBusinessLayer.AcpListField CnvEmerProfGeneralRemoteActivationEmergency
		{
			get
			{
				short num = (short)1247178116;
				short num2 = num;
				num = (short)1196387716;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1918763008;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)533725184;
				if (num != 0)
				{
				}
				num = (short)512163841;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralRemoteActivationEmergency;
			}
		}

		// Token: 0x17004EE8 RID: 20200
		// (get) Token: 0x06009D14 RID: 40212 RVA: 0x0092D0BC File Offset: 0x0092B2BC
		// (set) Token: 0x06009D15 RID: 40213 RVA: 0x0092D170 File Offset: 0x0092B370
		public bool CnvEmerProfGeneralRemoteActivationEmergency_Applicable
		{
			get
			{
				short num = (short)1696658204;
				short num2 = num;
				num = (short)828764956;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1042415616;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)547946497;
				if (num != 0)
				{
				}
				num = (short)1095630848;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralRemoteActivationEmergency.Applicable;
			}
			set
			{
				short num = (short)1268054491;
				short num2 = num;
				num = (short)1327495643;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1561133056;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)902299649;
				if (num != 0)
				{
				}
				num = (short)30408704;
				if (num != 0)
				{
				}
				this.cnvEmerProfGeneralRemoteActivationEmergency.Applicable = value;
			}
		}

		// Token: 0x17004EE9 RID: 20201
		// (get) Token: 0x06009D16 RID: 40214 RVA: 0x0092D224 File Offset: 0x0092B424
		// (set) Token: 0x06009D17 RID: 40215 RVA: 0x0092D2D8 File Offset: 0x0092B4D8
		public bool CnvEmerProfGeneralRemoteActivationEmergency_Valid
		{
			get
			{
				short num = (short)1407600897;
				short num2 = num;
				num = (short)1524320513;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1715666944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)111738880;
				if (num != 0)
				{
				}
				num = (short)1301282817;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralRemoteActivationEmergency.Valid;
			}
			set
			{
				short num = (short)1273124877;
				short num2 = num;
				num = (short)1050957837;
				switch (num2 == num)
				{
				default:
				{
					num = (short)736165888;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1908801537;
				if (num != 0)
				{
				}
				num = (short)426377216;
				if (num != 0)
				{
				}
				this.cnvEmerProfGeneralRemoteActivationEmergency.Valid = value;
			}
		}

		// Token: 0x17004EEA RID: 20202
		// (get) Token: 0x06009D18 RID: 40216 RVA: 0x0092D390 File Offset: 0x0092B590
		// (set) Token: 0x06009D19 RID: 40217 RVA: 0x0092D448 File Offset: 0x0092B648
		public bool CnvEmerProfGeneralRemoteActivationEmergency_Visible
		{
			get
			{
				short num = (short)1571943993;
				short num2 = num;
				num = (short)1922758201;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2016608256;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1118830593;
				if (num != 0)
				{
				}
				num = (short)412155904;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralRemoteActivationEmergency.Visible;
			}
			set
			{
				short num = (short)1416809218;
				short num2 = num;
				num = (short)883936002;
				switch (num2 == num)
				{
				default:
				{
					num = (short)413728768;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1132920832;
				if (num != 0)
				{
				}
				num = (short)1190723585;
				if (num != 0)
				{
				}
				this.cnvEmerProfGeneralRemoteActivationEmergency.Visible = value;
			}
		}

		// Token: 0x17004EEB RID: 20203
		// (get) Token: 0x06009D1A RID: 40218 RVA: 0x0092D500 File Offset: 0x0092B700
		// (set) Token: 0x06009D1B RID: 40219 RVA: 0x0092D5B4 File Offset: 0x0092B7B4
		public bool CnvEmerProfGeneralRemoteActivationEmergency_Editable
		{
			get
			{
				short num = (short)1899233281;
				if (num != 0)
				{
				}
				num = (short)306577408;
				short num2 = num;
				num = (short)1652789989;
				short num3 = num;
				num = (short)922981093;
				switch (num3 == num)
				{
				}
				num = (short)772472832;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralRemoteActivationEmergency.Editable;
			}
			set
			{
				short num = (short)733642629;
				short num2 = num;
				num = (short)1801748357;
				switch (num2 == num)
				{
				default:
				{
					num = (short)14483456;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1521942529;
				if (num != 0)
				{
				}
				num = (short)1441792000;
				if (num != 0)
				{
				}
				this.cnvEmerProfGeneralRemoteActivationEmergency.Editable = value;
			}
		}

		// Token: 0x17004EEC RID: 20204
		// (get) Token: 0x06009D1C RID: 40220 RVA: 0x0092D668 File Offset: 0x0092B868
		internal string CnvEmerProfGeneralRemoteActivationEmergency_UILabel
		{
			get
			{
				short num = (short)717467216;
				short num2 = num;
				num = (short)715763280;
				switch (num2 == num)
				{
				default:
				{
					num = (short)894959616;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1704919040;
				if (num != 0)
				{
				}
				num = (short)1375862785;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralRemoteActivationEmergency.UIName;
			}
		}

		// Token: 0x17004EED RID: 20205
		// (get) Token: 0x06009D1D RID: 40221 RVA: 0x0092D720 File Offset: 0x0092B920
		// (set) Token: 0x06009D1E RID: 40222 RVA: 0x0092D7D4 File Offset: 0x0092B9D4
		internal bool CnvEmerProfGeneralRemoteActivationEmergency_HiddenStatic
		{
			get
			{
				short num = (short)225763914;
				short num2 = num;
				num = (short)896787018;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1898643456;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)570097665;
				if (num != 0)
				{
				}
				num = (short)1295056896;
				if (num != 0)
				{
				}
				return this.cnvEmerProfGeneralRemoteActivationEmergency.HiddenStatic;
			}
			set
			{
				short num = (short)714897974;
				short num2 = num;
				num = (short)1301576246;
				switch (num2 == num)
				{
				default:
				{
					num = (short)683802624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)898367488;
				if (num != 0)
				{
				}
				num = (short)2015232001;
				if (num != 0)
				{
				}
				this.cnvEmerProfGeneralRemoteActivationEmergency.HiddenStatic = value;
			}
		}

		// Token: 0x17004EEE RID: 20206
		// (get) Token: 0x06009D1F RID: 40223 RVA: 0x0092D888 File Offset: 0x0092BA88
		// (set) Token: 0x06009D20 RID: 40224 RVA: 0x0092D93C File Offset: 0x0092BB3C
		internal bool CnvEmerProfGeneralRemoteActivationEmergency_HiddenDynamic
		{
			get
			{
				short num = (short)94551463;
				short num2 = num;
				num = (short)2003615143;
				switch (num2 == num)
				{
				}
				num = (short)1800404993;
				if (num != 0)
				{
				}
				num = (short)254803968;
				if (num != 0)
				{
				}
				num = (short)1877213184;
				short num3 = num;
				return this.cnvEmerProfGeneralRemoteActivationEmergency.HiddenDynamic;
			}
			set
			{
				short num = (short)689518002;
				short num2 = num;
				num = (short)1730557362;
				switch (num2 == num)
				{
				}
				num = (short)613613569;
				if (num != 0)
				{
				}
				num = (short)481951744;
				if (num != 0)
				{
				}
				num = (short)1633878016;
				short num3 = num;
				this.cnvEmerProfGeneralRemoteActivationEmergency.HiddenDynamic = value;
			}
		}

		// Token: 0x17004EEF RID: 20207
		// (get) Token: 0x06009D21 RID: 40225 RVA: 0x0092D9F0 File Offset: 0x0092BBF0
		public bool CnvEmerProfGeneralRemoteActivationEmergency_HasDiffs
		{
			get
			{
				short num = (short)440992779;
				short num2 = num;
				num = (short)540083211;
				switch (num2 == num)
				{
				}
				num = (short)1828585473;
				if (num != 0)
				{
				}
				num = (short)466616320;
				if (num != 0)
				{
				}
				num = (short)2137260032;
				short num3 = num;
				return this.cnvEmerProfGeneralRemoteActivationEmergency._HasDiffs;
			}
		}

		// Token: 0x17004EF0 RID: 20208
		// (get) Token: 0x06009D22 RID: 40226 RVA: 0x0092DAA4 File Offset: 0x0092BCA4
		public global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.EmergencyWide RefEmergencyWide
		{
			get
			{
				short num = (short)1120769647;
				short num2 = num;
				num = (short)287217263;
				switch (num2 == num)
				{
				}
				num = (short)405340161;
				if (num != 0)
				{
				}
				num = (short)1496252416;
				if (num != 0)
				{
				}
				num = (short)593428480;
				short num3 = num;
				return global::AcpCommonLib.FeatureManager.GetFeature(2032)[0] as global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.EmergencyWide;
			}
		}

		// Token: 0x06009D23 RID: 40227 RVA: 0x0092DB64 File Offset: 0x0092BD64
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			short num = (short)1084555265;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_4C;
			}
			int num2;
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_32:
				switch (num2)
				{
				case 0:
				{
					num = (short)217907200;
					short num3 = num;
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num = (short)119865347;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					goto IL_DB;
				case 2:
				{
					if (base.ParentRecset.ContainerDoc == null)
					{
						return result;
					}
					num = (short)1749544114;
					short num4 = num;
					num = (short)610659506;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_DB;
					default:
						num = (short)2046361600;
						if (num != 0)
						{
						}
						num = (short)2135425024;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 3:
					return result;
				case 4:
					if (base.ParentRecset != null)
					{
						num = (short)633339905;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				}
				goto IL_4C;
				IL_DB:
				num = (short)1863057410;
				num2 = (int)((global::System.IntPtr)num);
			}
			return result;
			IL_4C:
			result = null;
			num = (short)391708676;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_32;
		}

		// Token: 0x04004CFD RID: 19709
		private global::AcpBusinessLayer.AcpField<bool> cnvEmerProfGeneralAcknowledgeAlertTone_A7394;

		// Token: 0x04004CFE RID: 19710
		private global::AcpBusinessLayer.AcpListField cnvEmerProfGeneralEmergencyType_A7960;

		// Token: 0x04004CFF RID: 19711
		private global::AcpBusinessLayer.AcpField<bool> cnvEmerProfGeneralEnable3_A8171;

		// Token: 0x04004D00 RID: 19712
		private global::AcpBusinessLayer.AcpSimpleRangeField cnvEmerProfGeneralPoliteRetries_A8712;

		// Token: 0x04004D01 RID: 19713
		private global::AcpBusinessLayer.AcpListField cnvEmerProfGeneralFactor_A9548;

		// Token: 0x04004D02 RID: 19714
		private global::AcpBusinessLayer.AcpKeyField cnvEmerProfGeneralkeyofConventionalEmergencyProfiles_A19418;

		// Token: 0x04004D03 RID: 19715
		private global::AcpBusinessLayer.AcpListField conEmerProEmergencyAutoTransmitMode_A22532;

		// Token: 0x04004D04 RID: 19716
		private global::AcpBusinessLayer.AcpSimpleRangeField cnvEmerProfGeneralTxPeriodsec1_A8212;

		// Token: 0x04004D05 RID: 19717
		private global::AcpBusinessLayer.AcpSimpleRangeField cnvEmerProfGeneralImpoliteRetries_A8242;

		// Token: 0x04004D06 RID: 19718
		private global::AcpBusinessLayer.AcpSimpleRangeField cnvEmerProfGeneralTxPeriodsec2_A9131;

		// Token: 0x04004D07 RID: 19719
		private global::AcpBusinessLayer.AcpField<bool> cnvEmerProfGeneralConsoleAckRequired_A40167;

		// Token: 0x04004D08 RID: 19720
		private global::AcpBusinessLayer.AcpField<bool> cnvPerManDownEnable_42038;

		// Token: 0x04004D09 RID: 19721
		private global::AcpBusinessLayer.AcpListField cnvEmerProfEmergencyHotAuxMic_A42296;

		// Token: 0x04004D0A RID: 19722
		private global::AcpBusinessLayer.AcpField<bool> cnvPerEMGFindMeTxEnable_42920;

		// Token: 0x04004D0B RID: 19723
		private global::AcpBusinessLayer.AcpField<bool> cnvPerEMGFindMeRxEnable_42922;

		// Token: 0x04004D0C RID: 19724
		private global::AcpBusinessLayer.AcpField<bool> cnvEmerProfImpactDetectionEn_A43391;

		// Token: 0x04004D0D RID: 19725
		private global::AcpBusinessLayer.AcpField<bool> emergencyExitOnChannelChange_43590;

		// Token: 0x04004D0E RID: 19726
		private global::AcpBusinessLayer.AcpSimpleRangeField cnvEmerProfGeneralTxPeriodsec2_A43600;

		// Token: 0x04004D0F RID: 19727
		private global::AcpBusinessLayer.AcpListField cnvEmerProfGeneralRemoteActivationEmergency;
	}
}
