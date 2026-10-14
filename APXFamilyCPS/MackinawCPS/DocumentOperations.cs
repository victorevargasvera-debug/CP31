using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using AcpBusinessLayer;
using AcpBusinessLayer.UndoRedo;
using AcpCommonLib;
using AcpCommonLib.UndoRedo;
using Common;
using CommonResources;
using ConstraintHelper;
using Motorola.MackinawCPS.CoreFeatures.ActionConsolidation;
using Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList;
using Motorola.MackinawCPS.CoreFeatures.Buttons;
using Motorola.MackinawCPS.CoreFeatures.ControlHeadE5;
using Motorola.MackinawCPS.CoreFeatures.ControlHeadO2;
using Motorola.MackinawCPS.CoreFeatures.ControlHeadO3;
using Motorola.MackinawCPS.CoreFeatures.ControlHeadO5;
using Motorola.MackinawCPS.CoreFeatures.ControlHeadO7;
using Motorola.MackinawCPS.CoreFeatures.ControlHeadO9;
using Motorola.MackinawCPS.CoreFeatures.ConventionalAliasLists;
using Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles;
using Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality;
using Motorola.MackinawCPS.CoreFeatures.ConventionalSystem;
using Motorola.MackinawCPS.CoreFeatures.ConventionalWide;
using Motorola.MackinawCPS.CoreFeatures.DataProfiles;
using Motorola.MackinawCPS.CoreFeatures.DataWide;
using Motorola.MackinawCPS.CoreFeatures.DEK;
using Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu;
using Motorola.MackinawCPS.CoreFeatures.DVRSProfiles;
using Motorola.MackinawCPS.CoreFeatures.DVRSWide;
using Motorola.MackinawCPS.CoreFeatures.EmergencyWide;
using Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList;
using Motorola.MackinawCPS.CoreFeatures.ExternalMicNoiseReductionProfile;
using Motorola.MackinawCPS.CoreFeatures.FactoryOverrides;
using Motorola.MackinawCPS.CoreFeatures.GlobalNoiseReductionList;
using Motorola.MackinawCPS.CoreFeatures.InternalMicNoiseReductionProfile;
using Motorola.MackinawCPS.CoreFeatures.Keypad;
using Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories;
using Motorola.MackinawCPS.CoreFeatures.MenuItems;
using Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence;
using Motorola.MackinawCPS.CoreFeatures.MPLConfiguration;
using Motorola.MackinawCPS.CoreFeatures.NonGUIFeature;
using Motorola.MackinawCPS.CoreFeatures.PersonnelAccountability;
using Motorola.MackinawCPS.CoreFeatures.PhoneWide;
using Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide;
using Motorola.MackinawCPS.CoreFeatures.RadioInformation;
using Motorola.MackinawCPS.CoreFeatures.RadioProfiles;
using Motorola.MackinawCPS.CoreFeatures.RadioVIPs;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;
using Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic;
using Motorola.MackinawCPS.CoreFeatures.RepeaterIDList;
using Motorola.MackinawCPS.CoreFeatures.ScanList;
using Motorola.MackinawCPS.CoreFeatures.ScanWide;
using Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile;
using Motorola.MackinawCPS.CoreFeatures.SecureWide;
using Motorola.MackinawCPS.CoreFeatures.Shepherds;
using Motorola.MackinawCPS.CoreFeatures.SmartKeyFob;
using Motorola.MackinawCPS.CoreFeatures.Switches;
using Motorola.MackinawCPS.CoreFeatures.ToneSignalingList;
using Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles;
using Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality;
using Motorola.MackinawCPS.CoreFeatures.TrunkingSystem;
using Motorola.MackinawCPS.CoreFeatures.TrunkingWide;
using Motorola.MackinawCPS.CoreFeatures.VirtualPartnerAlert;
using Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment;
using PreEmptive.SoS.Runtime;
using SpecialFeatures.Comms;
using SpecialFeatures.DVRSFiles.List;
using SpecialFeatures.Flashport.FlashRadio;
using SpecialFeatures.Security;
using SpecialFeatures.SystemCertificates.List;
using SpecialFeatures.Ucl.Contact;
using SpecialFeatures.Ucl.HotList;
using SpecialFeatures.Ucl.UclWide;
using SpecialFeatures.VoiceAnnouncements.List;
using SpecialFeatures.VoiceAnnouncements.SiteSelectableAlertList;
using SpecialFeatures.VoiceAnnouncements.Wide;

namespace MackinawCPS
{
	// Token: 0x02000031 RID: 49
	public class DocumentOperations
	{
		// Token: 0x060000BD RID: 189 RVA: 0x0001422C File Offset: 0x0001242C
		public void InitDocument()
		{
			short num = (short)1919040973;
			short num2 = num;
			num = (short)637156813;
			switch (num2 == num)
			{
			default:
			{
				num = (short)582549504;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)751435776;
			if (num != 0)
			{
			}
			num = (short)858849281;
			if (num != 0)
			{
			}
			global::AcpBusinessLayer.AcpDocument theDocument = ((global::MackinawCPS.App)global::System.Windows.Application.Current).TheDocument;
			this.InitDocument(theDocument);
		}

		// Token: 0x060000BE RID: 190 RVA: 0x000142EC File Offset: 0x000124EC
		public void InitDocument(global::AcpCommonLib.Document doc)
		{
			if (doc == null)
			{
				short num = (short)1208188128;
				short num2 = num;
				num = (short)854752480;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1957232641;
					if (num != 0)
					{
					}
					num = (short)91095040;
					if (num != 0)
					{
					}
					num = (short)1804468224;
					short num3 = num;
					break;
				}
				}
				return;
			}
			global::AcpCommonLib.FeatureManager.BeginAddFeatures(doc);
			global::MackinawCPS.DocumentOperations.AddAllFeatures(doc);
			global::AcpCommonLib.FeatureManager.EndAddFeatures(doc);
			this.UclTemplateNodeInit();
			doc.ModificationLogEnabled = false;
		}

		// Token: 0x060000BF RID: 191 RVA: 0x000143BC File Offset: 0x000125BC
		public static void AddAllFeatures()
		{
			short num = (short)827588609;
			if (num != 0)
			{
			}
			num = (short)1290534912;
			short num2 = num;
			num = (short)1827045798;
			short num3 = num;
			num = (short)1250132390;
			switch (num3 == num)
			{
			}
			num = (short)279314432;
			if (num != 0)
			{
			}
			global::Common.CodeplugStatusManager.Status = global::Common.CodeplugStatus.Opening;
			global::AcpCommonLib.ConstraintManager.Suspend();
			global::AcpCommonLib.FeatureManager.AddFeature(new global::Motorola.MackinawCPS.CoreFeatures.NonGUIFeature.NonGUIFeatureRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(new global::Motorola.MackinawCPS.CoreFeatures.PhoneWide.PhoneWideRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(new global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.FactoryOverridesRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(new global::Motorola.MackinawCPS.CoreFeatures.ConventionalAliasLists.ConventionalAliasListsRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(new global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.DisplayAndMenuRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(new global::Motorola.MackinawCPS.CoreFeatures.Shepherds.ShepherdsRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(new global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(new global::Motorola.MackinawCPS.CoreFeatures.ScanWide.ScanWideRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(new global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.ConventionalWideRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(new global::Motorola.MackinawCPS.CoreFeatures.TrunkingWide.TrunkingWideRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(new global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(new global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.EmergencyWideRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(new global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWideRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(new global::Motorola.MackinawCPS.CoreFeatures.RepeaterIDList.RepeaterIDListRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(new global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RemoteSpeakerMicRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(new global::Motorola.MackinawCPS.CoreFeatures.Switches.SwitchesRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(new global::Motorola.MackinawCPS.CoreFeatures.Buttons.ButtonsRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(new global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(new global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformationRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(new global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(new global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(new global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(new global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(new global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(new global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(new global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.ASTROTalkgroupListRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(new global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(new global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(new global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.ConventionalEmergencyProfilesRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(new global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfilesRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(new global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfilesRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(new global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLConfigurationRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(new global::Motorola.MackinawCPS.CoreFeatures.InternalMicNoiseReductionProfile.InternalMicNoiseReductionProfileRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(new global::Motorola.MackinawCPS.CoreFeatures.ExternalMicNoiseReductionProfile.ExternalMicNoiseReductionProfileRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(new global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItemsRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(new global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPsRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.ControlHeadO3Recset());
			global::AcpCommonLib.FeatureManager.AddFeature(new global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(new global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.ControlHeadO5Recset());
			global::AcpCommonLib.FeatureManager.AddFeature(new global::Motorola.MackinawCPS.CoreFeatures.GlobalNoiseReductionList.GlobalNoiseReductionListRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset());
			global::AcpCommonLib.FeatureManager.AddFeature(new global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(new global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7Recset());
			global::AcpCommonLib.FeatureManager.AddFeature(new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.ControlHeadO2Recset());
			global::AcpCommonLib.FeatureManager.AddFeature(new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.ControlHeadE5Recset());
			global::AcpCommonLib.FeatureManager.AddFeature(new global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(new global::Motorola.MackinawCPS.CoreFeatures.DVRSWide.DVRSWideRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(new global::Motorola.MackinawCPS.CoreFeatures.DVRSProfiles.DVRSProfilesRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(new global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortListRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(new global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.ToneSignalingListRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(new global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.MissionCriticalGeofenceRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(new global::Motorola.MackinawCPS.CoreFeatures.PersonnelAccountability.PersonnelAccountabilityRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(new global::SpecialFeatures.Ucl.UclWide.UclWideRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(new global::SpecialFeatures.Ucl.Contact.UclContactRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(new global::SpecialFeatures.Ucl.HotList.UclTrunkingCallHotListRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(new global::SpecialFeatures.Ucl.HotList.UclTrunkingT2CallHotListRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(new global::SpecialFeatures.Ucl.HotList.UclAstroCallHotListRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(new global::SpecialFeatures.Ucl.HotList.UclMDCCallHotListRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(new global::SpecialFeatures.Ucl.HotList.UclPhoneCallHotListRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(new global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementListRecSet());
			global::AcpCommonLib.FeatureManager.AddFeature(new global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementWideRecSet());
			global::AcpCommonLib.FeatureManager.AddFeature(new global::SpecialFeatures.VoiceAnnouncements.SiteSelectableAlertList.SiteSelectableAlertListRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(new global::SpecialFeatures.VoiceAnnouncements.List.TTSVoiceAnnouncementListRecSet());
			global::AcpCommonLib.FeatureManager.AddFeature(new global::SpecialFeatures.SystemCertificates.List.SystemCertificateListRecSet());
			global::AcpCommonLib.FeatureManager.AddFeature(new global::SpecialFeatures.DVRSFiles.List.DVRSFileListRecSet());
			global::AcpCommonLib.FeatureManager.AddFeature(new global::Motorola.MackinawCPS.CoreFeatures.VirtualPartnerAlert.VirtualPartnerAlertRecset());
			global::AcpCommonLib.ConstraintManager.Resume();
			global::Common.CodeplugStatusManager.Status = global::Common.CodeplugStatus.Opened;
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00014724 File Offset: 0x00012924
		public static void AddAllFeatures(global::AcpCommonLib.Document doc)
		{
			short num = (short)364631718;
			short num2 = num;
			num = (short)954652326;
			switch (num2 == num)
			{
			default:
			{
				num = (short)231145472;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)22544385;
			if (num != 0)
			{
			}
			num = (short)728825856;
			if (num != 0)
			{
			}
			global::AcpCommonLib.FeatureManager.AddFeature(doc, new global::Motorola.MackinawCPS.CoreFeatures.NonGUIFeature.NonGUIFeatureRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(doc, new global::Motorola.MackinawCPS.CoreFeatures.PhoneWide.PhoneWideRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(doc, new global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.FactoryOverridesRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(doc, new global::Motorola.MackinawCPS.CoreFeatures.ConventionalAliasLists.ConventionalAliasListsRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(doc, new global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.DisplayAndMenuRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(doc, new global::Motorola.MackinawCPS.CoreFeatures.Shepherds.ShepherdsRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(doc, new global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(doc, new global::Motorola.MackinawCPS.CoreFeatures.ScanWide.ScanWideRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(doc, new global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.ConventionalWideRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(doc, new global::Motorola.MackinawCPS.CoreFeatures.TrunkingWide.TrunkingWideRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(doc, new global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(doc, new global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.EmergencyWideRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(doc, new global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWideRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(doc, new global::Motorola.MackinawCPS.CoreFeatures.RepeaterIDList.RepeaterIDListRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(doc, new global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RemoteSpeakerMicRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(doc, new global::Motorola.MackinawCPS.CoreFeatures.Switches.SwitchesRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(doc, new global::Motorola.MackinawCPS.CoreFeatures.Buttons.ButtonsRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(doc, new global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(doc, new global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformationRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(doc, new global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(doc, new global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(doc, new global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(doc, new global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(doc, new global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(doc, new global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(doc, new global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.ASTROTalkgroupListRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(doc, new global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(doc, new global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(doc, new global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.ConventionalEmergencyProfilesRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(doc, new global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfilesRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(doc, new global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfilesRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(doc, new global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLConfigurationRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(doc, new global::Motorola.MackinawCPS.CoreFeatures.InternalMicNoiseReductionProfile.InternalMicNoiseReductionProfileRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(doc, new global::Motorola.MackinawCPS.CoreFeatures.ExternalMicNoiseReductionProfile.ExternalMicNoiseReductionProfileRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(doc, new global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItemsRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(doc, new global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPsRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(doc, new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.ControlHeadO3Recset());
			global::AcpCommonLib.FeatureManager.AddFeature(doc, new global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(doc, new global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(doc, new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.ControlHeadO5Recset());
			global::AcpCommonLib.FeatureManager.AddFeature(doc, new global::Motorola.MackinawCPS.CoreFeatures.GlobalNoiseReductionList.GlobalNoiseReductionListRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(doc, new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset());
			global::AcpCommonLib.FeatureManager.AddFeature(doc, new global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(doc, new global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(doc, new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7Recset());
			global::AcpCommonLib.FeatureManager.AddFeature(doc, new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.ControlHeadO2Recset());
			global::AcpCommonLib.FeatureManager.AddFeature(doc, new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.ControlHeadE5Recset());
			global::AcpCommonLib.FeatureManager.AddFeature(doc, new global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(doc, new global::Motorola.MackinawCPS.CoreFeatures.DVRSWide.DVRSWideRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(doc, new global::Motorola.MackinawCPS.CoreFeatures.DVRSProfiles.DVRSProfilesRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(doc, new global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortListRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(doc, new global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.ToneSignalingListRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(doc, new global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.MissionCriticalGeofenceRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(doc, new global::Motorola.MackinawCPS.CoreFeatures.PersonnelAccountability.PersonnelAccountabilityRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(doc, new global::SpecialFeatures.Ucl.UclWide.UclWideRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(doc, new global::SpecialFeatures.Ucl.Contact.UclContactRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(doc, new global::SpecialFeatures.Ucl.HotList.UclTrunkingCallHotListRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(doc, new global::SpecialFeatures.Ucl.HotList.UclTrunkingT2CallHotListRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(doc, new global::SpecialFeatures.Ucl.HotList.UclAstroCallHotListRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(doc, new global::SpecialFeatures.Ucl.HotList.UclMDCCallHotListRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(doc, new global::SpecialFeatures.Ucl.HotList.UclPhoneCallHotListRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(doc, new global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementListRecSet());
			global::AcpCommonLib.FeatureManager.AddFeature(doc, new global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementWideRecSet());
			global::AcpCommonLib.FeatureManager.AddFeature(doc, new global::SpecialFeatures.VoiceAnnouncements.SiteSelectableAlertList.SiteSelectableAlertListRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(doc, new global::SpecialFeatures.SystemCertificates.List.SystemCertificateListRecSet());
			global::AcpCommonLib.FeatureManager.AddFeature(doc, new global::SpecialFeatures.DVRSFiles.List.DVRSFileListRecSet());
			global::AcpCommonLib.FeatureManager.AddFeature(doc, new global::Motorola.MackinawCPS.CoreFeatures.VirtualPartnerAlert.VirtualPartnerAlertRecset());
			global::AcpCommonLib.FeatureManager.AddFeature(doc, new global::SpecialFeatures.VoiceAnnouncements.List.TTSVoiceAnnouncementListRecSet());
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00014AB8 File Offset: 0x00012CB8
		public void UclTemplateNodeInit()
		{
			short num = (short)553910272;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_5A;
				}
				bool flag;
				for (;;)
				{
					IL_27:
					global::AcpCommonLib.IAcpRecordset feature;
					global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator2;
					global::AcpBusinessLayer.FeatureNode templateNode;
					switch (num2)
					{
					case 0:
						goto IL_BC;
					case 1:
						flag = global::AcpCommonLib.UndoRedo.UndoManager.StopUndoRedo();
						feature = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(2200);
						num = (short)1769799682;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_BC;
					case 3:
						return;
					case 4:
						if (flag)
						{
							num = (short)74383366;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 5:
						if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
						{
							num = (short)1943666689;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						feature = global::AcpCommonLib.FeatureManager.GetFeature(2200);
						num = (short)94306312;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_762;
					case 7:
						try
						{
							num = (short)1177092103;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::AcpBusinessLayer.Recordset recordset;
									if (recordset.Count == 0)
									{
										num = (short)1190658052;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
								{
									num = (short)1422911282;
									short num3 = num;
									num = (short)2085021490;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_1E9;
									default:
									{
										num = (short)1468137472;
										if (num != 0)
										{
										}
										global::AcpCommonLib.IAcpFeatureSection acpFeatureSection;
										global::AcpBusinessLayer.Recordset recordset = (global::AcpBusinessLayer.Recordset)acpFeatureSection.EmbeddedRecset;
										num = (short)1467809792;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									break;
								}
								case 2:
									goto IL_6F0;
								case 3:
								{
									global::AcpCommonLib.IAcpFeatureSection acpFeatureSection;
									if (acpFeatureSection.HasEmbeddedRecset)
									{
										num = (short)1930690561;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
								{
									global::AcpBusinessLayer.Recordset recordset;
									recordset.AddRecord(recordset.CreateDefaultRecord());
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = recordset.GetEnumerator();
									num = (short)546766854;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									goto IL_6D8;
								case 6:
									try
									{
										num = (short)674955278;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
											{
												global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
												((global::SpecialFeatures.Ucl.Contact.TrunkingT2CallListCallListSection)acpFeatureNode[10412]).UclT2Trk_SystemID_A00018Object.PointedField = null;
												num = (short)2051538954;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 1:
											{
												global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
												((global::SpecialFeatures.Ucl.Contact.MDCCallListCallListSection)acpFeatureNode[10406]).UclMDCCnv_SystemGroupNumber_A00029Object.PointedField = null;
												num = (short)1309147149;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 3:
											{
												global::AcpBusinessLayer.Recordset recordset;
												if (recordset.ParentSection.FeatureSectionId == 10411)
												{
													num = (short)566820864;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												num = (short)1836646404;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 4:
											{
												global::AcpBusinessLayer.Recordset recordset;
												if (recordset.ParentSection.FeatureSectionId == 10403)
												{
													num = (short)1750597640;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												num = (short)1313210380;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 5:
												goto IL_667;
											case 7:
												num = (short)1995243525;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 8:
											{
												global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
												((global::SpecialFeatures.Ucl.Contact.AstroCallListCallListSection)acpFeatureNode[10404]).UclAstroCnv_SystemGroupNumber_A00023Object.PointedField = null;
												num = (short)192872450;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 9:
											{
												global::AcpBusinessLayer.Recordset recordset;
												if (recordset.ParentSection.FeatureSectionId == 10401)
												{
													num = (short)157810699;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												num = (short)720899;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 11:
											{
												global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
												global::SpecialFeatures.Ucl.Contact.TrunkingCallListCallListSection trunkingCallListCallListSection = (global::SpecialFeatures.Ucl.Contact.TrunkingCallListCallListSection)acpFeatureNode[10402];
												trunkingCallListCallListSection.UclAstro25Trk_HomeSystemID_A00012Object.PointedField = null;
												trunkingCallListCallListSection.UclAstro25Trk_WACNID_A00011Object.PointedField = null;
												num = (short)1517027334;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 12:
											{
												global::AcpBusinessLayer.Recordset recordset;
												if (recordset.ParentSection.FeatureSectionId == 10405)
												{
													num = (short)793444353;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 14:
												switch (0)
												{
												case 0:
													goto IL_3DC;
												}
												continue;
											case 15:
											{
												global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
												if (!enumerator.MoveNext())
												{
													num = (short)282329095;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
												num = (short)277872649;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											}
											IL_427:
											num = (short)340525071;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_3DC:
											goto IL_427;
										}
										IL_667:
										break;
									}
									finally
									{
										num = (short)1586036738;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
											switch (num2)
											{
											case 0:
												enumerator.Dispose();
												num = (short)1160577025;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 1:
												goto IL_6D5;
											case 2:
												switch (0)
												{
												case 0:
													goto IL_69E;
												}
												continue;
											}
											IL_69E:
											if (enumerator == null)
											{
												break;
											}
											num = (short)2010644480;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_6D5:;
									}
									goto IL_6D8;
								case 7:
									goto IL_1E9;
								case 8:
								{
									if (!enumerator2.MoveNext())
									{
										num = (short)1134559237;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureSection acpFeatureSection = enumerator2.Current;
									num = (short)1356660739;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								goto IL_21E;
								IL_1E9:
								switch (0)
								{
								case 0:
									IL_21E:
									goto IL_223;
								}
								continue;
								IL_223:
								num = (short)1822294024;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_6D8:
								num = (short)369623042;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_6F0:
							goto IL_133;
						}
						finally
						{
							num = (short)1230241794;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator2.Dispose();
									num = (short)1638989825;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_75F;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_728;
									}
									continue;
								}
								IL_728:
								if (enumerator2 == null)
								{
									break;
								}
								num = (short)1726676992;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_75F:;
						}
						goto IL_762;
						IL_133:
						templateNode.KeyField.Value = null;
						num = (short)23134212;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						goto IL_BC;
					case 9:
						if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
						{
							num = (short)1077280778;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)635699205;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
					{
						num = (short)911867904;
						short num4 = num;
						feature = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2200);
						num = (short)4194305;
						if (num != 0)
						{
						}
						num = (short)1599340544;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_5A;
					IL_BC:
					templateNode = ((global::AcpBusinessLayer.Recordset)feature).TemplateNode;
					enumerator2 = templateNode.FeatureSectionsCollection.GetEnumerator();
					num = (short)1727397895;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_762:
					global::AcpCommonLib.UndoRedo.UndoManager.StartUndoRedo();
					num = (short)597950467;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_5A:
				flag = false;
				num = (short)1423048713;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x000152DC File Offset: 0x000134DC
		private void ResetInvalidFrequencyOptions()
		{
			short num;
			for (;;)
			{
				num = (short)1726676992;
				short num2 = num;
				num = (short)1250754560;
				switch (num)
				{
				default:
				{
					num = (short)360906753;
					if (num != 0)
					{
					}
					num = (short)1778714765;
					short num3 = num;
					num = (short)1462306957;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_A5;
					}
					break;
				}
				}
			}
			IL_A5:
			num = (short)452526080;
			if (num != 0)
			{
			}
			global::System.Collections.Generic.IEnumerator<global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality> enumerator = (global::AcpCommonLib.FeatureManager.GetFeature(2059) as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityRecset).Cast<global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality>().GetEnumerator();
			try
			{
				num = (short)1571684356;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
						try
						{
							num = (short)1060110341;
							num4 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num4)
								{
								case 0:
								{
									global::System.Collections.Generic.IEnumerator<global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner> enumerator2;
									if (!enumerator2.MoveNext())
									{
										num = (short)450035715;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1873346562;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									try
									{
										num = (short)1599799303;
										num4 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num4)
											{
											case 1:
											{
												global::AcpBusinessLayer.AcpListField acpListField;
												if (acpListField.Value == 0)
												{
													num = (short)4128774;
													num4 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 2:
												goto IL_38E;
											case 3:
												num = (short)842858498;
												num4 = (int)((global::System.IntPtr)num);
												continue;
											case 4:
											{
												global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.AcpListField> enumerator3;
												if (!enumerator3.MoveNext())
												{
													num = (short)1411710979;
													num4 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::AcpBusinessLayer.AcpListField acpListField = enumerator3.Current;
												num = (short)1139671041;
												num4 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 5:
											{
												global::AcpBusinessLayer.AcpListField acpListField;
												acpListField.ResetToDefault();
												num = (short)275972096;
												num4 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 6:
												num = (short)324272136;
												num4 = (int)((global::System.IntPtr)num);
												continue;
											case 7:
												switch (0)
												{
												case 0:
													goto IL_291;
												}
												continue;
											case 8:
											{
												global::AcpBusinessLayer.AcpListField acpListField;
												if (acpListField.UIValue == "")
												{
													num = (short)214171653;
													num4 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											}
											IL_2F2:
											num = (short)188809220;
											num4 = (int)((global::System.IntPtr)num);
											continue;
											IL_291:
											goto IL_2F2;
										}
										IL_38E:;
									}
									finally
									{
										num = (short)1755119617;
										num4 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.AcpListField> enumerator3;
											switch (num4)
											{
											case 0:
												enumerator3.Dispose();
												num = (short)1474822146;
												num4 = (int)((global::System.IntPtr)num);
												continue;
											case 1:
												switch (0)
												{
												case 0:
													goto IL_3C3;
												}
												continue;
											case 2:
												goto IL_3F8;
											}
											IL_3C3:
											if (enumerator3 == null)
											{
												break;
											}
											num = (short)1885667328;
											num4 = (int)((global::System.IntPtr)num);
										}
										IL_3F8:;
									}
									break;
								case 2:
								{
									global::System.Collections.Generic.IEnumerator<global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner> enumerator2;
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.AcpListField> enumerator3 = enumerator2.Current.FrequencyOptionsInnerSection.FieldsCollection.Where(delegate(global::AcpCommonLib.IAcpField x)
									{
										short num5 = (short)1365340078;
										short num6 = num5;
										num5 = (short)443051950;
										switch (num6 == num5)
										{
										}
										num5 = (short)417988609;
										if (num5 != 0)
										{
										}
										num5 = (short)1302593536;
										short num7 = num5;
										num5 = (short)1889861632;
										if (num5 != 0)
										{
										}
										return x is global::AcpBusinessLayer.AcpListField;
									}).Cast<global::AcpBusinessLayer.AcpListField>().GetEnumerator();
									num = (short)789250049;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									num = (short)1280049156;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									goto IL_450;
								case 5:
									switch (0)
									{
									case 0:
										goto IL_1CD;
									}
									continue;
								}
								IL_3FB:
								num = (short)983498752;
								num4 = (int)((global::System.IntPtr)num);
								continue;
								IL_1CD:
								goto IL_3FB;
							}
							IL_450:
							break;
						}
						finally
						{
							num = (short)1880555521;
							num4 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner> enumerator2;
								switch (num4)
								{
								case 0:
									enumerator2.Dispose();
									num = (short)1919483906;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_487;
									}
									continue;
								case 2:
									goto IL_4BD;
								}
								IL_487:
								if (enumerator2 == null)
								{
									break;
								}
								num = (short)681443328;
								num4 = (int)((global::System.IntPtr)num);
							}
							IL_4BD:;
						}
						goto IL_4C0;
					case 1:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)1198784514;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Collections.Generic.IEnumerator<global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner> enumerator2 = (enumerator.Current.FrequencyOptions.EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInnerRecset).Cast<global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner>().GetEnumerator();
						num = (short)1080754176;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_4C0;
					case 3:
						goto IL_4D8;
					case 4:
						switch (0)
						{
						case 0:
							goto IL_112;
						}
						continue;
					}
					IL_14F:
					num = (short)357957633;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_112:
					goto IL_14F;
					IL_4C0:
					num = (short)1629159427;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_4D8:;
			}
			finally
			{
				num = (short)264044545;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
						enumerator.Dispose();
						num = (short)546766850;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_50C;
						}
						continue;
					case 2:
						goto IL_543;
					}
					IL_50C:
					if (enumerator == null)
					{
						break;
					}
					num = (short)538378240;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_543:;
			}
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x0001587C File Offset: 0x00013A7C
		public void FixUpAfterOpen()
		{
			switch (0)
			{
			case 0:
				goto IL_2C;
			}
			int num;
			short num2;
			global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpRecordset> enumerator;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					try
					{
						num2 = (short)1334723785;
						short num3 = num2;
						num2 = (short)1155679433;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							IL_297:
							num2 = (short)524615684;
							num = (int)((global::System.IntPtr)num2);
							break;
						default:
							num2 = (short)968753152;
							if (num2 != 0)
							{
							}
							num2 = (short)1541931008;
							num = (int)((global::System.IntPtr)num2);
							break;
						}
						for (;;)
						{
							switch (num)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_264;
								}
								continue;
							case 1:
								goto IL_297;
							case 3:
								if (!enumerator.MoveNext())
								{
									num2 = (short)1630994433;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								enumerator.Current.CalculateVisibility(true);
								num2 = (short)499056642;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 4:
								goto IL_2D3;
							}
							IL_266:
							num2 = (short)17104899;
							num = (int)((global::System.IntPtr)num2);
							continue;
							IL_264:
							goto IL_266;
						}
						IL_2D3:
						goto IL_12C;
					}
					finally
					{
						num2 = (short)623706113;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								enumerator.Dispose();
								num2 = (short)425918466;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_309;
								}
								continue;
							case 2:
								goto IL_33F;
							}
							IL_309:
							if (enumerator == null)
							{
								break;
							}
							num2 = (short)1577123840;
							num = (int)((global::System.IntPtr)num2);
						}
						IL_33F:;
					}
					goto IL_342;
					IL_12C:
					this.SecureADPKeyDataFixup();
					this.ScanListFixup();
					this.CnvPerTalkgroupListFixUp();
					this.LimitedPatienceTimeFixup();
					this.InitASKProgHistoryRecSet();
					this.InitTrkPerAnnGroup();
					num2 = (short)419364866;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
				{
					bool flag = this.O9TableInit();
					this.SyncE5BottomButton();
					this.DEKVipTableInit();
					this.PresetZoneChannelTableInit();
					this.KeypadRecsetAndTableInit();
					this.O2MFKTableInit();
					this.O7MFKTableInit();
					this.O2NavigationControlsTableInit();
					this.O7NavigationControlsTableInit();
					this.E5NavigationControlsTableInit();
					this.O3NavigationControlsTableInit();
					this.O5NavigationControlsTableInit();
					this.O9NavigationControlsTableInit();
					this.KMANavigationControlsTableInit();
					this.AlertListTableInit();
					this.AddQC2DefaultRecord();
					this.expandFlashcode();
					global::SpecialFeatures.Security.ASKConstraints.Initialize();
					global::AcpCommonLib.ConstraintManager.Suspend();
					this.updateUnpackedFields(false, null);
					if (flag)
					{
						num2 = (short)1392377861;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_383;
				}
				case 2:
				{
					num2 = (short)220266496;
					short num4 = num2;
					if (global::ConstraintHelper.UtilityMack.IsPortable())
					{
						num2 = (short)1375928321;
						if (num2 != 0)
						{
						}
						num2 = (short)1069613059;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_68;
				}
				case 3:
					this.TxPowerTableInit();
					num2 = (short)331612166;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					goto IL_35F;
				case 5:
					goto IL_342;
				case 6:
					goto IL_68;
				}
				goto IL_2C;
				IL_68:
				this.MFKTableInit();
				this.ShepherdsInitForFob();
				this.TriggerMuteToneRefresh();
				num2 = (short)599982081;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_342:
				this.AddO9PhephedRecord();
				num2 = (short)2111832068;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_35F:
			IL_383:
			this.SyncO9PASirenButtons(true);
			this.O9DirectionalButtonsFixup();
			this.UpdateAuxControlTable();
			global::AcpCommonLib.ConstraintManager.Resume();
			this.RefreshScanlistMap();
			this.DataProfileTrunkingGroupIDFixup();
			this.ZoneToZoneCloneFixup(null);
			this.expandFlashcode();
			this.ResetInvalidFrequencyOptions();
			return;
			IL_2C:
			this.SetProductModelIdentifierField();
			this.PropertiesChanged();
			this.SetDVRSHoptionEnabledField();
			this.SetDVRSHwEnabledField();
			enumerator = global::AcpCommonLib.FeatureManager.Features.GetEnumerator();
			num2 = (short)2023424000;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00015C54 File Offset: 0x00013E54
		internal void SetDVRSHoptionEnabledField()
		{
			short num2;
			try
			{
				for (;;)
				{
					switch (0)
					{
					case 0:
						goto IL_20;
					}
					global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
					for (;;)
					{
						IL_0A:
						int num;
						switch (num)
						{
						case 0:
							if (radioInformation != null)
							{
								num2 = (short)225968130;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							goto IL_E4;
						case 1:
							goto IL_E4;
						case 2:
							global::ConstraintHelper.UtilityMack.IsDVRSHoptionEnabled = radioInformation.Labtool.RadioInfoLabToolGA00631DvrsMsuOperation_A41827.Value;
							num2 = (short)28180481;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 3:
							goto IL_FB;
						}
						break;
						IL_E4:
						num2 = (short)287440899;
						num = (int)((global::System.IntPtr)num2);
					}
					IL_20:
					radioInformation = (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation);
					num2 = (short)1288501386;
					short num3 = num2;
					num2 = (short)1643313290;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num2 = (short)2086010880;
						if (num2 != 0)
						{
						}
						num2 = (short)1858535424;
						int num = (int)((global::System.IntPtr)num2);
						goto IL_0A;
					}
					}
				}
				IL_FB:;
			}
			catch (global::System.Exception)
			{
			}
			num2 = (short)1391788032;
			short num4 = num2;
			num2 = (short)157483009;
			if (num2 != 0)
			{
			}
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00015DC4 File Offset: 0x00013FC4
		public void SetDVRSHwEnabledField()
		{
			short num2;
			try
			{
				for (;;)
				{
					switch (0)
					{
					case 0:
						goto IL_20;
					}
					global::Motorola.MackinawCPS.CoreFeatures.DVRSWide.DVRSWide dvrswide;
					for (;;)
					{
						IL_0A:
						int num;
						switch (num)
						{
						case 0:
							if (dvrswide != null)
							{
								num2 = (short)1691353090;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							goto IL_E1;
						case 1:
							goto IL_E1;
						case 2:
							global::ConstraintHelper.UtilityMack.IsDVRSHwEnabled = dvrswide.General.RadErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911.Value;
							num2 = (short)1588199425;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 3:
							goto IL_F8;
						}
						break;
						IL_E1:
						num2 = (short)1066336259;
						num = (int)((global::System.IntPtr)num2);
					}
					IL_20:
					dvrswide = (global::AcpCommonLib.FeatureManager.GetFeature(4142)[0] as global::Motorola.MackinawCPS.CoreFeatures.DVRSWide.DVRSWide);
					num2 = (short)1010935129;
					short num3 = num2;
					num2 = (short)684303705;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num2 = (short)1948844032;
						if (num2 != 0)
						{
						}
						num2 = (short)558235648;
						int num = (int)((global::System.IntPtr)num2);
						goto IL_0A;
					}
					}
				}
				IL_F8:;
			}
			catch (global::System.Exception)
			{
			}
			num2 = (short)2124283904;
			short num4 = num2;
			num2 = (short)1341849601;
			if (num2 != 0)
			{
			}
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00015F34 File Offset: 0x00014134
		public void SetProductModelIdentifierField()
		{
			short num;
			try
			{
				num = (short)1578825946;
				short num2 = num;
				num = (short)1915091162;
				switch (num2 == num)
				{
				}
				num = (short)1363476480;
				if (num != 0)
				{
				}
				global::ConstraintHelper.UtilityMack.ProductModelId = (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation).Labtool.RadInfoLabtoolProductModelIdentifier_A37178Value.ToString();
			}
			catch (global::System.Exception)
			{
			}
			num = (short)857145344;
			short num3 = num;
			num = (short)1619197953;
			if (num != 0)
			{
			}
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00016024 File Offset: 0x00014224
		private void SecureADPKeyDataFixup()
		{
			int a_ = 19;
			short num = (short)507052032;
			switch (num)
			{
			default:
			{
				num = (short)1524563968;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInnerRecset encryptionKeyListInnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide secureWide;
					switch (num2)
					{
					case 0:
					{
						num = (short)1109590016;
						short num3 = num;
						num = (short)1064632321;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_C5;
						}
						continue;
					}
					case 1:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = encryptionKeyListInnerRecset.GetEnumerator();
						num = (short)461438979;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						return;
					case 3:
						try
						{
							num = (short)1301020672;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									num = (short)1215214738;
									short num4 = num;
									num = (short)1076933778;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_33E;
									default:
										num = (short)1820196864;
										if (num != 0)
										{
										}
										switch (0)
										{
										case 0:
											goto IL_279;
										}
										continue;
									}
									break;
								}
								case 1:
									num = (short)812253192;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
								{
									global::AcpBusinessLayer.AcpField<string> secWideMultikeyListSelectableADPKeyData_A;
									long num5;
									if (!long.TryParse(secWideMultikeyListSelectableADPKeyData_A.Value, global::System.Globalization.NumberStyles.HexNumber, null, out num5))
									{
										num = (short)1921843203;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
									goto IL_33E;
								case 5:
								{
									global::AcpBusinessLayer.AcpField<string> secWideMultikeyListSelectableADPKeyData_A;
									if (!secWideMultikeyListSelectableADPKeyData_A.Value.Contains(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("\ud9f2\udff4\uddf6폸퇺퟼헾⬀⤂⼄", a_)))
									{
										num = (short)226033670;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
								{
									global::AcpBusinessLayer.AcpField<string> secWideMultikeyListSelectableADPKeyData_A;
									secWideMultikeyListSelectableADPKeyData_A.Valid = false;
									num = (short)1363869700;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)696057857;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpBusinessLayer.AcpField<string> secWideMultikeyListSelectableADPKeyData_A = (((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10041] as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInnerSection).SecWideMultikeyListSelectableADPKeyData_A9106;
									long num5 = 0L;
									num = (short)279445506;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
									goto IL_3A9;
								}
								IL_2DF:
								num = (short)1262878727;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_279:
								goto IL_2DF;
								IL_33E:
								num = (short)241827845;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_3A9:
							return;
						}
						finally
						{
							num = (short)2121334785;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)744357890;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_3E0;
									}
									continue;
								case 2:
									goto IL_417;
								}
								IL_3E0:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1040384000;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_417:;
						}
						goto IL_41A;
					case 4:
						if (secureWide.General.SecWideGeneralSecureOperation_A9067.Value != 3)
						{
							num = (short)768606213;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_41A;
					case 5:
						return;
					case 6:
						if (encryptionKeyListInnerRecset != null)
						{
							num = (short)707461128;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 7:
						if (encryptionKeyListInnerRecset.Count != 0)
						{
							num = (short)122093569;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 8:
						num = (short)779550727;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_C5:
					if (int.Parse(((global::AcpCommonLib.FeatureManager.GetFeature(2049) as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformationRecset)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation).General.RadInfoGeneralCodeplugVersion_A7683.Value.Substring(1, 2)) >= 8)
					{
						num = (short)881786882;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					secureWide = (global::AcpCommonLib.FeatureManager.GetFeature(2021)[0] as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide);
					num = (short)96600068;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_41A:
					encryptionKeyListInnerRecset = (secureWide.EncryptionKeyList.EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInnerRecset);
					num = (short)46268422;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
			}
			}
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x000164B4 File Offset: 0x000146B4
		private void ScanListFixup()
		{
			short num = (short)572325888;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_43;
				}
				global::AcpCommonLib.IAcpRecordset feature;
				for (;;)
				{
					IL_28:
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					switch (num2)
					{
					case 0:
						if (feature != null)
						{
							num = (short)2087387139;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
						try
						{
							num = (short)1507328005;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								int referencedIndex;
								global::AcpBusinessLayer.AcpRecRefField scanLstGeneralPriorityMember1_A;
								switch (num2)
								{
								case 0:
									if (referencedIndex <= scanLstGeneralPriorityMember1_A.RefRecset.Count)
									{
										num = (short)801832962;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 1:
									if (referencedIndex >= 1)
									{
										num = (short)797179911;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 2:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInner scanListInner = scanLstGeneralPriorityMember1_A.RefRecset[referencedIndex - 1] as global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInner;
									num = (short)1514668042;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									num = (short)1878786062;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									num = (short)640155654;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									switch (0)
									{
									case 0:
										goto IL_167;
									}
									continue;
								case 6:
									goto IL_589;
								case 7:
									num = (short)1054146560;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									goto IL_41E;
								case 9:
								{
									global::AcpBusinessLayer.AcpListField scanLstGeneralPriority1Type_A;
									if (scanLstGeneralPriority1Type_A.Value == 1)
									{
										num = (short)1097072643;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_327;
								}
								case 10:
								{
									global::AcpBusinessLayer.AcpListField scanLstGeneralPriority1Type_A;
									if (scanLstGeneralPriority1Type_A.Value != 1)
									{
										num = (short)2010841105;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_4CB;
								}
								case 11:
									num = (short)2118647809;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 12:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInner scanListInner;
									if (scanListInner.ScanListInnerSection.ScanLstScanListChannel_A7620.Value == 0)
									{
										num = (short)1225916437;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 13:
									goto IL_4CB;
								case 14:
									if (referencedIndex == 0)
									{
										num = (short)1262485531;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_327;
								case 15:
								{
									global::AcpBusinessLayer.AcpListField scanLstGeneralScanType_A;
									if (scanLstGeneralScanType_A.Value != 0)
									{
										num = (short)713097241;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_41E;
								}
								case 16:
								{
									global::AcpBusinessLayer.AcpListField scanLstGeneralScanType_A;
									if (scanLstGeneralScanType_A.Value == 2)
									{
										num = (short)1920860168;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 17:
									goto IL_56A;
								case 18:
									goto IL_327;
								case 20:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1125842948;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanList scanList = (global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanList)enumerator.Current;
									global::AcpBusinessLayer.AcpListField scanLstGeneralScanType_A = scanList.General.ScanLstGeneralScanType_A9058;
									global::AcpBusinessLayer.AcpListField scanLstGeneralPriority1Type_A = scanList.General.ScanLstGeneralPriority1Type_A8745;
									scanLstGeneralPriorityMember1_A = scanList.General.ScanLstGeneralPriorityMember1_A8747;
									num = (short)735303930;
									short num3 = num;
									num = (short)1201264890;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_56A;
									default:
										num = (short)276561920;
										if (num != 0)
										{
										}
										num = (short)408223759;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 21:
									goto IL_1F1;
								case 22:
									if (scanLstGeneralPriorityMember1_A.RefRecset != null)
									{
										num = (short)1494286347;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 23:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInner scanListInner;
									if (scanListInner.ScanListInnerSection.ScanLstScanListZone_A9718.Value != 0)
									{
										num = (short)1816789016;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1F1;
								}
								case 24:
									num = (short)580452364;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 25:
									num = (short)43646992;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 26:
								{
									global::AcpBusinessLayer.AcpListField scanLstGeneralPriority1Type_A;
									if (scanLstGeneralPriority1Type_A.Value == 3)
									{
										num = (short)2000093197;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 27:
									scanLstGeneralPriorityMember1_A.Valid = false;
									num = (short)367001618;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_167;
								IL_1F1:
								scanLstGeneralPriorityMember1_A.Valid = false;
								num = (short)944242707;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2E5:
								num = (short)292618260;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_167:
								goto IL_2E5;
								IL_327:
								num = (short)1091239958;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_41E:
								referencedIndex = scanLstGeneralPriorityMember1_A.ReferencedIndex;
								num = (short)637206537;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_4CB:
								num = (short)1204224023;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_56A:
								num = (short)724369434;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_589:
							return;
						}
						finally
						{
							num = (short)1831403522;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)165675009;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_5F8;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_5C1;
									}
									continue;
								}
								IL_5C1:
								if (enumerator == null)
								{
									break;
								}
								num = (short)737607680;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_5F8:;
						}
						goto IL_5FB;
					case 2:
						if (feature.Count != 0)
						{
							num = (short)1528889348;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 3:
						num = (short)1331298305;
						if (num != 0)
						{
						}
						num = (short)893452290;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_5FB;
					}
					goto IL_43;
					IL_5FB:
					enumerator = ((global::AcpBusinessLayer.Recordset)feature).GetEnumerator();
					num = (short)1178796033;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_43:
				num = (short)1078263808;
				short num4 = num;
				feature = global::AcpCommonLib.FeatureManager.GetFeature(2057);
				num = (short)746913792;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00016B40 File Offset: 0x00014D40
		private void CnvPerTalkgroupListFixUp()
		{
			short num = (short)1400766465;
			if (num != 0)
			{
			}
			num = (short)1071579136;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_94;
				}
				global::AcpCommonLib.IAcpRecordset feature;
				for (;;)
				{
					IL_4F:
					num = (short)1147142144;
					short num3 = num;
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					switch (num2)
					{
					case 0:
						if (feature.Count != 0)
						{
							num = (short)1533673473;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
						goto IL_46D;
					case 2:
						try
						{
							num = (short)613744645;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.ASTROTalkgroupList astrotalkgroupList;
									global::AcpBusinessLayer.AcpRecRefField cnvPerSecureKMFProfileIndex_A;
									if (astrotalkgroupList.General.AstTlkgrpLstGeneralKMFProfileIndex_A8380.ReferencedIndex != cnvPerSecureKMFProfileIndex_A.ReferencedIndex)
									{
										num = (short)1198981122;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
									if (conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.Value != 0)
									{
										num = (short)755302414;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
								{
									global::AcpBusinessLayer.AcpRecRefField cnvPerASTROTalkgroupOptionsTalkgroupList_A;
									cnvPerASTROTalkgroupOptionsTalkgroupList_A.Valid = false;
									num = (short)940900356;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
									global::AcpBusinessLayer.AcpRecRefField cnvPerSecureKMFProfileIndex_A = conventionalPersonality.Secure.CnvPerSecureKMFProfileIndex_A8381;
									global::AcpBusinessLayer.AcpRecRefField cnvPerASTROTalkgroupOptionsTalkgroupList_A = conventionalPersonality.ASTROTalkgroup.CnvPerASTROTalkgroupOptionsTalkgroupList_A9283;
									global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.ASTROTalkgroupList astrotalkgroupList = cnvPerASTROTalkgroupOptionsTalkgroupList_A.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.ASTROTalkgroupList;
									num = (short)953090060;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									switch (0)
									{
									case 0:
										goto IL_143;
									}
									continue;
								case 6:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
									if (conventionalPersonality.ASTROTalkgroup.CnvPerASTROTalkgroupOptionsTalkGroupEnable_A9272.Value)
									{
										num = (short)1236140047;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 7:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
									if (conventionalPersonality.Secure.CnvPerSecureASTROOTAR_A7493.Value)
									{
										num = (short)866910216;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 8:
									num = (short)355270667;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
								{
									num = (short)13917923;
									short num4 = num;
									num = (short)1102864099;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
										num = (short)1155596288;
										if (num != 0)
										{
										}
										num = (short)1499987978;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 10:
									goto IL_3FB;
								case 11:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
									if (conventionalPersonality.Secure.CnvPerSecureASTROOTAR_A7493.Applicable)
									{
										num = (short)460652547;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 12:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.ASTROTalkgroupList astrotalkgroupList;
									if (astrotalkgroupList != null)
									{
										num = (short)2055929869;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 13:
									num = (short)845938688;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 14:
									num = (short)2032926726;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 15:
									num = (short)235601927;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 16:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)176160777;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality = (global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality)enumerator.Current;
									num = (short)1399455745;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_1DC:
								num = (short)1928396816;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_143:
								goto IL_1DC;
							}
							IL_3FB:
							return;
						}
						finally
						{
							num = (short)1250557954;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)2108489729;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_46A;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_433;
									}
									continue;
								}
								IL_433:
								if (enumerator == null)
								{
									break;
								}
								num = (short)364380160;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_46A:;
						}
						goto IL_46D;
					case 3:
						if (feature != null)
						{
							num = (short)985268228;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 4:
						num = (short)1621884928;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_94;
					IL_46D:
					enumerator = ((global::AcpBusinessLayer.Recordset)feature).GetEnumerator();
					num = (short)1846280194;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_94:
				feature = global::AcpCommonLib.FeatureManager.GetFeature(2059);
				num = (short)1746534403;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_4F;
			}
			}
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00017040 File Offset: 0x00015240
		private void LimitedPatienceTimeFixup()
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.ConventionalWideRecset conventionalWideRecset;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1103626240;
					short num3 = num2;
					(conventionalWideRecset[0] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.ConventionalWide).ASTROData.CnvWideASTRODataTxLimitedPatienceSec_A9544.Valid = false;
					num2 = (short)1482031105;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					goto IL_123;
				case 2:
				{
					if ((conventionalWideRecset[0] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.ConventionalWide).ASTROData.CnvWideASTRODataTxLimitedPatienceSec_A9544.Value != 1)
					{
						return;
					}
					num2 = (short)2058916744;
					short num4 = num2;
					num2 = (short)111842184;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_123;
					default:
						num2 = (short)872349696;
						if (num2 != 0)
						{
						}
						num2 = (short)374472704;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_1C;
			}
			IL_123:
			num2 = (short)543096833;
			if (num2 != 0)
			{
			}
			return;
			IL_1C:
			conventionalWideRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2024) as global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.ConventionalWideRecset);
			num2 = (short)1356660738;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060000CB RID: 203 RVA: 0x0001719C File Offset: 0x0001539C
		private void RefreshScanlistMap()
		{
			switch (0)
			{
			case 0:
				goto IL_34;
			}
			int num;
			short num2;
			global::AcpCommonLib.IAcpRecordset acpRecordset;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num2 = (short)2112946183;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					acpRecordset = global::AcpCommonLib.FeatureManager.GetFeature(2057);
					num2 = (short)680460289;
					if (num2 != 0)
					{
					}
					num2 = (short)438042629;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (acpRecordset.Count != 0)
					{
						num2 = (short)675086342;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 2:
					if (acpRecordset != null)
					{
						num2 = (short)1942290435;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 3:
					num2 = (short)486801409;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					goto IL_2EF;
				case 5:
					goto IL_2EF;
				case 6:
				{
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = ((global::AcpBusinessLayer.Recordset)acpRecordset).GetEnumerator();
					num2 = (short)1636958216;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 7:
				{
					num2 = (short)1594294272;
					short num3 = num2;
					acpRecordset = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(2057);
					num2 = (short)1557659652;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 8:
					try
					{
						num2 = (short)564396035;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 1:
							{
								num2 = (short)1968067313;
								short num4 = num2;
								num2 = (short)1278759665;
								switch ((num4 == num2) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									goto IL_26C;
								}
								break;
							}
							case 2:
								num2 = (short)416088065;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 3:
								switch (0)
								{
								case 0:
									goto IL_1B3;
								}
								continue;
							case 4:
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								if (!enumerator.MoveNext())
								{
									num2 = (short)431620098;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								((global::AcpBusinessLayer.Recordset)((global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanList)enumerator.Current).ScanListMembers.EmbeddedRecset).RefreshKeyMap();
								num2 = (short)626982912;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							}
							IL_1B5:
							num2 = (short)1605500932;
							num = (int)((global::System.IntPtr)num2);
							continue;
							IL_1B3:
							goto IL_1B5;
						}
						IL_26C:
						num2 = (short)1937637376;
						if (num2 != 0)
						{
						}
						return;
					}
					finally
					{
						num2 = (short)129171458;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
							switch (num)
							{
							case 0:
								enumerator.Dispose();
								num2 = (short)596246529;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 1:
								goto IL_2EC;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_2B8;
								}
								continue;
							}
							IL_2B8:
							if (enumerator == null)
							{
								break;
							}
							num2 = (short)2000093184;
							num = (int)((global::System.IntPtr)num2);
						}
						IL_2EC:;
					}
					goto IL_2EF;
				}
				goto IL_34;
				IL_2EF:
				num2 = (short)974913538;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_34:
			acpRecordset = null;
			num2 = (short)1995505664;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060000CC RID: 204 RVA: 0x000174EC File Offset: 0x000156EC
		private void InitASKProgHistoryRecSet()
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.ASKProgrammingHistoryInnerRecset askprogrammingHistoryInnerRecset = (global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.ASKProgrammingHistoryInnerRecset)radioInformation.AdvancedSystemKeyInfo.EmbeddedRecset;
					askprogrammingHistoryInnerRecset.SetMax(askprogrammingHistoryInnerRecset.Count);
					global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.ASKProgrammingHistoryInnerRecset._Min = askprogrammingHistoryInnerRecset.Count;
					num2 = (short)217645057;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					return;
				case 2:
				{
					if (radioInformation == null)
					{
						return;
					}
					num2 = (short)787357584;
					short num3 = num2;
					num2 = (short)2122325904;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
					{
						num2 = (short)1563426816;
						if (num2 != 0)
						{
						}
						num2 = (short)457703424;
						short num4 = num2;
						num2 = (short)296681472;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				}
				goto IL_1C;
			}
			return;
			IL_1C:
			radioInformation = (global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation)global::AcpCommonLib.FeatureManager.GetFeature(2049)[0];
			num2 = (short)2128936961;
			if (num2 != 0)
			{
			}
			num2 = (short)722862082;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00017638 File Offset: 0x00015838
		private void InitTrkPerAnnGroup()
		{
			short num = (short)573898752;
			switch (num)
			{
			default:
			{
				num = (short)690421763;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)1437401088;
					short num3 = num;
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityRecset trunkingPersonalityRecset;
					switch (num2)
					{
					case 0:
						goto IL_325;
					case 1:
						goto IL_325;
					case 2:
						try
						{
							num = (short)1733165057;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::AcpBusinessLayer.AcpCustomRangeField trkPerAnnouncementGroupAnnouncementGroup_A;
								switch (num2)
								{
								case 0:
									if (trkPerAnnouncementGroupAnnouncementGroup_A.Value == 0)
									{
										num = (short)232587271;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_F9;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_F4;
									}
									continue;
								case 2:
									goto IL_295;
								case 3:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1094189065;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality trunkingPersonality = (global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality)enumerator.Current;
									num = (short)1679360006;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									goto IL_2B3;
								case 5:
								{
									global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality trunkingPersonality;
									trkPerAnnouncementGroupAnnouncementGroup_A = trunkingPersonality.AnnouncementGroup.TrkPerAnnouncementGroupAnnouncementGroup_A7444;
									num = (short)1026752512;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
								{
									global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality trunkingPersonality;
									if (trunkingPersonality.General.TrkPerGeneralProtocolType_A8767.Value == 2)
									{
										num = (short)52625413;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 7:
									trkPerAnnouncementGroupAnnouncementGroup_A.SetValue(4095);
									num = (short)276430850;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
								{
									num = (short)486070232;
									short num4 = num;
									num = (short)983881688;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_295;
									default:
										num = (short)2115633152;
										if (num != 0)
										{
										}
										break;
									}
									break;
								}
								case 9:
									num = (short)1367212036;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_F4;
								IL_F9:
								num = (short)47644673;
								if (num != 0)
								{
								}
								trkPerAnnouncementGroupAnnouncementGroup_A.ReplaceCustomValue(4095, global::CommonResources.AppResources.None_Id);
								num = (short)135069704;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_295:
								goto IL_F9;
								IL_193:
								num = (short)16252931;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_F4:
								goto IL_193;
							}
							IL_2B3:
							return;
						}
						finally
						{
							num = (short)1010171906;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)100270081;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_322;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_2EC;
									}
									continue;
								}
								IL_2EC:
								if (enumerator == null)
								{
									break;
								}
								num = (short)637927424;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_322:;
						}
						goto IL_325;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_81;
						}
						continue;
					case 4:
						trunkingPersonalityRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2072) as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityRecset);
						num = (short)1336410112;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_81:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugConfigurationMode)
					{
						num = (short)619446276;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					trunkingPersonalityRecset = (global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(2072) as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityRecset);
					num = (short)1911881729;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_325:
					enumerator = trunkingPersonalityRecset.GetEnumerator();
					num = (short)463667202;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
			}
			}
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00017A08 File Offset: 0x00015C08
		private void TxPowerTableInit()
		{
			short num = (short)632684544;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_A8;
				}
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeInnerRecset txPowerLevelsByFrequencyRangeInnerRecset;
				for (;;)
				{
					IL_29:
					global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeInnerSection txPowerLevelsByFrequencyRangeInnerSection4;
					global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeInnerSection txPowerLevelsByFrequencyRangeInnerSection5;
					switch (num2)
					{
					case 0:
						if (txPowerLevelsByFrequencyRangeInnerRecset != null)
						{
							num = (short)1970864145;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9A2;
					case 1:
						try
						{
							switch (0)
							{
							case 0:
								goto IL_7BC;
							}
							string value;
							int value2;
							for (;;)
							{
								IL_785:
								switch (num2)
								{
								case 0:
									if (value != null)
									{
										num = (short)108986375;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_97F;
								case 1:
									if (value2 != 6)
									{
										num = (short)1372454920;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_92F;
								case 2:
									num = (short)1316225035;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									goto IL_92F;
								case 4:
									goto IL_97F;
								case 5:
									if (value2 == 5)
									{
										num = (short)1734475779;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_97F;
								case 6:
									if (value.Length > 3)
									{
										num = (short)1097465858;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_97F;
								case 7:
									num = (short)809828358;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									num = (short)1267007493;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
									goto IL_997;
								case 10:
									num = (short)2146566145;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 11:
									if (int.Parse(value.Substring(1, 2)) < 8)
									{
										num = (short)662437898;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_97F;
								}
								goto IL_7BC;
								IL_92F:
								global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeInnerSection txPowerLevelsByFrequencyRangeInnerSection = txPowerLevelsByFrequencyRangeInnerRecset[0][10104] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeInnerSection;
								txPowerLevelsByFrequencyRangeInnerSection.RadWideTransmitPowerLevelsTxPowerLevelHighW_A8152.SetValue(37404);
								txPowerLevelsByFrequencyRangeInnerSection.RadWideTransmitPowerLevelsTxPowerLevelMaximumW_A20039.SetValue(37404);
								num = (short)80543748;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_97F:
								num = (short)518520841;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_997:
							goto IL_58B;
							IL_7BC:
							global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation = global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation;
							value = radioInformation.General.RadInfoGeneralCodeplugVersion_A7683.Value;
							value2 = radioInformation.Labtool.RadInfoLabtoolProductModelIdentifier_A37178.Value;
							num = (short)1192624128;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_785;
						}
						catch
						{
							goto IL_58B;
						}
						goto IL_9A2;
						IL_58B:
						num = (short)457637890;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						try
						{
							switch (0)
							{
							case 0:
								goto IL_30C;
							}
							string value3;
							int value4;
							for (;;)
							{
								IL_2D5:
								switch (num2)
								{
								case 0:
									if (value3 != null)
									{
										num = (short)1685454855;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_4DA;
								case 1:
									if (int.Parse(value3.Substring(1, 2)) < 8)
									{
										num = (short)1062273032;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_4DA;
								case 2:
									if (value3.Length > 3)
									{
										num = (short)598802437;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_4DA;
								case 3:
									if (value4 != 6)
									{
										num = (short)1046347787;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3CC;
								case 4:
									goto IL_3CC;
								case 5:
									num = (short)417333249;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									goto IL_4DA;
								case 7:
									num = (short)292290562;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									num = (short)2002255875;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
									goto IL_4F3;
								case 10:
									if (value4 == 5)
									{
										num = (short)1981284356;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_4DA;
								case 11:
									num = (short)2120220682;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_30C;
								IL_3CC:
								global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeInnerSection txPowerLevelsByFrequencyRangeInnerSection2 = txPowerLevelsByFrequencyRangeInnerRecset[0][10104] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeInnerSection;
								txPowerLevelsByFrequencyRangeInnerSection2.RadWideTransmitPowerLevelsTxPowerLevelHighW_A8152.SetValue(37404);
								txPowerLevelsByFrequencyRangeInnerSection2.RadWideTransmitPowerLevelsTxPowerLevelMaximumW_A20039.SetValue(37404);
								num = (short)73990150;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_4DA:
								num = (short)1797455881;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_4F3:
							return;
							IL_30C:
							global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation2 = global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation;
							value3 = radioInformation2.General.RadInfoGeneralCodeplugVersion_A7683.Value;
							value4 = radioInformation2.Labtool.RadInfoLabtoolProductModelIdentifier_A37178.Value;
							num = (short)1689321472;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_2D5;
						}
						catch
						{
							return;
						}
						goto IL_4FE;
					case 3:
						goto IL_9A2;
					case 4:
					{
						int count = txPowerLevelsByFrequencyRangeInnerRecset.Count;
						num = (short)642252814;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeInnerSection txPowerLevelsByFrequencyRangeInnerSection3;
						txPowerLevelsByFrequencyRangeInnerSection3.RadWideTransmitPowerLevelsFrequencyRangeEndMHz_A20037.SetValue(94400000);
						num = (short)1880358925;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						txPowerLevelsByFrequencyRangeInnerSection4.RadWidePowerLevelBandFrequency_A41063.SetValue(global::CommonResources.AcgResources.ID_P_900MHZ);
						txPowerLevelsByFrequencyRangeInnerSection4.RadWideTransmitPowerLevelsFrequencyRangeEndMHz_A20037.SetValue(188200000);
						txPowerLevelsByFrequencyRangeInnerSection4.RadWideTransmitPowerLevelsFrequencyRangeStartMHz_A19994.SetValue(179200000);
						txPowerLevelsByFrequencyRangeInnerSection4.RadWideTransmitPowerLevelsTxPowerLevelHighW_A8152.SetValue(34393);
						txPowerLevelsByFrequencyRangeInnerSection4.RadWideTransmitPowerLevelsTxPowerLevelMaximumW_A20039.SetValue(34393);
						num = (short)1684013059;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						num = (short)995098644;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						num = (short)431685661;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						if (txPowerLevelsByFrequencyRangeInnerRecset.Count >= 6)
						{
							num = (short)505872403;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						txPowerLevelsByFrequencyRangeInnerRecset.AddRecord(txPowerLevelsByFrequencyRangeInnerRecset.CreateDefaultRecord());
						num = (short)197132309;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
					{
						int count;
						if (count < 5)
						{
							num = (short)1868824594;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A38;
					}
					case 11:
						if (txPowerLevelsByFrequencyRangeInnerSection5 != null)
						{
							num = (short)555417626;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A38;
					case 12:
						goto IL_A38;
					case 13:
						goto IL_4FE;
					case 14:
						goto IL_6CF;
					case 15:
					{
						int count;
						if (count < 6)
						{
							num = (short)156499974;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9A2;
					}
					case 16:
						if (txPowerLevelsByFrequencyRangeInnerSection4 != null)
						{
							num = (short)1500381211;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9A2;
					case 17:
						num = (short)1256980503;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						txPowerLevelsByFrequencyRangeInnerSection5.RadWideTransmitPowerLevelsFrequencyRangeEndMHz_A20037.SetValue(104000000);
						txPowerLevelsByFrequencyRangeInnerSection5.RadWideTransmitPowerLevelsFrequencyRangeStartMHz_A19994.SetValue(90000000);
						txPowerLevelsByFrequencyRangeInnerSection5.RadWideTransmitPowerLevelsTxPowerLevelMaximumW_A20039.SetValue(37243);
						txPowerLevelsByFrequencyRangeInnerSection5.RadWideTransmitPowerLevelsTxPowerLevelLowW_A8153.SetValue(30792);
						txPowerLevelsByFrequencyRangeInnerSection5.RadWideTransmitPowerLevelsTxPowerLevelHighW_A8152.SetValue(37243);
						num = (short)1577713676;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeInnerSection txPowerLevelsByFrequencyRangeInnerSection3 = txPowerLevelsByFrequencyRangeInnerRecset[3][10104] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeInnerSection;
						num = (short)884277273;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 20:
					{
						int count;
						if (count < 4)
						{
							num = (short)85000200;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4FE;
					}
					case 21:
						goto IL_6CF;
					case 22:
						if (!this.IsULPCPG())
						{
							num = (short)2140864513;
							if (num != 0)
							{
							}
							num = (short)1707737112;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4FE;
					case 23:
						if (txPowerLevelsByFrequencyRangeInnerRecset.Count < 6)
						{
							num = (short)1015939076;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9A2;
					case 24:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeInnerSection txPowerLevelsByFrequencyRangeInnerSection3;
						txPowerLevelsByFrequencyRangeInnerSection3.RadWideTransmitPowerLevelsTxPowerLevelMaximumW_A20039.SetValue(37243);
						txPowerLevelsByFrequencyRangeInnerSection3.RadWideTransmitPowerLevelsTxPowerLevelHighW_A8152.SetValue(37243);
						num = (short)1875509276;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 25:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeInnerSection txPowerLevelsByFrequencyRangeInnerSection3;
						if (txPowerLevelsByFrequencyRangeInnerSection3 != null)
						{
							num = (short)1608581120;
							short num3 = num;
							num = (short)163315719;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4FE;
					}
					case 26:
						num = (short)53805066;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
						num = (short)380174351;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
						goto IL_4FE;
					case 29:
					{
						if (this.IsExtendedUHFR1CPG())
						{
							num = (short)72744965;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeInnerSection txPowerLevelsByFrequencyRangeInnerSection3;
						txPowerLevelsByFrequencyRangeInnerSection3.RadWideTransmitPowerLevelsFrequencyRangeEndMHz_A20037.SetValue(94000000);
						txPowerLevelsByFrequencyRangeInnerSection3.RadWideTransmitPowerLevelsFrequencyRangeStartMHz_A19994.SetValue(76000000);
						txPowerLevelsByFrequencyRangeInnerSection3.RadWideTransmitPowerLevelsTxPowerLevelLowW_A8153.SetValue(30792);
						num = (short)1166579762;
						short num4 = num;
						num = (short)1975883826;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_A38;
						default:
							num = (short)505020416;
							if (num != 0)
							{
							}
							num = (short)1055719446;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					goto IL_A8;
					IL_4FE:
					txPowerLevelsByFrequencyRangeInnerSection5 = (txPowerLevelsByFrequencyRangeInnerRecset[4][10104] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeInnerSection);
					num = (short)201261067;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6CF:
					num = (short)1552547849;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_9A2:
					num = (short)1269760001;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A38:
					txPowerLevelsByFrequencyRangeInnerSection4 = (txPowerLevelsByFrequencyRangeInnerRecset[5][10104] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeInnerSection);
					num = (short)31064080;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_A8:
				txPowerLevelsByFrequencyRangeInnerRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0][10103].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeInnerRecset);
				num = (short)1262813184;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x060000CF RID: 207 RVA: 0x000184FC File Offset: 0x000166FC
		private bool IsExtendedUHFR1CPG()
		{
			short num;
			for (;;)
			{
				IL_00:
				num = (short)1959133184;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					switch (0)
					{
					case 0:
						goto IL_3E;
					}
					global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
					for (;;)
					{
						IL_27:
						switch (num2)
						{
						case 0:
						{
							if (radioInformation == null)
							{
								return false;
							}
							num = (short)650990827;
							short num3 = num;
							num = (short)1914197227;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
								num = (short)1948909568;
								if (num != 0)
								{
								}
								num = (short)254935041;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 1:
							num = (short)1676738563;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_19D;
						case 3:
						{
							bool value = radioInformation.FrequencyRanges.RadInfoFrequencyRangesExtendedUHFR1Capable_A41443.Value;
							int value2 = radioInformation.Labtool.RadInfoLabtoolPrimaryBands_A23987.Value;
							int value3 = radioInformation.Labtool.RadInfoLabtoolSecondaryBands_A23988.Value;
							bool flag;
							if (global::ConstraintHelper.UtilityMack.IsFreonRadio)
							{
								flag = radioInformation.General.RadInfoGeneralPrimaryFrequencyBandUHF1_A42546.Value;
							}
							else
							{
								flag = (value2 == 5 || value2 == 4 || value3 == 5 || value3 == 4);
							}
							if (value && flag)
							{
								num = (short)1337196546;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return false;
						}
						}
						break;
					}
					IL_3E:
					num = (short)1455554561;
					if (num != 0)
					{
					}
					radioInformation = (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation);
					num = (short)1682309120;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_27;
				}
				}
			}
			IL_19D:
			num = (short)1576140800;
			short num4 = num;
			return true;
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x000186D4 File Offset: 0x000168D4
		private bool IsULPCPG()
		{
			short num;
			bool result;
			try
			{
				num = (short)1588632856;
				short num2 = num;
				num = (short)1335532824;
				switch (num2 == num)
				{
				}
				num = (short)533463040;
				if (num != 0)
				{
				}
				result = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide).Labtool.RadWideLabtoolUltraLowPowerSoldierMacCapable_A41710Value;
			}
			catch
			{
				result = false;
			}
			num = (short)1218641920;
			short num3 = num;
			num = (short)1567031297;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x000187B4 File Offset: 0x000169B4
		private void TxPowerNewTableInitForMobile()
		{
			short num = (short)1997799424;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_7E;
				}
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeInnerRecset txPowerLevelsByFrequencyRangeInnerRecset;
				global::AcpCommonLib.IAcpRecordset feature;
				for (;;)
				{
					IL_27:
					int num3;
					int[] array;
					int[] array2;
					switch (num2)
					{
					case 0:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeNewBandPlanInnerRecset txPowerLevelsByFrequencyRangeNewBandPlanInnerRecset;
						if (txPowerLevelsByFrequencyRangeNewBandPlanInnerRecset != null)
						{
							num = (short)1235484688;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_27F;
					}
					case 1:
						goto IL_207;
					case 2:
						goto IL_27F;
					case 3:
						goto IL_4F0;
					case 4:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeNewBandPlanInnerRecset txPowerLevelsByFrequencyRangeNewBandPlanInnerRecset;
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeNewBandPlanInnerSection txPowerLevelsByFrequencyRangeNewBandPlanInnerSection = txPowerLevelsByFrequencyRangeNewBandPlanInnerRecset[num3][10762] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeNewBandPlanInnerSection;
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeInnerSection txPowerLevelsByFrequencyRangeInnerSection;
						if (num3 < 9)
						{
							txPowerLevelsByFrequencyRangeInnerSection = (txPowerLevelsByFrequencyRangeInnerRecset[num3][10104] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeInnerSection);
						}
						else if (num3 == 9)
						{
							txPowerLevelsByFrequencyRangeInnerSection = (txPowerLevelsByFrequencyRangeInnerRecset[7][10104] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeInnerSection);
						}
						else
						{
							txPowerLevelsByFrequencyRangeInnerSection = (txPowerLevelsByFrequencyRangeInnerRecset[num3 - 1][10104] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeInnerSection);
						}
						txPowerLevelsByFrequencyRangeNewBandPlanInnerSection.RadWidePowerLevelBandFrequency_A41864.SetValue(txPowerLevelsByFrequencyRangeInnerSection.RadWidePowerLevelBandFrequency_A41063.Value);
						txPowerLevelsByFrequencyRangeNewBandPlanInnerSection.RadWideTransmitPowerLevelsFrequencyRangeStartMHz_A41856.SetValue(array[num3]);
						txPowerLevelsByFrequencyRangeNewBandPlanInnerSection.RadWideTransmitPowerLevelsFrequencyRangeEndMHz_A41857.SetValue(array2[num3]);
						txPowerLevelsByFrequencyRangeNewBandPlanInnerSection.RadWideTransmitPowerLevelsTxPowerLevelMinimumW_A41858.SetValue(txPowerLevelsByFrequencyRangeInnerSection.RadWideTransmitPowerLevelsTxPowerLevelMinimumW_A20038.Value);
						txPowerLevelsByFrequencyRangeNewBandPlanInnerSection.RadWideTransmitPowerLevelsTxPowerLevelLowW_A41855.SetValue(txPowerLevelsByFrequencyRangeInnerSection.RadWideTransmitPowerLevelsTxPowerLevelLowW_A8153.Value);
						txPowerLevelsByFrequencyRangeNewBandPlanInnerSection.RadWideTransmitPowerLevelsTxPowerLevelHighW_A41854.SetValue(txPowerLevelsByFrequencyRangeInnerSection.RadWideTransmitPowerLevelsTxPowerLevelHighW_A8152.Value);
						txPowerLevelsByFrequencyRangeNewBandPlanInnerSection.RadWideTransmitPowerLevelsTxPowerLevelMaximumW_A41859.SetValue(txPowerLevelsByFrequencyRangeInnerSection.RadWideTransmitPowerLevelsTxPowerLevelMaximumW_A20039.Value);
						txPowerLevelsByFrequencyRangeNewBandPlanInnerSection.RadWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41863.SetValue(txPowerLevelsByFrequencyRangeInnerSection.RadWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41173.Value);
						txPowerLevelsByFrequencyRangeNewBandPlanInnerSection.RadWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41862.SetValue(txPowerLevelsByFrequencyRangeInnerSection.RadWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41174.Value);
						txPowerLevelsByFrequencyRangeNewBandPlanInnerSection.RadWideTransmitPowerLevelsConvTxPowerLevelLowW_A41861.SetValue(txPowerLevelsByFrequencyRangeInnerSection.RadWideTransmitPowerLevelsConvTxPowerLevelLowW_A41175.Value);
						txPowerLevelsByFrequencyRangeNewBandPlanInnerSection.RadWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41860.SetValue(txPowerLevelsByFrequencyRangeInnerSection.RadWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41176.Value);
						num3++;
						num = (short)1416560643;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						array2[11] = 94400000;
						num = (short)1391919113;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (num3 >= 19)
						{
							num = (short)1325269006;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)268435460;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						num = (short)1549664274;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						if (this.IsExtendedUHFR1CPG())
						{
							num = (short)310181893;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_305;
					case 9:
						goto IL_305;
					case 10:
					{
						if (txPowerLevelsByFrequencyRangeInnerRecset.Count < 16)
						{
							num = (short)754122763;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeNewBandPlanInnerRecset txPowerLevelsByFrequencyRangeNewBandPlanInnerRecset = feature[0][10761].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeNewBandPlanInnerRecset;
						num = (short)472645644;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						return;
					case 12:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeNewBandPlanInnerRecset txPowerLevelsByFrequencyRangeNewBandPlanInnerRecset;
						if (txPowerLevelsByFrequencyRangeNewBandPlanInnerRecset == null)
						{
							goto IL_52C;
						}
						num = (short)642752043;
						short num4 = num;
						num = (short)1172020779;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_52A;
						default:
							num = (short)1359806464;
							if (num != 0)
							{
							}
							num = (short)1740636167;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 13:
						num = (short)1309212689;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						goto IL_52A;
					case 15:
						goto IL_4F0;
					case 16:
						num = (short)2102198291;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						goto IL_207;
					case 18:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeNewBandPlanInnerRecset txPowerLevelsByFrequencyRangeNewBandPlanInnerRecset;
						if (txPowerLevelsByFrequencyRangeNewBandPlanInnerRecset.Count < 19)
						{
							num = (short)1535901709;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_52C;
					}
					case 19:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeNewBandPlanInnerRecset txPowerLevelsByFrequencyRangeNewBandPlanInnerRecset;
						if (txPowerLevelsByFrequencyRangeNewBandPlanInnerRecset.Count >= 19)
						{
							num = (short)616759298;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						txPowerLevelsByFrequencyRangeNewBandPlanInnerRecset.AddRecord(txPowerLevelsByFrequencyRangeNewBandPlanInnerRecset.CreateDefaultRecord());
						num = (short)1574436865;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_7E;
					IL_207:
					num = (short)1467154432;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_27F:
					array = new int[]
					{
						27200000,
						152400000,
						153800000,
						153815001,
						154985000,
						155000001,
						159800000,
						159815001,
						160985000,
						161000000,
						161200000,
						76000000,
						90000000,
						97000000,
						102400000,
						179200000,
						180200000,
						187000000,
						188000000
					};
					array2 = new int[]
					{
						34800000,
						153799999,
						153815000,
						154984999,
						155000000,
						159799999,
						159815000,
						160984999,
						160999999,
						161199999,
						174000000,
						94000000,
						96999999,
						102399999,
						104000000,
						180199999,
						180400000,
						187999999,
						188200000
					};
					num = (short)1441136648;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_305:
					num3 = 0;
					num = (short)1283653632;
					short num5 = num;
					num = (short)949092367;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4F0:
					num = (short)1960509446;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_52A:
				IL_52C:
				num = (short)1989869569;
				if (num != 0)
				{
				}
				return;
				IL_7E:
				feature = global::AcpCommonLib.FeatureManager.GetFeature(2045);
				txPowerLevelsByFrequencyRangeInnerRecset = (feature[0][10103].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeInnerRecset);
				num = (short)227213322;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00018D14 File Offset: 0x00016F14
		private void TxPowerTableInitForMobile()
		{
			short num = (short)251527168;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_1F3;
				}
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeInnerRecset txPowerLevelsByFrequencyRangeInnerRecset;
				global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.Labtool labtool;
				for (;;)
				{
					IL_28:
					int num3;
					global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeInnerSection txPowerLevelsByFrequencyRangeInnerSection;
					switch (num2)
					{
					case 0:
						goto IL_3E7;
					case 1:
						goto IL_3E7;
					case 2:
						switch (num3)
						{
						case 10:
							txPowerLevelsByFrequencyRangeInnerSection.RadWidePowerLevelBandFrequency_A41063.SetValue(global::CommonResources.AcgResources.ID_UHF1);
							num = (short)281673749;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 11:
							txPowerLevelsByFrequencyRangeInnerSection.RadWidePowerLevelBandFrequency_A41063.SetValue(global::CommonResources.AcgResources.ID_UHF2);
							txPowerLevelsByFrequencyRangeInnerSection.RadWideTransmitPowerLevelsFrequencyRangeEndMHz_A20037.SetValue(96999999);
							txPowerLevelsByFrequencyRangeInnerSection.RadWideTransmitPowerLevelsFrequencyRangeStartMHz_A19994.SetValue(90000000);
							num = (short)22282245;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 12:
							txPowerLevelsByFrequencyRangeInnerSection.RadWidePowerLevelBandFrequency_A41063.SetValue(global::CommonResources.AcgResources.ID_UHF2);
							txPowerLevelsByFrequencyRangeInnerSection.RadWideTransmitPowerLevelsFrequencyRangeEndMHz_A20037.SetValue(102399999);
							txPowerLevelsByFrequencyRangeInnerSection.RadWideTransmitPowerLevelsFrequencyRangeStartMHz_A19994.SetValue(97000000);
							num = (short)2010906713;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 13:
							txPowerLevelsByFrequencyRangeInnerSection.RadWidePowerLevelBandFrequency_A41063.SetValue(global::CommonResources.AcgResources.ID_UHF2);
							txPowerLevelsByFrequencyRangeInnerSection.RadWideTransmitPowerLevelsFrequencyRangeEndMHz_A20037.SetValue(104000000);
							txPowerLevelsByFrequencyRangeInnerSection.RadWideTransmitPowerLevelsFrequencyRangeStartMHz_A19994.SetValue(102400000);
							num = (short)2034565130;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 14:
							txPowerLevelsByFrequencyRangeInnerSection.RadWidePowerLevelBandFrequency_A41063.SetValue(global::CommonResources.AcgResources.ID_P_900MHZ);
							txPowerLevelsByFrequencyRangeInnerSection.RadWideTransmitPowerLevelsFrequencyRangeEndMHz_A20037.SetValue(180199999);
							txPowerLevelsByFrequencyRangeInnerSection.RadWideTransmitPowerLevelsFrequencyRangeStartMHz_A19994.SetValue(179200000);
							num = (short)774111298;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 15:
							txPowerLevelsByFrequencyRangeInnerSection.RadWidePowerLevelBandFrequency_A41063.SetValue(global::CommonResources.AcgResources.ID_P_900MHZ);
							txPowerLevelsByFrequencyRangeInnerSection.RadWideTransmitPowerLevelsFrequencyRangeEndMHz_A20037.SetValue(180400000);
							txPowerLevelsByFrequencyRangeInnerSection.RadWideTransmitPowerLevelsFrequencyRangeStartMHz_A19994.SetValue(180200000);
							num = (short)1524760630;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 16:
							txPowerLevelsByFrequencyRangeInnerSection.RadWidePowerLevelBandFrequency_A41063.SetValue(global::CommonResources.AcgResources.ID_P_900MHZ);
							txPowerLevelsByFrequencyRangeInnerSection.RadWideTransmitPowerLevelsFrequencyRangeEndMHz_A20037.SetValue(187999999);
							txPowerLevelsByFrequencyRangeInnerSection.RadWideTransmitPowerLevelsFrequencyRangeStartMHz_A19994.SetValue(187000000);
							num = (short)1020133464;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 17:
							txPowerLevelsByFrequencyRangeInnerSection.RadWidePowerLevelBandFrequency_A41063.SetValue(global::CommonResources.AcgResources.ID_P_900MHZ);
							txPowerLevelsByFrequencyRangeInnerSection.RadWideTransmitPowerLevelsFrequencyRangeEndMHz_A20037.SetValue(188200000);
							txPowerLevelsByFrequencyRangeInnerSection.RadWideTransmitPowerLevelsFrequencyRangeStartMHz_A19994.SetValue(188000000);
							num = (short)1101594664;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						default:
							num = (short)1335623740;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 3:
						goto IL_B2E;
					case 4:
					{
						int count = txPowerLevelsByFrequencyRangeInnerRecset.Count;
						num = (short)857997358;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						goto IL_5F9;
					case 6:
						if (labtool.RadInfoLabtoolPrimaryBands_A23987.Value == 8)
						{
							num = (short)1850605605;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)677970031;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_3E7;
					case 8:
						goto IL_3E7;
					case 9:
					{
						int count;
						if (num3 >= count)
						{
							num = (short)1533673567;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3E7;
					}
					case 10:
						goto IL_5F9;
					case 11:
						if (labtool.RadInfoLabtoolSecondaryBands_A23988.Value != 0)
						{
							num = (short)137363491;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_720;
					case 12:
						goto IL_3E7;
					case 13:
						txPowerLevelsByFrequencyRangeInnerSection.RadWideTransmitPowerLevelsFrequencyRangeEndMHz_A20037.SetValue(94400000);
						num = (short)591396934;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						switch (num3)
						{
						case 10:
						case 11:
						case 12:
						case 13:
							this.SetTransmitPowerLevels(txPowerLevelsByFrequencyRangeInnerSection, 36021, 39031, 42175, 42175);
							num = (short)1454112850;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 14:
							goto IL_12E5;
						case 15:
							this.SetTransmitPowerLevels(txPowerLevelsByFrequencyRangeInnerSection, 30000, 33010, 35441, 35441);
							num = (short)1716650063;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 16:
							this.SetTransmitPowerLevels(txPowerLevelsByFrequencyRangeInnerSection, 30000, 42175, 45185, 45185);
							num = (short)1516568600;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 17:
							this.SetTransmitPowerLevels(txPowerLevelsByFrequencyRangeInnerSection, 30000, 33010, 35441, 35441);
							num = (short)1010040889;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						default:
							num = (short)1028587553;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 15:
						num = (short)483655702;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						goto IL_B73;
					case 17:
						goto IL_5F9;
					case 18:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeInnerSection txPowerLevelsByFrequencyRangeInnerSection2;
						if (txPowerLevelsByFrequencyRangeInnerSection2.RadWideTransmitPowerLevelsTxPowerLevelMaximumW_A20039.Value == 43424)
						{
							num = (short)341573704;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9AC;
					}
					case 19:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeInnerSection txPowerLevelsByFrequencyRangeInnerSection2;
						if (txPowerLevelsByFrequencyRangeInnerSection2.RadWideTransmitPowerLevelsTxPowerLevelMinimumW_A20038.Value == 40000)
						{
							num = (short)1111621731;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9AC;
					}
					case 20:
						if (labtool.RadInfoLabtoolPrimaryBands_A23987.Value != 2)
						{
							num = (short)34799668;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_720;
					case 21:
						if (this.IsExtendedUHFR1CPG())
						{
							num = (short)1649475597;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						txPowerLevelsByFrequencyRangeInnerSection.RadWideTransmitPowerLevelsFrequencyRangeEndMHz_A20037.SetValue(94000000);
						num = (short)1938096213;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						if (labtool.RadInfoLabtoolSecondaryBands_A23988.Value != 3)
						{
							num = (short)1449459750;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_139F;
					case 23:
						goto IL_3E7;
					case 24:
						goto IL_3E7;
					case 25:
						goto IL_3E7;
					case 26:
						goto IL_3E7;
					case 27:
						goto IL_3E7;
					case 28:
						num = (short)1056505949;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
						goto IL_3E7;
					case 30:
						num = (short)1160052822;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
						switch (num3)
						{
						case 10:
						case 11:
						case 12:
						case 13:
							this.SetTransmitPowerLevels(txPowerLevelsByFrequencyRangeInnerSection, 36021, 41461, 44393, 44393);
							num = (short)274726960;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 14:
							this.SetTransmitPowerLevels(txPowerLevelsByFrequencyRangeInnerSection, 30000, 42175, 45185, 45185);
							num = (short)1126170650;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 15:
							this.SetTransmitPowerLevels(txPowerLevelsByFrequencyRangeInnerSection, 30000, 33010, 35441, 35441);
							num = (short)1644363788;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 16:
							this.SetTransmitPowerLevels(txPowerLevelsByFrequencyRangeInnerSection, 30000, 42175, 45185, 45185);
							num = (short)2097741871;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 17:
							this.SetTransmitPowerLevels(txPowerLevelsByFrequencyRangeInnerSection, 30000, 33010, 35441, 35441);
							num = (short)1703149645;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						default:
							num = (short)316276823;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 32:
						goto IL_3E7;
					case 33:
						num = (short)1424752734;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 34:
						goto IL_3E7;
					case 35:
						goto IL_10BE;
					case 36:
						if (labtool.RadInfoLabtoolPrimaryBands_A23987.Value != 4)
						{
							num = (short)493027378;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_720;
					case 37:
						goto IL_720;
					case 38:
						goto IL_C28;
					case 39:
						if (labtool.RadInfoLabtoolSecondaryBands_A23988.Value != 2)
						{
							num = (short)1352269873;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_720;
					case 40:
						goto IL_5F9;
					case 41:
						goto IL_3E7;
					case 42:
						num = (short)124715009;
						if (num != 0)
						{
						}
						goto IL_B73;
					case 43:
						try
						{
							switch (0)
							{
							case 0:
								goto IL_18AD;
							}
							int value;
							for (;;)
							{
								IL_187E:
								switch (num2)
								{
								case 0:
									goto IL_1AC5;
								case 1:
									if (value != 17)
									{
										num = (short)127074313;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_190B;
								case 2:
									goto IL_190B;
								case 3:
									goto IL_1ADD;
								case 4:
									if (value == 22)
									{
										num = (short)1837039618;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1AC5;
								case 5:
									num = (short)1716453377;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
								{
									if (value == 15)
									{
										goto IL_190B;
									}
									num = (short)1013453249;
									short num4 = num;
									num = (short)1009062337;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_18EE;
									default:
										num = (short)1894711296;
										if (num != 0)
										{
										}
										num = (short)744947717;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 7:
									if (value != 14)
									{
										goto IL_18EE;
									}
									goto IL_190B;
								case 8:
									num = (short)1698562054;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
									num = (short)1126105092;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_18AD;
								IL_18EE:
								num = (short)36306952;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_190B:
								(txPowerLevelsByFrequencyRangeInnerRecset[10][10104] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeInnerSection).RadWideTransmitPowerLevelsTxPowerLevelMinimumW_A20038.SetValue(30000);
								(txPowerLevelsByFrequencyRangeInnerRecset[11][10104] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeInnerSection).RadWideTransmitPowerLevelsTxPowerLevelMinimumW_A20038.SetValue(30000);
								(txPowerLevelsByFrequencyRangeInnerRecset[12][10104] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeInnerSection).RadWideTransmitPowerLevelsTxPowerLevelMinimumW_A20038.SetValue(30000);
								(txPowerLevelsByFrequencyRangeInnerRecset[13][10104] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeInnerSection).RadWideTransmitPowerLevelsTxPowerLevelMinimumW_A20038.SetValue(30000);
								num = (short)379781120;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1AC5:
								num = (short)1182859267;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1ADD:
							return;
							IL_18AD:
							value = (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation).Labtool.RadInfoLabtoolProductModelIdentifier_A37178.Value;
							num = (short)1478164487;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_187E;
						}
						catch
						{
							return;
						}
						goto IL_1AE2;
					case 44:
						if (num3 >= 18)
						{
							num = (short)1904738413;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)830930953;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 45:
						goto IL_3E7;
					case 46:
						goto IL_B2E;
					case 47:
						goto IL_3E7;
					case 48:
						goto IL_3E7;
					case 49:
						goto IL_FC5;
					case 50:
						num = (short)1945501702;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 51:
						num = (short)1689780328;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 52:
						num = (short)1115160612;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 53:
						goto IL_3E7;
					case 54:
						goto IL_5F9;
					case 55:
						if (labtool.RadInfoLabtoolPrimaryBands_A23987.Value != 3)
						{
							num = (short)1278869555;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_139F;
					case 56:
						num = (short)1335820357;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 57:
						goto IL_3E7;
					case 58:
						switch (num3)
						{
						case 10:
							this.SetTransmitPowerLevels(txPowerLevelsByFrequencyRangeInnerSection, 43979, 47404, 50414, 50414);
							num = (short)406257671;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 11:
							this.SetTransmitPowerLevels(txPowerLevelsByFrequencyRangeInnerSection, 36021, 43979, 46946, 46946);
							num = (short)1450901568;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 12:
							this.SetTransmitPowerLevels(txPowerLevelsByFrequencyRangeInnerSection, 36021, 43424, 46435, 46435);
							num = (short)895483938;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 13:
							this.SetTransmitPowerLevels(txPowerLevelsByFrequencyRangeInnerSection, 36021, 41461, 44393, 44393);
							num = (short)1787101282;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 14:
							this.SetTransmitPowerLevels(txPowerLevelsByFrequencyRangeInnerSection, 30000, 42175, 45185, 45185);
							num = (short)942866432;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 15:
							this.SetTransmitPowerLevels(txPowerLevelsByFrequencyRangeInnerSection, 30000, 33010, 35441, 35441);
							num = (short)1548550152;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 16:
							this.SetTransmitPowerLevels(txPowerLevelsByFrequencyRangeInnerSection, 30000, 42175, 45185, 45185);
							num = (short)1246494745;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 17:
							this.SetTransmitPowerLevels(txPowerLevelsByFrequencyRangeInnerSection, 30000, 33010, 35441, 35441);
							num = (short)2077884516;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						default:
							num = (short)184746014;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 59:
						if (labtool.RadInfoLabtoolPrimaryBands_A23987.Value == 1)
						{
							num = (short)1535705184;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_FC5;
					case 60:
						num = (short)43319361;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 61:
						switch (num3)
						{
						case 10:
						case 11:
						case 12:
						case 13:
							this.SetTransmitPowerLevels(txPowerLevelsByFrequencyRangeInnerSection, 36021, 40414, 43424, 43424);
							num = (short)602603610;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 14:
							this.SetTransmitPowerLevels(txPowerLevelsByFrequencyRangeInnerSection, 30000, 42175, 45185, 45185);
							num = (short)1665859585;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 15:
							this.SetTransmitPowerLevels(txPowerLevelsByFrequencyRangeInnerSection, 30000, 33010, 35441, 35441);
							num = (short)699990096;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 16:
							this.SetTransmitPowerLevels(txPowerLevelsByFrequencyRangeInnerSection, 30000, 42175, 45185, 45185);
							num = (short)779550747;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 17:
							goto IL_1AE2;
						default:
							num = (short)1191510123;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 62:
						goto IL_3E7;
					case 63:
						num = (short)1223229454;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 64:
						goto IL_3E7;
					case 65:
						goto IL_5F9;
					case 66:
						goto IL_5F9;
					case 67:
						num = (short)1918435412;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 68:
						if (txPowerLevelsByFrequencyRangeInnerSection != null)
						{
							num = (short)1384513564;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3E7;
					case 69:
						if (txPowerLevelsByFrequencyRangeInnerRecset.Count < 18)
						{
							num = (short)872022020;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1856;
					case 70:
						goto IL_5C9;
					case 71:
						num = (short)285802498;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 72:
						num = (short)1890254867;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 73:
						try
						{
							switch (0)
							{
							case 0:
								goto IL_1137;
							}
							int value2;
							for (;;)
							{
								IL_1110:
								switch (num2)
								{
								case 0:
									num = (short)1823014913;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									if (value2 == 17)
									{
										num = (short)1057357831;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_12C2;
								case 2:
									goto IL_12DA;
								case 3:
									goto IL_12C2;
								case 4:
									if (value2 != 15)
									{
										num = (short)1232207872;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_11CF;
								case 5:
									if (value2 != 14)
									{
										num = (short)447610886;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_11CF;
								case 6:
									num = (short)1481113604;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									goto IL_11CF;
								}
								goto IL_1137;
								IL_11CF:
								(txPowerLevelsByFrequencyRangeInnerRecset[10][10104] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeInnerSection).RadWideTransmitPowerLevelsTxPowerLevelMinimumW_A20038.SetValue(30000);
								(txPowerLevelsByFrequencyRangeInnerRecset[11][10104] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeInnerSection).RadWideTransmitPowerLevelsTxPowerLevelMinimumW_A20038.SetValue(30000);
								(txPowerLevelsByFrequencyRangeInnerRecset[12][10104] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeInnerSection).RadWideTransmitPowerLevelsTxPowerLevelMinimumW_A20038.SetValue(30000);
								(txPowerLevelsByFrequencyRangeInnerRecset[13][10104] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeInnerSection).RadWideTransmitPowerLevelsTxPowerLevelMinimumW_A20038.SetValue(30000);
								num = (short)607125507;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_12C2:
								num = (short)1472790530;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_12DA:
							goto IL_4DE;
							IL_1137:
							value2 = (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation).Labtool.RadInfoLabtoolProductModelIdentifier_A37178.Value;
							num = (short)91291653;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_1110;
						}
						catch
						{
							goto IL_4DE;
						}
						goto IL_12E5;
						IL_4DE:
						num = (short)1031864363;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 74:
						if (txPowerLevelsByFrequencyRangeInnerRecset.Count >= 18)
						{
							num = (short)602603595;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						txPowerLevelsByFrequencyRangeInnerRecset.AddRecord(txPowerLevelsByFrequencyRangeInnerRecset.CreateDefaultRecord());
						num = (short)268107779;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 75:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeInnerSection txPowerLevelsByFrequencyRangeInnerSection2 = txPowerLevelsByFrequencyRangeInnerRecset[0][10104] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeInnerSection;
						num3 = 10;
						num = (short)553844778;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 76:
						goto IL_3E7;
					case 77:
						goto IL_3E7;
					case 78:
						goto IL_3E7;
					case 79:
						goto IL_3E7;
					case 80:
						goto IL_3E7;
					case 81:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeInnerSection txPowerLevelsByFrequencyRangeInnerSection2;
						if (txPowerLevelsByFrequencyRangeInnerSection2.RadWideTransmitPowerLevelsTxPowerLevelMaximumW_A20039.Value == 44393)
						{
							num = (short)1767964739;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_131E;
					}
					case 82:
						goto IL_3E7;
					case 83:
						goto IL_3E7;
					case 84:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeInnerSection txPowerLevelsByFrequencyRangeInnerSection2;
						if (txPowerLevelsByFrequencyRangeInnerSection2.RadWideTransmitPowerLevelsTxPowerLevelMinimumW_A20038.Value == 40000)
						{
							num = (short)606077029;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_131E;
					}
					case 85:
					{
						num = (short)1926823936;
						short num5 = num;
						goto IL_5C9;
					}
					case 86:
						goto IL_3E7;
					case 87:
						num = (short)183631950;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 88:
						goto IL_5F9;
					case 89:
						goto IL_5F9;
					case 90:
						goto IL_3E7;
					case 91:
						num = (short)417923134;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 92:
						switch (num3)
						{
						case 10:
							this.SetTransmitPowerLevels(txPowerLevelsByFrequencyRangeInnerSection, 36021, 43424, 46435, 46435);
							num = (short)1966735457;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 11:
							this.SetTransmitPowerLevels(txPowerLevelsByFrequencyRangeInnerSection, 36021, 43979, 46946, 46946);
							num = (short)1838481516;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 12:
							this.SetTransmitPowerLevels(txPowerLevelsByFrequencyRangeInnerSection, 36021, 43424, 46435, 46435);
							num = (short)803078189;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 13:
							this.SetTransmitPowerLevels(txPowerLevelsByFrequencyRangeInnerSection, 36021, 41461, 44393, 44393);
							num = (short)656998505;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 14:
							this.SetTransmitPowerLevels(txPowerLevelsByFrequencyRangeInnerSection, 30000, 42175, 45185, 45185);
							num = (short)1383268384;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 15:
							this.SetTransmitPowerLevels(txPowerLevelsByFrequencyRangeInnerSection, 30000, 33010, 35441, 35441);
							num = (short)1778909267;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 16:
							this.SetTransmitPowerLevels(txPowerLevelsByFrequencyRangeInnerSection, 30000, 42175, 45185, 45185);
							num = (short)1715535913;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 17:
							this.SetTransmitPowerLevels(txPowerLevelsByFrequencyRangeInnerSection, 30000, 33010, 35441, 35441);
							num = (short)2121859101;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						default:
							num = (short)1540685915;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 93:
						if (labtool != null)
						{
							num = (short)827785287;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3E7;
					case 94:
						goto IL_3E7;
					case 95:
						txPowerLevelsByFrequencyRangeInnerSection = (txPowerLevelsByFrequencyRangeInnerRecset[num3][10104] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeInnerSection);
						num = (short)2073296964;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 96:
						num = (short)345243687;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 97:
						goto IL_3E7;
					case 98:
						goto IL_3E7;
					case 99:
						num = (short)490668093;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 100:
						goto IL_3E7;
					case 101:
						num = (short)495255583;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 102:
						if (labtool.RadInfoLabtoolG138MotorcycleRadio_A24684.Value)
						{
							num = (short)171835455;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)446169194;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 103:
						if (txPowerLevelsByFrequencyRangeInnerRecset != null)
						{
							num = (short)1942093880;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1856;
					case 104:
						if (labtool.RadInfoLabtoolPrimaryBands_A23987.Value == 5)
						{
							num = (short)97779824;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3E7;
					case 105:
						goto IL_3E7;
					case 106:
						if (labtool.RadInfoLabtoolPrimaryBands_A23987.Value == 1)
						{
							num = (short)1067057262;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_10BE;
					case 107:
						num = (short)412090444;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 108:
						goto IL_3E7;
					case 109:
						goto IL_1856;
					case 110:
						num = (short)191823883;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 111:
						if (labtool.RadInfoLabtoolPrimaryBands_A23987.Value == 1)
						{
							num = (short)283181071;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C28;
					case 112:
						goto IL_139F;
					}
					goto IL_1F3;
					IL_3E7:
					num3++;
					num = (short)178454544;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5C9:
					txPowerLevelsByFrequencyRangeInnerSection.RadWideTransmitPowerLevelsFrequencyRangeStartMHz_A19994.SetValue(76000000);
					num = (short)1369112593;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5F9:
					num = (short)600899602;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_720:
					num = (short)1481834588;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_9AC:
					num = (short)865206353;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_B2E:
					num = (short)1305608266;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_B73:
					num = (short)1081737260;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C28:
					num = (short)293863479;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_FC5:
					num = (short)1056309268;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_10BE:
					num = (short)1471676475;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_12E5:
					this.SetTransmitPowerLevels(txPowerLevelsByFrequencyRangeInnerSection, 30000, 42175, 45185, 45185);
					num = (short)352190487;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_131E:
					num = (short)804192358;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_139F:
					num = (short)247791674;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1856:
					num = (short)1032061001;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1AE2:
					this.SetTransmitPowerLevels(txPowerLevelsByFrequencyRangeInnerSection, 30000, 33010, 35441, 35441);
					num = (short)1429012533;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_1F3:
				txPowerLevelsByFrequencyRangeInnerRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0][10103].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeInnerRecset);
				labtool = (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0][10107] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.Labtool);
				num = (short)629145703;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x0001A870 File Offset: 0x00018A70
		private void SetTransmitPowerLevels(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeInnerSection txPowerLevel, int min, int low, int high, int max)
		{
			short num = (short)30351669;
			short num2 = num;
			num = (short)554180917;
			switch (num2 == num)
			{
			}
			num = (short)1704067072;
			short num3 = num;
			num = (short)1092485121;
			if (num != 0)
			{
			}
			num = (short)1853751296;
			if (num != 0)
			{
			}
			txPowerLevel.RadWideTransmitPowerLevelsTxPowerLevelMinimumW_A20038.SetValue(min);
			txPowerLevel.RadWideTransmitPowerLevelsTxPowerLevelLowW_A8153.SetValue(low);
			txPowerLevel.RadWideTransmitPowerLevelsTxPowerLevelHighW_A8152.SetValue(high);
			txPowerLevel.RadWideTransmitPowerLevelsTxPowerLevelMaximumW_A20039.SetValue(max);
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x0001A94C File Offset: 0x00018B4C
		private void MFKTableInit()
		{
			short num = (short)536084480;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_AE;
				}
				global::Motorola.MackinawCPS.CoreFeatures.Switches.SwitchesRecset switchesRecset;
				for (;;)
				{
					IL_27:
					global::Motorola.MackinawCPS.CoreFeatures.Switches.MFKAssignmentControlInnerRecset mfkassignmentControlInnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.Switches.MFKAssignmentControlInner mfkassignmentControlInner;
					switch (num2)
					{
					case 0:
						mfkassignmentControlInnerRecset = (switchesRecset[0][10637].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.Switches.MFKAssignmentControlInnerRecset);
						num = (short)1344733187;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						return;
					case 2:
						goto IL_275;
					case 3:
					{
						if (mfkassignmentControlInnerRecset == null)
						{
							goto IL_2B5;
						}
						num = (short)648085504;
						short num3 = num;
						num = (short)1373684718;
						short num4 = num;
						num = (short)1377223662;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_2CD;
						default:
							num = (short)507707392;
							if (num != 0)
							{
							}
							num = (short)1101725711;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 4:
					{
						global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInnerRecset signalIndependentProductIndependentNonProgrammableButtonListInnerRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2013) as global::Motorola.MackinawCPS.CoreFeatures.Shepherds.ShepherdsRecset)[0][10031].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInnerRecset;
						num = (short)1845690388;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
					{
						global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInnerRecset signalIndependentProductIndependentNonProgrammableButtonListInnerRecset;
						if (signalIndependentProductIndependentNonProgrammableButtonListInnerRecset.Count < 26)
						{
							num = (short)141754384;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 6:
					{
						global::Motorola.MackinawCPS.CoreFeatures.Switches.MFKAssignmentControlInnerSection mfkassignmentControlInnerSection;
						mfkassignmentControlInnerSection.RadErgoControlSwitchsMFKFeatureAssignment_A38514.SetValue(23);
						num = (short)1349058583;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
					{
						global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInner signalIndependentProductIndependentNonProgrammableButtonListInner;
						signalIndependentProductIndependentNonProgrammableButtonListInner.SignalIndependentProductIndependentNonProgrammableButtonListInnerSection.RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonBCO_A19777.SetValue(91);
						signalIndependentProductIndependentNonProgrammableButtonListInner.SignalIndependentProductIndependentNonProgrammableButtonListInnerSection.RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonFeature_A19778.SetValue(38);
						num = (short)2086535169;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
					{
						global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInner signalIndependentProductIndependentNonProgrammableButtonListInner2;
						signalIndependentProductIndependentNonProgrammableButtonListInner2.SignalIndependentProductIndependentNonProgrammableButtonListInnerSection.RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonBCO_A19777.SetValue(11);
						signalIndependentProductIndependentNonProgrammableButtonListInner2.SignalIndependentProductIndependentNonProgrammableButtonListInnerSection.RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonFeature_A19778.SetValue(38);
						num = (short)1492713474;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
					{
						global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInner signalIndependentProductIndependentNonProgrammableButtonListInner2;
						if (signalIndependentProductIndependentNonProgrammableButtonListInner2 != null)
						{
							num = (short)719585288;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_275;
					}
					case 10:
						if (mfkassignmentControlInnerRecset.Count < 2)
						{
							num = (short)239206417;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2B5;
					case 11:
						if (mfkassignmentControlInner != null)
						{
							num = (short)96141343;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2B5;
					case 12:
						if (switchesRecset != null)
						{
							num = (short)1541996544;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2B5;
					case 13:
					{
						global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInner signalIndependentProductIndependentNonProgrammableButtonListInner;
						if (signalIndependentProductIndependentNonProgrammableButtonListInner != null)
						{
							num = (short)31195143;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 14:
						goto IL_58A;
					case 15:
						num = (short)1163132938;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						num = (short)247332893;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						num = (short)2138701850;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						if (mfkassignmentControlInnerRecset.Count >= 2)
						{
							num = (short)35717148;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						mfkassignmentControlInnerRecset.AddRecord(mfkassignmentControlInnerRecset.CreateDefaultRecord());
						num = (short)1311375384;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
					{
						global::Motorola.MackinawCPS.CoreFeatures.Switches.MFKAssignmentControlInner mfkassignmentControlInner2 = mfkassignmentControlInnerRecset[0] as global::Motorola.MackinawCPS.CoreFeatures.Switches.MFKAssignmentControlInner;
						global::Motorola.MackinawCPS.CoreFeatures.Switches.MFKAssignmentControlInnerSection mfkassignmentControlInnerSection = mfkassignmentControlInner2.MFKAssignmentControlInnerSection;
						if (mfkassignmentControlInner2 != null)
						{
							num = (short)1843527686;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_540;
					}
					case 20:
					{
						global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInnerRecset signalIndependentProductIndependentNonProgrammableButtonListInnerRecset;
						if (signalIndependentProductIndependentNonProgrammableButtonListInnerRecset != null)
						{
							num = (short)1926430742;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 21:
						goto IL_2B5;
					case 22:
						num = (short)1348861953;
						if (num != 0)
						{
						}
						num = (short)100204549;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						goto IL_540;
					case 24:
						goto IL_2F4;
					case 25:
					{
						global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInnerRecset signalIndependentProductIndependentNonProgrammableButtonListInnerRecset;
						global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInner signalIndependentProductIndependentNonProgrammableButtonListInner2 = signalIndependentProductIndependentNonProgrammableButtonListInnerRecset[24] as global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInner;
						global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInner signalIndependentProductIndependentNonProgrammableButtonListInner = signalIndependentProductIndependentNonProgrammableButtonListInnerRecset[25] as global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInner;
						num = (short)1613692937;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 26:
						goto IL_2F4;
					case 27:
						goto IL_2CD;
					case 28:
						num = (short)1508179987;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
						goto IL_58A;
					case 30:
					{
						global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInnerRecset signalIndependentProductIndependentNonProgrammableButtonListInnerRecset;
						if (signalIndependentProductIndependentNonProgrammableButtonListInnerRecset.Count >= 26)
						{
							num = (short)1032192025;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						signalIndependentProductIndependentNonProgrammableButtonListInnerRecset.AddRecord(signalIndependentProductIndependentNonProgrammableButtonListInnerRecset.CreateDefaultRecord());
						num = (short)1890648078;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 31:
						mfkassignmentControlInner.MFKAssignmentControlInnerSection.SwitchMFKAssignmentControlName_A38529.SetValue(global::CommonResources.AppResources.Secondary_Function);
						num = (short)124715029;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_AE;
					IL_275:
					num = (short)1842675725;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2B5:
					num = (short)325976091;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2CD:
					if (global::ConstraintHelper.UtilityMack.IsPortableOnly())
					{
						num = (short)2094792708;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_2F4:
					num = (short)38076434;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_540:
					mfkassignmentControlInner = (mfkassignmentControlInnerRecset[1] as global::Motorola.MackinawCPS.CoreFeatures.Switches.MFKAssignmentControlInner);
					num = (short)703725579;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_58A:
					num = (short)755695646;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_AE:
				switchesRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2038) as global::Motorola.MackinawCPS.CoreFeatures.Switches.SwitchesRecset);
				num = (short)582615052;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x0001AFA0 File Offset: 0x000191A0
		private void ToneSignalingListToneAliasFixup()
		{
			int a_ = 15;
			short num = (short)1207566336;
			switch (num)
			{
			default:
			{
				num = (short)1421934594;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)69402627;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.ToneSignalingList toneSignalingList;
									global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.AstroAlertingToneTableInnerRecset astroAlertingToneTableInnerRecset = toneSignalingList.AstroAlertingToneListExpander.EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.AstroAlertingToneTableInnerRecset;
									num = (short)1514471434;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									num = (short)1743585286;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									num = (short)1191575559;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_12C;
									}
									continue;
								case 4:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)589627394;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.ToneSignalingList toneSignalingList = enumerator.Current as global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.ToneSignalingList;
									num = (short)296222725;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.ToneSignalingList toneSignalingList;
									if (toneSignalingList != null)
									{
										num = (short)1299054604;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.ToneSignalingList toneSignalingList;
									if (toneSignalingList.AstroAlertingToneListExpander.EmbeddedRecset != null)
									{
										num = (short)138739712;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 7:
									goto IL_412;
								case 8:
								{
									int num3 = 1;
									global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.AstroAlertingToneTableInnerRecset astroAlertingToneTableInnerRecset;
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2 = astroAlertingToneTableInnerRecset.GetEnumerator();
									num = (short)544342025;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 9:
									try
									{
										num = (short)1582956548;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												goto IL_255;
											case 1:
												num = (short)515833856;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 3:
											{
												global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
												if (!enumerator2.MoveNext())
												{
													num = (short)130482177;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												int num3;
												(enumerator2.Current as global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.AstroAlertingToneTableInner).AstroAlertingToneTableInnerSection.RadErgoAstroAlertingToneTableToneAliasText_42533.SetValue(string.Format(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("믮黰鷲郴ퟶ룸韺铼黾爀⌂縄㜆琈", a_), num3));
												num3++;
												num = (short)883032066;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 4:
												switch (0)
												{
												case 0:
													goto IL_1AE;
												}
												continue;
											}
											IL_201:
											num = (short)657588227;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_1AE:
											goto IL_201;
										}
										IL_255:;
									}
									finally
									{
										num = (short)1454637058;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
											switch (num2)
											{
											case 0:
												goto IL_2C2;
											case 1:
												enumerator2.Dispose();
												num = (short)1595736064;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 2:
												switch (0)
												{
												case 0:
													goto IL_289;
												}
												continue;
											}
											IL_289:
											if (enumerator2 == null)
											{
												break;
											}
											num = (short)1209466881;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_2C2:;
									}
									break;
								case 10:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.AstroAlertingToneTableInnerRecset astroAlertingToneTableInnerRecset;
									if (astroAlertingToneTableInnerRecset != null)
									{
										num = (short)1348075528;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 11:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.ToneSignalingList toneSignalingList;
									if (toneSignalingList.AstroAlertingToneListExpander != null)
									{
										num = (short)1029832705;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 12:
									num = (short)1400242187;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_2C5:
								num = (short)928055300;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_12C:
								goto IL_2C5;
							}
							IL_412:
							return;
						}
						finally
						{
							num = (short)631832578;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								num = (short)1017088294;
								short num4 = num;
								num = (short)1271564582;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_4D0;
								default:
									num = (short)1567555584;
									if (num != 0)
									{
									}
									switch (num2)
									{
									case 0:
										goto IL_4D0;
									case 1:
										enumerator.Dispose();
										num = (short)423559168;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_496;
										}
										continue;
									}
									IL_496:
									if (enumerator == null)
									{
										goto IL_4D2;
									}
									num = (short)670040065;
									num2 = (int)((global::System.IntPtr)num);
									break;
								}
							}
							IL_4D0:
							IL_4D2:;
						}
						goto IL_4D3;
					case 1:
					{
						num = (short)1137901569;
						if (num != 0)
						{
						}
						num = (short)1507917824;
						short num5 = num;
						goto IL_4D3;
					}
					case 2:
						switch (0)
						{
						case 0:
							goto IL_59;
						}
						continue;
					}
					IL_59:
					if (this.GetCodeplugMainVersion() < 14)
					{
						num = (short)1056571393;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_4D3:
					enumerator = (global::AcpCommonLib.FeatureManager.GetFeature(4156) as global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.ToneSignalingListRecset).GetEnumerator();
					num = (short)1316618240;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
			}
			}
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x0001B4E8 File Offset: 0x000196E8
		private int GetCodeplugMainVersion()
		{
			int result = 0;
			short num2;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_2C;
				}
				int num;
				global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
				for (;;)
				{
					IL_0E:
					switch (num)
					{
					case 0:
						while (radioInformation != null)
						{
							num2 = (short)1846645097;
							short num3 = num2;
							num2 = (short)1092063593;
							switch ((num3 == num2) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								num2 = (short)138346496;
								if (num2 != 0)
								{
								}
								num2 = (short)1900085253;
								num = (int)((global::System.IntPtr)num2);
								goto IL_0E;
							}
						}
						goto IL_15A;
					case 1:
					{
						string radInfoGeneralCodeplugVersion_A7683_UIValue;
						result = int.Parse(radInfoGeneralCodeplugVersion_A7683_UIValue.Substring(1, 2).ToString());
						num2 = (short)727252994;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 2:
						goto IL_15A;
					case 3:
						goto IL_173;
					case 4:
					{
						string radInfoGeneralCodeplugVersion_A7683_UIValue;
						if (radInfoGeneralCodeplugVersion_A7683_UIValue.Length > 2)
						{
							num2 = (short)1193607169;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_15A;
					}
					case 5:
					{
						string radInfoGeneralCodeplugVersion_A7683_UIValue = radioInformation.General.RadInfoGeneralCodeplugVersion_A7683_UIValue;
						num2 = (short)285999105;
						if (num2 != 0)
						{
						}
						num2 = (short)438370308;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					goto IL_2C;
					IL_15A:
					num2 = (short)2117599235;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_173:
				goto IL_178;
				IL_2C:
				radioInformation = (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation);
				num2 = (short)2109997056;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0E;
			}
			catch
			{
			}
			IL_178:
			num2 = (short)1059192832;
			short num4 = num2;
			return result;
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x0001B6B4 File Offset: 0x000198B4
		private void hideADPKeyData()
		{
			short num = (short)1553006592;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_4A;
				}
				global::AcpCommonLib.IAcpRecordset feature;
				for (;;)
				{
					IL_27:
					global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide secureWide;
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					switch (num2)
					{
					case 0:
						goto IL_275;
					case 1:
						if (feature != null)
						{
							num = (short)1282342918;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 2:
					{
						num = (short)184483840;
						short num3 = num;
						secureWide = (feature[0] as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide);
						num = (short)366673921;
						if (num != 0)
						{
						}
						num = (short)1185415171;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						if (secureWide.EncryptionKeyList.EmbeddedRecset != null)
						{
							num = (short)71761920;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 4:
						try
						{
							num = (short)834142209;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_1B7;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_CE;
									}
									continue;
								case 2:
								{
									global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInnerSection encryptionKeyListInnerSection;
									if (encryptionKeyListInnerSection.SecWideMultikeyListSelectableADPKeyData_A9106.Value != encryptionKeyListInnerSection.SecWideMultikeyListSelectableADPKeyData_A9106.DefaultValue)
									{
										num = (short)717946883;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
								{
									global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInnerSection encryptionKeyListInnerSection;
									encryptionKeyListInnerSection.SecWideMultikeyListSelectableADPKeyData_A9106.Value = encryptionKeyListInnerSection.SecWideMultikeyListSelectableADPKeyData_A9106.DefaultValue;
									num = (short)687538181;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									num = (short)1325596672;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1020198916;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInnerSection encryptionKeyListInnerSection = (enumerator.Current as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInner).EncryptionKeyListInnerSection;
									num = (short)1679294466;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_D0:
								num = (short)1048379398;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_CE:
								goto IL_D0;
							}
							IL_1B7:
							return;
						}
						finally
						{
							num = (short)373424130;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								num = (short)930301067;
								short num4 = num;
								num = (short)1642808459;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_272;
								default:
									num = (short)817889280;
									if (num != 0)
									{
									}
									switch (num2)
									{
									case 0:
										goto IL_272;
									case 1:
										enumerator.Dispose();
										num = (short)1350369280;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_238;
										}
										continue;
									}
									IL_238:
									if (enumerator == null)
									{
										goto IL_274;
									}
									num = (short)1735720961;
									num2 = (int)((global::System.IntPtr)num);
									break;
								}
							}
							IL_272:
							IL_274:;
						}
						goto IL_275;
					case 5:
						if (feature.Count != 0)
						{
							num = (short)1341652994;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 6:
						num = (short)2017329157;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4A;
					IL_275:
					enumerator = ((global::AcpBusinessLayer.Recordset)secureWide.EncryptionKeyList.EmbeddedRecset).GetEnumerator();
					num = (short)1046937604;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_4A:
				feature = global::AcpCommonLib.FeatureManager.GetFeature(2021);
				num = (short)168493057;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x0001BA68 File Offset: 0x00019C68
		private void RefreshAESFields()
		{
			short num = (short)863764480;
			short num2 = num;
			switch (0)
			{
			case 0:
				goto IL_5C;
			}
			string value;
			for (;;)
			{
				IL_32:
				int num3;
				switch (num3)
				{
				case 0:
					num = (short)1374093319;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (value != null)
					{
						num = (short)975503368;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 2:
				{
					global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide secureWide;
					if (secureWide.General.SecWideGeneralSecureOperation_A9067.Value == 3)
					{
						num = (short)1661272070;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				case 3:
					goto IL_250;
				case 4:
					goto IL_1EF;
				case 5:
				{
					global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide secureWide = global::AcpCommonLib.FeatureManager.GetFeature(2021)[0] as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide;
					num = (short)1565982722;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 6:
				{
					global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide secureWide;
					secureWide.General.SecureWideADPAlgorithmEnable_43200.SetValue(true);
					secureWide.General.SecureWideKeyloadingSource_43204.SetValue(0);
					num = (short)1385955331;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 7:
					if (int.Parse(value.Substring(1, 2)) < 16)
					{
						num = (short)1044447237;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 8:
					num = (short)1501626372;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_5C;
			}
			IL_250:
			return;
			IL_5C:
			value = (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation).General.RadInfoGeneralCodeplugVersion_A7683.Value;
			num = (short)2043234091;
			short num4 = num;
			num = (short)619530027;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_1EF:
				if (value.Length > 3)
				{
					num = (short)1351352320;
					int num3 = (int)((global::System.IntPtr)num);
					goto IL_32;
				}
				break;
			default:
			{
				num = (short)1343815681;
				if (num != 0)
				{
				}
				num = (short)780926976;
				if (num != 0)
				{
				}
				num = (short)87818241;
				int num3 = (int)((global::System.IntPtr)num);
				goto IL_32;
			}
			}
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x0001BCC8 File Offset: 0x00019EC8
		private void SetValuesForShepherdsCnvKeyfob(global::AcpCommonLib.IAcpFeatureNode shepherds, int innerRecordIndex, int typeId)
		{
			short num = (short)1872092637;
			short num2 = num;
			num = (short)1772543453;
			global::Motorola.MackinawCPS.CoreFeatures.Shepherds.ConventionalShepherdListInnerSection conventionalShepherdListInnerSection;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_1FB:
				conventionalShepherdListInnerSection.RadErgoCfgCnvBtnListType_A21164.SetValue(typeId);
				num = (short)58261512;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)1355087872;
				if (num != 0)
				{
				}
				num = (short)996474881;
				num3 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				global::Motorola.MackinawCPS.CoreFeatures.Shepherds.ConventionalShepherdListInnerRecset conventionalShepherdListInnerRecset;
				object obj;
				switch (num3)
				{
				case 0:
					if (conventionalShepherdListInnerSection != null)
					{
						num = (short)1068498951;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_9B;
					}
					continue;
				case 2:
					num = (short)1006960646;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (conventionalShepherdListInnerRecset != null)
					{
						num = (short)829685762;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 4:
					goto IL_B1;
				case 5:
				{
					if (conventionalShepherdListInnerRecset.Count >= innerRecordIndex + 1)
					{
						num = (short)171442186;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)2121531392;
					short num4 = num;
					conventionalShepherdListInnerRecset.AddRecord(conventionalShepherdListInnerRecset.CreateDefaultRecord());
					num = (short)1228341249;
					if (num != 0)
					{
					}
					num = (short)1447034884;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 6:
					goto IL_B1;
				case 7:
					goto IL_1FB;
				case 8:
					return;
				case 9:
					obj = null;
					goto IL_21C;
				case 10:
					conventionalShepherdListInnerSection = (conventionalShepherdListInnerRecset[innerRecordIndex][10036] as global::Motorola.MackinawCPS.CoreFeatures.Shepherds.ConventionalShepherdListInnerSection);
					num = (short)1071644672;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_9B:
				global::AcpCommonLib.IAcpFeatureSection acpFeatureSection = shepherds[10035];
				if (acpFeatureSection == null)
				{
					num = (short)609091593;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				obj = acpFeatureSection.EmbeddedRecset;
				goto IL_21C;
				IL_B1:
				num = (short)2029780997;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_21C:
				conventionalShepherdListInnerRecset = (obj as global::Motorola.MackinawCPS.CoreFeatures.Shepherds.ConventionalShepherdListInnerRecset);
				num = (short)1951989763;
				num3 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x060000DA RID: 218 RVA: 0x0001BF2C File Offset: 0x0001A12C
		private void SetValuesForShepherdsTrkKeyfob(global::AcpCommonLib.IAcpFeatureNode shepherds, int innerRecordIndex, int typeId)
		{
			short num = (short)621716833;
			short num2 = num;
			num = (short)1409000801;
			global::Motorola.MackinawCPS.CoreFeatures.Shepherds.TrunkingShepherdListInnerSection trunkingShepherdListInnerSection;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_1A7:
				trunkingShepherdListInnerSection.RadErgoCfgTrkBtnListType_A21167.SetValue(typeId);
				num = (short)727384072;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)1133641728;
				if (num != 0)
				{
				}
				num = (short)703397889;
				num3 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				global::Motorola.MackinawCPS.CoreFeatures.Shepherds.TrunkingShepherdListInnerRecset trunkingShepherdListInnerRecset;
				object obj;
				switch (num3)
				{
				case 0:
					if (trunkingShepherdListInnerSection != null)
					{
						num = (short)2027159559;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_9D;
					}
					continue;
				case 2:
					num = (short)1629290502;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (trunkingShepherdListInnerRecset != null)
					{
						num = (short)362283010;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 4:
					goto IL_B0;
				case 5:
					if (trunkingShepherdListInnerRecset.Count >= innerRecordIndex + 1)
					{
						num = (short)572981258;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					trunkingShepherdListInnerRecset.AddRecord(trunkingShepherdListInnerRecset.CreateDefaultRecord());
					num = (short)1422917636;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					goto IL_B0;
				case 7:
					goto IL_1A7;
				case 8:
					return;
				case 9:
					obj = null;
					goto IL_1C9;
				case 10:
					trunkingShepherdListInnerSection = (trunkingShepherdListInnerRecset[innerRecordIndex][10038] as global::Motorola.MackinawCPS.CoreFeatures.Shepherds.TrunkingShepherdListInnerSection);
					num = (short)266600448;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_9D:
				global::AcpCommonLib.IAcpFeatureSection acpFeatureSection = shepherds[10037];
				if (acpFeatureSection == null)
				{
					num = (short)293863433;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				obj = acpFeatureSection.EmbeddedRecset;
				goto IL_1C9;
				IL_B0:
				num = (short)1399652357;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_1C9:
				trunkingShepherdListInnerRecset = (obj as global::Motorola.MackinawCPS.CoreFeatures.Shepherds.TrunkingShepherdListInnerRecset);
				num = (short)743178240;
				short num4 = num;
				num = (short)790102017;
				if (num != 0)
				{
				}
				num = (short)334888963;
				num3 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x060000DB RID: 219 RVA: 0x0001C194 File Offset: 0x0001A394
		private void ShepherdsInitForFob()
		{
			switch (0)
			{
			case 0:
				goto IL_38;
			}
			int num;
			global::Motorola.MackinawCPS.CoreFeatures.Shepherds.ShepherdsRecset shepherdsRecset;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					this.SetValuesForShepherdsCnvKeyfob(shepherdsRecset[0], 3, 1148);
					this.SetValuesForShepherdsTrkKeyfob(shepherdsRecset[0], 3, 1149);
					num2 = (short)383188994;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
				{
					num2 = (short)159172144;
					short num3 = num2;
					num2 = (short)1392166448;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_78;
					default:
						num2 = (short)286720000;
						if (num2 != 0)
						{
						}
						this.SetValuesForShepherdsCnvKeyfob(shepherdsRecset[0], 4, 1148);
						this.SetValuesForShepherdsTrkKeyfob(shepherdsRecset[0], 4, 1149);
						num2 = (short)220594183;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 2:
					goto IL_7D;
				case 3:
					num2 = (short)1227554824;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (shepherdsRecset.Count > 0)
					{
						num2 = (short)801701891;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 5:
				{
					num2 = (short)278921216;
					short num4 = num2;
					num2 = (short)43319297;
					if (num2 != 0)
					{
					}
					if (global::ConstraintHelper.UtilityMack.IsMobile())
					{
						num2 = (short)1584201729;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				case 6:
					goto IL_78;
				case 7:
					return;
				case 8:
					if (global::ConstraintHelper.UtilityMack.IsPortable())
					{
						num2 = (short)840892416;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_7D;
				case 9:
					if (shepherdsRecset != null)
					{
						num2 = (short)1353973766;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				goto IL_38;
				IL_78:
				num2 = (short)386793476;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_7D:
				num2 = (short)2079129605;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_38:
			shepherdsRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2013) as global::Motorola.MackinawCPS.CoreFeatures.Shepherds.ShepherdsRecset);
			num2 = (short)646053897;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060000DC RID: 220 RVA: 0x0001C3F8 File Offset: 0x0001A5F8
		private void TriggerMuteToneRefresh()
		{
			short num;
			global::AcpBusinessLayer.AcpListField radProfAlertTonesMuteTonesOperation_A;
			global::AcpBusinessLayer.AcpListField radProfAlertTonesEnhancedMuteTonesOperation_A;
			global::AcpBusinessLayer.AcpListField radProfAlertTonesNewMuteTonesOperation_A;
			for (;;)
			{
				num = (short)1229127680;
				switch (num)
				{
				default:
				{
					num = (short)1244069910;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
						switch (num2)
						{
						case 0:
						{
							int value;
							if (value != 1)
							{
								num = (short)1173028884;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_243;
						}
						case 1:
						{
							int value = radProfAlertTonesMuteTonesOperation_A.Value;
							num = (short)1419116556;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
						{
							int value;
							if (value != 15)
							{
								num = (short)133038097;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							radProfAlertTonesMuteTonesOperation_A.SetValue(3);
							radProfAlertTonesEnhancedMuteTonesOperation_A.SetValue(3);
							num = (short)1940652047;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
						{
							if (radProfAlertTonesNewMuteTonesOperation_A.Value == 0)
							{
								num = (short)455868417;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							int value = radProfAlertTonesNewMuteTonesOperation_A.Value;
							num = (short)55377920;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							goto IL_16A;
						case 5:
							goto IL_1AF;
						case 6:
							radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
							num = (short)936509445;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							return;
						case 8:
							num = (short)1025376265;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 9:
							if (radProfAlertTonesEnhancedMuteTonesOperation_A == null)
							{
								num = (short)1668415495;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1875116035;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 10:
							num = (short)806748181;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 11:
						{
							if (radioWide.AlertTones == null)
							{
								num = (short)1011482628;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.MackinawCPS.CoreFeatures.RadioWide.AlertTones alertTones = radioWide.AlertTones;
							radProfAlertTonesMuteTonesOperation_A = alertTones.RadProfAlertTonesMuteTonesOperation_A8562;
							radProfAlertTonesNewMuteTonesOperation_A = alertTones.RadProfAlertTonesNewMuteTonesOperation_A42149;
							radProfAlertTonesEnhancedMuteTonesOperation_A = alertTones.RadProfAlertTonesEnhancedMuteTonesOperation_A42150;
							num = (short)1974730765;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 12:
						{
							int value;
							switch (value)
							{
							case 0:
								goto IL_44C;
							case 1:
								goto IL_23B;
							case 2:
								return;
							case 3:
								goto IL_C6;
							default:
								num = (short)48431123;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 13:
							if (radProfAlertTonesMuteTonesOperation_A != null)
							{
								num = (short)726794250;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						case 14:
							num = (short)1839857675;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 15:
							goto IL_305;
						case 16:
							goto IL_1AF;
						case 17:
							goto IL_1AA;
						case 18:
							num = (short)558759937;
							if (num != 0)
							{
							}
							if (radioWide != null)
							{
								num = (short)1057685504;
								short num3 = num;
								num = (short)1416232974;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						case 19:
							return;
						case 20:
							num = (short)836829186;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 21:
							if (radProfAlertTonesNewMuteTonesOperation_A != null)
							{
								num = (short)1501691912;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						case 22:
							switch (0)
							{
							case 0:
								goto IL_9F;
							}
							continue;
						}
						IL_9F:
						if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugConfigurationMode)
						{
							num = (short)824049670;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						radioWide = (global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
						num = (short)1168769040;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1AF:
						num = (short)1896611858;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_1AA:
					num = (short)517360923;
					short num4 = num;
					num = (short)2054376731;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_2C8;
					}
					break;
				}
				}
			}
			IL_C6:
			radProfAlertTonesEnhancedMuteTonesOperation_A.SetValue(3);
			radProfAlertTonesNewMuteTonesOperation_A.SetValue(15);
			return;
			IL_16A:
			return;
			IL_23B:
			radProfAlertTonesEnhancedMuteTonesOperation_A.SetValue(1);
			return;
			IL_243:
			radProfAlertTonesMuteTonesOperation_A.SetValue(0);
			radProfAlertTonesEnhancedMuteTonesOperation_A.SetValue(2);
			return;
			IL_2C8:
			num = (short)4128768;
			if (num != 0)
			{
			}
			return;
			IL_305:
			return;
			IL_44C:
			radProfAlertTonesEnhancedMuteTonesOperation_A.SetValue(0);
		}

		// Token: 0x060000DD RID: 221 RVA: 0x0001C894 File Offset: 0x0001AA94
		private void PresetZoneChannelTableInit()
		{
			switch (0)
			{
			case 0:
				goto IL_57;
			}
			short num;
			int num2;
			global::AcpCommonLib.IAcpRecordset feature;
			for (;;)
			{
				IL_0A:
				num = (short)1844969473;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
					goto IL_1A3;
				case 1:
				{
					num = (short)1582694400;
					short num3 = num;
					global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.PresetZoneAndChannelTableInnerRecset presetZoneAndChannelTableInnerRecset;
					if (presetZoneAndChannelTableInnerRecset != null)
					{
						num = (short)690814981;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				case 2:
					goto IL_1A3;
				case 3:
				{
					global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.PresetZoneAndChannelTableInnerRecset presetZoneAndChannelTableInnerRecset = feature[0][10640].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.PresetZoneAndChannelTableInnerRecset;
					num = (short)270204929;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					return;
				case 5:
					goto IL_109;
				case 6:
				{
					global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.PresetZoneAndChannelTableInnerRecset presetZoneAndChannelTableInnerRecset;
					if (presetZoneAndChannelTableInnerRecset.Count >= 13)
					{
						num = (short)42663940;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					presetZoneAndChannelTableInnerRecset.AddRecord(presetZoneAndChannelTableInnerRecset.CreateDefaultRecord());
					num = (short)1307508736;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 7:
				{
					if (feature == null)
					{
						return;
					}
					num = (short)2077411541;
					short num4 = num;
					num = (short)118737109;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_109;
					default:
						num = (short)716570624;
						if (num != 0)
						{
						}
						num = (short)940965891;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				goto IL_57;
				IL_109:
				num = (short)1340735490;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1A3:
				num = (short)1537867782;
				num2 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_57:
			feature = global::AcpCommonLib.FeatureManager.GetFeature(2033);
			num = (short)242876423;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x060000DE RID: 222 RVA: 0x0001CA84 File Offset: 0x0001AC84
		private void AddQC2DefaultRecord()
		{
			short num = (short)1245184;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_3A;
				}
				global::AcpCommonLib.IAcpRecordset feature;
				for (;;)
				{
					IL_27:
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)1841561614;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_3B7;
								case 1:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)821886983;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpBusinessLayer.FeatureNode featureNode = enumerator.Current;
									num = (short)1687945222;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									num = (short)702677004;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									goto IL_15A;
								case 4:
									goto IL_15A;
								case 5:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.IndividualIDTonesInnerRecset individualIDTonesInnerRecset;
									if (individualIDTonesInnerRecset.Count >= 4)
									{
										num = (short)2025390090;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									individualIDTonesInnerRecset.AddRecord(individualIDTonesInnerRecset.CreateDefaultRecord());
									num = (short)1352794116;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
								{
									global::AcpBusinessLayer.FeatureNode featureNode;
									if (featureNode is global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem)
									{
										num = (short)912850952;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 7:
									num = (short)682622976;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
								{
									global::AcpBusinessLayer.FeatureNode featureNode;
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.IndividualIDTonesInnerRecset individualIDTonesInnerRecset = featureNode[10785].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.IndividualIDTonesInnerRecset;
									num = (short)523894795;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 10:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.IndividualIDTonesInnerRecset individualIDTonesInnerRecset;
									(individualIDTonesInnerRecset[0] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.IndividualIDTonesInner).IndividualIDTonesInnerSection.CnvSysGeneralQc2Name_A42231.Value = global::CommonResources.AppResources.QC2_Tone_A;
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.IndividualIDTonesInnerSection individualIDTonesInnerSection = (individualIDTonesInnerRecset[1] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.IndividualIDTonesInner).IndividualIDTonesInnerSection;
									individualIDTonesInnerSection.CnvSysGeneralQc2Name_A42231.Value = global::CommonResources.AppResources.QC2_Tone_B;
									individualIDTonesInnerSection.CnvSysGeneralQc2Freq_A42232.Value = 9032;
									individualIDTonesInnerSection.CnvSysGeneralQc2Code_A42234.Value = 94;
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.IndividualIDTonesInnerSection individualIDTonesInnerSection2 = (individualIDTonesInnerRecset[2] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.IndividualIDTonesInner).IndividualIDTonesInnerSection;
									individualIDTonesInnerSection2.CnvSysGeneralQc2Name_A42231.Value = global::CommonResources.AppResources.QC2_Tone_C;
									individualIDTonesInnerSection2.CnvSysGeneralQc2Freq_A42232.Value = 2885;
									individualIDTonesInnerSection2.CnvSysGeneralQc2Code_A42234.Value = 1;
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.IndividualIDTonesInnerSection individualIDTonesInnerSection3 = (individualIDTonesInnerRecset[3] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.IndividualIDTonesInner).IndividualIDTonesInnerSection;
									individualIDTonesInnerSection3.CnvSysGeneralQc2Name_A42231.Value = global::CommonResources.AppResources.QC2_Tone_D;
									individualIDTonesInnerSection3.CnvSysGeneralQc2Freq_A42232.Value = 2885;
									individualIDTonesInnerSection3.CnvSysGeneralQc2Code_A42234.Value = 1;
									num = (short)2109407241;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 11:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.IndividualIDTonesInnerRecset individualIDTonesInnerRecset;
									if (individualIDTonesInnerRecset != null)
									{
										num = (short)471859202;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 12:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.IndividualIDTonesInnerRecset individualIDTonesInnerRecset;
									if (individualIDTonesInnerRecset.Count == 1)
									{
										num = (short)91684877;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 13:
									num = (short)955449347;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 14:
									switch (0)
									{
									case 0:
										goto IL_107;
									}
									continue;
								}
								goto IL_107;
								IL_15A:
								num = (short)1037500421;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_19C:
								num = (short)429129729;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_107:
								goto IL_19C;
							}
							IL_3B7:
							return;
						}
						finally
						{
							num = (short)851509250;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_426;
								case 1:
									enumerator.Dispose();
									num = (short)131399680;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_3EE;
									}
									continue;
								}
								IL_3EE:
								if (enumerator != null)
								{
									num = (short)1274871809;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_426:
								num = (short)896513258;
								short num3 = num;
								num = (short)68793578;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_3EE;
								default:
									goto IL_45E;
								}
							}
							IL_45E:
							num = (short)191430656;
							if (num != 0)
							{
							}
						}
						goto IL_475;
					case 1:
						return;
					case 2:
						if (feature == null)
						{
							num = (short)2016870401;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_475;
					}
					goto IL_3A;
					IL_475:
					num = (short)783810560;
					short num4 = num;
					enumerator = ((global::AcpBusinessLayer.Recordset)feature).GetEnumerator();
					num = (short)1318060032;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_3A:
				feature = global::AcpCommonLib.FeatureManager.GetFeature(2053);
				num = (short)1534984193;
				if (num != 0)
				{
				}
				num = (short)2123694082;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x060000DF RID: 223 RVA: 0x0001CF78 File Offset: 0x0001B178
		private void updateUnpackedFields(bool isReadingRadio, global::SpecialFeatures.Comms.RadioParams currentRadioParams)
		{
			int a_ = 6;
			short num = (short)48758784;
			int num2 = (int)num;
			switch (num2)
			{
			default:
				switch (0)
				{
				case 0:
					goto IL_490;
				}
				for (;;)
				{
					IL_31:
					int num3;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7Recset controlHeadO7Recset;
					global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKRecset dekrecset;
					global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectStatusBCOListInnerRecset directStatusBCOListInnerRecset;
					int num4;
					global::AcpCommonLib.IAcpRecordset feature;
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					int num5;
					global::AcpCommonLib.IAcpRecordset acpRecordset;
					global::SpecialFeatures.Ucl.Contact.UclContact uclContact;
					global::Motorola.MackinawCPS.CoreFeatures.Shepherds.ShepherdsRecset shepherdsRecset;
					int value;
					global::AcpCommonLib.IAcpRecordset feature2;
					global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide secureWide;
					global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInnerSection signalIndependentProductIndependentNonProgrammableButtonListInnerSection;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset controlHeadO9Recset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButtonInnerRecset bottomFunctionProgrammableButtonInnerRecset;
					int num7;
					global::AcpBusinessLayer.AcpListField acpListField;
					global::AcpCommonLib.IAcpRecordset feature3;
					int num9;
					global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectStatusBCOListInnerSection directStatusBCOListInnerSection2;
					global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitchTableInner conventionalSwitchTableInner;
					global::Motorola.MackinawCPS.CoreFeatures.Switches.Switches switches2;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerRecset o7DataButtonInnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesRecset dataProfilesRecset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ResponseSelectorListInnerRecset responseSelectorListInnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInnerRecset signalIndependentProductIndependentNonProgrammableButtonListInnerRecset;
					global::AcpCommonLib.IAcpRecordset feature4;
					global::AcpCommonLib.IAcpRecordset feature5;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerRecset topFunctionProgrammableButtonListInnerRecset;
					int num10;
					int num12;
					global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInnerRecset keypadButtonInnerRecset;
					int num15;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2MultiFunctionKnob o2MultiFunctionKnob;
					global::AcpBusinessLayer.AcpListField acpListField2;
					bool radInfoLabtoolExtendedDispatch_A38638Value;
					global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityRecset conventionalPersonalityRecset;
					int codeplugMainVersion;
					global::AcpBusinessLayer.Recordset recordset;
					global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerRecset dataButtonInnerRecset3;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.ControlHeadO2Recset controlHeadO2Recset;
					int num18;
					global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectMessageListInnerRecset directMessageListInnerRecset2;
					string text;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerRecset o9DataButtonInnerRecset2;
					switch (num2)
					{
					case 0:
						num = (short)2015756484;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						int count;
						if (num3 >= count)
						{
							num = (short)282198122;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6ABF;
					}
					case 2:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7MultiFunctionKnob o7MultiFunctionKnob = controlHeadO7Recset[0][10718] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7MultiFunctionKnob;
						num = (short)428409004;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
					{
						global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInnerRecset dekbuttonInnerRecset = dekrecset[0][10232].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInnerRecset;
						global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectMessageListInnerRecset directMessageListInnerRecset = dekrecset[0][10229].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectMessageListInnerRecset;
						directStatusBCOListInnerRecset = (dekrecset[0][10219].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectStatusBCOListInnerRecset);
						global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectModeBCOListInnerRecset directModeBCOListInnerRecset = dekrecset[0][10220].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectModeBCOListInnerRecset;
						int count = directMessageListInnerRecset.Count;
						num4 = 0;
						num = (short)912785515;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
					{
						global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitchTableInner trunkingSwitchTableInner;
						if (trunkingSwitchTableInner.TrunkingSwitchTableInnerSection.SwitchTrunkingSwitchTablePosition3Feature_A21006.Value == 38)
						{
							num = (short)493486157;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_275D;
					}
					case 5:
						if (feature.Count != 0)
						{
							num = (short)555548904;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3433;
					case 6:
						num = (short)388956290;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						try
						{
							num = (short)2004287491;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 1:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)2123104258;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpBusinessLayer.FeatureNode featureNode = enumerator.Current;
									(((global::AcpCommonLib.IAcpFeatureNode)featureNode)[10212] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection).CHO3DataButtonConvIndex_A41419.CalculateApplicability();
									(((global::AcpCommonLib.IAcpFeatureNode)featureNode)[10212] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection).CHO3DataButtonConvIndex_A41419.CalculateValidity();
									(((global::AcpCommonLib.IAcpFeatureNode)featureNode)[10212] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection).CHO3DataButtonTrkIndex_A41420.CalculateApplicability();
									(((global::AcpCommonLib.IAcpFeatureNode)featureNode)[10212] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection).CHO3DataButtonTrkIndex_A41420.CalculateValidity();
									num = (short)141295616;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									num = (short)53936132;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_D15;
									}
									continue;
								case 4:
									goto IL_DF9;
								}
								IL_DA2:
								num = (short)76349441;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_D15:
								goto IL_DA2;
							}
							IL_DF9:
							goto IL_2E1E;
						}
						finally
						{
							num = (short)1658191874;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_E68;
								case 1:
									enumerator.Dispose();
									num = (short)1592852480;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_E30;
									}
									continue;
								}
								IL_E30:
								if (enumerator == null)
								{
									break;
								}
								num = (short)471007233;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_E68:;
						}
						goto IL_E6B;
					case 8:
					{
						global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitchTableInner trunkingSwitchTableInner;
						if (trunkingSwitchTableInner.TrunkingSwitchTableInnerSection.SwitchTrunkingSwitchTablePosition2Feature_A21005.Value == 42)
						{
							num = (short)965411013;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_275D;
					}
					case 9:
						try
						{
							num = (short)2076311552;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_1E4F;
									}
									continue;
								case 1:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInner topFunctionProgrammableButtonListInner;
									topFunctionProgrammableButtonListInner.TopFunctionProgrammableButtonListInnerSection.O9CHCnvTopFunctionButtonStsMsgIndex_A36781.SetValue(num5 + 1);
									topFunctionProgrammableButtonListInner.TopFunctionProgrammableButtonListInnerSection.O9CHTrkTopFunctionButtonStsMsgIndex_A36782.SetValue(num5 + 1);
									num = (short)1827274757;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									num = (short)840892420;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInner topFunctionProgrammableButtonListInner;
									global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectStatusBCOListInnerSection directStatusBCOListInnerSection;
									if (topFunctionProgrammableButtonListInner.TopFunctionProgrammableButtonListInnerSection.CnvTopFunctionButtonBCO_A36628.Value == directStatusBCOListInnerSection.DEKDirectStatusBCO_A9196.Value)
									{
										num = (short)2079981569;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
									goto IL_1F51;
								case 5:
									goto IL_1ECD;
								case 6:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)2035417090;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInner topFunctionProgrammableButtonListInner = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInner)enumerator.Current;
									num = (short)71303171;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_1E51:
								num = (short)103612422;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1E4F:
								goto IL_1E51;
							}
							IL_1ECD:
							IL_1F51:
							goto IL_1842;
						}
						finally
						{
							num = (short)830406657;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_1FC2;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_1F89;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)701825024;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_1F89:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1435893762;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1FC2:;
						}
						goto IL_1FC5;
					case 10:
					{
						global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.DisplayAndMenu displayAndMenu;
						acpRecordset = displayAndMenu.BacklightColorControl.EmbeddedRecset;
						int num6 = 0;
						enumerator = ((global::AcpBusinessLayer.Recordset)acpRecordset).GetEnumerator();
						num = (short)1647771715;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						goto IL_2F69;
					case 12:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide radioErgonomicsWide;
						radioErgonomicsWide.Advanced.RadErgoWideAdvancedLogicalSwitch2_A7756.SetValue(1);
						num = (short)1752432787;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
						if (uclContact.PhoneCallList.HasEmbeddedRecset)
						{
							num = (short)746913911;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2FB2;
					case 14:
						if (shepherdsRecset[0] != null)
						{
							num = (short)187498640;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_727B;
					case 15:
						value = 1;
						feature2 = global::AcpCommonLib.FeatureManager.GetFeature(2021);
						secureWide = null;
						num = (short)1239154790;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						if (acpRecordset.Count != 0)
						{
							num = (short)725286927;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6199;
					case 17:
					{
						bool flag;
						if (flag)
						{
							num = (short)845807814;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						signalIndependentProductIndependentNonProgrammableButtonListInnerSection.RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonFeature_A19778.SetValue(215);
						num = (short)1479868474;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 18:
					{
						global::SpecialFeatures.Ucl.Contact.PhoneCallList phoneCallList;
						if (phoneCallList.CallListPhone.UclPhone_PhoneNumber_A00033Value == "")
						{
							num = (short)630456353;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_57D;
					}
					case 19:
						goto IL_3433;
					case 20:
						num = (short)272761053;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						try
						{
							num = (short)661323777;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)320143365;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles = (global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles)enumerator.Current;
									num = (short)1234042886;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									switch (0)
									{
									case 0:
										goto IL_1BBC;
									}
									continue;
								case 2:
									num = (short)1550188548;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									goto IL_1D27;
								case 4:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
									if (dataProfiles.General.DataProfGeneralPacketDataMode_A8689.Value == 0)
									{
										num = (short)967966729;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
									num = (short)1343815683;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
									if (dataProfiles.General.DataProfGeneralDataProfileType_A21320.Value == 0)
									{
										num = (short)1257570306;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 8:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
									dataProfiles.Features.DataProfFeaturesARSMode_A7465.SetValue(0);
									num = (short)1526792199;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 9:
									num = (short)234684426;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
									if (dataProfiles.Features.DataProfFeaturesARSMode_A7465.Value == 3)
									{
										num = (short)1039794184;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_1CD4:
								num = (short)2142175232;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1BBC:
								goto IL_1CD4;
							}
							IL_1D27:
							goto IL_4A03;
						}
						finally
						{
							num = (short)1454440450;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_1D98;
								case 1:
									enumerator.Dispose();
									num = (short)285147136;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_1D60;
									}
									continue;
								}
								IL_1D60:
								if (enumerator == null)
								{
									break;
								}
								num = (short)72613889;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1D98:;
						}
						goto IL_1D9B;
					case 22:
					{
						bottomFunctionProgrammableButtonInnerRecset = (controlHeadO9Recset[0][10618].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButtonInnerRecset);
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInnerRecset consolidatedActionBCOListInnerRecset = controlHeadO9Recset[0][10622].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInnerRecset;
						global::AcpCommonLib.IAcpRecordset embeddedRecset = controlHeadO9Recset[0][10628].EmbeddedRecset;
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9InnerRecset o9InnerRecset = controlHeadO9Recset[0][10626].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9InnerRecset;
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerRecset o9DataButtonInnerRecset = controlHeadO9Recset[0][10611].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerRecset;
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5InnerRecset o5InnerRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2130) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.ControlHeadO5Recset)[0][10227].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5InnerRecset;
						global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerRecset dataButtonInnerRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2042) as global::Motorola.MackinawCPS.CoreFeatures.Buttons.ButtonsRecset)[0][10089].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerRecset;
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9Inner o9Inner = o9InnerRecset[0] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9Inner;
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInner o9DataButtonInner = o9DataButtonInnerRecset[0] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInner;
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5Inner o5Inner = o5InnerRecset[0] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5Inner;
						global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInner dataButtonInner = dataButtonInnerRecset[0] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInner;
						o9Inner.O9InnerSection.CHO9EmergencyButtonFeature_A36682.SetValue(o5Inner.O5InnerSection.CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754.Value);
						o9DataButtonInner.O9DataButtonInnerSection.RadErgCtrlHeadO9DataButtonCnvFeature_A36528.SetValue(dataButtonInner.DataButtonInnerSection.BtnConventionalButtonDatatButtonFeature_A22610.Value);
						o9DataButtonInner.O9DataButtonInnerSection.RadErgCtrlHeadO9DataButtonTrkFeature_A36526.SetValue(dataButtonInner.DataButtonInnerSection.BtnTrunkingButtonDatatButtonFeature_A22608.Value);
						num7 = consolidatedActionBCOListInnerRecset.Count;
						int num8 = 0;
						num = (short)883097776;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 23:
						secureWide.ASTROOTAR.SecWideASTROOTARIndividualASTROOTARRadioID_A8284.SetValue(value);
						num = (short)1781858335;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						enumerator = ((global::AcpBusinessLayer.Recordset)acpRecordset).GetEnumerator();
						num = (short)1458045059;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
					{
						global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitchTableInner trunkingSwitchTableInner;
						if (trunkingSwitchTableInner.TrunkingSwitchTableInnerSection.SwitchTrunkingSwitchTablePosition1Feature_A21004.Value == 38)
						{
							num = (short)1833828473;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3433;
					}
					case 26:
						num = (short)1739981027;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
						goto IL_1D9B;
					case 28:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7MultiFunctionKnob o7MultiFunctionKnob;
						acpListField = o7MultiFunctionKnob.RadErgoControlO7MFKButtonPress_A42218;
						num = (short)226361429;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 29:
						if (secureWide != null)
						{
							num = (short)1350041623;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6199;
					case 30:
						goto IL_3525;
					case 31:
						goto IL_6199;
					case 32:
						goto IL_4369;
					case 33:
					{
						global::SpecialFeatures.Ucl.Contact.PhoneCallList phoneCallList;
						phoneCallList.CallListPhone.UclPhone_PhoneNumber_A00033Value = global::PreEmptive.SoS.Runtime.FixedLengthStream.b("ꃥ", a_);
						num = (short)375914662;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 34:
						if (acpRecordset != null)
						{
							num = (short)1363476617;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2F69;
					case 35:
					{
						global::Motorola.MackinawCPS.CoreFeatures.Switches.Switches switches = acpRecordset[0] as global::Motorola.MackinawCPS.CoreFeatures.Switches.Switches;
						num = (short)765198374;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 36:
						if (global::ConstraintHelper.UtilityMack.IsMobileOnly())
						{
							num = (short)37486840;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1135;
					case 37:
						if (feature3 != null)
						{
							num = (short)579797154;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5A0;
					case 38:
					{
						global::Motorola.MackinawCPS.CoreFeatures.Switches.Switches switches;
						if (switches.ConventionalSwitchTable.EmbeddedRecset != null)
						{
							num = (short)274464969;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6B69;
					}
					case 39:
					{
						if (num9 >= num7)
						{
							num = (short)72548435;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectModeBCOListInnerRecset directModeBCOListInnerRecset2;
						global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectModeBCOListInnerSection directModeBCOListInnerSection = (directModeBCOListInnerRecset2[num9] as global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectModeBCOListInner).DirectModeBCOListInnerSection;
						num = (short)289669337;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 40:
						try
						{
							num = (short)1046609921;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInner dekbuttonInner;
									if (dekbuttonInner.DEKButtonInnerSection.DEKButtonBCO_A21352.Value == directStatusBCOListInnerSection2.DEKDirectStatusBCO_A9196.Value)
									{
										num = (short)300351492;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
									switch (0)
									{
									case 0:
										goto IL_3223;
									}
									continue;
								case 2:
									goto IL_3311;
								case 3:
									num = (short)203292674;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInner dekbuttonInner;
									dekbuttonInner.DEKButtonInnerSection.DEKButtonIndex_A22570.SetValue(num3 + 1);
									num = (short)555089926;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1705246723;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInner dekbuttonInner = (global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInner)enumerator.Current;
									num = (short)708706304;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									goto IL_32B5;
								}
								IL_32BA:
								num = (short)1828257797;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_3223:
								goto IL_32BA;
							}
							IL_32B5:
							IL_3311:
							goto IL_3630;
						}
						finally
						{
							num = (short)954859521;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1963720706;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_3348;
									}
									continue;
								case 2:
									goto IL_3380;
								}
								IL_3348:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1821638656;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_3380:;
						}
						goto IL_3383;
					case 41:
					{
						global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectStatusBCOListInnerRecset directStatusBCOListInnerRecset2 = dekrecset[0][10219].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectStatusBCOListInnerRecset;
						num7 = directStatusBCOListInnerRecset2.Count;
						num5 = 0;
						num = (short)930087178;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 42:
						goto IL_455E;
					case 43:
						goto IL_2C8B;
					case 44:
						goto IL_23CA;
					case 45:
						if (conventionalSwitchTableInner.ConventionalSwitchTableInnerSection.SwitchConventionalSwitchTablePosition2Feature_A19656.Value == 42)
						{
							num = (short)716833002;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_91A;
					case 46:
						if (switches2.TrunkingSwitchTable.EmbeddedRecset.Count >= 3)
						{
							num = (short)1757675609;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3433;
					case 47:
						goto IL_5168;
					case 48:
						goto IL_70CF;
					case 49:
						goto IL_5AD3;
					case 50:
						goto IL_61EA;
					case 51:
						if (o7DataButtonInnerRecset != null)
						{
							num = (short)1245774035;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1AE4;
					case 52:
						goto IL_4933;
					case 53:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide radioErgonomicsWide;
						radioErgonomicsWide.Advanced.RadErgoWideAdvancedLogicalSwitch2_A7756.SetValue(0);
						num = (short)775815403;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 54:
						if (feature2.Count != 0)
						{
							num = (short)196345908;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6F7;
					case 55:
						if (dataProfilesRecset != null)
						{
							num = (short)745275599;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4A03;
					case 56:
						if (responseSelectorListInnerRecset != null)
						{
							num = (short)1078853719;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_36B1;
					case 57:
						goto IL_3653;
					case 58:
						goto IL_58C9;
					case 59:
					{
						global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectStatusBCOListInnerSection directStatusBCOListInnerSection;
						if (directStatusBCOListInnerSection.DEKDirectStatusBCO_A9196.Value != 0)
						{
							num = (short)305922212;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1842;
					}
					case 60:
						if (acpRecordset != null)
						{
							num = (short)660406272;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_40D4;
					case 61:
						goto IL_61EA;
					case 62:
					{
						global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitchTableInner trunkingSwitchTableInner;
						if (trunkingSwitchTableInner.TrunkingSwitchTableInnerSection.SwitchTrunkingSwitchTablePosition1Feature_A21004.Value == 42)
						{
							num = (short)1307639878;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3F4A;
					}
					case 63:
						signalIndependentProductIndependentNonProgrammableButtonListInnerSection = (signalIndependentProductIndependentNonProgrammableButtonListInnerRecset[34][10032] as global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInnerSection);
						num = (short)1463157000;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 64:
						try
						{
							num = (short)1627521025;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_4E97;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_4DE6;
									}
									continue;
								case 2:
									goto IL_4EF4;
								case 3:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInner dekbuttonInner2;
									global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectModeBCOListInnerSection directModeBCOListInnerSection2;
									if (dekbuttonInner2.DEKButtonInnerSection.DEKButtonBCO_A21352.Value == directModeBCOListInnerSection2.DEKDirectModeBCO_A8534.Value)
									{
										num = (short)975699972;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInner dekbuttonInner2;
									global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectModeBCOListInnerSection directModeBCOListInnerSection2;
									dekbuttonInner2.DEKButtonInnerSection.DEKZone_A22566.UIValue = directModeBCOListInnerSection2.DEKDirectModeZone_A8538.UIValue;
									dekbuttonInner2.DEKButtonInnerSection.DEKChannel_A22565.UIValue = directModeBCOListInnerSection2.DEKDirectModeChannel_A8535.UIValue;
									num = (short)966131712;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1751121926;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInner dekbuttonInner2 = (global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInner)enumerator.Current;
									num = (short)1155727363;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									num = (short)251133954;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_4E9C:
								num = (short)1826422789;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_4DE6:
								goto IL_4E9C;
							}
							IL_4E97:
							IL_4EF4:
							goto IL_47B7;
						}
						finally
						{
							num = (short)1546125312;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_4F2B;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)476971010;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_4F62;
								}
								IL_4F2B:
								if (enumerator == null)
								{
									break;
								}
								num = (short)510722049;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_4F62:;
						}
						goto IL_4F65;
					case 65:
						if (signalIndependentProductIndependentNonProgrammableButtonListInnerRecset.Count >= 36)
						{
							num = (short)960167999;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						signalIndependentProductIndependentNonProgrammableButtonListInnerRecset.AddRecord(signalIndependentProductIndependentNonProgrammableButtonListInnerRecset.CreateDefaultRecord());
						num = (short)756809855;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 66:
						if (signalIndependentProductIndependentNonProgrammableButtonListInnerSection != null)
						{
							num = (short)1876623610;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_58C9;
					case 67:
						try
						{
							num = (short)1014366212;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)768999432;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1267138560;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpBusinessLayer.FeatureNode featureNode2 = enumerator.Current;
									int num6;
									num6++;
									global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.BacklightColorsInner backlightColorsInner = featureNode2 as global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.BacklightColorsInner;
									num = (short)449314822;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
								{
									int num6;
									global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.BacklightColorsInner backlightColorsInner;
									backlightColorsInner.BacklightColorsInnerSection.DispMenuLabtoolColorText1_A7689.Value = global::CommonResources.AppResources.Color_Id + num6.ToString();
									num = (short)1447034885;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									num = (short)1349255175;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									switch (0)
									{
									case 0:
										goto IL_691A;
									}
									continue;
								case 6:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.BacklightColorsInner backlightColorsInner;
									if (backlightColorsInner != null)
									{
										num = (short)979238915;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 7:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.BacklightColorsInner backlightColorsInner;
									if (backlightColorsInner.BacklightColorsInnerSection.DispMenuLabtoolColorText1_A7689.Value.Length > 14)
									{
										num = (short)139001858;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 8:
									goto IL_6A4C;
								}
								IL_69A5:
								num = (short)1271857153;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_691A:
								goto IL_69A5;
							}
							IL_6A4C:
							goto IL_307D;
						}
						finally
						{
							num = (short)2055798785;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_6ABC;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_6A83;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)353173504;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_6A83:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1306066946;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_6ABC:;
						}
						goto IL_6ABF;
					case 68:
						goto IL_3E63;
					case 69:
						goto IL_3433;
					case 70:
						num = (short)1136263316;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 71:
						num = (short)2065432681;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 72:
						if (directStatusBCOListInnerSection2.DEKDirectStatusBCO_A9196.Value != 0)
						{
							num = (short)1161036019;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3630;
					case 73:
						signalIndependentProductIndependentNonProgrammableButtonListInnerSection.RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonBCO_A19777.SetValue(11);
						signalIndependentProductIndependentNonProgrammableButtonListInnerSection.RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonFeature_A19778.SetValue(216);
						num = (short)276430977;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 74:
						if (this.IsMobileModel)
						{
							num = (short)2118058010;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_455E;
					case 75:
						if (feature3.Count != 0)
						{
							num = (short)1726218338;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5A0;
					case 76:
						if (acpRecordset.Count != 0)
						{
							num = (short)1116799176;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_30E3;
					case 77:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide radioErgonomicsWide;
						radioErgonomicsWide.Advanced.RadErgoWideAdvancedLogicalSwitch2_A7756.SetValue(1);
						num = (short)1715273797;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 78:
						num = (short)93716737;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 79:
						goto IL_1336;
					case 80:
						if (acpRecordset != null)
						{
							num = (short)508821510;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3EFF;
					case 81:
						try
						{
							num = (short)1842413571;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)2050359298;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)56229888;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpBusinessLayer.FeatureNode featureNode3 = enumerator.Current;
									(((global::AcpCommonLib.IAcpFeatureNode)featureNode3)[10608] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection).CHO9DataButtonConvIndex_A41414.CalculateApplicability();
									(((global::AcpCommonLib.IAcpFeatureNode)featureNode3)[10608] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection).CHO9DataButtonConvIndex_A41414.CalculateValidity();
									(((global::AcpCommonLib.IAcpFeatureNode)featureNode3)[10608] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection).CHO9DataButtonTrkIndex_A41416.CalculateApplicability();
									(((global::AcpCommonLib.IAcpFeatureNode)featureNode3)[10608] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection).CHO9DataButtonTrkIndex_A41416.CalculateValidity();
									num = (short)1282670596;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									goto IL_50F5;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_5016;
									}
									continue;
								}
								IL_5018:
								num = (short)350814209;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_5016:
								goto IL_5018;
							}
							IL_50F5:
							goto IL_143C;
						}
						finally
						{
							num = (short)477298689;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)924319746;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_512D;
									}
									continue;
								case 2:
									goto IL_5165;
								}
								IL_512D:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1888419840;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_5165:;
						}
						goto Block_99;
					case 82:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide = feature4[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
						switches2 = (feature[0] as global::Motorola.MackinawCPS.CoreFeatures.Switches.Switches);
						global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide radioErgonomicsWide = feature5[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide;
						num = (short)145948926;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 83:
						goto IL_1135;
					case 84:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide2;
						if (radioWide2.Labtool.RadWideLabtoolMFKEmergencyAccess_A42216 != null)
						{
							num = (short)1367605485;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C85;
					}
					case 85:
						goto IL_3EB1;
					case 86:
					{
						global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitchTableInner trunkingSwitchTableInner;
						if (trunkingSwitchTableInner.TrunkingSwitchTableInnerSection.SwitchTrunkingSwitchTablePosition1Feature_A21004.Value == 38)
						{
							num = (short)104267947;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_275D;
					}
					case 87:
						enumerator = responseSelectorListInnerRecset.GetEnumerator();
						num = (short)268566786;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 88:
						goto IL_3B3C;
					case 89:
					{
						global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitchTableInner trunkingSwitchTableInner = switches2.TrunkingSwitchTable.EmbeddedRecset[2] as global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitchTableInner;
						num = (short)1786118206;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 90:
						if (acpRecordset.Count != 0)
						{
							num = (short)2031776;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6E4F;
					case 91:
						num = (short)1149894844;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 92:
						num = (short)1035993104;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 93:
						try
						{
							num = (short)500695043;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
								switch (num2)
								{
								case 0:
									num = (short)1364918273;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_3DF1;
								case 2:
									if (!enumerator.MoveNext())
									{
										num = (short)1833107456;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3D58;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_3BD4;
									}
									continue;
								case 4:
									try
									{
										num = (short)190906372;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												goto IL_3CE5;
											case 1:
												num = (short)234487808;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 3:
											{
												if (!enumerator2.MoveNext())
												{
													num = (short)939393025;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInnerSection frequencyOptionsInnerSection = (enumerator2.Current as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner).FrequencyOptionsInnerSection;
												frequencyOptionsInnerSection.CnvPerConventionalChannelOptionsTAPLFreq_A9264.SetValue(frequencyOptionsInnerSection.CnvPerConventionalChannelOptionsTAPLCode_A9261.Value);
												frequencyOptionsInnerSection.CnvPerConventionalChannelOptionsRxPLFreq_A8918.SetValue(frequencyOptionsInnerSection.CnvPerConventionalChannelOptionsRxPLCode_A8917.Value);
												frequencyOptionsInnerSection.CnvPerConventionalChannelOptionsTxPLFreq_A9419.SetValue(frequencyOptionsInnerSection.CnvPerConventionalChannelOptionsTxPLCode_A9418.Value);
												num = (short)291831810;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 4:
												switch (0)
												{
												case 0:
													goto IL_3C14;
												}
												continue;
											}
											IL_3C8B:
											num = (short)599719939;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_3C14:
											goto IL_3C8B;
										}
										IL_3CE5:
										break;
									}
									finally
									{
										num = (short)2013855746;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												goto IL_3D55;
											case 1:
												enumerator2.Dispose();
												num = (short)1970012160;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 2:
												switch (0)
												{
												case 0:
													goto IL_3D1C;
												}
												continue;
											}
											IL_3D1C:
											if (enumerator2 == null)
											{
												break;
											}
											num = (short)522715137;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_3D55:;
									}
									goto IL_3D58;
								}
								goto IL_3BD4;
								IL_3D58:
								enumerator2 = ((global::AcpBusinessLayer.Recordset)(enumerator.Current as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality).FrequencyOptions.EmbeddedRecset).GetEnumerator();
								num = (short)2102591492;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_3D97:
								num = (short)1311571970;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_3BD4:
								goto IL_3D97;
							}
							IL_3DF1:
							goto IL_6E4F;
						}
						finally
						{
							num = (short)385482754;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_3E60;
								case 1:
									enumerator.Dispose();
									num = (short)458817536;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_3E28;
									}
									continue;
								}
								IL_3E28:
								if (enumerator == null)
								{
									break;
								}
								num = (short)2067267585;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_3E60:;
						}
						goto IL_3E63;
					case 94:
						if (acpRecordset != null)
						{
							num = (short)1085210644;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6B69;
					case 95:
						try
						{
							num = (short)1644953604;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1698693123;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInner topFunctionProgrammableButtonListInner2 = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInner)enumerator.Current;
									num = (short)1056702465;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInner topFunctionProgrammableButtonListInner2;
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInnerSection consolidatedActionBCOListInnerSection;
									if (topFunctionProgrammableButtonListInner2.TopFunctionProgrammableButtonListInnerSection.CnvTopFunctionButtonBCO_A36628.Value == consolidatedActionBCOListInnerSection.RadErgoControlO9ACBCOListBco_A36666.Value)
									{
										num = (short)71303170;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInner topFunctionProgrammableButtonListInner2;
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInnerSection consolidatedActionBCOListInnerSection;
									topFunctionProgrammableButtonListInner2.TopFunctionProgrammableButtonListInnerSection.O9CHCnvTopFunctionButtonIndex_A36634.UIValue = consolidatedActionBCOListInnerSection.RadErgoControlO9ACBCOListIndex_A36668.UIValue;
									topFunctionProgrammableButtonListInner2.TopFunctionProgrammableButtonListInnerSection.O9CHTrkTopFunctionButtonIndex_A36639.SetValue(consolidatedActionBCOListInnerSection.RadErgoControlO9ACBCOListIndex_A36668.Value);
									num = (short)602734598;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									num = (short)187760645;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									switch (0)
									{
									case 0:
										goto IL_1902;
									}
									continue;
								case 5:
									goto IL_1A0B;
								case 6:
									goto IL_19ED;
								}
								IL_195E:
								num = (short)1301807104;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1902:
								goto IL_195E;
							}
							IL_19ED:
							IL_1A0B:
							goto IL_4CDF;
						}
						finally
						{
							num = (short)1672609792;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_1A43;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)1442971650;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_1A7C;
								}
								IL_1A43:
								if (enumerator == null)
								{
									break;
								}
								num = (short)405078017;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1A7C:;
						}
						goto IL_1A7F;
					case 96:
					{
						global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectModeBCOListInnerRecset directModeBCOListInnerRecset2 = dekrecset[0][10220].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectModeBCOListInnerRecset;
						num7 = directModeBCOListInnerRecset2.Count;
						num9 = 0;
						num = (short)114360428;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 97:
						goto IL_4094;
					case 98:
						enumerator = ((global::AcpBusinessLayer.Recordset)feature3).GetEnumerator();
						num = (short)1678508178;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 99:
						if (conventionalSwitchTableInner.ConventionalSwitchTableInnerSection.SwitchConventionalSwitchTablePosition1Feature_A19655.Value == 38)
						{
							num = (short)831586498;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_91A;
					case 100:
						goto IL_37C6;
					case 101:
						goto IL_6F7;
					case 102:
						if (feature2 != null)
						{
							num = (short)1002045595;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6F7;
					case 103:
						if (controlHeadO7Recset[0] != null)
						{
							num = (short)742391810;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3EB1;
					case 104:
					{
						int num8;
						if (num8 >= num7)
						{
							num = (short)2146959484;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInnerRecset consolidatedActionBCOListInnerRecset;
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInnerSection consolidatedActionBCOListInnerSection = (consolidatedActionBCOListInnerRecset[num8] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner).ConsolidatedActionBCOListInnerSection;
						enumerator = topFunctionProgrammableButtonListInnerRecset.GetEnumerator();
						num = (short)86442079;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 105:
						if (conventionalSwitchTableInner.ConventionalSwitchTableInnerSection.SwitchConventionalSwitchTablePosition3Feature_A19657.Value == 38)
						{
							num = (short)1809383550;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_455E;
					case 106:
					{
						global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectModeBCOListInnerRecset directModeBCOListInnerRecset;
						int count = directModeBCOListInnerRecset.Count;
						num10 = 0;
						num = (short)664600673;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 107:
						goto IL_1336;
					case 108:
						goto IL_2F2A;
					case 109:
						if (conventionalSwitchTableInner.ConventionalSwitchTableInnerSection.SwitchConventionalSwitchTablePosition3Feature_A19657.Value == 38)
						{
							num = (short)367132822;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_657C;
					case 110:
					{
						num = (short)364249088;
						short num11 = num;
						try
						{
							num = (short)268959744;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_1696;
									}
									continue;
								case 1:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInner dekbuttonInner3;
									global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectMessageListInnerSection directMessageListInnerSection;
									if (dekbuttonInner3.DEKButtonInnerSection.DEKButtonBCO_A21352.Value == directMessageListInnerSection.DEKDirectMessageBCO_A8506.Value)
									{
										num = (short)1833238533;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									num = (short)611123206;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1233059842;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInner dekbuttonInner3 = (global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInner)enumerator.Current;
									num = (short)1832714241;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									goto IL_175E;
								case 5:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInner dekbuttonInner3;
									dekbuttonInner3.DEKButtonInnerSection.DEKButtonIndex_A22570.SetValue(num4 + 1);
									num = (short)2067988484;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									goto IL_177B;
								}
								IL_16F3:
								num = (short)1318125571;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1696:
								goto IL_16F3;
							}
							IL_175E:
							IL_177B:
							goto IL_246D;
						}
						finally
						{
							num = (short)1561591808;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_17B2;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)1699020802;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_17EA;
								}
								IL_17B2:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1105657857;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_17EA:;
						}
						goto IL_17ED;
					}
					case 111:
						num = (short)1110442135;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 112:
						goto IL_5876;
					case 113:
						if (num12 >= acpRecordset.Count)
						{
							num = (short)1577779405;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_268A;
					case 114:
						goto IL_455E;
					case 115:
					{
						int count;
						if (num4 >= count)
						{
							num = (short)342818995;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectMessageListInnerRecset directMessageListInnerRecset;
						global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectMessageListInnerSection directMessageListInnerSection = (directMessageListInnerRecset[num4] as global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectMessageListInner).DirectMessageListInnerSection;
						num = (short)1162412306;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 116:
					{
						int num13;
						if (num13 >= keypadButtonInnerRecset.Count)
						{
							num = (short)920387595;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::AcpBusinessLayer.AcpListField radErgCtrlKeypadGeneralKeypadButtonFeature_A = (keypadButtonInnerRecset[num13] as global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInner).KeypadButtonInnerSection.RadErgCtrlKeypadGeneralKeypadButtonFeature_A41071;
						global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentProgrammableButtonListInnerRecset signalIndependentProductIndependentProgrammableButtonListInnerRecset;
						enumerator = signalIndependentProductIndependentProgrammableButtonListInnerRecset.GetEnumerator();
						num = (short)1561854070;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 117:
						num = (short)1517748308;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 118:
					{
						int num13;
						try
						{
							num = (short)1745879043;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_25FA;
								case 1:
								{
									global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentProgrammableButtonListInner signalIndependentProductIndependentProgrammableButtonListInner;
									if ((keypadButtonInnerRecset[num13] as global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInner).KeypadButtonInnerSection.RadErgCtrlKeypadGeneralKeypadBCO_A41070.Value == signalIndependentProductIndependentProgrammableButtonListInner.SignalIndependentProductIndependentProgrammableButtonListInnerSection.RadErgoCfgSignalIndependentProductIndependentProgrammableButtonBCO_A19757.Value)
									{
										num = (short)1565130758;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									goto IL_2617;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_251A;
									}
									continue;
								case 4:
									num = (short)2103246850;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)435945476;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentProgrammableButtonListInner signalIndependentProductIndependentProgrammableButtonListInner = (global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentProgrammableButtonListInner)enumerator.Current;
									num = (short)1959591937;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
								{
									global::AcpBusinessLayer.AcpListField radErgCtrlKeypadGeneralKeypadButtonFeature_A;
									global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentProgrammableButtonListInner signalIndependentProductIndependentProgrammableButtonListInner;
									radErgCtrlKeypadGeneralKeypadButtonFeature_A.SetValue(signalIndependentProductIndependentProgrammableButtonListInner.SignalIndependentProductIndependentProgrammableButtonListInnerSection.RadErgoCfgSignalIndependentProductIndependentProgrammableButtonFeature_A19758.Value);
									num = (short)94896128;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_258A:
								num = (short)180748293;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_251A:
								goto IL_258A;
							}
							IL_25FA:
							IL_2617:
							goto IL_1419;
						}
						finally
						{
							num = (short)72876032;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_2650;
									}
									continue;
								case 1:
									goto IL_2687;
								case 2:
									enumerator.Dispose();
									num = (short)1994063873;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_2650:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1486225410;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2687:;
						}
						goto IL_268A;
						IL_1419:
						num13++;
						num = (short)1349845165;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 119:
						goto IL_3383;
					case 120:
						goto IL_4054;
					case 121:
						num = (short)330957072;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 122:
						goto IL_4094;
					case 123:
						if ((dekrecset[0][10232] as global::Motorola.MackinawCPS.CoreFeatures.DEK.General).DEKNumberofDEKBoxes_A8579.Value > 0)
						{
							num = (short)1664221187;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_23CA;
					case 124:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.RelayPatternBCOListListInnerRecset relayPatternBCOListListInnerRecset = controlHeadO9Recset[0][10620].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.RelayPatternBCOListListInnerRecset;
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.DirectionalButtonsListInnerRecset directionalButtonsListInnerRecset = controlHeadO9Recset[0][10609].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.DirectionalButtonsListInnerRecset;
						num7 = relayPatternBCOListListInnerRecset.Count;
						int num14 = 0;
						num = (short)1194393700;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 125:
						if (shepherdsRecset != null)
						{
							num = (short)670105815;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_727B;
					case 126:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide radioErgonomicsWide;
						radioErgonomicsWide.Advanced.RadErgoWideAdvancedLogicalSwitch2_A7756.SetValue(2);
						num = (short)1948909682;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 127:
						goto IL_5A5F;
					case 128:
						num = (short)1563951326;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 129:
						goto IL_3899;
					case 130:
						if (acpRecordset.Count != 0)
						{
							num = (short)2143158296;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3EFF;
					case 131:
						try
						{
							num = (short)236453891;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
									trunkingSystem.General.TrkSysLabtoolNetworkID_A8565.SetValue((trunkingSystem.General.TrkSysGeneralSystemType_A9252.Value != 3) ? (((trunkingSystem.General.TrkSysGeneralSystemID_A9239.Value & 255) << 4) + trunkingSystem.General.TrkSysGeneralConnectToneHz_A7710.Value) : 0);
									num = (short)2062614530;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1545273349;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem = enumerator.Current as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem;
									num = (short)772472832;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									switch (0)
									{
									case 0:
										goto IL_6F70;
									}
									continue;
								case 4:
									goto IL_705C;
								case 5:
									num = (short)1850605572;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_6FE4:
								num = (short)537853953;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_6F70:
								goto IL_6FE4;
							}
							IL_705C:
							goto IL_3EFF;
						}
						finally
						{
							num = (short)1232732160;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_7095;
									}
									continue;
								case 1:
									goto IL_70CC;
								case 2:
									enumerator.Dispose();
									num = (short)1572012033;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_7095:
								if (enumerator == null)
								{
									break;
								}
								num = (short)651624450;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_70CC:;
						}
						goto Block_134;
					case 132:
						if (global::ConstraintHelper.UtilityMack.IsMobile())
						{
							num = (short)422641851;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_727B;
					case 133:
						num15 = 0;
						num = (short)1167655092;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 134:
						goto IL_557E;
					case 135:
						num12 = 0;
						num = (short)2016280606;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 136:
					{
						try
						{
							num = (short)867106817;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInnerSection consolidatedActionBCOListInnerSection;
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButtonInner bottomFunctionProgrammableButtonInner;
									bottomFunctionProgrammableButtonInner.BottomFunctionProgrammableButtonInnerSection.CHO9BottomFunctionButtonIndex_A36665.UIValue = consolidatedActionBCOListInnerSection.RadErgoControlO9ACBCOListIndex_A36668.UIValue;
									num = (short)1246298116;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									switch (0)
									{
									case 0:
										goto IL_45E6;
									}
									continue;
								case 2:
									goto IL_46D5;
								case 3:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)2117795846;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButtonInner bottomFunctionProgrammableButtonInner = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButtonInner)enumerator.Current;
									num = (short)684457989;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									goto IL_46B7;
								case 5:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInnerSection consolidatedActionBCOListInnerSection;
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButtonInner bottomFunctionProgrammableButtonInner;
									if (bottomFunctionProgrammableButtonInner.BottomFunctionProgrammableButtonInnerSection.CHO9BottomFunctionButtonBCO_A36660.Value == consolidatedActionBCOListInnerSection.RadErgoControlO9ACBCOListBco_A36666.Value)
									{
										num = (short)2144206848;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
									num = (short)1204682754;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_4644:
								num = (short)769523715;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_45E6:
								goto IL_4644;
							}
							IL_46B7:
							IL_46D5:
							goto IL_6559;
						}
						finally
						{
							num = (short)1276444674;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)2112684033;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_4745;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_470D;
									}
									continue;
								}
								IL_470D:
								if (enumerator == null)
								{
									break;
								}
								num = (short)633602048;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_4745:;
						}
						goto IL_4748;
						IL_6559:
						int num8;
						num8++;
						num = (short)1136525432;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 137:
						num = (short)652476622;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 138:
					{
						int count;
						if (num10 >= count)
						{
							num = (short)1644167212;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectModeBCOListInnerRecset directModeBCOListInnerRecset;
						global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectModeBCOListInnerSection directModeBCOListInnerSection2 = (directModeBCOListInnerRecset[num10] as global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectModeBCOListInner).DirectModeBCOListInnerSection;
						num = (short)725090471;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 139:
						acpListField2 = o2MultiFunctionKnob.RadErgoControlO2MFKButtonPress_A42217;
						num = (short)660996357;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 140:
						goto IL_C85;
					case 141:
						try
						{
							num = (short)1723531266;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 1:
									goto IL_5803;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_568E;
									}
									continue;
								case 3:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)389611530;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem = (global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem)enumerator.Current;
									num = (short)1843855368;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem;
									conventionalSystem.Features.CnvSysFeaturesEmergencyAckEn_A41546.SetValue(true);
									num = (short)1584005124;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem;
									if (conventionalSystem.Features.CnvSysFeaturesExtendedDispatchEn_A37220.Value)
									{
										num = (short)1311703046;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									conventionalSystem.Features.CnvSysFeaturesEmergencyAckEn_A41546.SetValue(false);
									num = (short)902168576;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
								{
									if (radInfoLabtoolExtendedDispatch_A38638Value)
									{
										num = (short)569245705;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem;
									conventionalSystem.Features.CnvSysFeaturesEmergencyAckEn_A41546.SetValue(false);
									num = (short)559218693;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 9:
									num = (short)373817351;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
									num = (short)1483866113;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_5690:
								num = (short)2106327043;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_568E:
								goto IL_5690;
							}
							IL_5803:
							goto IL_63B6;
						}
						finally
						{
							num = (short)379977728;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_583B;
									}
									continue;
								case 1:
									goto IL_5873;
								case 2:
									enumerator.Dispose();
									num = (short)2009137153;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_583B:
								if (enumerator == null)
								{
									break;
								}
								num = (short)362676226;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_5873:;
						}
						goto IL_5876;
					case 142:
						if (this.IsMobileModel)
						{
							num = (short)2049245407;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3433;
					case 143:
						if (conventionalSwitchTableInner.ConventionalSwitchTableInnerSection.SwitchConventionalSwitchTablePosition2Feature_A19656.Value == 38)
						{
							num = (short)1588789316;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_657C;
					case 144:
						signalIndependentProductIndependentNonProgrammableButtonListInnerRecset = (shepherdsRecset[0][10031].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInnerRecset);
						num = (short)1484914881;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 145:
						try
						{
							num = (short)1553793029;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_B25;
								case 1:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.DirectionalButtonsListInner directionalButtonsListInner;
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.RelayPatternBCOListListInnerSection relayPatternBCOListListInnerSection;
									if (directionalButtonsListInner.DirectionalButtonsListInnerSection.RadErgCtrlHeadO9DirLightBarBCO_A36559.Value == relayPatternBCOListListInnerSection.RdEgoO9DirLtbarPatternBcoListBco_A36661.Value)
									{
										num = (short)1652359170;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.DirectionalButtonsListInner directionalButtonsListInner;
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.RelayPatternBCOListListInnerSection relayPatternBCOListListInnerSection;
									directionalButtonsListInner.DirectionalButtonsListInnerSection.RadErgCtrlHeadO9DirLightBarIndex_A36601.UIValue = relayPatternBCOListListInnerSection.RdEgoO9DirLtbarPatternBcoListIndex_A36707.UIValue;
									num = (short)699138048;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1726611462;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.DirectionalButtonsListInner directionalButtonsListInner = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.DirectionalButtonsListInner)enumerator.Current;
									num = (short)1718681601;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									goto IL_BEA;
								case 5:
									switch (0)
									{
									case 0:
										goto IL_AED;
									}
									continue;
								case 6:
									num = (short)807731204;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_B90:
								num = (short)1894449155;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_AED:
								goto IL_B90;
							}
							IL_B25:
							IL_BEA:
							goto IL_237D;
						}
						finally
						{
							num = (short)783089665;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1458372610;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_C23;
									}
									continue;
								case 2:
									goto IL_C5B;
								}
								IL_C23:
								if (enumerator == null)
								{
									break;
								}
								num = (short)439091200;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_C5B:
							num = (short)1961361409;
							if (num != 0)
							{
							}
						}
						goto IL_C85;
					case 146:
						try
						{
							num = (short)506724354;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1056833537;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.MissionCriticalGeofence missionCriticalGeofence = enumerator.Current as global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.MissionCriticalGeofence;
									num = (short)238682117;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									num = (short)988741635;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_2221;
									}
									continue;
								case 3:
									goto IL_2308;
								case 4:
								{
									global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.MissionCriticalGeofence missionCriticalGeofence;
									missionCriticalGeofence.General.McGeofencePriority_42879.CalculateApplicability();
									missionCriticalGeofence.General.McGeofencePriority_42879.CalculateValidity();
									num = (short)1650851846;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
								{
									global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.MissionCriticalGeofence missionCriticalGeofence;
									if (missionCriticalGeofence.General.McGeofencePriority_42879.Valid)
									{
										num = (short)49807364;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_22AF:
								num = (short)1134624768;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2221:
								goto IL_22AF;
							}
							IL_2308:
							goto IL_5A0;
						}
						finally
						{
							num = (short)2102984704;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_2340;
									}
									continue;
								case 1:
									goto IL_237A;
								case 2:
									enumerator.Dispose();
									num = (short)784465921;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_2340:
								if (enumerator == null)
								{
									break;
								}
								num = (short)591724546;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_237A:;
						}
						goto IL_237D;
					case 147:
						goto IL_455E;
					case 148:
					{
						global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitchTableInner trunkingSwitchTableInner;
						if (trunkingSwitchTableInner.TrunkingSwitchTableInnerSection.SwitchTrunkingSwitchTablePosition2Feature_A21005.Value == 38)
						{
							num = (short)77725807;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3F4A;
					}
					case 149:
						if (global::ConstraintHelper.UtilityMack.IsMobileOnly())
						{
							num = (short)561053885;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3833;
					case 150:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide radioErgonomicsWide;
						radioErgonomicsWide.Advanced.RadErgoWideAdvancedLogicalSwitch2_A7756.SetValue(0);
						num = (short)91947050;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 151:
					{
						global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitchTableInner trunkingSwitchTableInner;
						if (trunkingSwitchTableInner.TrunkingSwitchTableInnerSection.SwitchTrunkingSwitchTablePosition3Feature_A21006.Value == 38)
						{
							num = (short)1320878133;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3F4A;
					}
					case 152:
						if (conventionalSwitchTableInner.ConventionalSwitchTableInnerSection.SwitchConventionalSwitchTablePosition2Feature_A19656.Value == 38)
						{
							num = (short)215547975;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_455E;
					case 153:
					{
						global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide secureWide2 = acpRecordset[0] as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide;
						num = (short)397607104;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 154:
						if (o2MultiFunctionKnob != null)
						{
							num = (short)632225931;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6BCC;
					case 155:
						num = (short)850591798;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 156:
					{
						try
						{
							num = (short)1575485441;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)425263109;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInner keypadButtonInner = (global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInner)enumerator.Current;
									num = (short)1840578564;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									switch (0)
									{
									case 0:
										goto IL_766;
									}
									continue;
								case 2:
									goto IL_85B;
								case 3:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.RelayPatternBCOListListInnerSection relayPatternBCOListListInnerSection;
									global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInner keypadButtonInner;
									keypadButtonInner.KeypadButtonInnerSection.RadErgCtrlKeypadGeneralKeypadButtonIndex_41415.UIValue = relayPatternBCOListListInnerSection.RdEgoO9DirLtbarPatternBcoListIndex_A36707.UIValue;
									num = (short)1709047814;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.RelayPatternBCOListListInnerSection relayPatternBCOListListInnerSection;
									global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInner keypadButtonInner;
									if (keypadButtonInner.KeypadButtonInnerSection.RadErgCtrlKeypadGeneralKeypadBCO_A41070.Value == relayPatternBCOListListInnerSection.RdEgoO9DirLtbarPatternBcoListBco_A36661.Value)
									{
										num = (short)1610022915;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
									num = (short)1286537218;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									goto IL_7D8;
								}
								IL_768:
								num = (short)602472448;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_766:
								goto IL_768;
							}
							IL_7D8:
							IL_85B:
							goto IL_12E2;
						}
						finally
						{
							num = (short)1703937;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1537540098;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_892;
									}
									continue;
								case 2:
									goto IL_8CC;
								}
								IL_892:
								if (enumerator == null)
								{
									break;
								}
								num = (short)699006976;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_8CC:;
						}
						goto IL_8CF;
						IL_12E2:
						int num14;
						num14++;
						num = (short)294191351;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 157:
						try
						{
							num = (short)904134664;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 1:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1467482122;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInnerSection encryptionKeyListInnerSection = (enumerator.Current as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInner).EncryptionKeyListInnerSection;
									num = (short)522649602;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
								{
									int num16;
									if (num16 < 15)
									{
										num = (short)777846787;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInnerSection encryptionKeyListInnerSection;
									encryptionKeyListInnerSection.SecWideMultikeyListSlotA_A9155.SetValue(1);
									encryptionKeyListInnerSection.SecWideMultikeyListSlotB_A9158.SetValue(1);
									num = (short)1429995520;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									num = (short)990838791;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									goto IL_2C16;
								case 5:
								{
									global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInnerSection encryptionKeyListInnerSection;
									int num16;
									encryptionKeyListInnerSection.SecWideMultikeyListSlotA_A9155.SetValue(++num16);
									encryptionKeyListInnerSection.SecWideMultikeyListSlotB_A9158.SetValue(++num16);
									num = (short)351600649;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
								{
									global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInnerSection encryptionKeyListInnerSection;
									if (encryptionKeyListInnerSection.SecWideMultikeyListIndexed_A8282.Value)
									{
										num = (short)1758265349;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									int num16;
									num16++;
									encryptionKeyListInnerSection.SecWideMultikeyListSlotA_A9155.SetValue(num16);
									encryptionKeyListInnerSection.SecWideMultikeyListSlotB_A9158.SetValue(num16);
									num = (short)1767768070;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
									switch (0)
									{
									case 0:
										goto IL_2A6B;
									}
									continue;
								case 10:
									num = (short)1390477316;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_2B6C:
								num = (short)1539047425;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2A6B:
								goto IL_2B6C;
							}
							IL_2C16:
							goto IL_5B17;
						}
						finally
						{
							num = (short)1925185537;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)144572418;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_2C4F;
									}
									continue;
								case 2:
									goto IL_2C88;
								}
								IL_2C4F:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1445265408;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2C88:;
						}
						goto Block_45;
					case 158:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerRecset dataButtonInnerRecset2;
						enumerator = dataButtonInnerRecset2.GetEnumerator();
						num = (short)7405575;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 159:
						goto IL_17ED;
					case 160:
						goto IL_6046;
					case 161:
						if (conventionalPersonalityRecset != null)
						{
							num = (short)1997013230;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5955;
					case 162:
						num = (short)1442512971;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 163:
					{
						global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentProgrammableButtonListInnerRecset signalIndependentProductIndependentProgrammableButtonListInnerRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2013) as global::Motorola.MackinawCPS.CoreFeatures.Shepherds.ShepherdsRecset)[0][10029].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentProgrammableButtonListInnerRecset;
						int num13 = 0;
						num = (short)337379462;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 164:
						enumerator = topFunctionProgrammableButtonListInnerRecset.GetEnumerator();
						num = (short)1876688905;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 165:
						goto IL_3525;
					case 166:
						goto IL_57D;
					case 167:
					{
						global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectModeBCOListInnerSection directModeBCOListInnerSection2;
						if (directModeBCOListInnerSection2.DEKDirectModeBCO_A8534.Value != 0)
						{
							num = (short)219021553;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_47B7;
					}
					case 168:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemRecset conventionalSystemRecset;
						enumerator = conventionalSystemRecset.GetEnumerator();
						num = (short)1918042253;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 169:
						if (acpRecordset != null)
						{
							num = (short)1692336263;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_30E3;
					case 170:
						num = (short)2141650949;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 171:
						num = (short)1973092360;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 172:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7MultiFunctionKnob o7MultiFunctionKnob;
						if (o7MultiFunctionKnob != null)
						{
							num = (short)1742995484;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3EB1;
					}
					case 173:
						goto IL_557E;
					case 174:
						if (acpRecordset != null)
						{
							num = (short)1767964855;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5B17;
					case 175:
						goto IL_2F2A;
					case 176:
						goto IL_4054;
					case 177:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide2;
						if (radioWide2 != null)
						{
							num = (short)1427636341;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C85;
					}
					case 178:
					{
						try
						{
							num = (short)1592983557;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
								global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInnerRecset consolidatedActionsInnerRecset;
								global::AcpBusinessLayer.AcpFieldX<bool, string> radioErgoConfigACGeneralActionAllowed_A;
								bool flag2;
								int num17;
								global::AcpBusinessLayer.FeatureNode featureNode4;
								switch (num2)
								{
								case 0:
									if (consolidatedActionsInnerRecset.Count != 0)
									{
										num = (short)145817601;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									(consolidatedActionsInnerRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidation).General.RadioErgoConfigACGeneralActionAllowed_A36579.Value = true;
									num = (short)903479304;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									num = (short)1978793986;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									if (consolidatedActionsInnerRecset.ParentSection != null)
									{
										num = (short)1639383050;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 3:
									try
									{
										num = (short)1938358272;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												switch (0)
												{
												case 0:
													goto IL_5D14;
												}
												continue;
											case 1:
												goto IL_5E68;
											case 2:
												num = (short)1051066369;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 3:
												radioErgoConfigACGeneralActionAllowed_A.Value = false;
												flag2 = true;
												num = (short)572456968;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 5:
											{
												if (!enumerator2.MoveNext())
												{
													num = (short)633012226;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator2.Current;
												num = (short)810942473;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 6:
											{
												global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
												if ((acpFeatureNode[10614] as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInnerSection).RadioErgoConfigACActionID_A36590.Value == 75)
												{
													num = (short)586285063;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 7:
												num17++;
												num = (short)1092354052;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 8:
												goto IL_5DEB;
											case 9:
											{
												global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
												if ((acpFeatureNode[10614] as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInnerSection).RadioErgoConfigACActionID_A36590.Value == 74)
												{
													num = (short)122159107;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												num = (short)541655046;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											}
											IL_5D16:
											num = (short)205783045;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_5D14:
											goto IL_5D16;
										}
										IL_5DEB:
										IL_5E68:
										goto IL_5C5A;
									}
									finally
									{
										num = (short)60358658;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												enumerator2.Dispose();
												num = (short)325189633;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 1:
												goto IL_5ED7;
											case 2:
												switch (0)
												{
												case 0:
													goto IL_5EA0;
												}
												continue;
											}
											IL_5EA0:
											if (enumerator2 == null)
											{
												break;
											}
											num = (short)913506304;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_5ED7:;
									}
									goto IL_5EDA;
									IL_5C5A:
									num = (short)1583349773;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									num = (short)1820327943;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									switch (0)
									{
									case 0:
										goto IL_5BB7;
									}
									continue;
								case 7:
									goto IL_5FD4;
								case 9:
									if (!enumerator.MoveNext())
									{
										num = (short)115474436;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									featureNode4 = enumerator.Current;
									consolidatedActionsInnerRecset = (((global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidation)featureNode4).General.EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInnerRecset);
									num = (short)454688768;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
									goto IL_5EDA;
								case 11:
									radioErgoConfigACGeneralActionAllowed_A.Value = true;
									num = (short)436338700;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 13:
									if (!flag2 & num17 <= 1)
									{
										num = (short)2137063435;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									radioErgoConfigACGeneralActionAllowed_A.Value = false;
									num = (short)1664679942;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_5BB7;
								IL_5EDA:
								radioErgoConfigACGeneralActionAllowed_A = ((global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidation)featureNode4).General.RadioErgoConfigACGeneralActionAllowed_A36579;
								flag2 = false;
								num17 = 0;
								enumerator2 = consolidatedActionsInnerRecset.GetEnumerator();
								num = (short)1365442563;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_5F1A:
								num = (short)1705508873;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_5BB7:
								goto IL_5F1A;
							}
							IL_5FD4:
							goto IL_6071;
						}
						finally
						{
							num = (short)1454374914;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)67371009;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_6043;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_600B;
									}
									continue;
								}
								IL_600B:
								if (enumerator == null)
								{
									break;
								}
								num = (short)724500480;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_6043:;
						}
						goto IL_6046;
						IL_6071:
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerRecset dataButtonInnerRecset2 = (global::AcpCommonLib.FeatureManager.GetFeature(2127) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.ControlHeadO3Recset)[0][10234].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerRecset;
						num = (short)923009223;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 179:
					{
						int count = directStatusBCOListInnerRecset.Count;
						num3 = 0;
						num = (short)916324413;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 180:
						goto IL_5AD3;
					case 181:
						num = (short)2019491983;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 182:
					{
						global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInnerRecset dekbuttonInnerRecset;
						enumerator = dekbuttonInnerRecset.GetEnumerator();
						num = (short)478675054;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 183:
						num = (short)1381236944;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 184:
						goto IL_58C9;
					case 185:
						goto IL_2FB2;
					case 186:
						num = (short)1531052276;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 187:
					{
						bool flag = false;
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide2 = global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
						num = (short)1681981617;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 188:
						goto IL_5A5F;
					case 189:
						enumerator = (global::AcpCommonLib.FeatureManager.GetFeature(4008) as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationRecset).GetEnumerator();
						num = (short)13631666;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 190:
						enumerator = signalIndependentProductIndependentNonProgrammableButtonListInnerRecset.GetEnumerator();
						num = (short)800981039;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 191:
					{
						if (num5 >= num7)
						{
							num = (short)1475805206;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectStatusBCOListInnerRecset directStatusBCOListInnerRecset2;
						global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectStatusBCOListInnerSection directStatusBCOListInnerSection = (directStatusBCOListInnerRecset2[num5] as global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectStatusBCOListInner).DirectStatusBCOListInnerSection;
						num = (short)1459552315;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 192:
					{
						global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide secureWide2;
						if (secureWide2.EncryptionKeyList.EmbeddedRecset != null)
						{
							num = (short)142606588;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5B17;
					}
					case 193:
						if (signalIndependentProductIndependentNonProgrammableButtonListInnerRecset != null)
						{
							num = (short)1572798552;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_727B;
					case 194:
						num = (short)628424749;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 195:
						goto IL_4748;
					case 196:
						if (acpRecordset.Count != 0)
						{
							num = (short)1604518159;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_40D4;
					case 197:
						num = (short)90701828;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 198:
						signalIndependentProductIndependentNonProgrammableButtonListInnerSection.RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonFeature_A19778.SetValue(31);
						num = (short)1109196984;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 199:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerRecset dataButtonInnerRecset2;
						if (dataButtonInnerRecset2 != null)
						{
							num = (short)790626462;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2E1E;
					}
					case 200:
						num = (short)1319895209;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 201:
					{
						global::Motorola.MackinawCPS.CoreFeatures.Switches.Switches switches;
						global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitchTableInner conventionalSwitchTableInner2 = switches.ConventionalSwitchTable.EmbeddedRecset[0] as global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitchTableInner;
						switches.ConventionalSwitches.SwitchConventionalSwitchesPosition1_A7734.SetValue(conventionalSwitchTableInner2.ConventionalSwitchTableInnerSection.SwitchConventionalSwitchTablePosition1Feature_A19655.Value);
						switches.ConventionalSwitches.SwitchConventionalSwitchesPosition2_A7735.SetValue(conventionalSwitchTableInner2.ConventionalSwitchTableInnerSection.SwitchConventionalSwitchTablePosition2Feature_A19656.Value);
						conventionalSwitchTableInner2 = (switches.ConventionalSwitchTable.EmbeddedRecset[3] as global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitchTableInner);
						switches.ConventionalSwitches.SwitchConventionalSwitchesPosition3_A7737.SetValue(conventionalSwitchTableInner2.ConventionalSwitchTableInnerSection.SwitchConventionalSwitchTablePosition1Feature_A19655.Value);
						switches.ConventionalSwitches.SwitchConventionalSwitchesPosition4_A21530.SetValue(conventionalSwitchTableInner2.ConventionalSwitchTableInnerSection.SwitchConventionalSwitchTablePosition2Feature_A19656.Value);
						switches.ConventionalSwitches.SwitchConventionalSwitchesPosition5_A21531.SetValue(conventionalSwitchTableInner2.ConventionalSwitchTableInnerSection.SwitchConventionalSwitchTablePosition3Feature_A19657.Value);
						global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitchTableInner trunkingSwitchTableInner2 = switches.TrunkingSwitchTable.EmbeddedRecset[0] as global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitchTableInner;
						switches.TrunkingSwitches.SwitchTrunkingSwitchesPosition1_A9466.SetValue(trunkingSwitchTableInner2.TrunkingSwitchTableInnerSection.SwitchTrunkingSwitchTablePosition1Feature_A21004.Value);
						switches.TrunkingSwitches.SwitchTrunkingSwitchesPosition2_A9467.SetValue(trunkingSwitchTableInner2.TrunkingSwitchTableInnerSection.SwitchTrunkingSwitchTablePosition2Feature_A21005.Value);
						trunkingSwitchTableInner2 = (switches.TrunkingSwitchTable.EmbeddedRecset[3] as global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitchTableInner);
						switches.TrunkingSwitches.SwitchTrunkingSwitchesPosition3_A9468.SetValue(trunkingSwitchTableInner2.TrunkingSwitchTableInnerSection.SwitchTrunkingSwitchTablePosition1Feature_A21004.Value);
						switches.TrunkingSwitches.SwitchTrunkingSwitchesPosition4_A21534.SetValue(trunkingSwitchTableInner2.TrunkingSwitchTableInnerSection.SwitchTrunkingSwitchTablePosition2Feature_A21005.Value);
						switches.TrunkingSwitches.SwitchTrunkingSwitchesPosition5_A21535.SetValue(trunkingSwitchTableInner2.TrunkingSwitchTableInnerSection.SwitchTrunkingSwitchTablePosition3Feature_A21006.Value);
						num = (short)1863778579;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 202:
						if (codeplugMainVersion < 9)
						{
							num = (short)1559363796;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4A03;
					case 203:
						goto IL_3653;
					case 204:
					{
						if (num15 >= recordset.Count)
						{
							num = (short)685113529;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::SpecialFeatures.Ucl.Contact.PhoneCallList phoneCallList = recordset[num15] as global::SpecialFeatures.Ucl.Contact.PhoneCallList;
						num = (short)1788542994;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 205:
						goto IL_30E3;
					case 206:
						if (acpRecordset.Count != 0)
						{
							num = (short)167837859;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2F69;
					case 207:
						num = (short)770310346;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 208:
						if (acpRecordset.Count != 0)
						{
							num = (short)444596377;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5B17;
					case 209:
						if (this.IsMobileModel)
						{
							num = (short)211550290;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3433;
					case 210:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide radioErgonomicsWide;
						radioErgonomicsWide.Advanced.RadErgoWideAdvancedLogicalSwitch2_A7756.SetValue(2);
						num = (short)1042743315;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 211:
						enumerator = o7DataButtonInnerRecset.GetEnumerator();
						num = (short)3014925;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 212:
						enumerator = dataProfilesRecset.GetEnumerator();
						num = (short)857997333;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 213:
						if (signalIndependentProductIndependentNonProgrammableButtonListInnerRecset.Count < 36)
						{
							num = (short)1982136411;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_58C9;
					case 214:
						if (acpRecordset != null)
						{
							num = (short)2005205084;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6199;
					case 215:
						num = (short)1289224206;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 216:
						enumerator = topFunctionProgrammableButtonListInnerRecset.GetEnumerator();
						num = (short)635830320;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 217:
					{
						global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectModeBCOListInnerSection directModeBCOListInnerSection;
						if (directModeBCOListInnerSection.DEKDirectModeBCO_A8534.Value != 0)
						{
							num = (short)1089011824;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_611B;
					}
					case 218:
						num = (short)1800667288;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 219:
					{
						global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.DisplayAndMenu displayAndMenu;
						if (displayAndMenu != null)
						{
							num = (short)1795620874;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_307D;
					}
					case 220:
						goto IL_1FC5;
					case 221:
						if (acpRecordset.Count != 0)
						{
							num = (short)1425473801;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6B69;
					case 222:
						if (recordset != null)
						{
							num = (short)1708195973;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2FB2;
					case 223:
						num = (short)1190985774;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 224:
						if (switches2.TrunkingSwitchTable.EmbeddedRecset != null)
						{
							num = (short)607387908;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3433;
					case 225:
						if (this.IsPortableModel)
						{
							num = (short)1739522083;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6B69;
					case 226:
					{
						global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.DisplayAndMenu displayAndMenu = global::AcpCommonLib.FeatureManager.GetFeature(2010)[0] as global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.DisplayAndMenu;
						num = (short)531628251;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 227:
						if (switches2.TrunkingSwitchTable.EmbeddedRecset.Count >= 3)
						{
							num = (short)657522908;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_455E;
					case 228:
						try
						{
							num = (short)1927675904;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_6CC9;
									}
									continue;
								case 1:
									goto IL_6D58;
								case 2:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)2097807366;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInner topFunctionProgrammableButtonListInner3 = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInner)enumerator.Current;
									num = (short)2072903683;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.RelayPatternBCOListListInnerSection relayPatternBCOListListInnerSection;
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInner topFunctionProgrammableButtonListInner3;
									if (topFunctionProgrammableButtonListInner3.TopFunctionProgrammableButtonListInnerSection.CnvTopFunctionButtonBCO_A36628.Value == relayPatternBCOListListInnerSection.RdEgoO9DirLtbarPatternBcoListBco_A36661.Value)
									{
										num = (short)34996228;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.RelayPatternBCOListListInnerSection relayPatternBCOListListInnerSection;
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInner topFunctionProgrammableButtonListInner3;
									topFunctionProgrammableButtonListInner3.TopFunctionProgrammableButtonListInnerSection.O9CHCnvTopFunctionButtonIndex_A36634.UIValue = relayPatternBCOListListInnerSection.RdEgoO9DirLtbarPatternBcoListIndex_A36707.UIValue;
									topFunctionProgrammableButtonListInner3.TopFunctionProgrammableButtonListInnerSection.O9CHTrkTopFunctionButtonIndex_A36639.SetValue(relayPatternBCOListListInnerSection.RdEgoO9DirLtbarPatternBcoListIndex_A36707.Value);
									num = (short)514719745;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									goto IL_6DDC;
								case 6:
									num = (short)1579352069;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_6CCB:
								num = (short)1469579266;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_6CC9:
								goto IL_6CCB;
							}
							IL_6D58:
							IL_6DDC:
							goto IL_5EB;
						}
						finally
						{
							num = (short)120520705;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)722665474;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_6E13;
									}
									continue;
								case 2:
									goto IL_6E4C;
								}
								IL_6E13:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1247936512;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_6E4C:;
						}
						goto IL_6E4F;
						IL_5EB:
						enumerator = bottomFunctionProgrammableButtonInnerRecset.GetEnumerator();
						num = (short)148111627;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 229:
					{
						conventionalSwitchTableInner = (switches2.ConventionalSwitchTable.EmbeddedRecset[0] as global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitchTableInner);
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
						radioWide.Features.SwitchConventionalSwitchesPosition1_A12643.SetValue(conventionalSwitchTableInner.ConventionalSwitchTableInnerSection.SwitchConventionalSwitchTablePosition1Feature_A19655.Value);
						num = (short)1253769290;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 230:
						if (dataButtonInnerRecset3 != null)
						{
							num = (short)1305542683;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3833;
					case 231:
					{
						bool flag;
						if (flag)
						{
							num = (short)1429536958;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_727B;
					}
					case 232:
						goto IL_E6B;
					case 233:
						if (acpRecordset != null)
						{
							num = (short)535626004;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6E4F;
					case 234:
						num = (short)564068607;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 235:
						goto IL_3433;
					case 236:
						try
						{
							num = (short)322043905;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1414594564;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile = (global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile)enumerator.Current;
									num = (short)1081671682;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									switch (0)
									{
									case 0:
										goto IL_4414;
									}
									continue;
								case 2:
								{
									global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile;
									if (!secureKMFProfile.General.SecKmfProfGenIndependentKeyList_43597.Value)
									{
										num = (short)453443587;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
								{
									global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile;
									value = secureKMFProfile.ASTROOTARInformation.SecKmfProfASTROOTARInformationIndividualASTROOTARRadioID_A8285.Value;
									num = (short)1065222150;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									num = (short)2043478021;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									goto IL_44E9;
								case 6:
									goto IL_44CC;
								}
								IL_4465:
								num = (short)1330642944;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_4414:
								goto IL_4465;
							}
							IL_44CC:
							IL_44E9:
							goto IL_1A7F;
						}
						finally
						{
							num = (short)1337327617;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_455B;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_4522;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)1155989504;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_4522:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1943207938;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_455B:;
						}
						goto IL_455E;
					case 237:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide2;
						bool flag = radioWide2.Labtool.RadWideLabtoolMFKEmergencyAccess_A42216.Value;
						num = (short)1933443212;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 238:
						goto IL_4F65;
					case 239:
						if (conventionalSwitchTableInner.ConventionalSwitchTableInnerSection.SwitchConventionalSwitchTablePosition1Feature_A19655.Value == 38)
						{
							num = (short)713687258;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_455E;
					case 240:
					{
						int num14;
						if (num14 >= num7)
						{
							num = (short)176554080;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.RelayPatternBCOListListInnerRecset relayPatternBCOListListInnerRecset;
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.RelayPatternBCOListListInnerSection relayPatternBCOListListInnerSection = (relayPatternBCOListListInnerRecset[num14] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.RelayPatternBCOListListInner).RelayPatternBCOListListInnerSection;
						enumerator = topFunctionProgrammableButtonListInnerRecset.GetEnumerator();
						num = (short)1419444452;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 241:
					{
						global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInnerRecset dekbuttonInnerRecset;
						enumerator = dekbuttonInnerRecset.GetEnumerator();
						num = (short)932642880;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 242:
						if (controlHeadO7Recset != null)
						{
							num = (short)1707409603;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3EB1;
					case 243:
					{
						global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInnerRecset dekbuttonInnerRecset;
						enumerator = dekbuttonInnerRecset.GetEnumerator();
						num = (short)204865576;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 244:
						if (controlHeadO2Recset[0] != null)
						{
							num = (short)1201471647;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6BCC;
					case 245:
						try
						{
							num = (short)269484037;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)1312423937;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
									if (conventionalPersonality.Secure.CnvPerSecureOTARTx_A8675.Value)
									{
										num = (short)1660223498;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
									if (conventionalPersonality.Secure.CnvPerSecureOTARTx_A8675.HiddenStatic)
									{
										num = (short)838139904;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1940062214;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality = enumerator.Current as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality;
									num = (short)538050567;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									goto IL_42F4;
								case 5:
									switch (0)
									{
									case 0:
										goto IL_4197;
									}
									continue;
								case 6:
									num = (short)235470852;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
									if (conventionalPersonality != null)
									{
										num = (short)1870200841;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 9:
									num = (short)1227161602;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
									conventionalPersonality.Secure.CnvPerSecureOTARTx_A8675.SetValue(false);
									num = (short)1844641800;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_429B:
								num = (short)36503555;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_4197:
								goto IL_429B;
							}
							IL_42F4:
							goto IL_5955;
						}
						finally
						{
							num = (short)752091136;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_432B;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)1790246914;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_4366;
								}
								IL_432B:
								if (enumerator == null)
								{
									break;
								}
								num = (short)655556609;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_4366:;
						}
						goto IL_4369;
					case 246:
					{
						if (num18 >= num7)
						{
							num = (short)709885993;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectMessageListInnerSection directMessageListInnerSection2 = (directMessageListInnerRecset2[num18] as global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectMessageListInner).DirectMessageListInnerSection;
						num = (short)2078408960;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 247:
						goto IL_37C6;
					case 248:
						dekrecset = (global::AcpCommonLib.FeatureManager.GetFeature(2129) as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKRecset);
						num = (short)374800507;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 249:
						if (recordset.Count != 0)
						{
							num = (short)45809792;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2FB2;
					case 250:
						goto IL_8CF;
					case 251:
						if (controlHeadO2Recset != null)
						{
							num = (short)828571834;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6BCC;
					case 252:
					{
						int num16 = -1;
						global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide secureWide2;
						enumerator = ((global::AcpBusinessLayer.Recordset)secureWide2.EncryptionKeyList.EmbeddedRecset).GetEnumerator();
						num = (short)1690697885;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 253:
						goto IL_4015;
					case 254:
						if (switches2.ConventionalSwitchTable.EmbeddedRecset != null)
						{
							num = (short)1292239077;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_455E;
					case 255:
						if (conventionalSwitchTableInner.ConventionalSwitchTableInnerSection.SwitchConventionalSwitchTablePosition3Feature_A19657.Value == 38)
						{
							num = (short)1707474956;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_91A;
					case 256:
					{
						global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectMessageListInnerSection directMessageListInnerSection2;
						if (directMessageListInnerSection2.DEKDirectMessageBCO_A8506.Value != 0)
						{
							num = (short)1488912600;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_54DE;
					}
					case 257:
					{
						global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitchTableInner trunkingSwitchTableInner;
						if (trunkingSwitchTableInner.TrunkingSwitchTableInnerSection.SwitchTrunkingSwitchTablePosition3Feature_A21006.Value == 38)
						{
							num = (short)1279852754;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3433;
					}
					case 258:
						try
						{
							num = (short)1938030596;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)399179778;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_48BF;
								case 3:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1751384064;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpBusinessLayer.FeatureNode featureNode5 = enumerator.Current;
									(((global::AcpCommonLib.IAcpFeatureNode)featureNode5)[10625] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ResponseSelectorListInnerSection).CHO9PursuitKnobIndex_A36685.CalculateApplicability();
									(((global::AcpCommonLib.IAcpFeatureNode)featureNode5)[10625] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ResponseSelectorListInnerSection).CHO9PursuitKnobIndex_A36685.CalculateValidity();
									num = (short)1693057025;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									switch (0)
									{
									case 0:
										goto IL_4817;
									}
									continue;
								}
								IL_4819:
								num = (short)435814403;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_4817:
								goto IL_4819;
							}
							IL_48BF:
							goto IL_36B1;
						}
						finally
						{
							num = (short)221970433;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_4930;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_48F7;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)1944780800;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_48F7:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1836515330;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_4930:;
						}
						goto IL_4933;
					case 259:
					{
						int num19 = int.Parse(text.Substring(1, 2));
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemRecset conventionalSystemRecset = global::AcpCommonLib.FeatureManager.GetFeature(2053) as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemRecset;
						if (num19 < 9)
						{
							num = (short)848691368;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_63B6;
					}
					case 260:
					{
						global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitchTableInner trunkingSwitchTableInner = switches2.TrunkingSwitchTable.EmbeddedRecset[0] as global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitchTableInner;
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
						radioWide.Features.SwitchConventionalSwitchesPosition1_A12643.SetValue(trunkingSwitchTableInner.TrunkingSwitchTableInnerSection.SwitchTrunkingSwitchTablePosition1Feature_A21004.Value);
						num = (short)2061959310;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 261:
						goto IL_6BCC;
					case 262:
						try
						{
							num = (short)1152057348;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 1:
									goto IL_6345;
								case 2:
									num = (short)535494657;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)202244098;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpBusinessLayer.FeatureNode featureNode6 = enumerator.Current;
									(((global::AcpCommonLib.IAcpFeatureNode)featureNode6)[10209] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection).RadErgoCfgKMConventionalKMDatatButtonIndex_A41423.CalculateApplicability();
									(((global::AcpCommonLib.IAcpFeatureNode)featureNode6)[10209] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection).RadErgoCfgKMConventionalKMDatatButtonIndex_A41423.CalculateValidity();
									(((global::AcpCommonLib.IAcpFeatureNode)featureNode6)[10209] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection).RadErgoCfgKMTrunkingKMDatatButtonIndex_A41424.CalculateApplicability();
									(((global::AcpCommonLib.IAcpFeatureNode)featureNode6)[10209] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection).RadErgoCfgKMTrunkingKMDatatButtonIndex_A41424.CalculateValidity();
									num = (short)291700736;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									switch (0)
									{
									case 0:
										goto IL_6264;
									}
									continue;
								}
								IL_6266:
								num = (short)577699843;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_6264:
								goto IL_6266;
							}
							IL_6345:
							goto IL_3833;
						}
						finally
						{
							num = (short)209584128;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_637C;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)1218052098;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_63B3;
								}
								IL_637C:
								if (enumerator == null)
								{
									break;
								}
								num = (short)379125761;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_63B3:;
						}
						goto IL_63B6;
					case 263:
						try
						{
							num = (short)854327299;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_3A08;
								case 1:
									num = (short)1718353926;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1989083137;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInner topFunctionProgrammableButtonListInner4 = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInner)enumerator.Current;
									num = (short)1362100229;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									switch (0)
									{
									case 0:
										goto IL_3975;
									}
									continue;
								case 4:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectModeBCOListInnerSection directModeBCOListInnerSection;
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInner topFunctionProgrammableButtonListInner4;
									topFunctionProgrammableButtonListInner4.TopFunctionProgrammableButtonListInnerSection.TopFunctionBtnCnvZone_A36942.UIValue = directModeBCOListInnerSection.DEKDirectModeZone_A8538.UIValue;
									topFunctionProgrammableButtonListInner4.TopFunctionProgrammableButtonListInnerSection.TopFunctionBtnCnvChannel_A36943.UIValue = directModeBCOListInnerSection.DEKDirectModeChannel_A8535.UIValue;
									topFunctionProgrammableButtonListInner4.TopFunctionProgrammableButtonListInnerSection.TopFunctionBtnTrkZone_A36944.UIValue = directModeBCOListInnerSection.DEKDirectModeZone_A8538.UIValue;
									topFunctionProgrammableButtonListInner4.TopFunctionProgrammableButtonListInnerSection.TopFunctionBtnTrkChannel_A36945.UIValue = directModeBCOListInnerSection.DEKDirectModeChannel_A8535.UIValue;
									num = (short)659685376;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectModeBCOListInnerSection directModeBCOListInnerSection;
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInner topFunctionProgrammableButtonListInner4;
									if (topFunctionProgrammableButtonListInner4.TopFunctionProgrammableButtonListInnerSection.CnvTopFunctionButtonBCO_A36628.Value == directModeBCOListInnerSection.DEKDirectModeBCO_A8534.Value)
									{
										num = (short)1333985284;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
									goto IL_3AC9;
								}
								IL_3A72:
								num = (short)522059778;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_3975:
								goto IL_3A72;
							}
							IL_3A08:
							IL_3AC9:
							goto IL_611B;
						}
						finally
						{
							num = (short)475463682;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1444282369;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_3B39;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_3B00;
									}
									continue;
								}
								IL_3B00:
								if (enumerator == null)
								{
									break;
								}
								num = (short)892076032;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_3B39:;
						}
						goto IL_3B3C;
					case 264:
						if (signalIndependentProductIndependentNonProgrammableButtonListInnerSection != null)
						{
							num = (short)1511194697;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3899;
					case 265:
						num = (short)1402077409;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 266:
						goto IL_4015;
					case 267:
					{
						try
						{
							num = (short)1702100993;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)633864196;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_FCA;
									}
									continue;
								case 2:
									goto IL_103B;
								case 3:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.RelayPatternBCOListListInnerSection relayPatternBCOListListInnerSection;
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButtonInner bottomFunctionProgrammableButtonInner2;
									bottomFunctionProgrammableButtonInner2.BottomFunctionProgrammableButtonInnerSection.CHO9BottomFunctionButtonIndex_A36665.UIValue = relayPatternBCOListListInnerSection.RdEgoO9DirLtbarPatternBcoListIndex_A36707.UIValue;
									num = (short)2752514;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									goto IL_10C0;
								case 5:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.RelayPatternBCOListListInnerSection relayPatternBCOListListInnerSection;
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButtonInner bottomFunctionProgrammableButtonInner2;
									if (bottomFunctionProgrammableButtonInner2.BottomFunctionProgrammableButtonInnerSection.CHO9BottomFunctionButtonBCO_A36660.Value == relayPatternBCOListListInnerSection.RdEgoO9DirLtbarPatternBcoListBco_A36661.Value)
									{
										num = (short)1409810435;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)387776512;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButtonInner bottomFunctionProgrammableButtonInner2 = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButtonInner)enumerator.Current;
									num = (short)1629814789;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_FCC:
								num = (short)374210566;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_FCA:
								goto IL_FCC;
							}
							IL_103B:
							IL_10C0:
							goto IL_1ABD;
						}
						finally
						{
							num = (short)359727105;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1567555586;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_10F9;
									}
									continue;
								case 2:
									goto IL_1132;
								}
								IL_10F9:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1588068352;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1132:;
						}
						goto IL_1135;
						IL_1ABD:
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.DirectionalButtonsListInnerRecset directionalButtonsListInnerRecset;
						enumerator = directionalButtonsListInnerRecset.GetEnumerator();
						num = (short)1327890577;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 268:
						if (global::ConstraintHelper.UtilityMack.IsPortablePro)
						{
							num = (short)1135476962;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_307D;
					case 269:
						try
						{
							num = (short)1641218051;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)489291777;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
								{
									num = (short)379155655;
									short num20 = num;
									num = (short)158823623;
									switch ((num20 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
										goto IL_4C57;
									}
									break;
								}
								case 3:
									switch (0)
									{
									case 0:
										goto IL_4B3B;
									}
									continue;
								case 4:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1219624960;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpBusinessLayer.FeatureNode featureNode7 = enumerator.Current;
									(((global::AcpCommonLib.IAcpFeatureNode)featureNode7)[10713] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection).CHO7DataButtonConvIndex_A41417.CalculateApplicability();
									(((global::AcpCommonLib.IAcpFeatureNode)featureNode7)[10713] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection).CHO7DataButtonConvIndex_A41417.CalculateValidity();
									(((global::AcpCommonLib.IAcpFeatureNode)featureNode7)[10713] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection).CHO7DataButtonTrkIndex_A41418.CalculateApplicability();
									(((global::AcpCommonLib.IAcpFeatureNode)featureNode7)[10713] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection).CHO7DataButtonTrkIndex_A41418.CalculateValidity();
									num = (short)1324351490;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_4BC8:
								num = (short)806486020;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_4B3B:
								goto IL_4BC8;
							}
							IL_4C57:
							num = (short)830537728;
							if (num != 0)
							{
							}
							goto IL_1AE4;
						}
						finally
						{
							num = (short)1799946241;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_4CDC;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_4CA4;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)36634624;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_4CA4:
								if (enumerator == null)
								{
									break;
								}
								num = (short)859766786;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_4CDC:;
						}
						goto IL_4CDF;
					case 270:
						if (conventionalSwitchTableInner.ConventionalSwitchTableInnerSection.SwitchConventionalSwitchTablePosition1Feature_A19655.Value == 42)
						{
							num = (short)1799487669;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_657C;
					case 271:
						enumerator = ((global::AcpBusinessLayer.Recordset)(acpRecordset[0] as global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLConfiguration).MPLList.EmbeddedRecset).GetEnumerator();
						num = (short)2023817259;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 272:
					{
						global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitchTableInner trunkingSwitchTableInner;
						if (trunkingSwitchTableInner.TrunkingSwitchTableInnerSection.SwitchTrunkingSwitchTablePosition2Feature_A21005.Value == 38)
						{
							num = (short)1170735182;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3433;
					}
					case 273:
						if (o9DataButtonInnerRecset2 != null)
						{
							num = (short)954728480;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_143C;
					case 274:
					{
						global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectMessageListInnerSection directMessageListInnerSection;
						if (directMessageListInnerSection.DEKDirectMessageBCO_A8506.Value != 0)
						{
							num = (short)1870856374;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_246D;
					}
					case 275:
						goto IL_6B69;
					case 276:
						num = (short)1544945754;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 277:
						if (feature != null)
						{
							num = (short)824770730;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3433;
					}
					goto IL_490;
					IL_57D:
					num15++;
					num = (short)900268081;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5A0:
					acpRecordset = global::AcpCommonLib.FeatureManager.GetFeature(2055);
					num = (short)1909915862;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6F7:
					enumerator = (acpRecordset as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileRecset).GetEnumerator();
					num = (short)1919877356;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_8CF:
					signalIndependentProductIndependentNonProgrammableButtonListInnerSection.RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonBCO_A19777.SetValue(91);
					num = (short)1756561425;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_91A:
					num = (short)1925382383;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C85:
					acpListField2 = null;
					acpListField = null;
					controlHeadO2Recset = (global::AcpCommonLib.FeatureManager.GetFeature(4115) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.ControlHeadO2Recset);
					num = (short)479133947;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_E6B:
					num = (short)1426063569;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1135:
					global::AcpCommonLib.UndoRedo.UndoManager.Reset();
					global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerRecset dataButtonInnerRecset4 = (global::AcpCommonLib.FeatureManager.GetFeature(2042) as global::Motorola.MackinawCPS.CoreFeatures.Buttons.ButtonsRecset)[0][10089].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerRecset dataButtonInnerRecset5 = (global::AcpCommonLib.FeatureManager.GetFeature(2127) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.ControlHeadO3Recset)[0][10234].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerRecset;
					global::AcpBusinessLayer.Recordset recordset2 = (global::AcpCommonLib.FeatureManager.GetFeature(2128) as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesRecset)[0][10228].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerSection dataButtonInnerSection = dataButtonInnerRecset4[0][10090] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerSection;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection dataButtonInnerSection2 = dataButtonInnerRecset5[0][10212] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection;
					global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection dataButtonInnerSection3 = recordset2[0][10209] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection;
					dataButtonInnerSection2.CntrlHeadO3ConventionalO3DatatButtonFeature_A22595.SetValue(dataButtonInnerSection.BtnConventionalButtonDatatButtonFeature_A22610.Value);
					dataButtonInnerSection2.CntrlHeadO3TrunkingO3DatatButtonFeature_A22597.SetValue(dataButtonInnerSection.BtnTrunkingButtonDatatButtonFeature_A22608.Value);
					dataButtonInnerSection3.RadErgoCfgKMConventionalKMDatatButtonFeature_A22603.SetValue(dataButtonInnerSection.BtnConventionalButtonDatatButtonFeature_A22610.Value);
					dataButtonInnerSection3.RadErgoCfgKMTrunkingKMDatatButtonFeature_A22605.SetValue(dataButtonInnerSection.BtnTrunkingButtonDatatButtonFeature_A22608.Value);
					acpRecordset = global::AcpCommonLib.FeatureManager.GetFeature(2078);
					num = (short)1940586556;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1336:
					num = (short)1725694067;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_143C:
					dataButtonInnerRecset3 = ((global::AcpCommonLib.FeatureManager.GetFeature(2128) as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesRecset)[0][10228].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerRecset);
					num = (short)1315635430;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_17ED:
					o2MultiFunctionKnob = (controlHeadO2Recset[0][10721] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2MultiFunctionKnob);
					num = (short)6291610;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1842:
					num5++;
					num = (short)847708413;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1A7F:
					num = (short)319946781;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1AE4:
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset controlHeadO9Recset2 = global::AcpCommonLib.FeatureManager.GetFeature(4003) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset;
					responseSelectorListInnerRecset = (controlHeadO9Recset2[0][10624].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ResponseSelectorListInnerRecset);
					o9DataButtonInnerRecset2 = (controlHeadO9Recset2[0][10611].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerRecset);
					num = (short)1961951288;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1D9B:
					enumerator = dataButtonInnerRecset3.GetEnumerator();
					num = (short)157286662;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1FC5:
					conventionalSwitchTableInner = (switches2.ConventionalSwitchTable.EmbeddedRecset[2] as global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitchTableInner);
					num = (short)1873084686;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_237D:
					enumerator = ((global::AcpCommonLib.FeatureManager.GetFeature(4109) as global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadRecset)[0][10710].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInnerRecset).GetEnumerator();
					num = (short)789708956;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_23CA:
					controlHeadO9Recset = (global::AcpCommonLib.FeatureManager.GetFeature(4003) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset);
					topFunctionProgrammableButtonListInnerRecset = (controlHeadO9Recset[0][10616].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerRecset);
					directMessageListInnerRecset2 = (dekrecset[0][10229].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectMessageListInnerRecset);
					num7 = 0;
					num7 = directMessageListInnerRecset2.Count;
					num18 = 0;
					num = (short)720306379;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_246D:
					num4++;
					num = (short)1286537295;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_268A:
					uclContact = (acpRecordset[num12] as global::SpecialFeatures.Ucl.Contact.UclContact);
					num = (short)1698693133;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_275D:
					num = (short)2004353049;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2E1E:
					o7DataButtonInnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(4114) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7Recset)[0][10717].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerRecset);
					num = (short)1366229043;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_45:
					try
					{
						IL_2C8B:
						num = (short)1328021504;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_2CC6;
								}
								continue;
							case 2:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)380698628;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLListInner mpllistInner = enumerator.Current as global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLListInner;
								mpllistInner.MPLListInnerSection.MplCfgMPLListTxPLFreq_A9556.SetValue(mpllistInner.MPLListInnerSection.MplCfgMPLListTxPLCode_A9555.Value);
								mpllistInner.MPLListInnerSection.MplCfgMPLListRxPLFreq_A9027.SetValue(mpllistInner.MPLListInnerSection.MplCfgMPLListRxPLCode_A9026.Value);
								mpllistInner.MPLListInnerSection.MplCfgMPLListTAPLFreq_A9263.SetValue(mpllistInner.MPLListInnerSection.MplCfgMPLListTAPLCode_A9262.Value);
								num = (short)885129217;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 3:
								goto IL_2DAA;
							case 4:
								num = (short)1025114115;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_2CC8:
							num = (short)394526722;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_2CC6:
							goto IL_2CC8;
						}
						IL_2DAA:
						goto IL_40D4;
					}
					finally
					{
						num = (short)38731776;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_2DE2;
								}
								continue;
							case 1:
								goto IL_2E1B;
							case 2:
								enumerator.Dispose();
								num = (short)673644545;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_2DE2:
							if (enumerator == null)
							{
								break;
							}
							num = (short)2105344002;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_2E1B:;
					}
					goto IL_2E1E;
					IL_2F2A:
					num = (short)473104423;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2F69:
					acpRecordset = global::AcpCommonLib.FeatureManager.GetFeature(2038);
					num = (short)42270814;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2FB2:
					num12++;
					num = (short)187433125;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_307D:
					this.CombinePinPartsToPinPassword(isReadingRadio, currentRadioParams);
					this.ChangeLegacyDINCFieldsFromLowerToUpperCase();
					this.RemoveTheRecordOfCallAlertIDDisplay();
					acpRecordset = (global::AcpCommonLib.FeatureManager.GetFeature(2200) as global::SpecialFeatures.Ucl.Contact.UclContactRecset);
					num = (short)718143564;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_30E3:
					this.SynO2O7MFK();
					this.UpdateO2O7Emergency();
					this.SyncDataButton();
					this.SyncAllControlHeadsNavigationControls();
					global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation = global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation;
					text = radioInformation.General.RadInfoGeneralCodeplugVersion_A7683;
					radInfoLabtoolExtendedDispatch_A38638Value = radioInformation.Labtool.RadInfoLabtoolExtendedDispatch_A38638Value;
					num = (short)1139474691;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3383:
					recordset = (uclContact.PhoneCallList.EmbeddedRecset as global::SpecialFeatures.Ucl.Contact.PhoneCallListRecset);
					num = (short)1677525241;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3433:
					acpRecordset = global::AcpCommonLib.FeatureManager.GetFeature(2064);
					num = (short)451674192;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3525:
					num = (short)719782001;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3630:
					num3++;
					num = (short)1701707826;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3653:
					num = (short)141295862;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_36B1:
					num = (short)1769341201;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_37C6:
					num = (short)158204144;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3833:
					this.RefreshMaxChangeRecords();
					int radInfoGeneralMaximumChannels_A11479Value = (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation).General.RadInfoGeneralMaximumChannels_A11479Value;
					num = (short)1512374404;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3899:
					signalIndependentProductIndependentNonProgrammableButtonListInnerSection = (signalIndependentProductIndependentNonProgrammableButtonListInnerRecset[35][10032] as global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInnerSection);
					num = (short)143261762;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3B3C:
					num = (short)2046165205;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3E63:
					num = (short)1668284525;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3EB1:
					shepherdsRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2013) as global::Motorola.MackinawCPS.CoreFeatures.Shepherds.ShepherdsRecset);
					num = (short)1113194621;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3EFF:
					feature3 = global::AcpCommonLib.FeatureManager.GetFeature(4174);
					num = (short)2005729317;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3F4A:
					num = (short)356450390;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4015:
					num = (short)2088173759;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4054:
					num = (short)1837432936;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4094:
					num = (short)1240924298;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_40D4:
					acpRecordset = global::AcpCommonLib.FeatureManager.GetFeature(2059);
					num = (short)354025705;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4369:
					enumerator = o9DataButtonInnerRecset2.GetEnumerator();
					num = (short)668598353;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_455E:
					num = (short)1076101344;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4748:
					num = (short)1631846503;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_47B7:
					num10++;
					num = (short)632553594;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4933:
					secureWide = (feature2[0] as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide);
					value = secureWide.ASTROOTAR.SecWideASTROOTARIndividualASTROOTARRadioID_A8284.DefaultValue;
					num = (short)409141349;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4A03:
					conventionalPersonalityRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2059) as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityRecset);
					num = (short)1889730721;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4CDF:
					enumerator = bottomFunctionProgrammableButtonInnerRecset.GetEnumerator();
					num = (short)440598664;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4F65:
					enumerator = conventionalPersonalityRecset.GetEnumerator();
					num = (short)1613103349;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_54DE:
					num18++;
					num = (short)664731705;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_134:
					try
					{
						IL_70CF:
						num = (short)793968642;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)497090563;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInner topFunctionProgrammableButtonListInner5 = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInner)enumerator.Current;
								num = (short)1291321348;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 1:
								goto IL_71EA;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_7111;
								}
								continue;
							case 3:
								num = (short)1158283270;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
							{
								global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectMessageListInnerSection directMessageListInnerSection2;
								global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInner topFunctionProgrammableButtonListInner5;
								if (topFunctionProgrammableButtonListInner5.TopFunctionProgrammableButtonListInnerSection.CnvTopFunctionButtonBCO_A36628.Value == directMessageListInnerSection2.DEKDirectMessageBCO_A8506.Value)
								{
									num = (short)1788870661;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 5:
							{
								global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInner topFunctionProgrammableButtonListInner5;
								topFunctionProgrammableButtonListInner5.TopFunctionProgrammableButtonListInnerSection.O9CHCnvTopFunctionButtonStsMsgIndex_A36781.SetValue(num18 + 1);
								topFunctionProgrammableButtonListInner5.TopFunctionProgrammableButtonListInnerSection.O9CHTrkTopFunctionButtonStsMsgIndex_A36782.SetValue(num18 + 1);
								num = (short)209321985;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 6:
								goto IL_7208;
							}
							IL_716C:
							num = (short)209715200;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_7111:
							goto IL_716C;
						}
						IL_71EA:
						IL_7208:
						goto IL_54DE;
					}
					finally
					{
						num = (short)1048182785;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								enumerator.Dispose();
								num = (short)1674510338;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_723F;
								}
								continue;
							case 2:
								goto IL_7278;
							}
							IL_723F:
							if (enumerator == null)
							{
								break;
							}
							num = (short)461045760;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_7278:;
					}
					break;
					Block_99:
					try
					{
						IL_5168:
						num = (short)2083651603;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								if (acpListField2 != null)
								{
									num = (short)1463222285;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_51E1;
							case 1:
							{
								global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInnerSection signalIndependentProductIndependentNonProgrammableButtonListInnerSection2;
								if (signalIndependentProductIndependentNonProgrammableButtonListInnerSection2.RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonFeature_A19778.Value == 31)
								{
									num = (short)736755722;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)1667760142;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 2:
							{
								global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInnerSection signalIndependentProductIndependentNonProgrammableButtonListInnerSection2;
								if (signalIndependentProductIndependentNonProgrammableButtonListInnerSection2.RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonBCO_A19777.Value == 91)
								{
									num = (short)1617690642;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 3:
								goto IL_527C;
							case 4:
								acpListField.SetValue(31);
								num = (short)119603203;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 5:
								goto IL_51E1;
							case 6:
								goto IL_5419;
							case 7:
								goto IL_5326;
							case 8:
								if (acpListField != null)
								{
									num = (short)571408388;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_5453;
							case 9:
								if (acpListField != null)
								{
									num = (short)1194393615;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_5453;
							case 10:
								num = (short)1285160960;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 11:
								goto IL_5453;
							case 12:
								acpListField2.SetValue(215);
								num = (short)1456340998;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 13:
								acpListField2.SetValue(31);
								num = (short)1228668933;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 14:
								if (acpListField2 != null)
								{
									num = (short)595263500;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_5419;
							case 15:
								acpListField.SetValue(215);
								num = (short)1060569095;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 16:
								goto IL_546B;
							case 17:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)498991115;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInnerSection signalIndependentProductIndependentNonProgrammableButtonListInnerSection2 = ((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10032] as global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInnerSection;
								num = (short)1670971394;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 18:
								num = (short)1476198401;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 19:
								switch (0)
								{
								case 0:
									goto IL_51DF;
								}
								continue;
							}
							goto IL_51DF;
							IL_51E1:
							num = (short)2424840;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_5218:
							num = (short)1768882193;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_51DF:
							goto IL_5218;
							IL_5419:
							num = (short)56623113;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_5453:
							num = (short)809435152;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_527C:
						IL_5326:
						IL_546B:
						break;
					}
					finally
					{
						num = (short)643760130;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_54DB;
							case 1:
								enumerator.Dispose();
								num = (short)1682898944;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_54A2;
								}
								continue;
							}
							IL_54A2:
							if (enumerator == null)
							{
								break;
							}
							num = (short)739508225;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_54DB:;
					}
					goto IL_54DE;
					IL_557E:
					num = (short)1782251636;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5876:
					enumerator = topFunctionProgrammableButtonListInnerRecset.GetEnumerator();
					num = (short)2001273095;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_58C9:
					num = (short)1202585831;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5955:
					this.UpdatePaddingSpacesForSoftIDUsername();
					this.ConsolidatedActionBCOTableInit();
					num = (short)609550485;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5A5F:
					num = (short)5505089;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5AD3:
					num = (short)1530069196;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5B17:
					num = (short)65208588;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6046:
					enumerator = ((global::AcpBusinessLayer.Recordset)acpRecordset).GetEnumerator();
					num = (short)230359133;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_611B:
					num9++;
					num = (short)418119855;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6199:
					this.InitFCCNarrowBandSplit();
					acpRecordset = global::AcpCommonLib.FeatureManager.GetFeature(2021);
					num = (short)1525940398;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_61EA:
					num = (short)390135809;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_63B6:
					dataProfilesRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2054) as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesRecset);
					codeplugMainVersion = this.GetCodeplugMainVersion();
					num = (short)1456537655;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_657C:
					num = (short)368443491;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6ABF:
					directStatusBCOListInnerSection2 = (directStatusBCOListInnerRecset[num3] as global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectStatusBCOListInner).DirectStatusBCOListInnerSection;
					num = (short)1516044360;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6B69:
					feature4 = global::AcpCommonLib.FeatureManager.GetFeature(2045);
					feature = global::AcpCommonLib.FeatureManager.GetFeature(2038);
					feature5 = global::AcpCommonLib.FeatureManager.GetFeature(2033);
					num = (short)741474581;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6BCC:
					controlHeadO7Recset = (global::AcpCommonLib.FeatureManager.GetFeature(4114) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7Recset);
					num = (short)1383071986;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6E4F:
					acpRecordset = global::AcpCommonLib.FeatureManager.GetFeature(4109);
					keypadButtonInnerRecset = ((acpRecordset as global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadRecset)[0][10710].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInnerRecset);
					num = (short)1170866210;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_727B:
				this.ToneSignalingListToneAliasFixup();
				global::AcpCommonLib.UndoRedo.UndoManager.StartUndoRedo();
				return;
				IL_490:
				global::AcpCommonLib.UndoRedo.UndoManager.StopUndoRedo();
				this.AddQC2DefaultRecord();
				this.SyncQC2Code();
				this.InitTrkPerAnnGroup();
				this.ResetMotionSensitivityDefaultValue();
				this.ResetEmergencyAlarmRetryRateDefaultValue();
				this.RestoreScanZoneChannelWhenCNVTalkGroupIsDVNOrATG();
				this.SetStatusAutoExitToAlwaysAndUpdateConStatusAliasNumber();
				this.SetAudioConfigurationLevelToBasic();
				this.SetAudioSettingGroupSettingValueToCustom();
				this.SyncValueForAccessoryFieldsForAudioEnhancementFeature();
				this.RefreshAudioEnhancementForConsolette();
				this.SetActionTypeAfterUpgrade();
				this.SyncActiveMicForBTPTT();
				this.RefreshPowerLevelForSRX2200();
				this.SetControlHeadAliasList();
				this.SetGCAITable();
				this.RefreshDynChannelName();
				this.RefreshBroadbandFields();
				this.RefreshUserSelectablePL();
				this.RefreshActionConsolidation();
				this.RefreshToneSignalingList();
				this.FixPassword();
				this.UnpackFixupForFPPProtectedZonePassword();
				this.RefreshAESFields();
				this.SynPreAmp();
				this.SetValueForNewCnvHotMicTxPeriodField();
				this.SetValueForNewTrkHotMicTxPeriodField();
				global::SpecialFeatures.Flashport.FlashRadio.UpgradeRadio.SetWindNoiseReductionLevelForAccessories();
				num = (short)1670774820;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00024510 File Offset: 0x00022710
		private void ResetEmergencyAlarmRetryRateDefaultValue()
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			int codeplugMainVersion;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TPS tps;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					if (codeplugMainVersion >= 9)
					{
						return;
					}
					num2 = (short)1464978729;
					short num3 = num2;
					num2 = (short)769510697;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_B8;
					default:
						num2 = (short)2113601536;
						if (num2 != 0)
						{
						}
						num2 = (short)547160065;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
					tps.RadWideTPSFiregroundEmergencyAlarmRetryRatesec_A7929.Value = 4;
					num2 = (short)686358532;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					num2 = (short)783745024;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					goto IL_B8;
				case 4:
					return;
				}
				goto IL_24;
				IL_B8:
				if (tps == null)
				{
					break;
				}
				num2 = (short)864878594;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_24:
			num2 = (short)59506689;
			if (num2 != 0)
			{
			}
			tps = ((global::AcpCommonLib.FeatureManager.GetFeature(2045) as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset)[0][10749] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TPS);
			codeplugMainVersion = this.GetCodeplugMainVersion();
			num2 = (short)253165568;
			short num4 = num2;
			num2 = (short)554369027;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x000246A0 File Offset: 0x000228A0
		private void RestoreScanZoneChannelWhenCNVTalkGroupIsDVNOrATG()
		{
			short num = (short)644022272;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_152;
				}
				global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
				for (;;)
				{
					IL_27:
					int num4;
					global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInner scanListInner;
					int num5;
					switch (num2)
					{
					case 0:
						num = (short)1252982826;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						num = (short)1131151387;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
						if (conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044 != null)
						{
							num = (short)15138875;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_338;
					}
					case 3:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner;
						if (channelAssignmentListInner.ChannelAssignmentListInnerSection.ZnChanCfgChannelsChannelType_A22241.Value == 0)
						{
							num = (short)1815609353;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_338;
					}
					case 4:
						num = (short)643497996;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
					{
						global::AcpBusinessLayer.AcpRecRefField scanLstScanListChannel_A;
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner = scanLstScanListChannel_A.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner;
						num = (short)63701031;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						goto IL_338;
					case 7:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
						if (conventionalPersonality.ASTROTalkgroup.CnvPerASTROTalkgroupOptionsTalkGroupEnable_A9272.Value)
						{
							num = (short)2142830605;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_338;
					}
					case 8:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner frequencyOptionsInner;
						if (frequencyOptionsInner.FrequencyOptionsInnerSection.CnvPerConventionalChannelOptionsASTROTalkgroupID_A9281.Value == 65534)
						{
							num = (short)1415118909;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_338;
					}
					case 9:
						num = (short)1724186641;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
						if (conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.Value != 0)
						{
							num = (short)942538814;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_338;
					}
					case 11:
						num = (short)201392193;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner frequencyOptionsInner;
						if (frequencyOptionsInner.FrequencyOptionsInnerSection != null)
						{
							num = (short)931397633;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_338;
					}
					case 13:
					{
						num = (short)251068416;
						short num3 = num;
						num = (short)619315224;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
						goto IL_44A;
					case 15:
						num = (short)1163132983;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanList scanList;
						if (scanList.ScanListMembers != null)
						{
							num = (short)1943863307;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B17;
					}
					case 17:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner;
						if (channelAssignmentListInner.ChannelAssignmentListInnerSection.ZnChanCfgChannelsPersonality_A8698 != null)
						{
							num = (short)1867120680;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_338;
					}
					case 18:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListRecset scanListRecset;
						if (scanListRecset != null)
						{
							num = (short)932118549;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 19:
						num = (short)839909420;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						num = (short)1768292385;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						num4 = 0;
						num = (short)611975182;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						if (scanListInner.ScanListInnerSection.ScanLstScanListChannel_A7620.Value != 0)
						{
							num = (short)761987107;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_338;
					case 23:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListRecset scanListRecset = global::AcpCommonLib.FeatureManager.GetFeature(2057) as global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListRecset;
						num = (short)1328742418;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 24:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner;
						if (channelAssignmentListInner.ChannelAssignmentListInnerSection.ZnChanCfgChannelsConventionalChannelReference_A20560 != null)
						{
							num = (short)150863903;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_338;
					}
					case 25:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner frequencyOptionsInner;
						if (frequencyOptionsInner.FrequencyOptionsInnerSection.CnvPerConventionalChannelOptionsASTROTalkgroupID_A9281.Value != 65535)
						{
							num = (short)1237909573;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_408;
					}
					case 26:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanList scanList;
						if (num5 >= scanList.ScanListMembers.EmbeddedRecset.Count)
						{
							num = (short)1140654148;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						scanListInner = (scanList.ScanListMembers.EmbeddedRecset[num5] as global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInner);
						num = (short)1659174963;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 27:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner frequencyOptionsInner;
						if (frequencyOptionsInner.FrequencyOptionsInnerSection.CnvPerConventionalChannelOptionsASTROTalkgroupID_A9281 != null)
						{
							num = (short)407306286;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_338;
					}
					case 28:
						num5 = 0;
						num = (short)1046806557;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
						num = (short)360120321;
						if (num != 0)
						{
						}
						goto IL_A81;
					case 30:
						num = (short)2108489750;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner;
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner frequencyOptionsInner = channelAssignmentListInner.ChannelAssignmentListInnerSection.ZnChanCfgChannelsConventionalChannelReference_A20560.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner;
						num = (short)1567621184;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 32:
						num = (short)1514274819;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner;
						if (channelAssignmentListInner.ChannelAssignmentListInnerSection.ZnChanCfgChannelsChannelType_A22241 != null)
						{
							num = (short)699400224;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_338;
					}
					case 34:
						num = (short)1237516290;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 35:
					{
						global::AcpBusinessLayer.AcpRecRefField scanLstScanListChannel_A = scanListInner.ScanListInnerSection.ScanLstScanListChannel_A7620;
						num = (short)678953027;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 36:
						num = (short)936771631;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 37:
						goto IL_A81;
					case 38:
						num = (short)52363317;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 39:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner;
						if (channelAssignmentListInner == null)
						{
							goto IL_338;
						}
						num = (short)1478204429;
						short num6 = num;
						num = (short)1624218637;
						switch ((num6 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_8FC;
						default:
							num = (short)830603264;
							if (num != 0)
							{
							}
							num = (short)1182269489;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 40:
						num = (short)1987837997;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 41:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
						if (conventionalPersonality.ASTROTalkgroup != null)
						{
							num = (short)1648361542;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_338;
					}
					case 42:
						if (radioInformation.Labtool != null)
						{
							num = (short)1004208143;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 43:
						if (radioInformation.Labtool.RadioInfoLabToolQA00631DvrsPsuActivation_A40166.Value)
						{
							num = (short)198508567;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 44:
						if (scanListInner.ScanListInnerSection != null)
						{
							num = (short)1958346788;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_338;
					case 45:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner;
						if (channelAssignmentListInner.ChannelAssignmentListInnerSection.ZnChanCfgChannelsPersonality_A8698.ReferencedNode != null)
						{
							num = (short)842727495;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_338;
					}
					case 46:
						num = (short)130613273;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 47:
						if (scanListInner.ScanListInnerSection.ScanLstScanListChannel_A7620 != null)
						{
							num = (short)789512222;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_338;
					case 48:
						return;
					case 49:
						num = (short)203948092;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 50:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListRecset scanListRecset;
						if (num4 >= scanListRecset.Count)
						{
							num = (short)728105008;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanList scanList = scanListRecset[num4] as global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanList;
						num = (short)1009516596;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 51:
						if (scanListInner != null)
						{
							num = (short)646971411;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_338;
					case 52:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanList scanList;
						if (scanList != null)
						{
							num = (short)1548943418;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B17;
					}
					case 53:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
						if (conventionalPersonality.RxOptions != null)
						{
							num = (short)1522925602;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_338;
					}
					case 54:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
						if (conventionalPersonality != null)
						{
							num = (short)1458241574;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_338;
					}
					case 55:
						if (radioInformation.Labtool.RadioInfoLabToolQA00631DvrsPsuActivation_A40166 != null)
						{
							num = (short)1200881736;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 56:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
						if (conventionalPersonality.ASTROTalkgroup.CnvPerASTROTalkgroupOptionsTalkGroupEnable_A9272 != null)
						{
							num = (short)1044578361;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_338;
					}
					case 57:
						num = (short)936116234;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 58:
						num = (short)924909584;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 59:
						num = (short)249233449;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 60:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner;
						if (channelAssignmentListInner.ChannelAssignmentListInnerSection != null)
						{
							num = (short)1177878548;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_338;
					}
					case 61:
						goto IL_408;
					case 62:
						num = (short)910032903;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 63:
						goto IL_44A;
					case 64:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner frequencyOptionsInner;
						if (frequencyOptionsInner != null)
						{
							num = (short)581304324;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_338;
					}
					case 65:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanList scanList;
						if (scanList.ScanListMembers.EmbeddedRecset != null)
						{
							num = (short)869859356;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B17;
					}
					case 66:
						if (radioInformation != null)
						{
							num = (short)1766653952;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 67:
					{
						global::AcpBusinessLayer.AcpRecRefField scanLstScanListChannel_A;
						if (scanLstScanListChannel_A.ReferencedNode != null)
						{
							goto IL_8FC;
						}
						goto IL_338;
					}
					case 68:
						goto IL_B17;
					case 69:
						num = (short)258342920;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 70:
						num = (short)680984632;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 71:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner;
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality = channelAssignmentListInner.ChannelAssignmentListInnerSection.ZnChanCfgChannelsPersonality_A8698.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality;
						num = (short)1194000438;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 72:
						num = (short)1159266347;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_152;
					IL_338:
					num5++;
					num = (short)1569456165;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_408:
					scanListInner.ScanListInnerSection.ScanLstScanListChannel_A7620.SetValue(0);
					scanListInner.ScanListInnerSection.ScanLstScanListZone_A9718.SetValue(0);
					num = (short)1389101062;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_44A:
					num = (short)130023474;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_8FC:
					num = (short)57475077;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A81:
					num = (short)1842020378;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_B17:
					num4++;
					num = (short)1943732287;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_152:
				radioInformation = (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation);
				num = (short)450822210;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00025334 File Offset: 0x00023534
		private void SetStatusAutoExitToAlwaysAndUpdateConStatusAliasNumber()
		{
			short num = (short)1918631936;
			switch (num)
			{
			default:
			{
				num = (short)826277901;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::Motorola.MackinawCPS.CoreFeatures.ConventionalAliasLists.ConventionalAliasLists conventionalAliasLists;
					global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide radioErgonomicsWide;
					switch (num2)
					{
					case 0:
						if (conventionalAliasLists != null)
						{
							num = (short)884146193;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
						if (this.GetCodeplugMainVersion() >= 12)
						{
							num = (short)986841103;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_52A;
					case 2:
						num = (short)1601699846;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						int num3 = 1;
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalAliasLists.StatusAliasTableInnerRecset statusAliasTableInnerRecset;
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = statusAliasTableInnerRecset.GetEnumerator();
						num = (short)1834876947;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						num = (short)1365114890;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (this.GetCodeplugMainVersion() == 12)
						{
							num = (short)1169686528;
							short num4 = num;
							num = (short)977207300;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 6:
						if (radioErgonomicsWide.HomeMode.RadErgoWideHomeModeHomeModeSelection_A8202.HiddenStatic)
						{
							num = (short)887816201;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 7:
						if (radioErgonomicsWide != null)
						{
							num = (short)1136852994;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 8:
						goto IL_1A0;
					case 9:
					{
						global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.DisplayAndMenu displayAndMenu = global::AcpCommonLib.FeatureManager.GetFeature(2010)[0] as global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.DisplayAndMenu;
						num = (short)1953759250;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						if (this.GetCodeplugMiddleVersion() < 1)
						{
							num = (short)544866315;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 11:
						goto IL_52A;
					case 12:
						num = (short)1323958273;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						switch (0)
						{
						case 0:
							goto IL_95;
						}
						continue;
					case 14:
					{
						num = (short)772540869;
						short num5 = num;
						num = (short)1907755461;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1A0;
						default:
						{
							num = (short)1506148352;
							if (num != 0)
							{
							}
							global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.DisplayAndMenu displayAndMenu;
							displayAndMenu.Advanced.RadioErgDispAdvanceStatusAutoExit_42158.SetValue(1);
							num = (short)404553736;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 15:
						goto IL_36A;
					case 16:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalAliasLists.StatusAliasTableInnerRecset statusAliasTableInnerRecset;
						if (statusAliasTableInnerRecset != null)
						{
							num = (short)1509752835;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 17:
					{
						num = (short)891092993;
						if (num != 0)
						{
						}
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalAliasLists.StatusAliasTableInnerRecset statusAliasTableInnerRecset = conventionalAliasLists.StatusAliasList.EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ConventionalAliasLists.StatusAliasTableInnerRecset;
						num = (short)593231888;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 18:
					{
						global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.DisplayAndMenu displayAndMenu;
						if (displayAndMenu != null)
						{
							num = (short)1187315726;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3D6;
					}
					case 19:
						try
						{
							num = (short)322174979;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 1:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalAliasLists.StatusAliasTableInner statusAliasTableInner;
									if (statusAliasTableInner != null)
									{
										num = (short)1515716612;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)917504006;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalAliasLists.StatusAliasTableInner statusAliasTableInner = enumerator.Current as global::Motorola.MackinawCPS.CoreFeatures.ConventionalAliasLists.StatusAliasTableInner;
									num = (short)2094530561;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									switch (0)
									{
									case 0:
										goto IL_22A;
									}
									continue;
								case 4:
								{
									int num3;
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalAliasLists.StatusAliasTableInner statusAliasTableInner;
									statusAliasTableInner.StatusAliasTableInnerSection.CnvAlsLstStatusAliasListStatusAliasNumber_A9191.SetValue(num3++);
									num = (short)1942159360;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									goto IL_2F7;
								case 6:
									num = (short)1116209157;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_29D:
								num = (short)1115553794;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_22A:
								goto IL_29D;
							}
							IL_2F7:
							return;
						}
						finally
						{
							num = (short)795738112;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_32F;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)860880898;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_367;
								}
								IL_32F:
								if (enumerator == null)
								{
									break;
								}
								num = (short)230752257;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_367:;
						}
						goto IL_36A;
					}
					IL_95:
					if (global::ConstraintHelper.UtilityMack.IsPortablePro)
					{
						num = (short)1073283084;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_36A:
					num = (short)1097007109;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3D6:
					conventionalAliasLists = (global::AcpCommonLib.FeatureManager.GetFeature(2007)[0] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalAliasLists.ConventionalAliasLists);
					num = (short)383909888;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1A0:
					goto IL_3D6;
					IL_52A:
					radioErgonomicsWide = (global::AcpCommonLib.FeatureManager.GetFeature(2033)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide);
					num = (short)368902151;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
			}
			}
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x000258D8 File Offset: 0x00023AD8
		private void SetAudioConfigurationLevelToBasic()
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			global::AcpCommonLib.IAcpRecordset feature;
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					goto IL_121;
				case 1:
					(feature[0][10101] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.DigitalAudioOptions).RadWideAudioConfigurationLevel_42740.Value = 0;
					num2 = (short)232128512;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
				{
					num2 = (short)1475411968;
					short num3 = num2;
					if (!(feature[0][10093] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Labtool).RadWideLabtoolAudioEnhancement_A42736.Value)
					{
						num2 = (short)1738604545;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				}
				break;
			}
			IL_1C:
			feature = global::AcpCommonLib.FeatureManager.GetFeature(2045);
			num2 = (short)1100722336;
			short num4 = num2;
			num2 = (short)856338592;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_121:
				num2 = (short)256311297;
				if (num2 != 0)
				{
				}
				break;
			default:
			{
				num2 = (short)709361664;
				if (num2 != 0)
				{
				}
				num2 = (short)2026897410;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00025A30 File Offset: 0x00023C30
		private void SetAudioSettingGroupSettingValueToCustom()
		{
			short num = (short)90308608;
			switch (num)
			{
			default:
			{
				num = (short)985661444;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfilesRecset radioProfilesRecset;
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)784990208;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator;
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_CB;
									}
									continue;
								case 1:
									num = (short)284884994;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_312;
								case 3:
									try
									{
										num = (short)996999170;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												goto IL_25C;
											case 1:
											{
												global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings;
												audioSettings.NoiseReductionGroupSettingRadio_42584.Value = 4;
												audioSettings.NoiseReductionGroupSettingAccessory_42585.Value = 4;
												audioSettings.GainSensitivityGroupSettingRadio_42608.Value = 4;
												audioSettings.GainSensitivityGroupSettingAccessory_42610.Value = 4;
												audioSettings.AudioEqualizationGroupSettingRadio_42604.Value = 4;
												audioSettings.AudioEqualizationGroupSettingAccessory_42605.Value = 4;
												audioSettings.AudioEqualizationGroupSettingRadio_42613.Value = 4;
												audioSettings.AudioEqualizationGroupSettingAccessory_42614.Value = 4;
												num = (short)2067333125;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 2:
												switch (0)
												{
												case 0:
													goto IL_14E;
												}
												continue;
											case 3:
											{
												global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings;
												if (audioSettings != null)
												{
													num = (short)2022572033;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 4:
												num = (short)1621295104;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 5:
												goto IL_23E;
											case 6:
											{
												if (!enumerator.MoveNext())
												{
													num = (short)1847394308;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings = enumerator.Current as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings;
												num = (short)824311811;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											}
											IL_150:
											num = (short)1957625862;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_14E:
											goto IL_150;
										}
										IL_23E:
										IL_25C:
										break;
									}
									finally
									{
										num = (short)1029308418;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												goto IL_2C9;
											case 1:
												enumerator.Dispose();
												num = (short)581894144;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 2:
												switch (0)
												{
												case 0:
													goto IL_293;
												}
												continue;
											}
											IL_293:
											if (enumerator == null)
											{
												break;
											}
											num = (short)1436155905;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_2C9:;
									}
									goto IL_2CC;
								case 4:
									if (!enumerator2.MoveNext())
									{
										num = (short)2027945985;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2CC;
								}
								IL_D0:
								num = (short)1148452868;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_CB:
								goto IL_D0;
								IL_2CC:
								enumerator = ((global::AcpCommonLib.IAcpFeatureNode)enumerator2.Current).FeatureSectionsCollection.GetEnumerator();
								num = (short)1977548803;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_312:
							return;
						}
						finally
						{
							num = (short)449380354;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
								switch (num2)
								{
								case 0:
									goto IL_37E;
								case 1:
									enumerator2.Dispose();
									num = (short)1490288640;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_349;
									}
									continue;
								}
								IL_349:
								if (enumerator2 == null)
								{
									break;
								}
								num = (short)254476289;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_37E:;
						}
						goto IL_381;
					case 1:
						num = (short)1605566467;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_381;
					case 3:
						if (this.GetCodeplugMainVersion() == 13)
						{
							num = (short)829358085;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 4:
						switch (0)
						{
						case 0:
							goto IL_69;
						}
						continue;
					case 5:
						goto IL_45F;
					case 6:
					{
						num = (short)417988609;
						if (num != 0)
						{
						}
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2 = radioProfilesRecset.GetEnumerator();
						num = (short)1837629440;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
					{
						num = (short)142563167;
						short num3 = num;
						num = (short)2105694047;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_45F;
						default:
							num = (short)1084686336;
							if (num != 0)
							{
							}
							if (this.GetCodeplugMiddleVersion() < 1)
							{
								num = (short)647757826;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						}
						break;
					}
					case 8:
						if (radioProfilesRecset != null)
						{
							num = (short)20185088;
							short num4 = num;
							num = (short)1422721030;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					IL_69:
					if (this.GetCodeplugMainVersion() >= 13)
					{
						num = (short)1147600897;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_381:
					radioProfilesRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2077) as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfilesRecset);
					num = (short)211615752;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_45F:
					num = (short)3670023;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
			}
			}
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00025F80 File Offset: 0x00024180
		private int GetCodeplugMiddleVersion()
		{
			short num = (short)550463800;
			short num2 = num;
			num = (short)1895393592;
			int result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)2038693888;
				if (num != 0)
				{
				}
				result = 0;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_78;
					}
					int num3;
					global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
					for (;;)
					{
						IL_5A:
						switch (num3)
						{
						case 0:
						{
							string radInfoGeneralCodeplugVersion_A7683_UIValue = radioInformation.General.RadInfoGeneralCodeplugVersion_A7683_UIValue;
							num = (short)1823014916;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							goto IL_170;
						case 2:
							if (radioInformation != null)
							{
								num = (short)1170931712;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_159;
						case 3:
							num = (short)623116289;
							if (num != 0)
							{
							}
							goto IL_159;
						case 4:
						{
							string radInfoGeneralCodeplugVersion_A7683_UIValue;
							if (radInfoGeneralCodeplugVersion_A7683_UIValue.Length > 5)
							{
								num = (short)346816517;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_159;
						}
						case 5:
						{
							string radInfoGeneralCodeplugVersion_A7683_UIValue;
							result = int.Parse(radInfoGeneralCodeplugVersion_A7683_UIValue.Substring(4, 2).ToString());
							num = (short)506920963;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						goto IL_78;
						IL_159:
						num = (short)1292042241;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_170:
					break;
					IL_78:
					radioInformation = (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation);
					num = (short)1785331714;
					num3 = (int)((global::System.IntPtr)num);
					goto IL_5A;
				}
				catch
				{
				}
				break;
			}
			num = (short)1908277248;
			short num4 = num;
			return result;
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x0002614C File Offset: 0x0002434C
		private void SyncValueForAccessoryFieldsForAudioEnhancementFeature()
		{
			short num = (short)720175105;
			if (num != 0)
			{
			}
			num = (short)257949696;
			switch (num)
			{
			default:
			{
				num = (short)1255014402;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfilesRecset radioProfilesRecset;
					switch (num2)
					{
					case 0:
						if (radioProfilesRecset != null)
						{
							num = (short)2119172099;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
						if (this.GetCodeplugMiddleVersion() < 1)
						{
							num = (short)2141126662;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_8E;
						}
						continue;
					case 3:
					{
						num = (short)1459159040;
						short num3 = num;
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = radioProfilesRecset.GetEnumerator();
						num = (short)156631044;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						try
						{
							num = (short)643694595;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings;
								global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.LabtoolRAD_PROF_CDA labtoolRAD_PROF_CDA;
								switch (num2)
								{
								case 0:
									goto IL_4F1;
								case 1:
									if (audioSettings != null)
									{
										num = (short)1560674308;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 2:
									goto IL_384;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_106;
									}
									continue;
								case 4:
									num = (short)1225654281;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)202768390;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
									audioSettings = null;
									labtoolRAD_PROF_CDA = null;
									global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator2 = acpFeatureNode.FeatureSectionsCollection.GetEnumerator();
									num = (short)799277063;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									num = (short)131727360;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									try
									{
										num = (short)749928451;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												goto IL_312;
											case 1:
												goto IL_24D;
											case 2:
												num = (short)948830208;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 3:
												switch (0)
												{
												case 0:
													goto IL_1D3;
												}
												continue;
											case 4:
											{
												global::AcpCommonLib.IAcpFeatureSection acpFeatureSection;
												if (acpFeatureSection.GetType().Equals(typeof(global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.LabtoolRAD_PROF_CDA)))
												{
													num = (short)89653256;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 5:
											{
												global::AcpCommonLib.IAcpFeatureSection acpFeatureSection;
												if (acpFeatureSection.GetType().Equals(typeof(global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings)))
												{
													num = (short)1116078086;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_24D;
											}
											case 6:
											{
												global::AcpCommonLib.IAcpFeatureSection acpFeatureSection;
												audioSettings = (acpFeatureSection as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings);
												num = (short)145883137;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 8:
											{
												global::AcpCommonLib.IAcpFeatureSection acpFeatureSection;
												labtoolRAD_PROF_CDA = (acpFeatureSection as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.LabtoolRAD_PROF_CDA);
												num = (short)2103640071;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 9:
											{
												global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator2;
												if (!enumerator2.MoveNext())
												{
													num = (short)1886715906;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::AcpCommonLib.IAcpFeatureSection acpFeatureSection = enumerator2.Current;
												num = (short)328794117;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											}
											goto IL_1D3;
											IL_24D:
											num = (short)957480964;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_298:
											num = (short)255787017;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_1D3:
											goto IL_298;
										}
										IL_312:
										goto IL_147;
									}
									finally
									{
										num = (short)630521856;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator2;
											switch (num2)
											{
											case 0:
												switch (0)
												{
												case 0:
													goto IL_349;
												}
												continue;
											case 1:
												goto IL_381;
											case 2:
												enumerator2.Dispose();
												num = (short)240844801;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											IL_349:
											if (enumerator2 == null)
											{
												break;
											}
											num = (short)65601538;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_381:;
									}
									goto IL_384;
									IL_147:
									num = (short)1913651201;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
									if (labtoolRAD_PROF_CDA != null)
									{
										num = (short)404553730;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								IL_10B:
								num = (short)837484549;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_106:
								goto IL_10B;
								IL_384:
								audioSettings.AGCGainControlOutputAccessory_42644.Value = audioSettings.RadProfAudioSettingsOutput_A8679.Value;
								audioSettings.AGCGainControlTotalAccessory_42645.Value = audioSettings.RadProfAudioSettingsTotal_A9394.Value;
								audioSettings.RadioProfileAudioSettingsDigitalAnalogBalanceAccessory_42661.Value = audioSettings.RadioProfileAudioSettingsTxDigitalAnalogBalance_A37715.Value;
								audioSettings.AnalogHighFrequencyBandAccessory_42650.Value = audioSettings.RadProfAudioSettingsAnalog_A7438.Value;
								audioSettings.DigitalHighFrequencyBandAccessory_42655.Value = audioSettings.RadProfAudioSettingsDigital_A7850.Value;
								audioSettings.SecurenetHighFrequencyBandAccessory_42660.Value = audioSettings.RadProfAudioSettingsSecurenet_A9097.Value;
								audioSettings.AnalogLowFrequencyBandAccessory_42647.Value = labtoolRAD_PROF_CDA.RadProfLabtoolAnalogBassControl_A19506.Value;
								audioSettings.DigitalLowFrequencyBandAccessory_42652.Value = labtoolRAD_PROF_CDA.RadProfLabtoolDigitalBassControl_A19507.Value;
								audioSettings.SecurenetLowFrequencyBandAccessory_42657.Value = labtoolRAD_PROF_CDA.RadProfLabtoolSecurenetBassControl_A19508.Value;
								num = (short)1619001352;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_4F1:
							return;
						}
						finally
						{
							num = (short)159645696;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_529;
									}
									continue;
								case 1:
									goto IL_561;
								case 2:
									enumerator.Dispose();
									num = (short)1033699329;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_529:
								if (enumerator != null)
								{
									num = (short)1711996930;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_561:
								num = (short)916311918;
								short num4 = num;
								num = (short)1119342446;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_529;
								default:
									goto IL_595;
								}
							}
							IL_595:
							num = (short)1161953280;
							if (num != 0)
							{
							}
						}
						goto IL_5AC;
					case 5:
						num = (short)442368007;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_5AC;
					case 7:
						if (this.GetCodeplugMainVersion() == 13)
						{
							num = (short)1969160200;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 8:
						num = (short)1145044993;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_8E:
					if (this.GetCodeplugMainVersion() >= 13)
					{
						num = (short)50200581;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_5AC:
					radioProfilesRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2077) as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfilesRecset);
					num = (short)994836480;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
			}
			}
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x0002685C File Offset: 0x00024A5C
		private void RefreshAudioEnhancementForConsolette()
		{
			int a_ = 8;
			short num = (short)934543360;
			switch (num)
			{
			default:
			{
				num = (short)1944256516;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfilesRecset radioProfilesRecset = global::AcpCommonLib.FeatureManager.GetFeature(2077) as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfilesRecset;
						num = (short)763953153;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfilesRecset radioProfilesRecset;
						if (radioProfilesRecset != null)
						{
							num = (short)86900738;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 2:
					{
						num = (short)124715008;
						short num3 = num;
						global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfilesRecset radioProfilesRecset;
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = radioProfilesRecset.GetEnumerator();
						num = (short)2104164359;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
						if (radioInformation != null)
						{
							num = (short)1564016645;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 4:
						switch (0)
						{
						case 0:
							goto IL_7B;
						}
						continue;
					case 5:
					{
						num = (short)1430061057;
						if (num != 0)
						{
						}
						global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
						string radInfoGeneralModelNumber_A8539Value = radioInformation.General.RadInfoGeneralModelNumber_A8539Value;
						num = (short)1774911497;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation = global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation;
						num = (short)1228013571;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						try
						{
							num = (short)1931411457;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_87C;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_23E;
									}
									continue;
								case 2:
									try
									{
										num = (short)1970995224;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												num = (short)1557069831;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 1:
												num = (short)911409180;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 2:
											{
												global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings;
												if (audioSettings.NoiseReductionGroupSettingAccessory_42585.Value == 3)
												{
													num = (short)372178962;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_4CE;
											}
											case 3:
											{
												global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings;
												if (audioSettings != null)
												{
													num = (short)1679491073;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 4:
											{
												global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator2;
												if (!enumerator2.MoveNext())
												{
													num = (short)679149582;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings = enumerator2.Current as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings;
												num = (short)535494659;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 5:
												num = (short)1176305683;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 6:
											{
												global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings;
												if (audioSettings.GainSensitivityGroupSettingAccessory_42610.Value == 0)
												{
													num = (short)1392508944;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 7:
											{
												global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings;
												if (audioSettings.NoiseReductionGroupSettingAccessory_42585.Value != 2)
												{
													num = (short)296222729;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_59E;
											}
											case 8:
											{
												global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings;
												audioSettings.GainSensitivityGroupSettingRadio_42608.Value = 4;
												num = (short)1953234964;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 9:
												num = (short)1262354434;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 10:
											{
												global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings;
												if (audioSettings.NoiseReductionGroupSettingAccessory_42585.Value != 0)
												{
													num = (short)276234240;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_59E;
											}
											case 11:
												goto IL_45C;
											case 12:
												goto IL_4CE;
											case 13:
											{
												global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings;
												audioSettings.GainSensitivityGroupSettingAccessory_42610.Value = 4;
												num = (short)1363476510;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 14:
												num = (short)1824194591;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 15:
											{
												global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings;
												if (!audioSettings.RadProfAudioSettingsAnalogAGC2_A7439.Value)
												{
													num = (short)654573581;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 16:
												num = (short)2023096335;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 17:
												num = (short)668467223;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 18:
												goto IL_59E;
											case 19:
											{
												global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings;
												if (!audioSettings.RadProfAudioSettingsAnalogAGC1_A7440.Value)
												{
													num = (short)1408499720;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_515;
											}
											case 20:
												goto IL_515;
											case 21:
												num = (short)37027873;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 22:
											{
												global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings;
												if (audioSettings.RadProfAudioSettingsInternalMicWindNoiseReductionLevelSelection_A22194.Value == 0)
												{
													num = (short)599851035;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_45C;
											}
											case 23:
											{
												global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings;
												if (audioSettings.NoiseReductionGroupSettingRadio_42584.Value == 3)
												{
													num = (short)1409155101;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_45C;
											}
											case 24:
												switch (0)
												{
												case 0:
													goto IL_357;
												}
												continue;
											case 25:
											{
												global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings;
												if (audioSettings.GainSensitivityGroupSettingRadio_42608.Value == 0)
												{
													num = (short)608763909;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_515;
											}
											case 26:
											{
												global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings;
												if (audioSettings.RadProfExternalMicWindNoiseReductionLevelSelection_A21511.Value == 0)
												{
													num = (short)310837280;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_4CE;
											}
											case 27:
											{
												global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings;
												audioSettings.NoiseReductionGroupSettingRadio_42584.Value = 4;
												num = (short)891093003;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 28:
											{
												global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings;
												if (audioSettings.NoiseReductionGroupSettingRadio_42584.Value != 0)
												{
													num = (short)1556807701;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_3D2;
											}
											case 29:
												goto IL_3D2;
											case 31:
												goto IL_7F0;
											case 32:
											{
												global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings;
												audioSettings.NoiseReductionGroupSettingAccessory_42585.Value = 4;
												num = (short)1139277836;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 33:
											{
												global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings;
												if (audioSettings.NoiseReductionGroupSettingRadio_42584.Value != 2)
												{
													num = (short)1219035153;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_3D2;
											}
											}
											goto IL_357;
											IL_3D2:
											num = (short)1029308438;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_45C:
											num = (short)1529479193;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_4CE:
											num = (short)306446342;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_515:
											num = (short)2141847562;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_59E:
											num = (short)1107492890;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_76F:
											num = (short)1288699908;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_357:
											goto IL_76F;
										}
										IL_7F0:
										break;
									}
									finally
									{
										num = (short)588513280;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator2;
											switch (num2)
											{
											case 0:
												switch (0)
												{
												case 0:
													goto IL_827;
												}
												continue;
											case 1:
												goto IL_85F;
											case 2:
												enumerator2.Dispose();
												num = (short)50135041;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											IL_827:
											if (enumerator2 == null)
											{
												break;
											}
											num = (short)999227394;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_85F:;
									}
									goto IL_862;
								case 3:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1007419396;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator2 = ((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current).FeatureSectionsCollection.GetEnumerator();
									num = (short)1251803138;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									goto IL_862;
								}
								IL_26C:
								num = (short)1220673539;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_23E:
								goto IL_26C;
								IL_862:
								num = (short)1245577216;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_87C:
							return;
						}
						finally
						{
							num = (short)982450176;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_8B4;
									}
									continue;
								case 1:
									goto IL_938;
								case 2:
								{
									enumerator.Dispose();
									num = (short)36656483;
									short num4 = num;
									num = (short)1652708707;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										continue;
									default:
										num = (short)1929445376;
										if (num != 0)
										{
										}
										num = (short)381878273;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_8B4:
								if (enumerator == null)
								{
									break;
								}
								num = (short)758317058;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_938:;
						}
						goto IL_93B;
					case 8:
					{
						string radInfoGeneralModelNumber_A8539Value;
						if (radInfoGeneralModelNumber_A8539Value.StartsWith(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("ꓧ\ud9e9\udceb", a_)))
						{
							num = (short)1450442752;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 9:
					{
						string radInfoGeneralModelNumber_A8539Value;
						if (radInfoGeneralModelNumber_A8539Value != null)
						{
							num = (short)1005256714;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 10:
						goto IL_93B;
					}
					IL_7B:
					if (this.GetCodeplugMainVersion() < 15)
					{
						num = (short)64028678;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_93B:
					num = (short)1616838664;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
			}
			}
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00027228 File Offset: 0x00025428
		public void SetActionTypeAfterUpgrade()
		{
			short num = (short)276824064;
			switch (num)
			{
			default:
			{
				num = (short)1918304268;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					bool flag;
					bool flag2;
					global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationRecset actionConsolidationRecset;
					global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
					bool flag3;
					global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
					switch (num2)
					{
					case 0:
						num = (short)915341327;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_AE;
					case 2:
						goto IL_421;
					case 3:
						try
						{
							num = (short)1427636231;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)1981743105;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									if (flag)
									{
										num = (short)1570963464;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)2037579780;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									num = (short)1592655877;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1110704130;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidation actionConsolidation = (global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidation)enumerator.Current;
									num = (short)1922891785;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									if (flag2)
									{
										num = (short)1417478150;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 5:
									goto IL_3AF;
								case 6:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidation actionConsolidation;
									actionConsolidation.General.RadioErgoConfigACActionType_A42871.SetValue(3);
									num = (short)808321034;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
									switch (0)
									{
									case 0:
										goto IL_239;
									}
									continue;
								case 8:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidation actionConsolidation;
									actionConsolidation.General.RadioErgoConfigACActionType_A42871.SetValue(1);
									num = (short)1241907211;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 9:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidation actionConsolidation;
									if (actionConsolidation.General.RadioErgoConfigACActionType_A42871.Value == 0)
									{
										num = (short)1496973312;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_32A:
								num = (short)1448214531;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_239:
								goto IL_32A;
							}
							IL_3AF:
							return;
						}
						finally
						{
							num = (short)642318336;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_3E7;
									}
									continue;
								case 1:
									goto IL_41E;
								case 2:
									enumerator.Dispose();
									num = (short)556728321;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_3E7:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1148977154;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_41E:;
						}
						goto IL_421;
					case 4:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = actionConsolidationRecset.GetEnumerator();
						num = (short)239140867;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						if (radioWide != null)
						{
							goto IL_1C6;
						}
						goto IL_AE;
					case 6:
					{
						num = (short)1078067200;
						short num3 = num;
						if (actionConsolidationRecset != null)
						{
							num = (short)1852047364;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 7:
						flag3 = false;
						goto IL_450;
					case 8:
						num = (short)390660107;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						if (radioInformation != null)
						{
							num = (short)1505165314;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_191;
					case 10:
					{
						if (radioWide.Labtool.RadWideLabtoolPAAlertCapability_A42944.Value)
						{
							num = (short)796065800;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1401593871;
						short num4 = num;
						num = (short)1070505999;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1C6;
						default:
							num = (short)948174848;
							if (num != 0)
							{
							}
							num = (short)1220083719;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 11:
						flag3 = radioInformation.Labtool.RadInfoLabtoolQ445FiregroundSupport_A8796.Value;
						goto IL_450;
					case 12:
						switch (0)
						{
						case 0:
							goto IL_89;
						}
						continue;
					case 13:
						num = (short)962592778;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						num = (short)1377959937;
						if (num != 0)
						{
						}
						flag2 = false;
						flag = false;
						radioInformation = (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation);
						num = (short)530645001;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						if (radioInformation != null)
						{
							num = (short)743505933;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AE;
					case 16:
						goto IL_191;
					}
					IL_89:
					if (global::ConstraintHelper.UtilityMack.IsPortable())
					{
						num = (short)132251662;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_AE:
					actionConsolidationRecset = (global::AcpCommonLib.FeatureManager.GetFeature(4008) as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationRecset);
					num = (short)1677721606;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_191:
					radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
					num = (short)1461452805;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1C6:
					num = (short)186843136;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_421:
					flag = radioInformation.Labtool.RadInfoLabtoolMissionCriticalGeofencing_A43013.Value;
					num = (short)1978662928;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_450:
					flag2 = flag3;
					num = (short)1280376833;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
			}
			}
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00027818 File Offset: 0x00025A18
		public void SyncActiveMicForBTPTT()
		{
			short num = (short)599523332;
			int num2 = (int)((global::System.IntPtr)num);
			global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide radioErgonomicsWide;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)2127101954;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					return;
				case 2:
					if (this.GetCodeplugMainVersion() < 15)
					{
						num = (short)352518149;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 3:
				{
					global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide = global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
					radioErgonomicsWide = (global::AcpCommonLib.FeatureManager.GetFeature(2033)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide);
					if (radioWide.Bluetooth.RadWideBluetoothActiveRSMInternalMicIfNotBtMic_A41576.Value)
					{
						num = (short)569049094;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					radioErgonomicsWide.Advanced.RadErgoWideAdvancedActiveMicForBTPTT_43051.SetValue(3);
					num = (short)672727041;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					switch (0)
					{
					case 0:
						goto IL_40;
					}
					continue;
				case 5:
					goto IL_1B8;
				case 6:
				{
					num = (short)1889297549;
					short num3 = num;
					num = (short)971269261;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1B8;
					default:
						goto IL_BF;
					}
					break;
				}
				}
				IL_40:
				num = (short)77463553;
				if (num != 0)
				{
				}
				if (global::ConstraintHelper.UtilityMack.IsPortable())
				{
					num = (short)228327424;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return;
				IL_1B8:
				num = (short)1581514755;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_BF:
			num = (short)1609826304;
			short num4 = num;
			num = (short)464257024;
			if (num != 0)
			{
			}
			radioErgonomicsWide.Advanced.RadErgoWideAdvancedActiveMicForBTPTT_43051.SetValue(2);
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00027A0C File Offset: 0x00025C0C
		private void RefreshPowerLevelForSRX2200()
		{
			short num = (short)985071616;
			switch (num)
			{
			default:
			{
				num = (short)361693225;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeNewBandPlanInner txPowerLevelsByFrequencyRangeNewBandPlanInner;
					global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeInner txPowerLevelsByFrequencyRangeInner;
					int num4;
					int num5;
					switch (num2)
					{
					case 0:
						goto IL_675;
					case 1:
						if (txPowerLevelsByFrequencyRangeNewBandPlanInner.TxPowerLevelsByFrequencyRangeNewBandPlanInnerSection != null)
						{
							num = (short)523304994;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2F4;
					case 2:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
						if (!radioWide.Labtool.RadWideLabtoolUltraLowPowerSoldierMacCapable_A41710.Value)
						{
							num = (short)487456795;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2F4;
					}
					case 3:
						goto IL_2F4;
					case 4:
						if (txPowerLevelsByFrequencyRangeInner != null)
						{
							num = (short)1099104274;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_316;
					case 5:
						goto IL_3D3;
					case 6:
						num = (short)962723852;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_316;
					case 8:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
						if (radioWide.TxPowerLevelsNewBandPlan != null)
						{
							num = (short)1681981440;
							short num3 = num;
							num = (short)426508324;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 9:
						goto IL_19A;
					case 10:
						num = (short)345636866;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
						if (radioWide.Labtool != null)
						{
							num = (short)1285619718;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 12:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
						if (radioWide.Labtool.RadWideLabtoolUltraLowPowerSoldierMacCapable_A41710 != null)
						{
							num = (short)627703843;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 13:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
						if (num4 >= radioWide.TransmitPowerLevels.EmbeddedRecset.Count)
						{
							num = (short)1781530667;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						txPowerLevelsByFrequencyRangeInner = (radioWide.TransmitPowerLevels.EmbeddedRecset[num4] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeInner);
						num = (short)228392964;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
						goto IL_19A;
					case 15:
						num = (short)1334050827;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
						if (num5 >= radioWide.TxPowerLevelsNewBandPlan.EmbeddedRecset.Count)
						{
							num = (short)1046675501;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						txPowerLevelsByFrequencyRangeNewBandPlanInner = (radioWide.TxPowerLevelsNewBandPlan.EmbeddedRecset[num5] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeNewBandPlanInner);
						num = (short)3932177;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
						if (txPowerLevelsByFrequencyRangeNewBandPlanInner != null)
						{
							num = (short)809107496;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2F4;
					case 18:
						num = (short)568721445;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
						if (radioWide.TransmitPowerLevels != null)
						{
							num = (short)1022361622;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_819;
					}
					case 20:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
						if (radioWide.TransmitPowerLevels.EmbeddedRecset != null)
						{
							num = (short)1865220134;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_819;
					}
					case 21:
						num5 = 0;
						num = (short)58785817;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						num = (short)6619156;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
						if (!radioWide.Labtool.RadWideLabtoolUltraLowPowerSoldierMacCapable_A41710.Value)
						{
							num = (short)1432289280;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_316;
					}
					case 24:
						if (!(global::CommonResources.MTFResources.P_7800_mhz.Trim() == txPowerLevelsByFrequencyRangeInner.TxPowerLevelsByFrequencyRangeInnerSection.RadWidePowerLevelBandFrequency_A41063.Value.Trim()))
						{
							num = (short)2079391776;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_675;
					case 25:
						goto IL_3D3;
					case 26:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
						if (radioWide != null)
						{
							num = (short)820379663;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 27:
						goto IL_5B7;
					case 28:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide = global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
						num = (short)1162936346;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 29:
						if (global::CommonResources.AcgResources.ID_UHF1.Trim() == txPowerLevelsByFrequencyRangeInner.TxPowerLevelsByFrequencyRangeInnerSection.RadWidePowerLevelBandFrequency_A41063.Value.Trim())
						{
							num = (short)508756010;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_316;
					case 30:
						num = (short)1058078744;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
						if (global::CommonResources.AcgResources.ID_UHF1.Trim() == txPowerLevelsByFrequencyRangeNewBandPlanInner.TxPowerLevelsByFrequencyRangeNewBandPlanInnerSection.RadWidePowerLevelBandFrequency_A41864.Value.Trim())
						{
							num = (short)932053002;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2F4;
					case 32:
						num = (short)1588068381;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
						if (!(global::CommonResources.MTFResources.P_7800_mhz.Trim() == txPowerLevelsByFrequencyRangeNewBandPlanInner.TxPowerLevelsByFrequencyRangeNewBandPlanInnerSection.RadWidePowerLevelBandFrequency_A41864.Value.Trim()))
						{
							num = (short)1741946924;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5B7;
					case 34:
						goto IL_628;
					case 35:
						num = (short)1702952979;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 36:
						num = (short)1565851687;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 37:
						if (txPowerLevelsByFrequencyRangeInner.TxPowerLevelsByFrequencyRangeInnerSection != null)
						{
							num = (short)1715863582;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_316;
					case 38:
						num4 = 0;
						num = (short)205914121;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 39:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
						if (radioWide.TxPowerLevelsNewBandPlan.EmbeddedRecset == null)
						{
							return;
						}
						num = (short)441379017;
						short num6 = num;
						num = (short)1964697801;
						switch ((num6 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_628;
						default:
							num = (short)679870464;
							if (num != 0)
							{
							}
							num = (short)1214709781;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 40:
						num = (short)496500737;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 41:
						switch (0)
						{
						case 0:
							goto IL_FE;
						}
						continue;
					case 42:
						num = (short)2038890519;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 43:
						goto IL_819;
					case 44:
						num = (short)1806172191;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 45:
						return;
					}
					IL_FE:
					if ((global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation).Labtool.RadInfoLabtoolProductModelIdentifier_A37178.Value == 8)
					{
						num = (short)228786204;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_19A:
					num = (short)370540557;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2F4:
					num5++;
					num = (short)1012662277;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_316:
					num4++;
					num = (short)1833435150;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3D3:
					num = (short)734003201;
					if (num != 0)
					{
					}
					num = (short)622198800;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5B7:
					txPowerLevelsByFrequencyRangeNewBandPlanInner.TxPowerLevelsByFrequencyRangeNewBandPlanInnerSection.RadWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41862.SetValue(23979);
					num = (short)983695363;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_628:
					num = (short)1965424673;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_675:
					txPowerLevelsByFrequencyRangeInner.TxPowerLevelsByFrequencyRangeInnerSection.RadWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41174.SetValue(23979);
					num = (short)79495175;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_819:
					num = (short)1581187080;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
			}
			}
		}

		// Token: 0x060000EB RID: 235 RVA: 0x0002829C File Offset: 0x0002649C
		private void SetControlHeadAliasList()
		{
			short num = (short)316866560;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_7B;
				}
				global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide radioErgonomicsWide;
				global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.ControlHeadAliasListInnerRecset controlHeadAliasListInnerRecset;
				for (;;)
				{
					IL_28:
					int num5;
					global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.ControlHeadAliasListInner controlHeadAliasListInner;
					switch (num2)
					{
					case 0:
					{
						int num3 = 0;
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.ListItem> enumerator = radioErgonomicsWide.ControlHead.RadErgoWideControlHeadExpectedNumofControlHeads_A7982.Items.GetEnumerator();
						num = (short)1664548880;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						if (!radioErgonomicsWide.ControlHead.RadErgoWideControlHeadExpectedNumofControlHeads_A7982.HiddenStatic)
						{
							num = (short)491651072;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 2:
						if (controlHeadAliasListInnerRecset != null)
						{
							num = (short)854392836;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 3:
						goto IL_279;
					case 4:
						num = (short)1430913025;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
					{
						num = (short)915537920;
						short num4 = num;
						int num3;
						if (controlHeadAliasListInnerRecset.Count >= num3)
						{
							num = (short)673316881;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						controlHeadAliasListInnerRecset.AddDefaultRecord();
						num5++;
						controlHeadAliasListInner = (controlHeadAliasListInnerRecset[num5 - 1] as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.ControlHeadAliasListInner);
						num = (short)1587085320;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						goto IL_279;
					case 7:
						goto IL_279;
					case 8:
						if (controlHeadAliasListInner == null)
						{
							num = (short)604897290;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)91357198;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						num = (short)1327824902;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						goto IL_339;
					case 11:
						goto IL_279;
					case 12:
					{
						if (radioErgonomicsWide == null)
						{
							return;
						}
						num = (short)950285861;
						short num6 = num;
						num = (short)1340487205;
						switch ((num6 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1DC;
						default:
							num = (short)1714946048;
							if (num != 0)
							{
							}
							num = (short)1830158349;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 13:
						num = (short)432013314;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						switch (num5)
						{
						case 1:
							controlHeadAliasListInner.ControlHeadAliasListInnerSection.RadErgoWideControlHeadControlHead1Alias_A7718.SetValue(global::CommonResources.MTFResources.Control_head_1);
							num = (short)997785611;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							controlHeadAliasListInner.ControlHeadAliasListInnerSection.RadErgoWideControlHeadControlHead1Alias_A7718.SetValue(global::CommonResources.MTFResources.Control_head_2);
							num = (short)1441857554;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							controlHeadAliasListInner.ControlHeadAliasListInnerSection.RadErgoWideControlHeadControlHead1Alias_A7718.SetValue(global::CommonResources.MTFResources.Control_head_3);
							num = (short)1508179971;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							goto IL_49F;
						default:
							num = (short)13238281;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 15:
						goto IL_279;
					case 16:
						goto IL_1DC;
					case 17:
						goto IL_2E0;
					case 18:
						goto IL_279;
					}
					goto IL_7B;
					IL_279:
					num = (short)1621098501;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_49F:
					controlHeadAliasListInner.ControlHeadAliasListInnerSection.RadErgoWideControlHeadControlHead1Alias_A7718.SetValue(global::CommonResources.MTFResources.Control_head_4);
					num = (short)1899233287;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1DC:
					try
					{
						num = (short)1532362754;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								num = (short)711589891;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
							{
								int num3;
								num3++;
								num = (short)354353158;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 2:
								switch (0)
								{
								case 0:
									goto IL_381;
								}
								continue;
							case 3:
								goto IL_42D;
							case 4:
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.ListItem> enumerator;
								if (enumerator.Current.ItemVisibility)
								{
									num = (short)744095745;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 5:
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.ListItem> enumerator;
								if (!enumerator.MoveNext())
								{
									num = (short)269549568;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)449708036;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							IL_3BE:
							num = (short)2060320773;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_381:
							goto IL_3BE;
						}
						IL_42D:
						goto IL_541;
					}
					finally
					{
						num = (short)722141184;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.ListItem> enumerator;
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_464;
								}
								continue;
							case 1:
								enumerator.Dispose();
								num = (short)872677378;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_49C;
							}
							IL_464:
							if (enumerator == null)
							{
								break;
							}
							num = (short)2039480321;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_49C:;
					}
					goto IL_49F;
					IL_541:
					num5 = controlHeadAliasListInnerRecset.Count;
					num = (short)536215567;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_2E0:
				return;
				IL_339:
				num = (short)1634861057;
				if (num != 0)
				{
				}
				return;
				IL_7B:
				radioErgonomicsWide = (global::AcpCommonLib.FeatureManager.GetFeature(2033)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide);
				controlHeadAliasListInnerRecset = (radioErgonomicsWide.ControlHead.EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.ControlHeadAliasListInnerRecset);
				num = (short)193003532;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00028848 File Offset: 0x00026A48
		private void SetGCAITable()
		{
			int a_ = 14;
			short num = (short)1293942784;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_AB;
				}
				global::AcpCommonLib.IAcpRecordset feature;
				for (;;)
				{
					IL_30:
					int num3;
					switch (num2)
					{
					case 0:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.GCAIVIPInnerRecset gcaivipinnerRecset;
						if (gcaivipinnerRecset != null)
						{
							num = (short)840826884;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 1:
						goto IL_294;
					case 2:
						goto IL_294;
					case 3:
						num3 = 0;
						num = (short)430506005;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						num = (short)438042651;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
					{
						if (num3 != 0)
						{
							num = (short)2076770326;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.GCAIVIPInner gcaivipinner;
						gcaivipinner.GCAIVIPInnerSection.RadioGCAIVipName_42622.SetValue(global::CommonResources.MTFResources.P_1);
						gcaivipinner.GCAIVIPInnerSection.GCAIVipInputBCO_42620.SetValue(224);
						gcaivipinner.GCAIVIPInnerSection.RadioGCAIVIPKey_42621.SetValue(string.Format(global::CommonResources.AppResources.GCAI_VIP_ID, global::PreEmptive.SoS.Runtime.FixedLengthStream.b("\udfed", a_)));
						num = (short)1051000833;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPs radioVIPs = feature[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPs;
						num = (short)1984561178;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						return;
					case 8:
						goto IL_4E3;
					case 9:
						if (feature != null)
						{
							num = (short)669712407;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 10:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPs radioVIPs;
						if (radioVIPs.GCAI != null)
						{
							num = (short)367001628;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 11:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.GCAIVIPInnerRecset gcaivipinnerRecset;
						if (num3 >= gcaivipinnerRecset.Count)
						{
							num = (short)804716544;
							short num4 = num;
							num = (short)1054408711;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.GCAIVIPInner gcaivipinner = gcaivipinnerRecset[num3] as global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.GCAIVIPInner;
						num = (short)614072325;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPs radioVIPs;
						if (radioVIPs.GCAI.EmbeddedRecset != null)
						{
							num = (short)2127101976;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 13:
						num = (short)863109145;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.GCAIVIPInnerRecset gcaivipinnerRecset;
						if (gcaivipinnerRecset.Count < 2)
						{
							gcaivipinnerRecset.AddDefaultRecord();
							num = (short)288882696;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1329567034;
						short num5 = num;
						num = (short)1204983098;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_150;
						default:
							num = (short)1720844288;
							if (num != 0)
							{
							}
							num = (short)2014511107;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 15:
						if (feature.Count > 0)
						{
							num = (short)784990214;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 16:
						goto IL_398;
					case 17:
						goto IL_294;
					case 18:
					{
						num = (short)1414987777;
						if (num != 0)
						{
						}
						if (num3 != 1)
						{
							num = (short)29163540;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.GCAIVIPInner gcaivipinner;
						gcaivipinner.GCAIVIPInnerSection.RadioGCAIVipName_42622.SetValue(global::CommonResources.MTFResources.P_2);
						gcaivipinner.GCAIVIPInnerSection.GCAIVipInputBCO_42620.SetValue(225);
						gcaivipinner.GCAIVIPInnerSection.RadioGCAIVIPKey_42621.SetValue(string.Format(global::CommonResources.AppResources.GCAI_VIP_ID, global::PreEmptive.SoS.Runtime.FixedLengthStream.b("\udced", a_)));
						num = (short)1715208209;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 19:
						num = (short)1359151114;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						goto IL_150;
					case 21:
						goto IL_398;
					case 22:
						num = (short)2130444306;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						num = (short)1708392463;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPs radioVIPs;
						global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.GCAIVIPInnerRecset gcaivipinnerRecset = radioVIPs.GCAI.EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.GCAIVIPInnerRecset;
						num = (short)1124990976;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 25:
						goto IL_4E3;
					case 26:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPs radioVIPs;
						if (radioVIPs != null)
						{
							num = (short)1896087571;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 27:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.GCAIVIPInnerRecset gcaivipinnerRecset;
						if (gcaivipinnerRecset.Count < 2)
						{
							num = (short)1919352845;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 28:
						num = (short)1832517644;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_AB;
					IL_150:
					num = (short)2076639234;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_294:
					num3++;
					num = (short)1390542864;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_398:
					num = (short)111345675;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4E3:
					num = (short)556466190;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_AB:
				feature = global::AcpCommonLib.FeatureManager.GetFeature(2125);
				num = (short)1214971913;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00028E10 File Offset: 0x00027010
		private void RefreshDynChannelName()
		{
			int a_ = 19;
			short num = (short)742457344;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_63;
				}
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
				for (;;)
				{
					IL_30:
					global::AcpCommonLib.IAcpRecordset acpRecordset;
					switch (num2)
					{
					case 0:
						goto IL_DA;
					case 1:
						goto IL_DA;
					case 2:
						if (acpRecordset != null)
						{
							num = (short)50003971;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 3:
					{
						num = (short)499777536;
						short num3 = num;
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = ((global::AcpBusinessLayer.Recordset)acpRecordset).GetEnumerator();
						num = (short)2096889864;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
						{
							num = (short)486080521;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5FC;
					case 5:
						if (radioWide != null)
						{
							num = (short)1038286854;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 6:
						num = (short)1230897159;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (radioWide.Labtool.RadWideLabtoolDynamicZoneScanCapability_42749.Value)
						{
							num = (short)196018177;
							if (num != 0)
							{
							}
							num = (short)611319818;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 8:
						try
						{
							num = (short)511901700;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerRecset channelAssignmentListInnerRecset;
								switch (num2)
								{
								case 0:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment;
									channelAssignmentListInnerRecset = (zoneChannelAssignment.Channels.EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerRecset);
									num = (short)984875013;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									goto IL_58C;
								case 2:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)388759555;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment = (global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment)enumerator.Current;
									num = (short)1932263433;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									goto IL_574;
								case 4:
									switch (0)
									{
									case 0:
										goto IL_243;
									}
									continue;
								case 5:
									if (channelAssignmentListInnerRecset != null)
									{
										num = (short)1646657543;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_319;
								case 6:
									try
									{
										num = (short)1503592451;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 1:
											{
												global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner;
												channelAssignmentListInner.ChannelAssignmentListInnerSection.ZnChanCfgChannelsChannelName_A7659.SetValue(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("폲", a_));
												num = (short)957677575;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 2:
											{
												global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
												if (!enumerator2.MoveNext())
												{
													num = (short)1787297798;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner = (global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner)enumerator2.Current;
												num = (short)362283013;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 3:
												switch (0)
												{
												case 0:
													goto IL_400;
												}
												continue;
											case 4:
												goto IL_502;
											case 5:
											{
												global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner;
												if (!channelAssignmentListInner.ChannelAssignmentListInnerSection.ChannelsActiveChannel.UIValue)
												{
													num = (short)161611777;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_48F;
											}
											case 6:
												num = (short)1237647364;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 7:
												goto IL_48F;
											}
											IL_452:
											num = (short)787152898;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_400:
											goto IL_452;
											IL_48F:
											int num4;
											num4++;
											num = (short)408748032;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_502:
										goto IL_319;
									}
									finally
									{
										num = (short)1749417985;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
											switch (num2)
											{
											case 0:
												goto IL_571;
											case 1:
												switch (0)
												{
												case 0:
													goto IL_539;
												}
												continue;
											case 2:
												enumerator2.Dispose();
												num = (short)1044054016;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											IL_539:
											if (enumerator2 == null)
											{
												break;
											}
											num = (short)751697922;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_571:;
									}
									goto IL_574;
								case 7:
								{
									num = (short)1564311081;
									short num5 = num;
									num = (short)1522040361;
									switch ((num5 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
									{
										num = (short)861536256;
										if (num != 0)
										{
										}
										int num4 = 1;
										global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2 = channelAssignmentListInnerRecset.GetEnumerator();
										num = (short)2057437190;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									break;
								}
								case 9:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment;
									if (zoneChannelAssignment.Zone.ZnChanCfgZoneDynamicZoneEnable_A41257.Value)
									{
										num = (short)1916010496;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_2D6:
								num = (short)928579586;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_243:
								goto IL_2D6;
								IL_319:
								channelAssignmentListInnerRecset.RefreshKeyMap();
								num = (short)1474428936;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_574:
								num = (short)1838612481;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_58C:
							return;
						}
						finally
						{
							num = (short)1152253953;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									goto IL_5F9;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_5C4;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)2141519872;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_5C4:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1922367490;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_5F9:;
						}
						goto IL_5FC;
					case 9:
						acpRecordset = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(2051);
						num = (short)1047134209;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						acpRecordset = null;
						num = (short)1193213956;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_63;
					IL_DA:
					num = (short)1308557314;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5FC:
					acpRecordset = global::AcpCommonLib.FeatureManager.GetFeature(2051);
					num = (short)551616512;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_63:
				radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
				num = (short)357695493;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x060000EE RID: 238 RVA: 0x000294A4 File Offset: 0x000276A4
		private void RefreshBroadbandFields()
		{
			short num = (short)1907097600;
			switch (num)
			{
			default:
			{
				num = (short)1328611328;
				short num2 = num;
				num = (short)1771962379;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
					bool flag;
					global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide dataWide;
					global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesRecset dataProfilesRecset;
					switch (num3)
					{
					case 0:
						return;
					case 1:
						try
						{
							num = (short)650051595;
							num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
								switch (num3)
								{
								case 0:
									if (dataProfiles.General.DataProfGeneralDataProfileType_A21320 != 3)
									{
										num = (short)1338900492;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3B1;
								case 1:
									num = (short)1742602250;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									num = (short)2138046464;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									if (dataProfiles.General.DataProfGeneralDataProfileType_A21320 != 4)
									{
										num = (short)305070085;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3B1;
								case 4:
									goto IL_3B1;
								case 5:
									num = (short)983040007;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									if (dataProfiles.LTE.DataProfLTEEnabled_A42075.Value)
									{
										num = (short)2077556738;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 7:
									if (dataProfiles.General.DataProfGeneralDataProfileType_A21320 == 2)
									{
										num = (short)1368784900;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 9:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1008402433;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									dataProfiles = (enumerator.Current as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles);
									num = (short)104595462;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 10:
									goto IL_3F8;
								case 11:
									switch (0)
									{
									case 0:
										goto IL_240;
									}
									continue;
								case 12:
									num = (short)2101280771;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_242:
								num = (short)894894089;
								num3 = (int)((global::System.IntPtr)num);
								continue;
								IL_240:
								goto IL_242;
								IL_3B1:
								dataProfiles.LTE.DataProfBroadbandSource_A42858.SetValue(1);
								num = (short)190578696;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_3F8:
							goto IL_14F;
						}
						finally
						{
							num = (short)22806529;
							num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num3)
								{
								case 0:
									goto IL_4B7;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_42F;
									}
									continue;
								case 2:
								{
									enumerator.Dispose();
									num = (short)1785940612;
									short num4 = num;
									num = (short)57494148;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_436;
									default:
										num = (short)2140471296;
										if (num != 0)
										{
										}
										num = (short)579665920;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								goto IL_42F;
								IL_436:
								num = (short)36831234;
								num3 = (int)((global::System.IntPtr)num);
								continue;
								IL_42F:
								if (enumerator != null)
								{
									goto IL_436;
								}
								break;
							}
							IL_4B7:;
						}
						goto IL_4BA;
					case 2:
						goto IL_54B;
					case 3:
						goto IL_54B;
					case 4:
						flag = radioInformation.Labtool.RadInfoLabtoolLTEOperation_A41923.Value;
						num = (short)263061516;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (dataWide != null)
						{
							num = (short)1261764614;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 6:
						goto IL_4BA;
					case 7:
						if (radioInformation != null)
						{
							num = (short)494927876;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_585;
					case 8:
						if (dataProfilesRecset != null && flag)
						{
							num = (short)87621642;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_14F;
					case 9:
						dataProfilesRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2054) as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesRecset);
						radioInformation = (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation);
						dataWide = (global::AcpCommonLib.FeatureManager.GetFeature(2028)[0] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide);
						num = (short)640286722;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = dataProfilesRecset.GetEnumerator();
						num = (short)855048193;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						switch (0)
						{
						case 0:
							goto IL_A1;
						}
						continue;
					case 12:
						num = (short)2014445569;
						if (num != 0)
						{
						}
						goto IL_585;
					}
					IL_A1:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugConfigurationMode)
					{
						num = (short)1697513481;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					dataProfilesRecset = (global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(2054) as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesRecset);
					radioInformation = (global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation);
					dataWide = (global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(2028)[0] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide);
					num = (short)318636035;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_14F:
					num = (short)1532035077;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_4BA:
					dataWide.General.DataWideGeneralBroadbandCheckbackTime_A42862.SetValue(dataWide.LTE.DataWideLTELTECheckbackTime_A42205.Value);
					num = (short)472776704;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_54B:
					flag = false;
					num = (short)1485307911;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_585:
					num = (short)1154613256;
					num3 = (int)((global::System.IntPtr)num);
				}
				return;
			}
			}
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00029A94 File Offset: 0x00027C94
		private void RefreshUserSelectablePL()
		{
			short num = (short)1324548096;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_72;
				}
				global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityRecset conventionalPersonalityRecset;
				global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInnerRecset frequencyOptionsInnerRecset;
				for (;;)
				{
					IL_27:
					num = (short)1493237760;
					short num3 = num;
					switch (num2)
					{
					case 0:
						goto IL_F9;
					case 1:
					{
						num = (short)639631361;
						if (num != 0)
						{
						}
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = conventionalPersonalityRecset.GetEnumerator();
						num = (short)714473478;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
					{
						num = (short)769078016;
						short num4 = num;
						num = (short)1727804160;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_F9;
						default:
							num = (short)1106903040;
							if (num != 0)
							{
							}
							if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugConfigurationMode)
							{
								num = (short)1612382208;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							conventionalPersonalityRecset = (global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(2059) as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityRecset);
							num = (short)1172832260;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
						if (conventionalPersonalityRecset != null)
						{
							num = (short)1982070785;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 4:
						goto IL_4F8;
					case 5:
						goto IL_4F8;
					case 6:
						try
						{
							num = (short)1530593283;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_432;
								case 1:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality = enumerator.Current as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality;
									frequencyOptionsInnerRecset = (conventionalPersonality.Features.Parent[10148].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInnerRecset);
									if (conventionalPersonality != null)
									{
										num = (short)1775828992;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									num = (short)1247674376;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_148;
									}
									continue;
								case 4:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)828243970;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1253572609;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									try
									{
										num = (short)1680474114;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												num = (short)1863647235;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 1:
											{
												global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner frequencyOptionsInner;
												if (frequencyOptionsInner.FrequencyOptionsInnerSection.CnvPerConventionalChannelOptionsUserSelectablePLMPL_A9606.Value)
												{
													num = (short)581894149;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 2:
												switch (0)
												{
												case 0:
													goto IL_261;
												}
												continue;
											case 3:
											{
												global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner frequencyOptionsInner;
												if (frequencyOptionsInner.FrequencyOptionsInnerSection.CnvPerConventionalChannelOptionsUserSelectablePLMPLEnhance_43029.Value == 0)
												{
													num = (short)1928396807;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 4:
												num = (short)812580874;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 5:
											{
												global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner frequencyOptionsInner;
												frequencyOptionsInner.FrequencyOptionsInnerSection.CnvPerConventionalChannelOptionsUserSelectablePLMPLEnhance_43029.SetValue(7);
												num = (short)1636827145;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 6:
											{
												global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner frequencyOptionsInner;
												if (frequencyOptionsInner != null)
												{
													num = (short)240123904;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 7:
												num = (short)1521090561;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 8:
											{
												global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
												if (!enumerator2.MoveNext())
												{
													num = (short)537460740;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner frequencyOptionsInner = (global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner)enumerator2.Current;
												num = (short)1520828422;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 10:
												goto IL_3C0;
											}
											IL_369:
											num = (short)1582235656;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_261:
											goto IL_369;
										}
										IL_3C0:
										break;
									}
									finally
									{
										num = (short)677838848;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
											switch (num2)
											{
											case 0:
												switch (0)
												{
												case 0:
													goto IL_3F8;
												}
												continue;
											case 1:
												enumerator2.Dispose();
												num = (short)13369346;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 2:
												goto IL_42F;
											}
											IL_3F8:
											if (enumerator2 == null)
											{
												break;
											}
											num = (short)228196353;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_42F:;
									}
									goto IL_432;
								case 6:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2 = frequencyOptionsInnerRecset.GetEnumerator();
									num = (short)1615462405;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
									if (frequencyOptionsInnerRecset != null)
									{
										num = (short)902889478;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 8:
									goto IL_487;
								}
								IL_14D:
								num = (short)1765867524;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_148:
								goto IL_14D;
								IL_432:
								num = (short)132644871;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_487:
							return;
						}
						finally
						{
							num = (short)1971781632;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_4BE;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)1197670402;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_4F5;
								}
								IL_4BE:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1917911041;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_4F5:;
						}
						goto IL_4F8;
					}
					goto IL_72;
					IL_F9:
					conventionalPersonalityRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2059) as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityRecset);
					num = (short)372834309;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4F8:
					num = (short)1201143811;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_72:
				conventionalPersonalityRecset = null;
				frequencyOptionsInnerRecset = null;
				num = (short)770506754;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x0002A0B4 File Offset: 0x000282B4
		private void RefreshActionConsolidation()
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			short num2;
			int num3;
			global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationRecset actionConsolidationRecset;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_4D;
				case 1:
				{
					num2 = (short)1174536193;
					if (num2 != 0)
					{
					}
					if (num3 >= actionConsolidationRecset.Count)
					{
						goto IL_C2;
					}
					global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInnerSection consolidatedActionsInnerSection = ((actionConsolidationRecset[num3][10615].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInnerRecset).TemplateNode as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInner).ConsolidatedActionsInnerSection;
					consolidatedActionsInnerSection.RadioErgoConfigACGeneralIndex_A36591.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationConstraints.ConActionTypeIsGeneralOrExitOrControlOrInvalidSim);
					consolidatedActionsInnerSection.RadioErgoConfigACGeneralZone_A36592.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationConstraints.ConActionTypeIsGeneralOrControlOrInvalidSim);
					consolidatedActionsInnerSection.RadioErgoConfigACGeneralChannel_A36593.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationConstraints.ConActionTypeIsGeneralOrControlOrInvalidSim);
					consolidatedActionsInnerSection.RadioErgoConfigACGeneralTEXTMESSAGE_42913.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationConstraints.ConActionTypeIsGeneralOrExit);
					consolidatedActionsInnerSection.RadioErgoConfigACGeneralTxPowerChange__42916.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationConstraints.ConActionTypeIsGeneral);
					consolidatedActionsInnerSection.RadioErgoConfigACGeneralMuteSSA__42917.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationConstraints.ConActionTypeIsGeneral);
					consolidatedActionsInnerSection.CalculateVisibility();
					num3++;
					num2 = (short)1832648707;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					return;
				case 3:
				{
					num2 = (short)1842628757;
					short num4 = num2;
					num2 = (short)915359893;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_C2;
					default:
						num2 = (short)31719424;
						if (num2 != 0)
						{
						}
						goto IL_4D;
					}
					break;
				}
				}
				goto IL_20;
				IL_4D:
				num2 = (short)1335492608;
				short num5 = num2;
				num2 = (short)1959657473;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_C2:
				num2 = (short)1474691074;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_20:
			actionConsolidationRecset = (global::AcpCommonLib.FeatureManager.GetFeature(4008) as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationRecset);
			num3 = 0;
			num2 = (short)1639907328;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x0002A2C4 File Offset: 0x000284C4
		private void RefreshToneSignalingList()
		{
			switch (0)
			{
			case 0:
				goto IL_44;
			}
			short num;
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityRecset conventionalPersonalityRecset;
			for (;;)
			{
				IL_0A:
				num = (short)161284097;
				if (num != 0)
				{
				}
				int num2;
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
				switch (num2)
				{
				case 0:
					goto IL_B8;
				case 1:
					goto IL_29F;
				case 2:
					try
					{
						num = (short)1648230402;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1109983235;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality = enumerator.Current as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality;
								num = (short)863043585;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 1:
							{
								global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
								if (conventionalPersonality != null)
								{
									num = (short)475463685;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 2:
								switch (0)
								{
								case 0:
									goto IL_146;
								}
								continue;
							case 3:
								num = (short)1449328646;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 5:
							{
								global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
								conventionalPersonality.RAC.CnvPerRACCodeType1_A7680.CalculateApplicability();
								conventionalPersonality.RAC.CnvPerRACCodeType1_A7680.CalculateValidity();
								conventionalPersonality.RAC.CnvPerRACCodeType2_A8817.CalculateApplicability();
								conventionalPersonality.RAC.CnvPerRACCodeType2_A8817.CalculateValidity();
								num = (short)36438020;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 6:
								goto IL_232;
							}
							IL_148:
							num = (short)96993280;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_146:
							goto IL_148;
						}
						IL_232:
						return;
					}
					finally
					{
						num = (short)1982595072;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_268;
								}
								continue;
							case 1:
								enumerator.Dispose();
								num = (short)154468354;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_29C;
							}
							IL_268:
							if (enumerator == null)
							{
								break;
							}
							num = (short)359530497;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_29C:;
					}
					goto IL_29F;
				}
				goto IL_44;
				IL_29F:
				enumerator = conventionalPersonalityRecset.GetEnumerator();
				num = (short)1790574594;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_B8:
			if (conventionalPersonalityRecset != null)
			{
				goto IL_BE;
			}
			return;
			IL_44:
			num = (short)1908195084;
			short num3 = num;
			num = (short)752598796;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_BE:
				num = (short)565248000;
				short num4 = num;
				num = (short)1398603777;
				int num2 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}
			default:
			{
				num = (short)656670720;
				if (num != 0)
				{
				}
				conventionalPersonalityRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2059) as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityRecset);
				num = (short)1327431680;
				int num2 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}
			}
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x0002A5B0 File Offset: 0x000287B0
		private void FixPassword()
		{
			short num = (short)946339840;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
				switch (0)
				{
				case 0:
					break;
				default:
					for (;;)
					{
						IL_27:
						global::Motorola.MackinawCPS.CoreFeatures.DataWide.ConfiguredNetworksListInnerRecset configuredNetworksListInnerRecset;
						global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide dataWide;
						switch (num2)
						{
						case 0:
							if (configuredNetworksListInnerRecset.HiddenStatic)
							{
								num = (short)1199243276;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_16E;
						case 1:
							if (!radioWide.UserInformationAndPasswords.RadWideUserInformationandPINPassword_41303.Valid)
							{
								num = (short)1361641474;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_4D9;
						case 2:
							goto IL_388;
						case 3:
							num = (short)161349641;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
						{
							num = (short)849215488;
							short num3 = num;
							if (!radioWide.UserInformationAndPasswords.RadWideUserInformationandPINPassword_41303.HiddenStatic)
							{
								goto IL_4D9;
							}
							num = (short)1956968408;
							short num4 = num;
							num = (short)1201666008;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_AE;
							default:
								num = (short)154599424;
								if (num != 0)
								{
								}
								num = (short)2100822023;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 5:
							goto IL_4D9;
						case 6:
							dataWide.ExternalDataModem.DataWideDataModemPassword_A42848.SetValue(dataWide.ExternalDataModem.DataWideDataModemPassword_A42848.DefaultValue);
							dataWide.ExternalDataModem.DataWideDataModemPassword_A42848.CalculateValidity();
							num = (short)1865285643;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							num = (short)645791745;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
							if (dataWide.ExternalDataModem.DataWideDataModemPassword_A42848.HiddenStatic)
							{
								num = (short)308674563;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						case 9:
							if (!dataWide.ExternalDataModem.DataWideDataModemPassword_A42848.Valid)
							{
								num = (short)1597898758;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						case 10:
							try
							{
								num = (short)622788610;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
									{
										global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
										if (!enumerator.MoveNext())
										{
											num = (short)1796866051;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Motorola.MackinawCPS.CoreFeatures.DataWide.ConfiguredNetworksListInner configuredNetworksListInner = enumerator.Current as global::Motorola.MackinawCPS.CoreFeatures.DataWide.ConfiguredNetworksListInner;
										configuredNetworksListInner.ConfiguredNetworksListInnerSection.DataWideWiFiNetworkEncryptedNetworkPassword_42517.CalculateValidity();
										num = (short)1436090373;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 2:
										switch (0)
										{
										case 0:
											goto IL_20A;
										}
										continue;
									case 3:
										num = (short)1793916934;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 4:
									{
										global::Motorola.MackinawCPS.CoreFeatures.DataWide.ConfiguredNetworksListInner configuredNetworksListInner;
										configuredNetworksListInner.ConfiguredNetworksListInnerSection.DataWideWiFiNetworkEncryptedNetworkPassword_42517.SetValue(configuredNetworksListInner.ConfiguredNetworksListInnerSection.DataWideWiFiNetworkEncryptedNetworkPassword_42517.DefaultValue);
										configuredNetworksListInner.ConfiguredNetworksListInnerSection.DataWideWiFiNetworkEncryptedNetworkPassword_42517.CalculateValidity();
										num = (short)1806893057;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 5:
									{
										global::Motorola.MackinawCPS.CoreFeatures.DataWide.ConfiguredNetworksListInner configuredNetworksListInner;
										if (!configuredNetworksListInner.ConfiguredNetworksListInnerSection.DataWideWiFiNetworkEncryptedNetworkPassword_42517.Valid)
										{
											num = (short)310312964;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 6:
										goto IL_315;
									}
									IL_20C:
									num = (short)1994588160;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_20A:
									goto IL_20C;
								}
								IL_315:
								goto IL_16E;
							}
							finally
							{
								num = (short)989462528;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									switch (num2)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_34D;
										}
										continue;
									case 1:
										enumerator.Dispose();
										num = (short)1340932098;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										goto IL_385;
									}
									IL_34D:
									if (enumerator == null)
									{
										break;
									}
									num = (short)328269825;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_385:;
							}
							goto IL_388;
						case 11:
							return;
						case 12:
						{
							global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = configuredNetworksListInnerRecset.GetEnumerator();
							num = (short)1805582346;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						goto IL_62;
						IL_16E:
						dataWide.ExternalDataModem.DataWideDataModemPassword_A42848.CalculateValidity();
						num = (short)552009736;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_388:
						radioWide.UserInformationAndPasswords.RadWideUserInformationandPINPassword_41303.SetValue(radioWide.UserInformationAndPasswords.RadWideUserInformationandPINPassword_41303.DefaultValue);
						radioWide.UserInformationAndPasswords.RadWideUserInformationandPINPassword_41303.CalculateValidity();
						num = (short)879755269;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_4D9:
						dataWide = (global::AcpCommonLib.FeatureManager.GetFeature(2028)[0] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide);
						configuredNetworksListInnerRecset = (dataWide.WIFI.EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.DataWide.ConfiguredNetworksListInnerRecset);
						num = (short)1542717440;
						num2 = (int)((global::System.IntPtr)num);
					}
					return;
				}
				IL_62:
				num = (short)2097479681;
				if (num != 0)
				{
				}
				radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
				radioWide.UserInformationAndPasswords.RadWideUserInformationandPINPassword_41303.CalculateValidity();
				IL_AE:
				num = (short)1311768580;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x0002AB1C File Offset: 0x00028D1C
		private void UnpackFixupForFPPProtectedZonePassword()
		{
			switch (0)
			{
			case 0:
				goto IL_2C;
			}
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)1551433729;
					if (num2 != 0)
					{
					}
					goto IL_1A6;
				case 1:
					if (radioWide.Features.ZnChanCfgFPPProtectionFPPEnable_A8142)
					{
						num2 = (short)1748762629;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 2:
					if ((global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation).Labtool.RadInfoLabtoolQ53NonFEDFPPAndZoneClone_A8799)
					{
						num2 = (short)437257018;
						short num3 = num2;
						num2 = (short)1430455098;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1A6;
						case 1:
							break;
						default:
						{
							num2 = (short)1630470144;
							short num4 = num2;
							break;
						}
						}
						num2 = (short)990773248;
						if (num2 != 0)
						{
						}
						num2 = (short)2105409536;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 3:
					return;
				case 4:
					if (radioWide.UserInformationAndPasswords.RadWideUserInformationandPasswordsProtectedZonePassword_A8766 == string.Empty)
					{
						num2 = (short)877527046;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 5:
					radioWide.Features.ZnChanCfgFPPProtectionFPPEnable_A8142.Value = false;
					num2 = (short)966524931;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					num2 = (short)479789057;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_2C;
				IL_1A6:
				num2 = (short)1292763140;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_2C:
			radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
			num2 = (short)380239874;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x0002AD20 File Offset: 0x00028F20
		private void SynPreAmp()
		{
			int a_ = 17;
			switch (0)
			{
			case 0:
				goto IL_49;
			}
			int num;
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
			short num2;
			bool flag;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					radioWide.Features.RadWideFeaturePreAmpVHF_A42960.SetValue(radioWide.Features.RadWideAdvancedPreAmp_A8733.Value);
					num2 = (short)1355481098;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (global::ConstraintHelper.UtilityMack.IsMobile())
					{
						num2 = (short)1700593668;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 2:
					if (radioWide.Features.RadWideAdvancedPreAmp_A8733.Value != radioWide.Features.RadWideFeaturePreAmpUHF_A42962.Value)
					{
						num2 = (short)460259335;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 3:
					goto IL_2A6;
				case 4:
					num2 = (short)1440088070;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					if (radioWide != null)
					{
						num2 = (short)2028666889;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 6:
					if (!flag)
					{
						num2 = (short)1662517251;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 7:
					radioWide.Features.RadWideFeaturePreAmpUHF_A42962.SetValue(radioWide.Features.RadWideAdvancedPreAmp_A8733.Value);
					num2 = (short)323813384;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					return;
				case 9:
				{
					num2 = (short)1083780108;
					short num3 = num2;
					num2 = (short)385625100;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_2A6;
					default:
					{
						num2 = (short)1910964224;
						short num4 = num2;
						num2 = (short)201588736;
						if (num2 != 0)
						{
						}
						num2 = (short)1312882689;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 10:
					goto IL_123;
				case 11:
					if (radioWide.Features.RadWideAdvancedPreAmp_A8733.Value != radioWide.Features.RadWideFeaturePreAmpVHF_A42960.Value)
					{
						num2 = (short)958660609;
						if (num2 != 0)
						{
						}
						num2 = (short)1435041792;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_123;
				}
				goto IL_49;
				IL_123:
				num2 = (short)986775554;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_2A6:
				num2 = (short)355270667;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_49:
			flag = global::ConstraintHelper.UtilityMack.ProductModelId.Equals(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("냰ꏲ귴쿶쳸쯺췼", a_));
			radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
			num2 = (short)982384645;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x0002B018 File Offset: 0x00029218
		private void SetValueForNewCnvHotMicTxPeriodField()
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			short num2;
			int codeplugMainVersion;
			for (;;)
			{
				IL_0A:
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
				switch (num)
				{
				case 0:
					try
					{
						num2 = (short)1952907266;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
							{
								if (!enumerator.MoveNext())
								{
									num2 = (short)2097676289;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.ConventionalEmergencyProfiles conventionalEmergencyProfiles = (global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.ConventionalEmergencyProfiles)enumerator.Current;
								conventionalEmergencyProfiles.General.CnvEmerProfGeneralTxPeriodsec2_A43600.SetValue(conventionalEmergencyProfiles.General.CnvEmerProfGeneralTxPeriodsec1_A8212 * 10);
								num2 = (short)1500774404;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							case 1:
								num2 = (short)2031157251;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_C3;
								}
								continue;
							case 3:
								goto IL_156;
							}
							IL_10A:
							num2 = (short)2060976128;
							num = (int)((global::System.IntPtr)num2);
							continue;
							IL_C3:
							goto IL_10A;
						}
						IL_156:
						return;
					}
					finally
					{
						num2 = (short)929562625;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								goto IL_1C1;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_18B;
								}
								continue;
							case 2:
								enumerator.Dispose();
								goto IL_1AA;
							}
							IL_18B:
							if (enumerator != null)
							{
								num2 = (short)1271988226;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							goto IL_1C1;
							IL_1AA:
							num2 = (short)1221459968;
							num = (int)((global::System.IntPtr)num2);
							continue;
							IL_1C1:
							num2 = (short)537811882;
							short num3 = num2;
							num2 = (short)355556266;
							switch ((num3 == num2) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_1AA;
							default:
								goto IL_1F5;
							}
						}
						IL_1F5:
						num2 = (short)1877934080;
						if (num2 != 0)
						{
						}
					}
					goto IL_20B;
				case 1:
					if (codeplugMainVersion < 19)
					{
						num2 = (short)804388867;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 2:
					if (this.GetConventionalEmergencyProfiles() != null)
					{
						num2 = (short)1988952068;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 3:
					goto IL_20B;
				case 4:
					num2 = (short)1454178305;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_24;
				IL_20B:
				enumerator = this.GetConventionalEmergencyProfiles().GetEnumerator();
				num2 = (short)1334378496;
				short num4 = num2;
				num2 = (short)1654259712;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_24:
			num2 = (short)1483669505;
			if (num2 != 0)
			{
			}
			codeplugMainVersion = this.GetCodeplugMainVersion();
			num2 = (short)1389690882;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x0002B2CC File Offset: 0x000294CC
		private global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.ConventionalEmergencyProfilesRecset GetConventionalEmergencyProfiles()
		{
			while (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugConfigurationMode)
			{
				short num = (short)738197505;
				if (num != 0)
				{
				}
				num = (short)1884929464;
				short num2 = num;
				num = (short)879476152;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1837367296;
					if (num != 0)
					{
					}
					num = (short)119209984;
					short num3 = num;
					return global::AcpCommonLib.FeatureManager.GetFeature(2075) as global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.ConventionalEmergencyProfilesRecset;
				}
				}
			}
			return global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(2075) as global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.ConventionalEmergencyProfilesRecset;
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x0002B3A4 File Offset: 0x000295A4
		private void SetValueForNewTrkHotMicTxPeriodField()
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			short num2;
			int codeplugMainVersion;
			for (;;)
			{
				IL_0A:
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
				switch (num)
				{
				case 0:
				{
					num2 = (short)676528128;
					short num3 = num2;
					try
					{
						num2 = (short)618070018;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
							{
								if (!enumerator.MoveNext())
								{
									num2 = (short)439484417;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfiles trunkingEmergencyProfiles = (global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfiles)enumerator.Current;
								trunkingEmergencyProfiles.General.TrkEmerProfGeneralTxPeriodsec2_A43601.SetValue(trunkingEmergencyProfiles.General.TrkEmerProfGeneralTxPeriodsec1_A7939 * 10);
								num2 = (short)391708676;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							case 1:
								num2 = (short)1600061443;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_9F;
								}
								continue;
							case 3:
								goto IL_133;
							}
							IL_E6:
							num2 = (short)1322647552;
							num = (int)((global::System.IntPtr)num2);
							continue;
							IL_9F:
							goto IL_E6;
						}
						IL_133:
						return;
					}
					finally
					{
						num2 = (short)1640038401;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								goto IL_19E;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_169;
								}
								continue;
							case 2:
								enumerator.Dispose();
								goto IL_188;
							}
							IL_169:
							if (enumerator != null)
							{
								num2 = (short)58720258;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							goto IL_19E;
							IL_188:
							num2 = (short)608960512;
							num = (int)((global::System.IntPtr)num2);
							continue;
							IL_19E:
							num2 = (short)1712999807;
							short num4 = num2;
							num2 = (short)207506815;
							switch ((num4 == num2) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_188;
							default:
								goto IL_1D3;
							}
						}
						IL_1D3:
						num2 = (short)68878336;
						if (num2 != 0)
						{
						}
					}
					goto IL_1EB;
				}
				case 1:
					if (codeplugMainVersion < 19)
					{
						num2 = (short)4915203;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 2:
					if (this.GetTrunkingEmergencyProfiles() != null)
					{
						num2 = (short)793509892;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 3:
					num2 = (short)2123300865;
					if (num2 != 0)
					{
					}
					goto IL_1EB;
				case 4:
					num2 = (short)929824769;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_24;
				IL_1EB:
				enumerator = this.GetTrunkingEmergencyProfiles().GetEnumerator();
				num2 = (short)1980694528;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_24:
			codeplugMainVersion = this.GetCodeplugMainVersion();
			num2 = (short)591986690;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x0002B664 File Offset: 0x00029864
		private global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfilesRecset GetTrunkingEmergencyProfiles()
		{
			while (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugConfigurationMode)
			{
				short num = (short)403985864;
				short num2 = num;
				num = (short)1522030024;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)322109441;
					if (num != 0)
					{
					}
					num = (short)1149108224;
					if (num != 0)
					{
					}
					num = (short)1916993536;
					short num3 = num;
					return global::AcpCommonLib.FeatureManager.GetFeature(2076) as global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfilesRecset;
				}
				}
			}
			return global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(2076) as global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfilesRecset;
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x060000FA RID: 250 RVA: 0x0002B894 File Offset: 0x00029A94
		// (set) Token: 0x060000F9 RID: 249 RVA: 0x0002B73C File Offset: 0x0002993C
		public bool IsPortableModel
		{
			get
			{
				short num = (short)731774366;
				short num2 = num;
				num = (short)1103691166;
				switch (num2 == num)
				{
				}
				num = (short)700448768;
				short num3 = num;
				num = (short)449839105;
				if (num != 0)
				{
				}
				num = (short)1885143040;
				if (num != 0)
				{
				}
				return global::ConstraintHelper.UtilityMack.IsPortable();
			}
			set
			{
				int a_ = 2;
				switch (0)
				{
				case 0:
					goto IL_25;
				}
				int num;
				short num2;
				for (;;)
				{
					IL_13:
					switch (num)
					{
					case 0:
					{
						num2 = (short)559399938;
						short num3 = num2;
						num2 = (short)2043200514;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_91;
						case 1:
							goto IL_107;
						}
						goto Block_2;
					}
					case 1:
						if (this.PropertyChanged != null)
						{
							num2 = (short)784072706;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					case 2:
						this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("ꯡ韣뛥蟧飩飫迭鋯黱釳믵韷黹駻鋽", a_)));
						goto IL_91;
					}
					goto IL_25;
					IL_91:
					num2 = (short)287506432;
					num = (int)((global::System.IntPtr)num2);
				}
				Block_2:
				num2 = (short)1311571968;
				short num4 = num2;
				IL_107:
				num2 = (short)228720641;
				if (num2 != 0)
				{
				}
				num2 = (short)1090650112;
				if (num2 != 0)
				{
				}
				return;
				IL_25:
				string docFileName = ((global::MackinawCPS.App)global::System.Windows.Application.Current).TheDocument.docFileName;
				num2 = (short)864681985;
				num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x060000FB RID: 251 RVA: 0x0002B940 File Offset: 0x00029B40
		// (remove) Token: 0x060000FC RID: 252 RVA: 0x0002BA70 File Offset: 0x00029C70
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				short num2;
				global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler;
				for (;;)
				{
					IL_0A:
					global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler2;
					switch (num)
					{
					case 0:
					{
						num2 = (short)622402220;
						short num3 = num2;
						num2 = (short)1234115244;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_6E;
						case 1:
							goto IL_E3;
						}
						goto Block_1;
					}
					case 1:
						goto IL_39;
					case 2:
						if (propertyChangedEventHandler == propertyChangedEventHandler2)
						{
							goto IL_6E;
						}
						goto IL_39;
					}
					goto IL_1C;
					IL_39:
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					global::System.ComponentModel.PropertyChangedEventHandler value2 = (global::System.ComponentModel.PropertyChangedEventHandler)global::System.Delegate.Combine(propertyChangedEventHandler2, value);
					propertyChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.ComponentModel.PropertyChangedEventHandler>(ref this.PropertyChanged, value2, propertyChangedEventHandler2);
					num2 = (short)1459945474;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_6E:
					num2 = (short)1491468288;
					num = (int)((global::System.IntPtr)num2);
				}
				Block_1:
				num2 = (short)946733056;
				short num4 = num2;
				IL_E3:
				num2 = (short)1488977921;
				if (num2 != 0)
				{
				}
				num2 = (short)434896896;
				if (num2 != 0)
				{
				}
				return;
				IL_1C:
				propertyChangedEventHandler = this.PropertyChanged;
				num2 = (short)1700790273;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				short num2;
				global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler;
				for (;;)
				{
					IL_0A:
					global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler2;
					switch (num)
					{
					case 0:
					{
						num2 = (short)438435840;
						short num3 = num2;
						num2 = (short)1523843064;
						short num4 = num2;
						num2 = (short)2128281592;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_96;
						default:
							goto IL_10B;
						}
						break;
					}
					case 1:
						goto IL_39;
					case 2:
						num2 = (short)429785089;
						if (num2 != 0)
						{
						}
						if (propertyChangedEventHandler == propertyChangedEventHandler2)
						{
							goto IL_96;
						}
						goto IL_39;
					}
					goto IL_1C;
					IL_39:
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					global::System.ComponentModel.PropertyChangedEventHandler value2 = (global::System.ComponentModel.PropertyChangedEventHandler)global::System.Delegate.Remove(propertyChangedEventHandler2, value);
					propertyChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.ComponentModel.PropertyChangedEventHandler>(ref this.PropertyChanged, value2, propertyChangedEventHandler2);
					num2 = (short)1935212546;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_96:
					num2 = (short)471859200;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_10B:
				num2 = (short)2064252928;
				if (num2 != 0)
				{
				}
				return;
				IL_1C:
				propertyChangedEventHandler = this.PropertyChanged;
				num2 = (short)2107310081;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x060000FE RID: 254 RVA: 0x0002BCF8 File Offset: 0x00029EF8
		// (set) Token: 0x060000FD RID: 253 RVA: 0x0002BBA4 File Offset: 0x00029DA4
		public bool IsMobileModel
		{
			get
			{
				short num = (short)1006856055;
				short num2 = num;
				num = (short)155019127;
				switch (num2 == num)
				{
				}
				num = (short)1316487168;
				short num3 = num;
				num = (short)1859780608;
				if (num != 0)
				{
				}
				num = (short)564854785;
				if (num != 0)
				{
				}
				return global::ConstraintHelper.UtilityMack.IsMobile();
			}
			set
			{
				int a_ = 14;
				switch (0)
				{
				case 0:
					goto IL_25;
				}
				int num;
				short num2;
				for (;;)
				{
					IL_13:
					switch (num)
					{
					case 0:
					{
						num2 = (short)308543488;
						short num3 = num2;
						num2 = (short)1077097130;
						short num4 = num2;
						num2 = (short)1385050794;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_8E;
						default:
							goto IL_12E;
						}
						break;
					}
					case 1:
						if (this.PropertyChanged != null)
						{
							num2 = (short)1328611330;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					case 2:
						this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("꟭華뿱鯳铵釷雹駻돽濿昁愃樅", a_)));
						goto IL_8E;
					}
					goto IL_25;
					IL_8E:
					num2 = (short)1410990081;
					if (num2 != 0)
					{
					}
					num2 = (short)1913126912;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_12E:
				num2 = (short)515899392;
				if (num2 != 0)
				{
				}
				return;
				IL_25:
				string docFileName = ((global::MackinawCPS.App)global::System.Windows.Application.Current).TheDocument.docFileName;
				num2 = (short)45154305;
				num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
		}

		// Token: 0x060000FF RID: 255 RVA: 0x0002BDA8 File Offset: 0x00029FA8
		private void InitFCCNarrowBandSplit()
		{
			short num = (short)1817051136;
			switch (num)
			{
			default:
			{
				num = (short)996605960;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::AcpCommonLib.IAcpRecordset feature;
					global::Motorola.MackinawCPS.CoreFeatures.RadioWide.FCCNarrowBandingFrequencySplitInnerRecset fccnarrowBandingFrequencySplitInnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.RadioWide.FCCNarrowBandingFrequencySplit fccnarrowBandingFrequencySplit;
					bool flag2;
					switch (num2)
					{
					case 0:
						goto IL_12C;
					case 1:
						if (feature != null)
						{
							num = (short)807469059;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 2:
						if (fccnarrowBandingFrequencySplitInnerRecset.Count < 3)
						{
							num = (short)1718484998;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_355;
					case 3:
					{
						global::AcpBusinessLayer.FeatureNode featureNode = feature[0] as global::AcpBusinessLayer.FeatureNode;
						fccnarrowBandingFrequencySplit = (featureNode[10636] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.FCCNarrowBandingFrequencySplit);
						bool flag = false;
						num = (short)1961623562;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						goto IL_399;
					case 5:
						if (fccnarrowBandingFrequencySplitInnerRecset.Count >= 3)
						{
							num = (short)1988952073;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						fccnarrowBandingFrequencySplitInnerRecset.AddRecord(fccnarrowBandingFrequencySplitInnerRecset.CreateDefaultRecord());
						num = (short)589889553;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						flag2 = true;
						num = (short)958529548;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_12C;
					case 8:
						switch (0)
						{
						case 0:
							goto IL_95;
						}
						continue;
					case 9:
						num = (short)356843539;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						if (fccnarrowBandingFrequencySplit == null)
						{
							num = (short)805961743;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_399;
					case 11:
						return;
					case 12:
						goto IL_355;
					case 13:
						feature = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(2045);
						num = (short)464977920;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						goto IL_429;
					case 15:
					{
						global::AcpBusinessLayer.FeatureNode featureNode;
						featureNode.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.RadioWide.FCCNarrowBandingFrequencySplit(featureNode));
						fccnarrowBandingFrequencySplit = (featureNode[10636] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.FCCNarrowBandingFrequencySplit);
						bool flag = true;
						num = (short)741212164;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
					{
						if (fccnarrowBandingFrequencySplitInnerRecset == null)
						{
							return;
						}
						num = (short)1847398437;
						short num3 = num;
						num = (short)1409290277;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_429;
						default:
							num = (short)1215561728;
							if (num != 0)
							{
							}
							num = (short)609484814;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 17:
						goto IL_355;
					case 18:
					{
						num = (short)437977088;
						short num4 = num;
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.FCCNarrowBandingFrequencySplitInnerSection fccnarrowBandingFrequencySplitInnerSection = ((global::Motorola.MackinawCPS.CoreFeatures.RadioWide.FCCNarrowBandingFrequencySplitInner)fccnarrowBandingFrequencySplitInnerRecset[0]).FCCNarrowBandingFrequencySplitInnerSection;
						fccnarrowBandingFrequencySplitInnerSection.RadWideLabtoolFCCNarrowBandStartFrequency_A38270.Value = 30160000;
						fccnarrowBandingFrequencySplitInnerSection.RadWideLabtoolFCCNarrowBandEndFrequency_A38271.Value = 32402500;
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.FCCNarrowBandingFrequencySplitInnerSection fccnarrowBandingFrequencySplitInnerSection2 = ((global::Motorola.MackinawCPS.CoreFeatures.RadioWide.FCCNarrowBandingFrequencySplitInner)fccnarrowBandingFrequencySplitInnerRecset[1]).FCCNarrowBandingFrequencySplitInnerSection;
						fccnarrowBandingFrequencySplitInnerSection2.RadWideLabtoolFCCNarrowBandStartFrequency_A38270.Value = 34640000;
						fccnarrowBandingFrequencySplitInnerSection2.RadWideLabtoolFCCNarrowBandEndFrequency_A38271.Value = 34680000;
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.FCCNarrowBandingFrequencySplitInnerSection fccnarrowBandingFrequencySplitInnerSection3 = ((global::Motorola.MackinawCPS.CoreFeatures.RadioWide.FCCNarrowBandingFrequencySplitInner)fccnarrowBandingFrequencySplitInnerRecset[2]).FCCNarrowBandingFrequencySplitInnerSection;
						fccnarrowBandingFrequencySplitInnerSection3.RadWideLabtoolFCCNarrowBandStartFrequency_A38270.Value = 84200000;
						fccnarrowBandingFrequencySplitInnerSection3.RadWideLabtoolFCCNarrowBandEndFrequency_A38271.Value = 94000000;
						num = (short)1909522443;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 19:
					{
						num = (short)1687027713;
						if (num != 0)
						{
						}
						bool flag;
						if (flag2 || flag)
						{
							num = (short)1332150290;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					}
					IL_95:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num = (short)514064397;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					feature = global::AcpCommonLib.FeatureManager.GetFeature(2045);
					num = (short)1572732935;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_12C:
					num = (short)1893531649;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_355:
					num = (short)352387077;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_399:
					fccnarrowBandingFrequencySplitInnerRecset = (fccnarrowBandingFrequencySplit.EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.FCCNarrowBandingFrequencySplitInnerRecset);
					num = (short)1532690448;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_429:
					flag2 = false;
					num = (short)597426178;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
			}
			}
		}

		// Token: 0x06000100 RID: 256 RVA: 0x0002C244 File Offset: 0x0002A444
		private void CombinePinPartsToPinPassword(bool isReadingRadio, global::SpecialFeatures.Comms.RadioParams currentRadioParams)
		{
			short num = (short)633470976;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_70;
				}
				global::AcpCommonLib.IAcpRecordset acpRecordset;
				for (;;)
				{
					IL_29:
					global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
					string value2;
					switch (num2)
					{
					case 0:
						goto IL_2A2;
					case 1:
					{
						string text;
						if (text.Length > 4)
						{
							goto IL_38E;
						}
						goto IL_1F2;
					}
					case 2:
						num = (short)2133000201;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_1F2;
					case 4:
						if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
						{
							num = (short)329383946;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						acpRecordset = global::AcpCommonLib.FeatureManager.GetFeature(2045);
						num = (short)685178885;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
					{
						num = (short)1116252664;
						short num3 = num;
						num = (short)1746905592;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_38E;
						default:
							num = (short)7995392;
							if (num != 0)
							{
							}
							goto IL_2E6;
						}
						break;
					}
					case 6:
					{
						radioWide = (acpRecordset[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
						bool value = radioWide.Labtool.RadWideLabtoolEncryptPassword_A41695.Value;
						value2 = string.Empty;
						string empty = string.Empty;
						string empty2 = string.Empty;
						string text = radioWide.UserInformationAndPasswords.RadWideUserInformationandPasswordsPIN_A8705Value;
						string radWideUserInformationandPINPasswordPart2_41304Value = radioWide.UserInformationAndPasswords.RadWideUserInformationandPINPasswordPart2_41304Value;
						num = (short)284688385;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						value2 = radioWide.Labtool.RadWideLabtoolEncryptedPINPassword_A41702Value;
						num = (short)1468923917;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
					{
						bool value;
						if (value)
						{
							num = (short)1536557063;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						string text;
						string radWideUserInformationandPINPasswordPart2_41304Value;
						value2 = global::Common.AESCryptoUtil.AESEncryptWithDefKey(text + radWideUserInformationandPINPasswordPart2_41304Value);
						num = (short)1070137359;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						if (acpRecordset.Count > 0)
						{
							num = (short)1196752902;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3AC;
					case 10:
						num = (short)638386177;
						if (num != 0)
						{
						}
						acpRecordset = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(2045);
						num = (short)155713550;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
					{
						string text = text.Substring(0, 4);
						num = (short)963837955;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
						if (acpRecordset != null)
						{
							num = (short)1778450434;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3AC;
					case 13:
						goto IL_22C;
					case 14:
						goto IL_2E6;
					case 15:
						goto IL_22C;
					}
					goto IL_70;
					IL_1F2:
					num = (short)185401352;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_22C:
					radioWide.UserInformationAndPasswords.RadWideUserInformationandPINPassword_41303.SetValue(value2);
					radioWide.Labtool.RadWideLabtoolEncryptedPINPassword_A41702.SetValue(value2);
					radioWide.UserInformationAndPasswords.RadWideUserInformationandPasswordsPIN_A8705.SetValue(string.Empty);
					radioWide.UserInformationAndPasswords.RadWideUserInformationandPINPasswordPart2_41304.SetValue(string.Empty);
					radioWide.Labtool.RadWideLabtoolEncryptPassword_A41695.SetValue(true);
					num = (short)754188288;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2E6:
					num = (short)1223688204;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_38E:
					num = (short)1428815883;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_2A2:
				IL_3AC:
				num = (short)1291911168;
				short num4 = num;
				return;
				IL_70:
				acpRecordset = null;
				num = (short)2030632964;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x06000101 RID: 257 RVA: 0x0002C628 File Offset: 0x0002A828
		private void ChangeLegacyDINCFieldsFromLowerToUpperCase()
		{
			short num;
			try
			{
				num = (short)2067267584;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					switch (0)
					{
					case 0:
						goto IL_7E;
					}
					global::AcpCommonLib.IAcpRecordset acpRecordset;
					global::AcpCommonLib.IAcpRecordset acpRecordset2;
					global::AcpCommonLib.IAcpRecordset acpRecordset3;
					for (;;)
					{
						IL_27:
						switch (num2)
						{
						case 0:
							if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
							{
								num = (short)368443396;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							acpRecordset = global::AcpCommonLib.FeatureManager.GetFeature(2086);
							acpRecordset2 = global::AcpCommonLib.FeatureManager.GetFeature(2087);
							acpRecordset3 = global::AcpCommonLib.FeatureManager.GetFeature(2131);
							num = (short)1399193601;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_6A1;
						case 2:
							if (acpRecordset3.Count > 0)
							{
								num = (short)715849734;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_913;
						case 3:
							num = (short)584122370;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							goto IL_656;
						case 5:
							try
							{
								num = (short)1862598660;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										num = (short)697696257;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										goto IL_3A0;
									case 2:
									{
										global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
										if (!enumerator.MoveNext())
										{
											num = (short)1659043840;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Motorola.MackinawCPS.CoreFeatures.GlobalNoiseReductionList.GlobalNoiseReductionList globalNoiseReductionList = (global::Motorola.MackinawCPS.CoreFeatures.GlobalNoiseReductionList.GlobalNoiseReductionList)enumerator.Current;
										globalNoiseReductionList.General.DINCSPATIALEQ1VECTOR_A21553.Value = globalNoiseReductionList.General.DINCSPATIALEQ1VECTOR_A21553.Value.ToUpper();
										globalNoiseReductionList.General.DINCSPATIALEQ1VECTORCONT_A37716.Value = globalNoiseReductionList.General.DINCSPATIALEQ1VECTORCONT_A37716.Value.ToUpper();
										globalNoiseReductionList.General.DINCSPATIALEQ2VECTOR_A21556.Value = globalNoiseReductionList.General.DINCSPATIALEQ2VECTOR_A21556.Value.ToUpper();
										globalNoiseReductionList.General.DINCSPATIALEQ2VECTORCONT_A37717.Value = globalNoiseReductionList.General.DINCSPATIALEQ2VECTORCONT_A37717.Value.ToUpper();
										globalNoiseReductionList.General.DINCBFEQVECTOR_A21557.Value = globalNoiseReductionList.General.DINCBFEQVECTOR_A21557.Value.ToUpper();
										globalNoiseReductionList.General.DINCOUTPUTEQVECTOR_A21558.Value = globalNoiseReductionList.General.DINCOUTPUTEQVECTOR_A21558.Value.ToUpper();
										globalNoiseReductionList.General.DINCELKOVECTOR_A21561.Value = globalNoiseReductionList.General.DINCELKOVECTOR_A21561.Value.ToUpper();
										num = (short)359202819;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 4:
										switch (0)
										{
										case 0:
											goto IL_20B;
										}
										continue;
									}
									IL_210:
									num = (short)1726414850;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_20B:
									goto IL_210;
								}
								IL_3A0:
								goto IL_913;
							}
							finally
							{
								num = (short)1413742594;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									switch (num2)
									{
									case 0:
										goto IL_40C;
									case 1:
										enumerator.Dispose();
										num = (short)739115008;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_3D7;
										}
										continue;
									}
									IL_3D7:
									if (enumerator == null)
									{
										break;
									}
									num = (short)2109800449;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_40C:;
							}
							goto IL_40F;
						case 6:
						{
							global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = (acpRecordset3 as global::Motorola.MackinawCPS.CoreFeatures.GlobalNoiseReductionList.GlobalNoiseReductionListRecset).GetEnumerator();
							num = (short)881721349;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 7:
						{
							global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = (acpRecordset2 as global::Motorola.MackinawCPS.CoreFeatures.ExternalMicNoiseReductionProfile.ExternalMicNoiseReductionProfileRecset).GetEnumerator();
							num = (short)220725264;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 8:
							if (acpRecordset2 != null)
							{
								num = (short)306511883;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_196;
						case 9:
							if (acpRecordset3 != null)
							{
								num = (short)2143813635;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_913;
						case 10:
							goto IL_6A1;
						case 11:
							num = (short)1135738893;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 12:
						{
							global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = (acpRecordset as global::Motorola.MackinawCPS.CoreFeatures.InternalMicNoiseReductionProfile.InternalMicNoiseReductionProfileRecset).GetEnumerator();
							num = (short)2000748561;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 13:
							if (acpRecordset2.Count > 0)
							{
								num = (short)385482759;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_196;
						case 14:
							if (acpRecordset != null)
							{
								num = (short)779354130;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_40F;
						case 15:
							goto IL_92C;
						case 16:
							try
							{
								num = (short)661651460;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
									{
										global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
										if (!enumerator.MoveNext())
										{
											num = (short)623443971;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Motorola.MackinawCPS.CoreFeatures.ExternalMicNoiseReductionProfile.ExternalMicNoiseReductionProfile externalMicNoiseReductionProfile = (global::Motorola.MackinawCPS.CoreFeatures.ExternalMicNoiseReductionProfile.ExternalMicNoiseReductionProfile)enumerator.Current;
										externalMicNoiseReductionProfile.General.RadErgoCfgGeneralMAXSVECTOR_A22297.Value = externalMicNoiseReductionProfile.General.RadErgoCfgGeneralMAXSVECTOR_A22297.Value.ToUpper();
										externalMicNoiseReductionProfile.General.ExtMicNsRdGenDINCOUTPUTEQVECTOR_A37720.Value = externalMicNoiseReductionProfile.General.ExtMicNsRdGenDINCOUTPUTEQVECTOR_A37720.Value.ToUpper();
										externalMicNoiseReductionProfile.General.ExtMicNsRdGenDINCEPVECTOR_A37721.Value = externalMicNoiseReductionProfile.General.ExtMicNsRdGenDINCEPVECTOR_A37721.Value.ToUpper();
										num = (short)226820098;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 1:
										goto IL_857;
									case 3:
										num = (short)1069023233;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 4:
										switch (0)
										{
										case 0:
											goto IL_75B;
										}
										continue;
									}
									IL_7FE:
									num = (short)1228472320;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_75B:
									goto IL_7FE;
								}
								IL_857:
								goto IL_196;
							}
							finally
							{
								num = (short)1752170498;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									num = (short)1295654592;
									short num3 = num;
									num = (short)1666457280;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
									{
										num = (short)1322385408;
										if (num != 0)
										{
										}
										global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
										switch (num2)
										{
										case 0:
											goto IL_910;
										case 1:
											enumerator.Dispose();
											num = (short)142082048;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 2:
											switch (0)
											{
											case 0:
												goto IL_8D8;
											}
											continue;
										}
										IL_8D8:
										if (enumerator == null)
										{
											goto IL_912;
										}
										break;
									}
									}
									num = (short)1200553985;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_910:
								IL_912:;
							}
							goto IL_913;
						case 17:
							try
							{
								num = (short)1229193220;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
									{
										global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
										if (!enumerator.MoveNext())
										{
											num = (short)1050607619;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Motorola.MackinawCPS.CoreFeatures.InternalMicNoiseReductionProfile.InternalMicNoiseReductionProfile internalMicNoiseReductionProfile = (global::Motorola.MackinawCPS.CoreFeatures.InternalMicNoiseReductionProfile.InternalMicNoiseReductionProfile)enumerator.Current;
										internalMicNoiseReductionProfile.General.RadErgoCfgGeneralMAXSVECTOR_A21565.Value = internalMicNoiseReductionProfile.General.RadErgoCfgGeneralMAXSVECTOR_A21565.Value.ToUpper();
										internalMicNoiseReductionProfile.General.IntMicNsRdGenDINCOUTPUTEQVECTOR_A37718.Value = internalMicNoiseReductionProfile.General.IntMicNsRdGenDINCOUTPUTEQVECTOR_A37718.Value.ToUpper();
										internalMicNoiseReductionProfile.General.IntMicNsRdGenDINCEPVECTOR_A37719.Value = internalMicNoiseReductionProfile.General.IntMicNsRdGenDINCEPVECTOR_A37719.Value.ToUpper();
										num = (short)1525415938;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 1:
										goto IL_5E5;
									case 3:
										num = (short)1879048193;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 4:
										switch (0)
										{
										case 0:
											goto IL_4ED;
										}
										continue;
									}
									IL_58F:
									num = (short)726532096;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_4ED:
									goto IL_58F;
								}
								IL_5E5:
								goto IL_40F;
							}
							finally
							{
								num = (short)1317404674;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									switch (num2)
									{
									case 0:
										goto IL_653;
									case 1:
										enumerator.Dispose();
										num = (short)1954742272;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_61C;
										}
										continue;
									}
									IL_61C:
									if (enumerator == null)
									{
										break;
									}
									num = (short)798752769;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_653:;
							}
							goto IL_656;
						case 18:
							num = (short)863830035;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 19:
							if (acpRecordset.Count > 0)
							{
								num = (short)1504378892;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_40F;
						}
						goto IL_7E;
						IL_196:
						num = (short)1638409;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_40F:
						num = (short)990511112;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_656:
						acpRecordset = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(2086);
						acpRecordset2 = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(2087);
						acpRecordset3 = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(2131);
						num = (short)414318602;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_6A1:
						num = (short)1914896398;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_913:
						num = (short)1378680847;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_92C:
					break;
					IL_7E:
					acpRecordset = null;
					acpRecordset2 = null;
					acpRecordset3 = null;
					num = (short)686882816;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_27;
				}
				}
			}
			catch (global::System.Exception)
			{
			}
			num = (short)1727266817;
			if (num != 0)
			{
			}
			num = (short)1162412032;
			short num4 = num;
		}

		// Token: 0x06000102 RID: 258 RVA: 0x0002D01C File Offset: 0x0002B21C
		private void RemoveTheRecordOfCallAlertIDDisplay()
		{
			switch (0)
			{
			case 0:
				goto IL_44;
			}
			int num;
			global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.DisplayAndMenuRecset displayAndMenuRecset;
			short num2;
			for (;;)
			{
				IL_0A:
				global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.IDDisplayTableInnerRecset iddisplayTableInnerRecset;
				switch (num)
				{
				case 0:
					if (displayAndMenuRecset != null)
					{
						num2 = (short)1925578752;
						short num3 = num2;
						num2 = (short)479985673;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 1:
					num2 = (short)2039676929;
					if (num2 != 0)
					{
					}
					goto IL_25D;
				case 2:
					if (iddisplayTableInnerRecset.Count > 2)
					{
						num2 = (short)1267925000;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 3:
					return;
				case 4:
					goto IL_166;
				case 5:
				{
					int num4;
					if (num4 >= iddisplayTableInnerRecset.Count)
					{
						num2 = (short)1084162059;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					new global::AcpBusinessLayer.UndoRedo.DeleteRecordTask(iddisplayTableInnerRecset[num4] as global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.IDDisplayTableInner).Do();
					num4++;
					num2 = (short)362217484;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 6:
					num2 = (short)800653314;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					iddisplayTableInnerRecset = ((displayAndMenuRecset[0] as global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.DisplayAndMenu).IDDisplay.EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.IDDisplayTableInnerRecset);
					num2 = (short)725483524;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
				{
					int num4 = 2;
					num2 = (short)1438973953;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 9:
					num2 = (short)253296650;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					if (displayAndMenuRecset.Count > 0)
					{
						num2 = (short)593625095;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 11:
				{
					global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.IDDisplayTableInnerRecset._Min = iddisplayTableInnerRecset.Count;
					global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.IDDisplayTableInnerRecset._MaxPool = iddisplayTableInnerRecset.Count;
					iddisplayTableInnerRecset.DefaultRecordCount = iddisplayTableInnerRecset.Count;
					iddisplayTableInnerRecset.Max = iddisplayTableInnerRecset.Count;
					num2 = (short)1744078279;
					short num5 = num2;
					num2 = (short)279741895;
					switch ((num5 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_166;
					default:
						num2 = (short)305659904;
						if (num2 != 0)
						{
						}
						num2 = (short)1282211843;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 12:
					goto IL_25D;
				}
				goto IL_44;
				IL_166:
				if (iddisplayTableInnerRecset != null)
				{
					num2 = (short)101974022;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				break;
				IL_25D:
				num2 = (short)904790021;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_44:
			displayAndMenuRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2010) as global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.DisplayAndMenuRecset);
			num2 = (short)178782208;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000103 RID: 259 RVA: 0x0002D304 File Offset: 0x0002B504
		private void SynO2O7MFK()
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			global::AcpCommonLib.IAcpRecordset acpRecordset;
			for (;;)
			{
				IL_0A:
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
				switch (num)
				{
				case 0:
					try
					{
						num2 = (short)507117572;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								num2 = (short)185073665;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 1:
								goto IL_156;
							case 2:
							{
								if (!enumerator.MoveNext())
								{
									num2 = (short)1374617600;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								global::Motorola.MackinawCPS.CoreFeatures.Switches.MFKAssignmentControlInner mfkassignmentControlInner = (global::Motorola.MackinawCPS.CoreFeatures.Switches.MFKAssignmentControlInner)enumerator.Current;
								this.updateO2O7MFK(mfkassignmentControlInner.MFKAssignmentControlInnerSection.SwitchMFKAssignmentControlName_A38529.Value, mfkassignmentControlInner.MFKAssignmentControlInnerSection.RadErgoControlSwitchsMFKFeatureAssignment_A38514.Value);
								num2 = (short)891748355;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							case 4:
								switch (0)
								{
								case 0:
									goto IL_BF;
								}
								continue;
							}
							IL_C1:
							num2 = (short)1941635074;
							num = (int)((global::System.IntPtr)num2);
							continue;
							IL_BF:
							goto IL_C1;
						}
						IL_156:
						goto IL_24F;
					}
					finally
					{
						num2 = (short)803733506;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							num2 = (short)2007597954;
							short num3 = num2;
							num2 = (short)1691648898;
							switch ((num3 == num2) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								num2 = (short)570753024;
								if (num2 != 0)
								{
								}
								switch (num)
								{
								case 0:
									goto IL_20D;
								case 1:
									enumerator.Dispose();
									num2 = (short)1561526272;
									num = (int)((global::System.IntPtr)num2);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_1D7;
									}
									continue;
								}
								IL_1D7:
								if (enumerator == null)
								{
									goto IL_20F;
								}
								break;
							}
							num2 = (short)624033793;
							num = (int)((global::System.IntPtr)num2);
						}
						IL_20D:
						IL_20F:;
					}
					goto IL_210;
				case 1:
					goto IL_210;
				case 2:
					num2 = (short)847904769;
					if (num2 != 0)
					{
					}
					if (acpRecordset != null)
					{
						num2 = (short)1625554945;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_24F;
				}
				goto IL_1C;
				IL_210:
				enumerator = ((acpRecordset[0] as global::Motorola.MackinawCPS.CoreFeatures.Switches.Switches).MultiFunctionKnob.EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.Switches.MFKAssignmentControlInnerRecset).GetEnumerator();
				num2 = (short)1571749888;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_24F:
			num2 = (short)1198784512;
			short num4 = num2;
			return;
			IL_1C:
			acpRecordset = null;
			acpRecordset = global::AcpCommonLib.FeatureManager.GetFeature(2038);
			num2 = (short)1104216066;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000104 RID: 260 RVA: 0x0002D59C File Offset: 0x0002B79C
		internal void updateO2O7MFK(string name, int curConfigureFeature)
		{
			short num = (short)398917632;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_56;
				}
				global::AcpCommonLib.IAcpRecordset acpRecordset;
				for (;;)
				{
					IL_27:
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					global::AcpCommonLib.IAcpRecordset acpRecordset2;
					switch (num2)
					{
					case 0:
						goto IL_34E;
					case 1:
						try
						{
							num = (short)2062417921;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7MFKAssignmentControlInner o7MFKAssignmentControlInner;
									if (o7MFKAssignmentControlInner.O7MFKAssignmentControlInnerSection.RadErgoControlO7MFKFeatureAssignment_A41295Value != curConfigureFeature)
									{
										num = (short)508231686;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
									switch (0)
									{
									case 0:
										goto IL_1C3;
									}
									continue;
								case 2:
									num = (short)83623941;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									goto IL_2BF;
								case 4:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7MFKAssignmentControlInner o7MFKAssignmentControlInner;
									if (o7MFKAssignmentControlInner.O7MFKAssignmentControlInnerSection.O7MFKAssignmentControlName_A41294Value == name)
									{
										num = (short)720764935;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
									goto IL_2DE;
								case 6:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7MFKAssignmentControlInner o7MFKAssignmentControlInner;
									o7MFKAssignmentControlInner.O7MFKAssignmentControlInnerSection.RadErgoControlO7MFKFeatureAssignment_A41295.SetValue(curConfigureFeature);
									num = (short)474546179;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
									num = (short)1434714112;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1452408834;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7MFKAssignmentControlInner o7MFKAssignmentControlInner = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7MFKAssignmentControlInner)enumerator.Current;
									num = (short)1379205124;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_1C5:
								num = (short)1738473480;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1C3:
								goto IL_1C5;
							}
							IL_2BF:
							IL_2DE:
							goto IL_5CA;
						}
						finally
						{
							num = (short)1094123522;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_34B;
								case 1:
									enumerator.Dispose();
									num = (short)994508800;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_315;
									}
									continue;
								}
								IL_315:
								if (enumerator == null)
								{
									break;
								}
								num = (short)185401345;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_34B:;
						}
						goto Block_3;
					case 2:
						if (acpRecordset != null)
						{
							num = (short)1888681993;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5CA;
					case 3:
						goto IL_58D;
					case 4:
						acpRecordset2 = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(4115);
						num = (short)126025734;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
					{
						num = (short)1111477778;
						short num3 = num;
						num = (short)539676178;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_5CC;
						default:
							num = (short)913702912;
							if (num != 0)
							{
							}
							enumerator = ((acpRecordset2[0] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.ControlHeadO2).O2MultiFunctionKnob.EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2MFKAssignmentControlInnerRecset).GetEnumerator();
							num = (short)640155648;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 6:
						goto IL_58D;
					case 7:
						if (acpRecordset != null)
						{
							num = (short)1737949189;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 8:
						if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
						{
							num = (short)683212804;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						acpRecordset2 = global::AcpCommonLib.FeatureManager.GetFeature(4115);
						num = (short)678952963;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						goto IL_54F;
					}
					goto IL_56;
					IL_54F:
					enumerator = ((acpRecordset[0] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7).O7MultiFunctionKnob.EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7MFKAssignmentControlInnerRecset).GetEnumerator();
					num = (short)1698037761;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_3:
					try
					{
						IL_34E:
						num = (short)670040065;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
							{
								global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2MFKAssignmentControlInner o2MFKAssignmentControlInner;
								if (o2MFKAssignmentControlInner.O2MFKAssignmentControlInnerSection.RadErgoControlO2MFKFeatureAssignment_A41275Value != curConfigureFeature)
								{
									num = (short)302383110;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 1:
								switch (0)
								{
								case 0:
									goto IL_398;
								}
								continue;
							case 2:
								num = (short)601292800;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								goto IL_4C2;
							case 4:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1107951623;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2MFKAssignmentControlInner o2MFKAssignmentControlInner = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2MFKAssignmentControlInner)enumerator.Current;
								num = (short)2021064705;
								if (num != 0)
								{
								}
								num = (short)1520893960;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 5:
								goto IL_4E0;
							case 6:
							{
								global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2MFKAssignmentControlInner o2MFKAssignmentControlInner;
								o2MFKAssignmentControlInner.O2MFKAssignmentControlInnerSection.RadErgoControlO2MFKFeatureAssignment_A41275.SetValue(curConfigureFeature);
								num = (short)1864761347;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 7:
								num = (short)766377989;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 8:
							{
								global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2MFKAssignmentControlInner o2MFKAssignmentControlInner;
								if (o2MFKAssignmentControlInner.O2MFKAssignmentControlInnerSection.O2MFKAssignmentControlName_A41274Value == name)
								{
									num = (short)251133954;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							}
							IL_45A:
							num = (short)1502216196;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_398:
							goto IL_45A;
						}
						IL_4C2:
						IL_4E0:
						break;
					}
					finally
					{
						num = (short)1156317186;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_54C;
							case 1:
								enumerator.Dispose();
								num = (short)1653669888;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_517;
								}
								continue;
							}
							IL_517:
							if (enumerator == null)
							{
								break;
							}
							num = (short)1381040129;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_54C:;
					}
					goto IL_54F;
					IL_58D:
					num = (short)1319370759;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5CC:
					num = (short)1624702984;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5CA:
					acpRecordset2 = null;
					goto IL_5CC;
				}
				return;
				IL_56:
				acpRecordset = null;
				acpRecordset = global::AcpCommonLib.FeatureManager.GetFeature(4114);
				num = (short)1005715456;
				short num4 = num;
				num = (short)814153730;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000105 RID: 261 RVA: 0x0002DC14 File Offset: 0x0002BE14
		private void UpdateO2O7Emergency()
		{
			short num = (short)1491795968;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_5A;
				}
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.ControlHeadO5Recset controlHeadO5Recset;
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.ControlHeadE5Recset controlHeadE5Recset;
				for (;;)
				{
					IL_27:
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7Recset controlHeadO7Recset;
					switch (num2)
					{
					case 0:
						goto IL_EF;
					case 1:
						return;
					case 2:
						goto IL_119;
					case 3:
						goto IL_13E;
					case 4:
						if (controlHeadO5Recset != null)
						{
							num = (short)1563361285;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 5:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5Inner o5Inner = (controlHeadO5Recset[0][10227].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5InnerRecset)[0] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5Inner;
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.ControlHeadO2Recset controlHeadO2Recset = global::AcpCommonLib.FeatureManager.GetFeature(4115) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.ControlHeadO2Recset;
						num = (short)1847787530;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
					{
						num = (short)1280704512;
						short num3 = num;
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5Inner o5Inner;
						((controlHeadE5Recset[0][10902].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5InnerRecset)[0][10901] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5InnerSection).CHE5EmergencyButtonFeature_43768.SetValue(o5Inner.O5InnerSection.CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754.Value);
						num = (short)1921122305;
						if (num != 0)
						{
						}
						num = (short)1024851969;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						if (controlHeadO7Recset != null)
						{
							num = (short)590282761;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_EF;
					case 8:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5Inner o5Inner;
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.ControlHeadO2Recset controlHeadO2Recset;
						((controlHeadO2Recset[0][10723].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2InnerRecset)[0][10716] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2InnerSection).CHO2EmergencyButtonFeature_A41272.SetValue(o5Inner.O5InnerSection.CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754.Value);
						num = (short)1138753539;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5Inner o5Inner;
						((controlHeadO7Recset[0][10719].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7InnerRecset)[0][10715] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7InnerSection).CHO7EmergencyButtonFeature_A41291.SetValue(o5Inner.O5InnerSection.CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754.Value);
						num = (short)1394802688;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.ControlHeadO2Recset controlHeadO2Recset;
						if (controlHeadO2Recset != null)
						{
							num = (short)1152909320;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_13E;
					}
					}
					goto IL_5A;
					IL_EF:
					controlHeadE5Recset = (global::AcpCommonLib.FeatureManager.GetFeature(4236) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.ControlHeadE5Recset);
					num = (short)548405250;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_13E:
					controlHeadO7Recset = (global::AcpCommonLib.FeatureManager.GetFeature(4114) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7Recset);
					num = (short)324272135;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_119:
				if (controlHeadE5Recset != null)
				{
					goto IL_120;
				}
				return;
				IL_5A:
				controlHeadO5Recset = (global::AcpCommonLib.FeatureManager.GetFeature(2130) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.ControlHeadO5Recset);
				num = (short)181790609;
				short num4 = num;
				num = (short)1757603729;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_120:
					num = (short)273350662;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_27;
				default:
					num = (short)355729408;
					if (num != 0)
					{
					}
					num = (short)2090795012;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_27;
				}
				break;
			}
			}
		}

		// Token: 0x06000106 RID: 262 RVA: 0x0002DFA8 File Offset: 0x0002C1A8
		private void SyncDataButton()
		{
			short num = (short)1485307904;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7Recset controlHeadO7Recset;
				global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerSection dataButtonInnerSection;
				for (;;)
				{
					IL_1D:
					switch (0)
					{
					case 0:
						goto IL_4E;
					}
					global::Motorola.MackinawCPS.CoreFeatures.Buttons.ButtonsRecset buttonsRecset;
					for (;;)
					{
						IL_27:
						switch (num2)
						{
						case 0:
							if (controlHeadO7Recset == null)
							{
								num = (short)1688666117;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_30D;
						case 1:
							return;
						case 2:
						{
							num = (short)941948929;
							if (num != 0)
							{
							}
							if (buttonsRecset != null)
							{
								global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerRecset dataButtonInnerRecset = buttonsRecset[0][10089].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerRecset;
								global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.ControlHeadO3Recset controlHeadO3Recset = global::AcpCommonLib.FeatureManager.GetFeature(2127) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.ControlHeadO3Recset;
								num = (short)26804231;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)931921292;
							short num3 = num;
							num = (short)1954348428;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_1D;
							default:
								num = (short)56033280;
								if (num != 0)
								{
								}
								num = (short)137560067;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 3:
							return;
						case 4:
						{
							global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesRecset keypadMicAndAccessoriesRecset;
							if (keypadMicAndAccessoriesRecset == null)
							{
								num = (short)282066950;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::AcpBusinessLayer.Recordset recordset = keypadMicAndAccessoriesRecset[0][10228].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerRecset;
							global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerRecset dataButtonInnerRecset;
							dataButtonInnerSection = (dataButtonInnerRecset[0][10090] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerSection);
							global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerRecset dataButtonInnerRecset2;
							global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection dataButtonInnerSection2 = dataButtonInnerRecset2[0][10212] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection;
							global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection dataButtonInnerSection3 = recordset[0][10209] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection;
							dataButtonInnerSection2.CntrlHeadO3ConventionalO3DatatButtonFeature_A22595.SetValue(dataButtonInnerSection.BtnConventionalButtonDatatButtonFeature_A22610.Value);
							dataButtonInnerSection2.CntrlHeadO3TrunkingO3DatatButtonFeature_A22597.SetValue(dataButtonInnerSection.BtnTrunkingButtonDatatButtonFeature_A22608.Value);
							dataButtonInnerSection3.RadErgoCfgKMConventionalKMDatatButtonFeature_A22603.SetValue(dataButtonInnerSection.BtnConventionalButtonDatatButtonFeature_A22610.Value);
							dataButtonInnerSection3.RadErgoCfgKMTrunkingKMDatatButtonFeature_A22605.SetValue(dataButtonInnerSection.BtnTrunkingButtonDatatButtonFeature_A22608.Value);
							controlHeadO7Recset = (global::AcpCommonLib.FeatureManager.GetFeature(4114) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7Recset);
							num = (short)1587085312;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
							return;
						case 6:
							return;
						case 7:
						{
							global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.ControlHeadO3Recset controlHeadO3Recset;
							if (controlHeadO3Recset == null)
							{
								num = (short)279511040;
								short num4 = num;
								num = (short)1580204033;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerRecset dataButtonInnerRecset2 = controlHeadO3Recset[0][10234].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerRecset;
							global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesRecset keypadMicAndAccessoriesRecset = global::AcpCommonLib.FeatureManager.GetFeature(2128) as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesRecset;
							num = (short)190578692;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					IL_4E:
					buttonsRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2042) as global::Motorola.MackinawCPS.CoreFeatures.Buttons.ButtonsRecset);
					num = (short)1632829442;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_27;
				}
				return;
				IL_30D:
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection o7DataButtonInnerSection = (controlHeadO7Recset[0][10717].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerRecset)[0][10713] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection;
				o7DataButtonInnerSection.RadErgCtrlHeadO7DataButtonCnvFeature_A41299.SetValue(dataButtonInnerSection.BtnConventionalButtonDatatButtonFeature_A22610.Value);
				o7DataButtonInnerSection.RadErgCtrlHeadO7DataButtonTrkFeature_A41297.SetValue(dataButtonInnerSection.BtnTrunkingButtonDatatButtonFeature_A22608.Value);
				return;
			}
			}
		}

		// Token: 0x06000107 RID: 263 RVA: 0x0002E320 File Offset: 0x0002C520
		private void UpdatePaddingSpacesForSoftIDUsername()
		{
			int a_ = 5;
			short num = (short)322306048;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_8F;
				}
				string text;
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset radioWideRecset;
				global::AcpBusinessLayer.AcpFieldX<string, string> radWideUserInformationandPasswordsSoftIDUsername_A;
				for (;;)
				{
					IL_30:
					int length;
					int value;
					switch (num2)
					{
					case 0:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.ConventionalWideRecset conventionalWideRecset;
						if (conventionalWideRecset.Count < 1)
						{
							num = (short)2101215236;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)137887762;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						goto IL_43A;
					case 2:
						goto IL_2BE;
					case 3:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.UserInformationAndPasswords userInformationAndPasswords;
						userInformationAndPasswords.RadWideUserInformationandPasswordsSoftIDUsernameDisplayTextSize_A23453.SetValue(20);
						num = (short)1375600652;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						return;
					case 5:
						num = (short)1912340493;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
					{
						int num3;
						int num4;
						if (num3 >= num4)
						{
							num = (short)320733186;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1705115648;
						short num5 = num;
						text += global::PreEmptive.SoS.Runtime.FixedLengthStream.b("엤", a_);
						num3++;
						num = (short)1573191687;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						goto IL_284;
					case 8:
						if (length < value)
						{
							num = (short)1254948881;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4E5;
					case 9:
						num = (short)1547370516;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						goto IL_1E3;
					case 11:
						goto IL_1DD;
					case 12:
						goto IL_1E3;
					case 13:
					{
						if (radioWideRecset.Count < 1)
						{
							num = (short)2011365377;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.UserInformationAndPasswords userInformationAndPasswords = radioWideRecset[0][10102] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.UserInformationAndPasswords;
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.ConventionalWideRecset conventionalWideRecset = global::AcpCommonLib.FeatureManager.GetFeature(2024) as global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.ConventionalWideRecset;
						num = (short)262537232;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
						num = (short)262144000;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						num = (short)431095809;
						if (num != 0)
						{
						}
						if (radioWideRecset != null)
						{
							num = (short)1100480517;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 16:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.ConventionalWideRecset conventionalWideRecset;
						if (conventionalWideRecset != null)
						{
							num = (short)413138958;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 17:
					{
						int num4 = value - length;
						int num3 = 0;
						num = (short)1786904587;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 18:
					{
						num = (short)1692873695;
						short num6 = num;
						num = (short)2045391839;
						switch ((num6 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1DD;
						default:
						{
							num = (short)598016000;
							if (num != 0)
							{
							}
							global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.ConventionalWideRecset conventionalWideRecset;
							if ((conventionalWideRecset[0][10057] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.Features).CnvWideFeaturesSoftIDFeature_A9168.Value)
							{
								num = (short)312082441;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1386217491;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 19:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.UserInformationAndPasswords userInformationAndPasswords;
						if (userInformationAndPasswords.RadWideUserInformationandPasswordsSoftIDUsernameDisplayTextSize_A23453.Value != 20)
						{
							num = (short)845807619;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1E3;
					}
					case 20:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.UserInformationAndPasswords userInformationAndPasswords;
						if (userInformationAndPasswords.RadWideUserInformationandPasswordsSoftIDUsernameDisplayTextSize_A23453.Value != 8)
						{
							num = (short)916127765;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1E3;
					}
					case 21:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.UserInformationAndPasswords userInformationAndPasswords;
						userInformationAndPasswords.RadWideUserInformationandPasswordsSoftIDUsernameDisplayTextSize_A23453.SetValue(8);
						num = (short)1539309578;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_8F;
					IL_1E3:
					radWideUserInformationandPasswordsSoftIDUsername_A = (radioWideRecset[0][10102] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.UserInformationAndPasswords).RadWideUserInformationandPasswordsSoftIDUsername_A9169;
					string value2 = radWideUserInformationandPasswordsSoftIDUsername_A.Value;
					global::AcpBusinessLayer.AcpSimpleRangeField radWideUserInformationandPasswordsSoftIDUsernameDisplayTextSize_A = (radioWideRecset[0][10102] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.UserInformationAndPasswords).RadWideUserInformationandPasswordsSoftIDUsernameDisplayTextSize_A23453;
					text = global::System.Convert.ToString(value2).TrimEnd(global::System.Array.Empty<char>());
					length = text.Length;
					value = radWideUserInformationandPasswordsSoftIDUsernameDisplayTextSize_A.Value;
					num = (short)1834287112;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_284:
					num = (short)1396572166;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1DD:
					goto IL_284;
				}
				return;
				IL_2BE:
				goto IL_4E5;
				IL_43A:
				return;
				IL_4E5:
				radWideUserInformationandPasswordsSoftIDUsername_A.SetValue(text);
				return;
				IL_8F:
				radioWideRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2045) as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset);
				num = (short)96534543;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06000108 RID: 264 RVA: 0x0002E81C File Offset: 0x0002CA1C
		private void ConsolidatedActionBCOTableInit()
		{
			short num = (short)1646002176;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_42;
				}
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset controlHeadO9Recset;
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInnerRecset consolidatedActionBCOListInnerRecset;
				for (;;)
				{
					IL_27:
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					switch (num2)
					{
					case 0:
					{
						if (controlHeadO9Recset == null)
						{
							return;
						}
						num = (short)198889149;
						short num3 = num;
						num = (short)1283247805;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_2C1;
						default:
						{
							num = (short)1115815936;
							if (num != 0)
							{
							}
							num = (short)285540352;
							short num4 = num;
							num = (short)902430721;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 1:
						goto IL_2C1;
					case 2:
						if (consolidatedActionBCOListInnerRecset != null)
						{
							num = (short)1532100611;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 3:
						goto IL_29C;
					case 4:
						try
						{
							num = (short)1437073409;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_20E;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_147;
									}
									continue;
								case 2:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if (134 == (acpFeatureNode[10623] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInnerSection).RadErgoControlO9ACBCOListBco_A36666.Value)
									{
										num = (short)1876164611;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									global::MackinawCPS.DocumentOperations.SyncO9ACBCODataButtonIndexToOtherDataButtonIndex((acpFeatureNode[10623] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInnerSection).RadErgoControlO9ACBCOListIndex_A36668);
									num = (short)1214840832;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									num = (short)1606680581;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									goto IL_22C;
								case 6:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)2042560516;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
									num = (short)1720844290;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_19E:
								num = (short)1895628806;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_147:
								goto IL_19E;
							}
							IL_20E:
							IL_22C:
							return;
						}
						finally
						{
							num = (short)355139584;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_264;
									}
									continue;
								case 1:
									goto IL_299;
								case 2:
									enumerator.Dispose();
									num = (short)889978881;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_264:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1834418178;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_299:;
						}
						goto IL_29C;
					}
					goto IL_42;
					IL_29C:
					enumerator = consolidatedActionBCOListInnerRecset.GetEnumerator();
					num = (short)1323565060;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2C1:
					num = (short)1814429697;
					if (num != 0)
					{
					}
					consolidatedActionBCOListInnerRecset = (controlHeadO9Recset[0][10622].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInnerRecset);
					num = (short)1655570434;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_42:
				controlHeadO9Recset = null;
				consolidatedActionBCOListInnerRecset = null;
				controlHeadO9Recset = (global::AcpCommonLib.FeatureManager.GetFeature(4003) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset);
				num = (short)1207828480;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000109 RID: 265 RVA: 0x0002EB84 File Offset: 0x0002CD84
		internal static void SyncO9ACBCODataButtonIndexToOtherDataButtonIndex(global::AcpBusinessLayer.AcpListField srcField)
		{
			short num = (short)1268252672;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_8F;
				}
				global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerRecset dataButtonInnerRecset;
				global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesRecset keypadMicAndAccessoriesRecset;
				for (;;)
				{
					IL_28:
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7Recset controlHeadO7Recset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerRecset o7DataButtonInnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerRecset dataButtonInnerRecset2;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.ControlHeadO3Recset controlHeadO3Recset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset controlHeadO9Recset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerRecset o9DataButtonInnerRecset;
					switch (num2)
					{
					case 0:
						o7DataButtonInnerRecset = (controlHeadO7Recset[0][10717].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerRecset);
						num = (short)1221066770;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_B3E;
					case 2:
						goto IL_65F;
					case 3:
						if (dataButtonInnerRecset != null)
						{
							num = (short)49872919;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_492;
					case 4:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = o7DataButtonInnerRecset.GetEnumerator();
						num = (short)2014904329;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						if (o7DataButtonInnerRecset != null)
						{
							num = (short)324141060;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_16A;
					case 6:
						try
						{
							num = (short)1403518983;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if (srcField.Value != (acpFeatureNode[10209] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection).RadErgoCfgKMTrunkingKMDatatButtonIndex_A41424.Value)
									{
										num = (short)463667205;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									goto IL_74C;
								case 3:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)926482438;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
									num = (short)1988165636;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if (srcField.Value != (acpFeatureNode[10209] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection).RadErgoCfgKMConventionalKMDatatButtonIndex_A41423.Value)
									{
										num = (short)1671102472;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_74C;
								}
								case 5:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									(acpFeatureNode[10209] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection).RadErgoCfgKMTrunkingKMDatatButtonIndex_A41424.UIValue = srcField.UIValue;
									num = (short)1039990785;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									num = (short)826408969;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									switch (0)
									{
									case 0:
										goto IL_6E9;
									}
									continue;
								case 8:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									(acpFeatureNode[10209] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection).RadErgoCfgKMConventionalKMDatatButtonIndex_A41423.UIValue = srcField.UIValue;
									num = (short)989331458;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 9:
									goto IL_879;
								}
								goto IL_6E9;
								IL_74C:
								num = (short)1673461760;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_7E5:
								num = (short)942669827;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_6E9:
								goto IL_7E5;
							}
							IL_879:
							goto IL_492;
						}
						finally
						{
							num = (short)1864564737;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)337969154;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_8B1;
									}
									continue;
								case 2:
									goto IL_8E8;
								}
								IL_8B1:
								if (enumerator == null)
								{
									break;
								}
								num = (short)266862592;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_8E8:;
						}
						goto Block_10;
					case 7:
						goto IL_5D2;
					case 8:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = dataButtonInnerRecset2.GetEnumerator();
						num = (short)1972764689;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						try
						{
							num = (short)1726414855;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)228458501;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2 = enumerator.Current;
									num = (short)2081816580;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									goto IL_CBF;
								case 3:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									if (srcField.Value != (acpFeatureNode2[10713] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection).CHO7DataButtonTrkIndex_A41418.Value)
									{
										num = (short)542638086;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									if (srcField.Value != (acpFeatureNode2[10713] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection).CHO7DataButtonConvIndex_A41417.Value)
									{
										num = (short)1713963016;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_CBF;
								}
								case 5:
									num = (short)2002714633;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
								{
									num = (short)674872413;
									short num3 = num;
									num = (short)1034992733;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
									{
										num = (short)214368256;
										if (num != 0)
										{
										}
										global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
										(acpFeatureNode2[10713] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection).CHO7DataButtonTrkIndex_A41418.UIValue = srcField.UIValue;
										num = (short)643891201;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									break;
								}
								case 7:
									switch (0)
									{
									case 0:
										goto IL_BDD;
									}
									continue;
								case 8:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									(acpFeatureNode2[10713] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection).CHO7DataButtonConvIndex_A41417.UIValue = srcField.UIValue;
									num = (short)1220935682;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 9:
									goto IL_DBB;
								}
								IL_C41:
								num = (short)1224081408;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_BDD:
								goto IL_C41;
								IL_CBF:
								num = (short)1172439043;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_DBB:
							goto IL_16A;
						}
						finally
						{
							num = (short)374931457;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)789250050;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_DF2;
									}
									continue;
								case 2:
									goto IL_E2A;
								}
								IL_DF2:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1472331776;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_E2A:;
						}
						return;
					case 10:
						try
						{
							num = (short)1913913351;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_347;
								case 2:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									(acpFeatureNode3[10608] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection).CHO9DataButtonConvIndex_A41414.UIValue = srcField.UIValue;
									num = (short)1859256320;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									if (srcField.Value != (acpFeatureNode3[10608] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection).CHO9DataButtonTrkIndex_A41416.Value)
									{
										num = (short)625475590;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)610992136;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3 = enumerator.Current;
									num = (short)1137573893;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									if (srcField.Value != (acpFeatureNode3[10608] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection).CHO9DataButtonConvIndex_A41414.Value)
									{
										num = (short)869203970;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_347;
								}
								case 6:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									(acpFeatureNode3[10608] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection).CHO9DataButtonTrkIndex_A41416.UIValue = srcField.UIValue;
									num = (short)1204158465;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
									switch (0)
									{
									case 0:
										goto IL_269;
									}
									continue;
								case 8:
									num = (short)258146313;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
									goto IL_3F7;
								}
								IL_26E:
								num = (short)1930362884;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_269:
								goto IL_26E;
								IL_347:
								num = (short)973799427;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_3F7:
							return;
						}
						finally
						{
							num = (short)1209925633;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)535166978;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_42F;
									}
									continue;
								case 2:
									goto IL_48F;
								}
								IL_42F:
								num = (short)1506672641;
								if (num != 0)
								{
								}
								if (enumerator == null)
								{
									break;
								}
								num = (short)2095054848;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_48F:;
						}
						goto IL_492;
					case 11:
						if (controlHeadO7Recset != null)
						{
							num = (short)9043968;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4D0;
					case 12:
						if (dataButtonInnerRecset2 != null)
						{
							num = (short)309461000;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1DF;
					case 13:
						if (controlHeadO3Recset != null)
						{
							num = (short)1118306324;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5D2;
					case 14:
					{
						num = (short)722272256;
						short num4 = num;
						dataButtonInnerRecset = (keypadMicAndAccessoriesRecset[0][10228].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerRecset);
						num = (short)1622016001;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 15:
						if (controlHeadO9Recset != null)
						{
							num = (short)1621753875;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_65F;
					case 16:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = o9DataButtonInnerRecset.GetEnumerator();
						num = (short)1808793610;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
						goto IL_8EB;
					case 18:
						goto IL_4D0;
					case 19:
						o9DataButtonInnerRecset = (controlHeadO9Recset[0][10611].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerRecset);
						num = (short)1848246274;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						dataButtonInnerRecset2 = (controlHeadO3Recset[0][10234].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerRecset);
						num = (short)710017031;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						if (keypadMicAndAccessoriesRecset != null)
						{
							num = (short)791150606;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B3E;
					case 22:
						if (o9DataButtonInnerRecset != null)
						{
							num = (short)83230736;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 23:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = dataButtonInnerRecset.GetEnumerator();
						num = (short)1884160006;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_8F;
					IL_16A:
					num = (short)528613398;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1DF:
					num = (short)1302528005;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_10:
					try
					{
						IL_8EB:
						num = (short)1927872519;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
							{
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4;
								if (srcField.Value != (acpFeatureNode4[10212] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection).CHO3DataButtonConvIndex_A41419.Value)
								{
									num = (short)531628037;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_A58;
							}
							case 1:
							{
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4;
								(acpFeatureNode4[10212] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection).CHO3DataButtonTrkIndex_A41420.UIValue = srcField.UIValue;
								num = (short)2094989315;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 2:
								goto IL_A58;
							case 4:
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								if (!enumerator.MoveNext())
								{
									num = (short)1734541320;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4 = enumerator.Current;
								num = (short)531628032;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 5:
							{
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4;
								(acpFeatureNode4[10212] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection).CHO3DataButtonConvIndex_A41419.UIValue = srcField.UIValue;
								num = (short)2070740994;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 6:
							{
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4;
								if (srcField.Value != (acpFeatureNode4[10212] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection).CHO3DataButtonTrkIndex_A41420.Value)
								{
									num = (short)1845624833;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 7:
								switch (0)
								{
								case 0:
									goto IL_93A;
								}
								continue;
							case 8:
								num = (short)1995046921;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 9:
								goto IL_ACC;
							}
							IL_93F:
							num = (short)1924530180;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_93A:
							goto IL_93F;
							IL_A58:
							num = (short)746127366;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_ACC:
						goto IL_1DF;
					}
					finally
					{
						num = (short)1047986177;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
							switch (num2)
							{
							case 0:
								enumerator.Dispose();
								num = (short)792461314;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_B04;
								}
								continue;
							case 2:
								goto IL_B3B;
							}
							IL_B04:
							if (enumerator == null)
							{
								break;
							}
							num = (short)1291583488;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_B3B:;
					}
					goto IL_B3E;
					IL_492:
					num = (short)342753292;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4D0:
					controlHeadO9Recset = null;
					o9DataButtonInnerRecset = null;
					controlHeadO9Recset = (global::AcpCommonLib.FeatureManager.GetFeature(4003) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset);
					num = (short)9633807;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5D2:
					controlHeadO7Recset = null;
					o7DataButtonInnerRecset = null;
					controlHeadO7Recset = (global::AcpCommonLib.FeatureManager.GetFeature(4114) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7Recset);
					num = (short)1462173707;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_65F:
					num = (short)1732050947;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_B3E:
					controlHeadO3Recset = null;
					dataButtonInnerRecset2 = null;
					controlHeadO3Recset = (global::AcpCommonLib.FeatureManager.GetFeature(2127) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.ControlHeadO3Recset);
					num = (short)1076232205;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_8F:
				keypadMicAndAccessoriesRecset = null;
				dataButtonInnerRecset = null;
				keypadMicAndAccessoriesRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2128) as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesRecset);
				num = (short)1512636437;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x0600010A RID: 266 RVA: 0x0002FA24 File Offset: 0x0002DC24
		private void RefreshMaxChangeRecords()
		{
			short num = (short)820903936;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_52;
				}
				global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityRecset conventionalPersonalityRecset;
				global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInnerRecset frequencyOptionsInnerRecset;
				for (;;)
				{
					IL_27:
					global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListRecset scanListRecset;
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemRecset trunkingSystemRecset;
					switch (num2)
					{
					case 0:
						if (conventionalPersonalityRecset != null)
						{
							num = (short)1182728193;
							if (num != 0)
							{
							}
							num = (short)1483669509;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_81E;
					case 1:
						enumerator = scanListRecset.GetEnumerator();
						num = (short)680329224;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_302;
					case 3:
						if (conventionalPersonalityRecset != null)
						{
							num = (short)32309249;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_EB;
					case 4:
						if (trunkingSystemRecset != null)
						{
							num = (short)4980742;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 5:
						goto IL_7AF;
					case 6:
						enumerator = trunkingSystemRecset.GetEnumerator();
						num = (short)1525350407;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_5F0;
					case 8:
						try
						{
							num = (short)312016896;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_180;
									}
									continue;
								case 1:
									goto IL_28C;
								case 2:
									num = (short)408289285;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									num = (short)551419905;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanList scanList;
									scanList.General.ScanLstGeneralScanType_A9058.CalculateApplicability();
									num = (short)1514930183;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanList scanList;
									if (scanList.General.ScanLstGeneralScanType_A9058 != null)
									{
										num = (short)208273412;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanList scanList;
									if (scanList != null)
									{
										num = (short)426770434;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 8:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)752812035;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanList scanList = enumerator.Current as global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanList;
									num = (short)366804998;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_234:
								num = (short)1367605256;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_180:
								goto IL_234;
							}
							IL_28C:
							goto IL_EB;
						}
						finally
						{
							num = (short)1855455232;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_2C4;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)1901854722;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_2FF;
								}
								IL_2C4:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1335164929;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2FF:;
						}
						goto Block_4;
					}
					goto IL_52;
					IL_EB:
					trunkingSystemRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2064) as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemRecset);
					num = (short)2067988484;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7AF:
					enumerator = conventionalPersonalityRecset.GetEnumerator();
					num = (short)949157890;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_5:
					try
					{
						IL_5F0:
						num = (short)2078277632;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_63A;
								}
								continue;
							case 1:
								goto IL_73C;
							case 2:
								num = (short)1471610881;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
								num = (short)636289031;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 5:
							{
								global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
								if (trunkingSystem != null)
								{
									num = (short)669057028;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 6:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1244725250;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem = enumerator.Current as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem;
								num = (short)954138629;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 7:
							{
								global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
								if (trunkingSystem.StatusAlias.TrkSysStatusAliasStatusAliasEnable_A9195 != null)
								{
									num = (short)630390792;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 8:
							{
								global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
								trunkingSystem.StatusAlias.TrkSysStatusAliasStatusAliasEnable_A9195.CalculateApplicability();
								num = (short)670367747;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							IL_67A:
							num = (short)675414022;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_63A:
							goto IL_67A;
						}
						IL_73C:
						break;
					}
					finally
					{
						num = (short)1472200704;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_773;
								}
								continue;
							case 1:
								enumerator.Dispose();
								num = (short)1295712258;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_7AC;
							}
							IL_773:
							if (enumerator == null)
							{
								break;
							}
							num = (short)755695617;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_7AC:;
					}
					goto IL_7AF;
					Block_4:
					try
					{
						IL_302:
						num = (short)783155200;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_362;
								}
								continue;
							case 1:
								goto IL_533;
							case 2:
								frequencyOptionsInnerRecset.SetMax(15);
								num = (short)781385741;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								if (frequencyOptionsInnerRecset != null)
								{
									num = (short)1750138890;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							case 5:
								num = (short)1054670851;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 6:
							{
								global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
								if (conventionalPersonality != null)
								{
									num = (short)535035909;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 7:
								num = (short)803602444;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 8:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1059651593;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality = enumerator.Current as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality;
								frequencyOptionsInnerRecset = (conventionalPersonality.Features.Parent[10148].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInnerRecset);
								num = (short)164233222;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 9:
								num = (short)199294977;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 10:
								num = (short)1804140555;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 11:
							{
								global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
								if (conventionalPersonality.Features.CnvPerFeaturesMixedVoteScanEnable_A38723 != null)
								{
									num = (short)968097799;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 12:
							{
								global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
								if (conventionalPersonality.Features.CnvPerFeaturesMixedVoteScanEnable_A38723.Value)
								{
									num = (short)194772994;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								frequencyOptionsInnerRecset.SetMax(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInnerRecset._Max);
								num = (short)901447684;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							IL_395:
							num = (short)326107144;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_362:
							goto IL_395;
						}
						IL_533:
						goto IL_81E;
					}
					finally
					{
						num = (short)234455334;
						short num3 = num;
						num = (short)893944102;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)1655177216;
							if (num != 0)
							{
							}
							num = (short)1433337856;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_5B4;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)1671036930;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_5ED;
								}
								IL_5B4:
								if (enumerator == null)
								{
									break;
								}
								num = (short)812777473;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_5ED:
							break;
						}
					}
					goto Block_5;
					IL_81E:
					scanListRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2057) as global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListRecset);
					num = (short)1028456451;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_52:
				conventionalPersonalityRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2059) as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityRecset);
				frequencyOptionsInnerRecset = null;
				num = (short)111149056;
				short num4 = num;
				num = (short)1606025216;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x0600010B RID: 267 RVA: 0x000302E4 File Offset: 0x0002E4E4
		private void SyncQC2Code()
		{
			short num = (short)604307456;
			short num2 = num;
			num = (short)1757699936;
			short num3 = num;
			num = (short)1216307040;
			global::AcpCommonLib.IAcpRecordset feature;
			global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
			int num4;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_354:
				enumerator = ((global::AcpBusinessLayer.Recordset)feature).GetEnumerator();
				num = (short)785580034;
				num4 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)589299712;
				if (num != 0)
				{
				}
				num = (short)770834432;
				num4 = (int)num;
				switch (num4)
				{
				default:
					num = (short)674627585;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_D7;
					}
					break;
				}
				break;
			}
			for (;;)
			{
				IL_C4:
				switch (num4)
				{
				case 0:
					if (feature == null)
					{
						num = (short)1725497345;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_354;
				case 1:
					return;
				case 2:
					goto IL_37A;
				}
				goto IL_D7;
			}
			return;
			IL_37A:
			try
			{
				num = (short)471597059;
				num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
						num = (short)1836974081;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_2E3;
					case 2:
					{
						global::AcpBusinessLayer.FeatureNode featureNode;
						if (featureNode is global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem)
						{
							num = (short)1155465220;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
						switch (0)
						{
						case 0:
							goto IL_15D;
						}
						continue;
					case 4:
					{
						global::AcpBusinessLayer.FeatureNode featureNode;
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.IndividualIDTonesInnerRecset individualIDTonesInnerRecset = featureNode[10785].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.IndividualIDTonesInnerRecset;
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.IndividualIDTonesInnerSection individualIDTonesInnerSection = (individualIDTonesInnerRecset[0] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.IndividualIDTonesInner).IndividualIDTonesInnerSection;
						individualIDTonesInnerSection.CnvSysGeneralQc2Code_A42234.Value = this.FindCodeBasedonFreq(individualIDTonesInnerSection.CnvSysGeneralQc2Freq_A42232.UIValue);
						individualIDTonesInnerSection = (individualIDTonesInnerRecset[1] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.IndividualIDTonesInner).IndividualIDTonesInnerSection;
						individualIDTonesInnerSection.CnvSysGeneralQc2Code_A42234.Value = this.FindCodeBasedonFreq(individualIDTonesInnerSection.CnvSysGeneralQc2Freq_A42232.UIValue);
						individualIDTonesInnerSection = (individualIDTonesInnerRecset[2] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.IndividualIDTonesInner).IndividualIDTonesInnerSection;
						individualIDTonesInnerSection.CnvSysGeneralQc2Code_A42234.Value = this.FindCodeBasedonFreq(individualIDTonesInnerSection.CnvSysGeneralQc2Freq_A42232.UIValue);
						individualIDTonesInnerSection = (individualIDTonesInnerRecset[3] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.IndividualIDTonesInner).IndividualIDTonesInnerSection;
						individualIDTonesInnerSection.CnvSysGeneralQc2Code_A42234.Value = this.FindCodeBasedonFreq(individualIDTonesInnerSection.CnvSysGeneralQc2Freq_A42232.UIValue);
						num = (short)1032454150;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)1880621056;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::AcpBusinessLayer.FeatureNode featureNode = enumerator.Current;
						num = (short)958005250;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_1A2:
					num = (short)1270153221;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_15D:
					goto IL_1A2;
				}
				IL_2E3:
				return;
			}
			finally
			{
				num = (short)1269104640;
				num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_31A;
						}
						continue;
					case 1:
						enumerator.Dispose();
						num = (short)1886191618;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_351;
					}
					IL_31A:
					if (enumerator == null)
					{
						break;
					}
					num = (short)1843134465;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_351:;
			}
			goto IL_354;
			IL_D7:
			feature = global::AcpCommonLib.FeatureManager.GetFeature(2053);
			num = (short)517406720;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_C4;
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00030690 File Offset: 0x0002E890
		private int FindCodeBasedonFreq(string UIValue)
		{
			int num;
			short num2;
			double[] array;
			int num3;
			int num4;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						num2 = (short)1178206209;
						if (num2 != 0)
						{
						}
						goto IL_1BE;
					case 1:
						goto IL_90;
					case 2:
						if (UIValue == array[num3].ToString())
						{
							num2 = (short)1258881031;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num3++;
						num2 = (short)327745542;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3:
						if (num3 >= array.GetLength(0))
						{
							num2 = (short)1632698369;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)1755512834;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 4:
						return 0;
					case 5:
						if (num4 == -1)
						{
							num2 = (short)618528772;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_1FF;
					case 6:
						goto IL_1BE;
					case 7:
						num4 = num3;
						num2 = (short)835715080;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 8:
						goto IL_90;
					}
					goto IL_34;
					IL_90:
					num2 = (short)1881317469;
					short num5 = num2;
					num2 = (short)184721501;
					switch ((num5 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_4E;
					default:
					{
						num2 = (short)1327955968;
						short num6 = num2;
						num2 = (short)1818755072;
						if (num2 != 0)
						{
						}
						num2 = (short)694681605;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					IL_1BE:
					num2 = (short)1345257475;
					num = (int)((global::System.IntPtr)num2);
				}
				return 0;
				IL_1FF:
				return num4 + 1;
			}
			IL_34:
			array = new double[]
			{
				288.5,
				296.5,
				304.7,
				313.0,
				321.7,
				330.5,
				339.6,
				346.7,
				349.0,
				358.6,
				358.9,
				368.5,
				371.5,
				378.6,
				384.6,
				389.0,
				398.1,
				399.8,
				410.8,
				412.1,
				422.1,
				426.6,
				433.7,
				441.6,
				445.7,
				457.1,
				457.9,
				470.5,
				473.2,
				483.5,
				489.8,
				496.8,
				507.0,
				510.5,
				517.5,
				524.6,
				524.8,
				532.5,
				539.0,
				543.3,
				547.5,
				553.9,
				562.3,
				562.5,
				569.1,
				577.5,
				582.1,
				584.8,
				592.5,
				600.9,
				602.6,
				607.5,
				617.4,
				622.5,
				623.7,
				634.5,
				637.5,
				645.7,
				651.9,
				652.5,
				667.5,
				668.3,
				669.9,
				682.5,
				688.3,
				691.8,
				697.5,
				707.3,
				712.5,
				716.7,
				726.8,
				727.5,
				741.3,
				746.8,
				757.5,
				767.4,
				772.5,
				787.5,
				788.5,
				794.3,
				802.5,
				810.2,
				817.5,
				822.2,
				832.5,
				847.5,
				851.1,
				855.5,
				862.5,
				877.5,
				879.0,
				881.0,
				892.5,
				903.2,
				907.5,
				912.0,
				922.5,
				928.1,
				937.5,
				944.1,
				952.5,
				953.7,
				967.5,
				979.9,
				1006.9,
				1034.7,
				1063.2,
				1092.4,
				1122.5,
				1153.4,
				1185.2,
				1217.8,
				1251.4,
				1285.8,
				1321.2,
				1357.6,
				1395.0,
				1433.4,
				1472.9,
				1513.5,
				1555.2,
				1598.0,
				1642.0,
				1687.2,
				1733.7,
				1781.5,
				1830.5,
				1881.0,
				1930.2,
				1989.1,
				2043.8,
				2094.5,
				2155.6,
				2212.2,
				2271.7,
				2334.6,
				2401.0,
				2468.2
			};
			num4 = -1;
			num3 = 0;
			IL_4E:
			num2 = (short)275709952;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600010D RID: 269 RVA: 0x000308A0 File Offset: 0x0002EAA0
		private void ResetMotionSensitivityDefaultValue()
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.ManDown manDown;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					manDown.EmerWideManDownMotionlessSensitivity_A40002.SetValue(1);
					num2 = (short)940464964;
					short num3 = num2;
					num2 = (short)525818692;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)660144129;
						if (num2 != 0)
						{
						}
						num2 = (short)864157696;
						if (num2 != 0)
						{
						}
						num2 = (short)537395201;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
					return;
				case 2:
					if (manDown != null)
					{
						num2 = (short)112787456;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				goto IL_1C;
			}
			return;
			IL_1C:
			num2 = (short)299433984;
			short num4 = num2;
			manDown = ((global::AcpCommonLib.FeatureManager.GetFeature(2032) as global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.EmergencyWideRecset)[0][10639] as global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.ManDown);
			num2 = (short)1896284162;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600010E RID: 270 RVA: 0x000309E4 File Offset: 0x0002EBE4
		public void ResolveUCLReferenceAfterUnpack()
		{
			short num = (short)728236032;
			switch (num)
			{
			default:
			{
				num = (short)456130560;
				short num2 = num;
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = ((global::SpecialFeatures.Ucl.Contact.UclContactRecset)global::AcpCommonLib.FeatureManager.GetFeature(2200)).GetEnumerator();
				try
				{
					num = (short)646119428;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
						{
							num = (short)1191292752;
							short num4 = num;
							num = (short)1120579408;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_555;
							default:
								goto IL_5A5;
							}
							break;
						}
						case 1:
							goto IL_555;
						case 2:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)2038628353;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpRecordset> enumerator2 = ((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current).EmbeddedRecordsets.GetEnumerator();
							num = (short)686424067;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							try
							{
								num = (short)1468137476;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpRecordset> enumerator2;
									global::AcpCommonLib.IAcpRecordset acpRecordset;
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator3;
									switch (num3)
									{
									case 0:
										goto IL_4E4;
									case 1:
										try
										{
											num = (short)1552089097;
											num3 = (int)((global::System.IntPtr)num);
											for (;;)
											{
												switch (num3)
												{
												case 0:
													if (acpRecordset.ParentSection.FeatureSectionId == 10411)
													{
														num = (short)1498218497;
														num3 = (int)((global::System.IntPtr)num);
														continue;
													}
													num = (short)1043726349;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												case 1:
												{
													global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
													((global::SpecialFeatures.Ucl.Contact.TrunkingT2CallListCallListSection)acpFeatureNode[10412]).ResolveReferenceAfterUnpack();
													num = (short)1341784074;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												case 2:
													if (acpRecordset.ParentSection.FeatureSectionId == 10401)
													{
														num = (short)1455816718;
														num3 = (int)((global::System.IntPtr)num);
														continue;
													}
													num = (short)1955397632;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												case 3:
													num = (short)308150277;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												case 4:
												{
													global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
													((global::SpecialFeatures.Ucl.Contact.MDCCallListCallListSection)acpFeatureNode[10406]).ResolveReferenceAfterUnpack();
													num = (short)1818492936;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												case 5:
													goto IL_428;
												case 6:
												{
													global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
													((global::SpecialFeatures.Ucl.Contact.AstroCallListCallListSection)acpFeatureNode[10404]).ResolveReferenceAfterUnpack();
													num = (short)2027749383;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												case 9:
													switch (0)
													{
													case 0:
														goto IL_1E1;
													}
													continue;
												case 11:
													if (acpRecordset.ParentSection.FeatureSectionId == 10405)
													{
														num = (short)2109997060;
														num3 = (int)((global::System.IntPtr)num);
														continue;
													}
													break;
												case 13:
													if (acpRecordset.ParentSection.FeatureSectionId == 10403)
													{
														num = (short)1869676550;
														num3 = (int)((global::System.IntPtr)num);
														continue;
													}
													num = (short)876150795;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												case 14:
												{
													global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
													((global::SpecialFeatures.Ucl.Contact.TrunkingCallListCallListSection)acpFeatureNode[10402]).ResolveReferenceAfterUnpack();
													num = (short)708116492;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												case 15:
												{
													if (!enumerator3.MoveNext())
													{
														num = (short)497221635;
														num3 = (int)((global::System.IntPtr)num);
														continue;
													}
													global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator3.Current;
													num = (short)219348994;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												}
												IL_1E6:
												num = (short)1643511823;
												num3 = (int)((global::System.IntPtr)num);
												continue;
												IL_1E1:
												goto IL_1E6;
											}
											IL_428:
											break;
										}
										finally
										{
											num = (short)1931935746;
											num3 = (int)((global::System.IntPtr)num);
											for (;;)
											{
												switch (num3)
												{
												case 0:
													enumerator3.Dispose();
													num = (short)1102839809;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												case 1:
													goto IL_498;
												case 2:
													switch (0)
													{
													case 0:
														goto IL_460;
													}
													continue;
												}
												IL_460:
												if (enumerator3 == null)
												{
													break;
												}
												num = (short)1322385408;
												num3 = (int)((global::System.IntPtr)num);
											}
											IL_498:;
										}
										goto IL_49B;
									case 2:
										num = (short)1445593088;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 3:
										if (!enumerator2.MoveNext())
										{
											num = (short)1092812802;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_49B;
									case 4:
										switch (0)
										{
										case 0:
											goto IL_13B;
										}
										continue;
									}
									IL_140:
									num = (short)187957251;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_13B:
									goto IL_140;
									IL_49B:
									acpRecordset = enumerator2.Current;
									enumerator3 = ((global::AcpBusinessLayer.Recordset)acpRecordset).GetEnumerator();
									num = (short)1286078465;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_4E4:
								break;
							}
							finally
							{
								num = (short)298647554;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpRecordset> enumerator2;
									switch (num3)
									{
									case 0:
										enumerator2.Dispose();
										num = (short)2011037697;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										goto IL_552;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_51B;
										}
										continue;
									}
									IL_51B:
									if (enumerator2 == null)
									{
										break;
									}
									num = (short)383254528;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_552:;
							}
							goto IL_555;
						case 4:
							switch (0)
							{
							case 0:
								goto IL_99;
							}
							continue;
						}
						IL_C6:
						num = (short)231800834;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_99:
						goto IL_C6;
						IL_555:
						num = (short)734986240;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_5A5:
					num = (short)2060320768;
					if (num != 0)
					{
					}
				}
				finally
				{
					num = (short)1929117698;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							num = (short)1704460289;
							if (num != 0)
							{
							}
							enumerator.Dispose();
							num = (short)1619918849;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_651;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_5F3;
							}
							continue;
						}
						IL_5F3:
						if (enumerator == null)
						{
							break;
						}
						num = (short)2020474880;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_651:;
				}
				return;
			}
			}
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00031094 File Offset: 0x0002F294
		private void ResolvedMFKTimerUnpack()
		{
			switch (0)
			{
			case 0:
				goto IL_44;
			}
			int num;
			short num2;
			int codeplugMainVersion;
			for (;;)
			{
				IL_0A:
				global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide radioErgonomicsWide;
				switch (num)
				{
				case 0:
					goto IL_11F;
				case 1:
					radioErgonomicsWide.Advanced.RadErgoWideAdvancedShortKeypressDurationforMFK_A38505.ResetToDefault();
					num2 = (short)757006346;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_205;
				case 3:
					if (radioErgonomicsWide.Advanced.RadErgoWideAdvancedShortKeypressDurationforMFK_A38505.Value == 0)
					{
						num2 = (short)826343425;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 4:
					if (radioErgonomicsWide.Advanced.RadErgoWideAdvancedMFKInactivityTimeout_A38507.Value == 0)
					{
						num2 = (short)367001611;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_251;
				case 5:
					if (radioErgonomicsWide.Advanced.RadErgoWideAdvancedLongKeypressDurationforMFK_A38506.Value == 0)
					{
						num2 = (short)821428233;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_11F;
				case 6:
					if (codeplugMainVersion != 6)
					{
						num2 = (short)2065825804;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_164;
				case 7:
					goto IL_251;
				case 8:
					goto IL_164;
				case 9:
					radioErgonomicsWide.Advanced.RadErgoWideAdvancedLongKeypressDurationforMFK_A38506.ResetToDefault();
					num2 = (short)328073216;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					return;
				case 11:
					radioErgonomicsWide.Advanced.RadErgoWideAdvancedMFKInactivityTimeout_A38507.ResetToDefault();
					num2 = (short)236388359;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 12:
				{
					num2 = (short)1519569154;
					short num3 = num2;
					num2 = (short)49203458;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_205;
					default:
						num2 = (short)1564082176;
						if (num2 != 0)
						{
						}
						num2 = (short)34865153;
						if (num2 != 0)
						{
						}
						num2 = (short)900464642;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_44;
				IL_11F:
				num2 = (short)1575550980;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_164:
				radioErgonomicsWide = (global::AcpCommonLib.FeatureManager.GetFeature(2033)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide);
				num2 = (short)697761797;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_205:
				num2 = (short)2114387968;
				short num4 = num2;
				if (codeplugMainVersion == 5)
				{
					num2 = (short)1258029064;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				break;
				IL_251:
				num2 = (short)1852571651;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_44:
			codeplugMainVersion = this.GetCodeplugMainVersion();
			num2 = (short)122224646;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00031364 File Offset: 0x0002F564
		public static void PostUpgradeCodeplugProccessing(string codeplugVersion, string appVersion)
		{
			short num;
			try
			{
				num = (short)376635392;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					switch (0)
					{
					case 0:
						goto IL_86;
					}
					int num3;
					int num4;
					for (;;)
					{
						IL_27:
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemRecset conventionalSystemRecset;
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
						switch (num2)
						{
						case 0:
						{
							global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = (global::AcpCommonLib.FeatureManager.GetFeature(2054) as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesRecset).GetEnumerator();
							num = (short)1324351504;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							if (num3 > num4)
							{
								num = (short)937361426;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_4C4;
						case 2:
							if (num4 < 13)
							{
								num = (short)839778310;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_4C4;
						case 3:
							if (global::AcpCommonLib.Permission.Have(global::AcpCommonLib.Permissions.RefernceDisabled, conventionalSystemRecset[0].Permissions))
							{
								num = (short)1591803909;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_59A;
						case 4:
							num = (short)1519190018;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							num = (short)1481113609;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							num = (short)1504051207;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							if (num3 >= 13)
							{
								num = (short)717619208;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_4C4;
						case 8:
							num = (short)1322582017;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 9:
							if ((global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation).Labtool.RadInfoLabtoolQ806IMBE_A8191.Value)
							{
								num = (short)337313812;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_59A;
						case 10:
							if (num4 < 3)
							{
								num = (short)1800994831;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2A0;
						case 11:
							goto IL_5B2;
						case 12:
							num = (short)347734029;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 13:
							if (num3 > num4)
							{
								num = (short)1245839360;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2A0;
						case 14:
							if (num3 > 2)
							{
								num = (short)437452812;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2A0;
						case 15:
							num = (short)1433731086;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 16:
							try
							{
								num = (short)1944649732;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
									{
										num = (short)1212257113;
										short num5 = num;
										num = (short)1793692505;
										switch ((num5 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_3EB;
										default:
											goto IL_43A;
										}
										break;
									}
									case 1:
										goto IL_3EB;
									case 2:
									{
										global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
										if (!enumerator.MoveNext())
										{
											num = (short)211156993;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles = (global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles)enumerator.Current;
										dataProfiles.General.DataConfigDataProfRandomHoldOffTime_A36552.Value = dataProfiles.General.DataConfigDataProfRandomHoldOffTime_A36552.DefaultValue;
										global::MackinawCPS.DocumentOperations.SetFixedNumRecords(dataProfiles.DAC.EmbeddedRecset as global::AcpBusinessLayer.Recordset, 16);
										global::MackinawCPS.DocumentOperations.SetFixedNumRecords(dataProfiles.TrunkingGroupID.EmbeddedRecset as global::AcpBusinessLayer.Recordset, 8);
										num = (short)1549795331;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 4:
										switch (0)
										{
										case 0:
											goto IL_32F;
										}
										continue;
									}
									IL_3AC:
									num = (short)1386872834;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_32F:
									goto IL_3AC;
									IL_3EB:
									num = (short)1300365312;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_43A:
								num = (short)745603072;
								if (num != 0)
								{
								}
								goto IL_2A0;
							}
							finally
							{
								num = (short)795279362;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									switch (num2)
									{
									case 0:
										enumerator.Dispose();
										num = (short)1100283905;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										goto IL_4C1;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_488;
										}
										continue;
									}
									IL_488:
									if (enumerator == null)
									{
										break;
									}
									num = (short)1524039680;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_4C1:;
							}
							goto IL_4C4;
						case 17:
							goto IL_59A;
						case 18:
							radioWide.Location.GPSFailToneInterval_42329.Value = radioWide.Location.GPSFailToneInterval_42329.DefaultValue;
							num = (short)1700397077;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 19:
							if (radioWide != null)
							{
								num = (short)24903684;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_4C4;
						case 20:
							((global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.General)conventionalSystemRecset[0][10118]).CnvSysGeneralSystemType_A13262Value = 0;
							num = (short)1124532241;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 21:
							goto IL_4C4;
						}
						goto IL_86;
						IL_2A0:
						radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
						num = (short)328007699;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_4C4:
						conventionalSystemRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2053) as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemRecset);
						num = (short)267517955;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_59A:
						num = (short)1963327499;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_5B2:
					break;
					IL_86:
					num4 = int.Parse(codeplugVersion.Substring(1, 2));
					num3 = int.Parse(appVersion.Substring(1, 2));
					num = (short)818085898;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_27;
				}
				}
			}
			catch (global::System.Exception)
			{
			}
			num = (short)1084882945;
			if (num != 0)
			{
			}
			num = (short)312016896;
			short num6 = num;
		}

		// Token: 0x06000111 RID: 273 RVA: 0x000319B0 File Offset: 0x0002FBB0
		public static void SetFixedNumRecords(global::AcpBusinessLayer.Recordset recordset, int FixedTableRecordNumber)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					if (recordset.Count >= FixedTableRecordNumber)
					{
						num2 = (short)180420610;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1511981057;
					if (num2 != 0)
					{
					}
					num2 = (short)1406497376;
					short num3 = num2;
					num2 = (short)1944613472;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)180748288;
						if (num2 != 0)
						{
						}
						recordset.AddRecord(recordset.CreateDefaultRecord());
						break;
					}
					num2 = (short)760414208;
					short num4 = num2;
					num2 = (short)1466761219;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					goto IL_44;
				case 2:
					return;
				case 3:
					goto IL_44;
				}
				goto IL_20;
				IL_44:
				num2 = (short)1298857984;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_20:
			recordset.Max = FixedTableRecordNumber;
			recordset.Min = FixedTableRecordNumber;
			num2 = (short)1514274817;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00031B00 File Offset: 0x0002FD00
		private bool O9TableInit()
		{
			short num = (short)1982398464;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_253;
				}
				bool result;
				for (;;)
				{
					IL_28:
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset controlHeadO9Recset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset controlHeadO9Recset2;
					global::Motorola.MackinawCPS.CoreFeatures.Shepherds.ShepherdsRecset shepherdsRecset;
					global::Motorola.MackinawCPS.CoreFeatures.Shepherds.ConventionalShepherdListInnerRecset conventionalShepherdListInnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.Shepherds.TrunkingShepherdListInnerRecset trunkingShepherdListInnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInnerRecset signalIndependentProductIndependentNonProgrammableButtonListInnerRecset;
					switch (num2)
					{
					case 0:
						goto IL_BB3;
					case 1:
						goto IL_111A;
					case 2:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerRecset generalLightbarPatternInnerRecset;
						if (generalLightbarPatternInnerRecset.Count >= 3)
						{
							num = (short)1925906453;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						generalLightbarPatternInnerRecset.AddRecord(generalLightbarPatternInnerRecset.CreateDefaultRecord());
						result = true;
						num = (short)444727296;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButtonInnerRecset bottomFunctionProgrammableButtonInnerRecset;
						if (bottomFunctionProgrammableButtonInnerRecset != null)
						{
							num = (short)457506950;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AEB;
					}
					case 4:
						goto IL_CC4;
					case 5:
						goto IL_1754;
					case 6:
						return result;
					case 7:
						goto IL_CC4;
					case 8:
					{
						if (!global::ConstraintHelper.UtilityMack.IsMobileOnly())
						{
							num = (short)1196032049;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::AcpCommonLib.IAcpRecordset feature = global::AcpCommonLib.FeatureManager.GetFeature(2045);
						num = (short)1074528374;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ResponseSelectorListInnerRecset responseSelectorListInnerRecset;
						if (responseSelectorListInnerRecset.Count < 4)
						{
							num = (short)709034096;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E96;
					}
					case 10:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.DirectionalButtonsListInnerRecset directionalButtonsListInnerRecset;
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.DirectionalButtonsListInnerSection directionalButtonsListInnerSection = (directionalButtonsListInnerRecset[0] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.DirectionalButtonsListInner).DirectionalButtonsListInnerSection;
						directionalButtonsListInnerSection.RadErgCtrlHeadO9DirLightBarBCO_A36559.Value = 118;
						directionalButtonsListInnerSection.RadErgCtrlHeadO9DirLightBarName_A36558.Value = global::CommonResources.AppResources.Top_Center;
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.DirectionalButtonsListInnerSection directionalButtonsListInnerSection2 = (directionalButtonsListInnerRecset[1] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.DirectionalButtonsListInner).DirectionalButtonsListInnerSection;
						directionalButtonsListInnerSection2.RadErgCtrlHeadO9DirLightBarBCO_A36559.Value = 120;
						directionalButtonsListInnerSection2.RadErgCtrlHeadO9DirLightBarName_A36558.Value = global::CommonResources.AppResources.Left_Id;
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.DirectionalButtonsListInnerSection directionalButtonsListInnerSection3 = (directionalButtonsListInnerRecset[2] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.DirectionalButtonsListInner).DirectionalButtonsListInnerSection;
						directionalButtonsListInnerSection3.RadErgCtrlHeadO9DirLightBarBCO_A36559.Value = 119;
						directionalButtonsListInnerSection3.RadErgCtrlHeadO9DirLightBarName_A36558.Value = global::CommonResources.AppResources.Right_ID;
						num = (short)414777399;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						goto IL_83B;
					case 12:
					{
						bool flag = false;
						num = (short)829816876;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
					{
						num = (short)702021633;
						if (num != 0)
						{
						}
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButtonInnerRecset bottomFunctionProgrammableButtonInnerRecset;
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButtonInnerSection bottomFunctionProgrammableButtonInnerSection = (bottomFunctionProgrammableButtonInnerRecset[0] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButtonInner).BottomFunctionProgrammableButtonInnerSection;
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionButtonBCOListInnerRecset bottomFunctionButtonBCOListInnerRecset;
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionButtonBCOListInnerSection bottomFunctionButtonBCOListInnerSection = (bottomFunctionButtonBCOListInnerRecset[0] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionButtonBCOListInner).BottomFunctionButtonBCOListInnerSection;
						bottomFunctionProgrammableButtonInnerSection.CHO9BottomFunctionButtonBCO_A36660.Value = 165;
						bottomFunctionProgrammableButtonInnerSection.CHO9BottomFunctionButtonName_A36657.Value = global::CommonResources.AcgResources.ID_P1;
						bottomFunctionProgrammableButtonInnerSection.CHO9BottomFunctionButtonFeature_A36664.SetValue(bottomFunctionButtonBCOListInnerSection.CHO9BottomFunctionButtonFeature_A36826.Value);
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButtonInnerSection bottomFunctionProgrammableButtonInnerSection2 = (bottomFunctionProgrammableButtonInnerRecset[1] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButtonInner).BottomFunctionProgrammableButtonInnerSection;
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionButtonBCOListInnerSection bottomFunctionButtonBCOListInnerSection2 = (bottomFunctionButtonBCOListInnerRecset[1] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionButtonBCOListInner).BottomFunctionButtonBCOListInnerSection;
						bottomFunctionProgrammableButtonInnerSection2.CHO9BottomFunctionButtonBCO_A36660.Value = 166;
						bottomFunctionProgrammableButtonInnerSection2.CHO9BottomFunctionButtonName_A36657.Value = global::CommonResources.AppResources.P2_Id;
						bottomFunctionProgrammableButtonInnerSection2.CHO9BottomFunctionButtonFeature_A36664.SetValue(bottomFunctionButtonBCOListInnerSection2.CHO9BottomFunctionButtonFeature_A36826.Value);
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButtonInnerSection bottomFunctionProgrammableButtonInnerSection3 = (bottomFunctionProgrammableButtonInnerRecset[2] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButtonInner).BottomFunctionProgrammableButtonInnerSection;
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionButtonBCOListInnerSection bottomFunctionButtonBCOListInnerSection3 = (bottomFunctionButtonBCOListInnerRecset[2] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionButtonBCOListInner).BottomFunctionButtonBCOListInnerSection;
						bottomFunctionProgrammableButtonInnerSection3.CHO9BottomFunctionButtonBCO_A36660.Value = 167;
						bottomFunctionProgrammableButtonInnerSection3.CHO9BottomFunctionButtonName_A36657.Value = global::CommonResources.AppResources.P3_Id;
						bottomFunctionProgrammableButtonInnerSection3.CHO9BottomFunctionButtonFeature_A36664.SetValue(bottomFunctionButtonBCOListInnerSection3.CHO9BottomFunctionButtonFeature_A36826.Value);
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButtonInnerSection bottomFunctionProgrammableButtonInnerSection4 = (bottomFunctionProgrammableButtonInnerRecset[3] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButtonInner).BottomFunctionProgrammableButtonInnerSection;
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionButtonBCOListInnerSection bottomFunctionButtonBCOListInnerSection4 = (bottomFunctionButtonBCOListInnerRecset[3] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionButtonBCOListInner).BottomFunctionButtonBCOListInnerSection;
						bottomFunctionProgrammableButtonInnerSection4.CHO9BottomFunctionButtonBCO_A36660.Value = 168;
						bottomFunctionProgrammableButtonInnerSection4.CHO9BottomFunctionButtonName_A36657.Value = global::CommonResources.AppResources.P4_Id;
						bottomFunctionProgrammableButtonInnerSection4.CHO9BottomFunctionButtonFeature_A36664.SetValue(bottomFunctionButtonBCOListInnerSection4.CHO9BottomFunctionButtonFeature_A36826.Value);
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButtonInnerSection bottomFunctionProgrammableButtonInnerSection5 = (bottomFunctionProgrammableButtonInnerRecset[4] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButtonInner).BottomFunctionProgrammableButtonInnerSection;
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionButtonBCOListInnerSection bottomFunctionButtonBCOListInnerSection5 = (bottomFunctionButtonBCOListInnerRecset[4] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionButtonBCOListInner).BottomFunctionButtonBCOListInnerSection;
						bottomFunctionProgrammableButtonInnerSection5.CHO9BottomFunctionButtonBCO_A36660.Value = 169;
						bottomFunctionProgrammableButtonInnerSection5.CHO9BottomFunctionButtonName_A36657.Value = global::CommonResources.AppResources.P5_Id;
						bottomFunctionProgrammableButtonInnerSection5.CHO9BottomFunctionButtonFeature_A36664.SetValue(bottomFunctionButtonBCOListInnerSection5.CHO9BottomFunctionButtonFeature_A36826.Value);
						num = (short)1587806331;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
						goto IL_145C;
					case 15:
						goto IL_1687;
					case 16:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ResponseSelectorListInnerRecset responseSelectorListInnerRecset = controlHeadO9Recset[0][10624].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ResponseSelectorListInnerRecset;
						num = (short)776405071;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
						goto IL_2D7;
					case 18:
						if (controlHeadO9Recset2 != null)
						{
							num = (short)1417871401;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A28;
					case 19:
						goto IL_95C;
					case 20:
					{
						bool flag2;
						if (flag2)
						{
							num = (short)656539711;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E96;
					}
					case 21:
						num = (short)1463943283;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						goto IL_E35;
					case 23:
						num = (short)1625227337;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.PASirenButtonsListInnerSection pasirenButtonsListInnerSection;
						pasirenButtonsListInnerSection.CHO9PASirenButtonsBCO_A41538.Value = 117;
						pasirenButtonsListInnerSection.CHO9PASirenButtonsName_A41537.Value = global::CommonResources.AppResources.O9_Siren_Airhorn;
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.PASirenButtonsListInnerSection pasirenButtonsListInnerSection2;
						pasirenButtonsListInnerSection2.CHO9PASirenButtonsBCO_A41538.Value = 112;
						pasirenButtonsListInnerSection2.CHO9PASirenButtonsName_A41537.Value = global::CommonResources.AppResources.O9_Siren_Manual;
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.PASirenButtonsListInnerSection pasirenButtonsListInnerSection3;
						pasirenButtonsListInnerSection3.CHO9PASirenButtonsBCO_A41538.Value = 113;
						pasirenButtonsListInnerSection3.CHO9PASirenButtonsName_A41537.Value = global::CommonResources.AppResources.O9_Siren_Wail;
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.PASirenButtonsListInnerSection pasirenButtonsListInnerSection4;
						pasirenButtonsListInnerSection4.CHO9PASirenButtonsBCO_A41538.Value = 114;
						pasirenButtonsListInnerSection4.CHO9PASirenButtonsName_A41537.Value = global::CommonResources.AppResources.O9_Siren_Yelp;
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.PASirenButtonsListInnerSection pasirenButtonsListInnerSection5;
						pasirenButtonsListInnerSection5.CHO9PASirenButtonsBCO_A41538.Value = 115;
						pasirenButtonsListInnerSection5.CHO9PASirenButtonsName_A41537.Value = global::CommonResources.AppResources.O9_Siren_Hilo;
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.PASirenButtonsListInnerSection pasirenButtonsListInnerSection6;
						pasirenButtonsListInnerSection6.CHO9PASirenButtonsBCO_A41538.Value = 116;
						pasirenButtonsListInnerSection6.CHO9PASirenButtonsName_A41537.Value = global::CommonResources.AppResources.O9_Siren_PA;
						num = (short)290652161;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 25:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.DirectionalButtonsListInnerRecset directionalButtonsListInnerRecset;
						if (directionalButtonsListInnerRecset != null)
						{
							num = (short)1123287157;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A28;
					}
					case 26:
						goto IL_880;
					case 27:
					{
						bool flag;
						if (flag)
						{
							num = (short)1715535928;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_145C;
					}
					case 28:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RelockTimerInnerRecset relockTimerInnerRecset;
						if (relockTimerInnerRecset.Count >= 3)
						{
							num = (short)1096155266;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						relockTimerInnerRecset.AddRecord(relockTimerInnerRecset.CreateDefaultRecord());
						num = (short)798949381;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 29:
					{
						global::Motorola.MackinawCPS.CoreFeatures.Shepherds.GlobalShepherdListInnerRecset globalShepherdListInnerRecset;
						if (globalShepherdListInnerRecset != null)
						{
							num = (short)2008743982;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_BF2;
					}
					case 30:
						num = (short)907477001;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerRecset topFunctionProgrammableButtonListInnerRecset;
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerSection topFunctionProgrammableButtonListInnerSection = (topFunctionProgrammableButtonListInnerRecset[0] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInner).TopFunctionProgrammableButtonListInnerSection;
						topFunctionProgrammableButtonListInnerSection.O9CHTrkTopFunctionButtonBCO_A36636.Value = 160;
						topFunctionProgrammableButtonListInnerSection.CnvTopFunctionButtonBCO_A36628.Value = 160;
						topFunctionProgrammableButtonListInnerSection.CHO9TopFunctionButton_A36618.Value = global::CommonResources.AppResources.Button_1;
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerSection topFunctionProgrammableButtonListInnerSection2 = (topFunctionProgrammableButtonListInnerRecset[1] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInner).TopFunctionProgrammableButtonListInnerSection;
						topFunctionProgrammableButtonListInnerSection2.O9CHTrkTopFunctionButtonBCO_A36636.Value = 161;
						topFunctionProgrammableButtonListInnerSection2.CnvTopFunctionButtonBCO_A36628.Value = 161;
						topFunctionProgrammableButtonListInnerSection2.CHO9TopFunctionButton_A36618.Value = global::CommonResources.AppResources.Button_2;
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerSection topFunctionProgrammableButtonListInnerSection3 = (topFunctionProgrammableButtonListInnerRecset[2] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInner).TopFunctionProgrammableButtonListInnerSection;
						topFunctionProgrammableButtonListInnerSection3.O9CHTrkTopFunctionButtonBCO_A36636.Value = 162;
						topFunctionProgrammableButtonListInnerSection3.CnvTopFunctionButtonBCO_A36628.Value = 162;
						topFunctionProgrammableButtonListInnerSection3.CHO9TopFunctionButton_A36618.Value = global::CommonResources.AppResources.Button_3;
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerSection topFunctionProgrammableButtonListInnerSection4 = (topFunctionProgrammableButtonListInnerRecset[3] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInner).TopFunctionProgrammableButtonListInnerSection;
						topFunctionProgrammableButtonListInnerSection4.O9CHTrkTopFunctionButtonBCO_A36636.Value = 163;
						topFunctionProgrammableButtonListInnerSection4.CnvTopFunctionButtonBCO_A36628.Value = 163;
						topFunctionProgrammableButtonListInnerSection4.CHO9TopFunctionButton_A36618.Value = global::CommonResources.AppResources.Button_4;
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerSection topFunctionProgrammableButtonListInnerSection5 = (topFunctionProgrammableButtonListInnerRecset[4] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInner).TopFunctionProgrammableButtonListInnerSection;
						topFunctionProgrammableButtonListInnerSection5.O9CHTrkTopFunctionButtonBCO_A36636.Value = 164;
						topFunctionProgrammableButtonListInnerSection5.CnvTopFunctionButtonBCO_A36628.Value = 164;
						topFunctionProgrammableButtonListInnerSection5.CHO9TopFunctionButton_A36618.Value = global::CommonResources.AppResources.Button_5;
						num = (short)216268905;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 32:
					{
						bool flag3;
						if (flag3)
						{
							num = (short)401342495;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B56;
					}
					case 33:
						if (controlHeadO9Recset != null)
						{
							num = (short)92667920;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E96;
					case 34:
						goto IL_BF2;
					case 35:
						if (shepherdsRecset != null)
						{
							num = (short)1875378215;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_111A;
					case 36:
						goto IL_19CC;
					case 37:
						num = (short)520552490;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 38:
						num = (short)2053701690;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 39:
					{
						global::Motorola.MackinawCPS.CoreFeatures.Shepherds.GlobalShepherdListInnerRecset globalShepherdListInnerRecset = shepherdsRecset[0][10033].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.Shepherds.GlobalShepherdListInnerRecset;
						num = (short)687407133;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 40:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerRecset topFunctionProgrammableButtonListInnerRecset;
						if (topFunctionProgrammableButtonListInnerRecset != null)
						{
							num = (short)1468989488;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B56;
					}
					case 41:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.DirectionalButtonsListInnerRecset directionalButtonsListInnerRecset = controlHeadO9Recset2[0][10609].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.DirectionalButtonsListInnerRecset;
						num = (short)1865941017;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 42:
						goto IL_12E7;
					case 43:
						goto IL_1276;
					case 44:
						goto IL_83B;
					case 45:
						goto IL_95C;
					case 46:
						num = (short)668401723;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 47:
						goto IL_E35;
					case 48:
						num = (short)1421475951;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 49:
						return result;
					case 50:
						if (conventionalShepherdListInnerRecset != null)
						{
							num = (short)1522860069;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2D7;
					case 51:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ResponseSelectorListInnerRecset responseSelectorListInnerRecset;
						if (responseSelectorListInnerRecset.Count >= 4)
						{
							num = (short)925368414;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						responseSelectorListInnerRecset.AddRecord(responseSelectorListInnerRecset.CreateDefaultRecord());
						bool flag2 = true;
						num = (short)1314127891;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 52:
						goto IL_1CB0;
					case 53:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerRecset topFunctionProgrammableButtonListInnerRecset;
						if (topFunctionProgrammableButtonListInnerRecset.Count >= 5)
						{
							num = (short)1354170503;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						topFunctionProgrammableButtonListInnerRecset.AddRecord(topFunctionProgrammableButtonListInnerRecset.CreateDefaultRecord());
						bool flag3 = true;
						num = (short)691273800;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 54:
					{
						num = (short)27394048;
						short num3 = num;
						if (controlHeadO9Recset != null)
						{
							num = (short)2114256958;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B56;
					}
					case 55:
						goto IL_A28;
					case 56:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.RelayPatternBCOListListInnerRecset relayPatternBCOListListInnerRecset;
						(relayPatternBCOListListInnerRecset[0] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.RelayPatternBCOListListInner).RelayPatternBCOListListInnerSection.RdEgoO9DirLtbarPatternBcoListBco_A36661.Value = 118;
						(relayPatternBCOListListInnerRecset[1] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.RelayPatternBCOListListInner).RelayPatternBCOListListInnerSection.RdEgoO9DirLtbarPatternBcoListBco_A36661.Value = 120;
						(relayPatternBCOListListInnerRecset[2] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.RelayPatternBCOListListInner).RelayPatternBCOListListInnerSection.RdEgoO9DirLtbarPatternBcoListBco_A36661.Value = 119;
						num = (short)1058668558;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 57:
					{
						bool flag4;
						if (flag4)
						{
							num = (short)443351050;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A28;
					}
					case 58:
						goto IL_1276;
					case 59:
						goto IL_183B;
					case 60:
						if (trunkingShepherdListInnerRecset != null)
						{
							num = (short)355139622;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_157F;
					case 61:
						if (conventionalShepherdListInnerRecset.Count >= 4)
						{
							num = (short)1699872785;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						conventionalShepherdListInnerRecset.AddRecord(conventionalShepherdListInnerRecset.CreateDefaultRecord());
						num = (short)568197215;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 62:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerRecset topFunctionProgrammableButtonListInnerRecset = controlHeadO9Recset[0][10616].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerRecset;
						num = (short)1553334312;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 63:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ResponseSelectorListInnerRecset responseSelectorListInnerRecset;
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ResponseSelectorListInnerSection responseSelectorListInnerSection = (responseSelectorListInnerRecset[0] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ResponseSelectorListInner).ResponseSelectorListInnerSection;
						responseSelectorListInnerSection.CHO9PursuitKnobMode_A36683.Value = global::CommonResources.AppResources.Mode_0;
						responseSelectorListInnerSection.CHO9PursuitKnobIndex_A36685.ReferencedIndex = 1;
						(responseSelectorListInnerRecset[1] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ResponseSelectorListInner).ResponseSelectorListInnerSection.CHO9PursuitKnobMode_A36683.Value = global::CommonResources.AppResources.Mode_1;
						(responseSelectorListInnerRecset[2] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ResponseSelectorListInner).ResponseSelectorListInnerSection.CHO9PursuitKnobMode_A36683.Value = global::CommonResources.AppResources.Mode_2;
						(responseSelectorListInnerRecset[3] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ResponseSelectorListInner).ResponseSelectorListInnerSection.CHO9PursuitKnobMode_A36683.Value = global::CommonResources.AppResources.Mode_3;
						num = (short)1340932165;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 64:
					{
						bool flag3 = false;
						num = (short)267518053;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 65:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerRecset generalLightbarPatternInnerRecset;
						if (generalLightbarPatternInnerRecset != null)
						{
							num = (short)1274085492;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1800;
					}
					case 66:
						goto IL_BB3;
					case 67:
					{
						global::AcpCommonLib.IAcpRecordset feature;
						if (feature != null)
						{
							num = (short)1039335553;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					case 68:
						if (signalIndependentProductIndependentNonProgrammableButtonListInnerRecset.Count >= 34)
						{
							num = (short)970850319;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						signalIndependentProductIndependentNonProgrammableButtonListInnerRecset.AddRecord(signalIndependentProductIndependentNonProgrammableButtonListInnerRecset.CreateDefaultRecord());
						num = (short)907608100;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 69:
						goto IL_E96;
					case 70:
						num = (short)179241091;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 71:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerRecset generalLightbarPatternInnerRecset;
						if (generalLightbarPatternInnerRecset.Count < 3)
						{
							num = (short)1349320782;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1800;
					}
					case 72:
						goto IL_16C4;
					case 73:
						goto IL_19CC;
					case 74:
						goto IL_1CB0;
					case 75:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.PASirenButtonsListInnerRecset pasirenButtonsListInnerRecset = controlHeadO9Recset2[0][10743].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.PASirenButtonsListInnerRecset;
						num = (short)36110472;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 76:
						if (controlHeadO9Recset2 != null)
						{
							num = (short)1254031486;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_145C;
					case 77:
						if (controlHeadO9Recset2 != null)
						{
							num = (short)2034434123;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_111A;
					case 78:
						num = (short)1305608258;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 79:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ResponseSelectorListInnerRecset responseSelectorListInnerRecset;
						if (responseSelectorListInnerRecset != null)
						{
							num = (short)574226462;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E96;
					}
					case 80:
					{
						bool flag5 = false;
						num = (short)2126577711;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 81:
						num = (short)549191732;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 82:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerRecset generalLightbarPatternInnerRecset2;
						if (generalLightbarPatternInnerRecset2.Count >= 3)
						{
							num = (short)115408993;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						generalLightbarPatternInnerRecset2.AddRecord(generalLightbarPatternInnerRecset2.CreateDefaultRecord());
						num = (short)331481162;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 83:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.PASirenButtonsListInnerRecset pasirenButtonsListInnerRecset;
						if (pasirenButtonsListInnerRecset.Count >= 6)
						{
							num = (short)1557069934;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						pasirenButtonsListInnerRecset.AddRecord(pasirenButtonsListInnerRecset.CreateDefaultRecord());
						bool flag6 = true;
						num = (short)233439340;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 84:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.RelayPatternBCOListListInnerRecset relayPatternBCOListListInnerRecset;
						if (relayPatternBCOListListInnerRecset.Count >= 3)
						{
							num = (short)2055995477;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						relayPatternBCOListListInnerRecset.AddRecord(relayPatternBCOListListInnerRecset.CreateDefaultRecord());
						bool flag = true;
						num = (short)136118283;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 85:
						num = (short)458883099;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 86:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RelockTimerInnerRecset relockTimerInnerRecset;
						if (relockTimerInnerRecset != null)
						{
							num = (short)1063321670;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1005;
					}
					case 87:
					{
						global::AcpCommonLib.IAcpRecordset feature;
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RelockTimerInnerRecset relockTimerInnerRecset = feature[0][10606].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RelockTimerInnerRecset;
						num = (short)553123926;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 88:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.RelayPatternBCOListListInnerRecset relayPatternBCOListListInnerRecset;
						if (relayPatternBCOListListInnerRecset != null)
						{
							num = (short)2067726348;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_145C;
					}
					case 89:
					{
						bool flag5;
						if (flag5)
						{
							num = (short)238223481;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8C3;
					}
					case 90:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButtonInnerRecset bottomFunctionProgrammableButtonInnerRecset = controlHeadO9Recset2[0][10618].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButtonInnerRecset;
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionButtonBCOListInnerRecset bottomFunctionButtonBCOListInnerRecset = controlHeadO9Recset2[0][10628].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionButtonBCOListInnerRecset;
						num = (short)1648558184;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 91:
						num = (short)2069430329;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 92:
						num = (short)1561460855;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 93:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.DirectionalButtonsListInnerRecset directionalButtonsListInnerRecset;
						if (directionalButtonsListInnerRecset.Count >= 3)
						{
							num = (short)2136866907;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						directionalButtonsListInnerRecset.AddRecord(directionalButtonsListInnerRecset.CreateDefaultRecord());
						bool flag4 = true;
						num = (short)1701445639;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 94:
						num = (short)404291604;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 95:
						goto IL_12E7;
					case 96:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionButtonBCOListInnerRecset bottomFunctionButtonBCOListInnerRecset;
						if (bottomFunctionButtonBCOListInnerRecset.Count >= 6)
						{
							num = (short)905248890;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						bottomFunctionButtonBCOListInnerRecset.AddRecord(bottomFunctionButtonBCOListInnerRecset.CreateDefaultRecord());
						bool flag5 = true;
						num = (short)708575254;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 97:
						num = (short)830930950;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 98:
						num = (short)1876164714;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 99:
						goto IL_183B;
					case 100:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButtonInnerRecset bottomFunctionProgrammableButtonInnerRecset;
						if (bottomFunctionProgrammableButtonInnerRecset.Count >= 5)
						{
							num = (short)1668087906;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						bottomFunctionProgrammableButtonInnerRecset.AddRecord(bottomFunctionProgrammableButtonInnerRecset.CreateDefaultRecord());
						bool flag7 = true;
						num = (short)1908408427;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 101:
						goto IL_16C4;
					case 102:
						goto IL_157F;
					case 103:
						if (trunkingShepherdListInnerRecset.Count >= 4)
						{
							num = (short)1177485414;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						trunkingShepherdListInnerRecset.AddRecord(trunkingShepherdListInnerRecset.CreateDefaultRecord());
						num = (short)1182007339;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 104:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionButtonBCOListInnerRecset bottomFunctionButtonBCOListInnerRecset;
						if (bottomFunctionButtonBCOListInnerRecset != null)
						{
							num = (short)2145714256;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8C3;
					}
					case 105:
						goto IL_1B56;
					case 106:
					{
						bool flag7;
						if (flag7)
						{
							num = (short)2091450381;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AEB;
					}
					case 107:
						goto IL_880;
					case 108:
						goto IL_295;
					case 109:
					{
						bool flag6 = false;
						num = (short)54132863;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 110:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.PASirenButtonsListInnerRecset pasirenButtonsListInnerRecset;
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.PASirenButtonsListInnerSection pasirenButtonsListInnerSection = (pasirenButtonsListInnerRecset[0] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.PASirenButtonsListInner).PASirenButtonsListInnerSection;
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.PASirenButtonsListInnerSection pasirenButtonsListInnerSection2 = (pasirenButtonsListInnerRecset[1] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.PASirenButtonsListInner).PASirenButtonsListInnerSection;
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.PASirenButtonsListInnerSection pasirenButtonsListInnerSection3 = (pasirenButtonsListInnerRecset[2] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.PASirenButtonsListInner).PASirenButtonsListInnerSection;
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.PASirenButtonsListInnerSection pasirenButtonsListInnerSection4 = (pasirenButtonsListInnerRecset[3] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.PASirenButtonsListInner).PASirenButtonsListInnerSection;
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.PASirenButtonsListInnerSection pasirenButtonsListInnerSection5 = (pasirenButtonsListInnerRecset[4] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.PASirenButtonsListInner).PASirenButtonsListInnerSection;
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.PASirenButtonsListInnerSection pasirenButtonsListInnerSection6 = (pasirenButtonsListInnerRecset[5] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.PASirenButtonsListInner).PASirenButtonsListInnerSection;
						num = (short)1461321852;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 111:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerRecset topFunctionProgrammableButtonListInnerRecset;
						if (topFunctionProgrammableButtonListInnerRecset.Count < 5)
						{
							num = (short)1626472512;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B56;
					}
					case 112:
					{
						bool flag2 = false;
						num = (short)301727789;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 113:
					{
						global::AcpCommonLib.IAcpRecordset feature;
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerRecset generalLightbarPatternInnerRecset = feature[0][10604].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerRecset;
						num = (short)230359105;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 114:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerRecset generalLightbarPatternInnerRecset2;
						if (generalLightbarPatternInnerRecset2 != null)
						{
							num = (short)970522716;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					case 115:
						goto IL_1800;
					case 116:
						num = (short)692846663;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 117:
					{
						bool flag4 = false;
						num = (short)1869545476;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 118:
					{
						global::AcpCommonLib.IAcpRecordset feature;
						if (feature != null)
						{
							num = (short)435093591;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1005;
					}
					case 119:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerRecset generalLightbarPatternInnerRecset2;
						if (generalLightbarPatternInnerRecset2.Count < 3)
						{
							num = (short)989986897;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					case 120:
					{
						global::AcpCommonLib.IAcpRecordset feature;
						if (feature != null)
						{
							num = (short)583860337;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1800;
					}
					case 121:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionButtonBCOListInnerRecset bottomFunctionButtonBCOListInnerRecset;
						(bottomFunctionButtonBCOListInnerRecset[0] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionButtonBCOListInner).BottomFunctionButtonBCOListInnerSection.CHO9BottomFunctionButtonBCO_A36827.Value = 165;
						(bottomFunctionButtonBCOListInnerRecset[1] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionButtonBCOListInner).BottomFunctionButtonBCOListInnerSection.CHO9BottomFunctionButtonBCO_A36827.Value = 166;
						(bottomFunctionButtonBCOListInnerRecset[2] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionButtonBCOListInner).BottomFunctionButtonBCOListInnerSection.CHO9BottomFunctionButtonBCO_A36827.Value = 167;
						(bottomFunctionButtonBCOListInnerRecset[3] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionButtonBCOListInner).BottomFunctionButtonBCOListInnerSection.CHO9BottomFunctionButtonBCO_A36827.Value = 168;
						(bottomFunctionButtonBCOListInnerRecset[4] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionButtonBCOListInner).BottomFunctionButtonBCOListInnerSection.CHO9BottomFunctionButtonBCO_A36827.Value = 169;
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionButtonBCOListInnerSection bottomFunctionButtonBCOListInnerSection6 = (bottomFunctionButtonBCOListInnerRecset[5] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionButtonBCOListInner).BottomFunctionButtonBCOListInnerSection;
						bottomFunctionButtonBCOListInnerSection6.CHO9BottomFunctionButtonBCO_A36827.Value = 10;
						bottomFunctionButtonBCOListInnerSection6.CHO9BottomFunctionButtonFeature_A36826.Value = 205;
						num = (short)1648558212;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 122:
						num = (short)262668377;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 123:
						goto IL_AEB;
					case 124:
					{
						bool flag6;
						if (flag6)
						{
							num = (short)1577779224;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_111A;
					}
					case 125:
						if (signalIndependentProductIndependentNonProgrammableButtonListInnerRecset != null)
						{
							num = (short)94044183;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1687;
					case 126:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.RelayPatternBCOListListInnerRecset relayPatternBCOListListInnerRecset = controlHeadO9Recset2[0][10620].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.RelayPatternBCOListListInnerRecset;
						num = (short)473038936;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 127:
						goto IL_295;
					case 128:
						goto IL_102E;
					case 129:
					{
						global::AcpCommonLib.IAcpRecordset feature;
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerRecset generalLightbarPatternInnerRecset2 = feature[0][10604].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerRecset;
						num = (short)114261402;
						short num4 = num;
						num = (short)41123226;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_102E;
						default:
							num = (short)1055981568;
							if (num != 0)
							{
							}
							num = (short)1945698418;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 130:
						goto IL_1005;
					case 131:
						goto IL_1754;
					case 132:
						goto IL_8C3;
					case 133:
					{
						global::Motorola.MackinawCPS.CoreFeatures.Shepherds.GlobalShepherdListInnerRecset globalShepherdListInnerRecset;
						if (globalShepherdListInnerRecset.Count >= 10)
						{
							num = (short)1962344482;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						globalShepherdListInnerRecset.AddRecord(globalShepherdListInnerRecset.CreateDefaultRecord());
						num = (short)131399779;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 134:
					{
						bool flag7 = false;
						num = (short)1070530586;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 135:
						num = (short)1073020960;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 136:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.PASirenButtonsListInnerRecset pasirenButtonsListInnerRecset;
						if (pasirenButtonsListInnerRecset != null)
						{
							num = (short)79495277;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_111A;
					}
					}
					goto IL_253;
					IL_295:
					num = (short)1701576787;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2D7:
					trunkingShepherdListInnerRecset = (shepherdsRecset[0][10037].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.Shepherds.TrunkingShepherdListInnerRecset);
					num = (short)76087356;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_83B:
					num = (short)95617108;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_880:
					num = (short)187957348;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_8C3:
					num = (short)1482686467;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_95C:
					num = (short)2000748595;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A28:
					num = (short)823722060;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_AEB:
					num = (short)119144568;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_102E:
					if (controlHeadO9Recset2 != null)
					{
						num = (short)1804206170;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_AEB;
					IL_BB3:
					num = (short)318308354;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_BF2:
					conventionalShepherdListInnerRecset = (shepherdsRecset[0][10035].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.Shepherds.ConventionalShepherdListInnerRecset);
					num = (short)1032060978;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_CC4:
					num = (short)1646067805;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_E35:
					num = (short)551944288;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_E96:
					num = (short)1010761795;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1005:
					controlHeadO9Recset2 = (global::AcpCommonLib.FeatureManager.GetFeature(4003) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset);
					num = (short)1807941760;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_111A:
					controlHeadO9Recset = (global::AcpCommonLib.FeatureManager.GetFeature(4003) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset);
					num = (short)231538742;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1276:
					num = (short)1485897831;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_12E7:
					num = (short)1009975357;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_145C:
					shepherdsRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2013) as global::Motorola.MackinawCPS.CoreFeatures.Shepherds.ShepherdsRecset);
					num = (short)1195573283;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_157F:
					signalIndependentProductIndependentNonProgrammableButtonListInnerRecset = (shepherdsRecset[0][10031].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInnerRecset);
					num = (short)490078333;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1687:
					num = (short)449314893;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_16C4:
					num = (short)1203699765;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1754:
					num = (short)203096092;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1800:
					num = (short)1866268690;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_183B:
					num = (short)1157103749;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_19CC:
					num = (short)1986003012;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1B56:
					num = (short)1515651105;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1CB0:
					num = (short)5308498;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_253:
				result = false;
				num = (short)1309540360;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00033800 File Offset: 0x00031A00
		private void expandFlashcode()
		{
			int a_ = 6;
			short num = (short)1826328078;
			short num2 = num;
			num = (short)374377998;
			global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
			string radInfoFLASHportFLASHcode_A8132Value;
			string str;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_154:
				radInfoFLASHportFLASHcode_A8132Value = radioInformation.FLASHport.RadInfoFLASHportFLASHcode_A8132Value;
				str = global::PreEmptive.SoS.Runtime.FixedLengthStream.b("쯥\ud8e7\udae9\udceb\udeed샯싱\ud9f3웵죷쫹쳻컽ヿ", a_);
				num = (short)947519495;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)1115095040;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_87;
				}
				break;
			}
			for (;;)
			{
				IL_5D:
				switch (num3)
				{
				case 0:
					goto IL_1DB;
				case 1:
					if (radInfoFLASHportFLASHcode_A8132Value.Length <= 15)
					{
						num = (short)930086918;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 2:
				{
					num = (short)832110592;
					short num4 = num;
					num = (short)1572798465;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
					goto IL_20A;
				case 4:
					radioInformation = (global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation);
					num = (short)1533280256;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_23B;
				case 6:
					num = (short)748617729;
					if (num != 0)
					{
					}
					radioInformation.FLASHport.RadInfoFLASHportFLASHcode_A8132Value = radInfoFLASHportFLASHcode_A8132Value + str;
					num = (short)1517420547;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					if (radInfoFLASHportFLASHcode_A8132Value != null)
					{
						num = (short)1187905538;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 8:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num = (short)422969348;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					radioInformation = (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation);
					num = (short)267714565;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_87;
			}
			IL_1DB:
			goto IL_154;
			IL_20A:
			return;
			IL_23B:
			goto IL_154;
			IL_87:
			radioInformation = null;
			num = (short)2127888392;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_5D;
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00033A50 File Offset: 0x00031C50
		private void PropertiesChanged()
		{
			int a_ = 6;
			short num = (short)1517748225;
			if (num != 0)
			{
			}
			num = (short)2063859712;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_5F;
					}
					continue;
				case 1:
					goto IL_F6;
				case 2:
					return;
				}
				IL_5F:
				if (this.PropertyChanged == null)
				{
					break;
				}
				num = (short)569430268;
				short num3 = num;
				num = (short)255381756;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)528941056;
					if (num != 0)
					{
					}
					num = (short)1706164224;
					short num4 = num;
					num = (short)298319873;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_F6:
				this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("ꗥ飧跩ꏫ黭闯鳱닳髵駷鷹", a_)));
				this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("ꗥ觧蓩ꏫ黭闯鳱럳蛵鿷볹郻鿽柿", a_)));
				this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("ꓥ蓧藩迫藭ꋯ鏱郳鿵韷돹돻", a_)));
				this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("ꋥ跧鳩藫跭闯등蛳駵闷꧹駻賽盿朁瘃", a_)));
				this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("닥跧蟩鳫苭釯蛱釳냵諷闹釻귽旿瀁爃挅稇", a_)));
				this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("ꓥ蓧藩迫藭뛯黱闳藵郷돹돻", a_)));
				this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("ꧥ鳧诩鳫꯭黯鏱雳髵鷷黹뿻釽擿朁球樅紇洉", a_)));
				this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("꿥鯧볩귫뻭鿯臱蟳鿵髷雹駻럽滿䄁欃戅洇稉怋笍眏", a_)));
				num = (short)2123038722;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00033C68 File Offset: 0x00031E68
		private void O2MFKTableInit()
		{
			short num = (short)1360003073;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_6A;
			}
			int num2;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.ControlHeadO2Recset controlHeadO2Recset;
			for (;;)
			{
				IL_30:
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2MFKAssignmentControlInnerSection o2MFKAssignmentControlInnerSection;
				switch (num2)
				{
				case 0:
					num = (short)1545732099;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					return;
				case 2:
				{
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2MFKAssignmentControlInnerRecset o2MFKAssignmentControlInnerRecset;
					if (o2MFKAssignmentControlInnerRecset != null)
					{
						num = (short)1822425088;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				case 3:
				{
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2MFKAssignmentControlInnerRecset o2MFKAssignmentControlInnerRecset;
					if (o2MFKAssignmentControlInnerRecset.Count < 2)
					{
						num = (short)198705158;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				case 4:
					goto IL_27E;
				case 5:
					goto IL_AE;
				case 6:
				{
					num = (short)780468224;
					short num3 = num;
					num = (short)1345978379;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 7:
				{
					num = (short)2032054704;
					short num4 = num;
					num = (short)2142876080;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_27E;
					default:
					{
						num = (short)319160320;
						if (num != 0)
						{
						}
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2MFKAssignmentControlInnerRecset o2MFKAssignmentControlInnerRecset;
						o2MFKAssignmentControlInnerSection = (o2MFKAssignmentControlInnerRecset[1] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2MFKAssignmentControlInner).O2MFKAssignmentControlInnerSection;
						num = (short)1309802500;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 8:
				{
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2MFKAssignmentControlInnerRecset o2MFKAssignmentControlInnerRecset = controlHeadO2Recset[0][10721].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2MFKAssignmentControlInnerRecset;
					num = (short)1776091138;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 9:
				{
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2MFKAssignmentControlInnerRecset o2MFKAssignmentControlInnerRecset;
					if (o2MFKAssignmentControlInnerRecset.Count >= 2)
					{
						num = (short)915931143;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					o2MFKAssignmentControlInnerRecset.AddRecord(o2MFKAssignmentControlInnerRecset.CreateDefaultRecord());
					num = (short)1018298373;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 10:
					if (controlHeadO2Recset != null)
					{
						num = (short)126222344;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 11:
					goto IL_AE;
				case 12:
					o2MFKAssignmentControlInnerSection.RadErgoControlO2MFKFeatureAssignment_A41275.SetValue(29);
					o2MFKAssignmentControlInnerSection.O2MFKAssignmentControlName_A41274.SetValue(global::CommonResources.AppResources.Secondary_Function);
					num = (short)1613299713;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_6A;
				IL_AE:
				num = (short)906231817;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_27E:
				if (o2MFKAssignmentControlInnerSection == null)
				{
					break;
				}
				num = (short)1985937420;
				num2 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_6A:
			controlHeadO2Recset = (global::AcpCommonLib.FeatureManager.GetFeature(4115) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.ControlHeadO2Recset);
			num = (short)1513947146;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_30;
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00033F30 File Offset: 0x00032130
		private void O7MFKTableInit()
		{
			switch (0)
			{
			case 0:
				goto IL_44;
			}
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7Recset controlHeadO7Recset;
			for (;;)
			{
				IL_0A:
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7MFKAssignmentControlInnerSection o7MFKAssignmentControlInnerSection;
				switch (num)
				{
				case 0:
					num2 = (short)1934426115;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					return;
				case 2:
				{
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7MFKAssignmentControlInnerRecset o7MFKAssignmentControlInnerRecset;
					if (o7MFKAssignmentControlInnerRecset != null)
					{
						num2 = (short)881262592;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				case 3:
				{
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7MFKAssignmentControlInnerRecset o7MFKAssignmentControlInnerRecset;
					if (o7MFKAssignmentControlInnerRecset.Count < 2)
					{
						num2 = (short)142934022;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				case 4:
					goto IL_256;
				case 5:
					goto IL_89;
				case 6:
					num2 = (short)1523318795;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
				{
					num2 = (short)541280443;
					short num3 = num2;
					num2 = (short)1088768187;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_256;
					default:
					{
						num2 = (short)1414660096;
						if (num2 != 0)
						{
						}
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7MFKAssignmentControlInnerRecset o7MFKAssignmentControlInnerRecset;
						o7MFKAssignmentControlInnerSection = (o7MFKAssignmentControlInnerRecset[1] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7MFKAssignmentControlInner).O7MFKAssignmentControlInnerSection;
						num2 = (short)1314193412;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 8:
				{
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7MFKAssignmentControlInnerRecset o7MFKAssignmentControlInnerRecset = controlHeadO7Recset[0][10718].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7MFKAssignmentControlInnerRecset;
					num2 = (short)1963065346;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 9:
				{
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7MFKAssignmentControlInnerRecset o7MFKAssignmentControlInnerRecset;
					if (o7MFKAssignmentControlInnerRecset.Count >= 2)
					{
						num2 = (short)827785223;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					o7MFKAssignmentControlInnerRecset.AddRecord(o7MFKAssignmentControlInnerRecset.CreateDefaultRecord());
					num2 = (short)1622278149;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 10:
					if (controlHeadO7Recset != null)
					{
						num2 = (short)413990920;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 11:
					goto IL_89;
				case 12:
				{
					num2 = (short)1394016256;
					short num4 = num2;
					o7MFKAssignmentControlInnerSection.RadErgoControlO7MFKFeatureAssignment_A41295.SetValue(29);
					o7MFKAssignmentControlInnerSection.O7MFKAssignmentControlName_A41294.SetValue(global::CommonResources.AppResources.Secondary_Function);
					num2 = (short)186843137;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_44;
				IL_89:
				num2 = (short)551026697;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_256:
				if (o7MFKAssignmentControlInnerSection == null)
				{
					break;
				}
				num2 = (short)2032271361;
				if (num2 != 0)
				{
				}
				num2 = (short)374013964;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_44:
			controlHeadO7Recset = (global::AcpCommonLib.FeatureManager.GetFeature(4114) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7Recset);
			num2 = (short)950272010;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000117 RID: 279 RVA: 0x000341F8 File Offset: 0x000323F8
		private void O2NavigationControlsTableInit()
		{
			short num = (short)1060503553;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_6C;
			}
			int num2;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.ControlHeadO2Recset controlHeadO2Recset;
			for (;;)
			{
				IL_32:
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2NavigationControlsTableInner o2NavigationControlsTableInner;
				switch (num2)
				{
				case 0:
					num = (short)1498480643;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					return;
				case 2:
				{
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2NavigationControlsTableInnerRecset o2NavigationControlsTableInnerRecset;
					if (o2NavigationControlsTableInnerRecset != null)
					{
						num = (short)1693253632;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				case 3:
				{
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2NavigationControlsTableInnerRecset o2NavigationControlsTableInnerRecset;
					if (o2NavigationControlsTableInnerRecset.Count < 2)
					{
						num = (short)1948319750;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				case 4:
					goto IL_280;
				case 5:
					goto IL_AF;
				case 6:
				{
					num = (short)801046528;
					short num3 = num;
					num = (short)1085603851;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 7:
				{
					num = (short)105607551;
					short num4 = num;
					num = (short)530870655;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_280;
					default:
					{
						num = (short)1117061120;
						if (num != 0)
						{
						}
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2NavigationControlsTableInnerRecset o2NavigationControlsTableInnerRecset;
						o2NavigationControlsTableInner = (o2NavigationControlsTableInnerRecset[1] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2NavigationControlsTableInner);
						num = (short)468910084;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 8:
				{
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2NavigationControlsTableInnerRecset o2NavigationControlsTableInnerRecset = controlHeadO2Recset[0][10722].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2NavigationControlsTableInnerRecset;
					num = (short)130809858;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 9:
				{
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2NavigationControlsTableInnerRecset o2NavigationControlsTableInnerRecset;
					if (o2NavigationControlsTableInnerRecset.Count >= 2)
					{
						num = (short)902430727;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					o2NavigationControlsTableInnerRecset.AddRecord(o2NavigationControlsTableInnerRecset.CreateDefaultRecord());
					num = (short)68288517;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 10:
					if (controlHeadO2Recset != null)
					{
						num = (short)2118975496;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 11:
					goto IL_AF;
				case 12:
				{
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2NavigationControlsTableInnerSection o2NavigationControlsTableInnerSection = o2NavigationControlsTableInner.O2NavigationControlsTableInnerSection;
					o2NavigationControlsTableInnerSection.RadErgoControlO2UpDownButton_A41278.SetValue(144);
					o2NavigationControlsTableInnerSection.O2UpDownButtonName_A41277.SetValue(global::CommonResources.AppResources.Down_Button);
					num = (short)535166977;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				goto IL_6C;
				IL_AF:
				num = (short)1145438217;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_280:
				if (o2NavigationControlsTableInner == null)
				{
					break;
				}
				num = (short)130809868;
				num2 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_6C:
			controlHeadO2Recset = (global::AcpCommonLib.FeatureManager.GetFeature(4115) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.ControlHeadO2Recset);
			num = (short)269615114;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_32;
		}

		// Token: 0x06000118 RID: 280 RVA: 0x000344C4 File Offset: 0x000326C4
		private void O7NavigationControlsTableInit()
		{
			switch (0)
			{
			case 0:
				goto IL_44;
			}
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7Recset controlHeadO7Recset;
			for (;;)
			{
				IL_0A:
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7NavigationControlsTableInner o7NavigationControlsTableInner;
				switch (num)
				{
				case 0:
					num2 = (short)160497667;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					return;
				case 2:
				{
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7NavigationControlsTableInnerRecset o7NavigationControlsTableInnerRecset;
					if (o7NavigationControlsTableInnerRecset != null)
					{
						num2 = (short)762904576;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				case 3:
				{
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7NavigationControlsTableInnerRecset o7NavigationControlsTableInnerRecset;
					if (o7NavigationControlsTableInnerRecset.Count < 2)
					{
						num2 = (short)1608974342;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				case 4:
					goto IL_289;
				case 5:
					goto IL_89;
				case 6:
				{
					num2 = (short)1827733504;
					short num3 = num2;
					num2 = (short)871628811;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 7:
				{
					num2 = (short)1222630996;
					short num4 = num2;
					num2 = (short)988864084;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_289;
					default:
					{
						num2 = (short)995622912;
						if (num2 != 0)
						{
						}
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7NavigationControlsTableInnerRecset o7NavigationControlsTableInnerRecset;
						o7NavigationControlsTableInner = (o7NavigationControlsTableInnerRecset[1] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7NavigationControlsTableInner);
						num2 = (short)104792068;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 8:
				{
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7NavigationControlsTableInnerRecset o7NavigationControlsTableInnerRecset = controlHeadO7Recset[0][10727].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7NavigationControlsTableInnerRecset;
					num2 = (short)66781186;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 9:
				{
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7NavigationControlsTableInnerRecset o7NavigationControlsTableInnerRecset;
					if (o7NavigationControlsTableInnerRecset.Count >= 2)
					{
						num2 = (short)1327235073;
						if (num2 != 0)
						{
						}
						num2 = (short)185335815;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					o7NavigationControlsTableInnerRecset.AddRecord(o7NavigationControlsTableInnerRecset.CreateDefaultRecord());
					num2 = (short)2024341509;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 10:
					if (controlHeadO7Recset != null)
					{
						num2 = (short)1618411528;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 11:
					goto IL_89;
				case 12:
				{
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7NavigationControlsTableInnerSection o7NavigationControlsTableInnerSection = o7NavigationControlsTableInner.O7NavigationControlsTableInnerSection;
					o7NavigationControlsTableInnerSection.RadErgoControlO7UpDownButton_A41293.SetValue(144);
					o7NavigationControlsTableInnerSection.O7UpDownButtonName_A41292.SetValue(global::CommonResources.AppResources.Down_Button);
					num2 = (short)261750785;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_44;
				IL_89:
				num2 = (short)971964425;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_289:
				if (o7NavigationControlsTableInner == null)
				{
					break;
				}
				num2 = (short)1652097036;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_44:
			controlHeadO7Recset = (global::AcpCommonLib.FeatureManager.GetFeature(4114) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7Recset);
			num2 = (short)585236490;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00034798 File Offset: 0x00032998
		private void E5NavigationControlsTableInit()
		{
			switch (0)
			{
			case 0:
				goto IL_44;
			}
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.ControlHeadE5Recset controlHeadE5Recset;
			for (;;)
			{
				IL_0A:
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5NavigationControlsTableInner e5NavigationControlsTableInner;
				switch (num)
				{
				case 0:
					num2 = (short)1024262147;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					return;
				case 2:
				{
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5NavigationControlsTableInnerRecset e5NavigationControlsTableInnerRecset;
					if (e5NavigationControlsTableInnerRecset != null)
					{
						num2 = (short)266600448;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				case 3:
				{
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5NavigationControlsTableInnerRecset e5NavigationControlsTableInnerRecset;
					if (e5NavigationControlsTableInnerRecset.Count < 2)
					{
						num2 = (short)110493702;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				case 4:
					goto IL_280;
				case 5:
					goto IL_88;
				case 6:
				{
					num2 = (short)615317504;
					short num3 = num2;
					num2 = (short)1355612171;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 7:
				{
					num2 = (short)748207174;
					short num4 = num2;
					num2 = (short)763411526;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_280;
					default:
					{
						num2 = (short)1158348800;
						if (num2 != 0)
						{
						}
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5NavigationControlsTableInnerRecset e5NavigationControlsTableInnerRecset;
						e5NavigationControlsTableInner = (e5NavigationControlsTableInnerRecset[1] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5NavigationControlsTableInner);
						num2 = (short)765657092;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 8:
				{
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5NavigationControlsTableInnerRecset e5NavigationControlsTableInnerRecset = controlHeadE5Recset[0][10896].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5NavigationControlsTableInnerRecset;
					num2 = (short)1406402562;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 9:
				{
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5NavigationControlsTableInnerRecset e5NavigationControlsTableInnerRecset;
					if (e5NavigationControlsTableInnerRecset.Count >= 2)
					{
						num2 = (short)1072103425;
						if (num2 != 0)
						{
						}
						num2 = (short)1391132679;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					e5NavigationControlsTableInnerRecset.AddRecord(e5NavigationControlsTableInnerRecset.CreateDefaultRecord());
					num2 = (short)667025413;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 10:
					if (controlHeadE5Recset != null)
					{
						num2 = (short)1230372872;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 11:
					goto IL_88;
				case 12:
				{
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5NavigationControlsTableInnerSection e5NavigationControlsTableInnerSection = e5NavigationControlsTableInner.E5NavigationControlsTableInnerSection;
					e5NavigationControlsTableInnerSection.RadErgoControlE5UpDownButton_43752.SetValue(144);
					e5NavigationControlsTableInnerSection.E5UpDownButtonName_43753.SetValue(global::CommonResources.AppResources.Down_Button);
					num2 = (short)1324351489;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_44;
				IL_88:
				num2 = (short)706150409;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_280:
				if (e5NavigationControlsTableInner == null)
				{
					break;
				}
				num2 = (short)191037452;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_44:
			controlHeadE5Recset = (global::AcpCommonLib.FeatureManager.GetFeature(4236) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.ControlHeadE5Recset);
			num2 = (short)676069386;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00034A64 File Offset: 0x00032C64
		private void O3NavigationControlsTableInit()
		{
			switch (0)
			{
			case 0:
				goto IL_44;
			}
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.ControlHeadO3Recset controlHeadO3Recset;
			for (;;)
			{
				IL_0A:
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3NavigationControlsTableInner o3NavigationControlsTableInner;
				switch (num)
				{
				case 0:
					num2 = (short)626655235;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					return;
				case 2:
				{
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3NavigationControlsTableInnerRecset o3NavigationControlsTableInnerRecset;
					if (o3NavigationControlsTableInnerRecset != null)
					{
						num2 = (short)88473600;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				case 3:
				{
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3NavigationControlsTableInnerRecset o3NavigationControlsTableInnerRecset;
					if (o3NavigationControlsTableInnerRecset.Count < 2)
					{
						num2 = (short)652279814;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				case 4:
					goto IL_259;
				case 5:
					goto IL_88;
				case 6:
					num2 = (short)902692875;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
				{
					num2 = (short)809589463;
					short num3 = num2;
					num2 = (short)27351767;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_259;
					default:
					{
						num2 = (short)1825112064;
						if (num2 != 0)
						{
						}
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3NavigationControlsTableInnerRecset o3NavigationControlsTableInnerRecset;
						o3NavigationControlsTableInner = (o3NavigationControlsTableInnerRecset[1] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3NavigationControlsTableInner);
						num2 = (short)1163657220;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 8:
				{
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3NavigationControlsTableInnerRecset o3NavigationControlsTableInnerRecset = controlHeadO3Recset[0][10732].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3NavigationControlsTableInnerRecset;
					num2 = (short)624230402;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 9:
				{
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3NavigationControlsTableInnerRecset o3NavigationControlsTableInnerRecset;
					if (o3NavigationControlsTableInnerRecset.Count >= 2)
					{
						num2 = (short)1068630023;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					o3NavigationControlsTableInnerRecset.AddRecord(o3NavigationControlsTableInnerRecset.CreateDefaultRecord());
					num2 = (short)118358021;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 10:
					if (controlHeadO3Recset != null)
					{
						num2 = (short)1661665288;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 11:
					num2 = (short)1166999553;
					if (num2 != 0)
					{
					}
					goto IL_88;
				case 12:
				{
					num2 = (short)883884032;
					short num4 = num2;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3NavigationControlsTableInnerSection o3NavigationControlsTableInnerSection = o3NavigationControlsTableInner.O3NavigationControlsTableInnerSection;
					o3NavigationControlsTableInnerSection.RadErgoControlO3NaviControlFeature_A41375.SetValue(144);
					o3NavigationControlsTableInnerSection.RadErgoControlO3NaviControlName_A41374.SetValue(global::CommonResources.AppResources.Down_Button);
					num2 = (short)1639120897;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_44;
				IL_88:
				num2 = (short)1468792841;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_259:
				if (o3NavigationControlsTableInner == null)
				{
					break;
				}
				num2 = (short)170197004;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_44:
			controlHeadO3Recset = (global::AcpCommonLib.FeatureManager.GetFeature(2127) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.ControlHeadO3Recset);
			num2 = (short)1625620490;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00034D2C File Offset: 0x00032F2C
		private void O5NavigationControlsTableInit()
		{
			switch (0)
			{
			case 0:
				goto IL_44;
			}
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.ControlHeadO5Recset controlHeadO5Recset;
			for (;;)
			{
				IL_0A:
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5NavigationControlsTableInner o5NavigationControlsTableInner;
				switch (num)
				{
				case 0:
					num2 = (short)947126275;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					return;
				case 2:
				{
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5NavigationControlsTableInnerRecset o5NavigationControlsTableInnerRecset;
					if (o5NavigationControlsTableInnerRecset != null)
					{
						num2 = (short)104333312;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				case 3:
				{
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5NavigationControlsTableInnerRecset o5NavigationControlsTableInnerRecset;
					if (o5NavigationControlsTableInnerRecset.Count < 2)
					{
						num2 = (short)913833990;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				case 4:
					goto IL_285;
				case 5:
					goto IL_B0;
				case 6:
				{
					num2 = (short)2082275328;
					short num3 = num2;
					num2 = (short)1586823179;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 7:
				{
					num2 = (short)1063424861;
					short num4 = num2;
					num2 = (short)251368285;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_285;
					default:
					{
						num2 = (short)997588992;
						if (num2 != 0)
						{
						}
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5NavigationControlsTableInnerRecset o5NavigationControlsTableInnerRecset;
						o5NavigationControlsTableInner = (o5NavigationControlsTableInnerRecset[1] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5NavigationControlsTableInner);
						num2 = (short)1806237700;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 8:
				{
					num2 = (short)2113994753;
					if (num2 != 0)
					{
					}
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5NavigationControlsTableInnerRecset o5NavigationControlsTableInnerRecset = controlHeadO5Recset[0][10735].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5NavigationControlsTableInnerRecset;
					num2 = (short)897122306;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 9:
				{
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5NavigationControlsTableInnerRecset o5NavigationControlsTableInnerRecset;
					if (o5NavigationControlsTableInnerRecset.Count >= 2)
					{
						num2 = (short)879886343;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					o5NavigationControlsTableInnerRecset.AddRecord(o5NavigationControlsTableInnerRecset.CreateDefaultRecord());
					num2 = (short)1875771397;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 10:
					if (controlHeadO5Recset != null)
					{
						num2 = (short)1500381192;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 11:
					goto IL_B0;
				case 12:
				{
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5NavigationControlsTableInnerSection o5NavigationControlsTableInnerSection = o5NavigationControlsTableInner.O5NavigationControlsTableInnerSection;
					o5NavigationControlsTableInnerSection.RadErgoControlO5NaviControlFeature_A41379.SetValue(144);
					o5NavigationControlsTableInnerSection.RadErgoControlO5NaviControlName_A41378.SetValue(global::CommonResources.AppResources.Down_Button);
					num2 = (short)2024341505;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_44;
				IL_B0:
				num2 = (short)1472790537;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_285:
				if (o5NavigationControlsTableInner == null)
				{
					break;
				}
				num2 = (short)1878392844;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_44:
			controlHeadO5Recset = (global::AcpCommonLib.FeatureManager.GetFeature(2130) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.ControlHeadO5Recset);
			num2 = (short)636223498;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00034FFC File Offset: 0x000331FC
		private void KMANavigationControlsTableInit()
		{
			switch (0)
			{
			case 0:
				goto IL_44;
			}
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesRecset keypadMicAndAccessoriesRecset;
			for (;;)
			{
				IL_0A:
				global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMANavigationControlsTableInner kmanavigationControlsTableInner;
				switch (num)
				{
				case 0:
					num2 = (short)1609433091;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					return;
				case 2:
				{
					global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMANavigationControlsTableInnerRecset kmanavigationControlsTableInnerRecset;
					if (kmanavigationControlsTableInnerRecset != null)
					{
						num2 = (short)1549139968;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				case 3:
				{
					global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMANavigationControlsTableInnerRecset kmanavigationControlsTableInnerRecset;
					if (kmanavigationControlsTableInnerRecset.Count < 2)
					{
						num2 = (short)1923350534;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				case 4:
					goto IL_286;
				case 5:
					goto IL_88;
				case 6:
				{
					num2 = (short)1537802240;
					short num3 = num2;
					num2 = (short)352583691;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 7:
				{
					num2 = (short)194379777;
					if (num2 != 0)
					{
					}
					num2 = (short)1367829401;
					short num4 = num2;
					num2 = (short)1185573785;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_286;
					default:
					{
						num2 = (short)1647640576;
						if (num2 != 0)
						{
						}
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMANavigationControlsTableInnerRecset kmanavigationControlsTableInnerRecset;
						kmanavigationControlsTableInner = (kmanavigationControlsTableInnerRecset[1] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMANavigationControlsTableInner);
						num2 = (short)635699204;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 8:
				{
					global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMANavigationControlsTableInnerRecset kmanavigationControlsTableInnerRecset = keypadMicAndAccessoriesRecset[0][10753].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMANavigationControlsTableInnerRecset;
					num2 = (short)871759874;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 9:
				{
					global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMANavigationControlsTableInnerRecset kmanavigationControlsTableInnerRecset;
					if (kmanavigationControlsTableInnerRecset.Count >= 2)
					{
						num2 = (short)1337917447;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					kmanavigationControlsTableInnerRecset.AddRecord(kmanavigationControlsTableInnerRecset.CreateDefaultRecord());
					num2 = (short)1193672709;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 10:
					if (keypadMicAndAccessoriesRecset != null)
					{
						num2 = (short)1066139656;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 11:
					goto IL_88;
				case 12:
				{
					global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMANavigationControlsTableInnerSection kmanavigationControlsTableInnerSection = kmanavigationControlsTableInner.KMANavigationControlsTableInnerSection;
					kmanavigationControlsTableInnerSection.RadErgoControlKMAUpDownButton_41760.SetValue(144);
					kmanavigationControlsTableInnerSection.RadErgoControlKMANaviControlName_41759.SetValue(global::CommonResources.AppResources.Down_Button);
					num2 = (short)33292289;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_44;
				IL_88:
				num2 = (short)1604059145;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_286:
				if (kmanavigationControlsTableInner == null)
				{
					break;
				}
				num2 = (short)1883766796;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_44:
			keypadMicAndAccessoriesRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2128) as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesRecset);
			num2 = (short)2008940554;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600011D RID: 285 RVA: 0x000352CC File Offset: 0x000334CC
		private void AlertListTableInit()
		{
			short num = (short)361496576;
			short num2 = num;
			num = (short)178913280;
			int num3 = (int)num;
			switch (num3)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_BF;
				}
				global::Motorola.MackinawCPS.CoreFeatures.VirtualPartnerAlert.VirtualPartnerAlertRecset virtualPartnerAlertRecset;
				global::Motorola.MackinawCPS.CoreFeatures.VirtualPartnerAlert.AlertListInnerRecset alertListInnerRecset;
				for (;;)
				{
					IL_50:
					num = (short)588906497;
					if (num != 0)
					{
					}
					global::AcpBusinessLayer.AcpField<string> virtualPartnerAlertAlias_A;
					int num4;
					switch (num3)
					{
					case 0:
					{
						string[] array;
						virtualPartnerAlertAlias_A.SetValue(array[num4]);
						num = (short)447152141;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						num = (short)1072103431;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						alertListInnerRecset = (virtualPartnerAlertRecset[0][10891].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.VirtualPartnerAlert.AlertListInnerRecset);
						num = (short)1665466383;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						string[] array = new string[]
						{
							global::CommonResources.AppResources.ID_Alert_0,
							global::CommonResources.AppResources.ID_Alert_1,
							global::CommonResources.AppResources.ID_Alert_2,
							global::CommonResources.AppResources.ID_Alert_3,
							global::CommonResources.AppResources.ID_Alert_4,
							global::CommonResources.AppResources.ID_Alert_5,
							global::CommonResources.AppResources.ID_Alert_6,
							global::CommonResources.AppResources.ID_Alert_7,
							global::CommonResources.AppResources.ID_Alert_8,
							global::CommonResources.AppResources.ID_Alert_9,
							global::CommonResources.AppResources.ID_Alert_10,
							global::CommonResources.AppResources.ID_Alert_11,
							global::CommonResources.AppResources.ID_Alert_12,
							global::CommonResources.AppResources.ID_Alert_13,
							global::CommonResources.AppResources.ID_Alert_14,
							global::CommonResources.AppResources.ID_Alert_15
						};
						num4 = 0;
						num = (short)820903947;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						goto IL_21B;
					case 5:
						if (num4 >= alertListInnerRecset.Count)
						{
							num = (short)233504780;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_21B;
					case 6:
						return;
					case 7:
						if (virtualPartnerAlertRecset.Count > 0)
						{
							num = (short)447610882;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 8:
						goto IL_295;
					case 9:
						if (virtualPartnerAlertRecset != null)
						{
							num = (short)2130313217;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 10:
						if (num4 >= 16)
						{
							num = (short)1834811398;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)574488581;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						goto IL_295;
					case 12:
						alertListInnerRecset.AddRecord(alertListInnerRecset.CreateDefaultRecord());
						num = (short)1801519108;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						goto IL_1B6;
					case 14:
						if (string.IsNullOrEmpty(virtualPartnerAlertAlias_A.Value))
						{
							num = (short)1640693760;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B6;
					case 15:
						if (alertListInnerRecset != null)
						{
							goto IL_199;
						}
						return;
					}
					goto IL_BF;
					IL_199:
					num = (short)516030467;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_295:
					num = (short)288535745;
					short num5 = num;
					num = (short)1084732609;
					switch ((num5 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_199;
					default:
						num = (short)1512112128;
						if (num != 0)
						{
						}
						num = (short)1440874506;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_1B6:
					num4++;
					num = (short)191889416;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_21B:
					(alertListInnerRecset[num4] as global::Motorola.MackinawCPS.CoreFeatures.VirtualPartnerAlert.AlertListInner).AlertListInnerSection.VirtualPartnerAlertListResultCode_43682.SetValue(num4);
					virtualPartnerAlertAlias_A = (alertListInnerRecset[num4] as global::Motorola.MackinawCPS.CoreFeatures.VirtualPartnerAlert.AlertListInner).AlertListInnerSection.VirtualPartnerAlertAlias_A43683;
					num = (short)221184014;
					num3 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_BF:
				virtualPartnerAlertRecset = (global::AcpCommonLib.FeatureManager.GetFeature(4231) as global::Motorola.MackinawCPS.CoreFeatures.VirtualPartnerAlert.VirtualPartnerAlertRecset);
				alertListInnerRecset = null;
				num = (short)690683913;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_50;
			}
			}
		}

		// Token: 0x0600011E RID: 286 RVA: 0x000356E8 File Offset: 0x000338E8
		private void O9NavigationControlsTableInit()
		{
			switch (0)
			{
			case 0:
				goto IL_44;
			}
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset controlHeadO9Recset;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)426901508;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
				{
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9NavigationControlsTableInner o9NavigationControlsTableInner;
					if (o9NavigationControlsTableInner != null)
					{
						num2 = (short)45940745;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				case 2:
				{
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9NavigationControlsTableInnerRecset o9NavigationControlsTableInnerRecset = controlHeadO9Recset[0][10731].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9NavigationControlsTableInnerRecset;
					num2 = (short)1287520263;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
					num2 = (short)1686634504;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
				{
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9NavigationControlsTableInnerRecset o9NavigationControlsTableInnerRecset;
					if (o9NavigationControlsTableInnerRecset.Count < 2)
					{
						goto IL_13B;
					}
					return;
				}
				case 5:
					goto IL_88;
				case 6:
					if (controlHeadO9Recset != null)
					{
						num2 = (short)1638268930;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 7:
				{
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9NavigationControlsTableInnerRecset o9NavigationControlsTableInnerRecset;
					if (o9NavigationControlsTableInnerRecset != null)
					{
						num2 = (short)1638268928;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				case 8:
					goto IL_88;
				case 9:
				{
					num2 = (short)1602049387;
					short num3 = num2;
					num2 = (short)1267815787;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_13B;
					default:
					{
						num2 = (short)1714814976;
						if (num2 != 0)
						{
						}
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9NavigationControlsTableInner o9NavigationControlsTableInner;
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9NavigationControlsTableInnerSection o9NavigationControlsTableInnerSection = o9NavigationControlsTableInner.O9NavigationControlsTableInnerSection;
						o9NavigationControlsTableInnerSection.RadErgoControlO9NaviControlFeature_A41371.SetValue(144);
						o9NavigationControlsTableInnerSection.RadErgoControlO9NaviControlName_A41370.SetValue(global::CommonResources.AppResources.Down_Button);
						num2 = (short)1879375883;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 10:
				{
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9NavigationControlsTableInnerRecset o9NavigationControlsTableInnerRecset;
					if (o9NavigationControlsTableInnerRecset.Count >= 2)
					{
						num2 = (short)1510932480;
						short num4 = num2;
						num2 = (short)341770252;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					o9NavigationControlsTableInnerRecset.AddRecord(o9NavigationControlsTableInnerRecset.CreateDefaultRecord());
					num2 = (short)41811973;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 11:
					return;
				case 12:
				{
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9NavigationControlsTableInnerRecset o9NavigationControlsTableInnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9NavigationControlsTableInner o9NavigationControlsTableInner = o9NavigationControlsTableInnerRecset[1] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9NavigationControlsTableInner;
					num2 = (short)1465319425;
					if (num2 != 0)
					{
					}
					num2 = (short)693174273;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_44;
				IL_88:
				num2 = (short)498008074;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_13B:
				num2 = (short)1982005251;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_44:
			controlHeadO9Recset = (global::AcpCommonLib.FeatureManager.GetFeature(4003) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset);
			num2 = (short)1250099206;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600011F RID: 287 RVA: 0x000359B8 File Offset: 0x00033BB8
		private void SyncAllControlHeadsNavigationControls()
		{
			short num = (short)725483520;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_63;
				}
				int num4;
				int num6;
				global::Motorola.MackinawCPS.CoreFeatures.Shepherds.ShepherdsRecset shepherdsRecset;
				for (;;)
				{
					IL_28:
					num = (short)1451753472;
					short num3 = num;
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)1870921736;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								int value;
								int num5;
								int value2;
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									try
									{
										num = (short)994639880;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												num = (short)1395392522;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 1:
												if (value == num4)
												{
													num = (short)2094268427;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											case 3:
												goto IL_258;
											case 4:
												if (num5 == 2)
												{
													num = (short)891289612;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											case 5:
												if (num5 != 1)
												{
													num = (short)1266614275;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_204;
											case 6:
											{
												global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
												(acpFeatureNode[10725] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2NavigationControlsTableInnerSection).RadErgoControlO2UpDownButton_A41278.SetValue(value2);
												num = (short)1186529282;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 7:
											{
												global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
												if ((acpFeatureNode[10725] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2NavigationControlsTableInnerSection).RadErgoControlO2UpDownButton_A41278.Value != value2)
												{
													num = (short)1009254406;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 8:
												switch (0)
												{
												case 0:
													goto IL_180;
												}
												continue;
											case 9:
												if (value == num6)
												{
													num = (short)1068433422;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_258;
											case 10:
												goto IL_360;
											case 11:
												num = (short)638058500;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 12:
												goto IL_204;
											case 13:
											{
												if (!enumerator.MoveNext())
												{
													num = (short)1239810048;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
												num5++;
												num = (short)1423966217;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 14:
												num = (short)683868165;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_180;
											IL_204:
											num = (short)20381703;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_258:
											num = (short)426639361;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_292:
											num = (short)1429733389;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_180:
											goto IL_292;
										}
										IL_360:
										goto IL_940;
									}
									finally
									{
										num = (short)206176257;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												goto IL_3CE;
											case 1:
												switch (0)
												{
												case 0:
													goto IL_397;
												}
												continue;
											case 2:
												enumerator.Dispose();
												num = (short)1018167296;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											IL_397:
											if (enumerator == null)
											{
												break;
											}
											num = (short)942538754;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_3CE:;
									}
									goto Block_4;
								case 1:
									goto IL_1075;
								case 2:
									goto IL_141E;
								case 3:
									if (value == num4)
									{
										num = (short)1104674818;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 4:
								{
									num = (short)1199636481;
									if (num != 0)
									{
									}
									try
									{
										num = (short)1963786241;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												num = (short)1185218565;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 1:
												switch (0)
												{
												case 0:
													goto IL_E16;
												}
												continue;
											case 2:
												goto IL_E1B;
											case 3:
											{
												global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
												if ((acpFeatureNode2[10733] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3NavigationControlsTableInnerSection).RadErgoControlO3NaviControlFeature_A41375.Value != value2)
												{
													num = (short)1111162889;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 4:
												if (value == num4)
												{
													num = (short)1925120007;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											case 5:
												goto IL_1003;
											case 6:
												if (num5 != 1)
												{
													num = (short)1961623554;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_F92;
											case 7:
												num = (short)2092433419;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 8:
											{
												if (!enumerator.MoveNext())
												{
													num = (short)942735360;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2 = enumerator.Current;
												num5++;
												num = (short)104857613;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 9:
											{
												global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
												(acpFeatureNode2[10733] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3NavigationControlsTableInnerSection).RadErgoControlO3NaviControlFeature_A41375.SetValue(value2);
												num = (short)908787726;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 10:
												goto IL_F92;
											case 11:
												if (num5 == 2)
												{
													num = (short)1867579402;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											case 12:
												num = (short)930545670;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 13:
												if (value == num6)
												{
													num = (short)394723340;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_E1B;
											}
											goto IL_E16;
											IL_E1B:
											num = (short)975896580;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_F06:
											num = (short)1214119944;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_E16:
											goto IL_F06;
											IL_F92:
											num = (short)1665662979;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_1003:
										goto IL_148D;
									}
									finally
									{
										num = (short)537067520;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												switch (0)
												{
												case 0:
													goto IL_103A;
												}
												continue;
											case 1:
												goto IL_1072;
											case 2:
												enumerator.Dispose();
												num = (short)1940324353;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											IL_103A:
											if (enumerator == null)
											{
												break;
											}
											num = (short)231342082;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_1072:;
									}
									goto Block_10;
									IL_148D:
									global::System.Collections.ObjectModel.Collection<global::AcpBusinessLayer.FeatureNode> collection = (global::AcpCommonLib.FeatureManager.GetFeature(4114) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7Recset)[0][10727].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7NavigationControlsTableInnerRecset;
									num5 = 0;
									enumerator = collection.GetEnumerator();
									num = (short)931201029;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
								{
									try
									{
										num = (short)1719730180;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												num = (short)967966721;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 1:
												goto IL_CDD;
											case 2:
												if (value == num6)
												{
													num = (short)1124859918;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_B41;
											case 3:
												if (num5 == 2)
												{
													goto IL_CA8;
												}
												break;
											case 4:
												switch (0)
												{
												case 0:
													goto IL_AAF;
												}
												continue;
											case 5:
												if (value == num4)
												{
													num = (short)1569652746;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											case 7:
											{
												if (!enumerator.MoveNext())
												{
													num = (short)882638848;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3 = enumerator.Current;
												num5++;
												num = (short)984940546;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 8:
												goto IL_B41;
											case 9:
											{
												global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
												if ((acpFeatureNode3[10728] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7NavigationControlsTableInnerSection).RadErgoControlO7UpDownButton_A41293.Value != value2)
												{
													num = (short)176685069;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 10:
												num = (short)76021763;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 11:
												if (num5 != 1)
												{
													num = (short)988741640;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_AE7;
											case 12:
												goto IL_AE7;
											case 13:
											{
												global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
												(acpFeatureNode3[10728] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7NavigationControlsTableInnerSection).RadErgoControlO7UpDownButton_A41293.SetValue(value2);
												num = (short)2021130246;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 14:
												num = (short)1501298699;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_AAF;
											IL_AE7:
											num = (short)310378505;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_B41:
											num = (short)1100311908;
											short num7 = num;
											num = (short)1114729828;
											switch ((num7 == num) ? 1 : 0)
											{
											case 0:
											case 2:
												IL_CA8:
												num = (short)1234042892;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											default:
												num = (short)1966080000;
												if (num != 0)
												{
												}
												num = (short)1532428293;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											IL_C4F:
											num = (short)470941703;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_AAF:
											goto IL_C4F;
										}
										IL_CDD:
										goto IL_137D;
									}
									finally
									{
										num = (short)1201864704;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												switch (0)
												{
												case 0:
													goto IL_D14;
												}
												continue;
											case 1:
												goto IL_D4E;
											case 2:
												enumerator.Dispose();
												num = (short)2120548353;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											IL_D14:
											if (enumerator == null)
											{
												break;
											}
											num = (short)116719618;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_D4E:;
									}
									goto IL_D51;
									IL_137D:
									global::System.Collections.ObjectModel.Collection<global::AcpBusinessLayer.FeatureNode> collection2 = (global::AcpCommonLib.FeatureManager.GetFeature(2130) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.ControlHeadO5Recset)[0][10735].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5NavigationControlsTableInnerRecset;
									num5 = 0;
									enumerator = collection2.GetEnumerator();
									num = (short)1543766027;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									num = (short)675872771;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									if (value != num6)
									{
										num = (short)1905262598;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_141E;
								case 8:
									switch (0)
									{
									case 0:
										goto IL_119;
									}
									continue;
								case 9:
									if (!enumerator2.MoveNext())
									{
										num = (short)1651900430;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_D51;
								case 10:
									goto IL_17F4;
								case 11:
									goto IL_68A;
								case 12:
									goto IL_3D1;
								case 13:
									try
									{
										num = (short)1762918401;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												goto IL_1640;
											case 1:
												switch (0)
												{
												case 0:
													goto IL_157D;
												}
												continue;
											case 2:
											{
												global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4;
												if ((acpFeatureNode4[10754] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMANavigationControlsTableInnerSection).RadErgoControlKMAUpDownButton_41760.Value != value2)
												{
													num = (short)1422524430;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 3:
											{
												if (!enumerator.MoveNext())
												{
													num = (short)241893385;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4 = enumerator.Current;
												num5++;
												num = (short)532545540;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 4:
												if (value == num6)
												{
													num = (short)1692598279;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_15C8;
											case 5:
												goto IL_1769;
											case 7:
												num = (short)2117926925;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 8:
												if (num5 == 2)
												{
													num = (short)268894208;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											case 9:
												num = (short)1213988869;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 10:
												num = (short)188153864;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 11:
												if (value == num4)
												{
													num = (short)1530331146;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											case 12:
												goto IL_15C8;
											case 13:
												if (num5 != 1)
												{
													num = (short)1551302668;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_1640;
											case 14:
											{
												global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4;
												(acpFeatureNode4[10754] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMANavigationControlsTableInnerSection).RadErgoControlKMAUpDownButton_41760.SetValue(value2);
												num = (short)407764998;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											}
											goto IL_157D;
											IL_15C8:
											num = (short)943783947;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_1640:
											num = (short)26148866;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_1711:
											num = (short)1683030019;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_157D:
											goto IL_1711;
										}
										IL_1769:
										goto IL_132C;
									}
									finally
									{
										num = (short)1816723457;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												enumerator.Dispose();
												num = (short)351141890;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 1:
												switch (0)
												{
												case 0:
													goto IL_17A2;
												}
												continue;
											case 2:
												goto IL_17D9;
											}
											IL_17A2:
											if (enumerator == null)
											{
												break;
											}
											num = (short)1465843712;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_17D9:;
									}
									goto IL_17DC;
								case 14:
									goto IL_17DC;
								}
								goto IL_119;
								IL_940:
								global::System.Collections.ObjectModel.Collection<global::AcpBusinessLayer.FeatureNode> collection3 = (global::AcpCommonLib.FeatureManager.GetFeature(2127) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.ControlHeadO3Recset)[0][10732].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3NavigationControlsTableInnerRecset;
								num5 = 0;
								enumerator = collection3.GetEnumerator();
								num = (short)682229764;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								Block_5:
								try
								{
									IL_68A:
									num = (short)2016542724;
									num2 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num2)
										{
										case 0:
											goto IL_725;
										case 1:
											goto IL_8CD;
										case 2:
											num = (short)1086521345;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 3:
											if (value == num6)
											{
												num = (short)286261260;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_776;
										case 4:
											switch (0)
											{
											case 0:
												goto IL_6ED;
											}
											continue;
										case 5:
											if (value == num4)
											{
												num = (short)271908874;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											break;
										case 6:
										{
											if (!enumerator.MoveNext())
											{
												num = (short)603914242;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											global::AcpCommonLib.IAcpFeatureNode acpFeatureNode5 = enumerator.Current;
											num5++;
											num = (short)65732611;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 7:
											if (num5 == 2)
											{
												num = (short)1406664704;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											break;
										case 8:
											goto IL_776;
										case 9:
										{
											global::AcpCommonLib.IAcpFeatureNode acpFeatureNode5;
											if ((acpFeatureNode5[10736] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5NavigationControlsTableInnerSection).RadErgoControlO5NaviControlFeature_A41379.Value != value2)
											{
												num = (short)1097728013;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											break;
										}
										case 10:
											num = (short)28114951;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 11:
											if (num5 != 1)
											{
												num = (short)80871432;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_725;
										case 12:
											num = (short)112590859;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 13:
										{
											global::AcpCommonLib.IAcpFeatureNode acpFeatureNode5;
											(acpFeatureNode5[10736] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5NavigationControlsTableInnerSection).RadErgoControlO5NaviControlFeature_A41379.SetValue(value2);
											num = (short)1233190926;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										}
										goto IL_6ED;
										IL_725:
										num = (short)1928200201;
										num2 = (int)((global::System.IntPtr)num);
										continue;
										IL_776:
										num = (short)1860894725;
										num2 = (int)((global::System.IntPtr)num);
										continue;
										IL_7AD:
										num = (short)598212614;
										num2 = (int)((global::System.IntPtr)num);
										continue;
										IL_6ED:
										goto IL_7AD;
									}
									IL_8CD:
									goto IL_13CD;
								}
								finally
								{
									num = (short)233897985;
									num2 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num2)
										{
										case 0:
											goto IL_93D;
										case 1:
											switch (0)
											{
											case 0:
												goto IL_905;
											}
											continue;
										case 2:
											enumerator.Dispose();
											num = (short)1732968448;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										IL_905:
										if (enumerator == null)
										{
											break;
										}
										num = (short)1090519042;
										num2 = (int)((global::System.IntPtr)num);
									}
									IL_93D:;
								}
								goto IL_940;
								IL_13CD:
								global::System.Collections.ObjectModel.Collection<global::AcpBusinessLayer.FeatureNode> collection4 = (global::AcpCommonLib.FeatureManager.GetFeature(2128) as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesRecset)[0][10753].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMANavigationControlsTableInnerRecset;
								num5 = 0;
								enumerator = collection4.GetEnumerator();
								num = (short)1847132173;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								Block_4:
								try
								{
									IL_3D1:
									num = (short)320077828;
									num2 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num2)
										{
										case 1:
											goto IL_619;
										case 2:
											num = (short)23658510;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 3:
										{
											global::AcpCommonLib.IAcpFeatureNode acpFeatureNode6;
											if ((acpFeatureNode6[10897] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5NavigationControlsTableInnerSection).RadErgoControlE5UpDownButton_43752.Value != value2)
											{
												num = (short)1831665676;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											break;
										}
										case 4:
											switch (0)
											{
											case 0:
												goto IL_435;
											}
											continue;
										case 5:
										{
											if (!enumerator.MoveNext())
											{
												num = (short)1172504586;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											global::AcpCommonLib.IAcpFeatureNode acpFeatureNode6 = enumerator.Current;
											num5++;
											num = (short)238878729;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 6:
											if (value == num4)
											{
												num = (short)350093314;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											break;
										case 7:
											goto IL_5A9;
										case 8:
											goto IL_4FA;
										case 9:
											if (value == num6)
											{
												num = (short)1524498445;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_4FA;
										case 10:
											num = (short)1947140097;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 11:
											if (num5 != 1)
											{
												num = (short)1502609416;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_5A9;
										case 12:
										{
											global::AcpCommonLib.IAcpFeatureNode acpFeatureNode6;
											(acpFeatureNode6[10897] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5NavigationControlsTableInnerSection).RadErgoControlE5UpDownButton_43752.SetValue(value2);
											num = (short)111149056;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 13:
											num = (short)272367627;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 14:
											if (num5 == 2)
											{
												num = (short)1188954119;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											break;
										}
										IL_4BA:
										num = (short)315097093;
										num2 = (int)((global::System.IntPtr)num);
										continue;
										IL_435:
										goto IL_4BA;
										IL_4FA:
										num = (short)1988362246;
										num2 = (int)((global::System.IntPtr)num);
										continue;
										IL_5A9:
										num = (short)133365763;
										num2 = (int)((global::System.IntPtr)num);
									}
									IL_619:
									goto IL_A09;
								}
								finally
								{
									num = (short)1528561665;
									num2 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num2)
										{
										case 0:
											goto IL_687;
										case 1:
											switch (0)
											{
											case 0:
												goto IL_650;
											}
											continue;
										case 2:
											enumerator.Dispose();
											num = (short)1377697792;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										IL_650:
										if (enumerator == null)
										{
											break;
										}
										num = (short)1265696770;
										num2 = (int)((global::System.IntPtr)num);
									}
									IL_687:;
								}
								goto Block_5;
								Block_10:
								try
								{
									IL_1075:
									num = (short)1381826561;
									num2 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num2)
										{
										case 0:
											goto IL_114E;
										case 1:
											switch (0)
											{
											case 0:
												goto IL_10D7;
											}
											continue;
										case 2:
											if (value == num6)
											{
												num = (short)1993932814;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_114E;
										case 3:
										{
											if (!enumerator.MoveNext())
											{
												num = (short)1073283081;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											global::AcpCommonLib.IAcpFeatureNode acpFeatureNode7 = enumerator.Current;
											num5++;
											num = (short)905838594;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 4:
											if (num5 == 2)
											{
												num = (short)832176135;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											break;
										case 5:
											goto IL_12B9;
										case 6:
											num = (short)2125660164;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 7:
											goto IL_120D;
										case 8:
											if (num5 != 1)
											{
												num = (short)677707776;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_120D;
										case 9:
											num = (short)1571684357;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 10:
											if (value == num4)
											{
												num = (short)932773894;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											break;
										case 12:
										{
											global::AcpCommonLib.IAcpFeatureNode acpFeatureNode7;
											(acpFeatureNode7[10734] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9NavigationControlsTableInnerSection).RadErgoControlO9NaviControlFeature_A41371.SetValue(value2);
											num = (short)1321467915;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 13:
										{
											global::AcpCommonLib.IAcpFeatureNode acpFeatureNode7;
											if ((acpFeatureNode7[10734] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9NavigationControlsTableInnerSection).RadErgoControlO9NaviControlFeature_A41371.Value != value2)
											{
												num = (short)703266828;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											break;
										}
										case 14:
											num = (short)1020526600;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_10D7;
										IL_114E:
										num = (short)747765770;
										num2 = (int)((global::System.IntPtr)num);
										continue;
										IL_120D:
										num = (short)195100685;
										num2 = (int)((global::System.IntPtr)num);
										continue;
										IL_1262:
										num = (short)719192067;
										num2 = (int)((global::System.IntPtr)num);
										continue;
										IL_10D7:
										goto IL_1262;
									}
									IL_12B9:
									goto IL_9B8;
								}
								finally
								{
									num = (short)189595648;
									num2 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num2)
										{
										case 0:
											switch (0)
											{
											case 0:
												goto IL_12F0;
											}
											continue;
										case 1:
											goto IL_1329;
										case 2:
											enumerator.Dispose();
											num = (short)1360265217;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										IL_12F0:
										if (enumerator == null)
										{
											break;
										}
										num = (short)1305935874;
										num2 = (int)((global::System.IntPtr)num);
									}
									IL_1329:;
								}
								goto IL_132C;
								IL_9B8:
								global::System.Collections.ObjectModel.Collection<global::AcpBusinessLayer.FeatureNode> collection5 = (global::AcpCommonLib.FeatureManager.GetFeature(4236) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.ControlHeadE5Recset)[0][10896].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5NavigationControlsTableInnerRecset;
								num5 = 0;
								enumerator = collection5.GetEnumerator();
								num = (short)785711116;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_A09:
								num = (short)1345191945;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_119:
								goto IL_A09;
								IL_D51:
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode8 = enumerator2.Current;
								value = (acpFeatureNode8[10032] as global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInnerSection).RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonBCO_A19777.Value;
								num = (short)1961230343;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_132C:
								global::System.Collections.ObjectModel.Collection<global::AcpBusinessLayer.FeatureNode> collection6 = (global::AcpCommonLib.FeatureManager.GetFeature(4003) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset)[0][10731].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9NavigationControlsTableInnerRecset;
								num5 = 0;
								enumerator = collection6.GetEnumerator();
								num = (short)640221185;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_141E:
								value2 = (acpFeatureNode8[10032] as global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInnerSection).RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonFeature_A19778.Value;
								global::System.Collections.ObjectModel.Collection<global::AcpBusinessLayer.FeatureNode> collection7 = (global::AcpCommonLib.FeatureManager.GetFeature(4115) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.ControlHeadO2Recset)[0][10722].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2NavigationControlsTableInnerRecset;
								num5 = 0;
								enumerator = collection7.GetEnumerator();
								num = (short)653066240;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_17DC:
								num = (short)810418186;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_17F4:
							return;
						}
						finally
						{
							num = (short)1190723585;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator2.Dispose();
									num = (short)1728249858;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_182B;
									}
									continue;
								case 2:
									goto IL_1861;
								}
								IL_182B:
								if (enumerator2 == null)
								{
									break;
								}
								num = (short)25755648;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1861:;
						}
						goto IL_1864;
					case 1:
						goto IL_1864;
					case 2:
						if (shepherdsRecset != null)
						{
							num = (short)1426456577;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					goto IL_63;
					IL_1864:
					enumerator2 = (shepherdsRecset[0][10031].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInnerRecset).GetEnumerator();
					num = (short)1212219392;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_63:
				num6 = 135;
				num4 = 136;
				shepherdsRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2013) as global::Motorola.MackinawCPS.CoreFeatures.Shepherds.ShepherdsRecset);
				num = (short)881197058;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00037330 File Offset: 0x00035530
		private void AddO9PhephedRecord()
		{
			short num = (short)1447428096;
			short num2 = num;
			num = (short)1636629782;
			short num3 = num;
			num = (short)1521155350;
			switch (num3 == num)
			{
			}
			num = (short)142802945;
			if (num != 0)
			{
			}
			num = (short)122093568;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInnerRecset signalIndependentProductIndependentNonProgrammableButtonListInnerRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2013) as global::Motorola.MackinawCPS.CoreFeatures.Shepherds.ShepherdsRecset)[0][10031].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInnerRecset;
			global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInner signalIndependentProductIndependentNonProgrammableButtonListInner = signalIndependentProductIndependentNonProgrammableButtonListInnerRecset[24] as global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInner;
			signalIndependentProductIndependentNonProgrammableButtonListInner.SignalIndependentProductIndependentNonProgrammableButtonListInnerSection.RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonBCO_A19777.Value = 117;
			signalIndependentProductIndependentNonProgrammableButtonListInner.SignalIndependentProductIndependentNonProgrammableButtonListInnerSection.RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonFeature_A19778.Value = 38;
			global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInner signalIndependentProductIndependentNonProgrammableButtonListInner2 = signalIndependentProductIndependentNonProgrammableButtonListInnerRecset[25] as global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInner;
			signalIndependentProductIndependentNonProgrammableButtonListInner2.SignalIndependentProductIndependentNonProgrammableButtonListInnerSection.RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonBCO_A19777.Value = 112;
			signalIndependentProductIndependentNonProgrammableButtonListInner2.SignalIndependentProductIndependentNonProgrammableButtonListInnerSection.RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonFeature_A19778.Value = 38;
			global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInner signalIndependentProductIndependentNonProgrammableButtonListInner3 = signalIndependentProductIndependentNonProgrammableButtonListInnerRecset[26] as global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInner;
			signalIndependentProductIndependentNonProgrammableButtonListInner3.SignalIndependentProductIndependentNonProgrammableButtonListInnerSection.RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonBCO_A19777.Value = 114;
			signalIndependentProductIndependentNonProgrammableButtonListInner3.SignalIndependentProductIndependentNonProgrammableButtonListInnerSection.RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonFeature_A19778.Value = 38;
			global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInner signalIndependentProductIndependentNonProgrammableButtonListInner4 = signalIndependentProductIndependentNonProgrammableButtonListInnerRecset[27] as global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInner;
			signalIndependentProductIndependentNonProgrammableButtonListInner4.SignalIndependentProductIndependentNonProgrammableButtonListInnerSection.RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonBCO_A19777.Value = 115;
			signalIndependentProductIndependentNonProgrammableButtonListInner4.SignalIndependentProductIndependentNonProgrammableButtonListInnerSection.RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonFeature_A19778.Value = 38;
			global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInner signalIndependentProductIndependentNonProgrammableButtonListInner5 = signalIndependentProductIndependentNonProgrammableButtonListInnerRecset[28] as global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInner;
			signalIndependentProductIndependentNonProgrammableButtonListInner5.SignalIndependentProductIndependentNonProgrammableButtonListInnerSection.RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonBCO_A19777.Value = 113;
			signalIndependentProductIndependentNonProgrammableButtonListInner5.SignalIndependentProductIndependentNonProgrammableButtonListInnerSection.RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonFeature_A19778.Value = 38;
			global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInner signalIndependentProductIndependentNonProgrammableButtonListInner6 = signalIndependentProductIndependentNonProgrammableButtonListInnerRecset[29] as global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInner;
			signalIndependentProductIndependentNonProgrammableButtonListInner6.SignalIndependentProductIndependentNonProgrammableButtonListInnerSection.RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonBCO_A19777.Value = 116;
			signalIndependentProductIndependentNonProgrammableButtonListInner6.SignalIndependentProductIndependentNonProgrammableButtonListInnerSection.RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonFeature_A19778.Value = 204;
			global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInner signalIndependentProductIndependentNonProgrammableButtonListInner7 = signalIndependentProductIndependentNonProgrammableButtonListInnerRecset[30] as global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInner;
			signalIndependentProductIndependentNonProgrammableButtonListInner7.SignalIndependentProductIndependentNonProgrammableButtonListInnerSection.RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonBCO_A19777.Value = 87;
			signalIndependentProductIndependentNonProgrammableButtonListInner7.SignalIndependentProductIndependentNonProgrammableButtonListInnerSection.RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonFeature_A19778.Value = 196;
			global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInner signalIndependentProductIndependentNonProgrammableButtonListInner8 = signalIndependentProductIndependentNonProgrammableButtonListInnerRecset[31] as global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInner;
			signalIndependentProductIndependentNonProgrammableButtonListInner8.SignalIndependentProductIndependentNonProgrammableButtonListInnerSection.RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonBCO_A19777.Value = 88;
			signalIndependentProductIndependentNonProgrammableButtonListInner8.SignalIndependentProductIndependentNonProgrammableButtonListInnerSection.RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonFeature_A19778.Value = 197;
			global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInner signalIndependentProductIndependentNonProgrammableButtonListInner9 = signalIndependentProductIndependentNonProgrammableButtonListInnerRecset[32] as global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInner;
			signalIndependentProductIndependentNonProgrammableButtonListInner9.SignalIndependentProductIndependentNonProgrammableButtonListInnerSection.RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonBCO_A19777.Value = 89;
			signalIndependentProductIndependentNonProgrammableButtonListInner9.SignalIndependentProductIndependentNonProgrammableButtonListInnerSection.RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonFeature_A19778.Value = 208;
			global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInner signalIndependentProductIndependentNonProgrammableButtonListInner10 = signalIndependentProductIndependentNonProgrammableButtonListInnerRecset[33] as global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInner;
			signalIndependentProductIndependentNonProgrammableButtonListInner10.SignalIndependentProductIndependentNonProgrammableButtonListInnerSection.RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonBCO_A19777.Value = 90;
			signalIndependentProductIndependentNonProgrammableButtonListInner10.SignalIndependentProductIndependentNonProgrammableButtonListInnerSection.RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonFeature_A19778.Value = 198;
			((global::AcpCommonLib.FeatureManager.GetFeature(2033) as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWideRecset)[0][10225] as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.PASiren).RadErgoWidePASirenHiLoAirhornTones_A8200.Value = true;
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00037620 File Offset: 0x00035820
		private void O9DirectionalButtonsFixup()
		{
			short num = (short)1510932480;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_50;
					}
					continue;
				case 1:
				{
					num = (short)44292259;
					short num3 = num;
					num = (short)379967651;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
					{
						num = (short)1788280832;
						if (num != 0)
						{
						}
						num = (short)1786576896;
						short num4 = num;
						num = (short)48103426;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 2:
				{
					if (int.Parse((global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation).General.RadInfoGeneralCodeplugVersion_A7683.Substring(1, 2)) >= 9)
					{
						num = (short)968622090;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::AcpCommonLib.IAcpRecordset feature = global::AcpCommonLib.FeatureManager.GetFeature(2045);
					num = (short)164495368;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
				{
					global::AcpCommonLib.IAcpRecordset feature;
					global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LightbarPattern lightbarPattern = feature[0][10604] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LightbarPattern;
					num = (short)410583044;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
				{
					global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LightbarPattern lightbarPattern;
					if (lightbarPattern != null)
					{
						num = (short)1962803207;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				case 5:
				{
					num = (short)1938751489;
					if (num != 0)
					{
					}
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.DirectionalButtonsListInnerRecset directionalButtonsListInnerRecset = (global::AcpCommonLib.FeatureManager.GetFeature(4003) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset)[0][10609].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.DirectionalButtonsListInnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.DirectionalButtonsListInnerSection directionalButtonsListInnerSection = (directionalButtonsListInnerRecset[0] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.DirectionalButtonsListInner).DirectionalButtonsListInnerSection;
					directionalButtonsListInnerSection.RadErgCtrlHeadO9DirLightBarFeature_A36597.SetValue(38);
					directionalButtonsListInnerSection.RadErgCtrlHeadO9DirLightBarFeature_A36597.Valid = true;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.DirectionalButtonsListInnerSection directionalButtonsListInnerSection2 = (directionalButtonsListInnerRecset[1] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.DirectionalButtonsListInner).DirectionalButtonsListInnerSection;
					directionalButtonsListInnerSection2.RadErgCtrlHeadO9DirLightBarFeature_A36597.SetValue(38);
					directionalButtonsListInnerSection2.RadErgCtrlHeadO9DirLightBarFeature_A36597.Valid = true;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.DirectionalButtonsListInnerSection directionalButtonsListInnerSection3 = (directionalButtonsListInnerRecset[2] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.DirectionalButtonsListInner).DirectionalButtonsListInnerSection;
					directionalButtonsListInnerSection3.RadErgCtrlHeadO9DirLightBarFeature_A36597.SetValue(38);
					directionalButtonsListInnerSection3.RadErgCtrlHeadO9DirLightBarFeature_A36597.Valid = true;
					num = (short)2012413961;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 6:
				{
					global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LightbarPattern lightbarPattern;
					if (!lightbarPattern.RadWideUniversalRelayControllerEquipped_A37191.Value)
					{
						num = (short)1656619013;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				case 7:
					num = (short)4259846;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
				{
					global::AcpCommonLib.IAcpRecordset feature;
					if (feature != null)
					{
						num = (short)1602420739;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				case 9:
					goto IL_2B9;
				case 10:
					goto IL_1F9;
				}
				IL_50:
				if (!global::ConstraintHelper.UtilityMack.IsMobileOnly())
				{
					return;
				}
				num = (short)1841561601;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_1F9:
			return;
			IL_2B9:;
		}

		// Token: 0x06000122 RID: 290 RVA: 0x0003793C File Offset: 0x00035B3C
		private void SyncO9PASirenButtons(bool isCompareCpgPortable = true)
		{
			short num = (short)1191837696;
			short num2 = num;
			num = (short)440175660;
			short num3 = num;
			num = (short)315001900;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1166999552;
				if (num != 0)
				{
				}
				num = (short)2063794176;
				switch (num)
				{
				default:
				{
					global::Motorola.MackinawCPS.CoreFeatures.Shepherds.ShepherdsRecset shepherdsRecset = null;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset controlHeadO9Recset = null;
					try
					{
						num = (short)1010302976;
						int num4 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num4)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_EA;
								}
								continue;
							case 1:
								num = (short)1065222152;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_1BB;
							case 3:
								num = (short)1843593222;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
								goto IL_242;
							case 5:
								goto IL_242;
							case 6:
								goto IL_122;
							case 7:
								goto IL_3F0;
							case 8:
								if (isCompareCpgPortable)
								{
									num = (short)1125449731;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								shepherdsRecset = (global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(2013) as global::Motorola.MackinawCPS.CoreFeatures.Shepherds.ShepherdsRecset);
								controlHeadO9Recset = (global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(4003) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset);
								num = (short)776470532;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 9:
								num = (short)1249247234;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 10:
								if (!global::ConstraintHelper.UtilityMack.IsMobileOnly())
								{
									num = (short)1552744457;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								shepherdsRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2013) as global::Motorola.MackinawCPS.CoreFeatures.Shepherds.ShepherdsRecset);
								controlHeadO9Recset = (global::AcpCommonLib.FeatureManager.GetFeature(4003) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset);
								this.FixupSirenButtons();
								num = (short)1324744709;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_EA:
							if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
							{
								num = (short)1318846465;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1592066058;
							num4 = (int)((global::System.IntPtr)num);
							continue;
							IL_242:
							global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInnerRecset signalIndependentProductIndependentNonProgrammableButtonListInnerRecset = shepherdsRecset[0][10031].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInnerRecset;
							global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.PASirenButtonsListInnerRecset pasirenButtonsListInnerRecset = controlHeadO9Recset[0][10743].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.PASirenButtonsListInnerRecset;
							global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInner signalIndependentProductIndependentNonProgrammableButtonListInner = signalIndependentProductIndependentNonProgrammableButtonListInnerRecset[24] as global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInner;
							(pasirenButtonsListInnerRecset[0] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.PASirenButtonsListInner).PASirenButtonsListInnerSection.CHO9PASirenButtonsFeature_A41540.SetValue(signalIndependentProductIndependentNonProgrammableButtonListInner.SignalIndependentProductIndependentNonProgrammableButtonListInnerSection.RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonFeature_A19778.Value);
							global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInner signalIndependentProductIndependentNonProgrammableButtonListInner2 = signalIndependentProductIndependentNonProgrammableButtonListInnerRecset[25] as global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInner;
							(pasirenButtonsListInnerRecset[1] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.PASirenButtonsListInner).PASirenButtonsListInnerSection.CHO9PASirenButtonsFeature_A41540.SetValue(signalIndependentProductIndependentNonProgrammableButtonListInner2.SignalIndependentProductIndependentNonProgrammableButtonListInnerSection.RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonFeature_A19778.Value);
							global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInner signalIndependentProductIndependentNonProgrammableButtonListInner3 = signalIndependentProductIndependentNonProgrammableButtonListInnerRecset[28] as global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInner;
							(pasirenButtonsListInnerRecset[2] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.PASirenButtonsListInner).PASirenButtonsListInnerSection.CHO9PASirenButtonsFeature_A41540.SetValue(signalIndependentProductIndependentNonProgrammableButtonListInner3.SignalIndependentProductIndependentNonProgrammableButtonListInnerSection.RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonFeature_A19778.Value);
							global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInner signalIndependentProductIndependentNonProgrammableButtonListInner4 = signalIndependentProductIndependentNonProgrammableButtonListInnerRecset[26] as global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInner;
							(pasirenButtonsListInnerRecset[3] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.PASirenButtonsListInner).PASirenButtonsListInnerSection.CHO9PASirenButtonsFeature_A41540.SetValue(signalIndependentProductIndependentNonProgrammableButtonListInner4.SignalIndependentProductIndependentNonProgrammableButtonListInnerSection.RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonFeature_A19778.Value);
							global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInner signalIndependentProductIndependentNonProgrammableButtonListInner5 = signalIndependentProductIndependentNonProgrammableButtonListInnerRecset[27] as global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInner;
							(pasirenButtonsListInnerRecset[4] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.PASirenButtonsListInner).PASirenButtonsListInnerSection.CHO9PASirenButtonsFeature_A41540.SetValue(signalIndependentProductIndependentNonProgrammableButtonListInner5.SignalIndependentProductIndependentNonProgrammableButtonListInnerSection.RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonFeature_A19778.Value);
							global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInner signalIndependentProductIndependentNonProgrammableButtonListInner6 = signalIndependentProductIndependentNonProgrammableButtonListInnerRecset[29] as global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInner;
							(pasirenButtonsListInnerRecset[5] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.PASirenButtonsListInner).PASirenButtonsListInnerSection.CHO9PASirenButtonsFeature_A41540.SetValue(signalIndependentProductIndependentNonProgrammableButtonListInner6.SignalIndependentProductIndependentNonProgrammableButtonListInnerSection.RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonFeature_A19778.Value);
							num = (short)1572667399;
							num4 = (int)((global::System.IntPtr)num);
						}
						IL_122:
						IL_1BB:
						IL_3F0:;
					}
					catch (global::System.Exception)
					{
					}
					break;
				}
				}
				break;
			}
			num = (short)973471745;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00037D80 File Offset: 0x00035F80
		private void FixupSirenButtons()
		{
			short num = (short)2145058816;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInnerRecset signalIndependentProductIndependentNonProgrammableButtonListInnerRecset;
				global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.PASiren pasiren;
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_50;
					}
					continue;
				case 1:
					goto IL_141;
				case 2:
				{
					num = (short)955283065;
					short num3 = num;
					num = (short)1274574457;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_141;
					case 1:
						goto IL_23F;
					}
					goto Block_3;
				}
				case 3:
					signalIndependentProductIndependentNonProgrammableButtonListInnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(2013) as global::Motorola.MackinawCPS.CoreFeatures.Shepherds.ShepherdsRecset)[0][10031].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInnerRecset);
					num = (short)366411786;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (!pasiren.RadErgoWidePASirenHiLoAirhornTones_A8200.Value)
					{
						num = (short)531038215;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1AA;
				case 5:
					goto IL_2C5;
				case 6:
					goto IL_1AA;
				case 7:
					(signalIndependentProductIndependentNonProgrammableButtonListInnerRecset[27] as global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInner).SignalIndependentProductIndependentNonProgrammableButtonListInnerSection.RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonFeature_A19778.Value = 203;
					num = (short)675217414;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					if (pasiren.RadErgoWidePASirenSirenOperation_A9139.Value == 2)
					{
						num = (short)1728249859;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 9:
					(signalIndependentProductIndependentNonProgrammableButtonListInnerRecset[24] as global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInner).SignalIndependentProductIndependentNonProgrammableButtonListInnerSection.RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonFeature_A19778.Value = 199;
					num = (short)1488125953;
					if (num != 0)
					{
					}
					num = (short)1931018245;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					if (!pasiren.RadErgoWidePASirenHiLoAirhornTones_A8200.Value)
					{
						num = (short)680787977;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2C5;
				}
				IL_50:
				if (int.Parse((global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation).General.RadInfoGeneralCodeplugVersion_A7683.Substring(1, 2)) < 9)
				{
					num = (short)691077121;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return;
				IL_141:
				pasiren = ((global::AcpCommonLib.FeatureManager.GetFeature(2033) as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWideRecset)[0][10225] as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.PASiren);
				num = (short)1258684424;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1AA:
				(signalIndependentProductIndependentNonProgrammableButtonListInnerRecset[28] as global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInner).SignalIndependentProductIndependentNonProgrammableButtonListInnerSection.RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonFeature_A19778.Value = 201;
				num = (short)1657077762;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2C5:
				(signalIndependentProductIndependentNonProgrammableButtonListInnerRecset[25] as global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInner).SignalIndependentProductIndependentNonProgrammableButtonListInnerSection.RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonFeature_A19778.Value = 200;
				(signalIndependentProductIndependentNonProgrammableButtonListInnerRecset[26] as global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInner).SignalIndependentProductIndependentNonProgrammableButtonListInnerSection.RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonFeature_A19778.Value = 202;
				num = (short)492961796;
				num2 = (int)((global::System.IntPtr)num);
			}
			Block_3:
			num = (short)446889984;
			short num4 = num;
			IL_23F:
			num = (short)669908992;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000124 RID: 292 RVA: 0x000380D8 File Offset: 0x000362D8
		private void UpdateAuxControlTable()
		{
			short num = (short)1126234209;
			short num2 = num;
			num = (short)49412193;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				return;
			case 1:
				break;
			default:
			{
				num = (short)148373504;
				short num3 = num;
				break;
			}
			}
			num = (short)771424257;
			if (num != 0)
			{
			}
			num = (short)274399232;
			if (num != 0)
			{
			}
			global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = (((global::AcpCommonLib.FeatureManager.GetFeature(2033) as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWideRecset)[0][10633] as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.AuxControl).EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.AuxControlTableInnerRecset).GetEnumerator();
			try
			{
				num = (short)1972633602;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
						goto IL_2A5;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_12C;
						}
						continue;
					case 3:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)1633681420;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.AuxControlTableInnerSection auxControlTableInnerSection = (enumerator.Current as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.AuxControlTableInner).AuxControlTableInnerSection;
						num = (short)1840775176;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						goto IL_305;
					case 5:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.AuxControlTableInnerSection auxControlTableInnerSection;
						auxControlTableInnerSection.RadErgoWideAuxControlAuxOffAlias_A37252.SetValue(auxControlTableInnerSection.RadErgoWideAuxControlAuxOffAlias_A37252.DefaultValue);
						num = (short)231407625;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.AuxControlTableInnerSection auxControlTableInnerSection;
						auxControlTableInnerSection.RadErgoWideAuxControlAuxOnAlias_A37250.SetValue(auxControlTableInnerSection.RadErgoWideAuxControlAuxOnAlias_A37250.DefaultValue);
						num = (short)1529544705;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.AuxControlTableInnerSection auxControlTableInnerSection;
						auxControlTableInnerSection.RadErgoWideAuxControlAbbrAuxOnAlias_A37612.SetValue(auxControlTableInnerSection.RadErgoWideAuxControlAbbrAuxOnAlias_A37612.DefaultValue);
						num = (short)787021824;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.AuxControlTableInnerSection auxControlTableInnerSection;
						if (auxControlTableInnerSection.RadErgoWideAuxControlAbbrAuxOnAlias_A37612.Value.Length < 1)
						{
							num = (short)774373383;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2A5;
					}
					case 9:
						goto IL_1EF;
					case 10:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.AuxControlTableInnerSection auxControlTableInnerSection;
						if (auxControlTableInnerSection.RadErgoWideAuxControlAuxOnAlias_A37250.Value.Length < 1)
						{
							num = (short)1812529158;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 11:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.AuxControlTableInnerSection auxControlTableInnerSection;
						if (auxControlTableInnerSection.RadErgoWideAuxControlAuxOffAlias_A37252.Value.Length < 1)
						{
							num = (short)1009451013;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1EF;
					}
					case 12:
						num = (short)1695612932;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_12C;
					IL_1EF:
					num = (short)751042570;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_237:
					num = (short)1933508611;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_12C:
					goto IL_237;
					IL_2A5:
					num = (short)1812987915;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_305:;
			}
			finally
			{
				num = (short)159580160;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_337;
						}
						continue;
					case 1:
						goto IL_36B;
					case 2:
						enumerator.Dispose();
						num = (short)1791164417;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_337:
					if (enumerator == null)
					{
						break;
					}
					num = (short)1300496386;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_36B:;
			}
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00038470 File Offset: 0x00036670
		private void DataProfileTrunkingGroupIDFixup()
		{
			short num = (short)1843920896;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_9E;
				}
				global::AcpCommonLib.IAcpRecordset feature;
				int codeplugMainVersion;
				for (;;)
				{
					IL_27:
					int num3;
					int num4;
					switch (num2)
					{
					case 0:
						num = (short)2027356172;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
						if (dataProfiles.TrunkingGroupID.EmbeddedRecset != null)
						{
							num = (short)615186439;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_378;
					}
					case 2:
					{
						global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.TrunkingGroupIDListInner trunkingGroupIDListInner;
						if (trunkingGroupIDListInner != null)
						{
							num = (short)1776812047;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_39A;
					}
					case 3:
						goto IL_1B0;
					case 4:
						num = (short)1580269569;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_1B0;
					case 6:
					{
						if (num3 >= feature.Count)
						{
							num = (short)1038942234;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles = feature[num3] as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles;
						num = (short)627245080;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						num4 = 0;
						num = (short)421658627;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						num = (short)820379662;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
					{
						global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
						if (num4 >= dataProfiles.TrunkingGroupID.EmbeddedRecset.Count)
						{
							num = (short)1799815184;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.TrunkingGroupIDListInner trunkingGroupIDListInner = dataProfiles.TrunkingGroupID.EmbeddedRecset[num4] as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.TrunkingGroupIDListInner;
						num = (short)1554251793;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						goto IL_39A;
					case 11:
					{
						global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.TrunkingGroupIDListInner trunkingGroupIDListInner;
						if (trunkingGroupIDListInner.TrunkingGroupIDListInnerSection.DataProfilesTrunkingGroupID_ASTRO25DataGroupID_A36204Value == trunkingGroupIDListInner.TrunkingGroupIDListInnerSection.DataProfilesTrunkingGroupID_ASTRO25DataGroupID_A36204.DefaultValue)
						{
							num = (short)1287192577;
							if (num != 0)
							{
							}
							num = (short)1328087062;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_39A;
					}
					case 12:
					{
						global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
						if (dataProfiles.TrunkingGroupID != null)
						{
							num = (short)1523580932;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_378;
					}
					case 13:
						num3 = 0;
						num = (short)2032992275;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
					{
						global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.TrunkingGroupIDListInner trunkingGroupIDListInner;
						if (trunkingGroupIDListInner.TrunkingGroupIDListInnerSection.DataProfilesTrunkingGroupID_ASTRO25DataGroupID_A36204.HiddenStatic)
						{
							num = (short)336855060;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_12E;
					}
					case 15:
						num = (short)2017984535;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						goto IL_378;
					case 17:
					{
						global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.TrunkingGroupIDListInner trunkingGroupIDListInner;
						if (trunkingGroupIDListInner != null)
						{
							num = (short)1241251848;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_12E;
					}
					case 18:
						goto IL_12E;
					case 19:
						goto IL_2C6;
					case 20:
					{
						num = (short)1399047937;
						short num5 = num;
						num = (short)885835521;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_229;
						default:
						{
							num = (short)847511552;
							if (num != 0)
							{
							}
							global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.TrunkingGroupIDListInner trunkingGroupIDListInner;
							trunkingGroupIDListInner.TrunkingGroupIDListInnerSection.DataProfilesTrunkingGroupID_ASTRO25DataGroupID_A36204.Valid = true;
							num = (short)988545042;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 21:
						num = (short)656211979;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
					{
						global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.TrunkingGroupIDListInner trunkingGroupIDListInner;
						trunkingGroupIDListInner.TrunkingGroupIDListInnerSection.DataProfilesTrunkingGroupID_ASTRO25DataGroupID_A36204.SetValue(trunkingGroupIDListInner.TrunkingGroupIDListInnerSection.DataProfilesTrunkingGroupID_ASTRO25DataGroupID_A36204.DefaultValue + num4);
						num = (short)726466570;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 23:
						if (codeplugMainVersion <= 2)
						{
							num = (short)1736704000;
							short num6 = num;
							num = (short)1906180117;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_39A;
					case 24:
					{
						global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
						if (dataProfiles != null)
						{
							goto IL_229;
						}
						goto IL_378;
					}
					case 25:
						goto IL_2C6;
					case 26:
						return;
					case 27:
						if (feature != null)
						{
							num = (short)1908736013;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					goto IL_9E;
					IL_12E:
					num = (short)301662210;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1B0:
					num = (short)1925382153;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_229:
					num = (short)989462528;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2C6:
					num = (short)840105990;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_378:
					num3++;
					num = (short)1554055193;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_39A:
					num4++;
					num = (short)330366981;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_9E:
				codeplugMainVersion = this.GetCodeplugMainVersion();
				feature = global::AcpCommonLib.FeatureManager.GetFeature(2054);
				num = (short)274137115;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000126 RID: 294 RVA: 0x000389D0 File Offset: 0x00036BD0
		private void ZoneToZoneCloneFixup(global::AcpCommonLib.UndoRedo.ContainerTask Task = null)
		{
			short num = (short)1602748416;
			switch (num)
			{
			default:
			{
				num = (short)107741264;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::AcpCommonLib.Permissions permissions;
					global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentRecset zoneChannelAssignmentRecset2;
					int num5;
					global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemRecset conventionalSystemRecset;
					global::AcpCommonLib.Permissions permissions2;
					bool value;
					bool flag;
					global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment;
					global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerRecset channelAssignmentListInnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemRecset conventionalSystemRecset2;
					int num7;
					int num8;
					global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInnerRecset frequencyOptionsInnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner;
					global::AcpBusinessLayer.FeatureNode referencedNode;
					int num9;
					switch (num2)
					{
					case 0:
						goto IL_AB0;
					case 1:
					{
						int num3 = 0;
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentRecset zoneChannelAssignmentRecset;
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = zoneChannelAssignmentRecset.GetEnumerator();
						num = (short)1664680004;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
					{
						permissions = (global::AcpCommonLib.Permissions)79;
						num = (short)1362427904;
						short num4 = num;
						num = (short)1928855595;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						if (Task != null)
						{
							num = (short)108003412;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						zoneChannelAssignmentRecset2[num5].Permissions = permissions;
						num = (short)1502085120;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.ASTROTalkgroupListRecset astrotalkgroupListRecset;
						if (astrotalkgroupListRecset != null)
						{
							num = (short)1652359209;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B7D;
					}
					case 5:
						num = (short)646840397;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						permissions = (global::AcpCommonLib.Permissions)15;
						num = (short)338034730;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_1097;
					case 8:
						goto IL_EC2;
					case 9:
						goto IL_235;
					case 10:
						goto IL_335;
					case 11:
						if (Task != null)
						{
							num = (short)1790181440;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						conventionalSystemRecset[0].Permissions = permissions2;
						conventionalSystemRecset.Min = 1;
						num = (short)785121288;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
					{
						if (value || flag)
						{
							num = (short)214433866;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.ASTROTalkgroupListRecset astrotalkgroupListRecset = global::AcpCommonLib.FeatureManager.GetFeature(2062) as global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.ASTROTalkgroupListRecset;
						num = (short)1089667076;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.ASTROTalkgroupListRecset astrotalkgroupListRecset;
						global::AcpCommonLib.Permissions permissions3;
						Task.AddTask(new global::AcpBusinessLayer.UndoRedo.ChangePermissionsTask(astrotalkgroupListRecset[0], permissions3));
						Task.AddTask(new global::AcpBusinessLayer.UndoRedo.ChangeMinTask(astrotalkgroupListRecset, 1));
						Task.AddTask(new global::AcpBusinessLayer.UndoRedo.ChangePermissionsTask(zoneChannelAssignment, permissions3));
						num = (short)1866858510;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
						goto IL_B7D;
					case 15:
						goto IL_B7D;
					case 16:
						num = (short)331939903;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.ASTROTalkgroupListRecset astrotalkgroupListRecset2;
						if (astrotalkgroupListRecset2 != null)
						{
							num = (short)1505230905;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_235;
					}
					case 18:
					{
						if (!value)
						{
							num = (short)1889271857;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentRecset zoneChannelAssignmentRecset = null;
						zoneChannelAssignmentRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2051) as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentRecset);
						num = (short)219742274;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 19:
						num = (short)86900768;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						if ((zoneChannelAssignmentRecset2[num5] as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment).Zone.ZnChanCfgZoneZoneCloningEnable_43119.Value)
						{
							num = (short)823328829;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_282;
					case 21:
						return;
					case 22:
						goto IL_2E5;
					case 23:
						goto IL_81E;
					case 24:
						goto IL_EC2;
					case 25:
						Task.AddTask(new global::AcpBusinessLayer.UndoRedo.ChangePermissionsTask(channelAssignmentListInnerRecset, permissions));
						num = (short)1652228103;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						goto IL_335;
					case 27:
						if (conventionalSystemRecset2.Count > 0)
						{
							num = (short)213516321;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_EC2;
					case 28:
					{
						global::AcpCommonLib.Permissions permissions3 = global::AcpCommonLib.Permissions.None;
						num = (short)1211433012;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 29:
						permissions = (global::AcpCommonLib.Permissions)768;
						num = (short)286457916;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 30:
						goto IL_9A5;
					case 31:
					{
						int num6 = 1 + (num7 + 1) * 16;
						num = (short)526778443;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 32:
						if ((zoneChannelAssignmentRecset2[num8] as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment).Zone.ZnChanCfgZoneZoneCloningEnable_43119.Value)
						{
							num = (short)1953169454;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num8++;
						num = (short)128712782;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
					{
						global::AcpCommonLib.Permissions permissions4 = (global::AcpCommonLib.Permissions)79;
						num = (short)264306758;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 34:
						Task.AddTask(new global::AcpBusinessLayer.UndoRedo.ChangePermissionsTask(frequencyOptionsInnerRecset, permissions));
						num = (short)1149239319;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 35:
						goto IL_1097;
					case 36:
						goto IL_F81;
					case 37:
						goto IL_282;
					case 38:
						Task.AddTask(new global::AcpBusinessLayer.UndoRedo.ChangePermissionsTask(channelAssignmentListInner, permissions));
						num = (short)697434201;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 39:
					{
						if (Task != null)
						{
							num = (short)2134638679;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.ASTROTalkgroupListRecset astrotalkgroupListRecset2;
						global::AcpCommonLib.Permissions permissions5;
						astrotalkgroupListRecset2[0].Permissions = permissions5;
						astrotalkgroupListRecset2.Min = 2;
						zoneChannelAssignment.Permissions = (global::AcpCommonLib.Permissions)14;
						num = (short)1931804681;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 40:
						goto IL_F81;
					case 41:
						num = (short)1278672987;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 42:
						num = (short)198443009;
						if (num != 0)
						{
						}
						if (Task != null)
						{
							num = (short)810680358;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						channelAssignmentListInner.Permissions = permissions;
						num = (short)22609942;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 43:
						if (Task != null)
						{
							num = (short)560463920;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						referencedNode.Permissions = permissions;
						num = (short)529137718;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 44:
						if (referencedNode != null)
						{
							num = (short)747110402;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_81E;
					case 45:
						if (channelAssignmentListInner != null)
						{
							num = (short)1404764166;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_81E;
					case 46:
						flag = true;
						num = (short)1360986194;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 47:
						num = (short)204996635;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 48:
						Task.AddTask(new global::AcpBusinessLayer.UndoRedo.ChangePermissionsTask(referencedNode, permissions));
						num = (short)742195267;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 49:
						return;
					case 50:
						if (conventionalSystemRecset2 != null)
						{
							num = (short)451412015;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_EC2;
					case 51:
						if (channelAssignmentListInnerRecset != null)
						{
							num = (short)1391984669;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_282;
					case 52:
					{
						if (Task != null)
						{
							num = (short)1801650189;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.ASTROTalkgroupListRecset astrotalkgroupListRecset;
						global::AcpCommonLib.Permissions permissions3;
						astrotalkgroupListRecset[0].Permissions = permissions3;
						astrotalkgroupListRecset.Min = 1;
						zoneChannelAssignment.Permissions = permissions3;
						num = (short)553254927;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 53:
						goto IL_235;
					case 54:
						goto IL_F23;
					case 55:
						if (num9 >= channelAssignmentListInnerRecset.Count)
						{
							num = (short)1801977893;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						channelAssignmentListInner = (channelAssignmentListInnerRecset[num9] as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner);
						num = (short)2023096365;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 56:
						if (num8 != 15)
						{
							num = (short)1035141139;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2A7;
					case 57:
						num = (short)1248919611;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 58:
						goto IL_AB0;
					case 59:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.ASTROTalkgroupListRecset astrotalkgroupListRecset2;
						if (astrotalkgroupListRecset2.Count > 0)
						{
							num = (short)2019164250;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_235;
					}
					case 60:
						if (Task != null)
						{
							num = (short)214695961;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						channelAssignmentListInnerRecset.Permissions = permissions;
						num = (short)1452474403;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 61:
						num7 = num5;
						permissions = (global::AcpCommonLib.Permissions)719;
						num = (short)1413349379;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 62:
						permissions2 = global::AcpCommonLib.Permissions.None;
						num = (short)685834251;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 63:
						if (num7 >= -1)
						{
							num = (short)107610143;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_335;
					case 64:
						goto IL_6E6;
					case 65:
						if (num8 >= zoneChannelAssignmentRecset2.Count)
						{
							num = (short)369492051;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1972633656;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 66:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentRecset zoneChannelAssignmentRecset;
						if (zoneChannelAssignmentRecset != null)
						{
							num = (short)1382678529;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 67:
						goto IL_F23;
					case 68:
						try
						{
							num = (short)1644756994;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if (acpFeatureNode != null)
									{
										num = (short)236060682;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if ((acpFeatureNode as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment).Zone.ZnChanCfgZoneZoneCloningEnable_43119 != null)
									{
										num = (short)1417150475;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									switch (0)
									{
									case 0:
										goto IL_46C;
									}
									continue;
								case 3:
									num = (short)1380515844;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									goto IL_628;
								case 5:
									num = (short)303235073;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									num = (short)1823604744;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									goto IL_49D;
								case 8:
									goto IL_502;
								case 9:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1468792835;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
									int num3;
									num3++;
									num = (short)431751181;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 10:
									num = (short)1382875148;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 11:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									(acpFeatureNode as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment).Zone.ZnChanCfgZoneZoneCloningEnable_43119.CallConstraints();
									num = (short)1165557767;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 12:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if ((acpFeatureNode as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment).Zone != null)
									{
										num = (short)1222836229;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 13:
								{
									int num3;
									if (num3 > 15)
									{
										num = (short)1782317062;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1161297920;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_5D2:
								num = (short)1695285257;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_46C:
								goto IL_5D2;
							}
							IL_49D:
							IL_502:
							IL_628:
							return;
						}
						finally
						{
							for (;;)
							{
								num = (short)1320681474;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									switch (num2)
									{
									case 0:
										goto IL_69A;
									case 1:
										enumerator.Dispose();
										num = (short)346423296;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_661;
										}
										continue;
									}
									IL_661:
									if (enumerator == null)
									{
										break;
									}
									num = (short)181469185;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_69C:
								num = (short)364602605;
								short num10 = num;
								num = (short)360604909;
								switch ((num10 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									continue;
								default:
									goto IL_6D0;
								}
								IL_69A:
								goto IL_69C;
							}
							IL_6D0:
							num = (short)1526071296;
							if (num != 0)
							{
							}
						}
						goto IL_6E6;
					case 69:
						goto IL_81E;
					case 70:
					{
						if (Task != null)
						{
							num = (short)180486217;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::AcpCommonLib.Permissions permissions4;
						conventionalSystemRecset2[0].Permissions = permissions4;
						conventionalSystemRecset2.Min = 2;
						num = (short)86638616;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 71:
						if (Task != null)
						{
							num = (short)747569186;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						frequencyOptionsInnerRecset.Permissions = permissions;
						num = (short)1983053893;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 72:
						goto IL_EC2;
					case 73:
					{
						global::AcpCommonLib.Permissions permissions4;
						Task.AddTask(new global::AcpBusinessLayer.UndoRedo.ChangePermissionsTask(conventionalSystemRecset2[0], permissions4));
						Task.AddTask(new global::AcpBusinessLayer.UndoRedo.ChangeMinTask(conventionalSystemRecset2, 2));
						num = (short)1544028232;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 74:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.ASTROTalkgroupListRecset astrotalkgroupListRecset2 = global::AcpCommonLib.FeatureManager.GetFeature(2062) as global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.ASTROTalkgroupListRecset;
						num = (short)1163788305;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 75:
					{
						if (Task != null)
						{
							num = (short)1233846348;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int num6;
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityRecset._Min = num6;
						num = (short)626327578;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 76:
					{
						int num6;
						Task.AddTask(new global::AcpBusinessLayer.UndoRedo.ChangeMinTask(global::AcpCommonLib.FeatureManager.GetFeature(2059), num6));
						num = (short)1803419658;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 77:
						if (conventionalSystemRecset.Count > 0)
						{
							num = (short)1715339326;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_EC2;
					case 78:
						goto IL_C72;
					case 79:
						goto IL_9A5;
					case 80:
						switch (0)
						{
						case 0:
							goto IL_1B5;
						}
						continue;
					case 81:
						goto IL_C72;
					case 82:
						goto IL_2A7;
					case 83:
						goto IL_2A7;
					case 84:
						Task.AddTask(new global::AcpBusinessLayer.UndoRedo.ChangePermissionsTask(zoneChannelAssignmentRecset2[num5], permissions));
						num = (short)246022202;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 85:
						goto IL_EC2;
					case 86:
						if (conventionalSystemRecset != null)
						{
							num = (short)1696595973;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_EC2;
					case 87:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.ASTROTalkgroupListRecset astrotalkgroupListRecset2;
						global::AcpCommonLib.Permissions permissions5;
						Task.AddTask(new global::AcpBusinessLayer.UndoRedo.ChangePermissionsTask(astrotalkgroupListRecset2[0], permissions5));
						Task.AddTask(new global::AcpBusinessLayer.UndoRedo.ChangeMinTask(astrotalkgroupListRecset2, 2));
						Task.AddTask(new global::AcpBusinessLayer.UndoRedo.ChangePermissionsTask(zoneChannelAssignment, (global::AcpCommonLib.Permissions)14));
						num = (short)858980405;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 88:
						if (num5 >= zoneChannelAssignmentRecset2.Count)
						{
							num = (short)1870397456;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1731330068;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 89:
						goto IL_2E5;
					case 90:
					{
						global::AcpCommonLib.Permissions permissions5 = (global::AcpCommonLib.Permissions)79;
						num = (short)1621622823;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 91:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.ASTROTalkgroupListRecset astrotalkgroupListRecset;
						if (astrotalkgroupListRecset.Count > 0)
						{
							num = (short)1477574684;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B7D;
					}
					}
					IL_1B5:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num = (short)1427963925;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Features features = global::AcpCommonLib.FeatureManager.GetFeature(2045)[0][10105] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Features;
					zoneChannelAssignmentRecset2 = (global::AcpCommonLib.FeatureManager.GetFeature(2051) as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentRecset);
					zoneChannelAssignment = (zoneChannelAssignmentRecset2[0] as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment);
					value = features.RadWideFeaturesZoneCloneEnable_43130.Value;
					flag = false;
					num8 = 0;
					num = (short)2105147473;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_235:
					conventionalSystemRecset2 = (global::AcpCommonLib.FeatureManager.GetFeature(2053) as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemRecset);
					num = (short)526319666;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_282:
					num5++;
					num = (short)1163919396;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2A7:
					num = (short)333578252;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2E5:
					referencedNode = channelAssignmentListInner.ChannelAssignmentListInnerSection.ZnChanCfgChannelsPersonality_A8698.ReferencedNode;
					num = (short)1314979884;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_335:
					num = (short)770048018;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6E6:
					Task.AddTask(new global::AcpBusinessLayer.UndoRedo.ChangePermissionsTask(conventionalSystemRecset[0], permissions2));
					Task.AddTask(new global::AcpBusinessLayer.UndoRedo.ChangeMinTask(conventionalSystemRecset, 1));
					num = (short)90439765;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_81E:
					num9++;
					num = (short)220987471;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_9A5:
					num = (short)1849622583;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_AB0:
					channelAssignmentListInnerRecset = ((zoneChannelAssignmentRecset2[num5] as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment).Channels.EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerRecset);
					num = (short)1552875571;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_B7D:
					conventionalSystemRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2053) as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemRecset);
					num = (short)756875350;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C72:
					num = (short)1543438401;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_EC2:
					num7 = -1;
					num5 = 0;
					num = (short)588447784;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_F23:
					frequencyOptionsInnerRecset = ((referencedNode as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality).FrequencyOptions.EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInnerRecset);
					permissions = (global::AcpCommonLib.Permissions)768;
					num = (short)1758789703;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_F81:
					num = (short)503447640;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1097:
					num9 = 0;
					num = (short)1576271902;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
			}
			}
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00039D10 File Offset: 0x00037F10
		private void DEKVipTableInit()
		{
			short num = (short)643039232;
			switch (num)
			{
			default:
			{
				num = (short)1644494875;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKRecset dekrecset;
					global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPsRecset radioVIPsRecset;
					global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInnerRecset radioVIPInnerRecset;
					int value;
					int num3;
					int num4;
					global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKVIPInnerRecset dekvipinnerRecset;
					switch (num2)
					{
					case 0:
						num = (short)489029636;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInner radioVIPInner;
						if (radioVIPInner != null)
						{
							num = (short)460259335;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6C4;
					}
					case 2:
						dekrecset = (global::AcpCommonLib.FeatureManager.GetFeature(2129) as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKRecset);
						radioVIPsRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2125) as global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPsRecset);
						num = (short)276037663;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInner radioVIPInner;
						if (radioVIPInner.RadioVIPInnerSection.RadVipOutputFeature_A20947.Value != 0)
						{
							num = (short)894369830;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6C4;
					}
					case 4:
						if (radioVIPInnerRecset != null)
						{
							num = (short)1406337059;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 5:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInner radioVIPInner;
						if (radioVIPInner.RadioVIPInnerSection.RadVipInputFeature_A21329.Value != 38)
						{
							num = (short)1711144966;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_324;
					}
					case 6:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInner radioVIPInner;
						radioVIPInner.RadioVIPInnerSection.RadVipInputFeature_A21329.SetValue(38);
						num = (short)1916338200;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						num = (short)222035973;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						if (dekrecset != null)
						{
							num = (short)257163283;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 9:
						return;
					case 10:
						if (value != 0)
						{
							num = (short)867237888;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 11:
						goto IL_5C5;
					case 12:
						if (num3 < 9)
						{
							num = (short)858390560;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 13:
						num = (short)1610874909;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						goto IL_400;
					case 15:
					{
						num = (short)1505820673;
						if (num != 0)
						{
						}
						global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKVIPInner dekvipinner;
						if (dekvipinner.DEKVIPInnerSection.DEKVIPOutputFeature_A21346.Value != 0)
						{
							num = (short)893845526;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_300;
					}
					case 16:
						goto IL_6C4;
					case 17:
					{
						global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKVIPInner dekvipinner;
						dekvipinner.DEKVIPInnerSection.DEKVIPInputFeature_A21338.SetValue(38);
						num = (short)1053949963;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 18:
						if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugConfigurationMode)
						{
							num = (short)693895170;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						dekrecset = (global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(2129) as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKRecset);
						radioVIPsRecset = (global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(2125) as global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPsRecset);
						num = (short)279838734;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						num = (short)480378910;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
					{
						if (num4 >= radioVIPInnerRecset.Count)
						{
							num = (short)1397424153;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInner radioVIPInner = radioVIPInnerRecset[num4] as global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInner;
						num = (short)317915137;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 21:
						num3 = 0;
						num = (short)1753808937;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
					{
						global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKVIPInner dekvipinner;
						dekvipinner.DEKVIPInnerSection.DEKVIPOutputFeature_A21346.SetValue(0);
						num = (short)1650393116;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 23:
						return;
					case 24:
						goto IL_324;
					case 25:
						goto IL_3AD;
					case 26:
						goto IL_370;
					case 27:
						switch (0)
						{
						case 0:
							goto IL_ED;
						}
						continue;
					case 28:
						goto IL_300;
					case 29:
					{
						global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKVIPInner dekvipinner;
						if (dekvipinner.DEKVIPInnerSection.DEKVIPInputFeature_A21338.Value != 38)
						{
							num = (short)1592000529;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5C5;
					}
					case 30:
						if (radioVIPsRecset == null)
						{
							num = (short)20971529;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_466;
					case 31:
						goto IL_400;
					case 32:
						num = (short)249823266;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
						goto IL_370;
					case 34:
					{
						if (dekvipinnerRecset == null)
						{
							num = (short)281215012;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKVIPInner dekvipinner = dekvipinnerRecset[num3] as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKVIPInner;
						num = (short)79822885;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 35:
						num4 = 0;
						num = (short)364249114;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 36:
						return;
					case 37:
					{
						global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKVIPInner dekvipinner;
						if (dekvipinner != null)
						{
							num = (short)1553661965;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_300;
					}
					case 38:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInner radioVIPInner;
						radioVIPInner.RadioVIPInnerSection.RadVipOutputFeature_A20947.SetValue(0);
						num = (short)1445421316;
						short num5 = num;
						num = (short)694247684;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_466;
						default:
							num = (short)196739072;
							if (num != 0)
							{
							}
							num = (short)1091305488;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 39:
						if (value == 0)
						{
							num = (short)1167786005;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1149829130;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 40:
						goto IL_153;
					case 41:
						goto IL_153;
					}
					IL_ED:
					if (!global::ConstraintHelper.UtilityMack.IsMobileOnly())
					{
						num = (short)1929576471;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)828243986;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_153:
					num = (short)584581132;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_300:
					num3++;
					num = (short)427884584;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_324:
					num = (short)1041367043;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_370:
					num = (short)1687420948;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_400:
					num = (short)796393472;
					short num6 = num;
					num = (short)984678408;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_466:
					dekvipinnerRecset = (dekrecset[0][10233].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKVIPInnerRecset);
					global::Motorola.MackinawCPS.CoreFeatures.DEK.General general = (dekrecset[0][10232].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInnerRecset).ParentSection as global::Motorola.MackinawCPS.CoreFeatures.DEK.General;
					radioVIPInnerRecset = (radioVIPsRecset[0][10218].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInnerRecset);
					value = general.DEKNumberofDEKBoxes_A8579.Value;
					num = (short)1242890279;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5C5:
					num = (short)1508376591;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6C4:
					num4++;
					num = (short)737411105;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_3AD:
				return;
			}
			}
		}

		// Token: 0x06000128 RID: 296 RVA: 0x0003A504 File Offset: 0x00038704
		private void KeypadRecsetAndTableInit()
		{
			short num = (short)1558839296;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_67;
				}
				global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadRecset keypadRecset;
				for (;;)
				{
					IL_28:
					int num5;
					string[] array;
					switch (num2)
					{
					case 0:
					{
						bool flag = true;
						num = (short)1763885439;
						short num3 = num;
						num = (short)2014036351;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_AC;
						default:
							num = (short)323289088;
							if (num != 0)
							{
							}
							num = (short)1204682760;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
					{
						global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInnerRecset keypadButtonInnerRecset;
						if (keypadButtonInnerRecset.Count >= 12)
						{
							num = (short)1525481482;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						keypadButtonInnerRecset.AddRecord(keypadButtonInnerRecset.CreateDefaultRecord());
						num = (short)1249050633;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_20A;
					case 3:
					{
						bool flag = false;
						global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInnerRecset keypadButtonInnerRecset = keypadRecset[0][10710].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInnerRecset;
						num = (short)102170637;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						return;
					case 5:
						goto IL_20A;
					case 6:
					{
						bool flag;
						if (flag)
						{
							num = (short)2041184268;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 7:
						if (keypadRecset != null)
						{
							num = (short)1241186307;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 8:
						goto IL_338;
					case 9:
						goto IL_338;
					case 10:
					{
						num = (short)1313865728;
						short num4 = num;
						num = (short)1602355206;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
					{
						num = (short)1194328065;
						if (num != 0)
						{
						}
						if (num5 >= 12)
						{
							num = (short)816578564;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInnerRecset keypadButtonInnerRecset;
						(keypadButtonInnerRecset[num5] as global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInner).KeypadButtonInnerSection.RadErgCtrlKeypadGeneralKeypadButtonName_A41069.SetValue(array[num5]);
						(keypadButtonInnerRecset[num5] as global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInner).KeypadButtonInnerSection.RadErgCtrlKeypadGeneralKeypadBCO_A41070.SetValue(global::Motorola.MackinawCPS.CoreFeatures.Keypad.LOVs.indexRadErgCtrlKeypadGeneralKeypadBCO_A41070LovStrs[num5]);
						num5++;
						num = (short)691404802;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
						goto IL_AC;
					case 13:
					{
						global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInnerRecset keypadButtonInnerRecset;
						if (keypadButtonInnerRecset.Count < 12)
						{
							num = (short)790167552;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_338;
					}
					}
					goto IL_67;
					IL_AC:
					array = new string[]
					{
						global::CommonResources.AcgResources.ID_ZERO0,
						global::CommonResources.MTFResources.One1_Id,
						global::CommonResources.MTFResources.Two2_Id,
						global::CommonResources.MTFResources.Three3_Id,
						global::CommonResources.MTFResources.Four4_Id,
						global::CommonResources.MTFResources.Five5_Id,
						global::CommonResources.MTFResources.Six6_Id,
						global::CommonResources.MTFResources.Seven7_Id,
						global::CommonResources.MTFResources.Eight8_Id,
						global::CommonResources.MTFResources.Nine9_Id,
						global::CommonResources.MTFResources.Star_Id,
						global::CommonResources.MTFResources.PoundHash_Id
					};
					num5 = 0;
					num = (short)459472901;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_20A:
					num = (short)160301067;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_338:
					num = (short)1662058497;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_67:
				keypadRecset = (global::AcpCommonLib.FeatureManager.GetFeature(4109) as global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadRecset);
				num = (short)1391198215;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06000129 RID: 297 RVA: 0x0003A8B0 File Offset: 0x00038AB0
		private void SyncE5BottomButton()
		{
			short num = (short)222822400;
			switch (num)
			{
			default:
			{
				num = (short)536739855;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5BottomFunctionButtonInnerSection e5BottomFunctionButtonInnerSection;
					global::AcpBusinessLayer.AcpListField acpListField;
					global::AcpCommonLib.IAcpRecordset acpRecordset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5BottomFunctionButtonInnerSection e5BottomFunctionButtonInnerSection2;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionButtonBCOListInnerRecset bottomFunctionButtonBCOListInnerRecset;
					object obj;
					object obj2;
					switch (num2)
					{
					case 0:
						e5BottomFunctionButtonInnerSection = null;
						goto IL_18C;
					case 1:
						acpListField = null;
						goto IL_266;
					case 2:
						num = (short)168755213;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset controlHeadO9Recset = global::AcpCommonLib.FeatureManager.GetFeature(4003) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset;
						if (controlHeadO9Recset == null)
						{
							num = (short)526843915;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						acpRecordset = controlHeadO9Recset[0][10628].EmbeddedRecset;
						goto IL_1EE;
					}
					case 4:
						if (e5BottomFunctionButtonInnerSection2 == null)
						{
							num = (short)1926299653;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1773928462;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						num = (short)323092481;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						return;
					case 7:
						if (bottomFunctionButtonBCOListInnerRecset != null)
						{
							num = (short)1181417474;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 8:
						obj = null;
						goto IL_109;
					case 9:
						obj2 = null;
						goto IL_138;
					case 10:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.ControlHeadE5Recset controlHeadE5Recset = global::AcpCommonLib.FeatureManager.GetFeature(4236) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.ControlHeadE5Recset;
						if (controlHeadE5Recset == null)
						{
							num = (short)1613758472;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						obj = controlHeadE5Recset[0][10903].EmbeddedRecset;
						goto IL_109;
					}
					case 11:
						acpRecordset = null;
						goto IL_1EE;
					case 12:
						goto IL_2F4;
					case 13:
					{
						if (e5BottomFunctionButtonInnerSection2 == null)
						{
							num = (short)1930231824;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = bottomFunctionButtonBCOListInnerRecset.GetEnumerator();
						num = (short)1831796748;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
						acpListField = e5BottomFunctionButtonInnerSection2.E5BottomFunctionButtonBCO_43757;
						goto IL_266;
					case 15:
						switch (0)
						{
						case 0:
							goto IL_88;
						}
						continue;
					case 16:
						return;
					}
					IL_88:
					if (!global::ConstraintHelper.UtilityMack.IsMobileOnly())
					{
						num = (short)1131020294;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)850657290;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_109:
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5BottomFunctionButtonInnerRecset e5BottomFunctionButtonInnerRecset = obj as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5BottomFunctionButtonInnerRecset;
					if (e5BottomFunctionButtonInnerRecset == null)
					{
						num = (short)1606156297;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					obj2 = e5BottomFunctionButtonInnerRecset[0];
					IL_138:
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5BottomFunctionButtonInner e5BottomFunctionButtonInner = obj2 as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5BottomFunctionButtonInner;
					if (e5BottomFunctionButtonInner == null)
					{
						num = (short)1098842113;
						if (num != 0)
						{
						}
						num = (short)491585536;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					e5BottomFunctionButtonInnerSection = e5BottomFunctionButtonInner.E5BottomFunctionButtonInnerSection;
					IL_18C:
					e5BottomFunctionButtonInnerSection2 = e5BottomFunctionButtonInnerSection;
					num = (short)1666056195;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1EE:
					bottomFunctionButtonBCOListInnerRecset = (acpRecordset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionButtonBCOListInnerRecset);
					num = (short)1311113220;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_266:
					global::AcpBusinessLayer.AcpListField acpListField2 = acpListField;
					num = (short)20316167;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_2F4:
				try
				{
					num = (short)898695173;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionButtonBCOListInner bottomFunctionButtonBCOListInner;
						switch (num2)
						{
						case 0:
						{
							global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5BottomFunctionButtonInnerSection e5BottomFunctionButtonInnerSection2;
							e5BottomFunctionButtonInnerSection2.E5BottomFunctionButtonFeature_43758.Value = bottomFunctionButtonBCOListInner.BottomFunctionButtonBCOListInnerSection.CHO9BottomFunctionButtonFeature_A36826.Value;
							num = (short)1562312706;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							goto IL_3A8;
						case 2:
							goto IL_446;
						case 3:
							num = (short)1828257798;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
						{
							global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
							if (!enumerator.MoveNext())
							{
								num = (short)92602371;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							bottomFunctionButtonBCOListInner = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionButtonBCOListInner)enumerator.Current;
							num = (short)1478688769;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
						{
							num = (short)1590477816;
							short num3 = num;
							num = (short)2085274616;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_3A8;
							default:
								num = (short)765460480;
								if (num != 0)
								{
								}
								switch (0)
								{
								case 0:
									goto IL_383;
								}
								continue;
							}
							break;
						}
						case 6:
							goto IL_463;
						}
						goto IL_383;
						IL_3A8:
						global::AcpBusinessLayer.AcpListField acpListField2;
						if (bottomFunctionButtonBCOListInner.BottomFunctionButtonBCOListInnerSection.CHO9BottomFunctionButtonBCO_A36827.Value == acpListField2.Value)
						{
							num = (short)103481344;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_3D8:
						num = (short)997523460;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_383:
						goto IL_3D8;
					}
					IL_446:
					IL_463:;
				}
				finally
				{
					num = (short)979697665;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
						switch (num2)
						{
						case 0:
							enumerator.Dispose();
							num = (short)1376256002;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_499;
							}
							continue;
						case 2:
							goto IL_4CF;
						}
						IL_499:
						if (enumerator == null)
						{
							break;
						}
						num = (short)93388800;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_4CF:;
				}
				num = (short)1273692160;
				short num4 = num;
				return;
			}
			}
		}

		// Token: 0x040000C2 RID: 194
		[global::System.NonSerialized]
		string VafgnaprSvryq = 32;
	}
}
