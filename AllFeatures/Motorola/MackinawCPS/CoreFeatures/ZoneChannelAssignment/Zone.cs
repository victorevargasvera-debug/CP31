using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using ConstraintHelper;
using Features.Radio_Ergonomics_Configuration.Display_and_Menu;
using Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu;
using Motorola.MackinawCPS.CoreFeatures.DVRSWide;
using Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;

namespace Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment
{
	// Token: 0x0200004B RID: 75
	[global::System.Serializable]
	public class Zone : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600033C RID: 828 RVA: 0x0003BDB4 File Offset: 0x00039FB4
		public Zone(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x0600033D RID: 829 RVA: 0x0003BDD0 File Offset: 0x00039FD0
		protected Zone(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600033E RID: 830 RVA: 0x0003BDE8 File Offset: 0x00039FE8
		public override void Init()
		{
			int a_ = 10;
			short num = (short)1517826448;
			short num2 = num;
			num = (short)1137717648;
			switch (num2 == num)
			{
			default:
			{
				num = (short)97517568;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1504641025;
			if (num != 0)
			{
			}
			num = (short)1897332736;
			if (num != 0)
			{
			}
			this.b();
			this.znChanCfgZoneZoneName_A9724 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("释ꏌ賎말닒믔铖뿘볚蟜냞迠蛢뿤裦蟨軪ꏬ軮鳰雲ꫴ뛶샸쳺쿼쯾", a_), global::CommonResources.AcgResources.ID_ZONENAME, 20);
			this.znChanCfgZoneZoneName_A9724.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.znChanCfgZoneZoneName_A9724.DataTransferOrder = 11;
			this.znChanCfgZoneTopDisplayZone_A19772 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_Z, this, global::AllFeatures.CodeplugGuid.b("释ꏌ賎말닒믔铖뿘볚蟜냞迠蛢뇤裦駨꿪蓬鳮臰鿲铴軶ꏸ铺鏼髾帀䈂㐄㸆㸈㰊㼌", a_), global::CommonResources.AcgResources.ID_TOPDISPLAYZONE, 8);
			this.znChanCfgZoneTopDisplayZone_A19772.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.znChanCfgZoneTopDisplayZone_A19772.DataTransferOrder = 12;
			this.zoneVoiceAnnouncementID_A21514 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("释ꋌꇎ듐藒뫔뻖뫘뻚鳜뇞迠賢郤触諨軪胬諮鿰蟲보돶꛸뫺쿼컾㐀㈂㄄", a_), global::CommonResources.AcgResources.ID_ZONEANNOUNCEMENT, new string[]
			{
				global::CommonResources.AcgResources.ID_NONE,
				global::CommonResources.AcgResources.ID_TTS
			}, new int[]
			{
				0,
				65535
			}, true, false);
			this.zoneVoiceAnnouncementID_A21514.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.zoneVoiceAnnouncementID_A21514.DataTransferOrder = 8;
			this.vCZoneAnnouncement_A21515 = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::AllFeatures.CodeplugGuid.b("鷊軌闎뻐뷒냔雖럘뗚닜꫞迠胢胤諦賨藪駬냮냰쇲쓴싶죸컺", a_), global::CommonResources.AcgResources.ID_VC_Zone_TTSANNOUNCEMENT, 35);
			this.vCZoneAnnouncement_A21515.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.vCZoneAnnouncement_A21515.DataTransferOrder = 9;
			this.znChanCfgZoneDynamicZoneEnable_A41257 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("释ꏌ賎말닒믔铖뿘볚蟜냞迠蛢ꇤ黦蟨諪胬蛮鋰꧲髴駶鳸뻺鏼黾挀漂怄堆䠈㼊㰌㴎␐␒", a_), global::CommonResources.AcgResources.ID_DYNAMICZONEENABLE);
			this.znChanCfgZoneDynamicZoneEnable_A41257.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.znChanCfgZoneDynamicZoneEnable_A41257.DataTransferOrder = 16;
			this.znChanCfgZoneDynamicZoneEnable_A41257.ValidateAcrossRecset = true;
			this.znChanCfgZoneDynamicZoneEnable_A41257.EvaluateRecRefs = true;
			this.znChanCfgZoneZoneCloningEnable_43119 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("释ꏌ賎말닒믔铖뿘볚蟜냞迠蛢뿤裦蟨軪껬菮黰鷲鳴駶黸뻺鏼黾挀漂怄堆㴈㠊㰌㸎⠐", a_), global::CommonResources.AcgResources.ID_CLONEENABLE);
			this.znChanCfgZoneZoneCloningEnable_43119.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.znChanCfgZoneZoneCloningEnable_43119.DataTransferOrder = 500;
			this.znChanCfgZoneZoneCloningEnable_43119.ValidateAcrossRecset = true;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("释ꋌꇎ듐", a_);
			base.Id = 10116;
			base.UIName = global::CommonResources.AcgResources.ID_ZONE;
			base.DataTransferOrder = 1;
		}

		// Token: 0x0600033F RID: 831 RVA: 0x0003C080 File Offset: 0x0003A280
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 18;
			short num = (short)390594571;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_36B;
				case 1:
					goto IL_3BD;
				case 2:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("藒雔跖뛘뗚룜點迠跢諤鋦蟨裪裬苮铰鷲致ꣶ룸짺쳼쫾\u3000㘂", a_)))
					{
						num = (short)2003238926;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A9;
				case 3:
					this.znChanCfgZoneZoneName_A9724 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("角믔铖뇘뫚돜鳞蟠蓢뿤裦蟨軪러胮鿰雲믴零铸黺ꋼ뻾㠀㐂㜄㌆", a_), global::CommonResources.AcgResources.ID_ZONENAME, 20);
					this.znChanCfgZoneZoneName_A9724.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.znChanCfgZoneZoneName_A9724.DataTransferOrder = 11;
					num = (short)459341825;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
				{
					if (producerFields == null)
					{
						goto IL_5A0;
					}
					num = (short)2012973093;
					short num3 = num;
					num = (short)7178277;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_2B1;
					default:
						num = (short)281739264;
						if (num != 0)
						{
						}
						num = (short)96272396;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 5:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("角믔铖뇘뫚돜鳞蟠蓢뿤裦蟨軪러胮鿰雲뛴鯶雸闺铼釾昀䘂欄昆欈朊栌倎┐‒␔☖‘", a_)))
					{
						num = (short)482934793;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5A0;
				case 6:
					goto IL_474;
				case 7:
					this.zoneVoiceAnnouncementID_A21514 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("角뫔맖볘跚닜뛞苠蛢ꓤ触蟨蓪飬臮鋰雲飴鋶韸迺듼믾帀䈂㜄㘆㰈㨊㤌", a_), global::CommonResources.AcgResources.ID_ZONEANNOUNCEMENT, new string[]
					{
						global::CommonResources.AcgResources.ID_NONE,
						global::CommonResources.AcgResources.ID_TTS
					}, new int[]
					{
						0,
						65535
					}, true, false);
					this.zoneVoiceAnnouncementID_A21514.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.zoneVoiceAnnouncementID_A21514.DataTransferOrder = 8;
					num = (short)188678150;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
				{
					num = (short)813629440;
					short num4 = num;
					this.znChanCfgZoneDynamicZoneEnable_A41257 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("角믔铖뇘뫚돜鳞蟠蓢뿤裦蟨軪ꧬ雮鿰鋲飴黶髸ꇺ鋼釾搀䘂欄昆欈朊栌倎倐✒␔┖ⰘⰚ", a_), global::CommonResources.AcgResources.ID_DYNAMICZONEENABLE);
					this.znChanCfgZoneDynamicZoneEnable_A41257.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.znChanCfgZoneDynamicZoneEnable_A41257.DataTransferOrder = 16;
					this.znChanCfgZoneDynamicZoneEnable_A41257.ValidateAcrossRecset = true;
					this.znChanCfgZoneDynamicZoneEnable_A41257.EvaluateRecRefs = true;
					num = (short)686096400;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 9:
					this.znChanCfgZoneZoneCloningEnable_43119 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("角믔铖뇘뫚돜鳞蟠蓢뿤裦蟨軪러胮鿰雲뛴鯶雸闺铼釾昀䘂欄昆欈朊栌倎┐‒␔☖‘", a_), global::CommonResources.AcgResources.ID_CLONEENABLE);
					this.znChanCfgZoneZoneCloningEnable_43119.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.znChanCfgZoneZoneCloningEnable_43119.DataTransferOrder = 500;
					this.znChanCfgZoneZoneCloningEnable_43119.ValidateAcrossRecset = true;
					num = (short)79495168;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("角믔铖뇘뫚돜鳞蟠蓢뿤裦蟨軪러胮鿰雲믴零铸黺ꋼ뻾㠀㐂㜄㌆", a_)))
					{
						num = (short)934608899;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3BD;
				case 11:
					switch (0)
					{
					case 0:
						goto IL_86;
					}
					continue;
				case 12:
					num = (short)1855979530;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					goto IL_A9;
				case 14:
					goto IL_2B1;
				case 15:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("角믔铖뇘뫚돜鳞蟠蓢뿤裦蟨軪맬胮臰럲鳴蓶觸韺鳼蛾嬀氂欄戆嘈䨊㰌㘎☐␒✔", a_)))
					{
						num = (short)1911685139;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_370;
				case 16:
					goto IL_217;
				case 17:
					goto IL_370;
				case 18:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("角믔铖뇘뫚돜鳞蟠蓢뿤裦蟨軪ꧬ雮鿰鋲飴黶髸ꇺ鋼釾搀䘂欄昆欈朊栌倎倐✒␔┖ⰘⰚ", a_)))
					{
						num = (short)1169948673;
						if (num != 0)
						{
						}
						num = (short)1157955592;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_217;
				case 19:
					this.znChanCfgZoneTopDisplayZone_A19772 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_Z, this, global::AllFeatures.CodeplugGuid.b("角믔铖뇘뫚돜鳞蟠蓢뿤裦蟨軪맬胮臰럲鳴蓶觸韺鳼蛾嬀氂欄戆嘈䨊㰌㘎☐␒✔", a_), global::CommonResources.AcgResources.ID_TOPDISPLAYZONE, 8);
					this.znChanCfgZoneTopDisplayZone_A19772.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.znChanCfgZoneTopDisplayZone_A19772.DataTransferOrder = 12;
					num = (short)1979121681;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 20:
					num = (short)354156548;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 21:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("角뫔맖볘跚닜뛞苠蛢ꓤ触蟨蓪飬臮鋰雲飴鋶韸迺듼믾帀䈂㜄㘆㰈㨊㤌", a_)))
					{
						num = (short)1019084807;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_474;
				}
				IL_86:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)954728468;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_A9:
				num = (short)1552482322;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_217:
				num = (short)1743454213;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2B1:
				this.vCZoneAnnouncement_A21515 = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::AllFeatures.CodeplugGuid.b("藒雔跖뛘뗚룜點迠跢諤鋦蟨裪裬苮铰鷲致ꣶ룸짺쳼쫾\u3000㘂", a_), global::CommonResources.AcgResources.ID_VC_Zone_TTSANNOUNCEMENT, 35);
				this.vCZoneAnnouncement_A21515.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
				this.vCZoneAnnouncement_A21515.DataTransferOrder = 9;
				num = (short)2000027661;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_370:
				num = (short)683278357;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3BD:
				num = (short)1059520527;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_474:
				num = (short)569311234;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_36B:
			IL_5A0:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("角뫔맖볘", a_);
			base.Id = 10116;
			base.UIName = global::CommonResources.AcgResources.ID_ZONE;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06000340 RID: 832 RVA: 0x0003C660 File Offset: 0x0003A860
		public override void PopulateReferences()
		{
			short num = (short)185908816;
			short num2 = num;
			num = (short)1778630224;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1705771008;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)709427201;
			if (num != 0)
			{
			}
			num = (short)1684340736;
			if (num != 0)
			{
			}
			this.zoneVoiceAnnouncementID_A21514.SetRecset(this.a(2300));
		}

		// Token: 0x06000341 RID: 833 RVA: 0x0003C720 File Offset: 0x0003A920
		public override void DropReferences()
		{
			short num = (short)40165510;
			short num2 = num;
			num = (short)85516422;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1376256000;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)442695681;
			if (num != 0)
			{
			}
			num = (short)1559625728;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000342 RID: 834 RVA: 0x0003C7CC File Offset: 0x0003A9CC
		public override void SetConstraints()
		{
			short num = (short)927924225;
			if (num != 0)
			{
			}
			num = (short)2086600704;
			short num2 = num;
			num = (short)20546753;
			short num3 = num;
			num = (short)238519489;
			switch (num3 == num)
			{
			}
			num = (short)2137849856;
			if (num != 0)
			{
			}
			this.znChanCfgZoneZoneName_A9724.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentConstraints.ConZnTextSizeNotNone);
			this.znChanCfgZoneZoneName_A9724.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentConstraints.ConZoneTextSizeLimited);
			this.znChanCfgZoneTopDisplayZone_A19772.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentConstraints.ConTopDisplayZoneTextSize);
			this.zoneVoiceAnnouncementID_A21514.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentConstraints.ConZoneCheckRSIModeIsDisabled);
			this.zoneVoiceAnnouncementID_A21514.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentConstraints.ConIsZnChanVARecRefSelectionValid);
			this.znChanCfgZoneDynamicZoneEnable_A41257.ValidateAcrossRecset = true;
			this.znChanCfgZoneDynamicZoneEnable_A41257.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentConstraints.ConDynamicZoneEnableApplicable);
			this.znChanCfgZoneDynamicZoneEnable_A41257.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentConstraints.ConNonDynamicZoneExistFPPDisableProtectedZoneDisable);
			this.znChanCfgZoneDynamicZoneEnable_A41257.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentConstraints.ConDynamicZoneEnableEditability);
			this.znChanCfgZoneDynamicZoneEnable_A41257.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentConstraints.ConDynamicZoneEnableValue);
			this.znChanCfgZoneZoneCloningEnable_43119.ValidateAcrossRecset = true;
			this.znChanCfgZoneZoneCloningEnable_43119.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentConstraints.ConZoneChannAssignCloneEnableApplicable);
			this.znChanCfgZoneZoneCloningEnable_43119.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentConstraints.ConCloneEnableValid);
			this.znChanCfgZoneZoneCloningEnable_43119.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentConstraints.ConZoneChannAssignCloneEnableEditable);
			this.znChanCfgZoneZoneCloningEnable_43119.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentConstraints.ConZoneChannelAssignmentCloningEnableValueSetter);
			this.VCZoneAnnouncement_A21515.ValidateAcrossRecset = true;
			this.VCZoneAnnouncement_A21515.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentConstraints.ConIsVoiceAnnouncementVoiceControlApplicable);
			this.VCZoneAnnouncement_A21515.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentConstraints.ConIsVoiceAnnouncementVoiceControlNotConfusable);
		}

		// Token: 0x06000343 RID: 835 RVA: 0x0003C9F0 File Offset: 0x0003ABF0
		public override void SetupDependencies()
		{
			int num;
			short num2;
			switch (0)
			{
			case 0:
				break;
			default:
			{
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Features features;
				for (;;)
				{
					IL_0A:
					object obj;
					switch (num)
					{
					case 0:
						return;
					case 1:
						obj = null;
						goto IL_209;
					case 2:
					{
						num2 = (short)2098462721;
						if (num2 != 0)
						{
						}
						global::AcpCommonLib.IAcpRecordset feature = global::AcpCommonLib.FeatureManager.GetFeature(2045);
						if (feature == null)
						{
							num2 = (short)1778253825;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = feature[0];
						if (acpFeatureNode != null)
						{
							obj = acpFeatureNode[10105];
							goto IL_209;
						}
						num2 = (short)1693612766;
						short num3 = num2;
						num2 = (short)1310816990;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_F0;
						default:
							num2 = (short)1955004416;
							if (num2 != 0)
							{
							}
							num2 = (short)1671626755;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 3:
					{
						num2 = (short)1047658496;
						short num4 = num2;
						obj = null;
						goto IL_209;
					}
					}
					goto IL_20;
					IL_209:
					features = (obj as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Features);
					if (features != null)
					{
						goto IL_22C;
					}
					num2 = (short)1795620864;
					num = (int)((global::System.IntPtr)num2);
				}
				return;
				IL_22C:
				global::AcpBusinessLayer.AcpListField radWideFeaturesVoiceControlPriority = features.RadWideFeaturesVoiceControlPriority;
				if (radWideFeaturesVoiceControlPriority == null)
				{
					return;
				}
				radWideFeaturesVoiceControlPriority.AddDependentObject(this.VCZoneAnnouncement_A21515);
				return;
			}
			}
			IL_20:
			this.RefDisplayAndMenu.General.DispMenuGeneralZoneTextSize_A8167.AddDependentObject(this.znChanCfgZoneZoneName_A9724);
			this.RefDisplayAndMenu.General.DispMenuGeneralTopZoneTextSize_A19769.AddDependentObject(this.znChanCfgZoneTopDisplayZone_A19772);
			this.RefDVRSWide.General.RadErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911.AddDependentObject(this.znChanCfgZoneDynamicZoneEnable_A41257);
			this.RefRadioWide.Features.RadWideFeaturesZoneCloneEnable_43130.AddDependentObject(this.znChanCfgZoneZoneCloningEnable_43119);
			this.znChanCfgZoneDynamicZoneEnable_A41257.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2033)[0][10076] as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.HomeMode).RadErgoWideHomeModeZone_A9691);
			this.znChanCfgZoneZoneCloningEnable_43119.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2045)[0][10105] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Features).RadWideFeaturesZoneCloneEnable_43130);
			IL_F0:
			num2 = (short)1688797186;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x06000344 RID: 836 RVA: 0x0003CC44 File Offset: 0x0003AE44
		public bool HasDiffs
		{
			get
			{
				short num = (short)191177280;
				short num2 = num;
				num = (short)1747001920;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1240858624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2112684033;
				if (num != 0)
				{
				}
				num = (short)321912832;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x06000345 RID: 837 RVA: 0x0003CCF4 File Offset: 0x0003AEF4
		// (set) Token: 0x06000346 RID: 838 RVA: 0x0003CDA8 File Offset: 0x0003AFA8
		public string ZnChanCfgZoneZoneName_A9724Value
		{
			get
			{
				short num = (short)546768745;
				short num2 = num;
				num = (short)1512114025;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2030108672;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1459224577;
				if (num != 0)
				{
				}
				num = (short)2117533696;
				if (num != 0)
				{
				}
				return this.znChanCfgZoneZoneName_A9724.Value;
			}
			set
			{
				short num = (short)1025376257;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)1088022986;
					short num3 = num;
					num = (short)1555556810;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					case 1:
						goto IL_7D;
					default:
					{
						num = (short)1615986688;
						short num4 = num;
						goto IL_7D;
					}
					}
					IL_14:
					switch (0)
					{
					case 0:
						IL_CD:
						if (string.IsNullOrEmpty(value.Trim()))
						{
							return;
						}
						num = (short)1829502978;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					continue;
					IL_7D:
					num = (short)541917185;
					if (num != 0)
					{
					}
					num = (short)2078932992;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						return;
					case 1:
						goto IL_14;
					case 2:
						this.znChanCfgZoneZoneName_A9724.Value = value;
						num = (short)37027840;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_CD;
				}
			}
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x06000347 RID: 839 RVA: 0x0003CED0 File Offset: 0x0003B0D0
		// (set) Token: 0x06000348 RID: 840 RVA: 0x0003CF84 File Offset: 0x0003B184
		public string ZnChanCfgZoneZoneName_A9724_UIValue
		{
			get
			{
				short num = (short)1336994547;
				short num2 = num;
				num = (short)132180723;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1053622272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)915734529;
				if (num != 0)
				{
				}
				num = (short)454754304;
				if (num != 0)
				{
				}
				return this.znChanCfgZoneZoneName_A9724.Value;
			}
			set
			{
				short num = (short)757233006;
				short num2 = num;
				num = (short)1898345838;
				switch (num2 == num)
				{
				default:
				{
					num = (short)593362944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)218497024;
				if (num != 0)
				{
				}
				num = (short)783482881;
				if (num != 0)
				{
				}
				this.znChanCfgZoneZoneName_A9724.Value = value;
			}
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x06000349 RID: 841 RVA: 0x0003D038 File Offset: 0x0003B238
		public global::AcpBusinessLayer.AcpKeyField ZnChanCfgZoneZoneName_A9724
		{
			get
			{
				short num = (short)2130065120;
				short num2 = num;
				num = (short)1950955232;
				switch (num2 == num)
				{
				default:
				{
					num = (short)414121984;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)253558784;
				if (num != 0)
				{
				}
				num = (short)1320419329;
				if (num != 0)
				{
				}
				return this.znChanCfgZoneZoneName_A9724;
			}
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x0600034A RID: 842 RVA: 0x0003D0E8 File Offset: 0x0003B2E8
		// (set) Token: 0x0600034B RID: 843 RVA: 0x0003D19C File Offset: 0x0003B39C
		public bool ZnChanCfgZoneZoneName_A9724_Applicable
		{
			get
			{
				short num = (short)1034599532;
				short num2 = num;
				num = (short)132037740;
				switch (num2 == num)
				{
				default:
				{
					num = (short)623116288;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1640235009;
				if (num != 0)
				{
				}
				num = (short)964689920;
				if (num != 0)
				{
				}
				return this.znChanCfgZoneZoneName_A9724.Applicable;
			}
			set
			{
				short num = (short)1806022078;
				short num2 = num;
				num = (short)76789182;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1998651392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1996881921;
				if (num != 0)
				{
				}
				num = (short)1912471552;
				if (num != 0)
				{
				}
				this.znChanCfgZoneZoneName_A9724.Applicable = value;
			}
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x0600034C RID: 844 RVA: 0x0003D254 File Offset: 0x0003B454
		// (set) Token: 0x0600034D RID: 845 RVA: 0x0003D308 File Offset: 0x0003B508
		public bool ZnChanCfgZoneZoneName_A9724_Valid
		{
			get
			{
				short num = (short)1139242554;
				short num2 = num;
				num = (short)1204516410;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1098973184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)861929473;
				if (num != 0)
				{
				}
				num = (short)624623616;
				if (num != 0)
				{
				}
				return this.znChanCfgZoneZoneName_A9724.Valid;
			}
			set
			{
				short num = (short)1575045976;
				short num2 = num;
				num = (short)111430488;
				switch (num2 == num)
				{
				default:
				{
					num = (short)193462272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1341652992;
				if (num != 0)
				{
				}
				num = (short)1815937025;
				if (num != 0)
				{
				}
				this.znChanCfgZoneZoneName_A9724.Valid = value;
			}
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x0600034E RID: 846 RVA: 0x0003D3BC File Offset: 0x0003B5BC
		// (set) Token: 0x0600034F RID: 847 RVA: 0x0003D470 File Offset: 0x0003B670
		public bool ZnChanCfgZoneZoneName_A9724_Visible
		{
			get
			{
				short num = (short)1336824714;
				short num2 = num;
				num = (short)2117227402;
				switch (num2 == num)
				{
				default:
				{
					num = (short)817889280;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1263009793;
				if (num != 0)
				{
				}
				num = (short)1857290240;
				if (num != 0)
				{
				}
				return this.znChanCfgZoneZoneName_A9724.Visible;
			}
			set
			{
				short num = (short)1117257729;
				if (num != 0)
				{
				}
				num = (short)925564928;
				short num2 = num;
				num = (short)643902620;
				short num3 = num;
				num = (short)1858219164;
				switch (num3 == num)
				{
				}
				num = (short)945225728;
				if (num != 0)
				{
				}
				this.znChanCfgZoneZoneName_A9724.Visible = value;
			}
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x06000350 RID: 848 RVA: 0x0003D528 File Offset: 0x0003B728
		// (set) Token: 0x06000351 RID: 849 RVA: 0x0003D5E0 File Offset: 0x0003B7E0
		public bool ZnChanCfgZoneZoneName_A9724_Editable
		{
			get
			{
				short num = (short)1555935251;
				short num2 = num;
				num = (short)2121707539;
				switch (num2 == num)
				{
				default:
				{
					num = (short)924516352;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1445789697;
				if (num != 0)
				{
				}
				num = (short)1013448704;
				if (num != 0)
				{
				}
				return this.znChanCfgZoneZoneName_A9724.Editable;
			}
			set
			{
				short num = (short)1069110354;
				short num2 = num;
				num = (short)1761498194;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1565065216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1441923073;
				if (num != 0)
				{
				}
				num = (short)1571094528;
				if (num != 0)
				{
				}
				this.znChanCfgZoneZoneName_A9724.Editable = value;
			}
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x06000352 RID: 850 RVA: 0x0003D698 File Offset: 0x0003B898
		internal string ZnChanCfgZoneZoneName_A9724_UILabel
		{
			get
			{
				short num = (short)1814341699;
				short num2 = num;
				num = (short)1793828931;
				switch (num2 == num)
				{
				default:
				{
					num = (short)607780864;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)109051905;
				if (num != 0)
				{
				}
				num = (short)1229783040;
				if (num != 0)
				{
				}
				return this.znChanCfgZoneZoneName_A9724.UIName;
			}
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x06000353 RID: 851 RVA: 0x0003D74C File Offset: 0x0003B94C
		// (set) Token: 0x06000354 RID: 852 RVA: 0x0003D800 File Offset: 0x0003BA00
		internal bool ZnChanCfgZoneZoneName_A9724_HiddenStatic
		{
			get
			{
				short num = (short)499383580;
				short num2 = num;
				num = (short)82771228;
				switch (num2 == num)
				{
				}
				num = (short)737083392;
				short num3 = num;
				num = (short)1192558593;
				if (num != 0)
				{
				}
				num = (short)556138496;
				if (num != 0)
				{
				}
				return this.znChanCfgZoneZoneName_A9724.HiddenStatic;
			}
			set
			{
				short num = (short)372591302;
				short num2 = num;
				num = (short)1049971398;
				switch (num2 == num)
				{
				}
				num = (short)474349568;
				short num3 = num;
				num = (short)1884028928;
				if (num != 0)
				{
				}
				num = (short)50659329;
				if (num != 0)
				{
				}
				this.znChanCfgZoneZoneName_A9724.HiddenStatic = value;
			}
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x06000355 RID: 853 RVA: 0x0003D8B8 File Offset: 0x0003BAB8
		// (set) Token: 0x06000356 RID: 854 RVA: 0x0003D970 File Offset: 0x0003BB70
		internal bool ZnChanCfgZoneZoneName_A9724_HiddenDynamic
		{
			get
			{
				short num = (short)1770127361;
				if (num != 0)
				{
				}
				num = (short)1656649156;
				short num2 = num;
				num = (short)846296516;
				switch (num2 == num)
				{
				default:
				{
					num = (short)492437504;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1688535040;
				if (num != 0)
				{
				}
				return this.znChanCfgZoneZoneName_A9724.HiddenDynamic;
			}
			set
			{
				short num = (short)16582042;
				short num2 = num;
				num = (short)1449723290;
				switch (num2 == num)
				{
				}
				num = (short)1775435776;
				short num3 = num;
				num = (short)1838940161;
				if (num != 0)
				{
				}
				num = (short)691404800;
				if (num != 0)
				{
				}
				this.znChanCfgZoneZoneName_A9724.HiddenDynamic = value;
			}
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x06000357 RID: 855 RVA: 0x0003DA28 File Offset: 0x0003BC28
		public bool ZnChanCfgZoneZoneName_A9724_HasDiffs
		{
			get
			{
				short num = (short)2099052545;
				if (num != 0)
				{
				}
				num = (short)814132210;
				short num2 = num;
				num = (short)881634290;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1850015744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1223491584;
				if (num != 0)
				{
				}
				return this.znChanCfgZoneZoneName_A9724._HasDiffs;
			}
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x06000358 RID: 856 RVA: 0x0003DADC File Offset: 0x0003BCDC
		// (set) Token: 0x06000359 RID: 857 RVA: 0x0003DB90 File Offset: 0x0003BD90
		public string ZnChanCfgZoneTopDisplayZone_A19772Value
		{
			get
			{
				short num = (short)479178670;
				short num2 = num;
				num = (short)999010222;
				switch (num2 == num)
				{
				}
				num = (short)2084306944;
				short num3 = num;
				num = (short)2080636929;
				if (num != 0)
				{
				}
				num = (short)906821632;
				if (num != 0)
				{
				}
				return this.znChanCfgZoneTopDisplayZone_A19772.Value;
			}
			set
			{
				short num = (short)1760586105;
				short num2 = num;
				num = (short)2078304633;
				switch (num2 == num)
				{
				}
				num = (short)392953856;
				short num3 = num;
				num = (short)252182529;
				if (num != 0)
				{
				}
				num = (short)742064128;
				if (num != 0)
				{
				}
				this.znChanCfgZoneTopDisplayZone_A19772.Value = value;
			}
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x0600035A RID: 858 RVA: 0x0003DC44 File Offset: 0x0003BE44
		public global::AcpBusinessLayer.AcpField<string> ZnChanCfgZoneTopDisplayZone_A19772
		{
			get
			{
				short num = (short)1144349964;
				short num2 = num;
				num = (short)890529036;
				switch (num2 == num)
				{
				}
				num = (short)1712455680;
				short num3 = num;
				num = (short)1747910657;
				if (num != 0)
				{
				}
				num = (short)801177600;
				if (num != 0)
				{
				}
				return this.znChanCfgZoneTopDisplayZone_A19772;
			}
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x0600035B RID: 859 RVA: 0x0003DCF8 File Offset: 0x0003BEF8
		// (set) Token: 0x0600035C RID: 860 RVA: 0x0003DDB0 File Offset: 0x0003BFB0
		public string ZnChanCfgZoneTopDisplayZone_A19772_UIValue
		{
			get
			{
				short num = (short)1446038944;
				short num2 = num;
				num = (short)239652256;
				switch (num2 == num)
				{
				}
				num = (short)889389056;
				short num3 = num;
				num = (short)2018181120;
				if (num != 0)
				{
				}
				num = (short)436207617;
				if (num != 0)
				{
				}
				return this.znChanCfgZoneTopDisplayZone_A19772.Value;
			}
			set
			{
				short num = (short)926220289;
				if (num != 0)
				{
				}
				num = (short)299835993;
				short num2 = num;
				num = (short)60301913;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1605828608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1653211136;
				if (num != 0)
				{
				}
				this.znChanCfgZoneTopDisplayZone_A19772.Value = value;
			}
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x0600035D RID: 861 RVA: 0x0003DE68 File Offset: 0x0003C068
		// (set) Token: 0x0600035E RID: 862 RVA: 0x0003DF1C File Offset: 0x0003C11C
		public bool ZnChanCfgZoneTopDisplayZone_A19772_Applicable
		{
			get
			{
				short num = (short)530251777;
				if (num != 0)
				{
				}
				num = (short)1516078491;
				short num2 = num;
				num = (short)1383695771;
				switch (num2 == num)
				{
				default:
				{
					num = (short)393216000;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1265631232;
				if (num != 0)
				{
				}
				return this.znChanCfgZoneTopDisplayZone_A19772.Applicable;
			}
			set
			{
				short num = (short)308215809;
				if (num != 0)
				{
				}
				num = (short)1225868975;
				short num2 = num;
				num = (short)1430537903;
				switch (num2 == num)
				{
				default:
				{
					num = (short)503971840;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1494614016;
				if (num != 0)
				{
				}
				this.znChanCfgZoneTopDisplayZone_A19772.Applicable = value;
			}
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x0600035F RID: 863 RVA: 0x0003DFD0 File Offset: 0x0003C1D0
		// (set) Token: 0x06000360 RID: 864 RVA: 0x0003E088 File Offset: 0x0003C288
		public bool ZnChanCfgZoneTopDisplayZone_A19772_Valid
		{
			get
			{
				short num = (short)668075606;
				short num2 = num;
				num = (short)806094422;
				switch (num2 == num)
				{
				}
				num = (short)1498087424;
				short num3 = num;
				num = (short)1708654593;
				if (num != 0)
				{
				}
				num = (short)655360;
				if (num != 0)
				{
				}
				return this.znChanCfgZoneTopDisplayZone_A19772.Valid;
			}
			set
			{
				short num = (short)1794933461;
				short num2 = num;
				num = (short)335971029;
				switch (num2 == num)
				{
				}
				num = (short)61997056;
				short num3 = num;
				num = (short)1472200704;
				if (num != 0)
				{
				}
				num = (short)264241153;
				if (num != 0)
				{
				}
				this.znChanCfgZoneTopDisplayZone_A19772.Valid = value;
			}
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x06000361 RID: 865 RVA: 0x0003E13C File Offset: 0x0003C33C
		// (set) Token: 0x06000362 RID: 866 RVA: 0x0003E1EC File Offset: 0x0003C3EC
		public bool ZnChanCfgZoneTopDisplayZone_A19772_Visible
		{
			get
			{
				short num = (short)56253563;
				short num2 = num;
				num = (short)1955552379;
				switch (num2 == num)
				{
				}
				num = (short)1712848896;
				short num3 = num;
				num = (short)1510342657;
				if (num != 0)
				{
				}
				num = (short)92667904;
				if (num != 0)
				{
				}
				return this.znChanCfgZoneTopDisplayZone_A19772.Visible;
			}
			set
			{
				short num = (short)829016992;
				short num2 = num;
				num = (short)1185729440;
				switch (num2 == num)
				{
				}
				num = (short)1317208064;
				short num3 = num;
				num = (short)826146816;
				if (num != 0)
				{
				}
				num = (short)192806913;
				if (num != 0)
				{
				}
				this.znChanCfgZoneTopDisplayZone_A19772.Visible = value;
			}
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x06000363 RID: 867 RVA: 0x0003E2A0 File Offset: 0x0003C4A0
		// (set) Token: 0x06000364 RID: 868 RVA: 0x0003E354 File Offset: 0x0003C554
		public bool ZnChanCfgZoneTopDisplayZone_A19772_Editable
		{
			get
			{
				short num = (short)2123059701;
				short num2 = num;
				num = (short)1874874869;
				switch (num2 == num)
				{
				}
				num = (short)962396160;
				short num3 = num;
				num = (short)1652817921;
				if (num != 0)
				{
				}
				num = (short)972029952;
				if (num != 0)
				{
				}
				return this.znChanCfgZoneTopDisplayZone_A19772.Editable;
			}
			set
			{
				short num = (short)1054408705;
				if (num != 0)
				{
				}
				num = (short)1485071208;
				short num2 = num;
				num = (short)445408104;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1856372736;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1566113792;
				if (num != 0)
				{
				}
				this.znChanCfgZoneTopDisplayZone_A19772.Editable = value;
			}
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x06000365 RID: 869 RVA: 0x0003E40C File Offset: 0x0003C60C
		internal string ZnChanCfgZoneTopDisplayZone_A19772_UILabel
		{
			get
			{
				short num = (short)329083263;
				short num2 = num;
				num = (short)1809213823;
				switch (num2 == num)
				{
				}
				num = (short)555024384;
				short num3 = num;
				num = (short)1556217856;
				if (num != 0)
				{
				}
				num = (short)930217985;
				if (num != 0)
				{
				}
				return this.znChanCfgZoneTopDisplayZone_A19772.UIName;
			}
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x06000366 RID: 870 RVA: 0x0003E4C4 File Offset: 0x0003C6C4
		// (set) Token: 0x06000367 RID: 871 RVA: 0x0003E578 File Offset: 0x0003C778
		internal bool ZnChanCfgZoneTopDisplayZone_A19772_HiddenStatic
		{
			get
			{
				short num = (short)200015873;
				if (num != 0)
				{
				}
				num = (short)451119831;
				short num2 = num;
				num = (short)229411543;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1164640256;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1490157568;
				if (num != 0)
				{
				}
				return this.znChanCfgZoneTopDisplayZone_A19772.HiddenStatic;
			}
			set
			{
				short num = (short)415703770;
				short num2 = num;
				num = (short)606937818;
				switch (num2 == num)
				{
				}
				num = (short)320012288;
				short num3 = num;
				num = (short)1810432001;
				if (num != 0)
				{
				}
				num = (short)485621760;
				if (num != 0)
				{
				}
				this.znChanCfgZoneTopDisplayZone_A19772.HiddenStatic = value;
			}
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x06000368 RID: 872 RVA: 0x0003E630 File Offset: 0x0003C830
		// (set) Token: 0x06000369 RID: 873 RVA: 0x0003E6E8 File Offset: 0x0003C8E8
		internal bool ZnChanCfgZoneTopDisplayZone_A19772_HiddenDynamic
		{
			get
			{
				short num = (short)1701741048;
				short num2 = num;
				num = (short)631931384;
				switch (num2 == num)
				{
				}
				num = (short)866058240;
				short num3 = num;
				num = (short)2066677761;
				if (num != 0)
				{
				}
				num = (short)811532288;
				if (num != 0)
				{
				}
				return this.znChanCfgZoneTopDisplayZone_A19772.HiddenDynamic;
			}
			set
			{
				short num = (short)697027339;
				short num2 = num;
				num = (short)918997771;
				switch (num2 == num)
				{
				}
				num = (short)1065877504;
				short num3 = num;
				num = (short)1003618304;
				if (num != 0)
				{
				}
				num = (short)382795777;
				if (num != 0)
				{
				}
				this.znChanCfgZoneTopDisplayZone_A19772.HiddenDynamic = value;
			}
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x0600036A RID: 874 RVA: 0x0003E7A0 File Offset: 0x0003C9A0
		public bool ZnChanCfgZoneTopDisplayZone_A19772_HasDiffs
		{
			get
			{
				short num = (short)459041061;
				short num2 = num;
				num = (short)624912677;
				switch (num2 == num)
				{
				}
				num = (short)1441726464;
				short num3 = num;
				num = (short)2002845697;
				if (num != 0)
				{
				}
				num = (short)1255538688;
				if (num != 0)
				{
				}
				return this.znChanCfgZoneTopDisplayZone_A19772._HasDiffs;
			}
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x0600036B RID: 875 RVA: 0x0003E854 File Offset: 0x0003CA54
		// (set) Token: 0x0600036C RID: 876 RVA: 0x0003E90C File Offset: 0x0003CB0C
		public int ZoneVoiceAnnouncementID_A21514Value
		{
			get
			{
				short num = (short)764862424;
				short num2 = num;
				num = (short)1234690008;
				switch (num2 == num)
				{
				}
				num = (short)201195520;
				short num3 = num;
				num = (short)969539585;
				if (num != 0)
				{
				}
				num = (short)119799808;
				if (num != 0)
				{
				}
				return this.zoneVoiceAnnouncementID_A21514.Value;
			}
			set
			{
				short num = (short)920915204;
				short num2 = num;
				num = (short)549653764;
				switch (num2 == num)
				{
				}
				num = (short)1585381376;
				short num3 = num;
				num = (short)1095303168;
				if (num != 0)
				{
				}
				num = (short)692256769;
				if (num != 0)
				{
				}
				this.zoneVoiceAnnouncementID_A21514.Value = value;
			}
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x0600036D RID: 877 RVA: 0x0003E9C0 File Offset: 0x0003CBC0
		// (set) Token: 0x0600036E RID: 878 RVA: 0x0003EA74 File Offset: 0x0003CC74
		public string ZoneVoiceAnnouncementID_A21514_UIValue
		{
			get
			{
				short num = (short)1997152580;
				short num2 = num;
				num = (short)1175986500;
				switch (num2 == num)
				{
				}
				num = (short)1020329984;
				short num3 = num;
				num = (short)1868365825;
				if (num != 0)
				{
				}
				num = (short)1366360064;
				if (num != 0)
				{
				}
				return this.zoneVoiceAnnouncementID_A21514.UIValue;
			}
			set
			{
				short num = (short)1525908757;
				short num2 = num;
				num = (short)2045674773;
				switch (num2 == num)
				{
				}
				num = (short)1224540160;
				short num3 = num;
				num = (short)769785857;
				if (num != 0)
				{
				}
				num = (short)838270976;
				if (num != 0)
				{
				}
				this.zoneVoiceAnnouncementID_A21514.UIValue = value;
			}
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x0600036F RID: 879 RVA: 0x0003EB2C File Offset: 0x0003CD2C
		public global::AcpBusinessLayer.AcpRecRefField ZoneVoiceAnnouncementID_A21514
		{
			get
			{
				short num = (short)843456224;
				short num2 = num;
				num = (short)1520049888;
				switch (num2 == num)
				{
				}
				num = (short)933756928;
				short num3 = num;
				num = (short)28573697;
				if (num != 0)
				{
				}
				num = (short)478871552;
				if (num != 0)
				{
				}
				return this.zoneVoiceAnnouncementID_A21514;
			}
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x06000370 RID: 880 RVA: 0x0003EBDC File Offset: 0x0003CDDC
		// (set) Token: 0x06000371 RID: 881 RVA: 0x0003EC90 File Offset: 0x0003CE90
		public bool ZoneVoiceAnnouncementID_A21514_Applicable
		{
			get
			{
				short num = (short)2133950372;
				short num2 = num;
				num = (short)720469924;
				switch (num2 == num)
				{
				}
				num = (short)1210187776;
				short num3 = num;
				num = (short)1476067329;
				if (num != 0)
				{
				}
				num = (short)346488832;
				if (num != 0)
				{
				}
				return this.zoneVoiceAnnouncementID_A21514.Applicable;
			}
			set
			{
				short num = (short)1908342785;
				if (num != 0)
				{
				}
				num = (short)1606467043;
				short num2 = num;
				num = (short)1460125155;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1003749376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2088304640;
				if (num != 0)
				{
				}
				this.zoneVoiceAnnouncementID_A21514.Applicable = value;
			}
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x06000372 RID: 882 RVA: 0x0003ED44 File Offset: 0x0003CF44
		// (set) Token: 0x06000373 RID: 883 RVA: 0x0003EDF8 File Offset: 0x0003CFF8
		public bool ZoneVoiceAnnouncementID_A21514_Valid
		{
			get
			{
				short num = (short)842716920;
				short num2 = num;
				num = (short)1753667320;
				switch (num2 == num)
				{
				}
				num = (short)309329920;
				short num3 = num;
				num = (short)1592852480;
				if (num != 0)
				{
				}
				num = (short)969080833;
				if (num != 0)
				{
				}
				return this.zoneVoiceAnnouncementID_A21514.Valid;
			}
			set
			{
				short num = (short)1185948611;
				short num2 = num;
				num = (short)909714371;
				switch (num2 == num)
				{
				}
				num = (short)2012610560;
				short num3 = num;
				num = (short)1678639105;
				if (num != 0)
				{
				}
				num = (short)879558656;
				if (num != 0)
				{
				}
				this.zoneVoiceAnnouncementID_A21514.Valid = value;
			}
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x06000374 RID: 884 RVA: 0x0003EEAC File Offset: 0x0003D0AC
		// (set) Token: 0x06000375 RID: 885 RVA: 0x0003EF60 File Offset: 0x0003D160
		public bool ZoneVoiceAnnouncementID_A21514_Visible
		{
			get
			{
				short num = (short)268497604;
				short num2 = num;
				num = (short)1240134340;
				switch (num2 == num)
				{
				}
				num = (short)1421672448;
				short num3 = num;
				num = (short)612106241;
				if (num != 0)
				{
				}
				num = (short)885850112;
				if (num != 0)
				{
				}
				return this.zoneVoiceAnnouncementID_A21514.Visible;
			}
			set
			{
				short num = (short)1689728116;
				short num2 = num;
				num = (short)1499083892;
				switch (num2 == num)
				{
				}
				num = (short)697303040;
				short num3 = num;
				num = (short)276561920;
				if (num != 0)
				{
				}
				num = (short)1124794369;
				if (num != 0)
				{
				}
				this.zoneVoiceAnnouncementID_A21514.Visible = value;
			}
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x06000376 RID: 886 RVA: 0x0003F014 File Offset: 0x0003D214
		// (set) Token: 0x06000377 RID: 887 RVA: 0x0003F0CC File Offset: 0x0003D2CC
		public bool ZoneVoiceAnnouncementID_A21514_Editable
		{
			get
			{
				short num = (short)980630878;
				short num2 = num;
				num = (short)1199390046;
				switch (num2 == num)
				{
				}
				num = (short)1819475968;
				short num3 = num;
				num = (short)873136129;
				if (num != 0)
				{
				}
				num = (short)1340997632;
				if (num != 0)
				{
				}
				return this.zoneVoiceAnnouncementID_A21514.Editable;
			}
			set
			{
				short num = (short)1104889995;
				short num2 = num;
				num = (short)164186251;
				switch (num2 == num)
				{
				}
				num = (short)199426048;
				short num3 = num;
				num = (short)1612185601;
				if (num != 0)
				{
				}
				num = (short)1330249728;
				if (num != 0)
				{
				}
				this.zoneVoiceAnnouncementID_A21514.Editable = value;
			}
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x06000378 RID: 888 RVA: 0x0003F180 File Offset: 0x0003D380
		internal string ZoneVoiceAnnouncementID_A21514_UILabel
		{
			get
			{
				short num = (short)791599852;
				short num2 = num;
				num = (short)1463802604;
				switch (num2 == num)
				{
				}
				num = (short)365428736;
				short num3 = num;
				num = (short)2085421057;
				if (num != 0)
				{
				}
				num = (short)1847853056;
				if (num != 0)
				{
				}
				return this.zoneVoiceAnnouncementID_A21514.UIName;
			}
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x06000379 RID: 889 RVA: 0x0003F234 File Offset: 0x0003D434
		// (set) Token: 0x0600037A RID: 890 RVA: 0x0003F2EC File Offset: 0x0003D4EC
		internal bool ZoneVoiceAnnouncementID_A21514_HiddenStatic
		{
			get
			{
				short num = (short)280352975;
				short num2 = num;
				num = (short)1038735567;
				switch (num2 == num)
				{
				}
				num = (short)1668808704;
				short num3 = num;
				num = (short)2121859072;
				if (num != 0)
				{
				}
				num = (short)131661825;
				if (num != 0)
				{
				}
				return this.zoneVoiceAnnouncementID_A21514.HiddenStatic;
			}
			set
			{
				short num = (short)91605807;
				short num2 = num;
				num = (short)656591663;
				switch (num2 == num)
				{
				}
				num = (short)1631649792;
				short num3 = num;
				num = (short)688979968;
				if (num != 0)
				{
				}
				num = (short)1852440577;
				if (num != 0)
				{
				}
				this.zoneVoiceAnnouncementID_A21514.HiddenStatic = value;
			}
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x0600037B RID: 891 RVA: 0x0003F3A0 File Offset: 0x0003D5A0
		// (set) Token: 0x0600037C RID: 892 RVA: 0x0003F454 File Offset: 0x0003D654
		internal bool ZoneVoiceAnnouncementID_A21514_HiddenDynamic
		{
			get
			{
				short num = (short)30193862;
				short num2 = num;
				num = (short)2052503750;
				switch (num2 == num)
				{
				}
				num = (short)1901133824;
				short num3 = num;
				num = (short)1033699328;
				if (num != 0)
				{
				}
				num = (short)201261057;
				if (num != 0)
				{
				}
				return this.zoneVoiceAnnouncementID_A21514.HiddenDynamic;
			}
			set
			{
				short num = (short)1790616156;
				short num2 = num;
				num = (short)1828102748;
				switch (num2 == num)
				{
				}
				num = (short)994115584;
				short num3 = num;
				num = (short)1219428353;
				if (num != 0)
				{
				}
				num = (short)1680801792;
				if (num != 0)
				{
				}
				this.zoneVoiceAnnouncementID_A21514.HiddenDynamic = value;
			}
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x0600037D RID: 893 RVA: 0x0003F508 File Offset: 0x0003D708
		public bool ZoneVoiceAnnouncementID_A21514_HasDiffs
		{
			get
			{
				short num = (short)515906601;
				short num2 = num;
				num = (short)1594170409;
				switch (num2 == num)
				{
				}
				num = (short)1113980928;
				short num3 = num;
				num = (short)813105153;
				if (num != 0)
				{
				}
				num = (short)742260736;
				if (num != 0)
				{
				}
				return this.zoneVoiceAnnouncementID_A21514._HasDiffs;
			}
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x0600037E RID: 894 RVA: 0x0003F5C0 File Offset: 0x0003D7C0
		// (set) Token: 0x0600037F RID: 895 RVA: 0x0003F674 File Offset: 0x0003D874
		public string VCZoneAnnouncement_A21515Value
		{
			get
			{
				short num = (short)1595211777;
				if (num != 0)
				{
				}
				num = (short)1686096026;
				short num2 = num;
				num = (short)296011930;
				switch (num2 == num)
				{
				default:
				{
					num = (short)805044224;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)388628480;
				if (num != 0)
				{
				}
				return this.vCZoneAnnouncement_A21515.Value;
			}
			set
			{
				short num = (short)437383122;
				short num2 = num;
				num = (short)558952402;
				switch (num2 == num)
				{
				}
				num = (short)460587008;
				short num3 = num;
				num = (short)1268908032;
				if (num != 0)
				{
				}
				num = (short)398458881;
				if (num != 0)
				{
				}
				this.vCZoneAnnouncement_A21515.Value = value;
			}
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x06000380 RID: 896 RVA: 0x0003F72C File Offset: 0x0003D92C
		public global::AcpBusinessLayer.AcpField<string> VCZoneAnnouncement_A21515
		{
			get
			{
				short num = (short)1894576177;
				short num2 = num;
				num = (short)1644621873;
				switch (num2 == num)
				{
				}
				num = (short)1578041344;
				short num3 = num;
				num = (short)196739072;
				if (num != 0)
				{
				}
				num = (short)371785729;
				if (num != 0)
				{
				}
				return this.vCZoneAnnouncement_A21515;
			}
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x06000381 RID: 897 RVA: 0x0003F7E0 File Offset: 0x0003D9E0
		// (set) Token: 0x06000382 RID: 898 RVA: 0x0003F894 File Offset: 0x0003DA94
		public string VCZoneAnnouncement_A21515_UIValue
		{
			get
			{
				short num = (short)672970262;
				short num2 = num;
				num = (short)543602198;
				switch (num2 == num)
				{
				}
				num = (short)1951334400;
				short num3 = num;
				num = (short)1799421952;
				if (num != 0)
				{
				}
				num = (short)1861091329;
				if (num != 0)
				{
				}
				return this.vCZoneAnnouncement_A21515.Value;
			}
			set
			{
				short num = (short)1442067176;
				short num2 = num;
				num = (short)1463628520;
				switch (num2 == num)
				{
				}
				num = (short)1479409664;
				short num3 = num;
				num = (short)175243265;
				if (num != 0)
				{
				}
				num = (short)2025979904;
				if (num != 0)
				{
				}
				this.vCZoneAnnouncement_A21515.Value = value;
			}
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x06000383 RID: 899 RVA: 0x0003F948 File Offset: 0x0003DB48
		// (set) Token: 0x06000384 RID: 900 RVA: 0x0003F9FC File Offset: 0x0003DBFC
		public bool VCZoneAnnouncement_A21515_Applicable
		{
			get
			{
				short num = (short)1112480191;
				short num2 = num;
				num = (short)1907890623;
				switch (num2 == num)
				{
				}
				num = (short)1282015232;
				short num3 = num;
				num = (short)577896448;
				if (num != 0)
				{
				}
				num = (short)2120220673;
				if (num != 0)
				{
				}
				return this.vCZoneAnnouncement_A21515.Applicable;
			}
			set
			{
				short num = (short)1231519671;
				short num2 = num;
				num = (short)435322807;
				switch (num2 == num)
				{
				}
				num = (short)400359424;
				short num3 = num;
				num = (short)1653932033;
				if (num != 0)
				{
				}
				num = (short)340393984;
				if (num != 0)
				{
				}
				this.vCZoneAnnouncement_A21515.Applicable = value;
			}
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x06000385 RID: 901 RVA: 0x0003FAB0 File Offset: 0x0003DCB0
		// (set) Token: 0x06000386 RID: 902 RVA: 0x0003FB64 File Offset: 0x0003DD64
		public bool VCZoneAnnouncement_A21515_Valid
		{
			get
			{
				short num = (short)1413480853;
				short num2 = num;
				num = (short)1697251733;
				switch (num2 == num)
				{
				}
				num = (short)2123300864;
				short num3 = num;
				num = (short)815988737;
				if (num != 0)
				{
				}
				num = (short)1116405760;
				if (num != 0)
				{
				}
				return this.vCZoneAnnouncement_A21515.Valid;
			}
			set
			{
				short num = (short)1407371572;
				short num2 = num;
				num = (short)1230162228;
				switch (num2 == num)
				{
				}
				num = (short)904527872;
				short num3 = num;
				num = (short)123535360;
				if (num != 0)
				{
				}
				num = (short)354680833;
				if (num != 0)
				{
				}
				this.vCZoneAnnouncement_A21515.Valid = value;
			}
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x06000387 RID: 903 RVA: 0x0003FC18 File Offset: 0x0003DE18
		// (set) Token: 0x06000388 RID: 904 RVA: 0x0003FCCC File Offset: 0x0003DECC
		public bool VCZoneAnnouncement_A21515_Visible
		{
			get
			{
				short num = (short)1397376660;
				short num2 = num;
				num = (short)842221204;
				switch (num2 == num)
				{
				}
				num = (short)2133065728;
				short num3 = num;
				num = (short)1616248833;
				if (num != 0)
				{
				}
				num = (short)1611726848;
				if (num != 0)
				{
				}
				return this.vCZoneAnnouncement_A21515.Visible;
			}
			set
			{
				short num = (short)9750907;
				short num2 = num;
				num = (short)630835579;
				switch (num2 == num)
				{
				}
				num = (short)221708288;
				short num3 = num;
				num = (short)1646592001;
				if (num != 0)
				{
				}
				num = (short)1308688384;
				if (num != 0)
				{
				}
				this.vCZoneAnnouncement_A21515.Visible = value;
			}
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x06000389 RID: 905 RVA: 0x0003FD84 File Offset: 0x0003DF84
		// (set) Token: 0x0600038A RID: 906 RVA: 0x0003FE38 File Offset: 0x0003E038
		public bool VCZoneAnnouncement_A21515_Editable
		{
			get
			{
				short num = (short)118030337;
				if (num != 0)
				{
				}
				num = (short)209225065;
				short num2 = num;
				num = (short)50562409;
				switch (num2 == num)
				{
				}
				num = (short)274989056;
				if (num != 0)
				{
				}
				num = (short)1410465792;
				short num3 = num;
				return this.vCZoneAnnouncement_A21515.Editable;
			}
			set
			{
				short num = (short)549223203;
				short num2 = num;
				num = (short)1637120803;
				switch (num2 == num)
				{
				}
				num = (short)1627586561;
				if (num != 0)
				{
				}
				num = (short)1131216896;
				if (num != 0)
				{
				}
				num = (short)663617536;
				short num3 = num;
				this.vCZoneAnnouncement_A21515.Editable = value;
			}
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x0600038B RID: 907 RVA: 0x0003FEF0 File Offset: 0x0003E0F0
		internal string VCZoneAnnouncement_A21515_UILabel
		{
			get
			{
				short num = (short)2144042939;
				short num2 = num;
				num = (short)547520443;
				switch (num2 == num)
				{
				}
				num = (short)1583153152;
				if (num != 0)
				{
				}
				num = (short)219742209;
				if (num != 0)
				{
				}
				num = (short)1624506368;
				short num3 = num;
				return this.vCZoneAnnouncement_A21515.UIName;
			}
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x0600038C RID: 908 RVA: 0x0003FFA4 File Offset: 0x0003E1A4
		// (set) Token: 0x0600038D RID: 909 RVA: 0x00040058 File Offset: 0x0003E258
		internal bool VCZoneAnnouncement_A21515_HiddenStatic
		{
			get
			{
				short num = (short)1991969950;
				short num2 = num;
				num = (short)911412382;
				switch (num2 == num)
				{
				}
				num = (short)660275201;
				if (num != 0)
				{
				}
				num = (short)1637154816;
				if (num != 0)
				{
				}
				num = (short)485490688;
				short num3 = num;
				return this.vCZoneAnnouncement_A21515.HiddenStatic;
			}
			set
			{
				short num = (short)386999745;
				short num2 = num;
				num = (short)426059201;
				switch (num2 == num)
				{
				}
				num = (short)120717312;
				if (num != 0)
				{
				}
				num = (short)1463746561;
				if (num != 0)
				{
				}
				num = (short)928972800;
				short num3 = num;
				this.vCZoneAnnouncement_A21515.HiddenStatic = value;
			}
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x0600038E RID: 910 RVA: 0x0004010C File Offset: 0x0003E30C
		// (set) Token: 0x0600038F RID: 911 RVA: 0x000401C0 File Offset: 0x0003E3C0
		internal bool VCZoneAnnouncement_A21515_HiddenDynamic
		{
			get
			{
				short num = (short)1619959533;
				short num2 = num;
				num = (short)1424072429;
				switch (num2 == num)
				{
				}
				num = (short)342491137;
				if (num != 0)
				{
				}
				num = (short)1135738880;
				if (num != 0)
				{
				}
				num = (short)1656029184;
				short num3 = num;
				return this.vCZoneAnnouncement_A21515.HiddenDynamic;
			}
			set
			{
				short num = (short)1051823722;
				short num2 = num;
				num = (short)542346858;
				switch (num2 == num)
				{
				}
				num = (short)2104360961;
				if (num != 0)
				{
				}
				num = (short)853409792;
				if (num != 0)
				{
				}
				num = (short)1625554944;
				short num3 = num;
				this.vCZoneAnnouncement_A21515.HiddenDynamic = value;
			}
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x06000390 RID: 912 RVA: 0x00040278 File Offset: 0x0003E478
		public bool VCZoneAnnouncement_A21515_HasDiffs
		{
			get
			{
				short num = (short)1223229441;
				if (num != 0)
				{
				}
				num = (short)1216930915;
				short num2 = num;
				num = (short)100459619;
				switch (num2 == num)
				{
				}
				num = (short)1094647808;
				if (num != 0)
				{
				}
				num = (short)518914048;
				short num3 = num;
				return this.vCZoneAnnouncement_A21515._HasDiffs;
			}
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x06000391 RID: 913 RVA: 0x0004032C File Offset: 0x0003E52C
		// (set) Token: 0x06000392 RID: 914 RVA: 0x000403E0 File Offset: 0x0003E5E0
		public bool ZnChanCfgZoneDynamicZoneEnable_A41257Value
		{
			get
			{
				short num = (short)1261240321;
				if (num != 0)
				{
				}
				num = (short)1825064492;
				short num2 = num;
				num = (short)55002668;
				switch (num2 == num)
				{
				}
				num = (short)1271463936;
				if (num != 0)
				{
				}
				num = (short)2000814080;
				short num3 = num;
				return this.znChanCfgZoneDynamicZoneEnable_A41257.Value;
			}
			set
			{
				short num = (short)1835859969;
				if (num != 0)
				{
				}
				num = (short)118574588;
				short num2 = num;
				num = (short)1535856124;
				switch (num2 == num)
				{
				}
				num = (short)1710751744;
				if (num != 0)
				{
				}
				num = (short)100139008;
				short num3 = num;
				this.znChanCfgZoneDynamicZoneEnable_A41257.Value = value;
			}
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x06000393 RID: 915 RVA: 0x00040494 File Offset: 0x0003E694
		public global::AcpBusinessLayer.AcpField<bool> ZnChanCfgZoneDynamicZoneEnable_A41257
		{
			get
			{
				short num = (short)547225601;
				if (num != 0)
				{
				}
				num = (short)508257398;
				short num2 = num;
				num = (short)1132029046;
				switch (num2 == num)
				{
				}
				num = (short)1660813312;
				if (num != 0)
				{
				}
				num = (short)1871577088;
				short num3 = num;
				return this.znChanCfgZoneDynamicZoneEnable_A41257;
			}
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x06000394 RID: 916 RVA: 0x00040544 File Offset: 0x0003E744
		// (set) Token: 0x06000395 RID: 917 RVA: 0x000405F8 File Offset: 0x0003E7F8
		public bool ZnChanCfgZoneDynamicZoneEnable_A41257_UIValue
		{
			get
			{
				short num = (short)143130625;
				if (num != 0)
				{
				}
				num = (short)440118947;
				short num2 = num;
				num = (short)1948429987;
				switch (num2 == num)
				{
				}
				num = (short)387907584;
				if (num != 0)
				{
				}
				num = (short)842203136;
				short num3 = num;
				return this.znChanCfgZoneDynamicZoneEnable_A41257.Value;
			}
			set
			{
				short num = (short)2137727723;
				short num2 = num;
				num = (short)31990507;
				switch (num2 == num)
				{
				}
				num = (short)38666240;
				if (num != 0)
				{
				}
				num = (short)1349976065;
				if (num != 0)
				{
				}
				num = (short)1591934976;
				short num3 = num;
				this.znChanCfgZoneDynamicZoneEnable_A41257.Value = value;
			}
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x06000396 RID: 918 RVA: 0x000406B0 File Offset: 0x0003E8B0
		// (set) Token: 0x06000397 RID: 919 RVA: 0x00040768 File Offset: 0x0003E968
		public bool ZnChanCfgZoneDynamicZoneEnable_A41257_Applicable
		{
			get
			{
				short num = (short)537727890;
				short num2 = num;
				num = (short)1652233106;
				switch (num2 == num)
				{
				}
				num = (short)456916992;
				if (num != 0)
				{
				}
				num = (short)1333264385;
				if (num != 0)
				{
				}
				num = (short)1212219392;
				short num3 = num;
				return this.znChanCfgZoneDynamicZoneEnable_A41257.Applicable;
			}
			set
			{
				short num = (short)142016513;
				if (num != 0)
				{
				}
				num = (short)1970818657;
				short num2 = num;
				num = (short)1980190305;
				switch (num2 == num)
				{
				}
				num = (short)104202240;
				if (num != 0)
				{
				}
				num = (short)250609664;
				short num3 = num;
				this.znChanCfgZoneDynamicZoneEnable_A41257.Applicable = value;
			}
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x06000398 RID: 920 RVA: 0x00040820 File Offset: 0x0003EA20
		// (set) Token: 0x06000399 RID: 921 RVA: 0x000408D4 File Offset: 0x0003EAD4
		public bool ZnChanCfgZoneDynamicZoneEnable_A41257_Valid
		{
			get
			{
				short num = (short)1538531100;
				short num2 = num;
				num = (short)1640308508;
				switch (num2 == num)
				{
				}
				num = (short)655163393;
				if (num != 0)
				{
				}
				num = (short)1479147520;
				if (num != 0)
				{
				}
				num = (short)907083776;
				short num3 = num;
				return this.znChanCfgZoneDynamicZoneEnable_A41257.Valid;
			}
			set
			{
				short num = (short)926253844;
				short num2 = num;
				num = (short)1119453972;
				switch (num2 == num)
				{
				}
				num = (short)253820929;
				if (num != 0)
				{
				}
				num = (short)43581440;
				if (num != 0)
				{
				}
				num = (short)230555648;
				short num3 = num;
				this.znChanCfgZoneDynamicZoneEnable_A41257.Valid = value;
			}
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x0600039A RID: 922 RVA: 0x00040988 File Offset: 0x0003EB88
		// (set) Token: 0x0600039B RID: 923 RVA: 0x00040A3C File Offset: 0x0003EC3C
		public bool ZnChanCfgZoneDynamicZoneEnable_A41257_Visible
		{
			get
			{
				short num = (short)1249605384;
				short num2 = num;
				num = (short)1721857800;
				switch (num2 == num)
				{
				}
				num = (short)225705985;
				if (num != 0)
				{
				}
				num = (short)859111424;
				if (num != 0)
				{
				}
				num = (short)1391591424;
				short num3 = num;
				return this.znChanCfgZoneDynamicZoneEnable_A41257.Visible;
			}
			set
			{
				short num = (short)862388225;
				if (num != 0)
				{
				}
				num = (short)2009238169;
				short num2 = num;
				num = (short)1787005593;
				switch (num2 == num)
				{
				}
				num = (short)861405184;
				if (num != 0)
				{
				}
				num = (short)1426128896;
				short num3 = num;
				this.znChanCfgZoneDynamicZoneEnable_A41257.Visible = value;
			}
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x0600039C RID: 924 RVA: 0x00040AF0 File Offset: 0x0003ECF0
		// (set) Token: 0x0600039D RID: 925 RVA: 0x00040BA4 File Offset: 0x0003EDA4
		public bool ZnChanCfgZoneDynamicZoneEnable_A41257_Editable
		{
			get
			{
				short num = (short)1807392335;
				short num2 = num;
				num = (short)654286415;
				switch (num2 == num)
				{
				}
				num = (short)1131151360;
				if (num != 0)
				{
				}
				num = (short)640352257;
				if (num != 0)
				{
				}
				num = (short)1028521984;
				short num3 = num;
				return this.znChanCfgZoneDynamicZoneEnable_A41257.Editable;
			}
			set
			{
				short num = (short)1580990465;
				if (num != 0)
				{
				}
				num = (short)1226822160;
				short num2 = num;
				num = (short)634638864;
				switch (num2 == num)
				{
				}
				num = (short)1211695104;
				if (num != 0)
				{
				}
				num = (short)162594816;
				short num3 = num;
				this.znChanCfgZoneDynamicZoneEnable_A41257.Editable = value;
			}
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x0600039E RID: 926 RVA: 0x00040C58 File Offset: 0x0003EE58
		internal string ZnChanCfgZoneDynamicZoneEnable_A41257_UILabel
		{
			get
			{
				short num = (short)2102034558;
				short num2 = num;
				num = (short)2071756926;
				switch (num2 == num)
				{
				}
				num = (short)1601175552;
				if (num != 0)
				{
				}
				num = (short)2028273665;
				if (num != 0)
				{
				}
				num = (short)525991936;
				short num3 = num;
				return this.znChanCfgZoneDynamicZoneEnable_A41257.UIName;
			}
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x0600039F RID: 927 RVA: 0x00040D0C File Offset: 0x0003EF0C
		// (set) Token: 0x060003A0 RID: 928 RVA: 0x00040DC0 File Offset: 0x0003EFC0
		internal bool ZnChanCfgZoneDynamicZoneEnable_A41257_HiddenStatic
		{
			get
			{
				short num = (short)1945855439;
				short num2 = num;
				num = (short)1439851983;
				switch (num2 == num)
				{
				}
				num = (short)1528102912;
				if (num != 0)
				{
				}
				num = (short)1876623361;
				if (num != 0)
				{
				}
				num = (short)1264189440;
				short num3 = num;
				return this.znChanCfgZoneDynamicZoneEnable_A41257.HiddenStatic;
			}
			set
			{
				short num = (short)1993540209;
				short num2 = num;
				num = (short)460128881;
				switch (num2 == num)
				{
				}
				num = (short)1559429120;
				if (num != 0)
				{
				}
				num = (short)460587009;
				if (num != 0)
				{
				}
				num = (short)1037631488;
				short num3 = num;
				this.znChanCfgZoneDynamicZoneEnable_A41257.HiddenStatic = value;
			}
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x060003A1 RID: 929 RVA: 0x00040E74 File Offset: 0x0003F074
		// (set) Token: 0x060003A2 RID: 930 RVA: 0x00040F28 File Offset: 0x0003F128
		internal bool ZnChanCfgZoneDynamicZoneEnable_A41257_HiddenDynamic
		{
			get
			{
				short num = (short)1974237523;
				short num2 = num;
				num = (short)1481406803;
				switch (num2 == num)
				{
				}
				num = (short)1406271489;
				if (num != 0)
				{
				}
				num = (short)195428352;
				if (num != 0)
				{
				}
				num = (short)126418944;
				short num3 = num;
				return this.znChanCfgZoneDynamicZoneEnable_A41257.HiddenDynamic;
			}
			set
			{
				short num = (short)224522151;
				short num2 = num;
				num = (short)1280896935;
				switch (num2 == num)
				{
				}
				num = (short)426704897;
				if (num != 0)
				{
				}
				num = (short)781713408;
				if (num != 0)
				{
				}
				num = (short)100925440;
				short num3 = num;
				this.znChanCfgZoneDynamicZoneEnable_A41257.HiddenDynamic = value;
			}
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x060003A3 RID: 931 RVA: 0x00040FE0 File Offset: 0x0003F1E0
		public bool ZnChanCfgZoneDynamicZoneEnable_A41257_HasDiffs
		{
			get
			{
				short num = (short)2118080238;
				short num2 = num;
				num = (short)1195661038;
				switch (num2 == num)
				{
				}
				num = (short)1211826176;
				if (num != 0)
				{
				}
				num = (short)830537729;
				if (num != 0)
				{
				}
				num = (short)255852544;
				short num3 = num;
				return this.znChanCfgZoneDynamicZoneEnable_A41257._HasDiffs;
			}
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x060003A4 RID: 932 RVA: 0x00041094 File Offset: 0x0003F294
		// (set) Token: 0x060003A5 RID: 933 RVA: 0x00041148 File Offset: 0x0003F348
		public bool ZnChanCfgZoneZoneCloningEnable_43119Value
		{
			get
			{
				short num = (short)954461788;
				short num2 = num;
				num = (short)928378460;
				switch (num2 == num)
				{
				}
				num = (short)1531772929;
				if (num != 0)
				{
				}
				num = (short)1846870016;
				if (num != 0)
				{
				}
				num = (short)2036727808;
				short num3 = num;
				return this.znChanCfgZoneZoneCloningEnable_43119.Value;
			}
			set
			{
				short num = (short)1839164246;
				short num2 = num;
				num = (short)1757965142;
				switch (num2 == num)
				{
				}
				num = (short)1398669313;
				if (num != 0)
				{
				}
				num = (short)1629093888;
				if (num != 0)
				{
				}
				num = (short)428081152;
				short num3 = num;
				this.znChanCfgZoneZoneCloningEnable_43119.Value = value;
			}
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x060003A6 RID: 934 RVA: 0x000411FC File Offset: 0x0003F3FC
		public global::AcpBusinessLayer.AcpField<bool> ZnChanCfgZoneZoneCloningEnable_43119
		{
			get
			{
				short num = (short)1738211329;
				if (num != 0)
				{
				}
				num = (short)1030397736;
				short num2 = num;
				num = (short)1594400552;
				switch (num2 == num)
				{
				}
				num = (short)1650262016;
				if (num != 0)
				{
				}
				num = (short)1599012864;
				short num3 = num;
				return this.znChanCfgZoneZoneCloningEnable_43119;
			}
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x060003A7 RID: 935 RVA: 0x000412AC File Offset: 0x0003F4AC
		// (set) Token: 0x060003A8 RID: 936 RVA: 0x0004135C File Offset: 0x0003F55C
		public bool ZnChanCfgZoneZoneCloningEnable_43119_UIValue
		{
			get
			{
				short num = (short)2037383169;
				if (num != 0)
				{
				}
				num = (short)1153203727;
				short num2 = num;
				num = (short)234651151;
				switch (num2 == num)
				{
				}
				num = (short)399704064;
				if (num != 0)
				{
				}
				num = (short)1839792128;
				short num3 = num;
				return this.znChanCfgZoneZoneCloningEnable_43119.Value;
			}
			set
			{
				short num = (short)1813315585;
				if (num != 0)
				{
				}
				num = (short)1788998831;
				short num2 = num;
				num = (short)2086401199;
				switch (num2 == num)
				{
				}
				num = (short)2145714176;
				if (num != 0)
				{
				}
				num = (short)1209466880;
				short num3 = num;
				this.znChanCfgZoneZoneCloningEnable_43119.Value = value;
			}
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x060003A9 RID: 937 RVA: 0x00041410 File Offset: 0x0003F610
		// (set) Token: 0x060003AA RID: 938 RVA: 0x000414C8 File Offset: 0x0003F6C8
		public bool ZnChanCfgZoneZoneCloningEnable_43119_Applicable
		{
			get
			{
				short num = (short)1272418404;
				short num2 = num;
				num = (short)225087588;
				switch (num2 == num)
				{
				}
				num = (short)385613825;
				if (num != 0)
				{
				}
				num = (short)1506213888;
				if (num != 0)
				{
				}
				num = (short)1686962176;
				short num3 = num;
				return this.znChanCfgZoneZoneCloningEnable_43119.Applicable;
			}
			set
			{
				short num = (short)44849736;
				short num2 = num;
				num = (short)1669225032;
				switch (num2 == num)
				{
				}
				num = (short)1105657857;
				if (num != 0)
				{
				}
				num = (short)2117861376;
				if (num != 0)
				{
				}
				num = (short)1471414272;
				short num3 = num;
				this.znChanCfgZoneZoneCloningEnable_43119.Applicable = value;
			}
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x060003AB RID: 939 RVA: 0x00041580 File Offset: 0x0003F780
		// (set) Token: 0x060003AC RID: 940 RVA: 0x00041634 File Offset: 0x0003F834
		public bool ZnChanCfgZoneZoneCloningEnable_43119_Valid
		{
			get
			{
				short num = (short)2027646299;
				short num2 = num;
				num = (short)273313115;
				switch (num2 == num)
				{
				}
				num = (short)588644353;
				if (num != 0)
				{
				}
				num = (short)1575813120;
				if (num != 0)
				{
				}
				num = (short)2067988480;
				short num3 = num;
				return this.znChanCfgZoneZoneCloningEnable_43119.Valid;
			}
			set
			{
				short num = (short)293648721;
				short num2 = num;
				num = (short)1496824145;
				switch (num2 == num)
				{
				}
				num = (short)274792449;
				if (num != 0)
				{
				}
				num = (short)1929773056;
				if (num != 0)
				{
				}
				num = (short)1841627136;
				short num3 = num;
				this.znChanCfgZoneZoneCloningEnable_43119.Valid = value;
			}
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x060003AD RID: 941 RVA: 0x000416EC File Offset: 0x0003F8EC
		// (set) Token: 0x060003AE RID: 942 RVA: 0x000417A0 File Offset: 0x0003F9A0
		public bool ZnChanCfgZoneZoneCloningEnable_43119_Visible
		{
			get
			{
				short num = (short)74169763;
				short num2 = num;
				num = (short)1426898339;
				switch (num2 == num)
				{
				}
				num = (short)235536385;
				if (num != 0)
				{
				}
				num = (short)624689152;
				if (num != 0)
				{
				}
				num = (short)2005139456;
				short num3 = num;
				return this.znChanCfgZoneZoneCloningEnable_43119.Visible;
			}
			set
			{
				short num = (short)949042156;
				short num2 = num;
				num = (short)10828780;
				switch (num2 == num)
				{
				}
				num = (short)293142528;
				if (num != 0)
				{
				}
				num = (short)2099249153;
				if (num != 0)
				{
				}
				num = (short)922550272;
				short num3 = num;
				this.znChanCfgZoneZoneCloningEnable_43119.Visible = value;
			}
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x060003AF RID: 943 RVA: 0x00041854 File Offset: 0x0003FA54
		// (set) Token: 0x060003B0 RID: 944 RVA: 0x0004190C File Offset: 0x0003FB0C
		public bool ZnChanCfgZoneZoneCloningEnable_43119_Editable
		{
			get
			{
				short num = (short)624342315;
				short num2 = num;
				num = (short)208647467;
				switch (num2 == num)
				{
				}
				num = (short)1793785857;
				if (num != 0)
				{
				}
				num = (short)85721088;
				if (num != 0)
				{
				}
				num = (short)1359937536;
				short num3 = num;
				return this.znChanCfgZoneZoneCloningEnable_43119.Editable;
			}
			set
			{
				short num = (short)775961057;
				short num2 = num;
				num = (short)2118859233;
				switch (num2 == num)
				{
				}
				num = (short)1897398273;
				if (num != 0)
				{
				}
				num = (short)1994260480;
				if (num != 0)
				{
				}
				num = (short)1706426368;
				short num3 = num;
				this.znChanCfgZoneZoneCloningEnable_43119.Editable = value;
			}
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x060003B1 RID: 945 RVA: 0x000419C0 File Offset: 0x0003FBC0
		internal string ZnChanCfgZoneZoneCloningEnable_43119_UILabel
		{
			get
			{
				short num = (short)1787232257;
				if (num != 0)
				{
				}
				num = (short)832453829;
				short num2 = num;
				num = (short)1287601349;
				switch (num2 == num)
				{
				}
				num = (short)263323648;
				if (num != 0)
				{
				}
				num = (short)1493237760;
				short num3 = num;
				return this.znChanCfgZoneZoneCloningEnable_43119.UIName;
			}
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x060003B2 RID: 946 RVA: 0x00041A78 File Offset: 0x0003FC78
		// (set) Token: 0x060003B3 RID: 947 RVA: 0x00041B2C File Offset: 0x0003FD2C
		internal bool ZnChanCfgZoneZoneCloningEnable_43119_HiddenStatic
		{
			get
			{
				short num = (short)1248711779;
				short num2 = num;
				num = (short)1300354147;
				switch (num2 == num)
				{
				}
				num = (short)29556736;
				if (num != 0)
				{
				}
				num = (short)1583546369;
				if (num != 0)
				{
				}
				num = (short)586416128;
				short num3 = num;
				return this.znChanCfgZoneZoneCloningEnable_43119.HiddenStatic;
			}
			set
			{
				short num = (short)337009711;
				short num2 = num;
				num = (short)745233455;
				switch (num2 == num)
				{
				}
				num = (short)1807613953;
				if (num != 0)
				{
				}
				num = (short)1858928640;
				if (num != 0)
				{
				}
				num = (short)1766588416;
				short num3 = num;
				this.znChanCfgZoneZoneCloningEnable_43119.HiddenStatic = value;
			}
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x060003B4 RID: 948 RVA: 0x00041BE4 File Offset: 0x0003FDE4
		// (set) Token: 0x060003B5 RID: 949 RVA: 0x00041C98 File Offset: 0x0003FE98
		internal bool ZnChanCfgZoneZoneCloningEnable_43119_HiddenDynamic
		{
			get
			{
				short num = (short)937545261;
				short num2 = num;
				num = (short)658099757;
				switch (num2 == num)
				{
				}
				num = (short)1297743873;
				if (num != 0)
				{
				}
				num = (short)632815616;
				if (num != 0)
				{
				}
				num = (short)109576192;
				short num3 = num;
				return this.znChanCfgZoneZoneCloningEnable_43119.HiddenDynamic;
			}
			set
			{
				short num = (short)736755713;
				if (num != 0)
				{
				}
				num = (short)2046649379;
				short num2 = num;
				num = (short)221078563;
				switch (num2 == num)
				{
				}
				num = (short)1772683264;
				if (num != 0)
				{
				}
				num = (short)1509228544;
				short num3 = num;
				this.znChanCfgZoneZoneCloningEnable_43119.HiddenDynamic = value;
			}
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x060003B6 RID: 950 RVA: 0x00041D50 File Offset: 0x0003FF50
		public bool ZnChanCfgZoneZoneCloningEnable_43119_HasDiffs
		{
			get
			{
				short num = (short)1650802991;
				short num2 = num;
				num = (short)1487028527;
				switch (num2 == num)
				{
				}
				num = (short)842072064;
				if (num != 0)
				{
				}
				num = (short)1118830593;
				if (num != 0)
				{
				}
				num = (short)1495334912;
				short num3 = num;
				return this.znChanCfgZoneZoneCloningEnable_43119._HasDiffs;
			}
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x060003B7 RID: 951 RVA: 0x00041E04 File Offset: 0x00040004
		public global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.DisplayAndMenu RefDisplayAndMenu
		{
			get
			{
				short num = (short)851312641;
				if (num != 0)
				{
				}
				num = (short)820366661;
				short num2 = num;
				num = (short)1303760197;
				switch (num2 == num)
				{
				}
				num = (short)1670119424;
				if (num != 0)
				{
				}
				num = (short)1112866816;
				short num3 = num;
				return global::AcpCommonLib.FeatureManager.GetFeature(2010)[0] as global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.DisplayAndMenu;
			}
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x060003B8 RID: 952 RVA: 0x00041EC4 File Offset: 0x000400C4
		public global::Motorola.MackinawCPS.CoreFeatures.DVRSWide.DVRSWide RefDVRSWide
		{
			get
			{
				short num = (short)405274625;
				if (num != 0)
				{
				}
				num = (short)1819714179;
				short num2 = num;
				num = (short)208642691;
				switch (num2 == num)
				{
				}
				num = (short)127205376;
				if (num != 0)
				{
				}
				num = (short)1147994112;
				short num3 = num;
				return global::AcpCommonLib.FeatureManager.GetFeature(4142)[0] as global::Motorola.MackinawCPS.CoreFeatures.DVRSWide.DVRSWide;
			}
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x060003B9 RID: 953 RVA: 0x00041F84 File Offset: 0x00040184
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide RefRadioWide
		{
			get
			{
				short num = (short)651093127;
				short num2 = num;
				num = (short)1089922183;
				switch (num2 == num)
				{
				}
				num = (short)58064897;
				if (num != 0)
				{
				}
				num = (short)847642624;
				if (num != 0)
				{
				}
				num = (short)1304100864;
				short num3 = num;
				return global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
			}
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x060003BA RID: 954 RVA: 0x00042044 File Offset: 0x00040244
		public string TTSTargetSpeaker
		{
			get
			{
				short num = (short)1445722786;
				short num2 = num;
				num = (short)353434274;
				switch (num2 == num)
				{
				}
				num = (short)40697856;
				if (num != 0)
				{
				}
				num = (short)315490305;
				if (num != 0)
				{
				}
				num = (short)948961280;
				short num3 = num;
				return global::Features.Radio_Ergonomics_Configuration.Display_and_Menu.TtsSpeaker.TargetSpeaker;
			}
		}

		// Token: 0x060003BB RID: 955 RVA: 0x000420F4 File Offset: 0x000402F4
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
					num2 = (short)1413939203;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					for (;;)
					{
						result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
						num2 = (short)674823331;
						short num3 = num2;
						num2 = (short)550567075;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_A2;
						}
					}
					IL_A2:
					num2 = (short)454361088;
					if (num2 != 0)
					{
					}
					num2 = (short)1331429378;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_D0;
				case 3:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)1596194817;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_115;
				case 4:
					if (base.ParentRecset != null)
					{
						num2 = (short)358940672;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_115;
				}
				goto IL_24;
			}
			IL_D0:
			IL_115:
			num2 = (short)1723596800;
			short num4 = num2;
			num2 = (short)1504968705;
			if (num2 != 0)
			{
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)1787822084;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060003BC RID: 956 RVA: 0x00042268 File Offset: 0x00040468
		private void b()
		{
			short num = (short)1763281548;
			short num2 = num;
			num = (short)1765706380;
			switch (num2 == num)
			{
			default:
			{
				num = (short)837812224;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1188823041;
			if (num != 0)
			{
			}
			num = (short)217120768;
			if (num != 0)
			{
			}
			this.a();
		}

		// Token: 0x060003BD RID: 957 RVA: 0x00042318 File Offset: 0x00040518
		private void a()
		{
			short num = (short)1633042074;
			short num2 = num;
			num = (short)199245466;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1396834304;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1528037376;
			if (num != 0)
			{
			}
			num = (short)887029761;
			if (num != 0)
			{
			}
			base.PropertyChanged += global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.Zone.OnDynamicZoneEnable_PropertyChangedHandle;
			base.PropertyChanged += global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.Zone.OnZoneCloneEnable_PropertyChangeHandle;
		}

		// Token: 0x060003BE RID: 958 RVA: 0x000423E4 File Offset: 0x000405E4
		public static void OnDynamicZoneEnable_PropertyChangedHandle(object section, global::System.ComponentModel.PropertyChangedEventArgs label)
		{
			int a_ = 1;
			short num;
			try
			{
				num = (short)505937924;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment;
					switch (num2)
					{
					case 0:
						zoneChannelAssignment = ((section as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.Zone).Parent as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment);
						num = (short)112721921;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						if (zoneChannelAssignment == null)
						{
							num = (short)625934346;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1111599172;
						short num3 = num;
						num = (short)954968132;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_C8;
						default:
						{
							num = (short)1304625152;
							if (num != 0)
							{
							}
							global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerRecset channelAssignmentListInnerRecset = zoneChannelAssignment.Channels.EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerRecset;
							num = (short)82903047;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 2:
						goto IL_2C1;
					case 3:
						num = (short)786956297;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						switch (0)
						{
						case 0:
							goto IL_72;
						}
						continue;
					case 5:
						goto IL_2BF;
					case 6:
						goto IL_2D8;
					case 7:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerRecset channelAssignmentListInnerRecset;
						if (channelAssignmentListInnerRecset != null)
						{
							num = (short)1129906191;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B8;
					}
					case 8:
						if (zoneChannelAssignment != null)
						{
							num = (short)1934688270;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1EF;
					case 9:
						if (label.PropertyName == global::AllFeatures.CodeplugGuid.b("飁꫃藅ꃇꯉꋋ跍뛏뗑軓맕뛗뿙飛꟝軟菡解迥诧냩菫胭闯럱髳韵髷雹駻ꇽ䇿㘁㔃㐅㴇㴉娋漍簏朑焓", a_))
						{
							num = (short)1034223616;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2C1;
					case 10:
						num = (short)492961797;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						goto IL_C8;
					case 12:
						goto IL_1EF;
					case 13:
						goto IL_1B8;
					case 14:
						num = (short)176357392;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerRecset channelAssignmentListInnerRecset;
						channelAssignmentListInnerRecset.RefreshRecordsetToolBarNonACPMethod();
						num = (short)1182203917;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
						if (zoneChannelAssignment.Parent != null)
						{
							num = (short)1594687499;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1EF;
					}
					IL_72:
					if (section != null)
					{
						num = (short)1520566275;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2C1;
					IL_C8:
					(zoneChannelAssignment.Parent as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentRecset).RefreshRecordsetToolBarNonACPMethod();
					num = (short)1658781708;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1B8:
					num = (short)1067319304;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1EF:
					global::ConstraintHelper.AppMultiInstanceManager.IsDynamicZoneChanged = true;
					num = (short)1328349186;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2C1:
					num = (short)1772093446;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_2BF:
				IL_2D8:;
			}
			catch (global::System.Exception)
			{
			}
			num = (short)1965293569;
			if (num != 0)
			{
			}
			num = (short)2088108032;
			short num4 = num;
		}

		// Token: 0x060003BF RID: 959 RVA: 0x0004273C File Offset: 0x0004093C
		public static void OnZoneCloneEnable_PropertyChangeHandle(object section, global::System.ComponentModel.PropertyChangedEventArgs label)
		{
			int a_ = 5;
			short num;
			try
			{
				num = (short)90898432;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)1041102699;
					short num3 = num;
					num = (short)1055061867;
					global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1893138432;
						if (num != 0)
						{
						}
						switch (num2)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_A0;
							}
							continue;
						case 1:
							num = (short)1316552705;
							if (num != 0)
							{
							}
							if (zoneChannelAssignment != null)
							{
								num = (short)706609154;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1EA;
						case 2:
							num = (short)129302534;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							goto IL_1BB;
						case 4:
							goto IL_202;
						case 5:
							(zoneChannelAssignment.Parent as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentRecset).RefreshRecordsetToolBarNonACPMethod();
							num = (short)1530527752;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							if (zoneChannelAssignment.Parent != null)
							{
								num = (short)2058485765;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1EA;
						case 7:
							if (label.PropertyName == global::AllFeatures.CodeplugGuid.b("鳅ꛇ觉꓋꿍뻏金닓뇕苗뗙닛믝뫟跡諣菥ꯧ蛩菫胭駯鳱鏳돵雷鯹黻鋽旿崁〃㔅㤇㬉㔋堍焏縑愓猕", a_))
							{
								num = (short)1222639619;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1EA;
						case 8:
							goto IL_1EA;
						case 9:
							num = (short)1286471687;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_A0:
						if (section != null)
						{
							num = (short)945684489;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_1EA:
						num = (short)587857924;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_1BB:
					zoneChannelAssignment = ((section as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.Zone).Parent as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment);
					num = (short)1806303233;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_202:;
			}
			catch (global::System.Exception)
			{
			}
			num = (short)2103705600;
			short num4 = num;
		}

		// Token: 0x040000C2 RID: 194
		public const int TTS_INDEX = 65535;

		// Token: 0x040000C3 RID: 195
		private global::AcpBusinessLayer.AcpKeyField znChanCfgZoneZoneName_A9724;

		// Token: 0x040000C4 RID: 196
		private global::AcpBusinessLayer.AcpField<string> znChanCfgZoneTopDisplayZone_A19772;

		// Token: 0x040000C5 RID: 197
		private global::AcpBusinessLayer.AcpRecRefField zoneVoiceAnnouncementID_A21514;

		// Token: 0x040000C6 RID: 198
		private global::AcpBusinessLayer.AcpField<string> vCZoneAnnouncement_A21515;

		// Token: 0x040000C7 RID: 199
		private global::AcpBusinessLayer.AcpField<bool> znChanCfgZoneDynamicZoneEnable_A41257;

		// Token: 0x040000C8 RID: 200
		private global::AcpBusinessLayer.AcpField<bool> znChanCfgZoneZoneCloningEnable_43119;
	}
}
