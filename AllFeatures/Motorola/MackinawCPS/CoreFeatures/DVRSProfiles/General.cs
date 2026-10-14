using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using Motorola.MackinawCPS.CoreFeatures.DVRSWide;

namespace Motorola.MackinawCPS.CoreFeatures.DVRSProfiles
{
	// Token: 0x020004B8 RID: 1208
	[global::System.Serializable]
	public class General : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06009E71 RID: 40561 RVA: 0x0093F5B0 File Offset: 0x0093D7B0
		public General(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06009E72 RID: 40562 RVA: 0x0093F5CC File Offset: 0x0093D7CC
		protected General(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06009E73 RID: 40563 RVA: 0x0093F5E4 File Offset: 0x0093D7E4
		public override void Init()
		{
			int a_ = 16;
			short num = (short)1637994061;
			short num2 = num;
			num = (short)1096928845;
			switch (num2 == num)
			{
			}
			num = (short)1330249729;
			if (num != 0)
			{
			}
			num = (short)2056519680;
			short num3 = num;
			num = (short)2089549824;
			if (num != 0)
			{
			}
			this.dVRSProfGeneralDVRSRemoteActivation_A41800 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("闐藒蟔蓖觘꧚닜맞ꛠ蛢诤苦鯨諪臬꯮꟰ꇲ꛴ꗶ鳸雺鋼课搀䈂昄猆怈紊氌笎砐簒笔䠖堘⼚Ⱌ✞ᄠጢ", a_), global::CommonResources.AcgResources.ID_DVRSREMOTEACTIVATION, global::Motorola.MackinawCPS.CoreFeatures.DVRSProfiles.LOVs.DVRSProfGeneralDVRSRemoteActivation_A41800LovStrs);
			this.dVRSProfGeneralDVRSRemoteActivation_A41800.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.dVRSProfGeneralDVRSRemoteActivation_A41800.DataTransferOrder = 2;
			this.dVRSProfGeneralDVRSRemoteActivation_A41800.EvaluateRecRefs = true;
			this.dVRSProfGeneralGenStsOnDVRSModChg_A41801 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("闐藒蟔蓖觘꧚닜맞ꛠ蛢诤苦鯨諪臬꣮铰鷲꛴菶諸듺鏼믾圀儂嘄䨆昈漊丌朎瘐䰒吔⌖⠘⌚ⴜ⸞", a_), global::CommonResources.AcgResources.ID_GENERATESTATUSONDVRSMODECHANGE);
			this.dVRSProfGeneralGenStsOnDVRSModChg_A41801.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.dVRSProfGeneralGenStsOnDVRSModChg_A41801.DataTransferOrder = 3;
			this.dVRSProfGeneralGenStsOnDVRSModChg_A41801.EvaluateRecRefs = true;
			this.dVRSProfGeneralICMAllowed_A41802 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("闐藒蟔蓖觘꧚닜맞ꛠ蛢诤苦鯨諪臬ꛮ닰뻲듴鯶闸铺諼髾攀専䐄㌆㠈㌊㴌㴎", a_), global::CommonResources.AcgResources.ID_ICMALLOWED);
			this.dVRSProfGeneralICMAllowed_A41802.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.dVRSProfGeneralICMAllowed_A41802.DataTransferOrder = 4;
			this.dVRSProfGeneralMSUSysPTTInLocalMode_A41803 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("闐藒蟔蓖觘꧚닜맞ꛠ蛢诤苦鯨諪臬ꋮꋰ꛲꛴軶諸꯺ꧼ꯾䠀洂䤄栆樈樊愌䈎縐眒瀔䠖堘⼚Ⱌ✞ᄠဢ", a_), global::CommonResources.AcgResources.ID_LOCALMODEMSUSYSTEMPTTINLOCALMODE);
			this.dVRSProfGeneralMSUSysPTTInLocalMode_A41803.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.dVRSProfGeneralMSUSysPTTInLocalMode_A41803.DataTransferOrder = 5;
			this.dVRSProfGeneralOutSysRepLocalMode_A41804 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("闐藒蟔蓖觘꧚닜맞ꛠ蛢诤苦鯨諪臬ꃮ蓰蟲꛴軶諸ꧺ飼迾䴀氂昄昆攈䘊戌欎琐䰒吔⌖⠘⌚ⴜ⬞", a_), global::CommonResources.AcgResources.ID_LOCALMODEOUTBOUNDSYSTEMREPEATINLOCALMODE);
			this.dVRSProfGeneralOutSysRepLocalMode_A41804.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.dVRSProfGeneralOutSysRepLocalMode_A41804.DataTransferOrder = 6;
			this.dVRSProfGeneralRouteMSUPTTMicAudToDVR_A41805 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("闐藒蟔蓖觘꧚닜맞ꛠ蛢诤苦鯨諪臬뷮黰蛲致鋶듸꣺꣼꿾唀圂䠄渆樈䨊砌欎䔐簒儔䄖䬘䐚尜⬞ဠᬢᔤሦ", a_), global::CommonResources.AcgResources.ID_SYSTEMMODEROUTEMSUMICAUDIOTODVRSINSYSTEMMODE);
			this.dVRSProfGeneralRouteMSUPTTMicAudToDVR_A41805.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.dVRSProfGeneralRouteMSUPTTMicAudToDVR_A41805.DataTransferOrder = 7;
			this.dVRSProfGeneralLocalTxFallback_A41806 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("闐藒蟔蓖觘꧚닜맞ꛠ蛢诤苦鯨諪臬ꏮ黰郲铴鯶그菺민黾洀漂朄昆樈怊刌与┐−ⴔ✖⼘", a_), global::CommonResources.AcgResources.ID_SYSTEMMODELOCALTXFALLBACK);
			this.dVRSProfGeneralLocalTxFallback_A41806.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.dVRSProfGeneralLocalTxFallback_A41806.DataTransferOrder = 8;
			this.dVRSProfGeneralProxyTimeOutTimer_A41807 = new global::AcpBusinessLayer.AcpSimpleRangeField(0, this, global::AllFeatures.CodeplugGuid.b("闐藒蟔蓖觘꧚닜맞ꛠ蛢诤苦鯨諪臬뿮菰鳲跴軶그鋺郼髾一瘂焄匆怈昊栌紎丐划℔☖℘⬚⨜", a_), global::CommonResources.AcgResources.ID_PROXYTIMEOUTTIMERSEC, 1, 31, null, null, 0, 15);
			this.dVRSProfGeneralProxyTimeOutTimer_A41807.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.dVRSProfGeneralProxyTimeOutTimer_A41807.DataTransferOrder = 9;
			this.dVRSProfGeneralProxyTimeOutTimer_A41807.AddCustomValue(0, global::CommonResources.AcgResources.ID_INFINITE);
			this.dVRSProfGeneralProxyTimeOutTimer_A41807.ShowHexValue = false;
			this.dVRSProfGeneralProxyLimitPatienceTimer_A41808 = new global::AcpBusinessLayer.AcpSimpleRangeField(10, this, global::AllFeatures.CodeplugGuid.b("闐藒蟔蓖觘꧚닜맞ꛠ蛢诤苦鯨諪臬뿮菰鳲跴軶뗸鋺郼雾甀匂搄猆怈渊挌氎琐䜒簔稖簘椚䈜帞ᔠሢᴤᜦᄨ", a_), global::CommonResources.AcgResources.ID_PROXYLIMITEDPATIENCESEC, 1, 60, null, null, 0, 1);
			this.dVRSProfGeneralProxyLimitPatienceTimer_A41808.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.dVRSProfGeneralProxyLimitPatienceTimer_A41808.DataTransferOrder = 10;
			this.dVRSProfGeneralProxyLimitPatienceTimer_A41808.ShowHexValue = false;
			this.dVRSProfGeneralDVRSProfName_A41809 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("闐藒蟔蓖觘꧚닜맞ꛠ蛢诤苦鯨諪臬꯮꟰ꇲ꛴ꟶ诸铺鯼뇾怀渂怄堆䠈㼊㰌㜎ℐ⨒", a_), global::CommonResources.AcgResources.ID_DVRSPROFILENAME, 14);
			this.dVRSProfGeneralDVRSProfName_A41809.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.dVRSProfGeneralDVRSProfName_A41809.DataTransferOrder = 1;
			this.dVRSProfGeneralProxyRFSSReponseTimer_A41810 = new global::AcpBusinessLayer.AcpSimpleRangeField(30, this, global::AllFeatures.CodeplugGuid.b("闐藒蟔蓖觘꧚닜맞ꛠ蛢诤苦鯨諪臬뿮菰鳲跴軶꯸뷺껼곾匀昂甄栆月砊栌嬎砐縒瀔攖䘘娚⤜⸞ᤠሢᔤ", a_), global::CommonResources.AcgResources.ID_PROXYRFSSRESPONSETIMEMS, 0, 255, null, null, 0, 25);
			this.dVRSProfGeneralProxyRFSSReponseTimer_A41810.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.dVRSProfGeneralProxyRFSSReponseTimer_A41810.DataTransferOrder = 11;
			this.dVRSProfGeneralProxyRFSSReponseTimer_A41810.ShowHexValue = false;
			this.dVRSProfGeneralGenStsOnDVRSModChgHoldoff_A41869 = new global::AcpBusinessLayer.AcpSimpleRangeField(15, this, global::AllFeatures.CodeplugGuid.b("闐藒蟔蓖觘꧚닜맞ꛠ蛢诤苦鯨諪臬꣮铰鷲꛴菶諸듺鏼믾圀儂嘄䨆昈漊丌朎瘐嬒稔笖紘琚笜礞縠戢ᄤᘦᄨᴪᐬ", a_), global::CommonResources.AcgResources.ID_GENERATESTATUSONDVRSMODECHANGEHOLDOFFSEC, 2, 60, null, null, 0, 1);
			this.dVRSProfGeneralGenStsOnDVRSModChgHoldoff_A41869.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.dVRSProfGeneralGenStsOnDVRSModChgHoldoff_A41869.DataTransferOrder = 12;
			this.dVRSProfGeneralGenStsOnDVRSModChgHoldoff_A41869.ShowHexValue = false;
			this.dVRSProfGeneralGenStsLegacyMode = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("闐藒蟔蓖觘꧚닜맞ꛠ蛢诤苦鯨諪臬꣮铰鷲꛴菶諸럺飼飾怀怂簄䨆昈漊栌", a_), global::CommonResources.AcgResources.ID_GENERATESTATUSALTERNATEMODE);
			this.dVRSProfGeneralGenStsLegacyMode.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.dVRSProfGeneralGenStsLegacyMode.DataTransferOrder = 15;
			this.dVRSProfGeneralSuspendScanOnDVRSActive_42782 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("闐藒蟔蓖觘꧚닜맞ꛠ蛢诤苦鯨諪臬볮蓰胲藴鋶韸鿺껼鳾怀洂䨄椆䴈崊弌導倐瀒愔縖漘縚䈜⬞ጠᐢᴤᔦ", a_), global::CommonResources.AcgResources.ID_SUSPENDSCANONDVRSACTIVE);
			this.dVRSProfGeneralSuspendScanOnDVRSActive_42782.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.dVRSProfGeneralSuspendScanOnDVRSActive_42782.DataTransferOrder = 14;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("雐뛒믔닖ꯘ뫚뇜", a_);
			base.Id = 10759;
			base.UIName = global::CommonResources.AcgResources.ID_GENERAL;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06009E74 RID: 40564 RVA: 0x0093FA60 File Offset: 0x0093DC60
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 17;
			short num = (short)1522925598;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)391577604;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
				{
					num = (short)921696744;
					short num3 = num;
					num = (short)1267726824;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_3EB;
					default:
						num = (short)920911872;
						if (num != 0)
						{
						}
						if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("雑苓蓕诗諙껛뇝蛟ꗡ臣裥跧飩跫苭ꃯ胱鯳軵臷뛹闻鏽槿瘁吃朅簇按椋怍猏眑䀓缕甗缙減䄝感ᘡᔣḥᠧሩ", a_)))
						{
							num = (short)2097348636;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2FD;
					}
					break;
				}
				case 2:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("雑苓蓕诗諙껛뇝蛟ꗡ臣裥跧飩跫苭뷯ꇱꇳꗵ臷觹곻꫽哿䬁樃䨅朇椉洋戍崏紑瀓猕䜗嬙⠛⼝᠟ሡᜣ", a_)))
					{
						num = (short)1674051622;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_61C;
				case 3:
					goto IL_4DA;
				case 4:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("雑苓蓕诗諙껛뇝蛟ꗡ臣裥跧飩跫苭듯ꓱ꛳ꗵ꫷鿹釻釽瓿朁䔃攅簇按程漍搏笑笓砕䜗嬙⠛⼝᠟ሡᐣ", a_)))
					{
						num = (short)1483472907;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_28B;
				case 5:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("雑苓蓕诗諙껛뇝蛟ꗡ臣裥跧飩跫苭ꃯ胱鯳軵臷껹闻鏽旿䴁焃爅將按愋欍戏䴑唓∕⤗∙Ⱋ⤝", a_)))
					{
						num = (short)896008231;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_7AB;
				case 6:
					goto IL_7AB;
				case 7:
					goto IL_3EB;
				case 8:
					goto IL_1D8;
				case 9:
					goto IL_6B8;
				case 10:
					goto IL_98E;
				case 11:
					this.dVRSProfGeneralDVRSRemoteActivation_A41800 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("雑苓蓕诗諙껛뇝蛟ꗡ臣裥跧飩跫苭듯ꓱ꛳ꗵ꫷鿹釻釽瓿朁䔃攅簇按程漍搏笑笓砕䜗嬙⠛⼝᠟ሡᐣ", a_), global::CommonResources.AcgResources.ID_DVRSREMOTEACTIVATION, global::Motorola.MackinawCPS.CoreFeatures.DVRSProfiles.LOVs.DVRSProfGeneralDVRSRemoteActivation_A41800LovStrs);
					this.dVRSProfGeneralDVRSRemoteActivation_A41800.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.dVRSProfGeneralDVRSRemoteActivation_A41800.DataTransferOrder = 2;
					this.dVRSProfGeneralDVRSRemoteActivation_A41800.EvaluateRecRefs = true;
					num = (short)1900478499;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					goto IL_A79;
				case 13:
					num = (short)1215561764;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					goto IL_61C;
				case 15:
					goto IL_2FD;
				case 16:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("雑苓蓕诗諙껛뇝蛟ꗡ臣裥跧飩跫苭럯韱髳ꗵ賷觹돻都䓿吁嘃唅䔇攉栋䴍砏甑䬓圕Ⱇ⬙␛⸝ᄟ", a_)))
					{
						num = (short)412024855;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1D8;
				case 17:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("雑苓蓕诗諙껛뇝蛟ꗡ臣裥跧飩跫苭럯韱髳ꗵ賷觹냻鯽柿持會缅䔇攉栋欍", a_)))
					{
						num = (short)1234108447;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A79;
				case 18:
					goto IL_39E;
				case 19:
					goto IL_4DF;
				case 20:
					this.dVRSProfGeneralSuspendScanOnDVRSActive_42782 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("雑苓蓕诗諙껛뇝蛟ꗡ臣裥跧飩跫苭ꏯ蟱蟳蛵鷷铹飻귽揿持樃䤅昇三娋對䌏匑眓戕焗氙礛䄝ᐟအጣḥᨧ", a_), global::CommonResources.AcgResources.ID_SUSPENDSCANONDVRSACTIVE);
					this.dVRSProfGeneralSuspendScanOnDVRSActive_42782.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.dVRSProfGeneralSuspendScanOnDVRSActive_42782.DataTransferOrder = 14;
					num = (short)1270349827;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 21:
					this.dVRSProfGeneralOutSysRepLocalMode_A41804 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("雑苓蓕诗諙껛뇝蛟ꗡ臣裥跧飩跫苭뿯蟱胳ꗵ臷觹껻鯽烿丁欃攅椇昉䄋愍琏眑䬓圕Ⱇ⬙␛⸝ᐟ", a_), global::CommonResources.AcgResources.ID_LOCALMODEOUTBOUNDSYSTEMREPEATINLOCALMODE);
					this.dVRSProfGeneralOutSysRepLocalMode_A41804.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.dVRSProfGeneralOutSysRepLocalMode_A41804.DataTransferOrder = 6;
					num = (short)1502150675;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 22:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("雑苓蓕诗諙껛뇝蛟ꗡ臣裥跧飩跫苭맯뇱맳럵铷雹鏻觽旿昁嬃䜅㰇㬉㐋㸍∏", a_)))
					{
						num = (short)400883755;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3EB;
				case 23:
					num = (short)708182017;
					if (num != 0)
					{
					}
					this.dVRSProfGeneralGenStsOnDVRSModChg_A41801 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("雑苓蓕诗諙껛뇝蛟ꗡ臣裥跧飩跫苭럯韱髳ꗵ賷觹돻都䓿吁嘃唅䔇攉栋䴍砏甑䬓圕Ⱇ⬙␛⸝ᄟ", a_), global::CommonResources.AcgResources.ID_GENERATESTATUSONDVRSMODECHANGE);
					this.dVRSProfGeneralGenStsOnDVRSModChg_A41801.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.dVRSProfGeneralGenStsOnDVRSModChg_A41801.DataTransferOrder = 3;
					this.dVRSProfGeneralGenStsOnDVRSModChg_A41801.EvaluateRecRefs = true;
					num = (short)1348009992;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 24:
					this.dVRSProfGeneralDVRSProfName_A41809 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("雑苓蓕诗諙껛뇝蛟ꗡ臣裥跧飩跫苭듯ꓱ꛳ꗵꣷ裹鏻飽仿持椃挅圇䬉㠋㼍⠏∑ⴓ", a_), global::CommonResources.AcgResources.ID_DVRSPROFILENAME, 14);
					this.dVRSProfGeneralDVRSProfName_A41809.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.dVRSProfGeneralDVRSProfName_A41809.DataTransferOrder = 1;
					num = (short)1760690185;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 25:
					this.dVRSProfGeneralGenStsOnDVRSModChgHoldoff_A41869 = new global::AcpBusinessLayer.AcpSimpleRangeField(15, this, global::AllFeatures.CodeplugGuid.b("雑苓蓕诗諙껛뇝蛟ꗡ臣裥跧飩跫苭럯韱髳ꗵ賷觹돻都䓿吁嘃唅䔇攉栋䴍砏甑尓礕琗縙猛砝䘟紡攣ሥᤧሩᨫᜭ", a_), global::CommonResources.AcgResources.ID_GENERATESTATUSONDVRSMODECHANGEHOLDOFFSEC, null, null, 0, 1);
					this.dVRSProfGeneralGenStsOnDVRSModChgHoldoff_A41869.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.dVRSProfGeneralGenStsOnDVRSModChgHoldoff_A41869.DataTransferOrder = 12;
					this.dVRSProfGeneralGenStsOnDVRSModChgHoldoff_A41869.ShowHexValue = false;
					num = (short)758972453;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 26:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("雑苓蓕诗諙껛뇝蛟ꗡ臣裥跧飩跫苭듯ꓱ꛳ꗵꣷ裹鏻飽仿持椃挅圇䬉㠋㼍⠏∑ⴓ", a_)))
					{
						num = (short)12648472;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_6B8;
				case 27:
					goto IL_66A;
				case 28:
					this.dVRSProfGeneralProxyLimitPatienceTimer_A41808 = new global::AcpBusinessLayer.AcpSimpleRangeField(10, this, global::AllFeatures.CodeplugGuid.b("雑苓蓕诗諙껛뇝蛟ꗡ臣裥跧飩跫苭ꃯ胱鯳軵臷뛹闻鏽槿瘁吃朅簇按椋怍猏眑䀓缕甗缙減䄝感ᘡᔣḥᠧሩ", a_), global::CommonResources.AcgResources.ID_PROXYLIMITEDPATIENCESEC, null, null, 0, 1);
					this.dVRSProfGeneralProxyLimitPatienceTimer_A41808.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.dVRSProfGeneralProxyLimitPatienceTimer_A41808.DataTransferOrder = 10;
					this.dVRSProfGeneralProxyLimitPatienceTimer_A41808.ShowHexValue = false;
					num = (short)1415708687;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 29:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("雑苓蓕诗諙껛뇝蛟ꗡ臣裥跧飩跫苭ꏯ蟱蟳蛵鷷铹飻귽揿持樃䤅昇三娋對䌏匑眓戕焗氙礛䄝ᐟအጣḥᨧ", a_)))
					{
						num = (short)532545556;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_B2C;
				case 30:
					switch (0)
					{
					case 0:
						goto IL_E5;
					}
					continue;
				case 31:
					this.dVRSProfGeneralGenStsLegacyMode = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("雑苓蓕诗諙껛뇝蛟ꗡ臣裥跧飩跫苭럯韱髳ꗵ賷觹냻鯽柿持會缅䔇攉栋欍", a_), global::CommonResources.AcgResources.ID_GENERATESTATUSALTERNATEMODE);
					this.dVRSProfGeneralGenStsLegacyMode.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.dVRSProfGeneralGenStsLegacyMode.DataTransferOrder = 15;
					num = (short)1742667788;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 32:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("雑苓蓕诗諙껛뇝蛟ꗡ臣裥跧飩跫苭ꋯ鷱至苵鷷럹꿻꯽僿嘁倃䬅愇椉䴋笍琏䘑笓刕丗䠙䌛弝ᐟጡᰣᘥᴧ", a_)))
					{
						num = (short)706871337;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_98E;
				case 33:
					this.dVRSProfGeneralLocalTxFallback_A41806 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("雑苓蓕诗諙껛뇝蛟ꗡ臣裥跧飩跫苭볯鷱音韵铷껹蓻룽懿渁栃搅椇椉朋儍儏☑┓⸕⠗Ⱉ", a_), global::CommonResources.AcgResources.ID_SYSTEMMODELOCALTXFALLBACK);
					this.dVRSProfGeneralLocalTxFallback_A41806.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.dVRSProfGeneralLocalTxFallback_A41806.DataTransferOrder = 8;
					num = (short)1601241106;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 34:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("雑苓蓕诗諙껛뇝蛟ꗡ臣裥跧飩跫苭럯韱髳ꗵ賷觹돻都䓿吁嘃唅䔇攉栋䴍砏甑尓礕琗縙猛砝䘟紡攣ሥᤧሩᨫᜭ", a_)))
					{
						num = (short)420020249;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_43B;
				case 35:
					goto IL_28B;
				case 36:
					if (producerFields != null)
					{
						num = (short)1150746624;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_B2C;
				case 37:
					goto IL_43B;
				case 38:
					this.dVRSProfGeneralMSUSysPTTInLocalMode_A41803 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("雑苓蓕诗諙껛뇝蛟ꗡ臣裥跧飩跫苭뷯ꇱꇳꗵ臷觹곻꫽哿䬁樃䨅朇椉洋戍崏紑瀓猕䜗嬙⠛⼝᠟ሡᜣ", a_), global::CommonResources.AcgResources.ID_LOCALMODEMSUSYSTEMPTTINLOCALMODE);
					this.dVRSProfGeneralMSUSysPTTInLocalMode_A41803.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.dVRSProfGeneralMSUSysPTTInLocalMode_A41803.DataTransferOrder = 5;
					num = (short)509345806;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 39:
					this.dVRSProfGeneralProxyTimeOutTimer_A41807 = new global::AcpBusinessLayer.AcpSimpleRangeField(0, this, global::AllFeatures.CodeplugGuid.b("雑苓蓕诗諙껛뇝蛟ꗡ臣裥跧飩跫苭ꃯ胱鯳軵臷껹闻鏽旿䴁焃爅將按愋欍戏䴑唓∕⤗∙Ⱋ⤝", a_), global::CommonResources.AcgResources.ID_PROXYTIMEOUTTIMERSEC, null, null, 0, 15);
					this.dVRSProfGeneralProxyTimeOutTimer_A41807.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.dVRSProfGeneralProxyTimeOutTimer_A41807.DataTransferOrder = 9;
					this.dVRSProfGeneralProxyTimeOutTimer_A41807.AddCustomValue(0, global::CommonResources.AcgResources.ID_INFINITE);
					this.dVRSProfGeneralProxyTimeOutTimer_A41807.ShowHexValue = false;
					num = (short)997982214;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 40:
				{
					this.dVRSProfGeneralProxyRFSSReponseTimer_A41810 = new global::AcpBusinessLayer.AcpSimpleRangeField(30, this, global::AllFeatures.CodeplugGuid.b("雑苓蓕诗諙껛뇝蛟ꗡ臣裥跧飩跫苭ꃯ胱鯳軵臷꣹뫻귽叿倁愃瘅朇搉缋欍䐏笑礓猕樗䔙崛⨝ᄟᨡᔣᘥ", a_), global::CommonResources.AcgResources.ID_PROXYRFSSRESPONSETIMEMS, null, null, 0, 25);
					this.dVRSProfGeneralProxyRFSSReponseTimer_A41810.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.dVRSProfGeneralProxyRFSSReponseTimer_A41810.DataTransferOrder = 11;
					this.dVRSProfGeneralProxyRFSSReponseTimer_A41810.ShowHexValue = false;
					num = (short)629538816;
					short num4 = num;
					num = (short)1473576987;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 41:
					this.dVRSProfGeneralRouteMSUPTTMicAudToDVR_A41805 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("雑苓蓕诗諙껛뇝蛟ꗡ臣裥跧飩跫苭ꋯ鷱至苵鷷럹꿻꯽僿嘁倃䬅愇椉䴋笍琏䘑笓刕丗䠙䌛弝ᐟጡᰣᘥᴧ", a_), global::CommonResources.AcgResources.ID_SYSTEMMODEROUTEMSUMICAUDIOTODVRSINSYSTEMMODE);
					this.dVRSProfGeneralRouteMSUPTTMicAudToDVR_A41805.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.dVRSProfGeneralRouteMSUPTTMicAudToDVR_A41805.DataTransferOrder = 7;
					num = (short)559087626;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 42:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("雑苓蓕诗諙껛뇝蛟ꗡ臣裥跧飩跫苭ꃯ胱鯳軵臷꣹뫻귽叿倁愃瘅朇搉缋欍䐏笑礓猕樗䔙崛⨝ᄟᨡᔣᘥ", a_)))
					{
						num = (short)1485111336;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_66A;
				case 43:
					this.dVRSProfGeneralICMAllowed_A41802 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("雑苓蓕诗諙껛뇝蛟ꗡ臣裥跧飩跫苭맯뇱맳럵铷雹鏻觽旿昁嬃䜅㰇㬉㐋㸍∏", a_), global::CommonResources.AcgResources.ID_ICMALLOWED);
					this.dVRSProfGeneralICMAllowed_A41802.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.dVRSProfGeneralICMAllowed_A41802.DataTransferOrder = 4;
					num = (short)1081278471;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 44:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("雑苓蓕诗諙껛뇝蛟ꗡ臣裥跧飩跫苭뿯蟱胳ꗵ臷觹껻鯽烿丁欃攅椇昉䄋愍琏眑䬓圕Ⱇ⬙␛⸝ᐟ", a_)))
					{
						num = (short)1714618389;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4DF;
				case 45:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("雑苓蓕诗諙껛뇝蛟ꗡ臣裥跧飩跫苭볯鷱音韵铷껹蓻룽懿渁栃搅椇椉朋儍儏☑┓⸕⠗Ⱉ", a_)))
					{
						num = (short)479068193;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_39E;
				}
				IL_E5:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)419233805;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_1D8:
				num = (short)1255931926;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_28B:
				num = (short)871497744;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2FD:
				num = (short)1569718298;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_39E:
				num = (short)287440901;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3EB:
				num = (short)841023490;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_43B:
				num = (short)1699217425;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_4DF:
				num = (short)1351942176;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_61C:
				num = (short)2134310956;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_66A:
				num = (short)1403322402;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_6B8:
				num = (short)1970733098;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_7AB:
				num = (short)1206910977;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_98E:
				num = (short)38141997;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_A79:
				num = (short)1909129245;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_4DA:
			IL_B2C:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("闑뇓룕뷗꣙뷛닝", a_);
			base.Id = 10759;
			base.UIName = global::CommonResources.AcgResources.ID_GENERAL;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06009E75 RID: 40565 RVA: 0x009405CC File Offset: 0x0093E7CC
		public override void PopulateReferences()
		{
			short num = (short)1021268806;
			short num2 = num;
			num = (short)931681094;
			switch (num2 == num)
			{
			}
			num = (short)1760231425;
			if (num != 0)
			{
			}
			num = (short)117374976;
			short num3 = num;
			num = (short)1070333952;
			if (num != 0)
			{
			}
		}

		// Token: 0x06009E76 RID: 40566 RVA: 0x00940674 File Offset: 0x0093E874
		public override void DropReferences()
		{
			short num = (short)1616034450;
			short num2 = num;
			num = (short)2112862866;
			switch (num2 == num)
			{
			}
			num = (short)1370882048;
			if (num != 0)
			{
			}
			num = (short)1898446848;
			short num3 = num;
			num = (short)1830158337;
			if (num != 0)
			{
			}
		}

		// Token: 0x06009E77 RID: 40567 RVA: 0x0094071C File Offset: 0x0093E91C
		public override void SetConstraints()
		{
			short num = (short)924188673;
			if (num != 0)
			{
			}
			num = (short)899207380;
			short num2 = num;
			num = (short)41996500;
			switch (num2 == num)
			{
			}
			num = (short)1189609472;
			short num3 = num;
			num = (short)99090432;
			if (num != 0)
			{
			}
			this.dVRSProfGeneralDVRSRemoteActivation_A41800.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DVRSProfiles.DVRSProfilesConstraints.ConDVRSHardWareIsEnabled);
			this.dVRSProfGeneralGenStsOnDVRSModChg_A41801.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DVRSProfiles.DVRSProfilesConstraints.ConDVRSHardWareIsEnabled);
			this.dVRSProfGeneralICMAllowed_A41802.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DVRSProfiles.DVRSProfilesConstraints.ConDVRSHardWareIsEnabled);
			this.dVRSProfGeneralMSUSysPTTInLocalMode_A41803.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DVRSProfiles.DVRSProfilesConstraints.ConDVRSHardWareIsEnabled);
			this.dVRSProfGeneralMSUSysPTTInLocalMode_A41803.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DVRSProfiles.DVRSProfilesConstraints.ConOutBoundSysRepLocalMode);
			this.dVRSProfGeneralOutSysRepLocalMode_A41804.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DVRSProfiles.DVRSProfilesConstraints.ConDVRSHardWareIsEnabled);
			this.dVRSProfGeneralRouteMSUPTTMicAudToDVR_A41805.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DVRSProfiles.DVRSProfilesConstraints.ConDVRSHardWareIsEnabled);
			this.dVRSProfGeneralLocalTxFallback_A41806.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DVRSProfiles.DVRSProfilesConstraints.ConDVRSHardWareIsEnabled);
			this.dVRSProfGeneralLocalTxFallback_A41806.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DVRSProfiles.DVRSProfilesConstraints.ConMSUSysPTTLocalMode);
			this.dVRSProfGeneralProxyTimeOutTimer_A41807.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DVRSProfiles.DVRSProfilesConstraints.ConDVRSHardWareIsEnabled);
			this.dVRSProfGeneralProxyLimitPatienceTimer_A41808.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DVRSProfiles.DVRSProfilesConstraints.ConDVRSHardWareIsEnabled);
			this.dVRSProfGeneralProxyRFSSReponseTimer_A41810.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DVRSProfiles.DVRSProfilesConstraints.ConDVRSHardWareIsEnabled);
			this.dVRSProfGeneralGenStsOnDVRSModChgHoldoff_A41869.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DVRSProfiles.DVRSProfilesConstraints.ConDVRSHardWareIsEnabledAndHoldoffIsEnabled);
			this.dVRSProfGeneralGenStsLegacyMode.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DVRSProfiles.DVRSProfilesConstraints.ConDVRSHardWareIsEnabledAndHoldoffIsEnabled);
			this.dVRSProfGeneralSuspendScanOnDVRSActive_42782.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DVRSProfiles.DVRSProfilesConstraints.ConDVRSHardWareIsEnabled);
		}

		// Token: 0x06009E78 RID: 40568 RVA: 0x00940920 File Offset: 0x0093EB20
		public override void SetupDependencies()
		{
			short num = (short)1434129521;
			short num2 = num;
			num = (short)126096497;
			switch (num2 == num)
			{
			}
			num = (short)480444416;
			if (num != 0)
			{
			}
			num = (short)1063649280;
			short num3 = num;
			num = (short)1259601921;
			if (num != 0)
			{
			}
			this.RefDVRSWide.General.RadErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911.AddDependentObject(this.dVRSProfGeneralDVRSRemoteActivation_A41800);
			this.RefDVRSWide.General.RadErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911.AddDependentObject(this.dVRSProfGeneralGenStsOnDVRSModChg_A41801);
			this.RefDVRSWide.General.RadErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911.AddDependentObject(this.dVRSProfGeneralICMAllowed_A41802);
			this.RefDVRSWide.General.RadErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911.AddDependentObject(this.dVRSProfGeneralMSUSysPTTInLocalMode_A41803);
			this.dVRSProfGeneralOutSysRepLocalMode_A41804.AddDependentObject(this.dVRSProfGeneralMSUSysPTTInLocalMode_A41803);
			this.RefDVRSWide.General.RadErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911.AddDependentObject(this.dVRSProfGeneralOutSysRepLocalMode_A41804);
			this.RefDVRSWide.General.RadErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911.AddDependentObject(this.dVRSProfGeneralRouteMSUPTTMicAudToDVR_A41805);
			this.RefDVRSWide.General.RadErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911.AddDependentObject(this.dVRSProfGeneralLocalTxFallback_A41806);
			this.dVRSProfGeneralMSUSysPTTInLocalMode_A41803.AddDependentObject(this.dVRSProfGeneralLocalTxFallback_A41806);
			this.RefDVRSWide.General.RadErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911.AddDependentObject(this.dVRSProfGeneralProxyTimeOutTimer_A41807);
			this.RefDVRSWide.General.RadErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911.AddDependentObject(this.dVRSProfGeneralProxyLimitPatienceTimer_A41808);
			this.RefDVRSWide.General.RadErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911.AddDependentObject(this.dVRSProfGeneralProxyRFSSReponseTimer_A41810);
			this.RefDVRSWide.General.RadErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911.AddDependentObject(this.dVRSProfGeneralGenStsOnDVRSModChgHoldoff_A41869);
			this.dVRSProfGeneralGenStsOnDVRSModChg_A41801.AddDependentObject(this.dVRSProfGeneralGenStsOnDVRSModChgHoldoff_A41869);
			this.RefDVRSWide.General.RadErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911.AddDependentObject(this.dVRSProfGeneralSuspendScanOnDVRSActive_42782);
		}

		// Token: 0x17004F86 RID: 20358
		// (get) Token: 0x06009E79 RID: 40569 RVA: 0x00940B54 File Offset: 0x0093ED54
		public bool HasDiffs
		{
			get
			{
				short num = (short)1801251592;
				short num2 = num;
				num = (short)1105783560;
				switch (num2 == num)
				{
				}
				num = (short)2032599041;
				if (num != 0)
				{
				}
				num = (short)48168960;
				short num3 = num;
				num = (short)115081216;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17004F87 RID: 20359
		// (get) Token: 0x06009E7A RID: 40570 RVA: 0x00940C04 File Offset: 0x0093EE04
		// (set) Token: 0x06009E7B RID: 40571 RVA: 0x00940CB8 File Offset: 0x0093EEB8
		public int DVRSProfGeneralDVRSRemoteActivation_A41800Value
		{
			get
			{
				short num = (short)808696119;
				short num2 = num;
				num = (short)1592113463;
				switch (num2 == num)
				{
				}
				num = (short)940113920;
				if (num != 0)
				{
				}
				num = (short)472121344;
				short num3 = num;
				num = (short)1114177537;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralDVRSRemoteActivation_A41800.Value;
			}
			set
			{
				short num = (short)1028036943;
				short num2 = num;
				num = (short)1539479887;
				switch (num2 == num)
				{
				}
				num = (short)258605056;
				if (num != 0)
				{
				}
				num = (short)2049966080;
				short num3 = num;
				num = (short)1988558849;
				if (num != 0)
				{
				}
				this.dVRSProfGeneralDVRSRemoteActivation_A41800.Value = value;
			}
		}

		// Token: 0x17004F88 RID: 20360
		// (get) Token: 0x06009E7C RID: 40572 RVA: 0x00940D70 File Offset: 0x0093EF70
		// (set) Token: 0x06009E7D RID: 40573 RVA: 0x00940E24 File Offset: 0x0093F024
		public string DVRSProfGeneralDVRSRemoteActivation_A41800_UIValue
		{
			get
			{
				short num = (short)1925663372;
				short num2 = num;
				num = (short)2016234124;
				switch (num2 == num)
				{
				}
				num = (short)543490049;
				if (num != 0)
				{
				}
				num = (short)1863712768;
				short num3 = num;
				num = (short)1859518464;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralDVRSRemoteActivation_A41800.UIValue;
			}
			set
			{
				short num = (short)1577084970;
				short num2 = num;
				num = (short)1793878058;
				switch (num2 == num)
				{
				}
				num = (short)2054356993;
				if (num != 0)
				{
				}
				num = (short)1488388096;
				short num3 = num;
				num = (short)940376064;
				if (num != 0)
				{
				}
				this.dVRSProfGeneralDVRSRemoteActivation_A41800.UIValue = value;
			}
		}

		// Token: 0x17004F89 RID: 20361
		// (get) Token: 0x06009E7E RID: 40574 RVA: 0x00940ED8 File Offset: 0x0093F0D8
		public global::AcpBusinessLayer.AcpListField DVRSProfGeneralDVRSRemoteActivation_A41800
		{
			get
			{
				short num = (short)1594489171;
				short num2 = num;
				num = (short)1362164051;
				switch (num2 == num)
				{
				}
				num = (short)1621753856;
				if (num != 0)
				{
				}
				num = (short)184221696;
				short num3 = num;
				num = (short)69861377;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralDVRSRemoteActivation_A41800;
			}
		}

		// Token: 0x17004F8A RID: 20362
		// (get) Token: 0x06009E7F RID: 40575 RVA: 0x00940F88 File Offset: 0x0093F188
		// (set) Token: 0x06009E80 RID: 40576 RVA: 0x0094103C File Offset: 0x0093F23C
		public bool DVRSProfGeneralDVRSRemoteActivation_A41800_Applicable
		{
			get
			{
				short num = (short)468794989;
				short num2 = num;
				num = (short)624836205;
				switch (num2 == num)
				{
				}
				num = (short)1739456513;
				if (num != 0)
				{
				}
				num = (short)1370685440;
				short num3 = num;
				num = (short)1463681024;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralDVRSRemoteActivation_A41800.Applicable;
			}
			set
			{
				short num = (short)1869676545;
				if (num != 0)
				{
				}
				num = (short)880481627;
				short num2 = num;
				num = (short)1781405019;
				switch (num2 == num)
				{
				}
				num = (short)424214528;
				short num3 = num;
				num = (short)384565248;
				if (num != 0)
				{
				}
				this.dVRSProfGeneralDVRSRemoteActivation_A41800.Applicable = value;
			}
		}

		// Token: 0x17004F8B RID: 20363
		// (get) Token: 0x06009E81 RID: 40577 RVA: 0x009410F0 File Offset: 0x0093F2F0
		// (set) Token: 0x06009E82 RID: 40578 RVA: 0x009411A4 File Offset: 0x0093F3A4
		public bool DVRSProfGeneralDVRSRemoteActivation_A41800_Valid
		{
			get
			{
				short num = (short)1468415091;
				short num2 = num;
				num = (short)727399539;
				switch (num2 == num)
				{
				}
				num = (short)835387393;
				if (num != 0)
				{
				}
				num = (short)1898446848;
				short num3 = num;
				num = (short)235012096;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralDVRSRemoteActivation_A41800.Valid;
			}
			set
			{
				short num = (short)1893414822;
				short num2 = num;
				num = (short)389232550;
				switch (num2 == num)
				{
				}
				num = (short)1067909120;
				if (num != 0)
				{
				}
				num = (short)418709504;
				short num3 = num;
				num = (short)1894252545;
				if (num != 0)
				{
				}
				this.dVRSProfGeneralDVRSRemoteActivation_A41800.Valid = value;
			}
		}

		// Token: 0x17004F8C RID: 20364
		// (get) Token: 0x06009E83 RID: 40579 RVA: 0x00941258 File Offset: 0x0093F458
		// (set) Token: 0x06009E84 RID: 40580 RVA: 0x00941310 File Offset: 0x0093F510
		public bool DVRSProfGeneralDVRSRemoteActivation_A41800_Visible
		{
			get
			{
				short num = (short)23396353;
				if (num != 0)
				{
				}
				num = (short)151825808;
				short num2 = num;
				num = (short)1026076048;
				switch (num2 == num)
				{
				}
				num = (short)2105212928;
				short num3 = num;
				num = (short)1613103104;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralDVRSRemoteActivation_A41800.Visible;
			}
			set
			{
				short num = (short)1043788007;
				short num2 = num;
				num = (short)486863079;
				switch (num2 == num)
				{
				}
				num = (short)101449728;
				if (num != 0)
				{
				}
				num = (short)1826553856;
				short num3 = num;
				num = (short)1778712577;
				if (num != 0)
				{
				}
				this.dVRSProfGeneralDVRSRemoteActivation_A41800.Visible = value;
			}
		}

		// Token: 0x17004F8D RID: 20365
		// (get) Token: 0x06009E85 RID: 40581 RVA: 0x009413C8 File Offset: 0x0093F5C8
		// (set) Token: 0x06009E86 RID: 40582 RVA: 0x0094147C File Offset: 0x0093F67C
		public bool DVRSProfGeneralDVRSRemoteActivation_A41800_Editable
		{
			get
			{
				short num = (short)1520718163;
				short num2 = num;
				num = (short)1283805523;
				switch (num2 == num)
				{
				}
				num = (short)1113653249;
				if (num != 0)
				{
				}
				num = (short)1965031424;
				short num3 = num;
				num = (short)338493440;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralDVRSRemoteActivation_A41800.Editable;
			}
			set
			{
				short num = (short)572831071;
				short num2 = num;
				num = (short)817476959;
				switch (num2 == num)
				{
				}
				num = (short)1947271169;
				if (num != 0)
				{
				}
				num = (short)347406336;
				short num3 = num;
				num = (short)535101440;
				if (num != 0)
				{
				}
				this.dVRSProfGeneralDVRSRemoteActivation_A41800.Editable = value;
			}
		}

		// Token: 0x17004F8E RID: 20366
		// (get) Token: 0x06009E87 RID: 40583 RVA: 0x00941534 File Offset: 0x0093F734
		internal string DVRSProfGeneralDVRSRemoteActivation_A41800_UILabel
		{
			get
			{
				short num = (short)1907224742;
				short num2 = num;
				num = (short)679997606;
				switch (num2 == num)
				{
				}
				num = (short)1122828289;
				if (num != 0)
				{
				}
				num = (short)898301952;
				short num3 = num;
				num = (short)1941372928;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralDVRSRemoteActivation_A41800.UIName;
			}
		}

		// Token: 0x17004F8F RID: 20367
		// (get) Token: 0x06009E88 RID: 40584 RVA: 0x009415E8 File Offset: 0x0093F7E8
		// (set) Token: 0x06009E89 RID: 40585 RVA: 0x0094169C File Offset: 0x0093F89C
		internal bool DVRSProfGeneralDVRSRemoteActivation_A41800_HiddenStatic
		{
			get
			{
				short num = (short)163875322;
				short num2 = num;
				num = (short)211519994;
				switch (num2 == num)
				{
				}
				num = (short)1134559233;
				if (num != 0)
				{
				}
				num = (short)152698880;
				short num3 = num;
				num = (short)1671757824;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralDVRSRemoteActivation_A41800.HiddenStatic;
			}
			set
			{
				short num = (short)44367873;
				if (num != 0)
				{
				}
				num = (short)1734237901;
				short num2 = num;
				num = (short)2114805453;
				switch (num2 == num)
				{
				}
				num = (short)1934426112;
				short num3 = num;
				num = (short)2098659328;
				if (num != 0)
				{
				}
				this.dVRSProfGeneralDVRSRemoteActivation_A41800.HiddenStatic = value;
			}
		}

		// Token: 0x17004F90 RID: 20368
		// (get) Token: 0x06009E8A RID: 40586 RVA: 0x00941750 File Offset: 0x0093F950
		// (set) Token: 0x06009E8B RID: 40587 RVA: 0x00941804 File Offset: 0x0093FA04
		internal bool DVRSProfGeneralDVRSRemoteActivation_A41800_HiddenDynamic
		{
			get
			{
				short num = (short)1407317838;
				short num2 = num;
				num = (short)3667790;
				switch (num2 == num)
				{
				}
				num = (short)853803009;
				if (num != 0)
				{
				}
				num = (short)2047934464;
				short num3 = num;
				num = (short)1736900608;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralDVRSRemoteActivation_A41800.HiddenDynamic;
			}
			set
			{
				short num = (short)1041497130;
				short num2 = num;
				num = (short)1762065450;
				switch (num2 == num)
				{
				}
				num = (short)1553661952;
				if (num != 0)
				{
				}
				num = (short)1944322048;
				short num3 = num;
				num = (short)1482948609;
				if (num != 0)
				{
				}
				this.dVRSProfGeneralDVRSRemoteActivation_A41800.HiddenDynamic = value;
			}
		}

		// Token: 0x17004F91 RID: 20369
		// (get) Token: 0x06009E8C RID: 40588 RVA: 0x009418B8 File Offset: 0x0093FAB8
		public bool DVRSProfGeneralDVRSRemoteActivation_A41800_HasDiffs
		{
			get
			{
				short num = (short)342900118;
				short num2 = num;
				num = (short)31276438;
				switch (num2 == num)
				{
				}
				num = (short)246218753;
				if (num != 0)
				{
				}
				num = (short)939720704;
				short num3 = num;
				num = (short)1804599296;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralDVRSRemoteActivation_A41800._HasDiffs;
			}
		}

		// Token: 0x17004F92 RID: 20370
		// (get) Token: 0x06009E8D RID: 40589 RVA: 0x0094196C File Offset: 0x0093FB6C
		// (set) Token: 0x06009E8E RID: 40590 RVA: 0x00941A24 File Offset: 0x0093FC24
		public bool DVRSProfGeneralGenStsOnDVRSModChg_A41801Value
		{
			get
			{
				short num = (short)207759859;
				short num2 = num;
				num = (short)1566648819;
				switch (num2 == num)
				{
				}
				num = (short)1081212928;
				if (num != 0)
				{
				}
				num = (short)148307968;
				short num3 = num;
				num = (short)1254359041;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralGenStsOnDVRSModChg_A41801.Value;
			}
			set
			{
				short num = (short)857693695;
				short num2 = num;
				num = (short)257252863;
				switch (num2 == num)
				{
				}
				num = (short)580255745;
				if (num != 0)
				{
				}
				num = (short)1318322176;
				short num3 = num;
				num = (short)1627127808;
				if (num != 0)
				{
				}
				this.dVRSProfGeneralGenStsOnDVRSModChg_A41801.Value = value;
			}
		}

		// Token: 0x17004F93 RID: 20371
		// (get) Token: 0x06009E8F RID: 40591 RVA: 0x00941AD8 File Offset: 0x0093FCD8
		public global::AcpBusinessLayer.AcpField<bool> DVRSProfGeneralGenStsOnDVRSModChg_A41801
		{
			get
			{
				short num = (short)1502779613;
				short num2 = num;
				num = (short)1452251357;
				switch (num2 == num)
				{
				}
				num = (short)128712705;
				if (num != 0)
				{
				}
				num = (short)962199552;
				short num3 = num;
				num = (short)2133721088;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralGenStsOnDVRSModChg_A41801;
			}
		}

		// Token: 0x17004F94 RID: 20372
		// (get) Token: 0x06009E90 RID: 40592 RVA: 0x00941B8C File Offset: 0x0093FD8C
		// (set) Token: 0x06009E91 RID: 40593 RVA: 0x00941C40 File Offset: 0x0093FE40
		public bool DVRSProfGeneralGenStsOnDVRSModChg_A41801_UIValue
		{
			get
			{
				short num = (short)185766079;
				short num2 = num;
				num = (short)1082757311;
				switch (num2 == num)
				{
				}
				num = (short)1489567744;
				if (num != 0)
				{
				}
				num = (short)68026368;
				short num3 = num;
				num = (short)611516417;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralGenStsOnDVRSModChg_A41801.Value;
			}
			set
			{
				short num = (short)1469439916;
				short num2 = num;
				num = (short)1706483628;
				switch (num2 == num)
				{
				}
				num = (short)162201600;
				if (num != 0)
				{
				}
				num = (short)587071488;
				short num3 = num;
				num = (short)1057554433;
				if (num != 0)
				{
				}
				this.dVRSProfGeneralGenStsOnDVRSModChg_A41801.Value = value;
			}
		}

		// Token: 0x17004F95 RID: 20373
		// (get) Token: 0x06009E92 RID: 40594 RVA: 0x00941CF4 File Offset: 0x0093FEF4
		// (set) Token: 0x06009E93 RID: 40595 RVA: 0x00941DA8 File Offset: 0x0093FFA8
		public bool DVRSProfGeneralGenStsOnDVRSModChg_A41801_Applicable
		{
			get
			{
				short num = (short)210563169;
				short num2 = num;
				num = (short)1671360609;
				switch (num2 == num)
				{
				}
				num = (short)2110455809;
				if (num != 0)
				{
				}
				num = (short)1882062848;
				short num3 = num;
				num = (short)1699414016;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralGenStsOnDVRSModChg_A41801.Applicable;
			}
			set
			{
				short num = (short)1473309185;
				short num2 = num;
				num = (short)1242229249;
				switch (num2 == num)
				{
				}
				num = (short)673710081;
				if (num != 0)
				{
				}
				num = (short)1829502976;
				short num3 = num;
				num = (short)9895936;
				if (num != 0)
				{
				}
				this.dVRSProfGeneralGenStsOnDVRSModChg_A41801.Applicable = value;
			}
		}

		// Token: 0x17004F96 RID: 20374
		// (get) Token: 0x06009E94 RID: 40596 RVA: 0x00941E60 File Offset: 0x00940060
		// (set) Token: 0x06009E95 RID: 40597 RVA: 0x00941F18 File Offset: 0x00940118
		public bool DVRSProfGeneralGenStsOnDVRSModChg_A41801_Valid
		{
			get
			{
				short num = (short)1915724744;
				short num2 = num;
				num = (short)2137826248;
				switch (num2 == num)
				{
				}
				num = (short)1991704577;
				if (num != 0)
				{
				}
				num = (short)549126144;
				short num3 = num;
				num = (short)1924726784;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralGenStsOnDVRSModChg_A41801.Valid;
			}
			set
			{
				short num = (short)92449668;
				short num2 = num;
				num = (short)1104784260;
				switch (num2 == num)
				{
				}
				num = (short)597819393;
				if (num != 0)
				{
				}
				num = (short)1979777024;
				short num3 = num;
				num = (short)75759616;
				if (num != 0)
				{
				}
				this.dVRSProfGeneralGenStsOnDVRSModChg_A41801.Valid = value;
			}
		}

		// Token: 0x17004F97 RID: 20375
		// (get) Token: 0x06009E96 RID: 40598 RVA: 0x00941FCC File Offset: 0x009401CC
		// (set) Token: 0x06009E97 RID: 40599 RVA: 0x00942084 File Offset: 0x00940284
		public bool DVRSProfGeneralGenStsOnDVRSModChg_A41801_Visible
		{
			get
			{
				short num = (short)311820289;
				if (num != 0)
				{
				}
				num = (short)1203437568;
				short num2 = num;
				num = (short)2141318892;
				short num3 = num;
				num = (short)1045950188;
				switch (num3 == num)
				{
				}
				num = (short)650444800;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralGenStsOnDVRSModChg_A41801.Visible;
			}
			set
			{
				short num = (short)1676093766;
				short num2 = num;
				num = (short)1393895750;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1837629440;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1940717569;
				if (num != 0)
				{
				}
				num = (short)1020723200;
				if (num != 0)
				{
				}
				this.dVRSProfGeneralGenStsOnDVRSModChg_A41801.Visible = value;
			}
		}

		// Token: 0x17004F98 RID: 20376
		// (get) Token: 0x06009E98 RID: 40600 RVA: 0x0094213C File Offset: 0x0094033C
		// (set) Token: 0x06009E99 RID: 40601 RVA: 0x009421F0 File Offset: 0x009403F0
		public bool DVRSProfGeneralGenStsOnDVRSModChg_A41801_Editable
		{
			get
			{
				short num = (short)1363011868;
				short num2 = num;
				num = (short)2128734492;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2144075776;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)445054977;
				if (num != 0)
				{
				}
				num = (short)1075707904;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralGenStsOnDVRSModChg_A41801.Editable;
			}
			set
			{
				short num = (short)1057685505;
				if (num != 0)
				{
				}
				num = (short)395444224;
				short num2 = num;
				num = (short)1678792240;
				short num3 = num;
				num = (short)1801475632;
				switch (num3 == num)
				{
				}
				num = (short)1510932480;
				if (num != 0)
				{
				}
				this.dVRSProfGeneralGenStsOnDVRSModChg_A41801.Editable = value;
			}
		}

		// Token: 0x17004F99 RID: 20377
		// (get) Token: 0x06009E9A RID: 40602 RVA: 0x009422A8 File Offset: 0x009404A8
		internal string DVRSProfGeneralGenStsOnDVRSModChg_A41801_UILabel
		{
			get
			{
				short num = (short)527575659;
				short num2 = num;
				num = (short)918497899;
				switch (num2 == num)
				{
				default:
				{
					num = (short)21692416;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)768671744;
				if (num != 0)
				{
				}
				num = (short)699990017;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralGenStsOnDVRSModChg_A41801.UIName;
			}
		}

		// Token: 0x17004F9A RID: 20378
		// (get) Token: 0x06009E9B RID: 40603 RVA: 0x00942358 File Offset: 0x00940558
		// (set) Token: 0x06009E9C RID: 40604 RVA: 0x0094240C File Offset: 0x0094060C
		internal bool DVRSProfGeneralGenStsOnDVRSModChg_A41801_HiddenStatic
		{
			get
			{
				short num = (short)1095693072;
				short num2 = num;
				num = (short)190509840;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1375141888;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1194065921;
				if (num != 0)
				{
				}
				num = (short)465960960;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralGenStsOnDVRSModChg_A41801.HiddenStatic;
			}
			set
			{
				short num = (short)837869454;
				short num2 = num;
				num = (short)710401934;
				switch (num2 == num)
				{
				default:
				{
					num = (short)799473664;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)162529281;
				if (num != 0)
				{
				}
				num = (short)1708457984;
				if (num != 0)
				{
				}
				this.dVRSProfGeneralGenStsOnDVRSModChg_A41801.HiddenStatic = value;
			}
		}

		// Token: 0x17004F9B RID: 20379
		// (get) Token: 0x06009E9D RID: 40605 RVA: 0x009424C0 File Offset: 0x009406C0
		// (set) Token: 0x06009E9E RID: 40606 RVA: 0x00942578 File Offset: 0x00940778
		internal bool DVRSProfGeneralGenStsOnDVRSModChg_A41801_HiddenDynamic
		{
			get
			{
				short num = (short)1808898744;
				short num2 = num;
				num = (short)105618104;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1236860928;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)270663680;
				if (num != 0)
				{
				}
				num = (short)152043521;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralGenStsOnDVRSModChg_A41801.HiddenDynamic;
			}
			set
			{
				short num = (short)348097447;
				short num2 = num;
				num = (short)660769703;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1336147968;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1240858624;
				if (num != 0)
				{
				}
				num = (short)39583745;
				if (num != 0)
				{
				}
				this.dVRSProfGeneralGenStsOnDVRSModChg_A41801.HiddenDynamic = value;
			}
		}

		// Token: 0x17004F9C RID: 20380
		// (get) Token: 0x06009E9F RID: 40607 RVA: 0x0094262C File Offset: 0x0094082C
		public bool DVRSProfGeneralGenStsOnDVRSModChg_A41801_HasDiffs
		{
			get
			{
				short num = (short)2063078869;
				short num2 = num;
				num = (short)745805269;
				switch (num2 == num)
				{
				default:
				{
					num = (short)340328448;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1898708993;
				if (num != 0)
				{
				}
				num = (short)1313079296;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralGenStsOnDVRSModChg_A41801._HasDiffs;
			}
		}

		// Token: 0x17004F9D RID: 20381
		// (get) Token: 0x06009EA0 RID: 40608 RVA: 0x009426E0 File Offset: 0x009408E0
		// (set) Token: 0x06009EA1 RID: 40609 RVA: 0x00942794 File Offset: 0x00940994
		public bool DVRSProfGeneralICMAllowed_A41802Value
		{
			get
			{
				short num = (short)493440128;
				short num2 = num;
				num = (short)1141197952;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1626341376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1622605825;
				if (num != 0)
				{
				}
				num = (short)962658304;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralICMAllowed_A41802.Value;
			}
			set
			{
				short num = (short)1128907591;
				short num2 = num;
				num = (short)301646663;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1602682880;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)725680128;
				if (num != 0)
				{
				}
				num = (short)308674561;
				if (num != 0)
				{
				}
				this.dVRSProfGeneralICMAllowed_A41802.Value = value;
			}
		}

		// Token: 0x17004F9E RID: 20382
		// (get) Token: 0x06009EA2 RID: 40610 RVA: 0x00942848 File Offset: 0x00940A48
		public global::AcpBusinessLayer.AcpField<bool> DVRSProfGeneralICMAllowed_A41802
		{
			get
			{
				short num = (short)576589291;
				short num2 = num;
				num = (short)191368683;
				switch (num2 == num)
				{
				default:
				{
					num = (short)606208000;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1380057089;
				if (num != 0)
				{
				}
				num = (short)805765120;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralICMAllowed_A41802;
			}
		}

		// Token: 0x17004F9F RID: 20383
		// (get) Token: 0x06009EA3 RID: 40611 RVA: 0x009428F8 File Offset: 0x00940AF8
		// (set) Token: 0x06009EA4 RID: 40612 RVA: 0x009429AC File Offset: 0x00940BAC
		public bool DVRSProfGeneralICMAllowed_A41802_UIValue
		{
			get
			{
				short num = (short)1512505345;
				if (num != 0)
				{
				}
				num = (short)280166400;
				short num2 = num;
				num = (short)1717135593;
				short num3 = num;
				num = (short)2120378601;
				switch (num3 == num)
				{
				}
				num = (short)1763901440;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralICMAllowed_A41802.Value;
			}
			set
			{
				short num = (short)209635811;
				short num2 = num;
				num = (short)1087621603;
				switch (num2 == num)
				{
				default:
				{
					num = (short)954597376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1373241345;
				if (num != 0)
				{
				}
				num = (short)633405440;
				if (num != 0)
				{
				}
				this.dVRSProfGeneralICMAllowed_A41802.Value = value;
			}
		}

		// Token: 0x17004FA0 RID: 20384
		// (get) Token: 0x06009EA5 RID: 40613 RVA: 0x00942A60 File Offset: 0x00940C60
		// (set) Token: 0x06009EA6 RID: 40614 RVA: 0x00942B1C File Offset: 0x00940D1C
		public bool DVRSProfGeneralICMAllowed_A41802_Applicable
		{
			get
			{
				short num = (short)447350014;
				short num2 = num;
				num = (short)2039284990;
				switch (num2 == num)
				{
				default:
				{
					num = (short)111017984;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1619329024;
				if (num != 0)
				{
				}
				num = (short)1779105793;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralICMAllowed_A41802.Applicable;
			}
			set
			{
				short num = (short)1276498570;
				short num2 = num;
				num = (short)447468170;
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
				num = (short)1232076800;
				if (num != 0)
				{
				}
				num = (short)711917569;
				if (num != 0)
				{
				}
				this.dVRSProfGeneralICMAllowed_A41802.Applicable = value;
			}
		}

		// Token: 0x17004FA1 RID: 20385
		// (get) Token: 0x06009EA7 RID: 40615 RVA: 0x00942BD4 File Offset: 0x00940DD4
		// (set) Token: 0x06009EA8 RID: 40616 RVA: 0x00942C88 File Offset: 0x00940E88
		public bool DVRSProfGeneralICMAllowed_A41802_Valid
		{
			get
			{
				short num = (short)1163287882;
				short num2 = num;
				num = (short)1231576394;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1513947136;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1662320640;
				if (num != 0)
				{
				}
				num = (short)951451649;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralICMAllowed_A41802.Valid;
			}
			set
			{
				short num = (short)1312451232;
				short num2 = num;
				num = (short)130575008;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2036203520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)440336384;
				if (num != 0)
				{
				}
				num = (short)1795620865;
				if (num != 0)
				{
				}
				this.dVRSProfGeneralICMAllowed_A41802.Valid = value;
			}
		}

		// Token: 0x17004FA2 RID: 20386
		// (get) Token: 0x06009EA9 RID: 40617 RVA: 0x00942D3C File Offset: 0x00940F3C
		// (set) Token: 0x06009EAA RID: 40618 RVA: 0x00942DF0 File Offset: 0x00940FF0
		public bool DVRSProfGeneralICMAllowed_A41802_Visible
		{
			get
			{
				short num = (short)1322639916;
				short num2 = num;
				num = (short)369091116;
				switch (num2 == num)
				{
				default:
				{
					num = (short)265420800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)151650305;
				if (num != 0)
				{
				}
				num = (short)1630404608;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralICMAllowed_A41802.Visible;
			}
			set
			{
				short num = (short)116147282;
				short num2 = num;
				num = (short)555369554;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1315504128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1653538817;
				if (num != 0)
				{
				}
				num = (short)913899520;
				if (num != 0)
				{
				}
				this.dVRSProfGeneralICMAllowed_A41802.Visible = value;
			}
		}

		// Token: 0x17004FA3 RID: 20387
		// (get) Token: 0x06009EAB RID: 40619 RVA: 0x00942EA4 File Offset: 0x009410A4
		// (set) Token: 0x06009EAC RID: 40620 RVA: 0x00942F58 File Offset: 0x00941158
		public bool DVRSProfGeneralICMAllowed_A41802_Editable
		{
			get
			{
				short num = (short)1961164801;
				if (num != 0)
				{
				}
				num = (short)1413545984;
				short num2 = num;
				num = (short)1494915867;
				short num3 = num;
				num = (short)1271044891;
				switch (num3 == num)
				{
				}
				num = (short)935591936;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralICMAllowed_A41802.Editable;
			}
			set
			{
				short num = (short)650599415;
				short num2 = num;
				num = (short)2100976631;
				switch (num2 == num)
				{
				default:
				{
					num = (short)420151296;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1717436417;
				if (num != 0)
				{
				}
				num = (short)321257472;
				if (num != 0)
				{
				}
				this.dVRSProfGeneralICMAllowed_A41802.Editable = value;
			}
		}

		// Token: 0x17004FA4 RID: 20388
		// (get) Token: 0x06009EAD RID: 40621 RVA: 0x00943010 File Offset: 0x00941210
		internal string DVRSProfGeneralICMAllowed_A41802_UILabel
		{
			get
			{
				short num = (short)1306198017;
				if (num != 0)
				{
				}
				num = (short)775028736;
				short num2 = num;
				num = (short)520928872;
				short num3 = num;
				num = (short)1288814184;
				switch (num3 == num)
				{
				}
				num = (short)2092105728;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralICMAllowed_A41802.UIName;
			}
		}

		// Token: 0x17004FA5 RID: 20389
		// (get) Token: 0x06009EAE RID: 40622 RVA: 0x009430C4 File Offset: 0x009412C4
		// (set) Token: 0x06009EAF RID: 40623 RVA: 0x00943178 File Offset: 0x00941378
		internal bool DVRSProfGeneralICMAllowed_A41802_HiddenStatic
		{
			get
			{
				short num = (short)1784320829;
				short num2 = num;
				num = (short)756192061;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1800273920;
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
				num = (short)1910833152;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralICMAllowed_A41802.HiddenStatic;
			}
			set
			{
				short num = (short)538372733;
				short num2 = num;
				num = (short)1164503677;
				switch (num2 == num)
				{
				default:
				{
					num = (short)300154880;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)64159744;
				if (num != 0)
				{
				}
				num = (short)1164509185;
				if (num != 0)
				{
				}
				this.dVRSProfGeneralICMAllowed_A41802.HiddenStatic = value;
			}
		}

		// Token: 0x17004FA6 RID: 20390
		// (get) Token: 0x06009EB0 RID: 40624 RVA: 0x00943230 File Offset: 0x00941430
		// (set) Token: 0x06009EB1 RID: 40625 RVA: 0x009432E8 File Offset: 0x009414E8
		internal bool DVRSProfGeneralICMAllowed_A41802_HiddenDynamic
		{
			get
			{
				short num = (short)1303547144;
				short num2 = num;
				num = (short)941722888;
				switch (num2 == num)
				{
				default:
				{
					num = (short)42467328;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)594870272;
				if (num != 0)
				{
				}
				num = (short)402391041;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralICMAllowed_A41802.HiddenDynamic;
			}
			set
			{
				short num = (short)1726292058;
				short num2 = num;
				num = (short)648618074;
				switch (num2 == num)
				{
				default:
				{
					num = (short)162529280;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)330301441;
				if (num != 0)
				{
				}
				num = (short)73138176;
				if (num != 0)
				{
				}
				this.dVRSProfGeneralICMAllowed_A41802.HiddenDynamic = value;
			}
		}

		// Token: 0x17004FA7 RID: 20391
		// (get) Token: 0x06009EB2 RID: 40626 RVA: 0x0094339C File Offset: 0x0094159C
		public bool DVRSProfGeneralICMAllowed_A41802_HasDiffs
		{
			get
			{
				short num = (short)235405313;
				if (num != 0)
				{
				}
				num = (short)713490432;
				short num2 = num;
				num = (short)195496079;
				short num3 = num;
				num = (short)1862600847;
				switch (num3 == num)
				{
				}
				num = (short)87097344;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralICMAllowed_A41802._HasDiffs;
			}
		}

		// Token: 0x17004FA8 RID: 20392
		// (get) Token: 0x06009EB3 RID: 40627 RVA: 0x00943458 File Offset: 0x00941658
		// (set) Token: 0x06009EB4 RID: 40628 RVA: 0x00943510 File Offset: 0x00941710
		public bool DVRSProfGeneralMSUSysPTTInLocalMode_A41803Value
		{
			get
			{
				short num = (short)1329490656;
				short num2 = num;
				num = (short)25586400;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1184038912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1546846209;
				if (num != 0)
				{
				}
				num = (short)1480392704;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralMSUSysPTTInLocalMode_A41803.Value;
			}
			set
			{
				short num = (short)145651657;
				short num2 = num;
				num = (short)796424137;
				switch (num2 == num)
				{
				default:
				{
					num = (short)175636480;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)514654208;
				if (num != 0)
				{
				}
				num = (short)1438777345;
				if (num != 0)
				{
				}
				this.dVRSProfGeneralMSUSysPTTInLocalMode_A41803.Value = value;
			}
		}

		// Token: 0x17004FA9 RID: 20393
		// (get) Token: 0x06009EB5 RID: 40629 RVA: 0x009435C8 File Offset: 0x009417C8
		public global::AcpBusinessLayer.AcpField<bool> DVRSProfGeneralMSUSysPTTInLocalMode_A41803
		{
			get
			{
				short num = (short)1143541586;
				short num2 = num;
				num = (short)1130172242;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1906835456;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)27525121;
				if (num != 0)
				{
				}
				num = (short)711000064;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralMSUSysPTTInLocalMode_A41803;
			}
		}

		// Token: 0x17004FAA RID: 20394
		// (get) Token: 0x06009EB6 RID: 40630 RVA: 0x00943678 File Offset: 0x00941878
		// (set) Token: 0x06009EB7 RID: 40631 RVA: 0x00943730 File Offset: 0x00941930
		public bool DVRSProfGeneralMSUSysPTTInLocalMode_A41803_UIValue
		{
			get
			{
				short num = (short)1349517313;
				if (num != 0)
				{
				}
				num = (short)2129199104;
				short num2 = num;
				num = (short)939629221;
				short num3 = num;
				num = (short)949918373;
				switch (num3 == num)
				{
				}
				num = (short)1278869504;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralMSUSysPTTInLocalMode_A41803.Value;
			}
			set
			{
				short num = (short)1131375062;
				short num2 = num;
				num = (short)81553878;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1071710208;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1171062785;
				if (num != 0)
				{
				}
				num = (short)272039936;
				if (num != 0)
				{
				}
				this.dVRSProfGeneralMSUSysPTTInLocalMode_A41803.Value = value;
			}
		}

		// Token: 0x17004FAB RID: 20395
		// (get) Token: 0x06009EB8 RID: 40632 RVA: 0x009437E8 File Offset: 0x009419E8
		// (set) Token: 0x06009EB9 RID: 40633 RVA: 0x0094389C File Offset: 0x00941A9C
		public bool DVRSProfGeneralMSUSysPTTInLocalMode_A41803_Applicable
		{
			get
			{
				short num = (short)665931142;
				short num2 = num;
				num = (short)556289414;
				switch (num2 == num)
				{
				default:
				{
					num = (short)834207744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1708916737;
				if (num != 0)
				{
				}
				num = (short)419627008;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralMSUSysPTTInLocalMode_A41803.Applicable;
			}
			set
			{
				short num = (short)1349652063;
				short num2 = num;
				num = (short)142675551;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1768488960;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)21757953;
				if (num != 0)
				{
				}
				num = (short)2111766528;
				if (num != 0)
				{
				}
				this.dVRSProfGeneralMSUSysPTTInLocalMode_A41803.Applicable = value;
			}
		}

		// Token: 0x17004FAC RID: 20396
		// (get) Token: 0x06009EBA RID: 40634 RVA: 0x00943950 File Offset: 0x00941B50
		// (set) Token: 0x06009EBB RID: 40635 RVA: 0x00943A08 File Offset: 0x00941C08
		public bool DVRSProfGeneralMSUSysPTTInLocalMode_A41803_Valid
		{
			get
			{
				short num = (short)797295731;
				short num2 = num;
				num = (short)1714996339;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1025376256;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)331874305;
				if (num != 0)
				{
				}
				num = (short)2125332480;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralMSUSysPTTInLocalMode_A41803.Valid;
			}
			set
			{
				short num = (short)25664183;
				short num2 = num;
				num = (short)1709218487;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1019150336;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)213254144;
				if (num != 0)
				{
				}
				num = (short)336330753;
				if (num != 0)
				{
				}
				this.dVRSProfGeneralMSUSysPTTInLocalMode_A41803.Valid = value;
			}
		}

		// Token: 0x17004FAD RID: 20397
		// (get) Token: 0x06009EBC RID: 40636 RVA: 0x00943AC0 File Offset: 0x00941CC0
		// (set) Token: 0x06009EBD RID: 40637 RVA: 0x00943B78 File Offset: 0x00941D78
		public bool DVRSProfGeneralMSUSysPTTInLocalMode_A41803_Visible
		{
			get
			{
				short num = (short)2147165927;
				short num2 = num;
				num = (short)1892034279;
				switch (num2 == num)
				{
				default:
				{
					num = (short)199557120;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1331101696;
				if (num != 0)
				{
				}
				num = (short)1362690049;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralMSUSysPTTInLocalMode_A41803.Visible;
			}
			set
			{
				short num = (short)673694287;
				short num2 = num;
				num = (short)1536672335;
				switch (num2 == num)
				{
				default:
				{
					num = (short)466681856;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1827995649;
				if (num != 0)
				{
				}
				num = (short)291700736;
				if (num != 0)
				{
				}
				this.dVRSProfGeneralMSUSysPTTInLocalMode_A41803.Visible = value;
			}
		}

		// Token: 0x17004FAE RID: 20398
		// (get) Token: 0x06009EBE RID: 40638 RVA: 0x00943C30 File Offset: 0x00941E30
		// (set) Token: 0x06009EBF RID: 40639 RVA: 0x00943CE4 File Offset: 0x00941EE4
		public bool DVRSProfGeneralMSUSysPTTInLocalMode_A41803_Editable
		{
			get
			{
				short num = (short)685183256;
				short num2 = num;
				num = (short)1159663896;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1446641664;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)647888896;
				if (num != 0)
				{
				}
				num = (short)431554561;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralMSUSysPTTInLocalMode_A41803.Editable;
			}
			set
			{
				short num = (short)2084106049;
				short num2 = num;
				num = (short)743894849;
				switch (num2 == num)
				{
				default:
				{
					num = (short)773062656;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)820314112;
				if (num != 0)
				{
				}
				num = (short)699596801;
				if (num != 0)
				{
				}
				this.dVRSProfGeneralMSUSysPTTInLocalMode_A41803.Editable = value;
			}
		}

		// Token: 0x17004FAF RID: 20399
		// (get) Token: 0x06009EC0 RID: 40640 RVA: 0x00943D9C File Offset: 0x00941F9C
		internal string DVRSProfGeneralMSUSysPTTInLocalMode_A41803_UILabel
		{
			get
			{
				short num = (short)2124873729;
				if (num != 0)
				{
				}
				num = (short)315097088;
				short num2 = num;
				num = (short)140956454;
				short num3 = num;
				num = (short)1002558246;
				switch (num3 == num)
				{
				}
				num = (short)1911357440;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralMSUSysPTTInLocalMode_A41803.UIName;
			}
		}

		// Token: 0x17004FB0 RID: 20400
		// (get) Token: 0x06009EC1 RID: 40641 RVA: 0x00943E4C File Offset: 0x0094204C
		// (set) Token: 0x06009EC2 RID: 40642 RVA: 0x00943F00 File Offset: 0x00942100
		internal bool DVRSProfGeneralMSUSysPTTInLocalMode_A41803_HiddenStatic
		{
			get
			{
				short num = (short)854385016;
				short num2 = num;
				num = (short)1389289848;
				switch (num2 == num)
				{
				default:
				{
					num = (short)686555136;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1643511809;
				if (num != 0)
				{
				}
				num = (short)426442752;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralMSUSysPTTInLocalMode_A41803.HiddenStatic;
			}
			set
			{
				short num = (short)1792278528;
				short num2 = num;
				num = (short)1580969898;
				short num3 = num;
				num = (short)30322602;
				switch (num3 == num)
				{
				}
				num = (short)1831665665;
				if (num != 0)
				{
				}
				num = (short)345440256;
				if (num != 0)
				{
				}
				this.dVRSProfGeneralMSUSysPTTInLocalMode_A41803.HiddenStatic = value;
			}
		}

		// Token: 0x17004FB1 RID: 20401
		// (get) Token: 0x06009EC3 RID: 40643 RVA: 0x00943FB4 File Offset: 0x009421B4
		// (set) Token: 0x06009EC4 RID: 40644 RVA: 0x00944068 File Offset: 0x00942268
		internal bool DVRSProfGeneralMSUSysPTTInLocalMode_A41803_HiddenDynamic
		{
			get
			{
				short num = (short)2134507520;
				short num2 = num;
				num = (short)653294158;
				short num3 = num;
				num = (short)1218869838;
				switch (num3 == num)
				{
				}
				num = (short)605421569;
				if (num != 0)
				{
				}
				num = (short)191037440;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralMSUSysPTTInLocalMode_A41803.HiddenDynamic;
			}
			set
			{
				short num = (short)265224192;
				short num2 = num;
				num = (short)708123656;
				short num3 = num;
				num = (short)522460168;
				switch (num3 == num)
				{
				}
				num = (short)1208025088;
				if (num != 0)
				{
				}
				num = (short)954793985;
				if (num != 0)
				{
				}
				this.dVRSProfGeneralMSUSysPTTInLocalMode_A41803.HiddenDynamic = value;
			}
		}

		// Token: 0x17004FB2 RID: 20402
		// (get) Token: 0x06009EC5 RID: 40645 RVA: 0x0094411C File Offset: 0x0094231C
		public bool DVRSProfGeneralMSUSysPTTInLocalMode_A41803_HasDiffs
		{
			get
			{
				short num = (short)842661888;
				short num2 = num;
				num = (short)575010070;
				short num3 = num;
				num = (short)28898582;
				switch (num3 == num)
				{
				}
				num = (short)742064129;
				if (num != 0)
				{
				}
				num = (short)1424752640;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralMSUSysPTTInLocalMode_A41803._HasDiffs;
			}
		}

		// Token: 0x17004FB3 RID: 20403
		// (get) Token: 0x06009EC6 RID: 40646 RVA: 0x009441D0 File Offset: 0x009423D0
		// (set) Token: 0x06009EC7 RID: 40647 RVA: 0x00944284 File Offset: 0x00942484
		public bool DVRSProfGeneralOutSysRepLocalMode_A41804Value
		{
			get
			{
				short num = (short)748421120;
				short num2 = num;
				num = (short)955502330;
				short num3 = num;
				num = (short)996069114;
				switch (num3 == num)
				{
				}
				num = (short)1450967041;
				if (num != 0)
				{
				}
				num = (short)1794703360;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralOutSysRepLocalMode_A41804.Value;
			}
			set
			{
				short num = (short)841809920;
				short num2 = num;
				num = (short)1681296320;
				short num3 = num;
				num = (short)613321664;
				switch (num3 == num)
				{
				}
				num = (short)1424359424;
				if (num != 0)
				{
				}
				num = (short)1449525249;
				if (num != 0)
				{
				}
				this.dVRSProfGeneralOutSysRepLocalMode_A41804.Value = value;
			}
		}

		// Token: 0x17004FB4 RID: 20404
		// (get) Token: 0x06009EC8 RID: 40648 RVA: 0x00944338 File Offset: 0x00942538
		public global::AcpBusinessLayer.AcpField<bool> DVRSProfGeneralOutSysRepLocalMode_A41804
		{
			get
			{
				short num = (short)1105657856;
				short num2 = num;
				num = (short)1983053825;
				if (num != 0)
				{
				}
				num = (short)616697121;
				short num3 = num;
				num = (short)881331489;
				switch (num3 == num)
				{
				}
				num = (short)476905472;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralOutSysRepLocalMode_A41804;
			}
		}

		// Token: 0x17004FB5 RID: 20405
		// (get) Token: 0x06009EC9 RID: 40649 RVA: 0x009443E8 File Offset: 0x009425E8
		// (set) Token: 0x06009ECA RID: 40650 RVA: 0x0094449C File Offset: 0x0094269C
		public bool DVRSProfGeneralOutSysRepLocalMode_A41804_UIValue
		{
			get
			{
				short num = (short)1716846592;
				short num2 = num;
				num = (short)1446482710;
				short num3 = num;
				num = (short)678007574;
				switch (num3 == num)
				{
				}
				num = (short)420478977;
				if (num != 0)
				{
				}
				num = (short)95617024;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralOutSysRepLocalMode_A41804.Value;
			}
			set
			{
				short num = (short)115474432;
				short num2 = num;
				num = (short)261324641;
				short num3 = num;
				num = (short)632455009;
				switch (num3 == num)
				{
				}
				num = (short)1689387009;
				if (num != 0)
				{
				}
				num = (short)510066688;
				if (num != 0)
				{
				}
				this.dVRSProfGeneralOutSysRepLocalMode_A41804.Value = value;
			}
		}

		// Token: 0x17004FB6 RID: 20406
		// (get) Token: 0x06009ECB RID: 40651 RVA: 0x00944550 File Offset: 0x00942750
		// (set) Token: 0x06009ECC RID: 40652 RVA: 0x00944604 File Offset: 0x00942804
		public bool DVRSProfGeneralOutSysRepLocalMode_A41804_Applicable
		{
			get
			{
				short num = (short)2020605952;
				short num2 = num;
				num = (short)489603483;
				short num3 = num;
				num = (short)1216070043;
				switch (num3 == num)
				{
				}
				num = (short)1676148736;
				if (num != 0)
				{
				}
				num = (short)2041511937;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralOutSysRepLocalMode_A41804.Applicable;
			}
			set
			{
				short num = (short)1755250688;
				short num2 = num;
				num = (short)57829169;
				short num3 = num;
				num = (short)1920624433;
				switch (num3 == num)
				{
				}
				num = (short)485425152;
				if (num != 0)
				{
				}
				num = (short)316604417;
				if (num != 0)
				{
				}
				this.dVRSProfGeneralOutSysRepLocalMode_A41804.Applicable = value;
			}
		}

		// Token: 0x17004FB7 RID: 20407
		// (get) Token: 0x06009ECD RID: 40653 RVA: 0x009446BC File Offset: 0x009428BC
		// (set) Token: 0x06009ECE RID: 40654 RVA: 0x00944770 File Offset: 0x00942970
		public bool DVRSProfGeneralOutSysRepLocalMode_A41804_Valid
		{
			get
			{
				short num = (short)1045299200;
				short num2 = num;
				num = (short)249385937;
				short num3 = num;
				num = (short)342119377;
				switch (num3 == num)
				{
				}
				num = (short)1906769920;
				if (num != 0)
				{
				}
				num = (short)1253900289;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralOutSysRepLocalMode_A41804.Valid;
			}
			set
			{
				short num = (short)1507721216;
				short num2 = num;
				num = (short)1931922767;
				short num3 = num;
				num = (short)1249627471;
				switch (num3 == num)
				{
				}
				num = (short)212074496;
				if (num != 0)
				{
				}
				num = (short)1646919681;
				if (num != 0)
				{
				}
				this.dVRSProfGeneralOutSysRepLocalMode_A41804.Valid = value;
			}
		}

		// Token: 0x17004FB8 RID: 20408
		// (get) Token: 0x06009ECF RID: 40655 RVA: 0x00944824 File Offset: 0x00942A24
		// (set) Token: 0x06009ED0 RID: 40656 RVA: 0x009448D8 File Offset: 0x00942AD8
		public bool DVRSProfGeneralOutSysRepLocalMode_A41804_Visible
		{
			get
			{
				short num = (short)1059848192;
				short num2 = num;
				num = (short)1529293492;
				short num3 = num;
				num = (short)1914645172;
				switch (num3 == num)
				{
				}
				num = (short)105578497;
				if (num != 0)
				{
				}
				num = (short)740753408;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralOutSysRepLocalMode_A41804.Visible;
			}
			set
			{
				short num = (short)451149824;
				short num2 = num;
				num = (short)514376434;
				short num3 = num;
				num = (short)1354351346;
				switch (num3 == num)
				{
				}
				num = (short)1328283649;
				if (num != 0)
				{
				}
				num = (short)1462632448;
				if (num != 0)
				{
				}
				this.dVRSProfGeneralOutSysRepLocalMode_A41804.Visible = value;
			}
		}

		// Token: 0x17004FB9 RID: 20409
		// (get) Token: 0x06009ED1 RID: 40657 RVA: 0x00944990 File Offset: 0x00942B90
		// (set) Token: 0x06009ED2 RID: 40658 RVA: 0x00944A44 File Offset: 0x00942C44
		public bool DVRSProfGeneralOutSysRepLocalMode_A41804_Editable
		{
			get
			{
				short num = (short)426573824;
				short num2 = num;
				num = (short)1159741421;
				short num3 = num;
				num = (short)1845641197;
				switch (num3 == num)
				{
				}
				num = (short)1879113728;
				if (num != 0)
				{
				}
				num = (short)1701183489;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralOutSysRepLocalMode_A41804.Editable;
			}
			set
			{
				short num = (short)779485184;
				short num2 = num;
				num = (short)452290055;
				short num3 = num;
				num = (short)1693672967;
				switch (num3 == num)
				{
				}
				num = (short)1422721025;
				if (num != 0)
				{
				}
				num = (short)1186725888;
				if (num != 0)
				{
				}
				this.dVRSProfGeneralOutSysRepLocalMode_A41804.Editable = value;
			}
		}

		// Token: 0x17004FBA RID: 20410
		// (get) Token: 0x06009ED3 RID: 40659 RVA: 0x00944AF8 File Offset: 0x00942CF8
		internal string DVRSProfGeneralOutSysRepLocalMode_A41804_UILabel
		{
			get
			{
				short num = (short)1292369920;
				short num2 = num;
				num = (short)788381492;
				short num3 = num;
				num = (short)819642164;
				switch (num3 == num)
				{
				}
				num = (short)593100800;
				if (num != 0)
				{
				}
				num = (short)1394147329;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralOutSysRepLocalMode_A41804.UIName;
			}
		}

		// Token: 0x17004FBB RID: 20411
		// (get) Token: 0x06009ED4 RID: 40660 RVA: 0x00944BAC File Offset: 0x00942DAC
		// (set) Token: 0x06009ED5 RID: 40661 RVA: 0x00944C60 File Offset: 0x00942E60
		internal bool DVRSProfGeneralOutSysRepLocalMode_A41804_HiddenStatic
		{
			get
			{
				short num = (short)846659584;
				short num2 = num;
				num = (short)1622381096;
				short num3 = num;
				num = (short)1503367720;
				switch (num3 == num)
				{
				}
				num = (short)1995177984;
				if (num != 0)
				{
				}
				num = (short)705101825;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralOutSysRepLocalMode_A41804.HiddenStatic;
			}
			set
			{
				short num = (short)130809856;
				short num2 = num;
				num = (short)367730886;
				short num3 = num;
				num = (short)1427382470;
				switch (num3 == num)
				{
				}
				num = (short)1396113409;
				if (num != 0)
				{
				}
				num = (short)361824256;
				if (num != 0)
				{
				}
				this.dVRSProfGeneralOutSysRepLocalMode_A41804.HiddenStatic = value;
			}
		}

		// Token: 0x17004FBC RID: 20412
		// (get) Token: 0x06009ED6 RID: 40662 RVA: 0x00944D18 File Offset: 0x00942F18
		// (set) Token: 0x06009ED7 RID: 40663 RVA: 0x00944DD0 File Offset: 0x00942FD0
		internal bool DVRSProfGeneralOutSysRepLocalMode_A41804_HiddenDynamic
		{
			get
			{
				short num = (short)1767112704;
				short num2 = num;
				num = (short)1118674444;
				short num3 = num;
				num = (short)1097047564;
				switch (num3 == num)
				{
				}
				num = (short)368115713;
				if (num != 0)
				{
				}
				num = (short)1590231040;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralOutSysRepLocalMode_A41804.HiddenDynamic;
			}
			set
			{
				short num = (short)731185152;
				short num2 = num;
				num = (short)254688558;
				short num3 = num;
				num = (short)918895918;
				switch (num3 == num)
				{
				}
				num = (short)43646976;
				if (num != 0)
				{
				}
				num = (short)1065025537;
				if (num != 0)
				{
				}
				this.dVRSProfGeneralOutSysRepLocalMode_A41804.HiddenDynamic = value;
			}
		}

		// Token: 0x17004FBD RID: 20413
		// (get) Token: 0x06009ED8 RID: 40664 RVA: 0x00944E88 File Offset: 0x00943088
		public bool DVRSProfGeneralOutSysRepLocalMode_A41804_HasDiffs
		{
			get
			{
				short num = (short)499253248;
				short num2 = num;
				num = (short)382216354;
				short num3 = num;
				num = (short)590227618;
				switch (num3 == num)
				{
				}
				num = (short)1680605185;
				if (num != 0)
				{
				}
				num = (short)1211826176;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralOutSysRepLocalMode_A41804._HasDiffs;
			}
		}

		// Token: 0x17004FBE RID: 20414
		// (get) Token: 0x06009ED9 RID: 40665 RVA: 0x00944F3C File Offset: 0x0094313C
		// (set) Token: 0x06009EDA RID: 40666 RVA: 0x00944FF0 File Offset: 0x009431F0
		public bool DVRSProfGeneralRouteMSUPTTMicAudToDVR_A41805Value
		{
			get
			{
				short num = (short)161349632;
				short num2 = num;
				num = (short)1493804052;
				short num3 = num;
				num = (short)863347732;
				switch (num3 == num)
				{
				}
				num = (short)850722817;
				if (num != 0)
				{
				}
				num = (short)663879680;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralRouteMSUPTTMicAudToDVR_A41805.Value;
			}
			set
			{
				short num = (short)1576992768;
				short num2 = num;
				num = (short)843651938;
				short num3 = num;
				num = (short)357702498;
				switch (num3 == num)
				{
				}
				num = (short)74317824;
				if (num != 0)
				{
				}
				num = (short)1717698561;
				if (num != 0)
				{
				}
				this.dVRSProfGeneralRouteMSUPTTMicAudToDVR_A41805.Value = value;
			}
		}

		// Token: 0x17004FBF RID: 20415
		// (get) Token: 0x06009EDB RID: 40667 RVA: 0x009450A8 File Offset: 0x009432A8
		public global::AcpBusinessLayer.AcpField<bool> DVRSProfGeneralRouteMSUPTTMicAudToDVR_A41805
		{
			get
			{
				short num = (short)1015152640;
				short num2 = num;
				num = (short)1667956737;
				if (num != 0)
				{
				}
				num = (short)704101251;
				short num3 = num;
				num = (short)160676739;
				switch (num3 == num)
				{
				}
				num = (short)1931018240;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralRouteMSUPTTMicAudToDVR_A41805;
			}
		}

		// Token: 0x17004FC0 RID: 20416
		// (get) Token: 0x06009EDC RID: 40668 RVA: 0x00945158 File Offset: 0x00943358
		// (set) Token: 0x06009EDD RID: 40669 RVA: 0x00945210 File Offset: 0x00943410
		public bool DVRSProfGeneralRouteMSUPTTMicAudToDVR_A41805_UIValue
		{
			get
			{
				short num = (short)1413218304;
				short num2 = num;
				num = (short)547111050;
				short num3 = num;
				num = (short)1895907466;
				switch (num3 == num)
				{
				}
				num = (short)400752641;
				if (num != 0)
				{
				}
				num = (short)582025216;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralRouteMSUPTTMicAudToDVR_A41805.Value;
			}
			set
			{
				short num = (short)284950528;
				short num2 = num;
				num = (short)512491521;
				if (num != 0)
				{
				}
				num = (short)7747539;
				short num3 = num;
				num = (short)492976083;
				switch (num3 == num)
				{
				}
				num = (short)508559360;
				if (num != 0)
				{
				}
				this.dVRSProfGeneralRouteMSUPTTMicAudToDVR_A41805.Value = value;
			}
		}

		// Token: 0x17004FC1 RID: 20417
		// (get) Token: 0x06009EDE RID: 40670 RVA: 0x009452C4 File Offset: 0x009434C4
		// (set) Token: 0x06009EDF RID: 40671 RVA: 0x00945378 File Offset: 0x00943578
		public bool DVRSProfGeneralRouteMSUPTTMicAudToDVR_A41805_Applicable
		{
			get
			{
				short num = (short)433586176;
				short num2 = num;
				num = (short)826095203;
				short num3 = num;
				num = (short)1435580003;
				switch (num3 == num)
				{
				}
				num = (short)231145473;
				if (num != 0)
				{
				}
				num = (short)241434624;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralRouteMSUPTTMicAudToDVR_A41805.Applicable;
			}
			set
			{
				short num = (short)1401487360;
				short num2 = num;
				num = (short)1438558289;
				short num3 = num;
				num = (short)593471569;
				switch (num3 == num)
				{
				}
				num = (short)652279809;
				if (num != 0)
				{
				}
				num = (short)742719488;
				if (num != 0)
				{
				}
				this.dVRSProfGeneralRouteMSUPTTMicAudToDVR_A41805.Applicable = value;
			}
		}

		// Token: 0x17004FC2 RID: 20418
		// (get) Token: 0x06009EE0 RID: 40672 RVA: 0x0094542C File Offset: 0x0094362C
		// (set) Token: 0x06009EE1 RID: 40673 RVA: 0x009454E0 File Offset: 0x009436E0
		public bool DVRSProfGeneralRouteMSUPTTMicAudToDVR_A41805_Valid
		{
			get
			{
				short num = (short)1324351488;
				short num2 = num;
				num = (short)35115284;
				short num3 = num;
				num = (short)1726664980;
				switch (num3 == num)
				{
				}
				num = (short)901775361;
				if (num != 0)
				{
				}
				num = (short)2086993920;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralRouteMSUPTTMicAudToDVR_A41805.Valid;
			}
			set
			{
				short num = (short)584974336;
				short num2 = num;
				num = (short)43472144;
				short num3 = num;
				num = (short)1077892368;
				switch (num3 == num)
				{
				}
				num = (short)81788929;
				if (num != 0)
				{
				}
				num = (short)175505408;
				if (num != 0)
				{
				}
				this.dVRSProfGeneralRouteMSUPTTMicAudToDVR_A41805.Valid = value;
			}
		}

		// Token: 0x17004FC3 RID: 20419
		// (get) Token: 0x06009EE2 RID: 40674 RVA: 0x00945594 File Offset: 0x00943794
		// (set) Token: 0x06009EE3 RID: 40675 RVA: 0x0094564C File Offset: 0x0094384C
		public bool DVRSProfGeneralRouteMSUPTTMicAudToDVR_A41805_Visible
		{
			get
			{
				short num = (short)1893531648;
				short num2 = num;
				num = (short)421724161;
				if (num != 0)
				{
				}
				num = (short)2048182260;
				short num3 = num;
				num = (short)85051380;
				switch (num3 == num)
				{
				}
				num = (short)2036203520;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralRouteMSUPTTMicAudToDVR_A41805.Visible;
			}
			set
			{
				short num = (short)1492647936;
				short num2 = num;
				num = (short)1068630017;
				if (num != 0)
				{
				}
				num = (short)2016443007;
				short num3 = num;
				num = (short)845118079;
				switch (num3 == num)
				{
				}
				num = (short)490668032;
				if (num != 0)
				{
				}
				this.dVRSProfGeneralRouteMSUPTTMicAudToDVR_A41805.Visible = value;
			}
		}

		// Token: 0x17004FC4 RID: 20420
		// (get) Token: 0x06009EE4 RID: 40676 RVA: 0x00945700 File Offset: 0x00943900
		// (set) Token: 0x06009EE5 RID: 40677 RVA: 0x009457B8 File Offset: 0x009439B8
		public bool DVRSProfGeneralRouteMSUPTTMicAudToDVR_A41805_Editable
		{
			get
			{
				short num = (short)1862991872;
				short num2 = num;
				num = (short)2142441149;
				short num3 = num;
				num = (short)1344736957;
				switch (num3 == num)
				{
				}
				num = (short)1189806081;
				if (num != 0)
				{
				}
				num = (short)691666944;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralRouteMSUPTTMicAudToDVR_A41805.Editable;
			}
			set
			{
				short num = (short)146931712;
				short num2 = num;
				num = (short)18815215;
				short num3 = num;
				num = (short)589568239;
				switch (num3 == num)
				{
				}
				num = (short)785711104;
				if (num != 0)
				{
				}
				num = (short)1794703361;
				if (num != 0)
				{
				}
				this.dVRSProfGeneralRouteMSUPTTMicAudToDVR_A41805.Editable = value;
			}
		}

		// Token: 0x17004FC5 RID: 20421
		// (get) Token: 0x06009EE6 RID: 40678 RVA: 0x00945870 File Offset: 0x00943A70
		internal string DVRSProfGeneralRouteMSUPTTMicAudToDVR_A41805_UILabel
		{
			get
			{
				short num = (short)134545408;
				short num2 = num;
				num = (short)821939829;
				short num3 = num;
				num = (short)537448053;
				switch (num3 == num)
				{
				}
				num = (short)568983553;
				if (num != 0)
				{
				}
				num = (short)970522624;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralRouteMSUPTTMicAudToDVR_A41805.UIName;
			}
		}

		// Token: 0x17004FC6 RID: 20422
		// (get) Token: 0x06009EE7 RID: 40679 RVA: 0x00945928 File Offset: 0x00943B28
		// (set) Token: 0x06009EE8 RID: 40680 RVA: 0x009459D8 File Offset: 0x00943BD8
		internal bool DVRSProfGeneralRouteMSUPTTMicAudToDVR_A41805_HiddenStatic
		{
			get
			{
				short num = (short)1285423104;
				short num2 = num;
				num = (short)1033869298;
				short num3 = num;
				num = (short)1695127538;
				switch (num3 == num)
				{
				}
				num = (short)2044919809;
				if (num != 0)
				{
				}
				num = (short)1468792832;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralRouteMSUPTTMicAudToDVR_A41805.HiddenStatic;
			}
			set
			{
				short num = (short)2042953728;
				short num2 = num;
				num = (short)865554783;
				short num3 = num;
				num = (short)1458590047;
				switch (num3 == num)
				{
				}
				num = (short)1041367040;
				if (num != 0)
				{
				}
				num = (short)89456641;
				if (num != 0)
				{
				}
				this.dVRSProfGeneralRouteMSUPTTMicAudToDVR_A41805.HiddenStatic = value;
			}
		}

		// Token: 0x17004FC7 RID: 20423
		// (get) Token: 0x06009EE9 RID: 40681 RVA: 0x00945A8C File Offset: 0x00943C8C
		// (set) Token: 0x06009EEA RID: 40682 RVA: 0x00945B44 File Offset: 0x00943D44
		internal bool DVRSProfGeneralRouteMSUPTTMicAudToDVR_A41805_HiddenDynamic
		{
			get
			{
				short num = (short)935198720;
				short num2 = num;
				num = (short)229048321;
				if (num != 0)
				{
				}
				num = (short)853703886;
				short num3 = num;
				num = (short)259882190;
				switch (num3 == num)
				{
				}
				num = (short)224198656;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralRouteMSUPTTMicAudToDVR_A41805.HiddenDynamic;
			}
			set
			{
				short num = (short)549126144;
				short num2 = num;
				num = (short)6184382;
				short num3 = num;
				num = (short)1668636094;
				switch (num3 == num)
				{
				}
				num = (short)1459290113;
				if (num != 0)
				{
				}
				num = (short)987103232;
				if (num != 0)
				{
				}
				this.dVRSProfGeneralRouteMSUPTTMicAudToDVR_A41805.HiddenDynamic = value;
			}
		}

		// Token: 0x17004FC8 RID: 20424
		// (get) Token: 0x06009EEB RID: 40683 RVA: 0x00945BF8 File Offset: 0x00943DF8
		public bool DVRSProfGeneralRouteMSUPTTMicAudToDVR_A41805_HasDiffs
		{
			get
			{
				short num = (short)54329344;
				short num2 = num;
				num = (short)1577510066;
				short num3 = num;
				num = (short)351659186;
				switch (num3 == num)
				{
				}
				num = (short)381616129;
				if (num != 0)
				{
				}
				num = (short)288161792;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralRouteMSUPTTMicAudToDVR_A41805._HasDiffs;
			}
		}

		// Token: 0x17004FC9 RID: 20425
		// (get) Token: 0x06009EEC RID: 40684 RVA: 0x00945CAC File Offset: 0x00943EAC
		// (set) Token: 0x06009EED RID: 40685 RVA: 0x00945D64 File Offset: 0x00943F64
		public bool DVRSProfGeneralLocalTxFallback_A41806Value
		{
			get
			{
				short num = (short)1084882944;
				short num2 = num;
				num = (short)1041534961;
				short num3 = num;
				num = (short)1976799217;
				switch (num3 == num)
				{
				}
				num = (short)676724736;
				if (num != 0)
				{
				}
				num = (short)1251737601;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralLocalTxFallback_A41806.Value;
			}
			set
			{
				short num = (short)1082327040;
				short num2 = num;
				num = (short)1320671497;
				short num3 = num;
				num = (short)1624299785;
				switch (num3 == num)
				{
				}
				num = (short)1839595521;
				if (num != 0)
				{
				}
				num = (short)1264058368;
				if (num != 0)
				{
				}
				this.dVRSProfGeneralLocalTxFallback_A41806.Value = value;
			}
		}

		// Token: 0x17004FCA RID: 20426
		// (get) Token: 0x06009EEE RID: 40686 RVA: 0x00945E1C File Offset: 0x0094401C
		public global::AcpBusinessLayer.AcpField<bool> DVRSProfGeneralLocalTxFallback_A41806
		{
			get
			{
				short num = (short)489357312;
				short num2 = num;
				num = (short)1366688420;
				short num3 = num;
				num = (short)496304804;
				switch (num3 == num)
				{
				}
				num = (short)1556414464;
				if (num != 0)
				{
				}
				num = (short)545587201;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralLocalTxFallback_A41806;
			}
		}

		// Token: 0x17004FCB RID: 20427
		// (get) Token: 0x06009EEF RID: 40687 RVA: 0x00945ED0 File Offset: 0x009440D0
		// (set) Token: 0x06009EF0 RID: 40688 RVA: 0x00945F88 File Offset: 0x00944188
		public bool DVRSProfGeneralLocalTxFallback_A41806_UIValue
		{
			get
			{
				short num = (short)872415232;
				short num2 = num;
				num = (short)1583806901;
				short num3 = num;
				num = (short)1626077621;
				switch (num3 == num)
				{
				}
				num = (short)82182145;
				if (num != 0)
				{
				}
				num = (short)375521280;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralLocalTxFallback_A41806.Value;
			}
			set
			{
				short num = (short)1015939072;
				short num2 = num;
				num = (short)1262174480;
				short num3 = num;
				num = (short)1551646992;
				switch (num3 == num)
				{
				}
				num = (short)1100152833;
				if (num != 0)
				{
				}
				num = (short)465764352;
				if (num != 0)
				{
				}
				this.dVRSProfGeneralLocalTxFallback_A41806.Value = value;
			}
		}

		// Token: 0x17004FCC RID: 20428
		// (get) Token: 0x06009EF1 RID: 40689 RVA: 0x00946040 File Offset: 0x00944240
		// (set) Token: 0x06009EF2 RID: 40690 RVA: 0x009460F4 File Offset: 0x009442F4
		public bool DVRSProfGeneralLocalTxFallback_A41806_Applicable
		{
			get
			{
				short num = (short)806551552;
				short num2 = num;
				num = (short)154114495;
				short num3 = num;
				num = (short)1650104767;
				switch (num3 == num)
				{
				}
				num = (short)638320640;
				if (num != 0)
				{
				}
				num = (short)923926529;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralLocalTxFallback_A41806.Applicable;
			}
			set
			{
				short num = (short)1078329344;
				short num2 = num;
				num = (short)710531012;
				short num3 = num;
				num = (short)1706678212;
				switch (num3 == num)
				{
				}
				num = (short)1031536641;
				if (num != 0)
				{
				}
				num = (short)1309540352;
				if (num != 0)
				{
				}
				this.dVRSProfGeneralLocalTxFallback_A41806.Applicable = value;
			}
		}

		// Token: 0x17004FCD RID: 20429
		// (get) Token: 0x06009EF3 RID: 40691 RVA: 0x009461AC File Offset: 0x009443AC
		// (set) Token: 0x06009EF4 RID: 40692 RVA: 0x00946260 File Offset: 0x00944460
		public bool DVRSProfGeneralLocalTxFallback_A41806_Valid
		{
			get
			{
				short num = (short)1651900416;
				short num2 = num;
				num = (short)1854924537;
				short num3 = num;
				num = (short)781903609;
				switch (num3 == num)
				{
				}
				num = (short)2029977600;
				if (num != 0)
				{
				}
				num = (short)890044417;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralLocalTxFallback_A41806.Valid;
			}
			set
			{
				short num = (short)473169920;
				short num2 = num;
				num = (short)603872327;
				short num3 = num;
				num = (short)1892506695;
				switch (num3 == num)
				{
				}
				num = (short)572981248;
				if (num != 0)
				{
				}
				num = (short)64946177;
				if (num != 0)
				{
				}
				this.dVRSProfGeneralLocalTxFallback_A41806.Valid = value;
			}
		}

		// Token: 0x17004FCE RID: 20430
		// (get) Token: 0x06009EF5 RID: 40693 RVA: 0x00946314 File Offset: 0x00944514
		// (set) Token: 0x06009EF6 RID: 40694 RVA: 0x009463C8 File Offset: 0x009445C8
		public bool DVRSProfGeneralLocalTxFallback_A41806_Visible
		{
			get
			{
				short num = (short)842989568;
				short num2 = num;
				num = (short)1338003939;
				short num3 = num;
				num = (short)22696419;
				switch (num3 == num)
				{
				}
				num = (short)984285184;
				if (num != 0)
				{
				}
				num = (short)931987457;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralLocalTxFallback_A41806.Visible;
			}
			set
			{
				short num = (short)181927936;
				short num2 = num;
				num = (short)356211993;
				short num3 = num;
				num = (short)72572185;
				switch (num3 == num)
				{
				}
				num = (short)740818945;
				if (num != 0)
				{
				}
				num = (short)619511808;
				if (num != 0)
				{
				}
				this.dVRSProfGeneralLocalTxFallback_A41806.Visible = value;
			}
		}

		// Token: 0x17004FCF RID: 20431
		// (get) Token: 0x06009EF7 RID: 40695 RVA: 0x0094647C File Offset: 0x0094467C
		// (set) Token: 0x06009EF8 RID: 40696 RVA: 0x00946530 File Offset: 0x00944730
		public bool DVRSProfGeneralLocalTxFallback_A41806_Editable
		{
			get
			{
				short num = (short)1059304031;
				short num2 = num;
				num = (short)1190376031;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1314586624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1857748993;
				if (num != 0)
				{
				}
				num = (short)1759969280;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralLocalTxFallback_A41806.Editable;
			}
			set
			{
				short num = (short)485949441;
				if (num != 0)
				{
				}
				num = (short)1489436672;
				short num2 = num;
				num = (short)1111049068;
				short num3 = num;
				num = (short)1868710764;
				switch (num3 == num)
				{
				}
				num = (short)915800064;
				if (num != 0)
				{
				}
				this.dVRSProfGeneralLocalTxFallback_A41806.Editable = value;
			}
		}

		// Token: 0x17004FD0 RID: 20432
		// (get) Token: 0x06009EF9 RID: 40697 RVA: 0x009465E8 File Offset: 0x009447E8
		internal string DVRSProfGeneralLocalTxFallback_A41806_UILabel
		{
			get
			{
				short num = (short)260665980;
				short num2 = num;
				num = (short)1202025084;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1744437248;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1969750017;
				if (num != 0)
				{
				}
				num = (short)95092736;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralLocalTxFallback_A41806.UIName;
			}
		}

		// Token: 0x17004FD1 RID: 20433
		// (get) Token: 0x06009EFA RID: 40698 RVA: 0x009466A0 File Offset: 0x009448A0
		// (set) Token: 0x06009EFB RID: 40699 RVA: 0x00946750 File Offset: 0x00944950
		internal bool DVRSProfGeneralLocalTxFallback_A41806_HiddenStatic
		{
			get
			{
				short num = (short)1556021249;
				if (num != 0)
				{
				}
				num = (short)91553792;
				short num2 = num;
				num = (short)1065308588;
				short num3 = num;
				num = (short)951800236;
				switch (num3 == num)
				{
				}
				num = (short)490405888;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralLocalTxFallback_A41806.HiddenStatic;
			}
			set
			{
				short num = (short)399996915;
				short num2 = num;
				num = (short)370636787;
				switch (num2 == num)
				{
				default:
				{
					num = (short)674365440;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)495910913;
				if (num != 0)
				{
				}
				num = (short)690552832;
				if (num != 0)
				{
				}
				this.dVRSProfGeneralLocalTxFallback_A41806.HiddenStatic = value;
			}
		}

		// Token: 0x17004FD2 RID: 20434
		// (get) Token: 0x06009EFC RID: 40700 RVA: 0x00946804 File Offset: 0x00944A04
		// (set) Token: 0x06009EFD RID: 40701 RVA: 0x009468B8 File Offset: 0x00944AB8
		internal bool DVRSProfGeneralLocalTxFallback_A41806_HiddenDynamic
		{
			get
			{
				short num = (short)733534644;
				short num2 = num;
				num = (short)1996478900;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2118844416;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)931594241;
				if (num != 0)
				{
				}
				num = (short)1229324288;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralLocalTxFallback_A41806.HiddenDynamic;
			}
			set
			{
				short num = (short)1366430582;
				short num2 = num;
				num = (short)465703798;
				switch (num2 == num)
				{
				default:
				{
					num = (short)317456384;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1153826817;
				if (num != 0)
				{
				}
				num = (short)1743978496;
				if (num != 0)
				{
				}
				this.dVRSProfGeneralLocalTxFallback_A41806.HiddenDynamic = value;
			}
		}

		// Token: 0x17004FD3 RID: 20435
		// (get) Token: 0x06009EFE RID: 40702 RVA: 0x00946970 File Offset: 0x00944B70
		public bool DVRSProfGeneralLocalTxFallback_A41806_HasDiffs
		{
			get
			{
				short num = (short)897338165;
				short num2 = num;
				num = (short)128731957;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2047737856;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2114781185;
				if (num != 0)
				{
				}
				num = (short)1754005504;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralLocalTxFallback_A41806._HasDiffs;
			}
		}

		// Token: 0x17004FD4 RID: 20436
		// (get) Token: 0x06009EFF RID: 40703 RVA: 0x00946A20 File Offset: 0x00944C20
		// (set) Token: 0x06009F00 RID: 40704 RVA: 0x00946AD4 File Offset: 0x00944CD4
		public int DVRSProfGeneralProxyTimeOutTimer_A41807Value
		{
			get
			{
				short num = (short)393936897;
				if (num != 0)
				{
				}
				num = (short)1925578752;
				short num2 = num;
				num = (short)520410446;
				short num3 = num;
				num = (short)780457294;
				switch (num3 == num)
				{
				}
				num = (short)732102656;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralProxyTimeOutTimer_A41807.Value;
			}
			set
			{
				short num = (short)604855475;
				short num2 = num;
				num = (short)727997619;
				switch (num2 == num)
				{
				default:
				{
					num = (short)315490304;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)866058241;
				if (num != 0)
				{
				}
				num = (short)1290010624;
				if (num != 0)
				{
				}
				this.dVRSProfGeneralProxyTimeOutTimer_A41807.Value = value;
			}
		}

		// Token: 0x17004FD5 RID: 20437
		// (get) Token: 0x06009F01 RID: 40705 RVA: 0x00946B8C File Offset: 0x00944D8C
		public global::AcpBusinessLayer.AcpSimpleRangeField DVRSProfGeneralProxyTimeOutTimer_A41807
		{
			get
			{
				short num = (short)2046875407;
				short num2 = num;
				num = (short)1128781583;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1532100608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1442316288;
				if (num != 0)
				{
				}
				num = (short)389283841;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralProxyTimeOutTimer_A41807;
			}
		}

		// Token: 0x17004FD6 RID: 20438
		// (get) Token: 0x06009F02 RID: 40706 RVA: 0x00946C3C File Offset: 0x00944E3C
		// (set) Token: 0x06009F03 RID: 40707 RVA: 0x00946CF4 File Offset: 0x00944EF4
		public string DVRSProfGeneralProxyTimeOutTimer_A41807_UIValue
		{
			get
			{
				short num = (short)1888809095;
				short num2 = num;
				num = (short)1029959815;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1323958272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1953759233;
				if (num != 0)
				{
				}
				num = (short)243138560;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralProxyTimeOutTimer_A41807.UIValue;
			}
			set
			{
				short num = (short)1699680801;
				short num2 = num;
				num = (short)2118390305;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1334378496;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1521680385;
				if (num != 0)
				{
				}
				num = (short)644481024;
				if (num != 0)
				{
				}
				this.dVRSProfGeneralProxyTimeOutTimer_A41807.UIValue = value;
			}
		}

		// Token: 0x17004FD7 RID: 20439
		// (get) Token: 0x06009F04 RID: 40708 RVA: 0x00946DA8 File Offset: 0x00944FA8
		// (set) Token: 0x06009F05 RID: 40709 RVA: 0x00946E5C File Offset: 0x0094505C
		internal int DVRSProfGeneralProxyTimeOutTimer_A41807Min
		{
			get
			{
				short num = (short)932088796;
				short num2 = num;
				num = (short)1619692508;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2054684672;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)479789056;
				if (num != 0)
				{
				}
				num = (short)1687224321;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralProxyTimeOutTimer_A41807.Min;
			}
			set
			{
				short num = (short)1339445968;
				short num2 = num;
				num = (short)555373264;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1235877888;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)23658496;
				if (num != 0)
				{
				}
				num = (short)906690561;
				if (num != 0)
				{
				}
				this.dVRSProfGeneralProxyTimeOutTimer_A41807.Min = value;
			}
		}

		// Token: 0x17004FD8 RID: 20440
		// (get) Token: 0x06009F06 RID: 40710 RVA: 0x00946F10 File Offset: 0x00945110
		// (set) Token: 0x06009F07 RID: 40711 RVA: 0x00946FC4 File Offset: 0x009451C4
		internal int DVRSProfGeneralProxyTimeOutTimer_A41807Max
		{
			get
			{
				short num = (short)279379969;
				if (num != 0)
				{
				}
				num = (short)2039414784;
				short num2 = num;
				num = (short)110894070;
				short num3 = num;
				num = (short)907090934;
				switch (num3 == num)
				{
				}
				num = (short)2026504192;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralProxyTimeOutTimer_A41807.Max;
			}
			set
			{
				short num = (short)1350085123;
				short num2 = num;
				num = (short)2023008771;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2118975488;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)576913408;
				if (num != 0)
				{
				}
				num = (short)919601153;
				if (num != 0)
				{
				}
				this.dVRSProfGeneralProxyTimeOutTimer_A41807.Max = value;
			}
		}

		// Token: 0x17004FD9 RID: 20441
		// (get) Token: 0x06009F08 RID: 40712 RVA: 0x00947078 File Offset: 0x00945278
		// (set) Token: 0x06009F09 RID: 40713 RVA: 0x0094712C File Offset: 0x0094532C
		internal int DVRSProfGeneralProxyTimeOutTimer_A41807Step
		{
			get
			{
				short num = (short)926970232;
				short num2 = num;
				num = (short)549089656;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1286537216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1042284545;
				if (num != 0)
				{
				}
				num = (short)1932328960;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralProxyTimeOutTimer_A41807.StepSize;
			}
			set
			{
				short num = (short)1675808277;
				short num2 = num;
				num = (short)767282709;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1389101056;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)596639744;
				if (num != 0)
				{
				}
				num = (short)870514689;
				if (num != 0)
				{
				}
				this.dVRSProfGeneralProxyTimeOutTimer_A41807.StepSize = value;
			}
		}

		// Token: 0x17004FDA RID: 20442
		// (get) Token: 0x06009F0A RID: 40714 RVA: 0x009471E4 File Offset: 0x009453E4
		// (set) Token: 0x06009F0B RID: 40715 RVA: 0x00947298 File Offset: 0x00945498
		public bool DVRSProfGeneralProxyTimeOutTimer_A41807_Applicable
		{
			get
			{
				short num = (short)1254583764;
				short num2 = num;
				num = (short)1891397076;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1005649920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)916193280;
				if (num != 0)
				{
				}
				num = (short)457244673;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralProxyTimeOutTimer_A41807.Applicable;
			}
			set
			{
				short num = (short)742462809;
				short num2 = num;
				num = (short)1192826201;
				switch (num2 == num)
				{
				default:
				{
					num = (short)698548224;
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
				num = (short)186843136;
				if (num != 0)
				{
				}
				this.dVRSProfGeneralProxyTimeOutTimer_A41807.Applicable = value;
			}
		}

		// Token: 0x17004FDB RID: 20443
		// (get) Token: 0x06009F0C RID: 40716 RVA: 0x0094734C File Offset: 0x0094554C
		// (set) Token: 0x06009F0D RID: 40717 RVA: 0x00947400 File Offset: 0x00945600
		public bool DVRSProfGeneralProxyTimeOutTimer_A41807_Valid
		{
			get
			{
				short num = (short)1622065928;
				short num2 = num;
				num = (short)1358545672;
				switch (num2 == num)
				{
				default:
				{
					num = (short)152043520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)639565825;
				if (num != 0)
				{
				}
				num = (short)1896022016;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralProxyTimeOutTimer_A41807.Valid;
			}
			set
			{
				short num = (short)1618065753;
				short num2 = num;
				num = (short)1899346265;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1379336192;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1826684928;
				if (num != 0)
				{
				}
				num = (short)693370881;
				if (num != 0)
				{
				}
				this.dVRSProfGeneralProxyTimeOutTimer_A41807.Valid = value;
			}
		}

		// Token: 0x17004FDC RID: 20444
		// (get) Token: 0x06009F0E RID: 40718 RVA: 0x009474B8 File Offset: 0x009456B8
		// (set) Token: 0x06009F0F RID: 40719 RVA: 0x0094756C File Offset: 0x0094576C
		public bool DVRSProfGeneralProxyTimeOutTimer_A41807_Visible
		{
			get
			{
				short num = (short)1077521724;
				short num2 = num;
				num = (short)43756860;
				switch (num2 == num)
				{
				default:
				{
					num = (short)546504704;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2031484928;
				if (num != 0)
				{
				}
				num = (short)1665466369;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralProxyTimeOutTimer_A41807.Visible;
			}
			set
			{
				short num = (short)1138249624;
				short num2 = num;
				num = (short)836784024;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1571094528;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)100466689;
				if (num != 0)
				{
				}
				num = (short)1790509056;
				if (num != 0)
				{
				}
				this.dVRSProfGeneralProxyTimeOutTimer_A41807.Visible = value;
			}
		}

		// Token: 0x17004FDD RID: 20445
		// (get) Token: 0x06009F10 RID: 40720 RVA: 0x00947620 File Offset: 0x00945820
		// (set) Token: 0x06009F11 RID: 40721 RVA: 0x009476D8 File Offset: 0x009458D8
		public bool DVRSProfGeneralProxyTimeOutTimer_A41807_Editable
		{
			get
			{
				short num = (short)1892458863;
				short num2 = num;
				num = (short)848732527;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1339359232;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)603127809;
				if (num != 0)
				{
				}
				num = (short)2054881280;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralProxyTimeOutTimer_A41807.Editable;
			}
			set
			{
				short num = (short)351216044;
				short num2 = num;
				num = (short)1164911020;
				switch (num2 == num)
				{
				default:
				{
					num = (short)333381632;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)797114369;
				if (num != 0)
				{
				}
				num = (short)184418304;
				if (num != 0)
				{
				}
				this.dVRSProfGeneralProxyTimeOutTimer_A41807.Editable = value;
			}
		}

		// Token: 0x17004FDE RID: 20446
		// (get) Token: 0x06009F12 RID: 40722 RVA: 0x00947790 File Offset: 0x00945990
		internal string DVRSProfGeneralProxyTimeOutTimer_A41807_UILabel
		{
			get
			{
				short num = (short)689470067;
				short num2 = num;
				num = (short)452295283;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1019281408;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1463943169;
				if (num != 0)
				{
				}
				num = (short)1750728704;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralProxyTimeOutTimer_A41807.UIName;
			}
		}

		// Token: 0x17004FDF RID: 20447
		// (get) Token: 0x06009F13 RID: 40723 RVA: 0x00947844 File Offset: 0x00945A44
		// (set) Token: 0x06009F14 RID: 40724 RVA: 0x009478F8 File Offset: 0x00945AF8
		internal bool DVRSProfGeneralProxyTimeOutTimer_A41807_HiddenStatic
		{
			get
			{
				short num = (short)530491083;
				short num2 = num;
				num = (short)285255371;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1351745536;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)192086017;
				if (num != 0)
				{
				}
				num = (short)2107506688;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralProxyTimeOutTimer_A41807.HiddenStatic;
			}
			set
			{
				short num = (short)1523343374;
				short num2 = num;
				num = (short)409755662;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2014969856;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)6094848;
				if (num != 0)
				{
				}
				num = (short)66650113;
				if (num != 0)
				{
				}
				this.dVRSProfGeneralProxyTimeOutTimer_A41807.HiddenStatic = value;
			}
		}

		// Token: 0x17004FE0 RID: 20448
		// (get) Token: 0x06009F15 RID: 40725 RVA: 0x009479AC File Offset: 0x00945BAC
		// (set) Token: 0x06009F16 RID: 40726 RVA: 0x00947A60 File Offset: 0x00945C60
		internal bool DVRSProfGeneralProxyTimeOutTimer_A41807_HiddenDynamic
		{
			get
			{
				short num = (short)204230505;
				short num2 = num;
				num = (short)1354583913;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1114505216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)113770497;
				if (num != 0)
				{
				}
				num = (short)881065984;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralProxyTimeOutTimer_A41807.HiddenDynamic;
			}
			set
			{
				short num = (short)548097033;
				short num2 = num;
				num = (short)1569016841;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1604452352;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1509687297;
				if (num != 0)
				{
				}
				num = (short)1059651584;
				if (num != 0)
				{
				}
				this.dVRSProfGeneralProxyTimeOutTimer_A41807.HiddenDynamic = value;
			}
		}

		// Token: 0x17004FE1 RID: 20449
		// (get) Token: 0x06009F17 RID: 40727 RVA: 0x00947B14 File Offset: 0x00945D14
		public bool DVRSProfGeneralProxyTimeOutTimer_A41807_HasDiffs
		{
			get
			{
				short num = (short)562200368;
				short num2 = num;
				num = (short)518553392;
				switch (num2 == num)
				{
				default:
				{
					num = (short)463011840;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1002700801;
				if (num != 0)
				{
				}
				num = (short)857276416;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralProxyTimeOutTimer_A41807._HasDiffs;
			}
		}

		// Token: 0x17004FE2 RID: 20450
		// (get) Token: 0x06009F18 RID: 40728 RVA: 0x00947BC8 File Offset: 0x00945DC8
		// (set) Token: 0x06009F19 RID: 40729 RVA: 0x00947C80 File Offset: 0x00945E80
		public int DVRSProfGeneralProxyLimitPatienceTimer_A41808Value
		{
			get
			{
				short num = (short)1319499767;
				short num2 = num;
				num = (short)1771042807;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1741029376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1265369089;
				if (num != 0)
				{
				}
				num = (short)1498873856;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralProxyLimitPatienceTimer_A41808.Value;
			}
			set
			{
				short num = (short)1147737493;
				short num2 = num;
				num = (short)1111954837;
				switch (num2 == num)
				{
				default:
				{
					num = (short)311885824;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1937965057;
				if (num != 0)
				{
				}
				num = (short)152764416;
				if (num != 0)
				{
				}
				this.dVRSProfGeneralProxyLimitPatienceTimer_A41808.Value = value;
			}
		}

		// Token: 0x17004FE3 RID: 20451
		// (get) Token: 0x06009F1A RID: 40730 RVA: 0x00947D34 File Offset: 0x00945F34
		public global::AcpBusinessLayer.AcpSimpleRangeField DVRSProfGeneralProxyLimitPatienceTimer_A41808
		{
			get
			{
				short num = (short)606156562;
				short num2 = num;
				num = (short)107427602;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1063452672;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1152778240;
				if (num != 0)
				{
				}
				num = (short)490733569;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralProxyLimitPatienceTimer_A41808;
			}
		}

		// Token: 0x17004FE4 RID: 20452
		// (get) Token: 0x06009F1B RID: 40731 RVA: 0x00947DE0 File Offset: 0x00945FE0
		// (set) Token: 0x06009F1C RID: 40732 RVA: 0x00947E94 File Offset: 0x00946094
		public string DVRSProfGeneralProxyLimitPatienceTimer_A41808_UIValue
		{
			get
			{
				short num = (short)15703105;
				short num2 = num;
				num = (short)731028545;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1520173056;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)183304192;
				if (num != 0)
				{
				}
				num = (short)817758209;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralProxyLimitPatienceTimer_A41808.UIValue;
			}
			set
			{
				short num = (short)929351490;
				short num2 = num;
				num = (short)1657128770;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1903951872;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1908277248;
				if (num != 0)
				{
				}
				num = (short)196935681;
				if (num != 0)
				{
				}
				this.dVRSProfGeneralProxyLimitPatienceTimer_A41808.UIValue = value;
			}
		}

		// Token: 0x17004FE5 RID: 20453
		// (get) Token: 0x06009F1D RID: 40733 RVA: 0x00947F4C File Offset: 0x0094614C
		// (set) Token: 0x06009F1E RID: 40734 RVA: 0x00948000 File Offset: 0x00946200
		internal int DVRSProfGeneralProxyLimitPatienceTimer_A41808Min
		{
			get
			{
				short num = (short)522475137;
				short num2 = num;
				num = (short)2050446977;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1579679744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)333316096;
				if (num != 0)
				{
				}
				num = (short)15925249;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralProxyLimitPatienceTimer_A41808.Min;
			}
			set
			{
				short num = (short)419364865;
				if (num != 0)
				{
				}
				num = (short)1572470784;
				short num2 = num;
				num = (short)1436991037;
				short num3 = num;
				num = (short)1139326525;
				switch (num3 == num)
				{
				}
				num = (short)311689216;
				if (num != 0)
				{
				}
				this.dVRSProfGeneralProxyLimitPatienceTimer_A41808.Min = value;
			}
		}

		// Token: 0x17004FE6 RID: 20454
		// (get) Token: 0x06009F1F RID: 40735 RVA: 0x009480B4 File Offset: 0x009462B4
		// (set) Token: 0x06009F20 RID: 40736 RVA: 0x0094816C File Offset: 0x0094636C
		internal int DVRSProfGeneralProxyLimitPatienceTimer_A41808Max
		{
			get
			{
				short num = (short)1195785705;
				short num2 = num;
				num = (short)1079983593;
				switch (num2 == num)
				{
				default:
				{
					num = (short)474939392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)895942657;
				if (num != 0)
				{
				}
				num = (short)1742733312;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralProxyLimitPatienceTimer_A41808.Max;
			}
			set
			{
				short num = (short)247083417;
				short num2 = num;
				num = (short)1324167577;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2147221504;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2121138177;
				if (num != 0)
				{
				}
				num = (short)682754048;
				if (num != 0)
				{
				}
				this.dVRSProfGeneralProxyLimitPatienceTimer_A41808.Max = value;
			}
		}

		// Token: 0x17004FE7 RID: 20455
		// (get) Token: 0x06009F21 RID: 40737 RVA: 0x00948220 File Offset: 0x00946420
		// (set) Token: 0x06009F22 RID: 40738 RVA: 0x009482D8 File Offset: 0x009464D8
		internal int DVRSProfGeneralProxyLimitPatienceTimer_A41808Step
		{
			get
			{
				short num = (short)691339265;
				if (num != 0)
				{
				}
				num = (short)717291520;
				short num2 = num;
				num = (short)1800308847;
				short num3 = num;
				num = (short)690194543;
				switch (num3 == num)
				{
				}
				num = (short)404619264;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralProxyLimitPatienceTimer_A41808.StepSize;
			}
			set
			{
				short num = (short)1857325055;
				short num2 = num;
				num = (short)581470207;
				switch (num2 == num)
				{
				default:
				{
					num = (short)530382848;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2047082497;
				if (num != 0)
				{
				}
				num = (short)1812594688;
				if (num != 0)
				{
				}
				this.dVRSProfGeneralProxyLimitPatienceTimer_A41808.StepSize = value;
			}
		}

		// Token: 0x17004FE8 RID: 20456
		// (get) Token: 0x06009F23 RID: 40739 RVA: 0x00948390 File Offset: 0x00946590
		// (set) Token: 0x06009F24 RID: 40740 RVA: 0x00948444 File Offset: 0x00946644
		public bool DVRSProfGeneralProxyLimitPatienceTimer_A41808_Applicable
		{
			get
			{
				short num = (short)1039007745;
				if (num != 0)
				{
				}
				num = (short)1674182656;
				short num2 = num;
				num = (short)1224456417;
				short num3 = num;
				num = (short)541112545;
				switch (num3 == num)
				{
				}
				num = (short)135331840;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralProxyLimitPatienceTimer_A41808.Applicable;
			}
			set
			{
				short num = (short)135915649;
				short num2 = num;
				num = (short)1777395841;
				switch (num2 == num)
				{
				default:
				{
					num = (short)665649152;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)710410240;
				if (num != 0)
				{
				}
				num = (short)641269761;
				if (num != 0)
				{
				}
				this.dVRSProfGeneralProxyLimitPatienceTimer_A41808.Applicable = value;
			}
		}

		// Token: 0x17004FE9 RID: 20457
		// (get) Token: 0x06009F25 RID: 40741 RVA: 0x009484F8 File Offset: 0x009466F8
		// (set) Token: 0x06009F26 RID: 40742 RVA: 0x009485A8 File Offset: 0x009467A8
		public bool DVRSProfGeneralProxyLimitPatienceTimer_A41808_Valid
		{
			get
			{
				short num = (short)1133113475;
				short num2 = num;
				num = (short)1548415107;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1763835904;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1767309313;
				if (num != 0)
				{
				}
				num = (short)101056512;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralProxyLimitPatienceTimer_A41808.Valid;
			}
			set
			{
				short num = (short)663317976;
				short num2 = num;
				num = (short)1314549208;
				switch (num2 == num)
				{
				default:
				{
					num = (short)715128832;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1015742465;
				if (num != 0)
				{
				}
				num = (short)315359232;
				if (num != 0)
				{
				}
				this.dVRSProfGeneralProxyLimitPatienceTimer_A41808.Valid = value;
			}
		}

		// Token: 0x17004FEA RID: 20458
		// (get) Token: 0x06009F27 RID: 40743 RVA: 0x00948660 File Offset: 0x00946860
		// (set) Token: 0x06009F28 RID: 40744 RVA: 0x00948714 File Offset: 0x00946914
		public bool DVRSProfGeneralProxyLimitPatienceTimer_A41808_Visible
		{
			get
			{
				short num = (short)1178332736;
				short num2 = num;
				num = (short)2039672384;
				switch (num2 == num)
				{
				}
				num = (short)1310720;
				if (num != 0)
				{
				}
				num = (short)644087809;
				if (num != 0)
				{
				}
				num = (short)1079312384;
				short num3 = num;
				return this.dVRSProfGeneralProxyLimitPatienceTimer_A41808.Visible;
			}
			set
			{
				short num = (short)1132166600;
				short num2 = num;
				num = (short)1902280136;
				switch (num2 == num)
				{
				}
				num = (short)297861120;
				if (num != 0)
				{
				}
				num = (short)1433206785;
				if (num != 0)
				{
				}
				num = (short)1509687296;
				short num3 = num;
				this.dVRSProfGeneralProxyLimitPatienceTimer_A41808.Visible = value;
			}
		}

		// Token: 0x17004FEB RID: 20459
		// (get) Token: 0x06009F29 RID: 40745 RVA: 0x009487C8 File Offset: 0x009469C8
		// (set) Token: 0x06009F2A RID: 40746 RVA: 0x0094887C File Offset: 0x00946A7C
		public bool DVRSProfGeneralProxyLimitPatienceTimer_A41808_Editable
		{
			get
			{
				short num = (short)4795841;
				short num2 = num;
				num = (short)1781083585;
				switch (num2 == num)
				{
				}
				num = (short)1738539009;
				if (num != 0)
				{
				}
				num = (short)813039616;
				if (num != 0)
				{
				}
				num = (short)113508352;
				short num3 = num;
				return this.dVRSProfGeneralProxyLimitPatienceTimer_A41808.Editable;
			}
			set
			{
				short num = (short)184907137;
				short num2 = num;
				num = (short)1129739649;
				switch (num2 == num)
				{
				}
				num = (short)704446465;
				if (num != 0)
				{
				}
				num = (short)539492352;
				if (num != 0)
				{
				}
				num = (short)1658912768;
				short num3 = num;
				this.dVRSProfGeneralProxyLimitPatienceTimer_A41808.Editable = value;
			}
		}

		// Token: 0x17004FEC RID: 20460
		// (get) Token: 0x06009F2B RID: 40747 RVA: 0x00948934 File Offset: 0x00946B34
		internal string DVRSProfGeneralProxyLimitPatienceTimer_A41808_UILabel
		{
			get
			{
				short num = (short)1957465650;
				short num2 = num;
				num = (short)667323954;
				switch (num2 == num)
				{
				}
				num = (short)2079260672;
				if (num != 0)
				{
				}
				num = (short)1402535937;
				if (num != 0)
				{
				}
				num = (short)1468006400;
				short num3 = num;
				return this.dVRSProfGeneralProxyLimitPatienceTimer_A41808.UIName;
			}
		}

		// Token: 0x17004FED RID: 20461
		// (get) Token: 0x06009F2C RID: 40748 RVA: 0x009489E8 File Offset: 0x00946BE8
		// (set) Token: 0x06009F2D RID: 40749 RVA: 0x00948A9C File Offset: 0x00946C9C
		internal bool DVRSProfGeneralProxyLimitPatienceTimer_A41808_HiddenStatic
		{
			get
			{
				short num = (short)1056039950;
				short num2 = num;
				num = (short)1234101262;
				switch (num2 == num)
				{
				}
				num = (short)655097856;
				if (num != 0)
				{
				}
				num = (short)1305477121;
				if (num != 0)
				{
				}
				num = (short)2098135040;
				short num3 = num;
				return this.dVRSProfGeneralProxyLimitPatienceTimer_A41808.HiddenStatic;
			}
			set
			{
				short num = (short)464471999;
				short num2 = num;
				num = (short)1295534015;
				switch (num2 == num)
				{
				}
				num = (short)1213136897;
				if (num != 0)
				{
				}
				num = (short)337772544;
				if (num != 0)
				{
				}
				num = (short)756940800;
				short num3 = num;
				this.dVRSProfGeneralProxyLimitPatienceTimer_A41808.HiddenStatic = value;
			}
		}

		// Token: 0x17004FEE RID: 20462
		// (get) Token: 0x06009F2E RID: 40750 RVA: 0x00948B54 File Offset: 0x00946D54
		// (set) Token: 0x06009F2F RID: 40751 RVA: 0x00948C0C File Offset: 0x00946E0C
		internal bool DVRSProfGeneralProxyLimitPatienceTimer_A41808_HiddenDynamic
		{
			get
			{
				short num = (short)664797185;
				if (num != 0)
				{
				}
				num = (short)618524503;
				short num2 = num;
				num = (short)1414328151;
				switch (num2 == num)
				{
				}
				num = (short)1531052032;
				if (num != 0)
				{
				}
				num = (short)1716977664;
				short num3 = num;
				return this.dVRSProfGeneralProxyLimitPatienceTimer_A41808.HiddenDynamic;
			}
			set
			{
				short num = (short)257556481;
				if (num != 0)
				{
				}
				num = (short)1115064851;
				short num2 = num;
				num = (short)1974372883;
				switch (num2 == num)
				{
				}
				num = (short)1764491264;
				if (num != 0)
				{
				}
				num = (short)295763968;
				short num3 = num;
				this.dVRSProfGeneralProxyLimitPatienceTimer_A41808.HiddenDynamic = value;
			}
		}

		// Token: 0x17004FEF RID: 20463
		// (get) Token: 0x06009F30 RID: 40752 RVA: 0x00948CC4 File Offset: 0x00946EC4
		public bool DVRSProfGeneralProxyLimitPatienceTimer_A41808_HasDiffs
		{
			get
			{
				short num = (short)1439614271;
				short num2 = num;
				num = (short)868926783;
				switch (num2 == num)
				{
				}
				num = (short)1022296064;
				if (num != 0)
				{
				}
				num = (short)1767178241;
				if (num != 0)
				{
				}
				num = (short)710803456;
				short num3 = num;
				return this.dVRSProfGeneralProxyLimitPatienceTimer_A41808._HasDiffs;
			}
		}

		// Token: 0x17004FF0 RID: 20464
		// (get) Token: 0x06009F31 RID: 40753 RVA: 0x00948D78 File Offset: 0x00946F78
		// (set) Token: 0x06009F32 RID: 40754 RVA: 0x00948E30 File Offset: 0x00947030
		public string DVRSProfGeneralDVRSProfName_A41809Value
		{
			get
			{
				short num = (short)274203155;
				short num2 = num;
				num = (short)220332563;
				switch (num2 == num)
				{
				}
				num = (short)1077870592;
				if (num != 0)
				{
				}
				num = (short)295763969;
				if (num != 0)
				{
				}
				num = (short)173408256;
				short num3 = num;
				return this.dVRSProfGeneralDVRSProfName_A41809.Value;
			}
			set
			{
				short num = (short)1749407364;
				short num2 = num;
				num = (short)24106628;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_C9:
					this.dVRSProfGeneralDVRSProfName_A41809.Value = value;
					num = (short)1801912320;
					num3 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)2686976;
					if (num != 0)
					{
					}
					num = (short)1614610433;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					switch (num3)
					{
					case 0:
						goto IL_E9;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_7C;
						}
						continue;
					case 2:
						goto IL_C7;
					}
					IL_7C:
					if (string.IsNullOrEmpty(value.Trim()))
					{
						return;
					}
					num = (short)1091567617;
					if (num != 0)
					{
					}
					num = (short)1342832642;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_C7:
				goto IL_C9;
				IL_E9:
				num = (short)796655616;
				short num4 = num;
			}
		}

		// Token: 0x17004FF1 RID: 20465
		// (get) Token: 0x06009F33 RID: 40755 RVA: 0x00948F50 File Offset: 0x00947150
		// (set) Token: 0x06009F34 RID: 40756 RVA: 0x00949004 File Offset: 0x00947204
		public string DVRSProfGeneralDVRSProfName_A41809_UIValue
		{
			get
			{
				short num = (short)554874887;
				short num2 = num;
				num = (short)1971959815;
				switch (num2 == num)
				{
				}
				num = (short)1444872192;
				if (num != 0)
				{
				}
				num = (short)548536321;
				if (num != 0)
				{
				}
				num = (short)2086666240;
				short num3 = num;
				return this.dVRSProfGeneralDVRSProfName_A41809.Value;
			}
			set
			{
				short num = (short)1358665987;
				short num2 = num;
				num = (short)1115920643;
				switch (num2 == num)
				{
				}
				num = (short)276889601;
				if (num != 0)
				{
				}
				num = (short)946601984;
				if (num != 0)
				{
				}
				num = (short)300613632;
				short num3 = num;
				this.dVRSProfGeneralDVRSProfName_A41809.Value = value;
			}
		}

		// Token: 0x17004FF2 RID: 20466
		// (get) Token: 0x06009F35 RID: 40757 RVA: 0x009490B8 File Offset: 0x009472B8
		public global::AcpBusinessLayer.AcpKeyField DVRSProfGeneralDVRSProfName_A41809
		{
			get
			{
				short num = (short)935329793;
				if (num != 0)
				{
				}
				num = (short)1896195178;
				short num2 = num;
				num = (short)613786730;
				switch (num2 == num)
				{
				}
				num = (short)1037172736;
				if (num != 0)
				{
				}
				num = (short)584646656;
				short num3 = num;
				return this.dVRSProfGeneralDVRSProfName_A41809;
			}
		}

		// Token: 0x17004FF3 RID: 20467
		// (get) Token: 0x06009F36 RID: 40758 RVA: 0x00949164 File Offset: 0x00947364
		// (set) Token: 0x06009F37 RID: 40759 RVA: 0x00949218 File Offset: 0x00947418
		public bool DVRSProfGeneralDVRSProfName_A41809_Applicable
		{
			get
			{
				short num = (short)1758164287;
				short num2 = num;
				num = (short)1235449151;
				switch (num2 == num)
				{
				}
				num = (short)1126957057;
				if (num != 0)
				{
				}
				num = (short)394723328;
				if (num != 0)
				{
				}
				num = (short)1193017344;
				short num3 = num;
				return this.dVRSProfGeneralDVRSProfName_A41809.Applicable;
			}
			set
			{
				short num = (short)515444041;
				short num2 = num;
				num = (short)12520777;
				switch (num2 == num)
				{
				}
				num = (short)1856307200;
				if (num != 0)
				{
				}
				num = (short)105185281;
				if (num != 0)
				{
				}
				num = (short)1159790592;
				short num3 = num;
				this.dVRSProfGeneralDVRSProfName_A41809.Applicable = value;
			}
		}

		// Token: 0x17004FF4 RID: 20468
		// (get) Token: 0x06009F38 RID: 40760 RVA: 0x009492CC File Offset: 0x009474CC
		// (set) Token: 0x06009F39 RID: 40761 RVA: 0x00949380 File Offset: 0x00947580
		public bool DVRSProfGeneralDVRSProfName_A41809_Valid
		{
			get
			{
				short num = (short)1728613126;
				short num2 = num;
				num = (short)420580102;
				switch (num2 == num)
				{
				}
				num = (short)1884422145;
				if (num != 0)
				{
				}
				num = (short)2033319936;
				if (num != 0)
				{
				}
				num = (short)188809216;
				short num3 = num;
				return this.dVRSProfGeneralDVRSProfName_A41809.Valid;
			}
			set
			{
				short num = (short)1569157463;
				short num2 = num;
				num = (short)1237938519;
				switch (num2 == num)
				{
				}
				num = (short)2113404928;
				if (num != 0)
				{
				}
				num = (short)1901920257;
				if (num != 0)
				{
				}
				num = (short)45416448;
				short num3 = num;
				this.dVRSProfGeneralDVRSProfName_A41809.Valid = value;
			}
		}

		// Token: 0x17004FF5 RID: 20469
		// (get) Token: 0x06009F3A RID: 40762 RVA: 0x00949434 File Offset: 0x00947634
		// (set) Token: 0x06009F3B RID: 40763 RVA: 0x009494E8 File Offset: 0x009476E8
		public bool DVRSProfGeneralDVRSProfName_A41809_Visible
		{
			get
			{
				short num = (short)1295915561;
				short num2 = num;
				num = (short)148707881;
				switch (num2 == num)
				{
				}
				num = (short)20578304;
				if (num != 0)
				{
				}
				num = (short)2129657857;
				if (num != 0)
				{
				}
				num = (short)23068672;
				short num3 = num;
				return this.dVRSProfGeneralDVRSProfName_A41809.Visible;
			}
			set
			{
				short num = (short)1038317127;
				short num2 = num;
				num = (short)945387079;
				switch (num2 == num)
				{
				}
				num = (short)82640897;
				if (num != 0)
				{
				}
				num = (short)1299709952;
				if (num != 0)
				{
				}
				num = (short)597032960;
				short num3 = num;
				this.dVRSProfGeneralDVRSProfName_A41809.Visible = value;
			}
		}

		// Token: 0x17004FF6 RID: 20470
		// (get) Token: 0x06009F3C RID: 40764 RVA: 0x0094959C File Offset: 0x0094779C
		// (set) Token: 0x06009F3D RID: 40765 RVA: 0x00949654 File Offset: 0x00947854
		public bool DVRSProfGeneralDVRSProfName_A41809_Editable
		{
			get
			{
				short num = (short)1680874429;
				short num2 = num;
				num = (short)1467095997;
				switch (num2 == num)
				{
				}
				num = (short)212271104;
				if (num != 0)
				{
				}
				num = (short)429981697;
				if (num != 0)
				{
				}
				num = (short)1922498560;
				short num3 = num;
				return this.dVRSProfGeneralDVRSProfName_A41809.Editable;
			}
			set
			{
				short num = (short)1359937537;
				if (num != 0)
				{
				}
				num = (short)1255047092;
				short num2 = num;
				num = (short)1615429556;
				switch (num2 == num)
				{
				}
				num = (short)1709309952;
				if (num != 0)
				{
				}
				num = (short)1530462208;
				short num3 = num;
				this.dVRSProfGeneralDVRSProfName_A41809.Editable = value;
			}
		}

		// Token: 0x17004FF7 RID: 20471
		// (get) Token: 0x06009F3E RID: 40766 RVA: 0x00949708 File Offset: 0x00947908
		internal string DVRSProfGeneralDVRSProfName_A41809_UILabel
		{
			get
			{
				short num = (short)1169810112;
				short num2 = num;
				num = (short)2093212352;
				switch (num2 == num)
				{
				}
				num = (short)1909587968;
				if (num != 0)
				{
				}
				num = (short)573440001;
				if (num != 0)
				{
				}
				num = (short)1939079168;
				short num3 = num;
				return this.dVRSProfGeneralDVRSProfName_A41809.UIName;
			}
		}

		// Token: 0x17004FF8 RID: 20472
		// (get) Token: 0x06009F3F RID: 40767 RVA: 0x009497BC File Offset: 0x009479BC
		// (set) Token: 0x06009F40 RID: 40768 RVA: 0x00949870 File Offset: 0x00947A70
		internal bool DVRSProfGeneralDVRSProfName_A41809_HiddenStatic
		{
			get
			{
				short num = (short)1413225206;
				short num2 = num;
				num = (short)1989614326;
				switch (num2 == num)
				{
				}
				num = (short)47382529;
				if (num != 0)
				{
				}
				num = (short)1225588736;
				if (num != 0)
				{
				}
				num = (short)1537146880;
				short num3 = num;
				return this.dVRSProfGeneralDVRSProfName_A41809.HiddenStatic;
			}
			set
			{
				short num = (short)684986327;
				short num2 = num;
				num = (short)598544343;
				switch (num2 == num)
				{
				}
				num = (short)1081212928;
				if (num != 0)
				{
				}
				num = (short)718274561;
				if (num != 0)
				{
				}
				num = (short)184549376;
				short num3 = num;
				this.dVRSProfGeneralDVRSProfName_A41809.HiddenStatic = value;
			}
		}

		// Token: 0x17004FF9 RID: 20473
		// (get) Token: 0x06009F41 RID: 40769 RVA: 0x00949928 File Offset: 0x00947B28
		// (set) Token: 0x06009F42 RID: 40770 RVA: 0x009499DC File Offset: 0x00947BDC
		internal bool DVRSProfGeneralDVRSProfName_A41809_HiddenDynamic
		{
			get
			{
				short num = (short)1727606763;
				short num2 = num;
				num = (short)544354283;
				switch (num2 == num)
				{
				}
				num = (short)1639251969;
				if (num != 0)
				{
				}
				num = (short)1629028352;
				if (num != 0)
				{
				}
				num = (short)197263360;
				short num3 = num;
				return this.dVRSProfGeneralDVRSProfName_A41809.HiddenDynamic;
			}
			set
			{
				short num = (short)1026752513;
				if (num != 0)
				{
				}
				num = (short)983622592;
				short num2 = num;
				num = (short)1071834048;
				switch (num2 == num)
				{
				}
				num = (short)1677066240;
				if (num != 0)
				{
				}
				num = (short)1858535424;
				short num3 = num;
				this.dVRSProfGeneralDVRSProfName_A41809.HiddenDynamic = value;
			}
		}

		// Token: 0x17004FFA RID: 20474
		// (get) Token: 0x06009F43 RID: 40771 RVA: 0x00949A94 File Offset: 0x00947C94
		public bool DVRSProfGeneralDVRSProfName_A41809_HasDiffs
		{
			get
			{
				short num = (short)1575828120;
				short num2 = num;
				num = (short)263666328;
				switch (num2 == num)
				{
				}
				num = (short)2124218369;
				if (num != 0)
				{
				}
				num = (short)95092736;
				if (num != 0)
				{
				}
				num = (short)1402077184;
				short num3 = num;
				return this.dVRSProfGeneralDVRSProfName_A41809._HasDiffs;
			}
		}

		// Token: 0x17004FFB RID: 20475
		// (get) Token: 0x06009F44 RID: 40772 RVA: 0x00949B44 File Offset: 0x00947D44
		// (set) Token: 0x06009F45 RID: 40773 RVA: 0x00949BF8 File Offset: 0x00947DF8
		public int DVRSProfGeneralProxyRFSSReponseTimer_A41810Value
		{
			get
			{
				short num = (short)1782788441;
				short num2 = num;
				num = (short)441921881;
				switch (num2 == num)
				{
				}
				num = (short)1408303104;
				if (num != 0)
				{
				}
				num = (short)1449787393;
				if (num != 0)
				{
				}
				num = (short)2094137344;
				short num3 = num;
				return this.dVRSProfGeneralProxyRFSSReponseTimer_A41810.Value;
			}
			set
			{
				short num = (short)480310363;
				short num2 = num;
				num = (short)431682651;
				switch (num2 == num)
				{
				}
				num = (short)1964507136;
				if (num != 0)
				{
				}
				num = (short)1497169921;
				if (num != 0)
				{
				}
				num = (short)1174339584;
				short num3 = num;
				this.dVRSProfGeneralProxyRFSSReponseTimer_A41810.Value = value;
			}
		}

		// Token: 0x17004FFC RID: 20476
		// (get) Token: 0x06009F46 RID: 40774 RVA: 0x00949CAC File Offset: 0x00947EAC
		public global::AcpBusinessLayer.AcpSimpleRangeField DVRSProfGeneralProxyRFSSReponseTimer_A41810
		{
			get
			{
				short num = (short)974743319;
				short num2 = num;
				num = (short)1296656151;
				switch (num2 == num)
				{
				}
				num = (short)1706754049;
				if (num != 0)
				{
				}
				num = (short)1708195840;
				if (num != 0)
				{
				}
				num = (short)1997144064;
				short num3 = num;
				return this.dVRSProfGeneralProxyRFSSReponseTimer_A41810;
			}
		}

		// Token: 0x17004FFD RID: 20477
		// (get) Token: 0x06009F47 RID: 40775 RVA: 0x00949D5C File Offset: 0x00947F5C
		// (set) Token: 0x06009F48 RID: 40776 RVA: 0x00949E10 File Offset: 0x00948010
		public string DVRSProfGeneralProxyRFSSReponseTimer_A41810_UIValue
		{
			get
			{
				short num = (short)1593880811;
				short num2 = num;
				num = (short)1184477419;
				switch (num2 == num)
				{
				}
				num = (short)1884946433;
				if (num != 0)
				{
				}
				num = (short)1068892160;
				if (num != 0)
				{
				}
				num = (short)1311113216;
				short num3 = num;
				return this.dVRSProfGeneralProxyRFSSReponseTimer_A41810.UIValue;
			}
			set
			{
				short num = (short)1705685972;
				short num2 = num;
				num = (short)1026339796;
				switch (num2 == num)
				{
				}
				num = (short)541065217;
				if (num != 0)
				{
				}
				num = (short)2035351552;
				if (num != 0)
				{
				}
				num = (short)389742592;
				short num3 = num;
				this.dVRSProfGeneralProxyRFSSReponseTimer_A41810.UIValue = value;
			}
		}

		// Token: 0x17004FFE RID: 20478
		// (get) Token: 0x06009F49 RID: 40777 RVA: 0x00949EC8 File Offset: 0x009480C8
		// (set) Token: 0x06009F4A RID: 40778 RVA: 0x00949F7C File Offset: 0x0094817C
		internal int DVRSProfGeneralProxyRFSSReponseTimer_A41810Min
		{
			get
			{
				short num = (short)732531762;
				short num2 = num;
				num = (short)612994098;
				switch (num2 == num)
				{
				}
				num = (short)1852768257;
				if (num != 0)
				{
				}
				num = (short)268632064;
				if (num != 0)
				{
				}
				num = (short)1721499648;
				short num3 = num;
				return this.dVRSProfGeneralProxyRFSSReponseTimer_A41810.Min;
			}
			set
			{
				short num = (short)1750018307;
				short num2 = num;
				num = (short)1884563715;
				switch (num2 == num)
				{
				}
				num = (short)1472790529;
				if (num != 0)
				{
				}
				num = (short)424935424;
				if (num != 0)
				{
				}
				num = (short)1880621056;
				short num3 = num;
				this.dVRSProfGeneralProxyRFSSReponseTimer_A41810.Min = value;
			}
		}

		// Token: 0x17004FFF RID: 20479
		// (get) Token: 0x06009F4B RID: 40779 RVA: 0x0094A030 File Offset: 0x00948230
		// (set) Token: 0x06009F4C RID: 40780 RVA: 0x0094A0E8 File Offset: 0x009482E8
		internal int DVRSProfGeneralProxyRFSSReponseTimer_A41810Max
		{
			get
			{
				short num = (short)1562849868;
				short num2 = num;
				num = (short)376189516;
				switch (num2 == num)
				{
				}
				num = (short)1258422273;
				if (num != 0)
				{
				}
				num = (short)305135616;
				if (num != 0)
				{
				}
				num = (short)1731985408;
				short num3 = num;
				return this.dVRSProfGeneralProxyRFSSReponseTimer_A41810.Max;
			}
			set
			{
				short num = (short)582221825;
				if (num != 0)
				{
				}
				num = (short)977852904;
				short num2 = num;
				num = (short)1468520936;
				switch (num2 == num)
				{
				}
				num = (short)417136640;
				if (num != 0)
				{
				}
				num = (short)2123169792;
				short num3 = num;
				this.dVRSProfGeneralProxyRFSSReponseTimer_A41810.Max = value;
			}
		}

		// Token: 0x17005000 RID: 20480
		// (get) Token: 0x06009F4D RID: 40781 RVA: 0x0094A19C File Offset: 0x0094839C
		// (set) Token: 0x06009F4E RID: 40782 RVA: 0x0094A250 File Offset: 0x00948450
		internal int DVRSProfGeneralProxyRFSSReponseTimer_A41810Step
		{
			get
			{
				short num = (short)1815330263;
				short num2 = num;
				num = (short)1754381783;
				switch (num2 == num)
				{
				}
				num = (short)611778560;
				if (num != 0)
				{
				}
				num = (short)1108541441;
				if (num != 0)
				{
				}
				num = (short)1719795712;
				short num3 = num;
				return this.dVRSProfGeneralProxyRFSSReponseTimer_A41810.StepSize;
			}
			set
			{
				short num = (short)1209899809;
				short num2 = num;
				num = (short)1355782945;
				switch (num2 == num)
				{
				}
				num = (short)219611137;
				if (num != 0)
				{
				}
				num = (short)865730560;
				if (num != 0)
				{
				}
				num = (short)1030422528;
				short num3 = num;
				this.dVRSProfGeneralProxyRFSSReponseTimer_A41810.StepSize = value;
			}
		}

		// Token: 0x17005001 RID: 20481
		// (get) Token: 0x06009F4F RID: 40783 RVA: 0x0094A308 File Offset: 0x00948508
		// (set) Token: 0x06009F50 RID: 40784 RVA: 0x0094A3BC File Offset: 0x009485BC
		public bool DVRSProfGeneralProxyRFSSReponseTimer_A41810_Applicable
		{
			get
			{
				short num = (short)1381806136;
				short num2 = num;
				num = (short)1911533624;
				switch (num2 == num)
				{
				}
				num = (short)1414922240;
				if (num != 0)
				{
				}
				num = (short)699334657;
				if (num != 0)
				{
				}
				num = (short)95354880;
				short num3 = num;
				return this.dVRSProfGeneralProxyRFSSReponseTimer_A41810.Applicable;
			}
			set
			{
				short num = (short)1496262206;
				short num2 = num;
				num = (short)1306994238;
				switch (num2 == num)
				{
				}
				num = (short)581894145;
				if (num != 0)
				{
				}
				num = (short)1217462272;
				if (num != 0)
				{
				}
				num = (short)942997504;
				short num3 = num;
				this.dVRSProfGeneralProxyRFSSReponseTimer_A41810.Applicable = value;
			}
		}

		// Token: 0x17005002 RID: 20482
		// (get) Token: 0x06009F51 RID: 40785 RVA: 0x0094A474 File Offset: 0x00948674
		// (set) Token: 0x06009F52 RID: 40786 RVA: 0x0094A528 File Offset: 0x00948728
		public bool DVRSProfGeneralProxyRFSSReponseTimer_A41810_Valid
		{
			get
			{
				short num = (short)466201855;
				short num2 = num;
				num = (short)124103935;
				switch (num2 == num)
				{
				}
				num = (short)1752039424;
				if (num != 0)
				{
				}
				num = (short)391970817;
				if (num != 0)
				{
				}
				num = (short)1977090048;
				short num3 = num;
				return this.dVRSProfGeneralProxyRFSSReponseTimer_A41810.Valid;
			}
			set
			{
				short num = (short)1644025602;
				short num2 = num;
				num = (short)1894569730;
				switch (num2 == num)
				{
				}
				num = (short)188481537;
				if (num != 0)
				{
				}
				num = (short)2126905344;
				if (num != 0)
				{
				}
				num = (short)597229568;
				short num3 = num;
				this.dVRSProfGeneralProxyRFSSReponseTimer_A41810.Valid = value;
			}
		}

		// Token: 0x17005003 RID: 20483
		// (get) Token: 0x06009F53 RID: 40787 RVA: 0x0094A5DC File Offset: 0x009487DC
		// (set) Token: 0x06009F54 RID: 40788 RVA: 0x0094A690 File Offset: 0x00948890
		public bool DVRSProfGeneralProxyRFSSReponseTimer_A41810_Visible
		{
			get
			{
				short num = (short)829620225;
				if (num != 0)
				{
				}
				num = (short)1275381038;
				short num2 = num;
				num = (short)2068366638;
				switch (num2 == num)
				{
				}
				num = (short)1796276224;
				if (num != 0)
				{
				}
				num = (short)601096192;
				short num3 = num;
				return this.dVRSProfGeneralProxyRFSSReponseTimer_A41810.Visible;
			}
			set
			{
				short num = (short)1955495933;
				short num2 = num;
				num = (short)1112571901;
				switch (num2 == num)
				{
				}
				num = (short)1403715585;
				if (num != 0)
				{
				}
				num = (short)485621760;
				if (num != 0)
				{
				}
				num = (short)1337065472;
				short num3 = num;
				this.dVRSProfGeneralProxyRFSSReponseTimer_A41810.Visible = value;
			}
		}

		// Token: 0x17005004 RID: 20484
		// (get) Token: 0x06009F55 RID: 40789 RVA: 0x0094A744 File Offset: 0x00948944
		// (set) Token: 0x06009F56 RID: 40790 RVA: 0x0094A7F8 File Offset: 0x009489F8
		public bool DVRSProfGeneralProxyRFSSReponseTimer_A41810_Editable
		{
			get
			{
				short num = (short)1392707126;
				short num2 = num;
				num = (short)1632175670;
				switch (num2 == num)
				{
				}
				num = (short)519110657;
				if (num != 0)
				{
				}
				num = (short)787873792;
				if (num != 0)
				{
				}
				num = (short)349831168;
				short num3 = num;
				return this.dVRSProfGeneralProxyRFSSReponseTimer_A41810.Editable;
			}
			set
			{
				short num = (short)2062286849;
				if (num != 0)
				{
				}
				num = (short)1303749861;
				short num2 = num;
				num = (short)577283301;
				switch (num2 == num)
				{
				}
				num = (short)154075136;
				short num3 = num;
				num = (short)533200896;
				if (num != 0)
				{
				}
				this.dVRSProfGeneralProxyRFSSReponseTimer_A41810.Editable = value;
			}
		}

		// Token: 0x17005005 RID: 20485
		// (get) Token: 0x06009F57 RID: 40791 RVA: 0x0094A8B0 File Offset: 0x00948AB0
		internal string DVRSProfGeneralProxyRFSSReponseTimer_A41810_UILabel
		{
			get
			{
				short num = (short)1606585646;
				short num2 = num;
				num = (short)1753976110;
				switch (num2 == num)
				{
				}
				num = (short)765132801;
				if (num != 0)
				{
				}
				num = (short)1992097792;
				short num3 = num;
				num = (short)2048786432;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralProxyRFSSReponseTimer_A41810.UIName;
			}
		}

		// Token: 0x17005006 RID: 20486
		// (get) Token: 0x06009F58 RID: 40792 RVA: 0x0094A964 File Offset: 0x00948B64
		// (set) Token: 0x06009F59 RID: 40793 RVA: 0x0094AA1C File Offset: 0x00948C1C
		internal bool DVRSProfGeneralProxyRFSSReponseTimer_A41810_HiddenStatic
		{
			get
			{
				short num = (short)974787375;
				short num2 = num;
				num = (short)879366959;
				switch (num2 == num)
				{
				}
				num = (short)767950848;
				if (num != 0)
				{
				}
				num = (short)272760832;
				short num3 = num;
				num = (short)214958081;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralProxyRFSSReponseTimer_A41810.HiddenStatic;
			}
			set
			{
				short num = (short)910260918;
				short num2 = num;
				num = (short)1771141814;
				switch (num2 == num)
				{
				}
				num = (short)1929117697;
				if (num != 0)
				{
				}
				num = (short)876609536;
				short num3 = num;
				num = (short)1288372224;
				if (num != 0)
				{
				}
				this.dVRSProfGeneralProxyRFSSReponseTimer_A41810.HiddenStatic = value;
			}
		}

		// Token: 0x17005007 RID: 20487
		// (get) Token: 0x06009F5A RID: 40794 RVA: 0x0094AAD0 File Offset: 0x00948CD0
		// (set) Token: 0x06009F5B RID: 40795 RVA: 0x0094AB84 File Offset: 0x00948D84
		internal bool DVRSProfGeneralProxyRFSSReponseTimer_A41810_HiddenDynamic
		{
			get
			{
				short num = (short)1054551515;
				short num2 = num;
				num = (short)1198271963;
				switch (num2 == num)
				{
				}
				num = (short)1419575296;
				if (num != 0)
				{
				}
				num = (short)166133760;
				short num3 = num;
				num = (short)620036097;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralProxyRFSSReponseTimer_A41810.HiddenDynamic;
			}
			set
			{
				short num = (short)2051045162;
				short num2 = num;
				num = (short)667055914;
				switch (num2 == num)
				{
				}
				num = (short)1298333696;
				if (num != 0)
				{
				}
				num = (short)438370304;
				short num3 = num;
				num = (short)531693569;
				if (num != 0)
				{
				}
				this.dVRSProfGeneralProxyRFSSReponseTimer_A41810.HiddenDynamic = value;
			}
		}

		// Token: 0x17005008 RID: 20488
		// (get) Token: 0x06009F5C RID: 40796 RVA: 0x0094AC3C File Offset: 0x00948E3C
		public bool DVRSProfGeneralProxyRFSSReponseTimer_A41810_HasDiffs
		{
			get
			{
				short num = (short)1713559130;
				short num2 = num;
				num = (short)2145965658;
				switch (num2 == num)
				{
				}
				num = (short)961150977;
				if (num != 0)
				{
				}
				num = (short)1534853120;
				short num3 = num;
				num = (short)1818034176;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralProxyRFSSReponseTimer_A41810._HasDiffs;
			}
		}

		// Token: 0x17005009 RID: 20489
		// (get) Token: 0x06009F5D RID: 40797 RVA: 0x0094ACEC File Offset: 0x00948EEC
		// (set) Token: 0x06009F5E RID: 40798 RVA: 0x0094ADA0 File Offset: 0x00948FA0
		public int DVRSProfGeneralGenStsOnDVRSModChgHoldoff_A41869Value
		{
			get
			{
				short num = (short)254539665;
				short num2 = num;
				num = (short)365819793;
				switch (num2 == num)
				{
				}
				num = (short)1413677056;
				if (num != 0)
				{
				}
				num = (short)807993344;
				short num3 = num;
				num = (short)2113077249;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralGenStsOnDVRSModChgHoldoff_A41869.Value;
			}
			set
			{
				short num = (short)482398850;
				short num2 = num;
				num = (short)1617810050;
				switch (num2 == num)
				{
				}
				num = (short)367722496;
				if (num != 0)
				{
				}
				num = (short)1529479168;
				short num3 = num;
				num = (short)13172737;
				if (num != 0)
				{
				}
				this.dVRSProfGeneralGenStsOnDVRSModChgHoldoff_A41869.Value = value;
			}
		}

		// Token: 0x1700500A RID: 20490
		// (get) Token: 0x06009F5F RID: 40799 RVA: 0x0094AE54 File Offset: 0x00949054
		public global::AcpBusinessLayer.AcpSimpleRangeField DVRSProfGeneralGenStsOnDVRSModChgHoldoff_A41869
		{
			get
			{
				short num = (short)1480195603;
				short num2 = num;
				num = (short)1986264595;
				switch (num2 == num)
				{
				}
				num = (short)569049088;
				if (num != 0)
				{
				}
				num = (short)1101725696;
				short num3 = num;
				num = (short)1681719297;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralGenStsOnDVRSModChgHoldoff_A41869;
			}
		}

		// Token: 0x1700500B RID: 20491
		// (get) Token: 0x06009F60 RID: 40800 RVA: 0x0094AF04 File Offset: 0x00949104
		// (set) Token: 0x06009F61 RID: 40801 RVA: 0x0094AFBC File Offset: 0x009491BC
		public string DVRSProfGeneralGenStsOnDVRSModChgHoldoff_A41869_UIValue
		{
			get
			{
				short num = (short)289098496;
				short num2 = num;
				num = (short)1659718400;
				switch (num2 == num)
				{
				}
				num = (short)1809645569;
				if (num != 0)
				{
				}
				num = (short)79429632;
				short num3 = num;
				num = (short)778502144;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralGenStsOnDVRSModChgHoldoff_A41869.UIValue;
			}
			set
			{
				short num = (short)2097240714;
				short num2 = num;
				num = (short)1589009034;
				switch (num2 == num)
				{
				}
				num = (short)326893569;
				if (num != 0)
				{
				}
				num = (short)1602355200;
				short num3 = num;
				num = (short)1885274112;
				if (num != 0)
				{
				}
				this.dVRSProfGeneralGenStsOnDVRSModChgHoldoff_A41869.UIValue = value;
			}
		}

		// Token: 0x1700500C RID: 20492
		// (get) Token: 0x06009F62 RID: 40802 RVA: 0x0094B070 File Offset: 0x00949270
		// (set) Token: 0x06009F63 RID: 40803 RVA: 0x0094B124 File Offset: 0x00949324
		internal int DVRSProfGeneralGenStsOnDVRSModChgHoldoff_A41869Min
		{
			get
			{
				short num = (short)1508835329;
				if (num != 0)
				{
				}
				num = (short)970292826;
				short num2 = num;
				num = (short)2034990682;
				switch (num2 == num)
				{
				}
				num = (short)1578369024;
				short num3 = num;
				num = (short)1394606080;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralGenStsOnDVRSModChgHoldoff_A41869.Min;
			}
			set
			{
				short num = (short)934523939;
				short num2 = num;
				num = (short)1955968035;
				switch (num2 == num)
				{
				}
				num = (short)920453121;
				if (num != 0)
				{
				}
				num = (short)120061952;
				short num3 = num;
				num = (short)648216576;
				if (num != 0)
				{
				}
				this.dVRSProfGeneralGenStsOnDVRSModChgHoldoff_A41869.Min = value;
			}
		}

		// Token: 0x1700500D RID: 20493
		// (get) Token: 0x06009F64 RID: 40804 RVA: 0x0094B1D8 File Offset: 0x009493D8
		// (set) Token: 0x06009F65 RID: 40805 RVA: 0x0094B28C File Offset: 0x0094948C
		internal int DVRSProfGeneralGenStsOnDVRSModChgHoldoff_A41869Max
		{
			get
			{
				short num = (short)1005020158;
				short num2 = num;
				num = (short)37315582;
				switch (num2 == num)
				{
				}
				num = (short)888668161;
				if (num != 0)
				{
				}
				num = (short)1183383552;
				short num3 = num;
				num = (short)981401600;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralGenStsOnDVRSModChgHoldoff_A41869.Max;
			}
			set
			{
				short num = (short)1505342654;
				short num2 = num;
				num = (short)490583230;
				switch (num2 == num)
				{
				}
				num = (short)1116012544;
				if (num != 0)
				{
				}
				num = (short)758054912;
				short num3 = num;
				num = (short)1935343617;
				if (num != 0)
				{
				}
				this.dVRSProfGeneralGenStsOnDVRSModChgHoldoff_A41869.Max = value;
			}
		}

		// Token: 0x1700500E RID: 20494
		// (get) Token: 0x06009F66 RID: 40806 RVA: 0x0094B344 File Offset: 0x00949544
		// (set) Token: 0x06009F67 RID: 40807 RVA: 0x0094B3F8 File Offset: 0x009495F8
		internal int DVRSProfGeneralGenStsOnDVRSModChgHoldoff_A41869Step
		{
			get
			{
				short num = (short)854939833;
				short num2 = num;
				num = (short)23419065;
				switch (num2 == num)
				{
				}
				num = (short)615907329;
				if (num != 0)
				{
				}
				num = (short)1458372608;
				short num3 = num;
				num = (short)12582912;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralGenStsOnDVRSModChgHoldoff_A41869.StepSize;
			}
			set
			{
				short num = (short)188743681;
				if (num != 0)
				{
				}
				num = (short)1492766947;
				short num2 = num;
				num = (short)250335459;
				switch (num2 == num)
				{
				}
				num = (short)1201471488;
				short num3 = num;
				num = (short)842006528;
				if (num != 0)
				{
				}
				this.dVRSProfGeneralGenStsOnDVRSModChgHoldoff_A41869.StepSize = value;
			}
		}

		// Token: 0x1700500F RID: 20495
		// (get) Token: 0x06009F68 RID: 40808 RVA: 0x0094B4AC File Offset: 0x009496AC
		// (set) Token: 0x06009F69 RID: 40809 RVA: 0x0094B564 File Offset: 0x00949764
		public bool DVRSProfGeneralGenStsOnDVRSModChgHoldoff_A41869_Applicable
		{
			get
			{
				short num = (short)618306300;
				short num2 = num;
				num = (short)1446222588;
				switch (num2 == num)
				{
				}
				num = (short)1103757313;
				if (num != 0)
				{
				}
				num = (short)1790771200;
				short num3 = num;
				num = (short)1023541248;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralGenStsOnDVRSModChgHoldoff_A41869.Applicable;
			}
			set
			{
				short num = (short)721757593;
				short num2 = num;
				num = (short)726607257;
				switch (num2 == num)
				{
				}
				num = (short)1787035649;
				if (num != 0)
				{
				}
				num = (short)665255936;
				short num3 = num;
				num = (short)58327040;
				if (num != 0)
				{
				}
				this.dVRSProfGeneralGenStsOnDVRSModChgHoldoff_A41869.Applicable = value;
			}
		}

		// Token: 0x17005010 RID: 20496
		// (get) Token: 0x06009F6A RID: 40810 RVA: 0x0094B618 File Offset: 0x00949818
		// (set) Token: 0x06009F6B RID: 40811 RVA: 0x0094B6D0 File Offset: 0x009498D0
		public bool DVRSProfGeneralGenStsOnDVRSModChgHoldoff_A41869_Valid
		{
			get
			{
				short num = (short)1621820467;
				short num2 = num;
				num = (short)1153500211;
				switch (num2 == num)
				{
				}
				num = (short)1056440321;
				if (num != 0)
				{
				}
				num = (short)768540672;
				short num3 = num;
				num = (short)13959168;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralGenStsOnDVRSModChgHoldoff_A41869.Valid;
			}
			set
			{
				short num = (short)1834290384;
				short num2 = num;
				num = (short)1199246544;
				switch (num2 == num)
				{
				}
				num = (short)2139619329;
				if (num != 0)
				{
				}
				num = (short)1842806784;
				short num3 = num;
				num = (short)1645084672;
				if (num != 0)
				{
				}
				this.dVRSProfGeneralGenStsOnDVRSModChgHoldoff_A41869.Valid = value;
			}
		}

		// Token: 0x17005011 RID: 20497
		// (get) Token: 0x06009F6C RID: 40812 RVA: 0x0094B788 File Offset: 0x00949988
		// (set) Token: 0x06009F6D RID: 40813 RVA: 0x0094B840 File Offset: 0x00949A40
		public bool DVRSProfGeneralGenStsOnDVRSModChgHoldoff_A41869_Visible
		{
			get
			{
				short num = (short)481721190;
				short num2 = num;
				num = (short)928086886;
				switch (num2 == num)
				{
				}
				num = (short)1445527553;
				if (num != 0)
				{
				}
				num = (short)2091253760;
				short num3 = num;
				num = (short)1028915200;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralGenStsOnDVRSModChgHoldoff_A41869.Visible;
			}
			set
			{
				short num = (short)647692289;
				if (num != 0)
				{
				}
				num = (short)1972519667;
				short num2 = num;
				num = (short)210060019;
				switch (num2 == num)
				{
				}
				num = (short)740360192;
				short num3 = num;
				num = (short)878379008;
				if (num != 0)
				{
				}
				this.dVRSProfGeneralGenStsOnDVRSModChgHoldoff_A41869.Visible = value;
			}
		}

		// Token: 0x17005012 RID: 20498
		// (get) Token: 0x06009F6E RID: 40814 RVA: 0x0094B8F4 File Offset: 0x00949AF4
		// (set) Token: 0x06009F6F RID: 40815 RVA: 0x0094B9A8 File Offset: 0x00949BA8
		public bool DVRSProfGeneralGenStsOnDVRSModChgHoldoff_A41869_Editable
		{
			get
			{
				short num = (short)494613345;
				short num2 = num;
				num = (short)316486497;
				switch (num2 == num)
				{
				}
				num = (short)1755578368;
				if (num != 0)
				{
				}
				num = (short)2126643200;
				short num3 = num;
				num = (short)512163841;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralGenStsOnDVRSModChgHoldoff_A41869.Editable;
			}
			set
			{
				short num = (short)1894960431;
				short num2 = num;
				num = (short)884460847;
				switch (num2 == num)
				{
				}
				num = (short)1353711617;
				if (num != 0)
				{
				}
				num = (short)1339424768;
				short num3 = num;
				num = (short)848035840;
				if (num != 0)
				{
				}
				this.dVRSProfGeneralGenStsOnDVRSModChgHoldoff_A41869.Editable = value;
			}
		}

		// Token: 0x17005013 RID: 20499
		// (get) Token: 0x06009F70 RID: 40816 RVA: 0x0094BA5C File Offset: 0x00949C5C
		internal string DVRSProfGeneralGenStsOnDVRSModChgHoldoff_A41869_UILabel
		{
			get
			{
				short num = (short)652138037;
				short num2 = num;
				num = (short)1999230517;
				switch (num2 == num)
				{
				}
				num = (short)1358757889;
				if (num != 0)
				{
				}
				num = (short)1207828480;
				short num3 = num;
				num = (short)2090008576;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralGenStsOnDVRSModChgHoldoff_A41869.UIName;
			}
		}

		// Token: 0x17005014 RID: 20500
		// (get) Token: 0x06009F71 RID: 40817 RVA: 0x0094BB10 File Offset: 0x00949D10
		// (set) Token: 0x06009F72 RID: 40818 RVA: 0x0094BBC4 File Offset: 0x00949DC4
		internal bool DVRSProfGeneralGenStsOnDVRSModChgHoldoff_A41869_HiddenStatic
		{
			get
			{
				short num = (short)1282408449;
				if (num != 0)
				{
				}
				num = (short)399993329;
				short num2 = num;
				num = (short)312175089;
				switch (num2 == num)
				{
				}
				num = (short)6029312;
				short num3 = num;
				num = (short)882573312;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralGenStsOnDVRSModChgHoldoff_A41869.HiddenStatic;
			}
			set
			{
				short num = (short)2065432577;
				if (num != 0)
				{
				}
				num = (short)9392137;
				short num2 = num;
				num = (short)1194348553;
				switch (num2 == num)
				{
				}
				num = (short)1320353792;
				short num3 = num;
				num = (short)99876864;
				if (num != 0)
				{
				}
				this.dVRSProfGeneralGenStsOnDVRSModChgHoldoff_A41869.HiddenStatic = value;
			}
		}

		// Token: 0x17005015 RID: 20501
		// (get) Token: 0x06009F73 RID: 40819 RVA: 0x0094BC78 File Offset: 0x00949E78
		// (set) Token: 0x06009F74 RID: 40820 RVA: 0x0094BD2C File Offset: 0x00949F2C
		internal bool DVRSProfGeneralGenStsOnDVRSModChgHoldoff_A41869_HiddenDynamic
		{
			get
			{
				short num = (short)2130669245;
				short num2 = num;
				num = (short)1449160381;
				switch (num2 == num)
				{
				}
				num = (short)629800960;
				if (num != 0)
				{
				}
				num = (short)1174405120;
				short num3 = num;
				num = (short)413925377;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralGenStsOnDVRSModChgHoldoff_A41869.HiddenDynamic;
			}
			set
			{
				short num = (short)905750705;
				short num2 = num;
				num = (short)1367845041;
				switch (num2 == num)
				{
				}
				num = (short)860684288;
				if (num != 0)
				{
				}
				num = (short)585498624;
				short num3 = num;
				num = (short)2082865153;
				if (num != 0)
				{
				}
				this.dVRSProfGeneralGenStsOnDVRSModChgHoldoff_A41869.HiddenDynamic = value;
			}
		}

		// Token: 0x17005016 RID: 20502
		// (get) Token: 0x06009F75 RID: 40821 RVA: 0x0094BDE0 File Offset: 0x00949FE0
		public bool DVRSProfGeneralGenStsOnDVRSModChgHoldoff_A41869_HasDiffs
		{
			get
			{
				short num = (short)1185684881;
				short num2 = num;
				num = (short)1414798737;
				switch (num2 == num)
				{
				}
				num = (short)374865920;
				if (num != 0)
				{
				}
				num = (short)288358400;
				short num3 = num;
				num = (short)1978466305;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralGenStsOnDVRSModChgHoldoff_A41869._HasDiffs;
			}
		}

		// Token: 0x17005017 RID: 20503
		// (get) Token: 0x06009F76 RID: 40822 RVA: 0x0094BE94 File Offset: 0x0094A094
		// (set) Token: 0x06009F77 RID: 40823 RVA: 0x0094BF4C File Offset: 0x0094A14C
		public bool DVRSProfGeneralGenStsLegacyModeValue
		{
			get
			{
				short num = (short)953326329;
				short num2 = num;
				num = (short)407870201;
				switch (num2 == num)
				{
				}
				num = (short)804257793;
				if (num != 0)
				{
				}
				num = (short)1401880576;
				short num3 = num;
				num = (short)329842688;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralGenStsLegacyMode.Value;
			}
			set
			{
				short num = (short)945359264;
				short num2 = num;
				num = (short)806160800;
				switch (num2 == num)
				{
				}
				num = (short)1520893953;
				if (num != 0)
				{
				}
				num = (short)597688320;
				short num3 = num;
				num = (short)2124087296;
				if (num != 0)
				{
				}
				this.dVRSProfGeneralGenStsLegacyMode.Value = value;
			}
		}

		// Token: 0x17005018 RID: 20504
		// (get) Token: 0x06009F78 RID: 40824 RVA: 0x0094C004 File Offset: 0x0094A204
		public global::AcpBusinessLayer.AcpField<bool> DVRSProfGeneralGenStsLegacyMode
		{
			get
			{
				short num = (short)909740805;
				short num2 = num;
				num = (short)1305774853;
				switch (num2 == num)
				{
				}
				num = (short)749338625;
				if (num != 0)
				{
				}
				num = (short)980287488;
				short num3 = num;
				num = (short)19660800;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralGenStsLegacyMode;
			}
		}

		// Token: 0x17005019 RID: 20505
		// (get) Token: 0x06009F79 RID: 40825 RVA: 0x0094C0B0 File Offset: 0x0094A2B0
		// (set) Token: 0x06009F7A RID: 40826 RVA: 0x0094C160 File Offset: 0x0094A360
		public bool DVRSProfGeneralGenStsLegacyMode_UIValue
		{
			get
			{
				short num = (short)1080448657;
				short num2 = num;
				num = (short)965760657;
				switch (num2 == num)
				{
				}
				num = (short)345112577;
				if (num != 0)
				{
				}
				num = (short)1674379264;
				short num3 = num;
				num = (short)826474496;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralGenStsLegacyMode.Value;
			}
			set
			{
				short num = (short)2023696232;
				short num2 = num;
				num = (short)1842292584;
				switch (num2 == num)
				{
				}
				num = (short)1665794049;
				if (num != 0)
				{
				}
				num = (short)971374592;
				short num3 = num;
				num = (short)2065170432;
				if (num != 0)
				{
				}
				this.dVRSProfGeneralGenStsLegacyMode.Value = value;
			}
		}

		// Token: 0x1700501A RID: 20506
		// (get) Token: 0x06009F7B RID: 40827 RVA: 0x0094C218 File Offset: 0x0094A418
		// (set) Token: 0x06009F7C RID: 40828 RVA: 0x0094C2CC File Offset: 0x0094A4CC
		public bool DVRSProfGeneralGenStsLegacyMode_Applicable
		{
			get
			{
				short num = (short)611038883;
				short num2 = num;
				num = (short)519419555;
				switch (num2 == num)
				{
				}
				num = (short)314834945;
				if (num != 0)
				{
				}
				num = (short)106364928;
				short num3 = num;
				num = (short)2085945344;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralGenStsLegacyMode.Applicable;
			}
			set
			{
				short num = (short)1413545985;
				if (num != 0)
				{
				}
				num = (short)924173952;
				short num2 = num;
				num = (short)1469433472;
				switch (num2 == num)
				{
				}
				num = (short)624099328;
				short num3 = num;
				num = (short)686030848;
				if (num != 0)
				{
				}
				this.dVRSProfGeneralGenStsLegacyMode.Applicable = value;
			}
		}

		// Token: 0x1700501B RID: 20507
		// (get) Token: 0x06009F7D RID: 40829 RVA: 0x0094C380 File Offset: 0x0094A580
		// (set) Token: 0x06009F7E RID: 40830 RVA: 0x0094C434 File Offset: 0x0094A634
		public bool DVRSProfGeneralGenStsLegacyMode_Valid
		{
			get
			{
				short num = (short)1159655405;
				short num2 = num;
				num = (short)2062741485;
				switch (num2 == num)
				{
				}
				num = (short)1454833665;
				if (num != 0)
				{
				}
				num = (short)1026162688;
				short num3 = num;
				num = (short)96010240;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralGenStsLegacyMode.Valid;
			}
			set
			{
				short num = (short)254335632;
				short num2 = num;
				num = (short)760470160;
				switch (num2 == num)
				{
				}
				num = (short)1103691776;
				if (num != 0)
				{
				}
				num = (short)1604583424;
				short num3 = num;
				num = (short)48037889;
				if (num != 0)
				{
				}
				this.dVRSProfGeneralGenStsLegacyMode.Valid = value;
			}
		}

		// Token: 0x1700501C RID: 20508
		// (get) Token: 0x06009F7F RID: 40831 RVA: 0x0094C4EC File Offset: 0x0094A6EC
		// (set) Token: 0x06009F80 RID: 40832 RVA: 0x0094C5A0 File Offset: 0x0094A7A0
		public bool DVRSProfGeneralGenStsLegacyMode_Visible
		{
			get
			{
				short num = (short)30063683;
				short num2 = num;
				num = (short)1181727811;
				switch (num2 == num)
				{
				}
				num = (short)2146959361;
				if (num != 0)
				{
				}
				num = (short)1104412672;
				short num3 = num;
				num = (short)176226304;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralGenStsLegacyMode.Visible;
			}
			set
			{
				short num = (short)1613871536;
				short num2 = num;
				num = (short)1703131568;
				switch (num2 == num)
				{
				}
				num = (short)408879104;
				if (num != 0)
				{
				}
				num = (short)1978728448;
				short num3 = num;
				num = (short)1970536449;
				if (num != 0)
				{
				}
				this.dVRSProfGeneralGenStsLegacyMode.Visible = value;
			}
		}

		// Token: 0x1700501D RID: 20509
		// (get) Token: 0x06009F81 RID: 40833 RVA: 0x0094C658 File Offset: 0x0094A858
		// (set) Token: 0x06009F82 RID: 40834 RVA: 0x0094C70C File Offset: 0x0094A90C
		public bool DVRSProfGeneralGenStsLegacyMode_Editable
		{
			get
			{
				short num = (short)240134895;
				short num2 = num;
				num = (short)531639023;
				switch (num2 == num)
				{
				}
				num = (short)557776896;
				if (num != 0)
				{
				}
				num = (short)1754267648;
				short num3 = num;
				num = (short)714014721;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralGenStsLegacyMode.Editable;
			}
			set
			{
				short num = (short)163178316;
				short num2 = num;
				num = (short)380233548;
				switch (num2 == num)
				{
				}
				num = (short)1134231553;
				if (num != 0)
				{
				}
				num = (short)459931648;
				short num3 = num;
				num = (short)611057664;
				if (num != 0)
				{
				}
				this.dVRSProfGeneralGenStsLegacyMode.Editable = value;
			}
		}

		// Token: 0x1700501E RID: 20510
		// (get) Token: 0x06009F83 RID: 40835 RVA: 0x0094C7C0 File Offset: 0x0094A9C0
		internal string DVRSProfGeneralGenStsLegacyMode_UILabel
		{
			get
			{
				short num = (short)1073708893;
				short num2 = num;
				num = (short)77692765;
				switch (num2 == num)
				{
				}
				num = (short)1068695553;
				if (num != 0)
				{
				}
				num = (short)588185600;
				short num3 = num;
				num = (short)1182334976;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralGenStsLegacyMode.UIName;
			}
		}

		// Token: 0x1700501F RID: 20511
		// (get) Token: 0x06009F84 RID: 40836 RVA: 0x0094C874 File Offset: 0x0094AA74
		// (set) Token: 0x06009F85 RID: 40837 RVA: 0x0094C928 File Offset: 0x0094AB28
		internal bool DVRSProfGeneralGenStsLegacyMode_HiddenStatic
		{
			get
			{
				short num = (short)1763655548;
				short num2 = num;
				num = (short)56049532;
				switch (num2 == num)
				{
				}
				num = (short)989593601;
				if (num != 0)
				{
				}
				num = (short)9240576;
				short num3 = num;
				num = (short)195493888;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralGenStsLegacyMode.HiddenStatic;
			}
			set
			{
				short num = (short)985917182;
				short num2 = num;
				num = (short)1674045182;
				switch (num2 == num)
				{
				}
				num = (short)158597121;
				if (num != 0)
				{
				}
				num = (short)1925578752;
				short num3 = num;
				num = (short)33619968;
				if (num != 0)
				{
				}
				this.dVRSProfGeneralGenStsLegacyMode.HiddenStatic = value;
			}
		}

		// Token: 0x17005020 RID: 20512
		// (get) Token: 0x06009F86 RID: 40838 RVA: 0x0094C9E0 File Offset: 0x0094ABE0
		// (set) Token: 0x06009F87 RID: 40839 RVA: 0x0094CA94 File Offset: 0x0094AC94
		internal bool DVRSProfGeneralGenStsLegacyMode_HiddenDynamic
		{
			get
			{
				short num = (short)1989233721;
				short num2 = num;
				num = (short)584797241;
				switch (num2 == num)
				{
				}
				num = (short)1154678785;
				if (num != 0)
				{
				}
				num = (short)365166592;
				short num3 = num;
				num = (short)531169280;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralGenStsLegacyMode.HiddenDynamic;
			}
			set
			{
				short num = (short)1476489599;
				short num2 = num;
				num = (short)1760194943;
				switch (num2 == num)
				{
				}
				num = (short)1666646017;
				if (num != 0)
				{
				}
				num = (short)1151336448;
				short num3 = num;
				num = (short)1657667584;
				if (num != 0)
				{
				}
				this.dVRSProfGeneralGenStsLegacyMode.HiddenDynamic = value;
			}
		}

		// Token: 0x17005021 RID: 20513
		// (get) Token: 0x06009F88 RID: 40840 RVA: 0x0094CB4C File Offset: 0x0094AD4C
		public bool DVRSProfGeneralGenStsLegacyMode_HasDiffs
		{
			get
			{
				short num = (short)1169577030;
				short num2 = num;
				num = (short)1847415878;
				switch (num2 == num)
				{
				}
				num = (short)1415708673;
				if (num != 0)
				{
				}
				num = (short)934150144;
				short num3 = num;
				num = (short)147390464;
				if (num != 0)
				{
				}
				return this.dVRSProfGeneralGenStsLegacyMode._HasDiffs;
			}
		}

		// Token: 0x17005022 RID: 20514
		// (get) Token: 0x06009F89 RID: 40841 RVA: 0x0094CC00 File Offset: 0x0094AE00
		// (set) Token: 0x06009F8A RID: 40842 RVA: 0x0094CCB4 File Offset: 0x0094AEB4
		public bool DVRSProfGeneralSuspendScanOnDVRSActive_42782Value
		{
			get
			{
				short num = (short)1350895135;
				short num2 = num;
				num = (short)866059807;
				switch (num2 == num)
				{
				}
				num = (short)124649473;
				if (num != 0)
				{
				}
				num = (short)230490112;
				if (num != 0)
				{
				}
				num = (short)1109721088;
				short num3 = num;
				return this.dVRSProfGeneralSuspendScanOnDVRSActive_42782.Value;
			}
			set
			{
				short num = (short)1635527218;
				short num2 = num;
				num = (short)1502489138;
				switch (num2 == num)
				{
				}
				num = (short)876806144;
				if (num != 0)
				{
				}
				num = (short)1887043585;
				if (num != 0)
				{
				}
				num = (short)968687616;
				short num3 = num;
				this.dVRSProfGeneralSuspendScanOnDVRSActive_42782.Value = value;
			}
		}

		// Token: 0x17005023 RID: 20515
		// (get) Token: 0x06009F8B RID: 40843 RVA: 0x0094CD68 File Offset: 0x0094AF68
		public global::AcpBusinessLayer.AcpField<bool> DVRSProfGeneralSuspendScanOnDVRSActive_42782
		{
			get
			{
				short num = (short)1872714339;
				short num2 = num;
				num = (short)1846172259;
				switch (num2 == num)
				{
				}
				num = (short)1590558720;
				if (num != 0)
				{
				}
				num = (short)1653211137;
				if (num != 0)
				{
				}
				num = (short)451346432;
				short num3 = num;
				return this.dVRSProfGeneralSuspendScanOnDVRSActive_42782;
			}
		}

		// Token: 0x17005024 RID: 20516
		// (get) Token: 0x06009F8C RID: 40844 RVA: 0x0094CE18 File Offset: 0x0094B018
		// (set) Token: 0x06009F8D RID: 40845 RVA: 0x0094CECC File Offset: 0x0094B0CC
		public bool DVRSProfGeneralSuspendScanOnDVRSActive_42782_UIValue
		{
			get
			{
				short num = (short)1150484481;
				if (num != 0)
				{
				}
				num = (short)1367605763;
				short num2 = num;
				num = (short)2047607299;
				switch (num2 == num)
				{
				}
				num = (short)943783936;
				if (num != 0)
				{
				}
				num = (short)294977536;
				short num3 = num;
				return this.dVRSProfGeneralSuspendScanOnDVRSActive_42782.Value;
			}
			set
			{
				short num = (short)721459221;
				short num2 = num;
				num = (short)214865941;
				switch (num2 == num)
				{
				}
				num = (short)2027749377;
				if (num != 0)
				{
				}
				num = (short)1880227840;
				if (num != 0)
				{
				}
				num = (short)672530432;
				short num3 = num;
				this.dVRSProfGeneralSuspendScanOnDVRSActive_42782.Value = value;
			}
		}

		// Token: 0x17005025 RID: 20517
		// (get) Token: 0x06009F8E RID: 40846 RVA: 0x0094CF84 File Offset: 0x0094B184
		// (set) Token: 0x06009F8F RID: 40847 RVA: 0x0094D038 File Offset: 0x0094B238
		public bool DVRSProfGeneralSuspendScanOnDVRSActive_42782_Applicable
		{
			get
			{
				short num = (short)1160904705;
				if (num != 0)
				{
				}
				num = (short)828838344;
				short num2 = num;
				num = (short)531173832;
				switch (num2 == num)
				{
				}
				num = (short)615776256;
				if (num != 0)
				{
				}
				num = (short)489488384;
				short num3 = num;
				return this.dVRSProfGeneralSuspendScanOnDVRSActive_42782.Applicable;
			}
			set
			{
				short num = (short)1506136124;
				short num2 = num;
				num = (short)774688828;
				switch (num2 == num)
				{
				}
				num = (short)801701888;
				if (num != 0)
				{
				}
				num = (short)963641345;
				if (num != 0)
				{
				}
				num = (short)1928265728;
				short num3 = num;
				this.dVRSProfGeneralSuspendScanOnDVRSActive_42782.Applicable = value;
			}
		}

		// Token: 0x17005026 RID: 20518
		// (get) Token: 0x06009F90 RID: 40848 RVA: 0x0094D0EC File Offset: 0x0094B2EC
		// (set) Token: 0x06009F91 RID: 40849 RVA: 0x0094D1A4 File Offset: 0x0094B3A4
		public bool DVRSProfGeneralSuspendScanOnDVRSActive_42782_Valid
		{
			get
			{
				short num = (short)686114645;
				short num2 = num;
				num = (short)2030651221;
				switch (num2 == num)
				{
				}
				num = (short)60358657;
				if (num != 0)
				{
				}
				num = (short)165216256;
				if (num != 0)
				{
				}
				num = (short)1773600768;
				short num3 = num;
				return this.dVRSProfGeneralSuspendScanOnDVRSActive_42782.Valid;
			}
			set
			{
				short num = (short)201547948;
				short num2 = num;
				num = (short)1593729196;
				switch (num2 == num)
				{
				}
				num = (short)1880817665;
				if (num != 0)
				{
				}
				num = (short)352321536;
				if (num != 0)
				{
				}
				num = (short)506265600;
				short num3 = num;
				this.dVRSProfGeneralSuspendScanOnDVRSActive_42782.Valid = value;
			}
		}

		// Token: 0x17005027 RID: 20519
		// (get) Token: 0x06009F92 RID: 40850 RVA: 0x0094D258 File Offset: 0x0094B458
		// (set) Token: 0x06009F93 RID: 40851 RVA: 0x0094D30C File Offset: 0x0094B50C
		public bool DVRSProfGeneralSuspendScanOnDVRSActive_42782_Visible
		{
			get
			{
				short num = (short)764780788;
				short num2 = num;
				num = (short)1322033396;
				switch (num2 == num)
				{
				}
				num = (short)763887617;
				if (num != 0)
				{
				}
				num = (short)708575232;
				if (num != 0)
				{
				}
				num = (short)709427200;
				short num3 = num;
				return this.dVRSProfGeneralSuspendScanOnDVRSActive_42782.Visible;
			}
			set
			{
				short num = (short)1778412649;
				short num2 = num;
				num = (short)1026976873;
				switch (num2 == num)
				{
				}
				num = (short)916586497;
				if (num != 0)
				{
				}
				num = (short)1914634240;
				if (num != 0)
				{
				}
				num = (short)952696832;
				short num3 = num;
				this.dVRSProfGeneralSuspendScanOnDVRSActive_42782.Visible = value;
			}
		}

		// Token: 0x17005028 RID: 20520
		// (get) Token: 0x06009F94 RID: 40852 RVA: 0x0094D3C0 File Offset: 0x0094B5C0
		// (set) Token: 0x06009F95 RID: 40853 RVA: 0x0094D474 File Offset: 0x0094B674
		public bool DVRSProfGeneralSuspendScanOnDVRSActive_42782_Editable
		{
			get
			{
				short num = (short)384542599;
				short num2 = num;
				num = (short)1972938631;
				switch (num2 == num)
				{
				}
				num = (short)247857152;
				if (num != 0)
				{
				}
				num = (short)837681153;
				if (num != 0)
				{
				}
				num = (short)1877147648;
				short num3 = num;
				return this.dVRSProfGeneralSuspendScanOnDVRSActive_42782.Editable;
			}
			set
			{
				short num = (short)35218372;
				short num2 = num;
				num = (short)1311073220;
				switch (num2 == num)
				{
				}
				num = (short)1705836544;
				if (num != 0)
				{
				}
				num = (short)1451491329;
				if (num != 0)
				{
				}
				num = (short)19988480;
				short num3 = num;
				this.dVRSProfGeneralSuspendScanOnDVRSActive_42782.Editable = value;
			}
		}

		// Token: 0x17005029 RID: 20521
		// (get) Token: 0x06009F96 RID: 40854 RVA: 0x0094D528 File Offset: 0x0094B728
		internal string DVRSProfGeneralSuspendScanOnDVRSActive_42782_UILabel
		{
			get
			{
				short num = (short)1819432289;
				short num2 = num;
				num = (short)920671585;
				switch (num2 == num)
				{
				}
				num = (short)1252720640;
				if (num != 0)
				{
				}
				num = (short)1492910081;
				if (num != 0)
				{
				}
				num = (short)1737228288;
				short num3 = num;
				return this.dVRSProfGeneralSuspendScanOnDVRSActive_42782.UIName;
			}
		}

		// Token: 0x1700502A RID: 20522
		// (get) Token: 0x06009F97 RID: 40855 RVA: 0x0094D5DC File Offset: 0x0094B7DC
		// (set) Token: 0x06009F98 RID: 40856 RVA: 0x0094D690 File Offset: 0x0094B890
		internal bool DVRSProfGeneralSuspendScanOnDVRSActive_42782_HiddenStatic
		{
			get
			{
				short num = (short)625880431;
				short num2 = num;
				num = (short)415313263;
				switch (num2 == num)
				{
				}
				num = (short)298385409;
				if (num != 0)
				{
				}
				num = (short)813039616;
				if (num != 0)
				{
				}
				num = (short)1424293888;
				short num3 = num;
				return this.dVRSProfGeneralSuspendScanOnDVRSActive_42782.HiddenStatic;
			}
			set
			{
				short num = (short)798146449;
				short num2 = num;
				num = (short)1157283729;
				switch (num2 == num)
				{
				}
				num = (short)84803585;
				if (num != 0)
				{
				}
				num = (short)1517944832;
				if (num != 0)
				{
				}
				num = (short)2023227392;
				short num3 = num;
				this.dVRSProfGeneralSuspendScanOnDVRSActive_42782.HiddenStatic = value;
			}
		}

		// Token: 0x1700502B RID: 20523
		// (get) Token: 0x06009F99 RID: 40857 RVA: 0x0094D744 File Offset: 0x0094B944
		// (set) Token: 0x06009F9A RID: 40858 RVA: 0x0094D7FC File Offset: 0x0094B9FC
		internal bool DVRSProfGeneralSuspendScanOnDVRSActive_42782_HiddenDynamic
		{
			get
			{
				short num = (short)1461220537;
				short num2 = num;
				num = (short)1687450809;
				switch (num2 == num)
				{
				}
				num = (short)269549569;
				if (num != 0)
				{
				}
				num = (short)920453120;
				if (num != 0)
				{
				}
				num = (short)1005715456;
				short num3 = num;
				return this.dVRSProfGeneralSuspendScanOnDVRSActive_42782.HiddenDynamic;
			}
			set
			{
				short num = (short)948578589;
				short num2 = num;
				num = (short)2077894941;
				switch (num2 == num)
				{
				}
				num = (short)386072577;
				if (num != 0)
				{
				}
				num = (short)1211498496;
				if (num != 0)
				{
				}
				num = (short)1561657344;
				short num3 = num;
				this.dVRSProfGeneralSuspendScanOnDVRSActive_42782.HiddenDynamic = value;
			}
		}

		// Token: 0x1700502C RID: 20524
		// (get) Token: 0x06009F9B RID: 40859 RVA: 0x0094D8B4 File Offset: 0x0094BAB4
		public bool DVRSProfGeneralSuspendScanOnDVRSActive_42782_HasDiffs
		{
			get
			{
				short num = (short)427363693;
				short num2 = num;
				num = (short)932056429;
				switch (num2 == num)
				{
				}
				num = (short)1147731969;
				if (num != 0)
				{
				}
				num = (short)1934950400;
				if (num != 0)
				{
				}
				num = (short)497418240;
				short num3 = num;
				return this.dVRSProfGeneralSuspendScanOnDVRSActive_42782._HasDiffs;
			}
		}

		// Token: 0x1700502D RID: 20525
		// (get) Token: 0x06009F9C RID: 40860 RVA: 0x0094D968 File Offset: 0x0094BB68
		public global::Motorola.MackinawCPS.CoreFeatures.DVRSWide.DVRSWide RefDVRSWide
		{
			get
			{
				short num = (short)484871510;
				short num2 = num;
				num = (short)1826917718;
				switch (num2 == num)
				{
				}
				num = (short)315949057;
				if (num != 0)
				{
				}
				num = (short)889323520;
				if (num != 0)
				{
				}
				num = (short)19267584;
				short num3 = num;
				return global::AcpCommonLib.FeatureManager.GetFeature(4142)[0] as global::Motorola.MackinawCPS.CoreFeatures.DVRSWide.DVRSWide;
			}
		}

		// Token: 0x06009F9D RID: 40861 RVA: 0x0094DA24 File Offset: 0x0094BC24
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
				{
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)1064411670;
					short num3 = num2;
					num2 = (short)442409494;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)1468071936;
						if (num2 != 0)
						{
						}
						num2 = (short)1266941955;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
				{
					num2 = (short)614662144;
					short num4 = num2;
					num2 = (short)1910833153;
					if (num2 != 0)
					{
					}
					num2 = (short)1687552004;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					if (base.ParentRecset != null)
					{
						num2 = (short)359268353;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 3:
					return result;
				case 4:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)1267597312;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				goto IL_24;
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)2008154114;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04004DBD RID: 19901
		private global::AcpBusinessLayer.AcpListField dVRSProfGeneralDVRSRemoteActivation_A41800;

		// Token: 0x04004DBE RID: 19902
		private global::AcpBusinessLayer.AcpField<bool> dVRSProfGeneralGenStsOnDVRSModChg_A41801;

		// Token: 0x04004DBF RID: 19903
		private global::AcpBusinessLayer.AcpField<bool> dVRSProfGeneralICMAllowed_A41802;

		// Token: 0x04004DC0 RID: 19904
		private global::AcpBusinessLayer.AcpField<bool> dVRSProfGeneralMSUSysPTTInLocalMode_A41803;

		// Token: 0x04004DC1 RID: 19905
		private global::AcpBusinessLayer.AcpField<bool> dVRSProfGeneralOutSysRepLocalMode_A41804;

		// Token: 0x04004DC2 RID: 19906
		private global::AcpBusinessLayer.AcpField<bool> dVRSProfGeneralRouteMSUPTTMicAudToDVR_A41805;

		// Token: 0x04004DC3 RID: 19907
		private global::AcpBusinessLayer.AcpField<bool> dVRSProfGeneralLocalTxFallback_A41806;

		// Token: 0x04004DC4 RID: 19908
		private global::AcpBusinessLayer.AcpSimpleRangeField dVRSProfGeneralProxyTimeOutTimer_A41807;

		// Token: 0x04004DC5 RID: 19909
		private global::AcpBusinessLayer.AcpSimpleRangeField dVRSProfGeneralProxyLimitPatienceTimer_A41808;

		// Token: 0x04004DC6 RID: 19910
		private global::AcpBusinessLayer.AcpKeyField dVRSProfGeneralDVRSProfName_A41809;

		// Token: 0x04004DC7 RID: 19911
		private global::AcpBusinessLayer.AcpSimpleRangeField dVRSProfGeneralProxyRFSSReponseTimer_A41810;

		// Token: 0x04004DC8 RID: 19912
		private global::AcpBusinessLayer.AcpSimpleRangeField dVRSProfGeneralGenStsOnDVRSModChgHoldoff_A41869;

		// Token: 0x04004DC9 RID: 19913
		private global::AcpBusinessLayer.AcpField<bool> dVRSProfGeneralGenStsLegacyMode;

		// Token: 0x04004DCA RID: 19914
		private global::AcpBusinessLayer.AcpField<bool> dVRSProfGeneralSuspendScanOnDVRSActive_42782;
	}
}
