using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using Motorola.MackinawCPS.CoreFeatures.RadioInformation;

namespace Motorola.MackinawCPS.CoreFeatures.FactoryOverrides
{
	// Token: 0x02000461 RID: 1121
	[global::System.Serializable]
	public class RxSynthesizerReferenceDividerListInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x060094D9 RID: 38105 RVA: 0x008C1004 File Offset: 0x008BF204
		public RxSynthesizerReferenceDividerListInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x060094DA RID: 38106 RVA: 0x008C1020 File Offset: 0x008BF220
		protected RxSynthesizerReferenceDividerListInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x060094DB RID: 38107 RVA: 0x008C1038 File Offset: 0x008BF238
		public override void Init()
		{
			int a_ = 8;
			short num = (short)367123813;
			short num2 = num;
			num = (short)1298718053;
			switch (num2 == num)
			{
			}
			num = (short)262602752;
			short num3 = num;
			num = (short)1060306945;
			if (num != 0)
			{
			}
			num = (short)373424128;
			if (num != 0)
			{
			}
			this.fctOrdsRxSynthesizerReferenceDividerListRxRefDivMHz_A8925 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("迈꣊만胎ꏐ럒ꛔ藖ꇘ裚ꓜ뇞闠询胤铦胨釪裬鷮ꏰ雲鏴鋶诸黺鏼鳾搀䜂氄焆怈漊栌紎崐稒昔挖䬘挚伜稞䜠朢䰤儦搨挪圬瀮瀰ଲఴԶస", a_), global::CommonResources.AcgResources.ID_RXREFDIVMHZ, global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.LOVs.FctOrdsRxSynthesizerReferenceDividerListRxRefDivMHz_A8925LovStrs);
			this.fctOrdsRxSynthesizerReferenceDividerListRxRefDivMHz_A8925.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.fctOrdsRxSynthesizerReferenceDividerListRxRefDivMHz_A8925.DataTransferOrder = 8;
			this.fctOrdsRxSynthesizerReferenceDividerListRxFreqMHz_A9017 = new global::AcpBusinessLayer.AcpFrequencyField(170205000, this, global::AllFeatures.CodeplugGuid.b("迈꣊만胎ꏐ럒ꛔ藖ꇘ裚ꓜ뇞闠询胤铦胨釪裬鷮ꏰ雲鏴鋶诸黺鏼鳾搀䜂氄焆怈漊栌紎崐稒昔挖䬘挚嬜洞䐠刢栤漦匨琪氬ᘮİȲȴ", a_), global::CommonResources.AcgResources.ID_RXFREQMHZ, 0, int.MaxValue, 1);
			this.fctOrdsRxSynthesizerReferenceDividerListRxFreqMHz_A9017.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.fctOrdsRxSynthesizerReferenceDividerListRxFreqMHz_A9017.DataTransferOrder = 9;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鯈돊鳎꣐뷒ꇔ뿖볘꣚드ꗞ蓠釢엤뗦賨跪裬鷮铰鷲雴鋶\ud9f8뿺铼觾栀朂怄甆⤈䜊搌簎攐", a_);
			base.Id = 10007;
			base.UIName = global::CommonResources.AcgResources.ID_RXSYNTHESIZERREFERENCEDIVIDERLIST;
			base.DataTransferOrder = 1;
		}

		// Token: 0x060094DC RID: 38108 RVA: 0x008C11A0 File Offset: 0x008BF3A0
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 14;
			short num = (short)2028535809;
			if (num != 0)
			{
			}
			num = (short)599261192;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)796262406;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					this.fctOrdsRxSynthesizerReferenceDividerListRxRefDivMHz_A8925 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("觎닐꟒體ꗖ뷘꣚远꟞닠髢诤鏦臨軪黬蛮诰雲蟴ꗶ鳸鷺飼跾搀洂昄戆䴈戊笌明甐瘒朔嬖瀘栚検䴞夠焢䀤䄦洨䈪嬬戮礰䤲樴瘶ĸȺ༼ਾ", a_), global::CommonResources.AcgResources.ID_RXREFDIVMHZ, global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.LOVs.FctOrdsRxSynthesizerReferenceDividerListRxRefDivMHz_A8925LovStrs);
					this.fctOrdsRxSynthesizerReferenceDividerListRxRefDivMHz_A8925.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.fctOrdsRxSynthesizerReferenceDividerListRxRefDivMHz_A8925.DataTransferOrder = 8;
					num = (short)1564016647;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_249;
				case 3:
				{
					num = (short)618717186;
					short num3 = num;
					num = (short)59236354;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1B8;
					default:
					{
						num = (short)501350400;
						if (num != 0)
						{
						}
						num = (short)274857984;
						short num4 = num;
						num = (short)282329092;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 4:
					if (producerFields != null)
					{
						num = (short)1851326464;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_298;
				case 5:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("觎닐꟒體ꗖ뷘꣚远꟞닠髢诤鏦臨軪黬蛮诰雲蟴ꗶ鳸鷺飼跾搀洂昄戆䴈戊笌明甐瘒朔嬖瀘栚検䴞夠攢圤䈦堨昪攬售渰爲ఴܶ࠸఺", a_)))
					{
						num = (short)1295777801;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_298;
				case 6:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("觎닐꟒體ꗖ뷘꣚远꟞닠髢诤鏦臨軪黬蛮诰雲蟴ꗶ鳸鷺飼跾搀洂昄戆䴈戊笌明甐瘒朔嬖瀘栚検䴞夠焢䀤䄦洨䈪嬬戮礰䤲樴瘶ĸȺ༼ਾ", a_)))
					{
						num = (short)875495425;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_115;
				case 7:
					goto IL_1B8;
				case 8:
					switch (0)
					{
					case 0:
						goto IL_7C;
					}
					continue;
				case 9:
					this.fctOrdsRxSynthesizerReferenceDividerListRxFreqMHz_A9017 = new global::AcpBusinessLayer.AcpFrequencyField(170205000, this, global::AllFeatures.CodeplugGuid.b("觎닐꟒體ꗖ뷘꣚远꟞닠髢诤鏦臨軪黬蛮诰雲蟴ꗶ鳸鷺飼跾搀洂昄戆䴈戊笌明甐瘒朔嬖瀘栚検䴞夠攢圤䈦堨昪攬售渰爲ఴܶ࠸఺", a_), global::CommonResources.AcgResources.ID_RXFREQMHZ);
					this.fctOrdsRxSynthesizerReferenceDividerListRxFreqMHz_A9017.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.fctOrdsRxSynthesizerReferenceDividerListRxFreqMHz_A9017.DataTransferOrder = 9;
					num = (short)739573762;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_7C:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1978204163;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_115:
				num = (short)1132003333;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1B8:
				goto IL_115;
			}
			IL_249:
			IL_298:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鷎꧐蛔껖럘꿚뗜뫞鋠諢鿤苦鯨쯪뿬諮韰雲蟴鋶韸飺飼\udffe䔀樂猄渆洈渊缌⼎崐稒昔挖", a_);
			base.Id = 10007;
			base.UIName = global::CommonResources.AcgResources.ID_RXSYNTHESIZERREFERENCEDIVIDERLIST;
			base.DataTransferOrder = 1;
		}

		// Token: 0x060094DD RID: 38109 RVA: 0x008C1478 File Offset: 0x008BF678
		public override void PopulateReferences()
		{
			short num = (short)523285252;
			short num2 = num;
			num = (short)1617933060;
			switch (num2 == num)
			{
			}
			num = (short)1125253120;
			short num3 = num;
			num = (short)552271873;
			if (num != 0)
			{
			}
			num = (short)459800576;
			if (num != 0)
			{
			}
		}

		// Token: 0x060094DE RID: 38110 RVA: 0x008C1520 File Offset: 0x008BF720
		public override void DropReferences()
		{
			short num = (short)94521612;
			short num2 = num;
			num = (short)361908492;
			switch (num2 == num)
			{
			}
			num = (short)1300234240;
			short num3 = num;
			num = (short)1655898113;
			if (num != 0)
			{
			}
			num = (short)1342767104;
			if (num != 0)
			{
			}
		}

		// Token: 0x060094DF RID: 38111 RVA: 0x008C15CC File Offset: 0x008BF7CC
		public override void SetConstraints()
		{
			short num = (short)1700246741;
			short num2 = num;
			num = (short)753120469;
			switch (num2 == num)
			{
			}
			num = (short)2141913088;
			short num3 = num;
			num = (short)352059393;
			if (num != 0)
			{
			}
			num = (short)147718144;
			if (num != 0)
			{
			}
			this.fctOrdsRxSynthesizerReferenceDividerListRxRefDivMHz_A8925.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.FactoryOverridesConstraints.ConFactoryOverridesEnableIsChecked);
			this.fctOrdsRxSynthesizerReferenceDividerListRxFreqMHz_A9017.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.FactoryOverridesConstraints.ConFactoryOverridesEnableIsChecked);
			this.fctOrdsRxSynthesizerReferenceDividerListRxFreqMHz_A9017.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.FactoryOverridesConstraints.conFacOvrrdRxFreqMHzIsValid);
		}

		// Token: 0x060094E0 RID: 38112 RVA: 0x008C16BC File Offset: 0x008BF8BC
		public override void SetupDependencies()
		{
			short num = (short)117952015;
			short num2 = num;
			num = (short)1054461455;
			switch (num2 == num)
			{
			}
			num = (short)2125660161;
			if (num != 0)
			{
			}
			num = (short)401211392;
			short num3 = num;
			num = (short)646512640;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.FactoryOverrides factoryOverrides = base.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.FactoryOverrides;
			factoryOverrides.General.RadWideAdvancedFactoryOverrides_A8004.AddDependentObject(this.fctOrdsRxSynthesizerReferenceDividerListRxRefDivMHz_A8925);
			factoryOverrides.General.RadWideAdvancedFactoryOverrides_A8004.AddDependentObject(this.fctOrdsRxSynthesizerReferenceDividerListRxFreqMHz_A9017);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesOpenFrequency_A22699.AddDependentObject(this.fctOrdsRxSynthesizerReferenceDividerListRxFreqMHz_A9017);
		}

		// Token: 0x17004ADC RID: 19164
		// (get) Token: 0x060094E1 RID: 38113 RVA: 0x008C17C4 File Offset: 0x008BF9C4
		public bool HasDiffs
		{
			get
			{
				short num = (short)1683971647;
				short num2 = num;
				num = (short)1251892799;
				switch (num2 == num)
				{
				}
				num = (short)1805844480;
				if (num != 0)
				{
				}
				num = (short)14483456;
				short num3 = num;
				num = (short)1694826497;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17004ADD RID: 19165
		// (get) Token: 0x060094E2 RID: 38114 RVA: 0x008C1870 File Offset: 0x008BFA70
		// (set) Token: 0x060094E3 RID: 38115 RVA: 0x008C1924 File Offset: 0x008BFB24
		public int FctOrdsRxSynthesizerReferenceDividerListRxRefDivMHz_A8925Value
		{
			get
			{
				short num = (short)1502690340;
				short num2 = num;
				num = (short)1611217956;
				switch (num2 == num)
				{
				}
				num = (short)1215234049;
				if (num != 0)
				{
				}
				num = (short)78905344;
				short num3 = num;
				num = (short)1817051136;
				if (num != 0)
				{
				}
				return this.fctOrdsRxSynthesizerReferenceDividerListRxRefDivMHz_A8925.Value;
			}
			set
			{
				short num = (short)28150553;
				short num2 = num;
				num = (short)272010009;
				switch (num2 == num)
				{
				}
				num = (short)642449408;
				if (num != 0)
				{
				}
				num = (short)298057728;
				short num3 = num;
				num = (short)897515521;
				if (num != 0)
				{
				}
				this.fctOrdsRxSynthesizerReferenceDividerListRxRefDivMHz_A8925.Value = value;
			}
		}

		// Token: 0x17004ADE RID: 19166
		// (get) Token: 0x060094E4 RID: 38116 RVA: 0x008C19D8 File Offset: 0x008BFBD8
		// (set) Token: 0x060094E5 RID: 38117 RVA: 0x008C1A8C File Offset: 0x008BFC8C
		public string FctOrdsRxSynthesizerReferenceDividerListRxRefDivMHz_A8925_UIValue
		{
			get
			{
				short num = (short)1948450817;
				if (num != 0)
				{
				}
				num = (short)52712199;
				short num2 = num;
				num = (short)244077319;
				switch (num2 == num)
				{
				}
				num = (short)1369112576;
				short num3 = num;
				num = (short)840237056;
				if (num != 0)
				{
				}
				return this.fctOrdsRxSynthesizerReferenceDividerListRxRefDivMHz_A8925.UIValue;
			}
			set
			{
				short num = (short)1255450866;
				short num2 = num;
				num = (short)303802610;
				switch (num2 == num)
				{
				}
				num = (short)808648704;
				if (num != 0)
				{
				}
				num = (short)630652928;
				short num3 = num;
				num = (short)1714618369;
				if (num != 0)
				{
				}
				this.fctOrdsRxSynthesizerReferenceDividerListRxRefDivMHz_A8925.UIValue = value;
			}
		}

		// Token: 0x17004ADF RID: 19167
		// (get) Token: 0x060094E6 RID: 38118 RVA: 0x008C1B40 File Offset: 0x008BFD40
		public global::AcpBusinessLayer.AcpListField FctOrdsRxSynthesizerReferenceDividerListRxRefDivMHz_A8925
		{
			get
			{
				short num = (short)195955229;
				short num2 = num;
				num = (short)2120747549;
				switch (num2 == num)
				{
				}
				num = (short)1455685633;
				if (num != 0)
				{
				}
				num = (short)1448607744;
				short num3 = num;
				num = (short)1991966720;
				if (num != 0)
				{
				}
				return this.fctOrdsRxSynthesizerReferenceDividerListRxRefDivMHz_A8925;
			}
		}

		// Token: 0x17004AE0 RID: 19168
		// (get) Token: 0x060094E7 RID: 38119 RVA: 0x008C1BF0 File Offset: 0x008BFDF0
		// (set) Token: 0x060094E8 RID: 38120 RVA: 0x008C1CA8 File Offset: 0x008BFEA8
		public bool FctOrdsRxSynthesizerReferenceDividerListRxRefDivMHz_A8925_Applicable
		{
			get
			{
				short num = (short)1518398095;
				short num2 = num;
				num = (short)176679567;
				switch (num2 == num)
				{
				}
				num = (short)1883242497;
				if (num != 0)
				{
				}
				num = (short)1594032128;
				short num3 = num;
				num = (short)1872297984;
				if (num != 0)
				{
				}
				return this.fctOrdsRxSynthesizerReferenceDividerListRxRefDivMHz_A8925.Applicable;
			}
			set
			{
				short num = (short)1748307955;
				short num2 = num;
				num = (short)505745395;
				switch (num2 == num)
				{
				}
				num = (short)2002124801;
				if (num != 0)
				{
				}
				num = (short)935067648;
				short num3 = num;
				num = (short)1401159680;
				if (num != 0)
				{
				}
				this.fctOrdsRxSynthesizerReferenceDividerListRxRefDivMHz_A8925.Applicable = value;
			}
		}

		// Token: 0x17004AE1 RID: 19169
		// (get) Token: 0x060094E9 RID: 38121 RVA: 0x008C1D5C File Offset: 0x008BFF5C
		// (set) Token: 0x060094EA RID: 38122 RVA: 0x008C1E10 File Offset: 0x008C0010
		public bool FctOrdsRxSynthesizerReferenceDividerListRxRefDivMHz_A8925_Valid
		{
			get
			{
				short num = (short)873011738;
				short num2 = num;
				num = (short)76618266;
				switch (num2 == num)
				{
				}
				num = (short)358547457;
				if (num != 0)
				{
				}
				num = (short)1184432128;
				short num3 = num;
				num = (short)1667235840;
				if (num != 0)
				{
				}
				return this.fctOrdsRxSynthesizerReferenceDividerListRxRefDivMHz_A8925.Valid;
			}
			set
			{
				short num = (short)1053016145;
				short num2 = num;
				num = (short)666157137;
				switch (num2 == num)
				{
				}
				num = (short)1473314816;
				if (num != 0)
				{
				}
				num = (short)459997184;
				short num3 = num;
				num = (short)1029898241;
				if (num != 0)
				{
				}
				this.fctOrdsRxSynthesizerReferenceDividerListRxRefDivMHz_A8925.Valid = value;
			}
		}

		// Token: 0x17004AE2 RID: 19170
		// (get) Token: 0x060094EB RID: 38123 RVA: 0x008C1EC8 File Offset: 0x008C00C8
		// (set) Token: 0x060094EC RID: 38124 RVA: 0x008C1F7C File Offset: 0x008C017C
		public bool FctOrdsRxSynthesizerReferenceDividerListRxRefDivMHz_A8925_Visible
		{
			get
			{
				short num = (short)1357299953;
				short num2 = num;
				num = (short)1719845105;
				switch (num2 == num)
				{
				}
				num = (short)1418526720;
				if (num != 0)
				{
				}
				num = (short)607846400;
				short num3 = num;
				num = (short)2110455809;
				if (num != 0)
				{
				}
				return this.fctOrdsRxSynthesizerReferenceDividerListRxRefDivMHz_A8925.Visible;
			}
			set
			{
				short num = (short)1847911778;
				short num2 = num;
				num = (short)820176226;
				switch (num2 == num)
				{
				}
				num = (short)1812660225;
				if (num != 0)
				{
				}
				num = (short)796983296;
				short num3 = num;
				num = (short)1727135744;
				if (num != 0)
				{
				}
				this.fctOrdsRxSynthesizerReferenceDividerListRxRefDivMHz_A8925.Visible = value;
			}
		}

		// Token: 0x17004AE3 RID: 19171
		// (get) Token: 0x060094ED RID: 38125 RVA: 0x008C2030 File Offset: 0x008C0230
		// (set) Token: 0x060094EE RID: 38126 RVA: 0x008C20E8 File Offset: 0x008C02E8
		public bool FctOrdsRxSynthesizerReferenceDividerListRxRefDivMHz_A8925_Editable
		{
			get
			{
				short num = (short)1402637533;
				short num2 = num;
				num = (short)377654493;
				switch (num2 == num)
				{
				}
				num = (short)1328611329;
				if (num != 0)
				{
				}
				num = (short)132120576;
				short num3 = num;
				num = (short)756875264;
				if (num != 0)
				{
				}
				return this.fctOrdsRxSynthesizerReferenceDividerListRxRefDivMHz_A8925.Editable;
			}
			set
			{
				short num = (short)1257472342;
				short num2 = num;
				num = (short)1264812374;
				switch (num2 == num)
				{
				}
				num = (short)1283915777;
				if (num != 0)
				{
				}
				num = (short)1123024896;
				short num3 = num;
				num = (short)2006122496;
				if (num != 0)
				{
				}
				this.fctOrdsRxSynthesizerReferenceDividerListRxRefDivMHz_A8925.Editable = value;
			}
		}

		// Token: 0x17004AE4 RID: 19172
		// (get) Token: 0x060094EF RID: 38127 RVA: 0x008C219C File Offset: 0x008C039C
		internal string FctOrdsRxSynthesizerReferenceDividerListRxRefDivMHz_A8925_UILabel
		{
			get
			{
				short num = (short)901185537;
				if (num != 0)
				{
				}
				num = (short)579932881;
				short num2 = num;
				num = (short)67965649;
				switch (num2 == num)
				{
				}
				num = (short)5373952;
				short num3 = num;
				num = (short)1929969664;
				if (num != 0)
				{
				}
				return this.fctOrdsRxSynthesizerReferenceDividerListRxRefDivMHz_A8925.UIName;
			}
		}

		// Token: 0x17004AE5 RID: 19173
		// (get) Token: 0x060094F0 RID: 38128 RVA: 0x008C2250 File Offset: 0x008C0450
		// (set) Token: 0x060094F1 RID: 38129 RVA: 0x008C2308 File Offset: 0x008C0508
		internal bool FctOrdsRxSynthesizerReferenceDividerListRxRefDivMHz_A8925_HiddenStatic
		{
			get
			{
				short num = (short)1748488469;
				short num2 = num;
				num = (short)324718869;
				switch (num2 == num)
				{
				}
				num = (short)1449525249;
				if (num != 0)
				{
				}
				num = (short)1318125568;
				short num3 = num;
				num = (short)1865940992;
				if (num != 0)
				{
				}
				return this.fctOrdsRxSynthesizerReferenceDividerListRxRefDivMHz_A8925.HiddenStatic;
			}
			set
			{
				short num = (short)1517197701;
				short num2 = num;
				num = (short)1896061317;
				switch (num2 == num)
				{
				}
				num = (short)503513089;
				if (num != 0)
				{
				}
				num = (short)132448256;
				short num3 = num;
				num = (short)1805844480;
				if (num != 0)
				{
				}
				this.fctOrdsRxSynthesizerReferenceDividerListRxRefDivMHz_A8925.HiddenStatic = value;
			}
		}

		// Token: 0x17004AE6 RID: 19174
		// (get) Token: 0x060094F2 RID: 38130 RVA: 0x008C23BC File Offset: 0x008C05BC
		// (set) Token: 0x060094F3 RID: 38131 RVA: 0x008C2474 File Offset: 0x008C0674
		internal bool FctOrdsRxSynthesizerReferenceDividerListRxRefDivMHz_A8925_HiddenDynamic
		{
			get
			{
				short num = (short)2119669091;
				short num2 = num;
				num = (short)689018211;
				switch (num2 == num)
				{
				}
				num = (short)2058551297;
				if (num != 0)
				{
				}
				num = (short)45613056;
				short num3 = num;
				num = (short)348585984;
				if (num != 0)
				{
				}
				return this.fctOrdsRxSynthesizerReferenceDividerListRxRefDivMHz_A8925.HiddenDynamic;
			}
			set
			{
				short num = (short)407489522;
				short num2 = num;
				num = (short)1983368178;
				switch (num2 == num)
				{
				}
				num = (short)582811649;
				if (num != 0)
				{
				}
				num = (short)758972416;
				short num3 = num;
				num = (short)550699008;
				if (num != 0)
				{
				}
				this.fctOrdsRxSynthesizerReferenceDividerListRxRefDivMHz_A8925.HiddenDynamic = value;
			}
		}

		// Token: 0x17004AE7 RID: 19175
		// (get) Token: 0x060094F4 RID: 38132 RVA: 0x008C252C File Offset: 0x008C072C
		public bool FctOrdsRxSynthesizerReferenceDividerListRxRefDivMHz_A8925_HasDiffs
		{
			get
			{
				short num = (short)1106951840;
				short num2 = num;
				num = (short)2069937824;
				switch (num2 == num)
				{
				}
				num = (short)1208156161;
				if (num != 0)
				{
				}
				num = (short)1194196992;
				short num3 = num;
				num = (short)904396800;
				if (num != 0)
				{
				}
				return this.fctOrdsRxSynthesizerReferenceDividerListRxRefDivMHz_A8925._HasDiffs;
			}
		}

		// Token: 0x17004AE8 RID: 19176
		// (get) Token: 0x060094F5 RID: 38133 RVA: 0x008C25E0 File Offset: 0x008C07E0
		// (set) Token: 0x060094F6 RID: 38134 RVA: 0x008C2694 File Offset: 0x008C0894
		public int FctOrdsRxSynthesizerReferenceDividerListRxFreqMHz_A9017Value
		{
			get
			{
				short num = (short)880607233;
				if (num != 0)
				{
				}
				num = (short)1483188780;
				short num2 = num;
				num = (short)131508780;
				switch (num2 == num)
				{
				}
				num = (short)735444992;
				short num3 = num;
				num = (short)818806784;
				if (num != 0)
				{
				}
				return this.fctOrdsRxSynthesizerReferenceDividerListRxFreqMHz_A9017.Value;
			}
			set
			{
				short num = (short)1525680663;
				short num2 = num;
				num = (short)882182679;
				switch (num2 == num)
				{
				}
				num = (short)1355218945;
				if (num != 0)
				{
				}
				num = (short)281083904;
				short num3 = num;
				num = (short)1156120576;
				if (num != 0)
				{
				}
				this.fctOrdsRxSynthesizerReferenceDividerListRxFreqMHz_A9017.Value = value;
			}
		}

		// Token: 0x17004AE9 RID: 19177
		// (get) Token: 0x060094F7 RID: 38135 RVA: 0x008C2748 File Offset: 0x008C0948
		// (set) Token: 0x060094F8 RID: 38136 RVA: 0x008C27F8 File Offset: 0x008C09F8
		public string FctOrdsRxSynthesizerReferenceDividerListRxFreqMHz_A9017_UIValue
		{
			get
			{
				short num = (short)1283337201;
				short num2 = num;
				num = (short)1771973617;
				switch (num2 == num)
				{
				}
				num = (short)1208287233;
				if (num != 0)
				{
				}
				num = (short)1664352256;
				short num3 = num;
				num = (short)622067712;
				if (num != 0)
				{
				}
				return this.fctOrdsRxSynthesizerReferenceDividerListRxFreqMHz_A9017.UIValue;
			}
			set
			{
				short num = (short)1255837832;
				short num2 = num;
				num = (short)1886752904;
				switch (num2 == num)
				{
				}
				num = (short)595394561;
				if (num != 0)
				{
				}
				num = (short)355926016;
				short num3 = num;
				num = (short)846266368;
				if (num != 0)
				{
				}
				this.fctOrdsRxSynthesizerReferenceDividerListRxFreqMHz_A9017.UIValue = value;
			}
		}

		// Token: 0x17004AEA RID: 19178
		// (get) Token: 0x060094F9 RID: 38137 RVA: 0x008C28AC File Offset: 0x008C0AAC
		public global::AcpBusinessLayer.AcpFrequencyField FctOrdsRxSynthesizerReferenceDividerListRxFreqMHz_A9017
		{
			get
			{
				short num = (short)1501672710;
				short num2 = num;
				num = (short)2011280646;
				switch (num2 == num)
				{
				}
				num = (short)155320321;
				if (num != 0)
				{
				}
				num = (short)745865216;
				short num3 = num;
				num = (short)167313408;
				if (num != 0)
				{
				}
				return this.fctOrdsRxSynthesizerReferenceDividerListRxFreqMHz_A9017;
			}
		}

		// Token: 0x17004AEB RID: 19179
		// (get) Token: 0x060094FA RID: 38138 RVA: 0x008C2958 File Offset: 0x008C0B58
		// (set) Token: 0x060094FB RID: 38139 RVA: 0x008C2A0C File Offset: 0x008C0C0C
		internal int FctOrdsRxSynthesizerReferenceDividerListRxFreqMHz_A9017Min
		{
			get
			{
				short num = (short)808230127;
				short num2 = num;
				num = (short)1721343215;
				switch (num2 == num)
				{
				}
				num = (short)1833107456;
				if (num != 0)
				{
				}
				num = (short)2111569920;
				short num3 = num;
				num = (short)1634861057;
				if (num != 0)
				{
				}
				return this.fctOrdsRxSynthesizerReferenceDividerListRxFreqMHz_A9017.Min;
			}
			set
			{
				short num = (short)23150612;
				short num2 = num;
				num = (short)1527660564;
				switch (num2 == num)
				{
				}
				num = (short)1885339649;
				if (num != 0)
				{
				}
				num = (short)1943142400;
				short num3 = num;
				num = (short)705495040;
				if (num != 0)
				{
				}
				this.fctOrdsRxSynthesizerReferenceDividerListRxFreqMHz_A9017.Min = value;
			}
		}

		// Token: 0x17004AEC RID: 19180
		// (get) Token: 0x060094FC RID: 38140 RVA: 0x008C2AC4 File Offset: 0x008C0CC4
		// (set) Token: 0x060094FD RID: 38141 RVA: 0x008C2B78 File Offset: 0x008C0D78
		internal int FctOrdsRxSynthesizerReferenceDividerListRxFreqMHz_A9017Max
		{
			get
			{
				short num = (short)1108588826;
				short num2 = num;
				num = (short)808499482;
				switch (num2 == num)
				{
				}
				num = (short)1052573697;
				if (num != 0)
				{
				}
				num = (short)132513792;
				short num3 = num;
				num = (short)846004224;
				if (num != 0)
				{
				}
				return this.fctOrdsRxSynthesizerReferenceDividerListRxFreqMHz_A9017.Max;
			}
			set
			{
				short num = (short)270174984;
				short num2 = num;
				num = (short)1745128200;
				switch (num2 == num)
				{
				}
				num = (short)498794497;
				if (num != 0)
				{
				}
				num = (short)207159296;
				short num3 = num;
				num = (short)1255800832;
				if (num != 0)
				{
				}
				this.fctOrdsRxSynthesizerReferenceDividerListRxFreqMHz_A9017.Max = value;
			}
		}

		// Token: 0x17004AED RID: 19181
		// (get) Token: 0x060094FE RID: 38142 RVA: 0x008C2C2C File Offset: 0x008C0E2C
		// (set) Token: 0x060094FF RID: 38143 RVA: 0x008C2CE4 File Offset: 0x008C0EE4
		internal int FctOrdsRxSynthesizerReferenceDividerListRxFreqMHz_A9017Step
		{
			get
			{
				short num = (short)1862402049;
				if (num != 0)
				{
				}
				num = (short)158247336;
				short num2 = num;
				num = (short)1382263208;
				switch (num2 == num)
				{
				}
				num = (short)1998061568;
				short num3 = num;
				num = (short)1335689216;
				if (num != 0)
				{
				}
				return this.fctOrdsRxSynthesizerReferenceDividerListRxFreqMHz_A9017.StepSize;
			}
			set
			{
				short num = (short)1043660801;
				if (num != 0)
				{
				}
				num = (short)1273424747;
				short num2 = num;
				num = (short)1164241771;
				switch (num2 == num)
				{
				}
				num = (short)1522335744;
				short num3 = num;
				num = (short)1542520832;
				if (num != 0)
				{
				}
				this.fctOrdsRxSynthesizerReferenceDividerListRxFreqMHz_A9017.StepSize = value;
			}
		}

		// Token: 0x17004AEE RID: 19182
		// (get) Token: 0x06009500 RID: 38144 RVA: 0x008C2D98 File Offset: 0x008C0F98
		// (set) Token: 0x06009501 RID: 38145 RVA: 0x008C2E48 File Offset: 0x008C1048
		public bool FctOrdsRxSynthesizerReferenceDividerListRxFreqMHz_A9017_Applicable
		{
			get
			{
				short num = (short)291831809;
				if (num != 0)
				{
				}
				num = (short)110191468;
				short num2 = num;
				num = (short)468411244;
				switch (num2 == num)
				{
				}
				num = (short)2054094848;
				short num3 = num;
				num = (short)1603469312;
				if (num != 0)
				{
				}
				return this.fctOrdsRxSynthesizerReferenceDividerListRxFreqMHz_A9017.Applicable;
			}
			set
			{
				short num = (short)1742052886;
				short num2 = num;
				num = (short)337878550;
				switch (num2 == num)
				{
				}
				num = (short)1248133121;
				if (num != 0)
				{
				}
				num = (short)2145714176;
				short num3 = num;
				num = (short)2012020736;
				if (num != 0)
				{
				}
				this.fctOrdsRxSynthesizerReferenceDividerListRxFreqMHz_A9017.Applicable = value;
			}
		}

		// Token: 0x17004AEF RID: 19183
		// (get) Token: 0x06009502 RID: 38146 RVA: 0x008C2EFC File Offset: 0x008C10FC
		// (set) Token: 0x06009503 RID: 38147 RVA: 0x008C2FB0 File Offset: 0x008C11B0
		public bool FctOrdsRxSynthesizerReferenceDividerListRxFreqMHz_A9017_Valid
		{
			get
			{
				short num = (short)1118159333;
				short num2 = num;
				num = (short)1104003557;
				switch (num2 == num)
				{
				}
				num = (short)808517633;
				if (num != 0)
				{
				}
				num = (short)1755250688;
				short num3 = num;
				num = (short)1494876160;
				if (num != 0)
				{
				}
				return this.fctOrdsRxSynthesizerReferenceDividerListRxFreqMHz_A9017.Valid;
			}
			set
			{
				short num = (short)709558273;
				if (num != 0)
				{
				}
				num = (short)188281274;
				short num2 = num;
				num = (short)796979642;
				switch (num2 == num)
				{
				}
				num = (short)18743296;
				short num3 = num;
				num = (short)749273088;
				if (num != 0)
				{
				}
				this.fctOrdsRxSynthesizerReferenceDividerListRxFreqMHz_A9017.Valid = value;
			}
		}

		// Token: 0x17004AF0 RID: 19184
		// (get) Token: 0x06009504 RID: 38148 RVA: 0x008C3064 File Offset: 0x008C1264
		// (set) Token: 0x06009505 RID: 38149 RVA: 0x008C3118 File Offset: 0x008C1318
		public bool FctOrdsRxSynthesizerReferenceDividerListRxFreqMHz_A9017_Visible
		{
			get
			{
				short num = (short)823762795;
				short num2 = num;
				num = (short)1959894891;
				switch (num2 == num)
				{
				}
				num = (short)1628176385;
				if (num != 0)
				{
				}
				num = (short)708968448;
				short num3 = num;
				num = (short)1790771200;
				if (num != 0)
				{
				}
				return this.fctOrdsRxSynthesizerReferenceDividerListRxFreqMHz_A9017.Visible;
			}
			set
			{
				short num = (short)846528513;
				if (num != 0)
				{
				}
				num = (short)1593736943;
				short num2 = num;
				num = (short)266501871;
				switch (num2 == num)
				{
				}
				num = (short)9568256;
				short num3 = num;
				num = (short)1843724288;
				if (num != 0)
				{
				}
				this.fctOrdsRxSynthesizerReferenceDividerListRxFreqMHz_A9017.Visible = value;
			}
		}

		// Token: 0x17004AF1 RID: 19185
		// (get) Token: 0x06009506 RID: 38150 RVA: 0x008C31CC File Offset: 0x008C13CC
		// (set) Token: 0x06009507 RID: 38151 RVA: 0x008C3280 File Offset: 0x008C1480
		public bool FctOrdsRxSynthesizerReferenceDividerListRxFreqMHz_A9017_Editable
		{
			get
			{
				short num = (short)1703549857;
				short num2 = num;
				num = (short)1404312481;
				switch (num2 == num)
				{
				}
				num = (short)685441025;
				if (num != 0)
				{
				}
				num = (short)795541504;
				short num3 = num;
				num = (short)1447559168;
				if (num != 0)
				{
				}
				return this.fctOrdsRxSynthesizerReferenceDividerListRxFreqMHz_A9017.Editable;
			}
			set
			{
				short num = (short)209321985;
				if (num != 0)
				{
				}
				num = (short)134452374;
				short num2 = num;
				num = (short)675779734;
				switch (num2 == num)
				{
				}
				num = (short)1652424704;
				short num3 = num;
				num = (short)1531641856;
				if (num != 0)
				{
				}
				this.fctOrdsRxSynthesizerReferenceDividerListRxFreqMHz_A9017.Editable = value;
			}
		}

		// Token: 0x17004AF2 RID: 19186
		// (get) Token: 0x06009508 RID: 38152 RVA: 0x008C3338 File Offset: 0x008C1538
		internal string FctOrdsRxSynthesizerReferenceDividerListRxFreqMHz_A9017_UILabel
		{
			get
			{
				short num = (short)452884839;
				short num2 = num;
				num = (short)212302183;
				switch (num2 == num)
				{
				}
				num = (short)708313088;
				if (num != 0)
				{
				}
				num = (short)1370488832;
				short num3 = num;
				num = (short)702873601;
				if (num != 0)
				{
				}
				return this.fctOrdsRxSynthesizerReferenceDividerListRxFreqMHz_A9017.UIName;
			}
		}

		// Token: 0x17004AF3 RID: 19187
		// (get) Token: 0x06009509 RID: 38153 RVA: 0x008C33EC File Offset: 0x008C15EC
		// (set) Token: 0x0600950A RID: 38154 RVA: 0x008C34A0 File Offset: 0x008C16A0
		internal bool FctOrdsRxSynthesizerReferenceDividerListRxFreqMHz_A9017_HiddenStatic
		{
			get
			{
				short num = (short)300462172;
				short num2 = num;
				num = (short)1464774748;
				switch (num2 == num)
				{
				}
				num = (short)1960902656;
				if (num != 0)
				{
				}
				num = (short)478281728;
				short num3 = num;
				num = (short)1952776193;
				if (num != 0)
				{
				}
				return this.fctOrdsRxSynthesizerReferenceDividerListRxFreqMHz_A9017.HiddenStatic;
			}
			set
			{
				short num = (short)1741618220;
				short num2 = num;
				num = (short)328203308;
				switch (num2 == num)
				{
				}
				num = (short)1422327809;
				if (num != 0)
				{
				}
				num = (short)1815216128;
				short num3 = num;
				num = (short)53477376;
				if (num != 0)
				{
				}
				this.fctOrdsRxSynthesizerReferenceDividerListRxFreqMHz_A9017.HiddenStatic = value;
			}
		}

		// Token: 0x17004AF4 RID: 19188
		// (get) Token: 0x0600950B RID: 38155 RVA: 0x008C3558 File Offset: 0x008C1758
		// (set) Token: 0x0600950C RID: 38156 RVA: 0x008C3610 File Offset: 0x008C1810
		internal bool FctOrdsRxSynthesizerReferenceDividerListRxFreqMHz_A9017_HiddenDynamic
		{
			get
			{
				short num = (short)895707921;
				short num2 = num;
				num = (short)1204841233;
				switch (num2 == num)
				{
				}
				num = (short)396886017;
				if (num != 0)
				{
				}
				num = (short)1959395328;
				short num3 = num;
				num = (short)1442643968;
				if (num != 0)
				{
				}
				return this.fctOrdsRxSynthesizerReferenceDividerListRxFreqMHz_A9017.HiddenDynamic;
			}
			set
			{
				short num = (short)1166137878;
				short num2 = num;
				num = (short)2008668694;
				switch (num2 == num)
				{
				}
				num = (short)1819344896;
				if (num != 0)
				{
				}
				num = (short)618332160;
				short num3 = num;
				num = (short)1962672129;
				if (num != 0)
				{
				}
				this.fctOrdsRxSynthesizerReferenceDividerListRxFreqMHz_A9017.HiddenDynamic = value;
			}
		}

		// Token: 0x17004AF5 RID: 19189
		// (get) Token: 0x0600950D RID: 38157 RVA: 0x008C36C4 File Offset: 0x008C18C4
		public bool FctOrdsRxSynthesizerReferenceDividerListRxFreqMHz_A9017_HasDiffs
		{
			get
			{
				short num = (short)2088632321;
				if (num != 0)
				{
				}
				num = (short)1349102693;
				short num2 = num;
				num = (short)207137893;
				switch (num2 == num)
				{
				}
				num = (short)1941307392;
				short num3 = num;
				num = (short)777519104;
				if (num != 0)
				{
				}
				return this.fctOrdsRxSynthesizerReferenceDividerListRxFreqMHz_A9017._HasDiffs;
			}
		}

		// Token: 0x17004AF6 RID: 19190
		// (get) Token: 0x0600950E RID: 38158 RVA: 0x008C3778 File Offset: 0x008C1978
		public global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation RefRadioInformation
		{
			get
			{
				short num = (short)1490465241;
				short num2 = num;
				num = (short)878752217;
				switch (num2 == num)
				{
				}
				num = (short)1471086593;
				if (num != 0)
				{
				}
				num = (short)2037972992;
				short num3 = num;
				num = (short)1086980096;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation;
			}
		}

		// Token: 0x0600950F RID: 38159 RVA: 0x008C3838 File Offset: 0x008C1A38
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
						num2 = (short)858193922;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 1:
					return result;
				case 2:
				{
					num2 = (short)614486907;
					short num3 = num2;
					num2 = (short)1968001915;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return result;
					default:
					{
						num2 = (short)1663172608;
						if (num2 != 0)
						{
						}
						result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
						num2 = (short)1084227584;
						short num4 = num2;
						num2 = (short)1499463681;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 3:
					num2 = (short)416350208;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (base.ParentRecset != null)
					{
						num2 = (short)1475674115;
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
			num2 = (short)1155596289;
			if (num2 != 0)
			{
			}
			num2 = (short)2104295428;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x040049FA RID: 18938
		private global::AcpBusinessLayer.AcpListField fctOrdsRxSynthesizerReferenceDividerListRxRefDivMHz_A8925;

		// Token: 0x040049FB RID: 18939
		private global::AcpBusinessLayer.AcpFrequencyField fctOrdsRxSynthesizerReferenceDividerListRxFreqMHz_A9017;
	}
}
