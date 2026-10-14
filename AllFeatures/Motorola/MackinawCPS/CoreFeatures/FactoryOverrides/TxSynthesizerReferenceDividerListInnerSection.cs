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
	// Token: 0x0200046D RID: 1133
	[global::System.Serializable]
	public class TxSynthesizerReferenceDividerListInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x060095B6 RID: 38326 RVA: 0x008CAD68 File Offset: 0x008C8F68
		public TxSynthesizerReferenceDividerListInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x060095B7 RID: 38327 RVA: 0x008CAD84 File Offset: 0x008C8F84
		protected TxSynthesizerReferenceDividerListInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x060095B8 RID: 38328 RVA: 0x008CAD9C File Offset: 0x008C8F9C
		public override void Init()
		{
			int a_ = 13;
			short num = (short)1781262508;
			short num2 = num;
			num = (short)1610803372;
			switch (num2 == num)
			{
			}
			num = (short)470155264;
			short num3 = num;
			num = (short)1790115841;
			if (num != 0)
			{
			}
			num = (short)823525376;
			if (num != 0)
			{
			}
			this.fctOrdsRxSynthesizerReferenceDividerListTxRefDivMHz_A8924 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("裍돏ꛑ鯓ꓕ볗꧙軛ꛝ돟鯡諣鋥胧迩鿫蟭諯韱蛳ꓵ鷷鳹駻賽旿氁會挅䰇按程服琏眑易娕焗椙栛䨝堟瀡䄣䀥氧䌩娫挭砯䠱欳眵7̹฻਽", a_), global::CommonResources.AcgResources.ID_TXREFDIVMHZ, global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.LOVs.FctOrdsRxSynthesizerReferenceDividerListTxRefDivMHz_A8924LovStrs);
			this.fctOrdsRxSynthesizerReferenceDividerListTxRefDivMHz_A8924.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.fctOrdsRxSynthesizerReferenceDividerListTxRefDivMHz_A8924.DataTransferOrder = 7;
			this.fctOrdsTxSynthesizerReferenceDividerListTxFreqMHz_A9534 = new global::AcpBusinessLayer.AcpFrequencyField(161202500, this, global::AllFeatures.CodeplugGuid.b("裍돏ꛑ鯓ꓕ볗꧙裛ꛝ돟鯡諣鋥胧迩鿫蟭諯韱蛳ꓵ鷷鳹駻賽旿氁會挅䰇按程服琏眑易娕焗椙栛䨝堟搡嘣䌥大朩搫吭漯猱ള̵ଷู", a_), global::CommonResources.AcgResources.ID_TXFREQMHZ, 0, int.MaxValue, 1);
			this.fctOrdsTxSynthesizerReferenceDividerListTxFreqMHz_A9534.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.fctOrdsTxSynthesizerReferenceDividerListTxFreqMHz_A9534.DataTransferOrder = 11;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("髍꣏蟓꿕뛗껙듛믝鏟诡黣菥髧쫩뻫语雯韱蛳鏵雷駹駻\udefd䓿欁爃漅氇漉縋⸍小笑朓戕", a_);
			base.Id = 10009;
			base.UIName = global::CommonResources.AcgResources.ID_TXSYNTHESIZERREFERENCEDIVIDERLIST;
			base.DataTransferOrder = 1;
		}

		// Token: 0x060095B9 RID: 38329 RVA: 0x008CAEFC File Offset: 0x008C90FC
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 14;
			short num = (short)1228931079;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_1F8;
				case 1:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("觎닐꟒體ꗖ뷘꣚觜꟞닠髢诤鏦臨軪黬蛮诰雲蟴ꗶ鳸鷺飼跾搀洂昄戆䴈戊笌明甐瘒朔嬖瀘栚検䬞夠攢圤䈦堨昪攬售渰爲ఴȶਸ༺", a_)))
					{
						num = (short)477233157;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_245;
				case 2:
					goto IL_1F6;
				case 3:
					this.fctOrdsRxSynthesizerReferenceDividerListTxRefDivMHz_A8924 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("觎닐꟒體ꗖ뷘꣚远꟞닠髢诤鏦臨軪黬蛮诰雲蟴ꗶ鳸鷺飼跾搀洂昄戆䴈戊笌明甐瘒朔嬖瀘栚検䬞夠焢䀤䄦洨䈪嬬戮礰䤲樴瘶ĸȺ༼ା", a_), global::CommonResources.AcgResources.ID_TXREFDIVMHZ, global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.LOVs.FctOrdsRxSynthesizerReferenceDividerListTxRefDivMHz_A8924LovStrs);
					this.fctOrdsRxSynthesizerReferenceDividerListTxRefDivMHz_A8924.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.fctOrdsRxSynthesizerReferenceDividerListTxRefDivMHz_A8924.DataTransferOrder = 7;
					num = (short)932839430;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (producerFields != null)
					{
						num = (short)1123745792;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_245;
				case 5:
				{
					num = (short)111366865;
					short num3 = num;
					num = (short)163402449;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1F8;
					default:
						num = (short)1693581312;
						if (num != 0)
						{
						}
						this.fctOrdsTxSynthesizerReferenceDividerListTxFreqMHz_A9534 = new global::AcpBusinessLayer.AcpFrequencyField(161202500, this, global::AllFeatures.CodeplugGuid.b("觎닐꟒體ꗖ뷘꣚觜꟞닠髢诤鏦臨軪黬蛮诰雲蟴ꗶ鳸鷺飼跾搀洂昄戆䴈戊笌明甐瘒朔嬖瀘栚検䬞夠攢圤䈦堨昪攬售渰爲ఴȶਸ༺", a_), global::CommonResources.AcgResources.ID_TXFREQMHZ);
						this.fctOrdsTxSynthesizerReferenceDividerListTxFreqMHz_A9534.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
						this.fctOrdsTxSynthesizerReferenceDividerListTxFreqMHz_A9534.DataTransferOrder = 11;
						num = (short)1066139650;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 6:
					goto IL_7A;
				case 7:
					switch (0)
					{
					case 0:
						goto IL_56;
					}
					continue;
				case 8:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("觎닐꟒體ꗖ뷘꣚远꟞닠髢诤鏦臨軪黬蛮诰雲蟴ꗶ鳸鷺飼跾搀洂昄戆䴈戊笌明甐瘒朔嬖瀘栚検䬞夠焢䀤䄦洨䈪嬬戮礰䤲樴瘶ĸȺ༼ା", a_)))
					{
						num = (short)38273027;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_7A;
				case 9:
					num = (short)1649278980;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_56:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)555221001;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_7A:
				num = (short)840957953;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1F8:
				num = (short)374407176;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_1F6:
			IL_245:
			num = (short)462880769;
			if (num != 0)
			{
			}
			num = (short)282984448;
			short num4 = num;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鯎꧐蛔껖럘꿚뗜뫞鋠諢鿤苦鯨쯪뿬諮韰雲蟴鋶韸飺飼\udffe䔀樂猄渆洈渊缌⼎崐稒昔挖", a_);
			base.Id = 10009;
			base.UIName = global::CommonResources.AcgResources.ID_TXSYNTHESIZERREFERENCEDIVIDERLIST;
			base.DataTransferOrder = 1;
		}

		// Token: 0x060095BA RID: 38330 RVA: 0x008CB1D0 File Offset: 0x008C93D0
		public override void PopulateReferences()
		{
			short num = (short)1989072938;
			short num2 = num;
			num = (short)1745213482;
			switch (num2 == num)
			{
			}
			num = (short)815792128;
			short num3 = num;
			num = (short)1610809345;
			if (num != 0)
			{
			}
			num = (short)1601372160;
			if (num != 0)
			{
			}
		}

		// Token: 0x060095BB RID: 38331 RVA: 0x008CB278 File Offset: 0x008C9478
		public override void DropReferences()
		{
			short num = (short)1611125313;
			short num2 = num;
			num = (short)620483137;
			switch (num2 == num)
			{
			}
			num = (short)128974848;
			short num3 = num;
			num = (short)718733313;
			if (num != 0)
			{
			}
			num = (short)1751973888;
			if (num != 0)
			{
			}
		}

		// Token: 0x060095BC RID: 38332 RVA: 0x008CB320 File Offset: 0x008C9520
		public override void SetConstraints()
		{
			short num = (short)896273502;
			short num2 = num;
			num = (short)1481641054;
			switch (num2 == num)
			{
			}
			num = (short)1192624128;
			short num3 = num;
			num = (short)1328545792;
			if (num != 0)
			{
			}
			num = (short)167510017;
			if (num != 0)
			{
			}
			this.fctOrdsRxSynthesizerReferenceDividerListTxRefDivMHz_A8924.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.FactoryOverridesConstraints.ConFactoryOverridesEnableIsChecked);
			this.fctOrdsTxSynthesizerReferenceDividerListTxFreqMHz_A9534.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.FactoryOverridesConstraints.ConFactoryOverridesEnableIsChecked);
			this.fctOrdsTxSynthesizerReferenceDividerListTxFreqMHz_A9534.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.FactoryOverridesConstraints.conFacOvrrdTxFreqMHzIsValid);
		}

		// Token: 0x060095BD RID: 38333 RVA: 0x008CB410 File Offset: 0x008C9610
		public override void SetupDependencies()
		{
			short num = (short)1861629022;
			short num2 = num;
			num = (short)2098803806;
			switch (num2 == num)
			{
			}
			num = (short)1145896960;
			short num3 = num;
			num = (short)1101266945;
			if (num != 0)
			{
			}
			num = (short)1232011264;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.FactoryOverrides factoryOverrides = base.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.FactoryOverrides;
			factoryOverrides.General.RadWideAdvancedFactoryOverrides_A8004.AddDependentObject(this.fctOrdsRxSynthesizerReferenceDividerListTxRefDivMHz_A8924);
			factoryOverrides.General.RadWideAdvancedFactoryOverrides_A8004.AddDependentObject(this.fctOrdsTxSynthesizerReferenceDividerListTxFreqMHz_A9534);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesOpenFrequency_A22699.AddDependentObject(this.fctOrdsTxSynthesizerReferenceDividerListTxFreqMHz_A9534);
		}

		// Token: 0x17004B37 RID: 19255
		// (get) Token: 0x060095BE RID: 38334 RVA: 0x008CB518 File Offset: 0x008C9718
		public bool HasDiffs
		{
			get
			{
				short num = (short)3473409;
				if (num != 0)
				{
				}
				num = (short)1687316314;
				short num2 = num;
				num = (short)297822042;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1303248896;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1888485376;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17004B38 RID: 19256
		// (get) Token: 0x060095BF RID: 38335 RVA: 0x008CB5C8 File Offset: 0x008C97C8
		// (set) Token: 0x060095C0 RID: 38336 RVA: 0x008CB680 File Offset: 0x008C9880
		public int FctOrdsRxSynthesizerReferenceDividerListTxRefDivMHz_A8924Value
		{
			get
			{
				short num = (short)127723772;
				short num2 = num;
				num = (short)1410590972;
				switch (num2 == num)
				{
				}
				num = (short)1834287104;
				short num3 = num;
				num = (short)705757184;
				if (num != 0)
				{
				}
				num = (short)1878786049;
				if (num != 0)
				{
				}
				return this.fctOrdsRxSynthesizerReferenceDividerListTxRefDivMHz_A8924.Value;
			}
			set
			{
				short num = (short)1405999029;
				short num2 = num;
				num = (short)1771755445;
				switch (num2 == num)
				{
				}
				num = (short)1606287360;
				short num3 = num;
				num = (short)1415839745;
				if (num != 0)
				{
				}
				num = (short)23986176;
				if (num != 0)
				{
				}
				this.fctOrdsRxSynthesizerReferenceDividerListTxRefDivMHz_A8924.Value = value;
			}
		}

		// Token: 0x17004B39 RID: 19257
		// (get) Token: 0x060095C1 RID: 38337 RVA: 0x008CB738 File Offset: 0x008C9938
		// (set) Token: 0x060095C2 RID: 38338 RVA: 0x008CB7EC File Offset: 0x008C99EC
		public string FctOrdsRxSynthesizerReferenceDividerListTxRefDivMHz_A8924_UIValue
		{
			get
			{
				short num = (short)2047106864;
				short num2 = num;
				num = (short)891313968;
				switch (num2 == num)
				{
				}
				num = (short)910753792;
				short num3 = num;
				num = (short)2128674817;
				if (num != 0)
				{
				}
				num = (short)1269956608;
				if (num != 0)
				{
				}
				return this.fctOrdsRxSynthesizerReferenceDividerListTxRefDivMHz_A8924.UIValue;
			}
			set
			{
				short num = (short)1258220740;
				short num2 = num;
				num = (short)79555780;
				switch (num2 == num)
				{
				}
				num = (short)952565760;
				short num3 = num;
				num = (short)142540801;
				if (num != 0)
				{
				}
				num = (short)77594624;
				if (num != 0)
				{
				}
				this.fctOrdsRxSynthesizerReferenceDividerListTxRefDivMHz_A8924.UIValue = value;
			}
		}

		// Token: 0x17004B3A RID: 19258
		// (get) Token: 0x060095C3 RID: 38339 RVA: 0x008CB8A4 File Offset: 0x008C9AA4
		public global::AcpBusinessLayer.AcpListField FctOrdsRxSynthesizerReferenceDividerListTxRefDivMHz_A8924
		{
			get
			{
				short num = (short)637067413;
				short num2 = num;
				num = (short)2019745941;
				switch (num2 == num)
				{
				}
				num = (short)1097924608;
				short num3 = num;
				num = (short)1516109825;
				if (num != 0)
				{
				}
				num = (short)589168640;
				if (num != 0)
				{
				}
				return this.fctOrdsRxSynthesizerReferenceDividerListTxRefDivMHz_A8924;
			}
		}

		// Token: 0x17004B3B RID: 19259
		// (get) Token: 0x060095C4 RID: 38340 RVA: 0x008CB954 File Offset: 0x008C9B54
		// (set) Token: 0x060095C5 RID: 38341 RVA: 0x008CBA08 File Offset: 0x008C9C08
		public bool FctOrdsRxSynthesizerReferenceDividerListTxRefDivMHz_A8924_Applicable
		{
			get
			{
				short num = (short)310494310;
				short num2 = num;
				num = (short)499696742;
				switch (num2 == num)
				{
				}
				num = (short)1458700288;
				short num3 = num;
				num = (short)68681729;
				if (num != 0)
				{
				}
				num = (short)910032896;
				if (num != 0)
				{
				}
				return this.fctOrdsRxSynthesizerReferenceDividerListTxRefDivMHz_A8924.Applicable;
			}
			set
			{
				short num = (short)499944005;
				short num2 = num;
				num = (short)1931840069;
				switch (num2 == num)
				{
				}
				num = (short)2040791040;
				short num3 = num;
				num = (short)1622933505;
				if (num != 0)
				{
				}
				num = (short)945750016;
				if (num != 0)
				{
				}
				this.fctOrdsRxSynthesizerReferenceDividerListTxRefDivMHz_A8924.Applicable = value;
			}
		}

		// Token: 0x17004B3C RID: 19260
		// (get) Token: 0x060095C6 RID: 38342 RVA: 0x008CBAC0 File Offset: 0x008C9CC0
		// (set) Token: 0x060095C7 RID: 38343 RVA: 0x008CBB74 File Offset: 0x008C9D74
		public bool FctOrdsRxSynthesizerReferenceDividerListTxRefDivMHz_A8924_Valid
		{
			get
			{
				short num = (short)878300760;
				short num2 = num;
				num = (short)1109970520;
				switch (num2 == num)
				{
				}
				num = (short)378601472;
				short num3 = num;
				num = (short)124059649;
				if (num != 0)
				{
				}
				num = (short)800129024;
				if (num != 0)
				{
				}
				return this.fctOrdsRxSynthesizerReferenceDividerListTxRefDivMHz_A8924.Valid;
			}
			set
			{
				short num = (short)2001416038;
				short num2 = num;
				num = (short)1303719782;
				switch (num2 == num)
				{
				}
				num = (short)2055733248;
				short num3 = num;
				num = (short)40304640;
				if (num != 0)
				{
				}
				num = (short)1199177729;
				if (num != 0)
				{
				}
				this.fctOrdsRxSynthesizerReferenceDividerListTxRefDivMHz_A8924.Valid = value;
			}
		}

		// Token: 0x17004B3D RID: 19261
		// (get) Token: 0x060095C8 RID: 38344 RVA: 0x008CBC2C File Offset: 0x008C9E2C
		// (set) Token: 0x060095C9 RID: 38345 RVA: 0x008CBCE0 File Offset: 0x008C9EE0
		public bool FctOrdsRxSynthesizerReferenceDividerListTxRefDivMHz_A8924_Visible
		{
			get
			{
				short num = (short)1869052585;
				short num2 = num;
				num = (short)203848361;
				switch (num2 == num)
				{
				}
				num = (short)1804402688;
				short num3 = num;
				num = (short)197001216;
				if (num != 0)
				{
				}
				num = (short)1121320961;
				if (num != 0)
				{
				}
				return this.fctOrdsRxSynthesizerReferenceDividerListTxRefDivMHz_A8924.Visible;
			}
			set
			{
				short num = (short)1871882227;
				short num2 = num;
				num = (short)1059563507;
				switch (num2 == num)
				{
				}
				num = (short)328990720;
				short num3 = num;
				num = (short)818348032;
				if (num != 0)
				{
				}
				num = (short)932249601;
				if (num != 0)
				{
				}
				this.fctOrdsRxSynthesizerReferenceDividerListTxRefDivMHz_A8924.Visible = value;
			}
		}

		// Token: 0x17004B3E RID: 19262
		// (get) Token: 0x060095CA RID: 38346 RVA: 0x008CBD94 File Offset: 0x008C9F94
		// (set) Token: 0x060095CB RID: 38347 RVA: 0x008CBE48 File Offset: 0x008CA048
		public bool FctOrdsRxSynthesizerReferenceDividerListTxRefDivMHz_A8924_Editable
		{
			get
			{
				short num = (short)1856248893;
				short num2 = num;
				num = (short)554245181;
				switch (num2 == num)
				{
				}
				num = (short)1808793600;
				short num3 = num;
				num = (short)1345716224;
				if (num != 0)
				{
				}
				num = (short)746389505;
				if (num != 0)
				{
				}
				return this.fctOrdsRxSynthesizerReferenceDividerListTxRefDivMHz_A8924.Editable;
			}
			set
			{
				short num = (short)315026344;
				short num2 = num;
				num = (short)1115679656;
				switch (num2 == num)
				{
				}
				num = (short)584974336;
				short num3 = num;
				num = (short)560791552;
				if (num != 0)
				{
				}
				num = (short)482082817;
				if (num != 0)
				{
				}
				this.fctOrdsRxSynthesizerReferenceDividerListTxRefDivMHz_A8924.Editable = value;
			}
		}

		// Token: 0x17004B3F RID: 19263
		// (get) Token: 0x060095CC RID: 38348 RVA: 0x008CBF04 File Offset: 0x008CA104
		internal string FctOrdsRxSynthesizerReferenceDividerListTxRefDivMHz_A8924_UILabel
		{
			get
			{
				short num = (short)1320638135;
				short num2 = num;
				num = (short)444159671;
				switch (num2 == num)
				{
				}
				num = (short)1868824576;
				short num3 = num;
				num = (short)936247297;
				if (num != 0)
				{
				}
				num = (short)754712576;
				if (num != 0)
				{
				}
				return this.fctOrdsRxSynthesizerReferenceDividerListTxRefDivMHz_A8924.UIName;
			}
		}

		// Token: 0x17004B40 RID: 19264
		// (get) Token: 0x060095CD RID: 38349 RVA: 0x008CBFB8 File Offset: 0x008CA1B8
		// (set) Token: 0x060095CE RID: 38350 RVA: 0x008CC074 File Offset: 0x008CA274
		internal bool FctOrdsRxSynthesizerReferenceDividerListTxRefDivMHz_A8924_HiddenStatic
		{
			get
			{
				short num = (short)1546382587;
				short num2 = num;
				num = (short)385412347;
				switch (num2 == num)
				{
				}
				num = (short)1027735552;
				short num3 = num;
				num = (short)95158273;
				if (num != 0)
				{
				}
				num = (short)1156579328;
				if (num != 0)
				{
				}
				return this.fctOrdsRxSynthesizerReferenceDividerListTxRefDivMHz_A8924.HiddenStatic;
			}
			set
			{
				short num = (short)669077554;
				short num2 = num;
				num = (short)1634095154;
				switch (num2 == num)
				{
				}
				num = (short)1889075200;
				short num3 = num;
				num = (short)418185216;
				if (num != 0)
				{
				}
				num = (short)484245505;
				if (num != 0)
				{
				}
				this.fctOrdsRxSynthesizerReferenceDividerListTxRefDivMHz_A8924.HiddenStatic = value;
			}
		}

		// Token: 0x17004B41 RID: 19265
		// (get) Token: 0x060095CF RID: 38351 RVA: 0x008CC12C File Offset: 0x008CA32C
		// (set) Token: 0x060095D0 RID: 38352 RVA: 0x008CC1E0 File Offset: 0x008CA3E0
		internal bool FctOrdsRxSynthesizerReferenceDividerListTxRefDivMHz_A8924_HiddenDynamic
		{
			get
			{
				short num = (short)785353866;
				short num2 = num;
				num = (short)232950922;
				switch (num2 == num)
				{
				}
				num = (short)402915328;
				short num3 = num;
				num = (short)1681784833;
				if (num != 0)
				{
				}
				num = (short)1973420032;
				if (num != 0)
				{
				}
				return this.fctOrdsRxSynthesizerReferenceDividerListTxRefDivMHz_A8924.HiddenDynamic;
			}
			set
			{
				short num = (short)854174425;
				short num2 = num;
				num = (short)881830617;
				switch (num2 == num)
				{
				}
				num = (short)419102720;
				short num3 = num;
				num = (short)34734081;
				if (num != 0)
				{
				}
				num = (short)379256832;
				if (num != 0)
				{
				}
				this.fctOrdsRxSynthesizerReferenceDividerListTxRefDivMHz_A8924.HiddenDynamic = value;
			}
		}

		// Token: 0x17004B42 RID: 19266
		// (get) Token: 0x060095D1 RID: 38353 RVA: 0x008CC294 File Offset: 0x008CA494
		public bool FctOrdsRxSynthesizerReferenceDividerListTxRefDivMHz_A8924_HasDiffs
		{
			get
			{
				short num = (short)1987375716;
				short num2 = num;
				num = (short)521794148;
				switch (num2 == num)
				{
				}
				num = (short)778305536;
				short num3 = num;
				num = (short)769261569;
				if (num != 0)
				{
				}
				num = (short)1997537280;
				if (num != 0)
				{
				}
				return this.fctOrdsRxSynthesizerReferenceDividerListTxRefDivMHz_A8924._HasDiffs;
			}
		}

		// Token: 0x17004B43 RID: 19267
		// (get) Token: 0x060095D2 RID: 38354 RVA: 0x008CC348 File Offset: 0x008CA548
		// (set) Token: 0x060095D3 RID: 38355 RVA: 0x008CC3FC File Offset: 0x008CA5FC
		public int FctOrdsTxSynthesizerReferenceDividerListTxFreqMHz_A9534Value
		{
			get
			{
				short num = (short)1752142185;
				short num2 = num;
				num = (short)1316786537;
				switch (num2 == num)
				{
				}
				num = (short)1145896960;
				short num3 = num;
				num = (short)2062614528;
				if (num != 0)
				{
				}
				num = (short)896729089;
				if (num != 0)
				{
				}
				return this.fctOrdsTxSynthesizerReferenceDividerListTxFreqMHz_A9534.Value;
			}
			set
			{
				short num = (short)192287919;
				short num2 = num;
				num = (short)296490159;
				switch (num2 == num)
				{
				}
				num = (short)1329397760;
				short num3 = num;
				num = (short)69140481;
				if (num != 0)
				{
				}
				num = (short)741933056;
				if (num != 0)
				{
				}
				this.fctOrdsTxSynthesizerReferenceDividerListTxFreqMHz_A9534.Value = value;
			}
		}

		// Token: 0x17004B44 RID: 19268
		// (get) Token: 0x060095D4 RID: 38356 RVA: 0x008CC4B0 File Offset: 0x008CA6B0
		// (set) Token: 0x060095D5 RID: 38357 RVA: 0x008CC568 File Offset: 0x008CA768
		public string FctOrdsTxSynthesizerReferenceDividerListTxFreqMHz_A9534_UIValue
		{
			get
			{
				short num = (short)1892514160;
				short num2 = num;
				num = (short)1488222576;
				switch (num2 == num)
				{
				}
				num = (short)743571456;
				short num3 = num;
				num = (short)2026373120;
				if (num != 0)
				{
				}
				num = (short)1420361729;
				if (num != 0)
				{
				}
				return this.fctOrdsTxSynthesizerReferenceDividerListTxFreqMHz_A9534.UIValue;
			}
			set
			{
				short num = (short)970086829;
				short num2 = num;
				num = (short)939809197;
				switch (num2 == num)
				{
				}
				num = (short)1749024768;
				short num3 = num;
				num = (short)2030960641;
				if (num != 0)
				{
				}
				num = (short)972095488;
				if (num != 0)
				{
				}
				this.fctOrdsTxSynthesizerReferenceDividerListTxFreqMHz_A9534.UIValue = value;
			}
		}

		// Token: 0x17004B45 RID: 19269
		// (get) Token: 0x060095D6 RID: 38358 RVA: 0x008CC61C File Offset: 0x008CA81C
		public global::AcpBusinessLayer.AcpFrequencyField FctOrdsTxSynthesizerReferenceDividerListTxFreqMHz_A9534
		{
			get
			{
				short num = (short)1048191770;
				short num2 = num;
				num = (short)332145434;
				switch (num2 == num)
				{
				}
				num = (short)913571840;
				short num3 = num;
				num = (short)1621491713;
				if (num != 0)
				{
				}
				num = (short)286326784;
				if (num != 0)
				{
				}
				return this.fctOrdsTxSynthesizerReferenceDividerListTxFreqMHz_A9534;
			}
		}

		// Token: 0x17004B46 RID: 19270
		// (get) Token: 0x060095D7 RID: 38359 RVA: 0x008CC6CC File Offset: 0x008CA8CC
		// (set) Token: 0x060095D8 RID: 38360 RVA: 0x008CC77C File Offset: 0x008CA97C
		internal int FctOrdsTxSynthesizerReferenceDividerListTxFreqMHz_A9534Min
		{
			get
			{
				short num = (short)2802583;
				short num2 = num;
				num = (short)60081047;
				switch (num2 == num)
				{
				}
				num = (short)1859846144;
				short num3 = num;
				num = (short)2048327681;
				if (num != 0)
				{
				}
				num = (short)1299775488;
				if (num != 0)
				{
				}
				return this.fctOrdsTxSynthesizerReferenceDividerListTxFreqMHz_A9534.Min;
			}
			set
			{
				short num = (short)880161977;
				short num2 = num;
				num = (short)945632441;
				switch (num2 == num)
				{
				}
				num = (short)795082752;
				short num3 = num;
				num = (short)733020161;
				if (num != 0)
				{
				}
				num = (short)130088960;
				if (num != 0)
				{
				}
				this.fctOrdsTxSynthesizerReferenceDividerListTxFreqMHz_A9534.Min = value;
			}
		}

		// Token: 0x17004B47 RID: 19271
		// (get) Token: 0x060095D9 RID: 38361 RVA: 0x008CC834 File Offset: 0x008CAA34
		// (set) Token: 0x060095DA RID: 38362 RVA: 0x008CC8EC File Offset: 0x008CAAEC
		internal int FctOrdsTxSynthesizerReferenceDividerListTxFreqMHz_A9534Max
		{
			get
			{
				short num = (short)1996069947;
				short num2 = num;
				num = (short)135371835;
				switch (num2 == num)
				{
				}
				num = (short)1299513344;
				short num3 = num;
				num = (short)1934819329;
				if (num != 0)
				{
				}
				num = (short)1665400832;
				if (num != 0)
				{
				}
				return this.fctOrdsTxSynthesizerReferenceDividerListTxFreqMHz_A9534.Max;
			}
			set
			{
				short num = (short)2016688704;
				short num2 = num;
				num = (short)184498752;
				switch (num2 == num)
				{
				}
				num = (short)749862912;
				short num3 = num;
				num = (short)192675841;
				if (num != 0)
				{
				}
				num = (short)973471744;
				if (num != 0)
				{
				}
				this.fctOrdsTxSynthesizerReferenceDividerListTxFreqMHz_A9534.Max = value;
			}
		}

		// Token: 0x17004B48 RID: 19272
		// (get) Token: 0x060095DB RID: 38363 RVA: 0x008CC9A0 File Offset: 0x008CABA0
		// (set) Token: 0x060095DC RID: 38364 RVA: 0x008CCA54 File Offset: 0x008CAC54
		internal int FctOrdsTxSynthesizerReferenceDividerListTxFreqMHz_A9534Step
		{
			get
			{
				short num = (short)1744644685;
				short num2 = num;
				num = (short)2022386253;
				switch (num2 == num)
				{
				}
				num = (short)1027604480;
				short num3 = num;
				num = (short)856686592;
				if (num != 0)
				{
				}
				num = (short)1660354561;
				if (num != 0)
				{
				}
				return this.fctOrdsTxSynthesizerReferenceDividerListTxFreqMHz_A9534.StepSize;
			}
			set
			{
				short num = (short)969015296;
				short num2 = num;
				num = (short)373385596;
				short num3 = num;
				num = (short)2068408700;
				switch (num3 == num)
				{
				}
				num = (short)774569985;
				if (num != 0)
				{
				}
				num = (short)1730609152;
				if (num != 0)
				{
				}
				this.fctOrdsTxSynthesizerReferenceDividerListTxFreqMHz_A9534.StepSize = value;
			}
		}

		// Token: 0x17004B49 RID: 19273
		// (get) Token: 0x060095DD RID: 38365 RVA: 0x008CCB0C File Offset: 0x008CAD0C
		// (set) Token: 0x060095DE RID: 38366 RVA: 0x008CCBC0 File Offset: 0x008CADC0
		public bool FctOrdsTxSynthesizerReferenceDividerListTxFreqMHz_A9534_Applicable
		{
			get
			{
				short num = (short)1590886400;
				short num2 = num;
				num = (short)917872751;
				short num3 = num;
				num = (short)743088239;
				switch (num3 == num)
				{
				}
				num = (short)1019936769;
				if (num != 0)
				{
				}
				num = (short)1162543104;
				if (num != 0)
				{
				}
				return this.fctOrdsTxSynthesizerReferenceDividerListTxFreqMHz_A9534.Applicable;
			}
			set
			{
				short num = (short)1123876864;
				short num2 = num;
				num = (short)1220018177;
				if (num != 0)
				{
				}
				num = (short)1744325059;
				short num3 = num;
				num = (short)1515538883;
				switch (num3 == num)
				{
				}
				num = (short)1200160768;
				if (num != 0)
				{
				}
				this.fctOrdsTxSynthesizerReferenceDividerListTxFreqMHz_A9534.Applicable = value;
			}
		}

		// Token: 0x17004B4A RID: 19274
		// (get) Token: 0x060095DF RID: 38367 RVA: 0x008CCC78 File Offset: 0x008CAE78
		// (set) Token: 0x060095E0 RID: 38368 RVA: 0x008CCD2C File Offset: 0x008CAF2C
		public bool FctOrdsTxSynthesizerReferenceDividerListTxFreqMHz_A9534_Valid
		{
			get
			{
				short num = (short)774111232;
				short num2 = num;
				num = (short)1435828225;
				if (num != 0)
				{
				}
				num = (short)391874321;
				short num3 = num;
				num = (short)1233028881;
				switch (num3 == num)
				{
				}
				num = (short)908197888;
				if (num != 0)
				{
				}
				return this.fctOrdsTxSynthesizerReferenceDividerListTxFreqMHz_A9534.Valid;
			}
			set
			{
				short num = (short)1631387648;
				short num2 = num;
				num = (short)909015071;
				short num3 = num;
				num = (short)1177122847;
				switch (num3 == num)
				{
				}
				num = (short)607256576;
				if (num != 0)
				{
				}
				num = (short)2085879809;
				if (num != 0)
				{
				}
				this.fctOrdsTxSynthesizerReferenceDividerListTxFreqMHz_A9534.Valid = value;
			}
		}

		// Token: 0x17004B4B RID: 19275
		// (get) Token: 0x060095E1 RID: 38369 RVA: 0x008CCDE0 File Offset: 0x008CAFE0
		// (set) Token: 0x060095E2 RID: 38370 RVA: 0x008CCE94 File Offset: 0x008CB094
		public bool FctOrdsTxSynthesizerReferenceDividerListTxFreqMHz_A9534_Visible
		{
			get
			{
				short num = (short)1054867456;
				short num2 = num;
				num = (short)1722358745;
				short num3 = num;
				num = (short)635116505;
				switch (num3 == num)
				{
				}
				num = (short)893583361;
				if (num != 0)
				{
				}
				num = (short)1576599552;
				if (num != 0)
				{
				}
				return this.fctOrdsTxSynthesizerReferenceDividerListTxFreqMHz_A9534.Visible;
			}
			set
			{
				short num = (short)1439105024;
				short num2 = num;
				num = (short)843264483;
				short num3 = num;
				num = (short)1767715299;
				switch (num3 == num)
				{
				}
				num = (short)2077622273;
				if (num != 0)
				{
				}
				num = (short)2043281408;
				if (num != 0)
				{
				}
				this.fctOrdsTxSynthesizerReferenceDividerListTxFreqMHz_A9534.Visible = value;
			}
		}

		// Token: 0x17004B4C RID: 19276
		// (get) Token: 0x060095E3 RID: 38371 RVA: 0x008CCF48 File Offset: 0x008CB148
		// (set) Token: 0x060095E4 RID: 38372 RVA: 0x008CCFFC File Offset: 0x008CB1FC
		public bool FctOrdsTxSynthesizerReferenceDividerListTxFreqMHz_A9534_Editable
		{
			get
			{
				short num = (short)1675558912;
				short num2 = num;
				num = (short)1129362462;
				short num3 = num;
				num = (short)1723577374;
				switch (num3 == num)
				{
				}
				num = (short)1420099585;
				if (num != 0)
				{
				}
				num = (short)1935867904;
				if (num != 0)
				{
				}
				return this.fctOrdsTxSynthesizerReferenceDividerListTxFreqMHz_A9534.Editable;
			}
			set
			{
				short num = (short)1496514560;
				short num2 = num;
				num = (short)339243795;
				short num3 = num;
				num = (short)17462035;
				switch (num3 == num)
				{
				}
				num = (short)419364865;
				if (num != 0)
				{
				}
				num = (short)810876928;
				if (num != 0)
				{
				}
				this.fctOrdsTxSynthesizerReferenceDividerListTxFreqMHz_A9534.Editable = value;
			}
		}

		// Token: 0x17004B4D RID: 19277
		// (get) Token: 0x060095E5 RID: 38373 RVA: 0x008CD0B4 File Offset: 0x008CB2B4
		internal string FctOrdsTxSynthesizerReferenceDividerListTxFreqMHz_A9534_UILabel
		{
			get
			{
				short num = (short)1952579584;
				short num2 = num;
				num = (short)442055908;
				short num3 = num;
				num = (short)1346649316;
				switch (num3 == num)
				{
				}
				num = (short)1398669312;
				if (num != 0)
				{
				}
				num = (short)2050359297;
				if (num != 0)
				{
				}
				return this.fctOrdsTxSynthesizerReferenceDividerListTxFreqMHz_A9534.UIName;
			}
		}

		// Token: 0x17004B4E RID: 19278
		// (get) Token: 0x060095E6 RID: 38374 RVA: 0x008CD168 File Offset: 0x008CB368
		// (set) Token: 0x060095E7 RID: 38375 RVA: 0x008CD21C File Offset: 0x008CB41C
		internal bool FctOrdsTxSynthesizerReferenceDividerListTxFreqMHz_A9534_HiddenStatic
		{
			get
			{
				short num = (short)1009254400;
				short num2 = num;
				num = (short)114748877;
				short num3 = num;
				num = (short)2142694861;
				switch (num3 == num)
				{
				}
				num = (short)1137115136;
				if (num != 0)
				{
				}
				num = (short)549781505;
				if (num != 0)
				{
				}
				return this.fctOrdsTxSynthesizerReferenceDividerListTxFreqMHz_A9534.HiddenStatic;
			}
			set
			{
				short num = (short)1467875328;
				short num2 = num;
				num = (short)617180085;
				short num3 = num;
				num = (short)121924533;
				switch (num3 == num)
				{
				}
				num = (short)1953366017;
				if (num != 0)
				{
				}
				num = (short)1722548224;
				if (num != 0)
				{
				}
				this.fctOrdsTxSynthesizerReferenceDividerListTxFreqMHz_A9534.HiddenStatic = value;
			}
		}

		// Token: 0x17004B4F RID: 19279
		// (get) Token: 0x060095E8 RID: 38376 RVA: 0x008CD2D0 File Offset: 0x008CB4D0
		// (set) Token: 0x060095E9 RID: 38377 RVA: 0x008CD384 File Offset: 0x008CB584
		internal bool FctOrdsTxSynthesizerReferenceDividerListTxFreqMHz_A9534_HiddenDynamic
		{
			get
			{
				short num = (short)844300288;
				short num2 = num;
				num = (short)921400717;
				short num3 = num;
				num = (short)1787327885;
				switch (num3 == num)
				{
				}
				num = (short)1688797185;
				if (num != 0)
				{
				}
				num = (short)1971257344;
				if (num != 0)
				{
				}
				return this.fctOrdsTxSynthesizerReferenceDividerListTxFreqMHz_A9534.HiddenDynamic;
			}
			set
			{
				short num = (short)1489829888;
				short num2 = num;
				num = (short)1151637068;
				short num3 = num;
				num = (short)1823970892;
				switch (num3 == num)
				{
				}
				num = (short)1599471617;
				if (num != 0)
				{
				}
				num = (short)275447808;
				if (num != 0)
				{
				}
				this.fctOrdsTxSynthesizerReferenceDividerListTxFreqMHz_A9534.HiddenDynamic = value;
			}
		}

		// Token: 0x17004B50 RID: 19280
		// (get) Token: 0x060095EA RID: 38378 RVA: 0x008CD43C File Offset: 0x008CB63C
		public bool FctOrdsTxSynthesizerReferenceDividerListTxFreqMHz_A9534_HasDiffs
		{
			get
			{
				short num = (short)2009399296;
				short num2 = num;
				num = (short)1580940388;
				short num3 = num;
				num = (short)135281764;
				switch (num3 == num)
				{
				}
				num = (short)1871314944;
				if (num != 0)
				{
				}
				num = (short)1064173569;
				if (num != 0)
				{
				}
				return this.fctOrdsTxSynthesizerReferenceDividerListTxFreqMHz_A9534._HasDiffs;
			}
		}

		// Token: 0x17004B51 RID: 19281
		// (get) Token: 0x060095EB RID: 38379 RVA: 0x008CD4F0 File Offset: 0x008CB6F0
		public global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation RefRadioInformation
		{
			get
			{
				short num = (short)238092288;
				short num2 = num;
				num = (short)1500358305;
				short num3 = num;
				num = (short)1086039713;
				switch (num3 == num)
				{
				}
				num = (short)430178304;
				if (num != 0)
				{
				}
				num = (short)1311506433;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation;
			}
		}

		// Token: 0x060095EC RID: 38380 RVA: 0x008CD5B0 File Offset: 0x008CB7B0
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
						num2 = (short)1826553859;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 1:
					goto IL_FA;
				case 2:
					goto IL_13B;
				case 3:
				{
					num2 = (short)216179030;
					short num3 = num2;
					num2 = (short)1278189910;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_13B;
					default:
						num2 = (short)554106880;
						if (num2 != 0)
						{
						}
						num2 = (short)957939714;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 4:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)467533825;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_24;
				IL_13B:
				if (base.ParentRecset.ContainerDoc == null)
				{
					return result;
				}
				num2 = (short)584777732;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_FA:
			num2 = (short)1617821697;
			if (num2 != 0)
			{
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)1007943680;
			short num4 = num2;
			num2 = (short)2008154112;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04004A11 RID: 18961
		private global::AcpBusinessLayer.AcpListField fctOrdsRxSynthesizerReferenceDividerListTxRefDivMHz_A8924;

		// Token: 0x04004A12 RID: 18962
		private global::AcpBusinessLayer.AcpFrequencyField fctOrdsTxSynthesizerReferenceDividerListTxFreqMHz_A9534;
	}
}
