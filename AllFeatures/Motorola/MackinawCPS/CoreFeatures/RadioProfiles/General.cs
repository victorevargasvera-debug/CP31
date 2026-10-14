using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu;

namespace Motorola.MackinawCPS.CoreFeatures.RadioProfiles
{
	// Token: 0x02000213 RID: 531
	[global::System.Serializable]
	public class General : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06005E13 RID: 24083 RVA: 0x00548C0C File Offset: 0x00546E0C
		public General(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06005E14 RID: 24084 RVA: 0x00548C28 File Offset: 0x00546E28
		protected General(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06005E15 RID: 24085 RVA: 0x00548C40 File Offset: 0x00546E40
		public override void Init()
		{
			int a_ = 7;
			short num = (short)384413327;
			short num2 = num;
			num = (short)716287631;
			switch (num2 == num)
			{
			}
			num = (short)1994129409;
			if (num != 0)
			{
			}
			num = (short)1395326976;
			short num3 = num;
			num = (short)996605952;
			if (num != 0)
			{
			}
			this.radProfGeneralDisableLights_A7866 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("髇ꯉ꣋黍ꋏ뷑닓釕뷗듙맛곝臟軡ꃣ迥鯧诩軫苭闯뻱鷳釵郷軹迻ꇽ䇿㔁㰃々㸇", a_), global::CommonResources.AcgResources.ID_SURVEILLANCEMODEDISABLELIGHTS);
			this.radProfGeneralDisableLights_A7866.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radProfGeneralDisableLights_A7866.DataTransferOrder = 51;
			this.radProfGeneralDisableTones_A7870 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("髇ꯉ꣋黍ꋏ뷑닓釕뷗듙맛곝臟軡ꃣ迥鯧诩軫苭闯꛱鯳飵鷷觹ꏻ뿽㟿㨁㌃㘅", a_), global::CommonResources.AcgResources.ID_SURVEILLANCEMODEDISABLETONES);
			this.radProfGeneralDisableTones_A7870.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radProfGeneralDisableTones_A7870.DataTransferOrder = 13;
			this.radProfGeneralRadioProfileName_A19564 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("髇ꯉ꣋黍ꋏ뷑닓釕뷗듙맛곝臟軡뛣蟥賧菩菫뻭苯鷱鋳鿵铷鿹닻鿽淿朁嬃䜅㤇㌉㤋㠍␏", a_), global::CommonResources.AcgResources.ID_RADIOPROFILENAME, 14);
			this.radProfGeneralRadioProfileName_A19564.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radProfGeneralRadioProfileName_A19564.DataTransferOrder = 30;
			this.radProfGeneralSpeakerAudioRouting_A19566 = new global::AcpBusinessLayer.AcpListField(2, this, global::AllFeatures.CodeplugGuid.b("髇ꯉ꣋黍ꋏ뷑닓釕뷗듙맛곝臟軡럣雥跧诩蟫语苯돱至鋵釷闹껻釽痿瘁洃栅漇唉䴋㼍⤏✑∓―", a_), global::CommonResources.AcgResources.ID_SURVEILLANCEMODESPEAKERAUDIOROUTING, global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.LOVs.RadProfGeneralSpeakerAudioRouting_A19566LovStrs);
			this.radProfGeneralSpeakerAudioRouting_A19566.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radProfGeneralSpeakerAudioRouting_A19566.DataTransferOrder = 15;
			this.radProfGeneralDisableEmergencyAlertsNotification_A19570 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("髇ꯉ꣋黍ꋏ뷑닓釕뷗듙맛곝臟軡ꃣ迥鯧诩軫苭闯럱駳鏵諷鷹駻都揿笁䔃樅洇砉砋納帏紑怓缕縗猙缛缝吟䬡䬣䠥眧欩ᴫᜭԯԱг", a_), global::CommonResources.AcgResources.ID_INTELLIGENTLIGHTINGDISABLEEMERGENCYNOTIFICATION);
			this.radProfGeneralDisableEmergencyAlertsNotification_A19570.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radProfGeneralDisableEmergencyAlertsNotification_A19570.DataTransferOrder = 52;
			this.radProfGeneralDisableCriticalAlertsNotification_A19571 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("髇ꯉ꣋黍ꋏ뷑닓釕뷗듙맛곝臟軡ꃣ迥鯧诩軫苭闯뇱蛳鿵賷鏹鿻鿽泿䌁栃挅稇縉缋䀍缏昑紓瀕焗礙紛樝䤟䴡䨣礥椧ᬩᔫᬭܯ̱", a_), global::CommonResources.AcgResources.ID_INTELLIGENTLIGHTINGDISABLECRITICALNOTIFICATION);
			this.radProfGeneralDisableCriticalAlertsNotification_A19571.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radProfGeneralDisableCriticalAlertsNotification_A19571.DataTransferOrder = 53;
			this.radProfGeneralDisableCallAlertsNotification_A19572 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("髇ꯉ꣋黍ꋏ뷑닓釕뷗듙맛곝臟軡ꃣ迥鯧诩軫苭闯뇱闳髵铷믹郻鯽狿瘁眃䠅朇縉攋栍礏焑甓戕焗甙爛䄝感ጡᴣጥἧᠩ", a_), global::CommonResources.AcgResources.ID_INTELLIGENTLIGHTINGDISABLECALLNOTIFICATION);
			this.radProfGeneralDisableCallAlertsNotification_A19572.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radProfGeneralDisableCallAlertsNotification_A19572.DataTransferOrder = 54;
			this.permanentFrontDisplayBacklight_A22337 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("飇꿉뻋ꏍ뇏병뇓룕곗鳙껛뇝軟雡ꃣ迥鯧髩胫迭觯냱闳闵鏷雹闻駽棿瘁嬃䜅㨇㠉㼋㴍✏", a_), global::CommonResources.AcgResources.ID_PERMANENTFRONTDISPLAYBACKLIGHT);
			this.permanentFrontDisplayBacklight_A22337.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.permanentFrontDisplayBacklight_A22337.DataTransferOrder = 50;
			this.radProfPermanentTopDisplayBacklight = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("髇ꯉ꣋黍ꋏ뷑닓蛕뷗꣙뇛뿝軟蟡諣鋥볧藩鳫ꫭ駯臱蓳髵駷菹뻻鿽揿椁栃漅漇戉砋", a_), global::CommonResources.AcgResources.ID_PERMANENTTOPDISPLAYBACKLIGHT);
			this.radProfPermanentTopDisplayBacklight.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.radProfPermanentTopDisplayBacklight.DataTransferOrder = 55;
			this.radProfPermanentDisableTxRxLED_A41609 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("髇ꯉ꣋黍ꋏ뷑닓蛕뷗꣙뇛뿝軟蟡諣鋥곧菩鿫迭鋯黱釳ꋵ胷꣹蓻닽䗿䘁嬃䜅㰇㬉㨋㸍⤏", a_), global::CommonResources.AcgResources.ID_PERMANENTDISABLETXRXLED);
			this.radProfPermanentDisableTxRxLED_A41609.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radProfPermanentDisableTxRxLED_A41609.DataTransferOrder = 42;
			this.radProfileSelectNoiseSensingVolumeControl = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("髇ꯉ꣋黍ꋏ뷑닓뿕듗뿙进믝賟蟡蟣鋥ꛧ藩藫鷭闯ꇱ釳飵请鏹鋻駽囿洁栃猅攇漉伋愍縏昑易礕琗", a_), global::CommonResources.AcgResources.ID_RADPROFILENOISESENSINGVOLUMECONTROL);
			this.radProfileSelectNoiseSensingVolumeControl.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.radProfileSelectNoiseSensingVolumeControl.DataTransferOrder = 56;
			this.radProfNVGEnable_A41615 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("髇ꯉ꣋黍ꋏ뷑닓飕軗鷙駛냝臟胡裣菥럧ꯩ\ud8eb\udfed웯쏱쇳", a_), global::CommonResources.AcgResources.ID_NIGHTVISIONGOGGLESENABLE);
			this.radProfNVGEnable_A41615.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radProfNVGEnable_A41615.DataTransferOrder = 35;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("过꿉ꋋꯍꋏ돑룓", a_);
			base.Id = 10189;
			base.UIName = global::CommonResources.AcgResources.ID_GENERAL;
			base.DataTransferOrder = 3;
		}

		// Token: 0x06005E16 RID: 24086 RVA: 0x00548FD8 File Offset: 0x005471D8
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 17;
			short num = (short)443875337;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_3E4;
				case 1:
					goto IL_4CB;
				case 2:
					this.radProfNVGEnable_A41615 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("胑뗓닕裗꣙돛룝껟듡ꏣꏥ蛧诩軫苭闯귱뗳싵짷쳹췻쯽", a_), global::CommonResources.AcgResources.ID_NIGHTVISIONGOGGLESENABLE);
					this.radProfNVGEnable_A41615.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radProfNVGEnable_A41615.DataTransferOrder = 35;
					num = (short)868679681;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					this.radProfGeneralDisableEmergencyAlertsNotification_A19570 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("胑뗓닕裗꣙돛룝꟟蟡諣菥髧诩胫ꫭ駯臱闳铵铷鿹맻鏽旿瀁挃挅昇椉甋伍簏眑易戕欗吙猛樝䤟䐡䴣䔥䤧帩䔫䄭帯洱申ܵķ༹଻฽", a_), global::CommonResources.AcgResources.ID_INTELLIGENTLIGHTINGDISABLEEMERGENCYNOTIFICATION);
					this.radProfGeneralDisableEmergencyAlertsNotification_A19570.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radProfGeneralDisableEmergencyAlertsNotification_A19570.DataTransferOrder = 52;
					num = (short)1445986308;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_797;
				case 5:
					goto IL_4D0;
				case 6:
					goto IL_533;
				case 7:
					goto IL_556;
				case 8:
					num = (short)1804533766;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					switch (0)
					{
					case 0:
						goto IL_CE;
					}
					continue;
				case 10:
					this.radProfGeneralDisableTones_A7870 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("胑뗓닕裗꣙돛룝꟟蟡諣菥髧诩胫ꫭ駯臱闳铵铷鿹ꣻ釽滿朁眃夅䤇㴉㐋㤍‏", a_), global::CommonResources.AcgResources.ID_SURVEILLANCEMODEDISABLETONES);
					this.radProfGeneralDisableTones_A7870.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radProfGeneralDisableTones_A7870.DataTransferOrder = 13;
					num = (short)1584529415;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("胑뗓닕裗꣙돛룝냟蟡難该觧蓩觫胭蓯뛱鷳藵駷飹郻鯽哿稁嘃縅䐇伉䠋儍儏☑┓―⠗⌙", a_)))
					{
						num = (short)2041315367;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3E4;
				case 12:
					this.radProfGeneralDisableCriticalAlertsNotification_A19571 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("胑뗓닕裗꣙돛룝꟟蟡諣菥髧诩胫ꫭ駯臱闳铵铷鿹뿻賽槿瘁洃攅椇昉䴋戍甏怑怓攕嘗甙栛眝䘟䬡䜣䜥尧䌩䌫䀭漯猱Գ༵ഷഹ഻", a_), global::CommonResources.AcgResources.ID_INTELLIGENTLIGHTINGDISABLECRITICALNOTIFICATION);
					this.radProfGeneralDisableCriticalAlertsNotification_A19571.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radProfGeneralDisableCriticalAlertsNotification_A19571.DataTransferOrder = 53;
					num = (short)1616838685;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("胑뗓닕裗꣙돛룝꟟蟡諣菥髧诩胫뷭胯韱闳鷵鷷裹뷻诽擿欁欃吅朇缉砋服縏甑䬓圕⤗⌙⤛⠝ᘟ", a_)))
					{
						num = (short)1375862804;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4D0;
				case 14:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("胑뗓닕裗꣙돛룝꟟蟡諣菥髧诩胫ꫭ駯臱闳铵铷鿹냻韽柿樁瀃甅圇䬉㬋㘍☏␑", a_)))
					{
						num = (short)1566375966;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5A3;
				case 15:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("胑뗓닕裗꣙돛룝꟟蟡諣菥髧诩胫볭釯雱鷳駵ꣷ裹鏻飽槿渁愃䠅椇有椋儍儏⌑ⴓ⌕⸗⸙", a_)))
					{
						num = (short)1746731031;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_830;
				case 16:
				{
					num = (short)883032064;
					short num3 = num;
					this.radProfileSelectNoiseSensingVolumeControl = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("胑뗓닕裗꣙돛룝觟軡臣뗥跧蛩觫跭蓯볱鯳鿵请鿹꿻鯽滿焁洃栅漇尉挋戍攏缑焓唕眗琙栛氝伟両", a_), global::CommonResources.AcgResources.ID_RADPROFILENOISESENSINGVOLUMECONTROL);
					this.radProfileSelectNoiseSensingVolumeControl.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radProfileSelectNoiseSensingVolumeControl.DataTransferOrder = 56;
					num = (short)1356005402;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 17:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("胑뗓닕裗꣙돛룝냟蟡難该觧蓩觫胭蓯꛱鯳蛵볷鏹迻軽泿持紃䐅椇椉朋戍礏甑簓戕", a_)))
					{
						num = (short)1419706406;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_8CA;
				case 18:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("苑뇓ꓕ뗗믙닛믝軟雡ꋣ铥蟧蓩飫ꫭ駯臱蓳髵駷菹뻻鿽揿椁栃漅漇戉砋儍儏‑☓┕⬗ⴙ", a_)))
					{
						num = (short)720240676;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_F6;
				case 19:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("胑뗓닕裗꣙돛룝껟듡ꏣꏥ蛧诩軫苭闯귱뗳싵짷쳹췻쯽", a_)))
					{
						num = (short)1172439042;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_96E;
				case 20:
					this.radProfGeneralSpeakerAudioRouting_A19566 = new global::AcpBusinessLayer.AcpListField(2, this, global::AllFeatures.CodeplugGuid.b("胑뗓닕裗꣙돛룝꟟蟡諣菥髧诩胫뷭胯韱闳鷵鷷裹뷻诽擿欁欃吅朇缉砋服縏甑䬓圕⤗⌙⤛⠝ᘟ", a_), global::CommonResources.AcgResources.ID_SURVEILLANCEMODESPEAKERAUDIOROUTING, global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.LOVs.RadProfGeneralSpeakerAudioRouting_A19566LovStrs);
					this.radProfGeneralSpeakerAudioRouting_A19566.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radProfGeneralSpeakerAudioRouting_A19566.DataTransferOrder = 15;
					num = (short)1650262021;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 21:
					num = (short)2024407054;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 22:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("胑뗓닕裗꣙돛룝꟟蟡諣菥髧诩胫ꫭ駯臱闳铵铷鿹뿻鿽泿渁䔃樅洇砉砋納帏紑怓缕縗猙缛缝吟䬡䬣䠥眧欩ᴫᜭԯԱس", a_)))
					{
						num = (short)1239482393;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_7E4;
				case 23:
					this.radProfGeneralRadioProfileName_A19564 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("胑뗓닕裗꣙돛룝꟟蟡諣菥髧诩胫볭釯雱鷳駵ꣷ裹鏻飽槿渁愃䠅椇有椋儍儏⌑ⴓ⌕⸗⸙", a_), global::CommonResources.AcgResources.ID_RADIOPROFILENAME, 14);
					this.radProfGeneralRadioProfileName_A19564.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radProfGeneralRadioProfileName_A19564.DataTransferOrder = 30;
					num = (short)601882651;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 24:
					num = (short)90308609;
					if (num != 0)
					{
					}
					goto IL_8CA;
				case 25:
					this.radProfGeneralDisableCallAlertsNotification_A19572 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("胑뗓닕裗꣙돛룝꟟蟡諣菥髧诩胫ꫭ駯臱闳铵铷鿹뿻鿽泿渁䔃樅洇砉砋納帏紑怓缕縗猙缛缝吟䬡䬣䠥眧欩ᴫᜭԯԱس", a_), global::CommonResources.AcgResources.ID_INTELLIGENTLIGHTINGDISABLECALLNOTIFICATION);
					this.radProfGeneralDisableCallAlertsNotification_A19572.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radProfGeneralDisableCallAlertsNotification_A19572.DataTransferOrder = 54;
					num = (short)1383661603;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 26:
					goto IL_2E7;
				case 27:
					goto IL_830;
				case 28:
				{
					num = (short)1974781767;
					short num4 = num;
					num = (short)941213511;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_533;
					default:
						num = (short)182910976;
						if (num != 0)
						{
						}
						if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("胑뗓닕裗꣙돛룝觟軡臣뗥跧蛩觫跭蓯볱鯳鿵请鿹꿻鯽滿焁洃栅漇尉挋戍攏缑焓唕眗琙栛氝伟両", a_)))
						{
							num = (short)1379598352;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2E7;
					}
					break;
				}
				case 29:
					goto IL_143;
				case 30:
					this.radProfGeneralDisableLights_A7866 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("胑뗓닕裗꣙돛룝꟟蟡諣菥髧诩胫ꫭ駯臱闳铵铷鿹냻韽柿樁瀃甅圇䬉㬋㘍☏␑", a_), global::CommonResources.AcgResources.ID_SURVEILLANCEMODEDISABLELIGHTS);
					this.radProfGeneralDisableLights_A7866.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radProfGeneralDisableLights_A7866.DataTransferOrder = 51;
					num = (short)1496711200;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 31:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("胑뗓닕裗꣙돛룝꟟蟡諣菥髧诩胫ꫭ駯臱闳铵铷鿹ꣻ釽滿朁眃夅䤇㴉㐋㤍‏", a_)))
					{
						num = (short)1305411594;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_556;
				case 32:
					goto IL_5A3;
				case 33:
					goto IL_F6;
				case 34:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("胑뗓닕裗꣙돛룝꟟蟡諣菥髧诩胫ꫭ駯臱闳铵铷鿹뿻賽槿瘁洃攅椇昉䴋戍甏怑怓攕嘗甙栛眝䘟䬡䜣䜥尧䌩䌫䀭漯猱Գ༵ഷഹ഻", a_)))
					{
						num = (short)2133327884;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_143;
				case 35:
					goto IL_7E4;
				case 36:
					this.permanentFrontDisplayBacklight_A22337 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("苑뇓ꓕ뗗믙닛믝軟雡ꋣ铥蟧蓩飫ꫭ駯臱蓳髵駷菹뻻鿽揿椁栃漅漇戉砋儍儏‑☓┕⬗ⴙ", a_), global::CommonResources.AcgResources.ID_PERMANENTFRONTDISPLAYBACKLIGHT);
					this.permanentFrontDisplayBacklight_A22337.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.permanentFrontDisplayBacklight_A22337.DataTransferOrder = 50;
					num = (short)846069793;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 37:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("胑뗓닕裗꣙돛룝꟟蟡諣菥髧诩胫ꫭ駯臱闳铵铷鿹맻鏽旿瀁挃挅昇椉甋伍簏眑易戕欗吙猛樝䤟䐡䴣䔥䤧帩䔫䄭帯洱申ܵķ༹଻฽", a_)))
					{
						num = (short)59572227;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_797;
				case 38:
					this.radProfPermanentTopDisplayBacklight = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("胑뗓닕裗꣙돛룝냟蟡難该觧蓩觫胭蓯꛱鯳蛵볷鏹迻軽泿持紃䐅椇椉朋戍礏甑簓戕", a_), global::CommonResources.AcgResources.ID_PERMANENTTOPDISPLAYBACKLIGHT);
					this.radProfPermanentTopDisplayBacklight.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.radProfPermanentTopDisplayBacklight.DataTransferOrder = 55;
					num = (short)228524056;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 39:
					this.radProfPermanentDisableTxRxLED_A41609 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("胑뗓닕裗꣙돛룝냟蟡難该觧蓩觫胭蓯뛱鷳藵駷飹郻鯽哿稁嘃縅䐇伉䠋儍儏☑┓―⠗⌙", a_), global::CommonResources.AcgResources.ID_PERMANENTDISABLETXRXLED);
					this.radProfPermanentDisableTxRxLED_A41609.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radProfPermanentDisableTxRxLED_A41609.DataTransferOrder = 42;
					num = (short)2079457280;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_CE:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)552861704;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_F6:
				num = (short)695140369;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_143:
				num = (short)1263403030;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2E7:
				num = (short)657260563;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3E4:
				num = (short)670498844;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_4D0:
				num = (short)1277689893;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_533:
				if (producerFields != null)
				{
					num = (short)890896405;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_556:
				num = (short)1176174607;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_5A3:
				num = (short)1518272543;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_797:
				num = (short)765001762;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_7E4:
				num = (short)1904541714;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_830:
				num = (short)1460994061;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_8CA:
				num = (short)1836777483;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_4CB:
			IL_96E:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("闑뇓룕뷗꣙뷛닝", a_);
			base.Id = 10189;
			base.UIName = global::CommonResources.AcgResources.ID_GENERAL;
			base.DataTransferOrder = 3;
		}

		// Token: 0x06005E17 RID: 24087 RVA: 0x00549984 File Offset: 0x00547B84
		public override void PopulateReferences()
		{
			short num = (short)670272536;
			short num2 = num;
			num = (short)1452837912;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2091450368;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)984219648;
			if (num != 0)
			{
			}
			num = (short)1801256961;
			if (num != 0)
			{
			}
		}

		// Token: 0x06005E18 RID: 24088 RVA: 0x00549A2C File Offset: 0x00547C2C
		public override void DropReferences()
		{
			short num = (short)1399007199;
			short num2 = num;
			num = (short)1398745055;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1707999232;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)331808768;
			if (num != 0)
			{
			}
			num = (short)1959067649;
			if (num != 0)
			{
			}
		}

		// Token: 0x06005E19 RID: 24089 RVA: 0x00549AD4 File Offset: 0x00547CD4
		public override void SetConstraints()
		{
			short num = (short)1830813697;
			if (num != 0)
			{
			}
			num = (short)963969024;
			short num2 = num;
			num = (short)2005878854;
			short num3 = num;
			num = (short)399394886;
			switch (num3 == num)
			{
			}
			num = (short)441843712;
			if (num != 0)
			{
			}
			this.radProfGeneralDisableLights_A7866.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfilesConstraints.ConNVGEnabledAndDisableLightEn);
			this.radProfGeneralDisableEmergencyAlertsNotification_A19570.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfilesConstraints.ConNVGEnabledAndDisableEmerNotifyEn);
			this.radProfGeneralDisableCriticalAlertsNotification_A19571.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfilesConstraints.ConNVGEnabledAndDisableCriticalNotifyEn);
			this.radProfGeneralDisableCallAlertsNotification_A19572.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfilesConstraints.ConNVGEnabledAndDisableCallNotifyEn);
			this.permanentFrontDisplayBacklight_A22337.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfilesConstraints.ConNVGEnabledAndPermanentFrDisplayBackLightEnabled);
			this.radProfPermanentDisableTxRxLED_A41609.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfilesConstraints.conPermanentDisableTxRxLEDIsApplicable);
			this.radProfPermanentDisableTxRxLED_A41609.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfilesConstraints.ConNVGEnabledAndPermanentDisableTxRxLEDEn);
		}

		// Token: 0x06005E1A RID: 24090 RVA: 0x00549C24 File Offset: 0x00547E24
		public override void SetupDependencies()
		{
			short num = (short)1694733573;
			short num2 = num;
			num = (short)2002818309;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1216544768;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1578696704;
			if (num != 0)
			{
			}
			num = (short)1659895809;
			if (num != 0)
			{
			}
			this.radProfNVGEnable_A41615.AddDependentObject(this.radProfGeneralDisableLights_A7866);
			this.radProfNVGEnable_A41615.AddDependentObject(this.radProfGeneralDisableEmergencyAlertsNotification_A19570);
			this.RefDisplayAndMenu.Advanced.DisplMenuAdvancedTopLightColorPerChannel_A43171.AddDependentObject(this.radProfGeneralDisableEmergencyAlertsNotification_A19570);
			this.radProfNVGEnable_A41615.AddDependentObject(this.radProfGeneralDisableCriticalAlertsNotification_A19571);
			this.RefDisplayAndMenu.Advanced.DisplMenuAdvancedTopLightColorPerChannel_A43171.AddDependentObject(this.radProfGeneralDisableCriticalAlertsNotification_A19571);
			this.radProfNVGEnable_A41615.AddDependentObject(this.radProfGeneralDisableCallAlertsNotification_A19572);
			this.RefDisplayAndMenu.Advanced.DisplMenuAdvancedTopLightColorPerChannel_A43171.AddDependentObject(this.radProfGeneralDisableCallAlertsNotification_A19572);
			this.radProfNVGEnable_A41615.AddDependentObject(this.permanentFrontDisplayBacklight_A22337);
			this.radProfNVGEnable_A41615.AddDependentObject(this.radProfPermanentDisableTxRxLED_A41609);
			this.radProfGeneralDisableLights_A7866.AddDependentObject(this.radProfPermanentDisableTxRxLED_A41609);
		}

		// Token: 0x170030BD RID: 12477
		// (get) Token: 0x06005E1B RID: 24091 RVA: 0x00549D9C File Offset: 0x00547F9C
		public bool HasDiffs
		{
			get
			{
				short num = (short)620909151;
				short num2 = num;
				num = (short)1453216351;
				switch (num2 == num)
				{
				default:
				{
					num = (short)970653696;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2146107393;
				if (num != 0)
				{
				}
				num = (short)824115200;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x170030BE RID: 12478
		// (get) Token: 0x06005E1C RID: 24092 RVA: 0x00549E4C File Offset: 0x0054804C
		// (set) Token: 0x06005E1D RID: 24093 RVA: 0x00549F00 File Offset: 0x00548100
		public bool RadProfGeneralDisableLights_A7866Value
		{
			get
			{
				short num = (short)952243088;
				short num2 = num;
				num = (short)1975260048;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1863254016;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)226820096;
				if (num != 0)
				{
				}
				num = (short)747241473;
				if (num != 0)
				{
				}
				return this.radProfGeneralDisableLights_A7866.Value;
			}
			set
			{
				short num = (short)121157055;
				short num2 = num;
				num = (short)1319613887;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2003828736;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)237502465;
				if (num != 0)
				{
				}
				num = (short)2041380864;
				if (num != 0)
				{
				}
				this.radProfGeneralDisableLights_A7866.Value = value;
			}
		}

		// Token: 0x170030BF RID: 12479
		// (get) Token: 0x06005E1E RID: 24094 RVA: 0x00549FB8 File Offset: 0x005481B8
		public global::AcpBusinessLayer.AcpField<bool> RadProfGeneralDisableLights_A7866
		{
			get
			{
				short num = (short)869704832;
				short num2 = num;
				num = (short)1216455808;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1266548736;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)750583808;
				if (num != 0)
				{
				}
				num = (short)349831169;
				if (num != 0)
				{
				}
				return this.radProfGeneralDisableLights_A7866;
			}
		}

		// Token: 0x170030C0 RID: 12480
		// (get) Token: 0x06005E1F RID: 24095 RVA: 0x0054A06C File Offset: 0x0054826C
		// (set) Token: 0x06005E20 RID: 24096 RVA: 0x0054A120 File Offset: 0x00548320
		public bool RadProfGeneralDisableLights_A7866_UIValue
		{
			get
			{
				short num = (short)369637847;
				short num2 = num;
				num = (short)2020293079;
				switch (num2 == num)
				{
				default:
				{
					num = (short)262471680;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1449721857;
				if (num != 0)
				{
				}
				num = (short)151257088;
				if (num != 0)
				{
				}
				return this.radProfGeneralDisableLights_A7866.Value;
			}
			set
			{
				short num = (short)888220881;
				short num2 = num;
				num = (short)1939877073;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2081882112;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)112328705;
				if (num != 0)
				{
				}
				num = (short)155189248;
				if (num != 0)
				{
				}
				this.radProfGeneralDisableLights_A7866.Value = value;
			}
		}

		// Token: 0x170030C1 RID: 12481
		// (get) Token: 0x06005E21 RID: 24097 RVA: 0x0054A1D4 File Offset: 0x005483D4
		// (set) Token: 0x06005E22 RID: 24098 RVA: 0x0054A288 File Offset: 0x00548488
		public bool RadProfGeneralDisableLights_A7866_Applicable
		{
			get
			{
				short num = (short)619482648;
				short num2 = num;
				num = (short)1578274328;
				switch (num2 == num)
				{
				default:
				{
					num = (short)717029376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)111804417;
				if (num != 0)
				{
				}
				num = (short)10223616;
				if (num != 0)
				{
				}
				return this.radProfGeneralDisableLights_A7866.Applicable;
			}
			set
			{
				short num = (short)1291592422;
				short num2 = num;
				num = (short)401023718;
				switch (num2 == num)
				{
				}
				num = (short)963510272;
				if (num != 0)
				{
				}
				num = (short)881262592;
				short num3 = num;
				num = (short)635371521;
				if (num != 0)
				{
				}
				this.radProfGeneralDisableLights_A7866.Applicable = value;
			}
		}

		// Token: 0x170030C2 RID: 12482
		// (get) Token: 0x06005E23 RID: 24099 RVA: 0x0054A340 File Offset: 0x00548540
		// (set) Token: 0x06005E24 RID: 24100 RVA: 0x0054A3F8 File Offset: 0x005485F8
		public bool RadProfGeneralDisableLights_A7866_Valid
		{
			get
			{
				short num = (short)538006541;
				short num2 = num;
				num = (short)348148749;
				switch (num2 == num)
				{
				}
				num = (short)1094123520;
				if (num != 0)
				{
				}
				num = (short)1198456832;
				short num3 = num;
				num = (short)1998651393;
				if (num != 0)
				{
				}
				return this.radProfGeneralDisableLights_A7866.Valid;
			}
			set
			{
				short num = (short)1157871710;
				short num2 = num;
				num = (short)1922087006;
				switch (num2 == num)
				{
				}
				num = (short)1408827393;
				if (num != 0)
				{
				}
				num = (short)2101411840;
				short num3 = num;
				num = (short)1240006656;
				if (num != 0)
				{
				}
				this.radProfGeneralDisableLights_A7866.Valid = value;
			}
		}

		// Token: 0x170030C3 RID: 12483
		// (get) Token: 0x06005E25 RID: 24101 RVA: 0x0054A4AC File Offset: 0x005486AC
		// (set) Token: 0x06005E26 RID: 24102 RVA: 0x0054A560 File Offset: 0x00548760
		public bool RadProfGeneralDisableLights_A7866_Visible
		{
			get
			{
				short num = (short)842008736;
				short num2 = num;
				num = (short)2059798688;
				switch (num2 == num)
				{
				}
				num = (short)1348730881;
				if (num != 0)
				{
				}
				num = (short)1035403264;
				short num3 = num;
				num = (short)570621952;
				if (num != 0)
				{
				}
				return this.radProfGeneralDisableLights_A7866.Visible;
			}
			set
			{
				short num = (short)1298931453;
				short num2 = num;
				num = (short)1314725629;
				switch (num2 == num)
				{
				}
				num = (short)31850497;
				if (num != 0)
				{
				}
				num = (short)1687552000;
				short num3 = num;
				num = (short)616431616;
				if (num != 0)
				{
				}
				this.radProfGeneralDisableLights_A7866.Visible = value;
			}
		}

		// Token: 0x170030C4 RID: 12484
		// (get) Token: 0x06005E27 RID: 24103 RVA: 0x0054A614 File Offset: 0x00548814
		// (set) Token: 0x06005E28 RID: 24104 RVA: 0x0054A6C4 File Offset: 0x005488C4
		public bool RadProfGeneralDisableLights_A7866_Editable
		{
			get
			{
				short num = (short)1097443869;
				short num2 = num;
				num = (short)1042065949;
				switch (num2 == num)
				{
				}
				num = (short)604438529;
				if (num != 0)
				{
				}
				num = (short)2036596736;
				short num3 = num;
				num = (short)1265434624;
				if (num != 0)
				{
				}
				return this.radProfGeneralDisableLights_A7866.Editable;
			}
			set
			{
				short num = (short)1869987331;
				short num2 = num;
				num = (short)74104323;
				switch (num2 == num)
				{
				}
				num = (short)606339073;
				if (num != 0)
				{
				}
				num = (short)2009792512;
				short num3 = num;
				num = (short)939327488;
				if (num != 0)
				{
				}
				this.radProfGeneralDisableLights_A7866.Editable = value;
			}
		}

		// Token: 0x170030C5 RID: 12485
		// (get) Token: 0x06005E29 RID: 24105 RVA: 0x0054A778 File Offset: 0x00548978
		internal string RadProfGeneralDisableLights_A7866_UILabel
		{
			get
			{
				short num = (short)1355697801;
				short num2 = num;
				num = (short)889933449;
				switch (num2 == num)
				{
				}
				num = (short)831913984;
				if (num != 0)
				{
				}
				num = (short)501481472;
				short num3 = num;
				num = (short)269942785;
				if (num != 0)
				{
				}
				return this.radProfGeneralDisableLights_A7866.UIName;
			}
		}

		// Token: 0x170030C6 RID: 12486
		// (get) Token: 0x06005E2A RID: 24106 RVA: 0x0054A82C File Offset: 0x00548A2C
		// (set) Token: 0x06005E2B RID: 24107 RVA: 0x0054A8E4 File Offset: 0x00548AE4
		internal bool RadProfGeneralDisableLights_A7866_HiddenStatic
		{
			get
			{
				short num = (short)1450372171;
				short num2 = num;
				num = (short)904916043;
				switch (num2 == num)
				{
				}
				num = (short)1885536257;
				if (num != 0)
				{
				}
				num = (short)563871744;
				short num3 = num;
				num = (short)1562771456;
				if (num != 0)
				{
				}
				return this.radProfGeneralDisableLights_A7866.HiddenStatic;
			}
			set
			{
				short num = (short)2041152116;
				short num2 = num;
				num = (short)361333364;
				switch (num2 == num)
				{
				}
				num = (short)919339009;
				if (num != 0)
				{
				}
				num = (short)2129657856;
				short num3 = num;
				num = (short)727580672;
				if (num != 0)
				{
				}
				this.radProfGeneralDisableLights_A7866.HiddenStatic = value;
			}
		}

		// Token: 0x170030C7 RID: 12487
		// (get) Token: 0x06005E2C RID: 24108 RVA: 0x0054A998 File Offset: 0x00548B98
		// (set) Token: 0x06005E2D RID: 24109 RVA: 0x0054AA4C File Offset: 0x00548C4C
		internal bool RadProfGeneralDisableLights_A7866_HiddenDynamic
		{
			get
			{
				short num = (short)510855092;
				short num2 = num;
				num = (short)1376061364;
				switch (num2 == num)
				{
				}
				num = (short)770703361;
				if (num != 0)
				{
				}
				num = (short)1425014784;
				short num3 = num;
				num = (short)1933705216;
				if (num != 0)
				{
				}
				return this.radProfGeneralDisableLights_A7866.HiddenDynamic;
			}
			set
			{
				short num = (short)1086421105;
				short num2 = num;
				num = (short)1860204657;
				switch (num2 == num)
				{
				}
				num = (short)799473665;
				if (num != 0)
				{
				}
				num = (short)212795392;
				short num3 = num;
				num = (short)1573519360;
				if (num != 0)
				{
				}
				this.radProfGeneralDisableLights_A7866.HiddenDynamic = value;
			}
		}

		// Token: 0x170030C8 RID: 12488
		// (get) Token: 0x06005E2E RID: 24110 RVA: 0x0054AB00 File Offset: 0x00548D00
		public bool RadProfGeneralDisableLights_A7866_HasDiffs
		{
			get
			{
				short num = (short)2044854273;
				if (num != 0)
				{
				}
				num = (short)581204399;
				short num2 = num;
				num = (short)801208751;
				switch (num2 == num)
				{
				}
				num = (short)342360064;
				short num3 = num;
				num = (short)461307904;
				if (num != 0)
				{
				}
				return this.radProfGeneralDisableLights_A7866._HasDiffs;
			}
		}

		// Token: 0x170030C9 RID: 12489
		// (get) Token: 0x06005E2F RID: 24111 RVA: 0x0054ABB4 File Offset: 0x00548DB4
		// (set) Token: 0x06005E30 RID: 24112 RVA: 0x0054AC6C File Offset: 0x00548E6C
		public bool RadProfGeneralDisableTones_A7870Value
		{
			get
			{
				short num = (short)55900523;
				short num2 = num;
				num = (short)1465252203;
				switch (num2 == num)
				{
				}
				num = (short)1276575745;
				if (num != 0)
				{
				}
				num = (short)1336475648;
				short num3 = num;
				num = (short)96534528;
				if (num != 0)
				{
				}
				return this.radProfGeneralDisableTones_A7870.Value;
			}
			set
			{
				short num = (short)726886519;
				short num2 = num;
				num = (short)916482167;
				switch (num2 == num)
				{
				}
				num = (short)949944321;
				if (num != 0)
				{
				}
				num = (short)645332992;
				short num3 = num;
				num = (short)814284800;
				if (num != 0)
				{
				}
				this.radProfGeneralDisableTones_A7870.Value = value;
			}
		}

		// Token: 0x170030CA RID: 12490
		// (get) Token: 0x06005E31 RID: 24113 RVA: 0x0054AD20 File Offset: 0x00548F20
		public global::AcpBusinessLayer.AcpField<bool> RadProfGeneralDisableTones_A7870
		{
			get
			{
				short num = (short)1741425192;
				short num2 = num;
				num = (short)763562536;
				switch (num2 == num)
				{
				}
				num = (short)1121976320;
				if (num != 0)
				{
				}
				num = (short)672989184;
				short num3 = num;
				num = (short)2121072641;
				if (num != 0)
				{
				}
				return this.radProfGeneralDisableTones_A7870;
			}
		}

		// Token: 0x170030CB RID: 12491
		// (get) Token: 0x06005E32 RID: 24114 RVA: 0x0054ADD0 File Offset: 0x00548FD0
		// (set) Token: 0x06005E33 RID: 24115 RVA: 0x0054AE88 File Offset: 0x00549088
		public bool RadProfGeneralDisableTones_A7870_UIValue
		{
			get
			{
				short num = (short)1346282156;
				short num2 = num;
				num = (short)1663017644;
				switch (num2 == num)
				{
				}
				num = (short)1442971649;
				if (num != 0)
				{
				}
				num = (short)652738560;
				short num3 = num;
				num = (short)613023744;
				if (num != 0)
				{
				}
				return this.radProfGeneralDisableTones_A7870.Value;
			}
			set
			{
				short num = (short)1788164959;
				short num2 = num;
				num = (short)1122581343;
				switch (num2 == num)
				{
				}
				num = (short)362414081;
				if (num != 0)
				{
				}
				num = (short)1174142976;
				short num3 = num;
				num = (short)1255276544;
				if (num != 0)
				{
				}
				this.radProfGeneralDisableTones_A7870.Value = value;
			}
		}

		// Token: 0x170030CC RID: 12492
		// (get) Token: 0x06005E34 RID: 24116 RVA: 0x0054AF40 File Offset: 0x00549140
		// (set) Token: 0x06005E35 RID: 24117 RVA: 0x0054AFF4 File Offset: 0x005491F4
		public bool RadProfGeneralDisableTones_A7870_Applicable
		{
			get
			{
				short num = (short)341770241;
				if (num != 0)
				{
				}
				num = (short)758858691;
				short num2 = num;
				num = (short)1043416003;
				switch (num2 == num)
				{
				}
				num = (short)1943535616;
				short num3 = num;
				num = (short)1421344768;
				if (num != 0)
				{
				}
				return this.radProfGeneralDisableTones_A7870.Applicable;
			}
			set
			{
				short num = (short)149576824;
				short num2 = num;
				num = (short)1616665720;
				switch (num2 == num)
				{
				}
				num = (short)1488060417;
				if (num != 0)
				{
				}
				num = (short)1792147456;
				short num3 = num;
				num = (short)1783824384;
				if (num != 0)
				{
				}
				this.radProfGeneralDisableTones_A7870.Applicable = value;
			}
		}

		// Token: 0x170030CD RID: 12493
		// (get) Token: 0x06005E36 RID: 24118 RVA: 0x0054B0A8 File Offset: 0x005492A8
		// (set) Token: 0x06005E37 RID: 24119 RVA: 0x0054B160 File Offset: 0x00549360
		public bool RadProfGeneralDisableTones_A7870_Valid
		{
			get
			{
				short num = (short)1713853914;
				short num2 = num;
				num = (short)399726042;
				switch (num2 == num)
				{
				}
				num = (short)220135425;
				if (num != 0)
				{
				}
				num = (short)533331968;
				short num3 = num;
				num = (short)1365180416;
				if (num != 0)
				{
				}
				return this.radProfGeneralDisableTones_A7870.Valid;
			}
			set
			{
				short num = (short)1536712146;
				short num2 = num;
				num = (short)1226464722;
				switch (num2 == num)
				{
				}
				num = (short)1719140353;
				if (num != 0)
				{
				}
				num = (short)827195392;
				short num3 = num;
				num = (short)1363345408;
				if (num != 0)
				{
				}
				this.radProfGeneralDisableTones_A7870.Valid = value;
			}
		}

		// Token: 0x170030CE RID: 12494
		// (get) Token: 0x06005E38 RID: 24120 RVA: 0x0054B218 File Offset: 0x00549418
		// (set) Token: 0x06005E39 RID: 24121 RVA: 0x0054B2CC File Offset: 0x005494CC
		public bool RadProfGeneralDisableTones_A7870_Visible
		{
			get
			{
				short num = (short)1909432448;
				short num2 = num;
				num = (short)1424990336;
				switch (num2 == num)
				{
				}
				num = (short)1038286849;
				if (num != 0)
				{
				}
				num = (short)402194432;
				short num3 = num;
				num = (short)1828913152;
				if (num != 0)
				{
				}
				return this.radProfGeneralDisableTones_A7870.Visible;
			}
			set
			{
				short num = (short)1651769345;
				if (num != 0)
				{
				}
				num = (short)1739400390;
				short num2 = num;
				num = (short)1409098950;
				switch (num2 == num)
				{
				}
				num = (short)1115357184;
				short num3 = num;
				num = (short)819658752;
				if (num != 0)
				{
				}
				this.radProfGeneralDisableTones_A7870.Visible = value;
			}
		}

		// Token: 0x170030CF RID: 12495
		// (get) Token: 0x06005E3A RID: 24122 RVA: 0x0054B380 File Offset: 0x00549580
		// (set) Token: 0x06005E3B RID: 24123 RVA: 0x0054B438 File Offset: 0x00549638
		public bool RadProfGeneralDisableTones_A7870_Editable
		{
			get
			{
				short num = (short)186373816;
				short num2 = num;
				num = (short)1410586296;
				switch (num2 == num)
				{
				}
				num = (short)1584922624;
				if (num != 0)
				{
				}
				num = (short)1292632064;
				short num3 = num;
				num = (short)890896385;
				if (num != 0)
				{
				}
				return this.radProfGeneralDisableTones_A7870.Editable;
			}
			set
			{
				short num = (short)292711603;
				short num2 = num;
				num = (short)1881500851;
				switch (num2 == num)
				{
				}
				num = (short)1083572225;
				if (num != 0)
				{
				}
				num = (short)1627652096;
				short num3 = num;
				num = (short)1495072768;
				if (num != 0)
				{
				}
				this.radProfGeneralDisableTones_A7870.Editable = value;
			}
		}

		// Token: 0x170030D0 RID: 12496
		// (get) Token: 0x06005E3C RID: 24124 RVA: 0x0054B4F0 File Offset: 0x005496F0
		internal string RadProfGeneralDisableTones_A7870_UILabel
		{
			get
			{
				short num = (short)746280744;
				short num2 = num;
				num = (short)591353640;
				switch (num2 == num)
				{
				}
				num = (short)1765081089;
				if (num != 0)
				{
				}
				num = (short)104660992;
				short num3 = num;
				num = (short)242352128;
				if (num != 0)
				{
				}
				return this.radProfGeneralDisableTones_A7870.UIName;
			}
		}

		// Token: 0x170030D1 RID: 12497
		// (get) Token: 0x06005E3D RID: 24125 RVA: 0x0054B5A4 File Offset: 0x005497A4
		// (set) Token: 0x06005E3E RID: 24126 RVA: 0x0054B658 File Offset: 0x00549858
		internal bool RadProfGeneralDisableTones_A7870_HiddenStatic
		{
			get
			{
				short num = (short)456317835;
				short num2 = num;
				num = (short)2068896651;
				switch (num2 == num)
				{
				}
				num = (short)853344257;
				if (num != 0)
				{
				}
				num = (short)1627324416;
				short num3 = num;
				num = (short)1629749248;
				if (num != 0)
				{
				}
				return this.radProfGeneralDisableTones_A7870.HiddenStatic;
			}
			set
			{
				short num = (short)244405457;
				short num2 = num;
				num = (short)1348097233;
				switch (num2 == num)
				{
				}
				num = (short)1114177537;
				if (num != 0)
				{
				}
				num = (short)109772800;
				short num3 = num;
				num = (short)482148352;
				if (num != 0)
				{
				}
				this.radProfGeneralDisableTones_A7870.HiddenStatic = value;
			}
		}

		// Token: 0x170030D2 RID: 12498
		// (get) Token: 0x06005E3F RID: 24127 RVA: 0x0054B70C File Offset: 0x0054990C
		// (set) Token: 0x06005E40 RID: 24128 RVA: 0x0054B7C0 File Offset: 0x005499C0
		internal bool RadProfGeneralDisableTones_A7870_HiddenDynamic
		{
			get
			{
				short num = (short)1929022595;
				short num2 = num;
				num = (short)1716620419;
				switch (num2 == num)
				{
				}
				num = (short)1038155777;
				if (num != 0)
				{
				}
				num = (short)998965248;
				short num3 = num;
				num = (short)1837367296;
				if (num != 0)
				{
				}
				return this.radProfGeneralDisableTones_A7870.HiddenDynamic;
			}
			set
			{
				short num = (short)206536726;
				short num2 = num;
				num = (short)295010326;
				switch (num2 == num)
				{
				}
				num = (short)741212161;
				if (num != 0)
				{
				}
				num = (short)585498624;
				short num3 = num;
				num = (short)2125594624;
				if (num != 0)
				{
				}
				this.radProfGeneralDisableTones_A7870.HiddenDynamic = value;
			}
		}

		// Token: 0x170030D3 RID: 12499
		// (get) Token: 0x06005E41 RID: 24129 RVA: 0x0054B878 File Offset: 0x00549A78
		public bool RadProfGeneralDisableTones_A7870_HasDiffs
		{
			get
			{
				short num = (short)848477639;
				short num2 = num;
				num = (short)178634183;
				switch (num2 == num)
				{
				}
				num = (short)58916865;
				if (num != 0)
				{
				}
				num = (short)733282304;
				short num3 = num;
				num = (short)2035613696;
				if (num != 0)
				{
				}
				return this.radProfGeneralDisableTones_A7870._HasDiffs;
			}
		}

		// Token: 0x170030D4 RID: 12500
		// (get) Token: 0x06005E42 RID: 24130 RVA: 0x0054B92C File Offset: 0x00549B2C
		// (set) Token: 0x06005E43 RID: 24131 RVA: 0x0054B9E0 File Offset: 0x00549BE0
		public string RadProfGeneralRadioProfileName_A19564Value
		{
			get
			{
				short num = (short)2088475986;
				short num2 = num;
				num = (short)160079186;
				switch (num2 == num)
				{
				}
				num = (short)1353777153;
				if (num != 0)
				{
				}
				num = (short)1413808128;
				short num3 = num;
				num = (short)202178560;
				if (num != 0)
				{
				}
				return this.radProfGeneralRadioProfileName_A19564.Value;
			}
			set
			{
				short num = (short)204341249;
				if (num != 0)
				{
				}
				num = (short)42926082;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						return;
					case 1:
					{
						this.radProfGeneralRadioProfileName_A19564.Value = value;
						num = (short)1150002968;
						short num3 = num;
						num = (short)1708500760;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return;
						case 1:
							break;
						default:
						{
							num = (short)1769078784;
							short num4 = num;
							break;
						}
						}
						num = (short)1095499776;
						if (num != 0)
						{
						}
						num = (short)423428096;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						switch (0)
						{
						case 0:
							goto IL_5A;
						}
						continue;
					}
					IL_5A:
					if (string.IsNullOrEmpty(value.Trim()))
					{
						break;
					}
					num = (short)946601985;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x170030D5 RID: 12501
		// (get) Token: 0x06005E44 RID: 24132 RVA: 0x0054BB08 File Offset: 0x00549D08
		// (set) Token: 0x06005E45 RID: 24133 RVA: 0x0054BBBC File Offset: 0x00549DBC
		public string RadProfGeneralRadioProfileName_A19564_UIValue
		{
			get
			{
				short num = (short)1753174849;
				short num2 = num;
				num = (short)1862882113;
				switch (num2 == num)
				{
				}
				num = (short)1043791873;
				if (num != 0)
				{
				}
				num = (short)1759510528;
				short num3 = num;
				num = (short)1768292352;
				if (num != 0)
				{
				}
				return this.radProfGeneralRadioProfileName_A19564.Value;
			}
			set
			{
				short num = (short)1724905740;
				short num2 = num;
				num = (short)112392460;
				switch (num2 == num)
				{
				}
				num = (short)1213136896;
				if (num != 0)
				{
				}
				num = (short)749142016;
				short num3 = num;
				num = (short)2020540417;
				if (num != 0)
				{
				}
				this.radProfGeneralRadioProfileName_A19564.Value = value;
			}
		}

		// Token: 0x170030D6 RID: 12502
		// (get) Token: 0x06005E46 RID: 24134 RVA: 0x0054BC70 File Offset: 0x00549E70
		public global::AcpBusinessLayer.AcpKeyField RadProfGeneralRadioProfileName_A19564
		{
			get
			{
				short num = (short)1070686165;
				short num2 = num;
				num = (short)1064787925;
				switch (num2 == num)
				{
				}
				num = (short)840564736;
				if (num != 0)
				{
				}
				num = (short)1131347968;
				short num3 = num;
				num = (short)697040897;
				if (num != 0)
				{
				}
				return this.radProfGeneralRadioProfileName_A19564;
			}
		}

		// Token: 0x170030D7 RID: 12503
		// (get) Token: 0x06005E47 RID: 24135 RVA: 0x0054BD24 File Offset: 0x00549F24
		// (set) Token: 0x06005E48 RID: 24136 RVA: 0x0054BDD8 File Offset: 0x00549FD8
		public bool RadProfGeneralRadioProfileName_A19564_Applicable
		{
			get
			{
				short num = (short)1863030905;
				short num2 = num;
				num = (short)839358585;
				switch (num2 == num)
				{
				}
				num = (short)1452867584;
				if (num != 0)
				{
				}
				num = (short)1993146368;
				short num3 = num;
				num = (short)2025979905;
				if (num != 0)
				{
				}
				return this.radProfGeneralRadioProfileName_A19564.Applicable;
			}
			set
			{
				short num = (short)1513570538;
				short num2 = num;
				num = (short)2131181802;
				switch (num2 == num)
				{
				}
				num = (short)1282670593;
				if (num != 0)
				{
				}
				num = (short)1581383680;
				short num3 = num;
				num = (short)1487536128;
				if (num != 0)
				{
				}
				this.radProfGeneralRadioProfileName_A19564.Applicable = value;
			}
		}

		// Token: 0x170030D8 RID: 12504
		// (get) Token: 0x06005E49 RID: 24137 RVA: 0x0054BE8C File Offset: 0x0054A08C
		// (set) Token: 0x06005E4A RID: 24138 RVA: 0x0054BF44 File Offset: 0x0054A144
		public bool RadProfGeneralRadioProfileName_A19564_Valid
		{
			get
			{
				short num = (short)572334922;
				short num2 = num;
				num = (short)11739978;
				switch (num2 == num)
				{
				}
				num = (short)137887745;
				if (num != 0)
				{
				}
				num = (short)114360320;
				short num3 = num;
				num = (short)942800896;
				if (num != 0)
				{
				}
				return this.radProfGeneralRadioProfileName_A19564.Valid;
			}
			set
			{
				short num = (short)1498348914;
				short num2 = num;
				num = (short)503446898;
				switch (num2 == num)
				{
				}
				num = (short)648216577;
				if (num != 0)
				{
				}
				num = (short)786759680;
				short num3 = num;
				num = (short)782499840;
				if (num != 0)
				{
				}
				this.radProfGeneralRadioProfileName_A19564.Valid = value;
			}
		}

		// Token: 0x170030D9 RID: 12505
		// (get) Token: 0x06005E4B RID: 24139 RVA: 0x0054C000 File Offset: 0x0054A200
		// (set) Token: 0x06005E4C RID: 24140 RVA: 0x0054C0B8 File Offset: 0x0054A2B8
		public bool RadProfGeneralRadioProfileName_A19564_Visible
		{
			get
			{
				short num = (short)1569539262;
				short num2 = num;
				num = (short)1940538558;
				switch (num2 == num)
				{
				}
				num = (short)1347813377;
				if (num != 0)
				{
				}
				num = (short)10551296;
				short num3 = num;
				num = (short)558366720;
				if (num != 0)
				{
				}
				return this.radProfGeneralRadioProfileName_A19564.Visible;
			}
			set
			{
				short num = (short)1852817988;
				short num2 = num;
				num = (short)289587780;
				switch (num2 == num)
				{
				}
				num = (short)183631872;
				if (num != 0)
				{
				}
				num = (short)984285184;
				short num3 = num;
				num = (short)1870856193;
				if (num != 0)
				{
				}
				this.radProfGeneralRadioProfileName_A19564.Visible = value;
			}
		}

		// Token: 0x170030DA RID: 12506
		// (get) Token: 0x06005E4D RID: 24141 RVA: 0x0054C16C File Offset: 0x0054A36C
		// (set) Token: 0x06005E4E RID: 24142 RVA: 0x0054C220 File Offset: 0x0054A420
		public bool RadProfGeneralRadioProfileName_A19564_Editable
		{
			get
			{
				short num = (short)512115923;
				short num2 = num;
				num = (short)1727284435;
				switch (num2 == num)
				{
				}
				num = (short)1766916097;
				if (num != 0)
				{
				}
				num = (short)1994391552;
				short num3 = num;
				num = (short)228982784;
				if (num != 0)
				{
				}
				return this.radProfGeneralRadioProfileName_A19564.Editable;
			}
			set
			{
				short num = (short)1064010851;
				short num2 = num;
				num = (short)1041335395;
				switch (num2 == num)
				{
				}
				num = (short)679804929;
				if (num != 0)
				{
				}
				num = (short)2137784320;
				short num3 = num;
				num = (short)533200896;
				if (num != 0)
				{
				}
				this.radProfGeneralRadioProfileName_A19564.Editable = value;
			}
		}

		// Token: 0x170030DB RID: 12507
		// (get) Token: 0x06005E4F RID: 24143 RVA: 0x0054C2D4 File Offset: 0x0054A4D4
		internal string RadProfGeneralRadioProfileName_A19564_UILabel
		{
			get
			{
				short num = (short)90222445;
				short num2 = num;
				num = (short)900771693;
				switch (num2 == num)
				{
				}
				num = (short)1332477952;
				if (num != 0)
				{
				}
				num = (short)250413056;
				short num3 = num;
				num = (short)518389761;
				if (num != 0)
				{
				}
				return this.radProfGeneralRadioProfileName_A19564.UIName;
			}
		}

		// Token: 0x170030DC RID: 12508
		// (get) Token: 0x06005E50 RID: 24144 RVA: 0x0054C388 File Offset: 0x0054A588
		// (set) Token: 0x06005E51 RID: 24145 RVA: 0x0054C43C File Offset: 0x0054A63C
		internal bool RadProfGeneralRadioProfileName_A19564_HiddenStatic
		{
			get
			{
				short num = (short)241618583;
				short num2 = num;
				num = (short)1004129943;
				switch (num2 == num)
				{
				}
				num = (short)456327168;
				if (num != 0)
				{
				}
				num = (short)1802829824;
				short num3 = num;
				num = (short)1908670465;
				if (num != 0)
				{
				}
				return this.radProfGeneralRadioProfileName_A19564.HiddenStatic;
			}
			set
			{
				short num = (short)975674266;
				short num2 = num;
				num = (short)465607578;
				switch (num2 == num)
				{
				}
				num = (short)2017263617;
				if (num != 0)
				{
				}
				num = (short)311885824;
				short num3 = num;
				num = (short)1384120320;
				if (num != 0)
				{
				}
				this.radProfGeneralRadioProfileName_A19564.HiddenStatic = value;
			}
		}

		// Token: 0x170030DD RID: 12509
		// (get) Token: 0x06005E52 RID: 24146 RVA: 0x0054C4F4 File Offset: 0x0054A6F4
		// (set) Token: 0x06005E53 RID: 24147 RVA: 0x0054C5A8 File Offset: 0x0054A7A8
		internal bool RadProfGeneralRadioProfileName_A19564_HiddenDynamic
		{
			get
			{
				short num = (short)1072627713;
				if (num != 0)
				{
				}
				num = (short)578611688;
				short num2 = num;
				num = (short)620161512;
				switch (num2 == num)
				{
				}
				num = (short)206110720;
				short num3 = num;
				num = (short)1062666240;
				if (num != 0)
				{
				}
				return this.radProfGeneralRadioProfileName_A19564.HiddenDynamic;
			}
			set
			{
				short num = (short)1724254567;
				short num2 = num;
				num = (short)1465452903;
				switch (num2 == num)
				{
				}
				num = (short)108003328;
				if (num != 0)
				{
				}
				num = (short)150798336;
				short num3 = num;
				num = (short)1265172481;
				if (num != 0)
				{
				}
				this.radProfGeneralRadioProfileName_A19564.HiddenDynamic = value;
			}
		}

		// Token: 0x170030DE RID: 12510
		// (get) Token: 0x06005E54 RID: 24148 RVA: 0x0054C65C File Offset: 0x0054A85C
		public bool RadProfGeneralRadioProfileName_A19564_HasDiffs
		{
			get
			{
				short num = (short)2954002;
				short num2 = num;
				num = (short)1232802578;
				switch (num2 == num)
				{
				}
				num = (short)520355840;
				if (num != 0)
				{
				}
				num = (short)332857344;
				short num3 = num;
				num = (short)1653080065;
				if (num != 0)
				{
				}
				return this.radProfGeneralRadioProfileName_A19564._HasDiffs;
			}
		}

		// Token: 0x170030DF RID: 12511
		// (get) Token: 0x06005E55 RID: 24149 RVA: 0x0054C710 File Offset: 0x0054A910
		// (set) Token: 0x06005E56 RID: 24150 RVA: 0x0054C7C4 File Offset: 0x0054A9C4
		public int RadProfGeneralSpeakerAudioRouting_A19566Value
		{
			get
			{
				short num = (short)2042652960;
				short num2 = num;
				num = (short)455371040;
				switch (num2 == num)
				{
				}
				num = (short)968032257;
				if (num != 0)
				{
				}
				num = (short)1962475520;
				short num3 = num;
				num = (short)548601856;
				if (num != 0)
				{
				}
				return this.radProfGeneralSpeakerAudioRouting_A19566.Value;
			}
			set
			{
				short num = (short)197918721;
				if (num != 0)
				{
				}
				num = (short)1135015443;
				short num2 = num;
				num = (short)2081158675;
				switch (num2 == num)
				{
				}
				num = (short)1627389952;
				short num3 = num;
				num = (short)1396375552;
				if (num != 0)
				{
				}
				this.radProfGeneralSpeakerAudioRouting_A19566.Value = value;
			}
		}

		// Token: 0x170030E0 RID: 12512
		// (get) Token: 0x06005E57 RID: 24151 RVA: 0x0054C878 File Offset: 0x0054AA78
		// (set) Token: 0x06005E58 RID: 24152 RVA: 0x0054C92C File Offset: 0x0054AB2C
		public string RadProfGeneralSpeakerAudioRouting_A19566_UIValue
		{
			get
			{
				short num = (short)1543831553;
				if (num != 0)
				{
				}
				num = (short)1475268696;
				short num2 = num;
				num = (short)41078872;
				switch (num2 == num)
				{
				}
				num = (short)1449525248;
				short num3 = num;
				num = (short)1925644288;
				if (num != 0)
				{
				}
				return this.radProfGeneralSpeakerAudioRouting_A19566.UIValue;
			}
			set
			{
				short num = (short)700201021;
				short num2 = num;
				num = (short)2003449917;
				switch (num2 == num)
				{
				}
				num = (short)206569473;
				if (num != 0)
				{
				}
				num = (short)582942720;
				short num3 = num;
				num = (short)853803008;
				if (num != 0)
				{
				}
				this.radProfGeneralSpeakerAudioRouting_A19566.UIValue = value;
			}
		}

		// Token: 0x170030E1 RID: 12513
		// (get) Token: 0x06005E59 RID: 24153 RVA: 0x0054C9E4 File Offset: 0x0054ABE4
		public global::AcpBusinessLayer.AcpListField RadProfGeneralSpeakerAudioRouting_A19566
		{
			get
			{
				short num = (short)387630355;
				short num2 = num;
				num = (short)2134492435;
				switch (num2 == num)
				{
				}
				num = (short)1009516545;
				if (num != 0)
				{
				}
				num = (short)1746468864;
				short num3 = num;
				num = (short)835059712;
				if (num != 0)
				{
				}
				return this.radProfGeneralSpeakerAudioRouting_A19566;
			}
		}

		// Token: 0x170030E2 RID: 12514
		// (get) Token: 0x06005E5A RID: 24154 RVA: 0x0054CA94 File Offset: 0x0054AC94
		// (set) Token: 0x06005E5B RID: 24155 RVA: 0x0054CB48 File Offset: 0x0054AD48
		public bool RadProfGeneralSpeakerAudioRouting_A19566_Applicable
		{
			get
			{
				short num = (short)1077411840;
				short num2 = num;
				num = (short)1128575885;
				short num3 = num;
				num = (short)372945805;
				switch (num3 == num)
				{
				}
				num = (short)1520959489;
				if (num != 0)
				{
				}
				num = (short)1182203904;
				if (num != 0)
				{
				}
				return this.radProfGeneralSpeakerAudioRouting_A19566.Applicable;
			}
			set
			{
				short num = (short)128843776;
				short num2 = num;
				num = (short)1483576215;
				short num3 = num;
				num = (short)2042008471;
				switch (num3 == num)
				{
				}
				num = (short)1417019393;
				if (num != 0)
				{
				}
				num = (short)350552064;
				if (num != 0)
				{
				}
				this.radProfGeneralSpeakerAudioRouting_A19566.Applicable = value;
			}
		}

		// Token: 0x170030E3 RID: 12515
		// (get) Token: 0x06005E5C RID: 24156 RVA: 0x0054CBFC File Offset: 0x0054ADFC
		// (set) Token: 0x06005E5D RID: 24157 RVA: 0x0054CCB0 File Offset: 0x0054AEB0
		public bool RadProfGeneralSpeakerAudioRouting_A19566_Valid
		{
			get
			{
				short num = (short)1209729024;
				short num2 = num;
				num = (short)1604989416;
				short num3 = num;
				num = (short)1321415144;
				switch (num3 == num)
				{
				}
				num = (short)1070202881;
				if (num != 0)
				{
				}
				num = (short)1290403840;
				if (num != 0)
				{
				}
				return this.radProfGeneralSpeakerAudioRouting_A19566.Valid;
			}
			set
			{
				short num = (short)724500480;
				short num2 = num;
				num = (short)1052357194;
				short num3 = num;
				num = (short)1736684106;
				switch (num3 == num)
				{
				}
				num = (short)2012479489;
				if (num != 0)
				{
				}
				num = (short)1344602112;
				if (num != 0)
				{
				}
				this.radProfGeneralSpeakerAudioRouting_A19566.Valid = value;
			}
		}

		// Token: 0x170030E4 RID: 12516
		// (get) Token: 0x06005E5E RID: 24158 RVA: 0x0054CD68 File Offset: 0x0054AF68
		// (set) Token: 0x06005E5F RID: 24159 RVA: 0x0054CE1C File Offset: 0x0054B01C
		public bool RadProfGeneralSpeakerAudioRouting_A19566_Visible
		{
			get
			{
				short num = (short)262930432;
				short num2 = num;
				num = (short)1582235649;
				if (num != 0)
				{
				}
				num = (short)1531925237;
				short num3 = num;
				num = (short)954749685;
				switch (num3 == num)
				{
				}
				num = (short)1645150208;
				if (num != 0)
				{
				}
				return this.radProfGeneralSpeakerAudioRouting_A19566.Visible;
			}
			set
			{
				short num = (short)2145779712;
				short num2 = num;
				num = (short)1648616056;
				short num3 = num;
				num = (short)280027768;
				switch (num3 == num)
				{
				}
				num = (short)950337536;
				if (num != 0)
				{
				}
				num = (short)766377985;
				if (num != 0)
				{
				}
				this.radProfGeneralSpeakerAudioRouting_A19566.Visible = value;
			}
		}

		// Token: 0x170030E5 RID: 12517
		// (get) Token: 0x06005E60 RID: 24160 RVA: 0x0054CED0 File Offset: 0x0054B0D0
		// (set) Token: 0x06005E61 RID: 24161 RVA: 0x0054CF84 File Offset: 0x0054B184
		public bool RadProfGeneralSpeakerAudioRouting_A19566_Editable
		{
			get
			{
				short num = (short)206307328;
				short num2 = num;
				num = (short)700971447;
				short num3 = num;
				num = (short)1881602487;
				switch (num3 == num)
				{
				}
				num = (short)1456340993;
				if (num != 0)
				{
				}
				num = (short)660013056;
				if (num != 0)
				{
				}
				return this.radProfGeneralSpeakerAudioRouting_A19566.Editable;
			}
			set
			{
				short num = (short)2096562176;
				short num2 = num;
				num = (short)1408696321;
				if (num != 0)
				{
				}
				num = (short)898457544;
				short num3 = num;
				num = (short)420175816;
				switch (num3 == num)
				{
				}
				num = (short)1621753856;
				if (num != 0)
				{
				}
				this.radProfGeneralSpeakerAudioRouting_A19566.Editable = value;
			}
		}

		// Token: 0x170030E6 RID: 12518
		// (get) Token: 0x06005E62 RID: 24162 RVA: 0x0054D03C File Offset: 0x0054B23C
		internal string RadProfGeneralSpeakerAudioRouting_A19566_UILabel
		{
			get
			{
				short num = (short)1123155968;
				short num2 = num;
				num = (short)352715357;
				short num3 = num;
				num = (short)367460957;
				switch (num3 == num)
				{
				}
				num = (short)919207937;
				if (num != 0)
				{
				}
				num = (short)1148059648;
				if (num != 0)
				{
				}
				return this.radProfGeneralSpeakerAudioRouting_A19566.UIName;
			}
		}

		// Token: 0x170030E7 RID: 12519
		// (get) Token: 0x06005E63 RID: 24163 RVA: 0x0054D0F0 File Offset: 0x0054B2F0
		// (set) Token: 0x06005E64 RID: 24164 RVA: 0x0054D1A4 File Offset: 0x0054B3A4
		internal bool RadProfGeneralSpeakerAudioRouting_A19566_HiddenStatic
		{
			get
			{
				short num = (short)1066860544;
				short num2 = num;
				num = (short)893274604;
				short num3 = num;
				num = (short)1577011692;
				switch (num3 == num)
				{
				}
				num = (short)723058688;
				if (num != 0)
				{
				}
				num = (short)95485953;
				if (num != 0)
				{
				}
				return this.radProfGeneralSpeakerAudioRouting_A19566.HiddenStatic;
			}
			set
			{
				short num = (short)1300758528;
				short num2 = num;
				num = (short)1419500318;
				short num3 = num;
				num = (short)1407441694;
				switch (num3 == num)
				{
				}
				num = (short)1229324288;
				if (num != 0)
				{
				}
				num = (short)1330708481;
				if (num != 0)
				{
				}
				this.radProfGeneralSpeakerAudioRouting_A19566.HiddenStatic = value;
			}
		}

		// Token: 0x170030E8 RID: 12520
		// (get) Token: 0x06005E65 RID: 24165 RVA: 0x0054D25C File Offset: 0x0054B45C
		// (set) Token: 0x06005E66 RID: 24166 RVA: 0x0054D310 File Offset: 0x0054B510
		internal bool RadProfGeneralSpeakerAudioRouting_A19566_HiddenDynamic
		{
			get
			{
				short num = (short)5046272;
				short num2 = num;
				num = (short)1392574465;
				if (num != 0)
				{
				}
				num = (short)1702220438;
				short num3 = num;
				num = (short)355979926;
				switch (num3 == num)
				{
				}
				num = (short)1718288384;
				if (num != 0)
				{
				}
				return this.radProfGeneralSpeakerAudioRouting_A19566.HiddenDynamic;
			}
			set
			{
				short num = (short)1517486080;
				short num2 = num;
				num = (short)559392297;
				short num3 = num;
				num = (short)244753961;
				switch (num3 == num)
				{
				}
				num = (short)626655232;
				if (num != 0)
				{
				}
				num = (short)1305935873;
				if (num != 0)
				{
				}
				this.radProfGeneralSpeakerAudioRouting_A19566.HiddenDynamic = value;
			}
		}

		// Token: 0x170030E9 RID: 12521
		// (get) Token: 0x06005E67 RID: 24167 RVA: 0x0054D3C4 File Offset: 0x0054B5C4
		public bool RadProfGeneralSpeakerAudioRouting_A19566_HasDiffs
		{
			get
			{
				short num = (short)1936850944;
				short num2 = num;
				num = (short)1208708971;
				short num3 = num;
				num = (short)658534251;
				switch (num3 == num)
				{
				}
				num = (short)95682561;
				if (num != 0)
				{
				}
				num = (short)978714624;
				if (num != 0)
				{
				}
				return this.radProfGeneralSpeakerAudioRouting_A19566._HasDiffs;
			}
		}

		// Token: 0x170030EA RID: 12522
		// (get) Token: 0x06005E68 RID: 24168 RVA: 0x0054D474 File Offset: 0x0054B674
		// (set) Token: 0x06005E69 RID: 24169 RVA: 0x0054D52C File Offset: 0x0054B72C
		public bool RadProfGeneralDisableEmergencyAlertsNotification_A19570Value
		{
			get
			{
				short num = (short)902692864;
				short num2 = num;
				num = (short)1666755155;
				short num3 = num;
				num = (short)212838995;
				switch (num3 == num)
				{
				}
				num = (short)1505034240;
				if (num != 0)
				{
				}
				num = (short)1300889601;
				if (num != 0)
				{
				}
				return this.radProfGeneralDisableEmergencyAlertsNotification_A19570.Value;
			}
			set
			{
				short num = (short)749404160;
				short num2 = num;
				num = (short)1623394866;
				short num3 = num;
				num = (short)981404210;
				switch (num3 == num)
				{
				}
				num = (short)889585665;
				if (num != 0)
				{
				}
				num = (short)1777926144;
				if (num != 0)
				{
				}
				this.radProfGeneralDisableEmergencyAlertsNotification_A19570.Value = value;
			}
		}

		// Token: 0x170030EB RID: 12523
		// (get) Token: 0x06005E6A RID: 24170 RVA: 0x0054D5E4 File Offset: 0x0054B7E4
		public global::AcpBusinessLayer.AcpField<bool> RadProfGeneralDisableEmergencyAlertsNotification_A19570
		{
			get
			{
				short num = (short)1679818752;
				short num2 = num;
				num = (short)1879439988;
				short num3 = num;
				num = (short)618592884;
				switch (num3 == num)
				{
				}
				num = (short)895352833;
				if (num != 0)
				{
				}
				num = (short)1976238080;
				if (num != 0)
				{
				}
				return this.radProfGeneralDisableEmergencyAlertsNotification_A19570;
			}
		}

		// Token: 0x170030EC RID: 12524
		// (get) Token: 0x06005E6B RID: 24171 RVA: 0x0054D694 File Offset: 0x0054B894
		// (set) Token: 0x06005E6C RID: 24172 RVA: 0x0054D748 File Offset: 0x0054B948
		public bool RadProfGeneralDisableEmergencyAlertsNotification_A19570_UIValue
		{
			get
			{
				short num = (short)192741376;
				short num2 = num;
				num = (short)268836985;
				short num3 = num;
				num = (short)1685921913;
				switch (num3 == num)
				{
				}
				num = (short)2020802561;
				if (num != 0)
				{
				}
				num = (short)1763311616;
				if (num != 0)
				{
				}
				return this.radProfGeneralDisableEmergencyAlertsNotification_A19570.Value;
			}
			set
			{
				short num = (short)862453760;
				short num2 = num;
				num = (short)651517701;
				short num3 = num;
				num = (short)846094085;
				switch (num3 == num)
				{
				}
				num = (short)1149698049;
				if (num != 0)
				{
				}
				num = (short)99811328;
				if (num != 0)
				{
				}
				this.radProfGeneralDisableEmergencyAlertsNotification_A19570.Value = value;
			}
		}

		// Token: 0x170030ED RID: 12525
		// (get) Token: 0x06005E6D RID: 24173 RVA: 0x0054D7FC File Offset: 0x0054B9FC
		// (set) Token: 0x06005E6E RID: 24174 RVA: 0x0054D8B0 File Offset: 0x0054BAB0
		public bool RadProfGeneralDisableEmergencyAlertsNotification_A19570_Applicable
		{
			get
			{
				short num = (short)1765474304;
				short num2 = num;
				num = (short)1187512321;
				if (num != 0)
				{
				}
				num = (short)59248924;
				short num3 = num;
				num = (short)2004226332;
				switch (num3 == num)
				{
				}
				num = (short)452263936;
				if (num != 0)
				{
				}
				return this.radProfGeneralDisableEmergencyAlertsNotification_A19570.Applicable;
			}
			set
			{
				short num = (short)1505296384;
				short num2 = num;
				num = (short)1710005134;
				short num3 = num;
				num = (short)1116117902;
				switch (num3 == num)
				{
				}
				num = (short)1086324737;
				if (num != 0)
				{
				}
				num = (short)1170997248;
				if (num != 0)
				{
				}
				this.radProfGeneralDisableEmergencyAlertsNotification_A19570.Applicable = value;
			}
		}

		// Token: 0x170030EE RID: 12526
		// (get) Token: 0x06005E6F RID: 24175 RVA: 0x0054D968 File Offset: 0x0054BB68
		// (set) Token: 0x06005E70 RID: 24176 RVA: 0x0054DA1C File Offset: 0x0054BC1C
		public bool RadProfGeneralDisableEmergencyAlertsNotification_A19570_Valid
		{
			get
			{
				short num = (short)1888485376;
				short num2 = num;
				num = (short)1610177452;
				short num3 = num;
				num = (short)2043829164;
				switch (num3 == num)
				{
				}
				num = (short)506920961;
				if (num != 0)
				{
				}
				num = (short)598081536;
				if (num != 0)
				{
				}
				return this.radProfGeneralDisableEmergencyAlertsNotification_A19570.Valid;
			}
			set
			{
				short num = (short)654311424;
				short num2 = num;
				num = (short)1050255459;
				short num3 = num;
				num = (short)1654759523;
				switch (num3 == num)
				{
				}
				num = (short)332398593;
				if (num != 0)
				{
				}
				num = (short)362086400;
				if (num != 0)
				{
				}
				this.radProfGeneralDisableEmergencyAlertsNotification_A19570.Valid = value;
			}
		}

		// Token: 0x170030EF RID: 12527
		// (get) Token: 0x06005E71 RID: 24177 RVA: 0x0054DAD0 File Offset: 0x0054BCD0
		// (set) Token: 0x06005E72 RID: 24178 RVA: 0x0054DB88 File Offset: 0x0054BD88
		public bool RadProfGeneralDisableEmergencyAlertsNotification_A19570_Visible
		{
			get
			{
				short num = (short)1042284544;
				short num2 = num;
				num = (short)302186497;
				if (num != 0)
				{
				}
				num = (short)763701066;
				short num3 = num;
				num = (short)738076490;
				switch (num3 == num)
				{
				}
				num = (short)1513422848;
				if (num != 0)
				{
				}
				return this.radProfGeneralDisableEmergencyAlertsNotification_A19570.Visible;
			}
			set
			{
				short num = (short)1836384256;
				short num2 = num;
				num = (short)2000461339;
				short num3 = num;
				num = (short)871538203;
				switch (num3 == num)
				{
				}
				num = (short)575668225;
				if (num != 0)
				{
				}
				num = (short)1910046720;
				if (num != 0)
				{
				}
				this.radProfGeneralDisableEmergencyAlertsNotification_A19570.Visible = value;
			}
		}

		// Token: 0x170030F0 RID: 12528
		// (get) Token: 0x06005E73 RID: 24179 RVA: 0x0054DC40 File Offset: 0x0054BE40
		// (set) Token: 0x06005E74 RID: 24180 RVA: 0x0054DCF4 File Offset: 0x0054BEF4
		public bool RadProfGeneralDisableEmergencyAlertsNotification_A19570_Editable
		{
			get
			{
				short num = (short)608370688;
				short num2 = num;
				num = (short)246153217;
				if (num != 0)
				{
				}
				num = (short)493271950;
				short num3 = num;
				num = (short)1394195342;
				switch (num3 == num)
				{
				}
				num = (short)2073427968;
				if (num != 0)
				{
				}
				return this.radProfGeneralDisableEmergencyAlertsNotification_A19570.Editable;
			}
			set
			{
				short num = (short)990773248;
				short num2 = num;
				num = (short)1661202851;
				short num3 = num;
				num = (short)576516515;
				switch (num3 == num)
				{
				}
				num = (short)474611713;
				if (num != 0)
				{
				}
				num = (short)994312192;
				if (num != 0)
				{
				}
				this.radProfGeneralDisableEmergencyAlertsNotification_A19570.Editable = value;
			}
		}

		// Token: 0x170030F1 RID: 12529
		// (get) Token: 0x06005E75 RID: 24181 RVA: 0x0054DDAC File Offset: 0x0054BFAC
		internal string RadProfGeneralDisableEmergencyAlertsNotification_A19570_UILabel
		{
			get
			{
				short num = (short)1186070528;
				short num2 = num;
				num = (short)1826573162;
				short num3 = num;
				num = (short)996297578;
				switch (num3 == num)
				{
				}
				num = (short)666566657;
				if (num != 0)
				{
				}
				num = (short)55967744;
				if (num != 0)
				{
				}
				return this.radProfGeneralDisableEmergencyAlertsNotification_A19570.UIName;
			}
		}

		// Token: 0x170030F2 RID: 12530
		// (get) Token: 0x06005E76 RID: 24182 RVA: 0x0054DE60 File Offset: 0x0054C060
		// (set) Token: 0x06005E77 RID: 24183 RVA: 0x0054DF18 File Offset: 0x0054C118
		internal bool RadProfGeneralDisableEmergencyAlertsNotification_A19570_HiddenStatic
		{
			get
			{
				short num = (short)560005120;
				short num2 = num;
				num = (short)1264679280;
				short num3 = num;
				num = (short)875526512;
				switch (num3 == num)
				{
				}
				num = (short)1044185089;
				if (num != 0)
				{
				}
				num = (short)1195835392;
				if (num != 0)
				{
				}
				return this.radProfGeneralDisableEmergencyAlertsNotification_A19570.HiddenStatic;
			}
			set
			{
				short num = (short)264896512;
				short num2 = num;
				num = (short)965809909;
				short num3 = num;
				num = (short)1141380853;
				switch (num3 == num)
				{
				}
				num = (short)1357578241;
				if (num != 0)
				{
				}
				num = (short)573964288;
				if (num != 0)
				{
				}
				this.radProfGeneralDisableEmergencyAlertsNotification_A19570.HiddenStatic = value;
			}
		}

		// Token: 0x170030F3 RID: 12531
		// (get) Token: 0x06005E78 RID: 24184 RVA: 0x0054DFD0 File Offset: 0x0054C1D0
		// (set) Token: 0x06005E79 RID: 24185 RVA: 0x0054E084 File Offset: 0x0054C284
		internal bool RadProfGeneralDisableEmergencyAlertsNotification_A19570_HiddenDynamic
		{
			get
			{
				short num = (short)1234632704;
				short num2 = num;
				num = (short)1915930548;
				short num3 = num;
				num = (short)363317172;
				switch (num3 == num)
				{
				}
				num = (short)271122433;
				if (num != 0)
				{
				}
				num = (short)1176109056;
				if (num != 0)
				{
				}
				return this.radProfGeneralDisableEmergencyAlertsNotification_A19570.HiddenDynamic;
			}
			set
			{
				short num = (short)1305214976;
				short num2 = num;
				num = (short)356633850;
				short num3 = num;
				num = (short)1909574906;
				switch (num3 == num)
				{
				}
				num = (short)1486749697;
				if (num != 0)
				{
				}
				num = (short)788856832;
				if (num != 0)
				{
				}
				this.radProfGeneralDisableEmergencyAlertsNotification_A19570.HiddenDynamic = value;
			}
		}

		// Token: 0x170030F4 RID: 12532
		// (get) Token: 0x06005E7A RID: 24186 RVA: 0x0054E13C File Offset: 0x0054C33C
		public bool RadProfGeneralDisableEmergencyAlertsNotification_A19570_HasDiffs
		{
			get
			{
				short num = (short)264765440;
				short num2 = num;
				num = (short)505966299;
				short num3 = num;
				num = (short)1699114715;
				switch (num3 == num)
				{
				}
				num = (short)401997825;
				if (num != 0)
				{
				}
				num = (short)748617728;
				if (num != 0)
				{
				}
				return this.radProfGeneralDisableEmergencyAlertsNotification_A19570._HasDiffs;
			}
		}

		// Token: 0x170030F5 RID: 12533
		// (get) Token: 0x06005E7B RID: 24187 RVA: 0x0054E1F0 File Offset: 0x0054C3F0
		// (set) Token: 0x06005E7C RID: 24188 RVA: 0x0054E2A4 File Offset: 0x0054C4A4
		public bool RadProfGeneralDisableCriticalAlertsNotification_A19571Value
		{
			get
			{
				short num = (short)482279424;
				short num2 = num;
				num = (short)675843630;
				short num3 = num;
				num = (short)1709805102;
				switch (num3 == num)
				{
				}
				num = (short)662241281;
				if (num != 0)
				{
				}
				num = (short)316538880;
				if (num != 0)
				{
				}
				return this.radProfGeneralDisableCriticalAlertsNotification_A19571.Value;
			}
			set
			{
				short num = (short)1443692544;
				short num2 = num;
				num = (short)1465599358;
				short num3 = num;
				num = (short)283919742;
				switch (num3 == num)
				{
				}
				num = (short)547815425;
				if (num != 0)
				{
				}
				num = (short)1456668672;
				if (num != 0)
				{
				}
				this.radProfGeneralDisableCriticalAlertsNotification_A19571.Value = value;
			}
		}

		// Token: 0x170030F6 RID: 12534
		// (get) Token: 0x06005E7D RID: 24189 RVA: 0x0054E358 File Offset: 0x0054C558
		public global::AcpBusinessLayer.AcpField<bool> RadProfGeneralDisableCriticalAlertsNotification_A19571
		{
			get
			{
				short num = (short)1187381248;
				short num2 = num;
				num = (short)1048103997;
				short num3 = num;
				num = (short)2017643581;
				switch (num3 == num)
				{
				}
				num = (short)1917976577;
				if (num != 0)
				{
				}
				num = (short)1619066880;
				if (num != 0)
				{
				}
				return this.radProfGeneralDisableCriticalAlertsNotification_A19571;
			}
		}

		// Token: 0x170030F7 RID: 12535
		// (get) Token: 0x06005E7E RID: 24190 RVA: 0x0054E408 File Offset: 0x0054C608
		// (set) Token: 0x06005E7F RID: 24191 RVA: 0x0054E4BC File Offset: 0x0054C6BC
		public bool RadProfGeneralDisableCriticalAlertsNotification_A19571_UIValue
		{
			get
			{
				short num = (short)544145408;
				short num2 = num;
				num = (short)286549649;
				short num3 = num;
				num = (short)307390097;
				switch (num3 == num)
				{
				}
				num = (short)28442625;
				if (num != 0)
				{
				}
				num = (short)1473118208;
				if (num != 0)
				{
				}
				return this.radProfGeneralDisableCriticalAlertsNotification_A19571.Value;
			}
			set
			{
				short num = (short)651624448;
				short num2 = num;
				num = (short)2050461344;
				short num3 = num;
				num = (short)1051233952;
				switch (num3 == num)
				{
				}
				num = (short)661127169;
				if (num != 0)
				{
				}
				num = (short)1341456384;
				if (num != 0)
				{
				}
				this.radProfGeneralDisableCriticalAlertsNotification_A19571.Value = value;
			}
		}

		// Token: 0x170030F8 RID: 12536
		// (get) Token: 0x06005E80 RID: 24192 RVA: 0x0054E570 File Offset: 0x0054C770
		// (set) Token: 0x06005E81 RID: 24193 RVA: 0x0054E624 File Offset: 0x0054C824
		public bool RadProfGeneralDisableCriticalAlertsNotification_A19571_Applicable
		{
			get
			{
				short num = (short)588775424;
				short num2 = num;
				num = (short)421056597;
				short num3 = num;
				num = (short)1192546389;
				switch (num3 == num)
				{
				}
				num = (short)1849098241;
				if (num != 0)
				{
				}
				num = (short)1586429952;
				if (num != 0)
				{
				}
				return this.radProfGeneralDisableCriticalAlertsNotification_A19571.Applicable;
			}
			set
			{
				short num = (short)722796544;
				short num2 = num;
				num = (short)1836456698;
				short num3 = num;
				num = (short)50535162;
				switch (num3 == num)
				{
				}
				num = (short)789708801;
				if (num != 0)
				{
				}
				num = (short)891617280;
				if (num != 0)
				{
				}
				this.radProfGeneralDisableCriticalAlertsNotification_A19571.Applicable = value;
			}
		}

		// Token: 0x170030F9 RID: 12537
		// (get) Token: 0x06005E82 RID: 24194 RVA: 0x0054E6D8 File Offset: 0x0054C8D8
		// (set) Token: 0x06005E83 RID: 24195 RVA: 0x0054E790 File Offset: 0x0054C990
		public bool RadProfGeneralDisableCriticalAlertsNotification_A19571_Valid
		{
			get
			{
				short num = (short)161611776;
				short num2 = num;
				num = (short)1553091335;
				short num3 = num;
				num = (short)1955941127;
				switch (num3 == num)
				{
				}
				num = (short)306118656;
				if (num != 0)
				{
				}
				num = (short)132055041;
				if (num != 0)
				{
				}
				return this.radProfGeneralDisableCriticalAlertsNotification_A19571.Valid;
			}
			set
			{
				short num = (short)717488128;
				short num2 = num;
				num = (short)1443390076;
				short num3 = num;
				num = (short)1531798140;
				switch (num3 == num)
				{
				}
				num = (short)581828608;
				if (num != 0)
				{
				}
				num = (short)1987313665;
				if (num != 0)
				{
				}
				this.radProfGeneralDisableCriticalAlertsNotification_A19571.Valid = value;
			}
		}

		// Token: 0x170030FA RID: 12538
		// (get) Token: 0x06005E84 RID: 24196 RVA: 0x0054E844 File Offset: 0x0054CA44
		// (set) Token: 0x06005E85 RID: 24197 RVA: 0x0054E8F8 File Offset: 0x0054CAF8
		public bool RadProfGeneralDisableCriticalAlertsNotification_A19571_Visible
		{
			get
			{
				short num = (short)1885143040;
				short num2 = num;
				num = (short)1650279030;
				short num3 = num;
				num = (short)44122742;
				switch (num3 == num)
				{
				}
				num = (short)1422131200;
				if (num != 0)
				{
				}
				num = (short)1052639233;
				if (num != 0)
				{
				}
				return this.radProfGeneralDisableCriticalAlertsNotification_A19571.Visible;
			}
			set
			{
				short num = (short)1197735936;
				short num2 = num;
				num = (short)1852062327;
				short num3 = num;
				num = (short)130693751;
				switch (num3 == num)
				{
				}
				num = (short)2001403905;
				if (num != 0)
				{
				}
				num = (short)2064121856;
				if (num != 0)
				{
				}
				this.radProfGeneralDisableCriticalAlertsNotification_A19571.Visible = value;
			}
		}

		// Token: 0x170030FB RID: 12539
		// (get) Token: 0x06005E86 RID: 24198 RVA: 0x0054E9B0 File Offset: 0x0054CBB0
		// (set) Token: 0x06005E87 RID: 24199 RVA: 0x0054EA64 File Offset: 0x0054CC64
		public bool RadProfGeneralDisableCriticalAlertsNotification_A19571_Editable
		{
			get
			{
				short num = (short)1372782592;
				short num2 = num;
				num = (short)1211814990;
				short num3 = num;
				num = (short)1002820686;
				switch (num3 == num)
				{
				}
				num = (short)471531520;
				if (num != 0)
				{
				}
				num = (short)654180353;
				if (num != 0)
				{
				}
				return this.radProfGeneralDisableCriticalAlertsNotification_A19571.Editable;
			}
			set
			{
				short num = (short)1562902528;
				short num2 = num;
				num = (short)1411841025;
				short num3 = num;
				num = (short)1404042241;
				switch (num3 == num)
				{
				}
				num = (short)770310144;
				if (num != 0)
				{
				}
				num = (short)191037441;
				if (num != 0)
				{
				}
				this.radProfGeneralDisableCriticalAlertsNotification_A19571.Editable = value;
			}
		}

		// Token: 0x170030FC RID: 12540
		// (get) Token: 0x06005E88 RID: 24200 RVA: 0x0054EB18 File Offset: 0x0054CD18
		internal string RadProfGeneralDisableCriticalAlertsNotification_A19571_UILabel
		{
			get
			{
				short num = (short)991756288;
				short num2 = num;
				num = (short)287307120;
				short num3 = num;
				num = (short)1067578736;
				switch (num3 == num)
				{
				}
				num = (short)836304897;
				if (num != 0)
				{
				}
				num = (short)424869888;
				if (num != 0)
				{
				}
				return this.radProfGeneralDisableCriticalAlertsNotification_A19571.UIName;
			}
		}

		// Token: 0x170030FD RID: 12541
		// (get) Token: 0x06005E89 RID: 24201 RVA: 0x0054EBCC File Offset: 0x0054CDCC
		// (set) Token: 0x06005E8A RID: 24202 RVA: 0x0054EC80 File Offset: 0x0054CE80
		internal bool RadProfGeneralDisableCriticalAlertsNotification_A19571_HiddenStatic
		{
			get
			{
				short num = (short)1952972800;
				short num2 = num;
				num = (short)181500541;
				short num3 = num;
				num = (short)1296530045;
				switch (num3 == num)
				{
				}
				num = (short)1123155969;
				if (num != 0)
				{
				}
				num = (short)158793728;
				if (num != 0)
				{
				}
				return this.radProfGeneralDisableCriticalAlertsNotification_A19571.HiddenStatic;
			}
			set
			{
				short num = (short)1134714644;
				short num2 = num;
				num = (short)567697172;
				switch (num2 == num)
				{
				default:
				{
					num = (short)968294400;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)733609984;
				if (num != 0)
				{
				}
				num = (short)1014235137;
				if (num != 0)
				{
				}
				this.radProfGeneralDisableCriticalAlertsNotification_A19571.HiddenStatic = value;
			}
		}

		// Token: 0x170030FE RID: 12542
		// (get) Token: 0x06005E8B RID: 24203 RVA: 0x0054ED34 File Offset: 0x0054CF34
		// (set) Token: 0x06005E8C RID: 24204 RVA: 0x0054EDEC File Offset: 0x0054CFEC
		internal bool RadProfGeneralDisableCriticalAlertsNotification_A19571_HiddenDynamic
		{
			get
			{
				short num = (short)1391986912;
				short num2 = num;
				num = (short)829950176;
				switch (num2 == num)
				{
				default:
				{
					num = (short)660471808;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1830223873;
				if (num != 0)
				{
				}
				num = (short)1452605440;
				if (num != 0)
				{
				}
				return this.radProfGeneralDisableCriticalAlertsNotification_A19571.HiddenDynamic;
			}
			set
			{
				short num = (short)514195457;
				if (num != 0)
				{
				}
				num = (short)1304756224;
				short num2 = num;
				num = (short)482963115;
				short num3 = num;
				num = (short)698314411;
				switch (num3 == num)
				{
				}
				num = (short)1298792448;
				if (num != 0)
				{
				}
				this.radProfGeneralDisableCriticalAlertsNotification_A19571.HiddenDynamic = value;
			}
		}

		// Token: 0x170030FF RID: 12543
		// (get) Token: 0x06005E8D RID: 24205 RVA: 0x0054EEA4 File Offset: 0x0054D0A4
		public bool RadProfGeneralDisableCriticalAlertsNotification_A19571_HasDiffs
		{
			get
			{
				short num = (short)637982106;
				short num2 = num;
				num = (short)1466160538;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2146500608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2115108865;
				if (num != 0)
				{
				}
				num = (short)978649088;
				if (num != 0)
				{
				}
				return this.radProfGeneralDisableCriticalAlertsNotification_A19571._HasDiffs;
			}
		}

		// Token: 0x17003100 RID: 12544
		// (get) Token: 0x06005E8E RID: 24206 RVA: 0x0054EF58 File Offset: 0x0054D158
		// (set) Token: 0x06005E8F RID: 24207 RVA: 0x0054F010 File Offset: 0x0054D210
		public bool RadProfGeneralDisableCallAlertsNotification_A19572Value
		{
			get
			{
				short num = (short)1473474898;
				short num2 = num;
				num = (short)1762554194;
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
				num = (short)2108030976;
				if (num != 0)
				{
				}
				num = (short)333512705;
				if (num != 0)
				{
				}
				return this.radProfGeneralDisableCallAlertsNotification_A19572.Value;
			}
			set
			{
				short num = (short)1350379297;
				short num2 = num;
				num = (short)1739925281;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1172701184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1074331649;
				if (num != 0)
				{
				}
				num = (short)1663041536;
				if (num != 0)
				{
				}
				this.radProfGeneralDisableCallAlertsNotification_A19572.Value = value;
			}
		}

		// Token: 0x17003101 RID: 12545
		// (get) Token: 0x06005E90 RID: 24208 RVA: 0x0054F0C4 File Offset: 0x0054D2C4
		public global::AcpBusinessLayer.AcpField<bool> RadProfGeneralDisableCallAlertsNotification_A19572
		{
			get
			{
				short num = (short)1852582276;
				short num2 = num;
				num = (short)631974276;
				switch (num2 == num)
				{
				default:
				{
					num = (short)308871168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)317521921;
				if (num != 0)
				{
				}
				num = (short)2126643200;
				if (num != 0)
				{
				}
				return this.radProfGeneralDisableCallAlertsNotification_A19572;
			}
		}

		// Token: 0x17003102 RID: 12546
		// (get) Token: 0x06005E91 RID: 24209 RVA: 0x0054F174 File Offset: 0x0054D374
		// (set) Token: 0x06005E92 RID: 24210 RVA: 0x0054F228 File Offset: 0x0054D428
		public bool RadProfGeneralDisableCallAlertsNotification_A19572_UIValue
		{
			get
			{
				short num = (short)940333024;
				short num2 = num;
				num = (short)1689933792;
				switch (num2 == num)
				{
				default:
				{
					num = (short)898433024;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1272250368;
				if (num != 0)
				{
				}
				num = (short)1304297473;
				if (num != 0)
				{
				}
				return this.radProfGeneralDisableCallAlertsNotification_A19572.Value;
			}
			set
			{
				short num = (short)390329140;
				short num2 = num;
				num = (short)1063646004;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1130037248;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1822031872;
				if (num != 0)
				{
				}
				num = (short)2033516545;
				if (num != 0)
				{
				}
				this.radProfGeneralDisableCallAlertsNotification_A19572.Value = value;
			}
		}

		// Token: 0x17003103 RID: 12547
		// (get) Token: 0x06005E93 RID: 24211 RVA: 0x0054F2E0 File Offset: 0x0054D4E0
		// (set) Token: 0x06005E94 RID: 24212 RVA: 0x0054F394 File Offset: 0x0054D594
		public bool RadProfGeneralDisableCallAlertsNotification_A19572_Applicable
		{
			get
			{
				short num = (short)1265696769;
				if (num != 0)
				{
				}
				num = (short)807206912;
				short num2 = num;
				num = (short)1312557725;
				short num3 = num;
				num = (short)1082591901;
				switch (num3 == num)
				{
				}
				num = (short)1506672640;
				if (num != 0)
				{
				}
				return this.radProfGeneralDisableCallAlertsNotification_A19572.Applicable;
			}
			set
			{
				short num = (short)785454126;
				short num2 = num;
				num = (short)1089803310;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1573060608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1479737345;
				if (num != 0)
				{
				}
				num = (short)719323136;
				if (num != 0)
				{
				}
				this.radProfGeneralDisableCallAlertsNotification_A19572.Applicable = value;
			}
		}

		// Token: 0x17003104 RID: 12548
		// (get) Token: 0x06005E95 RID: 24213 RVA: 0x0054F448 File Offset: 0x0054D648
		// (set) Token: 0x06005E96 RID: 24214 RVA: 0x0054F4FC File Offset: 0x0054D6FC
		public bool RadProfGeneralDisableCallAlertsNotification_A19572_Valid
		{
			get
			{
				short num = (short)36569089;
				if (num != 0)
				{
				}
				num = (short)685047808;
				short num2 = num;
				num = (short)1267898215;
				short num3 = num;
				num = (short)1408145255;
				switch (num3 == num)
				{
				}
				num = (short)1529610240;
				if (num != 0)
				{
				}
				return this.radProfGeneralDisableCallAlertsNotification_A19572.Valid;
			}
			set
			{
				short num = (short)342290644;
				short num2 = num;
				num = (short)975761620;
				switch (num2 == num)
				{
				default:
				{
					num = (short)945356800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)326238208;
				if (num != 0)
				{
				}
				num = (short)45875201;
				if (num != 0)
				{
				}
				this.radProfGeneralDisableCallAlertsNotification_A19572.Valid = value;
			}
		}

		// Token: 0x17003105 RID: 12549
		// (get) Token: 0x06005E97 RID: 24215 RVA: 0x0054F5B0 File Offset: 0x0054D7B0
		// (set) Token: 0x06005E98 RID: 24216 RVA: 0x0054F664 File Offset: 0x0054D864
		public bool RadProfGeneralDisableCallAlertsNotification_A19572_Visible
		{
			get
			{
				short num = (short)1565306444;
				short num2 = num;
				num = (short)1273671244;
				switch (num2 == num)
				{
				default:
				{
					num = (short)6750208;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)234225665;
				if (num != 0)
				{
				}
				num = (short)79560704;
				if (num != 0)
				{
				}
				return this.radProfGeneralDisableCallAlertsNotification_A19572.Visible;
			}
			set
			{
				short num = (short)709879384;
				short num2 = num;
				num = (short)400221784;
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
				num = (short)394330113;
				if (num != 0)
				{
				}
				num = (short)386269184;
				if (num != 0)
				{
				}
				this.radProfGeneralDisableCallAlertsNotification_A19572.Visible = value;
			}
		}

		// Token: 0x17003106 RID: 12550
		// (get) Token: 0x06005E99 RID: 24217 RVA: 0x0054F71C File Offset: 0x0054D91C
		// (set) Token: 0x06005E9A RID: 24218 RVA: 0x0054F7D0 File Offset: 0x0054D9D0
		public bool RadProfGeneralDisableCallAlertsNotification_A19572_Editable
		{
			get
			{
				short num = (short)2086464359;
				short num2 = num;
				num = (short)1345514343;
				switch (num2 == num)
				{
				default:
				{
					num = (short)44564480;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1650851840;
				if (num != 0)
				{
				}
				num = (short)234422273;
				if (num != 0)
				{
				}
				return this.radProfGeneralDisableCallAlertsNotification_A19572.Editable;
			}
			set
			{
				short num = (short)243237431;
				short num2 = num;
				num = (short)252019255;
				switch (num2 == num)
				{
				default:
				{
					num = (short)287375360;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)391970817;
				if (num != 0)
				{
				}
				num = (short)672399360;
				if (num != 0)
				{
				}
				this.radProfGeneralDisableCallAlertsNotification_A19572.Editable = value;
			}
		}

		// Token: 0x17003107 RID: 12551
		// (get) Token: 0x06005E9B RID: 24219 RVA: 0x0054F884 File Offset: 0x0054DA84
		internal string RadProfGeneralDisableCallAlertsNotification_A19572_UILabel
		{
			get
			{
				short num = (short)1316490788;
				short num2 = num;
				num = (short)540282404;
				switch (num2 == num)
				{
				default:
				{
					num = (short)409665536;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1262944257;
				if (num != 0)
				{
				}
				num = (short)1530789888;
				if (num != 0)
				{
				}
				return this.radProfGeneralDisableCallAlertsNotification_A19572.UIName;
			}
		}

		// Token: 0x17003108 RID: 12552
		// (get) Token: 0x06005E9C RID: 24220 RVA: 0x0054F938 File Offset: 0x0054DB38
		// (set) Token: 0x06005E9D RID: 24221 RVA: 0x0054F9EC File Offset: 0x0054DBEC
		internal bool RadProfGeneralDisableCallAlertsNotification_A19572_HiddenStatic
		{
			get
			{
				short num = (short)1742234554;
				short num2 = num;
				num = (short)1184457658;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2015887360;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1116930049;
				if (num != 0)
				{
				}
				num = (short)534511616;
				if (num != 0)
				{
				}
				return this.radProfGeneralDisableCallAlertsNotification_A19572.HiddenStatic;
			}
			set
			{
				short num = (short)782637051;
				short num2 = num;
				num = (short)1637292027;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1470955520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)879558657;
				if (num != 0)
				{
				}
				num = (short)763363328;
				if (num != 0)
				{
				}
				this.radProfGeneralDisableCallAlertsNotification_A19572.HiddenStatic = value;
			}
		}

		// Token: 0x17003109 RID: 12553
		// (get) Token: 0x06005E9E RID: 24222 RVA: 0x0054FAA0 File Offset: 0x0054DCA0
		// (set) Token: 0x06005E9F RID: 24223 RVA: 0x0054FB58 File Offset: 0x0054DD58
		internal bool RadProfGeneralDisableCallAlertsNotification_A19572_HiddenDynamic
		{
			get
			{
				short num = (short)478882284;
				short num2 = num;
				num = (short)1416243692;
				switch (num2 == num)
				{
				default:
				{
					num = (short)680984576;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1690763264;
				if (num != 0)
				{
				}
				num = (short)679608321;
				if (num != 0)
				{
				}
				return this.radProfGeneralDisableCallAlertsNotification_A19572.HiddenDynamic;
			}
			set
			{
				short num = (short)87612949;
				short num2 = num;
				num = (short)357686805;
				switch (num2 == num)
				{
				default:
				{
					num = (short)927334400;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)267386881;
				if (num != 0)
				{
				}
				num = (short)718340096;
				if (num != 0)
				{
				}
				this.radProfGeneralDisableCallAlertsNotification_A19572.HiddenDynamic = value;
			}
		}

		// Token: 0x1700310A RID: 12554
		// (get) Token: 0x06005EA0 RID: 24224 RVA: 0x0054FC10 File Offset: 0x0054DE10
		public bool RadProfGeneralDisableCallAlertsNotification_A19572_HasDiffs
		{
			get
			{
				short num = (short)2018091937;
				short num2 = num;
				num = (short)395223969;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1003880448;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2059730944;
				if (num != 0)
				{
				}
				num = (short)760545281;
				if (num != 0)
				{
				}
				return this.radProfGeneralDisableCallAlertsNotification_A19572._HasDiffs;
			}
		}

		// Token: 0x1700310B RID: 12555
		// (get) Token: 0x06005EA1 RID: 24225 RVA: 0x0054FCC8 File Offset: 0x0054DEC8
		// (set) Token: 0x06005EA2 RID: 24226 RVA: 0x0054FD80 File Offset: 0x0054DF80
		public bool PermanentFrontDisplayBacklight_A22337Value
		{
			get
			{
				short num = (short)195100673;
				if (num != 0)
				{
				}
				num = (short)443023360;
				short num2 = num;
				num = (short)660433876;
				short num3 = num;
				num = (short)1024945108;
				switch (num3 == num)
				{
				}
				num = (short)36503552;
				if (num != 0)
				{
				}
				return this.permanentFrontDisplayBacklight_A22337.Value;
			}
			set
			{
				short num = (short)2104643620;
				short num2 = num;
				num = (short)63721508;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1631256576;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1259995136;
				if (num != 0)
				{
				}
				num = (short)1377239041;
				if (num != 0)
				{
				}
				this.permanentFrontDisplayBacklight_A22337.Value = value;
			}
		}

		// Token: 0x1700310C RID: 12556
		// (get) Token: 0x06005EA3 RID: 24227 RVA: 0x0054FE38 File Offset: 0x0054E038
		public global::AcpBusinessLayer.AcpField<bool> PermanentFrontDisplayBacklight_A22337
		{
			get
			{
				short num = (short)2065122315;
				short num2 = num;
				num = (short)1038107659;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1174208512;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1220870144;
				if (num != 0)
				{
				}
				num = (short)274595841;
				if (num != 0)
				{
				}
				return this.permanentFrontDisplayBacklight_A22337;
			}
		}

		// Token: 0x1700310D RID: 12557
		// (get) Token: 0x06005EA4 RID: 24228 RVA: 0x0054FEEC File Offset: 0x0054E0EC
		// (set) Token: 0x06005EA5 RID: 24229 RVA: 0x0054FFA4 File Offset: 0x0054E1A4
		public bool PermanentFrontDisplayBacklight_A22337_UIValue
		{
			get
			{
				short num = (short)1922352660;
				short num2 = num;
				num = (short)1418642964;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1390477312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)549650433;
				if (num != 0)
				{
				}
				num = (short)304742400;
				if (num != 0)
				{
				}
				return this.permanentFrontDisplayBacklight_A22337.Value;
			}
			set
			{
				short num = (short)1489189138;
				short num2 = num;
				num = (short)451229970;
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
				num = (short)1800404992;
				if (num != 0)
				{
				}
				num = (short)1722220545;
				if (num != 0)
				{
				}
				this.permanentFrontDisplayBacklight_A22337.Value = value;
			}
		}

		// Token: 0x1700310E RID: 12558
		// (get) Token: 0x06005EA6 RID: 24230 RVA: 0x0055005C File Offset: 0x0054E25C
		// (set) Token: 0x06005EA7 RID: 24231 RVA: 0x00550110 File Offset: 0x0054E310
		public bool PermanentFrontDisplayBacklight_A22337_Applicable
		{
			get
			{
				short num = (short)1394809142;
				short num2 = num;
				num = (short)800790838;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1618214912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)710344705;
				if (num != 0)
				{
				}
				num = (short)880541696;
				if (num != 0)
				{
				}
				return this.permanentFrontDisplayBacklight_A22337.Applicable;
			}
			set
			{
				short num = (short)1718183404;
				short num2 = num;
				num = (short)1433232876;
				switch (num2 == num)
				{
				default:
				{
					num = (short)936443904;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1736966145;
				if (num != 0)
				{
				}
				num = (short)1416167424;
				if (num != 0)
				{
				}
				this.permanentFrontDisplayBacklight_A22337.Applicable = value;
			}
		}

		// Token: 0x1700310F RID: 12559
		// (get) Token: 0x06005EA8 RID: 24232 RVA: 0x005501C4 File Offset: 0x0054E3C4
		// (set) Token: 0x06005EA9 RID: 24233 RVA: 0x00550278 File Offset: 0x0054E478
		public bool PermanentFrontDisplayBacklight_A22337_Valid
		{
			get
			{
				short num = (short)1034113787;
				short num2 = num;
				num = (short)1748587259;
				switch (num2 == num)
				{
				default:
				{
					num = (short)876740608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)882835457;
				if (num != 0)
				{
				}
				num = (short)1793458176;
				if (num != 0)
				{
				}
				return this.permanentFrontDisplayBacklight_A22337.Valid;
			}
			set
			{
				short num = (short)1799725594;
				short num2 = num;
				num = (short)2079760922;
				switch (num2 == num)
				{
				default:
				{
					num = (short)481820672;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)381681665;
				if (num != 0)
				{
				}
				num = (short)1502019584;
				if (num != 0)
				{
				}
				this.permanentFrontDisplayBacklight_A22337.Valid = value;
			}
		}

		// Token: 0x17003110 RID: 12560
		// (get) Token: 0x06005EAA RID: 24234 RVA: 0x0055032C File Offset: 0x0054E52C
		// (set) Token: 0x06005EAB RID: 24235 RVA: 0x005503E0 File Offset: 0x0054E5E0
		public bool PermanentFrontDisplayBacklight_A22337_Visible
		{
			get
			{
				short num = (short)1924122141;
				short num2 = num;
				num = (short)649446941;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1274675200;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)259784705;
				if (num != 0)
				{
				}
				num = (short)1870331904;
				if (num != 0)
				{
				}
				return this.permanentFrontDisplayBacklight_A22337.Visible;
			}
			set
			{
				short num = (short)238450470;
				short num2 = num;
				num = (short)1487042342;
				switch (num2 == num)
				{
				default:
				{
					num = (short)218955776;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)215482369;
				if (num != 0)
				{
				}
				num = (short)261750784;
				if (num != 0)
				{
				}
				this.permanentFrontDisplayBacklight_A22337.Visible = value;
			}
		}

		// Token: 0x17003111 RID: 12561
		// (get) Token: 0x06005EAC RID: 24236 RVA: 0x00550494 File Offset: 0x0054E694
		// (set) Token: 0x06005EAD RID: 24237 RVA: 0x00550548 File Offset: 0x0054E748
		public bool PermanentFrontDisplayBacklight_A22337_Editable
		{
			get
			{
				short num = (short)1439296598;
				short num2 = num;
				num = (short)179235926;
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
				num = (short)1213464577;
				if (num != 0)
				{
				}
				num = (short)485621760;
				if (num != 0)
				{
				}
				return this.permanentFrontDisplayBacklight_A22337.Editable;
			}
			set
			{
				short num = (short)533004289;
				if (num != 0)
				{
				}
				num = (short)1605697536;
				short num2 = num;
				num = (short)1707176079;
				short num3 = num;
				num = (short)249655439;
				switch (num3 == num)
				{
				}
				num = (short)689373184;
				if (num != 0)
				{
				}
				this.permanentFrontDisplayBacklight_A22337.Editable = value;
			}
		}

		// Token: 0x17003112 RID: 12562
		// (get) Token: 0x06005EAE RID: 24238 RVA: 0x005505FC File Offset: 0x0054E7FC
		internal string PermanentFrontDisplayBacklight_A22337_UILabel
		{
			get
			{
				short num = (short)337750090;
				short num2 = num;
				num = (short)1948952650;
				switch (num2 == num)
				{
				default:
				{
					num = (short)925827072;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1720647681;
				if (num != 0)
				{
				}
				num = (short)1037172736;
				if (num != 0)
				{
				}
				return this.permanentFrontDisplayBacklight_A22337.UIName;
			}
		}

		// Token: 0x17003113 RID: 12563
		// (get) Token: 0x06005EAF RID: 24239 RVA: 0x005506B0 File Offset: 0x0054E8B0
		// (set) Token: 0x06005EB0 RID: 24240 RVA: 0x00550764 File Offset: 0x0054E964
		internal bool PermanentFrontDisplayBacklight_A22337_HiddenStatic
		{
			get
			{
				short num = (short)1542255130;
				short num2 = num;
				num = (short)954987034;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1692598272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)158007296;
				if (num != 0)
				{
				}
				num = (short)1862926337;
				if (num != 0)
				{
				}
				return this.permanentFrontDisplayBacklight_A22337.HiddenStatic;
			}
			set
			{
				short num = (short)786652071;
				short num2 = num;
				num = (short)300178343;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1441857536;
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
				num = (short)78118912;
				if (num != 0)
				{
				}
				this.permanentFrontDisplayBacklight_A22337.HiddenStatic = value;
			}
		}

		// Token: 0x17003114 RID: 12564
		// (get) Token: 0x06005EB1 RID: 24241 RVA: 0x0055081C File Offset: 0x0054EA1C
		// (set) Token: 0x06005EB2 RID: 24242 RVA: 0x005508D0 File Offset: 0x0054EAD0
		internal bool PermanentFrontDisplayBacklight_A22337_HiddenDynamic
		{
			get
			{
				short num = (short)561989561;
				short num2 = num;
				num = (short)2125088697;
				switch (num2 == num)
				{
				default:
				{
					num = (short)763035648;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1615003649;
				if (num != 0)
				{
				}
				num = (short)302710784;
				if (num != 0)
				{
				}
				return this.permanentFrontDisplayBacklight_A22337.HiddenDynamic;
			}
			set
			{
				short num = (short)1677157545;
				short num2 = num;
				num = (short)1643013289;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1215037440;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2113339392;
				if (num != 0)
				{
				}
				num = (short)452591617;
				if (num != 0)
				{
				}
				this.permanentFrontDisplayBacklight_A22337.HiddenDynamic = value;
			}
		}

		// Token: 0x17003115 RID: 12565
		// (get) Token: 0x06005EB3 RID: 24243 RVA: 0x00550988 File Offset: 0x0054EB88
		public bool PermanentFrontDisplayBacklight_A22337_HasDiffs
		{
			get
			{
				short num = (short)438562206;
				short num2 = num;
				num = (short)21753246;
				switch (num2 == num)
				{
				default:
				{
					num = (short)131858432;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1915682817;
				if (num != 0)
				{
				}
				num = (short)24772608;
				if (num != 0)
				{
				}
				return this.permanentFrontDisplayBacklight_A22337._HasDiffs;
			}
		}

		// Token: 0x17003116 RID: 12566
		// (get) Token: 0x06005EB4 RID: 24244 RVA: 0x00550A40 File Offset: 0x0054EC40
		// (set) Token: 0x06005EB5 RID: 24245 RVA: 0x00550AF4 File Offset: 0x0054ECF4
		public bool RadProfPermanentTopDisplayBacklightValue
		{
			get
			{
				short num = (short)1575082248;
				short num2 = num;
				num = (short)911333640;
				switch (num2 == num)
				{
				default:
				{
					num = (short)128974848;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)65537;
				if (num != 0)
				{
				}
				num = (short)1351483392;
				if (num != 0)
				{
				}
				return this.radProfPermanentTopDisplayBacklight.Value;
			}
			set
			{
				short num = (short)1214864371;
				short num2 = num;
				num = (short)388062195;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1457782784;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)788594689;
				if (num != 0)
				{
				}
				num = (short)308936704;
				if (num != 0)
				{
				}
				this.radProfPermanentTopDisplayBacklight.Value = value;
			}
		}

		// Token: 0x17003117 RID: 12567
		// (get) Token: 0x06005EB6 RID: 24246 RVA: 0x00550BAC File Offset: 0x0054EDAC
		public global::AcpBusinessLayer.AcpField<bool> RadProfPermanentTopDisplayBacklight
		{
			get
			{
				short num = (short)284195441;
				short num2 = num;
				num = (short)133593713;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1391263744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)458686464;
				if (num != 0)
				{
				}
				num = (short)828375041;
				if (num != 0)
				{
				}
				return this.radProfPermanentTopDisplayBacklight;
			}
		}

		// Token: 0x17003118 RID: 12568
		// (get) Token: 0x06005EB7 RID: 24247 RVA: 0x00550C5C File Offset: 0x0054EE5C
		// (set) Token: 0x06005EB8 RID: 24248 RVA: 0x00550D10 File Offset: 0x0054EF10
		public bool RadProfPermanentTopDisplayBacklight_UIValue
		{
			get
			{
				short num = (short)480786670;
				short num2 = num;
				num = (short)1669871854;
				switch (num2 == num)
				{
				default:
				{
					num = (short)373358592;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)465502209;
				if (num != 0)
				{
				}
				num = (short)1538326528;
				if (num != 0)
				{
				}
				return this.radProfPermanentTopDisplayBacklight.Value;
			}
			set
			{
				short num = (short)779495973;
				short num2 = num;
				num = (short)1643325989;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1644101632;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2090532865;
				if (num != 0)
				{
				}
				num = (short)218693632;
				if (num != 0)
				{
				}
				this.radProfPermanentTopDisplayBacklight.Value = value;
			}
		}

		// Token: 0x17003119 RID: 12569
		// (get) Token: 0x06005EB9 RID: 24249 RVA: 0x00550DC8 File Offset: 0x0054EFC8
		// (set) Token: 0x06005EBA RID: 24250 RVA: 0x00550E7C File Offset: 0x0054F07C
		public bool RadProfPermanentTopDisplayBacklight_Applicable
		{
			get
			{
				short num = (short)114269370;
				short num2 = num;
				num = (short)2081987770;
				switch (num2 == num)
				{
				default:
				{
					num = (short)52494336;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)766967809;
				if (num != 0)
				{
				}
				num = (short)751894528;
				if (num != 0)
				{
				}
				return this.radProfPermanentTopDisplayBacklight.Applicable;
			}
			set
			{
				short num = (short)890141732;
				short num2 = num;
				num = (short)1350859812;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1941700608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)586809345;
				if (num != 0)
				{
				}
				num = (short)1005780992;
				if (num != 0)
				{
				}
				this.radProfPermanentTopDisplayBacklight.Applicable = value;
			}
		}

		// Token: 0x1700311A RID: 12570
		// (get) Token: 0x06005EBB RID: 24251 RVA: 0x00550F30 File Offset: 0x0054F130
		// (set) Token: 0x06005EBC RID: 24252 RVA: 0x00550FE4 File Offset: 0x0054F1E4
		public bool RadProfPermanentTopDisplayBacklight_Valid
		{
			get
			{
				short num = (short)1793523713;
				if (num != 0)
				{
				}
				num = (short)944963584;
				short num2 = num;
				num = (short)1241011982;
				short num3 = num;
				num = (short)1594251022;
				switch (num3 == num)
				{
				}
				num = (short)1693777920;
				if (num != 0)
				{
				}
				return this.radProfPermanentTopDisplayBacklight.Valid;
			}
			set
			{
				short num = (short)1069135935;
				short num2 = num;
				num = (short)1311750207;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1386938368;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)882769921;
				if (num != 0)
				{
				}
				num = (short)1549729792;
				if (num != 0)
				{
				}
				this.radProfPermanentTopDisplayBacklight.Valid = value;
			}
		}

		// Token: 0x1700311B RID: 12571
		// (get) Token: 0x06005EBD RID: 24253 RVA: 0x00551098 File Offset: 0x0054F298
		// (set) Token: 0x06005EBE RID: 24254 RVA: 0x0055114C File Offset: 0x0054F34C
		public bool RadProfPermanentTopDisplayBacklight_Visible
		{
			get
			{
				short num = (short)1389676074;
				short num2 = num;
				num = (short)1685243434;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1721958400;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1769472001;
				if (num != 0)
				{
				}
				num = (short)302841856;
				if (num != 0)
				{
				}
				return this.radProfPermanentTopDisplayBacklight.Visible;
			}
			set
			{
				short num = (short)423729222;
				short num2 = num;
				num = (short)2025363526;
				switch (num2 == num)
				{
				default:
				{
					num = (short)954662912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1590624257;
				if (num != 0)
				{
				}
				num = (short)65470464;
				if (num != 0)
				{
				}
				this.radProfPermanentTopDisplayBacklight.Visible = value;
			}
		}

		// Token: 0x1700311C RID: 12572
		// (get) Token: 0x06005EBF RID: 24255 RVA: 0x00551200 File Offset: 0x0054F400
		// (set) Token: 0x06005EC0 RID: 24256 RVA: 0x005512B4 File Offset: 0x0054F4B4
		public bool RadProfPermanentTopDisplayBacklight_Editable
		{
			get
			{
				short num = (short)1274010997;
				short num2 = num;
				num = (short)2048974197;
				switch (num2 == num)
				{
				}
				num = (short)2131165185;
				if (num != 0)
				{
				}
				num = (short)93454336;
				short num3 = num;
				num = (short)1543831552;
				if (num != 0)
				{
				}
				return this.radProfPermanentTopDisplayBacklight.Editable;
			}
			set
			{
				short num = (short)1440632976;
				short num2 = num;
				num = (short)1290686608;
				switch (num2 == num)
				{
				}
				num = (short)1779695617;
				if (num != 0)
				{
				}
				num = (short)969408512;
				short num3 = num;
				num = (short)1658847232;
				if (num != 0)
				{
				}
				this.radProfPermanentTopDisplayBacklight.Editable = value;
			}
		}

		// Token: 0x1700311D RID: 12573
		// (get) Token: 0x06005EC1 RID: 24257 RVA: 0x0055136C File Offset: 0x0054F56C
		internal string RadProfPermanentTopDisplayBacklight_UILabel
		{
			get
			{
				short num = (short)2110619902;
				short num2 = num;
				num = (short)2146664702;
				switch (num2 == num)
				{
				}
				num = (short)1610285057;
				if (num != 0)
				{
				}
				num = (short)51052544;
				short num3 = num;
				num = (short)841154560;
				if (num != 0)
				{
				}
				return this.radProfPermanentTopDisplayBacklight.UIName;
			}
		}

		// Token: 0x1700311E RID: 12574
		// (get) Token: 0x06005EC2 RID: 24258 RVA: 0x00551420 File Offset: 0x0054F620
		// (set) Token: 0x06005EC3 RID: 24259 RVA: 0x005514D8 File Offset: 0x0054F6D8
		internal bool RadProfPermanentTopDisplayBacklight_HiddenStatic
		{
			get
			{
				short num = (short)151676223;
				short num2 = num;
				num = (short)286352703;
				switch (num2 == num)
				{
				}
				num = (short)1307246593;
				if (num != 0)
				{
				}
				num = (short)1801519104;
				short num3 = num;
				num = (short)852819968;
				if (num != 0)
				{
				}
				return this.radProfPermanentTopDisplayBacklight.HiddenStatic;
			}
			set
			{
				short num = (short)1854866135;
				short num2 = num;
				num = (short)156893911;
				switch (num2 == num)
				{
				}
				num = (short)482344960;
				if (num != 0)
				{
				}
				num = (short)1457586176;
				short num3 = num;
				num = (short)504954881;
				if (num != 0)
				{
				}
				this.radProfPermanentTopDisplayBacklight.HiddenStatic = value;
			}
		}

		// Token: 0x1700311F RID: 12575
		// (get) Token: 0x06005EC4 RID: 24260 RVA: 0x0055158C File Offset: 0x0054F78C
		// (set) Token: 0x06005EC5 RID: 24261 RVA: 0x00551644 File Offset: 0x0054F844
		internal bool RadProfPermanentTopDisplayBacklight_HiddenDynamic
		{
			get
			{
				short num = (short)1364952438;
				short num2 = num;
				num = (short)197690742;
				switch (num2 == num)
				{
				}
				num = (short)1394802688;
				if (num != 0)
				{
				}
				num = (short)868614144;
				short num3 = num;
				num = (short)1356922881;
				if (num != 0)
				{
				}
				return this.radProfPermanentTopDisplayBacklight.HiddenDynamic;
			}
			set
			{
				short num = (short)895102279;
				short num2 = num;
				num = (short)1975790919;
				switch (num2 == num)
				{
				}
				num = (short)577437696;
				if (num != 0)
				{
				}
				num = (short)1022820352;
				short num3 = num;
				num = (short)287506433;
				if (num != 0)
				{
				}
				this.radProfPermanentTopDisplayBacklight.HiddenDynamic = value;
			}
		}

		// Token: 0x17003120 RID: 12576
		// (get) Token: 0x06005EC6 RID: 24262 RVA: 0x005516FC File Offset: 0x0054F8FC
		public bool RadProfPermanentTopDisplayBacklight_HasDiffs
		{
			get
			{
				short num = (short)301949196;
				short num2 = num;
				num = (short)1561813260;
				switch (num2 == num)
				{
				}
				num = (short)38600705;
				if (num != 0)
				{
				}
				num = (short)1849688064;
				short num3 = num;
				num = (short)750780416;
				if (num != 0)
				{
				}
				return this.radProfPermanentTopDisplayBacklight._HasDiffs;
			}
		}

		// Token: 0x17003121 RID: 12577
		// (get) Token: 0x06005EC7 RID: 24263 RVA: 0x005517B0 File Offset: 0x0054F9B0
		// (set) Token: 0x06005EC8 RID: 24264 RVA: 0x00551868 File Offset: 0x0054FA68
		public bool RadProfPermanentDisableTxRxLED_A41609Value
		{
			get
			{
				short num = (short)620556402;
				short num2 = num;
				num = (short)1273229426;
				switch (num2 == num)
				{
				}
				num = (short)958529537;
				if (num != 0)
				{
				}
				num = (short)1298530304;
				short num3 = num;
				num = (short)1415643136;
				if (num != 0)
				{
				}
				return this.radProfPermanentDisableTxRxLED_A41609.Value;
			}
			set
			{
				short num = (short)707804842;
				short num2 = num;
				num = (short)1295990442;
				switch (num2 == num)
				{
				}
				num = (short)37224449;
				if (num != 0)
				{
				}
				num = (short)736690176;
				short num3 = num;
				num = (short)545325056;
				if (num != 0)
				{
				}
				this.radProfPermanentDisableTxRxLED_A41609.Value = value;
			}
		}

		// Token: 0x17003122 RID: 12578
		// (get) Token: 0x06005EC9 RID: 24265 RVA: 0x0055191C File Offset: 0x0054FB1C
		public global::AcpBusinessLayer.AcpField<bool> RadProfPermanentDisableTxRxLED_A41609
		{
			get
			{
				short num = (short)992054600;
				short num2 = num;
				num = (short)1310494024;
				switch (num2 == num)
				{
				}
				num = (short)164888577;
				if (num != 0)
				{
				}
				num = (short)942866432;
				short num3 = num;
				num = (short)1014300672;
				if (num != 0)
				{
				}
				return this.radProfPermanentDisableTxRxLED_A41609;
			}
		}

		// Token: 0x17003123 RID: 12579
		// (get) Token: 0x06005ECA RID: 24266 RVA: 0x005519CC File Offset: 0x0054FBCC
		// (set) Token: 0x06005ECB RID: 24267 RVA: 0x00551A80 File Offset: 0x0054FC80
		public bool RadProfPermanentDisableTxRxLED_A41609_UIValue
		{
			get
			{
				short num = (short)1213380513;
				short num2 = num;
				num = (short)680048545;
				switch (num2 == num)
				{
				}
				num = (short)8388608;
				if (num != 0)
				{
				}
				num = (short)1581252608;
				short num3 = num;
				num = (short)447741953;
				if (num != 0)
				{
				}
				return this.radProfPermanentDisableTxRxLED_A41609.Value;
			}
			set
			{
				short num = (short)842006529;
				if (num != 0)
				{
				}
				num = (short)1186820628;
				short num2 = num;
				num = (short)526479892;
				switch (num2 == num)
				{
				}
				num = (short)1457651712;
				short num3 = num;
				num = (short)2134769664;
				if (num != 0)
				{
				}
				this.radProfPermanentDisableTxRxLED_A41609.Value = value;
			}
		}

		// Token: 0x17003124 RID: 12580
		// (get) Token: 0x06005ECC RID: 24268 RVA: 0x00551B38 File Offset: 0x0054FD38
		// (set) Token: 0x06005ECD RID: 24269 RVA: 0x00551BEC File Offset: 0x0054FDEC
		public bool RadProfPermanentDisableTxRxLED_A41609_Applicable
		{
			get
			{
				short num = (short)599118153;
				short num2 = num;
				num = (short)979947849;
				switch (num2 == num)
				{
				}
				num = (short)1696202753;
				if (num != 0)
				{
				}
				num = (short)1701904384;
				short num3 = num;
				num = (short)1485766656;
				if (num != 0)
				{
				}
				return this.radProfPermanentDisableTxRxLED_A41609.Applicable;
			}
			set
			{
				short num = (short)2072082862;
				short num2 = num;
				num = (short)1735227822;
				switch (num2 == num)
				{
				}
				num = (short)240713729;
				if (num != 0)
				{
				}
				num = (short)1283457024;
				short num3 = num;
				num = (short)376111104;
				if (num != 0)
				{
				}
				this.radProfPermanentDisableTxRxLED_A41609.Applicable = value;
			}
		}

		// Token: 0x17003125 RID: 12581
		// (get) Token: 0x06005ECE RID: 24270 RVA: 0x00551CA0 File Offset: 0x0054FEA0
		// (set) Token: 0x06005ECF RID: 24271 RVA: 0x00551D54 File Offset: 0x0054FF54
		public bool RadProfPermanentDisableTxRxLED_A41609_Valid
		{
			get
			{
				short num = (short)1483145217;
				if (num != 0)
				{
				}
				num = (short)1398325750;
				short num2 = num;
				num = (short)1020969462;
				switch (num2 == num)
				{
				}
				num = (short)127795200;
				short num3 = num;
				num = (short)1841627136;
				if (num != 0)
				{
				}
				return this.radProfPermanentDisableTxRxLED_A41609.Valid;
			}
			set
			{
				short num = (short)1961588168;
				short num2 = num;
				num = (short)281441736;
				switch (num2 == num)
				{
				}
				num = (short)784793601;
				if (num != 0)
				{
				}
				num = (short)1670578176;
				short num3 = num;
				num = (short)1194262528;
				if (num != 0)
				{
				}
				this.radProfPermanentDisableTxRxLED_A41609.Valid = value;
			}
		}

		// Token: 0x17003126 RID: 12582
		// (get) Token: 0x06005ED0 RID: 24272 RVA: 0x00551E08 File Offset: 0x00550008
		// (set) Token: 0x06005ED1 RID: 24273 RVA: 0x00551EBC File Offset: 0x005500BC
		public bool RadProfPermanentDisableTxRxLED_A41609_Visible
		{
			get
			{
				short num = (short)1788691229;
				short num2 = num;
				num = (short)1811235613;
				switch (num2 == num)
				{
				}
				num = (short)1994260481;
				if (num != 0)
				{
				}
				num = (short)1442906112;
				short num3 = num;
				num = (short)1803747328;
				if (num != 0)
				{
				}
				return this.radProfPermanentDisableTxRxLED_A41609.Visible;
			}
			set
			{
				short num = (short)941395997;
				short num2 = num;
				num = (short)805670941;
				switch (num2 == num)
				{
				}
				num = (short)2094202881;
				if (num != 0)
				{
				}
				num = (short)1844969472;
				short num3 = num;
				num = (short)1246494720;
				if (num != 0)
				{
				}
				this.radProfPermanentDisableTxRxLED_A41609.Visible = value;
			}
		}

		// Token: 0x17003127 RID: 12583
		// (get) Token: 0x06005ED2 RID: 24274 RVA: 0x00551F70 File Offset: 0x00550170
		// (set) Token: 0x06005ED3 RID: 24275 RVA: 0x0055202C File Offset: 0x0055022C
		public bool RadProfPermanentDisableTxRxLED_A41609_Editable
		{
			get
			{
				short num = (short)1389146748;
				short num2 = num;
				num = (short)295285372;
				switch (num2 == num)
				{
				}
				num = (short)620298241;
				if (num != 0)
				{
				}
				num = (short)365559808;
				short num3 = num;
				num = (short)902103040;
				if (num != 0)
				{
				}
				return this.radProfPermanentDisableTxRxLED_A41609.Editable;
			}
			set
			{
				short num = (short)1353522176;
				short num2 = num;
				num = (short)1427446784;
				switch (num2 == num)
				{
				}
				num = (short)858456065;
				if (num != 0)
				{
				}
				num = (short)1920729088;
				short num3 = num;
				num = (short)307953664;
				if (num != 0)
				{
				}
				this.radProfPermanentDisableTxRxLED_A41609.Editable = value;
			}
		}

		// Token: 0x17003128 RID: 12584
		// (get) Token: 0x06005ED4 RID: 24276 RVA: 0x005520E0 File Offset: 0x005502E0
		internal string RadProfPermanentDisableTxRxLED_A41609_UILabel
		{
			get
			{
				short num = (short)383234897;
				short num2 = num;
				num = (short)913421137;
				switch (num2 == num)
				{
				}
				num = (short)1313603585;
				if (num != 0)
				{
				}
				num = (short)800522240;
				short num3 = num;
				num = (short)1328021504;
				if (num != 0)
				{
				}
				return this.radProfPermanentDisableTxRxLED_A41609.UIName;
			}
		}

		// Token: 0x17003129 RID: 12585
		// (get) Token: 0x06005ED5 RID: 24277 RVA: 0x00552194 File Offset: 0x00550394
		// (set) Token: 0x06005ED6 RID: 24278 RVA: 0x00552248 File Offset: 0x00550448
		internal bool RadProfPermanentDisableTxRxLED_A41609_HiddenStatic
		{
			get
			{
				short num = (short)1389247566;
				short num2 = num;
				num = (short)2062892110;
				switch (num2 == num)
				{
				}
				num = (short)1041498113;
				if (num != 0)
				{
				}
				num = (short)1602879488;
				short num3 = num;
				num = (short)322306048;
				if (num != 0)
				{
				}
				return this.radProfPermanentDisableTxRxLED_A41609.HiddenStatic;
			}
			set
			{
				short num = (short)264963341;
				short num2 = num;
				num = (short)182977805;
				switch (num2 == num)
				{
				}
				num = (short)7536640;
				if (num != 0)
				{
				}
				num = (short)1294729216;
				short num3 = num;
				num = (short)2124218369;
				if (num != 0)
				{
				}
				this.radProfPermanentDisableTxRxLED_A41609.HiddenStatic = value;
			}
		}

		// Token: 0x1700312A RID: 12586
		// (get) Token: 0x06005ED7 RID: 24279 RVA: 0x005522FC File Offset: 0x005504FC
		// (set) Token: 0x06005ED8 RID: 24280 RVA: 0x005523B0 File Offset: 0x005505B0
		internal bool RadProfPermanentDisableTxRxLED_A41609_HiddenDynamic
		{
			get
			{
				short num = (short)1612072877;
				short num2 = num;
				num = (short)51791789;
				switch (num2 == num)
				{
				}
				num = (short)1869414401;
				if (num != 0)
				{
				}
				num = (short)554369024;
				short num3 = num;
				num = (short)584318976;
				if (num != 0)
				{
				}
				return this.radProfPermanentDisableTxRxLED_A41609.HiddenDynamic;
			}
			set
			{
				short num = (short)951975937;
				if (num != 0)
				{
				}
				num = (short)834466147;
				short num2 = num;
				num = (short)1277620579;
				switch (num2 == num)
				{
				}
				num = (short)246743040;
				short num3 = num;
				num = (short)778960896;
				if (num != 0)
				{
				}
				this.radProfPermanentDisableTxRxLED_A41609.HiddenDynamic = value;
			}
		}

		// Token: 0x1700312B RID: 12587
		// (get) Token: 0x06005ED9 RID: 24281 RVA: 0x00552464 File Offset: 0x00550664
		public bool RadProfPermanentDisableTxRxLED_A41609_HasDiffs
		{
			get
			{
				short num = (short)83302197;
				short num2 = num;
				num = (short)1626609461;
				switch (num2 == num)
				{
				}
				num = (short)1022951425;
				if (num != 0)
				{
				}
				num = (short)1695416320;
				short num3 = num;
				num = (short)1863712768;
				if (num != 0)
				{
				}
				return this.radProfPermanentDisableTxRxLED_A41609._HasDiffs;
			}
		}

		// Token: 0x1700312C RID: 12588
		// (get) Token: 0x06005EDA RID: 24282 RVA: 0x0055251C File Offset: 0x0055071C
		// (set) Token: 0x06005EDB RID: 24283 RVA: 0x005525D0 File Offset: 0x005507D0
		public bool RadProfileSelectNoiseSensingVolumeControlValue
		{
			get
			{
				short num = (short)920394213;
				short num2 = num;
				num = (short)689773029;
				switch (num2 == num)
				{
				}
				num = (short)275709953;
				if (num != 0)
				{
				}
				num = (short)1190002688;
				short num3 = num;
				num = (short)1025441792;
				if (num != 0)
				{
				}
				return this.radProfileSelectNoiseSensingVolumeControl.Value;
			}
			set
			{
				short num = (short)660744538;
				short num2 = num;
				num = (short)798042458;
				switch (num2 == num)
				{
				}
				num = (short)1257439233;
				if (num != 0)
				{
				}
				num = (short)776863744;
				short num3 = num;
				num = (short)643104768;
				if (num != 0)
				{
				}
				this.radProfileSelectNoiseSensingVolumeControl.Value = value;
			}
		}

		// Token: 0x1700312D RID: 12589
		// (get) Token: 0x06005EDC RID: 24284 RVA: 0x00552688 File Offset: 0x00550888
		public global::AcpBusinessLayer.AcpField<bool> RadProfileSelectNoiseSensingVolumeControl
		{
			get
			{
				short num = (short)1416805614;
				short num2 = num;
				num = (short)1351597294;
				switch (num2 == num)
				{
				}
				num = (short)1061158913;
				if (num != 0)
				{
				}
				num = (short)509280256;
				short num3 = num;
				num = (short)480378880;
				if (num != 0)
				{
				}
				return this.radProfileSelectNoiseSensingVolumeControl;
			}
		}

		// Token: 0x1700312E RID: 12590
		// (get) Token: 0x06005EDD RID: 24285 RVA: 0x00552738 File Offset: 0x00550938
		// (set) Token: 0x06005EDE RID: 24286 RVA: 0x005527EC File Offset: 0x005509EC
		public bool RadProfileSelectNoiseSensingVolumeControl_UIValue
		{
			get
			{
				short num = (short)795066920;
				short num2 = num;
				num = (short)2078786088;
				switch (num2 == num)
				{
				}
				num = (short)1616576513;
				if (num != 0)
				{
				}
				num = (short)1728643072;
				short num3 = num;
				num = (short)1653800960;
				if (num != 0)
				{
				}
				return this.radProfileSelectNoiseSensingVolumeControl.Value;
			}
			set
			{
				short num = (short)78425516;
				short num2 = num;
				num = (short)789491116;
				switch (num2 == num)
				{
				}
				num = (short)443416576;
				if (num != 0)
				{
				}
				num = (short)1585840128;
				short num3 = num;
				num = (short)1817051137;
				if (num != 0)
				{
				}
				this.radProfileSelectNoiseSensingVolumeControl.Value = value;
			}
		}

		// Token: 0x1700312F RID: 12591
		// (get) Token: 0x06005EDF RID: 24287 RVA: 0x005528A0 File Offset: 0x00550AA0
		// (set) Token: 0x06005EE0 RID: 24288 RVA: 0x00552954 File Offset: 0x00550B54
		public bool RadProfileSelectNoiseSensingVolumeControl_Applicable
		{
			get
			{
				short num = (short)393412609;
				if (num != 0)
				{
				}
				num = (short)1507429585;
				short num2 = num;
				num = (short)531795153;
				switch (num2 == num)
				{
				}
				num = (short)249626624;
				short num3 = num;
				num = (short)2000551936;
				if (num != 0)
				{
				}
				return this.radProfileSelectNoiseSensingVolumeControl.Applicable;
			}
			set
			{
				short num = (short)317587457;
				if (num != 0)
				{
				}
				num = (short)1376651731;
				short num2 = num;
				num = (short)939854291;
				switch (num2 == num)
				{
				}
				num = (short)637206528;
				short num3 = num;
				num = (short)2106982400;
				if (num != 0)
				{
				}
				this.radProfileSelectNoiseSensingVolumeControl.Applicable = value;
			}
		}

		// Token: 0x17003130 RID: 12592
		// (get) Token: 0x06005EE1 RID: 24289 RVA: 0x00552A0C File Offset: 0x00550C0C
		// (set) Token: 0x06005EE2 RID: 24290 RVA: 0x00552AC0 File Offset: 0x00550CC0
		public bool RadProfileSelectNoiseSensingVolumeControl_Valid
		{
			get
			{
				short num = (short)1311893672;
				short num2 = num;
				num = (short)1815144616;
				switch (num2 == num)
				{
				}
				num = (short)2021785600;
				if (num != 0)
				{
				}
				num = (short)192544768;
				short num3 = num;
				num = (short)1644363777;
				if (num != 0)
				{
				}
				return this.radProfileSelectNoiseSensingVolumeControl.Valid;
			}
			set
			{
				short num = (short)328869525;
				short num2 = num;
				num = (short)1215374997;
				switch (num2 == num)
				{
				}
				num = (short)1580204032;
				if (num != 0)
				{
				}
				num = (short)765526016;
				short num3 = num;
				num = (short)865468417;
				if (num != 0)
				{
				}
				this.radProfileSelectNoiseSensingVolumeControl.Valid = value;
			}
		}

		// Token: 0x17003131 RID: 12593
		// (get) Token: 0x06005EE3 RID: 24291 RVA: 0x00552B74 File Offset: 0x00550D74
		// (set) Token: 0x06005EE4 RID: 24292 RVA: 0x00552C2C File Offset: 0x00550E2C
		public bool RadProfileSelectNoiseSensingVolumeControl_Visible
		{
			get
			{
				short num = (short)1950182232;
				short num2 = num;
				num = (short)1299475288;
				switch (num2 == num)
				{
				}
				num = (short)1851326464;
				if (num != 0)
				{
				}
				num = (short)1736835072;
				short num3 = num;
				num = (short)1105920001;
				if (num != 0)
				{
				}
				return this.radProfileSelectNoiseSensingVolumeControl.Visible;
			}
			set
			{
				short num = (short)1252920144;
				short num2 = num;
				num = (short)1474169680;
				switch (num2 == num)
				{
				}
				num = (short)609812481;
				if (num != 0)
				{
				}
				num = (short)1838284800;
				short num3 = num;
				num = (short)1072824320;
				if (num != 0)
				{
				}
				this.radProfileSelectNoiseSensingVolumeControl.Visible = value;
			}
		}

		// Token: 0x17003132 RID: 12594
		// (get) Token: 0x06005EE5 RID: 24293 RVA: 0x00552CE4 File Offset: 0x00550EE4
		// (set) Token: 0x06005EE6 RID: 24294 RVA: 0x00552D9C File Offset: 0x00550F9C
		public bool RadProfileSelectNoiseSensingVolumeControl_Editable
		{
			get
			{
				short num = (short)1982768498;
				short num2 = num;
				num = (short)236103026;
				switch (num2 == num)
				{
				}
				num = (short)315031553;
				if (num != 0)
				{
				}
				num = (short)298188800;
				short num3 = num;
				num = (short)1217986560;
				if (num != 0)
				{
				}
				return this.radProfileSelectNoiseSensingVolumeControl.Editable;
			}
			set
			{
				short num = (short)1061055652;
				short num2 = num;
				num = (short)244542628;
				switch (num2 == num)
				{
				}
				num = (short)680656896;
				if (num != 0)
				{
				}
				num = (short)1528823808;
				short num3 = num;
				num = (short)1692336129;
				if (num != 0)
				{
				}
				this.radProfileSelectNoiseSensingVolumeControl.Editable = value;
			}
		}

		// Token: 0x17003133 RID: 12595
		// (get) Token: 0x06005EE7 RID: 24295 RVA: 0x00552E50 File Offset: 0x00551050
		internal string RadProfileSelectNoiseSensingVolumeControl_UILabel
		{
			get
			{
				short num = (short)2037853792;
				short num2 = num;
				num = (short)1661480544;
				switch (num2 == num)
				{
				}
				num = (short)1822031873;
				if (num != 0)
				{
				}
				num = (short)548864000;
				short num3 = num;
				num = (short)490536960;
				if (num != 0)
				{
				}
				return this.radProfileSelectNoiseSensingVolumeControl.UIName;
			}
		}

		// Token: 0x17003134 RID: 12596
		// (get) Token: 0x06005EE8 RID: 24296 RVA: 0x00552F04 File Offset: 0x00551104
		// (set) Token: 0x06005EE9 RID: 24297 RVA: 0x00552FB8 File Offset: 0x005511B8
		internal bool RadProfileSelectNoiseSensingVolumeControl_HiddenStatic
		{
			get
			{
				short num = (short)1268442797;
				short num2 = num;
				num = (short)976152237;
				switch (num2 == num)
				{
				}
				num = (short)1052377088;
				if (num != 0)
				{
				}
				num = (short)39845888;
				short num3 = num;
				num = (short)1121779713;
				if (num != 0)
				{
				}
				return this.radProfileSelectNoiseSensingVolumeControl.HiddenStatic;
			}
			set
			{
				short num = (short)389182518;
				short num2 = num;
				num = (short)1678013494;
				switch (num2 == num)
				{
				}
				num = (short)1426587649;
				if (num != 0)
				{
				}
				num = (short)1171783680;
				short num3 = num;
				num = (short)342753280;
				if (num != 0)
				{
				}
				this.radProfileSelectNoiseSensingVolumeControl.HiddenStatic = value;
			}
		}

		// Token: 0x17003135 RID: 12597
		// (get) Token: 0x06005EEA RID: 24298 RVA: 0x00553070 File Offset: 0x00551270
		// (set) Token: 0x06005EEB RID: 24299 RVA: 0x00553124 File Offset: 0x00551324
		internal bool RadProfileSelectNoiseSensingVolumeControl_HiddenDynamic
		{
			get
			{
				short num = (short)1506324212;
				short num2 = num;
				num = (short)1785442036;
				switch (num2 == num)
				{
				}
				num = (short)1609433089;
				if (num != 0)
				{
				}
				num = (short)1121845248;
				short num3 = num;
				num = (short)703725568;
				if (num != 0)
				{
				}
				return this.radProfileSelectNoiseSensingVolumeControl.HiddenDynamic;
			}
			set
			{
				short num = (short)96731137;
				if (num != 0)
				{
				}
				num = (short)1367952320;
				short num2 = num;
				num = (short)381635520;
				switch (num2 == num)
				{
				}
				num = (short)1323630592;
				short num3 = num;
				num = (short)662634496;
				if (num != 0)
				{
				}
				this.radProfileSelectNoiseSensingVolumeControl.HiddenDynamic = value;
			}
		}

		// Token: 0x17003136 RID: 12598
		// (get) Token: 0x06005EEC RID: 24300 RVA: 0x005531D8 File Offset: 0x005513D8
		public bool RadProfileSelectNoiseSensingVolumeControl_HasDiffs
		{
			get
			{
				short num = (short)1932239953;
				short num2 = num;
				num = (short)756261969;
				switch (num2 == num)
				{
				}
				num = (short)2077097985;
				if (num != 0)
				{
				}
				num = (short)255983616;
				short num3 = num;
				num = (short)927596544;
				if (num != 0)
				{
				}
				return this.radProfileSelectNoiseSensingVolumeControl._HasDiffs;
			}
		}

		// Token: 0x17003137 RID: 12599
		// (get) Token: 0x06005EED RID: 24301 RVA: 0x0055328C File Offset: 0x0055148C
		// (set) Token: 0x06005EEE RID: 24302 RVA: 0x0055333C File Offset: 0x0055153C
		public bool RadProfNVGEnable_A41615Value
		{
			get
			{
				short num = (short)418187356;
				short num2 = num;
				num = (short)801769564;
				switch (num2 == num)
				{
				}
				num = (short)1826947072;
				if (num != 0)
				{
				}
				num = (short)397344768;
				short num3 = num;
				num = (short)1192165377;
				if (num != 0)
				{
				}
				return this.radProfNVGEnable_A41615.Value;
			}
			set
			{
				short num = (short)1499162532;
				short num2 = num;
				num = (short)501639076;
				switch (num2 == num)
				{
				}
				num = (short)495845376;
				if (num != 0)
				{
				}
				num = (short)919207936;
				short num3 = num;
				num = (short)1873674241;
				if (num != 0)
				{
				}
				this.radProfNVGEnable_A41615.Value = value;
			}
		}

		// Token: 0x17003138 RID: 12600
		// (get) Token: 0x06005EEF RID: 24303 RVA: 0x005533F0 File Offset: 0x005515F0
		public global::AcpBusinessLayer.AcpField<bool> RadProfNVGEnable_A41615
		{
			get
			{
				short num = (short)282767478;
				short num2 = num;
				num = (short)1992011894;
				switch (num2 == num)
				{
				}
				num = (short)1358364673;
				if (num != 0)
				{
				}
				num = (short)1601765376;
				short num3 = num;
				num = (short)24772608;
				if (num != 0)
				{
				}
				return this.radProfNVGEnable_A41615;
			}
		}

		// Token: 0x17003139 RID: 12601
		// (get) Token: 0x06005EF0 RID: 24304 RVA: 0x005534A0 File Offset: 0x005516A0
		// (set) Token: 0x06005EF1 RID: 24305 RVA: 0x00553554 File Offset: 0x00551754
		public bool RadProfNVGEnable_A41615_UIValue
		{
			get
			{
				short num = (short)167828164;
				short num2 = num;
				num = (short)651156164;
				switch (num2 == num)
				{
				}
				num = (short)1702035457;
				if (num != 0)
				{
				}
				num = (short)910426112;
				short num3 = num;
				num = (short)293011456;
				if (num != 0)
				{
				}
				return this.radProfNVGEnable_A41615.Value;
			}
			set
			{
				short num = (short)1834157659;
				short num2 = num;
				num = (short)1824261723;
				switch (num2 == num)
				{
				}
				num = (short)310116352;
				if (num != 0)
				{
				}
				num = (short)228065280;
				short num3 = num;
				num = (short)1646723073;
				if (num != 0)
				{
				}
				this.radProfNVGEnable_A41615.Value = value;
			}
		}

		// Token: 0x1700313A RID: 12602
		// (get) Token: 0x06005EF2 RID: 24306 RVA: 0x00553610 File Offset: 0x00551810
		// (set) Token: 0x06005EF3 RID: 24307 RVA: 0x005536C4 File Offset: 0x005518C4
		public bool RadProfNVGEnable_A41615_Applicable
		{
			get
			{
				short num = (short)377820144;
				short num2 = num;
				num = (short)687018992;
				switch (num2 == num)
				{
				}
				num = (short)413597696;
				if (num != 0)
				{
				}
				num = (short)395706368;
				short num3 = num;
				num = (short)190447617;
				if (num != 0)
				{
				}
				return this.radProfNVGEnable_A41615.Applicable;
			}
			set
			{
				short num = (short)1257580577;
				short num2 = num;
				num = (short)543828001;
				switch (num2 == num)
				{
				}
				num = (short)184745984;
				if (num != 0)
				{
				}
				num = (short)1845886976;
				short num3 = num;
				num = (short)1201012737;
				if (num != 0)
				{
				}
				this.radProfNVGEnable_A41615.Applicable = value;
			}
		}

		// Token: 0x1700313B RID: 12603
		// (get) Token: 0x06005EF4 RID: 24308 RVA: 0x0055377C File Offset: 0x0055197C
		// (set) Token: 0x06005EF5 RID: 24309 RVA: 0x00553830 File Offset: 0x00551A30
		public bool RadProfNVGEnable_A41615_Valid
		{
			get
			{
				short num = (short)846921729;
				if (num != 0)
				{
				}
				num = (short)1565266861;
				short num2 = num;
				num = (short)652743597;
				switch (num2 == num)
				{
				}
				num = (short)107282432;
				short num3 = num;
				num = (short)1796341760;
				if (num != 0)
				{
				}
				return this.radProfNVGEnable_A41615.Valid;
			}
			set
			{
				short num = (short)1819311173;
				short num2 = num;
				num = (short)124746821;
				switch (num2 == num)
				{
				}
				num = (short)1889927169;
				if (num != 0)
				{
				}
				num = (short)56295424;
				short num3 = num;
				num = (short)1971519488;
				if (num != 0)
				{
				}
				this.radProfNVGEnable_A41615.Valid = value;
			}
		}

		// Token: 0x1700313C RID: 12604
		// (get) Token: 0x06005EF6 RID: 24310 RVA: 0x005538E4 File Offset: 0x00551AE4
		// (set) Token: 0x06005EF7 RID: 24311 RVA: 0x0055399C File Offset: 0x00551B9C
		public bool RadProfNVGEnable_A41615_Visible
		{
			get
			{
				short num = (short)680853505;
				if (num != 0)
				{
				}
				num = (short)399714851;
				short num2 = num;
				num = (short)134031907;
				switch (num2 == num)
				{
				}
				num = (short)1983512576;
				short num3 = num;
				num = (short)916389888;
				if (num != 0)
				{
				}
				return this.radProfNVGEnable_A41615.Visible;
			}
			set
			{
				short num = (short)1316099138;
				short num2 = num;
				num = (short)1832129602;
				switch (num2 == num)
				{
				}
				num = (short)302579713;
				if (num != 0)
				{
				}
				num = (short)2018050048;
				short num3 = num;
				num = (short)781778944;
				if (num != 0)
				{
				}
				this.radProfNVGEnable_A41615.Visible = value;
			}
		}

		// Token: 0x1700313D RID: 12605
		// (get) Token: 0x06005EF8 RID: 24312 RVA: 0x00553A50 File Offset: 0x00551C50
		// (set) Token: 0x06005EF9 RID: 24313 RVA: 0x00553B04 File Offset: 0x00551D04
		public bool RadProfNVGEnable_A41615_Editable
		{
			get
			{
				short num = (short)1474984945;
				short num2 = num;
				num = (short)102202353;
				switch (num2 == num)
				{
				}
				num = (short)585564160;
				if (num != 0)
				{
				}
				num = (short)2092564480;
				short num3 = num;
				num = (short)1009123329;
				if (num != 0)
				{
				}
				return this.radProfNVGEnable_A41615.Editable;
			}
			set
			{
				short num = (short)1071455633;
				short num2 = num;
				num = (short)676863377;
				switch (num2 == num)
				{
				}
				num = (short)8257536;
				if (num != 0)
				{
				}
				num = (short)288686080;
				short num3 = num;
				num = (short)1445199873;
				if (num != 0)
				{
				}
				this.radProfNVGEnable_A41615.Editable = value;
			}
		}

		// Token: 0x1700313E RID: 12606
		// (get) Token: 0x06005EFA RID: 24314 RVA: 0x00553BBC File Offset: 0x00551DBC
		internal string RadProfNVGEnable_A41615_UILabel
		{
			get
			{
				short num = (short)1181618547;
				short num2 = num;
				num = (short)1370886515;
				switch (num2 == num)
				{
				}
				num = (short)1837563904;
				if (num != 0)
				{
				}
				num = (short)1417281536;
				short num3 = num;
				num = (short)1921318913;
				if (num != 0)
				{
				}
				return this.radProfNVGEnable_A41615.UIName;
			}
		}

		// Token: 0x1700313F RID: 12607
		// (get) Token: 0x06005EFB RID: 24315 RVA: 0x00553C70 File Offset: 0x00551E70
		// (set) Token: 0x06005EFC RID: 24316 RVA: 0x00553D28 File Offset: 0x00551F28
		internal bool RadProfNVGEnable_A41615_HiddenStatic
		{
			get
			{
				short num = (short)938503744;
				short num2 = num;
				num = (short)1629187648;
				switch (num2 == num)
				{
				}
				num = (short)2021720064;
				if (num != 0)
				{
				}
				num = (short)1322778624;
				short num3 = num;
				num = (short)1812398081;
				if (num != 0)
				{
				}
				return this.radProfNVGEnable_A41615.HiddenStatic;
			}
			set
			{
				short num = (short)1472598881;
				short num2 = num;
				num = (short)1866994529;
				switch (num2 == num)
				{
				}
				num = (short)235405312;
				if (num != 0)
				{
				}
				num = (short)954400768;
				short num3 = num;
				num = (short)247136257;
				if (num != 0)
				{
				}
				this.radProfNVGEnable_A41615.HiddenStatic = value;
			}
		}

		// Token: 0x17003140 RID: 12608
		// (get) Token: 0x06005EFD RID: 24317 RVA: 0x00553DDC File Offset: 0x00551FDC
		// (set) Token: 0x06005EFE RID: 24318 RVA: 0x00553E90 File Offset: 0x00552090
		internal bool RadProfNVGEnable_A41615_HiddenDynamic
		{
			get
			{
				short num = (short)1541027761;
				short num2 = num;
				num = (short)1737045937;
				switch (num2 == num)
				{
				}
				num = (short)632946689;
				if (num != 0)
				{
				}
				num = (short)1476067328;
				short num3 = num;
				num = (short)1159200768;
				if (num != 0)
				{
				}
				return this.radProfNVGEnable_A41615.HiddenDynamic;
			}
			set
			{
				short num = (short)92484484;
				short num2 = num;
				num = (short)1604727684;
				switch (num2 == num)
				{
				}
				num = (short)1321009152;
				if (num != 0)
				{
				}
				num = (short)1279459328;
				short num3 = num;
				num = (short)186908673;
				if (num != 0)
				{
				}
				this.radProfNVGEnable_A41615.HiddenDynamic = value;
			}
		}

		// Token: 0x17003141 RID: 12609
		// (get) Token: 0x06005EFF RID: 24319 RVA: 0x00553F44 File Offset: 0x00552144
		public bool RadProfNVGEnable_A41615_HasDiffs
		{
			get
			{
				short num = (short)190413953;
				short num2 = num;
				num = (short)2141551745;
				switch (num2 == num)
				{
				}
				num = (short)1248788480;
				if (num != 0)
				{
				}
				num = (short)37552128;
				short num3 = num;
				num = (short)50331649;
				if (num != 0)
				{
				}
				return this.radProfNVGEnable_A41615._HasDiffs;
			}
		}

		// Token: 0x17003142 RID: 12610
		// (get) Token: 0x06005F00 RID: 24320 RVA: 0x00553FF8 File Offset: 0x005521F8
		public global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.DisplayAndMenu RefDisplayAndMenu
		{
			get
			{
				short num = (short)901570459;
				short num2 = num;
				num = (short)102752155;
				switch (num2 == num)
				{
				}
				num = (short)856489985;
				if (num != 0)
				{
				}
				num = (short)744947712;
				short num3 = num;
				num = (short)2074345472;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2010)[0] as global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.DisplayAndMenu;
			}
		}

		// Token: 0x06005F01 RID: 24321 RVA: 0x005540B8 File Offset: 0x005522B8
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			int num;
			short num2;
			global::AcpCommonLib.IAcpRecordset result;
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
					{
						num2 = (short)63974096;
						short num3 = num2;
						num2 = (short)1072966352;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_26;
						default:
						{
							num2 = (short)1373634560;
							short num4 = num2;
							num2 = (short)2085683200;
							if (num2 != 0)
							{
							}
							num2 = (short)642646017;
							if (num2 != 0)
							{
							}
							if (base.ParentRecset.ContainerDoc != null)
							{
								num2 = (short)1317208068;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							return result;
						}
						}
						break;
					}
					case 1:
						return result;
					case 2:
						num2 = (short)322240512;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3:
						if (base.ParentRecset != null)
						{
							num2 = (short)583794690;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					case 4:
						result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
						num2 = (short)965017601;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_24;
				}
				return result;
			}
			IL_24:
			result = null;
			IL_26:
			num2 = (short)2142568451;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0400233B RID: 9019
		private global::AcpBusinessLayer.AcpField<bool> radProfGeneralDisableLights_A7866;

		// Token: 0x0400233C RID: 9020
		private global::AcpBusinessLayer.AcpField<bool> radProfGeneralDisableTones_A7870;

		// Token: 0x0400233D RID: 9021
		private global::AcpBusinessLayer.AcpKeyField radProfGeneralRadioProfileName_A19564;

		// Token: 0x0400233E RID: 9022
		private global::AcpBusinessLayer.AcpListField radProfGeneralSpeakerAudioRouting_A19566;

		// Token: 0x0400233F RID: 9023
		private global::AcpBusinessLayer.AcpField<bool> radProfGeneralDisableEmergencyAlertsNotification_A19570;

		// Token: 0x04002340 RID: 9024
		private global::AcpBusinessLayer.AcpField<bool> radProfGeneralDisableCriticalAlertsNotification_A19571;

		// Token: 0x04002341 RID: 9025
		private global::AcpBusinessLayer.AcpField<bool> radProfGeneralDisableCallAlertsNotification_A19572;

		// Token: 0x04002342 RID: 9026
		private global::AcpBusinessLayer.AcpField<bool> permanentFrontDisplayBacklight_A22337;

		// Token: 0x04002343 RID: 9027
		private global::AcpBusinessLayer.AcpField<bool> radProfPermanentTopDisplayBacklight;

		// Token: 0x04002344 RID: 9028
		private global::AcpBusinessLayer.AcpField<bool> radProfPermanentDisableTxRxLED_A41609;

		// Token: 0x04002345 RID: 9029
		private global::AcpBusinessLayer.AcpField<bool> radProfileSelectNoiseSensingVolumeControl;

		// Token: 0x04002346 RID: 9030
		private global::AcpBusinessLayer.AcpField<bool> radProfNVGEnable_A41615;
	}
}
