using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using ConstraintHelper;
using Features.Converters;
using Features.Radio_Ergonomics_Configuration.Display_and_Menu;
using Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality;
using Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu;
using Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide;
using Motorola.MackinawCPS.CoreFeatures.RadioProfiles;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;
using Motorola.MackinawCPS.CoreFeatures.ScanList;
using Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality;
using Motorola.MackinawCPS.CoreFeatures.TrunkingSystem;

namespace Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment
{
	// Token: 0x02000039 RID: 57
	[global::System.Serializable]
	public class ChannelAssignmentListInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06000046 RID: 70 RVA: 0x0000B67C File Offset: 0x0000987C
		public ChannelAssignmentListInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06000047 RID: 71 RVA: 0x0000B698 File Offset: 0x00009898
		protected ChannelAssignmentListInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06000048 RID: 72 RVA: 0x0000B6B0 File Offset: 0x000098B0
		public override void Init()
		{
			int a_ = 5;
			short num = (short)1062141952;
			short num2 = num;
			num = (short)352959098;
			short num3 = num;
			num = (short)1891744378;
			switch (num3 == num)
			{
			}
			num = (short)832110593;
			if (num != 0)
			{
			}
			num = (short)157548544;
			if (num != 0)
			{
			}
			this.d();
			this.channelsActiveChannel = new global::AcpBusinessLayer.AcpFieldX<bool, bool>(false, new global::Features.Converters.UnpackAndPackAndInvertBooleanField(), this, global::AllFeatures.CodeplugGuid.b("藅ꃇꯉꋋꃍ뗏뻑ꟓ韕믗껙뗛꣝藟ꇡ賣蟥蛧蓩觫苭", a_), global::CommonResources.AcgResources.ID_ACTIVECHANNEL);
			this.channelsActiveChannel.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.channelsActiveChannel.DataTransferOrder = 16;
			this.znChanCfgChannelsChannelName_A7659 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("鳅ꛇ觉꓋꿍뻏金닓뇕鯗닙뷛냝軟蟡裣闥ꯧ苩跫胭黯韱飳룵駷韹駻ꇽ䇿㔁㈃㌅ㄇ", a_), global::CommonResources.AcgResources.ID_CHANNELNAME, 20);
			this.znChanCfgChannelsChannelName_A7659.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.znChanCfgChannelsChannelName_A7659.DataTransferOrder = 10;
			this.znChanCfgChannelsPersonality_A8698 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("鳅ꛇ觉꓋꿍뻏金닓뇕鯗닙뷛냝軟蟡裣闥룧迩黫鷭鿯鳱闳髵釷軹藻ꇽ䇿㨁㈃㼅〇", a_), global::CommonResources.AcgResources.ID_PERSONALITY, null, null, true, false);
			this.znChanCfgChannelsPersonality_A8698.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.znChanCfgChannelsPersonality_A8698.DataTransferOrder = 2;
			this.znChanCfgChannelsPersonality_A8698.EvaluateRecRefs = true;
			this.znChanCfgChannelsFiregroundSectorID_A33630 = new global::AcpBusinessLayer.AcpRangeField<int, string>(0, new global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.UnpackDecToHexPackHexToDecStr2(), this, global::AllFeatures.CodeplugGuid.b("鳅ꛇ觉꓋꿍뻏金닓뇕鯗닙뷛냝軟蟡裣闥껧菩黫语韯胱鯳菵雷黹꿻鯽揿瘁欃琅䄇三匋伍⌏ℑ∓┕⠗", a_), global::CommonResources.AcgResources.ID_PERSONNELACCOUNTABILITYSECTORIDHEX, 0, 255, 1, global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.LegacyTitles.ZnChanCfgChannelsFiregroundSectorID_A33630LegacyTitles);
			this.znChanCfgChannelsFiregroundSectorID_A33630.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.znChanCfgChannelsFiregroundSectorID_A33630.DataTransferOrder = 188;
			this.znChanCfgChannelsFiregroundSectorID_A33630.ValidateAcrossRecset = true;
			this.znChanCfgChannelsFiregroundSectorID_A33630.EvaluateRecRefs = true;
			this.znChanCfgChannelsFiregroundSectorID_A33630.ShowHexValue = false;
			string name = global::AllFeatures.CodeplugGuid.b("鳅ꛇ觉꓋꿍뻏金닓뇕鯗닙뷛냝軟蟡裣闥볧诩胫藭韯胱鯳菵裷ꗹ뷻쟽㋿㔁㈃", a_);
			string id_TRUNKINGTALKGROUP = global::CommonResources.AcgResources.ID_TRUNKINGTALKGROUP;
			string[] prependStrings = new string[]
			{
				global::CommonResources.AcgResources.ID_DYN,
				global::CommonResources.AcgResources.ID_ATG
			};
			int[] array = new int[2];
			array[0] = 65535;
			this.znChanCfgChannelsTalkgroup_A9276 = new global::AcpBusinessLayer.AcpRecRefField(this, name, id_TRUNKINGTALKGROUP, prependStrings, array, true, true);
			this.znChanCfgChannelsTalkgroup_A9276.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.znChanCfgChannelsTalkgroup_A9276.DataTransferOrder = 15;
			this.znChanCfgChannelsTalkgroup_A9276.EvaluateRecRefs = true;
			this.znChanCfgChannelsTopDisplayChannel_A19774 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_C, this, global::AllFeatures.CodeplugGuid.b("鳅ꛇ觉꓋꿍뻏金닓뇕鯗닙뷛냝軟蟡裣闥볧藩鳫ꫭ駯臱蓳髵駷菹뿻雽懿氁樃挅搇唉䴋㼍⤏┑⌓∕", a_), global::CommonResources.AcgResources.ID_TOPDISPLAYCHANNEL, 8);
			this.znChanCfgChannelsTopDisplayChannel_A19774.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.znChanCfgChannelsTopDisplayChannel_A19774.DataTransferOrder = 13;
			this.channelAnnouncementID_A20175 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("藅ꃇꯉꋋꃍ뗏뻑闓룕뛗뗙꧛냝菟蟡解菥蛧黩ꗫꫭ꿯돱웳웵짷췹짻", a_), global::CommonResources.AcgResources.ID_CHANNELANNOUNCEMENT, new string[]
			{
				global::CommonResources.AcgResources.ID_NONE,
				global::CommonResources.AcgResources.ID_TTS
			}, new int[]
			{
				0,
				65535
			}, true, false);
			this.channelAnnouncementID_A20175.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.channelAnnouncementID_A20175.DataTransferOrder = 6;
			this.vCChannelAnnouncement_A20176 = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::AllFeatures.CodeplugGuid.b("郅诇觉꓋꿍뻏병뇓뫕駗듙닛뇝闟賡蟣菥藧迩苫髭꿯돱웳웵짷췹쫻", a_), global::CommonResources.AcgResources.ID_VC_Channel_TTSANNOUNCEMENT, 35);
			this.vCChannelAnnouncement_A20176.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.vCChannelAnnouncement_A20176.DataTransferOrder = 20;
			this.znChanCfgChannelsRadioProfileCompositeItemNameID_A20192 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("鳅ꛇ觉꓋꿍뻏金닓뇕鯗닙뷛냝軟蟡裣闥뫧诩裫蟭鿯ꋱ蛳駵黷鏹郻鯽䏿洁椃瘅朇礉攋稍甏嬑怓猕甗吙紛猝䔟次怣礥椧ᠩᰫἭय1", a_), global::CommonResources.AcgResources.ID_RADIOPROFILESELECTION, new string[]
			{
				global::CommonResources.AcgResources.ID_LASTSELECTED
			}, new int[1], true, false);
			this.znChanCfgChannelsRadioProfileCompositeItemNameID_A20192.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.znChanCfgChannelsRadioProfileCompositeItemNameID_A20192.DataTransferOrder = 7;
			this.znChanCfgChannelsConventionalChannelReference_A20560 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("鳅ꛇ觉꓋꿍뻏金닓뇕鯗닙뷛냝軟蟡裣闥ꯧ藩苫飭闯鳱胳鿵韷铹鷻鋽䏿樁攃栅昇漉怋對甏琑焓搕紗琙缛笝缟挡ᘣᘥᴧᰩᰫ", a_), global::CommonResources.AcgResources.ID_CONVENTIONALFREQUENCYOPTION, null, null, false, false);
			this.znChanCfgChannelsConventionalChannelReference_A20560.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.znChanCfgChannelsConventionalChannelReference_A20560.DataTransferOrder = 9;
			this.znChanCfgChannelsConventionalChannelReference_A20560.EvaluateRecRefs = true;
			this.znChanCfgChannelsChannelType_A22241 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.LOVs.indexZnChanCfgChannelsChannelType_A22241LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.LOVs.idZnChanCfgChannelsChannelType_A22241LovStrs), this, global::AllFeatures.CodeplugGuid.b("鳅ꛇ觉꓋꿍뻏金닓뇕鯗닙뷛냝軟蟡裣闥ꯧ苩跫胭黯韱飳ꋵ臷諹駻ꇽ䇿、㘃㐅㰇㬉", a_), global::CommonResources.AcgResources.ID_CHANNELTYPE, global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.LOVs.ZnChanCfgChannelsChannelType_A22241LovStrs);
			this.znChanCfgChannelsChannelType_A22241.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.znChanCfgChannelsChannelType_A22241.DataTransferOrder = 1;
			this.znChanCfgChannelsChannelType_A22241.EvaluateRecRefs = true;
			this.znChanCfgChannelsFallbackZone = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("鳅ꛇ觉꓋꿍뻏金닓뇕鯗닙뷛냝軟蟡裣闥껧诩胫苭鋯鏱音鷵ꋷ闹鋻鯽", a_), global::CommonResources.AcgResources.ID_FALLBACKZONE, new string[]
			{
				global::AllFeatures.CodeplugGuid.b("苅ꇇ막귋곍볏럑냓", a_)
			}, new int[1], true, false);
			this.znChanCfgChannelsFallbackZone.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.znChanCfgChannelsFallbackZone.DataTransferOrder = 30;
			this.znChanCfgChannelsFallbackZone.EvaluateRecRefs = true;
			this.znChanCfgChannelsFallbackChannel = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("鳅ꛇ觉꓋꿍뻏金닓뇕鯗닙뷛냝軟蟡裣闥껧诩胫苭鋯鏱音鷵믷鋹鷻都滿朁栃", a_), global::CommonResources.AcgResources.ID_FALLBACKCHANNEL, new string[]
			{
				global::AllFeatures.CodeplugGuid.b("苅ꇇ막귋곍볏럑냓", a_)
			}, new int[1], true, false);
			this.znChanCfgChannelsFallbackChannel.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.znChanCfgChannelsFallbackChannel.DataTransferOrder = 31;
			this.znChanCfgChannelsFallbackChannel.EvaluateRecRefs = true;
			this.znChanCfgTopLightColor_A43173 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鳅ꛇ觉꓋꿍뻏金닓뇕賗뗙곛鋝觟藡賣鋥ꯧ藩胫臭苯귱뗳싵쯷쯹쯻췽", a_), global::CommonResources.AcgResources.ID_CHANNELCOLORBACKLIGHTSELECTION, global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.LOVs.ZnChanCfgTopLightColor_A43173LovStrs);
			this.znChanCfgTopLightColor_A43173.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.znChanCfgTopLightColor_A43173.DataTransferOrder = 18;
			this.znChanCfgChannelsChannelColorBacklightSelection_43749 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鳅ꛇ觉꓋꿍뻏金닓뇕鯗닙뷛냝軟蟡裣闥ꯧ苩跫胭黯韱飳뗵韷雹鏻賽䋿持會洅搇按欋昍搏䄑焓稕紗礙栛眝伟䰡笣ሥᬧᴩᠫᜭ", a_), global::CommonResources.AcgResources.ID_CHANNELCOLORBACKLIGHTSELECTION_E5, global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.LOVs.ZnChanCfgChannelColorBacklightSelection_43749LovStrs);
			this.znChanCfgChannelsChannelColorBacklightSelection_43749.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.znChanCfgChannelsChannelColorBacklightSelection_43749.DataTransferOrder = 19;
			this.znChanCfgChannelsWiFi = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鳅ꛇ觉꓋꿍뻏金닓뇕鯗닙뷛냝軟蟡裣闥뿧菩ꫫ蟭", a_), global::CommonResources.AcgResources.ID_ZONECHANNELWIFI, global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.LOVs.ZnChanCfgChannelsWiFiLovStrs);
			this.znChanCfgChannelsWiFi.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.znChanCfgChannelsWiFi.DataTransferOrder = 32;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("藅ꃇꯉꋋꃍ뗏뻑韕ꯗ꧙뗛망軟迡臣裥鳧쫩ꃫ蟭華蛱", a_);
			base.Id = 10115;
			base.UIName = global::CommonResources.AcgResources.ID_CHANNELASSIGNMENTLIST;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06000049 RID: 73 RVA: 0x0000BC7C File Offset: 0x00009E7C
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 15;
			short num = (short)1282998314;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_A3E;
				case 1:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("諏병韓뻕맗듙鿛룝蟟ꇡ賣蟥蛧蓩觫苭華등鷳蓵鷷鷹軻釽痿氁怃唅洇椉砋愍戏嬑倓䤕夗⤙⼛⠝ጟሡ", a_)))
					{
						num = (short)1164312600;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_69B;
				case 2:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏏뫑뗓룕뛗뿙냛鿝軟賡诣鏥蛧觩觫菭闯鳱胳뿵볷ꗹ뷻쳽ヿ㌁㌃㌅", a_)))
					{
						num = (short)1928658975;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A8A;
				case 3:
					this.znChanCfgChannelsChannelName_A7659 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("諏병韓뻕맗듙鿛룝蟟ꇡ賣蟥蛧蓩觫苭華뇱鳳韵雷铹駻鋽仿持椃挅圇䬉㬋㠍┏⬑", a_), global::CommonResources.AcgResources.ID_CHANNELNAME, 20);
					this.znChanCfgChannelsChannelName_A7659.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.znChanCfgChannelsChannelName_A7659.DataTransferOrder = 10;
					num = (short)2086273038;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					num = (short)1800339491;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_B31;
				case 6:
					goto IL_3D1;
				case 7:
					goto IL_555;
				case 8:
					goto IL_267;
				case 9:
					goto IL_CC1;
				case 10:
					this.znChanCfgChannelsPersonality_A8698 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("諏병韓뻕맗듙鿛룝蟟ꇡ賣蟥蛧蓩觫苭華ꋱ釳蓵请闹鋻鿽泿欁瀃缅圇䬉㐋㠍⤏⨑", a_), global::CommonResources.AcgResources.ID_PERSONALITY, null, null, true, false);
					this.znChanCfgChannelsPersonality_A8698.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.znChanCfgChannelsPersonality_A8698.DataTransferOrder = 2;
					this.znChanCfgChannelsPersonality_A8698.EvaluateRecRefs = true;
					num = (short)566296610;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("諏병韓뻕맗듙鿛룝蟟뛡诣雥ꓧ菩诫蛭蓯뇱鯳髵韷裹ꏻ뿽㓿㄁㔃ㄅ㬇", a_)))
					{
						num = (short)1980301330;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_6EA;
				case 12:
					this.znChanCfgChannelsRadioProfileCompositeItemNameID_A20192 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("諏병韓뻕맗듙鿛룝蟟ꇡ賣蟥蛧蓩觫苭華ꃱ闳鋵釷闹곻賽濿搁洃樅洇䤉挋挍怏紑朓缕気缙唛樝䔟伡樣䜥䔧伩攫樭漯猱سصष̹฻", a_), global::CommonResources.AcgResources.ID_RADIOPROFILESELECTION, new string[]
					{
						global::CommonResources.AcgResources.ID_LASTSELECTED
					}, new int[1], true, false);
					this.znChanCfgChannelsRadioProfileCompositeItemNameID_A20192.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.znChanCfgChannelsRadioProfileCompositeItemNameID_A20192.DataTransferOrder = 7;
					num = (short)1994391584;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("諏병韓뻕맗듙鿛룝蟟ꇡ賣蟥蛧蓩觫苭華뇱鳳韵雷铹駻鋽仿持椃挅圇䬉㬋㠍┏⬑", a_)))
					{
						num = (short)1233518595;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5E1;
				case 14:
					goto IL_5E1;
				case 15:
					goto IL_6EA;
				case 16:
					if (producerFields != null)
					{
						num = (short)805961732;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_D58;
				case 17:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("諏병韓뻕맗듙鿛룝蟟ꇡ賣蟥蛧蓩觫苭華뇱鯳飵軷鿹鋻諽槿洁樃朅搇䤉搋漍縏簑焓稕䨗缙稛笝刟䜡䨣䔥䴧甩洫ᰭ/ܱȳص", a_)))
					{
						num = (short)1800601644;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_B31;
				case 18:
					this.znChanCfgTopLightColor_A43173 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("諏병韓뻕맗듙鿛룝蟟뛡诣雥ꓧ菩诫蛭蓯뇱鯳髵韷裹ꏻ뿽㓿㄁㔃ㄅ㬇", a_), global::CommonResources.AcgResources.ID_CHANNELCOLORBACKLIGHTSELECTION, global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.LOVs.ZnChanCfgTopLightColor_A43173LovStrs);
					this.znChanCfgTopLightColor_A43173.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.znChanCfgTopLightColor_A43173.DataTransferOrder = 18;
					goto IL_4E3;
				case 19:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蛏金韓뻕맗듙닛믝賟ꏡ諣裥蟧鿩苫跭闯鿱釳飵賷ꗹ뷻쳽ヿ㌁㌃々", a_)))
					{
						num = (short)1635450908;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3D1;
				case 20:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("諏병韓뻕맗듙鿛룝蟟ꇡ賣蟥蛧蓩觫苭華ꋱ釳蓵请闹鋻鿽泿欁瀃缅圇䬉㐋㠍⤏⨑", a_)))
					{
						num = (short)1222443018;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_62A;
				case 21:
					this.znChanCfgChannelsFallbackChannel = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("諏병韓뻕맗듙鿛룝蟟ꇡ賣蟥蛧蓩觫苭華등闳髵铷飹鷻鷽毿䄁氃朅昇搉椋戍", a_), global::CommonResources.AcgResources.ID_FALLBACKCHANNEL, new string[]
					{
						global::CommonResources.AcgResources.ID_DISABLED
					}, new int[1], true, false);
					this.znChanCfgChannelsFallbackChannel.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.znChanCfgChannelsFallbackChannel.DataTransferOrder = 31;
					this.znChanCfgChannelsFallbackChannel.EvaluateRecRefs = true;
					num = (short)1656422408;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 22:
					goto IL_123;
				case 23:
					this.znChanCfgChannelsWiFi = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("諏병韓뻕맗듙鿛룝蟟ꇡ賣蟥蛧蓩觫苭華ꗱ鷳냵釷", a_), global::CommonResources.AcgResources.ID_ZONECHANNELWIFI, global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.LOVs.ZnChanCfgChannelsWiFiLovStrs);
					this.znChanCfgChannelsWiFi.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.znChanCfgChannelsWiFi.DataTransferOrder = 32;
					num = (short)34013191;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 24:
					num = (short)1812987905;
					if (num != 0)
					{
					}
					this.znChanCfgChannelsFiregroundSectorID_A33630 = new global::AcpBusinessLayer.AcpRangeField<int, string>(0, new global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.UnpackDecToHexPackHexToDecStr2(), this, global::AllFeatures.CodeplugGuid.b("諏병韓뻕맗듙鿛룝蟟ꇡ賣蟥蛧蓩觫苭華등鷳蓵鷷鷹軻釽痿氁怃唅洇椉砋愍戏嬑倓䤕夗⤙⼛⠝ጟሡ", a_), global::CommonResources.AcgResources.ID_PERSONNELACCOUNTABILITYSECTORIDHEX, global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.LegacyTitles.ZnChanCfgChannelsFiregroundSectorID_A33630LegacyTitles);
					this.znChanCfgChannelsFiregroundSectorID_A33630.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.znChanCfgChannelsFiregroundSectorID_A33630.DataTransferOrder = 188;
					this.znChanCfgChannelsFiregroundSectorID_A33630.ValidateAcrossRecset = true;
					this.znChanCfgChannelsFiregroundSectorID_A33630.EvaluateRecRefs = true;
					this.znChanCfgChannelsFiregroundSectorID_A33630.ShowHexValue = false;
					num = (short)434176051;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 25:
					this.channelsActiveChannel = new global::AcpBusinessLayer.AcpFieldX<bool, bool>(false, new global::Features.Converters.UnpackAndPackAndInvertBooleanField(), this, global::AllFeatures.CodeplugGuid.b("鏏뫑뗓룕뛗뿙냛귝ꇟ臡郣迥黧迩꿫蛭釯鳱髳鏵铷", a_), global::CommonResources.AcgResources.ID_ACTIVECHANNEL);
					this.channelsActiveChannel.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.channelsActiveChannel.DataTransferOrder = 16;
					num = (short)1232076839;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 26:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("諏병韓뻕맗듙鿛룝蟟ꇡ賣蟥蛧蓩觫苭華등闳髵铷飹鷻鷽毿䄁氃朅昇搉椋戍", a_)))
					{
						num = (short)2013200405;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_267;
				case 27:
					num = (short)916389904;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 28:
					this.vCChannelAnnouncement_A20176 = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::AllFeatures.CodeplugGuid.b("蛏金韓뻕맗듙닛믝賟ꏡ諣裥蟧鿩苫跭闯鿱釳飵賷ꗹ뷻쳽ヿ㌁㌃々", a_), global::CommonResources.AcgResources.ID_VC_Channel_TTSANNOUNCEMENT, 35);
					this.vCChannelAnnouncement_A20176.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.vCChannelAnnouncement_A20176.DataTransferOrder = 20;
					num = (short)808517638;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 29:
				{
					num = (short)2103967744;
					short num3 = num;
					this.znChanCfgChannelsFallbackZone = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("諏병韓뻕맗듙鿛룝蟟ꇡ賣蟥蛧蓩觫苭華등闳髵铷飹鷻鷽毿堁欃栅洇", a_), global::CommonResources.AcgResources.ID_FALLBACKZONE, new string[]
					{
						global::CommonResources.AcgResources.ID_DISABLED
					}, new int[1], true, false);
					this.znChanCfgChannelsFallbackZone.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.znChanCfgChannelsFallbackZone.DataTransferOrder = 30;
					this.znChanCfgChannelsFallbackZone.EvaluateRecRefs = true;
					num = (short)1871970349;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 30:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("諏병韓뻕맗듙鿛룝蟟ꇡ賣蟥蛧蓩觫苭華ꗱ鷳냵釷", a_)))
					{
						num = (short)1328087063;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_D58;
				case 31:
					this.channelAnnouncementID_A20175 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("鏏뫑뗓룕뛗뿙냛鿝軟賡诣鏥蛧觩觫菭闯鳱胳뿵볷ꗹ뷻쳽ヿ㌁㌃㌅", a_), global::CommonResources.AcgResources.ID_CHANNELANNOUNCEMENT, new string[]
					{
						global::CommonResources.AcgResources.ID_NONE,
						global::CommonResources.AcgResources.ID_TTS
					}, new int[]
					{
						0,
						65535
					}, true, false);
					this.channelAnnouncementID_A20175.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.channelAnnouncementID_A20175.DataTransferOrder = 6;
					num = (short)1686634539;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 32:
					goto IL_C18;
				case 33:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("諏병韓뻕맗듙鿛룝蟟ꇡ賣蟥蛧蓩觫苭華ꃱ闳鋵釷闹곻賽濿搁洃樅洇䤉挋挍怏紑朓缕気缙唛樝䔟伡樣䜥䔧伩攫樭漯猱سصष̹฻", a_)))
					{
						num = (short)2089877516;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_C18;
				case 34:
					goto IL_62A;
				case 35:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏏뫑뗓룕뛗뿙냛귝ꇟ臡郣迥黧迩꿫蛭釯鳱髳鏵铷", a_)))
					{
						num = (short)1637941273;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2B3;
				case 36:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("諏병韓뻕맗듙鿛룝蟟ꇡ賣蟥蛧蓩觫苭華뇱鳳韵雷铹駻鋽䏿洁栃椅稇䠉洋洍笏縑紓焕瀗渙伛笝䰟䜡䜣別䄧䔩䈫焭Яı̳ȵķ", a_)))
					{
						num = (short)1282867250;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_CC1;
				case 37:
					goto IL_55A;
				case 38:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("諏병韓뻕맗듙鿛룝蟟ꇡ賣蟥蛧蓩觫苭華꛱闳髵鏷鷹軻釽痿爁嬃䜅ㄇ㠉㬋㠍", a_)))
					{
						num = (short)874774568;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A3E;
				case 39:
					goto IL_2B3;
				case 40:
				{
					string name = global::AllFeatures.CodeplugGuid.b("諏병韓뻕맗듙鿛룝蟟ꇡ賣蟥蛧蓩觫苭華꛱闳髵鏷鷹軻釽痿爁嬃䜅ㄇ㠉㬋㠍", a_);
					string id_TRUNKINGTALKGROUP = global::CommonResources.AcgResources.ID_TRUNKINGTALKGROUP;
					string[] prependStrings = new string[]
					{
						global::CommonResources.AcgResources.ID_DYN,
						global::CommonResources.AcgResources.ID_ATG
					};
					int[] array = new int[2];
					array[0] = 65535;
					this.znChanCfgChannelsTalkgroup_A9276 = new global::AcpBusinessLayer.AcpRecRefField(this, name, id_TRUNKINGTALKGROUP, prependStrings, array, true, true);
					this.znChanCfgChannelsTalkgroup_A9276.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.znChanCfgChannelsTalkgroup_A9276.DataTransferOrder = 15;
					this.znChanCfgChannelsTalkgroup_A9276.EvaluateRecRefs = true;
					num = (short)1695678464;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 41:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("諏병韓뻕맗듙鿛룝蟟ꇡ賣蟥蛧蓩觫苭華등闳髵铷飹鷻鷽毿堁欃栅洇", a_)))
					{
						num = (short)2008678429;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_D0A;
				case 42:
					switch (0)
					{
					case 0:
						goto IL_FD;
					}
					continue;
				case 43:
					goto IL_A8A;
				case 44:
					this.znChanCfgChannelsConventionalChannelReference_A20560 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("諏병韓뻕맗듙鿛룝蟟ꇡ賣蟥蛧蓩觫苭華뇱鯳飵軷鿹鋻諽槿洁樃朅搇䤉搋漍縏簑焓稕䨗缙稛笝刟䜡䨣䔥䴧甩洫ᰭ/ܱȳص", a_), global::CommonResources.AcgResources.ID_CONVENTIONALFREQUENCYOPTION, null, null, false, false);
					this.znChanCfgChannelsConventionalChannelReference_A20560.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.znChanCfgChannelsConventionalChannelReference_A20560.DataTransferOrder = 9;
					this.znChanCfgChannelsConventionalChannelReference_A20560.EvaluateRecRefs = true;
					num = (short)183435269;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 45:
					goto IL_D0A;
				case 46:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("諏병韓뻕맗듙鿛룝蟟ꇡ賣蟥蛧蓩觫苭華뇱鳳韵雷铹駻鋽哿笁球挅圇䬉㸋㰍∏☑┓", a_)))
					{
						num = (short)206766128;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_123;
				case 47:
					this.znChanCfgChannelsTopDisplayChannel_A19774 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_C, this, global::AllFeatures.CodeplugGuid.b("諏병韓뻕맗듙鿛룝蟟ꇡ賣蟥蛧蓩觫苭華꛱鯳蛵볷鏹迻軽泿持紃䔅怇欉戋怍甏縑䬓圕⤗⌙⬛⤝ᐟ", a_), global::CommonResources.AcgResources.ID_TOPDISPLAYCHANNEL, 8);
					this.znChanCfgChannelsTopDisplayChannel_A19774.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.znChanCfgChannelsTopDisplayChannel_A19774.DataTransferOrder = 13;
					num = (short)209125413;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 48:
				{
					num = (short)991957528;
					short num4 = num;
					num = (short)1951928856;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_4E3;
					default:
						num = (short)498597888;
						if (num != 0)
						{
						}
						this.znChanCfgChannelsChannelType_A22241 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.LOVs.indexZnChanCfgChannelsChannelType_A22241LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.LOVs.idZnChanCfgChannelsChannelType_A22241LovStrs), this, global::AllFeatures.CodeplugGuid.b("諏병韓뻕맗듙鿛룝蟟ꇡ賣蟥蛧蓩觫苭華뇱鳳韵雷铹駻鋽哿笁球挅圇䬉㸋㰍∏☑┓", a_), global::CommonResources.AcgResources.ID_CHANNELTYPE, global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.LOVs.ZnChanCfgChannelsChannelType_A22241LovStrs);
						this.znChanCfgChannelsChannelType_A22241.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
						this.znChanCfgChannelsChannelType_A22241.DataTransferOrder = 1;
						this.znChanCfgChannelsChannelType_A22241.EvaluateRecRefs = true;
						num = (short)1263337494;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 49:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("諏병韓뻕맗듙鿛룝蟟ꇡ賣蟥蛧蓩觫苭華꛱鯳蛵볷鏹迻軽泿持紃䔅怇欉戋怍甏縑䬓圕⤗⌙⬛⤝ᐟ", a_)))
					{
						num = (short)1367015471;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_55A;
				case 50:
					this.znChanCfgChannelsChannelColorBacklightSelection_43749 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("諏병韓뻕맗듙鿛룝蟟ꇡ賣蟥蛧蓩觫苭華뇱鳳韵雷铹駻鋽䏿洁栃椅稇䠉洋洍笏縑紓焕瀗渙伛笝䰟䜡䜣別䄧䔩䈫焭Яı̳ȵķ", a_), global::CommonResources.AcgResources.ID_CHANNELCOLORBACKLIGHTSELECTION_E5, global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.LOVs.ZnChanCfgChannelColorBacklightSelection_43749LovStrs);
					this.znChanCfgChannelsChannelColorBacklightSelection_43749.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.znChanCfgChannelsChannelColorBacklightSelection_43749.DataTransferOrder = 19;
					num = (short)1434255369;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 51:
					goto IL_69B;
				}
				IL_FD:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)202965019;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_123:
				num = (short)1396703273;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_267:
				num = (short)116588555;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2B3:
				num = (short)1712979981;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3D1:
				num = (short)898695201;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_4E3:
				num = (short)1607729167;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_55A:
				num = (short)257753090;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_5E1:
				num = (short)1650130964;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_62A:
				num = (short)1165426689;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_69B:
				num = (short)965476390;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_6EA:
				num = (short)1165885476;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_A3E:
				num = (short)1715666993;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_A8A:
				num = (short)1023803411;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_B31:
				num = (short)1668087854;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_C18:
				num = (short)1541734417;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_CC1:
				num = (short)1035468830;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_D0A:
				num = (short)1085210650;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_555:
			IL_D58:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鏏뫑뗓룕뛗뿙냛ﻝꇟ釡韣迥迧蓩臫语黯蛱퓳뫵釷觹裻", a_);
			base.Id = 10115;
			base.UIName = global::CommonResources.AcgResources.ID_CHANNELASSIGNMENTLIST;
			base.DataTransferOrder = 1;
		}

		// Token: 0x0600004A RID: 74 RVA: 0x0000CA14 File Offset: 0x0000AC14
		public override void PopulateReferences()
		{
			short num = (short)716455282;
			short num2 = num;
			num = (short)2109095282;
			switch (num2 == num)
			{
			default:
			{
				num = (short)262144000;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2096234497;
			if (num != 0)
			{
			}
			num = (short)1949892608;
			if (num != 0)
			{
			}
			this.channelAnnouncementID_A20175.SetRecset(this.a(2300));
			this.znChanCfgChannelsRadioProfileCompositeItemNameID_A20192.SetRecset(this.a(2077));
			this.znChanCfgChannelsFallbackZone.SetRecset(this.a(2051));
			this.znChanCfgChannelsFallbackZone.AddSlaveField(this.ZnChanCfgChannelsFallbackChannel, 10114);
			this.znChanCfgChannelsPersonality_A8698.AddSlaveField(this.znChanCfgChannelsConventionalChannelReference_A20560, 10148);
			this.znChanCfgChannelsPersonality_A8698.AddSlaveField(this.znChanCfgChannelsTalkgroup_A9276, 10179);
			global::System.Collections.Generic.List<global::AcpBusinessLayer.Recordset> refRecsets = new global::System.Collections.Generic.List<global::AcpBusinessLayer.Recordset>
			{
				(global::AcpBusinessLayer.Recordset)this.a(2059),
				(global::AcpBusinessLayer.Recordset)this.a(2072)
			};
			global::System.Collections.Generic.List<string> resourceStrings = new global::System.Collections.Generic.List<string>
			{
				global::CommonResources.AcgResources.ID_CNV,
				global::CommonResources.AcgResources.ID_TRK
			};
			((global::AcpBusinessLayer.AcpSparseLOVField)this.znChanCfgChannelsChannelType_A22241).SetBuddyRecRefField(this.znChanCfgChannelsPersonality_A8698, refRecsets, resourceStrings);
			this.c();
		}

		// Token: 0x0600004B RID: 75 RVA: 0x0000CBAC File Offset: 0x0000ADAC
		public override void DropReferences()
		{
			short num = (short)822345729;
			if (num != 0)
			{
			}
			num = (short)1686110208;
			short num2 = num;
			num = (short)1706344367;
			short num3 = num;
			num = (short)336838575;
			switch (num3 == num)
			{
			}
			num = (short)479657984;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600004C RID: 76 RVA: 0x0000CC58 File Offset: 0x0000AE58
		public override void SetConstraints()
		{
			short num = (short)32813042;
			short num2 = num;
			num = (short)866693106;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1032912896;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1680277504;
			if (num != 0)
			{
			}
			num = (short)811073537;
			if (num != 0)
			{
			}
			this.channelsActiveChannel.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentConstraints.ConIsDynamicZoneEnableUnCheckedANDInLabtoolView);
			this.znChanCfgChannelsChannelName_A7659.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentConstraints.conValidateChanTextLength);
			this.znChanCfgChannelsChannelName_A7659.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentConstraints.ConIsDynamicZoneEnableUnChecked);
			this.znChanCfgChannelsPersonality_A8698.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentConstraints.ConRSIAndNonRSIMutual);
			this.znChanCfgChannelsPersonality_A8698.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentConstraints.ConIsDynamicZoneEnableUnChecked);
			this.znChanCfgChannelsPersonality_A8698.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentConstraints.ConZoneChannelsPersonalityEditable);
			this.znChanCfgChannelsPersonality_A8698.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentConstraints.ConFiregroundSectorIDValue);
			this.znChanCfgChannelsFiregroundSectorID_A33630.ValidateAcrossRecset = true;
			this.znChanCfgChannelsFiregroundSectorID_A33630.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentConstraints.ConFiregroundSectorIDApplicable);
			this.znChanCfgChannelsFiregroundSectorID_A33630.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentConstraints.ConFiregroundSectorIDIsValid);
			this.znChanCfgChannelsFiregroundSectorID_A33630.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentConstraints.ConIsDynamicZoneEnableUnChecked);
			this.znChanCfgChannelsFiregroundSectorID_A33630.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentConstraints.ConFiregroundSectorIDIsEditability);
			this.znChanCfgChannelsTalkgroup_A9276.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentConstraints.ConIsZnChanAssignChanPersTypeTrk);
			this.znChanCfgChannelsTalkgroup_A9276.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentConstraints.ConTalkgroupSelectionIsValid);
			this.znChanCfgChannelsTalkgroup_A9276.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentConstraints.ConIsDynamicZoneEnableUnChecked);
			this.znChanCfgChannelsTopDisplayChannel_A19774.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentConstraints.ConTopChannelTextSize);
			this.znChanCfgChannelsTopDisplayChannel_A19774.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentConstraints.ConIsDynamicZoneEnableUnChecked);
			this.channelAnnouncementID_A20175.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentConstraints.ConRSIModeIsDisabled);
			this.channelAnnouncementID_A20175.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentConstraints.ConIsZnChanChannelVARecRefSelectionValid);
			this.channelAnnouncementID_A20175.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentConstraints.ConIsDynamicZoneEnableUnChecked);
			this.znChanCfgChannelsRadioProfileCompositeItemNameID_A20192.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentConstraints.ConIsDynamicZoneEnableUnChecked);
			this.znChanCfgChannelsConventionalChannelReference_A20560.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentConstraints.ConIsZnChanAssignChTypeCnv);
			this.znChanCfgChannelsConventionalChannelReference_A20560.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentConstraints.ConIsCnvFreqOptValid);
			this.znChanCfgChannelsConventionalChannelReference_A20560.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentConstraints.ConIsDynamicZoneEnableUnChecked);
			this.znChanCfgChannelsChannelType_A22241.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentConstraints.conCnvTypeIsValid);
			this.znChanCfgChannelsChannelType_A22241.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentConstraints.ConIsDynamicZoneEnableUnChecked);
			this.znChanCfgChannelsChannelType_A22241.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentConstraints.ConZoneChannelsPersonalityEditable);
			this.znChanCfgChannelsChannelType_A22241.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentConstraints.ConFiregroundSectorIDValue);
			this.znChanCfgTopLightColor_A43173.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentConstraints.ConTopLightColorApplicable);
			this.znChanCfgTopLightColor_A43173.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentConstraints.ConIsDynamicZoneEnableUnChecked);
			this.znChanCfgChannelsChannelColorBacklightSelection_43749.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentConstraints.ConChannelColorBacklightSelectionApplicable);
			this.ZnChanCfgChannelsChannelColorBacklightSelection_43749.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentConstraints.ConChannelColorBacklightSelectionHasExtendedColorOptions);
			this.VCChannelAnnouncement_A20176.ValidateAcrossRecset = true;
			this.VCChannelAnnouncement_A20176.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentConstraints.ConIsVoiceAnnouncementVoiceControlApplicable);
			this.VCChannelAnnouncement_A20176.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentConstraints.ConIsVoiceAnnouncementVoiceControlNotConfusable);
			this.znChanCfgChannelsFallbackZone.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentConstraints.ConFallbackZoneApplicable);
			this.znChanCfgChannelsFallbackZone.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentConstraints.ConFallbackZoneSelectionValid);
			this.znChanCfgChannelsFallbackChannel.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentConstraints.ConFallbackChannelApplicable);
			this.znChanCfgChannelsFallbackChannel.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentConstraints.ConIsFallbackChannelSelectionValid);
			this.znChanCfgChannelsWiFi.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentConstraints.ConZoneChannelsWiFiApplicable);
		}

		// Token: 0x0600004D RID: 77 RVA: 0x0000D084 File Offset: 0x0000B284
		public override void SetupDependencies()
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			short num2;
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
				{
					num2 = (short)572447158;
					short num3 = num2;
					num2 = (short)1140185526;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num2 = (short)1744633856;
						if (num2 != 0)
						{
						}
						obj = null;
						goto IL_306;
					}
					break;
				}
				case 2:
				{
					global::AcpCommonLib.IAcpRecordset feature = global::AcpCommonLib.FeatureManager.GetFeature(2045);
					if (feature == null)
					{
						num2 = (short)444071937;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = feature[0];
					if (acpFeatureNode == null)
					{
						num2 = (short)11665411;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					obj = acpFeatureNode[10105];
					goto IL_306;
				}
				case 3:
					obj = null;
					goto IL_306;
				}
				goto IL_20;
				IL_306:
				features = (obj as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Features);
				if (features != null)
				{
					goto IL_37C;
				}
				num2 = (short)1958477824;
				short num4 = num2;
				num2 = (short)319094785;
				if (num2 != 0)
				{
				}
				num2 = (short)1405747200;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_37C:
			global::AcpBusinessLayer.AcpListField radWideFeaturesVoiceControlPriority = features.RadWideFeaturesVoiceControlPriority;
			if (radWideFeaturesVoiceControlPriority == null)
			{
				return;
			}
			radWideFeaturesVoiceControlPriority.AddDependentObject(this.VCChannelAnnouncement_A20176);
			return;
			IL_20:
			global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment = base.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment;
			this.RefDisplayAndMenu.General.DispMenuGeneralChannelTextSize_A7663.AddDependentObject(this.znChanCfgChannelsChannelName_A7659);
			this.znChanCfgChannelsChannelType_A22241.AddDependentObject(this.znChanCfgChannelsPersonality_A8698);
			this.znChanCfgChannelsFiregroundSectorID_A33630.AddDependentObject(this.znChanCfgChannelsPersonality_A8698);
			zoneChannelAssignment.RSI.ZoneChannelAssignmentRSIMode_A41831.AddDependentObject(this.znChanCfgChannelsPersonality_A8698);
			this.znChanCfgChannelsChannelType_A22241.AddDependentObject(this.znChanCfgChannelsFiregroundSectorID_A33630);
			this.znChanCfgChannelsPersonality_A8698.AddDependentObject(this.znChanCfgChannelsFiregroundSectorID_A33630);
			this.znChanCfgChannelsChannelType_A22241.AddDependentObject(this.znChanCfgChannelsTalkgroup_A9276);
			this.znChanCfgChannelsPersonality_A8698.AddDependentObject(this.znChanCfgChannelsTalkgroup_A9276);
			this.RefDisplayAndMenu.General.DispMenuTopChannelTextSize_A19504.AddDependentObject(this.znChanCfgChannelsTopDisplayChannel_A19774);
			zoneChannelAssignment.RSI.ZoneChannelAssignmentRSIMode_A41831.AddDependentObject(this.channelAnnouncementID_A20175);
			this.znChanCfgChannelsChannelType_A22241.AddDependentObject(this.znChanCfgChannelsConventionalChannelReference_A20560);
			this.znChanCfgChannelsPersonality_A8698.AddDependentObject(this.znChanCfgChannelsChannelType_A22241);
			this.znChanCfgChannelsFiregroundSectorID_A33630.AddDependentObject(this.znChanCfgChannelsChannelType_A22241);
			this.RefDisplayAndMenu.Advanced.DisplMenuAdvancedTopLightColorPerChannel_A43171.AddDependentObject(this.znChanCfgTopLightColor_A43173);
			this.RefDisplayAndMenu.Advanced.RadioErgDispAdvanceChannelColorBacklight_43747.AddDependentObject(this.znChanCfgChannelsChannelColorBacklightSelection_43749);
			this.znChanCfgChannelsChannelType_A22241.AddDependentObject((base.ParentRecset.ParentSection.Parent[10117] as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.FPPProtection).ZnChanCfgFPPProtectionProtectedZone_A8765);
			this.znChanCfgChannelsChannelType_A22241.AddDependentObject((base.ParentRecset.ParentSection.Parent[10117] as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.FPPProtection).ZnChanCfgFPPProtectionFPPEnable_A19562);
			this.znChanCfgChannelsChannelType_A22241.AddDependentObject((base.ParentRecset.ParentSection.Parent[10760] as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.RSI).ZoneChannelAssignmentRSIMode_A41831);
			global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide radioErgonomicsWide = global::AcpCommonLib.FeatureManager.GetFeature(2033)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide;
			this.znChanCfgChannelsChannelType_A22241.AddDependentObject(radioErgonomicsWide.HomeMode.HomeModeChannel);
			this.znChanCfgChannelsPersonality_A8698.AddDependentObject(radioErgonomicsWide.HomeMode.HomeModeChannel);
			num2 = (short)290521090;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600004E RID: 78 RVA: 0x0000D428 File Offset: 0x0000B628
		public global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality ConventionalPersonalityForZnChanCfgChannelsPersonality_A8698
		{
			get
			{
				short num = (short)7602177;
				if (num != 0)
				{
				}
				num = (short)565182464;
				short num2 = num;
				num = (short)873256593;
				short num3 = num;
				num = (short)1223218833;
				switch (num3 == num)
				{
				}
				num = (short)1301413888;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsPersonality_A8698.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600004F RID: 79 RVA: 0x0000D4E0 File Offset: 0x0000B6E0
		public global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TalkgroupInner TalkgroupInnerSectionForZnChanCfgChannelsTalkgroup_A9276
		{
			get
			{
				short num = (short)1893695657;
				short num2 = num;
				num = (short)2021753001;
				switch (num2 == num)
				{
				default:
				{
					num = (short)501940224;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1427374081;
				if (num != 0)
				{
				}
				num = (short)940507136;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsTalkgroup_A9276.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TalkgroupInner;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000050 RID: 80 RVA: 0x0000D598 File Offset: 0x0000B798
		public global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfiles RadioProfilesForZnChanCfgChannelsRadioProfileCompositeItemNameID_A20192
		{
			get
			{
				short num = (short)136141982;
				short num2 = num;
				num = (short)535780510;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1588723712;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1095041024;
				if (num != 0)
				{
				}
				num = (short)382074881;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsRadioProfileCompositeItemNameID_A20192.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfiles;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000051 RID: 81 RVA: 0x0000D650 File Offset: 0x0000B850
		public global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner FrequencyOptionsInnerSectionForZnChanCfgChannelsConventionalChannelReference_A20560
		{
			get
			{
				short num = (short)1320747009;
				if (num != 0)
				{
				}
				num = (short)1144455168;
				short num2 = num;
				num = (short)7163907;
				short num3 = num;
				num = (short)541020163;
				switch (num3 == num)
				{
				}
				num = (short)818413568;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsConventionalChannelReference_A20560.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000052 RID: 82 RVA: 0x0000D708 File Offset: 0x0000B908
		public bool HasDiffs
		{
			get
			{
				short num = (short)973004182;
				short num2 = num;
				num = (short)1427168662;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1078919168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2125004800;
				if (num != 0)
				{
				}
				num = (short)1749876737;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000053 RID: 83 RVA: 0x0000D7B8 File Offset: 0x0000B9B8
		// (set) Token: 0x06000054 RID: 84 RVA: 0x0000D86C File Offset: 0x0000BA6C
		public bool ChannelsActiveChannelValue
		{
			get
			{
				short num = (short)596711396;
				short num2 = num;
				num = (short)1462048740;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1467219968;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)878641153;
				if (num != 0)
				{
				}
				num = (short)457048064;
				if (num != 0)
				{
				}
				return this.channelsActiveChannel.Value;
			}
			set
			{
				short num = (short)138215425;
				if (num != 0)
				{
				}
				num = (short)2126381056;
				short num2 = num;
				num = (short)614579446;
				short num3 = num;
				num = (short)1190509814;
				switch (num3 == num)
				{
				}
				num = (short)622329856;
				if (num != 0)
				{
				}
				this.channelsActiveChannel.Value = value;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000055 RID: 85 RVA: 0x0000D924 File Offset: 0x0000BB24
		public global::AcpBusinessLayer.AcpFieldX<bool, bool> ChannelsActiveChannel
		{
			get
			{
				short num = (short)1921331547;
				short num2 = num;
				num = (short)598356315;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2071986176;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2098987008;
				if (num != 0)
				{
				}
				num = (short)444923905;
				if (num != 0)
				{
				}
				return this.channelsActiveChannel;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000056 RID: 86 RVA: 0x0000D9D0 File Offset: 0x0000BBD0
		// (set) Token: 0x06000057 RID: 87 RVA: 0x0000DA84 File Offset: 0x0000BC84
		public bool ChannelsActiveChannel_UIValue
		{
			get
			{
				short num = (short)1046793287;
				short num2 = num;
				num = (short)749849671;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1030029312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1604583424;
				if (num != 0)
				{
				}
				num = (short)1261764609;
				if (num != 0)
				{
				}
				return this.channelsActiveChannel.UIValue;
			}
			set
			{
				short num = (short)719672594;
				short num2 = num;
				num = (short)1640650002;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1589837824;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)759431169;
				if (num != 0)
				{
				}
				num = (short)368836608;
				if (num != 0)
				{
				}
				this.channelsActiveChannel.UIValue = value;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000058 RID: 88 RVA: 0x0000DB3C File Offset: 0x0000BD3C
		// (set) Token: 0x06000059 RID: 89 RVA: 0x0000DBF0 File Offset: 0x0000BDF0
		public bool ChannelsActiveChannel_Applicable
		{
			get
			{
				short num = (short)940913363;
				short num2 = num;
				num = (short)342307539;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1324875776;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)186253313;
				if (num != 0)
				{
				}
				num = (short)2093940736;
				if (num != 0)
				{
				}
				return this.channelsActiveChannel.Applicable;
			}
			set
			{
				short num = (short)1370005016;
				short num2 = num;
				num = (short)575774232;
				switch (num2 == num)
				{
				default:
				{
					num = (short)20447232;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)627769344;
				if (num != 0)
				{
				}
				num = (short)973275137;
				if (num != 0)
				{
				}
				this.channelsActiveChannel.Applicable = value;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600005A RID: 90 RVA: 0x0000DCA8 File Offset: 0x0000BEA8
		// (set) Token: 0x0600005B RID: 91 RVA: 0x0000DD60 File Offset: 0x0000BF60
		public bool ChannelsActiveChannel_Valid
		{
			get
			{
				short num = (short)1720057857;
				if (num != 0)
				{
				}
				num = (short)34799616;
				short num2 = num;
				num = (short)455480780;
				short num3 = num;
				num = (short)1315771852;
				switch (num3 == num)
				{
				}
				num = (short)2091122688;
				if (num != 0)
				{
				}
				return this.channelsActiveChannel.Valid;
			}
			set
			{
				short num = (short)1105723393;
				if (num != 0)
				{
				}
				num = (short)460062720;
				short num2 = num;
				num = (short)1259108114;
				short num3 = num;
				num = (short)216954642;
				switch (num3 == num)
				{
				}
				num = (short)1414397952;
				if (num != 0)
				{
				}
				this.channelsActiveChannel.Valid = value;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600005C RID: 92 RVA: 0x0000DE18 File Offset: 0x0000C018
		// (set) Token: 0x0600005D RID: 93 RVA: 0x0000DECC File Offset: 0x0000C0CC
		public bool ChannelsActiveChannel_Visible
		{
			get
			{
				short num = (short)695035401;
				short num2 = num;
				num = (short)1695376905;
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
				num = (short)1446641664;
				if (num != 0)
				{
				}
				num = (short)941948929;
				if (num != 0)
				{
				}
				return this.channelsActiveChannel.Visible;
			}
			set
			{
				short num = (short)1405943809;
				if (num != 0)
				{
				}
				num = (short)1521614848;
				short num2 = num;
				num = (short)845737660;
				short num3 = num;
				num = (short)1520365244;
				switch (num3 == num)
				{
				}
				num = (short)1106313216;
				if (num != 0)
				{
				}
				this.channelsActiveChannel.Visible = value;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600005E RID: 94 RVA: 0x0000DF84 File Offset: 0x0000C184
		// (set) Token: 0x0600005F RID: 95 RVA: 0x0000E034 File Offset: 0x0000C234
		public bool ChannelsActiveChannel_Editable
		{
			get
			{
				short num = (short)1720219978;
				short num2 = num;
				num = (short)1686337866;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2096300032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)190644225;
				if (num != 0)
				{
				}
				num = (short)1052770304;
				if (num != 0)
				{
				}
				return this.channelsActiveChannel.Editable;
			}
			set
			{
				short num = (short)1467352189;
				short num2 = num;
				num = (short)1280246909;
				switch (num2 == num)
				{
				default:
				{
					num = (short)525008896;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1434386433;
				if (num != 0)
				{
				}
				num = (short)1075576832;
				if (num != 0)
				{
				}
				this.channelsActiveChannel.Editable = value;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000060 RID: 96 RVA: 0x0000E0E8 File Offset: 0x0000C2E8
		internal string ChannelsActiveChannel_UILabel
		{
			get
			{
				short num = (short)197983953;
				short num2 = num;
				num = (short)1813708497;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1561329664;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1998454785;
				if (num != 0)
				{
				}
				num = (short)1255866368;
				if (num != 0)
				{
				}
				return this.channelsActiveChannel.UIName;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000061 RID: 97 RVA: 0x0000E19C File Offset: 0x0000C39C
		// (set) Token: 0x06000062 RID: 98 RVA: 0x0000E250 File Offset: 0x0000C450
		internal bool ChannelsActiveChannel_HiddenStatic
		{
			get
			{
				short num = (short)994639777;
				short num2 = num;
				num = (short)324796321;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1419051008;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1315897345;
				if (num != 0)
				{
				}
				num = (short)1737162752;
				if (num != 0)
				{
				}
				return this.channelsActiveChannel.HiddenStatic;
			}
			set
			{
				short num = (short)539898807;
				short num2 = num;
				num = (short)961950647;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1931542528;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1486749697;
				if (num != 0)
				{
				}
				num = (short)1724841984;
				if (num != 0)
				{
				}
				this.channelsActiveChannel.HiddenStatic = value;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000063 RID: 99 RVA: 0x0000E304 File Offset: 0x0000C504
		// (set) Token: 0x06000064 RID: 100 RVA: 0x0000E3BC File Offset: 0x0000C5BC
		internal bool ChannelsActiveChannel_HiddenDynamic
		{
			get
			{
				short num = (short)297205761;
				if (num != 0)
				{
				}
				num = (short)453771264;
				short num2 = num;
				num = (short)442711997;
				short num3 = num;
				num = (short)2102345661;
				switch (num3 == num)
				{
				}
				num = (short)1587281920;
				if (num != 0)
				{
				}
				return this.channelsActiveChannel.HiddenDynamic;
			}
			set
			{
				short num = (short)1996044403;
				short num2 = num;
				num = (short)1679964275;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1195769856;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)454885377;
				if (num != 0)
				{
				}
				num = (short)1519452160;
				if (num != 0)
				{
				}
				this.channelsActiveChannel.HiddenDynamic = value;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000065 RID: 101 RVA: 0x0000E470 File Offset: 0x0000C670
		public bool ChannelsActiveChannel_HasDiffs
		{
			get
			{
				short num = (short)1631977473;
				if (num != 0)
				{
				}
				num = (short)1255997440;
				short num2 = num;
				num = (short)1311667486;
				short num3 = num;
				num = (short)260470046;
				switch (num3 == num)
				{
				}
				num = (short)310444032;
				if (num != 0)
				{
				}
				return this.channelsActiveChannel._HasDiffs;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000066 RID: 102 RVA: 0x0000E524 File Offset: 0x0000C724
		// (set) Token: 0x06000067 RID: 103 RVA: 0x0000E5D8 File Offset: 0x0000C7D8
		public string ZnChanCfgChannelsChannelName_A7659Value
		{
			get
			{
				short num = (short)1450298885;
				short num2 = num;
				num = (short)373739013;
				switch (num2 == num)
				{
				default:
				{
					num = (short)364773376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1553530881;
				if (num != 0)
				{
				}
				num = (short)630521856;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsChannelName_A7659.Value;
			}
			set
			{
				short num = (short)504102913;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)98631680;
					short num3 = num;
					switch (num2)
					{
					case 0:
						return;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_5B;
						}
						continue;
					case 2:
					{
						num = (short)1542986333;
						short num4 = num;
						num = (short)1021450845;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return;
						default:
							num = (short)614989825;
							if (num != 0)
							{
							}
							num = (short)393412608;
							if (num != 0)
							{
							}
							this.znChanCfgChannelsChannelName_A7659.Value = value;
							num = (short)1363476480;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_5B:
					if (string.IsNullOrEmpty(value.Trim()))
					{
						break;
					}
					num = (short)638844930;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000068 RID: 104 RVA: 0x0000E700 File Offset: 0x0000C900
		// (set) Token: 0x06000069 RID: 105 RVA: 0x0000E7B8 File Offset: 0x0000C9B8
		public string ZnChanCfgChannelsChannelName_A7659_UIValue
		{
			get
			{
				short num = (short)604665271;
				short num2 = num;
				num = (short)1351054775;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1312948224;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)621740033;
				if (num != 0)
				{
				}
				num = (short)437059584;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsChannelName_A7659.Value;
			}
			set
			{
				short num = (short)418631665;
				short num2 = num;
				num = (short)47632369;
				switch (num2 == num)
				{
				default:
				{
					num = (short)42795008;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2130313217;
				if (num != 0)
				{
				}
				num = (short)942342144;
				if (num != 0)
				{
				}
				this.znChanCfgChannelsChannelName_A7659.Value = value;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600006A RID: 106 RVA: 0x0000E86C File Offset: 0x0000CA6C
		public global::AcpBusinessLayer.AcpKeyField ZnChanCfgChannelsChannelName_A7659
		{
			get
			{
				short num = (short)674383201;
				short num2 = num;
				num = (short)672482657;
				switch (num2 == num)
				{
				default:
				{
					num = (short)639500288;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1604911104;
				if (num != 0)
				{
				}
				num = (short)112590849;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsChannelName_A7659;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600006B RID: 107 RVA: 0x0000E918 File Offset: 0x0000CB18
		// (set) Token: 0x0600006C RID: 108 RVA: 0x0000E9D0 File Offset: 0x0000CBD0
		public bool ZnChanCfgChannelsChannelName_A7659_Applicable
		{
			get
			{
				short num = (short)1911750657;
				if (num != 0)
				{
				}
				num = (short)1156120576;
				short num2 = num;
				num = (short)1964158953;
				short num3 = num;
				num = (short)840216553;
				switch (num3 == num)
				{
				}
				num = (short)1806761984;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsChannelName_A7659.Applicable;
			}
			set
			{
				short num = (short)890440;
				short num2 = num;
				num = (short)1884722760;
				switch (num2 == num)
				{
				default:
				{
					num = (short)893648896;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)875233280;
				if (num != 0)
				{
				}
				num = (short)1951596545;
				if (num != 0)
				{
				}
				this.znChanCfgChannelsChannelName_A7659.Applicable = value;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600006D RID: 109 RVA: 0x0000EA88 File Offset: 0x0000CC88
		// (set) Token: 0x0600006E RID: 110 RVA: 0x0000EB3C File Offset: 0x0000CD3C
		public bool ZnChanCfgChannelsChannelName_A7659_Valid
		{
			get
			{
				short num = (short)642541210;
				short num2 = num;
				num = (short)2110416538;
				switch (num2 == num)
				{
				default:
				{
					num = (short)402128896;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)978190337;
				if (num != 0)
				{
				}
				num = (short)803930112;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsChannelName_A7659.Valid;
			}
			set
			{
				short num = (short)1782251521;
				if (num != 0)
				{
				}
				num = (short)1921581056;
				short num2 = num;
				num = (short)456605102;
				short num3 = num;
				num = (short)1558265262;
				switch (num3 == num)
				{
				}
				num = (short)356188160;
				if (num != 0)
				{
				}
				this.znChanCfgChannelsChannelName_A7659.Valid = value;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600006F RID: 111 RVA: 0x0000EBF0 File Offset: 0x0000CDF0
		// (set) Token: 0x06000070 RID: 112 RVA: 0x0000ECA8 File Offset: 0x0000CEA8
		public bool ZnChanCfgChannelsChannelName_A7659_Visible
		{
			get
			{
				short num = (short)436827786;
				short num2 = num;
				num = (short)1264285322;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1446313984;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1035796481;
				if (num != 0)
				{
				}
				num = (short)1747124224;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsChannelName_A7659.Visible;
			}
			set
			{
				short num = (short)177379876;
				short num2 = num;
				num = (short)1187682852;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1852702720;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)448004096;
				if (num != 0)
				{
				}
				num = (short)821100545;
				if (num != 0)
				{
				}
				this.znChanCfgChannelsChannelName_A7659.Visible = value;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000071 RID: 113 RVA: 0x0000ED5C File Offset: 0x0000CF5C
		// (set) Token: 0x06000072 RID: 114 RVA: 0x0000EE10 File Offset: 0x0000D010
		public bool ZnChanCfgChannelsChannelName_A7659_Editable
		{
			get
			{
				short num = (short)1870726346;
				short num2 = num;
				num = (short)1740047562;
				switch (num2 == num)
				{
				default:
				{
					num = (short)346357760;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)572850177;
				if (num != 0)
				{
				}
				num = (short)777650176;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsChannelName_A7659.Editable;
			}
			set
			{
				short num = (short)2058509050;
				short num2 = num;
				num = (short)816732922;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1647968256;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)27721728;
				if (num != 0)
				{
				}
				num = (short)1875509249;
				if (num != 0)
				{
				}
				this.znChanCfgChannelsChannelName_A7659.Editable = value;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000073 RID: 115 RVA: 0x0000EEC8 File Offset: 0x0000D0C8
		internal string ZnChanCfgChannelsChannelName_A7659_UILabel
		{
			get
			{
				short num = (short)1636083681;
				short num2 = num;
				num = (short)719890401;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1651113984;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1183514625;
				if (num != 0)
				{
				}
				num = (short)1896677376;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsChannelName_A7659.UIName;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000074 RID: 116 RVA: 0x0000EF80 File Offset: 0x0000D180
		// (set) Token: 0x06000075 RID: 117 RVA: 0x0000F034 File Offset: 0x0000D234
		internal bool ZnChanCfgChannelsChannelName_A7659_HiddenStatic
		{
			get
			{
				short num = (short)1177738321;
				short num2 = num;
				num = (short)1631509585;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1191968768;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)846135296;
				if (num != 0)
				{
				}
				num = (short)1238302721;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsChannelName_A7659.HiddenStatic;
			}
			set
			{
				short num = (short)1684668417;
				if (num != 0)
				{
				}
				num = (short)908591104;
				short num2 = num;
				num = (short)1623813648;
				short num3 = num;
				num = (short)1603628560;
				switch (num3 == num)
				{
				}
				num = (short)849608704;
				if (num != 0)
				{
				}
				this.znChanCfgChannelsChannelName_A7659.HiddenStatic = value;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000076 RID: 118 RVA: 0x0000F0EC File Offset: 0x0000D2EC
		// (set) Token: 0x06000077 RID: 119 RVA: 0x0000F1A4 File Offset: 0x0000D3A4
		internal bool ZnChanCfgChannelsChannelName_A7659_HiddenDynamic
		{
			get
			{
				short num = (short)1676693113;
				short num2 = num;
				num = (short)1145917049;
				switch (num2 == num)
				{
				default:
				{
					num = (short)943259648;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)362807297;
				if (num != 0)
				{
				}
				num = (short)1846280192;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsChannelName_A7659.HiddenDynamic;
			}
			set
			{
				short num = (short)924803161;
				short num2 = num;
				num = (short)712073305;
				switch (num2 == num)
				{
				default:
				{
					num = (short)143392768;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)207683585;
				if (num != 0)
				{
				}
				num = (short)424607744;
				if (num != 0)
				{
				}
				this.znChanCfgChannelsChannelName_A7659.HiddenDynamic = value;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000078 RID: 120 RVA: 0x0000F258 File Offset: 0x0000D458
		public bool ZnChanCfgChannelsChannelName_A7659_HasDiffs
		{
			get
			{
				short num = (short)1652533653;
				short num2 = num;
				num = (short)168208789;
				switch (num2 == num)
				{
				default:
				{
					num = (short)496762880;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)629211137;
				if (num != 0)
				{
				}
				num = (short)722468864;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsChannelName_A7659._HasDiffs;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000079 RID: 121 RVA: 0x0000F30C File Offset: 0x0000D50C
		// (set) Token: 0x0600007A RID: 122 RVA: 0x0000F3C4 File Offset: 0x0000D5C4
		public int ZnChanCfgChannelsPersonality_A8698Value
		{
			get
			{
				short num = (short)1655308289;
				if (num != 0)
				{
				}
				num = (short)1428226048;
				short num2 = num;
				num = (short)1462729473;
				short num3 = num;
				num = (short)991656705;
				switch (num3 == num)
				{
				}
				num = (short)1137049600;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsPersonality_A8698.Value;
			}
			set
			{
				short num = (short)1515596882;
				short num2 = num;
				num = (short)1943153746;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2074279936;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)335282177;
				if (num != 0)
				{
				}
				num = (short)505348096;
				if (num != 0)
				{
				}
				this.znChanCfgChannelsPersonality_A8698.Value = value;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600007B RID: 123 RVA: 0x0000F47C File Offset: 0x0000D67C
		// (set) Token: 0x0600007C RID: 124 RVA: 0x0000F530 File Offset: 0x0000D730
		public string ZnChanCfgChannelsPersonality_A8698_UIValue
		{
			get
			{
				short num = (short)1563885569;
				if (num != 0)
				{
				}
				num = (short)279516602;
				short num2 = num;
				num = (short)560731578;
				switch (num2 == num)
				{
				}
				num = (short)610729984;
				short num3 = num;
				num = (short)1525284864;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsPersonality_A8698.UIValue;
			}
			set
			{
				short num = (short)2143567887;
				short num2 = num;
				num = (short)15417359;
				switch (num2 == num)
				{
				}
				num = (short)1950023681;
				if (num != 0)
				{
				}
				num = (short)1448214528;
				short num3 = num;
				num = (short)1038811136;
				if (num != 0)
				{
				}
				this.znChanCfgChannelsPersonality_A8698.UIValue = value;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600007D RID: 125 RVA: 0x0000F5E4 File Offset: 0x0000D7E4
		public global::AcpBusinessLayer.AcpRecRefField ZnChanCfgChannelsPersonality_A8698
		{
			get
			{
				short num = (short)1534722049;
				if (num != 0)
				{
				}
				num = (short)1179700395;
				short num2 = num;
				num = (short)1137626283;
				switch (num2 == num)
				{
				}
				num = (short)1792016384;
				short num3 = num;
				num = (short)236191744;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsPersonality_A8698;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600007E RID: 126 RVA: 0x0000F694 File Offset: 0x0000D894
		// (set) Token: 0x0600007F RID: 127 RVA: 0x0000F744 File Offset: 0x0000D944
		public bool ZnChanCfgChannelsPersonality_A8698_Applicable
		{
			get
			{
				short num = (short)362678760;
				short num2 = num;
				num = (short)1198197224;
				switch (num2 == num)
				{
				}
				num = (short)257163264;
				if (num != 0)
				{
				}
				num = (short)1017774080;
				short num3 = num;
				num = (short)146014209;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsPersonality_A8698.Applicable;
			}
			set
			{
				short num = (short)1428147133;
				short num2 = num;
				num = (short)1904593853;
				switch (num2 == num)
				{
				}
				num = (short)493158401;
				if (num != 0)
				{
				}
				num = (short)2085355520;
				short num3 = num;
				num = (short)1438449664;
				if (num != 0)
				{
				}
				this.znChanCfgChannelsPersonality_A8698.Applicable = value;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000080 RID: 128 RVA: 0x0000F7FC File Offset: 0x0000D9FC
		// (set) Token: 0x06000081 RID: 129 RVA: 0x0000F8B4 File Offset: 0x0000DAB4
		public bool ZnChanCfgChannelsPersonality_A8698_Valid
		{
			get
			{
				short num = (short)200775885;
				short num2 = num;
				num = (short)528324813;
				switch (num2 == num)
				{
				}
				num = (short)1064763393;
				if (num != 0)
				{
				}
				num = (short)1963327488;
				short num3 = num;
				num = (short)406257664;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsPersonality_A8698.Valid;
			}
			set
			{
				short num = (short)714684660;
				short num2 = num;
				num = (short)489830644;
				switch (num2 == num)
				{
				}
				num = (short)1679228928;
				if (num != 0)
				{
				}
				num = (short)258342912;
				short num3 = num;
				num = (short)1308229633;
				if (num != 0)
				{
				}
				this.znChanCfgChannelsPersonality_A8698.Valid = value;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000082 RID: 130 RVA: 0x0000F968 File Offset: 0x0000DB68
		// (set) Token: 0x06000083 RID: 131 RVA: 0x0000FA1C File Offset: 0x0000DC1C
		public bool ZnChanCfgChannelsPersonality_A8698_Visible
		{
			get
			{
				short num = (short)667402461;
				short num2 = num;
				num = (short)2098184413;
				switch (num2 == num)
				{
				}
				num = (short)568000512;
				if (num != 0)
				{
				}
				num = (short)1442447360;
				short num3 = num;
				num = (short)539033601;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsPersonality_A8698.Visible;
			}
			set
			{
				short num = (short)384938064;
				short num2 = num;
				num = (short)424915024;
				switch (num2 == num)
				{
				}
				num = (short)1481506817;
				if (num != 0)
				{
				}
				num = (short)432078848;
				short num3 = num;
				num = (short)551616512;
				if (num != 0)
				{
				}
				this.znChanCfgChannelsPersonality_A8698.Visible = value;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000084 RID: 132 RVA: 0x0000FAD4 File Offset: 0x0000DCD4
		// (set) Token: 0x06000085 RID: 133 RVA: 0x0000FB88 File Offset: 0x0000DD88
		public bool ZnChanCfgChannelsPersonality_A8698_Editable
		{
			get
			{
				short num = (short)629777919;
				short num2 = num;
				num = (short)470984191;
				switch (num2 == num)
				{
				}
				num = (short)1234436097;
				if (num != 0)
				{
				}
				num = (short)1845297152;
				short num3 = num;
				num = (short)797245440;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsPersonality_A8698.Editable;
			}
			set
			{
				short num = (short)159094484;
				short num2 = num;
				num = (short)12293844;
				switch (num2 == num)
				{
				}
				num = (short)1241317376;
				if (num != 0)
				{
				}
				num = (short)1395523584;
				short num3 = num;
				num = (short)1642332161;
				if (num != 0)
				{
				}
				this.znChanCfgChannelsPersonality_A8698.Editable = value;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000086 RID: 134 RVA: 0x0000FC3C File Offset: 0x0000DE3C
		internal string ZnChanCfgChannelsPersonality_A8698_UILabel
		{
			get
			{
				short num = (short)1757169718;
				short num2 = num;
				num = (short)1485850678;
				switch (num2 == num)
				{
				}
				num = (short)2001600513;
				if (num != 0)
				{
				}
				num = (short)799866880;
				short num3 = num;
				num = (short)2037317632;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsPersonality_A8698.UIName;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000087 RID: 135 RVA: 0x0000FCF0 File Offset: 0x0000DEF0
		// (set) Token: 0x06000088 RID: 136 RVA: 0x0000FDA4 File Offset: 0x0000DFA4
		internal bool ZnChanCfgChannelsPersonality_A8698_HiddenStatic
		{
			get
			{
				short num = (short)425191296;
				short num2 = num;
				num = (short)200664960;
				switch (num2 == num)
				{
				}
				num = (short)1694040064;
				if (num != 0)
				{
				}
				num = (short)1128988672;
				short num3 = num;
				num = (short)1222770689;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsPersonality_A8698.HiddenStatic;
			}
			set
			{
				short num = (short)93684222;
				short num2 = num;
				num = (short)1774551550;
				switch (num2 == num)
				{
				}
				num = (short)674430976;
				if (num != 0)
				{
				}
				num = (short)1143996416;
				short num3 = num;
				num = (short)2025521153;
				if (num != 0)
				{
				}
				this.znChanCfgChannelsPersonality_A8698.HiddenStatic = value;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000089 RID: 137 RVA: 0x0000FE5C File Offset: 0x0000E05C
		// (set) Token: 0x0600008A RID: 138 RVA: 0x0000FF14 File Offset: 0x0000E114
		internal bool ZnChanCfgChannelsPersonality_A8698_HiddenDynamic
		{
			get
			{
				short num = (short)680641336;
				short num2 = num;
				num = (short)331203384;
				switch (num2 == num)
				{
				}
				num = (short)1203896321;
				if (num != 0)
				{
				}
				num = (short)1101463552;
				short num3 = num;
				num = (short)1936785408;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsPersonality_A8698.HiddenDynamic;
			}
			set
			{
				short num = (short)298754605;
				short num2 = num;
				num = (short)1292214829;
				switch (num2 == num)
				{
				}
				num = (short)1105395712;
				if (num != 0)
				{
				}
				num = (short)53673984;
				short num3 = num;
				num = (short)1656160257;
				if (num != 0)
				{
				}
				this.znChanCfgChannelsPersonality_A8698.HiddenDynamic = value;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600008B RID: 139 RVA: 0x0000FFC8 File Offset: 0x0000E1C8
		public bool ZnChanCfgChannelsPersonality_A8698_HasDiffs
		{
			get
			{
				short num = (short)1615916293;
				short num2 = num;
				num = (short)1446898949;
				switch (num2 == num)
				{
				}
				num = (short)119406592;
				if (num != 0)
				{
				}
				num = (short)822411264;
				short num3 = num;
				num = (short)762773505;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsPersonality_A8698._HasDiffs;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600008C RID: 140 RVA: 0x00010080 File Offset: 0x0000E280
		// (set) Token: 0x0600008D RID: 141 RVA: 0x00010134 File Offset: 0x0000E334
		public int ZnChanCfgChannelsFiregroundSectorID_A33630Value
		{
			get
			{
				short num = (short)1171123194;
				short num2 = num;
				num = (short)837348346;
				switch (num2 == num)
				{
				}
				num = (short)1411776512;
				if (num != 0)
				{
				}
				num = (short)320667648;
				short num3 = num;
				num = (short)1513881601;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsFiregroundSectorID_A33630.Value;
			}
			set
			{
				short num = (short)238623838;
				short num2 = num;
				num = (short)1416830046;
				switch (num2 == num)
				{
				}
				num = (short)1432092673;
				if (num != 0)
				{
				}
				num = (short)2006253568;
				short num3 = num;
				num = (short)1215496192;
				if (num != 0)
				{
				}
				this.znChanCfgChannelsFiregroundSectorID_A33630.Value = value;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600008E RID: 142 RVA: 0x000101E8 File Offset: 0x0000E3E8
		public global::AcpBusinessLayer.AcpRangeField<int, string> ZnChanCfgChannelsFiregroundSectorID_A33630
		{
			get
			{
				short num = (short)720617162;
				short num2 = num;
				num = (short)1270857418;
				switch (num2 == num)
				{
				}
				num = (short)1255997441;
				if (num != 0)
				{
				}
				num = (short)578748416;
				short num3 = num;
				num = (short)1117454336;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsFiregroundSectorID_A33630;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x0600008F RID: 143 RVA: 0x00010298 File Offset: 0x0000E498
		// (set) Token: 0x06000090 RID: 144 RVA: 0x0001034C File Offset: 0x0000E54C
		public string ZnChanCfgChannelsFiregroundSectorID_A33630_UIValue
		{
			get
			{
				short num = (short)2036400129;
				if (num != 0)
				{
				}
				num = (short)23514168;
				short num2 = num;
				num = (short)50252856;
				switch (num2 == num)
				{
				}
				num = (short)1039400960;
				short num3 = num;
				num = (short)1481113600;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsFiregroundSectorID_A33630.UIValue;
			}
			set
			{
				short num = (short)373973098;
				short num2 = num;
				num = (short)689397866;
				switch (num2 == num)
				{
				}
				num = (short)1948254209;
				if (num != 0)
				{
				}
				num = (short)677707776;
				short num3 = num;
				num = (short)1634992128;
				if (num != 0)
				{
				}
				this.znChanCfgChannelsFiregroundSectorID_A33630.UIValue = value;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000091 RID: 145 RVA: 0x00010404 File Offset: 0x0000E604
		// (set) Token: 0x06000092 RID: 146 RVA: 0x000104B8 File Offset: 0x0000E6B8
		internal int ZnChanCfgChannelsFiregroundSectorID_A33630Min
		{
			get
			{
				short num = (short)1340186433;
				short num2 = num;
				num = (short)1662164801;
				switch (num2 == num)
				{
				}
				num = (short)131530753;
				if (num != 0)
				{
				}
				num = (short)671612928;
				short num3 = num;
				num = (short)1792802816;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsFiregroundSectorID_A33630.Min;
			}
			set
			{
				short num = (short)977525998;
				short num2 = num;
				num = (short)1353899246;
				switch (num2 == num)
				{
				}
				num = (short)87621633;
				if (num != 0)
				{
				}
				num = (short)184877056;
				short num3 = num;
				num = (short)930086912;
				if (num != 0)
				{
				}
				this.znChanCfgChannelsFiregroundSectorID_A33630.Min = value;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000093 RID: 147 RVA: 0x00010570 File Offset: 0x0000E770
		// (set) Token: 0x06000094 RID: 148 RVA: 0x00010624 File Offset: 0x0000E824
		internal int ZnChanCfgChannelsFiregroundSectorID_A33630Max
		{
			get
			{
				short num = (short)1495097663;
				short num2 = num;
				num = (short)1842372927;
				switch (num2 == num)
				{
				}
				num = (short)2008481793;
				if (num != 0)
				{
				}
				num = (short)503840768;
				short num3 = num;
				num = (short)73596928;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsFiregroundSectorID_A33630.Max;
			}
			set
			{
				short num = (short)77304770;
				short num2 = num;
				num = (short)269784002;
				switch (num2 == num)
				{
				}
				num = (short)1893400577;
				if (num != 0)
				{
				}
				num = (short)1644756992;
				short num3 = num;
				num = (short)619577344;
				if (num != 0)
				{
				}
				this.znChanCfgChannelsFiregroundSectorID_A33630.Max = value;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000095 RID: 149 RVA: 0x000106DC File Offset: 0x0000E8DC
		// (set) Token: 0x06000096 RID: 150 RVA: 0x00010790 File Offset: 0x0000E990
		internal int ZnChanCfgChannelsFiregroundSectorID_A33630Step
		{
			get
			{
				short num = (short)1823789416;
				short num2 = num;
				num = (short)1822544232;
				switch (num2 == num)
				{
				}
				num = (short)1390804992;
				if (num != 0)
				{
				}
				num = (short)540868608;
				short num3 = num;
				num = (short)1571880961;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsFiregroundSectorID_A33630.StepSize;
			}
			set
			{
				short num = (short)159131692;
				short num2 = num;
				num = (short)404367404;
				switch (num2 == num)
				{
				}
				num = (short)1191116801;
				if (num != 0)
				{
				}
				num = (short)1966080000;
				short num3 = num;
				num = (short)1925513216;
				if (num != 0)
				{
				}
				this.znChanCfgChannelsFiregroundSectorID_A33630.StepSize = value;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000097 RID: 151 RVA: 0x00010848 File Offset: 0x0000EA48
		// (set) Token: 0x06000098 RID: 152 RVA: 0x00010900 File Offset: 0x0000EB00
		public bool ZnChanCfgChannelsFiregroundSectorID_A33630_Applicable
		{
			get
			{
				short num = (short)551588033;
				short num2 = num;
				num = (short)121344193;
				switch (num2 == num)
				{
				}
				num = (short)639893505;
				if (num != 0)
				{
				}
				num = (short)988807168;
				short num3 = num;
				num = (short)1970012160;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsFiregroundSectorID_A33630.Applicable;
			}
			set
			{
				short num = (short)1503113512;
				short num2 = num;
				num = (short)1957081384;
				switch (num2 == num)
				{
				}
				num = (short)917700609;
				if (num != 0)
				{
				}
				num = (short)1500708864;
				short num3 = num;
				num = (short)94240768;
				if (num != 0)
				{
				}
				this.znChanCfgChannelsFiregroundSectorID_A33630.Applicable = value;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000099 RID: 153 RVA: 0x000109B4 File Offset: 0x0000EBB4
		// (set) Token: 0x0600009A RID: 154 RVA: 0x00010A6C File Offset: 0x0000EC6C
		public bool ZnChanCfgChannelsFiregroundSectorID_A33630_Valid
		{
			get
			{
				short num = (short)497668957;
				short num2 = num;
				num = (short)1029886813;
				switch (num2 == num)
				{
				}
				num = (short)1090912256;
				if (num != 0)
				{
				}
				num = (short)2062090240;
				short num3 = num;
				num = (short)1451425793;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsFiregroundSectorID_A33630.Valid;
			}
			set
			{
				short num = (short)369399335;
				short num2 = num;
				num = (short)2121963047;
				switch (num2 == num)
				{
				}
				num = (short)519634945;
				if (num != 0)
				{
				}
				num = (short)1156448256;
				short num3 = num;
				num = (short)1792737280;
				if (num != 0)
				{
				}
				this.znChanCfgChannelsFiregroundSectorID_A33630.Valid = value;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x0600009B RID: 155 RVA: 0x00010B24 File Offset: 0x0000ED24
		// (set) Token: 0x0600009C RID: 156 RVA: 0x00010BDC File Offset: 0x0000EDDC
		public bool ZnChanCfgChannelsFiregroundSectorID_A33630_Visible
		{
			get
			{
				short num = (short)1285406066;
				short num2 = num;
				num = (short)1104985458;
				switch (num2 == num)
				{
				}
				num = (short)805699585;
				if (num != 0)
				{
				}
				num = (short)2096365568;
				short num3 = num;
				num = (short)53870592;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsFiregroundSectorID_A33630.Visible;
			}
			set
			{
				short num = (short)344082635;
				short num2 = num;
				num = (short)1388529867;
				switch (num2 == num)
				{
				}
				num = (short)597164032;
				if (num != 0)
				{
				}
				num = (short)930676736;
				short num3 = num;
				num = (short)10682369;
				if (num != 0)
				{
				}
				this.znChanCfgChannelsFiregroundSectorID_A33630.Visible = value;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x0600009D RID: 157 RVA: 0x00010C90 File Offset: 0x0000EE90
		// (set) Token: 0x0600009E RID: 158 RVA: 0x00010D44 File Offset: 0x0000EF44
		public bool ZnChanCfgChannelsFiregroundSectorID_A33630_Editable
		{
			get
			{
				short num = (short)1409857610;
				short num2 = num;
				num = (short)693090378;
				switch (num2 == num)
				{
				}
				num = (short)738590721;
				if (num != 0)
				{
				}
				num = (short)527958016;
				short num3 = num;
				num = (short)1580728320;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsFiregroundSectorID_A33630.Editable;
			}
			set
			{
				short num = (short)370868225;
				if (num != 0)
				{
				}
				num = (short)679074382;
				short num2 = num;
				num = (short)94231118;
				switch (num2 == num)
				{
				}
				num = (short)1049493504;
				short num3 = num;
				num = (short)1960116224;
				if (num != 0)
				{
				}
				this.znChanCfgChannelsFiregroundSectorID_A33630.Editable = value;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x0600009F RID: 159 RVA: 0x00010DFC File Offset: 0x0000EFFC
		internal string ZnChanCfgChannelsFiregroundSectorID_A33630_UILabel
		{
			get
			{
				short num = (short)1754179851;
				short num2 = num;
				num = (short)1134471435;
				switch (num2 == num)
				{
				}
				num = (short)902103041;
				if (num != 0)
				{
				}
				num = (short)1613496320;
				short num3 = num;
				num = (short)2083192832;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsFiregroundSectorID_A33630.UIName;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x00010EB4 File Offset: 0x0000F0B4
		// (set) Token: 0x060000A1 RID: 161 RVA: 0x00010F68 File Offset: 0x0000F168
		internal bool ZnChanCfgChannelsFiregroundSectorID_A33630_HiddenStatic
		{
			get
			{
				short num = (short)381208072;
				short num2 = num;
				num = (short)181782024;
				switch (num2 == num)
				{
				}
				num = (short)1715535873;
				if (num != 0)
				{
				}
				num = (short)541720576;
				short num3 = num;
				num = (short)1042808832;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsFiregroundSectorID_A33630.HiddenStatic;
			}
			set
			{
				short num = (short)1893300643;
				short num2 = num;
				num = (short)1284864419;
				switch (num2 == num)
				{
				}
				num = (short)221708289;
				if (num != 0)
				{
				}
				num = (short)188219392;
				short num3 = num;
				num = (short)132841472;
				if (num != 0)
				{
				}
				this.znChanCfgChannelsFiregroundSectorID_A33630.HiddenStatic = value;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x00011020 File Offset: 0x0000F220
		// (set) Token: 0x060000A3 RID: 163 RVA: 0x000110D4 File Offset: 0x0000F2D4
		internal bool ZnChanCfgChannelsFiregroundSectorID_A33630_HiddenDynamic
		{
			get
			{
				short num = (short)790107931;
				short num2 = num;
				num = (short)34674459;
				switch (num2 == num)
				{
				}
				num = (short)235601920;
				if (num != 0)
				{
				}
				num = (short)2060451840;
				short num3 = num;
				num = (short)480313345;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsFiregroundSectorID_A33630.HiddenDynamic;
			}
			set
			{
				short num = (short)1615224147;
				short num2 = num;
				num = (short)712596819;
				switch (num2 == num)
				{
				}
				num = (short)723320833;
				if (num != 0)
				{
				}
				num = (short)1140260864;
				short num3 = num;
				num = (short)1141243904;
				if (num != 0)
				{
				}
				this.znChanCfgChannelsFiregroundSectorID_A33630.HiddenDynamic = value;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x0001118C File Offset: 0x0000F38C
		public bool ZnChanCfgChannelsFiregroundSectorID_A33630_HasDiffs
		{
			get
			{
				short num = (short)871409084;
				short num2 = num;
				num = (short)1322624444;
				switch (num2 == num)
				{
				}
				num = (short)928120833;
				if (num != 0)
				{
				}
				num = (short)1801781248;
				short num3 = num;
				num = (short)1389101056;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsFiregroundSectorID_A33630._HasDiffs;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000A5 RID: 165 RVA: 0x00011240 File Offset: 0x0000F440
		// (set) Token: 0x060000A6 RID: 166 RVA: 0x000112F4 File Offset: 0x0000F4F4
		public int ZnChanCfgChannelsTalkgroup_A9276Value
		{
			get
			{
				short num = (short)1885769053;
				short num2 = num;
				num = (short)704810333;
				switch (num2 == num)
				{
				}
				num = (short)269156352;
				if (num != 0)
				{
				}
				num = (short)299171840;
				short num3 = num;
				num = (short)1925840897;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsTalkgroup_A9276.Value;
			}
			set
			{
				short num = (short)45076619;
				short num2 = num;
				num = (short)1572589707;
				switch (num2 == num)
				{
				}
				num = (short)1974927361;
				if (num != 0)
				{
				}
				num = (short)348520448;
				short num3 = num;
				num = (short)1585119232;
				if (num != 0)
				{
				}
				this.znChanCfgChannelsTalkgroup_A9276.Value = value;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000A7 RID: 167 RVA: 0x000113A8 File Offset: 0x0000F5A8
		// (set) Token: 0x060000A8 RID: 168 RVA: 0x00011458 File Offset: 0x0000F658
		public string ZnChanCfgChannelsTalkgroup_A9276_UIValue
		{
			get
			{
				short num = (short)978649935;
				short num2 = num;
				num = (short)959710031;
				switch (num2 == num)
				{
				}
				num = (short)1739128832;
				if (num != 0)
				{
				}
				num = (short)1380974592;
				short num3 = num;
				num = (short)456851457;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsTalkgroup_A9276.UIValue;
			}
			set
			{
				short num = (short)1775811732;
				short num2 = num;
				num = (short)2143927444;
				switch (num2 == num)
				{
				}
				num = (short)550567937;
				if (num != 0)
				{
				}
				num = (short)1071644672;
				short num3 = num;
				num = (short)887422976;
				if (num != 0)
				{
				}
				this.znChanCfgChannelsTalkgroup_A9276.UIValue = value;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x00011510 File Offset: 0x0000F710
		public global::AcpBusinessLayer.AcpRecRefField ZnChanCfgChannelsTalkgroup_A9276
		{
			get
			{
				short num = (short)639893505;
				if (num != 0)
				{
				}
				num = (short)1997108090;
				short num2 = num;
				num = (short)454325114;
				switch (num2 == num)
				{
				}
				num = (short)1715077120;
				short num3 = num;
				num = (short)1142030336;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsTalkgroup_A9276;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000AA RID: 170 RVA: 0x000115C0 File Offset: 0x0000F7C0
		// (set) Token: 0x060000AB RID: 171 RVA: 0x00011678 File Offset: 0x0000F878
		public bool ZnChanCfgChannelsTalkgroup_A9276_Applicable
		{
			get
			{
				short num = (short)296615936;
				short num2 = num;
				num = (short)1311843811;
				short num3 = num;
				num = (short)2092115427;
				switch (num3 == num)
				{
				}
				num = (short)1115160577;
				if (num != 0)
				{
				}
				num = (short)644349952;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsTalkgroup_A9276.Applicable;
			}
			set
			{
				short num = (short)1516699648;
				short num2 = num;
				num = (short)758192408;
				short num3 = num;
				num = (short)1645222168;
				switch (num3 == num)
				{
				}
				num = (short)351731713;
				if (num != 0)
				{
				}
				num = (short)1043529728;
				if (num != 0)
				{
				}
				this.znChanCfgChannelsTalkgroup_A9276.Applicable = value;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000AC RID: 172 RVA: 0x0001172C File Offset: 0x0000F92C
		// (set) Token: 0x060000AD RID: 173 RVA: 0x000117E4 File Offset: 0x0000F9E4
		public bool ZnChanCfgChannelsTalkgroup_A9276_Valid
		{
			get
			{
				short num = (short)181600256;
				short num2 = num;
				num = (short)1051721729;
				if (num != 0)
				{
				}
				num = (short)787860451;
				short num3 = num;
				num = (short)1232325603;
				switch (num3 == num)
				{
				}
				num = (short)62652416;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsTalkgroup_A9276.Valid;
			}
			set
			{
				short num = (short)654770176;
				short num2 = num;
				num = (short)669016436;
				short num3 = num;
				num = (short)105210228;
				switch (num3 == num)
				{
				}
				num = (short)759562241;
				if (num != 0)
				{
				}
				num = (short)1982201856;
				if (num != 0)
				{
				}
				this.znChanCfgChannelsTalkgroup_A9276.Valid = value;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000AE RID: 174 RVA: 0x00011898 File Offset: 0x0000FA98
		// (set) Token: 0x060000AF RID: 175 RVA: 0x00011950 File Offset: 0x0000FB50
		public bool ZnChanCfgChannelsTalkgroup_A9276_Visible
		{
			get
			{
				short num = (short)1513422848;
				short num2 = num;
				num = (short)3241055;
				short num3 = num;
				num = (short)137917535;
				switch (num3 == num)
				{
				}
				num = (short)1543569409;
				if (num != 0)
				{
				}
				num = (short)403570688;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsTalkgroup_A9276.Visible;
			}
			set
			{
				short num = (short)1914634240;
				short num2 = num;
				num = (short)61312311;
				short num3 = num;
				num = (short)1162644791;
				switch (num3 == num)
				{
				}
				num = (short)2073362432;
				if (num != 0)
				{
				}
				num = (short)1686634497;
				if (num != 0)
				{
				}
				this.znChanCfgChannelsTalkgroup_A9276.Visible = value;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x00011A04 File Offset: 0x0000FC04
		// (set) Token: 0x060000B1 RID: 177 RVA: 0x00011ABC File Offset: 0x0000FCBC
		public bool ZnChanCfgChannelsTalkgroup_A9276_Editable
		{
			get
			{
				short num = (short)1814429696;
				short num2 = num;
				num = (short)1479916598;
				short num3 = num;
				num = (short)1064811574;
				switch (num3 == num)
				{
				}
				num = (short)1369767936;
				if (num != 0)
				{
				}
				num = (short)2096037889;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsTalkgroup_A9276.Editable;
			}
			set
			{
				short num = (short)1974992896;
				short num2 = num;
				num = (short)2122842113;
				if (num != 0)
				{
				}
				num = (short)1254318105;
				short num3 = num;
				num = (short)1053712409;
				switch (num3 == num)
				{
				}
				num = (short)1980366848;
				if (num != 0)
				{
				}
				this.znChanCfgChannelsTalkgroup_A9276.Editable = value;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000B2 RID: 178 RVA: 0x00011B74 File Offset: 0x0000FD74
		internal string ZnChanCfgChannelsTalkgroup_A9276_UILabel
		{
			get
			{
				short num = (short)734134272;
				short num2 = num;
				num = (short)1044231503;
				short num3 = num;
				num = (short)1323742543;
				switch (num3 == num)
				{
				}
				num = (short)2058027009;
				if (num != 0)
				{
				}
				num = (short)1616576512;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsTalkgroup_A9276.UIName;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000B3 RID: 179 RVA: 0x00011C28 File Offset: 0x0000FE28
		// (set) Token: 0x060000B4 RID: 180 RVA: 0x00011CDC File Offset: 0x0000FEDC
		internal bool ZnChanCfgChannelsTalkgroup_A9276_HiddenStatic
		{
			get
			{
				short num = (short)867827712;
				short num2 = num;
				num = (short)1651572737;
				if (num != 0)
				{
				}
				num = (short)1948754125;
				short num3 = num;
				num = (short)1548853453;
				switch (num3 == num)
				{
				}
				num = (short)1885405184;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsTalkgroup_A9276.HiddenStatic;
			}
			set
			{
				short num = (short)1219100672;
				short num2 = num;
				num = (short)1171124157;
				short num3 = num;
				num = (short)508882877;
				switch (num3 == num)
				{
				}
				num = (short)811728896;
				if (num != 0)
				{
				}
				num = (short)1151139841;
				if (num != 0)
				{
				}
				this.znChanCfgChannelsTalkgroup_A9276.HiddenStatic = value;
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x00011D94 File Offset: 0x0000FF94
		// (set) Token: 0x060000B6 RID: 182 RVA: 0x00011E48 File Offset: 0x00010048
		internal bool ZnChanCfgChannelsTalkgroup_A9276_HiddenDynamic
		{
			get
			{
				short num = (short)208076800;
				short num2 = num;
				num = (short)1727244457;
				short num3 = num;
				num = (short)1521592489;
				switch (num3 == num)
				{
				}
				num = (short)119406593;
				if (num != 0)
				{
				}
				num = (short)167182336;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsTalkgroup_A9276.HiddenDynamic;
			}
			set
			{
				short num = (short)84213760;
				short num2 = num;
				num = (short)1134049275;
				short num3 = num;
				num = (short)1148270587;
				switch (num3 == num)
				{
				}
				num = (short)261226497;
				if (num != 0)
				{
				}
				num = (short)1236402176;
				if (num != 0)
				{
				}
				this.znChanCfgChannelsTalkgroup_A9276.HiddenDynamic = value;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x00011F00 File Offset: 0x00010100
		public bool ZnChanCfgChannelsTalkgroup_A9276_HasDiffs
		{
			get
			{
				short num = (short)1143930880;
				short num2 = num;
				num = (short)897501029;
				short num3 = num;
				num = (short)144820069;
				switch (num3 == num)
				{
				}
				num = (short)296878081;
				if (num != 0)
				{
				}
				num = (short)1066467328;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsTalkgroup_A9276._HasDiffs;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000B8 RID: 184 RVA: 0x00011FB4 File Offset: 0x000101B4
		// (set) Token: 0x060000B9 RID: 185 RVA: 0x00012068 File Offset: 0x00010268
		public string ZnChanCfgChannelsTopDisplayChannel_A19774Value
		{
			get
			{
				short num = (short)152764416;
				short num2 = num;
				num = (short)75436231;
				short num3 = num;
				num = (short)1847791815;
				switch (num3 == num)
				{
				}
				num = (short)192675841;
				if (num != 0)
				{
				}
				num = (short)1107099648;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsTopDisplayChannel_A19774.Value;
			}
			set
			{
				short num = (short)770310144;
				short num2 = num;
				num = (short)1813917724;
				short num3 = num;
				num = (short)250359836;
				switch (num3 == num)
				{
				}
				num = (short)867434497;
				if (num != 0)
				{
				}
				num = (short)1251737600;
				if (num != 0)
				{
				}
				this.znChanCfgChannelsTopDisplayChannel_A19774.Value = value;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060000BA RID: 186 RVA: 0x00012120 File Offset: 0x00010320
		public global::AcpBusinessLayer.AcpField<string> ZnChanCfgChannelsTopDisplayChannel_A19774
		{
			get
			{
				short num = (short)209387520;
				short num2 = num;
				num = (short)1832976385;
				if (num != 0)
				{
				}
				num = (short)235667240;
				short num3 = num;
				num = (short)1283325736;
				switch (num3 == num)
				{
				}
				num = (short)287440896;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsTopDisplayChannel_A19774;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060000BB RID: 187 RVA: 0x000121D0 File Offset: 0x000103D0
		// (set) Token: 0x060000BC RID: 188 RVA: 0x00012284 File Offset: 0x00010484
		public string ZnChanCfgChannelsTopDisplayChannel_A19774_UIValue
		{
			get
			{
				short num = (short)917962752;
				short num2 = num;
				num = (short)1307431585;
				short num3 = num;
				num = (short)79483553;
				switch (num3 == num)
				{
				}
				num = (short)2039349249;
				if (num != 0)
				{
				}
				num = (short)1397620736;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsTopDisplayChannel_A19774.Value;
			}
			set
			{
				short num = (short)421068800;
				short num2 = num;
				num = (short)1034027181;
				short num3 = num;
				num = (short)456458413;
				switch (num3 == num)
				{
				}
				num = (short)1250754561;
				if (num != 0)
				{
				}
				num = (short)1815543808;
				if (num != 0)
				{
				}
				this.znChanCfgChannelsTopDisplayChannel_A19774.Value = value;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060000BD RID: 189 RVA: 0x00012338 File Offset: 0x00010538
		// (set) Token: 0x060000BE RID: 190 RVA: 0x000123EC File Offset: 0x000105EC
		public bool ZnChanCfgChannelsTopDisplayChannel_A19774_Applicable
		{
			get
			{
				short num = (short)1907228672;
				short num2 = num;
				num = (short)351177412;
				short num3 = num;
				num = (short)991267524;
				switch (num3 == num)
				{
				}
				num = (short)1544028160;
				if (num != 0)
				{
				}
				num = (short)1212350465;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsTopDisplayChannel_A19774.Applicable;
			}
			set
			{
				short num = (short)1002831872;
				short num2 = num;
				num = (short)1026596532;
				short num3 = num;
				num = (short)1815125684;
				switch (num3 == num)
				{
				}
				num = (short)228196352;
				if (num != 0)
				{
				}
				num = (short)1075249153;
				if (num != 0)
				{
				}
				this.znChanCfgChannelsTopDisplayChannel_A19774.Applicable = value;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060000BF RID: 191 RVA: 0x000124A4 File Offset: 0x000106A4
		// (set) Token: 0x060000C0 RID: 192 RVA: 0x0001255C File Offset: 0x0001075C
		public bool ZnChanCfgChannelsTopDisplayChannel_A19774_Valid
		{
			get
			{
				short num = (short)1021444096;
				short num2 = num;
				num = (short)2102577587;
				short num3 = num;
				num = (short)1370016179;
				switch (num3 == num)
				{
				}
				num = (short)654835713;
				if (num != 0)
				{
				}
				num = (short)614858752;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsTopDisplayChannel_A19774.Valid;
			}
			set
			{
				short num = (short)1937178624;
				short num2 = num;
				num = (short)1604118762;
				short num3 = num;
				num = (short)1813702890;
				switch (num3 == num)
				{
				}
				num = (short)183500801;
				if (num != 0)
				{
				}
				num = (short)1649541120;
				if (num != 0)
				{
				}
				this.znChanCfgChannelsTopDisplayChannel_A19774.Valid = value;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060000C1 RID: 193 RVA: 0x00012610 File Offset: 0x00010810
		// (set) Token: 0x060000C2 RID: 194 RVA: 0x000126C8 File Offset: 0x000108C8
		public bool ZnChanCfgChannelsTopDisplayChannel_A19774_Visible
		{
			get
			{
				short num = (short)274006016;
				short num2 = num;
				num = (short)1210317089;
				short num3 = num;
				num = (short)1457715489;
				switch (num3 == num)
				{
				}
				num = (short)727318529;
				if (num != 0)
				{
				}
				num = (short)1943928832;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsTopDisplayChannel_A19774.Visible;
			}
			set
			{
				short num = (short)1011286016;
				short num2 = num;
				num = (short)1008805628;
				short num3 = num;
				num = (short)1549870844;
				switch (num3 == num)
				{
				}
				num = (short)1469382657;
				if (num != 0)
				{
				}
				num = (short)845545472;
				if (num != 0)
				{
				}
				this.znChanCfgChannelsTopDisplayChannel_A19774.Visible = value;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x00012780 File Offset: 0x00010980
		// (set) Token: 0x060000C4 RID: 196 RVA: 0x00012834 File Offset: 0x00010A34
		public bool ZnChanCfgChannelsTopDisplayChannel_A19774_Editable
		{
			get
			{
				short num = (short)954990592;
				short num2 = num;
				num = (short)83456598;
				short num3 = num;
				num = (short)2075488854;
				switch (num3 == num)
				{
				}
				num = (short)407109633;
				if (num != 0)
				{
				}
				num = (short)1872625664;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsTopDisplayChannel_A19774.Editable;
			}
			set
			{
				short num = (short)1852571648;
				short num2 = num;
				num = (short)1906246978;
				short num3 = num;
				num = (short)722076994;
				switch (num3 == num)
				{
				}
				num = (short)2106064896;
				if (num != 0)
				{
				}
				num = (short)1518469121;
				if (num != 0)
				{
				}
				this.znChanCfgChannelsTopDisplayChannel_A19774.Editable = value;
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060000C5 RID: 197 RVA: 0x000128E8 File Offset: 0x00010AE8
		internal string ZnChanCfgChannelsTopDisplayChannel_A19774_UILabel
		{
			get
			{
				short num = (short)1342111744;
				short num2 = num;
				num = (short)430662007;
				short num3 = num;
				num = (short)428368247;
				switch (num3 == num)
				{
				}
				num = (short)992215041;
				if (num != 0)
				{
				}
				num = (short)91422720;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsTopDisplayChannel_A19774.UIName;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060000C6 RID: 198 RVA: 0x0001299C File Offset: 0x00010B9C
		// (set) Token: 0x060000C7 RID: 199 RVA: 0x00012A54 File Offset: 0x00010C54
		internal bool ZnChanCfgChannelsTopDisplayChannel_A19774_HiddenStatic
		{
			get
			{
				short num = (short)1151270912;
				short num2 = num;
				num = (short)1355753084;
				short num3 = num;
				num = (short)22554236;
				switch (num3 == num)
				{
				}
				num = (short)533594113;
				if (num != 0)
				{
				}
				num = (short)721747968;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsTopDisplayChannel_A19774.HiddenStatic;
			}
			set
			{
				short num = (short)341114880;
				short num2 = num;
				num = (short)1301926669;
				short num3 = num;
				num = (short)1194840845;
				switch (num3 == num)
				{
				}
				num = (short)985858048;
				if (num != 0)
				{
				}
				num = (short)1378811905;
				if (num != 0)
				{
				}
				this.znChanCfgChannelsTopDisplayChannel_A19774.HiddenStatic = value;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x00012B08 File Offset: 0x00010D08
		// (set) Token: 0x060000C9 RID: 201 RVA: 0x00012BC0 File Offset: 0x00010DC0
		internal bool ZnChanCfgChannelsTopDisplayChannel_A19774_HiddenDynamic
		{
			get
			{
				short num = (short)96468992;
				short num2 = num;
				num = (short)553569974;
				short num3 = num;
				num = (short)1292881590;
				switch (num3 == num)
				{
				}
				num = (short)939786241;
				if (num != 0)
				{
				}
				num = (short)600834048;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsTopDisplayChannel_A19774.HiddenDynamic;
			}
			set
			{
				short num = (short)1004011520;
				short num2 = num;
				num = (short)800577950;
				short num3 = num;
				num = (short)538368414;
				switch (num3 == num)
				{
				}
				num = (short)600965121;
				if (num != 0)
				{
				}
				num = (short)770310144;
				if (num != 0)
				{
				}
				this.znChanCfgChannelsTopDisplayChannel_A19774.HiddenDynamic = value;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060000CA RID: 202 RVA: 0x00012C7C File Offset: 0x00010E7C
		public bool ZnChanCfgChannelsTopDisplayChannel_A19774_HasDiffs
		{
			get
			{
				short num = (short)1202257920;
				short num2 = num;
				num = (short)2054422529;
				if (num != 0)
				{
				}
				num = (short)256877738;
				short num3 = num;
				num = (short)1683137706;
				switch (num3 == num)
				{
				}
				num = (short)1593442304;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsTopDisplayChannel_A19774._HasDiffs;
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060000CB RID: 203 RVA: 0x00012D30 File Offset: 0x00010F30
		// (set) Token: 0x060000CC RID: 204 RVA: 0x00012DE8 File Offset: 0x00010FE8
		public int ChannelAnnouncementID_A20175Value
		{
			get
			{
				short num = (short)186974208;
				short num2 = num;
				num = (short)540418120;
				short num3 = num;
				num = (short)2096767048;
				switch (num3 == num)
				{
				}
				num = (short)1145241601;
				if (num != 0)
				{
				}
				num = (short)2123563008;
				if (num != 0)
				{
				}
				return this.channelAnnouncementID_A20175.Value;
			}
			set
			{
				short num = (short)829882368;
				short num2 = num;
				num = (short)1028653057;
				if (num != 0)
				{
				}
				num = (short)761834373;
				short num3 = num;
				num = (short)1418832773;
				switch (num3 == num)
				{
				}
				num = (short)1663041536;
				if (num != 0)
				{
				}
				this.channelAnnouncementID_A20175.Value = value;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060000CD RID: 205 RVA: 0x00012EA0 File Offset: 0x000110A0
		// (set) Token: 0x060000CE RID: 206 RVA: 0x00012F54 File Offset: 0x00011154
		public string ChannelAnnouncementID_A20175_UIValue
		{
			get
			{
				short num = (short)844955648;
				short num2 = num;
				num = (short)105189140;
				short num3 = num;
				num = (short)1049693972;
				switch (num3 == num)
				{
				}
				num = (short)1580072960;
				if (num != 0)
				{
				}
				num = (short)253296641;
				if (num != 0)
				{
				}
				return this.channelAnnouncementID_A20175.UIValue;
			}
			set
			{
				short num = (short)679084032;
				short num2 = num;
				num = (short)686292993;
				if (num != 0)
				{
				}
				num = (short)1679017182;
				short num3 = num;
				num = (short)1076151518;
				switch (num3 == num)
				{
				}
				num = (short)300417024;
				if (num != 0)
				{
				}
				this.channelAnnouncementID_A20175.UIValue = value;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060000CF RID: 207 RVA: 0x00013008 File Offset: 0x00011208
		public global::AcpBusinessLayer.AcpRecRefField ChannelAnnouncementID_A20175
		{
			get
			{
				short num = (short)1562050560;
				short num2 = num;
				num = (short)448679860;
				short num3 = num;
				num = (short)904810420;
				switch (num3 == num)
				{
				}
				num = (short)236978177;
				if (num != 0)
				{
				}
				num = (short)693698560;
				if (num != 0)
				{
				}
				return this.channelAnnouncementID_A20175;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x000130B8 File Offset: 0x000112B8
		// (set) Token: 0x060000D1 RID: 209 RVA: 0x00013170 File Offset: 0x00011370
		public bool ChannelAnnouncementID_A20175_Applicable
		{
			get
			{
				short num = (short)1346240512;
				short num2 = num;
				num = (short)1473732350;
				short num3 = num;
				num = (short)466837246;
				switch (num3 == num)
				{
				}
				num = (short)869924865;
				if (num != 0)
				{
				}
				num = (short)1686962176;
				if (num != 0)
				{
				}
				return this.channelAnnouncementID_A20175.Applicable;
			}
			set
			{
				short num = (short)1987379200;
				short num2 = num;
				num = (short)2057832688;
				short num3 = num;
				num = (short)1121126640;
				switch (num3 == num)
				{
				}
				num = (short)1697447936;
				if (num != 0)
				{
				}
				num = (short)56950785;
				if (num != 0)
				{
				}
				this.channelAnnouncementID_A20175.Applicable = value;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x00013228 File Offset: 0x00011428
		// (set) Token: 0x060000D3 RID: 211 RVA: 0x000132E0 File Offset: 0x000114E0
		public bool ChannelAnnouncementID_A20175_Valid
		{
			get
			{
				short num = (short)888471552;
				short num2 = num;
				num = (short)1134100795;
				short num3 = num;
				num = (short)1295188283;
				switch (num3 == num)
				{
				}
				num = (short)1766850561;
				if (num != 0)
				{
				}
				num = (short)726532096;
				if (num != 0)
				{
				}
				return this.channelAnnouncementID_A20175.Valid;
			}
			set
			{
				short num = (short)1041170432;
				short num2 = num;
				num = (short)1267329201;
				short num3 = num;
				num = (short)836167857;
				switch (num3 == num)
				{
				}
				num = (short)1287323649;
				if (num != 0)
				{
				}
				num = (short)994050048;
				if (num != 0)
				{
				}
				this.channelAnnouncementID_A20175.Valid = value;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060000D4 RID: 212 RVA: 0x00013398 File Offset: 0x00011598
		// (set) Token: 0x060000D5 RID: 213 RVA: 0x00013448 File Offset: 0x00011648
		public bool ChannelAnnouncementID_A20175_Visible
		{
			get
			{
				short num = (short)907280384;
				short num2 = num;
				num = (short)448529147;
				short num3 = num;
				num = (short)1811612411;
				switch (num3 == num)
				{
				}
				num = (short)1147142144;
				if (num != 0)
				{
				}
				num = (short)1133510657;
				if (num != 0)
				{
				}
				return this.channelAnnouncementID_A20175.Visible;
			}
			set
			{
				short num = (short)1474232320;
				short num2 = num;
				num = (short)737935361;
				if (num != 0)
				{
				}
				num = (short)239876481;
				short num3 = num;
				num = (short)1030109569;
				switch (num3 == num)
				{
				}
				num = (short)1440350208;
				if (num != 0)
				{
				}
				this.channelAnnouncementID_A20175.Visible = value;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060000D6 RID: 214 RVA: 0x000134FC File Offset: 0x000116FC
		// (set) Token: 0x060000D7 RID: 215 RVA: 0x000135AC File Offset: 0x000117AC
		public bool ChannelAnnouncementID_A20175_Editable
		{
			get
			{
				short num = (short)602275840;
				short num2 = num;
				num = (short)1419753806;
				short num3 = num;
				num = (short)757840206;
				switch (num3 == num)
				{
				}
				num = (short)2140930049;
				if (num != 0)
				{
				}
				num = (short)374472704;
				if (num != 0)
				{
				}
				return this.channelAnnouncementID_A20175.Editable;
			}
			set
			{
				short num = (short)502923264;
				short num2 = num;
				num = (short)77208927;
				short num3 = num;
				num = (short)917773663;
				switch (num3 == num)
				{
				}
				num = (short)825884673;
				if (num != 0)
				{
				}
				num = (short)1546190848;
				if (num != 0)
				{
				}
				this.channelAnnouncementID_A20175.Editable = value;
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060000D8 RID: 216 RVA: 0x00013668 File Offset: 0x00011868
		internal string ChannelAnnouncementID_A20175_UILabel
		{
			get
			{
				short num = (short)1546387457;
				if (num != 0)
				{
				}
				num = (short)150208512;
				short num2 = num;
				num = (short)1620525479;
				short num3 = num;
				num = (short)1270104487;
				switch (num3 == num)
				{
				}
				num = (short)1333854208;
				if (num != 0)
				{
				}
				return this.channelAnnouncementID_A20175.UIName;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060000D9 RID: 217 RVA: 0x0001371C File Offset: 0x0001191C
		// (set) Token: 0x060000DA RID: 218 RVA: 0x000137D0 File Offset: 0x000119D0
		internal bool ChannelAnnouncementID_A20175_HiddenStatic
		{
			get
			{
				short num = (short)65163190;
				short num2 = num;
				num = (short)860901302;
				switch (num2 == num)
				{
				default:
				{
					num = (short)161349632;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1272381441;
				if (num != 0)
				{
				}
				num = (short)1471021056;
				if (num != 0)
				{
				}
				return this.channelAnnouncementID_A20175.HiddenStatic;
			}
			set
			{
				short num = (short)618810507;
				short num2 = num;
				num = (short)1140345995;
				switch (num2 == num)
				{
				default:
				{
					num = (short)236781568;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)61669376;
				if (num != 0)
				{
				}
				num = (short)881459201;
				if (num != 0)
				{
				}
				this.channelAnnouncementID_A20175.HiddenStatic = value;
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060000DB RID: 219 RVA: 0x00013884 File Offset: 0x00011A84
		// (set) Token: 0x060000DC RID: 220 RVA: 0x0001393C File Offset: 0x00011B3C
		internal bool ChannelAnnouncementID_A20175_HiddenDynamic
		{
			get
			{
				short num = (short)670760961;
				if (num != 0)
				{
				}
				num = (short)853868544;
				short num2 = num;
				num = (short)1583445407;
				short num3 = num;
				num = (short)1860662687;
				switch (num3 == num)
				{
				}
				num = (short)710017024;
				if (num != 0)
				{
				}
				return this.channelAnnouncementID_A20175.HiddenDynamic;
			}
			set
			{
				short num = (short)974229044;
				short num2 = num;
				num = (short)1883934260;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1197146112;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)490995713;
				if (num != 0)
				{
				}
				num = (short)1254096896;
				if (num != 0)
				{
				}
				this.channelAnnouncementID_A20175.HiddenDynamic = value;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060000DD RID: 221 RVA: 0x000139F0 File Offset: 0x00011BF0
		public bool ChannelAnnouncementID_A20175_HasDiffs
		{
			get
			{
				short num = (short)457571818;
				short num2 = num;
				num = (short)1382022634;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1740242944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)123207681;
				if (num != 0)
				{
				}
				num = (short)1027080192;
				if (num != 0)
				{
				}
				return this.channelAnnouncementID_A20175._HasDiffs;
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060000DE RID: 222 RVA: 0x00013AA8 File Offset: 0x00011CA8
		// (set) Token: 0x060000DF RID: 223 RVA: 0x00013B5C File Offset: 0x00011D5C
		public string VCChannelAnnouncement_A20176Value
		{
			get
			{
				short num = (short)336134818;
				short num2 = num;
				num = (short)754451106;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1698430976;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1574764545;
				if (num != 0)
				{
				}
				num = (short)1280245760;
				if (num != 0)
				{
				}
				return this.vCChannelAnnouncement_A20176.Value;
			}
			set
			{
				short num = (short)1906520528;
				short num2 = num;
				num = (short)1311650256;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1947598848;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)231604225;
				if (num != 0)
				{
				}
				num = (short)2072248320;
				if (num != 0)
				{
				}
				this.vCChannelAnnouncement_A20176.Value = value;
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060000E0 RID: 224 RVA: 0x00013C10 File Offset: 0x00011E10
		public global::AcpBusinessLayer.AcpField<string> VCChannelAnnouncement_A20176
		{
			get
			{
				short num = (short)1013252097;
				if (num != 0)
				{
				}
				num = (short)164233216;
				short num2 = num;
				num = (short)849335493;
				short num3 = num;
				num = (short)233166021;
				switch (num3 == num)
				{
				}
				num = (short)1208418304;
				if (num != 0)
				{
				}
				return this.vCChannelAnnouncement_A20176;
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060000E1 RID: 225 RVA: 0x00013CC0 File Offset: 0x00011EC0
		// (set) Token: 0x060000E2 RID: 226 RVA: 0x00013D74 File Offset: 0x00011F74
		public string VCChannelAnnouncement_A20176_UIValue
		{
			get
			{
				short num = (short)801308673;
				if (num != 0)
				{
				}
				num = (short)314310656;
				short num2 = num;
				num = (short)1020419120;
				short num3 = num;
				num = (short)849173552;
				switch (num3 == num)
				{
				}
				num = (short)936968192;
				if (num != 0)
				{
				}
				return this.vCChannelAnnouncement_A20176.Value;
			}
			set
			{
				short num = (short)1386164269;
				short num2 = num;
				num = (short)1744777261;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2124939264;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)972488705;
				if (num != 0)
				{
				}
				num = (short)1272643584;
				if (num != 0)
				{
				}
				this.vCChannelAnnouncement_A20176.Value = value;
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060000E3 RID: 227 RVA: 0x00013E2C File Offset: 0x0001202C
		// (set) Token: 0x060000E4 RID: 228 RVA: 0x00013EE4 File Offset: 0x000120E4
		public bool VCChannelAnnouncement_A20176_Applicable
		{
			get
			{
				short num = (short)899797697;
				short num2 = num;
				num = (short)1933759169;
				switch (num2 == num)
				{
				default:
				{
					num = (short)201064448;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)78643201;
				if (num != 0)
				{
				}
				num = (short)701431808;
				if (num != 0)
				{
				}
				return this.vCChannelAnnouncement_A20176.Applicable;
			}
			set
			{
				short num = (short)1251999745;
				if (num != 0)
				{
				}
				num = (short)1061814272;
				short num2 = num;
				num = (short)1829059191;
				short num3 = num;
				num = (short)1705982583;
				switch (num3 == num)
				{
				}
				num = (short)2083520512;
				if (num != 0)
				{
				}
				this.vCChannelAnnouncement_A20176.Applicable = value;
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060000E5 RID: 229 RVA: 0x00013FA0 File Offset: 0x000121A0
		// (set) Token: 0x060000E6 RID: 230 RVA: 0x00014058 File Offset: 0x00012258
		public bool VCChannelAnnouncement_A20176_Valid
		{
			get
			{
				short num = (short)1561985544;
				short num2 = num;
				num = (short)1583612424;
				switch (num2 == num)
				{
				default:
				{
					num = (short)365428736;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)150536193;
				if (num != 0)
				{
				}
				num = (short)279642112;
				if (num != 0)
				{
				}
				return this.vCChannelAnnouncement_A20176.Valid;
			}
			set
			{
				short num = (short)513443828;
				short num2 = num;
				num = (short)105351156;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2050490368;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2073821184;
				if (num != 0)
				{
				}
				num = (short)761724929;
				if (num != 0)
				{
				}
				this.vCChannelAnnouncement_A20176.Valid = value;
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060000E7 RID: 231 RVA: 0x00014110 File Offset: 0x00012310
		// (set) Token: 0x060000E8 RID: 232 RVA: 0x000141C4 File Offset: 0x000123C4
		public bool VCChannelAnnouncement_A20176_Visible
		{
			get
			{
				short num = (short)1197234879;
				short num2 = num;
				num = (short)1094539967;
				switch (num2 == num)
				{
				default:
				{
					num = (short)662765568;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1434648577;
				if (num != 0)
				{
				}
				num = (short)845938688;
				if (num != 0)
				{
				}
				return this.vCChannelAnnouncement_A20176.Visible;
			}
			set
			{
				short num = (short)112408989;
				short num2 = num;
				num = (short)1614887325;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1616904192;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2039611393;
				if (num != 0)
				{
				}
				num = (short)372506624;
				if (num != 0)
				{
				}
				this.vCChannelAnnouncement_A20176.Visible = value;
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060000E9 RID: 233 RVA: 0x0001427C File Offset: 0x0001247C
		// (set) Token: 0x060000EA RID: 234 RVA: 0x0001432C File Offset: 0x0001252C
		public bool VCChannelAnnouncement_A20176_Editable
		{
			get
			{
				short num = (short)1720640066;
				short num2 = num;
				num = (short)501473858;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1751252992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2010054657;
				if (num != 0)
				{
				}
				num = (short)1121255424;
				if (num != 0)
				{
				}
				return this.vCChannelAnnouncement_A20176.Editable;
			}
			set
			{
				short num = (short)288739863;
				short num2 = num;
				num = (short)1347932695;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1493172224;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)107806720;
				if (num != 0)
				{
				}
				num = (short)1272643585;
				if (num != 0)
				{
				}
				this.vCChannelAnnouncement_A20176.Editable = value;
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060000EB RID: 235 RVA: 0x000143E0 File Offset: 0x000125E0
		internal string VCChannelAnnouncement_A20176_UILabel
		{
			get
			{
				short num = (short)163583518;
				short num2 = num;
				num = (short)1881675294;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1755447296;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)529924097;
				if (num != 0)
				{
				}
				num = (short)2129133568;
				if (num != 0)
				{
				}
				return this.vCChannelAnnouncement_A20176.UIName;
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060000EC RID: 236 RVA: 0x00014498 File Offset: 0x00012698
		// (set) Token: 0x060000ED RID: 237 RVA: 0x0001454C File Offset: 0x0001274C
		internal bool VCChannelAnnouncement_A20176_HiddenStatic
		{
			get
			{
				short num = (short)1819345918;
				short num2 = num;
				num = (short)1818166270;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1525874688;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1818755073;
				if (num != 0)
				{
				}
				num = (short)1089011712;
				if (num != 0)
				{
				}
				return this.vCChannelAnnouncement_A20176.HiddenStatic;
			}
			set
			{
				short num = (short)880285619;
				short num2 = num;
				num = (short)1868437427;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2121138176;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1079902208;
				if (num != 0)
				{
				}
				num = (short)873857025;
				if (num != 0)
				{
				}
				this.vCChannelAnnouncement_A20176.HiddenStatic = value;
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060000EE RID: 238 RVA: 0x00014600 File Offset: 0x00012800
		// (set) Token: 0x060000EF RID: 239 RVA: 0x000146B4 File Offset: 0x000128B4
		internal bool VCChannelAnnouncement_A20176_HiddenDynamic
		{
			get
			{
				short num = (short)1107106783;
				short num2 = num;
				num = (short)655170527;
				switch (num2 == num)
				{
				default:
				{
					num = (short)249167872;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)434372609;
				if (num != 0)
				{
				}
				num = (short)256507904;
				if (num != 0)
				{
				}
				return this.vCChannelAnnouncement_A20176.HiddenDynamic;
			}
			set
			{
				short num = (short)924189107;
				short num2 = num;
				num = (short)491913651;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1169227776;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)661520385;
				if (num != 0)
				{
				}
				num = (short)2116747264;
				if (num != 0)
				{
				}
				this.vCChannelAnnouncement_A20176.HiddenDynamic = value;
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060000F0 RID: 240 RVA: 0x00014768 File Offset: 0x00012968
		public bool VCChannelAnnouncement_A20176_HasDiffs
		{
			get
			{
				short num = (short)1548577598;
				short num2 = num;
				num = (short)119368510;
				switch (num2 == num)
				{
				default:
				{
					num = (short)483721216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)347734017;
				if (num != 0)
				{
				}
				num = (short)372441088;
				if (num != 0)
				{
				}
				return this.vCChannelAnnouncement_A20176._HasDiffs;
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x00014820 File Offset: 0x00012A20
		// (set) Token: 0x060000F2 RID: 242 RVA: 0x000148D4 File Offset: 0x00012AD4
		public int ZnChanCfgChannelsRadioProfileCompositeItemNameID_A20192Value
		{
			get
			{
				short num = (short)1480175476;
				short num2 = num;
				num = (short)870035316;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1060896768;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1326907393;
				if (num != 0)
				{
				}
				num = (short)2006450176;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsRadioProfileCompositeItemNameID_A20192.Value;
			}
			set
			{
				short num = (short)1302426531;
				short num2 = num;
				num = (short)1093956515;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1133445120;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)959315969;
				if (num != 0)
				{
				}
				num = (short)1705705472;
				if (num != 0)
				{
				}
				this.znChanCfgChannelsRadioProfileCompositeItemNameID_A20192.Value = value;
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060000F3 RID: 243 RVA: 0x00014988 File Offset: 0x00012B88
		// (set) Token: 0x060000F4 RID: 244 RVA: 0x00014A3C File Offset: 0x00012C3C
		public string ZnChanCfgChannelsRadioProfileCompositeItemNameID_A20192_UIValue
		{
			get
			{
				short num = (short)582612924;
				short num2 = num;
				num = (short)668137404;
				switch (num2 == num)
				{
				default:
				{
					num = (short)202571776;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2084110337;
				if (num != 0)
				{
				}
				num = (short)589627392;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsRadioProfileCompositeItemNameID_A20192.UIValue;
			}
			set
			{
				short num = (short)797018504;
				short num2 = num;
				num = (short)1525778824;
				switch (num2 == num)
				{
				default:
				{
					num = (short)813039616;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1781858305;
				if (num != 0)
				{
				}
				num = (short)1311244288;
				if (num != 0)
				{
				}
				this.znChanCfgChannelsRadioProfileCompositeItemNameID_A20192.UIValue = value;
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x00014AF4 File Offset: 0x00012CF4
		public global::AcpBusinessLayer.AcpRecRefField ZnChanCfgChannelsRadioProfileCompositeItemNameID_A20192
		{
			get
			{
				short num = (short)1176024578;
				short num2 = num;
				num = (short)100447746;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1642070016;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1796472833;
				if (num != 0)
				{
				}
				num = (short)168230912;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsRadioProfileCompositeItemNameID_A20192;
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060000F6 RID: 246 RVA: 0x00014BA4 File Offset: 0x00012DA4
		// (set) Token: 0x060000F7 RID: 247 RVA: 0x00014C58 File Offset: 0x00012E58
		public bool ZnChanCfgChannelsRadioProfileCompositeItemNameID_A20192_Applicable
		{
			get
			{
				short num = (short)620152504;
				short num2 = num;
				num = (short)598656696;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1421869056;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)327024640;
				if (num != 0)
				{
				}
				num = (short)1464860673;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsRadioProfileCompositeItemNameID_A20192.Applicable;
			}
			set
			{
				short num = (short)296529769;
				short num2 = num;
				num = (short)1095020393;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1974009856;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1735393281;
				if (num != 0)
				{
				}
				num = (short)1247281152;
				if (num != 0)
				{
				}
				this.znChanCfgChannelsRadioProfileCompositeItemNameID_A20192.Applicable = value;
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060000F8 RID: 248 RVA: 0x00014D10 File Offset: 0x00012F10
		// (set) Token: 0x060000F9 RID: 249 RVA: 0x00014DC8 File Offset: 0x00012FC8
		public bool ZnChanCfgChannelsRadioProfileCompositeItemNameID_A20192_Valid
		{
			get
			{
				short num = (short)343343105;
				if (num != 0)
				{
				}
				num = (short)2105540608;
				short num2 = num;
				num = (short)556154835;
				short num3 = num;
				num = (short)1786527699;
				switch (num3 == num)
				{
				}
				num = (short)1022623744;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsRadioProfileCompositeItemNameID_A20192.Valid;
			}
			set
			{
				short num = (short)181275036;
				short num2 = num;
				num = (short)1405225372;
				switch (num2 == num)
				{
				default:
				{
					num = (short)399376384;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)580452352;
				if (num != 0)
				{
				}
				num = (short)1600323585;
				if (num != 0)
				{
				}
				this.znChanCfgChannelsRadioProfileCompositeItemNameID_A20192.Valid = value;
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060000FA RID: 250 RVA: 0x00014E7C File Offset: 0x0001307C
		// (set) Token: 0x060000FB RID: 251 RVA: 0x00014F30 File Offset: 0x00013130
		public bool ZnChanCfgChannelsRadioProfileCompositeItemNameID_A20192_Visible
		{
			get
			{
				short num = (short)1205153967;
				short num2 = num;
				num = (short)488386735;
				switch (num2 == num)
				{
				default:
				{
					num = (short)570163200;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1819279361;
				if (num != 0)
				{
				}
				num = (short)561381376;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsRadioProfileCompositeItemNameID_A20192.Visible;
			}
			set
			{
				short num = (short)2093200779;
				short num2 = num;
				num = (short)1456715147;
				switch (num2 == num)
				{
				default:
				{
					num = (short)199163904;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)689307649;
				if (num != 0)
				{
				}
				num = (short)288161792;
				if (num != 0)
				{
				}
				this.znChanCfgChannelsRadioProfileCompositeItemNameID_A20192.Visible = value;
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060000FC RID: 252 RVA: 0x00014FE8 File Offset: 0x000131E8
		// (set) Token: 0x060000FD RID: 253 RVA: 0x000150A0 File Offset: 0x000132A0
		public bool ZnChanCfgChannelsRadioProfileCompositeItemNameID_A20192_Editable
		{
			get
			{
				short num = (short)256644331;
				short num2 = num;
				num = (short)972231915;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1242693632;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1481310209;
				if (num != 0)
				{
				}
				num = (short)759758848;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsRadioProfileCompositeItemNameID_A20192.Editable;
			}
			set
			{
				short num = (short)1624027356;
				short num2 = num;
				num = (short)1059893468;
				switch (num2 == num)
				{
				default:
				{
					num = (short)909967360;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1840185345;
				if (num != 0)
				{
				}
				num = (short)1889599488;
				if (num != 0)
				{
				}
				this.znChanCfgChannelsRadioProfileCompositeItemNameID_A20192.Editable = value;
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060000FE RID: 254 RVA: 0x00015158 File Offset: 0x00013358
		internal string ZnChanCfgChannelsRadioProfileCompositeItemNameID_A20192_UILabel
		{
			get
			{
				short num = (short)1928938712;
				short num2 = num;
				num = (short)904086744;
				switch (num2 == num)
				{
				default:
				{
					num = (short)11993088;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)553123841;
				if (num != 0)
				{
				}
				num = (short)1084030976;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsRadioProfileCompositeItemNameID_A20192.UIName;
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060000FF RID: 255 RVA: 0x00015210 File Offset: 0x00013410
		// (set) Token: 0x06000100 RID: 256 RVA: 0x000152C4 File Offset: 0x000134C4
		internal bool ZnChanCfgChannelsRadioProfileCompositeItemNameID_A20192_HiddenStatic
		{
			get
			{
				short num = (short)54710475;
				short num2 = num;
				num = (short)1259393227;
				switch (num2 == num)
				{
				default:
				{
					num = (short)307363840;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)352583681;
				if (num != 0)
				{
				}
				num = (short)448004096;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsRadioProfileCompositeItemNameID_A20192.HiddenStatic;
			}
			set
			{
				short num = (short)1788466940;
				short num2 = num;
				num = (short)1166333692;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1560084480;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2089222144;
				if (num != 0)
				{
				}
				num = (short)1422262273;
				if (num != 0)
				{
				}
				this.znChanCfgChannelsRadioProfileCompositeItemNameID_A20192.HiddenStatic = value;
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000101 RID: 257 RVA: 0x0001537C File Offset: 0x0001357C
		// (set) Token: 0x06000102 RID: 258 RVA: 0x00015430 File Offset: 0x00013630
		internal bool ZnChanCfgChannelsRadioProfileCompositeItemNameID_A20192_HiddenDynamic
		{
			get
			{
				short num = (short)1115517658;
				short num2 = num;
				num = (short)1150382810;
				switch (num2 == num)
				{
				default:
				{
					num = (short)235012096;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)377946113;
				if (num != 0)
				{
				}
				num = (short)548929536;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsRadioProfileCompositeItemNameID_A20192.HiddenDynamic;
			}
			set
			{
				short num = (short)838355842;
				short num2 = num;
				num = (short)665340802;
				switch (num2 == num)
				{
				default:
				{
					num = (short)431030272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)825425921;
				if (num != 0)
				{
				}
				num = (short)648871936;
				if (num != 0)
				{
				}
				this.znChanCfgChannelsRadioProfileCompositeItemNameID_A20192.HiddenDynamic = value;
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000103 RID: 259 RVA: 0x000154E8 File Offset: 0x000136E8
		public bool ZnChanCfgChannelsRadioProfileCompositeItemNameID_A20192_HasDiffs
		{
			get
			{
				short num = (short)1101352788;
				short num2 = num;
				num = (short)101732180;
				switch (num2 == num)
				{
				default:
				{
					num = (short)539754496;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1787297792;
				if (num != 0)
				{
				}
				num = (short)1660289025;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsRadioProfileCompositeItemNameID_A20192._HasDiffs;
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000104 RID: 260 RVA: 0x0001559C File Offset: 0x0001379C
		// (set) Token: 0x06000105 RID: 261 RVA: 0x00015650 File Offset: 0x00013850
		public int ZnChanCfgChannelsConventionalChannelReference_A20560Value
		{
			get
			{
				short num = (short)289267430;
				short num2 = num;
				num = (short)310107878;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1685913600;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1511784449;
				if (num != 0)
				{
				}
				num = (short)855900160;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsConventionalChannelReference_A20560.Value;
			}
			set
			{
				short num = (short)1121317404;
				short num2 = num;
				num = (short)397996572;
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
				num = (short)63307777;
				if (num != 0)
				{
				}
				num = (short)909246464;
				if (num != 0)
				{
				}
				this.znChanCfgChannelsConventionalChannelReference_A20560.Value = value;
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000106 RID: 262 RVA: 0x00015708 File Offset: 0x00013908
		// (set) Token: 0x06000107 RID: 263 RVA: 0x000157BC File Offset: 0x000139BC
		public string ZnChanCfgChannelsConventionalChannelReference_A20560_UIValue
		{
			get
			{
				short num = (short)1805653308;
				short num2 = num;
				num = (short)1315509564;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1804992512;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2031288321;
				if (num != 0)
				{
				}
				num = (short)948174848;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsConventionalChannelReference_A20560.UIValue;
			}
			set
			{
				short num = (short)534970369;
				if (num != 0)
				{
				}
				num = (short)342491136;
				short num2 = num;
				num = (short)693329141;
				short num3 = num;
				num = (short)1157389557;
				switch (num3 == num)
				{
				}
				num = (short)237699072;
				if (num != 0)
				{
				}
				this.znChanCfgChannelsConventionalChannelReference_A20560.UIValue = value;
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000108 RID: 264 RVA: 0x00015870 File Offset: 0x00013A70
		public global::AcpBusinessLayer.AcpRecRefField ZnChanCfgChannelsConventionalChannelReference_A20560
		{
			get
			{
				short num = (short)1926234113;
				if (num != 0)
				{
				}
				num = (short)846135296;
				short num2 = num;
				num = (short)1444774139;
				short num3 = num;
				num = (short)22905083;
				switch (num3 == num)
				{
				}
				num = (short)1086193664;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsConventionalChannelReference_A20560;
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000109 RID: 265 RVA: 0x00015920 File Offset: 0x00013B20
		// (set) Token: 0x0600010A RID: 266 RVA: 0x000159D4 File Offset: 0x00013BD4
		public bool ZnChanCfgChannelsConventionalChannelReference_A20560_Applicable
		{
			get
			{
				short num = (short)1184343675;
				short num2 = num;
				num = (short)1161995899;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2100428800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1235484672;
				if (num != 0)
				{
				}
				num = (short)976814081;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsConventionalChannelReference_A20560.Applicable;
			}
			set
			{
				short num = (short)1576271873;
				if (num != 0)
				{
				}
				num = (short)1337655296;
				short num2 = num;
				num = (short)2134683412;
				short num3 = num;
				num = (short)1699327764;
				switch (num3 == num)
				{
				}
				num = (short)2002321408;
				if (num != 0)
				{
				}
				this.znChanCfgChannelsConventionalChannelReference_A20560.Applicable = value;
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x0600010B RID: 267 RVA: 0x00015A8C File Offset: 0x00013C8C
		// (set) Token: 0x0600010C RID: 268 RVA: 0x00015B40 File Offset: 0x00013D40
		public bool ZnChanCfgChannelsConventionalChannelReference_A20560_Valid
		{
			get
			{
				short num = (short)1411326136;
				short num2 = num;
				num = (short)639312056;
				switch (num2 == num)
				{
				default:
				{
					num = (short)591790080;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)396689409;
				if (num != 0)
				{
				}
				num = (short)354025472;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsConventionalChannelReference_A20560.Valid;
			}
			set
			{
				short num = (short)1447782249;
				short num2 = num;
				num = (short)325740393;
				switch (num2 == num)
				{
				default:
				{
					num = (short)676003840;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1680146433;
				if (num != 0)
				{
				}
				num = (short)548077568;
				if (num != 0)
				{
				}
				this.znChanCfgChannelsConventionalChannelReference_A20560.Valid = value;
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x0600010D RID: 269 RVA: 0x00015BF4 File Offset: 0x00013DF4
		// (set) Token: 0x0600010E RID: 270 RVA: 0x00015CA8 File Offset: 0x00013EA8
		public bool ZnChanCfgChannelsConventionalChannelReference_A20560_Visible
		{
			get
			{
				short num = (short)68002607;
				short num2 = num;
				num = (short)1986110255;
				switch (num2 == num)
				{
				default:
				{
					num = (short)253362176;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)720502784;
				if (num != 0)
				{
				}
				num = (short)1854603265;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsConventionalChannelReference_A20560.Visible;
			}
			set
			{
				short num = (short)667031905;
				short num2 = num;
				num = (short)257628513;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1251803136;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)889913345;
				if (num != 0)
				{
				}
				num = (short)1884684288;
				if (num != 0)
				{
				}
				this.znChanCfgChannelsConventionalChannelReference_A20560.Visible = value;
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x0600010F RID: 271 RVA: 0x00015D5C File Offset: 0x00013F5C
		// (set) Token: 0x06000110 RID: 272 RVA: 0x00015E10 File Offset: 0x00014010
		public bool ZnChanCfgChannelsConventionalChannelReference_A20560_Editable
		{
			get
			{
				short num = (short)429861363;
				short num2 = num;
				num = (short)305867251;
				switch (num2 == num)
				{
				default:
				{
					num = (short)742260736;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)195559425;
				if (num != 0)
				{
				}
				num = (short)2102853632;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsConventionalChannelReference_A20560.Editable;
			}
			set
			{
				short num = (short)2086273025;
				if (num != 0)
				{
				}
				num = (short)1688338432;
				short num2 = num;
				num = (short)1905210327;
				short num3 = num;
				num = (short)107885527;
				switch (num3 == num)
				{
				}
				num = (short)1626406912;
				if (num != 0)
				{
				}
				this.znChanCfgChannelsConventionalChannelReference_A20560.Editable = value;
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000111 RID: 273 RVA: 0x00015EC4 File Offset: 0x000140C4
		internal string ZnChanCfgChannelsConventionalChannelReference_A20560_UILabel
		{
			get
			{
				short num = (short)692341464;
				short num2 = num;
				num = (short)1385712344;
				switch (num2 == num)
				{
				default:
				{
					num = (short)565444608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)497287168;
				if (num != 0)
				{
				}
				num = (short)885391361;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsConventionalChannelReference_A20560.UIName;
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000112 RID: 274 RVA: 0x00015F7C File Offset: 0x0001417C
		// (set) Token: 0x06000113 RID: 275 RVA: 0x00016030 File Offset: 0x00014230
		internal bool ZnChanCfgChannelsConventionalChannelReference_A20560_HiddenStatic
		{
			get
			{
				short num = (short)1582697057;
				short num2 = num;
				num = (short)1944193633;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1317076992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)744816641;
				if (num != 0)
				{
				}
				num = (short)1851260928;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsConventionalChannelReference_A20560.HiddenStatic;
			}
			set
			{
				short num = (short)1112727232;
				short num2 = num;
				num = (short)1139662528;
				switch (num2 == num)
				{
				default:
				{
					num = (short)546963456;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1125711873;
				if (num != 0)
				{
				}
				num = (short)1852833792;
				if (num != 0)
				{
				}
				this.znChanCfgChannelsConventionalChannelReference_A20560.HiddenStatic = value;
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000114 RID: 276 RVA: 0x000160E8 File Offset: 0x000142E8
		// (set) Token: 0x06000115 RID: 277 RVA: 0x0001619C File Offset: 0x0001439C
		internal bool ZnChanCfgChannelsConventionalChannelReference_A20560_HiddenDynamic
		{
			get
			{
				short num = (short)435063367;
				short num2 = num;
				num = (short)554928711;
				switch (num2 == num)
				{
				}
				num = (short)2078277632;
				short num3 = num;
				num = (short)1448673281;
				if (num != 0)
				{
				}
				num = (short)1391919104;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsConventionalChannelReference_A20560.HiddenDynamic;
			}
			set
			{
				short num = (short)309725926;
				short num2 = num;
				num = (short)870124262;
				switch (num2 == num)
				{
				}
				num = (short)138543104;
				short num3 = num;
				num = (short)2004615169;
				if (num != 0)
				{
				}
				num = (short)1970995200;
				if (num != 0)
				{
				}
				this.znChanCfgChannelsConventionalChannelReference_A20560.HiddenDynamic = value;
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000116 RID: 278 RVA: 0x00016250 File Offset: 0x00014450
		public bool ZnChanCfgChannelsConventionalChannelReference_A20560_HasDiffs
		{
			get
			{
				short num = (short)72329287;
				short num2 = num;
				num = (short)1130801223;
				switch (num2 == num)
				{
				}
				num = (short)528220160;
				short num3 = num;
				num = (short)1997733888;
				if (num != 0)
				{
				}
				num = (short)502530049;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsConventionalChannelReference_A20560._HasDiffs;
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000117 RID: 279 RVA: 0x00016304 File Offset: 0x00014504
		// (set) Token: 0x06000118 RID: 280 RVA: 0x000163BC File Offset: 0x000145BC
		public int ZnChanCfgChannelsChannelType_A22241Value
		{
			get
			{
				short num = (short)1249582787;
				short num2 = num;
				num = (short)77930179;
				switch (num2 == num)
				{
				}
				num = (short)1039794176;
				short num3 = num;
				num = (short)125370368;
				if (num != 0)
				{
				}
				num = (short)169345025;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsChannelType_A22241.Value;
			}
			set
			{
				short num = (short)577279352;
				short num2 = num;
				num = (short)1475188088;
				switch (num2 == num)
				{
				}
				num = (short)531300352;
				short num3 = num;
				num = (short)365756417;
				if (num != 0)
				{
				}
				num = (short)973668352;
				if (num != 0)
				{
				}
				this.znChanCfgChannelsChannelType_A22241.Value = value;
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000119 RID: 281 RVA: 0x00016474 File Offset: 0x00014674
		// (set) Token: 0x0600011A RID: 282 RVA: 0x00016528 File Offset: 0x00014728
		public string ZnChanCfgChannelsChannelType_A22241_UIValue
		{
			get
			{
				short num = (short)733970628;
				short num2 = num;
				num = (short)1941602500;
				switch (num2 == num)
				{
				}
				num = (short)34144256;
				short num3 = num;
				num = (short)288817153;
				if (num != 0)
				{
				}
				num = (short)420806656;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsChannelType_A22241.UIValue;
			}
			set
			{
				short num = (short)1146852077;
				short num2 = num;
				num = (short)1920897773;
				switch (num2 == num)
				{
				}
				num = (short)203554816;
				short num3 = num;
				num = (short)1268973569;
				if (num != 0)
				{
				}
				num = (short)1634009088;
				if (num != 0)
				{
				}
				this.znChanCfgChannelsChannelType_A22241.UIValue = value;
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x0600011B RID: 283 RVA: 0x000165E0 File Offset: 0x000147E0
		public global::AcpBusinessLayer.AcpListField ZnChanCfgChannelsChannelType_A22241
		{
			get
			{
				short num = (short)2092249306;
				short num2 = num;
				num = (short)1645687002;
				switch (num2 == num)
				{
				}
				num = (short)1346568192;
				short num3 = num;
				num = (short)1776812033;
				if (num != 0)
				{
				}
				num = (short)1457258496;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsChannelType_A22241;
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x0600011C RID: 284 RVA: 0x00016690 File Offset: 0x00014890
		// (set) Token: 0x0600011D RID: 285 RVA: 0x00016744 File Offset: 0x00014944
		public bool ZnChanCfgChannelsChannelType_A22241_Applicable
		{
			get
			{
				short num = (short)1937559897;
				short num2 = num;
				num = (short)1061015897;
				switch (num2 == num)
				{
				}
				num = (short)5963776;
				short num3 = num;
				num = (short)1035927552;
				if (num != 0)
				{
				}
				num = (short)1247674369;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsChannelType_A22241.Applicable;
			}
			set
			{
				short num = (short)1228132969;
				short num2 = num;
				num = (short)1050661481;
				switch (num2 == num)
				{
				}
				num = (short)879296512;
				short num3 = num;
				num = (short)262406145;
				if (num != 0)
				{
				}
				num = (short)439812096;
				if (num != 0)
				{
				}
				this.znChanCfgChannelsChannelType_A22241.Applicable = value;
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x0600011E RID: 286 RVA: 0x000167FC File Offset: 0x000149FC
		// (set) Token: 0x0600011F RID: 287 RVA: 0x000168B0 File Offset: 0x00014AB0
		public bool ZnChanCfgChannelsChannelType_A22241_Valid
		{
			get
			{
				short num = (short)893404628;
				short num2 = num;
				num = (short)586106324;
				switch (num2 == num)
				{
				}
				num = (short)1602027520;
				short num3 = num;
				num = (short)1450835969;
				if (num != 0)
				{
				}
				num = (short)1582563328;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsChannelType_A22241.Valid;
			}
			set
			{
				short num = (short)784500928;
				short num2 = num;
				num = (short)1182828736;
				switch (num2 == num)
				{
				}
				num = (short)726794240;
				short num3 = num;
				num = (short)338165761;
				if (num != 0)
				{
				}
				num = (short)1965490176;
				if (num != 0)
				{
				}
				this.znChanCfgChannelsChannelType_A22241.Valid = value;
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000120 RID: 288 RVA: 0x00016964 File Offset: 0x00014B64
		// (set) Token: 0x06000121 RID: 289 RVA: 0x00016A18 File Offset: 0x00014C18
		public bool ZnChanCfgChannelsChannelType_A22241_Visible
		{
			get
			{
				short num = (short)302030186;
				short num2 = num;
				num = (short)671456618;
				switch (num2 == num)
				{
				}
				num = (short)2102198272;
				short num3 = num;
				num = (short)1804075009;
				if (num != 0)
				{
				}
				num = (short)207159296;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsChannelType_A22241.Visible;
			}
			set
			{
				short num = (short)1506607435;
				short num2 = num;
				num = (short)1798570315;
				switch (num2 == num)
				{
				}
				num = (short)1068433408;
				short num3 = num;
				num = (short)2124742657;
				if (num != 0)
				{
				}
				num = (short)148307968;
				if (num != 0)
				{
				}
				this.znChanCfgChannelsChannelType_A22241.Visible = value;
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000122 RID: 290 RVA: 0x00016ACC File Offset: 0x00014CCC
		// (set) Token: 0x06000123 RID: 291 RVA: 0x00016B80 File Offset: 0x00014D80
		public bool ZnChanCfgChannelsChannelType_A22241_Editable
		{
			get
			{
				short num = (short)108674850;
				short num2 = num;
				num = (short)1511604002;
				switch (num2 == num)
				{
				}
				num = (short)790298624;
				short num3 = num;
				num = (short)404946944;
				if (num != 0)
				{
				}
				num = (short)123928577;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsChannelType_A22241.Editable;
			}
			set
			{
				short num = (short)838504740;
				short num2 = num;
				num = (short)715100452;
				switch (num2 == num)
				{
				}
				num = (short)105971712;
				short num3 = num;
				num = (short)38469632;
				if (num != 0)
				{
				}
				num = (short)959774721;
				if (num != 0)
				{
				}
				this.znChanCfgChannelsChannelType_A22241.Editable = value;
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000124 RID: 292 RVA: 0x00016C38 File Offset: 0x00014E38
		internal string ZnChanCfgChannelsChannelType_A22241_UILabel
		{
			get
			{
				short num = (short)765119537;
				short num2 = num;
				num = (short)1383058481;
				switch (num2 == num)
				{
				}
				num = (short)1450770432;
				short num3 = num;
				num = (short)548405249;
				if (num != 0)
				{
				}
				num = (short)462356480;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsChannelType_A22241.UIName;
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000125 RID: 293 RVA: 0x00016CEC File Offset: 0x00014EEC
		// (set) Token: 0x06000126 RID: 294 RVA: 0x00016DA4 File Offset: 0x00014FA4
		internal bool ZnChanCfgChannelsChannelType_A22241_HiddenStatic
		{
			get
			{
				short num = (short)1633864842;
				short num2 = num;
				num = (short)1943522442;
				switch (num2 == num)
				{
				}
				num = (short)1067974656;
				short num3 = num;
				num = (short)1991114753;
				if (num != 0)
				{
				}
				num = (short)1647640576;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsChannelType_A22241.HiddenStatic;
			}
			set
			{
				short num = (short)1607991296;
				short num2 = num;
				num = (short)1368990412;
				short num3 = num;
				num = (short)1504256716;
				switch (num3 == num)
				{
				}
				num = (short)1369112577;
				if (num != 0)
				{
				}
				num = (short)933232640;
				if (num != 0)
				{
				}
				this.znChanCfgChannelsChannelType_A22241.HiddenStatic = value;
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000127 RID: 295 RVA: 0x00016E58 File Offset: 0x00015058
		// (set) Token: 0x06000128 RID: 296 RVA: 0x00016F0C File Offset: 0x0001510C
		internal bool ZnChanCfgChannelsChannelType_A22241_HiddenDynamic
		{
			get
			{
				short num = (short)1902313472;
				short num2 = num;
				num = (short)787511585;
				short num3 = num;
				num = (short)2107603233;
				switch (num3 == num)
				{
				}
				num = (short)1364131840;
				if (num != 0)
				{
				}
				num = (short)271581185;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsChannelType_A22241.HiddenDynamic;
			}
			set
			{
				short num = (short)2023686144;
				short num2 = num;
				num = (short)1069980216;
				short num3 = num;
				num = (short)663788088;
				switch (num3 == num)
				{
				}
				num = (short)119668736;
				if (num != 0)
				{
				}
				num = (short)884342785;
				if (num != 0)
				{
				}
				this.znChanCfgChannelsChannelType_A22241.HiddenDynamic = value;
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000129 RID: 297 RVA: 0x00016FC0 File Offset: 0x000151C0
		public bool ZnChanCfgChannelsChannelType_A22241_HasDiffs
		{
			get
			{
				short num = (short)1349386240;
				short num2 = num;
				num = (short)1828787885;
				short num3 = num;
				num = (short)424941229;
				switch (num3 == num)
				{
				}
				num = (short)677969921;
				if (num != 0)
				{
				}
				num = (short)1407385600;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsChannelType_A22241._HasDiffs;
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x0600012A RID: 298 RVA: 0x00017070 File Offset: 0x00015270
		// (set) Token: 0x0600012B RID: 299 RVA: 0x00017124 File Offset: 0x00015324
		public int ZnChanCfgTopLightColor_A43173Value
		{
			get
			{
				short num = (short)2128740352;
				short num2 = num;
				num = (short)711227072;
				short num3 = num;
				num = (short)1363637952;
				switch (num3 == num)
				{
				}
				num = (short)1935212545;
				if (num != 0)
				{
				}
				num = (short)605487104;
				if (num != 0)
				{
				}
				return this.znChanCfgTopLightColor_A43173.Value;
			}
			set
			{
				short num = (short)176750592;
				short num2 = num;
				num = (short)184410893;
				short num3 = num;
				num = (short)341173005;
				switch (num3 == num)
				{
				}
				num = (short)1279983617;
				if (num != 0)
				{
				}
				num = (short)1915879424;
				if (num != 0)
				{
				}
				this.znChanCfgTopLightColor_A43173.Value = value;
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x0600012C RID: 300 RVA: 0x000171D8 File Offset: 0x000153D8
		// (set) Token: 0x0600012D RID: 301 RVA: 0x00017290 File Offset: 0x00015490
		public string ZnChanCfgTopLightColor_A43173_UIValue
		{
			get
			{
				short num = (short)1182334976;
				short num2 = num;
				num = (short)1355810542;
				short num3 = num;
				num = (short)553584366;
				switch (num3 == num)
				{
				}
				num = (short)1629880321;
				if (num != 0)
				{
				}
				num = (short)987430912;
				if (num != 0)
				{
				}
				return this.znChanCfgTopLightColor_A43173.UIValue;
			}
			set
			{
				short num = (short)1560608768;
				short num2 = num;
				num = (short)940156415;
				short num3 = num;
				num = (short)1545446911;
				switch (num3 == num)
				{
				}
				num = (short)1552154625;
				if (num != 0)
				{
				}
				num = (short)561446912;
				if (num != 0)
				{
				}
				this.znChanCfgTopLightColor_A43173.UIValue = value;
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x0600012E RID: 302 RVA: 0x00017348 File Offset: 0x00015548
		public global::AcpBusinessLayer.AcpListField ZnChanCfgTopLightColor_A43173
		{
			get
			{
				short num = (short)567345152;
				short num2 = num;
				num = (short)1059997695;
				short num3 = num;
				num = (short)371869695;
				switch (num3 == num)
				{
				}
				num = (short)1492254720;
				if (num != 0)
				{
				}
				num = (short)186777601;
				if (num != 0)
				{
				}
				return this.znChanCfgTopLightColor_A43173;
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x0600012F RID: 303 RVA: 0x000173F8 File Offset: 0x000155F8
		// (set) Token: 0x06000130 RID: 304 RVA: 0x000174AC File Offset: 0x000156AC
		public bool ZnChanCfgTopLightColor_A43173_Applicable
		{
			get
			{
				short num = (short)1836908544;
				short num2 = num;
				num = (short)1443889153;
				if (num != 0)
				{
				}
				num = (short)1204657315;
				short num3 = num;
				num = (short)1711119523;
				switch (num3 == num)
				{
				}
				num = (short)1688862720;
				if (num != 0)
				{
				}
				return this.znChanCfgTopLightColor_A43173.Applicable;
			}
			set
			{
				short num = (short)1703608320;
				short num2 = num;
				num = (short)414445627;
				short num3 = num;
				num = (short)1563095099;
				switch (num3 == num)
				{
				}
				num = (short)1630928897;
				if (num != 0)
				{
				}
				num = (short)1360658432;
				if (num != 0)
				{
				}
				this.znChanCfgTopLightColor_A43173.Applicable = value;
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000131 RID: 305 RVA: 0x00017560 File Offset: 0x00015760
		// (set) Token: 0x06000132 RID: 306 RVA: 0x00017618 File Offset: 0x00015818
		public bool ZnChanCfgTopLightColor_A43173_Valid
		{
			get
			{
				short num = (short)1506082816;
				short num2 = num;
				num = (short)1933836289;
				if (num != 0)
				{
				}
				num = (short)1590757051;
				short num3 = num;
				num = (short)1920272059;
				switch (num3 == num)
				{
				}
				num = (short)115867648;
				if (num != 0)
				{
				}
				return this.znChanCfgTopLightColor_A43173.Valid;
			}
			set
			{
				short num = (short)634322944;
				short num2 = num;
				num = (short)1370128820;
				short num3 = num;
				num = (short)1207665076;
				switch (num3 == num)
				{
				}
				num = (short)61997057;
				if (num != 0)
				{
				}
				num = (short)22216704;
				if (num != 0)
				{
				}
				this.znChanCfgTopLightColor_A43173.Valid = value;
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000133 RID: 307 RVA: 0x000176D0 File Offset: 0x000158D0
		// (set) Token: 0x06000134 RID: 308 RVA: 0x00017784 File Offset: 0x00015984
		public bool ZnChanCfgTopLightColor_A43173_Visible
		{
			get
			{
				short num = (short)908263424;
				short num2 = num;
				num = (short)704104978;
				short num3 = num;
				num = (short)1460718098;
				switch (num3 == num)
				{
				}
				num = (short)37027841;
				if (num != 0)
				{
				}
				num = (short)865599488;
				if (num != 0)
				{
				}
				return this.znChanCfgTopLightColor_A43173.Visible;
			}
			set
			{
				short num = (short)1537736704;
				short num2 = num;
				num = (short)1923131002;
				short num3 = num;
				num = (short)1756997242;
				switch (num3 == num)
				{
				}
				num = (short)1141702657;
				if (num != 0)
				{
				}
				num = (short)648282112;
				if (num != 0)
				{
				}
				this.znChanCfgTopLightColor_A43173.Visible = value;
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000135 RID: 309 RVA: 0x0001783C File Offset: 0x00015A3C
		// (set) Token: 0x06000136 RID: 310 RVA: 0x000178F0 File Offset: 0x00015AF0
		public bool ZnChanCfgTopLightColor_A43173_Editable
		{
			get
			{
				short num = (short)1873543168;
				short num2 = num;
				num = (short)1702192663;
				short num3 = num;
				num = (short)1905288727;
				switch (num3 == num)
				{
				}
				num = (short)1379598336;
				if (num != 0)
				{
				}
				num = (short)1441793;
				if (num != 0)
				{
				}
				return this.znChanCfgTopLightColor_A43173.Editable;
			}
			set
			{
				short num = (short)447741952;
				short num2 = num;
				num = (short)1208436356;
				short num3 = num;
				num = (short)21513860;
				switch (num3 == num)
				{
				}
				num = (short)1920794625;
				if (num != 0)
				{
				}
				num = (short)977993728;
				if (num != 0)
				{
				}
				this.znChanCfgTopLightColor_A43173.Editable = value;
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000137 RID: 311 RVA: 0x000179A4 File Offset: 0x00015BA4
		internal string ZnChanCfgTopLightColor_A43173_UILabel
		{
			get
			{
				short num = (short)1725497344;
				short num2 = num;
				num = (short)1663618070;
				short num3 = num;
				num = (short)2050608150;
				switch (num3 == num)
				{
				}
				num = (short)1922433025;
				if (num != 0)
				{
				}
				num = (short)1773862912;
				if (num != 0)
				{
				}
				return this.znChanCfgTopLightColor_A43173.UIName;
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000138 RID: 312 RVA: 0x00017A58 File Offset: 0x00015C58
		// (set) Token: 0x06000139 RID: 313 RVA: 0x00017B0C File Offset: 0x00015D0C
		internal bool ZnChanCfgTopLightColor_A43173_HiddenStatic
		{
			get
			{
				short num = (short)2082078720;
				short num2 = num;
				num = (short)2064894610;
				short num3 = num;
				num = (short)861981330;
				switch (num3 == num)
				{
				}
				num = (short)1645412352;
				if (num != 0)
				{
				}
				num = (short)1952120833;
				if (num != 0)
				{
				}
				return this.znChanCfgTopLightColor_A43173.HiddenStatic;
			}
			set
			{
				short num = (short)373030912;
				short num2 = num;
				num = (short)618278079;
				short num3 = num;
				num = (short)1153445055;
				switch (num3 == num)
				{
				}
				num = (short)890437633;
				if (num != 0)
				{
				}
				num = (short)1101725696;
				if (num != 0)
				{
				}
				this.znChanCfgTopLightColor_A43173.HiddenStatic = value;
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x0600013A RID: 314 RVA: 0x00017BC0 File Offset: 0x00015DC0
		// (set) Token: 0x0600013B RID: 315 RVA: 0x00017C74 File Offset: 0x00015E74
		internal bool ZnChanCfgTopLightColor_A43173_HiddenDynamic
		{
			get
			{
				short num = (short)838580700;
				short num2 = num;
				num = (short)2140781020;
				switch (num2 == num)
				{
				}
				num = (short)895025153;
				if (num != 0)
				{
				}
				num = (short)1327628288;
				short num3 = num;
				num = (short)185204736;
				if (num != 0)
				{
				}
				return this.znChanCfgTopLightColor_A43173.HiddenDynamic;
			}
			set
			{
				short num = (short)445537825;
				short num2 = num;
				num = (short)924409377;
				switch (num2 == num)
				{
				}
				num = (short)66060289;
				if (num != 0)
				{
				}
				num = (short)462487552;
				short num3 = num;
				num = (short)46858240;
				if (num != 0)
				{
				}
				this.znChanCfgTopLightColor_A43173.HiddenDynamic = value;
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x0600013C RID: 316 RVA: 0x00017D28 File Offset: 0x00015F28
		public bool ZnChanCfgTopLightColor_A43173_HasDiffs
		{
			get
			{
				short num = (short)772603905;
				if (num != 0)
				{
				}
				num = (short)544104239;
				short num2 = num;
				num = (short)577527599;
				switch (num2 == num)
				{
				}
				num = (short)139853824;
				short num3 = num;
				num = (short)352256000;
				if (num != 0)
				{
				}
				return this.znChanCfgTopLightColor_A43173._HasDiffs;
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x0600013D RID: 317 RVA: 0x00017DE0 File Offset: 0x00015FE0
		// (set) Token: 0x0600013E RID: 318 RVA: 0x00017E94 File Offset: 0x00016094
		public int ZnChanCfgChannelsChannelColorBacklightSelection_43749_Value
		{
			get
			{
				short num = (short)903603297;
				short num2 = num;
				num = (short)1199236193;
				switch (num2 == num)
				{
				}
				num = (short)825032705;
				if (num != 0)
				{
				}
				num = (short)1865613312;
				short num3 = num;
				num = (short)1551302656;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsChannelColorBacklightSelection_43749.Value;
			}
			set
			{
				short num = (short)1185647516;
				short num2 = num;
				num = (short)1409846172;
				switch (num2 == num)
				{
				}
				num = (short)631963649;
				if (num != 0)
				{
				}
				num = (short)686817280;
				short num3 = num;
				num = (short)1636433920;
				if (num != 0)
				{
				}
				this.znChanCfgChannelsChannelColorBacklightSelection_43749.Value = value;
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x0600013F RID: 319 RVA: 0x00017F4C File Offset: 0x0001614C
		// (set) Token: 0x06000140 RID: 320 RVA: 0x00018000 File Offset: 0x00016200
		public string ZnChanCfgChannelsChannelColorBacklightSelection_43749_UIValue
		{
			get
			{
				short num = (short)43101842;
				short num2 = num;
				num = (short)61648530;
				switch (num2 == num)
				{
				}
				num = (short)455081985;
				if (num != 0)
				{
				}
				num = (short)999161856;
				short num3 = num;
				num = (short)1333526528;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsChannelColorBacklightSelection_43749.UIValue;
			}
			set
			{
				short num = (short)1494442150;
				short num2 = num;
				num = (short)1500864678;
				switch (num2 == num)
				{
				}
				num = (short)111149057;
				if (num != 0)
				{
				}
				num = (short)1913978880;
				short num3 = num;
				num = (short)1919746048;
				if (num != 0)
				{
				}
				this.znChanCfgChannelsChannelColorBacklightSelection_43749.UIValue = value;
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000141 RID: 321 RVA: 0x000180B8 File Offset: 0x000162B8
		public global::AcpBusinessLayer.AcpListField ZnChanCfgChannelsChannelColorBacklightSelection_43749
		{
			get
			{
				short num = (short)1375348307;
				short num2 = num;
				num = (short)353248851;
				switch (num2 == num)
				{
				}
				num = (short)1326120961;
				if (num != 0)
				{
				}
				num = (short)1484914688;
				short num3 = num;
				num = (short)1328742400;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsChannelColorBacklightSelection_43749;
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000142 RID: 322 RVA: 0x00018168 File Offset: 0x00016368
		// (set) Token: 0x06000143 RID: 323 RVA: 0x0001821C File Offset: 0x0001641C
		public bool ZnChanCfgChannelsChannelColorBacklightSelection_43749_Applicable
		{
			get
			{
				short num = (short)748192590;
				short num2 = num;
				num = (short)739017550;
				switch (num2 == num)
				{
				}
				num = (short)1565982720;
				if (num != 0)
				{
				}
				num = (short)407961600;
				short num3 = num;
				num = (short)1025966081;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsChannelColorBacklightSelection_43749.Applicable;
			}
			set
			{
				short num = (short)203161601;
				if (num != 0)
				{
				}
				num = (short)1173579294;
				short num2 = num;
				num = (short)1669162526;
				switch (num2 == num)
				{
				}
				num = (short)1740046336;
				short num3 = num;
				num = (short)1917452288;
				if (num != 0)
				{
				}
				this.znChanCfgChannelsChannelColorBacklightSelection_43749.Applicable = value;
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000144 RID: 324 RVA: 0x000182D4 File Offset: 0x000164D4
		// (set) Token: 0x06000145 RID: 325 RVA: 0x00018388 File Offset: 0x00016588
		public bool ZnChanCfgChannelsChannelColorBacklightSelection_43749_Valid
		{
			get
			{
				short num = (short)511992845;
				short num2 = num;
				num = (short)291660813;
				switch (num2 == num)
				{
				}
				num = (short)13041665;
				if (num != 0)
				{
				}
				num = (short)758513664;
				short num3 = num;
				num = (short)893059072;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsChannelColorBacklightSelection_43749.Valid;
			}
			set
			{
				short num = (short)997361724;
				short num2 = num;
				num = (short)703170620;
				switch (num2 == num)
				{
				}
				num = (short)1056964609;
				if (num != 0)
				{
				}
				num = (short)1392640000;
				short num3 = num;
				num = (short)1968766976;
				if (num != 0)
				{
				}
				this.znChanCfgChannelsChannelColorBacklightSelection_43749.Valid = value;
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000146 RID: 326 RVA: 0x00018440 File Offset: 0x00016640
		// (set) Token: 0x06000147 RID: 327 RVA: 0x000184F4 File Offset: 0x000166F4
		public bool ZnChanCfgChannelsChannelColorBacklightSelection_43749_Visible
		{
			get
			{
				short num = (short)573726146;
				short num2 = num;
				num = (short)1958698434;
				switch (num2 == num)
				{
				}
				num = (short)1030422529;
				if (num != 0)
				{
				}
				num = (short)724762624;
				short num3 = num;
				num = (short)1372913664;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsChannelColorBacklightSelection_43749.Visible;
			}
			set
			{
				short num = (short)1690396492;
				short num2 = num;
				num = (short)2002216780;
				switch (num2 == num)
				{
				}
				num = (short)781975553;
				if (num != 0)
				{
				}
				num = (short)1220280320;
				short num3 = num;
				num = (short)137101312;
				if (num != 0)
				{
				}
				this.znChanCfgChannelsChannelColorBacklightSelection_43749.Visible = value;
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000148 RID: 328 RVA: 0x000185A8 File Offset: 0x000167A8
		// (set) Token: 0x06000149 RID: 329 RVA: 0x00018658 File Offset: 0x00016858
		public bool ZnChanCfgChannelsChannelColorBacklightSelection_43749_Editable
		{
			get
			{
				short num = (short)1964517388;
				short num2 = num;
				num = (short)753281036;
				switch (num2 == num)
				{
				}
				num = (short)893911041;
				if (num != 0)
				{
				}
				num = (short)1503657984;
				short num3 = num;
				num = (short)311361536;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsChannelColorBacklightSelection_43749.Editable;
			}
			set
			{
				short num = (short)1173131583;
				short num2 = num;
				num = (short)126587199;
				switch (num2 == num)
				{
				}
				num = (short)1595932672;
				if (num != 0)
				{
				}
				num = (short)1596719104;
				short num3 = num;
				num = (short)247398401;
				if (num != 0)
				{
				}
				this.znChanCfgChannelsChannelColorBacklightSelection_43749.Editable = value;
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x0600014A RID: 330 RVA: 0x00018710 File Offset: 0x00016910
		internal string ZnChanCfgChannelsChannelColorBacklightSelection_43749_UILabel
		{
			get
			{
				short num = (short)1013728392;
				short num2 = num;
				num = (short)661734536;
				switch (num2 == num)
				{
				}
				num = (short)40304641;
				if (num != 0)
				{
				}
				num = (short)86769664;
				short num3 = num;
				num = (short)1744109568;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsChannelColorBacklightSelection_43749.UIName;
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x0600014B RID: 331 RVA: 0x000187C4 File Offset: 0x000169C4
		// (set) Token: 0x0600014C RID: 332 RVA: 0x00018878 File Offset: 0x00016A78
		internal bool ZnChanCfgChannelsChannelColorBacklightSelection_43749_HiddenStatic
		{
			get
			{
				short num = (short)699990017;
				if (num != 0)
				{
				}
				num = (short)1198551961;
				short num2 = num;
				num = (short)1165587353;
				switch (num2 == num)
				{
				}
				num = (short)133038080;
				short num3 = num;
				num = (short)787546112;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsChannelColorBacklightSelection_43749.HiddenStatic;
			}
			set
			{
				short num = (short)1659671589;
				short num2 = num;
				num = (short)1418564645;
				switch (num2 == num)
				{
				}
				num = (short)857997312;
				if (num != 0)
				{
				}
				num = (short)1889665024;
				short num3 = num;
				num = (short)405536769;
				if (num != 0)
				{
				}
				this.znChanCfgChannelsChannelColorBacklightSelection_43749.HiddenStatic = value;
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x0600014D RID: 333 RVA: 0x00018930 File Offset: 0x00016B30
		// (set) Token: 0x0600014E RID: 334 RVA: 0x000189E4 File Offset: 0x00016BE4
		internal bool ZnChanCfgChannelsChannelColorBacklightSelection_43749_HiddenDynamic
		{
			get
			{
				short num = (short)1967179065;
				short num2 = num;
				num = (short)1637139769;
				switch (num2 == num)
				{
				}
				num = (short)578420737;
				if (num != 0)
				{
				}
				num = (short)1410990080;
				short num3 = num;
				num = (short)1618214912;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsChannelColorBacklightSelection_43749.HiddenDynamic;
			}
			set
			{
				short num = (short)2083198932;
				short num2 = num;
				num = (short)1275271124;
				switch (num2 == num)
				{
				}
				num = (short)1057947649;
				if (num != 0)
				{
				}
				num = (short)1671168000;
				short num3 = num;
				num = (short)542507008;
				if (num != 0)
				{
				}
				this.znChanCfgChannelsChannelColorBacklightSelection_43749.HiddenDynamic = value;
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x0600014F RID: 335 RVA: 0x00018A98 File Offset: 0x00016C98
		public bool ZnChanCfgChannelsChannelColorBacklightSelection_43749_HasDiffs
		{
			get
			{
				short num = (short)107147128;
				short num2 = num;
				num = (short)1522003832;
				switch (num2 == num)
				{
				}
				num = (short)1874132992;
				if (num != 0)
				{
				}
				num = (short)1279066112;
				short num3 = num;
				num = (short)1957036033;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsChannelColorBacklightSelection_43749._HasDiffs;
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x06000150 RID: 336 RVA: 0x00018B4C File Offset: 0x00016D4C
		// (set) Token: 0x06000151 RID: 337 RVA: 0x00018C00 File Offset: 0x00016E00
		public int ZnChanCfgChannelsFallbackZoneValue
		{
			get
			{
				short num = (short)1428043973;
				short num2 = num;
				num = (short)1634482373;
				switch (num2 == num)
				{
				}
				num = (short)1412431873;
				if (num != 0)
				{
				}
				num = (short)2132017152;
				short num3 = num;
				num = (short)501022720;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsFallbackZone.Value;
			}
			set
			{
				short num = (short)480376393;
				short num2 = num;
				num = (short)772929097;
				switch (num2 == num)
				{
				}
				num = (short)1634926593;
				if (num != 0)
				{
				}
				num = (short)1477050368;
				short num3 = num;
				num = (short)1804468224;
				if (num != 0)
				{
				}
				this.znChanCfgChannelsFallbackZone.Value = value;
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x06000152 RID: 338 RVA: 0x00018CB8 File Offset: 0x00016EB8
		// (set) Token: 0x06000153 RID: 339 RVA: 0x00018D68 File Offset: 0x00016F68
		public string ZnChanCfgChannelsFallbackZone_UIValue
		{
			get
			{
				short num = (short)1350582430;
				short num2 = num;
				num = (short)1319452830;
				switch (num2 == num)
				{
				}
				num = (short)1959723009;
				if (num != 0)
				{
				}
				num = (short)1015021568;
				short num3 = num;
				num = (short)1913520128;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsFallbackZone.UIValue;
			}
			set
			{
				short num = (short)1208928925;
				short num2 = num;
				num = (short)1823263389;
				switch (num2 == num)
				{
				}
				num = (short)771293185;
				if (num != 0)
				{
				}
				num = (short)63897600;
				short num3 = num;
				num = (short)952369152;
				if (num != 0)
				{
				}
				this.znChanCfgChannelsFallbackZone.UIValue = value;
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x06000154 RID: 340 RVA: 0x00018E1C File Offset: 0x0001701C
		public global::AcpBusinessLayer.AcpRecRefField ZnChanCfgChannelsFallbackZone
		{
			get
			{
				short num = (short)590368948;
				short num2 = num;
				num = (short)2029998260;
				switch (num2 == num)
				{
				}
				num = (short)355074049;
				if (num != 0)
				{
				}
				num = (short)1365573632;
				short num3 = num;
				num = (short)1756758016;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsFallbackZone;
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x06000155 RID: 341 RVA: 0x00018EC8 File Offset: 0x000170C8
		// (set) Token: 0x06000156 RID: 342 RVA: 0x00018F7C File Offset: 0x0001717C
		public bool ZnChanCfgChannelsFallbackZone_Applicable
		{
			get
			{
				short num = (short)2024635330;
				short num2 = num;
				num = (short)1042578370;
				switch (num2 == num)
				{
				}
				num = (short)1100218368;
				if (num != 0)
				{
				}
				num = (short)502530048;
				short num3 = num;
				num = (short)173473793;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsFallbackZone.Applicable;
			}
			set
			{
				short num = (short)1150804549;
				short num2 = num;
				num = (short)328786501;
				switch (num2 == num)
				{
				}
				num = (short)753991680;
				if (num != 0)
				{
				}
				num = (short)1106640896;
				short num3 = num;
				num = (short)1089208321;
				if (num != 0)
				{
				}
				this.znChanCfgChannelsFallbackZone.Applicable = value;
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x06000157 RID: 343 RVA: 0x00019034 File Offset: 0x00017234
		// (set) Token: 0x06000158 RID: 344 RVA: 0x000190E8 File Offset: 0x000172E8
		public bool ZnChanCfgChannelsFallbackZone_Valid
		{
			get
			{
				short num = (short)1363818322;
				short num2 = num;
				num = (short)400570194;
				switch (num2 == num)
				{
				}
				num = (short)2063204353;
				if (num != 0)
				{
				}
				num = (short)27852800;
				short num3 = num;
				num = (short)1745485824;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsFallbackZone.Valid;
			}
			set
			{
				short num = (short)1622719174;
				short num2 = num;
				num = (short)1440398022;
				switch (num2 == num)
				{
				}
				num = (short)795410432;
				if (num != 0)
				{
				}
				num = (short)1485766656;
				short num3 = num;
				num = (short)1679949825;
				if (num != 0)
				{
				}
				this.znChanCfgChannelsFallbackZone.Valid = value;
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x06000159 RID: 345 RVA: 0x0001919C File Offset: 0x0001739C
		// (set) Token: 0x0600015A RID: 346 RVA: 0x00019254 File Offset: 0x00017454
		public bool ZnChanCfgChannelsFallbackZone_Visible
		{
			get
			{
				short num = (short)1021539083;
				short num2 = num;
				num = (short)1356559115;
				switch (num2 == num)
				{
				}
				num = (short)149749761;
				if (num != 0)
				{
				}
				num = (short)357367808;
				short num3 = num;
				num = (short)1815412736;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsFallbackZone.Visible;
			}
			set
			{
				short num = (short)551419905;
				if (num != 0)
				{
				}
				num = (short)1763493521;
				short num2 = num;
				num = (short)1301923473;
				switch (num2 == num)
				{
				}
				num = (short)699727872;
				short num3 = num;
				num = (short)1966473216;
				if (num != 0)
				{
				}
				this.znChanCfgChannelsFallbackZone.Visible = value;
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x0600015B RID: 347 RVA: 0x0001930C File Offset: 0x0001750C
		// (set) Token: 0x0600015C RID: 348 RVA: 0x000193C0 File Offset: 0x000175C0
		public bool ZnChanCfgChannelsFallbackZone_Editable
		{
			get
			{
				short num = (short)1027645298;
				short num2 = num;
				num = (short)399482738;
				switch (num2 == num)
				{
				}
				num = (short)1274281985;
				if (num != 0)
				{
				}
				num = (short)774963200;
				short num3 = num;
				num = (short)1338310656;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsFallbackZone.Editable;
			}
			set
			{
				short num = (short)38867630;
				short num2 = num;
				num = (short)1399067310;
				switch (num2 == num)
				{
				}
				num = (short)1973747713;
				if (num != 0)
				{
				}
				num = (short)1509687296;
				short num3 = num;
				num = (short)1699282944;
				if (num != 0)
				{
				}
				this.znChanCfgChannelsFallbackZone.Editable = value;
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x0600015D RID: 349 RVA: 0x00019478 File Offset: 0x00017678
		internal string ZnChanCfgChannelsFallbackZone_UILabel
		{
			get
			{
				short num = (short)626902186;
				short num2 = num;
				num = (short)302433450;
				switch (num2 == num)
				{
				}
				num = (short)2111569921;
				if (num != 0)
				{
				}
				num = (short)1658388480;
				short num3 = num;
				num = (short)573571072;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsFallbackZone.UIName;
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x0600015E RID: 350 RVA: 0x00019528 File Offset: 0x00017728
		// (set) Token: 0x0600015F RID: 351 RVA: 0x000195E0 File Offset: 0x000177E0
		internal bool ZnChanCfgChannelsFallbackZone_HiddenStatic
		{
			get
			{
				short num = (short)320412146;
				short num2 = num;
				num = (short)628300274;
				switch (num2 == num)
				{
				}
				num = (short)1357971456;
				if (num != 0)
				{
				}
				num = (short)598540288;
				short num3 = num;
				num = (short)1254752257;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsFallbackZone.HiddenStatic;
			}
			set
			{
				short num = (short)805221846;
				short num2 = num;
				num = (short)1238808022;
				switch (num2 == num)
				{
				}
				num = (short)1470693376;
				if (num != 0)
				{
				}
				num = (short)430505984;
				short num3 = num;
				num = (short)589103105;
				if (num != 0)
				{
				}
				this.znChanCfgChannelsFallbackZone.HiddenStatic = value;
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000160 RID: 352 RVA: 0x00019698 File Offset: 0x00017898
		// (set) Token: 0x06000161 RID: 353 RVA: 0x0001974C File Offset: 0x0001794C
		internal bool ZnChanCfgChannelsFallbackZone_HiddenDynamic
		{
			get
			{
				short num = (short)2076770305;
				if (num != 0)
				{
				}
				num = (short)1207995153;
				short num2 = num;
				num = (short)1148685073;
				switch (num2 == num)
				{
				}
				num = (short)530120704;
				short num3 = num;
				num = (short)2124218368;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsFallbackZone.HiddenDynamic;
			}
			set
			{
				short num = (short)230082605;
				short num2 = num;
				num = (short)1206372397;
				switch (num2 == num)
				{
				}
				num = (short)219021312;
				if (num != 0)
				{
				}
				num = (short)318701568;
				short num3 = num;
				num = (short)1105395713;
				if (num != 0)
				{
				}
				this.znChanCfgChannelsFallbackZone.HiddenDynamic = value;
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x06000162 RID: 354 RVA: 0x00019800 File Offset: 0x00017A00
		public bool ZnChanCfgChannelsFallbackZone_HasDiffs
		{
			get
			{
				short num = (short)1354104833;
				if (num != 0)
				{
				}
				num = (short)299467367;
				short num2 = num;
				num = (short)1732870759;
				switch (num2 == num)
				{
				}
				num = (short)1845428224;
				short num3 = num;
				num = (short)238354432;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsFallbackZone._HasDiffs;
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x06000163 RID: 355 RVA: 0x000198B4 File Offset: 0x00017AB4
		// (set) Token: 0x06000164 RID: 356 RVA: 0x00019968 File Offset: 0x00017B68
		public int ZnChanCfgChannelsFallbackChannelValue
		{
			get
			{
				short num = (short)1664409754;
				short num2 = num;
				num = (short)7725210;
				switch (num2 == num)
				{
				}
				num = (short)208863233;
				if (num != 0)
				{
				}
				num = (short)1100152832;
				short num3 = num;
				num = (short)713949184;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsFallbackChannel.Value;
			}
			set
			{
				short num = (short)292233905;
				short num2 = num;
				num = (short)924852913;
				switch (num2 == num)
				{
				}
				num = (short)57016321;
				if (num != 0)
				{
				}
				num = (short)726532096;
				short num3 = num;
				num = (short)1361379328;
				if (num != 0)
				{
				}
				this.znChanCfgChannelsFallbackChannel.Value = value;
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x06000165 RID: 357 RVA: 0x00019A24 File Offset: 0x00017C24
		// (set) Token: 0x06000166 RID: 358 RVA: 0x00019ADC File Offset: 0x00017CDC
		public string ZnChanCfgChannelsFallbackChannel_UIValue
		{
			get
			{
				short num = (short)852156896;
				short num2 = num;
				num = (short)1216602592;
				switch (num2 == num)
				{
				}
				num = (short)1277952000;
				if (num != 0)
				{
				}
				num = (short)37093376;
				short num3 = num;
				num = (short)641138689;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsFallbackChannel.UIValue;
			}
			set
			{
				short num = (short)913324182;
				short num2 = num;
				num = (short)841365654;
				switch (num2 == num)
				{
				}
				num = (short)1818820608;
				if (num != 0)
				{
				}
				num = (short)1374748672;
				short num3 = num;
				num = (short)131465217;
				if (num != 0)
				{
				}
				this.znChanCfgChannelsFallbackChannel.UIValue = value;
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x06000167 RID: 359 RVA: 0x00019B94 File Offset: 0x00017D94
		public global::AcpBusinessLayer.AcpRecRefField ZnChanCfgChannelsFallbackChannel
		{
			get
			{
				short num = (short)1820944382;
				short num2 = num;
				num = (short)1117415422;
				switch (num2 == num)
				{
				}
				num = (short)636223489;
				if (num != 0)
				{
				}
				num = (short)658964480;
				short num3 = num;
				num = (short)198574080;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsFallbackChannel;
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x06000168 RID: 360 RVA: 0x00019C44 File Offset: 0x00017E44
		// (set) Token: 0x06000169 RID: 361 RVA: 0x00019CF8 File Offset: 0x00017EF8
		public bool ZnChanCfgChannelsFallbackChannel_Applicable
		{
			get
			{
				short num = (short)996059384;
				short num2 = num;
				num = (short)115845368;
				switch (num2 == num)
				{
				}
				num = (short)1428291585;
				if (num != 0)
				{
				}
				num = (short)1102249984;
				short num3 = num;
				num = (short)1910964224;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsFallbackChannel.Applicable;
			}
			set
			{
				short num = (short)949820008;
				short num2 = num;
				num = (short)30743144;
				switch (num2 == num)
				{
				}
				num = (short)885522433;
				if (num != 0)
				{
				}
				num = (short)700973056;
				short num3 = num;
				num = (short)98304000;
				if (num != 0)
				{
				}
				this.znChanCfgChannelsFallbackChannel.Applicable = value;
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x0600016A RID: 362 RVA: 0x00019DB0 File Offset: 0x00017FB0
		// (set) Token: 0x0600016B RID: 363 RVA: 0x00019E68 File Offset: 0x00018068
		public bool ZnChanCfgChannelsFallbackChannel_Valid
		{
			get
			{
				short num = (short)1923654150;
				short num2 = num;
				num = (short)1331012102;
				switch (num2 == num)
				{
				}
				num = (short)340656129;
				if (num != 0)
				{
				}
				num = (short)1470562304;
				short num3 = num;
				num = (short)1459159040;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsFallbackChannel.Valid;
			}
			set
			{
				short num = (short)1398674747;
				short num2 = num;
				num = (short)1960711483;
				switch (num2 == num)
				{
				}
				num = (short)1063845888;
				if (num != 0)
				{
				}
				num = (short)2000355328;
				short num3 = num;
				num = (short)1411579905;
				if (num != 0)
				{
				}
				this.znChanCfgChannelsFallbackChannel.Valid = value;
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x0600016C RID: 364 RVA: 0x00019F20 File Offset: 0x00018120
		// (set) Token: 0x0600016D RID: 365 RVA: 0x00019FD4 File Offset: 0x000181D4
		public bool ZnChanCfgChannelsFallbackChannel_Visible
		{
			get
			{
				short num = (short)1155998095;
				short num2 = num;
				num = (short)972366223;
				switch (num2 == num)
				{
				}
				num = (short)1617428481;
				if (num != 0)
				{
				}
				num = (short)1863122944;
				short num3 = num;
				num = (short)647888896;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsFallbackChannel.Visible;
			}
			set
			{
				short num = (short)329437930;
				short num2 = num;
				num = (short)1316934378;
				switch (num2 == num)
				{
				}
				num = (short)802553857;
				if (num != 0)
				{
				}
				num = (short)85655552;
				short num3 = num;
				num = (short)1690566656;
				if (num != 0)
				{
				}
				this.znChanCfgChannelsFallbackChannel.Visible = value;
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x0600016E RID: 366 RVA: 0x0001A08C File Offset: 0x0001828C
		// (set) Token: 0x0600016F RID: 367 RVA: 0x0001A144 File Offset: 0x00018344
		public bool ZnChanCfgChannelsFallbackChannel_Editable
		{
			get
			{
				short num = (short)195704816;
				short num2 = num;
				num = (short)1110915056;
				switch (num2 == num)
				{
				}
				num = (short)2103181313;
				if (num != 0)
				{
				}
				num = (short)1830158336;
				short num3 = num;
				num = (short)976158720;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsFallbackChannel.Editable;
			}
			set
			{
				short num = (short)1110181209;
				short num2 = num;
				num = (short)1236338009;
				switch (num2 == num)
				{
				}
				num = (short)341377025;
				if (num != 0)
				{
				}
				num = (short)70647808;
				short num3 = num;
				num = (short)845021184;
				if (num != 0)
				{
				}
				this.znChanCfgChannelsFallbackChannel.Editable = value;
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x06000170 RID: 368 RVA: 0x0001A1F8 File Offset: 0x000183F8
		internal string ZnChanCfgChannelsFallbackChannel_UILabel
		{
			get
			{
				short num = (short)217847018;
				short num2 = num;
				num = (short)738923754;
				switch (num2 == num)
				{
				}
				num = (short)934805504;
				if (num != 0)
				{
				}
				num = (short)1915682816;
				short num3 = num;
				num = (short)797704193;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsFallbackChannel.UIName;
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x06000171 RID: 369 RVA: 0x0001A2B0 File Offset: 0x000184B0
		// (set) Token: 0x06000172 RID: 370 RVA: 0x0001A368 File Offset: 0x00018568
		internal bool ZnChanCfgChannelsFallbackChannel_HiddenStatic
		{
			get
			{
				short num = (short)290048611;
				short num2 = num;
				num = (short)1439156835;
				switch (num2 == num)
				{
				}
				num = (short)1186332672;
				if (num != 0)
				{
				}
				num = (short)1220280320;
				short num3 = num;
				num = (short)988545025;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsFallbackChannel.HiddenStatic;
			}
			set
			{
				short num = (short)1391076700;
				short num2 = num;
				num = (short)425469276;
				switch (num2 == num)
				{
				}
				num = (short)853868544;
				if (num != 0)
				{
				}
				num = (short)415039488;
				short num3 = num;
				num = (short)296615937;
				if (num != 0)
				{
				}
				this.znChanCfgChannelsFallbackChannel.HiddenStatic = value;
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x06000173 RID: 371 RVA: 0x0001A420 File Offset: 0x00018620
		// (set) Token: 0x06000174 RID: 372 RVA: 0x0001A4D8 File Offset: 0x000186D8
		internal bool ZnChanCfgChannelsFallbackChannel_HiddenDynamic
		{
			get
			{
				short num = (short)1481861349;
				short num2 = num;
				num = (short)1268279525;
				switch (num2 == num)
				{
				}
				num = (short)843382784;
				if (num != 0)
				{
				}
				num = (short)1681457152;
				short num3 = num;
				num = (short)1471807489;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsFallbackChannel.HiddenDynamic;
			}
			set
			{
				short num = (short)648979394;
				short num2 = num;
				num = (short)1380819906;
				switch (num2 == num)
				{
				}
				num = (short)272105473;
				if (num != 0)
				{
				}
				num = (short)1049952256;
				short num3 = num;
				num = (short)918618112;
				if (num != 0)
				{
				}
				this.znChanCfgChannelsFallbackChannel.HiddenDynamic = value;
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x06000175 RID: 373 RVA: 0x0001A58C File Offset: 0x0001878C
		public bool ZnChanCfgChannelsFallbackChannel_HasDiffs
		{
			get
			{
				short num = (short)1573241086;
				short num2 = num;
				num = (short)381796606;
				switch (num2 == num)
				{
				}
				num = (short)1635713025;
				if (num != 0)
				{
				}
				num = (short)1069875200;
				short num3 = num;
				num = (short)26542080;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsFallbackChannel._HasDiffs;
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x06000176 RID: 374 RVA: 0x0001A640 File Offset: 0x00018840
		// (set) Token: 0x06000177 RID: 375 RVA: 0x0001A6F4 File Offset: 0x000188F4
		public int ZnChanCfgChannelsWiFiValue
		{
			get
			{
				short num = (short)1138122205;
				short num2 = num;
				num = (short)1140809181;
				switch (num2 == num)
				{
				}
				num = (short)1347223553;
				if (num != 0)
				{
				}
				num = (short)1110048768;
				short num3 = num;
				num = (short)868417536;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsWiFi.Value;
			}
			set
			{
				short num = (short)969401572;
				short num2 = num;
				num = (short)467133668;
				switch (num2 == num)
				{
				}
				num = (short)285736961;
				if (num != 0)
				{
				}
				num = (short)1012137984;
				short num3 = num;
				num = (short)442761216;
				if (num != 0)
				{
				}
				this.znChanCfgChannelsWiFi.Value = value;
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x06000178 RID: 376 RVA: 0x0001A7AC File Offset: 0x000189AC
		// (set) Token: 0x06000179 RID: 377 RVA: 0x0001A864 File Offset: 0x00018A64
		public string ZnChanCfgChannelsWiFi_UIValue
		{
			get
			{
				short num = (short)24724493;
				short num2 = num;
				num = (short)714818573;
				switch (num2 == num)
				{
				}
				num = (short)687472640;
				if (num != 0)
				{
				}
				num = (short)1607729152;
				short num3 = num;
				num = (short)1267793921;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsWiFi.UIValue;
			}
			set
			{
				short num = (short)130960380;
				short num2 = num;
				num = (short)1841974268;
				switch (num2 == num)
				{
				}
				num = (short)2008547329;
				if (num != 0)
				{
				}
				num = (short)1192951808;
				short num3 = num;
				num = (short)1707933696;
				if (num != 0)
				{
				}
				this.znChanCfgChannelsWiFi.UIValue = value;
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x0600017A RID: 378 RVA: 0x0001A918 File Offset: 0x00018B18
		public global::AcpBusinessLayer.AcpListField ZnChanCfgChannelsWiFi
		{
			get
			{
				short num = (short)1622278145;
				if (num != 0)
				{
				}
				num = (short)770026328;
				short num2 = num;
				num = (short)1724296024;
				switch (num2 == num)
				{
				}
				num = (short)514654208;
				short num3 = num;
				num = (short)1305214976;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsWiFi;
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x0600017B RID: 379 RVA: 0x0001A9C4 File Offset: 0x00018BC4
		// (set) Token: 0x0600017C RID: 380 RVA: 0x0001AA74 File Offset: 0x00018C74
		public bool ZnChanCfgChannelsWiFi_Applicable
		{
			get
			{
				short num = (short)972812545;
				short num2 = num;
				num = (short)1501229313;
				switch (num2 == num)
				{
				}
				num = (short)924057600;
				if (num != 0)
				{
				}
				num = (short)1798111232;
				short num3 = num;
				num = (short)100794369;
				if (num != 0)
				{
				}
				return this.znChanCfgChannelsWiFi.Applicable;
			}
			set
			{
				short num = (short)438288811;
				short num2 = num;
				num = (short)24756651;
				switch (num2 == num)
				{
				}
				num = (short)899481601;
				if (num != 0)
				{
				}
				num = (short)503578624;
				if (num != 0)
				{
				}
				num = (short)1149894656;
				short num3 = num;
				this.znChanCfgChannelsWiFi.Applicable = value;
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x0600017D RID: 381 RVA: 0x0001AB2C File Offset: 0x00018D2C
		// (set) Token: 0x0600017E RID: 382 RVA: 0x0001ABE0 File Offset: 0x00018DE0
		public bool ZnChanCfgChannelsWiFi_Valid
		{
			get
			{
				short num = (short)812826192;
				short num2 = num;
				num = (short)412991056;
				switch (num2 == num)
				{
				}
				num = (short)2035023873;
				if (num != 0)
				{
				}
				num = (short)685309952;
				if (num != 0)
				{
				}
				num = (short)1935605760;
				short num3 = num;
				return this.znChanCfgChannelsWiFi.Valid;
			}
			set
			{
				short num = (short)682972317;
				short num2 = num;
				num = (short)890983581;
				switch (num2 == num)
				{
				}
				num = (short)2009202688;
				if (num != 0)
				{
				}
				num = (short)1903886337;
				if (num != 0)
				{
				}
				num = (short)1587347456;
				short num3 = num;
				this.znChanCfgChannelsWiFi.Valid = value;
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x0600017F RID: 383 RVA: 0x0001AC94 File Offset: 0x00018E94
		// (set) Token: 0x06000180 RID: 384 RVA: 0x0001AD48 File Offset: 0x00018F48
		public bool ZnChanCfgChannelsWiFi_Visible
		{
			get
			{
				short num = (short)1727357793;
				short num2 = num;
				num = (short)975528801;
				switch (num2 == num)
				{
				}
				num = (short)508166144;
				if (num != 0)
				{
				}
				num = (short)1639186433;
				if (num != 0)
				{
				}
				num = (short)776273920;
				short num3 = num;
				return this.znChanCfgChannelsWiFi.Visible;
			}
			set
			{
				short num = (short)2078766925;
				short num2 = num;
				num = (short)1613789005;
				switch (num2 == num)
				{
				}
				num = (short)1180565504;
				if (num != 0)
				{
				}
				num = (short)619249665;
				if (num != 0)
				{
				}
				num = (short)1139212288;
				short num3 = num;
				this.znChanCfgChannelsWiFi.Visible = value;
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x06000181 RID: 385 RVA: 0x0001AE00 File Offset: 0x00019000
		// (set) Token: 0x06000182 RID: 386 RVA: 0x0001AEB4 File Offset: 0x000190B4
		public bool ZnChanCfgChannelsWiFi_Editable
		{
			get
			{
				short num = (short)872844977;
				short num2 = num;
				num = (short)472092337;
				switch (num2 == num)
				{
				}
				num = (short)1691746305;
				if (num != 0)
				{
				}
				num = (short)2037186560;
				if (num != 0)
				{
				}
				num = (short)1988624384;
				short num3 = num;
				return this.znChanCfgChannelsWiFi.Editable;
			}
			set
			{
				short num = (short)2139482248;
				short num2 = num;
				num = (short)1800988808;
				switch (num2 == num)
				{
				}
				num = (short)1635188736;
				if (num != 0)
				{
				}
				num = (short)1551433729;
				if (num != 0)
				{
				}
				num = (short)781778944;
				short num3 = num;
				this.znChanCfgChannelsWiFi.Editable = value;
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x06000183 RID: 387 RVA: 0x0001AF68 File Offset: 0x00019168
		internal string ZnChanCfgChannelsWiFi_UILabel
		{
			get
			{
				short num = (short)934608897;
				if (num != 0)
				{
				}
				num = (short)1596771319;
				short num2 = num;
				num = (short)494980087;
				switch (num2 == num)
				{
				}
				num = (short)1206321152;
				if (num != 0)
				{
				}
				num = (short)52363264;
				short num3 = num;
				return this.znChanCfgChannelsWiFi.UIName;
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000184 RID: 388 RVA: 0x0001B018 File Offset: 0x00019218
		// (set) Token: 0x06000185 RID: 389 RVA: 0x0001B0D0 File Offset: 0x000192D0
		internal bool ZnChanCfgChannelsWiFi_HiddenStatic
		{
			get
			{
				short num = (short)189333505;
				if (num != 0)
				{
				}
				num = (short)798573266;
				short num2 = num;
				num = (short)685064914;
				switch (num2 == num)
				{
				}
				num = (short)1482752000;
				if (num != 0)
				{
				}
				num = (short)1561526272;
				short num3 = num;
				return this.znChanCfgChannelsWiFi.HiddenStatic;
			}
			set
			{
				short num = (short)863633409;
				if (num != 0)
				{
				}
				num = (short)626341690;
				short num2 = num;
				num = (short)1290483514;
				switch (num2 == num)
				{
				}
				num = (short)819003392;
				if (num != 0)
				{
				}
				num = (short)1645150208;
				short num3 = num;
				this.znChanCfgChannelsWiFi.HiddenStatic = value;
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000186 RID: 390 RVA: 0x0001B184 File Offset: 0x00019384
		// (set) Token: 0x06000187 RID: 391 RVA: 0x0001B238 File Offset: 0x00019438
		internal bool ZnChanCfgChannelsWiFi_HiddenDynamic
		{
			get
			{
				short num = (short)1112604673;
				if (num != 0)
				{
				}
				num = (short)931843271;
				short num2 = num;
				num = (short)1531628743;
				switch (num2 == num)
				{
				}
				num = (short)575799296;
				if (num != 0)
				{
				}
				num = (short)1947729920;
				short num3 = num;
				return this.znChanCfgChannelsWiFi.HiddenDynamic;
			}
			set
			{
				short num = (short)828004068;
				short num2 = num;
				num = (short)1660049124;
				switch (num2 == num)
				{
				}
				num = (short)328269825;
				if (num != 0)
				{
				}
				num = (short)301596672;
				if (num != 0)
				{
				}
				num = (short)1334247424;
				short num3 = num;
				this.znChanCfgChannelsWiFi.HiddenDynamic = value;
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000188 RID: 392 RVA: 0x0001B2EC File Offset: 0x000194EC
		public bool ZnChanCfgChannelsWiFi_HasDiffs
		{
			get
			{
				short num = (short)742178227;
				short num2 = num;
				num = (short)1594801587;
				switch (num2 == num)
				{
				}
				num = (short)1015480321;
				if (num != 0)
				{
				}
				num = (short)994902016;
				if (num != 0)
				{
				}
				num = (short)786497536;
				short num3 = num;
				return this.znChanCfgChannelsWiFi._HasDiffs;
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x06000189 RID: 393 RVA: 0x0001B3A0 File Offset: 0x000195A0
		public global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.DisplayAndMenu RefDisplayAndMenu
		{
			get
			{
				short num = (short)1532090527;
				short num2 = num;
				num = (short)157341855;
				switch (num2 == num)
				{
				}
				num = (short)338821121;
				if (num != 0)
				{
				}
				num = (short)510132224;
				if (num != 0)
				{
				}
				num = (short)953679872;
				short num3 = num;
				return global::AcpCommonLib.FeatureManager.GetFeature(2010)[0] as global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.DisplayAndMenu;
			}
		}

		// Token: 0x0600018A RID: 394 RVA: 0x0001B45C File Offset: 0x0001965C
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				switch (0)
				{
				case 0:
					goto IL_24;
				}
				int num;
				short num2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
						num2 = (short)781385732;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 1:
						num2 = (short)1446510595;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
						if (base.ParentRecset != null)
						{
							num2 = (short)1173094401;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					case 3:
						if (base.ParentRecset.ContainerDoc != null)
						{
							num2 = (short)672792576;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					case 4:
						return result;
					}
					break;
				}
				IL_24:
				num2 = (short)426835969;
				if (num2 != 0)
				{
				}
				result = null;
				num2 = (short)2067407268;
				short num3 = num2;
				num2 = (short)1712005540;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				case 1:
					break;
				default:
				{
					num2 = (short)1286078464;
					short num4 = num2;
					break;
				}
				}
				num2 = (short)1029636096;
				if (num2 != 0)
				{
				}
				num2 = (short)341835778;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			return result;
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x0600018B RID: 395 RVA: 0x0001B5D4 File Offset: 0x000197D4
		public string TTSTargetSpeaker
		{
			get
			{
				short num = (short)1657747020;
				short num2 = num;
				num = (short)1495873100;
				switch (num2 == num)
				{
				}
				num = (short)150929409;
				if (num != 0)
				{
				}
				num = (short)1202520064;
				if (num != 0)
				{
				}
				num = (short)2053308416;
				short num3 = num;
				return global::Features.Radio_Ergonomics_Configuration.Display_and_Menu.TtsSpeaker.TargetSpeaker;
			}
		}

		// Token: 0x0600018C RID: 396 RVA: 0x0001B680 File Offset: 0x00019880
		private void d()
		{
			short num = (short)978311611;
			short num2 = num;
			num = (short)1347082683;
			switch (num2 == num)
			{
			}
			num = (short)216006656;
			if (num != 0)
			{
			}
			num = (short)989986817;
			if (num != 0)
			{
			}
			num = (short)1181024256;
			short num3 = num;
			this.b();
		}

		// Token: 0x0600018D RID: 397 RVA: 0x0001B730 File Offset: 0x00019930
		private void c()
		{
			short num = (short)2017643786;
			short num2 = num;
			num = (short)1283706122;
			switch (num2 == num)
			{
			}
			num = (short)800391168;
			if (num != 0)
			{
			}
			num = (short)1547370497;
			if (num != 0)
			{
			}
			num = (short)1351680000;
			short num3 = num;
			this.a();
		}

		// Token: 0x0600018E RID: 398 RVA: 0x0001B7E4 File Offset: 0x000199E4
		private void b()
		{
			short num = (short)1377375682;
			short num2 = num;
			num = (short)1216222658;
			switch (num2 == num)
			{
			}
			num = (short)778764288;
			if (num != 0)
			{
			}
			num = (short)1372585985;
			if (num != 0)
			{
			}
			num = (short)926220288;
			short num3 = num;
			base.PropertyChanging += global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerSection.OnTrkPerSysName_PropertyChangingHandle;
			base.PropertyChanged += global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerSection.OnZCATrkTalkgroup_PropertyChangedHandle;
			base.PropertyChanged += global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerSection.OnChannelsPersonalityChangedHandle;
		}

		// Token: 0x0600018F RID: 399 RVA: 0x0001B8C4 File Offset: 0x00019AC4
		public static void OnTrkPerSysName_PropertyChangingHandle(object section, global::System.ComponentModel.PropertyChangingEventArgs label)
		{
			int a_ = 15;
			short num = (short)1019609088;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_6D;
					}
					continue;
				case 1:
					if (section != null)
					{
						num = (short)1445265416;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 2:
					if (section != null)
					{
						num = (short)1704394756;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_120;
				case 3:
					num = (short)1427374092;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
				{
					global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality trunkingPersonality = (section as global::AcpBusinessLayer.FeatureSection).Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality;
					num = (short)1021181961;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 5:
				{
					global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality trunkingPersonality;
					global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem = trunkingPersonality.General.TrkPerGeneralSystem_A9237.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem;
					num = (short)1179058186;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 6:
					goto IL_120;
				case 7:
				{
					global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
					trunkingSystem.Features.TrkSysFeaturesZone_A9717_Valid = false;
					trunkingSystem.Features.TrkSysFeaturesChannel_A7647_Valid = false;
					num = (short)1097924609;
					if (num != 0)
					{
					}
					num = (short)1440808966;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 8:
				{
					string propertyName = label.PropertyName;
					num = (short)634912768;
					short num3 = num;
					num = (short)428539915;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 9:
				{
					num = (short)941942747;
					short num4 = num;
					num = (short)329050075;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_9F;
					default:
					{
						num = (short)125239296;
						if (num != 0)
						{
						}
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality trunkingPersonality;
						if (trunkingPersonality != null)
						{
							num = (short)2090860549;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_120;
					}
					}
					break;
				}
				case 10:
				{
					global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
					if (trunkingSystem != null)
					{
						num = (short)418185223;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_120;
				}
				case 11:
				{
					string propertyName;
					if (!(propertyName == global::AllFeatures.CodeplugGuid.b("諏병韓뻕맗듙鿛룝蟟ꇡ賣蟥蛧蓩觫苭華꛱闳髵鏷鷹軻釽痿爁嬃䜅ㄇ㠉㬋㠍伏䜑崓䀕礗瘙椛笝", a_)))
					{
						num = (short)1348403203;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1EF;
				}
				case 12:
				{
					string propertyName;
					if (propertyName == global::AllFeatures.CodeplugGuid.b("蓏ꃑ뿓蛕뷗꣙鯛믝軟蟡難蟥蓧맩闫鷭蓯韱駳꧵맷쏹컻췽㟿崁儃伅帇欉怋笍甏", a_))
					{
						num = (short)192020494;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				case 13:
					goto IL_9F;
				case 14:
					goto IL_1EF;
				case 15:
					return;
				}
				IL_6D:
				if (label.PropertyName == global::AllFeatures.CodeplugGuid.b("蓏ꃑ뿓蛕뷗꣙鯛믝軟蟡難蟥蓧맩闫鷭蓯韱駳꧵맷쏹컻췽㟿崁儃伅帇欉怋笍甏", a_))
				{
					num = (short)247595021;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_120;
				IL_9F:
				num = (short)976814082;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_120:
				num = (short)1032519681;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1EF:
				global::ConstraintHelper.UtilityMack.PropertyChanging = true;
				num = (short)1666056207;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06000190 RID: 400 RVA: 0x0001BC18 File Offset: 0x00019E18
		public static void OnZCATrkTalkgroup_PropertyChangedHandle(object section, global::System.ComponentModel.PropertyChangedEventArgs label)
		{
			int a_ = 3;
			short num = (short)2106458112;
			switch (num)
			{
			default:
			{
				num = (short)504037377;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListRecset scanListRecset;
					switch (num2)
					{
					case 0:
						goto IL_BD;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_7A;
						}
						continue;
					case 2:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = scanListRecset.GetEnumerator();
						num = (short)169934851;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						try
						{
							num = (short)1651507202;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_3A0;
								case 1:
									try
									{
										num = (short)686358530;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												goto IL_318;
											case 2:
												switch (0)
												{
												case 0:
													goto IL_294;
												}
												continue;
											case 3:
												num = (short)1801191424;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 4:
											{
												global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
												if (!enumerator2.MoveNext())
												{
													num = (short)1546518531;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												(enumerator2.Current as global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInner).ScanListInnerSection.ScanLstScanListChannel_A7620.CalculateValidity();
												num = (short)1206779905;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											}
											IL_2C7:
											num = (short)593625092;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_294:
											goto IL_2C7;
										}
										IL_318:
										break;
									}
									finally
									{
										num = (short)1088815104;
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
													goto IL_34F;
												}
												continue;
											case 1:
												goto IL_385;
											case 2:
												enumerator2.Dispose();
												num = (short)819331073;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											IL_34F:
											if (enumerator2 == null)
											{
												break;
											}
											num = (short)783220738;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_385:;
									}
									goto IL_388;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_1DF;
									}
									continue;
								case 3:
									goto IL_388;
								case 4:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1299120131;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2 = (((global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanList)enumerator.Current)[10132].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInnerRecset).GetEnumerator();
									num = (short)1154940929;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_21D:
								num = (short)243990532;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1DF:
								goto IL_21D;
								IL_388:
								num = (short)1108672512;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_3A0:
							goto IL_4D3;
						}
						finally
						{
							num = (short)1091829760;
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
										goto IL_3D7;
									}
									continue;
								case 1:
								{
									num = (short)891501339;
									short num3 = num;
									num = (short)1742486299;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
										goto IL_444;
									}
									break;
								}
								case 2:
									enumerator.Dispose();
									num = (short)1535049729;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_3D7:
								if (enumerator == null)
								{
									goto IL_45B;
								}
								num = (short)1187315714;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_444:
							num = (short)228851712;
							if (num != 0)
							{
							}
							IL_45B:;
						}
						goto IL_45C;
					case 4:
						if (scanListRecset != null)
						{
							num = (short)514523138;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4D3;
					case 5:
						goto IL_45C;
					case 6:
					{
						num = (short)129499137;
						if (num != 0)
						{
						}
						string propertyName;
						if (propertyName == global::AllFeatures.CodeplugGuid.b("郃듅ꏇ髉꧋볍韏럑뫓돕꫗믙냛距駟釡郣菥藧뗩귫ퟭ싯쇱쏳꧵귷돹꫻鿽泿省愃", a_))
						{
							num = (short)920977408;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4D3;
					}
					case 7:
						if (global::ConstraintHelper.UtilityMack.PropertyChanging)
						{
							num = (short)240123913;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4D3;
					case 8:
						num = (short)850984967;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
					{
						string propertyName = label.PropertyName;
						num = (short)445251594;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
					{
						string propertyName;
						if (!(propertyName == global::AllFeatures.CodeplugGuid.b("黃ꣅ诇ꋉ귋ꃍ鏏듑돓闕냗믙닛냝藟軡韣닥觧蛩蟫觭苯鷱至蛵ꟷ믹엻쳽㟿㐁嬃包䄇尉洋戍攏眑", a_)))
						{
							num = (short)24641541;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_BD;
					}
					}
					IL_7A:
					if (section != null)
					{
						num = (short)1955987464;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_BD:
					global::ConstraintHelper.UtilityMack.PropertyChanging = false;
					scanListRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2057) as global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListRecset);
					num = (short)29622276;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_45C:
					num = (short)2063728646;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_4D3:
				num = (short)1722679296;
				short num4 = num;
				return;
			}
			}
		}

		// Token: 0x06000191 RID: 401 RVA: 0x0001C158 File Offset: 0x0001A358
		public static void OnChannelsPersonalityChangedHandle(object section, global::System.ComponentModel.PropertyChangedEventArgs label)
		{
			int a_ = 7;
			short num = (short)107872262;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment;
					zoneChannelAssignment.RSI.ZoneChannelAssignmentRSIMode_A41831.CalculateValidity();
					num = (short)1530593283;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
				{
					global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment;
					if (zoneChannelAssignment.RSI != null)
					{
						num = (short)1598160896;
						short num3 = num;
						num = (short)1824849920;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				case 2:
				{
					num = (short)1665974583;
					short num4 = num;
					num = (short)2108539191;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_123;
					default:
						num = (short)740950016;
						if (num != 0)
						{
						}
						num = (short)480641031;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 3:
					return;
				case 4:
				{
					global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerSection channelAssignmentListInnerSection = section as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerSection;
					channelAssignmentListInnerSection.ZnChanCfgChannelsFiregroundSectorID_A33630.CalculateEditability();
					channelAssignmentListInnerSection.ZnChanCfgChannelsPersonality_A8698.CalculateValidity();
					channelAssignmentListInnerSection.znChanCfgChannelsFallbackZone.CalculateApplicability();
					channelAssignmentListInnerSection.znChanCfgChannelsFallbackChannel.CalculateApplicability();
					global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment = channelAssignmentListInnerSection.Parent.Parent.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment;
					goto IL_123;
				}
				case 5:
					num = (short)598802433;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					switch (0)
					{
					case 0:
						goto IL_52;
					}
					continue;
				case 7:
					if (label.PropertyName == global::AllFeatures.CodeplugGuid.b("鋇꓉迋ꛍ뇏병韓냕뿗駙듛뿝軟賡臣諥鯧뫩觫鳭華鷱髳韵铷鏹裻蟽忿䌁㰃々ㄇ㈉匋嬍夏䐑甓稕洗缙", a_))
					{
						num = (short)1352400900;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 8:
				{
					num = (short)332267521;
					if (num != 0)
					{
					}
					global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment;
					if (zoneChannelAssignment != null)
					{
						num = (short)829292549;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				}
				IL_52:
				if (section != null)
				{
					num = (short)1091895298;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_123:
				num = (short)1306460168;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06000192 RID: 402 RVA: 0x0001C3B0 File Offset: 0x0001A5B0
		public override bool CanFill(global::AcpCommonLib.IAcpField myField)
		{
			short num = (short)15007749;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (this.ZnChanCfgChannelsChannelType_A22241.Value == 1)
					{
						num = (short)379191298;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1D4;
				case 1:
				{
					num = (short)1574699009;
					if (num != 0)
					{
					}
					num = (short)1089208320;
					short num3 = num;
					num = (short)1626865667;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					return false;
				case 3:
					if (this.ZnChanCfgChannelsChannelType_A22241.Value != 0)
					{
						num = (short)1002110980;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 4:
					goto IL_125;
				case 5:
					switch (0)
					{
					case 0:
						goto IL_44;
					}
					continue;
				case 6:
					num = (short)213057536;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					if (myField == this.ZnChanCfgChannelsConventionalChannelReference_A20560)
					{
						num = (short)1329397766;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1D4;
				}
				IL_44:
				if (myField == this.ZnChanCfgChannelsTalkgroup_A9276)
				{
					num = (short)617712263;
					short num4 = num;
					num = (short)1377536647;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1443627008;
						if (num != 0)
						{
						}
						num = (short)799604737;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
				}
				IL_125:
				num = (short)311361543;
				num2 = (int)((global::System.IntPtr)num);
			}
			return false;
			IL_1D4:
			return base.CanFill(myField);
		}

		// Token: 0x06000193 RID: 403 RVA: 0x0001C598 File Offset: 0x0001A798
		private void a()
		{
			short num = (short)673841162;
			int num2 = (int)((global::System.IntPtr)num);
			global::AcpCommonLib.IAcpRecordset feature;
			int num4;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_290;
				case 1:
					num = (short)254672897;
					if (num != 0)
					{
					}
					goto IL_367;
				case 2:
					if (base.Parent.Parent.ContainerDoc.IsOpen)
					{
						num = (short)253034518;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 3:
				{
					num = (short)1427832832;
					short num3 = num;
					num = (short)326828056;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					if (global::AcpCommonLib.Permission.Have(global::AcpCommonLib.Permissions.RefernceDisabled, feature[num4].Permissions))
					{
						num = (short)1032716306;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1672347663;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_253;
				case 6:
					num4 += 15;
					num = (short)671612929;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					num = (short)1901592578;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					if (global::AcpCommonLib.AppInfoManager.AddDefaultRecord)
					{
						num = (short)313327633;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 9:
					feature = global::AcpCommonLib.FeatureManager.GetFeature(2059);
					num4 = 0;
					num = (short)976289813;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					switch (0)
					{
					case 0:
						goto IL_88;
					}
					continue;
				case 11:
					if (!(base.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment).Zone.ZnChanCfgZoneZoneCloningEnable_43119.Value)
					{
						num = (short)2140930057;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 12:
				{
					num = (short)505235530;
					short num5 = num;
					num = (short)707348554;
					switch ((num5 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_253;
					default:
						num = (short)1237712896;
						if (num != 0)
						{
						}
						num = (short)2002190356;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 13:
					return;
				case 14:
					if (base.Parent.Parent.ContainerDoc.DocType != global::AcpCommonLib.DocumentType.Comparator)
					{
						num = (short)1744109584;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 15:
					if (!global::AcpCommonLib.AppInfoManager.UndoRedoInProgress)
					{
						num = (short)958464005;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 16:
					num = (short)1836384267;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					goto IL_28B;
				case 18:
					num = (short)785186835;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 19:
					if (num4 + 15 < feature.Count)
					{
						num = (short)1432354822;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_367;
				case 20:
					if (base.Parent.Parent.ContainerDoc != null)
					{
						num = (short)1438580743;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 21:
					goto IL_290;
				case 22:
					num = (short)2143027214;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 23:
					if (num4 >= feature.Count)
					{
						num = (short)1201471501;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)2102525956;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 24:
					if (base.Parent.Parent != null)
					{
						num = (short)81854476;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				IL_88:
				if (base.Parent != null)
				{
					num = (short)1311440899;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return;
				IL_253:
				num = (short)1548419080;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_290:
				num = (short)2068250647;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_367:
				num4++;
				num = (short)486277120;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_28B:
			this.ZnChanCfgChannelsPersonality_A8698.UIValue = feature[num4].ReferenceKey;
		}

		// Token: 0x0400007B RID: 123
		private global::AcpBusinessLayer.AcpFieldX<bool, bool> channelsActiveChannel;

		// Token: 0x0400007C RID: 124
		private global::AcpBusinessLayer.AcpKeyField znChanCfgChannelsChannelName_A7659;

		// Token: 0x0400007D RID: 125
		private global::AcpBusinessLayer.AcpRecRefField znChanCfgChannelsPersonality_A8698;

		// Token: 0x0400007E RID: 126
		private global::AcpBusinessLayer.AcpRangeField<int, string> znChanCfgChannelsFiregroundSectorID_A33630;

		// Token: 0x0400007F RID: 127
		private global::AcpBusinessLayer.AcpRecRefField znChanCfgChannelsTalkgroup_A9276;

		// Token: 0x04000080 RID: 128
		private global::AcpBusinessLayer.AcpField<string> znChanCfgChannelsTopDisplayChannel_A19774;

		// Token: 0x04000081 RID: 129
		private global::AcpBusinessLayer.AcpRecRefField channelAnnouncementID_A20175;

		// Token: 0x04000082 RID: 130
		private global::AcpBusinessLayer.AcpField<string> vCChannelAnnouncement_A20176;

		// Token: 0x04000083 RID: 131
		private global::AcpBusinessLayer.AcpRecRefField znChanCfgChannelsRadioProfileCompositeItemNameID_A20192;

		// Token: 0x04000084 RID: 132
		private global::AcpBusinessLayer.AcpRecRefField znChanCfgChannelsConventionalChannelReference_A20560;

		// Token: 0x04000085 RID: 133
		private global::AcpBusinessLayer.AcpListField znChanCfgChannelsChannelType_A22241;

		// Token: 0x04000086 RID: 134
		private global::AcpBusinessLayer.AcpListField znChanCfgTopLightColor_A43173;

		// Token: 0x04000087 RID: 135
		private global::AcpBusinessLayer.AcpListField znChanCfgChannelsChannelColorBacklightSelection_43749;

		// Token: 0x04000088 RID: 136
		private global::AcpBusinessLayer.AcpRecRefField znChanCfgChannelsFallbackZone;

		// Token: 0x04000089 RID: 137
		private global::AcpBusinessLayer.AcpRecRefField znChanCfgChannelsFallbackChannel;

		// Token: 0x0400008A RID: 138
		private global::AcpBusinessLayer.AcpListField znChanCfgChannelsWiFi;
	}
}
