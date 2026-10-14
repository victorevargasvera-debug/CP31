using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AcpCommonLib.UndoRedo;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.RadioInformation
{
	// Token: 0x020001AA RID: 426
	[global::System.Serializable]
	public class FrequencyRanges : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x060045BA RID: 17850 RVA: 0x0040BEB0 File Offset: 0x0040A0B0
		public FrequencyRanges(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x060045BB RID: 17851 RVA: 0x0040BECC File Offset: 0x0040A0CC
		protected FrequencyRanges(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x060045BC RID: 17852 RVA: 0x0040BEE4 File Offset: 0x0040A0E4
		public override void Init()
		{
			int a_ = 9;
			short num = (short)1388754446;
			short num2 = num;
			num = (short)1004058126;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1373634560;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1606615041;
			if (num != 0)
			{
			}
			num = (short)1543962624;
			if (num != 0)
			{
			}
			this.radInfoFrequencyRangesVHFUsedinCodeplug_A8481 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("飉귋꫍駏병닓맕黗꣙맛꿝闟蟡諣藥釧룩跫胭韯韱蟳ꃵ냷볹ꧻ跽旿昁洃栅䬇攉栋欍怏縑愓焕䜗嬙␛⨝᠟ጡ", a_), global::CommonResources.AcgResources.ID_CODEPLUGFREQUENCIESVHFUSEDINCODEPLUG);
			this.radInfoFrequencyRangesVHFUsedinCodeplug_A8481.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.radInfoFrequencyRangesVHFUsedinCodeplug_A8481.DataTransferOrder = 10;
			this.radInfoFrequencyRangesUHF1UsedinCodeplug_A8504 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("飉귋꫍駏병닓맕黗꣙맛꿝闟蟡諣藥釧룩跫胭韯韱蟳ꏵ냷볹췻꯽珿朁怃漅昇䤉挋樍甏我砓挕缗䔙崛☝ᔟሡဣ", a_), global::CommonResources.AcgResources.ID_CODEPLUGFREQUENCIESUHF1USEDINCODEPLUG);
			this.radInfoFrequencyRangesUHF1UsedinCodeplug_A8504.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.radInfoFrequencyRangesUHF1UsedinCodeplug_A8504.DataTransferOrder = 11;
			this.radInfoFrequencyRangesUHF2UsedinCodeplug_A8507 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("飉귋꫍駏병닓맕黗꣙맛꿝闟蟡諣藥釧룩跫胭韯韱蟳ꏵ냷볹컻꯽珿朁怃漅昇䤉挋樍甏我砓挕缗䔙崛☝ᔟሡጣ", a_), global::CommonResources.AcgResources.ID_CODEPLUGFREQUENCIESUHF2USEDINCODEPLUG);
			this.radInfoFrequencyRangesUHF2UsedinCodeplug_A8507.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.radInfoFrequencyRangesUHF2UsedinCodeplug_A8507.DataTransferOrder = 12;
			this.radInfoFrequencyRanges7800MHzUsedinCodeplug_A8512 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("飉귋꫍駏병닓맕黗꣙맛꿝闟蟡諣藥釧룩跫胭韯韱蟳쇵샷쫹쳻돽䣿码儃甅洇渉攋怍匏紑瀓猕栗瘙椛礝缟挡ᰣጥᤧᠩ", a_), global::CommonResources.AcgResources.ID_CODEPLUGFREQUENCIES7800MHZUSEDINCODEPLUG);
			this.radInfoFrequencyRanges7800MHzUsedinCodeplug_A8512.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.radInfoFrequencyRanges7800MHzUsedinCodeplug_A8512.DataTransferOrder = 13;
			this.radInfoFrequencyRanges900MHzUsedinCodeplug_A8516 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("飉귋꫍駏병닓맕黗꣙맛꿝闟蟡諣藥釧룩跫胭韯韱蟳쿵죷쫹뇻뛽竿圁眃挅氇按戋䴍缏瘑焓昕琗漙笛䄝感ᨡᄣᜥḧ", a_), global::CommonResources.AcgResources.ID_CODEPLUGFREQUENCIES900MHZUSEDINCODEPLUG);
			this.radInfoFrequencyRanges900MHzUsedinCodeplug_A8516.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.radInfoFrequencyRanges900MHzUsedinCodeplug_A8516.DataTransferOrder = 14;
			this.radInfoFrequencyRangesAllowInvalidFrequencies_A12493 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("飉귋꫍駏병닓맕黗꣙맛꿝闟蟡諣藥釧룩跫胭韯韱蟳럵铷雹鏻觽䧿氁爃朅搇按栋䠍戏眑攓挕紗琙缛眝䔟儡笣朥ᤧᠩᠫᜭ̯", a_), global::CommonResources.AcgResources.ID_CODEPLUGFREQUENCIESALLOWINVALIDFREQUENCIES);
			this.radInfoFrequencyRangesAllowInvalidFrequencies_A12493.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.radInfoFrequencyRangesAllowInvalidFrequencies_A12493.DataTransferOrder = 2;
			this.radInfoFrequencyRangesOpenFrequency_A22699 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("飉귋꫍駏병닓맕黗꣙맛꿝闟蟡諣藥釧룩跫胭韯韱蟳맵裷鿹鋻룽狿朁甃猅洇搉漋眍伏匑☓␕⸗⌙┛", a_), global::CommonResources.AcgResources.ID_OPENFREQUENCY);
			this.radInfoFrequencyRangesOpenFrequency_A22699.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radInfoFrequencyRangesOpenFrequency_A22699.DataTransferOrder = 6;
			this.radInfoFrequencyRangesExtendedUHFR1Capable_A41443 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("飉귋꫍駏병닓맕黗꣙맛꿝闟蟡諣藥釧룩跫胭韯韱蟳돵胷軹駻都擿朁怃包䀇䰉帋㼍匏猑搓眕稗瘙礛䄝感ᘡᔣሥᰧᤩ", a_), global::CommonResources.AcgResources.ID_EXTENDEDUHFR1CAPABLE);
			this.radInfoFrequencyRangesExtendedUHFR1Capable_A41443.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radInfoFrequencyRangesExtendedUHFR1Capable_A41443.DataTransferOrder = -1;
			this.radInfoFrequencyRanges8900MHzUsedinCodeplug_A42502 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("飉귋꫍駏병닓맕黗꣙맛꿝闟蟡諣藥釧룩跫胭韯韱蟳컵쇷쫹쳻돽䣿码儃甅洇渉攋怍匏紑瀓猕栗瘙椛礝缟挡ဣᐥᴧᨩḫ", a_), global::CommonResources.AcgResources.ID_CODEPLUGFREQUENCIES8900MHZUSEDINCODEPLUG);
			this.radInfoFrequencyRanges8900MHzUsedinCodeplug_A42502.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.radInfoFrequencyRanges8900MHzUsedinCodeplug_A42502.DataTransferOrder = 15;
			this.radInfoFrequencyRanges700MHzUsedinCodeplug_A42551 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("飉귋꫍駏병닓맕黗꣙맛꿝闟蟡諣藥釧룩跫胭韯韱蟳쇵죷쫹뇻뛽竿圁眃挅氇按戋䴍缏瘑焓昕琗漙笛䄝感ᘡᘣጥᴧᬩ", a_), global::CommonResources.AcgResources.ID_CODEPLUGFREQUENCIES700MHZUSEDINCODEPLUG);
			this.radInfoFrequencyRanges700MHzUsedinCodeplug_A42551.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.radInfoFrequencyRanges700MHzUsedinCodeplug_A42551.DataTransferOrder = 16;
			this.radInfoFrequencyRanges800MHzUsedinCodeplug_A42552 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("飉귋꫍駏병닓맕黗꣙맛꿝闟蟡諣藥釧룩跫胭韯韱蟳컵죷쫹뇻뛽竿圁眃挅氇按戋䴍缏瘑焓昕琗漙笛䄝感ᘡᘣጥᴧᠩ", a_), global::CommonResources.AcgResources.ID_CODEPLUGFREQUENCIES800MHZUSEDINCODEPLUG);
			this.radInfoFrequencyRanges800MHzUsedinCodeplug_A42552.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.radInfoFrequencyRanges800MHzUsedinCodeplug_A42552.DataTransferOrder = 17;
			this.radInfoFrequencyRangesExtendRange762Capable_A43555 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("飉귋꫍駏병닓맕黗꣙맛꿝闟蟡諣藥釧룩跫胭韯韱蟳돵胷軹駻都擿倁攃栅漇漉㬋㠍∏儑甓昕礗砙瀛笝缟挡ဣᔥᴧἩᤫ", a_), global::CommonResources.AcgResources.ID_EXTENDED700MHZRANGE);
			this.radInfoFrequencyRangesExtendRange762Capable_A43555.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radInfoFrequencyRangesExtendRange762Capable_A43555.DataTransferOrder = -1;
			this.radInfoFrequencyRangesUHFR1480MHzHoptinEnabled_A43575 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("飉귋꫍駏병닓맕黗꣙맛꿝闟蟡諣藥釧룩跫胭韯韱蟳ꏵ냷볹껻쿽㓿㨁㐃䬅䀇瀉䐋愍怏昑紓砕崗琙紛簝䰟䜡䀣礥椧ḩἫᬭܯܱ", a_), global::CommonResources.AcgResources.ID_UHF1480MHZHOPTIONENABLED);
			this.radInfoFrequencyRangesUHFR1480MHzHoptinEnabled_A43575.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radInfoFrequencyRangesUHFR1480MHzHoptinEnabled_A43575.DataTransferOrder = -1;
			this.radInfoFrequencyRangesFWCapableUHFR1480MHz_A43576 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("飉귋꫍駏병닓맕黗꣙맛꿝闟蟡諣藥釧룩跫胭韯韱蟳냵꿷맹鷻軽懿态栃挅崇䈉䨋對ℏ☑Ⱃ☕唗则昛䄝感ᘡᜣጥἧᰩ", a_), global::CommonResources.AcgResources.ID_FWCOMPAREWITHUHF1480MHZEXTENSION);
			this.radInfoFrequencyRangesFWCapableUHFR1480MHz_A43576.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radInfoFrequencyRangesFWCapableUHFR1480MHz_A43576.DataTransferOrder = -1;
			this.radInfoFrequencyRangesExtendedUHFR1480MHzCapable_A43578 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("飉귋꫍駏병닓맕黗꣙맛꿝闟蟡諣藥釧룩跫胭韯韱蟳돵胷軹駻都擿朁怃包䀇䰉帋㼍␏⨑␓嬕倗怙弛缝借䌡䘣䨥䴧甩洫ᨭ̯ܱ̳ี", a_), global::CommonResources.AcgResources.ID_EXTENDEDUHFR1480MHZCAPABLE);
			this.radInfoFrequencyRangesExtendedUHFR1480MHzCapable_A43578.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radInfoFrequencyRangesExtendedUHFR1480MHzCapable_A43578.DataTransferOrder = -1;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("賉뻋ꯍꇏꟑ뇓룕믗ꏙﳛ賝臟賡菣菥鯧", a_);
			base.Id = 10110;
			base.UIName = global::CommonResources.AcgResources.ID_FREQUENCYRANGES;
			base.DataTransferOrder = 2;
		}

		// Token: 0x060045BD RID: 17853 RVA: 0x0040C314 File Offset: 0x0040A514
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 7;
			short num = (short)1676410928;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_68E;
				case 1:
					this.radInfoFrequencyRangesUHF2UsedinCodeplug_A8507 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("髇ꯉ꣋蟍뻏듑믓郕꫗뿙귛ꯝ藟賡蟣鿥뫧诩苫觭闯臱ꇳ뻵뻷죹ꧻ跽旿昁洃栅䬇攉栋欍怏縑愓焕䜗嬙␛⬝ဟᔡ", a_), global::CommonResources.AcgResources.ID_CODEPLUGFREQUENCIESUHF2USEDINCODEPLUG);
					this.radInfoFrequencyRangesUHF2UsedinCodeplug_A8507.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.radInfoFrequencyRangesUHF2UsedinCodeplug_A8507.DataTransferOrder = 12;
					num = (short)793182217;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("髇ꯉ꣋蟍뻏듑믓郕꫗뿙귛ꯝ藟賡蟣鿥뫧诩苫觭闯臱뇳軵賷鿹鋻髽勿持樃愅洇㴉㨋㰍匏猑搓眕稗瘙礛䄝感ᘡᜣጥᴧἩ", a_)))
					{
						num = (short)1196163084;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_207;
				case 3:
					goto IL_3F0;
				case 4:
					goto IL_117;
				case 5:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("髇ꯉ꣋蟍뻏듑믓郕꫗뿙귛ꯝ藟賡蟣鿥뫧诩苫觭闯臱쏳웵죷럹듻蓽嗿焁愃戅愇搉伋愍琏眑搓稕洗紙䌛弝ᐟအᄣጥᤧ", a_)))
					{
						num = (short)847839242;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_117;
				case 6:
					if (producerFields != null)
					{
						num = (short)1131610148;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_B6A;
				case 7:
					goto IL_729;
				case 8:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("髇ꯉ꣋蟍뻏듑믓郕꫗뿙귛ꯝ藟賡蟣鿥뫧诩苫觭闯臱닳ꇵ믷鯹賻鿽拿渁愃包䀇䰉帋㼍␏⨑␓嬕倗怙䌛弝ᐟᄡᄣᄥḧ", a_)))
					{
						num = (short)1956970531;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_B21;
				case 9:
					goto IL_3A0;
				case 10:
					this.radInfoFrequencyRanges700MHzUsedinCodeplug_A42551 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("髇ꯉ꣋蟍뻏듑믓郕꫗뿙귛ꯝ藟賡蟣鿥뫧诩苫觭闯臱쏳웵죷럹듻蓽嗿焁愃戅愇搉伋愍琏眑搓稕洗紙䌛弝ᐟအᄣጥᤧ", a_), global::CommonResources.AcgResources.ID_CODEPLUGFREQUENCIES700MHZUSEDINCODEPLUG);
					this.radInfoFrequencyRanges700MHzUsedinCodeplug_A42551.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.radInfoFrequencyRanges700MHzUsedinCodeplug_A42551.DataTransferOrder = 16;
					num = (short)1995374596;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					goto IL_9B0;
				case 12:
					this.radInfoFrequencyRangesExtendRange762Capable_A43555 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("髇ꯉ꣋蟍뻏듑믓郕꫗뿙귛ꯝ藟賡蟣鿥뫧诩苫觭闯臱뇳軵賷鿹鋻髽勿持樃愅洇㴉㨋㰍匏猑搓眕稗瘙礛䄝感ᘡᜣጥᴧἩ", a_), global::CommonResources.AcgResources.ID_EXTENDED700MHZRANGE);
					this.radInfoFrequencyRangesExtendRange762Capable_A43555.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radInfoFrequencyRangesExtendRange762Capable_A43555.DataTransferOrder = -1;
					num = (short)674955286;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					goto IL_B21;
				case 14:
					num = (short)925564934;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					this.radInfoFrequencyRanges900MHzUsedinCodeplug_A8516 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("髇ꯉ꣋蟍뻏듑믓郕꫗뿙귛ꯝ藟賡蟣鿥뫧诩苫觭闯臱췳웵죷럹듻蓽嗿焁愃戅愇搉伋愍琏眑搓稕洗紙䌛弝᠟ᜡᔣဥ", a_), global::CommonResources.AcgResources.ID_CODEPLUGFREQUENCIES900MHZUSEDINCODEPLUG);
					this.radInfoFrequencyRanges900MHzUsedinCodeplug_A8516.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.radInfoFrequencyRanges900MHzUsedinCodeplug_A8516.DataTransferOrder = 14;
					num = (short)1777401863;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
					this.radInfoFrequencyRanges7800MHzUsedinCodeplug_A8512 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("髇ꯉ꣋蟍뻏듑믓郕꫗뿙귛ꯝ藟賡蟣鿥뫧诩苫觭闯臱쏳컵죷쫹뇻뛽竿圁眃挅氇按戋䴍缏瘑焓昕琗漙笛䄝感ᨡᄣᜥᨧ", a_), global::CommonResources.AcgResources.ID_CODEPLUGFREQUENCIES7800MHZUSEDINCODEPLUG);
					this.radInfoFrequencyRanges7800MHzUsedinCodeplug_A8512.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.radInfoFrequencyRanges7800MHzUsedinCodeplug_A8512.DataTransferOrder = 13;
					goto IL_8F5;
				case 17:
					this.radInfoFrequencyRangesUHFR1480MHzHoptinEnabled_A43575 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("髇ꯉ꣋蟍뻏듑믓郕꫗뿙귛ꯝ藟賡蟣鿥뫧诩苫觭闯臱ꇳ뻵뻷꣹췻쫽㣿㈁䤃丅爇䈉挋縍搏笑稓匕瘗笙縛爝䔟䘡笣朥ᰧᤩᤫ᤭ԯ", a_), global::CommonResources.AcgResources.ID_UHF1480MHZHOPTIONENABLED);
					this.radInfoFrequencyRangesUHFR1480MHzHoptinEnabled_A43575.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radInfoFrequencyRangesUHFR1480MHzHoptinEnabled_A43575.DataTransferOrder = -1;
					num = (short)1422852099;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 18:
					this.radInfoFrequencyRanges8900MHzUsedinCodeplug_A42502 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("髇ꯉ꣋蟍뻏듑믓郕꫗뿙귛ꯝ藟賡蟣鿥뫧诩苫觭闯臱쳳쿵죷쫹뇻뛽竿圁眃挅氇按戋䴍缏瘑焓昕琗漙笛䄝感ᘡᘣጥᠧᠩ", a_), global::CommonResources.AcgResources.ID_CODEPLUGFREQUENCIES8900MHZUSEDINCODEPLUG);
					this.radInfoFrequencyRanges8900MHzUsedinCodeplug_A42502.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.radInfoFrequencyRanges8900MHzUsedinCodeplug_A42502.DataTransferOrder = 15;
					num = (short)1113653276;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 19:
					goto IL_549;
				case 20:
					this.radInfoFrequencyRangesUHF1UsedinCodeplug_A8504 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("髇ꯉ꣋蟍뻏듑믓郕꫗뿙귛ꯝ藟賡蟣鿥뫧诩苫觭闯臱ꇳ뻵뻷쯹ꧻ跽旿昁洃栅䬇攉栋欍怏縑愓焕䜗嬙␛⬝ဟᘡ", a_), global::CommonResources.AcgResources.ID_CODEPLUGFREQUENCIESUHF1USEDINCODEPLUG);
					this.radInfoFrequencyRangesUHF1UsedinCodeplug_A8504.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.radInfoFrequencyRangesUHF1UsedinCodeplug_A8504.DataTransferOrder = 11;
					num = (short)846135315;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 21:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("髇ꯉ꣋蟍뻏듑믓郕꫗뿙귛ꯝ藟賡蟣鿥뫧诩苫觭闯臱쏳컵죷쫹뇻뛽竿圁眃挅氇按戋䴍缏瘑焓昕琗漙笛䄝感ᨡᄣᜥᨧ", a_)))
					{
						num = (short)795410448;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5EC;
				case 22:
					goto IL_207;
				case 23:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("髇ꯉ꣋蟍뻏듑믓郕꫗뿙귛ꯝ藟賡蟣鿥뫧诩苫觭闯臱뇳軵賷鿹鋻髽旿昁儃丅万堉㴋㨍⠏∑夓帕戗夙紛渝䄟䀡䠣䌥眧欩ᠫᴭԯԱళ", a_)))
					{
						num = (short)2090401825;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_B6A;
				case 24:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("髇ꯉ꣋蟍뻏듑믓郕꫗뿙귛ꯝ藟賡蟣鿥뫧诩苫觭闯臱믳蛵鷷铹뫻賽旿猁焃挅昇椉甋儍儏‑☓―℗⌙", a_)))
					{
						num = (short)296550430;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_9B0;
				case 25:
					goto IL_6DB;
				case 26:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("髇ꯉ꣋蟍뻏듑믓郕꫗뿙귛ꯝ藟賡蟣鿥뫧诩苫觭闯臱쳳쿵죷쫹뇻뛽竿圁眃挅氇按戋䴍缏瘑焓昕琗漙笛䄝感ᘡᘣጥᠧᠩ", a_)))
					{
						num = (short)463732754;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_772;
				case 27:
					this.radInfoFrequencyRangesExtendedUHFR1Capable_A41443 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("髇ꯉ꣋蟍뻏듑믓郕꫗뿙귛ꯝ藟賡蟣鿥뫧诩苫觭闯臱뇳軵賷鿹鋻髽旿昁儃丅万堉㴋䴍焏我甓琕琗缙䌛弝ᐟጡဣሥᬧ", a_), global::CommonResources.AcgResources.ID_EXTENDEDUHFR1CAPABLE);
					this.radInfoFrequencyRangesExtendedUHFR1Capable_A41443.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radInfoFrequencyRangesExtendedUHFR1Capable_A41443.DataTransferOrder = -1;
					num = (short)398589997;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 28:
					goto IL_772;
				case 29:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("髇ꯉ꣋蟍뻏듑믓郕꫗뿙귛ꯝ藟賡蟣鿥뫧诩苫觭闯臱ꇳ뻵뻷죹ꧻ跽旿昁洃栅䬇攉栋欍怏縑愓焕䜗嬙␛⬝ဟᔡ", a_)))
					{
						num = (short)89391105;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3A0;
				case 30:
				{
					num = (short)1679666086;
					short num3 = num;
					num = (short)1469098918;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_8F5;
					default:
						num = (short)358875136;
						if (num != 0)
						{
						}
						this.radInfoFrequencyRangesOpenFrequency_A22699 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("髇ꯉ꣋蟍뻏듑믓郕꫗뿙귛ꯝ藟賡蟣鿥뫧诩苫觭闯臱믳蛵鷷铹뫻賽旿猁焃挅昇椉甋儍儏‑☓―℗⌙", a_), global::CommonResources.AcgResources.ID_OPENFREQUENCY);
						this.radInfoFrequencyRangesOpenFrequency_A22699.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
						this.radInfoFrequencyRangesOpenFrequency_A22699.DataTransferOrder = 6;
						num = (short)649265163;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 31:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("髇ꯉ꣋蟍뻏듑믓郕꫗뿙귛ꯝ藟賡蟣鿥뫧诩苫觭闯臱쳳웵죷럹듻蓽嗿焁愃戅愇搉伋愍琏眑搓稕洗紙䌛弝ᐟအᄣጥᨧ", a_)))
					{
						num = (short)945029157;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_68E;
				case 32:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("髇ꯉ꣋蟍뻏듑믓郕꫗뿙귛ꯝ藟賡蟣鿥뫧诩苫觭闯臱뇳軵賷鿹鋻髽旿昁儃丅万堉㴋䴍焏我甓琕琗缙䌛弝ᐟጡဣሥᬧ", a_)))
					{
						num = (short)1127219227;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_165;
				case 33:
					this.radInfoFrequencyRangesExtendedUHFR1480MHzCapable_A43578 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("髇ꯉ꣋蟍뻏듑믓郕꫗뿙귛ꯝ藟賡蟣鿥뫧诩苫觭闯臱뇳軵賷鿹鋻髽旿昁儃丅万堉㴋㨍⠏∑夓帕戗夙紛渝䄟䀡䠣䌥眧欩ᠫᴭԯԱళ", a_), global::CommonResources.AcgResources.ID_EXTENDEDUHFR1480MHZCAPABLE);
					this.radInfoFrequencyRangesExtendedUHFR1480MHzCapable_A43578.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radInfoFrequencyRangesExtendedUHFR1480MHzCapable_A43578.DataTransferOrder = -1;
					num = (short)958136354;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 34:
					goto IL_4B6;
				case 35:
				{
					num = (short)1020002304;
					short num4 = num;
					this.radInfoFrequencyRangesFWCapableUHFR1480MHz_A43576 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("髇ꯉ꣋蟍뻏듑믓郕꫗뿙귛ꯝ藟賡蟣鿥뫧诩苫觭闯臱닳ꇵ믷鯹賻鿽拿渁愃包䀇䰉帋㼍␏⨑␓嬕倗怙䌛弝ᐟᄡᄣᄥḧ", a_), global::CommonResources.AcgResources.ID_FWCOMPAREWITHUHF1480MHZEXTENSION);
					this.radInfoFrequencyRangesFWCapableUHFR1480MHz_A43576.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radInfoFrequencyRangesFWCapableUHFR1480MHz_A43576.DataTransferOrder = -1;
					num = (short)961085453;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 36:
					num = (short)1234239532;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 37:
					this.radInfoFrequencyRanges800MHzUsedinCodeplug_A42552 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("髇ꯉ꣋蟍뻏듑믓郕꫗뿙귛ꯝ藟賡蟣鿥뫧诩苫觭闯臱쳳웵죷럹듻蓽嗿焁愃戅愇搉伋愍琏眑搓稕洗紙䌛弝ᐟအᄣጥᨧ", a_), global::CommonResources.AcgResources.ID_CODEPLUGFREQUENCIES800MHZUSEDINCODEPLUG);
					this.radInfoFrequencyRanges800MHzUsedinCodeplug_A42552.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.radInfoFrequencyRanges800MHzUsedinCodeplug_A42552.DataTransferOrder = 17;
					num = (short)1437925376;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 38:
					goto IL_5EC;
				case 39:
					goto IL_254;
				case 40:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("髇ꯉ꣋蟍뻏듑믓郕꫗뿙귛ꯝ藟賡蟣鿥뫧诩苫觭闯臱ꇳ뻵뻷꣹췻쫽㣿㈁䤃丅爇䈉挋縍搏笑稓匕瘗笙縛爝䔟䘡笣朥ᰧᤩᤫ᤭ԯ", a_)))
					{
						num = (short)997392401;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3F0;
				case 41:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("髇ꯉ꣋蟍뻏듑믓郕꫗뿙귛ꯝ藟賡蟣鿥뫧诩苫觭闯臱ꇳ뻵뻷쯹ꧻ跽旿昁洃栅䬇攉栋欍怏縑愓焕䜗嬙␛⬝ဟᘡ", a_)))
					{
						num = (short)388235284;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_549;
				case 42:
					this.radInfoFrequencyRangesAllowInvalidFrequencies_A12493 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("髇ꯉ꣋蟍뻏듑믓郕꫗뿙귛ꯝ藟賡蟣鿥뫧诩苫觭闯臱뗳髵铷闹读럽滿琁攃樅愇渉䨋簍甏挑愓猕瘗礙甛笝匟紡攣ᜥᨧḩᔫᴭ", a_), global::CommonResources.AcgResources.ID_CODEPLUGFREQUENCIESALLOWINVALIDFREQUENCIES);
					this.radInfoFrequencyRangesAllowInvalidFrequencies_A12493.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.radInfoFrequencyRangesAllowInvalidFrequencies_A12493.DataTransferOrder = 2;
					num = (short)672333849;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 43:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("髇ꯉ꣋蟍뻏듑믓郕꫗뿙귛ꯝ藟賡蟣鿥뫧诩苫觭闯臱췳웵죷럹듻蓽嗿焁愃戅愇搉伋愍琏眑搓稕洗紙䌛弝᠟ᜡᔣဥ", a_)))
					{
						num = (short)4784143;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_729;
				case 44:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("髇ꯉ꣋蟍뻏듑믓郕꫗뿙귛ꯝ藟賡蟣鿥뫧诩苫觭闯臱ꋳ뻵뻷꿹迻鯽擿欁樃䔅朇渉椋縍簏朑猓䤕夗∙⠛☝ᄟ", a_)))
					{
						num = (short)115539969;
						if (num != 0)
						{
						}
						num = (short)1979908143;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_254;
				case 45:
					goto IL_165;
				case 46:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("髇ꯉ꣋蟍뻏듑믓郕꫗뿙귛ꯝ藟賡蟣鿥뫧诩苫觭闯臱뗳髵铷闹读럽滿琁攃樅愇渉䨋簍甏挑愓猕瘗礙甛笝匟紡攣ᜥᨧḩᔫᴭ", a_)))
					{
						num = (short)1213726762;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_6DB;
				case 47:
					this.radInfoFrequencyRangesVHFUsedinCodeplug_A8481 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("髇ꯉ꣋蟍뻏듑믓郕꫗뿙귛ꯝ藟賡蟣鿥뫧诩苫觭闯臱ꋳ뻵뻷꿹迻鯽擿欁樃䔅朇渉椋縍簏朑猓䤕夗∙⠛☝ᄟ", a_), global::CommonResources.AcgResources.ID_CODEPLUGFREQUENCIESVHFUSEDINCODEPLUG);
					this.radInfoFrequencyRangesVHFUsedinCodeplug_A8481.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.radInfoFrequencyRangesVHFUsedinCodeplug_A8481.DataTransferOrder = 10;
					num = (short)2122776615;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 48:
					switch (0)
					{
					case 0:
						goto IL_F1;
					}
					continue;
				}
				IL_F1:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1401880590;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_117:
				num = (short)16056351;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_165:
				num = (short)1008009242;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_207:
				num = (short)1303445544;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_254:
				num = (short)1670643753;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3A0:
				num = (short)898760725;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3F0:
				num = (short)1701642248;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_549:
				num = (short)678625309;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_5EC:
				num = (short)1464205355;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_68E:
				num = (short)152043522;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_6DB:
				num = (short)1627717656;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_729:
				num = (short)2139160622;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_772:
				num = (short)1779236869;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_8F5:
				num = (short)1932722214;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_9B0:
				num = (short)114950176;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_B21:
				num = (short)2040135703;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_4B6:
			IL_B6A:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("軇룉꧋뿍ꗏ럑뫓뗕ꇗ龎軛뿝軟藡臣闥", a_);
			base.Id = 10110;
			base.UIName = global::CommonResources.AcgResources.ID_FREQUENCYRANGES;
			base.DataTransferOrder = 2;
		}

		// Token: 0x060045BE RID: 17854 RVA: 0x0040CEBC File Offset: 0x0040B0BC
		public override void PopulateReferences()
		{
			short num = (short)2107086490;
			short num2 = num;
			num = (short)1418499738;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1723793408;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2032074753;
			if (num != 0)
			{
			}
			num = (short)436666368;
			if (num != 0)
			{
			}
		}

		// Token: 0x060045BF RID: 17855 RVA: 0x0040CF68 File Offset: 0x0040B168
		public override void DropReferences()
		{
			short num = (short)792520233;
			short num2 = num;
			num = (short)1697321;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2051473408;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)560070657;
			if (num != 0)
			{
			}
			num = (short)1470038016;
			if (num != 0)
			{
			}
		}

		// Token: 0x060045C0 RID: 17856 RVA: 0x0040D010 File Offset: 0x0040B210
		public override void SetConstraints()
		{
			short num = (short)800465699;
			short num2 = num;
			num = (short)505946915;
			switch (num2 == num)
			{
			default:
			{
				num = (short)682819584;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)873005056;
			if (num != 0)
			{
			}
			num = (short)922419201;
			if (num != 0)
			{
			}
			this.radInfoFrequencyRangesVHFUsedinCodeplug_A8481.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformationConstraints.ConAreInvalidFrequenciesAllowed);
			this.radInfoFrequencyRangesVHFUsedinCodeplug_A8481.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformationConstraints.ConFrequencyRanageVHFUsedIsEditable);
			this.radInfoFrequencyRangesVHFUsedinCodeplug_A8481.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformationConstraints.ConReadPerformanceValidity);
			this.radInfoFrequencyRangesUHF1UsedinCodeplug_A8504.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformationConstraints.ConAreInvalidFrequenciesAllowed);
			this.radInfoFrequencyRangesUHF1UsedinCodeplug_A8504.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformationConstraints.ConFrequencyRanageUHF1UsedIsEditable);
			this.radInfoFrequencyRangesUHF1UsedinCodeplug_A8504.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformationConstraints.ConReadPerformanceValidity);
			this.radInfoFrequencyRangesUHF2UsedinCodeplug_A8507.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformationConstraints.ConAreInvalidFrequenciesAllowed);
			this.radInfoFrequencyRangesUHF2UsedinCodeplug_A8507.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformationConstraints.ConFrequencyRanageUHF2UsedIsEditable);
			this.radInfoFrequencyRangesUHF2UsedinCodeplug_A8507.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformationConstraints.ConReadPerformanceValidity);
			this.radInfoFrequencyRanges7800MHzUsedinCodeplug_A8512.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformationConstraints.ConAreInvalidFrequenciesAllowed);
			this.radInfoFrequencyRanges7800MHzUsedinCodeplug_A8512.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformationConstraints.ConFrequencyRanage7800MIsEditable);
			this.radInfoFrequencyRanges7800MHzUsedinCodeplug_A8512.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformationConstraints.ConReadPerformanceValidity);
			this.radInfoFrequencyRanges900MHzUsedinCodeplug_A8516.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformationConstraints.ConAreInvalidFrequenciesAllowed);
			this.radInfoFrequencyRanges900MHzUsedinCodeplug_A8516.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformationConstraints.ConFrequencyRanage900MIsEditable);
			this.radInfoFrequencyRanges900MHzUsedinCodeplug_A8516.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformationConstraints.ConReadPerformanceValidity);
			this.radInfoFrequencyRangesAllowInvalidFrequencies_A12493.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformationConstraints.ConReadPerformanceValidity);
			this.radInfoFrequencyRangesExtendedUHFR1Capable_A41443.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.radInfoFrequencyRanges8900MHzUsedinCodeplug_A42502.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformationConstraints.ConAreInvalidFrequenciesAllowed);
			this.radInfoFrequencyRanges8900MHzUsedinCodeplug_A42502.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformationConstraints.ConFrequencyRanage8900MIsEditable);
			this.radInfoFrequencyRanges8900MHzUsedinCodeplug_A42502.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformationConstraints.ConReadPerformanceValidity);
			this.radInfoFrequencyRanges700MHzUsedinCodeplug_A42551.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformationConstraints.ConAreInvalidFrequenciesAllowed);
			this.radInfoFrequencyRanges700MHzUsedinCodeplug_A42551.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformationConstraints.con700MHzUsedInCodeplugValidity);
			this.radInfoFrequencyRanges700MHzUsedinCodeplug_A42551.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformationConstraints.ConFrequencyRanage700MIsEditable);
			this.radInfoFrequencyRanges700MHzUsedinCodeplug_A42551.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformationConstraints.ConReadPerformanceValidity);
			this.radInfoFrequencyRanges800MHzUsedinCodeplug_A42552.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformationConstraints.ConAreInvalidFrequenciesAllowed);
			this.radInfoFrequencyRanges800MHzUsedinCodeplug_A42552.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformationConstraints.con800MHzUsedInCodeplugValidity);
			this.radInfoFrequencyRanges800MHzUsedinCodeplug_A42552.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformationConstraints.ConFrequencyRanage800MIsEditable);
			this.radInfoFrequencyRanges800MHzUsedinCodeplug_A42552.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformationConstraints.ConReadPerformanceValidity);
			this.radInfoFrequencyRangesExtendRange762Capable_A43555.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.radInfoFrequencyRangesUHFR1480MHzHoptinEnabled_A43575.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.radInfoFrequencyRangesFWCapableUHFR1480MHz_A43576.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.radInfoFrequencyRangesExtendedUHFR1480MHzCapable_A43578.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
		}

		// Token: 0x060045C1 RID: 17857 RVA: 0x0040D398 File Offset: 0x0040B598
		public override void SetupDependencies()
		{
			short num = (short)1623457793;
			if (num != 0)
			{
			}
			num = (short)1224015872;
			short num2 = num;
			num = (short)1937496942;
			short num3 = num;
			num = (short)1548016494;
			switch (num3 == num)
			{
			}
			num = (short)967114752;
			if (num != 0)
			{
			}
			this.radInfoFrequencyRangesAllowInvalidFrequencies_A12493.AddDependentObject(this.radInfoFrequencyRangesVHFUsedinCodeplug_A8481);
			this.radInfoFrequencyRangesAllowInvalidFrequencies_A12493.AddDependentObject(this.radInfoFrequencyRangesUHF1UsedinCodeplug_A8504);
			this.radInfoFrequencyRangesAllowInvalidFrequencies_A12493.AddDependentObject(this.radInfoFrequencyRangesUHF2UsedinCodeplug_A8507);
			this.radInfoFrequencyRangesAllowInvalidFrequencies_A12493.AddDependentObject(this.radInfoFrequencyRanges7800MHzUsedinCodeplug_A8512);
			this.radInfoFrequencyRangesAllowInvalidFrequencies_A12493.AddDependentObject(this.radInfoFrequencyRanges900MHzUsedinCodeplug_A8516);
			this.radInfoFrequencyRangesAllowInvalidFrequencies_A12493.AddDependentObject(this.radInfoFrequencyRanges8900MHzUsedinCodeplug_A42502);
			this.radInfoFrequencyRangesAllowInvalidFrequencies_A12493.AddDependentObject(this.radInfoFrequencyRanges700MHzUsedinCodeplug_A42551);
			this.radInfoFrequencyRanges800MHzUsedinCodeplug_A42552.AddDependentObject(this.radInfoFrequencyRanges700MHzUsedinCodeplug_A42551);
			this.radInfoFrequencyRangesAllowInvalidFrequencies_A12493.AddDependentObject(this.radInfoFrequencyRanges800MHzUsedinCodeplug_A42552);
			this.radInfoFrequencyRanges700MHzUsedinCodeplug_A42551.AddDependentObject(this.radInfoFrequencyRanges800MHzUsedinCodeplug_A42552);
		}

		// Token: 0x170023C5 RID: 9157
		// (get) Token: 0x060045C2 RID: 17858 RVA: 0x0040D4F4 File Offset: 0x0040B6F4
		public bool HasDiffs
		{
			get
			{
				short num = (short)758079009;
				short num2 = num;
				num = (short)182869537;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1907163136;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1695088641;
				if (num != 0)
				{
				}
				num = (short)274268160;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x170023C6 RID: 9158
		// (get) Token: 0x060045C3 RID: 17859 RVA: 0x0040D5A4 File Offset: 0x0040B7A4
		// (set) Token: 0x060045C4 RID: 17860 RVA: 0x0040D660 File Offset: 0x0040B860
		public bool RadInfoFrequencyRangesVHFUsedinCodeplug_A8481Value
		{
			get
			{
				short num = (short)2109948530;
				short num2 = num;
				num = (short)48185970;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1063583744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2034302976;
				if (num != 0)
				{
				}
				num = (short)620101633;
				if (num != 0)
				{
				}
				this.l();
				return this.radInfoFrequencyRangesVHFUsedinCodeplug_A8481.Value;
			}
			set
			{
				short num = (short)178429607;
				short num2 = num;
				num = (short)1441701543;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1078394880;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)90046465;
				if (num != 0)
				{
				}
				num = (short)132251648;
				if (num != 0)
				{
				}
				this.radInfoFrequencyRangesVHFUsedinCodeplug_A8481.Value = value;
			}
		}

		// Token: 0x170023C7 RID: 9159
		// (get) Token: 0x060045C5 RID: 17861 RVA: 0x0040D714 File Offset: 0x0040B914
		public global::AcpBusinessLayer.AcpField<bool> RadInfoFrequencyRangesVHFUsedinCodeplug_A8481
		{
			get
			{
				short num = (short)290759605;
				short num2 = num;
				num = (short)233612213;
				switch (num2 == num)
				{
				default:
				{
					num = (short)504758272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)369229825;
				if (num != 0)
				{
				}
				num = (short)983498752;
				if (num != 0)
				{
				}
				return this.radInfoFrequencyRangesVHFUsedinCodeplug_A8481;
			}
		}

		// Token: 0x170023C8 RID: 9160
		// (get) Token: 0x060045C6 RID: 17862 RVA: 0x0040D7C0 File Offset: 0x0040B9C0
		// (set) Token: 0x060045C7 RID: 17863 RVA: 0x0040D874 File Offset: 0x0040BA74
		public bool RadInfoFrequencyRangesVHFUsedinCodeplug_A8481_UIValue
		{
			get
			{
				short num = (short)1263254000;
				short num2 = num;
				num = (short)791788016;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1256194048;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)534904833;
				if (num != 0)
				{
				}
				num = (short)638386176;
				if (num != 0)
				{
				}
				return this.radInfoFrequencyRangesVHFUsedinCodeplug_A8481.Value;
			}
			set
			{
				short num = (short)1053419853;
				short num2 = num;
				num = (short)1999169869;
				switch (num2 == num)
				{
				default:
				{
					num = (short)119013376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1992032257;
				if (num != 0)
				{
				}
				num = (short)290258944;
				if (num != 0)
				{
				}
				this.radInfoFrequencyRangesVHFUsedinCodeplug_A8481.Value = value;
			}
		}

		// Token: 0x170023C9 RID: 9161
		// (get) Token: 0x060045C8 RID: 17864 RVA: 0x0040D92C File Offset: 0x0040BB2C
		// (set) Token: 0x060045C9 RID: 17865 RVA: 0x0040D9E0 File Offset: 0x0040BBE0
		public bool RadInfoFrequencyRangesVHFUsedinCodeplug_A8481_Applicable
		{
			get
			{
				short num = (short)934346753;
				if (num != 0)
				{
				}
				num = (short)1863122944;
				short num2 = num;
				num = (short)1189169189;
				short num3 = num;
				num = (short)1218529317;
				switch (num3 == num)
				{
				}
				num = (short)1118961664;
				if (num != 0)
				{
				}
				return this.radInfoFrequencyRangesVHFUsedinCodeplug_A8481.Applicable;
			}
			set
			{
				short num = (short)1317928961;
				if (num != 0)
				{
				}
				num = (short)1074659328;
				short num2 = num;
				num = (short)117286984;
				short num3 = num;
				num = (short)678799432;
				switch (num3 == num)
				{
				}
				num = (short)426311680;
				if (num != 0)
				{
				}
				this.radInfoFrequencyRangesVHFUsedinCodeplug_A8481.Applicable = value;
			}
		}

		// Token: 0x170023CA RID: 9162
		// (get) Token: 0x060045CA RID: 17866 RVA: 0x0040DA98 File Offset: 0x0040BC98
		// (set) Token: 0x060045CB RID: 17867 RVA: 0x0040DB4C File Offset: 0x0040BD4C
		public bool RadInfoFrequencyRangesVHFUsedinCodeplug_A8481_Valid
		{
			get
			{
				short num = (short)1055410836;
				short num2 = num;
				num = (short)132205204;
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
				num = (short)178388993;
				if (num != 0)
				{
				}
				num = (short)629276672;
				if (num != 0)
				{
				}
				return this.radInfoFrequencyRangesVHFUsedinCodeplug_A8481.Valid;
			}
			set
			{
				short num = (short)831586305;
				if (num != 0)
				{
				}
				num = (short)645005312;
				short num2 = num;
				num = (short)781559251;
				short num3 = num;
				num = (short)964535763;
				switch (num3 == num)
				{
				}
				num = (short)644022272;
				if (num != 0)
				{
				}
				this.radInfoFrequencyRangesVHFUsedinCodeplug_A8481.Valid = value;
			}
		}

		// Token: 0x170023CB RID: 9163
		// (get) Token: 0x060045CC RID: 17868 RVA: 0x0040DC04 File Offset: 0x0040BE04
		// (set) Token: 0x060045CD RID: 17869 RVA: 0x0040DCB8 File Offset: 0x0040BEB8
		public bool RadInfoFrequencyRangesVHFUsedinCodeplug_A8481_Visible
		{
			get
			{
				short num = (short)558652048;
				short num2 = num;
				num = (short)473520784;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1891434496;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)840105984;
				if (num != 0)
				{
				}
				num = (short)1305018369;
				if (num != 0)
				{
				}
				return this.radInfoFrequencyRangesVHFUsedinCodeplug_A8481.Visible;
			}
			set
			{
				short num = (short)31304608;
				short num2 = num;
				num = (short)1159113632;
				switch (num2 == num)
				{
				default:
				{
					num = (short)7602176;
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
				num = (short)568721409;
				if (num != 0)
				{
				}
				this.radInfoFrequencyRangesVHFUsedinCodeplug_A8481.Visible = value;
			}
		}

		// Token: 0x170023CC RID: 9164
		// (get) Token: 0x060045CE RID: 17870 RVA: 0x0040DD6C File Offset: 0x0040BF6C
		// (set) Token: 0x060045CF RID: 17871 RVA: 0x0040DE24 File Offset: 0x0040C024
		public bool RadInfoFrequencyRangesVHFUsedinCodeplug_A8481_Editable
		{
			get
			{
				short num = (short)1758195825;
				short num2 = num;
				num = (short)1180299377;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1507000320;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)621674497;
				if (num != 0)
				{
				}
				num = (short)2086535168;
				if (num != 0)
				{
				}
				return this.radInfoFrequencyRangesVHFUsedinCodeplug_A8481.Editable;
			}
			set
			{
				short num = (short)1171141761;
				short num2 = num;
				num = (short)1817588865;
				switch (num2 == num)
				{
				default:
				{
					num = (short)179109888;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)772931584;
				if (num != 0)
				{
				}
				num = (short)1656422401;
				if (num != 0)
				{
				}
				this.radInfoFrequencyRangesVHFUsedinCodeplug_A8481.Editable = value;
			}
		}

		// Token: 0x170023CD RID: 9165
		// (get) Token: 0x060045D0 RID: 17872 RVA: 0x0040DED8 File Offset: 0x0040C0D8
		internal string RadInfoFrequencyRangesVHFUsedinCodeplug_A8481_UILabel
		{
			get
			{
				short num = (short)73990144;
				short num2 = num;
				num = (short)1224012714;
				short num3 = num;
				num = (short)209449898;
				switch (num3 == num)
				{
				}
				num = (short)310902785;
				if (num != 0)
				{
				}
				num = (short)554434560;
				if (num != 0)
				{
				}
				return this.radInfoFrequencyRangesVHFUsedinCodeplug_A8481.UIName;
			}
		}

		// Token: 0x170023CE RID: 9166
		// (get) Token: 0x060045D1 RID: 17873 RVA: 0x0040DF8C File Offset: 0x0040C18C
		// (set) Token: 0x060045D2 RID: 17874 RVA: 0x0040E040 File Offset: 0x0040C240
		internal bool RadInfoFrequencyRangesVHFUsedinCodeplug_A8481_HiddenStatic
		{
			get
			{
				short num = (short)170131456;
				short num2 = num;
				num = (short)1867341824;
				short num3 = num;
				num = (short)132603904;
				switch (num3 == num)
				{
				}
				num = (short)250609665;
				if (num != 0)
				{
				}
				num = (short)1132855296;
				if (num != 0)
				{
				}
				return this.radInfoFrequencyRangesVHFUsedinCodeplug_A8481.HiddenStatic;
			}
			set
			{
				short num = (short)365297664;
				short num2 = num;
				num = (short)38469633;
				if (num != 0)
				{
				}
				num = (short)1307010896;
				short num3 = num;
				num = (short)1539139408;
				switch (num3 == num)
				{
				}
				num = (short)1773404160;
				if (num != 0)
				{
				}
				this.radInfoFrequencyRangesVHFUsedinCodeplug_A8481.HiddenStatic = value;
			}
		}

		// Token: 0x170023CF RID: 9167
		// (get) Token: 0x060045D3 RID: 17875 RVA: 0x0040E0F4 File Offset: 0x0040C2F4
		// (set) Token: 0x060045D4 RID: 17876 RVA: 0x0040E1A8 File Offset: 0x0040C3A8
		internal bool RadInfoFrequencyRangesVHFUsedinCodeplug_A8481_HiddenDynamic
		{
			get
			{
				short num = (short)768671744;
				short num2 = num;
				num = (short)1006210136;
				short num3 = num;
				num = (short)274828376;
				switch (num3 == num)
				{
				}
				num = (short)2110980097;
				if (num != 0)
				{
				}
				num = (short)2078867456;
				if (num != 0)
				{
				}
				return this.radInfoFrequencyRangesVHFUsedinCodeplug_A8481.HiddenDynamic;
			}
			set
			{
				short num = (short)1786642432;
				short num2 = num;
				num = (short)809465795;
				short num3 = num;
				num = (short)1755805635;
				switch (num3 == num)
				{
				}
				num = (short)1742340097;
				if (num != 0)
				{
				}
				num = (short)1308033024;
				if (num != 0)
				{
				}
				this.radInfoFrequencyRangesVHFUsedinCodeplug_A8481.HiddenDynamic = value;
			}
		}

		// Token: 0x170023D0 RID: 9168
		// (get) Token: 0x060045D5 RID: 17877 RVA: 0x0040E25C File Offset: 0x0040C45C
		public bool RadInfoFrequencyRangesVHFUsedinCodeplug_A8481_HasDiffs
		{
			get
			{
				short num = (short)1644167168;
				short num2 = num;
				num = (short)1858622846;
				short num3 = num;
				num = (short)1925731710;
				switch (num3 == num)
				{
				}
				num = (short)1532755969;
				if (num != 0)
				{
				}
				num = (short)150601728;
				if (num != 0)
				{
				}
				return this.radInfoFrequencyRangesVHFUsedinCodeplug_A8481._HasDiffs;
			}
		}

		// Token: 0x170023D1 RID: 9169
		// (get) Token: 0x060045D6 RID: 17878 RVA: 0x0040E314 File Offset: 0x0040C514
		// (set) Token: 0x060045D7 RID: 17879 RVA: 0x0040E3D4 File Offset: 0x0040C5D4
		public bool RadInfoFrequencyRangesUHF1UsedinCodeplug_A8504Value
		{
			get
			{
				short num = (short)1339555840;
				short num2 = num;
				num = (short)1407316211;
				short num3 = num;
				num = (short)797372659;
				switch (num3 == num)
				{
				}
				num = (short)486211585;
				if (num != 0)
				{
				}
				num = (short)1377959936;
				if (num != 0)
				{
				}
				this.k();
				return this.radInfoFrequencyRangesUHF1UsedinCodeplug_A8504.Value;
			}
			set
			{
				short num = (short)737148928;
				short num2 = num;
				num = (short)332267602;
				short num3 = num;
				num = (short)1196490834;
				switch (num3 == num)
				{
				}
				num = (short)1182007296;
				if (num != 0)
				{
				}
				num = (short)1834352641;
				if (num != 0)
				{
				}
				this.radInfoFrequencyRangesUHF1UsedinCodeplug_A8504.Value = value;
			}
		}

		// Token: 0x170023D2 RID: 9170
		// (get) Token: 0x060045D8 RID: 17880 RVA: 0x0040E488 File Offset: 0x0040C688
		public global::AcpBusinessLayer.AcpField<bool> RadInfoFrequencyRangesUHF1UsedinCodeplug_A8504
		{
			get
			{
				short num = (short)288620544;
				short num2 = num;
				num = (short)165871617;
				if (num != 0)
				{
				}
				num = (short)1933479486;
				short num3 = num;
				num = (short)1918078526;
				switch (num3 == num)
				{
				}
				num = (short)388694016;
				if (num != 0)
				{
				}
				return this.radInfoFrequencyRangesUHF1UsedinCodeplug_A8504;
			}
		}

		// Token: 0x170023D3 RID: 9171
		// (get) Token: 0x060045D9 RID: 17881 RVA: 0x0040E538 File Offset: 0x0040C738
		// (set) Token: 0x060045DA RID: 17882 RVA: 0x0040E5EC File Offset: 0x0040C7EC
		public bool RadInfoFrequencyRangesUHF1UsedinCodeplug_A8504_UIValue
		{
			get
			{
				short num = (short)1151533056;
				short num2 = num;
				num = (short)1023038726;
				short num3 = num;
				num = (short)1830507782;
				switch (num3 == num)
				{
				}
				num = (short)1303379969;
				if (num != 0)
				{
				}
				num = (short)606339072;
				if (num != 0)
				{
				}
				return this.radInfoFrequencyRangesUHF1UsedinCodeplug_A8504.Value;
			}
			set
			{
				short num = (short)27000832;
				short num2 = num;
				num = (short)1432374160;
				short num3 = num;
				num = (short)800344976;
				switch (num3 == num)
				{
				}
				num = (short)1273561089;
				if (num != 0)
				{
				}
				num = (short)866648064;
				if (num != 0)
				{
				}
				this.radInfoFrequencyRangesUHF1UsedinCodeplug_A8504.Value = value;
			}
		}

		// Token: 0x170023D4 RID: 9172
		// (get) Token: 0x060045DB RID: 17883 RVA: 0x0040E6A4 File Offset: 0x0040C8A4
		// (set) Token: 0x060045DC RID: 17884 RVA: 0x0040E75C File Offset: 0x0040C95C
		public bool RadInfoFrequencyRangesUHF1UsedinCodeplug_A8504_Applicable
		{
			get
			{
				short num = (short)1186660352;
				short num2 = num;
				num = (short)2113379807;
				short num3 = num;
				num = (short)865967583;
				switch (num3 == num)
				{
				}
				num = (short)443613185;
				if (num != 0)
				{
				}
				num = (short)1159856128;
				if (num != 0)
				{
				}
				return this.radInfoFrequencyRangesUHF1UsedinCodeplug_A8504.Applicable;
			}
			set
			{
				short num = (short)2132541440;
				short num2 = num;
				num = (short)27855490;
				short num3 = num;
				num = (short)1649216130;
				switch (num3 == num)
				{
				}
				num = (short)1537015809;
				if (num != 0)
				{
				}
				num = (short)1719926784;
				if (num != 0)
				{
				}
				this.radInfoFrequencyRangesUHF1UsedinCodeplug_A8504.Applicable = value;
			}
		}

		// Token: 0x170023D5 RID: 9173
		// (get) Token: 0x060045DD RID: 17885 RVA: 0x0040E814 File Offset: 0x0040CA14
		// (set) Token: 0x060045DE RID: 17886 RVA: 0x0040E8C8 File Offset: 0x0040CAC8
		public bool RadInfoFrequencyRangesUHF1UsedinCodeplug_A8504_Valid
		{
			get
			{
				short num = (short)419627008;
				short num2 = num;
				num = (short)1306114220;
				short num3 = num;
				num = (short)805746860;
				switch (num3 == num)
				{
				}
				num = (short)869269505;
				if (num != 0)
				{
				}
				num = (short)190709760;
				if (num != 0)
				{
				}
				return this.radInfoFrequencyRangesUHF1UsedinCodeplug_A8504.Valid;
			}
			set
			{
				short num = (short)564002816;
				short num2 = num;
				num = (short)1166741624;
				short num3 = num;
				num = (short)847777912;
				switch (num3 == num)
				{
				}
				num = (short)676397056;
				if (num != 0)
				{
				}
				num = (short)1298399233;
				if (num != 0)
				{
				}
				this.radInfoFrequencyRangesUHF1UsedinCodeplug_A8504.Valid = value;
			}
		}

		// Token: 0x170023D6 RID: 9174
		// (get) Token: 0x060045DF RID: 17887 RVA: 0x0040E980 File Offset: 0x0040CB80
		// (set) Token: 0x060045E0 RID: 17888 RVA: 0x0040EA30 File Offset: 0x0040CC30
		public bool RadInfoFrequencyRangesUHF1UsedinCodeplug_A8504_Visible
		{
			get
			{
				short num = (short)1181876224;
				short num2 = num;
				num = (short)160793060;
				short num3 = num;
				num = (short)794853860;
				switch (num3 == num)
				{
				}
				num = (short)1624637440;
				if (num != 0)
				{
				}
				num = (short)1504772097;
				if (num != 0)
				{
				}
				return this.radInfoFrequencyRangesUHF1UsedinCodeplug_A8504.Visible;
			}
			set
			{
				short num = (short)1697447936;
				short num2 = num;
				num = (short)459419471;
				short num3 = num;
				num = (short)2075078479;
				switch (num3 == num)
				{
				}
				num = (short)1392181248;
				if (num != 0)
				{
				}
				num = (short)1696989185;
				if (num != 0)
				{
				}
				this.radInfoFrequencyRangesUHF1UsedinCodeplug_A8504.Visible = value;
			}
		}

		// Token: 0x170023D7 RID: 9175
		// (get) Token: 0x060045E1 RID: 17889 RVA: 0x0040EAE4 File Offset: 0x0040CCE4
		// (set) Token: 0x060045E2 RID: 17890 RVA: 0x0040EB98 File Offset: 0x0040CD98
		public bool RadInfoFrequencyRangesUHF1UsedinCodeplug_A8504_Editable
		{
			get
			{
				short num = (short)1454440448;
				short num2 = num;
				num = (short)437703401;
				short num3 = num;
				num = (short)1754583785;
				switch (num3 == num)
				{
				}
				num = (short)739639296;
				if (num != 0)
				{
				}
				num = (short)1185939457;
				if (num != 0)
				{
				}
				return this.radInfoFrequencyRangesUHF1UsedinCodeplug_A8504.Editable;
			}
			set
			{
				short num = (short)1067384832;
				short num2 = num;
				num = (short)1659273934;
				short num3 = num;
				num = (short)2119795406;
				switch (num3 == num)
				{
				}
				num = (short)1692270592;
				if (num != 0)
				{
				}
				num = (short)1448083457;
				if (num != 0)
				{
				}
				this.radInfoFrequencyRangesUHF1UsedinCodeplug_A8504.Editable = value;
			}
		}

		// Token: 0x170023D8 RID: 9176
		// (get) Token: 0x060045E3 RID: 17891 RVA: 0x0040EC4C File Offset: 0x0040CE4C
		internal string RadInfoFrequencyRangesUHF1UsedinCodeplug_A8504_UILabel
		{
			get
			{
				short num = (short)574226432;
				short num2 = num;
				num = (short)1954896078;
				short num3 = num;
				num = (short)487282894;
				switch (num3 == num)
				{
				}
				num = (short)1640169473;
				if (num != 0)
				{
				}
				num = (short)1296433152;
				if (num != 0)
				{
				}
				return this.radInfoFrequencyRangesUHF1UsedinCodeplug_A8504.UIName;
			}
		}

		// Token: 0x170023D9 RID: 9177
		// (get) Token: 0x060045E4 RID: 17892 RVA: 0x0040ED00 File Offset: 0x0040CF00
		// (set) Token: 0x060045E5 RID: 17893 RVA: 0x0040EDB4 File Offset: 0x0040CFB4
		internal bool RadInfoFrequencyRangesUHF1UsedinCodeplug_A8504_HiddenStatic
		{
			get
			{
				short num = (short)1143144448;
				short num2 = num;
				num = (short)1156601280;
				short num3 = num;
				num = (short)1536513472;
				switch (num3 == num)
				{
				}
				num = (short)1908801536;
				if (num != 0)
				{
				}
				num = (short)350093313;
				if (num != 0)
				{
				}
				return this.radInfoFrequencyRangesUHF1UsedinCodeplug_A8504.HiddenStatic;
			}
			set
			{
				short num = (short)1109524480;
				short num2 = num;
				num = (short)1416832294;
				short num3 = num;
				num = (short)1534797094;
				switch (num3 == num)
				{
				}
				num = (short)1659437057;
				if (num != 0)
				{
				}
				num = (short)1596325888;
				if (num != 0)
				{
				}
				this.radInfoFrequencyRangesUHF1UsedinCodeplug_A8504.HiddenStatic = value;
			}
		}

		// Token: 0x170023DA RID: 9178
		// (get) Token: 0x060045E6 RID: 17894 RVA: 0x0040EE68 File Offset: 0x0040D068
		// (set) Token: 0x060045E7 RID: 17895 RVA: 0x0040EF20 File Offset: 0x0040D120
		internal bool RadInfoFrequencyRangesUHF1UsedinCodeplug_A8504_HiddenDynamic
		{
			get
			{
				short num = (short)1474494464;
				short num2 = num;
				num = (short)860120705;
				short num3 = num;
				num = (short)1703437953;
				switch (num3 == num)
				{
				}
				num = (short)1650458625;
				if (num != 0)
				{
				}
				num = (short)684589056;
				if (num != 0)
				{
				}
				return this.radInfoFrequencyRangesUHF1UsedinCodeplug_A8504.HiddenDynamic;
			}
			set
			{
				short num = (short)1264910336;
				short num2 = num;
				num = (short)1723616974;
				short num3 = num;
				num = (short)1985892046;
				switch (num3 == num)
				{
				}
				num = (short)1750007809;
				if (num != 0)
				{
				}
				num = (short)305790976;
				if (num != 0)
				{
				}
				this.radInfoFrequencyRangesUHF1UsedinCodeplug_A8504.HiddenDynamic = value;
			}
		}

		// Token: 0x170023DB RID: 9179
		// (get) Token: 0x060045E8 RID: 17896 RVA: 0x0040EFD8 File Offset: 0x0040D1D8
		public bool RadInfoFrequencyRangesUHF1UsedinCodeplug_A8504_HasDiffs
		{
			get
			{
				short num = (short)1988952064;
				short num2 = num;
				num = (short)909653561;
				short num3 = num;
				num = (short)1919170105;
				switch (num3 == num)
				{
				}
				num = (short)1579548673;
				if (num != 0)
				{
				}
				num = (short)326762496;
				if (num != 0)
				{
				}
				return this.radInfoFrequencyRangesUHF1UsedinCodeplug_A8504._HasDiffs;
			}
		}

		// Token: 0x170023DC RID: 9180
		// (get) Token: 0x060045E9 RID: 17897 RVA: 0x0040F08C File Offset: 0x0040D28C
		// (set) Token: 0x060045EA RID: 17898 RVA: 0x0040F144 File Offset: 0x0040D344
		public bool RadInfoFrequencyRangesUHF2UsedinCodeplug_A8507Value
		{
			get
			{
				short num = (short)1392705536;
				short num2 = num;
				num = (short)1916758458;
				short num3 = num;
				num = (short)562063802;
				switch (num3 == num)
				{
				}
				num = (short)1933705216;
				if (num != 0)
				{
				}
				num = (short)173932545;
				if (num != 0)
				{
				}
				this.j();
				return this.radInfoFrequencyRangesUHF2UsedinCodeplug_A8507.Value;
			}
			set
			{
				short num = (short)2147287040;
				short num2 = num;
				num = (short)1250349952;
				short num3 = num;
				num = (short)1451479936;
				switch (num3 == num)
				{
				}
				num = (short)566231041;
				if (num != 0)
				{
				}
				num = (short)474218496;
				if (num != 0)
				{
				}
				this.radInfoFrequencyRangesUHF2UsedinCodeplug_A8507.Value = value;
			}
		}

		// Token: 0x170023DD RID: 9181
		// (get) Token: 0x060045EB RID: 17899 RVA: 0x0040F1FC File Offset: 0x0040D3FC
		public global::AcpBusinessLayer.AcpField<bool> RadInfoFrequencyRangesUHF2UsedinCodeplug_A8507
		{
			get
			{
				short num = (short)2097610752;
				short num2 = num;
				num = (short)2075830535;
				short num3 = num;
				num = (short)139766023;
				switch (num3 == num)
				{
				}
				num = (short)154730497;
				if (num != 0)
				{
				}
				num = (short)1448673280;
				if (num != 0)
				{
				}
				return this.radInfoFrequencyRangesUHF2UsedinCodeplug_A8507;
			}
		}

		// Token: 0x170023DE RID: 9182
		// (get) Token: 0x060045EC RID: 17900 RVA: 0x0040F2A8 File Offset: 0x0040D4A8
		// (set) Token: 0x060045ED RID: 17901 RVA: 0x0040F360 File Offset: 0x0040D560
		public bool RadInfoFrequencyRangesUHF2UsedinCodeplug_A8507_UIValue
		{
			get
			{
				short num = (short)478150656;
				short num2 = num;
				num = (short)778840215;
				short num3 = num;
				num = (short)1889872023;
				switch (num3 == num)
				{
				}
				num = (short)944373761;
				if (num != 0)
				{
				}
				num = (short)2031550464;
				if (num != 0)
				{
				}
				return this.radInfoFrequencyRangesUHF2UsedinCodeplug_A8507.Value;
			}
			set
			{
				short num = (short)1905590272;
				short num2 = num;
				num = (short)1067263891;
				short num3 = num;
				num = (short)1667245971;
				switch (num3 == num)
				{
				}
				num = (short)775225345;
				if (num != 0)
				{
				}
				num = (short)992477184;
				if (num != 0)
				{
				}
				this.radInfoFrequencyRangesUHF2UsedinCodeplug_A8507.Value = value;
			}
		}

		// Token: 0x170023DF RID: 9183
		// (get) Token: 0x060045EE RID: 17902 RVA: 0x0040F418 File Offset: 0x0040D618
		// (set) Token: 0x060045EF RID: 17903 RVA: 0x0040F4CC File Offset: 0x0040D6CC
		public bool RadInfoFrequencyRangesUHF2UsedinCodeplug_A8507_Applicable
		{
			get
			{
				short num = (short)883949568;
				short num2 = num;
				num = (short)864114568;
				short num3 = num;
				num = (short)362239880;
				switch (num3 == num)
				{
				}
				num = (short)1920663553;
				if (num != 0)
				{
				}
				num = (short)1276051456;
				if (num != 0)
				{
				}
				return this.radInfoFrequencyRangesUHF2UsedinCodeplug_A8507.Applicable;
			}
			set
			{
				short num = (short)900988928;
				short num2 = num;
				num = (short)1321671594;
				short num3 = num;
				num = (short)1300372394;
				switch (num3 == num)
				{
				}
				num = (short)628686848;
				if (num != 0)
				{
				}
				num = (short)1748041729;
				if (num != 0)
				{
				}
				this.radInfoFrequencyRangesUHF2UsedinCodeplug_A8507.Applicable = value;
			}
		}

		// Token: 0x170023E0 RID: 9184
		// (get) Token: 0x060045F0 RID: 17904 RVA: 0x0040F584 File Offset: 0x0040D784
		// (set) Token: 0x060045F1 RID: 17905 RVA: 0x0040F638 File Offset: 0x0040D838
		public bool RadInfoFrequencyRangesUHF2UsedinCodeplug_A8507_Valid
		{
			get
			{
				short num = (short)1453981696;
				short num2 = num;
				num = (short)1327562753;
				if (num != 0)
				{
				}
				num = (short)671504757;
				short num3 = num;
				num = (short)195844469;
				switch (num3 == num)
				{
				}
				num = (short)382009344;
				if (num != 0)
				{
				}
				return this.radInfoFrequencyRangesUHF2UsedinCodeplug_A8507.Valid;
			}
			set
			{
				short num = (short)1475149824;
				short num2 = num;
				num = (short)2067862594;
				short num3 = num;
				num = (short)192025666;
				switch (num3 == num)
				{
				}
				num = (short)2027618304;
				if (num != 0)
				{
				}
				num = (short)269746177;
				if (num != 0)
				{
				}
				this.radInfoFrequencyRangesUHF2UsedinCodeplug_A8507.Valid = value;
			}
		}

		// Token: 0x170023E1 RID: 9185
		// (get) Token: 0x060045F2 RID: 17906 RVA: 0x0040F6F0 File Offset: 0x0040D8F0
		// (set) Token: 0x060045F3 RID: 17907 RVA: 0x0040F7A4 File Offset: 0x0040D9A4
		public bool RadInfoFrequencyRangesUHF2UsedinCodeplug_A8507_Visible
		{
			get
			{
				short num = (short)1803485184;
				short num2 = num;
				num = (short)1182859265;
				if (num != 0)
				{
				}
				num = (short)849598426;
				short num3 = num;
				num = (short)1435686874;
				switch (num3 == num)
				{
				}
				num = (short)1366228992;
				if (num != 0)
				{
				}
				return this.radInfoFrequencyRangesUHF2UsedinCodeplug_A8507.Visible;
			}
			set
			{
				short num = (short)1775566848;
				short num2 = num;
				num = (short)1087854093;
				short num3 = num;
				num = (short)951997965;
				switch (num3 == num)
				{
				}
				num = (short)198770689;
				if (num != 0)
				{
				}
				num = (short)1840381952;
				if (num != 0)
				{
				}
				this.radInfoFrequencyRangesUHF2UsedinCodeplug_A8507.Visible = value;
			}
		}

		// Token: 0x170023E2 RID: 9186
		// (get) Token: 0x060045F4 RID: 17908 RVA: 0x0040F85C File Offset: 0x0040DA5C
		// (set) Token: 0x060045F5 RID: 17909 RVA: 0x0040F910 File Offset: 0x0040DB10
		public bool RadInfoFrequencyRangesUHF2UsedinCodeplug_A8507_Editable
		{
			get
			{
				short num = (short)1052573696;
				short num2 = num;
				num = (short)1852916821;
				short num3 = num;
				num = (short)796017749;
				switch (num3 == num)
				{
				}
				num = (short)1239810048;
				if (num != 0)
				{
				}
				num = (short)874446849;
				if (num != 0)
				{
				}
				return this.radInfoFrequencyRangesUHF2UsedinCodeplug_A8507.Editable;
			}
			set
			{
				short num = (short)1459027968;
				short num2 = num;
				num = (short)1895762497;
				short num3 = num;
				num = (short)73992769;
				switch (num3 == num)
				{
				}
				num = (short)2069168129;
				if (num != 0)
				{
				}
				num = (short)123666432;
				if (num != 0)
				{
				}
				this.radInfoFrequencyRangesUHF2UsedinCodeplug_A8507.Editable = value;
			}
		}

		// Token: 0x170023E3 RID: 9187
		// (get) Token: 0x060045F6 RID: 17910 RVA: 0x0040F9C8 File Offset: 0x0040DBC8
		internal string RadInfoFrequencyRangesUHF2UsedinCodeplug_A8507_UILabel
		{
			get
			{
				short num = (short)1450639360;
				short num2 = num;
				num = (short)661876325;
				short num3 = num;
				num = (short)1612607077;
				switch (num3 == num)
				{
				}
				num = (short)162463745;
				if (num != 0)
				{
				}
				num = (short)139001856;
				if (num != 0)
				{
				}
				return this.radInfoFrequencyRangesUHF2UsedinCodeplug_A8507.UIName;
			}
		}

		// Token: 0x170023E4 RID: 9188
		// (get) Token: 0x060045F7 RID: 17911 RVA: 0x0040FA7C File Offset: 0x0040DC7C
		// (set) Token: 0x060045F8 RID: 17912 RVA: 0x0040FB30 File Offset: 0x0040DD30
		internal bool RadInfoFrequencyRangesUHF2UsedinCodeplug_A8507_HiddenStatic
		{
			get
			{
				short num = (short)1570177024;
				short num2 = num;
				num = (short)1001770405;
				short num3 = num;
				num = (short)1455738277;
				switch (num3 == num)
				{
				}
				num = (short)1222311936;
				if (num != 0)
				{
				}
				num = (short)1022296065;
				if (num != 0)
				{
				}
				return this.radInfoFrequencyRangesUHF2UsedinCodeplug_A8507.HiddenStatic;
			}
			set
			{
				short num = (short)742522880;
				short num2 = num;
				num = (short)1339353723;
				short num3 = num;
				num = (short)1082321531;
				switch (num3 == num)
				{
				}
				num = (short)1716715521;
				if (num != 0)
				{
				}
				num = (short)239009792;
				if (num != 0)
				{
				}
				this.radInfoFrequencyRangesUHF2UsedinCodeplug_A8507.HiddenStatic = value;
			}
		}

		// Token: 0x170023E5 RID: 9189
		// (get) Token: 0x060045F9 RID: 17913 RVA: 0x0040FBE8 File Offset: 0x0040DDE8
		// (set) Token: 0x060045FA RID: 17914 RVA: 0x0040FC9C File Offset: 0x0040DE9C
		internal bool RadInfoFrequencyRangesUHF2UsedinCodeplug_A8507_HiddenDynamic
		{
			get
			{
				short num = (short)551747584;
				short num2 = num;
				num = (short)634543567;
				short num3 = num;
				num = (short)1577541071;
				switch (num3 == num)
				{
				}
				num = (short)1259798528;
				if (num != 0)
				{
				}
				num = (short)1293418497;
				if (num != 0)
				{
				}
				return this.radInfoFrequencyRangesUHF2UsedinCodeplug_A8507.HiddenDynamic;
			}
			set
			{
				short num = (short)812122112;
				short num2 = num;
				num = (short)647476276;
				short num3 = num;
				num = (short)2004005940;
				switch (num3 == num)
				{
				}
				num = (short)1958084608;
				if (num != 0)
				{
				}
				num = (short)1690763265;
				if (num != 0)
				{
				}
				this.radInfoFrequencyRangesUHF2UsedinCodeplug_A8507.HiddenDynamic = value;
			}
		}

		// Token: 0x170023E6 RID: 9190
		// (get) Token: 0x060045FB RID: 17915 RVA: 0x0040FD50 File Offset: 0x0040DF50
		public bool RadInfoFrequencyRangesUHF2UsedinCodeplug_A8507_HasDiffs
		{
			get
			{
				short num = (short)2067070976;
				short num2 = num;
				num = (short)1843855361;
				if (num != 0)
				{
				}
				num = (short)553273761;
				short num3 = num;
				num = (short)1651984801;
				switch (num3 == num)
				{
				}
				num = (short)1513095168;
				if (num != 0)
				{
				}
				return this.radInfoFrequencyRangesUHF2UsedinCodeplug_A8507._HasDiffs;
			}
		}

		// Token: 0x170023E7 RID: 9191
		// (get) Token: 0x060045FC RID: 17916 RVA: 0x0040FE04 File Offset: 0x0040E004
		// (set) Token: 0x060045FD RID: 17917 RVA: 0x0040FEC0 File Offset: 0x0040E0C0
		public bool RadInfoFrequencyRanges7800MHzUsedinCodeplug_A8512Value
		{
			get
			{
				short num = (short)133038080;
				short num2 = num;
				num = (short)42686501;
				short num3 = num;
				num = (short)1509972005;
				switch (num3 == num)
				{
				}
				num = (short)1397620737;
				if (num != 0)
				{
				}
				num = (short)1574699008;
				if (num != 0)
				{
				}
				this.i();
				return this.radInfoFrequencyRanges7800MHzUsedinCodeplug_A8512.Value;
			}
			set
			{
				short num = (short)666304512;
				short num2 = num;
				num = (short)1513167888;
				short num3 = num;
				num = (short)1882594320;
				switch (num3 == num)
				{
				}
				num = (short)1942028288;
				if (num != 0)
				{
				}
				num = (short)1280180225;
				if (num != 0)
				{
				}
				this.radInfoFrequencyRanges7800MHzUsedinCodeplug_A8512.Value = value;
			}
		}

		// Token: 0x170023E8 RID: 9192
		// (get) Token: 0x060045FE RID: 17918 RVA: 0x0040FF78 File Offset: 0x0040E178
		public global::AcpBusinessLayer.AcpField<bool> RadInfoFrequencyRanges7800MHzUsedinCodeplug_A8512
		{
			get
			{
				short num = (short)739966976;
				short num2 = num;
				num = (short)214687435;
				short num3 = num;
				num = (short)877321931;
				switch (num3 == num)
				{
				}
				num = (short)1332543489;
				if (num != 0)
				{
				}
				num = (short)987758592;
				if (num != 0)
				{
				}
				return this.radInfoFrequencyRanges7800MHzUsedinCodeplug_A8512;
			}
		}

		// Token: 0x170023E9 RID: 9193
		// (get) Token: 0x060045FF RID: 17919 RVA: 0x0041002C File Offset: 0x0040E22C
		// (set) Token: 0x06004600 RID: 17920 RVA: 0x004100E0 File Offset: 0x0040E2E0
		public bool RadInfoFrequencyRanges7800MHzUsedinCodeplug_A8512_UIValue
		{
			get
			{
				short num = (short)1520107520;
				short num2 = num;
				num = (short)771657593;
				short num3 = num;
				num = (short)224038777;
				switch (num3 == num)
				{
				}
				num = (short)1130496001;
				if (num != 0)
				{
				}
				num = (short)170917888;
				if (num != 0)
				{
				}
				return this.radInfoFrequencyRanges7800MHzUsedinCodeplug_A8512.Value;
			}
			set
			{
				short num = (short)626458624;
				short num2 = num;
				num = (short)1939576783;
				short num3 = num;
				num = (short)1566611407;
				switch (num3 == num)
				{
				}
				num = (short)1695612929;
				if (num != 0)
				{
				}
				num = (short)1039794176;
				if (num != 0)
				{
				}
				this.radInfoFrequencyRanges7800MHzUsedinCodeplug_A8512.Value = value;
			}
		}

		// Token: 0x170023EA RID: 9194
		// (get) Token: 0x06004601 RID: 17921 RVA: 0x00410198 File Offset: 0x0040E398
		// (set) Token: 0x06004602 RID: 17922 RVA: 0x0041024C File Offset: 0x0040E44C
		public bool RadInfoFrequencyRanges7800MHzUsedinCodeplug_A8512_Applicable
		{
			get
			{
				short num = (short)737869824;
				short num2 = num;
				num = (short)930531503;
				short num3 = num;
				num = (short)917031087;
				switch (num3 == num)
				{
				}
				num = (short)2102263809;
				if (num != 0)
				{
				}
				num = (short)1778057216;
				if (num != 0)
				{
				}
				return this.radInfoFrequencyRanges7800MHzUsedinCodeplug_A8512.Applicable;
			}
			set
			{
				short num = (short)64159744;
				short num2 = num;
				num = (short)1024882307;
				short num3 = num;
				num = (short)249394819;
				switch (num3 == num)
				{
				}
				num = (short)854261761;
				if (num != 0)
				{
				}
				num = (short)215220224;
				if (num != 0)
				{
				}
				this.radInfoFrequencyRanges7800MHzUsedinCodeplug_A8512.Applicable = value;
			}
		}

		// Token: 0x170023EB RID: 9195
		// (get) Token: 0x06004603 RID: 17923 RVA: 0x00410304 File Offset: 0x0040E504
		// (set) Token: 0x06004604 RID: 17924 RVA: 0x004103B8 File Offset: 0x0040E5B8
		public bool RadInfoFrequencyRanges7800MHzUsedinCodeplug_A8512_Valid
		{
			get
			{
				short num = (short)669908992;
				short num2 = num;
				num = (short)1361379329;
				if (num != 0)
				{
				}
				num = (short)2108393382;
				short num3 = num;
				num = (short)1253083046;
				switch (num3 == num)
				{
				}
				num = (short)402325504;
				if (num != 0)
				{
				}
				return this.radInfoFrequencyRanges7800MHzUsedinCodeplug_A8512.Valid;
			}
			set
			{
				short num = (short)1594359808;
				short num2 = num;
				num = (short)727787730;
				short num3 = num;
				num = (short)761669842;
				switch (num3 == num)
				{
				}
				num = (short)846528512;
				if (num != 0)
				{
				}
				num = (short)264175617;
				if (num != 0)
				{
				}
				this.radInfoFrequencyRanges7800MHzUsedinCodeplug_A8512.Valid = value;
			}
		}

		// Token: 0x170023EC RID: 9196
		// (get) Token: 0x06004605 RID: 17925 RVA: 0x00410470 File Offset: 0x0040E670
		// (set) Token: 0x06004606 RID: 17926 RVA: 0x00410528 File Offset: 0x0040E728
		public bool RadInfoFrequencyRanges7800MHzUsedinCodeplug_A8512_Visible
		{
			get
			{
				short num = (short)980746240;
				short num2 = num;
				num = (short)1151637411;
				short num3 = num;
				num = (short)332044195;
				switch (num3 == num)
				{
				}
				num = (short)2010710017;
				if (num != 0)
				{
				}
				num = (short)2035941376;
				if (num != 0)
				{
				}
				return this.radInfoFrequencyRanges7800MHzUsedinCodeplug_A8512.Visible;
			}
			set
			{
				short num = (short)1827602432;
				short num2 = num;
				num = (short)2002714625;
				if (num != 0)
				{
				}
				num = (short)37609152;
				short num3 = num;
				num = (short)939908800;
				switch (num3 == num)
				{
				}
				num = (short)1196687360;
				if (num != 0)
				{
				}
				this.radInfoFrequencyRanges7800MHzUsedinCodeplug_A8512.Visible = value;
			}
		}

		// Token: 0x170023ED RID: 9197
		// (get) Token: 0x06004607 RID: 17927 RVA: 0x004105DC File Offset: 0x0040E7DC
		// (set) Token: 0x06004608 RID: 17928 RVA: 0x00410690 File Offset: 0x0040E890
		public bool RadInfoFrequencyRanges7800MHzUsedinCodeplug_A8512_Editable
		{
			get
			{
				short num = (short)213057536;
				short num2 = num;
				num = (short)1272172164;
				short num3 = num;
				num = (short)1084870276;
				switch (num3 == num)
				{
				}
				num = (short)1923153921;
				if (num != 0)
				{
				}
				num = (short)320012288;
				if (num != 0)
				{
				}
				return this.radInfoFrequencyRanges7800MHzUsedinCodeplug_A8512.Editable;
			}
			set
			{
				short num = (short)1893007360;
				short num2 = num;
				num = (short)1413347711;
				short num3 = num;
				num = (short)1517091199;
				switch (num3 == num)
				{
				}
				num = (short)247463937;
				if (num != 0)
				{
				}
				num = (short)1578041344;
				if (num != 0)
				{
				}
				this.radInfoFrequencyRanges7800MHzUsedinCodeplug_A8512.Editable = value;
			}
		}

		// Token: 0x170023EE RID: 9198
		// (get) Token: 0x06004609 RID: 17929 RVA: 0x00410744 File Offset: 0x0040E944
		internal string RadInfoFrequencyRanges7800MHzUsedinCodeplug_A8512_UILabel
		{
			get
			{
				short num = (short)1851850752;
				short num2 = num;
				num = (short)1988761730;
				short num3 = num;
				num = (short)392763522;
				switch (num3 == num)
				{
				}
				num = (short)382074881;
				if (num != 0)
				{
				}
				num = (short)299171840;
				if (num != 0)
				{
				}
				return this.radInfoFrequencyRanges7800MHzUsedinCodeplug_A8512.UIName;
			}
		}

		// Token: 0x170023EF RID: 9199
		// (get) Token: 0x0600460A RID: 17930 RVA: 0x004107F8 File Offset: 0x0040E9F8
		// (set) Token: 0x0600460B RID: 17931 RVA: 0x004108AC File Offset: 0x0040EAAC
		internal bool RadInfoFrequencyRanges7800MHzUsedinCodeplug_A8512_HiddenStatic
		{
			get
			{
				short num = (short)16143903;
				short num2 = num;
				num = (short)584537631;
				switch (num2 == num)
				{
				}
				num = (short)683933697;
				if (num != 0)
				{
				}
				num = (short)88670208;
				if (num != 0)
				{
				}
				num = (short)1117978624;
				short num3 = num;
				return this.radInfoFrequencyRanges7800MHzUsedinCodeplug_A8512.HiddenStatic;
			}
			set
			{
				short num = (short)424545800;
				short num2 = num;
				num = (short)2011368968;
				switch (num2 == num)
				{
				}
				num = (short)1532297216;
				if (num != 0)
				{
				}
				num = (short)373293057;
				if (num != 0)
				{
				}
				num = (short)1917190144;
				short num3 = num;
				this.radInfoFrequencyRanges7800MHzUsedinCodeplug_A8512.HiddenStatic = value;
			}
		}

		// Token: 0x170023F0 RID: 9200
		// (get) Token: 0x0600460C RID: 17932 RVA: 0x00410964 File Offset: 0x0040EB64
		// (set) Token: 0x0600460D RID: 17933 RVA: 0x00410A18 File Offset: 0x0040EC18
		internal bool RadInfoFrequencyRanges7800MHzUsedinCodeplug_A8512_HiddenDynamic
		{
			get
			{
				short num = (short)398426621;
				short num2 = num;
				num = (short)1630110205;
				switch (num2 == num)
				{
				}
				num = (short)1933180929;
				if (num != 0)
				{
				}
				num = (short)1999896576;
				if (num != 0)
				{
				}
				num = (short)2114060288;
				short num3 = num;
				return this.radInfoFrequencyRanges7800MHzUsedinCodeplug_A8512.HiddenDynamic;
			}
			set
			{
				short num = (short)851855339;
				short num2 = num;
				num = (short)298993643;
				switch (num2 == num)
				{
				}
				num = (short)713883649;
				if (num != 0)
				{
				}
				num = (short)78184448;
				if (num != 0)
				{
				}
				num = (short)1472593920;
				short num3 = num;
				this.radInfoFrequencyRanges7800MHzUsedinCodeplug_A8512.HiddenDynamic = value;
			}
		}

		// Token: 0x170023F1 RID: 9201
		// (get) Token: 0x0600460E RID: 17934 RVA: 0x00410ACC File Offset: 0x0040ECCC
		public bool RadInfoFrequencyRanges7800MHzUsedinCodeplug_A8512_HasDiffs
		{
			get
			{
				short num = (short)930994107;
				short num2 = num;
				num = (short)1688262587;
				switch (num2 == num)
				{
				}
				num = (short)2135293953;
				if (num != 0)
				{
				}
				num = (short)1736572928;
				if (num != 0)
				{
				}
				num = (short)1326972928;
				short num3 = num;
				return this.radInfoFrequencyRanges7800MHzUsedinCodeplug_A8512._HasDiffs;
			}
		}

		// Token: 0x170023F2 RID: 9202
		// (get) Token: 0x0600460F RID: 17935 RVA: 0x00410B84 File Offset: 0x0040ED84
		// (set) Token: 0x06004610 RID: 17936 RVA: 0x00410C40 File Offset: 0x0040EE40
		public bool RadInfoFrequencyRanges900MHzUsedinCodeplug_A8516Value
		{
			get
			{
				short num = (short)1883661995;
				short num2 = num;
				num = (short)1000105643;
				switch (num2 == num)
				{
				}
				num = (short)2068774913;
				if (num != 0)
				{
				}
				num = (short)981729280;
				if (num != 0)
				{
				}
				num = (short)16908288;
				short num3 = num;
				this.h();
				return this.radInfoFrequencyRanges900MHzUsedinCodeplug_A8516.Value;
			}
			set
			{
				short num = (short)1014300029;
				short num2 = num;
				num = (short)1545665917;
				switch (num2 == num)
				{
				}
				num = (short)214368257;
				if (num != 0)
				{
				}
				num = (short)1215954944;
				if (num != 0)
				{
				}
				num = (short)1253572608;
				short num3 = num;
				this.radInfoFrequencyRanges900MHzUsedinCodeplug_A8516.Value = value;
			}
		}

		// Token: 0x170023F3 RID: 9203
		// (get) Token: 0x06004611 RID: 17937 RVA: 0x00410CF8 File Offset: 0x0040EEF8
		public global::AcpBusinessLayer.AcpField<bool> RadInfoFrequencyRanges900MHzUsedinCodeplug_A8516
		{
			get
			{
				short num = (short)1474179046;
				short num2 = num;
				num = (short)444411878;
				switch (num2 == num)
				{
				}
				num = (short)1024524288;
				if (num != 0)
				{
				}
				num = (short)756809729;
				if (num != 0)
				{
				}
				num = (short)1635254272;
				short num3 = num;
				return this.radInfoFrequencyRanges900MHzUsedinCodeplug_A8516;
			}
		}

		// Token: 0x170023F4 RID: 9204
		// (get) Token: 0x06004612 RID: 17938 RVA: 0x00410DA8 File Offset: 0x0040EFA8
		// (set) Token: 0x06004613 RID: 17939 RVA: 0x00410E5C File Offset: 0x0040F05C
		public bool RadInfoFrequencyRanges900MHzUsedinCodeplug_A8516_UIValue
		{
			get
			{
				short num = (short)1955677289;
				short num2 = num;
				num = (short)728712297;
				switch (num2 == num)
				{
				}
				num = (short)169934849;
				if (num != 0)
				{
				}
				num = (short)955187200;
				if (num != 0)
				{
				}
				num = (short)2115371008;
				short num3 = num;
				return this.radInfoFrequencyRanges900MHzUsedinCodeplug_A8516.Value;
			}
			set
			{
				short num = (short)999421504;
				short num2 = num;
				num = (short)1209726528;
				switch (num2 == num)
				{
				}
				num = (short)1231880193;
				if (num != 0)
				{
				}
				num = (short)434372608;
				if (num != 0)
				{
				}
				num = (short)1139998720;
				short num3 = num;
				this.radInfoFrequencyRanges900MHzUsedinCodeplug_A8516.Value = value;
			}
		}

		// Token: 0x170023F5 RID: 9205
		// (get) Token: 0x06004614 RID: 17940 RVA: 0x00410F10 File Offset: 0x0040F110
		// (set) Token: 0x06004615 RID: 17941 RVA: 0x00410FC8 File Offset: 0x0040F1C8
		public bool RadInfoFrequencyRanges900MHzUsedinCodeplug_A8516_Applicable
		{
			get
			{
				short num = (short)2100355282;
				short num2 = num;
				num = (short)376037586;
				switch (num2 == num)
				{
				}
				num = (short)1463943169;
				if (num != 0)
				{
				}
				num = (short)1281949696;
				if (num != 0)
				{
				}
				num = (short)515702784;
				short num3 = num;
				return this.radInfoFrequencyRanges900MHzUsedinCodeplug_A8516.Applicable;
			}
			set
			{
				short num = (short)1453374059;
				short num2 = num;
				num = (short)805812843;
				switch (num2 == num)
				{
				}
				num = (short)62980097;
				if (num != 0)
				{
				}
				num = (short)694812672;
				if (num != 0)
				{
				}
				num = (short)233832448;
				short num3 = num;
				this.radInfoFrequencyRanges900MHzUsedinCodeplug_A8516.Applicable = value;
			}
		}

		// Token: 0x170023F6 RID: 9206
		// (get) Token: 0x06004616 RID: 17942 RVA: 0x0041107C File Offset: 0x0040F27C
		// (set) Token: 0x06004617 RID: 17943 RVA: 0x00411134 File Offset: 0x0040F334
		public bool RadInfoFrequencyRanges900MHzUsedinCodeplug_A8516_Valid
		{
			get
			{
				short num = (short)963263887;
				short num2 = num;
				num = (short)1520057743;
				switch (num2 == num)
				{
				}
				num = (short)1903493121;
				if (num != 0)
				{
				}
				num = (short)1880948736;
				if (num != 0)
				{
				}
				num = (short)1955004416;
				short num3 = num;
				return this.radInfoFrequencyRanges900MHzUsedinCodeplug_A8516.Valid;
			}
			set
			{
				short num = (short)423568653;
				short num2 = num;
				num = (short)513942797;
				switch (num2 == num)
				{
				}
				num = (short)617807873;
				if (num != 0)
				{
				}
				num = (short)15335424;
				if (num != 0)
				{
				}
				num = (short)1023344640;
				short num3 = num;
				this.radInfoFrequencyRanges900MHzUsedinCodeplug_A8516.Valid = value;
			}
		}

		// Token: 0x170023F7 RID: 9207
		// (get) Token: 0x06004618 RID: 17944 RVA: 0x004111E8 File Offset: 0x0040F3E8
		// (set) Token: 0x06004619 RID: 17945 RVA: 0x0041129C File Offset: 0x0040F49C
		public bool RadInfoFrequencyRanges900MHzUsedinCodeplug_A8516_Visible
		{
			get
			{
				short num = (short)1105264641;
				if (num != 0)
				{
				}
				num = (short)1647928451;
				short num2 = num;
				num = (short)608789635;
				switch (num2 == num)
				{
				}
				num = (short)1053360128;
				if (num != 0)
				{
				}
				num = (short)508166144;
				short num3 = num;
				return this.radInfoFrequencyRanges900MHzUsedinCodeplug_A8516.Visible;
			}
			set
			{
				short num = (short)688698664;
				short num2 = num;
				num = (short)949531944;
				switch (num2 == num)
				{
				}
				num = (short)1698430976;
				if (num != 0)
				{
				}
				num = (short)56557569;
				if (num != 0)
				{
				}
				num = (short)149422080;
				short num3 = num;
				this.radInfoFrequencyRanges900MHzUsedinCodeplug_A8516.Visible = value;
			}
		}

		// Token: 0x170023F8 RID: 9208
		// (get) Token: 0x0600461A RID: 17946 RVA: 0x00411354 File Offset: 0x0040F554
		// (set) Token: 0x0600461B RID: 17947 RVA: 0x00411408 File Offset: 0x0040F608
		public bool RadInfoFrequencyRanges900MHzUsedinCodeplug_A8516_Editable
		{
			get
			{
				short num = (short)2142989906;
				short num2 = num;
				num = (short)1284402770;
				switch (num2 == num)
				{
				}
				num = (short)234815489;
				if (num != 0)
				{
				}
				num = (short)1077608448;
				if (num != 0)
				{
				}
				num = (short)1039007744;
				short num3 = num;
				return this.radInfoFrequencyRanges900MHzUsedinCodeplug_A8516.Editable;
			}
			set
			{
				short num = (short)2002188273;
				short num2 = num;
				num = (short)694941681;
				switch (num2 == num)
				{
				}
				num = (short)706543616;
				if (num != 0)
				{
				}
				num = (short)72482817;
				if (num != 0)
				{
				}
				num = (short)1899495424;
				short num3 = num;
				this.radInfoFrequencyRanges900MHzUsedinCodeplug_A8516.Editable = value;
			}
		}

		// Token: 0x170023F9 RID: 9209
		// (get) Token: 0x0600461C RID: 17948 RVA: 0x004114C0 File Offset: 0x0040F6C0
		internal string RadInfoFrequencyRanges900MHzUsedinCodeplug_A8516_UILabel
		{
			get
			{
				short num = (short)295530738;
				short num2 = num;
				num = (short)868249842;
				switch (num2 == num)
				{
				}
				num = (short)1134755841;
				if (num != 0)
				{
				}
				num = (short)1236729856;
				if (num != 0)
				{
				}
				num = (short)1631715328;
				short num3 = num;
				return this.radInfoFrequencyRanges900MHzUsedinCodeplug_A8516.UIName;
			}
		}

		// Token: 0x170023FA RID: 9210
		// (get) Token: 0x0600461D RID: 17949 RVA: 0x00411578 File Offset: 0x0040F778
		// (set) Token: 0x0600461E RID: 17950 RVA: 0x0041162C File Offset: 0x0040F82C
		internal bool RadInfoFrequencyRanges900MHzUsedinCodeplug_A8516_HiddenStatic
		{
			get
			{
				short num = (short)210312416;
				short num2 = num;
				num = (short)585506016;
				switch (num2 == num)
				{
				}
				num = (short)1979711489;
				if (num != 0)
				{
				}
				num = (short)748027904;
				if (num != 0)
				{
				}
				num = (short)1314848768;
				short num3 = num;
				return this.radInfoFrequencyRanges900MHzUsedinCodeplug_A8516.HiddenStatic;
			}
			set
			{
				short num = (short)1924071425;
				if (num != 0)
				{
				}
				num = (short)1383265961;
				short num2 = num;
				num = (short)1195439785;
				switch (num2 == num)
				{
				}
				num = (short)1847590912;
				if (num != 0)
				{
				}
				num = (short)105709568;
				short num3 = num;
				this.radInfoFrequencyRanges900MHzUsedinCodeplug_A8516.HiddenStatic = value;
			}
		}

		// Token: 0x170023FB RID: 9211
		// (get) Token: 0x0600461F RID: 17951 RVA: 0x004116E0 File Offset: 0x0040F8E0
		// (set) Token: 0x06004620 RID: 17952 RVA: 0x00411798 File Offset: 0x0040F998
		internal bool RadInfoFrequencyRanges900MHzUsedinCodeplug_A8516_HiddenDynamic
		{
			get
			{
				short num = (short)299244072;
				short num2 = num;
				num = (short)150215208;
				switch (num2 == num)
				{
				}
				num = (short)1566703617;
				if (num != 0)
				{
				}
				num = (short)656277504;
				if (num != 0)
				{
				}
				num = (short)1418002432;
				short num3 = num;
				return this.radInfoFrequencyRanges900MHzUsedinCodeplug_A8516.HiddenDynamic;
			}
			set
			{
				short num = (short)410094319;
				short num2 = num;
				num = (short)949914351;
				switch (num2 == num)
				{
				}
				num = (short)1215234049;
				if (num != 0)
				{
				}
				num = (short)882376704;
				if (num != 0)
				{
				}
				num = (short)1000144896;
				short num3 = num;
				this.radInfoFrequencyRanges900MHzUsedinCodeplug_A8516.HiddenDynamic = value;
			}
		}

		// Token: 0x170023FC RID: 9212
		// (get) Token: 0x06004621 RID: 17953 RVA: 0x0041184C File Offset: 0x0040FA4C
		public bool RadInfoFrequencyRanges900MHzUsedinCodeplug_A8516_HasDiffs
		{
			get
			{
				short num = (short)1091829761;
				if (num != 0)
				{
				}
				num = (short)1668826119;
				short num2 = num;
				num = (short)592987143;
				switch (num2 == num)
				{
				}
				num = (short)2102460416;
				if (num != 0)
				{
				}
				num = (short)529137664;
				short num3 = num;
				return this.radInfoFrequencyRanges900MHzUsedinCodeplug_A8516._HasDiffs;
			}
		}

		// Token: 0x170023FD RID: 9213
		// (get) Token: 0x06004622 RID: 17954 RVA: 0x00411900 File Offset: 0x0040FB00
		// (set) Token: 0x06004623 RID: 17955 RVA: 0x004119BC File Offset: 0x0040FBBC
		public bool RadInfoFrequencyRangesAllowInvalidFrequencies_A12493Value
		{
			get
			{
				short num = (short)1850081281;
				if (num != 0)
				{
				}
				num = (short)379261239;
				short num2 = num;
				num = (short)1053888823;
				switch (num2 == num)
				{
				}
				num = (short)896335872;
				if (num != 0)
				{
				}
				num = (short)857341952;
				short num3 = num;
				this.g();
				return this.radInfoFrequencyRangesAllowInvalidFrequencies_A12493.Value;
			}
			set
			{
				short num = (short)668360679;
				short num2 = num;
				num = (short)1583767527;
				switch (num2 == num)
				{
				}
				num = (short)1809055744;
				if (num != 0)
				{
				}
				num = (short)293011457;
				if (num != 0)
				{
				}
				num = (short)1700593664;
				short num3 = num;
				this.radInfoFrequencyRangesAllowInvalidFrequencies_A12493.Value = value;
			}
		}

		// Token: 0x170023FE RID: 9214
		// (get) Token: 0x06004624 RID: 17956 RVA: 0x00411A74 File Offset: 0x0040FC74
		public global::AcpBusinessLayer.AcpField<bool> RadInfoFrequencyRangesAllowInvalidFrequencies_A12493
		{
			get
			{
				short num = (short)508211471;
				short num2 = num;
				num = (short)962965775;
				switch (num2 == num)
				{
				}
				num = (short)158334977;
				if (num != 0)
				{
				}
				num = (short)25362432;
				if (num != 0)
				{
				}
				num = (short)369033216;
				short num3 = num;
				return this.radInfoFrequencyRangesAllowInvalidFrequencies_A12493;
			}
		}

		// Token: 0x170023FF RID: 9215
		// (get) Token: 0x06004625 RID: 17957 RVA: 0x00411B28 File Offset: 0x0040FD28
		// (set) Token: 0x06004626 RID: 17958 RVA: 0x00411BDC File Offset: 0x0040FDDC
		public bool RadInfoFrequencyRangesAllowInvalidFrequencies_A12493_UIValue
		{
			get
			{
				short num = (short)175820769;
				short num2 = num;
				num = (short)1919864801;
				switch (num2 == num)
				{
				}
				num = (short)1213923329;
				if (num != 0)
				{
				}
				num = (short)826736640;
				if (num != 0)
				{
				}
				num = (short)963969024;
				short num3 = num;
				return this.radInfoFrequencyRangesAllowInvalidFrequencies_A12493.Value;
			}
			set
			{
				short num = (short)1067446999;
				short num2 = num;
				num = (short)536474327;
				switch (num2 == num)
				{
				}
				num = (short)1861419008;
				if (num != 0)
				{
				}
				num = (short)313720833;
				if (num != 0)
				{
				}
				num = (short)1372258304;
				short num3 = num;
				this.radInfoFrequencyRangesAllowInvalidFrequencies_A12493.Value = value;
			}
		}

		// Token: 0x17002400 RID: 9216
		// (get) Token: 0x06004627 RID: 17959 RVA: 0x00411C94 File Offset: 0x0040FE94
		// (set) Token: 0x06004628 RID: 17960 RVA: 0x00411D48 File Offset: 0x0040FF48
		public bool RadInfoFrequencyRangesAllowInvalidFrequencies_A12493_Applicable
		{
			get
			{
				short num = (short)1174913490;
				short num2 = num;
				num = (short)1047642578;
				switch (num2 == num)
				{
				}
				num = (short)1058406401;
				if (num != 0)
				{
				}
				num = (short)533856256;
				if (num != 0)
				{
				}
				num = (short)1221853184;
				short num3 = num;
				return this.radInfoFrequencyRangesAllowInvalidFrequencies_A12493.Applicable;
			}
			set
			{
				short num = (short)1493513601;
				short num2 = num;
				num = (short)26555777;
				switch (num2 == num)
				{
				}
				num = (short)809828352;
				if (num != 0)
				{
				}
				num = (short)1248329729;
				if (num != 0)
				{
				}
				num = (short)1886388224;
				short num3 = num;
				this.radInfoFrequencyRangesAllowInvalidFrequencies_A12493.Applicable = value;
			}
		}

		// Token: 0x17002401 RID: 9217
		// (get) Token: 0x06004629 RID: 17961 RVA: 0x00411DFC File Offset: 0x0040FFFC
		// (set) Token: 0x0600462A RID: 17962 RVA: 0x00411EB4 File Offset: 0x004100B4
		public bool RadInfoFrequencyRangesAllowInvalidFrequencies_A12493_Valid
		{
			get
			{
				short num = (short)563022165;
				short num2 = num;
				num = (short)593299797;
				switch (num2 == num)
				{
				}
				num = (short)1973354496;
				if (num != 0)
				{
				}
				num = (short)1330970625;
				if (num != 0)
				{
				}
				num = (short)1005322240;
				short num3 = num;
				return this.radInfoFrequencyRangesAllowInvalidFrequencies_A12493.Valid;
			}
			set
			{
				short num = (short)1291410574;
				short num2 = num;
				num = (short)419323022;
				switch (num2 == num)
				{
				}
				num = (short)1842544640;
				if (num != 0)
				{
				}
				num = (short)7864321;
				if (num != 0)
				{
				}
				num = (short)1286275072;
				short num3 = num;
				this.radInfoFrequencyRangesAllowInvalidFrequencies_A12493.Valid = value;
			}
		}

		// Token: 0x17002402 RID: 9218
		// (get) Token: 0x0600462B RID: 17963 RVA: 0x00411F68 File Offset: 0x00410168
		// (set) Token: 0x0600462C RID: 17964 RVA: 0x0041201C File Offset: 0x0041021C
		public bool RadInfoFrequencyRangesAllowInvalidFrequencies_A12493_Visible
		{
			get
			{
				short num = (short)2078878675;
				short num2 = num;
				num = (short)1038625747;
				switch (num2 == num)
				{
				}
				num = (short)635043841;
				if (num != 0)
				{
				}
				num = (short)1606090752;
				if (num != 0)
				{
				}
				num = (short)896663552;
				short num3 = num;
				return this.radInfoFrequencyRangesAllowInvalidFrequencies_A12493.Visible;
			}
			set
			{
				short num = (short)419738658;
				short num2 = num;
				num = (short)1940436002;
				switch (num2 == num)
				{
				}
				num = (short)1214578688;
				if (num != 0)
				{
				}
				num = (short)728104961;
				if (num != 0)
				{
				}
				num = (short)886833152;
				short num3 = num;
				this.radInfoFrequencyRangesAllowInvalidFrequencies_A12493.Visible = value;
			}
		}

		// Token: 0x17002403 RID: 9219
		// (get) Token: 0x0600462D RID: 17965 RVA: 0x004120D0 File Offset: 0x004102D0
		// (set) Token: 0x0600462E RID: 17966 RVA: 0x00412188 File Offset: 0x00410388
		public bool RadInfoFrequencyRangesAllowInvalidFrequencies_A12493_Editable
		{
			get
			{
				short num = (short)353525853;
				short num2 = num;
				num = (short)610361437;
				switch (num2 == num)
				{
				}
				num = (short)284426240;
				if (num != 0)
				{
				}
				num = (short)1252917249;
				if (num != 0)
				{
				}
				num = (short)1789591552;
				short num3 = num;
				return this.radInfoFrequencyRangesAllowInvalidFrequencies_A12493.Editable;
			}
			set
			{
				short num = (short)1325681575;
				short num2 = num;
				num = (short)1012747175;
				switch (num2 == num)
				{
				}
				num = (short)1332871169;
				if (num != 0)
				{
				}
				num = (short)550240256;
				if (num != 0)
				{
				}
				num = (short)2074214400;
				short num3 = num;
				this.radInfoFrequencyRangesAllowInvalidFrequencies_A12493.Editable = value;
			}
		}

		// Token: 0x17002404 RID: 9220
		// (get) Token: 0x0600462F RID: 17967 RVA: 0x00412240 File Offset: 0x00410440
		internal string RadInfoFrequencyRangesAllowInvalidFrequencies_A12493_UILabel
		{
			get
			{
				short num = (short)158114447;
				short num2 = num;
				num = (short)1834853007;
				switch (num2 == num)
				{
				}
				num = (short)995688449;
				if (num != 0)
				{
				}
				num = (short)1146945536;
				if (num != 0)
				{
				}
				num = (short)1669595136;
				short num3 = num;
				return this.radInfoFrequencyRangesAllowInvalidFrequencies_A12493.UIName;
			}
		}

		// Token: 0x17002405 RID: 9221
		// (get) Token: 0x06004630 RID: 17968 RVA: 0x004122F4 File Offset: 0x004104F4
		// (set) Token: 0x06004631 RID: 17969 RVA: 0x004123A8 File Offset: 0x004105A8
		internal bool RadInfoFrequencyRangesAllowInvalidFrequencies_A12493_HiddenStatic
		{
			get
			{
				short num = (short)1308001812;
				short num2 = num;
				num = (short)1685816852;
				switch (num2 == num)
				{
				}
				num = (short)1722679297;
				if (num != 0)
				{
				}
				num = (short)37879808;
				if (num != 0)
				{
				}
				num = (short)349831168;
				short num3 = num;
				return this.radInfoFrequencyRangesAllowInvalidFrequencies_A12493.HiddenStatic;
			}
			set
			{
				short num = (short)612453769;
				short num2 = num;
				num = (short)24137097;
				switch (num2 == num)
				{
				}
				num = (short)973996033;
				if (num != 0)
				{
				}
				num = (short)1284308992;
				if (num != 0)
				{
				}
				num = (short)1342570496;
				short num3 = num;
				this.radInfoFrequencyRangesAllowInvalidFrequencies_A12493.HiddenStatic = value;
			}
		}

		// Token: 0x17002406 RID: 9222
		// (get) Token: 0x06004632 RID: 17970 RVA: 0x0041245C File Offset: 0x0041065C
		// (set) Token: 0x06004633 RID: 17971 RVA: 0x00412514 File Offset: 0x00410714
		internal bool RadInfoFrequencyRangesAllowInvalidFrequencies_A12493_HiddenDynamic
		{
			get
			{
				short num = (short)1715031075;
				short num2 = num;
				num = (short)646532131;
				switch (num2 == num)
				{
				}
				num = (short)1799946240;
				if (num != 0)
				{
				}
				num = (short)1566769153;
				if (num != 0)
				{
				}
				num = (short)1929773056;
				short num3 = num;
				return this.radInfoFrequencyRangesAllowInvalidFrequencies_A12493.HiddenDynamic;
			}
			set
			{
				short num = (short)264054846;
				short num2 = num;
				num = (short)726411326;
				switch (num2 == num)
				{
				}
				num = (short)245563392;
				if (num != 0)
				{
				}
				num = (short)1788280833;
				if (num != 0)
				{
				}
				num = (short)320667648;
				short num3 = num;
				this.radInfoFrequencyRangesAllowInvalidFrequencies_A12493.HiddenDynamic = value;
			}
		}

		// Token: 0x17002407 RID: 9223
		// (get) Token: 0x06004634 RID: 17972 RVA: 0x004125D0 File Offset: 0x004107D0
		public bool RadInfoFrequencyRangesAllowInvalidFrequencies_A12493_HasDiffs
		{
			get
			{
				short num = (short)751949734;
				short num2 = num;
				num = (short)791992230;
				switch (num2 == num)
				{
				}
				num = (short)1112014849;
				if (num != 0)
				{
				}
				num = (short)1520304128;
				if (num != 0)
				{
				}
				num = (short)1173946368;
				short num3 = num;
				return this.radInfoFrequencyRangesAllowInvalidFrequencies_A12493._HasDiffs;
			}
		}

		// Token: 0x17002408 RID: 9224
		// (get) Token: 0x06004635 RID: 17973 RVA: 0x00412684 File Offset: 0x00410884
		// (set) Token: 0x06004636 RID: 17974 RVA: 0x0041273C File Offset: 0x0041093C
		public bool RadInfoFrequencyRangesOpenFrequency_A22699Value
		{
			get
			{
				short num = (short)410910721;
				if (num != 0)
				{
				}
				num = (short)1915152522;
				short num2 = num;
				num = (short)803399818;
				switch (num2 == num)
				{
				}
				num = (short)941031424;
				if (num != 0)
				{
				}
				num = (short)785121280;
				short num3 = num;
				return this.radInfoFrequencyRangesOpenFrequency_A22699.Value;
			}
			set
			{
				short num = (short)45002407;
				short num2 = num;
				num = (short)1034006183;
				switch (num2 == num)
				{
				}
				num = (short)1110376449;
				if (num != 0)
				{
				}
				num = (short)903675904;
				if (num != 0)
				{
				}
				num = (short)100270080;
				short num3 = num;
				this.radInfoFrequencyRangesOpenFrequency_A22699.Value = value;
			}
		}

		// Token: 0x17002409 RID: 9225
		// (get) Token: 0x06004637 RID: 17975 RVA: 0x004127F4 File Offset: 0x004109F4
		public global::AcpBusinessLayer.AcpField<bool> RadInfoFrequencyRangesOpenFrequency_A22699
		{
			get
			{
				short num = (short)392617316;
				short num2 = num;
				num = (short)2076040548;
				switch (num2 == num)
				{
				}
				num = (short)1337917440;
				if (num != 0)
				{
				}
				num = (short)1024589824;
				short num3 = num;
				num = (short)964755457;
				if (num != 0)
				{
				}
				return this.radInfoFrequencyRangesOpenFrequency_A22699;
			}
		}

		// Token: 0x1700240A RID: 9226
		// (get) Token: 0x06004638 RID: 17976 RVA: 0x004128A0 File Offset: 0x00410AA0
		// (set) Token: 0x06004639 RID: 17977 RVA: 0x00412954 File Offset: 0x00410B54
		public bool RadInfoFrequencyRangesOpenFrequency_A22699_UIValue
		{
			get
			{
				short num = (short)1073122080;
				short num2 = num;
				num = (short)927042336;
				switch (num2 == num)
				{
				}
				num = (short)430833665;
				if (num != 0)
				{
				}
				num = (short)87818240;
				short num3 = num;
				num = (short)746323968;
				if (num != 0)
				{
				}
				return this.radInfoFrequencyRangesOpenFrequency_A22699.Value;
			}
			set
			{
				short num = (short)1501778294;
				short num2 = num;
				num = (short)738087286;
				switch (num2 == num)
				{
				}
				num = (short)109379585;
				if (num != 0)
				{
				}
				num = (short)1877540864;
				short num3 = num;
				num = (short)1189347328;
				if (num != 0)
				{
				}
				this.radInfoFrequencyRangesOpenFrequency_A22699.Value = value;
			}
		}

		// Token: 0x1700240B RID: 9227
		// (get) Token: 0x0600463A RID: 17978 RVA: 0x00412A08 File Offset: 0x00410C08
		// (set) Token: 0x0600463B RID: 17979 RVA: 0x00412ABC File Offset: 0x00410CBC
		public bool RadInfoFrequencyRangesOpenFrequency_A22699_Applicable
		{
			get
			{
				short num = (short)2014061347;
				short num2 = num;
				num = (short)713696035;
				switch (num2 == num)
				{
				}
				num = (short)2138701824;
				if (num != 0)
				{
				}
				num = (short)993198080;
				short num3 = num;
				num = (short)374013953;
				if (num != 0)
				{
				}
				return this.radInfoFrequencyRangesOpenFrequency_A22699.Applicable;
			}
			set
			{
				short num = (short)1061552129;
				if (num != 0)
				{
				}
				num = (short)21787562;
				short num2 = num;
				num = (short)1011446698;
				switch (num2 == num)
				{
				}
				num = (short)1203634176;
				short num3 = num;
				num = (short)1012006912;
				if (num != 0)
				{
				}
				this.radInfoFrequencyRangesOpenFrequency_A22699.Applicable = value;
			}
		}

		// Token: 0x1700240C RID: 9228
		// (get) Token: 0x0600463C RID: 17980 RVA: 0x00412B70 File Offset: 0x00410D70
		// (set) Token: 0x0600463D RID: 17981 RVA: 0x00412C24 File Offset: 0x00410E24
		public bool RadInfoFrequencyRangesOpenFrequency_A22699_Valid
		{
			get
			{
				short num = (short)227486032;
				short num2 = num;
				num = (short)1033578832;
				switch (num2 == num)
				{
				}
				num = (short)2040332288;
				if (num != 0)
				{
				}
				num = (short)1590951936;
				short num3 = num;
				num = (short)1825046529;
				if (num != 0)
				{
				}
				return this.radInfoFrequencyRangesOpenFrequency_A22699.Valid;
			}
			set
			{
				short num = (short)313393153;
				if (num != 0)
				{
				}
				num = (short)1944250063;
				short num2 = num;
				num = (short)2056382159;
				switch (num2 == num)
				{
				}
				num = (short)1261633536;
				short num3 = num;
				num = (short)405471232;
				if (num != 0)
				{
				}
				this.radInfoFrequencyRangesOpenFrequency_A22699.Valid = value;
			}
		}

		// Token: 0x1700240D RID: 9229
		// (get) Token: 0x0600463E RID: 17982 RVA: 0x00412CD8 File Offset: 0x00410ED8
		// (set) Token: 0x0600463F RID: 17983 RVA: 0x00412D90 File Offset: 0x00410F90
		public bool RadInfoFrequencyRangesOpenFrequency_A22699_Visible
		{
			get
			{
				short num = (short)691625361;
				short num2 = num;
				num = (short)1874550161;
				switch (num2 == num)
				{
				}
				num = (short)455868416;
				if (num != 0)
				{
				}
				num = (short)1479606272;
				short num3 = num;
				num = (short)812253185;
				if (num != 0)
				{
				}
				return this.radInfoFrequencyRangesOpenFrequency_A22699.Visible;
			}
			set
			{
				short num = (short)1799675038;
				short num2 = num;
				num = (short)445570206;
				switch (num2 == num)
				{
				}
				num = (short)2125987841;
				if (num != 0)
				{
				}
				num = (short)106233856;
				short num3 = num;
				num = (short)917700608;
				if (num != 0)
				{
				}
				this.radInfoFrequencyRangesOpenFrequency_A22699.Visible = value;
			}
		}

		// Token: 0x1700240E RID: 9230
		// (get) Token: 0x06004640 RID: 17984 RVA: 0x00412E48 File Offset: 0x00411048
		// (set) Token: 0x06004641 RID: 17985 RVA: 0x00412EFC File Offset: 0x004110FC
		public bool RadInfoFrequencyRangesOpenFrequency_A22699_Editable
		{
			get
			{
				short num = (short)1177559513;
				short num2 = num;
				num = (short)1947017689;
				switch (num2 == num)
				{
				}
				num = (short)1917714433;
				if (num != 0)
				{
				}
				num = (short)1595932672;
				short num3 = num;
				num = (short)2141585408;
				if (num != 0)
				{
				}
				return this.radInfoFrequencyRangesOpenFrequency_A22699.Editable;
			}
			set
			{
				short num = (short)1856322551;
				short num2 = num;
				num = (short)1637301239;
				switch (num2 == num)
				{
				}
				num = (short)1404043264;
				if (num != 0)
				{
				}
				num = (short)748355584;
				short num3 = num;
				num = (short)2083782657;
				if (num != 0)
				{
				}
				this.radInfoFrequencyRangesOpenFrequency_A22699.Editable = value;
			}
		}

		// Token: 0x1700240F RID: 9231
		// (get) Token: 0x06004642 RID: 17986 RVA: 0x00412FB4 File Offset: 0x004111B4
		internal string RadInfoFrequencyRangesOpenFrequency_A22699_UILabel
		{
			get
			{
				short num = (short)1035371289;
				short num2 = num;
				num = (short)1039041305;
				switch (num2 == num)
				{
				}
				num = (short)1198784513;
				if (num != 0)
				{
				}
				num = (short)712966144;
				short num3 = num;
				num = (short)637075456;
				if (num != 0)
				{
				}
				return this.radInfoFrequencyRangesOpenFrequency_A22699.UIName;
			}
		}

		// Token: 0x17002410 RID: 9232
		// (get) Token: 0x06004643 RID: 17987 RVA: 0x00413068 File Offset: 0x00411268
		// (set) Token: 0x06004644 RID: 17988 RVA: 0x0041311C File Offset: 0x0041131C
		internal bool RadInfoFrequencyRangesOpenFrequency_A22699_HiddenStatic
		{
			get
			{
				short num = (short)1810054646;
				short num2 = num;
				num = (short)835862006;
				switch (num2 == num)
				{
				}
				num = (short)926547969;
				if (num != 0)
				{
				}
				num = (short)93650944;
				short num3 = num;
				num = (short)237830144;
				if (num != 0)
				{
				}
				return this.radInfoFrequencyRangesOpenFrequency_A22699.HiddenStatic;
			}
			set
			{
				short num = (short)739260084;
				short num2 = num;
				num = (short)735786676;
				switch (num2 == num)
				{
				}
				num = (short)1223950337;
				if (num != 0)
				{
				}
				num = (short)1882980352;
				short num3 = num;
				num = (short)1560870912;
				if (num != 0)
				{
				}
				this.radInfoFrequencyRangesOpenFrequency_A22699.HiddenStatic = value;
			}
		}

		// Token: 0x17002411 RID: 9233
		// (get) Token: 0x06004645 RID: 17989 RVA: 0x004131D0 File Offset: 0x004113D0
		// (set) Token: 0x06004646 RID: 17990 RVA: 0x00413288 File Offset: 0x00411488
		internal bool RadInfoFrequencyRangesOpenFrequency_A22699_HiddenDynamic
		{
			get
			{
				short num = (short)229996499;
				short num2 = num;
				num = (short)2117695443;
				switch (num2 == num)
				{
				}
				num = (short)253558785;
				if (num != 0)
				{
				}
				num = (short)1038024704;
				short num3 = num;
				num = (short)623181824;
				if (num != 0)
				{
				}
				return this.radInfoFrequencyRangesOpenFrequency_A22699.HiddenDynamic;
			}
			set
			{
				short num = (short)1678966785;
				if (num != 0)
				{
				}
				num = (short)820884891;
				short num2 = num;
				num = (short)1036170651;
				switch (num2 == num)
				{
				}
				num = (short)325189632;
				short num3 = num;
				num = (short)956104704;
				if (num != 0)
				{
				}
				this.radInfoFrequencyRangesOpenFrequency_A22699.HiddenDynamic = value;
			}
		}

		// Token: 0x17002412 RID: 9234
		// (get) Token: 0x06004647 RID: 17991 RVA: 0x0041333C File Offset: 0x0041153C
		public bool RadInfoFrequencyRangesOpenFrequency_A22699_HasDiffs
		{
			get
			{
				short num = (short)2009595905;
				if (num != 0)
				{
				}
				num = (short)812658076;
				short num2 = num;
				num = (short)1047145884;
				switch (num2 == num)
				{
				}
				num = (short)2073427968;
				short num3 = num;
				num = (short)536739840;
				if (num != 0)
				{
				}
				return this.radInfoFrequencyRangesOpenFrequency_A22699._HasDiffs;
			}
		}

		// Token: 0x17002413 RID: 9235
		// (get) Token: 0x06004648 RID: 17992 RVA: 0x004133F0 File Offset: 0x004115F0
		// (set) Token: 0x06004649 RID: 17993 RVA: 0x004134A4 File Offset: 0x004116A4
		public bool RadInfoFrequencyRangesExtendedUHFR1Capable_A41443Value
		{
			get
			{
				short num = (short)546454799;
				short num2 = num;
				num = (short)573390095;
				switch (num2 == num)
				{
				}
				num = (short)1871052800;
				if (num != 0)
				{
				}
				num = (short)687603712;
				short num3 = num;
				num = (short)2140143617;
				if (num != 0)
				{
				}
				return this.radInfoFrequencyRangesExtendedUHFR1Capable_A41443.Value;
			}
			set
			{
				short num = (short)564953751;
				short num2 = num;
				num = (short)1786479255;
				switch (num2 == num)
				{
				}
				num = (short)511705089;
				if (num != 0)
				{
				}
				num = (short)1449984000;
				short num3 = num;
				num = (short)714342400;
				if (num != 0)
				{
				}
				this.radInfoFrequencyRangesExtendedUHFR1Capable_A41443.Value = value;
			}
		}

		// Token: 0x17002414 RID: 9236
		// (get) Token: 0x0600464A RID: 17994 RVA: 0x0041355C File Offset: 0x0041175C
		public global::AcpBusinessLayer.AcpField<bool> RadInfoFrequencyRangesExtendedUHFR1Capable_A41443
		{
			get
			{
				short num = (short)1672986814;
				short num2 = num;
				num = (short)337756350;
				switch (num2 == num)
				{
				}
				num = (short)950403073;
				if (num != 0)
				{
				}
				num = (short)2039152640;
				short num3 = num;
				num = (short)916193280;
				if (num != 0)
				{
				}
				return this.radInfoFrequencyRangesExtendedUHFR1Capable_A41443;
			}
		}

		// Token: 0x17002415 RID: 9237
		// (get) Token: 0x0600464B RID: 17995 RVA: 0x00413610 File Offset: 0x00411810
		// (set) Token: 0x0600464C RID: 17996 RVA: 0x004136C4 File Offset: 0x004118C4
		public bool RadInfoFrequencyRangesExtendedUHFR1Capable_A41443_UIValue
		{
			get
			{
				short num = (short)1048434556;
				short num2 = num;
				num = (short)726062972;
				switch (num2 == num)
				{
				}
				num = (short)1843855361;
				if (num != 0)
				{
				}
				num = (short)1885995008;
				short num3 = num;
				num = (short)772734976;
				if (num != 0)
				{
				}
				return this.radInfoFrequencyRangesExtendedUHFR1Capable_A41443.Value;
			}
			set
			{
				short num = (short)1130388956;
				short num2 = num;
				num = (short)1526226396;
				switch (num2 == num)
				{
				}
				num = (short)404422657;
				if (num != 0)
				{
				}
				num = (short)1244135424;
				short num3 = num;
				num = (short)73138176;
				if (num != 0)
				{
				}
				this.radInfoFrequencyRangesExtendedUHFR1Capable_A41443.Value = value;
			}
		}

		// Token: 0x17002416 RID: 9238
		// (get) Token: 0x0600464D RID: 17997 RVA: 0x00413778 File Offset: 0x00411978
		// (set) Token: 0x0600464E RID: 17998 RVA: 0x0041382C File Offset: 0x00411A2C
		public bool RadInfoFrequencyRangesExtendedUHFR1Capable_A41443_Applicable
		{
			get
			{
				short num = (short)464196027;
				short num2 = num;
				num = (short)692851131;
				switch (num2 == num)
				{
				}
				num = (short)1645608961;
				if (num != 0)
				{
				}
				num = (short)929759232;
				short num3 = num;
				num = (short)2045509632;
				if (num != 0)
				{
				}
				return this.radInfoFrequencyRangesExtendedUHFR1Capable_A41443.Applicable;
			}
			set
			{
				short num = (short)1164734699;
				short num2 = num;
				num = (short)223572203;
				switch (num2 == num)
				{
				}
				num = (short)198443009;
				if (num != 0)
				{
				}
				num = (short)1032323072;
				short num3 = num;
				num = (short)2087845888;
				if (num != 0)
				{
				}
				this.radInfoFrequencyRangesExtendedUHFR1Capable_A41443.Applicable = value;
			}
		}

		// Token: 0x17002417 RID: 9239
		// (get) Token: 0x0600464F RID: 17999 RVA: 0x004138E0 File Offset: 0x00411AE0
		// (set) Token: 0x06004650 RID: 18000 RVA: 0x00413994 File Offset: 0x00411B94
		public bool RadInfoFrequencyRangesExtendedUHFR1Capable_A41443_Valid
		{
			get
			{
				short num = (short)1027605541;
				short num2 = num;
				num = (short)173999141;
				switch (num2 == num)
				{
				}
				num = (short)2019622913;
				if (num != 0)
				{
				}
				num = (short)977928192;
				short num3 = num;
				num = (short)48693248;
				if (num != 0)
				{
				}
				return this.radInfoFrequencyRangesExtendedUHFR1Capable_A41443.Valid;
			}
			set
			{
				short num = (short)129460609;
				short num2 = num;
				num = (short)566389121;
				switch (num2 == num)
				{
				}
				num = (short)679739393;
				if (num != 0)
				{
				}
				num = (short)1789919232;
				short num3 = num;
				num = (short)1398931456;
				if (num != 0)
				{
				}
				this.radInfoFrequencyRangesExtendedUHFR1Capable_A41443.Valid = value;
			}
		}

		// Token: 0x17002418 RID: 9240
		// (get) Token: 0x06004651 RID: 18001 RVA: 0x00413A4C File Offset: 0x00411C4C
		// (set) Token: 0x06004652 RID: 18002 RVA: 0x00413B04 File Offset: 0x00411D04
		public bool RadInfoFrequencyRangesExtendedUHFR1Capable_A41443_Visible
		{
			get
			{
				short num = (short)169921475;
				short num2 = num;
				num = (short)371379139;
				switch (num2 == num)
				{
				}
				num = (short)74645505;
				if (num != 0)
				{
				}
				num = (short)1494155264;
				short num3 = num;
				num = (short)362020864;
				if (num != 0)
				{
				}
				return this.radInfoFrequencyRangesExtendedUHFR1Capable_A41443.Visible;
			}
			set
			{
				short num = (short)1985114589;
				short num2 = num;
				num = (short)30896605;
				switch (num2 == num)
				{
				}
				num = (short)53870593;
				if (num != 0)
				{
				}
				num = (short)361562112;
				short num3 = num;
				num = (short)636551168;
				if (num != 0)
				{
				}
				this.radInfoFrequencyRangesExtendedUHFR1Capable_A41443.Visible = value;
			}
		}

		// Token: 0x17002419 RID: 9241
		// (get) Token: 0x06004653 RID: 18003 RVA: 0x00413BB8 File Offset: 0x00411DB8
		// (set) Token: 0x06004654 RID: 18004 RVA: 0x00413C6C File Offset: 0x00411E6C
		public bool RadInfoFrequencyRangesExtendedUHFR1Capable_A41443_Editable
		{
			get
			{
				short num = (short)444605288;
				short num2 = num;
				num = (short)645014376;
				switch (num2 == num)
				{
				}
				num = (short)36306944;
				if (num != 0)
				{
				}
				num = (short)338100224;
				short num3 = num;
				num = (short)1331494913;
				if (num != 0)
				{
				}
				return this.radInfoFrequencyRangesExtendedUHFR1Capable_A41443.Editable;
			}
			set
			{
				short num = (short)1927860412;
				short num2 = num;
				num = (short)2110574780;
				switch (num2 == num)
				{
				}
				num = (short)1028587521;
				if (num != 0)
				{
				}
				num = (short)850395136;
				short num3 = num;
				num = (short)677117952;
				if (num != 0)
				{
				}
				this.radInfoFrequencyRangesExtendedUHFR1Capable_A41443.Editable = value;
			}
		}

		// Token: 0x1700241A RID: 9242
		// (get) Token: 0x06004655 RID: 18005 RVA: 0x00413D24 File Offset: 0x00411F24
		internal string RadInfoFrequencyRangesExtendedUHFR1Capable_A41443_UILabel
		{
			get
			{
				short num = (short)1976958977;
				if (num != 0)
				{
				}
				num = (short)811781738;
				short num2 = num;
				num = (short)2103889514;
				switch (num2 == num)
				{
				}
				num = (short)1156841472;
				short num3 = num;
				num = (short)1570963456;
				if (num != 0)
				{
				}
				return this.radInfoFrequencyRangesExtendedUHFR1Capable_A41443.UIName;
			}
		}

		// Token: 0x1700241B RID: 9243
		// (get) Token: 0x06004656 RID: 18006 RVA: 0x00413DDC File Offset: 0x00411FDC
		// (set) Token: 0x06004657 RID: 18007 RVA: 0x00413E94 File Offset: 0x00412094
		internal bool RadInfoFrequencyRangesExtendedUHFR1Capable_A41443_HiddenStatic
		{
			get
			{
				short num = (short)1317225089;
				short num2 = num;
				num = (short)155992705;
				switch (num2 == num)
				{
				}
				num = (short)1461714944;
				if (num != 0)
				{
				}
				num = (short)1590755328;
				short num3 = num;
				num = (short)1634467841;
				if (num != 0)
				{
				}
				return this.radInfoFrequencyRangesExtendedUHFR1Capable_A41443.HiddenStatic;
			}
			set
			{
				short num = (short)1687462500;
				short num2 = num;
				num = (short)1788715620;
				switch (num2 == num)
				{
				}
				num = (short)1510866945;
				if (num != 0)
				{
				}
				num = (short)1835466752;
				short num3 = num;
				num = (short)1395589120;
				if (num != 0)
				{
				}
				this.radInfoFrequencyRangesExtendedUHFR1Capable_A41443.HiddenStatic = value;
			}
		}

		// Token: 0x1700241C RID: 9244
		// (get) Token: 0x06004658 RID: 18008 RVA: 0x00413F4C File Offset: 0x0041214C
		// (set) Token: 0x06004659 RID: 18009 RVA: 0x00414000 File Offset: 0x00412200
		internal bool RadInfoFrequencyRangesExtendedUHFR1Capable_A41443_HiddenDynamic
		{
			get
			{
				short num = (short)1249416544;
				short num2 = num;
				num = (short)543331680;
				switch (num2 == num)
				{
				}
				num = (short)7274497;
				if (num != 0)
				{
				}
				num = (short)1143668736;
				short num3 = num;
				num = (short)1229127680;
				if (num != 0)
				{
				}
				return this.radInfoFrequencyRangesExtendedUHFR1Capable_A41443.HiddenDynamic;
			}
			set
			{
				short num = (short)660878290;
				short num2 = num;
				num = (short)706622418;
				switch (num2 == num)
				{
				}
				num = (short)332201985;
				if (num != 0)
				{
				}
				num = (short)739901440;
				short num3 = num;
				num = (short)227475456;
				if (num != 0)
				{
				}
				this.radInfoFrequencyRangesExtendedUHFR1Capable_A41443.HiddenDynamic = value;
			}
		}

		// Token: 0x1700241D RID: 9245
		// (get) Token: 0x0600465A RID: 18010 RVA: 0x004140B8 File Offset: 0x004122B8
		public bool RadInfoFrequencyRangesExtendedUHFR1Capable_A41443_HasDiffs
		{
			get
			{
				short num = (short)1403835590;
				short num2 = num;
				num = (short)2125452486;
				switch (num2 == num)
				{
				}
				num = (short)347406337;
				if (num != 0)
				{
				}
				num = (short)1518141440;
				short num3 = num;
				num = (short)1921843200;
				if (num != 0)
				{
				}
				return this.radInfoFrequencyRangesExtendedUHFR1Capable_A41443._HasDiffs;
			}
		}

		// Token: 0x1700241E RID: 9246
		// (get) Token: 0x0600465B RID: 18011 RVA: 0x0041416C File Offset: 0x0041236C
		// (set) Token: 0x0600465C RID: 18012 RVA: 0x00414220 File Offset: 0x00412420
		public bool RadInfoFrequencyRanges8900MHzUsedinCodeplug_A42502Value
		{
			get
			{
				short num = (short)1932156824;
				short num2 = num;
				num = (short)1915051928;
				switch (num2 == num)
				{
				}
				num = (short)1360527360;
				if (num != 0)
				{
				}
				num = (short)617545728;
				short num3 = num;
				num = (short)58261505;
				if (num != 0)
				{
				}
				return this.radInfoFrequencyRanges8900MHzUsedinCodeplug_A42502.Value;
			}
			set
			{
				short num = (short)1648536765;
				short num2 = num;
				num = (short)1527753917;
				switch (num2 == num)
				{
				}
				num = (short)1841299457;
				if (num != 0)
				{
				}
				num = (short)527171584;
				short num3 = num;
				num = (short)284688384;
				if (num != 0)
				{
				}
				this.radInfoFrequencyRanges8900MHzUsedinCodeplug_A42502.Value = value;
			}
		}

		// Token: 0x1700241F RID: 9247
		// (get) Token: 0x0600465D RID: 18013 RVA: 0x004142D8 File Offset: 0x004124D8
		public global::AcpBusinessLayer.AcpField<bool> RadInfoFrequencyRanges8900MHzUsedinCodeplug_A42502
		{
			get
			{
				short num = (short)919043885;
				short num2 = num;
				num = (short)456097581;
				switch (num2 == num)
				{
				}
				num = (short)685047808;
				if (num != 0)
				{
				}
				num = (short)733347840;
				short num3 = num;
				num = (short)1594621953;
				if (num != 0)
				{
				}
				return this.radInfoFrequencyRanges8900MHzUsedinCodeplug_A42502;
			}
		}

		// Token: 0x17002420 RID: 9248
		// (get) Token: 0x0600465E RID: 18014 RVA: 0x00414388 File Offset: 0x00412588
		// (set) Token: 0x0600465F RID: 18015 RVA: 0x0041443C File Offset: 0x0041263C
		public bool RadInfoFrequencyRanges8900MHzUsedinCodeplug_A42502_UIValue
		{
			get
			{
				short num = (short)770939009;
				short num2 = num;
				num = (short)1312266369;
				switch (num2 == num)
				{
				}
				num = (short)1858142208;
				if (num != 0)
				{
				}
				num = (short)1005518848;
				short num3 = num;
				num = (short)418250753;
				if (num != 0)
				{
				}
				return this.radInfoFrequencyRanges8900MHzUsedinCodeplug_A42502.Value;
			}
			set
			{
				short num = (short)1423330994;
				short num2 = num;
				num = (short)2124762802;
				switch (num2 == num)
				{
				}
				num = (short)158203904;
				if (num != 0)
				{
				}
				num = (short)871956480;
				short num3 = num;
				num = (short)1755709441;
				if (num != 0)
				{
				}
				this.radInfoFrequencyRanges8900MHzUsedinCodeplug_A42502.Value = value;
			}
		}

		// Token: 0x17002421 RID: 9249
		// (get) Token: 0x06004660 RID: 18016 RVA: 0x004144F4 File Offset: 0x004126F4
		// (set) Token: 0x06004661 RID: 18017 RVA: 0x004145A8 File Offset: 0x004127A8
		public bool RadInfoFrequencyRanges8900MHzUsedinCodeplug_A42502_Applicable
		{
			get
			{
				short num = (short)1096854467;
				short num2 = num;
				num = (short)1242737603;
				switch (num2 == num)
				{
				}
				num = (short)197787648;
				if (num != 0)
				{
				}
				num = (short)847970304;
				short num3 = num;
				num = (short)1555300353;
				if (num != 0)
				{
				}
				return this.radInfoFrequencyRanges8900MHzUsedinCodeplug_A42502.Applicable;
			}
			set
			{
				short num = (short)2046197743;
				short num2 = num;
				num = (short)1935376367;
				switch (num2 == num)
				{
				}
				num = (short)833028096;
				if (num != 0)
				{
				}
				num = (short)347865088;
				short num3 = num;
				num = (short)1045561345;
				if (num != 0)
				{
				}
				this.radInfoFrequencyRanges8900MHzUsedinCodeplug_A42502.Applicable = value;
			}
		}

		// Token: 0x17002422 RID: 9250
		// (get) Token: 0x06004662 RID: 18018 RVA: 0x00414660 File Offset: 0x00412860
		// (set) Token: 0x06004663 RID: 18019 RVA: 0x00414714 File Offset: 0x00412914
		public bool RadInfoFrequencyRanges8900MHzUsedinCodeplug_A42502_Valid
		{
			get
			{
				short num = (short)680525825;
				if (num != 0)
				{
				}
				num = (short)1948060153;
				short num2 = num;
				num = (short)2049772025;
				switch (num2 == num)
				{
				}
				num = (short)1097990144;
				short num3 = num;
				num = (short)819789824;
				if (num != 0)
				{
				}
				return this.radInfoFrequencyRanges8900MHzUsedinCodeplug_A42502.Valid;
			}
			set
			{
				short num = (short)1233911809;
				if (num != 0)
				{
				}
				num = (short)1897756715;
				short num2 = num;
				num = (short)644118571;
				switch (num2 == num)
				{
				}
				num = (short)174784512;
				short num3 = num;
				num = (short)381616128;
				if (num != 0)
				{
				}
				this.radInfoFrequencyRanges8900MHzUsedinCodeplug_A42502.Valid = value;
			}
		}

		// Token: 0x17002423 RID: 9251
		// (get) Token: 0x06004664 RID: 18020 RVA: 0x004147C8 File Offset: 0x004129C8
		// (set) Token: 0x06004665 RID: 18021 RVA: 0x00414880 File Offset: 0x00412A80
		public bool RadInfoFrequencyRanges8900MHzUsedinCodeplug_A42502_Visible
		{
			get
			{
				short num = (short)616291652;
				short num2 = num;
				num = (short)234085700;
				switch (num2 == num)
				{
				}
				num = (short)134348801;
				if (num != 0)
				{
				}
				num = (short)794427392;
				short num3 = num;
				num = (short)872022016;
				if (num != 0)
				{
				}
				return this.radInfoFrequencyRanges8900MHzUsedinCodeplug_A42502.Visible;
			}
			set
			{
				short num = (short)1127812529;
				short num2 = num;
				num = (short)801639857;
				switch (num2 == num)
				{
				}
				num = (short)1558970368;
				if (num != 0)
				{
				}
				num = (short)1331036160;
				short num3 = num;
				num = (short)865730561;
				if (num != 0)
				{
				}
				this.radInfoFrequencyRanges8900MHzUsedinCodeplug_A42502.Visible = value;
			}
		}

		// Token: 0x17002424 RID: 9252
		// (get) Token: 0x06004666 RID: 18022 RVA: 0x00414934 File Offset: 0x00412B34
		// (set) Token: 0x06004667 RID: 18023 RVA: 0x004149E8 File Offset: 0x00412BE8
		public bool RadInfoFrequencyRanges8900MHzUsedinCodeplug_A42502_Editable
		{
			get
			{
				short num = (short)957443034;
				short num2 = num;
				num = (short)1962372058;
				switch (num2 == num)
				{
				}
				num = (short)98893825;
				if (num != 0)
				{
				}
				num = (short)1026293760;
				short num3 = num;
				num = (short)570359808;
				if (num != 0)
				{
				}
				return this.radInfoFrequencyRanges8900MHzUsedinCodeplug_A42502.Editable;
			}
			set
			{
				short num = (short)908398144;
				short num2 = num;
				num = (short)1765150272;
				switch (num2 == num)
				{
				}
				num = (short)1763639297;
				if (num != 0)
				{
				}
				num = (short)116391936;
				short num3 = num;
				num = (short)907149312;
				if (num != 0)
				{
				}
				this.radInfoFrequencyRanges8900MHzUsedinCodeplug_A42502.Editable = value;
			}
		}

		// Token: 0x17002425 RID: 9253
		// (get) Token: 0x06004668 RID: 18024 RVA: 0x00414A9C File Offset: 0x00412C9C
		internal string RadInfoFrequencyRanges8900MHzUsedinCodeplug_A42502_UILabel
		{
			get
			{
				short num = (short)1954912237;
				short num2 = num;
				num = (short)230332397;
				switch (num2 == num)
				{
				}
				num = (short)1089929217;
				if (num != 0)
				{
				}
				num = (short)562954240;
				short num3 = num;
				num = (short)406978560;
				if (num != 0)
				{
				}
				return this.radInfoFrequencyRanges8900MHzUsedinCodeplug_A42502.UIName;
			}
		}

		// Token: 0x17002426 RID: 9254
		// (get) Token: 0x06004669 RID: 18025 RVA: 0x00414B50 File Offset: 0x00412D50
		// (set) Token: 0x0600466A RID: 18026 RVA: 0x00414C08 File Offset: 0x00412E08
		internal bool RadInfoFrequencyRanges8900MHzUsedinCodeplug_A42502_HiddenStatic
		{
			get
			{
				short num = (short)654057095;
				short num2 = num;
				num = (short)684138119;
				switch (num2 == num)
				{
				}
				num = (short)907542529;
				if (num != 0)
				{
				}
				num = (short)1088880640;
				short num3 = num;
				num = (short)2027487232;
				if (num != 0)
				{
				}
				return this.radInfoFrequencyRanges8900MHzUsedinCodeplug_A42502.HiddenStatic;
			}
			set
			{
				short num = (short)2061757231;
				short num2 = num;
				num = (short)397536047;
				switch (num2 == num)
				{
				}
				num = (short)1796014081;
				if (num != 0)
				{
				}
				num = (short)2141782016;
				short num3 = num;
				num = (short)1135673344;
				if (num != 0)
				{
				}
				this.radInfoFrequencyRanges8900MHzUsedinCodeplug_A42502.HiddenStatic = value;
			}
		}

		// Token: 0x17002427 RID: 9255
		// (get) Token: 0x0600466B RID: 18027 RVA: 0x00414CC0 File Offset: 0x00412EC0
		// (set) Token: 0x0600466C RID: 18028 RVA: 0x00414D74 File Offset: 0x00412F74
		internal bool RadInfoFrequencyRanges8900MHzUsedinCodeplug_A42502_HiddenDynamic
		{
			get
			{
				short num = (short)1471042831;
				short num2 = num;
				num = (short)1193825551;
				switch (num2 == num)
				{
				}
				num = (short)853671936;
				if (num != 0)
				{
				}
				num = (short)1588461568;
				short num3 = num;
				num = (short)612958209;
				if (num != 0)
				{
				}
				return this.radInfoFrequencyRanges8900MHzUsedinCodeplug_A42502.HiddenDynamic;
			}
			set
			{
				short num = (short)225978315;
				short num2 = num;
				num = (short)903096267;
				switch (num2 == num)
				{
				}
				num = (short)1758986241;
				if (num != 0)
				{
				}
				num = (short)58523648;
				short num3 = num;
				num = (short)2077491200;
				if (num != 0)
				{
				}
				this.radInfoFrequencyRanges8900MHzUsedinCodeplug_A42502.HiddenDynamic = value;
			}
		}

		// Token: 0x17002428 RID: 9256
		// (get) Token: 0x0600466D RID: 18029 RVA: 0x00414E28 File Offset: 0x00413028
		public bool RadInfoFrequencyRanges8900MHzUsedinCodeplug_A42502_HasDiffs
		{
			get
			{
				short num = (short)1534777130;
				short num2 = num;
				num = (short)1564333866;
				switch (num2 == num)
				{
				}
				num = (short)990380032;
				if (num != 0)
				{
				}
				num = (short)1841758208;
				short num3 = num;
				num = (short)131465217;
				if (num != 0)
				{
				}
				return this.radInfoFrequencyRanges8900MHzUsedinCodeplug_A42502._HasDiffs;
			}
		}

		// Token: 0x17002429 RID: 9257
		// (get) Token: 0x0600466E RID: 18030 RVA: 0x00414EDC File Offset: 0x004130DC
		// (set) Token: 0x0600466F RID: 18031 RVA: 0x00414F90 File Offset: 0x00413190
		public bool RadInfoFrequencyRanges700MHzUsedinCodeplug_A42551Value
		{
			get
			{
				short num = (short)1810235392;
				short num2 = num;
				num = (short)462585736;
				short num3 = num;
				num = (short)1578139528;
				switch (num3 == num)
				{
				}
				num = (short)1047592961;
				if (num != 0)
				{
				}
				num = (short)1779171328;
				if (num != 0)
				{
				}
				return this.radInfoFrequencyRanges700MHzUsedinCodeplug_A42551.Value;
			}
			set
			{
				short num = (short)1461583872;
				short num2 = num;
				num = (short)1948612964;
				short num3 = num;
				num = (short)783448420;
				switch (num3 == num)
				{
				}
				num = (short)641728512;
				if (num != 0)
				{
				}
				num = (short)1955332097;
				if (num != 0)
				{
				}
				this.radInfoFrequencyRanges700MHzUsedinCodeplug_A42551.Value = value;
			}
		}

		// Token: 0x1700242A RID: 9258
		// (get) Token: 0x06004670 RID: 18032 RVA: 0x00415044 File Offset: 0x00413244
		public global::AcpBusinessLayer.AcpField<bool> RadInfoFrequencyRanges700MHzUsedinCodeplug_A42551
		{
			get
			{
				short num = (short)1957429248;
				short num2 = num;
				num = (short)54780043;
				short num3 = num;
				num = (short)524738699;
				switch (num3 == num)
				{
				}
				num = (short)1532559360;
				if (num != 0)
				{
				}
				num = (short)848822273;
				if (num != 0)
				{
				}
				return this.radInfoFrequencyRanges700MHzUsedinCodeplug_A42551;
			}
		}

		// Token: 0x1700242B RID: 9259
		// (get) Token: 0x06004671 RID: 18033 RVA: 0x004150F4 File Offset: 0x004132F4
		// (set) Token: 0x06004672 RID: 18034 RVA: 0x004151A8 File Offset: 0x004133A8
		public bool RadInfoFrequencyRanges700MHzUsedinCodeplug_A42551_UIValue
		{
			get
			{
				short num = (short)951058432;
				short num2 = num;
				num = (short)1279663869;
				short num3 = num;
				num = (short)960044797;
				switch (num3 == num)
				{
				}
				num = (short)1303904256;
				if (num != 0)
				{
				}
				num = (short)1418723329;
				if (num != 0)
				{
				}
				return this.radInfoFrequencyRanges700MHzUsedinCodeplug_A42551.Value;
			}
			set
			{
				short num = (short)1879375872;
				short num2 = num;
				num = (short)788466216;
				short num3 = num;
				num = (short)1084688936;
				switch (num3 == num)
				{
				}
				num = (short)1733165057;
				if (num != 0)
				{
				}
				num = (short)477757440;
				if (num != 0)
				{
				}
				this.radInfoFrequencyRanges700MHzUsedinCodeplug_A42551.Value = value;
			}
		}

		// Token: 0x1700242C RID: 9260
		// (get) Token: 0x06004673 RID: 18035 RVA: 0x0041525C File Offset: 0x0041345C
		// (set) Token: 0x06004674 RID: 18036 RVA: 0x00415310 File Offset: 0x00413510
		public bool RadInfoFrequencyRanges700MHzUsedinCodeplug_A42551_Applicable
		{
			get
			{
				short num = (short)1581449216;
				short num2 = num;
				num = (short)1807703436;
				short num3 = num;
				num = (short)839146892;
				switch (num3 == num)
				{
				}
				num = (short)1897725953;
				if (num != 0)
				{
				}
				num = (short)1462435840;
				if (num != 0)
				{
				}
				return this.radInfoFrequencyRanges700MHzUsedinCodeplug_A42551.Applicable;
			}
			set
			{
				short num = (short)1525809152;
				short num2 = num;
				num = (short)874411249;
				short num3 = num;
				num = (short)2144040177;
				switch (num3 == num)
				{
				}
				num = (short)719454208;
				if (num != 0)
				{
				}
				num = (short)383713281;
				if (num != 0)
				{
				}
				this.radInfoFrequencyRanges700MHzUsedinCodeplug_A42551.Applicable = value;
			}
		}

		// Token: 0x1700242D RID: 9261
		// (get) Token: 0x06004675 RID: 18037 RVA: 0x004153C4 File Offset: 0x004135C4
		// (set) Token: 0x06004676 RID: 18038 RVA: 0x00415478 File Offset: 0x00413678
		public bool RadInfoFrequencyRanges700MHzUsedinCodeplug_A42551_Valid
		{
			get
			{
				short num = (short)43319296;
				short num2 = num;
				num = (short)1911765544;
				short num3 = num;
				num = (short)1985624616;
				switch (num3 == num)
				{
				}
				num = (short)719323137;
				if (num != 0)
				{
				}
				num = (short)942276608;
				if (num != 0)
				{
				}
				return this.radInfoFrequencyRanges700MHzUsedinCodeplug_A42551.Valid;
			}
			set
			{
				short num = (short)2101411840;
				short num2 = num;
				num = (short)574426082;
				short num3 = num;
				num = (short)928975842;
				switch (num3 == num)
				{
				}
				num = (short)1830223873;
				if (num != 0)
				{
				}
				num = (short)1099038720;
				if (num != 0)
				{
				}
				this.radInfoFrequencyRanges700MHzUsedinCodeplug_A42551.Valid = value;
			}
		}

		// Token: 0x1700242E RID: 9262
		// (get) Token: 0x06004677 RID: 18039 RVA: 0x0041552C File Offset: 0x0041372C
		// (set) Token: 0x06004678 RID: 18040 RVA: 0x004155E0 File Offset: 0x004137E0
		public bool RadInfoFrequencyRanges700MHzUsedinCodeplug_A42551_Visible
		{
			get
			{
				short num = (short)633602048;
				short num2 = num;
				num = (short)1802785646;
				short num3 = num;
				num = (short)241718126;
				switch (num3 == num)
				{
				}
				num = (short)1795227649;
				if (num != 0)
				{
				}
				num = (short)1082327040;
				if (num != 0)
				{
				}
				return this.radInfoFrequencyRanges700MHzUsedinCodeplug_A42551.Visible;
			}
			set
			{
				short num = (short)1510604800;
				short num2 = num;
				num = (short)480444417;
				if (num != 0)
				{
				}
				num = (short)564197750;
				short num3 = num;
				num = (short)1021770102;
				switch (num3 == num)
				{
				}
				num = (short)2123497472;
				if (num != 0)
				{
				}
				this.radInfoFrequencyRanges700MHzUsedinCodeplug_A42551.Visible = value;
			}
		}

		// Token: 0x1700242F RID: 9263
		// (get) Token: 0x06004679 RID: 18041 RVA: 0x00415694 File Offset: 0x00413894
		// (set) Token: 0x0600467A RID: 18042 RVA: 0x00415748 File Offset: 0x00413948
		public bool RadInfoFrequencyRanges700MHzUsedinCodeplug_A42551_Editable
		{
			get
			{
				short num = (short)298385408;
				short num2 = num;
				num = (short)306962612;
				short num3 = num;
				num = (short)1910825140;
				switch (num3 == num)
				{
				}
				num = (short)697761793;
				if (num != 0)
				{
				}
				num = (short)956628992;
				if (num != 0)
				{
				}
				return this.radInfoFrequencyRanges700MHzUsedinCodeplug_A42551.Editable;
			}
			set
			{
				short num = (short)860880896;
				short num2 = num;
				num = (short)2141431958;
				short num3 = num;
				num = (short)158509206;
				switch (num3 == num)
				{
				}
				num = (short)780730368;
				if (num != 0)
				{
				}
				num = (short)815267841;
				if (num != 0)
				{
				}
				this.radInfoFrequencyRanges700MHzUsedinCodeplug_A42551.Editable = value;
			}
		}

		// Token: 0x17002430 RID: 9264
		// (get) Token: 0x0600467B RID: 18043 RVA: 0x004157FC File Offset: 0x004139FC
		internal string RadInfoFrequencyRanges700MHzUsedinCodeplug_A42551_UILabel
		{
			get
			{
				short num = (short)1555824640;
				short num2 = num;
				num = (short)497156097;
				if (num != 0)
				{
				}
				num = (short)1345061602;
				short num3 = num;
				num = (short)2133132002;
				switch (num3 == num)
				{
				}
				num = (short)1520107520;
				if (num != 0)
				{
				}
				return this.radInfoFrequencyRanges700MHzUsedinCodeplug_A42551.UIName;
			}
		}

		// Token: 0x17002431 RID: 9265
		// (get) Token: 0x0600467C RID: 18044 RVA: 0x004158B0 File Offset: 0x00413AB0
		// (set) Token: 0x0600467D RID: 18045 RVA: 0x00415964 File Offset: 0x00413B64
		internal bool RadInfoFrequencyRanges700MHzUsedinCodeplug_A42551_HiddenStatic
		{
			get
			{
				short num = (short)1469513728;
				short num2 = num;
				num = (short)959357709;
				short num3 = num;
				num = (short)2035589901;
				switch (num3 == num)
				{
				}
				num = (short)1556086785;
				if (num != 0)
				{
				}
				num = (short)365625344;
				if (num != 0)
				{
				}
				return this.radInfoFrequencyRanges700MHzUsedinCodeplug_A42551.HiddenStatic;
			}
			set
			{
				short num = (short)1716453376;
				short num2 = num;
				num = (short)1884815361;
				if (num != 0)
				{
				}
				num = (short)2063619587;
				short num3 = num;
				num = (short)912152067;
				switch (num3 == num)
				{
				}
				num = (short)20905984;
				if (num != 0)
				{
				}
				this.radInfoFrequencyRanges700MHzUsedinCodeplug_A42551.HiddenStatic = value;
			}
		}

		// Token: 0x17002432 RID: 9266
		// (get) Token: 0x0600467E RID: 18046 RVA: 0x00415A1C File Offset: 0x00413C1C
		// (set) Token: 0x0600467F RID: 18047 RVA: 0x00415AD0 File Offset: 0x00413CD0
		internal bool RadInfoFrequencyRanges700MHzUsedinCodeplug_A42551_HiddenDynamic
		{
			get
			{
				short num = (short)733282304;
				short num2 = num;
				num = (short)1756987614;
				short num3 = num;
				num = (short)497778910;
				switch (num3 == num)
				{
				}
				num = (short)895352832;
				if (num != 0)
				{
				}
				num = (short)416677889;
				if (num != 0)
				{
				}
				return this.radInfoFrequencyRanges700MHzUsedinCodeplug_A42551.HiddenDynamic;
			}
			set
			{
				short num = (short)730464256;
				short num2 = num;
				num = (short)1597292002;
				short num3 = num;
				num = (short)860995042;
				switch (num3 == num)
				{
				}
				num = (short)1137442816;
				if (num != 0)
				{
				}
				num = (short)538705921;
				if (num != 0)
				{
				}
				this.radInfoFrequencyRanges700MHzUsedinCodeplug_A42551.HiddenDynamic = value;
			}
		}

		// Token: 0x17002433 RID: 9267
		// (get) Token: 0x06004680 RID: 18048 RVA: 0x00415B88 File Offset: 0x00413D88
		public bool RadInfoFrequencyRanges700MHzUsedinCodeplug_A42551_HasDiffs
		{
			get
			{
				short num = (short)1309147136;
				short num2 = num;
				num = (short)2101471766;
				short num3 = num;
				num = (short)524937750;
				switch (num3 == num)
				{
				}
				num = (short)1362821121;
				if (num != 0)
				{
				}
				num = (short)1325858816;
				if (num != 0)
				{
				}
				return this.radInfoFrequencyRanges700MHzUsedinCodeplug_A42551._HasDiffs;
			}
		}

		// Token: 0x17002434 RID: 9268
		// (get) Token: 0x06004681 RID: 18049 RVA: 0x00415C3C File Offset: 0x00413E3C
		// (set) Token: 0x06004682 RID: 18050 RVA: 0x00415CF0 File Offset: 0x00413EF0
		public bool RadInfoFrequencyRanges800MHzUsedinCodeplug_A42552Value
		{
			get
			{
				short num = (short)83886080;
				short num2 = num;
				num = (short)16347660;
				short num3 = num;
				num = (short)2034528780;
				switch (num3 == num)
				{
				}
				num = (short)1055391744;
				if (num != 0)
				{
				}
				num = (short)1962082305;
				if (num != 0)
				{
				}
				return this.radInfoFrequencyRanges800MHzUsedinCodeplug_A42552.Value;
			}
			set
			{
				short num = (short)299237376;
				short num2 = num;
				num = (short)856894392;
				short num3 = num;
				num = (short)1219439544;
				switch (num3 == num)
				{
				}
				num = (short)460652545;
				if (num != 0)
				{
				}
				num = (short)1037500416;
				if (num != 0)
				{
				}
				this.radInfoFrequencyRanges800MHzUsedinCodeplug_A42552.Value = value;
			}
		}

		// Token: 0x17002435 RID: 9269
		// (get) Token: 0x06004683 RID: 18051 RVA: 0x00415DA4 File Offset: 0x00413FA4
		public global::AcpBusinessLayer.AcpField<bool> RadInfoFrequencyRanges800MHzUsedinCodeplug_A42552
		{
			get
			{
				short num = (short)1313472512;
				short num2 = num;
				num = (short)1709366765;
				short num3 = num;
				num = (short)615243245;
				switch (num3 == num)
				{
				}
				num = (short)1954414593;
				if (num != 0)
				{
				}
				num = (short)707461120;
				if (num != 0)
				{
				}
				return this.radInfoFrequencyRanges800MHzUsedinCodeplug_A42552;
			}
		}

		// Token: 0x17002436 RID: 9270
		// (get) Token: 0x06004684 RID: 18052 RVA: 0x00415E54 File Offset: 0x00414054
		// (set) Token: 0x06004685 RID: 18053 RVA: 0x00415F08 File Offset: 0x00414108
		public bool RadInfoFrequencyRanges800MHzUsedinCodeplug_A42552_UIValue
		{
			get
			{
				short num = (short)634716160;
				short num2 = num;
				num = (short)458295233;
				short num3 = num;
				num = (short)1394935745;
				switch (num3 == num)
				{
				}
				num = (short)142082049;
				if (num != 0)
				{
				}
				num = (short)2035810304;
				if (num != 0)
				{
				}
				return this.radInfoFrequencyRanges800MHzUsedinCodeplug_A42552.Value;
			}
			set
			{
				short num = (short)201719808;
				short num2 = num;
				num = (short)713816256;
				short num3 = num;
				num = (short)1613887680;
				switch (num3 == num)
				{
				}
				num = (short)1194524673;
				if (num != 0)
				{
				}
				num = (short)1167982592;
				if (num != 0)
				{
				}
				this.radInfoFrequencyRanges800MHzUsedinCodeplug_A42552.Value = value;
			}
		}

		// Token: 0x17002437 RID: 9271
		// (get) Token: 0x06004686 RID: 18054 RVA: 0x00415FC0 File Offset: 0x004141C0
		// (set) Token: 0x06004687 RID: 18055 RVA: 0x00416074 File Offset: 0x00414274
		public bool RadInfoFrequencyRanges800MHzUsedinCodeplug_A42552_Applicable
		{
			get
			{
				short num = (short)1091698688;
				short num2 = num;
				num = (short)1989869569;
				if (num != 0)
				{
				}
				num = (short)775628513;
				short num3 = num;
				num = (short)1657743073;
				switch (num3 == num)
				{
				}
				num = (short)1533083648;
				if (num != 0)
				{
				}
				return this.radInfoFrequencyRanges800MHzUsedinCodeplug_A42552.Applicable;
			}
			set
			{
				short num = (short)1605435392;
				short num2 = num;
				num = (short)284842959;
				short num3 = num;
				num = (short)262298575;
				switch (num3 == num)
				{
				}
				num = (short)764608512;
				if (num != 0)
				{
				}
				num = (short)1545011201;
				if (num != 0)
				{
				}
				this.radInfoFrequencyRanges800MHzUsedinCodeplug_A42552.Applicable = value;
			}
		}

		// Token: 0x17002438 RID: 9272
		// (get) Token: 0x06004688 RID: 18056 RVA: 0x0041612C File Offset: 0x0041432C
		// (set) Token: 0x06004689 RID: 18057 RVA: 0x004161E0 File Offset: 0x004143E0
		public bool RadInfoFrequencyRanges800MHzUsedinCodeplug_A42552_Valid
		{
			get
			{
				short num = (short)1918828544;
				short num2 = num;
				num = (short)1438998505;
				short num3 = num;
				num = (short)1876451305;
				switch (num3 == num)
				{
				}
				num = (short)1645608960;
				if (num != 0)
				{
				}
				num = (short)564199425;
				if (num != 0)
				{
				}
				return this.radInfoFrequencyRanges800MHzUsedinCodeplug_A42552.Valid;
			}
			set
			{
				short num = (short)347865088;
				short num2 = num;
				num = (short)1320641436;
				short num3 = num;
				num = (short)2055496604;
				switch (num3 == num)
				{
				}
				num = (short)570884096;
				if (num != 0)
				{
				}
				num = (short)1634861057;
				if (num != 0)
				{
				}
				this.radInfoFrequencyRanges800MHzUsedinCodeplug_A42552.Valid = value;
			}
		}

		// Token: 0x17002439 RID: 9273
		// (get) Token: 0x0600468A RID: 18058 RVA: 0x00416298 File Offset: 0x00414498
		// (set) Token: 0x0600468B RID: 18059 RVA: 0x0041634C File Offset: 0x0041454C
		public bool RadInfoFrequencyRanges800MHzUsedinCodeplug_A42552_Visible
		{
			get
			{
				short num = (short)902692864;
				short num2 = num;
				num = (short)1520601979;
				short num3 = num;
				num = (short)290884475;
				switch (num3 == num)
				{
				}
				num = (short)614531073;
				if (num != 0)
				{
				}
				num = (short)316145664;
				if (num != 0)
				{
				}
				return this.radInfoFrequencyRanges800MHzUsedinCodeplug_A42552.Visible;
			}
			set
			{
				short num = (short)147128320;
				short num2 = num;
				num = (short)723890740;
				short num3 = num;
				num = (short)2063512116;
				switch (num3 == num)
				{
				}
				num = (short)1465909248;
				if (num != 0)
				{
				}
				num = (short)1610678273;
				if (num != 0)
				{
				}
				this.radInfoFrequencyRanges800MHzUsedinCodeplug_A42552.Visible = value;
			}
		}

		// Token: 0x1700243A RID: 9274
		// (get) Token: 0x0600468C RID: 18060 RVA: 0x00416404 File Offset: 0x00414604
		// (set) Token: 0x0600468D RID: 18061 RVA: 0x004164BC File Offset: 0x004146BC
		public bool RadInfoFrequencyRanges800MHzUsedinCodeplug_A42552_Editable
		{
			get
			{
				short num = (short)392495104;
				short num2 = num;
				num = (short)1644225339;
				short num3 = num;
				num = (short)320201531;
				switch (num3 == num)
				{
				}
				num = (short)390856704;
				if (num != 0)
				{
				}
				num = (short)1466236929;
				if (num != 0)
				{
				}
				return this.radInfoFrequencyRanges800MHzUsedinCodeplug_A42552.Editable;
			}
			set
			{
				short num = (short)1429929984;
				short num2 = num;
				num = (short)936111473;
				short num3 = num;
				num = (short)375516529;
				switch (num3 == num)
				{
				}
				num = (short)1372323840;
				if (num != 0)
				{
				}
				num = (short)310181889;
				if (num != 0)
				{
				}
				this.radInfoFrequencyRanges800MHzUsedinCodeplug_A42552.Editable = value;
			}
		}

		// Token: 0x1700243B RID: 9275
		// (get) Token: 0x0600468E RID: 18062 RVA: 0x00416570 File Offset: 0x00414770
		internal string RadInfoFrequencyRanges800MHzUsedinCodeplug_A42552_UILabel
		{
			get
			{
				short num = (short)1319698432;
				short num2 = num;
				num = (short)570587800;
				short num3 = num;
				num = (short)435583640;
				switch (num3 == num)
				{
				}
				num = (short)1533018113;
				if (num != 0)
				{
				}
				num = (short)1016791040;
				if (num != 0)
				{
				}
				return this.radInfoFrequencyRanges800MHzUsedinCodeplug_A42552.UIName;
			}
		}

		// Token: 0x1700243C RID: 9276
		// (get) Token: 0x0600468F RID: 18063 RVA: 0x00416628 File Offset: 0x00414828
		// (set) Token: 0x06004690 RID: 18064 RVA: 0x004166DC File Offset: 0x004148DC
		internal bool RadInfoFrequencyRanges800MHzUsedinCodeplug_A42552_HiddenStatic
		{
			get
			{
				short num = (short)1001652224;
				short num2 = num;
				num = (short)580828725;
				short num3 = num;
				num = (short)1641266741;
				switch (num3 == num)
				{
				}
				num = (short)551747584;
				if (num != 0)
				{
				}
				num = (short)98107393;
				if (num != 0)
				{
				}
				return this.radInfoFrequencyRanges800MHzUsedinCodeplug_A42552.HiddenStatic;
			}
			set
			{
				short num = (short)1820065792;
				short num2 = num;
				num = (short)2046145610;
				short num3 = num;
				num = (short)156349514;
				switch (num3 == num)
				{
				}
				num = (short)831913985;
				if (num != 0)
				{
				}
				num = (short)1441792;
				if (num != 0)
				{
				}
				this.radInfoFrequencyRanges800MHzUsedinCodeplug_A42552.HiddenStatic = value;
			}
		}

		// Token: 0x1700243D RID: 9277
		// (get) Token: 0x06004691 RID: 18065 RVA: 0x00416794 File Offset: 0x00414994
		// (set) Token: 0x06004692 RID: 18066 RVA: 0x00416848 File Offset: 0x00414A48
		internal bool RadInfoFrequencyRanges800MHzUsedinCodeplug_A42552_HiddenDynamic
		{
			get
			{
				short num = (short)1261502464;
				short num2 = num;
				num = (short)471358305;
				short num3 = num;
				num = (short)761551713;
				switch (num3 == num)
				{
				}
				num = (short)2110586881;
				if (num != 0)
				{
				}
				num = (short)1526988800;
				if (num != 0)
				{
				}
				return this.radInfoFrequencyRanges800MHzUsedinCodeplug_A42552.HiddenDynamic;
			}
			set
			{
				short num = (short)367132672;
				short num2 = num;
				num = (short)188579597;
				short num3 = num;
				num = (short)1675525901;
				switch (num3 == num)
				{
				}
				num = (short)564854785;
				if (num != 0)
				{
				}
				num = (short)805371904;
				if (num != 0)
				{
				}
				this.radInfoFrequencyRanges800MHzUsedinCodeplug_A42552.HiddenDynamic = value;
			}
		}

		// Token: 0x1700243E RID: 9278
		// (get) Token: 0x06004693 RID: 18067 RVA: 0x00416900 File Offset: 0x00414B00
		public bool RadInfoFrequencyRanges800MHzUsedinCodeplug_A42552_HasDiffs
		{
			get
			{
				short num = (short)1704329216;
				short num2 = num;
				num = (short)1032555967;
				short num3 = num;
				num = (short)1266126271;
				switch (num3 == num)
				{
				}
				num = (short)461307905;
				if (num != 0)
				{
				}
				num = (short)1975517184;
				if (num != 0)
				{
				}
				return this.radInfoFrequencyRanges800MHzUsedinCodeplug_A42552._HasDiffs;
			}
		}

		// Token: 0x1700243F RID: 9279
		// (get) Token: 0x06004694 RID: 18068 RVA: 0x004169B4 File Offset: 0x00414BB4
		// (set) Token: 0x06004695 RID: 18069 RVA: 0x00416A68 File Offset: 0x00414C68
		public bool RadInfoFrequencyRangesExtendRange762Capable_A43555Value
		{
			get
			{
				short num = (short)2099052544;
				short num2 = num;
				num = (short)474969348;
				short num3 = num;
				num = (short)219182340;
				switch (num3 == num)
				{
				}
				num = (short)396296193;
				if (num != 0)
				{
				}
				num = (short)1620639744;
				if (num != 0)
				{
				}
				return this.radInfoFrequencyRangesExtendRange762Capable_A43555.Value;
			}
			set
			{
				short num = (short)1265172480;
				short num2 = num;
				num = (short)240466677;
				short num3 = num;
				num = (short)971913973;
				switch (num3 == num)
				{
				}
				num = (short)271908865;
				if (num != 0)
				{
				}
				num = (short)1734344704;
				if (num != 0)
				{
				}
				this.radInfoFrequencyRangesExtendRange762Capable_A43555.Value = value;
			}
		}

		// Token: 0x17002440 RID: 9280
		// (get) Token: 0x06004696 RID: 18070 RVA: 0x00416B20 File Offset: 0x00414D20
		public global::AcpBusinessLayer.AcpField<bool> RadInfoFrequencyRangesExtendRange762Capable_A43555
		{
			get
			{
				short num = (short)99211712;
				short num2 = num;
				num = (short)1921046976;
				switch (num2 == num)
				{
				}
				num = (short)1932197888;
				if (num != 0)
				{
				}
				num = (short)1703804929;
				if (num != 0)
				{
				}
				num = (short)72548352;
				short num3 = num;
				return this.radInfoFrequencyRangesExtendRange762Capable_A43555;
			}
		}

		// Token: 0x17002441 RID: 9281
		// (get) Token: 0x06004697 RID: 18071 RVA: 0x00416BD0 File Offset: 0x00414DD0
		// (set) Token: 0x06004698 RID: 18072 RVA: 0x00416C88 File Offset: 0x00414E88
		public bool RadInfoFrequencyRangesExtendRange762Capable_A43555_UIValue
		{
			get
			{
				short num = (short)1636069786;
				short num2 = num;
				num = (short)64582042;
				switch (num2 == num)
				{
				}
				num = (short)1535377409;
				if (num != 0)
				{
				}
				num = (short)1324154880;
				if (num != 0)
				{
				}
				num = (short)1017774080;
				short num3 = num;
				return this.radInfoFrequencyRangesExtendRange762Capable_A43555.Value;
			}
			set
			{
				short num = (short)2045867021;
				short num2 = num;
				num = (short)1993569293;
				switch (num2 == num)
				{
				}
				num = (short)669057025;
				if (num != 0)
				{
				}
				num = (short)2131099648;
				if (num != 0)
				{
				}
				num = (short)1212678144;
				short num3 = num;
				this.radInfoFrequencyRangesExtendRange762Capable_A43555.Value = value;
			}
		}

		// Token: 0x17002442 RID: 9282
		// (get) Token: 0x06004699 RID: 18073 RVA: 0x00416D3C File Offset: 0x00414F3C
		// (set) Token: 0x0600469A RID: 18074 RVA: 0x00416DF0 File Offset: 0x00414FF0
		public bool RadInfoFrequencyRangesExtendRange762Capable_A43555_Applicable
		{
			get
			{
				short num = (short)1498789515;
				short num2 = num;
				num = (short)2074916491;
				switch (num2 == num)
				{
				}
				num = (short)982515712;
				if (num != 0)
				{
				}
				num = (short)1263534081;
				if (num != 0)
				{
				}
				num = (short)873791488;
				short num3 = num;
				return this.radInfoFrequencyRangesExtendRange762Capable_A43555.Applicable;
			}
			set
			{
				short num = (short)77135873;
				if (num != 0)
				{
				}
				num = (short)1103265460;
				short num2 = num;
				num = (short)940736180;
				switch (num2 == num)
				{
				}
				num = (short)588185600;
				if (num != 0)
				{
				}
				num = (short)1106968576;
				short num3 = num;
				this.radInfoFrequencyRangesExtendRange762Capable_A43555.Applicable = value;
			}
		}

		// Token: 0x17002443 RID: 9283
		// (get) Token: 0x0600469B RID: 18075 RVA: 0x00416EA4 File Offset: 0x004150A4
		// (set) Token: 0x0600469C RID: 18076 RVA: 0x00416F58 File Offset: 0x00415158
		public bool RadInfoFrequencyRangesExtendRange762Capable_A43555_Valid
		{
			get
			{
				short num = (short)1355480207;
				short num2 = num;
				num = (short)405339279;
				switch (num2 == num)
				{
				}
				num = (short)2088173568;
				if (num != 0)
				{
				}
				num = (short)1676804097;
				if (num != 0)
				{
				}
				num = (short)1818689536;
				short num3 = num;
				return this.radInfoFrequencyRangesExtendRange762Capable_A43555.Valid;
			}
			set
			{
				short num = (short)730490139;
				short num2 = num;
				num = (short)572679451;
				switch (num2 == num)
				{
				}
				num = (short)350093312;
				if (num != 0)
				{
				}
				num = (short)164560897;
				if (num != 0)
				{
				}
				num = (short)1275592704;
				short num3 = num;
				this.radInfoFrequencyRangesExtendRange762Capable_A43555.Valid = value;
			}
		}

		// Token: 0x17002444 RID: 9284
		// (get) Token: 0x0600469D RID: 18077 RVA: 0x0041700C File Offset: 0x0041520C
		// (set) Token: 0x0600469E RID: 18078 RVA: 0x004170C0 File Offset: 0x004152C0
		public bool RadInfoFrequencyRangesExtendRange762Capable_A43555_Visible
		{
			get
			{
				short num = (short)393373944;
				short num2 = num;
				num = (short)1124428024;
				switch (num2 == num)
				{
				}
				num = (short)479068161;
				if (num != 0)
				{
				}
				num = (short)284753920;
				if (num != 0)
				{
				}
				num = (short)435814400;
				short num3 = num;
				return this.radInfoFrequencyRangesExtendRange762Capable_A43555.Visible;
			}
			set
			{
				short num = (short)984481793;
				if (num != 0)
				{
				}
				num = (short)650144563;
				short num2 = num;
				num = (short)1116695347;
				switch (num2 == num)
				{
				}
				num = (short)72548352;
				if (num != 0)
				{
				}
				num = (short)105512960;
				short num3 = num;
				this.radInfoFrequencyRangesExtendRange762Capable_A43555.Visible = value;
			}
		}

		// Token: 0x17002445 RID: 9285
		// (get) Token: 0x0600469F RID: 18079 RVA: 0x00417174 File Offset: 0x00415374
		// (set) Token: 0x060046A0 RID: 18080 RVA: 0x00417228 File Offset: 0x00415428
		public bool RadInfoFrequencyRangesExtendRange762Capable_A43555_Editable
		{
			get
			{
				short num = (short)380912106;
				short num2 = num;
				num = (short)12403178;
				switch (num2 == num)
				{
				}
				num = (short)1162412033;
				if (num != 0)
				{
				}
				num = (short)246611968;
				if (num != 0)
				{
				}
				num = (short)1565655040;
				short num3 = num;
				return this.radInfoFrequencyRangesExtendRange762Capable_A43555.Editable;
			}
			set
			{
				short num = (short)767860137;
				short num2 = num;
				num = (short)562142633;
				switch (num2 == num)
				{
				}
				num = (short)389873664;
				if (num != 0)
				{
				}
				num = (short)1171783681;
				if (num != 0)
				{
				}
				num = (short)1149698048;
				short num3 = num;
				this.radInfoFrequencyRangesExtendRange762Capable_A43555.Editable = value;
			}
		}

		// Token: 0x17002446 RID: 9286
		// (get) Token: 0x060046A1 RID: 18081 RVA: 0x004172E0 File Offset: 0x004154E0
		internal string RadInfoFrequencyRangesExtendRange762Capable_A43555_UILabel
		{
			get
			{
				short num = (short)836971852;
				short num2 = num;
				num = (short)486026572;
				switch (num2 == num)
				{
				}
				num = (short)639434753;
				if (num != 0)
				{
				}
				num = (short)1166671872;
				if (num != 0)
				{
				}
				num = (short)2097938432;
				short num3 = num;
				return this.radInfoFrequencyRangesExtendRange762Capable_A43555.UIName;
			}
		}

		// Token: 0x17002447 RID: 9287
		// (get) Token: 0x060046A2 RID: 18082 RVA: 0x00417398 File Offset: 0x00415598
		// (set) Token: 0x060046A3 RID: 18083 RVA: 0x0041744C File Offset: 0x0041564C
		internal bool RadInfoFrequencyRangesExtendRange762Capable_A43555_HiddenStatic
		{
			get
			{
				short num = (short)310405880;
				short num2 = num;
				num = (short)1367042808;
				switch (num2 == num)
				{
				}
				num = (short)1335820289;
				if (num != 0)
				{
				}
				num = (short)379060224;
				if (num != 0)
				{
				}
				num = (short)1903362048;
				short num3 = num;
				return this.radInfoFrequencyRangesExtendRange762Capable_A43555.HiddenStatic;
			}
			set
			{
				short num = (short)373339583;
				short num2 = num;
				num = (short)1642706367;
				switch (num2 == num)
				{
				}
				num = (short)672268288;
				if (num != 0)
				{
				}
				num = (short)906297345;
				if (num != 0)
				{
				}
				num = (short)372375552;
				short num3 = num;
				this.radInfoFrequencyRangesExtendRange762Capable_A43555.HiddenStatic = value;
			}
		}

		// Token: 0x17002448 RID: 9288
		// (get) Token: 0x060046A4 RID: 18084 RVA: 0x00417504 File Offset: 0x00415704
		// (set) Token: 0x060046A5 RID: 18085 RVA: 0x004175BC File Offset: 0x004157BC
		internal bool RadInfoFrequencyRangesExtendRange762Capable_A43555_HiddenDynamic
		{
			get
			{
				short num = (short)2001906545;
				short num2 = num;
				num = (short)1227336561;
				switch (num2 == num)
				{
				}
				num = (short)1359478785;
				if (num != 0)
				{
				}
				num = (short)1000996864;
				if (num != 0)
				{
				}
				num = (short)1317797888;
				short num3 = num;
				return this.radInfoFrequencyRangesExtendRange762Capable_A43555.HiddenDynamic;
			}
			set
			{
				short num = (short)773759387;
				short num2 = num;
				num = (short)326017435;
				switch (num2 == num)
				{
				}
				num = (short)865206272;
				if (num != 0)
				{
				}
				num = (short)1724448769;
				if (num != 0)
				{
				}
				num = (short)1465188352;
				short num3 = num;
				this.radInfoFrequencyRangesExtendRange762Capable_A43555.HiddenDynamic = value;
			}
		}

		// Token: 0x17002449 RID: 9289
		// (get) Token: 0x060046A6 RID: 18086 RVA: 0x00417670 File Offset: 0x00415870
		public bool RadInfoFrequencyRangesExtendRange762Capable_A43555_HasDiffs
		{
			get
			{
				short num = (short)2076537250;
				short num2 = num;
				num = (short)834302370;
				switch (num2 == num)
				{
				}
				num = (short)1709834241;
				if (num != 0)
				{
				}
				num = (short)1292894208;
				if (num != 0)
				{
				}
				num = (short)1788805120;
				short num3 = num;
				return this.radInfoFrequencyRangesExtendRange762Capable_A43555._HasDiffs;
			}
		}

		// Token: 0x1700244A RID: 9290
		// (get) Token: 0x060046A7 RID: 18087 RVA: 0x00417728 File Offset: 0x00415928
		// (set) Token: 0x060046A8 RID: 18088 RVA: 0x004177DC File Offset: 0x004159DC
		public bool RadInfoFrequencyRangesUHFR1480MHzHoptinEnabled_A43575Value
		{
			get
			{
				short num = (short)359000011;
				short num2 = num;
				num = (short)796846027;
				switch (num2 == num)
				{
				}
				num = (short)666042369;
				if (num != 0)
				{
				}
				num = (short)1288830976;
				if (num != 0)
				{
				}
				num = (short)1132789760;
				short num3 = num;
				return this.radInfoFrequencyRangesUHFR1480MHzHoptinEnabled_A43575.Value;
			}
			set
			{
				short num = (short)805500956;
				short num2 = num;
				num = (short)1057355804;
				switch (num2 == num)
				{
				}
				num = (short)2002845697;
				if (num != 0)
				{
				}
				num = (short)919666688;
				if (num != 0)
				{
				}
				num = (short)291569664;
				short num3 = num;
				this.radInfoFrequencyRangesUHFR1480MHzHoptinEnabled_A43575.Value = value;
			}
		}

		// Token: 0x1700244B RID: 9291
		// (get) Token: 0x060046A9 RID: 18089 RVA: 0x00417894 File Offset: 0x00415A94
		public global::AcpBusinessLayer.AcpField<bool> RadInfoFrequencyRangesUHFR1480MHzHoptinEnabled_A43575
		{
			get
			{
				short num = (short)1985130073;
				short num2 = num;
				num = (short)1900785241;
				switch (num2 == num)
				{
				}
				num = (short)108986369;
				if (num != 0)
				{
				}
				num = (short)95551488;
				if (num != 0)
				{
				}
				num = (short)821428224;
				short num3 = num;
				return this.radInfoFrequencyRangesUHFR1480MHzHoptinEnabled_A43575;
			}
		}

		// Token: 0x1700244C RID: 9292
		// (get) Token: 0x060046AA RID: 18090 RVA: 0x00417944 File Offset: 0x00415B44
		// (set) Token: 0x060046AB RID: 18091 RVA: 0x004179FC File Offset: 0x00415BFC
		public bool RadInfoFrequencyRangesUHFR1480MHzHoptinEnabled_A43575_UIValue
		{
			get
			{
				short num = (short)553516451;
				short num2 = num;
				num = (short)1222901155;
				switch (num2 == num)
				{
				}
				num = (short)932315137;
				if (num != 0)
				{
				}
				num = (short)572653568;
				if (num != 0)
				{
				}
				num = (short)930611200;
				short num3 = num;
				return this.radInfoFrequencyRangesUHFR1480MHzHoptinEnabled_A43575.Value;
			}
			set
			{
				short num = (short)869994837;
				short num2 = num;
				num = (short)1536954709;
				switch (num2 == num)
				{
				}
				num = (short)737148928;
				if (num != 0)
				{
				}
				num = (short)1860370433;
				if (num != 0)
				{
				}
				num = (short)1701576704;
				short num3 = num;
				this.radInfoFrequencyRangesUHFR1480MHzHoptinEnabled_A43575.Value = value;
			}
		}

		// Token: 0x1700244D RID: 9293
		// (get) Token: 0x060046AC RID: 18092 RVA: 0x00417AB0 File Offset: 0x00415CB0
		// (set) Token: 0x060046AD RID: 18093 RVA: 0x00417B68 File Offset: 0x00415D68
		public bool RadInfoFrequencyRangesUHFR1480MHzHoptinEnabled_A43575_Applicable
		{
			get
			{
				short num = (short)1095478957;
				short num2 = num;
				num = (short)1075490477;
				switch (num2 == num)
				{
				}
				num = (short)759955457;
				if (num != 0)
				{
				}
				num = (short)1296171008;
				if (num != 0)
				{
				}
				num = (short)813826048;
				short num3 = num;
				return this.radInfoFrequencyRangesUHFR1480MHzHoptinEnabled_A43575.Applicable;
			}
			set
			{
				short num = (short)872241581;
				short num2 = num;
				num = (short)1933531565;
				switch (num2 == num)
				{
				}
				num = (short)923402241;
				if (num != 0)
				{
				}
				num = (short)1648099328;
				if (num != 0)
				{
				}
				num = (short)63963136;
				short num3 = num;
				this.radInfoFrequencyRangesUHFR1480MHzHoptinEnabled_A43575.Applicable = value;
			}
		}

		// Token: 0x1700244E RID: 9294
		// (get) Token: 0x060046AE RID: 18094 RVA: 0x00417C20 File Offset: 0x00415E20
		// (set) Token: 0x060046AF RID: 18095 RVA: 0x00417CD4 File Offset: 0x00415ED4
		public bool RadInfoFrequencyRangesUHFR1480MHzHoptinEnabled_A43575_Valid
		{
			get
			{
				short num = (short)109342771;
				short num2 = num;
				num = (short)1858564147;
				switch (num2 == num)
				{
				}
				num = (short)1080164353;
				if (num != 0)
				{
				}
				num = (short)1695547392;
				if (num != 0)
				{
				}
				num = (short)21233664;
				short num3 = num;
				return this.radInfoFrequencyRangesUHFR1480MHzHoptinEnabled_A43575.Valid;
			}
			set
			{
				short num = (short)1807420420;
				short num2 = num;
				num = (short)1353714692;
				switch (num2 == num)
				{
				}
				num = (short)1999437825;
				if (num != 0)
				{
				}
				num = (short)764674048;
				if (num != 0)
				{
				}
				num = (short)2099052544;
				short num3 = num;
				this.radInfoFrequencyRangesUHFR1480MHzHoptinEnabled_A43575.Valid = value;
			}
		}

		// Token: 0x1700244F RID: 9295
		// (get) Token: 0x060046B0 RID: 18096 RVA: 0x00417D88 File Offset: 0x00415F88
		// (set) Token: 0x060046B1 RID: 18097 RVA: 0x00417E40 File Offset: 0x00416040
		public bool RadInfoFrequencyRangesUHFR1480MHzHoptinEnabled_A43575_Visible
		{
			get
			{
				short num = (short)1914005019;
				short num2 = num;
				num = (short)1930389019;
				switch (num2 == num)
				{
				}
				num = (short)1207304193;
				if (num != 0)
				{
				}
				num = (short)564723712;
				if (num != 0)
				{
				}
				num = (short)877920256;
				short num3 = num;
				return this.radInfoFrequencyRangesUHFR1480MHzHoptinEnabled_A43575.Visible;
			}
			set
			{
				short num = (short)1728053249;
				if (num != 0)
				{
				}
				num = (short)97643104;
				short num2 = num;
				num = (short)319548000;
				switch (num2 == num)
				{
				}
				num = (short)1531510784;
				if (num != 0)
				{
				}
				num = (short)123928576;
				short num3 = num;
				this.radInfoFrequencyRangesUHFR1480MHzHoptinEnabled_A43575.Visible = value;
			}
		}

		// Token: 0x17002450 RID: 9296
		// (get) Token: 0x060046B2 RID: 18098 RVA: 0x00417EF8 File Offset: 0x004160F8
		// (set) Token: 0x060046B3 RID: 18099 RVA: 0x00417FAC File Offset: 0x004161AC
		public bool RadInfoFrequencyRangesUHFR1480MHzHoptinEnabled_A43575_Editable
		{
			get
			{
				short num = (short)198463127;
				short num2 = num;
				num = (short)1514622615;
				switch (num2 == num)
				{
				}
				num = (short)1539571713;
				if (num != 0)
				{
				}
				num = (short)767688704;
				if (num != 0)
				{
				}
				num = (short)1309212672;
				short num3 = num;
				return this.radInfoFrequencyRangesUHFR1480MHzHoptinEnabled_A43575.Editable;
			}
			set
			{
				short num = (short)277301163;
				short num2 = num;
				num = (short)1787119531;
				switch (num2 == num)
				{
				}
				num = (short)1544093696;
				if (num != 0)
				{
				}
				num = (short)134348801;
				if (num != 0)
				{
				}
				num = (short)1676869632;
				short num3 = num;
				this.radInfoFrequencyRangesUHFR1480MHzHoptinEnabled_A43575.Editable = value;
			}
		}

		// Token: 0x17002451 RID: 9297
		// (get) Token: 0x060046B4 RID: 18100 RVA: 0x00418064 File Offset: 0x00416264
		internal string RadInfoFrequencyRangesUHFR1480MHzHoptinEnabled_A43575_UILabel
		{
			get
			{
				short num = (short)1066784501;
				short num2 = num;
				num = (short)67426037;
				switch (num2 == num)
				{
				}
				num = (short)35717120;
				if (num != 0)
				{
				}
				num = (short)1236664321;
				if (num != 0)
				{
				}
				num = (short)616431616;
				short num3 = num;
				return this.radInfoFrequencyRangesUHFR1480MHzHoptinEnabled_A43575.UIName;
			}
		}

		// Token: 0x17002452 RID: 9298
		// (get) Token: 0x060046B5 RID: 18101 RVA: 0x00418118 File Offset: 0x00416318
		// (set) Token: 0x060046B6 RID: 18102 RVA: 0x004181CC File Offset: 0x004163CC
		internal bool RadInfoFrequencyRangesUHFR1480MHzHoptinEnabled_A43575_HiddenStatic
		{
			get
			{
				short num = (short)512619294;
				short num2 = num;
				num = (short)871428894;
				switch (num2 == num)
				{
				}
				num = (short)1999896577;
				if (num != 0)
				{
				}
				num = (short)1055326208;
				if (num != 0)
				{
				}
				num = (short)356974592;
				short num3 = num;
				return this.radInfoFrequencyRangesUHFR1480MHzHoptinEnabled_A43575.HiddenStatic;
			}
			set
			{
				short num = (short)1953384670;
				short num2 = num;
				num = (short)2123647198;
				switch (num2 == num)
				{
				}
				num = (short)479330305;
				if (num != 0)
				{
				}
				num = (short)1427570688;
				if (num != 0)
				{
				}
				num = (short)1287847936;
				short num3 = num;
				this.radInfoFrequencyRangesUHFR1480MHzHoptinEnabled_A43575.HiddenStatic = value;
			}
		}

		// Token: 0x17002453 RID: 9299
		// (get) Token: 0x060046B7 RID: 18103 RVA: 0x00418280 File Offset: 0x00416480
		// (set) Token: 0x060046B8 RID: 18104 RVA: 0x00418334 File Offset: 0x00416534
		internal bool RadInfoFrequencyRangesUHFR1480MHzHoptinEnabled_A43575_HiddenDynamic
		{
			get
			{
				short num = (short)1210822433;
				short num2 = num;
				num = (short)224702241;
				switch (num2 == num)
				{
				}
				num = (short)2026045441;
				if (num != 0)
				{
				}
				num = (short)2076573696;
				if (num != 0)
				{
				}
				num = (short)1485438976;
				short num3 = num;
				return this.radInfoFrequencyRangesUHFR1480MHzHoptinEnabled_A43575.HiddenDynamic;
			}
			set
			{
				short num = (short)883398731;
				short num2 = num;
				num = (short)1187354699;
				switch (num2 == num)
				{
				}
				num = (short)1080492032;
				if (num != 0)
				{
				}
				num = (short)489488385;
				if (num != 0)
				{
				}
				num = (short)1731002368;
				short num3 = num;
				this.radInfoFrequencyRangesUHFR1480MHzHoptinEnabled_A43575.HiddenDynamic = value;
			}
		}

		// Token: 0x17002454 RID: 9300
		// (get) Token: 0x060046B9 RID: 18105 RVA: 0x004183E8 File Offset: 0x004165E8
		public bool RadInfoFrequencyRangesUHFR1480MHzHoptinEnabled_A43575_HasDiffs
		{
			get
			{
				short num = (short)600095261;
				short num2 = num;
				num = (short)35240477;
				switch (num2 == num)
				{
				}
				num = (short)649920512;
				if (num != 0)
				{
				}
				num = (short)2060124161;
				if (num != 0)
				{
				}
				num = (short)1694629888;
				short num3 = num;
				return this.radInfoFrequencyRangesUHFR1480MHzHoptinEnabled_A43575._HasDiffs;
			}
		}

		// Token: 0x17002455 RID: 9301
		// (get) Token: 0x060046BA RID: 18106 RVA: 0x004184A0 File Offset: 0x004166A0
		// (set) Token: 0x060046BB RID: 18107 RVA: 0x00418554 File Offset: 0x00416754
		public bool RadInfoFrequencyRangesFWCapableUHFR1480MHz_A43576Value
		{
			get
			{
				short num = (short)865495519;
				short num2 = num;
				num = (short)50620895;
				switch (num2 == num)
				{
				}
				num = (short)83492865;
				if (num != 0)
				{
				}
				num = (short)1172242432;
				if (num != 0)
				{
				}
				num = (short)1340538880;
				short num3 = num;
				return this.radInfoFrequencyRangesFWCapableUHFR1480MHz_A43576.Value;
			}
			set
			{
				short num = (short)45371702;
				short num2 = num;
				num = (short)37507382;
				switch (num2 == num)
				{
				}
				num = (short)1064697856;
				if (num != 0)
				{
				}
				num = (short)1441005569;
				if (num != 0)
				{
				}
				num = (short)510001152;
				short num3 = num;
				this.radInfoFrequencyRangesFWCapableUHFR1480MHz_A43576.Value = value;
			}
		}

		// Token: 0x17002456 RID: 9302
		// (get) Token: 0x060046BC RID: 18108 RVA: 0x0041860C File Offset: 0x0041680C
		public global::AcpBusinessLayer.AcpField<bool> RadInfoFrequencyRangesFWCapableUHFR1480MHz_A43576
		{
			get
			{
				short num = (short)30112267;
				short num2 = num;
				num = (short)1556445707;
				switch (num2 == num)
				{
				}
				num = (short)530251777;
				if (num != 0)
				{
				}
				num = (short)1701052416;
				if (num != 0)
				{
				}
				num = (short)1460731904;
				short num3 = num;
				return this.radInfoFrequencyRangesFWCapableUHFR1480MHz_A43576;
			}
		}

		// Token: 0x17002457 RID: 9303
		// (get) Token: 0x060046BD RID: 18109 RVA: 0x004186BC File Offset: 0x004168BC
		// (set) Token: 0x060046BE RID: 18110 RVA: 0x0041876C File Offset: 0x0041696C
		public bool RadInfoFrequencyRangesFWCapableUHFR1480MHz_A43576_UIValue
		{
			get
			{
				short num = (short)1073414145;
				if (num != 0)
				{
				}
				num = (short)1692346962;
				short num2 = num;
				num = (short)232991314;
				switch (num2 == num)
				{
				}
				num = (short)1589444608;
				if (num != 0)
				{
				}
				num = (short)1650786304;
				short num3 = num;
				return this.radInfoFrequencyRangesFWCapableUHFR1480MHz_A43576.Value;
			}
			set
			{
				short num = (short)1750922932;
				short num2 = num;
				num = (short)1448933044;
				switch (num2 == num)
				{
				}
				num = (short)1445462016;
				if (num != 0)
				{
				}
				num = (short)466026497;
				if (num != 0)
				{
				}
				num = (short)1703477248;
				short num3 = num;
				this.radInfoFrequencyRangesFWCapableUHFR1480MHz_A43576.Value = value;
			}
		}

		// Token: 0x17002458 RID: 9304
		// (get) Token: 0x060046BF RID: 18111 RVA: 0x00418824 File Offset: 0x00416A24
		// (set) Token: 0x060046C0 RID: 18112 RVA: 0x004188D8 File Offset: 0x00416AD8
		public bool RadInfoFrequencyRangesFWCapableUHFR1480MHz_A43576_Applicable
		{
			get
			{
				short num = (short)1791293168;
				short num2 = num;
				num = (short)377419504;
				switch (num2 == num)
				{
				}
				num = (short)366608384;
				if (num != 0)
				{
				}
				num = (short)1433206785;
				if (num != 0)
				{
				}
				num = (short)1843200000;
				short num3 = num;
				return this.radInfoFrequencyRangesFWCapableUHFR1480MHz_A43576.Applicable;
			}
			set
			{
				short num = (short)447477864;
				short num2 = num;
				num = (short)547944552;
				switch (num2 == num)
				{
				}
				num = (short)52690944;
				if (num != 0)
				{
				}
				num = (short)1149370369;
				if (num != 0)
				{
				}
				num = (short)1800667136;
				short num3 = num;
				this.radInfoFrequencyRangesFWCapableUHFR1480MHz_A43576.Applicable = value;
			}
		}

		// Token: 0x17002459 RID: 9305
		// (get) Token: 0x060046C1 RID: 18113 RVA: 0x0041898C File Offset: 0x00416B8C
		// (set) Token: 0x060046C2 RID: 18114 RVA: 0x00418A44 File Offset: 0x00416C44
		public bool RadInfoFrequencyRangesFWCapableUHFR1480MHz_A43576_Valid
		{
			get
			{
				short num = (short)2023311761;
				short num2 = num;
				num = (short)642337169;
				switch (num2 == num)
				{
				}
				num = (short)618397697;
				if (num != 0)
				{
				}
				num = (short)858390528;
				if (num != 0)
				{
				}
				num = (short)463994880;
				short num3 = num;
				return this.radInfoFrequencyRangesFWCapableUHFR1480MHz_A43576.Valid;
			}
			set
			{
				short num = (short)1550712833;
				if (num != 0)
				{
				}
				num = (short)1424888971;
				short num2 = num;
				num = (short)2018907275;
				switch (num2 == num)
				{
				}
				num = (short)1764491264;
				if (num != 0)
				{
				}
				num = (short)1313406976;
				short num3 = num;
				this.radInfoFrequencyRangesFWCapableUHFR1480MHz_A43576.Valid = value;
			}
		}

		// Token: 0x1700245A RID: 9306
		// (get) Token: 0x060046C3 RID: 18115 RVA: 0x00418AFC File Offset: 0x00416CFC
		// (set) Token: 0x060046C4 RID: 18116 RVA: 0x00418BB4 File Offset: 0x00416DB4
		public bool RadInfoFrequencyRangesFWCapableUHFR1480MHz_A43576_Visible
		{
			get
			{
				short num = (short)1652602350;
				short num2 = num;
				num = (short)261469678;
				switch (num2 == num)
				{
				}
				num = (short)1986920449;
				if (num != 0)
				{
				}
				num = (short)927858688;
				if (num != 0)
				{
				}
				num = (short)142409728;
				short num3 = num;
				return this.radInfoFrequencyRangesFWCapableUHFR1480MHz_A43576.Visible;
			}
			set
			{
				short num = (short)1432650361;
				short num2 = num;
				num = (short)1173652089;
				switch (num2 == num)
				{
				}
				num = (short)1856110593;
				if (num != 0)
				{
				}
				num = (short)662831104;
				if (num != 0)
				{
				}
				num = (short)966852608;
				short num3 = num;
				this.radInfoFrequencyRangesFWCapableUHFR1480MHz_A43576.Visible = value;
			}
		}

		// Token: 0x1700245B RID: 9307
		// (get) Token: 0x060046C5 RID: 18117 RVA: 0x00418C68 File Offset: 0x00416E68
		// (set) Token: 0x060046C6 RID: 18118 RVA: 0x00418D1C File Offset: 0x00416F1C
		public bool RadInfoFrequencyRangesFWCapableUHFR1480MHz_A43576_Editable
		{
			get
			{
				short num = (short)1879229656;
				short num2 = num;
				num = (short)24036568;
				switch (num2 == num)
				{
				}
				num = (short)359006208;
				if (num != 0)
				{
				}
				num = (short)1664483329;
				if (num != 0)
				{
				}
				num = (short)1293942784;
				short num3 = num;
				return this.radInfoFrequencyRangesFWCapableUHFR1480MHz_A43576.Editable;
			}
			set
			{
				short num = (short)144577219;
				short num2 = num;
				num = (short)1266356931;
				switch (num2 == num)
				{
				}
				num = (short)1911226369;
				if (num != 0)
				{
				}
				num = (short)1858011136;
				if (num != 0)
				{
				}
				num = (short)806813696;
				short num3 = num;
				this.radInfoFrequencyRangesFWCapableUHFR1480MHz_A43576.Editable = value;
			}
		}

		// Token: 0x1700245C RID: 9308
		// (get) Token: 0x060046C7 RID: 18119 RVA: 0x00418DD0 File Offset: 0x00416FD0
		internal string RadInfoFrequencyRangesFWCapableUHFR1480MHz_A43576_UILabel
		{
			get
			{
				short num = (short)1873547951;
				short num2 = num;
				num = (short)1605505711;
				switch (num2 == num)
				{
				}
				num = (short)182779904;
				if (num != 0)
				{
				}
				num = (short)2084241409;
				if (num != 0)
				{
				}
				num = (short)1569390592;
				short num3 = num;
				return this.radInfoFrequencyRangesFWCapableUHFR1480MHz_A43576.UIName;
			}
		}

		// Token: 0x1700245D RID: 9309
		// (get) Token: 0x060046C8 RID: 18120 RVA: 0x00418E88 File Offset: 0x00417088
		// (set) Token: 0x060046C9 RID: 18121 RVA: 0x00418F40 File Offset: 0x00417140
		internal bool RadInfoFrequencyRangesFWCapableUHFR1480MHz_A43576_HiddenStatic
		{
			get
			{
				short num = (short)1361969153;
				if (num != 0)
				{
				}
				num = (short)1425074622;
				short num2 = num;
				num = (short)204990910;
				switch (num2 == num)
				{
				}
				num = (short)704315392;
				if (num != 0)
				{
				}
				num = (short)1899823104;
				short num3 = num;
				return this.radInfoFrequencyRangesFWCapableUHFR1480MHz_A43576.HiddenStatic;
			}
			set
			{
				short num = (short)870055937;
				if (num != 0)
				{
				}
				num = (short)2045613890;
				short num2 = num;
				num = (short)1388025666;
				switch (num2 == num)
				{
				}
				num = (short)2123366400;
				if (num != 0)
				{
				}
				num = (short)1339686912;
				short num3 = num;
				this.radInfoFrequencyRangesFWCapableUHFR1480MHz_A43576.HiddenStatic = value;
			}
		}

		// Token: 0x1700245E RID: 9310
		// (get) Token: 0x060046CA RID: 18122 RVA: 0x00418FF8 File Offset: 0x004171F8
		// (set) Token: 0x060046CB RID: 18123 RVA: 0x004190AC File Offset: 0x004172AC
		internal bool RadInfoFrequencyRangesFWCapableUHFR1480MHz_A43576_HiddenDynamic
		{
			get
			{
				short num = (short)1188402595;
				short num2 = num;
				num = (short)1063818659;
				switch (num2 == num)
				{
				}
				num = (short)781320192;
				if (num != 0)
				{
				}
				num = (short)853934081;
				if (num != 0)
				{
				}
				num = (short)1734934528;
				short num3 = num;
				return this.radInfoFrequencyRangesFWCapableUHFR1480MHz_A43576.HiddenDynamic;
			}
			set
			{
				short num = (short)503578625;
				if (num != 0)
				{
				}
				num = (short)1189398186;
				short num2 = num;
				num = (short)256296618;
				switch (num2 == num)
				{
				}
				num = (short)336920576;
				short num3 = num;
				num = (short)957284352;
				if (num != 0)
				{
				}
				this.radInfoFrequencyRangesFWCapableUHFR1480MHz_A43576.HiddenDynamic = value;
			}
		}

		// Token: 0x1700245F RID: 9311
		// (get) Token: 0x060046CC RID: 18124 RVA: 0x00419160 File Offset: 0x00417360
		public bool RadInfoFrequencyRangesFWCapableUHFR1480MHz_A43576_HasDiffs
		{
			get
			{
				short num = (short)1246969169;
				short num2 = num;
				num = (short)1289960785;
				switch (num2 == num)
				{
				}
				num = (short)324075520;
				if (num != 0)
				{
				}
				num = (short)695599104;
				short num3 = num;
				num = (short)653328385;
				if (num != 0)
				{
				}
				return this.radInfoFrequencyRangesFWCapableUHFR1480MHz_A43576._HasDiffs;
			}
		}

		// Token: 0x17002460 RID: 9312
		// (get) Token: 0x060046CD RID: 18125 RVA: 0x00419214 File Offset: 0x00417414
		// (set) Token: 0x060046CE RID: 18126 RVA: 0x004192C8 File Offset: 0x004174C8
		public bool RadInfoFrequencyRangesExtendedUHFR1480MHzCapable_A43578Value
		{
			get
			{
				short num = (short)1548208235;
				short num2 = num;
				num = (short)1304741995;
				switch (num2 == num)
				{
				}
				num = (short)804847616;
				if (num != 0)
				{
				}
				num = (short)2018705408;
				short num3 = num;
				num = (short)1219952641;
				if (num != 0)
				{
				}
				return this.radInfoFrequencyRangesExtendedUHFR1480MHzCapable_A43578.Value;
			}
			set
			{
				short num = (short)1710358529;
				if (num != 0)
				{
				}
				num = (short)1569637101;
				short num2 = num;
				num = (short)1161282285;
				switch (num2 == num)
				{
				}
				num = (short)415498240;
				short num3 = num;
				num = (short)457375744;
				if (num != 0)
				{
				}
				this.radInfoFrequencyRangesExtendedUHFR1480MHzCapable_A43578.Value = value;
			}
		}

		// Token: 0x17002461 RID: 9313
		// (get) Token: 0x060046CF RID: 18127 RVA: 0x0041937C File Offset: 0x0041757C
		public global::AcpBusinessLayer.AcpField<bool> RadInfoFrequencyRangesExtendedUHFR1480MHzCapable_A43578
		{
			get
			{
				short num = (short)1470962271;
				short num2 = num;
				num = (short)1502222943;
				switch (num2 == num)
				{
				}
				num = (short)1793196033;
				if (num != 0)
				{
				}
				num = (short)859176960;
				short num3 = num;
				num = (short)513474560;
				if (num != 0)
				{
				}
				return this.radInfoFrequencyRangesExtendedUHFR1480MHzCapable_A43578;
			}
		}

		// Token: 0x17002462 RID: 9314
		// (get) Token: 0x060046D0 RID: 18128 RVA: 0x0041942C File Offset: 0x0041762C
		// (set) Token: 0x060046D1 RID: 18129 RVA: 0x004194E0 File Offset: 0x004176E0
		public bool RadInfoFrequencyRangesExtendedUHFR1480MHzCapable_A43578_UIValue
		{
			get
			{
				short num = (short)1948468823;
				short num2 = num;
				num = (short)337069655;
				switch (num2 == num)
				{
				}
				num = (short)1570897921;
				if (num != 0)
				{
				}
				num = (short)32571392;
				short num3 = num;
				num = (short)1723006976;
				if (num != 0)
				{
				}
				return this.radInfoFrequencyRangesExtendedUHFR1480MHzCapable_A43578.Value;
			}
			set
			{
				short num = (short)2011329200;
				short num2 = num;
				num = (short)1038774960;
				switch (num2 == num)
				{
				}
				num = (short)182648832;
				if (num != 0)
				{
				}
				num = (short)254410752;
				short num3 = num;
				num = (short)2028273665;
				if (num != 0)
				{
				}
				this.radInfoFrequencyRangesExtendedUHFR1480MHzCapable_A43578.Value = value;
			}
		}

		// Token: 0x17002463 RID: 9315
		// (get) Token: 0x060046D2 RID: 18130 RVA: 0x00419598 File Offset: 0x00417798
		// (set) Token: 0x060046D3 RID: 18131 RVA: 0x0041964C File Offset: 0x0041784C
		public bool RadInfoFrequencyRangesExtendedUHFR1480MHzCapable_A43578_Applicable
		{
			get
			{
				short num = (short)1631098483;
				short num2 = num;
				num = (short)1150326387;
				switch (num2 == num)
				{
				}
				num = (short)211025921;
				if (num != 0)
				{
				}
				num = (short)655556608;
				short num3 = num;
				num = (short)428146688;
				if (num != 0)
				{
				}
				return this.radInfoFrequencyRangesExtendedUHFR1480MHzCapable_A43578.Applicable;
			}
			set
			{
				short num = (short)971012794;
				short num2 = num;
				num = (short)666401466;
				switch (num2 == num)
				{
				}
				num = (short)655425536;
				if (num != 0)
				{
				}
				num = (short)1820065792;
				short num3 = num;
				num = (short)1986789377;
				if (num != 0)
				{
				}
				this.radInfoFrequencyRangesExtendedUHFR1480MHzCapable_A43578.Applicable = value;
			}
		}

		// Token: 0x17002464 RID: 9316
		// (get) Token: 0x060046D4 RID: 18132 RVA: 0x00419704 File Offset: 0x00417904
		// (set) Token: 0x060046D5 RID: 18133 RVA: 0x004197B8 File Offset: 0x004179B8
		public bool RadInfoFrequencyRangesExtendedUHFR1480MHzCapable_A43578_Valid
		{
			get
			{
				short num = (short)357309024;
				short num2 = num;
				num = (short)31726176;
				switch (num2 == num)
				{
				}
				num = (short)1949499392;
				if (num != 0)
				{
				}
				num = (short)319881216;
				short num3 = num;
				num = (short)2025259009;
				if (num != 0)
				{
				}
				return this.radInfoFrequencyRangesExtendedUHFR1480MHzCapable_A43578.Valid;
			}
			set
			{
				short num = (short)1858741127;
				short num2 = num;
				num = (short)506930055;
				switch (num2 == num)
				{
				}
				num = (short)2060320769;
				if (num != 0)
				{
				}
				num = (short)1378418688;
				short num3 = num;
				num = (short)1759248384;
				if (num != 0)
				{
				}
				this.radInfoFrequencyRangesExtendedUHFR1480MHzCapable_A43578.Valid = value;
			}
		}

		// Token: 0x17002465 RID: 9317
		// (get) Token: 0x060046D6 RID: 18134 RVA: 0x0041986C File Offset: 0x00417A6C
		// (set) Token: 0x060046D7 RID: 18135 RVA: 0x00419924 File Offset: 0x00417B24
		public bool RadInfoFrequencyRangesExtendedUHFR1480MHzCapable_A43578_Visible
		{
			get
			{
				short num = (short)140864244;
				short num2 = num;
				num = (short)1233545972;
				switch (num2 == num)
				{
				}
				num = (short)1572274177;
				if (num != 0)
				{
				}
				num = (short)269549568;
				short num3 = num;
				num = (short)1314586624;
				if (num != 0)
				{
				}
				return this.radInfoFrequencyRangesExtendedUHFR1480MHzCapable_A43578.Visible;
			}
			set
			{
				short num = (short)1962125962;
				short num2 = num;
				num = (short)2096736906;
				switch (num2 == num)
				{
				}
				num = (short)1094320129;
				if (num != 0)
				{
				}
				num = (short)1692008448;
				short num3 = num;
				num = (short)1915420672;
				if (num != 0)
				{
				}
				this.radInfoFrequencyRangesExtendedUHFR1480MHzCapable_A43578.Visible = value;
			}
		}

		// Token: 0x17002466 RID: 9318
		// (get) Token: 0x060046D8 RID: 18136 RVA: 0x004199D8 File Offset: 0x00417BD8
		// (set) Token: 0x060046D9 RID: 18137 RVA: 0x00419A8C File Offset: 0x00417C8C
		public bool RadInfoFrequencyRangesExtendedUHFR1480MHzCapable_A43578_Editable
		{
			get
			{
				short num = (short)1080550510;
				short num2 = num;
				num = (short)479978606;
				switch (num2 == num)
				{
				}
				num = (short)1822752768;
				if (num != 0)
				{
				}
				num = (short)1822294016;
				short num3 = num;
				num = (short)1487339521;
				if (num != 0)
				{
				}
				return this.radInfoFrequencyRangesExtendedUHFR1480MHzCapable_A43578.Editable;
			}
			set
			{
				short num = (short)1296629761;
				if (num != 0)
				{
				}
				num = (short)1518123991;
				short num2 = num;
				num = (short)291945431;
				switch (num2 == num)
				{
				}
				num = (short)2068054016;
				short num3 = num;
				num = (short)415105024;
				if (num != 0)
				{
				}
				this.radInfoFrequencyRangesExtendedUHFR1480MHzCapable_A43578.Editable = value;
			}
		}

		// Token: 0x17002467 RID: 9319
		// (get) Token: 0x060046DA RID: 18138 RVA: 0x00419B40 File Offset: 0x00417D40
		internal string RadInfoFrequencyRangesExtendedUHFR1480MHzCapable_A43578_UILabel
		{
			get
			{
				short num = (short)1714225153;
				if (num != 0)
				{
				}
				num = (short)2145852788;
				short num2 = num;
				num = (short)692788596;
				switch (num2 == num)
				{
				}
				num = (short)1506607104;
				short num3 = num;
				num = (short)1654390784;
				if (num != 0)
				{
				}
				return this.radInfoFrequencyRangesExtendedUHFR1480MHzCapable_A43578.UIName;
			}
		}

		// Token: 0x17002468 RID: 9320
		// (get) Token: 0x060046DB RID: 18139 RVA: 0x00419BF4 File Offset: 0x00417DF4
		// (set) Token: 0x060046DC RID: 18140 RVA: 0x00419CAC File Offset: 0x00417EAC
		internal bool RadInfoFrequencyRangesExtendedUHFR1480MHzCapable_A43578_HiddenStatic
		{
			get
			{
				short num = (short)1873932628;
				short num2 = num;
				num = (short)2013196628;
				switch (num2 == num)
				{
				}
				num = (short)398524417;
				if (num != 0)
				{
				}
				num = (short)454230016;
				short num3 = num;
				num = (short)1272381440;
				if (num != 0)
				{
				}
				return this.radInfoFrequencyRangesExtendedUHFR1480MHzCapable_A43578.HiddenStatic;
			}
			set
			{
				short num = (short)1642608571;
				short num2 = num;
				num = (short)2088908731;
				switch (num2 == num)
				{
				}
				num = (short)847708161;
				if (num != 0)
				{
				}
				num = (short)320864256;
				short num3 = num;
				num = (short)974651392;
				if (num != 0)
				{
				}
				this.radInfoFrequencyRangesExtendedUHFR1480MHzCapable_A43578.HiddenStatic = value;
			}
		}

		// Token: 0x17002469 RID: 9321
		// (get) Token: 0x060046DD RID: 18141 RVA: 0x00419D64 File Offset: 0x00417F64
		// (set) Token: 0x060046DE RID: 18142 RVA: 0x00419E18 File Offset: 0x00418018
		internal bool RadInfoFrequencyRangesExtendedUHFR1480MHzCapable_A43578_HiddenDynamic
		{
			get
			{
				short num = (short)1797791852;
				short num2 = num;
				num = (short)362094700;
				switch (num2 == num)
				{
				}
				num = (short)937623553;
				if (num != 0)
				{
				}
				num = (short)1537474560;
				short num3 = num;
				num = (short)1666252800;
				if (num != 0)
				{
				}
				return this.radInfoFrequencyRangesExtendedUHFR1480MHzCapable_A43578.HiddenDynamic;
			}
			set
			{
				short num = (short)641756607;
				short num2 = num;
				num = (short)633630143;
				switch (num2 == num)
				{
				}
				num = (short)980025345;
				if (num != 0)
				{
				}
				num = (short)1031471104;
				short num3 = num;
				num = (short)16187392;
				if (num != 0)
				{
				}
				this.radInfoFrequencyRangesExtendedUHFR1480MHzCapable_A43578.HiddenDynamic = value;
			}
		}

		// Token: 0x1700246A RID: 9322
		// (get) Token: 0x060046DF RID: 18143 RVA: 0x00419ED0 File Offset: 0x004180D0
		public bool RadInfoFrequencyRangesExtendedUHFR1480MHzCapable_A43578_HasDiffs
		{
			get
			{
				short num = (short)1257557449;
				short num2 = num;
				num = (short)1601818057;
				switch (num2 == num)
				{
				}
				num = (short)541589505;
				if (num != 0)
				{
				}
				num = (short)175439872;
				short num3 = num;
				num = (short)1545207808;
				if (num != 0)
				{
				}
				return this.radInfoFrequencyRangesExtendedUHFR1480MHzCapable_A43578._HasDiffs;
			}
		}

		// Token: 0x060046E0 RID: 18144 RVA: 0x00419F88 File Offset: 0x00418188
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
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)1942945793;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 1:
				{
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)1949564928;
					short num3 = num2;
					num2 = (short)971374595;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
				{
					num2 = (short)305837988;
					short num4 = num2;
					num2 = (short)959231908;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return result;
					default:
						num2 = (short)837484544;
						if (num2 != 0)
						{
						}
						num2 = (short)1944256513;
						if (num2 != 0)
						{
						}
						num2 = (short)1539309568;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 3:
					return result;
				case 4:
					if (base.ParentRecset != null)
					{
						num2 = (short)405864450;
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
			num2 = (short)535035908;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060046E1 RID: 18145 RVA: 0x0041A0F8 File Offset: 0x004182F8
		private void l()
		{
			short num = (short)1470432947;
			short num2 = num;
			num = (short)909182643;
			switch (num2 == num)
			{
			}
			num = (short)81920000;
			if (num != 0)
			{
			}
			num = (short)212467712;
			short num3 = num;
			num = (short)35389441;
			if (num != 0)
			{
			}
			this.f();
		}

		// Token: 0x060046E2 RID: 18146 RVA: 0x0041A1A8 File Offset: 0x004183A8
		private void k()
		{
			short num = (short)1909594348;
			short num2 = num;
			num = (short)430250220;
			switch (num2 == num)
			{
			}
			num = (short)594411520;
			if (num != 0)
			{
			}
			num = (short)481886208;
			short num3 = num;
			num = (short)1448411137;
			if (num != 0)
			{
			}
			this.e();
		}

		// Token: 0x060046E3 RID: 18147 RVA: 0x0041A258 File Offset: 0x00418458
		private void j()
		{
			short num = (short)306210075;
			short num2 = num;
			num = (short)1898079515;
			switch (num2 == num)
			{
			}
			num = (short)1634926593;
			if (num != 0)
			{
			}
			num = (short)1394868224;
			short num3 = num;
			num = (short)260308992;
			if (num != 0)
			{
			}
			this.d();
		}

		// Token: 0x060046E4 RID: 18148 RVA: 0x0041A308 File Offset: 0x00418508
		private void i()
		{
			short num = (short)1728857377;
			short num2 = num;
			num = (short)1670268193;
			switch (num2 == num)
			{
			}
			num = (short)1069678593;
			if (num != 0)
			{
			}
			num = (short)2075852800;
			short num3 = num;
			num = (short)289603584;
			if (num != 0)
			{
			}
			this.c();
		}

		// Token: 0x060046E5 RID: 18149 RVA: 0x0041A3B8 File Offset: 0x004185B8
		private void h()
		{
			short num = (short)337885764;
			short num2 = num;
			num = (short)44153412;
			switch (num2 == num)
			{
			}
			num = (short)110952448;
			if (num != 0)
			{
			}
			num = (short)297926656;
			short num3 = num;
			num = (short)974913537;
			if (num != 0)
			{
			}
			this.b();
		}

		// Token: 0x060046E6 RID: 18150 RVA: 0x0041A464 File Offset: 0x00418664
		private void g()
		{
			short num = (short)937396619;
			short num2 = num;
			num = (short)1087474059;
			switch (num2 == num)
			{
			}
			num = (short)719388672;
			if (num != 0)
			{
			}
			num = (short)2135490560;
			short num3 = num;
			num = (short)701431809;
			if (num != 0)
			{
			}
			this.a();
		}

		// Token: 0x060046E7 RID: 18151 RVA: 0x0041A514 File Offset: 0x00418714
		private void f()
		{
			short num = (short)2048631107;
			short num2 = num;
			num = (short)976331075;
			int num4;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_9B:
				num = (short)1902444544;
				short num3 = num;
				num = (short)1169752065;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformationConstraints.ConReadPerformanceValidity(this, null);
				num = (short)37224448;
				num4 = (int)((global::System.IntPtr)num);
				break;
			}
			default:
				num = (short)769785856;
				if (num != 0)
				{
				}
				num = (short)777650178;
				num4 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				switch (num4)
				{
				case 0:
					return;
				case 1:
					goto IL_9B;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_7C;
					}
					continue;
				}
				IL_7C:
				if (global::AcpCommonLib.UndoRedo.UndoManager.MarkForUndo)
				{
					break;
				}
				num = (short)465829889;
				num4 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x060046E8 RID: 18152 RVA: 0x0041A630 File Offset: 0x00418830
		private void e()
		{
			short num = (short)293918620;
			short num2 = num;
			num = (short)283432860;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_EE:
				global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformationConstraints.ConReadPerformanceValidity(this, null);
				num = (short)1419902976;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)1507983360;
				if (num != 0)
				{
				}
				num = (short)1945567234;
				num3 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				switch (num3)
				{
				case 0:
					return;
				case 1:
					goto IL_EE;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_7B;
					}
					continue;
				}
				IL_7B:
				if (global::AcpCommonLib.UndoRedo.UndoManager.MarkForUndo)
				{
					break;
				}
				num = (short)850395137;
				if (num != 0)
				{
				}
				num = (short)1702887424;
				short num4 = num;
				num = (short)1495531521;
				num3 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x060046E9 RID: 18153 RVA: 0x0041A750 File Offset: 0x00418950
		private void d()
		{
			short num = (short)488782824;
			short num2 = num;
			num = (short)1373584360;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_EE:
				global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformationConstraints.ConReadPerformanceValidity(this, null);
				num = (short)2087321600;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)1483800576;
				if (num != 0)
				{
				}
				num = (short)671481858;
				num3 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				switch (num3)
				{
				case 0:
					return;
				case 1:
					goto IL_EE;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_7C;
					}
					continue;
				}
				IL_7C:
				if (global::AcpCommonLib.UndoRedo.UndoManager.MarkForUndo)
				{
					break;
				}
				num = (short)1630273537;
				if (num != 0)
				{
				}
				num = (short)1829634048;
				short num4 = num;
				num = (short)477626369;
				num3 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x060046EA RID: 18154 RVA: 0x0041A870 File Offset: 0x00418A70
		private void c()
		{
			short num = (short)596467181;
			short num2 = num;
			num = (short)1951161837;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_EA:
				global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformationConstraints.ConReadPerformanceValidity(this, null);
				num = (short)1466171392;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)1139736576;
				if (num != 0)
				{
				}
				num = (short)2012676098;
				num3 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				switch (num3)
				{
				case 0:
					return;
				case 1:
					goto IL_EA;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_7C;
					}
					continue;
				}
				IL_7C:
				if (global::AcpCommonLib.UndoRedo.UndoManager.MarkForUndo)
				{
					break;
				}
				num = (short)621412353;
				if (num != 0)
				{
				}
				num = (short)252903424;
				short num4 = num;
				num = (short)1905131521;
				num3 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x060046EB RID: 18155 RVA: 0x0041A98C File Offset: 0x00418B8C
		private void b()
		{
			short num = (short)1775910835;
			short num2 = num;
			num = (short)2045460403;
			int num4;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_99:
				num = (short)281542656;
				short num3 = num;
				num = (short)879689729;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformationConstraints.ConReadPerformanceValidity(this, null);
				num = (short)125435904;
				num4 = (int)((global::System.IntPtr)num);
				break;
			}
			default:
				num = (short)462094336;
				if (num != 0)
				{
				}
				num = (short)26279938;
				num4 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				switch (num4)
				{
				case 0:
					return;
				case 1:
					goto IL_99;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_7A;
					}
					continue;
				}
				IL_7A:
				if (global::AcpCommonLib.UndoRedo.UndoManager.MarkForUndo)
				{
					break;
				}
				num = (short)619380737;
				num4 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x060046EC RID: 18156 RVA: 0x0041AAA8 File Offset: 0x00418CA8
		private void a()
		{
			short num = (short)1023040890;
			short num2 = num;
			num = (short)789601658;
			int num4;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_99:
				num = (short)1884880896;
				short num3 = num;
				num = (short)540344321;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformationConstraints.ConReadPerformanceValidity(this, null);
				num = (short)2075459584;
				num4 = (int)((global::System.IntPtr)num);
				break;
			}
			default:
				num = (short)510656512;
				if (num != 0)
				{
				}
				num = (short)98697218;
				num4 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				switch (num4)
				{
				case 0:
					return;
				case 1:
					goto IL_99;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_7B;
					}
					continue;
				}
				IL_7B:
				if (global::AcpCommonLib.UndoRedo.UndoManager.MarkForUndo)
				{
					break;
				}
				num = (short)1621557249;
				num4 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x04001A7F RID: 6783
		private global::AcpBusinessLayer.AcpField<bool> radInfoFrequencyRangesVHFUsedinCodeplug_A8481;

		// Token: 0x04001A80 RID: 6784
		private global::AcpBusinessLayer.AcpField<bool> radInfoFrequencyRangesUHF1UsedinCodeplug_A8504;

		// Token: 0x04001A81 RID: 6785
		private global::AcpBusinessLayer.AcpField<bool> radInfoFrequencyRangesUHF2UsedinCodeplug_A8507;

		// Token: 0x04001A82 RID: 6786
		private global::AcpBusinessLayer.AcpField<bool> radInfoFrequencyRanges7800MHzUsedinCodeplug_A8512;

		// Token: 0x04001A83 RID: 6787
		private global::AcpBusinessLayer.AcpField<bool> radInfoFrequencyRanges900MHzUsedinCodeplug_A8516;

		// Token: 0x04001A84 RID: 6788
		private global::AcpBusinessLayer.AcpField<bool> radInfoFrequencyRangesAllowInvalidFrequencies_A12493;

		// Token: 0x04001A85 RID: 6789
		private global::AcpBusinessLayer.AcpField<bool> radInfoFrequencyRangesOpenFrequency_A22699;

		// Token: 0x04001A86 RID: 6790
		private global::AcpBusinessLayer.AcpField<bool> radInfoFrequencyRangesExtendedUHFR1Capable_A41443;

		// Token: 0x04001A87 RID: 6791
		private global::AcpBusinessLayer.AcpField<bool> radInfoFrequencyRanges8900MHzUsedinCodeplug_A42502;

		// Token: 0x04001A88 RID: 6792
		private global::AcpBusinessLayer.AcpField<bool> radInfoFrequencyRanges700MHzUsedinCodeplug_A42551;

		// Token: 0x04001A89 RID: 6793
		private global::AcpBusinessLayer.AcpField<bool> radInfoFrequencyRanges800MHzUsedinCodeplug_A42552;

		// Token: 0x04001A8A RID: 6794
		private global::AcpBusinessLayer.AcpField<bool> radInfoFrequencyRangesExtendRange762Capable_A43555;

		// Token: 0x04001A8B RID: 6795
		private global::AcpBusinessLayer.AcpField<bool> radInfoFrequencyRangesUHFR1480MHzHoptinEnabled_A43575;

		// Token: 0x04001A8C RID: 6796
		private global::AcpBusinessLayer.AcpField<bool> radInfoFrequencyRangesFWCapableUHFR1480MHz_A43576;

		// Token: 0x04001A8D RID: 6797
		private global::AcpBusinessLayer.AcpField<bool> radInfoFrequencyRangesExtendedUHFR1480MHzCapable_A43578;
	}
}
