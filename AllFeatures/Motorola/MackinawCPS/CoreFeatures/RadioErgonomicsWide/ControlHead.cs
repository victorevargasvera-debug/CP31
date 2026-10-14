using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using ConstraintHelper;
using Motorola.MackinawCPS.CoreFeatures.DVRSWide;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;

namespace Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide
{
	// Token: 0x0200021E RID: 542
	[global::System.Serializable]
	public class ControlHead : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600640D RID: 25613 RVA: 0x0059D06C File Offset: 0x0059B26C
		public ControlHead(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.ControlHeadAliasListInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x0600640E RID: 25614 RVA: 0x0059D0AC File Offset: 0x0059B2AC
		protected ControlHead(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600640F RID: 25615 RVA: 0x0059D0C4 File Offset: 0x0059B2C4
		public override void Init()
		{
			int a_ = 13;
			short num = (short)1185958344;
			short num2 = num;
			num = (short)793987528;
			switch (num2 == num)
			{
			}
			num = (short)1242431489;
			if (num != 0)
			{
			}
			num = (short)1170407424;
			short num3 = num;
			num = (short)911081472;
			if (num != 0)
			{
			}
			this.radErgoWideControlHeadControlHeadVIPInputSource_A7724 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑釓ꓕ뿗뗙诛럝蓟蟡꟣觥蛧黩黫臭鳯뫱釳韵鳷맹鏻都瓿瀁欃樅䀇漉洋樍䘏嬑䐓引瘗標椛樝猟䴡儣吥䬧伩猫漭ܯԱسȵ", a_), global::CommonResources.AcgResources.ID_CONTROLHEADVIPINPUTSOURCE, new string[]
			{
				global::CommonResources.AcgResources.ID_NONE
			}, new int[1], true, true);
			this.radErgoWideControlHeadControlHeadVIPInputSource_A7724.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radErgoWideControlHeadControlHeadVIPInputSource_A7724.DataTransferOrder = 39;
			this.radErgoWideControlHeadControlHeadsRequiredforPowerUp_A7725 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑釓ꓕ뿗뗙诛럝蓟蟡꟣觥蛧黩黫臭鳯뫱釳韵鳷맹鏻都瓿瀁欃樅䀇漉洋樍挏䀑焓朕洗猙減笝䐟䐡䬣吥砧䔩嬫䬭䈯朱䐳椵礷ഹ଻ఽ甿", a_), global::CommonResources.AcgResources.ID_CONTROLHEADSREQUIREDFORPOWERUP);
			this.radErgoWideControlHeadControlHeadsRequiredforPowerUp_A7725.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radErgoWideControlHeadControlHeadsRequiredforPowerUp_A7725.DataTransferOrder = 4;
			this.radErgoWideControlHeadExpectedNumofControlHeads_A7982 = new global::AcpBusinessLayer.AcpSparseLOVField(1, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.LOVs.indexRadErgoWideControlHeadExpectedNumofControlHeads_A7982LovStrs, global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.LOVs.idRadErgoWideControlHeadExpectedNumofControlHeads_A7982LovStrs), this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑釓ꓕ뿗뗙诛럝蓟蟡꟣觥蛧黩黫臭鳯뫱釳韵鳷뿹蓻軽旿愁瀃挅氇䐉礋挍缏琑圓礕瘗渙減焝䰟模䄣䜥䰧天猫漭ܯ଱ళе", a_), global::CommonResources.AcgResources.ID_EXPECTEDNUMOFCONTROLHEADS, global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.LOVs.RadErgoWideControlHeadExpectedNumofControlHeads_A7982LovStrs);
			this.radErgoWideControlHeadExpectedNumofControlHeads_A7982.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radErgoWideControlHeadExpectedNumofControlHeads_A7982.DataTransferOrder = 38;
			this.radErgoWideControlHeadIntercomTimeoutTimersec_A8297 = new global::AcpBusinessLayer.AcpSimpleRangeField(0, this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑釓ꓕ뿗뗙诛럝蓟蟡꟣觥蛧黩黫臭鳯뫱釳韵鳷돹鋻諽旿瀁會椅攇帉攋挍甏紑愓戕䰗猙焛笝刟儡䄣䔥眧欩ᐫᰭयԱ", a_), global::CommonResources.AcgResources.ID_INTERCOMTIMEOUTTIMERSEC, 0, 12, global::CommonResources.AcgResources.ID_DISABLED, null, 0, 10);
			this.radErgoWideControlHeadIntercomTimeoutTimersec_A8297.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radErgoWideControlHeadIntercomTimeoutTimersec_A8297.DataTransferOrder = 43;
			this.radErgoWideControlHeadIntercomTimeoutTimersec_A8297.ShowHexValue = false;
			this.radErgoWideControlHeadMultiControlHead_A8550 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑釓ꓕ뿗뗙诛럝蓟蟡꟣觥蛧黩黫臭鳯뫱釳韵鳷럹觻鋽瓿欁䜃椅昇縉縋愍簏娑焓眕簗䔙崛☝ᔟᜡᐣ", a_), global::CommonResources.AcgResources.ID_MULTICONTROLHEAD);
			this.radErgoWideControlHeadMultiControlHead_A8550.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radErgoWideControlHeadMultiControlHead_A8550.DataTransferOrder = 14;
			this.radErgoWideControlHeadMultipleControlHeadStyle_A8561 = new global::AcpBusinessLayer.AcpListField(1, this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑釓ꓕ뿗뗙诛럝蓟蟡꟣觥蛧黩黫臭鳯뫱釳韵鳷럹觻鋽瓿欁球樅洇䤉挋怍搏怑笓稕倗缙紛稝猟嘡崣䨥䴧甩洫ᘭԯбԳ", a_), global::CommonResources.AcgResources.ID_MULTIPLECONTROLHEADSTYLE, global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.LOVs.RadErgoWideControlHeadMultipleControlHeadStyle_A8561LovStrs);
			this.radErgoWideControlHeadMultipleControlHeadStyle_A8561.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radErgoWideControlHeadMultipleControlHeadStyle_A8561.DataTransferOrder = 37;
			this.radErgoWideControlHeadRemoteMicSource_A8930 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑釓ꓕ뿗뗙诛럝蓟蟡꟣觥蛧黩黫臭鳯뫱釳韵鳷꣹駻鏽濿瘁愃䬅愇椉弋愍攏怑眓猕䜗嬙␛✝ጟሡ", a_), global::CommonResources.AcgResources.ID_REMOTEMICSOURCE, new string[]
			{
				global::CommonResources.AcgResources.ID_DISABLED
			}, new int[1], true, true);
			this.radErgoWideControlHeadRemoteMicSource_A8930.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radErgoWideControlHeadRemoteMicSource_A8930.DataTransferOrder = 42;
			this.radErgoWideControlHeadTransceiverDEKDimControl_A9404 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑釓ꓕ뿗뗙诛럝蓟蟡꟣觥蛧黩黫臭鳯뫱釳韵鳷껹軻鿽滿焁會挅愇簉椋簍吏圑弓刕焗眙弛焝丟嘡嘣䤥䐧甩洫ᜭЯȱ3", a_), global::CommonResources.AcgResources.ID_TRANSCEIVERDEKDIMCONTROL, new string[]
			{
				global::CommonResources.AcgResources.ID_DISABLED
			}, new int[1], true, true);
			this.radErgoWideControlHeadTransceiverDEKDimControl_A9404.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radErgoWideControlHeadTransceiverDEKDimControl_A9404.DataTransferOrder = 41;
			this.radErgoWideControlHeadTransceiverVolumeControl_A9405 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑釓ꓕ뿗뗙诛럝蓟蟡꟣觥蛧黩黫臭鳯뫱釳韵鳷껹軻鿽滿焁會挅愇簉椋簍䘏紑砓挕甗缙弛焝丟嘡嘣䤥䐧甩洫ᜭЯȱĳ", a_), global::CommonResources.AcgResources.ID_TRANSCEIVERVOLUMECONTROL, new string[]
			{
				global::CommonResources.AcgResources.ID_DISABLED
			}, new int[1], true, true);
			this.radErgoWideControlHeadTransceiverVolumeControl_A9405.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radErgoWideControlHeadTransceiverVolumeControl_A9405.DataTransferOrder = 40;
			this.radErgoWideControlHeadAggregateCableLength_A38456 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑釓ꓕ뿗뗙诛럝蓟蟡꟣觥蛧黩黫臭鳯뫱釳韵鳷믹鯻駽狿朁挃朅簇漉伋漍爏縑焓娕紗琙笛樝䠟紡攣ᔥဧḩᤫᠭ", a_), global::CommonResources.AcgResources.ID_AGGREGATECABLELENGTH, global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.LOVs.RadErgoWideControlHeadAggregateCableLength_A38456LovStrs);
			this.radErgoWideControlHeadAggregateCableLength_A38456.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.radErgoWideControlHeadAggregateCableLength_A38456.DataTransferOrder = 34;
			this.radErgoWideControlHeadMulCHTxAudioRouting_A38459 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑釓ꓕ뿗뗙诛럝蓟蟡꟣觥蛧黩黫臭鳯뫱釳韵鳷럹觻鋽䏿䨁倃縅䤇缉栋服缏䀑笓挕気猙爛礝缟挡ᜣḥᰧἩᔫ", a_), global::CommonResources.AcgResources.ID_MULTICHTXAUDIOROUTING);
			this.radErgoWideControlHeadMulCHTxAudioRouting_A38459.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radErgoWideControlHeadMulCHTxAudioRouting_A38459.DataTransferOrder = 67;
			this.radErgoWideControlHeadBluetoothControl_44820 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑釓ꓕ뿗뗙诛럝蓟蟡꟣觥蛧黩黫臭鳯뫱釳韵鳷룹郻诽旿瘁欃椅簇戉伋愍縏昑易礕琗䔙⠛⨝᠟အᐣ", a_), global::CommonResources.AcgResources.ID_BLUETOOTHCONTROL, new string[]
			{
				global::CommonResources.AcgResources.ID_NONE
			}, new int[1], true, true);
			this.radErgoWideControlHeadBluetoothControl_44820.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radErgoWideControlHeadBluetoothControl_44820.DataTransferOrder = 134;
			this.radErgoWideControlHeadPowerUpBrightness = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑釓ꓕ뿗뗙诛럝蓟蟡꟣觥蛧黩黫臭鳯뫱釳韵鳷꫹鏻觽旿瀁儃瘅䨇砉攋植砏昑稓猕欗椙", a_), global::CommonResources.AcgResources.ID_CONTROL_HEAD_POWERUP_BRIGHTNESS, global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.LOVs.RadErgoWideControlHeadPowerUpBrightnessLovStrs);
			this.radErgoWideControlHeadPowerUpBrightness.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.radErgoWideControlHeadPowerUpBrightness.DataTransferOrder = 35;
			this.radioErgoWideControlHeadBlockDarkestDimLevel = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑뷓맕鷗꣙믛뇝럟诡胣菥ꯧ藩苫髭苯鷱飳뻵鷷鯹飻볽泿洁會洅䰇欉縋攍甏愑怓刕焗眙倛笝嘟䜡䠣", a_), global::CommonResources.AcgResources.ID_BLOCKDARKESTDIMLEVEL);
			this.radioErgoWideControlHeadBlockDarkestDimLevel.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radioErgoWideControlHeadBlockDarkestDimLevel.DataTransferOrder = 135;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("跍뿏병ꃓꓕ럗뛙ﳛ雝藟菡胣", a_);
			base.Id = 10223;
			base.UIName = global::CommonResources.AcgResources.ID_CONTROLHEAD;
			base.DataTransferOrder = 2;
		}

		// Token: 0x06006410 RID: 25616 RVA: 0x0059D570 File Offset: 0x0059B770
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 17;
			short num = (short)731512849;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_3D3;
				case 1:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("胑뗓닕鷗꣙믛뇝럟诡胣菥ꯧ藩苫髭苯鷱飳뻵鷷鯹飻곽旿漁欃爅洇䜉攋洍䌏紑愓搕笗缙䌛弝᠟ᬡᜣᘥ", a_)))
					{
						num = (short)2002059280;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_384;
				case 2:
					this.radErgoWideControlHeadMultiControlHead_A8550 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("胑뗓닕鷗꣙믛뇝럟诡胣菥ꯧ藩苫髭苯鷱飳뻵鷷鯹飻돽痿渁瀃漅䬇攉戋稍戏紑砓帕紗笙砛䄝感ᨡᄣጥᠧ", a_), global::CommonResources.AcgResources.ID_MULTICONTROLHEAD);
					this.radErgoWideControlHeadMultiControlHead_A8550.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radErgoWideControlHeadMultiControlHead_A8550.DataTransferOrder = 14;
					num = (short)217382921;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_6F6;
				case 4:
					if (producerFields != null)
					{
						num = (short)1813577769;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_B6A;
				case 5:
					goto IL_7EE;
				case 6:
					this.radErgoWideControlHeadTransceiverDEKDimControl_A9404 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("胑뗓닕鷗꣙믛뇝럟诡胣菥ꯧ藩苫髭苯鷱飳뻵鷷鯹飻꫽狿持樃甅欇漉攋砍甏怑倓匕北帙甛猝挟䴡䨣別娧䔩䀫焭焯଱3صష", a_), global::CommonResources.AcgResources.ID_TRANSCEIVERDEKDIMCONTROL, new string[]
					{
						global::CommonResources.AcgResources.ID_DISABLED
					}, new int[1], true, true);
					this.radErgoWideControlHeadTransceiverDEKDimControl_A9404.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radErgoWideControlHeadTransceiverDEKDimControl_A9404.DataTransferOrder = 41;
					num = (short)1740767237;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("胑뗓닕鷗꣙믛뇝럟诡胣菥ꯧ藩苫髭苯鷱飳뻵鷷鯹飻돽痿渁瀃漅砇昉椋䴍缏簑怓搕眗瘙君笝䄟䘡眣別儧䘩䤫焭焯਱ĳ5ष", a_)))
					{
						num = (short)409403393;
						if (num != 0)
						{
						}
						num = (short)1043005483;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_9AF;
				case 8:
					this.radErgoWideControlHeadIntercomTimeoutTimersec_A8297 = new global::AcpBusinessLayer.AcpSimpleRangeField(0, this, global::AllFeatures.CodeplugGuid.b("胑뗓닕鷗꣙믛뇝럟诡胣菥ꯧ藩苫髭苯鷱飳뻵鷷鯹飻럽滿瘁愃琅欇攉愋娍礏缑焓礕洗渙䠛眝䴟䜡嘣唥䴧䤩猫漭࠯1ളĵ", a_), global::CommonResources.AcgResources.ID_INTERCOMTIMEOUTTIMERSEC, global::CommonResources.AcgResources.ID_DISABLED, null, 0, 10);
					this.radErgoWideControlHeadIntercomTimeoutTimersec_A8297.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radErgoWideControlHeadIntercomTimeoutTimersec_A8297.DataTransferOrder = 43;
					this.radErgoWideControlHeadIntercomTimeoutTimersec_A8297.ShowHexValue = false;
					num = (short)973537317;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					goto IL_4C6;
				case 10:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("胑뗓닕鷗꣙믛뇝럟诡胣菥ꯧ藩苫髭苯鷱飳뻵鷷鯹飻볽泿省愃爅朇攉砋昍匏紑稓戕樗甙瀛䄝ᐟᘡᰣᐥᠧ", a_)))
					{
						num = (short)81526810;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_420;
				case 11:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("胑뗓닕鷗꣙믛뇝럟诡胣菥ꯧ藩苫髭苯鷱飳뻵鷷鯹飻럽滿瘁愃琅欇攉愋娍礏缑焓礕洗渙䠛眝䴟䜡嘣唥䴧䤩猫漭࠯1ളĵ", a_)))
					{
						num = (short)236912648;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_65B;
				case 12:
					goto IL_4C1;
				case 13:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("胑뗓닕鷗꣙믛뇝럟诡胣菥ꯧ藩苫髭苯鷱飳뻵鷷鯹飻돽痿渁瀃漅䬇攉戋稍戏紑砓帕紗笙砛䄝感ᨡᄣጥᠧ", a_)))
					{
						num = (short)2117533698;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4C6;
				case 14:
					goto IL_AB3;
				case 15:
					this.radErgoWideControlHeadAggregateCableLength_A38456 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("胑뗓닕鷗꣙믛뇝럟诡胣菥ꯧ藩苫髭苯鷱飳뻵鷷鯹飻뿽柿攁瘃挅漇欉砋欍匏猑瘓稕紗嘙礛瀝䜟嘡䰣礥椧ᤩᐫᨭԯб", a_), global::CommonResources.AcgResources.ID_AGGREGATECABLELENGTH, global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.LOVs.RadErgoWideControlHeadAggregateCableLength_A38456LovStrs);
					this.radErgoWideControlHeadAggregateCableLength_A38456.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.radErgoWideControlHeadAggregateCableLength_A38456.DataTransferOrder = 34;
					num = (short)810024963;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
					this.radErgoWideControlHeadRemoteMicSource_A8930 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("胑뗓닕鷗꣙믛뇝럟诡胣菥ꯧ藩苫髭苯鷱飳뻵鷷鯹飻곽旿漁欃爅洇䜉攋洍䌏紑愓搕笗缙䌛弝᠟ᬡᜣᘥ", a_), global::CommonResources.AcgResources.ID_REMOTEMICSOURCE, new string[]
					{
						global::CommonResources.AcgResources.ID_DISABLED
					}, new int[1], true, true);
					this.radErgoWideControlHeadRemoteMicSource_A8930.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radErgoWideControlHeadRemoteMicSource_A8930.DataTransferOrder = 42;
					num = (short)1802895388;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					switch (0)
					{
					case 0:
						goto IL_E7;
					}
					continue;
				case 18:
					this.radErgoWideControlHeadControlHeadVIPInputSource_A7724 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("胑뗓닕鷗꣙믛뇝럟诡胣菥ꯧ藩苫髭苯鷱飳뻵鷷鯹飻뷽濿氁瀃琅朇昉䐋欍焏瘑䈓引䠗匙爛渝唟嘡眣䤥崧堩伫䬭漯猱̳ĵ਷ู", a_), global::CommonResources.AcgResources.ID_CONTROLHEADVIPINPUTSOURCE, new string[]
					{
						global::CommonResources.AcgResources.ID_NONE
					}, new int[1], true, true);
					this.radErgoWideControlHeadControlHeadVIPInputSource_A7724.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radErgoWideControlHeadControlHeadVIPInputSource_A7724.DataTransferOrder = 39;
					num = (short)335478822;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 19:
					this.radErgoWideControlHeadControlHeadsRequiredforPowerUp_A7725 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("胑뗓닕鷗꣙믛뇝럟诡胣菥ꯧ藩苫髭苯鷱飳뻵鷷鯹飻뷽濿氁瀃琅朇昉䐋欍焏瘑朓䐕紗欙椛眝刟䜡䀣䀥䜧堩簫䄭䜯圱䘳挵䠷改紻ऽ眿灁煃", a_), global::CommonResources.AcgResources.ID_CONTROLHEADSREQUIREDFORPOWERUP);
					this.radErgoWideControlHeadControlHeadsRequiredforPowerUp_A7725.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radErgoWideControlHeadControlHeadsRequiredforPowerUp_A7725.DataTransferOrder = 4;
					num = (short)1403715615;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 20:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("胑뗓닕鷗꣙믛뇝럟诡胣菥ꯧ藩苫髭苯鷱飳뻵鷷鯹飻뷽濿氁瀃琅朇昉䐋欍焏瘑䈓引䠗匙爛渝唟嘡眣䤥崧堩伫䬭漯猱̳ĵ਷ู", a_)))
					{
						num = (short)865599506;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_28F;
				case 21:
					goto IL_9AF;
				case 22:
					this.radioErgoWideControlHeadBlockDarkestDimLevel = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("胑뗓닕뇗뗙駛곝蟟跡돣迥賧迩꿫臭黯蛱蛳駵铷당駻鿽擿䀁栃椅欇愉䠋漍戏礑焓攕気帙甛猝氟䜡刣䌥䐧", a_), global::CommonResources.AcgResources.ID_BLOCKDARKESTDIMLEVEL);
					this.radioErgoWideControlHeadBlockDarkestDimLevel.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radioErgoWideControlHeadBlockDarkestDimLevel.DataTransferOrder = 135;
					num = (short)1483735052;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 23:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("胑뗓닕뇗뗙駛곝蟟跡돣迥賧迩꿫臭黯蛱蛳駵铷당駻鿽擿䀁栃椅欇愉䠋漍戏礑焓攕気帙甛猝氟䜡刣䌥䐧", a_)))
					{
						num = (short)53149718;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_B6A;
				case 24:
				{
					if (!producerFields.Contains(global::AllFeatures.CodeplugGuid.b("胑뗓닕鷗꣙믛뇝럟诡胣菥ꯧ藩苫髭苯鷱飳뻵鷷鯹飻꫽狿持樃甅欇漉攋砍甏怑䈓礕琗漙焛笝挟䴡䨣別娧䔩䀫焭焯଱3صഷ", a_)))
					{
						goto IL_2DD;
					}
					num = (short)132040700;
					short num3 = num;
					num = (short)1900136444;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_4C6;
					default:
						num = (short)1550385152;
						if (num != 0)
						{
						}
						num = (short)304676904;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 25:
				{
					num = (short)945160192;
					short num4 = num;
					this.radErgoWideControlHeadExpectedNumofControlHeads_A7982 = new global::AcpBusinessLayer.AcpSparseLOVField(1, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.LOVs.indexRadErgoWideControlHeadExpectedNumofControlHeads_A7982LovStrs, global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.LOVs.idRadErgoWideControlHeadExpectedNumofControlHeads_A7982LovStrs), this, global::AllFeatures.CodeplugGuid.b("胑뗓닕鷗꣙믛뇝럟诡胣菥ꯧ藩苫髭苯鷱飳뻵鷷鯹飻믽磿爁愃攅簇漉栋䀍攏缑笓瀕嬗甙爛樝刟䴡䠣渥䴧䬩䠫崭漯猱̳༵7࠹", a_), global::CommonResources.AcgResources.ID_EXPECTEDNUMOFCONTROLHEADS, global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.LOVs.RadErgoWideControlHeadExpectedNumofControlHeads_A7982LovStrs);
					this.radErgoWideControlHeadExpectedNumofControlHeads_A7982.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radErgoWideControlHeadExpectedNumofControlHeads_A7982.DataTransferOrder = 38;
					num = (short)414711808;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 26:
					this.radErgoWideControlHeadBluetoothControl_44820 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("胑뗓닕鷗꣙믛뇝럟诡胣菥ꯧ藩苫髭苯鷱飳뻵鷷鯹飻볽泿省愃爅朇攉砋昍匏紑稓戕樗甙瀛䄝ᐟᘡᰣᐥᠧ", a_), global::CommonResources.AcgResources.ID_BLUETOOTHCONTROL, new string[]
					{
						global::CommonResources.AcgResources.ID_NONE
					}, new int[1], true, true);
					this.radErgoWideControlHeadBluetoothControl_44820.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radErgoWideControlHeadBluetoothControl_44820.DataTransferOrder = 134;
					num = (short)1104412708;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 27:
					this.radErgoWideControlHeadPowerUpBrightness = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("胑뗓닕鷗꣙믛뇝럟诡胣菥ꯧ藩苫髭苯鷱飳뻵鷷鯹飻껽濿甁愃琅崇稉下簍礏甑簓戕瘗缙漛洝", a_), global::CommonResources.AcgResources.ID_CONTROL_HEAD_POWERUP_BRIGHTNESS, global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.LOVs.RadErgoWideControlHeadPowerUpBrightnessLovStrs);
					this.radErgoWideControlHeadPowerUpBrightness.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.radErgoWideControlHeadPowerUpBrightness.DataTransferOrder = 35;
					num = (short)802881550;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 28:
					goto IL_384;
				case 29:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("胑뗓닕鷗꣙믛뇝럟诡胣菥ꯧ藩苫髭苯鷱飳뻵鷷鯹飻뷽濿氁瀃琅朇昉䐋欍焏瘑朓䐕紗欙椛眝刟䜡䀣䀥䜧堩簫䄭䜯圱䘳挵䠷改紻ऽ眿灁煃", a_)))
					{
						num = (short)838270995;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1D6;
				case 30:
					num = (short)216072196;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 31:
					goto IL_1D6;
				case 32:
					this.radErgoWideControlHeadMulCHTxAudioRouting_A38459 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("胑뗓닕鷗꣙믛뇝럟诡胣菥ꯧ藩苫髭苯鷱飳뻵鷷鯹飻돽痿渁䜃丅將爉䴋笍琏笑笓䐕眗漙栛眝丟䔡笣朥ᬧሩᠫᬭय", a_), global::CommonResources.AcgResources.ID_MULTICHTXAUDIOROUTING);
					this.radErgoWideControlHeadMulCHTxAudioRouting_A38459.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radErgoWideControlHeadMulCHTxAudioRouting_A38459.DataTransferOrder = 67;
					num = (short)139001891;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 33:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("胑뗓닕鷗꣙믛뇝럟诡胣菥ꯧ藩苫髭苯鷱飳뻵鷷鯹飻뿽柿攁瘃挅漇欉砋欍匏猑瘓稕紗嘙礛瀝䜟嘡䰣礥椧ᤩᐫᨭԯб", a_)))
					{
						num = (short)1594228751;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_6F6;
				case 34:
					goto IL_2DD;
				case 35:
					goto IL_6A9;
				case 36:
					goto IL_420;
				case 37:
					goto IL_65B;
				case 38:
					goto IL_28F;
				case 39:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("胑뗓닕鷗꣙믛뇝럟诡胣菥ꯧ藩苫髭苯鷱飳뻵鷷鯹飻꫽狿持樃甅欇漉攋砍甏怑倓匕北帙甛猝挟䴡䨣別娧䔩䀫焭焯଱3صష", a_)))
					{
						num = (short)506462214;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_7EE;
				case 40:
					this.radErgoWideControlHeadTransceiverVolumeControl_A9405 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("胑뗓닕鷗꣙믛뇝럟诡胣菥ꯧ藩苫髭苯鷱飳뻵鷷鯹飻꫽狿持樃甅欇漉攋砍甏怑䈓礕琗漙焛笝挟䴡䨣別娧䔩䀫焭焯଱3صഷ", a_), global::CommonResources.AcgResources.ID_TRANSCEIVERVOLUMECONTROL, new string[]
					{
						global::CommonResources.AcgResources.ID_DISABLED
					}, new int[1], true, true);
					this.radErgoWideControlHeadTransceiverVolumeControl_A9405.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radErgoWideControlHeadTransceiverVolumeControl_A9405.DataTransferOrder = 40;
					num = (short)1082982434;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 41:
					num = (short)1336213524;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 42:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("胑뗓닕鷗꣙믛뇝럟诡胣菥ꯧ藩苫髭苯鷱飳뻵鷷鯹飻돽痿渁䜃丅將爉䴋笍琏笑笓䐕眗漙栛眝丟䔡笣朥ᬧሩᠫᬭय", a_)))
					{
						num = (short)1392967712;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_6A9;
				case 43:
					this.radErgoWideControlHeadMultipleControlHeadStyle_A8561 = new global::AcpBusinessLayer.AcpListField(1, this, global::AllFeatures.CodeplugGuid.b("胑뗓닕鷗꣙믛뇝럟诡胣菥ꯧ藩苫髭苯鷱飳뻵鷷鯹飻돽痿渁瀃漅砇昉椋䴍缏簑怓搕眗瘙君笝䄟䘡眣別儧䘩䤫焭焯਱ĳ5ष", a_), global::CommonResources.AcgResources.ID_MULTIPLECONTROLHEADSTYLE, global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.LOVs.RadErgoWideControlHeadMultipleControlHeadStyle_A8561LovStrs);
					this.radErgoWideControlHeadMultipleControlHeadStyle_A8561.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radErgoWideControlHeadMultipleControlHeadStyle_A8561.DataTransferOrder = 37;
					num = (short)724500501;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 44:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("胑뗓닕鷗꣙믛뇝럟诡胣菥ꯧ藩苫髭苯鷱飳뻵鷷鯹飻믽磿爁愃攅簇漉栋䀍攏缑笓瀕嬗甙爛樝刟䴡䠣渥䴧䬩䠫崭漯猱̳༵7࠹", a_)))
					{
						num = (short)1729167385;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3D3;
				case 45:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("胑뗓닕鷗꣙믛뇝럟诡胣菥ꯧ藩苫髭苯鷱飳뻵鷷鯹飻껽濿甁愃琅崇稉下簍礏甑簓戕瘗缙漛洝", a_)))
					{
						num = (short)432996379;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_AB3;
				}
				IL_E7:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)740491294;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_1D6:
				num = (short)1497104428;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_28F:
				num = (short)3735581;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2DD:
				num = (short)919404577;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_384:
				num = (short)1905590311;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3D3:
				num = (short)1087176715;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_420:
				num = (short)1703018541;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_4C6:
				num = (short)1355153415;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_65B:
				num = (short)2004615181;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_6A9:
				num = (short)1389494282;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_6F6:
				num = (short)1547305002;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_7EE:
				num = (short)1315242008;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_9AF:
				num = (short)1598816257;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_AB3:
				num = (short)1909391383;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_4C1:
			IL_B6A:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("金믓룕곗꣙돛닝샟ꫡ臣蟥賧", a_);
			base.Id = 10223;
			base.UIName = global::CommonResources.AcgResources.ID_CONTROLHEAD;
			base.DataTransferOrder = 2;
		}

		// Token: 0x06006411 RID: 25617 RVA: 0x0059E118 File Offset: 0x0059C318
		public override void PopulateReferences()
		{
			short num = (short)1902804452;
			short num2 = num;
			num = (short)466255332;
			switch (num2 == num)
			{
			}
			num = (short)11993089;
			if (num != 0)
			{
			}
			num = (short)386269184;
			short num3 = num;
			num = (short)1302855680;
			if (num != 0)
			{
			}
			this.radErgoWideControlHeadControlHeadVIPInputSource_A7724.SetRecset(this.a(2033)[0][10223].EmbeddedRecset);
			this.radErgoWideControlHeadRemoteMicSource_A8930.SetRecset(this.a(2033)[0][10223].EmbeddedRecset);
			this.radErgoWideControlHeadTransceiverDEKDimControl_A9404.SetRecset(this.a(2033)[0][10223].EmbeddedRecset);
			this.radErgoWideControlHeadTransceiverVolumeControl_A9405.SetRecset(this.a(2033)[0][10223].EmbeddedRecset);
			this.radErgoWideControlHeadBluetoothControl_44820.SetRecset(this.a(2033)[0][10223].EmbeddedRecset);
		}

		// Token: 0x06006412 RID: 25618 RVA: 0x0059E29C File Offset: 0x0059C49C
		public override void DropReferences()
		{
			short num = (short)631602796;
			short num2 = num;
			num = (short)445808236;
			switch (num2 == num)
			{
			}
			num = (short)912654337;
			if (num != 0)
			{
			}
			num = (short)1845821440;
			short num3 = num;
			num = (short)484769792;
			if (num != 0)
			{
			}
		}

		// Token: 0x06006413 RID: 25619 RVA: 0x0059E348 File Offset: 0x0059C548
		public override void SetConstraints()
		{
			short num = (short)2110783489;
			if (num != 0)
			{
			}
			num = (short)759097129;
			short num2 = num;
			num = (short)833873705;
			switch (num2 == num)
			{
			}
			num = (short)1532035072;
			short num3 = num;
			num = (short)1023737856;
			if (num != 0)
			{
			}
			this.radErgoWideControlHeadControlHeadVIPInputSource_A7724.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWideConstraints.ConCHVIPInputSourceValidWhenCableLengthEnable);
			this.radErgoWideControlHeadControlHeadsRequiredforPowerUp_A7725.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWideConstraints.ConDualRadioSystemIsNOTSecondaryApp);
			this.radErgoWideControlHeadExpectedNumofControlHeads_A7982.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWideConstraints.ConMchNumCtrlHeadsValid);
			this.radErgoWideControlHeadIntercomTimeoutTimersec_A8297.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWideConstraints.conMultiCHIsEnabledAndMultiCHStyleIsAllActive);
			this.radErgoWideControlHeadMultiControlHead_A8550.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWideConstraints.ConRadErgoWideMCHApp);
			this.radErgoWideControlHeadMultiControlHead_A8550.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWideConstraints.ConRadErgoWideMCHValid);
			this.radErgoWideControlHeadMultipleControlHeadStyle_A8561.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWideConstraints.conMultiControlHeadIsEnabled);
			this.radErgoWideControlHeadRemoteMicSource_A8930.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWideConstraints.conMultiCHStyleIsAllActvAndMultiCHIsEnOrMultiCHIsDis);
			this.radErgoWideControlHeadRemoteMicSource_A8930.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWideConstraints.ConRemoteMicSourceValidWhenCableLengthEnable);
			this.radErgoWideControlHeadTransceiverDEKDimControl_A9404.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWideConstraints.ConTransceiverDEKDimControlValidWhenCableLengthEnable);
			this.radErgoWideControlHeadTransceiverVolumeControl_A9405.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWideConstraints.ConTransceiverVolControlValidWhenCableLengthEnable);
			this.radErgoWideControlHeadAggregateCableLength_A38456.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWideConstraints.ConAggregateCableLengthApp);
			this.radErgoWideControlHeadAggregateCableLength_A38456.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWideConstraints.ConAggregateCableLengthWhenDualRadioEnable);
			this.radErgoWideControlHeadMulCHTxAudioRouting_A38459.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWideConstraints.conMulCHTxAudioRootingValid);
			this.radErgoWideControlHeadBluetoothControl_44820.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWideConstraints.ConRadErgoWideControlHeadBluetoothControlApplicable);
			this.radErgoWideControlHeadPowerUpBrightness.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWideConstraints.ConDualRadioSystemIsNOTSecondaryAppAndBlockDarkestDimLevelNotEnable);
		}

		// Token: 0x06006414 RID: 25620 RVA: 0x0059E560 File Offset: 0x0059C760
		public override void SetupDependencies()
		{
			short num = (short)1472582739;
			short num2 = num;
			num = (short)2013516883;
			switch (num2 == num)
			{
			}
			num = (short)1608450049;
			if (num != 0)
			{
			}
			num = (short)1728774144;
			short num3 = num;
			num = (short)878182400;
			if (num != 0)
			{
			}
			this.radErgoWideControlHeadAggregateCableLength_A38456.AddDependentObject(this.radErgoWideControlHeadControlHeadVIPInputSource_A7724);
			this.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.AddDependentObject(this.radErgoWideControlHeadControlHeadVIPInputSource_A7724);
			this.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.AddDependentObject(this.radErgoWideControlHeadControlHeadsRequiredforPowerUp_A7725);
			this.radErgoWideControlHeadMultiControlHead_A8550.AddDependentObject(this.radErgoWideControlHeadExpectedNumofControlHeads_A7982);
			this.radErgoWideControlHeadMultipleControlHeadStyle_A8561.AddDependentObject(this.radErgoWideControlHeadExpectedNumofControlHeads_A7982);
			this.radErgoWideControlHeadAggregateCableLength_A38456.AddDependentObject(this.radErgoWideControlHeadExpectedNumofControlHeads_A7982);
			this.RefDVRSWide.General.RadErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911.AddDependentObject(this.radErgoWideControlHeadExpectedNumofControlHeads_A7982);
			this.radErgoWideControlHeadMultipleControlHeadStyle_A8561.AddDependentObject(this.radErgoWideControlHeadIntercomTimeoutTimersec_A8297);
			this.radErgoWideControlHeadMultiControlHead_A8550.AddDependentObject(this.radErgoWideControlHeadIntercomTimeoutTimersec_A8297);
			this.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.AddDependentObject(this.radErgoWideControlHeadMultiControlHead_A8550);
			this.radErgoWideControlHeadMultiControlHead_A8550.AddDependentObject(this.radErgoWideControlHeadMultipleControlHeadStyle_A8561);
			this.radErgoWideControlHeadMultipleControlHeadStyle_A8561.AddDependentObject(this.radErgoWideControlHeadRemoteMicSource_A8930);
			this.radErgoWideControlHeadMultiControlHead_A8550.AddDependentObject(this.radErgoWideControlHeadRemoteMicSource_A8930);
			this.radErgoWideControlHeadAggregateCableLength_A38456.AddDependentObject(this.radErgoWideControlHeadRemoteMicSource_A8930);
			this.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.AddDependentObject(this.radErgoWideControlHeadRemoteMicSource_A8930);
			this.radErgoWideControlHeadAggregateCableLength_A38456.AddDependentObject(this.radErgoWideControlHeadTransceiverDEKDimControl_A9404);
			this.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.AddDependentObject(this.radErgoWideControlHeadTransceiverDEKDimControl_A9404);
			this.radErgoWideControlHeadAggregateCableLength_A38456.AddDependentObject(this.radErgoWideControlHeadTransceiverVolumeControl_A9405);
			this.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.AddDependentObject(this.radErgoWideControlHeadTransceiverVolumeControl_A9405);
			this.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.AddDependentObject(this.radErgoWideControlHeadAggregateCableLength_A38456);
			this.radErgoWideControlHeadMultiControlHead_A8550.AddDependentObject(this.radErgoWideControlHeadMulCHTxAudioRouting_A38459);
			this.radErgoWideControlHeadMultipleControlHeadStyle_A8561.AddDependentObject(this.radErgoWideControlHeadMulCHTxAudioRouting_A38459);
			this.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.AddDependentObject(this.radErgoWideControlHeadPowerUpBrightness);
		}

		// Token: 0x170033D9 RID: 13273
		// (get) Token: 0x06006415 RID: 25621 RVA: 0x0059E800 File Offset: 0x0059CA00
		public global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.ControlHeadAliasListInner ControlHeadAliasListInnerSectionForRadErgoWideControlHeadControlHeadVIPInputSource_A7724
		{
			get
			{
				short num = (short)679256496;
				short num2 = num;
				num = (short)202547632;
				switch (num2 == num)
				{
				}
				num = (short)2078867457;
				if (num != 0)
				{
				}
				num = (short)1333067776;
				short num3 = num;
				num = (short)1779236864;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadControlHeadVIPInputSource_A7724.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.ControlHeadAliasListInner;
			}
		}

		// Token: 0x170033DA RID: 13274
		// (get) Token: 0x06006416 RID: 25622 RVA: 0x0059E8BC File Offset: 0x0059CABC
		public global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.ControlHeadAliasListInner ControlHeadAliasListInnerSectionForRadErgoWideControlHeadRemoteMicSource_A8930
		{
			get
			{
				short num = (short)1629660883;
				short num2 = num;
				num = (short)74163923;
				switch (num2 == num)
				{
				}
				num = (short)1326120960;
				if (num != 0)
				{
				}
				num = (short)1443233792;
				short num3 = num;
				num = (short)918814721;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadRemoteMicSource_A8930.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.ControlHeadAliasListInner;
			}
		}

		// Token: 0x170033DB RID: 13275
		// (get) Token: 0x06006417 RID: 25623 RVA: 0x0059E974 File Offset: 0x0059CB74
		public global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.ControlHeadAliasListInner ControlHeadAliasListInnerSectionForRadErgoWideControlHeadTransceiverDEKDimControl_A9404
		{
			get
			{
				short num = (short)1427184983;
				short num2 = num;
				num = (short)211230039;
				switch (num2 == num)
				{
				}
				num = (short)161742848;
				if (num != 0)
				{
				}
				num = (short)1981612032;
				short num3 = num;
				num = (short)102039553;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadTransceiverDEKDimControl_A9404.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.ControlHeadAliasListInner;
			}
		}

		// Token: 0x170033DC RID: 13276
		// (get) Token: 0x06006418 RID: 25624 RVA: 0x0059EA2C File Offset: 0x0059CC2C
		public global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.ControlHeadAliasListInner ControlHeadAliasListInnerSectionForRadErgoWideControlHeadTransceiverVolumeControl_A9405
		{
			get
			{
				short num = (short)476721554;
				short num2 = num;
				num = (short)737358226;
				switch (num2 == num)
				{
				}
				num = (short)1737883649;
				if (num != 0)
				{
				}
				num = (short)1489108992;
				short num3 = num;
				num = (short)1924071424;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadTransceiverVolumeControl_A9405.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.ControlHeadAliasListInner;
			}
		}

		// Token: 0x170033DD RID: 13277
		// (get) Token: 0x06006419 RID: 25625 RVA: 0x0059EAE0 File Offset: 0x0059CCE0
		public global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.ControlHeadAliasListInner ControlHeadAliasListInnerSectionForRadErgoWideControlHeadBluetoothControl_44820
		{
			get
			{
				short num = (short)705801209;
				short num2 = num;
				num = (short)1705225209;
				switch (num2 == num)
				{
				}
				num = (short)2146631681;
				if (num != 0)
				{
				}
				num = (short)1633484800;
				short num3 = num;
				num = (short)1825439744;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadBluetoothControl_44820.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.ControlHeadAliasListInner;
			}
		}

		// Token: 0x170033DE RID: 13278
		// (get) Token: 0x0600641A RID: 25626 RVA: 0x0059EB9C File Offset: 0x0059CD9C
		public bool HasDiffs
		{
			get
			{
				short num = (short)867304256;
				short num2 = num;
				num = (short)2085159744;
				switch (num2 == num)
				{
				}
				num = (short)463142913;
				if (num != 0)
				{
				}
				num = (short)405602304;
				short num3 = num;
				num = (short)1986527232;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x170033DF RID: 13279
		// (get) Token: 0x0600641B RID: 25627 RVA: 0x0059EC4C File Offset: 0x0059CE4C
		// (set) Token: 0x0600641C RID: 25628 RVA: 0x0059ECFC File Offset: 0x0059CEFC
		public int RadErgoWideControlHeadControlHeadVIPInputSource_A7724Value
		{
			get
			{
				short num = (short)37783349;
				short num2 = num;
				num = (short)1102415669;
				switch (num2 == num)
				{
				}
				num = (short)1911029761;
				if (num != 0)
				{
				}
				num = (short)733478912;
				short num3 = num;
				num = (short)1726021632;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadControlHeadVIPInputSource_A7724.Value;
			}
			set
			{
				short num = (short)1300734390;
				short num2 = num;
				num = (short)1990631862;
				switch (num2 == num)
				{
				}
				num = (short)1780940800;
				if (num != 0)
				{
				}
				num = (short)1819934720;
				short num3 = num;
				num = (short)1021706241;
				if (num != 0)
				{
				}
				this.radErgoWideControlHeadControlHeadVIPInputSource_A7724.Value = value;
			}
		}

		// Token: 0x170033E0 RID: 13280
		// (get) Token: 0x0600641D RID: 25629 RVA: 0x0059EDB4 File Offset: 0x0059CFB4
		// (set) Token: 0x0600641E RID: 25630 RVA: 0x0059EE68 File Offset: 0x0059D068
		public string RadErgoWideControlHeadControlHeadVIPInputSource_A7724_UIValue
		{
			get
			{
				short num = (short)79765013;
				short num2 = num;
				num = (short)968760853;
				switch (num2 == num)
				{
				}
				num = (short)986775553;
				if (num != 0)
				{
				}
				num = (short)1783169024;
				short num3 = num;
				num = (short)349896704;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadControlHeadVIPInputSource_A7724.UIValue;
			}
			set
			{
				short num = (short)1206629163;
				short num2 = num;
				num = (short)694924075;
				switch (num2 == num)
				{
				}
				num = (short)1149370369;
				if (num != 0)
				{
				}
				num = (short)1521745920;
				short num3 = num;
				num = (short)2007760896;
				if (num != 0)
				{
				}
				this.radErgoWideControlHeadControlHeadVIPInputSource_A7724.UIValue = value;
			}
		}

		// Token: 0x170033E1 RID: 13281
		// (get) Token: 0x0600641F RID: 25631 RVA: 0x0059EF1C File Offset: 0x0059D11C
		public global::AcpBusinessLayer.AcpRecRefField RadErgoWideControlHeadControlHeadVIPInputSource_A7724
		{
			get
			{
				short num = (short)870472723;
				short num2 = num;
				num = (short)2052611091;
				switch (num2 == num)
				{
				}
				num = (short)665976832;
				short num3 = num;
				num = (short)1380253696;
				if (num != 0)
				{
				}
				num = (short)1375862785;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadControlHeadVIPInputSource_A7724;
			}
		}

		// Token: 0x170033E2 RID: 13282
		// (get) Token: 0x06006420 RID: 25632 RVA: 0x0059EFCC File Offset: 0x0059D1CC
		// (set) Token: 0x06006421 RID: 25633 RVA: 0x0059F084 File Offset: 0x0059D284
		public bool RadErgoWideControlHeadControlHeadVIPInputSource_A7724_Applicable
		{
			get
			{
				short num = (short)1021875073;
				short num2 = num;
				num = (short)1080923009;
				switch (num2 == num)
				{
				}
				num = (short)110428160;
				short num3 = num;
				num = (short)1130692608;
				if (num != 0)
				{
				}
				num = (short)933167105;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadControlHeadVIPInputSource_A7724.Applicable;
			}
			set
			{
				short num = (short)1203044353;
				if (num != 0)
				{
				}
				num = (short)642787055;
				short num2 = num;
				num = (short)1973036783;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1730478080;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)500367360;
				if (num != 0)
				{
				}
				this.radErgoWideControlHeadControlHeadVIPInputSource_A7724.Applicable = value;
			}
		}

		// Token: 0x170033E3 RID: 13283
		// (get) Token: 0x06006422 RID: 25634 RVA: 0x0059F13C File Offset: 0x0059D33C
		// (set) Token: 0x06006423 RID: 25635 RVA: 0x0059F1F0 File Offset: 0x0059D3F0
		public bool RadErgoWideControlHeadControlHeadVIPInputSource_A7724_Valid
		{
			get
			{
				short num = (short)1377128858;
				short num2 = num;
				num = (short)1768903066;
				switch (num2 == num)
				{
				}
				num = (short)776339456;
				short num3 = num;
				num = (short)1262354433;
				if (num != 0)
				{
				}
				num = (short)1228210176;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadControlHeadVIPInputSource_A7724.Valid;
			}
			set
			{
				short num = (short)1851282798;
				short num2 = num;
				num = (short)1467962734;
				switch (num2 == num)
				{
				}
				num = (short)1457520640;
				short num3 = num;
				num = (short)350027776;
				if (num != 0)
				{
				}
				num = (short)1088946177;
				if (num != 0)
				{
				}
				this.radErgoWideControlHeadControlHeadVIPInputSource_A7724.Valid = value;
			}
		}

		// Token: 0x170033E4 RID: 13284
		// (get) Token: 0x06006424 RID: 25636 RVA: 0x0059F2A8 File Offset: 0x0059D4A8
		// (set) Token: 0x06006425 RID: 25637 RVA: 0x0059F360 File Offset: 0x0059D560
		public bool RadErgoWideControlHeadControlHeadVIPInputSource_A7724_Visible
		{
			get
			{
				short num = (short)2113511033;
				short num2 = num;
				num = (short)1459134073;
				switch (num2 == num)
				{
				}
				num = (short)679804928;
				short num3 = num;
				num = (short)1323237377;
				if (num != 0)
				{
				}
				num = (short)1338703872;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadControlHeadVIPInputSource_A7724.Visible;
			}
			set
			{
				short num = (short)2081784659;
				short num2 = num;
				num = (short)2040759123;
				switch (num2 == num)
				{
				}
				num = (short)325976064;
				short num3 = num;
				num = (short)690880513;
				if (num != 0)
				{
				}
				num = (short)1577123840;
				if (num != 0)
				{
				}
				this.radErgoWideControlHeadControlHeadVIPInputSource_A7724.Visible = value;
			}
		}

		// Token: 0x170033E5 RID: 13285
		// (get) Token: 0x06006426 RID: 25638 RVA: 0x0059F414 File Offset: 0x0059D614
		// (set) Token: 0x06006427 RID: 25639 RVA: 0x0059F4C4 File Offset: 0x0059D6C4
		public bool RadErgoWideControlHeadControlHeadVIPInputSource_A7724_Editable
		{
			get
			{
				short num = (short)305183691;
				short num2 = num;
				num = (short)1091419083;
				switch (num2 == num)
				{
				}
				num = (short)1648754688;
				short num3 = num;
				num = (short)25559041;
				if (num != 0)
				{
				}
				num = (short)1411514368;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadControlHeadVIPInputSource_A7724.Editable;
			}
			set
			{
				short num = (short)591986689;
				if (num != 0)
				{
				}
				num = (short)620060581;
				short num2 = num;
				num = (short)1766154149;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1765933056;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)839712768;
				if (num != 0)
				{
				}
				this.radErgoWideControlHeadControlHeadVIPInputSource_A7724.Editable = value;
			}
		}

		// Token: 0x170033E6 RID: 13286
		// (get) Token: 0x06006428 RID: 25640 RVA: 0x0059F57C File Offset: 0x0059D77C
		internal string RadErgoWideControlHeadControlHeadVIPInputSource_A7724_UILabel
		{
			get
			{
				short num = (short)338558977;
				if (num != 0)
				{
				}
				num = (short)108800657;
				short num2 = num;
				num = (short)320875153;
				switch (num2 == num)
				{
				default:
				{
					num = (short)712179712;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1066467328;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadControlHeadVIPInputSource_A7724.UIName;
			}
		}

		// Token: 0x170033E7 RID: 13287
		// (get) Token: 0x06006429 RID: 25641 RVA: 0x0059F630 File Offset: 0x0059D830
		// (set) Token: 0x0600642A RID: 25642 RVA: 0x0059F6E4 File Offset: 0x0059D8E4
		internal bool RadErgoWideControlHeadControlHeadVIPInputSource_A7724_HiddenStatic
		{
			get
			{
				short num = (short)2076609280;
				short num2 = num;
				num = (short)1248234240;
				switch (num2 == num)
				{
				}
				num = (short)1265958912;
				short num3 = num;
				num = (short)1635385344;
				if (num != 0)
				{
				}
				num = (short)681967617;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadControlHeadVIPInputSource_A7724.HiddenStatic;
			}
			set
			{
				short num = (short)1499564405;
				short num2 = num;
				num = (short)1600424309;
				switch (num2 == num)
				{
				}
				num = (short)1217069056;
				short num3 = num;
				num = (short)2053308417;
				if (num != 0)
				{
				}
				num = (short)234815488;
				if (num != 0)
				{
				}
				this.radErgoWideControlHeadControlHeadVIPInputSource_A7724.HiddenStatic = value;
			}
		}

		// Token: 0x170033E8 RID: 13288
		// (get) Token: 0x0600642B RID: 25643 RVA: 0x0059F798 File Offset: 0x0059D998
		// (set) Token: 0x0600642C RID: 25644 RVA: 0x0059F84C File Offset: 0x0059DA4C
		internal bool RadErgoWideControlHeadControlHeadVIPInputSource_A7724_HiddenDynamic
		{
			get
			{
				short num = (short)1295100039;
				short num2 = num;
				num = (short)1158457479;
				switch (num2 == num)
				{
				}
				num = (short)1102184448;
				short num3 = num;
				num = (short)117899265;
				if (num != 0)
				{
				}
				num = (short)269418496;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadControlHeadVIPInputSource_A7724.HiddenDynamic;
			}
			set
			{
				short num = (short)2025668674;
				short num2 = num;
				num = (short)214253634;
				switch (num2 == num)
				{
				}
				num = (short)557776896;
				short num3 = num;
				num = (short)1024065537;
				if (num != 0)
				{
				}
				num = (short)493617152;
				if (num != 0)
				{
				}
				this.radErgoWideControlHeadControlHeadVIPInputSource_A7724.HiddenDynamic = value;
			}
		}

		// Token: 0x170033E9 RID: 13289
		// (get) Token: 0x0600642D RID: 25645 RVA: 0x0059F904 File Offset: 0x0059DB04
		public bool RadErgoWideControlHeadControlHeadVIPInputSource_A7724_HasDiffs
		{
			get
			{
				short num = (short)1113282646;
				short num2 = num;
				num = (short)1574590550;
				switch (num2 == num)
				{
				}
				num = (short)172294144;
				short num3 = num;
				num = (short)1160970241;
				if (num != 0)
				{
				}
				num = (short)1503002624;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadControlHeadVIPInputSource_A7724._HasDiffs;
			}
		}

		// Token: 0x170033EA RID: 13290
		// (get) Token: 0x0600642E RID: 25646 RVA: 0x0059F9B8 File Offset: 0x0059DBB8
		// (set) Token: 0x0600642F RID: 25647 RVA: 0x0059FA6C File Offset: 0x0059DC6C
		public bool RadErgoWideControlHeadControlHeadsRequiredforPowerUp_A7725Value
		{
			get
			{
				short num = (short)2110914561;
				if (num != 0)
				{
				}
				num = (short)1986340875;
				short num2 = num;
				num = (short)267528203;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1072431104;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)849805312;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadControlHeadsRequiredforPowerUp_A7725.Value;
			}
			set
			{
				short num = (short)55281298;
				short num2 = num;
				num = (short)1179354770;
				switch (num2 == num)
				{
				}
				num = (short)284819456;
				short num3 = num;
				num = (short)1841889280;
				if (num != 0)
				{
				}
				num = (short)304021505;
				if (num != 0)
				{
				}
				this.radErgoWideControlHeadControlHeadsRequiredforPowerUp_A7725.Value = value;
			}
		}

		// Token: 0x170033EB RID: 13291
		// (get) Token: 0x06006430 RID: 25648 RVA: 0x0059FB24 File Offset: 0x0059DD24
		public global::AcpBusinessLayer.AcpField<bool> RadErgoWideControlHeadControlHeadsRequiredforPowerUp_A7725
		{
			get
			{
				short num = (short)1510277121;
				if (num != 0)
				{
				}
				num = (short)1871130001;
				short num2 = num;
				num = (short)2063478161;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1708785664;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)226033664;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadControlHeadsRequiredforPowerUp_A7725;
			}
		}

		// Token: 0x170033EC RID: 13292
		// (get) Token: 0x06006431 RID: 25649 RVA: 0x0059FBD4 File Offset: 0x0059DDD4
		// (set) Token: 0x06006432 RID: 25650 RVA: 0x0059FC88 File Offset: 0x0059DE88
		public bool RadErgoWideControlHeadControlHeadsRequiredforPowerUp_A7725_UIValue
		{
			get
			{
				short num = (short)123142145;
				if (num != 0)
				{
				}
				num = (short)371774496;
				short num2 = num;
				num = (short)868602912;
				switch (num2 == num)
				{
				default:
				{
					num = (short)733085696;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)945684480;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadControlHeadsRequiredforPowerUp_A7725.Value;
			}
			set
			{
				short num = (short)1464926209;
				if (num != 0)
				{
				}
				num = (short)738753318;
				short num2 = num;
				num = (short)1329167142;
				switch (num2 == num)
				{
				default:
				{
					num = (short)172294144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1605894144;
				if (num != 0)
				{
				}
				this.radErgoWideControlHeadControlHeadsRequiredforPowerUp_A7725.Value = value;
			}
		}

		// Token: 0x170033ED RID: 13293
		// (get) Token: 0x06006433 RID: 25651 RVA: 0x0059FD40 File Offset: 0x0059DF40
		// (set) Token: 0x06006434 RID: 25652 RVA: 0x0059FDF4 File Offset: 0x0059DFF4
		public bool RadErgoWideControlHeadControlHeadsRequiredforPowerUp_A7725_Applicable
		{
			get
			{
				short num = (short)1413632115;
				short num2 = num;
				num = (short)2041466995;
				switch (num2 == num)
				{
				}
				num = (short)1589313536;
				short num3 = num;
				num = (short)354287616;
				if (num != 0)
				{
				}
				num = (short)114425857;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadControlHeadsRequiredforPowerUp_A7725.Applicable;
			}
			set
			{
				short num = (short)1924435946;
				short num2 = num;
				num = (short)283545578;
				switch (num2 == num)
				{
				}
				num = (short)1556807681;
				if (num != 0)
				{
				}
				num = (short)1763442688;
				if (num != 0)
				{
				}
				num = (short)955645952;
				short num3 = num;
				this.radErgoWideControlHeadControlHeadsRequiredforPowerUp_A7725.Applicable = value;
			}
		}

		// Token: 0x170033EE RID: 13294
		// (get) Token: 0x06006435 RID: 25653 RVA: 0x0059FEAC File Offset: 0x0059E0AC
		// (set) Token: 0x06006436 RID: 25654 RVA: 0x0059FF60 File Offset: 0x0059E160
		public bool RadErgoWideControlHeadControlHeadsRequiredforPowerUp_A7725_Valid
		{
			get
			{
				short num = (short)979566098;
				short num2 = num;
				num = (short)836107794;
				switch (num2 == num)
				{
				}
				num = (short)810811393;
				if (num != 0)
				{
				}
				num = (short)330956800;
				if (num != 0)
				{
				}
				num = (short)35389440;
				short num3 = num;
				return this.radErgoWideControlHeadControlHeadsRequiredforPowerUp_A7725.Valid;
			}
			set
			{
				short num = (short)1592974005;
				short num2 = num;
				num = (short)156949173;
				switch (num2 == num)
				{
				}
				num = (short)1570766849;
				if (num != 0)
				{
				}
				num = (short)1691942912;
				if (num != 0)
				{
				}
				num = (short)871038976;
				short num3 = num;
				this.radErgoWideControlHeadControlHeadsRequiredforPowerUp_A7725.Valid = value;
			}
		}

		// Token: 0x170033EF RID: 13295
		// (get) Token: 0x06006437 RID: 25655 RVA: 0x005A0014 File Offset: 0x0059E214
		// (set) Token: 0x06006438 RID: 25656 RVA: 0x005A00C8 File Offset: 0x0059E2C8
		public bool RadErgoWideControlHeadControlHeadsRequiredforPowerUp_A7725_Visible
		{
			get
			{
				short num = (short)1471454379;
				short num2 = num;
				num = (short)1063820459;
				switch (num2 == num)
				{
				}
				num = (short)1876164608;
				if (num != 0)
				{
				}
				num = (short)2145714177;
				if (num != 0)
				{
				}
				num = (short)876085248;
				short num3 = num;
				return this.radErgoWideControlHeadControlHeadsRequiredforPowerUp_A7725.Visible;
			}
			set
			{
				short num = (short)2032881665;
				short num2 = num;
				num = (short)598364161;
				switch (num2 == num)
				{
				}
				num = (short)1890385920;
				if (num != 0)
				{
				}
				num = (short)7274497;
				if (num != 0)
				{
				}
				num = (short)255918080;
				short num3 = num;
				this.radErgoWideControlHeadControlHeadsRequiredforPowerUp_A7725.Visible = value;
			}
		}

		// Token: 0x170033F0 RID: 13296
		// (get) Token: 0x06006439 RID: 25657 RVA: 0x005A0180 File Offset: 0x0059E380
		// (set) Token: 0x0600643A RID: 25658 RVA: 0x005A0234 File Offset: 0x0059E434
		public bool RadErgoWideControlHeadControlHeadsRequiredforPowerUp_A7725_Editable
		{
			get
			{
				short num = (short)353193016;
				short num2 = num;
				num = (short)562908216;
				switch (num2 == num)
				{
				}
				num = (short)1496776705;
				if (num != 0)
				{
				}
				num = (short)1321336832;
				if (num != 0)
				{
				}
				num = (short)779681792;
				short num3 = num;
				return this.radErgoWideControlHeadControlHeadsRequiredforPowerUp_A7725.Editable;
			}
			set
			{
				short num = (short)1186157423;
				short num2 = num;
				num = (short)1358648175;
				switch (num2 == num)
				{
				}
				num = (short)1621819393;
				if (num != 0)
				{
				}
				num = (short)1209204736;
				if (num != 0)
				{
				}
				num = (short)2104819712;
				short num3 = num;
				this.radErgoWideControlHeadControlHeadsRequiredforPowerUp_A7725.Editable = value;
			}
		}

		// Token: 0x170033F1 RID: 13297
		// (get) Token: 0x0600643B RID: 25659 RVA: 0x005A02E8 File Offset: 0x0059E4E8
		internal string RadErgoWideControlHeadControlHeadsRequiredforPowerUp_A7725_UILabel
		{
			get
			{
				short num = (short)1692412819;
				short num2 = num;
				num = (short)1833249683;
				switch (num2 == num)
				{
				}
				num = (short)758972417;
				if (num != 0)
				{
				}
				num = (short)574816256;
				if (num != 0)
				{
				}
				num = (short)321257472;
				short num3 = num;
				return this.radErgoWideControlHeadControlHeadsRequiredforPowerUp_A7725.UIName;
			}
		}

		// Token: 0x170033F2 RID: 13298
		// (get) Token: 0x0600643C RID: 25660 RVA: 0x005A039C File Offset: 0x0059E59C
		// (set) Token: 0x0600643D RID: 25661 RVA: 0x005A0450 File Offset: 0x0059E650
		internal bool RadErgoWideControlHeadControlHeadsRequiredforPowerUp_A7725_HiddenStatic
		{
			get
			{
				short num = (short)638738299;
				short num2 = num;
				num = (short)25255803;
				switch (num2 == num)
				{
				}
				num = (short)255000577;
				if (num != 0)
				{
				}
				num = (short)1009713152;
				if (num != 0)
				{
				}
				num = (short)628555776;
				short num3 = num;
				return this.radErgoWideControlHeadControlHeadsRequiredforPowerUp_A7725.HiddenStatic;
			}
			set
			{
				short num = (short)1892600568;
				short num2 = num;
				num = (short)227855096;
				switch (num2 == num)
				{
				}
				num = (short)1493368833;
				if (num != 0)
				{
				}
				num = (short)472252416;
				if (num != 0)
				{
				}
				num = (short)851443712;
				short num3 = num;
				this.radErgoWideControlHeadControlHeadsRequiredforPowerUp_A7725.HiddenStatic = value;
			}
		}

		// Token: 0x170033F3 RID: 13299
		// (get) Token: 0x0600643E RID: 25662 RVA: 0x005A0508 File Offset: 0x0059E708
		// (set) Token: 0x0600643F RID: 25663 RVA: 0x005A05BC File Offset: 0x0059E7BC
		internal bool RadErgoWideControlHeadControlHeadsRequiredforPowerUp_A7725_HiddenDynamic
		{
			get
			{
				short num = (short)897974273;
				if (num != 0)
				{
				}
				num = (short)243762393;
				short num2 = num;
				num = (short)504726745;
				switch (num2 == num)
				{
				}
				num = (short)612237312;
				if (num != 0)
				{
				}
				num = (short)1631977472;
				short num3 = num;
				return this.radErgoWideControlHeadControlHeadsRequiredforPowerUp_A7725.HiddenDynamic;
			}
			set
			{
				short num = (short)774111233;
				if (num != 0)
				{
				}
				num = (short)1814899911;
				short num2 = num;
				num = (short)33828039;
				switch (num2 == num)
				{
				}
				num = (short)641269760;
				if (num != 0)
				{
				}
				num = (short)668794880;
				short num3 = num;
				this.radErgoWideControlHeadControlHeadsRequiredforPowerUp_A7725.HiddenDynamic = value;
			}
		}

		// Token: 0x170033F4 RID: 13300
		// (get) Token: 0x06006440 RID: 25664 RVA: 0x005A0674 File Offset: 0x0059E874
		public bool RadErgoWideControlHeadControlHeadsRequiredforPowerUp_A7725_HasDiffs
		{
			get
			{
				short num = (short)900717878;
				short num2 = num;
				num = (short)900259126;
				switch (num2 == num)
				{
				}
				num = (short)60489728;
				if (num != 0)
				{
				}
				num = (short)1621229569;
				if (num != 0)
				{
				}
				num = (short)564068352;
				short num3 = num;
				return this.radErgoWideControlHeadControlHeadsRequiredforPowerUp_A7725._HasDiffs;
			}
		}

		// Token: 0x170033F5 RID: 13301
		// (get) Token: 0x06006441 RID: 25665 RVA: 0x005A072C File Offset: 0x0059E92C
		// (set) Token: 0x06006442 RID: 25666 RVA: 0x005A07DC File Offset: 0x0059E9DC
		public int RadErgoWideControlHeadExpectedNumofControlHeads_A7982Value
		{
			get
			{
				short num = (short)1171053806;
				short num2 = num;
				num = (short)1691999470;
				switch (num2 == num)
				{
				}
				num = (short)501743617;
				if (num != 0)
				{
				}
				num = (short)109838336;
				if (num != 0)
				{
				}
				num = (short)1208287232;
				short num3 = num;
				return this.radErgoWideControlHeadExpectedNumofControlHeads_A7982.Value;
			}
			set
			{
				short num = (short)571670528;
				short num2 = num;
				num = (short)2110282319;
				short num3 = num;
				num = (short)2024954447;
				switch (num3 == num)
				{
				}
				num = (short)554565632;
				if (num != 0)
				{
				}
				num = (short)435683329;
				if (num != 0)
				{
				}
				this.radErgoWideControlHeadExpectedNumofControlHeads_A7982.Value = value;
			}
		}

		// Token: 0x170033F6 RID: 13302
		// (get) Token: 0x06006443 RID: 25667 RVA: 0x005A0890 File Offset: 0x0059EA90
		// (set) Token: 0x06006444 RID: 25668 RVA: 0x005A0940 File Offset: 0x0059EB40
		public string RadErgoWideControlHeadExpectedNumofControlHeads_A7982_UIValue
		{
			get
			{
				short num = (short)546045952;
				short num2 = num;
				num = (short)1865382802;
				short num3 = num;
				num = (short)1054112658;
				switch (num3 == num)
				{
				}
				num = (short)1117454336;
				if (num != 0)
				{
				}
				num = (short)1917911041;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadExpectedNumofControlHeads_A7982.UIValue;
			}
			set
			{
				short num = (short)1325662208;
				short num2 = num;
				num = (short)2060454855;
				short num3 = num;
				num = (short)830999495;
				switch (num3 == num)
				{
				}
				num = (short)375324673;
				if (num != 0)
				{
				}
				num = (short)1762066432;
				if (num != 0)
				{
				}
				this.radErgoWideControlHeadExpectedNumofControlHeads_A7982.UIValue = value;
			}
		}

		// Token: 0x170033F7 RID: 13303
		// (get) Token: 0x06006445 RID: 25669 RVA: 0x005A09F4 File Offset: 0x0059EBF4
		public global::AcpBusinessLayer.AcpListField RadErgoWideControlHeadExpectedNumofControlHeads_A7982
		{
			get
			{
				short num = (short)922025984;
				short num2 = num;
				num = (short)460254288;
				short num3 = num;
				num = (short)286125136;
				switch (num3 == num)
				{
				}
				num = (short)352452609;
				if (num != 0)
				{
				}
				num = (short)1709178880;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadExpectedNumofControlHeads_A7982;
			}
		}

		// Token: 0x170033F8 RID: 13304
		// (get) Token: 0x06006446 RID: 25670 RVA: 0x005A0AA4 File Offset: 0x0059ECA4
		// (set) Token: 0x06006447 RID: 25671 RVA: 0x005A0B58 File Offset: 0x0059ED58
		public bool RadErgoWideControlHeadExpectedNumofControlHeads_A7982_Applicable
		{
			get
			{
				short num = (short)42926080;
				short num2 = num;
				num = (short)194292559;
				short num3 = num;
				num = (short)993831759;
				switch (num3 == num)
				{
				}
				num = (short)1162346496;
				if (num != 0)
				{
				}
				num = (short)1415970817;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadExpectedNumofControlHeads_A7982.Applicable;
			}
			set
			{
				short num = (short)1375076352;
				short num2 = num;
				num = (short)1072514216;
				short num3 = num;
				num = (short)1282294952;
				switch (num3 == num)
				{
				}
				num = (short)692649985;
				if (num != 0)
				{
				}
				num = (short)1332150272;
				if (num != 0)
				{
				}
				this.radErgoWideControlHeadExpectedNumofControlHeads_A7982.Applicable = value;
			}
		}

		// Token: 0x170033F9 RID: 13305
		// (get) Token: 0x06006448 RID: 25672 RVA: 0x005A0C0C File Offset: 0x0059EE0C
		// (set) Token: 0x06006449 RID: 25673 RVA: 0x005A0CC0 File Offset: 0x0059EEC0
		public bool RadErgoWideControlHeadExpectedNumofControlHeads_A7982_Valid
		{
			get
			{
				short num = (short)180617216;
				short num2 = num;
				num = (short)1683079704;
				short num3 = num;
				num = (short)81642008;
				switch (num3 == num)
				{
				}
				num = (short)365887489;
				if (num != 0)
				{
				}
				num = (short)1625751552;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadExpectedNumofControlHeads_A7982.Valid;
			}
			set
			{
				short num = (short)941293568;
				short num2 = num;
				num = (short)642391751;
				short num3 = num;
				num = (short)119414471;
				switch (num3 == num)
				{
				}
				num = (short)815267841;
				if (num != 0)
				{
				}
				num = (short)1182990336;
				if (num != 0)
				{
				}
				this.radErgoWideControlHeadExpectedNumofControlHeads_A7982.Valid = value;
			}
		}

		// Token: 0x170033FA RID: 13306
		// (get) Token: 0x0600644A RID: 25674 RVA: 0x005A0D78 File Offset: 0x0059EF78
		// (set) Token: 0x0600644B RID: 25675 RVA: 0x005A0E2C File Offset: 0x0059F02C
		public bool RadErgoWideControlHeadExpectedNumofControlHeads_A7982_Visible
		{
			get
			{
				short num = (short)234225664;
				short num2 = num;
				num = (short)1739849729;
				if (num != 0)
				{
				}
				num = (short)1623309464;
				short num3 = num;
				num = (short)1687665816;
				switch (num3 == num)
				{
				}
				num = (short)1688797184;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadExpectedNumofControlHeads_A7982.Visible;
			}
			set
			{
				short num = (short)1918173184;
				short num2 = num;
				num = (short)1221937490;
				short num3 = num;
				num = (short)48515410;
				switch (num3 == num)
				{
				}
				num = (short)1182597120;
				if (num != 0)
				{
				}
				num = (short)692584449;
				if (num != 0)
				{
				}
				this.radErgoWideControlHeadExpectedNumofControlHeads_A7982.Visible = value;
			}
		}

		// Token: 0x170033FB RID: 13307
		// (get) Token: 0x0600644C RID: 25676 RVA: 0x005A0EE0 File Offset: 0x0059F0E0
		// (set) Token: 0x0600644D RID: 25677 RVA: 0x005A0F94 File Offset: 0x0059F194
		public bool RadErgoWideControlHeadExpectedNumofControlHeads_A7982_Editable
		{
			get
			{
				short num = (short)1479278592;
				short num2 = num;
				num = (short)1736054843;
				short num3 = num;
				num = (short)1857493051;
				switch (num3 == num)
				{
				}
				num = (short)730988544;
				if (num != 0)
				{
				}
				num = (short)1420230657;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadExpectedNumofControlHeads_A7982.Editable;
			}
			set
			{
				short num = (short)1343094784;
				short num2 = num;
				num = (short)2119892555;
				short num3 = num;
				num = (short)1984953931;
				switch (num3 == num)
				{
				}
				num = (short)2019950593;
				if (num != 0)
				{
				}
				num = (short)128385024;
				if (num != 0)
				{
				}
				this.radErgoWideControlHeadExpectedNumofControlHeads_A7982.Editable = value;
			}
		}

		// Token: 0x170033FC RID: 13308
		// (get) Token: 0x0600644E RID: 25678 RVA: 0x005A104C File Offset: 0x0059F24C
		internal string RadErgoWideControlHeadExpectedNumofControlHeads_A7982_UILabel
		{
			get
			{
				short num = (short)1591345152;
				short num2 = num;
				num = (short)1642913044;
				short num3 = num;
				num = (short)1727716628;
				switch (num3 == num)
				{
				}
				num = (short)1764294657;
				if (num != 0)
				{
				}
				num = (short)1811939328;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadExpectedNumofControlHeads_A7982.UIName;
			}
		}

		// Token: 0x170033FD RID: 13309
		// (get) Token: 0x0600644F RID: 25679 RVA: 0x005A1100 File Offset: 0x0059F300
		// (set) Token: 0x06006450 RID: 25680 RVA: 0x005A11B4 File Offset: 0x0059F3B4
		internal bool RadErgoWideControlHeadExpectedNumofControlHeads_A7982_HiddenStatic
		{
			get
			{
				short num = (short)117702656;
				short num2 = num;
				num = (short)1991694652;
				short num3 = num;
				num = (short)530897212;
				switch (num3 == num)
				{
				}
				num = (short)1738932225;
				if (num != 0)
				{
				}
				num = (short)1602748416;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadExpectedNumofControlHeads_A7982.HiddenStatic;
			}
			set
			{
				short num = (short)241172480;
				short num2 = num;
				num = (short)1944749037;
				short num3 = num;
				num = (short)1695056877;
				switch (num3 == num)
				{
				}
				num = (short)1308622849;
				if (num != 0)
				{
				}
				num = (short)18087936;
				if (num != 0)
				{
				}
				this.radErgoWideControlHeadExpectedNumofControlHeads_A7982.HiddenStatic = value;
			}
		}

		// Token: 0x170033FE RID: 13310
		// (get) Token: 0x06006451 RID: 25681 RVA: 0x005A126C File Offset: 0x0059F46C
		// (set) Token: 0x06006452 RID: 25682 RVA: 0x005A1320 File Offset: 0x0059F520
		internal bool RadErgoWideControlHeadExpectedNumofControlHeads_A7982_HiddenDynamic
		{
			get
			{
				short num = (short)1103626240;
				short num2 = num;
				num = (short)87522478;
				short num3 = num;
				num = (short)230194350;
				switch (num3 == num)
				{
				}
				num = (short)231473153;
				if (num != 0)
				{
				}
				num = (short)1589968896;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadExpectedNumofControlHeads_A7982.HiddenDynamic;
			}
			set
			{
				short num = (short)653656064;
				short num2 = num;
				num = (short)1035032995;
				short num3 = num;
				num = (short)570841507;
				switch (num3 == num)
				{
				}
				num = (short)291110913;
				if (num != 0)
				{
				}
				num = (short)605224960;
				if (num != 0)
				{
				}
				this.radErgoWideControlHeadExpectedNumofControlHeads_A7982.HiddenDynamic = value;
			}
		}

		// Token: 0x170033FF RID: 13311
		// (get) Token: 0x06006453 RID: 25683 RVA: 0x005A13D4 File Offset: 0x0059F5D4
		public bool RadErgoWideControlHeadExpectedNumofControlHeads_A7982_HasDiffs
		{
			get
			{
				short num = (short)1794375680;
				short num2 = num;
				num = (short)1607978389;
				short num3 = num;
				num = (short)1343802773;
				switch (num3 == num)
				{
				}
				num = (short)1089404928;
				if (num != 0)
				{
				}
				num = (short)1807876097;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadExpectedNumofControlHeads_A7982._HasDiffs;
			}
		}

		// Token: 0x17003400 RID: 13312
		// (get) Token: 0x06006454 RID: 25684 RVA: 0x005A148C File Offset: 0x0059F68C
		// (set) Token: 0x06006455 RID: 25685 RVA: 0x005A153C File Offset: 0x0059F73C
		public int RadErgoWideControlHeadIntercomTimeoutTimersec_A8297Value
		{
			get
			{
				short num = (short)808910848;
				short num2 = num;
				num = (short)1238606575;
				short num3 = num;
				num = (short)1910219503;
				switch (num3 == num)
				{
				}
				num = (short)483983361;
				if (num != 0)
				{
				}
				num = (short)1912209408;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadIntercomTimeoutTimersec_A8297.Value;
			}
			set
			{
				short num = (short)965541888;
				short num2 = num;
				num = (short)1523016376;
				short num3 = num;
				num = (short)264921784;
				switch (num3 == num)
				{
				}
				num = (short)237830145;
				if (num != 0)
				{
				}
				num = (short)1680605184;
				if (num != 0)
				{
				}
				this.radErgoWideControlHeadIntercomTimeoutTimersec_A8297.Value = value;
			}
		}

		// Token: 0x17003401 RID: 13313
		// (get) Token: 0x06006456 RID: 25686 RVA: 0x005A15F0 File Offset: 0x0059F7F0
		public global::AcpBusinessLayer.AcpSimpleRangeField RadErgoWideControlHeadIntercomTimeoutTimersec_A8297
		{
			get
			{
				short num = (short)1901002752;
				short num2 = num;
				num = (short)2113719336;
				short num3 = num;
				num = (short)1103285288;
				switch (num3 == num)
				{
				}
				num = (short)948633601;
				if (num != 0)
				{
				}
				num = (short)2053308416;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadIntercomTimeoutTimersec_A8297;
			}
		}

		// Token: 0x17003402 RID: 13314
		// (get) Token: 0x06006457 RID: 25687 RVA: 0x005A16A0 File Offset: 0x0059F8A0
		// (set) Token: 0x06006458 RID: 25688 RVA: 0x005A1758 File Offset: 0x0059F958
		public string RadErgoWideControlHeadIntercomTimeoutTimersec_A8297_UIValue
		{
			get
			{
				short num = (short)2123825152;
				short num2 = num;
				num = (short)987207022;
				short num3 = num;
				num = (short)919311726;
				switch (num3 == num)
				{
				}
				num = (short)176553985;
				if (num != 0)
				{
				}
				num = (short)782303232;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadIntercomTimeoutTimersec_A8297.UIValue;
			}
			set
			{
				short num = (short)430768128;
				short num2 = num;
				num = (short)974539833;
				short num3 = num;
				num = (short)924994617;
				switch (num3 == num)
				{
				}
				num = (short)187957249;
				if (num != 0)
				{
				}
				num = (short)351272960;
				if (num != 0)
				{
				}
				this.radErgoWideControlHeadIntercomTimeoutTimersec_A8297.UIValue = value;
			}
		}

		// Token: 0x17003403 RID: 13315
		// (get) Token: 0x06006459 RID: 25689 RVA: 0x005A180C File Offset: 0x0059FA0C
		// (set) Token: 0x0600645A RID: 25690 RVA: 0x005A18C0 File Offset: 0x0059FAC0
		internal int RadErgoWideControlHeadIntercomTimeoutTimersec_A8297Min
		{
			get
			{
				short num = (short)330629120;
				short num2 = num;
				num = (short)1494332655;
				short num3 = num;
				num = (short)1858712815;
				switch (num3 == num)
				{
				}
				num = (short)203292672;
				if (num != 0)
				{
				}
				num = (short)111935489;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadIntercomTimeoutTimersec_A8297.Min;
			}
			set
			{
				short num = (short)192872448;
				short num2 = num;
				num = (short)1798964589;
				short num3 = num;
				num = (short)256116077;
				switch (num3 == num)
				{
				}
				num = (short)1975648257;
				if (num != 0)
				{
				}
				num = (short)1093992448;
				if (num != 0)
				{
				}
				this.radErgoWideControlHeadIntercomTimeoutTimersec_A8297.Min = value;
			}
		}

		// Token: 0x17003404 RID: 13316
		// (get) Token: 0x0600645B RID: 25691 RVA: 0x005A1974 File Offset: 0x0059FB74
		// (set) Token: 0x0600645C RID: 25692 RVA: 0x005A1A2C File Offset: 0x0059FC2C
		internal int RadErgoWideControlHeadIntercomTimeoutTimersec_A8297Max
		{
			get
			{
				short num = (short)1236205568;
				short num2 = num;
				num = (short)84038209;
				short num3 = num;
				num = (short)100749889;
				switch (num3 == num)
				{
				}
				num = (short)53477377;
				if (num != 0)
				{
				}
				num = (short)1602289664;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadIntercomTimeoutTimersec_A8297.Max;
			}
			set
			{
				short num = (short)389873664;
				short num2 = num;
				num = (short)2026319843;
				short num3 = num;
				num = (short)606941155;
				switch (num3 == num)
				{
				}
				num = (short)1898774529;
				if (num != 0)
				{
				}
				num = (short)1586102272;
				if (num != 0)
				{
				}
				this.radErgoWideControlHeadIntercomTimeoutTimersec_A8297.Max = value;
			}
		}

		// Token: 0x17003405 RID: 13317
		// (get) Token: 0x0600645D RID: 25693 RVA: 0x005A1AE0 File Offset: 0x0059FCE0
		// (set) Token: 0x0600645E RID: 25694 RVA: 0x005A1B98 File Offset: 0x0059FD98
		internal int RadErgoWideControlHeadIntercomTimeoutTimersec_A8297Step
		{
			get
			{
				short num = (short)736596024;
				short num2 = num;
				num = (short)291737656;
				switch (num2 == num)
				{
				}
				num = (short)676397057;
				if (num != 0)
				{
				}
				num = (short)1013776384;
				short num3 = num;
				num = (short)1030488064;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadIntercomTimeoutTimersec_A8297.StepSize;
			}
			set
			{
				short num = (short)52822057;
				short num2 = num;
				num = (short)160366633;
				switch (num2 == num)
				{
				}
				num = (short)168886272;
				if (num != 0)
				{
				}
				num = (short)428539904;
				short num3 = num;
				num = (short)874250241;
				if (num != 0)
				{
				}
				this.radErgoWideControlHeadIntercomTimeoutTimersec_A8297.StepSize = value;
			}
		}

		// Token: 0x17003406 RID: 13318
		// (get) Token: 0x0600645F RID: 25695 RVA: 0x005A1C50 File Offset: 0x0059FE50
		// (set) Token: 0x06006460 RID: 25696 RVA: 0x005A1D04 File Offset: 0x0059FF04
		public bool RadErgoWideControlHeadIntercomTimeoutTimersec_A8297_Applicable
		{
			get
			{
				short num = (short)2033541016;
				short num2 = num;
				num = (short)1092575128;
				switch (num2 == num)
				{
				}
				num = (short)957743105;
				if (num != 0)
				{
				}
				num = (short)816578560;
				short num3 = num;
				num = (short)103415808;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadIntercomTimeoutTimersec_A8297.Applicable;
			}
			set
			{
				short num = (short)7800359;
				short num2 = num;
				num = (short)1805256231;
				switch (num2 == num)
				{
				}
				num = (short)1799553025;
				if (num != 0)
				{
				}
				num = (short)1230176256;
				short num3 = num;
				num = (short)1758986240;
				if (num != 0)
				{
				}
				this.radErgoWideControlHeadIntercomTimeoutTimersec_A8297.Applicable = value;
			}
		}

		// Token: 0x17003407 RID: 13319
		// (get) Token: 0x06006461 RID: 25697 RVA: 0x005A1DBC File Offset: 0x0059FFBC
		// (set) Token: 0x06006462 RID: 25698 RVA: 0x005A1E74 File Offset: 0x005A0074
		public bool RadErgoWideControlHeadIntercomTimeoutTimersec_A8297_Valid
		{
			get
			{
				short num = (short)1548377261;
				short num2 = num;
				num = (short)1945197741;
				switch (num2 == num)
				{
				}
				num = (short)695795713;
				if (num != 0)
				{
				}
				num = (short)809369600;
				short num3 = num;
				num = (short)937230336;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadIntercomTimeoutTimersec_A8297.Valid;
			}
			set
			{
				short num = (short)1213647697;
				short num2 = num;
				num = (short)2037631825;
				switch (num2 == num)
				{
				}
				num = (short)1765146624;
				if (num != 0)
				{
				}
				num = (short)1140260864;
				short num3 = num;
				num = (short)861995009;
				if (num != 0)
				{
				}
				this.radErgoWideControlHeadIntercomTimeoutTimersec_A8297.Valid = value;
			}
		}

		// Token: 0x17003408 RID: 13320
		// (get) Token: 0x06006463 RID: 25699 RVA: 0x005A1F28 File Offset: 0x005A0128
		// (set) Token: 0x06006464 RID: 25700 RVA: 0x005A1FDC File Offset: 0x005A01DC
		public bool RadErgoWideControlHeadIntercomTimeoutTimersec_A8297_Visible
		{
			get
			{
				short num = (short)1330275156;
				short num2 = num;
				num = (short)897934164;
				switch (num2 == num)
				{
				}
				num = (short)997916672;
				if (num != 0)
				{
				}
				num = (short)2139553792;
				short num3 = num;
				num = (short)2139553793;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadIntercomTimeoutTimersec_A8297.Visible;
			}
			set
			{
				short num = (short)1132461574;
				short num2 = num;
				num = (short)51183110;
				switch (num2 == num)
				{
				}
				num = (short)881852417;
				if (num != 0)
				{
				}
				num = (short)1200881664;
				short num3 = num;
				num = (short)336986112;
				if (num != 0)
				{
				}
				this.radErgoWideControlHeadIntercomTimeoutTimersec_A8297.Visible = value;
			}
		}

		// Token: 0x17003409 RID: 13321
		// (get) Token: 0x06006465 RID: 25701 RVA: 0x005A2094 File Offset: 0x005A0294
		// (set) Token: 0x06006466 RID: 25702 RVA: 0x005A2144 File Offset: 0x005A0344
		public bool RadErgoWideControlHeadIntercomTimeoutTimersec_A8297_Editable
		{
			get
			{
				short num = (short)793226361;
				short num2 = num;
				num = (short)518564985;
				switch (num2 == num)
				{
				}
				num = (short)395509761;
				if (num != 0)
				{
				}
				num = (short)1284046848;
				short num3 = num;
				num = (short)378339328;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadIntercomTimeoutTimersec_A8297.Editable;
			}
			set
			{
				short num = (short)1967684298;
				short num2 = num;
				num = (short)1057848010;
				switch (num2 == num)
				{
				}
				num = (short)1617887233;
				if (num != 0)
				{
				}
				num = (short)2062548992;
				short num3 = num;
				num = (short)971505664;
				if (num != 0)
				{
				}
				this.radErgoWideControlHeadIntercomTimeoutTimersec_A8297.Editable = value;
			}
		}

		// Token: 0x1700340A RID: 13322
		// (get) Token: 0x06006467 RID: 25703 RVA: 0x005A21F8 File Offset: 0x005A03F8
		internal string RadErgoWideControlHeadIntercomTimeoutTimersec_A8297_UILabel
		{
			get
			{
				short num = (short)2132492608;
				short num2 = num;
				num = (short)1339441472;
				switch (num2 == num)
				{
				}
				num = (short)789118976;
				if (num != 0)
				{
				}
				num = (short)1206714368;
				short num3 = num;
				num = (short)659750913;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadIntercomTimeoutTimersec_A8297.UIName;
			}
		}

		// Token: 0x1700340B RID: 13323
		// (get) Token: 0x06006468 RID: 25704 RVA: 0x005A22A8 File Offset: 0x005A04A8
		// (set) Token: 0x06006469 RID: 25705 RVA: 0x005A235C File Offset: 0x005A055C
		internal bool RadErgoWideControlHeadIntercomTimeoutTimersec_A8297_HiddenStatic
		{
			get
			{
				short num = (short)2142054609;
				short num2 = num;
				num = (short)839395537;
				switch (num2 == num)
				{
				}
				num = (short)1550843905;
				if (num != 0)
				{
				}
				num = (short)496959488;
				short num3 = num;
				num = (short)783679488;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadIntercomTimeoutTimersec_A8297.HiddenStatic;
			}
			set
			{
				short num = (short)1293891197;
				short num2 = num;
				num = (short)506082941;
				switch (num2 == num)
				{
				}
				num = (short)1586692096;
				if (num != 0)
				{
				}
				num = (short)1059913728;
				short num3 = num;
				num = (short)351731713;
				if (num != 0)
				{
				}
				this.radErgoWideControlHeadIntercomTimeoutTimersec_A8297.HiddenStatic = value;
			}
		}

		// Token: 0x1700340C RID: 13324
		// (get) Token: 0x0600646A RID: 25706 RVA: 0x005A2414 File Offset: 0x005A0614
		// (set) Token: 0x0600646B RID: 25707 RVA: 0x005A24C8 File Offset: 0x005A06C8
		internal bool RadErgoWideControlHeadIntercomTimeoutTimersec_A8297_HiddenDynamic
		{
			get
			{
				short num = (short)1978175066;
				short num2 = num;
				num = (short)409046618;
				switch (num2 == num)
				{
				}
				num = (short)805634048;
				if (num != 0)
				{
				}
				num = (short)254803968;
				short num3 = num;
				num = (short)511967233;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadIntercomTimeoutTimersec_A8297.HiddenDynamic;
			}
			set
			{
				short num = (short)1391620387;
				short num2 = num;
				num = (short)330723619;
				switch (num2 == num)
				{
				}
				num = (short)1579089920;
				if (num != 0)
				{
				}
				num = (short)1568669696;
				short num3 = num;
				num = (short)1206583297;
				if (num != 0)
				{
				}
				this.radErgoWideControlHeadIntercomTimeoutTimersec_A8297.HiddenDynamic = value;
			}
		}

		// Token: 0x1700340D RID: 13325
		// (get) Token: 0x0600646C RID: 25708 RVA: 0x005A257C File Offset: 0x005A077C
		public bool RadErgoWideControlHeadIntercomTimeoutTimersec_A8297_HasDiffs
		{
			get
			{
				short num = (short)495468922;
				short num2 = num;
				num = (short)341787002;
				switch (num2 == num)
				{
				}
				num = (short)1326055425;
				if (num != 0)
				{
				}
				num = (short)1726742528;
				short num3 = num;
				num = (short)1278869504;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadIntercomTimeoutTimersec_A8297._HasDiffs;
			}
		}

		// Token: 0x1700340E RID: 13326
		// (get) Token: 0x0600646D RID: 25709 RVA: 0x005A2630 File Offset: 0x005A0830
		// (set) Token: 0x0600646E RID: 25710 RVA: 0x005A26E4 File Offset: 0x005A08E4
		public bool RadErgoWideControlHeadMultiControlHead_A8550Value
		{
			get
			{
				short num = (short)1661112674;
				short num2 = num;
				num = (short)754291042;
				switch (num2 == num)
				{
				}
				num = (short)276103169;
				if (num != 0)
				{
				}
				num = (short)1768488960;
				short num3 = num;
				num = (short)291504128;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadMultiControlHead_A8550.Value;
			}
			set
			{
				short num = (short)1122041857;
				if (num != 0)
				{
				}
				num = (short)1965786223;
				short num2 = num;
				num = (short)1088390255;
				switch (num2 == num)
				{
				}
				num = (short)1338048512;
				short num3 = num;
				num = (short)231735296;
				if (num != 0)
				{
				}
				this.radErgoWideControlHeadMultiControlHead_A8550.Value = value;
			}
		}

		// Token: 0x1700340F RID: 13327
		// (get) Token: 0x0600646F RID: 25711 RVA: 0x005A2798 File Offset: 0x005A0998
		public global::AcpBusinessLayer.AcpField<bool> RadErgoWideControlHeadMultiControlHead_A8550
		{
			get
			{
				short num = (short)857035189;
				short num2 = num;
				num = (short)2147111349;
				switch (num2 == num)
				{
				}
				num = (short)1473839105;
				if (num != 0)
				{
				}
				num = (short)1173487616;
				short num3 = num;
				num = (short)1964834816;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadMultiControlHead_A8550;
			}
		}

		// Token: 0x17003410 RID: 13328
		// (get) Token: 0x06006470 RID: 25712 RVA: 0x005A2848 File Offset: 0x005A0A48
		// (set) Token: 0x06006471 RID: 25713 RVA: 0x005A28FC File Offset: 0x005A0AFC
		public bool RadErgoWideControlHeadMultiControlHead_A8550_UIValue
		{
			get
			{
				short num = (short)661810979;
				short num2 = num;
				num = (short)547122979;
				switch (num2 == num)
				{
				}
				num = (short)411041792;
				if (num != 0)
				{
				}
				num = (short)21037056;
				short num3 = num;
				num = (short)331677697;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadMultiControlHead_A8550.Value;
			}
			set
			{
				short num = (short)439319091;
				short num2 = num;
				num = (short)1816427059;
				switch (num2 == num)
				{
				}
				num = (short)1679753217;
				if (num != 0)
				{
				}
				num = (short)291110912;
				short num3 = num;
				num = (short)334561280;
				if (num != 0)
				{
				}
				this.radErgoWideControlHeadMultiControlHead_A8550.Value = value;
			}
		}

		// Token: 0x17003411 RID: 13329
		// (get) Token: 0x06006472 RID: 25714 RVA: 0x005A29B4 File Offset: 0x005A0BB4
		// (set) Token: 0x06006473 RID: 25715 RVA: 0x005A2A68 File Offset: 0x005A0C68
		public bool RadErgoWideControlHeadMultiControlHead_A8550_Applicable
		{
			get
			{
				short num = (short)1902182401;
				if (num != 0)
				{
				}
				num = (short)1315809189;
				short num2 = num;
				num = (short)1914349477;
				switch (num2 == num)
				{
				}
				num = (short)1303183360;
				short num3 = num;
				num = (short)1712848896;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadMultiControlHead_A8550.Applicable;
			}
			set
			{
				short num = (short)1598685185;
				if (num != 0)
				{
				}
				num = (short)1049486028;
				short num2 = num;
				num = (short)133817036;
				switch (num2 == num)
				{
				}
				num = (short)311689216;
				short num3 = num;
				num = (short)67698688;
				if (num != 0)
				{
				}
				this.radErgoWideControlHeadMultiControlHead_A8550.Applicable = value;
			}
		}

		// Token: 0x17003412 RID: 13330
		// (get) Token: 0x06006474 RID: 25716 RVA: 0x005A2B1C File Offset: 0x005A0D1C
		// (set) Token: 0x06006475 RID: 25717 RVA: 0x005A2BD0 File Offset: 0x005A0DD0
		public bool RadErgoWideControlHeadMultiControlHead_A8550_Valid
		{
			get
			{
				short num = (short)87228417;
				if (num != 0)
				{
				}
				num = (short)806318420;
				short num2 = num;
				num = (short)778137940;
				switch (num2 == num)
				{
				}
				num = (short)1598357504;
				short num3 = num;
				num = (short)435814400;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadMultiControlHead_A8550.Valid;
			}
			set
			{
				short num = (short)459192132;
				short num2 = num;
				num = (short)1897707332;
				switch (num2 == num)
				{
				}
				num = (short)1968701441;
				if (num != 0)
				{
				}
				num = (short)14024704;
				short num3 = num;
				num = (short)362151936;
				if (num != 0)
				{
				}
				this.radErgoWideControlHeadMultiControlHead_A8550.Valid = value;
			}
		}

		// Token: 0x17003413 RID: 13331
		// (get) Token: 0x06006476 RID: 25718 RVA: 0x005A2C88 File Offset: 0x005A0E88
		// (set) Token: 0x06006477 RID: 25719 RVA: 0x005A2D3C File Offset: 0x005A0F3C
		public bool RadErgoWideControlHeadMultiControlHead_A8550_Visible
		{
			get
			{
				short num = (short)865634776;
				short num2 = num;
				num = (short)1656195544;
				switch (num2 == num)
				{
				}
				num = (short)1389756416;
				if (num != 0)
				{
				}
				num = (short)668270592;
				short num3 = num;
				num = (short)1714618369;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadMultiControlHead_A8550.Visible;
			}
			set
			{
				short num = (short)1261075070;
				short num2 = num;
				num = (short)885226110;
				switch (num2 == num)
				{
				}
				num = (short)172687361;
				if (num != 0)
				{
				}
				num = (short)662700032;
				short num3 = num;
				num = (short)1552941056;
				if (num != 0)
				{
				}
				this.radErgoWideControlHeadMultiControlHead_A8550.Visible = value;
			}
		}

		// Token: 0x17003414 RID: 13332
		// (get) Token: 0x06006478 RID: 25720 RVA: 0x005A2DF0 File Offset: 0x005A0FF0
		// (set) Token: 0x06006479 RID: 25721 RVA: 0x005A2EA4 File Offset: 0x005A10A4
		public bool RadErgoWideControlHeadMultiControlHead_A8550_Editable
		{
			get
			{
				short num = (short)767295489;
				if (num != 0)
				{
				}
				num = (short)1930760389;
				short num2 = num;
				num = (short)891490501;
				switch (num2 == num)
				{
				}
				num = (short)324403200;
				short num3 = num;
				num = (short)373096448;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadMultiControlHead_A8550.Editable;
			}
			set
			{
				short num = (short)948684001;
				short num2 = num;
				num = (short)865780961;
				switch (num2 == num)
				{
				}
				num = (short)443023361;
				if (num != 0)
				{
				}
				num = (short)145752064;
				short num3 = num;
				num = (short)1963982848;
				if (num != 0)
				{
				}
				this.radErgoWideControlHeadMultiControlHead_A8550.Editable = value;
			}
		}

		// Token: 0x17003415 RID: 13333
		// (get) Token: 0x0600647A RID: 25722 RVA: 0x005A2F58 File Offset: 0x005A1158
		internal string RadErgoWideControlHeadMultiControlHead_A8550_UILabel
		{
			get
			{
				short num = (short)446889985;
				if (num != 0)
				{
				}
				num = (short)114241368;
				short num2 = num;
				num = (short)245772120;
				switch (num2 == num)
				{
				}
				num = (short)815333376;
				short num3 = num;
				num = (short)110100480;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadMultiControlHead_A8550.UIName;
			}
		}

		// Token: 0x17003416 RID: 13334
		// (get) Token: 0x0600647B RID: 25723 RVA: 0x005A3008 File Offset: 0x005A1208
		// (set) Token: 0x0600647C RID: 25724 RVA: 0x005A30BC File Offset: 0x005A12BC
		internal bool RadErgoWideControlHeadMultiControlHead_A8550_HiddenStatic
		{
			get
			{
				short num = (short)1832539863;
				short num2 = num;
				num = (short)2071090903;
				switch (num2 == num)
				{
				}
				num = (short)350093312;
				if (num != 0)
				{
				}
				num = (short)636092416;
				short num3 = num;
				num = (short)893517825;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadMultiControlHead_A8550.HiddenStatic;
			}
			set
			{
				short num = (short)1530920961;
				if (num != 0)
				{
				}
				num = (short)1205528291;
				short num2 = num;
				num = (short)1548019427;
				switch (num2 == num)
				{
				}
				num = (short)105709568;
				short num3 = num;
				num = (short)960102400;
				if (num != 0)
				{
				}
				this.radErgoWideControlHeadMultiControlHead_A8550.HiddenStatic = value;
			}
		}

		// Token: 0x17003417 RID: 13335
		// (get) Token: 0x0600647D RID: 25725 RVA: 0x005A3170 File Offset: 0x005A1370
		// (set) Token: 0x0600647E RID: 25726 RVA: 0x005A3224 File Offset: 0x005A1424
		internal bool RadErgoWideControlHeadMultiControlHead_A8550_HiddenDynamic
		{
			get
			{
				short num = (short)1121868046;
				short num2 = num;
				num = (short)1626691854;
				switch (num2 == num)
				{
				}
				num = (short)1684733953;
				if (num != 0)
				{
				}
				num = (short)876740608;
				short num3 = num;
				num = (short)1413349376;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadMultiControlHead_A8550.HiddenDynamic;
			}
			set
			{
				short num = (short)1447105733;
				short num2 = num;
				num = (short)292099269;
				switch (num2 == num)
				{
				}
				num = (short)656736257;
				if (num != 0)
				{
				}
				num = (short)1674117120;
				short num3 = num;
				num = (short)1227882496;
				if (num != 0)
				{
				}
				this.radErgoWideControlHeadMultiControlHead_A8550.HiddenDynamic = value;
			}
		}

		// Token: 0x17003418 RID: 13336
		// (get) Token: 0x0600647F RID: 25727 RVA: 0x005A32D8 File Offset: 0x005A14D8
		public bool RadErgoWideControlHeadMultiControlHead_A8550_HasDiffs
		{
			get
			{
				short num = (short)527446495;
				short num2 = num;
				num = (short)954872287;
				switch (num2 == num)
				{
				}
				num = (short)1518010369;
				if (num != 0)
				{
				}
				num = (short)1925513216;
				short num3 = num;
				num = (short)1101594624;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadMultiControlHead_A8550._HasDiffs;
			}
		}

		// Token: 0x17003419 RID: 13337
		// (get) Token: 0x06006480 RID: 25728 RVA: 0x005A3388 File Offset: 0x005A1588
		// (set) Token: 0x06006481 RID: 25729 RVA: 0x005A3440 File Offset: 0x005A1640
		public int RadErgoWideControlHeadMultipleControlHeadStyle_A8561Value
		{
			get
			{
				short num = (short)2037522077;
				short num2 = num;
				num = (short)1302077085;
				switch (num2 == num)
				{
				}
				num = (short)1932591104;
				if (num != 0)
				{
				}
				num = (short)323944448;
				short num3 = num;
				num = (short)74514433;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadMultipleControlHeadStyle_A8561.Value;
			}
			set
			{
				short num = (short)198532351;
				short num2 = num;
				num = (short)155606271;
				switch (num2 == num)
				{
				}
				num = (short)45481985;
				if (num != 0)
				{
				}
				num = (short)2090532864;
				short num3 = num;
				num = (short)363069440;
				if (num != 0)
				{
				}
				this.radErgoWideControlHeadMultipleControlHeadStyle_A8561.Value = value;
			}
		}

		// Token: 0x1700341A RID: 13338
		// (get) Token: 0x06006482 RID: 25730 RVA: 0x005A34F4 File Offset: 0x005A16F4
		// (set) Token: 0x06006483 RID: 25731 RVA: 0x005A35A4 File Offset: 0x005A17A4
		public string RadErgoWideControlHeadMultipleControlHeadStyle_A8561_UIValue
		{
			get
			{
				short num = (short)1088439083;
				short num2 = num;
				num = (short)1375159083;
				switch (num2 == num)
				{
				}
				num = (short)1934163969;
				if (num != 0)
				{
				}
				num = (short)494927872;
				short num3 = num;
				num = (short)401276928;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadMultipleControlHeadStyle_A8561.UIValue;
			}
			set
			{
				short num = (short)928824205;
				short num2 = num;
				num = (short)540851085;
				switch (num2 == num)
				{
				}
				num = (short)118554625;
				if (num != 0)
				{
				}
				num = (short)1410727936;
				short num3 = num;
				num = (short)1863712768;
				if (num != 0)
				{
				}
				this.radErgoWideControlHeadMultipleControlHeadStyle_A8561.UIValue = value;
			}
		}

		// Token: 0x1700341B RID: 13339
		// (get) Token: 0x06006484 RID: 25732 RVA: 0x005A3658 File Offset: 0x005A1858
		public global::AcpBusinessLayer.AcpListField RadErgoWideControlHeadMultipleControlHeadStyle_A8561
		{
			get
			{
				short num = (short)1799041786;
				short num2 = num;
				num = (short)350237434;
				switch (num2 == num)
				{
				}
				num = (short)854786049;
				if (num != 0)
				{
				}
				num = (short)1505230848;
				short num3 = num;
				num = (short)374407168;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadMultipleControlHeadStyle_A8561;
			}
		}

		// Token: 0x1700341C RID: 13340
		// (get) Token: 0x06006485 RID: 25733 RVA: 0x005A370C File Offset: 0x005A190C
		// (set) Token: 0x06006486 RID: 25734 RVA: 0x005A37C0 File Offset: 0x005A19C0
		public bool RadErgoWideControlHeadMultipleControlHeadStyle_A8561_Applicable
		{
			get
			{
				short num = (short)135756224;
				short num2 = num;
				num = (short)940079552;
				switch (num2 == num)
				{
				}
				num = (short)332726273;
				if (num != 0)
				{
				}
				num = (short)2103246848;
				short num3 = num;
				num = (short)1686568960;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadMultipleControlHeadStyle_A8561.Applicable;
			}
			set
			{
				short num = (short)1338432310;
				short num2 = num;
				num = (short)777706294;
				switch (num2 == num)
				{
				}
				num = (short)2054684673;
				if (num != 0)
				{
				}
				num = (short)240189440;
				short num3 = num;
				num = (short)662896640;
				if (num != 0)
				{
				}
				this.radErgoWideControlHeadMultipleControlHeadStyle_A8561.Applicable = value;
			}
		}

		// Token: 0x1700341D RID: 13341
		// (get) Token: 0x06006487 RID: 25735 RVA: 0x005A3874 File Offset: 0x005A1A74
		// (set) Token: 0x06006488 RID: 25736 RVA: 0x005A3928 File Offset: 0x005A1B28
		public bool RadErgoWideControlHeadMultipleControlHeadStyle_A8561_Valid
		{
			get
			{
				short num = (short)998233972;
				short num2 = num;
				num = (short)2069223284;
				switch (num2 == num)
				{
				}
				num = (short)650575873;
				if (num != 0)
				{
				}
				num = (short)1881669632;
				short num3 = num;
				num = (short)1388511232;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadMultipleControlHeadStyle_A8561.Valid;
			}
			set
			{
				short num = (short)670236673;
				if (num != 0)
				{
				}
				num = (short)1750925795;
				short num2 = num;
				num = (short)728105443;
				switch (num2 == num)
				{
				}
				num = (short)1094713344;
				short num3 = num;
				num = (short)1998913536;
				if (num != 0)
				{
				}
				this.radErgoWideControlHeadMultipleControlHeadStyle_A8561.Valid = value;
			}
		}

		// Token: 0x1700341E RID: 13342
		// (get) Token: 0x06006489 RID: 25737 RVA: 0x005A39E0 File Offset: 0x005A1BE0
		// (set) Token: 0x0600648A RID: 25738 RVA: 0x005A3A94 File Offset: 0x005A1C94
		public bool RadErgoWideControlHeadMultipleControlHeadStyle_A8561_Visible
		{
			get
			{
				short num = (short)866523234;
				short num2 = num;
				num = (short)501094498;
				switch (num2 == num)
				{
				}
				num = (short)633208833;
				if (num != 0)
				{
				}
				num = (short)1545273344;
				short num3 = num;
				num = (short)417529856;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadMultipleControlHeadStyle_A8561.Visible;
			}
			set
			{
				short num = (short)1731306692;
				short num2 = num;
				num = (short)1347462340;
				switch (num2 == num)
				{
				}
				num = (short)100990977;
				if (num != 0)
				{
				}
				num = (short)771227648;
				short num3 = num;
				num = (short)1604321280;
				if (num != 0)
				{
				}
				this.radErgoWideControlHeadMultipleControlHeadStyle_A8561.Visible = value;
			}
		}

		// Token: 0x1700341F RID: 13343
		// (get) Token: 0x0600648B RID: 25739 RVA: 0x005A3B4C File Offset: 0x005A1D4C
		// (set) Token: 0x0600648C RID: 25740 RVA: 0x005A3C00 File Offset: 0x005A1E00
		public bool RadErgoWideControlHeadMultipleControlHeadStyle_A8561_Editable
		{
			get
			{
				short num = (short)12479602;
				short num2 = num;
				num = (short)1365142642;
				switch (num2 == num)
				{
				}
				num = (short)1273102337;
				if (num != 0)
				{
				}
				num = (short)1681522688;
				short num3 = num;
				num = (short)1437335552;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadMultipleControlHeadStyle_A8561.Editable;
			}
			set
			{
				short num = (short)2079577181;
				short num2 = num;
				num = (short)1247728733;
				switch (num2 == num)
				{
				}
				num = (short)213909505;
				if (num != 0)
				{
				}
				num = (short)824967168;
				short num3 = num;
				num = (short)1459814400;
				if (num != 0)
				{
				}
				this.radErgoWideControlHeadMultipleControlHeadStyle_A8561.Editable = value;
			}
		}

		// Token: 0x17003420 RID: 13344
		// (get) Token: 0x0600648D RID: 25741 RVA: 0x005A3CB4 File Offset: 0x005A1EB4
		internal string RadErgoWideControlHeadMultipleControlHeadStyle_A8561_UILabel
		{
			get
			{
				short num = (short)318331653;
				short num2 = num;
				num = (short)616127237;
				switch (num2 == num)
				{
				}
				num = (short)993591297;
				if (num != 0)
				{
				}
				num = (short)571146240;
				short num3 = num;
				num = (short)439877632;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadMultipleControlHeadStyle_A8561.UIName;
			}
		}

		// Token: 0x17003421 RID: 13345
		// (get) Token: 0x0600648E RID: 25742 RVA: 0x005A3D68 File Offset: 0x005A1F68
		// (set) Token: 0x0600648F RID: 25743 RVA: 0x005A3E20 File Offset: 0x005A2020
		internal bool RadErgoWideControlHeadMultipleControlHeadStyle_A8561_HiddenStatic
		{
			get
			{
				short num = (short)240123905;
				if (num != 0)
				{
				}
				num = (short)231625716;
				short num2 = num;
				num = (short)1889620980;
				switch (num2 == num)
				{
				}
				num = (short)69271552;
				short num3 = num;
				num = (short)632684544;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadMultipleControlHeadStyle_A8561.HiddenStatic;
			}
			set
			{
				short num = (short)1567734486;
				short num2 = num;
				num = (short)1465236182;
				switch (num2 == num)
				{
				}
				num = (short)503578625;
				if (num != 0)
				{
				}
				num = (short)745472000;
				short num3 = num;
				num = (short)1104412672;
				if (num != 0)
				{
				}
				this.radErgoWideControlHeadMultipleControlHeadStyle_A8561.HiddenStatic = value;
			}
		}

		// Token: 0x17003422 RID: 13346
		// (get) Token: 0x06006490 RID: 25744 RVA: 0x005A3ED4 File Offset: 0x005A20D4
		// (set) Token: 0x06006491 RID: 25745 RVA: 0x005A3F8C File Offset: 0x005A218C
		internal bool RadErgoWideControlHeadMultipleControlHeadStyle_A8561_HiddenDynamic
		{
			get
			{
				short num = (short)1675047040;
				short num2 = num;
				num = (short)1544761472;
				switch (num2 == num)
				{
				}
				num = (short)1521090560;
				if (num != 0)
				{
				}
				num = (short)1930428416;
				short num3 = num;
				num = (short)99155969;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadMultipleControlHeadStyle_A8561.HiddenDynamic;
			}
			set
			{
				short num = (short)348500919;
				short num2 = num;
				num = (short)598848439;
				switch (num2 == num)
				{
				}
				num = (short)457179137;
				if (num != 0)
				{
				}
				num = (short)239140864;
				short num3 = num;
				num = (short)2008940544;
				if (num != 0)
				{
				}
				this.radErgoWideControlHeadMultipleControlHeadStyle_A8561.HiddenDynamic = value;
			}
		}

		// Token: 0x17003423 RID: 13347
		// (get) Token: 0x06006492 RID: 25746 RVA: 0x005A4044 File Offset: 0x005A2244
		public bool RadErgoWideControlHeadMultipleControlHeadStyle_A8561_HasDiffs
		{
			get
			{
				short num = (short)773251869;
				short num2 = num;
				num = (short)1255727901;
				switch (num2 == num)
				{
				}
				num = (short)561119233;
				if (num != 0)
				{
				}
				num = (short)60358656;
				short num3 = num;
				num = (short)281346048;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadMultipleControlHeadStyle_A8561._HasDiffs;
			}
		}

		// Token: 0x17003424 RID: 13348
		// (get) Token: 0x06006493 RID: 25747 RVA: 0x005A40F8 File Offset: 0x005A22F8
		// (set) Token: 0x06006494 RID: 25748 RVA: 0x005A41AC File Offset: 0x005A23AC
		public int RadErgoWideControlHeadRemoteMicSource_A8930Value
		{
			get
			{
				short num = (short)1413985712;
				short num2 = num;
				num = (short)1078179248;
				switch (num2 == num)
				{
				}
				num = (short)717553665;
				if (num != 0)
				{
				}
				num = (short)833421312;
				short num3 = num;
				num = (short)1630076928;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadRemoteMicSource_A8930.Value;
			}
			set
			{
				short num = (short)1303767187;
				short num2 = num;
				num = (short)1897785491;
				switch (num2 == num)
				{
				}
				num = (short)45023233;
				if (num != 0)
				{
				}
				num = (short)1331101696;
				short num3 = num;
				num = (short)769654784;
				if (num != 0)
				{
				}
				this.radErgoWideControlHeadRemoteMicSource_A8930.Value = value;
			}
		}

		// Token: 0x17003425 RID: 13349
		// (get) Token: 0x06006495 RID: 25749 RVA: 0x005A4260 File Offset: 0x005A2460
		// (set) Token: 0x06006496 RID: 25750 RVA: 0x005A4314 File Offset: 0x005A2514
		public string RadErgoWideControlHeadRemoteMicSource_A8930_UIValue
		{
			get
			{
				short num = (short)1218714972;
				short num2 = num;
				num = (short)736304476;
				switch (num2 == num)
				{
				}
				num = (short)1625227265;
				if (num != 0)
				{
				}
				num = (short)1065222144;
				short num3 = num;
				num = (short)1278345216;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadRemoteMicSource_A8930.UIValue;
			}
			set
			{
				short num = (short)2078731844;
				short num2 = num;
				num = (short)825749060;
				switch (num2 == num)
				{
				}
				num = (short)1877803009;
				if (num != 0)
				{
				}
				num = (short)289144832;
				short num3 = num;
				num = (short)1201537024;
				if (num != 0)
				{
				}
				this.radErgoWideControlHeadRemoteMicSource_A8930.UIValue = value;
			}
		}

		// Token: 0x17003426 RID: 13350
		// (get) Token: 0x06006497 RID: 25751 RVA: 0x005A43C8 File Offset: 0x005A25C8
		public global::AcpBusinessLayer.AcpRecRefField RadErgoWideControlHeadRemoteMicSource_A8930
		{
			get
			{
				short num = (short)1046695650;
				short num2 = num;
				num = (short)678579938;
				switch (num2 == num)
				{
				}
				num = (short)1491927041;
				if (num != 0)
				{
				}
				num = (short)1507852288;
				short num3 = num;
				num = (short)1876295680;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadRemoteMicSource_A8930;
			}
		}

		// Token: 0x17003427 RID: 13351
		// (get) Token: 0x06006498 RID: 25752 RVA: 0x005A4478 File Offset: 0x005A2678
		// (set) Token: 0x06006499 RID: 25753 RVA: 0x005A4528 File Offset: 0x005A2728
		public bool RadErgoWideControlHeadRemoteMicSource_A8930_Applicable
		{
			get
			{
				short num = (short)1429721813;
				short num2 = num;
				num = (short)470012629;
				switch (num2 == num)
				{
				}
				num = (short)1935933441;
				if (num != 0)
				{
				}
				num = (short)2049900544;
				short num3 = num;
				num = (short)1494155264;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadRemoteMicSource_A8930.Applicable;
			}
			set
			{
				short num = (short)1446793427;
				short num2 = num;
				num = (short)158748883;
				switch (num2 == num)
				{
				}
				num = (short)1164312577;
				if (num != 0)
				{
				}
				num = (short)935919616;
				short num3 = num;
				num = (short)1988820992;
				if (num != 0)
				{
				}
				this.radErgoWideControlHeadRemoteMicSource_A8930.Applicable = value;
			}
		}

		// Token: 0x17003428 RID: 13352
		// (get) Token: 0x0600649A RID: 25754 RVA: 0x005A45E0 File Offset: 0x005A27E0
		// (set) Token: 0x0600649B RID: 25755 RVA: 0x005A4698 File Offset: 0x005A2898
		public bool RadErgoWideControlHeadRemoteMicSource_A8930_Valid
		{
			get
			{
				short num = (short)1530090126;
				short num2 = num;
				num = (short)1568101006;
				switch (num2 == num)
				{
				}
				num = (short)1153630208;
				if (num != 0)
				{
				}
				num = (short)1473773568;
				short num3 = num;
				num = (short)1855848449;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadRemoteMicSource_A8930.Valid;
			}
			set
			{
				short num = (short)376045569;
				if (num != 0)
				{
				}
				num = (short)1894922533;
				short num2 = num;
				num = (short)1580480805;
				switch (num2 == num)
				{
				}
				num = (short)758775808;
				short num3 = num;
				num = (short)1783889920;
				if (num != 0)
				{
				}
				this.radErgoWideControlHeadRemoteMicSource_A8930.Valid = value;
			}
		}

		// Token: 0x17003429 RID: 13353
		// (get) Token: 0x0600649C RID: 25756 RVA: 0x005A474C File Offset: 0x005A294C
		// (set) Token: 0x0600649D RID: 25757 RVA: 0x005A4800 File Offset: 0x005A2A00
		public bool RadErgoWideControlHeadRemoteMicSource_A8930_Visible
		{
			get
			{
				short num = (short)839154976;
				short num2 = num;
				num = (short)1441627424;
				switch (num2 == num)
				{
				}
				num = (short)1873936385;
				if (num != 0)
				{
				}
				num = (short)1505034240;
				short num3 = num;
				num = (short)2005532672;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadRemoteMicSource_A8930.Visible;
			}
			set
			{
				short num = (short)427500531;
				short num2 = num;
				num = (short)1802445811;
				switch (num2 == num)
				{
				}
				num = (short)1905983489;
				if (num != 0)
				{
				}
				num = (short)1776943104;
				short num3 = num;
				num = (short)756547584;
				if (num != 0)
				{
				}
				this.radErgoWideControlHeadRemoteMicSource_A8930.Visible = value;
			}
		}

		// Token: 0x1700342A RID: 13354
		// (get) Token: 0x0600649E RID: 25758 RVA: 0x005A48B4 File Offset: 0x005A2AB4
		// (set) Token: 0x0600649F RID: 25759 RVA: 0x005A4968 File Offset: 0x005A2B68
		public bool RadErgoWideControlHeadRemoteMicSource_A8930_Editable
		{
			get
			{
				short num = (short)1162893917;
				short num2 = num;
				num = (short)1772903005;
				switch (num2 == num)
				{
				}
				num = (short)669188097;
				if (num != 0)
				{
				}
				num = (short)531234816;
				short num3 = num;
				num = (short)1595932672;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadRemoteMicSource_A8930.Editable;
			}
			set
			{
				short num = (short)243978179;
				short num2 = num;
				num = (short)1439551427;
				switch (num2 == num)
				{
				}
				num = (short)606339073;
				if (num != 0)
				{
				}
				num = (short)756482048;
				short num3 = num;
				num = (short)668729344;
				if (num != 0)
				{
				}
				this.radErgoWideControlHeadRemoteMicSource_A8930.Editable = value;
			}
		}

		// Token: 0x1700342B RID: 13355
		// (get) Token: 0x060064A0 RID: 25760 RVA: 0x005A4A1C File Offset: 0x005A2C1C
		internal string RadErgoWideControlHeadRemoteMicSource_A8930_UILabel
		{
			get
			{
				short num = (short)2070815159;
				short num2 = num;
				num = (short)1599021495;
				switch (num2 == num)
				{
				}
				num = (short)236191745;
				if (num != 0)
				{
				}
				num = (short)283377664;
				short num3 = num;
				num = (short)939130880;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadRemoteMicSource_A8930.UIName;
			}
		}

		// Token: 0x1700342C RID: 13356
		// (get) Token: 0x060064A1 RID: 25761 RVA: 0x005A4AD0 File Offset: 0x005A2CD0
		// (set) Token: 0x060064A2 RID: 25762 RVA: 0x005A4B80 File Offset: 0x005A2D80
		internal bool RadErgoWideControlHeadRemoteMicSource_A8930_HiddenStatic
		{
			get
			{
				short num = (short)1152581633;
				if (num != 0)
				{
				}
				num = (short)270228602;
				short num2 = num;
				num = (short)248798330;
				switch (num2 == num)
				{
				}
				num = (short)1525153792;
				short num3 = num;
				num = (short)1028521984;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadRemoteMicSource_A8930.HiddenStatic;
			}
			set
			{
				short num = (short)842945157;
				short num2 = num;
				num = (short)631984773;
				switch (num2 == num)
				{
				}
				num = (short)747110401;
				if (num != 0)
				{
				}
				num = (short)1594228736;
				short num3 = num;
				num = (short)695205888;
				if (num != 0)
				{
				}
				this.radErgoWideControlHeadRemoteMicSource_A8930.HiddenStatic = value;
			}
		}

		// Token: 0x1700342D RID: 13357
		// (get) Token: 0x060064A3 RID: 25763 RVA: 0x005A4C38 File Offset: 0x005A2E38
		// (set) Token: 0x060064A4 RID: 25764 RVA: 0x005A4CF0 File Offset: 0x005A2EF0
		internal bool RadErgoWideControlHeadRemoteMicSource_A8930_HiddenDynamic
		{
			get
			{
				short num = (short)49669243;
				short num2 = num;
				num = (short)1930749051;
				switch (num2 == num)
				{
				}
				num = (short)1771634688;
				if (num != 0)
				{
				}
				num = (short)2098266112;
				short num3 = num;
				num = (short)1578893313;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadRemoteMicSource_A8930.HiddenDynamic;
			}
			set
			{
				short num = (short)1425952311;
				short num2 = num;
				num = (short)1714769463;
				switch (num2 == num)
				{
				}
				num = (short)1121714177;
				if (num != 0)
				{
				}
				num = (short)255655936;
				short num3 = num;
				num = (short)707002368;
				if (num != 0)
				{
				}
				this.radErgoWideControlHeadRemoteMicSource_A8930.HiddenDynamic = value;
			}
		}

		// Token: 0x1700342E RID: 13358
		// (get) Token: 0x060064A5 RID: 25765 RVA: 0x005A4DAC File Offset: 0x005A2FAC
		public bool RadErgoWideControlHeadRemoteMicSource_A8930_HasDiffs
		{
			get
			{
				short num = (short)1626196194;
				short num2 = num;
				num = (short)1326368994;
				switch (num2 == num)
				{
				}
				num = (short)427032577;
				if (num != 0)
				{
				}
				num = (short)1998848000;
				short num3 = num;
				num = (short)609353728;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadRemoteMicSource_A8930._HasDiffs;
			}
		}

		// Token: 0x1700342F RID: 13359
		// (get) Token: 0x060064A6 RID: 25766 RVA: 0x005A4E60 File Offset: 0x005A3060
		// (set) Token: 0x060064A7 RID: 25767 RVA: 0x005A4F14 File Offset: 0x005A3114
		public int RadErgoWideControlHeadTransceiverDEKDimControl_A9404Value
		{
			get
			{
				short num = (short)756686523;
				short num2 = num;
				num = (short)734600891;
				switch (num2 == num)
				{
				}
				num = (short)1404567553;
				if (num != 0)
				{
				}
				num = (short)1083768832;
				short num3 = num;
				num = (short)570621952;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadTransceiverDEKDimControl_A9404.Value;
			}
			set
			{
				short num = (short)1570698594;
				short num2 = num;
				num = (short)405665122;
				switch (num2 == num)
				{
				}
				num = (short)722141185;
				if (num != 0)
				{
				}
				num = (short)469827584;
				short num3 = num;
				num = (short)2137260032;
				if (num != 0)
				{
				}
				this.radErgoWideControlHeadTransceiverDEKDimControl_A9404.Value = value;
			}
		}

		// Token: 0x17003430 RID: 13360
		// (get) Token: 0x060064A8 RID: 25768 RVA: 0x005A4FC8 File Offset: 0x005A31C8
		// (set) Token: 0x060064A9 RID: 25769 RVA: 0x005A507C File Offset: 0x005A327C
		public string RadErgoWideControlHeadTransceiverDEKDimControl_A9404_UIValue
		{
			get
			{
				short num = (short)51289852;
				short num2 = num;
				num = (short)1116446460;
				switch (num2 == num)
				{
				}
				num = (short)1374093312;
				if (num != 0)
				{
				}
				num = (short)1304625152;
				short num3 = num;
				num = (short)66125825;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadTransceiverDEKDimControl_A9404.UIValue;
			}
			set
			{
				short num = (short)784191537;
				short num2 = num;
				num = (short)588959793;
				switch (num2 == num)
				{
				}
				num = (short)1781530624;
				if (num != 0)
				{
				}
				num = (short)1642921984;
				short num3 = num;
				num = (short)1876819969;
				if (num != 0)
				{
				}
				this.radErgoWideControlHeadTransceiverDEKDimControl_A9404.UIValue = value;
			}
		}

		// Token: 0x17003431 RID: 13361
		// (get) Token: 0x060064AA RID: 25770 RVA: 0x005A5130 File Offset: 0x005A3330
		public global::AcpBusinessLayer.AcpRecRefField RadErgoWideControlHeadTransceiverDEKDimControl_A9404
		{
			get
			{
				short num = (short)1877934081;
				if (num != 0)
				{
				}
				num = (short)501080296;
				short num2 = num;
				num = (short)168812776;
				switch (num2 == num)
				{
				}
				num = (short)1571946496;
				short num3 = num;
				num = (short)249036800;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadTransceiverDEKDimControl_A9404;
			}
		}

		// Token: 0x17003432 RID: 13362
		// (get) Token: 0x060064AB RID: 25771 RVA: 0x005A51E0 File Offset: 0x005A33E0
		// (set) Token: 0x060064AC RID: 25772 RVA: 0x005A5298 File Offset: 0x005A3498
		public bool RadErgoWideControlHeadTransceiverDEKDimControl_A9404_Applicable
		{
			get
			{
				short num = (short)1538611442;
				short num2 = num;
				num = (short)1804294386;
				switch (num2 == num)
				{
				}
				num = (short)1663107073;
				if (num != 0)
				{
				}
				num = (short)256049152;
				short num3 = num;
				num = (short)1992359936;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadTransceiverDEKDimControl_A9404.Applicable;
			}
			set
			{
				short num = (short)57217664;
				short num2 = num;
				num = (short)1687884416;
				switch (num2 == num)
				{
				}
				num = (short)2062811136;
				if (num != 0)
				{
				}
				num = (short)744554496;
				short num3 = num;
				num = (short)1218183169;
				if (num != 0)
				{
				}
				this.radErgoWideControlHeadTransceiverDEKDimControl_A9404.Applicable = value;
			}
		}

		// Token: 0x17003433 RID: 13363
		// (get) Token: 0x060064AD RID: 25773 RVA: 0x005A534C File Offset: 0x005A354C
		// (set) Token: 0x060064AE RID: 25774 RVA: 0x005A5400 File Offset: 0x005A3600
		public bool RadErgoWideControlHeadTransceiverDEKDimControl_A9404_Valid
		{
			get
			{
				short num = (short)582032742;
				short num2 = num;
				num = (short)298786150;
				switch (num2 == num)
				{
				}
				num = (short)12910593;
				if (num != 0)
				{
				}
				num = (short)333053952;
				short num3 = num;
				num = (short)1186267136;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadTransceiverDEKDimControl_A9404.Valid;
			}
			set
			{
				short num = (short)649766432;
				short num2 = num;
				num = (short)887727648;
				switch (num2 == num)
				{
				}
				num = (short)1978597376;
				if (num != 0)
				{
				}
				num = (short)1883176960;
				short num3 = num;
				num = (short)1063124993;
				if (num != 0)
				{
				}
				this.radErgoWideControlHeadTransceiverDEKDimControl_A9404.Valid = value;
			}
		}

		// Token: 0x17003434 RID: 13364
		// (get) Token: 0x060064AF RID: 25775 RVA: 0x005A54B4 File Offset: 0x005A36B4
		// (set) Token: 0x060064B0 RID: 25776 RVA: 0x005A5568 File Offset: 0x005A3768
		public bool RadErgoWideControlHeadTransceiverDEKDimControl_A9404_Visible
		{
			get
			{
				short num = (short)810792383;
				short num2 = num;
				num = (short)168998335;
				switch (num2 == num)
				{
				}
				num = (short)1224605697;
				if (num != 0)
				{
				}
				num = (short)295829504;
				short num3 = num;
				num = (short)1805385728;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadTransceiverDEKDimControl_A9404.Visible;
			}
			set
			{
				short num = (short)377057517;
				short num2 = num;
				num = (short)1444901101;
				switch (num2 == num)
				{
				}
				num = (short)6225921;
				if (num != 0)
				{
				}
				num = (short)971964416;
				short num3 = num;
				num = (short)441581568;
				if (num != 0)
				{
				}
				this.radErgoWideControlHeadTransceiverDEKDimControl_A9404.Visible = value;
			}
		}

		// Token: 0x17003435 RID: 13365
		// (get) Token: 0x060064B1 RID: 25777 RVA: 0x005A561C File Offset: 0x005A381C
		// (set) Token: 0x060064B2 RID: 25778 RVA: 0x005A56D0 File Offset: 0x005A38D0
		public bool RadErgoWideControlHeadTransceiverDEKDimControl_A9404_Editable
		{
			get
			{
				short num = (short)1215526017;
				short num2 = num;
				num = (short)731935873;
				switch (num2 == num)
				{
				}
				num = (short)1968308224;
				if (num != 0)
				{
				}
				num = (short)1797914624;
				short num3 = num;
				num = (short)1002307585;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadTransceiverDEKDimControl_A9404.Editable;
			}
			set
			{
				short num = (short)974323713;
				if (num != 0)
				{
				}
				num = (short)1266755159;
				short num2 = num;
				num = (short)1005856343;
				switch (num2 == num)
				{
				}
				num = (short)1645412352;
				short num3 = num;
				num = (short)1261371392;
				if (num != 0)
				{
				}
				this.radErgoWideControlHeadTransceiverDEKDimControl_A9404.Editable = value;
			}
		}

		// Token: 0x17003436 RID: 13366
		// (get) Token: 0x060064B3 RID: 25779 RVA: 0x005A5784 File Offset: 0x005A3984
		internal string RadErgoWideControlHeadTransceiverDEKDimControl_A9404_UILabel
		{
			get
			{
				short num = (short)1109603116;
				short num2 = num;
				num = (short)1714500396;
				switch (num2 == num)
				{
				}
				num = (short)1077084161;
				if (num != 0)
				{
				}
				num = (short)913965056;
				short num3 = num;
				num = (short)1140326400;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadTransceiverDEKDimControl_A9404.UIName;
			}
		}

		// Token: 0x17003437 RID: 13367
		// (get) Token: 0x060064B4 RID: 25780 RVA: 0x005A583C File Offset: 0x005A3A3C
		// (set) Token: 0x060064B5 RID: 25781 RVA: 0x005A58F0 File Offset: 0x005A3AF0
		internal bool RadErgoWideControlHeadTransceiverDEKDimControl_A9404_HiddenStatic
		{
			get
			{
				short num = (short)2065825793;
				if (num != 0)
				{
				}
				num = (short)474445296;
				short num2 = num;
				num = (short)1070626288;
				switch (num2 == num)
				{
				}
				num = (short)53411840;
				short num3 = num;
				num = (short)765984768;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadTransceiverDEKDimControl_A9404.HiddenStatic;
			}
			set
			{
				short num = (short)692346644;
				short num2 = num;
				num = (short)1985502996;
				switch (num2 == num)
				{
				}
				num = (short)145358849;
				if (num != 0)
				{
				}
				num = (short)1578041344;
				short num3 = num;
				num = (short)1812922368;
				if (num != 0)
				{
				}
				this.radErgoWideControlHeadTransceiverDEKDimControl_A9404.HiddenStatic = value;
			}
		}

		// Token: 0x17003438 RID: 13368
		// (get) Token: 0x060064B6 RID: 25782 RVA: 0x005A59A4 File Offset: 0x005A3BA4
		// (set) Token: 0x060064B7 RID: 25783 RVA: 0x005A5A58 File Offset: 0x005A3C58
		internal bool RadErgoWideControlHeadTransceiverDEKDimControl_A9404_HiddenDynamic
		{
			get
			{
				short num = (short)1163984897;
				if (num != 0)
				{
				}
				num = (short)1125796172;
				short num2 = num;
				num = (short)1444563276;
				switch (num2 == num)
				{
				}
				num = (short)2005073920;
				short num3 = num;
				num = (short)1108475904;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadTransceiverDEKDimControl_A9404.HiddenDynamic;
			}
			set
			{
				short num = (short)1310523393;
				if (num != 0)
				{
				}
				num = (short)1538326848;
				short num2 = num;
				num = (short)1098842432;
				switch (num2 == num)
				{
				}
				num = (short)501940224;
				short num3 = num;
				num = (short)628424704;
				if (num != 0)
				{
				}
				this.radErgoWideControlHeadTransceiverDEKDimControl_A9404.HiddenDynamic = value;
			}
		}

		// Token: 0x17003439 RID: 13369
		// (get) Token: 0x060064B8 RID: 25784 RVA: 0x005A5B0C File Offset: 0x005A3D0C
		public bool RadErgoWideControlHeadTransceiverDEKDimControl_A9404_HasDiffs
		{
			get
			{
				short num = (short)1726508731;
				short num2 = num;
				num = (short)634482363;
				switch (num2 == num)
				{
				}
				num = (short)1669267456;
				if (num != 0)
				{
				}
				num = (short)1213267968;
				short num3 = num;
				num = (short)1392312321;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadTransceiverDEKDimControl_A9404._HasDiffs;
			}
		}

		// Token: 0x1700343A RID: 13370
		// (get) Token: 0x060064B9 RID: 25785 RVA: 0x005A5BC4 File Offset: 0x005A3DC4
		// (set) Token: 0x060064BA RID: 25786 RVA: 0x005A5C7C File Offset: 0x005A3E7C
		public int RadErgoWideControlHeadTransceiverVolumeControl_A9405Value
		{
			get
			{
				short num = (short)191951944;
				short num2 = num;
				num = (short)207025224;
				switch (num2 == num)
				{
				}
				num = (short)811532288;
				if (num != 0)
				{
				}
				num = (short)541261824;
				short num3 = num;
				num = (short)1694367745;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadTransceiverVolumeControl_A9405.Value;
			}
			set
			{
				short num = (short)475588792;
				short num2 = num;
				num = (short)2028595384;
				switch (num2 == num)
				{
				}
				num = (short)333053952;
				if (num != 0)
				{
				}
				num = (short)1961951232;
				short num3 = num;
				num = (short)2012741633;
				if (num != 0)
				{
				}
				this.radErgoWideControlHeadTransceiverVolumeControl_A9405.Value = value;
			}
		}

		// Token: 0x1700343B RID: 13371
		// (get) Token: 0x060064BB RID: 25787 RVA: 0x005A5D30 File Offset: 0x005A3F30
		// (set) Token: 0x060064BC RID: 25788 RVA: 0x005A5DE8 File Offset: 0x005A3FE8
		public string RadErgoWideControlHeadTransceiverVolumeControl_A9405_UIValue
		{
			get
			{
				short num = (short)1654194177;
				if (num != 0)
				{
				}
				num = (short)2007032358;
				short num2 = num;
				num = (short)2120475174;
				switch (num2 == num)
				{
				}
				num = (short)519831552;
				short num3 = num;
				num = (short)856162304;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadTransceiverVolumeControl_A9405.UIValue;
			}
			set
			{
				short num = (short)1875978034;
				short num2 = num;
				num = (short)372123442;
				switch (num2 == num)
				{
				}
				num = (short)238944257;
				if (num != 0)
				{
				}
				num = (short)881721344;
				short num3 = num;
				num = (short)1737097216;
				if (num != 0)
				{
				}
				this.radErgoWideControlHeadTransceiverVolumeControl_A9405.UIValue = value;
			}
		}

		// Token: 0x1700343C RID: 13372
		// (get) Token: 0x060064BD RID: 25789 RVA: 0x005A5EA0 File Offset: 0x005A40A0
		public global::AcpBusinessLayer.AcpRecRefField RadErgoWideControlHeadTransceiverVolumeControl_A9405
		{
			get
			{
				short num = (short)1990369809;
				short num2 = num;
				num = (short)95920657;
				switch (num2 == num)
				{
				}
				num = (short)822476801;
				if (num != 0)
				{
				}
				num = (short)1795358720;
				short num3 = num;
				num = (short)138936320;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadTransceiverVolumeControl_A9405;
			}
		}

		// Token: 0x1700343D RID: 13373
		// (get) Token: 0x060064BE RID: 25790 RVA: 0x005A5F50 File Offset: 0x005A4150
		// (set) Token: 0x060064BF RID: 25791 RVA: 0x005A6008 File Offset: 0x005A4208
		public bool RadErgoWideControlHeadTransceiverVolumeControl_A9405_Applicable
		{
			get
			{
				short num = (short)857735169;
				if (num != 0)
				{
				}
				num = (short)1884117587;
				short num2 = num;
				num = (short)1025333843;
				switch (num2 == num)
				{
				}
				num = (short)1649082368;
				short num3 = num;
				num = (short)1828585472;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadTransceiverVolumeControl_A9405.Applicable;
			}
			set
			{
				short num = (short)1249500656;
				short num2 = num;
				num = (short)741203440;
				switch (num2 == num)
				{
				}
				num = (short)1085734913;
				if (num != 0)
				{
				}
				num = (short)532152320;
				short num3 = num;
				num = (short)1536360448;
				if (num != 0)
				{
				}
				this.radErgoWideControlHeadTransceiverVolumeControl_A9405.Applicable = value;
			}
		}

		// Token: 0x1700343E RID: 13374
		// (get) Token: 0x060064C0 RID: 25792 RVA: 0x005A60C0 File Offset: 0x005A42C0
		// (set) Token: 0x060064C1 RID: 25793 RVA: 0x005A6174 File Offset: 0x005A4374
		public bool RadErgoWideControlHeadTransceiverVolumeControl_A9405_Valid
		{
			get
			{
				short num = (short)73711109;
				short num2 = num;
				num = (short)1247985157;
				switch (num2 == num)
				{
				}
				num = (short)1289027584;
				if (num != 0)
				{
				}
				num = (short)1333395456;
				short num3 = num;
				num = (short)544538625;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadTransceiverVolumeControl_A9405.Valid;
			}
			set
			{
				short num = (short)1561919489;
				if (num != 0)
				{
				}
				num = (short)1677382912;
				short num2 = num;
				num = (short)401200384;
				switch (num2 == num)
				{
				}
				num = (short)254672896;
				short num3 = num;
				num = (short)1117454336;
				if (num != 0)
				{
				}
				this.radErgoWideControlHeadTransceiverVolumeControl_A9405.Valid = value;
			}
		}

		// Token: 0x1700343F RID: 13375
		// (get) Token: 0x060064C2 RID: 25794 RVA: 0x005A6228 File Offset: 0x005A4428
		// (set) Token: 0x060064C3 RID: 25795 RVA: 0x005A62DC File Offset: 0x005A44DC
		public bool RadErgoWideControlHeadTransceiverVolumeControl_A9405_Visible
		{
			get
			{
				short num = (short)505367226;
				short num2 = num;
				num = (short)752831162;
				switch (num2 == num)
				{
				}
				num = (short)1870856192;
				if (num != 0)
				{
				}
				num = (short)1464926208;
				short num3 = num;
				num = (short)1580072961;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadTransceiverVolumeControl_A9405.Visible;
			}
			set
			{
				short num = (short)1120862208;
				short num2 = num;
				num = (short)613775330;
				short num3 = num;
				num = (short)1814919138;
				switch (num3 == num)
				{
				}
				num = (short)50266113;
				if (num != 0)
				{
				}
				num = (short)1509228544;
				if (num != 0)
				{
				}
				this.radErgoWideControlHeadTransceiverVolumeControl_A9405.Visible = value;
			}
		}

		// Token: 0x17003440 RID: 13376
		// (get) Token: 0x060064C4 RID: 25796 RVA: 0x005A6390 File Offset: 0x005A4590
		// (set) Token: 0x060064C5 RID: 25797 RVA: 0x005A6448 File Offset: 0x005A4648
		public bool RadErgoWideControlHeadTransceiverVolumeControl_A9405_Editable
		{
			get
			{
				short num = (short)920322048;
				short num2 = num;
				num = (short)274335872;
				short num3 = num;
				num = (short)468650112;
				switch (num3 == num)
				{
				}
				num = (short)282460161;
				if (num != 0)
				{
				}
				num = (short)992477184;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadTransceiverVolumeControl_A9405.Editable;
			}
			set
			{
				short num = (short)1133641728;
				short num2 = num;
				num = (short)646184961;
				if (num != 0)
				{
				}
				num = (short)2116120440;
				short num3 = num;
				num = (short)771649400;
				switch (num3 == num)
				{
				}
				num = (short)363134976;
				if (num != 0)
				{
				}
				this.radErgoWideControlHeadTransceiverVolumeControl_A9405.Editable = value;
			}
		}

		// Token: 0x17003441 RID: 13377
		// (get) Token: 0x060064C6 RID: 25798 RVA: 0x005A64FC File Offset: 0x005A46FC
		internal string RadErgoWideControlHeadTransceiverVolumeControl_A9405_UILabel
		{
			get
			{
				short num = (short)1514143744;
				short num2 = num;
				num = (short)2026073247;
				short num3 = num;
				num = (short)1998875807;
				switch (num3 == num)
				{
				}
				num = (short)2080047104;
				if (num != 0)
				{
				}
				num = (short)861995009;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadTransceiverVolumeControl_A9405.UIName;
			}
		}

		// Token: 0x17003442 RID: 13378
		// (get) Token: 0x060064C7 RID: 25799 RVA: 0x005A65B4 File Offset: 0x005A47B4
		// (set) Token: 0x060064C8 RID: 25800 RVA: 0x005A666C File Offset: 0x005A486C
		internal bool RadErgoWideControlHeadTransceiverVolumeControl_A9405_HiddenStatic
		{
			get
			{
				short num = (short)613416960;
				short num2 = num;
				num = (short)7235485;
				short num3 = num;
				num = (short)1723099037;
				switch (num3 == num)
				{
				}
				num = (short)1542062081;
				if (num != 0)
				{
				}
				num = (short)482344960;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadTransceiverVolumeControl_A9405.HiddenStatic;
			}
			set
			{
				short num = (short)16711680;
				short num2 = num;
				num = (short)1058051324;
				short num3 = num;
				num = (short)1106285820;
				switch (num3 == num)
				{
				}
				num = (short)144900097;
				if (num != 0)
				{
				}
				num = (short)1944190976;
				if (num != 0)
				{
				}
				this.radErgoWideControlHeadTransceiverVolumeControl_A9405.HiddenStatic = value;
			}
		}

		// Token: 0x17003443 RID: 13379
		// (get) Token: 0x060064C9 RID: 25801 RVA: 0x005A6724 File Offset: 0x005A4924
		// (set) Token: 0x060064CA RID: 25802 RVA: 0x005A67D8 File Offset: 0x005A49D8
		internal bool RadErgoWideControlHeadTransceiverVolumeControl_A9405_HiddenDynamic
		{
			get
			{
				short num = (short)1905000448;
				short num2 = num;
				num = (short)219283457;
				if (num != 0)
				{
				}
				num = (short)1277291963;
				short num3 = num;
				num = (short)448064955;
				switch (num3 == num)
				{
				}
				num = (short)285736960;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadTransceiverVolumeControl_A9405.HiddenDynamic;
			}
			set
			{
				short num = (short)2051473408;
				short num2 = num;
				num = (short)1638930100;
				short num3 = num;
				num = (short)1105991348;
				switch (num3 == num)
				{
				}
				num = (short)1767112705;
				if (num != 0)
				{
				}
				num = (short)1221591040;
				if (num != 0)
				{
				}
				this.radErgoWideControlHeadTransceiverVolumeControl_A9405.HiddenDynamic = value;
			}
		}

		// Token: 0x17003444 RID: 13380
		// (get) Token: 0x060064CB RID: 25803 RVA: 0x005A688C File Offset: 0x005A4A8C
		public bool RadErgoWideControlHeadTransceiverVolumeControl_A9405_HasDiffs
		{
			get
			{
				short num = (short)11796480;
				short num2 = num;
				num = (short)905975905;
				short num3 = num;
				num = (short)1044387937;
				switch (num3 == num)
				{
				}
				num = (short)1963393024;
				if (num != 0)
				{
				}
				num = (short)56492033;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadTransceiverVolumeControl_A9405._HasDiffs;
			}
		}

		// Token: 0x17003445 RID: 13381
		// (get) Token: 0x060064CC RID: 25804 RVA: 0x005A6940 File Offset: 0x005A4B40
		// (set) Token: 0x060064CD RID: 25805 RVA: 0x005A69F4 File Offset: 0x005A4BF4
		public int RadErgoWideControlHeadAggregateCableLength_A38456Value
		{
			get
			{
				short num = (short)1351352320;
				short num2 = num;
				num = (short)655375475;
				short num3 = num;
				num = (short)1223900275;
				switch (num3 == num)
				{
				}
				num = (short)1344929793;
				if (num != 0)
				{
				}
				num = (short)2100297728;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadAggregateCableLength_A38456.Value;
			}
			set
			{
				short num = (short)749600768;
				short num2 = num;
				num = (short)1344771409;
				short num3 = num;
				num = (short)603362641;
				switch (num3 == num)
				{
				}
				num = (short)1407385601;
				if (num != 0)
				{
				}
				num = (short)178716672;
				if (num != 0)
				{
				}
				this.radErgoWideControlHeadAggregateCableLength_A38456.Value = value;
			}
		}

		// Token: 0x17003446 RID: 13382
		// (get) Token: 0x060064CE RID: 25806 RVA: 0x005A6AA8 File Offset: 0x005A4CA8
		// (set) Token: 0x060064CF RID: 25807 RVA: 0x005A6B5C File Offset: 0x005A4D5C
		public string RadErgoWideControlHeadAggregateCableLength_A38456_UIValue
		{
			get
			{
				short num = (short)1720057856;
				short num2 = num;
				num = (short)809188450;
				short num3 = num;
				num = (short)1644379234;
				switch (num3 == num)
				{
				}
				num = (short)172294145;
				if (num != 0)
				{
				}
				num = (short)1021378560;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadAggregateCableLength_A38456.UIValue;
			}
			set
			{
				short num = (short)870121472;
				short num2 = num;
				num = (short)553451521;
				if (num != 0)
				{
				}
				num = (short)427079022;
				short num3 = num;
				num = (short)470398318;
				switch (num3 == num)
				{
				}
				num = (short)201064448;
				if (num != 0)
				{
				}
				this.radErgoWideControlHeadAggregateCableLength_A38456.UIValue = value;
			}
		}

		// Token: 0x17003447 RID: 13383
		// (get) Token: 0x060064D0 RID: 25808 RVA: 0x005A6C10 File Offset: 0x005A4E10
		public global::AcpBusinessLayer.AcpListField RadErgoWideControlHeadAggregateCableLength_A38456
		{
			get
			{
				short num = (short)1784676352;
				short num2 = num;
				num = (short)1820895922;
				short num3 = num;
				num = (short)1125100210;
				switch (num3 == num)
				{
				}
				num = (short)135593985;
				if (num != 0)
				{
				}
				num = (short)1704722432;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadAggregateCableLength_A38456;
			}
		}

		// Token: 0x17003448 RID: 13384
		// (get) Token: 0x060064D1 RID: 25809 RVA: 0x005A6CC0 File Offset: 0x005A4EC0
		// (set) Token: 0x060064D2 RID: 25810 RVA: 0x005A6D78 File Offset: 0x005A4F78
		public bool RadErgoWideControlHeadAggregateCableLength_A38456_Applicable
		{
			get
			{
				short num = (short)901971968;
				short num2 = num;
				num = (short)848403662;
				short num3 = num;
				num = (short)1380949198;
				switch (num3 == num)
				{
				}
				num = (short)1310720001;
				if (num != 0)
				{
				}
				num = (short)1713635328;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadAggregateCableLength_A38456.Applicable;
			}
			set
			{
				short num = (short)1568473088;
				short num2 = num;
				num = (short)51234872;
				short num3 = num;
				num = (short)590137400;
				switch (num3 == num)
				{
				}
				num = (short)11272193;
				if (num != 0)
				{
				}
				num = (short)1833762816;
				if (num != 0)
				{
				}
				this.radErgoWideControlHeadAggregateCableLength_A38456.Applicable = value;
			}
		}

		// Token: 0x17003449 RID: 13385
		// (get) Token: 0x060064D3 RID: 25811 RVA: 0x005A6E2C File Offset: 0x005A502C
		// (set) Token: 0x060064D4 RID: 25812 RVA: 0x005A6EDC File Offset: 0x005A50DC
		public bool RadErgoWideControlHeadAggregateCableLength_A38456_Valid
		{
			get
			{
				short num = (short)1952514048;
				short num2 = num;
				num = (short)844564639;
				short num3 = num;
				num = (short)203819167;
				switch (num3 == num)
				{
				}
				num = (short)733020161;
				if (num != 0)
				{
				}
				num = (short)1170997248;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadAggregateCableLength_A38456.Valid;
			}
			set
			{
				short num = (short)430047232;
				short num2 = num;
				num = (short)1594162588;
				short num3 = num;
				num = (short)298581404;
				switch (num3 == num)
				{
				}
				num = (short)1609826305;
				if (num != 0)
				{
				}
				num = (short)713621504;
				if (num != 0)
				{
				}
				this.radErgoWideControlHeadAggregateCableLength_A38456.Valid = value;
			}
		}

		// Token: 0x1700344A RID: 13386
		// (get) Token: 0x060064D5 RID: 25813 RVA: 0x005A6F90 File Offset: 0x005A5190
		// (set) Token: 0x060064D6 RID: 25814 RVA: 0x005A7044 File Offset: 0x005A5244
		public bool RadErgoWideControlHeadAggregateCableLength_A38456_Visible
		{
			get
			{
				short num = (short)723976192;
				short num2 = num;
				num = (short)1624713009;
				short num3 = num;
				num = (short)1554130737;
				switch (num3 == num)
				{
				}
				num = (short)852230145;
				if (num != 0)
				{
				}
				num = (short)2055471104;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadAggregateCableLength_A38456.Visible;
			}
			set
			{
				short num = (short)1232535552;
				short num2 = num;
				num = (short)707221970;
				short num3 = num;
				num = (short)1254840786;
				switch (num3 == num)
				{
				}
				num = (short)1898512385;
				if (num != 0)
				{
				}
				num = (short)1537409024;
				if (num != 0)
				{
				}
				this.radErgoWideControlHeadAggregateCableLength_A38456.Visible = value;
			}
		}

		// Token: 0x1700344B RID: 13387
		// (get) Token: 0x060064D7 RID: 25815 RVA: 0x005A70F8 File Offset: 0x005A52F8
		// (set) Token: 0x060064D8 RID: 25816 RVA: 0x005A71AC File Offset: 0x005A53AC
		public bool RadErgoWideControlHeadAggregateCableLength_A38456_Editable
		{
			get
			{
				short num = (short)1279721472;
				short num2 = num;
				num = (short)1338688163;
				short num3 = num;
				num = (short)1674953379;
				switch (num3 == num)
				{
				}
				num = (short)1188954112;
				if (num != 0)
				{
				}
				num = (short)2019950593;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadAggregateCableLength_A38456.Editable;
			}
			set
			{
				short num = (short)958791680;
				short num2 = num;
				num = (short)1602682881;
				if (num != 0)
				{
				}
				num = (short)942215981;
				short num3 = num;
				num = (short)1324225325;
				switch (num3 == num)
				{
				}
				num = (short)35061760;
				if (num != 0)
				{
				}
				this.radErgoWideControlHeadAggregateCableLength_A38456.Editable = value;
			}
		}

		// Token: 0x1700344C RID: 13388
		// (get) Token: 0x060064D9 RID: 25817 RVA: 0x005A7264 File Offset: 0x005A5464
		internal string RadErgoWideControlHeadAggregateCableLength_A38456_UILabel
		{
			get
			{
				short num = (short)1883176960;
				short num2 = num;
				num = (short)1150091265;
				if (num != 0)
				{
				}
				num = (short)426987844;
				short num3 = num;
				num = (short)440750404;
				switch (num3 == num)
				{
				}
				num = (short)971571200;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadAggregateCableLength_A38456.UIName;
			}
		}

		// Token: 0x1700344D RID: 13389
		// (get) Token: 0x060064DA RID: 25818 RVA: 0x005A731C File Offset: 0x005A551C
		// (set) Token: 0x060064DB RID: 25819 RVA: 0x005A73D0 File Offset: 0x005A55D0
		internal bool RadErgoWideControlHeadAggregateCableLength_A38456_HiddenStatic
		{
			get
			{
				short num = (short)1447362560;
				short num2 = num;
				num = (short)152073664;
				short num3 = num;
				num = (short)1217754560;
				switch (num3 == num)
				{
				}
				num = (short)1918107649;
				if (num != 0)
				{
				}
				num = (short)1944190976;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadAggregateCableLength_A38456.HiddenStatic;
			}
			set
			{
				short num = (short)1657798656;
				short num2 = num;
				num = (short)955537903;
				short num3 = num;
				num = (short)203971055;
				switch (num3 == num)
				{
				}
				num = (short)286720001;
				if (num != 0)
				{
				}
				num = (short)27590656;
				if (num != 0)
				{
				}
				this.radErgoWideControlHeadAggregateCableLength_A38456.HiddenStatic = value;
			}
		}

		// Token: 0x1700344E RID: 13390
		// (get) Token: 0x060064DC RID: 25820 RVA: 0x005A7488 File Offset: 0x005A5688
		// (set) Token: 0x060064DD RID: 25821 RVA: 0x005A7540 File Offset: 0x005A5740
		internal bool RadErgoWideControlHeadAggregateCableLength_A38456_HiddenDynamic
		{
			get
			{
				short num = (short)1526595584;
				short num2 = num;
				num = (short)1288822825;
				short num3 = num;
				num = (short)1077141545;
				switch (num3 == num)
				{
				}
				num = (short)950861824;
				if (num != 0)
				{
				}
				num = (short)2031878145;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadAggregateCableLength_A38456.HiddenDynamic;
			}
			set
			{
				short num = (short)497418240;
				short num2 = num;
				num = (short)1932147860;
				short num3 = num;
				num = (short)670579860;
				switch (num3 == num)
				{
				}
				num = (short)319356929;
				if (num != 0)
				{
				}
				num = (short)1142358016;
				if (num != 0)
				{
				}
				this.radErgoWideControlHeadAggregateCableLength_A38456.HiddenDynamic = value;
			}
		}

		// Token: 0x1700344F RID: 13391
		// (get) Token: 0x060064DE RID: 25822 RVA: 0x005A75F8 File Offset: 0x005A57F8
		public bool RadErgoWideControlHeadAggregateCableLength_A38456_HasDiffs
		{
			get
			{
				short num = (short)25165824;
				short num2 = num;
				num = (short)256560688;
				short num3 = num;
				num = (short)1333906992;
				switch (num3 == num)
				{
				}
				num = (short)153681920;
				if (num != 0)
				{
				}
				num = (short)618266625;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadAggregateCableLength_A38456._HasDiffs;
			}
		}

		// Token: 0x17003450 RID: 13392
		// (get) Token: 0x060064DF RID: 25823 RVA: 0x005A76AC File Offset: 0x005A58AC
		// (set) Token: 0x060064E0 RID: 25824 RVA: 0x005A7760 File Offset: 0x005A5960
		public bool RadErgoWideControlHeadMulCHTxAudioRouting_A38459Value
		{
			get
			{
				short num = (short)82182144;
				short num2 = num;
				num = (short)537264129;
				if (num != 0)
				{
				}
				num = (short)831585514;
				short num3 = num;
				num = (short)1958411498;
				switch (num3 == num)
				{
				}
				num = (short)431489024;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadMulCHTxAudioRouting_A38459.Value;
			}
			set
			{
				short num = (short)1864761344;
				short num2 = num;
				num = (short)1273918942;
				short num3 = num;
				num = (short)1985050078;
				switch (num3 == num)
				{
				}
				num = (short)141426689;
				if (num != 0)
				{
				}
				num = (short)1494810624;
				if (num != 0)
				{
				}
				this.radErgoWideControlHeadMulCHTxAudioRouting_A38459.Value = value;
			}
		}

		// Token: 0x17003451 RID: 13393
		// (get) Token: 0x060064E1 RID: 25825 RVA: 0x005A7818 File Offset: 0x005A5A18
		public global::AcpBusinessLayer.AcpField<bool> RadErgoWideControlHeadMulCHTxAudioRouting_A38459
		{
			get
			{
				short num = (short)1240530944;
				short num2 = num;
				num = (short)1782055672;
				short num3 = num;
				num = (short)1343750904;
				switch (num3 == num)
				{
				}
				num = (short)924975105;
				if (num != 0)
				{
				}
				num = (short)1302265856;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadMulCHTxAudioRouting_A38459;
			}
		}

		// Token: 0x17003452 RID: 13394
		// (get) Token: 0x060064E2 RID: 25826 RVA: 0x005A78C8 File Offset: 0x005A5AC8
		// (set) Token: 0x060064E3 RID: 25827 RVA: 0x005A797C File Offset: 0x005A5B7C
		public bool RadErgoWideControlHeadMulCHTxAudioRouting_A38459_UIValue
		{
			get
			{
				short num = (short)119472128;
				short num2 = num;
				num = (short)181508845;
				short num3 = num;
				num = (short)86481645;
				switch (num3 == num)
				{
				}
				num = (short)1638400001;
				if (num != 0)
				{
				}
				num = (short)1228341248;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadMulCHTxAudioRouting_A38459.Value;
			}
			set
			{
				short num = (short)87162880;
				short num2 = num;
				num = (short)845495679;
				short num3 = num;
				num = (short)2132557183;
				switch (num3 == num)
				{
				}
				num = (short)1136984065;
				if (num != 0)
				{
				}
				num = (short)209584128;
				if (num != 0)
				{
				}
				this.radErgoWideControlHeadMulCHTxAudioRouting_A38459.Value = value;
			}
		}

		// Token: 0x17003453 RID: 13395
		// (get) Token: 0x060064E4 RID: 25828 RVA: 0x005A7A30 File Offset: 0x005A5C30
		// (set) Token: 0x060064E5 RID: 25829 RVA: 0x005A7AE8 File Offset: 0x005A5CE8
		public bool RadErgoWideControlHeadMulCHTxAudioRouting_A38459_Applicable
		{
			get
			{
				short num = (short)645595136;
				short num2 = num;
				num = (short)624284332;
				short num3 = num;
				num = (short)215077548;
				switch (num3 == num)
				{
				}
				num = (short)1867644929;
				if (num != 0)
				{
				}
				num = (short)436731904;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadMulCHTxAudioRouting_A38459.Applicable;
			}
			set
			{
				short num = (short)620494848;
				short num2 = num;
				num = (short)361180733;
				short num3 = num;
				num = (short)132066877;
				switch (num3 == num)
				{
				}
				num = (short)2069037057;
				if (num != 0)
				{
				}
				num = (short)1066467328;
				if (num != 0)
				{
				}
				this.radErgoWideControlHeadMulCHTxAudioRouting_A38459.Applicable = value;
			}
		}

		// Token: 0x17003454 RID: 13396
		// (get) Token: 0x060064E6 RID: 25830 RVA: 0x005A7BA0 File Offset: 0x005A5DA0
		// (set) Token: 0x060064E7 RID: 25831 RVA: 0x005A7C54 File Offset: 0x005A5E54
		public bool RadErgoWideControlHeadMulCHTxAudioRouting_A38459_Valid
		{
			get
			{
				short num = (short)488374272;
				short num2 = num;
				num = (short)1841737023;
				short num3 = num;
				num = (short)504409407;
				switch (num3 == num)
				{
				}
				num = (short)834797569;
				if (num != 0)
				{
				}
				num = (short)934674432;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadMulCHTxAudioRouting_A38459.Valid;
			}
			set
			{
				short num = (short)1995636736;
				short num2 = num;
				num = (short)2818420;
				short num3 = num;
				num = (short)494928244;
				switch (num3 == num)
				{
				}
				num = (short)898301953;
				if (num != 0)
				{
				}
				num = (short)1991311360;
				if (num != 0)
				{
				}
				this.radErgoWideControlHeadMulCHTxAudioRouting_A38459.Valid = value;
			}
		}

		// Token: 0x17003455 RID: 13397
		// (get) Token: 0x060064E8 RID: 25832 RVA: 0x005A7D08 File Offset: 0x005A5F08
		// (set) Token: 0x060064E9 RID: 25833 RVA: 0x005A7DB8 File Offset: 0x005A5FB8
		public bool RadErgoWideControlHeadMulCHTxAudioRouting_A38459_Visible
		{
			get
			{
				short num = (short)296550400;
				short num2 = num;
				num = (short)697960418;
				short num3 = num;
				num = (short)1620510690;
				switch (num3 == num)
				{
				}
				num = (short)304807936;
				if (num != 0)
				{
				}
				num = (short)1245904897;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadMulCHTxAudioRouting_A38459.Visible;
			}
			set
			{
				short num = (short)1875574784;
				short num2 = num;
				num = (short)1991425721;
				short num3 = num;
				num = (short)1995620025;
				switch (num3 == num)
				{
				}
				num = (short)1321009152;
				if (num != 0)
				{
				}
				num = (short)1810038785;
				if (num != 0)
				{
				}
				this.radErgoWideControlHeadMulCHTxAudioRouting_A38459.Visible = value;
			}
		}

		// Token: 0x17003456 RID: 13398
		// (get) Token: 0x060064EA RID: 25834 RVA: 0x005A7E6C File Offset: 0x005A606C
		// (set) Token: 0x060064EB RID: 25835 RVA: 0x005A7F1C File Offset: 0x005A611C
		public bool RadErgoWideControlHeadMulCHTxAudioRouting_A38459_Editable
		{
			get
			{
				short num = (short)503447552;
				short num2 = num;
				num = (short)1765277697;
				if (num != 0)
				{
				}
				num = (short)1257610799;
				short num3 = num;
				num = (short)1332715055;
				switch (num3 == num)
				{
				}
				num = (short)884801536;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadMulCHTxAudioRouting_A38459.Editable;
			}
			set
			{
				short num = (short)1281294336;
				short num2 = num;
				num = (short)1072562177;
				if (num != 0)
				{
				}
				num = (short)1603242037;
				short num3 = num;
				num = (short)612075573;
				switch (num3 == num)
				{
				}
				num = (short)1024917504;
				if (num != 0)
				{
				}
				this.radErgoWideControlHeadMulCHTxAudioRouting_A38459.Editable = value;
			}
		}

		// Token: 0x17003457 RID: 13399
		// (get) Token: 0x060064EC RID: 25836 RVA: 0x005A7FD0 File Offset: 0x005A61D0
		internal string RadErgoWideControlHeadMulCHTxAudioRouting_A38459_UILabel
		{
			get
			{
				short num = (short)109903872;
				short num2 = num;
				num = (short)841173088;
				short num3 = num;
				num = (short)1658931296;
				switch (num3 == num)
				{
				}
				num = (short)593166336;
				if (num != 0)
				{
				}
				num = (short)595787777;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadMulCHTxAudioRouting_A38459.UIName;
			}
		}

		// Token: 0x17003458 RID: 13400
		// (get) Token: 0x060064ED RID: 25837 RVA: 0x005A8084 File Offset: 0x005A6284
		// (set) Token: 0x060064EE RID: 25838 RVA: 0x005A8138 File Offset: 0x005A6338
		internal bool RadErgoWideControlHeadMulCHTxAudioRouting_A38459_HiddenStatic
		{
			get
			{
				short num = (short)1766195200;
				short num2 = num;
				num = (short)1648177387;
				short num3 = num;
				num = (short)1481847019;
				switch (num3 == num)
				{
				}
				num = (short)1420361729;
				if (num != 0)
				{
				}
				num = (short)1790246912;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadMulCHTxAudioRouting_A38459.HiddenStatic;
			}
			set
			{
				short num = (short)2076508160;
				short num2 = num;
				num = (short)1632814285;
				short num3 = num;
				num = (short)2020590797;
				switch (num3 == num)
				{
				}
				num = (short)835059713;
				if (num != 0)
				{
				}
				num = (short)46858240;
				if (num != 0)
				{
				}
				this.radErgoWideControlHeadMulCHTxAudioRouting_A38459.HiddenStatic = value;
			}
		}

		// Token: 0x17003459 RID: 13401
		// (get) Token: 0x060064EF RID: 25839 RVA: 0x005A81F0 File Offset: 0x005A63F0
		// (set) Token: 0x060064F0 RID: 25840 RVA: 0x005A82A4 File Offset: 0x005A64A4
		internal bool RadErgoWideControlHeadMulCHTxAudioRouting_A38459_HiddenDynamic
		{
			get
			{
				short num = (short)1353252864;
				short num2 = num;
				num = (short)2091309417;
				short num3 = num;
				num = (short)699586921;
				switch (num3 == num)
				{
				}
				num = (short)434896897;
				if (num != 0)
				{
				}
				num = (short)464125952;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadMulCHTxAudioRouting_A38459.HiddenDynamic;
			}
			set
			{
				short num = (short)1401683968;
				short num2 = num;
				num = (short)1460404225;
				if (num != 0)
				{
				}
				num = (short)1520547813;
				short num3 = num;
				num = (short)669628389;
				switch (num3 == num)
				{
				}
				num = (short)1257177088;
				if (num != 0)
				{
				}
				this.radErgoWideControlHeadMulCHTxAudioRouting_A38459.HiddenDynamic = value;
			}
		}

		// Token: 0x1700345A RID: 13402
		// (get) Token: 0x060064F1 RID: 25841 RVA: 0x005A8358 File Offset: 0x005A6558
		public bool RadErgoWideControlHeadMulCHTxAudioRouting_A38459_HasDiffs
		{
			get
			{
				short num = (short)1969094656;
				short num2 = num;
				num = (short)653669193;
				short num3 = num;
				num = (short)1842623305;
				switch (num3 == num)
				{
				}
				num = (short)1352597505;
				if (num != 0)
				{
				}
				num = (short)878968832;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadMulCHTxAudioRouting_A38459._HasDiffs;
			}
		}

		// Token: 0x1700345B RID: 13403
		// (get) Token: 0x060064F2 RID: 25842 RVA: 0x005A840C File Offset: 0x005A660C
		// (set) Token: 0x060064F3 RID: 25843 RVA: 0x005A84C0 File Offset: 0x005A66C0
		public int RadErgoWideControlHeadBluetoothControl_44820Value
		{
			get
			{
				short num = (short)169869312;
				short num2 = num;
				num = (short)1056716660;
				short num3 = num;
				num = (short)1118975860;
				switch (num3 == num)
				{
				}
				num = (short)176685057;
				if (num != 0)
				{
				}
				num = (short)1418919936;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadBluetoothControl_44820.Value;
			}
			set
			{
				short num = (short)1085997056;
				short num2 = num;
				num = (short)96897635;
				short num3 = num;
				num = (short)1191938659;
				switch (num3 == num)
				{
				}
				num = (short)1627717633;
				if (num != 0)
				{
				}
				num = (short)1400700928;
				if (num != 0)
				{
				}
				this.radErgoWideControlHeadBluetoothControl_44820.Value = value;
			}
		}

		// Token: 0x1700345C RID: 13404
		// (get) Token: 0x060064F4 RID: 25844 RVA: 0x005A8578 File Offset: 0x005A6778
		// (set) Token: 0x060064F5 RID: 25845 RVA: 0x005A862C File Offset: 0x005A682C
		public string RadErgoWideControlHeadBluetoothControl_44820_UIValue
		{
			get
			{
				short num = (short)426180608;
				short num2 = num;
				num = (short)23321049;
				short num3 = num;
				num = (short)521460185;
				switch (num3 == num)
				{
				}
				num = (short)1300692992;
				if (num != 0)
				{
				}
				num = (short)1428750337;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadBluetoothControl_44820.UIValue;
			}
			set
			{
				short num = (short)1480982528;
				short num2 = num;
				num = (short)1750487476;
				short num3 = num;
				num = (short)1881887156;
				switch (num3 == num)
				{
				}
				num = (short)1806237697;
				if (num != 0)
				{
				}
				num = (short)1915748352;
				if (num != 0)
				{
				}
				this.radErgoWideControlHeadBluetoothControl_44820.UIValue = value;
			}
		}

		// Token: 0x1700345D RID: 13405
		// (get) Token: 0x060064F6 RID: 25846 RVA: 0x005A86E0 File Offset: 0x005A68E0
		public global::AcpBusinessLayer.AcpRecRefField RadErgoWideControlHeadBluetoothControl_44820
		{
			get
			{
				short num = (short)1408434176;
				short num2 = num;
				num = (short)1153949780;
				short num3 = num;
				num = (short)331604052;
				switch (num3 == num)
				{
				}
				num = (short)935198721;
				if (num != 0)
				{
				}
				num = (short)726269952;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadBluetoothControl_44820;
			}
		}

		// Token: 0x1700345E RID: 13406
		// (get) Token: 0x060064F7 RID: 25847 RVA: 0x005A8790 File Offset: 0x005A6990
		// (set) Token: 0x060064F8 RID: 25848 RVA: 0x005A8844 File Offset: 0x005A6A44
		public bool RadErgoWideControlHeadBluetoothControl_44820_Applicable
		{
			get
			{
				short num = (short)910884864;
				short num2 = num;
				num = (short)1591449300;
				short num3 = num;
				num = (short)14980820;
				switch (num3 == num)
				{
				}
				num = (short)929431552;
				if (num != 0)
				{
				}
				num = (short)840761345;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadBluetoothControl_44820.Applicable;
			}
			set
			{
				short num = (short)1385955328;
				short num2 = num;
				num = (short)1530034989;
				short num3 = num;
				num = (short)1582922541;
				switch (num3 == num)
				{
				}
				num = (short)919797761;
				if (num != 0)
				{
				}
				num = (short)174129152;
				if (num != 0)
				{
				}
				this.radErgoWideControlHeadBluetoothControl_44820.Applicable = value;
			}
		}

		// Token: 0x1700345F RID: 13407
		// (get) Token: 0x060064F9 RID: 25849 RVA: 0x005A88FC File Offset: 0x005A6AFC
		// (set) Token: 0x060064FA RID: 25850 RVA: 0x005A89B0 File Offset: 0x005A6BB0
		public bool RadErgoWideControlHeadBluetoothControl_44820_Valid
		{
			get
			{
				short num = (short)1331494912;
				short num2 = num;
				num = (short)1142786070;
				short num3 = num;
				num = (short)1190627350;
				switch (num3 == num)
				{
				}
				num = (short)654704640;
				if (num != 0)
				{
				}
				num = (short)1016332289;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadBluetoothControl_44820.Valid;
			}
			set
			{
				short num = (short)848756736;
				short num2 = num;
				num = (short)537289908;
				short num3 = num;
				num = (short)746546356;
				switch (num3 == num)
				{
				}
				num = (short)427753473;
				if (num != 0)
				{
				}
				num = (short)1254227968;
				if (num != 0)
				{
				}
				this.radErgoWideControlHeadBluetoothControl_44820.Valid = value;
			}
		}

		// Token: 0x17003460 RID: 13408
		// (get) Token: 0x060064FB RID: 25851 RVA: 0x005A8A68 File Offset: 0x005A6C68
		// (set) Token: 0x060064FC RID: 25852 RVA: 0x005A8B1C File Offset: 0x005A6D1C
		public bool RadErgoWideControlHeadBluetoothControl_44820_Visible
		{
			get
			{
				short num = (short)1347682304;
				short num2 = num;
				num = (short)1239725883;
				short num3 = num;
				num = (short)1179629371;
				switch (num3 == num)
				{
				}
				num = (short)589103105;
				if (num != 0)
				{
				}
				num = (short)2137915392;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadBluetoothControl_44820.Visible;
			}
			set
			{
				short num = (short)2095577527;
				short num2 = num;
				num = (short)2059925943;
				switch (num2 == num)
				{
				}
				num = (short)1043464192;
				if (num != 0)
				{
				}
				num = (short)1764491264;
				short num3 = num;
				num = (short)797966337;
				if (num != 0)
				{
				}
				this.radErgoWideControlHeadBluetoothControl_44820.Visible = value;
			}
		}

		// Token: 0x17003461 RID: 13409
		// (get) Token: 0x060064FD RID: 25853 RVA: 0x005A8BD4 File Offset: 0x005A6DD4
		// (set) Token: 0x060064FE RID: 25854 RVA: 0x005A8C88 File Offset: 0x005A6E88
		public bool RadErgoWideControlHeadBluetoothControl_44820_Editable
		{
			get
			{
				short num = (short)296096432;
				short num2 = num;
				num = (short)2095256240;
				switch (num2 == num)
				{
				}
				num = (short)2144534529;
				if (num != 0)
				{
				}
				num = (short)1684144128;
				short num3 = num;
				num = (short)547094528;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadBluetoothControl_44820.Editable;
			}
			set
			{
				short num = (short)1540130675;
				short num2 = num;
				num = (short)137987955;
				switch (num2 == num)
				{
				}
				num = (short)1117257729;
				if (num != 0)
				{
				}
				num = (short)1572601856;
				short num3 = num;
				num = (short)2146238464;
				if (num != 0)
				{
				}
				this.radErgoWideControlHeadBluetoothControl_44820.Editable = value;
			}
		}

		// Token: 0x17003462 RID: 13410
		// (get) Token: 0x060064FF RID: 25855 RVA: 0x005A8D40 File Offset: 0x005A6F40
		internal string RadErgoWideControlHeadBluetoothControl_44820_UILabel
		{
			get
			{
				short num = (short)38164583;
				short num2 = num;
				num = (short)290871399;
				switch (num2 == num)
				{
				}
				num = (short)625999873;
				if (num != 0)
				{
				}
				num = (short)221577216;
				short num3 = num;
				num = (short)955842560;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadBluetoothControl_44820.UIName;
			}
		}

		// Token: 0x17003463 RID: 13411
		// (get) Token: 0x06006500 RID: 25856 RVA: 0x005A8DF8 File Offset: 0x005A6FF8
		// (set) Token: 0x06006501 RID: 25857 RVA: 0x005A8EAC File Offset: 0x005A70AC
		internal bool RadErgoWideControlHeadBluetoothControl_44820_HiddenStatic
		{
			get
			{
				short num = (short)2098274186;
				short num2 = num;
				num = (short)226238346;
				switch (num2 == num)
				{
				}
				num = (short)1224671233;
				if (num != 0)
				{
				}
				num = (short)595787776;
				short num3 = num;
				num = (short)1127612416;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadBluetoothControl_44820.HiddenStatic;
			}
			set
			{
				short num = (short)384309705;
				short num2 = num;
				num = (short)1023875529;
				switch (num2 == num)
				{
				}
				num = (short)1834352641;
				if (num != 0)
				{
				}
				num = (short)258473984;
				short num3 = num;
				num = (short)1565917184;
				if (num != 0)
				{
				}
				this.radErgoWideControlHeadBluetoothControl_44820.HiddenStatic = value;
			}
		}

		// Token: 0x17003464 RID: 13412
		// (get) Token: 0x06006502 RID: 25858 RVA: 0x005A8F60 File Offset: 0x005A7160
		// (set) Token: 0x06006503 RID: 25859 RVA: 0x005A9018 File Offset: 0x005A7218
		internal bool RadErgoWideControlHeadBluetoothControl_44820_HiddenDynamic
		{
			get
			{
				short num = (short)471376515;
				short num2 = num;
				num = (short)156934787;
				switch (num2 == num)
				{
				}
				num = (short)1283325953;
				if (num != 0)
				{
				}
				num = (short)734855168;
				short num3 = num;
				num = (short)1082195968;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadBluetoothControl_44820.HiddenDynamic;
			}
			set
			{
				short num = (short)1364474235;
				short num2 = num;
				num = (short)783628667;
				switch (num2 == num)
				{
				}
				num = (short)1422589953;
				if (num != 0)
				{
				}
				num = (short)1168048128;
				short num3 = num;
				num = (short)111411200;
				if (num != 0)
				{
				}
				this.radErgoWideControlHeadBluetoothControl_44820.HiddenDynamic = value;
			}
		}

		// Token: 0x17003465 RID: 13413
		// (get) Token: 0x06006504 RID: 25860 RVA: 0x005A90CC File Offset: 0x005A72CC
		public bool RadErgoWideControlHeadBluetoothControl_44820_HasDiffs
		{
			get
			{
				short num = (short)1990064740;
				short num2 = num;
				num = (short)2131294820;
				switch (num2 == num)
				{
				}
				num = (short)1673068544;
				if (num != 0)
				{
				}
				num = (short)1643249664;
				short num3 = num;
				num = (short)22872065;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadBluetoothControl_44820._HasDiffs;
			}
		}

		// Token: 0x17003466 RID: 13414
		// (get) Token: 0x06006505 RID: 25861 RVA: 0x005A9180 File Offset: 0x005A7380
		// (set) Token: 0x06006506 RID: 25862 RVA: 0x005A9234 File Offset: 0x005A7434
		public int RadErgoWideControlHeadPowerUpBrightnessValue
		{
			get
			{
				short num = (short)1234829027;
				short num2 = num;
				num = (short)1421541091;
				switch (num2 == num)
				{
				}
				num = (short)1484455936;
				if (num != 0)
				{
				}
				num = (short)832831488;
				short num3 = num;
				num = (short)454885377;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadPowerUpBrightness.Value;
			}
			set
			{
				short num = (short)1762845378;
				short num2 = num;
				num = (short)1900929730;
				switch (num2 == num)
				{
				}
				num = (short)2077556737;
				if (num != 0)
				{
				}
				num = (short)1661927424;
				short num3 = num;
				num = (short)1818296320;
				if (num != 0)
				{
				}
				this.radErgoWideControlHeadPowerUpBrightness.Value = value;
			}
		}

		// Token: 0x17003467 RID: 13415
		// (get) Token: 0x06006507 RID: 25863 RVA: 0x005A92E8 File Offset: 0x005A74E8
		// (set) Token: 0x06006508 RID: 25864 RVA: 0x005A939C File Offset: 0x005A759C
		public string RadErgoWideControlHeadPowerUpBrightness_UIValue
		{
			get
			{
				short num = (short)1379926017;
				if (num != 0)
				{
				}
				num = (short)1145011316;
				short num2 = num;
				num = (short)2100984948;
				switch (num2 == num)
				{
				}
				num = (short)179765248;
				short num3 = num;
				num = (short)2001076224;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadPowerUpBrightness.UIValue;
			}
			set
			{
				short num = (short)872349697;
				if (num != 0)
				{
				}
				num = (short)773910415;
				short num2 = num;
				num = (short)6680463;
				switch (num2 == num)
				{
				}
				num = (short)1128333312;
				short num3 = num;
				num = (short)480641024;
				if (num != 0)
				{
				}
				this.radErgoWideControlHeadPowerUpBrightness.UIValue = value;
			}
		}

		// Token: 0x17003468 RID: 13416
		// (get) Token: 0x06006509 RID: 25865 RVA: 0x005A9450 File Offset: 0x005A7650
		public global::AcpBusinessLayer.AcpListField RadErgoWideControlHeadPowerUpBrightness
		{
			get
			{
				short num = (short)2111293123;
				short num2 = num;
				num = (short)976144067;
				switch (num2 == num)
				{
				}
				num = (short)2125660161;
				if (num != 0)
				{
				}
				num = (short)212533248;
				short num3 = num;
				num = (short)904790016;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadPowerUpBrightness;
			}
		}

		// Token: 0x17003469 RID: 13417
		// (get) Token: 0x0600650A RID: 25866 RVA: 0x005A9500 File Offset: 0x005A7700
		// (set) Token: 0x0600650B RID: 25867 RVA: 0x005A95B4 File Offset: 0x005A77B4
		public bool RadErgoWideControlHeadPowerUpBrightness_Applicable
		{
			get
			{
				short num = (short)1442382012;
				short num2 = num;
				num = (short)708051132;
				switch (num2 == num)
				{
				}
				num = (short)42926081;
				if (num != 0)
				{
				}
				num = (short)1039007744;
				short num3 = num;
				num = (short)1943994368;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadPowerUpBrightness.Applicable;
			}
			set
			{
				short num = (short)163790562;
				short num2 = num;
				num = (short)863256290;
				switch (num2 == num)
				{
				}
				num = (short)1962147841;
				if (num != 0)
				{
				}
				num = (short)2041118720;
				short num3 = num;
				num = (short)440139776;
				if (num != 0)
				{
				}
				this.radErgoWideControlHeadPowerUpBrightness.Applicable = value;
			}
		}

		// Token: 0x1700346A RID: 13418
		// (get) Token: 0x0600650C RID: 25868 RVA: 0x005A966C File Offset: 0x005A786C
		// (set) Token: 0x0600650D RID: 25869 RVA: 0x005A9720 File Offset: 0x005A7920
		public bool RadErgoWideControlHeadPowerUpBrightness_Valid
		{
			get
			{
				short num = (short)926351361;
				if (num != 0)
				{
				}
				num = (short)1834060033;
				short num2 = num;
				num = (short)735348993;
				switch (num2 == num)
				{
				}
				num = (short)1331822592;
				short num3 = num;
				num = (short)1401159680;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadPowerUpBrightness.Valid;
			}
			set
			{
				short num = (short)882495901;
				short num2 = num;
				num = (short)1878249885;
				switch (num2 == num)
				{
				}
				num = (short)1455095809;
				if (num != 0)
				{
				}
				num = (short)1511915520;
				short num3 = num;
				num = (short)1633681408;
				if (num != 0)
				{
				}
				this.radErgoWideControlHeadPowerUpBrightness.Valid = value;
			}
		}

		// Token: 0x1700346B RID: 13419
		// (get) Token: 0x0600650E RID: 25870 RVA: 0x005A97D8 File Offset: 0x005A79D8
		// (set) Token: 0x0600650F RID: 25871 RVA: 0x005A988C File Offset: 0x005A7A8C
		public bool RadErgoWideControlHeadPowerUpBrightness_Visible
		{
			get
			{
				short num = (short)842268673;
				if (num != 0)
				{
				}
				num = (short)1131051587;
				short num2 = num;
				num = (short)41056835;
				switch (num2 == num)
				{
				}
				num = (short)1005387776;
				short num3 = num;
				num = (short)129499136;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadPowerUpBrightness.Visible;
			}
			set
			{
				short num = (short)1135862338;
				short num2 = num;
				num = (short)81781314;
				switch (num2 == num)
				{
				}
				num = (short)682885121;
				if (num != 0)
				{
				}
				num = (short)2021982208;
				short num3 = num;
				num = (short)1168375808;
				if (num != 0)
				{
				}
				this.radErgoWideControlHeadPowerUpBrightness.Visible = value;
			}
		}

		// Token: 0x1700346C RID: 13420
		// (get) Token: 0x06006510 RID: 25872 RVA: 0x005A9944 File Offset: 0x005A7B44
		// (set) Token: 0x06006511 RID: 25873 RVA: 0x005A99F8 File Offset: 0x005A7BF8
		public bool RadErgoWideControlHeadPowerUpBrightness_Editable
		{
			get
			{
				short num = (short)1319799927;
				short num2 = num;
				num = (short)1431669879;
				switch (num2 == num)
				{
				}
				num = (short)1521352705;
				if (num != 0)
				{
				}
				num = (short)1847984128;
				short num3 = num;
				num = (short)628490240;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadPowerUpBrightness.Editable;
			}
			set
			{
				short num = (short)739155031;
				short num2 = num;
				num = (short)1223007319;
				switch (num2 == num)
				{
				}
				num = (short)596115457;
				if (num != 0)
				{
				}
				num = (short)1074069504;
				short num3 = num;
				num = (short)268435456;
				if (num != 0)
				{
				}
				this.radErgoWideControlHeadPowerUpBrightness.Editable = value;
			}
		}

		// Token: 0x1700346D RID: 13421
		// (get) Token: 0x06006512 RID: 25874 RVA: 0x005A9AB0 File Offset: 0x005A7CB0
		internal string RadErgoWideControlHeadPowerUpBrightness_UILabel
		{
			get
			{
				short num = (short)603890185;
				short num2 = num;
				num = (short)848667145;
				switch (num2 == num)
				{
				}
				num = (short)1621622785;
				if (num != 0)
				{
				}
				num = (short)130154496;
				short num3 = num;
				num = (short)1560936448;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadPowerUpBrightness.UIName;
			}
		}

		// Token: 0x1700346E RID: 13422
		// (get) Token: 0x06006513 RID: 25875 RVA: 0x005A9B64 File Offset: 0x005A7D64
		// (set) Token: 0x06006514 RID: 25876 RVA: 0x005A9C18 File Offset: 0x005A7E18
		internal bool RadErgoWideControlHeadPowerUpBrightness_HiddenStatic
		{
			get
			{
				short num = (short)616869088;
				short num2 = num;
				num = (short)1368960224;
				switch (num2 == num)
				{
				}
				num = (short)62390273;
				if (num != 0)
				{
				}
				num = (short)958136320;
				short num3 = num;
				num = (short)356712448;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadPowerUpBrightness.HiddenStatic;
			}
			set
			{
				short num = (short)134546720;
				short num2 = num;
				num = (short)46269728;
				switch (num2 == num)
				{
				}
				num = (short)1869676545;
				if (num != 0)
				{
				}
				num = (short)1110835200;
				short num3 = num;
				num = (short)2064318464;
				if (num != 0)
				{
				}
				this.radErgoWideControlHeadPowerUpBrightness.HiddenStatic = value;
			}
		}

		// Token: 0x1700346F RID: 13423
		// (get) Token: 0x06006515 RID: 25877 RVA: 0x005A9CCC File Offset: 0x005A7ECC
		// (set) Token: 0x06006516 RID: 25878 RVA: 0x005A9D80 File Offset: 0x005A7F80
		internal bool RadErgoWideControlHeadPowerUpBrightness_HiddenDynamic
		{
			get
			{
				short num = (short)1252803532;
				short num2 = num;
				num = (short)2027439052;
				switch (num2 == num)
				{
				}
				num = (short)38600705;
				if (num != 0)
				{
				}
				num = (short)88932352;
				short num3 = num;
				num = (short)909377536;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadPowerUpBrightness.HiddenDynamic;
			}
			set
			{
				short num = (short)701628417;
				if (num != 0)
				{
				}
				num = (short)981148432;
				short num2 = num;
				num = (short)1903829776;
				switch (num2 == num)
				{
				}
				num = (short)1999503360;
				short num3 = num;
				num = (short)1565130752;
				if (num != 0)
				{
				}
				this.radErgoWideControlHeadPowerUpBrightness.HiddenDynamic = value;
			}
		}

		// Token: 0x17003470 RID: 13424
		// (get) Token: 0x06006517 RID: 25879 RVA: 0x005A9E34 File Offset: 0x005A8034
		public bool RadErgoWideControlHeadPowerUpBrightness_HasDiffs
		{
			get
			{
				short num = (short)1036198954;
				short num2 = num;
				num = (short)1565008938;
				switch (num2 == num)
				{
				}
				num = (short)35389440;
				if (num != 0)
				{
				}
				num = (short)1061421056;
				short num3 = num;
				num = (short)734003201;
				if (num != 0)
				{
				}
				return this.radErgoWideControlHeadPowerUpBrightness._HasDiffs;
			}
		}

		// Token: 0x17003471 RID: 13425
		// (get) Token: 0x06006518 RID: 25880 RVA: 0x005A9EE8 File Offset: 0x005A80E8
		// (set) Token: 0x06006519 RID: 25881 RVA: 0x005A9F9C File Offset: 0x005A819C
		public bool RadioErgoWideControlHeadBlockDarkestDimLevelValue
		{
			get
			{
				short num = (short)48046755;
				short num2 = num;
				num = (short)957948579;
				switch (num2 == num)
				{
				}
				num = (short)826540033;
				if (num != 0)
				{
				}
				num = (short)598343680;
				short num3 = num;
				num = (short)455606272;
				if (num != 0)
				{
				}
				return this.radioErgoWideControlHeadBlockDarkestDimLevel.Value;
			}
			set
			{
				short num = (short)1753678872;
				short num2 = num;
				num = (short)365167640;
				switch (num2 == num)
				{
				}
				num = (short)1106116609;
				if (num != 0)
				{
				}
				num = (short)662110208;
				short num3 = num;
				num = (short)392691712;
				if (num != 0)
				{
				}
				this.radioErgoWideControlHeadBlockDarkestDimLevel.Value = value;
			}
		}

		// Token: 0x17003472 RID: 13426
		// (get) Token: 0x0600651A RID: 25882 RVA: 0x005AA050 File Offset: 0x005A8250
		public global::AcpBusinessLayer.AcpField<bool> RadioErgoWideControlHeadBlockDarkestDimLevel
		{
			get
			{
				short num = (short)165855825;
				short num2 = num;
				num = (short)1842790993;
				switch (num2 == num)
				{
				}
				num = (short)2038366208;
				if (num != 0)
				{
				}
				num = (short)1423179776;
				short num3 = num;
				num = (short)652607489;
				if (num != 0)
				{
				}
				return this.radioErgoWideControlHeadBlockDarkestDimLevel;
			}
		}

		// Token: 0x17003473 RID: 13427
		// (get) Token: 0x0600651B RID: 25883 RVA: 0x005AA100 File Offset: 0x005A8300
		// (set) Token: 0x0600651C RID: 25884 RVA: 0x005AA1B8 File Offset: 0x005A83B8
		public bool RadioErgoWideControlHeadBlockDarkestDimLevel_UIValue
		{
			get
			{
				short num = (short)365841045;
				short num2 = num;
				num = (short)1192512149;
				switch (num2 == num)
				{
				}
				num = (short)893321217;
				if (num != 0)
				{
				}
				num = (short)206635008;
				short num3 = num;
				num = (short)1531641856;
				if (num != 0)
				{
				}
				return this.radioErgoWideControlHeadBlockDarkestDimLevel.Value;
			}
			set
			{
				short num = (short)1096075656;
				short num2 = num;
				num = (short)1470220680;
				switch (num2 == num)
				{
				}
				num = (short)494731264;
				if (num != 0)
				{
				}
				num = (short)841940992;
				short num3 = num;
				num = (short)345767937;
				if (num != 0)
				{
				}
				this.radioErgoWideControlHeadBlockDarkestDimLevel.Value = value;
			}
		}

		// Token: 0x17003474 RID: 13428
		// (get) Token: 0x0600651D RID: 25885 RVA: 0x005AA26C File Offset: 0x005A846C
		// (set) Token: 0x0600651E RID: 25886 RVA: 0x005AA320 File Offset: 0x005A8520
		public bool RadioErgoWideControlHeadBlockDarkestDimLevel_Applicable
		{
			get
			{
				short num = (short)1346565636;
				short num2 = num;
				num = (short)142341636;
				switch (num2 == num)
				{
				}
				num = (short)373948416;
				if (num != 0)
				{
				}
				num = (short)1247281152;
				short num3 = num;
				num = (short)681246721;
				if (num != 0)
				{
				}
				return this.radioErgoWideControlHeadBlockDarkestDimLevel.Applicable;
			}
			set
			{
				short num = (short)1587808189;
				short num2 = num;
				num = (short)1776093117;
				switch (num2 == num)
				{
				}
				num = (short)1814429697;
				if (num != 0)
				{
				}
				num = (short)831520768;
				short num3 = num;
				num = (short)695271424;
				if (num != 0)
				{
				}
				this.radioErgoWideControlHeadBlockDarkestDimLevel.Applicable = value;
			}
		}

		// Token: 0x17003475 RID: 13429
		// (get) Token: 0x0600651F RID: 25887 RVA: 0x005AA3D8 File Offset: 0x005A85D8
		// (set) Token: 0x06006520 RID: 25888 RVA: 0x005AA488 File Offset: 0x005A8688
		public bool RadioErgoWideControlHeadBlockDarkestDimLevel_Valid
		{
			get
			{
				short num = (short)1038480690;
				short num2 = num;
				num = (short)1760359730;
				switch (num2 == num)
				{
				}
				num = (short)540672001;
				if (num != 0)
				{
				}
				num = (short)1282867200;
				short num3 = num;
				num = (short)836042752;
				if (num != 0)
				{
				}
				return this.radioErgoWideControlHeadBlockDarkestDimLevel.Valid;
			}
			set
			{
				short num = (short)1943091013;
				short num2 = num;
				num = (short)1837119301;
				switch (num2 == num)
				{
				}
				num = (short)1824391169;
				if (num != 0)
				{
				}
				num = (short)1933770752;
				short num3 = num;
				num = (short)1952645120;
				if (num != 0)
				{
				}
				this.radioErgoWideControlHeadBlockDarkestDimLevel.Valid = value;
			}
		}

		// Token: 0x17003476 RID: 13430
		// (get) Token: 0x06006521 RID: 25889 RVA: 0x005AA540 File Offset: 0x005A8740
		// (set) Token: 0x06006522 RID: 25890 RVA: 0x005AA5F4 File Offset: 0x005A87F4
		public bool RadioErgoWideControlHeadBlockDarkestDimLevel_Visible
		{
			get
			{
				short num = (short)655377864;
				short num2 = num;
				num = (short)664028616;
				switch (num2 == num)
				{
				}
				num = (short)837222400;
				if (num != 0)
				{
				}
				num = (short)1784020992;
				short num3 = num;
				num = (short)200802305;
				if (num != 0)
				{
				}
				return this.radioErgoWideControlHeadBlockDarkestDimLevel.Visible;
			}
			set
			{
				short num = (short)2910378;
				short num2 = num;
				num = (short)432892074;
				switch (num2 == num)
				{
				}
				num = (short)1967587328;
				if (num != 0)
				{
				}
				num = (short)115998720;
				short num3 = num;
				num = (short)716505089;
				if (num != 0)
				{
				}
				this.radioErgoWideControlHeadBlockDarkestDimLevel.Visible = value;
			}
		}

		// Token: 0x17003477 RID: 13431
		// (get) Token: 0x06006523 RID: 25891 RVA: 0x005AA6AC File Offset: 0x005A88AC
		// (set) Token: 0x06006524 RID: 25892 RVA: 0x005AA75C File Offset: 0x005A895C
		public bool RadioErgoWideControlHeadBlockDarkestDimLevel_Editable
		{
			get
			{
				short num = (short)1681403542;
				short num2 = num;
				num = (short)1164062358;
				switch (num2 == num)
				{
				}
				num = (short)1678245889;
				if (num != 0)
				{
				}
				num = (short)895287296;
				short num3 = num;
				num = (short)136708096;
				if (num != 0)
				{
				}
				return this.radioErgoWideControlHeadBlockDarkestDimLevel.Editable;
			}
			set
			{
				short num = (short)1965854311;
				short num2 = num;
				num = (short)1956220519;
				switch (num2 == num)
				{
				}
				num = (short)1030029313;
				if (num != 0)
				{
				}
				num = (short)1116536832;
				short num3 = num;
				num = (short)626524160;
				if (num != 0)
				{
				}
				this.radioErgoWideControlHeadBlockDarkestDimLevel.Editable = value;
			}
		}

		// Token: 0x17003478 RID: 13432
		// (get) Token: 0x06006525 RID: 25893 RVA: 0x005AA810 File Offset: 0x005A8A10
		internal string RadioErgoWideControlHeadBlockDarkestDimLevel_UILabel
		{
			get
			{
				short num = (short)1313442641;
				short num2 = num;
				num = (short)1688374097;
				switch (num2 == num)
				{
				}
				num = (short)154861569;
				if (num != 0)
				{
				}
				num = (short)1668153344;
				short num3 = num;
				num = (short)330039296;
				if (num != 0)
				{
				}
				return this.radioErgoWideControlHeadBlockDarkestDimLevel.UIName;
			}
		}

		// Token: 0x17003479 RID: 13433
		// (get) Token: 0x06006526 RID: 25894 RVA: 0x005AA8C4 File Offset: 0x005A8AC4
		// (set) Token: 0x06006527 RID: 25895 RVA: 0x005AA978 File Offset: 0x005A8B78
		internal bool RadioErgoWideControlHeadBlockDarkestDimLevel_HiddenStatic
		{
			get
			{
				short num = (short)1164566276;
				short num2 = num;
				num = (short)1872224004;
				switch (num2 == num)
				{
				}
				num = (short)748093440;
				if (num != 0)
				{
				}
				num = (short)929693696;
				short num3 = num;
				num = (short)159055873;
				if (num != 0)
				{
				}
				return this.radioErgoWideControlHeadBlockDarkestDimLevel.HiddenStatic;
			}
			set
			{
				short num = (short)1185087489;
				if (num != 0)
				{
				}
				num = (short)459061506;
				short num2 = num;
				num = (short)1312078082;
				switch (num2 == num)
				{
				}
				num = (short)2113994752;
				short num3 = num;
				num = (short)325713920;
				if (num != 0)
				{
				}
				this.radioErgoWideControlHeadBlockDarkestDimLevel.HiddenStatic = value;
			}
		}

		// Token: 0x1700347A RID: 13434
		// (get) Token: 0x06006528 RID: 25896 RVA: 0x005AAA2C File Offset: 0x005A8C2C
		// (set) Token: 0x06006529 RID: 25897 RVA: 0x005AAAE0 File Offset: 0x005A8CE0
		internal bool RadioErgoWideControlHeadBlockDarkestDimLevel_HiddenDynamic
		{
			get
			{
				short num = (short)851660935;
				short num2 = num;
				num = (short)1752715399;
				switch (num2 == num)
				{
				}
				num = (short)441974785;
				if (num != 0)
				{
				}
				num = (short)473432064;
				short num3 = num;
				num = (short)973602816;
				if (num != 0)
				{
				}
				return this.radioErgoWideControlHeadBlockDarkestDimLevel.HiddenDynamic;
			}
			set
			{
				short num = (short)43956991;
				short num2 = num;
				num = (short)683129599;
				switch (num2 == num)
				{
				}
				num = (short)216596481;
				if (num != 0)
				{
				}
				num = (short)443875328;
				short num3 = num;
				num = (short)1794703360;
				if (num != 0)
				{
				}
				this.radioErgoWideControlHeadBlockDarkestDimLevel.HiddenDynamic = value;
			}
		}

		// Token: 0x1700347B RID: 13435
		// (get) Token: 0x0600652A RID: 25898 RVA: 0x005AAB98 File Offset: 0x005A8D98
		public bool RadioErgoWideControlHeadBlockDarkestDimLevel_HasDiffs
		{
			get
			{
				short num = (short)1299684052;
				short num2 = num;
				num = (short)1837079252;
				switch (num2 == num)
				{
				}
				num = (short)910360577;
				if (num != 0)
				{
				}
				num = (short)960299008;
				short num3 = num;
				num = (short)183107584;
				if (num != 0)
				{
				}
				return this.radioErgoWideControlHeadBlockDarkestDimLevel._HasDiffs;
			}
		}

		// Token: 0x1700347C RID: 13436
		// (get) Token: 0x0600652B RID: 25899 RVA: 0x005AAC4C File Offset: 0x005A8E4C
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide RefRadioWide
		{
			get
			{
				short num = (short)1609634582;
				short num2 = num;
				num = (short)860427030;
				switch (num2 == num)
				{
				}
				num = (short)1751711745;
				if (num != 0)
				{
				}
				num = (short)299499520;
				short num3 = num;
				num = (short)1419378688;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
			}
		}

		// Token: 0x1700347D RID: 13437
		// (get) Token: 0x0600652C RID: 25900 RVA: 0x005AAD0C File Offset: 0x005A8F0C
		public global::Motorola.MackinawCPS.CoreFeatures.DVRSWide.DVRSWide RefDVRSWide
		{
			get
			{
				short num = (short)76632311;
				short num2 = num;
				num = (short)1799835895;
				switch (num2 == num)
				{
				}
				num = (short)1993408513;
				if (num != 0)
				{
				}
				num = (short)2112421888;
				short num3 = num;
				num = (short)1926627328;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(4142)[0] as global::Motorola.MackinawCPS.CoreFeatures.DVRSWide.DVRSWide;
			}
		}

		// Token: 0x0600652D RID: 25901 RVA: 0x005AADC8 File Offset: 0x005A8FC8
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
					if (base.ParentRecset.ContainerDoc == null)
					{
						return result;
					}
					num2 = (short)1249247233;
					if (num2 != 0)
					{
					}
					num2 = (short)1084268913;
					short num3 = num2;
					num2 = (short)953131377;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return result;
					default:
						num2 = (short)1349582848;
						if (num2 != 0)
						{
						}
						num2 = (short)611057665;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)219086852;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (base.ParentRecset != null)
					{
						num2 = (short)1592918019;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 3:
				{
					num2 = (short)938868736;
					short num4 = num2;
					num2 = (short)1628307456;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 4:
					return result;
				}
				goto IL_24;
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)1064894466;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04002632 RID: 9778
		private global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.ControlHeadAliasListInnerRecset innerRecset;

		// Token: 0x04002633 RID: 9779
		private global::AcpBusinessLayer.AcpRecRefField radErgoWideControlHeadControlHeadVIPInputSource_A7724;

		// Token: 0x04002634 RID: 9780
		private global::AcpBusinessLayer.AcpField<bool> radErgoWideControlHeadControlHeadsRequiredforPowerUp_A7725;

		// Token: 0x04002635 RID: 9781
		private global::AcpBusinessLayer.AcpListField radErgoWideControlHeadExpectedNumofControlHeads_A7982;

		// Token: 0x04002636 RID: 9782
		private global::AcpBusinessLayer.AcpSimpleRangeField radErgoWideControlHeadIntercomTimeoutTimersec_A8297;

		// Token: 0x04002637 RID: 9783
		private global::AcpBusinessLayer.AcpField<bool> radErgoWideControlHeadMultiControlHead_A8550;

		// Token: 0x04002638 RID: 9784
		private global::AcpBusinessLayer.AcpListField radErgoWideControlHeadMultipleControlHeadStyle_A8561;

		// Token: 0x04002639 RID: 9785
		private global::AcpBusinessLayer.AcpRecRefField radErgoWideControlHeadRemoteMicSource_A8930;

		// Token: 0x0400263A RID: 9786
		private global::AcpBusinessLayer.AcpRecRefField radErgoWideControlHeadTransceiverDEKDimControl_A9404;

		// Token: 0x0400263B RID: 9787
		private global::AcpBusinessLayer.AcpRecRefField radErgoWideControlHeadTransceiverVolumeControl_A9405;

		// Token: 0x0400263C RID: 9788
		private global::AcpBusinessLayer.AcpListField radErgoWideControlHeadAggregateCableLength_A38456;

		// Token: 0x0400263D RID: 9789
		private global::AcpBusinessLayer.AcpField<bool> radErgoWideControlHeadMulCHTxAudioRouting_A38459;

		// Token: 0x0400263E RID: 9790
		private global::AcpBusinessLayer.AcpRecRefField radErgoWideControlHeadBluetoothControl_44820;

		// Token: 0x0400263F RID: 9791
		private global::AcpBusinessLayer.AcpListField radErgoWideControlHeadPowerUpBrightness;

		// Token: 0x04002640 RID: 9792
		private global::AcpBusinessLayer.AcpField<bool> radioErgoWideControlHeadBlockDarkestDimLevel;
	}
}
