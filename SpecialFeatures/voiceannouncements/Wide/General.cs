using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using CommonResources;
using ConstraintHelper;
using Features.Radio_Ergonomics_Configuration.Display_and_Menu;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.VoiceAnnouncements.Wide
{
	// Token: 0x0200001A RID: 26
	[global::System.Serializable]
	public sealed class General : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06000091 RID: 145 RVA: 0x00002650 File Offset: 0x00000850
		internal General(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06000092 RID: 146 RVA: 0x0000265F File Offset: 0x0000085F
		internal General(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00010C14 File Offset: 0x0000EE14
		public override void Init()
		{
			int a_ = 4;
			short num = (short)737206650;
			short num2 = num;
			num = (short)204071290;
			switch (num2 == num)
			{
			}
			num = (short)364511232;
			if (num != 0)
			{
			}
			num = (short)1398472705;
			if (num != 0)
			{
			}
			num = (short)1057292288;
			short num3 = num;
			this.voiceAnnouncementPriority_A7651 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::SpecialFeatures.VoiceAnnouncements.Wide.LOVs.indexVoiceAnnouncementPriority_A76515LovStrs, global::SpecialFeatures.VoiceAnnouncements.Wide.LOVs.idVoiceAnnouncementPriority_A76515LovStrs), this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("톆킐ﶒﮔﺜ爵철욢쮤펦令\ud9aa쒬삮쎰\udab2솴캶諸誼覾", a_), global::CommonResources.AppResources.Voice_Announcement_Priority, global::SpecialFeatures.VoiceAnnouncements.Wide.LOVs.VoiceAnnouncementPriority_A76515LovStrs);
			this.voiceAnnouncementPriority_A7651.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.voiceAnnouncementPriority_A7651.DataTransferOrder = 6;
			this.suppressReplay_A44925 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("풆ﲈﮊﶌﶎ얖ﲘﺞ\ud8a0ﲢ鎦鶨銪龬骮", a_), global::CommonResources.AppResources.Suppress_Replay);
			this.suppressReplay_A44925.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.suppressReplay_A44925.DataTransferOrder = 65;
			this.scanOnAnnouncementID_A22250 = new global::AcpBusinessLayer.AcpRecRefField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("풆삎ﾐ튒ﮔ練ﲞ쒠캢삤즦\udda8膲螴薶貸论", a_), global::CommonResources.AppResources.Scan_On, new string[]
			{
				global::CommonResources.AppResources.None_Id,
				global::CommonResources.AppResources.TTS_Id
			}, new int[]
			{
				0,
				65535
			}, true, false);
			this.scanOnAnnouncementID_A22250.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.scanOnAnnouncementID_A22250.DataTransferOrder = 7;
			this.scanOffAnnouncementID_A22252 = new global::AcpBusinessLayer.AcpRecRefField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("풆삎풔練슠욢좤슦잨\udfaa螴薶许躺込", a_), global::CommonResources.AppResources.Scan_Off, new string[]
			{
				global::CommonResources.AppResources.None_Id,
				global::CommonResources.AppResources.TTS_Id
			}, new int[]
			{
				0,
				65535
			}, true, false);
			this.scanOffAnnouncementID_A22252.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.scanOffAnnouncementID_A22252.DataTransferOrder = 8;
			this.monitorOnAnnouncementID_A22254 = new global::AcpBusinessLayer.AcpRecRefField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쪆ﮎﺐ\uda94練\ud898풠춢욤슦쒨캪쎬\udbae许覺込誾", a_), global::CommonResources.AppResources.Monitor_On, new string[]
			{
				global::CommonResources.AppResources.None_Id,
				global::CommonResources.AppResources.TTS_Id
			}, new int[]
			{
				0,
				65535
			}, true, false);
			this.monitorOnAnnouncementID_A22254.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.monitorOnAnnouncementID_A22254.DataTransferOrder = 9;
			this.monitorOffAnnouncementID_A22256 = new global::AcpBusinessLayer.AcpRecRefField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쪆ﮎﺐ\uda94ﾘ\uda9a캠횢쮤쒦첨욪좬솮얰者覺込趾", a_), global::CommonResources.AppResources.Monitor_Off, new string[]
			{
				global::CommonResources.AppResources.None_Id,
				global::CommonResources.AppResources.TTS_Id
			}, new int[]
			{
				0,
				65535
			}, true, false);
			this.monitorOffAnnouncementID_A22256.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.monitorOffAnnouncementID_A22256.DataTransferOrder = 10;
			this.directModeOnAnnouncementID_A22258 = new global::AcpBusinessLayer.AcpRecRefField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎆力\ude92杖ﲘ풚\ude9e쾠춢쪤튦잨좪좬슮풰\uddb2솴ﺶﶸﲼ趾ￆ", a_), global::CommonResources.AppResources.Direct_Mode_On, new string[]
			{
				global::CommonResources.AppResources.None_Id,
				global::CommonResources.AppResources.TTS_Id
			}, new int[]
			{
				0,
				65535
			}, true, false);
			this.directModeOnAnnouncementID_A22258.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.directModeOnAnnouncementID_A22258.DataTransferOrder = 11;
			this.directModeOffAnnouncementID_A22121 = new global::AcpBusinessLayer.AcpRecRefField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎆力\ude92杖ﲘ풚ﮜ咽춢쮤좦\udca8얪캬쪮\udcb0횲\udbb4쎶ﾺﺾ", a_), global::CommonResources.AppResources.Direct_Mode_Off, new string[]
			{
				global::CommonResources.AppResources.None_Id,
				global::CommonResources.AppResources.TTS_Id
			}, new int[]
			{
				0,
				65535
			}, true, false);
			this.directModeOffAnnouncementID_A22121.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.directModeOffAnnouncementID_A22121.DataTransferOrder = 12;
			this.txInhibitOnAnnouncementID_A22260 = new global::AcpBusinessLayer.AcpRecRefField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("펆슊ﲔ횘\udc9c쾠첢키즦쪨캪사쪮\udfb0잲ﲴ諸込趾", a_), global::CommonResources.AppResources.Tx_Inhibit_On, new string[]
			{
				global::CommonResources.AppResources.None_Id,
				global::CommonResources.AppResources.TTS_Id
			}, new int[]
			{
				0,
				65535
			}, true, false);
			this.txInhibitOnAnnouncementID_A22260.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.txInhibitOnAnnouncementID_A22260.DataTransferOrder = 13;
			this.txInhibitOffAnnouncementID_A22262 = new global::AcpBusinessLayer.AcpRecRefField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("펆슊ﲔ횘ﶚﮜ\ude9e쾠춢쪤튦잨좪좬슮풰\uddb2솴ﺶﶸﲼ趾", a_), global::CommonResources.AppResources.Tx_Inhibit_Off, new string[]
			{
				global::CommonResources.AppResources.None_Id,
				global::CommonResources.AppResources.TTS_Id
			}, new int[]
			{
				0,
				65535
			}, true, false);
			this.txInhibitOffAnnouncementID_A22262.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.txInhibitOffAnnouncementID_A22262.DataTransferOrder = 14;
			this.radErgoCfgVAWide_A41497 = new global::AcpBusinessLayer.AcpRecRefField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ횔ﺘ춚\udc9c좞좠잢삤龪鲬鮮袰蒲", a_), global::CommonResources.AppResources.ICUA_On_ID, new string[]
			{
				global::CommonResources.AppResources.None_Id,
				global::CommonResources.AppResources.TTS_Id
			}, new int[]
			{
				0,
				65535
			}, true, false);
			this.radErgoCfgVAWide_A41497.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgoCfgVAWide_A41497.DataTransferOrder = 20;
			this.radErgoCfgVAWide_A41499 = new global::AcpBusinessLayer.AcpRecRefField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ횔ﺘ춚\udc9c좞좠잢삤龪鲬鮮袰課", a_), global::CommonResources.AppResources.ICUA_Off_ID, new string[]
			{
				global::CommonResources.AppResources.None_Id,
				global::CommonResources.AppResources.TTS_Id
			}, new int[]
			{
				0,
				65535
			}, true, false);
			this.radErgoCfgVAWide_A41499.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgoCfgVAWide_A41499.DataTransferOrder = 21;
			this.radErgoCfgVAWide_A41500 = new global::AcpBusinessLayer.AcpRecRefField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ횔ﺘ춚\udc9c좞좠잢삤龪鲬骮膰莲", a_), global::CommonResources.AppResources.Emergency_On_ID, new string[]
			{
				global::CommonResources.AppResources.None_Id,
				global::CommonResources.AppResources.TTS_Id
			}, new int[]
			{
				0,
				65535
			}, true, false);
			this.radErgoCfgVAWide_A41500.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgoCfgVAWide_A41500.DataTransferOrder = 22;
			this.radErgoCfgVAWide_A41501 = new global::AcpBusinessLayer.AcpRecRefField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ횔ﺘ춚\udc9c좞좠잢삤龪鲬骮膰芲", a_), global::CommonResources.AppResources.Secure_Tx_Select_On_ID, new string[]
			{
				global::CommonResources.AppResources.None_Id,
				global::CommonResources.AppResources.TTS_Id
			}, new int[]
			{
				0,
				65535
			}, true, false);
			this.radErgoCfgVAWide_A41501.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgoCfgVAWide_A41501.DataTransferOrder = 23;
			this.radErgoCfgVAWide_A41502 = new global::AcpBusinessLayer.AcpRecRefField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ횔ﺘ춚\udc9c좞좠잢삤龪鲬骮膰膲", a_), global::CommonResources.AppResources.Secure_Tx_Select_Off_ID, new string[]
			{
				global::CommonResources.AppResources.None_Id,
				global::CommonResources.AppResources.TTS_Id
			}, new int[]
			{
				0,
				65535
			}, true, false);
			this.radErgoCfgVAWide_A41502.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgoCfgVAWide_A41502.DataTransferOrder = 24;
			this.radErgoCfgVAWide_A41503 = new global::AcpBusinessLayer.AcpRecRefField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ횔ﺘ춚\udc9c좞좠잢삤龪鲬骮膰育", a_), global::CommonResources.AppResources.Keypad_Controls_Lock_On_ID, new string[]
			{
				global::CommonResources.AppResources.None_Id,
				global::CommonResources.AppResources.TTS_Id
			}, new int[]
			{
				0,
				65535
			}, true, false);
			this.radErgoCfgVAWide_A41503.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgoCfgVAWide_A41503.DataTransferOrder = 25;
			this.radErgoCfgVAWide_A41504 = new global::AcpBusinessLayer.AcpRecRefField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ횔ﺘ춚\udc9c좞좠잢삤龪鲬骮膰螲", a_), global::CommonResources.AppResources.Keypad_Controls_Lock_Off_ID, new string[]
			{
				global::CommonResources.AppResources.None_Id,
				global::CommonResources.AppResources.TTS_Id
			}, new int[]
			{
				0,
				65535
			}, true, false);
			this.radErgoCfgVAWide_A41504.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgoCfgVAWide_A41504.DataTransferOrder = 26;
			this.radErgoCfgVAWide_A41505 = new global::AcpBusinessLayer.AcpRecRefField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ횔ﺘ춚\udc9c좞좠잢삤龪鲬骮膰蚲", a_), global::CommonResources.AppResources.Multi_Functional_Button_Primary_Mode_ID, new string[]
			{
				global::CommonResources.AppResources.None_Id,
				global::CommonResources.AppResources.TTS_Id
			}, new int[]
			{
				0,
				65535
			}, true, false);
			this.radErgoCfgVAWide_A41505.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgoCfgVAWide_A41505.DataTransferOrder = 27;
			this.radErgoCfgVAWide_A41506 = new global::AcpBusinessLayer.AcpRecRefField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ횔ﺘ춚\udc9c좞좠잢삤龪鲬骮膰薲", a_), global::CommonResources.AppResources.Multi_Functional_Button_Secondary_Mode_ID, new string[]
			{
				global::CommonResources.AppResources.None_Id,
				global::CommonResources.AppResources.TTS_Id
			}, new int[]
			{
				0,
				65535
			}, true, false);
			this.radErgoCfgVAWide_A41506.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgoCfgVAWide_A41506.DataTransferOrder = 28;
			this.wrongBatteryOnAnnouncementID_43251 = new global::AcpBusinessLayer.AcpRecRefField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("킆ﮈ펐ﲘ킞쾠쮤즦욨\udeaa쎬첮풰\udeb2킴\ud9b6춸寮", a_), global::CommonResources.AppResources.Wrong_Battery_ID, new string[]
			{
				global::CommonResources.AppResources.None_Id,
				global::CommonResources.AppResources.TTS_Id
			}, new int[]
			{
				0,
				65535
			}, true, false);
			this.wrongBatteryOnAnnouncementID_43251.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.wrongBatteryOnAnnouncementID_43251.DataTransferOrder = 29;
			this.radErgoScanOnAnnouncementVoiceCommand = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ요튜춢쮤좦\udca8얪캬쪮\udcb0횲\udbb4쎶풺풼\udcbe꓀胂꫄꫆꓈꫊ꏌꯎ", a_), global::CommonResources.AppResources.ID_STRING_RAD_ERGO_SCAN_ON_ANCMNT_VCE_CMD, 35);
			this.radErgoScanOnAnnouncementVoiceCommand.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgoScanOnAnnouncementVoiceCommand.DataTransferOrder = 30;
			this.radErgoScanOffAnnouncementVoiceCommand = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ요튜咽잠쮤즦욨\udeaa쎬첮풰\udeb2킴\ud9b6춸튼횾ꋀꛂ蛄꣆꓈ꛊ곌ꇎ뗐", a_), global::CommonResources.AppResources.ID_STRING_RAD_ERGO_SCAN_OFF_ANCMNT_VCE_CMD, 35);
			this.radErgoScanOffAnnouncementVoiceCommand.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgoScanOffAnnouncementVoiceCommand.DataTransferOrder = 31;
			this.radErgoMonitorOnVoiceCommand = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ\ud894펠쮤욨슪캬쪮\udcb2\ud8b4\udab6\ud8b8햺\ud9bc", a_), global::CommonResources.AppResources.ID_STRING_RAD_ERGO_MNTR_ON_VCE_CMD, 35);
			this.radErgoMonitorOnVoiceCommand.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgoMonitorOnVoiceCommand.DataTransferOrder = 32;
			this.radErgoMonitorOffVoiceCommand = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ\ud894펠쎤솦ﾨ쒪쒬첮풰\udab4\udab6풸\udaba펼\udbbe", a_), global::CommonResources.AppResources.ID_STRING_RAD_ERGO_MNTR_OFF_VCE_CMD, 35);
			this.radErgoMonitorOffVoiceCommand.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgoMonitorOffVoiceCommand.DataTransferOrder = 33;
			this.radErgoDirectModeOnVoiceCommand = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ톔ﺖﺚﺜ첢솤슦얪ﮬ삮\ud8b0킲킴횸횺킼\udebe꿀Ꟃ", a_), global::CommonResources.AppResources.ID_STRING_RAD_ERGO_DRCT_MODE_ON_VCE_CMD, 35);
			this.radErgoDirectModeOnVoiceCommand.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgoDirectModeOnVoiceCommand.DataTransferOrder = 34;
			this.radErgoDirectModeOffVoiceCommand = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ톔ﺖﺚﺜ첢솤슦춪쮬瑩\udeb0\udab2횴튶視풺킼튾ꃀ귂ꇄ", a_), global::CommonResources.AppResources.ID_STRING_RAD_ERGO_DRCT_MODE_OFF_VCE_CMD, 35);
			this.radErgoDirectModeOffVoiceCommand.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgoDirectModeOffVoiceCommand.DataTransferOrder = 35;
			this.radErgoTxInhibitOnVoiceCommand = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ솔킘쎠쪢톤잨ﶪ슬욮튰횲\ud8b6풸횺\udcbc톾ꗀ", a_), global::CommonResources.AppResources.ID_STRING_RAD_ERGO_TX_INHIBIT_ON_VCE_CMD, 35);
			this.radErgoTxInhibitOnVoiceCommand.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgoTxInhibitOnVoiceCommand.DataTransferOrder = 36;
			this.radErgoTxInhibitOffVoiceCommand = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ솔킘쎠쪢톤쾨춪ﮬ삮\ud8b0킲킴횸횺킼\udebe꿀Ꟃ", a_), global::CommonResources.AppResources.ID_STRING_RAD_ERGO_TX_INHIBIT_OFF_VCE_CMD, 35);
			this.radErgoTxInhibitOffVoiceCommand.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgoTxInhibitOffVoiceCommand.DataTransferOrder = 37;
			this.radErgoEmergencyOnVoiceCommand = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ킔殺ﲘ煮爵쾠삢\udca4잨ﶪ슬욮튰횲\ud8b6풸횺\udcbc톾ꗀ", a_), global::CommonResources.AppResources.ID_STRING_RAD_ERGO_EMERGENCY_ON_VCE_CMD, 35);
			this.radErgoEmergencyOnVoiceCommand.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgoEmergencyOnVoiceCommand.DataTransferOrder = 38;
			this.radErgoInCallUserAlertOnVoiceCommand = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ\udc94練\uda98漢킢삤햦잪좬\uddae얰ﲲ\udbb4횸튺\udebc\udabe苀곂꣄꫆꣈ꗊ꧌", a_), global::CommonResources.AppResources.ID_STRING_RAD_ERGO_IN_CALL_USR_ALERT_ON_VCE_CMD, 35);
			this.radErgoInCallUserAlertOnVoiceCommand.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgoInCallUserAlertOnVoiceCommand.DataTransferOrder = 39;
			this.radErgoInCallUserAlertOffVoiceCommand = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ\udc94練\uda98漢킢삤햦잪좬\uddae얰ﲲ펴톶풺풼\udcbe꓀胂꫄꫆꓈꫊ꏌꯎ", a_), global::CommonResources.AppResources.ID_STRING_RAD_ERGO_IN_CALL_USR_ALERT_OFF_VCE_CMD, 35);
			this.radErgoInCallUserAlertOffVoiceCommand.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgoInCallUserAlertOffVoiceCommand.DataTransferOrder = 40;
			this.radErgoSecureTxSelectOnVoiceCommand = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ요滛爵\udba2슦얨캪캬\udbaeﺰ\uddb2\ud8b6킸\ud8ba\ud8bcﲾ껀껂꣄ꛆꟈ꿊", a_), global::CommonResources.AppResources.ID_STRING_RAD_ERGO_SECURE_TX_SELECT_ON_VCE_CMD, 35);
			this.radErgoSecureTxSelectOnVoiceCommand.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgoSecureTxSelectOnVoiceCommand.DataTransferOrder = 41;
			this.radErgoSecureTxSelectOffVoiceCommand = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ요滛爵\udba2슦얨캪캬\udbaeﺰ햲펴횸튺\udebc\udabe苀곂꣄꫆꣈ꗊ꧌", a_), global::CommonResources.AppResources.ID_STRING_RAD_ERGO_SECURE_TX_SELECT_OFF_VCE_CMD, 35);
			this.radErgoSecureTxSelectOffVoiceCommand.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgoSecureTxSelectOffVoiceCommand.DataTransferOrder = 42;
			this.radErgoKeyPadControlsLockOnVoiceCommand = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ\ude94쮚ﲜﮞ첢쮤펦\udba8쒪솬\udcaeﶰ\udcb2횴\udcb6햺킾ꣀꃂꃄ蓆ꛈꛊꃌ껎뿐럒", a_), global::CommonResources.AppResources.ID_STRING_RAD_ERGO_KEY_PAD_CTRL_LOCK_ON_VCE_CMD, 35);
			this.radErgoKeyPadControlsLockOnVoiceCommand.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgoKeyPadControlsLockOnVoiceCommand.DataTransferOrder = 43;
			this.radErgoKeyPadControlsLockOffVoiceCommand = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ\ude94쮚ﲜﮞ첢쮤펦\udba8쒪솬\udcaeﶰ\udcb2횴\udcb6\uddba\udbbc껀ꫂꛄꋆ諈꓊ꃌꋎ냐뷒뇔", a_), global::CommonResources.AppResources.ID_STRING_RAD_ERGO_KEY_PAD_CTRL_LOCK_OFF_VCE_CMD, 35);
			this.radErgoKeyPadControlsLockOffVoiceCommand.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgoKeyPadControlsLockOffVoiceCommand.DataTransferOrder = 44;
			this.radErgoMultiFuntionalButtonPrimaryModeCommand = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ\ud894\ud99e풠춢톤캦욨얪첬쎮욲솴쎶횸햺춾ꣀ껂꓄뗆냈蛊ꋌꯎ듐郒뫔뫖듘뫚돜믞", a_), global::CommonResources.AppResources.ID_STRING_RAD_ERGO_MULT_FUNC_BTN_PRIMARY_MODE_CMD, 35);
			this.radErgoMultiFuntionalButtonPrimaryModeCommand.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgoMultiFuntionalButtonPrimaryModeCommand.DataTransferOrder = 45;
			this.radErgoMultiFuntionalButtonSecondaryModeCommand = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ\ud894\ud99e풠춢톤캦욨얪첬쎮욲솴쎶횸햺\udabeꋀ곂ꯄꏆ꣈맊듌苎뻐럒냔铖뛘뛚냜뻞迠蟢", a_), global::CommonResources.AppResources.ID_STRING_RAD_ERGO_MULT_FUNC_BTN_SEC_MODE_CMD, 35);
			this.radErgoMultiFuntionalButtonSecondaryModeCommand.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgoMultiFuntionalButtonSecondaryModeCommand.DataTransferOrder = 46;
			this.radErgoWrongBatteryVoiceCommand = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ슔煮\udd9e삠힢톤슦\udba8튪ﮬ삮\ud8b0킲킴횸횺킼\udebe꿀Ꟃ", a_), global::CommonResources.AppResources.ID_STRING_RAD_ERGO_WRONG_BATTERY_VCE_CMD, 35);
			this.radErgoWrongBatteryVoiceCommand.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgoWrongBatteryVoiceCommand.DataTransferOrder = 47;
			this.radErgoOutOfRangeAnnouncementVoiceCommand = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ\uda94풚ﮜ춞삠춢스슦얪쎬삮쒰\uddb2횴튶풸\udeba펼쮾韀곂계꓆곈裊ꋌꋎ볐닒믔돖", a_), global::CommonResources.AppResources.ID_STRING_RAD_ERGO_OUT_OF_RANGE_VCE_CMD, 35);
			this.radErgoOutOfRangeAnnouncementVoiceCommand.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgoOutOfRangeAnnouncementVoiceCommand.DataTransferOrder = 48;
			this.radErgoSelfCheckFailAnnouncementVoiceCommand = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ요ﶚ\ude9c쒠삢캤좨슪솬\udfb0\uddb2\udab4슶ힸ\ud8ba\ud8bc튾꓀귂뇄釆ꛈꋊ껌꫎鋐볒룔뫖룘뗚맜", a_), global::CommonResources.AppResources.ID_STRING_RAD_ERGO_SELF_CHECK_FAILURE_VCE_CMD, 35);
			this.radErgoSelfCheckFailAnnouncementVoiceCommand.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgoSelfCheckFailAnnouncementVoiceCommand.DataTransferOrder = 49;
			this.radErgoAccessoryFailureAnnouncementVoiceCommand = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ풔滛ﺚ캠톢\udca4좨슪솬\udaae쎰횲\ud9b6ힸ풺좼톾ꋀꛂ꣄ꋆꟈ뿊鯌ꃎ룐냒냔铖뛘뛚냜뻞迠蟢", a_), global::CommonResources.AppResources.ID_STRING_RAD_ERGO_ACCESSORY_FAILURE_VCE_CMD, 35);
			this.radErgoAccessoryFailureAnnouncementVoiceCommand.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgoAccessoryFailureAnnouncementVoiceCommand.DataTransferOrder = 50;
			this.radErgoPowerDownAnnouncementVoiceCommand = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ얔ﺚ\udb9e캠풢쮤잨얪슬\udaae\udfb0킲킴\udab6\udcb8햺즼껀ꫂꛄꋆ諈꓊ꃌꋎ냐뷒뇔", a_), global::CommonResources.AppResources.ID_STRING_RAD_ERGO_POWER_DOWN_VCE_CMD, 35);
			this.radErgoPowerDownAnnouncementVoiceCommand.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgoPowerDownAnnouncementVoiceCommand.DataTransferOrder = 51;
			this.radErgoAntennaFailureAnnouncementVoiceCommand = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ풔練ﺚ삠쒤캦얨\udeaa\udfac쪮\uddb2\udbb4\ud8b6첸햺\udebc\udabe곀ꛂꯄ돆鿈꓊꓌곎듐郒뫔뫖듘뫚돜믞", a_), global::CommonResources.AppResources.ID_STRING_RAD_ERGO_ANTENNA_FAILURE_VCE_CMD, 35);
			this.radErgoAntennaFailureAnnouncementVoiceCommand.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgoAntennaFailureAnnouncementVoiceCommand.DataTransferOrder = 52;
			this.radErgoOverTemperatureAnnouncementVoiceCommand = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ\uda94ﲘ즜爵철펢삤햦좨\udfaa\ud8ac\uddae풰\udbb4\ud9b6횸캺펼\udcbe꓀껂ꃄ꧆뷈鷊ꋌꛎ닐뛒雔룖듘뛚볜뇞藠", a_), global::CommonResources.AppResources.ID_STRING_RAD_ERGO_OVER_TEMPERATURE_VCE_CMD, 35);
			this.radErgoOverTemperatureAnnouncementVoiceCommand.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgoOverTemperatureAnnouncementVoiceCommand.DataTransferOrder = 59;
			this.radErgoExitHazardZoneModeAnnouncementVoiceCommand = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ킔햜ﺞ\udba0슢힤쎦쒪쎬쪮ﲰ\udcb2톴튶햺펼킾듀귂ꛄꋆ꓈껊ꏌ믎蟐볒볔듖볘飚닜닞賠苢诤菦", a_), global::CommonResources.AppResources.ID_STRING_RAD_ERGO_EXIT_HAZARDZONE_MODE_VCE_CMD, 35);
			this.radErgoExitHazardZoneModeAnnouncementVoiceCommand.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgoExitHazardZoneModeAnnouncementVoiceCommand.DataTransferOrder = 60;
			this.radErgoRfDeviceCumulativeOverTemperatureAnnouncementVoiceCommand = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ잔\udd98ﺚ슠욢튦쒨\udeaa솬캮얰\udab2쎴튶춺\ud8bc춾闀ꛂ꣄럆곈맊곌믎ꓐꇒ냔雖럘뗚닜꫞迠胢胤諦賨藪駬맮黰髲雴鋶뫸铺郼鋾怀洂愄", a_), global::CommonResources.AppResources.ID_STRING_RAD_ERGO_RF_DEVICE_CUMULATIVE_OVER_TEMPERATURE_VCE_CMD, 35);
			this.radErgoRfDeviceCumulativeOverTemperatureAnnouncementVoiceCommand.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgoRfDeviceCumulativeOverTemperatureAnnouncementVoiceCommand.DataTransferOrder = 61;
			this.radErgoOptionalComponentCumulativeOverTemperatureAnnouncementVoiceCommand = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ\uda94삠쾢좦쒨\udbaa슬솮풰\uddb2솴첸횺좼펾ꃀ럂계뇆곈蓊믌꫎ꏐ蟒냔뫖꧘뻚꿜뻞闠離韤苦꣨藪菬胮蓰鷲雴鋶铸黺鏼课圀氂氄搆氈䠊戌戎簐爒笔猖", a_), global::CommonResources.AppResources.ID_STRING_RAD_ERGO_OPTIONAL_CUMULATIVE_OVER_TEMPERATURE_VCE_CMD, 35);
			this.radErgoOptionalComponentCumulativeOverTemperatureAnnouncementVoiceCommand.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgoOptionalComponentCumulativeOverTemperatureAnnouncementVoiceCommand.DataTransferOrder = 62;
			this.radErgoBatteryCumulativeOverTemperatureAnnouncementVoiceCommand = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ힔\ud8a0키쪦\udca8잪첬\udbae\ud8b0얲킴쾸\udeba쾼꓀껂뗄ꋆ믈꫊만뫎ꏐ뛒铔맖럘듚꣜뇞苠蛢裤苦蟨鿪믬胮飰郲郴듶雸雺郼黾漀朂", a_), global::CommonResources.AppResources.ID_STRING_RAD_ERGO_BATTERY_CUMULATIVE_OVER_TEMPERATURE_VCE_CMD, 35);
			this.radErgoBatteryCumulativeOverTemperatureAnnouncementVoiceCommand.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgoBatteryCumulativeOverTemperatureAnnouncementVoiceCommand.DataTransferOrder = 63;
			this.radErgoNonHZMAccessoryAnnouncementVoiceCommand = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ\udb94펚잜튞삢욤슦\udaa8\ud8aa슬\uddae좰\udbb4\ud9b6횸캺펼\udcbe꓀껂ꃄ꧆뷈鷊ꋌꛎ닐뛒雔룖듘뛚볜뇞藠", a_), global::CommonResources.AppResources.ID_STRING_RAD_ERGO_NON_HZM_ACCESSORY_VCE_CMD, 35);
			this.radErgoNonHZMAccessoryAnnouncementVoiceCommand.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgoNonHZMAccessoryAnnouncementVoiceCommand.DataTransferOrder = 64;
			this.radErgoCfgVAWidePowerDown = new global::AcpBusinessLayer.AcpRecRefField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ횔ﺘ춚\udc9c좞좠잢삤욨\udcaa좬\uddae\udcb2슴\ud9b6", a_), global::CommonResources.AppResources.Power_Down_ID, new string[]
			{
				global::CommonResources.AppResources.None_Id,
				global::CommonResources.AppResources.TTS_Id
			}, new int[]
			{
				0,
				65535
			}, true, false);
			this.radErgoCfgVAWidePowerDown.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgoCfgVAWidePowerDown.DataTransferOrder = 53;
			this.radErgoCfgVAWideAntennaFailure = new global::AcpBusinessLayer.AcpRecRefField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ횔ﺘ춚\udc9c좞좠잢삤잨\udfaa좬솮\udfb0튲횶킸ힺ좼춾꓀", a_), global::CommonResources.AppResources.Antenna_Failure_ID, new string[]
			{
				global::CommonResources.AppResources.None_Id,
				global::CommonResources.AppResources.TTS_Id
			}, new int[]
			{
				0,
				65535
			}, true, false);
			this.radErgoCfgVAWideAntennaFailure.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgoCfgVAWideAntennaFailure.DataTransferOrder = 54;
			this.radErgoCfgVAWideRFDeviceCumulativeOverTemperature = new global::AcpBusinessLayer.AcpRecRefField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ횔ﺘ춚\udc9c좞좠잢삤좬\ud9ae\ud8b0킲킴첸횺좼펾ꃀ럂계뇆곈蓊믌꫎ꏐ蟒냔뫖꧘뻚꿜뻞闠離韤苦", a_), global::CommonResources.AppResources.RF_Device_Cumulative_Over_Temperature_ID, new string[]
			{
				global::CommonResources.AppResources.None_Id,
				global::CommonResources.AppResources.TTS_Id
			}, new int[]
			{
				0,
				65535
			}, true, false);
			this.radErgoCfgVAWideRFDeviceCumulativeOverTemperature.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgoCfgVAWideRFDeviceCumulativeOverTemperature.DataTransferOrder = 55;
			this.radErgoCfgVAWideOptionalComponentCumulativeOverTemperature = new global::AcpBusinessLayer.AcpRecRefField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ횔ﺘ춚\udc9c좞좠잢삤\ud9a8\udfaa쒬삮\udfb0튲\ud9b4횸횺춼킾꿀ꛂꯄ돆諈뻊ꃌ뫎뷐닒ꇔ뻖꿘뻚鋜꧞蓠釢뇤苦蓨鯪裬鷮郰蟲胴藶鳸", a_), global::CommonResources.AppResources.Optional_Component_Cumulative_Over_Temperature_ID, new string[]
			{
				global::CommonResources.AppResources.None_Id,
				global::CommonResources.AppResources.TTS_Id
			}, new int[]
			{
				0,
				65535
			}, true, false);
			this.radErgoCfgVAWideOptionalComponentCumulativeOverTemperature.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgoCfgVAWideOptionalComponentCumulativeOverTemperature.DataTransferOrder = 56;
			this.radErgoCfgVAWideNonHZMAccessory = new global::AcpBusinessLayer.AcpRecRefField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ횔ﺘ춚\udc9c좞좠잢삤욨얪ﲰ횴풶\udcb8좺캼킾돀뫂", a_), global::CommonResources.AppResources.Non_HZM_Accessory_ID, new string[]
			{
				global::CommonResources.AppResources.None_Id,
				global::CommonResources.AppResources.TTS_Id
			}, new int[]
			{
				0,
				65535
			}, true, false);
			this.radErgoCfgVAWideNonHZMAccessory.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgoCfgVAWideNonHZMAccessory.DataTransferOrder = 57;
			this.radErgoCfgVAWideBatteryCumulativeOverTemperature = new global::AcpBusinessLayer.AcpRecRefField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ횔ﺘ춚\udc9c좞좠잢삤좨\udfaa\ud9ac쪮쎰쪲슶풸캺톼\udebe뗀ꫂ도ꋆ蛈뷊꣌뷎藐뛒룔Ꟗ볘꧚볜ꯞ铠釢胤", a_), global::CommonResources.AppResources.Battery_Cumulative_Over_Temperature_ID, new string[]
			{
				global::CommonResources.AppResources.None_Id,
				global::CommonResources.AppResources.TTS_Id
			}, new int[]
			{
				0,
				65535
			}, true, false);
			this.radErgoCfgVAWideBatteryCumulativeOverTemperature.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgoCfgVAWideBatteryCumulativeOverTemperature.DataTransferOrder = 58;
			this.siteSelectableAlertAllowedinOutofRange_A42013 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("풆ﾊ\udc8eﾒ漢ﾜ쒠즤슦\udba8\udfaa쎮\uddb0\udcb2슴튶\uddb8튺펼듀럂꫄ꇆ鯈꫊ꏌ꣎듐賒铔", a_), global::CommonResources.AppResources.ID_SSA_ALLOWED_OUT_OF_RANGE);
			this.siteSelectableAlertAllowedinOutofRange_A42013.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.siteSelectableAlertAllowedinOutofRange_A42013.DataTransferOrder = 5;
			this.radErgoCfgVAWideExitHazardZoneMode = new global::AcpBusinessLayer.AcpRecRefField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ횔ﺘ춚\udc9c좞좠잢삤톨슪\ud9ac킰즲풴얶\uddb8튼톾꓀軂꫄ꏆ곈", a_), global::CommonResources.AppResources.Exit_Hazard_Zone_Mode, new string[]
			{
				global::CommonResources.AppResources.None_Id,
				global::CommonResources.AppResources.TTS_Id
			}, new int[]
			{
				0,
				65535
			}, true, false);
			this.radErgoCfgVAWideExitHazardZoneMode.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgoCfgVAWideExitHazardZoneMode.DataTransferOrder = 15;
			this.radErgoCfgVAWideSelfCheckFailure = new global::AcpBusinessLayer.AcpRecRefField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ횔ﺘ춚\udc9c좞좠잢삤첨잪쮬\ud9b0횲횴\udcb6ﾸ\udaba풼펾듀뇂ꃄ", a_), global::CommonResources.AppResources.SELF_CHECK_FAILURE, new string[]
			{
				global::CommonResources.AppResources.None_Id,
				global::CommonResources.AppResources.TTS_Id
			}, new int[]
			{
				0,
				65535
			}, true, false);
			this.radErgoCfgVAWideSelfCheckFailure.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgoCfgVAWideSelfCheckFailure.DataTransferOrder = 16;
			this.radErgoCfgVAWideAccessoryFailure = new global::AcpBusinessLayer.AcpRecRefField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ횔ﺘ춚\udc9c좞좠잢삤쪨좪좬\udcae슰\udcb2잴캶ﾸ\udaba풼펾듀뇂ꃄ", a_), global::CommonResources.AppResources.ACCESSORY_FAILURE, new string[]
			{
				global::CommonResources.AppResources.None_Id,
				global::CommonResources.AppResources.TTS_Id
			}, new int[]
			{
				0,
				65535
			}, true, false);
			this.radErgoCfgVAWideAccessoryFailure.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgoCfgVAWideAccessoryFailure.DataTransferOrder = 17;
			this.radErgoCfgVAWideOutOfRange = new global::AcpBusinessLayer.AcpRecRefField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ횔ﺘ춚\udc9c좞좠잢삤\udca8\udfaa즮튲\udbb4킶\udcb8", a_), global::CommonResources.AppResources.VC_OUT_OF_RANGE, new string[]
			{
				global::CommonResources.AppResources.None_Id,
				global::CommonResources.AppResources.TTS_Id
			}, new int[]
			{
				0,
				65535
			}, true, false);
			this.radErgoCfgVAWideOutOfRange.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgoCfgVAWideOutOfRange.DataTransferOrder = 18;
			this.radErgoCfgVAWideOverTemperature = new global::AcpBusinessLayer.AcpRecRefField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ횔ﺘ춚\udc9c좞좠잢삤\udfa8캪\udfacﮮ풰\udeb2어튶쮸\udaba즼쪾돀ꛂ", a_), global::CommonResources.AppResources.OVER_TEMPERATURE, new string[]
			{
				global::CommonResources.AppResources.None_Id,
				global::CommonResources.AppResources.TTS_Id
			}, new int[]
			{
				0,
				65535
			}, true, false);
			this.radErgoCfgVAWideOverTemperature.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgoCfgVAWideOverTemperature.DataTransferOrder = 19;
			base.FeatureSectionName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삆ﶎﾒ", a_);
			base.Id = 10501;
			base.UIName = global::CommonResources.AppResources.General_Id;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00011F7C File Offset: 0x0001017C
		public override void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			short num = (short)73201474;
			short num2 = num;
			num = (short)1880487746;
			switch (num2 == num)
			{
			}
			num = (short)512688129;
			if (num != 0)
			{
			}
			num = (short)314572800;
			if (num != 0)
			{
			}
			num = (short)93519872;
			short num3 = num;
			base.GetObjectData(info, context);
		}

		// Token: 0x06000095 RID: 149 RVA: 0x0001202C File Offset: 0x0001022C
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 4;
			short num = (short)197394463;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					this.radErgoCfgVAWide_A41505 = new global::AcpBusinessLayer.AcpRecRefField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ횔ﺘ춚\udc9c좞좠잢삤龪鲬骮膰蚲", a_), global::CommonResources.AppResources.Multi_Functional_Button_Primary_Mode_ID, new string[]
					{
						global::CommonResources.AppResources.None_Id,
						global::CommonResources.AppResources.TTS_Id
					}, new int[]
					{
						0,
						65535
					}, true, false);
					this.radErgoCfgVAWide_A41505.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radErgoCfgVAWide_A41505.DataTransferOrder = 27;
					num = (short)445251769;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_1BCF;
				case 2:
					this.radErgoPowerDownAnnouncementVoiceCommand = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ얔ﺚ\udb9e캠풢쮤잨얪슬\udaae\udfb0킲킴\udab6\udcb8햺즼껀ꫂꛄꋆ諈꓊ꃌꋎ냐뷒뇔", a_), global::CommonResources.AppResources.ID_STRING_RAD_ERGO_POWER_DOWN_VCE_CMD, 35);
					this.radErgoPowerDownAnnouncementVoiceCommand.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radErgoPowerDownAnnouncementVoiceCommand.DataTransferOrder = 51;
					num = (short)182059162;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("펆슊ﲔ횘ﶚﮜ\ude9e쾠춢쪤튦잨좪좬슮풰\uddb2솴ﺶﶸﲼ趾", a_)))
					{
						num = (short)1697251428;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1235;
				case 4:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ얔ﺚ\udb9e캠풢쮤잨얪슬\udaae\udfb0킲킴\udab6\udcb8햺즼껀ꫂꛄꋆ諈꓊ꃌꋎ냐뷒뇔", a_)))
					{
						num = (short)2084241410;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1D59;
				case 5:
					goto IL_1E40;
				case 6:
					this.radErgoMultiFuntionalButtonSecondaryModeCommand = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ\ud894\ud99e풠춢톤캦욨얪첬쎮욲솴쎶횸햺\udabeꋀ곂ꯄꏆ꣈맊듌苎뻐럒냔铖뛘뛚냜뻞迠蟢", a_), global::CommonResources.AppResources.ID_STRING_RAD_ERGO_MULT_FUNC_BTN_SEC_MODE_CMD, 35);
					this.radErgoMultiFuntionalButtonSecondaryModeCommand.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radErgoMultiFuntionalButtonSecondaryModeCommand.DataTransferOrder = 46;
					num = (short)1614217305;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					goto IL_1F38;
				case 8:
					goto IL_2CEF;
				case 9:
					goto IL_F09;
				case 10:
				{
					num = (short)1994655829;
					short num3 = num;
					num = (short)735250517;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_2613;
					default:
						num = (short)862257152;
						if (num != 0)
						{
						}
						this.radErgoOutOfRangeAnnouncementVoiceCommand = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ\uda94풚ﮜ춞삠춢스슦얪쎬삮쒰\uddb2횴튶풸\udeba펼쮾韀곂계꓆곈裊ꋌꋎ볐닒믔돖", a_), global::CommonResources.AppResources.ID_STRING_RAD_ERGO_OUT_OF_RANGE_VCE_CMD, 35);
						this.radErgoOutOfRangeAnnouncementVoiceCommand.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
						this.radErgoOutOfRangeAnnouncementVoiceCommand.DataTransferOrder = 48;
						num = (short)13762634;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 11:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ슔煮\udd9e삠힢톤슦\udba8튪ﮬ삮\ud8b0킲킴횸횺킼\udebe꿀Ꟃ", a_)))
					{
						num = (short)906166391;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1F85;
				case 12:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("풆삎풔練슠욢좤슦잨\udfaa螴薶许躺込", a_)))
					{
						num = (short)208732238;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_11E7;
				case 13:
					goto IL_D02;
				case 14:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ킔殺ﲘ煮爵쾠삢\udca4잨ﶪ슬욮튰횲\ud8b6풸횺\udcbc톾ꗀ", a_)))
					{
						num = (short)464715959;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_E13;
				case 15:
					goto IL_2618;
				case 16:
					goto IL_2CA3;
				case 17:
					goto IL_DC6;
				case 18:
					this.radErgoCfgVAWideNonHZMAccessory = new global::AcpBusinessLayer.AcpRecRefField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ횔ﺘ춚\udc9c좞좠잢삤욨얪ﲰ횴풶\udcb8좺캼킾돀뫂", a_), global::CommonResources.AppResources.Non_HZM_Accessory_ID, new string[]
					{
						global::CommonResources.AppResources.None_Id,
						global::CommonResources.AppResources.TTS_Id
					}, new int[]
					{
						0,
						65535
					}, true, false);
					this.radErgoCfgVAWideNonHZMAccessory.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radErgoCfgVAWideNonHZMAccessory.DataTransferOrder = 57;
					num = (short)1985675352;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 19:
					this.radErgoMonitorOnVoiceCommand = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ\ud894펠쮤욨슪캬쪮\udcb2\ud8b4\udab6\ud8b8햺\ud9bc", a_), global::CommonResources.AppResources.ID_STRING_RAD_ERGO_MNTR_ON_VCE_CMD, 35);
					this.radErgoMonitorOnVoiceCommand.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radErgoMonitorOnVoiceCommand.DataTransferOrder = 32;
					num = (short)440533074;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 20:
					this.radErgoInCallUserAlertOffVoiceCommand = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ\udc94練\uda98漢킢삤햦잪좬\uddae얰ﲲ펴톶풺풼\udcbe꓀胂꫄꫆꓈꫊ꏌꯎ", a_), global::CommonResources.AppResources.ID_STRING_RAD_ERGO_IN_CALL_USR_ALERT_OFF_VCE_CMD, 35);
					this.radErgoInCallUserAlertOffVoiceCommand.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radErgoInCallUserAlertOffVoiceCommand.DataTransferOrder = 40;
					num = (short)1412104285;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 21:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ힔\ud8a0키쪦\udca8잪첬\udbae\ud8b0얲킴쾸\udeba쾼꓀껂뗄ꋆ믈꫊만뫎ꏐ뛒铔맖럘듚꣜뇞苠蛢裤苦蟨鿪믬胮飰郲郴듶雸雺郼黾漀朂", a_)))
					{
						num = (short)1001979934;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_955;
				case 22:
					this.scanOnAnnouncementID_A22250 = new global::AcpBusinessLayer.AcpRecRefField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("풆삎ﾐ튒ﮔ練ﲞ쒠캢삤즦\udda8膲螴薶貸论", a_), global::CommonResources.AppResources.Scan_On, new string[]
					{
						global::CommonResources.AppResources.None_Id,
						global::CommonResources.AppResources.TTS_Id
					}, new int[]
					{
						0,
						65535
					}, true, false);
					this.scanOnAnnouncementID_A22250.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.scanOnAnnouncementID_A22250.DataTransferOrder = 7;
					num = (short)161742864;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 23:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("풆삎ﾐ튒ﮔ練ﲞ쒠캢삤즦\udda8膲螴薶貸论", a_)))
					{
						num = (short)127008790;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2CA3;
				case 24:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ솔킘쎠쪢톤잨ﶪ슬욮튰횲\ud8b6풸횺\udcbc톾ꗀ", a_)))
					{
						num = (short)741605535;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_183B;
				case 25:
					goto IL_183B;
				case 26:
					this.radErgoCfgVAWideExitHazardZoneMode = new global::AcpBusinessLayer.AcpRecRefField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ횔ﺘ춚\udc9c좞좠잢삤톨슪\ud9ac킰즲풴얶\uddb8튼톾꓀軂꫄ꏆ곈", a_), global::CommonResources.AppResources.Exit_Hazard_Zone_Mode, new string[]
					{
						global::CommonResources.AppResources.None_Id,
						global::CommonResources.AppResources.TTS_Id
					}, new int[]
					{
						0,
						65535
					}, true, false);
					this.radErgoCfgVAWideExitHazardZoneMode.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radErgoCfgVAWideExitHazardZoneMode.DataTransferOrder = 15;
					num = (short)530120873;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 27:
					this.directModeOffAnnouncementID_A22121 = new global::AcpBusinessLayer.AcpRecRefField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎆力\ude92杖ﲘ풚ﮜ咽춢쮤좦\udca8얪캬쪮\udcb0횲\udbb4쎶ﾺﺾ", a_), global::CommonResources.AppResources.Direct_Mode_Off, new string[]
					{
						global::CommonResources.AppResources.None_Id,
						global::CommonResources.AppResources.TTS_Id
					}, new int[]
					{
						0,
						65535
					}, true, false);
					this.directModeOffAnnouncementID_A22121.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.directModeOffAnnouncementID_A22121.DataTransferOrder = 12;
					num = (short)1067843742;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 28:
					goto IL_2972;
				case 29:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ톔ﺖﺚﺜ첢솤슦춪쮬瑩\udeb0\udab2횴튶視풺킼튾ꃀ귂ꇄ", a_)))
					{
						num = (short)392036392;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1795;
				case 30:
					this.radErgoBatteryCumulativeOverTemperatureAnnouncementVoiceCommand = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ힔\ud8a0키쪦\udca8잪첬\udbae\ud8b0얲킴쾸\udeba쾼꓀껂뗄ꋆ믈꫊만뫎ꏐ뛒铔맖럘듚꣜뇞苠蛢裤苦蟨鿪믬胮飰郲郴듶雸雺郼黾漀朂", a_), global::CommonResources.AppResources.ID_STRING_RAD_ERGO_BATTERY_CUMULATIVE_OVER_TEMPERATURE_VCE_CMD, 35);
					this.radErgoBatteryCumulativeOverTemperatureAnnouncementVoiceCommand.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radErgoBatteryCumulativeOverTemperatureAnnouncementVoiceCommand.DataTransferOrder = 63;
					num = (short)1267859626;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 31:
					switch (0)
					{
					case 0:
						goto IL_31A;
					}
					continue;
				case 32:
					goto IL_1ABC;
				case 33:
					this.radErgoMonitorOffVoiceCommand = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ\ud894펠쎤솦ﾨ쒪쒬첮풰\udab4\udab6풸\udaba펼\udbbe", a_), global::CommonResources.AppResources.ID_STRING_RAD_ERGO_MNTR_OFF_VCE_CMD, 35);
					this.radErgoMonitorOffVoiceCommand.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radErgoMonitorOffVoiceCommand.DataTransferOrder = 33;
					num = (short)1797390518;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 34:
					goto IL_1235;
				case 35:
					this.radErgoCfgVAWide_A41503 = new global::AcpBusinessLayer.AcpRecRefField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ횔ﺘ춚\udc9c좞좠잢삤龪鲬骮膰育", a_), global::CommonResources.AppResources.Keypad_Controls_Lock_On_ID, new string[]
					{
						global::CommonResources.AppResources.None_Id,
						global::CommonResources.AppResources.TTS_Id
					}, new int[]
					{
						0,
						65535
					}, true, false);
					this.radErgoCfgVAWide_A41503.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radErgoCfgVAWide_A41503.DataTransferOrder = 25;
					num = (short)1480065146;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 36:
					this.radErgoCfgVAWide_A41501 = new global::AcpBusinessLayer.AcpRecRefField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ횔ﺘ춚\udc9c좞좠잢삤龪鲬骮膰芲", a_), global::CommonResources.AppResources.Secure_Tx_Select_On_ID, new string[]
					{
						global::CommonResources.AppResources.None_Id,
						global::CommonResources.AppResources.TTS_Id
					}, new int[]
					{
						0,
						65535
					}, true, false);
					this.radErgoCfgVAWide_A41501.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radErgoCfgVAWide_A41501.DataTransferOrder = 23;
					num = (short)737738905;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 37:
					goto IL_598;
				case 38:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ횔ﺘ춚\udc9c좞좠잢삤龪鲬骮膰螲", a_)))
					{
						num = (short)271777960;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2B30;
				case 39:
					this.radErgoKeyPadControlsLockOffVoiceCommand = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ\ude94쮚ﲜﮞ첢쮤펦\udba8쒪솬\udcaeﶰ\udcb2횴\udcb6\uddba\udbbc껀ꫂꛄꋆ諈꓊ꃌꋎ냐뷒뇔", a_), global::CommonResources.AppResources.ID_STRING_RAD_ERGO_KEY_PAD_CTRL_LOCK_OFF_VCE_CMD, 35);
					this.radErgoKeyPadControlsLockOffVoiceCommand.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radErgoKeyPadControlsLockOffVoiceCommand.DataTransferOrder = 44;
					num = (short)1246363753;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 40:
					this.radErgoDirectModeOffVoiceCommand = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ톔ﺖﺚﺜ첢솤슦춪쮬瑩\udeb0\udab2횴튶視풺킼튾ꃀ귂ꇄ", a_), global::CommonResources.AppResources.ID_STRING_RAD_ERGO_DRCT_MODE_OFF_VCE_CMD, 35);
					this.radErgoDirectModeOffVoiceCommand.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radErgoDirectModeOffVoiceCommand.DataTransferOrder = 35;
					num = (short)1069678647;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 41:
					this.radErgoAntennaFailureAnnouncementVoiceCommand = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ풔練ﺚ삠쒤캦얨\udeaa\udfac쪮\uddb2\udbb4\ud8b6첸햺\udebc\udabe곀ꛂꯄ돆鿈꓊꓌곎듐郒뫔뫖듘뫚돜믞", a_), global::CommonResources.AppResources.ID_STRING_RAD_ERGO_ANTENNA_FAILURE_VCE_CMD, 35);
					this.radErgoAntennaFailureAnnouncementVoiceCommand.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radErgoAntennaFailureAnnouncementVoiceCommand.DataTransferOrder = 52;
					num = (short)597360717;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 42:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ요滛爵\udba2슦얨캪캬\udbaeﺰ\uddb2\ud8b6킸\ud8ba\ud8bcﲾ껀껂꣄ꛆꟈ꿊", a_)))
					{
						num = (short)817692735;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1E40;
				case 43:
					goto IL_119A;
				case 44:
					this.radErgoOverTemperatureAnnouncementVoiceCommand = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ\uda94ﲘ즜爵철펢삤햦좨\udfaa\ud8ac\uddae풰\udbb4\ud9b6횸캺펼\udcbe꓀껂ꃄ꧆뷈鷊ꋌꛎ닐뛒雔룖듘뛚볜뇞藠", a_), global::CommonResources.AppResources.ID_STRING_RAD_ERGO_OVER_TEMPERATURE_VCE_CMD, 35);
					this.radErgoOverTemperatureAnnouncementVoiceCommand.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radErgoOverTemperatureAnnouncementVoiceCommand.DataTransferOrder = 59;
					num = (short)1782186086;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 45:
					goto IL_2613;
				case 46:
					this.radErgoExitHazardZoneModeAnnouncementVoiceCommand = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ킔햜ﺞ\udba0슢힤쎦쒪쎬쪮ﲰ\udcb2톴튶햺펼킾듀귂ꛄꋆ꓈껊ꏌ믎蟐볒볔듖볘飚닜닞賠苢诤菦", a_), global::CommonResources.AppResources.ID_STRING_RAD_ERGO_EXIT_HAZARDZONE_MODE_VCE_CMD, 35);
					this.radErgoExitHazardZoneModeAnnouncementVoiceCommand.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radErgoExitHazardZoneModeAnnouncementVoiceCommand.DataTransferOrder = 60;
					num = (short)1687683152;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 47:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ\udc94練\uda98漢킢삤햦잪좬\uddae얰ﲲ\udbb4횸튺\udebc\udabe苀곂꣄꫆꣈ꗊ꧌", a_)))
					{
						num = (short)1721827419;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_201C;
				case 48:
					this.radErgoScanOnAnnouncementVoiceCommand = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ요튜춢쮤좦\udca8얪캬쪮\udcb0횲\udbb4쎶풺풼\udcbe꓀胂꫄꫆꓈꫊ꏌꯎ", a_), global::CommonResources.AppResources.ID_STRING_RAD_ERGO_SCAN_ON_ANCMNT_VCE_CMD, 35);
					this.radErgoScanOnAnnouncementVoiceCommand.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radErgoScanOnAnnouncementVoiceCommand.DataTransferOrder = 30;
					num = (short)823197846;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 49:
					this.radErgoNonHZMAccessoryAnnouncementVoiceCommand = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ\udb94펚잜튞삢욤슦\udaa8\ud8aa슬\uddae좰\udbb4\ud9b6횸캺펼\udcbe꓀껂ꃄ꧆뷈鷊ꋌꛎ닐뛒雔룖듘뛚볜뇞藠", a_), global::CommonResources.AppResources.ID_STRING_RAD_ERGO_NON_HZM_ACCESSORY_VCE_CMD, 35);
					this.radErgoNonHZMAccessoryAnnouncementVoiceCommand.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radErgoNonHZMAccessoryAnnouncementVoiceCommand.DataTransferOrder = 64;
					num = (short)948961453;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 50:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("펆슊ﲔ횘\udc9c쾠첢키즦쪨캪사쪮\udfb0잲ﲴ諸込趾", a_)))
					{
						num = (short)1340014676;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_810;
				case 51:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ\ude94쮚ﲜﮞ첢쮤펦\udba8쒪솬\udcaeﶰ\udcb2횴\udcb6\uddba\udbbc껀ꫂꛄꋆ諈꓊ꃌꋎ냐뷒뇔", a_)))
					{
						num = (short)1449787431;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1748;
				case 52:
					goto IL_10B3;
				case 53:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ횔ﺘ춚\udc9c좞좠잢삤톨슪\ud9ac킰즲풴얶\uddb8튼톾꓀軂꫄ꏆ곈", a_)))
					{
						num = (short)1747517466;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2F06;
				case 54:
					if (producerFields != null)
					{
						num = (short)951648411;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2FCC;
				case 55:
					goto IL_1795;
				case 56:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ톔ﺖﺚﺜ첢솤슦얪ﮬ삮\ud8b0킲킴횸횺킼\udebe꿀Ꟃ", a_)))
					{
						num = (short)708247708;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2B7F;
				case 57:
					goto IL_6DC;
				case 58:
					this.radErgoRfDeviceCumulativeOverTemperatureAnnouncementVoiceCommand = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ잔\udd98ﺚ슠욢튦쒨\udeaa솬캮얰\udab2쎴튶춺\ud8bc춾闀ꛂ꣄럆곈맊곌믎ꓐꇒ냔雖럘뗚닜꫞迠胢胤諦賨藪駬맮黰髲雴鋶뫸铺郼鋾怀洂愄", a_), global::CommonResources.AppResources.ID_STRING_RAD_ERGO_RF_DEVICE_CUMULATIVE_OVER_TEMPERATURE_VCE_CMD, 35);
					this.radErgoRfDeviceCumulativeOverTemperatureAnnouncementVoiceCommand.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radErgoRfDeviceCumulativeOverTemperatureAnnouncementVoiceCommand.DataTransferOrder = 61;
					num = (short)742916207;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 59:
					goto IL_2512;
				case 60:
					goto IL_2A1A;
				case 61:
					this.radErgoCfgVAWide_A41499 = new global::AcpBusinessLayer.AcpRecRefField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ횔ﺘ춚\udc9c좞좠잢삤龪鲬鮮袰課", a_), global::CommonResources.AppResources.ICUA_Off_ID, new string[]
					{
						global::CommonResources.AppResources.None_Id,
						global::CommonResources.AppResources.TTS_Id
					}, new int[]
					{
						0,
						65535
					}, true, false);
					this.radErgoCfgVAWide_A41499.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radErgoCfgVAWide_A41499.DataTransferOrder = 21;
					num = (short)561119340;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 62:
					goto IL_1624;
				case 63:
					this.radErgoSecureTxSelectOnVoiceCommand = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ요滛爵\udba2슦얨캪캬\udbaeﺰ\uddb2\ud8b6킸\ud8ba\ud8bcﲾ껀껂꣄ꛆꟈ꿊", a_), global::CommonResources.AppResources.ID_STRING_RAD_ERGO_SECURE_TX_SELECT_ON_VCE_CMD, 35);
					this.radErgoSecureTxSelectOnVoiceCommand.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radErgoSecureTxSelectOnVoiceCommand.DataTransferOrder = 41;
					num = (short)1778384901;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 64:
					this.radErgoCfgVAWideOutOfRange = new global::AcpBusinessLayer.AcpRecRefField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ횔ﺘ춚\udc9c좞좠잢삤\udca8\udfaa즮튲\udbb4킶\udcb8", a_), global::CommonResources.AppResources.VC_OUT_OF_RANGE, new string[]
					{
						global::CommonResources.AppResources.None_Id,
						global::CommonResources.AppResources.TTS_Id
					}, new int[]
					{
						0,
						65535
					}, true, false);
					this.radErgoCfgVAWideOutOfRange.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radErgoCfgVAWideOutOfRange.DataTransferOrder = 18;
					num = (short)1859649564;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 65:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ횔ﺘ춚\udc9c좞좠잢삤龪鲬鮮袰蒲", a_)))
					{
						num = (short)731381885;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_7C2;
				case 66:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ\uda94풚ﮜ춞삠춢스슦얪쎬삮쒰\uddb2횴튶풸\udeba펼쮾韀곂계꓆곈裊ꋌꋎ볐닒믔돖", a_)))
					{
						num = (short)1787428874;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_26B0;
				case 67:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ횔ﺘ춚\udc9c좞좠잢삤첨잪쮬\ud9b0횲횴\udcb6ﾸ\udaba풼펾듀뇂ꃄ", a_)))
					{
						num = (short)1607532701;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2618;
				case 68:
					goto IL_2B30;
				case 69:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ횔ﺘ춚\udc9c좞좠잢삤좨\udfaa\ud9ac쪮쎰쪲슶풸캺톼\udebe뗀ꫂ도ꋆ蛈뷊꣌뷎藐뛒룔Ꟗ볘꧚볜ꯞ铠釢胤", a_)))
					{
						num = (short)674824302;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_598;
				case 70:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ요튜춢쮤좦\udca8얪캬쪮\udcb0횲\udbb4쎶풺풼\udcbe꓀胂꫄꫆꓈꫊ꏌꯎ", a_)))
					{
						num = (short)1586888752;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1DF4;
				case 71:
					num = (short)1518665782;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 72:
					this.radErgoKeyPadControlsLockOnVoiceCommand = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ\ude94쮚ﲜﮞ첢쮤펦\udba8쒪솬\udcaeﶰ\udcb2횴\udcb6햺킾ꣀꃂꃄ蓆ꛈꛊꃌ껎뿐럒", a_), global::CommonResources.AppResources.ID_STRING_RAD_ERGO_KEY_PAD_CTRL_LOCK_ON_VCE_CMD, 35);
					this.radErgoKeyPadControlsLockOnVoiceCommand.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radErgoKeyPadControlsLockOnVoiceCommand.DataTransferOrder = 43;
					num = (short)1533411360;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 73:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ횔ﺘ춚\udc9c좞좠잢삤龪鲬骮膰育", a_)))
					{
						num = (short)759693347;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_10FF;
				case 74:
					goto IL_26B0;
				case 75:
					goto IL_68E;
				case 76:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ횔ﺘ춚\udc9c좞좠잢삤龪鲬骮膰蚲", a_)))
					{
						num = (short)812580864;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_24C4;
				case 77:
					goto IL_1D0A;
				case 78:
					this.scanOffAnnouncementID_A22252 = new global::AcpBusinessLayer.AcpRecRefField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("풆삎풔練슠욢좤슦잨\udfaa螴薶许躺込", a_), global::CommonResources.AppResources.Scan_Off, new string[]
					{
						global::CommonResources.AppResources.None_Id,
						global::CommonResources.AppResources.TTS_Id
					}, new int[]
					{
						0,
						65535
					}, true, false);
					this.scanOffAnnouncementID_A22252.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.scanOffAnnouncementID_A22252.DataTransferOrder = 8;
					num = (short)1948254389;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 79:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ요ﶚ\ude9c쒠삢캤좨슪솬\udfb0\uddb2\udab4슶ힸ\ud8ba\ud8bc튾꓀귂뇄釆ꛈꋊ껌꫎鋐볒룔뫖룘뗚맜", a_)))
					{
						num = (short)377356378;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1DA4;
				case 80:
					goto IL_EBC;
				case 81:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ\udc94練\uda98漢킢삤햦잪좬\uddae얰ﲲ펴톶풺풼\udcbe꓀胂꫄꫆꓈꫊ꏌꯎ", a_)))
					{
						num = (short)1508769812;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_D50;
				case 82:
					goto IL_1CBC;
				case 83:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ\uda94ﲘ즜爵철펢삤햦좨\udfaa\ud8ac\uddae풰\udbb4\ud9b6횸캺펼\udcbe꓀껂ꃄ꧆뷈鷊ꋌꛎ닐뛒雔룖듘뛚볜뇞藠", a_)))
					{
						num = (short)1675493420;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2664;
				case 84:
					this.txInhibitOnAnnouncementID_A22260 = new global::AcpBusinessLayer.AcpRecRefField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("펆슊ﲔ횘\udc9c쾠첢키즦쪨캪사쪮\udfb0잲ﲴ諸込趾", a_), global::CommonResources.AppResources.Tx_Inhibit_On, new string[]
					{
						global::CommonResources.AppResources.None_Id,
						global::CommonResources.AppResources.TTS_Id
					}, new int[]
					{
						0,
						65535
					}, true, false);
					this.txInhibitOnAnnouncementID_A22260.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.txInhibitOnAnnouncementID_A22260.DataTransferOrder = 13;
					num = (short)1590493348;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 85:
					this.radErgoCfgVAWide_A41506 = new global::AcpBusinessLayer.AcpRecRefField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ횔ﺘ춚\udc9c좞좠잢삤龪鲬骮膰薲", a_), global::CommonResources.AppResources.Multi_Functional_Button_Secondary_Mode_ID, new string[]
					{
						global::CommonResources.AppResources.None_Id,
						global::CommonResources.AppResources.TTS_Id
					}, new int[]
					{
						0,
						65535
					}, true, false);
					this.radErgoCfgVAWide_A41506.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radErgoCfgVAWide_A41506.DataTransferOrder = 28;
					num = (short)2120482876;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 86:
					goto IL_2B7F;
				case 87:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ\ud894\ud99e풠춢톤캦욨얪첬쎮욲솴쎶횸햺\udabeꋀ곂ꯄꏆ꣈맊듌苎뻐럒냔铖뛘뛚냜뻞迠蟢", a_)))
					{
						num = (short)127139846;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1A15;
				case 88:
					goto IL_21E7;
				case 89:
					goto IL_1A15;
				case 90:
					this.radErgoSelfCheckFailAnnouncementVoiceCommand = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ요ﶚ\ude9c쒠삢캤좨슪솬\udfb0\uddb2\udab4슶ힸ\ud8ba\ud8bc튾꓀귂뇄釆ꛈꋊ껌꫎鋐볒룔뫖룘뗚맜", a_), global::CommonResources.AppResources.ID_STRING_RAD_ERGO_SELF_CHECK_FAILURE_VCE_CMD, 35);
					this.radErgoSelfCheckFailAnnouncementVoiceCommand.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radErgoSelfCheckFailAnnouncementVoiceCommand.DataTransferOrder = 49;
					num = (short)1156579373;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 91:
					this.radErgoInCallUserAlertOnVoiceCommand = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ\udc94練\uda98漢킢삤햦잪좬\uddae얰ﲲ\udbb4횸튺\udebc\udabe苀곂꣄꫆꣈ꗊ꧌", a_), global::CommonResources.AppResources.ID_STRING_RAD_ERGO_IN_CALL_USR_ALERT_ON_VCE_CMD, 35);
					this.radErgoInCallUserAlertOnVoiceCommand.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radErgoInCallUserAlertOnVoiceCommand.DataTransferOrder = 39;
					num = (short)1538457696;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 92:
					goto IL_1F85;
				case 93:
					goto IL_D50;
				case 94:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쪆ﮎﺐ\uda94ﾘ\uda9a캠횢쮤쒦첨욪좬솮얰者覺込趾", a_)))
					{
						num = (short)873857203;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1BCF;
				case 95:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ횔ﺘ춚\udc9c좞좠잢삤쪨좪좬\udcae슰\udcb2잴캶ﾸ\udaba풼펾듀뇂ꃄ", a_)))
					{
						num = (short)1049362536;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_6DC;
				case 96:
					goto IL_201C;
				case 97:
					goto IL_2C43;
				case 98:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ\ud894펠쮤욨슪캬쪮\udcb2\ud8b4\udab6\ud8b8햺\ud9bc", a_)))
					{
						num = (short)1225523219;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1CBC;
				case 99:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ\ud894\ud99e풠춢톤캦욨얪첬쎮욲솴쎶횸햺춾ꣀ껂꓄뗆냈蛊ꋌꯎ듐郒뫔뫖듘뫚돜믞", a_)))
					{
						num = (short)1169162380;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_23FC;
				case 100:
					this.txInhibitOffAnnouncementID_A22262 = new global::AcpBusinessLayer.AcpRecRefField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("펆슊ﲔ횘ﶚﮜ\ude9e쾠춢쪤튦잨좪좬슮풰\uddb2솴ﺶﶸﲼ趾", a_), global::CommonResources.AppResources.Tx_Inhibit_Off, new string[]
					{
						global::CommonResources.AppResources.None_Id,
						global::CommonResources.AppResources.TTS_Id
					}, new int[]
					{
						0,
						65535
					}, true, false);
					this.txInhibitOffAnnouncementID_A22262.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.txInhibitOffAnnouncementID_A22262.DataTransferOrder = 14;
					num = (short)1491206178;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 101:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ\uda94삠쾢좦쒨\udbaa슬솮풰\uddb2솴첸횺좼펾ꃀ럂계뇆곈蓊믌꫎ꏐ蟒냔뫖꧘뻚꿜뻞闠離韤苦꣨藪菬胮蓰鷲雴鋶铸黺鏼课圀氂氄搆氈䠊戌戎簐爒笔猖", a_)))
					{
						num = (short)1663828128;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_119A;
				case 102:
					goto IL_2664;
				case 103:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("풆ﲈﮊﶌﶎ얖ﲘﺞ\ud8a0ﲢ鎦鶨銪龬骮", a_)))
					{
						num = (short)1646723237;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1F38;
				case 104:
					this.radErgoCfgVAWideAccessoryFailure = new global::AcpBusinessLayer.AcpRecRefField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ횔ﺘ춚\udc9c좞좠잢삤쪨좪좬\udcae슰\udcb2잴캶ﾸ\udaba풼펾듀뇂ꃄ", a_), global::CommonResources.AppResources.ACCESSORY_FAILURE, new string[]
					{
						global::CommonResources.AppResources.None_Id,
						global::CommonResources.AppResources.TTS_Id
					}, new int[]
					{
						0,
						65535
					}, true, false);
					this.radErgoCfgVAWideAccessoryFailure.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radErgoCfgVAWideAccessoryFailure.DataTransferOrder = 17;
					num = (short)1921384505;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 105:
					goto IL_1748;
				case 106:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎆力\ude92杖ﲘ풚ﮜ咽춢쮤좦\udca8얪캬쪮\udcb0횲\udbb4쎶ﾺﺾ", a_)))
					{
						num = (short)1923612699;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_114C;
				case 107:
					goto IL_7C2;
				case 108:
					goto IL_3FA;
				case 109:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ횔ﺘ춚\udc9c좞좠잢삤龪鲬骮膰薲", a_)))
					{
						num = (short)331481173;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2A1A;
				case 110:
					this.radErgoCfgVAWideBatteryCumulativeOverTemperature = new global::AcpBusinessLayer.AcpRecRefField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ횔ﺘ춚\udc9c좞좠잢삤좨\udfaa\ud9ac쪮쎰쪲슶풸캺톼\udebe뗀ꫂ도ꋆ蛈뷊꣌뷎藐뛒룔Ꟗ볘꧚볜ꯞ铠釢胤", a_), global::CommonResources.AppResources.Power_Down_ID, new string[]
					{
						global::CommonResources.AppResources.None_Id,
						global::CommonResources.AppResources.TTS_Id
					}, new int[]
					{
						0,
						65535
					}, true, false);
					this.radErgoCfgVAWideBatteryCumulativeOverTemperature.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radErgoCfgVAWideBatteryCumulativeOverTemperature.DataTransferOrder = 58;
					num = (short)1555824677;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 111:
					goto IL_23AE;
				case 112:
					this.radErgoCfgVAWideRFDeviceCumulativeOverTemperature = new global::AcpBusinessLayer.AcpRecRefField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ횔ﺘ춚\udc9c좞좠잢삤좬\ud9ae\ud8b0킲킴첸횺좼펾ꃀ럂계뇆곈蓊믌꫎ꏐ蟒냔뫖꧘뻚꿜뻞闠離韤苦", a_), global::CommonResources.AppResources.Power_Down_ID, new string[]
					{
						global::CommonResources.AppResources.None_Id,
						global::CommonResources.AppResources.TTS_Id
					}, new int[]
					{
						0,
						65535
					}, true, false);
					this.radErgoCfgVAWideRFDeviceCumulativeOverTemperature.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radErgoCfgVAWideRFDeviceCumulativeOverTemperature.DataTransferOrder = 55;
					num = (short)1187512435;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 113:
					this.monitorOnAnnouncementID_A22254 = new global::AcpBusinessLayer.AcpRecRefField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쪆ﮎﺐ\uda94練\ud898풠춢욤슦쒨캪쎬\udbae许覺込誾", a_), global::CommonResources.AppResources.Monitor_On, new string[]
					{
						global::CommonResources.AppResources.None_Id,
						global::CommonResources.AppResources.TTS_Id
					}, new int[]
					{
						0,
						65535
					}, true, false);
					this.monitorOnAnnouncementID_A22254.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.monitorOnAnnouncementID_A22254.DataTransferOrder = 9;
					num = (short)1519386632;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 114:
					goto IL_23FC;
				case 115:
					goto IL_2AE0;
				case 116:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ횔ﺘ춚\udc9c좞좠잢삤잨\udfaa좬솮\udfb0튲횶킸ힺ좼춾꓀", a_)))
					{
						num = (short)560660611;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1429;
				case 117:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ횔ﺘ춚\udc9c좞좠잢삤龪鲬鮮袰課", a_)))
					{
						num = (short)117309501;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3FA;
				case 118:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ횔ﺘ춚\udc9c좞좠잢삤욨얪ﲰ횴풶\udcb8좺캼킾돀뫂", a_)))
					{
						num = (short)44367890;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_21E7;
				case 119:
					this.radErgoWrongBatteryVoiceCommand = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ슔煮\udd9e삠힢톤슦\udba8튪ﮬ삮\ud8b0킲킴횸횺킼\udebe꿀Ꟃ", a_), global::CommonResources.AppResources.ID_STRING_RAD_ERGO_WRONG_BATTERY_VCE_CMD, 35);
					this.radErgoWrongBatteryVoiceCommand.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radErgoWrongBatteryVoiceCommand.DataTransferOrder = 47;
					num = (short)743571548;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 120:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ횔ﺘ춚\udc9c좞좠잢삤龪鲬骮膰芲", a_)))
					{
						num = (short)1452343332;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_641;
				case 121:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎆力\ude92杖ﲘ풚\ude9e쾠춢쪤튦잨좪좬슮풰\uddb2솴ﺶﶸﲼ趾ￆ", a_)))
					{
						num = (short)96141498;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1C6F;
				case 122:
					goto IL_10FF;
				case 123:
					goto IL_1C6F;
				case 124:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("톆킐ﶒﮔﺜ爵철욢쮤펦令\ud9aa쒬삮쎰\udab2솴캶諸誼覾", a_)))
					{
						num = (short)1334509702;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_DC6;
				case 125:
					this.radErgoCfgVAWide_A41497 = new global::AcpBusinessLayer.AcpRecRefField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ횔ﺘ춚\udc9c좞좠잢삤龪鲬鮮袰蒲", a_), global::CommonResources.AppResources.ICUA_On_ID, new string[]
					{
						global::CommonResources.AppResources.None_Id,
						global::CommonResources.AppResources.TTS_Id
					}, new int[]
					{
						0,
						65535
					}, true, false);
					this.radErgoCfgVAWide_A41497.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radErgoCfgVAWide_A41497.DataTransferOrder = 20;
					num = (short)157155435;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 126:
					goto IL_BC0;
				case 127:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ횔ﺘ춚\udc9c좞좠잢삤\udfa8캪\udfacﮮ풰\udeb2어튶쮸\udaba즼쪾돀ꛂ", a_)))
					{
						num = (short)1758396546;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2FCC;
				case 128:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ\udb94펚잜튞삢욤슦\udaa8\ud8aa슬\uddae좰\udbb4\ud9b6횸캺펼\udcbe꓀껂ꃄ꧆뷈鷊ꋌꛎ닐뛒雔룖듘뛚볜뇞藠", a_)))
					{
						num = (short)1179516977;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2758;
				case 129:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ잔\udd98ﺚ슠욢튦쒨\udeaa솬캮얰\udab2쎴튶춺\ud8bc춾闀ꛂ꣄럆곈맊곌믎ꓐꇒ냔雖럘뗚닜꫞迠胢胤諦賨藪駬맮黰髲雴鋶뫸铺郼鋾怀洂愄", a_)))
					{
						num = (short)899743802;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_23AE;
				case 130:
					this.radErgoCfgVAWideOverTemperature = new global::AcpBusinessLayer.AcpRecRefField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ횔ﺘ춚\udc9c좞좠잢삤\udfa8캪\udfacﮮ풰\udeb2어튶쮸\udaba즼쪾돀ꛂ", a_), global::CommonResources.AppResources.OVER_TEMPERATURE, new string[]
					{
						global::CommonResources.AppResources.None_Id,
						global::CommonResources.AppResources.TTS_Id
					}, new int[]
					{
						0,
						65535
					}, true, false);
					this.radErgoCfgVAWideOverTemperature.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radErgoCfgVAWideOverTemperature.DataTransferOrder = 19;
					num = (short)2056454241;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 131:
					this.radErgoCfgVAWideAntennaFailure = new global::AcpBusinessLayer.AcpRecRefField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ횔ﺘ춚\udc9c좞좠잢삤잨\udfaa좬솮\udfb0튲횶킸ힺ좼춾꓀", a_), global::CommonResources.AppResources.Antenna_Failure_ID, new string[]
					{
						global::CommonResources.AppResources.None_Id,
						global::CommonResources.AppResources.TTS_Id
					}, new int[]
					{
						0,
						65535
					}, true, false);
					this.radErgoCfgVAWideAntennaFailure.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radErgoCfgVAWideAntennaFailure.DataTransferOrder = 54;
					num = (short)375324816;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 132:
					this.radErgoTxInhibitOffVoiceCommand = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ솔킘쎠쪢톤쾨춪ﮬ삮\ud8b0킲킴횸횺킼\udebe꿀Ꟃ", a_), global::CommonResources.AppResources.ID_STRING_RAD_ERGO_TX_INHIBIT_OFF_VCE_CMD, 35);
					this.radErgoTxInhibitOffVoiceCommand.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radErgoTxInhibitOffVoiceCommand.DataTransferOrder = 37;
					num = (short)1553858737;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 133:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ횔ﺘ춚\udc9c좞좠잢삤욨\udcaa좬\uddae\udcb2슴\ud9b6", a_)))
					{
						num = (short)1878327474;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_BC0;
				case 134:
					this.voiceAnnouncementPriority_A7651 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::SpecialFeatures.VoiceAnnouncements.Wide.LOVs.indexVoiceAnnouncementPriority_A76515LovStrs, global::SpecialFeatures.VoiceAnnouncements.Wide.LOVs.idVoiceAnnouncementPriority_A76515LovStrs), this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("톆킐ﶒﮔﺜ爵철욢쮤펦令\ud9aa쒬삮쎰\udab2솴캶諸誼覾", a_), global::CommonResources.AppResources.Voice_Announcement_Priority, global::SpecialFeatures.VoiceAnnouncements.Wide.LOVs.VoiceAnnouncementPriority_A76515LovStrs);
					this.voiceAnnouncementPriority_A7651.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.voiceAnnouncementPriority_A7651.DataTransferOrder = 6;
					num = (short)1888878609;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 135:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ횔ﺘ춚\udc9c좞좠잢삤龪鲬骮膰膲", a_)))
					{
						num = (short)1988952248;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_D02;
				case 136:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ횔ﺘ춚\udc9c좞좠잢삤\udca8\udfaa즮튲\udbb4킶\udcb8", a_)))
					{
						num = (short)1300234304;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2972;
				case 137:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ솔킘쎠쪢톤쾨춪ﮬ삮\ud8b0킲킴횸횺킼\udebe꿀Ꟃ", a_)))
					{
						num = (short)111149188;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2068;
				case 138:
					this.siteSelectableAlertAllowedinOutofRange_A42013 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("풆ﾊ\udc8eﾒ漢ﾜ쒠즤슦\udba8\udfaa쎮\uddb0\udcb2슴튶\uddb8튺펼듀럂꫄ꇆ鯈꫊ꏌ꣎듐賒铔", a_), global::CommonResources.AppResources.ID_SSA_ALLOWED_OUT_OF_RANGE);
					this.siteSelectableAlertAllowedinOutofRange_A42013.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.siteSelectableAlertAllowedinOutofRange_A42013.DataTransferOrder = 5;
					num = (short)874053684;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 139:
					this.radErgoSecureTxSelectOffVoiceCommand = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ요滛爵\udba2슦얨캪캬\udbaeﺰ햲펴횸튺\udebc\udabe苀곂꣄꫆꣈ꗊ꧌", a_), global::CommonResources.AppResources.ID_STRING_RAD_ERGO_SECURE_TX_SELECT_OFF_VCE_CMD, 35);
					this.radErgoSecureTxSelectOffVoiceCommand.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radErgoSecureTxSelectOffVoiceCommand.DataTransferOrder = 42;
					num = (short)1812922430;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 140:
					this.radErgoMultiFuntionalButtonPrimaryModeCommand = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ\ud894\ud99e풠춢톤캦욨얪첬쎮욲솴쎶횸햺춾ꣀ껂꓄뗆냈蛊ꋌꯎ듐郒뫔뫖듘뫚돜믞", a_), global::CommonResources.AppResources.ID_STRING_RAD_ERGO_MULT_FUNC_BTN_PRIMARY_MODE_CMD, 35);
					this.radErgoMultiFuntionalButtonPrimaryModeCommand.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radErgoMultiFuntionalButtonPrimaryModeCommand.DataTransferOrder = 45;
					num = (short)1059782770;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 141:
					this.radErgoAccessoryFailureAnnouncementVoiceCommand = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ풔滛ﺚ캠톢\udca4좨슪솬\udaae쎰횲\ud9b6ힸ풺좼톾ꋀꛂ꣄ꋆꟈ뿊鯌ꃎ룐냒냔铖뛘뛚냜뻞迠蟢", a_), global::CommonResources.AppResources.ID_STRING_RAD_ERGO_ACCESSORY_FAILURE_VCE_CMD, 35);
					this.radErgoAccessoryFailureAnnouncementVoiceCommand.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radErgoAccessoryFailureAnnouncementVoiceCommand.DataTransferOrder = 50;
					num = (short)951713935;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 142:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ풔練ﺚ삠쒤캦얨\udeaa\udfac쪮\uddb2\udbb4\ud8b6첸햺\udebc\udabe곀ꛂꯄ돆鿈꓊꓌곎듐郒뫔뫖듘뫚돜믞", a_)))
					{
						num = (short)2109538345;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1D0A;
				case 143:
					goto IL_2236;
				case 144:
					goto IL_1429;
				case 145:
					this.radErgoCfgVAWide_A41500 = new global::AcpBusinessLayer.AcpRecRefField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ횔ﺘ춚\udc9c좞좠잢삤龪鲬骮膰莲", a_), global::CommonResources.AppResources.Emergency_On_ID, new string[]
					{
						global::CommonResources.AppResources.None_Id,
						global::CommonResources.AppResources.TTS_Id
					}, new int[]
					{
						0,
						65535
					}, true, false);
					this.radErgoCfgVAWide_A41500.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radErgoCfgVAWide_A41500.DataTransferOrder = 22;
					num = (short)2125987991;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 146:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ횔ﺘ춚\udc9c좞좠잢삤龪鲬骮膰莲", a_)))
					{
						num = (short)567017617;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1B09;
				case 147:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ요滛爵\udba2슦얨캪캬\udbaeﺰ햲펴횸튺\udebc\udabe苀곂꣄꫆꣈ꗊ꧌", a_)))
					{
						num = (short)2070675595;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1624;
				case 148:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쪆ﮎﺐ\uda94練\ud898풠춢욤슦쒨캪쎬\udbae许覺込誾", a_)))
					{
						num = (short)2093678705;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2CEF;
				case 149:
					goto IL_E13;
				case 150:
					goto IL_1DF4;
				case 151:
					goto IL_1B09;
				case 152:
					this.wrongBatteryOnAnnouncementID_43251 = new global::AcpBusinessLayer.AcpRecRefField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("킆ﮈ펐ﲘ킞쾠쮤즦욨\udeaa쎬첮풰\udeb2킴\ud9b6춸寮", a_), global::CommonResources.AppResources.Wrong_Battery_ID, new string[]
					{
						global::CommonResources.AppResources.None_Id,
						global::CommonResources.AppResources.TTS_Id
					}, new int[]
					{
						0,
						65535
					}, true, false);
					this.wrongBatteryOnAnnouncementID_43251.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.wrongBatteryOnAnnouncementID_43251.DataTransferOrder = 29;
					num = (short)1616969787;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 153:
					goto IL_641;
				case 154:
					goto IL_1D59;
				case 155:
					num = (short)313917564;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 156:
					this.radErgoDirectModeOnVoiceCommand = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ톔ﺖﺚﺜ첢솤슦얪ﮬ삮\ud8b0킲킴횸횺킼\udebe꿀Ꟃ", a_), global::CommonResources.AppResources.ID_STRING_RAD_ERGO_DRCT_MODE_ON_VCE_CMD, 35);
					this.radErgoDirectModeOnVoiceCommand.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radErgoDirectModeOnVoiceCommand.DataTransferOrder = 34;
					num = (short)258867286;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 157:
					this.radErgoCfgVAWideSelfCheckFailure = new global::AcpBusinessLayer.AcpRecRefField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ횔ﺘ춚\udc9c좞좠잢삤첨잪쮬\ud9b0횲횴\udcb6ﾸ\udaba풼펾듀뇂ꃄ", a_), global::CommonResources.AppResources.SELF_CHECK_FAILURE, new string[]
					{
						global::CommonResources.AppResources.None_Id,
						global::CommonResources.AppResources.TTS_Id
					}, new int[]
					{
						0,
						65535
					}, true, false);
					this.radErgoCfgVAWideSelfCheckFailure.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radErgoCfgVAWideSelfCheckFailure.DataTransferOrder = 16;
					num = (short)1569259535;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 158:
					goto IL_114C;
				case 159:
					this.radErgoTxInhibitOnVoiceCommand = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ솔킘쎠쪢톤잨ﶪ슬욮튰횲\ud8b6풸횺\udcbc톾ꗀ", a_), global::CommonResources.AppResources.ID_STRING_RAD_ERGO_TX_INHIBIT_ON_VCE_CMD, 35);
					this.radErgoTxInhibitOnVoiceCommand.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radErgoTxInhibitOnVoiceCommand.DataTransferOrder = 36;
					num = (short)1969815577;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 160:
					this.radErgoOptionalComponentCumulativeOverTemperatureAnnouncementVoiceCommand = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ\uda94삠쾢좦쒨\udbaa슬솮풰\uddb2솴첸횺좼펾ꃀ럂계뇆곈蓊믌꫎ꏐ蟒냔뫖꧘뻚꿜뻞闠離韤苦꣨藪菬胮蓰鷲雴鋶铸黺鏼课圀氂氄搆氈䠊戌戎簐爒笔猖", a_), global::CommonResources.AppResources.ID_STRING_RAD_ERGO_OPTIONAL_CUMULATIVE_OVER_TEMPERATURE_VCE_CMD, 35);
					this.radErgoOptionalComponentCumulativeOverTemperatureAnnouncementVoiceCommand.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radErgoOptionalComponentCumulativeOverTemperatureAnnouncementVoiceCommand.DataTransferOrder = 62;
					num = (short)1774649387;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 161:
					this.radErgoCfgVAWideOptionalComponentCumulativeOverTemperature = new global::AcpBusinessLayer.AcpRecRefField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ횔ﺘ춚\udc9c좞좠잢삤\ud9a8\udfaa쒬삮\udfb0튲\ud9b4횸횺춼킾꿀ꛂꯄ돆諈뻊ꃌ뫎뷐닒ꇔ뻖꿘뻚鋜꧞蓠釢뇤苦蓨鯪裬鷮郰蟲胴藶鳸", a_), global::CommonResources.AppResources.Power_Down_ID, new string[]
					{
						global::CommonResources.AppResources.None_Id,
						global::CommonResources.AppResources.TTS_Id
					}, new int[]
					{
						0,
						65535
					}, true, false);
					this.radErgoCfgVAWideOptionalComponentCumulativeOverTemperature.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radErgoCfgVAWideOptionalComponentCumulativeOverTemperature.DataTransferOrder = 56;
					num = (short)1841692747;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 162:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ\ude94쮚ﲜﮞ첢쮤펦\udba8쒪솬\udcaeﶰ\udcb2횴\udcb6햺킾ꣀꃂꃄ蓆ꛈꛊꃌ껎뿐럒", a_)))
					{
						num = (short)274268232;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1ABC;
				case 163:
					this.radErgoScanOffAnnouncementVoiceCommand = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ요튜咽잠쮤즦욨\udeaa쎬첮풰\udeb2킴\ud9b6춸튼횾ꋀꛂ蛄꣆꓈ꛊ곌ꇎ뗐", a_), global::CommonResources.AppResources.ID_STRING_RAD_ERGO_SCAN_OFF_ANCMNT_VCE_CMD, 35);
					this.radErgoScanOffAnnouncementVoiceCommand.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radErgoScanOffAnnouncementVoiceCommand.DataTransferOrder = 31;
					num = (short)897974281;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 164:
					goto IL_810;
				case 165:
					this.suppressReplay_A44925 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("풆ﲈﮊﶌﶎ얖ﲘﺞ\ud8a0ﲢ鎦鶨銪龬骮", a_), global::CommonResources.AppResources.Suppress_Replay);
					this.suppressReplay_A44925.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.suppressReplay_A44925.DataTransferOrder = 65;
					num = (short)1907294215;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 166:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ풔滛ﺚ캠톢\udca4좨슪솬\udaae쎰횲\ud9b6ힸ풺좼톾ꋀꛂ꣄ꋆꟈ뿊鯌ꃎ룐냒냔铖뛘뛚냜뻞迠蟢", a_)))
					{
						num = (short)38666381;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2236;
				case 167:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ요튜咽잠쮤즦욨\udeaa쎬첮풰\udeb2킴\ud9b6춸튼횾ꋀꛂ蛄꣆꓈ꛊ곌ꇎ뗐", a_)))
					{
						num = (short)174588067;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_F09;
				case 168:
					this.radErgoCfgVAWide_A41504 = new global::AcpBusinessLayer.AcpRecRefField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ횔ﺘ춚\udc9c좞좠잢삤龪鲬骮膰螲", a_), global::CommonResources.AppResources.Keypad_Controls_Lock_Off_ID, new string[]
					{
						global::CommonResources.AppResources.None_Id,
						global::CommonResources.AppResources.TTS_Id
					}, new int[]
					{
						0,
						65535
					}, true, false);
					this.radErgoCfgVAWide_A41504.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radErgoCfgVAWide_A41504.DataTransferOrder = 26;
					num = (short)762118212;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 169:
					goto IL_2F06;
				case 170:
					goto IL_955;
				case 171:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ\ud894펠쎤솦ﾨ쒪쒬첮풰\udab4\udab6풸\udaba펼\udbbe", a_)))
					{
						num = (short)1202061345;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A22;
				case 172:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ횔ﺘ춚\udc9c좞좠잢삤좬\ud9ae\ud8b0킲킴첸횺좼펾ꃀ럂계뇆곈蓊믌꫎ꏐ蟒냔뫖꧘뻚꿜뻞闠離韤苦", a_)))
					{
						num = (short)1126891632;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2AE0;
				case 173:
					goto IL_2758;
				case 174:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("킆ﮈ펐ﲘ킞쾠쮤즦욨\udeaa쎬첮풰\udeb2킴\ud9b6춸寮", a_)))
					{
						num = (short)379453592;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2512;
				case 175:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ킔햜ﺞ\udba0슢힤쎦쒪쎬쪮ﲰ\udcb2톴튶햺펼킾듀귂ꛄꋆ꓈껊ꏌ믎蟐볒볔듖볘飚닜닞賠苢诤菦", a_)))
					{
						num = (short)1657798702;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_EBC;
				case 176:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ횔ﺘ춚\udc9c좞좠잢삤\ud9a8\udfaa쒬삮\udfb0튲\ud9b4횸횺춼킾꿀ꛂꯄ돆諈뻊ꃌ뫎뷐닒ꇔ뻖꿘뻚鋜꧞蓠釢뇤苦蓨鯪裬鷮郰蟲胴藶鳸", a_)))
					{
						num = (short)1695940769;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_68E;
				case 177:
					goto IL_2068;
				case 178:
					this.radErgoCfgVAWidePowerDown = new global::AcpBusinessLayer.AcpRecRefField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ횔ﺘ춚\udc9c좞좠잢삤욨\udcaa좬\uddae\udcb2슴\ud9b6", a_), global::CommonResources.AppResources.Power_Down_ID, new string[]
					{
						global::CommonResources.AppResources.None_Id,
						global::CommonResources.AppResources.TTS_Id
					}, new int[]
					{
						0,
						65535
					}, true, false);
					this.radErgoCfgVAWidePowerDown.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radErgoCfgVAWidePowerDown.DataTransferOrder = 53;
					num = (short)230293630;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 179:
					this.monitorOffAnnouncementID_A22256 = new global::AcpBusinessLayer.AcpRecRefField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쪆ﮎﺐ\uda94ﾘ\uda9a캠횢쮤쒦첨욪좬솮얰者覺込趾", a_), global::CommonResources.AppResources.Monitor_Off, new string[]
					{
						global::CommonResources.AppResources.None_Id,
						global::CommonResources.AppResources.TTS_Id
					}, new int[]
					{
						0,
						65535
					}, true, false);
					this.monitorOffAnnouncementID_A22256.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.monitorOffAnnouncementID_A22256.DataTransferOrder = 10;
					num = (short)940441601;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 180:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("풆ﾊ\udc8eﾒ漢ﾜ쒠즤슦\udba8\udfaa쎮\uddb0\udcb2슴튶\uddb8튺펼듀럂꫄ꇆ鯈꫊ꏌ꣎듐賒铔", a_)))
					{
						num = (short)1480065162;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_10B3;
				case 181:
					goto IL_11E7;
				case 182:
				{
					num = (short)377815040;
					short num4 = num;
					goto IL_A22;
				}
				case 183:
					this.radErgoEmergencyOnVoiceCommand = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ킔殺ﲘ煮爵쾠삢\udca4잨ﶪ슬욮튰횲\ud8b6풸횺\udcbc톾ꗀ", a_), global::CommonResources.AppResources.ID_STRING_RAD_ERGO_EMERGENCY_ON_VCE_CMD, 35);
					this.radErgoEmergencyOnVoiceCommand.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radErgoEmergencyOnVoiceCommand.DataTransferOrder = 38;
					num = (short)469500053;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 184:
					this.radErgoCfgVAWide_A41502 = new global::AcpBusinessLayer.AcpRecRefField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햆좌ﶎﲒ횔ﺘ춚\udc9c좞좠잢삤龪鲬骮膰膲", a_), global::CommonResources.AppResources.Secure_Tx_Select_Off_ID, new string[]
					{
						global::CommonResources.AppResources.None_Id,
						global::CommonResources.AppResources.TTS_Id
					}, new int[]
					{
						0,
						65535
					}, true, false);
					this.radErgoCfgVAWide_A41502.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radErgoCfgVAWide_A41502.DataTransferOrder = 24;
					num = (short)549584909;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 185:
					goto IL_24C4;
				case 186:
					this.directModeOnAnnouncementID_A22258 = new global::AcpBusinessLayer.AcpRecRefField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎆力\ude92杖ﲘ풚\ude9e쾠춢쪤튦잨좪좬슮풰\uddb2솴ﺶﶸﲼ趾ￆ", a_), global::CommonResources.AppResources.Direct_Mode_On, new string[]
					{
						global::CommonResources.AppResources.None_Id,
						global::CommonResources.AppResources.TTS_Id
					}, new int[]
					{
						0,
						65535
					}, true, false);
					this.directModeOnAnnouncementID_A22258.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.directModeOnAnnouncementID_A22258.DataTransferOrder = 11;
					num = (short)41549947;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_31A:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)751829063;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_3FA:
				num = (short)537329810;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_598:
				num = (short)1189085364;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_641:
				num = (short)1498349703;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_68E:
				num = (short)1202913398;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_6DC:
				num = (short)351928456;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_7C2:
				num = (short)1626079349;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_810:
				num = (short)1311703043;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_955:
				num = (short)50397312;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_A22:
				num = (short)1972633656;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_BC0:
				num = (short)1941373044;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_D02:
				num = (short)611450953;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_D50:
				num = (short)1959591937;
				if (num != 0)
				{
				}
				num = (short)2115633194;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_DC6:
				num = (short)782631015;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_E13:
				num = (short)1200291887;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_EBC:
				num = (short)247201921;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_F09:
				num = (short)1002111074;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_10B3:
				num = (short)375783477;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_10FF:
				num = (short)91881510;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_114C:
				num = (short)1241645106;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_119A:
				num = (short)1466630165;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_11E7:
				num = (short)1260781716;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1235:
				num = (short)146407489;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1429:
				num = (short)641532076;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1624:
				num = (short)319553698;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1748:
				num = (short)1286537315;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1795:
				num = (short)1975451672;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_183B:
				num = (short)2047344777;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1A15:
				num = (short)1401487371;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1ABC:
				num = (short)1771372595;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1B09:
				num = (short)387317880;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1BCF:
				num = (short)81002617;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1C6F:
				num = (short)1489961066;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1CBC:
				num = (short)707002539;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1D0A:
				num = (short)906756179;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1D59:
				num = (short)294912142;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1DA4:
				num = (short)979304614;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2613:
				goto IL_1DA4;
				IL_1DF4:
				num = (short)1656684711;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1E40:
				num = (short)1342374035;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1F38:
				num = (short)1522532375;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1F85:
				num = (short)366542914;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_201C:
				num = (short)668598353;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2068:
				num = (short)1402535950;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_21E7:
				num = (short)1877344325;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2236:
				num = (short)1151008772;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_23AE:
				num = (short)1743716453;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_23FC:
				num = (short)1058406487;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_24C4:
				num = (short)865730669;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2512:
				num = (short)1345716294;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2618:
				num = (short)666566751;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2664:
				num = (short)643694767;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_26B0:
				num = (short)1640824911;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2758:
				num = (short)1021247621;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2972:
				num = (short)1914044543;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2A1A:
				num = (short)1326514350;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2AE0:
				num = (short)887423152;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2B30:
				num = (short)1016528972;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2B7F:
				num = (short)617480221;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2CA3:
				num = (short)1517027340;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2CEF:
				num = (short)1219887198;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2F06:
				num = (short)2008547395;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_2C43:
			IL_2FCC:
			base.FeatureSectionName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삆ﶎﾒ", a_);
			base.Id = 10501;
			base.UIName = global::CommonResources.AppResources.General_Id;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00015038 File Offset: 0x00013238
		public override void PopulateReferences()
		{
			short num = (short)1979383812;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Collections.Generic.List<global::AcpBusinessLayer.AcpRecRefField>.Enumerator enumerator;
				switch (num2)
				{
				case 0:
					goto IL_177;
				case 1:
					num = (short)9568259;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					try
					{
						num = (short)738394116;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_164;
							case 1:
							{
								num = (short)2103794204;
								short num3 = num;
								num = (short)1613584924;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									continue;
								default:
									num = (short)284884992;
									if (num != 0)
									{
									}
									break;
								}
								break;
							}
							case 2:
								if (!enumerator.MoveNext())
								{
									num = (short)191168515;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								enumerator.Current.SetRecset(this.a(2300));
								num = (short)597229569;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								num = (short)1624965120;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
								switch (0)
								{
								case 0:
									goto IL_97;
								}
								continue;
							}
							IL_110:
							num = (short)566427650;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_97:
							goto IL_110;
						}
						IL_164:
						return;
					}
					finally
					{
						((global::System.IDisposable)enumerator).Dispose();
					}
					goto IL_177;
				case 3:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num = (short)1955987456;
						short num4 = num;
						num = (short)521666561;
						if (num != 0)
						{
						}
						num = (short)1390477312;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_3A;
					}
					continue;
				}
				IL_3A:
				if (base.ParentRecset != null)
				{
					num = (short)263258113;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_177:
				enumerator = new global::System.Collections.Generic.List<global::AcpBusinessLayer.AcpRecRefField>
				{
					this.scanOnAnnouncementID_A22250,
					this.scanOffAnnouncementID_A22252,
					this.monitorOnAnnouncementID_A22254,
					this.monitorOffAnnouncementID_A22256,
					this.directModeOnAnnouncementID_A22258,
					this.directModeOffAnnouncementID_A22121,
					this.txInhibitOnAnnouncementID_A22260,
					this.txInhibitOffAnnouncementID_A22262,
					this.radErgoCfgVAWide_A41497,
					this.radErgoCfgVAWide_A41499,
					this.radErgoCfgVAWide_A41500,
					this.radErgoCfgVAWide_A41501,
					this.radErgoCfgVAWide_A41502,
					this.radErgoCfgVAWide_A41503,
					this.radErgoCfgVAWide_A41504,
					this.radErgoCfgVAWide_A41505,
					this.radErgoCfgVAWide_A41506,
					this.wrongBatteryOnAnnouncementID_43251,
					this.radErgoCfgVAWideExitHazardZoneMode,
					this.radErgoCfgVAWideSelfCheckFailure,
					this.radErgoCfgVAWideAccessoryFailure,
					this.radErgoCfgVAWideOutOfRange,
					this.radErgoCfgVAWideOverTemperature,
					this.radErgoCfgVAWidePowerDown,
					this.radErgoCfgVAWideAntennaFailure,
					this.radErgoCfgVAWideRFDeviceCumulativeOverTemperature,
					this.radErgoCfgVAWideOptionalComponentCumulativeOverTemperature,
					this.radErgoCfgVAWideNonHZMAccessory,
					this.radErgoCfgVAWideBatteryCumulativeOverTemperature
				}.GetEnumerator();
				num = (short)1253703682;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06000097 RID: 151 RVA: 0x000153F0 File Offset: 0x000135F0
		public override void DropReferences()
		{
			short num = (short)1507836425;
			short num2 = num;
			num = (short)1000981001;
			switch (num2 == num)
			{
			}
			num = (short)647954433;
			if (num != 0)
			{
			}
			num = (short)780861440;
			if (num != 0)
			{
			}
			num = (short)1845952512;
			short num3 = num;
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00015498 File Offset: 0x00013698
		public override void SetConstraints()
		{
			short num = (short)1410990081;
			if (num != 0)
			{
			}
			num = (short)718547174;
			short num2 = num;
			num = (short)1816013030;
			switch (num2 == num)
			{
			}
			num = (short)1513684992;
			if (num != 0)
			{
			}
			num = (short)967507968;
			short num3 = num;
			this.scanOnAnnouncementID_A22250.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.ConIsVARecRefSelectionValid);
			this.scanOffAnnouncementID_A22252.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.ConIsVARecRefSelectionValid);
			this.monitorOnAnnouncementID_A22254.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.ConIsVARecRefSelectionValid);
			this.monitorOffAnnouncementID_A22256.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.ConIsVARecRefSelectionValid);
			this.directModeOnAnnouncementID_A22258.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.ConIsVARecRefSelectionValid);
			this.directModeOffAnnouncementID_A22121.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.ConIsVARecRefSelectionValid);
			this.txInhibitOnAnnouncementID_A22260.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.ConIsVARecRefSelectionValid);
			this.txInhibitOffAnnouncementID_A22262.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.ConIsVARecRefSelectionValid);
			this.radErgoCfgVAWide_A41497.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.ConIsVARecRefSelectionValid);
			this.radErgoCfgVAWide_A41499.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.ConIsVARecRefSelectionValid);
			this.radErgoCfgVAWide_A41500.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.ConIsVARecRefSelectionValid);
			this.radErgoCfgVAWide_A41501.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.ConIsVARecRefSelectionValid);
			this.radErgoCfgVAWide_A41502.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.ConIsVARecRefSelectionValid);
			this.radErgoCfgVAWide_A41503.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.ConIsVARecRefSelectionValid);
			this.radErgoCfgVAWide_A41504.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.ConIsVARecRefSelectionValid);
			this.radErgoCfgVAWide_A41505.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.ConIsVARecRefSelectionValid);
			this.radErgoCfgVAWide_A41506.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.ConIsVARecRefSelectionValid);
			this.radErgoCfgVAWidePowerDown.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.ConIsVARecRefSelectionValid);
			this.radErgoCfgVAWideAntennaFailure.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.ConIsVARecRefSelectionValid);
			this.radErgoCfgVAWideRFDeviceCumulativeOverTemperature.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.ConIsVARecRefSelectionValid);
			this.radErgoCfgVAWideOptionalComponentCumulativeOverTemperature.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.ConIsVARecRefSelectionValid);
			this.radErgoCfgVAWideNonHZMAccessory.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.ConIsVARecRefSelectionValid);
			this.radErgoCfgVAWideBatteryCumulativeOverTemperature.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.ConIsVARecRefSelectionValid);
			this.wrongBatteryOnAnnouncementID_43251.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.ConIsVARecRefSelectionValid);
			this.radErgoScanOnAnnouncementVoiceCommand.IsApplicable = new global::AcpCommonLib.StateConstraint(global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.ConSetVoiceCommandFieldInapplicableIfVoiceAnnouncementIsNotTTS);
			this.radErgoScanOffAnnouncementVoiceCommand.IsApplicable = new global::AcpCommonLib.StateConstraint(global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.ConSetVoiceCommandFieldInapplicableIfVoiceAnnouncementIsNotTTS);
			this.radErgoMonitorOnVoiceCommand.IsApplicable = new global::AcpCommonLib.StateConstraint(global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.ConSetVoiceCommandFieldInapplicableIfVoiceAnnouncementIsNotTTS);
			this.radErgoMonitorOffVoiceCommand.IsApplicable = new global::AcpCommonLib.StateConstraint(global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.ConSetVoiceCommandFieldInapplicableIfVoiceAnnouncementIsNotTTS);
			this.radErgoDirectModeOnVoiceCommand.IsApplicable = new global::AcpCommonLib.StateConstraint(global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.ConSetVoiceCommandFieldInapplicableIfVoiceAnnouncementIsNotTTS);
			this.radErgoDirectModeOffVoiceCommand.IsApplicable = new global::AcpCommonLib.StateConstraint(global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.ConSetVoiceCommandFieldInapplicableIfVoiceAnnouncementIsNotTTS);
			this.radErgoTxInhibitOnVoiceCommand.IsApplicable = new global::AcpCommonLib.StateConstraint(global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.ConSetVoiceCommandFieldInapplicableIfVoiceAnnouncementIsNotTTS);
			this.radErgoTxInhibitOffVoiceCommand.IsApplicable = new global::AcpCommonLib.StateConstraint(global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.ConSetVoiceCommandFieldInapplicableIfVoiceAnnouncementIsNotTTS);
			this.radErgoInCallUserAlertOnVoiceCommand.IsApplicable = new global::AcpCommonLib.StateConstraint(global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.ConSetVoiceCommandFieldInapplicableIfVoiceAnnouncementIsNotTTS);
			this.radErgoInCallUserAlertOffVoiceCommand.IsApplicable = new global::AcpCommonLib.StateConstraint(global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.ConSetVoiceCommandFieldInapplicableIfVoiceAnnouncementIsNotTTS);
			this.radErgoEmergencyOnVoiceCommand.IsApplicable = new global::AcpCommonLib.StateConstraint(global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.ConSetVoiceCommandFieldInapplicableIfVoiceAnnouncementIsNotTTS);
			this.radErgoSecureTxSelectOnVoiceCommand.IsApplicable = new global::AcpCommonLib.StateConstraint(global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.ConSetVoiceCommandFieldInapplicableIfVoiceAnnouncementIsNotTTS);
			this.radErgoSecureTxSelectOffVoiceCommand.IsApplicable = new global::AcpCommonLib.StateConstraint(global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.ConSetVoiceCommandFieldInapplicableIfVoiceAnnouncementIsNotTTS);
			this.radErgoKeyPadControlsLockOnVoiceCommand.IsApplicable = new global::AcpCommonLib.StateConstraint(global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.ConSetVoiceCommandFieldInapplicableIfVoiceAnnouncementIsNotTTS);
			this.radErgoKeyPadControlsLockOffVoiceCommand.IsApplicable = new global::AcpCommonLib.StateConstraint(global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.ConSetVoiceCommandFieldInapplicableIfVoiceAnnouncementIsNotTTS);
			this.radErgoMultiFuntionalButtonPrimaryModeCommand.IsApplicable = new global::AcpCommonLib.StateConstraint(global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.ConSetVoiceCommandFieldInapplicableIfVoiceAnnouncementIsNotTTS);
			this.radErgoMultiFuntionalButtonSecondaryModeCommand.IsApplicable = new global::AcpCommonLib.StateConstraint(global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.ConSetVoiceCommandFieldInapplicableIfVoiceAnnouncementIsNotTTS);
			this.radErgoWrongBatteryVoiceCommand.IsApplicable = new global::AcpCommonLib.StateConstraint(global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.ConSetVoiceCommandFieldInapplicableIfVoiceAnnouncementIsNotTTS);
			this.radErgoOverTemperatureAnnouncementVoiceCommand.IsApplicable = new global::AcpCommonLib.StateConstraint(global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.ConSetVoiceCommandFieldInapplicableIfVoiceAnnouncementIsNotTTS);
			this.radErgoRfDeviceCumulativeOverTemperatureAnnouncementVoiceCommand.IsApplicable = new global::AcpCommonLib.StateConstraint(global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.ConSetVoiceCommandFieldInapplicableIfVoiceAnnouncementIsNotTTS);
			this.radErgoOptionalComponentCumulativeOverTemperatureAnnouncementVoiceCommand.IsApplicable = new global::AcpCommonLib.StateConstraint(global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.ConSetVoiceCommandFieldInapplicableIfVoiceAnnouncementIsNotTTS);
			this.radErgoBatteryCumulativeOverTemperatureAnnouncementVoiceCommand.IsApplicable = new global::AcpCommonLib.StateConstraint(global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.ConSetVoiceCommandFieldInapplicableIfVoiceAnnouncementIsNotTTS);
			this.radErgoNonHZMAccessoryAnnouncementVoiceCommand.IsApplicable = new global::AcpCommonLib.StateConstraint(global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.ConSetVoiceCommandFieldInapplicableIfVoiceAnnouncementIsNotTTS);
			this.radErgoExitHazardZoneModeAnnouncementVoiceCommand.IsApplicable = new global::AcpCommonLib.StateConstraint(global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.ConSetVoiceCommandFieldInapplicableIfVoiceAnnouncementIsNotTTS);
			this.radErgoOutOfRangeAnnouncementVoiceCommand.IsApplicable = new global::AcpCommonLib.StateConstraint(global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.ConSetVoiceCommandFieldInapplicableIfVoiceAnnouncementIsNotTTS);
			this.radErgoPowerDownAnnouncementVoiceCommand.IsApplicable = new global::AcpCommonLib.StateConstraint(global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.ConSetVoiceCommandFieldInapplicableIfVoiceAnnouncementIsNotTTS);
			this.radErgoSelfCheckFailAnnouncementVoiceCommand.IsApplicable = new global::AcpCommonLib.StateConstraint(global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.ConSetVoiceCommandFieldInapplicableIfVoiceAnnouncementIsNotTTS);
			this.radErgoAccessoryFailureAnnouncementVoiceCommand.IsApplicable = new global::AcpCommonLib.StateConstraint(global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.ConSetVoiceCommandFieldInapplicableIfVoiceAnnouncementIsNotTTS);
			this.radErgoAntennaFailureAnnouncementVoiceCommand.IsApplicable = new global::AcpCommonLib.StateConstraint(global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.ConSetVoiceCommandFieldInapplicableIfVoiceAnnouncementIsNotTTS);
			this.radErgoScanOnAnnouncementVoiceCommand.IsValid = new global::AcpCommonLib.StateConstraint(global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.ConValidateTTSFieldAndDuration);
			this.radErgoScanOffAnnouncementVoiceCommand.IsValid = new global::AcpCommonLib.StateConstraint(global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.ConValidateTTSFieldAndDuration);
			this.radErgoMonitorOnVoiceCommand.IsValid = new global::AcpCommonLib.StateConstraint(global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.ConValidateTTSFieldAndDuration);
			this.radErgoMonitorOffVoiceCommand.IsValid = new global::AcpCommonLib.StateConstraint(global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.ConValidateTTSFieldAndDuration);
			this.radErgoDirectModeOnVoiceCommand.IsValid = new global::AcpCommonLib.StateConstraint(global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.ConValidateTTSFieldAndDuration);
			this.radErgoDirectModeOffVoiceCommand.IsValid = new global::AcpCommonLib.StateConstraint(global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.ConValidateTTSFieldAndDuration);
			this.radErgoTxInhibitOnVoiceCommand.IsValid = new global::AcpCommonLib.StateConstraint(global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.ConValidateTTSFieldAndDuration);
			this.radErgoTxInhibitOffVoiceCommand.IsValid = new global::AcpCommonLib.StateConstraint(global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.ConValidateTTSFieldAndDuration);
			this.radErgoInCallUserAlertOnVoiceCommand.IsValid = new global::AcpCommonLib.StateConstraint(global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.ConValidateTTSFieldAndDuration);
			this.radErgoInCallUserAlertOffVoiceCommand.IsValid = new global::AcpCommonLib.StateConstraint(global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.ConValidateTTSFieldAndDuration);
			this.radErgoEmergencyOnVoiceCommand.IsValid = new global::AcpCommonLib.StateConstraint(global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.ConValidateTTSFieldAndDuration);
			this.radErgoSecureTxSelectOnVoiceCommand.IsValid = new global::AcpCommonLib.StateConstraint(global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.ConValidateTTSFieldAndDuration);
			this.radErgoSecureTxSelectOffVoiceCommand.IsValid = new global::AcpCommonLib.StateConstraint(global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.ConValidateTTSFieldAndDuration);
			this.radErgoKeyPadControlsLockOnVoiceCommand.IsValid = new global::AcpCommonLib.StateConstraint(global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.ConValidateTTSFieldAndDuration);
			this.radErgoKeyPadControlsLockOffVoiceCommand.IsValid = new global::AcpCommonLib.StateConstraint(global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.ConValidateTTSFieldAndDuration);
			this.radErgoMultiFuntionalButtonPrimaryModeCommand.IsValid = new global::AcpCommonLib.StateConstraint(global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.ConValidateTTSFieldAndDuration);
			this.radErgoMultiFuntionalButtonSecondaryModeCommand.IsValid = new global::AcpCommonLib.StateConstraint(global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.ConValidateTTSFieldAndDuration);
			this.radErgoWrongBatteryVoiceCommand.IsValid = new global::AcpCommonLib.StateConstraint(global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.ConValidateTTSFieldAndDuration);
			this.radErgoOverTemperatureAnnouncementVoiceCommand.IsValid = new global::AcpCommonLib.StateConstraint(global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.ConValidateTTSFieldAndDuration);
			this.radErgoRfDeviceCumulativeOverTemperatureAnnouncementVoiceCommand.IsValid = new global::AcpCommonLib.StateConstraint(global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.ConValidateTTSFieldAndDuration);
			this.radErgoOptionalComponentCumulativeOverTemperatureAnnouncementVoiceCommand.IsValid = new global::AcpCommonLib.StateConstraint(global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.ConValidateTTSFieldAndDuration);
			this.radErgoBatteryCumulativeOverTemperatureAnnouncementVoiceCommand.IsValid = new global::AcpCommonLib.StateConstraint(global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.ConValidateTTSFieldAndDuration);
			this.radErgoNonHZMAccessoryAnnouncementVoiceCommand.IsValid = new global::AcpCommonLib.StateConstraint(global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.ConValidateTTSFieldAndDuration);
			this.radErgoExitHazardZoneModeAnnouncementVoiceCommand.IsValid = new global::AcpCommonLib.StateConstraint(global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.ConValidateTTSFieldAndDuration);
			this.radErgoOutOfRangeAnnouncementVoiceCommand.IsValid = new global::AcpCommonLib.StateConstraint(global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.ConValidateTTSFieldAndDuration);
			this.radErgoPowerDownAnnouncementVoiceCommand.IsValid = new global::AcpCommonLib.StateConstraint(global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.ConValidateTTSFieldAndDuration);
			this.radErgoSelfCheckFailAnnouncementVoiceCommand.IsValid = new global::AcpCommonLib.StateConstraint(global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.ConValidateTTSFieldAndDuration);
			this.radErgoAccessoryFailureAnnouncementVoiceCommand.IsValid = new global::AcpCommonLib.StateConstraint(global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.ConValidateTTSFieldAndDuration);
			this.radErgoAntennaFailureAnnouncementVoiceCommand.IsValid = new global::AcpCommonLib.StateConstraint(global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.ConValidateTTSFieldAndDuration);
			this.radErgoCfgVAWideExitHazardZoneMode.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.ConSetVAFieldInvalidWhenNoneForNFPACompliantEnabled);
			this.radErgoCfgVAWideSelfCheckFailure.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.ConSetVAFieldInvalidWhenNoneForNFPACompliantEnabled);
			this.radErgoCfgVAWideAccessoryFailure.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.ConSetVAFieldInvalidWhenNoneForNFPACompliantEnabled);
			this.radErgoCfgVAWideOutOfRange.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.ConSetVAFieldInvalidWhenNoneForNFPACompliantEnabled);
			this.radErgoCfgVAWideOverTemperature.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.ConSetVAFieldInvalidWhenNoneForNFPACompliantEnabled);
			this.radErgoCfgVAWidePowerDown.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.ConSetVAFieldInvalidWhenNoneForNFPACompliantEnabled);
			this.radErgoCfgVAWideRFDeviceCumulativeOverTemperature.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.ConSetVAFieldInvalidWhenNoneForNFPACompliantEnabled);
			this.radErgoCfgVAWideOptionalComponentCumulativeOverTemperature.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.ConSetVAFieldInvalidWhenNoneForNFPACompliantEnabled);
			this.radErgoCfgVAWideNonHZMAccessory.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.ConSetVAFieldInvalidWhenNoneForNFPACompliantEnabled);
			this.radErgoCfgVAWideBatteryCumulativeOverTemperature.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.ConSetVAFieldInvalidWhenNoneForNFPACompliantEnabled);
			this.voiceAnnouncementPriority_A7651.IsApplicable = new global::AcpCommonLib.StateConstraint(global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementsConstraints.ConSetVAPriorityFieldInapplicableAndLowForNFPAModelsAndNFPACompliantEnabled);
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00015D9C File Offset: 0x00013F9C
		public override void SetupDependencies()
		{
			short num = (short)1460043284;
			short num2 = num;
			num = (short)1981709844;
			switch (num2 == num)
			{
			}
			num = (short)543752193;
			if (num != 0)
			{
			}
			num = (short)928448512;
			if (num != 0)
			{
			}
			num = (short)1120534528;
			short num3 = num;
			this.RefRadioWide.Features.RadWideFeaturesNFPACompliant.AddDependentObject(this.radErgoCfgVAWideExitHazardZoneMode);
			this.RefRadioWide.Features.RadWideFeaturesNFPACompliant.AddDependentObject(this.radErgoCfgVAWideSelfCheckFailure);
			this.RefRadioWide.Features.RadWideFeaturesNFPACompliant.AddDependentObject(this.radErgoCfgVAWideAccessoryFailure);
			this.RefRadioWide.Features.RadWideFeaturesNFPACompliant.AddDependentObject(this.radErgoCfgVAWideOutOfRange);
			this.RefRadioWide.Features.RadWideFeaturesNFPACompliant.AddDependentObject(this.radErgoCfgVAWideOverTemperature);
			this.RefRadioWide.Features.RadWideFeaturesNFPACompliant.AddDependentObject(this.radErgoCfgVAWidePowerDown);
			this.RefRadioWide.Features.RadWideFeaturesNFPACompliant.AddDependentObject(this.radErgoCfgVAWideAntennaFailure);
			this.RefRadioWide.Features.RadWideFeaturesNFPACompliant.AddDependentObject(this.radErgoCfgVAWideRFDeviceCumulativeOverTemperature);
			this.RefRadioWide.Features.RadWideFeaturesNFPACompliant.AddDependentObject(this.radErgoCfgVAWideOptionalComponentCumulativeOverTemperature);
			this.RefRadioWide.Features.RadWideFeaturesNFPACompliant.AddDependentObject(this.radErgoCfgVAWideNonHZMAccessory);
			this.RefRadioWide.Features.RadWideFeaturesNFPACompliant.AddDependentObject(this.radErgoCfgVAWideBatteryCumulativeOverTemperature);
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600009A RID: 154 RVA: 0x00015F7C File Offset: 0x0001417C
		public bool HasDiffs
		{
			get
			{
				short num = (short)1359135926;
				short num2 = num;
				num = (short)1293599926;
				switch (num2 == num)
				{
				}
				num = (short)2002124801;
				if (num != 0)
				{
				}
				num = (short)345833472;
				if (num != 0)
				{
				}
				num = (short)418185216;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600009B RID: 155 RVA: 0x0001602C File Offset: 0x0001422C
		// (set) Token: 0x0600009C RID: 156 RVA: 0x000160E4 File Offset: 0x000142E4
		public bool SiteSelectableAlertAllowedinOutofRange_A42013Value
		{
			get
			{
				short num = (short)654644968;
				short num2 = num;
				num = (short)1515132648;
				switch (num2 == num)
				{
				}
				num = (short)1011613697;
				if (num != 0)
				{
				}
				num = (short)1497497600;
				if (num != 0)
				{
				}
				num = (short)1624178688;
				short num3 = num;
				return this.siteSelectableAlertAllowedinOutofRange_A42013.Value;
			}
			set
			{
				short num = (short)463056003;
				short num2 = num;
				num = (short)579972227;
				switch (num2 == num)
				{
				}
				num = (short)114294784;
				if (num != 0)
				{
				}
				num = (short)806682625;
				if (num != 0)
				{
				}
				num = (short)1137770496;
				short num3 = num;
				this.siteSelectableAlertAllowedinOutofRange_A42013.Value = value;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600009D RID: 157 RVA: 0x00016198 File Offset: 0x00014398
		public global::AcpBusinessLayer.AcpField<bool> SiteSelectableAlertAllowedinOutofRange_A42013
		{
			get
			{
				short num = (short)927188921;
				short num2 = num;
				num = (short)878167993;
				switch (num2 == num)
				{
				}
				num = (short)646578177;
				if (num != 0)
				{
				}
				num = (short)1348141056;
				if (num != 0)
				{
				}
				num = (short)306249728;
				short num3 = num;
				return this.siteSelectableAlertAllowedinOutofRange_A42013;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600009E RID: 158 RVA: 0x00016248 File Offset: 0x00014448
		// (set) Token: 0x0600009F RID: 159 RVA: 0x000162FC File Offset: 0x000144FC
		public bool SiteSelectableAlertAllowedinOutofRange_A42013_UIValue
		{
			get
			{
				short num = (short)1027959047;
				short num2 = num;
				num = (short)851863815;
				switch (num2 == num)
				{
				}
				num = (short)569114625;
				if (num != 0)
				{
				}
				num = (short)1741553664;
				if (num != 0)
				{
				}
				num = (short)876871680;
				short num3 = num;
				return this.siteSelectableAlertAllowedinOutofRange_A42013.Value;
			}
			set
			{
				short num = (short)1105684582;
				short num2 = num;
				num = (short)209348710;
				switch (num2 == num)
				{
				}
				num = (short)41680896;
				if (num != 0)
				{
				}
				num = (short)1944387585;
				if (num != 0)
				{
				}
				num = (short)516685824;
				short num3 = num;
				this.siteSelectableAlertAllowedinOutofRange_A42013.Value = value;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x000163B0 File Offset: 0x000145B0
		// (set) Token: 0x060000A1 RID: 161 RVA: 0x00016464 File Offset: 0x00014664
		public bool SiteSelectableAlertAllowedinOutofRange_A42013_Applicable
		{
			get
			{
				short num = (short)1191865986;
				short num2 = num;
				num = (short)734293634;
				switch (num2 == num)
				{
				}
				num = (short)417726465;
				if (num != 0)
				{
				}
				num = (short)1393623040;
				if (num != 0)
				{
				}
				num = (short)348454912;
				short num3 = num;
				return this.siteSelectableAlertAllowedinOutofRange_A42013.Applicable;
			}
			set
			{
				short num = (short)2053259287;
				short num2 = num;
				num = (short)1543520279;
				switch (num2 == num)
				{
				}
				num = (short)1318191104;
				if (num != 0)
				{
				}
				num = (short)1441202177;
				if (num != 0)
				{
				}
				num = (short)340721664;
				short num3 = num;
				this.siteSelectableAlertAllowedinOutofRange_A42013.Applicable = value;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x0001651C File Offset: 0x0001471C
		// (set) Token: 0x060000A3 RID: 163 RVA: 0x000165CC File Offset: 0x000147CC
		public bool SiteSelectableAlertAllowedinOutofRange_A42013_Valid
		{
			get
			{
				short num = (short)124442704;
				short num2 = num;
				num = (short)1009899600;
				switch (num2 == num)
				{
				}
				num = (short)856621057;
				if (num != 0)
				{
				}
				num = (short)1023410176;
				if (num != 0)
				{
				}
				num = (short)230817792;
				short num3 = num;
				return this.siteSelectableAlertAllowedinOutofRange_A42013.Valid;
			}
			set
			{
				short num = (short)493944833;
				if (num != 0)
				{
				}
				num = (short)1481833138;
				short num2 = num;
				num = (short)1706031794;
				switch (num2 == num)
				{
				}
				num = (short)2026831872;
				if (num != 0)
				{
				}
				num = (short)1371275264;
				short num3 = num;
				this.siteSelectableAlertAllowedinOutofRange_A42013.Valid = value;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x00016680 File Offset: 0x00014880
		// (set) Token: 0x060000A5 RID: 165 RVA: 0x00016734 File Offset: 0x00014934
		public bool SiteSelectableAlertAllowedinOutofRange_A42013_Visible
		{
			get
			{
				short num = (short)436476096;
				short num2 = num;
				num = (short)176429248;
				switch (num2 == num)
				{
				}
				num = (short)892207105;
				if (num != 0)
				{
				}
				num = (short)853737472;
				if (num != 0)
				{
				}
				num = (short)743374848;
				short num3 = num;
				return this.siteSelectableAlertAllowedinOutofRange_A42013.Visible;
			}
			set
			{
				short num = (short)440841256;
				short num2 = num;
				num = (short)1467200552;
				switch (num2 == num)
				{
				}
				num = (short)870318081;
				if (num != 0)
				{
				}
				num = (short)2048065536;
				if (num != 0)
				{
				}
				num = (short)723255296;
				short num3 = num;
				this.siteSelectableAlertAllowedinOutofRange_A42013.Visible = value;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060000A6 RID: 166 RVA: 0x000167EC File Offset: 0x000149EC
		// (set) Token: 0x060000A7 RID: 167 RVA: 0x0001689C File Offset: 0x00014A9C
		public bool SiteSelectableAlertAllowedinOutofRange_A42013_Editable
		{
			get
			{
				short num = (short)608501761;
				if (num != 0)
				{
				}
				num = (short)2142001501;
				short num2 = num;
				num = (short)448485725;
				switch (num2 == num)
				{
				}
				num = (short)2138570752;
				if (num != 0)
				{
				}
				num = (short)154730496;
				short num3 = num;
				return this.siteSelectableAlertAllowedinOutofRange_A42013.Editable;
			}
			set
			{
				short num = (short)842644208;
				short num2 = num;
				num = (short)1847311088;
				switch (num2 == num)
				{
				}
				num = (short)2030960641;
				if (num != 0)
				{
				}
				num = (short)682164224;
				if (num != 0)
				{
				}
				num = (short)1774911488;
				short num3 = num;
				this.siteSelectableAlertAllowedinOutofRange_A42013.Editable = value;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x00016954 File Offset: 0x00014B54
		internal string SiteSelectableAlertAllowedinOutofRange_A42013_UILabel
		{
			get
			{
				short num = (short)1009434807;
				short num2 = num;
				num = (short)1877262519;
				switch (num2 == num)
				{
				}
				num = (short)453181441;
				if (num != 0)
				{
				}
				num = (short)988413952;
				if (num != 0)
				{
				}
				num = (short)1389232128;
				short num3 = num;
				return this.siteSelectableAlertAllowedinOutofRange_A42013.UIName;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x00016A08 File Offset: 0x00014C08
		// (set) Token: 0x060000AA RID: 170 RVA: 0x00016ABC File Offset: 0x00014CBC
		internal bool SiteSelectableAlertAllowedinOutofRange_A42013_HiddenStatic
		{
			get
			{
				short num = (short)292139901;
				short num2 = num;
				num = (short)1796518781;
				switch (num2 == num)
				{
				}
				num = (short)152633344;
				if (num != 0)
				{
				}
				num = (short)701431809;
				if (num != 0)
				{
				}
				num = (short)1386479616;
				short num3 = num;
				return this.siteSelectableAlertAllowedinOutofRange_A42013.HiddenStatic;
			}
			set
			{
				short num = (short)549781504;
				short num2 = num;
				num = (short)1468221413;
				short num3 = num;
				num = (short)815482853;
				switch (num3 == num)
				{
				}
				num = (short)1962016768;
				if (num != 0)
				{
				}
				num = (short)1072103425;
				if (num != 0)
				{
				}
				this.siteSelectableAlertAllowedinOutofRange_A42013.HiddenStatic = value;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000AB RID: 171 RVA: 0x00016B70 File Offset: 0x00014D70
		// (set) Token: 0x060000AC RID: 172 RVA: 0x00016C28 File Offset: 0x00014E28
		internal bool SiteSelectableAlertAllowedinOutofRange_A42013_HiddenDynamic
		{
			get
			{
				short num = (short)1282932736;
				short num2 = num;
				num = (short)1601961985;
				if (num != 0)
				{
				}
				num = (short)472404481;
				short num3 = num;
				num = (short)245322241;
				switch (num3 == num)
				{
				}
				num = (short)869859328;
				if (num != 0)
				{
				}
				return this.siteSelectableAlertAllowedinOutofRange_A42013.HiddenDynamic;
			}
			set
			{
				short num = (short)810549248;
				short num2 = num;
				num = (short)1308333417;
				short num3 = num;
				num = (short)1730647401;
				switch (num3 == num)
				{
				}
				num = (short)1408565249;
				if (num != 0)
				{
				}
				num = (short)686948352;
				if (num != 0)
				{
				}
				this.siteSelectableAlertAllowedinOutofRange_A42013.HiddenDynamic = value;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000AD RID: 173 RVA: 0x00016CDC File Offset: 0x00014EDC
		public bool SiteSelectableAlertAllowedinOutofRange_A42013_HasDiffs
		{
			get
			{
				short num = (short)87949312;
				short num2 = num;
				num = (short)610402305;
				if (num != 0)
				{
				}
				num = (short)1615842770;
				short num3 = num;
				num = (short)1256639954;
				switch (num3 == num)
				{
				}
				num = (short)449576960;
				if (num != 0)
				{
				}
				return this.siteSelectableAlertAllowedinOutofRange_A42013._HasDiffs;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000AE RID: 174 RVA: 0x00016D90 File Offset: 0x00014F90
		// (set) Token: 0x060000AF RID: 175 RVA: 0x00016E44 File Offset: 0x00015044
		public int VoiceAnnouncementPriority_A7651Value
		{
			get
			{
				short num = (short)921239552;
				short num2 = num;
				num = (short)573385487;
				short num3 = num;
				num = (short)1251486479;
				switch (num3 == num)
				{
				}
				num = (short)1728905216;
				if (num != 0)
				{
				}
				num = (short)264699905;
				if (num != 0)
				{
				}
				return this.voiceAnnouncementPriority_A7651.Value;
			}
			set
			{
				short num = (short)1877540864;
				short num2 = num;
				num = (short)1549740816;
				short num3 = num;
				num = (short)509487888;
				switch (num3 == num)
				{
				}
				num = (short)1859911681;
				if (num != 0)
				{
				}
				num = (short)1465516032;
				if (num != 0)
				{
				}
				this.voiceAnnouncementPriority_A7651.Value = value;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x00016EFC File Offset: 0x000150FC
		// (set) Token: 0x060000B1 RID: 177 RVA: 0x00016FB0 File Offset: 0x000151B0
		public string VoiceAnnouncementPriority_A7651_UIValue
		{
			get
			{
				short num = (short)791937024;
				short num2 = num;
				num = (short)595960549;
				short num3 = num;
				num = (short)534029029;
				switch (num3 == num)
				{
				}
				num = (short)350617601;
				if (num != 0)
				{
				}
				num = (short)193265664;
				if (num != 0)
				{
				}
				return this.voiceAnnouncementPriority_A7651.UIValue;
			}
			set
			{
				short num = (short)1131937792;
				short num2 = num;
				num = (short)835198995;
				short num3 = num;
				num = (short)1596989459;
				switch (num3 == num)
				{
				}
				num = (short)192610305;
				if (num != 0)
				{
				}
				num = (short)654835712;
				if (num != 0)
				{
				}
				this.voiceAnnouncementPriority_A7651.UIValue = value;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000B2 RID: 178 RVA: 0x00017068 File Offset: 0x00015268
		public global::AcpBusinessLayer.AcpSparseLOVField VoiceAnnouncementPriority_A7651
		{
			get
			{
				short num = (short)284819456;
				short num2 = num;
				num = (short)724312071;
				short num3 = num;
				num = (short)1447567367;
				switch (num3 == num)
				{
				}
				num = (short)153812993;
				if (num != 0)
				{
				}
				num = (short)1337655296;
				if (num != 0)
				{
				}
				return this.voiceAnnouncementPriority_A7651;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000B3 RID: 179 RVA: 0x00017118 File Offset: 0x00015318
		// (set) Token: 0x060000B4 RID: 180 RVA: 0x000171CC File Offset: 0x000153CC
		public bool VoiceAnnouncementPriority_A7651_Applicable
		{
			get
			{
				short num = (short)445841408;
				short num2 = num;
				num = (short)1470157825;
				short num3 = num;
				num = (short)1978389505;
				switch (num3 == num)
				{
				}
				num = (short)1985347585;
				if (num != 0)
				{
				}
				num = (short)62586880;
				if (num != 0)
				{
				}
				return this.voiceAnnouncementPriority_A7651.Applicable;
			}
			set
			{
				short num = (short)1414594560;
				short num2 = num;
				num = (short)709492737;
				if (num != 0)
				{
				}
				num = (short)604926464;
				short num3 = num;
				num = (short)1550152192;
				switch (num3 == num)
				{
				}
				num = (short)1922105344;
				if (num != 0)
				{
				}
				this.voiceAnnouncementPriority_A7651.Applicable = value;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x00017280 File Offset: 0x00015480
		// (set) Token: 0x060000B6 RID: 182 RVA: 0x00017334 File Offset: 0x00015534
		public bool VoiceAnnouncementPriority_A7651_Valid
		{
			get
			{
				short num = (short)2036400128;
				short num2 = num;
				num = (short)984605759;
				short num3 = num;
				num = (short)1358619711;
				switch (num3 == num)
				{
				}
				num = (short)1334706177;
				if (num != 0)
				{
				}
				num = (short)840630272;
				if (num != 0)
				{
				}
				return this.voiceAnnouncementPriority_A7651.Valid;
			}
			set
			{
				short num = (short)220856320;
				short num2 = num;
				num = (short)268699590;
				short num3 = num;
				num = (short)1092945862;
				switch (num3 == num)
				{
				}
				num = (short)6553601;
				if (num != 0)
				{
				}
				num = (short)1017839616;
				if (num != 0)
				{
				}
				this.voiceAnnouncementPriority_A7651.Valid = value;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x000173E8 File Offset: 0x000155E8
		// (set) Token: 0x060000B8 RID: 184 RVA: 0x000174A0 File Offset: 0x000156A0
		public bool VoiceAnnouncementPriority_A7651_Visible
		{
			get
			{
				short num = (short)1264910336;
				short num2 = num;
				num = (short)1740531330;
				short num3 = num;
				num = (short)2142725762;
				switch (num3 == num)
				{
				}
				num = (short)892403712;
				if (num != 0)
				{
				}
				num = (short)1378484225;
				if (num != 0)
				{
				}
				return this.voiceAnnouncementPriority_A7651.Visible;
			}
			set
			{
				short num = (short)2113732608;
				short num2 = num;
				num = (short)1846326662;
				short num3 = num;
				num = (short)1105376646;
				switch (num3 == num)
				{
				}
				num = (short)966656000;
				if (num != 0)
				{
				}
				num = (short)883884033;
				if (num != 0)
				{
				}
				this.voiceAnnouncementPriority_A7651.Visible = value;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000B9 RID: 185 RVA: 0x00017558 File Offset: 0x00015758
		// (set) Token: 0x060000BA RID: 186 RVA: 0x00017610 File Offset: 0x00015810
		public bool VoiceAnnouncementPriority_A7651_Editable
		{
			get
			{
				short num = (short)1261633536;
				short num2 = num;
				num = (short)1760374595;
				short num3 = num;
				num = (short)2042507075;
				switch (num3 == num)
				{
				}
				num = (short)1239482369;
				if (num != 0)
				{
				}
				num = (short)166526976;
				if (num != 0)
				{
				}
				return this.voiceAnnouncementPriority_A7651.Editable;
			}
			set
			{
				short num = (short)2142568448;
				short num2 = num;
				num = (short)1546736008;
				short num3 = num;
				num = (short)2081116552;
				switch (num3 == num)
				{
				}
				num = (short)2001141761;
				if (num != 0)
				{
				}
				num = (short)209321984;
				if (num != 0)
				{
				}
				this.voiceAnnouncementPriority_A7651.Editable = value;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000BB RID: 187 RVA: 0x000176C8 File Offset: 0x000158C8
		internal string VoiceAnnouncementPriority_A7651_UILabel
		{
			get
			{
				short num = (short)621740032;
				short num2 = num;
				num = (short)178908493;
				short num3 = num;
				num = (short)489418061;
				switch (num3 == num)
				{
				}
				num = (short)1739194369;
				if (num != 0)
				{
				}
				num = (short)1834549248;
				if (num != 0)
				{
				}
				return this.voiceAnnouncementPriority_A7651.UIName;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000BC RID: 188 RVA: 0x00017778 File Offset: 0x00015978
		// (set) Token: 0x060000BD RID: 189 RVA: 0x00017830 File Offset: 0x00015A30
		internal bool VoiceAnnouncementPriority_A7651_HiddenStatic
		{
			get
			{
				short num = (short)685047808;
				short num2 = num;
				num = (short)739285298;
				short num3 = num;
				num = (short)457152818;
				switch (num3 == num)
				{
				}
				num = (short)1716322305;
				if (num != 0)
				{
				}
				num = (short)1872953344;
				if (num != 0)
				{
				}
				return this.voiceAnnouncementPriority_A7651.HiddenStatic;
			}
			set
			{
				short num = (short)1242300416;
				short num2 = num;
				num = (short)599735940;
				short num3 = num;
				num = (short)900611716;
				switch (num3 == num)
				{
				}
				num = (short)1428553729;
				if (num != 0)
				{
				}
				num = (short)314245120;
				if (num != 0)
				{
				}
				this.voiceAnnouncementPriority_A7651.HiddenStatic = value;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000BE RID: 190 RVA: 0x000178E4 File Offset: 0x00015AE4
		// (set) Token: 0x060000BF RID: 191 RVA: 0x0001799C File Offset: 0x00015B9C
		internal bool VoiceAnnouncementPriority_A7651_HiddenDynamic
		{
			get
			{
				short num = (short)1584398336;
				short num2 = num;
				num = (short)637812940;
				short num3 = num;
				num = (short)264913100;
				switch (num3 == num)
				{
				}
				num = (short)430112768;
				if (num != 0)
				{
				}
				num = (short)379453441;
				if (num != 0)
				{
				}
				return this.voiceAnnouncementPriority_A7651.HiddenDynamic;
			}
			set
			{
				short num = (short)584777728;
				short num2 = num;
				num = (short)290972105;
				short num3 = num;
				num = (short)1526587849;
				switch (num3 == num)
				{
				}
				num = (short)1217003521;
				if (num != 0)
				{
				}
				num = (short)1012596736;
				if (num != 0)
				{
				}
				this.voiceAnnouncementPriority_A7651.HiddenDynamic = value;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000C0 RID: 192 RVA: 0x00017A50 File Offset: 0x00015C50
		public bool VoiceAnnouncementPriority_A7651_HasDiffs
		{
			get
			{
				short num = (short)1754202112;
				short num2 = num;
				num = (short)2004869437;
				short num3 = num;
				num = (short)1611718973;
				switch (num3 == num)
				{
				}
				num = (short)1225457665;
				if (num != 0)
				{
				}
				num = (short)1818886144;
				if (num != 0)
				{
				}
				return this.voiceAnnouncementPriority_A7651._HasDiffs;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000C1 RID: 193 RVA: 0x00017B04 File Offset: 0x00015D04
		// (set) Token: 0x060000C2 RID: 194 RVA: 0x00017BB8 File Offset: 0x00015DB8
		public bool SuppressReplay_A44925Value
		{
			get
			{
				short num = (short)57016320;
				short num2 = num;
				num = (short)1087837713;
				short num3 = num;
				num = (short)474289681;
				switch (num3 == num)
				{
				}
				num = (short)863043584;
				if (num != 0)
				{
				}
				num = (short)149356545;
				if (num != 0)
				{
				}
				return this.suppressReplay_A44925.Value;
			}
			set
			{
				short num = (short)2043674624;
				short num2 = num;
				num = (short)323046287;
				short num3 = num;
				num = (short)1140870031;
				switch (num3 == num)
				{
				}
				num = (short)1550057473;
				if (num != 0)
				{
				}
				num = (short)287047680;
				if (num != 0)
				{
				}
				this.suppressReplay_A44925.Value = value;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x00017C6C File Offset: 0x00015E6C
		public global::AcpBusinessLayer.AcpField<bool> SuppressReplay_A44925
		{
			get
			{
				short num = (short)1207959552;
				short num2 = num;
				num = (short)2087233025;
				short num3 = num;
				num = (short)2041292289;
				switch (num3 == num)
				{
				}
				num = (short)1260453889;
				if (num != 0)
				{
				}
				num = (short)1660944384;
				if (num != 0)
				{
				}
				return this.suppressReplay_A44925;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000C4 RID: 196 RVA: 0x00017D1C File Offset: 0x00015F1C
		// (set) Token: 0x060000C5 RID: 197 RVA: 0x00017DD0 File Offset: 0x00015FD0
		public bool SuppressReplay_A44925_UIValue
		{
			get
			{
				short num = (short)847446016;
				short num2 = num;
				num = (short)1513357313;
				if (num != 0)
				{
				}
				num = (short)1507063476;
				short num3 = num;
				num = (short)975369908;
				switch (num3 == num)
				{
				}
				num = (short)949092352;
				if (num != 0)
				{
				}
				return this.suppressReplay_A44925.Value;
			}
			set
			{
				short num = (short)2136735744;
				short num2 = num;
				num = (short)1479525651;
				short num3 = num;
				num = (short)515163411;
				switch (num3 == num)
				{
				}
				num = (short)610009089;
				if (num != 0)
				{
				}
				num = (short)2138177536;
				if (num != 0)
				{
				}
				this.suppressReplay_A44925.Value = value;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000C6 RID: 198 RVA: 0x00017E84 File Offset: 0x00016084
		// (set) Token: 0x060000C7 RID: 199 RVA: 0x00017F38 File Offset: 0x00016138
		public bool SuppressReplay_A44925_Applicable
		{
			get
			{
				short num = (short)436862976;
				short num2 = num;
				num = (short)394526721;
				if (num != 0)
				{
				}
				num = (short)1541633196;
				short num3 = num;
				num = (short)1668773036;
				switch (num3 == num)
				{
				}
				num = (short)748879872;
				if (num != 0)
				{
				}
				return this.suppressReplay_A44925.Applicable;
			}
			set
			{
				short num = (short)385155072;
				short num2 = num;
				num = (short)517994732;
				short num3 = num;
				num = (short)1840445676;
				switch (num3 == num)
				{
				}
				num = (short)1093074944;
				if (num != 0)
				{
				}
				num = (short)487194625;
				if (num != 0)
				{
				}
				this.suppressReplay_A44925.Applicable = value;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x00017FEC File Offset: 0x000161EC
		// (set) Token: 0x060000C9 RID: 201 RVA: 0x000180A0 File Offset: 0x000162A0
		public bool SuppressReplay_A44925_Valid
		{
			get
			{
				short num = (short)348061696;
				short num2 = num;
				num = (short)839843841;
				if (num != 0)
				{
				}
				num = (short)500968651;
				short num3 = num;
				num = (short)164572363;
				switch (num3 == num)
				{
				}
				num = (short)368050176;
				if (num != 0)
				{
				}
				return this.suppressReplay_A44925.Valid;
			}
			set
			{
				short num = (short)1445658624;
				short num2 = num;
				num = (short)1232451387;
				short num3 = num;
				num = (short)1585952571;
				switch (num3 == num)
				{
				}
				num = (short)1516503041;
				if (num != 0)
				{
				}
				num = (short)2050490368;
				if (num != 0)
				{
				}
				this.suppressReplay_A44925.Valid = value;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000CA RID: 202 RVA: 0x00018158 File Offset: 0x00016358
		// (set) Token: 0x060000CB RID: 203 RVA: 0x0001820C File Offset: 0x0001640C
		public bool SuppressReplay_A44925_Visible
		{
			get
			{
				short num = (short)545652736;
				short num2 = num;
				num = (short)1975460035;
				short num3 = num;
				num = (short)1220092099;
				switch (num3 == num)
				{
				}
				num = (short)1972043777;
				if (num != 0)
				{
				}
				num = (short)1796931584;
				if (num != 0)
				{
				}
				return this.suppressReplay_A44925.Visible;
			}
			set
			{
				short num = (short)1505427456;
				short num2 = num;
				num = (short)183780293;
				short num3 = num;
				num = (short)267600837;
				switch (num3 == num)
				{
				}
				num = (short)1329070080;
				if (num != 0)
				{
				}
				num = (short)1644232705;
				if (num != 0)
				{
				}
				this.suppressReplay_A44925.Visible = value;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000CC RID: 204 RVA: 0x000182C4 File Offset: 0x000164C4
		// (set) Token: 0x060000CD RID: 205 RVA: 0x0001837C File Offset: 0x0001657C
		public bool SuppressReplay_A44925_Editable
		{
			get
			{
				short num = (short)1975713792;
				short num2 = num;
				num = (short)103268463;
				short num3 = num;
				num = (short)1280819311;
				switch (num3 == num)
				{
				}
				num = (short)1683881985;
				if (num != 0)
				{
				}
				num = (short)850460672;
				if (num != 0)
				{
				}
				return this.suppressReplay_A44925.Editable;
			}
			set
			{
				short num = (short)1142947840;
				short num2 = num;
				num = (short)566626330;
				short num3 = num;
				num = (short)1137117210;
				switch (num3 == num)
				{
				}
				num = (short)1416101889;
				if (num != 0)
				{
				}
				num = (short)203161600;
				if (num != 0)
				{
				}
				this.suppressReplay_A44925.Editable = value;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000CE RID: 206 RVA: 0x00018434 File Offset: 0x00016634
		internal string SuppressReplay_A44925_UILabel
		{
			get
			{
				short num = (short)1358430208;
				short num2 = num;
				num = (short)630533279;
				short num3 = num;
				num = (short)871771295;
				switch (num3 == num)
				{
				}
				num = (short)1987117056;
				if (num != 0)
				{
				}
				num = (short)371523585;
				if (num != 0)
				{
				}
				return this.suppressReplay_A44925.UIName;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000CF RID: 207 RVA: 0x000184E8 File Offset: 0x000166E8
		// (set) Token: 0x060000D0 RID: 208 RVA: 0x0001859C File Offset: 0x0001679C
		internal bool SuppressReplay_A44925_HiddenStatic
		{
			get
			{
				short num = (short)407633920;
				short num2 = num;
				num = (short)1879048193;
				if (num != 0)
				{
				}
				num = (short)2122341140;
				short num3 = num;
				num = (short)2022267668;
				switch (num3 == num)
				{
				}
				num = (short)1881014272;
				if (num != 0)
				{
				}
				return this.suppressReplay_A44925.HiddenStatic;
			}
			set
			{
				short num = (short)549912576;
				short num2 = num;
				num = (short)1341412100;
				short num3 = num;
				num = (short)1680823044;
				switch (num3 == num)
				{
				}
				num = (short)1301151745;
				if (num != 0)
				{
				}
				num = (short)411041792;
				if (num != 0)
				{
				}
				this.suppressReplay_A44925.HiddenStatic = value;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x00018650 File Offset: 0x00016850
		// (set) Token: 0x060000D2 RID: 210 RVA: 0x00018708 File Offset: 0x00016908
		internal bool SuppressReplay_A44925_HiddenDynamic
		{
			get
			{
				short num = (short)1090191360;
				short num2 = num;
				num = (short)67606949;
				short num3 = num;
				num = (short)2044107173;
				switch (num3 == num)
				{
				}
				num = (short)705626113;
				if (num != 0)
				{
				}
				num = (short)1720909824;
				if (num != 0)
				{
				}
				return this.suppressReplay_A44925.HiddenDynamic;
			}
			set
			{
				short num = (short)1843724288;
				short num2 = num;
				num = (short)2008416257;
				if (num != 0)
				{
				}
				num = (short)1455059971;
				short num3 = num;
				num = (short)1381856259;
				switch (num3 == num)
				{
				}
				num = (short)1117388800;
				if (num != 0)
				{
				}
				this.suppressReplay_A44925.HiddenDynamic = value;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000D3 RID: 211 RVA: 0x000187C0 File Offset: 0x000169C0
		public bool SuppressReplay_A44925_HasDiffs
		{
			get
			{
				short num = (short)1172176896;
				short num2 = num;
				num = (short)755076208;
				short num3 = num;
				num = (short)1135578224;
				switch (num3 == num)
				{
				}
				num = (short)2075197441;
				if (num != 0)
				{
				}
				num = (short)1032912896;
				if (num != 0)
				{
				}
				return this.suppressReplay_A44925._HasDiffs;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000D4 RID: 212 RVA: 0x0001887C File Offset: 0x00016A7C
		// (set) Token: 0x060000D5 RID: 213 RVA: 0x00018930 File Offset: 0x00016B30
		public int ScanOnAnnouncementID_A22250Value
		{
			get
			{
				short num = (short)1280376832;
				short num2 = num;
				num = (short)638232497;
				short num3 = num;
				num = (short)16164785;
				switch (num3 == num)
				{
				}
				num = (short)338362368;
				if (num != 0)
				{
				}
				num = (short)1906704385;
				if (num != 0)
				{
				}
				return this.scanOnAnnouncementID_A22250.Value;
			}
			set
			{
				short num = (short)376504320;
				short num2 = num;
				num = (short)861470721;
				if (num != 0)
				{
				}
				num = (short)1950586118;
				short num3 = num;
				num = (short)1841534214;
				switch (num3 == num)
				{
				}
				num = (short)1374027776;
				if (num != 0)
				{
				}
				this.scanOnAnnouncementID_A22250.Value = value;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000D6 RID: 214 RVA: 0x000189E8 File Offset: 0x00016BE8
		// (set) Token: 0x060000D7 RID: 215 RVA: 0x00018A98 File Offset: 0x00016C98
		public string ScanOnAnnouncementID_A22250_UIValue
		{
			get
			{
				short num = (short)440401920;
				short num2 = num;
				num = (short)1235678821;
				short num3 = num;
				num = (short)1214641765;
				switch (num3 == num)
				{
				}
				num = (short)320471041;
				if (num != 0)
				{
				}
				num = (short)275841024;
				if (num != 0)
				{
				}
				return this.scanOnAnnouncementID_A22250.UIValue;
			}
			set
			{
				short num = (short)363790336;
				short num2 = num;
				num = (short)1790020162;
				short num3 = num;
				num = (short)1954777666;
				switch (num3 == num)
				{
				}
				num = (short)2006777857;
				if (num != 0)
				{
				}
				num = (short)1198850048;
				if (num != 0)
				{
				}
				this.scanOnAnnouncementID_A22250.UIValue = value;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000D8 RID: 216 RVA: 0x00018B4C File Offset: 0x00016D4C
		public global::AcpBusinessLayer.AcpRecRefField ScanOnAnnouncementID_A22250
		{
			get
			{
				short num = (short)1926823936;
				short num2 = num;
				num = (short)1396258896;
				short num3 = num;
				num = (short)1572616272;
				switch (num3 == num)
				{
				}
				num = (short)74776577;
				if (num != 0)
				{
				}
				num = (short)1878654976;
				if (num != 0)
				{
				}
				return this.scanOnAnnouncementID_A22250;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000D9 RID: 217 RVA: 0x00018BFC File Offset: 0x00016DFC
		// (set) Token: 0x060000DA RID: 218 RVA: 0x00018CB0 File Offset: 0x00016EB0
		public bool ScanOnAnnouncementID_A22250_Applicable
		{
			get
			{
				short num = (short)232128512;
				short num2 = num;
				num = (short)659452365;
				short num3 = num;
				num = (short)1381331405;
				switch (num3 == num)
				{
				}
				num = (short)1804337153;
				if (num != 0)
				{
				}
				num = (short)1762394112;
				if (num != 0)
				{
				}
				return this.scanOnAnnouncementID_A22250.Applicable;
			}
			set
			{
				short num = (short)2123431936;
				short num2 = num;
				num = (short)1687945217;
				if (num != 0)
				{
				}
				num = (short)1831159083;
				short num3 = num;
				num = (short)1686324523;
				switch (num3 == num)
				{
				}
				num = (short)950534144;
				if (num != 0)
				{
				}
				this.scanOnAnnouncementID_A22250.Applicable = value;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000DB RID: 219 RVA: 0x00018D64 File Offset: 0x00016F64
		// (set) Token: 0x060000DC RID: 220 RVA: 0x00018E18 File Offset: 0x00017018
		public bool ScanOnAnnouncementID_A22250_Valid
		{
			get
			{
				short num = (short)1647706112;
				short num2 = num;
				num = (short)1932853249;
				if (num != 0)
				{
				}
				num = (short)505342333;
				short num3 = num;
				num = (short)862906749;
				switch (num3 == num)
				{
				}
				num = (short)749600768;
				if (num != 0)
				{
				}
				return this.scanOnAnnouncementID_A22250.Valid;
			}
			set
			{
				short num = (short)1618345984;
				short num2 = num;
				num = (short)2126865055;
				short num3 = num;
				num = (short)121660063;
				switch (num3 == num)
				{
				}
				num = (short)1136852993;
				if (num != 0)
				{
				}
				num = (short)1134428160;
				if (num != 0)
				{
				}
				this.scanOnAnnouncementID_A22250.Valid = value;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000DD RID: 221 RVA: 0x00018EC8 File Offset: 0x000170C8
		// (set) Token: 0x060000DE RID: 222 RVA: 0x00018F7C File Offset: 0x0001717C
		public bool ScanOnAnnouncementID_A22250_Visible
		{
			get
			{
				short num = (short)787021824;
				short num2 = num;
				num = (short)412249103;
				short num3 = num;
				num = (short)1518889999;
				switch (num3 == num)
				{
				}
				num = (short)1932197889;
				if (num != 0)
				{
				}
				num = (short)890437632;
				if (num != 0)
				{
				}
				return this.scanOnAnnouncementID_A22250.Visible;
			}
			set
			{
				short num = (short)979632128;
				short num2 = num;
				num = (short)1318977537;
				if (num != 0)
				{
				}
				num = (short)196944318;
				short num3 = num;
				num = (short)1844715966;
				switch (num3 == num)
				{
				}
				num = (short)580911104;
				if (num != 0)
				{
				}
				this.scanOnAnnouncementID_A22250.Visible = value;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000DF RID: 223 RVA: 0x00019034 File Offset: 0x00017234
		// (set) Token: 0x060000E0 RID: 224 RVA: 0x000190E8 File Offset: 0x000172E8
		public bool ScanOnAnnouncementID_A22250_Editable
		{
			get
			{
				short num = (short)275251200;
				short num2 = num;
				num = (short)181043762;
				short num3 = num;
				num = (short)1120371250;
				switch (num3 == num)
				{
				}
				num = (short)1002831873;
				if (num != 0)
				{
				}
				num = (short)1104936960;
				if (num != 0)
				{
				}
				return this.scanOnAnnouncementID_A22250.Editable;
			}
			set
			{
				short num = (short)2116943872;
				short num2 = num;
				num = (short)1677882033;
				short num3 = num;
				num = (short)1380610737;
				switch (num3 == num)
				{
				}
				num = (short)559022080;
				if (num != 0)
				{
				}
				num = (short)847446017;
				if (num != 0)
				{
				}
				this.scanOnAnnouncementID_A22250.Editable = value;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000E1 RID: 225 RVA: 0x0001919C File Offset: 0x0001739C
		internal string ScanOnAnnouncementID_A22250_UILabel
		{
			get
			{
				short num = (short)899114524;
				short num2 = num;
				num = (short)1681942044;
				switch (num2 == num)
				{
				}
				num = (short)2063073280;
				short num3 = num;
				num = (short)1538523137;
				if (num != 0)
				{
				}
				num = (short)2140143616;
				if (num != 0)
				{
				}
				return this.scanOnAnnouncementID_A22250.UIName;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000E2 RID: 226 RVA: 0x00019254 File Offset: 0x00017454
		// (set) Token: 0x060000E3 RID: 227 RVA: 0x00019308 File Offset: 0x00017508
		internal bool ScanOnAnnouncementID_A22250_HiddenStatic
		{
			get
			{
				short num = (short)1287418051;
				short num2 = num;
				num = (short)649031875;
				switch (num2 == num)
				{
				}
				num = (short)1752104960;
				short num3 = num;
				num = (short)156893185;
				if (num != 0)
				{
				}
				num = (short)672858112;
				if (num != 0)
				{
				}
				return this.scanOnAnnouncementID_A22250.HiddenStatic;
			}
			set
			{
				short num = (short)1897168727;
				short num2 = num;
				num = (short)42827607;
				switch (num2 == num)
				{
				}
				num = (short)931856384;
				short num3 = num;
				num = (short)1468334081;
				if (num != 0)
				{
				}
				num = (short)1763704832;
				if (num != 0)
				{
				}
				this.scanOnAnnouncementID_A22250.HiddenStatic = value;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000E4 RID: 228 RVA: 0x000193C0 File Offset: 0x000175C0
		// (set) Token: 0x060000E5 RID: 229 RVA: 0x00019478 File Offset: 0x00017678
		internal bool ScanOnAnnouncementID_A22250_HiddenDynamic
		{
			get
			{
				short num = (short)1151828547;
				short num2 = num;
				num = (short)1882161731;
				switch (num2 == num)
				{
				}
				num = (short)1014693888;
				short num3 = num;
				num = (short)1925971968;
				if (num != 0)
				{
				}
				num = (short)147456001;
				if (num != 0)
				{
				}
				return this.scanOnAnnouncementID_A22250.HiddenDynamic;
			}
			set
			{
				short num = (short)879330574;
				short num2 = num;
				num = (short)1481344270;
				switch (num2 == num)
				{
				}
				num = (short)910426112;
				short num3 = num;
				num = (short)1128071169;
				if (num != 0)
				{
				}
				num = (short)1214119936;
				if (num != 0)
				{
				}
				this.scanOnAnnouncementID_A22250.HiddenDynamic = value;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000E6 RID: 230 RVA: 0x00019530 File Offset: 0x00017730
		public bool ScanOnAnnouncementID_A22250_HasDiffs
		{
			get
			{
				short num = (short)1457402971;
				short num2 = num;
				num = (short)1293825115;
				switch (num2 == num)
				{
				}
				num = (short)476512256;
				short num3 = num;
				num = (short)1339621377;
				if (num != 0)
				{
				}
				num = (short)1358561280;
				if (num != 0)
				{
				}
				return this.scanOnAnnouncementID_A22250._HasDiffs;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000E7 RID: 231 RVA: 0x000195E8 File Offset: 0x000177E8
		// (set) Token: 0x060000E8 RID: 232 RVA: 0x000196A0 File Offset: 0x000178A0
		public int ScanOffAnnouncementID_A22252Value
		{
			get
			{
				short num = (short)1340792273;
				short num2 = num;
				num = (short)350412241;
				switch (num2 == num)
				{
				}
				num = (short)1345716224;
				short num3 = num;
				num = (short)279052288;
				if (num != 0)
				{
				}
				num = (short)869138433;
				if (num != 0)
				{
				}
				return this.scanOffAnnouncementID_A22252.Value;
			}
			set
			{
				short num = (short)68660070;
				short num2 = num;
				num = (short)1556654950;
				switch (num2 == num)
				{
				}
				num = (short)264634368;
				short num3 = num;
				num = (short)1508048897;
				if (num != 0)
				{
				}
				num = (short)1028718592;
				if (num != 0)
				{
				}
				this.scanOffAnnouncementID_A22252.Value = value;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000E9 RID: 233 RVA: 0x00019758 File Offset: 0x00017958
		// (set) Token: 0x060000EA RID: 234 RVA: 0x0001980C File Offset: 0x00017A0C
		public string ScanOffAnnouncementID_A22252_UIValue
		{
			get
			{
				short num = (short)424421147;
				short num2 = num;
				num = (short)487597851;
				switch (num2 == num)
				{
				}
				num = (short)600047616;
				short num3 = num;
				num = (short)967507969;
				if (num != 0)
				{
				}
				num = (short)1257439232;
				if (num != 0)
				{
				}
				return this.scanOffAnnouncementID_A22252.UIValue;
			}
			set
			{
				short num = (short)597468981;
				short num2 = num;
				num = (short)1212458805;
				switch (num2 == num)
				{
				}
				num = (short)2082275328;
				short num3 = num;
				num = (short)1921843201;
				if (num != 0)
				{
				}
				num = (short)89587712;
				if (num != 0)
				{
				}
				this.scanOffAnnouncementID_A22252.UIValue = value;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000EB RID: 235 RVA: 0x000198C4 File Offset: 0x00017AC4
		public global::AcpBusinessLayer.AcpRecRefField ScanOffAnnouncementID_A22252
		{
			get
			{
				short num = (short)2075310789;
				short num2 = num;
				num = (short)1982839493;
				switch (num2 == num)
				{
				}
				num = (short)573636608;
				short num3 = num;
				num = (short)267190273;
				if (num != 0)
				{
				}
				num = (short)1924792320;
				if (num != 0)
				{
				}
				return this.scanOffAnnouncementID_A22252;
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000EC RID: 236 RVA: 0x00019974 File Offset: 0x00017B74
		// (set) Token: 0x060000ED RID: 237 RVA: 0x00019A28 File Offset: 0x00017C28
		public bool ScanOffAnnouncementID_A22252_Applicable
		{
			get
			{
				short num = (short)1651622780;
				short num2 = num;
				num = (short)1662829436;
				switch (num2 == num)
				{
				}
				num = (short)553975808;
				short num3 = num;
				num = (short)821362689;
				if (num != 0)
				{
				}
				num = (short)1224015872;
				if (num != 0)
				{
				}
				return this.scanOffAnnouncementID_A22252.Applicable;
			}
			set
			{
				short num = (short)2139276289;
				short num2 = num;
				num = (short)2077344769;
				switch (num2 == num)
				{
				}
				num = (short)1784479744;
				short num3 = num;
				num = (short)494993409;
				if (num != 0)
				{
				}
				num = (short)1852768256;
				if (num != 0)
				{
				}
				this.scanOffAnnouncementID_A22252.Applicable = value;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000EE RID: 238 RVA: 0x00019ADC File Offset: 0x00017CDC
		// (set) Token: 0x060000EF RID: 239 RVA: 0x00019B90 File Offset: 0x00017D90
		public bool ScanOffAnnouncementID_A22252_Valid
		{
			get
			{
				short num = (short)1139058194;
				short num2 = num;
				num = (short)1966974482;
				switch (num2 == num)
				{
				}
				num = (short)217055232;
				short num3 = num;
				num = (short)1583808513;
				if (num != 0)
				{
				}
				num = (short)1716322304;
				if (num != 0)
				{
				}
				return this.scanOffAnnouncementID_A22252.Valid;
			}
			set
			{
				short num = (short)873311595;
				short num2 = num;
				num = (short)1310109035;
				switch (num2 == num)
				{
				}
				num = (short)1091764224;
				short num3 = num;
				num = (short)1791950849;
				if (num != 0)
				{
				}
				num = (short)1647575040;
				if (num != 0)
				{
				}
				this.scanOffAnnouncementID_A22252.Valid = value;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000F0 RID: 240 RVA: 0x00019C48 File Offset: 0x00017E48
		// (set) Token: 0x060000F1 RID: 241 RVA: 0x00019CFC File Offset: 0x00017EFC
		public bool ScanOffAnnouncementID_A22252_Visible
		{
			get
			{
				short num = (short)791347875;
				short num2 = num;
				num = (short)1984627363;
				switch (num2 == num)
				{
				}
				num = (short)1255407616;
				short num3 = num;
				num = (short)1172963328;
				if (num != 0)
				{
				}
				num = (short)1662189569;
				if (num != 0)
				{
				}
				return this.scanOffAnnouncementID_A22252.Visible;
			}
			set
			{
				short num = (short)1385428596;
				short num2 = num;
				num = (short)708834932;
				switch (num2 == num)
				{
				}
				num = (short)1463287808;
				short num3 = num;
				num = (short)90505217;
				if (num != 0)
				{
				}
				num = (short)370868224;
				if (num != 0)
				{
				}
				this.scanOffAnnouncementID_A22252.Visible = value;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060000F2 RID: 242 RVA: 0x00019DB0 File Offset: 0x00017FB0
		// (set) Token: 0x060000F3 RID: 243 RVA: 0x00019E64 File Offset: 0x00018064
		public bool ScanOffAnnouncementID_A22252_Editable
		{
			get
			{
				short num = (short)1786511361;
				if (num != 0)
				{
				}
				num = (short)1547803208;
				short num2 = num;
				num = (short)1733139016;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1223360512;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1742929920;
				if (num != 0)
				{
				}
				return this.scanOffAnnouncementID_A22252.Editable;
			}
			set
			{
				short num = (short)304349068;
				short num2 = num;
				num = (short)628227980;
				switch (num2 == num)
				{
				}
				num = (short)1427243008;
				short num3 = num;
				num = (short)1915879424;
				if (num != 0)
				{
				}
				num = (short)1689452545;
				if (num != 0)
				{
				}
				this.scanOffAnnouncementID_A22252.Editable = value;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060000F4 RID: 244 RVA: 0x00019F18 File Offset: 0x00018118
		internal string ScanOffAnnouncementID_A22252_UILabel
		{
			get
			{
				short num = (short)22530689;
				short num2 = num;
				num = (short)1254935169;
				switch (num2 == num)
				{
				}
				num = (short)140443648;
				short num3 = num;
				num = (short)553517057;
				if (num != 0)
				{
				}
				num = (short)1010171904;
				if (num != 0)
				{
				}
				return this.scanOffAnnouncementID_A22252.UIName;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x00019FCC File Offset: 0x000181CC
		// (set) Token: 0x060000F6 RID: 246 RVA: 0x0001A07C File Offset: 0x0001827C
		internal bool ScanOffAnnouncementID_A22252_HiddenStatic
		{
			get
			{
				short num = (short)1425978459;
				short num2 = num;
				num = (short)1120056411;
				switch (num2 == num)
				{
				}
				num = (short)1769537536;
				short num3 = num;
				num = (short)198115329;
				if (num != 0)
				{
				}
				num = (short)1930493952;
				if (num != 0)
				{
				}
				return this.scanOffAnnouncementID_A22252.HiddenStatic;
			}
			set
			{
				short num = (short)2009217560;
				short num2 = num;
				num = (short)53033496;
				switch (num2 == num)
				{
				}
				num = (short)825884672;
				short num3 = num;
				num = (short)720109569;
				if (num != 0)
				{
				}
				num = (short)1512439808;
				if (num != 0)
				{
				}
				this.scanOffAnnouncementID_A22252.HiddenStatic = value;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060000F7 RID: 247 RVA: 0x0001A134 File Offset: 0x00018334
		// (set) Token: 0x060000F8 RID: 248 RVA: 0x0001A1EC File Offset: 0x000183EC
		internal bool ScanOffAnnouncementID_A22252_HiddenDynamic
		{
			get
			{
				short num = (short)1399016503;
				short num2 = num;
				num = (short)420891703;
				switch (num2 == num)
				{
				}
				num = (short)113967104;
				short num3 = num;
				num = (short)1786576897;
				if (num != 0)
				{
				}
				num = (short)1943339008;
				if (num != 0)
				{
				}
				return this.scanOffAnnouncementID_A22252.HiddenDynamic;
			}
			set
			{
				short num = (short)473440172;
				short num2 = num;
				num = (short)677126060;
				switch (num2 == num)
				{
				}
				num = (short)746258432;
				short num3 = num;
				num = (short)402849793;
				if (num != 0)
				{
				}
				num = (short)998834176;
				if (num != 0)
				{
				}
				this.scanOffAnnouncementID_A22252.HiddenDynamic = value;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060000F9 RID: 249 RVA: 0x0001A2A4 File Offset: 0x000184A4
		public bool ScanOffAnnouncementID_A22252_HasDiffs
		{
			get
			{
				short num = (short)150520140;
				short num2 = num;
				num = (short)813547852;
				switch (num2 == num)
				{
				}
				num = (short)1016659968;
				short num3 = num;
				num = (short)1630863361;
				if (num != 0)
				{
				}
				num = (short)463732736;
				if (num != 0)
				{
				}
				return this.scanOffAnnouncementID_A22252._HasDiffs;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060000FA RID: 250 RVA: 0x0001A358 File Offset: 0x00018558
		// (set) Token: 0x060000FB RID: 251 RVA: 0x0001A40C File Offset: 0x0001860C
		public int MonitorOnAnnouncementID_A22254Value
		{
			get
			{
				short num = (short)834432432;
				short num2 = num;
				num = (short)239889840;
				switch (num2 == num)
				{
				}
				num = (short)268107776;
				short num3 = num;
				num = (short)1630797824;
				if (num != 0)
				{
				}
				num = (short)512032769;
				if (num != 0)
				{
				}
				return this.monitorOnAnnouncementID_A22254.Value;
			}
			set
			{
				short num = (short)247039206;
				short num2 = num;
				num = (short)750224614;
				switch (num2 == num)
				{
				}
				num = (short)946077696;
				short num3 = num;
				num = (short)1450770433;
				if (num != 0)
				{
				}
				num = (short)102367232;
				if (num != 0)
				{
				}
				this.monitorOnAnnouncementID_A22254.Value = value;
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060000FC RID: 252 RVA: 0x0001A4C0 File Offset: 0x000186C0
		// (set) Token: 0x060000FD RID: 253 RVA: 0x0001A574 File Offset: 0x00018774
		public string MonitorOnAnnouncementID_A22254_UIValue
		{
			get
			{
				short num = (short)1839431655;
				short num2 = num;
				num = (short)1105428455;
				switch (num2 == num)
				{
				}
				num = (short)450691072;
				short num3 = num;
				num = (short)562298881;
				if (num != 0)
				{
				}
				num = (short)1264123904;
				if (num != 0)
				{
				}
				return this.monitorOnAnnouncementID_A22254.UIValue;
			}
			set
			{
				short num = (short)2078640942;
				short num2 = num;
				num = (short)930646830;
				switch (num2 == num)
				{
				}
				num = (short)877068288;
				short num3 = num;
				num = (short)1917714432;
				if (num != 0)
				{
				}
				num = (short)497418241;
				if (num != 0)
				{
				}
				this.monitorOnAnnouncementID_A22254.UIValue = value;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060000FE RID: 254 RVA: 0x0001A62C File Offset: 0x0001882C
		public global::AcpBusinessLayer.AcpRecRefField MonitorOnAnnouncementID_A22254
		{
			get
			{
				short num = (short)748590668;
				short num2 = num;
				num = (short)1503041100;
				switch (num2 == num)
				{
				}
				num = (short)1451753472;
				short num3 = num;
				num = (short)724762625;
				if (num != 0)
				{
				}
				num = (short)2021851136;
				if (num != 0)
				{
				}
				return this.monitorOnAnnouncementID_A22254;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060000FF RID: 255 RVA: 0x0001A6DC File Offset: 0x000188DC
		// (set) Token: 0x06000100 RID: 256 RVA: 0x0001A78C File Offset: 0x0001898C
		public bool MonitorOnAnnouncementID_A22254_Applicable
		{
			get
			{
				short num = (short)536658108;
				short num2 = num;
				num = (short)417906876;
				switch (num2 == num)
				{
				}
				num = (short)1729888256;
				short num3 = num;
				num = (short)201064449;
				if (num != 0)
				{
				}
				num = (short)1216348160;
				if (num != 0)
				{
				}
				return this.monitorOnAnnouncementID_A22254.Applicable;
			}
			set
			{
				short num = (short)1475450237;
				short num2 = num;
				num = (short)1132500349;
				switch (num2 == num)
				{
				}
				num = (short)1942355968;
				short num3 = num;
				num = (short)68222977;
				if (num != 0)
				{
				}
				num = (short)1999896576;
				if (num != 0)
				{
				}
				this.monitorOnAnnouncementID_A22254.Applicable = value;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000101 RID: 257 RVA: 0x0001A840 File Offset: 0x00018A40
		// (set) Token: 0x06000102 RID: 258 RVA: 0x0001A8F8 File Offset: 0x00018AF8
		public bool MonitorOnAnnouncementID_A22254_Valid
		{
			get
			{
				short num = (short)1328480257;
				if (num != 0)
				{
				}
				num = (short)533765777;
				short num2 = num;
				num = (short)755342993;
				switch (num2 == num)
				{
				default:
				{
					num = (short)861339648;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1697775616;
				if (num != 0)
				{
				}
				return this.monitorOnAnnouncementID_A22254.Valid;
			}
			set
			{
				short num = (short)383778817;
				if (num != 0)
				{
				}
				num = (short)1371066643;
				short num2 = num;
				num = (short)1131073811;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1480720384;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1898971136;
				if (num != 0)
				{
				}
				this.monitorOnAnnouncementID_A22254.Valid = value;
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000103 RID: 259 RVA: 0x0001A9B0 File Offset: 0x00018BB0
		// (set) Token: 0x06000104 RID: 260 RVA: 0x0001AA68 File Offset: 0x00018C68
		public bool MonitorOnAnnouncementID_A22254_Visible
		{
			get
			{
				short num = (short)1767135827;
				short num2 = num;
				num = (short)1975147091;
				switch (num2 == num)
				{
				}
				num = (short)1164705792;
				short num3 = num;
				num = (short)745799680;
				if (num != 0)
				{
				}
				num = (short)1511849985;
				if (num != 0)
				{
				}
				return this.monitorOnAnnouncementID_A22254.Visible;
			}
			set
			{
				short num = (short)302776321;
				if (num != 0)
				{
				}
				num = (short)539727703;
				short num2 = num;
				num = (short)1240504151;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1231814656;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)412221440;
				if (num != 0)
				{
				}
				this.monitorOnAnnouncementID_A22254.Visible = value;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000105 RID: 261 RVA: 0x0001AB1C File Offset: 0x00018D1C
		// (set) Token: 0x06000106 RID: 262 RVA: 0x0001ABD0 File Offset: 0x00018DD0
		public bool MonitorOnAnnouncementID_A22254_Editable
		{
			get
			{
				short num = (short)539798855;
				short num2 = num;
				num = (short)1049406791;
				switch (num2 == num)
				{
				}
				num = (short)196935680;
				short num3 = num;
				num = (short)273416193;
				if (num != 0)
				{
				}
				num = (short)1008009216;
				if (num != 0)
				{
				}
				return this.monitorOnAnnouncementID_A22254.Editable;
			}
			set
			{
				short num = (short)1671485648;
				short num2 = num;
				num = (short)560126160;
				switch (num2 == num)
				{
				}
				num = (short)1681653760;
				short num3 = num;
				num = (short)206045185;
				if (num != 0)
				{
				}
				num = (short)851378176;
				if (num != 0)
				{
				}
				this.monitorOnAnnouncementID_A22254.Editable = value;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000107 RID: 263 RVA: 0x0001AC88 File Offset: 0x00018E88
		internal string MonitorOnAnnouncementID_A22254_UILabel
		{
			get
			{
				short num = (short)1056886262;
				short num2 = num;
				num = (short)590597622;
				switch (num2 == num)
				{
				}
				num = (short)1219756032;
				short num3 = num;
				num = (short)2051342336;
				if (num != 0)
				{
				}
				num = (short)1248591873;
				if (num != 0)
				{
				}
				return this.monitorOnAnnouncementID_A22254.UIName;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000108 RID: 264 RVA: 0x0001AD3C File Offset: 0x00018F3C
		// (set) Token: 0x06000109 RID: 265 RVA: 0x0001ADF0 File Offset: 0x00018FF0
		internal bool MonitorOnAnnouncementID_A22254_HiddenStatic
		{
			get
			{
				short num = (short)1366385993;
				short num2 = num;
				num = (short)988833097;
				switch (num2 == num)
				{
				}
				num = (short)2105671680;
				short num3 = num;
				num = (short)100859905;
				if (num != 0)
				{
				}
				num = (short)1786773504;
				if (num != 0)
				{
				}
				return this.monitorOnAnnouncementID_A22254.HiddenStatic;
			}
			set
			{
				short num = (short)1206031921;
				short num2 = num;
				num = (short)792827441;
				switch (num2 == num)
				{
				}
				num = (short)550305792;
				short num3 = num;
				num = (short)686751745;
				if (num != 0)
				{
				}
				num = (short)1574305792;
				if (num != 0)
				{
				}
				this.monitorOnAnnouncementID_A22254.HiddenStatic = value;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x0600010A RID: 266 RVA: 0x0001AEA4 File Offset: 0x000190A4
		// (set) Token: 0x0600010B RID: 267 RVA: 0x0001AF58 File Offset: 0x00019158
		internal bool MonitorOnAnnouncementID_A22254_HiddenDynamic
		{
			get
			{
				short num = (short)1686503425;
				if (num != 0)
				{
				}
				num = (short)1128128777;
				short num2 = num;
				num = (short)532603145;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1722548224;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)499449856;
				if (num != 0)
				{
				}
				return this.monitorOnAnnouncementID_A22254.HiddenDynamic;
			}
			set
			{
				short num = (short)1732870293;
				short num2 = num;
				num = (short)2049409173;
				switch (num2 == num)
				{
				}
				num = (short)1818099712;
				short num3 = num;
				num = (short)1129054208;
				if (num != 0)
				{
				}
				num = (short)178257921;
				if (num != 0)
				{
				}
				this.monitorOnAnnouncementID_A22254.HiddenDynamic = value;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x0600010C RID: 268 RVA: 0x0001B00C File Offset: 0x0001920C
		public bool MonitorOnAnnouncementID_A22254_HasDiffs
		{
			get
			{
				short num = (short)1182068176;
				short num2 = num;
				num = (short)62254544;
				switch (num2 == num)
				{
				}
				num = (short)1091829760;
				short num3 = num;
				num = (short)113836033;
				if (num != 0)
				{
				}
				num = (short)2087190528;
				if (num != 0)
				{
				}
				return this.monitorOnAnnouncementID_A22254._HasDiffs;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x0600010D RID: 269 RVA: 0x0001B0C4 File Offset: 0x000192C4
		// (set) Token: 0x0600010E RID: 270 RVA: 0x0001B178 File Offset: 0x00019378
		public int MonitorOffAnnouncementID_A22256Value
		{
			get
			{
				short num = (short)1474182047;
				short num2 = num;
				num = (short)1006255007;
				switch (num2 == num)
				{
				}
				num = (short)319225856;
				short num3 = num;
				num = (short)905248769;
				if (num != 0)
				{
				}
				num = (short)1809776640;
				if (num != 0)
				{
				}
				return this.monitorOffAnnouncementID_A22256.Value;
			}
			set
			{
				short num = (short)14272197;
				short num2 = num;
				num = (short)84657861;
				switch (num2 == num)
				{
				}
				num = (short)1182531584;
				short num3 = num;
				num = (short)2054619137;
				if (num != 0)
				{
				}
				num = (short)2131427328;
				if (num != 0)
				{
				}
				this.monitorOffAnnouncementID_A22256.Value = value;
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x0600010F RID: 271 RVA: 0x0001B22C File Offset: 0x0001942C
		// (set) Token: 0x06000110 RID: 272 RVA: 0x0001B2E0 File Offset: 0x000194E0
		public string MonitorOffAnnouncementID_A22256_UIValue
		{
			get
			{
				short num = (short)1396733007;
				short num2 = num;
				num = (short)935031887;
				switch (num2 == num)
				{
				}
				num = (short)1974665216;
				short num3 = num;
				num = (short)790822913;
				if (num != 0)
				{
				}
				num = (short)1762721792;
				if (num != 0)
				{
				}
				return this.monitorOffAnnouncementID_A22256.UIValue;
			}
			set
			{
				short num = (short)1696713659;
				short num2 = num;
				num = (short)738577339;
				switch (num2 == num)
				{
				}
				num = (short)1458634752;
				short num3 = num;
				num = (short)952958976;
				if (num != 0)
				{
				}
				num = (short)319815681;
				if (num != 0)
				{
				}
				this.monitorOffAnnouncementID_A22256.UIValue = value;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000111 RID: 273 RVA: 0x0001B394 File Offset: 0x00019594
		public global::AcpBusinessLayer.AcpRecRefField MonitorOffAnnouncementID_A22256
		{
			get
			{
				short num = (short)1129682879;
				short num2 = num;
				num = (short)2103023551;
				switch (num2 == num)
				{
				}
				num = (short)2033713152;
				short num3 = num;
				num = (short)541261824;
				if (num != 0)
				{
				}
				num = (short)598736897;
				if (num != 0)
				{
				}
				return this.monitorOffAnnouncementID_A22256;
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000112 RID: 274 RVA: 0x0001B444 File Offset: 0x00019644
		// (set) Token: 0x06000113 RID: 275 RVA: 0x0001B4F8 File Offset: 0x000196F8
		public bool MonitorOffAnnouncementID_A22256_Applicable
		{
			get
			{
				short num = (short)1716315865;
				short num2 = num;
				num = (short)1772283609;
				switch (num2 == num)
				{
				}
				num = (short)1217724416;
				short num3 = num;
				num = (short)1992687617;
				if (num != 0)
				{
				}
				num = (short)705429504;
				if (num != 0)
				{
				}
				return this.monitorOffAnnouncementID_A22256.Applicable;
			}
			set
			{
				short num = (short)662072362;
				short num2 = num;
				num = (short)1278176298;
				switch (num2 == num)
				{
				}
				num = (short)1325858816;
				short num3 = num;
				num = (short)1748697089;
				if (num != 0)
				{
				}
				num = (short)702021632;
				if (num != 0)
				{
				}
				this.monitorOffAnnouncementID_A22256.Applicable = value;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000114 RID: 276 RVA: 0x0001B5AC File Offset: 0x000197AC
		// (set) Token: 0x06000115 RID: 277 RVA: 0x0001B660 File Offset: 0x00019860
		public bool MonitorOffAnnouncementID_A22256_Valid
		{
			get
			{
				short num = (short)1407111622;
				short num2 = num;
				num = (short)1576587718;
				switch (num2 == num)
				{
				}
				num = (short)836108288;
				short num3 = num;
				num = (short)241696769;
				if (num != 0)
				{
				}
				num = (short)1797652480;
				if (num != 0)
				{
				}
				return this.monitorOffAnnouncementID_A22256.Valid;
			}
			set
			{
				short num = (short)1203839537;
				short num2 = num;
				num = (short)751116849;
				switch (num2 == num)
				{
				}
				num = (short)2001338368;
				short num3 = num;
				num = (short)1275199489;
				if (num != 0)
				{
				}
				num = (short)66387968;
				if (num != 0)
				{
				}
				this.monitorOffAnnouncementID_A22256.Valid = value;
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000116 RID: 278 RVA: 0x0001B714 File Offset: 0x00019914
		// (set) Token: 0x06000117 RID: 279 RVA: 0x0001B7C8 File Offset: 0x000199C8
		public bool MonitorOffAnnouncementID_A22256_Visible
		{
			get
			{
				short num = (short)1736292272;
				short num2 = num;
				num = (short)2032056240;
				switch (num2 == num)
				{
				}
				num = (short)1517682688;
				short num3 = num;
				num = (short)2137718784;
				if (num != 0)
				{
				}
				num = (short)2053570561;
				if (num != 0)
				{
				}
				return this.monitorOffAnnouncementID_A22256.Visible;
			}
			set
			{
				short num = (short)1738456661;
				short num2 = num;
				num = (short)1229373013;
				switch (num2 == num)
				{
				}
				num = (short)959512576;
				short num3 = num;
				num = (short)594542593;
				if (num != 0)
				{
				}
				num = (short)1970798592;
				if (num != 0)
				{
				}
				this.monitorOffAnnouncementID_A22256.Visible = value;
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000118 RID: 280 RVA: 0x0001B87C File Offset: 0x00019A7C
		// (set) Token: 0x06000119 RID: 281 RVA: 0x0001B930 File Offset: 0x00019B30
		public bool MonitorOffAnnouncementID_A22256_Editable
		{
			get
			{
				short num = (short)1818373123;
				short num2 = num;
				num = (short)382348291;
				switch (num2 == num)
				{
				}
				num = (short)349962240;
				short num3 = num;
				num = (short)151584769;
				if (num != 0)
				{
				}
				num = (short)1755906048;
				if (num != 0)
				{
				}
				return this.monitorOffAnnouncementID_A22256.Editable;
			}
			set
			{
				short num = (short)1539515531;
				short num2 = num;
				num = (short)626730123;
				switch (num2 == num)
				{
				}
				num = (short)510787584;
				short num3 = num;
				num = (short)878313473;
				if (num != 0)
				{
				}
				num = (short)1380712448;
				if (num != 0)
				{
				}
				this.monitorOffAnnouncementID_A22256.Editable = value;
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x0600011A RID: 282 RVA: 0x0001B9E8 File Offset: 0x00019BE8
		internal string MonitorOffAnnouncementID_A22256_UILabel
		{
			get
			{
				short num = (short)2069061547;
				short num2 = num;
				num = (short)917004203;
				switch (num2 == num)
				{
				}
				num = (short)111673344;
				short num3 = num;
				num = (short)952827905;
				if (num != 0)
				{
				}
				num = (short)1779564544;
				if (num != 0)
				{
				}
				return this.monitorOffAnnouncementID_A22256.UIName;
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x0600011B RID: 283 RVA: 0x0001BA98 File Offset: 0x00019C98
		// (set) Token: 0x0600011C RID: 284 RVA: 0x0001BB48 File Offset: 0x00019D48
		internal bool MonitorOffAnnouncementID_A22256_HiddenStatic
		{
			get
			{
				short num = (short)2082455798;
				short num2 = num;
				num = (short)731037942;
				switch (num2 == num)
				{
				}
				num = (short)1433600000;
				short num3 = num;
				num = (short)459210753;
				if (num != 0)
				{
				}
				num = (short)856424448;
				if (num != 0)
				{
				}
				return this.monitorOffAnnouncementID_A22256.HiddenStatic;
			}
			set
			{
				short num = (short)1356339037;
				short num2 = num;
				num = (short)1109464925;
				switch (num2 == num)
				{
				}
				num = (short)1841299456;
				short num3 = num;
				num = (short)46006272;
				if (num != 0)
				{
				}
				num = (short)1561395201;
				if (num != 0)
				{
				}
				this.monitorOffAnnouncementID_A22256.HiddenStatic = value;
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x0600011D RID: 285 RVA: 0x0001BBFC File Offset: 0x00019DFC
		// (set) Token: 0x0600011E RID: 286 RVA: 0x0001BCAC File Offset: 0x00019EAC
		internal bool MonitorOffAnnouncementID_A22256_HiddenDynamic
		{
			get
			{
				short num = (short)349679477;
				short num2 = num;
				num = (short)1936437109;
				switch (num2 == num)
				{
				}
				num = (short)70385664;
				short num3 = num;
				num = (short)1964834816;
				if (num != 0)
				{
				}
				num = (short)703266817;
				if (num != 0)
				{
				}
				return this.monitorOffAnnouncementID_A22256.HiddenDynamic;
			}
			set
			{
				short num = (short)712203753;
				short num2 = num;
				num = (short)240344553;
				switch (num2 == num)
				{
				}
				num = (short)1350828032;
				short num3 = num;
				num = (short)29229057;
				if (num != 0)
				{
				}
				num = (short)1535442944;
				if (num != 0)
				{
				}
				this.monitorOffAnnouncementID_A22256.HiddenDynamic = value;
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x0600011F RID: 287 RVA: 0x0001BD64 File Offset: 0x00019F64
		public bool MonitorOffAnnouncementID_A22256_HasDiffs
		{
			get
			{
				short num = (short)1272258616;
				short num2 = num;
				num = (short)543236152;
				switch (num2 == num)
				{
				}
				num = (short)817496064;
				short num3 = num;
				num = (short)1383727105;
				if (num != 0)
				{
				}
				num = (short)1803616256;
				if (num != 0)
				{
				}
				return this.monitorOffAnnouncementID_A22256._HasDiffs;
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000120 RID: 288 RVA: 0x0001BE1C File Offset: 0x0001A01C
		// (set) Token: 0x06000121 RID: 289 RVA: 0x0001BED0 File Offset: 0x0001A0D0
		public int DirectModeOnAnnouncementID_A22258Value
		{
			get
			{
				short num = (short)1025347790;
				short num2 = num;
				num = (short)1025675470;
				switch (num2 == num)
				{
				}
				num = (short)1843331072;
				short num3 = num;
				num = (short)918618113;
				if (num != 0)
				{
				}
				num = (short)1203765248;
				if (num != 0)
				{
				}
				return this.directModeOnAnnouncementID_A22258.Value;
			}
			set
			{
				short num = (short)1206249081;
				short num2 = num;
				num = (short)1998448249;
				switch (num2 == num)
				{
				}
				num = (short)114688000;
				short num3 = num;
				num = (short)1875574784;
				if (num != 0)
				{
				}
				num = (short)103940097;
				if (num != 0)
				{
				}
				this.directModeOnAnnouncementID_A22258.Value = value;
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000122 RID: 290 RVA: 0x0001BF84 File Offset: 0x0001A184
		// (set) Token: 0x06000123 RID: 291 RVA: 0x0001C034 File Offset: 0x0001A234
		public string DirectModeOnAnnouncementID_A22258_UIValue
		{
			get
			{
				short num = (short)963978568;
				short num2 = num;
				num = (short)1284056392;
				switch (num2 == num)
				{
				}
				num = (short)1326841856;
				short num3 = num;
				num = (short)580911104;
				if (num != 0)
				{
				}
				num = (short)558891009;
				if (num != 0)
				{
				}
				return this.directModeOnAnnouncementID_A22258.UIValue;
			}
			set
			{
				short num = (short)967058667;
				short num2 = num;
				num = (short)1913660651;
				switch (num2 == num)
				{
				}
				num = (short)997982208;
				short num3 = num;
				num = (short)428343297;
				if (num != 0)
				{
				}
				num = (short)1007878144;
				if (num != 0)
				{
				}
				this.directModeOnAnnouncementID_A22258.UIValue = value;
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000124 RID: 292 RVA: 0x0001C0EC File Offset: 0x0001A2EC
		public global::AcpBusinessLayer.AcpRecRefField DirectModeOnAnnouncementID_A22258
		{
			get
			{
				short num = (short)1632170734;
				short num2 = num;
				num = (short)725545710;
				switch (num2 == num)
				{
				}
				num = (short)1147928576;
				short num3 = num;
				num = (short)1203896321;
				if (num != 0)
				{
				}
				num = (short)381485056;
				if (num != 0)
				{
				}
				return this.directModeOnAnnouncementID_A22258;
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000125 RID: 293 RVA: 0x0001C1A0 File Offset: 0x0001A3A0
		// (set) Token: 0x06000126 RID: 294 RVA: 0x0001C254 File Offset: 0x0001A454
		public bool DirectModeOnAnnouncementID_A22258_Applicable
		{
			get
			{
				short num = (short)707939262;
				short num2 = num;
				num = (short)715672510;
				switch (num2 == num)
				{
				}
				num = (short)216530944;
				short num3 = num;
				num = (short)1945370625;
				if (num != 0)
				{
				}
				num = (short)482803712;
				if (num != 0)
				{
				}
				return this.directModeOnAnnouncementID_A22258.Applicable;
			}
			set
			{
				short num = (short)327816724;
				short num2 = num;
				num = (short)724768276;
				switch (num2 == num)
				{
				}
				num = (short)455802880;
				short num3 = num;
				num = (short)533987329;
				if (num != 0)
				{
				}
				num = (short)369754112;
				if (num != 0)
				{
				}
				this.directModeOnAnnouncementID_A22258.Applicable = value;
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000127 RID: 295 RVA: 0x0001C30C File Offset: 0x0001A50C
		// (set) Token: 0x06000128 RID: 296 RVA: 0x0001C3C0 File Offset: 0x0001A5C0
		public bool DirectModeOnAnnouncementID_A22258_Valid
		{
			get
			{
				short num = (short)774133083;
				short num2 = num;
				num = (short)849237339;
				switch (num2 == num)
				{
				}
				num = (short)131596288;
				short num3 = num;
				num = (short)1159135233;
				if (num != 0)
				{
				}
				num = (short)131727360;
				if (num != 0)
				{
				}
				return this.directModeOnAnnouncementID_A22258.Valid;
			}
			set
			{
				short num = (short)1419517347;
				short num2 = num;
				num = (short)223157667;
				switch (num2 == num)
				{
				}
				num = (short)1746272256;
				short num3 = num;
				num = (short)1858273280;
				if (num != 0)
				{
				}
				num = (short)863109121;
				if (num != 0)
				{
				}
				this.directModeOnAnnouncementID_A22258.Valid = value;
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000129 RID: 297 RVA: 0x0001C478 File Offset: 0x0001A678
		// (set) Token: 0x0600012A RID: 298 RVA: 0x0001C52C File Offset: 0x0001A72C
		public bool DirectModeOnAnnouncementID_A22258_Visible
		{
			get
			{
				short num = (short)122683393;
				if (num != 0)
				{
				}
				num = (short)15649874;
				short num2 = num;
				num = (short)1002490962;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2051670016;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1204158464;
				if (num != 0)
				{
				}
				return this.directModeOnAnnouncementID_A22258.Visible;
			}
			set
			{
				short num = (short)1769970242;
				short num2 = num;
				num = (short)941660738;
				switch (num2 == num)
				{
				}
				num = (short)1016332288;
				short num3 = num;
				num = (short)1854996481;
				if (num != 0)
				{
				}
				num = (short)308674560;
				if (num != 0)
				{
				}
				this.directModeOnAnnouncementID_A22258.Visible = value;
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x0600012B RID: 299 RVA: 0x0001C5E0 File Offset: 0x0001A7E0
		// (set) Token: 0x0600012C RID: 300 RVA: 0x0001C698 File Offset: 0x0001A898
		public bool DirectModeOnAnnouncementID_A22258_Editable
		{
			get
			{
				short num = (short)840892417;
				if (num != 0)
				{
				}
				num = (short)1493578832;
				short num2 = num;
				num = (short)1164915792;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1913389056;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)487718912;
				if (num != 0)
				{
				}
				return this.directModeOnAnnouncementID_A22258.Editable;
			}
			set
			{
				short num = (short)203543378;
				short num2 = num;
				num = (short)602788690;
				switch (num2 == num)
				{
				}
				num = (short)2089746432;
				short num3 = num;
				num = (short)29556737;
				if (num != 0)
				{
				}
				num = (short)751108096;
				if (num != 0)
				{
				}
				this.directModeOnAnnouncementID_A22258.Editable = value;
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x0600012D RID: 301 RVA: 0x0001C750 File Offset: 0x0001A950
		internal string DirectModeOnAnnouncementID_A22258_UILabel
		{
			get
			{
				short num = (short)487963011;
				short num2 = num;
				num = (short)56539523;
				switch (num2 == num)
				{
				}
				num = (short)464912384;
				short num3 = num;
				num = (short)1997144065;
				if (num != 0)
				{
				}
				num = (short)74842112;
				if (num != 0)
				{
				}
				return this.directModeOnAnnouncementID_A22258.UIName;
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x0600012E RID: 302 RVA: 0x0001C804 File Offset: 0x0001AA04
		// (set) Token: 0x0600012F RID: 303 RVA: 0x0001C8B8 File Offset: 0x0001AAB8
		internal bool DirectModeOnAnnouncementID_A22258_HiddenStatic
		{
			get
			{
				short num = (short)917593703;
				short num2 = num;
				num = (short)506420839;
				switch (num2 == num)
				{
				}
				num = (short)753467392;
				short num3 = num;
				num = (short)1251147777;
				if (num != 0)
				{
				}
				num = (short)227934208;
				if (num != 0)
				{
				}
				return this.directModeOnAnnouncementID_A22258.HiddenStatic;
			}
			set
			{
				short num = (short)1033495564;
				short num2 = num;
				num = (short)753394700;
				switch (num2 == num)
				{
				}
				num = (short)436862976;
				short num3 = num;
				num = (short)1864105984;
				if (num != 0)
				{
				}
				num = (short)229572609;
				if (num != 0)
				{
				}
				this.directModeOnAnnouncementID_A22258.HiddenStatic = value;
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000130 RID: 304 RVA: 0x0001C96C File Offset: 0x0001AB6C
		// (set) Token: 0x06000131 RID: 305 RVA: 0x0001CA20 File Offset: 0x0001AC20
		internal bool DirectModeOnAnnouncementID_A22258_HiddenDynamic
		{
			get
			{
				short num = (short)1247345286;
				short num2 = num;
				num = (short)340982406;
				switch (num2 == num)
				{
				}
				num = (short)1654325248;
				short num3 = num;
				num = (short)674037761;
				if (num != 0)
				{
				}
				num = (short)587268096;
				if (num != 0)
				{
				}
				return this.directModeOnAnnouncementID_A22258.HiddenDynamic;
			}
			set
			{
				short num = (short)1057749345;
				short num2 = num;
				num = (short)1586690401;
				switch (num2 == num)
				{
				}
				num = (short)752287744;
				short num3 = num;
				num = (short)839909377;
				if (num != 0)
				{
				}
				num = (short)1336279040;
				if (num != 0)
				{
				}
				this.directModeOnAnnouncementID_A22258.HiddenDynamic = value;
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000132 RID: 306 RVA: 0x0001CAD4 File Offset: 0x0001ACD4
		public bool DirectModeOnAnnouncementID_A22258_HasDiffs
		{
			get
			{
				short num = (short)246528299;
				short num2 = num;
				num = (short)1166915883;
				switch (num2 == num)
				{
				}
				num = (short)624099328;
				short num3 = num;
				num = (short)505217024;
				if (num != 0)
				{
				}
				num = (short)1476263937;
				if (num != 0)
				{
				}
				return this.directModeOnAnnouncementID_A22258._HasDiffs;
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000133 RID: 307 RVA: 0x0001CB8C File Offset: 0x0001AD8C
		// (set) Token: 0x06000134 RID: 308 RVA: 0x0001CC40 File Offset: 0x0001AE40
		public int DirectModeOffAnnouncementID_A22121Value
		{
			get
			{
				short num = (short)973727784;
				short num2 = num;
				num = (short)950396968;
				switch (num2 == num)
				{
				}
				num = (short)1248722944;
				short num3 = num;
				num = (short)64487425;
				if (num != 0)
				{
				}
				num = (short)872677376;
				if (num != 0)
				{
				}
				return this.directModeOffAnnouncementID_A22121.Value;
			}
			set
			{
				short num = (short)1493935188;
				short num2 = num;
				num = (short)1308468308;
				switch (num2 == num)
				{
				}
				num = (short)717684736;
				short num3 = num;
				num = (short)1358561281;
				if (num != 0)
				{
				}
				num = (short)438370304;
				if (num != 0)
				{
				}
				this.directModeOffAnnouncementID_A22121.Value = value;
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000135 RID: 309 RVA: 0x0001CCF4 File Offset: 0x0001AEF4
		// (set) Token: 0x06000136 RID: 310 RVA: 0x0001CDAC File Offset: 0x0001AFAC
		public string DirectModeOffAnnouncementID_A22121_UIValue
		{
			get
			{
				short num = (short)551889442;
				short num2 = num;
				num = (short)848308770;
				switch (num2 == num)
				{
				}
				num = (short)2003697664;
				short num3 = num;
				num = (short)1637941249;
				if (num != 0)
				{
				}
				num = (short)1207107584;
				if (num != 0)
				{
				}
				return this.directModeOffAnnouncementID_A22121.UIValue;
			}
			set
			{
				short num = (short)543162369;
				if (num != 0)
				{
				}
				num = (short)980152053;
				short num2 = num;
				num = (short)1289350901;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1129775104;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)856621056;
				if (num != 0)
				{
				}
				this.directModeOffAnnouncementID_A22121.UIValue = value;
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000137 RID: 311 RVA: 0x0001CE60 File Offset: 0x0001B060
		public global::AcpBusinessLayer.AcpRecRefField DirectModeOffAnnouncementID_A22121
		{
			get
			{
				short num = (short)238777163;
				short num2 = num;
				num = (short)586117963;
				switch (num2 == num)
				{
				}
				num = (short)577306625;
				if (num != 0)
				{
				}
				num = (short)1963196416;
				if (num != 0)
				{
				}
				num = (short)1585774592;
				short num3 = num;
				return this.directModeOffAnnouncementID_A22121;
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000138 RID: 312 RVA: 0x0001CF10 File Offset: 0x0001B110
		// (set) Token: 0x06000139 RID: 313 RVA: 0x0001CFC0 File Offset: 0x0001B1C0
		public bool DirectModeOffAnnouncementID_A22121_Applicable
		{
			get
			{
				short num = (short)181724896;
				short num2 = num;
				num = (short)1115219680;
				switch (num2 == num)
				{
				}
				num = (short)586743809;
				if (num != 0)
				{
				}
				num = (short)815136768;
				if (num != 0)
				{
				}
				num = (short)276692992;
				short num3 = num;
				return this.directModeOffAnnouncementID_A22121.Applicable;
			}
			set
			{
				short num = (short)2074546877;
				short num2 = num;
				num = (short)1664946877;
				switch (num2 == num)
				{
				}
				num = (short)1369899009;
				if (num != 0)
				{
				}
				num = (short)801505280;
				if (num != 0)
				{
				}
				num = (short)422117376;
				short num3 = num;
				this.directModeOffAnnouncementID_A22121.Applicable = value;
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x0600013A RID: 314 RVA: 0x0001D074 File Offset: 0x0001B274
		// (set) Token: 0x0600013B RID: 315 RVA: 0x0001D128 File Offset: 0x0001B328
		public bool DirectModeOffAnnouncementID_A22121_Valid
		{
			get
			{
				short num = (short)597503568;
				short num2 = num;
				num = (short)1945841232;
				switch (num2 == num)
				{
				}
				num = (short)551616513;
				if (num != 0)
				{
				}
				num = (short)1763901440;
				if (num != 0)
				{
				}
				num = (short)1312555008;
				short num3 = num;
				return this.directModeOffAnnouncementID_A22121.Valid;
			}
			set
			{
				short num = (short)462254795;
				short num2 = num;
				num = (short)2127721163;
				switch (num2 == num)
				{
				}
				num = (short)1665662977;
				if (num != 0)
				{
				}
				num = (short)1359347712;
				if (num != 0)
				{
				}
				num = (short)1245839360;
				short num3 = num;
				this.directModeOffAnnouncementID_A22121.Valid = value;
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x0600013C RID: 316 RVA: 0x0001D1E0 File Offset: 0x0001B3E0
		// (set) Token: 0x0600013D RID: 317 RVA: 0x0001D294 File Offset: 0x0001B494
		public bool DirectModeOffAnnouncementID_A22121_Visible
		{
			get
			{
				short num = (short)463228316;
				short num2 = num;
				num = (short)1532710300;
				switch (num2 == num)
				{
				}
				num = (short)1428553728;
				if (num != 0)
				{
				}
				num = (short)1114046465;
				if (num != 0)
				{
				}
				num = (short)352124928;
				short num3 = num;
				return this.directModeOffAnnouncementID_A22121.Visible;
			}
			set
			{
				short num = (short)268238849;
				if (num != 0)
				{
				}
				num = (short)833558490;
				short num2 = num;
				num = (short)2047547354;
				switch (num2 == num)
				{
				}
				num = (short)1362558976;
				if (num != 0)
				{
				}
				num = (short)908984320;
				short num3 = num;
				this.directModeOffAnnouncementID_A22121.Visible = value;
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x0600013E RID: 318 RVA: 0x0001D34C File Offset: 0x0001B54C
		// (set) Token: 0x0600013F RID: 319 RVA: 0x0001D404 File Offset: 0x0001B604
		public bool DirectModeOffAnnouncementID_A22121_Editable
		{
			get
			{
				short num = (short)717862552;
				short num2 = num;
				num = (short)246331032;
				switch (num2 == num)
				{
				}
				num = (short)1133576193;
				if (num != 0)
				{
				}
				num = (short)1447231488;
				if (num != 0)
				{
				}
				num = (short)286130176;
				short num3 = num;
				return this.directModeOffAnnouncementID_A22121.Editable;
			}
			set
			{
				short num = (short)1916515796;
				short num2 = num;
				num = (short)1266136532;
				switch (num2 == num)
				{
				}
				num = (short)2127626241;
				if (num != 0)
				{
				}
				num = (short)1536163840;
				if (num != 0)
				{
				}
				num = (short)1932918784;
				short num3 = num;
				this.directModeOffAnnouncementID_A22121.Editable = value;
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000140 RID: 320 RVA: 0x0001D4B8 File Offset: 0x0001B6B8
		internal string DirectModeOffAnnouncementID_A22121_UILabel
		{
			get
			{
				short num = (short)1111767111;
				short num2 = num;
				num = (short)1298282567;
				switch (num2 == num)
				{
				}
				num = (short)379846657;
				if (num != 0)
				{
				}
				num = (short)817954816;
				if (num != 0)
				{
				}
				num = (short)1931214848;
				short num3 = num;
				return this.directModeOffAnnouncementID_A22121.UIName;
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000141 RID: 321 RVA: 0x0001D56C File Offset: 0x0001B76C
		// (set) Token: 0x06000142 RID: 322 RVA: 0x0001D624 File Offset: 0x0001B824
		internal bool DirectModeOffAnnouncementID_A22121_HiddenStatic
		{
			get
			{
				short num = (short)1640612049;
				short num2 = num;
				num = (short)493994193;
				switch (num2 == num)
				{
				}
				num = (short)2061172737;
				if (num != 0)
				{
				}
				num = (short)1139408896;
				if (num != 0)
				{
				}
				num = (short)1399848960;
				short num3 = num;
				return this.directModeOffAnnouncementID_A22121.HiddenStatic;
			}
			set
			{
				short num = (short)444919750;
				short num2 = num;
				num = (short)1205006278;
				switch (num2 == num)
				{
				}
				num = (short)28835841;
				if (num != 0)
				{
				}
				num = (short)253558784;
				if (num != 0)
				{
				}
				num = (short)1710686208;
				short num3 = num;
				this.directModeOffAnnouncementID_A22121.HiddenStatic = value;
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000143 RID: 323 RVA: 0x0001D6D8 File Offset: 0x0001B8D8
		// (set) Token: 0x06000144 RID: 324 RVA: 0x0001D790 File Offset: 0x0001B990
		internal bool DirectModeOffAnnouncementID_A22121_HiddenDynamic
		{
			get
			{
				short num = (short)627705686;
				short num2 = num;
				num = (short)679282518;
				switch (num2 == num)
				{
				}
				num = (short)1261568000;
				if (num != 0)
				{
				}
				num = (short)1788608513;
				if (num != 0)
				{
				}
				num = (short)1015611392;
				short num3 = num;
				return this.directModeOffAnnouncementID_A22121.HiddenDynamic;
			}
			set
			{
				short num = (short)124589655;
				short num2 = num;
				num = (short)124786263;
				switch (num2 == num)
				{
				}
				num = (short)544800769;
				if (num != 0)
				{
				}
				num = (short)1016135680;
				if (num != 0)
				{
				}
				num = (short)93388800;
				short num3 = num;
				this.directModeOffAnnouncementID_A22121.HiddenDynamic = value;
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000145 RID: 325 RVA: 0x0001D844 File Offset: 0x0001BA44
		public bool DirectModeOffAnnouncementID_A22121_HasDiffs
		{
			get
			{
				short num = (short)1553072129;
				if (num != 0)
				{
				}
				num = (short)1198039514;
				short num2 = num;
				num = (short)742564314;
				switch (num2 == num)
				{
				}
				num = (short)263913472;
				if (num != 0)
				{
				}
				num = (short)1818820608;
				short num3 = num;
				return this.directModeOffAnnouncementID_A22121._HasDiffs;
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000146 RID: 326 RVA: 0x0001D8F8 File Offset: 0x0001BAF8
		// (set) Token: 0x06000147 RID: 327 RVA: 0x0001D9AC File Offset: 0x0001BBAC
		public int TxInhibitOnAnnouncementID_A22260Value
		{
			get
			{
				short num = (short)1187217761;
				short num2 = num;
				num = (short)23757153;
				switch (num2 == num)
				{
				}
				num = (short)1274871808;
				if (num != 0)
				{
				}
				num = (short)583532545;
				if (num != 0)
				{
				}
				num = (short)1795555328;
				short num3 = num;
				return this.txInhibitOnAnnouncementID_A22260.Value;
			}
			set
			{
				short num = (short)906199036;
				short num2 = num;
				num = (short)271417340;
				switch (num2 == num)
				{
				}
				num = (short)416612353;
				if (num != 0)
				{
				}
				num = (short)1760296960;
				if (num != 0)
				{
				}
				num = (short)742326272;
				short num3 = num;
				this.txInhibitOnAnnouncementID_A22260.Value = value;
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000148 RID: 328 RVA: 0x0001DA5C File Offset: 0x0001BC5C
		// (set) Token: 0x06000149 RID: 329 RVA: 0x0001DB10 File Offset: 0x0001BD10
		public string TxInhibitOnAnnouncementID_A22260_UIValue
		{
			get
			{
				short num = (short)2096791979;
				short num2 = num;
				num = (short)1254982059;
				switch (num2 == num)
				{
				}
				num = (short)381550593;
				if (num != 0)
				{
				}
				num = (short)1658978304;
				if (num != 0)
				{
				}
				num = (short)862912512;
				short num3 = num;
				return this.txInhibitOnAnnouncementID_A22260.UIValue;
			}
			set
			{
				short num = (short)1160417662;
				short num2 = num;
				num = (short)1745654142;
				switch (num2 == num)
				{
				}
				num = (short)313393152;
				if (num != 0)
				{
				}
				num = (short)395247617;
				if (num != 0)
				{
				}
				num = (short)690225152;
				short num3 = num;
				this.txInhibitOnAnnouncementID_A22260.UIValue = value;
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x0600014A RID: 330 RVA: 0x0001DBC4 File Offset: 0x0001BDC4
		public global::AcpBusinessLayer.AcpRecRefField TxInhibitOnAnnouncementID_A22260
		{
			get
			{
				short num = (short)173559431;
				short num2 = num;
				num = (short)481513095;
				switch (num2 == num)
				{
				}
				num = (short)920322049;
				if (num != 0)
				{
				}
				num = (short)1284898816;
				if (num != 0)
				{
				}
				num = (short)374276096;
				short num3 = num;
				return this.txInhibitOnAnnouncementID_A22260;
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x0600014B RID: 331 RVA: 0x0001DC70 File Offset: 0x0001BE70
		// (set) Token: 0x0600014C RID: 332 RVA: 0x0001DD28 File Offset: 0x0001BF28
		public bool TxInhibitOnAnnouncementID_A22260_Applicable
		{
			get
			{
				short num = (short)148047220;
				short num2 = num;
				num = (short)2034435444;
				switch (num2 == num)
				{
				}
				num = (short)1521745921;
				if (num != 0)
				{
				}
				num = (short)688193536;
				if (num != 0)
				{
				}
				num = (short)61734912;
				short num3 = num;
				return this.txInhibitOnAnnouncementID_A22260.Applicable;
			}
			set
			{
				short num = (short)822773743;
				short num2 = num;
				num = (short)981436399;
				switch (num2 == num)
				{
				}
				num = (short)1854210049;
				if (num != 0)
				{
				}
				num = (short)423034880;
				if (num != 0)
				{
				}
				num = (short)1110441984;
				short num3 = num;
				this.txInhibitOnAnnouncementID_A22260.Applicable = value;
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x0600014D RID: 333 RVA: 0x0001DDDC File Offset: 0x0001BFDC
		// (set) Token: 0x0600014E RID: 334 RVA: 0x0001DE90 File Offset: 0x0001C090
		public bool TxInhibitOnAnnouncementID_A22260_Valid
		{
			get
			{
				short num = (short)285901664;
				short num2 = num;
				num = (short)2008056672;
				switch (num2 == num)
				{
				}
				num = (short)1952317441;
				if (num != 0)
				{
				}
				num = (short)1194721280;
				if (num != 0)
				{
				}
				num = (short)213385216;
				short num3 = num;
				return this.txInhibitOnAnnouncementID_A22260.Valid;
			}
			set
			{
				short num = (short)1298393859;
				short num2 = num;
				num = (short)219409155;
				switch (num2 == num)
				{
				}
				num = (short)1964113921;
				if (num != 0)
				{
				}
				num = (short)1918500864;
				if (num != 0)
				{
				}
				num = (short)182517760;
				short num3 = num;
				this.txInhibitOnAnnouncementID_A22260.Valid = value;
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x0600014F RID: 335 RVA: 0x0001DF48 File Offset: 0x0001C148
		// (set) Token: 0x06000150 RID: 336 RVA: 0x0001DFFC File Offset: 0x0001C1FC
		public bool TxInhibitOnAnnouncementID_A22260_Visible
		{
			get
			{
				short num = (short)1843032703;
				short num2 = num;
				num = (short)1136882303;
				switch (num2 == num)
				{
				}
				num = (short)1938620416;
				if (num != 0)
				{
				}
				num = (short)32636929;
				if (num != 0)
				{
				}
				num = (short)1599012864;
				short num3 = num;
				return this.txInhibitOnAnnouncementID_A22260.Visible;
			}
			set
			{
				short num = (short)220841508;
				short num2 = num;
				num = (short)1592182308;
				switch (num2 == num)
				{
				}
				num = (short)1885798400;
				if (num != 0)
				{
				}
				num = (short)1065680897;
				if (num != 0)
				{
				}
				num = (short)761266176;
				short num3 = num;
				this.txInhibitOnAnnouncementID_A22260.Visible = value;
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000151 RID: 337 RVA: 0x0001E0B0 File Offset: 0x0001C2B0
		// (set) Token: 0x06000152 RID: 338 RVA: 0x0001E164 File Offset: 0x0001C364
		public bool TxInhibitOnAnnouncementID_A22260_Editable
		{
			get
			{
				short num = (short)199261086;
				short num2 = num;
				num = (short)106068894;
				switch (num2 == num)
				{
				}
				num = (short)1515126785;
				if (num != 0)
				{
				}
				num = (short)1422327808;
				if (num != 0)
				{
				}
				num = (short)1536360448;
				short num3 = num;
				return this.txInhibitOnAnnouncementID_A22260.Editable;
			}
			set
			{
				short num = (short)1078969967;
				short num2 = num;
				num = (short)127125103;
				switch (num2 == num)
				{
				}
				num = (short)575864832;
				if (num != 0)
				{
				}
				num = (short)592576513;
				if (num != 0)
				{
				}
				num = (short)700907520;
				short num3 = num;
				this.txInhibitOnAnnouncementID_A22260.Editable = value;
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000153 RID: 339 RVA: 0x0001E21C File Offset: 0x0001C41C
		internal string TxInhibitOnAnnouncementID_A22260_UILabel
		{
			get
			{
				short num = (short)1151802876;
				short num2 = num;
				num = (short)585440764;
				switch (num2 == num)
				{
				}
				num = (short)1487863809;
				if (num != 0)
				{
				}
				num = (short)202375168;
				if (num != 0)
				{
				}
				num = (short)1438384128;
				short num3 = num;
				return this.txInhibitOnAnnouncementID_A22260.UIName;
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000154 RID: 340 RVA: 0x0001E2D0 File Offset: 0x0001C4D0
		// (set) Token: 0x06000155 RID: 341 RVA: 0x0001E388 File Offset: 0x0001C588
		internal bool TxInhibitOnAnnouncementID_A22260_HiddenStatic
		{
			get
			{
				short num = (short)1876492289;
				if (num != 0)
				{
				}
				num = (short)1412494922;
				short num2 = num;
				num = (short)243463754;
				switch (num2 == num)
				{
				}
				num = (short)346816512;
				if (num != 0)
				{
				}
				num = (short)1036189696;
				short num3 = num;
				return this.txInhibitOnAnnouncementID_A22260.HiddenStatic;
			}
			set
			{
				short num = (short)1788966337;
				short num2 = num;
				num = (short)595097025;
				switch (num2 == num)
				{
				}
				num = (short)208666625;
				if (num != 0)
				{
				}
				num = (short)214433792;
				if (num != 0)
				{
				}
				num = (short)792920064;
				short num3 = num;
				this.txInhibitOnAnnouncementID_A22260.HiddenStatic = value;
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000156 RID: 342 RVA: 0x0001E440 File Offset: 0x0001C640
		// (set) Token: 0x06000157 RID: 343 RVA: 0x0001E4F4 File Offset: 0x0001C6F4
		internal bool TxInhibitOnAnnouncementID_A22260_HiddenDynamic
		{
			get
			{
				short num = (short)1498708963;
				short num2 = num;
				num = (short)2123660259;
				switch (num2 == num)
				{
				}
				num = (short)122486785;
				if (num != 0)
				{
				}
				num = (short)754122752;
				if (num != 0)
				{
				}
				num = (short)1286340608;
				short num3 = num;
				return this.txInhibitOnAnnouncementID_A22260.HiddenDynamic;
			}
			set
			{
				short num = (short)1728603820;
				short num2 = num;
				num = (short)246441644;
				switch (num2 == num)
				{
				}
				num = (short)1987182593;
				if (num != 0)
				{
				}
				num = (short)1003814912;
				if (num != 0)
				{
				}
				num = (short)1589379072;
				short num3 = num;
				this.txInhibitOnAnnouncementID_A22260.HiddenDynamic = value;
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000158 RID: 344 RVA: 0x0001E5AC File Offset: 0x0001C7AC
		public bool TxInhibitOnAnnouncementID_A22260_HasDiffs
		{
			get
			{
				short num = (short)1255339908;
				short num2 = num;
				num = (short)322500484;
				switch (num2 == num)
				{
				}
				num = (short)969277440;
				if (num != 0)
				{
				}
				num = (short)1141571585;
				if (num != 0)
				{
				}
				num = (short)624951296;
				short num3 = num;
				return this.txInhibitOnAnnouncementID_A22260._HasDiffs;
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000159 RID: 345 RVA: 0x0001E664 File Offset: 0x0001C864
		// (set) Token: 0x0600015A RID: 346 RVA: 0x0001E71C File Offset: 0x0001C91C
		public int TxInhibitOffAnnouncementID_A22262Value
		{
			get
			{
				short num = (short)958706172;
				short num2 = num;
				num = (short)2091758076;
				switch (num2 == num)
				{
				}
				num = (short)1237319680;
				if (num != 0)
				{
				}
				num = (short)1933901825;
				if (num != 0)
				{
				}
				num = (short)1159593984;
				short num3 = num;
				return this.txInhibitOffAnnouncementID_A22262.Value;
			}
			set
			{
				short num = (short)790233089;
				if (num != 0)
				{
				}
				num = (short)627326474;
				short num2 = num;
				num = (short)1288846858;
				switch (num2 == num)
				{
				}
				num = (short)1182334976;
				if (num != 0)
				{
				}
				num = (short)1885601792;
				short num3 = num;
				this.txInhibitOffAnnouncementID_A22262.Value = value;
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x0600015B RID: 347 RVA: 0x0001E7D4 File Offset: 0x0001C9D4
		// (set) Token: 0x0600015C RID: 348 RVA: 0x0001E888 File Offset: 0x0001CA88
		public string TxInhibitOffAnnouncementID_A22262_UIValue
		{
			get
			{
				short num = (short)761061424;
				short num2 = num;
				num = (short)1015406640;
				switch (num2 == num)
				{
				}
				num = (short)562954240;
				if (num != 0)
				{
				}
				num = (short)912261121;
				if (num != 0)
				{
				}
				num = (short)955973632;
				short num3 = num;
				return this.txInhibitOffAnnouncementID_A22262.UIValue;
			}
			set
			{
				short num = (short)198770689;
				if (num != 0)
				{
				}
				num = (short)1788747118;
				short num2 = num;
				num = (short)50208110;
				switch (num2 == num)
				{
				}
				num = (short)1222639616;
				if (num != 0)
				{
				}
				num = (short)979435520;
				short num3 = num;
				this.txInhibitOffAnnouncementID_A22262.UIValue = value;
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x0600015D RID: 349 RVA: 0x0001E93C File Offset: 0x0001CB3C
		public global::AcpBusinessLayer.AcpRecRefField TxInhibitOffAnnouncementID_A22262
		{
			get
			{
				short num = (short)1047831368;
				short num2 = num;
				num = (short)739812168;
				switch (num2 == num)
				{
				}
				num = (short)730267649;
				if (num != 0)
				{
				}
				num = (short)1548288000;
				if (num != 0)
				{
				}
				num = (short)124911616;
				short num3 = num;
				return this.txInhibitOffAnnouncementID_A22262;
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x0600015E RID: 350 RVA: 0x0001E9EC File Offset: 0x0001CBEC
		// (set) Token: 0x0600015F RID: 351 RVA: 0x0001EAA4 File Offset: 0x0001CCA4
		public bool TxInhibitOffAnnouncementID_A22262_Applicable
		{
			get
			{
				short num = (short)677251006;
				short num2 = num;
				num = (short)1452541886;
				switch (num2 == num)
				{
				}
				num = (short)1805516801;
				if (num != 0)
				{
				}
				num = (short)323158016;
				if (num != 0)
				{
				}
				num = (short)1287716864;
				short num3 = num;
				return this.txInhibitOffAnnouncementID_A22262.Applicable;
			}
			set
			{
				short num = (short)167642569;
				short num2 = num;
				num = (short)1448543689;
				switch (num2 == num)
				{
				}
				num = (short)147718144;
				if (num != 0)
				{
				}
				num = (short)1788477441;
				if (num != 0)
				{
				}
				num = (short)1807089664;
				short num3 = num;
				this.txInhibitOffAnnouncementID_A22262.Applicable = value;
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000160 RID: 352 RVA: 0x0001EB5C File Offset: 0x0001CD5C
		// (set) Token: 0x06000161 RID: 353 RVA: 0x0001EC14 File Offset: 0x0001CE14
		public bool TxInhibitOffAnnouncementID_A22262_Valid
		{
			get
			{
				short num = (short)1704269241;
				short num2 = num;
				num = (short)1686836665;
				switch (num2 == num)
				{
				}
				num = (short)712179712;
				if (num != 0)
				{
				}
				num = (short)1339162625;
				if (num != 0)
				{
				}
				num = (short)1976762368;
				short num3 = num;
				return this.txInhibitOffAnnouncementID_A22262.Valid;
			}
			set
			{
				short num = (short)1318511726;
				short num2 = num;
				num = (short)319022190;
				switch (num2 == num)
				{
				}
				num = (short)283705345;
				if (num != 0)
				{
				}
				num = (short)1962344448;
				if (num != 0)
				{
				}
				num = (short)1325858816;
				short num3 = num;
				this.txInhibitOffAnnouncementID_A22262.Valid = value;
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000162 RID: 354 RVA: 0x0001ECCC File Offset: 0x0001CECC
		// (set) Token: 0x06000163 RID: 355 RVA: 0x0001ED84 File Offset: 0x0001CF84
		public bool TxInhibitOffAnnouncementID_A22262_Visible
		{
			get
			{
				short num = (short)1277950984;
				short num2 = num;
				num = (short)427424776;
				switch (num2 == num)
				{
				}
				num = (short)106627073;
				if (num != 0)
				{
				}
				num = (short)714735616;
				if (num != 0)
				{
				}
				num = (short)554500096;
				short num3 = num;
				return this.txInhibitOffAnnouncementID_A22262.Visible;
			}
			set
			{
				short num = (short)1513624192;
				short num2 = num;
				num = (short)612242048;
				switch (num2 == num)
				{
				}
				num = (short)292749313;
				if (num != 0)
				{
				}
				num = (short)1544945664;
				if (num != 0)
				{
				}
				num = (short)154009600;
				short num3 = num;
				this.txInhibitOffAnnouncementID_A22262.Visible = value;
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000164 RID: 356 RVA: 0x0001EE3C File Offset: 0x0001D03C
		// (set) Token: 0x06000165 RID: 357 RVA: 0x0001EEF4 File Offset: 0x0001D0F4
		public bool TxInhibitOffAnnouncementID_A22262_Editable
		{
			get
			{
				short num = (short)1139460541;
				short num2 = num;
				num = (short)1582811581;
				switch (num2 == num)
				{
				}
				num = (short)418512897;
				if (num != 0)
				{
				}
				num = (short)1709965312;
				if (num != 0)
				{
				}
				num = (short)323813376;
				short num3 = num;
				return this.txInhibitOffAnnouncementID_A22262.Editable;
			}
			set
			{
				short num = (short)1362777872;
				short num2 = num;
				num = (short)1430411024;
				switch (num2 == num)
				{
				}
				num = (short)195035136;
				if (num != 0)
				{
				}
				num = (short)702152705;
				if (num != 0)
				{
				}
				num = (short)223608832;
				short num3 = num;
				this.txInhibitOffAnnouncementID_A22262.Editable = value;
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000166 RID: 358 RVA: 0x0001EFAC File Offset: 0x0001D1AC
		internal string TxInhibitOffAnnouncementID_A22262_UILabel
		{
			get
			{
				short num = (short)1990708660;
				short num2 = num;
				num = (short)752733620;
				switch (num2 == num)
				{
				}
				num = (short)1798897665;
				if (num != 0)
				{
				}
				num = (short)553517056;
				if (num != 0)
				{
				}
				num = (short)1664286720;
				short num3 = num;
				return this.txInhibitOffAnnouncementID_A22262.UIName;
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000167 RID: 359 RVA: 0x0001F060 File Offset: 0x0001D260
		// (set) Token: 0x06000168 RID: 360 RVA: 0x0001F114 File Offset: 0x0001D314
		internal bool TxInhibitOffAnnouncementID_A22262_HiddenStatic
		{
			get
			{
				short num = (short)1597462700;
				short num2 = num;
				num = (short)559700140;
				switch (num2 == num)
				{
				}
				num = (short)1715470337;
				if (num != 0)
				{
				}
				num = (short)619511808;
				if (num != 0)
				{
				}
				num = (short)1803747328;
				short num3 = num;
				return this.txInhibitOffAnnouncementID_A22262.HiddenStatic;
			}
			set
			{
				short num = (short)424835072;
				short num2 = num;
				num = (short)818837504;
				switch (num2 == num)
				{
				}
				num = (short)12976129;
				if (num != 0)
				{
				}
				num = (short)1192099840;
				if (num != 0)
				{
				}
				num = (short)1329004544;
				short num3 = num;
				this.txInhibitOffAnnouncementID_A22262.HiddenStatic = value;
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000169 RID: 361 RVA: 0x0001F1CC File Offset: 0x0001D3CC
		// (set) Token: 0x0600016A RID: 362 RVA: 0x0001F280 File Offset: 0x0001D480
		internal bool TxInhibitOffAnnouncementID_A22262_HiddenDynamic
		{
			get
			{
				short num = (short)2020030766;
				short num2 = num;
				num = (short)1765816622;
				switch (num2 == num)
				{
				}
				num = (short)1554448385;
				if (num != 0)
				{
				}
				num = (short)1157169152;
				if (num != 0)
				{
				}
				num = (short)1605959680;
				short num3 = num;
				return this.txInhibitOffAnnouncementID_A22262.HiddenDynamic;
			}
			set
			{
				short num = (short)143615612;
				short num2 = num;
				num = (short)1002137212;
				switch (num2 == num)
				{
				}
				num = (short)1585119232;
				if (num != 0)
				{
				}
				num = (short)833159169;
				if (num != 0)
				{
				}
				num = (short)1315700736;
				short num3 = num;
				this.txInhibitOffAnnouncementID_A22262.HiddenDynamic = value;
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x0600016B RID: 363 RVA: 0x0001F334 File Offset: 0x0001D534
		public bool TxInhibitOffAnnouncementID_A22262_HasDiffs
		{
			get
			{
				short num = (short)1491276502;
				short num2 = num;
				num = (short)336204502;
				switch (num2 == num)
				{
				}
				num = (short)288161792;
				if (num != 0)
				{
				}
				num = (short)2110586881;
				if (num != 0)
				{
				}
				num = (short)1245052928;
				short num3 = num;
				return this.txInhibitOffAnnouncementID_A22262._HasDiffs;
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x0600016C RID: 364 RVA: 0x0001F3EC File Offset: 0x0001D5EC
		// (set) Token: 0x0600016D RID: 365 RVA: 0x0001F4A0 File Offset: 0x0001D6A0
		public int RadErgoCfgVAWide_A41497Value
		{
			get
			{
				short num = (short)1080613787;
				short num2 = num;
				num = (short)1431952283;
				switch (num2 == num)
				{
				}
				num = (short)1823604736;
				if (num != 0)
				{
				}
				num = (short)1675558913;
				if (num != 0)
				{
				}
				num = (short)1474494464;
				short num3 = num;
				return this.radErgoCfgVAWide_A41497.Value;
			}
			set
			{
				short num = (short)1496967553;
				short num2 = num;
				num = (short)755100033;
				switch (num2 == num)
				{
				}
				num = (short)45154304;
				if (num != 0)
				{
				}
				num = (short)2030108673;
				if (num != 0)
				{
				}
				num = (short)313524224;
				short num3 = num;
				this.radErgoCfgVAWide_A41497.Value = value;
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x0600016E RID: 366 RVA: 0x0001F554 File Offset: 0x0001D754
		// (set) Token: 0x0600016F RID: 367 RVA: 0x0001F608 File Offset: 0x0001D808
		public string RadErgoCfgVAWide_A41497_UIValue
		{
			get
			{
				short num = (short)821750620;
				short num2 = num;
				num = (short)945810268;
				switch (num2 == num)
				{
				}
				num = (short)420020225;
				if (num != 0)
				{
				}
				num = (short)2113470464;
				if (num != 0)
				{
				}
				num = (short)2078998528;
				short num3 = num;
				return this.radErgoCfgVAWide_A41497.UIValue;
			}
			set
			{
				short num = (short)902456191;
				short num2 = num;
				num = (short)662725503;
				switch (num2 == num)
				{
				}
				num = (short)1340080129;
				if (num != 0)
				{
				}
				num = (short)1970143232;
				if (num != 0)
				{
				}
				num = (short)385482752;
				short num3 = num;
				this.radErgoCfgVAWide_A41497.UIValue = value;
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000170 RID: 368 RVA: 0x0001F6C0 File Offset: 0x0001D8C0
		public global::AcpBusinessLayer.AcpRecRefField RadErgoCfgVAWide_A41497
		{
			get
			{
				short num = (short)1153836985;
				short num2 = num;
				num = (short)954476473;
				switch (num2 == num)
				{
				}
				num = (short)325779457;
				if (num != 0)
				{
				}
				num = (short)1479344128;
				if (num != 0)
				{
				}
				num = (short)1847066624;
				short num3 = num;
				return this.radErgoCfgVAWide_A41497;
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000171 RID: 369 RVA: 0x0001F76C File Offset: 0x0001D96C
		// (set) Token: 0x06000172 RID: 370 RVA: 0x0001F820 File Offset: 0x0001DA20
		public bool RadErgoCfgVAWide_A41497_Applicable
		{
			get
			{
				short num = (short)870104016;
				short num2 = num;
				num = (short)1331542992;
				switch (num2 == num)
				{
				}
				num = (short)425656321;
				if (num != 0)
				{
				}
				num = (short)456261632;
				if (num != 0)
				{
				}
				num = (short)1215954944;
				short num3 = num;
				return this.radErgoCfgVAWide_A41497.Applicable;
			}
			set
			{
				short num = (short)1775414439;
				short num2 = num;
				num = (short)813083815;
				switch (num2 == num)
				{
				}
				num = (short)848297984;
				if (num != 0)
				{
				}
				num = (short)2136408065;
				if (num != 0)
				{
				}
				num = (short)26411008;
				short num3 = num;
				this.radErgoCfgVAWide_A41497.Applicable = value;
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000173 RID: 371 RVA: 0x0001F8D4 File Offset: 0x0001DAD4
		// (set) Token: 0x06000174 RID: 372 RVA: 0x0001F988 File Offset: 0x0001DB88
		public bool RadErgoCfgVAWide_A41497_Valid
		{
			get
			{
				short num = (short)2039534078;
				short num2 = num;
				num = (short)674222590;
				switch (num2 == num)
				{
				}
				num = (short)545849345;
				if (num != 0)
				{
				}
				num = (short)1601437696;
				if (num != 0)
				{
				}
				num = (short)1272643584;
				short num3 = num;
				return this.radErgoCfgVAWide_A41497.Valid;
			}
			set
			{
				short num = (short)1209860097;
				if (num != 0)
				{
				}
				num = (short)1260147050;
				short num2 = num;
				num = (short)1227837802;
				switch (num2 == num)
				{
				}
				num = (short)116391936;
				if (num != 0)
				{
				}
				num = (short)536084480;
				short num3 = num;
				this.radErgoCfgVAWide_A41497.Valid = value;
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000175 RID: 373 RVA: 0x0001FA40 File Offset: 0x0001DC40
		// (set) Token: 0x06000176 RID: 374 RVA: 0x0001FAF4 File Offset: 0x0001DCF4
		public bool RadErgoCfgVAWide_A41497_Visible
		{
			get
			{
				short num = (short)450467996;
				short num2 = num;
				num = (short)1757321372;
				switch (num2 == num)
				{
				}
				num = (short)207093760;
				short num3 = num;
				num = (short)86704128;
				if (num != 0)
				{
				}
				num = (short)250675201;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWide_A41497.Visible;
			}
			set
			{
				short num = (short)1795473290;
				short num2 = num;
				num = (short)2036449162;
				switch (num2 == num)
				{
				}
				num = (short)167510016;
				short num3 = num;
				num = (short)123600897;
				if (num != 0)
				{
				}
				num = (short)1508114432;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWide_A41497.Visible = value;
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06000177 RID: 375 RVA: 0x0001FBAC File Offset: 0x0001DDAC
		// (set) Token: 0x06000178 RID: 376 RVA: 0x0001FC64 File Offset: 0x0001DE64
		public bool RadErgoCfgVAWide_A41497_Editable
		{
			get
			{
				short num = (short)1638253189;
				short num2 = num;
				num = (short)2096153221;
				switch (num2 == num)
				{
				}
				num = (short)1180958720;
				short num3 = num;
				num = (short)1198784513;
				if (num != 0)
				{
				}
				num = (short)1318191104;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWide_A41497.Editable;
			}
			set
			{
				short num = (short)493896942;
				short num2 = num;
				num = (short)918963438;
				switch (num2 == num)
				{
				}
				num = (short)726925312;
				short num3 = num;
				num = (short)1791950848;
				if (num != 0)
				{
				}
				num = (short)794296321;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWide_A41497.Editable = value;
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000179 RID: 377 RVA: 0x0001FD1C File Offset: 0x0001DF1C
		internal string RadErgoCfgVAWide_A41497_UILabel
		{
			get
			{
				short num = (short)2722073;
				short num2 = num;
				num = (short)916556057;
				switch (num2 == num)
				{
				}
				num = (short)454688768;
				short num3 = num;
				num = (short)1081671680;
				if (num != 0)
				{
				}
				num = (short)1740439553;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWide_A41497.UIName;
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x0600017A RID: 378 RVA: 0x0001FDD0 File Offset: 0x0001DFD0
		// (set) Token: 0x0600017B RID: 379 RVA: 0x0001FE84 File Offset: 0x0001E084
		internal bool RadErgoCfgVAWide_A41497_HiddenStatic
		{
			get
			{
				short num = (short)1482821586;
				short num2 = num;
				num = (short)1993936850;
				switch (num2 == num)
				{
				}
				num = (short)613089280;
				short num3 = num;
				num = (short)1512898560;
				if (num != 0)
				{
				}
				num = (short)1576992769;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWide_A41497.HiddenStatic;
			}
			set
			{
				short num = (short)1367499867;
				short num2 = num;
				num = (short)467362907;
				switch (num2 == num)
				{
				}
				num = (short)457637888;
				short num3 = num;
				num = (short)1631453185;
				if (num != 0)
				{
				}
				num = (short)172294144;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWide_A41497.HiddenStatic = value;
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x0600017C RID: 380 RVA: 0x0001FF3C File Offset: 0x0001E13C
		// (set) Token: 0x0600017D RID: 381 RVA: 0x0001FFF0 File Offset: 0x0001E1F0
		internal bool RadErgoCfgVAWide_A41497_HiddenDynamic
		{
			get
			{
				short num = (short)517759951;
				short num2 = num;
				num = (short)183657423;
				switch (num2 == num)
				{
				}
				num = (short)1336410112;
				short num3 = num;
				num = (short)1125449728;
				if (num != 0)
				{
				}
				num = (short)1954414593;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWide_A41497.HiddenDynamic;
			}
			set
			{
				short num = (short)1463746561;
				if (num != 0)
				{
				}
				num = (short)686793008;
				short num2 = num;
				num = (short)1847370032;
				switch (num2 == num)
				{
				default:
				{
					num = (short)680329216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1301479424;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWide_A41497.HiddenDynamic = value;
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x0600017E RID: 382 RVA: 0x000200A4 File Offset: 0x0001E2A4
		public bool RadErgoCfgVAWide_A41497_HasDiffs
		{
			get
			{
				short num = (short)1396572161;
				if (num != 0)
				{
				}
				num = (short)1279681165;
				short num2 = num;
				num = (short)2025349773;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1071579136;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2074148864;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWide_A41497._HasDiffs;
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x0600017F RID: 383 RVA: 0x0002015C File Offset: 0x0001E35C
		// (set) Token: 0x06000180 RID: 384 RVA: 0x00020214 File Offset: 0x0001E414
		public int RadErgoCfgVAWide_A41499Value
		{
			get
			{
				short num = (short)690159617;
				if (num != 0)
				{
				}
				num = (short)1709956707;
				short num2 = num;
				num = (short)1823661667;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1734541312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)761135104;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWide_A41499.Value;
			}
			set
			{
				short num = (short)2115239937;
				if (num != 0)
				{
				}
				num = (short)1599506879;
				short num2 = num;
				num = (short)893028799;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1205469184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)801505280;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWide_A41499.Value = value;
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000181 RID: 385 RVA: 0x000202C8 File Offset: 0x0001E4C8
		// (set) Token: 0x06000182 RID: 386 RVA: 0x0002037C File Offset: 0x0001E57C
		public string RadErgoCfgVAWide_A41499_UIValue
		{
			get
			{
				short num = (short)571361469;
				short num2 = num;
				num = (short)29640893;
				switch (num2 == num)
				{
				}
				num = (short)1308557312;
				short num3 = num;
				num = (short)1453981697;
				if (num != 0)
				{
				}
				num = (short)1194524672;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWide_A41499.UIValue;
			}
			set
			{
				short num = (short)2112352186;
				short num2 = num;
				num = (short)547942330;
				switch (num2 == num)
				{
				}
				num = (short)1273561088;
				short num3 = num;
				num = (short)626393089;
				if (num != 0)
				{
				}
				num = (short)487522304;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWide_A41499.UIValue = value;
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06000183 RID: 387 RVA: 0x00020434 File Offset: 0x0001E634
		public global::AcpBusinessLayer.AcpRecRefField RadErgoCfgVAWide_A41499
		{
			get
			{
				short num = (short)1011065729;
				short num2 = num;
				num = (short)281256833;
				switch (num2 == num)
				{
				}
				num = (short)1721499648;
				short num3 = num;
				num = (short)2134900737;
				if (num != 0)
				{
				}
				num = (short)986644480;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWide_A41499;
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000184 RID: 388 RVA: 0x000204E4 File Offset: 0x0001E6E4
		// (set) Token: 0x06000185 RID: 389 RVA: 0x00020598 File Offset: 0x0001E798
		public bool RadErgoCfgVAWide_A41499_Applicable
		{
			get
			{
				short num = (short)753305431;
				short num2 = num;
				num = (short)425232215;
				switch (num2 == num)
				{
				}
				num = (short)614268928;
				short num3 = num;
				num = (short)1384972289;
				if (num != 0)
				{
				}
				num = (short)881328128;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWide_A41499.Applicable;
			}
			set
			{
				short num = (short)1694554242;
				short num2 = num;
				num = (short)2099042434;
				switch (num2 == num)
				{
				}
				num = (short)1111359488;
				short num3 = num;
				num = (short)118423553;
				if (num != 0)
				{
				}
				num = (short)470745088;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWide_A41499.Applicable = value;
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x06000186 RID: 390 RVA: 0x00020650 File Offset: 0x0001E850
		// (set) Token: 0x06000187 RID: 391 RVA: 0x0002070C File Offset: 0x0001E90C
		public bool RadErgoCfgVAWide_A41499_Valid
		{
			get
			{
				short num = (short)616802498;
				short num2 = num;
				num = (short)1910024386;
				switch (num2 == num)
				{
				}
				num = (short)1450115072;
				short num3 = num;
				num = (short)1119682560;
				if (num != 0)
				{
				}
				num = (short)1739128833;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWide_A41499.Valid;
			}
			set
			{
				short num = (short)1872391956;
				short num2 = num;
				num = (short)237399828;
				switch (num2 == num)
				{
				}
				num = (short)2010120192;
				short num3 = num;
				num = (short)1247870976;
				if (num != 0)
				{
				}
				num = (short)1255473153;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWide_A41499.Valid = value;
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x06000188 RID: 392 RVA: 0x000207C8 File Offset: 0x0001E9C8
		// (set) Token: 0x06000189 RID: 393 RVA: 0x0002087C File Offset: 0x0001EA7C
		public bool RadErgoCfgVAWide_A41499_Visible
		{
			get
			{
				short num = (short)783330793;
				short num2 = num;
				num = (short)1126215145;
				switch (num2 == num)
				{
				}
				num = (short)959119360;
				short num3 = num;
				num = (short)1077936128;
				if (num != 0)
				{
				}
				num = (short)358219777;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWide_A41499.Visible;
			}
			set
			{
				short num = (short)1652518339;
				short num2 = num;
				num = (short)1547988419;
				switch (num2 == num)
				{
				}
				num = (short)1133903872;
				short num3 = num;
				num = (short)1268187136;
				if (num != 0)
				{
				}
				num = (short)1717698561;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWide_A41499.Visible = value;
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x0600018A RID: 394 RVA: 0x00020930 File Offset: 0x0001EB30
		// (set) Token: 0x0600018B RID: 395 RVA: 0x000209E0 File Offset: 0x0001EBE0
		public bool RadErgoCfgVAWide_A41499_Editable
		{
			get
			{
				short num = (short)905422331;
				short num2 = num;
				num = (short)1835443707;
				switch (num2 == num)
				{
				}
				num = (short)1135869952;
				short num3 = num;
				num = (short)426967040;
				if (num != 0)
				{
				}
				num = (short)1963720705;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWide_A41499.Editable;
			}
			set
			{
				short num = (short)1356905755;
				short num2 = num;
				num = (short)2105785627;
				switch (num2 == num)
				{
				}
				num = (short)262144000;
				short num3 = num;
				num = (short)375390209;
				if (num != 0)
				{
				}
				num = (short)1115947008;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWide_A41499.Editable = value;
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x0600018C RID: 396 RVA: 0x00020A98 File Offset: 0x0001EC98
		internal string RadErgoCfgVAWide_A41499_UILabel
		{
			get
			{
				short num = (short)2071138116;
				short num2 = num;
				num = (short)969150276;
				switch (num2 == num)
				{
				}
				num = (short)529006592;
				short num3 = num;
				num = (short)1572798465;
				if (num != 0)
				{
				}
				num = (short)1447559168;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWide_A41499.UIName;
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x0600018D RID: 397 RVA: 0x00020B4C File Offset: 0x0001ED4C
		// (set) Token: 0x0600018E RID: 398 RVA: 0x00020C00 File Offset: 0x0001EE00
		internal bool RadErgoCfgVAWide_A41499_HiddenStatic
		{
			get
			{
				short num = (short)1278372108;
				short num2 = num;
				num = (short)1305897228;
				switch (num2 == num)
				{
				}
				num = (short)1039532032;
				short num3 = num;
				num = (short)1821638656;
				if (num != 0)
				{
				}
				num = (short)540344321;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWide_A41499.HiddenStatic;
			}
			set
			{
				short num = (short)756321041;
				short num2 = num;
				num = (short)1773374225;
				switch (num2 == num)
				{
				}
				num = (short)1493565440;
				short num3 = num;
				num = (short)1842020353;
				if (num != 0)
				{
				}
				num = (short)796000256;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWide_A41499.HiddenStatic = value;
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x0600018F RID: 399 RVA: 0x00020CB8 File Offset: 0x0001EEB8
		// (set) Token: 0x06000190 RID: 400 RVA: 0x00020D70 File Offset: 0x0001EF70
		internal bool RadErgoCfgVAWide_A41499_HiddenDynamic
		{
			get
			{
				short num = (short)1717571075;
				short num2 = num;
				num = (short)81530371;
				switch (num2 == num)
				{
				}
				num = (short)1150681088;
				short num3 = num;
				num = (short)1597505536;
				if (num != 0)
				{
				}
				num = (short)1279983617;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWide_A41499.HiddenDynamic;
			}
			set
			{
				short num = (short)683919008;
				short num2 = num;
				num = (short)1788069536;
				switch (num2 == num)
				{
				}
				num = (short)1233321984;
				short num3 = num;
				num = (short)796459009;
				if (num != 0)
				{
				}
				num = (short)80805888;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWide_A41499.HiddenDynamic = value;
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x06000191 RID: 401 RVA: 0x00020E28 File Offset: 0x0001F028
		public bool RadErgoCfgVAWide_A41499_HasDiffs
		{
			get
			{
				short num = (short)119921290;
				short num2 = num;
				num = (short)1581832842;
				switch (num2 == num)
				{
				}
				num = (short)716701696;
				short num3 = num;
				num = (short)1855848449;
				if (num != 0)
				{
				}
				num = (short)1402732544;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWide_A41499._HasDiffs;
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x06000192 RID: 402 RVA: 0x00020EDC File Offset: 0x0001F0DC
		// (set) Token: 0x06000193 RID: 403 RVA: 0x00020F90 File Offset: 0x0001F190
		public int RadErgoCfgVAWide_A41500Value
		{
			get
			{
				short num = (short)67287158;
				short num2 = num;
				num = (short)1352775798;
				switch (num2 == num)
				{
				}
				num = (short)570032128;
				short num3 = num;
				num = (short)519372801;
				if (num != 0)
				{
				}
				num = (short)648478720;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWide_A41500.Value;
			}
			set
			{
				short num = (short)733700510;
				short num2 = num;
				num = (short)2128109982;
				switch (num2 == num)
				{
				}
				num = (short)1152843776;
				short num3 = num;
				num = (short)1023672321;
				if (num != 0)
				{
				}
				num = (short)348585984;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWide_A41500.Value = value;
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000194 RID: 404 RVA: 0x00021048 File Offset: 0x0001F248
		// (set) Token: 0x06000195 RID: 405 RVA: 0x00021100 File Offset: 0x0001F300
		public string RadErgoCfgVAWide_A41500_UIValue
		{
			get
			{
				short num = (short)1484256928;
				short num2 = num;
				num = (short)1385297568;
				switch (num2 == num)
				{
				}
				num = (short)942800896;
				short num3 = num;
				num = (short)1399980032;
				if (num != 0)
				{
				}
				num = (short)1138098177;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWide_A41500.UIValue;
			}
			set
			{
				short num = (short)1979463104;
				short num2 = num;
				num = (short)461583808;
				switch (num2 == num)
				{
				}
				num = (short)1606156288;
				short num3 = num;
				num = (short)894042113;
				if (num != 0)
				{
				}
				num = (short)173670400;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWide_A41500.UIValue = value;
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x06000196 RID: 406 RVA: 0x000211B8 File Offset: 0x0001F3B8
		public global::AcpBusinessLayer.AcpRecRefField RadErgoCfgVAWide_A41500
		{
			get
			{
				short num = (short)367440990;
				short num2 = num;
				num = (short)1850061918;
				switch (num2 == num)
				{
				}
				num = (short)2147090432;
				short num3 = num;
				num = (short)259194880;
				if (num != 0)
				{
				}
				num = (short)1882652673;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWide_A41500;
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000197 RID: 407 RVA: 0x00021268 File Offset: 0x0001F468
		// (set) Token: 0x06000198 RID: 408 RVA: 0x0002131C File Offset: 0x0001F51C
		public bool RadErgoCfgVAWide_A41500_Applicable
		{
			get
			{
				short num = (short)1880489985;
				if (num != 0)
				{
				}
				num = (short)1086291229;
				short num2 = num;
				num = (short)1857387805;
				switch (num2 == num)
				{
				default:
				{
					num = (short)972226560;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1529806848;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWide_A41500.Applicable;
			}
			set
			{
				short num = (short)1940792548;
				short num2 = num;
				num = (short)1040000228;
				switch (num2 == num)
				{
				}
				num = (short)822607872;
				short num3 = num;
				num = (short)1213071361;
				if (num != 0)
				{
				}
				num = (short)914817024;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWide_A41500.Applicable = value;
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x06000199 RID: 409 RVA: 0x000213D4 File Offset: 0x0001F5D4
		// (set) Token: 0x0600019A RID: 410 RVA: 0x00021488 File Offset: 0x0001F688
		public bool RadErgoCfgVAWide_A41500_Valid
		{
			get
			{
				short num = (short)803944835;
				short num2 = num;
				num = (short)704395651;
				switch (num2 == num)
				{
				}
				num = (short)1641021440;
				short num3 = num;
				num = (short)1617952768;
				if (num != 0)
				{
				}
				num = (short)1540620289;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWide_A41500.Valid;
			}
			set
			{
				short num = (short)1215417746;
				short num2 = num;
				num = (short)513723794;
				switch (num2 == num)
				{
				}
				num = (short)749404160;
				short num3 = num;
				num = (short)1217396737;
				if (num != 0)
				{
				}
				num = (short)1870856192;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWide_A41500.Valid = value;
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x0600019B RID: 411 RVA: 0x00021540 File Offset: 0x0001F740
		// (set) Token: 0x0600019C RID: 412 RVA: 0x000215F4 File Offset: 0x0001F7F4
		public bool RadErgoCfgVAWide_A41500_Visible
		{
			get
			{
				short num = (short)1403207843;
				short num2 = num;
				num = (short)854147235;
				switch (num2 == num)
				{
				}
				num = (short)938868736;
				short num3 = num;
				num = (short)516096001;
				if (num != 0)
				{
				}
				num = (short)1975517184;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWide_A41500.Visible;
			}
			set
			{
				short num = (short)786712381;
				short num2 = num;
				num = (short)1768376125;
				switch (num2 == num)
				{
				}
				num = (short)1591803904;
				short num3 = num;
				num = (short)1552547840;
				if (num != 0)
				{
				}
				num = (short)1170669569;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWide_A41500.Visible = value;
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x0600019D RID: 413 RVA: 0x000216A8 File Offset: 0x0001F8A8
		// (set) Token: 0x0600019E RID: 414 RVA: 0x0002175C File Offset: 0x0001F95C
		public bool RadErgoCfgVAWide_A41500_Editable
		{
			get
			{
				short num = (short)491219289;
				short num2 = num;
				num = (short)607873369;
				switch (num2 == num)
				{
				}
				num = (short)421068800;
				short num3 = num;
				num = (short)873660417;
				if (num != 0)
				{
				}
				num = (short)1314586624;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWide_A41500.Editable;
			}
			set
			{
				short num = (short)1235612892;
				short num2 = num;
				num = (short)507311324;
				switch (num2 == num)
				{
				}
				num = (short)462422016;
				short num3 = num;
				num = (short)303431681;
				if (num != 0)
				{
				}
				num = (short)1549729792;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWide_A41500.Editable = value;
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x0600019F RID: 415 RVA: 0x00021810 File Offset: 0x0001FA10
		internal string RadErgoCfgVAWide_A41500_UILabel
		{
			get
			{
				short num = (short)779867855;
				short num2 = num;
				num = (short)871225039;
				switch (num2 == num)
				{
				}
				num = (short)1239810048;
				short num3 = num;
				num = (short)1656881153;
				if (num != 0)
				{
				}
				num = (short)1791623168;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWide_A41500.UIName;
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060001A0 RID: 416 RVA: 0x000218C4 File Offset: 0x0001FAC4
		// (set) Token: 0x060001A1 RID: 417 RVA: 0x00021978 File Offset: 0x0001FB78
		internal bool RadErgoCfgVAWide_A41500_HiddenStatic
		{
			get
			{
				short num = (short)1497552545;
				short num2 = num;
				num = (short)512612001;
				switch (num2 == num)
				{
				}
				num = (short)1197473792;
				short num3 = num;
				num = (short)948568065;
				if (num != 0)
				{
				}
				num = (short)269877248;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWide_A41500.HiddenStatic;
			}
			set
			{
				short num = (short)1061193753;
				short num2 = num;
				num = (short)1258063897;
				switch (num2 == num)
				{
				}
				num = (short)479395840;
				short num3 = num;
				num = (short)663486464;
				if (num != 0)
				{
				}
				num = (short)494010369;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWide_A41500.HiddenStatic = value;
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060001A2 RID: 418 RVA: 0x00021A30 File Offset: 0x0001FC30
		// (set) Token: 0x060001A3 RID: 419 RVA: 0x00021AE4 File Offset: 0x0001FCE4
		internal bool RadErgoCfgVAWide_A41500_HiddenDynamic
		{
			get
			{
				short num = (short)107120919;
				short num2 = num;
				num = (short)1639680279;
				switch (num2 == num)
				{
				}
				num = (short)576913408;
				short num3 = num;
				num = (short)392036352;
				if (num != 0)
				{
				}
				num = (short)1282539521;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWide_A41500.HiddenDynamic;
			}
			set
			{
				short num = (short)905052160;
				short num2 = num;
				num = (short)158044893;
				short num3 = num;
				num = (short)811897565;
				switch (num3 == num)
				{
				}
				num = (short)41746433;
				if (num != 0)
				{
				}
				num = (short)578093056;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWide_A41500.HiddenDynamic = value;
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060001A4 RID: 420 RVA: 0x00021B98 File Offset: 0x0001FD98
		public bool RadErgoCfgVAWide_A41500_HasDiffs
		{
			get
			{
				short num = (short)1904345088;
				short num2 = num;
				num = (short)1925446087;
				short num3 = num;
				num = (short)1377827271;
				switch (num3 == num)
				{
				}
				num = (short)1353318401;
				if (num != 0)
				{
				}
				num = (short)1282408448;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWide_A41500._HasDiffs;
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060001A5 RID: 421 RVA: 0x00021C4C File Offset: 0x0001FE4C
		// (set) Token: 0x060001A6 RID: 422 RVA: 0x00021D04 File Offset: 0x0001FF04
		public int RadErgoCfgVAWide_A41501Value
		{
			get
			{
				short num = (short)337313792;
				short num2 = num;
				num = (short)712656859;
				short num3 = num;
				num = (short)1027426267;
				switch (num3 == num)
				{
				}
				num = (short)1716912129;
				if (num != 0)
				{
				}
				num = (short)1175584768;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWide_A41501.Value;
			}
			set
			{
				short num = (short)348192768;
				short num2 = num;
				num = (short)2100943912;
				short num3 = num;
				num = (short)346348584;
				switch (num3 == num)
				{
				}
				num = (short)550699009;
				if (num != 0)
				{
				}
				num = (short)882049024;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWide_A41501.Value = value;
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060001A7 RID: 423 RVA: 0x00021DBC File Offset: 0x0001FFBC
		// (set) Token: 0x060001A8 RID: 424 RVA: 0x00021E74 File Offset: 0x00020074
		public string RadErgoCfgVAWide_A41501_UIValue
		{
			get
			{
				short num = (short)1416953856;
				short num2 = num;
				num = (short)85151543;
				short num3 = num;
				num = (short)590303031;
				switch (num3 == num)
				{
				}
				num = (short)352845825;
				if (num != 0)
				{
				}
				num = (short)1918959616;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWide_A41501.UIValue;
			}
			set
			{
				short num = (short)1416691712;
				short num2 = num;
				num = (short)1351422733;
				short num3 = num;
				num = (short)278795021;
				switch (num3 == num)
				{
				}
				num = (short)481165312;
				if (num != 0)
				{
				}
				num = (short)963772417;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWide_A41501.UIValue = value;
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060001A9 RID: 425 RVA: 0x00021F2C File Offset: 0x0002012C
		public global::AcpBusinessLayer.AcpRecRefField RadErgoCfgVAWide_A41501
		{
			get
			{
				short num = (short)861339648;
				short num2 = num;
				num = (short)462618625;
				if (num != 0)
				{
				}
				num = (short)1717058963;
				short num3 = num;
				num = (short)293879187;
				switch (num3 == num)
				{
				}
				num = (short)767885312;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWide_A41501;
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060001AA RID: 426 RVA: 0x00021FD8 File Offset: 0x000201D8
		// (set) Token: 0x060001AB RID: 427 RVA: 0x0002208C File Offset: 0x0002028C
		public bool RadErgoCfgVAWide_A41501_Applicable
		{
			get
			{
				short num = (short)1840775168;
				short num2 = num;
				num = (short)1098458132;
				short num3 = num;
				num = (short)1560224788;
				switch (num3 == num)
				{
				}
				num = (short)2030895105;
				if (num != 0)
				{
				}
				num = (short)437256192;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWide_A41501.Applicable;
			}
			set
			{
				short num = (short)568262656;
				short num2 = num;
				num = (short)1791091623;
				short num3 = num;
				num = (short)1344791463;
				switch (num3 == num)
				{
				}
				num = (short)998113281;
				if (num != 0)
				{
				}
				num = (short)938803200;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWide_A41501.Applicable = value;
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060001AC RID: 428 RVA: 0x00022144 File Offset: 0x00020344
		// (set) Token: 0x060001AD RID: 429 RVA: 0x000221F8 File Offset: 0x000203F8
		public bool RadErgoCfgVAWide_A41501_Valid
		{
			get
			{
				short num = (short)1623588864;
				short num2 = num;
				num = (short)341111456;
				short num3 = num;
				num = (short)1352594080;
				switch (num3 == num)
				{
				}
				num = (short)361824256;
				if (num != 0)
				{
				}
				num = (short)444596225;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWide_A41501.Valid;
			}
			set
			{
				short num = (short)1601699840;
				short num2 = num;
				num = (short)98370158;
				short num3 = num;
				num = (short)1185415790;
				switch (num3 == num)
				{
				}
				num = (short)1225457665;
				if (num != 0)
				{
				}
				num = (short)1172176896;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWide_A41501.Valid = value;
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060001AE RID: 430 RVA: 0x000222AC File Offset: 0x000204AC
		// (set) Token: 0x060001AF RID: 431 RVA: 0x00022364 File Offset: 0x00020564
		public bool RadErgoCfgVAWide_A41501_Visible
		{
			get
			{
				short num = (short)1658257408;
				short num2 = num;
				num = (short)2013396993;
				if (num != 0)
				{
				}
				num = (short)1277539136;
				short num3 = num;
				num = (short)1371059008;
				switch (num3 == num)
				{
				}
				num = (short)49152000;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWide_A41501.Visible;
			}
			set
			{
				short num = (short)954597376;
				short num2 = num;
				num = (short)2017057761;
				short num3 = num;
				num = (short)1755896801;
				switch (num3 == num)
				{
				}
				num = (short)1064435713;
				if (num != 0)
				{
				}
				num = (short)1770389504;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWide_A41501.Visible = value;
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060001B0 RID: 432 RVA: 0x0002241C File Offset: 0x0002061C
		// (set) Token: 0x060001B1 RID: 433 RVA: 0x000224D0 File Offset: 0x000206D0
		public bool RadErgoCfgVAWide_A41501_Editable
		{
			get
			{
				short num = (short)2036662272;
				short num2 = num;
				num = (short)1880555015;
				short num3 = num;
				num = (short)453377543;
				switch (num3 == num)
				{
				}
				num = (short)986054657;
				if (num != 0)
				{
				}
				num = (short)2084569088;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWide_A41501.Editable;
			}
			set
			{
				short num = (short)234946560;
				short num2 = num;
				num = (short)367133135;
				short num3 = num;
				num = (short)2118386127;
				switch (num3 == num)
				{
				}
				num = (short)71368704;
				if (num != 0)
				{
				}
				num = (short)1991049217;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWide_A41501.Editable = value;
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060001B2 RID: 434 RVA: 0x00022588 File Offset: 0x00020788
		internal string RadErgoCfgVAWide_A41501_UILabel
		{
			get
			{
				short num = (short)1366360064;
				short num2 = num;
				num = (short)999005627;
				short num3 = num;
				num = (short)1968741819;
				switch (num3 == num)
				{
				}
				num = (short)1794768897;
				if (num != 0)
				{
				}
				num = (short)120193024;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWide_A41501.UIName;
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060001B3 RID: 435 RVA: 0x00022640 File Offset: 0x00020840
		// (set) Token: 0x060001B4 RID: 436 RVA: 0x000226F4 File Offset: 0x000208F4
		internal bool RadErgoCfgVAWide_A41501_HiddenStatic
		{
			get
			{
				short num = (short)447021056;
				short num2 = num;
				num = (short)1582664004;
				short num3 = num;
				num = (short)169183556;
				switch (num3 == num)
				{
				}
				num = (short)2133852161;
				if (num != 0)
				{
				}
				num = (short)1868627968;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWide_A41501.HiddenStatic;
			}
			set
			{
				short num = (short)2054750208;
				short num2 = num;
				num = (short)534571193;
				short num3 = num;
				num = (short)413853881;
				switch (num3 == num)
				{
				}
				num = (short)2089353217;
				if (num != 0)
				{
				}
				num = (short)1415839744;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWide_A41501.HiddenStatic = value;
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060001B5 RID: 437 RVA: 0x000227AC File Offset: 0x000209AC
		// (set) Token: 0x060001B6 RID: 438 RVA: 0x00022860 File Offset: 0x00020A60
		internal bool RadErgoCfgVAWide_A41501_HiddenDynamic
		{
			get
			{
				short num = (short)693370880;
				short num2 = num;
				num = (short)1776287982;
				short num3 = num;
				num = (short)2090336494;
				switch (num3 == num)
				{
				}
				num = (short)1342504961;
				if (num != 0)
				{
				}
				num = (short)1158676480;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWide_A41501.HiddenDynamic;
			}
			set
			{
				short num = (short)447283200;
				short num2 = num;
				num = (short)1404692418;
				short num3 = num;
				num = (short)1145300930;
				switch (num3 == num)
				{
				}
				num = (short)994967553;
				if (num != 0)
				{
				}
				num = (short)1032257536;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWide_A41501.HiddenDynamic = value;
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060001B7 RID: 439 RVA: 0x00022918 File Offset: 0x00020B18
		public bool RadErgoCfgVAWide_A41501_HasDiffs
		{
			get
			{
				short num = (short)1259405312;
				short num2 = num;
				num = (short)1924748287;
				short num3 = num;
				num = (short)1061639167;
				switch (num3 == num)
				{
				}
				num = (short)1946419200;
				if (num != 0)
				{
				}
				num = (short)2052259841;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWide_A41501._HasDiffs;
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060001B8 RID: 440 RVA: 0x000229CC File Offset: 0x00020BCC
		// (set) Token: 0x060001B9 RID: 441 RVA: 0x00022A84 File Offset: 0x00020C84
		public int RadErgoCfgVAWide_A41502Value
		{
			get
			{
				short num = (short)845021184;
				short num2 = num;
				num = (short)2029491295;
				short num3 = num;
				num = (short)637310047;
				switch (num3 == num)
				{
				}
				num = (short)635502593;
				if (num != 0)
				{
				}
				num = (short)1709309952;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWide_A41502.Value;
			}
			set
			{
				short num = (short)806551552;
				short num2 = num;
				num = (short)303461020;
				short num3 = num;
				num = (short)512062108;
				switch (num3 == num)
				{
				}
				num = (short)1506476033;
				if (num != 0)
				{
				}
				num = (short)1288175616;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWide_A41502.Value = value;
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060001BA RID: 442 RVA: 0x00022B38 File Offset: 0x00020D38
		// (set) Token: 0x060001BB RID: 443 RVA: 0x00022BF0 File Offset: 0x00020DF0
		public string RadErgoCfgVAWide_A41502_UIValue
		{
			get
			{
				short num = (short)829095936;
				short num2 = num;
				num = (short)1471021057;
				if (num != 0)
				{
				}
				num = (short)1856274076;
				short num3 = num;
				num = (short)1985904284;
				switch (num3 == num)
				{
				}
				num = (short)1051787264;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWide_A41502.UIValue;
			}
			set
			{
				short num = (short)75038720;
				short num2 = num;
				num = (short)546000340;
				short num3 = num;
				num = (short)2131119572;
				switch (num3 == num)
				{
				}
				num = (short)1433534465;
				if (num != 0)
				{
				}
				num = (short)395051008;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWide_A41502.UIValue = value;
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x060001BC RID: 444 RVA: 0x00022CA4 File Offset: 0x00020EA4
		public global::AcpBusinessLayer.AcpRecRefField RadErgoCfgVAWide_A41502
		{
			get
			{
				short num = (short)1756430336;
				short num2 = num;
				num = (short)166857456;
				short num3 = num;
				num = (short)786107120;
				switch (num3 == num)
				{
				}
				num = (short)1698693120;
				if (num != 0)
				{
				}
				num = (short)956432385;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWide_A41502;
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x060001BD RID: 445 RVA: 0x00022D50 File Offset: 0x00020F50
		// (set) Token: 0x060001BE RID: 446 RVA: 0x00022E04 File Offset: 0x00021004
		public bool RadErgoCfgVAWide_A41502_Applicable
		{
			get
			{
				short num = (short)878182400;
				short num2 = num;
				num = (short)586901534;
				short num3 = num;
				num = (short)734160926;
				switch (num3 == num)
				{
				}
				num = (short)1081016321;
				if (num != 0)
				{
				}
				num = (short)1963196416;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWide_A41502.Applicable;
			}
			set
			{
				short num = (short)1129185280;
				short num2 = num;
				num = (short)719136726;
				short num3 = num;
				num = (short)2134124502;
				switch (num3 == num)
				{
				}
				num = (short)1885339648;
				if (num != 0)
				{
				}
				num = (short)1588396033;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWide_A41502.Applicable = value;
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x060001BF RID: 447 RVA: 0x00022EB8 File Offset: 0x000210B8
		// (set) Token: 0x060001C0 RID: 448 RVA: 0x00022F6C File Offset: 0x0002116C
		public bool RadErgoCfgVAWide_A41502_Valid
		{
			get
			{
				short num = (short)2019295232;
				short num2 = num;
				num = (short)2127119504;
				short num3 = num;
				num = (short)1427915920;
				switch (num3 == num)
				{
				}
				num = (short)1052901377;
				if (num != 0)
				{
				}
				num = (short)445448192;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWide_A41502.Valid;
			}
			set
			{
				short num = (short)400490496;
				short num2 = num;
				num = (short)615872742;
				short num3 = num;
				num = (short)403732710;
				switch (num3 == num)
				{
				}
				num = (short)272760833;
				if (num != 0)
				{
				}
				num = (short)1023606784;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWide_A41502.Valid = value;
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x060001C1 RID: 449 RVA: 0x00023020 File Offset: 0x00021220
		// (set) Token: 0x060001C2 RID: 450 RVA: 0x000230D8 File Offset: 0x000212D8
		public bool RadErgoCfgVAWide_A41502_Visible
		{
			get
			{
				short num = (short)343146496;
				short num2 = num;
				num = (short)529125164;
				short num3 = num;
				num = (short)1025232684;
				switch (num3 == num)
				{
				}
				num = (short)2064646145;
				if (num != 0)
				{
				}
				num = (short)1811349504;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWide_A41502.Visible;
			}
			set
			{
				short num = (short)2120089600;
				short num2 = num;
				num = (short)1152378490;
				short num3 = num;
				num = (short)1653073530;
				switch (num3 == num)
				{
				}
				num = (short)1492058112;
				if (num != 0)
				{
				}
				num = (short)1341194241;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWide_A41502.Visible = value;
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x060001C3 RID: 451 RVA: 0x00023190 File Offset: 0x00021390
		// (set) Token: 0x060001C4 RID: 452 RVA: 0x00023244 File Offset: 0x00021444
		public bool RadErgoCfgVAWide_A41502_Editable
		{
			get
			{
				short num = (short)110100480;
				short num2 = num;
				num = (short)1156482859;
				short num3 = num;
				num = (short)1587054379;
				switch (num3 == num)
				{
				}
				num = (short)66584577;
				if (num != 0)
				{
				}
				num = (short)699269120;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWide_A41502.Editable;
			}
			set
			{
				short num = (short)1419051008;
				short num2 = num;
				num = (short)401268725;
				short num3 = num;
				num = (short)1874386933;
				switch (num3 == num)
				{
				}
				num = (short)1320550400;
				if (num != 0)
				{
				}
				num = (short)1272184833;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWide_A41502.Editable = value;
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x060001C5 RID: 453 RVA: 0x000232F8 File Offset: 0x000214F8
		internal string RadErgoCfgVAWide_A41502_UILabel
		{
			get
			{
				short num = (short)1299644416;
				short num2 = num;
				num = (short)742850561;
				if (num != 0)
				{
				}
				num = (short)1938487348;
				short num3 = num;
				num = (short)94763060;
				switch (num3 == num)
				{
				}
				num = (short)1286144000;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWide_A41502.UIName;
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x060001C6 RID: 454 RVA: 0x000233A8 File Offset: 0x000215A8
		// (set) Token: 0x060001C7 RID: 455 RVA: 0x0002345C File Offset: 0x0002165C
		internal bool RadErgoCfgVAWide_A41502_HiddenStatic
		{
			get
			{
				short num = (short)291766272;
				short num2 = num;
				num = (short)990647356;
				short num3 = num;
				num = (short)827593788;
				switch (num3 == num)
				{
				}
				num = (short)2066022401;
				if (num != 0)
				{
				}
				num = (short)2085093376;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWide_A41502.HiddenStatic;
			}
			set
			{
				short num = (short)2002321408;
				short num2 = num;
				num = (short)1897857025;
				if (num != 0)
				{
				}
				num = (short)1784774341;
				short num3 = num;
				num = (short)2143846085;
				switch (num3 == num)
				{
				}
				num = (short)232194048;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWide_A41502.HiddenStatic = value;
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x060001C8 RID: 456 RVA: 0x00023510 File Offset: 0x00021710
		// (set) Token: 0x060001C9 RID: 457 RVA: 0x000235C4 File Offset: 0x000217C4
		internal bool RadErgoCfgVAWide_A41502_HiddenDynamic
		{
			get
			{
				short num = (short)666828800;
				short num2 = num;
				num = (short)558759522;
				short num3 = num;
				num = (short)87817826;
				switch (num3 == num)
				{
				}
				num = (short)751960064;
				if (num != 0)
				{
				}
				num = (short)778371073;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWide_A41502.HiddenDynamic;
			}
			set
			{
				short num = (short)293994496;
				short num2 = num;
				num = (short)1523122177;
				if (num != 0)
				{
				}
				num = (short)1990682943;
				short num3 = num;
				num = (short)679635263;
				switch (num3 == num)
				{
				}
				num = (short)320667648;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWide_A41502.HiddenDynamic = value;
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x060001CA RID: 458 RVA: 0x0002367C File Offset: 0x0002187C
		public bool RadErgoCfgVAWide_A41502_HasDiffs
		{
			get
			{
				short num = (short)1532887040;
				short num2 = num;
				num = (short)1709067920;
				short num3 = num;
				num = (short)1601916560;
				switch (num3 == num)
				{
				}
				num = (short)2076573696;
				if (num != 0)
				{
				}
				num = (short)2146369537;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWide_A41502._HasDiffs;
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x060001CB RID: 459 RVA: 0x00023730 File Offset: 0x00021930
		// (set) Token: 0x060001CC RID: 460 RVA: 0x000237E4 File Offset: 0x000219E4
		public int RadErgoCfgVAWide_A41503Value
		{
			get
			{
				short num = (short)222035968;
				short num2 = num;
				num = (short)1422309645;
				short num3 = num;
				num = (short)1931917581;
				switch (num3 == num)
				{
				}
				num = (short)318636032;
				if (num != 0)
				{
				}
				num = (short)111280129;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWide_A41503.Value;
			}
			set
			{
				short num = (short)256638976;
				short num2 = num;
				num = (short)438178219;
				short num3 = num;
				num = (short)669716907;
				switch (num3 == num)
				{
				}
				num = (short)2123890688;
				if (num != 0)
				{
				}
				num = (short)1266941953;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWide_A41503.Value = value;
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x060001CD RID: 461 RVA: 0x0002389C File Offset: 0x00021A9C
		// (set) Token: 0x060001CE RID: 462 RVA: 0x00023950 File Offset: 0x00021B50
		public string RadErgoCfgVAWide_A41503_UIValue
		{
			get
			{
				short num = (short)1840906240;
				short num2 = num;
				num = (short)814076086;
				short num3 = num;
				num = (short)710856886;
				switch (num3 == num)
				{
				}
				num = (short)2017198081;
				if (num != 0)
				{
				}
				num = (short)531562496;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWide_A41503.UIValue;
			}
			set
			{
				short num = (short)2053308416;
				short num2 = num;
				num = (short)1925810813;
				short num3 = num;
				num = (short)926452349;
				switch (num3 == num)
				{
				}
				num = (short)1370095617;
				if (num != 0)
				{
				}
				num = (short)415891456;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWide_A41503.UIValue = value;
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x060001CF RID: 463 RVA: 0x00023A08 File Offset: 0x00021C08
		public global::AcpBusinessLayer.AcpRecRefField RadErgoCfgVAWide_A41503
		{
			get
			{
				short num = (short)494534656;
				short num2 = num;
				num = (short)2124685941;
				short num3 = num;
				num = (short)920134261;
				switch (num3 == num)
				{
				}
				num = (short)1490288641;
				if (num != 0)
				{
				}
				num = (short)299302912;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWide_A41503;
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x060001D0 RID: 464 RVA: 0x00023AB8 File Offset: 0x00021CB8
		// (set) Token: 0x060001D1 RID: 465 RVA: 0x00023B6C File Offset: 0x00021D6C
		public bool RadErgoCfgVAWide_A41503_Applicable
		{
			get
			{
				short num = (short)779878400;
				short num2 = num;
				num = (short)1371244098;
				short num3 = num;
				num = (short)1754433090;
				switch (num3 == num)
				{
				}
				num = (short)915865600;
				if (num != 0)
				{
				}
				num = (short)63897601;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWide_A41503.Applicable;
			}
			set
			{
				short num = (short)1853358080;
				short num2 = num;
				num = (short)1868558769;
				short num3 = num;
				num = (short)1730671025;
				switch (num3 == num)
				{
				}
				num = (short)680198145;
				if (num != 0)
				{
				}
				num = (short)1683816448;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWide_A41503.Applicable = value;
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x060001D2 RID: 466 RVA: 0x00023C24 File Offset: 0x00021E24
		// (set) Token: 0x060001D3 RID: 467 RVA: 0x00023CD8 File Offset: 0x00021ED8
		public bool RadErgoCfgVAWide_A41503_Valid
		{
			get
			{
				short num = (short)634912768;
				short num2 = num;
				num = (short)864502428;
				short num3 = num;
				num = (short)445792924;
				switch (num3 == num)
				{
				}
				num = (short)422117376;
				if (num != 0)
				{
				}
				num = (short)350814209;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWide_A41503.Valid;
			}
			set
			{
				short num = (short)1984692224;
				short num2 = num;
				num = (short)1848967169;
				if (num != 0)
				{
				}
				num = (short)907429230;
				short num3 = num;
				num = (short)592332142;
				switch (num3 == num)
				{
				}
				num = (short)889782272;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWide_A41503.Valid = value;
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x060001D4 RID: 468 RVA: 0x00023D90 File Offset: 0x00021F90
		// (set) Token: 0x060001D5 RID: 469 RVA: 0x00023E44 File Offset: 0x00022044
		public bool RadErgoCfgVAWide_A41503_Visible
		{
			get
			{
				short num = (short)124715008;
				short num2 = num;
				num = (short)1527434142;
				short num3 = num;
				num = (short)741591966;
				switch (num3 == num)
				{
				}
				num = (short)1950220288;
				if (num != 0)
				{
				}
				num = (short)1411186689;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWide_A41503.Visible;
			}
			set
			{
				short num = (short)2000879616;
				short num2 = num;
				num = (short)438725527;
				short num3 = num;
				num = (short)590572439;
				switch (num3 == num)
				{
				}
				num = (short)265617409;
				if (num != 0)
				{
				}
				num = (short)499974144;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWide_A41503.Visible = value;
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x060001D6 RID: 470 RVA: 0x00023EF8 File Offset: 0x000220F8
		// (set) Token: 0x060001D7 RID: 471 RVA: 0x00023FAC File Offset: 0x000221AC
		public bool RadErgoCfgVAWide_A41503_Editable
		{
			get
			{
				short num = (short)2135425024;
				short num2 = num;
				num = (short)318107157;
				short num3 = num;
				num = (short)522251797;
				switch (num3 == num)
				{
				}
				num = (short)2031288320;
				if (num != 0)
				{
				}
				num = (short)213254145;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWide_A41503.Editable;
			}
			set
			{
				short num = (short)959709184;
				short num2 = num;
				num = (short)1179910145;
				if (num != 0)
				{
				}
				num = (short)1101714866;
				short num3 = num;
				num = (short)73258418;
				switch (num3 == num)
				{
				}
				num = (short)1753088000;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWide_A41503.Editable = value;
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x060001D8 RID: 472 RVA: 0x00024064 File Offset: 0x00022264
		internal string RadErgoCfgVAWide_A41503_UILabel
		{
			get
			{
				short num = (short)1565196288;
				short num2 = num;
				num = (short)1245093975;
				short num3 = num;
				num = (short)930390103;
				switch (num3 == num)
				{
				}
				num = (short)1809973249;
				if (num != 0)
				{
				}
				num = (short)1994784768;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWide_A41503.UIName;
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x060001D9 RID: 473 RVA: 0x00024118 File Offset: 0x00022318
		// (set) Token: 0x060001DA RID: 474 RVA: 0x000241CC File Offset: 0x000223CC
		internal bool RadErgoCfgVAWide_A41503_HiddenStatic
		{
			get
			{
				short num = (short)1919287296;
				short num2 = num;
				num = (short)1819738113;
				if (num != 0)
				{
				}
				num = (short)1330459927;
				short num3 = num;
				num = (short)513553687;
				switch (num3 == num)
				{
				}
				num = (short)573440000;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWide_A41503.HiddenStatic;
			}
			set
			{
				short num = (short)1583153152;
				short num2 = num;
				num = (short)1051328125;
				short num3 = num;
				num = (short)1075969661;
				switch (num3 == num)
				{
				}
				num = (short)1789853696;
				if (num != 0)
				{
				}
				num = (short)909180929;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWide_A41503.HiddenStatic = value;
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x060001DB RID: 475 RVA: 0x00024284 File Offset: 0x00022484
		// (set) Token: 0x060001DC RID: 476 RVA: 0x00024338 File Offset: 0x00022538
		internal bool RadErgoCfgVAWide_A41503_HiddenDynamic
		{
			get
			{
				short num = (short)2113505066;
				short num2 = num;
				num = (short)1365083946;
				switch (num2 == num)
				{
				}
				num = (short)1022689280;
				short num3 = num;
				num = (short)1106247681;
				if (num != 0)
				{
				}
				num = (short)529596416;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWide_A41503.HiddenDynamic;
			}
			set
			{
				short num = (short)1484193793;
				if (num != 0)
				{
				}
				num = (short)2070858046;
				short num2 = num;
				num = (short)2011941182;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1636630528;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1629224960;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWide_A41503.HiddenDynamic = value;
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x060001DD RID: 477 RVA: 0x000243EC File Offset: 0x000225EC
		public bool RadErgoCfgVAWide_A41503_HasDiffs
		{
			get
			{
				short num = (short)1490718291;
				short num2 = num;
				num = (short)1165397587;
				switch (num2 == num)
				{
				}
				num = (short)84213760;
				short num3 = num;
				num = (short)51642369;
				if (num != 0)
				{
				}
				num = (short)47644672;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWide_A41503._HasDiffs;
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x060001DE RID: 478 RVA: 0x000244A0 File Offset: 0x000226A0
		// (set) Token: 0x060001DF RID: 479 RVA: 0x00024554 File Offset: 0x00022754
		public int RadErgoCfgVAWide_A41504Value
		{
			get
			{
				short num = (short)765215814;
				short num2 = num;
				num = (short)1513374790;
				switch (num2 == num)
				{
				}
				num = (short)1311965184;
				short num3 = num;
				num = (short)532086784;
				if (num != 0)
				{
				}
				num = (short)2089549825;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWide_A41504.Value;
			}
			set
			{
				short num = (short)1961994990;
				short num2 = num;
				num = (short)909224686;
				switch (num2 == num)
				{
				}
				num = (short)1132462080;
				short num3 = num;
				num = (short)1350828033;
				if (num != 0)
				{
				}
				num = (short)1387462656;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWide_A41504.Value = value;
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x060001E0 RID: 480 RVA: 0x00024608 File Offset: 0x00022808
		// (set) Token: 0x060001E1 RID: 481 RVA: 0x000246BC File Offset: 0x000228BC
		public string RadErgoCfgVAWide_A41504_UIValue
		{
			get
			{
				short num = (short)2147358140;
				short num2 = num;
				num = (short)907810236;
				switch (num2 == num)
				{
				}
				num = (short)1273692160;
				short num3 = num;
				num = (short)926810113;
				if (num != 0)
				{
				}
				num = (short)1853947904;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWide_A41504.UIValue;
			}
			set
			{
				short num = (short)1452793732;
				short num2 = num;
				num = (short)780656516;
				switch (num2 == num)
				{
				}
				num = (short)549126144;
				short num3 = num;
				num = (short)1353777152;
				if (num != 0)
				{
				}
				num = (short)1353187329;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWide_A41504.UIValue = value;
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x060001E2 RID: 482 RVA: 0x00024774 File Offset: 0x00022974
		public global::AcpBusinessLayer.AcpRecRefField RadErgoCfgVAWide_A41504
		{
			get
			{
				short num = (short)1051617984;
				short num2 = num;
				num = (short)2107992768;
				switch (num2 == num)
				{
				}
				num = (short)292552704;
				short num3 = num;
				num = (short)1407844353;
				if (num != 0)
				{
				}
				num = (short)608174080;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWide_A41504;
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x060001E3 RID: 483 RVA: 0x00024824 File Offset: 0x00022A24
		// (set) Token: 0x060001E4 RID: 484 RVA: 0x000248D8 File Offset: 0x00022AD8
		public bool RadErgoCfgVAWide_A41504_Applicable
		{
			get
			{
				short num = (short)1561797492;
				short num2 = num;
				num = (short)2143691636;
				switch (num2 == num)
				{
				}
				num = (short)1901985792;
				short num3 = num;
				num = (short)1838546945;
				if (num != 0)
				{
				}
				num = (short)1952907264;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWide_A41504.Applicable;
			}
			set
			{
				short num = (short)1573133300;
				short num2 = num;
				num = (short)1037048820;
				switch (num2 == num)
				{
				}
				num = (short)238288896;
				short num3 = num;
				num = (short)1889533952;
				if (num != 0)
				{
				}
				num = (short)1251344385;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWide_A41504.Applicable = value;
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x060001E5 RID: 485 RVA: 0x0002498C File Offset: 0x00022B8C
		// (set) Token: 0x060001E6 RID: 486 RVA: 0x00024A40 File Offset: 0x00022C40
		public bool RadErgoCfgVAWide_A41504_Valid
		{
			get
			{
				short num = (short)836512789;
				short num2 = num;
				num = (short)864758805;
				switch (num2 == num)
				{
				}
				num = (short)1164771328;
				short num3 = num;
				num = (short)215089153;
				if (num != 0)
				{
				}
				num = (short)373620736;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWide_A41504.Valid;
			}
			set
			{
				short num = (short)922549228;
				short num2 = num;
				num = (short)99089388;
				switch (num2 == num)
				{
				}
				num = (short)1158086656;
				short num3 = num;
				num = (short)1614020609;
				if (num != 0)
				{
				}
				num = (short)1417740288;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWide_A41504.Valid = value;
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x060001E7 RID: 487 RVA: 0x00024AF4 File Offset: 0x00022CF4
		// (set) Token: 0x060001E8 RID: 488 RVA: 0x00024BAC File Offset: 0x00022DAC
		public bool RadErgoCfgVAWide_A41504_Visible
		{
			get
			{
				short num = (short)1641809363;
				short num2 = num;
				num = (short)1474233811;
				switch (num2 == num)
				{
				}
				num = (short)2115960832;
				short num3 = num;
				num = (short)529661953;
				if (num != 0)
				{
				}
				num = (short)577372160;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWide_A41504.Visible;
			}
			set
			{
				short num = (short)1443491219;
				short num2 = num;
				num = (short)1635446163;
				switch (num2 == num)
				{
				}
				num = (short)380764160;
				short num3 = num;
				num = (short)2077818881;
				if (num != 0)
				{
				}
				num = (short)1432748032;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWide_A41504.Visible = value;
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x060001E9 RID: 489 RVA: 0x00024C64 File Offset: 0x00022E64
		// (set) Token: 0x060001EA RID: 490 RVA: 0x00024D18 File Offset: 0x00022F18
		public bool RadErgoCfgVAWide_A41504_Editable
		{
			get
			{
				short num = (short)1434517505;
				if (num != 0)
				{
				}
				num = (short)1966677749;
				short num2 = num;
				num = (short)856039157;
				switch (num2 == num)
				{
				default:
				{
					num = (short)61407232;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)417202176;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWide_A41504.Editable;
			}
			set
			{
				short num = (short)438536930;
				short num2 = num;
				num = (short)1101236962;
				switch (num2 == num)
				{
				}
				num = (short)1716125696;
				short num3 = num;
				num = (short)1965490176;
				if (num != 0)
				{
				}
				num = (short)948371457;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWide_A41504.Editable = value;
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x060001EB RID: 491 RVA: 0x00024DD0 File Offset: 0x00022FD0
		internal string RadErgoCfgVAWide_A41504_UILabel
		{
			get
			{
				short num = (short)875462522;
				short num2 = num;
				num = (short)1594064762;
				switch (num2 == num)
				{
				}
				num = (short)316014592;
				short num3 = num;
				num = (short)284164097;
				if (num != 0)
				{
				}
				num = (short)589627392;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWide_A41504.UIName;
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x060001EC RID: 492 RVA: 0x00024E84 File Offset: 0x00023084
		// (set) Token: 0x060001ED RID: 493 RVA: 0x00024F38 File Offset: 0x00023138
		internal bool RadErgoCfgVAWide_A41504_HiddenStatic
		{
			get
			{
				short num = (short)1000714846;
				short num2 = num;
				num = (short)1148564062;
				switch (num2 == num)
				{
				}
				num = (short)1453850624;
				short num3 = num;
				num = (short)1389690880;
				if (num != 0)
				{
				}
				num = (short)1011875841;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWide_A41504.HiddenStatic;
			}
			set
			{
				short num = (short)1012674228;
				short num2 = num;
				num = (short)1081290420;
				switch (num2 == num)
				{
				}
				num = (short)762707968;
				short num3 = num;
				num = (short)494600193;
				if (num != 0)
				{
				}
				num = (short)1469841408;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWide_A41504.HiddenStatic = value;
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x060001EE RID: 494 RVA: 0x00024FF0 File Offset: 0x000231F0
		// (set) Token: 0x060001EF RID: 495 RVA: 0x000250A4 File Offset: 0x000232A4
		internal bool RadErgoCfgVAWide_A41504_HiddenDynamic
		{
			get
			{
				short num = (short)163594835;
				short num2 = num;
				num = (short)2061451859;
				switch (num2 == num)
				{
				}
				num = (short)1156513792;
				short num3 = num;
				num = (short)1682243584;
				if (num != 0)
				{
				}
				num = (short)1139081217;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWide_A41504.HiddenDynamic;
			}
			set
			{
				short num = (short)983614376;
				short num2 = num;
				num = (short)368755624;
				switch (num2 == num)
				{
				}
				num = (short)760283136;
				short num3 = num;
				num = (short)1998651393;
				if (num != 0)
				{
				}
				num = (short)231211008;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWide_A41504.HiddenDynamic = value;
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x060001F0 RID: 496 RVA: 0x0002515C File Offset: 0x0002335C
		public bool RadErgoCfgVAWide_A41504_HasDiffs
		{
			get
			{
				short num = (short)1194190879;
				short num2 = num;
				num = (short)192210975;
				switch (num2 == num)
				{
				}
				num = (short)420347904;
				short num3 = num;
				num = (short)1237778432;
				if (num != 0)
				{
				}
				num = (short)1712979969;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWide_A41504._HasDiffs;
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x060001F1 RID: 497 RVA: 0x00025210 File Offset: 0x00023410
		// (set) Token: 0x060001F2 RID: 498 RVA: 0x000252C4 File Offset: 0x000234C4
		public int RadErgoCfgVAWide_A41505Value
		{
			get
			{
				short num = (short)1431657511;
				short num2 = num;
				num = (short)2116508711;
				switch (num2 == num)
				{
				}
				num = (short)695271424;
				short num3 = num;
				num = (short)1163001857;
				if (num != 0)
				{
				}
				num = (short)288751616;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWide_A41505.Value;
			}
			set
			{
				short num = (short)125028242;
				short num2 = num;
				num = (short)787924882;
				switch (num2 == num)
				{
				}
				num = (short)583204864;
				short num3 = num;
				num = (short)844955649;
				if (num != 0)
				{
				}
				num = (short)1943994368;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWide_A41505.Value = value;
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x060001F3 RID: 499 RVA: 0x00025378 File Offset: 0x00023578
		// (set) Token: 0x060001F4 RID: 500 RVA: 0x00025430 File Offset: 0x00023630
		public string RadErgoCfgVAWide_A41505_UIValue
		{
			get
			{
				short num = (short)422975807;
				short num2 = num;
				num = (short)1778784575;
				switch (num2 == num)
				{
				}
				num = (short)1043726336;
				short num3 = num;
				num = (short)1230503937;
				if (num != 0)
				{
				}
				num = (short)329449472;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWide_A41505.UIValue;
			}
			set
			{
				short num = (short)1015752066;
				short num2 = num;
				num = (short)527836546;
				switch (num2 == num)
				{
				}
				num = (short)1411645440;
				short num3 = num;
				num = (short)1087832065;
				if (num != 0)
				{
				}
				num = (short)1075904512;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWide_A41505.UIValue = value;
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x060001F5 RID: 501 RVA: 0x000254E4 File Offset: 0x000236E4
		public global::AcpBusinessLayer.AcpRecRefField RadErgoCfgVAWide_A41505
		{
			get
			{
				short num = (short)1870586471;
				short num2 = num;
				num = (short)307159655;
				switch (num2 == num)
				{
				}
				num = (short)583270400;
				short num3 = num;
				num = (short)1326579712;
				if (num != 0)
				{
				}
				num = (short)80084993;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWide_A41505;
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x060001F6 RID: 502 RVA: 0x00025594 File Offset: 0x00023794
		// (set) Token: 0x060001F7 RID: 503 RVA: 0x00025648 File Offset: 0x00023848
		public bool RadErgoCfgVAWide_A41505_Applicable
		{
			get
			{
				short num = (short)1599699185;
				short num2 = num;
				num = (short)366835953;
				switch (num2 == num)
				{
				}
				num = (short)720896000;
				short num3 = num;
				num = (short)2086928385;
				if (num != 0)
				{
				}
				num = (short)39911424;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWide_A41505.Applicable;
			}
			set
			{
				short num = (short)309333326;
				short num2 = num;
				num = (short)446565710;
				switch (num2 == num)
				{
				}
				num = (short)1964310528;
				short num3 = num;
				num = (short)135397377;
				if (num != 0)
				{
				}
				num = (short)825163776;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWide_A41505.Applicable = value;
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x060001F8 RID: 504 RVA: 0x00025700 File Offset: 0x00023900
		// (set) Token: 0x060001F9 RID: 505 RVA: 0x000257B0 File Offset: 0x000239B0
		public bool RadErgoCfgVAWide_A41505_Valid
		{
			get
			{
				short num = (short)1701306646;
				short num2 = num;
				num = (short)485155094;
				switch (num2 == num)
				{
				}
				num = (short)1631911936;
				short num3 = num;
				num = (short)1110245377;
				if (num != 0)
				{
				}
				num = (short)976027648;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWide_A41505.Valid;
			}
			set
			{
				short num = (short)450695368;
				short num2 = num;
				num = (short)253956296;
				switch (num2 == num)
				{
				}
				num = (short)1795555328;
				short num3 = num;
				num = (short)1553006592;
				if (num != 0)
				{
				}
				num = (short)212205569;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWide_A41505.Valid = value;
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x060001FA RID: 506 RVA: 0x00025864 File Offset: 0x00023A64
		// (set) Token: 0x060001FB RID: 507 RVA: 0x00025918 File Offset: 0x00023B18
		public bool RadErgoCfgVAWide_A41505_Visible
		{
			get
			{
				short num = (short)1678436052;
				short num2 = num;
				num = (short)2031347412;
				switch (num2 == num)
				{
				}
				num = (short)653459456;
				short num3 = num;
				num = (short)518324225;
				if (num != 0)
				{
				}
				num = (short)1317142528;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWide_A41505.Visible;
			}
			set
			{
				short num = (short)264547037;
				short num2 = num;
				num = (short)932555485;
				switch (num2 == num)
				{
				}
				num = (short)1659174912;
				short num3 = num;
				num = (short)940244992;
				if (num != 0)
				{
				}
				num = (short)1965031425;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWide_A41505.Visible = value;
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x060001FC RID: 508 RVA: 0x000259D0 File Offset: 0x00023BD0
		// (set) Token: 0x060001FD RID: 509 RVA: 0x00025A80 File Offset: 0x00023C80
		public bool RadErgoCfgVAWide_A41505_Editable
		{
			get
			{
				short num = (short)1662646711;
				short num2 = num;
				num = (short)1874262455;
				switch (num2 == num)
				{
				}
				num = (short)592183296;
				short num3 = num;
				num = (short)536150017;
				if (num != 0)
				{
				}
				num = (short)609812480;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWide_A41505.Editable;
			}
			set
			{
				short num = (short)1142525201;
				short num2 = num;
				num = (short)734694673;
				switch (num2 == num)
				{
				}
				num = (short)1732444160;
				short num3 = num;
				num = (short)2063532033;
				if (num != 0)
				{
				}
				num = (short)483524608;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWide_A41505.Editable = value;
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x060001FE RID: 510 RVA: 0x00025B34 File Offset: 0x00023D34
		internal string RadErgoCfgVAWide_A41505_UILabel
		{
			get
			{
				short num = (short)1767899137;
				if (num != 0)
				{
				}
				num = (short)1122284934;
				short num2 = num;
				num = (short)2129900934;
				switch (num2 == num)
				{
				default:
				{
					num = (short)423362560;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2029780992;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWide_A41505.UIName;
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x060001FF RID: 511 RVA: 0x00025BE4 File Offset: 0x00023DE4
		// (set) Token: 0x06000200 RID: 512 RVA: 0x00025C9C File Offset: 0x00023E9C
		internal bool RadErgoCfgVAWide_A41505_HiddenStatic
		{
			get
			{
				short num = (short)627994638;
				short num2 = num;
				num = (short)1790734350;
				switch (num2 == num)
				{
				}
				num = (short)1921581056;
				short num3 = num;
				num = (short)1218314241;
				if (num != 0)
				{
				}
				num = (short)1265565696;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWide_A41505.HiddenStatic;
			}
			set
			{
				short num = (short)1045439736;
				short num2 = num;
				num = (short)192488696;
				switch (num2 == num)
				{
				}
				num = (short)21430272;
				short num3 = num;
				num = (short)1750073345;
				if (num != 0)
				{
				}
				num = (short)1027211264;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWide_A41505.HiddenStatic = value;
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x06000201 RID: 513 RVA: 0x00025D50 File Offset: 0x00023F50
		// (set) Token: 0x06000202 RID: 514 RVA: 0x00025E04 File Offset: 0x00024004
		internal bool RadErgoCfgVAWide_A41505_HiddenDynamic
		{
			get
			{
				short num = (short)1932764066;
				short num2 = num;
				num = (short)344040354;
				switch (num2 == num)
				{
				}
				num = (short)11206656;
				short num3 = num;
				num = (short)646184961;
				if (num != 0)
				{
				}
				num = (short)1615396864;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWide_A41505.HiddenDynamic;
			}
			set
			{
				short num = (short)1574150992;
				short num2 = num;
				num = (short)614048592;
				switch (num2 == num)
				{
				default:
				{
					num = (short)212205568;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1618477057;
				if (num != 0)
				{
				}
				num = (short)1506344960;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWide_A41505.HiddenDynamic = value;
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06000203 RID: 515 RVA: 0x00025EB8 File Offset: 0x000240B8
		public bool RadErgoCfgVAWide_A41505_HasDiffs
		{
			get
			{
				short num = (short)1299722791;
				short num2 = num;
				num = (short)252785191;
				switch (num2 == num)
				{
				default:
				{
					num = (short)960954368;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)309985280;
				if (num != 0)
				{
				}
				num = (short)1935998977;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWide_A41505._HasDiffs;
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06000204 RID: 516 RVA: 0x00025F70 File Offset: 0x00024170
		// (set) Token: 0x06000205 RID: 517 RVA: 0x00026028 File Offset: 0x00024228
		public int RadErgoCfgVAWide_A41506Value
		{
			get
			{
				short num = (short)1570137590;
				short num2 = num;
				num = (short)1079535094;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1074724864;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)767033344;
				if (num != 0)
				{
				}
				num = (short)386531329;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWide_A41506.Value;
			}
			set
			{
				short num = (short)271345416;
				short num2 = num;
				num = (short)124413704;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2135490560;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2115239936;
				if (num != 0)
				{
				}
				num = (short)125304833;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWide_A41506.Value = value;
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x06000206 RID: 518 RVA: 0x000260DC File Offset: 0x000242DC
		// (set) Token: 0x06000207 RID: 519 RVA: 0x00026190 File Offset: 0x00024390
		public string RadErgoCfgVAWide_A41506_UIValue
		{
			get
			{
				short num = (short)1211827841;
				short num2 = num;
				num = (short)1657407105;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2069561344;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1667235840;
				if (num != 0)
				{
				}
				num = (short)183435265;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWide_A41506.UIValue;
			}
			set
			{
				short num = (short)634608172;
				short num2 = num;
				num = (short)1274960428;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1033371648;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)722403329;
				if (num != 0)
				{
				}
				num = (short)1440284672;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWide_A41506.UIValue = value;
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x06000208 RID: 520 RVA: 0x00026248 File Offset: 0x00024448
		public global::AcpBusinessLayer.AcpRecRefField RadErgoCfgVAWide_A41506
		{
			get
			{
				short num = (short)811398596;
				short num2 = num;
				num = (short)1125774788;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2107834368;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1846411265;
				if (num != 0)
				{
				}
				num = (short)926482432;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWide_A41506;
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x06000209 RID: 521 RVA: 0x000262F8 File Offset: 0x000244F8
		// (set) Token: 0x0600020A RID: 522 RVA: 0x000263AC File Offset: 0x000245AC
		public bool RadErgoCfgVAWide_A41506_Applicable
		{
			get
			{
				short num = (short)668089545;
				short num2 = num;
				num = (short)771833033;
				switch (num2 == num)
				{
				default:
				{
					num = (short)7077888;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)39518209;
				if (num != 0)
				{
				}
				num = (short)80805888;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWide_A41506.Applicable;
			}
			set
			{
				short num = (short)420632539;
				short num2 = num;
				num = (short)1997821915;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1155268608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)303824897;
				if (num != 0)
				{
				}
				num = (short)914685952;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWide_A41506.Applicable = value;
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x0600020B RID: 523 RVA: 0x00026464 File Offset: 0x00024664
		// (set) Token: 0x0600020C RID: 524 RVA: 0x00026518 File Offset: 0x00024718
		public bool RadErgoCfgVAWide_A41506_Valid
		{
			get
			{
				short num = (short)1673702568;
				short num2 = num;
				num = (short)537504936;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1491140608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1485832192;
				if (num != 0)
				{
				}
				num = (short)1462894593;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWide_A41506.Valid;
			}
			set
			{
				short num = (short)705224885;
				short num2 = num;
				num = (short)263446709;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1272971264;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)232521729;
				if (num != 0)
				{
				}
				num = (short)1020526592;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWide_A41506.Valid = value;
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x0600020D RID: 525 RVA: 0x000265D0 File Offset: 0x000247D0
		// (set) Token: 0x0600020E RID: 526 RVA: 0x00026684 File Offset: 0x00024884
		public bool RadErgoCfgVAWide_A41506_Visible
		{
			get
			{
				short num = (short)1902997147;
				short num2 = num;
				num = (short)1657106075;
				switch (num2 == num)
				{
				default:
				{
					num = (short)722141184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)60162049;
				if (num != 0)
				{
				}
				num = (short)381026304;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWide_A41506.Visible;
			}
			set
			{
				short num = (short)1138762580;
				short num2 = num;
				num = (short)1799365460;
				switch (num2 == num)
				{
				default:
				{
					num = (short)170917888;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)195100673;
				if (num != 0)
				{
				}
				num = (short)38797312;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWide_A41506.Visible = value;
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x0600020F RID: 527 RVA: 0x00026738 File Offset: 0x00024938
		// (set) Token: 0x06000210 RID: 528 RVA: 0x000267EC File Offset: 0x000249EC
		public bool RadErgoCfgVAWide_A41506_Editable
		{
			get
			{
				short num = (short)1285976482;
				short num2 = num;
				num = (short)696807842;
				switch (num2 == num)
				{
				default:
				{
					num = (short)419692544;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1415512064;
				if (num != 0)
				{
				}
				num = (short)1964179457;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWide_A41506.Editable;
			}
			set
			{
				short num = (short)1022951425;
				if (num != 0)
				{
				}
				num = (short)1024458752;
				short num2 = num;
				num = (short)1537798852;
				short num3 = num;
				num = (short)1653011140;
				switch (num3 == num)
				{
				}
				num = (short)1824849920;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWide_A41506.Editable = value;
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x06000211 RID: 529 RVA: 0x000268A0 File Offset: 0x00024AA0
		internal string RadErgoCfgVAWide_A41506_UILabel
		{
			get
			{
				short num = (short)157498068;
				short num2 = num;
				num = (short)2088516308;
				switch (num2 == num)
				{
				default:
				{
					num = (short)885719040;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)987037697;
				if (num != 0)
				{
				}
				num = (short)1242431488;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWide_A41506.UIName;
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x06000212 RID: 530 RVA: 0x00026950 File Offset: 0x00024B50
		// (set) Token: 0x06000213 RID: 531 RVA: 0x00026A08 File Offset: 0x00024C08
		internal bool RadErgoCfgVAWide_A41506_HiddenStatic
		{
			get
			{
				short num = (short)1571659530;
				short num2 = num;
				num = (short)409050890;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1945239552;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)137363457;
				if (num != 0)
				{
				}
				num = (short)897056768;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWide_A41506.HiddenStatic;
			}
			set
			{
				short num = (short)1642753302;
				short num2 = num;
				num = (short)47738134;
				switch (num2 == num)
				{
				default:
				{
					num = (short)431882240;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)621477889;
				if (num != 0)
				{
				}
				num = (short)414056448;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWide_A41506.HiddenStatic = value;
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x06000214 RID: 532 RVA: 0x00026AC0 File Offset: 0x00024CC0
		// (set) Token: 0x06000215 RID: 533 RVA: 0x00026B74 File Offset: 0x00024D74
		internal bool RadErgoCfgVAWide_A41506_HiddenDynamic
		{
			get
			{
				short num = (short)1431029441;
				short num2 = num;
				num = (short)179750593;
				switch (num2 == num)
				{
				default:
				{
					num = (short)697040896;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1547370496;
				if (num != 0)
				{
				}
				num = (short)707067905;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWide_A41506.HiddenDynamic;
			}
			set
			{
				short num = (short)1409755911;
				short num2 = num;
				num = (short)1908878087;
				switch (num2 == num)
				{
				default:
				{
					num = (short)207486976;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)169607169;
				if (num != 0)
				{
				}
				num = (short)610271232;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWide_A41506.HiddenDynamic = value;
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x06000216 RID: 534 RVA: 0x00026C2C File Offset: 0x00024E2C
		public bool RadErgoCfgVAWide_A41506_HasDiffs
		{
			get
			{
				short num = (short)1589282156;
				short num2 = num;
				num = (short)500925804;
				switch (num2 == num)
				{
				default:
				{
					num = (short)427950080;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)307429376;
				if (num != 0)
				{
				}
				num = (short)498728961;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWide_A41506._HasDiffs;
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x06000217 RID: 535 RVA: 0x00026CE0 File Offset: 0x00024EE0
		// (set) Token: 0x06000218 RID: 536 RVA: 0x00026D98 File Offset: 0x00024F98
		public int WrongBatteryOnAnnouncementID_43251Value
		{
			get
			{
				short num = (short)655569748;
				short num2 = num;
				num = (short)3617620;
				switch (num2 == num)
				{
				default:
				{
					num = (short)553123840;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1924005889;
				if (num != 0)
				{
				}
				num = (short)1584660480;
				if (num != 0)
				{
				}
				return this.wrongBatteryOnAnnouncementID_43251.Value;
			}
			set
			{
				short num = (short)172517010;
				short num2 = num;
				num = (short)635463314;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1496973312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1430585345;
				if (num != 0)
				{
				}
				num = (short)625606656;
				if (num != 0)
				{
				}
				this.wrongBatteryOnAnnouncementID_43251.Value = value;
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x06000219 RID: 537 RVA: 0x00026E4C File Offset: 0x0002504C
		// (set) Token: 0x0600021A RID: 538 RVA: 0x00026F00 File Offset: 0x00025100
		public string WrongBatteryOnAnnouncementID_43251_UIValue
		{
			get
			{
				short num = (short)1723948402;
				short num2 = num;
				num = (short)1422351730;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1055457280;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)882376705;
				if (num != 0)
				{
				}
				num = (short)416677888;
				if (num != 0)
				{
				}
				return this.wrongBatteryOnAnnouncementID_43251.UIValue;
			}
			set
			{
				short num = (short)231555678;
				short num2 = num;
				num = (short)1025786462;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2060451840;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2028011520;
				if (num != 0)
				{
				}
				num = (short)1640628225;
				if (num != 0)
				{
				}
				this.wrongBatteryOnAnnouncementID_43251.UIValue = value;
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x0600021B RID: 539 RVA: 0x00026FB4 File Offset: 0x000251B4
		public global::AcpBusinessLayer.AcpRecRefField WrongBatteryOnAnnouncementID_43251
		{
			get
			{
				short num = (short)864422700;
				short num2 = num;
				num = (short)174918444;
				switch (num2 == num)
				{
				default:
				{
					num = (short)521535488;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1112932352;
				if (num != 0)
				{
				}
				num = (short)139919361;
				if (num != 0)
				{
				}
				return this.wrongBatteryOnAnnouncementID_43251;
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x0600021C RID: 540 RVA: 0x00027064 File Offset: 0x00025264
		// (set) Token: 0x0600021D RID: 541 RVA: 0x00027118 File Offset: 0x00025318
		public bool WrongBatteryOnAnnouncementID_43251_Applicable
		{
			get
			{
				short num = (short)1358447936;
				short num2 = num;
				num = (short)1297696064;
				switch (num2 == num)
				{
				default:
				{
					num = (short)352124928;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1335885825;
				if (num != 0)
				{
				}
				num = (short)879493120;
				if (num != 0)
				{
				}
				return this.wrongBatteryOnAnnouncementID_43251.Applicable;
			}
			set
			{
				short num = (short)1806848270;
				short num2 = num;
				num = (short)1353404686;
				switch (num2 == num)
				{
				default:
				{
					num = (short)178585600;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)252903425;
				if (num != 0)
				{
				}
				num = (short)317980672;
				if (num != 0)
				{
				}
				this.wrongBatteryOnAnnouncementID_43251.Applicable = value;
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x0600021E RID: 542 RVA: 0x000271D0 File Offset: 0x000253D0
		// (set) Token: 0x0600021F RID: 543 RVA: 0x00027284 File Offset: 0x00025484
		public bool WrongBatteryOnAnnouncementID_43251_Valid
		{
			get
			{
				short num = (short)374145025;
				if (num != 0)
				{
				}
				num = (short)1623523328;
				short num2 = num;
				num = (short)410192923;
				short num3 = num;
				num = (short)1382812699;
				switch (num3 == num)
				{
				}
				num = (short)1412300800;
				if (num != 0)
				{
				}
				return this.wrongBatteryOnAnnouncementID_43251.Valid;
			}
			set
			{
				short num = (short)40263809;
				short num2 = num;
				num = (short)1835753601;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2138243072;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)683147265;
				if (num != 0)
				{
				}
				num = (short)1179123712;
				if (num != 0)
				{
				}
				this.wrongBatteryOnAnnouncementID_43251.Valid = value;
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x06000220 RID: 544 RVA: 0x00027338 File Offset: 0x00025538
		// (set) Token: 0x06000221 RID: 545 RVA: 0x000273E8 File Offset: 0x000255E8
		public bool WrongBatteryOnAnnouncementID_43251_Visible
		{
			get
			{
				short num = (short)224985089;
				if (num != 0)
				{
				}
				num = (short)1517486080;
				short num2 = num;
				num = (short)170420591;
				short num3 = num;
				num = (short)73427311;
				switch (num3 == num)
				{
				}
				num = (short)948043776;
				if (num != 0)
				{
				}
				return this.wrongBatteryOnAnnouncementID_43251.Visible;
			}
			set
			{
				short num = (short)1811552979;
				short num2 = num;
				num = (short)1968773843;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1969881088;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1809776641;
				if (num != 0)
				{
				}
				num = (short)1897660416;
				if (num != 0)
				{
				}
				this.wrongBatteryOnAnnouncementID_43251.Visible = value;
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x06000222 RID: 546 RVA: 0x0002749C File Offset: 0x0002569C
		// (set) Token: 0x06000223 RID: 547 RVA: 0x00027554 File Offset: 0x00025754
		public bool WrongBatteryOnAnnouncementID_43251_Editable
		{
			get
			{
				short num = (short)1313430145;
				short num2 = num;
				num = (short)1082808961;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1456865280;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)760807425;
				if (num != 0)
				{
				}
				num = (short)250675200;
				if (num != 0)
				{
				}
				return this.wrongBatteryOnAnnouncementID_43251.Editable;
			}
			set
			{
				short num = (short)526913211;
				short num2 = num;
				num = (short)3018427;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2091712512;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1894449153;
				if (num != 0)
				{
				}
				num = (short)1564344320;
				if (num != 0)
				{
				}
				this.wrongBatteryOnAnnouncementID_43251.Editable = value;
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x06000224 RID: 548 RVA: 0x0002760C File Offset: 0x0002580C
		internal string WrongBatteryOnAnnouncementID_43251_UILabel
		{
			get
			{
				short num = (short)1112378211;
				short num2 = num;
				num = (short)1703906147;
				switch (num2 == num)
				{
				default:
				{
					num = (short)694812672;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1544290304;
				if (num != 0)
				{
				}
				num = (short)101449729;
				if (num != 0)
				{
				}
				return this.wrongBatteryOnAnnouncementID_43251.UIName;
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x06000225 RID: 549 RVA: 0x000276C0 File Offset: 0x000258C0
		// (set) Token: 0x06000226 RID: 550 RVA: 0x00027774 File Offset: 0x00025974
		internal bool WrongBatteryOnAnnouncementID_43251_HiddenStatic
		{
			get
			{
				short num = (short)12713985;
				if (num != 0)
				{
				}
				num = (short)648478720;
				short num2 = num;
				num = (short)1922109483;
				short num3 = num;
				num = (short)206508075;
				switch (num3 == num)
				{
				}
				num = (short)500629504;
				if (num != 0)
				{
				}
				return this.wrongBatteryOnAnnouncementID_43251.HiddenStatic;
			}
			set
			{
				short num = (short)895704498;
				short num2 = num;
				num = (short)1888640434;
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
				num = (short)1038090241;
				if (num != 0)
				{
				}
				num = (short)1314979840;
				if (num != 0)
				{
				}
				this.wrongBatteryOnAnnouncementID_43251.HiddenStatic = value;
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x06000227 RID: 551 RVA: 0x0002782C File Offset: 0x00025A2C
		// (set) Token: 0x06000228 RID: 552 RVA: 0x000278E4 File Offset: 0x00025AE4
		internal bool WrongBatteryOnAnnouncementID_43251_HiddenDynamic
		{
			get
			{
				short num = (short)1228505366;
				short num2 = num;
				num = (short)233865494;
				switch (num2 == num)
				{
				default:
				{
					num = (short)927006720;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)842137601;
				if (num != 0)
				{
				}
				num = (short)1275461632;
				if (num != 0)
				{
				}
				return this.wrongBatteryOnAnnouncementID_43251.HiddenDynamic;
			}
			set
			{
				short num = (short)972182949;
				short num2 = num;
				num = (short)1795904933;
				switch (num2 == num)
				{
				default:
				{
					num = (short)713949184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1762656256;
				if (num != 0)
				{
				}
				num = (short)1572274177;
				if (num != 0)
				{
				}
				this.wrongBatteryOnAnnouncementID_43251.HiddenDynamic = value;
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x06000229 RID: 553 RVA: 0x0002799C File Offset: 0x00025B9C
		public bool WrongBatteryOnAnnouncementID_43251_HasDiffs
		{
			get
			{
				short num = (short)673017189;
				short num2 = num;
				num = (short)1020161381;
				switch (num2 == num)
				{
				default:
				{
					num = (short)546701312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)469499905;
				if (num != 0)
				{
				}
				num = (short)1272119296;
				if (num != 0)
				{
				}
				return this.wrongBatteryOnAnnouncementID_43251._HasDiffs;
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x0600022A RID: 554 RVA: 0x00027A50 File Offset: 0x00025C50
		// (set) Token: 0x0600022B RID: 555 RVA: 0x00027B04 File Offset: 0x00025D04
		public string RadErgoScanOnAnnouncementVoiceCommandValue
		{
			get
			{
				short num = (short)65414010;
				short num2 = num;
				num = (short)1594303354;
				switch (num2 == num)
				{
				default:
				{
					num = (short)178061312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1776156672;
				if (num != 0)
				{
				}
				num = (short)1174405121;
				if (num != 0)
				{
				}
				return this.radErgoScanOnAnnouncementVoiceCommand.Value;
			}
			set
			{
				short num = (short)1716447417;
				short num2 = num;
				num = (short)635234489;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1326776320;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1171914752;
				if (num != 0)
				{
				}
				num = (short)1916534785;
				if (num != 0)
				{
				}
				this.radErgoScanOnAnnouncementVoiceCommand.Value = value;
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x0600022C RID: 556 RVA: 0x00027BBC File Offset: 0x00025DBC
		public global::AcpBusinessLayer.AcpField<string> RadErgoScanOnAnnouncementVoiceCommand
		{
			get
			{
				short num = (short)1472105100;
				short num2 = num;
				num = (short)1796442764;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1412628480;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1443364865;
				if (num != 0)
				{
				}
				num = (short)1564409856;
				if (num != 0)
				{
				}
				return this.radErgoScanOnAnnouncementVoiceCommand;
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x0600022D RID: 557 RVA: 0x00027C68 File Offset: 0x00025E68
		// (set) Token: 0x0600022E RID: 558 RVA: 0x00027D1C File Offset: 0x00025F1C
		public string RadErgoScanOnAnnouncementVoiceCommand_UIValue
		{
			get
			{
				short num = (short)929680457;
				short num2 = num;
				num = (short)220253257;
				switch (num2 == num)
				{
				default:
				{
					num = (short)413270016;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)202768384;
				if (num != 0)
				{
				}
				num = (short)2017525761;
				if (num != 0)
				{
				}
				return this.radErgoScanOnAnnouncementVoiceCommand.Value;
			}
			set
			{
				short num = (short)439495832;
				short num2 = num;
				num = (short)1649159320;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1902903296;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1230962689;
				if (num != 0)
				{
				}
				num = (short)1289027584;
				if (num != 0)
				{
				}
				this.radErgoScanOnAnnouncementVoiceCommand.Value = value;
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x0600022F RID: 559 RVA: 0x00027DD4 File Offset: 0x00025FD4
		// (set) Token: 0x06000230 RID: 560 RVA: 0x00027E8C File Offset: 0x0002608C
		public bool RadErgoScanOnAnnouncementVoiceCommand_Applicable
		{
			get
			{
				short num = (short)1856336506;
				short num2 = num;
				num = (short)151810682;
				switch (num2 == num)
				{
				}
				num = (short)410320896;
				if (num != 0)
				{
				}
				num = (short)1138425856;
				short num3 = num;
				num = (short)1214775297;
				if (num != 0)
				{
				}
				return this.radErgoScanOnAnnouncementVoiceCommand.Applicable;
			}
			set
			{
				short num = (short)1699212659;
				short num2 = num;
				num = (short)1413934451;
				switch (num2 == num)
				{
				}
				num = (short)1296760833;
				if (num != 0)
				{
				}
				num = (short)1655832576;
				short num3 = num;
				num = (short)88735744;
				if (num != 0)
				{
				}
				this.radErgoScanOnAnnouncementVoiceCommand.Applicable = value;
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x06000231 RID: 561 RVA: 0x00027F44 File Offset: 0x00026144
		// (set) Token: 0x06000232 RID: 562 RVA: 0x00027FF8 File Offset: 0x000261F8
		public bool RadErgoScanOnAnnouncementVoiceCommand_Valid
		{
			get
			{
				short num = (short)315520306;
				short num2 = num;
				num = (short)1560311090;
				switch (num2 == num)
				{
				}
				num = (short)1133641729;
				if (num != 0)
				{
				}
				num = (short)1884422144;
				short num3 = num;
				num = (short)2088304640;
				if (num != 0)
				{
				}
				return this.radErgoScanOnAnnouncementVoiceCommand.Valid;
			}
			set
			{
				short num = (short)2107750424;
				short num2 = num;
				num = (short)1023195160;
				switch (num2 == num)
				{
				}
				num = (short)552730624;
				if (num != 0)
				{
				}
				num = (short)1376583680;
				short num3 = num;
				num = (short)780664833;
				if (num != 0)
				{
				}
				this.radErgoScanOnAnnouncementVoiceCommand.Valid = value;
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x06000233 RID: 563 RVA: 0x000280B0 File Offset: 0x000262B0
		// (set) Token: 0x06000234 RID: 564 RVA: 0x00028164 File Offset: 0x00026364
		public bool RadErgoScanOnAnnouncementVoiceCommand_Visible
		{
			get
			{
				short num = (short)1151647458;
				short num2 = num;
				num = (short)937148130;
				switch (num2 == num)
				{
				}
				num = (short)1695481856;
				if (num != 0)
				{
				}
				num = (short)1432682496;
				short num3 = num;
				num = (short)1004601345;
				if (num != 0)
				{
				}
				return this.radErgoScanOnAnnouncementVoiceCommand.Visible;
			}
			set
			{
				short num = (short)1505357318;
				short num2 = num;
				num = (short)2087185926;
				switch (num2 == num)
				{
				}
				num = (short)1242628096;
				if (num != 0)
				{
				}
				num = (short)896663552;
				short num3 = num;
				num = (short)2083848193;
				if (num != 0)
				{
				}
				this.radErgoScanOnAnnouncementVoiceCommand.Visible = value;
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x06000235 RID: 565 RVA: 0x00028218 File Offset: 0x00026418
		// (set) Token: 0x06000236 RID: 566 RVA: 0x000282CC File Offset: 0x000264CC
		public bool RadErgoScanOnAnnouncementVoiceCommand_Editable
		{
			get
			{
				short num = (short)776357999;
				short num2 = num;
				num = (short)1082148975;
				switch (num2 == num)
				{
				}
				num = (short)1738014721;
				if (num != 0)
				{
				}
				num = (short)803471360;
				short num3 = num;
				num = (short)2112880640;
				if (num != 0)
				{
				}
				return this.radErgoScanOnAnnouncementVoiceCommand.Editable;
			}
			set
			{
				short num = (short)1447799117;
				short num2 = num;
				num = (short)1017358669;
				switch (num2 == num)
				{
				}
				num = (short)562823169;
				if (num != 0)
				{
				}
				num = (short)83886080;
				short num3 = num;
				num = (short)1016135680;
				if (num != 0)
				{
				}
				this.radErgoScanOnAnnouncementVoiceCommand.Editable = value;
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x06000237 RID: 567 RVA: 0x00028380 File Offset: 0x00026580
		internal string RadErgoScanOnAnnouncementVoiceCommand_UILabel
		{
			get
			{
				short num = (short)889977328;
				short num2 = num;
				num = (short)860092912;
				switch (num2 == num)
				{
				}
				num = (short)282001408;
				if (num != 0)
				{
				}
				num = (short)1378025472;
				short num3 = num;
				num = (short)345505793;
				if (num != 0)
				{
				}
				return this.radErgoScanOnAnnouncementVoiceCommand.UIName;
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x06000238 RID: 568 RVA: 0x00028434 File Offset: 0x00026634
		// (set) Token: 0x06000239 RID: 569 RVA: 0x000284E8 File Offset: 0x000266E8
		internal bool RadErgoScanOnAnnouncementVoiceCommand_HiddenStatic
		{
			get
			{
				short num = (short)1811422773;
				short num2 = num;
				num = (short)2134646325;
				switch (num2 == num)
				{
				}
				num = (short)1547698177;
				if (num != 0)
				{
				}
				num = (short)220528640;
				short num3 = num;
				num = (short)297926656;
				if (num != 0)
				{
				}
				return this.radErgoScanOnAnnouncementVoiceCommand.HiddenStatic;
			}
			set
			{
				short num = (short)994144252;
				short num2 = num;
				num = (short)5861372;
				switch (num2 == num)
				{
				}
				num = (short)1264386049;
				if (num != 0)
				{
				}
				num = (short)334495744;
				short num3 = num;
				num = (short)1605697536;
				if (num != 0)
				{
				}
				this.radErgoScanOnAnnouncementVoiceCommand.HiddenStatic = value;
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x0600023A RID: 570 RVA: 0x0002859C File Offset: 0x0002679C
		// (set) Token: 0x0600023B RID: 571 RVA: 0x00028650 File Offset: 0x00026850
		internal bool RadErgoScanOnAnnouncementVoiceCommand_HiddenDynamic
		{
			get
			{
				short num = (short)578210709;
				short num2 = num;
				num = (short)835505045;
				switch (num2 == num)
				{
				}
				num = (short)1455030273;
				if (num != 0)
				{
				}
				num = (short)1134690304;
				short num3 = num;
				num = (short)1764818944;
				if (num != 0)
				{
				}
				return this.radErgoScanOnAnnouncementVoiceCommand.HiddenDynamic;
			}
			set
			{
				short num = (short)1061226627;
				short num2 = num;
				num = (short)1827473539;
				switch (num2 == num)
				{
				}
				num = (short)436338689;
				if (num != 0)
				{
				}
				num = (short)1370619904;
				short num3 = num;
				num = (short)1108082688;
				if (num != 0)
				{
				}
				this.radErgoScanOnAnnouncementVoiceCommand.HiddenDynamic = value;
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x0600023C RID: 572 RVA: 0x00028708 File Offset: 0x00026908
		public bool RadErgoScanOnAnnouncementVoiceCommand_HasDiffs
		{
			get
			{
				short num = (short)1617634474;
				short num2 = num;
				num = (short)1961305258;
				switch (num2 == num)
				{
				}
				num = (short)1114177536;
				if (num != 0)
				{
				}
				num = (short)1609826304;
				short num3 = num;
				num = (short)418381825;
				if (num != 0)
				{
				}
				return this.radErgoScanOnAnnouncementVoiceCommand._HasDiffs;
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x0600023D RID: 573 RVA: 0x000287BC File Offset: 0x000269BC
		// (set) Token: 0x0600023E RID: 574 RVA: 0x00028870 File Offset: 0x00026A70
		public string RadErgoScanOffAnnouncementVoiceCommandValue
		{
			get
			{
				short num = (short)370670421;
				short num2 = num;
				num = (short)1753873237;
				switch (num2 == num)
				{
				}
				num = (short)363397120;
				if (num != 0)
				{
				}
				num = (short)331743232;
				short num3 = num;
				num = (short)1099759617;
				if (num != 0)
				{
				}
				return this.radErgoScanOffAnnouncementVoiceCommand.Value;
			}
			set
			{
				short num = (short)2136675564;
				short num2 = num;
				num = (short)1316164844;
				switch (num2 == num)
				{
				}
				num = (short)2016346112;
				if (num != 0)
				{
				}
				num = (short)617086976;
				short num3 = num;
				num = (short)75235329;
				if (num != 0)
				{
				}
				this.radErgoScanOffAnnouncementVoiceCommand.Value = value;
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x0600023F RID: 575 RVA: 0x00028928 File Offset: 0x00026B28
		public global::AcpBusinessLayer.AcpField<string> RadErgoScanOffAnnouncementVoiceCommand
		{
			get
			{
				short num = (short)915996673;
				if (num != 0)
				{
				}
				num = (short)1049273526;
				short num2 = num;
				num = (short)436774070;
				switch (num2 == num)
				{
				}
				num = (short)1464401920;
				short num3 = num;
				num = (short)915472384;
				if (num != 0)
				{
				}
				return this.radErgoScanOffAnnouncementVoiceCommand;
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x06000240 RID: 576 RVA: 0x000289DC File Offset: 0x00026BDC
		// (set) Token: 0x06000241 RID: 577 RVA: 0x00028A94 File Offset: 0x00026C94
		public string RadErgoScanOffAnnouncementVoiceCommand_UIValue
		{
			get
			{
				short num = (short)694825133;
				short num2 = num;
				num = (short)299708589;
				switch (num2 == num)
				{
				}
				num = (short)1015218177;
				if (num != 0)
				{
				}
				num = (short)646971392;
				short num3 = num;
				num = (short)907280384;
				if (num != 0)
				{
				}
				return this.radErgoScanOffAnnouncementVoiceCommand.Value;
			}
			set
			{
				short num = (short)1649669978;
				short num2 = num;
				num = (short)1514141530;
				switch (num2 == num)
				{
				}
				num = (short)44433409;
				if (num != 0)
				{
				}
				num = (short)16580608;
				short num3 = num;
				num = (short)677249024;
				if (num != 0)
				{
				}
				this.radErgoScanOffAnnouncementVoiceCommand.Value = value;
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x06000242 RID: 578 RVA: 0x00028B48 File Offset: 0x00026D48
		// (set) Token: 0x06000243 RID: 579 RVA: 0x00028BFC File Offset: 0x00026DFC
		public bool RadErgoScanOffAnnouncementVoiceCommand_Applicable
		{
			get
			{
				short num = (short)1365590841;
				short num2 = num;
				num = (short)2033664825;
				switch (num2 == num)
				{
				}
				num = (short)563281920;
				if (num != 0)
				{
				}
				num = (short)982122496;
				short num3 = num;
				num = (short)940441601;
				if (num != 0)
				{
				}
				return this.radErgoScanOffAnnouncementVoiceCommand.Applicable;
			}
			set
			{
				short num = (short)2015151586;
				short num2 = num;
				num = (short)1165149666;
				switch (num2 == num)
				{
				}
				num = (short)1356857345;
				if (num != 0)
				{
				}
				num = (short)702676992;
				short num3 = num;
				num = (short)685244416;
				if (num != 0)
				{
				}
				this.radErgoScanOffAnnouncementVoiceCommand.Applicable = value;
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x06000244 RID: 580 RVA: 0x00028CB0 File Offset: 0x00026EB0
		// (set) Token: 0x06000245 RID: 581 RVA: 0x00028D64 File Offset: 0x00026F64
		public bool RadErgoScanOffAnnouncementVoiceCommand_Valid
		{
			get
			{
				short num = (short)2078675994;
				short num2 = num;
				num = (short)545920026;
				switch (num2 == num)
				{
				}
				num = (short)183762945;
				if (num != 0)
				{
				}
				num = (short)1621426176;
				short num3 = num;
				num = (short)2083061760;
				if (num != 0)
				{
				}
				return this.radErgoScanOffAnnouncementVoiceCommand.Valid;
			}
			set
			{
				short num = (short)375259137;
				if (num != 0)
				{
				}
				num = (short)564139160;
				short num2 = num;
				num = (short)1532433560;
				switch (num2 == num)
				{
				}
				num = (short)1286733824;
				short num3 = num;
				num = (short)849805312;
				if (num != 0)
				{
				}
				this.radErgoScanOffAnnouncementVoiceCommand.Valid = value;
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x06000246 RID: 582 RVA: 0x00028E1C File Offset: 0x0002701C
		// (set) Token: 0x06000247 RID: 583 RVA: 0x00028ED4 File Offset: 0x000270D4
		public bool RadErgoScanOffAnnouncementVoiceCommand_Visible
		{
			get
			{
				short num = (short)1057547838;
				short num2 = num;
				num = (short)1258808894;
				switch (num2 == num)
				{
				}
				num = (short)1821704192;
				if (num != 0)
				{
				}
				num = (short)1699545088;
				short num3 = num;
				num = (short)185925633;
				if (num != 0)
				{
				}
				return this.radErgoScanOffAnnouncementVoiceCommand.Visible;
			}
			set
			{
				short num = (short)1826750465;
				if (num != 0)
				{
				}
				num = (short)1260511897;
				short num2 = num;
				num = (short)1193206425;
				switch (num2 == num)
				{
				}
				num = (short)455933952;
				short num3 = num;
				num = (short)1526071296;
				if (num != 0)
				{
				}
				this.radErgoScanOffAnnouncementVoiceCommand.Visible = value;
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x06000248 RID: 584 RVA: 0x00028F88 File Offset: 0x00027188
		// (set) Token: 0x06000249 RID: 585 RVA: 0x0002903C File Offset: 0x0002723C
		public bool RadErgoScanOffAnnouncementVoiceCommand_Editable
		{
			get
			{
				short num = (short)1511513378;
				short num2 = num;
				num = (short)126606626;
				switch (num2 == num)
				{
				}
				num = (short)2088960001;
				if (num != 0)
				{
				}
				num = (short)1937833984;
				short num3 = num;
				num = (short)1865809920;
				if (num != 0)
				{
				}
				return this.radErgoScanOffAnnouncementVoiceCommand.Editable;
			}
			set
			{
				short num = (short)1754005505;
				if (num != 0)
				{
				}
				num = (short)786636276;
				short num2 = num;
				num = (short)606084596;
				switch (num2 == num)
				{
				}
				num = (short)437518336;
				short num3 = num;
				num = (short)1076035584;
				if (num != 0)
				{
				}
				this.radErgoScanOffAnnouncementVoiceCommand.Editable = value;
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x0600024A RID: 586 RVA: 0x000290F0 File Offset: 0x000272F0
		internal string radErgoScanOffAnnouncementVoiceCommand_UILabel
		{
			get
			{
				short num = (short)617682801;
				short num2 = num;
				num = (short)1275991921;
				switch (num2 == num)
				{
				}
				num = (short)28573697;
				if (num != 0)
				{
				}
				num = (short)2089025536;
				short num3 = num;
				num = (short)1789657088;
				if (num != 0)
				{
				}
				return this.radErgoScanOffAnnouncementVoiceCommand.UIName;
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x0600024B RID: 587 RVA: 0x000291A4 File Offset: 0x000273A4
		// (set) Token: 0x0600024C RID: 588 RVA: 0x0002925C File Offset: 0x0002745C
		internal bool RadErgoScanOffAnnouncementVoiceCommand_HiddenStatic
		{
			get
			{
				short num = (short)1631017308;
				short num2 = num;
				num = (short)1465866588;
				switch (num2 == num)
				{
				}
				num = (short)262078465;
				if (num != 0)
				{
				}
				num = (short)851968000;
				short num3 = num;
				num = (short)11337728;
				if (num != 0)
				{
				}
				return this.radErgoScanOffAnnouncementVoiceCommand.HiddenStatic;
			}
			set
			{
				short num = (short)540215181;
				short num2 = num;
				num = (short)1745422221;
				switch (num2 == num)
				{
				}
				num = (short)807731201;
				if (num != 0)
				{
				}
				num = (short)60948480;
				short num3 = num;
				num = (short)901185536;
				if (num != 0)
				{
				}
				this.radErgoScanOffAnnouncementVoiceCommand.HiddenStatic = value;
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x0600024D RID: 589 RVA: 0x00029314 File Offset: 0x00027514
		// (set) Token: 0x0600024E RID: 590 RVA: 0x000293C8 File Offset: 0x000275C8
		internal bool RadErgoScanOffAnnouncementVoiceCommand_HiddenDynamic
		{
			get
			{
				short num = (short)884146177;
				if (num != 0)
				{
				}
				num = (short)418553010;
				short num2 = num;
				num = (short)338730162;
				switch (num2 == num)
				{
				}
				num = (short)14155776;
				short num3 = num;
				num = (short)1957888000;
				if (num != 0)
				{
				}
				return this.radErgoScanOffAnnouncementVoiceCommand.HiddenDynamic;
			}
			set
			{
				short num = (short)1613824001;
				if (num != 0)
				{
				}
				num = (short)766879944;
				short num2 = num;
				num = (short)129542344;
				switch (num2 == num)
				{
				}
				num = (short)533921792;
				short num3 = num;
				num = (short)2006319104;
				if (num != 0)
				{
				}
				this.radErgoScanOffAnnouncementVoiceCommand.HiddenDynamic = value;
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x0600024F RID: 591 RVA: 0x0002947C File Offset: 0x0002767C
		public bool RadErgoScanOffAnnouncementVoiceCommand_HasDiffs
		{
			get
			{
				short num = (short)1878301257;
				short num2 = num;
				num = (short)1819646537;
				switch (num2 == num)
				{
				}
				num = (short)1929773057;
				if (num != 0)
				{
				}
				num = (short)1878851584;
				short num3 = num;
				num = (short)1110835200;
				if (num != 0)
				{
				}
				return this.radErgoScanOffAnnouncementVoiceCommand._HasDiffs;
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000250 RID: 592 RVA: 0x00029530 File Offset: 0x00027730
		// (set) Token: 0x06000251 RID: 593 RVA: 0x000295E4 File Offset: 0x000277E4
		public string RadErgoMonitorOnVoiceCommandValue
		{
			get
			{
				short num = (short)2062954713;
				short num2 = num;
				num = (short)945172697;
				switch (num2 == num)
				{
				}
				num = (short)286588928;
				if (num != 0)
				{
				}
				num = (short)560201728;
				short num3 = num;
				num = (short)2065301505;
				if (num != 0)
				{
				}
				return this.radErgoMonitorOnVoiceCommand.Value;
			}
			set
			{
				short num = (short)1087557603;
				short num2 = num;
				num = (short)115724259;
				switch (num2 == num)
				{
				}
				num = (short)1474691072;
				if (num != 0)
				{
				}
				num = (short)1392443392;
				short num3 = num;
				num = (short)1215365121;
				if (num != 0)
				{
				}
				this.radErgoMonitorOnVoiceCommand.Value = value;
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x06000252 RID: 594 RVA: 0x0002969C File Offset: 0x0002789C
		public global::AcpBusinessLayer.AcpField<string> RadErgoMonitorOnVoiceCommand
		{
			get
			{
				short num = (short)385359288;
				short num2 = num;
				num = (short)1523457464;
				switch (num2 == num)
				{
				}
				num = (short)496697345;
				if (num != 0)
				{
				}
				num = (short)207224832;
				short num3 = num;
				num = (short)1546911744;
				if (num != 0)
				{
				}
				return this.radErgoMonitorOnVoiceCommand;
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x06000253 RID: 595 RVA: 0x00029748 File Offset: 0x00027948
		// (set) Token: 0x06000254 RID: 596 RVA: 0x000297FC File Offset: 0x000279FC
		public string RadErgoMonitorOnVoiceCommand_UIValue
		{
			get
			{
				short num = (short)1707343873;
				if (num != 0)
				{
				}
				num = (short)1855770638;
				short num2 = num;
				num = (short)1588514830;
				switch (num2 == num)
				{
				}
				num = (short)1183449088;
				short num3 = num;
				num = (short)1397817344;
				if (num != 0)
				{
				}
				return this.radErgoMonitorOnVoiceCommand.Value;
			}
			set
			{
				short num = (short)283154677;
				short num2 = num;
				num = (short)1955174645;
				switch (num2 == num)
				{
				}
				num = (short)1206452224;
				short num3 = num;
				num = (short)484245505;
				if (num != 0)
				{
				}
				num = (short)826277888;
				if (num != 0)
				{
				}
				this.radErgoMonitorOnVoiceCommand.Value = value;
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x06000255 RID: 597 RVA: 0x000298B4 File Offset: 0x00027AB4
		// (set) Token: 0x06000256 RID: 598 RVA: 0x00029968 File Offset: 0x00027B68
		public bool RadErgoMonitorOnVoiceCommand_Applicable
		{
			get
			{
				short num = (short)1108495673;
				short num2 = num;
				num = (short)1071861049;
				switch (num2 == num)
				{
				}
				num = (short)528351232;
				short num3 = num;
				num = (short)1714225153;
				if (num != 0)
				{
				}
				num = (short)1894973440;
				if (num != 0)
				{
				}
				return this.radErgoMonitorOnVoiceCommand.Applicable;
			}
			set
			{
				short num = (short)785805946;
				short num2 = num;
				num = (short)1650356858;
				switch (num2 == num)
				{
				}
				num = (short)284229632;
				short num3 = num;
				num = (short)533266433;
				if (num != 0)
				{
				}
				num = (short)154861568;
				if (num != 0)
				{
				}
				this.radErgoMonitorOnVoiceCommand.Applicable = value;
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x06000257 RID: 599 RVA: 0x00029A20 File Offset: 0x00027C20
		// (set) Token: 0x06000258 RID: 600 RVA: 0x00029AD4 File Offset: 0x00027CD4
		public bool RadErgoMonitorOnVoiceCommand_Valid
		{
			get
			{
				short num = (short)1601904895;
				short num2 = num;
				num = (short)1806180607;
				switch (num2 == num)
				{
				}
				num = (short)1214971904;
				short num3 = num;
				num = (short)923467777;
				if (num != 0)
				{
				}
				num = (short)2046885888;
				if (num != 0)
				{
				}
				return this.radErgoMonitorOnVoiceCommand.Valid;
			}
			set
			{
				short num = (short)206795141;
				short num2 = num;
				num = (short)102003077;
				switch (num2 == num)
				{
				}
				num = (short)1669595136;
				short num3 = num;
				num = (short)1502806016;
				if (num != 0)
				{
				}
				num = (short)1203961857;
				if (num != 0)
				{
				}
				this.radErgoMonitorOnVoiceCommand.Valid = value;
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x06000259 RID: 601 RVA: 0x00029B8C File Offset: 0x00027D8C
		// (set) Token: 0x0600025A RID: 602 RVA: 0x00029C44 File Offset: 0x00027E44
		public bool RadErgoMonitorOnVoiceCommand_Visible
		{
			get
			{
				short num = (short)1127112848;
				short num2 = num;
				num = (short)1867604112;
				switch (num2 == num)
				{
				}
				num = (short)2145976320;
				short num3 = num;
				num = (short)928382977;
				if (num != 0)
				{
				}
				num = (short)2068447232;
				if (num != 0)
				{
				}
				return this.radErgoMonitorOnVoiceCommand.Visible;
			}
			set
			{
				short num = (short)242741382;
				short num2 = num;
				num = (short)1430974598;
				switch (num2 == num)
				{
				}
				num = (short)1236729856;
				short num3 = num;
				num = (short)1219821568;
				if (num != 0)
				{
				}
				num = (short)903938049;
				if (num != 0)
				{
				}
				this.radErgoMonitorOnVoiceCommand.Visible = value;
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x0600025B RID: 603 RVA: 0x00029CFC File Offset: 0x00027EFC
		// (set) Token: 0x0600025C RID: 604 RVA: 0x00029DAC File Offset: 0x00027FAC
		public bool RadErgoMonitorOnVoiceCommand_Editable
		{
			get
			{
				short num = (short)539237223;
				short num2 = num;
				num = (short)452860775;
				switch (num2 == num)
				{
				}
				num = (short)128778240;
				short num3 = num;
				num = (short)59179008;
				if (num != 0)
				{
				}
				num = (short)364576769;
				if (num != 0)
				{
				}
				return this.radErgoMonitorOnVoiceCommand.Editable;
			}
			set
			{
				short num = (short)1814774934;
				short num2 = num;
				num = (short)1345143958;
				switch (num2 == num)
				{
				}
				num = (short)1020657664;
				short num3 = num;
				num = (short)2016739329;
				if (num != 0)
				{
				}
				num = (short)922943488;
				if (num != 0)
				{
				}
				this.radErgoMonitorOnVoiceCommand.Editable = value;
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x0600025D RID: 605 RVA: 0x00029E60 File Offset: 0x00028060
		internal string radErgoMonitorOnVoiceCommand_UILabel
		{
			get
			{
				short num = (short)1146574126;
				short num2 = num;
				num = (short)364401966;
				switch (num2 == num)
				{
				}
				num = (short)2123890688;
				short num3 = num;
				num = (short)991690753;
				if (num != 0)
				{
				}
				num = (short)428277760;
				if (num != 0)
				{
				}
				return this.radErgoMonitorOnVoiceCommand.UIName;
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x0600025E RID: 606 RVA: 0x00029F18 File Offset: 0x00028118
		// (set) Token: 0x0600025F RID: 607 RVA: 0x00029FD0 File Offset: 0x000281D0
		internal bool RadErgoMonitorOnVoiceCommand_HiddenStatic
		{
			get
			{
				short num = (short)1572887660;
				short num2 = num;
				num = (short)764238956;
				switch (num2 == num)
				{
				}
				num = (short)330170368;
				short num3 = num;
				num = (short)2099445761;
				if (num != 0)
				{
				}
				num = (short)981532672;
				if (num != 0)
				{
				}
				return this.radErgoMonitorOnVoiceCommand.HiddenStatic;
			}
			set
			{
				short num = (short)425066497;
				if (num != 0)
				{
				}
				num = (short)582441552;
				short num2 = num;
				num = (short)1281514064;
				switch (num2 == num)
				{
				default:
				{
					num = (short)52101120;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)631767040;
				if (num != 0)
				{
				}
				this.radErgoMonitorOnVoiceCommand.HiddenStatic = value;
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06000260 RID: 608 RVA: 0x0002A084 File Offset: 0x00028284
		// (set) Token: 0x06000261 RID: 609 RVA: 0x0002A138 File Offset: 0x00028338
		internal bool RadErgoMonitorOnVoiceCommand_HiddenDynamic
		{
			get
			{
				short num = (short)1754749049;
				short num2 = num;
				num = (short)1414486137;
				switch (num2 == num)
				{
				}
				num = (short)2022899712;
				short num3 = num;
				num = (short)1105657857;
				if (num != 0)
				{
				}
				num = (short)1128333312;
				if (num != 0)
				{
				}
				return this.radErgoMonitorOnVoiceCommand.HiddenDynamic;
			}
			set
			{
				short num = (short)2076278467;
				short num2 = num;
				num = (short)1970372291;
				switch (num2 == num)
				{
				}
				num = (short)1390018560;
				short num3 = num;
				num = (short)633667584;
				if (num != 0)
				{
				}
				num = (short)1994784769;
				if (num != 0)
				{
				}
				this.radErgoMonitorOnVoiceCommand.HiddenDynamic = value;
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x06000262 RID: 610 RVA: 0x0002A1EC File Offset: 0x000283EC
		public bool RadErgoMonitorOnVoiceCommand_HasDiffs
		{
			get
			{
				short num = (short)918009868;
				short num2 = num;
				num = (short)1349433356;
				switch (num2 == num)
				{
				}
				num = (short)1216872448;
				short num3 = num;
				num = (short)1862074369;
				if (num != 0)
				{
				}
				num = (short)706215936;
				if (num != 0)
				{
				}
				return this.radErgoMonitorOnVoiceCommand._HasDiffs;
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x06000263 RID: 611 RVA: 0x0002A2A0 File Offset: 0x000284A0
		// (set) Token: 0x06000264 RID: 612 RVA: 0x0002A358 File Offset: 0x00028558
		public string RadErgoMonitorOffVoiceCommandValue
		{
			get
			{
				short num = (short)1531614002;
				short num2 = num;
				num = (short)277975858;
				switch (num2 == num)
				{
				}
				num = (short)1938554880;
				short num3 = num;
				num = (short)1401356288;
				if (num != 0)
				{
				}
				num = (short)204931073;
				if (num != 0)
				{
				}
				return this.radErgoMonitorOffVoiceCommand.Value;
			}
			set
			{
				short num = (short)1724549392;
				short num2 = num;
				num = (short)1931970832;
				switch (num2 == num)
				{
				}
				num = (short)1417216000;
				short num3 = num;
				num = (short)1393098752;
				if (num != 0)
				{
				}
				num = (short)663748609;
				if (num != 0)
				{
				}
				this.radErgoMonitorOffVoiceCommand.Value = value;
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x06000265 RID: 613 RVA: 0x0002A410 File Offset: 0x00028610
		public global::AcpBusinessLayer.AcpField<string> RadErgoMonitorOffVoiceCommand
		{
			get
			{
				short num = (short)1579640502;
				short num2 = num;
				num = (short)1167943350;
				switch (num2 == num)
				{
				}
				num = (short)2101870592;
				short num3 = num;
				num = (short)127860737;
				if (num != 0)
				{
				}
				num = (short)956497920;
				if (num != 0)
				{
				}
				return this.radErgoMonitorOffVoiceCommand;
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x06000266 RID: 614 RVA: 0x0002A4C0 File Offset: 0x000286C0
		// (set) Token: 0x06000267 RID: 615 RVA: 0x0002A574 File Offset: 0x00028774
		public string RadErgoMonitorOffVoiceCommand_UIValue
		{
			get
			{
				short num = (short)216948319;
				short num2 = num;
				num = (short)930700895;
				switch (num2 == num)
				{
				}
				num = (short)1640038400;
				short num3 = num;
				num = (short)458096641;
				if (num != 0)
				{
				}
				num = (short)395182080;
				if (num != 0)
				{
				}
				return this.radErgoMonitorOffVoiceCommand.Value;
			}
			set
			{
				short num = (short)1240062171;
				short num2 = num;
				num = (short)310040795;
				switch (num2 == num)
				{
				}
				num = (short)2031353856;
				short num3 = num;
				num = (short)1956052993;
				if (num != 0)
				{
				}
				num = (short)294518784;
				if (num != 0)
				{
				}
				this.radErgoMonitorOffVoiceCommand.Value = value;
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x06000268 RID: 616 RVA: 0x0002A62C File Offset: 0x0002882C
		// (set) Token: 0x06000269 RID: 617 RVA: 0x0002A6DC File Offset: 0x000288DC
		public bool RadErgoMonitorOffVoiceCommand_Applicable
		{
			get
			{
				short num = (short)350785267;
				short num2 = num;
				num = (short)1000443635;
				switch (num2 == num)
				{
				}
				num = (short)671285248;
				short num3 = num;
				num = (short)1682636801;
				if (num != 0)
				{
				}
				num = (short)1844772864;
				if (num != 0)
				{
				}
				return this.radErgoMonitorOffVoiceCommand.Applicable;
			}
			set
			{
				short num = (short)1051383167;
				short num2 = num;
				num = (short)1046599039;
				switch (num2 == num)
				{
				}
				num = (short)1579483136;
				short num3 = num;
				num = (short)333119489;
				if (num != 0)
				{
				}
				num = (short)1177812992;
				if (num != 0)
				{
				}
				this.radErgoMonitorOffVoiceCommand.Applicable = value;
			}
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x0600026A RID: 618 RVA: 0x0002A798 File Offset: 0x00028998
		// (set) Token: 0x0600026B RID: 619 RVA: 0x0002A850 File Offset: 0x00028A50
		public bool RadErgoMonitorOffVoiceCommand_Valid
		{
			get
			{
				short num = (short)2018566591;
				short num2 = num;
				num = (short)754180543;
				switch (num2 == num)
				{
				}
				num = (short)616628224;
				short num3 = num;
				num = (short)548405249;
				if (num != 0)
				{
				}
				num = (short)1125122048;
				if (num != 0)
				{
				}
				return this.radErgoMonitorOffVoiceCommand.Valid;
			}
			set
			{
				short num = (short)216715282;
				short num2 = num;
				num = (short)334417938;
				switch (num2 == num)
				{
				}
				num = (short)920780800;
				short num3 = num;
				num = (short)1661337600;
				if (num != 0)
				{
				}
				num = (short)895614977;
				if (num != 0)
				{
				}
				this.radErgoMonitorOffVoiceCommand.Valid = value;
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x0600026C RID: 620 RVA: 0x0002A904 File Offset: 0x00028B04
		// (set) Token: 0x0600026D RID: 621 RVA: 0x0002A9B4 File Offset: 0x00028BB4
		public bool RadErgoMonitorOffVoiceCommand_Visible
		{
			get
			{
				short num = (short)1643131134;
				short num2 = num;
				num = (short)2000433406;
				switch (num2 == num)
				{
				}
				num = (short)564068352;
				short num3 = num;
				num = (short)626327552;
				if (num != 0)
				{
				}
				num = (short)1466302465;
				if (num != 0)
				{
				}
				return this.radErgoMonitorOffVoiceCommand.Visible;
			}
			set
			{
				short num = (short)802443249;
				short num2 = num;
				num = (short)2021674993;
				switch (num2 == num)
				{
				}
				num = (short)564396032;
				short num3 = num;
				num = (short)2118647808;
				if (num != 0)
				{
				}
				num = (short)1193934849;
				if (num != 0)
				{
				}
				this.radErgoMonitorOffVoiceCommand.Visible = value;
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x0600026E RID: 622 RVA: 0x0002AA6C File Offset: 0x00028C6C
		// (set) Token: 0x0600026F RID: 623 RVA: 0x0002AB20 File Offset: 0x00028D20
		public bool RadErgoMonitorOffVoiceCommand_Editable
		{
			get
			{
				short num = (short)51245667;
				short num2 = num;
				num = (short)1756885603;
				switch (num2 == num)
				{
				}
				num = (short)1166671872;
				short num3 = num;
				num = (short)741539841;
				if (num != 0)
				{
				}
				num = (short)2074738688;
				if (num != 0)
				{
				}
				return this.radErgoMonitorOffVoiceCommand.Editable;
			}
			set
			{
				short num = (short)960856451;
				short num2 = num;
				num = (short)848527747;
				switch (num2 == num)
				{
				}
				num = (short)337641472;
				short num3 = num;
				num = (short)1845690369;
				if (num != 0)
				{
				}
				num = (short)1666514944;
				if (num != 0)
				{
				}
				this.radErgoMonitorOffVoiceCommand.Editable = value;
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x06000270 RID: 624 RVA: 0x0002ABD8 File Offset: 0x00028DD8
		internal string radErgoMonitorOffVoiceCommand_UILabel
		{
			get
			{
				short num = (short)2037841921;
				if (num != 0)
				{
				}
				num = (short)1869530931;
				short num2 = num;
				num = (short)1778763571;
				switch (num2 == num)
				{
				default:
				{
					num = (short)285540352;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)577896448;
				if (num != 0)
				{
				}
				return this.radErgoMonitorOffVoiceCommand.UIName;
			}
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x06000271 RID: 625 RVA: 0x0002AC8C File Offset: 0x00028E8C
		// (set) Token: 0x06000272 RID: 626 RVA: 0x0002AD40 File Offset: 0x00028F40
		internal bool RadErgoMonitorOffVoiceCommand_HiddenStatic
		{
			get
			{
				short num = (short)992804865;
				if (num != 0)
				{
				}
				num = (short)1394684236;
				short num2 = num;
				num = (short)343617868;
				switch (num2 == num)
				{
				default:
				{
					num = (short)432209920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1788215296;
				if (num != 0)
				{
				}
				return this.radErgoMonitorOffVoiceCommand.HiddenStatic;
			}
			set
			{
				short num = (short)1037555626;
				short num2 = num;
				num = (short)2122307498;
				switch (num2 == num)
				{
				}
				num = (short)1463615488;
				short num3 = num;
				num = (short)532742144;
				if (num != 0)
				{
				}
				num = (short)1030619137;
				if (num != 0)
				{
				}
				this.radErgoMonitorOffVoiceCommand.HiddenStatic = value;
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x06000273 RID: 627 RVA: 0x0002ADF4 File Offset: 0x00028FF4
		// (set) Token: 0x06000274 RID: 628 RVA: 0x0002AEAC File Offset: 0x000290AC
		internal bool RadErgoMonitorOffVoiceCommand_HiddenDynamic
		{
			get
			{
				short num = (short)1490485249;
				if (num != 0)
				{
				}
				num = (short)370562246;
				short num2 = num;
				num = (short)66278598;
				switch (num2 == num)
				{
				default:
				{
					num = (short)675545088;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)139722752;
				if (num != 0)
				{
				}
				return this.radErgoMonitorOffVoiceCommand.HiddenDynamic;
			}
			set
			{
				short num = (short)1436474781;
				short num2 = num;
				num = (short)836885917;
				switch (num2 == num)
				{
				}
				num = (short)1227096064;
				short num3 = num;
				num = (short)1284636673;
				if (num != 0)
				{
				}
				num = (short)1385562112;
				if (num != 0)
				{
				}
				this.radErgoMonitorOffVoiceCommand.HiddenDynamic = value;
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x06000275 RID: 629 RVA: 0x0002AF60 File Offset: 0x00029160
		public bool RadErgoMonitorOffVoiceCommand_HasDiffs
		{
			get
			{
				short num = (short)453657821;
				short num2 = num;
				num = (short)1124877533;
				switch (num2 == num)
				{
				}
				num = (short)267911168;
				short num3 = num;
				num = (short)1410465792;
				if (num != 0)
				{
				}
				num = (short)386531329;
				if (num != 0)
				{
				}
				return this.radErgoMonitorOffVoiceCommand._HasDiffs;
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x06000276 RID: 630 RVA: 0x0002B014 File Offset: 0x00029214
		// (set) Token: 0x06000277 RID: 631 RVA: 0x0002B0C8 File Offset: 0x000292C8
		public string RadErgoDirectModeOnVoiceCommandValue
		{
			get
			{
				short num = (short)388500416;
				short num2 = num;
				num = (short)863898560;
				switch (num2 == num)
				{
				}
				num = (short)1788084224;
				short num3 = num;
				num = (short)554958849;
				if (num != 0)
				{
				}
				num = (short)1872691200;
				if (num != 0)
				{
				}
				return this.radErgoDirectModeOnVoiceCommand.Value;
			}
			set
			{
				short num = (short)276103169;
				if (num != 0)
				{
				}
				num = (short)590537587;
				short num2 = num;
				num = (short)647553907;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1032060928;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1222311936;
				if (num != 0)
				{
				}
				this.radErgoDirectModeOnVoiceCommand.Value = value;
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x06000278 RID: 632 RVA: 0x0002B17C File Offset: 0x0002937C
		public global::AcpBusinessLayer.AcpField<string> RadErgoDirectModeOnVoiceCommand
		{
			get
			{
				short num = (short)37289985;
				if (num != 0)
				{
				}
				num = (short)924091615;
				short num2 = num;
				num = (short)1049199839;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1640300544;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)818216960;
				if (num != 0)
				{
				}
				return this.radErgoDirectModeOnVoiceCommand;
			}
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x06000279 RID: 633 RVA: 0x0002B230 File Offset: 0x00029430
		// (set) Token: 0x0600027A RID: 634 RVA: 0x0002B2E8 File Offset: 0x000294E8
		public string RadErgoDirectModeOnVoiceCommand_UIValue
		{
			get
			{
				short num = (short)1442849337;
				short num2 = num;
				num = (short)1188110905;
				switch (num2 == num)
				{
				}
				num = (short)249823232;
				short num3 = num;
				num = (short)612761601;
				if (num != 0)
				{
				}
				num = (short)2083979264;
				if (num != 0)
				{
				}
				return this.radErgoDirectModeOnVoiceCommand.Value;
			}
			set
			{
				short num = (short)196170844;
				short num2 = num;
				num = (short)893736028;
				switch (num2 == num)
				{
				}
				num = (short)164888576;
				short num3 = num;
				num = (short)1970077697;
				if (num != 0)
				{
				}
				num = (short)356122624;
				if (num != 0)
				{
				}
				this.radErgoDirectModeOnVoiceCommand.Value = value;
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x0600027B RID: 635 RVA: 0x0002B3A0 File Offset: 0x000295A0
		// (set) Token: 0x0600027C RID: 636 RVA: 0x0002B454 File Offset: 0x00029654
		public bool RadErgoDirectModeOnVoiceCommand_Applicable
		{
			get
			{
				short num = (short)1723990017;
				if (num != 0)
				{
				}
				num = (short)1369944969;
				short num2 = num;
				num = (short)806073225;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1892745216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)760414208;
				if (num != 0)
				{
				}
				return this.radErgoDirectModeOnVoiceCommand.Applicable;
			}
			set
			{
				short num = (short)291054610;
				short num2 = num;
				num = (short)1758733330;
				switch (num2 == num)
				{
				}
				num = (short)592379904;
				short num3 = num;
				num = (short)614662145;
				if (num != 0)
				{
				}
				num = (short)1065156608;
				if (num != 0)
				{
				}
				this.radErgoDirectModeOnVoiceCommand.Applicable = value;
			}
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x0600027D RID: 637 RVA: 0x0002B508 File Offset: 0x00029708
		// (set) Token: 0x0600027E RID: 638 RVA: 0x0002B5BC File Offset: 0x000297BC
		public bool RadErgoDirectModeOnVoiceCommand_Valid
		{
			get
			{
				short num = (short)2020592342;
				short num2 = num;
				num = (short)1621609174;
				switch (num2 == num)
				{
				}
				num = (short)649461760;
				short num3 = num;
				num = (short)380305409;
				if (num != 0)
				{
				}
				num = (short)776929280;
				if (num != 0)
				{
				}
				return this.radErgoDirectModeOnVoiceCommand.Valid;
			}
			set
			{
				short num = (short)1640865283;
				short num2 = num;
				num = (short)900767235;
				switch (num2 == num)
				{
				}
				num = (short)150274048;
				short num3 = num;
				num = (short)601554945;
				if (num != 0)
				{
				}
				num = (short)1122762752;
				if (num != 0)
				{
				}
				this.radErgoDirectModeOnVoiceCommand.Valid = value;
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x0600027F RID: 639 RVA: 0x0002B670 File Offset: 0x00029870
		// (set) Token: 0x06000280 RID: 640 RVA: 0x0002B728 File Offset: 0x00029928
		public bool RadErgoDirectModeOnVoiceCommand_Visible
		{
			get
			{
				short num = (short)198477811;
				short num2 = num;
				num = (short)498501619;
				switch (num2 == num)
				{
				}
				num = (short)1599668224;
				short num3 = num;
				num = (short)210567168;
				if (num != 0)
				{
				}
				num = (short)1633746945;
				if (num != 0)
				{
				}
				return this.radErgoDirectModeOnVoiceCommand.Visible;
			}
			set
			{
				short num = (short)509460872;
				short num2 = num;
				num = (short)1243136392;
				switch (num2 == num)
				{
				}
				num = (short)1472135168;
				short num3 = num;
				num = (short)682557440;
				if (num != 0)
				{
				}
				num = (short)817823745;
				if (num != 0)
				{
				}
				this.radErgoDirectModeOnVoiceCommand.Visible = value;
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x06000281 RID: 641 RVA: 0x0002B7DC File Offset: 0x000299DC
		// (set) Token: 0x06000282 RID: 642 RVA: 0x0002B890 File Offset: 0x00029A90
		public bool RadErgoDirectModeOnVoiceCommand_Editable
		{
			get
			{
				short num = (short)859618592;
				short num2 = num;
				num = (short)1796717856;
				switch (num2 == num)
				{
				}
				num = (short)608829440;
				short num3 = num;
				num = (short)1188626433;
				if (num != 0)
				{
				}
				num = (short)1853423616;
				if (num != 0)
				{
				}
				return this.radErgoDirectModeOnVoiceCommand.Editable;
			}
			set
			{
				short num = (short)1520173282;
				short num2 = num;
				num = (short)2109276386;
				switch (num2 == num)
				{
				}
				num = (short)918421504;
				short num3 = num;
				num = (short)484769793;
				if (num != 0)
				{
				}
				num = (short)449970176;
				if (num != 0)
				{
				}
				this.radErgoDirectModeOnVoiceCommand.Editable = value;
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x06000283 RID: 643 RVA: 0x0002B94C File Offset: 0x00029B4C
		internal string radErgoDirectModeOnVoiceCommand_UILabel
		{
			get
			{
				short num = (short)1507231945;
				short num2 = num;
				num = (short)1607633097;
				switch (num2 == num)
				{
				}
				num = (short)732626944;
				short num3 = num;
				num = (short)1285619713;
				if (num != 0)
				{
				}
				num = (short)463601664;
				if (num != 0)
				{
				}
				return this.radErgoDirectModeOnVoiceCommand.UIName;
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x06000284 RID: 644 RVA: 0x0002BA04 File Offset: 0x00029C04
		// (set) Token: 0x06000285 RID: 645 RVA: 0x0002BABC File Offset: 0x00029CBC
		internal bool RadErgoDirectModeOnVoiceCommand_HiddenStatic
		{
			get
			{
				short num = (short)1276437670;
				short num2 = num;
				num = (short)883352742;
				switch (num2 == num)
				{
				}
				num = (short)582090752;
				short num3 = num;
				num = (short)1684865025;
				if (num != 0)
				{
				}
				num = (short)351797248;
				if (num != 0)
				{
				}
				return this.radErgoDirectModeOnVoiceCommand.HiddenStatic;
			}
			set
			{
				short num = (short)412554646;
				short num2 = num;
				num = (short)408163734;
				switch (num2 == num)
				{
				}
				num = (short)1316945920;
				short num3 = num;
				num = (short)1868300289;
				if (num != 0)
				{
				}
				num = (short)721485824;
				if (num != 0)
				{
				}
				this.radErgoDirectModeOnVoiceCommand.HiddenStatic = value;
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x06000286 RID: 646 RVA: 0x0002BB70 File Offset: 0x00029D70
		// (set) Token: 0x06000287 RID: 647 RVA: 0x0002BC24 File Offset: 0x00029E24
		internal bool RadErgoDirectModeOnVoiceCommand_HiddenDynamic
		{
			get
			{
				short num = (short)530911545;
				short num2 = num;
				num = (short)787681593;
				switch (num2 == num)
				{
				}
				num = (short)402128896;
				short num3 = num;
				num = (short)1478623233;
				if (num != 0)
				{
				}
				num = (short)133365760;
				if (num != 0)
				{
				}
				return this.radErgoDirectModeOnVoiceCommand.HiddenDynamic;
			}
			set
			{
				short num = (short)451922466;
				short num2 = num;
				num = (short)763480610;
				switch (num2 == num)
				{
				}
				num = (short)182517760;
				short num3 = num;
				num = (short)265093121;
				if (num != 0)
				{
				}
				num = (short)318177280;
				if (num != 0)
				{
				}
				this.radErgoDirectModeOnVoiceCommand.HiddenDynamic = value;
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x06000288 RID: 648 RVA: 0x0002BCD8 File Offset: 0x00029ED8
		public bool RadErgoDirectModeOnVoiceCommand_HasDiffs
		{
			get
			{
				short num = (short)423915908;
				short num2 = num;
				num = (short)1221030276;
				switch (num2 == num)
				{
				}
				num = (short)1944322049;
				if (num != 0)
				{
				}
				num = (short)30146560;
				if (num != 0)
				{
				}
				num = (short)1215954944;
				short num3 = num;
				return this.radErgoDirectModeOnVoiceCommand._HasDiffs;
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x06000289 RID: 649 RVA: 0x0002BD90 File Offset: 0x00029F90
		// (set) Token: 0x0600028A RID: 650 RVA: 0x0002BE44 File Offset: 0x0002A044
		public string RadErgoDirectModeOffVoiceCommandValue
		{
			get
			{
				short num = (short)1850998785;
				if (num != 0)
				{
				}
				num = (short)1716339932;
				short num2 = num;
				num = (short)858211548;
				switch (num2 == num)
				{
				}
				num = (short)1069219840;
				if (num != 0)
				{
				}
				num = (short)355008512;
				short num3 = num;
				return this.radErgoDirectModeOffVoiceCommand.Value;
			}
			set
			{
				short num = (short)1092895002;
				short num2 = num;
				num = (short)216940826;
				switch (num2 == num)
				{
				}
				num = (short)20709377;
				if (num != 0)
				{
				}
				num = (short)1643577344;
				if (num != 0)
				{
				}
				num = (short)1539702784;
				short num3 = num;
				this.radErgoDirectModeOffVoiceCommand.Value = value;
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x0600028B RID: 651 RVA: 0x0002BEFC File Offset: 0x0002A0FC
		public global::AcpBusinessLayer.AcpField<string> RadErgoDirectModeOffVoiceCommand
		{
			get
			{
				short num = (short)583910261;
				short num2 = num;
				num = (short)1019986805;
				switch (num2 == num)
				{
				}
				num = (short)1235484672;
				if (num != 0)
				{
				}
				num = (short)395444225;
				if (num != 0)
				{
				}
				num = (short)2043609088;
				short num3 = num;
				return this.radErgoDirectModeOffVoiceCommand;
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x0600028C RID: 652 RVA: 0x0002BFAC File Offset: 0x0002A1AC
		// (set) Token: 0x0600028D RID: 653 RVA: 0x0002C064 File Offset: 0x0002A264
		public string RadErgoDirectModeOffVoiceCommand_UIValue
		{
			get
			{
				short num = (short)154599425;
				if (num != 0)
				{
				}
				num = (short)1152019321;
				short num2 = num;
				num = (short)886401913;
				switch (num2 == num)
				{
				}
				num = (short)1223229440;
				if (num != 0)
				{
				}
				num = (short)47120384;
				short num3 = num;
				return this.radErgoDirectModeOffVoiceCommand.Value;
			}
			set
			{
				short num = (short)894345831;
				short num2 = num;
				num = (short)1944887911;
				switch (num2 == num)
				{
				}
				num = (short)762249217;
				if (num != 0)
				{
				}
				num = (short)266600448;
				if (num != 0)
				{
				}
				num = (short)420610048;
				short num3 = num;
				this.radErgoDirectModeOffVoiceCommand.Value = value;
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x0600028E RID: 654 RVA: 0x0002C118 File Offset: 0x0002A318
		// (set) Token: 0x0600028F RID: 655 RVA: 0x0002C1CC File Offset: 0x0002A3CC
		public bool RadErgoDirectModeOffVoiceCommand_Applicable
		{
			get
			{
				short num = (short)48361472;
				short num2 = num;
				num = (short)1529344000;
				switch (num2 == num)
				{
				}
				num = (short)720830465;
				if (num != 0)
				{
				}
				num = (short)281935872;
				if (num != 0)
				{
				}
				num = (short)789446656;
				short num3 = num;
				return this.radErgoDirectModeOffVoiceCommand.Applicable;
			}
			set
			{
				short num = (short)670376340;
				short num2 = num;
				num = (short)1237787028;
				switch (num2 == num)
				{
				}
				num = (short)1618280448;
				if (num != 0)
				{
				}
				num = (short)224133121;
				if (num != 0)
				{
				}
				num = (short)1908277248;
				short num3 = num;
				this.radErgoDirectModeOffVoiceCommand.Applicable = value;
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x06000290 RID: 656 RVA: 0x0002C280 File Offset: 0x0002A480
		// (set) Token: 0x06000291 RID: 657 RVA: 0x0002C334 File Offset: 0x0002A534
		public bool RadErgoDirectModeOffVoiceCommand_Valid
		{
			get
			{
				short num = (short)1817013805;
				short num2 = num;
				num = (short)801402413;
				switch (num2 == num)
				{
				}
				num = (short)547749889;
				if (num != 0)
				{
				}
				num = (short)457375744;
				if (num != 0)
				{
				}
				num = (short)524025856;
				short num3 = num;
				return this.radErgoDirectModeOffVoiceCommand.Valid;
			}
			set
			{
				short num = (short)1663528706;
				short num2 = num;
				num = (short)398814978;
				switch (num2 == num)
				{
				}
				num = (short)1290993665;
				if (num != 0)
				{
				}
				num = (short)1877016576;
				if (num != 0)
				{
				}
				num = (short)1808793600;
				short num3 = num;
				this.radErgoDirectModeOffVoiceCommand.Valid = value;
			}
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x06000292 RID: 658 RVA: 0x0002C3EC File Offset: 0x0002A5EC
		// (set) Token: 0x06000293 RID: 659 RVA: 0x0002C4A0 File Offset: 0x0002A6A0
		public bool RadErgoDirectModeOffVoiceCommand_Visible
		{
			get
			{
				short num = (short)592335923;
				short num2 = num;
				num = (short)1433883699;
				switch (num2 == num)
				{
				}
				num = (short)972292097;
				if (num != 0)
				{
				}
				num = (short)1737490432;
				if (num != 0)
				{
				}
				num = (short)1535442944;
				short num3 = num;
				return this.radErgoDirectModeOffVoiceCommand.Visible;
			}
			set
			{
				short num = (short)686953289;
				short num2 = num;
				num = (short)1775309641;
				switch (num2 == num)
				{
				}
				num = (short)1904934913;
				if (num != 0)
				{
				}
				num = (short)1047527424;
				if (num != 0)
				{
				}
				num = (short)1331232768;
				short num3 = num;
				this.radErgoDirectModeOffVoiceCommand.Visible = value;
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x06000294 RID: 660 RVA: 0x0002C558 File Offset: 0x0002A758
		// (set) Token: 0x06000295 RID: 661 RVA: 0x0002C60C File Offset: 0x0002A80C
		public bool RadErgoDirectModeOffVoiceCommand_Editable
		{
			get
			{
				short num = (short)225082755;
				short num2 = num;
				num = (short)2131328387;
				switch (num2 == num)
				{
				}
				num = (short)744423424;
				if (num != 0)
				{
				}
				num = (short)1744961537;
				if (num != 0)
				{
				}
				num = (short)195362816;
				short num3 = num;
				return this.radErgoDirectModeOffVoiceCommand.Editable;
			}
			set
			{
				short num = (short)2109015973;
				short num2 = num;
				num = (short)2015692709;
				switch (num2 == num)
				{
				}
				num = (short)1992359937;
				if (num != 0)
				{
				}
				num = (short)79691776;
				if (num != 0)
				{
				}
				num = (short)164233216;
				short num3 = num;
				this.radErgoDirectModeOffVoiceCommand.Editable = value;
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x06000296 RID: 662 RVA: 0x0002C6C0 File Offset: 0x0002A8C0
		internal string radErgoDirectModeOffVoiceCommand_UILabel
		{
			get
			{
				short num = (short)1179810995;
				short num2 = num;
				num = (short)955481267;
				switch (num2 == num)
				{
				}
				num = (short)497090560;
				if (num != 0)
				{
				}
				num = (short)1376518145;
				if (num != 0)
				{
				}
				num = (short)1741946880;
				short num3 = num;
				return this.radErgoDirectModeOffVoiceCommand.UIName;
			}
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x06000297 RID: 663 RVA: 0x0002C774 File Offset: 0x0002A974
		// (set) Token: 0x06000298 RID: 664 RVA: 0x0002C828 File Offset: 0x0002AA28
		internal bool RadErgoDirectModeOffVoiceCommand_HiddenStatic
		{
			get
			{
				short num = (short)1958613915;
				short num2 = num;
				num = (short)1440748443;
				switch (num2 == num)
				{
				}
				num = (short)665387009;
				if (num != 0)
				{
				}
				num = (short)349175808;
				if (num != 0)
				{
				}
				num = (short)1197735936;
				short num3 = num;
				return this.radErgoDirectModeOffVoiceCommand.HiddenStatic;
			}
			set
			{
				short num = (short)1078162178;
				short num2 = num;
				num = (short)2014737154;
				switch (num2 == num)
				{
				}
				num = (short)1757216769;
				if (num != 0)
				{
				}
				num = (short)459800576;
				if (num != 0)
				{
				}
				num = (short)813891584;
				short num3 = num;
				this.radErgoDirectModeOffVoiceCommand.HiddenStatic = value;
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x06000299 RID: 665 RVA: 0x0002C8E0 File Offset: 0x0002AAE0
		// (set) Token: 0x0600029A RID: 666 RVA: 0x0002C998 File Offset: 0x0002AB98
		internal bool RadErgoDirectModeOffVoiceCommand_HiddenDynamic
		{
			get
			{
				short num = (short)1829754008;
				short num2 = num;
				num = (short)1265882264;
				switch (num2 == num)
				{
				}
				num = (short)1332609025;
				if (num != 0)
				{
				}
				num = (short)947060736;
				if (num != 0)
				{
				}
				num = (short)545259520;
				short num3 = num;
				return this.radErgoDirectModeOffVoiceCommand.HiddenDynamic;
			}
			set
			{
				short num = (short)1670385234;
				short num2 = num;
				num = (short)692457042;
				switch (num2 == num)
				{
				}
				num = (short)1902247936;
				if (num != 0)
				{
				}
				num = (short)965935105;
				if (num != 0)
				{
				}
				num = (short)905773056;
				short num3 = num;
				this.radErgoDirectModeOffVoiceCommand.HiddenDynamic = value;
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x0600029B RID: 667 RVA: 0x0002CA4C File Offset: 0x0002AC4C
		public bool RadErgoDirectModeOffVoiceCommand_HasDiffs
		{
			get
			{
				short num = (short)2029938390;
				short num2 = num;
				num = (short)507406038;
				switch (num2 == num)
				{
				}
				num = (short)1521352705;
				if (num != 0)
				{
				}
				num = (short)481558528;
				if (num != 0)
				{
				}
				num = (short)1011679232;
				short num3 = num;
				return this.radErgoDirectModeOffVoiceCommand._HasDiffs;
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x0600029C RID: 668 RVA: 0x0002CB04 File Offset: 0x0002AD04
		// (set) Token: 0x0600029D RID: 669 RVA: 0x0002CBB8 File Offset: 0x0002ADB8
		public string RadErgoTxInhibitOnVoiceCommandValue
		{
			get
			{
				short num = (short)1836323417;
				short num2 = num;
				num = (short)424612441;
				switch (num2 == num)
				{
				}
				num = (short)701825024;
				if (num != 0)
				{
				}
				num = (short)1901002753;
				if (num != 0)
				{
				}
				num = (short)905641984;
				short num3 = num;
				return this.radErgoTxInhibitOnVoiceCommand.Value;
			}
			set
			{
				short num = (short)41331413;
				short num2 = num;
				num = (short)1471982293;
				switch (num2 == num)
				{
				}
				num = (short)1089208321;
				if (num != 0)
				{
				}
				num = (short)430047232;
				if (num != 0)
				{
				}
				num = (short)1629749248;
				short num3 = num;
				this.radErgoTxInhibitOnVoiceCommand.Value = value;
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x0600029E RID: 670 RVA: 0x0002CC70 File Offset: 0x0002AE70
		public global::AcpBusinessLayer.AcpField<string> RadErgoTxInhibitOnVoiceCommand
		{
			get
			{
				short num = (short)803648713;
				short num2 = num;
				num = (short)448705737;
				switch (num2 == num)
				{
				}
				num = (short)271122433;
				if (num != 0)
				{
				}
				num = (short)1298333696;
				if (num != 0)
				{
				}
				num = (short)1246822400;
				short num3 = num;
				return this.radErgoTxInhibitOnVoiceCommand;
			}
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x0600029F RID: 671 RVA: 0x0002CD24 File Offset: 0x0002AF24
		// (set) Token: 0x060002A0 RID: 672 RVA: 0x0002CDDC File Offset: 0x0002AFDC
		public string RadErgoTxInhibitOnVoiceCommand_UIValue
		{
			get
			{
				short num = (short)1238237185;
				if (num != 0)
				{
				}
				num = (short)1061471260;
				short num2 = num;
				num = (short)266519580;
				switch (num2 == num)
				{
				}
				num = (short)888340480;
				if (num != 0)
				{
				}
				num = (short)1781792768;
				short num3 = num;
				return this.radErgoTxInhibitOnVoiceCommand.Value;
			}
			set
			{
				short num = (short)576978945;
				if (num != 0)
				{
				}
				num = (short)1564358524;
				short num2 = num;
				num = (short)48707452;
				switch (num2 == num)
				{
				}
				num = (short)1465647104;
				if (num != 0)
				{
				}
				num = (short)1279000576;
				short num3 = num;
				this.radErgoTxInhibitOnVoiceCommand.Value = value;
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x060002A1 RID: 673 RVA: 0x0002CE90 File Offset: 0x0002B090
		// (set) Token: 0x060002A2 RID: 674 RVA: 0x0002CF44 File Offset: 0x0002B144
		public bool RadErgoTxInhibitOnVoiceCommand_Applicable
		{
			get
			{
				short num = (short)328227275;
				short num2 = num;
				num = (short)3758539;
				switch (num2 == num)
				{
				}
				num = (short)2125266945;
				if (num != 0)
				{
				}
				num = (short)226689024;
				if (num != 0)
				{
				}
				num = (short)2135228416;
				short num3 = num;
				return this.radErgoTxInhibitOnVoiceCommand.Applicable;
			}
			set
			{
				short num = (short)1506545290;
				short num2 = num;
				num = (short)1464929930;
				switch (num2 == num)
				{
				}
				num = (short)1847001088;
				if (num != 0)
				{
				}
				num = (short)1983905793;
				if (num != 0)
				{
				}
				num = (short)1031602176;
				short num3 = num;
				this.radErgoTxInhibitOnVoiceCommand.Applicable = value;
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x060002A3 RID: 675 RVA: 0x0002CFF8 File Offset: 0x0002B1F8
		// (set) Token: 0x060002A4 RID: 676 RVA: 0x0002D0B0 File Offset: 0x0002B2B0
		public bool RadErgoTxInhibitOnVoiceCommand_Valid
		{
			get
			{
				short num = (short)1095988190;
				short num2 = num;
				num = (short)466187230;
				switch (num2 == num)
				{
				}
				num = (short)1249312769;
				if (num != 0)
				{
				}
				num = (short)2013134848;
				if (num != 0)
				{
				}
				num = (short)1554448384;
				short num3 = num;
				return this.radErgoTxInhibitOnVoiceCommand.Valid;
			}
			set
			{
				short num = (short)1865699086;
				short num2 = num;
				num = (short)1307135758;
				switch (num2 == num)
				{
				}
				num = (short)2047344641;
				if (num != 0)
				{
				}
				num = (short)1719402496;
				if (num != 0)
				{
				}
				num = (short)2128347136;
				short num3 = num;
				this.radErgoTxInhibitOnVoiceCommand.Valid = value;
			}
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x060002A5 RID: 677 RVA: 0x0002D168 File Offset: 0x0002B368
		// (set) Token: 0x060002A6 RID: 678 RVA: 0x0002D220 File Offset: 0x0002B420
		public bool RadErgoTxInhibitOnVoiceCommand_Visible
		{
			get
			{
				short num = (short)930965913;
				short num2 = num;
				num = (short)1727097241;
				switch (num2 == num)
				{
				}
				num = (short)833355777;
				if (num != 0)
				{
				}
				num = (short)233242624;
				if (num != 0)
				{
				}
				num = (short)420872192;
				short num3 = num;
				return this.radErgoTxInhibitOnVoiceCommand.Visible;
			}
			set
			{
				short num = (short)730963165;
				short num2 = num;
				num = (short)1091804381;
				switch (num2 == num)
				{
				}
				num = (short)1239613440;
				if (num != 0)
				{
				}
				num = (short)170196993;
				if (num != 0)
				{
				}
				num = (short)760020992;
				short num3 = num;
				this.radErgoTxInhibitOnVoiceCommand.Visible = value;
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x060002A7 RID: 679 RVA: 0x0002D2D4 File Offset: 0x0002B4D4
		// (set) Token: 0x060002A8 RID: 680 RVA: 0x0002D388 File Offset: 0x0002B588
		public bool RadErgoTxInhibitOnVoiceCommand_Editable
		{
			get
			{
				short num = (short)999272861;
				short num2 = num;
				num = (short)784707997;
				switch (num2 == num)
				{
				}
				num = (short)1946025984;
				if (num != 0)
				{
				}
				num = (short)1626800129;
				if (num != 0)
				{
				}
				num = (short)1274019840;
				short num3 = num;
				return this.radErgoTxInhibitOnVoiceCommand.Editable;
			}
			set
			{
				short num = (short)691937299;
				short num2 = num;
				num = (short)1513299987;
				switch (num2 == num)
				{
				}
				num = (short)2002518017;
				if (num != 0)
				{
				}
				num = (short)451936256;
				if (num != 0)
				{
				}
				num = (short)431816704;
				short num3 = num;
				this.radErgoTxInhibitOnVoiceCommand.Editable = value;
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x060002A9 RID: 681 RVA: 0x0002D43C File Offset: 0x0002B63C
		internal string radErgoTxInhibitOnVoiceCommand_UILabel
		{
			get
			{
				short num = (short)1396116871;
				short num2 = num;
				num = (short)1576471943;
				switch (num2 == num)
				{
				}
				num = (short)1688666113;
				if (num != 0)
				{
				}
				num = (short)664141824;
				if (num != 0)
				{
				}
				num = (short)1174470656;
				short num3 = num;
				return this.radErgoTxInhibitOnVoiceCommand.UIName;
			}
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x060002AA RID: 682 RVA: 0x0002D4F0 File Offset: 0x0002B6F0
		// (set) Token: 0x060002AB RID: 683 RVA: 0x0002D5A4 File Offset: 0x0002B7A4
		internal bool RadErgoTxInhibitOnVoiceCommand_HiddenStatic
		{
			get
			{
				short num = (short)1315431234;
				short num2 = num;
				num = (short)1700455234;
				switch (num2 == num)
				{
				}
				num = (short)1150156801;
				if (num != 0)
				{
				}
				num = (short)1085145088;
				if (num != 0)
				{
				}
				num = (short)70189056;
				short num3 = num;
				return this.radErgoTxInhibitOnVoiceCommand.HiddenStatic;
			}
			set
			{
				short num = (short)1670355136;
				short num2 = num;
				num = (short)2122488000;
				switch (num2 == num)
				{
				}
				num = (short)1444610049;
				if (num != 0)
				{
				}
				num = (short)1870266368;
				if (num != 0)
				{
				}
				num = (short)359071744;
				short num3 = num;
				this.radErgoTxInhibitOnVoiceCommand.HiddenStatic = value;
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x060002AC RID: 684 RVA: 0x0002D658 File Offset: 0x0002B858
		// (set) Token: 0x060002AD RID: 685 RVA: 0x0002D70C File Offset: 0x0002B90C
		internal bool RadErgoTxInhibitOnVoiceCommand_HiddenDynamic
		{
			get
			{
				short num = (short)1539179458;
				short num2 = num;
				num = (short)1420559298;
				switch (num2 == num)
				{
				}
				num = (short)1612578817;
				if (num != 0)
				{
				}
				num = (short)1777795072;
				if (num != 0)
				{
				}
				num = (short)1360461824;
				short num3 = num;
				return this.radErgoTxInhibitOnVoiceCommand.HiddenDynamic;
			}
			set
			{
				short num = (short)1373915210;
				short num2 = num;
				num = (short)573065290;
				switch (num2 == num)
				{
				}
				num = (short)1087438849;
				if (num != 0)
				{
				}
				num = (short)1507721216;
				if (num != 0)
				{
				}
				num = (short)120193024;
				short num3 = num;
				this.radErgoTxInhibitOnVoiceCommand.HiddenDynamic = value;
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x060002AE RID: 686 RVA: 0x0002D7C0 File Offset: 0x0002B9C0
		public bool RadErgoTxInhibitOnVoiceCommand_HasDiffs
		{
			get
			{
				short num = (short)2122872825;
				short num2 = num;
				num = (short)72906745;
				switch (num2 == num)
				{
				}
				num = (short)1483210752;
				if (num != 0)
				{
				}
				num = (short)704380929;
				if (num != 0)
				{
				}
				num = (short)209715200;
				short num3 = num;
				return this.radErgoTxInhibitOnVoiceCommand._HasDiffs;
			}
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x060002AF RID: 687 RVA: 0x0002D878 File Offset: 0x0002BA78
		// (set) Token: 0x060002B0 RID: 688 RVA: 0x0002D930 File Offset: 0x0002BB30
		public string RadErgoTxInhibitOffVoiceCommandValue
		{
			get
			{
				short num = (short)722592376;
				short num2 = num;
				num = (short)2085282424;
				switch (num2 == num)
				{
				}
				num = (short)324272129;
				if (num != 0)
				{
				}
				num = (short)690356224;
				if (num != 0)
				{
				}
				num = (short)519569408;
				short num3 = num;
				return this.radErgoTxInhibitOffVoiceCommand.Value;
			}
			set
			{
				short num = (short)193540665;
				short num2 = num;
				num = (short)620245561;
				switch (num2 == num)
				{
				}
				num = (short)897843200;
				if (num != 0)
				{
				}
				num = (short)881786881;
				if (num != 0)
				{
				}
				num = (short)1838743552;
				short num3 = num;
				this.radErgoTxInhibitOffVoiceCommand.Value = value;
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x060002B1 RID: 689 RVA: 0x0002D9E8 File Offset: 0x0002BBE8
		public global::AcpBusinessLayer.AcpField<string> RadErgoTxInhibitOffVoiceCommand
		{
			get
			{
				short num = (short)74527432;
				short num2 = num;
				num = (short)2110468808;
				switch (num2 == num)
				{
				}
				num = (short)1784020993;
				if (num != 0)
				{
				}
				num = (short)1255276544;
				if (num != 0)
				{
				}
				num = (short)502267904;
				short num3 = num;
				return this.radErgoTxInhibitOffVoiceCommand;
			}
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x060002B2 RID: 690 RVA: 0x0002DA98 File Offset: 0x0002BC98
		// (set) Token: 0x060002B3 RID: 691 RVA: 0x0002DB4C File Offset: 0x0002BD4C
		public string RadErgoTxInhibitOffVoiceCommand_UIValue
		{
			get
			{
				short num = (short)1911899484;
				short num2 = num;
				num = (short)1116489052;
				switch (num2 == num)
				{
				}
				num = (short)956825600;
				if (num != 0)
				{
				}
				num = (short)1237188609;
				if (num != 0)
				{
				}
				num = (short)1050017792;
				short num3 = num;
				return this.radErgoTxInhibitOffVoiceCommand.Value;
			}
			set
			{
				short num = (short)231257359;
				short num2 = num;
				num = (short)2108470543;
				switch (num2 == num)
				{
				}
				num = (short)1978662912;
				if (num != 0)
				{
				}
				num = (short)983041;
				if (num != 0)
				{
				}
				num = (short)654508032;
				short num3 = num;
				this.radErgoTxInhibitOffVoiceCommand.Value = value;
			}
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x060002B4 RID: 692 RVA: 0x0002DC04 File Offset: 0x0002BE04
		// (set) Token: 0x060002B5 RID: 693 RVA: 0x0002DCB8 File Offset: 0x0002BEB8
		public bool RadErgoTxInhibitOffVoiceCommand_Applicable
		{
			get
			{
				short num = (short)1684829859;
				short num2 = num;
				num = (short)1010529955;
				switch (num2 == num)
				{
				}
				num = (short)1117257729;
				if (num != 0)
				{
				}
				num = (short)393936896;
				if (num != 0)
				{
				}
				num = (short)322437120;
				short num3 = num;
				return this.radErgoTxInhibitOffVoiceCommand.Applicable;
			}
			set
			{
				short num = (short)1526893241;
				short num2 = num;
				num = (short)1139378873;
				switch (num2 == num)
				{
				}
				num = (short)228982785;
				if (num != 0)
				{
				}
				num = (short)1972174848;
				if (num != 0)
				{
				}
				num = (short)951189504;
				short num3 = num;
				this.radErgoTxInhibitOffVoiceCommand.Applicable = value;
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x060002B6 RID: 694 RVA: 0x0002DD70 File Offset: 0x0002BF70
		// (set) Token: 0x060002B7 RID: 695 RVA: 0x0002DE20 File Offset: 0x0002C020
		public bool RadErgoTxInhibitOffVoiceCommand_Valid
		{
			get
			{
				short num = (short)1726414849;
				if (num != 0)
				{
				}
				num = (short)1999243888;
				short num2 = num;
				num = (short)1977027184;
				switch (num2 == num)
				{
				}
				num = (short)377028608;
				if (num != 0)
				{
				}
				num = (short)1860435968;
				short num3 = num;
				return this.radErgoTxInhibitOffVoiceCommand.Valid;
			}
			set
			{
				short num = (short)282507746;
				short num2 = num;
				num = (short)605534690;
				switch (num2 == num)
				{
				}
				num = (short)1708261376;
				if (num != 0)
				{
				}
				num = (short)513343489;
				if (num != 0)
				{
				}
				num = (short)2107310080;
				short num3 = num;
				this.radErgoTxInhibitOffVoiceCommand.Valid = value;
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x060002B8 RID: 696 RVA: 0x0002DED4 File Offset: 0x0002C0D4
		// (set) Token: 0x060002B9 RID: 697 RVA: 0x0002DF88 File Offset: 0x0002C188
		public bool RadErgoTxInhibitOffVoiceCommand_Visible
		{
			get
			{
				short num = (short)640565356;
				short num2 = num;
				num = (short)1378828396;
				switch (num2 == num)
				{
				}
				num = (short)791347200;
				if (num != 0)
				{
				}
				num = (short)456130561;
				if (num != 0)
				{
				}
				num = (short)2042560512;
				short num3 = num;
				return this.radErgoTxInhibitOffVoiceCommand.Visible;
			}
			set
			{
				short num = (short)1261628743;
				short num2 = num;
				num = (short)1686105415;
				switch (num2 == num)
				{
				}
				num = (short)2069299201;
				if (num != 0)
				{
				}
				num = (short)345636864;
				if (num != 0)
				{
				}
				num = (short)1551368192;
				short num3 = num;
				this.radErgoTxInhibitOffVoiceCommand.Visible = value;
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x060002BA RID: 698 RVA: 0x0002E040 File Offset: 0x0002C240
		// (set) Token: 0x060002BB RID: 699 RVA: 0x0002E0F4 File Offset: 0x0002C2F4
		public bool RadErgoTxInhibitOffVoiceCommand_Editable
		{
			get
			{
				short num = (short)643629057;
				if (num != 0)
				{
				}
				num = (short)1225397702;
				short num2 = num;
				num = (short)126686662;
				switch (num2 == num)
				{
				}
				num = (short)665124864;
				if (num != 0)
				{
				}
				num = (short)964296704;
				short num3 = num;
				return this.radErgoTxInhibitOffVoiceCommand.Editable;
			}
			set
			{
				short num = (short)1026490369;
				if (num != 0)
				{
				}
				num = (short)1655050253;
				short num2 = num;
				num = (short)1303449613;
				switch (num2 == num)
				{
				}
				num = (short)893779968;
				if (num != 0)
				{
				}
				num = (short)1149829120;
				short num3 = num;
				this.radErgoTxInhibitOffVoiceCommand.Editable = value;
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x060002BC RID: 700 RVA: 0x0002E1A8 File Offset: 0x0002C3A8
		internal string radErgoTxInhibitOffVoiceCommand_UILabel
		{
			get
			{
				short num = (short)67503940;
				short num2 = num;
				num = (short)1604126532;
				switch (num2 == num)
				{
				}
				num = (short)378404865;
				if (num != 0)
				{
				}
				num = (short)1284177920;
				if (num != 0)
				{
				}
				num = (short)558432256;
				short num3 = num;
				return this.radErgoTxInhibitOffVoiceCommand.UIName;
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x060002BD RID: 701 RVA: 0x0002E25C File Offset: 0x0002C45C
		// (set) Token: 0x060002BE RID: 702 RVA: 0x0002E310 File Offset: 0x0002C510
		internal bool RadErgoTxInhibitOffVoiceCommand_HiddenStatic
		{
			get
			{
				short num = (short)1523165794;
				short num2 = num;
				num = (short)287025762;
				switch (num2 == num)
				{
				}
				num = (short)480968704;
				if (num != 0)
				{
				}
				num = (short)1718681601;
				if (num != 0)
				{
				}
				num = (short)277348352;
				short num3 = num;
				return this.radErgoTxInhibitOffVoiceCommand.HiddenStatic;
			}
			set
			{
				short num = (short)1011136457;
				short num2 = num;
				num = (short)15775689;
				switch (num2 == num)
				{
				}
				num = (short)884801537;
				if (num != 0)
				{
				}
				num = (short)1654456320;
				if (num != 0)
				{
				}
				num = (short)306380800;
				short num3 = num;
				this.radErgoTxInhibitOffVoiceCommand.HiddenStatic = value;
			}
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x060002BF RID: 703 RVA: 0x0002E3C4 File Offset: 0x0002C5C4
		// (set) Token: 0x060002C0 RID: 704 RVA: 0x0002E47C File Offset: 0x0002C67C
		internal bool RadErgoTxInhibitOffVoiceCommand_HiddenDynamic
		{
			get
			{
				short num = (short)1927479297;
				if (num != 0)
				{
				}
				num = (short)532661934;
				short num2 = num;
				num = (short)110872238;
				switch (num2 == num)
				{
				}
				num = (short)479789056;
				if (num != 0)
				{
				}
				num = (short)1233190912;
				short num3 = num;
				return this.radErgoTxInhibitOffVoiceCommand.HiddenDynamic;
			}
			set
			{
				short num = (short)2058457106;
				short num2 = num;
				num = (short)1272352786;
				switch (num2 == num)
				{
				}
				num = (short)1212743680;
				if (num != 0)
				{
				}
				num = (short)960954369;
				if (num != 0)
				{
				}
				num = (short)1491206144;
				short num3 = num;
				this.radErgoTxInhibitOffVoiceCommand.HiddenDynamic = value;
			}
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x060002C1 RID: 705 RVA: 0x0002E534 File Offset: 0x0002C734
		public bool RadErgoTxInhibitOffVoiceCommand_HasDiffs
		{
			get
			{
				short num = (short)1744731389;
				short num2 = num;
				num = (short)1896774909;
				switch (num2 == num)
				{
				}
				num = (short)646053889;
				if (num != 0)
				{
				}
				num = (short)2060451840;
				short num3 = num;
				num = (short)181731328;
				if (num != 0)
				{
				}
				return this.radErgoTxInhibitOffVoiceCommand._HasDiffs;
			}
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x060002C2 RID: 706 RVA: 0x0002E5E8 File Offset: 0x0002C7E8
		// (set) Token: 0x060002C3 RID: 707 RVA: 0x0002E69C File Offset: 0x0002C89C
		public string RadErgoEmergencyOnVoiceCommandValue
		{
			get
			{
				short num = (short)1333496825;
				short num2 = num;
				num = (short)481856505;
				switch (num2 == num)
				{
				}
				num = (short)243073024;
				if (num != 0)
				{
				}
				num = (short)1607335936;
				short num3 = num;
				num = (short)73924609;
				if (num != 0)
				{
				}
				return this.radErgoEmergencyOnVoiceCommand.Value;
			}
			set
			{
				short num = (short)1139216814;
				short num2 = num;
				num = (short)246682030;
				switch (num2 == num)
				{
				}
				num = (short)333053953;
				if (num != 0)
				{
				}
				num = (short)1058078720;
				short num3 = num;
				num = (short)913375232;
				if (num != 0)
				{
				}
				this.radErgoEmergencyOnVoiceCommand.Value = value;
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x060002C4 RID: 708 RVA: 0x0002E750 File Offset: 0x0002C950
		public global::AcpBusinessLayer.AcpField<string> RadErgoEmergencyOnVoiceCommand
		{
			get
			{
				short num = (short)2057606109;
				short num2 = num;
				num = (short)1162974173;
				switch (num2 == num)
				{
				}
				num = (short)939917313;
				if (num != 0)
				{
				}
				num = (short)1863385088;
				short num3 = num;
				num = (short)2128084992;
				if (num != 0)
				{
				}
				return this.radErgoEmergencyOnVoiceCommand;
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x060002C5 RID: 709 RVA: 0x0002E800 File Offset: 0x0002CA00
		// (set) Token: 0x060002C6 RID: 710 RVA: 0x0002E8B4 File Offset: 0x0002CAB4
		public string RadErgoEmergencyOnVoiceCommand_UIValue
		{
			get
			{
				short num = (short)569015330;
				short num2 = num;
				num = (short)1814264866;
				switch (num2 == num)
				{
				}
				num = (short)2014445569;
				if (num != 0)
				{
				}
				num = (short)565182464;
				short num3 = num;
				num = (short)1030225920;
				if (num != 0)
				{
				}
				return this.radErgoEmergencyOnVoiceCommand.Value;
			}
			set
			{
				short num = (short)1030017669;
				short num2 = num;
				num = (short)1922880133;
				switch (num2 == num)
				{
				}
				num = (short)1329397761;
				if (num != 0)
				{
				}
				num = (short)394788864;
				short num3 = num;
				num = (short)1210187776;
				if (num != 0)
				{
				}
				this.radErgoEmergencyOnVoiceCommand.Value = value;
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x060002C7 RID: 711 RVA: 0x0002E96C File Offset: 0x0002CB6C
		// (set) Token: 0x060002C8 RID: 712 RVA: 0x0002EA24 File Offset: 0x0002CC24
		public bool RadErgoEmergencyOnVoiceCommand_Applicable
		{
			get
			{
				short num = (short)1242760340;
				short num2 = num;
				num = (short)1088488596;
				switch (num2 == num)
				{
				}
				num = (short)2006908929;
				if (num != 0)
				{
				}
				num = (short)567410688;
				short num3 = num;
				num = (short)1505296384;
				if (num != 0)
				{
				}
				return this.radErgoEmergencyOnVoiceCommand.Applicable;
			}
			set
			{
				short num = (short)1574883877;
				short num2 = num;
				num = (short)1713230373;
				switch (num2 == num)
				{
				}
				num = (short)1965096961;
				if (num != 0)
				{
				}
				num = (short)372047872;
				short num3 = num;
				num = (short)771555328;
				if (num != 0)
				{
				}
				this.radErgoEmergencyOnVoiceCommand.Applicable = value;
			}
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x060002C9 RID: 713 RVA: 0x0002EAD8 File Offset: 0x0002CCD8
		// (set) Token: 0x060002CA RID: 714 RVA: 0x0002EB8C File Offset: 0x0002CD8C
		public bool RadErgoEmergencyOnVoiceCommand_Valid
		{
			get
			{
				short num = (short)895394454;
				short num2 = num;
				num = (short)551985814;
				switch (num2 == num)
				{
				}
				num = (short)1750990849;
				if (num != 0)
				{
				}
				num = (short)996081664;
				short num3 = num;
				num = (short)138543104;
				if (num != 0)
				{
				}
				return this.radErgoEmergencyOnVoiceCommand.Valid;
			}
			set
			{
				short num = (short)2079781686;
				short num2 = num;
				num = (short)129233718;
				switch (num2 == num)
				{
				}
				num = (short)526974976;
				if (num != 0)
				{
				}
				num = (short)687276032;
				short num3 = num;
				num = (short)2004221953;
				if (num != 0)
				{
				}
				this.radErgoEmergencyOnVoiceCommand.Valid = value;
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x060002CB RID: 715 RVA: 0x0002EC40 File Offset: 0x0002CE40
		// (set) Token: 0x060002CC RID: 716 RVA: 0x0002ECF4 File Offset: 0x0002CEF4
		public bool RadErgoEmergencyOnVoiceCommand_Visible
		{
			get
			{
				short num = (short)860254203;
				short num2 = num;
				num = (short)144535547;
				switch (num2 == num)
				{
				}
				num = (short)1338441729;
				if (num != 0)
				{
				}
				num = (short)38273024;
				short num3 = num;
				num = (short)645595136;
				if (num != 0)
				{
				}
				return this.radErgoEmergencyOnVoiceCommand.Visible;
			}
			set
			{
				short num = (short)222897250;
				short num2 = num;
				num = (short)1298343010;
				switch (num2 == num)
				{
				}
				num = (short)1928069121;
				if (num != 0)
				{
				}
				num = (short)912523264;
				short num3 = num;
				num = (short)865927168;
				if (num != 0)
				{
				}
				this.radErgoEmergencyOnVoiceCommand.Visible = value;
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x060002CD RID: 717 RVA: 0x0002EDA8 File Offset: 0x0002CFA8
		// (set) Token: 0x060002CE RID: 718 RVA: 0x0002EE5C File Offset: 0x0002D05C
		public bool RadErgoEmergencyOnVoiceCommand_Editable
		{
			get
			{
				short num = (short)1967383538;
				short num2 = num;
				num = (short)1278206962;
				switch (num2 == num)
				{
				}
				num = (short)798556161;
				if (num != 0)
				{
				}
				num = (short)130613248;
				short num3 = num;
				num = (short)1012989952;
				if (num != 0)
				{
				}
				return this.radErgoEmergencyOnVoiceCommand.Editable;
			}
			set
			{
				short num = (short)1039994840;
				short num2 = num;
				num = (short)1120145368;
				switch (num2 == num)
				{
				}
				num = (short)1741750272;
				if (num != 0)
				{
				}
				num = (short)315621376;
				short num3 = num;
				num = (short)1224802305;
				if (num != 0)
				{
				}
				this.radErgoEmergencyOnVoiceCommand.Editable = value;
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x060002CF RID: 719 RVA: 0x0002EF14 File Offset: 0x0002D114
		internal string radErgoEmergencyOnVoiceCommand_UILabel
		{
			get
			{
				short num = (short)1609247416;
				short num2 = num;
				num = (short)1139026616;
				switch (num2 == num)
				{
				}
				num = (short)1310654464;
				if (num != 0)
				{
				}
				num = (short)557842432;
				short num3 = num;
				num = (short)896794625;
				if (num != 0)
				{
				}
				return this.radErgoEmergencyOnVoiceCommand.UIName;
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x060002D0 RID: 720 RVA: 0x0002EFC8 File Offset: 0x0002D1C8
		// (set) Token: 0x060002D1 RID: 721 RVA: 0x0002F07C File Offset: 0x0002D27C
		internal bool RadErgoEmergencyOnVoiceCommand_HiddenStatic
		{
			get
			{
				short num = (short)117988511;
				short num2 = num;
				num = (short)1938447519;
				switch (num2 == num)
				{
				}
				num = (short)1317404673;
				if (num != 0)
				{
				}
				num = (short)156172288;
				short num3 = num;
				num = (short)309788672;
				if (num != 0)
				{
				}
				return this.radErgoEmergencyOnVoiceCommand.HiddenStatic;
			}
			set
			{
				short num = (short)1810181081;
				short num2 = num;
				num = (short)173419481;
				switch (num2 == num)
				{
				}
				num = (short)1522466817;
				if (num != 0)
				{
				}
				num = (short)2125463552;
				short num3 = num;
				num = (short)1702821888;
				if (num != 0)
				{
				}
				this.radErgoEmergencyOnVoiceCommand.HiddenStatic = value;
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x060002D2 RID: 722 RVA: 0x0002F134 File Offset: 0x0002D334
		// (set) Token: 0x060002D3 RID: 723 RVA: 0x0002F1E8 File Offset: 0x0002D3E8
		internal bool RadErgoEmergencyOnVoiceCommand_HiddenDynamic
		{
			get
			{
				short num = (short)1627272349;
				short num2 = num;
				num = (short)385954973;
				switch (num2 == num)
				{
				}
				num = (short)1503133696;
				if (num != 0)
				{
				}
				num = (short)537788416;
				short num3 = num;
				num = (short)1897660417;
				if (num != 0)
				{
				}
				return this.radErgoEmergencyOnVoiceCommand.HiddenDynamic;
			}
			set
			{
				short num = (short)1795547025;
				short num2 = num;
				num = (short)2043600785;
				switch (num2 == num)
				{
				}
				num = (short)1245577217;
				if (num != 0)
				{
				}
				num = (short)220921856;
				short num3 = num;
				num = (short)239992832;
				if (num != 0)
				{
				}
				this.radErgoEmergencyOnVoiceCommand.HiddenDynamic = value;
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x060002D4 RID: 724 RVA: 0x0002F29C File Offset: 0x0002D49C
		public bool RadErgoEmergencyOnVoiceCommand_HasDiffs
		{
			get
			{
				short num = (short)226649465;
				short num2 = num;
				num = (short)1464362361;
				switch (num2 == num)
				{
				}
				num = (short)1410793473;
				if (num != 0)
				{
				}
				num = (short)1045954560;
				short num3 = num;
				num = (short)726073344;
				if (num != 0)
				{
				}
				return this.radErgoEmergencyOnVoiceCommand._HasDiffs;
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x060002D5 RID: 725 RVA: 0x0002F350 File Offset: 0x0002D550
		// (set) Token: 0x060002D6 RID: 726 RVA: 0x0002F408 File Offset: 0x0002D608
		public string RadErgoInCallUserAlertOnVoiceCommandValue
		{
			get
			{
				short num = (short)538967994;
				short num2 = num;
				num = (short)1685061562;
				switch (num2 == num)
				{
				}
				num = (short)1354235905;
				if (num != 0)
				{
				}
				num = (short)5963776;
				short num3 = num;
				num = (short)1392640000;
				if (num != 0)
				{
				}
				return this.radErgoInCallUserAlertOnVoiceCommand.Value;
			}
			set
			{
				short num = (short)1644449145;
				short num2 = num;
				num = (short)1100172665;
				switch (num2 == num)
				{
				}
				num = (short)774045697;
				if (num != 0)
				{
				}
				num = (short)1143209984;
				short num3 = num;
				num = (short)1597964288;
				if (num != 0)
				{
				}
				this.radErgoInCallUserAlertOnVoiceCommand.Value = value;
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x060002D7 RID: 727 RVA: 0x0002F4BC File Offset: 0x0002D6BC
		public global::AcpBusinessLayer.AcpField<string> RadErgoInCallUserAlertOnVoiceCommand
		{
			get
			{
				short num = (short)1390456002;
				short num2 = num;
				num = (short)83537090;
				switch (num2 == num)
				{
				}
				num = (short)1694695424;
				if (num != 0)
				{
				}
				num = (short)270598144;
				short num3 = num;
				num = (short)858128385;
				if (num != 0)
				{
				}
				return this.radErgoInCallUserAlertOnVoiceCommand;
			}
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x060002D8 RID: 728 RVA: 0x0002F56C File Offset: 0x0002D76C
		// (set) Token: 0x060002D9 RID: 729 RVA: 0x0002F624 File Offset: 0x0002D824
		public string RadErgoInCallUserAlertOnVoiceCommand_UIValue
		{
			get
			{
				short num = (short)1922060123;
				short num2 = num;
				num = (short)2095664987;
				switch (num2 == num)
				{
				}
				num = (short)93192193;
				if (num != 0)
				{
				}
				num = (short)1559625728;
				short num3 = num;
				num = (short)498794496;
				if (num != 0)
				{
				}
				return this.radErgoInCallUserAlertOnVoiceCommand.Value;
			}
			set
			{
				short num = (short)2128499879;
				short num2 = num;
				num = (short)477582503;
				switch (num2 == num)
				{
				}
				num = (short)266600449;
				if (num != 0)
				{
				}
				num = (short)2118516736;
				short num3 = num;
				num = (short)835321856;
				if (num != 0)
				{
				}
				this.radErgoInCallUserAlertOnVoiceCommand.Value = value;
			}
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x060002DA RID: 730 RVA: 0x0002F6D8 File Offset: 0x0002D8D8
		// (set) Token: 0x060002DB RID: 731 RVA: 0x0002F790 File Offset: 0x0002D990
		public bool RadErgoInCallUserAlertOnVoiceCommand_Applicable
		{
			get
			{
				short num = (short)1953444721;
				short num2 = num;
				num = (short)579875697;
				switch (num2 == num)
				{
				}
				num = (short)46858241;
				if (num != 0)
				{
				}
				num = (short)1247674368;
				short num3 = num;
				num = (short)786366464;
				if (num != 0)
				{
				}
				return this.radErgoInCallUserAlertOnVoiceCommand.Applicable;
			}
			set
			{
				short num = (short)795107783;
				short num2 = num;
				num = (short)1626235335;
				switch (num2 == num)
				{
				}
				num = (short)1743192065;
				if (num != 0)
				{
				}
				num = (short)701890560;
				short num3 = num;
				num = (short)1337589760;
				if (num != 0)
				{
				}
				this.radErgoInCallUserAlertOnVoiceCommand.Applicable = value;
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x060002DC RID: 732 RVA: 0x0002F848 File Offset: 0x0002DA48
		// (set) Token: 0x060002DD RID: 733 RVA: 0x0002F900 File Offset: 0x0002DB00
		public bool RadErgoInCallUserAlertOnVoiceCommand_Valid
		{
			get
			{
				short num = (short)300831698;
				short num2 = num;
				num = (short)208229330;
				switch (num2 == num)
				{
				}
				num = (short)1200619521;
				if (num != 0)
				{
				}
				num = (short)2049376256;
				short num3 = num;
				num = (short)160694272;
				if (num != 0)
				{
				}
				return this.radErgoInCallUserAlertOnVoiceCommand.Valid;
			}
			set
			{
				short num = (short)1185582287;
				short num2 = num;
				num = (short)1024625871;
				switch (num2 == num)
				{
				}
				num = (short)1816068096;
				if (num != 0)
				{
				}
				num = (short)1057751040;
				short num3 = num;
				num = (short)672530433;
				if (num != 0)
				{
				}
				this.radErgoInCallUserAlertOnVoiceCommand.Valid = value;
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x060002DE RID: 734 RVA: 0x0002F9B8 File Offset: 0x0002DBB8
		// (set) Token: 0x060002DF RID: 735 RVA: 0x0002FA70 File Offset: 0x0002DC70
		public bool RadErgoInCallUserAlertOnVoiceCommand_Visible
		{
			get
			{
				short num = (short)143305305;
				short num2 = num;
				num = (short)153725529;
				switch (num2 == num)
				{
				}
				num = (short)886505473;
				if (num != 0)
				{
				}
				num = (short)1245052928;
				short num3 = num;
				num = (short)983040;
				if (num != 0)
				{
				}
				return this.radErgoInCallUserAlertOnVoiceCommand.Visible;
			}
			set
			{
				short num = (short)1380742576;
				short num2 = num;
				num = (short)256144816;
				switch (num2 == num)
				{
				}
				num = (short)1604583425;
				if (num != 0)
				{
				}
				num = (short)1865482240;
				short num3 = num;
				num = (short)442892288;
				if (num != 0)
				{
				}
				this.radErgoInCallUserAlertOnVoiceCommand.Visible = value;
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x060002E0 RID: 736 RVA: 0x0002FB24 File Offset: 0x0002DD24
		// (set) Token: 0x060002E1 RID: 737 RVA: 0x0002FBD8 File Offset: 0x0002DDD8
		public bool RadErgoInCallUserAlertOnVoiceCommand_Editable
		{
			get
			{
				short num = (short)884168126;
				short num2 = num;
				num = (short)868701630;
				switch (num2 == num)
				{
				}
				num = (short)402784256;
				if (num != 0)
				{
				}
				num = (short)674889728;
				short num3 = num;
				num = (short)1657667585;
				if (num != 0)
				{
				}
				return this.radErgoInCallUserAlertOnVoiceCommand.Editable;
			}
			set
			{
				short num = (short)567090324;
				short num2 = num;
				num = (short)1371348116;
				switch (num2 == num)
				{
				}
				num = (short)836632577;
				if (num != 0)
				{
				}
				num = (short)390856704;
				short num3 = num;
				num = (short)723255296;
				if (num != 0)
				{
				}
				this.radErgoInCallUserAlertOnVoiceCommand.Editable = value;
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x060002E2 RID: 738 RVA: 0x0002FC90 File Offset: 0x0002DE90
		internal string radErgoInCallUserAlertOnVoiceCommand_UILabel
		{
			get
			{
				short num = (short)624756909;
				short num2 = num;
				num = (short)1707673773;
				switch (num2 == num)
				{
				}
				num = (short)1730084865;
				if (num != 0)
				{
				}
				num = (short)633208832;
				short num3 = num;
				num = (short)1153892352;
				if (num != 0)
				{
				}
				return this.radErgoInCallUserAlertOnVoiceCommand.UIName;
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x060002E3 RID: 739 RVA: 0x0002FD44 File Offset: 0x0002DF44
		// (set) Token: 0x060002E4 RID: 740 RVA: 0x0002FDFC File Offset: 0x0002DFFC
		internal bool RadErgoInCallUserAlertOnVoiceCommand_HiddenStatic
		{
			get
			{
				short num = (short)598968004;
				short num2 = num;
				num = (short)919045828;
				switch (num2 == num)
				{
				}
				num = (short)309723137;
				if (num != 0)
				{
				}
				num = (short)1088094208;
				short num3 = num;
				num = (short)1591476224;
				if (num != 0)
				{
				}
				return this.radErgoInCallUserAlertOnVoiceCommand.HiddenStatic;
			}
			set
			{
				short num = (short)1000324177;
				short num2 = num;
				num = (short)1942797393;
				switch (num2 == num)
				{
				}
				num = (short)1500643328;
				if (num != 0)
				{
				}
				num = (short)1686110208;
				short num3 = num;
				num = (short)19857409;
				if (num != 0)
				{
				}
				this.radErgoInCallUserAlertOnVoiceCommand.HiddenStatic = value;
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x060002E5 RID: 741 RVA: 0x0002FEB0 File Offset: 0x0002E0B0
		// (set) Token: 0x060002E6 RID: 742 RVA: 0x0002FF64 File Offset: 0x0002E164
		internal bool RadErgoInCallUserAlertOnVoiceCommand_HiddenDynamic
		{
			get
			{
				short num = (short)161375819;
				short num2 = num;
				num = (short)1866753611;
				switch (num2 == num)
				{
				}
				num = (short)610664449;
				if (num != 0)
				{
				}
				num = (short)2031222784;
				short num3 = num;
				num = (short)1101463552;
				if (num != 0)
				{
				}
				return this.radErgoInCallUserAlertOnVoiceCommand.HiddenDynamic;
			}
			set
			{
				short num = (short)481054363;
				short num2 = num;
				num = (short)1426083483;
				switch (num2 == num)
				{
				}
				num = (short)1940783105;
				if (num != 0)
				{
				}
				num = (short)331808768;
				short num3 = num;
				num = (short)1035534336;
				if (num != 0)
				{
				}
				this.radErgoInCallUserAlertOnVoiceCommand.HiddenDynamic = value;
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x060002E7 RID: 743 RVA: 0x00030018 File Offset: 0x0002E218
		public bool RadErgoInCallUserAlertOnVoiceCommand_HasDiffs
		{
			get
			{
				short num = (short)1397405206;
				short num2 = num;
				num = (short)1210627606;
				switch (num2 == num)
				{
				}
				num = (short)2115764224;
				short num3 = num;
				num = (short)901709825;
				if (num != 0)
				{
				}
				num = (short)710672384;
				if (num != 0)
				{
				}
				return this.radErgoInCallUserAlertOnVoiceCommand._HasDiffs;
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x060002E8 RID: 744 RVA: 0x000300CC File Offset: 0x0002E2CC
		// (set) Token: 0x060002E9 RID: 745 RVA: 0x00030180 File Offset: 0x0002E380
		public string RadErgoInCallUserAlertOffVoiceCommandValue
		{
			get
			{
				short num = (short)1153392706;
				short num2 = num;
				num = (short)853303362;
				switch (num2 == num)
				{
				}
				num = (short)1056833536;
				short num3 = num;
				num = (short)1591869441;
				if (num != 0)
				{
				}
				num = (short)1733885952;
				if (num != 0)
				{
				}
				return this.radErgoInCallUserAlertOffVoiceCommand.Value;
			}
			set
			{
				short num = (short)1042956488;
				short num2 = num;
				num = (short)291848392;
				switch (num2 == num)
				{
				}
				num = (short)2014838784;
				short num3 = num;
				num = (short)1894973441;
				if (num != 0)
				{
				}
				num = (short)151388160;
				if (num != 0)
				{
				}
				this.radErgoInCallUserAlertOffVoiceCommand.Value = value;
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x060002EA RID: 746 RVA: 0x00030234 File Offset: 0x0002E434
		public global::AcpBusinessLayer.AcpField<string> RadErgoInCallUserAlertOffVoiceCommand
		{
			get
			{
				short num = (short)949543658;
				short num2 = num;
				num = (short)28828394;
				switch (num2 == num)
				{
				}
				num = (short)867827712;
				short num3 = num;
				num = (short)839712769;
				if (num != 0)
				{
				}
				num = (short)31326208;
				if (num != 0)
				{
				}
				return this.radErgoInCallUserAlertOffVoiceCommand;
			}
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x060002EB RID: 747 RVA: 0x000302E4 File Offset: 0x0002E4E4
		// (set) Token: 0x060002EC RID: 748 RVA: 0x00030398 File Offset: 0x0002E598
		public string RadErgoInCallUserAlertOffVoiceCommand_UIValue
		{
			get
			{
				short num = (short)1070257164;
				short num2 = num;
				num = (short)1533465612;
				switch (num2 == num)
				{
				}
				num = (short)1841102848;
				short num3 = num;
				num = (short)1220608000;
				if (num != 0)
				{
				}
				num = (short)1454178305;
				if (num != 0)
				{
				}
				return this.radErgoInCallUserAlertOffVoiceCommand.Value;
			}
			set
			{
				short num = (short)973182850;
				short num2 = num;
				num = (short)1424136066;
				switch (num2 == num)
				{
				}
				num = (short)1590689792;
				short num3 = num;
				num = (short)1630732289;
				if (num != 0)
				{
				}
				num = (short)452395008;
				if (num != 0)
				{
				}
				this.radErgoInCallUserAlertOffVoiceCommand.Value = value;
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x060002ED RID: 749 RVA: 0x00030450 File Offset: 0x0002E650
		// (set) Token: 0x060002EE RID: 750 RVA: 0x00030500 File Offset: 0x0002E700
		public bool RadErgoInCallUserAlertOffVoiceCommand_Applicable
		{
			get
			{
				short num = (short)1367186036;
				short num2 = num;
				num = (short)1125685876;
				switch (num2 == num)
				{
				}
				num = (short)837550080;
				short num3 = num;
				num = (short)1885536257;
				if (num != 0)
				{
				}
				num = (short)1636171776;
				if (num != 0)
				{
				}
				return this.radErgoInCallUserAlertOffVoiceCommand.Applicable;
			}
			set
			{
				short num = (short)1220253056;
				short num2 = num;
				num = (short)731092352;
				switch (num2 == num)
				{
				}
				num = (short)1998454784;
				short num3 = num;
				num = (short)319094785;
				if (num != 0)
				{
				}
				num = (short)413138944;
				if (num != 0)
				{
				}
				this.radErgoInCallUserAlertOffVoiceCommand.Applicable = value;
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x060002EF RID: 751 RVA: 0x000305B8 File Offset: 0x0002E7B8
		// (set) Token: 0x060002F0 RID: 752 RVA: 0x0003066C File Offset: 0x0002E86C
		public bool RadErgoInCallUserAlertOffVoiceCommand_Valid
		{
			get
			{
				short num = (short)559635577;
				short num2 = num;
				num = (short)1240620153;
				switch (num2 == num)
				{
				}
				num = (short)1847918592;
				short num3 = num;
				num = (short)1053360129;
				if (num != 0)
				{
				}
				num = (short)980615168;
				if (num != 0)
				{
				}
				return this.radErgoInCallUserAlertOffVoiceCommand.Valid;
			}
			set
			{
				short num = (short)1520491886;
				short num2 = num;
				num = (short)760405358;
				switch (num2 == num)
				{
				}
				num = (short)1259732992;
				short num3 = num;
				num = (short)252182529;
				if (num != 0)
				{
				}
				num = (short)2121138176;
				if (num != 0)
				{
				}
				this.radErgoInCallUserAlertOffVoiceCommand.Valid = value;
			}
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x060002F1 RID: 753 RVA: 0x00030724 File Offset: 0x0002E924
		// (set) Token: 0x060002F2 RID: 754 RVA: 0x000307D8 File Offset: 0x0002E9D8
		public bool RadErgoInCallUserAlertOffVoiceCommand_Visible
		{
			get
			{
				short num = (short)1743650817;
				if (num != 0)
				{
				}
				num = (short)213117710;
				short num2 = num;
				num = (short)860744462;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1559756800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)711917568;
				if (num != 0)
				{
				}
				return this.radErgoInCallUserAlertOffVoiceCommand.Visible;
			}
			set
			{
				short num = (short)1755231086;
				short num2 = num;
				num = (short)1057862510;
				switch (num2 == num)
				{
				}
				num = (short)2034565120;
				short num3 = num;
				num = (short)1289617409;
				if (num != 0)
				{
				}
				num = (short)294256640;
				if (num != 0)
				{
				}
				this.radErgoInCallUserAlertOffVoiceCommand.Visible = value;
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x060002F3 RID: 755 RVA: 0x0003088C File Offset: 0x0002EA8C
		// (set) Token: 0x060002F4 RID: 756 RVA: 0x00030940 File Offset: 0x0002EB40
		public bool RadErgoInCallUserAlertOffVoiceCommand_Editable
		{
			get
			{
				short num = (short)870121473;
				if (num != 0)
				{
				}
				num = (short)509991786;
				short num2 = num;
				num = (short)230087530;
				switch (num2 == num)
				{
				default:
				{
					num = (short)233701376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)730071040;
				if (num != 0)
				{
				}
				return this.radErgoInCallUserAlertOffVoiceCommand.Editable;
			}
			set
			{
				short num = (short)846594049;
				if (num != 0)
				{
				}
				num = (short)1002337733;
				short num2 = num;
				num = (short)171734469;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1194590208;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)881852416;
				if (num != 0)
				{
				}
				this.radErgoInCallUserAlertOffVoiceCommand.Editable = value;
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x060002F5 RID: 757 RVA: 0x000309F4 File Offset: 0x0002EBF4
		internal string radErgoInCallUserAlertOffVoiceCommand_UILabel
		{
			get
			{
				short num = (short)2100680759;
				short num2 = num;
				num = (short)763680823;
				switch (num2 == num)
				{
				}
				num = (short)581959680;
				short num3 = num;
				num = (short)284622849;
				if (num != 0)
				{
				}
				num = (short)513277952;
				if (num != 0)
				{
				}
				return this.radErgoInCallUserAlertOffVoiceCommand.UIName;
			}
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x060002F6 RID: 758 RVA: 0x00030AAC File Offset: 0x0002ECAC
		// (set) Token: 0x060002F7 RID: 759 RVA: 0x00030B60 File Offset: 0x0002ED60
		internal bool RadErgoInCallUserAlertOffVoiceCommand_HiddenStatic
		{
			get
			{
				short num = (short)1128030516;
				short num2 = num;
				num = (short)900030772;
				switch (num2 == num)
				{
				}
				num = (short)1062797312;
				short num3 = num;
				num = (short)179109889;
				if (num != 0)
				{
				}
				num = (short)2042036224;
				if (num != 0)
				{
				}
				return this.radErgoInCallUserAlertOffVoiceCommand.HiddenStatic;
			}
			set
			{
				short num = (short)1007718488;
				short num2 = num;
				num = (short)415993944;
				switch (num2 == num)
				{
				}
				num = (short)1950220288;
				short num3 = num;
				num = (short)1994522625;
				if (num != 0)
				{
				}
				num = (short)68878336;
				if (num != 0)
				{
				}
				this.radErgoInCallUserAlertOffVoiceCommand.HiddenStatic = value;
			}
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x060002F8 RID: 760 RVA: 0x00030C14 File Offset: 0x0002EE14
		// (set) Token: 0x060002F9 RID: 761 RVA: 0x00030CC8 File Offset: 0x0002EEC8
		internal bool RadErgoInCallUserAlertOffVoiceCommand_HiddenDynamic
		{
			get
			{
				short num = (short)937426945;
				if (num != 0)
				{
				}
				num = (short)108998532;
				short num2 = num;
				num = (short)2079076228;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1908211712;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1772945408;
				if (num != 0)
				{
				}
				return this.radErgoInCallUserAlertOffVoiceCommand.HiddenDynamic;
			}
			set
			{
				short num = (short)1492246326;
				short num2 = num;
				num = (short)1480515382;
				switch (num2 == num)
				{
				}
				num = (short)878837760;
				short num3 = num;
				num = (short)188350464;
				if (num != 0)
				{
				}
				num = (short)436011009;
				if (num != 0)
				{
				}
				this.radErgoInCallUserAlertOffVoiceCommand.HiddenDynamic = value;
			}
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x060002FA RID: 762 RVA: 0x00030D7C File Offset: 0x0002EF7C
		public bool RadErgoInCallUserAlertOffVoiceCommand_HasDiffs
		{
			get
			{
				short num = (short)2091057153;
				if (num != 0)
				{
				}
				num = (short)1938735698;
				short num2 = num;
				num = (short)1645003346;
				switch (num2 == num)
				{
				default:
				{
					num = (short)95223808;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1850671104;
				if (num != 0)
				{
				}
				return this.radErgoInCallUserAlertOffVoiceCommand._HasDiffs;
			}
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x060002FB RID: 763 RVA: 0x00030E30 File Offset: 0x0002F030
		// (set) Token: 0x060002FC RID: 764 RVA: 0x00030EE4 File Offset: 0x0002F0E4
		public string RadErgoSecureTxSelectOnVoiceCommandValue
		{
			get
			{
				short num = (short)188170037;
				short num2 = num;
				num = (short)683425589;
				switch (num2 == num)
				{
				}
				num = (short)284033024;
				short num3 = num;
				num = (short)1390477313;
				if (num != 0)
				{
				}
				num = (short)907214848;
				if (num != 0)
				{
				}
				return this.radErgoSecureTxSelectOnVoiceCommand.Value;
			}
			set
			{
				short num = (short)1615349936;
				short num2 = num;
				num = (short)1742686384;
				switch (num2 == num)
				{
				}
				num = (short)671875072;
				short num3 = num;
				num = (short)1092812800;
				if (num != 0)
				{
				}
				num = (short)1774977025;
				if (num != 0)
				{
				}
				this.radErgoSecureTxSelectOnVoiceCommand.Value = value;
			}
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x060002FD RID: 765 RVA: 0x00030F9C File Offset: 0x0002F19C
		public global::AcpBusinessLayer.AcpField<string> RadErgoSecureTxSelectOnVoiceCommand
		{
			get
			{
				short num = (short)1525117118;
				short num2 = num;
				num = (short)1054503102;
				switch (num2 == num)
				{
				}
				num = (short)138805248;
				short num3 = num;
				num = (short)1958477824;
				if (num != 0)
				{
				}
				num = (short)918290433;
				if (num != 0)
				{
				}
				return this.radErgoSecureTxSelectOnVoiceCommand;
			}
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x060002FE RID: 766 RVA: 0x00031048 File Offset: 0x0002F248
		// (set) Token: 0x060002FF RID: 767 RVA: 0x000310FC File Offset: 0x0002F2FC
		public string RadErgoSecureTxSelectOnVoiceCommand_UIValue
		{
			get
			{
				short num = (short)1257156801;
				short num2 = num;
				num = (short)911257793;
				switch (num2 == num)
				{
				}
				num = (short)1287127040;
				short num3 = num;
				num = (short)831324160;
				if (num != 0)
				{
				}
				num = (short)1364590593;
				if (num != 0)
				{
				}
				return this.radErgoSecureTxSelectOnVoiceCommand.Value;
			}
			set
			{
				short num = (short)1690256725;
				short num2 = num;
				num = (short)725828949;
				switch (num2 == num)
				{
				}
				num = (short)551550976;
				short num3 = num;
				num = (short)2127757313;
				if (num != 0)
				{
				}
				num = (short)1109196800;
				if (num != 0)
				{
				}
				this.radErgoSecureTxSelectOnVoiceCommand.Value = value;
			}
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x06000300 RID: 768 RVA: 0x000311B0 File Offset: 0x0002F3B0
		// (set) Token: 0x06000301 RID: 769 RVA: 0x00031268 File Offset: 0x0002F468
		public bool RadErgoSecureTxSelectOnVoiceCommand_Applicable
		{
			get
			{
				short num = (short)1111687169;
				if (num != 0)
				{
				}
				num = (short)1059125309;
				short num2 = num;
				num = (short)1229453373;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1142161408;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1385758720;
				if (num != 0)
				{
				}
				return this.radErgoSecureTxSelectOnVoiceCommand.Applicable;
			}
			set
			{
				short num = (short)635731334;
				short num2 = num;
				num = (short)846167430;
				switch (num2 == num)
				{
				}
				num = (short)1322778624;
				short num3 = num;
				num = (short)994639873;
				if (num != 0)
				{
				}
				num = (short)706936832;
				if (num != 0)
				{
				}
				this.radErgoSecureTxSelectOnVoiceCommand.Applicable = value;
			}
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x06000302 RID: 770 RVA: 0x0003131C File Offset: 0x0002F51C
		// (set) Token: 0x06000303 RID: 771 RVA: 0x000313D0 File Offset: 0x0002F5D0
		public bool RadErgoSecureTxSelectOnVoiceCommand_Valid
		{
			get
			{
				short num = (short)1498356285;
				short num2 = num;
				num = (short)1422465597;
				switch (num2 == num)
				{
				}
				num = (short)1069023232;
				short num3 = num;
				num = (short)1730281473;
				if (num != 0)
				{
				}
				num = (short)205455360;
				if (num != 0)
				{
				}
				return this.radErgoSecureTxSelectOnVoiceCommand.Valid;
			}
			set
			{
				short num = (short)1664286721;
				if (num != 0)
				{
				}
				num = (short)1808467918;
				short num2 = num;
				num = (short)244385742;
				switch (num2 == num)
				{
				default:
				{
					num = (short)522190848;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)812384256;
				if (num != 0)
				{
				}
				this.radErgoSecureTxSelectOnVoiceCommand.Valid = value;
			}
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x06000304 RID: 772 RVA: 0x00031488 File Offset: 0x0002F688
		// (set) Token: 0x06000305 RID: 773 RVA: 0x0003153C File Offset: 0x0002F73C
		public bool RadErgoSecureTxSelectOnVoiceCommand_Visible
		{
			get
			{
				short num = (short)743562053;
				short num2 = num;
				num = (short)251190085;
				switch (num2 == num)
				{
				}
				num = (short)1549402112;
				short num3 = num;
				num = (short)2126708737;
				if (num != 0)
				{
				}
				num = (short)1536688128;
				if (num != 0)
				{
				}
				return this.radErgoSecureTxSelectOnVoiceCommand.Visible;
			}
			set
			{
				short num = (short)1118800148;
				short num2 = num;
				num = (short)1613596948;
				switch (num2 == num)
				{
				}
				num = (short)2145255424;
				short num3 = num;
				num = (short)1094975489;
				if (num != 0)
				{
				}
				num = (short)1321533440;
				if (num != 0)
				{
				}
				this.radErgoSecureTxSelectOnVoiceCommand.Visible = value;
			}
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x06000306 RID: 774 RVA: 0x000315F4 File Offset: 0x0002F7F4
		// (set) Token: 0x06000307 RID: 775 RVA: 0x000316AC File Offset: 0x0002F8AC
		public bool RadErgoSecureTxSelectOnVoiceCommand_Editable
		{
			get
			{
				short num = (short)1958440550;
				short num2 = num;
				num = (short)1003712102;
				switch (num2 == num)
				{
				}
				num = (short)1124859904;
				short num3 = num;
				num = (short)1533476865;
				if (num != 0)
				{
				}
				num = (short)177012736;
				if (num != 0)
				{
				}
				return this.radErgoSecureTxSelectOnVoiceCommand.Editable;
			}
			set
			{
				short num = (short)389480449;
				if (num != 0)
				{
				}
				num = (short)343733843;
				short num2 = num;
				num = (short)918287955;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1622474752;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2101149696;
				if (num != 0)
				{
				}
				this.radErgoSecureTxSelectOnVoiceCommand.Editable = value;
			}
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x06000308 RID: 776 RVA: 0x00031760 File Offset: 0x0002F960
		internal string radErgoSecureTxSelectOnVoiceCommand_UILabel
		{
			get
			{
				short num = (short)1891491134;
				short num2 = num;
				num = (short)1394859326;
				switch (num2 == num)
				{
				}
				num = (short)409665536;
				short num3 = num;
				num = (short)612761600;
				if (num != 0)
				{
				}
				num = (short)1953234945;
				if (num != 0)
				{
				}
				return this.radErgoSecureTxSelectOnVoiceCommand.UIName;
			}
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x06000309 RID: 777 RVA: 0x00031814 File Offset: 0x0002FA14
		// (set) Token: 0x0600030A RID: 778 RVA: 0x000318CC File Offset: 0x0002FACC
		internal bool RadErgoSecureTxSelectOnVoiceCommand_HiddenStatic
		{
			get
			{
				short num = (short)1326612102;
				short num2 = num;
				num = (short)2096463494;
				switch (num2 == num)
				{
				}
				num = (short)2026962944;
				short num3 = num;
				num = (short)254738433;
				if (num != 0)
				{
				}
				num = (short)112721920;
				if (num != 0)
				{
				}
				return this.radErgoSecureTxSelectOnVoiceCommand.HiddenStatic;
			}
			set
			{
				short num = (short)1461092174;
				short num2 = num;
				num = (short)1837727566;
				switch (num2 == num)
				{
				}
				num = (short)530251776;
				short num3 = num;
				num = (short)1720451072;
				if (num != 0)
				{
				}
				num = (short)1950416897;
				if (num != 0)
				{
				}
				this.radErgoSecureTxSelectOnVoiceCommand.HiddenStatic = value;
			}
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x0600030B RID: 779 RVA: 0x00031988 File Offset: 0x0002FB88
		// (set) Token: 0x0600030C RID: 780 RVA: 0x00031A3C File Offset: 0x0002FC3C
		internal bool RadErgoSecureTxSelectOnVoiceCommand_HiddenDynamic
		{
			get
			{
				short num = (short)314254512;
				short num2 = num;
				num = (short)1112876208;
				switch (num2 == num)
				{
				}
				num = (short)1992622080;
				short num3 = num;
				num = (short)544604161;
				if (num != 0)
				{
				}
				num = (short)1230176256;
				if (num != 0)
				{
				}
				return this.radErgoSecureTxSelectOnVoiceCommand.HiddenDynamic;
			}
			set
			{
				short num = (short)1839996111;
				short num2 = num;
				num = (short)12262607;
				switch (num2 == num)
				{
				}
				num = (short)1154220032;
				short num3 = num;
				num = (short)1274150913;
				if (num != 0)
				{
				}
				num = (short)2117861376;
				if (num != 0)
				{
				}
				this.radErgoSecureTxSelectOnVoiceCommand.HiddenDynamic = value;
			}
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x0600030D RID: 781 RVA: 0x00031AF0 File Offset: 0x0002FCF0
		public bool RadErgoSecureTxSelectOnVoiceCommand_HasDiffs
		{
			get
			{
				short num = (short)655260013;
				short num2 = num;
				num = (short)627472749;
				switch (num2 == num)
				{
				}
				num = (short)130351104;
				short num3 = num;
				num = (short)1309736961;
				if (num != 0)
				{
				}
				num = (short)1064828928;
				if (num != 0)
				{
				}
				return this.radErgoSecureTxSelectOnVoiceCommand._HasDiffs;
			}
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x0600030E RID: 782 RVA: 0x00031BA8 File Offset: 0x0002FDA8
		// (set) Token: 0x0600030F RID: 783 RVA: 0x00031C5C File Offset: 0x0002FE5C
		public string RadErgoSecureTxSelectOffVoiceCommandValue
		{
			get
			{
				short num = (short)1644762432;
				short num2 = num;
				num = (short)2048005440;
				switch (num2 == num)
				{
				}
				num = (short)1822162944;
				short num3 = num;
				num = (short)62259201;
				if (num != 0)
				{
				}
				num = (short)1172963328;
				if (num != 0)
				{
				}
				return this.radErgoSecureTxSelectOffVoiceCommand.Value;
			}
			set
			{
				short num = (short)228373735;
				short num2 = num;
				num = (short)2083828967;
				switch (num2 == num)
				{
				}
				num = (short)2111832064;
				short num3 = num;
				num = (short)1986330624;
				if (num != 0)
				{
				}
				num = (short)1332412417;
				if (num != 0)
				{
				}
				this.radErgoSecureTxSelectOffVoiceCommand.Value = value;
			}
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x06000310 RID: 784 RVA: 0x00031D10 File Offset: 0x0002FF10
		public global::AcpBusinessLayer.AcpField<string> RadErgoSecureTxSelectOffVoiceCommand
		{
			get
			{
				short num = (short)2081488897;
				if (num != 0)
				{
				}
				num = (short)1762443047;
				short num2 = num;
				num = (short)110214951;
				switch (num2 == num)
				{
				default:
				{
					num = (short)62849024;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1512701952;
				if (num != 0)
				{
				}
				return this.radErgoSecureTxSelectOffVoiceCommand;
			}
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x06000311 RID: 785 RVA: 0x00031DC4 File Offset: 0x0002FFC4
		// (set) Token: 0x06000312 RID: 786 RVA: 0x00031E78 File Offset: 0x00030078
		public string RadErgoSecureTxSelectOffVoiceCommand_UIValue
		{
			get
			{
				short num = (short)524091393;
				if (num != 0)
				{
				}
				num = (short)367908599;
				short num2 = num;
				num = (short)1486214903;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1260191744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)428474368;
				if (num != 0)
				{
				}
				return this.radErgoSecureTxSelectOffVoiceCommand.Value;
			}
			set
			{
				short num = (short)928120833;
				if (num != 0)
				{
				}
				num = (short)623150169;
				short num2 = num;
				num = (short)393774169;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1010499584;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)207028224;
				if (num != 0)
				{
				}
				this.radErgoSecureTxSelectOffVoiceCommand.Value = value;
			}
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x06000313 RID: 787 RVA: 0x00031F2C File Offset: 0x0003012C
		// (set) Token: 0x06000314 RID: 788 RVA: 0x00031FE0 File Offset: 0x000301E0
		public bool RadErgoSecureTxSelectOffVoiceCommand_Applicable
		{
			get
			{
				short num = (short)1252157635;
				short num2 = num;
				num = (short)1120102595;
				switch (num2 == num)
				{
				}
				num = (short)283377664;
				short num3 = num;
				num = (short)473563137;
				if (num != 0)
				{
				}
				num = (short)1005584384;
				if (num != 0)
				{
				}
				return this.radErgoSecureTxSelectOffVoiceCommand.Applicable;
			}
			set
			{
				short num = (short)365353313;
				short num2 = num;
				num = (short)1949686113;
				switch (num2 == num)
				{
				}
				num = (short)325255168;
				short num3 = num;
				num = (short)1282342913;
				if (num != 0)
				{
				}
				num = (short)568918016;
				if (num != 0)
				{
				}
				this.radErgoSecureTxSelectOffVoiceCommand.Applicable = value;
			}
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x06000315 RID: 789 RVA: 0x00032098 File Offset: 0x00030298
		// (set) Token: 0x06000316 RID: 790 RVA: 0x0003214C File Offset: 0x0003034C
		public bool RadErgoSecureTxSelectOffVoiceCommand_Valid
		{
			get
			{
				short num = (short)417189614;
				short num2 = num;
				num = (short)2125844206;
				switch (num2 == num)
				{
				}
				num = (short)1971847168;
				short num3 = num;
				num = (short)120913921;
				if (num != 0)
				{
				}
				num = (short)808386560;
				if (num != 0)
				{
				}
				return this.radErgoSecureTxSelectOffVoiceCommand.Valid;
			}
			set
			{
				short num = (short)47841258;
				short num2 = num;
				num = (short)2078801898;
				switch (num2 == num)
				{
				}
				num = (short)1001127936;
				short num3 = num;
				num = (short)1575944193;
				if (num != 0)
				{
				}
				num = (short)602275840;
				if (num != 0)
				{
				}
				this.radErgoSecureTxSelectOffVoiceCommand.Valid = value;
			}
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x06000317 RID: 791 RVA: 0x00032204 File Offset: 0x00030404
		// (set) Token: 0x06000318 RID: 792 RVA: 0x000322B8 File Offset: 0x000304B8
		public bool RadErgoSecureTxSelectOffVoiceCommand_Visible
		{
			get
			{
				short num = (short)1342733703;
				short num2 = num;
				num = (short)1406631303;
				switch (num2 == num)
				{
				}
				num = (short)831520768;
				short num3 = num;
				num = (short)1068630017;
				if (num != 0)
				{
				}
				num = (short)1626800128;
				if (num != 0)
				{
				}
				return this.radErgoSecureTxSelectOffVoiceCommand.Visible;
			}
			set
			{
				short num = (short)1853882369;
				if (num != 0)
				{
				}
				num = (short)740342623;
				short num2 = num;
				num = (short)1704770399;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1836974080;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1071251456;
				if (num != 0)
				{
				}
				this.radErgoSecureTxSelectOffVoiceCommand.Visible = value;
			}
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x06000319 RID: 793 RVA: 0x0003236C File Offset: 0x0003056C
		// (set) Token: 0x0600031A RID: 794 RVA: 0x00032424 File Offset: 0x00030624
		public bool RadErgoSecureTxSelectOffVoiceCommand_Editable
		{
			get
			{
				short num = (short)778371073;
				if (num != 0)
				{
				}
				num = (short)1538816084;
				short num2 = num;
				num = (short)1548318804;
				switch (num2 == num)
				{
				default:
				{
					num = (short)250544128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2034761728;
				if (num != 0)
				{
				}
				return this.radErgoSecureTxSelectOffVoiceCommand.Editable;
			}
			set
			{
				short num = (short)1518032704;
				short num2 = num;
				num = (short)1987598144;
				switch (num2 == num)
				{
				}
				num = (short)1089011712;
				short num3 = num;
				num = (short)598212609;
				if (num != 0)
				{
				}
				num = (short)409010176;
				if (num != 0)
				{
				}
				this.radErgoSecureTxSelectOffVoiceCommand.Editable = value;
			}
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x0600031B RID: 795 RVA: 0x000324D8 File Offset: 0x000306D8
		internal string radErgoSecureTxSelectOffVoiceCommand_UILabel
		{
			get
			{
				short num = (short)516152603;
				short num2 = num;
				num = (short)1081793819;
				switch (num2 == num)
				{
				}
				num = (short)721092608;
				short num3 = num;
				num = (short)698613760;
				if (num != 0)
				{
				}
				num = (short)1116602369;
				if (num != 0)
				{
				}
				return this.radErgoSecureTxSelectOffVoiceCommand.UIName;
			}
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x0600031C RID: 796 RVA: 0x0003258C File Offset: 0x0003078C
		// (set) Token: 0x0600031D RID: 797 RVA: 0x00032640 File Offset: 0x00030840
		internal bool RadErgoSecureTxSelectOffVoiceCommand_HiddenStatic
		{
			get
			{
				short num = (short)1107207161;
				short num2 = num;
				num = (short)353084409;
				switch (num2 == num)
				{
				}
				num = (short)946995200;
				short num3 = num;
				num = (short)894894081;
				if (num != 0)
				{
				}
				num = (short)1530724352;
				if (num != 0)
				{
				}
				return this.radErgoSecureTxSelectOffVoiceCommand.HiddenStatic;
			}
			set
			{
				short num = (short)1404633089;
				if (num != 0)
				{
				}
				num = (short)2069040997;
				short num2 = num;
				num = (short)1737101157;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1149501440;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)68091904;
				if (num != 0)
				{
				}
				this.radErgoSecureTxSelectOffVoiceCommand.HiddenStatic = value;
			}
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x0600031E RID: 798 RVA: 0x000326F4 File Offset: 0x000308F4
		// (set) Token: 0x0600031F RID: 799 RVA: 0x000327AC File Offset: 0x000309AC
		internal bool RadErgoSecureTxSelectOffVoiceCommand_HiddenDynamic
		{
			get
			{
				short num = (short)1455779173;
				short num2 = num;
				num = (short)1603890533;
				switch (num2 == num)
				{
				}
				num = (short)935133184;
				short num3 = num;
				num = (short)1948516353;
				if (num != 0)
				{
				}
				num = (short)341311488;
				if (num != 0)
				{
				}
				return this.radErgoSecureTxSelectOffVoiceCommand.HiddenDynamic;
			}
			set
			{
				short num = (short)2121854852;
				short num2 = num;
				num = (short)1186459524;
				switch (num2 == num)
				{
				}
				num = (short)1700200448;
				short num3 = num;
				num = (short)143130625;
				if (num != 0)
				{
				}
				num = (short)856162304;
				if (num != 0)
				{
				}
				this.radErgoSecureTxSelectOffVoiceCommand.HiddenDynamic = value;
			}
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x06000320 RID: 800 RVA: 0x00032860 File Offset: 0x00030A60
		public bool RadErgoSecureTxSelectOffVoiceCommand_HasDiffs
		{
			get
			{
				short num = (short)1836093446;
				short num2 = num;
				num = (short)428707846;
				switch (num2 == num)
				{
				}
				num = (short)977272832;
				short num3 = num;
				num = (short)661585921;
				if (num != 0)
				{
				}
				num = (short)856489984;
				if (num != 0)
				{
				}
				return this.radErgoSecureTxSelectOffVoiceCommand._HasDiffs;
			}
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x06000321 RID: 801 RVA: 0x00032918 File Offset: 0x00030B18
		// (set) Token: 0x06000322 RID: 802 RVA: 0x000329CC File Offset: 0x00030BCC
		public string RadErgoKeyPadControlsLockOnVoiceCommandValue
		{
			get
			{
				short num = (short)601333140;
				short num2 = num;
				num = (short)456039828;
				switch (num2 == num)
				{
				}
				num = (short)538181632;
				short num3 = num;
				num = (short)341180416;
				if (num != 0)
				{
				}
				num = (short)699924481;
				if (num != 0)
				{
				}
				return this.radErgoKeyPadControlsLockOnVoiceCommand.Value;
			}
			set
			{
				short num = (short)68869071;
				short num2 = num;
				num = (short)1988877263;
				switch (num2 == num)
				{
				}
				num = (short)436535296;
				short num3 = num;
				num = (short)2087780352;
				if (num != 0)
				{
				}
				num = (short)954925057;
				if (num != 0)
				{
				}
				this.radErgoKeyPadControlsLockOnVoiceCommand.Value = value;
			}
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x06000323 RID: 803 RVA: 0x00032A84 File Offset: 0x00030C84
		public global::AcpBusinessLayer.AcpField<string> RadErgoKeyPadControlsLockOnVoiceCommand
		{
			get
			{
				short num = (short)681115649;
				if (num != 0)
				{
				}
				num = (short)1220221436;
				short num2 = num;
				num = (short)1544165884;
				switch (num2 == num)
				{
				default:
				{
					num = (short)212926464;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1149239296;
				if (num != 0)
				{
				}
				return this.radErgoKeyPadControlsLockOnVoiceCommand;
			}
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x06000324 RID: 804 RVA: 0x00032B34 File Offset: 0x00030D34
		// (set) Token: 0x06000325 RID: 805 RVA: 0x00032BEC File Offset: 0x00030DEC
		public string RadErgoKeyPadControlsLockOnVoiceCommand_UIValue
		{
			get
			{
				short num = (short)1620770816;
				short num2 = num;
				num = (short)2130968577;
				if (num != 0)
				{
				}
				num = (short)196116534;
				short num3 = num;
				num = (short)872120374;
				switch (num3 == num)
				{
				}
				num = (short)1377042432;
				if (num != 0)
				{
				}
				return this.radErgoKeyPadControlsLockOnVoiceCommand.Value;
			}
			set
			{
				short num = (short)1081147392;
				short num2 = num;
				num = (short)776273921;
				if (num != 0)
				{
				}
				num = (short)709922225;
				short num3 = num;
				num = (short)811044273;
				switch (num3 == num)
				{
				}
				num = (short)2048589824;
				if (num != 0)
				{
				}
				this.radErgoKeyPadControlsLockOnVoiceCommand.Value = value;
			}
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x06000326 RID: 806 RVA: 0x00032CA0 File Offset: 0x00030EA0
		// (set) Token: 0x06000327 RID: 807 RVA: 0x00032D50 File Offset: 0x00030F50
		public bool RadErgoKeyPadControlsLockOnVoiceCommand_Applicable
		{
			get
			{
				short num = (short)1829044224;
				short num2 = num;
				num = (short)1008926721;
				if (num != 0)
				{
				}
				num = (short)1169916212;
				short num3 = num;
				num = (short)105480500;
				switch (num3 == num)
				{
				}
				num = (short)1997537280;
				if (num != 0)
				{
				}
				return this.radErgoKeyPadControlsLockOnVoiceCommand.Applicable;
			}
			set
			{
				short num = (short)1459421184;
				short num2 = num;
				num = (short)1433796609;
				if (num != 0)
				{
				}
				num = (short)2118866010;
				short num3 = num;
				num = (short)1648907354;
				switch (num3 == num)
				{
				}
				num = (short)916389888;
				if (num != 0)
				{
				}
				this.radErgoKeyPadControlsLockOnVoiceCommand.Applicable = value;
			}
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x06000328 RID: 808 RVA: 0x00032E08 File Offset: 0x00031008
		// (set) Token: 0x06000329 RID: 809 RVA: 0x00032EC0 File Offset: 0x000310C0
		public bool RadErgoKeyPadControlsLockOnVoiceCommand_Valid
		{
			get
			{
				short num = (short)1696202752;
				short num2 = num;
				num = (short)1722776744;
				short num3 = num;
				num = (short)174947496;
				switch (num3 == num)
				{
				}
				num = (short)260898816;
				if (num != 0)
				{
				}
				num = (short)1094778881;
				if (num != 0)
				{
				}
				return this.radErgoKeyPadControlsLockOnVoiceCommand.Valid;
			}
			set
			{
				short num = (short)208863232;
				short num2 = num;
				num = (short)907001114;
				short num3 = num;
				num = (short)433175834;
				switch (num3 == num)
				{
				}
				num = (short)724828161;
				if (num != 0)
				{
				}
				num = (short)885653504;
				if (num != 0)
				{
				}
				this.radErgoKeyPadControlsLockOnVoiceCommand.Valid = value;
			}
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x0600032A RID: 810 RVA: 0x00032F78 File Offset: 0x00031178
		// (set) Token: 0x0600032B RID: 811 RVA: 0x0003302C File Offset: 0x0003122C
		public bool RadErgoKeyPadControlsLockOnVoiceCommand_Visible
		{
			get
			{
				short num = (short)132055040;
				short num2 = num;
				num = (short)2016476715;
				short num3 = num;
				num = (short)290127403;
				switch (num3 == num)
				{
				}
				num = (short)1428553729;
				if (num != 0)
				{
				}
				num = (short)2000486400;
				if (num != 0)
				{
				}
				return this.radErgoKeyPadControlsLockOnVoiceCommand.Visible;
			}
			set
			{
				short num = (short)1461780480;
				short num2 = num;
				num = (short)880867134;
				short num3 = num;
				num = (short)1150154558;
				switch (num3 == num)
				{
				}
				num = (short)70582273;
				if (num != 0)
				{
				}
				num = (short)494927872;
				if (num != 0)
				{
				}
				this.radErgoKeyPadControlsLockOnVoiceCommand.Visible = value;
			}
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x0600032C RID: 812 RVA: 0x000330E0 File Offset: 0x000312E0
		// (set) Token: 0x0600032D RID: 813 RVA: 0x00033198 File Offset: 0x00031398
		public bool RadErgoKeyPadControlsLockOnVoiceCommand_Editable
		{
			get
			{
				short num = (short)2105081856;
				short num2 = num;
				num = (short)2015516904;
				short num3 = num;
				num = (short)1105549544;
				switch (num3 == num)
				{
				}
				num = (short)1390804993;
				if (num != 0)
				{
				}
				num = (short)961544192;
				if (num != 0)
				{
				}
				return this.radErgoKeyPadControlsLockOnVoiceCommand.Editable;
			}
			set
			{
				short num = (short)2079588352;
				short num2 = num;
				num = (short)1126760449;
				if (num != 0)
				{
				}
				num = (short)1472609412;
				short num3 = num;
				num = (short)2081700996;
				switch (num3 == num)
				{
				}
				num = (short)1393360896;
				if (num != 0)
				{
				}
				this.radErgoKeyPadControlsLockOnVoiceCommand.Editable = value;
			}
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x0600032E RID: 814 RVA: 0x0003324C File Offset: 0x0003144C
		internal string radErgoKeyPadControlsLockOnVoiceCommand_UILabel
		{
			get
			{
				short num = (short)1822621696;
				short num2 = num;
				num = (short)1837527944;
				short num3 = num;
				num = (short)1979020168;
				switch (num3 == num)
				{
				}
				num = (short)1890123777;
				if (num != 0)
				{
				}
				num = (short)1474691072;
				if (num != 0)
				{
				}
				return this.radErgoKeyPadControlsLockOnVoiceCommand.UIName;
			}
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x0600032F RID: 815 RVA: 0x00033304 File Offset: 0x00031504
		// (set) Token: 0x06000330 RID: 816 RVA: 0x000333B8 File Offset: 0x000315B8
		internal bool RadErgoKeyPadControlsLockOnVoiceCommand_HiddenStatic
		{
			get
			{
				short num = (short)1609433088;
				short num2 = num;
				num = (short)1015461399;
				short num3 = num;
				num = (short)2097919511;
				switch (num3 == num)
				{
				}
				num = (short)635633665;
				if (num != 0)
				{
				}
				num = (short)907411456;
				if (num != 0)
				{
				}
				return this.radErgoKeyPadControlsLockOnVoiceCommand.HiddenStatic;
			}
			set
			{
				short num = (short)123469824;
				short num2 = num;
				num = (short)1598671350;
				short num3 = num;
				num = (short)1250281974;
				switch (num3 == num)
				{
				}
				num = (short)177340417;
				if (num != 0)
				{
				}
				num = (short)582680576;
				if (num != 0)
				{
				}
				this.radErgoKeyPadControlsLockOnVoiceCommand.HiddenStatic = value;
			}
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x06000331 RID: 817 RVA: 0x0003346C File Offset: 0x0003166C
		// (set) Token: 0x06000332 RID: 818 RVA: 0x00033520 File Offset: 0x00031720
		internal bool RadErgoKeyPadControlsLockOnVoiceCommand_HiddenDynamic
		{
			get
			{
				short num = (short)793182208;
				short num2 = num;
				num = (short)269290858;
				short num3 = num;
				num = (short)1462766954;
				switch (num3 == num)
				{
				}
				num = (short)845217793;
				if (num != 0)
				{
				}
				num = (short)704446464;
				if (num != 0)
				{
				}
				return this.radErgoKeyPadControlsLockOnVoiceCommand.HiddenDynamic;
			}
			set
			{
				short num = (short)119209984;
				short num2 = num;
				num = (short)1918271502;
				short num3 = num;
				num = (short)2016575502;
				switch (num3 == num)
				{
				}
				num = (short)483393537;
				if (num != 0)
				{
				}
				num = (short)1636040704;
				if (num != 0)
				{
				}
				this.radErgoKeyPadControlsLockOnVoiceCommand.HiddenDynamic = value;
			}
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x06000333 RID: 819 RVA: 0x000335D4 File Offset: 0x000317D4
		public bool RadErgoKeyPadControlsLockOnVoiceCommand_HasDiffs
		{
			get
			{
				short num = (short)668139520;
				short num2 = num;
				num = (short)386625977;
				short num3 = num;
				num = (short)890859961;
				switch (num3 == num)
				{
				}
				num = (short)1248526336;
				if (num != 0)
				{
				}
				num = (short)15335425;
				if (num != 0)
				{
				}
				return this.radErgoKeyPadControlsLockOnVoiceCommand._HasDiffs;
			}
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x06000334 RID: 820 RVA: 0x00033688 File Offset: 0x00031888
		// (set) Token: 0x06000335 RID: 821 RVA: 0x0003373C File Offset: 0x0003193C
		public string RadErgoKeyPadControlsLockOffVoiceCommandValue
		{
			get
			{
				short num = (short)1272512512;
				short num2 = num;
				num = (short)1886383205;
				short num3 = num;
				num = (short)302443621;
				switch (num3 == num)
				{
				}
				num = (short)391905280;
				if (num != 0)
				{
				}
				num = (short)1903820801;
				if (num != 0)
				{
				}
				return this.radErgoKeyPadControlsLockOffVoiceCommand.Value;
			}
			set
			{
				short num = (short)336920576;
				short num2 = num;
				num = (short)1147291646;
				short num3 = num;
				num = (short)1916225534;
				switch (num3 == num)
				{
				}
				num = (short)1668874241;
				if (num != 0)
				{
				}
				num = (short)481427456;
				if (num != 0)
				{
				}
				this.radErgoKeyPadControlsLockOffVoiceCommand.Value = value;
			}
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x06000336 RID: 822 RVA: 0x000337F0 File Offset: 0x000319F0
		public global::AcpBusinessLayer.AcpField<string> RadErgoKeyPadControlsLockOffVoiceCommand
		{
			get
			{
				short num = (short)726466560;
				short num2 = num;
				num = (short)678325235;
				short num3 = num;
				num = (short)402811891;
				switch (num3 == num)
				{
				}
				num = (short)1412104193;
				if (num != 0)
				{
				}
				num = (short)824836096;
				if (num != 0)
				{
				}
				return this.radErgoKeyPadControlsLockOffVoiceCommand;
			}
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x06000337 RID: 823 RVA: 0x000338A0 File Offset: 0x00031AA0
		// (set) Token: 0x06000338 RID: 824 RVA: 0x00033958 File Offset: 0x00031B58
		public string RadErgoKeyPadControlsLockOffVoiceCommand_UIValue
		{
			get
			{
				short num = (short)286326784;
				short num2 = num;
				num = (short)1690380622;
				short num3 = num;
				num = (short)2697550;
				switch (num3 == num)
				{
				}
				num = (short)585957377;
				if (num != 0)
				{
				}
				num = (short)1072824320;
				if (num != 0)
				{
				}
				return this.radErgoKeyPadControlsLockOffVoiceCommand.Value;
			}
			set
			{
				short num = (short)1934753792;
				short num2 = num;
				num = (short)2109242779;
				short num3 = num;
				num = (short)769949083;
				switch (num3 == num)
				{
				}
				num = (short)1567227904;
				if (num != 0)
				{
				}
				num = (short)1874853889;
				if (num != 0)
				{
				}
				this.radErgoKeyPadControlsLockOffVoiceCommand.Value = value;
			}
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x06000339 RID: 825 RVA: 0x00033A10 File Offset: 0x00031C10
		// (set) Token: 0x0600033A RID: 826 RVA: 0x00033AC4 File Offset: 0x00031CC4
		public bool RadErgoKeyPadControlsLockOffVoiceCommand_Applicable
		{
			get
			{
				short num = (short)165412864;
				short num2 = num;
				num = (short)373398710;
				short num3 = num;
				num = (short)810720438;
				switch (num3 == num)
				{
				}
				num = (short)1285685249;
				if (num != 0)
				{
				}
				num = (short)1331953664;
				if (num != 0)
				{
				}
				return this.radErgoKeyPadControlsLockOffVoiceCommand.Applicable;
			}
			set
			{
				short num = (short)1788477440;
				short num2 = num;
				num = (short)261226497;
				if (num != 0)
				{
				}
				num = (short)754928751;
				short num3 = num;
				num = (short)225791087;
				switch (num3 == num)
				{
				}
				num = (short)311951360;
				if (num != 0)
				{
				}
				this.radErgoKeyPadControlsLockOffVoiceCommand.Applicable = value;
			}
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x0600033B RID: 827 RVA: 0x00033B78 File Offset: 0x00031D78
		// (set) Token: 0x0600033C RID: 828 RVA: 0x00033C2C File Offset: 0x00031E2C
		public bool RadErgoKeyPadControlsLockOffVoiceCommand_Valid
		{
			get
			{
				short num = (short)1711276032;
				short num2 = num;
				num = (short)550003440;
				short num3 = num;
				num = (short)1590780656;
				switch (num3 == num)
				{
				}
				num = (short)53673985;
				if (num != 0)
				{
				}
				num = (short)861470720;
				if (num != 0)
				{
				}
				return this.radErgoKeyPadControlsLockOffVoiceCommand.Valid;
			}
			set
			{
				short num = (short)829489152;
				short num2 = num;
				num = (short)1701261779;
				short num3 = num;
				num = (short)383726035;
				switch (num3 == num)
				{
				}
				num = (short)2105606145;
				if (num != 0)
				{
				}
				num = (short)1637744640;
				if (num != 0)
				{
				}
				this.radErgoKeyPadControlsLockOffVoiceCommand.Valid = value;
			}
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x0600033D RID: 829 RVA: 0x00033CE4 File Offset: 0x00031EE4
		// (set) Token: 0x0600033E RID: 830 RVA: 0x00033D98 File Offset: 0x00031F98
		public bool RadErgoKeyPadControlsLockOffVoiceCommand_Visible
		{
			get
			{
				short num = (short)1241186304;
				short num2 = num;
				num = (short)689279307;
				short num3 = num;
				num = (short)288723275;
				switch (num3 == num)
				{
				}
				num = (short)607911937;
				if (num != 0)
				{
				}
				num = (short)291307520;
				if (num != 0)
				{
				}
				return this.radErgoKeyPadControlsLockOffVoiceCommand.Visible;
			}
			set
			{
				short num = (short)231276544;
				short num2 = num;
				num = (short)86331994;
				short num3 = num;
				num = (short)2109821530;
				switch (num3 == num)
				{
				}
				num = (short)84738049;
				if (num != 0)
				{
				}
				num = (short)305922048;
				if (num != 0)
				{
				}
				this.radErgoKeyPadControlsLockOffVoiceCommand.Visible = value;
			}
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x0600033F RID: 831 RVA: 0x00033E50 File Offset: 0x00032050
		// (set) Token: 0x06000340 RID: 832 RVA: 0x00033F04 File Offset: 0x00032104
		public bool RadErgoKeyPadControlsLockOffVoiceCommand_Editable
		{
			get
			{
				short num = (short)331415552;
				short num2 = num;
				num = (short)74632665;
				short num3 = num;
				num = (short)1604439513;
				switch (num3 == num)
				{
				}
				num = (short)1080492032;
				if (num != 0)
				{
				}
				num = (short)1584988161;
				if (num != 0)
				{
				}
				return this.radErgoKeyPadControlsLockOffVoiceCommand.Editable;
			}
			set
			{
				short num = (short)1357250560;
				short num2 = num;
				num = (short)1904541697;
				if (num != 0)
				{
				}
				num = (short)1817841952;
				short num3 = num;
				num = (short)1706561824;
				switch (num3 == num)
				{
				}
				num = (short)87752704;
				if (num != 0)
				{
				}
				this.radErgoKeyPadControlsLockOffVoiceCommand.Editable = value;
			}
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x06000341 RID: 833 RVA: 0x00033FBC File Offset: 0x000321BC
		internal string radErgoKeyPadControlsLockOffVoiceCommand_UILabel
		{
			get
			{
				short num = (short)1951203328;
				short num2 = num;
				num = (short)80515018;
				short num3 = num;
				num = (short)511741898;
				switch (num3 == num)
				{
				}
				num = (short)1714225153;
				if (num != 0)
				{
				}
				num = (short)255262720;
				if (num != 0)
				{
				}
				return this.radErgoKeyPadControlsLockOffVoiceCommand.UIName;
			}
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x06000342 RID: 834 RVA: 0x00034070 File Offset: 0x00032270
		// (set) Token: 0x06000343 RID: 835 RVA: 0x00034124 File Offset: 0x00032324
		internal bool RadErgoKeyPadControlsLockOffVoiceCommand_HiddenStatic
		{
			get
			{
				short num = (short)18546688;
				short num2 = num;
				num = (short)65798145;
				if (num != 0)
				{
				}
				num = (short)269915306;
				short num3 = num;
				num = (short)1259574442;
				switch (num3 == num)
				{
				}
				num = (short)1308557312;
				if (num != 0)
				{
				}
				return this.radErgoKeyPadControlsLockOffVoiceCommand.HiddenStatic;
			}
			set
			{
				short num = (short)546832384;
				short num2 = num;
				num = (short)147947323;
				short num3 = num;
				num = (short)1157857083;
				switch (num3 == num)
				{
				}
				num = (short)878444545;
				if (num != 0)
				{
				}
				num = (short)686489600;
				if (num != 0)
				{
				}
				this.radErgoKeyPadControlsLockOffVoiceCommand.HiddenStatic = value;
			}
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x06000344 RID: 836 RVA: 0x000341DC File Offset: 0x000323DC
		// (set) Token: 0x06000345 RID: 837 RVA: 0x00034290 File Offset: 0x00032490
		internal bool RadErgoKeyPadControlsLockOffVoiceCommand_HiddenDynamic
		{
			get
			{
				short num = (short)1747255296;
				short num2 = num;
				num = (short)2126683549;
				short num3 = num;
				num = (short)1561566621;
				switch (num3 == num)
				{
				}
				num = (short)1314455553;
				if (num != 0)
				{
				}
				num = (short)152502272;
				if (num != 0)
				{
				}
				return this.radErgoKeyPadControlsLockOffVoiceCommand.HiddenDynamic;
			}
			set
			{
				short num = (short)2014511104;
				short num2 = num;
				num = (short)1535114051;
				short num3 = num;
				num = (short)302644035;
				switch (num3 == num)
				{
				}
				num = (short)2025193473;
				if (num != 0)
				{
				}
				num = (short)503709696;
				if (num != 0)
				{
				}
				this.radErgoKeyPadControlsLockOffVoiceCommand.HiddenDynamic = value;
			}
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x06000346 RID: 838 RVA: 0x00034348 File Offset: 0x00032548
		public bool RadErgoKeyPadControlsLockOffVoiceCommand_HasDiffs
		{
			get
			{
				short num = (short)1975189504;
				short num2 = num;
				num = (short)468071600;
				short num3 = num;
				num = (short)1335964848;
				switch (num3 == num)
				{
				}
				num = (short)1711865856;
				if (num != 0)
				{
				}
				num = (short)50462721;
				if (num != 0)
				{
				}
				return this.radErgoKeyPadControlsLockOffVoiceCommand._HasDiffs;
			}
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x06000347 RID: 839 RVA: 0x000343FC File Offset: 0x000325FC
		// (set) Token: 0x06000348 RID: 840 RVA: 0x000344B4 File Offset: 0x000326B4
		public string RadErgoMultiFuntionalButtonPrimaryModeCommandValue
		{
			get
			{
				short num = (short)1716125696;
				short num2 = num;
				num = (short)743243777;
				if (num != 0)
				{
				}
				num = (short)1944531318;
				short num3 = num;
				num = (short)1055404406;
				switch (num3 == num)
				{
				}
				num = (short)2122579968;
				if (num != 0)
				{
				}
				return this.radErgoMultiFuntionalButtonPrimaryModeCommand.Value;
			}
			set
			{
				short num = (short)1281884160;
				short num2 = num;
				num = (short)1003880449;
				if (num != 0)
				{
				}
				num = (short)712005059;
				short num3 = num;
				num = (short)270554563;
				switch (num3 == num)
				{
				}
				num = (short)423624704;
				if (num != 0)
				{
				}
				this.radErgoMultiFuntionalButtonPrimaryModeCommand.Value = value;
			}
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x06000349 RID: 841 RVA: 0x00034568 File Offset: 0x00032768
		public global::AcpBusinessLayer.AcpField<string> RadErgoMultiFuntionalButtonPrimaryModeCommand
		{
			get
			{
				short num = (short)1936850944;
				short num2 = num;
				num = (short)713162753;
				if (num != 0)
				{
				}
				num = (short)2057187326;
				short num3 = num;
				num = (short)1738420222;
				switch (num3 == num)
				{
				}
				num = (short)251068416;
				if (num != 0)
				{
				}
				return this.radErgoMultiFuntionalButtonPrimaryModeCommand;
			}
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x0600034A RID: 842 RVA: 0x00034618 File Offset: 0x00032818
		// (set) Token: 0x0600034B RID: 843 RVA: 0x000346D0 File Offset: 0x000328D0
		public string RadErgoMultiFuntionalButtonPrimaryModeCommand_UIValue
		{
			get
			{
				short num = (short)913113088;
				short num2 = num;
				num = (short)2014833691;
				short num3 = num;
				num = (short)1664150555;
				switch (num3 == num)
				{
				}
				num = (short)355926017;
				if (num != 0)
				{
				}
				num = (short)262144000;
				if (num != 0)
				{
				}
				return this.radErgoMultiFuntionalButtonPrimaryModeCommand.Value;
			}
			set
			{
				short num = (short)649986048;
				short num2 = num;
				num = (short)157359175;
				short num3 = num;
				num = (short)1258167367;
				switch (num3 == num)
				{
				}
				num = (short)195100672;
				if (num != 0)
				{
				}
				num = (short)1064108033;
				if (num != 0)
				{
				}
				this.radErgoMultiFuntionalButtonPrimaryModeCommand.Value = value;
			}
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x0600034C RID: 844 RVA: 0x00034784 File Offset: 0x00032984
		// (set) Token: 0x0600034D RID: 845 RVA: 0x00034838 File Offset: 0x00032A38
		public bool RadErgoMultiFuntionalButtonPrimaryModeCommand_Applicable
		{
			get
			{
				short num = (short)419692544;
				short num2 = num;
				num = (short)282251458;
				short num3 = num;
				num = (short)184799426;
				switch (num3 == num)
				{
				}
				num = (short)1586495489;
				if (num != 0)
				{
				}
				num = (short)223346688;
				if (num != 0)
				{
				}
				return this.radErgoMultiFuntionalButtonPrimaryModeCommand.Applicable;
			}
			set
			{
				short num = (short)816709632;
				short num2 = num;
				num = (short)1137051819;
				short num3 = num;
				num = (short)426969259;
				switch (num3 == num)
				{
				}
				num = (short)1765277696;
				if (num != 0)
				{
				}
				num = (short)984350721;
				if (num != 0)
				{
				}
				this.radErgoMultiFuntionalButtonPrimaryModeCommand.Applicable = value;
			}
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x0600034E RID: 846 RVA: 0x000348F0 File Offset: 0x00032AF0
		// (set) Token: 0x0600034F RID: 847 RVA: 0x000349A4 File Offset: 0x00032BA4
		public bool RadErgoMultiFuntionalButtonPrimaryModeCommand_Valid
		{
			get
			{
				short num = (short)415694848;
				short num2 = num;
				num = (short)1074078878;
				short num3 = num;
				num = (short)265364638;
				switch (num3 == num)
				{
				}
				num = (short)1590099969;
				if (num != 0)
				{
				}
				num = (short)126025728;
				if (num != 0)
				{
				}
				return this.radErgoMultiFuntionalButtonPrimaryModeCommand.Valid;
			}
			set
			{
				short num = (short)428277760;
				short num2 = num;
				num = (short)190447617;
				if (num != 0)
				{
				}
				num = (short)602242779;
				short num3 = num;
				num = (short)1377140443;
				switch (num3 == num)
				{
				}
				num = (short)1012400128;
				if (num != 0)
				{
				}
				this.radErgoMultiFuntionalButtonPrimaryModeCommand.Valid = value;
			}
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x06000350 RID: 848 RVA: 0x00034A5C File Offset: 0x00032C5C
		// (set) Token: 0x06000351 RID: 849 RVA: 0x00034B0C File Offset: 0x00032D0C
		public bool RadErgoMultiFuntionalButtonPrimaryModeCommand_Visible
		{
			get
			{
				short num = (short)1625161728;
				short num2 = num;
				num = (short)403047627;
				short num3 = num;
				num = (short)481232075;
				switch (num3 == num)
				{
				}
				num = (short)835387392;
				if (num != 0)
				{
				}
				num = (short)115015681;
				if (num != 0)
				{
				}
				return this.radErgoMultiFuntionalButtonPrimaryModeCommand.Visible;
			}
			set
			{
				short num = (short)1138425856;
				short num2 = num;
				num = (short)1817575425;
				if (num != 0)
				{
				}
				num = (short)638886185;
				short num3 = num;
				num = (short)1372234025;
				switch (num3 == num)
				{
				}
				num = (short)1366032384;
				if (num != 0)
				{
				}
				this.radErgoMultiFuntionalButtonPrimaryModeCommand.Visible = value;
			}
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x06000352 RID: 850 RVA: 0x00034BC4 File Offset: 0x00032DC4
		// (set) Token: 0x06000353 RID: 851 RVA: 0x00034C7C File Offset: 0x00032E7C
		public bool RadErgoMultiFuntionalButtonPrimaryModeCommand_Editable
		{
			get
			{
				short num = (short)1843396608;
				short num2 = num;
				num = (short)76223268;
				short num3 = num;
				num = (short)801510180;
				switch (num3 == num)
				{
				}
				num = (short)1650196481;
				if (num != 0)
				{
				}
				num = (short)667549696;
				if (num != 0)
				{
				}
				return this.radErgoMultiFuntionalButtonPrimaryModeCommand.Editable;
			}
			set
			{
				short num = (short)515309568;
				short num2 = num;
				num = (short)281319054;
				short num3 = num;
				num = (short)1187878542;
				switch (num3 == num)
				{
				}
				num = (short)1085538305;
				if (num != 0)
				{
				}
				num = (short)1662713856;
				if (num != 0)
				{
				}
				this.radErgoMultiFuntionalButtonPrimaryModeCommand.Editable = value;
			}
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x06000354 RID: 852 RVA: 0x00034D30 File Offset: 0x00032F30
		internal string radErgoMultiFuntionalButtonPrimaryModeCommand_UILabel
		{
			get
			{
				short num = (short)907710295;
				short num2 = num;
				num = (short)263229271;
				switch (num2 == num)
				{
				}
				num = (short)311885824;
				if (num != 0)
				{
				}
				num = (short)1396768769;
				if (num != 0)
				{
				}
				num = (short)1065418752;
				short num3 = num;
				return this.radErgoMultiFuntionalButtonPrimaryModeCommand.UIName;
			}
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x06000355 RID: 853 RVA: 0x00034DE8 File Offset: 0x00032FE8
		// (set) Token: 0x06000356 RID: 854 RVA: 0x00034E9C File Offset: 0x0003309C
		internal bool RadErgoMultiFuntionalButtonPrimaryModeCommand_HiddenStatic
		{
			get
			{
				short num = (short)1037237164;
				short num2 = num;
				num = (short)2005662636;
				switch (num2 == num)
				{
				}
				num = (short)1685979137;
				if (num != 0)
				{
				}
				num = (short)483590144;
				if (num != 0)
				{
				}
				num = (short)365494272;
				short num3 = num;
				return this.radErgoMultiFuntionalButtonPrimaryModeCommand.HiddenStatic;
			}
			set
			{
				short num = (short)457638686;
				short num2 = num;
				num = (short)1836909342;
				switch (num2 == num)
				{
				}
				num = (short)681246721;
				if (num != 0)
				{
				}
				num = (short)1756299264;
				if (num != 0)
				{
				}
				num = (short)691863552;
				short num3 = num;
				this.radErgoMultiFuntionalButtonPrimaryModeCommand.HiddenStatic = value;
			}
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x06000357 RID: 855 RVA: 0x00034F50 File Offset: 0x00033150
		// (set) Token: 0x06000358 RID: 856 RVA: 0x00035004 File Offset: 0x00033204
		internal bool RadErgoMultiFuntionalButtonPrimaryModeCommand_HiddenDynamic
		{
			get
			{
				short num = (short)574310408;
				short num2 = num;
				num = (short)620513288;
				switch (num2 == num)
				{
				}
				num = (short)1759969280;
				if (num != 0)
				{
				}
				num = (short)1482031105;
				if (num != 0)
				{
				}
				num = (short)264896512;
				short num3 = num;
				return this.radErgoMultiFuntionalButtonPrimaryModeCommand.HiddenDynamic;
			}
			set
			{
				short num = (short)1955213728;
				short num2 = num;
				num = (short)1448685984;
				switch (num2 == num)
				{
				}
				num = (short)99155969;
				if (num != 0)
				{
				}
				num = (short)1451032576;
				if (num != 0)
				{
				}
				num = (short)565248000;
				short num3 = num;
				this.radErgoMultiFuntionalButtonPrimaryModeCommand.HiddenDynamic = value;
			}
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x06000359 RID: 857 RVA: 0x000350BC File Offset: 0x000332BC
		public bool RadErgoMultiFuntionalButtonPrimaryModeCommand_HasDiffs
		{
			get
			{
				short num = (short)1751560832;
				short num2 = num;
				num = (short)1500361344;
				switch (num2 == num)
				{
				}
				num = (short)579862529;
				if (num != 0)
				{
				}
				num = (short)751435776;
				if (num != 0)
				{
				}
				num = (short)841482240;
				short num3 = num;
				return this.radErgoMultiFuntionalButtonPrimaryModeCommand._HasDiffs;
			}
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x0600035A RID: 858 RVA: 0x00035170 File Offset: 0x00033370
		// (set) Token: 0x0600035B RID: 859 RVA: 0x00035224 File Offset: 0x00033424
		public string RadErgoMultiFuntionalButtonSecondaryModeCommandValue
		{
			get
			{
				short num = (short)2109316192;
				short num2 = num;
				num = (short)1099013216;
				switch (num2 == num)
				{
				}
				num = (short)1581711361;
				if (num != 0)
				{
				}
				num = (short)1060962304;
				if (num != 0)
				{
				}
				num = (short)1808859136;
				short num3 = num;
				return this.radErgoMultiFuntionalButtonSecondaryModeCommand.Value;
			}
			set
			{
				short num = (short)629334912;
				short num2 = num;
				num = (short)828826496;
				switch (num2 == num)
				{
				}
				num = (short)1305935873;
				if (num != 0)
				{
				}
				num = (short)629407744;
				if (num != 0)
				{
				}
				num = (short)1928069120;
				short num3 = num;
				this.radErgoMultiFuntionalButtonSecondaryModeCommand.Value = value;
			}
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x0600035C RID: 860 RVA: 0x000352D8 File Offset: 0x000334D8
		public global::AcpBusinessLayer.AcpField<string> RadErgoMultiFuntionalButtonSecondaryModeCommand
		{
			get
			{
				short num = (short)2109603841;
				if (num != 0)
				{
				}
				num = (short)1800225090;
				short num2 = num;
				num = (short)262029634;
				switch (num2 == num)
				{
				}
				num = (short)1263140864;
				if (num != 0)
				{
				}
				num = (short)706674688;
				short num3 = num;
				return this.radErgoMultiFuntionalButtonSecondaryModeCommand;
			}
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x0600035D RID: 861 RVA: 0x00035388 File Offset: 0x00033588
		// (set) Token: 0x0600035E RID: 862 RVA: 0x00035440 File Offset: 0x00033640
		public string RadErgoMultiFuntionalButtonSecondaryModeCommand_UIValue
		{
			get
			{
				short num = (short)1827413571;
				short num2 = num;
				num = (short)630529603;
				switch (num2 == num)
				{
				}
				num = (short)1557200896;
				if (num != 0)
				{
				}
				num = (short)175702017;
				if (num != 0)
				{
				}
				num = (short)106692608;
				short num3 = num;
				return this.radErgoMultiFuntionalButtonSecondaryModeCommand.Value;
			}
			set
			{
				short num = (short)182133382;
				short num2 = num;
				num = (short)866919046;
				switch (num2 == num)
				{
				}
				num = (short)1631584257;
				if (num != 0)
				{
				}
				num = (short)103350272;
				if (num != 0)
				{
				}
				num = (short)1111359488;
				short num3 = num;
				this.radErgoMultiFuntionalButtonSecondaryModeCommand.Value = value;
			}
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x0600035F RID: 863 RVA: 0x000354F4 File Offset: 0x000336F4
		// (set) Token: 0x06000360 RID: 864 RVA: 0x000355AC File Offset: 0x000337AC
		public bool RadErgoMultiFuntionalButtonSecondaryModeCommand_Applicable
		{
			get
			{
				short num = (short)1391127389;
				short num2 = num;
				num = (short)16051037;
				switch (num2 == num)
				{
				}
				num = (short)959643649;
				if (num != 0)
				{
				}
				num = (short)1212350464;
				if (num != 0)
				{
				}
				num = (short)18808832;
				short num3 = num;
				return this.radErgoMultiFuntionalButtonSecondaryModeCommand.Applicable;
			}
			set
			{
				short num = (short)849308352;
				short num2 = num;
				num = (short)197552832;
				switch (num2 == num)
				{
				}
				num = (short)2133524480;
				if (num != 0)
				{
				}
				num = (short)1384316929;
				if (num != 0)
				{
				}
				num = (short)214433792;
				short num3 = num;
				this.radErgoMultiFuntionalButtonSecondaryModeCommand.Applicable = value;
			}
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x06000361 RID: 865 RVA: 0x00035664 File Offset: 0x00033864
		// (set) Token: 0x06000362 RID: 866 RVA: 0x0003571C File Offset: 0x0003391C
		public bool RadErgoMultiFuntionalButtonSecondaryModeCommand_Valid
		{
			get
			{
				short num = (short)741617746;
				short num2 = num;
				num = (short)962015314;
				switch (num2 == num)
				{
				}
				num = (short)1868955649;
				if (num != 0)
				{
				}
				num = (short)1792212992;
				if (num != 0)
				{
				}
				num = (short)1723924480;
				short num3 = num;
				return this.radErgoMultiFuntionalButtonSecondaryModeCommand.Valid;
			}
			set
			{
				short num = (short)334554654;
				short num2 = num;
				num = (short)1045620254;
				switch (num2 == num)
				{
				}
				num = (short)1491992577;
				if (num != 0)
				{
				}
				num = (short)1068761088;
				if (num != 0)
				{
				}
				num = (short)1576402944;
				short num3 = num;
				this.radErgoMultiFuntionalButtonSecondaryModeCommand.Valid = value;
			}
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x06000363 RID: 867 RVA: 0x000357D0 File Offset: 0x000339D0
		// (set) Token: 0x06000364 RID: 868 RVA: 0x00035884 File Offset: 0x00033A84
		public bool RadErgoMultiFuntionalButtonSecondaryModeCommand_Visible
		{
			get
			{
				short num = (short)1323878686;
				short num2 = num;
				num = (short)1942538526;
				switch (num2 == num)
				{
				}
				num = (short)1736245249;
				if (num != 0)
				{
				}
				num = (short)930217984;
				if (num != 0)
				{
				}
				num = (short)1829437440;
				short num3 = num;
				return this.radErgoMultiFuntionalButtonSecondaryModeCommand.Visible;
			}
			set
			{
				short num = (short)1009428442;
				short num2 = num;
				num = (short)136292314;
				switch (num2 == num)
				{
				}
				num = (short)238747648;
				if (num != 0)
				{
				}
				num = (short)312279041;
				if (num != 0)
				{
				}
				num = (short)1290862592;
				short num3 = num;
				this.radErgoMultiFuntionalButtonSecondaryModeCommand.Visible = value;
			}
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x06000365 RID: 869 RVA: 0x00035938 File Offset: 0x00033B38
		// (set) Token: 0x06000366 RID: 870 RVA: 0x000359F0 File Offset: 0x00033BF0
		public bool RadErgoMultiFuntionalButtonSecondaryModeCommand_Editable
		{
			get
			{
				short num = (short)825095245;
				short num2 = num;
				num = (short)1726673997;
				switch (num2 == num)
				{
				}
				num = (short)1154023424;
				if (num != 0)
				{
				}
				num = (short)172752897;
				if (num != 0)
				{
				}
				num = (short)770244608;
				short num3 = num;
				return this.radErgoMultiFuntionalButtonSecondaryModeCommand.Editable;
			}
			set
			{
				short num = (short)920918137;
				short num2 = num;
				num = (short)1052973177;
				switch (num2 == num)
				{
				}
				num = (short)1720713216;
				if (num != 0)
				{
				}
				num = (short)1221722113;
				if (num != 0)
				{
				}
				num = (short)1118109696;
				short num3 = num;
				this.radErgoMultiFuntionalButtonSecondaryModeCommand.Editable = value;
			}
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x06000367 RID: 871 RVA: 0x00035AA8 File Offset: 0x00033CA8
		internal string radErgoMultiFuntionalButtonSecondaryModeCommand_UILabel
		{
			get
			{
				short num = (short)366988978;
				short num2 = num;
				num = (short)126537394;
				switch (num2 == num)
				{
				}
				num = (short)635174913;
				if (num != 0)
				{
				}
				num = (short)14286848;
				if (num != 0)
				{
				}
				num = (short)1355153408;
				short num3 = num;
				return this.radErgoMultiFuntionalButtonSecondaryModeCommand.UIName;
			}
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x06000368 RID: 872 RVA: 0x00035B5C File Offset: 0x00033D5C
		// (set) Token: 0x06000369 RID: 873 RVA: 0x00035C10 File Offset: 0x00033E10
		internal bool RadErgoMultiFuntionalButtonSecondaryModeCommand_HiddenStatic
		{
			get
			{
				short num = (short)1277679802;
				short num2 = num;
				num = (short)846911674;
				switch (num2 == num)
				{
				}
				num = (short)1299513345;
				if (num != 0)
				{
				}
				num = (short)2007826432;
				if (num != 0)
				{
				}
				num = (short)1496121344;
				short num3 = num;
				return this.radErgoMultiFuntionalButtonSecondaryModeCommand.HiddenStatic;
			}
			set
			{
				short num = (short)384499713;
				if (num != 0)
				{
				}
				num = (short)1452494488;
				short num2 = num;
				num = (short)30822040;
				switch (num2 == num)
				{
				}
				num = (short)1100218368;
				if (num != 0)
				{
				}
				num = (short)284426240;
				short num3 = num;
				this.radErgoMultiFuntionalButtonSecondaryModeCommand.HiddenStatic = value;
			}
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x0600036A RID: 874 RVA: 0x00035CC4 File Offset: 0x00033EC4
		// (set) Token: 0x0600036B RID: 875 RVA: 0x00035D78 File Offset: 0x00033F78
		internal bool RadErgoMultiFuntionalButtonSecondaryModeCommand_HiddenDynamic
		{
			get
			{
				short num = (short)866917365;
				short num2 = num;
				num = (short)540679157;
				switch (num2 == num)
				{
				}
				num = (short)1417609216;
				if (num != 0)
				{
				}
				num = (short)2098200577;
				if (num != 0)
				{
				}
				num = (short)1712979968;
				short num3 = num;
				return this.radErgoMultiFuntionalButtonSecondaryModeCommand.HiddenDynamic;
			}
			set
			{
				short num = (short)1746648166;
				short num2 = num;
				num = (short)272809062;
				switch (num2 == num)
				{
				}
				num = (short)1442054144;
				if (num != 0)
				{
				}
				num = (short)1576402945;
				if (num != 0)
				{
				}
				num = (short)675807232;
				short num3 = num;
				this.radErgoMultiFuntionalButtonSecondaryModeCommand.HiddenDynamic = value;
			}
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x0600036C RID: 876 RVA: 0x00035E2C File Offset: 0x0003402C
		public bool RadErgoMultiFuntionalButtonSecondaryModeCommand_HasDiffs
		{
			get
			{
				short num = (short)21257187;
				short num2 = num;
				num = (short)868375523;
				switch (num2 == num)
				{
				}
				num = (short)1886978048;
				if (num != 0)
				{
				}
				num = (short)319750145;
				if (num != 0)
				{
				}
				num = (short)185794560;
				short num3 = num;
				return this.radErgoMultiFuntionalButtonSecondaryModeCommand._HasDiffs;
			}
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x0600036D RID: 877 RVA: 0x00035EE4 File Offset: 0x000340E4
		// (set) Token: 0x0600036E RID: 878 RVA: 0x00035F98 File Offset: 0x00034198
		public string RadErgoWrongBatteryVoiceCommandValue
		{
			get
			{
				short num = (short)372592556;
				short num2 = num;
				num = (short)724324268;
				switch (num2 == num)
				{
				}
				num = (short)1378091009;
				if (num != 0)
				{
				}
				num = (short)1058799616;
				if (num != 0)
				{
				}
				num = (short)1716584448;
				short num3 = num;
				return this.radErgoWrongBatteryVoiceCommand.Value;
			}
			set
			{
				short num = (short)1464227979;
				short num2 = num;
				num = (short)1066424459;
				switch (num2 == num)
				{
				}
				num = (short)2065498112;
				if (num != 0)
				{
				}
				num = (short)1666711553;
				if (num != 0)
				{
				}
				num = (short)210370560;
				short num3 = num;
				this.radErgoWrongBatteryVoiceCommand.Value = value;
			}
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x0600036F RID: 879 RVA: 0x0003604C File Offset: 0x0003424C
		public global::AcpBusinessLayer.AcpField<string> RadErgoWrongBatteryVoiceCommand
		{
			get
			{
				short num = (short)1513649391;
				short num2 = num;
				num = (short)1741190383;
				switch (num2 == num)
				{
				}
				num = (short)268435457;
				if (num != 0)
				{
				}
				num = (short)1040646144;
				if (num != 0)
				{
				}
				num = (short)1793982464;
				short num3 = num;
				return this.radErgoWrongBatteryVoiceCommand;
			}
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x06000370 RID: 880 RVA: 0x000360FC File Offset: 0x000342FC
		// (set) Token: 0x06000371 RID: 881 RVA: 0x000361B4 File Offset: 0x000343B4
		public string RadErgoWrongBatteryVoiceCommand_UIValue
		{
			get
			{
				short num = (short)1788639255;
				short num2 = num;
				num = (short)1469544471;
				switch (num2 == num)
				{
				}
				num = (short)1284374529;
				if (num != 0)
				{
				}
				num = (short)2064908288;
				if (num != 0)
				{
				}
				num = (short)842137600;
				short num3 = num;
				return this.radErgoWrongBatteryVoiceCommand.Value;
			}
			set
			{
				short num = (short)1554107796;
				short num2 = num;
				num = (short)1144507796;
				switch (num2 == num)
				{
				}
				num = (short)1306984448;
				if (num != 0)
				{
				}
				num = (short)1556938753;
				if (num != 0)
				{
				}
				num = (short)691208192;
				short num3 = num;
				this.radErgoWrongBatteryVoiceCommand.Value = value;
			}
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x06000372 RID: 882 RVA: 0x0003626C File Offset: 0x0003446C
		// (set) Token: 0x06000373 RID: 883 RVA: 0x00036320 File Offset: 0x00034520
		public bool RadErgoWrongBatteryVoiceCommand_Applicable
		{
			get
			{
				short num = (short)1748721188;
				short num2 = num;
				num = (short)2061000228;
				switch (num2 == num)
				{
				}
				num = (short)2060255233;
				if (num != 0)
				{
				}
				num = (short)1410793472;
				if (num != 0)
				{
				}
				num = (short)2102001664;
				short num3 = num;
				return this.radErgoWrongBatteryVoiceCommand.Applicable;
			}
			set
			{
				short num = (short)1812172970;
				short num2 = num;
				num = (short)1337430186;
				switch (num2 == num)
				{
				}
				num = (short)1954086913;
				if (num != 0)
				{
				}
				num = (short)1622999040;
				if (num != 0)
				{
				}
				num = (short)1883570176;
				short num3 = num;
				this.radErgoWrongBatteryVoiceCommand.Applicable = value;
			}
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x06000374 RID: 884 RVA: 0x000363DC File Offset: 0x000345DC
		// (set) Token: 0x06000375 RID: 885 RVA: 0x00036490 File Offset: 0x00034690
		public bool RadErgoWrongBatteryVoiceCommand_Valid
		{
			get
			{
				short num = (short)1676935169;
				if (num != 0)
				{
				}
				num = (short)339246630;
				short num2 = num;
				num = (short)1921809958;
				switch (num2 == num)
				{
				}
				num = (short)911212544;
				if (num != 0)
				{
				}
				num = (short)614203392;
				short num3 = num;
				return this.radErgoWrongBatteryVoiceCommand.Valid;
			}
			set
			{
				short num = (short)762035147;
				short num2 = num;
				num = (short)37206987;
				switch (num2 == num)
				{
				}
				num = (short)1104019457;
				if (num != 0)
				{
				}
				num = (short)566886400;
				if (num != 0)
				{
				}
				num = (short)1066991616;
				short num3 = num;
				this.radErgoWrongBatteryVoiceCommand.Valid = value;
			}
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x06000376 RID: 886 RVA: 0x00036544 File Offset: 0x00034744
		// (set) Token: 0x06000377 RID: 887 RVA: 0x000365F8 File Offset: 0x000347F8
		public bool RadErgoWrongBatteryVoiceCommand_Visible
		{
			get
			{
				short num = (short)626998914;
				short num2 = num;
				num = (short)1794588290;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1743454208;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1446248448;
				if (num != 0)
				{
				}
				num = (short)192348161;
				if (num != 0)
				{
				}
				return this.radErgoWrongBatteryVoiceCommand.Visible;
			}
			set
			{
				short num = (short)2136020340;
				short num2 = num;
				num = (short)1538921844;
				switch (num2 == num)
				{
				default:
				{
					num = (short)820707328;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)392822785;
				if (num != 0)
				{
				}
				num = (short)1929904128;
				if (num != 0)
				{
				}
				this.radErgoWrongBatteryVoiceCommand.Visible = value;
			}
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x06000378 RID: 888 RVA: 0x000366B0 File Offset: 0x000348B0
		// (set) Token: 0x06000379 RID: 889 RVA: 0x00036764 File Offset: 0x00034964
		public bool RadErgoWrongBatteryVoiceCommand_Editable
		{
			get
			{
				short num = (short)1903070379;
				short num2 = num;
				num = (short)50957483;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2126184448;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)409141248;
				if (num != 0)
				{
				}
				num = (short)1755971585;
				if (num != 0)
				{
				}
				return this.radErgoWrongBatteryVoiceCommand.Editable;
			}
			set
			{
				short num = (short)1133071521;
				short num2 = num;
				num = (short)2096385185;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1143799808;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1191051265;
				if (num != 0)
				{
				}
				num = (short)2121990144;
				if (num != 0)
				{
				}
				this.radErgoWrongBatteryVoiceCommand.Editable = value;
			}
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x0600037A RID: 890 RVA: 0x0003681C File Offset: 0x00034A1C
		internal string radErgoWrongBatteryVoiceCommand_UILabel
		{
			get
			{
				short num = (short)1849707930;
				short num2 = num;
				num = (short)1220103578;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1718091776;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1864237057;
				if (num != 0)
				{
				}
				num = (short)301203456;
				if (num != 0)
				{
				}
				return this.radErgoWrongBatteryVoiceCommand.UIName;
			}
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x0600037B RID: 891 RVA: 0x000368D0 File Offset: 0x00034AD0
		// (set) Token: 0x0600037C RID: 892 RVA: 0x00036984 File Offset: 0x00034B84
		internal bool RadErgoWrongBatteryVoiceCommand_HiddenStatic
		{
			get
			{
				short num = (short)1311440897;
				if (num != 0)
				{
				}
				num = (short)912195584;
				short num2 = num;
				num = (short)270396188;
				short num3 = num;
				num = (short)107539228;
				switch (num3 == num)
				{
				}
				num = (short)983040000;
				if (num != 0)
				{
				}
				return this.radErgoWrongBatteryVoiceCommand.HiddenStatic;
			}
			set
			{
				short num = (short)669777921;
				if (num != 0)
				{
				}
				num = (short)33423360;
				short num2 = num;
				num = (short)1554079458;
				short num3 = num;
				num = (short)1048862434;
				switch (num3 == num)
				{
				}
				num = (short)1710948352;
				if (num != 0)
				{
				}
				this.radErgoWrongBatteryVoiceCommand.HiddenStatic = value;
			}
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x0600037D RID: 893 RVA: 0x00036A3C File Offset: 0x00034C3C
		// (set) Token: 0x0600037E RID: 894 RVA: 0x00036AF4 File Offset: 0x00034CF4
		internal bool RadErgoWrongBatteryVoiceCommand_HiddenDynamic
		{
			get
			{
				short num = (short)1495859201;
				if (num != 0)
				{
				}
				num = (short)1533804544;
				short num2 = num;
				num = (short)151736624;
				short num3 = num;
				num = (short)631066928;
				switch (num3 == num)
				{
				}
				num = (short)432734208;
				if (num != 0)
				{
				}
				return this.radErgoWrongBatteryVoiceCommand.HiddenDynamic;
			}
			set
			{
				short num = (short)1712193537;
				if (num != 0)
				{
				}
				num = (short)1876623360;
				short num2 = num;
				num = (short)87617588;
				short num3 = num;
				num = (short)139915316;
				switch (num3 == num)
				{
				}
				num = (short)1029898240;
				if (num != 0)
				{
				}
				this.radErgoWrongBatteryVoiceCommand.HiddenDynamic = value;
			}
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x0600037F RID: 895 RVA: 0x00036BA8 File Offset: 0x00034DA8
		public bool RadErgoWrongBatteryVoiceCommand_HasDiffs
		{
			get
			{
				short num = (short)663224321;
				if (num != 0)
				{
				}
				num = (short)1337393152;
				short num2 = num;
				num = (short)813053823;
				short num3 = num;
				num = (short)921778047;
				switch (num3 == num)
				{
				}
				num = (short)157220864;
				if (num != 0)
				{
				}
				return this.radErgoWrongBatteryVoiceCommand._HasDiffs;
			}
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x06000380 RID: 896 RVA: 0x00036C5C File Offset: 0x00034E5C
		// (set) Token: 0x06000381 RID: 897 RVA: 0x00036D10 File Offset: 0x00034F10
		public int RadErgoCfgVAWideExitHazardZoneModeValue
		{
			get
			{
				short num = (short)1051659640;
				short num2 = num;
				num = (short)1650396536;
				switch (num2 == num)
				{
				default:
				{
					num = (short)897253376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)934543360;
				if (num != 0)
				{
				}
				num = (short)735903745;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWideExitHazardZoneMode.Value;
			}
			set
			{
				short num = (short)1690566846;
				short num2 = num;
				num = (short)1868890302;
				switch (num2 == num)
				{
				default:
				{
					num = (short)377618432;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)79101952;
				if (num != 0)
				{
				}
				num = (short)1688535041;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWideExitHazardZoneMode.Value = value;
			}
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x06000382 RID: 898 RVA: 0x00036DC4 File Offset: 0x00034FC4
		// (set) Token: 0x06000383 RID: 899 RVA: 0x00036E74 File Offset: 0x00035074
		public string RadErgoCfgVAWideExitHazardZoneMode_UIValue
		{
			get
			{
				short num = (short)1327366145;
				if (num != 0)
				{
				}
				num = (short)1484980224;
				short num2 = num;
				num = (short)583381382;
				short num3 = num;
				num = (short)435925382;
				switch (num3 == num)
				{
				}
				num = (short)518782976;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWideExitHazardZoneMode.UIValue;
			}
			set
			{
				short num = (short)317694064;
				short num2 = num;
				num = (short)637116528;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1654390784;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1562509313;
				if (num != 0)
				{
				}
				num = (short)834142208;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWideExitHazardZoneMode.UIValue = value;
			}
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x06000384 RID: 900 RVA: 0x00036F2C File Offset: 0x0003512C
		public global::AcpBusinessLayer.AcpRecRefField RadErgoCfgVAWideExitHazardZoneMode
		{
			get
			{
				short num = (short)1310925453;
				short num2 = num;
				num = (short)199369357;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1553203200;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)861208577;
				if (num != 0)
				{
				}
				num = (short)1369505792;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWideExitHazardZoneMode;
			}
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x06000385 RID: 901 RVA: 0x00036FDC File Offset: 0x000351DC
		// (set) Token: 0x06000386 RID: 902 RVA: 0x00037090 File Offset: 0x00035290
		public bool RadErgoCfgVAWideExitHazardZoneMode_Applicable
		{
			get
			{
				short num = (short)1634884480;
				short num2 = num;
				num = (short)1833917312;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1600258048;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1939668993;
				if (num != 0)
				{
				}
				num = (short)1423179776;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWideExitHazardZoneMode.Applicable;
			}
			set
			{
				short num = (short)105906177;
				if (num != 0)
				{
				}
				num = (short)303497216;
				short num2 = num;
				num = (short)1165481728;
				short num3 = num;
				num = (short)1177016064;
				switch (num3 == num)
				{
				}
				num = (short)151650304;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWideExitHazardZoneMode.Applicable = value;
			}
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x06000387 RID: 903 RVA: 0x00037144 File Offset: 0x00035344
		// (set) Token: 0x06000388 RID: 904 RVA: 0x000371F8 File Offset: 0x000353F8
		public bool RadErgoCfgVAWideExitHazardZoneMode_Valid
		{
			get
			{
				short num = (short)930549886;
				short num2 = num;
				num = (short)554045566;
				switch (num2 == num)
				{
				default:
				{
					num = (short)117768192;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)698482688;
				if (num != 0)
				{
				}
				num = (short)477691905;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWideExitHazardZoneMode.Valid;
			}
			set
			{
				short num = (short)1142554625;
				if (num != 0)
				{
				}
				num = (short)1646133248;
				short num2 = num;
				num = (short)448301231;
				short num3 = num;
				num = (short)1118537903;
				switch (num3 == num)
				{
				}
				num = (short)1972502528;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWideExitHazardZoneMode.Valid = value;
			}
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x06000389 RID: 905 RVA: 0x000372AC File Offset: 0x000354AC
		// (set) Token: 0x0600038A RID: 906 RVA: 0x00037360 File Offset: 0x00035560
		public bool RadErgoCfgVAWideExitHazardZoneMode_Visible
		{
			get
			{
				short num = (short)1001145457;
				short num2 = num;
				num = (short)1538737265;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1994719232;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)636813312;
				if (num != 0)
				{
				}
				num = (short)824311809;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWideExitHazardZoneMode.Visible;
			}
			set
			{
				short num = (short)916700628;
				short num2 = num;
				num = (short)296795604;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1153630208;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)877199360;
				if (num != 0)
				{
				}
				num = (short)813170689;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWideExitHazardZoneMode.Visible = value;
			}
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x0600038B RID: 907 RVA: 0x00037418 File Offset: 0x00035618
		// (set) Token: 0x0600038C RID: 908 RVA: 0x000374CC File Offset: 0x000356CC
		public bool RadErgoCfgVAWideExitHazardZoneMode_Editable
		{
			get
			{
				short num = (short)787103934;
				short num2 = num;
				num = (short)1389183166;
				switch (num2 == num)
				{
				default:
				{
					num = (short)915406848;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)40632320;
				if (num != 0)
				{
				}
				num = (short)1662844929;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWideExitHazardZoneMode.Editable;
			}
			set
			{
				short num = (short)995745718;
				short num2 = num;
				num = (short)307158966;
				switch (num2 == num)
				{
				default:
				{
					num = (short)215941120;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1121845249;
				if (num != 0)
				{
				}
				num = (short)9240576;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWideExitHazardZoneMode.Editable = value;
			}
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x0600038D RID: 909 RVA: 0x00037584 File Offset: 0x00035784
		internal string RadErgoCfgVAWideExitHazardZoneMode_UILabel
		{
			get
			{
				short num = (short)2043823800;
				short num2 = num;
				num = (short)995837624;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1342308352;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)23724033;
				if (num != 0)
				{
				}
				num = (short)777453568;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWideExitHazardZoneMode.UIName;
			}
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x0600038E RID: 910 RVA: 0x0003763C File Offset: 0x0003583C
		// (set) Token: 0x0600038F RID: 911 RVA: 0x000376F0 File Offset: 0x000358F0
		internal bool RadErgoCfgVAWideExitHazardZoneMode_HiddenStatic
		{
			get
			{
				short num = (short)1571875877;
				short num2 = num;
				num = (short)583134245;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1982660608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1399783424;
				if (num != 0)
				{
				}
				num = (short)63045633;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWideExitHazardZoneMode.HiddenStatic;
			}
			set
			{
				short num = (short)184672756;
				short num2 = num;
				num = (short)634577396;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1621295104;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1795096577;
				if (num != 0)
				{
				}
				num = (short)1056505856;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWideExitHazardZoneMode.HiddenStatic = value;
			}
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x06000390 RID: 912 RVA: 0x000377A8 File Offset: 0x000359A8
		// (set) Token: 0x06000391 RID: 913 RVA: 0x0003785C File Offset: 0x00035A5C
		internal bool RadErgoCfgVAWideExitHazardZoneMode_HiddenDynamic
		{
			get
			{
				short num = (short)1335974388;
				short num2 = num;
				num = (short)153049588;
				switch (num2 == num)
				{
				default:
				{
					num = (short)722534400;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)438697985;
				if (num != 0)
				{
				}
				num = (short)902430720;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWideExitHazardZoneMode.HiddenDynamic;
			}
			set
			{
				short num = (short)1956249601;
				if (num != 0)
				{
				}
				num = (short)2092236800;
				short num2 = num;
				num = (short)1212688241;
				short num3 = num;
				num = (short)219883377;
				switch (num3 == num)
				{
				}
				num = (short)291569664;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWideExitHazardZoneMode.HiddenDynamic = value;
			}
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x06000392 RID: 914 RVA: 0x00037910 File Offset: 0x00035B10
		public bool RadErgoCfgVAWideExitHazardZoneMode_HasDiffs
		{
			get
			{
				short num = (short)572522497;
				if (num != 0)
				{
				}
				num = (short)1647968256;
				short num2 = num;
				num = (short)317221736;
				short num3 = num;
				num = (short)795437928;
				switch (num3 == num)
				{
				}
				num = (short)48693248;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWideExitHazardZoneMode._HasDiffs;
			}
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x06000393 RID: 915 RVA: 0x000379C4 File Offset: 0x00035BC4
		// (set) Token: 0x06000394 RID: 916 RVA: 0x00037A78 File Offset: 0x00035C78
		public string RadErgoExitHazardZoneModeAnnouncementVoiceCommandValue
		{
			get
			{
				short num = (short)337379329;
				if (num != 0)
				{
				}
				num = (short)1867251712;
				short num2 = num;
				num = (short)1941271469;
				short num3 = num;
				num = (short)1847489453;
				switch (num3 == num)
				{
				}
				num = (short)712179712;
				if (num != 0)
				{
				}
				return this.radErgoExitHazardZoneModeAnnouncementVoiceCommand.Value;
			}
			set
			{
				short num = (short)1362935839;
				short num2 = num;
				num = (short)140689439;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1290207232;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)494993409;
				if (num != 0)
				{
				}
				num = (short)972685312;
				if (num != 0)
				{
				}
				this.radErgoExitHazardZoneModeAnnouncementVoiceCommand.Value = value;
			}
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x06000395 RID: 917 RVA: 0x00037B2C File Offset: 0x00035D2C
		public global::AcpBusinessLayer.AcpField<string> RadErgoExitHazardZoneModeAnnouncementVoiceCommand
		{
			get
			{
				short num = (short)1043304924;
				short num2 = num;
				num = (short)794661340;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1372323840;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)130875393;
				if (num != 0)
				{
				}
				num = (short)121241600;
				if (num != 0)
				{
				}
				return this.radErgoExitHazardZoneModeAnnouncementVoiceCommand;
			}
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x06000396 RID: 918 RVA: 0x00037BDC File Offset: 0x00035DDC
		// (set) Token: 0x06000397 RID: 919 RVA: 0x00037C90 File Offset: 0x00035E90
		public string RadErgoExitHazardZoneModeAnnouncementVoiceCommand_UIValue
		{
			get
			{
				short num = (short)1492741430;
				short num2 = num;
				num = (short)44133686;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1298464768;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1791492097;
				if (num != 0)
				{
				}
				num = (short)961544192;
				if (num != 0)
				{
				}
				return this.radErgoExitHazardZoneModeAnnouncementVoiceCommand.Value;
			}
			set
			{
				short num = (short)1669312244;
				short num2 = num;
				num = (short)339521268;
				switch (num2 == num)
				{
				default:
				{
					num = (short)13434880;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)562626561;
				if (num != 0)
				{
				}
				num = (short)621215744;
				if (num != 0)
				{
				}
				this.radErgoExitHazardZoneModeAnnouncementVoiceCommand.Value = value;
			}
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x06000398 RID: 920 RVA: 0x00037D44 File Offset: 0x00035F44
		// (set) Token: 0x06000399 RID: 921 RVA: 0x00037DF8 File Offset: 0x00035FF8
		public bool RadErgoExitHazardZoneModeAnnouncementVoiceCommand_Applicable
		{
			get
			{
				short num = (short)353694159;
				short num2 = num;
				num = (short)558494159;
				switch (num2 == num)
				{
				default:
				{
					num = (short)154009600;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1379008513;
				if (num != 0)
				{
				}
				num = (short)1898446848;
				if (num != 0)
				{
				}
				return this.radErgoExitHazardZoneModeAnnouncementVoiceCommand.Applicable;
			}
			set
			{
				short num = (short)645583017;
				short num2 = num;
				num = (short)2002243753;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1345388544;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1347813376;
				if (num != 0)
				{
				}
				num = (short)1306263553;
				if (num != 0)
				{
				}
				this.radErgoExitHazardZoneModeAnnouncementVoiceCommand.Applicable = value;
			}
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x0600039A RID: 922 RVA: 0x00037EAC File Offset: 0x000360AC
		// (set) Token: 0x0600039B RID: 923 RVA: 0x00037F60 File Offset: 0x00036160
		public bool RadErgoExitHazardZoneModeAnnouncementVoiceCommand_Valid
		{
			get
			{
				short num = (short)340278386;
				short num2 = num;
				num = (short)1653357682;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1971585024;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)319029249;
				if (num != 0)
				{
				}
				num = (short)1584463872;
				if (num != 0)
				{
				}
				return this.radErgoExitHazardZoneModeAnnouncementVoiceCommand.Valid;
			}
			set
			{
				short num = (short)1646025528;
				short num2 = num;
				num = (short)731405112;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1067450368;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1879310337;
				if (num != 0)
				{
				}
				num = (short)824836096;
				if (num != 0)
				{
				}
				this.radErgoExitHazardZoneModeAnnouncementVoiceCommand.Valid = value;
			}
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x0600039C RID: 924 RVA: 0x00038018 File Offset: 0x00036218
		// (set) Token: 0x0600039D RID: 925 RVA: 0x000380CC File Offset: 0x000362CC
		public bool RadErgoExitHazardZoneModeAnnouncementVoiceCommand_Visible
		{
			get
			{
				short num = (short)544866305;
				if (num != 0)
				{
				}
				num = (short)266272768;
				short num2 = num;
				num = (short)1921296051;
				short num3 = num;
				num = (short)2062198451;
				switch (num3 == num)
				{
				}
				num = (short)1264779264;
				if (num != 0)
				{
				}
				return this.radErgoExitHazardZoneModeAnnouncementVoiceCommand.Visible;
			}
			set
			{
				short num = (short)1646800220;
				short num2 = num;
				num = (short)456666460;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1439170560;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)460849152;
				if (num != 0)
				{
				}
				num = (short)573308929;
				if (num != 0)
				{
				}
				this.radErgoExitHazardZoneModeAnnouncementVoiceCommand.Visible = value;
			}
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x0600039E RID: 926 RVA: 0x00038180 File Offset: 0x00036380
		// (set) Token: 0x0600039F RID: 927 RVA: 0x00038234 File Offset: 0x00036434
		public bool RadErgoExitHazardZoneModeAnnouncementVoiceCommand_Editable
		{
			get
			{
				short num = (short)1786277840;
				short num2 = num;
				num = (short)1481994192;
				switch (num2 == num)
				{
				default:
				{
					num = (short)674496512;
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
				num = (short)1053163520;
				if (num != 0)
				{
				}
				return this.radErgoExitHazardZoneModeAnnouncementVoiceCommand.Editable;
			}
			set
			{
				short num = (short)855017353;
				short num2 = num;
				num = (short)1743619977;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1146486784;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1121124353;
				if (num != 0)
				{
				}
				num = (short)605028352;
				if (num != 0)
				{
				}
				this.radErgoExitHazardZoneModeAnnouncementVoiceCommand.Editable = value;
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x060003A0 RID: 928 RVA: 0x000382E8 File Offset: 0x000364E8
		internal string RadErgoExitHazardZoneModeAnnouncementVoiceCommand_UILabel
		{
			get
			{
				short num = (short)1832452097;
				if (num != 0)
				{
				}
				num = (short)331153408;
				short num2 = num;
				num = (short)47603300;
				short num3 = num;
				num = (short)370957924;
				switch (num3 == num)
				{
				}
				num = (short)1599995904;
				if (num != 0)
				{
				}
				return this.radErgoExitHazardZoneModeAnnouncementVoiceCommand.UIName;
			}
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x060003A1 RID: 929 RVA: 0x0003839C File Offset: 0x0003659C
		// (set) Token: 0x060003A2 RID: 930 RVA: 0x00038450 File Offset: 0x00036650
		internal bool RadErgoExitHazardZoneModeAnnouncementVoiceCommand_HiddenStatic
		{
			get
			{
				short num = (short)1805837430;
				short num2 = num;
				num = (short)317514870;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1389035520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)303562752;
				if (num != 0)
				{
				}
				num = (short)827457537;
				if (num != 0)
				{
				}
				return this.radErgoExitHazardZoneModeAnnouncementVoiceCommand.HiddenStatic;
			}
			set
			{
				short num = (short)299106305;
				if (num != 0)
				{
				}
				num = (short)351404032;
				short num2 = num;
				num = (short)1655942893;
				short num3 = num;
				num = (short)1637199597;
				switch (num3 == num)
				{
				}
				num = (short)212140032;
				if (num != 0)
				{
				}
				this.radErgoExitHazardZoneModeAnnouncementVoiceCommand.HiddenStatic = value;
			}
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x060003A3 RID: 931 RVA: 0x00038508 File Offset: 0x00036708
		// (set) Token: 0x060003A4 RID: 932 RVA: 0x000385BC File Offset: 0x000367BC
		internal bool RadErgoExitHazardZoneModeAnnouncementVoiceCommand_HiddenDynamic
		{
			get
			{
				short num = (short)1732575233;
				if (num != 0)
				{
				}
				num = (short)1913389056;
				short num2 = num;
				num = (short)1918982949;
				short num3 = num;
				num = (short)1191402277;
				switch (num3 == num)
				{
				}
				num = (short)1022820352;
				if (num != 0)
				{
				}
				return this.radErgoExitHazardZoneModeAnnouncementVoiceCommand.HiddenDynamic;
			}
			set
			{
				short num = (short)260939302;
				short num2 = num;
				num = (short)1679269414;
				switch (num2 == num)
				{
				default:
				{
					num = (short)879951872;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1757478913;
				if (num != 0)
				{
				}
				num = (short)1669332992;
				if (num != 0)
				{
				}
				this.radErgoExitHazardZoneModeAnnouncementVoiceCommand.HiddenDynamic = value;
			}
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x060003A5 RID: 933 RVA: 0x00038674 File Offset: 0x00036874
		public bool RadErgoExitHazardZoneModeAnnouncementVoiceCommand_HasDiffs
		{
			get
			{
				short num = (short)901101595;
				short num2 = num;
				num = (short)1624094747;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1348075520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)107282432;
				if (num != 0)
				{
				}
				num = (short)1572732929;
				if (num != 0)
				{
				}
				return this.radErgoExitHazardZoneModeAnnouncementVoiceCommand._HasDiffs;
			}
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x060003A6 RID: 934 RVA: 0x0003872C File Offset: 0x0003692C
		// (set) Token: 0x060003A7 RID: 935 RVA: 0x000387E0 File Offset: 0x000369E0
		public int RadErgoCfgVAWideSelfCheckFailureValue
		{
			get
			{
				short num = (short)703091298;
				short num2 = num;
				num = (short)1047220834;
				switch (num2 == num)
				{
				default:
				{
					num = (short)276496384;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1614741504;
				if (num != 0)
				{
				}
				num = (short)1055326209;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWideSelfCheckFailure.Value;
			}
			set
			{
				short num = (short)1981684887;
				short num2 = num;
				num = (short)1790778519;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1808793600;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1162543105;
				if (num != 0)
				{
				}
				num = (short)327680000;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWideSelfCheckFailure.Value = value;
			}
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x060003A8 RID: 936 RVA: 0x00038898 File Offset: 0x00036A98
		// (set) Token: 0x060003A9 RID: 937 RVA: 0x00038948 File Offset: 0x00036B48
		public string RadErgoCfgVAWideSelfCheckFailure_UIValue
		{
			get
			{
				short num = (short)227997331;
				short num2 = num;
				num = (short)2008741523;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1497759744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)177930240;
				if (num != 0)
				{
				}
				num = (short)22544385;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWideSelfCheckFailure.UIValue;
			}
			set
			{
				short num = (short)1003900326;
				short num2 = num;
				num = (short)866340262;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2067726336;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1332609025;
				if (num != 0)
				{
				}
				num = (short)1495334912;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWideSelfCheckFailure.UIValue = value;
			}
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x060003AA RID: 938 RVA: 0x000389FC File Offset: 0x00036BFC
		public global::AcpBusinessLayer.AcpRecRefField RadErgoCfgVAWideSelfCheckFailure
		{
			get
			{
				short num = (short)449251322;
				short num2 = num;
				num = (short)534710266;
				switch (num2 == num)
				{
				default:
				{
					num = (short)225247232;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)426901505;
				if (num != 0)
				{
				}
				num = (short)142278656;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWideSelfCheckFailure;
			}
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x060003AB RID: 939 RVA: 0x00038AA8 File Offset: 0x00036CA8
		// (set) Token: 0x060003AC RID: 940 RVA: 0x00038B5C File Offset: 0x00036D5C
		public bool RadErgoCfgVAWideSelfCheckFailure_Applicable
		{
			get
			{
				short num = (short)1155086772;
				short num2 = num;
				num = (short)731724212;
				switch (num2 == num)
				{
				default:
				{
					num = (short)834273280;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1707737089;
				if (num != 0)
				{
				}
				num = (short)1631453184;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWideSelfCheckFailure.Applicable;
			}
			set
			{
				short num = (short)1187773943;
				short num2 = num;
				num = (short)376241655;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2047410176;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)251854849;
				if (num != 0)
				{
				}
				num = (short)1862139904;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWideSelfCheckFailure.Applicable = value;
			}
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x060003AD RID: 941 RVA: 0x00038C10 File Offset: 0x00036E10
		// (set) Token: 0x060003AE RID: 942 RVA: 0x00038CC8 File Offset: 0x00036EC8
		public bool RadErgoCfgVAWideSelfCheckFailure_Valid
		{
			get
			{
				short num = (short)1005911491;
				short num2 = num;
				num = (short)803143107;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1284898816;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1771307009;
				if (num != 0)
				{
				}
				num = (short)407896064;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWideSelfCheckFailure.Valid;
			}
			set
			{
				short num = (short)2046703037;
				short num2 = num;
				num = (short)1787180477;
				switch (num2 == num)
				{
				default:
				{
					num = (short)997785600;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)73465856;
				if (num != 0)
				{
				}
				num = (short)1275002881;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWideSelfCheckFailure.Valid = value;
			}
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x060003AF RID: 943 RVA: 0x00038D7C File Offset: 0x00036F7C
		// (set) Token: 0x060003B0 RID: 944 RVA: 0x00038E34 File Offset: 0x00037034
		public bool RadErgoCfgVAWideSelfCheckFailure_Visible
		{
			get
			{
				short num = (short)181272577;
				if (num != 0)
				{
				}
				num = (short)1190920192;
				short num2 = num;
				num = (short)548029939;
				short num3 = num;
				num = (short)602883571;
				switch (num3 == num)
				{
				}
				num = (short)544145408;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWideSelfCheckFailure.Visible;
			}
			set
			{
				short num = (short)1651466364;
				short num2 = num;
				num = (short)307978364;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1736179712;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1135542273;
				if (num != 0)
				{
				}
				num = (short)105250816;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWideSelfCheckFailure.Visible = value;
			}
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x060003B1 RID: 945 RVA: 0x00038EE8 File Offset: 0x000370E8
		// (set) Token: 0x060003B2 RID: 946 RVA: 0x00038F9C File Offset: 0x0003719C
		public bool RadErgoCfgVAWideSelfCheckFailure_Editable
		{
			get
			{
				short num = (short)1818820608;
				short num2 = num;
				num = (short)1490971558;
				short num3 = num;
				num = (short)2010934182;
				switch (num3 == num)
				{
				}
				num = (short)1805582337;
				if (num != 0)
				{
				}
				num = (short)1571225600;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWideSelfCheckFailure.Editable;
			}
			set
			{
				short num = (short)1500119040;
				short num2 = num;
				num = (short)29987112;
				short num3 = num;
				num = (short)364089640;
				switch (num3 == num)
				{
				}
				num = (short)2125332481;
				if (num != 0)
				{
				}
				num = (short)2119565312;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWideSelfCheckFailure.Editable = value;
			}
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x060003B3 RID: 947 RVA: 0x00039050 File Offset: 0x00037250
		internal string RadErgoCfgVAWideSelfCheckFailure_UILabel
		{
			get
			{
				short num = (short)729874432;
				short num2 = num;
				num = (short)775829361;
				short num3 = num;
				num = (short)69941105;
				switch (num3 == num)
				{
				}
				num = (short)1051262976;
				if (num != 0)
				{
				}
				num = (short)152502273;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWideSelfCheckFailure.UIName;
			}
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x060003B4 RID: 948 RVA: 0x00039104 File Offset: 0x00037304
		// (set) Token: 0x060003B5 RID: 949 RVA: 0x000391BC File Offset: 0x000373BC
		internal bool RadErgoCfgVAWideSelfCheckFailure_HiddenStatic
		{
			get
			{
				short num = (short)740294656;
				short num2 = num;
				num = (short)641925121;
				if (num != 0)
				{
				}
				num = (short)925099463;
				short num3 = num;
				num = (short)1154475463;
				switch (num3 == num)
				{
				}
				num = (short)1296629760;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWideSelfCheckFailure.HiddenStatic;
			}
			set
			{
				short num = (short)347602944;
				short num2 = num;
				num = (short)1818066054;
				short num3 = num;
				num = (short)1928035462;
				switch (num3 == num)
				{
				}
				num = (short)256770048;
				if (num != 0)
				{
				}
				num = (short)430112769;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWideSelfCheckFailure.HiddenStatic = value;
			}
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x060003B6 RID: 950 RVA: 0x00039270 File Offset: 0x00037470
		// (set) Token: 0x060003B7 RID: 951 RVA: 0x00039328 File Offset: 0x00037528
		internal bool RadErgoCfgVAWideSelfCheckFailure_HiddenDynamic
		{
			get
			{
				short num = (short)2039480320;
				short num2 = num;
				num = (short)2113828704;
				short num3 = num;
				num = (short)469923680;
				switch (num3 == num)
				{
				}
				num = (short)531365889;
				if (num != 0)
				{
				}
				num = (short)1475018752;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWideSelfCheckFailure.HiddenDynamic;
			}
			set
			{
				short num = (short)305266688;
				short num2 = num;
				num = (short)1727004673;
				if (num != 0)
				{
				}
				num = (short)1268087708;
				short num3 = num;
				num = (short)311589788;
				switch (num3 == num)
				{
				}
				num = (short)227278848;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWideSelfCheckFailure.HiddenDynamic = value;
			}
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x060003B8 RID: 952 RVA: 0x000393DC File Offset: 0x000375DC
		public bool RadErgoCfgVAWideSelfCheckFailure_HasDiffs
		{
			get
			{
				short num = (short)797245440;
				short num2 = num;
				num = (short)147690375;
				short num3 = num;
				num = (short)1432392583;
				switch (num3 == num)
				{
				}
				num = (short)2087911425;
				if (num != 0)
				{
				}
				num = (short)1398407168;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWideSelfCheckFailure._HasDiffs;
			}
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x060003B9 RID: 953 RVA: 0x00039494 File Offset: 0x00037694
		// (set) Token: 0x060003BA RID: 954 RVA: 0x00039548 File Offset: 0x00037748
		public string RadErgoSelfCheckFailAnnouncementVoiceCommandValue
		{
			get
			{
				short num = (short)1946484736;
				short num2 = num;
				num = (short)1800143505;
				short num3 = num;
				num = (short)1019937425;
				switch (num3 == num)
				{
				}
				num = (short)1137377281;
				if (num != 0)
				{
				}
				num = (short)624623616;
				if (num != 0)
				{
				}
				return this.radErgoSelfCheckFailAnnouncementVoiceCommand.Value;
			}
			set
			{
				short num = (short)463929344;
				short num2 = num;
				num = (short)1933225632;
				short num3 = num;
				num = (short)716222112;
				switch (num3 == num)
				{
				}
				num = (short)1035993088;
				if (num != 0)
				{
				}
				num = (short)430243841;
				if (num != 0)
				{
				}
				this.radErgoSelfCheckFailAnnouncementVoiceCommand.Value = value;
			}
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x060003BB RID: 955 RVA: 0x000395FC File Offset: 0x000377FC
		public global::AcpBusinessLayer.AcpField<string> RadErgoSelfCheckFailAnnouncementVoiceCommand
		{
			get
			{
				short num = (short)1629618176;
				short num2 = num;
				num = (short)1930645987;
				short num3 = num;
				num = (short)557011427;
				switch (num3 == num)
				{
				}
				num = (short)1483472897;
				if (num != 0)
				{
				}
				num = (short)1483276288;
				if (num != 0)
				{
				}
				return this.radErgoSelfCheckFailAnnouncementVoiceCommand;
			}
		}

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x060003BC RID: 956 RVA: 0x000396B0 File Offset: 0x000378B0
		// (set) Token: 0x060003BD RID: 957 RVA: 0x00039760 File Offset: 0x00037960
		public string RadErgoSelfCheckFailAnnouncementVoiceCommand_UIValue
		{
			get
			{
				short num = (short)1016463360;
				short num2 = num;
				num = (short)1701388046;
				short num3 = num;
				num = (short)203628302;
				switch (num3 == num)
				{
				}
				num = (short)1561591808;
				if (num != 0)
				{
				}
				num = (short)1732837377;
				if (num != 0)
				{
				}
				return this.radErgoSelfCheckFailAnnouncementVoiceCommand.Value;
			}
			set
			{
				short num = (short)1587806208;
				short num2 = num;
				num = (short)17464264;
				short num3 = num;
				num = (short)1851554760;
				switch (num3 == num)
				{
				}
				num = (short)1509556225;
				if (num != 0)
				{
				}
				num = (short)2130051072;
				if (num != 0)
				{
				}
				this.radErgoSelfCheckFailAnnouncementVoiceCommand.Value = value;
			}
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x060003BE RID: 958 RVA: 0x00039818 File Offset: 0x00037A18
		// (set) Token: 0x060003BF RID: 959 RVA: 0x000398CC File Offset: 0x00037ACC
		public bool RadErgoSelfCheckFailAnnouncementVoiceCommand_Applicable
		{
			get
			{
				short num = (short)829620224;
				short num2 = num;
				num = (short)1722575307;
				short num3 = num;
				num = (short)1697475019;
				switch (num3 == num)
				{
				}
				num = (short)720830464;
				if (num != 0)
				{
				}
				num = (short)474939393;
				if (num != 0)
				{
				}
				return this.radErgoSelfCheckFailAnnouncementVoiceCommand.Applicable;
			}
			set
			{
				short num = (short)510197760;
				short num2 = num;
				num = (short)361126738;
				short num3 = num;
				num = (short)702831442;
				switch (num3 == num)
				{
				}
				num = (short)1969487873;
				if (num != 0)
				{
				}
				num = (short)464584704;
				if (num != 0)
				{
				}
				this.radErgoSelfCheckFailAnnouncementVoiceCommand.Applicable = value;
			}
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x060003C0 RID: 960 RVA: 0x00039980 File Offset: 0x00037B80
		// (set) Token: 0x060003C1 RID: 961 RVA: 0x00039A34 File Offset: 0x00037C34
		public bool RadErgoSelfCheckFailAnnouncementVoiceCommand_Valid
		{
			get
			{
				short num = (short)2132541440;
				short num2 = num;
				num = (short)2064241825;
				short num3 = num;
				num = (short)1667945633;
				switch (num3 == num)
				{
				}
				num = (short)936640513;
				if (num != 0)
				{
				}
				num = (short)1551826944;
				if (num != 0)
				{
				}
				return this.radErgoSelfCheckFailAnnouncementVoiceCommand.Valid;
			}
			set
			{
				short num = (short)250216448;
				short num2 = num;
				num = (short)1284257354;
				short num3 = num;
				num = (short)1277245002;
				switch (num3 == num)
				{
				}
				num = (short)76546049;
				if (num != 0)
				{
				}
				num = (short)249364480;
				if (num != 0)
				{
				}
				this.radErgoSelfCheckFailAnnouncementVoiceCommand.Valid = value;
			}
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x060003C2 RID: 962 RVA: 0x00039AEC File Offset: 0x00037CEC
		// (set) Token: 0x060003C3 RID: 963 RVA: 0x00039BA4 File Offset: 0x00037DA4
		public bool RadErgoSelfCheckFailAnnouncementVoiceCommand_Visible
		{
			get
			{
				short num = (short)309657600;
				short num2 = num;
				num = (short)1304617562;
				short num3 = num;
				num = (short)1919279706;
				switch (num3 == num)
				{
				}
				num = (short)1973420033;
				if (num != 0)
				{
				}
				num = (short)1124466688;
				if (num != 0)
				{
				}
				return this.radErgoSelfCheckFailAnnouncementVoiceCommand.Visible;
			}
			set
			{
				short num = (short)633012224;
				short num2 = num;
				num = (short)1702951744;
				short num3 = num;
				num = (short)1160837952;
				switch (num3 == num)
				{
				}
				num = (short)631046144;
				if (num != 0)
				{
				}
				num = (short)2143879169;
				if (num != 0)
				{
				}
				this.radErgoSelfCheckFailAnnouncementVoiceCommand.Visible = value;
			}
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x060003C4 RID: 964 RVA: 0x00039C58 File Offset: 0x00037E58
		// (set) Token: 0x060003C5 RID: 965 RVA: 0x00039D10 File Offset: 0x00037F10
		public bool RadErgoSelfCheckFailAnnouncementVoiceCommand_Editable
		{
			get
			{
				short num = (short)28442624;
				short num2 = num;
				num = (short)1566414795;
				short num3 = num;
				num = (short)1374721995;
				switch (num3 == num)
				{
				}
				num = (short)1773862913;
				if (num != 0)
				{
				}
				num = (short)1747189760;
				if (num != 0)
				{
				}
				return this.radErgoSelfCheckFailAnnouncementVoiceCommand.Editable;
			}
			set
			{
				short num = (short)885850112;
				short num2 = num;
				num = (short)1878429952;
				short num3 = num;
				num = (short)1281528064;
				switch (num3 == num)
				{
				}
				num = (short)962592768;
				if (num != 0)
				{
				}
				num = (short)1639514113;
				if (num != 0)
				{
				}
				this.radErgoSelfCheckFailAnnouncementVoiceCommand.Editable = value;
			}
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x060003C6 RID: 966 RVA: 0x00039DC4 File Offset: 0x00037FC4
		internal string radErgoSelfCheckFailAnnouncementVoiceCommand_UILabel
		{
			get
			{
				short num = (short)1307246592;
				short num2 = num;
				num = (short)816595917;
				short num3 = num;
				num = (short)49955789;
				switch (num3 == num)
				{
				}
				num = (short)1862598657;
				if (num != 0)
				{
				}
				num = (short)850395136;
				if (num != 0)
				{
				}
				return this.radErgoSelfCheckFailAnnouncementVoiceCommand.UIName;
			}
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x060003C7 RID: 967 RVA: 0x00039E78 File Offset: 0x00038078
		// (set) Token: 0x060003C8 RID: 968 RVA: 0x00039F2C File Offset: 0x0003812C
		internal bool RadErgoSelfCheckFailAnnouncementVoiceCommand_HiddenStatic
		{
			get
			{
				short num = (short)751435776;
				short num2 = num;
				num = (short)159687129;
				short num3 = num;
				num = (short)1525064153;
				switch (num3 == num)
				{
				}
				num = (short)965410816;
				if (num != 0)
				{
				}
				num = (short)643956737;
				if (num != 0)
				{
				}
				return this.radErgoSelfCheckFailAnnouncementVoiceCommand.HiddenStatic;
			}
			set
			{
				short num = (short)454098944;
				short num2 = num;
				num = (short)1390280705;
				if (num != 0)
				{
				}
				num = (short)752604430;
				short num3 = num;
				num = (short)1712968974;
				switch (num3 == num)
				{
				}
				num = (short)215941120;
				if (num != 0)
				{
				}
				this.radErgoSelfCheckFailAnnouncementVoiceCommand.HiddenStatic = value;
			}
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x060003C9 RID: 969 RVA: 0x00039FE0 File Offset: 0x000381E0
		// (set) Token: 0x060003CA RID: 970 RVA: 0x0003A094 File Offset: 0x00038294
		internal bool RadErgoSelfCheckFailAnnouncementVoiceCommand_HiddenDynamic
		{
			get
			{
				short num = (short)938672128;
				short num2 = num;
				num = (short)964841169;
				short num3 = num;
				num = (short)320491217;
				switch (num3 == num)
				{
				}
				num = (short)1860304896;
				if (num != 0)
				{
				}
				num = (short)202833921;
				if (num != 0)
				{
				}
				return this.radErgoSelfCheckFailAnnouncementVoiceCommand.HiddenDynamic;
			}
			set
			{
				short num = (short)1342963712;
				short num2 = num;
				num = (short)1164803354;
				short num3 = num;
				num = (short)1283030298;
				switch (num3 == num)
				{
				}
				num = (short)928055297;
				if (num != 0)
				{
				}
				num = (short)1005322240;
				if (num != 0)
				{
				}
				this.radErgoSelfCheckFailAnnouncementVoiceCommand.HiddenDynamic = value;
			}
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x060003CB RID: 971 RVA: 0x0003A150 File Offset: 0x00038350
		public bool RadErgoSelfCheckFailAnnouncementVoiceCommand_HasDiffs
		{
			get
			{
				short num = (short)675872768;
				short num2 = num;
				num = (short)368407160;
				short num3 = num;
				num = (short)1567191672;
				switch (num3 == num)
				{
				}
				num = (short)1194131457;
				if (num != 0)
				{
				}
				num = (short)989462528;
				if (num != 0)
				{
				}
				return this.radErgoSelfCheckFailAnnouncementVoiceCommand._HasDiffs;
			}
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x060003CC RID: 972 RVA: 0x0003A204 File Offset: 0x00038404
		// (set) Token: 0x060003CD RID: 973 RVA: 0x0003A2B8 File Offset: 0x000384B8
		public int RadErgoCfgVAWideAccessoryFailureValue
		{
			get
			{
				short num = (short)743571456;
				short num2 = num;
				num = (short)174754273;
				short num3 = num;
				num = (short)1381468641;
				switch (num3 == num)
				{
				}
				num = (short)1201668096;
				if (num != 0)
				{
				}
				num = (short)1483210753;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWideAccessoryFailure.Value;
			}
			set
			{
				short num = (short)723845120;
				short num2 = num;
				num = (short)244265857;
				short num3 = num;
				num = (short)100086657;
				switch (num3 == num)
				{
				}
				num = (short)1361838081;
				if (num != 0)
				{
				}
				num = (short)378077184;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWideAccessoryFailure.Value = value;
			}
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x060003CE RID: 974 RVA: 0x0003A370 File Offset: 0x00038570
		// (set) Token: 0x060003CF RID: 975 RVA: 0x0003A424 File Offset: 0x00038624
		public string RadErgoCfgVAWideAccessoryFailure_UIValue
		{
			get
			{
				short num = (short)1631256576;
				short num2 = num;
				num = (short)251965693;
				short num3 = num;
				num = (short)1876865277;
				switch (num3 == num)
				{
				}
				num = (short)1729560576;
				if (num != 0)
				{
				}
				num = (short)517996545;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWideAccessoryFailure.UIValue;
			}
			set
			{
				short num = (short)527106048;
				short num2 = num;
				num = (short)315293697;
				if (num != 0)
				{
				}
				num = (short)1678046220;
				short num3 = num;
				num = (short)1754723340;
				switch (num3 == num)
				{
				}
				num = (short)365821952;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWideAccessoryFailure.UIValue = value;
			}
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x060003D0 RID: 976 RVA: 0x0003A4DC File Offset: 0x000386DC
		public global::AcpBusinessLayer.AcpRecRefField RadErgoCfgVAWideAccessoryFailure
		{
			get
			{
				short num = (short)1217724416;
				short num2 = num;
				num = (short)1061001963;
				short num3 = num;
				num = (short)2107284203;
				switch (num3 == num)
				{
				}
				num = (short)1817378816;
				if (num != 0)
				{
				}
				num = (short)1072037889;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWideAccessoryFailure;
			}
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x060003D1 RID: 977 RVA: 0x0003A58C File Offset: 0x0003878C
		// (set) Token: 0x060003D2 RID: 978 RVA: 0x0003A640 File Offset: 0x00038840
		public bool RadErgoCfgVAWideAccessoryFailure_Applicable
		{
			get
			{
				short num = (short)1527906304;
				short num2 = num;
				num = (short)541849215;
				short num3 = num;
				num = (short)465041023;
				switch (num3 == num)
				{
				}
				num = (short)878510081;
				if (num != 0)
				{
				}
				num = (short)750845952;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWideAccessoryFailure.Applicable;
			}
			set
			{
				short num = (short)2141454336;
				short num2 = num;
				num = (short)1454112769;
				if (num != 0)
				{
				}
				num = (short)1749809852;
				short num3 = num;
				num = (short)285276860;
				switch (num3 == num)
				{
				}
				num = (short)220200960;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWideAccessoryFailure.Applicable = value;
			}
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x060003D3 RID: 979 RVA: 0x0003A6F8 File Offset: 0x000388F8
		// (set) Token: 0x060003D4 RID: 980 RVA: 0x0003A7A8 File Offset: 0x000389A8
		public bool RadErgoCfgVAWideAccessoryFailure_Valid
		{
			get
			{
				short num = (short)1389625344;
				short num2 = num;
				num = (short)1645427468;
				short num3 = num;
				num = (short)1812806412;
				switch (num3 == num)
				{
				}
				num = (short)2046296064;
				if (num != 0)
				{
				}
				num = (short)697761793;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWideAccessoryFailure.Valid;
			}
			set
			{
				short num = (short)821035008;
				short num2 = num;
				num = (short)218733620;
				short num3 = num;
				num = (short)982293556;
				switch (num3 == num)
				{
				}
				num = (short)713621505;
				if (num != 0)
				{
				}
				num = (short)1499529216;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWideAccessoryFailure.Valid = value;
			}
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x060003D5 RID: 981 RVA: 0x0003A85C File Offset: 0x00038A5C
		// (set) Token: 0x060003D6 RID: 982 RVA: 0x0003A910 File Offset: 0x00038B10
		public bool RadErgoCfgVAWideAccessoryFailure_Visible
		{
			get
			{
				short num = (short)425721856;
				short num2 = num;
				num = (short)17971294;
				short num3 = num;
				num = (short)1296644190;
				switch (num3 == num)
				{
				}
				num = (short)2108227585;
				if (num != 0)
				{
				}
				num = (short)438108160;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWideAccessoryFailure.Visible;
			}
			set
			{
				short num = (short)522256384;
				short num2 = num;
				num = (short)497525186;
				short num3 = num;
				num = (short)2004722114;
				switch (num3 == num)
				{
				}
				num = (short)323485697;
				if (num != 0)
				{
				}
				num = (short)558301184;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWideAccessoryFailure.Visible = value;
			}
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x060003D7 RID: 983 RVA: 0x0003A9C4 File Offset: 0x00038BC4
		// (set) Token: 0x060003D8 RID: 984 RVA: 0x0003AA78 File Offset: 0x00038C78
		public bool RadErgoCfgVAWideAccessoryFailure_Editable
		{
			get
			{
				short num = (short)409010176;
				short num2 = num;
				num = (short)1942479325;
				short num3 = num;
				num = (short)1768481245;
				switch (num3 == num)
				{
				}
				num = (short)1006305281;
				if (num != 0)
				{
				}
				num = (short)1509425152;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWideAccessoryFailure.Editable;
			}
			set
			{
				short num = (short)1024851968;
				short num2 = num;
				num = (short)1933667606;
				short num3 = num;
				num = (short)310668566;
				switch (num3 == num)
				{
				}
				num = (short)1846476801;
				if (num != 0)
				{
				}
				num = (short)416677888;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWideAccessoryFailure.Editable = value;
			}
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x060003D9 RID: 985 RVA: 0x0003AB30 File Offset: 0x00038D30
		internal string RadErgoCfgVAWideAccessoryFailure_UILabel
		{
			get
			{
				short num = (short)1531838464;
				short num2 = num;
				num = (short)1374027777;
				if (num != 0)
				{
				}
				num = (short)1651323729;
				short num3 = num;
				num = (short)1881355089;
				switch (num3 == num)
				{
				}
				num = (short)1574961152;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWideAccessoryFailure.UIName;
			}
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x060003DA RID: 986 RVA: 0x0003ABE4 File Offset: 0x00038DE4
		// (set) Token: 0x060003DB RID: 987 RVA: 0x0003AC98 File Offset: 0x00038E98
		internal bool RadErgoCfgVAWideAccessoryFailure_HiddenStatic
		{
			get
			{
				short num = (short)1334837248;
				short num2 = num;
				num = (short)92260253;
				short num3 = num;
				num = (short)1025165213;
				switch (num3 == num)
				{
				}
				num = (short)1226702849;
				if (num != 0)
				{
				}
				num = (short)1419640832;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWideAccessoryFailure.HiddenStatic;
			}
			set
			{
				short num = (short)455999488;
				short num2 = num;
				num = (short)909155220;
				short num3 = num;
				num = (short)591371156;
				switch (num3 == num)
				{
				}
				num = (short)257949697;
				if (num != 0)
				{
				}
				num = (short)847183872;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWideAccessoryFailure.HiddenStatic = value;
			}
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x060003DC RID: 988 RVA: 0x0003AD50 File Offset: 0x00038F50
		// (set) Token: 0x060003DD RID: 989 RVA: 0x0003AE08 File Offset: 0x00039008
		internal bool RadErgoCfgVAWideAccessoryFailure_HiddenDynamic
		{
			get
			{
				short num = (short)54919168;
				short num2 = num;
				num = (short)1020725626;
				short num3 = num;
				num = (short)1248659834;
				switch (num3 == num)
				{
				}
				num = (short)2139160576;
				if (num != 0)
				{
				}
				num = (short)613744641;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWideAccessoryFailure.HiddenDynamic;
			}
			set
			{
				short num = (short)1469251584;
				short num2 = num;
				num = (short)764084350;
				short num3 = num;
				num = (short)1660616830;
				switch (num3 == num)
				{
				}
				num = (short)1688731648;
				if (num != 0)
				{
				}
				num = (short)630849537;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWideAccessoryFailure.HiddenDynamic = value;
			}
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x060003DE RID: 990 RVA: 0x0003AEC0 File Offset: 0x000390C0
		public bool RadErgoCfgVAWideAccessoryFailure_HasDiffs
		{
			get
			{
				short num = (short)52297728;
				short num2 = num;
				num = (short)649788809;
				short num3 = num;
				num = (short)1715076489;
				switch (num3 == num)
				{
				}
				num = (short)1951858689;
				if (num != 0)
				{
				}
				num = (short)925630464;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWideAccessoryFailure._HasDiffs;
			}
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x060003DF RID: 991 RVA: 0x0003AF74 File Offset: 0x00039174
		// (set) Token: 0x060003E0 RID: 992 RVA: 0x0003B028 File Offset: 0x00039228
		public string RadErgoAccessoryFailureAnnouncementVoiceCommandValue
		{
			get
			{
				short num = (short)120879819;
				short num2 = num;
				num = (short)1555856075;
				switch (num2 == num)
				{
				default:
				{
					num = (short)717553664;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1631191041;
				if (num != 0)
				{
				}
				num = (short)83427328;
				if (num != 0)
				{
				}
				return this.radErgoAccessoryFailureAnnouncementVoiceCommand.Value;
			}
			set
			{
				short num = (short)885711835;
				short num2 = num;
				num = (short)1938875355;
				switch (num2 == num)
				{
				default:
				{
					num = (short)891813888;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)220921857;
				if (num != 0)
				{
				}
				num = (short)13828096;
				if (num != 0)
				{
				}
				this.radErgoAccessoryFailureAnnouncementVoiceCommand.Value = value;
			}
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x060003E1 RID: 993 RVA: 0x0003B0E0 File Offset: 0x000392E0
		public global::AcpBusinessLayer.AcpField<string> RadErgoAccessoryFailureAnnouncementVoiceCommand
		{
			get
			{
				short num = (short)171682984;
				short num2 = num;
				num = (short)1337371816;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1067450368;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1617690625;
				if (num != 0)
				{
				}
				num = (short)164954112;
				if (num != 0)
				{
				}
				return this.radErgoAccessoryFailureAnnouncementVoiceCommand;
			}
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x060003E2 RID: 994 RVA: 0x0003B18C File Offset: 0x0003938C
		// (set) Token: 0x060003E3 RID: 995 RVA: 0x0003B244 File Offset: 0x00039444
		public string RadErgoAccessoryFailureAnnouncementVoiceCommand_UIValue
		{
			get
			{
				short num = (short)799171858;
				short num2 = num;
				num = (short)215115026;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1573388288;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1060175873;
				if (num != 0)
				{
				}
				num = (short)1830551552;
				if (num != 0)
				{
				}
				return this.radErgoAccessoryFailureAnnouncementVoiceCommand.Value;
			}
			set
			{
				short num = (short)289523628;
				short num2 = num;
				num = (short)838322092;
				switch (num2 == num)
				{
				default:
				{
					num = (short)755630080;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)419561473;
				if (num != 0)
				{
				}
				num = (short)1819017216;
				if (num != 0)
				{
				}
				this.radErgoAccessoryFailureAnnouncementVoiceCommand.Value = value;
			}
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x060003E4 RID: 996 RVA: 0x0003B2FC File Offset: 0x000394FC
		// (set) Token: 0x060003E5 RID: 997 RVA: 0x0003B3B0 File Offset: 0x000395B0
		public bool RadErgoAccessoryFailureAnnouncementVoiceCommand_Applicable
		{
			get
			{
				short num = (short)1548032872;
				short num2 = num;
				num = (short)18881384;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1359544320;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1042415617;
				if (num != 0)
				{
				}
				num = (short)1336213504;
				if (num != 0)
				{
				}
				return this.radErgoAccessoryFailureAnnouncementVoiceCommand.Applicable;
			}
			set
			{
				short num = (short)780155517;
				short num2 = num;
				num = (short)1958165117;
				switch (num2 == num)
				{
				default:
				{
					num = (short)727515136;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1205141505;
				if (num != 0)
				{
				}
				num = (short)96010240;
				if (num != 0)
				{
				}
				this.radErgoAccessoryFailureAnnouncementVoiceCommand.Applicable = value;
			}
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x060003E6 RID: 998 RVA: 0x0003B464 File Offset: 0x00039664
		// (set) Token: 0x060003E7 RID: 999 RVA: 0x0003B518 File Offset: 0x00039718
		public bool RadErgoAccessoryFailureAnnouncementVoiceCommand_Valid
		{
			get
			{
				short num = (short)634498600;
				short num2 = num;
				num = (short)383036968;
				switch (num2 == num)
				{
				default:
				{
					num = (short)218234880;
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
				num = (short)790626304;
				if (num != 0)
				{
				}
				return this.radErgoAccessoryFailureAnnouncementVoiceCommand.Valid;
			}
			set
			{
				short num = (short)355520379;
				short num2 = num;
				num = (short)877907835;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1796014080;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)616759297;
				if (num != 0)
				{
				}
				num = (short)282066944;
				if (num != 0)
				{
				}
				this.radErgoAccessoryFailureAnnouncementVoiceCommand.Valid = value;
			}
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x060003E8 RID: 1000 RVA: 0x0003B5CC File Offset: 0x000397CC
		// (set) Token: 0x060003E9 RID: 1001 RVA: 0x0003B684 File Offset: 0x00039884
		public bool RadErgoAccessoryFailureAnnouncementVoiceCommand_Visible
		{
			get
			{
				short num = (short)20709377;
				if (num != 0)
				{
				}
				num = (short)28704768;
				short num2 = num;
				num = (short)1030629336;
				short num3 = num;
				num = (short)2075404248;
				switch (num3 == num)
				{
				}
				num = (short)50200576;
				if (num != 0)
				{
				}
				return this.radErgoAccessoryFailureAnnouncementVoiceCommand.Visible;
			}
			set
			{
				short num = (short)1557131086;
				short num2 = num;
				num = (short)578088782;
				switch (num2 == num)
				{
				default:
				{
					num = (short)346226688;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)936181760;
				if (num != 0)
				{
				}
				num = (short)1198194689;
				if (num != 0)
				{
				}
				this.radErgoAccessoryFailureAnnouncementVoiceCommand.Visible = value;
			}
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x060003EA RID: 1002 RVA: 0x0003B738 File Offset: 0x00039938
		// (set) Token: 0x060003EB RID: 1003 RVA: 0x0003B7EC File Offset: 0x000399EC
		public bool RadErgoAccessoryFailureAnnouncementVoiceCommand_Editable
		{
			get
			{
				short num = (short)473784930;
				short num2 = num;
				num = (short)897999458;
				switch (num2 == num)
				{
				default:
				{
					num = (short)355794944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2056585216;
				if (num != 0)
				{
				}
				num = (short)1603338241;
				if (num != 0)
				{
				}
				return this.radErgoAccessoryFailureAnnouncementVoiceCommand.Editable;
			}
			set
			{
				short num = (short)1074894582;
				short num2 = num;
				num = (short)1660131062;
				switch (num2 == num)
				{
				default:
				{
					num = (short)590282752;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)233177089;
				if (num != 0)
				{
				}
				num = (short)80347136;
				if (num != 0)
				{
				}
				this.radErgoAccessoryFailureAnnouncementVoiceCommand.Editable = value;
			}
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x060003EC RID: 1004 RVA: 0x0003B8A0 File Offset: 0x00039AA0
		internal string RadErgoAccessoryFailureAnnouncementVoiceCommand_UILabel
		{
			get
			{
				short num = (short)1097138028;
				short num2 = num;
				num = (short)2068971372;
				switch (num2 == num)
				{
				default:
				{
					num = (short)535166976;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1901330432;
				if (num != 0)
				{
				}
				num = (short)1928921089;
				if (num != 0)
				{
				}
				return this.radErgoAccessoryFailureAnnouncementVoiceCommand.UIName;
			}
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x060003ED RID: 1005 RVA: 0x0003B954 File Offset: 0x00039B54
		// (set) Token: 0x060003EE RID: 1006 RVA: 0x0003BA08 File Offset: 0x00039C08
		internal bool RadErgoAccessoryFailureAnnouncementVoiceCommand_HiddenStatic
		{
			get
			{
				short num = (short)883426535;
				short num2 = num;
				num = (short)837354727;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1793327104;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)74711041;
				if (num != 0)
				{
				}
				num = (short)36765696;
				if (num != 0)
				{
				}
				return this.radErgoAccessoryFailureAnnouncementVoiceCommand.HiddenStatic;
			}
			set
			{
				short num = (short)1886584833;
				if (num != 0)
				{
				}
				num = (short)1012793344;
				short num2 = num;
				num = (short)1307636155;
				short num3 = num;
				num = (short)432402875;
				switch (num3 == num)
				{
				}
				num = (short)829227008;
				if (num != 0)
				{
				}
				this.radErgoAccessoryFailureAnnouncementVoiceCommand.HiddenStatic = value;
			}
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x060003EF RID: 1007 RVA: 0x0003BABC File Offset: 0x00039CBC
		// (set) Token: 0x060003F0 RID: 1008 RVA: 0x0003BB74 File Offset: 0x00039D74
		internal bool RadErgoAccessoryFailureAnnouncementVoiceCommand_HiddenDynamic
		{
			get
			{
				short num = (short)791412737;
				if (num != 0)
				{
				}
				num = (short)1013841920;
				short num2 = num;
				num = (short)789929989;
				short num3 = num;
				num = (short)980115461;
				switch (num3 == num)
				{
				}
				num = (short)786563072;
				if (num != 0)
				{
				}
				return this.radErgoAccessoryFailureAnnouncementVoiceCommand.HiddenDynamic;
			}
			set
			{
				short num = (short)893407635;
				short num2 = num;
				num = (short)449728915;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1356988416;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1102446593;
				if (num != 0)
				{
				}
				num = (short)1028194304;
				if (num != 0)
				{
				}
				this.radErgoAccessoryFailureAnnouncementVoiceCommand.HiddenDynamic = value;
			}
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x060003F1 RID: 1009 RVA: 0x0003BC30 File Offset: 0x00039E30
		public bool RadErgoAccessoryFailureAnnouncementVoiceCommand_HasDiffs
		{
			get
			{
				short num = (short)342407828;
				short num2 = num;
				num = (short)1415690900;
				switch (num2 == num)
				{
				default:
				{
					num = (short)463077376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)733806593;
				if (num != 0)
				{
				}
				num = (short)1608515584;
				if (num != 0)
				{
				}
				return this.radErgoAccessoryFailureAnnouncementVoiceCommand._HasDiffs;
			}
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x060003F2 RID: 1010 RVA: 0x0003BCE4 File Offset: 0x00039EE4
		// (set) Token: 0x060003F3 RID: 1011 RVA: 0x0003BD98 File Offset: 0x00039F98
		public int RadErgoCfgVAWideOutOfRangeValue
		{
			get
			{
				short num = (short)844347128;
				short num2 = num;
				num = (short)985118456;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1002766336;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1560215553;
				if (num != 0)
				{
				}
				num = (short)206635008;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWideOutOfRange.Value;
			}
			set
			{
				short num = (short)1018898574;
				short num2 = num;
				num = (short)480782478;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1120206848;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)374276097;
				if (num != 0)
				{
				}
				num = (short)1478361088;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWideOutOfRange.Value = value;
			}
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x060003F4 RID: 1012 RVA: 0x0003BE50 File Offset: 0x0003A050
		// (set) Token: 0x060003F5 RID: 1013 RVA: 0x0003BF08 File Offset: 0x0003A108
		public string RadErgoCfgVAWideOutOfRange_UIValue
		{
			get
			{
				short num = (short)492798219;
				short num2 = num;
				num = (short)532578571;
				switch (num2 == num)
				{
				default:
				{
					num = (short)259391488;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1398669313;
				if (num != 0)
				{
				}
				num = (short)290652160;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWideOutOfRange.UIValue;
			}
			set
			{
				short num = (short)762052609;
				if (num != 0)
				{
				}
				num = (short)1677721600;
				short num2 = num;
				num = (short)1962553022;
				short num3 = num;
				num = (short)1950559934;
				switch (num3 == num)
				{
				}
				num = (short)1326317568;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWideOutOfRange.UIValue = value;
			}
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x060003F6 RID: 1014 RVA: 0x0003BFC0 File Offset: 0x0003A1C0
		public global::AcpBusinessLayer.AcpRecRefField RadErgoCfgVAWideOutOfRange
		{
			get
			{
				short num = (short)1375256350;
				short num2 = num;
				num = (short)1693368094;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1882259456;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2025062400;
				if (num != 0)
				{
				}
				num = (short)289603585;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWideOutOfRange;
			}
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x060003F7 RID: 1015 RVA: 0x0003C070 File Offset: 0x0003A270
		// (set) Token: 0x060003F8 RID: 1016 RVA: 0x0003C128 File Offset: 0x0003A328
		public bool RadErgoCfgVAWideOutOfRange_Applicable
		{
			get
			{
				short num = (short)49454147;
				short num2 = num;
				num = (short)404921411;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1251672064;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1745616897;
				if (num != 0)
				{
				}
				num = (short)104267776;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWideOutOfRange.Applicable;
			}
			set
			{
				short num = (short)1794572289;
				if (num != 0)
				{
				}
				num = (short)1333395456;
				short num2 = num;
				num = (short)264803463;
				short num3 = num;
				num = (short)170890375;
				switch (num3 == num)
				{
				}
				num = (short)13107200;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWideOutOfRange.Applicable = value;
			}
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x060003F9 RID: 1017 RVA: 0x0003C1DC File Offset: 0x0003A3DC
		// (set) Token: 0x060003FA RID: 1018 RVA: 0x0003C290 File Offset: 0x0003A490
		public bool RadErgoCfgVAWideOutOfRange_Valid
		{
			get
			{
				short num = (short)1148518524;
				short num2 = num;
				num = (short)671678588;
				switch (num2 == num)
				{
				default:
				{
					num = (short)262537216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)784072705;
				if (num != 0)
				{
				}
				num = (short)969146368;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWideOutOfRange.Valid;
			}
			set
			{
				short num = (short)37916201;
				short num2 = num;
				num = (short)1752469033;
				switch (num2 == num)
				{
				default:
				{
					num = (short)281346048;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)180879361;
				if (num != 0)
				{
				}
				num = (short)1941372928;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWideOutOfRange.Valid = value;
			}
		}

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x060003FB RID: 1019 RVA: 0x0003C348 File Offset: 0x0003A548
		// (set) Token: 0x060003FC RID: 1020 RVA: 0x0003C400 File Offset: 0x0003A600
		public bool RadErgoCfgVAWideOutOfRange_Visible
		{
			get
			{
				short num = (short)620717177;
				short num2 = num;
				num = (short)1443128441;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1508573184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1085407233;
				if (num != 0)
				{
				}
				num = (short)272760832;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWideOutOfRange.Visible;
			}
			set
			{
				short num = (short)1730529634;
				short num2 = num;
				num = (short)1774176610;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2088697856;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)665321473;
				if (num != 0)
				{
				}
				num = (short)705560576;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWideOutOfRange.Visible = value;
			}
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x060003FD RID: 1021 RVA: 0x0003C4B4 File Offset: 0x0003A6B4
		// (set) Token: 0x060003FE RID: 1022 RVA: 0x0003C56C File Offset: 0x0003A76C
		public bool RadErgoCfgVAWideOutOfRange_Editable
		{
			get
			{
				short num = (short)1768532025;
				short num2 = num;
				num = (short)1054713913;
				switch (num2 == num)
				{
				default:
				{
					num = (short)299958272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1217593345;
				if (num != 0)
				{
				}
				num = (short)993722368;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWideOutOfRange.Editable;
			}
			set
			{
				short num = (short)722311262;
				short num2 = num;
				num = (short)1302370398;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2065104896;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1983315968;
				if (num != 0)
				{
				}
				num = (short)612696065;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWideOutOfRange.Editable = value;
			}
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x060003FF RID: 1023 RVA: 0x0003C624 File Offset: 0x0003A824
		internal string RadErgoCfgVAWideOutOfRange_UILabel
		{
			get
			{
				short num = (short)306697360;
				short num2 = num;
				num = (short)2069157008;
				switch (num2 == num)
				{
				default:
				{
					num = (short)477298688;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)736690177;
				if (num != 0)
				{
				}
				num = (short)879427584;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWideOutOfRange.UIName;
			}
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x06000400 RID: 1024 RVA: 0x0003C6D8 File Offset: 0x0003A8D8
		// (set) Token: 0x06000401 RID: 1025 RVA: 0x0003C78C File Offset: 0x0003A98C
		internal bool RadErgoCfgVAWideOutOfRange_HiddenStatic
		{
			get
			{
				short num = (short)1255756103;
				short num2 = num;
				num = (short)1366118727;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1698824192;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1034682369;
				if (num != 0)
				{
				}
				num = (short)1978793984;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWideOutOfRange.HiddenStatic;
			}
			set
			{
				short num = (short)1815872079;
				short num2 = num;
				num = (short)1527906895;
				switch (num2 == num)
				{
				default:
				{
					num = (short)215875584;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1447034880;
				if (num != 0)
				{
				}
				num = (short)1004929025;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWideOutOfRange.HiddenStatic = value;
			}
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x06000402 RID: 1026 RVA: 0x0003C844 File Offset: 0x0003AA44
		// (set) Token: 0x06000403 RID: 1027 RVA: 0x0003C8FC File Offset: 0x0003AAFC
		internal bool RadErgoCfgVAWideOutOfRange_HiddenDynamic
		{
			get
			{
				short num = (short)741314205;
				short num2 = num;
				num = (short)1280020125;
				switch (num2 == num)
				{
				default:
				{
					num = (short)192806912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2141061120;
				if (num != 0)
				{
				}
				num = (short)281214977;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWideOutOfRange.HiddenDynamic;
			}
			set
			{
				short num = (short)264559929;
				short num2 = num;
				num = (short)24829241;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2092367872;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)181403649;
				if (num != 0)
				{
				}
				num = (short)808124416;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWideOutOfRange.HiddenDynamic = value;
			}
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x06000404 RID: 1028 RVA: 0x0003C9B0 File Offset: 0x0003ABB0
		public bool RadErgoCfgVAWideOutOfRange_HasDiffs
		{
			get
			{
				short num = (short)715837039;
				short num2 = num;
				num = (short)531156591;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1293418496;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)673251328;
				if (num != 0)
				{
				}
				num = (short)1560281089;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWideOutOfRange._HasDiffs;
			}
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x06000405 RID: 1029 RVA: 0x0003CA64 File Offset: 0x0003AC64
		// (set) Token: 0x06000406 RID: 1030 RVA: 0x0003CB1C File Offset: 0x0003AD1C
		public string RadErgoOutOfRangeAnnouncementVoiceCommandValue
		{
			get
			{
				short num = (short)932505937;
				short num2 = num;
				num = (short)140765521;
				switch (num2 == num)
				{
				default:
				{
					num = (short)756678656;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1546321920;
				if (num != 0)
				{
				}
				num = (short)220856321;
				if (num != 0)
				{
				}
				return this.radErgoOutOfRangeAnnouncementVoiceCommand.Value;
			}
			set
			{
				short num = (short)1580390563;
				short num2 = num;
				num = (short)790223011;
				switch (num2 == num)
				{
				default:
				{
					num = (short)969474048;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)852557825;
				if (num != 0)
				{
				}
				num = (short)1975582720;
				if (num != 0)
				{
				}
				this.radErgoOutOfRangeAnnouncementVoiceCommand.Value = value;
			}
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x06000407 RID: 1031 RVA: 0x0003CBD4 File Offset: 0x0003ADD4
		public global::AcpBusinessLayer.AcpField<string> RadErgoOutOfRangeAnnouncementVoiceCommand
		{
			get
			{
				short num = (short)98590830;
				short num2 = num;
				num = (short)1883070574;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2019426304;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)69206016;
				if (num != 0)
				{
				}
				num = (short)1291780097;
				if (num != 0)
				{
				}
				return this.radErgoOutOfRangeAnnouncementVoiceCommand;
			}
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x06000408 RID: 1032 RVA: 0x0003CC84 File Offset: 0x0003AE84
		// (set) Token: 0x06000409 RID: 1033 RVA: 0x0003CD38 File Offset: 0x0003AF38
		public string RadErgoOutOfRangeAnnouncementVoiceCommand_UIValue
		{
			get
			{
				short num = (short)465389655;
				short num2 = num;
				num = (short)1693730903;
				switch (num2 == num)
				{
				default:
				{
					num = (short)654573568;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)119668736;
				if (num != 0)
				{
				}
				num = (short)584384513;
				if (num != 0)
				{
				}
				return this.radErgoOutOfRangeAnnouncementVoiceCommand.Value;
			}
			set
			{
				short num = (short)1556884288;
				short num2 = num;
				num = (short)1574644544;
				switch (num2 == num)
				{
				default:
				{
					num = (short)909246464;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2053308417;
				if (num != 0)
				{
				}
				num = (short)1406205952;
				if (num != 0)
				{
				}
				this.radErgoOutOfRangeAnnouncementVoiceCommand.Value = value;
			}
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x0600040A RID: 1034 RVA: 0x0003CDEC File Offset: 0x0003AFEC
		// (set) Token: 0x0600040B RID: 1035 RVA: 0x0003CEA8 File Offset: 0x0003B0A8
		public bool RadErgoOutOfRangeAnnouncementVoiceCommand_Applicable
		{
			get
			{
				short num = (short)1978864436;
				short num2 = num;
				num = (short)1743590196;
				switch (num2 == num)
				{
				default:
				{
					num = (short)984809472;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1388576768;
				if (num != 0)
				{
				}
				num = (short)668991489;
				if (num != 0)
				{
				}
				return this.radErgoOutOfRangeAnnouncementVoiceCommand.Applicable;
			}
			set
			{
				short num = (short)1466805477;
				short num2 = num;
				num = (short)1726917861;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1690173440;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)415629313;
				if (num != 0)
				{
				}
				num = (short)1771765760;
				if (num != 0)
				{
				}
				this.radErgoOutOfRangeAnnouncementVoiceCommand.Applicable = value;
			}
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x0600040C RID: 1036 RVA: 0x0003CF60 File Offset: 0x0003B160
		// (set) Token: 0x0600040D RID: 1037 RVA: 0x0003D014 File Offset: 0x0003B214
		public bool RadErgoOutOfRangeAnnouncementVoiceCommand_Valid
		{
			get
			{
				short num = (short)673764859;
				short num2 = num;
				num = (short)1933891067;
				switch (num2 == num)
				{
				default:
				{
					num = (short)636878848;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)760610817;
				if (num != 0)
				{
				}
				num = (short)996999168;
				if (num != 0)
				{
				}
				return this.radErgoOutOfRangeAnnouncementVoiceCommand.Valid;
			}
			set
			{
				short num = (short)2092042956;
				short num2 = num;
				num = (short)1481247436;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1749090304;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1920466945;
				if (num != 0)
				{
				}
				num = (short)1273364480;
				if (num != 0)
				{
				}
				this.radErgoOutOfRangeAnnouncementVoiceCommand.Valid = value;
			}
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x0600040E RID: 1038 RVA: 0x0003D0C8 File Offset: 0x0003B2C8
		// (set) Token: 0x0600040F RID: 1039 RVA: 0x0003D17C File Offset: 0x0003B37C
		public bool RadErgoOutOfRangeAnnouncementVoiceCommand_Visible
		{
			get
			{
				short num = (short)2075517553;
				short num2 = num;
				num = (short)852222577;
				switch (num2 == num)
				{
				default:
				{
					num = (short)487063552;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1530593281;
				if (num != 0)
				{
				}
				num = (short)175767552;
				if (num != 0)
				{
				}
				return this.radErgoOutOfRangeAnnouncementVoiceCommand.Visible;
			}
			set
			{
				short num = (short)815556654;
				short num2 = num;
				num = (short)878012462;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1154220032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1364393984;
				if (num != 0)
				{
				}
				num = (short)1143603201;
				if (num != 0)
				{
				}
				this.radErgoOutOfRangeAnnouncementVoiceCommand.Visible = value;
			}
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x06000410 RID: 1040 RVA: 0x0003D230 File Offset: 0x0003B430
		// (set) Token: 0x06000411 RID: 1041 RVA: 0x0003D2E8 File Offset: 0x0003B4E8
		public bool RadErgoOutOfRangeAnnouncementVoiceCommand_Editable
		{
			get
			{
				short num = (short)1362510230;
				short num2 = num;
				num = (short)209207702;
				switch (num2 == num)
				{
				}
				num = (short)1053818880;
				if (num != 0)
				{
				}
				num = (short)1660289024;
				short num3 = num;
				num = (short)1248985089;
				if (num != 0)
				{
				}
				return this.radErgoOutOfRangeAnnouncementVoiceCommand.Editable;
			}
			set
			{
				short num = (short)1160669079;
				short num2 = num;
				num = (short)1829463959;
				switch (num2 == num)
				{
				}
				num = (short)1659371521;
				if (num != 0)
				{
				}
				num = (short)1275199488;
				short num3 = num;
				num = (short)973471744;
				if (num != 0)
				{
				}
				this.radErgoOutOfRangeAnnouncementVoiceCommand.Editable = value;
			}
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x06000412 RID: 1042 RVA: 0x0003D3A0 File Offset: 0x0003B5A0
		internal string RadErgoOutOfRangeAnnouncementVoiceCommand_UILabel
		{
			get
			{
				short num = (short)1250183681;
				short num2 = num;
				num = (short)1408780801;
				switch (num2 == num)
				{
				}
				num = (short)1574109184;
				if (num != 0)
				{
				}
				num = (short)1463549952;
				short num3 = num;
				num = (short)1899167745;
				if (num != 0)
				{
				}
				return this.radErgoOutOfRangeAnnouncementVoiceCommand.UIName;
			}
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x06000413 RID: 1043 RVA: 0x0003D458 File Offset: 0x0003B658
		// (set) Token: 0x06000414 RID: 1044 RVA: 0x0003D50C File Offset: 0x0003B70C
		internal bool RadErgoOutOfRangeAnnouncementVoiceCommand_HiddenStatic
		{
			get
			{
				short num = (short)962416358;
				short num2 = num;
				num = (short)75976422;
				switch (num2 == num)
				{
				}
				num = (short)216858625;
				if (num != 0)
				{
				}
				num = (short)1388052480;
				short num3 = num;
				num = (short)944046080;
				if (num != 0)
				{
				}
				return this.radErgoOutOfRangeAnnouncementVoiceCommand.HiddenStatic;
			}
			set
			{
				short num = (short)1030637958;
				short num2 = num;
				num = (short)151734662;
				switch (num2 == num)
				{
				}
				num = (short)652607489;
				if (num != 0)
				{
				}
				num = (short)235864064;
				short num3 = num;
				num = (short)802881536;
				if (num != 0)
				{
				}
				this.radErgoOutOfRangeAnnouncementVoiceCommand.HiddenStatic = value;
			}
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x06000415 RID: 1045 RVA: 0x0003D5C0 File Offset: 0x0003B7C0
		// (set) Token: 0x06000416 RID: 1046 RVA: 0x0003D674 File Offset: 0x0003B874
		internal bool RadErgoOutOfRangeAnnouncementVoiceCommand_HiddenDynamic
		{
			get
			{
				short num = (short)2084623610;
				short num2 = num;
				num = (short)1885000954;
				switch (num2 == num)
				{
				}
				num = (short)614268928;
				if (num != 0)
				{
				}
				num = (short)668860416;
				short num3 = num;
				num = (short)1129709569;
				if (num != 0)
				{
				}
				return this.radErgoOutOfRangeAnnouncementVoiceCommand.HiddenDynamic;
			}
			set
			{
				short num = (short)586283455;
				short num2 = num;
				num = (short)2095577535;
				switch (num2 == num)
				{
				}
				num = (short)1771765760;
				if (num != 0)
				{
				}
				num = (short)1897267200;
				short num3 = num;
				num = (short)272433153;
				if (num != 0)
				{
				}
				this.radErgoOutOfRangeAnnouncementVoiceCommand.HiddenDynamic = value;
			}
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x06000417 RID: 1047 RVA: 0x0003D728 File Offset: 0x0003B928
		public bool RadErgoOutOfRangeAnnouncementVoiceCommand_HasDiffs
		{
			get
			{
				short num = (short)2042082588;
				short num2 = num;
				num = (short)941143324;
				switch (num2 == num)
				{
				}
				num = (short)146997249;
				if (num != 0)
				{
				}
				num = (short)1312751616;
				short num3 = num;
				num = (short)523304960;
				if (num != 0)
				{
				}
				return this.radErgoOutOfRangeAnnouncementVoiceCommand._HasDiffs;
			}
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x06000418 RID: 1048 RVA: 0x0003D7DC File Offset: 0x0003B9DC
		// (set) Token: 0x06000419 RID: 1049 RVA: 0x0003D890 File Offset: 0x0003BA90
		public int RadErgoCfgVAWideOverTemperatureValue
		{
			get
			{
				short num = (short)569175434;
				short num2 = num;
				num = (short)1940581770;
				switch (num2 == num)
				{
				}
				num = (short)57212929;
				if (num != 0)
				{
				}
				num = (short)634978304;
				short num3 = num;
				num = (short)2066022400;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWideOverTemperature.Value;
			}
			set
			{
				short num = (short)970705103;
				short num2 = num;
				num = (short)728221903;
				switch (num2 == num)
				{
				}
				num = (short)144506881;
				if (num != 0)
				{
				}
				num = (short)40632320;
				short num3 = num;
				num = (short)2046820352;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWideOverTemperature.Value = value;
			}
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x0600041A RID: 1050 RVA: 0x0003D948 File Offset: 0x0003BB48
		// (set) Token: 0x0600041B RID: 1051 RVA: 0x0003DA00 File Offset: 0x0003BC00
		public string RadErgoCfgVAWideOverTemperature_UIValue
		{
			get
			{
				short num = (short)398262273;
				if (num != 0)
				{
				}
				num = (short)2062955300;
				short num2 = num;
				num = (short)657470244;
				switch (num2 == num)
				{
				}
				num = (short)2013790208;
				short num3 = num;
				num = (short)149553152;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWideOverTemperature.UIValue;
			}
			set
			{
				short num = (short)828964865;
				if (num != 0)
				{
				}
				num = (short)1198004971;
				short num2 = num;
				num = (short)1703221995;
				switch (num2 == num)
				{
				}
				num = (short)654114816;
				short num3 = num;
				num = (short)1421737984;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWideOverTemperature.UIValue = value;
			}
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x0600041C RID: 1052 RVA: 0x0003DAB8 File Offset: 0x0003BCB8
		public global::AcpBusinessLayer.AcpRecRefField RadErgoCfgVAWideOverTemperature
		{
			get
			{
				short num = (short)679193683;
				short num2 = num;
				num = (short)2093263955;
				switch (num2 == num)
				{
				}
				num = (short)906952705;
				if (num != 0)
				{
				}
				num = (short)1271070720;
				short num3 = num;
				num = (short)1116995584;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWideOverTemperature;
			}
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x0600041D RID: 1053 RVA: 0x0003DB68 File Offset: 0x0003BD68
		// (set) Token: 0x0600041E RID: 1054 RVA: 0x0003DC20 File Offset: 0x0003BE20
		public bool RadErgoCfgVAWideOverTemperature_Applicable
		{
			get
			{
				short num = (short)1295403438;
				short num2 = num;
				num = (short)290539950;
				switch (num2 == num)
				{
				}
				num = (short)1632436224;
				if (num != 0)
				{
				}
				num = (short)110624768;
				short num3 = num;
				num = (short)1846345729;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWideOverTemperature.Applicable;
			}
			set
			{
				short num = (short)268830233;
				short num2 = num;
				num = (short)808781337;
				switch (num2 == num)
				{
				}
				num = (short)1801912321;
				if (num != 0)
				{
				}
				num = (short)1155203072;
				short num3 = num;
				num = (short)670629888;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWideOverTemperature.Applicable = value;
			}
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x0600041F RID: 1055 RVA: 0x0003DCD4 File Offset: 0x0003BED4
		// (set) Token: 0x06000420 RID: 1056 RVA: 0x0003DD8C File Offset: 0x0003BF8C
		public bool RadErgoCfgVAWideOverTemperature_Valid
		{
			get
			{
				short num = (short)1837727647;
				short num2 = num;
				num = (short)256737183;
				switch (num2 == num)
				{
				}
				num = (short)432799745;
				if (num != 0)
				{
				}
				num = (short)1467940864;
				short num3 = num;
				num = (short)1808269312;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWideOverTemperature.Valid;
			}
			set
			{
				short num = (short)1488869104;
				short num2 = num;
				num = (short)1655396080;
				switch (num2 == num)
				{
				}
				num = (short)1226178560;
				if (num != 0)
				{
				}
				num = (short)403701760;
				short num3 = num;
				num = (short)1371209729;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWideOverTemperature.Valid = value;
			}
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x06000421 RID: 1057 RVA: 0x0003DE40 File Offset: 0x0003C040
		// (set) Token: 0x06000422 RID: 1058 RVA: 0x0003DEF4 File Offset: 0x0003C0F4
		public bool RadErgoCfgVAWideOverTemperature_Visible
		{
			get
			{
				short num = (short)80580050;
				short num2 = num;
				num = (short)226397650;
				switch (num2 == num)
				{
				}
				num = (short)1804271617;
				if (num != 0)
				{
				}
				num = (short)395444224;
				short num3 = num;
				num = (short)1764360192;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWideOverTemperature.Visible;
			}
			set
			{
				short num = (short)1570391470;
				short num2 = num;
				num = (short)2118862254;
				switch (num2 == num)
				{
				}
				num = (short)1537605633;
				if (num != 0)
				{
				}
				num = (short)654770176;
				short num3 = num;
				num = (short)325713920;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWideOverTemperature.Visible = value;
			}
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x06000423 RID: 1059 RVA: 0x0003DFAC File Offset: 0x0003C1AC
		// (set) Token: 0x06000424 RID: 1060 RVA: 0x0003E060 File Offset: 0x0003C260
		public bool RadErgoCfgVAWideOverTemperature_Editable
		{
			get
			{
				short num = (short)1259273500;
				short num2 = num;
				num = (short)848166172;
				switch (num2 == num)
				{
				}
				num = (short)893976576;
				if (num != 0)
				{
				}
				num = (short)570228736;
				short num3 = num;
				num = (short)1536884737;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWideOverTemperature.Editable;
			}
			set
			{
				short num = (short)1424258634;
				short num2 = num;
				num = (short)600405578;
				switch (num2 == num)
				{
				}
				num = (short)1137901569;
				if (num != 0)
				{
				}
				num = (short)346750976;
				short num3 = num;
				num = (short)237895680;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWideOverTemperature.Editable = value;
			}
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x06000425 RID: 1061 RVA: 0x0003E114 File Offset: 0x0003C314
		internal string RadErgoCfgVAWideOverTemperature_UILabel
		{
			get
			{
				short num = (short)9180290;
				short num2 = num;
				num = (short)293016706;
				switch (num2 == num)
				{
				}
				num = (short)789643265;
				if (num != 0)
				{
				}
				num = (short)917176320;
				short num3 = num;
				num = (short)1605369856;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWideOverTemperature.UIName;
			}
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x06000426 RID: 1062 RVA: 0x0003E1C8 File Offset: 0x0003C3C8
		// (set) Token: 0x06000427 RID: 1063 RVA: 0x0003E27C File Offset: 0x0003C47C
		internal bool RadErgoCfgVAWideOverTemperature_HiddenStatic
		{
			get
			{
				short num = (short)1295421846;
				short num2 = num;
				num = (short)1274122646;
				switch (num2 == num)
				{
				}
				num = (short)1086390273;
				if (num != 0)
				{
				}
				num = (short)289800192;
				short num3 = num;
				num = (short)232325120;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWideOverTemperature.HiddenStatic;
			}
			set
			{
				short num = (short)920021058;
				short num2 = num;
				num = (short)1021995074;
				switch (num2 == num)
				{
				}
				num = (short)1850408960;
				if (num != 0)
				{
				}
				num = (short)861536256;
				short num3 = num;
				num = (short)383909889;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWideOverTemperature.HiddenStatic = value;
			}
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x06000428 RID: 1064 RVA: 0x0003E330 File Offset: 0x0003C530
		// (set) Token: 0x06000429 RID: 1065 RVA: 0x0003E3E4 File Offset: 0x0003C5E4
		internal bool RadErgoCfgVAWideOverTemperature_HiddenDynamic
		{
			get
			{
				short num = (short)402194433;
				if (num != 0)
				{
				}
				num = (short)1683808753;
				short num2 = num;
				num = (short)1496375793;
				switch (num2 == num)
				{
				}
				num = (short)1890648064;
				short num3 = num;
				num = (short)423362560;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWideOverTemperature.HiddenDynamic;
			}
			set
			{
				short num = (short)157111946;
				short num2 = num;
				num = (short)793269898;
				switch (num2 == num)
				{
				}
				num = (short)1884225537;
				if (num != 0)
				{
				}
				num = (short)1423966208;
				short num3 = num;
				num = (short)991821824;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWideOverTemperature.HiddenDynamic = value;
			}
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x0600042A RID: 1066 RVA: 0x0003E49C File Offset: 0x0003C69C
		public bool RadErgoCfgVAWideOverTemperature_HasDiffs
		{
			get
			{
				short num = (short)840753207;
				short num2 = num;
				num = (short)1369235511;
				switch (num2 == num)
				{
				}
				num = (short)968491009;
				if (num != 0)
				{
				}
				num = (short)1249837056;
				short num3 = num;
				num = (short)1298923520;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWideOverTemperature._HasDiffs;
			}
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x0600042B RID: 1067 RVA: 0x0003E554 File Offset: 0x0003C754
		// (set) Token: 0x0600042C RID: 1068 RVA: 0x0003E608 File Offset: 0x0003C808
		public string RadErgoOverTemperatureAnnouncementVoiceCommandValue
		{
			get
			{
				short num = (short)73291211;
				short num2 = num;
				num = (short)1795446219;
				switch (num2 == num)
				{
				}
				num = (short)1282342912;
				if (num != 0)
				{
				}
				num = (short)787349504;
				short num3 = num;
				num = (short)216334337;
				if (num != 0)
				{
				}
				return this.radErgoOverTemperatureAnnouncementVoiceCommand.Value;
			}
			set
			{
				short num = (short)519773066;
				short num2 = num;
				num = (short)1929976714;
				switch (num2 == num)
				{
				}
				num = (short)1629159425;
				if (num != 0)
				{
				}
				num = (short)1333067776;
				short num3 = num;
				num = (short)1661403136;
				if (num != 0)
				{
				}
				this.radErgoOverTemperatureAnnouncementVoiceCommand.Value = value;
			}
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x0600042D RID: 1069 RVA: 0x0003E6C0 File Offset: 0x0003C8C0
		public global::AcpBusinessLayer.AcpField<string> RadErgoOverTemperatureAnnouncementVoiceCommand
		{
			get
			{
				short num = (short)1101271608;
				short num2 = num;
				num = (short)958272056;
				switch (num2 == num)
				{
				}
				num = (short)264437761;
				if (num != 0)
				{
				}
				num = (short)1823866880;
				short num3 = num;
				num = (short)1196425216;
				if (num != 0)
				{
				}
				return this.radErgoOverTemperatureAnnouncementVoiceCommand;
			}
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x0600042E RID: 1070 RVA: 0x0003E770 File Offset: 0x0003C970
		// (set) Token: 0x0600042F RID: 1071 RVA: 0x0003E824 File Offset: 0x0003CA24
		public string RadErgoOverTemperatureAnnouncementVoiceCommand_UIValue
		{
			get
			{
				short num = (short)158385735;
				short num2 = num;
				num = (short)481084999;
				switch (num2 == num)
				{
				}
				num = (short)1898577920;
				if (num != 0)
				{
				}
				num = (short)1776746496;
				short num3 = num;
				num = (short)1722679297;
				if (num != 0)
				{
				}
				return this.radErgoOverTemperatureAnnouncementVoiceCommand.Value;
			}
			set
			{
				short num = (short)1644988859;
				short num2 = num;
				num = (short)1893435835;
				switch (num2 == num)
				{
				}
				num = (short)899284992;
				if (num != 0)
				{
				}
				num = (short)2000420864;
				short num3 = num;
				num = (short)774569985;
				if (num != 0)
				{
				}
				this.radErgoOverTemperatureAnnouncementVoiceCommand.Value = value;
			}
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x06000430 RID: 1072 RVA: 0x0003E8D8 File Offset: 0x0003CAD8
		// (set) Token: 0x06000431 RID: 1073 RVA: 0x0003E98C File Offset: 0x0003CB8C
		public bool RadErgoOverTemperatureAnnouncementVoiceCommand_Applicable
		{
			get
			{
				short num = (short)93650945;
				if (num != 0)
				{
				}
				num = (short)698228235;
				short num2 = num;
				num = (short)389946891;
				switch (num2 == num)
				{
				}
				num = (short)1491992576;
				short num3 = num;
				num = (short)946601984;
				if (num != 0)
				{
				}
				return this.radErgoOverTemperatureAnnouncementVoiceCommand.Applicable;
			}
			set
			{
				short num = (short)1132602875;
				short num2 = num;
				num = (short)1815487995;
				switch (num2 == num)
				{
				}
				num = (short)383516672;
				if (num != 0)
				{
				}
				num = (short)467927040;
				short num3 = num;
				num = (short)1366556673;
				if (num != 0)
				{
				}
				this.radErgoOverTemperatureAnnouncementVoiceCommand.Applicable = value;
			}
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x06000432 RID: 1074 RVA: 0x0003EA40 File Offset: 0x0003CC40
		// (set) Token: 0x06000433 RID: 1075 RVA: 0x0003EAF4 File Offset: 0x0003CCF4
		public bool RadErgoOverTemperatureAnnouncementVoiceCommand_Valid
		{
			get
			{
				short num = (short)221913827;
				short num2 = num;
				num = (short)324477667;
				switch (num2 == num)
				{
				}
				num = (short)1856307201;
				if (num != 0)
				{
				}
				num = (short)1312686080;
				short num3 = num;
				num = (short)871694336;
				if (num != 0)
				{
				}
				return this.radErgoOverTemperatureAnnouncementVoiceCommand.Valid;
			}
			set
			{
				short num = (short)806314442;
				short num2 = num;
				num = (short)1064788426;
				switch (num2 == num)
				{
				}
				num = (short)2023751681;
				if (num != 0)
				{
				}
				num = (short)1069023232;
				short num3 = num;
				num = (short)1700528128;
				if (num != 0)
				{
				}
				this.radErgoOverTemperatureAnnouncementVoiceCommand.Valid = value;
			}
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x06000434 RID: 1076 RVA: 0x0003EBA8 File Offset: 0x0003CDA8
		// (set) Token: 0x06000435 RID: 1077 RVA: 0x0003EC5C File Offset: 0x0003CE5C
		public bool RadErgoOverTemperatureAnnouncementVoiceCommand_Visible
		{
			get
			{
				short num = (short)724196920;
				short num2 = num;
				num = (short)1566203448;
				switch (num2 == num)
				{
				}
				num = (short)266338305;
				if (num != 0)
				{
				}
				num = (short)1303642112;
				short num3 = num;
				num = (short)658767872;
				if (num != 0)
				{
				}
				return this.radErgoOverTemperatureAnnouncementVoiceCommand.Visible;
			}
			set
			{
				short num = (short)1274825079;
				short num2 = num;
				num = (short)1877100919;
				switch (num2 == num)
				{
				}
				num = (short)651689985;
				if (num != 0)
				{
				}
				num = (short)591331328;
				short num3 = num;
				num = (short)1236402176;
				if (num != 0)
				{
				}
				this.radErgoOverTemperatureAnnouncementVoiceCommand.Visible = value;
			}
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x06000436 RID: 1078 RVA: 0x0003ED14 File Offset: 0x0003CF14
		// (set) Token: 0x06000437 RID: 1079 RVA: 0x0003EDC8 File Offset: 0x0003CFC8
		public bool RadErgoOverTemperatureAnnouncementVoiceCommand_Editable
		{
			get
			{
				short num = (short)662211338;
				short num2 = num;
				num = (short)633506570;
				switch (num2 == num)
				{
				}
				num = (short)71630848;
				short num3 = num;
				num = (short)1674379264;
				if (num != 0)
				{
				}
				num = (short)873529345;
				if (num != 0)
				{
				}
				return this.radErgoOverTemperatureAnnouncementVoiceCommand.Editable;
			}
			set
			{
				short num = (short)1318681676;
				short num2 = num;
				num = (short)45055052;
				switch (num2 == num)
				{
				}
				num = (short)944177152;
				short num3 = num;
				num = (short)227540992;
				if (num != 0)
				{
				}
				num = (short)1575092225;
				if (num != 0)
				{
				}
				this.radErgoOverTemperatureAnnouncementVoiceCommand.Editable = value;
			}
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x06000438 RID: 1080 RVA: 0x0003EE80 File Offset: 0x0003D080
		internal string RadErgoOverTemperatureAnnouncementVoiceCommand_UILabel
		{
			get
			{
				short num = (short)1106577551;
				short num2 = num;
				num = (short)2105804943;
				switch (num2 == num)
				{
				}
				num = (short)1299578880;
				short num3 = num;
				num = (short)1435566080;
				if (num != 0)
				{
				}
				num = (short)375848961;
				if (num != 0)
				{
				}
				return this.radErgoOverTemperatureAnnouncementVoiceCommand.UIName;
			}
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x06000439 RID: 1081 RVA: 0x0003EF34 File Offset: 0x0003D134
		// (set) Token: 0x0600043A RID: 1082 RVA: 0x0003EFE4 File Offset: 0x0003D1E4
		internal bool RadErgoOverTemperatureAnnouncementVoiceCommand_HiddenStatic
		{
			get
			{
				short num = (short)1369692544;
				short num2 = num;
				num = (short)964942208;
				switch (num2 == num)
				{
				}
				num = (short)287113216;
				short num3 = num;
				num = (short)2015166465;
				if (num != 0)
				{
				}
				num = (short)1420951552;
				if (num != 0)
				{
				}
				return this.radErgoOverTemperatureAnnouncementVoiceCommand.HiddenStatic;
			}
			set
			{
				short num = (short)1326776321;
				if (num != 0)
				{
				}
				num = (short)1129377710;
				short num2 = num;
				num = (short)382529454;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1610416128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2026700800;
				if (num != 0)
				{
				}
				this.radErgoOverTemperatureAnnouncementVoiceCommand.HiddenStatic = value;
			}
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x0600043B RID: 1083 RVA: 0x0003F098 File Offset: 0x0003D298
		// (set) Token: 0x0600043C RID: 1084 RVA: 0x0003F14C File Offset: 0x0003D34C
		internal bool RadErgoOverTemperatureAnnouncementVoiceCommand_HiddenDynamic
		{
			get
			{
				short num = (short)254477727;
				short num2 = num;
				num = (short)978716063;
				switch (num2 == num)
				{
				}
				num = (short)1604190208;
				short num3 = num;
				num = (short)1620508673;
				if (num != 0)
				{
				}
				num = (short)1215234048;
				if (num != 0)
				{
				}
				return this.radErgoOverTemperatureAnnouncementVoiceCommand.HiddenDynamic;
			}
			set
			{
				short num = (short)1468053037;
				short num2 = num;
				num = (short)793622061;
				switch (num2 == num)
				{
				}
				num = (short)1865875456;
				short num3 = num;
				num = (short)1432027137;
				if (num != 0)
				{
				}
				num = (short)1232666624;
				if (num != 0)
				{
				}
				this.radErgoOverTemperatureAnnouncementVoiceCommand.HiddenDynamic = value;
			}
		}

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x0600043D RID: 1085 RVA: 0x0003F204 File Offset: 0x0003D404
		public bool RadErgoOverTemperatureAnnouncementVoiceCommand_HasDiffs
		{
			get
			{
				short num = (short)1834270135;
				short num2 = num;
				num = (short)199474615;
				switch (num2 == num)
				{
				}
				num = (short)1772552192;
				short num3 = num;
				num = (short)409403393;
				if (num != 0)
				{
				}
				num = (short)1515716608;
				if (num != 0)
				{
				}
				return this.radErgoOverTemperatureAnnouncementVoiceCommand._HasDiffs;
			}
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x0600043E RID: 1086 RVA: 0x0003F2B8 File Offset: 0x0003D4B8
		// (set) Token: 0x0600043F RID: 1087 RVA: 0x0003F36C File Offset: 0x0003D56C
		public string RadErgoPowerDownAnnouncementVoiceCommandValue
		{
			get
			{
				short num = (short)1590932506;
				short num2 = num;
				num = (short)193246234;
				switch (num2 == num)
				{
				}
				num = (short)368574464;
				short num3 = num;
				num = (short)907476993;
				if (num != 0)
				{
				}
				num = (short)354287616;
				if (num != 0)
				{
				}
				return this.radErgoPowerDownAnnouncementVoiceCommand.Value;
			}
			set
			{
				short num = (short)1828388520;
				short num2 = num;
				num = (short)986185384;
				switch (num2 == num)
				{
				}
				num = (short)610140160;
				short num3 = num;
				num = (short)302448640;
				if (num != 0)
				{
				}
				num = (short)884801537;
				if (num != 0)
				{
				}
				this.radErgoPowerDownAnnouncementVoiceCommand.Value = value;
			}
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x06000440 RID: 1088 RVA: 0x0003F420 File Offset: 0x0003D620
		public global::AcpBusinessLayer.AcpField<string> RadErgoPowerDownAnnouncementVoiceCommand
		{
			get
			{
				short num = (short)1223426049;
				if (num != 0)
				{
				}
				num = (short)224404775;
				short num2 = num;
				num = (short)334243111;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1616314368;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)532807680;
				if (num != 0)
				{
				}
				return this.radErgoPowerDownAnnouncementVoiceCommand;
			}
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x06000441 RID: 1089 RVA: 0x0003F4D0 File Offset: 0x0003D6D0
		// (set) Token: 0x06000442 RID: 1090 RVA: 0x0003F584 File Offset: 0x0003D784
		public string RadErgoPowerDownAnnouncementVoiceCommand_UIValue
		{
			get
			{
				short num = (short)781292436;
				short num2 = num;
				num = (short)28480404;
				switch (num2 == num)
				{
				}
				num = (short)1490616320;
				short num3 = num;
				num = (short)406585345;
				if (num != 0)
				{
				}
				num = (short)293076992;
				if (num != 0)
				{
				}
				return this.radErgoPowerDownAnnouncementVoiceCommand.Value;
			}
			set
			{
				short num = (short)1103386101;
				short num2 = num;
				num = (short)313480693;
				switch (num2 == num)
				{
				}
				num = (short)993984512;
				short num3 = num;
				num = (short)978583553;
				if (num != 0)
				{
				}
				num = (short)1339686912;
				if (num != 0)
				{
				}
				this.radErgoPowerDownAnnouncementVoiceCommand.Value = value;
			}
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x06000443 RID: 1091 RVA: 0x0003F640 File Offset: 0x0003D840
		// (set) Token: 0x06000444 RID: 1092 RVA: 0x0003F6F4 File Offset: 0x0003D8F4
		public bool RadErgoPowerDownAnnouncementVoiceCommand_Applicable
		{
			get
			{
				short num = (short)1161185321;
				short num2 = num;
				num = (short)1180846121;
				switch (num2 == num)
				{
				}
				num = (short)1911947264;
				short num3 = num;
				num = (short)1025179648;
				if (num != 0)
				{
				}
				num = (short)1265958913;
				if (num != 0)
				{
				}
				return this.radErgoPowerDownAnnouncementVoiceCommand.Applicable;
			}
			set
			{
				short num = (short)2039858461;
				short num2 = num;
				num = (short)2032125213;
				switch (num2 == num)
				{
				}
				num = (short)24576000;
				short num3 = num;
				num = (short)609353729;
				if (num != 0)
				{
				}
				num = (short)1731067904;
				if (num != 0)
				{
				}
				this.radErgoPowerDownAnnouncementVoiceCommand.Applicable = value;
			}
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x06000445 RID: 1093 RVA: 0x0003F7AC File Offset: 0x0003D9AC
		// (set) Token: 0x06000446 RID: 1094 RVA: 0x0003F860 File Offset: 0x0003DA60
		public bool RadErgoPowerDownAnnouncementVoiceCommand_Valid
		{
			get
			{
				short num = (short)1326507348;
				short num2 = num;
				num = (short)1210180948;
				switch (num2 == num)
				{
				}
				num = (short)711131136;
				short num3 = num;
				num = (short)1375010817;
				if (num != 0)
				{
				}
				num = (short)1984430080;
				if (num != 0)
				{
				}
				return this.radErgoPowerDownAnnouncementVoiceCommand.Valid;
			}
			set
			{
				short num = (short)1291317731;
				short num2 = num;
				num = (short)388428259;
				switch (num2 == num)
				{
				}
				num = (short)144310272;
				short num3 = num;
				num = (short)272367617;
				if (num != 0)
				{
				}
				num = (short)2063138816;
				if (num != 0)
				{
				}
				this.radErgoPowerDownAnnouncementVoiceCommand.Valid = value;
			}
		}

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x06000447 RID: 1095 RVA: 0x0003F914 File Offset: 0x0003DB14
		// (set) Token: 0x06000448 RID: 1096 RVA: 0x0003F9CC File Offset: 0x0003DBCC
		public bool RadErgoPowerDownAnnouncementVoiceCommand_Visible
		{
			get
			{
				short num = (short)1933061395;
				short num2 = num;
				num = (short)1094659347;
				switch (num2 == num)
				{
				}
				num = (short)1710882816;
				short num3 = num;
				num = (short)1682505729;
				if (num != 0)
				{
				}
				num = (short)848887808;
				if (num != 0)
				{
				}
				return this.radErgoPowerDownAnnouncementVoiceCommand.Visible;
			}
			set
			{
				short num = (short)1740690945;
				short num2 = num;
				num = (short)1623119361;
				switch (num2 == num)
				{
				}
				num = (short)970719232;
				short num3 = num;
				num = (short)1640038401;
				if (num != 0)
				{
				}
				num = (short)951189504;
				if (num != 0)
				{
				}
				this.radErgoPowerDownAnnouncementVoiceCommand.Visible = value;
			}
		}

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x06000449 RID: 1097 RVA: 0x0003FA80 File Offset: 0x0003DC80
		// (set) Token: 0x0600044A RID: 1098 RVA: 0x0003FB34 File Offset: 0x0003DD34
		public bool RadErgoPowerDownAnnouncementVoiceCommand_Editable
		{
			get
			{
				short num = (short)1625948161;
				if (num != 0)
				{
				}
				num = (short)1111089599;
				short num2 = num;
				num = (short)1729552831;
				switch (num2 == num)
				{
				default:
				{
					num = (short)788201472;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)546701312;
				if (num != 0)
				{
				}
				return this.radErgoPowerDownAnnouncementVoiceCommand.Editable;
			}
			set
			{
				short num = (short)1728970753;
				if (num != 0)
				{
				}
				num = (short)2031840501;
				short num2 = num;
				num = (short)642936053;
				switch (num2 == num)
				{
				default:
				{
					num = (short)366346240;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)331939840;
				if (num != 0)
				{
				}
				this.radErgoPowerDownAnnouncementVoiceCommand.Editable = value;
			}
		}

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x0600044B RID: 1099 RVA: 0x0003FBEC File Offset: 0x0003DDEC
		internal string RadErgoPowerDownAnnouncementVoiceCommand_UILabel
		{
			get
			{
				short num = (short)1194521340;
				short num2 = num;
				num = (short)1153757948;
				switch (num2 == num)
				{
				}
				num = (short)31457280;
				short num3 = num;
				num = (short)1381302272;
				if (num != 0)
				{
				}
				num = (short)2047541249;
				if (num != 0)
				{
				}
				return this.radErgoPowerDownAnnouncementVoiceCommand.UIName;
			}
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x0600044C RID: 1100 RVA: 0x0003FCA0 File Offset: 0x0003DEA0
		// (set) Token: 0x0600044D RID: 1101 RVA: 0x0003FD50 File Offset: 0x0003DF50
		internal bool RadErgoPowerDownAnnouncementVoiceCommand_HiddenStatic
		{
			get
			{
				short num = (short)1733948611;
				short num2 = num;
				num = (short)649983171;
				switch (num2 == num)
				{
				}
				num = (short)593231872;
				short num3 = num;
				num = (short)618659841;
				if (num != 0)
				{
				}
				num = (short)419430400;
				if (num != 0)
				{
				}
				return this.radErgoPowerDownAnnouncementVoiceCommand.HiddenStatic;
			}
			set
			{
				short num = (short)242614273;
				if (num != 0)
				{
				}
				num = (short)1926996979;
				short num2 = num;
				num = (short)103785459;
				switch (num2 == num)
				{
				default:
				{
					num = (short)297992192;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)417398784;
				if (num != 0)
				{
				}
				this.radErgoPowerDownAnnouncementVoiceCommand.HiddenStatic = value;
			}
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x0600044E RID: 1102 RVA: 0x0003FE08 File Offset: 0x0003E008
		// (set) Token: 0x0600044F RID: 1103 RVA: 0x0003FEBC File Offset: 0x0003E0BC
		internal bool RadErgoPowerDownAnnouncementVoiceCommand_HiddenDynamic
		{
			get
			{
				short num = (short)1680474113;
				if (num != 0)
				{
				}
				num = (short)230005138;
				short num2 = num;
				num = (short)544184722;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1170341888;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)380698624;
				if (num != 0)
				{
				}
				return this.radErgoPowerDownAnnouncementVoiceCommand.HiddenDynamic;
			}
			set
			{
				short num = (short)1393810257;
				short num2 = num;
				num = (short)1858853713;
				switch (num2 == num)
				{
				}
				num = (short)1848836096;
				short num3 = num;
				num = (short)1595277313;
				if (num != 0)
				{
				}
				num = (short)715653120;
				if (num != 0)
				{
				}
				this.radErgoPowerDownAnnouncementVoiceCommand.HiddenDynamic = value;
			}
		}

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x06000450 RID: 1104 RVA: 0x0003FF70 File Offset: 0x0003E170
		public bool RadErgoPowerDownAnnouncementVoiceCommand_HasDiffs
		{
			get
			{
				short num = (short)638583431;
				short num2 = num;
				num = (short)1842741895;
				switch (num2 == num)
				{
				}
				num = (short)88211456;
				short num3 = num;
				num = (short)273350657;
				if (num != 0)
				{
				}
				num = (short)2015690752;
				if (num != 0)
				{
				}
				return this.radErgoPowerDownAnnouncementVoiceCommand._HasDiffs;
			}
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x06000451 RID: 1105 RVA: 0x00040024 File Offset: 0x0003E224
		// (set) Token: 0x06000452 RID: 1106 RVA: 0x000400D8 File Offset: 0x0003E2D8
		public string RadErgoAntennaFailureAnnouncementVoiceCommandValue
		{
			get
			{
				short num = (short)822870017;
				if (num != 0)
				{
				}
				num = (short)814852457;
				short num2 = num;
				num = (short)970697065;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1535901696;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)747962368;
				if (num != 0)
				{
				}
				return this.radErgoAntennaFailureAnnouncementVoiceCommand.Value;
			}
			set
			{
				short num = (short)341179616;
				short num2 = num;
				num = (short)631700704;
				switch (num2 == num)
				{
				}
				num = (short)293470208;
				short num3 = num;
				num = (short)473956352;
				if (num != 0)
				{
				}
				num = (short)1234436097;
				if (num != 0)
				{
				}
				this.radErgoAntennaFailureAnnouncementVoiceCommand.Value = value;
			}
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x06000453 RID: 1107 RVA: 0x0004018C File Offset: 0x0003E38C
		public global::AcpBusinessLayer.AcpField<string> RadErgoAntennaFailureAnnouncementVoiceCommand
		{
			get
			{
				short num = (short)1983022680;
				short num2 = num;
				num = (short)991463000;
				switch (num2 == num)
				{
				}
				num = (short)1459027968;
				short num3 = num;
				num = (short)513933312;
				if (num != 0)
				{
				}
				num = (short)756088833;
				if (num != 0)
				{
				}
				return this.radErgoAntennaFailureAnnouncementVoiceCommand;
			}
		}

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x06000454 RID: 1108 RVA: 0x00040240 File Offset: 0x0003E440
		// (set) Token: 0x06000455 RID: 1109 RVA: 0x000402F4 File Offset: 0x0003E4F4
		public string RadErgoAntennaFailureAnnouncementVoiceCommand_UIValue
		{
			get
			{
				short num = (short)1068705482;
				short num2 = num;
				num = (short)327624394;
				switch (num2 == num)
				{
				}
				num = (short)1938554880;
				short num3 = num;
				num = (short)927006721;
				if (num != 0)
				{
				}
				num = (short)1101922304;
				if (num != 0)
				{
				}
				return this.radErgoAntennaFailureAnnouncementVoiceCommand.Value;
			}
			set
			{
				short num = (short)1720427598;
				short num2 = num;
				num = (short)1802347598;
				switch (num2 == num)
				{
				}
				num = (short)1252327424;
				short num3 = num;
				num = (short)1774780416;
				if (num != 0)
				{
				}
				num = (short)806420481;
				if (num != 0)
				{
				}
				this.radErgoAntennaFailureAnnouncementVoiceCommand.Value = value;
			}
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x06000456 RID: 1110 RVA: 0x000403AC File Offset: 0x0003E5AC
		// (set) Token: 0x06000457 RID: 1111 RVA: 0x00040460 File Offset: 0x0003E660
		public bool RadErgoAntennaFailureAnnouncementVoiceCommand_Applicable
		{
			get
			{
				short num = (short)384311654;
				short num2 = num;
				num = (short)1937056102;
				switch (num2 == num)
				{
				}
				num = (short)1245380608;
				short num3 = num;
				num = (short)2040266752;
				if (num != 0)
				{
				}
				num = (short)965083137;
				if (num != 0)
				{
				}
				return this.radErgoAntennaFailureAnnouncementVoiceCommand.Applicable;
			}
			set
			{
				short num = (short)923798905;
				short num2 = num;
				num = (short)297667961;
				switch (num2 == num)
				{
				}
				num = (short)1242497024;
				short num3 = num;
				num = (short)1499922433;
				if (num != 0)
				{
				}
				num = (short)1711013888;
				if (num != 0)
				{
				}
				this.radErgoAntennaFailureAnnouncementVoiceCommand.Applicable = value;
			}
		}

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x06000458 RID: 1112 RVA: 0x00040514 File Offset: 0x0003E714
		// (set) Token: 0x06000459 RID: 1113 RVA: 0x000405C4 File Offset: 0x0003E7C4
		public bool RadErgoAntennaFailureAnnouncementVoiceCommand_Valid
		{
			get
			{
				short num = (short)1153893063;
				short num2 = num;
				num = (short)813695687;
				switch (num2 == num)
				{
				}
				num = (short)1285292032;
				short num3 = num;
				num = (short)487587841;
				if (num != 0)
				{
				}
				num = (short)203423744;
				if (num != 0)
				{
				}
				return this.radErgoAntennaFailureAnnouncementVoiceCommand.Valid;
			}
			set
			{
				short num = (short)1851509089;
				short num2 = num;
				num = (short)1275513185;
				switch (num2 == num)
				{
				}
				num = (short)926089216;
				short num3 = num;
				num = (short)1076101120;
				if (num != 0)
				{
				}
				num = (short)1220149249;
				if (num != 0)
				{
				}
				this.radErgoAntennaFailureAnnouncementVoiceCommand.Valid = value;
			}
		}

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x0600045A RID: 1114 RVA: 0x00040678 File Offset: 0x0003E878
		// (set) Token: 0x0600045B RID: 1115 RVA: 0x0004072C File Offset: 0x0003E92C
		public bool RadErgoAntennaFailureAnnouncementVoiceCommand_Visible
		{
			get
			{
				short num = (short)2045050881;
				if (num != 0)
				{
				}
				num = (short)1615983756;
				short num2 = num;
				num = (short)1555887244;
				switch (num2 == num)
				{
				default:
				{
					num = (short)969539584;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2145648640;
				if (num != 0)
				{
				}
				return this.radErgoAntennaFailureAnnouncementVoiceCommand.Visible;
			}
			set
			{
				short num = (short)1828166858;
				short num2 = num;
				num = (short)1995480266;
				switch (num2 == num)
				{
				}
				num = (short)1513553920;
				short num3 = num;
				num = (short)1191051265;
				if (num != 0)
				{
				}
				num = (short)1055653888;
				if (num != 0)
				{
				}
				this.radErgoAntennaFailureAnnouncementVoiceCommand.Visible = value;
			}
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x0600045C RID: 1116 RVA: 0x000407E0 File Offset: 0x0003E9E0
		// (set) Token: 0x0600045D RID: 1117 RVA: 0x00040894 File Offset: 0x0003EA94
		public bool RadErgoAntennaFailureAnnouncementVoiceCommand_Editable
		{
			get
			{
				short num = (short)42935507;
				short num2 = num;
				num = (short)1994335443;
				switch (num2 == num)
				{
				}
				num = (short)211222528;
				short num3 = num;
				num = (short)1553465345;
				if (num != 0)
				{
				}
				num = (short)88408064;
				if (num != 0)
				{
				}
				return this.radErgoAntennaFailureAnnouncementVoiceCommand.Editable;
			}
			set
			{
				short num = (short)122194934;
				short num2 = num;
				num = (short)682003446;
				switch (num2 == num)
				{
				}
				num = (short)1533542400;
				short num3 = num;
				num = (short)763101185;
				if (num != 0)
				{
				}
				num = (short)1150418944;
				if (num != 0)
				{
				}
				this.radErgoAntennaFailureAnnouncementVoiceCommand.Editable = value;
			}
		}

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x0600045E RID: 1118 RVA: 0x0004094C File Offset: 0x0003EB4C
		internal string RadErgoAntennaFailureAnnouncementVoiceCommand_UILabel
		{
			get
			{
				short num = (short)1150988820;
				short num2 = num;
				num = (short)174633492;
				switch (num2 == num)
				{
				}
				num = (short)554303488;
				short num3 = num;
				num = (short)27394049;
				if (num != 0)
				{
				}
				num = (short)1964703744;
				if (num != 0)
				{
				}
				return this.radErgoAntennaFailureAnnouncementVoiceCommand.UIName;
			}
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x0600045F RID: 1119 RVA: 0x00040A00 File Offset: 0x0003EC00
		// (set) Token: 0x06000460 RID: 1120 RVA: 0x00040AB4 File Offset: 0x0003ECB4
		internal bool RadErgoAntennaFailureAnnouncementVoiceCommand_HiddenStatic
		{
			get
			{
				short num = (short)270672953;
				short num2 = num;
				num = (short)1712858169;
				switch (num2 == num)
				{
				}
				num = (short)1988952064;
				short num3 = num;
				num = (short)248971265;
				if (num != 0)
				{
				}
				num = (short)96010240;
				if (num != 0)
				{
				}
				return this.radErgoAntennaFailureAnnouncementVoiceCommand.HiddenStatic;
			}
			set
			{
				short num = (short)1206493807;
				short num2 = num;
				num = (short)1364238959;
				switch (num2 == num)
				{
				}
				num = (short)1514471424;
				short num3 = num;
				num = (short)1302986753;
				if (num != 0)
				{
				}
				num = (short)823590912;
				if (num != 0)
				{
				}
				this.radErgoAntennaFailureAnnouncementVoiceCommand.HiddenStatic = value;
			}
		}

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x06000461 RID: 1121 RVA: 0x00040B68 File Offset: 0x0003ED68
		// (set) Token: 0x06000462 RID: 1122 RVA: 0x00040C18 File Offset: 0x0003EE18
		internal bool RadErgoAntennaFailureAnnouncementVoiceCommand_HiddenDynamic
		{
			get
			{
				short num = (short)1785258382;
				short num2 = num;
				num = (short)1155981710;
				switch (num2 == num)
				{
				}
				num = (short)1947992064;
				short num3 = num;
				num = (short)1141964801;
				if (num != 0)
				{
				}
				num = (short)1387724800;
				if (num != 0)
				{
				}
				return this.radErgoAntennaFailureAnnouncementVoiceCommand.HiddenDynamic;
			}
			set
			{
				short num = (short)998650019;
				short num2 = num;
				num = (short)2123575459;
				switch (num2 == num)
				{
				}
				num = (short)1403387904;
				short num3 = num;
				num = (short)384172032;
				if (num != 0)
				{
				}
				num = (short)1024655361;
				if (num != 0)
				{
				}
				this.radErgoAntennaFailureAnnouncementVoiceCommand.HiddenDynamic = value;
			}
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x06000463 RID: 1123 RVA: 0x00040CCC File Offset: 0x0003EECC
		public bool RadErgoAntennaFailureAnnouncementVoiceCommand_HasDiffs
		{
			get
			{
				short num = (short)330794997;
				short num2 = num;
				num = (short)839682037;
				switch (num2 == num)
				{
				}
				num = (short)1375797248;
				short num3 = num;
				num = (short)690094081;
				if (num != 0)
				{
				}
				num = (short)1346633728;
				if (num != 0)
				{
				}
				return this.radErgoAntennaFailureAnnouncementVoiceCommand._HasDiffs;
			}
		}

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x06000464 RID: 1124 RVA: 0x00040D80 File Offset: 0x0003EF80
		// (set) Token: 0x06000465 RID: 1125 RVA: 0x00040E34 File Offset: 0x0003F034
		public int RadErgoCfgVAWidePowerDownValue
		{
			get
			{
				short num = (short)911981635;
				short num2 = num;
				num = (short)1264368707;
				switch (num2 == num)
				{
				}
				num = (short)2025259008;
				short num3 = num;
				num = (short)523829249;
				if (num != 0)
				{
				}
				num = (short)496435200;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWidePowerDown.Value;
			}
			set
			{
				short num = (short)2089909789;
				short num2 = num;
				num = (short)517111325;
				switch (num2 == num)
				{
				}
				num = (short)924385280;
				short num3 = num;
				num = (short)1104609280;
				if (num != 0)
				{
				}
				num = (short)325779457;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWidePowerDown.Value = value;
			}
		}

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x06000466 RID: 1126 RVA: 0x00040EE8 File Offset: 0x0003F0E8
		// (set) Token: 0x06000467 RID: 1127 RVA: 0x00040F9C File Offset: 0x0003F19C
		public string RadErgoCfgVAWidePowerDown_UIValue
		{
			get
			{
				short num = (short)1494402205;
				short num2 = num;
				num = (short)1030079645;
				switch (num2 == num)
				{
				}
				num = (short)2052325376;
				short num3 = num;
				num = (short)202113025;
				if (num != 0)
				{
				}
				num = (short)1307836416;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWidePowerDown.UIValue;
			}
			set
			{
				short num = (short)998783158;
				short num2 = num;
				num = (short)555759798;
				switch (num2 == num)
				{
				}
				num = (short)84017152;
				short num3 = num;
				num = (short)1222901760;
				if (num != 0)
				{
				}
				num = (short)985137153;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWidePowerDown.UIValue = value;
			}
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x06000468 RID: 1128 RVA: 0x00041050 File Offset: 0x0003F250
		public global::AcpBusinessLayer.AcpRecRefField RadErgoCfgVAWidePowerDown
		{
			get
			{
				short num = (short)1759327256;
				short num2 = num;
				num = (short)33240088;
				switch (num2 == num)
				{
				}
				num = (short)1120993280;
				short num3 = num;
				num = (short)1025966081;
				if (num != 0)
				{
				}
				num = (short)1250230272;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWidePowerDown;
			}
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x06000469 RID: 1129 RVA: 0x00041100 File Offset: 0x0003F300
		// (set) Token: 0x0600046A RID: 1130 RVA: 0x000411B4 File Offset: 0x0003F3B4
		public bool RadErgoCfgVAWidePowerDown_Applicable
		{
			get
			{
				short num = (short)1180104143;
				short num2 = num;
				num = (short)82179535;
				switch (num2 == num)
				{
				}
				num = (short)1938882560;
				short num3 = num;
				num = (short)1129775105;
				if (num != 0)
				{
				}
				num = (short)1812463616;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWidePowerDown.Applicable;
			}
			set
			{
				short num = (short)1039859713;
				if (num != 0)
				{
				}
				num = (short)1156418505;
				short num2 = num;
				num = (short)840207305;
				switch (num2 == num)
				{
				}
				num = (short)945815552;
				if (num != 0)
				{
				}
				num = (short)1423900672;
				short num3 = num;
				this.radErgoCfgVAWidePowerDown.Applicable = value;
			}
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x0600046B RID: 1131 RVA: 0x00041268 File Offset: 0x0003F468
		// (set) Token: 0x0600046C RID: 1132 RVA: 0x0004131C File Offset: 0x0003F51C
		public bool RadErgoCfgVAWidePowerDown_Valid
		{
			get
			{
				short num = (short)2059893881;
				short num2 = num;
				num = (short)1940552825;
				switch (num2 == num)
				{
				}
				num = (short)1221066753;
				if (num != 0)
				{
				}
				num = (short)756940800;
				if (num != 0)
				{
				}
				num = (short)789708800;
				short num3 = num;
				return this.radErgoCfgVAWidePowerDown.Valid;
			}
			set
			{
				short num = (short)932174978;
				short num2 = num;
				num = (short)1862982786;
				switch (num2 == num)
				{
				}
				num = (short)343867393;
				if (num != 0)
				{
				}
				num = (short)1193410560;
				if (num != 0)
				{
				}
				num = (short)1896284160;
				short num3 = num;
				this.radErgoCfgVAWidePowerDown.Valid = value;
			}
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x0600046D RID: 1133 RVA: 0x000413D0 File Offset: 0x0003F5D0
		// (set) Token: 0x0600046E RID: 1134 RVA: 0x00041488 File Offset: 0x0003F688
		public bool RadErgoCfgVAWidePowerDown_Visible
		{
			get
			{
				short num = (short)1716387841;
				if (num != 0)
				{
				}
				num = (short)811243534;
				short num2 = num;
				num = (short)1445697550;
				switch (num2 == num)
				{
				}
				num = (short)2014576640;
				if (num != 0)
				{
				}
				num = (short)2029387776;
				short num3 = num;
				return this.radErgoCfgVAWidePowerDown.Visible;
			}
			set
			{
				short num = (short)2078181257;
				short num2 = num;
				num = (short)1420396425;
				switch (num2 == num)
				{
				}
				num = (short)235995137;
				if (num != 0)
				{
				}
				num = (short)323026944;
				if (num != 0)
				{
				}
				num = (short)245301248;
				short num3 = num;
				this.radErgoCfgVAWidePowerDown.Visible = value;
			}
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x0600046F RID: 1135 RVA: 0x0004153C File Offset: 0x0003F73C
		// (set) Token: 0x06000470 RID: 1136 RVA: 0x000415F4 File Offset: 0x0003F7F4
		public bool RadErgoCfgVAWidePowerDown_Editable
		{
			get
			{
				short num = (short)1684759708;
				short num2 = num;
				num = (short)628515996;
				switch (num2 == num)
				{
				}
				num = (short)376635392;
				if (num != 0)
				{
				}
				num = (short)259391489;
				if (num != 0)
				{
				}
				num = (short)906690560;
				short num3 = num;
				return this.radErgoCfgVAWidePowerDown.Editable;
			}
			set
			{
				short num = (short)982925293;
				short num2 = num;
				num = (short)1160265709;
				switch (num2 == num)
				{
				}
				num = (short)1295319041;
				if (num != 0)
				{
				}
				num = (short)396492800;
				if (num != 0)
				{
				}
				num = (short)312934400;
				short num3 = num;
				this.radErgoCfgVAWidePowerDown.Editable = value;
			}
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x06000471 RID: 1137 RVA: 0x000416A8 File Offset: 0x0003F8A8
		internal string RadErgoCfgVAWidePowerDown_UILabel
		{
			get
			{
				short num = (short)465245277;
				short num2 = num;
				num = (short)369562717;
				switch (num2 == num)
				{
				}
				num = (short)266731520;
				if (num != 0)
				{
				}
				num = (short)1171128321;
				if (num != 0)
				{
				}
				num = (short)1646264320;
				short num3 = num;
				return this.radErgoCfgVAWidePowerDown.UIName;
			}
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x06000472 RID: 1138 RVA: 0x0004175C File Offset: 0x0003F95C
		// (set) Token: 0x06000473 RID: 1139 RVA: 0x00041810 File Offset: 0x0003FA10
		internal bool RadErgoCfgVAWidePowerDown_HiddenStatic
		{
			get
			{
				short num = (short)1301676824;
				short num2 = num;
				num = (short)557843224;
				switch (num2 == num)
				{
				}
				num = (short)1756823553;
				if (num != 0)
				{
				}
				num = (short)1796145152;
				if (num != 0)
				{
				}
				num = (short)1938554880;
				short num3 = num;
				return this.radErgoCfgVAWidePowerDown.HiddenStatic;
			}
			set
			{
				short num = (short)286330052;
				short num2 = num;
				num = (short)1681984708;
				switch (num2 == num)
				{
				}
				num = (short)1890189313;
				if (num != 0)
				{
				}
				num = (short)224002048;
				if (num != 0)
				{
				}
				num = (short)1073086464;
				short num3 = num;
				this.radErgoCfgVAWidePowerDown.HiddenStatic = value;
			}
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x06000474 RID: 1140 RVA: 0x000418C8 File Offset: 0x0003FAC8
		// (set) Token: 0x06000475 RID: 1141 RVA: 0x00041980 File Offset: 0x0003FB80
		internal bool RadErgoCfgVAWidePowerDown_HiddenDynamic
		{
			get
			{
				short num = (short)1623507158;
				short num2 = num;
				num = (short)1865466070;
				switch (num2 == num)
				{
				}
				num = (short)139264001;
				if (num != 0)
				{
				}
				num = (short)862781440;
				if (num != 0)
				{
				}
				num = (short)40435712;
				short num3 = num;
				return this.radErgoCfgVAWidePowerDown.HiddenDynamic;
			}
			set
			{
				short num = (short)174665153;
				short num2 = num;
				num = (short)223555009;
				switch (num2 == num)
				{
				}
				num = (short)1485045761;
				if (num != 0)
				{
				}
				num = (short)1804664832;
				if (num != 0)
				{
				}
				num = (short)1303248896;
				short num3 = num;
				this.radErgoCfgVAWidePowerDown.HiddenDynamic = value;
			}
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x06000476 RID: 1142 RVA: 0x00041A38 File Offset: 0x0003FC38
		public bool RadErgoCfgVAWidePowerDown_HasDiffs
		{
			get
			{
				short num = (short)408016862;
				short num2 = num;
				num = (short)204724190;
				switch (num2 == num)
				{
				}
				num = (short)1880227840;
				if (num != 0)
				{
				}
				num = (short)976355329;
				if (num != 0)
				{
				}
				num = (short)117702656;
				short num3 = num;
				return this.radErgoCfgVAWidePowerDown._HasDiffs;
			}
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x06000477 RID: 1143 RVA: 0x00041AE8 File Offset: 0x0003FCE8
		// (set) Token: 0x06000478 RID: 1144 RVA: 0x00041B9C File Offset: 0x0003FD9C
		public int RadErgoCfgVAWideAntennaFailureValue
		{
			get
			{
				short num = (short)188842200;
				short num2 = num;
				num = (short)1073971416;
				switch (num2 == num)
				{
				}
				num = (short)1521352705;
				if (num != 0)
				{
				}
				num = (short)646905856;
				if (num != 0)
				{
				}
				num = (short)739704832;
				short num3 = num;
				return this.radErgoCfgVAWideAntennaFailure.Value;
			}
			set
			{
				short num = (short)319189550;
				short num2 = num;
				num = (short)1884123694;
				switch (num2 == num)
				{
				}
				num = (short)1410072577;
				if (num != 0)
				{
				}
				num = (short)1725825024;
				if (num != 0)
				{
				}
				num = (short)1070399488;
				short num3 = num;
				this.radErgoCfgVAWideAntennaFailure.Value = value;
			}
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x06000479 RID: 1145 RVA: 0x00041C50 File Offset: 0x0003FE50
		// (set) Token: 0x0600047A RID: 1146 RVA: 0x00041D04 File Offset: 0x0003FF04
		public string RadErgoCfgVAWideAntennaFailure_UIValue
		{
			get
			{
				short num = (short)880232572;
				short num2 = num;
				num = (short)961824892;
				switch (num2 == num)
				{
				}
				num = (short)702087169;
				if (num != 0)
				{
				}
				num = (short)247595008;
				if (num != 0)
				{
				}
				num = (short)1653473280;
				short num3 = num;
				return this.radErgoCfgVAWideAntennaFailure.UIValue;
			}
			set
			{
				short num = (short)83510626;
				short num2 = num;
				num = (short)1120159074;
				switch (num2 == num)
				{
				}
				num = (short)1617100801;
				if (num != 0)
				{
				}
				num = (short)856948736;
				if (num != 0)
				{
				}
				num = (short)1279262720;
				short num3 = num;
				this.radErgoCfgVAWideAntennaFailure.UIValue = value;
			}
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x0600047B RID: 1147 RVA: 0x00041DC0 File Offset: 0x0003FFC0
		public global::AcpBusinessLayer.AcpRecRefField RadErgoCfgVAWideAntennaFailure
		{
			get
			{
				short num = (short)250280891;
				short num2 = num;
				num = (short)276560827;
				switch (num2 == num)
				{
				}
				num = (short)873005057;
				if (num != 0)
				{
				}
				num = (short)88080384;
				if (num != 0)
				{
				}
				num = (short)1766457344;
				short num3 = num;
				return this.radErgoCfgVAWideAntennaFailure;
			}
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x0600047C RID: 1148 RVA: 0x00041E70 File Offset: 0x00040070
		// (set) Token: 0x0600047D RID: 1149 RVA: 0x00041F28 File Offset: 0x00040128
		public bool RadErgoCfgVAWideAntennaFailure_Applicable
		{
			get
			{
				short num = (short)1442246855;
				short num2 = num;
				num = (short)2067591367;
				switch (num2 == num)
				{
				}
				num = (short)975241217;
				if (num != 0)
				{
				}
				num = (short)1923612672;
				if (num != 0)
				{
				}
				num = (short)1582170112;
				short num3 = num;
				return this.radErgoCfgVAWideAntennaFailure.Applicable;
			}
			set
			{
				short num = (short)1453937944;
				short num2 = num;
				num = (short)511202584;
				switch (num2 == num)
				{
				}
				num = (short)1539112960;
				if (num != 0)
				{
				}
				num = (short)1270415361;
				if (num != 0)
				{
				}
				num = (short)586088448;
				short num3 = num;
				this.radErgoCfgVAWideAntennaFailure.Applicable = value;
			}
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x0600047E RID: 1150 RVA: 0x00041FE0 File Offset: 0x000401E0
		// (set) Token: 0x0600047F RID: 1151 RVA: 0x00042094 File Offset: 0x00040294
		public bool RadErgoCfgVAWideAntennaFailure_Valid
		{
			get
			{
				short num = (short)2134378560;
				short num2 = num;
				num = (short)107153472;
				switch (num2 == num)
				{
				}
				num = (short)2107113472;
				if (num != 0)
				{
				}
				num = (short)1446313985;
				if (num != 0)
				{
				}
				num = (short)1136197632;
				short num3 = num;
				return this.radErgoCfgVAWideAntennaFailure.Valid;
			}
			set
			{
				short num = (short)111823370;
				short num2 = num;
				num = (short)1840859658;
				switch (num2 == num)
				{
				}
				num = (short)735313920;
				if (num != 0)
				{
				}
				num = (short)1767440385;
				if (num != 0)
				{
				}
				num = (short)1338834944;
				short num3 = num;
				this.radErgoCfgVAWideAntennaFailure.Valid = value;
			}
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x06000480 RID: 1152 RVA: 0x00042148 File Offset: 0x00040348
		// (set) Token: 0x06000481 RID: 1153 RVA: 0x00042200 File Offset: 0x00040400
		public bool RadErgoCfgVAWideAntennaFailure_Visible
		{
			get
			{
				short num = (short)639709098;
				short num2 = num;
				num = (short)541994922;
				switch (num2 == num)
				{
				}
				num = (short)602996736;
				if (num != 0)
				{
				}
				num = (short)1249116161;
				if (num != 0)
				{
				}
				num = (short)486866944;
				short num3 = num;
				return this.radErgoCfgVAWideAntennaFailure.Visible;
			}
			set
			{
				short num = (short)2073708731;
				short num2 = num;
				num = (short)1280329915;
				switch (num2 == num)
				{
				}
				num = (short)1514864641;
				if (num != 0)
				{
				}
				num = (short)171048960;
				if (num != 0)
				{
				}
				num = (short)1689583616;
				short num3 = num;
				this.radErgoCfgVAWideAntennaFailure.Visible = value;
			}
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x06000482 RID: 1154 RVA: 0x000422B4 File Offset: 0x000404B4
		// (set) Token: 0x06000483 RID: 1155 RVA: 0x00042368 File Offset: 0x00040568
		public bool RadErgoCfgVAWideAntennaFailure_Editable
		{
			get
			{
				short num = (short)685527180;
				short num2 = num;
				num = (short)55005324;
				switch (num2 == num)
				{
				}
				num = (short)1453326337;
				if (num != 0)
				{
				}
				num = (short)979566592;
				if (num != 0)
				{
				}
				num = (short)802947072;
				short num3 = num;
				return this.radErgoCfgVAWideAntennaFailure.Editable;
			}
			set
			{
				short num = (short)1428558644;
				short num2 = num;
				num = (short)2145719092;
				switch (num2 == num)
				{
				}
				num = (short)624820225;
				if (num != 0)
				{
				}
				num = (short)2119172096;
				if (num != 0)
				{
				}
				num = (short)1940979712;
				short num3 = num;
				this.radErgoCfgVAWideAntennaFailure.Editable = value;
			}
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x06000484 RID: 1156 RVA: 0x0004241C File Offset: 0x0004061C
		internal string RadErgoCfgVAWideAntennaFailure_UILabel
		{
			get
			{
				short num = (short)1907716943;
				short num2 = num;
				num = (short)358576975;
				switch (num2 == num)
				{
				}
				num = (short)760348673;
				if (num != 0)
				{
				}
				num = (short)1665859584;
				if (num != 0)
				{
				}
				num = (short)1352073216;
				short num3 = num;
				return this.radErgoCfgVAWideAntennaFailure.UIName;
			}
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x06000485 RID: 1157 RVA: 0x000424D0 File Offset: 0x000406D0
		// (set) Token: 0x06000486 RID: 1158 RVA: 0x00042588 File Offset: 0x00040788
		internal bool RadErgoCfgVAWideAntennaFailure_HiddenStatic
		{
			get
			{
				short num = (short)1306071453;
				short num2 = num;
				num = (short)610275741;
				switch (num2 == num)
				{
				}
				num = (short)1606549504;
				if (num != 0)
				{
				}
				num = (short)1791623169;
				if (num != 0)
				{
				}
				num = (short)1674313728;
				short num3 = num;
				return this.radErgoCfgVAWideAntennaFailure.HiddenStatic;
			}
			set
			{
				short num = (short)879042318;
				short num2 = num;
				num = (short)1847074574;
				switch (num2 == num)
				{
				}
				num = (short)846200833;
				if (num != 0)
				{
				}
				num = (short)839450624;
				if (num != 0)
				{
				}
				num = (short)1711603712;
				short num3 = num;
				this.radErgoCfgVAWideAntennaFailure.HiddenStatic = value;
			}
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x06000487 RID: 1159 RVA: 0x00042640 File Offset: 0x00040840
		// (set) Token: 0x06000488 RID: 1160 RVA: 0x000426F4 File Offset: 0x000408F4
		internal bool RadErgoCfgVAWideAntennaFailure_HiddenDynamic
		{
			get
			{
				short num = (short)561480809;
				short num2 = num;
				num = (short)1566540905;
				switch (num2 == num)
				{
				}
				num = (short)697499649;
				if (num != 0)
				{
				}
				num = (short)650706944;
				if (num != 0)
				{
				}
				num = (short)475922432;
				short num3 = num;
				return this.radErgoCfgVAWideAntennaFailure.HiddenDynamic;
			}
			set
			{
				short num = (short)303949003;
				short num2 = num;
				num = (short)2061952203;
				switch (num2 == num)
				{
				}
				num = (short)1832124416;
				if (num != 0)
				{
				}
				num = (short)1672937473;
				if (num != 0)
				{
				}
				num = (short)478478336;
				short num3 = num;
				this.radErgoCfgVAWideAntennaFailure.HiddenDynamic = value;
			}
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x06000489 RID: 1161 RVA: 0x000427A8 File Offset: 0x000409A8
		public bool RadErgoCfgVAWideAntennaFailure_HasDiffs
		{
			get
			{
				short num = (short)170574890;
				short num2 = num;
				num = (short)1591723050;
				switch (num2 == num)
				{
				}
				num = (short)173932545;
				if (num != 0)
				{
				}
				num = (short)596115456;
				if (num != 0)
				{
				}
				num = (short)258146304;
				short num3 = num;
				return this.radErgoCfgVAWideAntennaFailure._HasDiffs;
			}
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x0600048A RID: 1162 RVA: 0x00042860 File Offset: 0x00040A60
		// (set) Token: 0x0600048B RID: 1163 RVA: 0x00042914 File Offset: 0x00040B14
		public int RadErgoCfgVAWideRFDeviceCumulativeOverTemperatureValue
		{
			get
			{
				short num = (short)2055295552;
				short num2 = num;
				num = (short)646074944;
				switch (num2 == num)
				{
				}
				num = (short)1410203649;
				if (num != 0)
				{
				}
				num = (short)319815680;
				if (num != 0)
				{
				}
				num = (short)342425600;
				short num3 = num;
				return this.radErgoCfgVAWideRFDeviceCumulativeOverTemperature.Value;
			}
			set
			{
				short num = (short)487403770;
				short num2 = num;
				num = (short)1540436218;
				switch (num2 == num)
				{
				}
				num = (short)1936982016;
				if (num != 0)
				{
				}
				num = (short)845414401;
				if (num != 0)
				{
				}
				num = (short)1733296128;
				short num3 = num;
				this.radErgoCfgVAWideRFDeviceCumulativeOverTemperature.Value = value;
			}
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x0600048C RID: 1164 RVA: 0x000429CC File Offset: 0x00040BCC
		// (set) Token: 0x0600048D RID: 1165 RVA: 0x00042A80 File Offset: 0x00040C80
		public string RadErgoCfgVAWideRFDeviceCumulativeOverTemperature_UIValue
		{
			get
			{
				short num = (short)77731972;
				short num2 = num;
				num = (short)1384650884;
				switch (num2 == num)
				{
				}
				num = (short)755171328;
				if (num != 0)
				{
				}
				num = (short)265289729;
				if (num != 0)
				{
				}
				num = (short)1564868608;
				short num3 = num;
				return this.radErgoCfgVAWideRFDeviceCumulativeOverTemperature.UIValue;
			}
			set
			{
				short num = (short)678929645;
				short num2 = num;
				num = (short)845063405;
				switch (num2 == num)
				{
				}
				num = (short)1352663041;
				if (num != 0)
				{
				}
				num = (short)1145307136;
				if (num != 0)
				{
				}
				num = (short)1287585792;
				short num3 = num;
				this.radErgoCfgVAWideRFDeviceCumulativeOverTemperature.UIValue = value;
			}
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x0600048E RID: 1166 RVA: 0x00042B38 File Offset: 0x00040D38
		public global::AcpBusinessLayer.AcpRecRefField RadErgoCfgVAWideRFDeviceCumulativeOverTemperature
		{
			get
			{
				short num = (short)1869230326;
				short num2 = num;
				num = (short)121778422;
				switch (num2 == num)
				{
				}
				num = (short)2066808832;
				if (num != 0)
				{
				}
				num = (short)1505951745;
				if (num != 0)
				{
				}
				num = (short)247791616;
				short num3 = num;
				return this.radErgoCfgVAWideRFDeviceCumulativeOverTemperature;
			}
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x0600048F RID: 1167 RVA: 0x00042BE8 File Offset: 0x00040DE8
		// (set) Token: 0x06000490 RID: 1168 RVA: 0x00042C98 File Offset: 0x00040E98
		public bool RadErgoCfgVAWideRFDeviceCumulativeOverTemperature_Applicable
		{
			get
			{
				short num = (short)1389783737;
				short num2 = num;
				num = (short)1719233209;
				switch (num2 == num)
				{
				}
				num = (short)996933633;
				if (num != 0)
				{
				}
				num = (short)1980170240;
				if (num != 0)
				{
				}
				num = (short)95944704;
				short num3 = num;
				return this.radErgoCfgVAWideRFDeviceCumulativeOverTemperature.Applicable;
			}
			set
			{
				short num = (short)1740325336;
				short num2 = num;
				num = (short)2014790104;
				switch (num2 == num)
				{
				}
				num = (short)890765313;
				if (num != 0)
				{
				}
				num = (short)1535639552;
				if (num != 0)
				{
				}
				num = (short)1982922752;
				short num3 = num;
				this.radErgoCfgVAWideRFDeviceCumulativeOverTemperature.Applicable = value;
			}
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x06000491 RID: 1169 RVA: 0x00042D4C File Offset: 0x00040F4C
		// (set) Token: 0x06000492 RID: 1170 RVA: 0x00042E00 File Offset: 0x00041000
		public bool RadErgoCfgVAWideRFDeviceCumulativeOverTemperature_Valid
		{
			get
			{
				short num = (short)1227788272;
				short num2 = num;
				num = (short)844599280;
				switch (num2 == num)
				{
				}
				num = (short)926416897;
				if (num != 0)
				{
				}
				num = (short)1307901952;
				if (num != 0)
				{
				}
				num = (short)1330642944;
				short num3 = num;
				return this.radErgoCfgVAWideRFDeviceCumulativeOverTemperature.Valid;
			}
			set
			{
				short num = (short)1769668609;
				if (num != 0)
				{
				}
				num = (short)587750620;
				short num2 = num;
				num = (short)200826076;
				switch (num2 == num)
				{
				}
				num = (short)1163984896;
				if (num != 0)
				{
				}
				num = (short)850591744;
				short num3 = num;
				this.radErgoCfgVAWideRFDeviceCumulativeOverTemperature.Valid = value;
			}
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x06000493 RID: 1171 RVA: 0x00042EB8 File Offset: 0x000410B8
		// (set) Token: 0x06000494 RID: 1172 RVA: 0x00042F6C File Offset: 0x0004116C
		public bool RadErgoCfgVAWideRFDeviceCumulativeOverTemperature_Visible
		{
			get
			{
				short num = (short)1797460086;
				short num2 = num;
				num = (short)1218449526;
				switch (num2 == num)
				{
				}
				num = (short)670760960;
				if (num != 0)
				{
				}
				num = (short)1638596609;
				if (num != 0)
				{
				}
				num = (short)58851328;
				short num3 = num;
				return this.radErgoCfgVAWideRFDeviceCumulativeOverTemperature.Visible;
			}
			set
			{
				short num = (short)729516254;
				short num2 = num;
				num = (short)1104775390;
				switch (num2 == num)
				{
				}
				num = (short)1219624961;
				if (num != 0)
				{
				}
				num = (short)1495007232;
				if (num != 0)
				{
				}
				num = (short)1435893760;
				short num3 = num;
				this.radErgoCfgVAWideRFDeviceCumulativeOverTemperature.Visible = value;
			}
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x06000495 RID: 1173 RVA: 0x00043020 File Offset: 0x00041220
		// (set) Token: 0x06000496 RID: 1174 RVA: 0x000430D4 File Offset: 0x000412D4
		public bool RadErgoCfgVAWideRFDeviceCumulativeOverTemperature_Editable
		{
			get
			{
				short num = (short)343713104;
				short num2 = num;
				num = (short)1578149200;
				switch (num2 == num)
				{
				}
				num = (short)1350631425;
				if (num != 0)
				{
				}
				num = (short)546177024;
				if (num != 0)
				{
				}
				num = (short)1299972096;
				short num3 = num;
				return this.radErgoCfgVAWideRFDeviceCumulativeOverTemperature.Editable;
			}
			set
			{
				short num = (short)1324089345;
				if (num != 0)
				{
				}
				num = (short)1249076067;
				short num2 = num;
				num = (short)150561635;
				switch (num2 == num)
				{
				}
				num = (short)1613365248;
				if (num != 0)
				{
				}
				num = (short)347865088;
				short num3 = num;
				this.radErgoCfgVAWideRFDeviceCumulativeOverTemperature.Editable = value;
			}
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x06000497 RID: 1175 RVA: 0x00043188 File Offset: 0x00041388
		internal string RadErgoCfgVAWideRFDeviceCumulativeOverTemperature_UILabel
		{
			get
			{
				short num = (short)1332704430;
				short num2 = num;
				num = (short)1495495854;
				switch (num2 == num)
				{
				}
				num = (short)1295712256;
				if (num != 0)
				{
				}
				num = (short)753401857;
				if (num != 0)
				{
				}
				num = (short)1963655168;
				short num3 = num;
				return this.radErgoCfgVAWideRFDeviceCumulativeOverTemperature.UIName;
			}
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x06000498 RID: 1176 RVA: 0x0004323C File Offset: 0x0004143C
		// (set) Token: 0x06000499 RID: 1177 RVA: 0x000432F0 File Offset: 0x000414F0
		internal bool RadErgoCfgVAWideRFDeviceCumulativeOverTemperature_HiddenStatic
		{
			get
			{
				short num = (short)1122306480;
				short num2 = num;
				num = (short)766839216;
				switch (num2 == num)
				{
				}
				num = (short)1273036800;
				if (num != 0)
				{
				}
				num = (short)848756737;
				if (num != 0)
				{
				}
				num = (short)982843392;
				short num3 = num;
				return this.radErgoCfgVAWideRFDeviceCumulativeOverTemperature.HiddenStatic;
			}
			set
			{
				short num = (short)674869195;
				short num2 = num;
				num = (short)1076867019;
				switch (num2 == num)
				{
				}
				num = (short)1586823169;
				if (num != 0)
				{
				}
				num = (short)278069248;
				if (num != 0)
				{
				}
				num = (short)2132606976;
				short num3 = num;
				this.radErgoCfgVAWideRFDeviceCumulativeOverTemperature.HiddenStatic = value;
			}
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x0600049A RID: 1178 RVA: 0x000433A8 File Offset: 0x000415A8
		// (set) Token: 0x0600049B RID: 1179 RVA: 0x00043460 File Offset: 0x00041660
		internal bool RadErgoCfgVAWideRFDeviceCumulativeOverTemperature_HiddenDynamic
		{
			get
			{
				short num = (short)1320359367;
				short num2 = num;
				num = (short)918296007;
				switch (num2 == num)
				{
				}
				num = (short)180879360;
				if (num != 0)
				{
				}
				num = (short)1291649025;
				if (num != 0)
				{
				}
				num = (short)946274304;
				short num3 = num;
				return this.radErgoCfgVAWideRFDeviceCumulativeOverTemperature.HiddenDynamic;
			}
			set
			{
				short num = (short)767849415;
				short num2 = num;
				num = (short)1253929927;
				switch (num2 == num)
				{
				}
				num = (short)1410138113;
				if (num != 0)
				{
				}
				num = (short)1678049280;
				if (num != 0)
				{
				}
				num = (short)648151040;
				short num3 = num;
				this.radErgoCfgVAWideRFDeviceCumulativeOverTemperature.HiddenDynamic = value;
			}
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x0600049C RID: 1180 RVA: 0x00043514 File Offset: 0x00041714
		public bool RadErgoCfgVAWideRFDeviceCumulativeOverTemperature_HasDiffs
		{
			get
			{
				short num = (short)1448622267;
				short num2 = num;
				num = (short)767375547;
				switch (num2 == num)
				{
				}
				num = (short)896860160;
				if (num != 0)
				{
				}
				num = (short)100204545;
				if (num != 0)
				{
				}
				num = (short)601030656;
				short num3 = num;
				return this.radErgoCfgVAWideRFDeviceCumulativeOverTemperature._HasDiffs;
			}
		}

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x0600049D RID: 1181 RVA: 0x000435C8 File Offset: 0x000417C8
		// (set) Token: 0x0600049E RID: 1182 RVA: 0x0004367C File Offset: 0x0004187C
		public int RadErgoCfgVAWideOptionalComponentCumulativeOverTemperatureValue
		{
			get
			{
				short num = (short)2088683745;
				short num2 = num;
				num = (short)1241893089;
				switch (num2 == num)
				{
				}
				num = (short)1474363392;
				if (num != 0)
				{
				}
				num = (short)152698881;
				if (num != 0)
				{
				}
				num = (short)1893269504;
				short num3 = num;
				return this.radErgoCfgVAWideOptionalComponentCumulativeOverTemperature.Value;
			}
			set
			{
				short num = (short)1861765102;
				short num2 = num;
				num = (short)930039790;
				switch (num2 == num)
				{
				}
				num = (short)754515969;
				if (num != 0)
				{
				}
				num = (short)1020723200;
				if (num != 0)
				{
				}
				num = (short)1299316736;
				short num3 = num;
				this.radErgoCfgVAWideOptionalComponentCumulativeOverTemperature.Value = value;
			}
		}

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x0600049F RID: 1183 RVA: 0x00043730 File Offset: 0x00041930
		// (set) Token: 0x060004A0 RID: 1184 RVA: 0x000437E4 File Offset: 0x000419E4
		public string RadErgoCfgVAWideOptionalComponentCumulativeOverTemperature_UIValue
		{
			get
			{
				short num = (short)1784536831;
				short num2 = num;
				num = (short)388751103;
				switch (num2 == num)
				{
				}
				num = (short)2034696193;
				if (num != 0)
				{
				}
				num = (short)1285357568;
				if (num != 0)
				{
				}
				num = (short)627965952;
				short num3 = num;
				return this.radErgoCfgVAWideOptionalComponentCumulativeOverTemperature.UIValue;
			}
			set
			{
				short num = (short)294841743;
				short num2 = num;
				num = (short)1450044815;
				switch (num2 == num)
				{
				default:
				{
					num = (short)441253888;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)396034049;
				if (num != 0)
				{
				}
				num = (short)356777984;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWideOptionalComponentCumulativeOverTemperature.UIValue = value;
			}
		}

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x060004A1 RID: 1185 RVA: 0x0004389C File Offset: 0x00041A9C
		public global::AcpBusinessLayer.AcpRecRefField RadErgoCfgVAWideOptionalComponentCumulativeOverTemperature
		{
			get
			{
				short num = (short)1406878143;
				short num2 = num;
				num = (short)7684543;
				switch (num2 == num)
				{
				default:
				{
					num = (short)632225792;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1022754817;
				if (num != 0)
				{
				}
				num = (short)1015742464;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWideOptionalComponentCumulativeOverTemperature;
			}
		}

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x060004A2 RID: 1186 RVA: 0x00043950 File Offset: 0x00041B50
		// (set) Token: 0x060004A3 RID: 1187 RVA: 0x00043A00 File Offset: 0x00041C00
		public bool RadErgoCfgVAWideOptionalComponentCumulativeOverTemperature_Applicable
		{
			get
			{
				short num = (short)7949519;
				short num2 = num;
				num = (short)409095375;
				switch (num2 == num)
				{
				default:
				{
					num = (short)582287360;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1269563393;
				if (num != 0)
				{
				}
				num = (short)1722089472;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWideOptionalComponentCumulativeOverTemperature.Applicable;
			}
			set
			{
				short num = (short)824742854;
				short num2 = num;
				num = (short)1147966406;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1751908352;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2112749568;
				if (num != 0)
				{
				}
				num = (short)245563393;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWideOptionalComponentCumulativeOverTemperature.Applicable = value;
			}
		}

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x060004A4 RID: 1188 RVA: 0x00043AB8 File Offset: 0x00041CB8
		// (set) Token: 0x060004A5 RID: 1189 RVA: 0x00043B70 File Offset: 0x00041D70
		public bool RadErgoCfgVAWideOptionalComponentCumulativeOverTemperature_Valid
		{
			get
			{
				short num = (short)1572620162;
				short num2 = num;
				num = (short)380192642;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1397489664;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)522584065;
				if (num != 0)
				{
				}
				num = (short)2069757952;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWideOptionalComponentCumulativeOverTemperature.Valid;
			}
			set
			{
				short num = (short)616366081;
				if (num != 0)
				{
				}
				num = (short)102563840;
				short num2 = num;
				num = (short)1242723413;
				short num3 = num;
				num = (short)529495125;
				switch (num3 == num)
				{
				}
				num = (short)1563295744;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWideOptionalComponentCumulativeOverTemperature.Valid = value;
			}
		}

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x060004A6 RID: 1190 RVA: 0x00043C28 File Offset: 0x00041E28
		// (set) Token: 0x060004A7 RID: 1191 RVA: 0x00043CDC File Offset: 0x00041EDC
		public bool RadErgoCfgVAWideOptionalComponentCumulativeOverTemperature_Visible
		{
			get
			{
				short num = (short)1909322060;
				short num2 = num;
				num = (short)1704784204;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2040004608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)952434689;
				if (num != 0)
				{
				}
				num = (short)1057292288;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWideOptionalComponentCumulativeOverTemperature.Visible;
			}
			set
			{
				short num = (short)929312336;
				short num2 = num;
				num = (short)1864642128;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1667497984;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)351993857;
				if (num != 0)
				{
				}
				num = (short)1923612672;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWideOptionalComponentCumulativeOverTemperature.Visible = value;
			}
		}

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x060004A8 RID: 1192 RVA: 0x00043D90 File Offset: 0x00041F90
		// (set) Token: 0x060004A9 RID: 1193 RVA: 0x00043E44 File Offset: 0x00042044
		public bool RadErgoCfgVAWideOptionalComponentCumulativeOverTemperature_Editable
		{
			get
			{
				short num = (short)679867726;
				short num2 = num;
				num = (short)1919612238;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2116026368;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1249771521;
				if (num != 0)
				{
				}
				num = (short)58392576;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWideOptionalComponentCumulativeOverTemperature.Editable;
			}
			set
			{
				short num = (short)1651736238;
				short num2 = num;
				num = (short)324697774;
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
				num = (short)911998976;
				if (num != 0)
				{
				}
				num = (short)404488193;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWideOptionalComponentCumulativeOverTemperature.Editable = value;
			}
		}

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x060004AA RID: 1194 RVA: 0x00043EFC File Offset: 0x000420FC
		internal string RadErgoCfgVAWideOptionalComponentCumulativeOverTemperature_UILabel
		{
			get
			{
				short num = (short)11806712;
				short num2 = num;
				num = (short)712714232;
				switch (num2 == num)
				{
				default:
				{
					num = (short)349765632;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1870135296;
				if (num != 0)
				{
				}
				num = (short)1102970881;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWideOptionalComponentCumulativeOverTemperature.UIName;
			}
		}

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x060004AB RID: 1195 RVA: 0x00043FB0 File Offset: 0x000421B0
		// (set) Token: 0x060004AC RID: 1196 RVA: 0x00044068 File Offset: 0x00042268
		internal bool RadErgoCfgVAWideOptionalComponentCumulativeOverTemperature_HiddenStatic
		{
			get
			{
				short num = (short)202439852;
				short num2 = num;
				num = (short)1196948652;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1145700352;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1302724609;
				if (num != 0)
				{
				}
				num = (short)1000865792;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWideOptionalComponentCumulativeOverTemperature.HiddenStatic;
			}
			set
			{
				short num = (short)1944256513;
				if (num != 0)
				{
				}
				num = (short)308805632;
				short num2 = num;
				num = (short)1354029953;
				short num3 = num;
				num = (short)1562631041;
				switch (num3 == num)
				{
				}
				num = (short)1643970560;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWideOptionalComponentCumulativeOverTemperature.HiddenStatic = value;
			}
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x060004AD RID: 1197 RVA: 0x0004411C File Offset: 0x0004231C
		// (set) Token: 0x060004AE RID: 1198 RVA: 0x000441D4 File Offset: 0x000423D4
		internal bool RadErgoCfgVAWideOptionalComponentCumulativeOverTemperature_HiddenDynamic
		{
			get
			{
				short num = (short)1187882723;
				short num2 = num;
				num = (short)2034214627;
				switch (num2 == num)
				{
				default:
				{
					num = (short)189530112;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)977141760;
				if (num != 0)
				{
				}
				num = (short)2013790209;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWideOptionalComponentCumulativeOverTemperature.HiddenDynamic;
			}
			set
			{
				short num = (short)1285122132;
				short num2 = num;
				num = (short)1283352660;
				switch (num2 == num)
				{
				default:
				{
					num = (short)980353024;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1297612801;
				if (num != 0)
				{
				}
				num = (short)1540489216;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWideOptionalComponentCumulativeOverTemperature.HiddenDynamic = value;
			}
		}

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x060004AF RID: 1199 RVA: 0x0004428C File Offset: 0x0004248C
		public bool RadErgoCfgVAWideOptionalComponentCumulativeOverTemperature_HasDiffs
		{
			get
			{
				short num = (short)1605160256;
				short num2 = num;
				num = (short)1237241152;
				switch (num2 == num)
				{
				default:
				{
					num = (short)154402816;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1310523392;
				if (num != 0)
				{
				}
				num = (short)648151041;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWideOptionalComponentCumulativeOverTemperature._HasDiffs;
			}
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x060004B0 RID: 1200 RVA: 0x00044340 File Offset: 0x00042540
		// (set) Token: 0x060004B1 RID: 1201 RVA: 0x000443F4 File Offset: 0x000425F4
		public int RadErgoCfgVAWideNonHZMAccessoryValue
		{
			get
			{
				short num = (short)1898452869;
				short num2 = num;
				num = (short)2135103365;
				switch (num2 == num)
				{
				default:
				{
					num = (short)287309824;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1409155073;
				if (num != 0)
				{
				}
				num = (short)1980432384;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWideNonHZMAccessory.Value;
			}
			set
			{
				short num = (short)1876351656;
				short num2 = num;
				num = (short)971496104;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1952907264;
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
				num = (short)612564992;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWideNonHZMAccessory.Value = value;
			}
		}

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x060004B2 RID: 1202 RVA: 0x000444A8 File Offset: 0x000426A8
		// (set) Token: 0x060004B3 RID: 1203 RVA: 0x0004455C File Offset: 0x0004275C
		public string RadErgoCfgVAWideNonHZMAccessory_UIValue
		{
			get
			{
				short num = (short)1179564515;
				short num2 = num;
				num = (short)51034595;
				switch (num2 == num)
				{
				default:
				{
					num = (short)402784256;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)3735553;
				if (num != 0)
				{
				}
				num = (short)1997996032;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWideNonHZMAccessory.UIValue;
			}
			set
			{
				short num = (short)1147797505;
				if (num != 0)
				{
				}
				num = (short)1522925568;
				short num2 = num;
				num = (short)343040214;
				short num3 = num;
				num = (short)1156604118;
				switch (num3 == num)
				{
				}
				num = (short)1888616448;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWideNonHZMAccessory.UIValue = value;
			}
		}

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x060004B4 RID: 1204 RVA: 0x00044614 File Offset: 0x00042814
		public global::AcpBusinessLayer.AcpRecRefField RadErgoCfgVAWideNonHZMAccessory
		{
			get
			{
				short num = (short)438630459;
				short num2 = num;
				num = (short)769259579;
				switch (num2 == num)
				{
				default:
				{
					num = (short)66715648;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)252903424;
				if (num != 0)
				{
				}
				num = (short)112656385;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWideNonHZMAccessory;
			}
		}

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x060004B5 RID: 1205 RVA: 0x000446C4 File Offset: 0x000428C4
		// (set) Token: 0x060004B6 RID: 1206 RVA: 0x00044778 File Offset: 0x00042978
		public bool RadErgoCfgVAWideNonHZMAccessory_Applicable
		{
			get
			{
				short num = (short)973733889;
				if (num != 0)
				{
				}
				num = (short)915406848;
				short num2 = num;
				num = (short)1809840074;
				short num3 = num;
				num = (short)82180042;
				switch (num3 == num)
				{
				}
				num = (short)1459290112;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWideNonHZMAccessory.Applicable;
			}
			set
			{
				short num = (short)1882243371;
				short num2 = num;
				num = (short)1920778539;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1969684480;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1331625985;
				if (num != 0)
				{
				}
				num = (short)1040252928;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWideNonHZMAccessory.Applicable = value;
			}
		}

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x060004B7 RID: 1207 RVA: 0x0004482C File Offset: 0x00042A2C
		// (set) Token: 0x060004B8 RID: 1208 RVA: 0x000448E0 File Offset: 0x00042AE0
		public bool RadErgoCfgVAWideNonHZMAccessory_Valid
		{
			get
			{
				short num = (short)746490457;
				short num2 = num;
				num = (short)833325657;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1175846912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1600126977;
				if (num != 0)
				{
				}
				num = (short)573505536;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWideNonHZMAccessory.Valid;
			}
			set
			{
				short num = (short)507766104;
				short num2 = num;
				num = (short)1327883608;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2136145920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)812318721;
				if (num != 0)
				{
				}
				num = (short)1760690176;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWideNonHZMAccessory.Valid = value;
			}
		}

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x060004B9 RID: 1209 RVA: 0x00044994 File Offset: 0x00042B94
		// (set) Token: 0x060004BA RID: 1210 RVA: 0x00044A48 File Offset: 0x00042C48
		public bool RadErgoCfgVAWideNonHZMAccessory_Visible
		{
			get
			{
				short num = (short)2113395678;
				short num2 = num;
				num = (short)859036638;
				switch (num2 == num)
				{
				default:
				{
					num = (short)828375040;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)166723584;
				if (num != 0)
				{
				}
				num = (short)960233473;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWideNonHZMAccessory.Visible;
			}
			set
			{
				short num = (short)1673595267;
				short num2 = num;
				num = (short)1409616259;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1311113216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1240858625;
				if (num != 0)
				{
				}
				num = (short)1052901376;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWideNonHZMAccessory.Visible = value;
			}
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x060004BB RID: 1211 RVA: 0x00044AFC File Offset: 0x00042CFC
		// (set) Token: 0x060004BC RID: 1212 RVA: 0x00044BB0 File Offset: 0x00042DB0
		public bool RadErgoCfgVAWideNonHZMAccessory_Editable
		{
			get
			{
				short num = (short)1002488708;
				short num2 = num;
				num = (short)1308607364;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1399390208;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)645267457;
				if (num != 0)
				{
				}
				num = (short)700055552;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWideNonHZMAccessory.Editable;
			}
			set
			{
				short num = (short)532217857;
				if (num != 0)
				{
				}
				num = (short)447348736;
				short num2 = num;
				num = (short)1548286933;
				short num3 = num;
				num = (short)1187904469;
				switch (num3 == num)
				{
				}
				num = (short)1130627072;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWideNonHZMAccessory.Editable = value;
			}
		}

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x060004BD RID: 1213 RVA: 0x00044C68 File Offset: 0x00042E68
		internal string RadErgoCfgVAWideNonHZMAccessory_UILabel
		{
			get
			{
				short num = (short)1407844353;
				if (num != 0)
				{
				}
				num = (short)112590848;
				short num2 = num;
				num = (short)1938533191;
				short num3 = num;
				num = (short)1270393671;
				switch (num3 == num)
				{
				}
				num = (short)1766785024;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWideNonHZMAccessory.UIName;
			}
		}

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x060004BE RID: 1214 RVA: 0x00044D1C File Offset: 0x00042F1C
		// (set) Token: 0x060004BF RID: 1215 RVA: 0x00044DD0 File Offset: 0x00042FD0
		internal bool RadErgoCfgVAWideNonHZMAccessory_HiddenStatic
		{
			get
			{
				short num = (short)134040493;
				short num2 = num;
				num = (short)982010797;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1884946432;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)611844097;
				if (num != 0)
				{
				}
				num = (short)1881341952;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWideNonHZMAccessory.HiddenStatic;
			}
			set
			{
				short num = (short)2075721729;
				if (num != 0)
				{
				}
				num = (short)1557266432;
				short num2 = num;
				num = (short)2107907049;
				short num3 = num;
				num = (short)1964907497;
				switch (num3 == num)
				{
				}
				num = (short)2057830400;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWideNonHZMAccessory.HiddenStatic = value;
			}
		}

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x060004C0 RID: 1216 RVA: 0x00044E88 File Offset: 0x00043088
		// (set) Token: 0x060004C1 RID: 1217 RVA: 0x00044F3C File Offset: 0x0004313C
		internal bool RadErgoCfgVAWideNonHZMAccessory_HiddenDynamic
		{
			get
			{
				short num = (short)1014135867;
				short num2 = num;
				num = (short)1464433723;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1843855360;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)668336129;
				if (num != 0)
				{
				}
				num = (short)1599733760;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWideNonHZMAccessory.HiddenDynamic;
			}
			set
			{
				short num = (short)1787065152;
				short num2 = num;
				num = (short)336753472;
				switch (num2 == num)
				{
				default:
				{
					num = (short)640679936;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1593442304;
				if (num != 0)
				{
				}
				num = (short)1439891457;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWideNonHZMAccessory.HiddenDynamic = value;
			}
		}

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x060004C2 RID: 1218 RVA: 0x00044FF4 File Offset: 0x000431F4
		public bool RadErgoCfgVAWideNonHZMAccessory_HasDiffs
		{
			get
			{
				short num = (short)159007595;
				short num2 = num;
				num = (short)1135756139;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1967128576;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1153630209;
				if (num != 0)
				{
				}
				num = (short)13369344;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWideNonHZMAccessory._HasDiffs;
			}
		}

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x060004C3 RID: 1219 RVA: 0x000450AC File Offset: 0x000432AC
		// (set) Token: 0x060004C4 RID: 1220 RVA: 0x00045160 File Offset: 0x00043360
		public int RadErgoCfgVAWideBatteryCumulativeOverTemperatureValue
		{
			get
			{
				short num = (short)216454853;
				short num2 = num;
				num = (short)434886341;
				switch (num2 == num)
				{
				default:
				{
					num = (short)216727552;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)295043073;
				if (num != 0)
				{
				}
				num = (short)1940455424;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWideBatteryCumulativeOverTemperature.Value;
			}
			set
			{
				short num = (short)1378113566;
				short num2 = num;
				num = (short)1412388894;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1203109888;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)467730432;
				if (num != 0)
				{
				}
				num = (short)1696595969;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWideBatteryCumulativeOverTemperature.Value = value;
			}
		}

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x060004C5 RID: 1221 RVA: 0x00045214 File Offset: 0x00043414
		// (set) Token: 0x060004C6 RID: 1222 RVA: 0x000452C8 File Offset: 0x000434C8
		public string RadErgoCfgVAWideBatteryCumulativeOverTemperature_UIValue
		{
			get
			{
				short num = (short)245210416;
				short num2 = num;
				num = (short)1422564656;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1074397184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)963510272;
				if (num != 0)
				{
				}
				num = (short)1278476289;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWideBatteryCumulativeOverTemperature.UIValue;
			}
			set
			{
				short num = (short)1526735671;
				short num2 = num;
				num = (short)2046370615;
				switch (num2 == num)
				{
				default:
				{
					num = (short)978583552;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)760152065;
				if (num != 0)
				{
				}
				num = (short)405929984;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWideBatteryCumulativeOverTemperature.UIValue = value;
			}
		}

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x060004C7 RID: 1223 RVA: 0x0004537C File Offset: 0x0004357C
		public global::AcpBusinessLayer.AcpRecRefField RadErgoCfgVAWideBatteryCumulativeOverTemperature
		{
			get
			{
				short num = (short)769904002;
				short num2 = num;
				num = (short)593874306;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1319960576;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1228472321;
				if (num != 0)
				{
				}
				num = (short)932708352;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWideBatteryCumulativeOverTemperature;
			}
		}

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x060004C8 RID: 1224 RVA: 0x00045428 File Offset: 0x00043628
		// (set) Token: 0x060004C9 RID: 1225 RVA: 0x000454E0 File Offset: 0x000436E0
		public bool RadErgoCfgVAWideBatteryCumulativeOverTemperature_Applicable
		{
			get
			{
				short num = (short)404463268;
				short num2 = num;
				num = (short)1731305124;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1294991360;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2070216705;
				if (num != 0)
				{
				}
				num = (short)782237696;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWideBatteryCumulativeOverTemperature.Applicable;
			}
			set
			{
				short num = (short)1794649740;
				short num2 = num;
				num = (short)1994337932;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1852243968;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)345636864;
				if (num != 0)
				{
				}
				num = (short)43253761;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWideBatteryCumulativeOverTemperature.Applicable = value;
			}
		}

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x060004CA RID: 1226 RVA: 0x00045598 File Offset: 0x00043798
		// (set) Token: 0x060004CB RID: 1227 RVA: 0x00045650 File Offset: 0x00043850
		public bool RadErgoCfgVAWideBatteryCumulativeOverTemperature_Valid
		{
			get
			{
				short num = (short)2095717159;
				short num2 = num;
				num = (short)198122279;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1248591872;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)962002945;
				if (num != 0)
				{
				}
				num = (short)1119551488;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWideBatteryCumulativeOverTemperature.Valid;
			}
			set
			{
				short num = (short)1751190064;
				short num2 = num;
				num = (short)1635846704;
				switch (num2 == num)
				{
				default:
				{
					num = (short)817168384;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2077753345;
				if (num != 0)
				{
				}
				num = (short)381419520;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWideBatteryCumulativeOverTemperature.Valid = value;
			}
		}

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x060004CC RID: 1228 RVA: 0x00045708 File Offset: 0x00043908
		// (set) Token: 0x060004CD RID: 1229 RVA: 0x000457C0 File Offset: 0x000439C0
		public bool RadErgoCfgVAWideBatteryCumulativeOverTemperature_Visible
		{
			get
			{
				short num = (short)1587314008;
				short num2 = num;
				num = (short)1931378008;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1801125888;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1797062656;
				if (num != 0)
				{
				}
				num = (short)1335951361;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWideBatteryCumulativeOverTemperature.Visible;
			}
			set
			{
				short num = (short)2072274614;
				short num2 = num;
				num = (short)271804086;
				switch (num2 == num)
				{
				default:
				{
					num = (short)60489728;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1222180864;
				if (num != 0)
				{
				}
				num = (short)165150721;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWideBatteryCumulativeOverTemperature.Visible = value;
			}
		}

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x060004CE RID: 1230 RVA: 0x00045878 File Offset: 0x00043A78
		// (set) Token: 0x060004CF RID: 1231 RVA: 0x00045930 File Offset: 0x00043B30
		public bool RadErgoCfgVAWideBatteryCumulativeOverTemperature_Editable
		{
			get
			{
				short num = (short)1441175852;
				short num2 = num;
				num = (short)1412405548;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1130889216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)816185344;
				if (num != 0)
				{
				}
				num = (short)1318977537;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWideBatteryCumulativeOverTemperature.Editable;
			}
			set
			{
				short num = (short)334127821;
				short num2 = num;
				num = (short)1253139149;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2008809472;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)928776192;
				if (num != 0)
				{
				}
				num = (short)506920961;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWideBatteryCumulativeOverTemperature.Editable = value;
			}
		}

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x060004D0 RID: 1232 RVA: 0x000459E4 File Offset: 0x00043BE4
		internal string RadErgoCfgVAWideBatteryCumulativeOverTemperature_UILabel
		{
			get
			{
				short num = (short)828375041;
				if (num != 0)
				{
				}
				num = (short)815792128;
				short num2 = num;
				num = (short)1139165046;
				short num3 = num;
				num = (short)345393014;
				switch (num3 == num)
				{
				}
				num = (short)12255232;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWideBatteryCumulativeOverTemperature.UIName;
			}
		}

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x060004D1 RID: 1233 RVA: 0x00045A9C File Offset: 0x00043C9C
		// (set) Token: 0x060004D2 RID: 1234 RVA: 0x00045B54 File Offset: 0x00043D54
		internal bool RadErgoCfgVAWideBatteryCumulativeOverTemperature_HiddenStatic
		{
			get
			{
				short num = (short)1811021825;
				if (num != 0)
				{
				}
				num = (short)718209024;
				short num2 = num;
				num = (short)783304839;
				short num3 = num;
				num = (short)381175943;
				switch (num3 == num)
				{
				}
				num = (short)1833304064;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWideBatteryCumulativeOverTemperature.HiddenStatic;
			}
			set
			{
				short num = (short)952172544;
				short num2 = num;
				num = (short)1422131201;
				if (num != 0)
				{
				}
				num = (short)1565088833;
				short num3 = num;
				num = (short)354311233;
				switch (num3 == num)
				{
				}
				num = (short)1579810816;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWideBatteryCumulativeOverTemperature.HiddenStatic = value;
			}
		}

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x060004D3 RID: 1235 RVA: 0x00045C08 File Offset: 0x00043E08
		// (set) Token: 0x060004D4 RID: 1236 RVA: 0x00045CB8 File Offset: 0x00043EB8
		internal bool RadErgoCfgVAWideBatteryCumulativeOverTemperature_HiddenDynamic
		{
			get
			{
				short num = (short)1395851264;
				short num2 = num;
				num = (short)1718509075;
				short num3 = num;
				num = (short)1807834643;
				switch (num3 == num)
				{
				}
				num = (short)665583617;
				if (num != 0)
				{
				}
				num = (short)1035468800;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWideBatteryCumulativeOverTemperature.HiddenDynamic;
			}
			set
			{
				short num = (short)1317404672;
				short num2 = num;
				num = (short)1164054270;
				short num3 = num;
				num = (short)1875250942;
				switch (num3 == num)
				{
				}
				num = (short)814350337;
				if (num != 0)
				{
				}
				num = (short)1547894784;
				if (num != 0)
				{
				}
				this.radErgoCfgVAWideBatteryCumulativeOverTemperature.HiddenDynamic = value;
			}
		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x060004D5 RID: 1237 RVA: 0x00045D70 File Offset: 0x00043F70
		public bool RadErgoCfgVAWideBatteryCumulativeOverTemperature_HasDiffs
		{
			get
			{
				short num = (short)1005912064;
				short num2 = num;
				num = (short)1742268184;
				short num3 = num;
				num = (short)695330584;
				switch (num3 == num)
				{
				}
				num = (short)169672705;
				if (num != 0)
				{
				}
				num = (short)2006908928;
				if (num != 0)
				{
				}
				return this.radErgoCfgVAWideBatteryCumulativeOverTemperature._HasDiffs;
			}
		}

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x060004D6 RID: 1238 RVA: 0x00045E24 File Offset: 0x00044024
		// (set) Token: 0x060004D7 RID: 1239 RVA: 0x00045ED8 File Offset: 0x000440D8
		public string RadErgoRfDeviceCumulativeOverTemperatureAnnouncementVoiceCommandValue
		{
			get
			{
				short num = (short)5373952;
				short num2 = num;
				num = (short)1973741251;
				short num3 = num;
				num = (short)1630463683;
				switch (num3 == num)
				{
				}
				num = (short)926941185;
				if (num != 0)
				{
				}
				num = (short)774832128;
				if (num != 0)
				{
				}
				return this.radErgoRfDeviceCumulativeOverTemperatureAnnouncementVoiceCommand.Value;
			}
			set
			{
				short num = (short)265420800;
				short num2 = num;
				num = (short)758969796;
				short num3 = num;
				num = (short)125105604;
				switch (num3 == num)
				{
				}
				num = (short)2029780993;
				if (num != 0)
				{
				}
				num = (short)302448640;
				if (num != 0)
				{
				}
				this.radErgoRfDeviceCumulativeOverTemperatureAnnouncementVoiceCommand.Value = value;
			}
		}

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x060004D8 RID: 1240 RVA: 0x00045F8C File Offset: 0x0004418C
		public global::AcpBusinessLayer.AcpField<string> RadErgoRfDeviceCumulativeOverTemperatureAnnouncementVoiceCommand
		{
			get
			{
				short num = (short)648347648;
				short num2 = num;
				num = (short)716800147;
				short num3 = num;
				num = (short)669941907;
				switch (num3 == num)
				{
				}
				num = (short)1792147457;
				if (num != 0)
				{
				}
				num = (short)1385496576;
				if (num != 0)
				{
				}
				return this.radErgoRfDeviceCumulativeOverTemperatureAnnouncementVoiceCommand;
			}
		}

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x060004D9 RID: 1241 RVA: 0x0004603C File Offset: 0x0004423C
		// (set) Token: 0x060004DA RID: 1242 RVA: 0x000460F4 File Offset: 0x000442F4
		public string RadErgoRfDeviceCumulativeOverTemperatureAnnouncementVoiceCommand_UIValue
		{
			get
			{
				short num = (short)546439168;
				short num2 = num;
				num = (short)362988149;
				short num3 = num;
				num = (short)1934344821;
				switch (num3 == num)
				{
				}
				num = (short)1832976385;
				if (num != 0)
				{
				}
				num = (short)2095972352;
				if (num != 0)
				{
				}
				return this.radErgoRfDeviceCumulativeOverTemperatureAnnouncementVoiceCommand.Value;
			}
			set
			{
				short num = (short)1226309632;
				short num2 = num;
				num = (short)1234021997;
				short num3 = num;
				num = (short)1993322093;
				switch (num3 == num)
				{
				}
				num = (short)1779630081;
				if (num != 0)
				{
				}
				num = (short)1149370368;
				if (num != 0)
				{
				}
				this.radErgoRfDeviceCumulativeOverTemperatureAnnouncementVoiceCommand.Value = value;
			}
		}

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x060004DB RID: 1243 RVA: 0x000461AC File Offset: 0x000443AC
		// (set) Token: 0x060004DC RID: 1244 RVA: 0x00046260 File Offset: 0x00044460
		public bool RadErgoRfDeviceCumulativeOverTemperatureAnnouncementVoiceCommand_Applicable
		{
			get
			{
				short num = (short)49872896;
				short num2 = num;
				num = (short)1724869540;
				short num3 = num;
				num = (short)1102867364;
				switch (num3 == num)
				{
				}
				num = (short)304087041;
				if (num != 0)
				{
				}
				num = (short)955645952;
				if (num != 0)
				{
				}
				return this.radErgoRfDeviceCumulativeOverTemperatureAnnouncementVoiceCommand.Applicable;
			}
			set
			{
				short num = (short)837091328;
				short num2 = num;
				num = (short)1758489297;
				short num3 = num;
				num = (short)172387025;
				switch (num3 == num)
				{
				}
				num = (short)276234241;
				if (num != 0)
				{
				}
				num = (short)1524367360;
				if (num != 0)
				{
				}
				this.radErgoRfDeviceCumulativeOverTemperatureAnnouncementVoiceCommand.Applicable = value;
			}
		}

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x060004DD RID: 1245 RVA: 0x00046314 File Offset: 0x00044514
		// (set) Token: 0x060004DE RID: 1246 RVA: 0x000463C8 File Offset: 0x000445C8
		public bool RadErgoRfDeviceCumulativeOverTemperatureAnnouncementVoiceCommand_Valid
		{
			get
			{
				short num = (short)1923809280;
				short num2 = num;
				num = (short)263651329;
				if (num != 0)
				{
				}
				num = (short)55455175;
				short num3 = num;
				num = (short)709832135;
				switch (num3 == num)
				{
				}
				num = (short)297533440;
				if (num != 0)
				{
				}
				return this.radErgoRfDeviceCumulativeOverTemperatureAnnouncementVoiceCommand.Valid;
			}
			set
			{
				short num = (short)446300160;
				short num2 = num;
				num = (short)1194406523;
				short num3 = num;
				num = (short)103690875;
				switch (num3 == num)
				{
				}
				num = (short)985792513;
				if (num != 0)
				{
				}
				num = (short)46006272;
				if (num != 0)
				{
				}
				this.radErgoRfDeviceCumulativeOverTemperatureAnnouncementVoiceCommand.Valid = value;
			}
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x060004DF RID: 1247 RVA: 0x0004647C File Offset: 0x0004467C
		// (set) Token: 0x060004E0 RID: 1248 RVA: 0x00046530 File Offset: 0x00044730
		public bool RadErgoRfDeviceCumulativeOverTemperatureAnnouncementVoiceCommand_Visible
		{
			get
			{
				short num = (short)359418374;
				short num2 = num;
				num = (short)1455376902;
				switch (num2 == num)
				{
				default:
				{
					num = (short)49741824;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1610874881;
				if (num != 0)
				{
				}
				num = (short)393019392;
				if (num != 0)
				{
				}
				return this.radErgoRfDeviceCumulativeOverTemperatureAnnouncementVoiceCommand.Visible;
			}
			set
			{
				short num = (short)1744974592;
				short num2 = num;
				num = (short)1552364288;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1264582656;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1453260801;
				if (num != 0)
				{
				}
				num = (short)924254208;
				if (num != 0)
				{
				}
				this.radErgoRfDeviceCumulativeOverTemperatureAnnouncementVoiceCommand.Visible = value;
			}
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x060004E1 RID: 1249 RVA: 0x000465E4 File Offset: 0x000447E4
		// (set) Token: 0x060004E2 RID: 1250 RVA: 0x00046698 File Offset: 0x00044898
		public bool RadErgoRfDeviceCumulativeOverTemperatureAnnouncementVoiceCommand_Editable
		{
			get
			{
				short num = (short)520227854;
				short num2 = num;
				num = (short)580717582;
				switch (num2 == num)
				{
				default:
				{
					num = (short)660013056;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1759772672;
				if (num != 0)
				{
				}
				num = (short)2092826625;
				if (num != 0)
				{
				}
				return this.radErgoRfDeviceCumulativeOverTemperatureAnnouncementVoiceCommand.Editable;
			}
			set
			{
				short num = (short)1560772721;
				short num2 = num;
				num = (short)1972535409;
				switch (num2 == num)
				{
				default:
				{
					num = (short)277676032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)923467776;
				if (num != 0)
				{
				}
				num = (short)377880577;
				if (num != 0)
				{
				}
				this.radErgoRfDeviceCumulativeOverTemperatureAnnouncementVoiceCommand.Editable = value;
			}
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x060004E3 RID: 1251 RVA: 0x0004674C File Offset: 0x0004494C
		internal string RadErgoRfDeviceCumulativeOverTemperatureAnnouncementVoiceCommand_UILabel
		{
			get
			{
				short num = (short)202244097;
				if (num != 0)
				{
				}
				num = (short)88014848;
				short num2 = num;
				num = (short)1440573505;
				short num3 = num;
				num = (short)472541249;
				switch (num3 == num)
				{
				}
				num = (short)1432748032;
				if (num != 0)
				{
				}
				return this.radErgoRfDeviceCumulativeOverTemperatureAnnouncementVoiceCommand.UIName;
			}
		}

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x060004E4 RID: 1252 RVA: 0x00046804 File Offset: 0x00044A04
		// (set) Token: 0x060004E5 RID: 1253 RVA: 0x000468B4 File Offset: 0x00044AB4
		internal bool RadErgoRfDeviceCumulativeOverTemperatureAnnouncementVoiceCommand_HiddenStatic
		{
			get
			{
				short num = (short)1709728631;
				short num2 = num;
				num = (short)209347447;
				switch (num2 == num)
				{
				default:
				{
					num = (short)675741696;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1943339009;
				if (num != 0)
				{
				}
				num = (short)606208000;
				if (num != 0)
				{
				}
				return this.radErgoRfDeviceCumulativeOverTemperatureAnnouncementVoiceCommand.HiddenStatic;
			}
			set
			{
				short num = (short)140087694;
				short num2 = num;
				num = (short)720867726;
				switch (num2 == num)
				{
				default:
				{
					num = (short)987299840;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1745944576;
				if (num != 0)
				{
				}
				num = (short)804585473;
				if (num != 0)
				{
				}
				this.radErgoRfDeviceCumulativeOverTemperatureAnnouncementVoiceCommand.HiddenStatic = value;
			}
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x060004E6 RID: 1254 RVA: 0x00046968 File Offset: 0x00044B68
		// (set) Token: 0x060004E7 RID: 1255 RVA: 0x00046A1C File Offset: 0x00044C1C
		internal bool RadErgoRfDeviceCumulativeOverTemperatureAnnouncementVoiceCommand_HiddenDynamic
		{
			get
			{
				short num = (short)985989121;
				if (num != 0)
				{
				}
				num = (short)1653800960;
				short num2 = num;
				num = (short)1914139937;
				short num3 = num;
				num = (short)178025761;
				switch (num3 == num)
				{
				}
				num = (short)1040973824;
				if (num != 0)
				{
				}
				return this.radErgoRfDeviceCumulativeOverTemperatureAnnouncementVoiceCommand.HiddenDynamic;
			}
			set
			{
				short num = (short)2036693588;
				short num2 = num;
				num = (short)1171356244;
				switch (num2 == num)
				{
				default:
				{
					num = (short)290193408;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1029439489;
				if (num != 0)
				{
				}
				num = (short)1136263168;
				if (num != 0)
				{
				}
				this.radErgoRfDeviceCumulativeOverTemperatureAnnouncementVoiceCommand.HiddenDynamic = value;
			}
		}

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x060004E8 RID: 1256 RVA: 0x00046AD4 File Offset: 0x00044CD4
		public bool RadErgoRfDeviceCumulativeOverTemperatureAnnouncementVoiceCommand_HasDiffs
		{
			get
			{
				short num = (short)356497265;
				short num2 = num;
				num = (short)443004785;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1426456576;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)588185601;
				if (num != 0)
				{
				}
				num = (short)1335492608;
				if (num != 0)
				{
				}
				return this.radErgoRfDeviceCumulativeOverTemperatureAnnouncementVoiceCommand._HasDiffs;
			}
		}

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x060004E9 RID: 1257 RVA: 0x00046B8C File Offset: 0x00044D8C
		// (set) Token: 0x060004EA RID: 1258 RVA: 0x00046C40 File Offset: 0x00044E40
		public string RadErgoOptionalComponentCumulativeOverTemperatureAnnouncementVoiceCommandValue
		{
			get
			{
				short num = (short)1440153601;
				if (num != 0)
				{
				}
				num = (short)473956352;
				short num2 = num;
				num = (short)1378151520;
				short num3 = num;
				num = (short)821947488;
				switch (num3 == num)
				{
				}
				num = (short)472317952;
				if (num != 0)
				{
				}
				return this.radErgoOptionalComponentCumulativeOverTemperatureAnnouncementVoiceCommand.Value;
			}
			set
			{
				short num = (short)13681201;
				short num2 = num;
				num = (short)418628145;
				switch (num2 == num)
				{
				default:
				{
					num = (short)159842304;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1642201089;
				if (num != 0)
				{
				}
				num = (short)1564737536;
				if (num != 0)
				{
				}
				this.radErgoOptionalComponentCumulativeOverTemperatureAnnouncementVoiceCommand.Value = value;
			}
		}

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x060004EB RID: 1259 RVA: 0x00046CF4 File Offset: 0x00044EF4
		public global::AcpBusinessLayer.AcpField<string> RadErgoOptionalComponentCumulativeOverTemperatureAnnouncementVoiceCommand
		{
			get
			{
				short num = (short)563937281;
				if (num != 0)
				{
				}
				num = (short)275972096;
				short num2 = num;
				num = (short)101304751;
				short num3 = num;
				num = (short)1665386927;
				switch (num3 == num)
				{
				}
				num = (short)1357119488;
				if (num != 0)
				{
				}
				return this.radErgoOptionalComponentCumulativeOverTemperatureAnnouncementVoiceCommand;
			}
		}

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x060004EC RID: 1260 RVA: 0x00046DA8 File Offset: 0x00044FA8
		// (set) Token: 0x060004ED RID: 1261 RVA: 0x00046E5C File Offset: 0x0004505C
		public string RadErgoOptionalComponentCumulativeOverTemperatureAnnouncementVoiceCommand_UIValue
		{
			get
			{
				short num = (short)2048056482;
				short num2 = num;
				num = (short)829086882;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1612185600;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)567869441;
				if (num != 0)
				{
				}
				num = (short)1471414272;
				if (num != 0)
				{
				}
				return this.radErgoOptionalComponentCumulativeOverTemperatureAnnouncementVoiceCommand.Value;
			}
			set
			{
				short num = (short)361084667;
				short num2 = num;
				num = (short)1357297403;
				switch (num2 == num)
				{
				default:
				{
					num = (short)982908928;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1765736449;
				if (num != 0)
				{
				}
				num = (short)911212544;
				if (num != 0)
				{
				}
				this.radErgoOptionalComponentCumulativeOverTemperatureAnnouncementVoiceCommand.Value = value;
			}
		}

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x060004EE RID: 1262 RVA: 0x00046F10 File Offset: 0x00045110
		// (set) Token: 0x060004EF RID: 1263 RVA: 0x00046FC4 File Offset: 0x000451C4
		public bool RadErgoOptionalComponentCumulativeOverTemperatureAnnouncementVoiceCommand_Applicable
		{
			get
			{
				short num = (short)1547373824;
				short num2 = num;
				num = (short)1262161152;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1326186496;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1294729217;
				if (num != 0)
				{
				}
				num = (short)1104805888;
				if (num != 0)
				{
				}
				return this.radErgoOptionalComponentCumulativeOverTemperatureAnnouncementVoiceCommand.Applicable;
			}
			set
			{
				short num = (short)586120866;
				short num2 = num;
				num = (short)686325410;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1187971072;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1016004609;
				if (num != 0)
				{
				}
				num = (short)937033728;
				if (num != 0)
				{
				}
				this.radErgoOptionalComponentCumulativeOverTemperatureAnnouncementVoiceCommand.Applicable = value;
			}
		}

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x060004F0 RID: 1264 RVA: 0x00047078 File Offset: 0x00045278
		// (set) Token: 0x060004F1 RID: 1265 RVA: 0x0004712C File Offset: 0x0004532C
		public bool RadErgoOptionalComponentCumulativeOverTemperatureAnnouncementVoiceCommand_Valid
		{
			get
			{
				short num = (short)25117361;
				short num2 = num;
				num = (short)1982612145;
				switch (num2 == num)
				{
				default:
				{
					num = (short)244252672;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1770717184;
				if (num != 0)
				{
				}
				num = (short)964165633;
				if (num != 0)
				{
				}
				return this.radErgoOptionalComponentCumulativeOverTemperatureAnnouncementVoiceCommand.Valid;
			}
			set
			{
				short num = (short)569484982;
				short num2 = num;
				num = (short)1353098934;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1492647936;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)208076800;
				if (num != 0)
				{
				}
				num = (short)1381892097;
				if (num != 0)
				{
				}
				this.radErgoOptionalComponentCumulativeOverTemperatureAnnouncementVoiceCommand.Valid = value;
			}
		}

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x060004F2 RID: 1266 RVA: 0x000471E0 File Offset: 0x000453E0
		// (set) Token: 0x060004F3 RID: 1267 RVA: 0x00047294 File Offset: 0x00045494
		public bool RadErgoOptionalComponentCumulativeOverTemperatureAnnouncementVoiceCommand_Visible
		{
			get
			{
				short num = (short)1512209421;
				short num2 = num;
				num = (short)285768717;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2105016320;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)378732545;
				if (num != 0)
				{
				}
				num = (short)1117716480;
				if (num != 0)
				{
				}
				return this.radErgoOptionalComponentCumulativeOverTemperatureAnnouncementVoiceCommand.Visible;
			}
			set
			{
				short num = (short)1975386113;
				if (num != 0)
				{
				}
				num = (short)315817984;
				short num2 = num;
				num = (short)1879946062;
				short num3 = num;
				num = (short)1404613454;
				switch (num3 == num)
				{
				}
				num = (short)1151336448;
				if (num != 0)
				{
				}
				this.radErgoOptionalComponentCumulativeOverTemperatureAnnouncementVoiceCommand.Visible = value;
			}
		}

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x060004F4 RID: 1268 RVA: 0x0004734C File Offset: 0x0004554C
		// (set) Token: 0x060004F5 RID: 1269 RVA: 0x00047404 File Offset: 0x00045604
		public bool RadErgoOptionalComponentCumulativeOverTemperatureAnnouncementVoiceCommand_Editable
		{
			get
			{
				short num = (short)1376276229;
				short num2 = num;
				num = (short)1333284613;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1087373312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1939275776;
				if (num != 0)
				{
				}
				num = (short)1059586049;
				if (num != 0)
				{
				}
				return this.radErgoOptionalComponentCumulativeOverTemperatureAnnouncementVoiceCommand.Editable;
			}
			set
			{
				short num = (short)1274801562;
				short num2 = num;
				num = (short)1224076698;
				switch (num2 == num)
				{
				default:
				{
					num = (short)981598208;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)284688385;
				if (num != 0)
				{
				}
				num = (short)1375928320;
				if (num != 0)
				{
				}
				this.radErgoOptionalComponentCumulativeOverTemperatureAnnouncementVoiceCommand.Editable = value;
			}
		}

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x060004F6 RID: 1270 RVA: 0x000474BC File Offset: 0x000456BC
		internal string RadErgoOptionalComponentCumulativeOverTemperatureAnnouncementVoiceCommand_UILabel
		{
			get
			{
				short num = (short)384634091;
				short num2 = num;
				num = (short)1364659435;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1348337664;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)564985857;
				if (num != 0)
				{
				}
				num = (short)1574174720;
				if (num != 0)
				{
				}
				return this.radErgoOptionalComponentCumulativeOverTemperatureAnnouncementVoiceCommand.UIName;
			}
		}

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x060004F7 RID: 1271 RVA: 0x00047570 File Offset: 0x00045770
		// (set) Token: 0x060004F8 RID: 1272 RVA: 0x00047624 File Offset: 0x00045824
		internal bool RadErgoOptionalComponentCumulativeOverTemperatureAnnouncementVoiceCommand_HiddenStatic
		{
			get
			{
				short num = (short)1349779457;
				if (num != 0)
				{
				}
				num = (short)788332544;
				short num2 = num;
				num = (short)421893411;
				short num3 = num;
				num = (short)2144376099;
				switch (num3 == num)
				{
				}
				num = (short)1669005312;
				if (num != 0)
				{
				}
				return this.radErgoOptionalComponentCumulativeOverTemperatureAnnouncementVoiceCommand.HiddenStatic;
			}
			set
			{
				short num = (short)162630780;
				short num2 = num;
				num = (short)1170115708;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1273430016;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)288882689;
				if (num != 0)
				{
				}
				num = (short)1775566848;
				if (num != 0)
				{
				}
				this.radErgoOptionalComponentCumulativeOverTemperatureAnnouncementVoiceCommand.HiddenStatic = value;
			}
		}

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x060004F9 RID: 1273 RVA: 0x000476DC File Offset: 0x000458DC
		// (set) Token: 0x060004FA RID: 1274 RVA: 0x00047790 File Offset: 0x00045990
		internal bool RadErgoOptionalComponentCumulativeOverTemperatureAnnouncementVoiceCommand_HiddenDynamic
		{
			get
			{
				short num = (short)435572135;
				short num2 = num;
				num = (short)1951223207;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1220739072;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1980563456;
				if (num != 0)
				{
				}
				num = (short)875823105;
				if (num != 0)
				{
				}
				return this.radErgoOptionalComponentCumulativeOverTemperatureAnnouncementVoiceCommand.HiddenDynamic;
			}
			set
			{
				short num = (short)1912952369;
				short num2 = num;
				num = (short)1767659057;
				switch (num2 == num)
				{
				default:
				{
					num = (short)963575808;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1069088768;
				if (num != 0)
				{
				}
				num = (short)587399169;
				if (num != 0)
				{
				}
				this.radErgoOptionalComponentCumulativeOverTemperatureAnnouncementVoiceCommand.HiddenDynamic = value;
			}
		}

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x060004FB RID: 1275 RVA: 0x00047844 File Offset: 0x00045A44
		public bool RadErgoOptionalComponentCumulativeOverTemperatureAnnouncementVoiceCommand_HasDiffs
		{
			get
			{
				short num = (short)1102026152;
				short num2 = num;
				num = (short)528127400;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1510342656;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1977352193;
				if (num != 0)
				{
				}
				num = (short)645857280;
				if (num != 0)
				{
				}
				return this.radErgoOptionalComponentCumulativeOverTemperatureAnnouncementVoiceCommand._HasDiffs;
			}
		}

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x060004FC RID: 1276 RVA: 0x000478F8 File Offset: 0x00045AF8
		// (set) Token: 0x060004FD RID: 1277 RVA: 0x000479B0 File Offset: 0x00045BB0
		public string RadErgoBatteryCumulativeOverTemperatureAnnouncementVoiceCommandValue
		{
			get
			{
				short num = (short)1550315202;
				short num2 = num;
				num = (short)1427435202;
				switch (num2 == num)
				{
				default:
				{
					num = (short)921108480;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1913782273;
				if (num != 0)
				{
				}
				num = (short)15859712;
				if (num != 0)
				{
				}
				return this.radErgoBatteryCumulativeOverTemperatureAnnouncementVoiceCommand.Value;
			}
			set
			{
				short num = (short)2006628243;
				short num2 = num;
				num = (short)2047784851;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1072037888;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1978531841;
				if (num != 0)
				{
				}
				num = (short)1536950272;
				if (num != 0)
				{
				}
				this.radErgoBatteryCumulativeOverTemperatureAnnouncementVoiceCommand.Value = value;
			}
		}

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x060004FE RID: 1278 RVA: 0x00047A64 File Offset: 0x00045C64
		public global::AcpBusinessLayer.AcpField<string> RadErgoBatteryCumulativeOverTemperatureAnnouncementVoiceCommand
		{
			get
			{
				short num = (short)941162496;
				short num2 = num;
				num = (short)1899848369;
				short num3 = num;
				num = (short)1287152305;
				switch (num3 == num)
				{
				}
				num = (short)1347223552;
				if (num != 0)
				{
				}
				num = (short)1803681793;
				if (num != 0)
				{
				}
				return this.radErgoBatteryCumulativeOverTemperatureAnnouncementVoiceCommand;
			}
		}

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x060004FF RID: 1279 RVA: 0x00047B14 File Offset: 0x00045D14
		// (set) Token: 0x06000500 RID: 1280 RVA: 0x00047BC8 File Offset: 0x00045DC8
		public string RadErgoBatteryCumulativeOverTemperatureAnnouncementVoiceCommand_UIValue
		{
			get
			{
				short num = (short)1116012544;
				short num2 = num;
				num = (short)1604284637;
				short num3 = num;
				num = (short)1229811933;
				switch (num3 == num)
				{
				}
				num = (short)1857814529;
				if (num != 0)
				{
				}
				num = (short)1976303616;
				if (num != 0)
				{
				}
				return this.radErgoBatteryCumulativeOverTemperatureAnnouncementVoiceCommand.Value;
			}
			set
			{
				short num = (short)2063007744;
				short num2 = num;
				num = (short)22936593;
				short num3 = num;
				num = (short)240450577;
				switch (num3 == num)
				{
				}
				num = (short)2067660801;
				if (num != 0)
				{
				}
				num = (short)490274816;
				if (num != 0)
				{
				}
				this.radErgoBatteryCumulativeOverTemperatureAnnouncementVoiceCommand.Value = value;
			}
		}

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x06000501 RID: 1281 RVA: 0x00047C80 File Offset: 0x00045E80
		// (set) Token: 0x06000502 RID: 1282 RVA: 0x00047D34 File Offset: 0x00045F34
		public bool RadErgoBatteryCumulativeOverTemperatureAnnouncementVoiceCommand_Applicable
		{
			get
			{
				short num = (short)2090401792;
				short num2 = num;
				num = (short)1819738113;
				if (num != 0)
				{
				}
				num = (short)1675088161;
				short num3 = num;
				num = (short)1568723233;
				switch (num3 == num)
				{
				}
				num = (short)1576861696;
				if (num != 0)
				{
				}
				return this.radErgoBatteryCumulativeOverTemperatureAnnouncementVoiceCommand.Applicable;
			}
			set
			{
				short num = (short)594018304;
				short num2 = num;
				num = (short)1406654255;
				short num3 = num;
				num = (short)499373871;
				switch (num3 == num)
				{
				}
				num = (short)1275658241;
				if (num != 0)
				{
				}
				num = (short)1239285760;
				if (num != 0)
				{
				}
				this.radErgoBatteryCumulativeOverTemperatureAnnouncementVoiceCommand.Applicable = value;
			}
		}

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x06000503 RID: 1283 RVA: 0x00047DEC File Offset: 0x00045FEC
		// (set) Token: 0x06000504 RID: 1284 RVA: 0x00047EA4 File Offset: 0x000460A4
		public bool RadErgoBatteryCumulativeOverTemperatureAnnouncementVoiceCommand_Valid
		{
			get
			{
				short num = (short)564592640;
				short num2 = num;
				num = (short)302317569;
				if (num != 0)
				{
				}
				num = (short)515273033;
				short num3 = num;
				num = (short)652177737;
				switch (num3 == num)
				{
				}
				num = (short)1298464768;
				if (num != 0)
				{
				}
				return this.radErgoBatteryCumulativeOverTemperatureAnnouncementVoiceCommand.Valid;
			}
			set
			{
				short num = (short)1579024384;
				short num2 = num;
				num = (short)2079319621;
				short num3 = num;
				num = (short)1453319749;
				switch (num3 == num)
				{
				}
				num = (short)1464860672;
				if (num != 0)
				{
				}
				num = (short)646119425;
				if (num != 0)
				{
				}
				this.radErgoBatteryCumulativeOverTemperatureAnnouncementVoiceCommand.Valid = value;
			}
		}

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x06000505 RID: 1285 RVA: 0x00047F5C File Offset: 0x0004615C
		// (set) Token: 0x06000506 RID: 1286 RVA: 0x0004800C File Offset: 0x0004620C
		public bool RadErgoBatteryCumulativeOverTemperatureAnnouncementVoiceCommand_Visible
		{
			get
			{
				short num = (short)102957056;
				short num2 = num;
				num = (short)1382297835;
				short num3 = num;
				num = (short)494874859;
				switch (num3 == num)
				{
				}
				num = (short)137035776;
				if (num != 0)
				{
				}
				num = (short)53149697;
				if (num != 0)
				{
				}
				return this.radErgoBatteryCumulativeOverTemperatureAnnouncementVoiceCommand.Visible;
			}
			set
			{
				short num = (short)1154678784;
				short num2 = num;
				num = (short)268697429;
				short num3 = num;
				num = (short)1808072533;
				switch (num3 == num)
				{
				}
				num = (short)1845428225;
				if (num != 0)
				{
				}
				num = (short)1280376832;
				if (num != 0)
				{
				}
				this.radErgoBatteryCumulativeOverTemperatureAnnouncementVoiceCommand.Visible = value;
			}
		}

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x06000507 RID: 1287 RVA: 0x000480C4 File Offset: 0x000462C4
		// (set) Token: 0x06000508 RID: 1288 RVA: 0x00048178 File Offset: 0x00046378
		public bool RadErgoBatteryCumulativeOverTemperatureAnnouncementVoiceCommand_Editable
		{
			get
			{
				short num = (short)534118400;
				short num2 = num;
				num = (short)620822529;
				if (num != 0)
				{
				}
				num = (short)265270760;
				short num3 = num;
				num = (short)1813886440;
				switch (num3 == num)
				{
				}
				num = (short)1742602240;
				if (num != 0)
				{
				}
				return this.radErgoBatteryCumulativeOverTemperatureAnnouncementVoiceCommand.Editable;
			}
			set
			{
				short num = (short)842006528;
				short num2 = num;
				num = (short)1239547905;
				if (num != 0)
				{
				}
				num = (short)1467143013;
				short num3 = num;
				num = (short)1714213733;
				switch (num3 == num)
				{
				}
				num = (short)1510080512;
				if (num != 0)
				{
				}
				this.radErgoBatteryCumulativeOverTemperatureAnnouncementVoiceCommand.Editable = value;
			}
		}

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x06000509 RID: 1289 RVA: 0x0004822C File Offset: 0x0004642C
		internal string RadErgoBatteryCumulativeOverTemperatureAnnouncementVoiceCommand_UILabel
		{
			get
			{
				short num = (short)743243776;
				short num2 = num;
				num = (short)118481389;
				short num3 = num;
				num = (short)685826541;
				switch (num3 == num)
				{
				}
				num = (short)1964441600;
				if (num != 0)
				{
				}
				num = (short)2135556097;
				if (num != 0)
				{
				}
				return this.radErgoBatteryCumulativeOverTemperatureAnnouncementVoiceCommand.UIName;
			}
		}

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x0600050A RID: 1290 RVA: 0x000482E0 File Offset: 0x000464E0
		// (set) Token: 0x0600050B RID: 1291 RVA: 0x00048394 File Offset: 0x00046594
		internal bool RadErgoBatteryCumulativeOverTemperatureAnnouncementVoiceCommand_HiddenStatic
		{
			get
			{
				short num = (short)851968;
				short num2 = num;
				num = (short)1358669473;
				short num3 = num;
				num = (short)335128225;
				switch (num3 == num)
				{
				}
				num = (short)311164928;
				if (num != 0)
				{
				}
				num = (short)130809857;
				if (num != 0)
				{
				}
				return this.radErgoBatteryCumulativeOverTemperatureAnnouncementVoiceCommand.HiddenStatic;
			}
			set
			{
				short num = (short)1186791424;
				short num2 = num;
				num = (short)1312629405;
				short num3 = num;
				num = (short)1915495069;
				switch (num3 == num)
				{
				}
				num = (short)533135361;
				if (num != 0)
				{
				}
				num = (short)1498349568;
				if (num != 0)
				{
				}
				this.radErgoBatteryCumulativeOverTemperatureAnnouncementVoiceCommand.HiddenStatic = value;
			}
		}

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x0600050C RID: 1292 RVA: 0x00048448 File Offset: 0x00046648
		// (set) Token: 0x0600050D RID: 1293 RVA: 0x000484FC File Offset: 0x000466FC
		internal bool RadErgoBatteryCumulativeOverTemperatureAnnouncementVoiceCommand_HiddenDynamic
		{
			get
			{
				short num = (short)1389363200;
				short num2 = num;
				num = (short)1228537857;
				if (num != 0)
				{
				}
				num = (short)234366182;
				short num3 = num;
				num = (short)836379878;
				switch (num3 == num)
				{
				}
				num = (short)698286080;
				if (num != 0)
				{
				}
				return this.radErgoBatteryCumulativeOverTemperatureAnnouncementVoiceCommand.HiddenDynamic;
			}
			set
			{
				short num = (short)1713766400;
				short num2 = num;
				num = (short)179117332;
				short num3 = num;
				num = (short)2087066900;
				switch (num3 == num)
				{
				}
				num = (short)1566900225;
				if (num != 0)
				{
				}
				num = (short)548012032;
				if (num != 0)
				{
				}
				this.radErgoBatteryCumulativeOverTemperatureAnnouncementVoiceCommand.HiddenDynamic = value;
			}
		}

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x0600050E RID: 1294 RVA: 0x000485B0 File Offset: 0x000467B0
		public bool RadErgoBatteryCumulativeOverTemperatureAnnouncementVoiceCommand_HasDiffs
		{
			get
			{
				short num = (short)1307639808;
				short num2 = num;
				num = (short)612571426;
				short num3 = num;
				num = (short)768284962;
				switch (num3 == num)
				{
				}
				num = (short)1487405056;
				if (num != 0)
				{
				}
				num = (short)798031873;
				if (num != 0)
				{
				}
				return this.radErgoBatteryCumulativeOverTemperatureAnnouncementVoiceCommand._HasDiffs;
			}
		}

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x0600050F RID: 1295 RVA: 0x00048664 File Offset: 0x00046864
		// (set) Token: 0x06000510 RID: 1296 RVA: 0x00048718 File Offset: 0x00046918
		public string RadErgoNonHZMAccessoryAnnouncementVoiceCommandValue
		{
			get
			{
				short num = (short)1809842176;
				short num2 = num;
				num = (short)1115802008;
				short num3 = num;
				num = (short)860408216;
				switch (num3 == num)
				{
				}
				num = (short)1181024257;
				if (num != 0)
				{
				}
				num = (short)1928003584;
				if (num != 0)
				{
				}
				return this.radErgoNonHZMAccessoryAnnouncementVoiceCommand.Value;
			}
			set
			{
				short num = (short)1922236416;
				short num2 = num;
				num = (short)1299166581;
				short num3 = num;
				num = (short)638367093;
				switch (num3 == num)
				{
				}
				num = (short)766574592;
				if (num != 0)
				{
				}
				num = (short)611254273;
				if (num != 0)
				{
				}
				this.radErgoNonHZMAccessoryAnnouncementVoiceCommand.Value = value;
			}
		}

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x06000511 RID: 1297 RVA: 0x000487D0 File Offset: 0x000469D0
		public global::AcpBusinessLayer.AcpField<string> RadErgoNonHZMAccessoryAnnouncementVoiceCommand
		{
			get
			{
				short num = (short)255852544;
				short num2 = num;
				num = (short)963653579;
				short num3 = num;
				num = (short)268382155;
				switch (num3 == num)
				{
				}
				num = (short)176685056;
				if (num != 0)
				{
				}
				num = (short)1814036481;
				if (num != 0)
				{
				}
				return this.radErgoNonHZMAccessoryAnnouncementVoiceCommand;
			}
		}

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x06000512 RID: 1298 RVA: 0x00048880 File Offset: 0x00046A80
		// (set) Token: 0x06000513 RID: 1299 RVA: 0x00048934 File Offset: 0x00046B34
		public string RadErgoNonHZMAccessoryAnnouncementVoiceCommand_UIValue
		{
			get
			{
				short num = (short)905052160;
				short num2 = num;
				num = (short)1867917554;
				short num3 = num;
				num = (short)1049241842;
				switch (num3 == num)
				{
				}
				num = (short)277413888;
				if (num != 0)
				{
				}
				num = (short)348061697;
				if (num != 0)
				{
				}
				return this.radErgoNonHZMAccessoryAnnouncementVoiceCommand.Value;
			}
			set
			{
				short num = (short)719519744;
				short num2 = num;
				num = (short)588366875;
				short num3 = num;
				num = (short)2122826779;
				switch (num3 == num)
				{
				}
				num = (short)1992097793;
				if (num != 0)
				{
				}
				num = (short)506200064;
				if (num != 0)
				{
				}
				this.radErgoNonHZMAccessoryAnnouncementVoiceCommand.Value = value;
			}
		}

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x06000514 RID: 1300 RVA: 0x000489E8 File Offset: 0x00046BE8
		// (set) Token: 0x06000515 RID: 1301 RVA: 0x00048A9C File Offset: 0x00046C9C
		public bool RadErgoNonHZMAccessoryAnnouncementVoiceCommand_Applicable
		{
			get
			{
				short num = (short)2012938240;
				short num2 = num;
				num = (short)701608377;
				short num3 = num;
				num = (short)1023193529;
				switch (num3 == num)
				{
				}
				num = (short)256049153;
				if (num != 0)
				{
				}
				num = (short)1412300800;
				if (num != 0)
				{
				}
				return this.radErgoNonHZMAccessoryAnnouncementVoiceCommand.Applicable;
			}
			set
			{
				short num = (short)950468608;
				short num2 = num;
				num = (short)563445548;
				short num3 = num;
				num = (short)1093369644;
				switch (num3 == num)
				{
				}
				num = (short)1082851329;
				if (num != 0)
				{
				}
				num = (short)212271104;
				if (num != 0)
				{
				}
				this.radErgoNonHZMAccessoryAnnouncementVoiceCommand.Applicable = value;
			}
		}

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x06000516 RID: 1302 RVA: 0x00048B54 File Offset: 0x00046D54
		// (set) Token: 0x06000517 RID: 1303 RVA: 0x00048C08 File Offset: 0x00046E08
		public bool RadErgoNonHZMAccessoryAnnouncementVoiceCommand_Valid
		{
			get
			{
				short num = (short)1359085568;
				short num2 = num;
				num = (short)223476481;
				short num3 = num;
				num = (short)243792641;
				switch (num3 == num)
				{
				}
				num = (short)1722744833;
				if (num != 0)
				{
				}
				num = (short)1496842240;
				if (num != 0)
				{
				}
				return this.radErgoNonHZMAccessoryAnnouncementVoiceCommand.Valid;
			}
			set
			{
				short num = (short)595918848;
				short num2 = num;
				num = (short)692405605;
				short num3 = num;
				num = (short)686441829;
				switch (num3 == num)
				{
				}
				num = (short)661848064;
				if (num != 0)
				{
				}
				num = (short)1428553729;
				if (num != 0)
				{
				}
				this.radErgoNonHZMAccessoryAnnouncementVoiceCommand.Valid = value;
			}
		}

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x06000518 RID: 1304 RVA: 0x00048CBC File Offset: 0x00046EBC
		// (set) Token: 0x06000519 RID: 1305 RVA: 0x00048D70 File Offset: 0x00046F70
		public bool RadErgoNonHZMAccessoryAnnouncementVoiceCommand_Visible
		{
			get
			{
				short num = (short)279379968;
				short num2 = num;
				num = (short)11403265;
				if (num != 0)
				{
				}
				num = (short)1958412067;
				short num3 = num;
				num = (short)98369315;
				switch (num3 == num)
				{
				}
				num = (short)618332160;
				if (num != 0)
				{
				}
				return this.radErgoNonHZMAccessoryAnnouncementVoiceCommand.Visible;
			}
			set
			{
				short num = (short)1883373568;
				short num2 = num;
				num = (short)645196622;
				short num3 = num;
				num = (short)1358687054;
				switch (num3 == num)
				{
				}
				num = (short)982581249;
				if (num != 0)
				{
				}
				num = (short)183238656;
				if (num != 0)
				{
				}
				this.radErgoNonHZMAccessoryAnnouncementVoiceCommand.Visible = value;
			}
		}

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x0600051A RID: 1306 RVA: 0x00048E28 File Offset: 0x00047028
		// (set) Token: 0x0600051B RID: 1307 RVA: 0x00048EDC File Offset: 0x000470DC
		public bool RadErgoNonHZMAccessoryAnnouncementVoiceCommand_Editable
		{
			get
			{
				short num = (short)299040768;
				short num2 = num;
				num = (short)1871240132;
				short num3 = num;
				num = (short)822467524;
				switch (num3 == num)
				{
				}
				num = (short)1639383041;
				if (num != 0)
				{
				}
				num = (short)378535936;
				if (num != 0)
				{
				}
				return this.radErgoNonHZMAccessoryAnnouncementVoiceCommand.Editable;
			}
			set
			{
				short num = (short)1909391360;
				short num2 = num;
				num = (short)2069501392;
				short num3 = num;
				num = (short)479270352;
				switch (num3 == num)
				{
				}
				num = (short)2000224256;
				if (num != 0)
				{
				}
				num = (short)1165033473;
				if (num != 0)
				{
				}
				this.radErgoNonHZMAccessoryAnnouncementVoiceCommand.Editable = value;
			}
		}

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x0600051C RID: 1308 RVA: 0x00048F90 File Offset: 0x00047190
		internal string RadErgoNonHZMAccessoryAnnouncementVoiceCommand_UILabel
		{
			get
			{
				short num = (short)156499968;
				short num2 = num;
				num = (short)284950529;
				if (num != 0)
				{
				}
				num = (short)101006172;
				short num3 = num;
				num = (short)231750492;
				switch (num3 == num)
				{
				}
				num = (short)1995767808;
				if (num != 0)
				{
				}
				return this.radErgoNonHZMAccessoryAnnouncementVoiceCommand.UIName;
			}
		}

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x0600051D RID: 1309 RVA: 0x00049048 File Offset: 0x00047248
		// (set) Token: 0x0600051E RID: 1310 RVA: 0x00049100 File Offset: 0x00047300
		internal bool RadErgoNonHZMAccessoryAnnouncementVoiceCommand_HiddenStatic
		{
			get
			{
				short num = (short)1475084288;
				short num2 = num;
				num = (short)1101127544;
				short num3 = num;
				num = (short)247717752;
				switch (num3 == num)
				{
				}
				num = (short)2127364097;
				if (num != 0)
				{
				}
				num = (short)1275854848;
				if (num != 0)
				{
				}
				return this.radErgoNonHZMAccessoryAnnouncementVoiceCommand.HiddenStatic;
			}
			set
			{
				short num = (short)1331101696;
				short num2 = num;
				num = (short)1154940929;
				if (num != 0)
				{
				}
				num = (short)1838451601;
				short num3 = num;
				num = (short)400788369;
				switch (num3 == num)
				{
				}
				num = (short)1271595008;
				if (num != 0)
				{
				}
				this.radErgoNonHZMAccessoryAnnouncementVoiceCommand.HiddenStatic = value;
			}
		}

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x0600051F RID: 1311 RVA: 0x000491B8 File Offset: 0x000473B8
		// (set) Token: 0x06000520 RID: 1312 RVA: 0x0004926C File Offset: 0x0004746C
		internal bool RadErgoNonHZMAccessoryAnnouncementVoiceCommand_HiddenDynamic
		{
			get
			{
				short num = (short)52822016;
				short num2 = num;
				num = (short)572915678;
				short num3 = num;
				num = (short)226230238;
				switch (num3 == num)
				{
				}
				num = (short)1106968576;
				if (num != 0)
				{
				}
				num = (short)1205534721;
				if (num != 0)
				{
				}
				return this.radErgoNonHZMAccessoryAnnouncementVoiceCommand.HiddenDynamic;
			}
			set
			{
				short num = (short)1665269760;
				short num2 = num;
				num = (short)2078867457;
				if (num != 0)
				{
				}
				num = (short)76319151;
				short num3 = num;
				num = (short)892832175;
				switch (num3 == num)
				{
				}
				num = (short)2026700800;
				if (num != 0)
				{
				}
				this.radErgoNonHZMAccessoryAnnouncementVoiceCommand.HiddenDynamic = value;
			}
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x06000521 RID: 1313 RVA: 0x00049320 File Offset: 0x00047520
		public bool RadErgoNonHZMAccessoryAnnouncementVoiceCommand_HasDiffs
		{
			get
			{
				short num = (short)1209794560;
				short num2 = num;
				num = (short)442323284;
				short num3 = num;
				num = (short)1094275412;
				switch (num3 == num)
				{
				}
				num = (short)285278208;
				if (num != 0)
				{
				}
				num = (short)1305280513;
				if (num != 0)
				{
				}
				return this.radErgoNonHZMAccessoryAnnouncementVoiceCommand._HasDiffs;
			}
		}

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x06000522 RID: 1314 RVA: 0x000493D4 File Offset: 0x000475D4
		public string TTSTargetSpeaker
		{
			get
			{
				short num = (short)462487552;
				short num2 = num;
				num = (short)1674235294;
				short num3 = num;
				num = (short)1172032926;
				switch (num3 == num)
				{
				}
				num = (short)1909719041;
				if (num != 0)
				{
				}
				num = (short)773980160;
				if (num != 0)
				{
				}
				return global::Features.Radio_Ergonomics_Configuration.Display_and_Menu.TtsSpeaker.TargetSpeaker;
			}
		}

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x06000523 RID: 1315 RVA: 0x00049484 File Offset: 0x00047684
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide RefRadioWide
		{
			get
			{
				short num = (short)1959198720;
				short num2 = num;
				num = (short)41487233;
				short num3 = num;
				num = (short)390990721;
				switch (num3 == num)
				{
				}
				num = (short)1872887809;
				if (num != 0)
				{
				}
				num = (short)1737228288;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
			}
		}

		// Token: 0x06000524 RID: 1316 RVA: 0x00049544 File Offset: 0x00047744
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			short num = (short)347725771;
			short num2 = num;
			num = (short)485679051;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_6E;
			default:
				num = (short)810221568;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_6E;
				}
				break;
			}
			int num3;
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_54:
				switch (num3)
				{
				case 0:
					if (base.ParentRecset != null)
					{
						num = (short)1425014785;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 1:
					num = (short)593952770;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num = (short)1105330179;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 3:
				{
					num = (short)231800833;
					if (num != 0)
					{
					}
					num = (short)676790272;
					short num4 = num;
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num = (short)1219952644;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					return result;
				}
				goto IL_6E;
			}
			return result;
			IL_6E:
			result = null;
			num = (short)1013514240;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_54;
		}

		// Token: 0x04000060 RID: 96
		private global::AcpBusinessLayer.AcpField<bool> siteSelectableAlertAllowedinOutofRange_A42013;

		// Token: 0x04000061 RID: 97
		private global::AcpBusinessLayer.AcpSparseLOVField voiceAnnouncementPriority_A7651;

		// Token: 0x04000062 RID: 98
		private global::AcpBusinessLayer.AcpField<bool> suppressReplay_A44925;

		// Token: 0x04000063 RID: 99
		private global::AcpBusinessLayer.AcpRecRefField scanOnAnnouncementID_A22250;

		// Token: 0x04000064 RID: 100
		private global::AcpBusinessLayer.AcpRecRefField scanOffAnnouncementID_A22252;

		// Token: 0x04000065 RID: 101
		private global::AcpBusinessLayer.AcpRecRefField monitorOnAnnouncementID_A22254;

		// Token: 0x04000066 RID: 102
		private global::AcpBusinessLayer.AcpRecRefField monitorOffAnnouncementID_A22256;

		// Token: 0x04000067 RID: 103
		private global::AcpBusinessLayer.AcpRecRefField directModeOnAnnouncementID_A22258;

		// Token: 0x04000068 RID: 104
		private global::AcpBusinessLayer.AcpRecRefField directModeOffAnnouncementID_A22121;

		// Token: 0x04000069 RID: 105
		private global::AcpBusinessLayer.AcpRecRefField txInhibitOnAnnouncementID_A22260;

		// Token: 0x0400006A RID: 106
		private global::AcpBusinessLayer.AcpRecRefField txInhibitOffAnnouncementID_A22262;

		// Token: 0x0400006B RID: 107
		private global::AcpBusinessLayer.AcpRecRefField radErgoCfgVAWide_A41497;

		// Token: 0x0400006C RID: 108
		private global::AcpBusinessLayer.AcpRecRefField radErgoCfgVAWide_A41499;

		// Token: 0x0400006D RID: 109
		private global::AcpBusinessLayer.AcpRecRefField radErgoCfgVAWide_A41500;

		// Token: 0x0400006E RID: 110
		private global::AcpBusinessLayer.AcpRecRefField radErgoCfgVAWide_A41501;

		// Token: 0x0400006F RID: 111
		private global::AcpBusinessLayer.AcpRecRefField radErgoCfgVAWide_A41502;

		// Token: 0x04000070 RID: 112
		private global::AcpBusinessLayer.AcpRecRefField radErgoCfgVAWide_A41503;

		// Token: 0x04000071 RID: 113
		private global::AcpBusinessLayer.AcpRecRefField radErgoCfgVAWide_A41504;

		// Token: 0x04000072 RID: 114
		private global::AcpBusinessLayer.AcpRecRefField radErgoCfgVAWide_A41505;

		// Token: 0x04000073 RID: 115
		private global::AcpBusinessLayer.AcpRecRefField radErgoCfgVAWide_A41506;

		// Token: 0x04000074 RID: 116
		private global::AcpBusinessLayer.AcpRecRefField wrongBatteryOnAnnouncementID_43251;

		// Token: 0x04000075 RID: 117
		private global::AcpBusinessLayer.AcpField<string> radErgoScanOnAnnouncementVoiceCommand;

		// Token: 0x04000076 RID: 118
		private global::AcpBusinessLayer.AcpField<string> radErgoScanOffAnnouncementVoiceCommand;

		// Token: 0x04000077 RID: 119
		private global::AcpBusinessLayer.AcpField<string> radErgoMonitorOnVoiceCommand;

		// Token: 0x04000078 RID: 120
		private global::AcpBusinessLayer.AcpField<string> radErgoMonitorOffVoiceCommand;

		// Token: 0x04000079 RID: 121
		private global::AcpBusinessLayer.AcpField<string> radErgoDirectModeOnVoiceCommand;

		// Token: 0x0400007A RID: 122
		private global::AcpBusinessLayer.AcpField<string> radErgoDirectModeOffVoiceCommand;

		// Token: 0x0400007B RID: 123
		private global::AcpBusinessLayer.AcpField<string> radErgoTxInhibitOnVoiceCommand;

		// Token: 0x0400007C RID: 124
		private global::AcpBusinessLayer.AcpField<string> radErgoTxInhibitOffVoiceCommand;

		// Token: 0x0400007D RID: 125
		private global::AcpBusinessLayer.AcpField<string> radErgoEmergencyOnVoiceCommand;

		// Token: 0x0400007E RID: 126
		private global::AcpBusinessLayer.AcpField<string> radErgoInCallUserAlertOnVoiceCommand;

		// Token: 0x0400007F RID: 127
		private global::AcpBusinessLayer.AcpField<string> radErgoInCallUserAlertOffVoiceCommand;

		// Token: 0x04000080 RID: 128
		private global::AcpBusinessLayer.AcpField<string> radErgoSecureTxSelectOnVoiceCommand;

		// Token: 0x04000081 RID: 129
		private global::AcpBusinessLayer.AcpField<string> radErgoSecureTxSelectOffVoiceCommand;

		// Token: 0x04000082 RID: 130
		private global::AcpBusinessLayer.AcpField<string> radErgoKeyPadControlsLockOnVoiceCommand;

		// Token: 0x04000083 RID: 131
		private global::AcpBusinessLayer.AcpField<string> radErgoKeyPadControlsLockOffVoiceCommand;

		// Token: 0x04000084 RID: 132
		private global::AcpBusinessLayer.AcpField<string> radErgoMultiFuntionalButtonPrimaryModeCommand;

		// Token: 0x04000085 RID: 133
		private global::AcpBusinessLayer.AcpField<string> radErgoMultiFuntionalButtonSecondaryModeCommand;

		// Token: 0x04000086 RID: 134
		private global::AcpBusinessLayer.AcpField<string> radErgoWrongBatteryVoiceCommand;

		// Token: 0x04000087 RID: 135
		private global::AcpBusinessLayer.AcpRecRefField radErgoCfgVAWideExitHazardZoneMode;

		// Token: 0x04000088 RID: 136
		private global::AcpBusinessLayer.AcpField<string> radErgoExitHazardZoneModeAnnouncementVoiceCommand;

		// Token: 0x04000089 RID: 137
		private global::AcpBusinessLayer.AcpRecRefField radErgoCfgVAWideSelfCheckFailure;

		// Token: 0x0400008A RID: 138
		private global::AcpBusinessLayer.AcpField<string> radErgoSelfCheckFailAnnouncementVoiceCommand;

		// Token: 0x0400008B RID: 139
		private global::AcpBusinessLayer.AcpRecRefField radErgoCfgVAWideAccessoryFailure;

		// Token: 0x0400008C RID: 140
		private global::AcpBusinessLayer.AcpField<string> radErgoAccessoryFailureAnnouncementVoiceCommand;

		// Token: 0x0400008D RID: 141
		private global::AcpBusinessLayer.AcpRecRefField radErgoCfgVAWideOutOfRange;

		// Token: 0x0400008E RID: 142
		private global::AcpBusinessLayer.AcpField<string> radErgoOutOfRangeAnnouncementVoiceCommand;

		// Token: 0x0400008F RID: 143
		private global::AcpBusinessLayer.AcpRecRefField radErgoCfgVAWideOverTemperature;

		// Token: 0x04000090 RID: 144
		private global::AcpBusinessLayer.AcpField<string> radErgoOverTemperatureAnnouncementVoiceCommand;

		// Token: 0x04000091 RID: 145
		private global::AcpBusinessLayer.AcpField<string> radErgoPowerDownAnnouncementVoiceCommand;

		// Token: 0x04000092 RID: 146
		private global::AcpBusinessLayer.AcpField<string> radErgoAntennaFailureAnnouncementVoiceCommand;

		// Token: 0x04000093 RID: 147
		private global::AcpBusinessLayer.AcpRecRefField radErgoCfgVAWidePowerDown;

		// Token: 0x04000094 RID: 148
		private global::AcpBusinessLayer.AcpRecRefField radErgoCfgVAWideAntennaFailure;

		// Token: 0x04000095 RID: 149
		private global::AcpBusinessLayer.AcpRecRefField radErgoCfgVAWideRFDeviceCumulativeOverTemperature;

		// Token: 0x04000096 RID: 150
		private global::AcpBusinessLayer.AcpRecRefField radErgoCfgVAWideOptionalComponentCumulativeOverTemperature;

		// Token: 0x04000097 RID: 151
		private global::AcpBusinessLayer.AcpRecRefField radErgoCfgVAWideNonHZMAccessory;

		// Token: 0x04000098 RID: 152
		private global::AcpBusinessLayer.AcpRecRefField radErgoCfgVAWideBatteryCumulativeOverTemperature;

		// Token: 0x04000099 RID: 153
		private global::AcpBusinessLayer.AcpField<string> radErgoRfDeviceCumulativeOverTemperatureAnnouncementVoiceCommand;

		// Token: 0x0400009A RID: 154
		private global::AcpBusinessLayer.AcpField<string> radErgoOptionalComponentCumulativeOverTemperatureAnnouncementVoiceCommand;

		// Token: 0x0400009B RID: 155
		private global::AcpBusinessLayer.AcpField<string> radErgoBatteryCumulativeOverTemperatureAnnouncementVoiceCommand;

		// Token: 0x0400009C RID: 156
		private global::AcpBusinessLayer.AcpField<string> radErgoNonHZMAccessoryAnnouncementVoiceCommand;
	}
}
