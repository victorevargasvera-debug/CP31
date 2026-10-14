using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using ConstraintHelper;
using Motorola.MackinawCPS.CoreFeatures.EmergencyWide;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;

namespace Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles
{
	// Token: 0x0200047A RID: 1146
	[global::System.Serializable]
	public class General : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06009638 RID: 38456 RVA: 0x008D3424 File Offset: 0x008D1624
		public General(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06009639 RID: 38457 RVA: 0x008D3440 File Offset: 0x008D1640
		protected General(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600963A RID: 38458 RVA: 0x008D3458 File Offset: 0x008D1658
		public override void Init()
		{
			int a_ = 19;
			short num = (short)1340832860;
			short num2 = num;
			num = (short)633437276;
			switch (num2 == num)
			{
			}
			num = (short)2004549632;
			short num3 = num;
			num = (short)352518144;
			if (num != 0)
			{
			}
			num = (short)1535574017;
			if (num != 0)
			{
			}
			this.trkEmerProfGeneralConsoleAckRequired_A7712 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("胓ꓕ돗鿙뇛믝鋟닡難觥軧귩觫胭闯胱闳髵믷闹鋻跽濿渁愃䜅欇愉帋欍意朑紓搕紗縙䌛弝ᜟᔡᔣᐥ", a_), global::CommonResources.AcgResources.ID_CONSOLEACKREQUIRED);
			this.trkEmerProfGeneralConsoleAckRequired_A7712.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkEmerProfGeneralConsoleAckRequired_A7712.DataTransferOrder = 4;
			this.trkEmerProfGeneralEmergencyOperation_A7926 = new global::AcpBusinessLayer.AcpSparseLOVField(1, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.LOVs.indexTrkEmerProfGeneralEmergencyOperation_A7926LovStrs, global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.LOVs.idTrkEmerProfGeneralEmergencyOperation_A7926LovStrs), this, global::AllFeatures.CodeplugGuid.b("胓ꓕ돗鿙뇛믝鋟닡難觥軧귩觫胭闯胱闳髵뷷韹駻賽柿朁樃攅焇䔉簋欍戏猑怓缕眗琙䌛弝ᜟᬡᘣဥ", a_), global::CommonResources.AcgResources.ID_EMERGENCYOPERATION, global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.LOVs.TrkEmerProfGeneralEmergencyOperation_A7926LovStrs);
			this.trkEmerProfGeneralEmergencyOperation_A7926.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkEmerProfGeneralEmergencyOperation_A7926.DataTransferOrder = 3;
			this.trkEmerProfGeneralRetryCounter_A8951 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("胓ꓕ돗鿙뇛믝鋟닡難觥軧귩觫胭闯胱闳髵꫷鿹裻賽秿䄁欃猅昇縉椋簍伏匑Ⱃ⼕ⴗ⬙", a_), global::CommonResources.AcgResources.ID_RETRYCOUNTER, 0, 255, global::CommonResources.AcgResources.ID_INFINITE, null, 0, 1);
			this.trkEmerProfGeneralRetryCounter_A8951.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkEmerProfGeneralRetryCounter_A8951.DataTransferOrder = 13;
			this.trkEmerProfGeneralRetryCounter_A8951.ShowHexValue = false;
			this.trkEmerProfGeneralEmergencyTalkback_A9268 = new global::AcpBusinessLayer.AcpSparseLOVField(1, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.LOVs.indexTrkEmerProfGeneralEmergencyTalkback_A9268LovStrs, global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.LOVs.idTrkEmerProfGeneralEmergencyTalkback_A9268LovStrs), this, global::AllFeatures.CodeplugGuid.b("胓ꓕ돗鿙뇛믝鋟닡難觥軧귩觫胭闯胱闳髵뷷韹駻賽柿朁樃攅焇帉洋戍笏瀑甓甕猗䔙崛✝ሟᐡᰣ", a_), global::CommonResources.AcgResources.ID_EMERGENCYTALKBACK, global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.LOVs.TrkEmerProfGeneralEmergencyTalkback_A9268LovStrs);
			this.trkEmerProfGeneralEmergencyTalkback_A9268.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkEmerProfGeneralEmergencyTalkback_A9268.DataTransferOrder = 1;
			this.trkEmerProfGeneralEmergencyTalkback_A9268.EvaluateRecRefs = true;
			this.trkEmerProfGeneralRevertPTTID_A12642 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("胓ꓕ돗鿙뇛믝鋟닡難觥軧귩觫胭闯胱闳髵꫷鿹諻鯽狿瘁吃刅將䌉䠋儍儏⌑☓―Ⱇ⠙", a_), global::CommonResources.AcgResources.ID_REVERTPTTID);
			this.trkEmerProfGeneralRevertPTTID_A12642.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.trkEmerProfGeneralRevertPTTID_A12642.DataTransferOrder = 2;
			this.trkEmerProfGeneralkeyofTrunkingEmergencyProfiles_A19419 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("胓ꓕ돗鿙뇛믝鋟닡難觥軧귩觫胭闯胱闳髵鏷鿹藻釽替嘁瘃猅昇愉攋怍眏圑礓猕樗紙礛瀝䌟嬡琣吥䜧䰩䔫䈭唯䄱欳眵ष̹࠻༽礿", a_), global::CommonResources.AcgResources.ID_TRUNKINGEMERGENCYPROFILES, 14);
			this.trkEmerProfGeneralkeyofTrunkingEmergencyProfiles_A19419.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.trkEmerProfGeneralkeyofTrunkingEmergencyProfiles_A19419.DataTransferOrder = 7;
			this.trkEmerProEmergencyAutoTransmitMode_A22567 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.LOVs.indexTrkEmerProEmergencyAutoTransmitMode_A22567LovStrs, global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.LOVs.idTrkEmerProEmergencyAutoTransmitMode_A22567LovStrs), this, global::AllFeatures.CodeplugGuid.b("胓ꓕ돗鿙뇛믝鋟닡難觥귧蟩觫鳭韯韱髳闵臷믹觻諽濿嘁瘃朅昇礉愋服搏弑笓爕紗䔙崛Ⱍሟᜡሣᄥ", a_), global::CommonResources.AcgResources.ID_AUTOTRANSMITEMERGENCYAUTOTRANSMITMODE, global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.LOVs.TrkEmerProEmergencyAutoTransmitMode_A22567LovStrs);
			this.trkEmerProEmergencyAutoTransmitMode_A22567.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkEmerProEmergencyAutoTransmitMode_A22567.DataTransferOrder = 14;
			this.trkEmerProEmergencyAutoTransmitMode_A22567.EvaluateRecRefs = true;
			this.trkEmerProfGeneralTxPeriodsec1_A7939 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("胓ꓕ돗鿙뇛믝鋟닡難觥軧귩觫胭闯胱闳髵곷苹곻鯽狿欁欃戅笇漉漋㼍伏匑⌓⼕⬗⌙", a_), global::CommonResources.AcgResources.ID_AUTOTRANSMITHOTMICTXPERIODSECOLDFIELD, 1, 12, null, null, 0, 10);
			this.trkEmerProfGeneralTxPeriodsec1_A7939.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkEmerProfGeneralTxPeriodsec1_A7939.DataTransferOrder = 15;
			this.trkEmerProfGeneralTxPeriodsec1_A7939.ShowHexValue = false;
			this.trkEmerProfGeneralTxPeriodsec2_A9132 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("胓ꓕ돗鿙뇛믝鋟닡難觥軧귩觫胭闯胱闳髵곷苹곻鯽狿欁欃戅笇漉漋㰍伏匑ⴓ✕⬗⠙", a_), global::CommonResources.AcgResources.ID_AUTOTRANSMITSILENTAUDIOTXPERIODSEC, 1, 5, null, null, 0, 1);
			this.trkEmerProfGeneralTxPeriodsec2_A9132.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkEmerProfGeneralTxPeriodsec2_A9132.DataTransferOrder = 16;
			this.trkEmerProfGeneralTxPeriodsec2_A9132.ShowHexValue = false;
			this.trkPerManDownEnable_42039 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("胓ꓕ돗諙맛곝귟菡諣ꋥ蟧鷩苫꯭黯鏱雳髵鷷ꗹ죻쳽ヿ㄁㴃", a_), global::CommonResources.AcgResources.ID_MANDOWNENABLE);
			this.trkPerManDownEnable_42039.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.trkPerManDownEnable_42039.DataTransferOrder = 18;
			this.trkEmerProfEmergencyHotAuxMic_A42300 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.LOVs.indexTrkEmerProfEmergencyHotAuxMic_A42300LovStrs, global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.LOVs.idTrkEmerProfEmergencyHotAuxMic_A42300LovStrs), this, global::AllFeatures.CodeplugGuid.b("胓ꓕ돗鿙뇛믝鋟닡難觥軧꿩臫语苯闱釳飵鯷菹듻釽瓿䌁焃縅䔇按漋儍儏☑☓┕⠗⨙", a_), global::CommonResources.AcgResources.ID_AUTOTRANSMITHOTAUXMICACTIVATION, global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.LOVs.TrkEmerProfEmergencyHotAuxMic_A42300LovStrs);
			this.trkEmerProfEmergencyHotAuxMic_A42300.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkEmerProfEmergencyHotAuxMic_A42300.DataTransferOrder = 30;
			this.trkPeEMGFindMeTxEnable_42921 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("胓ꓕ돗諙맛鯝귟ꗡꋣ迥蛧軩ꇫ语ꓯ諱뇳飵駷飹郻鯽忿㘁㘃㼅㨇㬉", a_), global::CommonResources.AcgResources.ID_EMERGENCYFINDMETRANSMITENABLE);
			this.trkPeEMGFindMeTxEnable_42921.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.trkPeEMGFindMeTxEnable_42921.DataTransferOrder = 25;
			this.trkPeEMGFindMeRxEnable_42923 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("胓ꓕ돗諙맛鯝귟ꗡꋣ迥蛧軩ꇫ语ꋯ諱뇳飵駷飹郻鯽忿㘁㘃㼅㨇㤉", a_), global::CommonResources.AcgResources.ID_EMERGENCYFINDMERECEIVEENABLE);
			this.trkPeEMGFindMeRxEnable_42923.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.trkPeEMGFindMeRxEnable_42923.DataTransferOrder = 26;
			this.trkEmerProfImpactDetectionEn_A43392 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("胓ꓕ돗鿙뇛믝鋟닡難觥軧ꏩ臫黭釯釱胳답鷷軹駻鷽瓿欁欃栅䴇搉匋伍␏ℑ✓⼕⨗", a_), global::CommonResources.AcgResources.ID_IMPACTDETECTIONENABLE);
			this.trkEmerProfImpactDetectionEn_A43392.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkEmerProfImpactDetectionEn_A43392.DataTransferOrder = 22;
			this.emergencyExitOnChannelChange_43588 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("釓믕뷗꣙믛믝軟臡鷣ꏥ郧菩飫ꇭ黯뇱鳳韵雷铹駻鋽䏿樁攃栅漇漉匋㨍⌏✑Ⱃ⸕", a_), global::CommonResources.AcgResources.ID_EMERGENCYEXITONCHANNELCHANGE);
			this.emergencyExitOnChannelChange_43588.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.emergencyExitOnChannelChange_43588.DataTransferOrder = 12;
			this.trkEmerProfGeneralTxPeriodsec2_A43601 = new global::AcpBusinessLayer.AcpSimpleRangeField(10, this, global::AllFeatures.CodeplugGuid.b("胓ꓕ돗鿙뇛믝鋟닡難觥軧귩觫胭闯胱闳髵곷苹곻鯽狿欁欃戅笇漉漋㰍伏匑–┕⸗⨙ⴛ", a_), global::CommonResources.AcgResources.ID_AUTOTRANSMITHOTMICTXPERIODSEC, 1, 120, null, null, 0, 1);
			this.trkEmerProfGeneralTxPeriodsec2_A43601.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkEmerProfGeneralTxPeriodsec2_A43601.DataTransferOrder = 17;
			this.trkEmerProfGeneralTxPeriodsec2_A43601.ShowHexValue = false;
			this.trkEmerProfGeneralRemoteActivationEmergency = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("胓ꓕ돗鿙뇛믝鋟닡難觥軧귩觫胭闯胱闳髵꫷鿹釻釽瓿朁䔃攅簇按程漍搏笑笓砕崗眙礛氝䜟䜡䨣䔥儧", a_), global::CommonResources.AcgResources.ID_REMOTEEMERGENCYACTIVATION, global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.LOVs.TrkEmerProfGeneralRemoteActivationEmergencyLovStrs);
			this.trkEmerProfGeneralRemoteActivationEmergency.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkEmerProfGeneralRemoteActivationEmergency.DataTransferOrder = 31;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鏓돕뛗뿙껛뿝賟", a_);
			base.Id = 10186;
			base.UIName = global::CommonResources.AcgResources.ID_GENERAL;
			base.DataTransferOrder = 1;
		}

		// Token: 0x0600963B RID: 38459 RVA: 0x008D39C0 File Offset: 0x008D1BC0
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 15;
			short num = (short)568066048;
			short num2 = num;
			num = (short)1132331033;
			int num3 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num3)
				{
				case 0:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蓏ꃑ뿓鏕뗗뿙껛軝鋟跡苣ꇥ跧蓩觫鳭釯黱뇳鯵鷷裹鯻鯽滿愁紃䤅砇漉縋漍搏笑笓砕䜗嬙⬛✝ሟᐡ", a_)))
					{
						num = (short)291635202;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_634;
				case 1:
					goto IL_546;
				case 2:
					this.trkEmerProfGeneralEmergencyOperation_A7926 = new global::AcpBusinessLayer.AcpSparseLOVField(1, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.LOVs.indexTrkEmerProfGeneralEmergencyOperation_A7926LovStrs, global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.LOVs.idTrkEmerProfGeneralEmergencyOperation_A7926LovStrs), this, global::AllFeatures.CodeplugGuid.b("蓏ꃑ뿓鏕뗗뿙껛軝鋟跡苣ꇥ跧蓩觫鳭釯黱뇳鯵鷷裹鯻鯽滿愁紃䤅砇漉縋漍搏笑笓砕䜗嬙⬛✝ሟᐡ", a_), global::CommonResources.AcgResources.ID_EMERGENCYOPERATION, global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.LOVs.TrkEmerProfGeneralEmergencyOperation_A7926LovStrs);
					this.trkEmerProfGeneralEmergencyOperation_A7926.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkEmerProfGeneralEmergencyOperation_A7926.DataTransferOrder = 3;
					num = (short)728694838;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蓏ꃑ뿓鏕뗗뿙껛軝鋟跡苣ꇥ跧蓩觫鳭釯黱뇳鯵鷷裹鯻鯽滿愁紃刅椇昉朋氍焏焑缓䤕夗⌙⸛⠝᠟", a_)))
					{
						num = (short)740098085;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_9EA;
				case 4:
					goto IL_C44;
				case 5:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蓏ꃑ뿓蛕뷗鿙釛駝ꛟ诡諣若ꗧ迩룫雭뗯鳱闳铵铷鿹ꏻ쫽㋿㬁㘃㜅", a_)))
					{
						num = (short)373751840;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_C91;
				case 6:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蓏ꃑ뿓鏕뗗뿙껛軝鋟跡苣ꇥ跧蓩觫鳭釯黱ꃳ軵ꣷ鿹軻韽濿昁眃挅欇㠉匋伍␏ℑ∓☕⤗", a_)))
					{
						num = (short)1782644781;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_CDE;
				case 7:
					goto IL_BF6;
				case 8:
					goto IL_862;
				case 9:
					this.trkEmerProfGeneralTxPeriodsec1_A7939 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("蓏ꃑ뿓鏕뗗뿙껛軝鋟跡苣ꇥ跧蓩觫鳭釯黱ꃳ軵ꣷ鿹軻韽濿昁眃挅欇㬉匋伍✏⬑✓⼕", a_), global::CommonResources.AcgResources.ID_AUTOTRANSMITHOTMICTXPERIODSECOLDFIELD, null, null, 0, 10);
					this.trkEmerProfGeneralTxPeriodsec1_A7939.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkEmerProfGeneralTxPeriodsec1_A7939.DataTransferOrder = 15;
					this.trkEmerProfGeneralTxPeriodsec1_A7939.ShowHexValue = false;
					num = (short)178126855;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					goto IL_1AE;
				case 11:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蓏ꃑ뿓蛕뷗鿙釛駝ꛟ诡諣若ꗧ迩뻫雭뗯鳱闳铵铷鿹ꏻ쫽㋿㬁㘃㔅", a_)))
					{
						num = (short)1838743568;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_949;
				case 12:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蓏ꃑ뿓鏕뗗뿙껛軝鋟跡苣꿥藧髩跫跭蓯뛱釳苵鷷駹裻韽濿氁䄃栅圇䬉㠋㴍⌏⬑☓", a_)))
					{
						num = (short)121700393;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_C44;
				case 13:
					goto IL_949;
				case 14:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蓏ꃑ뿓鏕뗗뿙껛軝鋟跡苣ꏥ藧迩黫觭闯鳱音迵냷闹裻뿽痿稁䤃漅欇唉䴋㨍∏ℑ␓☕", a_)))
					{
						num = (short)730464307;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_307;
				case 15:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蓏ꃑ뿓鏕뗗뿙껛軝鋟跡ꇣ该跧飩诫语黯釱跳럵跷軹鏻꫽狿持樃甅攇按砋䌍缏瘑焓䤕夗⠙⸛⬝ᘟᔡ", a_)))
					{
						num = (short)463077399;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_7EF;
				case 16:
					this.trkPeEMGFindMeRxEnable_42923 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("蓏ꃑ뿓蛕뷗鿙釛駝ꛟ诡諣若ꗧ迩뻫雭뗯鳱闳铵铷鿹ꏻ쫽㋿㬁㘃㔅", a_), global::CommonResources.AcgResources.ID_EMERGENCYFINDMERECEIVEENABLE);
					this.trkPeEMGFindMeRxEnable_42923.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.trkPeEMGFindMeRxEnable_42923.DataTransferOrder = 26;
					num = (short)588578829;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					goto IL_B08;
				case 18:
					this.trkEmerProfGeneralRetryCounter_A8951 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("蓏ꃑ뿓鏕뗗뿙껛軝鋟跡苣ꇥ跧蓩觫鳭釯黱꛳鏵賷裹藻뷽濿省樃爅洇砉匋伍⠏⬑ℓ✕", a_), global::CommonResources.AcgResources.ID_RETRYCOUNTER, global::CommonResources.AcgResources.ID_INFINITE, null, 0, 1);
					this.trkEmerProfGeneralRetryCounter_A8951.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkEmerProfGeneralRetryCounter_A8951.DataTransferOrder = 13;
					this.trkEmerProfGeneralRetryCounter_A8951.ShowHexValue = false;
					num = (short)472449066;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 19:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("闏뿑뇓ꓕ뿗뿙닛뷝駟꟡鳣迥鳧ꗩ苫귭飯鏱髳飵鷷雹뿻雽懿氁挃挅圇㸉㼋㬍⠏⨑", a_)))
					{
						num = (short)1494024227;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_6D8;
				case 20:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蓏ꃑ뿓鏕뗗뿙껛軝鋟跡苣ꇥ跧蓩觫鳭釯黱鿳鏵臷闹髻꫽狿省樃洅愇搉欋䬍紏眑易焕紗琙缛朝瀟倡䬣䀥䄧䘩䤫崭漯猱Գ༵షହԻ", a_)))
					{
						num = (short)1393623089;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_546;
				case 21:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蓏ꃑ뿓鏕뗗뿙껛軝鋟跡苣ꇥ跧蓩觫鳭釯黱꛳鏵闷闹裻鯽䇿愁瀃漅縇欉砋服缏簑儓笕紗栙笛笝丟䄡崣", a_)))
					{
						num = (short)1629028400;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_D7C;
				case 22:
					goto IL_541;
				case 23:
					this.trkEmerProEmergencyAutoTransmitMode_A22567 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.LOVs.indexTrkEmerProEmergencyAutoTransmitMode_A22567LovStrs, global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.LOVs.idTrkEmerProEmergencyAutoTransmitMode_A22567LovStrs), this, global::AllFeatures.CodeplugGuid.b("蓏ꃑ뿓鏕뗗뿙껛軝鋟跡ꇣ该跧飩诫语黯釱跳럵跷軹鏻꫽狿持樃甅攇按砋䌍缏瘑焓䤕夗⠙⸛⬝ᘟᔡ", a_), global::CommonResources.AcgResources.ID_AUTOTRANSMITEMERGENCYAUTOTRANSMITMODE, global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.LOVs.TrkEmerProEmergencyAutoTransmitMode_A22567LovStrs);
					this.trkEmerProEmergencyAutoTransmitMode_A22567.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkEmerProEmergencyAutoTransmitMode_A22567.DataTransferOrder = 14;
					this.trkEmerProEmergencyAutoTransmitMode_A22567.EvaluateRecRefs = true;
					num = (short)1750073383;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 24:
					goto IL_6D8;
				case 25:
					switch (0)
					{
					case 0:
						goto IL_132;
					}
					continue;
				case 26:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蓏ꃑ뿓鏕뗗뿙껛軝鋟跡苣ꇥ跧蓩觫鳭釯黱꛳鏵賷裹藻뷽濿省樃爅洇砉匋伍⠏⬑ℓ✕", a_)))
					{
						num = (short)202965010;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1FB;
				case 27:
					this.trkEmerProfGeneralRevertPTTID_A12642 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("蓏ꃑ뿓鏕뗗뿙껛軝鋟跡苣ꇥ跧蓩觫鳭釯黱꛳鏵軷鿹軻諽僿嘁倃伅䰇唉䴋㼍∏␑–␕", a_), global::CommonResources.AcgResources.ID_REVERTPTTID);
					this.trkEmerProfGeneralRevertPTTID_A12642.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.trkEmerProfGeneralRevertPTTID_A12642.DataTransferOrder = 2;
					num = (short)1771765807;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 28:
					goto IL_CDE;
				case 29:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蓏ꃑ뿓鏕뗗뿙껛軝鋟跡苣ꇥ跧蓩觫鳭釯黱꛳鏵軷鿹軻諽僿嘁倃伅䰇唉䴋㼍∏␑–␕", a_)))
					{
						num = (short)204800027;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_8B0;
				case 30:
				{
					num = (short)1348970509;
					short num4 = num;
					num = (short)884910093;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_B08;
					default:
						num = (short)2039939072;
						if (num != 0)
						{
						}
						if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蓏ꃑ뿓鏕뗗뿙껛軝鋟跡苣ꇥ跧蓩觫鳭釯黱럳駵雷觹鏻鋽旿䌁會洅娇漉紋笍礏怑焓爕䜗嬙⬛⤝ᄟအ", a_)))
						{
							num = (short)1974272046;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8FC;
					}
					break;
				}
				case 31:
					goto IL_307;
				case 32:
					this.trkPeEMGFindMeTxEnable_42921 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("蓏ꃑ뿓蛕뷗鿙釛駝ꛟ诡諣若ꗧ迩룫雭뗯鳱闳铵铷鿹ꏻ쫽㋿㬁㘃㜅", a_), global::CommonResources.AcgResources.ID_EMERGENCYFINDMETRANSMITENABLE);
					this.trkPeEMGFindMeTxEnable_42921.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.trkPeEMGFindMeTxEnable_42921.DataTransferOrder = 25;
					num = (short)1781596213;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 33:
					this.trkEmerProfGeneralTxPeriodsec2_A9132 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("蓏ꃑ뿓鏕뗗뿙껛軝鋟跡苣ꇥ跧蓩觫鳭釯黱ꃳ軵ꣷ鿹軻韽濿昁眃挅欇㠉匋伍⤏⌑✓␕", a_), global::CommonResources.AcgResources.ID_AUTOTRANSMITSILENTAUDIOTXPERIODSEC, null, null, 0, 1);
					this.trkEmerProfGeneralTxPeriodsec2_A9132.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkEmerProfGeneralTxPeriodsec2_A9132.DataTransferOrder = 16;
					this.trkEmerProfGeneralTxPeriodsec2_A9132.ShowHexValue = false;
					num = (short)731054090;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 34:
					if (producerFields != null)
					{
						num = (short)257687569;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_D7C;
				case 35:
					this.emergencyExitOnChannelChange_43588 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("闏뿑뇓ꓕ뿗뿙닛뷝駟꟡鳣迥鳧ꗩ苫귭飯鏱髳飵鷷雹뿻雽懿氁挃挅圇㸉㼋㬍⠏⨑", a_), global::CommonResources.AcgResources.ID_EMERGENCYEXITONCHANNELCHANGE);
					this.emergencyExitOnChannelChange_43588.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.emergencyExitOnChannelChange_43588.DataTransferOrder = 12;
					num = (short)420610072;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 36:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蓏ꃑ뿓鏕뗗뿙껛軝鋟跡苣ꇥ跧蓩觫鳭釯黱ꃳ軵ꣷ鿹軻韽濿昁眃挅欇㠉匋伍⤏⌑✓␕", a_)))
					{
						num = (short)133234721;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1AE;
				case 37:
					this.trkEmerProfGeneralEmergencyTalkback_A9268 = new global::AcpBusinessLayer.AcpSparseLOVField(1, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.LOVs.indexTrkEmerProfGeneralEmergencyTalkback_A9268LovStrs, global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.LOVs.idTrkEmerProfGeneralEmergencyTalkback_A9268LovStrs), this, global::AllFeatures.CodeplugGuid.b("蓏ꃑ뿓鏕뗗뿙껛軝鋟跡苣ꇥ跧蓩觫鳭釯黱뇳鯵鷷裹鯻鯽滿愁紃刅椇昉朋氍焏焑缓䤕夗⌙⸛⠝᠟", a_), global::CommonResources.AcgResources.ID_EMERGENCYTALKBACK, global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.LOVs.TrkEmerProfGeneralEmergencyTalkback_A9268LovStrs);
					this.trkEmerProfGeneralEmergencyTalkback_A9268.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkEmerProfGeneralEmergencyTalkback_A9268.DataTransferOrder = 1;
					this.trkEmerProfGeneralEmergencyTalkback_A9268.EvaluateRecRefs = true;
					num = (short)263258152;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 38:
					num = (short)1434255394;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 39:
					goto IL_7EF;
				case 40:
					goto IL_9EA;
				case 41:
					this.trkEmerProfImpactDetectionEn_A43392 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("蓏ꃑ뿓鏕뗗뿙껛軝鋟跡苣꿥藧髩跫跭蓯뛱釳苵鷷駹裻韽濿氁䄃栅圇䬉㠋㴍⌏⬑☓", a_), global::CommonResources.AcgResources.ID_IMPACTDETECTIONENABLE);
					this.trkEmerProfImpactDetectionEn_A43392.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkEmerProfImpactDetectionEn_A43392.DataTransferOrder = 22;
					num = (short)1398865924;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 42:
					goto IL_1FB;
				case 43:
					num = (short)977338369;
					if (num != 0)
					{
					}
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蓏ꃑ뿓鏕뗗뿙껛軝鋟跡苣ꇥ跧蓩觫鳭釯黱ꃳ軵ꣷ鿹軻韽濿昁眃挅欇㬉匋伍✏⬑✓⼕", a_)))
					{
						num = (short)1371734025;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_BF6;
				case 44:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蓏ꃑ뿓蛕뷗꣙釛뿝軟ꛡ诣釥蛧꿩苫迭鋯黱釳꧵쳷죹쳻췽㧿", a_)))
					{
						num = (short)247136308;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_862;
				case 45:
					this.trkEmerProfGeneralTxPeriodsec2_A43601 = new global::AcpBusinessLayer.AcpSimpleRangeField(10, this, global::AllFeatures.CodeplugGuid.b("蓏ꃑ뿓鏕뗗뿙껛軝鋟跡苣ꇥ跧蓩觫鳭釯黱ꃳ軵ꣷ鿹軻韽濿昁眃挅欇㠉匋伍␏ℑ∓☕⤗", a_), global::CommonResources.AcgResources.ID_AUTOTRANSMITHOTMICTXPERIODSEC, null, null, 0, 1);
					this.trkEmerProfGeneralTxPeriodsec2_A43601.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkEmerProfGeneralTxPeriodsec2_A43601.DataTransferOrder = 17;
					this.trkEmerProfGeneralTxPeriodsec2_A43601.ShowHexValue = false;
					num = (short)237895708;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 46:
					this.trkEmerProfGeneralConsoleAckRequired_A7712 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("蓏ꃑ뿓鏕뗗뿙껛軝鋟跡苣ꇥ跧蓩觫鳭釯黱럳駵雷觹鏻鋽旿䌁會洅娇漉紋笍礏怑焓爕䜗嬙⬛⤝ᄟအ", a_), global::CommonResources.AcgResources.ID_CONSOLEACKREQUIRED);
					this.trkEmerProfGeneralConsoleAckRequired_A7712.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkEmerProfGeneralConsoleAckRequired_A7712.DataTransferOrder = 4;
					num = (short)1961099314;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 47:
					goto IL_8B0;
				case 48:
					this.trkEmerProfGeneralRemoteActivationEmergency = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("蓏ꃑ뿓鏕뗗뿙껛軝鋟跡苣ꇥ跧蓩觫鳭釯黱꛳鏵闷闹裻鯽䇿愁瀃漅縇欉砋服缏簑儓笕紗栙笛笝丟䄡崣", a_), global::CommonResources.AcgResources.ID_REMOTEEMERGENCYACTIVATION, global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.LOVs.TrkEmerProfGeneralRemoteActivationEmergencyLovStrs);
					this.trkEmerProfGeneralRemoteActivationEmergency.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkEmerProfGeneralRemoteActivationEmergency.DataTransferOrder = 31;
					num = (short)712441878;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 49:
					this.trkEmerProfGeneralkeyofTrunkingEmergencyProfiles_A19419 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("蓏ꃑ뿓鏕뗗뿙껛軝鋟跡苣ꇥ跧蓩觫鳭釯黱鿳鏵臷闹髻꫽狿省樃洅愇搉欋䬍紏眑易焕紗琙缛朝瀟倡䬣䀥䄧䘩䤫崭漯猱Գ༵షହԻ", a_), global::CommonResources.AcgResources.ID_TRUNKINGEMERGENCYPROFILES, 14);
					this.trkEmerProfGeneralkeyofTrunkingEmergencyProfiles_A19419.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.trkEmerProfGeneralkeyofTrunkingEmergencyProfiles_A19419.DataTransferOrder = 7;
					num = (short)1578237953;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 50:
					goto IL_8FC;
				case 51:
					this.trkEmerProfEmergencyHotAuxMic_A42300 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.LOVs.indexTrkEmerProfEmergencyHotAuxMic_A42300LovStrs, global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.LOVs.idTrkEmerProfEmergencyHotAuxMic_A42300LovStrs), this, global::AllFeatures.CodeplugGuid.b("蓏ꃑ뿓鏕뗗뿙껛軝鋟跡苣ꏥ藧迩黫觭闯鳱音迵냷闹裻뿽痿稁䤃漅欇唉䴋㨍∏ℑ␓☕", a_), global::CommonResources.AcgResources.ID_AUTOTRANSMITHOTAUXMICACTIVATION, global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.LOVs.TrkEmerProfEmergencyHotAuxMic_A42300LovStrs);
					this.trkEmerProfEmergencyHotAuxMic_A42300.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkEmerProfEmergencyHotAuxMic_A42300.DataTransferOrder = 30;
					num = (short)317325343;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 52:
					this.trkPerManDownEnable_42039 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("蓏ꃑ뿓蛕뷗꣙釛뿝軟ꛡ诣釥蛧꿩苫迭鋯黱釳꧵쳷죹쳻췽㧿", a_), global::CommonResources.AcgResources.ID_MANDOWNENABLE);
					this.trkPerManDownEnable_42039.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.trkPerManDownEnable_42039.DataTransferOrder = 18;
					num = (short)1271922696;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 53:
					goto IL_C91;
				case 54:
					goto IL_634;
				}
				IL_132:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)2051342374;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_1AE:
				num = (short)1375404076;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_1FB:
				num = (short)1857093635;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_307:
				num = (short)922353669;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_546:
				num = (short)1927675919;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_634:
				num = (short)1324285978;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_6D8:
				num = (short)403963910;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_7EF:
				num = (short)1964572715;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_862:
				num = (short)1352138766;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_8B0:
				num = (short)1943928852;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_8FC:
				num = (short)1042415616;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_949:
				num = (short)822280204;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_9EA:
				num = (short)1531641885;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_B08:
				num = (short)1829437470;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_BF6:
				num = (short)642449444;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_C44:
				num = (short)651690003;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_C91:
				num = (short)1035993099;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_CDE:
				num = (short)1189347349;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_541:
			IL_D7C:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("韏럑뫓돕꫗믙냛", a_);
			base.Id = 10186;
			base.UIName = global::CommonResources.AcgResources.ID_GENERAL;
			base.DataTransferOrder = 1;
		}

		// Token: 0x0600963C RID: 38460 RVA: 0x008D477C File Offset: 0x008D297C
		public override void PopulateReferences()
		{
			short num = (short)355754290;
			short num2 = num;
			num = (short)722231602;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1267728384;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1839988737;
			if (num != 0)
			{
			}
			num = (short)2134245376;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600963D RID: 38461 RVA: 0x008D4824 File Offset: 0x008D2A24
		public override void DropReferences()
		{
			short num = (short)1966878309;
			short num2 = num;
			num = (short)1258761829;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1071448064;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)481886209;
			if (num != 0)
			{
			}
			num = (short)874840064;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600963E RID: 38462 RVA: 0x008D48CC File Offset: 0x008D2ACC
		public override void SetConstraints()
		{
			short num = (short)529051920;
			short num2 = num;
			num = (short)1950527760;
			switch (num2 == num)
			{
			default:
			{
				num = (short)800653312;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)80871425;
			if (num != 0)
			{
			}
			num = (short)481427456;
			if (num != 0)
			{
			}
			this.trkEmerProfGeneralConsoleAckRequired_A7712.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfilesConstraints.ConEmerAlarmIsEnabled);
			this.trkEmerProfGeneralEmergencyOperation_A7926.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfilesConstraints.conEmergencyOpCallOnly);
			this.trkEmerProfGeneralEmergencyTalkback_A9268.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfilesConstraints.ConTriggerTrkPerApplicableConstraint);
			this.trkEmerProEmergencyAutoTransmitMode_A22567.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfilesConstraints.conAutoTransmitModeIsValid);
			this.trkEmerProfGeneralTxPeriodsec1_A7939.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfilesConstraints.conAutoTransmitModeIsHotMicEmergency);
			this.trkEmerProfGeneralTxPeriodsec2_A9132.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfilesConstraints.conAutoTransmitModeIsEmerViaSilentAudio);
			this.trkPerManDownEnable_42039.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfilesConstraints.ConPerEmerProfIsSelected);
			this.trkEmerProfEmergencyHotAuxMic_A42300.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfilesConstraints.conAutoModeIsHotMicEmergencyForTRK);
			this.trkEmerProfImpactDetectionEn_A43392.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfilesConstraints.conImpDetectApplicable);
			this.trkEmerProfGeneralTxPeriodsec2_A43601.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfilesConstraints.conAutoTransmitModeIsHotMicEmergency);
			this.trkEmerProfGeneralTxPeriodsec2_A43601.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfilesConstraints.conSetValueTrkHotMicTxPeriod);
		}

		// Token: 0x0600963F RID: 38463 RVA: 0x008D4A70 File Offset: 0x008D2C70
		public override void SetupDependencies()
		{
			short num = (short)454230017;
			if (num != 0)
			{
			}
			num = (short)364707840;
			short num2 = num;
			num = (short)1199590932;
			short num3 = num;
			num = (short)1885163028;
			switch (num3 == num)
			{
			}
			num = (short)207159296;
			if (num != 0)
			{
			}
			this.trkEmerProfGeneralEmergencyOperation_A7926.AddDependentObject(this.trkEmerProfGeneralConsoleAckRequired_A7712);
			this.RefEmergencyWide.General.EmerWideGeneralSilentAlarm_A9130.AddDependentObject(this.trkEmerProfGeneralEmergencyOperation_A7926);
			this.trkEmerProfGeneralEmergencyOperation_A7926.AddDependentObject(this.trkEmerProEmergencyAutoTransmitMode_A22567);
			this.trkEmerProfGeneralRevertPTTID_A12642.AddDependentObject(this.trkEmerProEmergencyAutoTransmitMode_A22567);
			this.trkEmerProfGeneralConsoleAckRequired_A7712.AddDependentObject(this.trkEmerProEmergencyAutoTransmitMode_A22567);
			this.RefRadioWide.Labtool.RadWideLabtoolEmergencyCallOnlywithHotMicCapable_A43162.AddDependentObject(this.trkEmerProEmergencyAutoTransmitMode_A22567);
			this.trkEmerProEmergencyAutoTransmitMode_A22567.AddDependentObject(this.trkEmerProfGeneralTxPeriodsec1_A7939);
			this.trkEmerProfGeneralEmergencyOperation_A7926.AddDependentObject(this.trkEmerProfGeneralTxPeriodsec1_A7939);
			this.trkEmerProfGeneralRevertPTTID_A12642.AddDependentObject(this.trkEmerProfGeneralTxPeriodsec1_A7939);
			this.trkEmerProfGeneralConsoleAckRequired_A7712.AddDependentObject(this.trkEmerProfGeneralTxPeriodsec1_A7939);
			this.RefRadioWide.Labtool.RadWideLabtoolEmergencyCallOnlywithHotMicCapable_A43162.AddDependentObject(this.trkEmerProfGeneralTxPeriodsec1_A7939);
			this.trkEmerProEmergencyAutoTransmitMode_A22567.AddDependentObject(this.trkEmerProfGeneralTxPeriodsec2_A9132);
			this.trkEmerProfGeneralEmergencyOperation_A7926.AddDependentObject(this.trkEmerProfGeneralTxPeriodsec2_A9132);
			this.trkEmerProfGeneralRevertPTTID_A12642.AddDependentObject(this.trkEmerProfGeneralTxPeriodsec2_A9132);
			this.trkEmerProfGeneralConsoleAckRequired_A7712.AddDependentObject(this.trkEmerProfGeneralTxPeriodsec2_A9132);
			this.RefRadioWide.Labtool.RadWideLabtoolEmergencyCallOnlywithHotMicCapable_A43162.AddDependentObject(this.trkEmerProfGeneralTxPeriodsec2_A9132);
			this.RefEmergencyWide.ManDown.ManDownConfigurabilityGranularityLevel_42057.AddDependentObject(this.trkPerManDownEnable_42039);
			this.RefEmergencyWide.ManDown.EmerWideManDownTrigger_A40001.AddDependentObject(this.trkPerManDownEnable_42039);
			this.trkEmerProEmergencyAutoTransmitMode_A22567.AddDependentObject(this.trkEmerProfEmergencyHotAuxMic_A42300);
			this.RefEmergencyWide.EmergencyWideImpactDetection.EmerWideImpactDetectionConfigLevel_A43384.AddDependentObject(this.trkEmerProfImpactDetectionEn_A43392);
			this.trkEmerProEmergencyAutoTransmitMode_A22567.AddDependentObject(this.trkEmerProfGeneralTxPeriodsec2_A43601);
			this.trkEmerProfGeneralEmergencyOperation_A7926.AddDependentObject(this.trkEmerProfGeneralTxPeriodsec2_A43601);
			this.trkEmerProfGeneralRevertPTTID_A12642.AddDependentObject(this.trkEmerProfGeneralTxPeriodsec2_A43601);
			this.trkEmerProfGeneralConsoleAckRequired_A7712.AddDependentObject(this.trkEmerProfGeneralTxPeriodsec2_A43601);
			this.RefRadioWide.Labtool.RadWideLabtoolEmergencyCallOnlywithHotMicCapable_A43162.AddDependentObject(this.trkEmerProfGeneralTxPeriodsec2_A43601);
			this.trkEmerProfGeneralTxPeriodsec1_A7939.AddDependentObject(this.trkEmerProfGeneralTxPeriodsec2_A43601);
		}

		// Token: 0x17004B6E RID: 19310
		// (get) Token: 0x06009640 RID: 38464 RVA: 0x008D4D3C File Offset: 0x008D2F3C
		public bool HasDiffs
		{
			get
			{
				short num = (short)808750735;
				short num2 = num;
				num = (short)763727503;
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
				num = (short)2032992257;
				if (num != 0)
				{
				}
				num = (short)513146880;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17004B6F RID: 19311
		// (get) Token: 0x06009641 RID: 38465 RVA: 0x008D4DF0 File Offset: 0x008D2FF0
		// (set) Token: 0x06009642 RID: 38466 RVA: 0x008D4EA4 File Offset: 0x008D30A4
		public bool TrkEmerProfGeneralConsoleAckRequired_A7712Value
		{
			get
			{
				short num = (short)563676988;
				short num2 = num;
				num = (short)377554748;
				switch (num2 == num)
				{
				default:
				{
					num = (short)88080384;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1660485633;
				if (num != 0)
				{
				}
				num = (short)395247616;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralConsoleAckRequired_A7712.Value;
			}
			set
			{
				short num = (short)28779530;
				short num2 = num;
				num = (short)2139759626;
				switch (num2 == num)
				{
				default:
				{
					num = (short)508231680;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1102774273;
				if (num != 0)
				{
				}
				num = (short)237830144;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralConsoleAckRequired_A7712.Value = value;
			}
		}

		// Token: 0x17004B70 RID: 19312
		// (get) Token: 0x06009643 RID: 38467 RVA: 0x008D4F5C File Offset: 0x008D315C
		public global::AcpBusinessLayer.AcpField<bool> TrkEmerProfGeneralConsoleAckRequired_A7712
		{
			get
			{
				short num = (short)884526993;
				short num2 = num;
				num = (short)1591791505;
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
				num = (short)1812987904;
				if (num != 0)
				{
				}
				num = (short)1312555009;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralConsoleAckRequired_A7712;
			}
		}

		// Token: 0x17004B71 RID: 19313
		// (get) Token: 0x06009644 RID: 38468 RVA: 0x008D500C File Offset: 0x008D320C
		// (set) Token: 0x06009645 RID: 38469 RVA: 0x008D50C0 File Offset: 0x008D32C0
		public bool TrkEmerProfGeneralConsoleAckRequired_A7712_UIValue
		{
			get
			{
				short num = (short)751885547;
				short num2 = num;
				num = (short)1996020971;
				switch (num2 == num)
				{
				default:
				{
					num = (short)553582592;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1467678721;
				if (num != 0)
				{
				}
				num = (short)463601664;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralConsoleAckRequired_A7712.Value;
			}
			set
			{
				short num = (short)683818740;
				short num2 = num;
				num = (short)1067073268;
				switch (num2 == num)
				{
				default:
				{
					num = (short)438566912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1376780289;
				if (num != 0)
				{
				}
				num = (short)705101824;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralConsoleAckRequired_A7712.Value = value;
			}
		}

		// Token: 0x17004B72 RID: 19314
		// (get) Token: 0x06009646 RID: 38470 RVA: 0x008D5174 File Offset: 0x008D3374
		// (set) Token: 0x06009647 RID: 38471 RVA: 0x008D5228 File Offset: 0x008D3428
		public bool TrkEmerProfGeneralConsoleAckRequired_A7712_Applicable
		{
			get
			{
				short num = (short)1749289475;
				short num2 = num;
				num = (short)1635715587;
				switch (num2 == num)
				{
				default:
				{
					num = (short)813563904;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)425000960;
				if (num != 0)
				{
				}
				num = (short)2127757313;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralConsoleAckRequired_A7712.Applicable;
			}
			set
			{
				short num = (short)2080165279;
				short num2 = num;
				num = (short)2078395807;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1238827008;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)489226240;
				if (num != 0)
				{
				}
				num = (short)2074869761;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralConsoleAckRequired_A7712.Applicable = value;
			}
		}

		// Token: 0x17004B73 RID: 19315
		// (get) Token: 0x06009648 RID: 38472 RVA: 0x008D52E0 File Offset: 0x008D34E0
		// (set) Token: 0x06009649 RID: 38473 RVA: 0x008D5394 File Offset: 0x008D3594
		public bool TrkEmerProfGeneralConsoleAckRequired_A7712_Valid
		{
			get
			{
				short num = (short)1294467073;
				if (num != 0)
				{
				}
				num = (short)753205248;
				short num2 = num;
				num = (short)1239225024;
				short num3 = num;
				num = (short)957682368;
				switch (num3 == num)
				{
				}
				num = (short)1672478720;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralConsoleAckRequired_A7712.Valid;
			}
			set
			{
				short num = (short)333822750;
				short num2 = num;
				num = (short)1207548702;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1193410560;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)299827201;
				if (num != 0)
				{
				}
				num = (short)277938176;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralConsoleAckRequired_A7712.Valid = value;
			}
		}

		// Token: 0x17004B74 RID: 19316
		// (get) Token: 0x0600964A RID: 38474 RVA: 0x008D544C File Offset: 0x008D364C
		// (set) Token: 0x0600964B RID: 38475 RVA: 0x008D5500 File Offset: 0x008D3700
		public bool TrkEmerProfGeneralConsoleAckRequired_A7712_Visible
		{
			get
			{
				short num = (short)1431909383;
				short num2 = num;
				num = (short)1328821255;
				switch (num2 == num)
				{
				default:
				{
					num = (short)869662720;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1653014529;
				if (num != 0)
				{
				}
				num = (short)82575360;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralConsoleAckRequired_A7712.Visible;
			}
			set
			{
				short num = (short)1178801687;
				short num2 = num;
				num = (short)1702827543;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1441398784;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1136066561;
				if (num != 0)
				{
				}
				num = (short)590544896;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralConsoleAckRequired_A7712.Visible = value;
			}
		}

		// Token: 0x17004B75 RID: 19317
		// (get) Token: 0x0600964C RID: 38476 RVA: 0x008D55B4 File Offset: 0x008D37B4
		// (set) Token: 0x0600964D RID: 38477 RVA: 0x008D5668 File Offset: 0x008D3868
		public bool TrkEmerProfGeneralConsoleAckRequired_A7712_Editable
		{
			get
			{
				short num = (short)173139101;
				short num2 = num;
				num = (short)1256776861;
				switch (num2 == num)
				{
				default:
				{
					num = (short)129761280;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2055536640;
				if (num != 0)
				{
				}
				num = (short)963575809;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralConsoleAckRequired_A7712.Editable;
			}
			set
			{
				short num = (short)1147255233;
				short num2 = num;
				num = (short)1683012033;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1947860992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)523960321;
				if (num != 0)
				{
				}
				num = (short)138215424;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralConsoleAckRequired_A7712.Editable = value;
			}
		}

		// Token: 0x17004B76 RID: 19318
		// (get) Token: 0x0600964E RID: 38478 RVA: 0x008D5724 File Offset: 0x008D3924
		internal string TrkEmerProfGeneralConsoleAckRequired_A7712_UILabel
		{
			get
			{
				short num = (short)897056769;
				if (num != 0)
				{
				}
				num = (short)548077568;
				short num2 = num;
				num = (short)1923350005;
				short num3 = num;
				num = (short)240188917;
				switch (num3 == num)
				{
				}
				num = (short)2027880448;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralConsoleAckRequired_A7712.UIName;
			}
		}

		// Token: 0x17004B77 RID: 19319
		// (get) Token: 0x0600964F RID: 38479 RVA: 0x008D57D8 File Offset: 0x008D39D8
		// (set) Token: 0x06009650 RID: 38480 RVA: 0x008D5888 File Offset: 0x008D3A88
		internal bool TrkEmerProfGeneralConsoleAckRequired_A7712_HiddenStatic
		{
			get
			{
				short num = (short)1711325476;
				short num2 = num;
				num = (short)523616548;
				switch (num2 == num)
				{
				default:
				{
					num = (short)925106176;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1808400384;
				if (num != 0)
				{
				}
				num = (short)1327955969;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralConsoleAckRequired_A7712.HiddenStatic;
			}
			set
			{
				short num = (short)1452141491;
				short num2 = num;
				num = (short)1223551923;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1244921856;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1537540096;
				if (num != 0)
				{
				}
				num = (short)718798849;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralConsoleAckRequired_A7712.HiddenStatic = value;
			}
		}

		// Token: 0x17004B78 RID: 19320
		// (get) Token: 0x06009651 RID: 38481 RVA: 0x008D593C File Offset: 0x008D3B3C
		// (set) Token: 0x06009652 RID: 38482 RVA: 0x008D59F0 File Offset: 0x008D3BF0
		internal bool TrkEmerProfGeneralConsoleAckRequired_A7712_HiddenDynamic
		{
			get
			{
				short num = (short)83476372;
				short num2 = num;
				num = (short)1689108372;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1988296704;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)529793025;
				if (num != 0)
				{
				}
				num = (short)1847328768;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralConsoleAckRequired_A7712.HiddenDynamic;
			}
			set
			{
				short num = (short)295508582;
				short num2 = num;
				num = (short)589765222;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1716322304;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)541851648;
				if (num != 0)
				{
				}
				num = (short)362545153;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralConsoleAckRequired_A7712.HiddenDynamic = value;
			}
		}

		// Token: 0x17004B79 RID: 19321
		// (get) Token: 0x06009653 RID: 38483 RVA: 0x008D5AA8 File Offset: 0x008D3CA8
		public bool TrkEmerProfGeneralConsoleAckRequired_A7712_HasDiffs
		{
			get
			{
				short num = (short)16344794;
				short num2 = num;
				num = (short)1045849818;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1939275776;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2097348609;
				if (num != 0)
				{
				}
				num = (short)1768030208;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralConsoleAckRequired_A7712._HasDiffs;
			}
		}

		// Token: 0x17004B7A RID: 19322
		// (get) Token: 0x06009654 RID: 38484 RVA: 0x008D5B5C File Offset: 0x008D3D5C
		// (set) Token: 0x06009655 RID: 38485 RVA: 0x008D5C10 File Offset: 0x008D3E10
		public int TrkEmerProfGeneralEmergencyOperation_A7926Value
		{
			get
			{
				short num = (short)979988971;
				short num2 = num;
				num = (short)1294627307;
				switch (num2 == num)
				{
				default:
				{
					num = (short)688128000;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1517748224;
				if (num != 0)
				{
				}
				num = (short)1009254401;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralEmergencyOperation_A7926.Value;
			}
			set
			{
				short num = (short)212213732;
				short num2 = num;
				num = (short)1997545444;
				switch (num2 == num)
				{
				default:
				{
					num = (short)713162752;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1063714817;
				if (num != 0)
				{
				}
				num = (short)490930176;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralEmergencyOperation_A7926.Value = value;
			}
		}

		// Token: 0x17004B7B RID: 19323
		// (get) Token: 0x06009656 RID: 38486 RVA: 0x008D5CC8 File Offset: 0x008D3EC8
		// (set) Token: 0x06009657 RID: 38487 RVA: 0x008D5D7C File Offset: 0x008D3F7C
		public string TrkEmerProfGeneralEmergencyOperation_A7926_UIValue
		{
			get
			{
				short num = (short)1157387037;
				short num2 = num;
				num = (short)460673821;
				switch (num2 == num)
				{
				default:
				{
					num = (short)533069824;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)595066881;
				if (num != 0)
				{
				}
				num = (short)1784020992;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralEmergencyOperation_A7926.UIValue;
			}
			set
			{
				short num = (short)1505081452;
				short num2 = num;
				num = (short)280148076;
				switch (num2 == num)
				{
				}
				num = (short)183828480;
				short num3 = num;
				num = (short)1409613825;
				if (num != 0)
				{
				}
				num = (short)2129854464;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralEmergencyOperation_A7926.UIValue = value;
			}
		}

		// Token: 0x17004B7C RID: 19324
		// (get) Token: 0x06009658 RID: 38488 RVA: 0x008D5E34 File Offset: 0x008D4034
		public global::AcpBusinessLayer.AcpListField TrkEmerProfGeneralEmergencyOperation_A7926
		{
			get
			{
				short num = (short)1457603321;
				short num2 = num;
				num = (short)2127839993;
				switch (num2 == num)
				{
				}
				num = (short)1212874752;
				short num3 = num;
				num = (short)159121408;
				if (num != 0)
				{
				}
				num = (short)2138177537;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralEmergencyOperation_A7926;
			}
		}

		// Token: 0x17004B7D RID: 19325
		// (get) Token: 0x06009659 RID: 38489 RVA: 0x008D5EE8 File Offset: 0x008D40E8
		// (set) Token: 0x0600965A RID: 38490 RVA: 0x008D5F9C File Offset: 0x008D419C
		public bool TrkEmerProfGeneralEmergencyOperation_A7926_Applicable
		{
			get
			{
				short num = (short)581056533;
				short num2 = num;
				num = (short)580466709;
				switch (num2 == num)
				{
				}
				num = (short)363593728;
				short num3 = num;
				num = (short)1986002945;
				if (num != 0)
				{
				}
				num = (short)1850474496;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralEmergencyOperation_A7926.Applicable;
			}
			set
			{
				short num = (short)1252666118;
				short num2 = num;
				num = (short)802695942;
				switch (num2 == num)
				{
				}
				num = (short)435355648;
				short num3 = num;
				num = (short)1826291713;
				if (num != 0)
				{
				}
				num = (short)266076160;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralEmergencyOperation_A7926.Applicable = value;
			}
		}

		// Token: 0x17004B7E RID: 19326
		// (get) Token: 0x0600965B RID: 38491 RVA: 0x008D6050 File Offset: 0x008D4250
		// (set) Token: 0x0600965C RID: 38492 RVA: 0x008D6108 File Offset: 0x008D4308
		public bool TrkEmerProfGeneralEmergencyOperation_A7926_Valid
		{
			get
			{
				short num = (short)948177465;
				short num2 = num;
				num = (short)820644409;
				switch (num2 == num)
				{
				}
				num = (short)1547436032;
				short num3 = num;
				num = (short)1363148801;
				if (num != 0)
				{
				}
				num = (short)2085355520;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralEmergencyOperation_A7926.Valid;
			}
			set
			{
				short num = (short)1773163814;
				short num2 = num;
				num = (short)747066662;
				switch (num2 == num)
				{
				}
				num = (short)1353252864;
				short num3 = num;
				num = (short)1353449472;
				if (num != 0)
				{
				}
				num = (short)1410203649;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralEmergencyOperation_A7926.Valid = value;
			}
		}

		// Token: 0x17004B7F RID: 19327
		// (get) Token: 0x0600965D RID: 38493 RVA: 0x008D61BC File Offset: 0x008D43BC
		// (set) Token: 0x0600965E RID: 38494 RVA: 0x008D626C File Offset: 0x008D446C
		public bool TrkEmerProfGeneralEmergencyOperation_A7926_Visible
		{
			get
			{
				short num = (short)1623009365;
				short num2 = num;
				num = (short)1069623381;
				switch (num2 == num)
				{
				}
				num = (short)959578112;
				short num3 = num;
				num = (short)2021982208;
				if (num != 0)
				{
				}
				num = (short)503316481;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralEmergencyOperation_A7926.Visible;
			}
			set
			{
				short num = (short)1891762177;
				if (num != 0)
				{
				}
				num = (short)1917452536;
				short num2 = num;
				num = (short)1817313528;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1197867008;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1529413632;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralEmergencyOperation_A7926.Visible = value;
			}
		}

		// Token: 0x17004B80 RID: 19328
		// (get) Token: 0x0600965F RID: 38495 RVA: 0x008D6324 File Offset: 0x008D4524
		// (set) Token: 0x06009660 RID: 38496 RVA: 0x008D63D8 File Offset: 0x008D45D8
		public bool TrkEmerProfGeneralEmergencyOperation_A7926_Editable
		{
			get
			{
				short num = (short)1436228108;
				short num2 = num;
				num = (short)895162892;
				switch (num2 == num)
				{
				}
				num = (short)1264254976;
				short num3 = num;
				num = (short)1496317953;
				if (num != 0)
				{
				}
				num = (short)1226309632;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralEmergencyOperation_A7926.Editable;
			}
			set
			{
				short num = (short)2026920729;
				short num2 = num;
				num = (short)1644321561;
				switch (num2 == num)
				{
				}
				num = (short)617480192;
				short num3 = num;
				num = (short)1558839296;
				if (num != 0)
				{
				}
				num = (short)1172701185;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralEmergencyOperation_A7926.Editable = value;
			}
		}

		// Token: 0x17004B81 RID: 19329
		// (get) Token: 0x06009661 RID: 38497 RVA: 0x008D6490 File Offset: 0x008D4690
		internal string TrkEmerProfGeneralEmergencyOperation_A7926_UILabel
		{
			get
			{
				short num = (short)1156259892;
				short num2 = num;
				num = (short)476651572;
				switch (num2 == num)
				{
				}
				num = (short)980025344;
				short num3 = num;
				num = (short)1492189185;
				if (num != 0)
				{
				}
				num = (short)2130837504;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralEmergencyOperation_A7926.UIName;
			}
		}

		// Token: 0x17004B82 RID: 19330
		// (get) Token: 0x06009662 RID: 38498 RVA: 0x008D6544 File Offset: 0x008D4744
		// (set) Token: 0x06009663 RID: 38499 RVA: 0x008D65F8 File Offset: 0x008D47F8
		internal bool TrkEmerProfGeneralEmergencyOperation_A7926_HiddenStatic
		{
			get
			{
				short num = (short)494617918;
				short num2 = num;
				num = (short)118900030;
				switch (num2 == num)
				{
				}
				num = (short)1681129472;
				short num3 = num;
				num = (short)274333697;
				if (num != 0)
				{
				}
				num = (short)1720451072;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralEmergencyOperation_A7926.HiddenStatic;
			}
			set
			{
				short num = (short)1376663900;
				short num2 = num;
				num = (short)843200860;
				switch (num2 == num)
				{
				}
				num = (short)2061107200;
				short num3 = num;
				num = (short)177602561;
				if (num != 0)
				{
				}
				num = (short)2026897408;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralEmergencyOperation_A7926.HiddenStatic = value;
			}
		}

		// Token: 0x17004B83 RID: 19331
		// (get) Token: 0x06009664 RID: 38500 RVA: 0x008D66AC File Offset: 0x008D48AC
		// (set) Token: 0x06009665 RID: 38501 RVA: 0x008D6764 File Offset: 0x008D4964
		internal bool TrkEmerProfGeneralEmergencyOperation_A7926_HiddenDynamic
		{
			get
			{
				short num = (short)1433748095;
				short num2 = num;
				num = (short)834159231;
				switch (num2 == num)
				{
				}
				num = (short)590348288;
				short num3 = num;
				num = (short)71827457;
				if (num != 0)
				{
				}
				num = (short)440532992;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralEmergencyOperation_A7926.HiddenDynamic;
			}
			set
			{
				short num = (short)1085079553;
				if (num != 0)
				{
				}
				num = (short)417751702;
				short num2 = num;
				num = (short)581395094;
				switch (num2 == num)
				{
				default:
				{
					num = (short)234029056;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)410517504;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralEmergencyOperation_A7926.HiddenDynamic = value;
			}
		}

		// Token: 0x17004B84 RID: 19332
		// (get) Token: 0x06009666 RID: 38502 RVA: 0x008D6818 File Offset: 0x008D4A18
		public bool TrkEmerProfGeneralEmergencyOperation_A7926_HasDiffs
		{
			get
			{
				short num = (short)2105269384;
				short num2 = num;
				num = (short)1861737608;
				switch (num2 == num)
				{
				}
				num = (short)1066008576;
				short num3 = num;
				num = (short)1355874305;
				if (num != 0)
				{
				}
				num = (short)467795968;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralEmergencyOperation_A7926._HasDiffs;
			}
		}

		// Token: 0x17004B85 RID: 19333
		// (get) Token: 0x06009667 RID: 38503 RVA: 0x008D68CC File Offset: 0x008D4ACC
		// (set) Token: 0x06009668 RID: 38504 RVA: 0x008D6980 File Offset: 0x008D4B80
		public int TrkEmerProfGeneralRetryCounter_A8951Value
		{
			get
			{
				short num = (short)363124334;
				short num2 = num;
				num = (short)1362810478;
				switch (num2 == num)
				{
				}
				num = (short)1400307712;
				short num3 = num;
				num = (short)1927020544;
				if (num != 0)
				{
				}
				num = (short)1532035073;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralRetryCounter_A8951.Value;
			}
			set
			{
				short num = (short)358576957;
				short num2 = num;
				num = (short)1591374653;
				switch (num2 == num)
				{
				}
				num = (short)1142292480;
				short num3 = num;
				num = (short)812515329;
				if (num != 0)
				{
				}
				num = (short)237764608;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralRetryCounter_A8951.Value = value;
			}
		}

		// Token: 0x17004B86 RID: 19334
		// (get) Token: 0x06009669 RID: 38505 RVA: 0x008D6A38 File Offset: 0x008D4C38
		public global::AcpBusinessLayer.AcpSimpleRangeField TrkEmerProfGeneralRetryCounter_A8951
		{
			get
			{
				short num = (short)596239848;
				short num2 = num;
				num = (short)575333864;
				switch (num2 == num)
				{
				}
				num = (short)1912274944;
				short num3 = num;
				num = (short)1471021057;
				if (num != 0)
				{
				}
				num = (short)215744512;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralRetryCounter_A8951;
			}
		}

		// Token: 0x17004B87 RID: 19335
		// (get) Token: 0x0600966A RID: 38506 RVA: 0x008D6AE4 File Offset: 0x008D4CE4
		// (set) Token: 0x0600966B RID: 38507 RVA: 0x008D6B9C File Offset: 0x008D4D9C
		public string TrkEmerProfGeneralRetryCounter_A8951_UIValue
		{
			get
			{
				short num = (short)1742305704;
				short num2 = num;
				num = (short)2017425832;
				switch (num2 == num)
				{
				}
				num = (short)795869184;
				short num3 = num;
				num = (short)32636929;
				if (num != 0)
				{
				}
				num = (short)1811742720;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralRetryCounter_A8951.UIValue;
			}
			set
			{
				short num = (short)644982175;
				short num2 = num;
				num = (short)656909727;
				switch (num2 == num)
				{
				}
				num = (short)1214709760;
				short num3 = num;
				num = (short)1707933697;
				if (num != 0)
				{
				}
				num = (short)101515264;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralRetryCounter_A8951.UIValue = value;
			}
		}

		// Token: 0x17004B88 RID: 19336
		// (get) Token: 0x0600966C RID: 38508 RVA: 0x008D6C50 File Offset: 0x008D4E50
		// (set) Token: 0x0600966D RID: 38509 RVA: 0x008D6D04 File Offset: 0x008D4F04
		internal int TrkEmerProfGeneralRetryCounter_A8951Min
		{
			get
			{
				short num = (short)552700820;
				short num2 = num;
				num = (short)109677460;
				switch (num2 == num)
				{
				}
				num = (short)1809514496;
				short num3 = num;
				num = (short)1207959552;
				if (num != 0)
				{
				}
				num = (short)1688993793;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralRetryCounter_A8951.Min;
			}
			set
			{
				short num = (short)322891988;
				short num2 = num;
				num = (short)1076949204;
				switch (num2 == num)
				{
				}
				num = (short)623968256;
				short num3 = num;
				num = (short)1106182145;
				if (num != 0)
				{
				}
				num = (short)1940979712;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralRetryCounter_A8951.Min = value;
			}
		}

		// Token: 0x17004B89 RID: 19337
		// (get) Token: 0x0600966E RID: 38510 RVA: 0x008D6DBC File Offset: 0x008D4FBC
		// (set) Token: 0x0600966F RID: 38511 RVA: 0x008D6E74 File Offset: 0x008D5074
		internal int TrkEmerProfGeneralRetryCounter_A8951Max
		{
			get
			{
				short num = (short)1095106561;
				if (num != 0)
				{
				}
				num = (short)1376482391;
				short num2 = num;
				num = (short)432632919;
				switch (num2 == num)
				{
				default:
				{
					num = (short)195690496;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)12845056;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralRetryCounter_A8951.Max;
			}
			set
			{
				short num = (short)804323329;
				if (num != 0)
				{
				}
				num = (short)1850400986;
				short num2 = num;
				num = (short)1982521562;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1543372800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1343684608;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralRetryCounter_A8951.Max = value;
			}
		}

		// Token: 0x17004B8A RID: 19338
		// (get) Token: 0x06009670 RID: 38512 RVA: 0x008D6F28 File Offset: 0x008D5128
		// (set) Token: 0x06009671 RID: 38513 RVA: 0x008D6FDC File Offset: 0x008D51DC
		internal int TrkEmerProfGeneralRetryCounter_A8951Step
		{
			get
			{
				short num = (short)1317011457;
				if (num != 0)
				{
				}
				num = (short)367793025;
				short num2 = num;
				num = (short)778048385;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1397293056;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2019557376;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralRetryCounter_A8951.StepSize;
			}
			set
			{
				short num = (short)880196407;
				short num2 = num;
				num = (short)28293943;
				switch (num2 == num)
				{
				}
				num = (short)387055616;
				short num3 = num;
				num = (short)1881997312;
				if (num != 0)
				{
				}
				num = (short)1833041921;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralRetryCounter_A8951.StepSize = value;
			}
		}

		// Token: 0x17004B8B RID: 19339
		// (get) Token: 0x06009672 RID: 38514 RVA: 0x008D7090 File Offset: 0x008D5290
		// (set) Token: 0x06009673 RID: 38515 RVA: 0x008D7144 File Offset: 0x008D5344
		public bool TrkEmerProfGeneralRetryCounter_A8951_Applicable
		{
			get
			{
				short num = (short)2083634265;
				short num2 = num;
				num = (short)1289600089;
				switch (num2 == num)
				{
				}
				num = (short)1900937216;
				short num3 = num;
				num = (short)2000158720;
				if (num != 0)
				{
				}
				num = (short)498663425;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralRetryCounter_A8951.Applicable;
			}
			set
			{
				short num = (short)1485808029;
				short num2 = num;
				num = (short)1621139869;
				switch (num2 == num)
				{
				}
				num = (short)200278016;
				short num3 = num;
				num = (short)328204289;
				if (num != 0)
				{
				}
				num = (short)1676804096;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralRetryCounter_A8951.Applicable = value;
			}
		}

		// Token: 0x17004B8C RID: 19340
		// (get) Token: 0x06009674 RID: 38516 RVA: 0x008D71F8 File Offset: 0x008D53F8
		// (set) Token: 0x06009675 RID: 38517 RVA: 0x008D72AC File Offset: 0x008D54AC
		public bool TrkEmerProfGeneralRetryCounter_A8951_Valid
		{
			get
			{
				short num = (short)1006900222;
				short num2 = num;
				num = (short)374084606;
				switch (num2 == num)
				{
				}
				num = (short)1973747712;
				short num3 = num;
				num = (short)752549889;
				if (num != 0)
				{
				}
				num = (short)170655744;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralRetryCounter_A8951.Valid;
			}
			set
			{
				short num = (short)389106230;
				short num2 = num;
				num = (short)699484726;
				switch (num2 == num)
				{
				}
				num = (short)2107768832;
				short num3 = num;
				num = (short)765263873;
				if (num != 0)
				{
				}
				num = (short)478740480;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralRetryCounter_A8951.Valid = value;
			}
		}

		// Token: 0x17004B8D RID: 19341
		// (get) Token: 0x06009676 RID: 38518 RVA: 0x008D7364 File Offset: 0x008D5564
		// (set) Token: 0x06009677 RID: 38519 RVA: 0x008D7418 File Offset: 0x008D5618
		public bool TrkEmerProfGeneralRetryCounter_A8951_Visible
		{
			get
			{
				short num = (short)659554305;
				if (num != 0)
				{
				}
				num = (short)533519400;
				short num2 = num;
				num = (short)261348392;
				switch (num2 == num)
				{
				default:
				{
					num = (short)480509952;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1696595968;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralRetryCounter_A8951.Visible;
			}
			set
			{
				short num = (short)1847029418;
				short num2 = num;
				num = (short)374435498;
				switch (num2 == num)
				{
				}
				num = (short)208470016;
				short num3 = num;
				num = (short)1241972736;
				if (num != 0)
				{
				}
				num = (short)1352204289;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralRetryCounter_A8951.Visible = value;
			}
		}

		// Token: 0x17004B8E RID: 19342
		// (get) Token: 0x06009678 RID: 38520 RVA: 0x008D74CC File Offset: 0x008D56CC
		// (set) Token: 0x06009679 RID: 38521 RVA: 0x008D7584 File Offset: 0x008D5784
		public bool TrkEmerProfGeneralRetryCounter_A8951_Editable
		{
			get
			{
				short num = (short)1969029121;
				if (num != 0)
				{
				}
				num = (short)864269343;
				short num2 = num;
				num = (short)1709093919;
				switch (num2 == num)
				{
				default:
				{
					num = (short)626524160;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)866975744;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralRetryCounter_A8951.Editable;
			}
			set
			{
				short num = (short)331377566;
				short num2 = num;
				num = (short)511798174;
				switch (num2 == num)
				{
				}
				num = (short)699662336;
				short num3 = num;
				num = (short)545062912;
				if (num != 0)
				{
				}
				num = (short)1344077825;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralRetryCounter_A8951.Editable = value;
			}
		}

		// Token: 0x17004B8F RID: 19343
		// (get) Token: 0x0600967A RID: 38522 RVA: 0x008D763C File Offset: 0x008D583C
		internal string TrkEmerProfGeneralRetryCounter_A8951_UILabel
		{
			get
			{
				short num = (short)553815192;
				short num2 = num;
				num = (short)1877970072;
				switch (num2 == num)
				{
				}
				num = (short)1007616000;
				short num3 = num;
				num = (short)1647247360;
				if (num != 0)
				{
				}
				num = (short)1510998017;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralRetryCounter_A8951.UIName;
			}
		}

		// Token: 0x17004B90 RID: 19344
		// (get) Token: 0x0600967B RID: 38523 RVA: 0x008D76F0 File Offset: 0x008D58F0
		// (set) Token: 0x0600967C RID: 38524 RVA: 0x008D77A4 File Offset: 0x008D59A4
		internal bool TrkEmerProfGeneralRetryCounter_A8951_HiddenStatic
		{
			get
			{
				short num = (short)1364918273;
				if (num != 0)
				{
				}
				num = (short)1324590293;
				short num2 = num;
				num = (short)1331537109;
				switch (num2 == num)
				{
				default:
				{
					num = (short)486408192;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2023555072;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralRetryCounter_A8951.HiddenStatic;
			}
			set
			{
				short num = (short)690492398;
				short num2 = num;
				num = (short)1852380142;
				switch (num2 == num)
				{
				}
				num = (short)868089856;
				short num3 = num;
				num = (short)1077280769;
				if (num != 0)
				{
				}
				num = (short)1449263104;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralRetryCounter_A8951.HiddenStatic = value;
			}
		}

		// Token: 0x17004B91 RID: 19345
		// (get) Token: 0x0600967D RID: 38525 RVA: 0x008D7858 File Offset: 0x008D5A58
		// (set) Token: 0x0600967E RID: 38526 RVA: 0x008D790C File Offset: 0x008D5B0C
		internal bool TrkEmerProfGeneralRetryCounter_A8951_HiddenDynamic
		{
			get
			{
				short num = (short)252510154;
				short num2 = num;
				num = (short)616890314;
				switch (num2 == num)
				{
				}
				num = (short)255459328;
				short num3 = num;
				num = (short)712507393;
				if (num != 0)
				{
				}
				num = (short)417202176;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralRetryCounter_A8951.HiddenDynamic;
			}
			set
			{
				short num = (short)1854537729;
				if (num != 0)
				{
				}
				num = (short)1132034169;
				short num2 = num;
				num = (short)1974433913;
				switch (num2 == num)
				{
				default:
				{
					num = (short)3276800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)388497408;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralRetryCounter_A8951.HiddenDynamic = value;
			}
		}

		// Token: 0x17004B92 RID: 19346
		// (get) Token: 0x0600967F RID: 38527 RVA: 0x008D79C0 File Offset: 0x008D5BC0
		public bool TrkEmerProfGeneralRetryCounter_A8951_HasDiffs
		{
			get
			{
				short num = (short)18350081;
				if (num != 0)
				{
				}
				num = (short)1991961194;
				short num2 = num;
				num = (short)1832643178;
				switch (num2 == num)
				{
				default:
				{
					num = (short)629538816;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)507510784;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralRetryCounter_A8951._HasDiffs;
			}
		}

		// Token: 0x17004B93 RID: 19347
		// (get) Token: 0x06009680 RID: 38528 RVA: 0x008D7A74 File Offset: 0x008D5C74
		// (set) Token: 0x06009681 RID: 38529 RVA: 0x008D7B28 File Offset: 0x008D5D28
		public int TrkEmerProfGeneralEmergencyTalkback_A9268Value
		{
			get
			{
				short num = (short)482064934;
				short num2 = num;
				num = (short)1080932902;
				switch (num2 == num)
				{
				}
				num = (short)1200488448;
				short num3 = num;
				num = (short)718209025;
				if (num != 0)
				{
				}
				num = (short)83361792;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralEmergencyTalkback_A9268.Value;
			}
			set
			{
				short num = (short)1714618369;
				if (num != 0)
				{
				}
				num = (short)918559227;
				short num2 = num;
				num = (short)1977817595;
				switch (num2 == num)
				{
				default:
				{
					num = (short)20971520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1453326336;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralEmergencyTalkback_A9268.Value = value;
			}
		}

		// Token: 0x17004B94 RID: 19348
		// (get) Token: 0x06009682 RID: 38530 RVA: 0x008D7BDC File Offset: 0x008D5DDC
		// (set) Token: 0x06009683 RID: 38531 RVA: 0x008D7C90 File Offset: 0x008D5E90
		public string TrkEmerProfGeneralEmergencyTalkback_A9268_UIValue
		{
			get
			{
				short num = (short)650623742;
				short num2 = num;
				num = (short)495631102;
				switch (num2 == num)
				{
				}
				num = (short)1588527104;
				short num3 = num;
				num = (short)1737490432;
				if (num != 0)
				{
				}
				num = (short)423100417;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralEmergencyTalkback_A9268.UIValue;
			}
			set
			{
				short num = (short)945603688;
				short num2 = num;
				num = (short)566543464;
				switch (num2 == num)
				{
				}
				num = (short)1576599552;
				short num3 = num;
				num = (short)124715009;
				if (num != 0)
				{
				}
				num = (short)455999488;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralEmergencyTalkback_A9268.UIValue = value;
			}
		}

		// Token: 0x17004B95 RID: 19349
		// (get) Token: 0x06009684 RID: 38532 RVA: 0x008D7D44 File Offset: 0x008D5F44
		public global::AcpBusinessLayer.AcpListField TrkEmerProfGeneralEmergencyTalkback_A9268
		{
			get
			{
				short num = (short)987299841;
				if (num != 0)
				{
				}
				num = (short)282162306;
				short num2 = num;
				num = (short)1701016706;
				switch (num2 == num)
				{
				default:
				{
					num = (short)65077248;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)212533248;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralEmergencyTalkback_A9268;
			}
		}

		// Token: 0x17004B96 RID: 19350
		// (get) Token: 0x06009685 RID: 38533 RVA: 0x008D7DF4 File Offset: 0x008D5FF4
		// (set) Token: 0x06009686 RID: 38534 RVA: 0x008D7EA8 File Offset: 0x008D60A8
		public bool TrkEmerProfGeneralEmergencyTalkback_A9268_Applicable
		{
			get
			{
				short num = (short)1156826264;
				short num2 = num;
				num = (short)881706136;
				switch (num2 == num)
				{
				}
				num = (short)2133393408;
				short num3 = num;
				num = (short)172556289;
				if (num != 0)
				{
				}
				num = (short)994967552;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralEmergencyTalkback_A9268.Applicable;
			}
			set
			{
				short num = (short)1953070756;
				short num2 = num;
				num = (short)252542628;
				switch (num2 == num)
				{
				}
				num = (short)893517824;
				short num3 = num;
				num = (short)2084044801;
				if (num != 0)
				{
				}
				num = (short)1823997952;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralEmergencyTalkback_A9268.Applicable = value;
			}
		}

		// Token: 0x17004B97 RID: 19351
		// (get) Token: 0x06009687 RID: 38535 RVA: 0x008D7F60 File Offset: 0x008D6160
		// (set) Token: 0x06009688 RID: 38536 RVA: 0x008D8014 File Offset: 0x008D6214
		public bool TrkEmerProfGeneralEmergencyTalkback_A9268_Valid
		{
			get
			{
				short num = (short)823757085;
				short num2 = num;
				num = (short)735545629;
				switch (num2 == num)
				{
				}
				num = (short)1371209728;
				short num3 = num;
				num = (short)93650945;
				if (num != 0)
				{
				}
				num = (short)2037514240;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralEmergencyTalkback_A9268.Valid;
			}
			set
			{
				short num = (short)1199694604;
				short num2 = num;
				num = (short)369746700;
				switch (num2 == num)
				{
				}
				num = (short)1263337472;
				short num3 = num;
				num = (short)446496768;
				if (num != 0)
				{
				}
				num = (short)1081344001;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralEmergencyTalkback_A9268.Valid = value;
			}
		}

		// Token: 0x17004B98 RID: 19352
		// (get) Token: 0x06009689 RID: 38537 RVA: 0x008D80C8 File Offset: 0x008D62C8
		// (set) Token: 0x0600968A RID: 38538 RVA: 0x008D817C File Offset: 0x008D637C
		public bool TrkEmerProfGeneralEmergencyTalkback_A9268_Visible
		{
			get
			{
				short num = (short)1153254392;
				short num2 = num;
				num = (short)1972061176;
				switch (num2 == num)
				{
				}
				num = (short)1281622016;
				short num3 = num;
				num = (short)5046272;
				if (num != 0)
				{
				}
				num = (short)1149698049;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralEmergencyTalkback_A9268.Visible;
			}
			set
			{
				short num = (short)1589703580;
				short num2 = num;
				num = (short)946336668;
				switch (num2 == num)
				{
				}
				num = (short)695205888;
				short num3 = num;
				num = (short)1613430784;
				if (num != 0)
				{
				}
				num = (short)190513153;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralEmergencyTalkback_A9268.Visible = value;
			}
		}

		// Token: 0x17004B99 RID: 19353
		// (get) Token: 0x0600968B RID: 38539 RVA: 0x008D8230 File Offset: 0x008D6430
		// (set) Token: 0x0600968C RID: 38540 RVA: 0x008D82E4 File Offset: 0x008D64E4
		public bool TrkEmerProfGeneralEmergencyTalkback_A9268_Editable
		{
			get
			{
				short num = (short)997166083;
				short num2 = num;
				num = (short)392793091;
				switch (num2 == num)
				{
				}
				num = (short)185204736;
				short num3 = num;
				num = (short)1240530945;
				if (num != 0)
				{
				}
				num = (short)1704656896;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralEmergencyTalkback_A9268.Editable;
			}
			set
			{
				short num = (short)1412497408;
				short num2 = num;
				num = (short)888579644;
				short num3 = num;
				num = (short)363439676;
				switch (num3 == num)
				{
				}
				num = (short)514588672;
				if (num != 0)
				{
				}
				num = (short)1212481537;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralEmergencyTalkback_A9268.Editable = value;
			}
		}

		// Token: 0x17004B9A RID: 19354
		// (get) Token: 0x0600968D RID: 38541 RVA: 0x008D8398 File Offset: 0x008D6598
		internal string TrkEmerProfGeneralEmergencyTalkback_A9268_UILabel
		{
			get
			{
				short num = (short)1314127872;
				short num2 = num;
				num = (short)1666231677;
				short num3 = num;
				num = (short)499232125;
				switch (num3 == num)
				{
				}
				num = (short)1149894656;
				if (num != 0)
				{
				}
				num = (short)193200129;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralEmergencyTalkback_A9268.UIName;
			}
		}

		// Token: 0x17004B9B RID: 19355
		// (get) Token: 0x0600968E RID: 38542 RVA: 0x008D844C File Offset: 0x008D664C
		// (set) Token: 0x0600968F RID: 38543 RVA: 0x008D8504 File Offset: 0x008D6704
		internal bool TrkEmerProfGeneralEmergencyTalkback_A9268_HiddenStatic
		{
			get
			{
				short num = (short)1428750336;
				short num2 = num;
				num = (short)458829015;
				short num3 = num;
				num = (short)2071538903;
				switch (num3 == num)
				{
				}
				num = (short)378535937;
				if (num != 0)
				{
				}
				num = (short)2006319104;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralEmergencyTalkback_A9268.HiddenStatic;
			}
			set
			{
				short num = (short)1826619392;
				short num2 = num;
				num = (short)1729974820;
				short num3 = num;
				num = (short)1846563364;
				switch (num3 == num)
				{
				}
				num = (short)1090256896;
				if (num != 0)
				{
				}
				num = (short)45678593;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralEmergencyTalkback_A9268.HiddenStatic = value;
			}
		}

		// Token: 0x17004B9C RID: 19356
		// (get) Token: 0x06009690 RID: 38544 RVA: 0x008D85B8 File Offset: 0x008D67B8
		// (set) Token: 0x06009691 RID: 38545 RVA: 0x008D8670 File Offset: 0x008D6870
		internal bool TrkEmerProfGeneralEmergencyTalkback_A9268_HiddenDynamic
		{
			get
			{
				short num = (short)2027421696;
				short num2 = num;
				num = (short)100058045;
				short num3 = num;
				num = (short)803062717;
				switch (num3 == num)
				{
				}
				num = (short)1533739009;
				if (num != 0)
				{
				}
				num = (short)897646592;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralEmergencyTalkback_A9268.HiddenDynamic;
			}
			set
			{
				short num = (short)1631387648;
				short num2 = num;
				num = (short)237128236;
				short num3 = num;
				num = (short)408177196;
				switch (num3 == num)
				{
				}
				num = (short)1763901441;
				if (num != 0)
				{
				}
				num = (short)1340866560;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralEmergencyTalkback_A9268.HiddenDynamic = value;
			}
		}

		// Token: 0x17004B9D RID: 19357
		// (get) Token: 0x06009692 RID: 38546 RVA: 0x008D8728 File Offset: 0x008D6928
		public bool TrkEmerProfGeneralEmergencyTalkback_A9268_HasDiffs
		{
			get
			{
				short num = (short)95289344;
				short num2 = num;
				num = (short)1793586871;
				short num3 = num;
				num = (short)1109194423;
				switch (num3 == num)
				{
				}
				num = (short)689307649;
				if (num != 0)
				{
				}
				num = (short)1653538816;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralEmergencyTalkback_A9268._HasDiffs;
			}
		}

		// Token: 0x17004B9E RID: 19358
		// (get) Token: 0x06009693 RID: 38547 RVA: 0x008D87DC File Offset: 0x008D69DC
		// (set) Token: 0x06009694 RID: 38548 RVA: 0x008D8890 File Offset: 0x008D6A90
		public bool TrkEmerProfGeneralRevertPTTID_A12642Value
		{
			get
			{
				short num = (short)184352768;
				short num2 = num;
				num = (short)428710382;
				short num3 = num;
				num = (short)591698414;
				switch (num3 == num)
				{
				}
				num = (short)925499392;
				if (num != 0)
				{
				}
				num = (short)674824193;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralRevertPTTID_A12642.Value;
			}
			set
			{
				short num = (short)1207631872;
				short num2 = num;
				num = (short)1408827393;
				if (num != 0)
				{
				}
				num = (short)1074686972;
				short num3 = num;
				num = (short)545352700;
				switch (num3 == num)
				{
				}
				num = (short)1338048512;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralRevertPTTID_A12642.Value = value;
			}
		}

		// Token: 0x17004B9F RID: 19359
		// (get) Token: 0x06009695 RID: 38549 RVA: 0x008D8948 File Offset: 0x008D6B48
		public global::AcpBusinessLayer.AcpField<bool> TrkEmerProfGeneralRevertPTTID_A12642
		{
			get
			{
				short num = (short)408616960;
				short num2 = num;
				num = (short)1345478490;
				short num3 = num;
				num = (short)1325555546;
				switch (num3 == num)
				{
				}
				num = (short)405405697;
				if (num != 0)
				{
				}
				num = (short)2079784960;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralRevertPTTID_A12642;
			}
		}

		// Token: 0x17004BA0 RID: 19360
		// (get) Token: 0x06009696 RID: 38550 RVA: 0x008D89F8 File Offset: 0x008D6BF8
		// (set) Token: 0x06009697 RID: 38551 RVA: 0x008D8AAC File Offset: 0x008D6CAC
		public bool TrkEmerProfGeneralRevertPTTID_A12642_UIValue
		{
			get
			{
				short num = (short)1704132608;
				short num2 = num;
				num = (short)1140786701;
				short num3 = num;
				num = (short)820119053;
				switch (num3 == num)
				{
				}
				num = (short)1645543424;
				if (num != 0)
				{
				}
				num = (short)923664385;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralRevertPTTID_A12642.Value;
			}
			set
			{
				short num = (short)1829371904;
				short num2 = num;
				num = (short)901189858;
				short num3 = num;
				num = (short)124850402;
				switch (num3 == num)
				{
				}
				num = (short)1539309569;
				if (num != 0)
				{
				}
				num = (short)1629487104;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralRevertPTTID_A12642.Value = value;
			}
		}

		// Token: 0x17004BA1 RID: 19361
		// (get) Token: 0x06009698 RID: 38552 RVA: 0x008D8B60 File Offset: 0x008D6D60
		// (set) Token: 0x06009699 RID: 38553 RVA: 0x008D8C14 File Offset: 0x008D6E14
		public bool TrkEmerProfGeneralRevertPTTID_A12642_Applicable
		{
			get
			{
				short num = (short)950730752;
				short num2 = num;
				num = (short)615186433;
				if (num != 0)
				{
				}
				num = (short)1838236684;
				short num3 = num;
				num = (short)1140737036;
				switch (num3 == num)
				{
				}
				num = (short)1456668672;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralRevertPTTID_A12642.Applicable;
			}
			set
			{
				short num = (short)685768704;
				short num2 = num;
				num = (short)805754516;
				short num3 = num;
				num = (short)1917834900;
				switch (num3 == num)
				{
				}
				num = (short)1536819201;
				if (num != 0)
				{
				}
				num = (short)1581973504;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralRevertPTTID_A12642.Applicable = value;
			}
		}

		// Token: 0x17004BA2 RID: 19362
		// (get) Token: 0x0600969A RID: 38554 RVA: 0x008D8CD0 File Offset: 0x008D6ED0
		// (set) Token: 0x0600969B RID: 38555 RVA: 0x008D8D84 File Offset: 0x008D6F84
		public bool TrkEmerProfGeneralRevertPTTID_A12642_Valid
		{
			get
			{
				short num = (short)1193410560;
				short num2 = num;
				num = (short)577340733;
				short num3 = num;
				num = (short)213747005;
				switch (num3 == num)
				{
				}
				num = (short)2052259841;
				if (num != 0)
				{
				}
				num = (short)787873792;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralRevertPTTID_A12642.Valid;
			}
			set
			{
				short num = (short)1556742144;
				short num2 = num;
				num = (short)1939003105;
				short num3 = num;
				num = (short)405067489;
				switch (num3 == num)
				{
				}
				num = (short)130088961;
				if (num != 0)
				{
				}
				num = (short)519503872;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralRevertPTTID_A12642.Valid = value;
			}
		}

		// Token: 0x17004BA3 RID: 19363
		// (get) Token: 0x0600969C RID: 38556 RVA: 0x008D8E3C File Offset: 0x008D703C
		// (set) Token: 0x0600969D RID: 38557 RVA: 0x008D8EF0 File Offset: 0x008D70F0
		public bool TrkEmerProfGeneralRevertPTTID_A12642_Visible
		{
			get
			{
				short num = (short)157548544;
				short num2 = num;
				num = (short)1611333633;
				if (num != 0)
				{
				}
				num = (short)189912574;
				short num3 = num;
				num = (short)333108734;
				switch (num3 == num)
				{
				}
				num = (short)741539840;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralRevertPTTID_A12642.Visible;
			}
			set
			{
				short num = (short)2102919168;
				short num2 = num;
				num = (short)1366636466;
				short num3 = num;
				num = (short)1174878130;
				switch (num3 == num)
				{
				}
				num = (short)1449132033;
				if (num != 0)
				{
				}
				num = (short)1908867072;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralRevertPTTID_A12642.Visible = value;
			}
		}

		// Token: 0x17004BA4 RID: 19364
		// (get) Token: 0x0600969E RID: 38558 RVA: 0x008D8FA8 File Offset: 0x008D71A8
		// (set) Token: 0x0600969F RID: 38559 RVA: 0x008D905C File Offset: 0x008D725C
		public bool TrkEmerProfGeneralRevertPTTID_A12642_Editable
		{
			get
			{
				short num = (short)1529741312;
				short num2 = num;
				num = (short)1007796863;
				short num3 = num;
				num = (short)1996079743;
				switch (num3 == num)
				{
				}
				num = (short)188678145;
				if (num != 0)
				{
				}
				num = (short)1270939648;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralRevertPTTID_A12642.Editable;
			}
			set
			{
				short num = (short)2019885056;
				short num2 = num;
				num = (short)433943411;
				short num3 = num;
				num = (short)1563784051;
				switch (num3 == num)
				{
				}
				num = (short)1365180417;
				if (num != 0)
				{
				}
				num = (short)1094451200;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralRevertPTTID_A12642.Editable = value;
			}
		}

		// Token: 0x17004BA5 RID: 19365
		// (get) Token: 0x060096A0 RID: 38560 RVA: 0x008D9118 File Offset: 0x008D7318
		internal string TrkEmerProfGeneralRevertPTTID_A12642_UILabel
		{
			get
			{
				short num = (short)1418526720;
				short num2 = num;
				num = (short)592866670;
				short num3 = num;
				num = (short)440888686;
				switch (num3 == num)
				{
				}
				num = (short)2105475073;
				if (num != 0)
				{
				}
				num = (short)923271168;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralRevertPTTID_A12642.UIName;
			}
		}

		// Token: 0x17004BA6 RID: 19366
		// (get) Token: 0x060096A1 RID: 38561 RVA: 0x008D91CC File Offset: 0x008D73CC
		// (set) Token: 0x060096A2 RID: 38562 RVA: 0x008D9284 File Offset: 0x008D7484
		internal bool TrkEmerProfGeneralRevertPTTID_A12642_HiddenStatic
		{
			get
			{
				short num = (short)172163072;
				short num2 = num;
				num = (short)1411682109;
				short num3 = num;
				num = (short)213552957;
				switch (num3 == num)
				{
				}
				num = (short)635437057;
				if (num != 0)
				{
				}
				num = (short)1652490240;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralRevertPTTID_A12642.HiddenStatic;
			}
			set
			{
				short num = (short)1359609856;
				short num2 = num;
				num = (short)1986259832;
				short num3 = num;
				num = (short)532867960;
				switch (num3 == num)
				{
				}
				num = (short)2090663936;
				if (num != 0)
				{
				}
				num = (short)1926692865;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralRevertPTTID_A12642.HiddenStatic = value;
			}
		}

		// Token: 0x17004BA7 RID: 19367
		// (get) Token: 0x060096A3 RID: 38563 RVA: 0x008D9338 File Offset: 0x008D7538
		// (set) Token: 0x060096A4 RID: 38564 RVA: 0x008D93F0 File Offset: 0x008D75F0
		internal bool TrkEmerProfGeneralRevertPTTID_A12642_HiddenDynamic
		{
			get
			{
				short num = (short)761200640;
				short num2 = num;
				num = (short)1768059289;
				short num3 = num;
				num = (short)1223782809;
				switch (num3 == num)
				{
				}
				num = (short)1236140032;
				if (num != 0)
				{
				}
				num = (short)887947265;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralRevertPTTID_A12642.HiddenDynamic;
			}
			set
			{
				short num = (short)1123155968;
				short num2 = num;
				num = (short)96155094;
				short num3 = num;
				num = (short)1018705366;
				switch (num3 == num)
				{
				}
				num = (short)512491521;
				if (num != 0)
				{
				}
				num = (short)777715712;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralRevertPTTID_A12642.HiddenDynamic = value;
			}
		}

		// Token: 0x17004BA8 RID: 19368
		// (get) Token: 0x060096A5 RID: 38565 RVA: 0x008D94A4 File Offset: 0x008D76A4
		public bool TrkEmerProfGeneralRevertPTTID_A12642_HasDiffs
		{
			get
			{
				short num = (short)95879168;
				short num2 = num;
				num = (short)648785903;
				short num3 = num;
				num = (short)1291169775;
				switch (num3 == num)
				{
				}
				num = (short)1641283585;
				if (num != 0)
				{
				}
				num = (short)299368448;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralRevertPTTID_A12642._HasDiffs;
			}
		}

		// Token: 0x17004BA9 RID: 19369
		// (get) Token: 0x060096A6 RID: 38566 RVA: 0x008D9554 File Offset: 0x008D7754
		// (set) Token: 0x060096A7 RID: 38567 RVA: 0x008D9608 File Offset: 0x008D7808
		public string TrkEmerProfGeneralkeyofTrunkingEmergencyProfiles_A19419Value
		{
			get
			{
				short num = (short)1847328768;
				short num2 = num;
				num = (short)1475936257;
				if (num != 0)
				{
				}
				num = (short)476146776;
				short num3 = num;
				num = (short)41184344;
				switch (num3 == num)
				{
				}
				num = (short)221249536;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralkeyofTrunkingEmergencyProfiles_A19419.Value;
			}
			set
			{
				short num = (short)347865088;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_14;
					case 1:
					{
						num = (short)1463570153;
						short num3 = num;
						num = (short)1391939305;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_14;
						default:
						{
							num = (short)1047855105;
							if (num != 0)
							{
							}
							num = (short)809041920;
							short num4 = num;
							num = (short)301989888;
							if (num != 0)
							{
							}
							this.trkEmerProfGeneralkeyofTrunkingEmergencyProfiles_A19419.Value = value;
							num = (short)1700593666;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 2:
						return;
					}
					goto IL_30;
					IL_14:
					switch (0)
					{
					case 0:
						IL_30:
						if (string.IsNullOrEmpty(value.Trim()))
						{
							return;
						}
						num = (short)712310785;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
			}
		}

		// Token: 0x17004BAA RID: 19370
		// (get) Token: 0x060096A8 RID: 38568 RVA: 0x008D9730 File Offset: 0x008D7930
		// (set) Token: 0x060096A9 RID: 38569 RVA: 0x008D97E4 File Offset: 0x008D79E4
		public string TrkEmerProfGeneralkeyofTrunkingEmergencyProfiles_A19419_UIValue
		{
			get
			{
				short num = (short)1890254848;
				short num2 = num;
				num = (short)1856715923;
				short num3 = num;
				num = (short)1867332755;
				switch (num3 == num)
				{
				}
				num = (short)717619201;
				if (num != 0)
				{
				}
				num = (short)954007552;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralkeyofTrunkingEmergencyProfiles_A19419.Value;
			}
			set
			{
				short num = (short)1511325696;
				short num2 = num;
				num = (short)2136276993;
				if (num != 0)
				{
				}
				num = (short)1304900412;
				short num3 = num;
				num = (short)396309308;
				switch (num3 == num)
				{
				}
				num = (short)291307520;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralkeyofTrunkingEmergencyProfiles_A19419.Value = value;
			}
		}

		// Token: 0x17004BAB RID: 19371
		// (get) Token: 0x060096AA RID: 38570 RVA: 0x008D9898 File Offset: 0x008D7A98
		public global::AcpBusinessLayer.AcpKeyField TrkEmerProfGeneralkeyofTrunkingEmergencyProfiles_A19419
		{
			get
			{
				short num = (short)682557440;
				short num2 = num;
				num = (short)1156038289;
				short num3 = num;
				num = (short)1522843281;
				switch (num3 == num)
				{
				}
				num = (short)651493376;
				if (num != 0)
				{
				}
				num = (short)650051585;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralkeyofTrunkingEmergencyProfiles_A19419;
			}
		}

		// Token: 0x17004BAC RID: 19372
		// (get) Token: 0x060096AB RID: 38571 RVA: 0x008D9948 File Offset: 0x008D7B48
		// (set) Token: 0x060096AC RID: 38572 RVA: 0x008D99F8 File Offset: 0x008D7BF8
		public bool TrkEmerProfGeneralkeyofTrunkingEmergencyProfiles_A19419_Applicable
		{
			get
			{
				short num = (short)472121344;
				short num2 = num;
				num = (short)1581502470;
				short num3 = num;
				num = (short)1901252614;
				switch (num3 == num)
				{
				}
				num = (short)2071855104;
				if (num != 0)
				{
				}
				num = (short)883556353;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralkeyofTrunkingEmergencyProfiles_A19419.Applicable;
			}
			set
			{
				short num = (short)440139776;
				short num2 = num;
				num = (short)1906136730;
				short num3 = num;
				num = (short)1491555994;
				switch (num3 == num)
				{
				}
				num = (short)1490550785;
				if (num != 0)
				{
				}
				num = (short)1824849920;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralkeyofTrunkingEmergencyProfiles_A19419.Applicable = value;
			}
		}

		// Token: 0x17004BAD RID: 19373
		// (get) Token: 0x060096AD RID: 38573 RVA: 0x008D9AAC File Offset: 0x008D7CAC
		// (set) Token: 0x060096AE RID: 38574 RVA: 0x008D9B64 File Offset: 0x008D7D64
		public bool TrkEmerProfGeneralkeyofTrunkingEmergencyProfiles_A19419_Valid
		{
			get
			{
				short num = (short)1323696128;
				short num2 = num;
				num = (short)763318309;
				short num3 = num;
				num = (short)1187008549;
				switch (num3 == num)
				{
				}
				num = (short)1214316545;
				if (num != 0)
				{
				}
				num = (short)1863712768;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralkeyofTrunkingEmergencyProfiles_A19419.Valid;
			}
			set
			{
				short num = (short)1941372928;
				short num2 = num;
				num = (short)1166868481;
				if (num != 0)
				{
				}
				num = (short)17746030;
				short num3 = num;
				num = (short)520538222;
				switch (num3 == num)
				{
				}
				num = (short)1217396736;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralkeyofTrunkingEmergencyProfiles_A19419.Valid = value;
			}
		}

		// Token: 0x17004BAE RID: 19374
		// (get) Token: 0x060096AF RID: 38575 RVA: 0x008D9C18 File Offset: 0x008D7E18
		// (set) Token: 0x060096B0 RID: 38576 RVA: 0x008D9CD0 File Offset: 0x008D7ED0
		public bool TrkEmerProfGeneralkeyofTrunkingEmergencyProfiles_A19419_Visible
		{
			get
			{
				short num = (short)777453568;
				short num2 = num;
				num = (short)234096289;
				short num3 = num;
				num = (short)956630689;
				switch (num3 == num)
				{
				}
				num = (short)1091502081;
				if (num != 0)
				{
				}
				num = (short)1628897280;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralkeyofTrunkingEmergencyProfiles_A19419.Visible;
			}
			set
			{
				short num = (short)69730304;
				short num2 = num;
				num = (short)1022574278;
				short num3 = num;
				num = (short)46218950;
				switch (num3 == num)
				{
				}
				num = (short)941883393;
				if (num != 0)
				{
				}
				num = (short)1318518784;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralkeyofTrunkingEmergencyProfiles_A19419.Visible = value;
			}
		}

		// Token: 0x17004BAF RID: 19375
		// (get) Token: 0x060096B1 RID: 38577 RVA: 0x008D9D88 File Offset: 0x008D7F88
		// (set) Token: 0x060096B2 RID: 38578 RVA: 0x008D9E3C File Offset: 0x008D803C
		public bool TrkEmerProfGeneralkeyofTrunkingEmergencyProfiles_A19419_Editable
		{
			get
			{
				short num = (short)1451819008;
				short num2 = num;
				num = (short)601307763;
				short num3 = num;
				num = (short)1077230195;
				switch (num3 == num)
				{
				}
				num = (short)380895233;
				if (num != 0)
				{
				}
				num = (short)709558272;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralkeyofTrunkingEmergencyProfiles_A19419.Editable;
			}
			set
			{
				short num = (short)1351221248;
				short num2 = num;
				num = (short)702865687;
				short num3 = num;
				num = (short)1532027159;
				switch (num3 == num)
				{
				}
				num = (short)537395200;
				if (num != 0)
				{
				}
				num = (short)451608577;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralkeyofTrunkingEmergencyProfiles_A19419.Editable = value;
			}
		}

		// Token: 0x17004BB0 RID: 19376
		// (get) Token: 0x060096B3 RID: 38579 RVA: 0x008D9EF4 File Offset: 0x008D80F4
		internal string TrkEmerProfGeneralkeyofTrunkingEmergencyProfiles_A19419_UILabel
		{
			get
			{
				short num = (short)1289814016;
				short num2 = num;
				num = (short)1312344514;
				short num3 = num;
				num = (short)832031170;
				switch (num3 == num)
				{
				}
				num = (short)2068643840;
				if (num != 0)
				{
				}
				num = (short)1134493697;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralkeyofTrunkingEmergencyProfiles_A19419.UIName;
			}
		}

		// Token: 0x17004BB1 RID: 19377
		// (get) Token: 0x060096B4 RID: 38580 RVA: 0x008D9FA8 File Offset: 0x008D81A8
		// (set) Token: 0x060096B5 RID: 38581 RVA: 0x008DA05C File Offset: 0x008D825C
		internal bool TrkEmerProfGeneralkeyofTrunkingEmergencyProfiles_A19419_HiddenStatic
		{
			get
			{
				short num = (short)1933443072;
				short num2 = num;
				num = (short)1962412306;
				short num3 = num;
				num = (short)1602554130;
				switch (num3 == num)
				{
				}
				num = (short)252444673;
				if (num != 0)
				{
				}
				num = (short)1623392256;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralkeyofTrunkingEmergencyProfiles_A19419.HiddenStatic;
			}
			set
			{
				short num = (short)1587937280;
				short num2 = num;
				num = (short)226745995;
				short num3 = num;
				num = (short)331341451;
				switch (num3 == num)
				{
				}
				num = (short)925433857;
				if (num != 0)
				{
				}
				num = (short)642514944;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralkeyofTrunkingEmergencyProfiles_A19419.HiddenStatic = value;
			}
		}

		// Token: 0x17004BB2 RID: 19378
		// (get) Token: 0x060096B6 RID: 38582 RVA: 0x008DA110 File Offset: 0x008D8310
		// (set) Token: 0x060096B7 RID: 38583 RVA: 0x008DA1C4 File Offset: 0x008D83C4
		internal bool TrkEmerProfGeneralkeyofTrunkingEmergencyProfiles_A19419_HiddenDynamic
		{
			get
			{
				short num = (short)1792016384;
				short num2 = num;
				num = (short)1913486958;
				short num3 = num;
				num = (short)840924782;
				switch (num3 == num)
				{
				}
				num = (short)1204027392;
				if (num != 0)
				{
				}
				num = (short)430112769;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralkeyofTrunkingEmergencyProfiles_A19419.HiddenDynamic;
			}
			set
			{
				short num = (short)250216448;
				short num2 = num;
				num = (short)1883200203;
				short num3 = num;
				num = (short)1981110987;
				switch (num3 == num)
				{
				}
				num = (short)1490944001;
				if (num != 0)
				{
				}
				num = (short)525926400;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralkeyofTrunkingEmergencyProfiles_A19419.HiddenDynamic = value;
			}
		}

		// Token: 0x17004BB3 RID: 19379
		// (get) Token: 0x060096B8 RID: 38584 RVA: 0x008DA27C File Offset: 0x008D847C
		public bool TrkEmerProfGeneralkeyofTrunkingEmergencyProfiles_A19419_HasDiffs
		{
			get
			{
				short num = (short)464584704;
				short num2 = num;
				num = (short)1338381293;
				short num3 = num;
				num = (short)1055462381;
				switch (num3 == num)
				{
				}
				num = (short)12058625;
				if (num != 0)
				{
				}
				num = (short)1802502144;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralkeyofTrunkingEmergencyProfiles_A19419._HasDiffs;
			}
		}

		// Token: 0x17004BB4 RID: 19380
		// (get) Token: 0x060096B9 RID: 38585 RVA: 0x008DA330 File Offset: 0x008D8530
		// (set) Token: 0x060096BA RID: 38586 RVA: 0x008DA3E4 File Offset: 0x008D85E4
		public int TrkEmerProEmergencyAutoTransmitMode_A22567Value
		{
			get
			{
				short num = (short)350552064;
				short num2 = num;
				num = (short)1275636251;
				short num3 = num;
				num = (short)590064155;
				switch (num3 == num)
				{
				}
				num = (short)2031026177;
				if (num != 0)
				{
				}
				num = (short)1596981248;
				if (num != 0)
				{
				}
				return this.trkEmerProEmergencyAutoTransmitMode_A22567.Value;
			}
			set
			{
				short num = (short)344522752;
				short num2 = num;
				num = (short)1689944156;
				short num3 = num;
				num = (short)215580764;
				switch (num3 == num)
				{
				}
				num = (short)661192705;
				if (num != 0)
				{
				}
				num = (short)848429056;
				if (num != 0)
				{
				}
				this.trkEmerProEmergencyAutoTransmitMode_A22567.Value = value;
			}
		}

		// Token: 0x17004BB5 RID: 19381
		// (get) Token: 0x060096BB RID: 38587 RVA: 0x008DA498 File Offset: 0x008D8698
		// (set) Token: 0x060096BC RID: 38588 RVA: 0x008DA54C File Offset: 0x008D874C
		public string TrkEmerProEmergencyAutoTransmitMode_A22567_UIValue
		{
			get
			{
				short num = (short)465633280;
				short num2 = num;
				num = (short)269065710;
				short num3 = num;
				num = (short)1768857070;
				switch (num3 == num)
				{
				}
				num = (short)417267712;
				if (num != 0)
				{
				}
				num = (short)998178817;
				if (num != 0)
				{
				}
				return this.trkEmerProEmergencyAutoTransmitMode_A22567.UIValue;
			}
			set
			{
				short num = (short)2049703936;
				short num2 = num;
				num = (short)1294679898;
				short num3 = num;
				num = (short)294535002;
				switch (num3 == num)
				{
				}
				num = (short)223936513;
				if (num != 0)
				{
				}
				num = (short)127926272;
				if (num != 0)
				{
				}
				this.trkEmerProEmergencyAutoTransmitMode_A22567.UIValue = value;
			}
		}

		// Token: 0x17004BB6 RID: 19382
		// (get) Token: 0x060096BD RID: 38589 RVA: 0x008DA600 File Offset: 0x008D8800
		public global::AcpBusinessLayer.AcpListField TrkEmerProEmergencyAutoTransmitMode_A22567
		{
			get
			{
				short num = (short)549847040;
				short num2 = num;
				num = (short)504014787;
				short num3 = num;
				num = (short)169650115;
				switch (num3 == num)
				{
				}
				num = (short)1675296768;
				if (num != 0)
				{
				}
				num = (short)1293811713;
				if (num != 0)
				{
				}
				return this.trkEmerProEmergencyAutoTransmitMode_A22567;
			}
		}

		// Token: 0x17004BB7 RID: 19383
		// (get) Token: 0x060096BE RID: 38590 RVA: 0x008DA6B0 File Offset: 0x008D88B0
		// (set) Token: 0x060096BF RID: 38591 RVA: 0x008DA768 File Offset: 0x008D8968
		public bool TrkEmerProEmergencyAutoTransmitMode_A22567_Applicable
		{
			get
			{
				short num = (short)1433383710;
				short num2 = num;
				num = (short)2110173982;
				switch (num2 == num)
				{
				default:
				{
					num = (short)65798144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)629473281;
				if (num != 0)
				{
				}
				num = (short)1264648192;
				if (num != 0)
				{
				}
				return this.trkEmerProEmergencyAutoTransmitMode_A22567.Applicable;
			}
			set
			{
				short num = (short)360622937;
				short num2 = num;
				num = (short)1143515993;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1027473408;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)611385345;
				if (num != 0)
				{
				}
				num = (short)1919025152;
				if (num != 0)
				{
				}
				this.trkEmerProEmergencyAutoTransmitMode_A22567.Applicable = value;
			}
		}

		// Token: 0x17004BB8 RID: 19384
		// (get) Token: 0x060096C0 RID: 38592 RVA: 0x008DA81C File Offset: 0x008D8A1C
		// (set) Token: 0x060096C1 RID: 38593 RVA: 0x008DA8D0 File Offset: 0x008D8AD0
		public bool TrkEmerProEmergencyAutoTransmitMode_A22567_Valid
		{
			get
			{
				short num = (short)1237090680;
				short num2 = num;
				num = (short)1327006072;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1060175872;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1918173185;
				if (num != 0)
				{
				}
				num = (short)1627521024;
				if (num != 0)
				{
				}
				return this.trkEmerProEmergencyAutoTransmitMode_A22567.Valid;
			}
			set
			{
				short num = (short)1018527785;
				short num2 = num;
				num = (short)825262121;
				switch (num2 == num)
				{
				default:
				{
					num = (short)988348416;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1410334721;
				if (num != 0)
				{
				}
				num = (short)760414208;
				if (num != 0)
				{
				}
				this.trkEmerProEmergencyAutoTransmitMode_A22567.Valid = value;
			}
		}

		// Token: 0x17004BB9 RID: 19385
		// (get) Token: 0x060096C2 RID: 38594 RVA: 0x008DA984 File Offset: 0x008D8B84
		// (set) Token: 0x060096C3 RID: 38595 RVA: 0x008DAA38 File Offset: 0x008D8C38
		public bool TrkEmerProEmergencyAutoTransmitMode_A22567_Visible
		{
			get
			{
				short num = (short)1665335297;
				if (num != 0)
				{
				}
				num = (short)635633664;
				short num2 = num;
				num = (short)1107304084;
				short num3 = num;
				num = (short)1195056788;
				switch (num3 == num)
				{
				}
				num = (short)743571456;
				if (num != 0)
				{
				}
				return this.trkEmerProEmergencyAutoTransmitMode_A22567.Visible;
			}
			set
			{
				short num = (short)1014109950;
				short num2 = num;
				num = (short)1342969598;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1126694912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1501036545;
				if (num != 0)
				{
				}
				num = (short)490405888;
				if (num != 0)
				{
				}
				this.trkEmerProEmergencyAutoTransmitMode_A22567.Visible = value;
			}
		}

		// Token: 0x17004BBA RID: 19386
		// (get) Token: 0x060096C4 RID: 38596 RVA: 0x008DAAF0 File Offset: 0x008D8CF0
		// (set) Token: 0x060096C5 RID: 38597 RVA: 0x008DABA4 File Offset: 0x008D8DA4
		public bool TrkEmerProEmergencyAutoTransmitMode_A22567_Editable
		{
			get
			{
				short num = (short)174047748;
				short num2 = num;
				num = (short)1053671940;
				switch (num2 == num)
				{
				default:
				{
					num = (short)963117056;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)644153345;
				if (num != 0)
				{
				}
				num = (short)1309868032;
				if (num != 0)
				{
				}
				return this.trkEmerProEmergencyAutoTransmitMode_A22567.Editable;
			}
			set
			{
				short num = (short)1797241662;
				short num2 = num;
				num = (short)768195390;
				switch (num2 == num)
				{
				default:
				{
					num = (short)453378048;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1780940800;
				if (num != 0)
				{
				}
				num = (short)1847263233;
				if (num != 0)
				{
				}
				this.trkEmerProEmergencyAutoTransmitMode_A22567.Editable = value;
			}
		}

		// Token: 0x17004BBB RID: 19387
		// (get) Token: 0x060096C6 RID: 38598 RVA: 0x008DAC58 File Offset: 0x008D8E58
		internal string TrkEmerProEmergencyAutoTransmitMode_A22567_UILabel
		{
			get
			{
				short num = (short)527244365;
				short num2 = num;
				num = (short)665984077;
				switch (num2 == num)
				{
				default:
				{
					num = (short)556335104;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1177223169;
				if (num != 0)
				{
				}
				num = (short)318636032;
				if (num != 0)
				{
				}
				return this.trkEmerProEmergencyAutoTransmitMode_A22567.UIName;
			}
		}

		// Token: 0x17004BBC RID: 19388
		// (get) Token: 0x060096C7 RID: 38599 RVA: 0x008DAD0C File Offset: 0x008D8F0C
		// (set) Token: 0x060096C8 RID: 38600 RVA: 0x008DADC0 File Offset: 0x008D8FC0
		internal bool TrkEmerProEmergencyAutoTransmitMode_A22567_HiddenStatic
		{
			get
			{
				short num = (short)71570382;
				short num2 = num;
				num = (short)1230443470;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1168965632;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)386859008;
				if (num != 0)
				{
				}
				num = (short)644349953;
				if (num != 0)
				{
				}
				return this.trkEmerProEmergencyAutoTransmitMode_A22567.HiddenStatic;
			}
			set
			{
				short num = (short)2036129236;
				short num2 = num;
				num = (short)981130708;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1169096704;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)202309633;
				if (num != 0)
				{
				}
				num = (short)246677504;
				if (num != 0)
				{
				}
				this.trkEmerProEmergencyAutoTransmitMode_A22567.HiddenStatic = value;
			}
		}

		// Token: 0x17004BBD RID: 19389
		// (get) Token: 0x060096C9 RID: 38601 RVA: 0x008DAE78 File Offset: 0x008D9078
		// (set) Token: 0x060096CA RID: 38602 RVA: 0x008DAF2C File Offset: 0x008D912C
		internal bool TrkEmerProEmergencyAutoTransmitMode_A22567_HiddenDynamic
		{
			get
			{
				short num = (short)1329113038;
				short num2 = num;
				num = (short)1298311118;
				switch (num2 == num)
				{
				default:
				{
					num = (short)220135424;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1024262145;
				if (num != 0)
				{
				}
				num = (short)1958674432;
				if (num != 0)
				{
				}
				return this.trkEmerProEmergencyAutoTransmitMode_A22567.HiddenDynamic;
			}
			set
			{
				short num = (short)1873108314;
				short num2 = num;
				num = (short)1486445914;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1679753216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)330760193;
				if (num != 0)
				{
				}
				num = (short)1230438400;
				if (num != 0)
				{
				}
				this.trkEmerProEmergencyAutoTransmitMode_A22567.HiddenDynamic = value;
			}
		}

		// Token: 0x17004BBE RID: 19390
		// (get) Token: 0x060096CB RID: 38603 RVA: 0x008DAFE4 File Offset: 0x008D91E4
		public bool TrkEmerProEmergencyAutoTransmitMode_A22567_HasDiffs
		{
			get
			{
				short num = (short)1166868481;
				if (num != 0)
				{
				}
				num = (short)1357512704;
				short num2 = num;
				num = (short)1796225215;
				short num3 = num;
				num = (short)303052991;
				switch (num3 == num)
				{
				}
				num = (short)2145648640;
				if (num != 0)
				{
				}
				return this.trkEmerProEmergencyAutoTransmitMode_A22567._HasDiffs;
			}
		}

		// Token: 0x17004BBF RID: 19391
		// (get) Token: 0x060096CC RID: 38604 RVA: 0x008DB098 File Offset: 0x008D9298
		// (set) Token: 0x060096CD RID: 38605 RVA: 0x008DB150 File Offset: 0x008D9350
		public int TrkEmerProfGeneralTxPeriodsec1_A7939Value
		{
			get
			{
				short num = (short)1464312008;
				short num2 = num;
				num = (short)959488200;
				switch (num2 == num)
				{
				default:
				{
					num = (short)323354624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1587675137;
				if (num != 0)
				{
				}
				num = (short)1960509440;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralTxPeriodsec1_A7939.Value;
			}
			set
			{
				short num = (short)1289093121;
				if (num != 0)
				{
				}
				num = (short)1345847296;
				short num2 = num;
				num = (short)1057895943;
				short num3 = num;
				num = (short)2131179015;
				switch (num3 == num)
				{
				}
				num = (short)1079705600;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralTxPeriodsec1_A7939.Value = value;
			}
		}

		// Token: 0x17004BC0 RID: 19392
		// (get) Token: 0x060096CE RID: 38606 RVA: 0x008DB208 File Offset: 0x008D9408
		public global::AcpBusinessLayer.AcpSimpleRangeField TrkEmerProfGeneralTxPeriodsec1_A7939
		{
			get
			{
				short num = (short)748010056;
				short num2 = num;
				num = (short)1382726216;
				switch (num2 == num)
				{
				default:
				{
					num = (short)727908352;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1969225728;
				if (num != 0)
				{
				}
				num = (short)487522305;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralTxPeriodsec1_A7939;
			}
		}

		// Token: 0x17004BC1 RID: 19393
		// (get) Token: 0x060096CF RID: 38607 RVA: 0x008DB2B8 File Offset: 0x008D94B8
		// (set) Token: 0x060096D0 RID: 38608 RVA: 0x008DB36C File Offset: 0x008D956C
		public string TrkEmerProfGeneralTxPeriodsec1_A7939_UIValue
		{
			get
			{
				short num = (short)867496934;
				short num2 = num;
				num = (short)747369446;
				switch (num2 == num)
				{
				default:
				{
					num = (short)366936064;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1164771329;
				if (num != 0)
				{
				}
				num = (short)1456799744;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralTxPeriodsec1_A7939.UIValue;
			}
			set
			{
				short num = (short)1654787621;
				short num2 = num;
				num = (short)1367543333;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1340014592;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1014759425;
				if (num != 0)
				{
				}
				num = (short)514916352;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralTxPeriodsec1_A7939.UIValue = value;
			}
		}

		// Token: 0x17004BC2 RID: 19394
		// (get) Token: 0x060096D1 RID: 38609 RVA: 0x008DB424 File Offset: 0x008D9624
		// (set) Token: 0x060096D2 RID: 38610 RVA: 0x008DB4D8 File Offset: 0x008D96D8
		internal int TrkEmerProfGeneralTxPeriodsec1_A7939Min
		{
			get
			{
				short num = (short)1363377819;
				short num2 = num;
				num = (short)73891483;
				switch (num2 == num)
				{
				default:
				{
					num = (short)9633792;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)192544769;
				if (num != 0)
				{
				}
				num = (short)1349124096;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralTxPeriodsec1_A7939.Min;
			}
			set
			{
				short num = (short)616667162;
				short num2 = num;
				num = (short)1197512730;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1501429760;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1337262081;
				if (num != 0)
				{
				}
				num = (short)1987837952;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralTxPeriodsec1_A7939.Min = value;
			}
		}

		// Token: 0x17004BC3 RID: 19395
		// (get) Token: 0x060096D3 RID: 38611 RVA: 0x008DB590 File Offset: 0x008D9790
		// (set) Token: 0x060096D4 RID: 38612 RVA: 0x008DB644 File Offset: 0x008D9844
		internal int TrkEmerProfGeneralTxPeriodsec1_A7939Max
		{
			get
			{
				short num = (short)812555147;
				short num2 = num;
				num = (short)1930468235;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2000093184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2123104256;
				if (num != 0)
				{
				}
				num = (short)1093074945;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralTxPeriodsec1_A7939.Max;
			}
			set
			{
				short num = (short)301880986;
				short num2 = num;
				num = (short)1080120986;
				switch (num2 == num)
				{
				default:
				{
					num = (short)110166016;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1747451904;
				if (num != 0)
				{
				}
				num = (short)1572995073;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralTxPeriodsec1_A7939.Max = value;
			}
		}

		// Token: 0x17004BC4 RID: 19396
		// (get) Token: 0x060096D5 RID: 38613 RVA: 0x008DB6F8 File Offset: 0x008D98F8
		// (set) Token: 0x060096D6 RID: 38614 RVA: 0x008DB7AC File Offset: 0x008D99AC
		internal int TrkEmerProfGeneralTxPeriodsec1_A7939Step
		{
			get
			{
				short num = (short)1332541629;
				short num2 = num;
				num = (short)247920829;
				switch (num2 == num)
				{
				default:
				{
					num = (short)667942912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1922957313;
				if (num != 0)
				{
				}
				num = (short)2101936128;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralTxPeriodsec1_A7939.StepSize;
			}
			set
			{
				short num = (short)1192913504;
				short num2 = num;
				num = (short)1773300320;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1745944576;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1228406785;
				if (num != 0)
				{
				}
				num = (short)1852178432;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralTxPeriodsec1_A7939.StepSize = value;
			}
		}

		// Token: 0x17004BC5 RID: 19397
		// (get) Token: 0x060096D7 RID: 38615 RVA: 0x008DB864 File Offset: 0x008D9A64
		// (set) Token: 0x060096D8 RID: 38616 RVA: 0x008DB918 File Offset: 0x008D9B18
		public bool TrkEmerProfGeneralTxPeriodsec1_A7939_Applicable
		{
			get
			{
				short num = (short)935235299;
				short num2 = num;
				num = (short)1088392931;
				switch (num2 == num)
				{
				default:
				{
					num = (short)673054720;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)341114881;
				if (num != 0)
				{
				}
				num = (short)1699807232;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralTxPeriodsec1_A7939.Applicable;
			}
			set
			{
				short num = (short)887623886;
				short num2 = num;
				num = (short)310841550;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1042087936;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1351352321;
				if (num != 0)
				{
				}
				num = (short)2125266944;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralTxPeriodsec1_A7939.Applicable = value;
			}
		}

		// Token: 0x17004BC6 RID: 19398
		// (get) Token: 0x060096D9 RID: 38617 RVA: 0x008DB9CC File Offset: 0x008D9BCC
		// (set) Token: 0x060096DA RID: 38618 RVA: 0x008DBA80 File Offset: 0x008D9C80
		public bool TrkEmerProfGeneralTxPeriodsec1_A7939_Valid
		{
			get
			{
				short num = (short)2102038701;
				short num2 = num;
				num = (short)1256886445;
				switch (num2 == num)
				{
				default:
				{
					num = (short)383188992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2111504385;
				if (num != 0)
				{
				}
				num = (short)2085814272;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralTxPeriodsec1_A7939.Valid;
			}
			set
			{
				short num = (short)515661227;
				short num2 = num;
				num = (short)1137008043;
				switch (num2 == num)
				{
				default:
				{
					num = (short)572784640;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)320995329;
				if (num != 0)
				{
				}
				num = (short)1916076032;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralTxPeriodsec1_A7939.Valid = value;
			}
		}

		// Token: 0x17004BC7 RID: 19399
		// (get) Token: 0x060096DB RID: 38619 RVA: 0x008DBB34 File Offset: 0x008D9D34
		// (set) Token: 0x060096DC RID: 38620 RVA: 0x008DBBE8 File Offset: 0x008D9DE8
		public bool TrkEmerProfGeneralTxPeriodsec1_A7939_Visible
		{
			get
			{
				short num = (short)415468475;
				short num2 = num;
				num = (short)2085456827;
				switch (num2 == num)
				{
				default:
				{
					num = (short)11534336;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1298006016;
				if (num != 0)
				{
				}
				num = (short)305070081;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralTxPeriodsec1_A7939.Visible;
			}
			set
			{
				short num = (short)1382875137;
				if (num != 0)
				{
				}
				num = (short)808976384;
				short num2 = num;
				num = (short)1917005714;
				short num3 = num;
				num = (short)1503342482;
				switch (num3 == num)
				{
				}
				num = (short)1939144704;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralTxPeriodsec1_A7939.Visible = value;
			}
		}

		// Token: 0x17004BC8 RID: 19400
		// (get) Token: 0x060096DD RID: 38621 RVA: 0x008DBC9C File Offset: 0x008D9E9C
		// (set) Token: 0x060096DE RID: 38622 RVA: 0x008DBD50 File Offset: 0x008D9F50
		public bool TrkEmerProfGeneralTxPeriodsec1_A7939_Editable
		{
			get
			{
				short num = (short)1416416873;
				short num2 = num;
				num = (short)389860969;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1560477696;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2109014017;
				if (num != 0)
				{
				}
				num = (short)473694208;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralTxPeriodsec1_A7939.Editable;
			}
			set
			{
				short num = (short)1734414222;
				short num2 = num;
				num = (short)869928846;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1381433344;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)885325825;
				if (num != 0)
				{
				}
				num = (short)554500096;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralTxPeriodsec1_A7939.Editable = value;
			}
		}

		// Token: 0x17004BC9 RID: 19401
		// (get) Token: 0x060096DF RID: 38623 RVA: 0x008DBE04 File Offset: 0x008DA004
		internal string TrkEmerProfGeneralTxPeriodsec1_A7939_UILabel
		{
			get
			{
				short num = (short)2037486800;
				short num2 = num;
				num = (short)2084934864;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1057488896;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)601948161;
				if (num != 0)
				{
				}
				num = (short)1384906752;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralTxPeriodsec1_A7939.UIName;
			}
		}

		// Token: 0x17004BCA RID: 19402
		// (get) Token: 0x060096E0 RID: 38624 RVA: 0x008DBEB8 File Offset: 0x008DA0B8
		// (set) Token: 0x060096E1 RID: 38625 RVA: 0x008DBF70 File Offset: 0x008DA170
		internal bool TrkEmerProfGeneralTxPeriodsec1_A7939_HiddenStatic
		{
			get
			{
				short num = (short)638091293;
				short num2 = num;
				num = (short)477986845;
				switch (num2 == num)
				{
				default:
				{
					num = (short)111411200;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)269680641;
				if (num != 0)
				{
				}
				num = (short)120061952;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralTxPeriodsec1_A7939.HiddenStatic;
			}
			set
			{
				short num = (short)1526403896;
				short num2 = num;
				num = (short)1682379576;
				switch (num2 == num)
				{
				default:
				{
					num = (short)164823040;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)37224449;
				if (num != 0)
				{
				}
				num = (short)1772814336;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralTxPeriodsec1_A7939.HiddenStatic = value;
			}
		}

		// Token: 0x17004BCB RID: 19403
		// (get) Token: 0x060096E2 RID: 38626 RVA: 0x008DC024 File Offset: 0x008DA224
		// (set) Token: 0x060096E3 RID: 38627 RVA: 0x008DC0DC File Offset: 0x008DA2DC
		internal bool TrkEmerProfGeneralTxPeriodsec1_A7939_HiddenDynamic
		{
			get
			{
				short num = (short)1267224205;
				short num2 = num;
				num = (short)512052877;
				switch (num2 == num)
				{
				default:
				{
					num = (short)889651200;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1262485505;
				if (num != 0)
				{
				}
				num = (short)914620416;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralTxPeriodsec1_A7939.HiddenDynamic;
			}
			set
			{
				short num = (short)1676203633;
				short num2 = num;
				num = (short)160290417;
				switch (num2 == num)
				{
				default:
				{
					num = (short)872873984;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)470876161;
				if (num != 0)
				{
				}
				num = (short)457637888;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralTxPeriodsec1_A7939.HiddenDynamic = value;
			}
		}

		// Token: 0x17004BCC RID: 19404
		// (get) Token: 0x060096E4 RID: 38628 RVA: 0x008DC190 File Offset: 0x008DA390
		public bool TrkEmerProfGeneralTxPeriodsec1_A7939_HasDiffs
		{
			get
			{
				short num = (short)591540625;
				short num2 = num;
				num = (short)1943089553;
				switch (num2 == num)
				{
				default:
				{
					num = (short)274726912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)147128321;
				if (num != 0)
				{
				}
				num = (short)1360265216;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralTxPeriodsec1_A7939._HasDiffs;
			}
		}

		// Token: 0x17004BCD RID: 19405
		// (get) Token: 0x060096E5 RID: 38629 RVA: 0x008DC244 File Offset: 0x008DA444
		// (set) Token: 0x060096E6 RID: 38630 RVA: 0x008DC2F8 File Offset: 0x008DA4F8
		public int TrkEmerProfGeneralTxPeriodsec2_A9132Value
		{
			get
			{
				short num = (short)551793007;
				short num2 = num;
				num = (short)1110815087;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1325006848;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1706622976;
				if (num != 0)
				{
				}
				num = (short)799014913;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralTxPeriodsec2_A9132.Value;
			}
			set
			{
				short num = (short)1315110913;
				if (num != 0)
				{
				}
				num = (short)1313144832;
				short num2 = num;
				num = (short)843728029;
				short num3 = num;
				num = (short)488195229;
				switch (num3 == num)
				{
				}
				num = (short)159121408;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralTxPeriodsec2_A9132.Value = value;
			}
		}

		// Token: 0x17004BCE RID: 19406
		// (get) Token: 0x060096E7 RID: 38631 RVA: 0x008DC3AC File Offset: 0x008DA5AC
		public global::AcpBusinessLayer.AcpSimpleRangeField TrkEmerProfGeneralTxPeriodsec2_A9132
		{
			get
			{
				short num = (short)2069070728;
				short num2 = num;
				num = (short)717259656;
				switch (num2 == num)
				{
				default:
				{
					num = (short)382337024;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)109182977;
				if (num != 0)
				{
				}
				num = (short)2135490560;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralTxPeriodsec2_A9132;
			}
		}

		// Token: 0x17004BCF RID: 19407
		// (get) Token: 0x060096E8 RID: 38632 RVA: 0x008DC45C File Offset: 0x008DA65C
		// (set) Token: 0x060096E9 RID: 38633 RVA: 0x008DC510 File Offset: 0x008DA710
		public string TrkEmerProfGeneralTxPeriodsec2_A9132_UIValue
		{
			get
			{
				short num = (short)937500197;
				short num2 = num;
				num = (short)938876453;
				switch (num2 == num)
				{
				default:
				{
					num = (short)825163776;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1807548416;
				if (num != 0)
				{
				}
				num = (short)1083506689;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralTxPeriodsec2_A9132.UIValue;
			}
			set
			{
				short num = (short)1239534920;
				short num2 = num;
				num = (short)598461768;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1038942208;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1186201600;
				if (num != 0)
				{
				}
				num = (short)394985473;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralTxPeriodsec2_A9132.UIValue = value;
			}
		}

		// Token: 0x17004BD0 RID: 19408
		// (get) Token: 0x060096EA RID: 38634 RVA: 0x008DC5C4 File Offset: 0x008DA7C4
		// (set) Token: 0x060096EB RID: 38635 RVA: 0x008DC678 File Offset: 0x008DA878
		internal int TrkEmerProfGeneralTxPeriodsec2_A9132Min
		{
			get
			{
				short num = (short)513207278;
				short num2 = num;
				num = (short)1862200302;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2068643840;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)762707969;
				if (num != 0)
				{
				}
				num = (short)1079508992;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralTxPeriodsec2_A9132.Min;
			}
			set
			{
				short num = (short)1837261124;
				short num2 = num;
				num = (short)513696068;
				switch (num2 == num)
				{
				default:
				{
					num = (short)650117120;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1000669184;
				if (num != 0)
				{
				}
				num = (short)397541377;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralTxPeriodsec2_A9132.Min = value;
			}
		}

		// Token: 0x17004BD1 RID: 19409
		// (get) Token: 0x060096EC RID: 38636 RVA: 0x008DC72C File Offset: 0x008DA92C
		// (set) Token: 0x060096ED RID: 38637 RVA: 0x008DC7E0 File Offset: 0x008DA9E0
		internal int TrkEmerProfGeneralTxPeriodsec2_A9132Max
		{
			get
			{
				short num = (short)1887797552;
				short num2 = num;
				num = (short)1090093360;
				switch (num2 == num)
				{
				}
				num = (short)6225920;
				short num3 = num;
				num = (short)1394081792;
				if (num != 0)
				{
				}
				num = (short)1619984385;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralTxPeriodsec2_A9132.Max;
			}
			set
			{
				short num = (short)2071348655;
				short num2 = num;
				num = (short)825836975;
				switch (num2 == num)
				{
				}
				num = (short)1808400384;
				short num3 = num;
				num = (short)97058816;
				if (num != 0)
				{
				}
				num = (short)169410561;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralTxPeriodsec2_A9132.Max = value;
			}
		}

		// Token: 0x17004BD2 RID: 19410
		// (get) Token: 0x060096EE RID: 38638 RVA: 0x008DC898 File Offset: 0x008DAA98
		// (set) Token: 0x060096EF RID: 38639 RVA: 0x008DC94C File Offset: 0x008DAB4C
		internal int TrkEmerProfGeneralTxPeriodsec2_A9132Step
		{
			get
			{
				short num = (short)164149762;
				short num2 = num;
				num = (short)1532869122;
				switch (num2 == num)
				{
				}
				num = (short)1691222016;
				short num3 = num;
				num = (short)1973616640;
				if (num != 0)
				{
				}
				num = (short)1790312449;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralTxPeriodsec2_A9132.StepSize;
			}
			set
			{
				short num = (short)1728699878;
				short num2 = num;
				num = (short)703782374;
				switch (num2 == num)
				{
				}
				num = (short)822280192;
				short num3 = num;
				num = (short)289406977;
				if (num != 0)
				{
				}
				num = (short)499712000;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralTxPeriodsec2_A9132.StepSize = value;
			}
		}

		// Token: 0x17004BD3 RID: 19411
		// (get) Token: 0x060096F0 RID: 38640 RVA: 0x008DCA04 File Offset: 0x008DAC04
		// (set) Token: 0x060096F1 RID: 38641 RVA: 0x008DCAB8 File Offset: 0x008DACB8
		public bool TrkEmerProfGeneralTxPeriodsec2_A9132_Applicable
		{
			get
			{
				short num = (short)665186259;
				short num2 = num;
				num = (short)810282963;
				switch (num2 == num)
				{
				}
				num = (short)780075008;
				short num3 = num;
				num = (short)1491533825;
				if (num != 0)
				{
				}
				num = (short)100466688;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralTxPeriodsec2_A9132.Applicable;
			}
			set
			{
				short num = (short)1255246965;
				short num2 = num;
				num = (short)475499637;
				switch (num2 == num)
				{
				}
				num = (short)2061238272;
				short num3 = num;
				num = (short)2091778048;
				if (num != 0)
				{
				}
				num = (short)544866305;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralTxPeriodsec2_A9132.Applicable = value;
			}
		}

		// Token: 0x17004BD4 RID: 19412
		// (get) Token: 0x060096F2 RID: 38642 RVA: 0x008DCB6C File Offset: 0x008DAD6C
		// (set) Token: 0x060096F3 RID: 38643 RVA: 0x008DCC20 File Offset: 0x008DAE20
		public bool TrkEmerProfGeneralTxPeriodsec2_A9132_Valid
		{
			get
			{
				short num = (short)544837576;
				short num2 = num;
				num = (short)1766100936;
				switch (num2 == num)
				{
				}
				num = (short)687931392;
				short num3 = num;
				num = (short)1620246529;
				if (num != 0)
				{
				}
				num = (short)1081868288;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralTxPeriodsec2_A9132.Valid;
			}
			set
			{
				short num = (short)672137217;
				if (num != 0)
				{
				}
				num = (short)1506918591;
				short num2 = num;
				num = (short)903069887;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1958674432;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)477888512;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralTxPeriodsec2_A9132.Valid = value;
			}
		}

		// Token: 0x17004BD5 RID: 19413
		// (get) Token: 0x060096F4 RID: 38644 RVA: 0x008DCCD8 File Offset: 0x008DAED8
		// (set) Token: 0x060096F5 RID: 38645 RVA: 0x008DCD8C File Offset: 0x008DAF8C
		public bool TrkEmerProfGeneralTxPeriodsec2_A9132_Visible
		{
			get
			{
				short num = (short)507121576;
				short num2 = num;
				num = (short)2136739752;
				switch (num2 == num)
				{
				}
				num = (short)1540227072;
				short num3 = num;
				num = (short)691404801;
				if (num != 0)
				{
				}
				num = (short)490274816;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralTxPeriodsec2_A9132.Visible;
			}
			set
			{
				short num = (short)231151507;
				short num2 = num;
				num = (short)705632147;
				switch (num2 == num)
				{
				}
				num = (short)1629814784;
				short num3 = num;
				num = (short)915472385;
				if (num != 0)
				{
				}
				num = (short)1107296256;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralTxPeriodsec2_A9132.Visible = value;
			}
		}

		// Token: 0x17004BD6 RID: 19414
		// (get) Token: 0x060096F6 RID: 38646 RVA: 0x008DCE44 File Offset: 0x008DB044
		// (set) Token: 0x060096F7 RID: 38647 RVA: 0x008DCEFC File Offset: 0x008DB0FC
		public bool TrkEmerProfGeneralTxPeriodsec2_A9132_Editable
		{
			get
			{
				short num = (short)1979602110;
				short num2 = num;
				num = (short)935023806;
				switch (num2 == num)
				{
				}
				num = (short)1283784704;
				short num3 = num;
				num = (short)2114846721;
				if (num != 0)
				{
				}
				num = (short)1113260032;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralTxPeriodsec2_A9132.Editable;
			}
			set
			{
				short num = (short)957843643;
				short num2 = num;
				num = (short)1799325883;
				switch (num2 == num)
				{
				}
				num = (short)691404800;
				short num3 = num;
				num = (short)591396865;
				if (num != 0)
				{
				}
				num = (short)1127350272;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralTxPeriodsec2_A9132.Editable = value;
			}
		}

		// Token: 0x17004BD7 RID: 19415
		// (get) Token: 0x060096F8 RID: 38648 RVA: 0x008DCFB0 File Offset: 0x008DB1B0
		internal string TrkEmerProfGeneralTxPeriodsec2_A9132_UILabel
		{
			get
			{
				short num = (short)1685192705;
				if (num != 0)
				{
				}
				num = (short)97588680;
				short num2 = num;
				num = (short)1471616456;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1418854400;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)466419712;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralTxPeriodsec2_A9132.UIName;
			}
		}

		// Token: 0x17004BD8 RID: 19416
		// (get) Token: 0x060096F9 RID: 38649 RVA: 0x008DD064 File Offset: 0x008DB264
		// (set) Token: 0x060096FA RID: 38650 RVA: 0x008DD118 File Offset: 0x008DB318
		internal bool TrkEmerProfGeneralTxPeriodsec2_A9132_HiddenStatic
		{
			get
			{
				short num = (short)1211600816;
				short num2 = num;
				num = (short)1166774192;
				switch (num2 == num)
				{
				}
				num = (short)964100096;
				short num3 = num;
				num = (short)316145664;
				if (num != 0)
				{
				}
				num = (short)1486094337;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralTxPeriodsec2_A9132.HiddenStatic;
			}
			set
			{
				short num = (short)1195968048;
				short num2 = num;
				num = (short)465569328;
				switch (num2 == num)
				{
				}
				num = (short)28573696;
				short num3 = num;
				num = (short)1412366336;
				if (num != 0)
				{
				}
				num = (short)342032385;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralTxPeriodsec2_A9132.HiddenStatic = value;
			}
		}

		// Token: 0x17004BD9 RID: 19417
		// (get) Token: 0x060096FB RID: 38651 RVA: 0x008DD1CC File Offset: 0x008DB3CC
		// (set) Token: 0x060096FC RID: 38652 RVA: 0x008DD280 File Offset: 0x008DB480
		internal bool TrkEmerProfGeneralTxPeriodsec2_A9132_HiddenDynamic
		{
			get
			{
				short num = (short)1154429271;
				short num2 = num;
				num = (short)993276247;
				switch (num2 == num)
				{
				}
				num = (short)1480982528;
				short num3 = num;
				num = (short)6160385;
				if (num != 0)
				{
				}
				num = (short)1949761536;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralTxPeriodsec2_A9132.HiddenDynamic;
			}
			set
			{
				short num = (short)464477586;
				short num2 = num;
				num = (short)822697362;
				switch (num2 == num)
				{
				}
				num = (short)133758976;
				short num3 = num;
				num = (short)940441601;
				if (num != 0)
				{
				}
				num = (short)1273036800;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralTxPeriodsec2_A9132.HiddenDynamic = value;
			}
		}

		// Token: 0x17004BDA RID: 19418
		// (get) Token: 0x060096FD RID: 38653 RVA: 0x008DD334 File Offset: 0x008DB534
		public bool TrkEmerProfGeneralTxPeriodsec2_A9132_HasDiffs
		{
			get
			{
				short num = (short)1261211794;
				short num2 = num;
				num = (short)1347588242;
				switch (num2 == num)
				{
				}
				num = (short)1012596736;
				short num3 = num;
				num = (short)208863233;
				if (num != 0)
				{
				}
				num = (short)1990393856;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralTxPeriodsec2_A9132._HasDiffs;
			}
		}

		// Token: 0x17004BDB RID: 19419
		// (get) Token: 0x060096FE RID: 38654 RVA: 0x008DD3E8 File Offset: 0x008DB5E8
		// (set) Token: 0x060096FF RID: 38655 RVA: 0x008DD49C File Offset: 0x008DB69C
		public bool TrkPerManDownEnable_42039Value
		{
			get
			{
				short num = (short)1353114684;
				short num2 = num;
				num = (short)829809724;
				switch (num2 == num)
				{
				}
				num = (short)1796997120;
				short num3 = num;
				num = (short)1070923776;
				if (num != 0)
				{
				}
				num = (short)1313341441;
				if (num != 0)
				{
				}
				return this.trkPerManDownEnable_42039.Value;
			}
			set
			{
				short num = (short)1919549441;
				if (num != 0)
				{
				}
				num = (short)2048200554;
				short num2 = num;
				num = (short)713494378;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1461059584;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)802095104;
				if (num != 0)
				{
				}
				this.trkPerManDownEnable_42039.Value = value;
			}
		}

		// Token: 0x17004BDC RID: 19420
		// (get) Token: 0x06009700 RID: 38656 RVA: 0x008DD554 File Offset: 0x008DB754
		public global::AcpBusinessLayer.AcpField<bool> TrkPerManDownEnable_42039
		{
			get
			{
				short num = (short)2069338175;
				short num2 = num;
				num = (short)1360959551;
				switch (num2 == num)
				{
				}
				num = (short)57344000;
				short num3 = num;
				num = (short)1572012033;
				if (num != 0)
				{
				}
				num = (short)1878458368;
				if (num != 0)
				{
				}
				return this.trkPerManDownEnable_42039;
			}
		}

		// Token: 0x17004BDD RID: 19421
		// (get) Token: 0x06009701 RID: 38657 RVA: 0x008DD604 File Offset: 0x008DB804
		// (set) Token: 0x06009702 RID: 38658 RVA: 0x008DD6B8 File Offset: 0x008DB8B8
		public bool TrkPerManDownEnable_42039_UIValue
		{
			get
			{
				short num = (short)1450756234;
				short num2 = num;
				num = (short)1194379402;
				switch (num2 == num)
				{
				}
				num = (short)798490624;
				short num3 = num;
				num = (short)849018880;
				if (num != 0)
				{
				}
				num = (short)1497366529;
				if (num != 0)
				{
				}
				return this.trkPerManDownEnable_42039.Value;
			}
			set
			{
				short num = (short)1554626721;
				short num2 = num;
				num = (short)1671346337;
				switch (num2 == num)
				{
				}
				num = (short)905314304;
				short num3 = num;
				num = (short)941883393;
				if (num != 0)
				{
				}
				num = (short)1959723008;
				if (num != 0)
				{
				}
				this.trkPerManDownEnable_42039.Value = value;
			}
		}

		// Token: 0x17004BDE RID: 19422
		// (get) Token: 0x06009703 RID: 38659 RVA: 0x008DD76C File Offset: 0x008DB96C
		// (set) Token: 0x06009704 RID: 38660 RVA: 0x008DD820 File Offset: 0x008DBA20
		public bool TrkPerManDownEnable_42039_Applicable
		{
			get
			{
				short num = (short)1903398288;
				short num2 = num;
				num = (short)647925136;
				switch (num2 == num)
				{
				}
				num = (short)1982201856;
				short num3 = num;
				num = (short)1930297344;
				if (num != 0)
				{
				}
				num = (short)1953497089;
				if (num != 0)
				{
				}
				return this.trkPerManDownEnable_42039.Applicable;
			}
			set
			{
				short num = (short)644802425;
				short num2 = num;
				num = (short)337373049;
				switch (num2 == num)
				{
				}
				num = (short)1518403584;
				short num3 = num;
				num = (short)700383233;
				if (num != 0)
				{
				}
				num = (short)2058616832;
				if (num != 0)
				{
				}
				this.trkPerManDownEnable_42039.Applicable = value;
			}
		}

		// Token: 0x17004BDF RID: 19423
		// (get) Token: 0x06009705 RID: 38661 RVA: 0x008DD8D8 File Offset: 0x008DBAD8
		// (set) Token: 0x06009706 RID: 38662 RVA: 0x008DD98C File Offset: 0x008DBB8C
		public bool TrkPerManDownEnable_42039_Valid
		{
			get
			{
				short num = (short)140108758;
				short num2 = num;
				num = (short)1295705046;
				switch (num2 == num)
				{
				}
				num = (short)2035548160;
				short num3 = num;
				num = (short)692715521;
				if (num != 0)
				{
				}
				num = (short)1445593088;
				if (num != 0)
				{
				}
				return this.trkPerManDownEnable_42039.Valid;
			}
			set
			{
				short num = (short)989119061;
				short num2 = num;
				num = (short)1270989397;
				switch (num2 == num)
				{
				}
				num = (short)807272448;
				short num3 = num;
				num = (short)1150222336;
				if (num != 0)
				{
				}
				num = (short)768147457;
				if (num != 0)
				{
				}
				this.trkPerManDownEnable_42039.Valid = value;
			}
		}

		// Token: 0x17004BE0 RID: 19424
		// (get) Token: 0x06009707 RID: 38663 RVA: 0x008DDA40 File Offset: 0x008DBC40
		// (set) Token: 0x06009708 RID: 38664 RVA: 0x008DDAF4 File Offset: 0x008DBCF4
		public bool TrkPerManDownEnable_42039_Visible
		{
			get
			{
				short num = (short)696868022;
				short num2 = num;
				num = (short)951803062;
				switch (num2 == num)
				{
				}
				num = (short)1955594240;
				short num3 = num;
				num = (short)591724545;
				if (num != 0)
				{
				}
				num = (short)1623719936;
				if (num != 0)
				{
				}
				return this.trkPerManDownEnable_42039.Visible;
			}
			set
			{
				short num = (short)655360001;
				if (num != 0)
				{
				}
				num = (short)125123070;
				short num2 = num;
				num = (short)278608382;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1522466816;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1097596928;
				if (num != 0)
				{
				}
				this.trkPerManDownEnable_42039.Visible = value;
			}
		}

		// Token: 0x17004BE1 RID: 19425
		// (get) Token: 0x06009709 RID: 38665 RVA: 0x008DDBA8 File Offset: 0x008DBDA8
		// (set) Token: 0x0600970A RID: 38666 RVA: 0x008DDC58 File Offset: 0x008DBE58
		public bool TrkPerManDownEnable_42039_Editable
		{
			get
			{
				short num = (short)1869681810;
				short num2 = num;
				num = (short)1316099218;
				switch (num2 == num)
				{
				}
				num = (short)973471744;
				short num3 = num;
				num = (short)1038876673;
				if (num != 0)
				{
				}
				num = (short)1062010880;
				if (num != 0)
				{
				}
				return this.trkPerManDownEnable_42039.Editable;
			}
			set
			{
				short num = (short)1318715393;
				if (num != 0)
				{
				}
				num = (short)520060261;
				short num2 = num;
				num = (short)35421541;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1368457216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1124859904;
				if (num != 0)
				{
				}
				this.trkPerManDownEnable_42039.Editable = value;
			}
		}

		// Token: 0x17004BE2 RID: 19426
		// (get) Token: 0x0600970B RID: 38667 RVA: 0x008DDD0C File Offset: 0x008DBF0C
		internal string TrkPerManDownEnable_42039_UILabel
		{
			get
			{
				short num = (short)494307665;
				short num2 = num;
				num = (short)1979353425;
				switch (num2 == num)
				{
				}
				num = (short)405012480;
				short num3 = num;
				num = (short)1293549568;
				if (num != 0)
				{
				}
				num = (short)827588609;
				if (num != 0)
				{
				}
				return this.trkPerManDownEnable_42039.UIName;
			}
		}

		// Token: 0x17004BE3 RID: 19427
		// (get) Token: 0x0600970C RID: 38668 RVA: 0x008DDDC4 File Offset: 0x008DBFC4
		// (set) Token: 0x0600970D RID: 38669 RVA: 0x008DDE78 File Offset: 0x008DC078
		internal bool TrkPerManDownEnable_42039_HiddenStatic
		{
			get
			{
				short num = (short)533793998;
				short num2 = num;
				num = (short)486018254;
				switch (num2 == num)
				{
				}
				num = (short)341377024;
				short num3 = num;
				num = (short)395771904;
				if (num != 0)
				{
				}
				num = (short)302841857;
				if (num != 0)
				{
				}
				return this.trkPerManDownEnable_42039.HiddenStatic;
			}
			set
			{
				short num = (short)1020987675;
				short num2 = num;
				num = (short)580782363;
				switch (num2 == num)
				{
				}
				num = (short)1199898624;
				short num3 = num;
				num = (short)2074673153;
				if (num != 0)
				{
				}
				num = (short)1659961344;
				if (num != 0)
				{
				}
				this.trkPerManDownEnable_42039.HiddenStatic = value;
			}
		}

		// Token: 0x17004BE4 RID: 19428
		// (get) Token: 0x0600970E RID: 38670 RVA: 0x008DDF30 File Offset: 0x008DC130
		// (set) Token: 0x0600970F RID: 38671 RVA: 0x008DDFE4 File Offset: 0x008DC1E4
		internal bool TrkPerManDownEnable_42039_HiddenDynamic
		{
			get
			{
				short num = (short)1173360050;
				short num2 = num;
				num = (short)2094271922;
				switch (num2 == num)
				{
				}
				num = (short)1547370496;
				short num3 = num;
				num = (short)1248788481;
				if (num != 0)
				{
				}
				num = (short)1716977664;
				if (num != 0)
				{
				}
				return this.trkPerManDownEnable_42039.HiddenDynamic;
			}
			set
			{
				short num = (short)675990303;
				short num2 = num;
				num = (short)792906527;
				switch (num2 == num)
				{
				}
				num = (short)165609472;
				short num3 = num;
				num = (short)1033043969;
				if (num != 0)
				{
				}
				num = (short)1961623552;
				if (num != 0)
				{
				}
				this.trkPerManDownEnable_42039.HiddenDynamic = value;
			}
		}

		// Token: 0x17004BE5 RID: 19429
		// (get) Token: 0x06009710 RID: 38672 RVA: 0x008DE09C File Offset: 0x008DC29C
		public bool TrkPerManDownEnable_42039_HasDiffs
		{
			get
			{
				short num = (short)435213994;
				short num2 = num;
				num = (short)1347081898;
				switch (num2 == num)
				{
				}
				num = (short)2042953728;
				short num3 = num;
				num = (short)752156672;
				if (num != 0)
				{
				}
				num = (short)1369112577;
				if (num != 0)
				{
				}
				return this.trkPerManDownEnable_42039._HasDiffs;
			}
		}

		// Token: 0x17004BE6 RID: 19430
		// (get) Token: 0x06009711 RID: 38673 RVA: 0x008DE150 File Offset: 0x008DC350
		// (set) Token: 0x06009712 RID: 38674 RVA: 0x008DE200 File Offset: 0x008DC400
		public int TrkEmerProfEmergencyHotAuxMic_A42300Value
		{
			get
			{
				short num = (short)1551728580;
				short num2 = num;
				num = (short)1598455748;
				switch (num2 == num)
				{
				}
				num = (short)1111097344;
				short num3 = num;
				num = (short)1204551681;
				if (num != 0)
				{
				}
				num = (short)1886584832;
				if (num != 0)
				{
				}
				return this.trkEmerProfEmergencyHotAuxMic_A42300.Value;
			}
			set
			{
				short num = (short)2095291367;
				short num2 = num;
				num = (short)1952816103;
				switch (num2 == num)
				{
				}
				num = (short)1460273152;
				short num3 = num;
				num = (short)780992513;
				if (num != 0)
				{
				}
				num = (short)1546780672;
				if (num != 0)
				{
				}
				this.trkEmerProfEmergencyHotAuxMic_A42300.Value = value;
			}
		}

		// Token: 0x17004BE7 RID: 19431
		// (get) Token: 0x06009713 RID: 38675 RVA: 0x008DE2B4 File Offset: 0x008DC4B4
		// (set) Token: 0x06009714 RID: 38676 RVA: 0x008DE368 File Offset: 0x008DC568
		public string TrkEmerProfEmergencyHotAuxMic_A42300_UIValue
		{
			get
			{
				short num = (short)1102488349;
				short num2 = num;
				num = (short)521184029;
				switch (num2 == num)
				{
				}
				num = (short)426967040;
				short num3 = num;
				num = (short)1939800065;
				if (num != 0)
				{
				}
				num = (short)1729822720;
				if (num != 0)
				{
				}
				return this.trkEmerProfEmergencyHotAuxMic_A42300.UIValue;
			}
			set
			{
				short num = (short)1158823585;
				short num2 = num;
				num = (short)962870945;
				switch (num2 == num)
				{
				}
				num = (short)1888092160;
				short num3 = num;
				num = (short)462553089;
				if (num != 0)
				{
				}
				num = (short)467533824;
				if (num != 0)
				{
				}
				this.trkEmerProfEmergencyHotAuxMic_A42300.UIValue = value;
			}
		}

		// Token: 0x17004BE8 RID: 19432
		// (get) Token: 0x06009715 RID: 38677 RVA: 0x008DE41C File Offset: 0x008DC61C
		public global::AcpBusinessLayer.AcpListField TrkEmerProfEmergencyHotAuxMic_A42300
		{
			get
			{
				short num = (short)1754287822;
				short num2 = num;
				num = (short)2136100558;
				switch (num2 == num)
				{
				}
				num = (short)814481408;
				short num3 = num;
				num = (short)1066663937;
				if (num != 0)
				{
				}
				num = (short)384892928;
				if (num != 0)
				{
				}
				return this.trkEmerProfEmergencyHotAuxMic_A42300;
			}
		}

		// Token: 0x17004BE9 RID: 19433
		// (get) Token: 0x06009716 RID: 38678 RVA: 0x008DE4CC File Offset: 0x008DC6CC
		// (set) Token: 0x06009717 RID: 38679 RVA: 0x008DE584 File Offset: 0x008DC784
		public bool TrkEmerProfEmergencyHotAuxMic_A42300_Applicable
		{
			get
			{
				short num = (short)1587119399;
				short num2 = num;
				num = (short)254903591;
				switch (num2 == num)
				{
				}
				num = (short)1924333568;
				short num3 = num;
				num = (short)946667520;
				if (num != 0)
				{
				}
				num = (short)1777729537;
				if (num != 0)
				{
				}
				return this.trkEmerProfEmergencyHotAuxMic_A42300.Applicable;
			}
			set
			{
				short num = (short)481847434;
				short num2 = num;
				num = (short)1873569930;
				switch (num2 == num)
				{
				}
				num = (short)1969815552;
				short num3 = num;
				num = (short)511639552;
				if (num != 0)
				{
				}
				num = (short)2027683841;
				if (num != 0)
				{
				}
				this.trkEmerProfEmergencyHotAuxMic_A42300.Applicable = value;
			}
		}

		// Token: 0x17004BEA RID: 19434
		// (get) Token: 0x06009718 RID: 38680 RVA: 0x008DE640 File Offset: 0x008DC840
		// (set) Token: 0x06009719 RID: 38681 RVA: 0x008DE6F4 File Offset: 0x008DC8F4
		public bool TrkEmerProfEmergencyHotAuxMic_A42300_Valid
		{
			get
			{
				short num = (short)393217;
				if (num != 0)
				{
				}
				num = (short)1178386041;
				short num2 = num;
				num = (short)1546305145;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1422393344;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1120600064;
				if (num != 0)
				{
				}
				return this.trkEmerProfEmergencyHotAuxMic_A42300.Valid;
			}
			set
			{
				short num = (short)1714210257;
				short num2 = num;
				num = (short)1116128721;
				switch (num2 == num)
				{
				}
				num = (short)1895628800;
				short num3 = num;
				num = (short)739115008;
				if (num != 0)
				{
				}
				num = (short)2025259009;
				if (num != 0)
				{
				}
				this.trkEmerProfEmergencyHotAuxMic_A42300.Valid = value;
			}
		}

		// Token: 0x17004BEB RID: 19435
		// (get) Token: 0x0600971A RID: 38682 RVA: 0x008DE7A8 File Offset: 0x008DC9A8
		// (set) Token: 0x0600971B RID: 38683 RVA: 0x008DE860 File Offset: 0x008DCA60
		public bool TrkEmerProfEmergencyHotAuxMic_A42300_Visible
		{
			get
			{
				short num = (short)310952104;
				short num2 = num;
				num = (short)1836499112;
				switch (num2 == num)
				{
				}
				num = (short)679739392;
				short num3 = num;
				num = (short)385482753;
				if (num != 0)
				{
				}
				num = (short)1551826944;
				if (num != 0)
				{
				}
				return this.trkEmerProfEmergencyHotAuxMic_A42300.Visible;
			}
			set
			{
				short num = (short)842834400;
				short num2 = num;
				num = (short)906469856;
				switch (num2 == num)
				{
				}
				num = (short)357433344;
				short num3 = num;
				num = (short)1986985984;
				if (num != 0)
				{
				}
				num = (short)1806303233;
				if (num != 0)
				{
				}
				this.trkEmerProfEmergencyHotAuxMic_A42300.Visible = value;
			}
		}

		// Token: 0x17004BEC RID: 19436
		// (get) Token: 0x0600971C RID: 38684 RVA: 0x008DE914 File Offset: 0x008DCB14
		// (set) Token: 0x0600971D RID: 38685 RVA: 0x008DE9C8 File Offset: 0x008DCBC8
		public bool TrkEmerProfEmergencyHotAuxMic_A42300_Editable
		{
			get
			{
				short num = (short)1315547967;
				short num2 = num;
				num = (short)2092477247;
				switch (num2 == num)
				{
				}
				num = (short)995229696;
				short num3 = num;
				num = (short)1174011904;
				if (num != 0)
				{
				}
				num = (short)816250881;
				if (num != 0)
				{
				}
				return this.trkEmerProfEmergencyHotAuxMic_A42300.Editable;
			}
			set
			{
				short num = (short)1429214021;
				short num2 = num;
				num = (short)1318982469;
				switch (num2 == num)
				{
				}
				num = (short)1278607360;
				short num3 = num;
				num = (short)530186241;
				if (num != 0)
				{
				}
				num = (short)535232512;
				if (num != 0)
				{
				}
				this.trkEmerProfEmergencyHotAuxMic_A42300.Editable = value;
			}
		}

		// Token: 0x17004BED RID: 19437
		// (get) Token: 0x0600971E RID: 38686 RVA: 0x008DEA80 File Offset: 0x008DCC80
		internal string TrkEmerProfEmergencyHotAuxMic_A42300_UILabel
		{
			get
			{
				short num = (short)1022698997;
				short num2 = num;
				num = (short)1492592117;
				switch (num2 == num)
				{
				}
				num = (short)117768192;
				short num3 = num;
				num = (short)400818177;
				if (num != 0)
				{
				}
				num = (short)297598976;
				if (num != 0)
				{
				}
				return this.trkEmerProfEmergencyHotAuxMic_A42300.UIName;
			}
		}

		// Token: 0x17004BEE RID: 19438
		// (get) Token: 0x0600971F RID: 38687 RVA: 0x008DEB34 File Offset: 0x008DCD34
		// (set) Token: 0x06009720 RID: 38688 RVA: 0x008DEBE8 File Offset: 0x008DCDE8
		internal bool TrkEmerProfEmergencyHotAuxMic_A42300_HiddenStatic
		{
			get
			{
				short num = (short)758943122;
				short num2 = num;
				num = (short)1636470162;
				switch (num2 == num)
				{
				}
				num = (short)743571456;
				short num3 = num;
				num = (short)609812481;
				if (num != 0)
				{
				}
				num = (short)581238784;
				if (num != 0)
				{
				}
				return this.trkEmerProfEmergencyHotAuxMic_A42300.HiddenStatic;
			}
			set
			{
				short num = (short)1891172353;
				if (num != 0)
				{
				}
				num = (short)2005854476;
				short num2 = num;
				num = (short)40626444;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2095513600;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1419837440;
				if (num != 0)
				{
				}
				this.trkEmerProfEmergencyHotAuxMic_A42300.HiddenStatic = value;
			}
		}

		// Token: 0x17004BEF RID: 19439
		// (get) Token: 0x06009721 RID: 38689 RVA: 0x008DEC9C File Offset: 0x008DCE9C
		// (set) Token: 0x06009722 RID: 38690 RVA: 0x008DED54 File Offset: 0x008DCF54
		internal bool TrkEmerProfEmergencyHotAuxMic_A42300_HiddenDynamic
		{
			get
			{
				short num = (short)767417476;
				short num2 = num;
				num = (short)162126980;
				switch (num2 == num)
				{
				}
				num = (short)849477632;
				short num3 = num;
				num = (short)852688897;
				if (num != 0)
				{
				}
				num = (short)1664024576;
				if (num != 0)
				{
				}
				return this.trkEmerProfEmergencyHotAuxMic_A42300.HiddenDynamic;
			}
			set
			{
				short num = (short)1798949124;
				short num2 = num;
				num = (short)1651099908;
				switch (num2 == num)
				{
				}
				num = (short)1487536128;
				short num3 = num;
				num = (short)2040070145;
				if (num != 0)
				{
				}
				num = (short)361299968;
				if (num != 0)
				{
				}
				this.trkEmerProfEmergencyHotAuxMic_A42300.HiddenDynamic = value;
			}
		}

		// Token: 0x17004BF0 RID: 19440
		// (get) Token: 0x06009723 RID: 38691 RVA: 0x008DEE08 File Offset: 0x008DD008
		public bool TrkEmerProfEmergencyHotAuxMic_A42300_HasDiffs
		{
			get
			{
				short num = (short)1328461989;
				short num2 = num;
				num = (short)688437413;
				switch (num2 == num)
				{
				}
				num = (short)1280311296;
				short num3 = num;
				num = (short)397017089;
				if (num != 0)
				{
				}
				num = (short)1773469696;
				if (num != 0)
				{
				}
				return this.trkEmerProfEmergencyHotAuxMic_A42300._HasDiffs;
			}
		}

		// Token: 0x17004BF1 RID: 19441
		// (get) Token: 0x06009724 RID: 38692 RVA: 0x008DEEC0 File Offset: 0x008DD0C0
		// (set) Token: 0x06009725 RID: 38693 RVA: 0x008DEF74 File Offset: 0x008DD174
		public bool TrkPeEMGFindMeTxEnable_42921Value
		{
			get
			{
				short num = (short)143691021;
				short num2 = num;
				num = (short)675187981;
				switch (num2 == num)
				{
				}
				num = (short)1537409024;
				short num3 = num;
				num = (short)1720385537;
				if (num != 0)
				{
				}
				num = (short)1801519104;
				if (num != 0)
				{
				}
				return this.trkPeEMGFindMeTxEnable_42921.Value;
			}
			set
			{
				short num = (short)1009527922;
				short num2 = num;
				num = (short)707341426;
				switch (num2 == num)
				{
				}
				num = (short)1311440896;
				short num3 = num;
				num = (short)1451556864;
				if (num != 0)
				{
				}
				num = (short)874053633;
				if (num != 0)
				{
				}
				this.trkPeEMGFindMeTxEnable_42921.Value = value;
			}
		}

		// Token: 0x17004BF2 RID: 19442
		// (get) Token: 0x06009726 RID: 38694 RVA: 0x008DF02C File Offset: 0x008DD22C
		public global::AcpBusinessLayer.AcpField<bool> TrkPeEMGFindMeTxEnable_42921
		{
			get
			{
				short num = (short)1262417517;
				short num2 = num;
				num = (short)741799533;
				switch (num2 == num)
				{
				}
				num = (short)458424320;
				short num3 = num;
				num = (short)1580793857;
				if (num != 0)
				{
				}
				num = (short)1460011008;
				if (num != 0)
				{
				}
				return this.trkPeEMGFindMeTxEnable_42921;
			}
		}

		// Token: 0x17004BF3 RID: 19443
		// (get) Token: 0x06009727 RID: 38695 RVA: 0x008DF0DC File Offset: 0x008DD2DC
		// (set) Token: 0x06009728 RID: 38696 RVA: 0x008DF18C File Offset: 0x008DD38C
		public bool TrkPeEMGFindMeTxEnable_42921_UIValue
		{
			get
			{
				short num = (short)177212412;
				short num2 = num;
				num = (short)1839074300;
				switch (num2 == num)
				{
				}
				num = (short)373948416;
				short num3 = num;
				num = (short)1482162176;
				if (num != 0)
				{
				}
				num = (short)778436609;
				if (num != 0)
				{
				}
				return this.trkPeEMGFindMeTxEnable_42921.Value;
			}
			set
			{
				short num = (short)1541196320;
				short num2 = num;
				num = (short)1739967008;
				switch (num2 == num)
				{
				}
				num = (short)2018902016;
				short num3 = num;
				num = (short)1363279872;
				if (num != 0)
				{
				}
				num = (short)1230635009;
				if (num != 0)
				{
				}
				this.trkPeEMGFindMeTxEnable_42921.Value = value;
			}
		}

		// Token: 0x17004BF4 RID: 19444
		// (get) Token: 0x06009729 RID: 38697 RVA: 0x008DF240 File Offset: 0x008DD440
		// (set) Token: 0x0600972A RID: 38698 RVA: 0x008DF2F4 File Offset: 0x008DD4F4
		public bool TrkPeEMGFindMeTxEnable_42921_Applicable
		{
			get
			{
				short num = (short)22216705;
				if (num != 0)
				{
				}
				num = (short)1575432977;
				short num2 = num;
				num = (short)99955473;
				switch (num2 == num)
				{
				}
				num = (short)1643184128;
				if (num != 0)
				{
				}
				num = (short)1895170048;
				short num3 = num;
				return this.trkPeEMGFindMeTxEnable_42921.Applicable;
			}
			set
			{
				short num = (short)1660389057;
				short num2 = num;
				num = (short)1252492993;
				switch (num2 == num)
				{
				}
				num = (short)1231880192;
				if (num != 0)
				{
				}
				num = (short)2075066369;
				if (num != 0)
				{
				}
				num = (short)596443136;
				short num3 = num;
				this.trkPeEMGFindMeTxEnable_42921.Applicable = value;
			}
		}

		// Token: 0x17004BF5 RID: 19445
		// (get) Token: 0x0600972B RID: 38699 RVA: 0x008DF3AC File Offset: 0x008DD5AC
		// (set) Token: 0x0600972C RID: 38700 RVA: 0x008DF460 File Offset: 0x008DD660
		public bool TrkPeEMGFindMeTxEnable_42921_Valid
		{
			get
			{
				short num = (short)10289153;
				if (num != 0)
				{
				}
				num = (short)993327893;
				short num2 = num;
				num = (short)1688861461;
				switch (num2 == num)
				{
				}
				num = (short)2034040832;
				if (num != 0)
				{
				}
				num = (short)533594112;
				short num3 = num;
				return this.trkPeEMGFindMeTxEnable_42921.Valid;
			}
			set
			{
				short num = (short)2078054957;
				short num2 = num;
				num = (short)540711469;
				switch (num2 == num)
				{
				}
				num = (short)1122435073;
				if (num != 0)
				{
				}
				num = (short)1670578176;
				if (num != 0)
				{
				}
				num = (short)1593704448;
				short num3 = num;
				this.trkPeEMGFindMeTxEnable_42921.Valid = value;
			}
		}

		// Token: 0x17004BF6 RID: 19446
		// (get) Token: 0x0600972D RID: 38701 RVA: 0x008DF514 File Offset: 0x008DD714
		// (set) Token: 0x0600972E RID: 38702 RVA: 0x008DF5C8 File Offset: 0x008DD7C8
		public bool TrkPeEMGFindMeTxEnable_42921_Visible
		{
			get
			{
				short num = (short)1794231149;
				short num2 = num;
				num = (short)1529531245;
				switch (num2 == num)
				{
				}
				num = (short)1751646209;
				if (num != 0)
				{
				}
				num = (short)318439424;
				if (num != 0)
				{
				}
				num = (short)1889009664;
				short num3 = num;
				return this.trkPeEMGFindMeTxEnable_42921.Visible;
			}
			set
			{
				short num = (short)1864268780;
				short num2 = num;
				num = (short)808877036;
				switch (num2 == num)
				{
				}
				num = (short)797704193;
				if (num != 0)
				{
				}
				num = (short)78643200;
				if (num != 0)
				{
				}
				num = (short)1048641536;
				short num3 = num;
				this.trkPeEMGFindMeTxEnable_42921.Visible = value;
			}
		}

		// Token: 0x17004BF7 RID: 19447
		// (get) Token: 0x0600972F RID: 38703 RVA: 0x008DF680 File Offset: 0x008DD880
		// (set) Token: 0x06009730 RID: 38704 RVA: 0x008DF734 File Offset: 0x008DD934
		public bool TrkPeEMGFindMeTxEnable_42921_Editable
		{
			get
			{
				short num = (short)664603821;
				short num2 = num;
				num = (short)1313803437;
				switch (num2 == num)
				{
				}
				num = (short)1006305281;
				if (num != 0)
				{
				}
				num = (short)1175388160;
				if (num != 0)
				{
				}
				num = (short)1723072512;
				short num3 = num;
				return this.trkPeEMGFindMeTxEnable_42921.Editable;
			}
			set
			{
				short num = (short)2000519678;
				short num2 = num;
				num = (short)528122366;
				switch (num2 == num)
				{
				}
				num = (short)531693569;
				if (num != 0)
				{
				}
				num = (short)390266880;
				if (num != 0)
				{
				}
				num = (short)1536819200;
				short num3 = num;
				this.trkPeEMGFindMeTxEnable_42921.Editable = value;
			}
		}

		// Token: 0x17004BF8 RID: 19448
		// (get) Token: 0x06009731 RID: 38705 RVA: 0x008DF7E8 File Offset: 0x008DD9E8
		internal string TrkPeEMGFindMeTxEnable_42921_UILabel
		{
			get
			{
				short num = (short)1439120144;
				short num2 = num;
				num = (short)934361872;
				switch (num2 == num)
				{
				}
				num = (short)1944977409;
				if (num != 0)
				{
				}
				num = (short)981598208;
				if (num != 0)
				{
				}
				num = (short)1499987968;
				short num3 = num;
				return this.trkPeEMGFindMeTxEnable_42921.UIName;
			}
		}

		// Token: 0x17004BF9 RID: 19449
		// (get) Token: 0x06009732 RID: 38706 RVA: 0x008DF89C File Offset: 0x008DDA9C
		// (set) Token: 0x06009733 RID: 38707 RVA: 0x008DF950 File Offset: 0x008DDB50
		internal bool TrkPeEMGFindMeTxEnable_42921_HiddenStatic
		{
			get
			{
				short num = (short)967006892;
				short num2 = num;
				num = (short)895965868;
				switch (num2 == num)
				{
				}
				num = (short)1946091520;
				if (num != 0)
				{
				}
				num = (short)1647247361;
				if (num != 0)
				{
				}
				num = (short)584843264;
				short num3 = num;
				return this.trkPeEMGFindMeTxEnable_42921.HiddenStatic;
			}
			set
			{
				short num = (short)2050088398;
				short num2 = num;
				num = (short)1392565710;
				switch (num2 == num)
				{
				}
				num = (short)1198325760;
				if (num != 0)
				{
				}
				num = (short)1984233473;
				if (num != 0)
				{
				}
				num = (short)1786839040;
				short num3 = num;
				this.trkPeEMGFindMeTxEnable_42921.HiddenStatic = value;
			}
		}

		// Token: 0x17004BFA RID: 19450
		// (get) Token: 0x06009734 RID: 38708 RVA: 0x008DFA04 File Offset: 0x008DDC04
		// (set) Token: 0x06009735 RID: 38709 RVA: 0x008DFABC File Offset: 0x008DDCBC
		internal bool TrkPeEMGFindMeTxEnable_42921_HiddenDynamic
		{
			get
			{
				short num = (short)1711862955;
				short num2 = num;
				num = (short)421983403;
				switch (num2 == num)
				{
				}
				num = (short)8192000;
				if (num != 0)
				{
				}
				num = (short)473432065;
				if (num != 0)
				{
				}
				num = (short)1653669888;
				short num3 = num;
				return this.trkPeEMGFindMeTxEnable_42921.HiddenDynamic;
			}
			set
			{
				short num = (short)1821589790;
				short num2 = num;
				num = (short)1477329182;
				switch (num2 == num)
				{
				}
				num = (short)1417216001;
				if (num != 0)
				{
				}
				num = (short)276889600;
				if (num != 0)
				{
				}
				num = (short)1342308352;
				short num3 = num;
				this.trkPeEMGFindMeTxEnable_42921.HiddenDynamic = value;
			}
		}

		// Token: 0x17004BFB RID: 19451
		// (get) Token: 0x06009736 RID: 38710 RVA: 0x008DFB70 File Offset: 0x008DDD70
		public bool TrkPeEMGFindMeTxEnable_42921_HasDiffs
		{
			get
			{
				short num = (short)1986908360;
				short num2 = num;
				num = (short)1652871368;
				switch (num2 == num)
				{
				}
				num = (short)312147969;
				if (num != 0)
				{
				}
				num = (short)836304896;
				if (num != 0)
				{
				}
				num = (short)1915879424;
				short num3 = num;
				return this.trkPeEMGFindMeTxEnable_42921._HasDiffs;
			}
		}

		// Token: 0x17004BFC RID: 19452
		// (get) Token: 0x06009737 RID: 38711 RVA: 0x008DFC24 File Offset: 0x008DDE24
		// (set) Token: 0x06009738 RID: 38712 RVA: 0x008DFCD8 File Offset: 0x008DDED8
		public bool TrkPeEMGFindMeRxEnable_42923Value
		{
			get
			{
				short num = (short)106758145;
				if (num != 0)
				{
				}
				num = (short)1233930609;
				short num2 = num;
				num = (short)327567729;
				switch (num2 == num)
				{
				}
				num = (short)1229979648;
				if (num != 0)
				{
				}
				num = (short)861405184;
				short num3 = num;
				return this.trkPeEMGFindMeRxEnable_42923.Value;
			}
			set
			{
				short num = (short)685589347;
				short num2 = num;
				num = (short)236929891;
				switch (num2 == num)
				{
				}
				num = (short)2103902208;
				if (num != 0)
				{
				}
				num = (short)1561198593;
				if (num != 0)
				{
				}
				num = (short)905904128;
				short num3 = num;
				this.trkPeEMGFindMeRxEnable_42923.Value = value;
			}
		}

		// Token: 0x17004BFD RID: 19453
		// (get) Token: 0x06009739 RID: 38713 RVA: 0x008DFD8C File Offset: 0x008DDF8C
		public global::AcpBusinessLayer.AcpField<bool> TrkPeEMGFindMeRxEnable_42923
		{
			get
			{
				short num = (short)1213681687;
				short num2 = num;
				num = (short)895832087;
				switch (num2 == num)
				{
				}
				num = (short)1292894209;
				if (num != 0)
				{
				}
				num = (short)1467809792;
				if (num != 0)
				{
				}
				num = (short)163250176;
				short num3 = num;
				return this.trkPeEMGFindMeRxEnable_42923;
			}
		}

		// Token: 0x17004BFE RID: 19454
		// (get) Token: 0x0600973A RID: 38714 RVA: 0x008DFE3C File Offset: 0x008DE03C
		// (set) Token: 0x0600973B RID: 38715 RVA: 0x008DFEF0 File Offset: 0x008DE0F0
		public bool TrkPeEMGFindMeRxEnable_42923_UIValue
		{
			get
			{
				short num = (short)322227991;
				short num2 = num;
				num = (short)1274400535;
				switch (num2 == num)
				{
				}
				num = (short)338296832;
				if (num != 0)
				{
				}
				num = (short)1101398017;
				if (num != 0)
				{
				}
				num = (short)1873674240;
				short num3 = num;
				return this.trkPeEMGFindMeRxEnable_42923.Value;
			}
			set
			{
				short num = (short)868753831;
				short num2 = num;
				num = (short)873144743;
				switch (num2 == num)
				{
				}
				num = (short)1167196160;
				if (num != 0)
				{
				}
				num = (short)361234433;
				if (num != 0)
				{
				}
				num = (short)260636672;
				short num3 = num;
				this.trkPeEMGFindMeRxEnable_42923.Value = value;
			}
		}

		// Token: 0x17004BFF RID: 19455
		// (get) Token: 0x0600973C RID: 38716 RVA: 0x008DFFA8 File Offset: 0x008DE1A8
		// (set) Token: 0x0600973D RID: 38717 RVA: 0x008E0060 File Offset: 0x008DE260
		public bool TrkPeEMGFindMeRxEnable_42923_Applicable
		{
			get
			{
				short num = (short)456663854;
				short num2 = num;
				num = (short)1254564654;
				switch (num2 == num)
				{
				}
				num = (short)741933057;
				if (num != 0)
				{
				}
				num = (short)1530331136;
				if (num != 0)
				{
				}
				num = (short)292356096;
				short num3 = num;
				return this.trkPeEMGFindMeRxEnable_42923.Applicable;
			}
			set
			{
				short num = (short)594681973;
				short num2 = num;
				num = (short)1804607605;
				switch (num2 == num)
				{
				}
				num = (short)1680801793;
				if (num != 0)
				{
				}
				num = (short)508231680;
				if (num != 0)
				{
				}
				num = (short)1757020160;
				short num3 = num;
				this.trkPeEMGFindMeRxEnable_42923.Applicable = value;
			}
		}

		// Token: 0x17004C00 RID: 19456
		// (get) Token: 0x0600973E RID: 38718 RVA: 0x008E0118 File Offset: 0x008DE318
		// (set) Token: 0x0600973F RID: 38719 RVA: 0x008E01CC File Offset: 0x008DE3CC
		public bool TrkPeEMGFindMeRxEnable_42923_Valid
		{
			get
			{
				short num = (short)1908715895;
				short num2 = num;
				num = (short)943239543;
				switch (num2 == num)
				{
				}
				num = (short)1395458049;
				if (num != 0)
				{
				}
				num = (short)252116992;
				if (num != 0)
				{
				}
				num = (short)456130560;
				short num3 = num;
				return this.trkPeEMGFindMeRxEnable_42923.Valid;
			}
			set
			{
				short num = (short)718284472;
				short num2 = num;
				num = (short)382936760;
				switch (num2 == num)
				{
				}
				num = (short)1121648641;
				if (num != 0)
				{
				}
				num = (short)934412288;
				if (num != 0)
				{
				}
				num = (short)1167327232;
				short num3 = num;
				this.trkPeEMGFindMeRxEnable_42923.Valid = value;
			}
		}

		// Token: 0x17004C01 RID: 19457
		// (get) Token: 0x06009740 RID: 38720 RVA: 0x008E0284 File Offset: 0x008DE484
		// (set) Token: 0x06009741 RID: 38721 RVA: 0x008E0338 File Offset: 0x008DE538
		public bool TrkPeEMGFindMeRxEnable_42923_Visible
		{
			get
			{
				short num = (short)837480093;
				short num2 = num;
				num = (short)631434909;
				switch (num2 == num)
				{
				}
				num = (short)9895937;
				if (num != 0)
				{
				}
				num = (short)1221328896;
				if (num != 0)
				{
				}
				num = (short)1426063360;
				short num3 = num;
				return this.trkPeEMGFindMeRxEnable_42923.Visible;
			}
			set
			{
				short num = (short)1221062610;
				short num2 = num;
				num = (short)1402466258;
				switch (num2 == num)
				{
				}
				num = (short)1390149633;
				if (num != 0)
				{
				}
				num = (short)739770368;
				if (num != 0)
				{
				}
				num = (short)410124288;
				short num3 = num;
				this.trkPeEMGFindMeRxEnable_42923.Visible = value;
			}
		}

		// Token: 0x17004C02 RID: 19458
		// (get) Token: 0x06009742 RID: 38722 RVA: 0x008E03F0 File Offset: 0x008DE5F0
		// (set) Token: 0x06009743 RID: 38723 RVA: 0x008E04A8 File Offset: 0x008DE6A8
		public bool TrkPeEMGFindMeRxEnable_42923_Editable
		{
			get
			{
				short num = (short)1519689796;
				short num2 = num;
				num = (short)1291755588;
				switch (num2 == num)
				{
				}
				num = (short)1229783040;
				short num3 = num;
				num = (short)979173376;
				if (num != 0)
				{
				}
				num = (short)1926103041;
				if (num != 0)
				{
				}
				return this.trkPeEMGFindMeRxEnable_42923.Editable;
			}
			set
			{
				short num = (short)109326410;
				short num2 = num;
				num = (short)98709578;
				switch (num2 == num)
				{
				}
				num = (short)230096896;
				short num3 = num;
				num = (short)1436286977;
				if (num != 0)
				{
				}
				num = (short)192151552;
				if (num != 0)
				{
				}
				this.trkPeEMGFindMeRxEnable_42923.Editable = value;
			}
		}

		// Token: 0x17004C03 RID: 19459
		// (get) Token: 0x06009744 RID: 38724 RVA: 0x008E055C File Offset: 0x008DE75C
		internal string TrkPeEMGFindMeRxEnable_42923_UILabel
		{
			get
			{
				short num = (short)1274822678;
				short num2 = num;
				num = (short)518537238;
				switch (num2 == num)
				{
				}
				num = (short)223215616;
				short num3 = num;
				num = (short)1056178176;
				if (num != 0)
				{
				}
				num = (short)998637569;
				if (num != 0)
				{
				}
				return this.trkPeEMGFindMeRxEnable_42923.UIName;
			}
		}

		// Token: 0x17004C04 RID: 19460
		// (get) Token: 0x06009745 RID: 38725 RVA: 0x008E0610 File Offset: 0x008DE810
		// (set) Token: 0x06009746 RID: 38726 RVA: 0x008E06C4 File Offset: 0x008DE8C4
		internal bool TrkPeEMGFindMeRxEnable_42923_HiddenStatic
		{
			get
			{
				short num = (short)1582170113;
				if (num != 0)
				{
				}
				num = (short)1671779596;
				short num2 = num;
				num = (short)1687377164;
				switch (num2 == num)
				{
				default:
				{
					num = (short)659947520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1604517888;
				if (num != 0)
				{
				}
				return this.trkPeEMGFindMeRxEnable_42923.HiddenStatic;
			}
			set
			{
				short num = (short)861536257;
				if (num != 0)
				{
				}
				num = (short)9780754;
				short num2 = num;
				num = (short)1737768466;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2046361600;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1297678336;
				if (num != 0)
				{
				}
				this.trkPeEMGFindMeRxEnable_42923.HiddenStatic = value;
			}
		}

		// Token: 0x17004C05 RID: 19461
		// (get) Token: 0x06009747 RID: 38727 RVA: 0x008E077C File Offset: 0x008DE97C
		// (set) Token: 0x06009748 RID: 38728 RVA: 0x008E0834 File Offset: 0x008DEA34
		internal bool TrkPeEMGFindMeRxEnable_42923_HiddenDynamic
		{
			get
			{
				short num = (short)1321249336;
				short num2 = num;
				num = (short)345025080;
				switch (num2 == num)
				{
				}
				num = (short)981270528;
				short num3 = num;
				num = (short)917045248;
				if (num != 0)
				{
				}
				num = (short)1673592833;
				if (num != 0)
				{
				}
				return this.trkPeEMGFindMeRxEnable_42923.HiddenDynamic;
			}
			set
			{
				short num = (short)869960023;
				short num2 = num;
				num = (short)1108445527;
				switch (num2 == num)
				{
				}
				num = (short)334102528;
				short num3 = num;
				num = (short)1646067712;
				if (num != 0)
				{
				}
				num = (short)1915158529;
				if (num != 0)
				{
				}
				this.trkPeEMGFindMeRxEnable_42923.HiddenDynamic = value;
			}
		}

		// Token: 0x17004C06 RID: 19462
		// (get) Token: 0x06009749 RID: 38729 RVA: 0x008E08EC File Offset: 0x008DEAEC
		public bool TrkPeEMGFindMeRxEnable_42923_HasDiffs
		{
			get
			{
				short num = (short)1478635;
				short num2 = num;
				num = (short)727027691;
				switch (num2 == num)
				{
				}
				num = (short)994705408;
				short num3 = num;
				num = (short)1891237889;
				if (num != 0)
				{
				}
				num = (short)262602752;
				if (num != 0)
				{
				}
				return this.trkPeEMGFindMeRxEnable_42923._HasDiffs;
			}
		}

		// Token: 0x17004C07 RID: 19463
		// (get) Token: 0x0600974A RID: 38730 RVA: 0x008E09A0 File Offset: 0x008DEBA0
		// (set) Token: 0x0600974B RID: 38731 RVA: 0x008E0A54 File Offset: 0x008DEC54
		public bool TrkEmerProfImpactDetectionEn_A43392Value
		{
			get
			{
				short num = (short)1026611452;
				short num2 = num;
				num = (short)1929566460;
				switch (num2 == num)
				{
				}
				num = (short)748945408;
				short num3 = num;
				num = (short)1719992321;
				if (num != 0)
				{
				}
				num = (short)1999241216;
				if (num != 0)
				{
				}
				return this.trkEmerProfImpactDetectionEn_A43392.Value;
			}
			set
			{
				short num = (short)1627589519;
				short num2 = num;
				num = (short)1070992271;
				switch (num2 == num)
				{
				}
				num = (short)40239104;
				short num3 = num;
				num = (short)1100939265;
				if (num != 0)
				{
				}
				num = (short)734003200;
				if (num != 0)
				{
				}
				this.trkEmerProfImpactDetectionEn_A43392.Value = value;
			}
		}

		// Token: 0x17004C08 RID: 19464
		// (get) Token: 0x0600974C RID: 38732 RVA: 0x008E0B0C File Offset: 0x008DED0C
		public global::AcpBusinessLayer.AcpField<bool> TrkEmerProfImpactDetectionEn_A43392
		{
			get
			{
				short num = (short)1032439821;
				short num2 = num;
				num = (short)592103437;
				switch (num2 == num)
				{
				}
				num = (short)789315584;
				short num3 = num;
				num = (short)236453889;
				if (num != 0)
				{
				}
				num = (short)2081685504;
				if (num != 0)
				{
				}
				return this.trkEmerProfImpactDetectionEn_A43392;
			}
		}

		// Token: 0x17004C09 RID: 19465
		// (get) Token: 0x0600974D RID: 38733 RVA: 0x008E0BBC File Offset: 0x008DEDBC
		// (set) Token: 0x0600974E RID: 38734 RVA: 0x008E0C74 File Offset: 0x008DEE74
		public bool TrkEmerProfImpactDetectionEn_A43392_UIValue
		{
			get
			{
				short num = (short)105810449;
				short num2 = num;
				num = (short)355633681;
				switch (num2 == num)
				{
				}
				num = (short)2073690112;
				short num3 = num;
				num = (short)1025769472;
				if (num != 0)
				{
				}
				num = (short)1714225153;
				if (num != 0)
				{
				}
				return this.trkEmerProfImpactDetectionEn_A43392.Value;
			}
			set
			{
				short num = (short)952028765;
				short num2 = num;
				num = (short)441503325;
				switch (num2 == num)
				{
				}
				num = (short)27983872;
				short num3 = num;
				num = (short)1879638017;
				if (num != 0)
				{
				}
				num = (short)437387264;
				if (num != 0)
				{
				}
				this.trkEmerProfImpactDetectionEn_A43392.Value = value;
			}
		}

		// Token: 0x17004C0A RID: 19466
		// (get) Token: 0x0600974F RID: 38735 RVA: 0x008E0D2C File Offset: 0x008DEF2C
		// (set) Token: 0x06009750 RID: 38736 RVA: 0x008E0DE0 File Offset: 0x008DEFE0
		public bool TrkEmerProfImpactDetectionEn_A43392_Applicable
		{
			get
			{
				short num = (short)1024258827;
				short num2 = num;
				num = (short)621212427;
				switch (num2 == num)
				{
				}
				num = (short)1358364672;
				short num3 = num;
				num = (short)1309540353;
				if (num != 0)
				{
				}
				num = (short)256049152;
				if (num != 0)
				{
				}
				return this.trkEmerProfImpactDetectionEn_A43392.Applicable;
			}
			set
			{
				short num = (short)1484343781;
				short num2 = num;
				num = (short)131811813;
				switch (num2 == num)
				{
				}
				num = (short)1755512832;
				short num3 = num;
				num = (short)208535553;
				if (num != 0)
				{
				}
				num = (short)677511168;
				if (num != 0)
				{
				}
				this.trkEmerProfImpactDetectionEn_A43392.Applicable = value;
			}
		}

		// Token: 0x17004C0B RID: 19467
		// (get) Token: 0x06009751 RID: 38737 RVA: 0x008E0E9C File Offset: 0x008DF09C
		// (set) Token: 0x06009752 RID: 38738 RVA: 0x008E0F50 File Offset: 0x008DF150
		public bool TrkEmerProfImpactDetectionEn_A43392_Valid
		{
			get
			{
				short num = (short)501330939;
				short num2 = num;
				num = (short)513520635;
				switch (num2 == num)
				{
				}
				num = (short)509542400;
				short num3 = num;
				num = (short)318570497;
				if (num != 0)
				{
				}
				num = (short)1489567744;
				if (num != 0)
				{
				}
				return this.trkEmerProfImpactDetectionEn_A43392.Valid;
			}
			set
			{
				short num = (short)1591279617;
				if (num != 0)
				{
				}
				num = (short)33562593;
				short num2 = num;
				num = (short)2046042081;
				switch (num2 == num)
				{
				default:
				{
					num = (short)369295360;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1299906560;
				if (num != 0)
				{
				}
				this.trkEmerProfImpactDetectionEn_A43392.Valid = value;
			}
		}

		// Token: 0x17004C0C RID: 19468
		// (get) Token: 0x06009753 RID: 38739 RVA: 0x008E100C File Offset: 0x008DF20C
		// (set) Token: 0x06009754 RID: 38740 RVA: 0x008E10C0 File Offset: 0x008DF2C0
		public bool TrkEmerProfImpactDetectionEn_A43392_Visible
		{
			get
			{
				short num = (short)980250670;
				short num2 = num;
				num = (short)156397614;
				switch (num2 == num)
				{
				}
				num = (short)604438528;
				short num3 = num;
				num = (short)966197248;
				if (num != 0)
				{
				}
				num = (short)701956097;
				if (num != 0)
				{
				}
				return this.trkEmerProfImpactDetectionEn_A43392.Visible;
			}
			set
			{
				short num = (short)380221592;
				short num2 = num;
				num = (short)728545432;
				switch (num2 == num)
				{
				}
				num = (short)959447040;
				short num3 = num;
				num = (short)454557697;
				if (num != 0)
				{
				}
				num = (short)1755906048;
				if (num != 0)
				{
				}
				this.trkEmerProfImpactDetectionEn_A43392.Visible = value;
			}
		}

		// Token: 0x17004C0D RID: 19469
		// (get) Token: 0x06009755 RID: 38741 RVA: 0x008E1178 File Offset: 0x008DF378
		// (set) Token: 0x06009756 RID: 38742 RVA: 0x008E122C File Offset: 0x008DF42C
		public bool TrkEmerProfImpactDetectionEn_A43392_Editable
		{
			get
			{
				short num = (short)1225017383;
				short num2 = num;
				num = (short)321669159;
				switch (num2 == num)
				{
				}
				num = (short)960954368;
				short num3 = num;
				num = (short)1443758081;
				if (num != 0)
				{
				}
				num = (short)1716977664;
				if (num != 0)
				{
				}
				return this.trkEmerProfImpactDetectionEn_A43392.Editable;
			}
			set
			{
				short num = (short)789354727;
				short num2 = num;
				num = (short)815372519;
				switch (num2 == num)
				{
				}
				num = (short)194576384;
				short num3 = num;
				num = (short)173801473;
				if (num != 0)
				{
				}
				num = (short)715522048;
				if (num != 0)
				{
				}
				this.trkEmerProfImpactDetectionEn_A43392.Editable = value;
			}
		}

		// Token: 0x17004C0E RID: 19470
		// (get) Token: 0x06009757 RID: 38743 RVA: 0x008E12E4 File Offset: 0x008DF4E4
		internal string TrkEmerProfImpactDetectionEn_A43392_UILabel
		{
			get
			{
				short num = (short)705931246;
				short num2 = num;
				num = (short)710256622;
				switch (num2 == num)
				{
				}
				num = (short)159449088;
				short num3 = num;
				num = (short)209846273;
				if (num != 0)
				{
				}
				num = (short)2042560512;
				if (num != 0)
				{
				}
				return this.trkEmerProfImpactDetectionEn_A43392.UIName;
			}
		}

		// Token: 0x17004C0F RID: 19471
		// (get) Token: 0x06009758 RID: 38744 RVA: 0x008E139C File Offset: 0x008DF59C
		// (set) Token: 0x06009759 RID: 38745 RVA: 0x008E1454 File Offset: 0x008DF654
		internal bool TrkEmerProfImpactDetectionEn_A43392_HiddenStatic
		{
			get
			{
				short num = (short)1664814011;
				short num2 = num;
				num = (short)67767227;
				switch (num2 == num)
				{
				}
				num = (short)1312227328;
				short num3 = num;
				num = (short)1316028417;
				if (num != 0)
				{
				}
				num = (short)802947072;
				if (num != 0)
				{
				}
				return this.trkEmerProfImpactDetectionEn_A43392.HiddenStatic;
			}
			set
			{
				short num = (short)1195474835;
				short num2 = num;
				num = (short)40206227;
				switch (num2 == num)
				{
				}
				num = (short)1893466112;
				short num3 = num;
				num = (short)1154154497;
				if (num != 0)
				{
				}
				num = (short)1633681408;
				if (num != 0)
				{
				}
				this.trkEmerProfImpactDetectionEn_A43392.HiddenStatic = value;
			}
		}

		// Token: 0x17004C10 RID: 19472
		// (get) Token: 0x0600975A RID: 38746 RVA: 0x008E150C File Offset: 0x008DF70C
		// (set) Token: 0x0600975B RID: 38747 RVA: 0x008E15C0 File Offset: 0x008DF7C0
		internal bool TrkEmerProfImpactDetectionEn_A43392_HiddenDynamic
		{
			get
			{
				short num = (short)1354462530;
				short num2 = num;
				num = (short)1410954562;
				switch (num2 == num)
				{
				}
				num = (short)710213632;
				short num3 = num;
				num = (short)243138561;
				if (num != 0)
				{
				}
				num = (short)1327169536;
				if (num != 0)
				{
				}
				return this.trkEmerProfImpactDetectionEn_A43392.HiddenDynamic;
			}
			set
			{
				short num = (short)1527201014;
				short num2 = num;
				num = (short)787234038;
				switch (num2 == num)
				{
				}
				num = (short)474611712;
				short num3 = num;
				num = (short)2038497280;
				if (num != 0)
				{
				}
				num = (short)482541569;
				if (num != 0)
				{
				}
				this.trkEmerProfImpactDetectionEn_A43392.HiddenDynamic = value;
			}
		}

		// Token: 0x17004C11 RID: 19473
		// (get) Token: 0x0600975C RID: 38748 RVA: 0x008E1674 File Offset: 0x008DF874
		public bool TrkEmerProfImpactDetectionEn_A43392_HasDiffs
		{
			get
			{
				short num = (short)1703173466;
				short num2 = num;
				num = (short)368336218;
				switch (num2 == num)
				{
				}
				num = (short)1622081536;
				short num3 = num;
				num = (short)1190526976;
				if (num != 0)
				{
				}
				num = (short)257490945;
				if (num != 0)
				{
				}
				return this.trkEmerProfImpactDetectionEn_A43392._HasDiffs;
			}
		}

		// Token: 0x17004C12 RID: 19474
		// (get) Token: 0x0600975D RID: 38749 RVA: 0x008E1728 File Offset: 0x008DF928
		// (set) Token: 0x0600975E RID: 38750 RVA: 0x008E17E0 File Offset: 0x008DF9E0
		public bool EmergencyExitOnChannelChange_43588Value
		{
			get
			{
				short num = (short)707515589;
				short num2 = num;
				num = (short)795137221;
				switch (num2 == num)
				{
				}
				num = (short)1760296960;
				short num3 = num;
				num = (short)1277034496;
				if (num != 0)
				{
				}
				num = (short)1631977473;
				if (num != 0)
				{
				}
				return this.emergencyExitOnChannelChange_43588.Value;
			}
			set
			{
				short num = (short)636545230;
				short num2 = num;
				num = (short)1373497550;
				switch (num2 == num)
				{
				}
				num = (short)1498152960;
				short num3 = num;
				num = (short)1955463168;
				if (num != 0)
				{
				}
				num = (short)1848901633;
				if (num != 0)
				{
				}
				this.emergencyExitOnChannelChange_43588.Value = value;
			}
		}

		// Token: 0x17004C13 RID: 19475
		// (get) Token: 0x0600975F RID: 38751 RVA: 0x008E1898 File Offset: 0x008DFA98
		public global::AcpBusinessLayer.AcpField<bool> EmergencyExitOnChannelChange_43588
		{
			get
			{
				short num = (short)1587587499;
				short num2 = num;
				num = (short)1218881963;
				switch (num2 == num)
				{
				}
				num = (short)1057619968;
				short num3 = num;
				num = (short)1861812224;
				if (num != 0)
				{
				}
				num = (short)515768321;
				if (num != 0)
				{
				}
				return this.emergencyExitOnChannelChange_43588;
			}
		}

		// Token: 0x17004C14 RID: 19476
		// (get) Token: 0x06009760 RID: 38752 RVA: 0x008E1948 File Offset: 0x008DFB48
		// (set) Token: 0x06009761 RID: 38753 RVA: 0x008E19FC File Offset: 0x008DFBFC
		public bool EmergencyExitOnChannelChange_43588_UIValue
		{
			get
			{
				short num = (short)380076442;
				short num2 = num;
				num = (short)1755546010;
				switch (num2 == num)
				{
				}
				num = (short)1927741440;
				short num3 = num;
				num = (short)21102593;
				if (num != 0)
				{
				}
				num = (short)1205141504;
				if (num != 0)
				{
				}
				return this.emergencyExitOnChannelChange_43588.Value;
			}
			set
			{
				short num = (short)1246257161;
				short num2 = num;
				num = (short)173891593;
				switch (num2 == num)
				{
				}
				num = (short)572850176;
				short num3 = num;
				num = (short)1155661825;
				if (num != 0)
				{
				}
				num = (short)272236544;
				if (num != 0)
				{
				}
				this.emergencyExitOnChannelChange_43588.Value = value;
			}
		}

		// Token: 0x17004C15 RID: 19477
		// (get) Token: 0x06009762 RID: 38754 RVA: 0x008E1AB4 File Offset: 0x008DFCB4
		// (set) Token: 0x06009763 RID: 38755 RVA: 0x008E1B68 File Offset: 0x008DFD68
		public bool EmergencyExitOnChannelChange_43588_Applicable
		{
			get
			{
				short num = (short)1992494200;
				short num2 = num;
				num = (short)1155271800;
				switch (num2 == num)
				{
				}
				num = (short)2059665408;
				short num3 = num;
				num = (short)1840513024;
				if (num != 0)
				{
				}
				num = (short)1743257601;
				if (num != 0)
				{
				}
				return this.emergencyExitOnChannelChange_43588.Applicable;
			}
			set
			{
				short num = (short)1931673601;
				if (num != 0)
				{
				}
				num = (short)1363913306;
				short num2 = num;
				num = (short)1623698010;
				switch (num2 == num)
				{
				default:
				{
					num = (short)77070336;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1289814016;
				if (num != 0)
				{
				}
				this.emergencyExitOnChannelChange_43588.Applicable = value;
			}
		}

		// Token: 0x17004C16 RID: 19478
		// (get) Token: 0x06009764 RID: 38756 RVA: 0x008E1C24 File Offset: 0x008DFE24
		// (set) Token: 0x06009765 RID: 38757 RVA: 0x008E1CD8 File Offset: 0x008DFED8
		public bool EmergencyExitOnChannelChange_43588_Valid
		{
			get
			{
				short num = (short)2119445288;
				short num2 = num;
				num = (short)172436264;
				switch (num2 == num)
				{
				}
				num = (short)237764608;
				short num3 = num;
				num = (short)306511872;
				if (num != 0)
				{
				}
				num = (short)1831141377;
				if (num != 0)
				{
				}
				return this.emergencyExitOnChannelChange_43588.Valid;
			}
			set
			{
				short num = (short)1247693729;
				short num2 = num;
				num = (short)540887969;
				switch (num2 == num)
				{
				}
				num = (short)1521876992;
				short num3 = num;
				num = (short)750518273;
				if (num != 0)
				{
				}
				num = (short)855179264;
				if (num != 0)
				{
				}
				this.emergencyExitOnChannelChange_43588.Valid = value;
			}
		}

		// Token: 0x17004C17 RID: 19479
		// (get) Token: 0x06009766 RID: 38758 RVA: 0x008E1D90 File Offset: 0x008DFF90
		// (set) Token: 0x06009767 RID: 38759 RVA: 0x008E1E44 File Offset: 0x008E0044
		public bool EmergencyExitOnChannelChange_43588_Visible
		{
			get
			{
				short num = (short)1396690070;
				short num2 = num;
				num = (short)1175112854;
				switch (num2 == num)
				{
				}
				num = (short)1753219072;
				short num3 = num;
				num = (short)151846912;
				if (num != 0)
				{
				}
				num = (short)1478754305;
				if (num != 0)
				{
				}
				return this.emergencyExitOnChannelChange_43588.Visible;
			}
			set
			{
				short num = (short)252718321;
				short num2 = num;
				num = (short)1292971249;
				switch (num2 == num)
				{
				}
				num = (short)833028096;
				short num3 = num;
				num = (short)1214971905;
				if (num != 0)
				{
				}
				num = (short)1069219840;
				if (num != 0)
				{
				}
				this.emergencyExitOnChannelChange_43588.Visible = value;
			}
		}

		// Token: 0x17004C18 RID: 19480
		// (get) Token: 0x06009768 RID: 38760 RVA: 0x008E1EF8 File Offset: 0x008E00F8
		// (set) Token: 0x06009769 RID: 38761 RVA: 0x008E1FAC File Offset: 0x008E01AC
		public bool EmergencyExitOnChannelChange_43588_Editable
		{
			get
			{
				short num = (short)323289089;
				if (num != 0)
				{
				}
				num = (short)1084554494;
				short num2 = num;
				num = (short)1971125502;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1720057856;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1080557568;
				if (num != 0)
				{
				}
				return this.emergencyExitOnChannelChange_43588.Editable;
			}
			set
			{
				short num = (short)1223340148;
				short num2 = num;
				num = (short)1662103668;
				switch (num2 == num)
				{
				}
				num = (short)1870397440;
				short num3 = num;
				num = (short)2141061120;
				if (num != 0)
				{
				}
				num = (short)372899841;
				if (num != 0)
				{
				}
				this.emergencyExitOnChannelChange_43588.Editable = value;
			}
		}

		// Token: 0x17004C19 RID: 19481
		// (get) Token: 0x0600976A RID: 38762 RVA: 0x008E2064 File Offset: 0x008E0264
		internal string EmergencyExitOnChannelChange_43588_UILabel
		{
			get
			{
				short num = (short)563565686;
				short num2 = num;
				num = (short)1720013942;
				switch (num2 == num)
				{
				}
				num = (short)622264320;
				short num3 = num;
				num = (short)593035265;
				if (num != 0)
				{
				}
				num = (short)495321088;
				if (num != 0)
				{
				}
				return this.emergencyExitOnChannelChange_43588.UIName;
			}
		}

		// Token: 0x17004C1A RID: 19482
		// (get) Token: 0x0600976B RID: 38763 RVA: 0x008E211C File Offset: 0x008E031C
		// (set) Token: 0x0600976C RID: 38764 RVA: 0x008E21D0 File Offset: 0x008E03D0
		internal bool EmergencyExitOnChannelChange_43588_HiddenStatic
		{
			get
			{
				short num = (short)397173951;
				short num2 = num;
				num = (short)438920383;
				switch (num2 == num)
				{
				}
				num = (short)1590624256;
				short num3 = num;
				num = (short)733216769;
				if (num != 0)
				{
				}
				num = (short)1339949056;
				if (num != 0)
				{
				}
				return this.emergencyExitOnChannelChange_43588.HiddenStatic;
			}
			set
			{
				short num = (short)1815963681;
				short num2 = num;
				num = (short)1841260577;
				switch (num2 == num)
				{
				}
				num = (short)635109376;
				short num3 = num;
				num = (short)1935015937;
				if (num != 0)
				{
				}
				num = (short)1332346880;
				if (num != 0)
				{
				}
				this.emergencyExitOnChannelChange_43588.HiddenStatic = value;
			}
		}

		// Token: 0x17004C1B RID: 19483
		// (get) Token: 0x0600976D RID: 38765 RVA: 0x008E2284 File Offset: 0x008E0484
		// (set) Token: 0x0600976E RID: 38766 RVA: 0x008E2338 File Offset: 0x008E0538
		internal bool EmergencyExitOnChannelChange_43588_HiddenDynamic
		{
			get
			{
				short num = (short)185255225;
				short num2 = num;
				num = (short)574473529;
				switch (num2 == num)
				{
				}
				num = (short)453705728;
				short num3 = num;
				num = (short)197001217;
				if (num != 0)
				{
				}
				num = (short)229310464;
				if (num != 0)
				{
				}
				return this.emergencyExitOnChannelChange_43588.HiddenDynamic;
			}
			set
			{
				short num = (short)1080328547;
				short num2 = num;
				num = (short)797606243;
				switch (num2 == num)
				{
				}
				num = (short)624230400;
				short num3 = num;
				num = (short)521338881;
				if (num != 0)
				{
				}
				num = (short)1933246464;
				if (num != 0)
				{
				}
				this.emergencyExitOnChannelChange_43588.HiddenDynamic = value;
			}
		}

		// Token: 0x17004C1C RID: 19484
		// (get) Token: 0x0600976F RID: 38767 RVA: 0x008E23EC File Offset: 0x008E05EC
		public bool EmergencyExitOnChannelChange_43588_HasDiffs
		{
			get
			{
				short num = (short)1357560145;
				short num2 = num;
				num = (short)1951447377;
				switch (num2 == num)
				{
				}
				num = (short)1542127616;
				short num3 = num;
				num = (short)1733820417;
				if (num != 0)
				{
				}
				num = (short)1454309376;
				if (num != 0)
				{
				}
				return this.emergencyExitOnChannelChange_43588._HasDiffs;
			}
		}

		// Token: 0x17004C1D RID: 19485
		// (get) Token: 0x06009770 RID: 38768 RVA: 0x008E24A0 File Offset: 0x008E06A0
		// (set) Token: 0x06009771 RID: 38769 RVA: 0x008E2554 File Offset: 0x008E0754
		public int TrkEmerProfGeneralTxPeriodsec2_A43601Value
		{
			get
			{
				short num = (short)836010426;
				short num2 = num;
				num = (short)444367290;
				switch (num2 == num)
				{
				}
				num = (short)121110528;
				short num3 = num;
				num = (short)2037383169;
				if (num != 0)
				{
				}
				num = (short)889389056;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralTxPeriodsec2_A43601.Value;
			}
			set
			{
				short num = (short)104520715;
				short num2 = num;
				num = (short)1790893067;
				switch (num2 == num)
				{
				}
				num = (short)877133824;
				short num3 = num;
				num = (short)2021982209;
				if (num != 0)
				{
				}
				num = (short)910950400;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralTxPeriodsec2_A43601.Value = value;
			}
		}

		// Token: 0x17004C1E RID: 19486
		// (get) Token: 0x06009772 RID: 38770 RVA: 0x008E260C File Offset: 0x008E080C
		public global::AcpBusinessLayer.AcpSimpleRangeField TrkEmerProfGeneralTxPeriodsec2_A43601
		{
			get
			{
				short num = (short)1040701378;
				short num2 = num;
				num = (short)399497154;
				switch (num2 == num)
				{
				}
				num = (short)954007552;
				short num3 = num;
				num = (short)184680449;
				if (num != 0)
				{
				}
				num = (short)1182138368;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralTxPeriodsec2_A43601;
			}
		}

		// Token: 0x17004C1F RID: 19487
		// (get) Token: 0x06009773 RID: 38771 RVA: 0x008E26BC File Offset: 0x008E08BC
		// (set) Token: 0x06009774 RID: 38772 RVA: 0x008E276C File Offset: 0x008E096C
		public string TrkEmerProfGeneralTxPeriodsec2_A43601_UIValue
		{
			get
			{
				short num = (short)948072243;
				short num2 = num;
				num = (short)1497526067;
				switch (num2 == num)
				{
				}
				num = (short)894763008;
				short num3 = num;
				num = (short)1966276609;
				if (num != 0)
				{
				}
				num = (short)1558249472;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralTxPeriodsec2_A43601.UIValue;
			}
			set
			{
				short num = (short)438435987;
				short num2 = num;
				num = (short)29163667;
				switch (num2 == num)
				{
				}
				num = (short)116785152;
				short num3 = num;
				num = (short)1826750465;
				if (num != 0)
				{
				}
				num = (short)591724544;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralTxPeriodsec2_A43601.UIValue = value;
			}
		}

		// Token: 0x17004C20 RID: 19488
		// (get) Token: 0x06009775 RID: 38773 RVA: 0x008E2820 File Offset: 0x008E0A20
		// (set) Token: 0x06009776 RID: 38774 RVA: 0x008E28D4 File Offset: 0x008E0AD4
		internal int TrkEmerProfGeneralTxPeriodsec2_A43601Min
		{
			get
			{
				short num = (short)1303527753;
				short num2 = num;
				num = (short)1308115273;
				switch (num2 == num)
				{
				}
				num = (short)673316864;
				short num3 = num;
				num = (short)437387264;
				if (num != 0)
				{
				}
				num = (short)1968766977;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralTxPeriodsec2_A43601.Min;
			}
			set
			{
				short num = (short)1180565505;
				if (num != 0)
				{
				}
				num = (short)949317151;
				short num2 = num;
				num = (short)1069772319;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1397096448;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1714946048;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralTxPeriodsec2_A43601.Min = value;
			}
		}

		// Token: 0x17004C21 RID: 19489
		// (get) Token: 0x06009777 RID: 38775 RVA: 0x008E298C File Offset: 0x008E0B8C
		// (set) Token: 0x06009778 RID: 38776 RVA: 0x008E2A40 File Offset: 0x008E0C40
		internal int TrkEmerProfGeneralTxPeriodsec2_A43601Max
		{
			get
			{
				short num = (short)1412277877;
				short num2 = num;
				num = (short)17213045;
				switch (num2 == num)
				{
				}
				num = (short)1790181376;
				short num3 = num;
				num = (short)184483840;
				if (num != 0)
				{
				}
				num = (short)1867382785;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralTxPeriodsec2_A43601.Max;
			}
			set
			{
				short num = (short)1381302273;
				if (num != 0)
				{
				}
				num = (short)28202731;
				short num2 = num;
				num = (short)686642923;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1095827456;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1869938688;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralTxPeriodsec2_A43601.Max = value;
			}
		}

		// Token: 0x17004C22 RID: 19490
		// (get) Token: 0x06009779 RID: 38777 RVA: 0x008E2AF4 File Offset: 0x008E0CF4
		// (set) Token: 0x0600977A RID: 38778 RVA: 0x008E2BA4 File Offset: 0x008E0DA4
		internal int TrkEmerProfGeneralTxPeriodsec2_A43601Step
		{
			get
			{
				short num = (short)1967323222;
				short num2 = num;
				num = (short)1127872598;
				switch (num2 == num)
				{
				}
				num = (short)2097938432;
				short num3 = num;
				num = (short)296091649;
				if (num != 0)
				{
				}
				num = (short)725155840;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralTxPeriodsec2_A43601.StepSize;
			}
			set
			{
				short num = (short)88286351;
				short num2 = num;
				num = (short)1299522703;
				switch (num2 == num)
				{
				}
				num = (short)1055326208;
				short num3 = num;
				num = (short)858652672;
				if (num != 0)
				{
				}
				num = (short)602734593;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralTxPeriodsec2_A43601.StepSize = value;
			}
		}

		// Token: 0x17004C23 RID: 19491
		// (get) Token: 0x0600977B RID: 38779 RVA: 0x008E2C5C File Offset: 0x008E0E5C
		// (set) Token: 0x0600977C RID: 38780 RVA: 0x008E2D10 File Offset: 0x008E0F10
		public bool TrkEmerProfGeneralTxPeriodsec2_A43601_Applicable
		{
			get
			{
				short num = (short)819249283;
				short num2 = num;
				num = (short)239321219;
				switch (num2 == num)
				{
				}
				num = (short)935591936;
				short num3 = num;
				num = (short)690749441;
				if (num != 0)
				{
				}
				num = (short)845611008;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralTxPeriodsec2_A43601.Applicable;
			}
			set
			{
				short num = (short)878174153;
				short num2 = num;
				num = (short)720232393;
				switch (num2 == num)
				{
				}
				num = (short)1680211968;
				short num3 = num;
				num = (short)1938751488;
				if (num != 0)
				{
				}
				num = (short)391053313;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralTxPeriodsec2_A43601.Applicable = value;
			}
		}

		// Token: 0x17004C24 RID: 19492
		// (get) Token: 0x0600977D RID: 38781 RVA: 0x008E2DC8 File Offset: 0x008E0FC8
		// (set) Token: 0x0600977E RID: 38782 RVA: 0x008E2E80 File Offset: 0x008E1080
		public bool TrkEmerProfGeneralTxPeriodsec2_A43601_Valid
		{
			get
			{
				short num = (short)2095579419;
				short num2 = num;
				num = (short)1936982299;
				switch (num2 == num)
				{
				}
				num = (short)566362112;
				short num3 = num;
				num = (short)433586177;
				if (num != 0)
				{
				}
				num = (short)2098921472;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralTxPeriodsec2_A43601.Valid;
			}
			set
			{
				short num = (short)1815478273;
				if (num != 0)
				{
				}
				num = (short)1413172445;
				short num2 = num;
				num = (short)1351371997;
				switch (num2 == num)
				{
				default:
				{
					num = (short)918749184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)391380992;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralTxPeriodsec2_A43601.Valid = value;
			}
		}

		// Token: 0x17004C25 RID: 19493
		// (get) Token: 0x0600977F RID: 38783 RVA: 0x008E2F38 File Offset: 0x008E1138
		// (set) Token: 0x06009780 RID: 38784 RVA: 0x008E2FEC File Offset: 0x008E11EC
		public bool TrkEmerProfGeneralTxPeriodsec2_A43601_Visible
		{
			get
			{
				short num = (short)198030482;
				short num2 = num;
				num = (short)1793635474;
				switch (num2 == num)
				{
				}
				num = (short)1700855808;
				short num3 = num;
				num = (short)1574436864;
				if (num != 0)
				{
				}
				num = (short)392167425;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralTxPeriodsec2_A43601.Visible;
			}
			set
			{
				short num = (short)2118952733;
				short num2 = num;
				num = (short)829138717;
				switch (num2 == num)
				{
				}
				num = (short)1142685696;
				short num3 = num;
				num = (short)1280049153;
				if (num != 0)
				{
				}
				num = (short)865927168;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralTxPeriodsec2_A43601.Visible = value;
			}
		}

		// Token: 0x17004C26 RID: 19494
		// (get) Token: 0x06009781 RID: 38785 RVA: 0x008E30A4 File Offset: 0x008E12A4
		// (set) Token: 0x06009782 RID: 38786 RVA: 0x008E3158 File Offset: 0x008E1358
		public bool TrkEmerProfGeneralTxPeriodsec2_A43601_Editable
		{
			get
			{
				short num = (short)219819857;
				short num2 = num;
				num = (short)1576546129;
				switch (num2 == num)
				{
				}
				num = (short)1724317696;
				short num3 = num;
				num = (short)1669398529;
				if (num != 0)
				{
				}
				num = (short)1008992256;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralTxPeriodsec2_A43601.Editable;
			}
			set
			{
				short num = (short)952821;
				short num2 = num;
				num = (short)61114869;
				switch (num2 == num)
				{
				}
				num = (short)96993280;
				short num3 = num;
				num = (short)434241537;
				if (num != 0)
				{
				}
				num = (short)117637120;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralTxPeriodsec2_A43601.Editable = value;
			}
		}

		// Token: 0x17004C27 RID: 19495
		// (get) Token: 0x06009783 RID: 38787 RVA: 0x008E3210 File Offset: 0x008E1410
		internal string TrkEmerProfGeneralTxPeriodsec2_A43601_UILabel
		{
			get
			{
				short num = (short)1097662465;
				if (num != 0)
				{
				}
				num = (short)1053845508;
				short num2 = num;
				num = (short)1185376260;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2555904;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)49872896;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralTxPeriodsec2_A43601.UIName;
			}
		}

		// Token: 0x17004C28 RID: 19496
		// (get) Token: 0x06009784 RID: 38788 RVA: 0x008E32C8 File Offset: 0x008E14C8
		// (set) Token: 0x06009785 RID: 38789 RVA: 0x008E337C File Offset: 0x008E157C
		internal bool TrkEmerProfGeneralTxPeriodsec2_A43601_HiddenStatic
		{
			get
			{
				short num = (short)290880920;
				short num2 = num;
				num = (short)1574927768;
				switch (num2 == num)
				{
				}
				num = (short)803930112;
				short num3 = num;
				num = (short)567803904;
				if (num != 0)
				{
				}
				num = (short)329056257;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralTxPeriodsec2_A43601.HiddenStatic;
			}
			set
			{
				short num = (short)1522204673;
				if (num != 0)
				{
				}
				num = (short)994714626;
				short num2 = num;
				num = (short)1541874690;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1357905920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)325582848;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralTxPeriodsec2_A43601.HiddenStatic = value;
			}
		}

		// Token: 0x17004C29 RID: 19497
		// (get) Token: 0x06009786 RID: 38790 RVA: 0x008E3434 File Offset: 0x008E1634
		// (set) Token: 0x06009787 RID: 38791 RVA: 0x008E34E8 File Offset: 0x008E16E8
		internal bool TrkEmerProfGeneralTxPeriodsec2_A43601_HiddenDynamic
		{
			get
			{
				short num = (short)1798424547;
				short num2 = num;
				num = (short)1238747107;
				switch (num2 == num)
				{
				}
				num = (short)1144324096;
				short num3 = num;
				num = (short)287244288;
				if (num != 0)
				{
				}
				num = (short)98172929;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralTxPeriodsec2_A43601.HiddenDynamic;
			}
			set
			{
				short num = (short)111476291;
				short num2 = num;
				num = (short)360250947;
				switch (num2 == num)
				{
				}
				num = (short)1571553280;
				short num3 = num;
				num = (short)1321074688;
				if (num != 0)
				{
				}
				num = (short)779681793;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralTxPeriodsec2_A43601.HiddenDynamic = value;
			}
		}

		// Token: 0x17004C2A RID: 19498
		// (get) Token: 0x06009788 RID: 38792 RVA: 0x008E359C File Offset: 0x008E179C
		public bool TrkEmerProfGeneralTxPeriodsec2_A43601_HasDiffs
		{
			get
			{
				short num = (short)1191438181;
				short num2 = num;
				num = (short)1542973285;
				switch (num2 == num)
				{
				}
				num = (short)1096024064;
				short num3 = num;
				num = (short)304087040;
				if (num != 0)
				{
				}
				num = (short)168361985;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralTxPeriodsec2_A43601._HasDiffs;
			}
		}

		// Token: 0x17004C2B RID: 19499
		// (get) Token: 0x06009789 RID: 38793 RVA: 0x008E364C File Offset: 0x008E184C
		// (set) Token: 0x0600978A RID: 38794 RVA: 0x008E3700 File Offset: 0x008E1900
		public int TrkEmerProfGeneralRemoteActivationEmergencyValue
		{
			get
			{
				short num = (short)1530327792;
				short num2 = num;
				num = (short)1254224624;
				switch (num2 == num)
				{
				}
				num = (short)603193344;
				short num3 = num;
				num = (short)2127953921;
				if (num != 0)
				{
				}
				num = (short)1624178688;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralRemoteActivationEmergency.Value;
			}
			set
			{
				short num = (short)1043297071;
				short num2 = num;
				num = (short)1477538607;
				switch (num2 == num)
				{
				}
				num = (short)444465152;
				short num3 = num;
				num = (short)1310392321;
				if (num != 0)
				{
				}
				num = (short)182452224;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralRemoteActivationEmergency.Value = value;
			}
		}

		// Token: 0x17004C2C RID: 19500
		// (get) Token: 0x0600978B RID: 38795 RVA: 0x008E37B4 File Offset: 0x008E19B4
		// (set) Token: 0x0600978C RID: 38796 RVA: 0x008E3868 File Offset: 0x008E1A68
		public string TrkEmerProfGeneralRemoteActivationEmergency_UIValue
		{
			get
			{
				short num = (short)778766372;
				short num2 = num;
				num = (short)1831340068;
				switch (num2 == num)
				{
				}
				num = (short)481951744;
				short num3 = num;
				num = (short)383713280;
				if (num != 0)
				{
				}
				num = (short)144441345;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralRemoteActivationEmergency.UIValue;
			}
			set
			{
				short num = (short)1938882561;
				if (num != 0)
				{
				}
				num = (short)688255920;
				short num2 = num;
				num = (short)1999631280;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1832189952;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1462042624;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralRemoteActivationEmergency.UIValue = value;
			}
		}

		// Token: 0x17004C2D RID: 19501
		// (get) Token: 0x0600978D RID: 38797 RVA: 0x008E391C File Offset: 0x008E1B1C
		public global::AcpBusinessLayer.AcpListField TrkEmerProfGeneralRemoteActivationEmergency
		{
			get
			{
				short num = (short)324337665;
				if (num != 0)
				{
				}
				num = (short)138818599;
				short num2 = num;
				num = (short)1238643751;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1358495744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)365559808;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralRemoteActivationEmergency;
			}
		}

		// Token: 0x17004C2E RID: 19502
		// (get) Token: 0x0600978E RID: 38798 RVA: 0x008E39CC File Offset: 0x008E1BCC
		// (set) Token: 0x0600978F RID: 38799 RVA: 0x008E3A84 File Offset: 0x008E1C84
		public bool TrkEmerProfGeneralRemoteActivationEmergency_Applicable
		{
			get
			{
				short num = (short)590954444;
				short num2 = num;
				num = (short)1335377868;
				switch (num2 == num)
				{
				}
				num = (short)842924032;
				short num3 = num;
				num = (short)359333888;
				if (num != 0)
				{
				}
				num = (short)66060289;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralRemoteActivationEmergency.Applicable;
			}
			set
			{
				short num = (short)122570370;
				short num2 = num;
				num = (short)1117144706;
				switch (num2 == num)
				{
				}
				num = (short)1979645952;
				short num3 = num;
				num = (short)1351745537;
				if (num != 0)
				{
				}
				num = (short)1518338048;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralRemoteActivationEmergency.Applicable = value;
			}
		}

		// Token: 0x17004C2F RID: 19503
		// (get) Token: 0x06009790 RID: 38800 RVA: 0x008E3B3C File Offset: 0x008E1D3C
		// (set) Token: 0x06009791 RID: 38801 RVA: 0x008E3BF0 File Offset: 0x008E1DF0
		public bool TrkEmerProfGeneralRemoteActivationEmergency_Valid
		{
			get
			{
				short num = (short)1739193903;
				short num2 = num;
				num = (short)1724251695;
				switch (num2 == num)
				{
				}
				num = (short)565903360;
				short num3 = num;
				num = (short)1857748992;
				if (num != 0)
				{
				}
				num = (short)283639809;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralRemoteActivationEmergency.Valid;
			}
			set
			{
				short num = (short)2111290353;
				short num2 = num;
				num = (short)1019853809;
				switch (num2 == num)
				{
				}
				num = (short)1746731008;
				short num3 = num;
				num = (short)318439424;
				if (num != 0)
				{
				}
				num = (short)2111963137;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralRemoteActivationEmergency.Valid = value;
			}
		}

		// Token: 0x17004C30 RID: 19504
		// (get) Token: 0x06009792 RID: 38802 RVA: 0x008E3CA8 File Offset: 0x008E1EA8
		// (set) Token: 0x06009793 RID: 38803 RVA: 0x008E3D5C File Offset: 0x008E1F5C
		public bool TrkEmerProfGeneralRemoteActivationEmergency_Visible
		{
			get
			{
				short num = (short)2094381884;
				short num2 = num;
				num = (short)894483260;
				switch (num2 == num)
				{
				}
				num = (short)1654128640;
				short num3 = num;
				num = (short)105185281;
				if (num != 0)
				{
				}
				num = (short)2138112000;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralRemoteActivationEmergency.Visible;
			}
			set
			{
				short num = (short)1863745871;
				short num2 = num;
				num = (short)1837859151;
				switch (num2 == num)
				{
				}
				num = (short)1862664192;
				short num3 = num;
				num = (short)1814298625;
				if (num != 0)
				{
				}
				num = (short)163577856;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralRemoteActivationEmergency.Visible = value;
			}
		}

		// Token: 0x17004C31 RID: 19505
		// (get) Token: 0x06009794 RID: 38804 RVA: 0x008E3E14 File Offset: 0x008E2014
		// (set) Token: 0x06009795 RID: 38805 RVA: 0x008E3ECC File Offset: 0x008E20CC
		public bool TrkEmerProfGeneralRemoteActivationEmergency_Editable
		{
			get
			{
				short num = (short)546766082;
				short num2 = num;
				num = (short)1342635266;
				switch (num2 == num)
				{
				}
				num = (short)1786380288;
				short num3 = num;
				num = (short)1791623169;
				if (num != 0)
				{
				}
				num = (short)1759510528;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralRemoteActivationEmergency.Editable;
			}
			set
			{
				short num = (short)1257077146;
				short num2 = num;
				num = (short)1258715546;
				switch (num2 == num)
				{
				}
				num = (short)195690496;
				short num3 = num;
				num = (short)1240530945;
				if (num != 0)
				{
				}
				num = (short)746520576;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralRemoteActivationEmergency.Editable = value;
			}
		}

		// Token: 0x17004C32 RID: 19506
		// (get) Token: 0x06009796 RID: 38806 RVA: 0x008E3F80 File Offset: 0x008E2180
		internal string TrkEmerProfGeneralRemoteActivationEmergency_UILabel
		{
			get
			{
				short num = (short)343255319;
				short num2 = num;
				num = (short)925083927;
				switch (num2 == num)
				{
				}
				num = (short)2127626240;
				short num3 = num;
				num = (short)1767636993;
				if (num != 0)
				{
				}
				num = (short)1894711296;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralRemoteActivationEmergency.UIName;
			}
		}

		// Token: 0x17004C33 RID: 19507
		// (get) Token: 0x06009797 RID: 38807 RVA: 0x008E4038 File Offset: 0x008E2238
		// (set) Token: 0x06009798 RID: 38808 RVA: 0x008E40EC File Offset: 0x008E22EC
		internal bool TrkEmerProfGeneralRemoteActivationEmergency_HiddenStatic
		{
			get
			{
				short num = (short)1402749009;
				short num2 = num;
				num = (short)1175863377;
				switch (num2 == num)
				{
				}
				num = (short)120389632;
				short num3 = num;
				num = (short)1239154689;
				if (num != 0)
				{
				}
				num = (short)1241055232;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralRemoteActivationEmergency.HiddenStatic;
			}
			set
			{
				short num = (short)1241313769;
				short num2 = num;
				num = (short)1481896425;
				switch (num2 == num)
				{
				}
				num = (short)1472659456;
				short num3 = num;
				num = (short)1213726721;
				if (num != 0)
				{
				}
				num = (short)98566144;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralRemoteActivationEmergency.HiddenStatic = value;
			}
		}

		// Token: 0x17004C34 RID: 19508
		// (get) Token: 0x06009799 RID: 38809 RVA: 0x008E41A4 File Offset: 0x008E23A4
		// (set) Token: 0x0600979A RID: 38810 RVA: 0x008E4258 File Offset: 0x008E2458
		internal bool TrkEmerProfGeneralRemoteActivationEmergency_HiddenDynamic
		{
			get
			{
				short num = (short)1749378562;
				short num2 = num;
				num = (short)195061250;
				switch (num2 == num)
				{
				}
				num = (short)148373504;
				short num3 = num;
				num = (short)1352335360;
				if (num != 0)
				{
				}
				num = (short)1791557633;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralRemoteActivationEmergency.HiddenDynamic;
			}
			set
			{
				short num = (short)341508097;
				if (num != 0)
				{
				}
				num = (short)1492996975;
				short num2 = num;
				num = (short)8737647;
				switch (num2 == num)
				{
				default:
				{
					num = (short)199098368;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)512950272;
				if (num != 0)
				{
				}
				this.trkEmerProfGeneralRemoteActivationEmergency.HiddenDynamic = value;
			}
		}

		// Token: 0x17004C35 RID: 19509
		// (get) Token: 0x0600979B RID: 38811 RVA: 0x008E430C File Offset: 0x008E250C
		public bool TrkEmerProfGeneralRemoteActivationEmergency_HasDiffs
		{
			get
			{
				short num = (short)1343042258;
				short num2 = num;
				num = (short)1304244946;
				switch (num2 == num)
				{
				}
				num = (short)1522991104;
				short num3 = num;
				num = (short)1967456257;
				if (num != 0)
				{
				}
				num = (short)1438842880;
				if (num != 0)
				{
				}
				return this.trkEmerProfGeneralRemoteActivationEmergency._HasDiffs;
			}
		}

		// Token: 0x17004C36 RID: 19510
		// (get) Token: 0x0600979C RID: 38812 RVA: 0x008E43C0 File Offset: 0x008E25C0
		public global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.EmergencyWide RefEmergencyWide
		{
			get
			{
				short num = (short)1658857234;
				short num2 = num;
				num = (short)1482303250;
				switch (num2 == num)
				{
				}
				num = (short)1997537280;
				short num3 = num;
				num = (short)1898708993;
				if (num != 0)
				{
				}
				num = (short)440532992;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2032)[0] as global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.EmergencyWide;
			}
		}

		// Token: 0x17004C37 RID: 19511
		// (get) Token: 0x0600979D RID: 38813 RVA: 0x008E4480 File Offset: 0x008E2680
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide RefRadioWide
		{
			get
			{
				short num = (short)2057964562;
				short num2 = num;
				num = (short)1466174482;
				switch (num2 == num)
				{
				}
				num = (short)153681920;
				short num3 = num;
				num = (short)302383105;
				if (num != 0)
				{
				}
				num = (short)939524096;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
			}
		}

		// Token: 0x0600979E RID: 38814 RVA: 0x008E4540 File Offset: 0x008E2740
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
					return result;
				case 1:
				{
					num2 = (short)497025024;
					short num3 = num2;
					num2 = (short)634847233;
					if (num2 != 0)
					{
					}
					num2 = (short)1938358276;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					if (base.ParentRecset != null)
					{
						num2 = (short)1133641729;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 3:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)2016673792;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)1963130883;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				goto IL_24;
			}
			return result;
			IL_24:
			num2 = (short)34295079;
			short num4 = num2;
			num2 = (short)1294355751;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num2 = (short)1517748224;
				if (num2 != 0)
				{
				}
				result = null;
				break;
			}
			num2 = (short)94502914;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04004A3F RID: 19007
		private global::AcpBusinessLayer.AcpField<bool> trkEmerProfGeneralConsoleAckRequired_A7712;

		// Token: 0x04004A40 RID: 19008
		private global::AcpBusinessLayer.AcpListField trkEmerProfGeneralEmergencyOperation_A7926;

		// Token: 0x04004A41 RID: 19009
		private global::AcpBusinessLayer.AcpSimpleRangeField trkEmerProfGeneralRetryCounter_A8951;

		// Token: 0x04004A42 RID: 19010
		private global::AcpBusinessLayer.AcpListField trkEmerProfGeneralEmergencyTalkback_A9268;

		// Token: 0x04004A43 RID: 19011
		private global::AcpBusinessLayer.AcpField<bool> trkEmerProfGeneralRevertPTTID_A12642;

		// Token: 0x04004A44 RID: 19012
		private global::AcpBusinessLayer.AcpKeyField trkEmerProfGeneralkeyofTrunkingEmergencyProfiles_A19419;

		// Token: 0x04004A45 RID: 19013
		private global::AcpBusinessLayer.AcpListField trkEmerProEmergencyAutoTransmitMode_A22567;

		// Token: 0x04004A46 RID: 19014
		private global::AcpBusinessLayer.AcpSimpleRangeField trkEmerProfGeneralTxPeriodsec1_A7939;

		// Token: 0x04004A47 RID: 19015
		private global::AcpBusinessLayer.AcpSimpleRangeField trkEmerProfGeneralTxPeriodsec2_A9132;

		// Token: 0x04004A48 RID: 19016
		private global::AcpBusinessLayer.AcpField<bool> trkPerManDownEnable_42039;

		// Token: 0x04004A49 RID: 19017
		private global::AcpBusinessLayer.AcpListField trkEmerProfEmergencyHotAuxMic_A42300;

		// Token: 0x04004A4A RID: 19018
		private global::AcpBusinessLayer.AcpField<bool> trkPeEMGFindMeTxEnable_42921;

		// Token: 0x04004A4B RID: 19019
		private global::AcpBusinessLayer.AcpField<bool> trkPeEMGFindMeRxEnable_42923;

		// Token: 0x04004A4C RID: 19020
		private global::AcpBusinessLayer.AcpField<bool> trkEmerProfImpactDetectionEn_A43392;

		// Token: 0x04004A4D RID: 19021
		private global::AcpBusinessLayer.AcpField<bool> emergencyExitOnChannelChange_43588;

		// Token: 0x04004A4E RID: 19022
		private global::AcpBusinessLayer.AcpSimpleRangeField trkEmerProfGeneralTxPeriodsec2_A43601;

		// Token: 0x04004A4F RID: 19023
		private global::AcpBusinessLayer.AcpListField trkEmerProfGeneralRemoteActivationEmergency;
	}
}
