using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using Motorola.MackinawCPS.CoreFeatures.DVRSWide;
using Motorola.MackinawCPS.CoreFeatures.TrunkingWide;

namespace Motorola.MackinawCPS.CoreFeatures.TrunkingSystem
{
	// Token: 0x02000067 RID: 103
	[global::System.Serializable]
	public class ASTRO26 : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06000906 RID: 2310 RVA: 0x0008973C File Offset: 0x0008793C
		public ASTRO26(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06000907 RID: 2311 RVA: 0x00089758 File Offset: 0x00087958
		protected ASTRO26(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06000908 RID: 2312 RVA: 0x00089770 File Offset: 0x00087970
		public override void Init()
		{
			int a_ = 7;
			short num = (short)147845294;
			short num2 = num;
			num = (short)1762259118;
			switch (num2 == num)
			{
			}
			num = (short)818216960;
			if (num != 0)
			{
			}
			num = (short)533069824;
			short num3 = num;
			num = (short)1354170369;
			if (num != 0)
			{
			}
			this.trkSysASTRO25EndF2TDMATransmitOnOutOfRange_A1394 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鳇룉Ɤ鷍ꧏꇑ闓藕賗裙鏛헟꟡諣若껧\ud8e9룫ꫭ뷯돱ꃳ蓵駷铹迻鏽槿瘁䬃栅䜇缉砋䄍瘏䀑甓砕缗缙䌛弝ᄟᄡᴣሥ", a_), global::CommonResources.AcgResources.ID_ENDX2TDMATRANSMITONOUTOFRANGE);
			this.trkSysASTRO25EndF2TDMATransmitOnOutOfRange_A1394.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Depot;
			this.trkSysASTRO25EndF2TDMATransmitOnOutOfRange_A1394.DataTransferOrder = 50;
			this.trkSysASTRO25F2VoiceCapable_A1395 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鳇룉Ɤ鷍ꧏꇑ闓藕賗裙鏛헟ꓡ훣냥蟧菩迫语돯鏱蓳韵髷雹駻ꇽ䇿㌁㜃㼅㴇", a_), global::CommonResources.AcgResources.ID_X2VOICECAPABLE);
			this.trkSysASTRO25F2VoiceCapable_A1395.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.trkSysASTRO25F2VoiceCapable_A1395.DataTransferOrder = 4;
			this.trkSysASTRO25BusyUpdateTimesec_A7574 = new global::AcpBusinessLayer.AcpSimpleRangeField(2, this, global::AllFeatures.CodeplugGuid.b("鳇룉Ɤ鷍ꧏꇑ闓藕賗裙鏛헟ꃡ釣闥釧뿩鳫諭釯蛱釳ꋵ釷韹駻跽旿愁嬃䜅㼇㼉㬋㨍", a_), global::CommonResources.AcgResources.ID_BUSYUPDATETIMESEC, 0, 63, global::CommonResources.AcgResources.ID_INFINITE, null, 0, 15);
			this.trkSysASTRO25BusyUpdateTimesec_A7574.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.trkSysASTRO25BusyUpdateTimesec_A7574.DataTransferOrder = 51;
			this.trkSysASTRO25BusyUpdateTimesec_A7574.ShowHexValue = false;
			this.trkSysASTRO25DefaultRCMAddress_A7813 = new global::AcpBusinessLayer.AcpSimpleRangeField(16777212, this, global::AllFeatures.CodeplugGuid.b("鳇룉Ɤ鷍ꧏꇑ闓藕賗裙鏛헟ꛡ臣胥觧鿩胫髭ꋯ뇱맳럵鳷黹軻鯽珿焁嬃䜅㼇㈉㴋㴍", a_), global::CommonResources.AcgResources.ID_DEFAULTRCMID, 0, 16777215, null, null, 0, 1);
			this.trkSysASTRO25DefaultRCMAddress_A7813.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkSysASTRO25DefaultRCMAddress_A7813.DataTransferOrder = 55;
			this.trkSysASTRO25DefaultRCMAddress_A7813.ShowHexValue = true;
			this.trkSysASTRO25ForceUnmuteTimems_A8141 = new global::AcpBusinessLayer.AcpSimpleRangeField(48, this, global::AllFeatures.CodeplugGuid.b("鳇룉Ɤ鷍ꧏꇑ闓藕賗裙鏛헟ꓡ诣铥诧迩맫胭鷯蟱胳鏵곷鏹釻鯽淿焁嬃䜅〇㬉㠋㼍", a_), global::CommonResources.AcgResources.ID_FORCEUNMUTETIMEMS, 0, 255, global::CommonResources.AcgResources.ID_IMMEDIATE, null, 0, 25);
			this.trkSysASTRO25ForceUnmuteTimems_A8141.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.trkSysASTRO25ForceUnmuteTimems_A8141.DataTransferOrder = 58;
			this.trkSysASTRO25ForceUnmuteTimems_A8141.ShowHexValue = false;
			this.trkSysASTRO25ISPSequenceLengthsec_A8354 = new global::AcpBusinessLayer.AcpSimpleRangeField(5, this, global::AllFeatures.CodeplugGuid.b("鳇룉Ɤ鷍ꧏꇑ闓藕賗裙鏛헟ꯡ럣뛥믧迩鷫鯭闯鳱音鏵듷鿹鋻駽瓿樁眃挅欇唉䴋㘍⌏✑–", a_), global::CommonResources.AcgResources.ID_ISPSEQUENCELENGTHSEC, 0, 255, global::CommonResources.AcgResources.ID_INFINITE, null, 0, 1);
			this.trkSysASTRO25ISPSequenceLengthsec_A8354.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.trkSysASTRO25ISPSequenceLengthsec_A8354.DataTransferOrder = 65;
			this.trkSysASTRO25ISPSequenceLengthsec_A8354.ShowHexValue = false;
			this.trkSysASTRO25MaximumSlotSizems_A8478 = new global::AcpBusinessLayer.AcpCustomRangeField(1, new global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.UnpackAndpackRangeValueToLogicalIndexForMaxSlotSize(), this, global::AllFeatures.CodeplugGuid.b("鳇룉Ɤ鷍ꧏꇑ闓藕賗裙鏛헟꿡藣黥臧蟩駫菭ꏯ黱鯳苵꯷鏹蛻鯽淿焁嬃䜅〇㸉㬋㘍", a_), global::CommonResources.AcgResources.ID_MAXIMUMSLOTSIZEMS, 0, 15, 1, null, global::CommonResources.AcgResources.ID_UNBOUNDED);
			this.trkSysASTRO25MaximumSlotSizems_A8478.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.trkSysASTRO25MaximumSlotSizems_A8478.DataTransferOrder = 66;
			this.trkSysASTRO25MaximumSlotSizems_A8478.ShowHexValue = false;
			this.trkSysASTRO25MotorolaProprietaryFeatures_A8547 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("鳇룉Ɤ鷍ꧏꇑ闓藕賗裙鏛헟꿡诣鋥蟧飩菫苭釯ꋱ蛳駵裷裹闻鯽瓿持瘃缅万漉洋稍攏怑焓攕䜗嬙␛⬝ᐟᔡ", a_), global::CommonResources.AcgResources.ID_MOTOROLAPROPRIETARYFEATURES);
			this.trkSysASTRO25MotorolaProprietaryFeatures_A8547.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkSysASTRO25MotorolaProprietaryFeatures_A8547.DataTransferOrder = 40;
			this.trkSysASTRO25PTTWarningTimems_A8781 = new global::AcpBusinessLayer.AcpSimpleRangeField(30, this, global::AllFeatures.CodeplugGuid.b("鳇룉Ɤ鷍ꧏꇑ闓藕賗裙鏛헟닡냣닥뿧诩黫胭駯鳱鏳ꋵ釷韹駻鏽珿崁䔃㸅㼇㈉㴋", a_), global::CommonResources.AcgResources.ID_PTTWARNINGTIMEMS, 0, 255, global::CommonResources.AcgResources.ID_DISABLED, null, 0, 25);
			this.trkSysASTRO25PTTWarningTimems_A8781.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.trkSysASTRO25PTTWarningTimems_A8781.DataTransferOrder = 69;
			this.trkSysASTRO25PTTWarningTimems_A8781.ShowHexValue = false;
			this.trkSysASTRO25ResponsePendingTimesec_A8945 = new global::AcpBusinessLayer.AcpSimpleRangeField(6, this, global::AllFeatures.CodeplugGuid.b("鳇룉Ɤ鷍ꧏꇑ闓藕賗裙鏛헟냡臣闥飧藩苫鷭闯ꋱ釳飵鳷鏹鋻駽哿欁椃挅笇漉漋儍儏⨑ⴓ∕ⴗ", a_), global::CommonResources.AcgResources.ID_RESPONSEPENDINGTIMESEC, 0, 255, global::CommonResources.AcgResources.ID_INFINITE, null, 0, 1);
			this.trkSysASTRO25ResponsePendingTimesec_A8945.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.trkSysASTRO25ResponsePendingTimesec_A8945.DataTransferOrder = 71;
			this.trkSysASTRO25ResponsePendingTimesec_A8945.ShowHexValue = false;
			this.trkSysASTRO25ValidateNACAgainstSystemID_A20608 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("鳇룉Ɤ鷍ꧏꇑ闓藕賗裙鏛헟듡藣諥臧軩跫髭闯볱뗳뗵맷鷹鷻韽滿焁瀃唅焇礉砋欍紏嬑倓䤕夗⠙Ⱋ⠝ဟᨡ", a_), global::CommonResources.AcgResources.ID_VALIDATENACAGAINSTSYSTEMID);
			this.trkSysASTRO25ValidateNACAgainstSystemID_A20608.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkSysASTRO25ValidateNACAgainstSystemID_A20608.DataTransferOrder = 48;
			this.trkSysASTRO25Phase2VoiceCapable_A37972 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("鳇룉Ɤ鷍ꧏꇑ闓藕賗裙鏛헟닡賣蟥鯧迩\udeeb룭鿯鯱音鏵믷鯹賻鿽拿渁愃夅䤇㤉㬋㜍✏‑", a_), global::CommonResources.AcgResources.ID_PHASE2VOICECAPABLE);
			this.trkSysASTRO25Phase2VoiceCapable_A37972.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkSysASTRO25Phase2VoiceCapable_A37972.DataTransferOrder = 130;
			this.trkSysASTRO25EndPhase2TDMATransmitOnOutOfRange_A37980 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鳇룉Ɤ鷍ꧏꇑ闓藕賗裙鏛헟꟡諣若룧苩跫鷭闯샱ꃳ답뗷믹ꣻ賽懿氁眃欅愇縉䌋怍式朑怓夕縗䠙紛瀝䜟䜡笣朥ᬧᴩᔫᘭ/", a_), global::CommonResources.AcgResources.ID_ENDPHASE2TDMATRANSMITONOUTOFRANGE);
			this.trkSysASTRO25EndPhase2TDMATransmitOnOutOfRange_A37980.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.trkSysASTRO25EndPhase2TDMATransmitOnOutOfRange_A37980.DataTransferOrder = 131;
			this.trkSysASTRO25QuickFadeProtectms_A8807 = new global::AcpBusinessLayer.AcpSimpleRangeField(12, this, global::AllFeatures.CodeplugGuid.b("鳇룉Ɤ鷍ꧏꇑ闓藕賗裙鏛헟돡釣迥诧臩ꫫ迭铯韱ꓳ蓵韷軹駻鷽瓿漁眃夅䤇㈉㐋㸍✏", a_), global::CommonResources.AcgResources.ID_QUICKFADEPROTECTMS, 8, 255, null, null, 0, 25);
			this.trkSysASTRO25QuickFadeProtectms_A8807.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.trkSysASTRO25QuickFadeProtectms_A8807.DataTransferOrder = 70;
			this.trkSysASTRO25QuickFadeProtectms_A8807.ShowHexValue = false;
			this.trkSysASTRO25WUIDValiditySupport_A41483 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鳇룉Ɤ鷍ꧏꇑ闓藕賗裙鏛헟뗡뇣꿥곧볩跫苭駯雱鷳苵臷꧹觻軽烿洁瘃爅圇䬉㠋㼍␏⨑✓", a_), global::CommonResources.AcgResources.ID_WUIDVALIDITYSUPPORT);
			this.trkSysASTRO25WUIDValiditySupport_A41483.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.trkSysASTRO25WUIDValiditySupport_A41483.DataTransferOrder = 135;
			this.trkSysASTRO25GeoFenceMode_42322 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鳇룉Ɤ鷍ꧏꇑ闓藕賗裙鏛헟ꗡ臣觥껧迩苫跭闯뿱鯳鋵鷷ꗹ죻쳽㏿、㘃", a_), global::CommonResources.AcgResources.ID_GEOFENCEMODE, global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.LOVs.TrkSysASTRO25GeoFenceMode_42322LovStrs);
			this.trkSysASTRO25GeoFenceMode_42322.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkSysASTRO25GeoFenceMode_42322.DataTransferOrder = 136;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("觇駉飋鳍鿏", a_);
			base.Id = 10162;
			base.UIName = global::CommonResources.AcgResources.ID_ASTRO25;
			base.DataTransferOrder = 3;
		}

		// Token: 0x06000909 RID: 2313 RVA: 0x00089CC4 File Offset: 0x00087EC4
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 9;
			short num = (short)2091515947;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("黉뻋ꗍ菏ꯑꟓ韕诗軙軛針틟ퟡ듣軥觧駩觫\udcedꛯ鷱鷳闵鷷맹鷻軽懿态栃挅圇䬉㼋㤍⤏┑☓", a_)))
					{
						num = (short)117571585;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_C85;
				case 1:
					this.trkSysASTRO25Phase2VoiceCapable_A37972 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("黉뻋ꗍ菏ꯑꟓ韕诗軙軛針틟ퟡ듣軥觧駩觫\udcedꛯ鷱鷳闵鷷맹鷻軽懿态栃挅圇䬉㼋㤍⤏┑☓", a_), global::CommonResources.AcgResources.ID_PHASE2VOICECAPABLE);
					this.trkSysASTRO25Phase2VoiceCapable_A37972.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkSysASTRO25Phase2VoiceCapable_A37972.DataTransferOrder = 130;
					num = (short)1206386692;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					this.trkSysASTRO25ResponsePendingTimesec_A8945 = new global::AcpBusinessLayer.AcpSimpleRangeField(6, this, global::AllFeatures.CodeplugGuid.b("黉뻋ꗍ菏ꯑꟓ韕诗軙軛針틟ퟡ뛣菥鯧髩菫胭華韱ꓳ鏵雷黹闻都柿嘁洃欅洇礉椋洍伏匑Ⱃ⼕Ⱇ⼙", a_), global::CommonResources.AcgResources.ID_RESPONSEPENDINGTIMESEC, global::CommonResources.AcgResources.ID_INFINITE, null, 0, 1);
					this.trkSysASTRO25ResponsePendingTimesec_A8945.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.trkSysASTRO25ResponsePendingTimesec_A8945.DataTransferOrder = 71;
					this.trkSysASTRO25ResponsePendingTimesec_A8945.ShowHexValue = false;
					num = (short)1174667296;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("黉뻋ꗍ菏ꯑꟓ韕诗軙軛針틟ퟡ뛣菥鯧髩菫胭華韱ꓳ鏵雷黹闻都柿嘁洃欅洇礉椋洍伏匑Ⱃ⼕Ⱇ⼙", a_)))
					{
						num = (short)2008219650;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_AFD;
				case 4:
					goto IL_C85;
				case 5:
					goto IL_246;
				case 6:
					goto IL_64E;
				case 7:
					goto IL_3B8;
				case 8:
					goto IL_69A;
				case 9:
					this.trkSysASTRO25EndPhase2TDMATransmitOnOutOfRange_A37980 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("黉뻋ꗍ菏ꯑꟓ韕诗軙軛針틟ퟡꇣ裥賧뫩蓫迭華韱웳ꋵ볷럹뷻꫽狿持樃甅攇按砋䄍縏崑愓戕圗簙丛缝丟䔡䄣礥椧ᤩᬫᜭ࠯ȱ", a_), global::CommonResources.AcgResources.ID_ENDPHASE2TDMATRANSMITONOUTOFRANGE);
					this.trkSysASTRO25EndPhase2TDMATransmitOnOutOfRange_A37980.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.trkSysASTRO25EndPhase2TDMATransmitOnOutOfRange_A37980.DataTransferOrder = 131;
					num = (short)854589445;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					goto IL_6E7;
				case 11:
					this.trkSysASTRO25MotorolaProprietaryFeatures_A8547 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("黉뻋ꗍ菏ꯑꟓ韕诗軙軛針틟ퟡꧣ觥鳧藩黫臭鳯鏱ꓳ蓵韷諹軻韽旿瘁攃琅焇䰉椋漍搏朑易猕欗䔙崛☝ᔟᘡጣ", a_), global::CommonResources.AcgResources.ID_MOTOROLAPROPRIETARYFEATURES);
					this.trkSysASTRO25MotorolaProprietaryFeatures_A8547.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkSysASTRO25MotorolaProprietaryFeatures_A8547.DataTransferOrder = 40;
					num = (short)643629063;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("黉뻋ꗍ菏ꯑꟓ韕诗軙軛針틟ퟡꋣ퓥뻧藩藫跭闯뇱闳蛵駷飹郻鯽忿䌁㔃㔅ㄇ㼉", a_)))
					{
						num = (short)833683502;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5B9;
				case 13:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("黉뻋ꗍ菏ꯑꟓ韕诗軙軛針틟ퟡꃣ菥軧诩駫苭蓯ꃱ럳믵맷黹飻賽旿焁眃夅䤇㴉㐋㼍⌏", a_)))
					{
						num = (short)1144258591;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_69A;
				case 14:
					this.trkSysASTRO25ForceUnmuteTimems_A8141 = new global::AcpBusinessLayer.AcpSimpleRangeField(48, this, global::AllFeatures.CodeplugGuid.b("黉뻋ꗍ菏ꯑꟓ韕诗軙軛針틟ퟡꋣ觥髧觩觫믭黯鿱至苵鷷껹闻鏽旿漁眃夅䤇㈉㴋㨍ℏ", a_), global::CommonResources.AcgResources.ID_FORCEUNMUTETIMEMS, global::CommonResources.AcgResources.ID_IMMEDIATE, null, 0, 25);
					this.trkSysASTRO25ForceUnmuteTimems_A8141.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.trkSysASTRO25ForceUnmuteTimems_A8141.DataTransferOrder = 58;
					this.trkSysASTRO25ForceUnmuteTimems_A8141.ShowHexValue = false;
					num = (short)299827245;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					goto IL_C3A;
				case 16:
				{
					num = (short)999134332;
					short num3 = num;
					num = (short)191796348;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)188481536;
						if (num != 0)
						{
						}
						this.trkSysASTRO25BusyUpdateTimesec_A7574 = new global::AcpBusinessLayer.AcpSimpleRangeField(2, this, global::AllFeatures.CodeplugGuid.b("黉뻋ꗍ菏ꯑꟓ韕诗軙軛針틟ퟡꛣ鏥鯧鏩맫黭铯鏱胳鏵곷鏹釻鯽珿朁會夅䤇㴉㤋㤍␏", a_), global::CommonResources.AcgResources.ID_BUSYUPDATETIMESEC, global::CommonResources.AcgResources.ID_INFINITE, null, 0, 15);
						this.trkSysASTRO25BusyUpdateTimesec_A7574.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
						this.trkSysASTRO25BusyUpdateTimesec_A7574.DataTransferOrder = 51;
						this.trkSysASTRO25BusyUpdateTimesec_A7574.ShowHexValue = false;
						break;
					}
					num = (short)51183622;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 17:
					goto IL_B98;
				case 18:
					goto IL_532;
				case 19:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("黉뻋ꗍ菏ꯑꟓ韕诗軙軛針틟ퟡ닣蟥蓧菩裫迭蓯韱뫳럵믷믹鯻鿽槿氁眃爅嬇猉缋稍甏缑崓刕䜗嬙⸛⸝ᘟሡᰣ", a_)))
					{
						num = (short)1461977114;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_123;
				case 20:
					this.trkSysASTRO25MaximumSlotSizems_A8478 = new global::AcpBusinessLayer.AcpCustomRangeField(1, new global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.UnpackAndpackRangeValueToLogicalIndexForMaxSlotSize(), this, global::AllFeatures.CodeplugGuid.b("黉뻋ꗍ菏ꯑꟓ韕诗軙軛針틟ퟡꧣ蟥郧菩臫鯭鷯ꇱ飳駵賷꧹闻蓽旿漁眃夅䤇㈉㠋㤍⠏", a_), global::CommonResources.AcgResources.ID_MAXIMUMSLOTSIZEMS, null, global::CommonResources.AcgResources.ID_UNBOUNDED);
					this.trkSysASTRO25MaximumSlotSizems_A8478.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.trkSysASTRO25MaximumSlotSizems_A8478.DataTransferOrder = 66;
					this.trkSysASTRO25MaximumSlotSizems_A8478.ShowHexValue = false;
					num = (short)2026700849;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 21:
					this.trkSysASTRO25EndF2TDMATransmitOnOutOfRange_A1394 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("黉뻋ꗍ菏ꯑꟓ韕诗軙軛針틟ퟡꇣ裥賧곩\udeeb뫭듯뿱뗳ꋵ諷鯹鋻跽淿欁瀃䤅昇䔉礋稍式琑䘓眕瘗紙礛䄝感ጡᜣἥᰧ", a_), global::CommonResources.AcgResources.ID_ENDX2TDMATRANSMITONOUTOFRANGE);
					this.trkSysASTRO25EndF2TDMATransmitOnOutOfRange_A1394.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Depot;
					this.trkSysASTRO25EndF2TDMATransmitOnOutOfRange_A1394.DataTransferOrder = 50;
					num = (short)307560477;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 22:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("黉뻋ꗍ菏ꯑꟓ韕诗軙軛針틟ퟡꇣ裥賧곩\udeeb뫭듯뿱뗳ꋵ諷鯹鋻跽淿欁瀃䤅昇䔉礋稍式琑䘓眕瘗紙礛䄝感ጡᜣἥᰧ", a_)))
					{
						num = (short)366018581;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_294;
				case 23:
					this.trkSysASTRO25ISPSequenceLengthsec_A8354 = new global::AcpBusinessLayer.AcpSimpleRangeField(5, this, global::AllFeatures.CodeplugGuid.b("黉뻋ꗍ菏ꯑꟓ韕诗軙軛針틟ퟡ귣뗥룧맩觫鿭藯韱髳闵鷷뛹駻都柿瘁氃甅洇椉匋伍⠏ℑℓ∕", a_), global::CommonResources.AcgResources.ID_ISPSEQUENCELENGTHSEC, global::CommonResources.AcgResources.ID_INFINITE, null, 0, 1);
					this.trkSysASTRO25ISPSequenceLengthsec_A8354.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.trkSysASTRO25ISPSequenceLengthsec_A8354.DataTransferOrder = 65;
					this.trkSysASTRO25ISPSequenceLengthsec_A8354.ShowHexValue = false;
					num = (short)639238162;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 24:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("黉뻋ꗍ菏ꯑꟓ韕诗軙軛針틟ퟡꛣ鏥鯧鏩맫黭铯鏱胳鏵곷鏹釻鯽珿朁會夅䤇㴉㤋㤍␏", a_)))
					{
						num = (short)1824915472;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_64E;
				case 25:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("黉뻋ꗍ菏ꯑꟓ韕诗軙軛針틟ퟡꇣ裥賧뫩蓫迭華韱웳ꋵ볷럹뷻꫽狿持樃甅攇按砋䄍縏崑愓戕圗簙丛缝丟䔡䄣礥椧ᤩᬫᜭ࠯ȱ", a_)))
					{
						num = (short)2110586889;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_246;
				case 26:
					this.trkSysASTRO25ValidateNACAgainstSystemID_A20608 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("黉뻋ꗍ菏ꯑꟓ韕诗軙軛針틟ퟡ닣蟥蓧菩裫迭蓯韱뫳럵믷믹鯻鿽槿氁眃爅嬇猉缋稍甏缑崓刕䜗嬙⸛⸝ᘟሡᰣ", a_), global::CommonResources.AcgResources.ID_VALIDATENACAGAINSTSYSTEMID);
					this.trkSysASTRO25ValidateNACAgainstSystemID_A20608.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkSysASTRO25ValidateNACAgainstSystemID_A20608.DataTransferOrder = 48;
					num = (short)737804327;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 27:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("黉뻋ꗍ菏ꯑꟓ韕诗軙軛針틟ퟡ뗣鏥臧觩蟫꣭釯雱釳꛵諷闹裻鯽揿瘁椃甅圇䬉㐋㘍‏┑", a_)))
					{
						num = (short)877920291;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_6E7;
				case 28:
					num = (short)1763573782;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 29:
					goto IL_294;
				case 30:
					this.trkSysASTRO25PTTWarningTimems_A8781 = new global::AcpBusinessLayer.AcpSimpleRangeField(30, this, global::AllFeatures.CodeplugGuid.b("黉뻋ꗍ菏ꯑꟓ韕诗軙軛針틟ퟡ듣닥볧뷩跫鳭黯鯱髳釵곷鏹釻鯽淿焁嬃䜅〇㴉㐋㼍", a_), global::CommonResources.AcgResources.ID_PTTWARNINGTIMEMS, global::CommonResources.AcgResources.ID_DISABLED, null, 0, 25);
					this.trkSysASTRO25PTTWarningTimems_A8781.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.trkSysASTRO25PTTWarningTimems_A8781.DataTransferOrder = 69;
					this.trkSysASTRO25PTTWarningTimems_A8781.ShowHexValue = false;
					num = (short)1549729809;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 31:
					this.trkSysASTRO25DefaultRCMAddress_A7813 = new global::AcpBusinessLayer.AcpSimpleRangeField(16777212, this, global::AllFeatures.CodeplugGuid.b("黉뻋ꗍ菏ꯑꟓ韕诗軙軛針틟ퟡꃣ菥軧诩駫苭蓯ꃱ럳믵맷黹飻賽旿焁眃夅䤇㴉㐋㼍⌏", a_), global::CommonResources.AcgResources.ID_DEFAULTRCMID, null, null, 0, 1);
					this.trkSysASTRO25DefaultRCMAddress_A7813.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkSysASTRO25DefaultRCMAddress_A7813.DataTransferOrder = 55;
					this.trkSysASTRO25DefaultRCMAddress_A7813.ShowHexValue = true;
					num = (short)413794312;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 32:
					goto IL_AFD;
				case 33:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("黉뻋ꗍ菏ꯑꟓ韕诗軙軛針틟ퟡꏣ菥蟧곩觫胭鏯韱맳駵鳷鿹ꏻ쫽㋿㄁㘃㐅", a_)))
					{
						num = (short)503906344;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_CD2;
				case 34:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("黉뻋ꗍ菏ꯑꟓ韕诗軙軛針틟ퟡꋣ觥髧觩觫믭黯鿱至苵鷷껹闻鏽旿漁眃夅䤇㈉㴋㨍ℏ", a_)))
					{
						num = (short)1963196430;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A0F;
				case 35:
					this.trkSysASTRO25QuickFadeProtectms_A8807 = new global::AcpBusinessLayer.AcpSimpleRangeField(12, this, global::AllFeatures.CodeplugGuid.b("黉뻋ꗍ菏ꯑꟓ韕诗軙軛針틟ퟡ뗣鏥臧觩蟫꣭釯雱釳꛵諷闹裻鯽揿瘁椃甅圇䬉㐋㘍‏┑", a_), global::CommonResources.AcgResources.ID_QUICKFADEPROTECTMS, null, null, 0, 25);
					this.trkSysASTRO25QuickFadeProtectms_A8807.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.trkSysASTRO25QuickFadeProtectms_A8807.DataTransferOrder = 70;
					this.trkSysASTRO25QuickFadeProtectms_A8807.ShowHexValue = false;
					num = (short)514719754;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 36:
					num = (short)1161560105;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 37:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("黉뻋ꗍ菏ꯑꟓ韕诗軙軛針틟ퟡ귣뗥룧맩觫鿭藯韱髳闵鷷뛹駻都柿瘁氃甅洇椉匋伍⠏ℑℓ∕", a_)))
					{
						num = (short)1298137111;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_532;
				case 38:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("黉뻋ꗍ菏ꯑꟓ韕诗軙軛針틟ퟡꧣ蟥郧菩臫鯭鷯ꇱ飳駵賷꧹闻蓽旿漁眃夅䤇㈉㠋㤍⠏", a_)))
					{
						num = (short)231014420;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A5B;
				case 39:
					goto IL_123;
				case 40:
					this.trkSysASTRO25GeoFenceMode_42322 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("黉뻋ꗍ菏ꯑꟓ韕诗軙軛針틟ퟡꏣ菥蟧곩觫胭鏯韱맳駵鳷鿹ꏻ쫽㋿㄁㘃㐅", a_), global::CommonResources.AcgResources.ID_GEOFENCEMODE, global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.LOVs.TrkSysASTRO25GeoFenceMode_42322LovStrs);
					this.trkSysASTRO25GeoFenceMode_42322.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkSysASTRO25GeoFenceMode_42322.DataTransferOrder = 136;
					num = (short)1243480106;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 41:
					if (producerFields != null)
					{
						num = (short)526712860;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_CD2;
				case 42:
					goto IL_52D;
				case 43:
					switch (0)
					{
					case 0:
						goto IL_FD;
					}
					continue;
				case 44:
					num = (short)1751187457;
					if (num != 0)
					{
					}
					goto IL_5B9;
				case 45:
					goto IL_A0F;
				case 46:
					this.trkSysASTRO25F2VoiceCapable_A1395 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("黉뻋ꗍ菏ꯑꟓ韕诗軙軛針틟ퟡꋣ퓥뻧藩藫跭闯뇱闳蛵駷飹郻鯽忿䌁㔃㔅ㄇ㼉", a_), global::CommonResources.AcgResources.ID_X2VOICECAPABLE);
					this.trkSysASTRO25F2VoiceCapable_A1395.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.trkSysASTRO25F2VoiceCapable_A1395.DataTransferOrder = 4;
					num = (short)973930540;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 47:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("黉뻋ꗍ菏ꯑꟓ韕诗軙軛針틟ퟡꧣ觥鳧藩黫臭鳯鏱ꓳ蓵韷諹軻韽旿瘁攃琅焇䰉椋漍搏朑易猕欗䔙崛☝ᔟᘡጣ", a_)))
					{
						num = (short)1563361291;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3B8;
				case 48:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("黉뻋ꗍ菏ꯑꟓ韕诗軙軛針틟ퟡ듣닥볧뷩跫鳭黯鯱髳釵곷鏹釻鯽淿焁嬃䜅〇㴉㐋㼍", a_)))
					{
						num = (short)498860062;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_B98;
				case 49:
					goto IL_A5B;
				case 50:
					this.trkSysASTRO25WUIDValiditySupport_A41483 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("黉뻋ꗍ菏ꯑꟓ韕诗軙軛針틟ퟡ돣돥ꇧ껩뫫迭鳯鯱郳鿵賷菹꿻诽烿爁欃琅簇唉䴋㨍ℏ☑Ⱃ┕", a_), global::CommonResources.AcgResources.ID_WUIDVALIDITYSUPPORT);
					this.trkSysASTRO25WUIDValiditySupport_A41483.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.trkSysASTRO25WUIDValiditySupport_A41483.DataTransferOrder = 135;
					num = (short)1251606543;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 51:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("黉뻋ꗍ菏ꯑꟓ韕诗軙軛針틟ퟡ돣돥ꇧ껩뫫迭鳯鯱郳鿵賷菹꿻诽烿爁欃琅簇唉䴋㨍ℏ☑Ⱃ┕", a_)))
					{
						num = (short)813957170;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_C3A;
				}
				IL_FD:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)762445860;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_123:
				num = (short)1181089792;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_246:
				num = (short)1862926363;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_294:
				num = (short)1461190656;
				short num4 = num;
				num = (short)1664024588;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3B8:
				num = (short)259063856;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_532:
				num = (short)51904550;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_5B9:
				num = (short)1102577688;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_64E:
				num = (short)745144333;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_69A:
				num = (short)430374946;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_6E7:
				num = (short)2100887603;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_A0F:
				num = (short)148045861;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_A5B:
				num = (short)107348015;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_AFD:
				num = (short)1402470419;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_B98:
				num = (short)852754435;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_C3A:
				num = (short)1615724577;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_C85:
				num = (short)1616314393;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_52D:
			IL_CD2:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("诉鿋髍苏鷑", a_);
			base.Id = 10162;
			base.UIName = global::CommonResources.AcgResources.ID_ASTRO25;
			base.DataTransferOrder = 3;
		}

		// Token: 0x0600090A RID: 2314 RVA: 0x0008A9D4 File Offset: 0x00088BD4
		public override void PopulateReferences()
		{
			short num = (short)805634048;
			short num2 = num;
			num = (short)1179262728;
			short num3 = num;
			num = (short)1312694024;
			switch (num3 == num)
			{
			}
			num = (short)112984064;
			if (num != 0)
			{
			}
			num = (short)1310916609;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600090B RID: 2315 RVA: 0x0008AA7C File Offset: 0x00088C7C
		public override void DropReferences()
		{
			short num = (short)1950220288;
			short num2 = num;
			num = (short)299126917;
			short num3 = num;
			num = (short)1394167941;
			switch (num3 == num)
			{
			}
			num = (short)1965162496;
			if (num != 0)
			{
			}
			num = (short)915603457;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600090C RID: 2316 RVA: 0x0008AB28 File Offset: 0x00088D28
		public override void SetConstraints()
		{
			short num = (short)1500708864;
			short num2 = num;
			num = (short)1414812134;
			short num3 = num;
			num = (short)1198281190;
			switch (num3 == num)
			{
			}
			num = (short)1612775425;
			if (num != 0)
			{
			}
			num = (short)1187971072;
			if (num != 0)
			{
			}
			this.trkSysASTRO25EndF2TDMATransmitOnOutOfRange_A1394.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConX2VoiceCapableIsEnabled);
			this.trkSysASTRO25EndF2TDMATransmitOnOutOfRange_A1394.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConTrkSysTypeIsAstro25);
			this.trkSysASTRO25F2VoiceCapable_A1395.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConIsMutualExclusiveWithInterWACNRoaming);
			this.trkSysASTRO25F2VoiceCapable_A1395.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConTrkSysTypeIsAstro25);
			this.trkSysASTRO25BusyUpdateTimesec_A7574.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConTrkSysTypeIsAstro25);
			this.trkSysASTRO25DefaultRCMAddress_A7813.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConTrkSysTypeIsAstro25);
			this.trkSysASTRO25ForceUnmuteTimems_A8141.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConTrkSysTypeIsAstro25);
			this.trkSysASTRO25ISPSequenceLengthsec_A8354.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConTrkSysTypeIsAstro25);
			this.trkSysASTRO25MaximumSlotSizems_A8478.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConTrkSysTypeIsAstro25);
			this.trkSysASTRO25MotorolaProprietaryFeatures_A8547.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConTrkSysTypeIsAstro25);
			this.trkSysASTRO25PTTWarningTimems_A8781.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConTrkSysTypeIsAstro25);
			this.trkSysASTRO25ResponsePendingTimesec_A8945.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConTrkSysTypeIsAstro25);
			this.trkSysASTRO25ValidateNACAgainstSystemID_A20608.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConCoverTypeIsNotInterWACNAndNotNAC);
			this.trkSysASTRO25ValidateNACAgainstSystemID_A20608.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConTrkSysTypeIsAstro25);
			this.trkSysASTRO25Phase2VoiceCapable_A37972.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConTrkSysTypeIsAstro25);
			this.trkSysASTRO25EndPhase2TDMATransmitOnOutOfRange_A37980.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConTrkSysPhase2VoiceCapableIsEnable);
			this.trkSysASTRO25EndPhase2TDMATransmitOnOutOfRange_A37980.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConTrkSysTypeIsAstro25);
			this.trkSysASTRO25QuickFadeProtectms_A8807.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConTrkSysTypeIsAstro25);
			this.trkSysASTRO25WUIDValiditySupport_A41483.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConDVRSIsEnAndWUIDValSupApp);
			this.trkSysASTRO25WUIDValiditySupport_A41483.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConTrkSysTypeIsAstro25OrWUIDValidityIsUncheckedIfTypeII);
			this.trkSysASTRO25WUIDValiditySupport_A41483.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConWUIDValidityIsUncheckedAndSysTypeIsTypeII);
			this.trkSysASTRO25GeoFenceMode_42322.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConTrkSysTypeIsAstro25);
		}

		// Token: 0x0600090D RID: 2317 RVA: 0x0008ADCC File Offset: 0x00088FCC
		public override void SetupDependencies()
		{
			short num = (short)867565568;
			short num2 = num;
			num = (short)562353689;
			short num3 = num;
			num = (short)1741739545;
			switch (num3 == num)
			{
			}
			num = (short)816250881;
			if (num != 0)
			{
			}
			num = (short)2027683840;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem = base.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem;
			trunkingSystem.General.TrkSysGeneralSystemType_A9252.AddDependentObject(this.trkSysASTRO25EndF2TDMATransmitOnOutOfRange_A1394);
			this.trkSysASTRO25F2VoiceCapable_A1395.AddDependentObject(this.trkSysASTRO25EndF2TDMATransmitOnOutOfRange_A1394);
			trunkingSystem.General.TrkSysGeneralSystemType_A9252.AddDependentObject(this.trkSysASTRO25F2VoiceCapable_A1395);
			trunkingSystem.General.TrkSysGeneralCoverageType_A7782.AddDependentObject(this.trkSysASTRO25F2VoiceCapable_A1395);
			trunkingSystem.General.TrkSysGeneralSystemType_A9252.AddDependentObject(this.trkSysASTRO25BusyUpdateTimesec_A7574);
			trunkingSystem.General.TrkSysGeneralSystemType_A9252.AddDependentObject(this.trkSysASTRO25DefaultRCMAddress_A7813);
			trunkingSystem.General.TrkSysGeneralSystemType_A9252.AddDependentObject(this.trkSysASTRO25ForceUnmuteTimems_A8141);
			trunkingSystem.General.TrkSysGeneralSystemType_A9252.AddDependentObject(this.trkSysASTRO25ISPSequenceLengthsec_A8354);
			trunkingSystem.General.TrkSysGeneralSystemType_A9252.AddDependentObject(this.trkSysASTRO25MaximumSlotSizems_A8478);
			trunkingSystem.General.TrkSysGeneralSystemType_A9252.AddDependentObject(this.trkSysASTRO25MotorolaProprietaryFeatures_A8547);
			trunkingSystem.General.TrkSysGeneralSystemType_A9252.AddDependentObject(this.trkSysASTRO25PTTWarningTimems_A8781);
			trunkingSystem.General.TrkSysGeneralSystemType_A9252.AddDependentObject(this.trkSysASTRO25ResponsePendingTimesec_A8945);
			trunkingSystem.General.TrkSysGeneralSystemType_A9252.AddDependentObject(this.trkSysASTRO25ValidateNACAgainstSystemID_A20608);
			trunkingSystem.General.TrkSysGeneralCoverageType_A7782.AddDependentObject(this.trkSysASTRO25ValidateNACAgainstSystemID_A20608);
			this.RefDVRSWide.General.RadErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911.AddDependentObject(this.trkSysASTRO25ValidateNACAgainstSystemID_A20608);
			trunkingSystem.General.TrkSysGeneralSystemType_A9252.AddDependentObject(this.trkSysASTRO25Phase2VoiceCapable_A37972);
			trunkingSystem.General.TrkSysGeneralSystemType_A9252.AddDependentObject(this.trkSysASTRO25EndPhase2TDMATransmitOnOutOfRange_A37980);
			this.trkSysASTRO25Phase2VoiceCapable_A37972.AddDependentObject(this.trkSysASTRO25EndPhase2TDMATransmitOnOutOfRange_A37980);
			trunkingSystem.General.TrkSysGeneralSystemType_A9252.AddDependentObject(this.trkSysASTRO25QuickFadeProtectms_A8807);
			trunkingSystem.General.TrkSysGeneralSystemType_A9252.AddDependentObject(this.trkSysASTRO25WUIDValiditySupport_A41483);
			trunkingSystem.General.TrkSysGeneralCoverageType_A7782.AddDependentObject(this.trkSysASTRO25WUIDValiditySupport_A41483);
			this.RefDVRSWide.General.RadErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911.AddDependentObject(this.trkSysASTRO25WUIDValiditySupport_A41483);
			trunkingSystem.General.TrkSysGeneralSystemType_A9252.AddDependentObject(this.trkSysASTRO25GeoFenceMode_42322);
			this.trkSysASTRO25Phase2VoiceCapable_A37972.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2027)[0][10060] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingWide.Labtool).TrkWideLabtoolPhase2ScramblingDisable_A37983);
		}

		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x0600090E RID: 2318 RVA: 0x0008B0C0 File Offset: 0x000892C0
		public bool HasDiffs
		{
			get
			{
				short num = (short)1083179008;
				short num2 = num;
				num = (short)1618945429;
				short num3 = num;
				num = (short)956638613;
				switch (num3 == num)
				{
				}
				num = (short)1812135936;
				if (num != 0)
				{
				}
				num = (short)1900544001;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x0600090F RID: 2319 RVA: 0x0008B174 File Offset: 0x00089374
		// (set) Token: 0x06000910 RID: 2320 RVA: 0x0008B22C File Offset: 0x0008942C
		public bool TrkSysASTRO25EndF2TDMATransmitOnOutOfRange_A1394Value
		{
			get
			{
				short num = (short)607649792;
				short num2 = num;
				num = (short)1766642227;
				short num3 = num;
				num = (short)1858196019;
				switch (num3 == num)
				{
				}
				num = (short)1896087552;
				if (num != 0)
				{
				}
				num = (short)1152188417;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25EndF2TDMATransmitOnOutOfRange_A1394.Value;
			}
			set
			{
				short num = (short)627638272;
				short num2 = num;
				num = (short)855399591;
				short num3 = num;
				num = (short)420175015;
				switch (num3 == num)
				{
				}
				num = (short)399900673;
				if (num != 0)
				{
				}
				num = (short)1944190976;
				if (num != 0)
				{
				}
				this.trkSysASTRO25EndF2TDMATransmitOnOutOfRange_A1394.Value = value;
			}
		}

		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x06000911 RID: 2321 RVA: 0x0008B2E4 File Offset: 0x000894E4
		public global::AcpBusinessLayer.AcpField<bool> TrkSysASTRO25EndF2TDMATransmitOnOutOfRange_A1394
		{
			get
			{
				short num = (short)1289551872;
				short num2 = num;
				num = (short)172704331;
				short num3 = num;
				num = (short)2075542091;
				switch (num3 == num)
				{
				}
				num = (short)35782657;
				if (num != 0)
				{
				}
				num = (short)1806368768;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25EndF2TDMATransmitOnOutOfRange_A1394;
			}
		}

		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x06000912 RID: 2322 RVA: 0x0008B394 File Offset: 0x00089594
		// (set) Token: 0x06000913 RID: 2323 RVA: 0x0008B448 File Offset: 0x00089648
		public bool TrkSysASTRO25EndF2TDMATransmitOnOutOfRange_A1394_UIValue
		{
			get
			{
				short num = (short)1120468992;
				short num2 = num;
				num = (short)1233723250;
				short num3 = num;
				num = (short)318119794;
				switch (num3 == num)
				{
				}
				num = (short)1185153024;
				if (num != 0)
				{
				}
				num = (short)1708130305;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25EndF2TDMATransmitOnOutOfRange_A1394.Value;
			}
			set
			{
				short num = (short)1577648128;
				short num2 = num;
				num = (short)160324303;
				short num3 = num;
				num = (short)1574263503;
				switch (num3 == num)
				{
				}
				num = (short)642514945;
				if (num != 0)
				{
				}
				num = (short)738459648;
				if (num != 0)
				{
				}
				this.trkSysASTRO25EndF2TDMATransmitOnOutOfRange_A1394.Value = value;
			}
		}

		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x06000914 RID: 2324 RVA: 0x0008B500 File Offset: 0x00089700
		// (set) Token: 0x06000915 RID: 2325 RVA: 0x0008B5B8 File Offset: 0x000897B8
		public bool TrkSysASTRO25EndF2TDMATransmitOnOutOfRange_A1394_Applicable
		{
			get
			{
				short num = (short)600702976;
				short num2 = num;
				num = (short)512032769;
				if (num != 0)
				{
				}
				num = (short)1040250663;
				short num3 = num;
				num = (short)1342633767;
				switch (num3 == num)
				{
				}
				num = (short)2048917504;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25EndF2TDMATransmitOnOutOfRange_A1394.Applicable;
			}
			set
			{
				short num = (short)1969225728;
				short num2 = num;
				num = (short)742475898;
				short num3 = num;
				num = (short)792807546;
				switch (num3 == num)
				{
				}
				num = (short)1855979521;
				if (num != 0)
				{
				}
				num = (short)976617472;
				if (num != 0)
				{
				}
				this.trkSysASTRO25EndF2TDMATransmitOnOutOfRange_A1394.Applicable = value;
			}
		}

		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x06000916 RID: 2326 RVA: 0x0008B66C File Offset: 0x0008986C
		// (set) Token: 0x06000917 RID: 2327 RVA: 0x0008B720 File Offset: 0x00089920
		public bool TrkSysASTRO25EndF2TDMATransmitOnOutOfRange_A1394_Valid
		{
			get
			{
				short num = (short)501153792;
				short num2 = num;
				num = (short)1438989719;
				short num3 = num;
				num = (short)270482839;
				switch (num3 == num)
				{
				}
				num = (short)1012596736;
				if (num != 0)
				{
				}
				num = (short)1696923649;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25EndF2TDMATransmitOnOutOfRange_A1394.Valid;
			}
			set
			{
				short num = (short)439877632;
				short num2 = num;
				num = (short)876048771;
				short num3 = num;
				num = (short)1703178627;
				switch (num3 == num)
				{
				}
				num = (short)724959233;
				if (num != 0)
				{
				}
				num = (short)1520238592;
				if (num != 0)
				{
				}
				this.trkSysASTRO25EndF2TDMATransmitOnOutOfRange_A1394.Valid = value;
			}
		}

		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x06000918 RID: 2328 RVA: 0x0008B7D8 File Offset: 0x000899D8
		// (set) Token: 0x06000919 RID: 2329 RVA: 0x0008B88C File Offset: 0x00089A8C
		public bool TrkSysASTRO25EndF2TDMATransmitOnOutOfRange_A1394_Visible
		{
			get
			{
				short num = (short)615055360;
				short num2 = num;
				num = (short)1628571312;
				short num3 = num;
				num = (short)1962411696;
				switch (num3 == num)
				{
				}
				num = (short)60030977;
				if (num != 0)
				{
				}
				num = (short)1693712384;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25EndF2TDMATransmitOnOutOfRange_A1394.Visible;
			}
			set
			{
				short num = (short)823459840;
				short num2 = num;
				num = (short)1270703098;
				short num3 = num;
				num = (short)721118202;
				switch (num3 == num)
				{
				}
				num = (short)768016385;
				if (num != 0)
				{
				}
				num = (short)1597505536;
				if (num != 0)
				{
				}
				this.trkSysASTRO25EndF2TDMATransmitOnOutOfRange_A1394.Visible = value;
			}
		}

		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x0600091A RID: 2330 RVA: 0x0008B940 File Offset: 0x00089B40
		// (set) Token: 0x0600091B RID: 2331 RVA: 0x0008B9F4 File Offset: 0x00089BF4
		public bool TrkSysASTRO25EndF2TDMATransmitOnOutOfRange_A1394_Editable
		{
			get
			{
				short num = (short)340262912;
				short num2 = num;
				num = (short)2011453893;
				short num3 = num;
				num = (short)1302354373;
				switch (num3 == num)
				{
				}
				num = (short)938934273;
				if (num != 0)
				{
				}
				num = (short)1855520768;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25EndF2TDMATransmitOnOutOfRange_A1394.Editable;
			}
			set
			{
				short num = (short)40239104;
				short num2 = num;
				num = (short)604505093;
				short num3 = num;
				num = (short)1614742533;
				switch (num3 == num)
				{
				}
				num = (short)1895759873;
				if (num != 0)
				{
				}
				num = (short)1240989696;
				if (num != 0)
				{
				}
				this.trkSysASTRO25EndF2TDMATransmitOnOutOfRange_A1394.Editable = value;
			}
		}

		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x0600091C RID: 2332 RVA: 0x0008BAA8 File Offset: 0x00089CA8
		internal string TrkSysASTRO25EndF2TDMATransmitOnOutOfRange_A1394_UILabel
		{
			get
			{
				short num = (short)1453719552;
				short num2 = num;
				num = (short)1393804163;
				short num3 = num;
				num = (short)1538114435;
				switch (num3 == num)
				{
				}
				num = (short)1063518208;
				if (num != 0)
				{
				}
				num = (short)2039349249;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25EndF2TDMATransmitOnOutOfRange_A1394.UIName;
			}
		}

		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x0600091D RID: 2333 RVA: 0x0008BB5C File Offset: 0x00089D5C
		// (set) Token: 0x0600091E RID: 2334 RVA: 0x0008BC14 File Offset: 0x00089E14
		internal bool TrkSysASTRO25EndF2TDMATransmitOnOutOfRange_A1394_HiddenStatic
		{
			get
			{
				short num = (short)1554448384;
				short num2 = num;
				num = (short)1395496745;
				short num3 = num;
				num = (short)998676265;
				switch (num3 == num)
				{
				}
				num = (short)919666689;
				if (num != 0)
				{
				}
				num = (short)1068892160;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25EndF2TDMATransmitOnOutOfRange_A1394.HiddenStatic;
			}
			set
			{
				short num = (short)358285312;
				short num2 = num;
				num = (short)1555247019;
				short num3 = num;
				num = (short)1250439083;
				switch (num3 == num)
				{
				}
				num = (short)1163395073;
				if (num != 0)
				{
				}
				num = (short)272302080;
				if (num != 0)
				{
				}
				this.trkSysASTRO25EndF2TDMATransmitOnOutOfRange_A1394.HiddenStatic = value;
			}
		}

		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x0600091F RID: 2335 RVA: 0x0008BCCC File Offset: 0x00089ECC
		// (set) Token: 0x06000920 RID: 2336 RVA: 0x0008BD80 File Offset: 0x00089F80
		internal bool TrkSysASTRO25EndF2TDMATransmitOnOutOfRange_A1394_HiddenDynamic
		{
			get
			{
				short num = (short)1434910720;
				short num2 = num;
				num = (short)527449547;
				short num3 = num;
				num = (short)1280327115;
				switch (num3 == num)
				{
				}
				num = (short)1778909184;
				if (num != 0)
				{
				}
				num = (short)1019543553;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25EndF2TDMATransmitOnOutOfRange_A1394.HiddenDynamic;
			}
			set
			{
				short num = (short)1251672064;
				short num2 = num;
				num = (short)865821720;
				short num3 = num;
				num = (short)617374744;
				switch (num3 == num)
				{
				}
				num = (short)1649541121;
				if (num != 0)
				{
				}
				num = (short)1256259584;
				if (num != 0)
				{
				}
				this.trkSysASTRO25EndF2TDMATransmitOnOutOfRange_A1394.HiddenDynamic = value;
			}
		}

		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x06000921 RID: 2337 RVA: 0x0008BE38 File Offset: 0x0008A038
		public bool TrkSysASTRO25EndF2TDMATransmitOnOutOfRange_A1394_HasDiffs
		{
			get
			{
				short num = (short)511180800;
				short num2 = num;
				num = (short)1789015554;
				short num3 = num;
				num = (short)711472642;
				switch (num3 == num)
				{
				}
				num = (short)1882390528;
				if (num != 0)
				{
				}
				num = (short)1264713729;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25EndF2TDMATransmitOnOutOfRange_A1394._HasDiffs;
			}
		}

		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x06000922 RID: 2338 RVA: 0x0008BEF0 File Offset: 0x0008A0F0
		// (set) Token: 0x06000923 RID: 2339 RVA: 0x0008BFA4 File Offset: 0x0008A1A4
		public bool TrkSysASTRO25F2VoiceCapable_A1395Value
		{
			get
			{
				short num = (short)1477509120;
				short num2 = num;
				num = (short)1837608352;
				short num3 = num;
				num = (short)1707322784;
				switch (num3 == num)
				{
				}
				num = (short)826015745;
				if (num != 0)
				{
				}
				num = (short)1041563648;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25F2VoiceCapable_A1395.Value;
			}
			set
			{
				short num = (short)479723520;
				short num2 = num;
				num = (short)1888046025;
				short num3 = num;
				num = (short)595610569;
				switch (num3 == num)
				{
				}
				num = (short)381288448;
				if (num != 0)
				{
				}
				num = (short)1190985729;
				if (num != 0)
				{
				}
				this.trkSysASTRO25F2VoiceCapable_A1395.Value = value;
			}
		}

		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x06000924 RID: 2340 RVA: 0x0008C058 File Offset: 0x0008A258
		public global::AcpBusinessLayer.AcpField<bool> TrkSysASTRO25F2VoiceCapable_A1395
		{
			get
			{
				short num = (short)2060648448;
				short num2 = num;
				num = (short)1809447372;
				short num3 = num;
				num = (short)84933068;
				switch (num3 == num)
				{
				}
				num = (short)2111242241;
				if (num != 0)
				{
				}
				num = (short)1215561728;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25F2VoiceCapable_A1395;
			}
		}

		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x06000925 RID: 2341 RVA: 0x0008C104 File Offset: 0x0008A304
		// (set) Token: 0x06000926 RID: 2342 RVA: 0x0008C1B8 File Offset: 0x0008A3B8
		public bool TrkSysASTRO25F2VoiceCapable_A1395_UIValue
		{
			get
			{
				short num = (short)1189347328;
				short num2 = num;
				num = (short)1842918256;
				short num3 = num;
				num = (short)18920304;
				switch (num3 == num)
				{
				}
				num = (short)114491393;
				if (num != 0)
				{
				}
				num = (short)1903034368;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25F2VoiceCapable_A1395.Value;
			}
			set
			{
				short num = (short)1386741760;
				short num2 = num;
				num = (short)972941743;
				short num3 = num;
				num = (short)2091051439;
				switch (num3 == num)
				{
				}
				num = (short)274989057;
				if (num != 0)
				{
				}
				num = (short)159514624;
				if (num != 0)
				{
				}
				this.trkSysASTRO25F2VoiceCapable_A1395.Value = value;
			}
		}

		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x06000927 RID: 2343 RVA: 0x0008C270 File Offset: 0x0008A470
		// (set) Token: 0x06000928 RID: 2344 RVA: 0x0008C324 File Offset: 0x0008A524
		public bool TrkSysASTRO25F2VoiceCapable_A1395_Applicable
		{
			get
			{
				short num = (short)457310208;
				short num2 = num;
				num = (short)1507257024;
				short num3 = num;
				num = (short)405924544;
				switch (num3 == num)
				{
				}
				num = (short)667025409;
				if (num != 0)
				{
				}
				num = (short)1780285440;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25F2VoiceCapable_A1395.Applicable;
			}
			set
			{
				short num = (short)289144832;
				short num2 = num;
				num = (short)1506846984;
				short num3 = num;
				num = (short)993437960;
				switch (num3 == num)
				{
				}
				num = (short)454688768;
				if (num != 0)
				{
				}
				num = (short)497221633;
				if (num != 0)
				{
				}
				this.trkSysASTRO25F2VoiceCapable_A1395.Applicable = value;
			}
		}

		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x06000929 RID: 2345 RVA: 0x0008C3DC File Offset: 0x0008A5DC
		// (set) Token: 0x0600092A RID: 2346 RVA: 0x0008C490 File Offset: 0x0008A690
		public bool TrkSysASTRO25F2VoiceCapable_A1395_Valid
		{
			get
			{
				short num = (short)174915584;
				short num2 = num;
				num = (short)361609266;
				short num3 = num;
				num = (short)1077262386;
				switch (num3 == num)
				{
				}
				num = (short)1950023681;
				if (num != 0)
				{
				}
				num = (short)1587281920;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25F2VoiceCapable_A1395.Valid;
			}
			set
			{
				short num = (short)1600192512;
				short num2 = num;
				num = (short)483460458;
				short num3 = num;
				num = (short)552011114;
				switch (num3 == num)
				{
				}
				num = (short)1550254080;
				if (num != 0)
				{
				}
				num = (short)1746731009;
				if (num != 0)
				{
				}
				this.trkSysASTRO25F2VoiceCapable_A1395.Valid = value;
			}
		}

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x0600092B RID: 2347 RVA: 0x0008C544 File Offset: 0x0008A744
		// (set) Token: 0x0600092C RID: 2348 RVA: 0x0008C5F8 File Offset: 0x0008A7F8
		public bool TrkSysASTRO25F2VoiceCapable_A1395_Visible
		{
			get
			{
				short num = (short)1789984768;
				short num2 = num;
				num = (short)458652083;
				short num3 = num;
				num = (short)369981875;
				switch (num3 == num)
				{
				}
				num = (short)1719599104;
				if (num != 0)
				{
				}
				num = (short)1978531841;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25F2VoiceCapable_A1395.Visible;
			}
			set
			{
				short num = (short)1290797056;
				short num2 = num;
				num = (short)905904129;
				if (num != 0)
				{
				}
				num = (short)525539005;
				short num3 = num;
				num = (short)838801085;
				switch (num3 == num)
				{
				}
				num = (short)170131456;
				if (num != 0)
				{
				}
				this.trkSysASTRO25F2VoiceCapable_A1395.Visible = value;
			}
		}

		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x0600092D RID: 2349 RVA: 0x0008C6AC File Offset: 0x0008A8AC
		// (set) Token: 0x0600092E RID: 2350 RVA: 0x0008C760 File Offset: 0x0008A960
		public bool TrkSysASTRO25F2VoiceCapable_A1395_Editable
		{
			get
			{
				short num = (short)783024128;
				short num2 = num;
				num = (short)547587125;
				short num3 = num;
				num = (short)446334005;
				switch (num3 == num)
				{
				}
				num = (short)1587675137;
				if (num != 0)
				{
				}
				num = (short)991166464;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25F2VoiceCapable_A1395.Editable;
			}
			set
			{
				short num = (short)854589440;
				short num2 = num;
				num = (short)879937098;
				short num3 = num;
				num = (short)1486800458;
				switch (num3 == num)
				{
				}
				num = (short)1995374593;
				if (num != 0)
				{
				}
				num = (short)1890582528;
				if (num != 0)
				{
				}
				this.trkSysASTRO25F2VoiceCapable_A1395.Editable = value;
			}
		}

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x0600092F RID: 2351 RVA: 0x0008C814 File Offset: 0x0008AA14
		internal string TrkSysASTRO25F2VoiceCapable_A1395_UILabel
		{
			get
			{
				short num = (short)614858752;
				short num2 = num;
				num = (short)701767421;
				short num3 = num;
				num = (short)1026694909;
				switch (num3 == num)
				{
				}
				num = (short)1441267712;
				if (num != 0)
				{
				}
				num = (short)2105868289;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25F2VoiceCapable_A1395.UIName;
			}
		}

		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x06000930 RID: 2352 RVA: 0x0008C8CC File Offset: 0x0008AACC
		// (set) Token: 0x06000931 RID: 2353 RVA: 0x0008C980 File Offset: 0x0008AB80
		internal bool TrkSysASTRO25F2VoiceCapable_A1395_HiddenStatic
		{
			get
			{
				short num = (short)1546715136;
				short num2 = num;
				num = (short)1796987540;
				short num3 = num;
				num = (short)207149716;
				switch (num3 == num)
				{
				}
				num = (short)946798593;
				if (num != 0)
				{
				}
				num = (short)752418816;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25F2VoiceCapable_A1395.HiddenStatic;
			}
			set
			{
				short num = (short)833945600;
				short num2 = num;
				num = (short)998572033;
				if (num != 0)
				{
				}
				num = (short)375938343;
				short num3 = num;
				num = (short)465526055;
				switch (num3 == num)
				{
				}
				num = (short)1545404416;
				if (num != 0)
				{
				}
				this.trkSysASTRO25F2VoiceCapable_A1395.HiddenStatic = value;
			}
		}

		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x06000932 RID: 2354 RVA: 0x0008CA34 File Offset: 0x0008AC34
		// (set) Token: 0x06000933 RID: 2355 RVA: 0x0008CAE8 File Offset: 0x0008ACE8
		internal bool TrkSysASTRO25F2VoiceCapable_A1395_HiddenDynamic
		{
			get
			{
				short num = (short)1301217280;
				short num2 = num;
				num = (short)1545402817;
				short num3 = num;
				num = (short)1673066945;
				switch (num3 == num)
				{
				}
				num = (short)1812594689;
				if (num != 0)
				{
				}
				num = (short)1750532096;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25F2VoiceCapable_A1395.HiddenDynamic;
			}
			set
			{
				short num = (short)1667039232;
				short num2 = num;
				num = (short)580654690;
				short num3 = num;
				num = (short)1073157730;
				switch (num3 == num)
				{
				}
				num = (short)1862795265;
				if (num != 0)
				{
				}
				num = (short)1424097280;
				if (num != 0)
				{
				}
				this.trkSysASTRO25F2VoiceCapable_A1395.HiddenDynamic = value;
			}
		}

		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x06000934 RID: 2356 RVA: 0x0008CB9C File Offset: 0x0008AD9C
		public bool TrkSysASTRO25F2VoiceCapable_A1395_HasDiffs
		{
			get
			{
				short num = (short)61472768;
				short num2 = num;
				num = (short)1240268801;
				if (num != 0)
				{
				}
				num = (short)102426039;
				short num3 = num;
				num = (short)1854006711;
				switch (num3 == num)
				{
				}
				num = (short)656015360;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25F2VoiceCapable_A1395._HasDiffs;
			}
		}

		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x06000935 RID: 2357 RVA: 0x0008CC50 File Offset: 0x0008AE50
		// (set) Token: 0x06000936 RID: 2358 RVA: 0x0008CD08 File Offset: 0x0008AF08
		public int TrkSysASTRO25BusyUpdateTimesec_A7574Value
		{
			get
			{
				short num = (short)1143799808;
				short num2 = num;
				num = (short)510229083;
				short num3 = num;
				num = (short)1755675227;
				switch (num3 == num)
				{
				}
				num = (short)1671168001;
				if (num != 0)
				{
				}
				num = (short)266993664;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25BusyUpdateTimesec_A7574.Value;
			}
			set
			{
				short num = (short)509280256;
				short num2 = num;
				num = (short)1122965225;
				short num3 = num;
				num = (short)1325930217;
				switch (num3 == num)
				{
				}
				num = (short)1185808385;
				if (num != 0)
				{
				}
				num = (short)321323008;
				if (num != 0)
				{
				}
				this.trkSysASTRO25BusyUpdateTimesec_A7574.Value = value;
			}
		}

		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x06000937 RID: 2359 RVA: 0x0008CDBC File Offset: 0x0008AFBC
		public global::AcpBusinessLayer.AcpSimpleRangeField TrkSysASTRO25BusyUpdateTimesec_A7574
		{
			get
			{
				short num = (short)33357824;
				short num2 = num;
				num = (short)320681594;
				short num3 = num;
				num = (short)1219245690;
				switch (num3 == num)
				{
				}
				num = (short)166002688;
				if (num != 0)
				{
				}
				num = (short)1322975233;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25BusyUpdateTimesec_A7574;
			}
		}

		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x06000938 RID: 2360 RVA: 0x0008CE6C File Offset: 0x0008B06C
		// (set) Token: 0x06000939 RID: 2361 RVA: 0x0008CF20 File Offset: 0x0008B120
		public string TrkSysASTRO25BusyUpdateTimesec_A7574_UIValue
		{
			get
			{
				short num = (short)1971191808;
				short num2 = num;
				num = (short)2074052026;
				short num3 = num;
				num = (short)1182041530;
				switch (num3 == num)
				{
				}
				num = (short)1373765632;
				if (num != 0)
				{
				}
				num = (short)1188495361;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25BusyUpdateTimesec_A7574.UIValue;
			}
			set
			{
				short num = (short)1144848384;
				short num2 = num;
				num = (short)1620782554;
				short num3 = num;
				num = (short)1193815514;
				switch (num3 == num)
				{
				}
				num = (short)2014969857;
				if (num != 0)
				{
				}
				num = (short)1950482432;
				if (num != 0)
				{
				}
				this.trkSysASTRO25BusyUpdateTimesec_A7574.UIValue = value;
			}
		}

		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x0600093A RID: 2362 RVA: 0x0008CFD8 File Offset: 0x0008B1D8
		// (set) Token: 0x0600093B RID: 2363 RVA: 0x0008D08C File Offset: 0x0008B28C
		internal int TrkSysASTRO25BusyUpdateTimesec_A7574Min
		{
			get
			{
				short num = (short)2071396352;
				short num2 = num;
				num = (short)1824815437;
				short num3 = num;
				num = (short)1100380493;
				switch (num3 == num)
				{
				}
				num = (short)1446576129;
				if (num != 0)
				{
				}
				num = (short)1775239168;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25BusyUpdateTimesec_A7574.Min;
			}
			set
			{
				short num = (short)235929600;
				short num2 = num;
				num = (short)737034590;
				short num3 = num;
				num = (short)417022302;
				switch (num3 == num)
				{
				}
				num = (short)261619713;
				if (num != 0)
				{
				}
				num = (short)1463025664;
				if (num != 0)
				{
				}
				this.trkSysASTRO25BusyUpdateTimesec_A7574.Min = value;
			}
		}

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x0600093C RID: 2364 RVA: 0x0008D140 File Offset: 0x0008B340
		// (set) Token: 0x0600093D RID: 2365 RVA: 0x0008D1F0 File Offset: 0x0008B3F0
		internal int TrkSysASTRO25BusyUpdateTimesec_A7574Max
		{
			get
			{
				short num = (short)161284096;
				short num2 = num;
				num = (short)1912930305;
				if (num != 0)
				{
				}
				num = (short)363995979;
				short num3 = num;
				num = (short)1383277387;
				switch (num3 == num)
				{
				}
				num = (short)1624637440;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25BusyUpdateTimesec_A7574.Max;
			}
			set
			{
				short num = (short)1002504192;
				short num2 = num;
				num = (short)489816065;
				if (num != 0)
				{
				}
				num = (short)621864564;
				short num3 = num;
				num = (short)332785268;
				switch (num3 == num)
				{
				}
				num = (short)2044461056;
				if (num != 0)
				{
				}
				this.trkSysASTRO25BusyUpdateTimesec_A7574.Max = value;
			}
		}

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x0600093E RID: 2366 RVA: 0x0008D2A8 File Offset: 0x0008B4A8
		// (set) Token: 0x0600093F RID: 2367 RVA: 0x0008D35C File Offset: 0x0008B55C
		internal int TrkSysASTRO25BusyUpdateTimesec_A7574Step
		{
			get
			{
				short num = (short)117047296;
				short num2 = num;
				num = (short)42926879;
				short num3 = num;
				num = (short)1948648223;
				switch (num3 == num)
				{
				}
				num = (short)1309605888;
				if (num != 0)
				{
				}
				num = (short)1176371201;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25BusyUpdateTimesec_A7574.StepSize;
			}
			set
			{
				short num = (short)1851611524;
				short num2 = num;
				num = (short)372595076;
				switch (num2 == num)
				{
				}
				num = (short)496828417;
				if (num != 0)
				{
				}
				num = (short)92471296;
				if (num != 0)
				{
				}
				num = (short)23986176;
				short num3 = num;
				this.trkSysASTRO25BusyUpdateTimesec_A7574.StepSize = value;
			}
		}

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x06000940 RID: 2368 RVA: 0x0008D410 File Offset: 0x0008B610
		// (set) Token: 0x06000941 RID: 2369 RVA: 0x0008D4C4 File Offset: 0x0008B6C4
		public bool TrkSysASTRO25BusyUpdateTimesec_A7574_Applicable
		{
			get
			{
				short num = (short)634322945;
				if (num != 0)
				{
				}
				num = (short)41313488;
				short num2 = num;
				num = (short)373384400;
				switch (num2 == num)
				{
				}
				num = (short)1263796224;
				if (num != 0)
				{
				}
				num = (short)667025408;
				short num3 = num;
				return this.trkSysASTRO25BusyUpdateTimesec_A7574.Applicable;
			}
			set
			{
				short num = (short)1849745724;
				short num2 = num;
				num = (short)1326047548;
				switch (num2 == num)
				{
				}
				num = (short)1245249536;
				if (num != 0)
				{
				}
				num = (short)300351489;
				if (num != 0)
				{
				}
				num = (short)813760512;
				short num3 = num;
				this.trkSysASTRO25BusyUpdateTimesec_A7574.Applicable = value;
			}
		}

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x06000942 RID: 2370 RVA: 0x0008D578 File Offset: 0x0008B778
		// (set) Token: 0x06000943 RID: 2371 RVA: 0x0008D62C File Offset: 0x0008B82C
		public bool TrkSysASTRO25BusyUpdateTimesec_A7574_Valid
		{
			get
			{
				short num = (short)1128852589;
				short num2 = num;
				num = (short)617016429;
				switch (num2 == num)
				{
				}
				num = (short)1099300865;
				if (num != 0)
				{
				}
				num = (short)1820852224;
				if (num != 0)
				{
				}
				num = (short)1583218688;
				short num3 = num;
				return this.trkSysASTRO25BusyUpdateTimesec_A7574.Valid;
			}
			set
			{
				short num = (short)347151332;
				short num2 = num;
				num = (short)1129651172;
				switch (num2 == num)
				{
				}
				num = (short)1940979713;
				if (num != 0)
				{
				}
				num = (short)1214185472;
				if (num != 0)
				{
				}
				num = (short)642777088;
				short num3 = num;
				this.trkSysASTRO25BusyUpdateTimesec_A7574.Valid = value;
			}
		}

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x06000944 RID: 2372 RVA: 0x0008D6E0 File Offset: 0x0008B8E0
		// (set) Token: 0x06000945 RID: 2373 RVA: 0x0008D794 File Offset: 0x0008B994
		public bool TrkSysASTRO25BusyUpdateTimesec_A7574_Visible
		{
			get
			{
				short num = (short)1319501825;
				if (num != 0)
				{
				}
				num = (short)1098197112;
				short num2 = num;
				num = (short)1277634680;
				switch (num2 == num)
				{
				}
				num = (short)1553203200;
				if (num != 0)
				{
				}
				num = (short)326369280;
				short num3 = num;
				return this.trkSysASTRO25BusyUpdateTimesec_A7574.Visible;
			}
			set
			{
				short num = (short)1843855361;
				if (num != 0)
				{
				}
				num = (short)1615714764;
				short num2 = num;
				num = (short)1182259660;
				switch (num2 == num)
				{
				}
				num = (short)1528365056;
				if (num != 0)
				{
				}
				num = (short)1926365184;
				short num3 = num;
				this.trkSysASTRO25BusyUpdateTimesec_A7574.Visible = value;
			}
		}

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x06000946 RID: 2374 RVA: 0x0008D84C File Offset: 0x0008BA4C
		// (set) Token: 0x06000947 RID: 2375 RVA: 0x0008D900 File Offset: 0x0008BB00
		public bool TrkSysASTRO25BusyUpdateTimesec_A7574_Editable
		{
			get
			{
				short num = (short)1452202086;
				short num2 = num;
				num = (short)983881830;
				switch (num2 == num)
				{
				}
				num = (short)1152122880;
				if (num != 0)
				{
				}
				num = (short)576323585;
				if (num != 0)
				{
				}
				num = (short)1942093824;
				short num3 = num;
				return this.trkSysASTRO25BusyUpdateTimesec_A7574.Editable;
			}
			set
			{
				short num = (short)900901174;
				short num2 = num;
				num = (short)1582344502;
				switch (num2 == num)
				{
				}
				num = (short)1876951040;
				if (num != 0)
				{
				}
				num = (short)2017394689;
				if (num != 0)
				{
				}
				num = (short)100466688;
				short num3 = num;
				this.trkSysASTRO25BusyUpdateTimesec_A7574.Editable = value;
			}
		}

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x06000948 RID: 2376 RVA: 0x0008D9B4 File Offset: 0x0008BBB4
		internal string TrkSysASTRO25BusyUpdateTimesec_A7574_UILabel
		{
			get
			{
				short num = (short)1390673921;
				if (num != 0)
				{
				}
				num = (short)1059608731;
				short num2 = num;
				num = (short)2106677403;
				switch (num2 == num)
				{
				}
				num = (short)174718976;
				if (num != 0)
				{
				}
				num = (short)298516480;
				short num3 = num;
				return this.trkSysASTRO25BusyUpdateTimesec_A7574.UIName;
			}
		}

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x06000949 RID: 2377 RVA: 0x0008DA6C File Offset: 0x0008BC6C
		// (set) Token: 0x0600094A RID: 2378 RVA: 0x0008DB20 File Offset: 0x0008BD20
		internal bool TrkSysASTRO25BusyUpdateTimesec_A7574_HiddenStatic
		{
			get
			{
				short num = (short)1931293873;
				short num2 = num;
				num = (short)42611889;
				switch (num2 == num)
				{
				}
				num = (short)108855297;
				if (num != 0)
				{
				}
				num = (short)2049376256;
				if (num != 0)
				{
				}
				num = (short)779681792;
				short num3 = num;
				return this.trkSysASTRO25BusyUpdateTimesec_A7574.HiddenStatic;
			}
			set
			{
				short num = (short)1165341127;
				short num2 = num;
				num = (short)552317383;
				switch (num2 == num)
				{
				}
				num = (short)1169424384;
				if (num != 0)
				{
				}
				num = (short)1397030913;
				if (num != 0)
				{
				}
				num = (short)1226964992;
				short num3 = num;
				this.trkSysASTRO25BusyUpdateTimesec_A7574.HiddenStatic = value;
			}
		}

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x0600094B RID: 2379 RVA: 0x0008DBD8 File Offset: 0x0008BDD8
		// (set) Token: 0x0600094C RID: 2380 RVA: 0x0008DC8C File Offset: 0x0008BE8C
		internal bool TrkSysASTRO25BusyUpdateTimesec_A7574_HiddenDynamic
		{
			get
			{
				short num = (short)1593261813;
				short num2 = num;
				num = (short)2098544373;
				switch (num2 == num)
				{
				}
				num = (short)173539328;
				if (num != 0)
				{
				}
				num = (short)1996816385;
				if (num != 0)
				{
				}
				num = (short)1665007616;
				short num3 = num;
				return this.trkSysASTRO25BusyUpdateTimesec_A7574.HiddenDynamic;
			}
			set
			{
				short num = (short)2057782031;
				short num2 = num;
				num = (short)1984905999;
				switch (num2 == num)
				{
				}
				num = (short)973996032;
				if (num != 0)
				{
				}
				num = (short)1947336705;
				if (num != 0)
				{
				}
				num = (short)641597440;
				short num3 = num;
				this.trkSysASTRO25BusyUpdateTimesec_A7574.HiddenDynamic = value;
			}
		}

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x0600094D RID: 2381 RVA: 0x0008DD40 File Offset: 0x0008BF40
		public bool TrkSysASTRO25BusyUpdateTimesec_A7574_HasDiffs
		{
			get
			{
				short num = (short)207668196;
				short num2 = num;
				num = (short)1038402532;
				switch (num2 == num)
				{
				}
				num = (short)911671297;
				if (num != 0)
				{
				}
				num = (short)922550272;
				if (num != 0)
				{
				}
				num = (short)708116480;
				short num3 = num;
				return this.trkSysASTRO25BusyUpdateTimesec_A7574._HasDiffs;
			}
		}

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x0600094E RID: 2382 RVA: 0x0008DDF4 File Offset: 0x0008BFF4
		// (set) Token: 0x0600094F RID: 2383 RVA: 0x0008DEA8 File Offset: 0x0008C0A8
		public int TrkSysASTRO25DefaultRCMAddress_A7813Value
		{
			get
			{
				short num = (short)1029593798;
				short num2 = num;
				num = (short)634542790;
				switch (num2 == num)
				{
				}
				num = (short)1669005313;
				if (num != 0)
				{
				}
				num = (short)1479671808;
				if (num != 0)
				{
				}
				num = (short)395182080;
				short num3 = num;
				return this.trkSysASTRO25DefaultRCMAddress_A7813.Value;
			}
			set
			{
				short num = (short)116753018;
				short num2 = num;
				num = (short)1915060858;
				switch (num2 == num)
				{
				}
				num = (short)1841561600;
				if (num != 0)
				{
				}
				num = (short)1857159169;
				if (num != 0)
				{
				}
				num = (short)2032861184;
				short num3 = num;
				this.trkSysASTRO25DefaultRCMAddress_A7813.Value = value;
			}
		}

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x06000950 RID: 2384 RVA: 0x0008DF5C File Offset: 0x0008C15C
		public global::AcpBusinessLayer.AcpSimpleRangeField TrkSysASTRO25DefaultRCMAddress_A7813
		{
			get
			{
				short num = (short)853712304;
				short num2 = num;
				num = (short)1766694320;
				switch (num2 == num)
				{
				}
				num = (short)1005453313;
				if (num != 0)
				{
				}
				num = (short)1005387776;
				if (num != 0)
				{
				}
				num = (short)1877016576;
				short num3 = num;
				return this.trkSysASTRO25DefaultRCMAddress_A7813;
			}
		}

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x06000951 RID: 2385 RVA: 0x0008E00C File Offset: 0x0008C20C
		// (set) Token: 0x06000952 RID: 2386 RVA: 0x0008E0BC File Offset: 0x0008C2BC
		public string TrkSysASTRO25DefaultRCMAddress_A7813_UIValue
		{
			get
			{
				short num = (short)1592212168;
				short num2 = num;
				num = (short)1488665288;
				switch (num2 == num)
				{
				}
				num = (short)1374093313;
				if (num != 0)
				{
				}
				num = (short)1749483520;
				if (num != 0)
				{
				}
				num = (short)1523384320;
				short num3 = num;
				return this.trkSysASTRO25DefaultRCMAddress_A7813.UIValue;
			}
			set
			{
				short num = (short)1313614192;
				short num2 = num;
				num = (short)1159145840;
				switch (num2 == num)
				{
				}
				num = (short)202440705;
				if (num != 0)
				{
				}
				num = (short)397410304;
				if (num != 0)
				{
				}
				num = (short)1329332224;
				short num3 = num;
				this.trkSysASTRO25DefaultRCMAddress_A7813.UIValue = value;
			}
		}

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x06000953 RID: 2387 RVA: 0x0008E170 File Offset: 0x0008C370
		// (set) Token: 0x06000954 RID: 2388 RVA: 0x0008E224 File Offset: 0x0008C424
		public string TrkSysASTRO25DefaultRCMAddress_A7813_HexUIValue
		{
			get
			{
				short num = (short)962881115;
				short num2 = num;
				num = (short)1221224027;
				switch (num2 == num)
				{
				}
				num = (short)1543634944;
				if (num != 0)
				{
				}
				num = (short)325517313;
				if (num != 0)
				{
				}
				num = (short)284688384;
				short num3 = num;
				return this.trkSysASTRO25DefaultRCMAddress_A7813.HexUIValue;
			}
			set
			{
				short num = (short)1350802792;
				short num2 = num;
				num = (short)1780522344;
				switch (num2 == num)
				{
				}
				num = (short)622592001;
				if (num != 0)
				{
				}
				num = (short)1918697472;
				if (num != 0)
				{
				}
				num = (short)567476224;
				short num3 = num;
				this.trkSysASTRO25DefaultRCMAddress_A7813.HexUIValue = value;
			}
		}

		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x06000955 RID: 2389 RVA: 0x0008E2DC File Offset: 0x0008C4DC
		// (set) Token: 0x06000956 RID: 2390 RVA: 0x0008E390 File Offset: 0x0008C590
		internal int TrkSysASTRO25DefaultRCMAddress_A7813Min
		{
			get
			{
				short num = (short)1729698121;
				short num2 = num;
				num = (short)21109065;
				switch (num2 == num)
				{
				}
				num = (short)1940258816;
				if (num != 0)
				{
				}
				num = (short)1762590721;
				if (num != 0)
				{
				}
				num = (short)1828978688;
				short num3 = num;
				return this.trkSysASTRO25DefaultRCMAddress_A7813.Min;
			}
			set
			{
				short num = (short)2031704084;
				short num2 = num;
				num = (short)773675028;
				switch (num2 == num)
				{
				}
				num = (short)1351942144;
				if (num != 0)
				{
				}
				num = (short)1517486081;
				if (num != 0)
				{
				}
				num = (short)259784704;
				short num3 = num;
				this.trkSysASTRO25DefaultRCMAddress_A7813.Min = value;
			}
		}

		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x06000957 RID: 2391 RVA: 0x0008E44C File Offset: 0x0008C64C
		// (set) Token: 0x06000958 RID: 2392 RVA: 0x0008E500 File Offset: 0x0008C700
		internal int TrkSysASTRO25DefaultRCMAddress_A7813Max
		{
			get
			{
				short num = (short)1452140988;
				short num2 = num;
				num = (short)1153624508;
				switch (num2 == num)
				{
				}
				num = (short)300613632;
				if (num != 0)
				{
				}
				num = (short)1979187201;
				if (num != 0)
				{
				}
				num = (short)672530432;
				short num3 = num;
				return this.trkSysASTRO25DefaultRCMAddress_A7813.Max;
			}
			set
			{
				short num = (short)4333336;
				short num2 = num;
				num = (short)858988312;
				switch (num2 == num)
				{
				}
				num = (short)299565057;
				if (num != 0)
				{
				}
				num = (short)1600520192;
				if (num != 0)
				{
				}
				num = (short)1336082432;
				short num3 = num;
				this.trkSysASTRO25DefaultRCMAddress_A7813.Max = value;
			}
		}

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x06000959 RID: 2393 RVA: 0x0008E5B4 File Offset: 0x0008C7B4
		// (set) Token: 0x0600095A RID: 2394 RVA: 0x0008E668 File Offset: 0x0008C868
		internal int TrkSysASTRO25DefaultRCMAddress_A7813Step
		{
			get
			{
				short num = (short)227243814;
				short num2 = num;
				num = (short)1282438950;
				switch (num2 == num)
				{
				}
				num = (short)591134720;
				if (num != 0)
				{
				}
				num = (short)781451265;
				if (num != 0)
				{
				}
				num = (short)56623104;
				short num3 = num;
				return this.trkSysASTRO25DefaultRCMAddress_A7813.StepSize;
			}
			set
			{
				short num = (short)522649601;
				if (num != 0)
				{
				}
				num = (short)1998833166;
				short num2 = num;
				num = (short)1296287246;
				switch (num2 == num)
				{
				}
				num = (short)1847721984;
				if (num != 0)
				{
				}
				num = (short)1917321216;
				short num3 = num;
				this.trkSysASTRO25DefaultRCMAddress_A7813.StepSize = value;
			}
		}

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x0600095B RID: 2395 RVA: 0x0008E720 File Offset: 0x0008C920
		// (set) Token: 0x0600095C RID: 2396 RVA: 0x0008E7D4 File Offset: 0x0008C9D4
		public bool TrkSysASTRO25DefaultRCMAddress_A7813_Applicable
		{
			get
			{
				short num = (short)1444793330;
				short num2 = num;
				num = (short)2029505522;
				switch (num2 == num)
				{
				}
				num = (short)532938752;
				if (num != 0)
				{
				}
				num = (short)1562050561;
				if (num != 0)
				{
				}
				num = (short)635699200;
				short num3 = num;
				return this.trkSysASTRO25DefaultRCMAddress_A7813.Applicable;
			}
			set
			{
				short num = (short)1667316259;
				short num2 = num;
				num = (short)1828207139;
				switch (num2 == num)
				{
				}
				num = (short)1403387905;
				if (num != 0)
				{
				}
				num = (short)584450048;
				if (num != 0)
				{
				}
				num = (short)433651712;
				short num3 = num;
				this.trkSysASTRO25DefaultRCMAddress_A7813.Applicable = value;
			}
		}

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x0600095D RID: 2397 RVA: 0x0008E888 File Offset: 0x0008CA88
		// (set) Token: 0x0600095E RID: 2398 RVA: 0x0008E93C File Offset: 0x0008CB3C
		public bool TrkSysASTRO25DefaultRCMAddress_A7813_Valid
		{
			get
			{
				short num = (short)1256826960;
				short num2 = num;
				num = (short)1652271184;
				switch (num2 == num)
				{
				}
				num = (short)1861615616;
				if (num != 0)
				{
				}
				num = (short)1161035777;
				if (num != 0)
				{
				}
				num = (short)31064064;
				short num3 = num;
				return this.trkSysASTRO25DefaultRCMAddress_A7813.Valid;
			}
			set
			{
				short num = (short)577881973;
				short num2 = num;
				num = (short)2075838325;
				switch (num2 == num)
				{
				}
				num = (short)1833041921;
				if (num != 0)
				{
				}
				num = (short)1172701184;
				if (num != 0)
				{
				}
				num = (short)959381504;
				short num3 = num;
				this.trkSysASTRO25DefaultRCMAddress_A7813.Valid = value;
			}
		}

		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x0600095F RID: 2399 RVA: 0x0008E9F4 File Offset: 0x0008CBF4
		// (set) Token: 0x06000960 RID: 2400 RVA: 0x0008EAA8 File Offset: 0x0008CCA8
		public bool TrkSysASTRO25DefaultRCMAddress_A7813_Visible
		{
			get
			{
				short num = (short)1367327379;
				short num2 = num;
				num = (short)146064019;
				switch (num2 == num)
				{
				}
				num = (short)1811677185;
				if (num != 0)
				{
				}
				num = (short)1433468928;
				if (num != 0)
				{
				}
				num = (short)369098752;
				short num3 = num;
				return this.trkSysASTRO25DefaultRCMAddress_A7813.Visible;
			}
			set
			{
				short num = (short)755283218;
				short num2 = num;
				num = (short)1658303762;
				switch (num2 == num)
				{
				}
				num = (short)2112552961;
				if (num != 0)
				{
				}
				num = (short)1418592256;
				if (num != 0)
				{
				}
				num = (short)2072576000;
				short num3 = num;
				this.trkSysASTRO25DefaultRCMAddress_A7813.Visible = value;
			}
		}

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x06000961 RID: 2401 RVA: 0x0008EB5C File Offset: 0x0008CD5C
		// (set) Token: 0x06000962 RID: 2402 RVA: 0x0008EC10 File Offset: 0x0008CE10
		public bool TrkSysASTRO25DefaultRCMAddress_A7813_Editable
		{
			get
			{
				short num = (short)956017637;
				short num2 = num;
				num = (short)646949861;
				switch (num2 == num)
				{
				}
				num = (short)568393729;
				if (num != 0)
				{
				}
				num = (short)426049536;
				if (num != 0)
				{
				}
				num = (short)20054016;
				short num3 = num;
				return this.trkSysASTRO25DefaultRCMAddress_A7813.Editable;
			}
			set
			{
				short num = (short)175576291;
				short num2 = num;
				num = (short)102634723;
				switch (num2 == num)
				{
				}
				num = (short)248578049;
				if (num != 0)
				{
				}
				num = (short)2080112640;
				if (num != 0)
				{
				}
				num = (short)941424640;
				short num3 = num;
				this.trkSysASTRO25DefaultRCMAddress_A7813.Editable = value;
			}
		}

		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x06000963 RID: 2403 RVA: 0x0008ECC8 File Offset: 0x0008CEC8
		internal string TrkSysASTRO25DefaultRCMAddress_A7813_UILabel
		{
			get
			{
				short num = (short)1635319809;
				if (num != 0)
				{
				}
				num = (short)1229469056;
				short num2 = num;
				num = (short)1036989824;
				switch (num2 == num)
				{
				}
				num = (short)2012938240;
				if (num != 0)
				{
				}
				num = (short)1849163776;
				short num3 = num;
				return this.trkSysASTRO25DefaultRCMAddress_A7813.UIName;
			}
		}

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x06000964 RID: 2404 RVA: 0x0008ED7C File Offset: 0x0008CF7C
		// (set) Token: 0x06000965 RID: 2405 RVA: 0x0008EE34 File Offset: 0x0008D034
		internal bool TrkSysASTRO25DefaultRCMAddress_A7813_HiddenStatic
		{
			get
			{
				short num = (short)710973384;
				short num2 = num;
				num = (short)304060360;
				switch (num2 == num)
				{
				}
				num = (short)1194852352;
				if (num != 0)
				{
				}
				num = (short)794624001;
				if (num != 0)
				{
				}
				num = (short)1447755776;
				short num3 = num;
				return this.trkSysASTRO25DefaultRCMAddress_A7813.HiddenStatic;
			}
			set
			{
				short num = (short)1955594241;
				if (num != 0)
				{
				}
				num = (short)1559079525;
				short num2 = num;
				num = (short)698853989;
				switch (num2 == num)
				{
				}
				num = (short)740229120;
				if (num != 0)
				{
				}
				num = (short)1357643776;
				short num3 = num;
				this.trkSysASTRO25DefaultRCMAddress_A7813.HiddenStatic = value;
			}
		}

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x06000966 RID: 2406 RVA: 0x0008EEEC File Offset: 0x0008D0EC
		// (set) Token: 0x06000967 RID: 2407 RVA: 0x0008EFA0 File Offset: 0x0008D1A0
		internal bool TrkSysASTRO25DefaultRCMAddress_A7813_HiddenDynamic
		{
			get
			{
				short num = (short)1745352324;
				short num2 = num;
				num = (short)1126626948;
				switch (num2 == num)
				{
				}
				num = (short)227475456;
				if (num != 0)
				{
				}
				num = (short)306774017;
				if (num != 0)
				{
				}
				num = (short)272564224;
				short num3 = num;
				return this.trkSysASTRO25DefaultRCMAddress_A7813.HiddenDynamic;
			}
			set
			{
				short num = (short)852426753;
				if (num != 0)
				{
				}
				num = (short)1161822408;
				short num2 = num;
				num = (short)182386888;
				switch (num2 == num)
				{
				}
				num = (short)1900544000;
				if (num != 0)
				{
				}
				num = (short)1177288704;
				short num3 = num;
				this.trkSysASTRO25DefaultRCMAddress_A7813.HiddenDynamic = value;
			}
		}

		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x06000968 RID: 2408 RVA: 0x0008F054 File Offset: 0x0008D254
		public bool TrkSysASTRO25DefaultRCMAddress_A7813_HasDiffs
		{
			get
			{
				short num = (short)1516405952;
				short num2 = num;
				num = (short)1444906176;
				switch (num2 == num)
				{
				}
				num = (short)1498742785;
				if (num != 0)
				{
				}
				num = (short)1191772160;
				if (num != 0)
				{
				}
				num = (short)1039925248;
				short num3 = num;
				return this.trkSysASTRO25DefaultRCMAddress_A7813._HasDiffs;
			}
		}

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x06000969 RID: 2409 RVA: 0x0008F10C File Offset: 0x0008D30C
		// (set) Token: 0x0600096A RID: 2410 RVA: 0x0008F1C0 File Offset: 0x0008D3C0
		public int TrkSysASTRO25ForceUnmuteTimems_A8141Value
		{
			get
			{
				short num = (short)1039487114;
				short num2 = num;
				num = (short)169234570;
				switch (num2 == num)
				{
				}
				num = (short)525336577;
				if (num != 0)
				{
				}
				num = (short)1249902592;
				if (num != 0)
				{
				}
				num = (short)1553268736;
				short num3 = num;
				return this.trkSysASTRO25ForceUnmuteTimems_A8141.Value;
			}
			set
			{
				short num = (short)580697542;
				short num2 = num;
				num = (short)1932770758;
				switch (num2 == num)
				{
				}
				num = (short)1409613825;
				if (num != 0)
				{
				}
				num = (short)2146762752;
				if (num != 0)
				{
				}
				num = (short)1451425792;
				short num3 = num;
				this.trkSysASTRO25ForceUnmuteTimems_A8141.Value = value;
			}
		}

		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x0600096B RID: 2411 RVA: 0x0008F274 File Offset: 0x0008D474
		public global::AcpBusinessLayer.AcpSimpleRangeField TrkSysASTRO25ForceUnmuteTimems_A8141
		{
			get
			{
				short num = (short)719696133;
				short num2 = num;
				num = (short)386380037;
				switch (num2 == num)
				{
				}
				num = (short)1049165824;
				if (num != 0)
				{
				}
				num = (short)1425670145;
				if (num != 0)
				{
				}
				num = (short)1625227264;
				short num3 = num;
				return this.trkSysASTRO25ForceUnmuteTimems_A8141;
			}
		}

		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x0600096C RID: 2412 RVA: 0x0008F320 File Offset: 0x0008D520
		// (set) Token: 0x0600096D RID: 2413 RVA: 0x0008F3D4 File Offset: 0x0008D5D4
		public string TrkSysASTRO25ForceUnmuteTimems_A8141_UIValue
		{
			get
			{
				short num = (short)642631827;
				short num2 = num;
				num = (short)1041287315;
				switch (num2 == num)
				{
				}
				num = (short)2087387136;
				short num3 = num;
				num = (short)337641473;
				if (num != 0)
				{
				}
				num = (short)171442176;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ForceUnmuteTimems_A8141.UIValue;
			}
			set
			{
				short num = (short)326031348;
				short num2 = num;
				num = (short)247781364;
				switch (num2 == num)
				{
				}
				num = (short)981991424;
				short num3 = num;
				num = (short)1874722816;
				if (num != 0)
				{
				}
				num = (short)177537025;
				if (num != 0)
				{
				}
				this.trkSysASTRO25ForceUnmuteTimems_A8141.UIValue = value;
			}
		}

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x0600096E RID: 2414 RVA: 0x0008F488 File Offset: 0x0008D688
		// (set) Token: 0x0600096F RID: 2415 RVA: 0x0008F53C File Offset: 0x0008D73C
		internal int TrkSysASTRO25ForceUnmuteTimems_A8141Min
		{
			get
			{
				short num = (short)1884353386;
				short num2 = num;
				num = (short)663090026;
				switch (num2 == num)
				{
				}
				num = (short)1352138752;
				short num3 = num;
				num = (short)207552512;
				if (num != 0)
				{
				}
				num = (short)600244225;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ForceUnmuteTimems_A8141.Min;
			}
			set
			{
				short num = (short)534626774;
				short num2 = num;
				num = (short)160219606;
				switch (num2 == num)
				{
				}
				num = (short)505741312;
				short num3 = num;
				num = (short)1248002049;
				if (num != 0)
				{
				}
				num = (short)181075968;
				if (num != 0)
				{
				}
				this.trkSysASTRO25ForceUnmuteTimems_A8141.Min = value;
			}
		}

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x06000970 RID: 2416 RVA: 0x0008F5F0 File Offset: 0x0008D7F0
		// (set) Token: 0x06000971 RID: 2417 RVA: 0x0008F6A8 File Offset: 0x0008D8A8
		internal int TrkSysASTRO25ForceUnmuteTimems_A8141Max
		{
			get
			{
				short num = (short)1222377473;
				if (num != 0)
				{
				}
				num = (short)1215288083;
				short num2 = num;
				num = (short)757125907;
				switch (num2 == num)
				{
				default:
				{
					num = (short)647692288;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)491257856;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ForceUnmuteTimems_A8141.Max;
			}
			set
			{
				short num = (short)714077906;
				short num2 = num;
				num = (short)923858642;
				switch (num2 == num)
				{
				}
				num = (short)1586692096;
				short num3 = num;
				num = (short)161021953;
				if (num != 0)
				{
				}
				num = (short)874053632;
				if (num != 0)
				{
				}
				this.trkSysASTRO25ForceUnmuteTimems_A8141.Max = value;
			}
		}

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x06000972 RID: 2418 RVA: 0x0008F75C File Offset: 0x0008D95C
		// (set) Token: 0x06000973 RID: 2419 RVA: 0x0008F814 File Offset: 0x0008DA14
		internal int TrkSysASTRO25ForceUnmuteTimems_A8141Step
		{
			get
			{
				short num = (short)293249966;
				short num2 = num;
				num = (short)2119738286;
				switch (num2 == num)
				{
				}
				num = (short)735182848;
				short num3 = num;
				num = (short)1252196352;
				if (num != 0)
				{
				}
				num = (short)209453057;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ForceUnmuteTimems_A8141.StepSize;
			}
			set
			{
				short num = (short)1813047426;
				short num2 = num;
				num = (short)532998274;
				switch (num2 == num)
				{
				}
				num = (short)2040135680;
				short num3 = num;
				num = (short)1244987393;
				if (num != 0)
				{
				}
				num = (short)1615724544;
				if (num != 0)
				{
				}
				this.trkSysASTRO25ForceUnmuteTimems_A8141.StepSize = value;
			}
		}

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x06000974 RID: 2420 RVA: 0x0008F8CC File Offset: 0x0008DACC
		// (set) Token: 0x06000975 RID: 2421 RVA: 0x0008F984 File Offset: 0x0008DB84
		public bool TrkSysASTRO25ForceUnmuteTimems_A8141_Applicable
		{
			get
			{
				short num = (short)1371913475;
				short num2 = num;
				num = (short)21544195;
				switch (num2 == num)
				{
				}
				num = (short)1815412736;
				short num3 = num;
				num = (short)1622081536;
				if (num != 0)
				{
				}
				num = (short)1705771009;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ForceUnmuteTimems_A8141.Applicable;
			}
			set
			{
				short num = (short)1633222657;
				if (num != 0)
				{
				}
				num = (short)200187076;
				short num2 = num;
				num = (short)1345100996;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2086862848;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1691680768;
				if (num != 0)
				{
				}
				this.trkSysASTRO25ForceUnmuteTimems_A8141.Applicable = value;
			}
		}

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x06000976 RID: 2422 RVA: 0x0008FA34 File Offset: 0x0008DC34
		// (set) Token: 0x06000977 RID: 2423 RVA: 0x0008FAE8 File Offset: 0x0008DCE8
		public bool TrkSysASTRO25ForceUnmuteTimems_A8141_Valid
		{
			get
			{
				short num = (short)1616296988;
				short num2 = num;
				num = (short)381664284;
				switch (num2 == num)
				{
				}
				num = (short)1460666368;
				short num3 = num;
				num = (short)823984128;
				if (num != 0)
				{
				}
				num = (short)1415249921;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ForceUnmuteTimems_A8141.Valid;
			}
			set
			{
				short num = (short)503139207;
				short num2 = num;
				num = (short)1717455751;
				switch (num2 == num)
				{
				}
				num = (short)1612513280;
				short num3 = num;
				num = (short)1799159809;
				if (num != 0)
				{
				}
				num = (short)485031936;
				if (num != 0)
				{
				}
				this.trkSysASTRO25ForceUnmuteTimems_A8141.Valid = value;
			}
		}

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x06000978 RID: 2424 RVA: 0x0008FBA0 File Offset: 0x0008DDA0
		// (set) Token: 0x06000979 RID: 2425 RVA: 0x0008FC58 File Offset: 0x0008DE58
		public bool TrkSysASTRO25ForceUnmuteTimems_A8141_Visible
		{
			get
			{
				short num = (short)765788161;
				if (num != 0)
				{
				}
				num = (short)932546856;
				short num2 = num;
				num = (short)452167976;
				switch (num2 == num)
				{
				default:
				{
					num = (short)805699584;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2018902016;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ForceUnmuteTimems_A8141.Visible;
			}
			set
			{
				short num = (short)375259824;
				short num2 = num;
				num = (short)1954677424;
				switch (num2 == num)
				{
				}
				num = (short)62783488;
				short num3 = num;
				num = (short)1290272768;
				if (num != 0)
				{
				}
				num = (short)578682881;
				if (num != 0)
				{
				}
				this.trkSysASTRO25ForceUnmuteTimems_A8141.Visible = value;
			}
		}

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x0600097A RID: 2426 RVA: 0x0008FD10 File Offset: 0x0008DF10
		// (set) Token: 0x0600097B RID: 2427 RVA: 0x0008FDC4 File Offset: 0x0008DFC4
		public bool TrkSysASTRO25ForceUnmuteTimems_A8141_Editable
		{
			get
			{
				short num = (short)1988689099;
				short num2 = num;
				num = (short)579402955;
				switch (num2 == num)
				{
				}
				num = (short)1249640448;
				short num3 = num;
				num = (short)715587584;
				if (num != 0)
				{
				}
				num = (short)8388609;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ForceUnmuteTimems_A8141.Editable;
			}
			set
			{
				short num = (short)1726591314;
				short num2 = num;
				num = (short)587051346;
				switch (num2 == num)
				{
				}
				num = (short)676855808;
				short num3 = num;
				num = (short)166526977;
				if (num != 0)
				{
				}
				num = (short)2061697024;
				if (num != 0)
				{
				}
				this.trkSysASTRO25ForceUnmuteTimems_A8141.Editable = value;
			}
		}

		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x0600097C RID: 2428 RVA: 0x0008FE7C File Offset: 0x0008E07C
		internal string TrkSysASTRO25ForceUnmuteTimems_A8141_UILabel
		{
			get
			{
				short num = (short)56623105;
				if (num != 0)
				{
				}
				num = (short)1072567229;
				short num2 = num;
				num = (short)1875121085;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2086993920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1751973888;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ForceUnmuteTimems_A8141.UIName;
			}
		}

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x0600097D RID: 2429 RVA: 0x0008FF30 File Offset: 0x0008E130
		// (set) Token: 0x0600097E RID: 2430 RVA: 0x0008FFE8 File Offset: 0x0008E1E8
		internal bool TrkSysASTRO25ForceUnmuteTimems_A8141_HiddenStatic
		{
			get
			{
				short num = (short)653659252;
				short num2 = num;
				num = (short)1748962420;
				switch (num2 == num)
				{
				}
				num = (short)1937047552;
				short num3 = num;
				num = (short)1557659648;
				if (num != 0)
				{
				}
				num = (short)830406657;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ForceUnmuteTimems_A8141.HiddenStatic;
			}
			set
			{
				short num = (short)299265811;
				short num2 = num;
				num = (short)1734242067;
				switch (num2 == num)
				{
				}
				num = (short)1716060160;
				short num3 = num;
				num = (short)790036481;
				if (num != 0)
				{
				}
				num = (short)813694976;
				if (num != 0)
				{
				}
				this.trkSysASTRO25ForceUnmuteTimems_A8141.HiddenStatic = value;
			}
		}

		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x0600097F RID: 2431 RVA: 0x000900A0 File Offset: 0x0008E2A0
		// (set) Token: 0x06000980 RID: 2432 RVA: 0x00090154 File Offset: 0x0008E354
		internal bool TrkSysASTRO25ForceUnmuteTimems_A8141_HiddenDynamic
		{
			get
			{
				short num = (short)1689956427;
				short num2 = num;
				num = (short)1980477515;
				switch (num2 == num)
				{
				}
				num = (short)2137849856;
				short num3 = num;
				num = (short)1724645377;
				if (num != 0)
				{
				}
				num = (short)1499660288;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ForceUnmuteTimems_A8141.HiddenDynamic;
			}
			set
			{
				short num = (short)98790715;
				short num2 = num;
				num = (short)674590011;
				switch (num2 == num)
				{
				}
				num = (short)2069168128;
				short num3 = num;
				num = (short)1207697409;
				if (num != 0)
				{
				}
				num = (short)2124873728;
				if (num != 0)
				{
				}
				this.trkSysASTRO25ForceUnmuteTimems_A8141.HiddenDynamic = value;
			}
		}

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x06000981 RID: 2433 RVA: 0x0009020C File Offset: 0x0008E40C
		public bool TrkSysASTRO25ForceUnmuteTimems_A8141_HasDiffs
		{
			get
			{
				short num = (short)1388310323;
				short num2 = num;
				num = (short)670756659;
				switch (num2 == num)
				{
				}
				num = (short)1631649792;
				short num3 = num;
				num = (short)1349648385;
				if (num != 0)
				{
				}
				num = (short)748355584;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ForceUnmuteTimems_A8141._HasDiffs;
			}
		}

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x06000982 RID: 2434 RVA: 0x000902C0 File Offset: 0x0008E4C0
		// (set) Token: 0x06000983 RID: 2435 RVA: 0x00090374 File Offset: 0x0008E574
		public int TrkSysASTRO25ISPSequenceLengthsec_A8354Value
		{
			get
			{
				short num = (short)2013366754;
				short num2 = num;
				num = (short)129927650;
				switch (num2 == num)
				{
				}
				num = (short)1479409664;
				short num3 = num;
				num = (short)898301953;
				if (num != 0)
				{
				}
				num = (short)752680960;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ISPSequenceLengthsec_A8354.Value;
			}
			set
			{
				short num = (short)1415878441;
				short num2 = num;
				num = (short)361928489;
				switch (num2 == num)
				{
				}
				num = (short)1973420032;
				short num3 = num;
				num = (short)61276161;
				if (num != 0)
				{
				}
				num = (short)872677376;
				if (num != 0)
				{
				}
				this.trkSysASTRO25ISPSequenceLengthsec_A8354.Value = value;
			}
		}

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x06000984 RID: 2436 RVA: 0x00090430 File Offset: 0x0008E630
		public global::AcpBusinessLayer.AcpSimpleRangeField TrkSysASTRO25ISPSequenceLengthsec_A8354
		{
			get
			{
				short num = (short)1673375488;
				short num2 = num;
				num = (short)818851584;
				switch (num2 == num)
				{
				}
				num = (short)1620115456;
				short num3 = num;
				num = (short)180092929;
				if (num != 0)
				{
				}
				num = (short)115605504;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ISPSequenceLengthsec_A8354;
			}
		}

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x06000985 RID: 2437 RVA: 0x000904E0 File Offset: 0x0008E6E0
		// (set) Token: 0x06000986 RID: 2438 RVA: 0x00090594 File Offset: 0x0008E794
		public string TrkSysASTRO25ISPSequenceLengthsec_A8354_UIValue
		{
			get
			{
				short num = (short)1792484677;
				short num2 = num;
				num = (short)265364805;
				switch (num2 == num)
				{
				}
				num = (short)558563328;
				short num3 = num;
				num = (short)1456078849;
				if (num != 0)
				{
				}
				num = (short)2030764032;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ISPSequenceLengthsec_A8354.UIValue;
			}
			set
			{
				short num = (short)312863410;
				short num2 = num;
				num = (short)835906226;
				switch (num2 == num)
				{
				}
				num = (short)415236096;
				short num3 = num;
				num = (short)704053248;
				if (num != 0)
				{
				}
				num = (short)1261109249;
				if (num != 0)
				{
				}
				this.trkSysASTRO25ISPSequenceLengthsec_A8354.UIValue = value;
			}
		}

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x06000987 RID: 2439 RVA: 0x0009064C File Offset: 0x0008E84C
		// (set) Token: 0x06000988 RID: 2440 RVA: 0x00090700 File Offset: 0x0008E900
		internal int TrkSysASTRO25ISPSequenceLengthsec_A8354Min
		{
			get
			{
				short num = (short)1510011722;
				short num2 = num;
				num = (short)1015804746;
				switch (num2 == num)
				{
				}
				num = (short)1286995968;
				short num3 = num;
				num = (short)631177217;
				if (num != 0)
				{
				}
				num = (short)1399324672;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ISPSequenceLengthsec_A8354.Min;
			}
			set
			{
				short num = (short)2083275843;
				short num2 = num;
				num = (short)518734915;
				switch (num2 == num)
				{
				}
				num = (short)326172672;
				short num3 = num;
				num = (short)815529984;
				if (num != 0)
				{
				}
				num = (short)674824193;
				if (num != 0)
				{
				}
				this.trkSysASTRO25ISPSequenceLengthsec_A8354.Min = value;
			}
		}

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x06000989 RID: 2441 RVA: 0x000907B4 File Offset: 0x0008E9B4
		// (set) Token: 0x0600098A RID: 2442 RVA: 0x00090868 File Offset: 0x0008EA68
		internal int TrkSysASTRO25ISPSequenceLengthsec_A8354Max
		{
			get
			{
				short num = (short)1859397799;
				short num2 = num;
				num = (short)798894247;
				switch (num2 == num)
				{
				}
				num = (short)2017656832;
				short num3 = num;
				num = (short)564723713;
				if (num != 0)
				{
				}
				num = (short)871825408;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ISPSequenceLengthsec_A8354.Max;
			}
			set
			{
				short num = (short)355197338;
				short num2 = num;
				num = (short)419488154;
				switch (num2 == num)
				{
				}
				num = (short)1181876224;
				short num3 = num;
				num = (short)1128857601;
				if (num != 0)
				{
				}
				num = (short)954597376;
				if (num != 0)
				{
				}
				this.trkSysASTRO25ISPSequenceLengthsec_A8354.Max = value;
			}
		}

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x0600098B RID: 2443 RVA: 0x00090920 File Offset: 0x0008EB20
		// (set) Token: 0x0600098C RID: 2444 RVA: 0x000909D4 File Offset: 0x0008EBD4
		internal int TrkSysASTRO25ISPSequenceLengthsec_A8354Step
		{
			get
			{
				short num = (short)574442717;
				short num2 = num;
				num = (short)1884048605;
				switch (num2 == num)
				{
				}
				num = (short)457637888;
				short num3 = num;
				num = (short)403636224;
				if (num != 0)
				{
				}
				num = (short)1862270977;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ISPSequenceLengthsec_A8354.StepSize;
			}
			set
			{
				short num = (short)1916033922;
				short num2 = num;
				num = (short)1467833218;
				switch (num2 == num)
				{
				}
				num = (short)1411055616;
				short num3 = num;
				num = (short)88932353;
				if (num != 0)
				{
				}
				num = (short)1668349952;
				if (num != 0)
				{
				}
				this.trkSysASTRO25ISPSequenceLengthsec_A8354.StepSize = value;
			}
		}

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x0600098D RID: 2445 RVA: 0x00090A88 File Offset: 0x0008EC88
		// (set) Token: 0x0600098E RID: 2446 RVA: 0x00090B38 File Offset: 0x0008ED38
		public bool TrkSysASTRO25ISPSequenceLengthsec_A8354_Applicable
		{
			get
			{
				short num = (short)89391105;
				if (num != 0)
				{
				}
				num = (short)649045774;
				short num2 = num;
				num = (short)1590339342;
				switch (num2 == num)
				{
				default:
				{
					num = (short)538705920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1070202880;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ISPSequenceLengthsec_A8354.Applicable;
			}
			set
			{
				short num = (short)2039947560;
				short num2 = num;
				num = (short)194191656;
				switch (num2 == num)
				{
				}
				num = (short)928514048;
				short num3 = num;
				num = (short)1260716033;
				if (num != 0)
				{
				}
				num = (short)563478528;
				if (num != 0)
				{
				}
				this.trkSysASTRO25ISPSequenceLengthsec_A8354.Applicable = value;
			}
		}

		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x0600098F RID: 2447 RVA: 0x00090BEC File Offset: 0x0008EDEC
		// (set) Token: 0x06000990 RID: 2448 RVA: 0x00090CA0 File Offset: 0x0008EEA0
		public bool TrkSysASTRO25ISPSequenceLengthsec_A8354_Valid
		{
			get
			{
				short num = (short)1493255972;
				short num2 = num;
				num = (short)1392396068;
				switch (num2 == num)
				{
				}
				num = (short)1450246144;
				short num3 = num;
				num = (short)87687169;
				if (num != 0)
				{
				}
				num = (short)646381568;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ISPSequenceLengthsec_A8354.Valid;
			}
			set
			{
				short num = (short)155026363;
				short num2 = num;
				num = (short)2093908923;
				switch (num2 == num)
				{
				}
				num = (short)1897529344;
				short num3 = num;
				num = (short)943259648;
				if (num != 0)
				{
				}
				num = (short)1379074049;
				if (num != 0)
				{
				}
				this.trkSysASTRO25ISPSequenceLengthsec_A8354.Valid = value;
			}
		}

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x06000991 RID: 2449 RVA: 0x00090D54 File Offset: 0x0008EF54
		// (set) Token: 0x06000992 RID: 2450 RVA: 0x00090E0C File Offset: 0x0008F00C
		public bool TrkSysASTRO25ISPSequenceLengthsec_A8354_Visible
		{
			get
			{
				short num = (short)1216676919;
				short num2 = num;
				num = (short)1386021943;
				switch (num2 == num)
				{
				}
				num = (short)1586823168;
				short num3 = num;
				num = (short)158466049;
				if (num != 0)
				{
				}
				num = (short)756285440;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ISPSequenceLengthsec_A8354.Visible;
			}
			set
			{
				short num = (short)1411774686;
				short num2 = num;
				num = (short)1198520542;
				switch (num2 == num)
				{
				}
				num = (short)1922564096;
				short num3 = num;
				num = (short)1873215488;
				if (num != 0)
				{
				}
				num = (short)1298989057;
				if (num != 0)
				{
				}
				this.trkSysASTRO25ISPSequenceLengthsec_A8354.Visible = value;
			}
		}

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x06000993 RID: 2451 RVA: 0x00090EC0 File Offset: 0x0008F0C0
		// (set) Token: 0x06000994 RID: 2452 RVA: 0x00090F74 File Offset: 0x0008F174
		public bool TrkSysASTRO25ISPSequenceLengthsec_A8354_Editable
		{
			get
			{
				short num = (short)2054964048;
				short num2 = num;
				num = (short)1914192720;
				switch (num2 == num)
				{
				}
				num = (short)373227520;
				short num3 = num;
				num = (short)2122645505;
				if (num != 0)
				{
				}
				num = (short)1472462848;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ISPSequenceLengthsec_A8354.Editable;
			}
			set
			{
				short num = (short)1681915905;
				if (num != 0)
				{
				}
				num = (short)1200293026;
				short num2 = num;
				num = (short)1630733474;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1713045504;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1900216320;
				if (num != 0)
				{
				}
				this.trkSysASTRO25ISPSequenceLengthsec_A8354.Editable = value;
			}
		}

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x06000995 RID: 2453 RVA: 0x0009102C File Offset: 0x0008F22C
		internal string TrkSysASTRO25ISPSequenceLengthsec_A8354_UILabel
		{
			get
			{
				short num = (short)1789189875;
				short num2 = num;
				num = (short)1047846643;
				switch (num2 == num)
				{
				}
				num = (short)1780154368;
				short num3 = num;
				num = (short)53346305;
				if (num != 0)
				{
				}
				num = (short)621805568;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ISPSequenceLengthsec_A8354.UIName;
			}
		}

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x06000996 RID: 2454 RVA: 0x000910DC File Offset: 0x0008F2DC
		// (set) Token: 0x06000997 RID: 2455 RVA: 0x00091194 File Offset: 0x0008F394
		internal bool TrkSysASTRO25ISPSequenceLengthsec_A8354_HiddenStatic
		{
			get
			{
				short num = (short)1808598416;
				short num2 = num;
				num = (short)1484981648;
				switch (num2 == num)
				{
				}
				num = (short)1018822656;
				short num3 = num;
				num = (short)599195648;
				if (num != 0)
				{
				}
				num = (short)961413121;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ISPSequenceLengthsec_A8354.HiddenStatic;
			}
			set
			{
				short num = (short)691673166;
				short num2 = num;
				num = (short)1991383118;
				switch (num2 == num)
				{
				}
				num = (short)1566507008;
				short num3 = num;
				num = (short)1520369665;
				if (num != 0)
				{
				}
				num = (short)1715535872;
				if (num != 0)
				{
				}
				this.trkSysASTRO25ISPSequenceLengthsec_A8354.HiddenStatic = value;
			}
		}

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x06000998 RID: 2456 RVA: 0x0009124C File Offset: 0x0008F44C
		// (set) Token: 0x06000999 RID: 2457 RVA: 0x00091300 File Offset: 0x0008F500
		internal bool TrkSysASTRO25ISPSequenceLengthsec_A8354_HiddenDynamic
		{
			get
			{
				short num = (short)38596552;
				short num2 = num;
				num = (short)1522855880;
				switch (num2 == num)
				{
				}
				num = (short)1734213632;
				short num3 = num;
				num = (short)134152193;
				if (num != 0)
				{
				}
				num = (short)1602289664;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ISPSequenceLengthsec_A8354.HiddenDynamic;
			}
			set
			{
				short num = (short)339790171;
				short num2 = num;
				num = (short)309447003;
				switch (num2 == num)
				{
				}
				num = (short)2111700992;
				short num3 = num;
				num = (short)295436289;
				if (num != 0)
				{
				}
				num = (short)433520640;
				if (num != 0)
				{
				}
				this.trkSysASTRO25ISPSequenceLengthsec_A8354.HiddenDynamic = value;
			}
		}

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x0600099A RID: 2458 RVA: 0x000913B8 File Offset: 0x0008F5B8
		public bool TrkSysASTRO25ISPSequenceLengthsec_A8354_HasDiffs
		{
			get
			{
				short num = (short)203795544;
				short num2 = num;
				num = (short)1914481752;
				switch (num2 == num)
				{
				}
				num = (short)1445003264;
				short num3 = num;
				num = (short)187105280;
				if (num != 0)
				{
				}
				num = (short)9830401;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ISPSequenceLengthsec_A8354._HasDiffs;
			}
		}

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x0600099B RID: 2459 RVA: 0x0009146C File Offset: 0x0008F66C
		// (set) Token: 0x0600099C RID: 2460 RVA: 0x00091520 File Offset: 0x0008F720
		public int TrkSysASTRO25MaximumSlotSizems_A8478Value
		{
			get
			{
				short num = (short)391774209;
				if (num != 0)
				{
				}
				num = (short)987796759;
				short num2 = num;
				num = (short)1817089303;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1474494464;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)837156864;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25MaximumSlotSizems_A8478.Value;
			}
			set
			{
				short num = (short)674540954;
				short num2 = num;
				num = (short)268152218;
				switch (num2 == num)
				{
				}
				num = (short)1162084352;
				short num3 = num;
				num = (short)1031208961;
				if (num != 0)
				{
				}
				num = (short)714145792;
				if (num != 0)
				{
				}
				this.trkSysASTRO25MaximumSlotSizems_A8478.Value = value;
			}
		}

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x0600099D RID: 2461 RVA: 0x000915D8 File Offset: 0x0008F7D8
		public global::AcpBusinessLayer.AcpCustomRangeField TrkSysASTRO25MaximumSlotSizems_A8478
		{
			get
			{
				short num = (short)929908018;
				short num2 = num;
				num = (short)1130841394;
				switch (num2 == num)
				{
				}
				num = (short)927334400;
				short num3 = num;
				num = (short)869990401;
				if (num != 0)
				{
				}
				num = (short)1012596736;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25MaximumSlotSizems_A8478;
			}
		}

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x0600099E RID: 2462 RVA: 0x00091688 File Offset: 0x0008F888
		// (set) Token: 0x0600099F RID: 2463 RVA: 0x00091738 File Offset: 0x0008F938
		public string TrkSysASTRO25MaximumSlotSizems_A8478_UIValue
		{
			get
			{
				short num = (short)959507722;
				short num2 = num;
				num = (short)1676406026;
				switch (num2 == num)
				{
				}
				num = (short)1144324096;
				short num3 = num;
				num = (short)229507072;
				if (num != 0)
				{
				}
				num = (short)1319305217;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25MaximumSlotSizems_A8478.UIValue;
			}
			set
			{
				short num = (short)1054505036;
				short num2 = num;
				num = (short)2048817228;
				switch (num2 == num)
				{
				}
				num = (short)553779200;
				short num3 = num;
				num = (short)1802240001;
				if (num != 0)
				{
				}
				num = (short)471465984;
				if (num != 0)
				{
				}
				this.trkSysASTRO25MaximumSlotSizems_A8478.UIValue = value;
			}
		}

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x060009A0 RID: 2464 RVA: 0x000917EC File Offset: 0x0008F9EC
		// (set) Token: 0x060009A1 RID: 2465 RVA: 0x000918A0 File Offset: 0x0008FAA0
		internal int TrkSysASTRO25MaximumSlotSizems_A8478Min
		{
			get
			{
				short num = (short)66576759;
				short num2 = num;
				num = (short)1747640695;
				switch (num2 == num)
				{
				}
				num = (short)858521600;
				short num3 = num;
				num = (short)770703360;
				if (num != 0)
				{
				}
				num = (short)1196818433;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25MaximumSlotSizems_A8478.Min;
			}
			set
			{
				short num = (short)551357819;
				short num2 = num;
				num = (short)870714747;
				switch (num2 == num)
				{
				}
				num = (short)206962688;
				short num3 = num;
				num = (short)1390084097;
				if (num != 0)
				{
				}
				num = (short)480116736;
				if (num != 0)
				{
				}
				this.trkSysASTRO25MaximumSlotSizems_A8478.Min = value;
			}
		}

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x060009A2 RID: 2466 RVA: 0x00091958 File Offset: 0x0008FB58
		// (set) Token: 0x060009A3 RID: 2467 RVA: 0x00091A0C File Offset: 0x0008FC0C
		internal int TrkSysASTRO25MaximumSlotSizems_A8478Max
		{
			get
			{
				short num = (short)1839219657;
				short num2 = num;
				num = (short)1275610057;
				switch (num2 == num)
				{
				}
				num = (short)1143406592;
				short num3 = num;
				num = (short)68681729;
				if (num != 0)
				{
				}
				num = (short)18808832;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25MaximumSlotSizems_A8478.Max;
			}
			set
			{
				short num = (short)1015667040;
				short num2 = num;
				num = (short)1386862944;
				switch (num2 == num)
				{
				}
				num = (short)341049345;
				if (num != 0)
				{
				}
				num = (short)1143209984;
				short num3 = num;
				num = (short)526188544;
				if (num != 0)
				{
				}
				this.trkSysASTRO25MaximumSlotSizems_A8478.Max = value;
			}
		}

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x060009A4 RID: 2468 RVA: 0x00091AC8 File Offset: 0x0008FCC8
		// (set) Token: 0x060009A5 RID: 2469 RVA: 0x00091B7C File Offset: 0x0008FD7C
		internal int TrkSysASTRO25MaximumSlotSizems_A8478Step
		{
			get
			{
				short num = (short)1544244754;
				short num2 = num;
				num = (short)764825106;
				switch (num2 == num)
				{
				}
				num = (short)1505492993;
				if (num != 0)
				{
				}
				num = (short)96272384;
				short num3 = num;
				num = (short)37289984;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25MaximumSlotSizems_A8478.StepSize;
			}
			set
			{
				short num = (short)972905536;
				short num2 = num;
				num = (short)1003445312;
				switch (num2 == num)
				{
				}
				num = (short)1874067457;
				if (num != 0)
				{
				}
				num = (short)445251584;
				short num3 = num;
				num = (short)1411448832;
				if (num != 0)
				{
				}
				this.trkSysASTRO25MaximumSlotSizems_A8478.StepSize = value;
			}
		}

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x060009A6 RID: 2470 RVA: 0x00091C34 File Offset: 0x0008FE34
		// (set) Token: 0x060009A7 RID: 2471 RVA: 0x00091CE8 File Offset: 0x0008FEE8
		public bool TrkSysASTRO25MaximumSlotSizems_A8478_Applicable
		{
			get
			{
				short num = (short)57217749;
				short num2 = num;
				num = (short)260772565;
				switch (num2 == num)
				{
				}
				num = (short)1494548481;
				if (num != 0)
				{
				}
				num = (short)1335689216;
				short num3 = num;
				num = (short)880214016;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25MaximumSlotSizems_A8478.Applicable;
			}
			set
			{
				short num = (short)1176481230;
				short num2 = num;
				num = (short)1635823054;
				switch (num2 == num)
				{
				}
				num = (short)1118371840;
				if (num != 0)
				{
				}
				num = (short)743178240;
				short num3 = num;
				num = (short)672530433;
				if (num != 0)
				{
				}
				this.trkSysASTRO25MaximumSlotSizems_A8478.Applicable = value;
			}
		}

		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x060009A8 RID: 2472 RVA: 0x00091DA0 File Offset: 0x0008FFA0
		// (set) Token: 0x060009A9 RID: 2473 RVA: 0x00091E58 File Offset: 0x00090058
		public bool TrkSysASTRO25MaximumSlotSizems_A8478_Valid
		{
			get
			{
				short num = (short)666438688;
				short num2 = num;
				num = (short)1560480800;
				switch (num2 == num)
				{
				}
				num = (short)32833537;
				if (num != 0)
				{
				}
				num = (short)857014272;
				short num3 = num;
				num = (short)493420544;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25MaximumSlotSizems_A8478.Valid;
			}
			set
			{
				short num = (short)1612820579;
				short num2 = num;
				num = (short)1186443363;
				switch (num2 == num)
				{
				}
				num = (short)1244528641;
				if (num != 0)
				{
				}
				num = (short)162988032;
				short num3 = num;
				num = (short)1643970560;
				if (num != 0)
				{
				}
				this.trkSysASTRO25MaximumSlotSizems_A8478.Valid = value;
			}
		}

		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x060009AA RID: 2474 RVA: 0x00091F10 File Offset: 0x00090110
		// (set) Token: 0x060009AB RID: 2475 RVA: 0x00091FC8 File Offset: 0x000901C8
		public bool TrkSysASTRO25MaximumSlotSizems_A8478_Visible
		{
			get
			{
				short num = (short)1701225535;
				short num2 = num;
				num = (short)1142006847;
				switch (num2 == num)
				{
				}
				num = (short)518127617;
				if (num != 0)
				{
				}
				num = (short)1003880448;
				short num3 = num;
				num = (short)2109603840;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25MaximumSlotSizems_A8478.Visible;
			}
			set
			{
				short num = (short)1707447388;
				short num2 = num;
				num = (short)214864988;
				switch (num2 == num)
				{
				}
				num = (short)1228800001;
				if (num != 0)
				{
				}
				num = (short)1899823104;
				short num3 = num;
				num = (short)1664745472;
				if (num != 0)
				{
				}
				this.trkSysASTRO25MaximumSlotSizems_A8478.Visible = value;
			}
		}

		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x060009AC RID: 2476 RVA: 0x00092080 File Offset: 0x00090280
		// (set) Token: 0x060009AD RID: 2477 RVA: 0x00092134 File Offset: 0x00090334
		public bool TrkSysASTRO25MaximumSlotSizems_A8478_Editable
		{
			get
			{
				short num = (short)1664858921;
				short num2 = num;
				num = (short)424917801;
				switch (num2 == num)
				{
				}
				num = (short)1858404353;
				if (num != 0)
				{
				}
				num = (short)1374420992;
				short num3 = num;
				num = (short)1057751040;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25MaximumSlotSizems_A8478.Editable;
			}
			set
			{
				short num = (short)547581759;
				short num2 = num;
				num = (short)1431203647;
				switch (num2 == num)
				{
				}
				num = (short)1901854720;
				if (num != 0)
				{
				}
				num = (short)1453457408;
				short num3 = num;
				num = (short)552271873;
				if (num != 0)
				{
				}
				this.trkSysASTRO25MaximumSlotSizems_A8478.Editable = value;
			}
		}

		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x060009AE RID: 2478 RVA: 0x000921E8 File Offset: 0x000903E8
		internal string TrkSysASTRO25MaximumSlotSizems_A8478_UILabel
		{
			get
			{
				short num = (short)1410789381;
				short num2 = num;
				num = (short)425062405;
				switch (num2 == num)
				{
				}
				num = (short)149225473;
				if (num != 0)
				{
				}
				num = (short)1504706560;
				short num3 = num;
				num = (short)1451098112;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25MaximumSlotSizems_A8478.UIName;
			}
		}

		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x060009AF RID: 2479 RVA: 0x0009229C File Offset: 0x0009049C
		// (set) Token: 0x060009B0 RID: 2480 RVA: 0x00092350 File Offset: 0x00090550
		internal bool TrkSysASTRO25MaximumSlotSizems_A8478_HiddenStatic
		{
			get
			{
				short num = (short)1143530009;
				short num2 = num;
				num = (short)680845849;
				switch (num2 == num)
				{
				}
				num = (short)482279424;
				if (num != 0)
				{
				}
				num = (short)147587072;
				short num3 = num;
				num = (short)114622465;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25MaximumSlotSizems_A8478.HiddenStatic;
			}
			set
			{
				short num = (short)360046983;
				short num2 = num;
				num = (short)1268900231;
				switch (num2 == num)
				{
				}
				num = (short)903610369;
				if (num != 0)
				{
				}
				num = (short)2145189888;
				short num3 = num;
				num = (short)851378176;
				if (num != 0)
				{
				}
				this.trkSysASTRO25MaximumSlotSizems_A8478.HiddenStatic = value;
			}
		}

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x060009B1 RID: 2481 RVA: 0x00092404 File Offset: 0x00090604
		// (set) Token: 0x060009B2 RID: 2482 RVA: 0x000924BC File Offset: 0x000906BC
		internal bool TrkSysASTRO25MaximumSlotSizems_A8478_HiddenDynamic
		{
			get
			{
				short num = (short)1344274433;
				if (num != 0)
				{
				}
				num = (short)645576102;
				short num2 = num;
				num = (short)1199355302;
				switch (num2 == num)
				{
				}
				num = (short)1607991296;
				short num3 = num;
				num = (short)695795712;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25MaximumSlotSizems_A8478.HiddenDynamic;
			}
			set
			{
				short num = (short)1187458454;
				short num2 = num;
				num = (short)1677798806;
				switch (num2 == num)
				{
				}
				num = (short)1152253953;
				if (num != 0)
				{
				}
				num = (short)742653952;
				short num3 = num;
				num = (short)978386944;
				if (num != 0)
				{
				}
				this.trkSysASTRO25MaximumSlotSizems_A8478.HiddenDynamic = value;
			}
		}

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x060009B3 RID: 2483 RVA: 0x00092574 File Offset: 0x00090774
		public bool TrkSysASTRO25MaximumSlotSizems_A8478_HasDiffs
		{
			get
			{
				short num = (short)477499269;
				short num2 = num;
				num = (short)999231365;
				switch (num2 == num)
				{
				}
				num = (short)1522270208;
				if (num != 0)
				{
				}
				num = (short)1548484608;
				short num3 = num;
				num = (short)1069481985;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25MaximumSlotSizems_A8478._HasDiffs;
			}
		}

		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x060009B4 RID: 2484 RVA: 0x0009262C File Offset: 0x0009082C
		// (set) Token: 0x060009B5 RID: 2485 RVA: 0x000926E0 File Offset: 0x000908E0
		public bool TrkSysASTRO25MotorolaProprietaryFeatures_A8547Value
		{
			get
			{
				short num = (short)790434709;
				short num2 = num;
				num = (short)1037636501;
				switch (num2 == num)
				{
				}
				num = (short)88866816;
				if (num != 0)
				{
				}
				num = (short)1613496320;
				short num3 = num;
				num = (short)1904214017;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25MotorolaProprietaryFeatures_A8547.Value;
			}
			set
			{
				short num = (short)580332483;
				short num2 = num;
				num = (short)733621187;
				switch (num2 == num)
				{
				}
				num = (short)353173504;
				if (num != 0)
				{
				}
				num = (short)783417344;
				short num3 = num;
				num = (short)1182072833;
				if (num != 0)
				{
				}
				this.trkSysASTRO25MotorolaProprietaryFeatures_A8547.Value = value;
			}
		}

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x060009B6 RID: 2486 RVA: 0x00092798 File Offset: 0x00090998
		public global::AcpBusinessLayer.AcpField<bool> TrkSysASTRO25MotorolaProprietaryFeatures_A8547
		{
			get
			{
				short num = (short)1057663912;
				short num2 = num;
				num = (short)1875880872;
				switch (num2 == num)
				{
				}
				num = (short)1154220033;
				if (num != 0)
				{
				}
				num = (short)134152192;
				short num3 = num;
				num = (short)1399128064;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25MotorolaProprietaryFeatures_A8547;
			}
		}

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x060009B7 RID: 2487 RVA: 0x00092848 File Offset: 0x00090A48
		// (set) Token: 0x060009B8 RID: 2488 RVA: 0x00092900 File Offset: 0x00090B00
		public bool TrkSysASTRO25MotorolaProprietaryFeatures_A8547_UIValue
		{
			get
			{
				short num = (short)1034391112;
				short num2 = num;
				num = (short)1140297288;
				switch (num2 == num)
				{
				}
				num = (short)229769217;
				if (num != 0)
				{
				}
				num = (short)2147287040;
				short num3 = num;
				num = (short)1920335872;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25MotorolaProprietaryFeatures_A8547.Value;
			}
			set
			{
				short num = (short)1203104163;
				short num2 = num;
				num = (short)1887365539;
				switch (num2 == num)
				{
				}
				num = (short)512688129;
				if (num != 0)
				{
				}
				num = (short)1199702016;
				short num3 = num;
				num = (short)1698824192;
				if (num != 0)
				{
				}
				this.trkSysASTRO25MotorolaProprietaryFeatures_A8547.Value = value;
			}
		}

		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x060009B9 RID: 2489 RVA: 0x000929B4 File Offset: 0x00090BB4
		// (set) Token: 0x060009BA RID: 2490 RVA: 0x00092A68 File Offset: 0x00090C68
		public bool TrkSysASTRO25MotorolaProprietaryFeatures_A8547_Applicable
		{
			get
			{
				short num = (short)337473940;
				short num2 = num;
				num = (short)1544253844;
				switch (num2 == num)
				{
				}
				num = (short)1014169601;
				if (num != 0)
				{
				}
				num = (short)1178468352;
				short num3 = num;
				num = (short)2000093184;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25MotorolaProprietaryFeatures_A8547.Applicable;
			}
			set
			{
				short num = (short)1480435553;
				short num2 = num;
				num = (short)934717281;
				switch (num2 == num)
				{
				}
				num = (short)1692991489;
				if (num != 0)
				{
				}
				num = (short)98172928;
				short num3 = num;
				num = (short)1330249728;
				if (num != 0)
				{
				}
				this.trkSysASTRO25MotorolaProprietaryFeatures_A8547.Applicable = value;
			}
		}

		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x060009BB RID: 2491 RVA: 0x00092B1C File Offset: 0x00090D1C
		// (set) Token: 0x060009BC RID: 2492 RVA: 0x00092BD4 File Offset: 0x00090DD4
		public bool TrkSysASTRO25MotorolaProprietaryFeatures_A8547_Valid
		{
			get
			{
				short num = (short)1958077861;
				short num2 = num;
				num = (short)1830741413;
				switch (num2 == num)
				{
				}
				num = (short)1253048320;
				if (num != 0)
				{
				}
				num = (short)28180480;
				short num3 = num;
				num = (short)320995329;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25MotorolaProprietaryFeatures_A8547.Valid;
			}
			set
			{
				short num = (short)222787820;
				short num2 = num;
				num = (short)58685676;
				switch (num2 == num)
				{
				}
				num = (short)1384579073;
				if (num != 0)
				{
				}
				num = (short)1796341760;
				short num3 = num;
				num = (short)1617297408;
				if (num != 0)
				{
				}
				this.trkSysASTRO25MotorolaProprietaryFeatures_A8547.Valid = value;
			}
		}

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x060009BD RID: 2493 RVA: 0x00092C88 File Offset: 0x00090E88
		// (set) Token: 0x060009BE RID: 2494 RVA: 0x00092D3C File Offset: 0x00090F3C
		public bool TrkSysASTRO25MotorolaProprietaryFeatures_A8547_Visible
		{
			get
			{
				short num = (short)36394395;
				short num2 = num;
				num = (short)2117948827;
				switch (num2 == num)
				{
				}
				num = (short)1905917952;
				if (num != 0)
				{
				}
				num = (short)222298112;
				short num3 = num;
				num = (short)383516673;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25MotorolaProprietaryFeatures_A8547.Visible;
			}
			set
			{
				short num = (short)669205935;
				short num2 = num;
				num = (short)578241967;
				switch (num2 == num)
				{
				}
				num = (short)567541761;
				if (num != 0)
				{
				}
				num = (short)1004404736;
				short num3 = num;
				num = (short)461701120;
				if (num != 0)
				{
				}
				this.trkSysASTRO25MotorolaProprietaryFeatures_A8547.Visible = value;
			}
		}

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x060009BF RID: 2495 RVA: 0x00092DF4 File Offset: 0x00090FF4
		// (set) Token: 0x060009C0 RID: 2496 RVA: 0x00092EAC File Offset: 0x000910AC
		public bool TrkSysASTRO25MotorolaProprietaryFeatures_A8547_Editable
		{
			get
			{
				short num = (short)1147731728;
				short num2 = num;
				num = (short)1024065296;
				switch (num2 == num)
				{
				}
				num = (short)1946877953;
				if (num != 0)
				{
				}
				num = (short)639172608;
				short num3 = num;
				num = (short)537657344;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25MotorolaProprietaryFeatures_A8547.Editable;
			}
			set
			{
				short num = (short)1415134109;
				short num2 = num;
				num = (short)835271581;
				switch (num2 == num)
				{
				}
				num = (short)2110652417;
				if (num != 0)
				{
				}
				num = (short)486539264;
				short num3 = num;
				num = (short)1902772224;
				if (num != 0)
				{
				}
				this.trkSysASTRO25MotorolaProprietaryFeatures_A8547.Editable = value;
			}
		}

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x060009C1 RID: 2497 RVA: 0x00092F64 File Offset: 0x00091164
		internal string TrkSysASTRO25MotorolaProprietaryFeatures_A8547_UILabel
		{
			get
			{
				short num = (short)154757454;
				short num2 = num;
				num = (short)423651662;
				switch (num2 == num)
				{
				}
				num = (short)1403715584;
				if (num != 0)
				{
				}
				num = (short)1215692800;
				short num3 = num;
				num = (short)2018967553;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25MotorolaProprietaryFeatures_A8547.UIName;
			}
		}

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x060009C2 RID: 2498 RVA: 0x00093018 File Offset: 0x00091218
		// (set) Token: 0x060009C3 RID: 2499 RVA: 0x000930CC File Offset: 0x000912CC
		internal bool TrkSysASTRO25MotorolaProprietaryFeatures_A8547_HiddenStatic
		{
			get
			{
				short num = (short)294322177;
				if (num != 0)
				{
				}
				num = (short)240610149;
				short num2 = num;
				num = (short)1946381157;
				switch (num2 == num)
				{
				}
				num = (short)1950875648;
				short num3 = num;
				num = (short)558170112;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25MotorolaProprietaryFeatures_A8547.HiddenStatic;
			}
			set
			{
				short num = (short)1370050055;
				short num2 = num;
				num = (short)1085492743;
				switch (num2 == num)
				{
				}
				num = (short)566165505;
				if (num != 0)
				{
				}
				num = (short)1249050624;
				short num3 = num;
				num = (short)560922624;
				if (num != 0)
				{
				}
				this.trkSysASTRO25MotorolaProprietaryFeatures_A8547.HiddenStatic = value;
			}
		}

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x060009C4 RID: 2500 RVA: 0x00093180 File Offset: 0x00091380
		// (set) Token: 0x060009C5 RID: 2501 RVA: 0x00093234 File Offset: 0x00091434
		internal bool TrkSysASTRO25MotorolaProprietaryFeatures_A8547_HiddenDynamic
		{
			get
			{
				short num = (short)592798533;
				short num2 = num;
				num = (short)547709765;
				switch (num2 == num)
				{
				}
				num = (short)2067660800;
				if (num != 0)
				{
				}
				num = (short)316538880;
				short num3 = num;
				num = (short)1148780545;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25MotorolaProprietaryFeatures_A8547.HiddenDynamic;
			}
			set
			{
				short num = (short)1200048072;
				short num2 = num;
				num = (short)1142441928;
				switch (num2 == num)
				{
				}
				num = (short)981008384;
				if (num != 0)
				{
				}
				num = (short)2147090432;
				short num3 = num;
				num = (short)869531649;
				if (num != 0)
				{
				}
				this.trkSysASTRO25MotorolaProprietaryFeatures_A8547.HiddenDynamic = value;
			}
		}

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x060009C6 RID: 2502 RVA: 0x000932EC File Offset: 0x000914EC
		public bool TrkSysASTRO25MotorolaProprietaryFeatures_A8547_HasDiffs
		{
			get
			{
				short num = (short)1254291730;
				short num2 = num;
				num = (short)530839826;
				switch (num2 == num)
				{
				}
				num = (short)1837170689;
				if (num != 0)
				{
				}
				num = (short)1528430592;
				short num3 = num;
				num = (short)1499332608;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25MotorolaProprietaryFeatures_A8547._HasDiffs;
			}
		}

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x060009C7 RID: 2503 RVA: 0x000933A0 File Offset: 0x000915A0
		// (set) Token: 0x060009C8 RID: 2504 RVA: 0x00093454 File Offset: 0x00091654
		public int TrkSysASTRO25PTTWarningTimems_A8781Value
		{
			get
			{
				short num = (short)850274170;
				short num2 = num;
				num = (short)1338648442;
				switch (num2 == num)
				{
				}
				num = (short)1087373313;
				if (num != 0)
				{
				}
				num = (short)1068695552;
				short num3 = num;
				num = (short)942407680;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25PTTWarningTimems_A8781.Value;
			}
			set
			{
				short num = (short)1832710498;
				short num2 = num;
				num = (short)2139418978;
				switch (num2 == num)
				{
				}
				num = (short)1392508929;
				if (num != 0)
				{
				}
				num = (short)1199767552;
				short num3 = num;
				num = (short)1496776704;
				if (num != 0)
				{
				}
				this.trkSysASTRO25PTTWarningTimems_A8781.Value = value;
			}
		}

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x060009C9 RID: 2505 RVA: 0x00093508 File Offset: 0x00091708
		public global::AcpBusinessLayer.AcpSimpleRangeField TrkSysASTRO25PTTWarningTimems_A8781
		{
			get
			{
				short num = (short)1489502209;
				if (num != 0)
				{
				}
				num = (short)1412582160;
				short num2 = num;
				num = (short)1836206864;
				switch (num2 == num)
				{
				}
				num = (short)866975744;
				short num3 = num;
				num = (short)1736245248;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25PTTWarningTimems_A8781;
			}
		}

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x060009CA RID: 2506 RVA: 0x000935B4 File Offset: 0x000917B4
		// (set) Token: 0x060009CB RID: 2507 RVA: 0x00093668 File Offset: 0x00091868
		public string TrkSysASTRO25PTTWarningTimems_A8781_UIValue
		{
			get
			{
				short num = (short)1915434799;
				short num2 = num;
				num = (short)1212888879;
				switch (num2 == num)
				{
				}
				num = (short)329908225;
				if (num != 0)
				{
				}
				num = (short)1082261504;
				short num3 = num;
				num = (short)1287127040;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25PTTWarningTimems_A8781.UIValue;
			}
			set
			{
				short num = (short)1176065086;
				short num2 = num;
				num = (short)1364415550;
				switch (num2 == num)
				{
				}
				num = (short)452657153;
				if (num != 0)
				{
				}
				num = (short)1568407552;
				short num3 = num;
				num = (short)1152581632;
				if (num != 0)
				{
				}
				this.trkSysASTRO25PTTWarningTimems_A8781.UIValue = value;
			}
		}

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x060009CC RID: 2508 RVA: 0x00093720 File Offset: 0x00091920
		// (set) Token: 0x060009CD RID: 2509 RVA: 0x000937D4 File Offset: 0x000919D4
		internal int TrkSysASTRO25PTTWarningTimems_A8781Min
		{
			get
			{
				short num = (short)1734032051;
				short num2 = num;
				num = (short)371145395;
				switch (num2 == num)
				{
				}
				num = (short)42532865;
				if (num != 0)
				{
				}
				num = (short)39911424;
				short num3 = num;
				num = (short)735510528;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25PTTWarningTimems_A8781.Min;
			}
			set
			{
				short num = (short)1146253620;
				short num2 = num;
				num = (short)1149661492;
				switch (num2 == num)
				{
				}
				num = (short)1138556928;
				short num3 = num;
				num = (short)2071789569;
				if (num != 0)
				{
				}
				num = (short)1673461760;
				if (num != 0)
				{
				}
				this.trkSysASTRO25PTTWarningTimems_A8781.Min = value;
			}
		}

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x060009CE RID: 2510 RVA: 0x00093888 File Offset: 0x00091A88
		// (set) Token: 0x060009CF RID: 2511 RVA: 0x00093940 File Offset: 0x00091B40
		internal int TrkSysASTRO25PTTWarningTimems_A8781Max
		{
			get
			{
				short num = (short)942628132;
				short num2 = num;
				num = (short)136273188;
				switch (num2 == num)
				{
				}
				num = (short)167968768;
				short num3 = num;
				num = (short)838598657;
				if (num != 0)
				{
				}
				num = (short)434503680;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25PTTWarningTimems_A8781.Max;
			}
			set
			{
				short num = (short)1580368009;
				short num2 = num;
				num = (short)1158250633;
				switch (num2 == num)
				{
				}
				num = (short)1839267840;
				short num3 = num;
				num = (short)280428544;
				if (num != 0)
				{
				}
				num = (short)1565851649;
				if (num != 0)
				{
				}
				this.trkSysASTRO25PTTWarningTimems_A8781.Max = value;
			}
		}

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x060009D0 RID: 2512 RVA: 0x000939F4 File Offset: 0x00091BF4
		// (set) Token: 0x060009D1 RID: 2513 RVA: 0x00093AA8 File Offset: 0x00091CA8
		internal int TrkSysASTRO25PTTWarningTimems_A8781Step
		{
			get
			{
				short num = (short)457496918;
				short num2 = num;
				num = (short)1811142998;
				switch (num2 == num)
				{
				}
				num = (short)45744128;
				short num3 = num;
				num = (short)2054225920;
				if (num != 0)
				{
				}
				num = (short)1577254913;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25PTTWarningTimems_A8781.StepSize;
			}
			set
			{
				short num = (short)2076639233;
				if (num != 0)
				{
				}
				num = (short)2015611455;
				short num2 = num;
				num = (short)279890495;
				switch (num2 == num)
				{
				default:
				{
					num = (short)603258880;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)298254336;
				if (num != 0)
				{
				}
				this.trkSysASTRO25PTTWarningTimems_A8781.StepSize = value;
			}
		}

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x060009D2 RID: 2514 RVA: 0x00093B60 File Offset: 0x00091D60
		// (set) Token: 0x060009D3 RID: 2515 RVA: 0x00093C14 File Offset: 0x00091E14
		public bool TrkSysASTRO25PTTWarningTimems_A8781_Applicable
		{
			get
			{
				short num = (short)1449309071;
				short num2 = num;
				num = (short)1791538063;
				switch (num2 == num)
				{
				}
				num = (short)1782251520;
				short num3 = num;
				num = (short)792920065;
				if (num != 0)
				{
				}
				num = (short)1632763904;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25PTTWarningTimems_A8781.Applicable;
			}
			set
			{
				short num = (short)1330839553;
				if (num != 0)
				{
				}
				num = (short)1336473587;
				short num2 = num;
				num = (short)1971058675;
				switch (num2 == num)
				{
				default:
				{
					num = (short)465633280;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1307836416;
				if (num != 0)
				{
				}
				this.trkSysASTRO25PTTWarningTimems_A8781.Applicable = value;
			}
		}

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x060009D4 RID: 2516 RVA: 0x00093CC8 File Offset: 0x00091EC8
		// (set) Token: 0x060009D5 RID: 2517 RVA: 0x00093D7C File Offset: 0x00091F7C
		public bool TrkSysASTRO25PTTWarningTimems_A8781_Valid
		{
			get
			{
				short num = (short)610408348;
				short num2 = num;
				num = (short)840112028;
				switch (num2 == num)
				{
				}
				num = (short)1633353728;
				short num3 = num;
				num = (short)1317928961;
				if (num != 0)
				{
				}
				num = (short)1492320256;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25PTTWarningTimems_A8781.Valid;
			}
			set
			{
				short num = (short)508681604;
				short num2 = num;
				num = (short)583523716;
				switch (num2 == num)
				{
				}
				num = (short)131399680;
				short num3 = num;
				num = (short)572588033;
				if (num != 0)
				{
				}
				num = (short)1109131264;
				if (num != 0)
				{
				}
				this.trkSysASTRO25PTTWarningTimems_A8781.Valid = value;
			}
		}

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x060009D6 RID: 2518 RVA: 0x00093E34 File Offset: 0x00092034
		// (set) Token: 0x060009D7 RID: 2519 RVA: 0x00093EEC File Offset: 0x000920EC
		public bool TrkSysASTRO25PTTWarningTimems_A8781_Visible
		{
			get
			{
				short num = (short)334259383;
				short num2 = num;
				num = (short)980837559;
				switch (num2 == num)
				{
				}
				num = (short)90505216;
				short num3 = num;
				num = (short)1331429377;
				if (num != 0)
				{
				}
				num = (short)720896000;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25PTTWarningTimems_A8781.Visible;
			}
			set
			{
				short num = (short)437106100;
				short num2 = num;
				num = (short)336573876;
				switch (num2 == num)
				{
				}
				num = (short)1119289344;
				short num3 = num;
				num = (short)1168244736;
				if (num != 0)
				{
				}
				num = (short)1732444161;
				if (num != 0)
				{
				}
				this.trkSysASTRO25PTTWarningTimems_A8781.Visible = value;
			}
		}

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x060009D8 RID: 2520 RVA: 0x00093FA0 File Offset: 0x000921A0
		// (set) Token: 0x060009D9 RID: 2521 RVA: 0x00094058 File Offset: 0x00092258
		public bool TrkSysASTRO25PTTWarningTimems_A8781_Editable
		{
			get
			{
				short num = (short)2009489874;
				short num2 = num;
				num = (short)1345675730;
				switch (num2 == num)
				{
				}
				num = (short)1285488640;
				short num3 = num;
				num = (short)1214709760;
				if (num != 0)
				{
				}
				num = (short)1732771841;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25PTTWarningTimems_A8781.Editable;
			}
			set
			{
				short num = (short)1012315520;
				short num2 = num;
				num = (short)1774171520;
				switch (num2 == num)
				{
				}
				num = (short)169803776;
				short num3 = num;
				num = (short)1874001920;
				if (num != 0)
				{
				}
				num = (short)640090113;
				if (num != 0)
				{
				}
				this.trkSysASTRO25PTTWarningTimems_A8781.Editable = value;
			}
		}

		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x060009DA RID: 2522 RVA: 0x00094110 File Offset: 0x00092310
		internal string TrkSysASTRO25PTTWarningTimems_A8781_UILabel
		{
			get
			{
				short num = (short)1344077825;
				if (num != 0)
				{
				}
				num = (short)1075244988;
				short num2 = num;
				num = (short)1141305276;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1166934016;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)124649472;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25PTTWarningTimems_A8781.UIName;
			}
		}

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x060009DB RID: 2523 RVA: 0x000941C4 File Offset: 0x000923C4
		// (set) Token: 0x060009DC RID: 2524 RVA: 0x00094278 File Offset: 0x00092478
		internal bool TrkSysASTRO25PTTWarningTimems_A8781_HiddenStatic
		{
			get
			{
				short num = (short)593943677;
				short num2 = num;
				num = (short)796974205;
				switch (num2 == num)
				{
				}
				num = (short)1370554368;
				short num3 = num;
				num = (short)794427392;
				if (num != 0)
				{
				}
				num = (short)2048917505;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25PTTWarningTimems_A8781.HiddenStatic;
			}
			set
			{
				short num = (short)901821663;
				short num2 = num;
				num = (short)138589407;
				switch (num2 == num)
				{
				}
				num = (short)177274880;
				short num3 = num;
				num = (short)725942272;
				if (num != 0)
				{
				}
				num = (short)313655297;
				if (num != 0)
				{
				}
				this.trkSysASTRO25PTTWarningTimems_A8781.HiddenStatic = value;
			}
		}

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x060009DD RID: 2525 RVA: 0x00094330 File Offset: 0x00092530
		// (set) Token: 0x060009DE RID: 2526 RVA: 0x000943E4 File Offset: 0x000925E4
		internal bool TrkSysASTRO25PTTWarningTimems_A8781_HiddenDynamic
		{
			get
			{
				short num = (short)1001336112;
				short num2 = num;
				num = (short)1476144432;
				switch (num2 == num)
				{
				}
				num = (short)325517312;
				short num3 = num;
				num = (short)1987248129;
				if (num != 0)
				{
				}
				num = (short)85917696;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25PTTWarningTimems_A8781.HiddenDynamic;
			}
			set
			{
				short num = (short)449197281;
				short num2 = num;
				num = (short)40121569;
				switch (num2 == num)
				{
				}
				num = (short)1157824512;
				short num3 = num;
				num = (short)1013317633;
				if (num != 0)
				{
				}
				num = (short)630456320;
				if (num != 0)
				{
				}
				this.trkSysASTRO25PTTWarningTimems_A8781.HiddenDynamic = value;
			}
		}

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x060009DF RID: 2527 RVA: 0x00094498 File Offset: 0x00092698
		public bool TrkSysASTRO25PTTWarningTimems_A8781_HasDiffs
		{
			get
			{
				short num = (short)497661573;
				short num2 = num;
				num = (short)581940869;
				switch (num2 == num)
				{
				}
				num = (short)1182531584;
				short num3 = num;
				num = (short)510459905;
				if (num != 0)
				{
				}
				num = (short)472383488;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25PTTWarningTimems_A8781._HasDiffs;
			}
		}

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x060009E0 RID: 2528 RVA: 0x00094550 File Offset: 0x00092750
		// (set) Token: 0x060009E1 RID: 2529 RVA: 0x00094604 File Offset: 0x00092804
		public int TrkSysASTRO25ResponsePendingTimesec_A8945Value
		{
			get
			{
				short num = (short)341863092;
				short num2 = num;
				num = (short)543320756;
				switch (num2 == num)
				{
				}
				num = (short)241172480;
				short num3 = num;
				num = (short)2108882945;
				if (num != 0)
				{
				}
				num = (short)1441529856;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ResponsePendingTimesec_A8945.Value;
			}
			set
			{
				short num = (short)1875748142;
				short num2 = num;
				num = (short)1538499886;
				switch (num2 == num)
				{
				}
				num = (short)2005467136;
				short num3 = num;
				num = (short)1775763457;
				if (num != 0)
				{
				}
				num = (short)2087649280;
				if (num != 0)
				{
				}
				this.trkSysASTRO25ResponsePendingTimesec_A8945.Value = value;
			}
		}

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x060009E2 RID: 2530 RVA: 0x000946BC File Offset: 0x000928BC
		public global::AcpBusinessLayer.AcpSimpleRangeField TrkSysASTRO25ResponsePendingTimesec_A8945
		{
			get
			{
				short num = (short)25123006;
				short num2 = num;
				num = (short)1382963390;
				switch (num2 == num)
				{
				}
				num = (short)1512112128;
				short num3 = num;
				num = (short)155844609;
				if (num != 0)
				{
				}
				num = (short)112066560;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ResponsePendingTimesec_A8945;
			}
		}

		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x060009E3 RID: 2531 RVA: 0x0009476C File Offset: 0x0009296C
		// (set) Token: 0x060009E4 RID: 2532 RVA: 0x00094824 File Offset: 0x00092A24
		public string TrkSysASTRO25ResponsePendingTimesec_A8945_UIValue
		{
			get
			{
				short num = (short)1001935323;
				short num2 = num;
				num = (short)949375451;
				switch (num2 == num)
				{
				}
				num = (short)254672896;
				short num3 = num;
				num = (short)486932481;
				if (num != 0)
				{
				}
				num = (short)1357512704;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ResponsePendingTimesec_A8945.UIValue;
			}
			set
			{
				short num = (short)1057096665;
				short num2 = num;
				num = (short)800457689;
				switch (num2 == num)
				{
				}
				num = (short)1008861184;
				short num3 = num;
				num = (short)1486028800;
				if (num != 0)
				{
				}
				num = (short)764280833;
				if (num != 0)
				{
				}
				this.trkSysASTRO25ResponsePendingTimesec_A8945.UIValue = value;
			}
		}

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x060009E5 RID: 2533 RVA: 0x000948D8 File Offset: 0x00092AD8
		// (set) Token: 0x060009E6 RID: 2534 RVA: 0x0009498C File Offset: 0x00092B8C
		internal int TrkSysASTRO25ResponsePendingTimesec_A8945Min
		{
			get
			{
				short num = (short)335389181;
				short num2 = num;
				num = (short)1913299453;
				switch (num2 == num)
				{
				}
				num = (short)824967168;
				short num3 = num;
				num = (short)1989476353;
				if (num != 0)
				{
				}
				num = (short)729350144;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ResponsePendingTimesec_A8945.Min;
			}
			set
			{
				short num = (short)1114113;
				if (num != 0)
				{
				}
				num = (short)1123974867;
				short num2 = num;
				num = (short)546733779;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1220608000;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)34930688;
				if (num != 0)
				{
				}
				this.trkSysASTRO25ResponsePendingTimesec_A8945.Min = value;
			}
		}

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x060009E7 RID: 2535 RVA: 0x00094A40 File Offset: 0x00092C40
		// (set) Token: 0x060009E8 RID: 2536 RVA: 0x00094AF4 File Offset: 0x00092CF4
		internal int TrkSysASTRO25ResponsePendingTimesec_A8945Max
		{
			get
			{
				short num = (short)1851627967;
				short num2 = num;
				num = (short)863672767;
				switch (num2 == num)
				{
				}
				num = (short)488308736;
				short num3 = num;
				num = (short)1911685121;
				if (num != 0)
				{
				}
				num = (short)1135476736;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ResponsePendingTimesec_A8945.Max;
			}
			set
			{
				short num = (short)1862319252;
				short num2 = num;
				num = (short)1928510612;
				switch (num2 == num)
				{
				}
				num = (short)1133182976;
				short num3 = num;
				num = (short)1166344193;
				if (num != 0)
				{
				}
				num = (short)1621688320;
				if (num != 0)
				{
				}
				this.trkSysASTRO25ResponsePendingTimesec_A8945.Max = value;
			}
		}

		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x060009E9 RID: 2537 RVA: 0x00094BA8 File Offset: 0x00092DA8
		// (set) Token: 0x060009EA RID: 2538 RVA: 0x00094C5C File Offset: 0x00092E5C
		internal int TrkSysASTRO25ResponsePendingTimesec_A8945Step
		{
			get
			{
				short num = (short)912197147;
				short num2 = num;
				num = (short)1863190043;
				switch (num2 == num)
				{
				}
				num = (short)158007296;
				short num3 = num;
				num = (short)856489985;
				if (num != 0)
				{
				}
				num = (short)250937344;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ResponsePendingTimesec_A8945.StepSize;
			}
			set
			{
				short num = (short)405937699;
				short num2 = num;
				num = (short)947199523;
				switch (num2 == num)
				{
				}
				num = (short)1243021312;
				short num3 = num;
				num = (short)1935998977;
				if (num != 0)
				{
				}
				num = (short)79298560;
				if (num != 0)
				{
				}
				this.trkSysASTRO25ResponsePendingTimesec_A8945.StepSize = value;
			}
		}

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x060009EB RID: 2539 RVA: 0x00094D10 File Offset: 0x00092F10
		// (set) Token: 0x060009EC RID: 2540 RVA: 0x00094DC4 File Offset: 0x00092FC4
		public bool TrkSysASTRO25ResponsePendingTimesec_A8945_Applicable
		{
			get
			{
				short num = (short)1353566341;
				short num2 = num;
				num = (short)1917569157;
				switch (num2 == num)
				{
				}
				num = (short)675217408;
				short num3 = num;
				num = (short)565248000;
				if (num != 0)
				{
				}
				num = (short)734396417;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ResponsePendingTimesec_A8945.Applicable;
			}
			set
			{
				short num = (short)770765971;
				short num2 = num;
				num = (short)1876227219;
				switch (num2 == num)
				{
				}
				num = (short)827457536;
				short num3 = num;
				num = (short)8650752;
				if (num != 0)
				{
				}
				num = (short)1268711425;
				if (num != 0)
				{
				}
				this.trkSysASTRO25ResponsePendingTimesec_A8945.Applicable = value;
			}
		}

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x060009ED RID: 2541 RVA: 0x00094E78 File Offset: 0x00093078
		// (set) Token: 0x060009EE RID: 2542 RVA: 0x00094F30 File Offset: 0x00093130
		public bool TrkSysASTRO25ResponsePendingTimesec_A8945_Valid
		{
			get
			{
				short num = (short)1498306410;
				short num2 = num;
				num = (short)609900394;
				switch (num2 == num)
				{
				}
				num = (short)88408064;
				short num3 = num;
				num = (short)400818177;
				if (num != 0)
				{
				}
				num = (short)2037055488;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ResponsePendingTimesec_A8945.Valid;
			}
			set
			{
				short num = (short)1316508564;
				short num2 = num;
				num = (short)1172263828;
				switch (num2 == num)
				{
				}
				num = (short)1149960192;
				short num3 = num;
				num = (short)1631911936;
				if (num != 0)
				{
				}
				num = (short)1496973313;
				if (num != 0)
				{
				}
				this.trkSysASTRO25ResponsePendingTimesec_A8945.Valid = value;
			}
		}

		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x060009EF RID: 2543 RVA: 0x00094FE8 File Offset: 0x000931E8
		// (set) Token: 0x060009F0 RID: 2544 RVA: 0x0009509C File Offset: 0x0009329C
		public bool TrkSysASTRO25ResponsePendingTimesec_A8945_Visible
		{
			get
			{
				short num = (short)509245551;
				short num2 = num;
				num = (short)229341295;
				switch (num2 == num)
				{
				}
				num = (short)586678272;
				short num3 = num;
				num = (short)2136473600;
				if (num != 0)
				{
				}
				num = (short)1284571137;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ResponsePendingTimesec_A8945.Visible;
			}
			set
			{
				short num = (short)582161519;
				short num2 = num;
				num = (short)1757221999;
				switch (num2 == num)
				{
				}
				num = (short)1650589696;
				short num3 = num;
				num = (short)1527971840;
				if (num != 0)
				{
				}
				num = (short)1061945345;
				if (num != 0)
				{
				}
				this.trkSysASTRO25ResponsePendingTimesec_A8945.Visible = value;
			}
		}

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x060009F1 RID: 2545 RVA: 0x00095154 File Offset: 0x00093354
		// (set) Token: 0x060009F2 RID: 2546 RVA: 0x00095204 File Offset: 0x00093404
		public bool TrkSysASTRO25ResponsePendingTimesec_A8945_Editable
		{
			get
			{
				short num = (short)938682071;
				short num2 = num;
				num = (short)74065623;
				switch (num2 == num)
				{
				}
				num = (short)2030108672;
				short num3 = num;
				num = (short)824967168;
				if (num != 0)
				{
				}
				num = (short)1082195969;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ResponsePendingTimesec_A8945.Editable;
			}
			set
			{
				short num = (short)1641086977;
				if (num != 0)
				{
				}
				num = (short)1554910286;
				short num2 = num;
				num = (short)1999834190;
				switch (num2 == num)
				{
				default:
				{
					num = (short)667615232;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)269025280;
				if (num != 0)
				{
				}
				this.trkSysASTRO25ResponsePendingTimesec_A8945.Editable = value;
			}
		}

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x060009F3 RID: 2547 RVA: 0x000952B8 File Offset: 0x000934B8
		internal string TrkSysASTRO25ResponsePendingTimesec_A8945_UILabel
		{
			get
			{
				short num = (short)1406643885;
				short num2 = num;
				num = (short)363703981;
				switch (num2 == num)
				{
				}
				num = (short)890961920;
				short num3 = num;
				num = (short)327155713;
				if (num != 0)
				{
				}
				num = (short)2144403456;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ResponsePendingTimesec_A8945.UIName;
			}
		}

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x060009F4 RID: 2548 RVA: 0x0009536C File Offset: 0x0009356C
		// (set) Token: 0x060009F5 RID: 2549 RVA: 0x00095420 File Offset: 0x00093620
		internal bool TrkSysASTRO25ResponsePendingTimesec_A8945_HiddenStatic
		{
			get
			{
				short num = (short)244687371;
				short num2 = num;
				num = (short)290300427;
				switch (num2 == num)
				{
				}
				num = (short)1475805184;
				short num3 = num;
				num = (short)428539905;
				if (num != 0)
				{
				}
				num = (short)979566592;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ResponsePendingTimesec_A8945.HiddenStatic;
			}
			set
			{
				short num = (short)1112735745;
				if (num != 0)
				{
				}
				num = (short)1016810939;
				short num2 = num;
				num = (short)1607880123;
				switch (num2 == num)
				{
				default:
				{
					num = (short)523370496;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)87293952;
				if (num != 0)
				{
				}
				this.trkSysASTRO25ResponsePendingTimesec_A8945.HiddenStatic = value;
			}
		}

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x060009F6 RID: 2550 RVA: 0x000954D4 File Offset: 0x000936D4
		// (set) Token: 0x060009F7 RID: 2551 RVA: 0x00095588 File Offset: 0x00093788
		internal bool TrkSysASTRO25ResponsePendingTimesec_A8945_HiddenDynamic
		{
			get
			{
				short num = (short)1711800321;
				if (num != 0)
				{
				}
				num = (short)2117658484;
				short num2 = num;
				num = (short)1970792308;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1638400000;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1900347392;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ResponsePendingTimesec_A8945.HiddenDynamic;
			}
			set
			{
				short num = (short)965607425;
				if (num != 0)
				{
				}
				num = (short)151674392;
				short num2 = num;
				num = (short)569466392;
				switch (num2 == num)
				{
				default:
				{
					num = (short)988282880;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1038090240;
				if (num != 0)
				{
				}
				this.trkSysASTRO25ResponsePendingTimesec_A8945.HiddenDynamic = value;
			}
		}

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x060009F8 RID: 2552 RVA: 0x0009563C File Offset: 0x0009383C
		public bool TrkSysASTRO25ResponsePendingTimesec_A8945_HasDiffs
		{
			get
			{
				short num = (short)1837958295;
				short num2 = num;
				num = (short)1592263831;
				switch (num2 == num)
				{
				}
				num = (short)722599936;
				short num3 = num;
				num = (short)2017525761;
				if (num != 0)
				{
				}
				num = (short)326565888;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ResponsePendingTimesec_A8945._HasDiffs;
			}
		}

		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x060009F9 RID: 2553 RVA: 0x000956F0 File Offset: 0x000938F0
		// (set) Token: 0x060009FA RID: 2554 RVA: 0x000957A4 File Offset: 0x000939A4
		public bool TrkSysASTRO25ValidateNACAgainstSystemID_A20608Value
		{
			get
			{
				short num = (short)67745201;
				short num2 = num;
				num = (short)1117697457;
				switch (num2 == num)
				{
				}
				num = (short)1215365120;
				short num3 = num;
				num = (short)478543873;
				if (num != 0)
				{
				}
				num = (short)621805568;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ValidateNACAgainstSystemID_A20608.Value;
			}
			set
			{
				short num = (short)756935732;
				short num2 = num;
				num = (short)1879239732;
				switch (num2 == num)
				{
				}
				num = (short)537853952;
				short num3 = num;
				num = (short)803667969;
				if (num != 0)
				{
				}
				num = (short)368115712;
				if (num != 0)
				{
				}
				this.trkSysASTRO25ValidateNACAgainstSystemID_A20608.Value = value;
			}
		}

		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x060009FB RID: 2555 RVA: 0x00095858 File Offset: 0x00093A58
		public global::AcpBusinessLayer.AcpField<bool> TrkSysASTRO25ValidateNACAgainstSystemID_A20608
		{
			get
			{
				short num = (short)863305729;
				if (num != 0)
				{
				}
				num = (short)1195879876;
				short num2 = num;
				num = (short)469478852;
				switch (num2 == num)
				{
				default:
				{
					num = (short)842399744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)766902272;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ValidateNACAgainstSystemID_A20608;
			}
		}

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x060009FC RID: 2556 RVA: 0x00095908 File Offset: 0x00093B08
		// (set) Token: 0x060009FD RID: 2557 RVA: 0x000959BC File Offset: 0x00093BBC
		public bool TrkSysASTRO25ValidateNACAgainstSystemID_A20608_UIValue
		{
			get
			{
				short num = (short)139089932;
				short num2 = num;
				num = (short)930830348;
				switch (num2 == num)
				{
				}
				num = (short)2141257728;
				short num3 = num;
				num = (short)1763180544;
				if (num != 0)
				{
				}
				num = (short)1395982337;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ValidateNACAgainstSystemID_A20608.Value;
			}
			set
			{
				short num = (short)2005671060;
				short num2 = num;
				num = (short)870194324;
				switch (num2 == num)
				{
				}
				num = (short)1416036352;
				short num3 = num;
				num = (short)244056064;
				if (num != 0)
				{
				}
				num = (short)194772993;
				if (num != 0)
				{
				}
				this.trkSysASTRO25ValidateNACAgainstSystemID_A20608.Value = value;
			}
		}

		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x060009FE RID: 2558 RVA: 0x00095A70 File Offset: 0x00093C70
		// (set) Token: 0x060009FF RID: 2559 RVA: 0x00095B24 File Offset: 0x00093D24
		public bool TrkSysASTRO25ValidateNACAgainstSystemID_A20608_Applicable
		{
			get
			{
				short num = (short)2142991002;
				short num2 = num;
				num = (short)1639871130;
				switch (num2 == num)
				{
				}
				num = (short)1141833728;
				short num3 = num;
				num = (short)1597374465;
				if (num != 0)
				{
				}
				num = (short)594542592;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ValidateNACAgainstSystemID_A20608.Applicable;
			}
			set
			{
				short num = (short)554041345;
				if (num != 0)
				{
				}
				num = (short)1367393329;
				short num2 = num;
				num = (short)784712753;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1287847936;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1222246400;
				if (num != 0)
				{
				}
				this.trkSysASTRO25ValidateNACAgainstSystemID_A20608.Applicable = value;
			}
		}

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x06000A00 RID: 2560 RVA: 0x00095BD8 File Offset: 0x00093DD8
		// (set) Token: 0x06000A01 RID: 2561 RVA: 0x00095C8C File Offset: 0x00093E8C
		public bool TrkSysASTRO25ValidateNACAgainstSystemID_A20608_Valid
		{
			get
			{
				short num = (short)1027348014;
				short num2 = num;
				num = (short)1480136238;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1858535424;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)502464513;
				if (num != 0)
				{
				}
				num = (short)2108227584;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ValidateNACAgainstSystemID_A20608.Valid;
			}
			set
			{
				short num = (short)1661960362;
				short num2 = num;
				num = (short)1934393514;
				switch (num2 == num)
				{
				default:
				{
					num = (short)16252928;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1840906241;
				if (num != 0)
				{
				}
				num = (short)1937833984;
				if (num != 0)
				{
				}
				this.trkSysASTRO25ValidateNACAgainstSystemID_A20608.Valid = value;
			}
		}

		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x06000A02 RID: 2562 RVA: 0x00095D40 File Offset: 0x00093F40
		// (set) Token: 0x06000A03 RID: 2563 RVA: 0x00095DF4 File Offset: 0x00093FF4
		public bool TrkSysASTRO25ValidateNACAgainstSystemID_A20608_Visible
		{
			get
			{
				short num = (short)1830152586;
				short num2 = num;
				num = (short)268626314;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1681195008;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)874577921;
				if (num != 0)
				{
				}
				num = (short)1851260928;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ValidateNACAgainstSystemID_A20608.Visible;
			}
			set
			{
				short num = (short)613548033;
				if (num != 0)
				{
				}
				num = (short)1631059968;
				short num2 = num;
				num = (short)881759621;
				short num3 = num;
				num = (short)638621061;
				switch (num3 == num)
				{
				}
				num = (short)718340096;
				if (num != 0)
				{
				}
				this.trkSysASTRO25ValidateNACAgainstSystemID_A20608.Visible = value;
			}
		}

		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x06000A04 RID: 2564 RVA: 0x00095EAC File Offset: 0x000940AC
		// (set) Token: 0x06000A05 RID: 2565 RVA: 0x00095F60 File Offset: 0x00094160
		public bool TrkSysASTRO25ValidateNACAgainstSystemID_A20608_Editable
		{
			get
			{
				short num = (short)2142240769;
				if (num != 0)
				{
				}
				num = (short)1424228352;
				short num2 = num;
				num = (short)1034688629;
				short num3 = num;
				num = (short)164698229;
				switch (num3 == num)
				{
				}
				num = (short)2030174208;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ValidateNACAgainstSystemID_A20608.Editable;
			}
			set
			{
				short num = (short)357894985;
				short num2 = num;
				num = (short)1067846473;
				switch (num2 == num)
				{
				default:
				{
					num = (short)810942464;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1428946944;
				if (num != 0)
				{
				}
				num = (short)1237516289;
				if (num != 0)
				{
				}
				this.trkSysASTRO25ValidateNACAgainstSystemID_A20608.Editable = value;
			}
		}

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x06000A06 RID: 2566 RVA: 0x00096014 File Offset: 0x00094214
		internal string TrkSysASTRO25ValidateNACAgainstSystemID_A20608_UILabel
		{
			get
			{
				short num = (short)1528168449;
				if (num != 0)
				{
				}
				num = (short)76808192;
				short num2 = num;
				num = (short)1409252527;
				short num3 = num;
				num = (short)1256160431;
				switch (num3 == num)
				{
				}
				num = (short)1722941440;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ValidateNACAgainstSystemID_A20608.UIName;
			}
		}

		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x06000A07 RID: 2567 RVA: 0x000960C8 File Offset: 0x000942C8
		// (set) Token: 0x06000A08 RID: 2568 RVA: 0x00096180 File Offset: 0x00094380
		internal bool TrkSysASTRO25ValidateNACAgainstSystemID_A20608_HiddenStatic
		{
			get
			{
				short num = (short)657995608;
				short num2 = num;
				num = (short)123418456;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1421934592;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)312475649;
				if (num != 0)
				{
				}
				num = (short)1453129728;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ValidateNACAgainstSystemID_A20608.HiddenStatic;
			}
			set
			{
				short num = (short)1054165867;
				short num2 = num;
				num = (short)1196313451;
				switch (num2 == num)
				{
				default:
				{
					num = (short)220463104;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1103495168;
				if (num != 0)
				{
				}
				num = (short)307757057;
				if (num != 0)
				{
				}
				this.trkSysASTRO25ValidateNACAgainstSystemID_A20608.HiddenStatic = value;
			}
		}

		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x06000A09 RID: 2569 RVA: 0x00096238 File Offset: 0x00094438
		// (set) Token: 0x06000A0A RID: 2570 RVA: 0x000962F0 File Offset: 0x000944F0
		internal bool TrkSysASTRO25ValidateNACAgainstSystemID_A20608_HiddenDynamic
		{
			get
			{
				short num = (short)114622465;
				if (num != 0)
				{
				}
				num = (short)982777856;
				short num2 = num;
				num = (short)1189616080;
				short num3 = num;
				num = (short)1495079376;
				switch (num3 == num)
				{
				}
				num = (short)1340866560;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ValidateNACAgainstSystemID_A20608.HiddenDynamic;
			}
			set
			{
				short num = (short)494222175;
				short num2 = num;
				num = (short)915749727;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2010316800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1351942145;
				if (num != 0)
				{
				}
				num = (short)356843520;
				if (num != 0)
				{
				}
				this.trkSysASTRO25ValidateNACAgainstSystemID_A20608.HiddenDynamic = value;
			}
		}

		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x06000A0B RID: 2571 RVA: 0x000963A4 File Offset: 0x000945A4
		public bool TrkSysASTRO25ValidateNACAgainstSystemID_A20608_HasDiffs
		{
			get
			{
				short num = (short)340201856;
				short num2 = num;
				num = (short)658641280;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2037841920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)943849472;
				if (num != 0)
				{
				}
				num = (short)1379008513;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ValidateNACAgainstSystemID_A20608._HasDiffs;
			}
		}

		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x06000A0C RID: 2572 RVA: 0x00096458 File Offset: 0x00094658
		// (set) Token: 0x06000A0D RID: 2573 RVA: 0x0009650C File Offset: 0x0009470C
		public bool TrkSysASTRO25Phase2VoiceCapable_A37972Value
		{
			get
			{
				short num = (short)1584185184;
				short num2 = num;
				num = (short)113819488;
				switch (num2 == num)
				{
				default:
				{
					num = (short)304676864;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)373620737;
				if (num != 0)
				{
				}
				num = (short)1154088960;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25Phase2VoiceCapable_A37972.Value;
			}
			set
			{
				short num = (short)1365875762;
				short num2 = num;
				num = (short)281189426;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1261633536;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)164954112;
				if (num != 0)
				{
				}
				num = (short)1929379841;
				if (num != 0)
				{
				}
				this.trkSysASTRO25Phase2VoiceCapable_A37972.Value = value;
			}
		}

		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x06000A0E RID: 2574 RVA: 0x000965C0 File Offset: 0x000947C0
		public global::AcpBusinessLayer.AcpField<bool> TrkSysASTRO25Phase2VoiceCapable_A37972
		{
			get
			{
				short num = (short)450019616;
				short num2 = num;
				num = (short)1792721184;
				switch (num2 == num)
				{
				default:
				{
					num = (short)868220928;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1999306753;
				if (num != 0)
				{
				}
				num = (short)1656225792;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25Phase2VoiceCapable_A37972;
			}
		}

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x06000A0F RID: 2575 RVA: 0x00096670 File Offset: 0x00094870
		// (set) Token: 0x06000A10 RID: 2576 RVA: 0x00096724 File Offset: 0x00094924
		public bool TrkSysASTRO25Phase2VoiceCapable_A37972_UIValue
		{
			get
			{
				short num = (short)439880296;
				short num2 = num;
				num = (short)506137192;
				switch (num2 == num)
				{
				default:
				{
					num = (short)522321920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)134676481;
				if (num != 0)
				{
				}
				num = (short)201588736;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25Phase2VoiceCapable_A37972.Value;
			}
			set
			{
				short num = (short)1586389483;
				short num2 = num;
				num = (short)1980785131;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2002845696;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)964820992;
				if (num != 0)
				{
				}
				num = (short)1661009921;
				if (num != 0)
				{
				}
				this.trkSysASTRO25Phase2VoiceCapable_A37972.Value = value;
			}
		}

		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x06000A11 RID: 2577 RVA: 0x000967DC File Offset: 0x000949DC
		// (set) Token: 0x06000A12 RID: 2578 RVA: 0x00096890 File Offset: 0x00094A90
		public bool TrkSysASTRO25Phase2VoiceCapable_A37972_Applicable
		{
			get
			{
				short num = (short)1048838145;
				if (num != 0)
				{
				}
				num = (short)918945792;
				short num2 = num;
				num = (short)620525388;
				short num3 = num;
				num = (short)2138077004;
				switch (num3 == num)
				{
				}
				num = (short)1021902848;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25Phase2VoiceCapable_A37972.Applicable;
			}
			set
			{
				short num = (short)361941006;
				short num2 = num;
				num = (short)1988020238;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1142685696;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1489567744;
				if (num != 0)
				{
				}
				num = (short)485097473;
				if (num != 0)
				{
				}
				this.trkSysASTRO25Phase2VoiceCapable_A37972.Applicable = value;
			}
		}

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x06000A13 RID: 2579 RVA: 0x00096948 File Offset: 0x00094B48
		// (set) Token: 0x06000A14 RID: 2580 RVA: 0x00096A00 File Offset: 0x00094C00
		public bool TrkSysASTRO25Phase2VoiceCapable_A37972_Valid
		{
			get
			{
				short num = (short)1826065928;
				short num2 = num;
				num = (short)635866632;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1697644544;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)509149184;
				if (num != 0)
				{
				}
				num = (short)295960577;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25Phase2VoiceCapable_A37972.Valid;
			}
			set
			{
				short num = (short)2026176513;
				if (num != 0)
				{
				}
				num = (short)1261764608;
				short num2 = num;
				num = (short)247079137;
				short num3 = num;
				num = (short)28647649;
				switch (num3 == num)
				{
				}
				num = (short)52101120;
				if (num != 0)
				{
				}
				this.trkSysASTRO25Phase2VoiceCapable_A37972.Valid = value;
			}
		}

		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x06000A15 RID: 2581 RVA: 0x00096AB4 File Offset: 0x00094CB4
		// (set) Token: 0x06000A16 RID: 2582 RVA: 0x00096B68 File Offset: 0x00094D68
		public bool TrkSysASTRO25Phase2VoiceCapable_A37972_Visible
		{
			get
			{
				short num = (short)426149428;
				short num2 = num;
				num = (short)504858164;
				switch (num2 == num)
				{
				default:
				{
					num = (short)566558720;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)334299137;
				if (num != 0)
				{
				}
				num = (short)1072889856;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25Phase2VoiceCapable_A37972.Visible;
			}
			set
			{
				short num = (short)1408373882;
				short num2 = num;
				num = (short)785257594;
				switch (num2 == num)
				{
				default:
				{
					num = (short)311427072;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1266614273;
				if (num != 0)
				{
				}
				num = (short)88211456;
				if (num != 0)
				{
				}
				this.trkSysASTRO25Phase2VoiceCapable_A37972.Visible = value;
			}
		}

		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x06000A17 RID: 2583 RVA: 0x00096C1C File Offset: 0x00094E1C
		// (set) Token: 0x06000A18 RID: 2584 RVA: 0x00096CD0 File Offset: 0x00094ED0
		public bool TrkSysASTRO25Phase2VoiceCapable_A37972_Editable
		{
			get
			{
				short num = (short)1849032705;
				if (num != 0)
				{
				}
				num = (short)160301056;
				short num2 = num;
				num = (short)138616056;
				short num3 = num;
				num = (short)1149508856;
				switch (num3 == num)
				{
				}
				num = (short)663027712;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25Phase2VoiceCapable_A37972.Editable;
			}
			set
			{
				short num = (short)1094696378;
				short num2 = num;
				num = (short)331726266;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1935147008;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)974520321;
				if (num != 0)
				{
				}
				num = (short)2101936128;
				if (num != 0)
				{
				}
				this.trkSysASTRO25Phase2VoiceCapable_A37972.Editable = value;
			}
		}

		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x06000A19 RID: 2585 RVA: 0x00096D84 File Offset: 0x00094F84
		internal string TrkSysASTRO25Phase2VoiceCapable_A37972_UILabel
		{
			get
			{
				short num = (short)550305793;
				if (num != 0)
				{
				}
				num = (short)157548544;
				short num2 = num;
				num = (short)937097893;
				short num3 = num;
				num = (short)818608805;
				switch (num3 == num)
				{
				}
				num = (short)1678245888;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25Phase2VoiceCapable_A37972.UIName;
			}
		}

		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x06000A1A RID: 2586 RVA: 0x00096E3C File Offset: 0x0009503C
		// (set) Token: 0x06000A1B RID: 2587 RVA: 0x00096EF4 File Offset: 0x000950F4
		internal bool TrkSysASTRO25Phase2VoiceCapable_A37972_HiddenStatic
		{
			get
			{
				short num = (short)626347332;
				short num2 = num;
				num = (short)2080984388;
				switch (num2 == num)
				{
				default:
				{
					num = (short)890241024;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1066205185;
				if (num != 0)
				{
				}
				num = (short)599064576;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25Phase2VoiceCapable_A37972.HiddenStatic;
			}
			set
			{
				short num = (short)1020349991;
				short num2 = num;
				num = (short)1785417255;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1682112512;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)373424129;
				if (num != 0)
				{
				}
				num = (short)1906114560;
				if (num != 0)
				{
				}
				this.trkSysASTRO25Phase2VoiceCapable_A37972.HiddenStatic = value;
			}
		}

		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x06000A1C RID: 2588 RVA: 0x00096FA8 File Offset: 0x000951A8
		// (set) Token: 0x06000A1D RID: 2589 RVA: 0x00097060 File Offset: 0x00095260
		internal bool TrkSysASTRO25Phase2VoiceCapable_A37972_HiddenDynamic
		{
			get
			{
				short num = (short)1300758529;
				if (num != 0)
				{
				}
				num = (short)1167851520;
				short num2 = num;
				num = (short)151107017;
				short num3 = num;
				num = (short)1089713609;
				switch (num3 == num)
				{
				}
				num = (short)188874752;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25Phase2VoiceCapable_A37972.HiddenDynamic;
			}
			set
			{
				short num = (short)801165583;
				short num2 = num;
				num = (short)1900728591;
				switch (num2 == num)
				{
				default:
				{
					num = (short)106299392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1960706048;
				if (num != 0)
				{
				}
				num = (short)1591148545;
				if (num != 0)
				{
				}
				this.trkSysASTRO25Phase2VoiceCapable_A37972.HiddenDynamic = value;
			}
		}

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x06000A1E RID: 2590 RVA: 0x00097118 File Offset: 0x00095318
		public bool TrkSysASTRO25Phase2VoiceCapable_A37972_HasDiffs
		{
			get
			{
				short num = (short)47595954;
				short num2 = num;
				num = (short)999899570;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1898184704;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1581842433;
				if (num != 0)
				{
				}
				num = (short)806027264;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25Phase2VoiceCapable_A37972._HasDiffs;
			}
		}

		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x06000A1F RID: 2591 RVA: 0x000971D0 File Offset: 0x000953D0
		// (set) Token: 0x06000A20 RID: 2592 RVA: 0x00097284 File Offset: 0x00095484
		public bool TrkSysASTRO25EndPhase2TDMATransmitOnOutOfRange_A37980Value
		{
			get
			{
				short num = (short)1075617791;
				short num2 = num;
				num = (short)427532287;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1523449856;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1236664320;
				if (num != 0)
				{
				}
				num = (short)1740177409;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25EndPhase2TDMATransmitOnOutOfRange_A37980.Value;
			}
			set
			{
				short num = (short)955224960;
				short num2 = num;
				num = (short)141988736;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2009792512;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)114163712;
				if (num != 0)
				{
				}
				num = (short)1014824961;
				if (num != 0)
				{
				}
				this.trkSysASTRO25EndPhase2TDMATransmitOnOutOfRange_A37980.Value = value;
			}
		}

		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x06000A21 RID: 2593 RVA: 0x0009733C File Offset: 0x0009553C
		public global::AcpBusinessLayer.AcpField<bool> TrkSysASTRO25EndPhase2TDMATransmitOnOutOfRange_A37980
		{
			get
			{
				short num = (short)127883761;
				short num2 = num;
				num = (short)466049521;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1862074368;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)262209537;
				if (num != 0)
				{
				}
				num = (short)834404352;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25EndPhase2TDMATransmitOnOutOfRange_A37980;
			}
		}

		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x06000A22 RID: 2594 RVA: 0x000973EC File Offset: 0x000955EC
		// (set) Token: 0x06000A23 RID: 2595 RVA: 0x000974A0 File Offset: 0x000956A0
		public bool TrkSysASTRO25EndPhase2TDMATransmitOnOutOfRange_A37980_UIValue
		{
			get
			{
				short num = (short)1379185238;
				short num2 = num;
				num = (short)1034138198;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1389232128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1380515841;
				if (num != 0)
				{
				}
				num = (short)1361051648;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25EndPhase2TDMATransmitOnOutOfRange_A37980.Value;
			}
			set
			{
				short num = (short)2031711209;
				short num2 = num;
				num = (short)1269330921;
				switch (num2 == num)
				{
				default:
				{
					num = (short)436994048;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1673330689;
				if (num != 0)
				{
				}
				num = (short)959053824;
				if (num != 0)
				{
				}
				this.trkSysASTRO25EndPhase2TDMATransmitOnOutOfRange_A37980.Value = value;
			}
		}

		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x06000A24 RID: 2596 RVA: 0x00097554 File Offset: 0x00095754
		// (set) Token: 0x06000A25 RID: 2597 RVA: 0x0009760C File Offset: 0x0009580C
		public bool TrkSysASTRO25EndPhase2TDMATransmitOnOutOfRange_A37980_Applicable
		{
			get
			{
				short num = (short)1563557889;
				if (num != 0)
				{
				}
				num = (short)2142896128;
				short num2 = num;
				num = (short)938569183;
				short num3 = num;
				num = (short)2057792991;
				switch (num3 == num)
				{
				}
				num = (short)1574240256;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25EndPhase2TDMATransmitOnOutOfRange_A37980.Applicable;
			}
			set
			{
				short num = (short)1816641039;
				short num2 = num;
				num = (short)1939127823;
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
				num = (short)639172608;
				if (num != 0)
				{
				}
				num = (short)1461059585;
				if (num != 0)
				{
				}
				this.trkSysASTRO25EndPhase2TDMATransmitOnOutOfRange_A37980.Applicable = value;
			}
		}

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x06000A26 RID: 2598 RVA: 0x000976C0 File Offset: 0x000958C0
		// (set) Token: 0x06000A27 RID: 2599 RVA: 0x00097778 File Offset: 0x00095978
		public bool TrkSysASTRO25EndPhase2TDMATransmitOnOutOfRange_A37980_Valid
		{
			get
			{
				short num = (short)1345216506;
				short num2 = num;
				num = (short)1771200506;
				switch (num2 == num)
				{
				default:
				{
					num = (short)891420672;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)329515008;
				if (num != 0)
				{
				}
				num = (short)1389690881;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25EndPhase2TDMATransmitOnOutOfRange_A37980.Valid;
			}
			set
			{
				short num = (short)902695205;
				short num2 = num;
				num = (short)1379010853;
				switch (num2 == num)
				{
				default:
				{
					num = (short)460587008;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)508821504;
				if (num != 0)
				{
				}
				num = (short)195624961;
				if (num != 0)
				{
				}
				this.trkSysASTRO25EndPhase2TDMATransmitOnOutOfRange_A37980.Valid = value;
			}
		}

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x06000A28 RID: 2600 RVA: 0x00097830 File Offset: 0x00095A30
		// (set) Token: 0x06000A29 RID: 2601 RVA: 0x000978E8 File Offset: 0x00095AE8
		public bool TrkSysASTRO25EndPhase2TDMATransmitOnOutOfRange_A37980_Visible
		{
			get
			{
				short num = (short)384412199;
				short num2 = num;
				num = (short)1550690855;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1641152512;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1505820672;
				if (num != 0)
				{
				}
				num = (short)633012225;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25EndPhase2TDMATransmitOnOutOfRange_A37980.Visible;
			}
			set
			{
				short num = (short)1408423158;
				short num2 = num;
				num = (short)461821174;
				switch (num2 == num)
				{
				default:
				{
					num = (short)945094656;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1406271489;
				if (num != 0)
				{
				}
				num = (short)840105984;
				if (num != 0)
				{
				}
				this.trkSysASTRO25EndPhase2TDMATransmitOnOutOfRange_A37980.Visible = value;
			}
		}

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x06000A2A RID: 2602 RVA: 0x000979A0 File Offset: 0x00095BA0
		// (set) Token: 0x06000A2B RID: 2603 RVA: 0x00097A54 File Offset: 0x00095C54
		public bool TrkSysASTRO25EndPhase2TDMATransmitOnOutOfRange_A37980_Editable
		{
			get
			{
				short num = (short)1807115073;
				short num2 = num;
				num = (short)1736663873;
				switch (num2 == num)
				{
				default:
				{
					num = (short)234160128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2048327681;
				if (num != 0)
				{
				}
				num = (short)1673592832;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25EndPhase2TDMATransmitOnOutOfRange_A37980.Editable;
			}
			set
			{
				short num = (short)328794113;
				if (num != 0)
				{
				}
				num = (short)1526136832;
				short num2 = num;
				num = (short)382634042;
				short num3 = num;
				num = (short)815433786;
				switch (num3 == num)
				{
				}
				num = (short)775815168;
				if (num != 0)
				{
				}
				this.trkSysASTRO25EndPhase2TDMATransmitOnOutOfRange_A37980.Editable = value;
			}
		}

		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x06000A2C RID: 2604 RVA: 0x00097B0C File Offset: 0x00095D0C
		internal string TrkSysASTRO25EndPhase2TDMATransmitOnOutOfRange_A37980_UILabel
		{
			get
			{
				short num = (short)1245385307;
				short num2 = num;
				num = (short)1751388763;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1850212352;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1489436673;
				if (num != 0)
				{
				}
				num = (short)2036858880;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25EndPhase2TDMATransmitOnOutOfRange_A37980.UIName;
			}
		}

		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x06000A2D RID: 2605 RVA: 0x00097BC0 File Offset: 0x00095DC0
		// (set) Token: 0x06000A2E RID: 2606 RVA: 0x00097C78 File Offset: 0x00095E78
		internal bool TrkSysASTRO25EndPhase2TDMATransmitOnOutOfRange_A37980_HiddenStatic
		{
			get
			{
				short num = (short)255721473;
				if (num != 0)
				{
				}
				num = (short)197787648;
				short num2 = num;
				num = (short)1483593203;
				short num3 = num;
				num = (short)944035315;
				switch (num3 == num)
				{
				}
				num = (short)1535639552;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25EndPhase2TDMATransmitOnOutOfRange_A37980.HiddenStatic;
			}
			set
			{
				short num = (short)8691383;
				short num2 = num;
				num = (short)935042743;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2070740992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1585709057;
				if (num != 0)
				{
				}
				num = (short)1188298752;
				if (num != 0)
				{
				}
				this.trkSysASTRO25EndPhase2TDMATransmitOnOutOfRange_A37980.HiddenStatic = value;
			}
		}

		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x06000A2F RID: 2607 RVA: 0x00097D30 File Offset: 0x00095F30
		// (set) Token: 0x06000A30 RID: 2608 RVA: 0x00097DE8 File Offset: 0x00095FE8
		internal bool TrkSysASTRO25EndPhase2TDMATransmitOnOutOfRange_A37980_HiddenDynamic
		{
			get
			{
				short num = (short)2129684581;
				short num2 = num;
				num = (short)1626171493;
				switch (num2 == num)
				{
				default:
				{
					num = (short)258146304;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1519648769;
				if (num != 0)
				{
				}
				num = (short)1343356928;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25EndPhase2TDMATransmitOnOutOfRange_A37980.HiddenDynamic;
			}
			set
			{
				short num = (short)804517009;
				short num2 = num;
				num = (short)622785681;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2059665408;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1732640768;
				if (num != 0)
				{
				}
				num = (short)1966014465;
				if (num != 0)
				{
				}
				this.trkSysASTRO25EndPhase2TDMATransmitOnOutOfRange_A37980.HiddenDynamic = value;
			}
		}

		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x06000A31 RID: 2609 RVA: 0x00097EA0 File Offset: 0x000960A0
		public bool TrkSysASTRO25EndPhase2TDMATransmitOnOutOfRange_A37980_HasDiffs
		{
			get
			{
				short num = (short)1904533963;
				short num2 = num;
				num = (short)363782603;
				switch (num2 == num)
				{
				default:
				{
					num = (short)503250944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1347551232;
				if (num != 0)
				{
				}
				num = (short)412745729;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25EndPhase2TDMATransmitOnOutOfRange_A37980._HasDiffs;
			}
		}

		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x06000A32 RID: 2610 RVA: 0x00097F58 File Offset: 0x00096158
		// (set) Token: 0x06000A33 RID: 2611 RVA: 0x00098010 File Offset: 0x00096210
		public int TrkSysASTRO25QuickFadeProtectms_A8807Value
		{
			get
			{
				short num = (short)745884632;
				short num2 = num;
				num = (short)1933331416;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1458765824;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1800601601;
				if (num != 0)
				{
				}
				num = (short)680132608;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25QuickFadeProtectms_A8807.Value;
			}
			set
			{
				short num = (short)833347775;
				short num2 = num;
				num = (short)658825407;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1888550912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1269628928;
				if (num != 0)
				{
				}
				num = (short)259457025;
				if (num != 0)
				{
				}
				this.trkSysASTRO25QuickFadeProtectms_A8807.Value = value;
			}
		}

		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x06000A34 RID: 2612 RVA: 0x000980C4 File Offset: 0x000962C4
		public global::AcpBusinessLayer.AcpSimpleRangeField TrkSysASTRO25QuickFadeProtectms_A8807
		{
			get
			{
				short num = (short)34886790;
				short num2 = num;
				num = (short)730813574;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1705050112;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)913899520;
				if (num != 0)
				{
				}
				num = (short)943390721;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25QuickFadeProtectms_A8807;
			}
		}

		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x06000A35 RID: 2613 RVA: 0x00098174 File Offset: 0x00096374
		// (set) Token: 0x06000A36 RID: 2614 RVA: 0x0009822C File Offset: 0x0009642C
		public string TrkSysASTRO25QuickFadeProtectms_A8807_UIValue
		{
			get
			{
				short num = (short)705036288;
				short num2 = num;
				num = (short)1658840210;
				short num3 = num;
				num = (short)1711334546;
				switch (num3 == num)
				{
				}
				num = (short)1883045889;
				if (num != 0)
				{
				}
				num = (short)863305728;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25QuickFadeProtectms_A8807.UIValue;
			}
			set
			{
				short num = (short)1190264832;
				short num2 = num;
				num = (short)965976912;
				short num3 = num;
				num = (short)129278800;
				switch (num3 == num)
				{
				}
				num = (short)1347485696;
				if (num != 0)
				{
				}
				num = (short)1674575873;
				if (num != 0)
				{
				}
				this.trkSysASTRO25QuickFadeProtectms_A8807.UIValue = value;
			}
		}

		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x06000A37 RID: 2615 RVA: 0x000982E4 File Offset: 0x000964E4
		// (set) Token: 0x06000A38 RID: 2616 RVA: 0x00098398 File Offset: 0x00096598
		internal int TrkSysASTRO25QuickFadeProtectms_A8807Min
		{
			get
			{
				short num = (short)2073755648;
				short num2 = num;
				num = (short)1987547129;
				short num3 = num;
				num = (short)2083229689;
				switch (num3 == num)
				{
				}
				num = (short)941555713;
				if (num != 0)
				{
				}
				num = (short)1838088192;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25QuickFadeProtectms_A8807.Min;
			}
			set
			{
				short num = (short)142082048;
				short num2 = num;
				num = (short)1998389249;
				if (num != 0)
				{
				}
				num = (short)679701551;
				short num3 = num;
				num = (short)97152047;
				switch (num3 == num)
				{
				}
				num = (short)481099776;
				if (num != 0)
				{
				}
				this.trkSysASTRO25QuickFadeProtectms_A8807.Min = value;
			}
		}

		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x06000A39 RID: 2617 RVA: 0x0009844C File Offset: 0x0009664C
		// (set) Token: 0x06000A3A RID: 2618 RVA: 0x00098500 File Offset: 0x00096700
		internal int TrkSysASTRO25QuickFadeProtectms_A8807Max
		{
			get
			{
				short num = (short)752549888;
				short num2 = num;
				num = (short)423152785;
				short num3 = num;
				num = (short)82889873;
				switch (num3 == num)
				{
				}
				num = (short)114622465;
				if (num != 0)
				{
				}
				num = (short)1073938432;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25QuickFadeProtectms_A8807.Max;
			}
			set
			{
				short num = (short)76152832;
				short num2 = num;
				num = (short)1329977291;
				short num3 = num;
				num = (short)1931139019;
				switch (num3 == num)
				{
				}
				num = (short)110624769;
				if (num != 0)
				{
				}
				num = (short)1514340352;
				if (num != 0)
				{
				}
				this.trkSysASTRO25QuickFadeProtectms_A8807.Max = value;
			}
		}

		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x06000A3B RID: 2619 RVA: 0x000985B4 File Offset: 0x000967B4
		// (set) Token: 0x06000A3C RID: 2620 RVA: 0x00098668 File Offset: 0x00096868
		internal int TrkSysASTRO25QuickFadeProtectms_A8807Step
		{
			get
			{
				short num = (short)846397440;
				short num2 = num;
				num = (short)87301583;
				short num3 = num;
				num = (short)1614945743;
				switch (num3 == num)
				{
				}
				num = (short)499056640;
				if (num != 0)
				{
				}
				num = (short)969211905;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25QuickFadeProtectms_A8807.StepSize;
			}
			set
			{
				short num = (short)880345088;
				short num2 = num;
				num = (short)971881989;
				short num3 = num;
				num = (short)317177349;
				switch (num3 == num)
				{
				}
				num = (short)1013186561;
				if (num != 0)
				{
				}
				num = (short)1763573760;
				if (num != 0)
				{
				}
				this.trkSysASTRO25QuickFadeProtectms_A8807.StepSize = value;
			}
		}

		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x06000A3D RID: 2621 RVA: 0x0009871C File Offset: 0x0009691C
		// (set) Token: 0x06000A3E RID: 2622 RVA: 0x000987D0 File Offset: 0x000969D0
		public bool TrkSysASTRO25QuickFadeProtectms_A8807_Applicable
		{
			get
			{
				short num = (short)2104492032;
				short num2 = num;
				num = (short)129052296;
				short num3 = num;
				num = (short)660811400;
				switch (num3 == num)
				{
				}
				num = (short)336592897;
				if (num != 0)
				{
				}
				num = (short)1795686400;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25QuickFadeProtectms_A8807.Applicable;
			}
			set
			{
				short num = (short)1479606272;
				short num2 = num;
				num = (short)973046158;
				short num3 = num;
				num = (short)958562702;
				switch (num3 == num)
				{
				}
				num = (short)424935425;
				if (num != 0)
				{
				}
				num = (short)773718016;
				if (num != 0)
				{
				}
				this.trkSysASTRO25QuickFadeProtectms_A8807.Applicable = value;
			}
		}

		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x06000A3F RID: 2623 RVA: 0x00098888 File Offset: 0x00096A88
		// (set) Token: 0x06000A40 RID: 2624 RVA: 0x0009893C File Offset: 0x00096B3C
		public bool TrkSysASTRO25QuickFadeProtectms_A8807_Valid
		{
			get
			{
				short num = (short)1713045504;
				short num2 = num;
				num = (short)1577286236;
				short num3 = num;
				num = (short)821525084;
				switch (num3 == num)
				{
				}
				num = (short)1309147136;
				if (num != 0)
				{
				}
				num = (short)128385025;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25QuickFadeProtectms_A8807.Valid;
			}
			set
			{
				short num = (short)1987837952;
				short num2 = num;
				num = (short)1092474909;
				short num3 = num;
				num = (short)1832638493;
				switch (num3 == num)
				{
				}
				num = (short)391184385;
				if (num != 0)
				{
				}
				num = (short)925827072;
				if (num != 0)
				{
				}
				this.trkSysASTRO25QuickFadeProtectms_A8807.Valid = value;
			}
		}

		// Token: 0x17000514 RID: 1300
		// (get) Token: 0x06000A41 RID: 2625 RVA: 0x000989F0 File Offset: 0x00096BF0
		// (set) Token: 0x06000A42 RID: 2626 RVA: 0x00098AA4 File Offset: 0x00096CA4
		public bool TrkSysASTRO25QuickFadeProtectms_A8807_Visible
		{
			get
			{
				short num = (short)559153152;
				short num2 = num;
				num = (short)213162848;
				short num3 = num;
				num = (short)779262816;
				switch (num3 == num)
				{
				}
				num = (short)646250497;
				if (num != 0)
				{
				}
				num = (short)791674880;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25QuickFadeProtectms_A8807.Visible;
			}
			set
			{
				short num = (short)1938817024;
				short num2 = num;
				num = (short)964263424;
				short num3 = num;
				num = (short)320044544;
				switch (num3 == num)
				{
				}
				num = (short)556859392;
				if (num != 0)
				{
				}
				num = (short)170786817;
				if (num != 0)
				{
				}
				this.trkSysASTRO25QuickFadeProtectms_A8807.Visible = value;
			}
		}

		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x06000A43 RID: 2627 RVA: 0x00098B58 File Offset: 0x00096D58
		// (set) Token: 0x06000A44 RID: 2628 RVA: 0x00098C10 File Offset: 0x00096E10
		public bool TrkSysASTRO25QuickFadeProtectms_A8807_Editable
		{
			get
			{
				short num = (short)711065600;
				short num2 = num;
				num = (short)457244673;
				if (num != 0)
				{
				}
				num = (short)87450990;
				short num3 = num;
				num = (short)128476526;
				switch (num3 == num)
				{
				}
				num = (short)685441024;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25QuickFadeProtectms_A8807.Editable;
			}
			set
			{
				short num = (short)1437663232;
				short num2 = num;
				num = (short)721152475;
				short num3 = num;
				num = (short)710928859;
				switch (num3 == num)
				{
				}
				num = (short)523108353;
				if (num != 0)
				{
				}
				num = (short)864485376;
				if (num != 0)
				{
				}
				this.trkSysASTRO25QuickFadeProtectms_A8807.Editable = value;
			}
		}

		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x06000A45 RID: 2629 RVA: 0x00098CC4 File Offset: 0x00096EC4
		internal string TrkSysASTRO25QuickFadeProtectms_A8807_UILabel
		{
			get
			{
				short num = (short)1673003008;
				short num2 = num;
				num = (short)1705725238;
				short num3 = num;
				num = (short)1665748278;
				switch (num3 == num)
				{
				}
				num = (short)787218432;
				if (num != 0)
				{
				}
				num = (short)1520304129;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25QuickFadeProtectms_A8807.UIName;
			}
		}

		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x06000A46 RID: 2630 RVA: 0x00098D7C File Offset: 0x00096F7C
		// (set) Token: 0x06000A47 RID: 2631 RVA: 0x00098E2C File Offset: 0x0009702C
		internal bool TrkSysASTRO25QuickFadeProtectms_A8807_HiddenStatic
		{
			get
			{
				short num = (short)1412562944;
				short num2 = num;
				num = (short)1851038856;
				short num3 = num;
				num = (short)728603784;
				switch (num3 == num)
				{
				}
				num = (short)1988755457;
				if (num != 0)
				{
				}
				num = (short)230883328;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25QuickFadeProtectms_A8807.HiddenStatic;
			}
			set
			{
				short num = (short)156106752;
				short num2 = num;
				num = (short)74186753;
				if (num != 0)
				{
				}
				num = (short)1070179292;
				short num3 = num;
				num = (short)1775346652;
				switch (num3 == num)
				{
				}
				num = (short)1552809984;
				if (num != 0)
				{
				}
				this.trkSysASTRO25QuickFadeProtectms_A8807.HiddenStatic = value;
			}
		}

		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x06000A48 RID: 2632 RVA: 0x00098EE4 File Offset: 0x000970E4
		// (set) Token: 0x06000A49 RID: 2633 RVA: 0x00098F98 File Offset: 0x00097198
		internal bool TrkSysASTRO25QuickFadeProtectms_A8807_HiddenDynamic
		{
			get
			{
				short num = (short)270598144;
				short num2 = num;
				num = (short)2121799506;
				short num3 = num;
				num = (short)1532106578;
				switch (num3 == num)
				{
				}
				num = (short)73334785;
				if (num != 0)
				{
				}
				num = (short)618463232;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25QuickFadeProtectms_A8807.HiddenDynamic;
			}
			set
			{
				short num = (short)383713280;
				short num2 = num;
				num = (short)130924264;
				short num3 = num;
				num = (short)1682226920;
				switch (num3 == num)
				{
				}
				num = (short)104333312;
				if (num != 0)
				{
				}
				num = (short)1925382145;
				if (num != 0)
				{
				}
				this.trkSysASTRO25QuickFadeProtectms_A8807.HiddenDynamic = value;
			}
		}

		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x06000A4A RID: 2634 RVA: 0x00099050 File Offset: 0x00097250
		public bool TrkSysASTRO25QuickFadeProtectms_A8807_HasDiffs
		{
			get
			{
				short num = (short)1541931008;
				short num2 = num;
				num = (short)1872887809;
				if (num != 0)
				{
				}
				num = (short)594076640;
				short num3 = num;
				num = (short)1820517344;
				switch (num3 == num)
				{
				}
				num = (short)889192448;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25QuickFadeProtectms_A8807._HasDiffs;
			}
		}

		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x06000A4B RID: 2635 RVA: 0x00099104 File Offset: 0x00097304
		// (set) Token: 0x06000A4C RID: 2636 RVA: 0x000991B8 File Offset: 0x000973B8
		public bool TrkSysASTRO25WUIDValiditySupport_A41483Value
		{
			get
			{
				short num = (short)664469504;
				short num2 = num;
				num = (short)1102269419;
				short num3 = num;
				num = (short)982600683;
				switch (num3 == num)
				{
				}
				num = (short)548798465;
				if (num != 0)
				{
				}
				num = (short)390004736;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25WUIDValiditySupport_A41483.Value;
			}
			set
			{
				short num = (short)613810176;
				short num2 = num;
				num = (short)34939635;
				short num3 = num;
				num = (short)1147216627;
				switch (num3 == num)
				{
				}
				num = (short)556990464;
				if (num != 0)
				{
				}
				num = (short)50200577;
				if (num != 0)
				{
				}
				this.trkSysASTRO25WUIDValiditySupport_A41483.Value = value;
			}
		}

		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x06000A4D RID: 2637 RVA: 0x00099270 File Offset: 0x00097470
		public global::AcpBusinessLayer.AcpField<bool> TrkSysASTRO25WUIDValiditySupport_A41483
		{
			get
			{
				short num = (short)1984692224;
				short num2 = num;
				num = (short)1293716543;
				short num3 = num;
				num = (short)648186943;
				switch (num3 == num)
				{
				}
				num = (short)1767112705;
				if (num != 0)
				{
				}
				num = (short)549715968;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25WUIDValiditySupport_A41483;
			}
		}

		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x06000A4E RID: 2638 RVA: 0x00099320 File Offset: 0x00097520
		// (set) Token: 0x06000A4F RID: 2639 RVA: 0x000993D4 File Offset: 0x000975D4
		public bool TrkSysASTRO25WUIDValiditySupport_A41483_UIValue
		{
			get
			{
				short num = (short)1227816960;
				short num2 = num;
				num = (short)774245020;
				short num3 = num;
				num = (short)2021329564;
				switch (num3 == num)
				{
				}
				num = (short)2025848833;
				if (num != 0)
				{
				}
				num = (short)1105526784;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25WUIDValiditySupport_A41483.Value;
			}
			set
			{
				short num = (short)1652097024;
				short num2 = num;
				num = (short)1114499014;
				short num3 = num;
				num = (short)1560668102;
				switch (num3 == num)
				{
				}
				num = (short)909770753;
				if (num != 0)
				{
				}
				num = (short)736493568;
				if (num != 0)
				{
				}
				this.trkSysASTRO25WUIDValiditySupport_A41483.Value = value;
			}
		}

		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x06000A50 RID: 2640 RVA: 0x0009948C File Offset: 0x0009768C
		// (set) Token: 0x06000A51 RID: 2641 RVA: 0x00099540 File Offset: 0x00097740
		public bool TrkSysASTRO25WUIDValiditySupport_A41483_Applicable
		{
			get
			{
				short num = (short)1458110464;
				short num2 = num;
				num = (short)23747565;
				short num3 = num;
				num = (short)964975597;
				switch (num3 == num)
				{
				}
				num = (short)1706622977;
				if (num != 0)
				{
				}
				num = (short)1710817280;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25WUIDValiditySupport_A41483.Applicable;
			}
			set
			{
				short num = (short)1014890496;
				short num2 = num;
				num = (short)617866462;
				short num3 = num;
				num = (short)315942110;
				switch (num3 == num)
				{
				}
				num = (short)954793985;
				if (num != 0)
				{
				}
				num = (short)1889271808;
				if (num != 0)
				{
				}
				this.trkSysASTRO25WUIDValiditySupport_A41483.Applicable = value;
			}
		}

		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x06000A52 RID: 2642 RVA: 0x000995F4 File Offset: 0x000977F4
		// (set) Token: 0x06000A53 RID: 2643 RVA: 0x000996A8 File Offset: 0x000978A8
		public bool TrkSysASTRO25WUIDValiditySupport_A41483_Valid
		{
			get
			{
				short num = (short)2039939072;
				short num2 = num;
				num = (short)1265719702;
				short num3 = num;
				num = (short)337402262;
				switch (num3 == num)
				{
				}
				num = (short)214564865;
				if (num != 0)
				{
				}
				num = (short)816971776;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25WUIDValiditySupport_A41483.Valid;
			}
			set
			{
				short num = (short)1160577024;
				short num2 = num;
				num = (short)69599233;
				if (num != 0)
				{
				}
				num = (short)230872062;
				short num3 = num;
				num = (short)1464390654;
				switch (num3 == num)
				{
				}
				num = (short)1943535616;
				if (num != 0)
				{
				}
				this.trkSysASTRO25WUIDValiditySupport_A41483.Valid = value;
			}
		}

		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x06000A54 RID: 2644 RVA: 0x0009975C File Offset: 0x0009795C
		// (set) Token: 0x06000A55 RID: 2645 RVA: 0x00099810 File Offset: 0x00097A10
		public bool TrkSysASTRO25WUIDValiditySupport_A41483_Visible
		{
			get
			{
				short num = (short)2090205184;
				short num2 = num;
				num = (short)1211598134;
				short num3 = num;
				num = (short)2100921654;
				switch (num3 == num)
				{
				}
				num = (short)1369636864;
				if (num != 0)
				{
				}
				num = (short)732037121;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25WUIDValiditySupport_A41483.Visible;
			}
			set
			{
				short num = (short)478609408;
				short num2 = num;
				num = (short)1650680051;
				short num3 = num;
				num = (short)1459577075;
				switch (num3 == num)
				{
				}
				num = (short)280428544;
				if (num != 0)
				{
				}
				num = (short)1498611713;
				if (num != 0)
				{
				}
				this.trkSysASTRO25WUIDValiditySupport_A41483.Visible = value;
			}
		}

		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x06000A56 RID: 2646 RVA: 0x000998C4 File Offset: 0x00097AC4
		// (set) Token: 0x06000A57 RID: 2647 RVA: 0x00099978 File Offset: 0x00097B78
		public bool TrkSysASTRO25WUIDValiditySupport_A41483_Editable
		{
			get
			{
				short num = (short)720044032;
				short num2 = num;
				num = (short)1766345593;
				short num3 = num;
				num = (short)801721209;
				switch (num3 == num)
				{
				}
				num = (short)2128281600;
				if (num != 0)
				{
				}
				num = (short)1557659649;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25WUIDValiditySupport_A41483.Editable;
			}
			set
			{
				short num = (short)1653276672;
				short num2 = num;
				num = (short)72396525;
				short num3 = num;
				num = (short)884453101;
				switch (num3 == num)
				{
				}
				num = (short)241041409;
				if (num != 0)
				{
				}
				num = (short)1378549760;
				if (num != 0)
				{
				}
				this.trkSysASTRO25WUIDValiditySupport_A41483.Editable = value;
			}
		}

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x06000A58 RID: 2648 RVA: 0x00099A2C File Offset: 0x00097C2C
		internal string TrkSysASTRO25WUIDValiditySupport_A41483_UILabel
		{
			get
			{
				short num = (short)849739776;
				short num2 = num;
				num = (short)592950945;
				short num3 = num;
				num = (short)900839073;
				switch (num3 == num)
				{
				}
				num = (short)1710686209;
				if (num != 0)
				{
				}
				num = (short)1031405568;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25WUIDValiditySupport_A41483.UIName;
			}
		}

		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x06000A59 RID: 2649 RVA: 0x00099AE4 File Offset: 0x00097CE4
		// (set) Token: 0x06000A5A RID: 2650 RVA: 0x00099B98 File Offset: 0x00097D98
		internal bool TrkSysASTRO25WUIDValiditySupport_A41483_HiddenStatic
		{
			get
			{
				short num = (short)926023680;
				short num2 = num;
				num = (short)1391927900;
				short num3 = num;
				num = (short)1200300636;
				switch (num3 == num)
				{
				}
				num = (short)1848770560;
				if (num != 0)
				{
				}
				num = (short)774963201;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25WUIDValiditySupport_A41483.HiddenStatic;
			}
			set
			{
				short num = (short)2066153472;
				short num2 = num;
				num = (short)1390741433;
				short num3 = num;
				num = (short)776538041;
				switch (num3 == num)
				{
				}
				num = (short)799866881;
				if (num != 0)
				{
				}
				num = (short)478871552;
				if (num != 0)
				{
				}
				this.trkSysASTRO25WUIDValiditySupport_A41483.HiddenStatic = value;
			}
		}

		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x06000A5B RID: 2651 RVA: 0x00099C50 File Offset: 0x00097E50
		// (set) Token: 0x06000A5C RID: 2652 RVA: 0x00099D04 File Offset: 0x00097F04
		internal bool TrkSysASTRO25WUIDValiditySupport_A41483_HiddenDynamic
		{
			get
			{
				short num = (short)224460800;
				short num2 = num;
				num = (short)470655310;
				short num3 = num;
				num = (short)1905238350;
				switch (num3 == num)
				{
				}
				num = (short)823721985;
				if (num != 0)
				{
				}
				num = (short)1299251200;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25WUIDValiditySupport_A41483.HiddenDynamic;
			}
			set
			{
				short num = (short)1856176128;
				short num2 = num;
				num = (short)800718849;
				if (num != 0)
				{
				}
				num = (short)1023469124;
				short num3 = num;
				num = (short)18867780;
				switch (num3 == num)
				{
				}
				num = (short)952500224;
				if (num != 0)
				{
				}
				this.trkSysASTRO25WUIDValiditySupport_A41483.HiddenDynamic = value;
			}
		}

		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x06000A5D RID: 2653 RVA: 0x00099DB8 File Offset: 0x00097FB8
		public bool TrkSysASTRO25WUIDValiditySupport_A41483_HasDiffs
		{
			get
			{
				short num = (short)890241024;
				short num2 = num;
				num = (short)1250050602;
				short num3 = num;
				num = (short)1474970154;
				switch (num3 == num)
				{
				}
				num = (short)316801024;
				if (num != 0)
				{
				}
				num = (short)1654194177;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25WUIDValiditySupport_A41483._HasDiffs;
			}
		}

		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x06000A5E RID: 2654 RVA: 0x00099E70 File Offset: 0x00098070
		// (set) Token: 0x06000A5F RID: 2655 RVA: 0x00099F24 File Offset: 0x00098124
		public int TrkSysASTRO25GeoFenceMode_42322Value
		{
			get
			{
				short num = (short)1795358720;
				short num2 = num;
				num = (short)2103659296;
				short num3 = num;
				num = (short)1774471968;
				switch (num3 == num)
				{
				}
				num = (short)1512701953;
				if (num != 0)
				{
				}
				num = (short)725286912;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25GeoFenceMode_42322.Value;
			}
			set
			{
				short num = (short)677052416;
				short num2 = num;
				num = (short)1060928415;
				short num3 = num;
				num = (short)1873902495;
				switch (num3 == num)
				{
				}
				num = (short)1295384577;
				if (num != 0)
				{
				}
				num = (short)47448064;
				if (num != 0)
				{
				}
				this.trkSysASTRO25GeoFenceMode_42322.Value = value;
			}
		}

		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x06000A60 RID: 2656 RVA: 0x00099FE0 File Offset: 0x000981E0
		// (set) Token: 0x06000A61 RID: 2657 RVA: 0x0009A098 File Offset: 0x00098298
		public string TrkSysASTRO25GeoFenceMode_42322_UIValue
		{
			get
			{
				short num = (short)5373952;
				short num2 = num;
				num = (short)1189827431;
				short num3 = num;
				num = (short)1855607655;
				switch (num3 == num)
				{
				}
				num = (short)1215758337;
				if (num != 0)
				{
				}
				num = (short)1488388096;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25GeoFenceMode_42322.UIValue;
			}
			set
			{
				short num = (short)394067968;
				short num2 = num;
				num = (short)1515972837;
				short num3 = num;
				num = (short)187754725;
				switch (num3 == num)
				{
				}
				num = (short)1621557249;
				if (num != 0)
				{
				}
				num = (short)1341980672;
				if (num != 0)
				{
				}
				this.trkSysASTRO25GeoFenceMode_42322.UIValue = value;
			}
		}

		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x06000A62 RID: 2658 RVA: 0x0009A14C File Offset: 0x0009834C
		public global::AcpBusinessLayer.AcpListField TrkSysASTRO25GeoFenceMode_42322
		{
			get
			{
				short num = (short)64663580;
				short num2 = num;
				num = (short)743878684;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1375404032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1682374657;
				if (num != 0)
				{
				}
				num = (short)1042153472;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25GeoFenceMode_42322;
			}
		}

		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x06000A63 RID: 2659 RVA: 0x0009A1FC File Offset: 0x000983FC
		// (set) Token: 0x06000A64 RID: 2660 RVA: 0x0009A2B0 File Offset: 0x000984B0
		public bool TrkSysASTRO25GeoFenceMode_42322_Applicable
		{
			get
			{
				short num = (short)317652993;
				if (num != 0)
				{
				}
				num = (short)729219072;
				short num2 = num;
				num = (short)1317828347;
				short num3 = num;
				num = (short)622032635;
				switch (num3 == num)
				{
				}
				num = (short)813498368;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25GeoFenceMode_42322.Applicable;
			}
			set
			{
				short num = (short)865032179;
				short num2 = num;
				num = (short)2130532339;
				switch (num2 == num)
				{
				default:
				{
					num = (short)850460672;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)321650689;
				if (num != 0)
				{
				}
				num = (short)1387593728;
				if (num != 0)
				{
				}
				this.trkSysASTRO25GeoFenceMode_42322.Applicable = value;
			}
		}

		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x06000A65 RID: 2661 RVA: 0x0009A364 File Offset: 0x00098564
		// (set) Token: 0x06000A66 RID: 2662 RVA: 0x0009A41C File Offset: 0x0009861C
		public bool TrkSysASTRO25GeoFenceMode_42322_Valid
		{
			get
			{
				short num = (short)280836425;
				short num2 = num;
				num = (short)1339701577;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1476788224;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1684668417;
				if (num != 0)
				{
				}
				num = (short)61669376;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25GeoFenceMode_42322.Valid;
			}
			set
			{
				short num = (short)617021441;
				if (num != 0)
				{
				}
				num = (short)1438187520;
				short num2 = num;
				num = (short)333938313;
				short num3 = num;
				num = (short)1352236681;
				switch (num3 == num)
				{
				}
				num = (short)598474752;
				if (num != 0)
				{
				}
				this.trkSysASTRO25GeoFenceMode_42322.Valid = value;
			}
		}

		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x06000A67 RID: 2663 RVA: 0x0009A4D0 File Offset: 0x000986D0
		// (set) Token: 0x06000A68 RID: 2664 RVA: 0x0009A584 File Offset: 0x00098784
		public bool TrkSysASTRO25GeoFenceMode_42322_Visible
		{
			get
			{
				short num = (short)2023030785;
				if (num != 0)
				{
				}
				num = (short)1584726016;
				short num2 = num;
				num = (short)1710729050;
				short num3 = num;
				num = (short)438019930;
				switch (num3 == num)
				{
				}
				num = (short)485687296;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25GeoFenceMode_42322.Visible;
			}
			set
			{
				short num = (short)1216628034;
				short num2 = num;
				num = (short)762135874;
				switch (num2 == num)
				{
				default:
				{
					num = (short)851050496;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)403374081;
				if (num != 0)
				{
				}
				num = (short)1363542016;
				if (num != 0)
				{
				}
				this.trkSysASTRO25GeoFenceMode_42322.Visible = value;
			}
		}

		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x06000A69 RID: 2665 RVA: 0x0009A638 File Offset: 0x00098838
		// (set) Token: 0x06000A6A RID: 2666 RVA: 0x0009A6E8 File Offset: 0x000988E8
		public bool TrkSysASTRO25GeoFenceMode_42322_Editable
		{
			get
			{
				short num = (short)669646849;
				if (num != 0)
				{
				}
				num = (short)446824448;
				short num2 = num;
				num = (short)1490331644;
				short num3 = num;
				num = (short)1746839548;
				switch (num3 == num)
				{
				}
				num = (short)2096496640;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25GeoFenceMode_42322.Editable;
			}
			set
			{
				short num = (short)1245563244;
				short num2 = num;
				num = (short)259770732;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1810759680;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)55181313;
				if (num != 0)
				{
				}
				num = (short)2103115776;
				if (num != 0)
				{
				}
				this.trkSysASTRO25GeoFenceMode_42322.Editable = value;
			}
		}

		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x06000A6B RID: 2667 RVA: 0x0009A79C File Offset: 0x0009899C
		internal string TrkSysASTRO25GeoFenceMode_42322_UILabel
		{
			get
			{
				short num = (short)17039361;
				if (num != 0)
				{
				}
				num = (short)725614592;
				short num2 = num;
				num = (short)954635677;
				short num3 = num;
				num = (short)455251357;
				switch (num3 == num)
				{
				}
				num = (short)288620544;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25GeoFenceMode_42322.UIName;
			}
		}

		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x06000A6C RID: 2668 RVA: 0x0009A850 File Offset: 0x00098A50
		// (set) Token: 0x06000A6D RID: 2669 RVA: 0x0009A908 File Offset: 0x00098B08
		internal bool TrkSysASTRO25GeoFenceMode_42322_HiddenStatic
		{
			get
			{
				short num = (short)1043595442;
				short num2 = num;
				num = (short)1492451506;
				switch (num2 == num)
				{
				default:
				{
					num = (short)516554752;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1152516097;
				if (num != 0)
				{
				}
				num = (short)1734737920;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25GeoFenceMode_42322.HiddenStatic;
			}
			set
			{
				short num = (short)753555300;
				short num2 = num;
				num = (short)765417316;
				switch (num2 == num)
				{
				default:
				{
					num = (short)20250624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1843593217;
				if (num != 0)
				{
				}
				num = (short)1854210048;
				if (num != 0)
				{
				}
				this.trkSysASTRO25GeoFenceMode_42322.HiddenStatic = value;
			}
		}

		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x06000A6E RID: 2670 RVA: 0x0009A9BC File Offset: 0x00098BBC
		// (set) Token: 0x06000A6F RID: 2671 RVA: 0x0009AA70 File Offset: 0x00098C70
		internal bool TrkSysASTRO25GeoFenceMode_42322_HiddenDynamic
		{
			get
			{
				short num = (short)1032482054;
				short num2 = num;
				num = (short)2024107270;
				switch (num2 == num)
				{
				default:
				{
					num = (short)787415040;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1840250881;
				if (num != 0)
				{
				}
				num = (short)853409792;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25GeoFenceMode_42322.HiddenDynamic;
			}
			set
			{
				short num = (short)818544640;
				short num2 = num;
				num = (short)1713758192;
				short num3 = num;
				num = (short)844947440;
				switch (num3 == num)
				{
				}
				num = (short)2122055681;
				if (num != 0)
				{
				}
				num = (short)1961623552;
				if (num != 0)
				{
				}
				this.trkSysASTRO25GeoFenceMode_42322.HiddenDynamic = value;
			}
		}

		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x06000A70 RID: 2672 RVA: 0x0009AB24 File Offset: 0x00098D24
		public bool TrkSysASTRO25GeoFenceMode_42322_HasDiffs
		{
			get
			{
				short num = (short)192086016;
				short num2 = num;
				num = (short)143130625;
				if (num != 0)
				{
				}
				num = (short)1882374645;
				short num3 = num;
				num = (short)1505214965;
				switch (num3 == num)
				{
				}
				num = (short)753074176;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25GeoFenceMode_42322._HasDiffs;
			}
		}

		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x06000A71 RID: 2673 RVA: 0x0009ABDC File Offset: 0x00098DDC
		public global::Motorola.MackinawCPS.CoreFeatures.DVRSWide.DVRSWide RefDVRSWide
		{
			get
			{
				short num = (short)583663616;
				short num2 = num;
				num = (short)78245892;
				short num3 = num;
				num = (short)1872162820;
				switch (num3 == num)
				{
				}
				num = (short)1673920513;
				if (num != 0)
				{
				}
				num = (short)1564344320;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(4142)[0] as global::Motorola.MackinawCPS.CoreFeatures.DVRSWide.DVRSWide;
			}
		}

		// Token: 0x06000A72 RID: 2674 RVA: 0x0009AC9C File Offset: 0x00098E9C
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
						num2 = (short)1081868290;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 1:
				{
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)691126753;
					short num3 = num2;
					num2 = (short)300138977;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num2 = (short)549978112;
						if (num2 != 0)
						{
						}
						num2 = (short)1273298948;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 2:
					num2 = (short)1118568449;
					if (num2 != 0)
					{
					}
					num2 = (short)564527107;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)1761017857;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 4:
					return result;
				}
				goto IL_24;
			}
			return result;
			IL_24:
			num2 = (short)1503723520;
			short num4 = num2;
			result = null;
			num2 = (short)2106720256;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04000332 RID: 818
		private global::AcpBusinessLayer.AcpField<bool> trkSysASTRO25EndF2TDMATransmitOnOutOfRange_A1394;

		// Token: 0x04000333 RID: 819
		private global::AcpBusinessLayer.AcpField<bool> trkSysASTRO25F2VoiceCapable_A1395;

		// Token: 0x04000334 RID: 820
		private global::AcpBusinessLayer.AcpSimpleRangeField trkSysASTRO25BusyUpdateTimesec_A7574;

		// Token: 0x04000335 RID: 821
		private global::AcpBusinessLayer.AcpSimpleRangeField trkSysASTRO25DefaultRCMAddress_A7813;

		// Token: 0x04000336 RID: 822
		private global::AcpBusinessLayer.AcpSimpleRangeField trkSysASTRO25ForceUnmuteTimems_A8141;

		// Token: 0x04000337 RID: 823
		private global::AcpBusinessLayer.AcpSimpleRangeField trkSysASTRO25ISPSequenceLengthsec_A8354;

		// Token: 0x04000338 RID: 824
		private global::AcpBusinessLayer.AcpCustomRangeField trkSysASTRO25MaximumSlotSizems_A8478;

		// Token: 0x04000339 RID: 825
		private global::AcpBusinessLayer.AcpField<bool> trkSysASTRO25MotorolaProprietaryFeatures_A8547;

		// Token: 0x0400033A RID: 826
		private global::AcpBusinessLayer.AcpSimpleRangeField trkSysASTRO25PTTWarningTimems_A8781;

		// Token: 0x0400033B RID: 827
		private global::AcpBusinessLayer.AcpSimpleRangeField trkSysASTRO25ResponsePendingTimesec_A8945;

		// Token: 0x0400033C RID: 828
		private global::AcpBusinessLayer.AcpField<bool> trkSysASTRO25ValidateNACAgainstSystemID_A20608;

		// Token: 0x0400033D RID: 829
		private global::AcpBusinessLayer.AcpField<bool> trkSysASTRO25Phase2VoiceCapable_A37972;

		// Token: 0x0400033E RID: 830
		private global::AcpBusinessLayer.AcpField<bool> trkSysASTRO25EndPhase2TDMATransmitOnOutOfRange_A37980;

		// Token: 0x0400033F RID: 831
		private global::AcpBusinessLayer.AcpSimpleRangeField trkSysASTRO25QuickFadeProtectms_A8807;

		// Token: 0x04000340 RID: 832
		private global::AcpBusinessLayer.AcpField<bool> trkSysASTRO25WUIDValiditySupport_A41483;

		// Token: 0x04000341 RID: 833
		private global::AcpBusinessLayer.AcpListField trkSysASTRO25GeoFenceMode_42322;
	}
}
