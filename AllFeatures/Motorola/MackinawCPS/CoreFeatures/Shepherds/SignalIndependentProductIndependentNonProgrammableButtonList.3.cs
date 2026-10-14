using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using ConstraintHelper;

namespace Motorola.MackinawCPS.CoreFeatures.Shepherds
{
	// Token: 0x020001E3 RID: 483
	[global::System.Serializable]
	public class SignalIndependentProductIndependentNonProgrammableButtonListInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06005441 RID: 21569 RVA: 0x004C96B8 File Offset: 0x004C78B8
		public SignalIndependentProductIndependentNonProgrammableButtonListInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06005442 RID: 21570 RVA: 0x004C96D4 File Offset: 0x004C78D4
		protected SignalIndependentProductIndependentNonProgrammableButtonListInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			this.b(info, context);
		}

		// Token: 0x06005443 RID: 21571 RVA: 0x004C96F4 File Offset: 0x004C78F4
		public override void Init()
		{
			int a_ = 1;
			short num = (short)1607598080;
			short num2 = num;
			num = (short)280215584;
			short num3 = num;
			num = (short)1859829792;
			switch (num3 == num)
			{
			}
			num = (short)1144061953;
			if (num != 0)
			{
			}
			num = (short)623575040;
			if (num != 0)
			{
			}
			this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonKey_A21195 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ跇룉ꯋꇍ鏏듑돓藕뇗뷙닛뿝賟ꯡ諣若跧髩觫胭铯韱髳苵ꣷ裹鏻髽痿愁瀃伅昇渉椋縍甏簑瀓猕瘗渙创焝丟爡嘣䤥伧堩䴫䌭崯匱嘳娵崷砹䤻䨽㐿ⵁ⩃൅ⵇ㍉ፋཌྷ扏捑敓潕浗", a_), global::CommonResources.AcgResources.ID_KEY, 14);
			this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonKey_A21195.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonKey_A21195.DataTransferOrder = -1;
			this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonBCO_A19777 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.Shepherds.LOVs.indexRadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonBCO_A19777LovStrs, global::Motorola.MackinawCPS.CoreFeatures.Shepherds.LOVs.idRadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonBCO_A19777LovStrs), this, global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ跇룉ꯋꇍ鏏듑돓藕뇗뷙닛뿝賟ꯡ諣若跧髩觫胭铯韱髳苵ꣷ裹鏻髽痿愁瀃伅昇渉椋縍甏簑瀓猕瘗渙创焝丟爡嘣䤥伧堩䴫䌭崯匱嘳娵崷砹䤻䨽㐿ⵁ⩃хେՉፋཌྷ慏歑捓慕潗", a_), global::CommonResources.AcgResources.ID_BCO, global::Motorola.MackinawCPS.CoreFeatures.Shepherds.LOVs.RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonBCO_A19777LovStrs);
			this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonBCO_A19777.IgnoreOnCompare = true;
			this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonBCO_A19777.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonBCO_A19777.DataTransferOrder = -1;
			this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonFeature_A19778 = new global::AcpBusinessLayer.AcpSparseLOVField(45, new global::Motorola.MackinawCPS.CoreFeatures.Shepherds.ModeUpDownSparseConverter(global::Motorola.MackinawCPS.CoreFeatures.Shepherds.LOVs.indexRadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonFeature_A19778LovStrs, global::Motorola.MackinawCPS.CoreFeatures.Shepherds.LOVs.idRadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonFeature_A19778LovStrs), this, global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ跇룉ꯋꇍ鏏듑돓藕뇗뷙닛뿝賟ꯡ諣若跧髩觫胭铯韱髳苵ꣷ裹鏻髽痿愁瀃伅昇渉椋縍甏簑瀓猕瘗渙创焝丟爡嘣䤥伧堩䴫䌭崯匱嘳娵崷砹䤻䨽㐿ⵁ⩃Eⵇ⭉㡋㭍≏㝑୓᝕楗捙歛楝塟", a_), global::CommonResources.AcgResources.ID_FEATURE, global::Motorola.MackinawCPS.CoreFeatures.Shepherds.LOVs.RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonFeature_A19778LovStrs);
			this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonFeature_A19778.IgnoreOnCompare = true;
			this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonFeature_A19778.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonFeature_A19778.DataTransferOrder = -1;
			this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonShortPressTime = new global::AcpBusinessLayer.AcpSimpleRangeField(255, this, global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ跇룉ꯋꇍ鏏듑돓藕뇗뷙닛뿝賟ꯡ諣若跧髩觫胭铯韱髳苵ꣷ裹鏻髽痿愁瀃伅昇渉椋縍甏簑瀓猕瘗渙创焝丟爡嘣䤥伧堩䴫䌭崯匱嘳娵崷砹䤻䨽㐿ⵁ⩃ᕅ⁇╉㹋㩍O⁑ㅓ╕⭗๙㕛㍝՟", a_), global::CommonResources.AcgResources.ID_SHORTPRESSTIME, 0, 124, null, null, 0, 50);
			this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonShortPressTime.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonShortPressTime.DataTransferOrder = -1;
			this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonShortPressTime.AddCustomValue(255, global::CommonResources.AcgResources.ID_RADIOWIDE);
			this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonShortPressTime.ShowHexValue = false;
			this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonShortPressTime.ValidateAcrossRecset = true;
			this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonLongPressTime = new global::AcpBusinessLayer.AcpSimpleRangeField(255, this, global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ跇룉ꯋꇍ鏏듑돓藕뇗뷙닛뿝賟ꯡ諣若跧髩觫胭铯韱髳苵ꣷ裹鏻髽痿愁瀃伅昇渉椋縍甏簑瀓猕瘗渙创焝丟爡嘣䤥伧堩䴫䌭崯匱嘳娵崷砹䤻䨽㐿ⵁ⩃੅❇⑉⭋ṍ≏㝑❓╕౗㍙ㅛ㭝", a_), global::CommonResources.AcgResources.ID_LONGPRESSTIME, 0, 25, null, null, 0, 250);
			this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonLongPressTime.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonLongPressTime.DataTransferOrder = -1;
			this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonLongPressTime.AddCustomValue(255, global::CommonResources.AcgResources.ID_RADIOWIDE);
			this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonLongPressTime.ShowHexValue = false;
			this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonLongPressTime.ValidateAcrossRecset = true;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("釁귃ꇅꛇꯉꃋ駏병냓돕꣗뿙닛뫝藟賡郣웥룧飩菫諭藯釱胳훵뇷铹飻鯽烿朁樃戅洇搉砋⸍帏紑稓㬕䠗栙猛礝刟䌡䤣䬥䤧䠩䀫䬭ု瀱䄳䈵䰷唹刻ḽి⭁㝃㉅", a_);
			base.Id = 10032;
			base.UIName = global::CommonResources.AcgResources.ID_SIGNALINDEPENDENTPRODUCTINDEPENDENTNONPROGRAMMABLEBUTTONLIST;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06005444 RID: 21572 RVA: 0x004C99A8 File Offset: 0x004C7BA8
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 12;
			short num = (short)1555431426;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鿌껎뗐雒꟔냖뛘飚믜룞닠諢苤触裨蟪ꓬ臮闰雲藴鋶韸鿺飼釾甀匂眄栆洈縊渌笎堐紒焔爖椘縚猜笞䐠䴢儤椦䘨䔪紬崮帰吲䜴嘶吸嘺尼崾ⵀ♂݄㉆㵈㽊≌ⅎᩐ㙒ⱔࡖᡘ楚汜湞塠噢", a_)))
					{
						num = (short)1268121603;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_507;
				case 1:
					this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonBCO_A19777 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.Shepherds.LOVs.indexRadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonBCO_A19777LovStrs, global::Motorola.MackinawCPS.CoreFeatures.Shepherds.LOVs.idRadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonBCO_A19777LovStrs), this, global::AllFeatures.CodeplugGuid.b("鿌껎뗐雒꟔냖뛘飚믜룞닠諢苤触裨蟪ꓬ臮闰雲藴鋶韸鿺飼釾甀匂眄栆洈縊渌笎堐紒焔爖椘縚猜笞䐠䴢儤椦䘨䔪紬崮帰吲䜴嘶吸嘺尼崾ⵀ♂݄㉆㵈㽊≌ⅎፐၒᩔࡖᡘ橚摜桞噠呢", a_), global::CommonResources.AcgResources.ID_BCO, global::Motorola.MackinawCPS.CoreFeatures.Shepherds.LOVs.RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonBCO_A19777LovStrs);
					this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonBCO_A19777.IgnoreOnCompare = true;
					this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonBCO_A19777.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonBCO_A19777.DataTransferOrder = -1;
					num = (short)997654532;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_79;
					}
					continue;
				case 3:
					this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonKey_A21195 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("鿌껎뗐雒꟔냖뛘飚믜룞닠諢苤触裨蟪ꓬ臮闰雲藴鋶韸鿺飼釾甀匂眄栆洈縊渌笎堐紒焔爖椘縚猜笞䐠䴢儤椦䘨䔪紬崮帰吲䜴嘶吸嘺尼崾ⵀ♂݄㉆㵈㽊≌ⅎᩐ㙒ⱔࡖᡘ楚汜湞塠噢", a_), global::CommonResources.AcgResources.ID_KEY, 14);
					this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonKey_A21195.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonKey_A21195.DataTransferOrder = -1;
					num = (short)575799311;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_138;
				case 5:
					goto IL_E8;
				case 6:
					this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonShortPressTime = new global::AcpBusinessLayer.AcpSimpleRangeField(255, this, global::AllFeatures.CodeplugGuid.b("鿌껎뗐雒꟔냖뛘飚믜룞닠諢苤触裨蟪ꓬ臮闰雲藴鋶韸鿺飼釾甀匂眄栆洈縊渌笎堐紒焔爖椘縚猜笞䐠䴢儤椦䘨䔪紬崮帰吲䜴嘶吸嘺尼崾ⵀ♂݄㉆㵈㽊≌ⅎɐ㭒㩔╖ⵘ୚⽜㩞በၢㅤ๦Ѩ๪", a_), global::CommonResources.AcgResources.ID_SHORTPRESSTIME, 0, 124, null, null, 0, 50);
					this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonShortPressTime.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonShortPressTime.DataTransferOrder = -1;
					this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonShortPressTime.AddCustomValue(255, global::CommonResources.AcgResources.ID_RADIOWIDE);
					this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonShortPressTime.ShowHexValue = false;
					this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonShortPressTime.ValidateAcrossRecset = true;
					num = (short)17301514;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					if (producerFields != null)
					{
						num = (short)1566113810;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_557;
				case 8:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鿌껎뗐雒꟔냖뛘飚믜룞닠諢苤触裨蟪ꓬ臮闰雲藴鋶韸鿺飼釾甀匂眄栆洈縊渌笎堐紒焔爖椘縚猜笞䐠䴢儤椦䘨䔪紬崮帰吲䜴嘶吸嘺尼崾ⵀ♂݄㉆㵈㽊≌ⅎፐၒᩔࡖᡘ橚摜桞噠呢", a_)))
					{
						num = (short)1699282945;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_138;
				case 9:
					goto IL_3C5;
				case 10:
					goto IL_1F9;
				case 11:
					this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonLongPressTime = new global::AcpBusinessLayer.AcpSimpleRangeField(255, this, global::AllFeatures.CodeplugGuid.b("鿌껎뗐雒꟔냖뛘飚믜룞닠諢苤触裨蟪ꓬ臮闰雲藴鋶韸鿺飼釾甀匂眄栆洈縊渌笎堐紒焔爖椘縚猜笞䐠䴢儤椦䘨䔪紬崮帰吲䜴嘶吸嘺尼崾ⵀ♂݄㉆㵈㽊≌ⅎᵐ㱒㭔ざक़⥚㡜ⱞበ㝢౤੦౨", a_), global::CommonResources.AcgResources.ID_LONGPRESSTIME, 0, 25, null, null, 0, 250);
					this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonLongPressTime.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonLongPressTime.DataTransferOrder = -1;
					this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonLongPressTime.AddCustomValue(255, global::CommonResources.AcgResources.ID_RADIOWIDE);
					this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonLongPressTime.ShowHexValue = false;
					this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonLongPressTime.ValidateAcrossRecset = true;
					num = (short)546242569;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鿌껎뗐雒꟔냖뛘飚믜룞닠諢苤触裨蟪ꓬ臮闰雲藴鋶韸鿺飼釾甀匂眄栆洈縊渌笎堐紒焔爖椘縚猜笞䐠䴢儤椦䘨䔪紬崮帰吲䜴嘶吸嘺尼崾ⵀ♂݄㉆㵈㽊≌ⅎᝐ㙒㑔⍖ⱘ⥚㡜^⁠剢層偦幨卪", a_)))
					{
						num = (short)1289879569;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_E8;
				case 13:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鿌껎뗐雒꟔냖뛘飚믜룞닠諢苤触裨蟪ꓬ臮闰雲藴鋶韸鿺飼釾甀匂眄栆洈縊渌笎堐紒焔爖椘縚猜笞䐠䴢儤椦䘨䔪紬崮帰吲䜴嘶吸嘺尼崾ⵀ♂݄㉆㵈㽊≌ⅎɐ㭒㩔╖ⵘ୚⽜㩞በၢㅤ๦Ѩ๪", a_)))
					{
						num = (short)1186988038;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1F9;
				case 14:
				{
					num = (short)1130126612;
					short num3 = num;
					num = (short)667573524;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_507;
					default:
						num = (short)21430272;
						if (num != 0)
						{
						}
						num = (short)248381447;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 15:
					goto IL_507;
				case 16:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鿌껎뗐雒꟔냖뛘飚믜룞닠諢苤触裨蟪ꓬ臮闰雲藴鋶韸鿺飼釾甀匂眄栆洈縊渌笎堐紒焔爖椘縚猜笞䐠䴢儤椦䘨䔪紬崮帰吲䜴嘶吸嘺尼崾ⵀ♂݄㉆㵈㽊≌ⅎᵐ㱒㭔ざक़⥚㡜ⱞበ㝢౤੦౨", a_)))
					{
						num = (short)1523515403;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_557;
				case 17:
					this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonFeature_A19778 = new global::AcpBusinessLayer.AcpSparseLOVField(45, new global::Motorola.MackinawCPS.CoreFeatures.Shepherds.ModeUpDownSparseConverter(global::Motorola.MackinawCPS.CoreFeatures.Shepherds.LOVs.indexRadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonFeature_A19778LovStrs, global::Motorola.MackinawCPS.CoreFeatures.Shepherds.LOVs.idRadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonFeature_A19778LovStrs), this, global::AllFeatures.CodeplugGuid.b("鿌껎뗐雒꟔냖뛘飚믜룞닠諢苤触裨蟪ꓬ臮闰雲藴鋶韸鿺飼釾甀匂眄栆洈縊渌笎堐紒焔爖椘縚猜笞䐠䴢儤椦䘨䔪紬崮帰吲䜴嘶吸嘺尼崾ⵀ♂݄㉆㵈㽊≌ⅎᝐ㙒㑔⍖ⱘ⥚㡜^⁠剢層偦幨卪", a_), global::CommonResources.AcgResources.ID_FEATURE, global::Motorola.MackinawCPS.CoreFeatures.Shepherds.LOVs.RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonFeature_A19778LovStrs);
					this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonFeature_A19778.IgnoreOnCompare = true;
					this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonFeature_A19778.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonFeature_A19778.DataTransferOrder = -1;
					num = (short)1318715397;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 18:
				{
					num = (short)1536753664;
					short num4 = num;
					num = (short)512425984;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_79:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)116391950;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_E8:
				num = (short)363003917;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_138:
				num = (short)1881866241;
				if (num != 0)
				{
				}
				num = (short)1846673420;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1F9:
				num = (short)1509490704;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_507:
				num = (short)623837192;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_3C5:
			IL_557:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("黌ꛎ뛐뷒듔믖律鋚돜믞蓠鏢胤触跨軪菬鯮퇰ꏲ蟴飶鷸軺黼课℀䨂欄挆氈笊栌愎甐瘒笔挖㤘唚爜焞ఠ猢圤䠦丨太䰬䈮尰刲圴嬶尸ᬺ缼䨾㕀㝂⩄⥆楈݊⑌㱎═", a_);
			base.Id = 10032;
			base.UIName = global::CommonResources.AcgResources.ID_SIGNALINDEPENDENTPRODUCTINDEPENDENTNONPROGRAMMABLEBUTTONLIST;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06005445 RID: 21573 RVA: 0x004C9F40 File Offset: 0x004C8140
		public override void PopulateReferences()
		{
			short num = (short)15007744;
			short num2 = num;
			num = (short)1613206493;
			short num3 = num;
			num = (short)2120455133;
			switch (num3 == num)
			{
			}
			num = (short)1629880321;
			if (num != 0)
			{
			}
			num = (short)286720000;
			if (num != 0)
			{
			}
		}

		// Token: 0x06005446 RID: 21574 RVA: 0x004C9FE8 File Offset: 0x004C81E8
		public override void DropReferences()
		{
			short num = (short)1365966848;
			short num2 = num;
			num = (short)740619914;
			short num3 = num;
			num = (short)82769546;
			switch (num3 == num)
			{
			}
			num = (short)2043871233;
			if (num != 0)
			{
			}
			num = (short)1841364992;
			if (num != 0)
			{
			}
		}

		// Token: 0x06005447 RID: 21575 RVA: 0x004CA094 File Offset: 0x004C8294
		public override void SetConstraints()
		{
			short num = (short)1991180288;
			short num2 = num;
			num = (short)924638975;
			short num3 = num;
			num = (short)65003263;
			switch (num3 == num)
			{
			}
			num = (short)1928331264;
			if (num != 0)
			{
			}
			num = (short)1555103745;
			if (num != 0)
			{
			}
		}

		// Token: 0x06005448 RID: 21576 RVA: 0x004CA140 File Offset: 0x004C8340
		public override void SetupDependencies()
		{
			short num = (short)989396992;
			short num2 = num;
			num = (short)533124437;
			short num3 = num;
			num = (short)486004053;
			switch (num3 == num)
			{
			}
			num = (short)129761281;
			if (num != 0)
			{
			}
			num = (short)2009268224;
			if (num != 0)
			{
			}
		}

		// Token: 0x17002B85 RID: 11141
		// (get) Token: 0x06005449 RID: 21577 RVA: 0x004CA1E8 File Offset: 0x004C83E8
		public bool HasDiffs
		{
			get
			{
				short num = (short)969277440;
				short num2 = num;
				num = (short)1627923518;
				short num3 = num;
				num = (short)1310336062;
				switch (num3 == num)
				{
				}
				num = (short)1815150593;
				if (num != 0)
				{
				}
				num = (short)2026504192;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17002B86 RID: 11142
		// (get) Token: 0x0600544A RID: 21578 RVA: 0x004CA298 File Offset: 0x004C8498
		// (set) Token: 0x0600544B RID: 21579 RVA: 0x004CA34C File Offset: 0x004C854C
		public string RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonKey_A21195Value
		{
			get
			{
				short num = (short)979697664;
				short num2 = num;
				num = (short)1893964963;
				short num3 = num;
				num = (short)1717148835;
				switch (num3 == num)
				{
				}
				num = (short)936509440;
				if (num != 0)
				{
				}
				num = (short)94240769;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonKey_A21195.Value;
			}
			set
			{
				short num = (short)458948609;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_E9;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_30;
						}
						continue;
					case 2:
						this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonKey_A21195.Value = value;
						goto IL_D2;
					}
					IL_30:
					num = (short)365949868;
					short num3 = num;
					num = (short)581104556;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_D2:
						num = (short)2095382528;
						num2 = (int)((global::System.IntPtr)num);
						break;
					default:
						num = (short)1085472768;
						if (num != 0)
						{
						}
						num = (short)1745420289;
						if (num != 0)
						{
						}
						if (string.IsNullOrEmpty(value.Trim()))
						{
							return;
						}
						num = (short)179634178;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				IL_E9:
				num = (short)2005008384;
				short num4 = num;
			}
		}

		// Token: 0x17002B87 RID: 11143
		// (get) Token: 0x0600544C RID: 21580 RVA: 0x004CA470 File Offset: 0x004C8670
		// (set) Token: 0x0600544D RID: 21581 RVA: 0x004CA524 File Offset: 0x004C8724
		public string RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonKey_A21195_UIValue
		{
			get
			{
				short num = (short)2030698497;
				if (num != 0)
				{
				}
				num = (short)1515388928;
				short num2 = num;
				num = (short)606883300;
				short num3 = num;
				num = (short)1623936484;
				switch (num3 == num)
				{
				}
				num = (short)648478720;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonKey_A21195.Value;
			}
			set
			{
				short num = (short)956050942;
				short num2 = num;
				num = (short)1680092670;
				switch (num2 == num)
				{
				default:
				{
					num = (short)625410048;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2076704768;
				if (num != 0)
				{
				}
				num = (short)288686081;
				if (num != 0)
				{
				}
				this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonKey_A21195.Value = value;
			}
		}

		// Token: 0x17002B88 RID: 11144
		// (get) Token: 0x0600544E RID: 21582 RVA: 0x004CA5D8 File Offset: 0x004C87D8
		public global::AcpBusinessLayer.AcpKeyField RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonKey_A21195
		{
			get
			{
				short num = (short)770021066;
				short num2 = num;
				num = (short)802854602;
				switch (num2 == num)
				{
				default:
				{
					num = (short)800784384;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)294649857;
				if (num != 0)
				{
				}
				num = (short)706150400;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonKey_A21195;
			}
		}

		// Token: 0x17002B89 RID: 11145
		// (get) Token: 0x0600544F RID: 21583 RVA: 0x004CA688 File Offset: 0x004C8888
		// (set) Token: 0x06005450 RID: 21584 RVA: 0x004CA740 File Offset: 0x004C8940
		public bool RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonKey_A21195_Applicable
		{
			get
			{
				short num = (short)727708464;
				short num2 = num;
				num = (short)624292656;
				switch (num2 == num)
				{
				default:
				{
					num = (short)652738560;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1364525057;
				if (num != 0)
				{
				}
				num = (short)779878400;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonKey_A21195.Applicable;
			}
			set
			{
				short num = (short)1254877357;
				short num2 = num;
				num = (short)634972333;
				switch (num2 == num)
				{
				default:
				{
					num = (short)698744832;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)317718528;
				if (num != 0)
				{
				}
				num = (short)763625473;
				if (num != 0)
				{
				}
				this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonKey_A21195.Applicable = value;
			}
		}

		// Token: 0x17002B8A RID: 11146
		// (get) Token: 0x06005451 RID: 21585 RVA: 0x004CA7F8 File Offset: 0x004C89F8
		// (set) Token: 0x06005452 RID: 21586 RVA: 0x004CA8AC File Offset: 0x004C8AAC
		public bool RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonKey_A21195_Valid
		{
			get
			{
				short num = (short)139197829;
				short num2 = num;
				num = (short)832044421;
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
				num = (short)85917697;
				if (num != 0)
				{
				}
				num = (short)486604800;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonKey_A21195.Valid;
			}
			set
			{
				short num = (short)63351499;
				short num2 = num;
				num = (short)1932634827;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2048196608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)321388545;
				if (num != 0)
				{
				}
				num = (short)1718353920;
				if (num != 0)
				{
				}
				this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonKey_A21195.Valid = value;
			}
		}

		// Token: 0x17002B8B RID: 11147
		// (get) Token: 0x06005453 RID: 21587 RVA: 0x004CA960 File Offset: 0x004C8B60
		// (set) Token: 0x06005454 RID: 21588 RVA: 0x004CAA14 File Offset: 0x004C8C14
		public bool RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonKey_A21195_Visible
		{
			get
			{
				short num = (short)406476635;
				short num2 = num;
				num = (short)634935131;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1873018880;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2092630017;
				if (num != 0)
				{
				}
				num = (short)1784020992;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonKey_A21195.Visible;
			}
			set
			{
				short num = (short)502517345;
				short num2 = num;
				num = (short)6082145;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1348599808;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)355598337;
				if (num != 0)
				{
				}
				num = (short)297795584;
				if (num != 0)
				{
				}
				this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonKey_A21195.Visible = value;
			}
		}

		// Token: 0x17002B8C RID: 11148
		// (get) Token: 0x06005455 RID: 21589 RVA: 0x004CAACC File Offset: 0x004C8CCC
		// (set) Token: 0x06005456 RID: 21590 RVA: 0x004CAB80 File Offset: 0x004C8D80
		public bool RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonKey_A21195_Editable
		{
			get
			{
				short num = (short)44422525;
				short num2 = num;
				num = (short)1387320701;
				switch (num2 == num)
				{
				default:
				{
					num = (short)291766272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1469841409;
				if (num != 0)
				{
				}
				num = (short)1081409536;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonKey_A21195.Editable;
			}
			set
			{
				short num = (short)1754053100;
				short num2 = num;
				num = (short)795720172;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1720778752;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1866268673;
				if (num != 0)
				{
				}
				num = (short)626589696;
				if (num != 0)
				{
				}
				this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonKey_A21195.Editable = value;
			}
		}

		// Token: 0x17002B8D RID: 11149
		// (get) Token: 0x06005457 RID: 21591 RVA: 0x004CAC38 File Offset: 0x004C8E38
		internal string RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonKey_A21195_UILabel
		{
			get
			{
				short num = (short)467992577;
				if (num != 0)
				{
				}
				num = (short)934477824;
				short num2 = num;
				num = (short)203919959;
				short num3 = num;
				num = (short)922587735;
				switch (num3 == num)
				{
				}
				num = (short)304480256;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonKey_A21195.UIName;
			}
		}

		// Token: 0x17002B8E RID: 11150
		// (get) Token: 0x06005458 RID: 21592 RVA: 0x004CACEC File Offset: 0x004C8EEC
		// (set) Token: 0x06005459 RID: 21593 RVA: 0x004CADA4 File Offset: 0x004C8FA4
		internal bool RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonKey_A21195_HiddenStatic
		{
			get
			{
				short num = (short)1618618452;
				short num2 = num;
				num = (short)2113939540;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1102970880;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1009582080;
				if (num != 0)
				{
				}
				num = (short)2089877505;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonKey_A21195.HiddenStatic;
			}
			set
			{
				short num = (short)521932596;
				short num2 = num;
				num = (short)902041396;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1020395520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1979121665;
				if (num != 0)
				{
				}
				num = (short)1000013824;
				if (num != 0)
				{
				}
				this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonKey_A21195.HiddenStatic = value;
			}
		}

		// Token: 0x17002B8F RID: 11151
		// (get) Token: 0x0600545A RID: 21594 RVA: 0x004CAE5C File Offset: 0x004C905C
		// (set) Token: 0x0600545B RID: 21595 RVA: 0x004CAF14 File Offset: 0x004C9114
		internal bool RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonKey_A21195_HiddenDynamic
		{
			get
			{
				short num = (short)1568216161;
				short num2 = num;
				num = (short)1994003553;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1009188864;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)179568641;
				if (num != 0)
				{
				}
				num = (short)1613299712;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonKey_A21195.HiddenDynamic;
			}
			set
			{
				short num = (short)1527250945;
				if (num != 0)
				{
				}
				num = (short)957022208;
				short num2 = num;
				num = (short)201191738;
				short num3 = num;
				num = (short)1754657082;
				switch (num3 == num)
				{
				}
				num = (short)1396768768;
				if (num != 0)
				{
				}
				this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonKey_A21195.HiddenDynamic = value;
			}
		}

		// Token: 0x17002B90 RID: 11152
		// (get) Token: 0x0600545C RID: 21596 RVA: 0x004CAFCC File Offset: 0x004C91CC
		public bool RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonKey_A21195_HasDiffs
		{
			get
			{
				short num = (short)422110759;
				short num2 = num;
				num = (short)366732839;
				switch (num2 == num)
				{
				default:
				{
					num = (short)10354688;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)385220608;
				if (num != 0)
				{
				}
				num = (short)521338881;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonKey_A21195._HasDiffs;
			}
		}

		// Token: 0x17002B91 RID: 11153
		// (get) Token: 0x0600545D RID: 21597 RVA: 0x004CB084 File Offset: 0x004C9284
		// (set) Token: 0x0600545E RID: 21598 RVA: 0x004CB13C File Offset: 0x004C933C
		public int RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonBCO_A19777Value
		{
			get
			{
				short num = (short)263176185;
				short num2 = num;
				num = (short)556122105;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1944059904;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1532166144;
				if (num != 0)
				{
				}
				num = (short)505151489;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonBCO_A19777.Value;
			}
			set
			{
				short num = (short)1895673228;
				short num2 = num;
				num = (short)1007070604;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1594818560;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)622067713;
				if (num != 0)
				{
				}
				num = (short)340262912;
				if (num != 0)
				{
				}
				this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonBCO_A19777.Value = value;
			}
		}

		// Token: 0x17002B92 RID: 11154
		// (get) Token: 0x0600545F RID: 21599 RVA: 0x004CB1F4 File Offset: 0x004C93F4
		// (set) Token: 0x06005460 RID: 21600 RVA: 0x004CB2A8 File Offset: 0x004C94A8
		public string RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonBCO_A19777_UIValue
		{
			get
			{
				short num = (short)1806382467;
				short num2 = num;
				num = (short)1946629507;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1394802688;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)922746880;
				if (num != 0)
				{
				}
				num = (short)286326785;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonBCO_A19777.UIValue;
			}
			set
			{
				short num = (short)1393717916;
				short num2 = num;
				num = (short)950694556;
				switch (num2 == num)
				{
				default:
				{
					num = (short)849608704;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1727004672;
				if (num != 0)
				{
				}
				num = (short)1130299393;
				if (num != 0)
				{
				}
				this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonBCO_A19777.UIValue = value;
			}
		}

		// Token: 0x17002B93 RID: 11155
		// (get) Token: 0x06005461 RID: 21601 RVA: 0x004CB360 File Offset: 0x004C9560
		public global::AcpBusinessLayer.AcpListField RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonBCO_A19777
		{
			get
			{
				short num = (short)1054924158;
				short num2 = num;
				num = (short)1192091006;
				switch (num2 == num)
				{
				default:
				{
					num = (short)262144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1032912896;
				if (num != 0)
				{
				}
				num = (short)555548673;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonBCO_A19777;
			}
		}

		// Token: 0x17002B94 RID: 11156
		// (get) Token: 0x06005462 RID: 21602 RVA: 0x004CB410 File Offset: 0x004C9610
		// (set) Token: 0x06005463 RID: 21603 RVA: 0x004CB4C4 File Offset: 0x004C96C4
		public bool RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonBCO_A19777_Applicable
		{
			get
			{
				short num = (short)1054924854;
				short num2 = num;
				num = (short)1127407670;
				switch (num2 == num)
				{
				default:
				{
					num = (short)575406080;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1855520769;
				if (num != 0)
				{
				}
				num = (short)239403008;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonBCO_A19777.Applicable;
			}
			set
			{
				short num = (short)1811098517;
				short num2 = num;
				num = (short)1681009557;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1637482496;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)708313089;
				if (num != 0)
				{
				}
				num = (short)723255296;
				if (num != 0)
				{
				}
				this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonBCO_A19777.Applicable = value;
			}
		}

		// Token: 0x17002B95 RID: 11157
		// (get) Token: 0x06005464 RID: 21604 RVA: 0x004CB57C File Offset: 0x004C977C
		// (set) Token: 0x06005465 RID: 21605 RVA: 0x004CB62C File Offset: 0x004C982C
		public bool RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonBCO_A19777_Valid
		{
			get
			{
				short num = (short)2069299201;
				if (num != 0)
				{
				}
				num = (short)529530880;
				short num2 = num;
				num = (short)201803677;
				short num3 = num;
				num = (short)174213021;
				switch (num3 == num)
				{
				}
				num = (short)1038680064;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonBCO_A19777.Valid;
			}
			set
			{
				short num = (short)750812074;
				short num2 = num;
				num = (short)457276330;
				switch (num2 == num)
				{
				default:
				{
					num = (short)874381312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1272053761;
				if (num != 0)
				{
				}
				num = (short)1017708544;
				if (num != 0)
				{
				}
				this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonBCO_A19777.Valid = value;
			}
		}

		// Token: 0x17002B96 RID: 11158
		// (get) Token: 0x06005466 RID: 21606 RVA: 0x004CB6E0 File Offset: 0x004C98E0
		// (set) Token: 0x06005467 RID: 21607 RVA: 0x004CB794 File Offset: 0x004C9994
		public bool RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonBCO_A19777_Visible
		{
			get
			{
				short num = (short)1705404081;
				short num2 = num;
				num = (short)2026792625;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1899757568;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)720437248;
				if (num != 0)
				{
				}
				num = (short)807469057;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonBCO_A19777.Visible;
			}
			set
			{
				short num = (short)1876313753;
				short num2 = num;
				num = (short)312755865;
				switch (num2 == num)
				{
				default:
				{
					num = (short)409796608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1422393344;
				if (num != 0)
				{
				}
				num = (short)1305542657;
				if (num != 0)
				{
				}
				this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonBCO_A19777.Visible = value;
			}
		}

		// Token: 0x17002B97 RID: 11159
		// (get) Token: 0x06005468 RID: 21608 RVA: 0x004CB84C File Offset: 0x004C9A4C
		// (set) Token: 0x06005469 RID: 21609 RVA: 0x004CB900 File Offset: 0x004C9B00
		public bool RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonBCO_A19777_Editable
		{
			get
			{
				short num = (short)1468921145;
				short num2 = num;
				num = (short)2134897977;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1474101248;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1219493889;
				if (num != 0)
				{
				}
				num = (short)1888944128;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonBCO_A19777.Editable;
			}
			set
			{
				short num = (short)80236409;
				short num2 = num;
				num = (short)1803046777;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1658650624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2075525121;
				if (num != 0)
				{
				}
				num = (short)1588920320;
				if (num != 0)
				{
				}
				this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonBCO_A19777.Editable = value;
			}
		}

		// Token: 0x17002B98 RID: 11160
		// (get) Token: 0x0600546A RID: 21610 RVA: 0x004CB9B8 File Offset: 0x004C9BB8
		internal string RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonBCO_A19777_UILabel
		{
			get
			{
				short num = (short)735644003;
				short num2 = num;
				num = (short)798755171;
				switch (num2 == num)
				{
				default:
				{
					num = (short)825425920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2126053377;
				if (num != 0)
				{
				}
				num = (short)1721434112;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonBCO_A19777.UIName;
			}
		}

		// Token: 0x17002B99 RID: 11161
		// (get) Token: 0x0600546B RID: 21611 RVA: 0x004CBA6C File Offset: 0x004C9C6C
		// (set) Token: 0x0600546C RID: 21612 RVA: 0x004CBB20 File Offset: 0x004C9D20
		internal bool RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonBCO_A19777_HiddenStatic
		{
			get
			{
				short num = (short)1411776513;
				if (num != 0)
				{
				}
				num = (short)1539112960;
				short num2 = num;
				num = (short)2012519580;
				short num3 = num;
				num = (short)1248173212;
				switch (num3 == num)
				{
				}
				num = (short)1184104448;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonBCO_A19777.HiddenStatic;
			}
			set
			{
				short num = (short)373234767;
				short num2 = num;
				num = (short)1098587215;
				switch (num2 == num)
				{
				default:
				{
					num = (short)815661056;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)682491904;
				if (num != 0)
				{
				}
				num = (short)1661075457;
				if (num != 0)
				{
				}
				this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonBCO_A19777.HiddenStatic = value;
			}
		}

		// Token: 0x17002B9A RID: 11162
		// (get) Token: 0x0600546D RID: 21613 RVA: 0x004CBBD4 File Offset: 0x004C9DD4
		// (set) Token: 0x0600546E RID: 21614 RVA: 0x004CBC88 File Offset: 0x004C9E88
		internal bool RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonBCO_A19777_HiddenDynamic
		{
			get
			{
				short num = (short)1486969211;
				short num2 = num;
				num = (short)1533041019;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1199112192;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1160314881;
				if (num != 0)
				{
				}
				num = (short)1753350144;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonBCO_A19777.HiddenDynamic;
			}
			set
			{
				short num = (short)657260545;
				if (num != 0)
				{
				}
				num = (short)1519255552;
				short num2 = num;
				num = (short)1549749084;
				short num3 = num;
				num = (short)1519209308;
				switch (num3 == num)
				{
				}
				num = (short)1040252928;
				if (num != 0)
				{
				}
				this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonBCO_A19777.HiddenDynamic = value;
			}
		}

		// Token: 0x17002B9B RID: 11163
		// (get) Token: 0x0600546F RID: 21615 RVA: 0x004CBD3C File Offset: 0x004C9F3C
		public bool RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonBCO_A19777_HasDiffs
		{
			get
			{
				short num = (short)2078367769;
				short num2 = num;
				num = (short)1590976537;
				switch (num2 == num)
				{
				default:
				{
					num = (short)248709120;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1220214785;
				if (num != 0)
				{
				}
				num = (short)1910505472;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonBCO_A19777._HasDiffs;
			}
		}

		// Token: 0x17002B9C RID: 11164
		// (get) Token: 0x06005470 RID: 21616 RVA: 0x004CBDEC File Offset: 0x004C9FEC
		// (set) Token: 0x06005471 RID: 21617 RVA: 0x004CBEA0 File Offset: 0x004CA0A0
		public int RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonFeature_A19778Value
		{
			get
			{
				short num = (short)1719723296;
				short num2 = num;
				num = (short)684320032;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2046164992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1974468609;
				if (num != 0)
				{
				}
				num = (short)1507917824;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonFeature_A19778.Value;
			}
			set
			{
				short num = (short)1956380673;
				if (num != 0)
				{
				}
				num = (short)613613568;
				short num2 = num;
				num = (short)1735148066;
				short num3 = num;
				num = (short)245318178;
				switch (num3 == num)
				{
				}
				num = (short)1205862400;
				if (num != 0)
				{
				}
				this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonFeature_A19778.Value = value;
			}
		}

		// Token: 0x17002B9D RID: 11165
		// (get) Token: 0x06005472 RID: 21618 RVA: 0x004CBF54 File Offset: 0x004CA154
		// (set) Token: 0x06005473 RID: 21619 RVA: 0x004CC00C File Offset: 0x004CA20C
		public string RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonFeature_A19778_UIValue
		{
			get
			{
				short num = (short)752990219;
				short num2 = num;
				num = (short)313047051;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1236795392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2129133569;
				if (num != 0)
				{
				}
				num = (short)1773273088;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonFeature_A19778.UIValue;
			}
			set
			{
				short num = (short)1515325693;
				short num2 = num;
				num = (short)1297025277;
				switch (num2 == num)
				{
				default:
				{
					num = (short)543490048;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)400359425;
				if (num != 0)
				{
				}
				num = (short)917438464;
				if (num != 0)
				{
				}
				this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonFeature_A19778.UIValue = value;
			}
		}

		// Token: 0x17002B9E RID: 11166
		// (get) Token: 0x06005474 RID: 21620 RVA: 0x004CC0C4 File Offset: 0x004CA2C4
		public global::AcpBusinessLayer.AcpListField RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonFeature_A19778
		{
			get
			{
				short num = (short)1398029632;
				short num2 = num;
				num = (short)1643658560;
				switch (num2 == num)
				{
				default:
				{
					num = (short)29229056;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1746337792;
				if (num != 0)
				{
				}
				num = (short)383123457;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonFeature_A19778;
			}
		}

		// Token: 0x17002B9F RID: 11167
		// (get) Token: 0x06005475 RID: 21621 RVA: 0x004CC178 File Offset: 0x004CA378
		// (set) Token: 0x06005476 RID: 21622 RVA: 0x004CC22C File Offset: 0x004CA42C
		public bool RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonFeature_A19778_Applicable
		{
			get
			{
				short num = (short)770643;
				short num2 = num;
				num = (short)1438302803;
				switch (num2 == num)
				{
				default:
				{
					num = (short)942800896;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)69533697;
				if (num != 0)
				{
				}
				num = (short)1069547520;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonFeature_A19778.Applicable;
			}
			set
			{
				short num = (short)1425893982;
				short num2 = num;
				num = (short)1218996830;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1195311104;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)803536897;
				if (num != 0)
				{
				}
				num = (short)953876480;
				if (num != 0)
				{
				}
				this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonFeature_A19778.Applicable = value;
			}
		}

		// Token: 0x17002BA0 RID: 11168
		// (get) Token: 0x06005477 RID: 21623 RVA: 0x004CC2E0 File Offset: 0x004CA4E0
		// (set) Token: 0x06005478 RID: 21624 RVA: 0x004CC398 File Offset: 0x004CA598
		public bool RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonFeature_A19778_Valid
		{
			get
			{
				short num = (short)1737522941;
				short num2 = num;
				num = (short)1383628541;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1378877440;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)578420737;
				if (num != 0)
				{
				}
				num = (short)44761088;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonFeature_A19778.Valid;
			}
			set
			{
				short num = (short)1688980237;
				short num2 = num;
				num = (short)236964621;
				switch (num2 == num)
				{
				default:
				{
					num = (short)325648384;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)418971648;
				if (num != 0)
				{
				}
				num = (short)1526071297;
				if (num != 0)
				{
				}
				this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonFeature_A19778.Valid = value;
			}
		}

		// Token: 0x17002BA1 RID: 11169
		// (get) Token: 0x06005479 RID: 21625 RVA: 0x004CC44C File Offset: 0x004CA64C
		// (set) Token: 0x0600547A RID: 21626 RVA: 0x004CC504 File Offset: 0x004CA704
		public bool RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonFeature_A19778_Visible
		{
			get
			{
				short num = (short)1163526145;
				if (num != 0)
				{
				}
				num = (short)1981808640;
				short num2 = num;
				num = (short)619372820;
				short num3 = num;
				num = (short)857923860;
				switch (num3 == num)
				{
				}
				num = (short)1684078592;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonFeature_A19778.Visible;
			}
			set
			{
				short num = (short)730437579;
				short num2 = num;
				num = (short)266835915;
				switch (num2 == num)
				{
				default:
				{
					num = (short)315686912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1211301888;
				if (num != 0)
				{
				}
				num = (short)917307393;
				if (num != 0)
				{
				}
				this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonFeature_A19778.Visible = value;
			}
		}

		// Token: 0x17002BA2 RID: 11170
		// (get) Token: 0x0600547B RID: 21627 RVA: 0x004CC5B8 File Offset: 0x004CA7B8
		// (set) Token: 0x0600547C RID: 21628 RVA: 0x004CC66C File Offset: 0x004CA86C
		public bool RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonFeature_A19778_Editable
		{
			get
			{
				short num = (short)1301237215;
				short num2 = num;
				num = (short)2091929055;
				switch (num2 == num)
				{
				default:
				{
					num = (short)890830848;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1814364160;
				if (num != 0)
				{
				}
				num = (short)569507841;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonFeature_A19778.Editable;
			}
			set
			{
				short num = (short)579633020;
				short num2 = num;
				num = (short)1621917564;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1013579776;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)678690817;
				if (num != 0)
				{
				}
				num = (short)381353984;
				if (num != 0)
				{
				}
				this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonFeature_A19778.Editable = value;
			}
		}

		// Token: 0x17002BA3 RID: 11171
		// (get) Token: 0x0600547D RID: 21629 RVA: 0x004CC720 File Offset: 0x004CA920
		internal string RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonFeature_A19778_UILabel
		{
			get
			{
				short num = (short)588711247;
				short num2 = num;
				num = (short)1521157455;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1313472512;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2053636097;
				if (num != 0)
				{
				}
				num = (short)374341632;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonFeature_A19778.UIName;
			}
		}

		// Token: 0x17002BA4 RID: 11172
		// (get) Token: 0x0600547E RID: 21630 RVA: 0x004CC7D4 File Offset: 0x004CA9D4
		// (set) Token: 0x0600547F RID: 21631 RVA: 0x004CC888 File Offset: 0x004CAA88
		internal bool RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonFeature_A19778_HiddenStatic
		{
			get
			{
				short num = (short)1691285719;
				short num2 = num;
				num = (short)489617623;
				switch (num2 == num)
				{
				}
				num = (short)1508114432;
				short num3 = num;
				num = (short)137232384;
				if (num != 0)
				{
				}
				num = (short)410386433;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonFeature_A19778.HiddenStatic;
			}
			set
			{
				short num = (short)763368795;
				short num2 = num;
				num = (short)902698331;
				switch (num2 == num)
				{
				}
				num = (short)2126118912;
				short num3 = num;
				num = (short)235732993;
				if (num != 0)
				{
				}
				num = (short)620756992;
				if (num != 0)
				{
				}
				this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonFeature_A19778.HiddenStatic = value;
			}
		}

		// Token: 0x17002BA5 RID: 11173
		// (get) Token: 0x06005480 RID: 21632 RVA: 0x004CC940 File Offset: 0x004CAB40
		// (set) Token: 0x06005481 RID: 21633 RVA: 0x004CC9F4 File Offset: 0x004CABF4
		internal bool RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonFeature_A19778_HiddenDynamic
		{
			get
			{
				short num = (short)1654224561;
				short num2 = num;
				num = (short)1239512753;
				switch (num2 == num)
				{
				}
				num = (short)2055012352;
				short num3 = num;
				num = (short)1657864192;
				if (num != 0)
				{
				}
				num = (short)527106049;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonFeature_A19778.HiddenDynamic;
			}
			set
			{
				short num = (short)1561683743;
				short num2 = num;
				num = (short)7300895;
				switch (num2 == num)
				{
				}
				num = (short)1367867392;
				short num3 = num;
				num = (short)1308164096;
				if (num != 0)
				{
				}
				num = (short)912064513;
				if (num != 0)
				{
				}
				this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonFeature_A19778.HiddenDynamic = value;
			}
		}

		// Token: 0x17002BA6 RID: 11174
		// (get) Token: 0x06005482 RID: 21634 RVA: 0x004CCAA8 File Offset: 0x004CACA8
		public bool RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonFeature_A19778_HasDiffs
		{
			get
			{
				short num = (short)408912143;
				short num2 = num;
				num = (short)1820819727;
				switch (num2 == num)
				{
				}
				num = (short)16187392;
				short num3 = num;
				num = (short)1326055424;
				if (num != 0)
				{
				}
				num = (short)802750465;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonFeature_A19778._HasDiffs;
			}
		}

		// Token: 0x17002BA7 RID: 11175
		// (get) Token: 0x06005483 RID: 21635 RVA: 0x004CCB60 File Offset: 0x004CAD60
		// (set) Token: 0x06005484 RID: 21636 RVA: 0x004CCC14 File Offset: 0x004CAE14
		public int RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonShortPressTimeValue
		{
			get
			{
				short num = (short)32141413;
				short num2 = num;
				num = (short)977694821;
				switch (num2 == num)
				{
				}
				num = (short)1741815808;
				short num3 = num;
				num = (short)2019819521;
				if (num != 0)
				{
				}
				num = (short)163184640;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonShortPressTime.Value;
			}
			set
			{
				short num = (short)1188974024;
				short num2 = num;
				num = (short)894193096;
				switch (num2 == num)
				{
				}
				num = (short)304742400;
				short num3 = num;
				num = (short)336658433;
				if (num != 0)
				{
				}
				num = (short)1715142656;
				if (num != 0)
				{
				}
				this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonShortPressTime.Value = value;
			}
		}

		// Token: 0x17002BA8 RID: 11176
		// (get) Token: 0x06005485 RID: 21637 RVA: 0x004CCCC8 File Offset: 0x004CAEC8
		// (set) Token: 0x06005486 RID: 21638 RVA: 0x004CCD7C File Offset: 0x004CAF7C
		public string RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonShortPressTime_UIValue
		{
			get
			{
				short num = (short)1566927669;
				short num2 = num;
				num = (short)1269263157;
				switch (num2 == num)
				{
				}
				num = (short)627179520;
				short num3 = num;
				num = (short)1492779009;
				if (num != 0)
				{
				}
				num = (short)895746048;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonShortPressTime.UIValue;
			}
			set
			{
				short num = (short)272673682;
				short num2 = num;
				num = (short)940092306;
				switch (num2 == num)
				{
				}
				num = (short)1243086848;
				short num3 = num;
				num = (short)1133445121;
				if (num != 0)
				{
				}
				num = (short)805109760;
				if (num != 0)
				{
				}
				this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonShortPressTime.UIValue = value;
			}
		}

		// Token: 0x17002BA9 RID: 11177
		// (get) Token: 0x06005487 RID: 21639 RVA: 0x004CCE30 File Offset: 0x004CB030
		public global::AcpBusinessLayer.AcpSimpleRangeField RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonShortPressTime
		{
			get
			{
				short num = (short)659975426;
				short num2 = num;
				num = (short)1488874754;
				switch (num2 == num)
				{
				}
				num = (short)1300299776;
				short num3 = num;
				num = (short)1161953281;
				if (num != 0)
				{
				}
				num = (short)1348665344;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonShortPressTime;
			}
		}

		// Token: 0x17002BAA RID: 11178
		// (get) Token: 0x06005488 RID: 21640 RVA: 0x004CCEE0 File Offset: 0x004CB0E0
		// (set) Token: 0x06005489 RID: 21641 RVA: 0x004CCF94 File Offset: 0x004CB194
		public bool RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonShortPressTime_Applicable
		{
			get
			{
				short num = (short)1664784083;
				short num2 = num;
				num = (short)832476883;
				switch (num2 == num)
				{
				}
				num = (short)956104704;
				short num3 = num;
				num = (short)950206465;
				if (num != 0)
				{
				}
				num = (short)145686528;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonShortPressTime.Applicable;
			}
			set
			{
				short num = (short)293364786;
				short num2 = num;
				num = (short)1737843762;
				switch (num2 == num)
				{
				}
				num = (short)2095513600;
				short num3 = num;
				num = (short)627703809;
				if (num != 0)
				{
				}
				num = (short)1632305152;
				if (num != 0)
				{
				}
				this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonShortPressTime.Applicable = value;
			}
		}

		// Token: 0x17002BAB RID: 11179
		// (get) Token: 0x0600548A RID: 21642 RVA: 0x004CD048 File Offset: 0x004CB248
		// (set) Token: 0x0600548B RID: 21643 RVA: 0x004CD100 File Offset: 0x004CB300
		public bool RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonShortPressTime_Valid
		{
			get
			{
				short num = (short)1760231425;
				if (num != 0)
				{
				}
				num = (short)746021410;
				short num2 = num;
				num = (short)1459773986;
				switch (num2 == num)
				{
				default:
				{
					num = (short)579403776;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1128202240;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonShortPressTime.Valid;
			}
			set
			{
				short num = (short)17923815;
				short num2 = num;
				num = (short)136216295;
				switch (num2 == num)
				{
				}
				num = (short)867565568;
				short num3 = num;
				num = (short)1592328193;
				if (num != 0)
				{
				}
				num = (short)1185611776;
				if (num != 0)
				{
				}
				this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonShortPressTime.Valid = value;
			}
		}

		// Token: 0x17002BAC RID: 11180
		// (get) Token: 0x0600548C RID: 21644 RVA: 0x004CD1B8 File Offset: 0x004CB3B8
		// (set) Token: 0x0600548D RID: 21645 RVA: 0x004CD270 File Offset: 0x004CB470
		public bool RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonShortPressTime_Visible
		{
			get
			{
				short num = (short)199150618;
				short num2 = num;
				num = (short)670551066;
				switch (num2 == num)
				{
				}
				num = (short)1712783360;
				short num3 = num;
				num = (short)1062862849;
				if (num != 0)
				{
				}
				num = (short)1705181184;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonShortPressTime.Visible;
			}
			set
			{
				short num = (short)620895568;
				short num2 = num;
				num = (short)464788816;
				switch (num2 == num)
				{
				}
				num = (short)1573519360;
				short num3 = num;
				num = (short)1089667073;
				if (num != 0)
				{
				}
				num = (short)518717440;
				if (num != 0)
				{
				}
				this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonShortPressTime.Visible = value;
			}
		}

		// Token: 0x17002BAD RID: 11181
		// (get) Token: 0x0600548E RID: 21646 RVA: 0x004CD328 File Offset: 0x004CB528
		// (set) Token: 0x0600548F RID: 21647 RVA: 0x004CD3E0 File Offset: 0x004CB5E0
		public bool RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonShortPressTime_Editable
		{
			get
			{
				short num = (short)1160672775;
				short num2 = num;
				num = (short)852456967;
				switch (num2 == num)
				{
				}
				num = (short)446627840;
				short num3 = num;
				num = (short)428146689;
				if (num != 0)
				{
				}
				num = (short)1731854336;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonShortPressTime.Editable;
			}
			set
			{
				short num = (short)1902235352;
				short num2 = num;
				num = (short)546295512;
				switch (num2 == num)
				{
				}
				num = (short)1815085056;
				short num3 = num;
				num = (short)1185087489;
				if (num != 0)
				{
				}
				num = (short)1283129344;
				if (num != 0)
				{
				}
				this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonShortPressTime.Editable = value;
			}
		}

		// Token: 0x17002BAE RID: 11182
		// (get) Token: 0x06005490 RID: 21648 RVA: 0x004CD498 File Offset: 0x004CB698
		internal string RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonShortPressTime_UILabel
		{
			get
			{
				short num = (short)1803469783;
				short num2 = num;
				num = (short)1606206423;
				switch (num2 == num)
				{
				}
				num = (short)1686503424;
				short num3 = num;
				num = (short)1300496385;
				if (num != 0)
				{
				}
				num = (short)1960050688;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonShortPressTime.UIName;
			}
		}

		// Token: 0x17002BAF RID: 11183
		// (get) Token: 0x06005491 RID: 21649 RVA: 0x004CD54C File Offset: 0x004CB74C
		// (set) Token: 0x06005492 RID: 21650 RVA: 0x004CD604 File Offset: 0x004CB804
		internal bool RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonShortPressTime_HiddenStatic
		{
			get
			{
				short num = (short)1361228872;
				short num2 = num;
				num = (short)507425864;
				switch (num2 == num)
				{
				}
				num = (short)170000384;
				short num3 = num;
				num = (short)107675649;
				if (num != 0)
				{
				}
				num = (short)2070609920;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonShortPressTime.HiddenStatic;
			}
			set
			{
				short num = (short)23333914;
				short num2 = num;
				num = (short)1575291930;
				switch (num2 == num)
				{
				}
				num = (short)317521920;
				short num3 = num;
				num = (short)294125568;
				if (num != 0)
				{
				}
				num = (short)1438449665;
				if (num != 0)
				{
				}
				this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonShortPressTime.HiddenStatic = value;
			}
		}

		// Token: 0x17002BB0 RID: 11184
		// (get) Token: 0x06005493 RID: 21651 RVA: 0x004CD6B4 File Offset: 0x004CB8B4
		// (set) Token: 0x06005494 RID: 21652 RVA: 0x004CD768 File Offset: 0x004CB968
		internal bool RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonShortPressTime_HiddenDynamic
		{
			get
			{
				short num = (short)2003018756;
				short num2 = num;
				num = (short)258057220;
				switch (num2 == num)
				{
				}
				num = (short)52822016;
				short num3 = num;
				num = (short)1127350272;
				if (num != 0)
				{
				}
				num = (short)1099104257;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonShortPressTime.HiddenDynamic;
			}
			set
			{
				short num = (short)243468270;
				short num2 = num;
				num = (short)637732846;
				switch (num2 == num)
				{
				}
				num = (short)1237581824;
				short num3 = num;
				num = (short)179830784;
				if (num != 0)
				{
				}
				num = (short)322961409;
				if (num != 0)
				{
				}
				this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonShortPressTime.HiddenDynamic = value;
			}
		}

		// Token: 0x17002BB1 RID: 11185
		// (get) Token: 0x06005495 RID: 21653 RVA: 0x004CD81C File Offset: 0x004CBA1C
		public bool RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonShortPressTime_HasDiffs
		{
			get
			{
				short num = (short)1551672462;
				short num2 = num;
				num = (short)676439182;
				switch (num2 == num)
				{
				}
				num = (short)1840644096;
				short num3 = num;
				num = (short)887488513;
				if (num != 0)
				{
				}
				num = (short)441319424;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonShortPressTime._HasDiffs;
			}
		}

		// Token: 0x17002BB2 RID: 11186
		// (get) Token: 0x06005496 RID: 21654 RVA: 0x004CD8D0 File Offset: 0x004CBAD0
		// (set) Token: 0x06005497 RID: 21655 RVA: 0x004CD984 File Offset: 0x004CBB84
		public int RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonLongPressTimeValue
		{
			get
			{
				short num = (short)1723334657;
				if (num != 0)
				{
				}
				num = (short)121698371;
				short num2 = num;
				num = (short)1167390787;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1907294208;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)543752192;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonLongPressTime.Value;
			}
			set
			{
				short num = (short)1413853256;
				short num2 = num;
				num = (short)1970516040;
				switch (num2 == num)
				{
				}
				num = (short)91291648;
				short num3 = num;
				num = (short)2037121025;
				if (num != 0)
				{
				}
				num = (short)215285760;
				if (num != 0)
				{
				}
				this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonLongPressTime.Value = value;
			}
		}

		// Token: 0x17002BB3 RID: 11187
		// (get) Token: 0x06005498 RID: 21656 RVA: 0x004CDA38 File Offset: 0x004CBC38
		// (set) Token: 0x06005499 RID: 21657 RVA: 0x004CDAEC File Offset: 0x004CBCEC
		public string RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonLongPressTime_UIValue
		{
			get
			{
				short num = (short)861172512;
				short num2 = num;
				num = (short)1850962720;
				switch (num2 == num)
				{
				}
				num = (short)1399193600;
				short num3 = num;
				num = (short)200409089;
				if (num != 0)
				{
				}
				num = (short)702939136;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonLongPressTime.UIValue;
			}
			set
			{
				short num = (short)1499594753;
				if (num != 0)
				{
				}
				num = (short)1342464312;
				short num2 = num;
				num = (short)1008755000;
				switch (num2 == num)
				{
				default:
				{
					num = (short)395837440;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1048313856;
				if (num != 0)
				{
				}
				this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonLongPressTime.UIValue = value;
			}
		}

		// Token: 0x17002BB4 RID: 11188
		// (get) Token: 0x0600549A RID: 21658 RVA: 0x004CDBA0 File Offset: 0x004CBDA0
		public global::AcpBusinessLayer.AcpSimpleRangeField RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonLongPressTime
		{
			get
			{
				short num = (short)591290504;
				short num2 = num;
				num = (short)1539924104;
				switch (num2 == num)
				{
				}
				num = (short)1400373248;
				short num3 = num;
				num = (short)175046656;
				if (num != 0)
				{
				}
				num = (short)247201793;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonLongPressTime;
			}
		}

		// Token: 0x17002BB5 RID: 11189
		// (get) Token: 0x0600549B RID: 21659 RVA: 0x004CDC50 File Offset: 0x004CBE50
		// (set) Token: 0x0600549C RID: 21660 RVA: 0x004CDD04 File Offset: 0x004CBF04
		public bool RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonLongPressTime_Applicable
		{
			get
			{
				short num = (short)1131964040;
				short num2 = num;
				num = (short)922314376;
				switch (num2 == num)
				{
				}
				num = (short)1644953600;
				short num3 = num;
				num = (short)1799356416;
				if (num != 0)
				{
				}
				num = (short)1855324161;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonLongPressTime.Applicable;
			}
			set
			{
				short num = (short)938599390;
				short num2 = num;
				num = (short)2017125342;
				switch (num2 == num)
				{
				}
				num = (short)428670976;
				short num3 = num;
				num = (short)635109377;
				if (num != 0)
				{
				}
				num = (short)1932328960;
				if (num != 0)
				{
				}
				this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonLongPressTime.Applicable = value;
			}
		}

		// Token: 0x17002BB6 RID: 11190
		// (get) Token: 0x0600549D RID: 21661 RVA: 0x004CDDB8 File Offset: 0x004CBFB8
		// (set) Token: 0x0600549E RID: 21662 RVA: 0x004CDE6C File Offset: 0x004CC06C
		public bool RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonLongPressTime_Valid
		{
			get
			{
				short num = (short)1212356818;
				short num2 = num;
				num = (short)1515722962;
				switch (num2 == num)
				{
				}
				num = (short)838664192;
				short num3 = num;
				num = (short)378798080;
				if (num != 0)
				{
				}
				num = (short)510197761;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonLongPressTime.Valid;
			}
			set
			{
				short num = (short)17891329;
				if (num != 0)
				{
				}
				num = (short)258590493;
				short num2 = num;
				num = (short)757778205;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1708326912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1626144768;
				if (num != 0)
				{
				}
				this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonLongPressTime.Valid = value;
			}
		}

		// Token: 0x17002BB7 RID: 11191
		// (get) Token: 0x0600549F RID: 21663 RVA: 0x004CDF20 File Offset: 0x004CC120
		// (set) Token: 0x060054A0 RID: 21664 RVA: 0x004CDFD4 File Offset: 0x004CC1D4
		public bool RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonLongPressTime_Visible
		{
			get
			{
				short num = (short)1595932673;
				if (num != 0)
				{
				}
				num = (short)1217458153;
				short num2 = num;
				num = (short)1423503337;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1042677760;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)782237696;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonLongPressTime.Visible;
			}
			set
			{
				short num = (short)1322997409;
				short num2 = num;
				num = (short)1346197153;
				switch (num2 == num)
				{
				}
				num = (short)59703296;
				short num3 = num;
				num = (short)1615593473;
				if (num != 0)
				{
				}
				num = (short)628097024;
				if (num != 0)
				{
				}
				this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonLongPressTime.Visible = value;
			}
		}

		// Token: 0x17002BB8 RID: 11192
		// (get) Token: 0x060054A1 RID: 21665 RVA: 0x004CE08C File Offset: 0x004CC28C
		// (set) Token: 0x060054A2 RID: 21666 RVA: 0x004CE140 File Offset: 0x004CC340
		public bool RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonLongPressTime_Editable
		{
			get
			{
				short num = (short)193459207;
				short num2 = num;
				num = (short)869594119;
				switch (num2 == num)
				{
				}
				num = (short)1516109824;
				short num3 = num;
				num = (short)507379712;
				if (num != 0)
				{
				}
				num = (short)618135553;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonLongPressTime.Editable;
			}
			set
			{
				short num = (short)582615041;
				if (num != 0)
				{
				}
				num = (short)771761642;
				short num2 = num;
				num = (short)14296554;
				switch (num2 == num)
				{
				default:
				{
					num = (short)900661248;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)54263808;
				if (num != 0)
				{
				}
				this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonLongPressTime.Editable = value;
			}
		}

		// Token: 0x17002BB9 RID: 11193
		// (get) Token: 0x060054A3 RID: 21667 RVA: 0x004CE1F4 File Offset: 0x004CC3F4
		internal string RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonLongPressTime_UILabel
		{
			get
			{
				short num = (short)665629999;
				short num2 = num;
				num = (short)1691268399;
				switch (num2 == num)
				{
				}
				num = (short)678232064;
				short num3 = num;
				num = (short)1073152000;
				if (num != 0)
				{
				}
				num = (short)355663873;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonLongPressTime.UIName;
			}
		}

		// Token: 0x17002BBA RID: 11194
		// (get) Token: 0x060054A4 RID: 21668 RVA: 0x004CE2A8 File Offset: 0x004CC4A8
		// (set) Token: 0x060054A5 RID: 21669 RVA: 0x004CE360 File Offset: 0x004CC560
		internal bool RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonLongPressTime_HiddenStatic
		{
			get
			{
				short num = (short)480565356;
				short num2 = num;
				num = (short)599316588;
				switch (num2 == num)
				{
				}
				num = (short)1656619008;
				short num3 = num;
				num = (short)672071680;
				if (num != 0)
				{
				}
				num = (short)516030465;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonLongPressTime.HiddenStatic;
			}
			set
			{
				short num = (short)1995365111;
				short num2 = num;
				num = (short)2027215607;
				switch (num2 == num)
				{
				}
				num = (short)2113339392;
				short num3 = num;
				num = (short)1753481216;
				if (num != 0)
				{
				}
				num = (short)962527233;
				if (num != 0)
				{
				}
				this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonLongPressTime.HiddenStatic = value;
			}
		}

		// Token: 0x17002BBB RID: 11195
		// (get) Token: 0x060054A6 RID: 21670 RVA: 0x004CE414 File Offset: 0x004CC614
		// (set) Token: 0x060054A7 RID: 21671 RVA: 0x004CE4C8 File Offset: 0x004CC6C8
		internal bool RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonLongPressTime_HiddenDynamic
		{
			get
			{
				short num = (short)1960776272;
				short num2 = num;
				num = (short)1184043600;
				switch (num2 == num)
				{
				}
				num = (short)1429143552;
				short num3 = num;
				num = (short)1572536320;
				if (num != 0)
				{
				}
				num = (short)1609564161;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonLongPressTime.HiddenDynamic;
			}
			set
			{
				short num = (short)641956331;
				short num2 = num;
				num = (short)1812756971;
				switch (num2 == num)
				{
				}
				num = (short)329646080;
				short num3 = num;
				num = (short)2006319105;
				if (num != 0)
				{
				}
				num = (short)2121990144;
				if (num != 0)
				{
				}
				this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonLongPressTime.HiddenDynamic = value;
			}
		}

		// Token: 0x17002BBC RID: 11196
		// (get) Token: 0x060054A8 RID: 21672 RVA: 0x004CE57C File Offset: 0x004CC77C
		public bool RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonLongPressTime_HasDiffs
		{
			get
			{
				short num = (short)752588432;
				short num2 = num;
				num = (short)203593360;
				switch (num2 == num)
				{
				}
				num = (short)1253441536;
				short num3 = num;
				num = (short)1474625537;
				if (num != 0)
				{
				}
				num = (short)868679680;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonLongPressTime._HasDiffs;
			}
		}

		// Token: 0x060054A9 RID: 21673 RVA: 0x004CE630 File Offset: 0x004CC830
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
					goto IL_D2;
				case 1:
					num2 = (short)1547042817;
					if (num2 != 0)
					{
					}
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)1634861060;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 2:
					if (base.ParentRecset != null)
					{
						num2 = (short)1454505987;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 3:
				{
					num2 = (short)2098678537;
					short num3 = num2;
					num2 = (short)887311113;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)896991232;
						if (num2 != 0)
						{
						}
						break;
					}
					num2 = (short)2020540417;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 4:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)493158400;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_24;
			}
			IL_D2:
			num2 = (short)1906835456;
			short num4 = num2;
			return result;
			IL_24:
			result = null;
			num2 = (short)563085314;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060054AA RID: 21674 RVA: 0x004CE7A4 File Offset: 0x004CC9A4
		private void b(global::System.Runtime.Serialization.SerializationInfo A_0, global::System.Runtime.Serialization.StreamingContext A_1)
		{
			short num = (short)1860923946;
			short num2 = num;
			num = (short)1473737258;
			switch (num2 == num)
			{
			}
			num = (short)1337196544;
			short num3 = num;
			num = (short)348323841;
			if (num != 0)
			{
			}
			num = (short)2100428800;
			if (num != 0)
			{
			}
			this.a(A_0, A_1);
		}

		// Token: 0x060054AB RID: 21675 RVA: 0x004CE854 File Offset: 0x004CCA54
		private void a(global::System.Runtime.Serialization.SerializationInfo A_0, global::System.Runtime.Serialization.StreamingContext A_1)
		{
			int a_ = 5;
			string radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonFeature_A19778_UIValue;
			int radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonBCO_A19777Value;
			short num;
			for (;;)
			{
				radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonFeature_A19778_UIValue = this.RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonFeature_A19778_UIValue;
				radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonBCO_A19777Value = this.RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonBCO_A19777Value;
				if (!global::ConstraintHelper.UtilityMack.IsPortable())
				{
					return;
				}
				num = (short)1273954304;
				short num2 = num;
				num = (short)130406669;
				short num3 = num;
				num = (short)953014541;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_7F;
				}
			}
			IL_7F:
			num = (short)23592961;
			if (num != 0)
			{
			}
			num = (short)1276968960;
			if (num != 0)
			{
			}
			try
			{
				switch (0)
				{
				case 0:
					goto IL_E4;
				}
				int num4;
				string b;
				for (;;)
				{
					IL_C6:
					switch (num4)
					{
					case 0:
						goto IL_1AB;
					case 1:
						this.RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonFeature_A19778Value = 0;
						num = (short)849477637;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						num = (short)1622867972;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonFeature_A19778_UIValue != b)
						{
							num = (short)634388482;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_193;
					case 4:
						if (radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonBCO_A19777Value == 65)
						{
							num = (short)974782465;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_193;
					case 5:
						goto IL_193;
					}
					goto IL_E4;
					IL_193:
					num = (short)945618944;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_1AB:
				return;
				IL_E4:
				b = (string)A_0.GetValue(global::AllFeatures.CodeplugGuid.b("胅귇ꯉ룋믍ꋏ럑", a_), typeof(string));
				num = (short)179568643;
				num4 = (int)((global::System.IntPtr)num);
				goto IL_C6;
			}
			catch (global::System.Exception)
			{
			}
		}

		// Token: 0x04002163 RID: 8547
		private global::AcpBusinessLayer.AcpKeyField radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonKey_A21195;

		// Token: 0x04002164 RID: 8548
		private global::AcpBusinessLayer.AcpListField radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonBCO_A19777;

		// Token: 0x04002165 RID: 8549
		private global::AcpBusinessLayer.AcpListField radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonFeature_A19778;

		// Token: 0x04002166 RID: 8550
		private global::AcpBusinessLayer.AcpSimpleRangeField radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonShortPressTime;

		// Token: 0x04002167 RID: 8551
		private global::AcpBusinessLayer.AcpSimpleRangeField radErgoCfgSignalIndependentProductIndependentNonProgrammableButtonLongPressTime;
	}
}
