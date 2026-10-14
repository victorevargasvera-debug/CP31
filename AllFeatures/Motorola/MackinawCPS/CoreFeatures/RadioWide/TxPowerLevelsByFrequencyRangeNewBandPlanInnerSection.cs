using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using Motorola.MackinawCPS.CoreFeatures.RadioInformation;

namespace Motorola.MackinawCPS.CoreFeatures.RadioWide
{
	// Token: 0x02000192 RID: 402
	[global::System.Serializable]
	public class TxPowerLevelsByFrequencyRangeNewBandPlanInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06004163 RID: 16739 RVA: 0x003D2370 File Offset: 0x003D0570
		public TxPowerLevelsByFrequencyRangeNewBandPlanInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06004164 RID: 16740 RVA: 0x003D238C File Offset: 0x003D058C
		protected TxPowerLevelsByFrequencyRangeNewBandPlanInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06004165 RID: 16741 RVA: 0x003D23A4 File Offset: 0x003D05A4
		public override void Init()
		{
			int a_ = 6;
			short num = (short)483000320;
			short num2 = num;
			num = (short)1270490959;
			short num3 = num;
			num = (short)1209083727;
			switch (num3 == num)
			{
			}
			num = (short)1675821057;
			if (num != 0)
			{
			}
			num = (short)2048262144;
			if (num != 0)
			{
			}
			this.radWideTransmitPowerLevelsTxPowerLevelHighW_A41854 = new global::AcpBusinessLayer.AcpRangeField<int, string>(37993, new global::Motorola.MackinawCPS.CoreFeatures.RadioWide.ConvertTxPowerLevelValues(), this, global::AllFeatures.CodeplugGuid.b("闆꣈꿊髌ꛎ뗐뛒臔ꗖ룘뗚껜닞裠韢뗤裦黨軪鿬ꏮ铰藲郴鯶諸꿺藼꿾渀琂怄甆䔈渊笌樎紐嬒簔瀖焘䰚䈜帞ᔠሢᴤሦᴨ", a_), global::CommonResources.AcgResources.ID_TXPOWERLEVELHIGHW, 10000, 60000, 1);
			this.radWideTransmitPowerLevelsTxPowerLevelHighW_A41854.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radWideTransmitPowerLevelsTxPowerLevelHighW_A41854.DataTransferOrder = 228;
			this.radWideTransmitPowerLevelsTxPowerLevelHighW_A41854.ShowHexValue = false;
			this.radWideTransmitPowerLevelsTxPowerLevelLowW_A41855 = new global::AcpBusinessLayer.AcpRangeField<int, string>(30792, new global::Motorola.MackinawCPS.CoreFeatures.RadioWide.ConvertTxPowerLevelValues(), this, global::AllFeatures.CodeplugGuid.b("闆꣈꿊髌ꛎ뗐뛒臔ꗖ룘뗚껜닞裠韢뗤裦黨軪鿬ꏮ铰藲郴鯶諸꿺藼꿾渀琂怄甆䔈渊笌樎紐弒稔怖丘䐚尜⬞ဠᬢဤሦ", a_), global::CommonResources.AcgResources.ID_TXPOWERLEVELLOWW, 10000, 60000, 1);
			this.radWideTransmitPowerLevelsTxPowerLevelLowW_A41855.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radWideTransmitPowerLevelsTxPowerLevelLowW_A41855.DataTransferOrder = 225;
			this.radWideTransmitPowerLevelsTxPowerLevelLowW_A41855.ShowHexValue = false;
			this.radWideTransmitPowerLevelsFrequencyRangeStartMHz_A41856 = new global::AcpBusinessLayer.AcpFrequencyField(27200000, this, global::AllFeatures.CodeplugGuid.b("闆꣈꿊髌ꛎ뗐뛒臔ꗖ룘뗚껜닞裠韢뗤裦黨軪鿬ꏮ铰藲郴鯶諸뷺迼髾瀀瘂怄椆樈爊弌渎缐琒瀔䐖洘稚漜欞氠欢弤砦栨ἪᰬᜮаԲ", a_), global::CommonResources.AcgResources.ID_FREQUENCYRANGESTARTMHZ, 0, 199999999, 1);
			this.radWideTransmitPowerLevelsFrequencyRangeStartMHz_A41856.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radWideTransmitPowerLevelsFrequencyRangeStartMHz_A41856.DataTransferOrder = 220;
			this.radWideTransmitPowerLevelsFrequencyRangeEndMHz_A41857 = new global::AcpBusinessLayer.AcpFrequencyField(35000000, this, global::AllFeatures.CodeplugGuid.b("闆꣈꿊髌ꛎ뗐뛒臔ꗖ룘뗚껜닞裠韢뗤裦黨軪鿬ꏮ铰藲郴鯶諸뷺迼髾瀀瘂怄椆樈爊弌渎缐琒瀔刖眘缚倜圞嬠簢搤ጦᠨጪᠬᠮ", a_), global::CommonResources.AcgResources.ID_FREQUENCYRANGEENDMHZ, 0, 199999999, 1);
			this.radWideTransmitPowerLevelsFrequencyRangeEndMHz_A41857.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radWideTransmitPowerLevelsFrequencyRangeEndMHz_A41857.DataTransferOrder = 221;
			this.radWideTransmitPowerLevelsTxPowerLevelMinimumW_A41858 = new global::AcpBusinessLayer.AcpRangeField<int, string>(30000, new global::Motorola.MackinawCPS.CoreFeatures.RadioWide.ConvertTxPowerLevelValues(), this, global::AllFeatures.CodeplugGuid.b("闆꣈꿊髌ꛎ뗐뛒臔ꗖ룘뗚껜닞裠韢뗤裦黨軪鿬ꏮ铰藲郴鯶諸꿺藼꿾渀琂怄甆䔈渊笌樎紐帒簔礖瀘瘚栜爞瘠簢搤ጦᠨጪᠬᜮ", a_), global::CommonResources.AcgResources.ID_TXPOWERLEVELMINIMUMW, 10000, 60000, 1);
			this.radWideTransmitPowerLevelsTxPowerLevelMinimumW_A41858.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radWideTransmitPowerLevelsTxPowerLevelMinimumW_A41858.DataTransferOrder = 222;
			this.radWideTransmitPowerLevelsTxPowerLevelMinimumW_A41858.ShowHexValue = false;
			this.radWideTransmitPowerLevelsTxPowerLevelMaximumW_A41859 = new global::AcpBusinessLayer.AcpRangeField<int, string>(37993, new global::Motorola.MackinawCPS.CoreFeatures.RadioWide.ConvertTxPowerLevelValues(), this, global::AllFeatures.CodeplugGuid.b("闆꣈꿊髌ꛎ뗐뛒臔ꗖ룘뗚껜닞裠韢뗤裦黨軪鿬ꏮ铰藲郴鯶諸꿺藼꿾渀琂怄甆䔈渊笌樎紐帒琔漖瀘瘚栜爞瘠簢搤ጦᠨጪᠬᘮ", a_), global::CommonResources.AcgResources.ID_TXPOWERLEVELMAXIMUMW, 10000, 60000, 1);
			this.radWideTransmitPowerLevelsTxPowerLevelMaximumW_A41859.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radWideTransmitPowerLevelsTxPowerLevelMaximumW_A41859.DataTransferOrder = 219;
			this.radWideTransmitPowerLevelsTxPowerLevelMaximumW_A41859.ShowHexValue = false;
			this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41860 = new global::AcpBusinessLayer.AcpRangeField<int, string>(30792, new global::Motorola.MackinawCPS.CoreFeatures.RadioWide.ConvertTxPowerLevelValues(), this, global::AllFeatures.CodeplugGuid.b("闆꣈꿊髌ꛎ뗐뛒臔ꗖ룘뗚껜닞裠韢뗤裦黨軪鿬ꏮ铰藲郴鯶諸꿺迼链唀笂唄栆縈渊缌䌎琐攒瀔笖唘琚樜䠞縠戢ᄤᘦᄨᴪᴬ", a_), global::CommonResources.AcgResources.ID_TRKTXPOWERLEVELLOWW, 10000, 60000, 1);
			this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41860.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41860.DataTransferOrder = 227;
			this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41860.ShowHexValue = false;
			this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41861 = new global::AcpBusinessLayer.AcpRangeField<int, string>(30792, new global::Motorola.MackinawCPS.CoreFeatures.RadioWide.ConvertTxPowerLevelValues(), this, global::AllFeatures.CodeplugGuid.b("闆꣈꿊髌ꛎ뗐뛒臔ꗖ룘뗚껜닞裠韢뗤裦黨軪鿬ꏮ铰藲郴鯶諸룺鋼釾眀圂約圆昈簊栌紎崐瘒挔爖甘圚爜栞瘠簢搤ጦᠨጪᬬḮ", a_), global::CommonResources.AcgResources.ID_CNVTXPOWERLEVELLOWW, 10000, 60000, 1);
			this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41861.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41861.DataTransferOrder = 226;
			this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41861.ShowHexValue = false;
			this.radWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41862 = new global::AcpBusinessLayer.AcpRangeField<int, string>(30000, new global::Motorola.MackinawCPS.CoreFeatures.RadioWide.ConvertTxPowerLevelValues(), this, global::AllFeatures.CodeplugGuid.b("闆꣈꿊髌ꛎ뗐뛒臔ꗖ룘뗚껜닞裠韢뗤裦黨軪鿬ꏮ铰藲郴鯶諸꿺迼链唀笂唄栆縈渊缌䌎琐攒瀔笖吘爚猜瘞䰠嘢䠤瀦瘨横᤬ḮरԲܴ", a_), global::CommonResources.AcgResources.ID_TRKTXPOWERLEVELMINIMUMW, 10000, 60000, 1);
			this.radWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41862.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41862.DataTransferOrder = 224;
			this.radWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41862.ShowHexValue = false;
			this.radWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41863 = new global::AcpBusinessLayer.AcpRangeField<int, string>(30000, new global::Motorola.MackinawCPS.CoreFeatures.RadioWide.ConvertTxPowerLevelValues(), this, global::AllFeatures.CodeplugGuid.b("闆꣈꿊髌ꛎ뗐뛒臔ꗖ룘뗚껜닞裠韢뗤裦黨軪鿬ꏮ铰藲郴鯶諸룺鋼釾眀圂約圆昈簊栌紎崐瘒挔爖甘嘚琜焞䠠丢値䨦縨琪氬ᬮ0ଲ̴ж", a_), global::CommonResources.AcgResources.ID_CNVTXPOWERLEVELMINIMUMW, 10000, 60000, 1);
			this.radWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41863.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41863.DataTransferOrder = 223;
			this.radWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41863.ShowHexValue = false;
			this.radWidePowerLevelBandFrequency_A41864 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_VHF, this, global::AllFeatures.CodeplugGuid.b("闆꣈꿊髌ꛎ뗐뛒藔룖께뻚꿜鏞蓠闢胤详ꯨ諪菬诮런臲郴蛶賸黺鏼鳾砀専䐄㌆㠈㌊㬌㬎", a_), global::CommonResources.AcgResources.ID_FREQUENCYBAND, 100);
			this.radWidePowerLevelBandFrequency_A41864.IgnoreOnCompare = true;
			this.radWidePowerLevelBandFrequency_A41864.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radWidePowerLevelBandFrequency_A41864.DataTransferOrder = -1;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鏆뇈鷌ꃎꛐ뛒꟔闘뻚ꯜ뫞跠郢", a_);
			base.Id = 10762;
			base.UIName = global::CommonResources.AcgResources.ID_TXPOWERLEVELS;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06004166 RID: 16742 RVA: 0x003D2840 File Offset: 0x003D0A40
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 14;
			short num = (short)2142765066;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_65B;
				case 1:
					this.radWideTransmitPowerLevelsTxPowerLevelHighW_A41854 = new global::AcpBusinessLayer.AcpRangeField<int, string>(37993, new global::Motorola.MackinawCPS.CoreFeatures.RadioWide.ConvertTxPowerLevelValues(), this, global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚觜귞胠跢雤諦胨鿪뷬胮蛰雲蟴믶鳸跺飼鏾爀圂約圆昈簊栌紎崐瘒挔爖甘匚琜砞䤠琢稤昦ᴨᨪᔬᨮ԰", a_), global::CommonResources.AcgResources.ID_TXPOWERLEVELHIGHW);
					this.radWideTransmitPowerLevelsTxPowerLevelHighW_A41854.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radWideTransmitPowerLevelsTxPowerLevelHighW_A41854.DataTransferOrder = 228;
					this.radWideTransmitPowerLevelsTxPowerLevelHighW_A41854.ShowHexValue = false;
					num = (short)1590820878;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					this.radWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41862 = new global::AcpBusinessLayer.AcpRangeField<int, string>(30000, new global::Motorola.MackinawCPS.CoreFeatures.RadioWide.ConvertTxPowerLevelValues(), this, global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚觜귞胠跢雤諦胨鿪뷬胮蛰雲蟴믶鳸跺飼鏾爀圂眄氆崈猊崌怎昐瘒朔嬖簘洚砜猞氠䨢䬤並䐨帪䀬砮渰爲Ĵضĸഺ༼", a_), global::CommonResources.AcgResources.ID_TRKTXPOWERLEVELMINIMUMW);
					this.radWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41862.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41862.DataTransferOrder = 224;
					this.radWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41862.ShowHexValue = false;
					num = (short)322568217;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚觜귞胠跢雤諦胨鿪뷬胮蛰雲蟴믶鳸跺飼鏾爀䔂眄戆砈縊栌愎爐樒䜔瘖眘簚砜娞传䜢栤漦匨琪氬ᬮ0ଲ46", a_)))
					{
						num = (short)725352454;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_7A9;
				case 4:
					this.radWideTransmitPowerLevelsTxPowerLevelMaximumW_A41859 = new global::AcpBusinessLayer.AcpRangeField<int, string>(37993, new global::Motorola.MackinawCPS.CoreFeatures.RadioWide.ConvertTxPowerLevelValues(), this, global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚觜귞胠跢雤諦胨鿪뷬胮蛰雲蟴믶鳸跺飼鏾爀圂約圆昈簊栌紎崐瘒挔爖甘嘚簜朞䠠丢値䨦縨琪氬ᬮ0ଲ4ึ", a_), global::CommonResources.AcgResources.ID_TXPOWERLEVELMAXIMUMW);
					this.radWideTransmitPowerLevelsTxPowerLevelMaximumW_A41859.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radWideTransmitPowerLevelsTxPowerLevelMaximumW_A41859.DataTransferOrder = 219;
					this.radWideTransmitPowerLevelsTxPowerLevelMaximumW_A41859.ShowHexValue = false;
					num = (short)96862236;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					num = (short)1467285537;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					this.radWideTransmitPowerLevelsFrequencyRangeEndMHz_A41857 = new global::AcpBusinessLayer.AcpFrequencyField(35000000, this, global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚觜귞胠跢雤諦胨鿪뷬胮蛰雲蟴믶鳸跺飼鏾爀䔂眄戆砈縊栌愎爐樒䜔瘖眘簚砜娞传䜢栤漦匨琪氬ᬮ0ଲ46", a_), global::CommonResources.AcgResources.ID_FREQUENCYRANGEENDMHZ);
					this.radWideTransmitPowerLevelsFrequencyRangeEndMHz_A41857.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radWideTransmitPowerLevelsFrequencyRangeEndMHz_A41857.DataTransferOrder = 221;
					num = (short)96469004;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚觜귞胠跢雤諦胨鿪뷬胮蛰雲蟴믶鳸跺飼鏾爀圂眄氆崈猊崌怎昐瘒朔嬖簘洚砜猞洠䰢判瀦瘨横᤬ḮरԲԴ", a_)))
					{
						num = (short)1626865687;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2EA;
				case 8:
					goto IL_2EA;
				case 9:
					this.radWidePowerLevelBandFrequency_A41864 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_VHF, this, global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚跜냞雠蛢韤ꯦ賨鷪裬菮돰鋲鯴鏶뿸觺飼軾琀昂欄搆瀈吊䰌㬎‐⬒⌔⌖", a_), global::CommonResources.AcgResources.ID_FREQUENCYBAND, 100);
					this.radWidePowerLevelBandFrequency_A41864.IgnoreOnCompare = true;
					this.radWidePowerLevelBandFrequency_A41864.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radWidePowerLevelBandFrequency_A41864.DataTransferOrder = -1;
					num = (short)1856110605;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					switch (0)
					{
					case 0:
						goto IL_C2;
					}
					continue;
				case 11:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚觜귞胠跢雤諦胨鿪뷬胮蛰雲蟴믶鳸跺飼鏾爀圂約圆昈簊栌紎崐瘒挔爖甘嘚琜焞䠠丢値䨦縨琪氬ᬮ0ଲ4༶", a_)))
					{
						num = (short)405405730;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_386;
				case 12:
					goto IL_7A9;
				case 13:
					goto IL_517;
				case 14:
					goto IL_5B3;
				case 15:
					if (producerFields != null)
					{
						num = (short)712048645;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_993;
				case 16:
					IL_3EB:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚觜귞胠跢雤諦胨鿪뷬胮蛰雲蟴믶鳸跺飼鏾爀䔂眄戆砈縊栌愎爐樒䜔瘖眘簚砜䰞唠䈢圤匦搨挪圬瀮瀰ܲд༶సഺ", a_)))
					{
						num = (short)1720320000;
						short num3 = num;
						num = (short)2072510499;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_65B;
				case 17:
					this.radWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41863 = new global::AcpBusinessLayer.AcpRangeField<int, string>(30000, new global::Motorola.MackinawCPS.CoreFeatures.RadioWide.ConvertTxPowerLevelValues(), this, global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚觜귞胠跢雤諦胨鿪뷬胮蛰雲蟴믶鳸跺飼鏾爀䀂樄椆缈弊甌弎縐搒瀔攖唘縚欜稞䴠渢䰤䤦䀨䘪堬䈮昰氲琴̶࠸଼̺ా", a_), global::CommonResources.AcgResources.ID_CNVTXPOWERLEVELMINIMUMW);
					this.radWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41863.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41863.DataTransferOrder = 223;
					this.radWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41863.ShowHexValue = false;
					num = (short)338624548;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 18:
					goto IL_3D3;
				case 19:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚觜귞胠跢雤諦胨鿪뷬胮蛰雲蟴믶鳸跺飼鏾爀䀂樄椆缈弊甌弎縐搒瀔攖唘縚欜稞䴠渢䰤䤦䀨䘪堬䈮昰氲琴̶࠸଼̺ా", a_)))
					{
						num = (short)1634205713;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_339;
				case 20:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚觜귞胠跢雤諦胨鿪뷬胮蛰雲蟴믶鳸跺飼鏾爀圂約圆昈簊栌紎崐瘒挔爖甘圚爜栞瘠簢搤ጦᠨጪᠬᨮ", a_)))
					{
						num = (short)1886453784;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3D3;
				case 21:
					num = (short)1928921103;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 22:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚觜귞胠跢雤諦胨鿪뷬胮蛰雲蟴믶鳸跺飼鏾爀圂約圆昈簊栌紎崐瘒挔爖甘嘚簜朞䠠丢値䨦縨琪氬ᬮ0ଲ4ึ", a_)))
					{
						num = (short)2032402436;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_8AC;
				case 23:
					this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41860 = new global::AcpBusinessLayer.AcpRangeField<int, string>(30792, new global::Motorola.MackinawCPS.CoreFeatures.RadioWide.ConvertTxPowerLevelValues(), this, global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚觜귞胠跢雤諦胨鿪뷬胮蛰雲蟴믶鳸跺飼鏾爀圂眄氆崈猊崌怎昐瘒朔嬖簘洚砜猞洠䰢判瀦瘨横᤬ḮरԲԴ", a_), global::CommonResources.AcgResources.ID_TRKTXPOWERLEVELLOWW);
					this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41860.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41860.DataTransferOrder = 227;
					this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41860.ShowHexValue = false;
					num = (short)753139713;
					if (num != 0)
					{
					}
					num = (short)2017722376;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 24:
					this.radWideTransmitPowerLevelsTxPowerLevelLowW_A41855 = new global::AcpBusinessLayer.AcpRangeField<int, string>(30792, new global::Motorola.MackinawCPS.CoreFeatures.RadioWide.ConvertTxPowerLevelValues(), this, global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚觜귞胠跢雤諦胨鿪뷬胮蛰雲蟴믶鳸跺飼鏾爀圂約圆昈簊栌紎崐瘒挔爖甘圚爜栞瘠簢搤ጦᠨጪᠬᨮ", a_), global::CommonResources.AcgResources.ID_TXPOWERLEVELLOWW);
					this.radWideTransmitPowerLevelsTxPowerLevelLowW_A41855.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radWideTransmitPowerLevelsTxPowerLevelLowW_A41855.DataTransferOrder = 225;
					this.radWideTransmitPowerLevelsTxPowerLevelLowW_A41855.ShowHexValue = false;
					num = (short)2117730322;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 25:
					goto IL_22F;
				case 26:
					goto IL_946;
				case 27:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚觜귞胠跢雤諦胨鿪뷬胮蛰雲蟴믶鳸跺飼鏾爀圂眄氆崈猊崌怎昐瘒朔嬖簘洚砜猞氠䨢䬤並䐨帪䀬砮渰爲Ĵضĸഺ༼", a_)))
					{
						num = (short)2105212930;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_22F;
				case 28:
					goto IL_8AC;
				case 29:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚觜귞胠跢雤諦胨鿪뷬胮蛰雲蟴믶鳸跺飼鏾爀䀂樄椆缈弊甌弎縐搒瀔攖唘縚欜稞䴠漢䨤倦縨琪氬ᬮ0ଲ̴ض", a_)))
					{
						num = (short)874577952;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_946;
				case 30:
					goto IL_386;
				case 31:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚跜냞雠蛢韤ꯦ賨鷪裬菮돰鋲鯴鏶뿸觺飼軾琀昂欄搆瀈吊䰌㬎‐⬒⌔⌖", a_)))
					{
						num = (short)1763311625;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_993;
				case 32:
					this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41861 = new global::AcpBusinessLayer.AcpRangeField<int, string>(30792, new global::Motorola.MackinawCPS.CoreFeatures.RadioWide.ConvertTxPowerLevelValues(), this, global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚觜귞胠跢雤諦胨鿪뷬胮蛰雲蟴믶鳸跺飼鏾爀䀂樄椆缈弊甌弎縐搒瀔攖唘縚欜稞䴠漢䨤倦縨琪氬ᬮ0ଲ̴ض", a_), global::CommonResources.AcgResources.ID_CNVTXPOWERLEVELLOWW);
					this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41861.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41861.DataTransferOrder = 226;
					this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41861.ShowHexValue = false;
					num = (short)637141018;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 33:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚觜귞胠跢雤諦胨鿪뷬胮蛰雲蟴믶鳸跺飼鏾爀圂約圆昈簊栌紎崐瘒挔爖甘匚琜砞䤠琢稤昦ᴨᨪᔬᨮ԰", a_)))
					{
						num = (short)584843265;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5B3;
				case 34:
					this.radWideTransmitPowerLevelsTxPowerLevelMinimumW_A41858 = new global::AcpBusinessLayer.AcpRangeField<int, string>(30000, new global::Motorola.MackinawCPS.CoreFeatures.RadioWide.ConvertTxPowerLevelValues(), this, global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚觜귞胠跢雤諦胨鿪뷬胮蛰雲蟴믶鳸跺飼鏾爀圂約圆昈簊栌紎崐瘒挔爖甘嘚琜焞䠠丢値䨦縨琪氬ᬮ0ଲ4༶", a_), global::CommonResources.AcgResources.ID_TXPOWERLEVELMINIMUMW);
					this.radWideTransmitPowerLevelsTxPowerLevelMinimumW_A41858.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radWideTransmitPowerLevelsTxPowerLevelMinimumW_A41858.DataTransferOrder = 222;
					this.radWideTransmitPowerLevelsTxPowerLevelMinimumW_A41858.ShowHexValue = false;
					num = (short)581435422;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 35:
					this.radWideTransmitPowerLevelsFrequencyRangeStartMHz_A41856 = new global::AcpBusinessLayer.AcpFrequencyField(27200000, this, global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚觜귞胠跢雤諦胨鿪뷬胮蛰雲蟴믶鳸跺飼鏾爀䔂眄戆砈縊栌愎爐樒䜔瘖眘簚砜䰞唠䈢圤匦搨挪圬瀮瀰ܲд༶సഺ", a_), global::CommonResources.AcgResources.ID_FREQUENCYRANGESTARTMHZ);
					this.radWideTransmitPowerLevelsFrequencyRangeStartMHz_A41856.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radWideTransmitPowerLevelsFrequencyRangeStartMHz_A41856.DataTransferOrder = 220;
					num = (short)1633419264;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 36:
					goto IL_339;
				}
				IL_C2:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)2130575381;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_22F:
				num = (short)886833171;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2EA:
				num = (short)1018036253;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_339:
				num = (short)769916959;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_386:
				num = (short)1530527766;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3D3:
				num = (short)101318672;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_7A9:
				num = (short)1639371187;
				short num4 = num;
				num = (short)2139017651;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_3EB;
				default:
					num = (short)737869824;
					if (num != 0)
					{
					}
					num = (short)155320331;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_5B3:
				num = (short)1357905940;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_65B:
				num = (short)990642179;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_8AC:
				num = (short)683474951;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_946:
				num = (short)217841691;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_517:
			IL_993:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鯎꧐藔룖께뻚꿜￞균蛢鏤苦藨飪", a_);
			base.Id = 10762;
			base.UIName = global::CommonResources.AcgResources.ID_TXPOWERLEVELS;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06004167 RID: 16743 RVA: 0x003D3214 File Offset: 0x003D1414
		public override void PopulateReferences()
		{
			short num = (short)183212973;
			short num2 = num;
			num = (short)1164352429;
			switch (num2 == num)
			{
			}
			num = (short)665518080;
			short num3 = num;
			num = (short)205324289;
			if (num != 0)
			{
			}
			num = (short)1515126784;
			if (num != 0)
			{
			}
		}

		// Token: 0x06004168 RID: 16744 RVA: 0x003D32B8 File Offset: 0x003D14B8
		public override void DropReferences()
		{
			short num = (short)1726187342;
			short num2 = num;
			num = (short)1493469006;
			switch (num2 == num)
			{
			}
			num = (short)2051866624;
			short num3 = num;
			num = (short)375062529;
			if (num != 0)
			{
			}
			num = (short)2018902016;
			if (num != 0)
			{
			}
		}

		// Token: 0x06004169 RID: 16745 RVA: 0x003D3360 File Offset: 0x003D1560
		public override void SetConstraints()
		{
			short num = (short)10787084;
			short num2 = num;
			num = (short)1272813836;
			switch (num2 == num)
			{
			}
			num = (short)1205075968;
			short num3 = num;
			num = (short)1731198977;
			if (num != 0)
			{
			}
			num = (short)264372224;
			if (num != 0)
			{
			}
			this.radWideTransmitPowerLevelsTxPowerLevelHighW_A41854.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConTxPowerLevelsByFrequencyRangeNewBand);
			this.radWideTransmitPowerLevelsTxPowerLevelHighW_A41854.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.TxPowerLevelHighNewBandValid);
			this.radWideTransmitPowerLevelsTxPowerLevelHighW_A41854.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConIsNewBandPlanSelNew);
			this.radWideTransmitPowerLevelsTxPowerLevelHighW_A41854.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConTxPowerLevelsByFrequencyRangeNewBandEditable);
			this.radWideTransmitPowerLevelsTxPowerLevelLowW_A41855.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConTxPowerLevelsByFrequencyRangeNewBand);
			this.radWideTransmitPowerLevelsTxPowerLevelLowW_A41855.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.TxPowerLowNewBandVaild);
			this.radWideTransmitPowerLevelsTxPowerLevelLowW_A41855.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConIsNewBandPlanSelNew);
			this.radWideTransmitPowerLevelsTxPowerLevelLowW_A41855.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConTxPowerLevelsByFrequencyRangeNewBandEditable);
			this.radWideTransmitPowerLevelsFrequencyRangeStartMHz_A41856.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConIsNewBandPlanSelNew);
			this.radWideTransmitPowerLevelsFrequencyRangeStartMHz_A41856.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.conReturnTrueIfViewSetToLabtoolOrDepot);
			this.radWideTransmitPowerLevelsFrequencyRangeEndMHz_A41857.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConIsNewBandPlanSelNew);
			this.radWideTransmitPowerLevelsFrequencyRangeEndMHz_A41857.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.conReturnTrueIfViewSetToLabtoolOrDepot);
			this.radWideTransmitPowerLevelsTxPowerLevelMinimumW_A41858.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConIsNewBandPlanSelNew);
			this.radWideTransmitPowerLevelsTxPowerLevelMinimumW_A41858.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.conReturnTrueIfViewSetToLabtoolOrDepot);
			this.radWideTransmitPowerLevelsTxPowerLevelMaximumW_A41859.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConIsNewBandPlanSelNew);
			this.radWideTransmitPowerLevelsTxPowerLevelMaximumW_A41859.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.conReturnTrueIfViewSetToLabtoolOrDepot);
			this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41860.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConTxPowerLevelsByFrequencyRangeNewBand);
			this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41860.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.TrkTxPowerLevelLowNewBandValid);
			this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41860.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConIsNewBandPlanSelNew);
			this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41860.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConTxPowerLevelsByFrequencyRangeNewBandEditable);
			this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41861.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConTxPowerLevelsByFrequencyRangeNewBand);
			this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41861.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.CnvTxPowerLevelLowNewBandValid);
			this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41861.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConIsNewBandPlanSelNew);
			this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41861.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConTxPowerLevelsByFrequencyRangeNewBandEditable);
			this.radWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41862.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConIsNewBandPlanSelNew);
			this.radWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41862.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.conReturnTrueIfViewSetToLabtool);
			this.radWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41863.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConIsNewBandPlanSelNew);
			this.radWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41863.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.conReturnTrueIfViewSetToLabtool);
			this.radWidePowerLevelBandFrequency_A41864.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConIsNewBandPlanSelNew);
			this.radWidePowerLevelBandFrequency_A41864.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
		}

		// Token: 0x0600416A RID: 16746 RVA: 0x003D36BC File Offset: 0x003D18BC
		public override void SetupDependencies()
		{
			short num = (short)1404829697;
			if (num != 0)
			{
			}
			num = (short)1115223016;
			short num2 = num;
			num = (short)1343615976;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1658978304;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1175191552;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide = base.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
			radioWide.TransmitPowerLevels.RadWideTxPowerLevelsNewBandPlan78MHzBandSelection_A41851.AddDependentObject(this.radWideTransmitPowerLevelsTxPowerLevelHighW_A41854);
			this.RefRadioInformation.Labtool.RadInfoLabtoolPrimaryBands_A23987.AddDependentObject(this.radWideTransmitPowerLevelsTxPowerLevelHighW_A41854);
			this.RefRadioInformation.Labtool.RadInfoLabtoolSecondaryBands_A23988.AddDependentObject(this.radWideTransmitPowerLevelsTxPowerLevelHighW_A41854);
			this.RefRadioInformation.Labtool.RadInfoLabtoolDualBandEnable_A23986.AddDependentObject(this.radWideTransmitPowerLevelsTxPowerLevelHighW_A41854);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesAllowInvalidFrequencies_A12493.AddDependentObject(this.radWideTransmitPowerLevelsTxPowerLevelHighW_A41854);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesVHFUsedinCodeplug_A8481.AddDependentObject(this.radWideTransmitPowerLevelsTxPowerLevelHighW_A41854);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRanges7800MHzUsedinCodeplug_A8512.AddDependentObject(this.radWideTransmitPowerLevelsTxPowerLevelHighW_A41854);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesUHF1UsedinCodeplug_A8504.AddDependentObject(this.radWideTransmitPowerLevelsTxPowerLevelHighW_A41854);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesUHF2UsedinCodeplug_A8507.AddDependentObject(this.radWideTransmitPowerLevelsTxPowerLevelHighW_A41854);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRanges900MHzUsedinCodeplug_A8516.AddDependentObject(this.radWideTransmitPowerLevelsTxPowerLevelHighW_A41854);
			this.radWideTransmitPowerLevelsTxPowerLevelMinimumW_A41858.AddDependentObject(this.radWideTransmitPowerLevelsTxPowerLevelHighW_A41854);
			this.radWideTransmitPowerLevelsTxPowerLevelMaximumW_A41859.AddDependentObject(this.radWideTransmitPowerLevelsTxPowerLevelHighW_A41854);
			this.radWideTransmitPowerLevelsTxPowerLevelLowW_A41855.AddDependentObject(this.radWideTransmitPowerLevelsTxPowerLevelHighW_A41854);
			this.radWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41863.AddDependentObject(this.radWideTransmitPowerLevelsTxPowerLevelHighW_A41854);
			this.radWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41862.AddDependentObject(this.radWideTransmitPowerLevelsTxPowerLevelHighW_A41854);
			this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41861.AddDependentObject(this.radWideTransmitPowerLevelsTxPowerLevelHighW_A41854);
			this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41860.AddDependentObject(this.radWideTransmitPowerLevelsTxPowerLevelHighW_A41854);
			radioWide.TransmitPowerLevels.RadWideTxPowerLevelsNewBandPlan78MHzBandSelection_A41851.AddDependentObject(this.radWideTransmitPowerLevelsTxPowerLevelLowW_A41855);
			this.RefRadioInformation.Labtool.RadInfoLabtoolPrimaryBands_A23987.AddDependentObject(this.radWideTransmitPowerLevelsTxPowerLevelLowW_A41855);
			this.RefRadioInformation.Labtool.RadInfoLabtoolSecondaryBands_A23988.AddDependentObject(this.radWideTransmitPowerLevelsTxPowerLevelLowW_A41855);
			this.RefRadioInformation.Labtool.RadInfoLabtoolDualBandEnable_A23986.AddDependentObject(this.radWideTransmitPowerLevelsTxPowerLevelLowW_A41855);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesAllowInvalidFrequencies_A12493.AddDependentObject(this.radWideTransmitPowerLevelsTxPowerLevelLowW_A41855);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesVHFUsedinCodeplug_A8481.AddDependentObject(this.radWideTransmitPowerLevelsTxPowerLevelLowW_A41855);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRanges7800MHzUsedinCodeplug_A8512.AddDependentObject(this.radWideTransmitPowerLevelsTxPowerLevelLowW_A41855);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesUHF1UsedinCodeplug_A8504.AddDependentObject(this.radWideTransmitPowerLevelsTxPowerLevelLowW_A41855);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesUHF2UsedinCodeplug_A8507.AddDependentObject(this.radWideTransmitPowerLevelsTxPowerLevelLowW_A41855);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRanges900MHzUsedinCodeplug_A8516.AddDependentObject(this.radWideTransmitPowerLevelsTxPowerLevelLowW_A41855);
			this.radWideTransmitPowerLevelsTxPowerLevelMinimumW_A41858.AddDependentObject(this.radWideTransmitPowerLevelsTxPowerLevelLowW_A41855);
			this.radWideTransmitPowerLevelsTxPowerLevelMaximumW_A41859.AddDependentObject(this.radWideTransmitPowerLevelsTxPowerLevelLowW_A41855);
			this.radWideTransmitPowerLevelsTxPowerLevelHighW_A41854.AddDependentObject(this.radWideTransmitPowerLevelsTxPowerLevelLowW_A41855);
			radioWide.TransmitPowerLevels.RadWideTxPowerLevelsNewBandPlan78MHzBandSelection_A41851.AddDependentObject(this.radWideTransmitPowerLevelsFrequencyRangeStartMHz_A41856);
			radioWide.TransmitPowerLevels.RadWideTxPowerLevelsNewBandPlan78MHzBandSelection_A41851.AddDependentObject(this.radWideTransmitPowerLevelsFrequencyRangeEndMHz_A41857);
			radioWide.TransmitPowerLevels.RadWideTxPowerLevelsNewBandPlan78MHzBandSelection_A41851.AddDependentObject(this.radWideTransmitPowerLevelsTxPowerLevelMinimumW_A41858);
			radioWide.TransmitPowerLevels.RadWideTxPowerLevelsNewBandPlan78MHzBandSelection_A41851.AddDependentObject(this.radWideTransmitPowerLevelsTxPowerLevelMaximumW_A41859);
			radioWide.TransmitPowerLevels.RadWideTxPowerLevelsNewBandPlan78MHzBandSelection_A41851.AddDependentObject(this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41860);
			this.RefRadioInformation.Labtool.RadInfoLabtoolPrimaryBands_A23987.AddDependentObject(this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41860);
			this.RefRadioInformation.Labtool.RadInfoLabtoolSecondaryBands_A23988.AddDependentObject(this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41860);
			this.RefRadioInformation.Labtool.RadInfoLabtoolDualBandEnable_A23986.AddDependentObject(this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41860);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesAllowInvalidFrequencies_A12493.AddDependentObject(this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41860);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesVHFUsedinCodeplug_A8481.AddDependentObject(this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41860);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRanges7800MHzUsedinCodeplug_A8512.AddDependentObject(this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41860);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesUHF1UsedinCodeplug_A8504.AddDependentObject(this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41860);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesUHF2UsedinCodeplug_A8507.AddDependentObject(this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41860);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRanges900MHzUsedinCodeplug_A8516.AddDependentObject(this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41860);
			this.radWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41862.AddDependentObject(this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41860);
			this.radWideTransmitPowerLevelsTxPowerLevelMaximumW_A41859.AddDependentObject(this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41860);
			this.radWideTransmitPowerLevelsTxPowerLevelHighW_A41854.AddDependentObject(this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41860);
			radioWide.TransmitPowerLevels.RadWideTxPowerLevelsNewBandPlan78MHzBandSelection_A41851.AddDependentObject(this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41861);
			this.RefRadioInformation.Labtool.RadInfoLabtoolPrimaryBands_A23987.AddDependentObject(this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41861);
			this.RefRadioInformation.Labtool.RadInfoLabtoolSecondaryBands_A23988.AddDependentObject(this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41861);
			this.RefRadioInformation.Labtool.RadInfoLabtoolDualBandEnable_A23986.AddDependentObject(this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41861);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesAllowInvalidFrequencies_A12493.AddDependentObject(this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41861);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesVHFUsedinCodeplug_A8481.AddDependentObject(this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41861);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRanges7800MHzUsedinCodeplug_A8512.AddDependentObject(this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41861);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesUHF1UsedinCodeplug_A8504.AddDependentObject(this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41861);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesUHF2UsedinCodeplug_A8507.AddDependentObject(this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41861);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRanges900MHzUsedinCodeplug_A8516.AddDependentObject(this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41861);
			this.radWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41863.AddDependentObject(this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41861);
			this.radWideTransmitPowerLevelsTxPowerLevelMaximumW_A41859.AddDependentObject(this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41861);
			this.radWideTransmitPowerLevelsTxPowerLevelHighW_A41854.AddDependentObject(this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41861);
			radioWide.TransmitPowerLevels.RadWideTxPowerLevelsNewBandPlan78MHzBandSelection_A41851.AddDependentObject(this.radWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41862);
			radioWide.TransmitPowerLevels.RadWideTxPowerLevelsNewBandPlan78MHzBandSelection_A41851.AddDependentObject(this.radWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41863);
			radioWide.TransmitPowerLevels.RadWideTxPowerLevelsNewBandPlan78MHzBandSelection_A41851.AddDependentObject(this.radWidePowerLevelBandFrequency_A41864);
		}

		// Token: 0x1700217E RID: 8574
		// (get) Token: 0x0600416B RID: 16747 RVA: 0x003D3D84 File Offset: 0x003D1F84
		public bool HasDiffs
		{
			get
			{
				short num = (short)754689046;
				short num2 = num;
				num = (short)50635798;
				switch (num2 == num)
				{
				}
				num = (short)1354366976;
				short num3 = num;
				num = (short)2123366400;
				if (num != 0)
				{
				}
				num = (short)1355808769;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x1700217F RID: 8575
		// (get) Token: 0x0600416C RID: 16748 RVA: 0x003D3E34 File Offset: 0x003D2034
		// (set) Token: 0x0600416D RID: 16749 RVA: 0x003D3EE8 File Offset: 0x003D20E8
		public int RadWideTransmitPowerLevelsTxPowerLevelHighW_A41854Value
		{
			get
			{
				short num = (short)1016494847;
				short num2 = num;
				num = (short)96566015;
				switch (num2 == num)
				{
				}
				num = (short)1476984832;
				short num3 = num;
				num = (short)331874304;
				if (num != 0)
				{
				}
				num = (short)1996357633;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelHighW_A41854.Value;
			}
			set
			{
				short num = (short)48037889;
				if (num != 0)
				{
				}
				num = (short)623733861;
				short num2 = num;
				num = (short)2111007845;
				switch (num2 == num)
				{
				default:
				{
					num = (short)325451776;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)583532544;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTxPowerLevelHighW_A41854.Value = value;
			}
		}

		// Token: 0x17002180 RID: 8576
		// (get) Token: 0x0600416E RID: 16750 RVA: 0x003D3F9C File Offset: 0x003D219C
		public global::AcpBusinessLayer.AcpRangeField<int, string> RadWideTransmitPowerLevelsTxPowerLevelHighW_A41854
		{
			get
			{
				short num = (short)652476532;
				short num2 = num;
				num = (short)909049972;
				switch (num2 == num)
				{
				}
				num = (short)1163722752;
				short num3 = num;
				num = (short)1975582721;
				if (num != 0)
				{
				}
				num = (short)934084608;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelHighW_A41854;
			}
		}

		// Token: 0x17002181 RID: 8577
		// (get) Token: 0x0600416F RID: 16751 RVA: 0x003D404C File Offset: 0x003D224C
		// (set) Token: 0x06004170 RID: 16752 RVA: 0x003D40FC File Offset: 0x003D22FC
		public string RadWideTransmitPowerLevelsTxPowerLevelHighW_A41854_UIValue
		{
			get
			{
				short num = (short)979008869;
				short num2 = num;
				num = (short)1058176357;
				switch (num2 == num)
				{
				}
				num = (short)73728000;
				short num3 = num;
				num = (short)744030209;
				if (num != 0)
				{
				}
				num = (short)674955264;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelHighW_A41854.UIValue;
			}
			set
			{
				short num = (short)1662516383;
				short num2 = num;
				num = (short)76020895;
				switch (num2 == num)
				{
				}
				num = (short)1987772416;
				short num3 = num;
				num = (short)858718209;
				if (num != 0)
				{
				}
				num = (short)1614938112;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTxPowerLevelHighW_A41854.UIValue = value;
			}
		}

		// Token: 0x17002182 RID: 8578
		// (get) Token: 0x06004171 RID: 16753 RVA: 0x003D41B0 File Offset: 0x003D23B0
		// (set) Token: 0x06004172 RID: 16754 RVA: 0x003D4264 File Offset: 0x003D2464
		internal int RadWideTransmitPowerLevelsTxPowerLevelHighW_A41854Min
		{
			get
			{
				short num = (short)1375439442;
				short num2 = num;
				num = (short)1733134930;
				switch (num2 == num)
				{
				}
				num = (short)210763776;
				short num3 = num;
				num = (short)1676083200;
				if (num != 0)
				{
				}
				num = (short)1228931073;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelHighW_A41854.Min;
			}
			set
			{
				short num = (short)641204225;
				if (num != 0)
				{
				}
				num = (short)1937347816;
				short num2 = num;
				num = (short)1733203176;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1862729728;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1649868800;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTxPowerLevelHighW_A41854.Min = value;
			}
		}

		// Token: 0x17002183 RID: 8579
		// (get) Token: 0x06004173 RID: 16755 RVA: 0x003D4318 File Offset: 0x003D2518
		// (set) Token: 0x06004174 RID: 16756 RVA: 0x003D43CC File Offset: 0x003D25CC
		internal int RadWideTransmitPowerLevelsTxPowerLevelHighW_A41854Max
		{
			get
			{
				short num = (short)1820880037;
				short num2 = num;
				num = (short)1799253157;
				switch (num2 == num)
				{
				}
				num = (short)1499332608;
				short num3 = num;
				num = (short)202833921;
				if (num != 0)
				{
				}
				num = (short)1866858496;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelHighW_A41854.Max;
			}
			set
			{
				short num = (short)961801984;
				short num2 = num;
				num = (short)1898442496;
				switch (num2 == num)
				{
				}
				num = (short)1560215552;
				short num3 = num;
				num = (short)1735983104;
				if (num != 0)
				{
				}
				num = (short)2005204993;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTxPowerLevelHighW_A41854.Max = value;
			}
		}

		// Token: 0x17002184 RID: 8580
		// (get) Token: 0x06004175 RID: 16757 RVA: 0x003D4480 File Offset: 0x003D2680
		// (set) Token: 0x06004176 RID: 16758 RVA: 0x003D4538 File Offset: 0x003D2738
		internal int RadWideTransmitPowerLevelsTxPowerLevelHighW_A41854Step
		{
			get
			{
				short num = (short)30454469;
				short num2 = num;
				num = (short)1938797253;
				switch (num2 == num)
				{
				}
				num = (short)1832386560;
				short num3 = num;
				num = (short)1840250881;
				if (num != 0)
				{
				}
				num = (short)463208448;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelHighW_A41854.StepSize;
			}
			set
			{
				short num = (short)1180565505;
				if (num != 0)
				{
				}
				num = (short)586490561;
				short num2 = num;
				num = (short)1996169921;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1473773568;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1107427328;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTxPowerLevelHighW_A41854.StepSize = value;
			}
		}

		// Token: 0x17002185 RID: 8581
		// (get) Token: 0x06004177 RID: 16759 RVA: 0x003D45EC File Offset: 0x003D27EC
		// (set) Token: 0x06004178 RID: 16760 RVA: 0x003D46A0 File Offset: 0x003D28A0
		public bool RadWideTransmitPowerLevelsTxPowerLevelHighW_A41854_Applicable
		{
			get
			{
				short num = (short)1005166914;
				short num2 = num;
				num = (short)588161346;
				switch (num2 == num)
				{
				}
				num = (short)1460666368;
				short num3 = num;
				num = (short)770113537;
				if (num != 0)
				{
				}
				num = (short)584974336;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelHighW_A41854.Applicable;
			}
			set
			{
				short num = (short)1869484269;
				short num2 = num;
				num = (short)8851693;
				switch (num2 == num)
				{
				}
				num = (short)1326448640;
				short num3 = num;
				num = (short)1752236033;
				if (num != 0)
				{
				}
				num = (short)1418526720;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTxPowerLevelHighW_A41854.Applicable = value;
			}
		}

		// Token: 0x17002186 RID: 8582
		// (get) Token: 0x06004179 RID: 16761 RVA: 0x003D4754 File Offset: 0x003D2954
		// (set) Token: 0x0600417A RID: 16762 RVA: 0x003D4808 File Offset: 0x003D2A08
		public bool RadWideTransmitPowerLevelsTxPowerLevelHighW_A41854_Valid
		{
			get
			{
				short num = (short)2045326088;
				short num2 = num;
				num = (short)102839048;
				switch (num2 == num)
				{
				}
				num = (short)2000814080;
				short num3 = num;
				num = (short)1019674624;
				if (num != 0)
				{
				}
				num = (short)314966017;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelHighW_A41854.Valid;
			}
			set
			{
				short num = (short)932144548;
				short num2 = num;
				num = (short)1882547620;
				switch (num2 == num)
				{
				}
				num = (short)387121152;
				short num3 = num;
				num = (short)1951727617;
				if (num != 0)
				{
				}
				num = (short)409075712;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTxPowerLevelHighW_A41854.Valid = value;
			}
		}

		// Token: 0x17002187 RID: 8583
		// (get) Token: 0x0600417B RID: 16763 RVA: 0x003D48BC File Offset: 0x003D2ABC
		// (set) Token: 0x0600417C RID: 16764 RVA: 0x003D4970 File Offset: 0x003D2B70
		public bool RadWideTransmitPowerLevelsTxPowerLevelHighW_A41854_Visible
		{
			get
			{
				short num = (short)257110823;
				short num2 = num;
				num = (short)731984679;
				switch (num2 == num)
				{
				}
				num = (short)1155792896;
				short num3 = num;
				num = (short)237436929;
				if (num != 0)
				{
				}
				num = (short)132644864;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelHighW_A41854.Visible;
			}
			set
			{
				short num = (short)317784065;
				if (num != 0)
				{
				}
				num = (short)45141708;
				short num2 = num;
				num = (short)1709625036;
				switch (num2 == num)
				{
				default:
				{
					num = (short)428539904;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)736493568;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTxPowerLevelHighW_A41854.Visible = value;
			}
		}

		// Token: 0x17002188 RID: 8584
		// (get) Token: 0x0600417D RID: 16765 RVA: 0x003D4A28 File Offset: 0x003D2C28
		// (set) Token: 0x0600417E RID: 16766 RVA: 0x003D4AE0 File Offset: 0x003D2CE0
		public bool RadWideTransmitPowerLevelsTxPowerLevelHighW_A41854_Editable
		{
			get
			{
				short num = (short)655928300;
				short num2 = num;
				num = (short)369404908;
				switch (num2 == num)
				{
				}
				num = (short)821297152;
				short num3 = num;
				num = (short)1838481409;
				if (num != 0)
				{
				}
				num = (short)826736640;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelHighW_A41854.Editable;
			}
			set
			{
				short num = (short)2095316993;
				if (num != 0)
				{
				}
				num = (short)373699843;
				short num2 = num;
				num = (short)1857303811;
				switch (num2 == num)
				{
				default:
				{
					num = (short)139395072;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)618332160;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTxPowerLevelHighW_A41854.Editable = value;
			}
		}

		// Token: 0x17002189 RID: 8585
		// (get) Token: 0x0600417F RID: 16767 RVA: 0x003D4B98 File Offset: 0x003D2D98
		internal string RadWideTransmitPowerLevelsTxPowerLevelHighW_A41854_UILabel
		{
			get
			{
				short num = (short)566009718;
				short num2 = num;
				num = (short)979148662;
				switch (num2 == num)
				{
				}
				num = (short)568131584;
				short num3 = num;
				num = (short)735051776;
				if (num != 0)
				{
				}
				num = (short)6684673;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelHighW_A41854.UIName;
			}
		}

		// Token: 0x1700218A RID: 8586
		// (get) Token: 0x06004180 RID: 16768 RVA: 0x003D4C4C File Offset: 0x003D2E4C
		// (set) Token: 0x06004181 RID: 16769 RVA: 0x003D4D00 File Offset: 0x003D2F00
		internal bool RadWideTransmitPowerLevelsTxPowerLevelHighW_A41854_HiddenStatic
		{
			get
			{
				short num = (short)453453824;
				short num2 = num;
				num = (short)728377344;
				switch (num2 == num)
				{
				}
				num = (short)1321205760;
				short num3 = num;
				num = (short)229441536;
				if (num != 0)
				{
				}
				num = (short)1141702657;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelHighW_A41854.HiddenStatic;
			}
			set
			{
				short num = (short)1814426506;
				short num2 = num;
				num = (short)653259658;
				switch (num2 == num)
				{
				}
				num = (short)1962737664;
				short num3 = num;
				num = (short)2026962944;
				if (num != 0)
				{
				}
				num = (short)937754625;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTxPowerLevelHighW_A41854.HiddenStatic = value;
			}
		}

		// Token: 0x1700218B RID: 8587
		// (get) Token: 0x06004182 RID: 16770 RVA: 0x003D4DB8 File Offset: 0x003D2FB8
		// (set) Token: 0x06004183 RID: 16771 RVA: 0x003D4E6C File Offset: 0x003D306C
		internal bool RadWideTransmitPowerLevelsTxPowerLevelHighW_A41854_HiddenDynamic
		{
			get
			{
				short num = (short)1299410630;
				short num2 = num;
				num = (short)1316777670;
				switch (num2 == num)
				{
				}
				num = (short)1224802304;
				short num3 = num;
				num = (short)1919090688;
				if (num != 0)
				{
				}
				num = (short)1742667777;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelHighW_A41854.HiddenDynamic;
			}
			set
			{
				short num = (short)2076267730;
				short num2 = num;
				num = (short)720917714;
				switch (num2 == num)
				{
				}
				num = (short)253165568;
				short num3 = num;
				num = (short)1173749761;
				if (num != 0)
				{
				}
				num = (short)1944977408;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTxPowerLevelHighW_A41854.HiddenDynamic = value;
			}
		}

		// Token: 0x1700218C RID: 8588
		// (get) Token: 0x06004184 RID: 16772 RVA: 0x003D4F24 File Offset: 0x003D3124
		public bool RadWideTransmitPowerLevelsTxPowerLevelHighW_A41854_HasDiffs
		{
			get
			{
				short num = (short)618921985;
				if (num != 0)
				{
				}
				num = (short)1594867325;
				short num2 = num;
				num = (short)872529533;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1413414912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)319619072;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelHighW_A41854._HasDiffs;
			}
		}

		// Token: 0x1700218D RID: 8589
		// (get) Token: 0x06004185 RID: 16773 RVA: 0x003D4FDC File Offset: 0x003D31DC
		// (set) Token: 0x06004186 RID: 16774 RVA: 0x003D5090 File Offset: 0x003D3290
		public int RadWideTransmitPowerLevelsTxPowerLevelLowW_A41855Value
		{
			get
			{
				short num = (short)348117020;
				short num2 = num;
				num = (short)816175132;
				switch (num2 == num)
				{
				}
				num = (short)1946222592;
				short num3 = num;
				num = (short)280166401;
				if (num != 0)
				{
				}
				num = (short)232652800;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelLowW_A41855.Value;
			}
			set
			{
				short num = (short)1906264486;
				short num2 = num;
				num = (short)1507805606;
				switch (num2 == num)
				{
				}
				num = (short)675807232;
				short num3 = num;
				num = (short)1198325760;
				if (num != 0)
				{
				}
				num = (short)1614020609;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTxPowerLevelLowW_A41855.Value = value;
			}
		}

		// Token: 0x1700218E RID: 8590
		// (get) Token: 0x06004187 RID: 16775 RVA: 0x003D5144 File Offset: 0x003D3344
		public global::AcpBusinessLayer.AcpRangeField<int, string> RadWideTransmitPowerLevelsTxPowerLevelLowW_A41855
		{
			get
			{
				short num = (short)1493126183;
				short num2 = num;
				num = (short)1455442983;
				switch (num2 == num)
				{
				}
				num = (short)1314193408;
				short num3 = num;
				num = (short)869924865;
				if (num != 0)
				{
				}
				num = (short)118489088;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelLowW_A41855;
			}
		}

		// Token: 0x1700218F RID: 8591
		// (get) Token: 0x06004188 RID: 16776 RVA: 0x003D51F4 File Offset: 0x003D33F4
		// (set) Token: 0x06004189 RID: 16777 RVA: 0x003D52A8 File Offset: 0x003D34A8
		public string RadWideTransmitPowerLevelsTxPowerLevelLowW_A41855_UIValue
		{
			get
			{
				short num = (short)1650851841;
				if (num != 0)
				{
				}
				num = (short)1659362872;
				short num2 = num;
				num = (short)875879992;
				switch (num2 == num)
				{
				default:
				{
					num = (short)278462464;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)976879616;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelLowW_A41855.UIValue;
			}
			set
			{
				short num = (short)760698797;
				short num2 = num;
				num = (short)155998125;
				switch (num2 == num)
				{
				}
				num = (short)2048983040;
				short num3 = num;
				num = (short)798818305;
				if (num != 0)
				{
				}
				num = (short)327614464;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTxPowerLevelLowW_A41855.UIValue = value;
			}
		}

		// Token: 0x17002190 RID: 8592
		// (get) Token: 0x0600418A RID: 16778 RVA: 0x003D535C File Offset: 0x003D355C
		// (set) Token: 0x0600418B RID: 16779 RVA: 0x003D5414 File Offset: 0x003D3614
		internal int RadWideTransmitPowerLevelsTxPowerLevelLowW_A41855Min
		{
			get
			{
				short num = (short)1527539229;
				short num2 = num;
				num = (short)876832285;
				switch (num2 == num)
				{
				}
				num = (short)1005387776;
				short num3 = num;
				num = (short)1676017665;
				if (num != 0)
				{
				}
				num = (short)826015744;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelLowW_A41855.Min;
			}
			set
			{
				short num = (short)632815616;
				short num2 = num;
				num = (short)2070365329;
				short num3 = num;
				num = (short)1871332497;
				switch (num3 == num)
				{
				}
				num = (short)527630336;
				if (num != 0)
				{
				}
				num = (short)872480769;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTxPowerLevelLowW_A41855.Min = value;
			}
		}

		// Token: 0x17002191 RID: 8593
		// (get) Token: 0x0600418C RID: 16780 RVA: 0x003D54CC File Offset: 0x003D36CC
		// (set) Token: 0x0600418D RID: 16781 RVA: 0x003D5580 File Offset: 0x003D3780
		internal int RadWideTransmitPowerLevelsTxPowerLevelLowW_A41855Max
		{
			get
			{
				short num = (short)874774528;
				short num2 = num;
				num = (short)1934229505;
				if (num != 0)
				{
				}
				num = (short)1471913421;
				short num3 = num;
				num = (short)22584781;
				switch (num3 == num)
				{
				}
				num = (short)172687360;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelLowW_A41855.Max;
			}
			set
			{
				short num = (short)422838272;
				short num2 = num;
				num = (short)334888961;
				if (num != 0)
				{
				}
				num = (short)2113604065;
				short num3 = num;
				num = (short)1089407457;
				switch (num3 == num)
				{
				}
				num = (short)1431306240;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTxPowerLevelLowW_A41855.Max = value;
			}
		}

		// Token: 0x17002192 RID: 8594
		// (get) Token: 0x0600418E RID: 16782 RVA: 0x003D5634 File Offset: 0x003D3834
		// (set) Token: 0x0600418F RID: 16783 RVA: 0x003D56E8 File Offset: 0x003D38E8
		internal int RadWideTransmitPowerLevelsTxPowerLevelLowW_A41855Step
		{
			get
			{
				short num = (short)835846144;
				short num2 = num;
				num = (short)1885359374;
				short num3 = num;
				num = (short)1059081486;
				switch (num3 == num)
				{
				}
				num = (short)1324285953;
				if (num != 0)
				{
				}
				num = (short)1456799744;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelLowW_A41855.StepSize;
			}
			set
			{
				short num = (short)495583232;
				short num2 = num;
				num = (short)479002561;
				short num3 = num;
				num = (short)26083265;
				switch (num3 == num)
				{
				}
				num = (short)548274177;
				if (num != 0)
				{
				}
				num = (short)1730871296;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTxPowerLevelLowW_A41855.StepSize = value;
			}
		}

		// Token: 0x17002193 RID: 8595
		// (get) Token: 0x06004190 RID: 16784 RVA: 0x003D579C File Offset: 0x003D399C
		// (set) Token: 0x06004191 RID: 16785 RVA: 0x003D5854 File Offset: 0x003D3A54
		public bool RadWideTransmitPowerLevelsTxPowerLevelLowW_A41855_Applicable
		{
			get
			{
				short num = (short)1917386752;
				short num2 = num;
				num = (short)2145302337;
				short num3 = num;
				num = (short)140162881;
				switch (num3 == num)
				{
				}
				num = (short)580911104;
				if (num != 0)
				{
				}
				num = (short)789053441;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelLowW_A41855.Applicable;
			}
			set
			{
				short num = (short)1854734336;
				short num2 = num;
				num = (short)1072893381;
				short num3 = num;
				num = (short)1095437765;
				switch (num3 == num)
				{
				}
				num = (short)1819148289;
				if (num != 0)
				{
				}
				num = (short)445775872;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTxPowerLevelLowW_A41855.Applicable = value;
			}
		}

		// Token: 0x17002194 RID: 8596
		// (get) Token: 0x06004192 RID: 16786 RVA: 0x003D590C File Offset: 0x003D3B0C
		// (set) Token: 0x06004193 RID: 16787 RVA: 0x003D59C0 File Offset: 0x003D3BC0
		public bool RadWideTransmitPowerLevelsTxPowerLevelLowW_A41855_Valid
		{
			get
			{
				short num = (short)850264064;
				short num2 = num;
				num = (short)823442105;
				short num3 = num;
				num = (short)1921170105;
				switch (num3 == num)
				{
				}
				num = (short)846725121;
				if (num != 0)
				{
				}
				num = (short)121962496;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelLowW_A41855.Valid;
			}
			set
			{
				short num = (short)1711669248;
				short num2 = num;
				num = (short)1895712110;
				short num3 = num;
				num = (short)795362670;
				switch (num3 == num)
				{
				}
				num = (short)1848901633;
				if (num != 0)
				{
				}
				num = (short)1294073856;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTxPowerLevelLowW_A41855.Valid = value;
			}
		}

		// Token: 0x17002195 RID: 8597
		// (get) Token: 0x06004194 RID: 16788 RVA: 0x003D5A78 File Offset: 0x003D3C78
		// (set) Token: 0x06004195 RID: 16789 RVA: 0x003D5B2C File Offset: 0x003D3D2C
		public bool RadWideTransmitPowerLevelsTxPowerLevelLowW_A41855_Visible
		{
			get
			{
				short num = (short)1173880832;
				short num2 = num;
				num = (short)1707576469;
				short num3 = num;
				num = (short)1327926421;
				switch (num3 == num)
				{
				}
				num = (short)798949377;
				if (num != 0)
				{
				}
				num = (short)696057856;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelLowW_A41855.Visible;
			}
			set
			{
				short num = (short)1010040832;
				short num2 = num;
				num = (short)1514012673;
				if (num != 0)
				{
				}
				num = (short)1641759712;
				short num3 = num;
				num = (short)1466647520;
				switch (num3 == num)
				{
				}
				num = (short)685506560;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTxPowerLevelLowW_A41855.Visible = value;
			}
		}

		// Token: 0x17002196 RID: 8598
		// (get) Token: 0x06004196 RID: 16790 RVA: 0x003D5BE0 File Offset: 0x003D3DE0
		// (set) Token: 0x06004197 RID: 16791 RVA: 0x003D5C94 File Offset: 0x003D3E94
		public bool RadWideTransmitPowerLevelsTxPowerLevelLowW_A41855_Editable
		{
			get
			{
				short num = (short)238419968;
				short num2 = num;
				num = (short)1810610558;
				short num3 = num;
				num = (short)1392556414;
				switch (num3 == num)
				{
				}
				num = (short)694222848;
				if (num != 0)
				{
				}
				num = (short)1913913345;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelLowW_A41855.Editable;
			}
			set
			{
				short num = (short)2061434880;
				short num2 = num;
				num = (short)584055136;
				short num3 = num;
				num = (short)746912096;
				switch (num3 == num)
				{
				}
				num = (short)504496129;
				if (num != 0)
				{
				}
				num = (short)806813696;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTxPowerLevelLowW_A41855.Editable = value;
			}
		}

		// Token: 0x17002197 RID: 8599
		// (get) Token: 0x06004198 RID: 16792 RVA: 0x003D5D4C File Offset: 0x003D3F4C
		internal string RadWideTransmitPowerLevelsTxPowerLevelLowW_A41855_UILabel
		{
			get
			{
				short num = (short)289144832;
				short num2 = num;
				num = (short)108110326;
				short num3 = num;
				num = (short)2117771766;
				switch (num3 == num)
				{
				}
				num = (short)1516306433;
				if (num != 0)
				{
				}
				num = (short)2073755648;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelLowW_A41855.UIName;
			}
		}

		// Token: 0x17002198 RID: 8600
		// (get) Token: 0x06004199 RID: 16793 RVA: 0x003D5E00 File Offset: 0x003D4000
		// (set) Token: 0x0600419A RID: 16794 RVA: 0x003D5EB8 File Offset: 0x003D40B8
		internal bool RadWideTransmitPowerLevelsTxPowerLevelLowW_A41855_HiddenStatic
		{
			get
			{
				short num = (short)1768620032;
				short num2 = num;
				num = (short)737197443;
				short num3 = num;
				num = (short)1364049283;
				switch (num3 == num)
				{
				}
				num = (short)1330380801;
				if (num != 0)
				{
				}
				num = (short)479789056;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelLowW_A41855.HiddenStatic;
			}
			set
			{
				short num = (short)1616445440;
				short num2 = num;
				num = (short)929476602;
				short num3 = num;
				num = (short)1381085178;
				switch (num3 == num)
				{
				}
				num = (short)1024262145;
				if (num != 0)
				{
				}
				num = (short)1883832320;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTxPowerLevelLowW_A41855.HiddenStatic = value;
			}
		}

		// Token: 0x17002199 RID: 8601
		// (get) Token: 0x0600419B RID: 16795 RVA: 0x003D5F6C File Offset: 0x003D416C
		// (set) Token: 0x0600419C RID: 16796 RVA: 0x003D6020 File Offset: 0x003D4220
		internal bool RadWideTransmitPowerLevelsTxPowerLevelLowW_A41855_HiddenDynamic
		{
			get
			{
				short num = (short)1926365184;
				short num2 = num;
				num = (short)1471483896;
				short num3 = num;
				num = (short)1427443704;
				switch (num3 == num)
				{
				}
				num = (short)1694892033;
				if (num != 0)
				{
				}
				num = (short)1385103360;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelLowW_A41855.HiddenDynamic;
			}
			set
			{
				short num = (short)1590165504;
				short num2 = num;
				num = (short)740802987;
				short num3 = num;
				num = (short)1203225003;
				switch (num3 == num)
				{
				}
				num = (short)2069037057;
				if (num != 0)
				{
				}
				num = (short)843972608;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTxPowerLevelLowW_A41855.HiddenDynamic = value;
			}
		}

		// Token: 0x1700219A RID: 8602
		// (get) Token: 0x0600419D RID: 16797 RVA: 0x003D60D4 File Offset: 0x003D42D4
		public bool RadWideTransmitPowerLevelsTxPowerLevelLowW_A41855_HasDiffs
		{
			get
			{
				short num = (short)1207369728;
				short num2 = num;
				num = (short)1277468300;
				short num3 = num;
				num = (short)233807500;
				switch (num3 == num)
				{
				}
				num = (short)117702657;
				if (num != 0)
				{
				}
				num = (short)1201537024;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelLowW_A41855._HasDiffs;
			}
		}

		// Token: 0x1700219B RID: 8603
		// (get) Token: 0x0600419E RID: 16798 RVA: 0x003D6188 File Offset: 0x003D4388
		// (set) Token: 0x0600419F RID: 16799 RVA: 0x003D623C File Offset: 0x003D443C
		public int RadWideTransmitPowerLevelsFrequencyRangeStartMHz_A41856Value
		{
			get
			{
				short num = (short)786890752;
				short num2 = num;
				num = (short)766377985;
				if (num != 0)
				{
				}
				num = (short)276810976;
				short num3 = num;
				num = (short)928763104;
				switch (num3 == num)
				{
				}
				num = (short)1127219200;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsFrequencyRangeStartMHz_A41856.Value;
			}
			set
			{
				short num = (short)1204748288;
				short num2 = num;
				num = (short)584375138;
				short num3 = num;
				num = (short)1756748642;
				switch (num3 == num)
				{
				}
				num = (short)1107165185;
				if (num != 0)
				{
				}
				num = (short)1430847488;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsFrequencyRangeStartMHz_A41856.Value = value;
			}
		}

		// Token: 0x1700219C RID: 8604
		// (get) Token: 0x060041A0 RID: 16800 RVA: 0x003D62F0 File Offset: 0x003D44F0
		// (set) Token: 0x060041A1 RID: 16801 RVA: 0x003D63A4 File Offset: 0x003D45A4
		public string RadWideTransmitPowerLevelsFrequencyRangeStartMHz_A41856_UIValue
		{
			get
			{
				short num = (short)644808704;
				short num2 = num;
				num = (short)884433929;
				short num3 = num;
				num = (short)970220553;
				switch (num3 == num)
				{
				}
				num = (short)1659895809;
				if (num != 0)
				{
				}
				num = (short)821231616;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsFrequencyRangeStartMHz_A41856.UIValue;
			}
			set
			{
				short num = (short)1646985216;
				short num2 = num;
				num = (short)9327730;
				short num3 = num;
				num = (short)1123243122;
				switch (num3 == num)
				{
				}
				num = (short)645136385;
				if (num != 0)
				{
				}
				num = (short)316866560;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsFrequencyRangeStartMHz_A41856.UIValue = value;
			}
		}

		// Token: 0x1700219D RID: 8605
		// (get) Token: 0x060041A2 RID: 16802 RVA: 0x003D6458 File Offset: 0x003D4658
		public global::AcpBusinessLayer.AcpFrequencyField RadWideTransmitPowerLevelsFrequencyRangeStartMHz_A41856
		{
			get
			{
				short num = (short)768868352;
				short num2 = num;
				num = (short)426998806;
				short num3 = num;
				num = (short)1370913814;
				switch (num3 == num)
				{
				}
				num = (short)233242624;
				if (num != 0)
				{
				}
				num = (short)867303425;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsFrequencyRangeStartMHz_A41856;
			}
		}

		// Token: 0x1700219E RID: 8606
		// (get) Token: 0x060041A3 RID: 16803 RVA: 0x003D6508 File Offset: 0x003D4708
		// (set) Token: 0x060041A4 RID: 16804 RVA: 0x003D65BC File Offset: 0x003D47BC
		internal int RadWideTransmitPowerLevelsFrequencyRangeStartMHz_A41856Min
		{
			get
			{
				short num = (short)1134624768;
				short num2 = num;
				num = (short)968853364;
				short num3 = num;
				num = (short)1206945652;
				switch (num3 == num)
				{
				}
				num = (short)2098528257;
				if (num != 0)
				{
				}
				num = (short)650248192;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsFrequencyRangeStartMHz_A41856.Min;
			}
			set
			{
				short num = (short)1267335168;
				short num2 = num;
				num = (short)1825308673;
				if (num != 0)
				{
				}
				num = (short)1051262366;
				short num3 = num;
				num = (short)46464414;
				switch (num3 == num)
				{
				}
				num = (short)1523449856;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsFrequencyRangeStartMHz_A41856.Min = value;
			}
		}

		// Token: 0x1700219F RID: 8607
		// (get) Token: 0x060041A5 RID: 16805 RVA: 0x003D6670 File Offset: 0x003D4870
		// (set) Token: 0x060041A6 RID: 16806 RVA: 0x003D6724 File Offset: 0x003D4924
		internal int RadWideTransmitPowerLevelsFrequencyRangeStartMHz_A41856Max
		{
			get
			{
				short num = (short)351600640;
				short num2 = num;
				num = (short)1860610977;
				short num3 = num;
				num = (short)74754977;
				switch (num3 == num)
				{
				}
				num = (short)409337856;
				if (num != 0)
				{
				}
				num = (short)406519809;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsFrequencyRangeStartMHz_A41856.Max;
			}
			set
			{
				short num = (short)13434880;
				short num2 = num;
				num = (short)1242480360;
				short num3 = num;
				num = (short)2019409640;
				switch (num3 == num)
				{
				}
				num = (short)1162084353;
				if (num != 0)
				{
				}
				num = (short)45023232;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsFrequencyRangeStartMHz_A41856.Max = value;
			}
		}

		// Token: 0x170021A0 RID: 8608
		// (get) Token: 0x060041A7 RID: 16807 RVA: 0x003D67DC File Offset: 0x003D49DC
		// (set) Token: 0x060041A8 RID: 16808 RVA: 0x003D6890 File Offset: 0x003D4A90
		internal int RadWideTransmitPowerLevelsFrequencyRangeStartMHz_A41856Step
		{
			get
			{
				short num = (short)706215936;
				short num2 = num;
				num = (short)1914053763;
				short num3 = num;
				num = (short)105456771;
				switch (num3 == num)
				{
				}
				num = (short)1900478465;
				if (num != 0)
				{
				}
				num = (short)1585643520;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsFrequencyRangeStartMHz_A41856.StepSize;
			}
			set
			{
				short num = (short)936706048;
				short num2 = num;
				num = (short)937246892;
				short num3 = num;
				num = (short)296239276;
				switch (num3 == num)
				{
				}
				num = (short)1878851584;
				if (num != 0)
				{
				}
				num = (short)525729793;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsFrequencyRangeStartMHz_A41856.StepSize = value;
			}
		}

		// Token: 0x170021A1 RID: 8609
		// (get) Token: 0x060041A9 RID: 16809 RVA: 0x003D6948 File Offset: 0x003D4B48
		// (set) Token: 0x060041AA RID: 16810 RVA: 0x003D69FC File Offset: 0x003D4BFC
		public bool RadWideTransmitPowerLevelsFrequencyRangeStartMHz_A41856_Applicable
		{
			get
			{
				short num = (short)1135738880;
				short num2 = num;
				num = (short)1632323776;
				short num3 = num;
				num = (short)1426081984;
				switch (num3 == num)
				{
				}
				num = (short)347209729;
				if (num != 0)
				{
				}
				num = (short)808189952;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsFrequencyRangeStartMHz_A41856.Applicable;
			}
			set
			{
				short num = (short)1365704704;
				short num2 = num;
				num = (short)743280236;
				short num3 = num;
				num = (short)1732415084;
				switch (num3 == num)
				{
				}
				num = (short)1820262401;
				if (num != 0)
				{
				}
				num = (short)1574109184;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsFrequencyRangeStartMHz_A41856.Applicable = value;
			}
		}

		// Token: 0x170021A2 RID: 8610
		// (get) Token: 0x060041AB RID: 16811 RVA: 0x003D6AB0 File Offset: 0x003D4CB0
		// (set) Token: 0x060041AC RID: 16812 RVA: 0x003D6B64 File Offset: 0x003D4D64
		public bool RadWideTransmitPowerLevelsFrequencyRangeStartMHz_A41856_Valid
		{
			get
			{
				short num = (short)1187840000;
				short num2 = num;
				num = (short)617322323;
				short num3 = num;
				num = (short)244684627;
				switch (num3 == num)
				{
				}
				num = (short)1471741953;
				if (num != 0)
				{
				}
				num = (short)1174339584;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsFrequencyRangeStartMHz_A41856.Valid;
			}
			set
			{
				short num = (short)893648896;
				short num2 = num;
				num = (short)165019649;
				if (num != 0)
				{
				}
				num = (short)946293927;
				short num3 = num;
				num = (short)1276857511;
				switch (num3 == num)
				{
				}
				num = (short)1774452736;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsFrequencyRangeStartMHz_A41856.Valid = value;
			}
		}

		// Token: 0x170021A3 RID: 8611
		// (get) Token: 0x060041AD RID: 16813 RVA: 0x003D6C18 File Offset: 0x003D4E18
		// (set) Token: 0x060041AE RID: 16814 RVA: 0x003D6CCC File Offset: 0x003D4ECC
		public bool RadWideTransmitPowerLevelsFrequencyRangeStartMHz_A41856_Visible
		{
			get
			{
				short num = (short)1923940352;
				short num2 = num;
				num = (short)559865391;
				short num3 = num;
				num = (short)1165352495;
				switch (num3 == num)
				{
				}
				num = (short)1941700609;
				if (num != 0)
				{
				}
				num = (short)1427177472;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsFrequencyRangeStartMHz_A41856.Visible;
			}
			set
			{
				short num = (short)689373184;
				short num2 = num;
				num = (short)547029877;
				short num3 = num;
				num = (short)1427571573;
				switch (num3 == num)
				{
				}
				num = (short)677117953;
				if (num != 0)
				{
				}
				num = (short)1780940800;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsFrequencyRangeStartMHz_A41856.Visible = value;
			}
		}

		// Token: 0x170021A4 RID: 8612
		// (get) Token: 0x060041AF RID: 16815 RVA: 0x003D6D80 File Offset: 0x003D4F80
		// (set) Token: 0x060041B0 RID: 16816 RVA: 0x003D6E34 File Offset: 0x003D5034
		public bool RadWideTransmitPowerLevelsFrequencyRangeStartMHz_A41856_Editable
		{
			get
			{
				short num = (short)24969216;
				short num2 = num;
				num = (short)441779980;
				short num3 = num;
				num = (short)1422657292;
				switch (num3 == num)
				{
				}
				num = (short)1720516609;
				if (num != 0)
				{
				}
				num = (short)1379991552;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsFrequencyRangeStartMHz_A41856.Editable;
			}
			set
			{
				short num = (short)1779236864;
				short num2 = num;
				num = (short)1489757690;
				short num3 = num;
				num = (short)1153689082;
				switch (num3 == num)
				{
				}
				num = (short)259260417;
				if (num != 0)
				{
				}
				num = (short)1922826240;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsFrequencyRangeStartMHz_A41856.Editable = value;
			}
		}

		// Token: 0x170021A5 RID: 8613
		// (get) Token: 0x060041B1 RID: 16817 RVA: 0x003D6EE8 File Offset: 0x003D50E8
		internal string RadWideTransmitPowerLevelsFrequencyRangeStartMHz_A41856_UILabel
		{
			get
			{
				short num = (short)1297678336;
				short num2 = num;
				num = (short)2011915746;
				short num3 = num;
				num = (short)160523746;
				switch (num3 == num)
				{
				}
				num = (short)1746337793;
				if (num != 0)
				{
				}
				num = (short)748224512;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsFrequencyRangeStartMHz_A41856.UIName;
			}
		}

		// Token: 0x170021A6 RID: 8614
		// (get) Token: 0x060041B2 RID: 16818 RVA: 0x003D6F9C File Offset: 0x003D519C
		// (set) Token: 0x060041B3 RID: 16819 RVA: 0x003D7050 File Offset: 0x003D5250
		internal bool RadWideTransmitPowerLevelsFrequencyRangeStartMHz_A41856_HiddenStatic
		{
			get
			{
				short num = (short)1193541632;
				short num2 = num;
				num = (short)795507685;
				short num3 = num;
				num = (short)756055013;
				switch (num3 == num)
				{
				}
				num = (short)2065760257;
				if (num != 0)
				{
				}
				num = (short)1709441024;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsFrequencyRangeStartMHz_A41856.HiddenStatic;
			}
			set
			{
				short num = (short)615579648;
				short num2 = num;
				num = (short)273793287;
				short num3 = num;
				num = (short)1908588807;
				switch (num3 == num)
				{
				}
				num = (short)1885274113;
				if (num != 0)
				{
				}
				num = (short)790167552;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsFrequencyRangeStartMHz_A41856.HiddenStatic = value;
			}
		}

		// Token: 0x170021A7 RID: 8615
		// (get) Token: 0x060041B4 RID: 16820 RVA: 0x003D7104 File Offset: 0x003D5304
		// (set) Token: 0x060041B5 RID: 16821 RVA: 0x003D71BC File Offset: 0x003D53BC
		internal bool RadWideTransmitPowerLevelsFrequencyRangeStartMHz_A41856_HiddenDynamic
		{
			get
			{
				short num = (short)1798897664;
				short num2 = num;
				num = (short)1782706482;
				short num3 = num;
				num = (short)1805381938;
				switch (num3 == num)
				{
				}
				num = (short)696451073;
				if (num != 0)
				{
				}
				num = (short)1791426560;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsFrequencyRangeStartMHz_A41856.HiddenDynamic;
			}
			set
			{
				short num = (short)1488388096;
				short num2 = num;
				num = (short)1047457685;
				short num3 = num;
				num = (short)431812501;
				switch (num3 == num)
				{
				}
				num = (short)1602093056;
				if (num != 0)
				{
				}
				num = (short)1393819649;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsFrequencyRangeStartMHz_A41856.HiddenDynamic = value;
			}
		}

		// Token: 0x170021A8 RID: 8616
		// (get) Token: 0x060041B6 RID: 16822 RVA: 0x003D7270 File Offset: 0x003D5470
		public bool RadWideTransmitPowerLevelsFrequencyRangeStartMHz_A41856_HasDiffs
		{
			get
			{
				short num = (short)1125122048;
				short num2 = num;
				num = (short)1772950240;
				short num3 = num;
				num = (short)581833440;
				switch (num3 == num)
				{
				}
				num = (short)1536557057;
				if (num != 0)
				{
				}
				num = (short)1667170304;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsFrequencyRangeStartMHz_A41856._HasDiffs;
			}
		}

		// Token: 0x170021A9 RID: 8617
		// (get) Token: 0x060041B7 RID: 16823 RVA: 0x003D7324 File Offset: 0x003D5524
		// (set) Token: 0x060041B8 RID: 16824 RVA: 0x003D73DC File Offset: 0x003D55DC
		public int RadWideTransmitPowerLevelsFrequencyRangeEndMHz_A41857Value
		{
			get
			{
				short num = (short)967180288;
				short num2 = num;
				num = (short)1303372832;
				short num3 = num;
				num = (short)588047392;
				switch (num3 == num)
				{
				}
				num = (short)1959329793;
				if (num != 0)
				{
				}
				num = (short)228524032;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsFrequencyRangeEndMHz_A41857.Value;
			}
			set
			{
				short num = (short)993394688;
				short num2 = num;
				num = (short)393624076;
				short num3 = num;
				num = (short)1236154892;
				switch (num3 == num)
				{
				}
				num = (short)158531584;
				if (num != 0)
				{
				}
				num = (short)76087297;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsFrequencyRangeEndMHz_A41857.Value = value;
			}
		}

		// Token: 0x170021AA RID: 8618
		// (get) Token: 0x060041B9 RID: 16825 RVA: 0x003D7498 File Offset: 0x003D5698
		// (set) Token: 0x060041BA RID: 16826 RVA: 0x003D754C File Offset: 0x003D574C
		public string RadWideTransmitPowerLevelsFrequencyRangeEndMHz_A41857_UIValue
		{
			get
			{
				short num = (short)1909915648;
				short num2 = num;
				num = (short)1614181733;
				short num3 = num;
				num = (short)504853861;
				switch (num3 == num)
				{
				}
				num = (short)238682113;
				if (num != 0)
				{
				}
				num = (short)373358592;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsFrequencyRangeEndMHz_A41857.UIValue;
			}
			set
			{
				short num = (short)550371328;
				short num2 = num;
				num = (short)60601051;
				short num3 = num;
				num = (short)1887023835;
				switch (num3 == num)
				{
				}
				num = (short)574947329;
				if (num != 0)
				{
				}
				num = (short)878772224;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsFrequencyRangeEndMHz_A41857.UIValue = value;
			}
		}

		// Token: 0x170021AB RID: 8619
		// (get) Token: 0x060041BB RID: 16827 RVA: 0x003D7600 File Offset: 0x003D5800
		public global::AcpBusinessLayer.AcpFrequencyField RadWideTransmitPowerLevelsFrequencyRangeEndMHz_A41857
		{
			get
			{
				short num = (short)778108928;
				short num2 = num;
				num = (short)1199046906;
				short num3 = num;
				num = (short)598475002;
				switch (num3 == num)
				{
				}
				num = (short)731381761;
				if (num != 0)
				{
				}
				num = (short)7929856;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsFrequencyRangeEndMHz_A41857;
			}
		}

		// Token: 0x170021AC RID: 8620
		// (get) Token: 0x060041BC RID: 16828 RVA: 0x003D76B4 File Offset: 0x003D58B4
		// (set) Token: 0x060041BD RID: 16829 RVA: 0x003D7768 File Offset: 0x003D5968
		internal int RadWideTransmitPowerLevelsFrequencyRangeEndMHz_A41857Min
		{
			get
			{
				short num = (short)601227264;
				short num2 = num;
				num = (short)1165633569;
				short num3 = num;
				num = (short)867706913;
				switch (num3 == num)
				{
				}
				num = (short)204668928;
				if (num != 0)
				{
				}
				num = (short)1875705857;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsFrequencyRangeEndMHz_A41857.Min;
			}
			set
			{
				short num = (short)1665859584;
				short num2 = num;
				num = (short)1250769326;
				short num3 = num;
				num = (short)1990867374;
				switch (num3 == num)
				{
				}
				num = (short)1812267009;
				if (num != 0)
				{
				}
				num = (short)1768685568;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsFrequencyRangeEndMHz_A41857.Min = value;
			}
		}

		// Token: 0x170021AD RID: 8621
		// (get) Token: 0x060041BE RID: 16830 RVA: 0x003D7820 File Offset: 0x003D5A20
		// (set) Token: 0x060041BF RID: 16831 RVA: 0x003D78D4 File Offset: 0x003D5AD4
		internal int RadWideTransmitPowerLevelsFrequencyRangeEndMHz_A41857Max
		{
			get
			{
				short num = (short)252182528;
				short num2 = num;
				num = (short)1926662780;
				short num3 = num;
				num = (short)341805692;
				switch (num3 == num)
				{
				}
				num = (short)834797568;
				if (num != 0)
				{
				}
				num = (short)1474035713;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsFrequencyRangeEndMHz_A41857.Max;
			}
			set
			{
				short num = (short)391004075;
				short num2 = num;
				num = (short)177946539;
				switch (num2 == num)
				{
				default:
				{
					num = (short)722665472;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)564199425;
				if (num != 0)
				{
				}
				num = (short)1480916992;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsFrequencyRangeEndMHz_A41857.Max = value;
			}
		}

		// Token: 0x170021AE RID: 8622
		// (get) Token: 0x060041C0 RID: 16832 RVA: 0x003D7988 File Offset: 0x003D5B88
		// (set) Token: 0x060041C1 RID: 16833 RVA: 0x003D7A40 File Offset: 0x003D5C40
		internal int RadWideTransmitPowerLevelsFrequencyRangeEndMHz_A41857Step
		{
			get
			{
				short num = (short)1441761996;
				short num2 = num;
				num = (short)988449484;
				switch (num2 == num)
				{
				default:
				{
					num = (short)976683008;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1675427841;
				if (num != 0)
				{
				}
				num = (short)282460160;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsFrequencyRangeEndMHz_A41857.StepSize;
			}
			set
			{
				short num = (short)98732731;
				short num2 = num;
				num = (short)581864123;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2091384832;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1838743552;
				if (num != 0)
				{
				}
				num = (short)743768065;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsFrequencyRangeEndMHz_A41857.StepSize = value;
			}
		}

		// Token: 0x170021AF RID: 8623
		// (get) Token: 0x060041C2 RID: 16834 RVA: 0x003D7AF8 File Offset: 0x003D5CF8
		// (set) Token: 0x060041C3 RID: 16835 RVA: 0x003D7BB0 File Offset: 0x003D5DB0
		public bool RadWideTransmitPowerLevelsFrequencyRangeEndMHz_A41857_Applicable
		{
			get
			{
				short num = (short)407822472;
				short num2 = num;
				num = (short)1941430408;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2092105728;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1562509313;
				if (num != 0)
				{
				}
				num = (short)834076672;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsFrequencyRangeEndMHz_A41857.Applicable;
			}
			set
			{
				short num = (short)761743707;
				short num2 = num;
				num = (short)2006206811;
				switch (num2 == num)
				{
				default:
				{
					num = (short)700383232;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1990524928;
				if (num != 0)
				{
				}
				num = (short)130285569;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsFrequencyRangeEndMHz_A41857.Applicable = value;
			}
		}

		// Token: 0x170021B0 RID: 8624
		// (get) Token: 0x060041C4 RID: 16836 RVA: 0x003D7C6C File Offset: 0x003D5E6C
		// (set) Token: 0x060041C5 RID: 16837 RVA: 0x003D7D24 File Offset: 0x003D5F24
		public bool RadWideTransmitPowerLevelsFrequencyRangeEndMHz_A41857_Valid
		{
			get
			{
				short num = (short)245760001;
				if (num != 0)
				{
				}
				num = (short)149356544;
				short num2 = num;
				num = (short)1718980042;
				short num3 = num;
				num = (short)592940490;
				switch (num3 == num)
				{
				}
				num = (short)487718912;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsFrequencyRangeEndMHz_A41857.Valid;
			}
			set
			{
				short num = (short)1533083649;
				if (num != 0)
				{
				}
				num = (short)335282176;
				short num2 = num;
				num = (short)1234486681;
				short num3 = num;
				num = (short)1922024857;
				switch (num3 == num)
				{
				}
				num = (short)367067136;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsFrequencyRangeEndMHz_A41857.Valid = value;
			}
		}

		// Token: 0x170021B1 RID: 8625
		// (get) Token: 0x060041C6 RID: 16838 RVA: 0x003D7DD8 File Offset: 0x003D5FD8
		// (set) Token: 0x060041C7 RID: 16839 RVA: 0x003D7E8C File Offset: 0x003D608C
		public bool RadWideTransmitPowerLevelsFrequencyRangeEndMHz_A41857_Visible
		{
			get
			{
				short num = (short)1849360930;
				short num2 = num;
				num = (short)1300628002;
				switch (num2 == num)
				{
				default:
				{
					num = (short)50331648;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1145896961;
				if (num != 0)
				{
				}
				num = (short)1950810112;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsFrequencyRangeEndMHz_A41857.Visible;
			}
			set
			{
				short num = (short)1176895489;
				if (num != 0)
				{
				}
				num = (short)2077163520;
				short num2 = num;
				num = (short)1391004576;
				short num3 = num;
				num = (short)1178864544;
				switch (num3 == num)
				{
				}
				num = (short)124190720;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsFrequencyRangeEndMHz_A41857.Visible = value;
			}
		}

		// Token: 0x170021B2 RID: 8626
		// (get) Token: 0x060041C8 RID: 16840 RVA: 0x003D7F40 File Offset: 0x003D6140
		// (set) Token: 0x060041C9 RID: 16841 RVA: 0x003D7FF4 File Offset: 0x003D61F4
		public bool RadWideTransmitPowerLevelsFrequencyRangeEndMHz_A41857_Editable
		{
			get
			{
				short num = (short)1802981084;
				short num2 = num;
				num = (short)1679642332;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1714356224;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)633208832;
				if (num != 0)
				{
				}
				num = (short)617611265;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsFrequencyRangeEndMHz_A41857.Editable;
			}
			set
			{
				short num = (short)1693619766;
				short num2 = num;
				num = (short)1774556726;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1495007232;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1458634753;
				if (num != 0)
				{
				}
				num = (short)374079488;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsFrequencyRangeEndMHz_A41857.Editable = value;
			}
		}

		// Token: 0x170021B3 RID: 8627
		// (get) Token: 0x060041CA RID: 16842 RVA: 0x003D80AC File Offset: 0x003D62AC
		internal string RadWideTransmitPowerLevelsFrequencyRangeEndMHz_A41857_UILabel
		{
			get
			{
				short num = (short)536020161;
				short num2 = num;
				num = (short)1093469377;
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
				num = (short)251854849;
				if (num != 0)
				{
				}
				num = (short)790364160;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsFrequencyRangeEndMHz_A41857.UIName;
			}
		}

		// Token: 0x170021B4 RID: 8628
		// (get) Token: 0x060041CB RID: 16843 RVA: 0x003D8160 File Offset: 0x003D6360
		// (set) Token: 0x060041CC RID: 16844 RVA: 0x003D8218 File Offset: 0x003D6418
		internal bool RadWideTransmitPowerLevelsFrequencyRangeEndMHz_A41857_HiddenStatic
		{
			get
			{
				short num = (short)627524565;
				short num2 = num;
				num = (short)634930133;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1530462208;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)623706113;
				if (num != 0)
				{
				}
				num = (short)1505296384;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsFrequencyRangeEndMHz_A41857.HiddenStatic;
			}
			set
			{
				short num = (short)1084405107;
				short num2 = num;
				num = (short)342406515;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1690501120;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)409468929;
				if (num != 0)
				{
				}
				num = (short)1638137856;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsFrequencyRangeEndMHz_A41857.HiddenStatic = value;
			}
		}

		// Token: 0x170021B5 RID: 8629
		// (get) Token: 0x060041CD RID: 16845 RVA: 0x003D82CC File Offset: 0x003D64CC
		// (set) Token: 0x060041CE RID: 16846 RVA: 0x003D8380 File Offset: 0x003D6580
		internal bool RadWideTransmitPowerLevelsFrequencyRangeEndMHz_A41857_HiddenDynamic
		{
			get
			{
				short num = (short)1187521066;
				short num2 = num;
				num = (short)1054876202;
				switch (num2 == num)
				{
				default:
				{
					num = (short)449445888;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1537474561;
				if (num != 0)
				{
				}
				num = (short)964165632;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsFrequencyRangeEndMHz_A41857.HiddenDynamic;
			}
			set
			{
				short num = (short)1031384248;
				short num2 = num;
				num = (short)1047440568;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1324613632;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1989607425;
				if (num != 0)
				{
				}
				num = (short)2092040192;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsFrequencyRangeEndMHz_A41857.HiddenDynamic = value;
			}
		}

		// Token: 0x170021B6 RID: 8630
		// (get) Token: 0x060041CF RID: 16847 RVA: 0x003D8438 File Offset: 0x003D6638
		public bool RadWideTransmitPowerLevelsFrequencyRangeEndMHz_A41857_HasDiffs
		{
			get
			{
				short num = (short)1586036737;
				if (num != 0)
				{
				}
				num = (short)68878336;
				short num2 = num;
				num = (short)694862791;
				short num3 = num;
				num = (short)627950535;
				switch (num3 == num)
				{
				}
				num = (short)2079457280;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsFrequencyRangeEndMHz_A41857._HasDiffs;
			}
		}

		// Token: 0x170021B7 RID: 8631
		// (get) Token: 0x060041D0 RID: 16848 RVA: 0x003D84EC File Offset: 0x003D66EC
		// (set) Token: 0x060041D1 RID: 16849 RVA: 0x003D85A4 File Offset: 0x003D67A4
		public int RadWideTransmitPowerLevelsTxPowerLevelMinimumW_A41858Value
		{
			get
			{
				short num = (short)729790990;
				short num2 = num;
				num = (short)1269807630;
				switch (num2 == num)
				{
				default:
				{
					num = (short)687210496;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)500563968;
				if (num != 0)
				{
				}
				num = (short)1081475073;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelMinimumW_A41858.Value;
			}
			set
			{
				short num = (short)1798678765;
				short num2 = num;
				num = (short)1311549677;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2086076416;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)181207040;
				if (num != 0)
				{
				}
				num = (short)1068040193;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTxPowerLevelMinimumW_A41858.Value = value;
			}
		}

		// Token: 0x170021B8 RID: 8632
		// (get) Token: 0x060041D2 RID: 16850 RVA: 0x003D8658 File Offset: 0x003D6858
		public global::AcpBusinessLayer.AcpRangeField<int, string> RadWideTransmitPowerLevelsTxPowerLevelMinimumW_A41858
		{
			get
			{
				short num = (short)1102391806;
				short num2 = num;
				num = (short)105064958;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1044709376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1074659328;
				if (num != 0)
				{
				}
				num = (short)988348417;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelMinimumW_A41858;
			}
		}

		// Token: 0x170021B9 RID: 8633
		// (get) Token: 0x060041D3 RID: 16851 RVA: 0x003D870C File Offset: 0x003D690C
		// (set) Token: 0x060041D4 RID: 16852 RVA: 0x003D87C0 File Offset: 0x003D69C0
		public string RadWideTransmitPowerLevelsTxPowerLevelMinimumW_A41858_UIValue
		{
			get
			{
				short num = (short)884366280;
				short num2 = num;
				num = (short)635395016;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1583415296;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)113311744;
				if (num != 0)
				{
				}
				num = (short)461111297;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelMinimumW_A41858.UIValue;
			}
			set
			{
				short num = (short)51454631;
				short num2 = num;
				num = (short)1968906919;
				switch (num2 == num)
				{
				default:
				{
					num = (short)965804032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1858404353;
				if (num != 0)
				{
				}
				num = (short)483524608;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTxPowerLevelMinimumW_A41858.UIValue = value;
			}
		}

		// Token: 0x170021BA RID: 8634
		// (get) Token: 0x060041D5 RID: 16853 RVA: 0x003D8874 File Offset: 0x003D6A74
		// (set) Token: 0x060041D6 RID: 16854 RVA: 0x003D892C File Offset: 0x003D6B2C
		internal int RadWideTransmitPowerLevelsTxPowerLevelMinimumW_A41858Min
		{
			get
			{
				short num = (short)464849881;
				short num2 = num;
				num = (short)1926106073;
				switch (num2 == num)
				{
				default:
				{
					num = (short)196149248;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1607729153;
				if (num != 0)
				{
				}
				num = (short)1760886784;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelMinimumW_A41858.Min;
			}
			set
			{
				short num = (short)680389168;
				short num2 = num;
				num = (short)2109401648;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1519058944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)989396992;
				if (num != 0)
				{
				}
				num = (short)878247937;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTxPowerLevelMinimumW_A41858.Min = value;
			}
		}

		// Token: 0x170021BB RID: 8635
		// (get) Token: 0x060041D7 RID: 16855 RVA: 0x003D89E0 File Offset: 0x003D6BE0
		// (set) Token: 0x060041D8 RID: 16856 RVA: 0x003D8A94 File Offset: 0x003D6C94
		internal int RadWideTransmitPowerLevelsTxPowerLevelMinimumW_A41858Max
		{
			get
			{
				short num = (short)1941402740;
				short num2 = num;
				num = (short)749696116;
				switch (num2 == num)
				{
				default:
				{
					num = (short)739377152;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)66125825;
				if (num != 0)
				{
				}
				num = (short)2108817408;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelMinimumW_A41858.Max;
			}
			set
			{
				short num = (short)385892753;
				short num2 = num;
				num = (short)1627275665;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1601306624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)608174081;
				if (num != 0)
				{
				}
				num = (short)618594304;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTxPowerLevelMinimumW_A41858.Max = value;
			}
		}

		// Token: 0x170021BC RID: 8636
		// (get) Token: 0x060041D9 RID: 16857 RVA: 0x003D8B4C File Offset: 0x003D6D4C
		// (set) Token: 0x060041DA RID: 16858 RVA: 0x003D8C00 File Offset: 0x003D6E00
		internal int RadWideTransmitPowerLevelsTxPowerLevelMinimumW_A41858Step
		{
			get
			{
				short num = (short)505911285;
				short num2 = num;
				num = (short)981964789;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1050214400;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)958660609;
				if (num != 0)
				{
				}
				num = (short)814219264;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelMinimumW_A41858.StepSize;
			}
			set
			{
				short num = (short)1202539880;
				short num2 = num;
				num = (short)872303976;
				switch (num2 == num)
				{
				default:
				{
					num = (short)455016448;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1904082945;
				if (num != 0)
				{
				}
				num = (short)1744437248;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTxPowerLevelMinimumW_A41858.StepSize = value;
			}
		}

		// Token: 0x170021BD RID: 8637
		// (get) Token: 0x060041DB RID: 16859 RVA: 0x003D8CB4 File Offset: 0x003D6EB4
		// (set) Token: 0x060041DC RID: 16860 RVA: 0x003D8D68 File Offset: 0x003D6F68
		public bool RadWideTransmitPowerLevelsTxPowerLevelMinimumW_A41858_Applicable
		{
			get
			{
				short num = (short)444172344;
				short num2 = num;
				num = (short)973047864;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1341652992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)520880129;
				if (num != 0)
				{
				}
				num = (short)789905408;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelMinimumW_A41858.Applicable;
			}
			set
			{
				short num = (short)1488517317;
				short num2 = num;
				num = (short)886831301;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1346109440;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1850015745;
				if (num != 0)
				{
				}
				num = (short)893911040;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTxPowerLevelMinimumW_A41858.Applicable = value;
			}
		}

		// Token: 0x170021BE RID: 8638
		// (get) Token: 0x060041DD RID: 16861 RVA: 0x003D8E20 File Offset: 0x003D7020
		// (set) Token: 0x060041DE RID: 16862 RVA: 0x003D8ED8 File Offset: 0x003D70D8
		public bool RadWideTransmitPowerLevelsTxPowerLevelMinimumW_A41858_Valid
		{
			get
			{
				short num = (short)1330036206;
				short num2 = num;
				num = (short)932691438;
				switch (num2 == num)
				{
				default:
				{
					num = (short)664010752;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1842610176;
				if (num != 0)
				{
				}
				num = (short)101253121;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelMinimumW_A41858.Valid;
			}
			set
			{
				short num = (short)1821965409;
				short num2 = num;
				num = (short)1612446817;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1062535168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1369571329;
				if (num != 0)
				{
				}
				num = (short)822280192;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTxPowerLevelMinimumW_A41858.Valid = value;
			}
		}

		// Token: 0x170021BF RID: 8639
		// (get) Token: 0x060041DF RID: 16863 RVA: 0x003D8F8C File Offset: 0x003D718C
		// (set) Token: 0x060041E0 RID: 16864 RVA: 0x003D9040 File Offset: 0x003D7240
		public bool RadWideTransmitPowerLevelsTxPowerLevelMinimumW_A41858_Visible
		{
			get
			{
				short num = (short)1520699133;
				short num2 = num;
				num = (short)1206191869;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1770520576;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1426128897;
				if (num != 0)
				{
				}
				num = (short)1659764736;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelMinimumW_A41858.Visible;
			}
			set
			{
				short num = (short)214548035;
				short num2 = num;
				num = (short)473349699;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1276379136;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1817706496;
				if (num != 0)
				{
				}
				num = (short)1507000321;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTxPowerLevelMinimumW_A41858.Visible = value;
			}
		}

		// Token: 0x170021C0 RID: 8640
		// (get) Token: 0x060041E1 RID: 16865 RVA: 0x003D90F4 File Offset: 0x003D72F4
		// (set) Token: 0x060041E2 RID: 16866 RVA: 0x003D91A4 File Offset: 0x003D73A4
		public bool RadWideTransmitPowerLevelsTxPowerLevelMinimumW_A41858_Editable
		{
			get
			{
				short num = (short)1145654977;
				short num2 = num;
				num = (short)1013010113;
				switch (num2 == num)
				{
				default:
				{
					num = (short)10223616;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1981087744;
				if (num != 0)
				{
				}
				num = (short)790036481;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelMinimumW_A41858.Editable;
			}
			set
			{
				short num = (short)804978689;
				if (num != 0)
				{
				}
				num = (short)1087766528;
				short num2 = num;
				num = (short)168955015;
				short num3 = num;
				num = (short)1597508743;
				switch (num3 == num)
				{
				}
				num = (short)1612840960;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTxPowerLevelMinimumW_A41858.Editable = value;
			}
		}

		// Token: 0x170021C1 RID: 8641
		// (get) Token: 0x060041E3 RID: 16867 RVA: 0x003D9258 File Offset: 0x003D7458
		internal string RadWideTransmitPowerLevelsTxPowerLevelMinimumW_A41858_UILabel
		{
			get
			{
				short num = (short)96715244;
				short num2 = num;
				num = (short)299942380;
				switch (num2 == num)
				{
				default:
				{
					num = (short)338296832;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1490747393;
				if (num != 0)
				{
				}
				num = (short)1696595968;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelMinimumW_A41858.UIName;
			}
		}

		// Token: 0x170021C2 RID: 8642
		// (get) Token: 0x060041E4 RID: 16868 RVA: 0x003D930C File Offset: 0x003D750C
		// (set) Token: 0x060041E5 RID: 16869 RVA: 0x003D93C0 File Offset: 0x003D75C0
		internal bool RadWideTransmitPowerLevelsTxPowerLevelMinimumW_A41858_HiddenStatic
		{
			get
			{
				short num = (short)1329922049;
				if (num != 0)
				{
				}
				num = (short)1578172416;
				short num2 = num;
				num = (short)817888679;
				short num3 = num;
				num = (short)1590230439;
				switch (num3 == num)
				{
				}
				num = (short)2061565952;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelMinimumW_A41858.HiddenStatic;
			}
			set
			{
				short num = (short)1962588697;
				short num2 = num;
				num = (short)497007129;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1301544960;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1580138497;
				if (num != 0)
				{
				}
				num = (short)1023672320;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTxPowerLevelMinimumW_A41858.HiddenStatic = value;
			}
		}

		// Token: 0x170021C3 RID: 8643
		// (get) Token: 0x060041E6 RID: 16870 RVA: 0x003D9474 File Offset: 0x003D7674
		// (set) Token: 0x060041E7 RID: 16871 RVA: 0x003D9528 File Offset: 0x003D7728
		internal bool RadWideTransmitPowerLevelsTxPowerLevelMinimumW_A41858_HiddenDynamic
		{
			get
			{
				short num = (short)35092802;
				short num2 = num;
				num = (short)693991746;
				switch (num2 == num)
				{
				default:
				{
					num = (short)17956864;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1742209025;
				if (num != 0)
				{
				}
				num = (short)1499004928;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelMinimumW_A41858.HiddenDynamic;
			}
			set
			{
				short num = (short)1774723168;
				short num2 = num;
				num = (short)1844715616;
				switch (num2 == num)
				{
				default:
				{
					num = (short)617152512;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)282787841;
				if (num != 0)
				{
				}
				num = (short)1682178048;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTxPowerLevelMinimumW_A41858.HiddenDynamic = value;
			}
		}

		// Token: 0x170021C4 RID: 8644
		// (get) Token: 0x060041E8 RID: 16872 RVA: 0x003D95E0 File Offset: 0x003D77E0
		public bool RadWideTransmitPowerLevelsTxPowerLevelMinimumW_A41858_HasDiffs
		{
			get
			{
				short num = (short)1241408448;
				short num2 = num;
				num = (short)316498880;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1678639104;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1298857985;
				if (num != 0)
				{
				}
				num = (short)1419444224;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelMinimumW_A41858._HasDiffs;
			}
		}

		// Token: 0x170021C5 RID: 8645
		// (get) Token: 0x060041E9 RID: 16873 RVA: 0x003D9694 File Offset: 0x003D7894
		// (set) Token: 0x060041EA RID: 16874 RVA: 0x003D9748 File Offset: 0x003D7948
		public int RadWideTransmitPowerLevelsTxPowerLevelMaximumW_A41859Value
		{
			get
			{
				short num = (short)1012691013;
				short num2 = num;
				num = (short)480276549;
				switch (num2 == num)
				{
				default:
				{
					num = (short)266600448;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1188102145;
				if (num != 0)
				{
				}
				num = (short)1724776448;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelMaximumW_A41859.Value;
			}
			set
			{
				short num = (short)315781674;
				short num2 = num;
				num = (short)362705450;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1494810624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1044971521;
				if (num != 0)
				{
				}
				num = (short)618594304;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTxPowerLevelMaximumW_A41859.Value = value;
			}
		}

		// Token: 0x170021C6 RID: 8646
		// (get) Token: 0x060041EB RID: 16875 RVA: 0x003D97FC File Offset: 0x003D79FC
		public global::AcpBusinessLayer.AcpRangeField<int, string> RadWideTransmitPowerLevelsTxPowerLevelMaximumW_A41859
		{
			get
			{
				short num = (short)1466456827;
				short num2 = num;
				num = (short)501046011;
				switch (num2 == num)
				{
				default:
				{
					num = (short)196411392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)49348609;
				if (num != 0)
				{
				}
				num = (short)329908224;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelMaximumW_A41859;
			}
		}

		// Token: 0x170021C7 RID: 8647
		// (get) Token: 0x060041EC RID: 16876 RVA: 0x003D98AC File Offset: 0x003D7AAC
		// (set) Token: 0x060041ED RID: 16877 RVA: 0x003D9960 File Offset: 0x003D7B60
		public string RadWideTransmitPowerLevelsTxPowerLevelMaximumW_A41859_UIValue
		{
			get
			{
				short num = (short)230877907;
				short num2 = num;
				num = (short)930081491;
				switch (num2 == num)
				{
				default:
				{
					num = (short)447414272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)831848449;
				if (num != 0)
				{
				}
				num = (short)643694592;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelMaximumW_A41859.UIValue;
			}
			set
			{
				short num = (short)2116472587;
				short num2 = num;
				num = (short)1834077963;
				switch (num2 == num)
				{
				default:
				{
					num = (short)380567552;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)726073345;
				if (num != 0)
				{
				}
				num = (short)2004811776;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTxPowerLevelMaximumW_A41859.UIValue = value;
			}
		}

		// Token: 0x170021C8 RID: 8648
		// (get) Token: 0x060041EE RID: 16878 RVA: 0x003D9A18 File Offset: 0x003D7C18
		// (set) Token: 0x060041EF RID: 16879 RVA: 0x003D9ACC File Offset: 0x003D7CCC
		internal int RadWideTransmitPowerLevelsTxPowerLevelMaximumW_A41859Min
		{
			get
			{
				short num = (short)124125185;
				if (num != 0)
				{
				}
				num = (short)707985408;
				short num2 = num;
				num = (short)1264135853;
				short num3 = num;
				num = (short)79703725;
				switch (num3 == num)
				{
				}
				num = (short)1173225472;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelMaximumW_A41859.Min;
			}
			set
			{
				short num = (short)895817697;
				short num2 = num;
				num = (short)1411258337;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1868169216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)172752897;
				if (num != 0)
				{
				}
				num = (short)829161472;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTxPowerLevelMaximumW_A41859.Min = value;
			}
		}

		// Token: 0x170021C9 RID: 8649
		// (get) Token: 0x060041F0 RID: 16880 RVA: 0x003D9B80 File Offset: 0x003D7D80
		// (set) Token: 0x060041F1 RID: 16881 RVA: 0x003D9C38 File Offset: 0x003D7E38
		internal int RadWideTransmitPowerLevelsTxPowerLevelMaximumW_A41859Max
		{
			get
			{
				short num = (short)619366572;
				short num2 = num;
				num = (short)1881065644;
				switch (num2 == num)
				{
				default:
				{
					num = (short)907083776;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)6422528;
				if (num != 0)
				{
				}
				num = (short)1933049857;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelMaximumW_A41859.Max;
			}
			set
			{
				short num = (short)2047471380;
				short num2 = num;
				num = (short)5762836;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1765474304;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)328859649;
				if (num != 0)
				{
				}
				num = (short)199163904;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTxPowerLevelMaximumW_A41859.Max = value;
			}
		}

		// Token: 0x170021CA RID: 8650
		// (get) Token: 0x060041F2 RID: 16882 RVA: 0x003D9CF0 File Offset: 0x003D7EF0
		// (set) Token: 0x060041F3 RID: 16883 RVA: 0x003D9DA0 File Offset: 0x003D7FA0
		internal int RadWideTransmitPowerLevelsTxPowerLevelMaximumW_A41859Step
		{
			get
			{
				short num = (short)438912747;
				short num2 = num;
				num = (short)266684139;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1490747392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1013645312;
				if (num != 0)
				{
				}
				num = (short)1693712385;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelMaximumW_A41859.StepSize;
			}
			set
			{
				short num = (short)1352695604;
				short num2 = num;
				num = (short)761036596;
				switch (num2 == num)
				{
				default:
				{
					num = (short)296222720;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1420558336;
				if (num != 0)
				{
				}
				num = (short)569376769;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTxPowerLevelMaximumW_A41859.StepSize = value;
			}
		}

		// Token: 0x170021CB RID: 8651
		// (get) Token: 0x060041F4 RID: 16884 RVA: 0x003D9E54 File Offset: 0x003D8054
		// (set) Token: 0x060041F5 RID: 16885 RVA: 0x003D9F08 File Offset: 0x003D8108
		public bool RadWideTransmitPowerLevelsTxPowerLevelMaximumW_A41859_Applicable
		{
			get
			{
				short num = (short)1715605424;
				short num2 = num;
				num = (short)1559564208;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1826095104;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1319632897;
				if (num != 0)
				{
				}
				num = (short)692453376;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelMaximumW_A41859.Applicable;
			}
			set
			{
				short num = (short)549453825;
				if (num != 0)
				{
				}
				num = (short)2065563648;
				short num2 = num;
				num = (short)1175793332;
				short num3 = num;
				num = (short)410726068;
				switch (num3 == num)
				{
				}
				num = (short)692453376;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTxPowerLevelMaximumW_A41859.Applicable = value;
			}
		}

		// Token: 0x170021CC RID: 8652
		// (get) Token: 0x060041F6 RID: 16886 RVA: 0x003D9FC0 File Offset: 0x003D81C0
		// (set) Token: 0x060041F7 RID: 16887 RVA: 0x003DA078 File Offset: 0x003D8278
		public bool RadWideTransmitPowerLevelsTxPowerLevelMaximumW_A41859_Valid
		{
			get
			{
				short num = (short)2131041540;
				short num2 = num;
				num = (short)899292420;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1029111808;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1761607681;
				if (num != 0)
				{
				}
				num = (short)364576768;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelMaximumW_A41859.Valid;
			}
			set
			{
				short num = (short)290750194;
				short num2 = num;
				num = (short)1651605234;
				switch (num2 == num)
				{
				default:
				{
					num = (short)732823552;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1064304640;
				if (num != 0)
				{
				}
				num = (short)94044161;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTxPowerLevelMaximumW_A41859.Valid = value;
			}
		}

		// Token: 0x170021CD RID: 8653
		// (get) Token: 0x060041F8 RID: 16888 RVA: 0x003DA12C File Offset: 0x003D832C
		// (set) Token: 0x060041F9 RID: 16889 RVA: 0x003DA1E0 File Offset: 0x003D83E0
		public bool RadWideTransmitPowerLevelsTxPowerLevelMaximumW_A41859_Visible
		{
			get
			{
				short num = (short)2059640971;
				short num2 = num;
				num = (short)873832587;
				switch (num2 == num)
				{
				default:
				{
					num = (short)508887040;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)303169536;
				if (num != 0)
				{
				}
				num = (short)185073665;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelMaximumW_A41859.Visible;
			}
			set
			{
				short num = (short)1830710292;
				short num2 = num;
				num = (short)1099983892;
				switch (num2 == num)
				{
				default:
				{
					num = (short)857407488;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)442957825;
				if (num != 0)
				{
				}
				num = (short)1271398400;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTxPowerLevelMaximumW_A41859.Visible = value;
			}
		}

		// Token: 0x170021CE RID: 8654
		// (get) Token: 0x060041FA RID: 16890 RVA: 0x003DA294 File Offset: 0x003D8494
		// (set) Token: 0x060041FB RID: 16891 RVA: 0x003DA348 File Offset: 0x003D8548
		public bool RadWideTransmitPowerLevelsTxPowerLevelMaximumW_A41859_Editable
		{
			get
			{
				short num = (short)610207689;
				short num2 = num;
				num = (short)865994697;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1373700096;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1172242433;
				if (num != 0)
				{
				}
				num = (short)966983680;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelMaximumW_A41859.Editable;
			}
			set
			{
				short num = (short)2071328213;
				short num2 = num;
				num = (short)386004437;
				switch (num2 == num)
				{
				default:
				{
					num = (short)431161344;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)523108352;
				if (num != 0)
				{
				}
				num = (short)613679105;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTxPowerLevelMaximumW_A41859.Editable = value;
			}
		}

		// Token: 0x170021CF RID: 8655
		// (get) Token: 0x060041FC RID: 16892 RVA: 0x003DA3FC File Offset: 0x003D85FC
		internal string RadWideTransmitPowerLevelsTxPowerLevelMaximumW_A41859_UILabel
		{
			get
			{
				short num = (short)19429425;
				short num2 = num;
				num = (short)1389852721;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1701511168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)628817920;
				if (num != 0)
				{
				}
				num = (short)1406533633;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelMaximumW_A41859.UIName;
			}
		}

		// Token: 0x170021D0 RID: 8656
		// (get) Token: 0x060041FD RID: 16893 RVA: 0x003DA4B0 File Offset: 0x003D86B0
		// (set) Token: 0x060041FE RID: 16894 RVA: 0x003DA564 File Offset: 0x003D8764
		internal bool RadWideTransmitPowerLevelsTxPowerLevelMaximumW_A41859_HiddenStatic
		{
			get
			{
				short num = (short)1781234153;
				short num2 = num;
				num = (short)1108310505;
				switch (num2 == num)
				{
				default:
				{
					num = (short)851116032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1763639296;
				if (num != 0)
				{
				}
				num = (short)71630849;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelMaximumW_A41859.HiddenStatic;
			}
			set
			{
				short num = (short)614273754;
				short num2 = num;
				num = (short)734073562;
				switch (num2 == num)
				{
				default:
				{
					num = (short)939130880;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1566113793;
				if (num != 0)
				{
				}
				num = (short)2075918336;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTxPowerLevelMaximumW_A41859.HiddenStatic = value;
			}
		}

		// Token: 0x170021D1 RID: 8657
		// (get) Token: 0x060041FF RID: 16895 RVA: 0x003DA618 File Offset: 0x003D8818
		// (set) Token: 0x06004200 RID: 16896 RVA: 0x003DA6CC File Offset: 0x003D88CC
		internal bool RadWideTransmitPowerLevelsTxPowerLevelMaximumW_A41859_HiddenDynamic
		{
			get
			{
				short num = (short)558207214;
				short num2 = num;
				num = (short)1539805422;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1542717440;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)62062593;
				if (num != 0)
				{
				}
				num = (short)1008140288;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelMaximumW_A41859.HiddenDynamic;
			}
			set
			{
				short num = (short)1342609877;
				short num2 = num;
				num = (short)2055903701;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2048131072;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1872953345;
				if (num != 0)
				{
				}
				num = (short)1877016576;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTxPowerLevelMaximumW_A41859.HiddenDynamic = value;
			}
		}

		// Token: 0x170021D2 RID: 8658
		// (get) Token: 0x06004201 RID: 16897 RVA: 0x003DA784 File Offset: 0x003D8984
		public bool RadWideTransmitPowerLevelsTxPowerLevelMaximumW_A41859_HasDiffs
		{
			get
			{
				short num = (short)1237188035;
				short num2 = num;
				num = (short)1543699907;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1923088384;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)187564033;
				if (num != 0)
				{
				}
				num = (short)1797521408;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelMaximumW_A41859._HasDiffs;
			}
		}

		// Token: 0x170021D3 RID: 8659
		// (get) Token: 0x06004202 RID: 16898 RVA: 0x003DA838 File Offset: 0x003D8A38
		// (set) Token: 0x06004203 RID: 16899 RVA: 0x003DA8EC File Offset: 0x003D8AEC
		public int RadWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41860Value
		{
			get
			{
				short num = (short)1476232593;
				short num2 = num;
				num = (short)769557905;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1259798528;
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
				num = (short)1485963265;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41860.Value;
			}
			set
			{
				short num = (short)1754097330;
				short num2 = num;
				num = (short)1636656818;
				switch (num2 == num)
				{
				default:
				{
					num = (short)26083328;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1485897729;
				if (num != 0)
				{
				}
				num = (short)207552512;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41860.Value = value;
			}
		}

		// Token: 0x170021D4 RID: 8660
		// (get) Token: 0x06004204 RID: 16900 RVA: 0x003DA9A0 File Offset: 0x003D8BA0
		public global::AcpBusinessLayer.AcpRangeField<int, string> RadWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41860
		{
			get
			{
				short num = (short)778442147;
				short num2 = num;
				num = (short)1954223523;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1060306944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)553517057;
				if (num != 0)
				{
				}
				num = (short)1178730496;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41860;
			}
		}

		// Token: 0x170021D5 RID: 8661
		// (get) Token: 0x06004205 RID: 16901 RVA: 0x003DAA50 File Offset: 0x003D8C50
		// (set) Token: 0x06004206 RID: 16902 RVA: 0x003DAB04 File Offset: 0x003D8D04
		public string RadWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41860_UIValue
		{
			get
			{
				short num = (short)1075768012;
				short num2 = num;
				num = (short)1291578060;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1792868352;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)716308481;
				if (num != 0)
				{
				}
				num = (short)1084096512;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41860.UIValue;
			}
			set
			{
				short num = (short)1217644063;
				short num2 = num;
				num = (short)1381156383;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1792737280;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1698168832;
				if (num != 0)
				{
				}
				num = (short)92340225;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41860.UIValue = value;
			}
		}

		// Token: 0x170021D6 RID: 8662
		// (get) Token: 0x06004207 RID: 16903 RVA: 0x003DABB8 File Offset: 0x003D8DB8
		// (set) Token: 0x06004208 RID: 16904 RVA: 0x003DAC70 File Offset: 0x003D8E70
		internal int RadWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41860Min
		{
			get
			{
				short num = (short)1589116916;
				short num2 = num;
				num = (short)1381302260;
				switch (num2 == num)
				{
				default:
				{
					num = (short)354222080;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1158021121;
				if (num != 0)
				{
				}
				num = (short)1912930304;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41860.Min;
			}
			set
			{
				short num = (short)446967723;
				short num2 = num;
				num = (short)1125920683;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1424883712;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1395916801;
				if (num != 0)
				{
				}
				num = (short)1721171968;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41860.Min = value;
			}
		}

		// Token: 0x170021D7 RID: 8663
		// (get) Token: 0x06004209 RID: 16905 RVA: 0x003DAD28 File Offset: 0x003D8F28
		// (set) Token: 0x0600420A RID: 16906 RVA: 0x003DADE0 File Offset: 0x003D8FE0
		internal int RadWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41860Max
		{
			get
			{
				short num = (short)65800605;
				short num2 = num;
				num = (short)838470045;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1391329280;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)844759041;
				if (num != 0)
				{
				}
				num = (short)1844903936;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41860.Max;
			}
			set
			{
				short num = (short)1167456264;
				short num2 = num;
				num = (short)848885768;
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
				num = (short)268500993;
				if (num != 0)
				{
				}
				num = (short)606470144;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41860.Max = value;
			}
		}

		// Token: 0x170021D8 RID: 8664
		// (get) Token: 0x0600420B RID: 16907 RVA: 0x003DAE98 File Offset: 0x003D9098
		// (set) Token: 0x0600420C RID: 16908 RVA: 0x003DAF4C File Offset: 0x003D914C
		internal int RadWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41860Step
		{
			get
			{
				short num = (short)1379401729;
				if (num != 0)
				{
				}
				num = (short)653852672;
				short num2 = num;
				num = (short)1347924578;
				short num3 = num;
				num = (short)101692002;
				switch (num3 == num)
				{
				}
				num = (short)866123776;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41860.StepSize;
			}
			set
			{
				short num = (short)1624152495;
				short num2 = num;
				num = (short)452041135;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1083375616;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)947716096;
				if (num != 0)
				{
				}
				num = (short)1341980673;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41860.StepSize = value;
			}
		}

		// Token: 0x170021D9 RID: 8665
		// (get) Token: 0x0600420D RID: 16909 RVA: 0x003DB004 File Offset: 0x003D9204
		// (set) Token: 0x0600420E RID: 16910 RVA: 0x003DB0B8 File Offset: 0x003D92B8
		public bool RadWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41860_Applicable
		{
			get
			{
				short num = (short)2119405364;
				short num2 = num;
				num = (short)304910132;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1721434112;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1728446465;
				if (num != 0)
				{
				}
				num = (short)1350434816;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41860.Applicable;
			}
			set
			{
				short num = (short)175606176;
				short num2 = num;
				num = (short)1113229728;
				switch (num2 == num)
				{
				default:
				{
					num = (short)904331264;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1496055808;
				if (num != 0)
				{
				}
				num = (short)1711276033;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41860.Applicable = value;
			}
		}

		// Token: 0x170021DA RID: 8666
		// (get) Token: 0x0600420F RID: 16911 RVA: 0x003DB16C File Offset: 0x003D936C
		// (set) Token: 0x06004210 RID: 16912 RVA: 0x003DB21C File Offset: 0x003D941C
		public bool RadWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41860_Valid
		{
			get
			{
				short num = (short)1530425990;
				short num2 = num;
				num = (short)373518982;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1390739456;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)945553409;
				if (num != 0)
				{
				}
				num = (short)1808138240;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41860.Valid;
			}
			set
			{
				short num = (short)965214208;
				short num2 = num;
				num = (short)826894664;
				short num3 = num;
				num = (short)965241160;
				switch (num3 == num)
				{
				}
				num = (short)499908609;
				if (num != 0)
				{
				}
				num = (short)904986624;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41860.Valid = value;
			}
		}

		// Token: 0x170021DB RID: 8667
		// (get) Token: 0x06004211 RID: 16913 RVA: 0x003DB2D4 File Offset: 0x003D94D4
		// (set) Token: 0x06004212 RID: 16914 RVA: 0x003DB384 File Offset: 0x003D9584
		public bool RadWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41860_Visible
		{
			get
			{
				short num = (short)2054946816;
				short num2 = num;
				num = (short)1496135046;
				short num3 = num;
				num = (short)463353222;
				switch (num3 == num)
				{
				}
				num = (short)1650458624;
				if (num != 0)
				{
				}
				num = (short)1172963329;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41860.Visible;
			}
			set
			{
				short num = (short)1904934912;
				short num2 = num;
				num = (short)1182580620;
				short num3 = num;
				num = (short)493076364;
				switch (num3 == num)
				{
				}
				num = (short)1165492225;
				if (num != 0)
				{
				}
				num = (short)101711872;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41860.Visible = value;
			}
		}

		// Token: 0x170021DC RID: 8668
		// (get) Token: 0x06004213 RID: 16915 RVA: 0x003DB43C File Offset: 0x003D963C
		// (set) Token: 0x06004214 RID: 16916 RVA: 0x003DB4F0 File Offset: 0x003D96F0
		public bool RadWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41860_Editable
		{
			get
			{
				short num = (short)1050935296;
				short num2 = num;
				num = (short)1032912897;
				if (num != 0)
				{
				}
				num = (short)1197083056;
				short num3 = num;
				num = (short)2041776560;
				switch (num3 == num)
				{
				}
				num = (short)1440350208;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41860.Editable;
			}
			set
			{
				short num = (short)1372913664;
				short num2 = num;
				num = (short)1762293506;
				short num3 = num;
				num = (short)381515522;
				switch (num3 == num)
				{
				}
				num = (short)864813056;
				if (num != 0)
				{
				}
				num = (short)223019009;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41860.Editable = value;
			}
		}

		// Token: 0x170021DD RID: 8669
		// (get) Token: 0x06004215 RID: 16917 RVA: 0x003DB5A4 File Offset: 0x003D97A4
		internal string RadWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41860_UILabel
		{
			get
			{
				short num = (short)438763520;
				short num2 = num;
				num = (short)364084525;
				short num3 = num;
				num = (short)1757707565;
				switch (num3 == num)
				{
				}
				num = (short)1177419776;
				if (num != 0)
				{
				}
				num = (short)662044673;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41860.UIName;
			}
		}

		// Token: 0x170021DE RID: 8670
		// (get) Token: 0x06004216 RID: 16918 RVA: 0x003DB658 File Offset: 0x003D9858
		// (set) Token: 0x06004217 RID: 16919 RVA: 0x003DB710 File Offset: 0x003D9910
		internal bool RadWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41860_HiddenStatic
		{
			get
			{
				short num = (short)1098645504;
				short num2 = num;
				num = (short)1503199233;
				if (num != 0)
				{
				}
				num = (short)1886320461;
				short num3 = num;
				num = (short)92731213;
				switch (num3 == num)
				{
				}
				num = (short)786759680;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41860.HiddenStatic;
			}
			set
			{
				short num = (short)303824896;
				short num2 = num;
				num = (short)1564184463;
				short num3 = num;
				num = (short)499945359;
				switch (num3 == num)
				{
				}
				num = (short)1661009921;
				if (num != 0)
				{
				}
				num = (short)553582592;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41860.HiddenStatic = value;
			}
		}

		// Token: 0x170021DF RID: 8671
		// (get) Token: 0x06004218 RID: 16920 RVA: 0x003DB7C8 File Offset: 0x003D99C8
		// (set) Token: 0x06004219 RID: 16921 RVA: 0x003DB87C File Offset: 0x003D9A7C
		internal bool RadWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41860_HiddenDynamic
		{
			get
			{
				short num = (short)1013710848;
				short num2 = num;
				num = (short)1893872060;
				short num3 = num;
				num = (short)2078421436;
				switch (num3 == num)
				{
				}
				num = (short)9633793;
				if (num != 0)
				{
				}
				num = (short)766902272;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41860.HiddenDynamic;
			}
			set
			{
				short num = (short)1387003904;
				short num2 = num;
				num = (short)1751158164;
				short num3 = num;
				num = (short)1605995924;
				switch (num3 == num)
				{
				}
				num = (short)588840961;
				if (num != 0)
				{
				}
				num = (short)1621295104;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41860.HiddenDynamic = value;
			}
		}

		// Token: 0x170021E0 RID: 8672
		// (get) Token: 0x0600421A RID: 16922 RVA: 0x003DB934 File Offset: 0x003D9B34
		public bool RadWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41860_HasDiffs
		{
			get
			{
				short num = (short)1704853504;
				short num2 = num;
				num = (short)340271457;
				short num3 = num;
				num = (short)568205665;
				switch (num3 == num)
				{
				}
				num = (short)297861121;
				if (num != 0)
				{
				}
				num = (short)522518528;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41860._HasDiffs;
			}
		}

		// Token: 0x170021E1 RID: 8673
		// (get) Token: 0x0600421B RID: 16923 RVA: 0x003DB9E4 File Offset: 0x003D9BE4
		// (set) Token: 0x0600421C RID: 16924 RVA: 0x003DBA9C File Offset: 0x003D9C9C
		public int RadWideTransmitPowerLevelsConvTxPowerLevelLowW_A41861Value
		{
			get
			{
				short num = (short)668336128;
				short num2 = num;
				num = (short)180785554;
				short num3 = num;
				num = (short)1463587218;
				switch (num3 == num)
				{
				}
				num = (short)1040908289;
				if (num != 0)
				{
				}
				num = (short)1186070528;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41861.Value;
			}
			set
			{
				short num = (short)1454833664;
				short num2 = num;
				num = (short)1689301584;
				short num3 = num;
				num = (short)965718608;
				switch (num3 == num)
				{
				}
				num = (short)2017067009;
				if (num != 0)
				{
				}
				num = (short)1483472896;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41861.Value = value;
			}
		}

		// Token: 0x170021E2 RID: 8674
		// (get) Token: 0x0600421D RID: 16925 RVA: 0x003DBB54 File Offset: 0x003D9D54
		public global::AcpBusinessLayer.AcpRangeField<int, string> RadWideTransmitPowerLevelsConvTxPowerLevelLowW_A41861
		{
			get
			{
				short num = (short)538116096;
				short num2 = num;
				num = (short)845841261;
				short num3 = num;
				num = (short)1569489773;
				switch (num3 == num)
				{
				}
				num = (short)43319296;
				if (num != 0)
				{
				}
				num = (short)448069633;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41861;
			}
		}

		// Token: 0x170021E3 RID: 8675
		// (get) Token: 0x0600421E RID: 16926 RVA: 0x003DBC04 File Offset: 0x003D9E04
		// (set) Token: 0x0600421F RID: 16927 RVA: 0x003DBCBC File Offset: 0x003D9EBC
		public string RadWideTransmitPowerLevelsConvTxPowerLevelLowW_A41861_UIValue
		{
			get
			{
				short num = (short)24641536;
				short num2 = num;
				num = (short)77047854;
				short num3 = num;
				num = (short)826517550;
				switch (num3 == num)
				{
				}
				num = (short)121503744;
				if (num != 0)
				{
				}
				num = (short)2097086465;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41861.UIValue;
			}
			set
			{
				short num = (short)171704320;
				short num2 = num;
				num = (short)971237846;
				short num3 = num;
				num = (short)279701974;
				switch (num3 == num)
				{
				}
				num = (short)885260289;
				if (num != 0)
				{
				}
				num = (short)2000093184;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41861.UIValue = value;
			}
		}

		// Token: 0x170021E4 RID: 8676
		// (get) Token: 0x06004220 RID: 16928 RVA: 0x003DBD70 File Offset: 0x003D9F70
		// (set) Token: 0x06004221 RID: 16929 RVA: 0x003DBE24 File Offset: 0x003DA024
		internal int RadWideTransmitPowerLevelsConvTxPowerLevelLowW_A41861Min
		{
			get
			{
				short num = (short)1955921920;
				short num2 = num;
				num = (short)767057258;
				short num3 = num;
				num = (short)356539754;
				switch (num3 == num)
				{
				}
				num = (short)1170210817;
				if (num != 0)
				{
				}
				num = (short)632487936;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41861.Min;
			}
			set
			{
				short num = (short)192413696;
				short num2 = num;
				num = (short)224518459;
				short num3 = num;
				num = (short)1844175163;
				switch (num3 == num)
				{
				}
				num = (short)1184497665;
				if (num != 0)
				{
				}
				num = (short)1200226304;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41861.Min = value;
			}
		}

		// Token: 0x170021E5 RID: 8677
		// (get) Token: 0x06004222 RID: 16930 RVA: 0x003DBED8 File Offset: 0x003DA0D8
		// (set) Token: 0x06004223 RID: 16931 RVA: 0x003DBF8C File Offset: 0x003DA18C
		internal int RadWideTransmitPowerLevelsConvTxPowerLevelLowW_A41861Max
		{
			get
			{
				short num = (short)1593311232;
				short num2 = num;
				num = (short)29606182;
				short num3 = num;
				num = (short)2118041894;
				switch (num3 == num)
				{
				}
				num = (short)139460609;
				if (num != 0)
				{
				}
				num = (short)357171200;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41861.Max;
			}
			set
			{
				short num = (short)1191641088;
				short num2 = num;
				num = (short)1742204175;
				short num3 = num;
				num = (short)825748751;
				switch (num3 == num)
				{
				}
				num = (short)1696727040;
				if (num != 0)
				{
				}
				num = (short)1656684545;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41861.Max = value;
			}
		}

		// Token: 0x170021E6 RID: 8678
		// (get) Token: 0x06004224 RID: 16932 RVA: 0x003DC044 File Offset: 0x003DA244
		// (set) Token: 0x06004225 RID: 16933 RVA: 0x003DC0FC File Offset: 0x003DA2FC
		internal int RadWideTransmitPowerLevelsConvTxPowerLevelLowW_A41861Step
		{
			get
			{
				short num = (short)1049821184;
				short num2 = num;
				num = (short)1608468857;
				short num3 = num;
				num = (short)734153081;
				switch (num3 == num)
				{
				}
				num = (short)516882433;
				if (num != 0)
				{
				}
				num = (short)397606912;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41861.StepSize;
			}
			set
			{
				short num = (short)878968832;
				short num2 = num;
				num = (short)1308018682;
				short num3 = num;
				num = (short)1234946042;
				switch (num3 == num)
				{
				}
				num = (short)663945217;
				if (num != 0)
				{
				}
				num = (short)1038417920;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41861.StepSize = value;
			}
		}

		// Token: 0x170021E7 RID: 8679
		// (get) Token: 0x06004226 RID: 16934 RVA: 0x003DC1B8 File Offset: 0x003DA3B8
		// (set) Token: 0x06004227 RID: 16935 RVA: 0x003DC26C File Offset: 0x003DA46C
		public bool RadWideTransmitPowerLevelsConvTxPowerLevelLowW_A41861_Applicable
		{
			get
			{
				short num = (short)293339136;
				short num2 = num;
				num = (short)1287258686;
				short num3 = num;
				num = (short)1522860606;
				switch (num3 == num)
				{
				}
				num = (short)213909504;
				if (num != 0)
				{
				}
				num = (short)107806721;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41861.Applicable;
			}
			set
			{
				short num = (short)1304887296;
				short num2 = num;
				num = (short)1811602912;
				short num3 = num;
				num = (short)1738399200;
				switch (num3 == num)
				{
				}
				num = (short)815202304;
				if (num != 0)
				{
				}
				num = (short)1000603649;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41861.Applicable = value;
			}
		}

		// Token: 0x170021E8 RID: 8680
		// (get) Token: 0x06004228 RID: 16936 RVA: 0x003DC31C File Offset: 0x003DA51C
		// (set) Token: 0x06004229 RID: 16937 RVA: 0x003DC3D0 File Offset: 0x003DA5D0
		public bool RadWideTransmitPowerLevelsConvTxPowerLevelLowW_A41861_Valid
		{
			get
			{
				short num = (short)421658624;
				short num2 = num;
				num = (short)1412638964;
				short num3 = num;
				num = (short)66922740;
				switch (num3 == num)
				{
				}
				num = (short)941686785;
				if (num != 0)
				{
				}
				num = (short)115736576;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41861.Valid;
			}
			set
			{
				short num = (short)294518784;
				short num2 = num;
				num = (short)1721583351;
				short num3 = num;
				num = (short)128599799;
				switch (num3 == num)
				{
				}
				num = (short)333316097;
				if (num != 0)
				{
				}
				num = (short)464977920;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41861.Valid = value;
			}
		}

		// Token: 0x170021E9 RID: 8681
		// (get) Token: 0x0600422A RID: 16938 RVA: 0x003DC488 File Offset: 0x003DA688
		// (set) Token: 0x0600422B RID: 16939 RVA: 0x003DC53C File Offset: 0x003DA73C
		public bool RadWideTransmitPowerLevelsConvTxPowerLevelLowW_A41861_Visible
		{
			get
			{
				short num = (short)1170145280;
				short num2 = num;
				num = (short)638013320;
				short num3 = num;
				num = (short)858935176;
				switch (num3 == num)
				{
				}
				num = (short)303431681;
				if (num != 0)
				{
				}
				num = (short)1440088064;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41861.Visible;
			}
			set
			{
				short num = (short)1828061184;
				short num2 = num;
				num = (short)226493970;
				short num3 = num;
				num = (short)1151206930;
				switch (num3 == num)
				{
				}
				num = (short)595525632;
				if (num != 0)
				{
				}
				num = (short)667680769;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41861.Visible = value;
			}
		}

		// Token: 0x170021EA RID: 8682
		// (get) Token: 0x0600422C RID: 16940 RVA: 0x003DC5F0 File Offset: 0x003DA7F0
		// (set) Token: 0x0600422D RID: 16941 RVA: 0x003DC6A4 File Offset: 0x003DA8A4
		public bool RadWideTransmitPowerLevelsConvTxPowerLevelLowW_A41861_Editable
		{
			get
			{
				short num = (short)1989279744;
				short num2 = num;
				num = (short)1267349163;
				short num3 = num;
				num = (short)1971664555;
				switch (num3 == num)
				{
				}
				num = (short)395247617;
				if (num != 0)
				{
				}
				num = (short)1741225984;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41861.Editable;
			}
			set
			{
				short num = (short)2002714624;
				short num2 = num;
				num = (short)581069474;
				short num3 = num;
				num = (short)648964770;
				switch (num3 == num)
				{
				}
				num = (short)823918593;
				if (num != 0)
				{
				}
				num = (short)1794965504;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41861.Editable = value;
			}
		}

		// Token: 0x170021EB RID: 8683
		// (get) Token: 0x0600422E RID: 16942 RVA: 0x003DC758 File Offset: 0x003DA958
		internal string RadWideTransmitPowerLevelsConvTxPowerLevelLowW_A41861_UILabel
		{
			get
			{
				short num = (short)2019164160;
				short num2 = num;
				num = (short)1641086977;
				if (num != 0)
				{
				}
				num = (short)1393878339;
				short num3 = num;
				num = (short)775677251;
				switch (num3 == num)
				{
				}
				num = (short)768802816;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41861.UIName;
			}
		}

		// Token: 0x170021EC RID: 8684
		// (get) Token: 0x0600422F RID: 16943 RVA: 0x003DC80C File Offset: 0x003DAA0C
		// (set) Token: 0x06004230 RID: 16944 RVA: 0x003DC8C0 File Offset: 0x003DAAC0
		internal bool RadWideTransmitPowerLevelsConvTxPowerLevelLowW_A41861_HiddenStatic
		{
			get
			{
				short num = (short)669843456;
				short num2 = num;
				num = (short)1457983830;
				short num3 = num;
				num = (short)1288245590;
				switch (num3 == num)
				{
				}
				num = (short)1504641025;
				if (num != 0)
				{
				}
				num = (short)1240006656;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41861.HiddenStatic;
			}
			set
			{
				short num = (short)794951680;
				short num2 = num;
				num = (short)1030873716;
				short num3 = num;
				num = (short)1331618420;
				switch (num3 == num)
				{
				}
				num = (short)1821900800;
				if (num != 0)
				{
				}
				num = (short)708575233;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41861.HiddenStatic = value;
			}
		}

		// Token: 0x170021ED RID: 8685
		// (get) Token: 0x06004231 RID: 16945 RVA: 0x003DC974 File Offset: 0x003DAB74
		// (set) Token: 0x06004232 RID: 16946 RVA: 0x003DCA28 File Offset: 0x003DAC28
		internal bool RadWideTransmitPowerLevelsConvTxPowerLevelLowW_A41861_HiddenDynamic
		{
			get
			{
				short num = (short)578158592;
				short num2 = num;
				num = (short)16384001;
				if (num != 0)
				{
				}
				num = (short)778278211;
				short num3 = num;
				num = (short)1868141891;
				switch (num3 == num)
				{
				}
				num = (short)384499712;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41861.HiddenDynamic;
			}
			set
			{
				short num = (short)1256914944;
				short num2 = num;
				num = (short)258772108;
				short num3 = num;
				num = (short)1271368844;
				switch (num3 == num)
				{
				}
				num = (short)242483201;
				if (num != 0)
				{
				}
				num = (short)370671616;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41861.HiddenDynamic = value;
			}
		}

		// Token: 0x170021EE RID: 8686
		// (get) Token: 0x06004233 RID: 16947 RVA: 0x003DCADC File Offset: 0x003DACDC
		public bool RadWideTransmitPowerLevelsConvTxPowerLevelLowW_A41861_HasDiffs
		{
			get
			{
				short num = (short)593625088;
				short num2 = num;
				num = (short)2062238378;
				short num3 = num;
				num = (short)652493482;
				switch (num3 == num)
				{
				}
				num = (short)1808531456;
				if (num != 0)
				{
				}
				num = (short)1873543169;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41861._HasDiffs;
			}
		}

		// Token: 0x170021EF RID: 8687
		// (get) Token: 0x06004234 RID: 16948 RVA: 0x003DCB94 File Offset: 0x003DAD94
		// (set) Token: 0x06004235 RID: 16949 RVA: 0x003DCC48 File Offset: 0x003DAE48
		public int RadWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41862Value
		{
			get
			{
				short num = (short)723845120;
				short num2 = num;
				num = (short)2096037889;
				if (num != 0)
				{
				}
				num = (short)1915730525;
				short num3 = num;
				num = (short)2097199709;
				switch (num3 == num)
				{
				}
				num = (short)1335951360;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41862.Value;
			}
			set
			{
				short num = (short)149159936;
				short num2 = num;
				num = (short)179505449;
				short num3 = num;
				num = (short)56953129;
				switch (num3 == num)
				{
				}
				num = (short)1828257793;
				if (num != 0)
				{
				}
				num = (short)1597308928;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41862.Value = value;
			}
		}

		// Token: 0x170021F0 RID: 8688
		// (get) Token: 0x06004236 RID: 16950 RVA: 0x003DCD00 File Offset: 0x003DAF00
		public global::AcpBusinessLayer.AcpRangeField<int, string> RadWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41862
		{
			get
			{
				short num = (short)1271988224;
				short num2 = num;
				num = (short)507386348;
				short num3 = num;
				num = (short)1639717356;
				switch (num3 == num)
				{
				}
				num = (short)458293249;
				if (num != 0)
				{
				}
				num = (short)1781399552;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41862;
			}
		}

		// Token: 0x170021F1 RID: 8689
		// (get) Token: 0x06004237 RID: 16951 RVA: 0x003DCDB0 File Offset: 0x003DAFB0
		// (set) Token: 0x06004238 RID: 16952 RVA: 0x003DCE60 File Offset: 0x003DB060
		public string RadWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41862_UIValue
		{
			get
			{
				short num = (short)652345344;
				short num2 = num;
				num = (short)2003967144;
				short num3 = num;
				num = (short)1994792104;
				switch (num3 == num)
				{
				}
				num = (short)1919025152;
				if (num != 0)
				{
				}
				num = (short)1108410369;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41862.UIValue;
			}
			set
			{
				short num = (short)1778581504;
				short num2 = num;
				num = (short)1792738934;
				short num3 = num;
				num = (short)1276446326;
				switch (num3 == num)
				{
				}
				num = (short)1607991297;
				if (num != 0)
				{
				}
				num = (short)818216960;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41862.UIValue = value;
			}
		}

		// Token: 0x170021F2 RID: 8690
		// (get) Token: 0x06004239 RID: 16953 RVA: 0x003DCF14 File Offset: 0x003DB114
		// (set) Token: 0x0600423A RID: 16954 RVA: 0x003DCFCC File Offset: 0x003DB1CC
		internal int RadWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41862Min
		{
			get
			{
				short num = (short)121962496;
				short num2 = num;
				num = (short)94830593;
				if (num != 0)
				{
				}
				num = (short)2145056257;
				short num3 = num;
				num = (short)1028388353;
				switch (num3 == num)
				{
				}
				num = (short)664928256;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41862.Min;
			}
			set
			{
				short num = (short)778436608;
				short num2 = num;
				num = (short)191037441;
				if (num != 0)
				{
				}
				num = (short)644625653;
				short num3 = num;
				num = (short)1988048117;
				switch (num3 == num)
				{
				}
				num = (short)1638268928;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41862.Min = value;
			}
		}

		// Token: 0x170021F3 RID: 8691
		// (get) Token: 0x0600423B RID: 16955 RVA: 0x003DD080 File Offset: 0x003DB280
		// (set) Token: 0x0600423C RID: 16956 RVA: 0x003DD134 File Offset: 0x003DB334
		internal int RadWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41862Max
		{
			get
			{
				short num = (short)142344192;
				short num2 = num;
				num = (short)608995343;
				short num3 = num;
				num = (short)1438484495;
				switch (num3 == num)
				{
				}
				num = (short)401145857;
				if (num != 0)
				{
				}
				num = (short)560726016;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41862.Max;
			}
			set
			{
				short num = (short)1640366080;
				short num2 = num;
				num = (short)81774955;
				short num3 = num;
				num = (short)913099115;
				switch (num3 == num)
				{
				}
				num = (short)1842085888;
				if (num != 0)
				{
				}
				num = (short)1042284545;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41862.Max = value;
			}
		}

		// Token: 0x170021F4 RID: 8692
		// (get) Token: 0x0600423D RID: 16957 RVA: 0x003DD1EC File Offset: 0x003DB3EC
		// (set) Token: 0x0600423E RID: 16958 RVA: 0x003DD2A0 File Offset: 0x003DB4A0
		internal int RadWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41862Step
		{
			get
			{
				short num = (short)872349696;
				short num2 = num;
				num = (short)672937101;
				short num3 = num;
				num = (short)299709581;
				switch (num3 == num)
				{
				}
				num = (short)2066743297;
				if (num != 0)
				{
				}
				num = (short)966066176;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41862.StepSize;
			}
			set
			{
				short num = (short)1598881792;
				short num2 = num;
				num = (short)1554533796;
				short num3 = num;
				num = (short)613174692;
				switch (num3 == num)
				{
				}
				num = (short)829161472;
				if (num != 0)
				{
				}
				num = (short)565510145;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41862.StepSize = value;
			}
		}

		// Token: 0x170021F5 RID: 8693
		// (get) Token: 0x0600423F RID: 16959 RVA: 0x003DD358 File Offset: 0x003DB558
		// (set) Token: 0x06004240 RID: 16960 RVA: 0x003DD40C File Offset: 0x003DB60C
		public bool RadWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41862_Applicable
		{
			get
			{
				short num = (short)523370496;
				short num2 = num;
				num = (short)1126607934;
				short num3 = num;
				num = (short)1537780798;
				switch (num3 == num)
				{
				}
				num = (short)146800641;
				if (num != 0)
				{
				}
				num = (short)540475392;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41862.Applicable;
			}
			set
			{
				short num = (short)2071789568;
				short num2 = num;
				num = (short)2127323502;
				short num3 = num;
				num = (short)917987694;
				switch (num3 == num)
				{
				}
				num = (short)1492385792;
				if (num != 0)
				{
				}
				num = (short)81002497;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41862.Applicable = value;
			}
		}

		// Token: 0x170021F6 RID: 8694
		// (get) Token: 0x06004241 RID: 16961 RVA: 0x003DD4C4 File Offset: 0x003DB6C4
		// (set) Token: 0x06004242 RID: 16962 RVA: 0x003DD57C File Offset: 0x003DB77C
		public bool RadWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41862_Valid
		{
			get
			{
				short num = (short)1183645696;
				short num2 = num;
				num = (short)422579761;
				short num3 = num;
				num = (short)778505777;
				switch (num3 == num)
				{
				}
				num = (short)745340928;
				if (num != 0)
				{
				}
				num = (short)909574145;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41862.Valid;
			}
			set
			{
				short num = (short)1612775424;
				short num2 = num;
				num = (short)627922167;
				short num3 = num;
				num = (short)764302583;
				switch (num3 == num)
				{
				}
				num = (short)1013317633;
				if (num != 0)
				{
				}
				num = (short)119472128;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41862.Valid = value;
			}
		}

		// Token: 0x170021F7 RID: 8695
		// (get) Token: 0x06004243 RID: 16963 RVA: 0x003DD630 File Offset: 0x003DB830
		// (set) Token: 0x06004244 RID: 16964 RVA: 0x003DD6E4 File Offset: 0x003DB8E4
		public bool RadWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41862_Visible
		{
			get
			{
				short num = (short)503119872;
				short num2 = num;
				num = (short)532461683;
				short num3 = num;
				num = (short)83802227;
				switch (num3 == num)
				{
				}
				num = (short)1118830593;
				if (num != 0)
				{
				}
				num = (short)1526464512;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41862.Visible;
			}
			set
			{
				short num = (short)1446576128;
				short num2 = num;
				num = (short)763547150;
				short num3 = num;
				num = (short)225955342;
				switch (num3 == num)
				{
				}
				num = (short)1406337024;
				if (num != 0)
				{
				}
				num = (short)1441988609;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41862.Visible = value;
			}
		}

		// Token: 0x170021F8 RID: 8696
		// (get) Token: 0x06004245 RID: 16965 RVA: 0x003DD79C File Offset: 0x003DB99C
		// (set) Token: 0x06004246 RID: 16966 RVA: 0x003DD850 File Offset: 0x003DBA50
		public bool RadWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41862_Editable
		{
			get
			{
				short num = (short)966066176;
				short num2 = num;
				num = (short)905485456;
				short num3 = num;
				num = (short)901815440;
				switch (num3 == num)
				{
				}
				num = (short)1539309568;
				if (num != 0)
				{
				}
				num = (short)1567162369;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41862.Editable;
			}
			set
			{
				short num = (short)226240780;
				short num2 = num;
				num = (short)1397238028;
				switch (num2 == num)
				{
				}
				num = (short)1842806784;
				if (num != 0)
				{
				}
				num = (short)1534197761;
				if (num != 0)
				{
				}
				num = (short)815464448;
				short num3 = num;
				this.radWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41862.Editable = value;
			}
		}

		// Token: 0x170021F9 RID: 8697
		// (get) Token: 0x06004247 RID: 16967 RVA: 0x003DD904 File Offset: 0x003DBB04
		internal string RadWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41862_UILabel
		{
			get
			{
				short num = (short)1120510286;
				short num2 = num;
				num = (short)90808654;
				switch (num2 == num)
				{
				}
				num = (short)1116733440;
				if (num != 0)
				{
				}
				num = (short)127533057;
				if (num != 0)
				{
				}
				num = (short)2033385472;
				short num3 = num;
				return this.radWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41862.UIName;
			}
		}

		// Token: 0x170021FA RID: 8698
		// (get) Token: 0x06004248 RID: 16968 RVA: 0x003DD9B8 File Offset: 0x003DBBB8
		// (set) Token: 0x06004249 RID: 16969 RVA: 0x003DDA6C File Offset: 0x003DBC6C
		internal bool RadWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41862_HiddenStatic
		{
			get
			{
				short num = (short)1268776961;
				if (num != 0)
				{
				}
				num = (short)1333474120;
				short num2 = num;
				num = (short)1640182600;
				switch (num2 == num)
				{
				}
				num = (short)559022080;
				if (num != 0)
				{
				}
				num = (short)1014431744;
				short num3 = num;
				return this.radWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41862.HiddenStatic;
			}
			set
			{
				short num = (short)1756094891;
				short num2 = num;
				num = (short)1668604331;
				switch (num2 == num)
				{
				}
				num = (short)194576384;
				if (num != 0)
				{
				}
				num = (short)114098177;
				if (num != 0)
				{
				}
				num = (short)2056388608;
				short num3 = num;
				this.radWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41862.HiddenStatic = value;
			}
		}

		// Token: 0x170021FB RID: 8699
		// (get) Token: 0x0600424A RID: 16970 RVA: 0x003DDB20 File Offset: 0x003DBD20
		// (set) Token: 0x0600424B RID: 16971 RVA: 0x003DDBD4 File Offset: 0x003DBDD4
		internal bool RadWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41862_HiddenDynamic
		{
			get
			{
				short num = (short)1749803196;
				short num2 = num;
				num = (short)1646387388;
				switch (num2 == num)
				{
				}
				num = (short)2052849664;
				if (num != 0)
				{
				}
				num = (short)1285423105;
				if (num != 0)
				{
				}
				num = (short)1677262848;
				short num3 = num;
				return this.radWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41862.HiddenDynamic;
			}
			set
			{
				short num = (short)1468739594;
				short num2 = num;
				num = (short)340471818;
				switch (num2 == num)
				{
				}
				num = (short)1019674625;
				if (num != 0)
				{
				}
				num = (short)319291392;
				if (num != 0)
				{
				}
				num = (short)1987969024;
				short num3 = num;
				this.radWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41862.HiddenDynamic = value;
			}
		}

		// Token: 0x170021FC RID: 8700
		// (get) Token: 0x0600424C RID: 16972 RVA: 0x003DDC8C File Offset: 0x003DBE8C
		public bool RadWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41862_HasDiffs
		{
			get
			{
				short num = (short)957546497;
				if (num != 0)
				{
				}
				num = (short)1981689252;
				short num2 = num;
				num = (short)895430052;
				switch (num2 == num)
				{
				}
				num = (short)768868352;
				if (num != 0)
				{
				}
				num = (short)1650655232;
				short num3 = num;
				return this.radWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41862._HasDiffs;
			}
		}

		// Token: 0x170021FD RID: 8701
		// (get) Token: 0x0600424D RID: 16973 RVA: 0x003DDD44 File Offset: 0x003DBF44
		// (set) Token: 0x0600424E RID: 16974 RVA: 0x003DDDFC File Offset: 0x003DBFFC
		public int RadWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41863Value
		{
			get
			{
				short num = (short)1926889473;
				if (num != 0)
				{
				}
				num = (short)2021323066;
				short num2 = num;
				num = (short)1437462842;
				switch (num2 == num)
				{
				}
				num = (short)1387069440;
				if (num != 0)
				{
				}
				num = (short)1680408576;
				short num3 = num;
				return this.radWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41863.Value;
			}
			set
			{
				short num = (short)91357185;
				if (num != 0)
				{
				}
				num = (short)576149732;
				short num2 = num;
				num = (short)1239374052;
				switch (num2 == num)
				{
				}
				num = (short)869007360;
				if (num != 0)
				{
				}
				num = (short)1846542336;
				short num3 = num;
				this.radWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41863.Value = value;
			}
		}

		// Token: 0x170021FE RID: 8702
		// (get) Token: 0x0600424F RID: 16975 RVA: 0x003DDEB0 File Offset: 0x003DC0B0
		public global::AcpBusinessLayer.AcpRangeField<int, string> RadWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41863
		{
			get
			{
				short num = (short)2014496538;
				short num2 = num;
				num = (short)618252058;
				switch (num2 == num)
				{
				}
				num = (short)663748609;
				if (num != 0)
				{
				}
				num = (short)2000093184;
				if (num != 0)
				{
				}
				num = (short)725745664;
				short num3 = num;
				return this.radWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41863;
			}
		}

		// Token: 0x170021FF RID: 8703
		// (get) Token: 0x06004250 RID: 16976 RVA: 0x003DDF60 File Offset: 0x003DC160
		// (set) Token: 0x06004251 RID: 16977 RVA: 0x003DE014 File Offset: 0x003DC214
		public string RadWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41863_UIValue
		{
			get
			{
				short num = (short)928884817;
				short num2 = num;
				num = (short)1169991761;
				switch (num2 == num)
				{
				}
				num = (short)745472001;
				if (num != 0)
				{
				}
				num = (short)100532224;
				if (num != 0)
				{
				}
				num = (short)1757675520;
				short num3 = num;
				return this.radWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41863.UIValue;
			}
			set
			{
				short num = (short)830865409;
				if (num != 0)
				{
				}
				num = (short)79958026;
				short num2 = num;
				num = (short)1722617866;
				switch (num2 == num)
				{
				}
				num = (short)1415446528;
				if (num != 0)
				{
				}
				num = (short)1127940096;
				short num3 = num;
				this.radWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41863.UIValue = value;
			}
		}

		// Token: 0x17002200 RID: 8704
		// (get) Token: 0x06004252 RID: 16978 RVA: 0x003DE0C8 File Offset: 0x003DC2C8
		// (set) Token: 0x06004253 RID: 16979 RVA: 0x003DE17C File Offset: 0x003DC37C
		internal int RadWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41863Min
		{
			get
			{
				short num = (short)706850590;
				short num2 = num;
				num = (short)363441950;
				switch (num2 == num)
				{
				}
				num = (short)1808138241;
				if (num != 0)
				{
				}
				num = (short)1502150656;
				if (num != 0)
				{
				}
				num = (short)1657536512;
				short num3 = num;
				return this.radWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41863.Min;
			}
			set
			{
				short num = (short)1304829196;
				short num2 = num;
				num = (short)527375628;
				switch (num2 == num)
				{
				}
				num = (short)875626497;
				if (num != 0)
				{
				}
				num = (short)1633484800;
				if (num != 0)
				{
				}
				num = (short)508231680;
				short num3 = num;
				this.radWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41863.Min = value;
			}
		}

		// Token: 0x17002201 RID: 8705
		// (get) Token: 0x06004254 RID: 16980 RVA: 0x003DE234 File Offset: 0x003DC434
		// (set) Token: 0x06004255 RID: 16981 RVA: 0x003DE2E8 File Offset: 0x003DC4E8
		internal int RadWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41863Max
		{
			get
			{
				short num = (short)1417279200;
				short num2 = num;
				num = (short)1730606816;
				switch (num2 == num)
				{
				}
				num = (short)55640065;
				if (num != 0)
				{
				}
				num = (short)76677120;
				if (num != 0)
				{
				}
				num = (short)2026962944;
				short num3 = num;
				return this.radWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41863.Max;
			}
			set
			{
				short num = (short)646735236;
				short num2 = num;
				num = (short)529491332;
				switch (num2 == num)
				{
				}
				num = (short)1963851776;
				if (num != 0)
				{
				}
				num = (short)1987706881;
				if (num != 0)
				{
				}
				num = (short)1926430720;
				short num3 = num;
				this.radWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41863.Max = value;
			}
		}

		// Token: 0x17002202 RID: 8706
		// (get) Token: 0x06004256 RID: 16982 RVA: 0x003DE39C File Offset: 0x003DC59C
		// (set) Token: 0x06004257 RID: 16983 RVA: 0x003DE450 File Offset: 0x003DC650
		internal int RadWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41863Step
		{
			get
			{
				short num = (short)1479618425;
				short num2 = num;
				num = (short)1811754873;
				switch (num2 == num)
				{
				}
				num = (short)1907359745;
				if (num != 0)
				{
				}
				num = (short)1976172544;
				if (num != 0)
				{
				}
				num = (short)853278720;
				short num3 = num;
				return this.radWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41863.StepSize;
			}
			set
			{
				short num = (short)414908417;
				if (num != 0)
				{
				}
				num = (short)1246909504;
				short num2 = num;
				num = (short)747525184;
				switch (num2 == num)
				{
				}
				num = (short)1455489024;
				if (num != 0)
				{
				}
				num = (short)1976762368;
				short num3 = num;
				this.radWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41863.StepSize = value;
			}
		}

		// Token: 0x17002203 RID: 8707
		// (get) Token: 0x06004258 RID: 16984 RVA: 0x003DE508 File Offset: 0x003DC708
		// (set) Token: 0x06004259 RID: 16985 RVA: 0x003DE5BC File Offset: 0x003DC7BC
		public bool RadWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41863_Applicable
		{
			get
			{
				short num = (short)23447375;
				short num2 = num;
				num = (short)431474511;
				switch (num2 == num)
				{
				}
				num = (short)1759510529;
				if (num != 0)
				{
				}
				num = (short)1613234176;
				if (num != 0)
				{
				}
				num = (short)1415708672;
				short num3 = num;
				return this.radWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41863.Applicable;
			}
			set
			{
				short num = (short)1732813950;
				short num2 = num;
				num = (short)1960813694;
				switch (num2 == num)
				{
				}
				num = (short)2001600512;
				if (num != 0)
				{
				}
				num = (short)477102081;
				if (num != 0)
				{
				}
				num = (short)1177878528;
				short num3 = num;
				this.radWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41863.Applicable = value;
			}
		}

		// Token: 0x17002204 RID: 8708
		// (get) Token: 0x0600425A RID: 16986 RVA: 0x003DE670 File Offset: 0x003DC870
		// (set) Token: 0x0600425B RID: 16987 RVA: 0x003DE720 File Offset: 0x003DC920
		public bool RadWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41863_Valid
		{
			get
			{
				short num = (short)1382475417;
				short num2 = num;
				num = (short)550626969;
				switch (num2 == num)
				{
				}
				num = (short)1564147713;
				if (num != 0)
				{
				}
				num = (short)1655898112;
				if (num != 0)
				{
				}
				num = (short)1860698112;
				short num3 = num;
				return this.radWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41863.Valid;
			}
			set
			{
				short num = (short)544559991;
				short num2 = num;
				num = (short)379147127;
				switch (num2 == num)
				{
				}
				num = (short)1391919105;
				if (num != 0)
				{
				}
				num = (short)994770944;
				if (num != 0)
				{
				}
				num = (short)1426325504;
				short num3 = num;
				this.radWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41863.Valid = value;
			}
		}

		// Token: 0x17002205 RID: 8709
		// (get) Token: 0x0600425C RID: 16988 RVA: 0x003DE7D8 File Offset: 0x003DC9D8
		// (set) Token: 0x0600425D RID: 16989 RVA: 0x003DE890 File Offset: 0x003DCA90
		public bool RadWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41863_Visible
		{
			get
			{
				short num = (short)1615106821;
				short num2 = num;
				num = (short)1410044677;
				switch (num2 == num)
				{
				}
				num = (short)1308950529;
				if (num != 0)
				{
				}
				num = (short)1153695744;
				if (num != 0)
				{
				}
				num = (short)847773696;
				short num3 = num;
				return this.radWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41863.Visible;
			}
			set
			{
				short num = (short)1706129967;
				short num2 = num;
				num = (short)1454078511;
				switch (num2 == num)
				{
				}
				num = (short)76087296;
				if (num != 0)
				{
				}
				num = (short)1464008705;
				if (num != 0)
				{
				}
				num = (short)2134507520;
				short num3 = num;
				this.radWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41863.Visible = value;
			}
		}

		// Token: 0x17002206 RID: 8710
		// (get) Token: 0x0600425E RID: 16990 RVA: 0x003DE944 File Offset: 0x003DCB44
		// (set) Token: 0x0600425F RID: 16991 RVA: 0x003DE9F8 File Offset: 0x003DCBF8
		public bool RadWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41863_Editable
		{
			get
			{
				short num = (short)338564212;
				short num2 = num;
				num = (short)294982772;
				switch (num2 == num)
				{
				}
				num = (short)734265344;
				if (num != 0)
				{
				}
				num = (short)1530462209;
				if (num != 0)
				{
				}
				num = (short)1960837120;
				short num3 = num;
				return this.radWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41863.Editable;
			}
			set
			{
				short num = (short)288486503;
				short num2 = num;
				num = (short)1021375591;
				switch (num2 == num)
				{
				}
				num = (short)491126784;
				if (num != 0)
				{
				}
				num = (short)80084993;
				if (num != 0)
				{
				}
				num = (short)12124160;
				short num3 = num;
				this.radWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41863.Editable = value;
			}
		}

		// Token: 0x17002207 RID: 8711
		// (get) Token: 0x06004260 RID: 16992 RVA: 0x003DEAB0 File Offset: 0x003DCCB0
		internal string RadWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41863_UILabel
		{
			get
			{
				short num = (short)2067724626;
				short num2 = num;
				num = (short)1807546706;
				switch (num2 == num)
				{
				}
				num = (short)537460737;
				if (num != 0)
				{
				}
				num = (short)972619776;
				if (num != 0)
				{
				}
				num = (short)1559166976;
				short num3 = num;
				return this.radWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41863.UIName;
			}
		}

		// Token: 0x17002208 RID: 8712
		// (get) Token: 0x06004261 RID: 16993 RVA: 0x003DEB64 File Offset: 0x003DCD64
		// (set) Token: 0x06004262 RID: 16994 RVA: 0x003DEC18 File Offset: 0x003DCE18
		internal bool RadWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41863_HiddenStatic
		{
			get
			{
				short num = (short)1625334602;
				short num2 = num;
				num = (short)1497932618;
				switch (num2 == num)
				{
				}
				num = (short)2025390081;
				if (num != 0)
				{
				}
				num = (short)1744437248;
				if (num != 0)
				{
				}
				num = (short)1364656128;
				short num3 = num;
				return this.radWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41863.HiddenStatic;
			}
			set
			{
				short num = (short)2147329187;
				short num2 = num;
				num = (short)178562211;
				switch (num2 == num)
				{
				}
				num = (short)638582785;
				if (num != 0)
				{
				}
				num = (short)750256128;
				if (num != 0)
				{
				}
				num = (short)988086272;
				short num3 = num;
				this.radWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41863.HiddenStatic = value;
			}
		}

		// Token: 0x17002209 RID: 8713
		// (get) Token: 0x06004263 RID: 16995 RVA: 0x003DECD0 File Offset: 0x003DCED0
		// (set) Token: 0x06004264 RID: 16996 RVA: 0x003DED88 File Offset: 0x003DCF88
		internal bool RadWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41863_HiddenDynamic
		{
			get
			{
				short num = (short)305408121;
				short num2 = num;
				num = (short)840837241;
				switch (num2 == num)
				{
				}
				num = (short)1072693249;
				if (num != 0)
				{
				}
				num = (short)1799618560;
				if (num != 0)
				{
				}
				num = (short)1892745216;
				short num3 = num;
				return this.radWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41863.HiddenDynamic;
			}
			set
			{
				short num = (short)68097450;
				short num2 = num;
				num = (short)100144554;
				switch (num2 == num)
				{
				}
				num = (short)2020081664;
				if (num != 0)
				{
				}
				num = (short)1510670337;
				if (num != 0)
				{
				}
				num = (short)805961728;
				short num3 = num;
				this.radWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41863.HiddenDynamic = value;
			}
		}

		// Token: 0x1700220A RID: 8714
		// (get) Token: 0x06004265 RID: 16997 RVA: 0x003DEE40 File Offset: 0x003DD040
		public bool RadWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41863_HasDiffs
		{
			get
			{
				short num = (short)1535454415;
				short num2 = num;
				num = (short)1437740239;
				switch (num2 == num)
				{
				}
				num = (short)2114584576;
				if (num != 0)
				{
				}
				num = (short)290783233;
				if (num != 0)
				{
				}
				num = (short)1283850240;
				short num3 = num;
				return this.radWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41863._HasDiffs;
			}
		}

		// Token: 0x1700220B RID: 8715
		// (get) Token: 0x06004266 RID: 16998 RVA: 0x003DEEF8 File Offset: 0x003DD0F8
		// (set) Token: 0x06004267 RID: 16999 RVA: 0x003DEFAC File Offset: 0x003DD1AC
		public string RadWidePowerLevelBandFrequency_A41864Value
		{
			get
			{
				short num = (short)1481130824;
				short num2 = num;
				num = (short)1340162888;
				switch (num2 == num)
				{
				}
				num = (short)302972929;
				if (num != 0)
				{
				}
				num = (short)1593507840;
				if (num != 0)
				{
				}
				num = (short)2126774272;
				short num3 = num;
				return this.radWidePowerLevelBandFrequency_A41864.Value;
			}
			set
			{
				short num = (short)1080903139;
				short num2 = num;
				num = (short)119752163;
				switch (num2 == num)
				{
				}
				num = (short)338886656;
				if (num != 0)
				{
				}
				num = (short)1248133121;
				if (num != 0)
				{
				}
				num = (short)459735040;
				short num3 = num;
				this.radWidePowerLevelBandFrequency_A41864.Value = value;
			}
		}

		// Token: 0x1700220C RID: 8716
		// (get) Token: 0x06004268 RID: 17000 RVA: 0x003DF060 File Offset: 0x003DD260
		public global::AcpBusinessLayer.AcpField<string> RadWidePowerLevelBandFrequency_A41864
		{
			get
			{
				short num = (short)2125201409;
				if (num != 0)
				{
				}
				num = (short)1805544502;
				short num2 = num;
				num = (short)1326345270;
				switch (num2 == num)
				{
				}
				num = (short)816316416;
				if (num != 0)
				{
				}
				num = (short)1638596608;
				short num3 = num;
				return this.radWidePowerLevelBandFrequency_A41864;
			}
		}

		// Token: 0x1700220D RID: 8717
		// (get) Token: 0x06004269 RID: 17001 RVA: 0x003DF110 File Offset: 0x003DD310
		// (set) Token: 0x0600426A RID: 17002 RVA: 0x003DF1C4 File Offset: 0x003DD3C4
		public string RadWidePowerLevelBandFrequency_A41864_UIValue
		{
			get
			{
				short num = (short)1722673982;
				short num2 = num;
				num = (short)106752830;
				switch (num2 == num)
				{
				}
				num = (short)72744960;
				if (num != 0)
				{
				}
				num = (short)1436614657;
				if (num != 0)
				{
				}
				num = (short)203227136;
				short num3 = num;
				return this.radWidePowerLevelBandFrequency_A41864.Value;
			}
			set
			{
				short num = (short)1713835874;
				short num2 = num;
				num = (short)1987514210;
				switch (num2 == num)
				{
				}
				num = (short)1958608896;
				if (num != 0)
				{
				}
				num = (short)167903233;
				if (num != 0)
				{
				}
				num = (short)619380736;
				short num3 = num;
				this.radWidePowerLevelBandFrequency_A41864.Value = value;
			}
		}

		// Token: 0x1700220E RID: 8718
		// (get) Token: 0x0600426B RID: 17003 RVA: 0x003DF278 File Offset: 0x003DD478
		// (set) Token: 0x0600426C RID: 17004 RVA: 0x003DF32C File Offset: 0x003DD52C
		public bool RadWidePowerLevelBandFrequency_A41864_Applicable
		{
			get
			{
				short num = (short)1406195889;
				short num2 = num;
				num = (short)811391153;
				switch (num2 == num)
				{
				}
				num = (short)1878458369;
				if (num != 0)
				{
				}
				num = (short)833683456;
				if (num != 0)
				{
				}
				num = (short)550633472;
				short num3 = num;
				return this.radWidePowerLevelBandFrequency_A41864.Applicable;
			}
			set
			{
				short num = (short)1553279085;
				short num2 = num;
				num = (short)664741997;
				switch (num2 == num)
				{
				}
				num = (short)189988864;
				if (num != 0)
				{
				}
				num = (short)1821966337;
				if (num != 0)
				{
				}
				num = (short)405078016;
				short num3 = num;
				this.radWidePowerLevelBandFrequency_A41864.Applicable = value;
			}
		}

		// Token: 0x1700220F RID: 8719
		// (get) Token: 0x0600426D RID: 17005 RVA: 0x003DF3E4 File Offset: 0x003DD5E4
		// (set) Token: 0x0600426E RID: 17006 RVA: 0x003DF49C File Offset: 0x003DD69C
		public bool RadWidePowerLevelBandFrequency_A41864_Valid
		{
			get
			{
				short num = (short)2039146977;
				short num2 = num;
				num = (short)1206774241;
				switch (num2 == num)
				{
				}
				num = (short)541261824;
				if (num != 0)
				{
				}
				num = (short)1643380737;
				if (num != 0)
				{
				}
				num = (short)1192755200;
				short num3 = num;
				return this.radWidePowerLevelBandFrequency_A41864.Valid;
			}
			set
			{
				short num = (short)879030019;
				short num2 = num;
				num = (short)1522134787;
				switch (num2 == num)
				{
				}
				num = (short)1688076288;
				if (num != 0)
				{
				}
				num = (short)649854977;
				if (num != 0)
				{
				}
				num = (short)691601408;
				short num3 = num;
				this.radWidePowerLevelBandFrequency_A41864.Valid = value;
			}
		}

		// Token: 0x17002210 RID: 8720
		// (get) Token: 0x0600426F RID: 17007 RVA: 0x003DF550 File Offset: 0x003DD750
		// (set) Token: 0x06004270 RID: 17008 RVA: 0x003DF608 File Offset: 0x003DD808
		public bool RadWidePowerLevelBandFrequency_A41864_Visible
		{
			get
			{
				short num = (short)1201214779;
				short num2 = num;
				num = (short)1032852795;
				switch (num2 == num)
				{
				}
				num = (short)1753677825;
				if (num != 0)
				{
				}
				num = (short)382468096;
				if (num != 0)
				{
				}
				num = (short)162004992;
				short num3 = num;
				return this.radWidePowerLevelBandFrequency_A41864.Visible;
			}
			set
			{
				short num = (short)2064908289;
				if (num != 0)
				{
				}
				num = (short)453090589;
				short num2 = num;
				num = (short)1030462749;
				switch (num2 == num)
				{
				}
				num = (short)1533870080;
				if (num != 0)
				{
				}
				num = (short)569114624;
				short num3 = num;
				this.radWidePowerLevelBandFrequency_A41864.Visible = value;
			}
		}

		// Token: 0x17002211 RID: 8721
		// (get) Token: 0x06004271 RID: 17009 RVA: 0x003DF6BC File Offset: 0x003DD8BC
		// (set) Token: 0x06004272 RID: 17010 RVA: 0x003DF774 File Offset: 0x003DD974
		public bool RadWidePowerLevelBandFrequency_A41864_Editable
		{
			get
			{
				short num = (short)784625115;
				short num2 = num;
				num = (short)904883675;
				switch (num2 == num)
				{
				}
				num = (short)486342656;
				if (num != 0)
				{
				}
				num = (short)446496769;
				if (num != 0)
				{
				}
				num = (short)1345191936;
				short num3 = num;
				return this.radWidePowerLevelBandFrequency_A41864.Editable;
			}
			set
			{
				short num = (short)1564016641;
				if (num != 0)
				{
				}
				num = (short)712368061;
				short num2 = num;
				num = (short)1513086909;
				switch (num2 == num)
				{
				}
				num = (short)463667200;
				if (num != 0)
				{
				}
				num = (short)2048524288;
				short num3 = num;
				this.radWidePowerLevelBandFrequency_A41864.Editable = value;
			}
		}

		// Token: 0x17002212 RID: 8722
		// (get) Token: 0x06004273 RID: 17011 RVA: 0x003DF828 File Offset: 0x003DDA28
		internal string RadWidePowerLevelBandFrequency_A41864_UILabel
		{
			get
			{
				short num = (short)248166752;
				short num2 = num;
				num = (short)1231206752;
				switch (num2 == num)
				{
				}
				num = (short)573112320;
				if (num != 0)
				{
				}
				num = (short)439091201;
				if (num != 0)
				{
				}
				num = (short)1806172160;
				short num3 = num;
				return this.radWidePowerLevelBandFrequency_A41864.UIName;
			}
		}

		// Token: 0x17002213 RID: 8723
		// (get) Token: 0x06004274 RID: 17012 RVA: 0x003DF8DC File Offset: 0x003DDADC
		// (set) Token: 0x06004275 RID: 17013 RVA: 0x003DF990 File Offset: 0x003DDB90
		internal bool RadWidePowerLevelBandFrequency_A41864_HiddenStatic
		{
			get
			{
				short num = (short)1059782657;
				if (num != 0)
				{
				}
				num = (short)1694008686;
				short num2 = num;
				num = (short)2075166062;
				switch (num2 == num)
				{
				}
				num = (short)774569984;
				if (num != 0)
				{
				}
				num = (short)1093730304;
				short num3 = num;
				return this.radWidePowerLevelBandFrequency_A41864.HiddenStatic;
			}
			set
			{
				short num = (short)1697460375;
				short num2 = num;
				num = (short)1110126743;
				switch (num2 == num)
				{
				}
				num = (short)1700921344;
				if (num != 0)
				{
				}
				num = (short)1293352961;
				if (num != 0)
				{
				}
				num = (short)505872384;
				short num3 = num;
				this.radWidePowerLevelBandFrequency_A41864.HiddenStatic = value;
			}
		}

		// Token: 0x17002214 RID: 8724
		// (get) Token: 0x06004276 RID: 17014 RVA: 0x003DFA48 File Offset: 0x003DDC48
		// (set) Token: 0x06004277 RID: 17015 RVA: 0x003DFB00 File Offset: 0x003DDD00
		internal bool RadWidePowerLevelBandFrequency_A41864_HiddenDynamic
		{
			get
			{
				short num = (short)712684893;
				short num2 = num;
				num = (short)577090909;
				switch (num2 == num)
				{
				}
				num = (short)196214784;
				if (num != 0)
				{
				}
				num = (short)1874591745;
				if (num != 0)
				{
				}
				num = (short)1347878912;
				short num3 = num;
				return this.radWidePowerLevelBandFrequency_A41864.HiddenDynamic;
			}
			set
			{
				short num = (short)302054378;
				short num2 = num;
				num = (short)1791163370;
				switch (num2 == num)
				{
				}
				num = (short)619380736;
				if (num != 0)
				{
				}
				num = (short)157745153;
				if (num != 0)
				{
				}
				num = (short)1403387904;
				short num3 = num;
				this.radWidePowerLevelBandFrequency_A41864.HiddenDynamic = value;
			}
		}

		// Token: 0x17002215 RID: 8725
		// (get) Token: 0x06004278 RID: 17016 RVA: 0x003DFBB8 File Offset: 0x003DDDB8
		public bool RadWidePowerLevelBandFrequency_A41864_HasDiffs
		{
			get
			{
				short num = (short)408084152;
				short num2 = num;
				num = (short)2061950648;
				switch (num2 == num)
				{
				}
				num = (short)811925505;
				if (num != 0)
				{
				}
				num = (short)2007433216;
				if (num != 0)
				{
				}
				num = (short)2106720256;
				short num3 = num;
				return this.radWidePowerLevelBandFrequency_A41864._HasDiffs;
			}
		}

		// Token: 0x17002216 RID: 8726
		// (get) Token: 0x06004279 RID: 17017 RVA: 0x003DFC6C File Offset: 0x003DDE6C
		public global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation RefRadioInformation
		{
			get
			{
				short num = (short)791216311;
				short num2 = num;
				num = (short)1180696759;
				switch (num2 == num)
				{
				}
				num = (short)59703297;
				if (num != 0)
				{
				}
				num = (short)623443968;
				short num3 = num;
				num = (short)223870976;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation;
			}
		}

		// Token: 0x0600427A RID: 17018 RVA: 0x003DFD28 File Offset: 0x003DDF28
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
			{
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						if (base.ParentRecset.ContainerDoc != null)
						{
							num2 = (short)358809603;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					case 1:
						goto IL_B0;
					case 2:
						if (base.ParentRecset != null)
						{
							num2 = (short)2008416260;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					case 3:
						result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
						num2 = (short)1358036993;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 4:
						num2 = (short)882638848;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_24;
				}
				IL_B0:
				num2 = (short)836170020;
				short num3 = num2;
				num2 = (short)1266086180;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_4D;
				default:
				{
					num2 = (short)513802240;
					if (num2 != 0)
					{
					}
					num2 = (short)1660682240;
					short num4 = num2;
					break;
				}
				}
				return result;
			}
			}
			IL_24:
			num2 = (short)1380515841;
			if (num2 != 0)
			{
			}
			result = null;
			IL_4D:
			num2 = (short)784465922;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04001A16 RID: 6678
		private global::AcpBusinessLayer.AcpRangeField<int, string> radWideTransmitPowerLevelsTxPowerLevelHighW_A41854;

		// Token: 0x04001A17 RID: 6679
		private global::AcpBusinessLayer.AcpRangeField<int, string> radWideTransmitPowerLevelsTxPowerLevelLowW_A41855;

		// Token: 0x04001A18 RID: 6680
		private global::AcpBusinessLayer.AcpFrequencyField radWideTransmitPowerLevelsFrequencyRangeStartMHz_A41856;

		// Token: 0x04001A19 RID: 6681
		private global::AcpBusinessLayer.AcpFrequencyField radWideTransmitPowerLevelsFrequencyRangeEndMHz_A41857;

		// Token: 0x04001A1A RID: 6682
		private global::AcpBusinessLayer.AcpRangeField<int, string> radWideTransmitPowerLevelsTxPowerLevelMinimumW_A41858;

		// Token: 0x04001A1B RID: 6683
		private global::AcpBusinessLayer.AcpRangeField<int, string> radWideTransmitPowerLevelsTxPowerLevelMaximumW_A41859;

		// Token: 0x04001A1C RID: 6684
		private global::AcpBusinessLayer.AcpRangeField<int, string> radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41860;

		// Token: 0x04001A1D RID: 6685
		private global::AcpBusinessLayer.AcpRangeField<int, string> radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41861;

		// Token: 0x04001A1E RID: 6686
		private global::AcpBusinessLayer.AcpRangeField<int, string> radWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41862;

		// Token: 0x04001A1F RID: 6687
		private global::AcpBusinessLayer.AcpRangeField<int, string> radWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41863;

		// Token: 0x04001A20 RID: 6688
		private global::AcpBusinessLayer.AcpField<string> radWidePowerLevelBandFrequency_A41864;
	}
}
