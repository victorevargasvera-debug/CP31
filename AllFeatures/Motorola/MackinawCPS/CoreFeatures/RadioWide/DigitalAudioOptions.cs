using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using Features.Converters;

namespace Motorola.MackinawCPS.CoreFeatures.RadioWide
{
	// Token: 0x0200016A RID: 362
	[global::System.Serializable]
	public class DigitalAudioOptions : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06002E2E RID: 11822 RVA: 0x002D98F0 File Offset: 0x002D7AF0
		public DigitalAudioOptions(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06002E2F RID: 11823 RVA: 0x002D990C File Offset: 0x002D7B0C
		protected DigitalAudioOptions(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			this.b(info, context);
		}

		// Token: 0x06002E30 RID: 11824 RVA: 0x002D992C File Offset: 0x002D7B2C
		public override void Init()
		{
			int a_ = 9;
			short num = (short)1032941180;
			short num2 = num;
			num = (short)1773039228;
			switch (num2 == num)
			{
			}
			num = (short)2130378753;
			if (num != 0)
			{
			}
			num = (short)958529536;
			if (num != 0)
			{
			}
			num = (short)347209728;
			short num3 = num;
			this.radWideAdvancedAuxPTTAudioSource_A7529 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("飉귋꫍蟏믑냓돕駗뻙ꫛ뿝軟臡臣若ꧧ鿩铫뻭ꓯ꛱뗳菵鳷鏹鏻귽濿省瘃攅洇唉䴋㤍┏‑ⴓ", a_), global::CommonResources.AcgResources.ID_AUXPTTAUDIOSOURCE, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideAdvancedAuxPTTAudioSource_A7529LovStrs);
			this.radWideAdvancedAuxPTTAudioSource_A7529.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.radWideAdvancedAuxPTTAudioSource_A7529.DataTransferOrder = 2;
			this.advancedAuxTransmitSensitivity_A7530 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("诉꣋룍뇏병럓돕볗鯙꧛ꛝ듟郡藣裥鯧蟩藫髭ꏯ韱髳藵釷軹闻製槿瘁紃夅䤇㴉㤋㴍‏", a_), global::CommonResources.AcgResources.ID_AUXTRANSMITSENSITIVITY, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.AdvancedAuxTransmitSensitivity_A7530LovStrs);
			this.advancedAuxTransmitSensitivity_A7530.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.advancedAuxTransmitSensitivity_A7530.DataTransferOrder = 121;
			this.radWideRxAudioControlMidrangeEqualization_A8508 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("飉귋꫍蟏믑냓돕諗ꋙ鷛ꯝ蓟诡诣ꗥ蟧蓩飫鳭鿯黱맳鿵鳷裹鷻都柿朁䄃眅紇欉怋服樏猑怓缕眗琙䌛弝᠟ᜡᐣḥ", a_), global::CommonResources.AcgResources.ID_RXMIDRANGEEQUALIZATION);
			this.radWideRxAudioControlMidrangeEqualization_A8508.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.radWideRxAudioControlMidrangeEqualization_A8508.DataTransferOrder = 84;
			this.radWideDigitalAudioOptionsStrongInterference2_A9206 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("飉귋꫍蟏믑냓돕鳗동믛럝铟菡裣꟥鷧軩藫臭뿯英胳鿵韷铹迻귽瓿瀁欃栅漇䌉戋稍甏怑爓猕樗缙爛紝䔟အ笣朥ᄧᠩᰫᠭ", a_), global::CommonResources.AcgResources.ID_DIGITALINBOUNDINDICATORSSTRONGINTERFERENCE);
			this.radWideDigitalAudioOptionsStrongInterference2_A9206.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radWideDigitalAudioOptionsStrongInterference2_A9206.DataTransferOrder = 38;
			this.radWideDigitalAudioOptionsStrongInterference1_A9207 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("飉귋꫍蟏믑냓돕鳗동믛럝铟菡裣꟥鷧軩藫臭뿯英胳鿵韷铹迻귽瓿瀁欃栅漇䌉戋稍甏怑爓猕樗缙爛紝䔟ጡ笣朥ᄧᠩᰫ᤭", a_), global::CommonResources.AcgResources.ID_DIGITALOUTBOUNDINDICATORSSTRONGINTERFERENCE);
			this.radWideDigitalAudioOptionsStrongInterference1_A9207.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radWideDigitalAudioOptionsStrongInterference1_A9207.DataTransferOrder = 39;
			this.radWideDigitalAudioOptionsWeakSignalFringe_A9678 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("飉귋꫍蟏믑냓돕鳗동믛럝铟菡裣꟥鷧軩藫臭뿯英胳鿵韷铹迻ꧽ旿持漃唅愇洉戋漍簏向易缕瘗紙礛䄝感ᬡሣᄥဧ", a_), global::CommonResources.AcgResources.ID_DIGITALINBOUNDINDICATORSWEAKSIGNALFRINGE);
			this.radWideDigitalAudioOptionsWeakSignalFringe_A9678.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radWideDigitalAudioOptionsWeakSignalFringe_A9678.DataTransferOrder = 44;
			this.radWideDigitalAudioOptionsWeakSignalFringe_A9679 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("飉귋꫍蟏믑냓돕鳗동믛럝铟菡裣꟥鷧軩藫臭뿯英胳鿵韷铹迻ꧽ旿持漃唅愇洉戋漍簏向易缕瘗紙礛䄝感ᬡሣᄥᄧ", a_), global::CommonResources.AcgResources.ID_DIGITALOUTBOUNDINDICATORSWEAKSIGNALFRINGE);
			this.radWideDigitalAudioOptionsWeakSignalFringe_A9679.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radWideDigitalAudioOptionsWeakSignalFringe_A9679.DataTransferOrder = 45;
			this.radWideLabtoolMultipleConversationDisable_A19552 = new global::AcpBusinessLayer.AcpFieldX<bool, bool>(true, new global::Features.Converters.UnpackAndPackAndInvertBooleanField(), this, global::AllFeatures.CodeplugGuid.b("飉귋꫍蟏믑냓돕铗믙뻛ꫝ迟跡裣ꯥ鷧蛩飫蟭胯黱釳뗵韷铹諻鯽狿焁攃爅愇攉戋䨍礏愑甓琕琗缙䌛弝ᄟᬡᄣጥᨧ", a_), global::CommonResources.AcgResources.ID_CONCURRENTRXENABLE);
			this.radWideLabtoolMultipleConversationDisable_A19552.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.radWideLabtoolMultipleConversationDisable_A19552.DataTransferOrder = 57;
			this.radWideLabtoolDigitalAnalogBalance_A7851 = new global::AcpBusinessLayer.AcpListField(2, this, global::AllFeatures.CodeplugGuid.b("飉귋꫍蟏믑냓돕铗믙뻛ꫝ迟跡裣ꋥ臧跩藫髭釯黱뗳飵駷雹鏻駽䋿持栃朅昇椉椋儍儏┑Ⱃ⌕⤗", a_), global::CommonResources.AcgResources.ID_TXDIGITALANALOGBALANCE, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideLabtoolDigitalAnalogBalance_A7851LovStrs);
			this.radWideLabtoolDigitalAnalogBalance_A7851.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.radWideLabtoolDigitalAnalogBalance_A7851.DataTransferOrder = 80;
			this.radWideAudioConfigurationLevel_42740 = new global::AcpBusinessLayer.AcpListField(1, this, global::AllFeatures.CodeplugGuid.b("飉귋꫍蟏믑냓돕駗꿙룛럝迟ꇡ诣裥軧菩诫鯭苯鏱胳鿵韷铹냻鯽盿朁栃夅㰇㠉㬋㨍‏", a_), global::CommonResources.AcgResources.ID_AUDIOCONFIGURATIONLEVEL, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideAudioConfigurationLevel_42740LovStrs);
			this.radWideAudioConfigurationLevel_42740.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.radWideAudioConfigurationLevel_42740.DataTransferOrder = 3;
			this.radWideCombineTxWithRxFilteredAudio_44808 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("飉귋꫍蟏믑냓돕鯗뗙뇛볝觟賡臣닥郧뷩藫髭飯ꃱ賳냵釷雹裻鯽狿朁怃䜅紇渉攋愍伏☑–⸕⠗∙", a_), global::CommonResources.AcgResources.ID_RADWIDECOMBINETXWITHRXFILTEREDAUDIO);
			this.radWideCombineTxWithRxFilteredAudio_44808.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radWideCombineTxWithRxFilteredAudio_44808.DataTransferOrder = 56;
			this.radWideAudioOptionsSelectBluetoothMicForAuxPTTAudioSource_44819 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("飉귋꫍蟏믑냓돕駗꿙룛럝迟귡铣鋥臧藩苫鷭ꏯ韱飳鏵鯷軹뻻鋽痿朁瀃椅朇縉搋䌍礏焑刓礕樗嬙椛昝瀟瘡瀣朥崧丩䔫䄭振崱䄳䐵嬷弹挻਽琿穁畃罅", a_), global::CommonResources.AcgResources.ID_SELECTBLUETOOTHMICFORAUXPTTAUDIOSOURCE);
			this.radWideAudioOptionsSelectBluetoothMicForAuxPTTAudioSource_44819.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.radWideAudioOptionsSelectBluetoothMicForAuxPTTAudioSource_44819.DataTransferOrder = 122;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("诉맋꫍맏뷑駕꣗껙뗛뇝軟釡", a_);
			base.Id = 10101;
			base.UIName = global::CommonResources.AcgResources.ID_AUDIOOPTIONS;
			base.DataTransferOrder = 2;
		}

		// Token: 0x06002E31 RID: 11825 RVA: 0x002D9CD4 File Offset: 0x002D7ED4
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 4;
			short num = (short)1114636300;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)356450330;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_F6;
				case 2:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("韄ꛆ귈鳊꓌ꯎ듐臒귔雖곘뿚드냞ꋠ賢诤鏦鯨蓪臬ꋮ飰韲蟴零韸鳺飼뫾瀀瘂搄欆怈焊氌笎砐簒笔䠖堘⌚⠜⼞ᤠ", a_)))
					{
						num = (short)1788149790;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_840;
				case 3:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("韄ꛆ귈鳊꓌ꯎ듐郒뫔뫖믘닚돜뫞뗠鯢다軦鷨菪뿬韮런髲駴菶鳸觺飼鯾䀀瘂愄渆昈吊㤌㬎⤐⌒ⴔ", a_)))
					{
						num = (short)571736069;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2F9;
				case 4:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("韄ꛆ귈鳊꓌ꯎ듐鋒뇔ꇖ룘뗚뻜뫞藠ꋢ郤鿦맨뿪맬껮蓰韲鳴飶꫸铺裼跾戀昂娄䘆㸈㸊㼌㘎", a_)))
					{
						num = (short)1833041928;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_58E;
				case 5:
					this.radWideCombineTxWithRxFilteredAudio_44808 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("韄ꛆ귈鳊꓌ꯎ듐郒뫔뫖믘닚돜뫞뗠鯢다軦鷨菪뿬韮런髲駴菶鳸觺飼鯾䀀瘂愄渆昈吊㤌㬎⤐⌒ⴔ", a_), global::CommonResources.AcgResources.ID_RADWIDECOMBINETXWITHRXFILTEREDAUDIO);
					this.radWideCombineTxWithRxFilteredAudio_44808.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radWideCombineTxWithRxFilteredAudio_44808.DataTransferOrder = 56;
					num = (short)289144857;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					num = (short)421986308;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("韄ꛆ귈鳊꓌ꯎ듐韒볔냖냘꿚볜돞ꃠ離臤軦蛨ꓪ鷬鯮飰鳲鯴蓶껸黺鳼链刀樂戄椆栈朊䬌紎砐紒爔爖䘘娚␜⤞ᘠᨢ", a_)))
					{
						num = (short)1681981467;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_7F1;
				case 8:
					this.radWideAdvancedAuxPTTAudioSource_A7529 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("韄ꛆ귈鳊꓌ꯎ듐鋒뇔ꇖ룘뗚뻜뫞藠ꋢ郤鿦맨뿪맬껮蓰韲鳴飶꫸铺裼跾戀昂娄䘆㸈㸊㼌㘎", a_), global::CommonResources.AcgResources.ID_AUXPTTAUDIOSOURCE, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideAdvancedAuxPTTAudioSource_A7529LovStrs);
					this.radWideAdvancedAuxPTTAudioSource_A7529.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.radWideAdvancedAuxPTTAudioSource_A7529.DataTransferOrder = 2;
					num = (short)497811472;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					this.radWideAudioConfigurationLevel_42740 = new global::AcpBusinessLayer.AcpListField(1, this, global::AllFeatures.CodeplugGuid.b("韄ꛆ귈鳊꓌ꯎ듐鋒ꃔ돖냘듚黜냞迠藢賤胦鳨駪賬鯮飰鳲鯴믶鳸跺飼鏾帀㜂㜄〆㴈㬊", a_), global::CommonResources.AcgResources.ID_AUDIOCONFIGURATIONLEVEL, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideAudioConfigurationLevel_42740LovStrs);
					this.radWideAudioConfigurationLevel_42740.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.radWideAudioConfigurationLevel_42740.DataTransferOrder = 3;
					num = (short)338100235;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					this.radWideAudioOptionsSelectBluetoothMicForAuxPTTAudioSource_44819 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("韄ꛆ귈鳊꓌ꯎ듐鋒ꃔ돖냘듚鋜꿞闠諢諤触髨룪裬菮铰郲致뗶闸軺飼课渀氂焄漆䐈戊渌䤎縐愒吔或愘䬚䤜䬞怠嘢䄤並䘨砪䈬娮䌰倲倴栶സ༺Լ฾础", a_), global::CommonResources.AcgResources.ID_SELECTBLUETOOTHMICFORAUXPTTAUDIOSOURCE);
					this.radWideAudioOptionsSelectBluetoothMicForAuxPTTAudioSource_44819.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.radWideAudioOptionsSelectBluetoothMicForAuxPTTAudioSource_44819.DataTransferOrder = 122;
					num = (short)1950744591;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					goto IL_3F0;
				case 12:
					switch (0)
					{
					case 0:
						goto IL_CF;
					}
					continue;
				case 13:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("韄ꛆ귈鳊꓌ꯎ듐鿒듔뗖귘듚닜돞ꗠ諢苤軦鷨諪臬껮鿰鋲駴飶黸맺鳼鏾怀洂昄戆嘈䨊㨌㜎␐−", a_)))
					{
						num = (short)1861419037;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_8DA;
				case 14:
					goto IL_4BA;
				case 15:
					goto IL_48D;
				case 16:
					goto IL_58E;
				case 17:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("韄ꛆ귈鳊꓌ꯎ듐鋒ꃔ돖냘듚黜냞迠藢賤胦鳨駪賬鯮飰鳲鯴믶鳸跺飼鏾帀㜂㜄〆㴈㬊", a_)))
					{
						num = (short)2135621641;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3F0;
				case 18:
					this.radWideDigitalAudioOptionsWeakSignalFringe_A9678 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("韄ꛆ귈鳊꓌ꯎ듐韒볔냖냘꿚볜돞ꃠ離臤軦蛨ꓪ鷬鯮飰鳲鯴蓶껸黺鳼链刀樂戄椆栈朊䬌紎砐紒爔爖䘘娚␜⤞ᘠᬢ", a_), global::CommonResources.AcgResources.ID_DIGITALINBOUNDINDICATORSWEAKSIGNALFRINGE);
					this.radWideDigitalAudioOptionsWeakSignalFringe_A9678.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radWideDigitalAudioOptionsWeakSignalFringe_A9678.DataTransferOrder = 44;
					num = (short)607322136;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 19:
				{
					num = (short)1472428379;
					short num3 = num;
					num = (short)1476753755;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_D9;
					default:
						num = (short)165806080;
						if (num != 0)
						{
						}
						if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("韄ꛆ귈鳊꓌ꯎ듐韒볔냖냘꿚볜돞ꃠ離臤軦蛨ꓪ鷬鯮飰鳲鯴蓶껸黺鳼链刀樂戄椆栈朊䬌紎砐紒爔爖䘘娚␜⤞ᘠᬢ", a_)))
						{
							num = (short)670236690;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_143;
					}
					break;
				}
				case 20:
					this.radWideDigitalAudioOptionsStrongInterference1_A9207 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("韄ꛆ귈鳊꓌ꯎ듐韒볔냖냘꿚볜돞ꃠ離臤軦蛨ꓪ鷬鯮飰鳲鯴蓶꫸迺迼郾漀搂䰄椆紈渊缌椎琐愒瀔礖稘縚Ⱌ䀞怠ᨢᜤᜦḨ", a_), global::CommonResources.AcgResources.ID_DIGITALOUTBOUNDINDICATORSSTRONGINTERFERENCE);
					this.radWideDigitalAudioOptionsStrongInterference1_A9207.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radWideDigitalAudioOptionsStrongInterference1_A9207.DataTransferOrder = 39;
					num = (short)1334575136;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 21:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("韄ꛆ귈鳊꓌ꯎ듐韒볔냖냘꿚볜돞ꃠ離臤軦蛨ꓪ鷬鯮飰鳲鯴蓶꫸迺迼郾漀搂䰄椆紈渊缌椎琐愒瀔礖稘縚Ⱌ䀞怠ᨢᜤᜦḨ", a_)))
					{
						num = (short)747241492;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_759;
				case 22:
					goto IL_7F1;
				case 23:
					this.radWideDigitalAudioOptionsStrongInterference2_A9206 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("韄ꛆ귈鳊꓌ꯎ듐韒볔냖냘꿚볜돞ꃠ離臤軦蛨ꓪ鷬鯮飰鳲鯴蓶꫸迺迼郾漀搂䰄椆紈渊缌椎琐愒瀔礖稘縚⼜䀞怠ᨢᜤᜦἨ", a_), global::CommonResources.AcgResources.ID_DIGITALINBOUNDINDICATORSSTRONGINTERFERENCE);
					this.radWideDigitalAudioOptionsStrongInterference2_A9206.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radWideDigitalAudioOptionsStrongInterference2_A9206.DataTransferOrder = 38;
					num = (short)985726990;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 24:
					goto IL_143;
				case 25:
					goto IL_2F9;
				case 26:
					if (producerFields != null)
					{
						num = (short)878247942;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_97D;
				case 27:
					this.radWideDigitalAudioOptionsWeakSignalFringe_A9679 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("韄ꛆ귈鳊꓌ꯎ듐韒볔냖냘꿚볜돞ꃠ離臤軦蛨ꓪ鷬鯮飰鳲鯴蓶껸黺鳼链刀樂戄椆栈朊䬌紎砐紒爔爖䘘娚␜⤞ᘠᨢ", a_), global::CommonResources.AcgResources.ID_DIGITALOUTBOUNDINDICATORSWEAKSIGNALFRINGE);
					this.radWideDigitalAudioOptionsWeakSignalFringe_A9679.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radWideDigitalAudioOptionsWeakSignalFringe_A9679.DataTransferOrder = 45;
					num = (short)977731606;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 28:
					goto IL_840;
				case 29:
					this.radWideLabtoolDigitalAnalogBalance_A7851 = new global::AcpBusinessLayer.AcpListField(2, this, global::AllFeatures.CodeplugGuid.b("韄ꛆ귈鳊꓌ꯎ듐鿒듔뗖귘듚닜돞ꗠ諢苤軦鷨諪臬껮鿰鋲駴飶黸맺鳼鏾怀洂昄戆嘈䨊㨌㜎␐−", a_), global::CommonResources.AcgResources.ID_TXDIGITALANALOGBALANCE, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideLabtoolDigitalAnalogBalance_A7851LovStrs);
					this.radWideLabtoolDigitalAnalogBalance_A7851.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.radWideLabtoolDigitalAnalogBalance_A7851.DataTransferOrder = 80;
					num = (short)2058485797;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 30:
					this.radWideRxAudioControlMidrangeEqualization_A8508 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("韄ꛆ귈鳊꓌ꯎ듐臒귔雖곘뿚드냞ꋠ賢诤鏦鯨蓪臬ꋮ飰韲蟴零韸鳺飼뫾瀀瘂搄欆怈焊氌笎砐簒笔䠖堘⌚⠜⼞ᤠ", a_), global::CommonResources.AcgResources.ID_RXMIDRANGEEQUALIZATION);
					this.radWideRxAudioControlMidrangeEqualization_A8508.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.radWideRxAudioControlMidrangeEqualization_A8508.DataTransferOrder = 84;
					num = (short)1520238620;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 31:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蓄ꏆ뿈꫊ꏌ곎듐럒铔ꋖꇘ迚꿜뻞迠郢裤軦鷨룪裬臮苰髲致黶迸鋺觼蛾帀䈂㈄㈆㨈㬊", a_)))
					{
						num = (short)1866072103;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_541;
				case 32:
					goto IL_759;
				case 33:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("韄ꛆ귈鳊꓌ꯎ듐鋒ꃔ돖냘듚鋜꿞闠諢諤触髨룪裬菮铰郲致뗶闸軺飼课渀氂焄漆䐈戊渌䤎縐愒吔或愘䬚䤜䬞怠嘢䄤並䘨砪䈬娮䌰倲倴栶സ༺Լ฾础", a_)))
					{
						num = (short)1537212426;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_97D;
				case 34:
					this.radWideLabtoolMultipleConversationDisable_A19552 = new global::AcpBusinessLayer.AcpFieldX<bool, bool>(true, new global::Features.Converters.UnpackAndPackAndInvertBooleanField(), this, global::AllFeatures.CodeplugGuid.b("韄ꛆ귈鳊꓌ꯎ듐鿒듔뗖귘듚닜돞고離觤鏦胨鯪臬諮닰鳲鯴臶鳸觺軼黾甀樂樄椆䴈戊縌渎猐缒瀔䠖堘⨚␜⨞ᐠᄢ", a_), global::CommonResources.AcgResources.ID_CONCURRENTRXENABLE);
					this.radWideLabtoolMultipleConversationDisable_A19552.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.radWideLabtoolMultipleConversationDisable_A19552.DataTransferOrder = 57;
					num = (short)43581441;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 35:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("韄ꛆ귈鳊꓌ꯎ듐韒볔냖냘꿚볜돞ꃠ離臤軦蛨ꓪ鷬鯮飰鳲鯴蓶꫸迺迼郾漀搂䰄椆紈渊缌椎琐愒瀔礖稘縚⼜䀞怠ᨢᜤᜦἨ", a_)))
					{
						num = (short)322109463;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4BA;
				case 36:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("韄ꛆ귈鳊꓌ꯎ듐鿒듔뗖귘듚닜돞고離觤鏦胨鯪臬諮닰鳲鯴臶鳸觺軼黾甀樂樄椆䴈戊縌渎猐缒瀔䠖堘⨚␜⨞ᐠᄢ", a_)))
					{
						num = (short)63242274;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_F6;
				case 37:
					num = (short)816971777;
					if (num != 0)
					{
					}
					goto IL_8DA;
				case 38:
					goto IL_541;
				case 39:
					this.advancedAuxTransmitSensitivity_A7530 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("蓄ꏆ뿈꫊ꏌ곎듐럒铔ꋖꇘ迚꿜뻞迠郢裤軦鷨룪裬臮苰髲致黶迸鋺觼蛾帀䈂㈄㈆㨈㬊", a_), global::CommonResources.AcgResources.ID_AUXTRANSMITSENSITIVITY, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.AdvancedAuxTransmitSensitivity_A7530LovStrs);
					this.advancedAuxTransmitSensitivity_A7530.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.advancedAuxTransmitSensitivity_A7530.DataTransferOrder = 121;
					num = (short)662306854;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_CF;
				IL_D9:
				num = (short)1550450688;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_CF:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					goto IL_D9;
				}
				goto IL_97D;
				IL_F6:
				num = (short)978452493;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_143:
				num = (short)1313800199;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2F9:
				num = (short)1918435361;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3F0:
				num = (short)1103364099;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_4BA:
				num = (short)1475870741;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_541:
				num = (short)226295810;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_58E:
				num = (short)1020657695;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_759:
				num = (short)411238419;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_7F1:
				num = (short)1997602852;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_840:
				num = (short)1299972131;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_8DA:
				num = (short)170000401;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_48D:
			num = (short)1022230528;
			short num4 = num;
			IL_97D:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("蓄닆귈ꋊꋌ黐ꏒꇔ뻖뛘뗚껜", a_);
			base.Id = 10101;
			base.UIName = global::CommonResources.AcgResources.ID_AUDIOOPTIONS;
			base.DataTransferOrder = 2;
		}

		// Token: 0x06002E32 RID: 11826 RVA: 0x002DA690 File Offset: 0x002D8890
		public override void PopulateReferences()
		{
			short num = (short)1922938239;
			short num2 = num;
			num = (short)1924707711;
			switch (num2 == num)
			{
			}
			num = (short)354615297;
			if (num != 0)
			{
			}
			num = (short)724959232;
			if (num != 0)
			{
			}
			num = (short)2006384640;
			short num3 = num;
		}

		// Token: 0x06002E33 RID: 11827 RVA: 0x002DA73C File Offset: 0x002D893C
		public override void DropReferences()
		{
			short num = (short)1240203265;
			if (num != 0)
			{
			}
			num = (short)1035754189;
			short num2 = num;
			num = (short)1901419213;
			switch (num2 == num)
			{
			}
			num = (short)1956249600;
			if (num != 0)
			{
			}
			num = (short)1567358976;
			short num3 = num;
		}

		// Token: 0x06002E34 RID: 11828 RVA: 0x002DA7E4 File Offset: 0x002D89E4
		public override void SetConstraints()
		{
			short num = (short)1409113977;
			short num2 = num;
			num = (short)449666937;
			switch (num2 == num)
			{
			}
			num = (short)259784705;
			if (num != 0)
			{
			}
			num = (short)1730281472;
			if (num != 0)
			{
			}
			num = (short)117702656;
			short num3 = num;
			this.advancedAuxTransmitSensitivity_A7530.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.conAuxPttAudioSrcIsAuxTxAndAuxTxSnstvtyIs300mvOrAuxPttAudioSrcIsAuxMic);
			this.radWideLabtoolDigitalAnalogBalance_A7851.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.conDigAnalogBalNoAGCChannelEnabled);
			this.radWideAudioConfigurationLevel_42740.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.conAudioConfigurationLevelValueSetter);
			this.radWideAudioOptionsSelectBluetoothMicForAuxPTTAudioSource_44819.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConSelectBluetoothMicForAuxPTTAudioSourceApplicable);
		}

		// Token: 0x06002E35 RID: 11829 RVA: 0x002DA8E8 File Offset: 0x002D8AE8
		public override void SetupDependencies()
		{
			short num = (short)1323654887;
			short num2 = num;
			num = (short)296705767;
			switch (num2 == num)
			{
			}
			num = (short)1753153537;
			if (num != 0)
			{
			}
			num = (short)1565327360;
			if (num != 0)
			{
			}
			num = (short)917372928;
			short num3 = num;
			this.radWideAdvancedAuxPTTAudioSource_A7529.AddDependentObject(this.advancedAuxTransmitSensitivity_A7530);
		}

		// Token: 0x17001701 RID: 5889
		// (get) Token: 0x06002E36 RID: 11830 RVA: 0x002DA9A4 File Offset: 0x002D8BA4
		public bool HasDiffs
		{
			get
			{
				short num = (short)1620486913;
				short num2 = num;
				num = (short)214477569;
				switch (num2 == num)
				{
				}
				num = (short)1683292160;
				if (num != 0)
				{
				}
				num = (short)1865940993;
				if (num != 0)
				{
				}
				num = (short)1231093760;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x17001702 RID: 5890
		// (get) Token: 0x06002E37 RID: 11831 RVA: 0x002DAA54 File Offset: 0x002D8C54
		// (set) Token: 0x06002E38 RID: 11832 RVA: 0x002DAB08 File Offset: 0x002D8D08
		public int RadWideAdvancedAuxPTTAudioSource_A7529Value
		{
			get
			{
				short num = (short)809500673;
				if (num != 0)
				{
				}
				num = (short)245661199;
				short num2 = num;
				num = (short)1178631695;
				switch (num2 == num)
				{
				}
				num = (short)485556224;
				if (num != 0)
				{
				}
				num = (short)703987712;
				short num3 = num;
				return this.radWideAdvancedAuxPTTAudioSource_A7529.Value;
			}
			set
			{
				short num = (short)103197143;
				short num2 = num;
				num = (short)1345300951;
				switch (num2 == num)
				{
				}
				num = (short)1428750336;
				if (num != 0)
				{
				}
				num = (short)83361793;
				if (num != 0)
				{
				}
				num = (short)648937472;
				short num3 = num;
				this.radWideAdvancedAuxPTTAudioSource_A7529.Value = value;
			}
		}

		// Token: 0x17001703 RID: 5891
		// (get) Token: 0x06002E39 RID: 11833 RVA: 0x002DABBC File Offset: 0x002D8DBC
		// (set) Token: 0x06002E3A RID: 11834 RVA: 0x002DAC70 File Offset: 0x002D8E70
		public string RadWideAdvancedAuxPTTAudioSource_A7529_UIValue
		{
			get
			{
				short num = (short)2037149765;
				short num2 = num;
				num = (short)1955426373;
				switch (num2 == num)
				{
				}
				num = (short)1555824641;
				if (num != 0)
				{
				}
				num = (short)1220542464;
				if (num != 0)
				{
				}
				num = (short)1099628544;
				short num3 = num;
				return this.radWideAdvancedAuxPTTAudioSource_A7529.UIValue;
			}
			set
			{
				short num = (short)1852645390;
				short num2 = num;
				num = (short)1563959310;
				switch (num2 == num)
				{
				}
				num = (short)1498415105;
				if (num != 0)
				{
				}
				num = (short)970063872;
				if (num != 0)
				{
				}
				num = (short)176947200;
				short num3 = num;
				this.radWideAdvancedAuxPTTAudioSource_A7529.UIValue = value;
			}
		}

		// Token: 0x17001704 RID: 5892
		// (get) Token: 0x06002E3B RID: 11835 RVA: 0x002DAD24 File Offset: 0x002D8F24
		public global::AcpBusinessLayer.AcpListField RadWideAdvancedAuxPTTAudioSource_A7529
		{
			get
			{
				short num = (short)515714755;
				short num2 = num;
				num = (short)517811907;
				switch (num2 == num)
				{
				}
				num = (short)1829371905;
				if (num != 0)
				{
				}
				num = (short)1961361408;
				if (num != 0)
				{
				}
				num = (short)994312192;
				short num3 = num;
				return this.radWideAdvancedAuxPTTAudioSource_A7529;
			}
		}

		// Token: 0x17001705 RID: 5893
		// (get) Token: 0x06002E3C RID: 11836 RVA: 0x002DADD4 File Offset: 0x002D8FD4
		// (set) Token: 0x06002E3D RID: 11837 RVA: 0x002DAE84 File Offset: 0x002D9084
		public bool RadWideAdvancedAuxPTTAudioSource_A7529_Applicable
		{
			get
			{
				short num = (short)1726428250;
				short num2 = num;
				num = (short)735786074;
				switch (num2 == num)
				{
				}
				num = (short)1556545537;
				if (num != 0)
				{
				}
				num = (short)1229783040;
				if (num != 0)
				{
				}
				num = (short)1703673856;
				short num3 = num;
				return this.radWideAdvancedAuxPTTAudioSource_A7529.Applicable;
			}
			set
			{
				short num = (short)368526563;
				short num2 = num;
				num = (short)2107458787;
				switch (num2 == num)
				{
				}
				num = (short)124321793;
				if (num != 0)
				{
				}
				num = (short)937033728;
				if (num != 0)
				{
				}
				num = (short)525139968;
				short num3 = num;
				this.radWideAdvancedAuxPTTAudioSource_A7529.Applicable = value;
			}
		}

		// Token: 0x17001706 RID: 5894
		// (get) Token: 0x06002E3E RID: 11838 RVA: 0x002DAF3C File Offset: 0x002D913C
		// (set) Token: 0x06002E3F RID: 11839 RVA: 0x002DAFF4 File Offset: 0x002D91F4
		public bool RadWideAdvancedAuxPTTAudioSource_A7529_Valid
		{
			get
			{
				short num = (short)1741619201;
				if (num != 0)
				{
				}
				num = (short)1374241815;
				short num2 = num;
				num = (short)961823767;
				switch (num2 == num)
				{
				}
				num = (short)919339008;
				if (num != 0)
				{
				}
				num = (short)558759936;
				short num3 = num;
				return this.radWideAdvancedAuxPTTAudioSource_A7529.Valid;
			}
			set
			{
				short num = (short)1814108605;
				short num2 = num;
				num = (short)619518397;
				switch (num2 == num)
				{
				}
				num = (short)757530624;
				if (num != 0)
				{
				}
				num = (short)456523777;
				if (num != 0)
				{
				}
				num = (short)1510670336;
				short num3 = num;
				this.radWideAdvancedAuxPTTAudioSource_A7529.Valid = value;
			}
		}

		// Token: 0x17001707 RID: 5895
		// (get) Token: 0x06002E40 RID: 11840 RVA: 0x002DB0A8 File Offset: 0x002D92A8
		// (set) Token: 0x06002E41 RID: 11841 RVA: 0x002DB15C File Offset: 0x002D935C
		public bool RadWideAdvancedAuxPTTAudioSource_A7529_Visible
		{
			get
			{
				short num = (short)941811871;
				short num2 = num;
				num = (short)87550111;
				switch (num2 == num)
				{
				}
				num = (short)812646401;
				if (num != 0)
				{
				}
				num = (short)1527775232;
				if (num != 0)
				{
				}
				num = (short)1530724352;
				short num3 = num;
				return this.radWideAdvancedAuxPTTAudioSource_A7529.Visible;
			}
			set
			{
				short num = (short)716256322;
				short num2 = num;
				num = (short)959198274;
				switch (num2 == num)
				{
				}
				num = (short)1247346689;
				if (num != 0)
				{
				}
				num = (short)321060864;
				if (num != 0)
				{
				}
				num = (short)399507456;
				short num3 = num;
				this.radWideAdvancedAuxPTTAudioSource_A7529.Visible = value;
			}
		}

		// Token: 0x17001708 RID: 5896
		// (get) Token: 0x06002E42 RID: 11842 RVA: 0x002DB214 File Offset: 0x002D9414
		// (set) Token: 0x06002E43 RID: 11843 RVA: 0x002DB2C8 File Offset: 0x002D94C8
		public bool RadWideAdvancedAuxPTTAudioSource_A7529_Editable
		{
			get
			{
				short num = (short)841512432;
				short num2 = num;
				num = (short)1460041200;
				switch (num2 == num)
				{
				}
				num = (short)1988427777;
				if (num != 0)
				{
				}
				num = (short)260440064;
				if (num != 0)
				{
				}
				num = (short)1842610176;
				short num3 = num;
				return this.radWideAdvancedAuxPTTAudioSource_A7529.Editable;
			}
			set
			{
				short num = (short)1926083497;
				short num2 = num;
				num = (short)1456583593;
				switch (num2 == num)
				{
				}
				num = (short)1020854273;
				if (num != 0)
				{
				}
				num = (short)1449459712;
				if (num != 0)
				{
				}
				num = (short)1690566656;
				short num3 = num;
				this.radWideAdvancedAuxPTTAudioSource_A7529.Editable = value;
			}
		}

		// Token: 0x17001709 RID: 5897
		// (get) Token: 0x06002E44 RID: 11844 RVA: 0x002DB380 File Offset: 0x002D9580
		internal string RadWideAdvancedAuxPTTAudioSource_A7529_UILabel
		{
			get
			{
				short num = (short)1339908151;
				short num2 = num;
				num = (short)857235511;
				switch (num2 == num)
				{
				}
				num = (short)2146697217;
				if (num != 0)
				{
				}
				num = (short)1568210944;
				if (num != 0)
				{
				}
				num = (short)1896153088;
				short num3 = num;
				return this.radWideAdvancedAuxPTTAudioSource_A7529.UIName;
			}
		}

		// Token: 0x1700170A RID: 5898
		// (get) Token: 0x06002E45 RID: 11845 RVA: 0x002DB438 File Offset: 0x002D9638
		// (set) Token: 0x06002E46 RID: 11846 RVA: 0x002DB4EC File Offset: 0x002D96EC
		internal bool RadWideAdvancedAuxPTTAudioSource_A7529_HiddenStatic
		{
			get
			{
				short num = (short)1475487261;
				short num2 = num;
				num = (short)2062886429;
				switch (num2 == num)
				{
				}
				num = (short)1285160961;
				if (num != 0)
				{
				}
				num = (short)499122176;
				if (num != 0)
				{
				}
				num = (short)1613365248;
				short num3 = num;
				return this.radWideAdvancedAuxPTTAudioSource_A7529.HiddenStatic;
			}
			set
			{
				short num = (short)1735691315;
				short num2 = num;
				num = (short)1024494643;
				switch (num2 == num)
				{
				}
				num = (short)38600704;
				if (num != 0)
				{
				}
				num = (short)1402863617;
				if (num != 0)
				{
				}
				num = (short)720109568;
				short num3 = num;
				this.radWideAdvancedAuxPTTAudioSource_A7529.HiddenStatic = value;
			}
		}

		// Token: 0x1700170B RID: 5899
		// (get) Token: 0x06002E47 RID: 11847 RVA: 0x002DB5A0 File Offset: 0x002D97A0
		// (set) Token: 0x06002E48 RID: 11848 RVA: 0x002DB654 File Offset: 0x002D9854
		internal bool RadWideAdvancedAuxPTTAudioSource_A7529_HiddenDynamic
		{
			get
			{
				short num = (short)1067812326;
				short num2 = num;
				num = (short)117999078;
				switch (num2 == num)
				{
				}
				num = (short)1112276993;
				if (num != 0)
				{
				}
				num = (short)714932224;
				if (num != 0)
				{
				}
				num = (short)1628372992;
				short num3 = num;
				return this.radWideAdvancedAuxPTTAudioSource_A7529.HiddenDynamic;
			}
			set
			{
				short num = (short)241498073;
				short num2 = num;
				num = (short)1898444761;
				switch (num2 == num)
				{
				}
				num = (short)1486815232;
				if (num != 0)
				{
				}
				num = (short)1349386241;
				if (num != 0)
				{
				}
				num = (short)2041643008;
				short num3 = num;
				this.radWideAdvancedAuxPTTAudioSource_A7529.HiddenDynamic = value;
			}
		}

		// Token: 0x1700170C RID: 5900
		// (get) Token: 0x06002E49 RID: 11849 RVA: 0x002DB708 File Offset: 0x002D9908
		public bool RadWideAdvancedAuxPTTAudioSource_A7529_HasDiffs
		{
			get
			{
				short num = (short)133627905;
				if (num != 0)
				{
				}
				num = (short)2054023300;
				short num2 = num;
				num = (short)1180952708;
				switch (num2 == num)
				{
				}
				num = (short)1406926848;
				if (num != 0)
				{
				}
				num = (short)2058616832;
				short num3 = num;
				return this.radWideAdvancedAuxPTTAudioSource_A7529._HasDiffs;
			}
		}

		// Token: 0x1700170D RID: 5901
		// (get) Token: 0x06002E4A RID: 11850 RVA: 0x002DB7BC File Offset: 0x002D99BC
		// (set) Token: 0x06002E4B RID: 11851 RVA: 0x002DB870 File Offset: 0x002D9A70
		public int AdvancedAuxTransmitSensitivity_A7530Value
		{
			get
			{
				short num = (short)2110573908;
				short num2 = num;
				num = (short)1114361172;
				switch (num2 == num)
				{
				}
				num = (short)3276800;
				if (num != 0)
				{
				}
				num = (short)2113732609;
				if (num != 0)
				{
				}
				num = (short)1019215872;
				short num3 = num;
				return this.advancedAuxTransmitSensitivity_A7530.Value;
			}
			set
			{
				short num = (short)303300609;
				if (num != 0)
				{
				}
				num = (short)1119511492;
				short num2 = num;
				num = (short)1531274180;
				switch (num2 == num)
				{
				}
				num = (short)1750532096;
				if (num != 0)
				{
				}
				num = (short)2143289344;
				short num3 = num;
				this.advancedAuxTransmitSensitivity_A7530.Value = value;
			}
		}

		// Token: 0x1700170E RID: 5902
		// (get) Token: 0x06002E4C RID: 11852 RVA: 0x002DB928 File Offset: 0x002D9B28
		// (set) Token: 0x06002E4D RID: 11853 RVA: 0x002DB9DC File Offset: 0x002D9BDC
		public string AdvancedAuxTransmitSensitivity_A7530_UIValue
		{
			get
			{
				short num = (short)843029623;
				short num2 = num;
				num = (short)1748999287;
				switch (num2 == num)
				{
				}
				num = (short)384696320;
				if (num != 0)
				{
				}
				num = (short)112852993;
				if (num != 0)
				{
				}
				num = (short)1688403968;
				short num3 = num;
				return this.advancedAuxTransmitSensitivity_A7530.UIValue;
			}
			set
			{
				short num = (short)744229460;
				short num2 = num;
				num = (short)738462292;
				switch (num2 == num)
				{
				}
				num = (short)822345728;
				if (num != 0)
				{
				}
				num = (short)432930817;
				if (num != 0)
				{
				}
				num = (short)1193607168;
				short num3 = num;
				this.advancedAuxTransmitSensitivity_A7530.UIValue = value;
			}
		}

		// Token: 0x1700170F RID: 5903
		// (get) Token: 0x06002E4E RID: 11854 RVA: 0x002DBA90 File Offset: 0x002D9C90
		public global::AcpBusinessLayer.AcpListField AdvancedAuxTransmitSensitivity_A7530
		{
			get
			{
				short num = (short)8359136;
				short num2 = num;
				num = (short)1779862752;
				switch (num2 == num)
				{
				}
				num = (short)2144403457;
				if (num != 0)
				{
				}
				num = (short)831782912;
				if (num != 0)
				{
				}
				num = (short)1733099520;
				short num3 = num;
				return this.advancedAuxTransmitSensitivity_A7530;
			}
		}

		// Token: 0x17001710 RID: 5904
		// (get) Token: 0x06002E4F RID: 11855 RVA: 0x002DBB40 File Offset: 0x002D9D40
		// (set) Token: 0x06002E50 RID: 11856 RVA: 0x002DBBF8 File Offset: 0x002D9DF8
		public bool AdvancedAuxTransmitSensitivity_A7530_Applicable
		{
			get
			{
				short num = (short)1387116529;
				short num2 = num;
				num = (short)1016248305;
				switch (num2 == num)
				{
				}
				num = (short)930086913;
				if (num != 0)
				{
				}
				num = (short)65339392;
				if (num != 0)
				{
				}
				num = (short)1045495808;
				short num3 = num;
				return this.advancedAuxTransmitSensitivity_A7530.Applicable;
			}
			set
			{
				short num = (short)523496075;
				short num2 = num;
				num = (short)756083339;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2097676288;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1603141632;
				if (num != 0)
				{
				}
				num = (short)1008926721;
				if (num != 0)
				{
				}
				this.advancedAuxTransmitSensitivity_A7530.Applicable = value;
			}
		}

		// Token: 0x17001711 RID: 5905
		// (get) Token: 0x06002E51 RID: 11857 RVA: 0x002DBCAC File Offset: 0x002D9EAC
		// (set) Token: 0x06002E52 RID: 11858 RVA: 0x002DBD60 File Offset: 0x002D9F60
		public bool AdvancedAuxTransmitSensitivity_A7530_Valid
		{
			get
			{
				short num = (short)1553354574;
				short num2 = num;
				num = (short)1752649550;
				switch (num2 == num)
				{
				default:
				{
					num = (short)764542976;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1713504257;
				if (num != 0)
				{
				}
				num = (short)785580032;
				if (num != 0)
				{
				}
				return this.advancedAuxTransmitSensitivity_A7530.Valid;
			}
			set
			{
				short num = (short)1408192265;
				short num2 = num;
				num = (short)253906697;
				switch (num2 == num)
				{
				default:
				{
					num = (short)722796544;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)817758208;
				if (num != 0)
				{
				}
				num = (short)261357569;
				if (num != 0)
				{
				}
				this.advancedAuxTransmitSensitivity_A7530.Valid = value;
			}
		}

		// Token: 0x17001712 RID: 5906
		// (get) Token: 0x06002E53 RID: 11859 RVA: 0x002DBE14 File Offset: 0x002DA014
		// (set) Token: 0x06002E54 RID: 11860 RVA: 0x002DBEC8 File Offset: 0x002DA0C8
		public bool AdvancedAuxTransmitSensitivity_A7530_Visible
		{
			get
			{
				short num = (short)1810993478;
				short num2 = num;
				num = (short)746950982;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1119485952;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)745406465;
				if (num != 0)
				{
				}
				num = (short)1676738560;
				if (num != 0)
				{
				}
				return this.advancedAuxTransmitSensitivity_A7530.Visible;
			}
			set
			{
				short num = (short)1972399454;
				short num2 = num;
				num = (short)543583582;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1232928768;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1823408129;
				if (num != 0)
				{
				}
				num = (short)941555712;
				if (num != 0)
				{
				}
				this.advancedAuxTransmitSensitivity_A7530.Visible = value;
			}
		}

		// Token: 0x17001713 RID: 5907
		// (get) Token: 0x06002E55 RID: 11861 RVA: 0x002DBF7C File Offset: 0x002DA17C
		// (set) Token: 0x06002E56 RID: 11862 RVA: 0x002DC030 File Offset: 0x002DA230
		public bool AdvancedAuxTransmitSensitivity_A7530_Editable
		{
			get
			{
				short num = (short)1145099142;
				short num2 = num;
				num = (short)1288295302;
				switch (num2 == num)
				{
				default:
				{
					num = (short)222101504;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1277427713;
				if (num != 0)
				{
				}
				num = (short)2140078080;
				if (num != 0)
				{
				}
				return this.advancedAuxTransmitSensitivity_A7530.Editable;
			}
			set
			{
				short num = (short)1637597593;
				short num2 = num;
				num = (short)112574873;
				switch (num2 == num)
				{
				default:
				{
					num = (short)669712384;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)989921281;
				if (num != 0)
				{
				}
				num = (short)2101477376;
				if (num != 0)
				{
				}
				this.advancedAuxTransmitSensitivity_A7530.Editable = value;
			}
		}

		// Token: 0x17001714 RID: 5908
		// (get) Token: 0x06002E57 RID: 11863 RVA: 0x002DC0E4 File Offset: 0x002DA2E4
		internal string AdvancedAuxTransmitSensitivity_A7530_UILabel
		{
			get
			{
				short num = (short)270284332;
				short num2 = num;
				num = (short)1385707052;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1530527744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)239730689;
				if (num != 0)
				{
				}
				num = (short)2118975488;
				if (num != 0)
				{
				}
				return this.advancedAuxTransmitSensitivity_A7530.UIName;
			}
		}

		// Token: 0x17001715 RID: 5909
		// (get) Token: 0x06002E58 RID: 11864 RVA: 0x002DC19C File Offset: 0x002DA39C
		// (set) Token: 0x06002E59 RID: 11865 RVA: 0x002DC250 File Offset: 0x002DA450
		internal bool AdvancedAuxTransmitSensitivity_A7530_HiddenStatic
		{
			get
			{
				short num = (short)1964745021;
				short num2 = num;
				num = (short)307732797;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1885405184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)353239041;
				if (num != 0)
				{
				}
				num = (short)2014576640;
				if (num != 0)
				{
				}
				return this.advancedAuxTransmitSensitivity_A7530.HiddenStatic;
			}
			set
			{
				short num = (short)706179130;
				short num2 = num;
				num = (short)1475899450;
				switch (num2 == num)
				{
				default:
				{
					num = (short)232521728;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1202520064;
				if (num != 0)
				{
				}
				num = (short)1724448769;
				if (num != 0)
				{
				}
				this.advancedAuxTransmitSensitivity_A7530.HiddenStatic = value;
			}
		}

		// Token: 0x17001716 RID: 5910
		// (get) Token: 0x06002E5A RID: 11866 RVA: 0x002DC304 File Offset: 0x002DA504
		// (set) Token: 0x06002E5B RID: 11867 RVA: 0x002DC3B8 File Offset: 0x002DA5B8
		internal bool AdvancedAuxTransmitSensitivity_A7530_HiddenDynamic
		{
			get
			{
				short num = (short)1277351489;
				short num2 = num;
				num = (short)1250678337;
				switch (num2 == num)
				{
				default:
				{
					num = (short)660406272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)986447873;
				if (num != 0)
				{
				}
				num = (short)1186660352;
				if (num != 0)
				{
				}
				return this.advancedAuxTransmitSensitivity_A7530.HiddenDynamic;
			}
			set
			{
				short num = (short)699242771;
				short num2 = num;
				num = (short)2035390739;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1139998720;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)928448512;
				if (num != 0)
				{
				}
				num = (short)314245121;
				if (num != 0)
				{
				}
				this.advancedAuxTransmitSensitivity_A7530.HiddenDynamic = value;
			}
		}

		// Token: 0x17001717 RID: 5911
		// (get) Token: 0x06002E5C RID: 11868 RVA: 0x002DC46C File Offset: 0x002DA66C
		public bool AdvancedAuxTransmitSensitivity_A7530_HasDiffs
		{
			get
			{
				short num = (short)468009057;
				short num2 = num;
				num = (short)1457930337;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1878261760;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)800784384;
				if (num != 0)
				{
				}
				num = (short)329711617;
				if (num != 0)
				{
				}
				return this.advancedAuxTransmitSensitivity_A7530._HasDiffs;
			}
		}

		// Token: 0x17001718 RID: 5912
		// (get) Token: 0x06002E5D RID: 11869 RVA: 0x002DC520 File Offset: 0x002DA720
		// (set) Token: 0x06002E5E RID: 11870 RVA: 0x002DC5D4 File Offset: 0x002DA7D4
		public bool RadWideRxAudioControlMidrangeEqualization_A8508Value
		{
			get
			{
				short num = (short)1734052270;
				short num2 = num;
				num = (short)1264093614;
				switch (num2 == num)
				{
				default:
				{
					num = (short)717619200;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1013776384;
				if (num != 0)
				{
				}
				num = (short)1729101825;
				if (num != 0)
				{
				}
				return this.radWideRxAudioControlMidrangeEqualization_A8508.Value;
			}
			set
			{
				short num = (short)869302910;
				short num2 = num;
				num = (short)767328894;
				switch (num2 == num)
				{
				default:
				{
					num = (short)809107456;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1487470593;
				if (num != 0)
				{
				}
				num = (short)2084175872;
				if (num != 0)
				{
				}
				this.radWideRxAudioControlMidrangeEqualization_A8508.Value = value;
			}
		}

		// Token: 0x17001719 RID: 5913
		// (get) Token: 0x06002E5F RID: 11871 RVA: 0x002DC688 File Offset: 0x002DA888
		public global::AcpBusinessLayer.AcpField<bool> RadWideRxAudioControlMidrangeEqualization_A8508
		{
			get
			{
				short num = (short)1052639233;
				if (num != 0)
				{
				}
				num = (short)1759641600;
				short num2 = num;
				num = (short)759399749;
				short num3 = num;
				num = (short)1063552325;
				switch (num3 == num)
				{
				}
				num = (short)154402816;
				if (num != 0)
				{
				}
				return this.radWideRxAudioControlMidrangeEqualization_A8508;
			}
		}

		// Token: 0x1700171A RID: 5914
		// (get) Token: 0x06002E60 RID: 11872 RVA: 0x002DC738 File Offset: 0x002DA938
		// (set) Token: 0x06002E61 RID: 11873 RVA: 0x002DC7F0 File Offset: 0x002DA9F0
		public bool RadWideRxAudioControlMidrangeEqualization_A8508_UIValue
		{
			get
			{
				short num = (short)1708311206;
				short num2 = num;
				num = (short)1304412838;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2121662464;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)56688641;
				if (num != 0)
				{
				}
				num = (short)1922039808;
				if (num != 0)
				{
				}
				return this.radWideRxAudioControlMidrangeEqualization_A8508.Value;
			}
			set
			{
				short num = (short)1888399881;
				short num2 = num;
				num = (short)1683141129;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1904082944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)606339073;
				if (num != 0)
				{
				}
				num = (short)1476001792;
				if (num != 0)
				{
				}
				this.radWideRxAudioControlMidrangeEqualization_A8508.Value = value;
			}
		}

		// Token: 0x1700171B RID: 5915
		// (get) Token: 0x06002E62 RID: 11874 RVA: 0x002DC8A8 File Offset: 0x002DAAA8
		// (set) Token: 0x06002E63 RID: 11875 RVA: 0x002DC960 File Offset: 0x002DAB60
		public bool RadWideRxAudioControlMidrangeEqualization_A8508_Applicable
		{
			get
			{
				short num = (short)678049662;
				short num2 = num;
				num = (short)1592276862;
				switch (num2 == num)
				{
				default:
				{
					num = (short)354680832;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2014773248;
				if (num != 0)
				{
				}
				num = (short)834273281;
				if (num != 0)
				{
				}
				return this.radWideRxAudioControlMidrangeEqualization_A8508.Applicable;
			}
			set
			{
				short num = (short)332922881;
				if (num != 0)
				{
				}
				num = (short)1056636928;
				short num2 = num;
				num = (short)975840970;
				short num3 = num;
				num = (short)455550666;
				switch (num3 == num)
				{
				}
				num = (short)524288;
				if (num != 0)
				{
				}
				this.radWideRxAudioControlMidrangeEqualization_A8508.Applicable = value;
			}
		}

		// Token: 0x1700171C RID: 5916
		// (get) Token: 0x06002E64 RID: 11876 RVA: 0x002DCA14 File Offset: 0x002DAC14
		// (set) Token: 0x06002E65 RID: 11877 RVA: 0x002DCAC8 File Offset: 0x002DACC8
		public bool RadWideRxAudioControlMidrangeEqualization_A8508_Valid
		{
			get
			{
				short num = (short)1544637200;
				short num2 = num;
				num = (short)1600342800;
				switch (num2 == num)
				{
				default:
				{
					num = (short)14811136;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)978255872;
				if (num != 0)
				{
				}
				num = (short)1708261377;
				if (num != 0)
				{
				}
				return this.radWideRxAudioControlMidrangeEqualization_A8508.Valid;
			}
			set
			{
				short num = (short)1025788651;
				short num2 = num;
				num = (short)1290095339;
				switch (num2 == num)
				{
				default:
				{
					num = (short)206176256;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1458634752;
				if (num != 0)
				{
				}
				num = (short)1381695489;
				if (num != 0)
				{
				}
				this.radWideRxAudioControlMidrangeEqualization_A8508.Valid = value;
			}
		}

		// Token: 0x1700171D RID: 5917
		// (get) Token: 0x06002E66 RID: 11878 RVA: 0x002DCB7C File Offset: 0x002DAD7C
		// (set) Token: 0x06002E67 RID: 11879 RVA: 0x002DCC30 File Offset: 0x002DAE30
		public bool RadWideRxAudioControlMidrangeEqualization_A8508_Visible
		{
			get
			{
				short num = (short)1729971;
				short num2 = num;
				num = (short)1814062515;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1956708352;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1428160513;
				if (num != 0)
				{
				}
				num = (short)556597248;
				if (num != 0)
				{
				}
				return this.radWideRxAudioControlMidrangeEqualization_A8508.Visible;
			}
			set
			{
				short num = (short)1719486558;
				short num2 = num;
				num = (short)969230430;
				switch (num2 == num)
				{
				default:
				{
					num = (short)464322560;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)321126400;
				if (num != 0)
				{
				}
				num = (short)1558315009;
				if (num != 0)
				{
				}
				this.radWideRxAudioControlMidrangeEqualization_A8508.Visible = value;
			}
		}

		// Token: 0x1700171E RID: 5918
		// (get) Token: 0x06002E68 RID: 11880 RVA: 0x002DCCE4 File Offset: 0x002DAEE4
		// (set) Token: 0x06002E69 RID: 11881 RVA: 0x002DCD98 File Offset: 0x002DAF98
		public bool RadWideRxAudioControlMidrangeEqualization_A8508_Editable
		{
			get
			{
				short num = (short)872475943;
				short num2 = num;
				num = (short)2078207271;
				switch (num2 == num)
				{
				default:
				{
					num = (short)712638464;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)461242368;
				if (num != 0)
				{
				}
				num = (short)883097601;
				if (num != 0)
				{
				}
				return this.radWideRxAudioControlMidrangeEqualization_A8508.Editable;
			}
			set
			{
				short num = (short)1081802753;
				if (num != 0)
				{
				}
				num = (short)274857984;
				short num2 = num;
				num = (short)862990232;
				short num3 = num;
				num = (short)2116431768;
				switch (num3 == num)
				{
				}
				num = (short)704905216;
				if (num != 0)
				{
				}
				this.radWideRxAudioControlMidrangeEqualization_A8508.Editable = value;
			}
		}

		// Token: 0x1700171F RID: 5919
		// (get) Token: 0x06002E6A RID: 11882 RVA: 0x002DCE4C File Offset: 0x002DB04C
		internal string RadWideRxAudioControlMidrangeEqualization_A8508_UILabel
		{
			get
			{
				short num = (short)315293697;
				if (num != 0)
				{
				}
				num = (short)1062207488;
				short num2 = num;
				num = (short)200237811;
				short num3 = num;
				num = (short)594830067;
				switch (num3 == num)
				{
				}
				num = (short)1663041536;
				if (num != 0)
				{
				}
				return this.radWideRxAudioControlMidrangeEqualization_A8508.UIName;
			}
		}

		// Token: 0x17001720 RID: 5920
		// (get) Token: 0x06002E6B RID: 11883 RVA: 0x002DCF00 File Offset: 0x002DB100
		// (set) Token: 0x06002E6C RID: 11884 RVA: 0x002DCFB4 File Offset: 0x002DB1B4
		internal bool RadWideRxAudioControlMidrangeEqualization_A8508_HiddenStatic
		{
			get
			{
				short num = (short)624295937;
				if (num != 0)
				{
				}
				num = (short)1426063360;
				short num2 = num;
				num = (short)885815028;
				short num3 = num;
				num = (short)535328500;
				switch (num3 == num)
				{
				}
				num = (short)1663369216;
				if (num != 0)
				{
				}
				return this.radWideRxAudioControlMidrangeEqualization_A8508.HiddenStatic;
			}
			set
			{
				short num = (short)791122323;
				short num2 = num;
				num = (short)184521107;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1089601536;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1921974273;
				if (num != 0)
				{
				}
				num = (short)1117650944;
				if (num != 0)
				{
				}
				this.radWideRxAudioControlMidrangeEqualization_A8508.HiddenStatic = value;
			}
		}

		// Token: 0x17001721 RID: 5921
		// (get) Token: 0x06002E6D RID: 11885 RVA: 0x002DD06C File Offset: 0x002DB26C
		// (set) Token: 0x06002E6E RID: 11886 RVA: 0x002DD124 File Offset: 0x002DB324
		internal bool RadWideRxAudioControlMidrangeEqualization_A8508_HiddenDynamic
		{
			get
			{
				short num = (short)1732462396;
				short num2 = num;
				num = (short)321865532;
				switch (num2 == num)
				{
				default:
				{
					num = (short)338034688;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1260650497;
				if (num != 0)
				{
				}
				num = (short)752156672;
				if (num != 0)
				{
				}
				return this.radWideRxAudioControlMidrangeEqualization_A8508.HiddenDynamic;
			}
			set
			{
				short num = (short)1291837847;
				short num2 = num;
				num = (short)1012851095;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1142030336;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1567293441;
				if (num != 0)
				{
				}
				num = (short)1175060480;
				if (num != 0)
				{
				}
				this.radWideRxAudioControlMidrangeEqualization_A8508.HiddenDynamic = value;
			}
		}

		// Token: 0x17001722 RID: 5922
		// (get) Token: 0x06002E6F RID: 11887 RVA: 0x002DD1D8 File Offset: 0x002DB3D8
		public bool RadWideRxAudioControlMidrangeEqualization_A8508_HasDiffs
		{
			get
			{
				short num = (short)1324261250;
				short num2 = num;
				num = (short)1633329026;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1173618688;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1044447233;
				if (num != 0)
				{
				}
				num = (short)1042939904;
				if (num != 0)
				{
				}
				return this.radWideRxAudioControlMidrangeEqualization_A8508._HasDiffs;
			}
		}

		// Token: 0x17001723 RID: 5923
		// (get) Token: 0x06002E70 RID: 11888 RVA: 0x002DD28C File Offset: 0x002DB48C
		// (set) Token: 0x06002E71 RID: 11889 RVA: 0x002DD340 File Offset: 0x002DB540
		public bool RadWideDigitalAudioOptionsStrongInterference2_A9206Value
		{
			get
			{
				short num = (short)1774445412;
				short num2 = num;
				num = (short)1503060836;
				switch (num2 == num)
				{
				default:
				{
					num = (short)422182912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)941031424;
				if (num != 0)
				{
				}
				num = (short)610861057;
				if (num != 0)
				{
				}
				return this.radWideDigitalAudioOptionsStrongInterference2_A9206.Value;
			}
			set
			{
				short num = (short)440231964;
				short num2 = num;
				num = (short)225142812;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1593966592;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)72876033;
				if (num != 0)
				{
				}
				num = (short)705560576;
				if (num != 0)
				{
				}
				this.radWideDigitalAudioOptionsStrongInterference2_A9206.Value = value;
			}
		}

		// Token: 0x17001724 RID: 5924
		// (get) Token: 0x06002E72 RID: 11890 RVA: 0x002DD3F8 File Offset: 0x002DB5F8
		public global::AcpBusinessLayer.AcpField<bool> RadWideDigitalAudioOptionsStrongInterference2_A9206
		{
			get
			{
				short num = (short)301614135;
				short num2 = num;
				num = (short)1903379511;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1203044352;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)488964097;
				if (num != 0)
				{
				}
				num = (short)114425856;
				if (num != 0)
				{
				}
				return this.radWideDigitalAudioOptionsStrongInterference2_A9206;
			}
		}

		// Token: 0x17001725 RID: 5925
		// (get) Token: 0x06002E73 RID: 11891 RVA: 0x002DD4AC File Offset: 0x002DB6AC
		// (set) Token: 0x06002E74 RID: 11892 RVA: 0x002DD560 File Offset: 0x002DB760
		public bool RadWideDigitalAudioOptionsStrongInterference2_A9206_UIValue
		{
			get
			{
				short num = (short)590807041;
				if (num != 0)
				{
				}
				num = (short)597164032;
				short num2 = num;
				num = (short)154002700;
				short num3 = num;
				num = (short)141944076;
				switch (num3 == num)
				{
				}
				num = (short)144769024;
				if (num != 0)
				{
				}
				return this.radWideDigitalAudioOptionsStrongInterference2_A9206.Value;
			}
			set
			{
				short num = (short)654112217;
				short num2 = num;
				num = (short)2006447577;
				switch (num2 == num)
				{
				default:
				{
					num = (short)123273216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1826750464;
				if (num != 0)
				{
				}
				num = (short)1704656897;
				if (num != 0)
				{
				}
				this.radWideDigitalAudioOptionsStrongInterference2_A9206.Value = value;
			}
		}

		// Token: 0x17001726 RID: 5926
		// (get) Token: 0x06002E75 RID: 11893 RVA: 0x002DD618 File Offset: 0x002DB818
		// (set) Token: 0x06002E76 RID: 11894 RVA: 0x002DD6CC File Offset: 0x002DB8CC
		public bool RadWideDigitalAudioOptionsStrongInterference2_A9206_Applicable
		{
			get
			{
				short num = (short)1648734928;
				short num2 = num;
				num = (short)1478603472;
				switch (num2 == num)
				{
				default:
				{
					num = (short)980746240;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1338310656;
				if (num != 0)
				{
				}
				num = (short)1012989953;
				if (num != 0)
				{
				}
				return this.radWideDigitalAudioOptionsStrongInterference2_A9206.Applicable;
			}
			set
			{
				short num = (short)1156099167;
				short num2 = num;
				num = (short)279555167;
				switch (num2 == num)
				{
				default:
				{
					num = (short)711131136;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)477757441;
				if (num != 0)
				{
				}
				num = (short)1788084224;
				if (num != 0)
				{
				}
				this.radWideDigitalAudioOptionsStrongInterference2_A9206.Applicable = value;
			}
		}

		// Token: 0x17001727 RID: 5927
		// (get) Token: 0x06002E77 RID: 11895 RVA: 0x002DD780 File Offset: 0x002DB980
		// (set) Token: 0x06002E78 RID: 11896 RVA: 0x002DD834 File Offset: 0x002DBA34
		public bool RadWideDigitalAudioOptionsStrongInterference2_A9206_Valid
		{
			get
			{
				short num = (short)1350309145;
				short num2 = num;
				num = (short)1789793561;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1147535360;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1270874113;
				if (num != 0)
				{
				}
				num = (short)1778057216;
				if (num != 0)
				{
				}
				return this.radWideDigitalAudioOptionsStrongInterference2_A9206.Valid;
			}
			set
			{
				short num = (short)99185321;
				short num2 = num;
				num = (short)1244885673;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1894318080;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1696399361;
				if (num != 0)
				{
				}
				num = (short)1413742592;
				if (num != 0)
				{
				}
				this.radWideDigitalAudioOptionsStrongInterference2_A9206.Valid = value;
			}
		}

		// Token: 0x17001728 RID: 5928
		// (get) Token: 0x06002E79 RID: 11897 RVA: 0x002DD8EC File Offset: 0x002DBAEC
		// (set) Token: 0x06002E7A RID: 11898 RVA: 0x002DD9A0 File Offset: 0x002DBBA0
		public bool RadWideDigitalAudioOptionsStrongInterference2_A9206_Visible
		{
			get
			{
				short num = (short)1993686979;
				short num2 = num;
				num = (short)1749761987;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1353646080;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1173225473;
				if (num != 0)
				{
				}
				num = (short)354353152;
				if (num != 0)
				{
				}
				return this.radWideDigitalAudioOptionsStrongInterference2_A9206.Visible;
			}
			set
			{
				short num = (short)1091048043;
				short num2 = num;
				num = (short)1735332459;
				switch (num2 == num)
				{
				default:
				{
					num = (short)261029888;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1126957057;
				if (num != 0)
				{
				}
				num = (short)151126016;
				if (num != 0)
				{
				}
				this.radWideDigitalAudioOptionsStrongInterference2_A9206.Visible = value;
			}
		}

		// Token: 0x17001729 RID: 5929
		// (get) Token: 0x06002E7B RID: 11899 RVA: 0x002DDA54 File Offset: 0x002DBC54
		// (set) Token: 0x06002E7C RID: 11900 RVA: 0x002DDB0C File Offset: 0x002DBD0C
		public bool RadWideDigitalAudioOptionsStrongInterference2_A9206_Editable
		{
			get
			{
				short num = (short)2023026685;
				short num2 = num;
				num = (short)894889981;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1412497408;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)635830272;
				if (num != 0)
				{
				}
				num = (short)1224081409;
				if (num != 0)
				{
				}
				return this.radWideDigitalAudioOptionsStrongInterference2_A9206.Editable;
			}
			set
			{
				short num = (short)349327324;
				short num2 = num;
				num = (short)632377308;
				switch (num2 == num)
				{
				}
				num = (short)1873936384;
				short num3 = num;
				num = (short)1709309953;
				if (num != 0)
				{
				}
				num = (short)276692992;
				if (num != 0)
				{
				}
				this.radWideDigitalAudioOptionsStrongInterference2_A9206.Editable = value;
			}
		}

		// Token: 0x1700172A RID: 5930
		// (get) Token: 0x06002E7D RID: 11901 RVA: 0x002DDBC4 File Offset: 0x002DBDC4
		internal string RadWideDigitalAudioOptionsStrongInterference2_A9206_UILabel
		{
			get
			{
				short num = (short)219411232;
				short num2 = num;
				num = (short)15725344;
				switch (num2 == num)
				{
				}
				num = (short)169410560;
				short num3 = num;
				num = (short)1301413888;
				if (num != 0)
				{
				}
				num = (short)345243649;
				if (num != 0)
				{
				}
				return this.radWideDigitalAudioOptionsStrongInterference2_A9206.UIName;
			}
		}

		// Token: 0x1700172B RID: 5931
		// (get) Token: 0x06002E7E RID: 11902 RVA: 0x002DDC78 File Offset: 0x002DBE78
		// (set) Token: 0x06002E7F RID: 11903 RVA: 0x002DDD2C File Offset: 0x002DBF2C
		internal bool RadWideDigitalAudioOptionsStrongInterference2_A9206_HiddenStatic
		{
			get
			{
				short num = (short)949896581;
				short num2 = num;
				num = (short)57492869;
				switch (num2 == num)
				{
				}
				num = (short)297664512;
				short num3 = num;
				num = (short)1947860993;
				if (num != 0)
				{
				}
				num = (short)1572864000;
				if (num != 0)
				{
				}
				return this.radWideDigitalAudioOptionsStrongInterference2_A9206.HiddenStatic;
			}
			set
			{
				short num = (short)1106996779;
				short num2 = num;
				num = (short)1917808171;
				switch (num2 == num)
				{
				}
				num = (short)2085486592;
				short num3 = num;
				num = (short)1347223553;
				if (num != 0)
				{
				}
				num = (short)1245118464;
				if (num != 0)
				{
				}
				this.radWideDigitalAudioOptionsStrongInterference2_A9206.HiddenStatic = value;
			}
		}

		// Token: 0x1700172C RID: 5932
		// (get) Token: 0x06002E80 RID: 11904 RVA: 0x002DDDE4 File Offset: 0x002DBFE4
		// (set) Token: 0x06002E81 RID: 11905 RVA: 0x002DDE98 File Offset: 0x002DC098
		internal bool RadWideDigitalAudioOptionsStrongInterference2_A9206_HiddenDynamic
		{
			get
			{
				short num = (short)395470342;
				short num2 = num;
				num = (short)1277584902;
				switch (num2 == num)
				{
				}
				num = (short)932446208;
				short num3 = num;
				num = (short)620822529;
				if (num != 0)
				{
				}
				num = (short)1526202368;
				if (num != 0)
				{
				}
				return this.radWideDigitalAudioOptionsStrongInterference2_A9206.HiddenDynamic;
			}
			set
			{
				short num = (short)997935118;
				short num2 = num;
				num = (short)1624393742;
				switch (num2 == num)
				{
				}
				num = (short)698089472;
				short num3 = num;
				num = (short)1824522240;
				if (num != 0)
				{
				}
				num = (short)1509490689;
				if (num != 0)
				{
				}
				this.radWideDigitalAudioOptionsStrongInterference2_A9206.HiddenDynamic = value;
			}
		}

		// Token: 0x1700172D RID: 5933
		// (get) Token: 0x06002E82 RID: 11906 RVA: 0x002DDF4C File Offset: 0x002DC14C
		public bool RadWideDigitalAudioOptionsStrongInterference2_A9206_HasDiffs
		{
			get
			{
				short num = (short)779657501;
				short num2 = num;
				num = (short)1679008029;
				switch (num2 == num)
				{
				}
				num = (short)163053568;
				short num3 = num;
				num = (short)1623130113;
				if (num != 0)
				{
				}
				num = (short)594935808;
				if (num != 0)
				{
				}
				return this.radWideDigitalAudioOptionsStrongInterference2_A9206._HasDiffs;
			}
		}

		// Token: 0x1700172E RID: 5934
		// (get) Token: 0x06002E83 RID: 11907 RVA: 0x002DE000 File Offset: 0x002DC200
		// (set) Token: 0x06002E84 RID: 11908 RVA: 0x002DE0B4 File Offset: 0x002DC2B4
		public bool RadWideDigitalAudioOptionsStrongInterference1_A9207Value
		{
			get
			{
				short num = (short)1898179181;
				short num2 = num;
				num = (short)1182263917;
				switch (num2 == num)
				{
				}
				num = (short)668073984;
				short num3 = num;
				num = (short)1158742017;
				if (num != 0)
				{
				}
				num = (short)911015936;
				if (num != 0)
				{
				}
				return this.radWideDigitalAudioOptionsStrongInterference1_A9207.Value;
			}
			set
			{
				short num = (short)1439552213;
				short num2 = num;
				num = (short)590926549;
				switch (num2 == num)
				{
				}
				num = (short)2098200576;
				short num3 = num;
				num = (short)529399808;
				if (num != 0)
				{
				}
				num = (short)829161473;
				if (num != 0)
				{
				}
				this.radWideDigitalAudioOptionsStrongInterference1_A9207.Value = value;
			}
		}

		// Token: 0x1700172F RID: 5935
		// (get) Token: 0x06002E85 RID: 11909 RVA: 0x002DE168 File Offset: 0x002DC368
		public global::AcpBusinessLayer.AcpField<bool> RadWideDigitalAudioOptionsStrongInterference1_A9207
		{
			get
			{
				short num = (short)588251137;
				if (num != 0)
				{
				}
				num = (short)1819960854;
				short num2 = num;
				num = (short)121988630;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1168637952;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1382416384;
				if (num != 0)
				{
				}
				return this.radWideDigitalAudioOptionsStrongInterference1_A9207;
			}
		}

		// Token: 0x17001730 RID: 5936
		// (get) Token: 0x06002E86 RID: 11910 RVA: 0x002DE218 File Offset: 0x002DC418
		// (set) Token: 0x06002E87 RID: 11911 RVA: 0x002DE2D0 File Offset: 0x002DC4D0
		public bool RadWideDigitalAudioOptionsStrongInterference1_A9207_UIValue
		{
			get
			{
				short num = (short)9661665;
				short num2 = num;
				num = (short)340749537;
				switch (num2 == num)
				{
				}
				num = (short)747896832;
				short num3 = num;
				num = (short)1719140352;
				if (num != 0)
				{
				}
				num = (short)1756954625;
				if (num != 0)
				{
				}
				return this.radWideDigitalAudioOptionsStrongInterference1_A9207.Value;
			}
			set
			{
				short num = (short)774610847;
				short num2 = num;
				num = (short)1180278687;
				switch (num2 == num)
				{
				}
				num = (short)111083520;
				short num3 = num;
				num = (short)973602817;
				if (num != 0)
				{
				}
				num = (short)1499136000;
				if (num != 0)
				{
				}
				this.radWideDigitalAudioOptionsStrongInterference1_A9207.Value = value;
			}
		}

		// Token: 0x17001731 RID: 5937
		// (get) Token: 0x06002E88 RID: 11912 RVA: 0x002DE384 File Offset: 0x002DC584
		// (set) Token: 0x06002E89 RID: 11913 RVA: 0x002DE438 File Offset: 0x002DC638
		public bool RadWideDigitalAudioOptionsStrongInterference1_A9207_Applicable
		{
			get
			{
				short num = (short)1878321562;
				short num2 = num;
				num = (short)1070262682;
				switch (num2 == num)
				{
				}
				num = (short)346095616;
				short num3 = num;
				num = (short)2107244545;
				if (num != 0)
				{
				}
				num = (short)1365049344;
				if (num != 0)
				{
				}
				return this.radWideDigitalAudioOptionsStrongInterference1_A9207.Applicable;
			}
			set
			{
				short num = (short)799080449;
				if (num != 0)
				{
				}
				num = (short)637208234;
				short num2 = num;
				num = (short)516818602;
				switch (num2 == num)
				{
				default:
				{
					num = (short)51249152;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1959657472;
				if (num != 0)
				{
				}
				this.radWideDigitalAudioOptionsStrongInterference1_A9207.Applicable = value;
			}
		}

		// Token: 0x17001732 RID: 5938
		// (get) Token: 0x06002E8A RID: 11914 RVA: 0x002DE4F0 File Offset: 0x002DC6F0
		// (set) Token: 0x06002E8B RID: 11915 RVA: 0x002DE5A4 File Offset: 0x002DC7A4
		public bool RadWideDigitalAudioOptionsStrongInterference1_A9207_Valid
		{
			get
			{
				short num = (short)1771938847;
				short num2 = num;
				num = (short)707634207;
				switch (num2 == num)
				{
				}
				num = (short)744030208;
				short num3 = num;
				num = (short)573833217;
				if (num != 0)
				{
				}
				num = (short)769130496;
				if (num != 0)
				{
				}
				return this.radWideDigitalAudioOptionsStrongInterference1_A9207.Valid;
			}
			set
			{
				short num = (short)331890117;
				short num2 = num;
				num = (short)364658117;
				switch (num2 == num)
				{
				}
				num = (short)892600320;
				short num3 = num;
				num = (short)1281556481;
				if (num != 0)
				{
				}
				num = (short)878379008;
				if (num != 0)
				{
				}
				this.radWideDigitalAudioOptionsStrongInterference1_A9207.Valid = value;
			}
		}

		// Token: 0x17001733 RID: 5939
		// (get) Token: 0x06002E8C RID: 11916 RVA: 0x002DE65C File Offset: 0x002DC85C
		// (set) Token: 0x06002E8D RID: 11917 RVA: 0x002DE714 File Offset: 0x002DC914
		public bool RadWideDigitalAudioOptionsStrongInterference1_A9207_Visible
		{
			get
			{
				short num = (short)1139699858;
				short num2 = num;
				num = (short)846229650;
				switch (num2 == num)
				{
				}
				num = (short)718667776;
				short num3 = num;
				num = (short)276168705;
				if (num != 0)
				{
				}
				num = (short)1679032320;
				if (num != 0)
				{
				}
				return this.radWideDigitalAudioOptionsStrongInterference1_A9207.Visible;
			}
			set
			{
				short num = (short)780861441;
				if (num != 0)
				{
				}
				num = (short)652561060;
				short num2 = num;
				num = (short)1243433636;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1660026880;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2130116608;
				if (num != 0)
				{
				}
				this.radWideDigitalAudioOptionsStrongInterference1_A9207.Visible = value;
			}
		}

		// Token: 0x17001734 RID: 5940
		// (get) Token: 0x06002E8E RID: 11918 RVA: 0x002DE7C8 File Offset: 0x002DC9C8
		// (set) Token: 0x06002E8F RID: 11919 RVA: 0x002DE87C File Offset: 0x002DCA7C
		public bool RadWideDigitalAudioOptionsStrongInterference1_A9207_Editable
		{
			get
			{
				short num = (short)1087087768;
				short num2 = num;
				num = (short)79078552;
				switch (num2 == num)
				{
				}
				num = (short)462749696;
				short num3 = num;
				num = (short)734199809;
				if (num != 0)
				{
				}
				num = (short)675676160;
				if (num != 0)
				{
				}
				return this.radWideDigitalAudioOptionsStrongInterference1_A9207.Editable;
			}
			set
			{
				short num = (short)920607232;
				short num2 = num;
				num = (short)620255744;
				switch (num2 == num)
				{
				}
				num = (short)660865024;
				short num3 = num;
				num = (short)1153826816;
				if (num != 0)
				{
				}
				num = (short)1509818369;
				if (num != 0)
				{
				}
				this.radWideDigitalAudioOptionsStrongInterference1_A9207.Editable = value;
			}
		}

		// Token: 0x17001735 RID: 5941
		// (get) Token: 0x06002E90 RID: 11920 RVA: 0x002DE934 File Offset: 0x002DCB34
		internal string RadWideDigitalAudioOptionsStrongInterference1_A9207_UILabel
		{
			get
			{
				short num = (short)2050985634;
				short num2 = num;
				num = (short)542346914;
				switch (num2 == num)
				{
				}
				num = (short)1670774784;
				short num3 = num;
				num = (short)493092865;
				if (num != 0)
				{
				}
				num = (short)539754496;
				if (num != 0)
				{
				}
				return this.radWideDigitalAudioOptionsStrongInterference1_A9207.UIName;
			}
		}

		// Token: 0x17001736 RID: 5942
		// (get) Token: 0x06002E91 RID: 11921 RVA: 0x002DE9E8 File Offset: 0x002DCBE8
		// (set) Token: 0x06002E92 RID: 11922 RVA: 0x002DEA9C File Offset: 0x002DCC9C
		internal bool RadWideDigitalAudioOptionsStrongInterference1_A9207_HiddenStatic
		{
			get
			{
				short num = (short)1747334846;
				short num2 = num;
				num = (short)2127378110;
				switch (num2 == num)
				{
				}
				num = (short)919732224;
				short num3 = num;
				num = (short)380043265;
				if (num != 0)
				{
				}
				num = (short)210960384;
				if (num != 0)
				{
				}
				return this.radWideDigitalAudioOptionsStrongInterference1_A9207.HiddenStatic;
			}
			set
			{
				short num = (short)1302640046;
				short num2 = num;
				num = (short)1544467886;
				switch (num2 == num)
				{
				}
				num = (short)1759248384;
				short num3 = num;
				num = (short)435617792;
				if (num != 0)
				{
				}
				num = (short)1959329793;
				if (num != 0)
				{
				}
				this.radWideDigitalAudioOptionsStrongInterference1_A9207.HiddenStatic = value;
			}
		}

		// Token: 0x17001737 RID: 5943
		// (get) Token: 0x06002E93 RID: 11923 RVA: 0x002DEB50 File Offset: 0x002DCD50
		// (set) Token: 0x06002E94 RID: 11924 RVA: 0x002DEC00 File Offset: 0x002DCE00
		internal bool RadWideDigitalAudioOptionsStrongInterference1_A9207_HiddenDynamic
		{
			get
			{
				short num = (short)1378474052;
				short num2 = num;
				num = (short)1904465988;
				switch (num2 == num)
				{
				}
				num = (short)1052704768;
				short num3 = num;
				num = (short)1439629313;
				if (num != 0)
				{
				}
				num = (short)1425014784;
				if (num != 0)
				{
				}
				return this.radWideDigitalAudioOptionsStrongInterference1_A9207.HiddenDynamic;
			}
			set
			{
				short num = (short)877544822;
				short num2 = num;
				num = (short)1806321014;
				switch (num2 == num)
				{
				}
				num = (short)78315520;
				short num3 = num;
				num = (short)1328283649;
				if (num != 0)
				{
				}
				num = (short)272105472;
				if (num != 0)
				{
				}
				this.radWideDigitalAudioOptionsStrongInterference1_A9207.HiddenDynamic = value;
			}
		}

		// Token: 0x17001738 RID: 5944
		// (get) Token: 0x06002E95 RID: 11925 RVA: 0x002DECB8 File Offset: 0x002DCEB8
		public bool RadWideDigitalAudioOptionsStrongInterference1_A9207_HasDiffs
		{
			get
			{
				short num = (short)1336450418;
				short num2 = num;
				num = (short)48471410;
				switch (num2 == num)
				{
				}
				num = (short)855244800;
				short num3 = num;
				num = (short)2113208321;
				if (num != 0)
				{
				}
				num = (short)1636564992;
				if (num != 0)
				{
				}
				return this.radWideDigitalAudioOptionsStrongInterference1_A9207._HasDiffs;
			}
		}

		// Token: 0x17001739 RID: 5945
		// (get) Token: 0x06002E96 RID: 11926 RVA: 0x002DED70 File Offset: 0x002DCF70
		// (set) Token: 0x06002E97 RID: 11927 RVA: 0x002DEE24 File Offset: 0x002DD024
		public bool RadWideDigitalAudioOptionsWeakSignalFringe_A9678Value
		{
			get
			{
				short num = (short)1104252779;
				short num2 = num;
				num = (short)506498923;
				switch (num2 == num)
				{
				}
				num = (short)937099264;
				short num3 = num;
				num = (short)1409679361;
				if (num != 0)
				{
				}
				num = (short)392364032;
				if (num != 0)
				{
				}
				return this.radWideDigitalAudioOptionsWeakSignalFringe_A9678.Value;
			}
			set
			{
				short num = (short)1695354838;
				short num2 = num;
				num = (short)2133856214;
				switch (num2 == num)
				{
				}
				num = (short)163840000;
				short num3 = num;
				num = (short)2118778880;
				if (num != 0)
				{
				}
				num = (short)573898753;
				if (num != 0)
				{
				}
				this.radWideDigitalAudioOptionsWeakSignalFringe_A9678.Value = value;
			}
		}

		// Token: 0x1700173A RID: 5946
		// (get) Token: 0x06002E98 RID: 11928 RVA: 0x002DEED8 File Offset: 0x002DD0D8
		public global::AcpBusinessLayer.AcpField<bool> RadWideDigitalAudioOptionsWeakSignalFringe_A9678
		{
			get
			{
				short num = (short)1343817130;
				short num2 = num;
				num = (short)557254058;
				switch (num2 == num)
				{
				}
				num = (short)363921408;
				short num3 = num;
				num = (short)1735655424;
				if (num != 0)
				{
				}
				num = (short)825688065;
				if (num != 0)
				{
				}
				return this.radWideDigitalAudioOptionsWeakSignalFringe_A9678;
			}
		}

		// Token: 0x1700173B RID: 5947
		// (get) Token: 0x06002E99 RID: 11929 RVA: 0x002DEF84 File Offset: 0x002DD184
		// (set) Token: 0x06002E9A RID: 11930 RVA: 0x002DF03C File Offset: 0x002DD23C
		public bool RadWideDigitalAudioOptionsWeakSignalFringe_A9678_UIValue
		{
			get
			{
				short num = (short)1736647269;
				short num2 = num;
				num = (short)1623663205;
				switch (num2 == num)
				{
				}
				num = (short)745537536;
				short num3 = num;
				num = (short)1477967873;
				if (num != 0)
				{
				}
				num = (short)142934016;
				if (num != 0)
				{
				}
				return this.radWideDigitalAudioOptionsWeakSignalFringe_A9678.Value;
			}
			set
			{
				short num = (short)1734390817;
				short num2 = num;
				num = (short)1866118177;
				switch (num2 == num)
				{
				}
				num = (short)896794624;
				short num3 = num;
				num = (short)2127167488;
				if (num != 0)
				{
				}
				num = (short)425197569;
				if (num != 0)
				{
				}
				this.radWideDigitalAudioOptionsWeakSignalFringe_A9678.Value = value;
			}
		}

		// Token: 0x1700173C RID: 5948
		// (get) Token: 0x06002E9B RID: 11931 RVA: 0x002DF0F4 File Offset: 0x002DD2F4
		// (set) Token: 0x06002E9C RID: 11932 RVA: 0x002DF1A8 File Offset: 0x002DD3A8
		public bool RadWideDigitalAudioOptionsWeakSignalFringe_A9678_Applicable
		{
			get
			{
				short num = (short)389548876;
				short num2 = num;
				num = (short)878512972;
				switch (num2 == num)
				{
				}
				num = (short)337444864;
				short num3 = num;
				num = (short)787415041;
				if (num != 0)
				{
				}
				num = (short)879034368;
				if (num != 0)
				{
				}
				return this.radWideDigitalAudioOptionsWeakSignalFringe_A9678.Applicable;
			}
			set
			{
				short num = (short)14483457;
				if (num != 0)
				{
				}
				num = (short)759707775;
				short num2 = num;
				num = (short)2104572031;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1196032000;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)152109056;
				if (num != 0)
				{
				}
				this.radWideDigitalAudioOptionsWeakSignalFringe_A9678.Applicable = value;
			}
		}

		// Token: 0x1700173D RID: 5949
		// (get) Token: 0x06002E9D RID: 11933 RVA: 0x002DF260 File Offset: 0x002DD460
		// (set) Token: 0x06002E9E RID: 11934 RVA: 0x002DF314 File Offset: 0x002DD514
		public bool RadWideDigitalAudioOptionsWeakSignalFringe_A9678_Valid
		{
			get
			{
				short num = (short)1044084150;
				short num2 = num;
				num = (short)810317238;
				switch (num2 == num)
				{
				}
				num = (short)1005977600;
				short num3 = num;
				num = (short)852033536;
				if (num != 0)
				{
				}
				num = (short)1796341761;
				if (num != 0)
				{
				}
				return this.radWideDigitalAudioOptionsWeakSignalFringe_A9678.Valid;
			}
			set
			{
				short num = (short)922024066;
				short num2 = num;
				num = (short)1663170690;
				switch (num2 == num)
				{
				}
				num = (short)2146172928;
				short num3 = num;
				num = (short)554041344;
				if (num != 0)
				{
				}
				num = (short)269221889;
				if (num != 0)
				{
				}
				this.radWideDigitalAudioOptionsWeakSignalFringe_A9678.Valid = value;
			}
		}

		// Token: 0x1700173E RID: 5950
		// (get) Token: 0x06002E9F RID: 11935 RVA: 0x002DF3C8 File Offset: 0x002DD5C8
		// (set) Token: 0x06002EA0 RID: 11936 RVA: 0x002DF47C File Offset: 0x002DD67C
		public bool RadWideDigitalAudioOptionsWeakSignalFringe_A9678_Visible
		{
			get
			{
				short num = (short)519436806;
				short num2 = num;
				num = (short)1331624454;
				switch (num2 == num)
				{
				}
				num = (short)566951936;
				short num3 = num;
				num = (short)1340669953;
				if (num != 0)
				{
				}
				num = (short)1518469120;
				if (num != 0)
				{
				}
				return this.radWideDigitalAudioOptionsWeakSignalFringe_A9678.Visible;
			}
			set
			{
				short num = (short)2135419411;
				short num2 = num;
				num = (short)588769811;
				switch (num2 == num)
				{
				}
				num = (short)1973616640;
				short num3 = num;
				num = (short)1007681537;
				if (num != 0)
				{
				}
				num = (short)683671552;
				if (num != 0)
				{
				}
				this.radWideDigitalAudioOptionsWeakSignalFringe_A9678.Visible = value;
			}
		}

		// Token: 0x1700173F RID: 5951
		// (get) Token: 0x06002EA1 RID: 11937 RVA: 0x002DF534 File Offset: 0x002DD734
		// (set) Token: 0x06002EA2 RID: 11938 RVA: 0x002DF5E4 File Offset: 0x002DD7E4
		public bool RadWideDigitalAudioOptionsWeakSignalFringe_A9678_Editable
		{
			get
			{
				short num = (short)2110649544;
				short num2 = num;
				num = (short)74773704;
				switch (num2 == num)
				{
				}
				num = (short)1847787520;
				short num3 = num;
				num = (short)1632305152;
				if (num != 0)
				{
				}
				num = (short)157614081;
				if (num != 0)
				{
				}
				return this.radWideDigitalAudioOptionsWeakSignalFringe_A9678.Editable;
			}
			set
			{
				short num = (short)386666734;
				short num2 = num;
				num = (short)944640238;
				switch (num2 == num)
				{
				}
				num = (short)1049362432;
				short num3 = num;
				num = (short)18350081;
				if (num != 0)
				{
				}
				num = (short)816316416;
				if (num != 0)
				{
				}
				this.radWideDigitalAudioOptionsWeakSignalFringe_A9678.Editable = value;
			}
		}

		// Token: 0x17001740 RID: 5952
		// (get) Token: 0x06002EA3 RID: 11939 RVA: 0x002DF698 File Offset: 0x002DD898
		internal string RadWideDigitalAudioOptionsWeakSignalFringe_A9678_UILabel
		{
			get
			{
				short num = (short)36587908;
				short num2 = num;
				num = (short)2104969604;
				switch (num2 == num)
				{
				}
				num = (short)751960064;
				short num3 = num;
				num = (short)2107637760;
				if (num != 0)
				{
				}
				num = (short)1781792769;
				if (num != 0)
				{
				}
				return this.radWideDigitalAudioOptionsWeakSignalFringe_A9678.UIName;
			}
		}

		// Token: 0x17001741 RID: 5953
		// (get) Token: 0x06002EA4 RID: 11940 RVA: 0x002DF74C File Offset: 0x002DD94C
		// (set) Token: 0x06002EA5 RID: 11941 RVA: 0x002DF804 File Offset: 0x002DDA04
		internal bool RadWideDigitalAudioOptionsWeakSignalFringe_A9678_HiddenStatic
		{
			get
			{
				short num = (short)2000659999;
				short num2 = num;
				num = (short)1677436447;
				switch (num2 == num)
				{
				}
				num = (short)1990656000;
				short num3 = num;
				num = (short)701038593;
				if (num != 0)
				{
				}
				num = (short)1337524224;
				if (num != 0)
				{
				}
				return this.radWideDigitalAudioOptionsWeakSignalFringe_A9678.HiddenStatic;
			}
			set
			{
				short num = (short)85065729;
				if (num != 0)
				{
				}
				num = (short)1669265194;
				short num2 = num;
				num = (short)30471978;
				switch (num2 == num)
				{
				default:
				{
					num = (short)28180480;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)532021248;
				if (num != 0)
				{
				}
				this.radWideDigitalAudioOptionsWeakSignalFringe_A9678.HiddenStatic = value;
			}
		}

		// Token: 0x17001742 RID: 5954
		// (get) Token: 0x06002EA6 RID: 11942 RVA: 0x002DF8B8 File Offset: 0x002DDAB8
		// (set) Token: 0x06002EA7 RID: 11943 RVA: 0x002DF96C File Offset: 0x002DDB6C
		internal bool RadWideDigitalAudioOptionsWeakSignalFringe_A9678_HiddenDynamic
		{
			get
			{
				short num = (short)1371196588;
				short num2 = num;
				num = (short)1246809260;
				switch (num2 == num)
				{
				}
				num = (short)2028470272;
				short num3 = num;
				num = (short)2052325377;
				if (num != 0)
				{
				}
				num = (short)1316552704;
				if (num != 0)
				{
				}
				return this.radWideDigitalAudioOptionsWeakSignalFringe_A9678.HiddenDynamic;
			}
			set
			{
				short num = (short)1218084173;
				short num2 = num;
				num = (short)102661453;
				switch (num2 == num)
				{
				}
				num = (short)493158400;
				short num3 = num;
				num = (short)1524891648;
				if (num != 0)
				{
				}
				num = (short)1346437121;
				if (num != 0)
				{
				}
				this.radWideDigitalAudioOptionsWeakSignalFringe_A9678.HiddenDynamic = value;
			}
		}

		// Token: 0x17001743 RID: 5955
		// (get) Token: 0x06002EA8 RID: 11944 RVA: 0x002DFA24 File Offset: 0x002DDC24
		public bool RadWideDigitalAudioOptionsWeakSignalFringe_A9678_HasDiffs
		{
			get
			{
				short num = (short)1204091706;
				short num2 = num;
				num = (short)575142714;
				switch (num2 == num)
				{
				}
				num = (short)2005729280;
				short num3 = num;
				num = (short)1599275008;
				if (num != 0)
				{
				}
				num = (short)411762689;
				if (num != 0)
				{
				}
				return this.radWideDigitalAudioOptionsWeakSignalFringe_A9678._HasDiffs;
			}
		}

		// Token: 0x17001744 RID: 5956
		// (get) Token: 0x06002EA9 RID: 11945 RVA: 0x002DFAD8 File Offset: 0x002DDCD8
		// (set) Token: 0x06002EAA RID: 11946 RVA: 0x002DFB90 File Offset: 0x002DDD90
		public bool RadWideDigitalAudioOptionsWeakSignalFringe_A9679Value
		{
			get
			{
				short num = (short)1102315521;
				if (num != 0)
				{
				}
				num = (short)986752151;
				short num2 = num;
				num = (short)1936762007;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1663107072;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1098252288;
				if (num != 0)
				{
				}
				return this.radWideDigitalAudioOptionsWeakSignalFringe_A9679.Value;
			}
			set
			{
				short num = (short)1252850545;
				short num2 = num;
				num = (short)1381694321;
				switch (num2 == num)
				{
				}
				num = (short)1640103936;
				short num3 = num;
				num = (short)1900019713;
				if (num != 0)
				{
				}
				num = (short)797573120;
				if (num != 0)
				{
				}
				this.radWideDigitalAudioOptionsWeakSignalFringe_A9679.Value = value;
			}
		}

		// Token: 0x17001745 RID: 5957
		// (get) Token: 0x06002EAB RID: 11947 RVA: 0x002DFC44 File Offset: 0x002DDE44
		public global::AcpBusinessLayer.AcpField<bool> RadWideDigitalAudioOptionsWeakSignalFringe_A9679
		{
			get
			{
				short num = (short)1210249006;
				short num2 = num;
				num = (short)221703982;
				switch (num2 == num)
				{
				}
				num = (short)877068288;
				short num3 = num;
				num = (short)968425473;
				if (num != 0)
				{
				}
				num = (short)900923392;
				if (num != 0)
				{
				}
				return this.radWideDigitalAudioOptionsWeakSignalFringe_A9679;
			}
		}

		// Token: 0x17001746 RID: 5958
		// (get) Token: 0x06002EAC RID: 11948 RVA: 0x002DFCF0 File Offset: 0x002DDEF0
		// (set) Token: 0x06002EAD RID: 11949 RVA: 0x002DFDA4 File Offset: 0x002DDFA4
		public bool RadWideDigitalAudioOptionsWeakSignalFringe_A9679_UIValue
		{
			get
			{
				short num = (short)1027018417;
				short num2 = num;
				num = (short)76418737;
				switch (num2 == num)
				{
				}
				num = (short)1600585728;
				short num3 = num;
				num = (short)661389313;
				if (num != 0)
				{
				}
				num = (short)122880000;
				if (num != 0)
				{
				}
				return this.radWideDigitalAudioOptionsWeakSignalFringe_A9679.Value;
			}
			set
			{
				short num = (short)1065643674;
				short num2 = num;
				num = (short)653749914;
				switch (num2 == num)
				{
				}
				num = (short)1079574528;
				short num3 = num;
				num = (short)1396965377;
				if (num != 0)
				{
				}
				num = (short)652804096;
				if (num != 0)
				{
				}
				this.radWideDigitalAudioOptionsWeakSignalFringe_A9679.Value = value;
			}
		}

		// Token: 0x17001747 RID: 5959
		// (get) Token: 0x06002EAE RID: 11950 RVA: 0x002DFE5C File Offset: 0x002DE05C
		// (set) Token: 0x06002EAF RID: 11951 RVA: 0x002DFF14 File Offset: 0x002DE114
		public bool RadWideDigitalAudioOptionsWeakSignalFringe_A9679_Applicable
		{
			get
			{
				short num = (short)917808262;
				short num2 = num;
				num = (short)1489740934;
				switch (num2 == num)
				{
				}
				num = (short)1752694784;
				short num3 = num;
				num = (short)2045181953;
				if (num != 0)
				{
				}
				num = (short)1399128064;
				if (num != 0)
				{
				}
				return this.radWideDigitalAudioOptionsWeakSignalFringe_A9679.Applicable;
			}
			set
			{
				short num = (short)1299972097;
				if (num != 0)
				{
				}
				num = (short)1470507012;
				short num2 = num;
				num = (short)906569732;
				switch (num2 == num)
				{
				default:
				{
					num = (short)449904640;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1415446528;
				if (num != 0)
				{
				}
				this.radWideDigitalAudioOptionsWeakSignalFringe_A9679.Applicable = value;
			}
		}

		// Token: 0x17001748 RID: 5960
		// (get) Token: 0x06002EB0 RID: 11952 RVA: 0x002DFFC8 File Offset: 0x002DE1C8
		// (set) Token: 0x06002EB1 RID: 11953 RVA: 0x002E007C File Offset: 0x002DE27C
		public bool RadWideDigitalAudioOptionsWeakSignalFringe_A9679_Valid
		{
			get
			{
				short num = (short)1499634475;
				short num2 = num;
				num = (short)88316715;
				switch (num2 == num)
				{
				}
				num = (short)54984704;
				short num3 = num;
				num = (short)1164836865;
				if (num != 0)
				{
				}
				num = (short)715522048;
				if (num != 0)
				{
				}
				return this.radWideDigitalAudioOptionsWeakSignalFringe_A9679.Valid;
			}
			set
			{
				short num = (short)789887083;
				short num2 = num;
				num = (short)36288619;
				switch (num2 == num)
				{
				}
				num = (short)995098624;
				short num3 = num;
				num = (short)1493172224;
				if (num != 0)
				{
				}
				num = (short)1531445249;
				if (num != 0)
				{
				}
				this.radWideDigitalAudioOptionsWeakSignalFringe_A9679.Valid = value;
			}
		}

		// Token: 0x17001749 RID: 5961
		// (get) Token: 0x06002EB2 RID: 11954 RVA: 0x002E0130 File Offset: 0x002DE330
		// (set) Token: 0x06002EB3 RID: 11955 RVA: 0x002E01E4 File Offset: 0x002DE3E4
		public bool RadWideDigitalAudioOptionsWeakSignalFringe_A9679_Visible
		{
			get
			{
				short num = (short)156328282;
				short num2 = num;
				num = (short)1193828698;
				switch (num2 == num)
				{
				}
				num = (short)602210304;
				short num3 = num;
				num = (short)1547370497;
				if (num != 0)
				{
				}
				num = (short)935329792;
				if (num != 0)
				{
				}
				return this.radWideDigitalAudioOptionsWeakSignalFringe_A9679.Visible;
			}
			set
			{
				short num = (short)576126976;
				short num2 = num;
				num = (short)911808797;
				short num3 = num;
				num = (short)1666980125;
				switch (num3 == num)
				{
				}
				num = (short)1663827968;
				if (num != 0)
				{
				}
				num = (short)653328385;
				if (num != 0)
				{
				}
				this.radWideDigitalAudioOptionsWeakSignalFringe_A9679.Visible = value;
			}
		}

		// Token: 0x1700174A RID: 5962
		// (get) Token: 0x06002EB4 RID: 11956 RVA: 0x002E0298 File Offset: 0x002DE498
		// (set) Token: 0x06002EB5 RID: 11957 RVA: 0x002E034C File Offset: 0x002DE54C
		public bool RadWideDigitalAudioOptionsWeakSignalFringe_A9679_Editable
		{
			get
			{
				short num = (short)627113984;
				short num2 = num;
				num = (short)1176386930;
				short num3 = num;
				num = (short)1804287346;
				switch (num3 == num)
				{
				}
				num = (short)2020147200;
				if (num != 0)
				{
				}
				num = (short)731119617;
				if (num != 0)
				{
				}
				return this.radWideDigitalAudioOptionsWeakSignalFringe_A9679.Editable;
			}
			set
			{
				short num = (short)498466816;
				short num2 = num;
				num = (short)986541376;
				short num3 = num;
				num = (short)1453747520;
				switch (num3 == num)
				{
				}
				num = (short)639238145;
				if (num != 0)
				{
				}
				num = (short)1083047936;
				if (num != 0)
				{
				}
				this.radWideDigitalAudioOptionsWeakSignalFringe_A9679.Editable = value;
			}
		}

		// Token: 0x1700174B RID: 5963
		// (get) Token: 0x06002EB6 RID: 11958 RVA: 0x002E0400 File Offset: 0x002DE600
		internal string RadWideDigitalAudioOptionsWeakSignalFringe_A9679_UILabel
		{
			get
			{
				short num = (short)1997799424;
				short num2 = num;
				num = (short)2098604213;
				short num3 = num;
				num = (short)1952917685;
				switch (num3 == num)
				{
				}
				num = (short)606273537;
				if (num != 0)
				{
				}
				num = (short)1520697344;
				if (num != 0)
				{
				}
				return this.radWideDigitalAudioOptionsWeakSignalFringe_A9679.UIName;
			}
		}

		// Token: 0x1700174C RID: 5964
		// (get) Token: 0x06002EB7 RID: 11959 RVA: 0x002E04B4 File Offset: 0x002DE6B4
		// (set) Token: 0x06002EB8 RID: 11960 RVA: 0x002E0568 File Offset: 0x002DE768
		internal bool RadWideDigitalAudioOptionsWeakSignalFringe_A9679_HiddenStatic
		{
			get
			{
				short num = (short)1867841536;
				short num2 = num;
				num = (short)724027539;
				short num3 = num;
				num = (short)1900923027;
				switch (num3 == num)
				{
				}
				num = (short)526319616;
				if (num != 0)
				{
				}
				num = (short)36634625;
				if (num != 0)
				{
				}
				return this.radWideDigitalAudioOptionsWeakSignalFringe_A9679.HiddenStatic;
			}
			set
			{
				short num = (short)1149894656;
				short num2 = num;
				num = (short)345749667;
				short num3 = num;
				num = (short)1737996451;
				switch (num3 == num)
				{
				}
				num = (short)1431830529;
				if (num != 0)
				{
				}
				num = (short)1282801664;
				if (num != 0)
				{
				}
				this.radWideDigitalAudioOptionsWeakSignalFringe_A9679.HiddenStatic = value;
			}
		}

		// Token: 0x1700174D RID: 5965
		// (get) Token: 0x06002EB9 RID: 11961 RVA: 0x002E061C File Offset: 0x002DE81C
		// (set) Token: 0x06002EBA RID: 11962 RVA: 0x002E06D0 File Offset: 0x002DE8D0
		internal bool RadWideDigitalAudioOptionsWeakSignalFringe_A9679_HiddenDynamic
		{
			get
			{
				short num = (short)1593114624;
				short num2 = num;
				num = (short)114856263;
				short num3 = num;
				num = (short)504271175;
				switch (num3 == num)
				{
				}
				num = (short)1822490625;
				if (num != 0)
				{
				}
				num = (short)1873543168;
				if (num != 0)
				{
				}
				return this.radWideDigitalAudioOptionsWeakSignalFringe_A9679.HiddenDynamic;
			}
			set
			{
				short num = (short)1894187008;
				short num2 = num;
				num = (short)1348199619;
				short num3 = num;
				num = (short)1786832067;
				switch (num3 == num)
				{
				}
				num = (short)1745420289;
				if (num != 0)
				{
				}
				num = (short)976158720;
				if (num != 0)
				{
				}
				this.radWideDigitalAudioOptionsWeakSignalFringe_A9679.HiddenDynamic = value;
			}
		}

		// Token: 0x1700174E RID: 5966
		// (get) Token: 0x06002EBB RID: 11963 RVA: 0x002E0784 File Offset: 0x002DE984
		public bool RadWideDigitalAudioOptionsWeakSignalFringe_A9679_HasDiffs
		{
			get
			{
				short num = (short)1213005824;
				short num2 = num;
				num = (short)934785135;
				short num3 = num;
				num = (short)1917759599;
				switch (num3 == num)
				{
				}
				num = (short)1835009;
				if (num != 0)
				{
				}
				num = (short)977403904;
				if (num != 0)
				{
				}
				return this.radWideDigitalAudioOptionsWeakSignalFringe_A9679._HasDiffs;
			}
		}

		// Token: 0x1700174F RID: 5967
		// (get) Token: 0x06002EBC RID: 11964 RVA: 0x002E0838 File Offset: 0x002DEA38
		// (set) Token: 0x06002EBD RID: 11965 RVA: 0x002E08EC File Offset: 0x002DEAEC
		public bool RadWideLabtoolMultipleConversationDisable_A19552Value
		{
			get
			{
				short num = (short)959578112;
				short num2 = num;
				num = (short)599437813;
				short num3 = num;
				num = (short)797749749;
				switch (num3 == num)
				{
				}
				num = (short)1028653057;
				if (num != 0)
				{
				}
				num = (short)571867136;
				if (num != 0)
				{
				}
				return this.radWideLabtoolMultipleConversationDisable_A19552.Value;
			}
			set
			{
				short num = (short)975699968;
				short num2 = num;
				num = (short)1592328193;
				if (num != 0)
				{
				}
				num = (short)1706189205;
				short num3 = num;
				num = (short)1454334357;
				switch (num3 == num)
				{
				}
				num = (short)338296832;
				if (num != 0)
				{
				}
				this.radWideLabtoolMultipleConversationDisable_A19552.Value = value;
			}
		}

		// Token: 0x17001750 RID: 5968
		// (get) Token: 0x06002EBE RID: 11966 RVA: 0x002E09A0 File Offset: 0x002DEBA0
		public global::AcpBusinessLayer.AcpFieldX<bool, bool> RadWideLabtoolMultipleConversationDisable_A19552
		{
			get
			{
				short num = (short)1327366144;
				short num2 = num;
				num = (short)1117978625;
				if (num != 0)
				{
				}
				num = (short)2075027232;
				short num3 = num;
				num = (short)2120574752;
				switch (num3 == num)
				{
				}
				num = (short)1339817984;
				if (num != 0)
				{
				}
				return this.radWideLabtoolMultipleConversationDisable_A19552;
			}
		}

		// Token: 0x17001751 RID: 5969
		// (get) Token: 0x06002EBF RID: 11967 RVA: 0x002E0A4C File Offset: 0x002DEC4C
		// (set) Token: 0x06002EC0 RID: 11968 RVA: 0x002E0B00 File Offset: 0x002DED00
		public bool RadWideLabtoolMultipleConversationDisable_A19552_UIValue
		{
			get
			{
				short num = (short)815661056;
				short num2 = num;
				num = (short)1055749091;
				short num3 = num;
				num = (short)587625443;
				switch (num3 == num)
				{
				}
				num = (short)56098817;
				if (num != 0)
				{
				}
				num = (short)1652490240;
				if (num != 0)
				{
				}
				return this.radWideLabtoolMultipleConversationDisable_A19552.UIValue;
			}
			set
			{
				short num = (short)179961856;
				short num2 = num;
				num = (short)1803423272;
				short num3 = num;
				num = (short)1345064488;
				switch (num3 == num)
				{
				}
				num = (short)1382219777;
				if (num != 0)
				{
				}
				num = (short)4849664;
				if (num != 0)
				{
				}
				this.radWideLabtoolMultipleConversationDisable_A19552.UIValue = value;
			}
		}

		// Token: 0x17001752 RID: 5970
		// (get) Token: 0x06002EC1 RID: 11969 RVA: 0x002E0BB8 File Offset: 0x002DEDB8
		// (set) Token: 0x06002EC2 RID: 11970 RVA: 0x002E0C6C File Offset: 0x002DEE6C
		public bool RadWideLabtoolMultipleConversationDisable_A19552_Applicable
		{
			get
			{
				short num = (short)1925513216;
				short num2 = num;
				num = (short)510459905;
				if (num != 0)
				{
				}
				num = (short)2033691160;
				short num3 = num;
				num = (short)1609607704;
				switch (num3 == num)
				{
				}
				num = (short)257425408;
				if (num != 0)
				{
				}
				return this.radWideLabtoolMultipleConversationDisable_A19552.Applicable;
			}
			set
			{
				short num = (short)655753216;
				short num2 = num;
				num = (short)1928221617;
				short num3 = num;
				num = (short)214324145;
				switch (num3 == num)
				{
				}
				num = (short)261881856;
				if (num != 0)
				{
				}
				num = (short)1130627073;
				if (num != 0)
				{
				}
				this.radWideLabtoolMultipleConversationDisable_A19552.Applicable = value;
			}
		}

		// Token: 0x17001753 RID: 5971
		// (get) Token: 0x06002EC3 RID: 11971 RVA: 0x002E0D20 File Offset: 0x002DEF20
		// (set) Token: 0x06002EC4 RID: 11972 RVA: 0x002E0DD4 File Offset: 0x002DEFD4
		public bool RadWideLabtoolMultipleConversationDisable_A19552_Valid
		{
			get
			{
				short num = (short)1595015168;
				short num2 = num;
				num = (short)860781514;
				short num3 = num;
				num = (short)1434614730;
				switch (num3 == num)
				{
				}
				num = (short)952631297;
				if (num != 0)
				{
				}
				num = (short)1498546176;
				if (num != 0)
				{
				}
				return this.radWideLabtoolMultipleConversationDisable_A19552.Valid;
			}
			set
			{
				short num = (short)98697216;
				short num2 = num;
				num = (short)1970878902;
				short num3 = num;
				num = (short)1232222646;
				switch (num3 == num)
				{
				}
				num = (short)1407582209;
				if (num != 0)
				{
				}
				num = (short)325582848;
				if (num != 0)
				{
				}
				this.radWideLabtoolMultipleConversationDisable_A19552.Valid = value;
			}
		}

		// Token: 0x17001754 RID: 5972
		// (get) Token: 0x06002EC5 RID: 11973 RVA: 0x002E0E8C File Offset: 0x002DF08C
		// (set) Token: 0x06002EC6 RID: 11974 RVA: 0x002E0F40 File Offset: 0x002DF140
		public bool RadWideLabtoolMultipleConversationDisable_A19552_Visible
		{
			get
			{
				short num = (short)1078657024;
				short num2 = num;
				num = (short)630741780;
				short num3 = num;
				num = (short)1832016660;
				switch (num3 == num)
				{
				}
				num = (short)436076544;
				if (num != 0)
				{
				}
				num = (short)777650177;
				if (num != 0)
				{
				}
				return this.radWideLabtoolMultipleConversationDisable_A19552.Visible;
			}
			set
			{
				short num = (short)1755316224;
				short num2 = num;
				num = (short)1807332321;
				short num3 = num;
				num = (short)1537061857;
				switch (num3 == num)
				{
				}
				num = (short)819003393;
				if (num != 0)
				{
				}
				num = (short)1653669888;
				if (num != 0)
				{
				}
				this.radWideLabtoolMultipleConversationDisable_A19552.Visible = value;
			}
		}

		// Token: 0x17001755 RID: 5973
		// (get) Token: 0x06002EC7 RID: 11975 RVA: 0x002E0FF8 File Offset: 0x002DF1F8
		// (set) Token: 0x06002EC8 RID: 11976 RVA: 0x002E10B0 File Offset: 0x002DF2B0
		public bool RadWideLabtoolMultipleConversationDisable_A19552_Editable
		{
			get
			{
				short num = (short)105250816;
				short num2 = num;
				num = (short)1698142072;
				short num3 = num;
				num = (short)1192925048;
				switch (num3 == num)
				{
				}
				num = (short)2112552961;
				if (num != 0)
				{
				}
				num = (short)412811264;
				if (num != 0)
				{
				}
				return this.radWideLabtoolMultipleConversationDisable_A19552.Editable;
			}
			set
			{
				short num = (short)1700724736;
				short num2 = num;
				num = (short)1681549841;
				short num3 = num;
				num = (short)2110155281;
				switch (num3 == num)
				{
				}
				num = (short)1143341056;
				if (num != 0)
				{
				}
				num = (short)169082881;
				if (num != 0)
				{
				}
				this.radWideLabtoolMultipleConversationDisable_A19552.Editable = value;
			}
		}

		// Token: 0x17001756 RID: 5974
		// (get) Token: 0x06002EC9 RID: 11977 RVA: 0x002E1168 File Offset: 0x002DF368
		internal string RadWideLabtoolMultipleConversationDisable_A19552_UILabel
		{
			get
			{
				short num = (short)1229258752;
				short num2 = num;
				num = (short)1749235809;
				short num3 = num;
				num = (short)378943585;
				switch (num3 == num)
				{
				}
				num = (short)41811969;
				if (num != 0)
				{
				}
				num = (short)1979449344;
				if (num != 0)
				{
				}
				return this.radWideLabtoolMultipleConversationDisable_A19552.UIName;
			}
		}

		// Token: 0x17001757 RID: 5975
		// (get) Token: 0x06002ECA RID: 11978 RVA: 0x002E1220 File Offset: 0x002DF420
		// (set) Token: 0x06002ECB RID: 11979 RVA: 0x002E12D4 File Offset: 0x002DF4D4
		internal bool RadWideLabtoolMultipleConversationDisable_A19552_HiddenStatic
		{
			get
			{
				short num = (short)329449472;
				short num2 = num;
				num = (short)401333514;
				short num3 = num;
				num = (short)1409080586;
				switch (num3 == num)
				{
				}
				num = (short)1313800193;
				if (num != 0)
				{
				}
				num = (short)1824980992;
				if (num != 0)
				{
				}
				return this.radWideLabtoolMultipleConversationDisable_A19552.HiddenStatic;
			}
			set
			{
				short num = (short)874053632;
				short num2 = num;
				num = (short)2059706590;
				short num3 = num;
				num = (short)1218552030;
				switch (num3 == num)
				{
				}
				num = (short)1531904001;
				if (num != 0)
				{
				}
				num = (short)1681391616;
				if (num != 0)
				{
				}
				this.radWideLabtoolMultipleConversationDisable_A19552.HiddenStatic = value;
			}
		}

		// Token: 0x17001758 RID: 5976
		// (get) Token: 0x06002ECC RID: 11980 RVA: 0x002E138C File Offset: 0x002DF58C
		// (set) Token: 0x06002ECD RID: 11981 RVA: 0x002E1440 File Offset: 0x002DF640
		internal bool RadWideLabtoolMultipleConversationDisable_A19552_HiddenDynamic
		{
			get
			{
				short num = (short)1953759232;
				short num2 = num;
				num = (short)581673472;
				short num3 = num;
				num = (short)970236416;
				switch (num3 == num)
				{
				}
				num = (short)1276510208;
				if (num != 0)
				{
				}
				num = (short)310444033;
				if (num != 0)
				{
				}
				return this.radWideLabtoolMultipleConversationDisable_A19552.HiddenDynamic;
			}
			set
			{
				short num = (short)947257344;
				short num2 = num;
				num = (short)1037738044;
				short num3 = num;
				num = (short)191143996;
				switch (num3 == num)
				{
				}
				num = (short)652083201;
				if (num != 0)
				{
				}
				num = (short)1416626176;
				if (num != 0)
				{
				}
				this.radWideLabtoolMultipleConversationDisable_A19552.HiddenDynamic = value;
			}
		}

		// Token: 0x17001759 RID: 5977
		// (get) Token: 0x06002ECE RID: 11982 RVA: 0x002E14F8 File Offset: 0x002DF6F8
		public bool RadWideLabtoolMultipleConversationDisable_A19552_HasDiffs
		{
			get
			{
				short num = (short)1248985088;
				short num2 = num;
				num = (short)314704165;
				short num3 = num;
				num = (short)1477574949;
				switch (num3 == num)
				{
				}
				num = (short)855703553;
				if (num != 0)
				{
				}
				num = (short)1009516544;
				if (num != 0)
				{
				}
				return this.radWideLabtoolMultipleConversationDisable_A19552._HasDiffs;
			}
		}

		// Token: 0x1700175A RID: 5978
		// (get) Token: 0x06002ECF RID: 11983 RVA: 0x002E15AC File Offset: 0x002DF7AC
		// (set) Token: 0x06002ED0 RID: 11984 RVA: 0x002E1660 File Offset: 0x002DF860
		public int RadWideLabtoolDigitalAnalogBalance_A7851Value
		{
			get
			{
				short num = (short)708444160;
				short num2 = num;
				num = (short)2043123471;
				short num3 = num;
				num = (short)1055823631;
				switch (num3 == num)
				{
				}
				num = (short)482344961;
				if (num != 0)
				{
				}
				num = (short)1217265664;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDigitalAnalogBalance_A7851.Value;
			}
			set
			{
				short num = (short)309985280;
				short num2 = num;
				num = (short)1538817503;
				short num3 = num;
				num = (short)859930079;
				switch (num3 == num)
				{
				}
				num = (short)1678376961;
				if (num != 0)
				{
				}
				num = (short)2099707904;
				if (num != 0)
				{
				}
				this.radWideLabtoolDigitalAnalogBalance_A7851.Value = value;
			}
		}

		// Token: 0x1700175B RID: 5979
		// (get) Token: 0x06002ED1 RID: 11985 RVA: 0x002E1718 File Offset: 0x002DF918
		// (set) Token: 0x06002ED2 RID: 11986 RVA: 0x002E17CC File Offset: 0x002DF9CC
		public string RadWideLabtoolDigitalAnalogBalance_A7851_UIValue
		{
			get
			{
				short num = (short)770965504;
				short num2 = num;
				num = (short)2086439964;
				short num3 = num;
				num = (short)48139292;
				switch (num3 == num)
				{
				}
				num = (short)495583232;
				if (num != 0)
				{
				}
				num = (short)247332865;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDigitalAnalogBalance_A7851.UIValue;
			}
			set
			{
				short num = (short)859570176;
				short num2 = num;
				num = (short)1591672833;
				if (num != 0)
				{
				}
				num = (short)1612804129;
				short num3 = num;
				num = (short)969830433;
				switch (num3 == num)
				{
				}
				num = (short)1313734656;
				if (num != 0)
				{
				}
				this.radWideLabtoolDigitalAnalogBalance_A7851.UIValue = value;
			}
		}

		// Token: 0x1700175C RID: 5980
		// (get) Token: 0x06002ED3 RID: 11987 RVA: 0x002E1880 File Offset: 0x002DFA80
		public global::AcpBusinessLayer.AcpListField RadWideLabtoolDigitalAnalogBalance_A7851
		{
			get
			{
				short num = (short)2131099648;
				short num2 = num;
				num = (short)146767892;
				short num3 = num;
				num = (short)592871444;
				switch (num3 == num)
				{
				}
				num = (short)1101201409;
				if (num != 0)
				{
				}
				num = (short)1827995648;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDigitalAnalogBalance_A7851;
			}
		}

		// Token: 0x1700175D RID: 5981
		// (get) Token: 0x06002ED4 RID: 11988 RVA: 0x002E1930 File Offset: 0x002DFB30
		// (set) Token: 0x06002ED5 RID: 11989 RVA: 0x002E19E0 File Offset: 0x002DFBE0
		public bool RadWideLabtoolDigitalAnalogBalance_A7851_Applicable
		{
			get
			{
				short num = (short)1846935552;
				short num2 = num;
				num = (short)434902107;
				short num3 = num;
				num = (short)959059035;
				switch (num3 == num)
				{
				}
				num = (short)2134573057;
				if (num != 0)
				{
				}
				num = (short)1441202176;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDigitalAnalogBalance_A7851.Applicable;
			}
			set
			{
				short num = (short)218300416;
				short num2 = num;
				num = (short)1297604452;
				short num3 = num;
				num = (short)1053613924;
				switch (num3 == num)
				{
				}
				num = (short)1547894784;
				if (num != 0)
				{
				}
				num = (short)443023361;
				if (num != 0)
				{
				}
				this.radWideLabtoolDigitalAnalogBalance_A7851.Applicable = value;
			}
		}

		// Token: 0x1700175E RID: 5982
		// (get) Token: 0x06002ED6 RID: 11990 RVA: 0x002E1A98 File Offset: 0x002DFC98
		// (set) Token: 0x06002ED7 RID: 11991 RVA: 0x002E1B4C File Offset: 0x002DFD4C
		public bool RadWideLabtoolDigitalAnalogBalance_A7851_Valid
		{
			get
			{
				short num = (short)1586429952;
				short num2 = num;
				num = (short)664517780;
				short num3 = num;
				num = (short)914799764;
				switch (num3 == num)
				{
				}
				num = (short)289931265;
				if (num != 0)
				{
				}
				num = (short)382992384;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDigitalAnalogBalance_A7851.Valid;
			}
			set
			{
				short num = (short)1525809152;
				short num2 = num;
				num = (short)678132947;
				short num3 = num;
				num = (short)569015507;
				switch (num3 == num)
				{
				}
				num = (short)852688896;
				if (num != 0)
				{
				}
				num = (short)1192361985;
				if (num != 0)
				{
				}
				this.radWideLabtoolDigitalAnalogBalance_A7851.Valid = value;
			}
		}

		// Token: 0x1700175F RID: 5983
		// (get) Token: 0x06002ED8 RID: 11992 RVA: 0x002E1C00 File Offset: 0x002DFE00
		// (set) Token: 0x06002ED9 RID: 11993 RVA: 0x002E1CB4 File Offset: 0x002DFEB4
		public bool RadWideLabtoolDigitalAnalogBalance_A7851_Visible
		{
			get
			{
				short num = (short)1917059072;
				short num2 = num;
				num = (short)672779282;
				short num3 = num;
				num = (short)80006162;
				switch (num3 == num)
				{
				}
				num = (short)1245577217;
				if (num != 0)
				{
				}
				num = (short)789446656;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDigitalAnalogBalance_A7851.Visible;
			}
			set
			{
				short num = (short)1351024640;
				short num2 = num;
				num = (short)53626970;
				short num3 = num;
				num = (short)1295861850;
				switch (num3 == num)
				{
				}
				num = (short)1744044032;
				if (num != 0)
				{
				}
				num = (short)1880293377;
				if (num != 0)
				{
				}
				this.radWideLabtoolDigitalAnalogBalance_A7851.Visible = value;
			}
		}

		// Token: 0x17001760 RID: 5984
		// (get) Token: 0x06002EDA RID: 11994 RVA: 0x002E1D6C File Offset: 0x002DFF6C
		// (set) Token: 0x06002EDB RID: 11995 RVA: 0x002E1E24 File Offset: 0x002E0024
		public bool RadWideLabtoolDigitalAnalogBalance_A7851_Editable
		{
			get
			{
				short num = (short)1182007296;
				short num2 = num;
				num = (short)156405985;
				short num3 = num;
				num = (short)590581985;
				switch (num3 == num)
				{
				}
				num = (short)2074214401;
				if (num != 0)
				{
				}
				num = (short)2133000192;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDigitalAnalogBalance_A7851.Editable;
			}
			set
			{
				short num = (short)1997078528;
				short num2 = num;
				num = (short)1119163607;
				short num3 = num;
				num = (short)1217664215;
				switch (num3 == num)
				{
				}
				num = (short)510459905;
				if (num != 0)
				{
				}
				num = (short)985923584;
				if (num != 0)
				{
				}
				this.radWideLabtoolDigitalAnalogBalance_A7851.Editable = value;
			}
		}

		// Token: 0x17001761 RID: 5985
		// (get) Token: 0x06002EDC RID: 11996 RVA: 0x002E1EDC File Offset: 0x002E00DC
		internal string RadWideLabtoolDigitalAnalogBalance_A7851_UILabel
		{
			get
			{
				short num = (short)1332477952;
				short num2 = num;
				num = (short)526062182;
				short num3 = num;
				num = (short)1610420838;
				switch (num3 == num)
				{
				}
				num = (short)1368326144;
				if (num != 0)
				{
				}
				num = (short)1368064001;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDigitalAnalogBalance_A7851.UIName;
			}
		}

		// Token: 0x17001762 RID: 5986
		// (get) Token: 0x06002EDD RID: 11997 RVA: 0x002E1F90 File Offset: 0x002E0190
		// (set) Token: 0x06002EDE RID: 11998 RVA: 0x002E2044 File Offset: 0x002E0244
		internal bool RadWideLabtoolDigitalAnalogBalance_A7851_HiddenStatic
		{
			get
			{
				short num = (short)1064632320;
				short num2 = num;
				num = (short)1289624636;
				short num3 = num;
				num = (short)15408188;
				switch (num3 == num)
				{
				}
				num = (short)1241120768;
				if (num != 0)
				{
				}
				num = (short)919076865;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDigitalAnalogBalance_A7851.HiddenStatic;
			}
			set
			{
				short num = (short)83492864;
				short num2 = num;
				num = (short)1727187799;
				short num3 = num;
				num = (short)744868695;
				switch (num3 == num)
				{
				}
				num = (short)948174849;
				if (num != 0)
				{
				}
				num = (short)1515192320;
				if (num != 0)
				{
				}
				this.radWideLabtoolDigitalAnalogBalance_A7851.HiddenStatic = value;
			}
		}

		// Token: 0x17001763 RID: 5987
		// (get) Token: 0x06002EDF RID: 11999 RVA: 0x002E20F8 File Offset: 0x002E02F8
		// (set) Token: 0x06002EE0 RID: 12000 RVA: 0x002E21AC File Offset: 0x002E03AC
		internal bool RadWideLabtoolDigitalAnalogBalance_A7851_HiddenDynamic
		{
			get
			{
				short num = (short)1790181376;
				short num2 = num;
				num = (short)1383111077;
				short num3 = num;
				num = (short)376805797;
				switch (num3 == num)
				{
				}
				num = (short)1568014336;
				if (num != 0)
				{
				}
				num = (short)20119553;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDigitalAnalogBalance_A7851.HiddenDynamic;
			}
			set
			{
				short num = (short)1077870592;
				short num2 = num;
				num = (short)2036678007;
				short num3 = num;
				num = (short)1647000951;
				switch (num3 == num)
				{
				}
				num = (short)140967936;
				if (num != 0)
				{
				}
				num = (short)74514433;
				if (num != 0)
				{
				}
				this.radWideLabtoolDigitalAnalogBalance_A7851.HiddenDynamic = value;
			}
		}

		// Token: 0x17001764 RID: 5988
		// (get) Token: 0x06002EE1 RID: 12001 RVA: 0x002E2264 File Offset: 0x002E0464
		public bool RadWideLabtoolDigitalAnalogBalance_A7851_HasDiffs
		{
			get
			{
				short num = (short)783220736;
				short num2 = num;
				num = (short)522160013;
				short num3 = num;
				num = (short)1909950349;
				switch (num3 == num)
				{
				}
				num = (short)679804928;
				if (num != 0)
				{
				}
				num = (short)1424097281;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDigitalAnalogBalance_A7851._HasDiffs;
			}
		}

		// Token: 0x17001765 RID: 5989
		// (get) Token: 0x06002EE2 RID: 12002 RVA: 0x002E2318 File Offset: 0x002E0518
		// (set) Token: 0x06002EE3 RID: 12003 RVA: 0x002E23D0 File Offset: 0x002E05D0
		public int RadWideAudioConfigurationLevel_42740Value
		{
			get
			{
				short num = (short)1932263424;
				short num2 = num;
				num = (short)2106712326;
				short num3 = num;
				num = (short)1476780294;
				switch (num3 == num)
				{
				}
				num = (short)1588396033;
				if (num != 0)
				{
				}
				num = (short)378863616;
				if (num != 0)
				{
				}
				return this.radWideAudioConfigurationLevel_42740.Value;
			}
			set
			{
				short num = (short)1155989504;
				short num2 = num;
				num = (short)1662870680;
				short num3 = num;
				num = (short)157443224;
				switch (num3 == num)
				{
				}
				num = (short)1901264897;
				if (num != 0)
				{
				}
				num = (short)885653504;
				if (num != 0)
				{
				}
				this.radWideAudioConfigurationLevel_42740.Value = value;
			}
		}

		// Token: 0x17001766 RID: 5990
		// (get) Token: 0x06002EE4 RID: 12004 RVA: 0x002E2488 File Offset: 0x002E0688
		// (set) Token: 0x06002EE5 RID: 12005 RVA: 0x002E253C File Offset: 0x002E073C
		public string RadWideAudioConfigurationLevel_42740_UIValue
		{
			get
			{
				short num = (short)1679753216;
				short num2 = num;
				num = (short)1503337193;
				short num3 = num;
				num = (short)1256856297;
				switch (num3 == num)
				{
				}
				num = (short)62521345;
				if (num != 0)
				{
				}
				num = (short)1407057920;
				if (num != 0)
				{
				}
				return this.radWideAudioConfigurationLevel_42740.UIValue;
			}
			set
			{
				short num = (short)553320448;
				short num2 = num;
				num = (short)1102784699;
				short num3 = num;
				num = (short)796272827;
				switch (num3 == num)
				{
				}
				num = (short)268369920;
				if (num != 0)
				{
				}
				num = (short)767426561;
				if (num != 0)
				{
				}
				this.radWideAudioConfigurationLevel_42740.UIValue = value;
			}
		}

		// Token: 0x17001767 RID: 5991
		// (get) Token: 0x06002EE6 RID: 12006 RVA: 0x002E25F4 File Offset: 0x002E07F4
		public global::AcpBusinessLayer.AcpListField RadWideAudioConfigurationLevel_42740
		{
			get
			{
				short num = (short)454819840;
				short num2 = num;
				num = (short)1849159245;
				short num3 = num;
				num = (short)56094285;
				switch (num3 == num)
				{
				}
				num = (short)638320640;
				if (num != 0)
				{
				}
				num = (short)103350273;
				if (num != 0)
				{
				}
				return this.radWideAudioConfigurationLevel_42740;
			}
		}

		// Token: 0x17001768 RID: 5992
		// (get) Token: 0x06002EE7 RID: 12007 RVA: 0x002E26A0 File Offset: 0x002E08A0
		// (set) Token: 0x06002EE8 RID: 12008 RVA: 0x002E2758 File Offset: 0x002E0958
		public bool RadWideAudioConfigurationLevel_42740_Applicable
		{
			get
			{
				short num = (short)1255014400;
				short num2 = num;
				num = (short)200032278;
				short num3 = num;
				num = (short)274874390;
				switch (num3 == num)
				{
				}
				num = (short)178782208;
				if (num != 0)
				{
				}
				num = (short)1320550401;
				if (num != 0)
				{
				}
				return this.radWideAudioConfigurationLevel_42740.Applicable;
			}
			set
			{
				short num = (short)901382144;
				short num2 = num;
				num = (short)1108477066;
				short num3 = num;
				num = (short)94504074;
				switch (num3 == num)
				{
				}
				num = (short)290783233;
				if (num != 0)
				{
				}
				num = (short)797376512;
				if (num != 0)
				{
				}
				this.radWideAudioConfigurationLevel_42740.Applicable = value;
			}
		}

		// Token: 0x17001769 RID: 5993
		// (get) Token: 0x06002EE9 RID: 12009 RVA: 0x002E280C File Offset: 0x002E0A0C
		// (set) Token: 0x06002EEA RID: 12010 RVA: 0x002E28C0 File Offset: 0x002E0AC0
		public bool RadWideAudioConfigurationLevel_42740_Valid
		{
			get
			{
				short num = (short)1504051200;
				short num2 = num;
				num = (short)1345112546;
				short num3 = num;
				num = (short)1514588642;
				switch (num3 == num)
				{
				}
				num = (short)1538523136;
				if (num != 0)
				{
				}
				num = (short)373161985;
				if (num != 0)
				{
				}
				return this.radWideAudioConfigurationLevel_42740.Valid;
			}
			set
			{
				short num = (short)445710336;
				short num2 = num;
				num = (short)1666428684;
				short num3 = num;
				num = (short)2003808012;
				switch (num3 == num)
				{
				}
				num = (short)145817600;
				if (num != 0)
				{
				}
				num = (short)269549569;
				if (num != 0)
				{
				}
				this.radWideAudioConfigurationLevel_42740.Valid = value;
			}
		}

		// Token: 0x1700176A RID: 5994
		// (get) Token: 0x06002EEB RID: 12011 RVA: 0x002E2978 File Offset: 0x002E0B78
		// (set) Token: 0x06002EEC RID: 12012 RVA: 0x002E2A2C File Offset: 0x002E0C2C
		public bool RadWideAudioConfigurationLevel_42740_Visible
		{
			get
			{
				short num = (short)570818560;
				short num2 = num;
				num = (short)2072577296;
				short num3 = num;
				num = (short)303236368;
				switch (num3 == num)
				{
				}
				num = (short)67895297;
				if (num != 0)
				{
				}
				num = (short)1228734464;
				if (num != 0)
				{
				}
				return this.radWideAudioConfigurationLevel_42740.Visible;
			}
			set
			{
				short num = (short)2055274497;
				if (num != 0)
				{
				}
				num = (short)1385992245;
				short num2 = num;
				num = (short)944738357;
				switch (num2 == num)
				{
				}
				num = (short)808976384;
				short num3 = num;
				num = (short)650510336;
				if (num != 0)
				{
				}
				this.radWideAudioConfigurationLevel_42740.Visible = value;
			}
		}

		// Token: 0x1700176B RID: 5995
		// (get) Token: 0x06002EED RID: 12013 RVA: 0x002E2AE4 File Offset: 0x002E0CE4
		// (set) Token: 0x06002EEE RID: 12014 RVA: 0x002E2B9C File Offset: 0x002E0D9C
		public bool RadWideAudioConfigurationLevel_42740_Editable
		{
			get
			{
				short num = (short)1463484417;
				if (num != 0)
				{
				}
				num = (short)1009027030;
				short num2 = num;
				num = (short)1656195030;
				switch (num2 == num)
				{
				}
				num = (short)766312448;
				short num3 = num;
				num = (short)989921280;
				if (num != 0)
				{
				}
				return this.radWideAudioConfigurationLevel_42740.Editable;
			}
			set
			{
				short num = (short)1811293843;
				short num2 = num;
				num = (short)1485710995;
				switch (num2 == num)
				{
				}
				num = (short)1255473152;
				if (num != 0)
				{
				}
				num = (short)1610678272;
				short num3 = num;
				num = (short)1385365505;
				if (num != 0)
				{
				}
				this.radWideAudioConfigurationLevel_42740.Editable = value;
			}
		}

		// Token: 0x1700176C RID: 5996
		// (get) Token: 0x06002EEF RID: 12015 RVA: 0x002E2C50 File Offset: 0x002E0E50
		internal string RadWideAudioConfigurationLevel_42740_UILabel
		{
			get
			{
				short num = (short)1650595942;
				short num2 = num;
				num = (short)485234790;
				switch (num2 == num)
				{
				}
				num = (short)1095827456;
				if (num != 0)
				{
				}
				num = (short)1608908800;
				short num3 = num;
				num = (short)476053505;
				if (num != 0)
				{
				}
				return this.radWideAudioConfigurationLevel_42740.UIName;
			}
		}

		// Token: 0x1700176D RID: 5997
		// (get) Token: 0x06002EF0 RID: 12016 RVA: 0x002E2D04 File Offset: 0x002E0F04
		// (set) Token: 0x06002EF1 RID: 12017 RVA: 0x002E2DBC File Offset: 0x002E0FBC
		internal bool RadWideAudioConfigurationLevel_42740_HiddenStatic
		{
			get
			{
				short num = (short)1227722786;
				short num2 = num;
				num = (short)232689698;
				switch (num2 == num)
				{
				}
				num = (short)1656946689;
				if (num != 0)
				{
				}
				num = (short)81395712;
				short num3 = num;
				num = (short)542507008;
				if (num != 0)
				{
				}
				return this.radWideAudioConfigurationLevel_42740.HiddenStatic;
			}
			set
			{
				short num = (short)376327604;
				short num2 = num;
				num = (short)1986219444;
				switch (num2 == num)
				{
				}
				num = (short)2055012352;
				if (num != 0)
				{
				}
				num = (short)257425408;
				short num3 = num;
				num = (short)1407385601;
				if (num != 0)
				{
				}
				this.radWideAudioConfigurationLevel_42740.HiddenStatic = value;
			}
		}

		// Token: 0x1700176E RID: 5998
		// (get) Token: 0x06002EF2 RID: 12018 RVA: 0x002E2E74 File Offset: 0x002E1074
		// (set) Token: 0x06002EF3 RID: 12019 RVA: 0x002E2F2C File Offset: 0x002E112C
		internal bool RadWideAudioConfigurationLevel_42740_HiddenDynamic
		{
			get
			{
				short num = (short)1265054352;
				short num2 = num;
				num = (short)862466704;
				switch (num2 == num)
				{
				}
				num = (short)623509505;
				if (num != 0)
				{
				}
				num = (short)697892864;
				short num3 = num;
				num = (short)1841168384;
				if (num != 0)
				{
				}
				return this.radWideAudioConfigurationLevel_42740.HiddenDynamic;
			}
			set
			{
				short num = (short)837887448;
				short num2 = num;
				num = (short)973612504;
				switch (num2 == num)
				{
				}
				num = (short)270729217;
				if (num != 0)
				{
				}
				num = (short)2621440;
				short num3 = num;
				num = (short)1492058112;
				if (num != 0)
				{
				}
				this.radWideAudioConfigurationLevel_42740.HiddenDynamic = value;
			}
		}

		// Token: 0x1700176F RID: 5999
		// (get) Token: 0x06002EF4 RID: 12020 RVA: 0x002E2FE0 File Offset: 0x002E11E0
		public bool RadWideAudioConfigurationLevel_42740_HasDiffs
		{
			get
			{
				short num = (short)1841627137;
				if (num != 0)
				{
				}
				num = (short)830075252;
				short num2 = num;
				num = (short)1943073140;
				switch (num2 == num)
				{
				}
				num = (short)279838720;
				short num3 = num;
				num = (short)153026560;
				if (num != 0)
				{
				}
				return this.radWideAudioConfigurationLevel_42740._HasDiffs;
			}
		}

		// Token: 0x17001770 RID: 6000
		// (get) Token: 0x06002EF5 RID: 12021 RVA: 0x002E3090 File Offset: 0x002E1290
		// (set) Token: 0x06002EF6 RID: 12022 RVA: 0x002E314C File Offset: 0x002E134C
		public bool RadWideCombineTxWithRxFilteredAudio_44808Value
		{
			get
			{
				short num = (short)1202054923;
				short num2 = num;
				num = (short)1367271179;
				switch (num2 == num)
				{
				}
				num = (short)271319040;
				if (num != 0)
				{
				}
				num = (short)517079040;
				short num3 = num;
				num = (short)719781889;
				if (num != 0)
				{
				}
				return this.radWideCombineTxWithRxFilteredAudio_44808.Value;
			}
			set
			{
				short num = (short)1454399367;
				short num2 = num;
				num = (short)1918656391;
				switch (num2 == num)
				{
				}
				num = (short)627834880;
				if (num != 0)
				{
				}
				num = (short)1119092736;
				short num3 = num;
				num = (short)1815281665;
				if (num != 0)
				{
				}
				this.radWideCombineTxWithRxFilteredAudio_44808.Value = value;
			}
		}

		// Token: 0x17001771 RID: 6001
		// (get) Token: 0x06002EF7 RID: 12023 RVA: 0x002E3200 File Offset: 0x002E1400
		public global::AcpBusinessLayer.AcpField<bool> RadWideCombineTxWithRxFilteredAudio_44808
		{
			get
			{
				short num = (short)1757032132;
				short num2 = num;
				num = (short)524627652;
				switch (num2 == num)
				{
				}
				num = (short)451215361;
				if (num != 0)
				{
				}
				num = (short)904658944;
				short num3 = num;
				num = (short)1257308160;
				if (num != 0)
				{
				}
				return this.radWideCombineTxWithRxFilteredAudio_44808;
			}
		}

		// Token: 0x17001772 RID: 6002
		// (get) Token: 0x06002EF8 RID: 12024 RVA: 0x002E32B0 File Offset: 0x002E14B0
		// (set) Token: 0x06002EF9 RID: 12025 RVA: 0x002E3364 File Offset: 0x002E1564
		public bool RadWideCombineTxWithRxFilteredAudio_44808_UIValue
		{
			get
			{
				short num = (short)699723139;
				short num2 = num;
				num = (short)2020928899;
				switch (num2 == num)
				{
				}
				num = (short)673382400;
				if (num != 0)
				{
				}
				num = (short)1171914752;
				short num3 = num;
				num = (short)1564016641;
				if (num != 0)
				{
				}
				return this.radWideCombineTxWithRxFilteredAudio_44808.Value;
			}
			set
			{
				short num = (short)639293150;
				short num2 = num;
				num = (short)415553246;
				switch (num2 == num)
				{
				}
				num = (short)473890816;
				if (num != 0)
				{
				}
				num = (short)1189281792;
				short num3 = num;
				num = (short)1505492993;
				if (num != 0)
				{
				}
				this.radWideCombineTxWithRxFilteredAudio_44808.Value = value;
			}
		}

		// Token: 0x17001773 RID: 6003
		// (get) Token: 0x06002EFA RID: 12026 RVA: 0x002E3414 File Offset: 0x002E1614
		// (set) Token: 0x06002EFB RID: 12027 RVA: 0x002E34C4 File Offset: 0x002E16C4
		public bool RadWideCombineTxWithRxFilteredAudio_44808_Applicable
		{
			get
			{
				short num = (short)231473153;
				if (num != 0)
				{
				}
				num = (short)915713975;
				short num2 = num;
				num = (short)580562871;
				switch (num2 == num)
				{
				}
				num = (short)604569600;
				short num3 = num;
				num = (short)538640384;
				if (num != 0)
				{
				}
				return this.radWideCombineTxWithRxFilteredAudio_44808.Applicable;
			}
			set
			{
				short num = (short)74903900;
				short num2 = num;
				num = (short)1477636444;
				switch (num2 == num)
				{
				}
				num = (short)1751515137;
				if (num != 0)
				{
				}
				num = (short)563216384;
				short num3 = num;
				num = (short)1714290688;
				if (num != 0)
				{
				}
				this.radWideCombineTxWithRxFilteredAudio_44808.Applicable = value;
			}
		}

		// Token: 0x17001774 RID: 6004
		// (get) Token: 0x06002EFC RID: 12028 RVA: 0x002E3578 File Offset: 0x002E1778
		// (set) Token: 0x06002EFD RID: 12029 RVA: 0x002E362C File Offset: 0x002E182C
		public bool RadWideCombineTxWithRxFilteredAudio_44808_Valid
		{
			get
			{
				short num = (short)1999358515;
				short num2 = num;
				num = (short)1374931507;
				switch (num2 == num)
				{
				}
				num = (short)335413249;
				if (num != 0)
				{
				}
				num = (short)1916796928;
				short num3 = num;
				num = (short)1670316032;
				if (num != 0)
				{
				}
				return this.radWideCombineTxWithRxFilteredAudio_44808.Valid;
			}
			set
			{
				short num = (short)175570945;
				if (num != 0)
				{
				}
				num = (short)1856413449;
				short num2 = num;
				num = (short)103849737;
				switch (num2 == num)
				{
				}
				num = (short)45744128;
				short num3 = num;
				num = (short)870842368;
				if (num != 0)
				{
				}
				this.radWideCombineTxWithRxFilteredAudio_44808.Valid = value;
			}
		}

		// Token: 0x17001775 RID: 6005
		// (get) Token: 0x06002EFE RID: 12030 RVA: 0x002E36E4 File Offset: 0x002E18E4
		// (set) Token: 0x06002EFF RID: 12031 RVA: 0x002E3794 File Offset: 0x002E1994
		public bool RadWideCombineTxWithRxFilteredAudio_44808_Visible
		{
			get
			{
				short num = (short)1376748817;
				short num2 = num;
				num = (short)1274578193;
				switch (num2 == num)
				{
				}
				num = (short)951320577;
				if (num != 0)
				{
				}
				num = (short)1823801344;
				short num3 = num;
				num = (short)1921318912;
				if (num != 0)
				{
				}
				return this.radWideCombineTxWithRxFilteredAudio_44808.Visible;
			}
			set
			{
				short num = (short)705449428;
				short num2 = num;
				num = (short)684674516;
				switch (num2 == num)
				{
				}
				num = (short)1911160833;
				if (num != 0)
				{
				}
				num = (short)808189952;
				short num3 = num;
				num = (short)1730740224;
				if (num != 0)
				{
				}
				this.radWideCombineTxWithRxFilteredAudio_44808.Visible = value;
			}
		}

		// Token: 0x17001776 RID: 6006
		// (get) Token: 0x06002F00 RID: 12032 RVA: 0x002E3848 File Offset: 0x002E1A48
		// (set) Token: 0x06002F01 RID: 12033 RVA: 0x002E38FC File Offset: 0x002E1AFC
		public bool RadWideCombineTxWithRxFilteredAudio_44808_Editable
		{
			get
			{
				short num = (short)4091145;
				short num2 = num;
				num = (short)442854665;
				switch (num2 == num)
				{
				}
				num = (short)1601961985;
				if (num != 0)
				{
				}
				num = (short)1776156672;
				short num3 = num;
				num = (short)435421184;
				if (num != 0)
				{
				}
				return this.radWideCombineTxWithRxFilteredAudio_44808.Editable;
			}
			set
			{
				short num = (short)1896891237;
				short num2 = num;
				num = (short)738607973;
				switch (num2 == num)
				{
				}
				num = (short)941096961;
				if (num != 0)
				{
				}
				num = (short)2065498112;
				short num3 = num;
				num = (short)1465188352;
				if (num != 0)
				{
				}
				this.radWideCombineTxWithRxFilteredAudio_44808.Editable = value;
			}
		}

		// Token: 0x17001777 RID: 6007
		// (get) Token: 0x06002F02 RID: 12034 RVA: 0x002E39B4 File Offset: 0x002E1BB4
		internal string RadWideCombineTxWithRxFilteredAudio_44808_UILabel
		{
			get
			{
				short num = (short)476930918;
				short num2 = num;
				num = (short)1873961830;
				switch (num2 == num)
				{
				}
				num = (short)797048833;
				if (num != 0)
				{
				}
				num = (short)482476032;
				short num3 = num;
				num = (short)1256587264;
				if (num != 0)
				{
				}
				return this.radWideCombineTxWithRxFilteredAudio_44808.UIName;
			}
		}

		// Token: 0x17001778 RID: 6008
		// (get) Token: 0x06002F03 RID: 12035 RVA: 0x002E3A68 File Offset: 0x002E1C68
		// (set) Token: 0x06002F04 RID: 12036 RVA: 0x002E3B20 File Offset: 0x002E1D20
		internal bool RadWideCombineTxWithRxFilteredAudio_44808_HiddenStatic
		{
			get
			{
				short num = (short)301472370;
				short num2 = num;
				num = (short)2122127986;
				switch (num2 == num)
				{
				}
				num = (short)1401290752;
				if (num != 0)
				{
				}
				num = (short)490340352;
				short num3 = num;
				num = (short)1203175425;
				if (num != 0)
				{
				}
				return this.radWideCombineTxWithRxFilteredAudio_44808.HiddenStatic;
			}
			set
			{
				short num = (short)1476247350;
				short num2 = num;
				num = (short)1985462070;
				switch (num2 == num)
				{
				}
				num = (short)1545928705;
				if (num != 0)
				{
				}
				num = (short)1361838080;
				short num3 = num;
				num = (short)1963786240;
				if (num != 0)
				{
				}
				this.radWideCombineTxWithRxFilteredAudio_44808.HiddenStatic = value;
			}
		}

		// Token: 0x17001779 RID: 6009
		// (get) Token: 0x06002F05 RID: 12037 RVA: 0x002E3BD4 File Offset: 0x002E1DD4
		// (set) Token: 0x06002F06 RID: 12038 RVA: 0x002E3C84 File Offset: 0x002E1E84
		internal bool RadWideCombineTxWithRxFilteredAudio_44808_HiddenDynamic
		{
			get
			{
				short num = (short)463379596;
				short num2 = num;
				num = (short)56335500;
				switch (num2 == num)
				{
				}
				num = (short)2062155776;
				if (num != 0)
				{
				}
				num = (short)1245577216;
				short num3 = num;
				num = (short)733675521;
				if (num != 0)
				{
				}
				return this.radWideCombineTxWithRxFilteredAudio_44808.HiddenDynamic;
			}
			set
			{
				short num = (short)1847032870;
				short num2 = num;
				num = (short)1540127782;
				switch (num2 == num)
				{
				}
				num = (short)183959552;
				if (num != 0)
				{
				}
				num = (short)27066368;
				short num3 = num;
				num = (short)2047934465;
				if (num != 0)
				{
				}
				this.radWideCombineTxWithRxFilteredAudio_44808.HiddenDynamic = value;
			}
		}

		// Token: 0x1700177A RID: 6010
		// (get) Token: 0x06002F07 RID: 12039 RVA: 0x002E3D38 File Offset: 0x002E1F38
		public bool RadWideCombineTxWithRxFilteredAudio_44808_HasDiffs
		{
			get
			{
				short num = (short)373445923;
				short num2 = num;
				num = (short)909399331;
				switch (num2 == num)
				{
				}
				num = (short)937492481;
				if (num != 0)
				{
				}
				num = (short)1895038976;
				short num3 = num;
				num = (short)636813312;
				if (num != 0)
				{
				}
				return this.radWideCombineTxWithRxFilteredAudio_44808._HasDiffs;
			}
		}

		// Token: 0x1700177B RID: 6011
		// (get) Token: 0x06002F08 RID: 12040 RVA: 0x002E3DEC File Offset: 0x002E1FEC
		// (set) Token: 0x06002F09 RID: 12041 RVA: 0x002E3EA0 File Offset: 0x002E20A0
		public bool RadWideAudioOptionsSelectBluetoothMicForAuxPTTAudioSource_44819Value
		{
			get
			{
				short num = (short)1042324943;
				short num2 = num;
				num = (short)993697231;
				switch (num2 == num)
				{
				}
				num = (short)843579392;
				if (num != 0)
				{
				}
				num = (short)57606144;
				short num3 = num;
				num = (short)1537671169;
				if (num != 0)
				{
				}
				return this.radWideAudioOptionsSelectBluetoothMicForAuxPTTAudioSource_44819.Value;
			}
			set
			{
				short num = (short)609419265;
				if (num != 0)
				{
				}
				num = (short)121909258;
				short num2 = num;
				num = (short)854601738;
				switch (num2 == num)
				{
				}
				num = (short)1497497600;
				short num3 = num;
				num = (short)97058816;
				if (num != 0)
				{
				}
				this.radWideAudioOptionsSelectBluetoothMicForAuxPTTAudioSource_44819.Value = value;
			}
		}

		// Token: 0x1700177C RID: 6012
		// (get) Token: 0x06002F0A RID: 12042 RVA: 0x002E3F58 File Offset: 0x002E2158
		public global::AcpBusinessLayer.AcpField<bool> RadWideAudioOptionsSelectBluetoothMicForAuxPTTAudioSource_44819
		{
			get
			{
				short num = (short)2117402625;
				if (num != 0)
				{
				}
				num = (short)213482377;
				short num2 = num;
				num = (short)836926345;
				switch (num2 == num)
				{
				}
				num = (short)1640759296;
				short num3 = num;
				num = (short)1480523776;
				if (num != 0)
				{
				}
				return this.radWideAudioOptionsSelectBluetoothMicForAuxPTTAudioSource_44819;
			}
		}

		// Token: 0x1700177D RID: 6013
		// (get) Token: 0x06002F0B RID: 12043 RVA: 0x002E4008 File Offset: 0x002E2208
		// (set) Token: 0x06002F0C RID: 12044 RVA: 0x002E40BC File Offset: 0x002E22BC
		public bool RadWideAudioOptionsSelectBluetoothMicForAuxPTTAudioSource_44819_UIValue
		{
			get
			{
				short num = (short)2036484729;
				short num2 = num;
				num = (short)2127514233;
				switch (num2 == num)
				{
				}
				num = (short)1699479552;
				if (num != 0)
				{
				}
				num = (short)689438720;
				short num3 = num;
				num = (short)976683009;
				if (num != 0)
				{
				}
				return this.radWideAudioOptionsSelectBluetoothMicForAuxPTTAudioSource_44819.Value;
			}
			set
			{
				short num = (short)1204826200;
				short num2 = num;
				num = (short)994455640;
				switch (num2 == num)
				{
				}
				num = (short)2113208320;
				if (num != 0)
				{
				}
				num = (short)958332928;
				short num3 = num;
				num = (short)1944059905;
				if (num != 0)
				{
				}
				this.radWideAudioOptionsSelectBluetoothMicForAuxPTTAudioSource_44819.Value = value;
			}
		}

		// Token: 0x1700177E RID: 6014
		// (get) Token: 0x06002F0D RID: 12045 RVA: 0x002E4170 File Offset: 0x002E2370
		// (set) Token: 0x06002F0E RID: 12046 RVA: 0x002E4224 File Offset: 0x002E2424
		public bool RadWideAudioOptionsSelectBluetoothMicForAuxPTTAudioSource_44819_Applicable
		{
			get
			{
				short num = (short)1091417987;
				short num2 = num;
				num = (short)1763948419;
				switch (num2 == num)
				{
				}
				num = (short)1953431553;
				if (num != 0)
				{
				}
				num = (short)2113798144;
				short num3 = num;
				num = (short)649854976;
				if (num != 0)
				{
				}
				return this.radWideAudioOptionsSelectBluetoothMicForAuxPTTAudioSource_44819.Applicable;
			}
			set
			{
				short num = (short)1787686045;
				short num2 = num;
				num = (short)477359261;
				switch (num2 == num)
				{
				}
				num = (short)1546256384;
				if (num != 0)
				{
				}
				num = (short)1725431808;
				short num3 = num;
				num = (short)346685441;
				if (num != 0)
				{
				}
				this.radWideAudioOptionsSelectBluetoothMicForAuxPTTAudioSource_44819.Applicable = value;
			}
		}

		// Token: 0x1700177F RID: 6015
		// (get) Token: 0x06002F0F RID: 12047 RVA: 0x002E42DC File Offset: 0x002E24DC
		// (set) Token: 0x06002F10 RID: 12048 RVA: 0x002E4394 File Offset: 0x002E2594
		public bool RadWideAudioOptionsSelectBluetoothMicForAuxPTTAudioSource_44819_Valid
		{
			get
			{
				short num = (short)1661289532;
				short num2 = num;
				num = (short)669402172;
				switch (num2 == num)
				{
				}
				num = (short)1967521793;
				if (num != 0)
				{
				}
				num = (short)2072510464;
				short num3 = num;
				num = (short)1683881984;
				if (num != 0)
				{
				}
				return this.radWideAudioOptionsSelectBluetoothMicForAuxPTTAudioSource_44819.Valid;
			}
			set
			{
				short num = (short)558506438;
				short num2 = num;
				num = (short)193864134;
				switch (num2 == num)
				{
				}
				num = (short)573308928;
				if (num != 0)
				{
				}
				num = (short)1572864;
				short num3 = num;
				num = (short)1476657153;
				if (num != 0)
				{
				}
				this.radWideAudioOptionsSelectBluetoothMicForAuxPTTAudioSource_44819.Valid = value;
			}
		}

		// Token: 0x17001780 RID: 6016
		// (get) Token: 0x06002F11 RID: 12049 RVA: 0x002E4448 File Offset: 0x002E2648
		// (set) Token: 0x06002F12 RID: 12050 RVA: 0x002E44FC File Offset: 0x002E26FC
		public bool RadWideAudioOptionsSelectBluetoothMicForAuxPTTAudioSource_44819_Visible
		{
			get
			{
				short num = (short)154368123;
				short num2 = num;
				num = (short)2022537339;
				switch (num2 == num)
				{
				}
				num = (short)1935802369;
				if (num != 0)
				{
				}
				num = (short)470614016;
				short num3 = num;
				num = (short)285802496;
				if (num != 0)
				{
				}
				return this.radWideAudioOptionsSelectBluetoothMicForAuxPTTAudioSource_44819.Visible;
			}
			set
			{
				short num = (short)1316390069;
				short num2 = num;
				num = (short)1937015989;
				switch (num2 == num)
				{
				}
				num = (short)268042241;
				if (num != 0)
				{
				}
				num = (short)1989935104;
				short num3 = num;
				num = (short)1547829248;
				if (num != 0)
				{
				}
				this.radWideAudioOptionsSelectBluetoothMicForAuxPTTAudioSource_44819.Visible = value;
			}
		}

		// Token: 0x17001781 RID: 6017
		// (get) Token: 0x06002F13 RID: 12051 RVA: 0x002E45B0 File Offset: 0x002E27B0
		// (set) Token: 0x06002F14 RID: 12052 RVA: 0x002E4668 File Offset: 0x002E2868
		public bool RadWideAudioOptionsSelectBluetoothMicForAuxPTTAudioSource_44819_Editable
		{
			get
			{
				short num = (short)1153221810;
				short num2 = num;
				num = (short)1182450866;
				switch (num2 == num)
				{
				}
				num = (short)870973440;
				if (num != 0)
				{
				}
				num = (short)730726400;
				short num3 = num;
				num = (short)1853489153;
				if (num != 0)
				{
				}
				return this.radWideAudioOptionsSelectBluetoothMicForAuxPTTAudioSource_44819.Editable;
			}
			set
			{
				short num = (short)816966060;
				short num2 = num;
				num = (short)1346169260;
				switch (num2 == num)
				{
				}
				num = (short)942931969;
				if (num != 0)
				{
				}
				num = (short)861405184;
				short num3 = num;
				num = (short)387579904;
				if (num != 0)
				{
				}
				this.radWideAudioOptionsSelectBluetoothMicForAuxPTTAudioSource_44819.Editable = value;
			}
		}

		// Token: 0x17001782 RID: 6018
		// (get) Token: 0x06002F15 RID: 12053 RVA: 0x002E4720 File Offset: 0x002E2920
		internal string RadWideAudioOptionsSelectBluetoothMicForAuxPTTAudioSource_44819_UILabel
		{
			get
			{
				short num = (short)161611777;
				if (num != 0)
				{
				}
				num = (short)1863230847;
				short num2 = num;
				num = (short)526493055;
				switch (num2 == num)
				{
				}
				num = (short)1864761344;
				short num3 = num;
				num = (short)1533870080;
				if (num != 0)
				{
				}
				return this.radWideAudioOptionsSelectBluetoothMicForAuxPTTAudioSource_44819.UIName;
			}
		}

		// Token: 0x17001783 RID: 6019
		// (get) Token: 0x06002F16 RID: 12054 RVA: 0x002E47D0 File Offset: 0x002E29D0
		// (set) Token: 0x06002F17 RID: 12055 RVA: 0x002E4884 File Offset: 0x002E2A84
		internal bool RadWideAudioOptionsSelectBluetoothMicForAuxPTTAudioSource_44819_HiddenStatic
		{
			get
			{
				short num = (short)79603760;
				short num2 = num;
				num = (short)390572080;
				switch (num2 == num)
				{
				}
				num = (short)467337217;
				if (num != 0)
				{
				}
				num = (short)2138374144;
				short num3 = num;
				num = (short)371785728;
				if (num != 0)
				{
				}
				return this.radWideAudioOptionsSelectBluetoothMicForAuxPTTAudioSource_44819.HiddenStatic;
			}
			set
			{
				short num = (short)783701612;
				short num2 = num;
				num = (short)294475372;
				switch (num2 == num)
				{
				}
				num = (short)576716801;
				if (num != 0)
				{
				}
				num = (short)802488320;
				short num3 = num;
				num = (short)2116354048;
				if (num != 0)
				{
				}
				this.radWideAudioOptionsSelectBluetoothMicForAuxPTTAudioSource_44819.HiddenStatic = value;
			}
		}

		// Token: 0x17001784 RID: 6020
		// (get) Token: 0x06002F18 RID: 12056 RVA: 0x002E4938 File Offset: 0x002E2B38
		// (set) Token: 0x06002F19 RID: 12057 RVA: 0x002E49F0 File Offset: 0x002E2BF0
		internal bool RadWideAudioOptionsSelectBluetoothMicForAuxPTTAudioSource_44819_HiddenDynamic
		{
			get
			{
				short num = (short)15476742;
				short num2 = num;
				num = (short)1027549190;
				switch (num2 == num)
				{
				}
				num = (short)770113536;
				if (num != 0)
				{
				}
				num = (short)776929280;
				short num3 = num;
				num = (short)912654337;
				if (num != 0)
				{
				}
				return this.radWideAudioOptionsSelectBluetoothMicForAuxPTTAudioSource_44819.HiddenDynamic;
			}
			set
			{
				short num = (short)1831842370;
				short num2 = num;
				num = (short)1179300418;
				switch (num2 == num)
				{
				}
				num = (short)2032205824;
				if (num != 0)
				{
				}
				num = (short)495124480;
				short num3 = num;
				num = (short)672989185;
				if (num != 0)
				{
				}
				this.radWideAudioOptionsSelectBluetoothMicForAuxPTTAudioSource_44819.HiddenDynamic = value;
			}
		}

		// Token: 0x17001785 RID: 6021
		// (get) Token: 0x06002F1A RID: 12058 RVA: 0x002E4AA8 File Offset: 0x002E2CA8
		public bool RadWideAudioOptionsSelectBluetoothMicForAuxPTTAudioSource_44819_HasDiffs
		{
			get
			{
				short num = (short)714503956;
				short num2 = num;
				num = (short)1034450708;
				switch (num2 == num)
				{
				}
				num = (short)147324929;
				if (num != 0)
				{
				}
				num = (short)1759379456;
				short num3 = num;
				num = (short)1752563712;
				if (num != 0)
				{
				}
				return this.radWideAudioOptionsSelectBluetoothMicForAuxPTTAudioSource_44819._HasDiffs;
			}
		}

		// Token: 0x06002F1B RID: 12059 RVA: 0x002E4B5C File Offset: 0x002E2D5C
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
					goto IL_5B;
				case 1:
					return result;
				case 2:
				{
					if (base.ParentRecset.ContainerDoc == null)
					{
						return result;
					}
					num2 = (short)1458503680;
					short num3 = num2;
					num2 = (short)941835274;
					short num4 = num2;
					num2 = (short)870728714;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_5B;
					default:
						num2 = (short)2116026369;
						if (num2 != 0)
						{
						}
						num2 = (short)1154416640;
						if (num2 != 0)
						{
						}
						num2 = (short)1384054784;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 3:
					if (base.ParentRecset != null)
					{
						num2 = (short)235995140;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 4:
					num2 = (short)1377566722;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_24;
				IL_5B:
				result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
				num2 = (short)126353409;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)952762371;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06002F1C RID: 12060 RVA: 0x002E4CCC File Offset: 0x002E2ECC
		private void b(global::System.Runtime.Serialization.SerializationInfo A_0, global::System.Runtime.Serialization.StreamingContext A_1)
		{
			short num = (short)212039940;
			short num2 = num;
			num = (short)227178756;
			switch (num2 == num)
			{
			}
			num = (short)146735104;
			if (num != 0)
			{
			}
			num = (short)387842049;
			if (num != 0)
			{
			}
			num = (short)672006144;
			short num3 = num;
			this.a(A_0, A_1);
		}

		// Token: 0x06002F1D RID: 12061 RVA: 0x002E4D80 File Offset: 0x002E2F80
		private void a(global::System.Runtime.Serialization.SerializationInfo A_0, global::System.Runtime.Serialization.StreamingContext A_1)
		{
			int a_ = 3;
			short num = (short)245039105;
			if (num != 0)
			{
			}
			int radWideLabtoolDigitalAnalogBalance_A7851Value = this.RadWideLabtoolDigitalAnalogBalance_A7851Value;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_6D;
				}
				int num2;
				string text;
				for (;;)
				{
					IL_43:
					switch (num2)
					{
					case 0:
						if (text == global::AllFeatures.CodeplugGuid.b("苃Ʂ꓇막꧋", a_))
						{
							num = (short)1113128964;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1F1;
					case 1:
						goto IL_1F1;
					case 2:
						goto IL_208;
					case 3:
						goto IL_184;
					case 4:
						this.RadWideLabtoolDigitalAnalogBalance_A7851Value = 0;
						num = (short)1485504515;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (text == global::AllFeatures.CodeplugGuid.b("郃듅뷇꿉", a_))
						{
							num = (short)1137377288;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)624885760;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						num = (short)480706565;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (this.RadWideLabtoolDigitalAnalogBalance_A7851_UIValue != text)
						{
							num = (short)1398407174;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1F1;
					case 8:
					{
						num = (short)196279537;
						short num3 = num;
						num = (short)77266161;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_184;
						default:
							num = (short)1040580608;
							if (num != 0)
							{
							}
							this.RadWideLabtoolDigitalAnalogBalance_A7851Value = 1;
							num = (short)261423105;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					goto IL_6D;
					IL_1F1:
					num = (short)870187010;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_184:
					goto IL_1F1;
				}
				IL_208:
				goto IL_20D;
				IL_6D:
				text = (string)A_0.GetValue(global::AllFeatures.CodeplugGuid.b("郃뻅軉ꗋ꧍맏ꛑ뗓뫕ﳛ鿝軟菡裣觥迧쫩껫迭鳯鏱髳闵鷷", a_), typeof(string));
				num = (short)1867448327;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_43;
			}
			catch (global::System.Exception)
			{
			}
			IL_20D:
			num = (short)1694236672;
			short num4 = num;
		}

		// Token: 0x0400114F RID: 4431
		private global::AcpBusinessLayer.AcpListField radWideAdvancedAuxPTTAudioSource_A7529;

		// Token: 0x04001150 RID: 4432
		private global::AcpBusinessLayer.AcpListField advancedAuxTransmitSensitivity_A7530;

		// Token: 0x04001151 RID: 4433
		private global::AcpBusinessLayer.AcpField<bool> radWideRxAudioControlMidrangeEqualization_A8508;

		// Token: 0x04001152 RID: 4434
		private global::AcpBusinessLayer.AcpField<bool> radWideDigitalAudioOptionsStrongInterference2_A9206;

		// Token: 0x04001153 RID: 4435
		private global::AcpBusinessLayer.AcpField<bool> radWideDigitalAudioOptionsStrongInterference1_A9207;

		// Token: 0x04001154 RID: 4436
		private global::AcpBusinessLayer.AcpField<bool> radWideDigitalAudioOptionsWeakSignalFringe_A9678;

		// Token: 0x04001155 RID: 4437
		private global::AcpBusinessLayer.AcpField<bool> radWideDigitalAudioOptionsWeakSignalFringe_A9679;

		// Token: 0x04001156 RID: 4438
		private global::AcpBusinessLayer.AcpFieldX<bool, bool> radWideLabtoolMultipleConversationDisable_A19552;

		// Token: 0x04001157 RID: 4439
		private global::AcpBusinessLayer.AcpListField radWideLabtoolDigitalAnalogBalance_A7851;

		// Token: 0x04001158 RID: 4440
		private global::AcpBusinessLayer.AcpListField radWideAudioConfigurationLevel_42740;

		// Token: 0x04001159 RID: 4441
		private global::AcpBusinessLayer.AcpField<bool> radWideCombineTxWithRxFilteredAudio_44808;

		// Token: 0x0400115A RID: 4442
		private global::AcpBusinessLayer.AcpField<bool> radWideAudioOptionsSelectBluetoothMicForAuxPTTAudioSource_44819;
	}
}
