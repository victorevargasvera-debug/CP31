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
	// Token: 0x0200018F RID: 399
	[global::System.Serializable]
	public class TxPowerLevelsByFrequencyRangeInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600403C RID: 16444 RVA: 0x003C3BB8 File Offset: 0x003C1DB8
		public TxPowerLevelsByFrequencyRangeInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x0600403D RID: 16445 RVA: 0x003C3BD4 File Offset: 0x003C1DD4
		protected TxPowerLevelsByFrequencyRangeInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600403E RID: 16446 RVA: 0x003C3BEC File Offset: 0x003C1DEC
		public override void Init()
		{
			int a_ = 0;
			short num = (short)1710404179;
			short num2 = num;
			num = (short)976990803;
			switch (num2 == num)
			{
			}
			num = (short)1396047873;
			if (num != 0)
			{
			}
			num = (short)1683423232;
			short num3 = num;
			num = (short)936181760;
			if (num != 0)
			{
			}
			this.radWideTransmitPowerLevelsTxPowerLevelHighW_A8152 = new global::AcpBusinessLayer.AcpRangeField<int, string>(37993, new global::Motorola.MackinawCPS.CoreFeatures.RadioWide.ConvertTxPowerLevelValues(), this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌鯎ꏐ닒믔ꓖ듘닚꧜连軠铢胤闦ꗨ軪鯬諮鷰胲ꇴ迶꧸铺諼髾猀伂怄焆氈朊䔌明瘐笒䈔䠖堘⌚Ⱌ⨞ጠ", a_), global::CommonResources.AcgResources.ID_TXPOWERLEVELHIGHW, 10000, 60000, 1);
			this.radWideTransmitPowerLevelsTxPowerLevelHighW_A8152.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radWideTransmitPowerLevelsTxPowerLevelHighW_A8152.DataTransferOrder = 105;
			this.radWideTransmitPowerLevelsTxPowerLevelHighW_A8152.ShowHexValue = false;
			this.radWideTransmitPowerLevelsTxPowerLevelLowW_A8153 = new global::AcpBusinessLayer.AcpRangeField<int, string>(30792, new global::Motorola.MackinawCPS.CoreFeatures.RadioWide.ConvertTxPowerLevelValues(), this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌鯎ꏐ닒믔ꓖ듘닚꧜连軠铢胤闦ꗨ軪鯬諮鷰胲ꇴ迶꧸铺諼髾猀伂怄焆氈朊䄌怎昐䐒䨔嘖℘⨚⠜Ⱎ", a_), global::CommonResources.AcgResources.ID_TXPOWERLEVELLOWW, 10000, 60000, 1);
			this.radWideTransmitPowerLevelsTxPowerLevelLowW_A8153.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radWideTransmitPowerLevelsTxPowerLevelLowW_A8153.DataTransferOrder = 106;
			this.radWideTransmitPowerLevelsTxPowerLevelLowW_A8153.ShowHexValue = false;
			this.radWideTransmitPowerLevelsFrequencyRangeStartMHz_A19994 = new global::AcpBusinessLayer.AcpFrequencyField(27200000, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌鯎ꏐ닒믔ꓖ듘닚꧜连軠铢胤闦ꗨ軪鯬諮鷰胲돴藶鳸諺裼髾漀怂簄唆栈攊樌樎䈐朒琔攖洘嘚唜攞縠戢ᐤḦဨሪ᤬", a_), global::CommonResources.AcgResources.ID_FREQUENCYRANGESTARTMHZ, 0, 199999999, 1);
			this.radWideTransmitPowerLevelsFrequencyRangeStartMHz_A19994.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radWideTransmitPowerLevelsFrequencyRangeStartMHz_A19994.DataTransferOrder = 102;
			this.radWideTransmitPowerLevelsFrequencyRangeEndMHz_A20037 = new global::AcpBusinessLayer.AcpFrequencyField(35000000, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌鯎ꏐ닒믔ꓖ듘닚꧜连軠铢胤闦ꗨ軪鯬諮鷰胲돴藶鳸諺裼髾漀怂簄唆栈攊樌樎吐紒焔娖儘愚䈜帞ጠጢᔤᐦḨ", a_), global::CommonResources.AcgResources.ID_FREQUENCYRANGEENDMHZ, 0, 199999999, 1);
			this.radWideTransmitPowerLevelsFrequencyRangeEndMHz_A20037.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radWideTransmitPowerLevelsFrequencyRangeEndMHz_A20037.DataTransferOrder = 58;
			this.radWideTransmitPowerLevelsTxPowerLevelMinimumW_A20038 = new global::AcpBusinessLayer.AcpRangeField<int, string>(30000, new global::Motorola.MackinawCPS.CoreFeatures.RadioWide.ConvertTxPowerLevelValues(), this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌鯎ꏐ닒믔ꓖ듘닚꧜连軠铢胤闦ꗨ軪鯬諮鷰胲ꇴ迶꧸铺諼髾猀伂怄焆氈朊䀌明缐稒研或琘䰚䈜帞ጠጢᔤᐦᄨ", a_), global::CommonResources.AcgResources.ID_TXPOWERLEVELMINIMUMW, 10000, 60000, 1);
			this.radWideTransmitPowerLevelsTxPowerLevelMinimumW_A20038.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radWideTransmitPowerLevelsTxPowerLevelMinimumW_A20038.DataTransferOrder = 103;
			this.radWideTransmitPowerLevelsTxPowerLevelMinimumW_A20038.ShowHexValue = false;
			this.radWideTransmitPowerLevelsTxPowerLevelMaximumW_A20039 = new global::AcpBusinessLayer.AcpRangeField<int, string>(37993, new global::Motorola.MackinawCPS.CoreFeatures.RadioWide.ConvertTxPowerLevelValues(), this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌鯎ꏐ닒믔ꓖ듘닚꧜连軠铢胤闦ꗨ軪鯬諮鷰胲ꇴ迶꧸铺諼髾猀伂怄焆氈朊䀌渎椐稒研或琘䰚䈜帞ጠጢᔤᐦဨ", a_), global::CommonResources.AcgResources.ID_TXPOWERLEVELMAXIMUMW, 10000, 60000, 1);
			this.radWideTransmitPowerLevelsTxPowerLevelMaximumW_A20039.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radWideTransmitPowerLevelsTxPowerLevelMaximumW_A20039.DataTransferOrder = 104;
			this.radWideTransmitPowerLevelsTxPowerLevelMaximumW_A20039.ShowHexValue = false;
			this.radWidePowerLevelBandFrequency_A41063 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_VHF, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌鿎뻐ꓒ냔ꗖ闘뻚ꯜ뫞跠ꇢ蓤触跨귪鿬諮胰蛲郴駶髸苺ꋼ뻾㔀㈂㔄ㄆ㨈", a_), global::CommonResources.AcgResources.ID_FREQUENCYBAND, 100);
			this.radWidePowerLevelBandFrequency_A41063.IgnoreOnCompare = true;
			this.radWidePowerLevelBandFrequency_A41063.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radWidePowerLevelBandFrequency_A41063.DataTransferOrder = -1;
			this.radWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41173 = new global::AcpBusinessLayer.AcpRangeField<int, string>(30000, new global::Motorola.MackinawCPS.CoreFeatures.RadioWide.ConvertTxPowerLevelValues(), this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌鯎ꏐ닒믔ꓖ듘닚꧜连軠铢胤闦ꗨ軪鯬諮鷰胲뛴飶韸跺ꧼ蟾儀氂爄戆笈䜊栌礎琐缒堔縖眘爚瀜樞䰠琢稤昦ᴨᨪᰬᠮȰ", a_), global::CommonResources.AcgResources.ID_CNVTXPOWERLEVELMINIMUMW, 10000, 60000, 1);
			this.radWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41173.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41173.DataTransferOrder = 160;
			this.radWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41173.ShowHexValue = false;
			this.radWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41174 = new global::AcpBusinessLayer.AcpRangeField<int, string>(30000, new global::Motorola.MackinawCPS.CoreFeatures.RadioWide.ConvertTxPowerLevelValues(), this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌鯎ꏐ닒믔ꓖ듘닚꧜连軠铢胤闦ꗨ軪鯬諮鷰胲ꇴ藶鋸꿺藼꿾渀琂怄甆䔈渊笌樎紐帒簔礖瀘瘚栜爞瘠簢搤ጦᠨᨪᨬᬮ", a_), global::CommonResources.AcgResources.ID_TRKTXPOWERLEVELMINIMUMW, 10000, 60000, 1);
			this.radWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41174.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41174.DataTransferOrder = 161;
			this.radWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41174.ShowHexValue = false;
			this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41175 = new global::AcpBusinessLayer.AcpRangeField<int, string>(30792, new global::Motorola.MackinawCPS.CoreFeatures.RadioWide.ConvertTxPowerLevelValues(), this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌鯎ꏐ닒믔ꓖ듘닚꧜连軠铢胤闦ꗨ軪鯬諮鷰胲뛴飶韸跺ꧼ蟾儀氂爄戆笈䜊栌礎琐缒夔砖渘䰚䈜帞ᔠሢᐤဦᰨ", a_), global::CommonResources.AcgResources.ID_CNVTXPOWERLEVELLOWW, 10000, 60000, 1);
			this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41175.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41175.DataTransferOrder = 162;
			this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41175.ShowHexValue = false;
			this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41176 = new global::AcpBusinessLayer.AcpRangeField<int, string>(30792, new global::Motorola.MackinawCPS.CoreFeatures.RadioWide.ConvertTxPowerLevelValues(), this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ郆ꃈ꿊꣌鯎ꏐ닒믔ꓖ듘닚꧜连軠铢胤闦ꗨ軪鯬諮鷰胲ꇴ藶鋸꿺藼꿾渀琂怄甆䔈渊笌樎紐弒稔怖丘䐚尜⬞ဠሢሤᄦ", a_), global::CommonResources.AcgResources.ID_TRKTXPOWERLEVELLOWW, 10000, 60000, 1);
			this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41176.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41176.DataTransferOrder = 163;
			this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41176.ShowHexValue = false;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("闀믂韆ꛈ볊꣌뷎鿒냔ꇖ볘럚껜￞菠髢엤ꇦ鯨軪鳬髮铰鷲雴軶\ud9f8ꧺ鳼釾昀昂", a_);
			base.Id = 10104;
			base.UIName = global::CommonResources.AcgResources.ID_TXPOWERLEVELSBYFREQUENCYRANGE;
			base.DataTransferOrder = 1;
		}

		// Token: 0x0600403F RID: 16447 RVA: 0x003C4078 File Offset: 0x003C2278
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 13;
			short num = (short)1681063956;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_2E2;
				case 1:
					goto IL_586;
				case 2:
					goto IL_3C9;
				case 3:
					num = (short)2010906625;
					if (num != 0)
					{
					}
					this.radWideTransmitPowerLevelsFrequencyRangeEndMHz_A20037 = new global::AcpBusinessLayer.AcpFrequencyField(35000000, this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑菓뿕볗뿙裛곝臟賡韣该臧黩볫臭蟯韱蛳뫵鷷賹駻鋽珿䐁瘃挅礇缉椋怍猏欑䘓眕瘗紙礛嬝丟䘡椣渥刧甩洫ᰭ/ȱܳĵ", a_), global::CommonResources.AcgResources.ID_FREQUENCYRANGEENDMHZ);
					this.radWideTransmitPowerLevelsFrequencyRangeEndMHz_A20037.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radWideTransmitPowerLevelsFrequencyRangeEndMHz_A20037.DataTransferOrder = 58;
					num = (short)1286012947;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41176 = new global::AcpBusinessLayer.AcpRangeField<int, string>(30792, new global::Motorola.MackinawCPS.CoreFeatures.RadioWide.ConvertTxPowerLevelValues(), this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑菓뿕볗뿙裛곝臟賡韣该臧黩볫臭蟯韱蛳뫵鷷賹駻鋽珿嘁瘃洅將爉尋愍朏眑易娕紗氙礛爝氟䴡匣焥眧欩ᠫἭįԱȳ", a_), global::CommonResources.AcgResources.ID_TRKTXPOWERLEVELLOWW);
					this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41176.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41176.DataTransferOrder = 163;
					this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41176.ShowHexValue = false;
					num = (short)1191444515;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鳍뇏뛑菓뿕볗뿙裛곝臟賡韣该臧黩볫臭蟯韱蛳뫵鷷賹駻鋽珿嘁簃嘅朇紉椋簍小眑戓猕琗圙甛瀝䤟伡儣䬥缧甩洫ᰭ/ȱܳี", a_)))
					{
						num = (short)1520369674;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_37C;
				case 6:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鳍뇏뛑菓뿕볗뿙裛곝臟賡韣该臧黩볫臭蟯韱蛳뫵鷷賹駻鋽珿䄁欃栅縇帉琋帍缏攑焓搕吗缙樛笝䰟渡䬣儥缧甩洫ᨭį̵̱̳", a_)))
					{
						num = (short)270401563;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_32F;
				case 7:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鳍뇏뛑菓뿕볗뿙裛곝臟賡韣该臧黩볫臭蟯韱蛳뫵鷷賹駻鋽珿嘁瘃洅將爉尋愍朏眑易娕紗氙礛爝氟䴡匣焥眧欩ᠫἭįԱȳ", a_)))
					{
						goto IL_360;
					}
					goto IL_97C;
				case 8:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鳍뇏뛑菓뿕볗뿙賛뇝韟蟡難ꫥ跧鳩觫苭닯鏱髳鋵뻷裹駻追痿朁樃攅焇唉䴋㨍ℏ∑∓┕", a_)))
					{
						num = (short)1588133924;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2E2;
				case 9:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鳍뇏뛑菓뿕볗뿙裛곝臟賡韣该臧黩볫臭蟯韱蛳뫵鷷賹駻鋽珿嘁簃嘅朇紉椋簍小眑戓猕琗圙紛昝䤟伡儣䬥缧甩洫ᰭ/ȱ༵ܳ", a_)))
					{
						num = (short)1279066129;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_895;
				case 10:
					this.radWideTransmitPowerLevelsTxPowerLevelMinimumW_A20038 = new global::AcpBusinessLayer.AcpRangeField<int, string>(30000, new global::Motorola.MackinawCPS.CoreFeatures.RadioWide.ConvertTxPowerLevelValues(), this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑菓뿕볗뿙裛곝臟賡韣该臧黩볫臭蟯韱蛳뫵鷷賹駻鋽珿嘁簃嘅朇紉椋簍小眑戓猕琗圙甛瀝䤟伡儣䬥缧甩洫ᰭ/ȱܳี", a_), global::CommonResources.AcgResources.ID_TXPOWERLEVELMINIMUMW);
					this.radWideTransmitPowerLevelsTxPowerLevelMinimumW_A20038.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radWideTransmitPowerLevelsTxPowerLevelMinimumW_A20038.DataTransferOrder = 103;
					this.radWideTransmitPowerLevelsTxPowerLevelMinimumW_A20038.ShowHexValue = false;
					num = (short)475529246;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					this.radWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41173 = new global::AcpBusinessLayer.AcpRangeField<int, string>(30000, new global::Motorola.MackinawCPS.CoreFeatures.RadioWide.ConvertTxPowerLevelValues(), this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑菓뿕볗뿙裛곝臟賡韣该臧黩볫臭蟯韱蛳뫵鷷賹駻鋽珿䄁欃栅縇帉琋帍缏攑焓搕吗缙樛笝䰟漡䴣䠥䄧䜩夫䌭术洱申ȵषହ଻ഽ", a_), global::CommonResources.AcgResources.ID_CNVTXPOWERLEVELMINIMUMW);
					this.radWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41173.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41173.DataTransferOrder = 160;
					this.radWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41173.ShowHexValue = false;
					num = (short)1529806860;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					goto IL_930;
				case 13:
					if (producerFields != null)
					{
						num = (short)1041104924;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_97C;
				case 14:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鳍뇏뛑菓뿕볗뿙裛곝臟賡韣该臧黩볫臭蟯韱蛳뫵鷷賹駻鋽珿嘁簃嘅朇紉椋簍小眑戓猕琗则甛礝䠟甡笣朥ဧᬩᤫᰭ", a_)))
					{
						num = (short)1804599311;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_586;
				case 15:
					this.radWideTransmitPowerLevelsTxPowerLevelHighW_A8152 = new global::AcpBusinessLayer.AcpRangeField<int, string>(37993, new global::Motorola.MackinawCPS.CoreFeatures.RadioWide.ConvertTxPowerLevelValues(), this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑菓뿕볗뿙裛곝臟賡韣该臧黩볫臭蟯韱蛳뫵鷷賹駻鋽珿嘁簃嘅朇紉椋簍小眑戓猕琗则甛礝䠟甡笣朥ဧᬩᤫᰭ", a_), global::CommonResources.AcgResources.ID_TXPOWERLEVELHIGHW);
					this.radWideTransmitPowerLevelsTxPowerLevelHighW_A8152.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radWideTransmitPowerLevelsTxPowerLevelHighW_A8152.DataTransferOrder = 105;
					this.radWideTransmitPowerLevelsTxPowerLevelHighW_A8152.ShowHexValue = false;
					num = (short)805306369;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
					goto IL_651;
				case 17:
					this.radWideTransmitPowerLevelsTxPowerLevelMaximumW_A20039 = new global::AcpBusinessLayer.AcpRangeField<int, string>(37993, new global::Motorola.MackinawCPS.CoreFeatures.RadioWide.ConvertTxPowerLevelValues(), this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑菓뿕볗뿙裛곝臟賡韣该臧黩볫臭蟯韱蛳뫵鷷賹駻鋽珿嘁簃嘅朇紉椋簍小眑戓猕琗圙紛昝䤟伡儣䬥缧甩洫ᰭ/ȱ༵ܳ", a_), global::CommonResources.AcgResources.ID_TXPOWERLEVELMAXIMUMW);
					this.radWideTransmitPowerLevelsTxPowerLevelMaximumW_A20039.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radWideTransmitPowerLevelsTxPowerLevelMaximumW_A20039.DataTransferOrder = 104;
					this.radWideTransmitPowerLevelsTxPowerLevelMaximumW_A20039.ShowHexValue = false;
					num = (short)1350303778;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 18:
				{
					this.radWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41174 = new global::AcpBusinessLayer.AcpRangeField<int, string>(30000, new global::Motorola.MackinawCPS.CoreFeatures.RadioWide.ConvertTxPowerLevelValues(), this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑菓뿕볗뿙裛곝臟賡韣该臧黩볫臭蟯韱蛳뫵鷷賹駻鋽珿嘁瘃洅將爉尋愍朏眑易娕紗氙礛爝洟䬡䨣伥䔧弩䄫礭漯猱3ܵषഹ࠻", a_), global::CommonResources.AcgResources.ID_TRKTXPOWERLEVELMINIMUMW);
					this.radWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41174.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41174.DataTransferOrder = 161;
					this.radWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41174.ShowHexValue = false;
					num = (short)595531618;
					short num3 = num;
					num = (short)1298339682;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_360;
					default:
						num = (short)1477312512;
						if (num != 0)
						{
						}
						num = (short)1223819293;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 19:
					goto IL_7E1;
				case 20:
					switch (0)
					{
					case 0:
						goto IL_C2;
					}
					continue;
				case 21:
				{
					num = (short)1889140736;
					short num4 = num;
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鳍뇏뛑菓뿕볗뿙裛곝臟賡韣该臧黩볫臭蟯韱蛳뫵鷷賹駻鋽珿嘁簃嘅朇紉椋簍小眑戓猕琗嘙猛椝真紡攣ḥᤧἩἫ", a_)))
					{
						num = (short)529072150;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3C9;
				}
				case 22:
					this.radWideTransmitPowerLevelsTxPowerLevelLowW_A8153 = new global::AcpBusinessLayer.AcpRangeField<int, string>(30792, new global::Motorola.MackinawCPS.CoreFeatures.RadioWide.ConvertTxPowerLevelValues(), this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑菓뿕볗뿙裛곝臟賡韣该臧黩볫臭蟯韱蛳뫵鷷賹駻鋽珿嘁簃嘅朇紉椋簍小眑戓猕琗嘙猛椝真紡攣ḥᤧἩἫ", a_), global::CommonResources.AcgResources.ID_TXPOWERLEVELLOWW);
					this.radWideTransmitPowerLevelsTxPowerLevelLowW_A8153.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radWideTransmitPowerLevelsTxPowerLevelLowW_A8153.DataTransferOrder = 106;
					this.radWideTransmitPowerLevelsTxPowerLevelLowW_A8153.ShowHexValue = false;
					num = (short)1608581122;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 23:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鳍뇏뛑菓뿕볗뿙裛곝臟賡韣该臧黩볫臭蟯韱蛳뫵鷷賹駻鋽珿䐁瘃挅礇缉椋怍猏欑䘓眕瘗紙礛䴝吟䌡嘣別攧戩嘫焭焯̱ള༵ķู", a_)))
					{
						num = (short)709820448;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_651;
				case 24:
					goto IL_32F;
				case 25:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鳍뇏뛑菓뿕볗뿙裛곝臟賡韣该臧黩볫臭蟯韱蛳뫵鷷賹駻鋽珿嘁瘃洅將爉尋愍朏眑易娕紗氙礛爝洟䬡䨣伥䔧弩䄫礭漯猱3ܵषഹ࠻", a_)))
					{
						num = (short)2009333778;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_22A;
				case 26:
					num = (short)1685389325;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 27:
					this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41175 = new global::AcpBusinessLayer.AcpRangeField<int, string>(30792, new global::Motorola.MackinawCPS.CoreFeatures.RadioWide.ConvertTxPowerLevelValues(), this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑菓뿕볗뿙裛곝臟賡韣该臧黩볫臭蟯韱蛳뫵鷷賹駻鋽珿䄁欃栅縇帉琋帍缏攑焓搕吗缙樛笝䰟渡䬣儥缧甩洫ᨭį̵̱̳", a_), global::CommonResources.AcgResources.ID_CNVTXPOWERLEVELLOWW);
					this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41175.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41175.DataTransferOrder = 162;
					this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41175.ShowHexValue = false;
					num = (short)495452184;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 28:
					num = (short)1826750478;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 29:
					goto IL_22A;
				case 30:
					goto IL_37C;
				case 31:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鳍뇏뛑菓뿕볗뿙裛곝臟賡韣该臧黩볫臭蟯韱蛳뫵鷷賹駻鋽珿䐁瘃挅礇缉椋怍猏欑䘓眕瘗紙礛嬝丟䘡椣渥刧甩洫ᰭ/ȱܳĵ", a_)))
					{
						num = (short)331743235;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_7E1;
				case 32:
					this.radWideTransmitPowerLevelsFrequencyRangeStartMHz_A19994 = new global::AcpBusinessLayer.AcpFrequencyField(27200000, this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑菓뿕볗뿙裛곝臟賡韣该臧黩볫臭蟯韱蛳뫵鷷賹駻鋽珿䐁瘃挅礇缉椋怍猏欑䘓眕瘗紙礛䴝吟䌡嘣別攧戩嘫焭焯̱ള༵ķู", a_), global::CommonResources.AcgResources.ID_FREQUENCYRANGESTARTMHZ);
					this.radWideTransmitPowerLevelsFrequencyRangeStartMHz_A19994.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radWideTransmitPowerLevelsFrequencyRangeStartMHz_A19994.DataTransferOrder = 102;
					num = (short)625410064;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 33:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鳍뇏뛑菓뿕볗뿙裛곝臟賡韣该臧黩볫臭蟯韱蛳뫵鷷賹駻鋽珿䄁欃栅縇帉琋帍缏攑焓搕吗缙樛笝䰟漡䴣䠥䄧䜩夫䌭术洱申ȵषହ଻ഽ", a_)))
					{
						num = (short)61472779;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_930;
				case 34:
					goto IL_895;
				case 35:
					goto IL_4EC;
				case 36:
					this.radWidePowerLevelBandFrequency_A41063 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_VHF, this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑菓뿕볗뿙賛뇝韟蟡難ꫥ跧鳩觫苭닯鏱髳鋵뻷裹駻追痿朁樃攅焇唉䴋㨍ℏ∑∓┕", a_), global::CommonResources.AcgResources.ID_FREQUENCYBAND, 100);
					this.radWidePowerLevelBandFrequency_A41063.IgnoreOnCompare = true;
					this.radWidePowerLevelBandFrequency_A41063.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radWidePowerLevelBandFrequency_A41063.DataTransferOrder = -1;
					num = (short)1405616128;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_C2:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)246415386;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_22A:
				num = (short)90243078;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2E2:
				num = (short)1969618977;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_32F:
				num = (short)93913095;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_360:
				num = (short)1532100612;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_37C:
				num = (short)716636169;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3C9:
				num = (short)1977614359;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_586:
				num = (short)265748501;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_651:
				num = (short)2053636127;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_7E1:
				num = (short)9109509;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_895:
				num = (short)1816068104;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_930:
				num = (short)1475346457;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_4EC:
			IL_97C:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("髍꣏蓓맕꿗뿙껛ﻝ곟蟡鋣菥蓧駩쳫賭觯틱닳蓵鷷诹觻鯽滿愁紃★娇欉戋植甏", a_);
			base.Id = 10104;
			base.UIName = global::CommonResources.AcgResources.ID_TXPOWERLEVELSBYFREQUENCYRANGE;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06004040 RID: 16448 RVA: 0x003C4A34 File Offset: 0x003C2C34
		public override void PopulateReferences()
		{
			short num = (short)1203044353;
			if (num != 0)
			{
			}
			num = (short)407976466;
			short num2 = num;
			num = (short)2125281810;
			switch (num2 == num)
			{
			}
			num = (short)1237778432;
			short num3 = num;
			num = (short)846790656;
			if (num != 0)
			{
			}
		}

		// Token: 0x06004041 RID: 16449 RVA: 0x003C4AE0 File Offset: 0x003C2CE0
		public override void DropReferences()
		{
			short num = (short)2041366041;
			short num2 = num;
			num = (short)2077148697;
			switch (num2 == num)
			{
			}
			num = (short)1745616897;
			if (num != 0)
			{
			}
			num = (short)442368000;
			short num3 = num;
			num = (short)1539178496;
			if (num != 0)
			{
			}
		}

		// Token: 0x06004042 RID: 16450 RVA: 0x003C4B88 File Offset: 0x003C2D88
		public override void SetConstraints()
		{
			short num = (short)1907503857;
			short num2 = num;
			num = (short)879637233;
			switch (num2 == num)
			{
			}
			num = (short)1176436737;
			if (num != 0)
			{
			}
			num = (short)630063104;
			short num3 = num;
			num = (short)1559101440;
			if (num != 0)
			{
			}
			this.radWideTransmitPowerLevelsTxPowerLevelHighW_A8152.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConTxPowerLevelsByFrequencyRange);
			this.radWideTransmitPowerLevelsTxPowerLevelHighW_A8152.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.conTxPwrLvlLoLessThanEqlToTxPwrLvlHiAndTxPwrLvlHiLessThanEqlToTxPwrLvlMaxAndTxPwrLvlHiGrtrThanEqlToTxPwrLvlMin);
			this.radWideTransmitPowerLevelsTxPowerLevelHighW_A8152.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConIsNewBandPlanSelOld);
			this.radWideTransmitPowerLevelsTxPowerLevelHighW_A8152.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConTxPowerLevelsByFrequencyRangeEditable);
			this.radWideTransmitPowerLevelsTxPowerLevelLowW_A8153.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConTxPowerLevelsByFrequencyRange);
			this.radWideTransmitPowerLevelsTxPowerLevelLowW_A8153.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.conTxPwrLvlLoLessThanEqlToTxPwrLvlHiAndTxPwrLvlLoLessThanEqlToTxPwrLvlMaxAndTxPwrLvlLoGrtrThanEqlToTxPwrLvlMin);
			this.radWideTransmitPowerLevelsTxPowerLevelLowW_A8153.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConIsNewBandPlanSelOld);
			this.radWideTransmitPowerLevelsTxPowerLevelLowW_A8153.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConTxPowerLevelsByFrequencyRangeEditable);
			this.radWideTransmitPowerLevelsFrequencyRangeStartMHz_A19994.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConIsNewBandPlanSelOld);
			this.radWideTransmitPowerLevelsFrequencyRangeStartMHz_A19994.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.conReturnTrueIfViewSetToLabtoolOrDepot);
			this.radWideTransmitPowerLevelsFrequencyRangeEndMHz_A20037.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConIsNewBandPlanSelOld);
			this.radWideTransmitPowerLevelsFrequencyRangeEndMHz_A20037.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.conReturnTrueIfViewSetToLabtoolOrDepot);
			this.radWideTransmitPowerLevelsTxPowerLevelMinimumW_A20038.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConIsNewBandPlanSelOld);
			this.radWideTransmitPowerLevelsTxPowerLevelMinimumW_A20038.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.conReturnTrueIfViewSetToLabtoolOrDepot);
			this.radWideTransmitPowerLevelsTxPowerLevelMaximumW_A20039.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConIsNewBandPlanSelOld);
			this.radWideTransmitPowerLevelsTxPowerLevelMaximumW_A20039.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.conReturnTrueIfViewSetToLabtoolOrDepot);
			this.radWidePowerLevelBandFrequency_A41063.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConIsNewBandPlanSelOld);
			this.radWidePowerLevelBandFrequency_A41063.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.radWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41173.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConIsNewBandPlanSelOld);
			this.radWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41173.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.conReturnTrueIfViewSetToLabtool);
			this.radWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41174.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConIsNewBandPlanSelOld);
			this.radWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41174.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.conReturnTrueIfViewSetToLabtool);
			this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41175.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConTxPowerLevelsByFrequencyRange);
			this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41175.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.conConvTxPwrLvlLoLessThanEqlToTxPwrLvlHiAndConvTxPwrLvlLoLessThanEqlToTxPwrLvlMaxAndConvTxPwrLvlLoGrtrThanEqlToConvTxPwrLvlMin);
			this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41175.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConIsNewBandPlanSelOld);
			this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41175.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConTxPowerLevelsByFrequencyRangeEditable);
			this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41176.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConTxPowerLevelsByFrequencyRange);
			this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41176.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.conTrkTxPwrLvlLoLessThanEqlToTxPwrLvlHiAndTrkTxPwrLvlLoLessThanEqlToTxPwrLvlMaxAndTrkTxPwrLvlLoGrtrThanEqlToTrkTxPwrLvlMin);
			this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41176.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConIsNewBandPlanSelOld);
			this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41176.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConTxPowerLevelsByFrequencyRangeEditable);
		}

		// Token: 0x06004043 RID: 16451 RVA: 0x003C4EE4 File Offset: 0x003C30E4
		public override void SetupDependencies()
		{
			short num = (short)1051905276;
			short num2 = num;
			num = (short)181914876;
			switch (num2 == num)
			{
			}
			num = (short)263258112;
			if (num != 0)
			{
			}
			num = (short)902627328;
			short num3 = num;
			num = (short)1578565633;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide = base.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
			this.radWideTransmitPowerLevelsTxPowerLevelMinimumW_A20038.AddDependentObject(this.radWideTransmitPowerLevelsTxPowerLevelHighW_A8152);
			this.radWideTransmitPowerLevelsTxPowerLevelMaximumW_A20039.AddDependentObject(this.radWideTransmitPowerLevelsTxPowerLevelHighW_A8152);
			this.radWideTransmitPowerLevelsTxPowerLevelLowW_A8153.AddDependentObject(this.radWideTransmitPowerLevelsTxPowerLevelHighW_A8152);
			this.radWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41173.AddDependentObject(this.radWideTransmitPowerLevelsTxPowerLevelHighW_A8152);
			this.radWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41174.AddDependentObject(this.radWideTransmitPowerLevelsTxPowerLevelHighW_A8152);
			this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41175.AddDependentObject(this.radWideTransmitPowerLevelsTxPowerLevelHighW_A8152);
			this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41176.AddDependentObject(this.radWideTransmitPowerLevelsTxPowerLevelHighW_A8152);
			this.RefRadioInformation.Labtool.RadInfoLabtoolPrimaryBands_A23987.AddDependentObject(this.radWideTransmitPowerLevelsTxPowerLevelHighW_A8152);
			this.RefRadioInformation.Labtool.RadInfoLabtoolSecondaryBands_A23988.AddDependentObject(this.radWideTransmitPowerLevelsTxPowerLevelHighW_A8152);
			this.RefRadioInformation.Labtool.RadInfoLabtoolDualBandEnable_A23986.AddDependentObject(this.radWideTransmitPowerLevelsTxPowerLevelHighW_A8152);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesAllowInvalidFrequencies_A12493.AddDependentObject(this.radWideTransmitPowerLevelsTxPowerLevelHighW_A8152);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesVHFUsedinCodeplug_A8481.AddDependentObject(this.radWideTransmitPowerLevelsTxPowerLevelHighW_A8152);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRanges7800MHzUsedinCodeplug_A8512.AddDependentObject(this.radWideTransmitPowerLevelsTxPowerLevelHighW_A8152);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesUHF1UsedinCodeplug_A8504.AddDependentObject(this.radWideTransmitPowerLevelsTxPowerLevelHighW_A8152);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesUHF2UsedinCodeplug_A8507.AddDependentObject(this.radWideTransmitPowerLevelsTxPowerLevelHighW_A8152);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRanges700MHzUsedinCodeplug_A42551.AddDependentObject(this.radWideTransmitPowerLevelsTxPowerLevelHighW_A8152);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRanges800MHzUsedinCodeplug_A42552.AddDependentObject(this.radWideTransmitPowerLevelsTxPowerLevelHighW_A8152);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRanges900MHzUsedinCodeplug_A8516.AddDependentObject(this.radWideTransmitPowerLevelsTxPowerLevelHighW_A8152);
			this.RefRadioInformation.General.RadInfoGeneralPrimaryFrequencyBandVHF_A42545.AddDependentObject(this.radWideTransmitPowerLevelsTxPowerLevelHighW_A8152);
			this.RefRadioInformation.General.RadInfoGeneralPrimaryFrequencyBandUHF1_A42546.AddDependentObject(this.radWideTransmitPowerLevelsTxPowerLevelHighW_A8152);
			this.RefRadioInformation.General.RadInfoGeneralPrimaryFrequencyBandUHF2_A42547.AddDependentObject(this.radWideTransmitPowerLevelsTxPowerLevelHighW_A8152);
			this.RefRadioInformation.General.RadInfoGeneralPrimaryFrequencyBand700_A42543.AddDependentObject(this.radWideTransmitPowerLevelsTxPowerLevelHighW_A8152);
			this.RefRadioInformation.General.RadInfoGeneralPrimaryFrequencyBand800_A42544.AddDependentObject(this.radWideTransmitPowerLevelsTxPowerLevelHighW_A8152);
			this.RefRadioInformation.General.RadInfoGeneralPrimaryFrequencyBand900_A42548.AddDependentObject(this.radWideTransmitPowerLevelsTxPowerLevelHighW_A8152);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRanges8900MHzUsedinCodeplug_A42502.AddDependentObject(this.radWideTransmitPowerLevelsTxPowerLevelHighW_A8152);
			radioWide.TransmitPowerLevels.RadWideTxPowerLevelsNewBandPlan78MHzBandSelection_A41851.AddDependentObject(this.radWideTransmitPowerLevelsTxPowerLevelHighW_A8152);
			this.RefRadioInformation.Labtool.RadInfoLabtoolPrimaryBands_A23987.AddDependentObject(this.radWideTransmitPowerLevelsTxPowerLevelLowW_A8153);
			this.RefRadioInformation.Labtool.RadInfoLabtoolSecondaryBands_A23988.AddDependentObject(this.radWideTransmitPowerLevelsTxPowerLevelLowW_A8153);
			this.RefRadioInformation.Labtool.RadInfoLabtoolDualBandEnable_A23986.AddDependentObject(this.radWideTransmitPowerLevelsTxPowerLevelLowW_A8153);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesAllowInvalidFrequencies_A12493.AddDependentObject(this.radWideTransmitPowerLevelsTxPowerLevelLowW_A8153);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesVHFUsedinCodeplug_A8481.AddDependentObject(this.radWideTransmitPowerLevelsTxPowerLevelLowW_A8153);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRanges7800MHzUsedinCodeplug_A8512.AddDependentObject(this.radWideTransmitPowerLevelsTxPowerLevelLowW_A8153);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesUHF1UsedinCodeplug_A8504.AddDependentObject(this.radWideTransmitPowerLevelsTxPowerLevelLowW_A8153);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesUHF2UsedinCodeplug_A8507.AddDependentObject(this.radWideTransmitPowerLevelsTxPowerLevelLowW_A8153);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRanges700MHzUsedinCodeplug_A42551.AddDependentObject(this.radWideTransmitPowerLevelsTxPowerLevelLowW_A8153);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRanges800MHzUsedinCodeplug_A42552.AddDependentObject(this.radWideTransmitPowerLevelsTxPowerLevelLowW_A8153);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRanges900MHzUsedinCodeplug_A8516.AddDependentObject(this.radWideTransmitPowerLevelsTxPowerLevelLowW_A8153);
			this.RefRadioInformation.General.RadInfoGeneralPrimaryFrequencyBandVHF_A42545.AddDependentObject(this.radWideTransmitPowerLevelsTxPowerLevelLowW_A8153);
			this.RefRadioInformation.General.RadInfoGeneralPrimaryFrequencyBandUHF1_A42546.AddDependentObject(this.radWideTransmitPowerLevelsTxPowerLevelLowW_A8153);
			this.RefRadioInformation.General.RadInfoGeneralPrimaryFrequencyBandUHF2_A42547.AddDependentObject(this.radWideTransmitPowerLevelsTxPowerLevelLowW_A8153);
			this.RefRadioInformation.General.RadInfoGeneralPrimaryFrequencyBand700_A42543.AddDependentObject(this.radWideTransmitPowerLevelsTxPowerLevelLowW_A8153);
			this.RefRadioInformation.General.RadInfoGeneralPrimaryFrequencyBand800_A42544.AddDependentObject(this.radWideTransmitPowerLevelsTxPowerLevelLowW_A8153);
			this.RefRadioInformation.General.RadInfoGeneralPrimaryFrequencyBand900_A42548.AddDependentObject(this.radWideTransmitPowerLevelsTxPowerLevelLowW_A8153);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRanges8900MHzUsedinCodeplug_A42502.AddDependentObject(this.radWideTransmitPowerLevelsTxPowerLevelLowW_A8153);
			radioWide.TransmitPowerLevels.RadWideTxPowerLevelsNewBandPlan78MHzBandSelection_A41851.AddDependentObject(this.radWideTransmitPowerLevelsTxPowerLevelLowW_A8153);
			this.radWideTransmitPowerLevelsTxPowerLevelMinimumW_A20038.AddDependentObject(this.radWideTransmitPowerLevelsTxPowerLevelLowW_A8153);
			this.radWideTransmitPowerLevelsTxPowerLevelMaximumW_A20039.AddDependentObject(this.radWideTransmitPowerLevelsTxPowerLevelLowW_A8153);
			this.radWideTransmitPowerLevelsTxPowerLevelHighW_A8152.AddDependentObject(this.radWideTransmitPowerLevelsTxPowerLevelLowW_A8153);
			radioWide.TransmitPowerLevels.RadWideTxPowerLevelsNewBandPlan78MHzBandSelection_A41851.AddDependentObject(this.radWideTransmitPowerLevelsFrequencyRangeStartMHz_A19994);
			radioWide.TransmitPowerLevels.RadWideTxPowerLevelsNewBandPlan78MHzBandSelection_A41851.AddDependentObject(this.radWideTransmitPowerLevelsFrequencyRangeEndMHz_A20037);
			radioWide.TransmitPowerLevels.RadWideTxPowerLevelsNewBandPlan78MHzBandSelection_A41851.AddDependentObject(this.radWideTransmitPowerLevelsTxPowerLevelMinimumW_A20038);
			radioWide.TransmitPowerLevels.RadWideTxPowerLevelsNewBandPlan78MHzBandSelection_A41851.AddDependentObject(this.radWideTransmitPowerLevelsTxPowerLevelMaximumW_A20039);
			radioWide.TransmitPowerLevels.RadWideTxPowerLevelsNewBandPlan78MHzBandSelection_A41851.AddDependentObject(this.radWidePowerLevelBandFrequency_A41063);
			radioWide.TransmitPowerLevels.RadWideTxPowerLevelsNewBandPlan78MHzBandSelection_A41851.AddDependentObject(this.radWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41173);
			radioWide.TransmitPowerLevels.RadWideTxPowerLevelsNewBandPlan78MHzBandSelection_A41851.AddDependentObject(this.radWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41174);
			this.RefRadioInformation.Labtool.RadInfoLabtoolPrimaryBands_A23987.AddDependentObject(this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41175);
			this.RefRadioInformation.Labtool.RadInfoLabtoolSecondaryBands_A23988.AddDependentObject(this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41175);
			this.RefRadioInformation.Labtool.RadInfoLabtoolDualBandEnable_A23986.AddDependentObject(this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41175);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesAllowInvalidFrequencies_A12493.AddDependentObject(this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41175);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesVHFUsedinCodeplug_A8481.AddDependentObject(this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41175);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRanges7800MHzUsedinCodeplug_A8512.AddDependentObject(this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41175);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesUHF1UsedinCodeplug_A8504.AddDependentObject(this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41175);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesUHF2UsedinCodeplug_A8507.AddDependentObject(this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41175);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRanges700MHzUsedinCodeplug_A42551.AddDependentObject(this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41175);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRanges800MHzUsedinCodeplug_A42552.AddDependentObject(this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41175);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRanges900MHzUsedinCodeplug_A8516.AddDependentObject(this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41175);
			this.RefRadioInformation.General.RadInfoGeneralPrimaryFrequencyBandVHF_A42545.AddDependentObject(this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41175);
			this.RefRadioInformation.General.RadInfoGeneralPrimaryFrequencyBandUHF1_A42546.AddDependentObject(this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41175);
			this.RefRadioInformation.General.RadInfoGeneralPrimaryFrequencyBandUHF2_A42547.AddDependentObject(this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41175);
			this.RefRadioInformation.General.RadInfoGeneralPrimaryFrequencyBand700_A42543.AddDependentObject(this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41175);
			this.RefRadioInformation.General.RadInfoGeneralPrimaryFrequencyBand800_A42544.AddDependentObject(this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41175);
			this.RefRadioInformation.General.RadInfoGeneralPrimaryFrequencyBand900_A42548.AddDependentObject(this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41175);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRanges8900MHzUsedinCodeplug_A42502.AddDependentObject(this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41175);
			radioWide.TransmitPowerLevels.RadWideTxPowerLevelsNewBandPlan78MHzBandSelection_A41851.AddDependentObject(this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41175);
			this.radWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41173.AddDependentObject(this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41175);
			this.radWideTransmitPowerLevelsTxPowerLevelMaximumW_A20039.AddDependentObject(this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41175);
			this.radWideTransmitPowerLevelsTxPowerLevelHighW_A8152.AddDependentObject(this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41175);
			this.RefRadioInformation.Labtool.RadInfoLabtoolPrimaryBands_A23987.AddDependentObject(this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41176);
			this.RefRadioInformation.Labtool.RadInfoLabtoolSecondaryBands_A23988.AddDependentObject(this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41176);
			this.RefRadioInformation.Labtool.RadInfoLabtoolDualBandEnable_A23986.AddDependentObject(this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41176);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesAllowInvalidFrequencies_A12493.AddDependentObject(this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41176);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesVHFUsedinCodeplug_A8481.AddDependentObject(this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41176);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRanges7800MHzUsedinCodeplug_A8512.AddDependentObject(this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41176);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesUHF1UsedinCodeplug_A8504.AddDependentObject(this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41176);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesUHF2UsedinCodeplug_A8507.AddDependentObject(this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41176);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRanges700MHzUsedinCodeplug_A42551.AddDependentObject(this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41176);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRanges800MHzUsedinCodeplug_A42552.AddDependentObject(this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41176);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRanges900MHzUsedinCodeplug_A8516.AddDependentObject(this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41176);
			this.RefRadioInformation.General.RadInfoGeneralPrimaryFrequencyBandVHF_A42545.AddDependentObject(this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41176);
			this.RefRadioInformation.General.RadInfoGeneralPrimaryFrequencyBandUHF1_A42546.AddDependentObject(this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41176);
			this.RefRadioInformation.General.RadInfoGeneralPrimaryFrequencyBandUHF2_A42547.AddDependentObject(this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41176);
			this.RefRadioInformation.General.RadInfoGeneralPrimaryFrequencyBand700_A42543.AddDependentObject(this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41176);
			this.RefRadioInformation.General.RadInfoGeneralPrimaryFrequencyBand800_A42544.AddDependentObject(this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41176);
			this.RefRadioInformation.General.RadInfoGeneralPrimaryFrequencyBand900_A42548.AddDependentObject(this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41176);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRanges8900MHzUsedinCodeplug_A42502.AddDependentObject(this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41176);
			radioWide.TransmitPowerLevels.RadWideTxPowerLevelsNewBandPlan78MHzBandSelection_A41851.AddDependentObject(this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41176);
			this.radWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41174.AddDependentObject(this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41176);
			this.radWideTransmitPowerLevelsTxPowerLevelMaximumW_A20039.AddDependentObject(this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41176);
			this.radWideTransmitPowerLevelsTxPowerLevelHighW_A8152.AddDependentObject(this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41176);
		}

		// Token: 0x170020DF RID: 8415
		// (get) Token: 0x06004044 RID: 16452 RVA: 0x003C59A0 File Offset: 0x003C3BA0
		public bool HasDiffs
		{
			get
			{
				short num = (short)1550006718;
				short num2 = num;
				num = (short)1899837886;
				switch (num2 == num)
				{
				}
				num = (short)1408630784;
				if (num != 0)
				{
				}
				num = (short)1487405056;
				short num3 = num;
				num = (short)1787756545;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x170020E0 RID: 8416
		// (get) Token: 0x06004045 RID: 16453 RVA: 0x003C5A50 File Offset: 0x003C3C50
		// (set) Token: 0x06004046 RID: 16454 RVA: 0x003C5B04 File Offset: 0x003C3D04
		public int RadWideTransmitPowerLevelsTxPowerLevelHighW_A8152Value
		{
			get
			{
				short num = (short)1890958510;
				short num2 = num;
				num = (short)1404746926;
				switch (num2 == num)
				{
				}
				num = (short)1115160577;
				if (num != 0)
				{
				}
				num = (short)421199872;
				short num3 = num;
				num = (short)392167424;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelHighW_A8152.Value;
			}
			set
			{
				short num = (short)1731978393;
				short num2 = num;
				num = (short)1823663257;
				switch (num2 == num)
				{
				}
				num = (short)162725888;
				if (num != 0)
				{
				}
				num = (short)1205665792;
				short num3 = num;
				num = (short)1848508417;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTxPowerLevelHighW_A8152.Value = value;
			}
		}

		// Token: 0x170020E1 RID: 8417
		// (get) Token: 0x06004047 RID: 16455 RVA: 0x003C5BBC File Offset: 0x003C3DBC
		public global::AcpBusinessLayer.AcpRangeField<int, string> RadWideTransmitPowerLevelsTxPowerLevelHighW_A8152
		{
			get
			{
				short num = (short)1499582492;
				short num2 = num;
				num = (short)528273436;
				switch (num2 == num)
				{
				}
				num = (short)1064828928;
				short num3 = num;
				num = (short)1616576513;
				if (num != 0)
				{
				}
				num = (short)290652160;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelHighW_A8152;
			}
		}

		// Token: 0x170020E2 RID: 8418
		// (get) Token: 0x06004048 RID: 16456 RVA: 0x003C5C6C File Offset: 0x003C3E6C
		// (set) Token: 0x06004049 RID: 16457 RVA: 0x003C5D24 File Offset: 0x003C3F24
		public string RadWideTransmitPowerLevelsTxPowerLevelHighW_A8152_UIValue
		{
			get
			{
				short num = (short)612828986;
				short num2 = num;
				num = (short)1542129466;
				switch (num2 == num)
				{
				}
				num = (short)1877737472;
				short num3 = num;
				num = (short)1224015873;
				if (num != 0)
				{
				}
				num = (short)1886519296;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelHighW_A8152.UIValue;
			}
			set
			{
				short num = (short)2047737857;
				if (num != 0)
				{
				}
				num = (short)1718307608;
				short num2 = num;
				num = (short)232344344;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1801388032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1212022784;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTxPowerLevelHighW_A8152.UIValue = value;
			}
		}

		// Token: 0x170020E3 RID: 8419
		// (get) Token: 0x0600404A RID: 16458 RVA: 0x003C5DD8 File Offset: 0x003C3FD8
		// (set) Token: 0x0600404B RID: 16459 RVA: 0x003C5E90 File Offset: 0x003C4090
		internal int RadWideTransmitPowerLevelsTxPowerLevelHighW_A8152Min
		{
			get
			{
				short num = (short)352660261;
				short num2 = num;
				num = (short)623323941;
				switch (num2 == num)
				{
				}
				num = (short)24969216;
				short num3 = num;
				num = (short)1379532801;
				if (num != 0)
				{
				}
				num = (short)866582528;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelHighW_A8152.Min;
			}
			set
			{
				short num = (short)342097921;
				if (num != 0)
				{
				}
				num = (short)432487964;
				short num2 = num;
				num = (short)2024947228;
				switch (num2 == num)
				{
				default:
				{
					num = (short)131661824;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)485556224;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTxPowerLevelHighW_A8152.Min = value;
			}
		}

		// Token: 0x170020E4 RID: 8420
		// (get) Token: 0x0600404C RID: 16460 RVA: 0x003C5F44 File Offset: 0x003C4144
		// (set) Token: 0x0600404D RID: 16461 RVA: 0x003C5FFC File Offset: 0x003C41FC
		internal int RadWideTransmitPowerLevelsTxPowerLevelHighW_A8152Max
		{
			get
			{
				short num = (short)775225345;
				if (num != 0)
				{
				}
				num = (short)1344053101;
				short num2 = num;
				num = (short)2116591469;
				switch (num2 == num)
				{
				default:
				{
					num = (short)733413376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1660813312;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelHighW_A8152.Max;
			}
			set
			{
				short num = (short)829468329;
				short num2 = num;
				num = (short)1405267625;
				switch (num2 == num)
				{
				}
				num = (short)172228608;
				short num3 = num;
				num = (short)623902721;
				if (num != 0)
				{
				}
				num = (short)214630400;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTxPowerLevelHighW_A8152.Max = value;
			}
		}

		// Token: 0x170020E5 RID: 8421
		// (get) Token: 0x0600404E RID: 16462 RVA: 0x003C60B4 File Offset: 0x003C42B4
		// (set) Token: 0x0600404F RID: 16463 RVA: 0x003C616C File Offset: 0x003C436C
		internal int RadWideTransmitPowerLevelsTxPowerLevelHighW_A8152Step
		{
			get
			{
				short num = (short)1917568795;
				short num2 = num;
				num = (short)1481885467;
				switch (num2 == num)
				{
				}
				num = (short)1587412992;
				short num3 = num;
				num = (short)165412865;
				if (num != 0)
				{
				}
				num = (short)1282015232;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelHighW_A8152.StepSize;
			}
			set
			{
				short num = (short)66912257;
				if (num != 0)
				{
				}
				num = (short)658994263;
				short num2 = num;
				num = (short)783840343;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1462960128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1357971456;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTxPowerLevelHighW_A8152.StepSize = value;
			}
		}

		// Token: 0x170020E6 RID: 8422
		// (get) Token: 0x06004050 RID: 16464 RVA: 0x003C6220 File Offset: 0x003C4420
		// (set) Token: 0x06004051 RID: 16465 RVA: 0x003C62D4 File Offset: 0x003C44D4
		public bool RadWideTransmitPowerLevelsTxPowerLevelHighW_A8152_Applicable
		{
			get
			{
				short num = (short)480642092;
				short num2 = num;
				num = (short)842859564;
				switch (num2 == num)
				{
				}
				num = (short)1222639616;
				short num3 = num;
				num = (short)1716125696;
				if (num != 0)
				{
				}
				num = (short)927465473;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelHighW_A8152.Applicable;
			}
			set
			{
				short num = (short)1862805800;
				short num2 = num;
				num = (short)1919887656;
				switch (num2 == num)
				{
				}
				num = (short)558366720;
				short num3 = num;
				num = (short)608305153;
				if (num != 0)
				{
				}
				num = (short)275447808;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTxPowerLevelHighW_A8152.Applicable = value;
			}
		}

		// Token: 0x170020E7 RID: 8423
		// (get) Token: 0x06004052 RID: 16466 RVA: 0x003C638C File Offset: 0x003C458C
		// (set) Token: 0x06004053 RID: 16467 RVA: 0x003C6440 File Offset: 0x003C4640
		public bool RadWideTransmitPowerLevelsTxPowerLevelHighW_A8152_Valid
		{
			get
			{
				short num = (short)1128052824;
				short num2 = num;
				num = (short)841660504;
				switch (num2 == num)
				{
				}
				num = (short)173342720;
				short num3 = num;
				num = (short)207552512;
				if (num != 0)
				{
				}
				num = (short)36503553;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelHighW_A8152.Valid;
			}
			set
			{
				short num = (short)345317931;
				short num2 = num;
				num = (short)1015030315;
				switch (num2 == num)
				{
				}
				num = (short)1443561472;
				short num3 = num;
				num = (short)379256833;
				if (num != 0)
				{
				}
				num = (short)989003776;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTxPowerLevelHighW_A8152.Valid = value;
			}
		}

		// Token: 0x170020E8 RID: 8424
		// (get) Token: 0x06004054 RID: 16468 RVA: 0x003C64F4 File Offset: 0x003C46F4
		// (set) Token: 0x06004055 RID: 16469 RVA: 0x003C65A8 File Offset: 0x003C47A8
		public bool RadWideTransmitPowerLevelsTxPowerLevelHighW_A8152_Visible
		{
			get
			{
				short num = (short)1603272705;
				if (num != 0)
				{
				}
				num = (short)438379817;
				short num2 = num;
				num = (short)1312433449;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1995898880;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)837025792;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelHighW_A8152.Visible;
			}
			set
			{
				short num = (short)554434561;
				if (num != 0)
				{
				}
				num = (short)1564630613;
				short num2 = num;
				num = (short)1039490645;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1176174592;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)966393856;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTxPowerLevelHighW_A8152.Visible = value;
			}
		}

		// Token: 0x170020E9 RID: 8425
		// (get) Token: 0x06004056 RID: 16470 RVA: 0x003C6660 File Offset: 0x003C4860
		// (set) Token: 0x06004057 RID: 16471 RVA: 0x003C6714 File Offset: 0x003C4914
		public bool RadWideTransmitPowerLevelsTxPowerLevelHighW_A8152_Editable
		{
			get
			{
				short num = (short)539306306;
				short num2 = num;
				num = (short)419572034;
				switch (num2 == num)
				{
				}
				num = (short)1888813056;
				short num3 = num;
				num = (short)1206976512;
				if (num != 0)
				{
				}
				num = (short)1331429377;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelHighW_A8152.Editable;
			}
			set
			{
				short num = (short)1949545636;
				short num2 = num;
				num = (short)255308964;
				switch (num2 == num)
				{
				}
				num = (short)906625024;
				short num3 = num;
				num = (short)655360000;
				if (num != 0)
				{
				}
				num = (short)1293615105;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTxPowerLevelHighW_A8152.Editable = value;
			}
		}

		// Token: 0x170020EA RID: 8426
		// (get) Token: 0x06004058 RID: 16472 RVA: 0x003C67C8 File Offset: 0x003C49C8
		internal string RadWideTransmitPowerLevelsTxPowerLevelHighW_A8152_UILabel
		{
			get
			{
				short num = (short)349014141;
				short num2 = num;
				num = (short)1383237757;
				switch (num2 == num)
				{
				}
				num = (short)1095892992;
				short num3 = num;
				num = (short)876281857;
				if (num != 0)
				{
				}
				num = (short)987627520;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelHighW_A8152.UIName;
			}
		}

		// Token: 0x170020EB RID: 8427
		// (get) Token: 0x06004059 RID: 16473 RVA: 0x003C687C File Offset: 0x003C4A7C
		// (set) Token: 0x0600405A RID: 16474 RVA: 0x003C6930 File Offset: 0x003C4B30
		internal bool RadWideTransmitPowerLevelsTxPowerLevelHighW_A8152_HiddenStatic
		{
			get
			{
				short num = (short)1463143053;
				short num2 = num;
				num = (short)596691597;
				switch (num2 == num)
				{
				}
				num = (short)1358233600;
				short num3 = num;
				num = (short)1158152193;
				if (num != 0)
				{
				}
				num = (short)1827602432;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelHighW_A8152.HiddenStatic;
			}
			set
			{
				short num = (short)1170776961;
				short num2 = num;
				num = (short)2074977153;
				switch (num2 == num)
				{
				}
				num = (short)1778057216;
				short num3 = num;
				num = (short)1799421953;
				if (num != 0)
				{
				}
				num = (short)1432092672;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTxPowerLevelHighW_A8152.HiddenStatic = value;
			}
		}

		// Token: 0x170020EC RID: 8428
		// (get) Token: 0x0600405B RID: 16475 RVA: 0x003C69E4 File Offset: 0x003C4BE4
		// (set) Token: 0x0600405C RID: 16476 RVA: 0x003C6A9C File Offset: 0x003C4C9C
		internal bool RadWideTransmitPowerLevelsTxPowerLevelHighW_A8152_HiddenDynamic
		{
			get
			{
				short num = (short)1447327651;
				short num2 = num;
				num = (short)12416931;
				switch (num2 == num)
				{
				}
				num = (short)1423638528;
				short num3 = num;
				num = (short)1708523520;
				if (num != 0)
				{
				}
				num = (short)938541057;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelHighW_A8152.HiddenDynamic;
			}
			set
			{
				short num = (short)1051556891;
				short num2 = num;
				num = (short)934181915;
				switch (num2 == num)
				{
				}
				num = (short)1661730816;
				short num3 = num;
				num = (short)385548289;
				if (num != 0)
				{
				}
				num = (short)2004615168;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTxPowerLevelHighW_A8152.HiddenDynamic = value;
			}
		}

		// Token: 0x170020ED RID: 8429
		// (get) Token: 0x0600405D RID: 16477 RVA: 0x003C6B50 File Offset: 0x003C4D50
		public bool RadWideTransmitPowerLevelsTxPowerLevelHighW_A8152_HasDiffs
		{
			get
			{
				short num = (short)1700430626;
				short num2 = num;
				num = (short)2110292770;
				switch (num2 == num)
				{
				}
				num = (short)472514560;
				short num3 = num;
				num = (short)1067974657;
				if (num != 0)
				{
				}
				num = (short)1995964416;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelHighW_A8152._HasDiffs;
			}
		}

		// Token: 0x170020EE RID: 8430
		// (get) Token: 0x0600405E RID: 16478 RVA: 0x003C6C04 File Offset: 0x003C4E04
		// (set) Token: 0x0600405F RID: 16479 RVA: 0x003C6CB8 File Offset: 0x003C4EB8
		public int RadWideTransmitPowerLevelsTxPowerLevelLowW_A8153Value
		{
			get
			{
				short num = (short)1863807131;
				short num2 = num;
				num = (short)1342206107;
				switch (num2 == num)
				{
				}
				num = (short)1627127808;
				short num3 = num;
				num = (short)1848705025;
				if (num != 0)
				{
				}
				num = (short)633733120;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelLowW_A8153.Value;
			}
			set
			{
				short num = (short)255191673;
				short num2 = num;
				num = (short)1544153721;
				switch (num2 == num)
				{
				}
				num = (short)424083456;
				short num3 = num;
				num = (short)586743809;
				if (num != 0)
				{
				}
				num = (short)959774720;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTxPowerLevelLowW_A8153.Value = value;
			}
		}

		// Token: 0x170020EF RID: 8431
		// (get) Token: 0x06004060 RID: 16480 RVA: 0x003C6D70 File Offset: 0x003C4F70
		public global::AcpBusinessLayer.AcpRangeField<int, string> RadWideTransmitPowerLevelsTxPowerLevelLowW_A8153
		{
			get
			{
				short num = (short)1827930113;
				if (num != 0)
				{
				}
				num = (short)1979670372;
				short num2 = num;
				num = (short)1879662436;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1362231296;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)833093632;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelLowW_A8153;
			}
		}

		// Token: 0x170020F0 RID: 8432
		// (get) Token: 0x06004061 RID: 16481 RVA: 0x003C6E1C File Offset: 0x003C501C
		// (set) Token: 0x06004062 RID: 16482 RVA: 0x003C6ED4 File Offset: 0x003C50D4
		public string RadWideTransmitPowerLevelsTxPowerLevelLowW_A8153_UIValue
		{
			get
			{
				short num = (short)2126616059;
				short num2 = num;
				num = (short)266311163;
				switch (num2 == num)
				{
				}
				num = (short)1667235840;
				short num3 = num;
				num = (short)28573697;
				if (num != 0)
				{
				}
				num = (short)290062336;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelLowW_A8153.UIValue;
			}
			set
			{
				short num = (short)1517241645;
				short num2 = num;
				num = (short)1960396077;
				switch (num2 == num)
				{
				}
				num = (short)1491468288;
				short num3 = num;
				num = (short)318832641;
				if (num != 0)
				{
				}
				num = (short)1727856640;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTxPowerLevelLowW_A8153.UIValue = value;
			}
		}

		// Token: 0x170020F1 RID: 8433
		// (get) Token: 0x06004063 RID: 16483 RVA: 0x003C6F8C File Offset: 0x003C518C
		// (set) Token: 0x06004064 RID: 16484 RVA: 0x003C7040 File Offset: 0x003C5240
		internal int RadWideTransmitPowerLevelsTxPowerLevelLowW_A8153Min
		{
			get
			{
				short num = (short)851181569;
				if (num != 0)
				{
				}
				num = (short)2097020827;
				short num2 = num;
				num = (short)2011824027;
				switch (num2 == num)
				{
				default:
				{
					num = (short)143917056;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)740163584;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelLowW_A8153.Min;
			}
			set
			{
				short num = (short)1815172620;
				short num2 = num;
				num = (short)1140872716;
				switch (num2 == num)
				{
				}
				num = (short)1032650752;
				short num3 = num;
				num = (short)2070609921;
				if (num != 0)
				{
				}
				num = (short)1251344384;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTxPowerLevelLowW_A8153.Min = value;
			}
		}

		// Token: 0x170020F2 RID: 8434
		// (get) Token: 0x06004065 RID: 16485 RVA: 0x003C70F8 File Offset: 0x003C52F8
		// (set) Token: 0x06004066 RID: 16486 RVA: 0x003C71AC File Offset: 0x003C53AC
		internal int RadWideTransmitPowerLevelsTxPowerLevelLowW_A8153Max
		{
			get
			{
				short num = (short)1236174256;
				short num2 = num;
				num = (short)513967536;
				switch (num2 == num)
				{
				}
				num = (short)1834221568;
				short num3 = num;
				num = (short)989921281;
				if (num != 0)
				{
				}
				num = (short)1146748928;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelLowW_A8153.Max;
			}
			set
			{
				short num = (short)100349827;
				short num2 = num;
				num = (short)755578755;
				switch (num2 == num)
				{
				}
				num = (short)645595136;
				short num3 = num;
				num = (short)1008926721;
				if (num != 0)
				{
				}
				num = (short)1042546688;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTxPowerLevelLowW_A8153.Max = value;
			}
		}

		// Token: 0x170020F3 RID: 8435
		// (get) Token: 0x06004067 RID: 16487 RVA: 0x003C7260 File Offset: 0x003C5460
		// (set) Token: 0x06004068 RID: 16488 RVA: 0x003C7318 File Offset: 0x003C5518
		internal int RadWideTransmitPowerLevelsTxPowerLevelLowW_A8153Step
		{
			get
			{
				short num = (short)182049220;
				short num2 = num;
				num = (short)1962203588;
				switch (num2 == num)
				{
				}
				num = (short)207224832;
				short num3 = num;
				num = (short)934019072;
				if (num != 0)
				{
				}
				num = (short)1530855425;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelLowW_A8153.StepSize;
			}
			set
			{
				short num = (short)207514125;
				short num2 = num;
				num = (short)1681418765;
				switch (num2 == num)
				{
				}
				num = (short)1671364608;
				short num3 = num;
				num = (short)882966529;
				if (num != 0)
				{
				}
				num = (short)892534784;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTxPowerLevelLowW_A8153.StepSize = value;
			}
		}

		// Token: 0x170020F4 RID: 8436
		// (get) Token: 0x06004069 RID: 16489 RVA: 0x003C73CC File Offset: 0x003C55CC
		// (set) Token: 0x0600406A RID: 16490 RVA: 0x003C7480 File Offset: 0x003C5680
		public bool RadWideTransmitPowerLevelsTxPowerLevelLowW_A8153_Applicable
		{
			get
			{
				short num = (short)2122329955;
				short num2 = num;
				num = (short)1768828771;
				switch (num2 == num)
				{
				}
				num = (short)776011776;
				short num3 = num;
				num = (short)1560477697;
				if (num != 0)
				{
				}
				num = (short)1127940096;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelLowW_A8153.Applicable;
			}
			set
			{
				short num = (short)1024681246;
				short num2 = num;
				num = (short)164717854;
				switch (num2 == num)
				{
				}
				num = (short)988676096;
				short num3 = num;
				num = (short)468320257;
				if (num != 0)
				{
				}
				num = (short)1982005248;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTxPowerLevelLowW_A8153.Applicable = value;
			}
		}

		// Token: 0x170020F5 RID: 8437
		// (get) Token: 0x0600406B RID: 16491 RVA: 0x003C7538 File Offset: 0x003C5738
		// (set) Token: 0x0600406C RID: 16492 RVA: 0x003C75EC File Offset: 0x003C57EC
		public bool RadWideTransmitPowerLevelsTxPowerLevelLowW_A8153_Valid
		{
			get
			{
				short num = (short)342360035;
				short num2 = num;
				num = (short)894042083;
				switch (num2 == num)
				{
				}
				num = (short)1951531008;
				short num3 = num;
				num = (short)1598357505;
				if (num != 0)
				{
				}
				num = (short)162791424;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelLowW_A8153.Valid;
			}
			set
			{
				short num = (short)1671783006;
				short num2 = num;
				num = (short)1293771358;
				switch (num2 == num)
				{
				}
				num = (short)1497956352;
				short num3 = num;
				num = (short)92274689;
				if (num != 0)
				{
				}
				num = (short)685113344;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTxPowerLevelLowW_A8153.Valid = value;
			}
		}

		// Token: 0x170020F6 RID: 8438
		// (get) Token: 0x0600406D RID: 16493 RVA: 0x003C76A0 File Offset: 0x003C58A0
		// (set) Token: 0x0600406E RID: 16494 RVA: 0x003C7758 File Offset: 0x003C5958
		public bool RadWideTransmitPowerLevelsTxPowerLevelLowW_A8153_Visible
		{
			get
			{
				short num = (short)545182009;
				short num2 = num;
				num = (short)707252537;
				switch (num2 == num)
				{
				}
				num = (short)126484480;
				short num3 = num;
				num = (short)276955137;
				if (num != 0)
				{
				}
				num = (short)1800994816;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelLowW_A8153.Visible;
			}
			set
			{
				short num = (short)1301348353;
				if (num != 0)
				{
				}
				num = (short)969972238;
				short num2 = num;
				num = (short)2117310990;
				switch (num2 == num)
				{
				default:
				{
					num = (short)227409920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)570949632;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTxPowerLevelLowW_A8153.Visible = value;
			}
		}

		// Token: 0x170020F7 RID: 8439
		// (get) Token: 0x0600406F RID: 16495 RVA: 0x003C780C File Offset: 0x003C5A0C
		// (set) Token: 0x06004070 RID: 16496 RVA: 0x003C78C0 File Offset: 0x003C5AC0
		public bool RadWideTransmitPowerLevelsTxPowerLevelLowW_A8153_Editable
		{
			get
			{
				short num = (short)2112704295;
				short num2 = num;
				num = (short)333008679;
				switch (num2 == num)
				{
				}
				num = (short)131072;
				short num3 = num;
				num = (short)1252065280;
				if (num != 0)
				{
				}
				num = (short)188350465;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelLowW_A8153.Editable;
			}
			set
			{
				short num = (short)1723501228;
				short num2 = num;
				num = (short)413436588;
				switch (num2 == num)
				{
				}
				num = (short)995885056;
				short num3 = num;
				num = (short)165806081;
				if (num != 0)
				{
				}
				num = (short)256180224;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTxPowerLevelLowW_A8153.Editable = value;
			}
		}

		// Token: 0x170020F8 RID: 8440
		// (get) Token: 0x06004071 RID: 16497 RVA: 0x003C7978 File Offset: 0x003C5B78
		internal string RadWideTransmitPowerLevelsTxPowerLevelLowW_A8153_UILabel
		{
			get
			{
				short num = (short)88397742;
				short num2 = num;
				num = (short)1702156206;
				switch (num2 == num)
				{
				}
				num = (short)633929728;
				short num3 = num;
				num = (short)165412865;
				if (num != 0)
				{
				}
				num = (short)1042677760;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelLowW_A8153.UIName;
			}
		}

		// Token: 0x170020F9 RID: 8441
		// (get) Token: 0x06004072 RID: 16498 RVA: 0x003C7A30 File Offset: 0x003C5C30
		// (set) Token: 0x06004073 RID: 16499 RVA: 0x003C7AE4 File Offset: 0x003C5CE4
		internal bool RadWideTransmitPowerLevelsTxPowerLevelLowW_A8153_HiddenStatic
		{
			get
			{
				short num = (short)88195206;
				short num2 = num;
				num = (short)2064957574;
				switch (num2 == num)
				{
				}
				num = (short)1892089856;
				short num3 = num;
				num = (short)1510539265;
				if (num != 0)
				{
				}
				num = (short)1657339904;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelLowW_A8153.HiddenStatic;
			}
			set
			{
				short num = (short)2037776697;
				short num2 = num;
				num = (short)1413284153;
				switch (num2 == num)
				{
				}
				num = (short)1176305664;
				short num3 = num;
				num = (short)1738735617;
				if (num != 0)
				{
				}
				num = (short)261685248;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTxPowerLevelLowW_A8153.HiddenStatic = value;
			}
		}

		// Token: 0x170020FA RID: 8442
		// (get) Token: 0x06004074 RID: 16500 RVA: 0x003C7B98 File Offset: 0x003C5D98
		// (set) Token: 0x06004075 RID: 16501 RVA: 0x003C7C50 File Offset: 0x003C5E50
		internal bool RadWideTransmitPowerLevelsTxPowerLevelLowW_A8153_HiddenDynamic
		{
			get
			{
				short num = (short)1164462433;
				short num2 = num;
				num = (short)195381601;
				switch (num2 == num)
				{
				}
				num = (short)155451392;
				short num3 = num;
				num = (short)1987117056;
				if (num != 0)
				{
				}
				num = (short)1082392577;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelLowW_A8153.HiddenDynamic;
			}
			set
			{
				short num = (short)2108264487;
				short num2 = num;
				num = (short)1457098791;
				switch (num2 == num)
				{
				}
				num = (short)1545797632;
				short num3 = num;
				num = (short)1465253889;
				if (num != 0)
				{
				}
				num = (short)93782016;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTxPowerLevelLowW_A8153.HiddenDynamic = value;
			}
		}

		// Token: 0x170020FB RID: 8443
		// (get) Token: 0x06004076 RID: 16502 RVA: 0x003C7D04 File Offset: 0x003C5F04
		public bool RadWideTransmitPowerLevelsTxPowerLevelLowW_A8153_HasDiffs
		{
			get
			{
				short num = (short)2016866873;
				short num2 = num;
				num = (short)736162361;
				switch (num2 == num)
				{
				}
				num = (short)794624000;
				short num3 = num;
				num = (short)237502465;
				if (num != 0)
				{
				}
				num = (short)974585856;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelLowW_A8153._HasDiffs;
			}
		}

		// Token: 0x170020FC RID: 8444
		// (get) Token: 0x06004077 RID: 16503 RVA: 0x003C7DB8 File Offset: 0x003C5FB8
		// (set) Token: 0x06004078 RID: 16504 RVA: 0x003C7E6C File Offset: 0x003C606C
		public int RadWideTransmitPowerLevelsFrequencyRangeStartMHz_A19994Value
		{
			get
			{
				short num = (short)1752751037;
				short num2 = num;
				num = (short)1702681533;
				switch (num2 == num)
				{
				}
				num = (short)1887764480;
				short num3 = num;
				num = (short)1465778176;
				if (num != 0)
				{
				}
				num = (short)1064632321;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsFrequencyRangeStartMHz_A19994.Value;
			}
			set
			{
				short num = (short)1846910167;
				short num2 = num;
				num = (short)1851563223;
				switch (num2 == num)
				{
				}
				num = (short)570228736;
				short num3 = num;
				num = (short)1004142593;
				if (num != 0)
				{
				}
				num = (short)160432128;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsFrequencyRangeStartMHz_A19994.Value = value;
			}
		}

		// Token: 0x170020FD RID: 8445
		// (get) Token: 0x06004079 RID: 16505 RVA: 0x003C7F24 File Offset: 0x003C6124
		// (set) Token: 0x0600407A RID: 16506 RVA: 0x003C7FD8 File Offset: 0x003C61D8
		public string RadWideTransmitPowerLevelsFrequencyRangeStartMHz_A19994_UIValue
		{
			get
			{
				short num = (short)1434877517;
				short num2 = num;
				num = (short)1374453325;
				switch (num2 == num)
				{
				}
				num = (short)1629552640;
				short num3 = num;
				num = (short)2038300672;
				if (num != 0)
				{
				}
				num = (short)619249665;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsFrequencyRangeStartMHz_A19994.UIValue;
			}
			set
			{
				short num = (short)1725383806;
				short num2 = num;
				num = (short)1787249790;
				switch (num2 == num)
				{
				}
				num = (short)1339359232;
				short num3 = num;
				num = (short)92274689;
				if (num != 0)
				{
				}
				num = (short)139722752;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsFrequencyRangeStartMHz_A19994.UIValue = value;
			}
		}

		// Token: 0x170020FE RID: 8446
		// (get) Token: 0x0600407B RID: 16507 RVA: 0x003C808C File Offset: 0x003C628C
		public global::AcpBusinessLayer.AcpFrequencyField RadWideTransmitPowerLevelsFrequencyRangeStartMHz_A19994
		{
			get
			{
				short num = (short)552496944;
				short num2 = num;
				num = (short)331378480;
				switch (num2 == num)
				{
				}
				num = (short)1728643072;
				short num3 = num;
				num = (short)521011201;
				if (num != 0)
				{
				}
				num = (short)1844314112;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsFrequencyRangeStartMHz_A19994;
			}
		}

		// Token: 0x170020FF RID: 8447
		// (get) Token: 0x0600407C RID: 16508 RVA: 0x003C8140 File Offset: 0x003C6340
		// (set) Token: 0x0600407D RID: 16509 RVA: 0x003C81F4 File Offset: 0x003C63F4
		internal int RadWideTransmitPowerLevelsFrequencyRangeStartMHz_A19994Min
		{
			get
			{
				short num = (short)217585965;
				short num2 = num;
				num = (short)2017270061;
				switch (num2 == num)
				{
				}
				num = (short)1875378177;
				if (num != 0)
				{
				}
				num = (short)760872960;
				if (num != 0)
				{
				}
				num = (short)311230464;
				short num3 = num;
				return this.radWideTransmitPowerLevelsFrequencyRangeStartMHz_A19994.Min;
			}
			set
			{
				short num = (short)1716088054;
				short num2 = num;
				num = (short)1609526518;
				switch (num2 == num)
				{
				}
				num = (short)28246016;
				if (num != 0)
				{
				}
				num = (short)493813761;
				if (num != 0)
				{
				}
				num = (short)579469312;
				short num3 = num;
				this.radWideTransmitPowerLevelsFrequencyRangeStartMHz_A19994.Min = value;
			}
		}

		// Token: 0x17002100 RID: 8448
		// (get) Token: 0x0600407E RID: 16510 RVA: 0x003C82A8 File Offset: 0x003C64A8
		// (set) Token: 0x0600407F RID: 16511 RVA: 0x003C835C File Offset: 0x003C655C
		internal int RadWideTransmitPowerLevelsFrequencyRangeStartMHz_A19994Max
		{
			get
			{
				short num = (short)1705661440;
				short num2 = num;
				num = (short)758993920;
				switch (num2 == num)
				{
				}
				num = (short)1872363520;
				if (num != 0)
				{
				}
				num = (short)736493569;
				if (num != 0)
				{
				}
				num = (short)1795817472;
				short num3 = num;
				return this.radWideTransmitPowerLevelsFrequencyRangeStartMHz_A19994.Max;
			}
			set
			{
				short num = (short)2133065729;
				if (num != 0)
				{
				}
				num = (short)864912407;
				short num2 = num;
				num = (short)1740669975;
				switch (num2 == num)
				{
				}
				num = (short)888143872;
				if (num != 0)
				{
				}
				num = (short)1333329920;
				short num3 = num;
				this.radWideTransmitPowerLevelsFrequencyRangeStartMHz_A19994.Max = value;
			}
		}

		// Token: 0x17002101 RID: 8449
		// (get) Token: 0x06004080 RID: 16512 RVA: 0x003C8410 File Offset: 0x003C6610
		// (set) Token: 0x06004081 RID: 16513 RVA: 0x003C84C4 File Offset: 0x003C66C4
		internal int RadWideTransmitPowerLevelsFrequencyRangeStartMHz_A19994Step
		{
			get
			{
				short num = (short)1088346748;
				short num2 = num;
				num = (short)526178940;
				switch (num2 == num)
				{
				}
				num = (short)316473344;
				if (num != 0)
				{
				}
				num = (short)2119499777;
				if (num != 0)
				{
				}
				num = (short)450297856;
				short num3 = num;
				return this.radWideTransmitPowerLevelsFrequencyRangeStartMHz_A19994.StepSize;
			}
			set
			{
				short num = (short)469385388;
				short num2 = num;
				num = (short)1492795564;
				switch (num2 == num)
				{
				}
				num = (short)625278977;
				if (num != 0)
				{
				}
				num = (short)708509696;
				if (num != 0)
				{
				}
				num = (short)380239872;
				short num3 = num;
				this.radWideTransmitPowerLevelsFrequencyRangeStartMHz_A19994.StepSize = value;
			}
		}

		// Token: 0x17002102 RID: 8450
		// (get) Token: 0x06004082 RID: 16514 RVA: 0x003C8578 File Offset: 0x003C6778
		// (set) Token: 0x06004083 RID: 16515 RVA: 0x003C862C File Offset: 0x003C682C
		public bool RadWideTransmitPowerLevelsFrequencyRangeStartMHz_A19994_Applicable
		{
			get
			{
				short num = (short)1210646529;
				if (num != 0)
				{
				}
				num = (short)2077613751;
				short num2 = num;
				num = (short)905764535;
				switch (num2 == num)
				{
				}
				num = (short)121962496;
				if (num != 0)
				{
				}
				num = (short)688062464;
				short num3 = num;
				return this.radWideTransmitPowerLevelsFrequencyRangeStartMHz_A19994.Applicable;
			}
			set
			{
				short num = (short)1966606705;
				short num2 = num;
				num = (short)1296173425;
				switch (num2 == num)
				{
				}
				num = (short)1411579905;
				if (num != 0)
				{
				}
				num = (short)1943928832;
				if (num != 0)
				{
				}
				num = (short)578748416;
				short num3 = num;
				this.radWideTransmitPowerLevelsFrequencyRangeStartMHz_A19994.Applicable = value;
			}
		}

		// Token: 0x17002103 RID: 8451
		// (get) Token: 0x06004084 RID: 16516 RVA: 0x003C86E0 File Offset: 0x003C68E0
		// (set) Token: 0x06004085 RID: 16517 RVA: 0x003C8794 File Offset: 0x003C6994
		public bool RadWideTransmitPowerLevelsFrequencyRangeStartMHz_A19994_Valid
		{
			get
			{
				short num = (short)1275947387;
				short num2 = num;
				num = (short)647784827;
				switch (num2 == num)
				{
				}
				num = (short)2129657856;
				if (num != 0)
				{
				}
				num = (short)616431617;
				if (num != 0)
				{
				}
				num = (short)616300544;
				short num3 = num;
				return this.radWideTransmitPowerLevelsFrequencyRangeStartMHz_A19994.Valid;
			}
			set
			{
				short num = (short)695650176;
				short num2 = num;
				num = (short)2063124352;
				switch (num2 == num)
				{
				}
				num = (short)1700200449;
				if (num != 0)
				{
				}
				num = (short)1940324352;
				if (num != 0)
				{
				}
				num = (short)649920512;
				short num3 = num;
				this.radWideTransmitPowerLevelsFrequencyRangeStartMHz_A19994.Valid = value;
			}
		}

		// Token: 0x17002104 RID: 8452
		// (get) Token: 0x06004086 RID: 16518 RVA: 0x003C8848 File Offset: 0x003C6A48
		// (set) Token: 0x06004087 RID: 16519 RVA: 0x003C88FC File Offset: 0x003C6AFC
		public bool RadWideTransmitPowerLevelsFrequencyRangeStartMHz_A19994_Visible
		{
			get
			{
				short num = (short)1872633419;
				short num2 = num;
				num = (short)2089950795;
				switch (num2 == num)
				{
				}
				num = (short)1787232257;
				if (num != 0)
				{
				}
				num = (short)1739849728;
				if (num != 0)
				{
				}
				num = (short)140247040;
				short num3 = num;
				return this.radWideTransmitPowerLevelsFrequencyRangeStartMHz_A19994.Visible;
			}
			set
			{
				short num = (short)561806971;
				short num2 = num;
				num = (short)1940815483;
				switch (num2 == num)
				{
				}
				num = (short)3080193;
				if (num != 0)
				{
				}
				num = (short)679084032;
				if (num != 0)
				{
				}
				num = (short)1996816384;
				short num3 = num;
				this.radWideTransmitPowerLevelsFrequencyRangeStartMHz_A19994.Visible = value;
			}
		}

		// Token: 0x17002105 RID: 8453
		// (get) Token: 0x06004088 RID: 16520 RVA: 0x003C89B4 File Offset: 0x003C6BB4
		// (set) Token: 0x06004089 RID: 16521 RVA: 0x003C8A68 File Offset: 0x003C6C68
		public bool RadWideTransmitPowerLevelsFrequencyRangeStartMHz_A19994_Editable
		{
			get
			{
				short num = (short)306049444;
				short num2 = num;
				num = (short)1165685156;
				switch (num2 == num)
				{
				}
				num = (short)1490223105;
				if (num != 0)
				{
				}
				num = (short)1117913088;
				if (num != 0)
				{
				}
				num = (short)1455357952;
				short num3 = num;
				return this.radWideTransmitPowerLevelsFrequencyRangeStartMHz_A19994.Editable;
			}
			set
			{
				short num = (short)1559355028;
				short num2 = num;
				num = (short)10411668;
				switch (num2 == num)
				{
				}
				num = (short)1993146368;
				if (num != 0)
				{
				}
				num = (short)1440743425;
				if (num != 0)
				{
				}
				num = (short)1744568320;
				short num3 = num;
				this.radWideTransmitPowerLevelsFrequencyRangeStartMHz_A19994.Editable = value;
			}
		}

		// Token: 0x17002106 RID: 8454
		// (get) Token: 0x0600408A RID: 16522 RVA: 0x003C8B1C File Offset: 0x003C6D1C
		internal string RadWideTransmitPowerLevelsFrequencyRangeStartMHz_A19994_UILabel
		{
			get
			{
				short num = (short)193378333;
				short num2 = num;
				num = (short)1846786077;
				switch (num2 == num)
				{
				}
				num = (short)925368321;
				if (num != 0)
				{
				}
				num = (short)1693515776;
				if (num != 0)
				{
				}
				num = (short)1081868288;
				short num3 = num;
				return this.radWideTransmitPowerLevelsFrequencyRangeStartMHz_A19994.UIName;
			}
		}

		// Token: 0x17002107 RID: 8455
		// (get) Token: 0x0600408B RID: 16523 RVA: 0x003C8BD0 File Offset: 0x003C6DD0
		// (set) Token: 0x0600408C RID: 16524 RVA: 0x003C8C84 File Offset: 0x003C6E84
		internal bool RadWideTransmitPowerLevelsFrequencyRangeStartMHz_A19994_HiddenStatic
		{
			get
			{
				short num = (short)1163982278;
				short num2 = num;
				num = (short)1111553478;
				switch (num2 == num)
				{
				}
				num = (short)1143209985;
				if (num != 0)
				{
				}
				num = (short)617611264;
				if (num != 0)
				{
				}
				num = (short)1262026752;
				short num3 = num;
				return this.radWideTransmitPowerLevelsFrequencyRangeStartMHz_A19994.HiddenStatic;
			}
			set
			{
				short num = (short)21756214;
				short num2 = num;
				num = (short)750319926;
				switch (num2 == num)
				{
				}
				num = (short)633995264;
				if (num != 0)
				{
				}
				num = (short)681115649;
				if (num != 0)
				{
				}
				num = (short)81461248;
				short num3 = num;
				this.radWideTransmitPowerLevelsFrequencyRangeStartMHz_A19994.HiddenStatic = value;
			}
		}

		// Token: 0x17002108 RID: 8456
		// (get) Token: 0x0600408D RID: 16525 RVA: 0x003C8D38 File Offset: 0x003C6F38
		// (set) Token: 0x0600408E RID: 16526 RVA: 0x003C8DEC File Offset: 0x003C6FEC
		internal bool RadWideTransmitPowerLevelsFrequencyRangeStartMHz_A19994_HiddenDynamic
		{
			get
			{
				short num = (short)1490823519;
				short num2 = num;
				num = (short)1717315935;
				switch (num2 == num)
				{
				}
				num = (short)1786445825;
				if (num != 0)
				{
				}
				num = (short)2005532672;
				if (num != 0)
				{
				}
				num = (short)835256320;
				short num3 = num;
				return this.radWideTransmitPowerLevelsFrequencyRangeStartMHz_A19994.HiddenDynamic;
			}
			set
			{
				short num = (short)1891586629;
				short num2 = num;
				num = (short)977883717;
				switch (num2 == num)
				{
				}
				num = (short)1237123073;
				if (num != 0)
				{
				}
				num = (short)681377792;
				if (num != 0)
				{
				}
				num = (short)784007168;
				short num3 = num;
				this.radWideTransmitPowerLevelsFrequencyRangeStartMHz_A19994.HiddenDynamic = value;
			}
		}

		// Token: 0x17002109 RID: 8457
		// (get) Token: 0x0600408F RID: 16527 RVA: 0x003C8EA0 File Offset: 0x003C70A0
		public bool RadWideTransmitPowerLevelsFrequencyRangeStartMHz_A19994_HasDiffs
		{
			get
			{
				short num = (short)1367455556;
				short num2 = num;
				num = (short)1992996676;
				switch (num2 == num)
				{
				}
				num = (short)443023360;
				if (num != 0)
				{
				}
				num = (short)1341128705;
				if (num != 0)
				{
				}
				num = (short)623968256;
				short num3 = num;
				return this.radWideTransmitPowerLevelsFrequencyRangeStartMHz_A19994._HasDiffs;
			}
		}

		// Token: 0x1700210A RID: 8458
		// (get) Token: 0x06004090 RID: 16528 RVA: 0x003C8F54 File Offset: 0x003C7154
		// (set) Token: 0x06004091 RID: 16529 RVA: 0x003C9008 File Offset: 0x003C7208
		public int RadWideTransmitPowerLevelsFrequencyRangeEndMHz_A20037Value
		{
			get
			{
				short num = (short)1249390719;
				short num2 = num;
				num = (short)2095067263;
				switch (num2 == num)
				{
				}
				num = (short)1848377345;
				if (num != 0)
				{
				}
				num = (short)1866072064;
				if (num != 0)
				{
				}
				num = (short)1958936576;
				short num3 = num;
				return this.radWideTransmitPowerLevelsFrequencyRangeEndMHz_A20037.Value;
			}
			set
			{
				short num = (short)1412387929;
				short num2 = num;
				num = (short)1685017689;
				switch (num2 == num)
				{
				}
				num = (short)1305739265;
				if (num != 0)
				{
				}
				num = (short)1473839104;
				if (num != 0)
				{
				}
				num = (short)264896512;
				short num3 = num;
				this.radWideTransmitPowerLevelsFrequencyRangeEndMHz_A20037.Value = value;
			}
		}

		// Token: 0x1700210B RID: 8459
		// (get) Token: 0x06004092 RID: 16530 RVA: 0x003C90C0 File Offset: 0x003C72C0
		// (set) Token: 0x06004093 RID: 16531 RVA: 0x003C9174 File Offset: 0x003C7374
		public string RadWideTransmitPowerLevelsFrequencyRangeEndMHz_A20037_UIValue
		{
			get
			{
				short num = (short)1451093238;
				short num2 = num;
				num = (short)1464986870;
				switch (num2 == num)
				{
				}
				num = (short)1374158849;
				if (num != 0)
				{
				}
				num = (short)2107310080;
				if (num != 0)
				{
				}
				num = (short)1204682752;
				short num3 = num;
				return this.radWideTransmitPowerLevelsFrequencyRangeEndMHz_A20037.UIValue;
			}
			set
			{
				short num = (short)1077388396;
				short num2 = num;
				num = (short)864003180;
				switch (num2 == num)
				{
				}
				num = (short)2059927552;
				if (num != 0)
				{
				}
				num = (short)389545985;
				if (num != 0)
				{
				}
				num = (short)439877632;
				short num3 = num;
				this.radWideTransmitPowerLevelsFrequencyRangeEndMHz_A20037.UIValue = value;
			}
		}

		// Token: 0x1700210C RID: 8460
		// (get) Token: 0x06004094 RID: 16532 RVA: 0x003C9228 File Offset: 0x003C7428
		public global::AcpBusinessLayer.AcpFrequencyField RadWideTransmitPowerLevelsFrequencyRangeEndMHz_A20037
		{
			get
			{
				short num = (short)1211170817;
				if (num != 0)
				{
				}
				num = (short)204915356;
				short num2 = num;
				num = (short)1170391708;
				switch (num2 == num)
				{
				}
				num = (short)487129088;
				if (num != 0)
				{
				}
				num = (short)393347072;
				short num3 = num;
				return this.radWideTransmitPowerLevelsFrequencyRangeEndMHz_A20037;
			}
		}

		// Token: 0x1700210D RID: 8461
		// (get) Token: 0x06004095 RID: 16533 RVA: 0x003C92D8 File Offset: 0x003C74D8
		// (set) Token: 0x06004096 RID: 16534 RVA: 0x003C938C File Offset: 0x003C758C
		internal int RadWideTransmitPowerLevelsFrequencyRangeEndMHz_A20037Min
		{
			get
			{
				short num = (short)2115202914;
				short num2 = num;
				num = (short)334917474;
				switch (num2 == num)
				{
				}
				num = (short)409337856;
				if (num != 0)
				{
				}
				num = (short)1751777281;
				if (num != 0)
				{
				}
				num = (short)1449328640;
				short num3 = num;
				return this.radWideTransmitPowerLevelsFrequencyRangeEndMHz_A20037.Min;
			}
			set
			{
				short num = (short)1798021400;
				short num2 = num;
				num = (short)1671209240;
				switch (num2 == num)
				{
				}
				num = (short)1191116801;
				if (num != 0)
				{
				}
				num = (short)513212416;
				if (num != 0)
				{
				}
				num = (short)176881664;
				short num3 = num;
				this.radWideTransmitPowerLevelsFrequencyRangeEndMHz_A20037.Min = value;
			}
		}

		// Token: 0x1700210E RID: 8462
		// (get) Token: 0x06004097 RID: 16535 RVA: 0x003C9440 File Offset: 0x003C7640
		// (set) Token: 0x06004098 RID: 16536 RVA: 0x003C94F4 File Offset: 0x003C76F4
		internal int RadWideTransmitPowerLevelsFrequencyRangeEndMHz_A20037Max
		{
			get
			{
				short num = (short)1377029949;
				short num2 = num;
				num = (short)1875038013;
				switch (num2 == num)
				{
				}
				num = (short)1335885824;
				if (num != 0)
				{
				}
				num = (short)1646198785;
				if (num != 0)
				{
				}
				num = (short)1878851584;
				short num3 = num;
				return this.radWideTransmitPowerLevelsFrequencyRangeEndMHz_A20037.Max;
			}
			set
			{
				short num = (short)917897217;
				if (num != 0)
				{
				}
				num = (short)17277890;
				short num2 = num;
				num = (short)1528865730;
				switch (num2 == num)
				{
				}
				num = (short)901316608;
				if (num != 0)
				{
				}
				num = (short)247332864;
				short num3 = num;
				this.radWideTransmitPowerLevelsFrequencyRangeEndMHz_A20037.Max = value;
			}
		}

		// Token: 0x1700210F RID: 8463
		// (get) Token: 0x06004099 RID: 16537 RVA: 0x003C95A8 File Offset: 0x003C77A8
		// (set) Token: 0x0600409A RID: 16538 RVA: 0x003C965C File Offset: 0x003C785C
		internal int RadWideTransmitPowerLevelsFrequencyRangeEndMHz_A20037Step
		{
			get
			{
				short num = (short)1985636720;
				short num2 = num;
				num = (short)1997564272;
				switch (num2 == num)
				{
				}
				num = (short)2143092737;
				if (num != 0)
				{
				}
				num = (short)61538304;
				if (num != 0)
				{
				}
				num = (short)1119813632;
				short num3 = num;
				return this.radWideTransmitPowerLevelsFrequencyRangeEndMHz_A20037.StepSize;
			}
			set
			{
				short num = (short)1039426244;
				short num2 = num;
				num = (short)1673224900;
				switch (num2 == num)
				{
				}
				num = (short)1236729857;
				if (num != 0)
				{
				}
				num = (short)2040397824;
				if (num != 0)
				{
				}
				num = (short)1934688256;
				short num3 = num;
				this.radWideTransmitPowerLevelsFrequencyRangeEndMHz_A20037.StepSize = value;
			}
		}

		// Token: 0x17002110 RID: 8464
		// (get) Token: 0x0600409B RID: 16539 RVA: 0x003C9710 File Offset: 0x003C7910
		// (set) Token: 0x0600409C RID: 16540 RVA: 0x003C97C8 File Offset: 0x003C79C8
		public bool RadWideTransmitPowerLevelsFrequencyRangeEndMHz_A20037_Applicable
		{
			get
			{
				short num = (short)1639503806;
				short num2 = num;
				num = (short)1029822398;
				switch (num2 == num)
				{
				}
				num = (short)1597702144;
				if (num != 0)
				{
				}
				num = (short)104792065;
				if (num != 0)
				{
				}
				num = (short)1600192512;
				short num3 = num;
				return this.radWideTransmitPowerLevelsFrequencyRangeEndMHz_A20037.Applicable;
			}
			set
			{
				short num = (short)2093826354;
				short num2 = num;
				num = (short)1832010034;
				switch (num2 == num)
				{
				}
				num = (short)746520576;
				if (num != 0)
				{
				}
				num = (short)169148417;
				if (num != 0)
				{
				}
				num = (short)583663616;
				short num3 = num;
				this.radWideTransmitPowerLevelsFrequencyRangeEndMHz_A20037.Applicable = value;
			}
		}

		// Token: 0x17002111 RID: 8465
		// (get) Token: 0x0600409D RID: 16541 RVA: 0x003C9880 File Offset: 0x003C7A80
		// (set) Token: 0x0600409E RID: 16542 RVA: 0x003C9934 File Offset: 0x003C7B34
		public bool RadWideTransmitPowerLevelsFrequencyRangeEndMHz_A20037_Valid
		{
			get
			{
				short num = (short)1879033939;
				short num2 = num;
				num = (short)1018611795;
				switch (num2 == num)
				{
				}
				num = (short)575209473;
				if (num != 0)
				{
				}
				num = (short)735182848;
				if (num != 0)
				{
				}
				num = (short)1703149568;
				short num3 = num;
				return this.radWideTransmitPowerLevelsFrequencyRangeEndMHz_A20037.Valid;
			}
			set
			{
				short num = (short)1280884886;
				short num2 = num;
				num = (short)1832698006;
				switch (num2 == num)
				{
				}
				num = (short)582483969;
				if (num != 0)
				{
				}
				num = (short)700448768;
				if (num != 0)
				{
				}
				num = (short)1477115904;
				short num3 = num;
				this.radWideTransmitPowerLevelsFrequencyRangeEndMHz_A20037.Valid = value;
			}
		}

		// Token: 0x17002112 RID: 8466
		// (get) Token: 0x0600409F RID: 16543 RVA: 0x003C99E8 File Offset: 0x003C7BE8
		// (set) Token: 0x060040A0 RID: 16544 RVA: 0x003C9A9C File Offset: 0x003C7C9C
		public bool RadWideTransmitPowerLevelsFrequencyRangeEndMHz_A20037_Visible
		{
			get
			{
				short num = (short)890764567;
				short num2 = num;
				num = (short)838925591;
				switch (num2 == num)
				{
				}
				num = (short)1780809729;
				if (num != 0)
				{
				}
				num = (short)1326186496;
				if (num != 0)
				{
				}
				num = (short)662831104;
				short num3 = num;
				return this.radWideTransmitPowerLevelsFrequencyRangeEndMHz_A20037.Visible;
			}
			set
			{
				short num = (short)1777458018;
				short num2 = num;
				num = (short)774364002;
				switch (num2 == num)
				{
				}
				num = (short)100073472;
				if (num != 0)
				{
				}
				num = (short)1736376320;
				short num3 = num;
				num = (short)1142161409;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsFrequencyRangeEndMHz_A20037.Visible = value;
			}
		}

		// Token: 0x17002113 RID: 8467
		// (get) Token: 0x060040A1 RID: 16545 RVA: 0x003C9B50 File Offset: 0x003C7D50
		// (set) Token: 0x060040A2 RID: 16546 RVA: 0x003C9C04 File Offset: 0x003C7E04
		public bool RadWideTransmitPowerLevelsFrequencyRangeEndMHz_A20037_Editable
		{
			get
			{
				short num = (short)1210900743;
				short num2 = num;
				num = (short)1637146887;
				switch (num2 == num)
				{
				}
				num = (short)111869953;
				if (num != 0)
				{
				}
				num = (short)2056912896;
				short num3 = num;
				num = (short)1894907904;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsFrequencyRangeEndMHz_A20037.Editable;
			}
			set
			{
				short num = (short)1503536486;
				short num2 = num;
				num = (short)1507009894;
				switch (num2 == num)
				{
				}
				num = (short)1399717889;
				if (num != 0)
				{
				}
				num = (short)1616773120;
				short num3 = num;
				num = (short)60096512;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsFrequencyRangeEndMHz_A20037.Editable = value;
			}
		}

		// Token: 0x17002114 RID: 8468
		// (get) Token: 0x060040A3 RID: 16547 RVA: 0x003C9CBC File Offset: 0x003C7EBC
		internal string RadWideTransmitPowerLevelsFrequencyRangeEndMHz_A20037_UILabel
		{
			get
			{
				short num = (short)523379121;
				short num2 = num;
				num = (short)514662833;
				switch (num2 == num)
				{
				}
				num = (short)2106392576;
				if (num != 0)
				{
				}
				num = (short)1505951744;
				short num3 = num;
				num = (short)416284673;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsFrequencyRangeEndMHz_A20037.UIName;
			}
		}

		// Token: 0x17002115 RID: 8469
		// (get) Token: 0x060040A4 RID: 16548 RVA: 0x003C9D70 File Offset: 0x003C7F70
		// (set) Token: 0x060040A5 RID: 16549 RVA: 0x003C9E24 File Offset: 0x003C8024
		internal bool RadWideTransmitPowerLevelsFrequencyRangeEndMHz_A20037_HiddenStatic
		{
			get
			{
				short num = (short)1722544769;
				short num2 = num;
				num = (short)888009345;
				switch (num2 == num)
				{
				}
				num = (short)841678849;
				if (num != 0)
				{
				}
				num = (short)349241344;
				short num3 = num;
				num = (short)1293680640;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsFrequencyRangeEndMHz_A20037.HiddenStatic;
			}
			set
			{
				short num = (short)376737949;
				short num2 = num;
				num = (short)1267044509;
				switch (num2 == num)
				{
				}
				num = (short)1085603841;
				if (num != 0)
				{
				}
				num = (short)10027008;
				short num3 = num;
				num = (short)1716518912;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsFrequencyRangeEndMHz_A20037.HiddenStatic = value;
			}
		}

		// Token: 0x17002116 RID: 8470
		// (get) Token: 0x060040A6 RID: 16550 RVA: 0x003C9ED8 File Offset: 0x003C80D8
		// (set) Token: 0x060040A7 RID: 16551 RVA: 0x003C9F8C File Offset: 0x003C818C
		internal bool RadWideTransmitPowerLevelsFrequencyRangeEndMHz_A20037_HiddenDynamic
		{
			get
			{
				short num = (short)1638137857;
				if (num != 0)
				{
				}
				num = (short)206628267;
				short num2 = num;
				num = (short)2066212267;
				switch (num2 == num)
				{
				}
				num = (short)1745682432;
				short num3 = num;
				num = (short)1228734464;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsFrequencyRangeEndMHz_A20037.HiddenDynamic;
			}
			set
			{
				short num = (short)195216172;
				short num2 = num;
				num = (short)1925432108;
				switch (num2 == num)
				{
				}
				num = (short)1493893120;
				if (num != 0)
				{
				}
				num = (short)825753600;
				short num3 = num;
				num = (short)712900609;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsFrequencyRangeEndMHz_A20037.HiddenDynamic = value;
			}
		}

		// Token: 0x17002117 RID: 8471
		// (get) Token: 0x060040A8 RID: 16552 RVA: 0x003CA044 File Offset: 0x003C8244
		public bool RadWideTransmitPowerLevelsFrequencyRangeEndMHz_A20037_HasDiffs
		{
			get
			{
				short num = (short)1168506881;
				if (num != 0)
				{
				}
				num = (short)738769251;
				short num2 = num;
				num = (short)1766963555;
				switch (num2 == num)
				{
				}
				num = (short)1587609600;
				short num3 = num;
				num = (short)834666496;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsFrequencyRangeEndMHz_A20037._HasDiffs;
			}
		}

		// Token: 0x17002118 RID: 8472
		// (get) Token: 0x060040A9 RID: 16553 RVA: 0x003CA0FC File Offset: 0x003C82FC
		// (set) Token: 0x060040AA RID: 16554 RVA: 0x003CA1B0 File Offset: 0x003C83B0
		public int RadWideTransmitPowerLevelsTxPowerLevelMinimumW_A20038Value
		{
			get
			{
				short num = (short)901267978;
				short num2 = num;
				num = (short)1238057482;
				switch (num2 == num)
				{
				}
				num = (short)1356857344;
				if (num != 0)
				{
				}
				num = (short)2089877504;
				short num3 = num;
				num = (short)1505034241;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelMinimumW_A20038.Value;
			}
			set
			{
				short num = (short)1279004564;
				short num2 = num;
				num = (short)1396117396;
				switch (num2 == num)
				{
				}
				num = (short)46006273;
				if (num != 0)
				{
				}
				num = (short)1657012224;
				short num3 = num;
				num = (short)1192165376;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTxPowerLevelMinimumW_A20038.Value = value;
			}
		}

		// Token: 0x17002119 RID: 8473
		// (get) Token: 0x060040AB RID: 16555 RVA: 0x003CA264 File Offset: 0x003C8464
		public global::AcpBusinessLayer.AcpRangeField<int, string> RadWideTransmitPowerLevelsTxPowerLevelMinimumW_A20038
		{
			get
			{
				short num = (short)498991105;
				if (num != 0)
				{
				}
				num = (short)2126605005;
				short num2 = num;
				num = (short)1221356237;
				switch (num2 == num)
				{
				}
				num = (short)220135424;
				short num3 = num;
				num = (short)130547712;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelMinimumW_A20038;
			}
		}

		// Token: 0x1700211A RID: 8474
		// (get) Token: 0x060040AC RID: 16556 RVA: 0x003CA318 File Offset: 0x003C8518
		// (set) Token: 0x060040AD RID: 16557 RVA: 0x003CA3D0 File Offset: 0x003C85D0
		public string RadWideTransmitPowerLevelsTxPowerLevelMinimumW_A20038_UIValue
		{
			get
			{
				short num = (short)2057043969;
				if (num != 0)
				{
				}
				num = (short)2042222602;
				short num2 = num;
				num = (short)2109593610;
				switch (num2 == num)
				{
				}
				num = (short)1347747840;
				short num3 = num;
				num = (short)901513216;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelMinimumW_A20038.UIValue;
			}
			set
			{
				short num = (short)749665394;
				short num2 = num;
				num = (short)315030642;
				switch (num2 == num)
				{
				}
				num = (short)1454637057;
				if (num != 0)
				{
				}
				num = (short)110034944;
				short num3 = num;
				num = (short)458096640;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTxPowerLevelMinimumW_A20038.UIValue = value;
			}
		}

		// Token: 0x1700211B RID: 8475
		// (get) Token: 0x060040AE RID: 16558 RVA: 0x003CA488 File Offset: 0x003C8688
		// (set) Token: 0x060040AF RID: 16559 RVA: 0x003CA540 File Offset: 0x003C8740
		internal int RadWideTransmitPowerLevelsTxPowerLevelMinimumW_A20038Min
		{
			get
			{
				short num = (short)1934025350;
				short num2 = num;
				num = (short)131785350;
				switch (num2 == num)
				{
				}
				num = (short)1008599041;
				if (num != 0)
				{
				}
				num = (short)1143537664;
				short num3 = num;
				num = (short)2063269888;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelMinimumW_A20038.Min;
			}
			set
			{
				short num = (short)606827384;
				short num2 = num;
				num = (short)2141025144;
				switch (num2 == num)
				{
				}
				num = (short)2072576000;
				if (num != 0)
				{
				}
				num = (short)1039663104;
				short num3 = num;
				num = (short)2114453505;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTxPowerLevelMinimumW_A20038.Min = value;
			}
		}

		// Token: 0x1700211C RID: 8476
		// (get) Token: 0x060040B0 RID: 16560 RVA: 0x003CA5F8 File Offset: 0x003C87F8
		// (set) Token: 0x060040B1 RID: 16561 RVA: 0x003CA6B0 File Offset: 0x003C88B0
		internal int RadWideTransmitPowerLevelsTxPowerLevelMinimumW_A20038Max
		{
			get
			{
				short num = (short)593505288;
				short num2 = num;
				num = (short)459484168;
				switch (num2 == num)
				{
				}
				num = (short)403243009;
				if (num != 0)
				{
				}
				num = (short)1735720960;
				short num3 = num;
				num = (short)298975232;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelMinimumW_A20038.Max;
			}
			set
			{
				short num = (short)1229294906;
				short num2 = num;
				num = (short)49057082;
				switch (num2 == num)
				{
				}
				num = (short)1886191616;
				if (num != 0)
				{
				}
				num = (short)1584726016;
				short num3 = num;
				num = (short)567607297;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTxPowerLevelMinimumW_A20038.Max = value;
			}
		}

		// Token: 0x1700211D RID: 8477
		// (get) Token: 0x060040B2 RID: 16562 RVA: 0x003CA768 File Offset: 0x003C8968
		// (set) Token: 0x060040B3 RID: 16563 RVA: 0x003CA81C File Offset: 0x003C8A1C
		internal int RadWideTransmitPowerLevelsTxPowerLevelMinimumW_A20038Step
		{
			get
			{
				short num = (short)900677297;
				short num2 = num;
				num = (short)1168129713;
				switch (num2 == num)
				{
				}
				num = (short)440205313;
				if (num != 0)
				{
				}
				num = (short)1654456320;
				short num3 = num;
				num = (short)1558052864;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelMinimumW_A20038.StepSize;
			}
			set
			{
				short num = (short)932103379;
				short num2 = num;
				num = (short)1557251283;
				switch (num2 == num)
				{
				}
				num = (short)737607681;
				if (num != 0)
				{
				}
				num = (short)2076835840;
				short num3 = num;
				num = (short)287113216;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTxPowerLevelMinimumW_A20038.StepSize = value;
			}
		}

		// Token: 0x1700211E RID: 8478
		// (get) Token: 0x060040B4 RID: 16564 RVA: 0x003CA8D4 File Offset: 0x003C8AD4
		// (set) Token: 0x060040B5 RID: 16565 RVA: 0x003CA98C File Offset: 0x003C8B8C
		public bool RadWideTransmitPowerLevelsTxPowerLevelMinimumW_A20038_Applicable
		{
			get
			{
				short num = (short)816480255;
				short num2 = num;
				num = (short)343506943;
				switch (num2 == num)
				{
				}
				num = (short)1566572545;
				if (num != 0)
				{
				}
				num = (short)613154816;
				short num3 = num;
				num = (short)990314496;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelMinimumW_A20038.Applicable;
			}
			set
			{
				short num = (short)1497608083;
				short num2 = num;
				num = (short)1139584915;
				switch (num2 == num)
				{
				}
				num = (short)643825665;
				if (num != 0)
				{
				}
				num = (short)1201405952;
				short num3 = num;
				num = (short)374931456;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTxPowerLevelMinimumW_A20038.Applicable = value;
			}
		}

		// Token: 0x1700211F RID: 8479
		// (get) Token: 0x060040B6 RID: 16566 RVA: 0x003CAA44 File Offset: 0x003C8C44
		// (set) Token: 0x060040B7 RID: 16567 RVA: 0x003CAAF4 File Offset: 0x003C8CF4
		public bool RadWideTransmitPowerLevelsTxPowerLevelMinimumW_A20038_Valid
		{
			get
			{
				short num = (short)383909889;
				if (num != 0)
				{
				}
				num = (short)696172922;
				short num2 = num;
				num = (short)1915994490;
				switch (num2 == num)
				{
				}
				num = (short)1397751808;
				short num3 = num;
				num = (short)103284736;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelMinimumW_A20038.Valid;
			}
			set
			{
				short num = (short)944794393;
				short num2 = num;
				num = (short)97086233;
				switch (num2 == num)
				{
				}
				num = (short)762642433;
				if (num != 0)
				{
				}
				num = (short)682360832;
				short num3 = num;
				num = (short)375521280;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTxPowerLevelMinimumW_A20038.Valid = value;
			}
		}

		// Token: 0x17002120 RID: 8480
		// (get) Token: 0x060040B8 RID: 16568 RVA: 0x003CABA8 File Offset: 0x003C8DA8
		// (set) Token: 0x060040B9 RID: 16569 RVA: 0x003CAC5C File Offset: 0x003C8E5C
		public bool RadWideTransmitPowerLevelsTxPowerLevelMinimumW_A20038_Visible
		{
			get
			{
				short num = (short)912498580;
				short num2 = num;
				num = (short)1638702996;
				switch (num2 == num)
				{
				}
				num = (short)133955584;
				if (num != 0)
				{
				}
				num = (short)752615424;
				short num3 = num;
				num = (short)901775361;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelMinimumW_A20038.Visible;
			}
			set
			{
				short num = (short)641863546;
				short num2 = num;
				num = (short)494866298;
				switch (num2 == num)
				{
				}
				num = (short)704839681;
				if (num != 0)
				{
				}
				num = (short)1000079360;
				short num3 = num;
				num = (short)422576128;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTxPowerLevelMinimumW_A20038.Visible = value;
			}
		}

		// Token: 0x17002121 RID: 8481
		// (get) Token: 0x060040BA RID: 16570 RVA: 0x003CAD14 File Offset: 0x003C8F14
		// (set) Token: 0x060040BB RID: 16571 RVA: 0x003CADC8 File Offset: 0x003C8FC8
		public bool RadWideTransmitPowerLevelsTxPowerLevelMinimumW_A20038_Editable
		{
			get
			{
				short num = (short)838231470;
				short num2 = num;
				num = (short)175269294;
				switch (num2 == num)
				{
				}
				num = (short)2132475905;
				if (num != 0)
				{
				}
				num = (short)2065432576;
				short num3 = num;
				num = (short)897449984;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelMinimumW_A20038.Editable;
			}
			set
			{
				short num = (short)1100480513;
				if (num != 0)
				{
				}
				num = (short)1168441355;
				short num2 = num;
				num = (short)1262878731;
				switch (num2 == num)
				{
				}
				num = (short)1993408512;
				short num3 = num;
				num = (short)637206528;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTxPowerLevelMinimumW_A20038.Editable = value;
			}
		}

		// Token: 0x17002122 RID: 8482
		// (get) Token: 0x060040BC RID: 16572 RVA: 0x003CAE7C File Offset: 0x003C907C
		internal string RadWideTransmitPowerLevelsTxPowerLevelMinimumW_A20038_UILabel
		{
			get
			{
				short num = (short)446653628;
				short num2 = num;
				num = (short)806184124;
				switch (num2 == num)
				{
				}
				num = (short)268173312;
				if (num != 0)
				{
				}
				num = (short)1326776320;
				short num3 = num;
				num = (short)1698365441;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelMinimumW_A20038.UIName;
			}
		}

		// Token: 0x17002123 RID: 8483
		// (get) Token: 0x060040BD RID: 16573 RVA: 0x003CAF30 File Offset: 0x003C9130
		// (set) Token: 0x060040BE RID: 16574 RVA: 0x003CAFE4 File Offset: 0x003C91E4
		internal bool RadWideTransmitPowerLevelsTxPowerLevelMinimumW_A20038_HiddenStatic
		{
			get
			{
				short num = (short)469321356;
				short num2 = num;
				num = (short)25380492;
				switch (num2 == num)
				{
				}
				num = (short)1612775424;
				if (num != 0)
				{
				}
				num = (short)969801728;
				short num3 = num;
				num = (short)801243137;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelMinimumW_A20038.HiddenStatic;
			}
			set
			{
				short num = (short)1109802313;
				short num2 = num;
				num = (short)1840790857;
				switch (num2 == num)
				{
				}
				num = (short)1686306816;
				if (num != 0)
				{
				}
				num = (short)2004156416;
				short num3 = num;
				num = (short)2002714625;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTxPowerLevelMinimumW_A20038.HiddenStatic = value;
			}
		}

		// Token: 0x17002124 RID: 8484
		// (get) Token: 0x060040BF RID: 16575 RVA: 0x003CB09C File Offset: 0x003C929C
		// (set) Token: 0x060040C0 RID: 16576 RVA: 0x003CB150 File Offset: 0x003C9350
		internal bool RadWideTransmitPowerLevelsTxPowerLevelMinimumW_A20038_HiddenDynamic
		{
			get
			{
				short num = (short)1608264017;
				short num2 = num;
				num = (short)1558522193;
				switch (num2 == num)
				{
				}
				num = (short)352124929;
				if (num != 0)
				{
				}
				num = (short)919601152;
				short num3 = num;
				num = (short)582483968;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelMinimumW_A20038.HiddenDynamic;
			}
			set
			{
				short num = (short)32579069;
				short num2 = num;
				num = (short)854466045;
				switch (num2 == num)
				{
				}
				num = (short)1487273985;
				if (num != 0)
				{
				}
				num = (short)1187840000;
				short num3 = num;
				num = (short)984088576;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTxPowerLevelMinimumW_A20038.HiddenDynamic = value;
			}
		}

		// Token: 0x17002125 RID: 8485
		// (get) Token: 0x060040C1 RID: 16577 RVA: 0x003CB208 File Offset: 0x003C9408
		public bool RadWideTransmitPowerLevelsTxPowerLevelMinimumW_A20038_HasDiffs
		{
			get
			{
				short num = (short)48627713;
				if (num != 0)
				{
				}
				num = (short)1079556869;
				short num2 = num;
				num = (short)691714821;
				switch (num2 == num)
				{
				}
				num = (short)943521792;
				short num3 = num;
				num = (short)1937571840;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelMinimumW_A20038._HasDiffs;
			}
		}

		// Token: 0x17002126 RID: 8486
		// (get) Token: 0x060040C2 RID: 16578 RVA: 0x003CB2C0 File Offset: 0x003C94C0
		// (set) Token: 0x060040C3 RID: 16579 RVA: 0x003CB378 File Offset: 0x003C9578
		public int RadWideTransmitPowerLevelsTxPowerLevelMaximumW_A20039Value
		{
			get
			{
				short num = (short)906369636;
				short num2 = num;
				num = (short)1332746852;
				switch (num2 == num)
				{
				}
				num = (short)93126657;
				if (num != 0)
				{
				}
				num = (short)1707147264;
				short num3 = num;
				num = (short)921370624;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelMaximumW_A20039.Value;
			}
			set
			{
				short num = (short)1827870767;
				short num2 = num;
				num = (short)862328879;
				switch (num2 == num)
				{
				}
				num = (short)670957569;
				if (num != 0)
				{
				}
				num = (short)730005504;
				short num3 = num;
				num = (short)552402944;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTxPowerLevelMaximumW_A20039.Value = value;
			}
		}

		// Token: 0x17002127 RID: 8487
		// (get) Token: 0x060040C4 RID: 16580 RVA: 0x003CB42C File Offset: 0x003C962C
		public global::AcpBusinessLayer.AcpRangeField<int, string> RadWideTransmitPowerLevelsTxPowerLevelMaximumW_A20039
		{
			get
			{
				short num = (short)1742144504;
				short num2 = num;
				num = (short)98698232;
				switch (num2 == num)
				{
				}
				num = (short)1293877248;
				if (num != 0)
				{
				}
				num = (short)1362034688;
				short num3 = num;
				num = (short)367788033;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelMaximumW_A20039;
			}
		}

		// Token: 0x17002128 RID: 8488
		// (get) Token: 0x060040C5 RID: 16581 RVA: 0x003CB4DC File Offset: 0x003C96DC
		// (set) Token: 0x060040C6 RID: 16582 RVA: 0x003CB590 File Offset: 0x003C9790
		public string RadWideTransmitPowerLevelsTxPowerLevelMaximumW_A20039_UIValue
		{
			get
			{
				short num = (short)640430228;
				short num2 = num;
				num = (short)720646292;
				switch (num2 == num)
				{
				}
				num = (short)1457586176;
				if (num != 0)
				{
				}
				num = (short)1555300352;
				short num3 = num;
				num = (short)535953409;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelMaximumW_A20039.UIValue;
			}
			set
			{
				short num = (short)578405570;
				short num2 = num;
				num = (short)59032770;
				switch (num2 == num)
				{
				}
				num = (short)1602945025;
				if (num != 0)
				{
				}
				num = (short)629800960;
				short num3 = num;
				num = (short)647036928;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTxPowerLevelMaximumW_A20039.UIValue = value;
			}
		}

		// Token: 0x17002129 RID: 8489
		// (get) Token: 0x060040C7 RID: 16583 RVA: 0x003CB648 File Offset: 0x003C9848
		// (set) Token: 0x060040C8 RID: 16584 RVA: 0x003CB6FC File Offset: 0x003C98FC
		internal int RadWideTransmitPowerLevelsTxPowerLevelMaximumW_A20039Min
		{
			get
			{
				short num = (short)473079777;
				short num2 = num;
				num = (short)2049417185;
				switch (num2 == num)
				{
				}
				num = (short)1274216449;
				if (num != 0)
				{
				}
				num = (short)979501056;
				short num3 = num;
				num = (short)1946877952;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelMaximumW_A20039.Min;
			}
			set
			{
				short num = (short)1574727342;
				short num2 = num;
				num = (short)1964535470;
				switch (num2 == num)
				{
				}
				num = (short)2146631681;
				if (num != 0)
				{
				}
				num = (short)1875312640;
				short num3 = num;
				num = (short)477626368;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTxPowerLevelMaximumW_A20039.Min = value;
			}
		}

		// Token: 0x1700212A RID: 8490
		// (get) Token: 0x060040C9 RID: 16585 RVA: 0x003CB7B0 File Offset: 0x003C99B0
		// (set) Token: 0x060040CA RID: 16586 RVA: 0x003CB868 File Offset: 0x003C9A68
		internal int RadWideTransmitPowerLevelsTxPowerLevelMaximumW_A20039Max
		{
			get
			{
				short num = (short)1746020810;
				short num2 = num;
				num = (short)1874799050;
				switch (num2 == num)
				{
				}
				num = (short)1162805249;
				if (num != 0)
				{
				}
				num = (short)1523712000;
				short num3 = num;
				num = (short)545652736;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelMaximumW_A20039.Max;
			}
			set
			{
				short num = (short)1004268297;
				short num2 = num;
				num = (short)2039606025;
				switch (num2 == num)
				{
				}
				num = (short)2129526785;
				if (num != 0)
				{
				}
				num = (short)738525184;
				short num3 = num;
				num = (short)781058048;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTxPowerLevelMaximumW_A20039.Max = value;
			}
		}

		// Token: 0x1700212B RID: 8491
		// (get) Token: 0x060040CB RID: 16587 RVA: 0x003CB920 File Offset: 0x003C9B20
		// (set) Token: 0x060040CC RID: 16588 RVA: 0x003CB9D4 File Offset: 0x003C9BD4
		internal int RadWideTransmitPowerLevelsTxPowerLevelMaximumW_A20039Step
		{
			get
			{
				short num = (short)1909162129;
				short num2 = num;
				num = (short)1551335569;
				switch (num2 == num)
				{
				}
				num = (short)957612033;
				if (num != 0)
				{
				}
				num = (short)79298560;
				short num3 = num;
				num = (short)434962432;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelMaximumW_A20039.StepSize;
			}
			set
			{
				short num = (short)1617715150;
				short num2 = num;
				num = (short)1203527630;
				switch (num2 == num)
				{
				}
				num = (short)827392001;
				if (num != 0)
				{
				}
				num = (short)1639317504;
				short num3 = num;
				num = (short)385220608;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTxPowerLevelMaximumW_A20039.StepSize = value;
			}
		}

		// Token: 0x1700212C RID: 8492
		// (get) Token: 0x060040CD RID: 16589 RVA: 0x003CBA8C File Offset: 0x003C9C8C
		// (set) Token: 0x060040CE RID: 16590 RVA: 0x003CBB44 File Offset: 0x003C9D44
		public bool RadWideTransmitPowerLevelsTxPowerLevelMaximumW_A20039_Applicable
		{
			get
			{
				short num = (short)523187786;
				short num2 = num;
				num = (short)1904162378;
				switch (num2 == num)
				{
				}
				num = (short)302383105;
				if (num != 0)
				{
				}
				num = (short)1417674752;
				short num3 = num;
				num = (short)597884928;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelMaximumW_A20039.Applicable;
			}
			set
			{
				short num = (short)1113913139;
				short num2 = num;
				num = (short)681965363;
				switch (num2 == num)
				{
				}
				num = (short)1118961665;
				if (num != 0)
				{
				}
				num = (short)67895296;
				short num3 = num;
				num = (short)1689190400;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTxPowerLevelMaximumW_A20039.Applicable = value;
			}
		}

		// Token: 0x1700212D RID: 8493
		// (get) Token: 0x060040CF RID: 16591 RVA: 0x003CBBFC File Offset: 0x003C9DFC
		// (set) Token: 0x060040D0 RID: 16592 RVA: 0x003CBCB4 File Offset: 0x003C9EB4
		public bool RadWideTransmitPowerLevelsTxPowerLevelMaximumW_A20039_Valid
		{
			get
			{
				short num = (short)1345431376;
				short num2 = num;
				num = (short)1297852240;
				switch (num2 == num)
				{
				}
				num = (short)707067904;
				if (num != 0)
				{
				}
				num = (short)855965696;
				short num3 = num;
				num = (short)1220739073;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelMaximumW_A20039.Valid;
			}
			set
			{
				short num = (short)2112849641;
				short num2 = num;
				num = (short)702056169;
				switch (num2 == num)
				{
				}
				num = (short)1083506689;
				if (num != 0)
				{
				}
				num = (short)121307136;
				short num3 = num;
				num = (short)2113667072;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTxPowerLevelMaximumW_A20039.Valid = value;
			}
		}

		// Token: 0x1700212E RID: 8494
		// (get) Token: 0x060040D1 RID: 16593 RVA: 0x003CBD68 File Offset: 0x003C9F68
		// (set) Token: 0x060040D2 RID: 16594 RVA: 0x003CBE18 File Offset: 0x003CA018
		public bool RadWideTransmitPowerLevelsTxPowerLevelMaximumW_A20039_Visible
		{
			get
			{
				short num = (short)316272459;
				short num2 = num;
				num = (short)1302654795;
				switch (num2 == num)
				{
				}
				num = (short)2099380224;
				if (num != 0)
				{
				}
				num = (short)1066336256;
				short num3 = num;
				num = (short)1552220161;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelMaximumW_A20039.Visible;
			}
			set
			{
				short num = (short)1399106486;
				short num2 = num;
				num = (short)1844554678;
				switch (num2 == num)
				{
				}
				num = (short)202440705;
				if (num != 0)
				{
				}
				num = (short)1401159680;
				short num3 = num;
				num = (short)217382912;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTxPowerLevelMaximumW_A20039.Visible = value;
			}
		}

		// Token: 0x1700212F RID: 8495
		// (get) Token: 0x060040D3 RID: 16595 RVA: 0x003CBED4 File Offset: 0x003CA0D4
		// (set) Token: 0x060040D4 RID: 16596 RVA: 0x003CBF88 File Offset: 0x003CA188
		public bool RadWideTransmitPowerLevelsTxPowerLevelMaximumW_A20039_Editable
		{
			get
			{
				short num = (short)1692120055;
				short num2 = num;
				num = (short)1567667191;
				switch (num2 == num)
				{
				}
				num = (short)1648230400;
				if (num != 0)
				{
				}
				num = (short)1034878976;
				short num3 = num;
				num = (short)183631873;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelMaximumW_A20039.Editable;
			}
			set
			{
				short num = (short)2100398498;
				short num2 = num;
				num = (short)1529514402;
				switch (num2 == num)
				{
				}
				num = (short)848363521;
				if (num != 0)
				{
				}
				num = (short)2043674624;
				short num3 = num;
				num = (short)842727424;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTxPowerLevelMaximumW_A20039.Editable = value;
			}
		}

		// Token: 0x17002130 RID: 8496
		// (get) Token: 0x060040D5 RID: 16597 RVA: 0x003CC040 File Offset: 0x003CA240
		internal string RadWideTransmitPowerLevelsTxPowerLevelMaximumW_A20039_UILabel
		{
			get
			{
				short num = (short)1388903362;
				short num2 = num;
				num = (short)2134637506;
				switch (num2 == num)
				{
				}
				num = (short)1360134144;
				if (num != 0)
				{
				}
				num = (short)1641152512;
				short num3 = num;
				num = (short)1525743617;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelMaximumW_A20039.UIName;
			}
		}

		// Token: 0x17002131 RID: 8497
		// (get) Token: 0x060040D6 RID: 16598 RVA: 0x003CC0F8 File Offset: 0x003CA2F8
		// (set) Token: 0x060040D7 RID: 16599 RVA: 0x003CC1AC File Offset: 0x003CA3AC
		internal bool RadWideTransmitPowerLevelsTxPowerLevelMaximumW_A20039_HiddenStatic
		{
			get
			{
				short num = (short)1546288408;
				short num2 = num;
				num = (short)453147928;
				switch (num2 == num)
				{
				}
				num = (short)2067070977;
				if (num != 0)
				{
				}
				num = (short)60817408;
				short num3 = num;
				num = (short)720633856;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelMaximumW_A20039.HiddenStatic;
			}
			set
			{
				short num = (short)1784556494;
				short num2 = num;
				num = (short)403188686;
				switch (num2 == num)
				{
				}
				num = (short)1865940993;
				if (num != 0)
				{
				}
				num = (short)742064128;
				short num3 = num;
				num = (short)2022047744;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTxPowerLevelMaximumW_A20039.HiddenStatic = value;
			}
		}

		// Token: 0x17002132 RID: 8498
		// (get) Token: 0x060040D8 RID: 16600 RVA: 0x003CC260 File Offset: 0x003CA460
		// (set) Token: 0x060040D9 RID: 16601 RVA: 0x003CC314 File Offset: 0x003CA514
		internal bool RadWideTransmitPowerLevelsTxPowerLevelMaximumW_A20039_HiddenDynamic
		{
			get
			{
				short num = (short)740695948;
				short num2 = num;
				num = (short)529145740;
				switch (num2 == num)
				{
				}
				num = (short)1641349121;
				if (num != 0)
				{
				}
				num = (short)240451584;
				short num3 = num;
				num = (short)58589184;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelMaximumW_A20039.HiddenDynamic;
			}
			set
			{
				short num = (short)450738765;
				short num2 = num;
				num = (short)1542109773;
				switch (num2 == num)
				{
				}
				num = (short)1354039297;
				if (num != 0)
				{
				}
				num = (short)1311440896;
				short num3 = num;
				num = (short)1149435904;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTxPowerLevelMaximumW_A20039.HiddenDynamic = value;
			}
		}

		// Token: 0x17002133 RID: 8499
		// (get) Token: 0x060040DA RID: 16602 RVA: 0x003CC3CC File Offset: 0x003CA5CC
		public bool RadWideTransmitPowerLevelsTxPowerLevelMaximumW_A20039_HasDiffs
		{
			get
			{
				short num = (short)843219484;
				short num2 = num;
				num = (short)387154460;
				switch (num2 == num)
				{
				}
				num = (short)211812352;
				if (num != 0)
				{
				}
				num = (short)500563968;
				short num3 = num;
				num = (short)682950657;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelMaximumW_A20039._HasDiffs;
			}
		}

		// Token: 0x17002134 RID: 8500
		// (get) Token: 0x060040DB RID: 16603 RVA: 0x003CC480 File Offset: 0x003CA680
		// (set) Token: 0x060040DC RID: 16604 RVA: 0x003CC538 File Offset: 0x003CA738
		public string RadWidePowerLevelBandFrequency_A41063Value
		{
			get
			{
				short num = (short)1231421441;
				if (num != 0)
				{
				}
				num = (short)42459911;
				short num2 = num;
				num = (short)220128007;
				switch (num2 == num)
				{
				}
				num = (short)681312256;
				short num3 = num;
				num = (short)1079705600;
				if (num != 0)
				{
				}
				return this.radWidePowerLevelBandFrequency_A41063.Value;
			}
			set
			{
				short num = (short)1905983489;
				if (num != 0)
				{
				}
				num = (short)1726753519;
				short num2 = num;
				num = (short)1491938031;
				switch (num2 == num)
				{
				}
				num = (short)727252992;
				short num3 = num;
				num = (short)2139815936;
				if (num != 0)
				{
				}
				this.radWidePowerLevelBandFrequency_A41063.Value = value;
			}
		}

		// Token: 0x17002135 RID: 8501
		// (get) Token: 0x060040DD RID: 16605 RVA: 0x003CC5EC File Offset: 0x003CA7EC
		public global::AcpBusinessLayer.AcpField<string> RadWidePowerLevelBandFrequency_A41063
		{
			get
			{
				short num = (short)259384735;
				short num2 = num;
				num = (short)1459742111;
				switch (num2 == num)
				{
				}
				num = (short)916258816;
				if (num != 0)
				{
				}
				num = (short)1192493056;
				short num3 = num;
				num = (short)709689345;
				if (num != 0)
				{
				}
				return this.radWidePowerLevelBandFrequency_A41063;
			}
		}

		// Token: 0x17002136 RID: 8502
		// (get) Token: 0x060040DE RID: 16606 RVA: 0x003CC69C File Offset: 0x003CA89C
		// (set) Token: 0x060040DF RID: 16607 RVA: 0x003CC750 File Offset: 0x003CA950
		public string RadWidePowerLevelBandFrequency_A41063_UIValue
		{
			get
			{
				short num = (short)842399745;
				if (num != 0)
				{
				}
				num = (short)348610159;
				short num2 = num;
				num = (short)76766831;
				switch (num2 == num)
				{
				}
				num = (short)165806080;
				short num3 = num;
				num = (short)201981952;
				if (num != 0)
				{
				}
				return this.radWidePowerLevelBandFrequency_A41063.Value;
			}
			set
			{
				short num = (short)1289515734;
				short num2 = num;
				num = (short)1160803030;
				switch (num2 == num)
				{
				}
				num = (short)1366884353;
				if (num != 0)
				{
				}
				num = (short)170262528;
				short num3 = num;
				num = (short)1088749568;
				if (num != 0)
				{
				}
				this.radWidePowerLevelBandFrequency_A41063.Value = value;
			}
		}

		// Token: 0x17002137 RID: 8503
		// (get) Token: 0x060040E0 RID: 16608 RVA: 0x003CC804 File Offset: 0x003CAA04
		// (set) Token: 0x060040E1 RID: 16609 RVA: 0x003CC8BC File Offset: 0x003CAABC
		public bool RadWidePowerLevelBandFrequency_A41063_Applicable
		{
			get
			{
				short num = (short)295437505;
				short num2 = num;
				num = (short)1137706177;
				switch (num2 == num)
				{
				}
				num = (short)1914175488;
				if (num != 0)
				{
				}
				num = (short)86048768;
				short num3 = num;
				num = (short)1145962497;
				if (num != 0)
				{
				}
				return this.radWidePowerLevelBandFrequency_A41063.Applicable;
			}
			set
			{
				short num = (short)2074928706;
				short num2 = num;
				num = (short)1227548226;
				switch (num2 == num)
				{
				}
				num = (short)1918763009;
				if (num != 0)
				{
				}
				num = (short)17563648;
				short num3 = num;
				num = (short)254083072;
				if (num != 0)
				{
				}
				this.radWidePowerLevelBandFrequency_A41063.Applicable = value;
			}
		}

		// Token: 0x17002138 RID: 8504
		// (get) Token: 0x060040E2 RID: 16610 RVA: 0x003CC974 File Offset: 0x003CAB74
		// (set) Token: 0x060040E3 RID: 16611 RVA: 0x003CCA2C File Offset: 0x003CAC2C
		public bool RadWidePowerLevelBandFrequency_A41063_Valid
		{
			get
			{
				short num = (short)358239439;
				short num2 = num;
				num = (short)211111119;
				switch (num2 == num)
				{
				}
				num = (short)2110980097;
				if (num != 0)
				{
				}
				num = (short)1623064576;
				short num3 = num;
				num = (short)916914176;
				if (num != 0)
				{
				}
				return this.radWidePowerLevelBandFrequency_A41063.Valid;
			}
			set
			{
				short num = (short)1092812801;
				if (num != 0)
				{
				}
				num = (short)1882332420;
				short num2 = num;
				num = (short)548543748;
				switch (num2 == num)
				{
				}
				num = (short)1056636928;
				short num3 = num;
				num = (short)253886464;
				if (num != 0)
				{
				}
				this.radWidePowerLevelBandFrequency_A41063.Valid = value;
			}
		}

		// Token: 0x17002139 RID: 8505
		// (get) Token: 0x060040E4 RID: 16612 RVA: 0x003CCAE0 File Offset: 0x003CACE0
		// (set) Token: 0x060040E5 RID: 16613 RVA: 0x003CCB90 File Offset: 0x003CAD90
		public bool RadWidePowerLevelBandFrequency_A41063_Visible
		{
			get
			{
				short num = (short)443736589;
				short num2 = num;
				num = (short)1107943949;
				switch (num2 == num)
				{
				}
				num = (short)672071681;
				if (num != 0)
				{
				}
				num = (short)279183360;
				short num3 = num;
				num = (short)225837056;
				if (num != 0)
				{
				}
				return this.radWidePowerLevelBandFrequency_A41063.Visible;
			}
			set
			{
				short num = (short)1453705815;
				short num2 = num;
				num = (short)432065111;
				switch (num2 == num)
				{
				}
				num = (short)406388736;
				if (num != 0)
				{
				}
				num = (short)476250112;
				short num3 = num;
				num = (short)290127873;
				if (num != 0)
				{
				}
				this.radWidePowerLevelBandFrequency_A41063.Visible = value;
			}
		}

		// Token: 0x1700213A RID: 8506
		// (get) Token: 0x060040E6 RID: 16614 RVA: 0x003CCC44 File Offset: 0x003CAE44
		// (set) Token: 0x060040E7 RID: 16615 RVA: 0x003CCCF8 File Offset: 0x003CAEF8
		public bool RadWidePowerLevelBandFrequency_A41063_Editable
		{
			get
			{
				short num = (short)1858142209;
				if (num != 0)
				{
				}
				num = (short)596668287;
				short num2 = num;
				num = (short)464088959;
				switch (num2 == num)
				{
				}
				num = (short)435290112;
				short num3 = num;
				num = (short)421396480;
				if (num != 0)
				{
				}
				return this.radWidePowerLevelBandFrequency_A41063.Editable;
			}
			set
			{
				short num = (short)148241268;
				short num2 = num;
				num = (short)1192688500;
				switch (num2 == num)
				{
				}
				num = (short)1576992769;
				if (num != 0)
				{
				}
				num = (short)211681280;
				short num3 = num;
				num = (short)1117192192;
				if (num != 0)
				{
				}
				this.radWidePowerLevelBandFrequency_A41063.Editable = value;
			}
		}

		// Token: 0x1700213B RID: 8507
		// (get) Token: 0x060040E8 RID: 16616 RVA: 0x003CCDB0 File Offset: 0x003CAFB0
		internal string RadWidePowerLevelBandFrequency_A41063_UILabel
		{
			get
			{
				short num = (short)1270990967;
				short num2 = num;
				num = (short)1386858615;
				switch (num2 == num)
				{
				}
				num = (short)1312620545;
				if (num != 0)
				{
				}
				num = (short)599982080;
				short num3 = num;
				num = (short)958922752;
				if (num != 0)
				{
				}
				return this.radWidePowerLevelBandFrequency_A41063.UIName;
			}
		}

		// Token: 0x1700213C RID: 8508
		// (get) Token: 0x060040E9 RID: 16617 RVA: 0x003CCE68 File Offset: 0x003CB068
		// (set) Token: 0x060040EA RID: 16618 RVA: 0x003CCF20 File Offset: 0x003CB120
		internal bool RadWidePowerLevelBandFrequency_A41063_HiddenStatic
		{
			get
			{
				short num = (short)1769053903;
				short num2 = num;
				num = (short)643800783;
				switch (num2 == num)
				{
				}
				num = (short)1980039168;
				if (num != 0)
				{
				}
				num = (short)1445658624;
				short num3 = num;
				num = (short)146538497;
				if (num != 0)
				{
				}
				return this.radWidePowerLevelBandFrequency_A41063.HiddenStatic;
			}
			set
			{
				short num = (short)1456603137;
				if (num != 0)
				{
				}
				num = (short)23483941;
				short num2 = num;
				num = (short)1196578341;
				switch (num2 == num)
				{
				}
				num = (short)135659520;
				short num3 = num;
				num = (short)515768320;
				if (num != 0)
				{
				}
				this.radWidePowerLevelBandFrequency_A41063.HiddenStatic = value;
			}
		}

		// Token: 0x1700213D RID: 8509
		// (get) Token: 0x060040EB RID: 16619 RVA: 0x003CCFD4 File Offset: 0x003CB1D4
		// (set) Token: 0x060040EC RID: 16620 RVA: 0x003CD08C File Offset: 0x003CB28C
		internal bool RadWidePowerLevelBandFrequency_A41063_HiddenDynamic
		{
			get
			{
				short num = (short)721835572;
				short num2 = num;
				num = (short)1707824692;
				switch (num2 == num)
				{
				}
				num = (short)725680128;
				if (num != 0)
				{
				}
				num = (short)102039552;
				short num3 = num;
				num = (short)2107768833;
				if (num != 0)
				{
				}
				return this.radWidePowerLevelBandFrequency_A41063.HiddenDynamic;
			}
			set
			{
				short num = (short)328909962;
				short num2 = num;
				num = (short)1090241674;
				switch (num2 == num)
				{
				}
				num = (short)2047934465;
				if (num != 0)
				{
				}
				num = (short)831062016;
				short num3 = num;
				num = (short)1510473728;
				if (num != 0)
				{
				}
				this.radWidePowerLevelBandFrequency_A41063.HiddenDynamic = value;
			}
		}

		// Token: 0x1700213E RID: 8510
		// (get) Token: 0x060040ED RID: 16621 RVA: 0x003CD140 File Offset: 0x003CB340
		public bool RadWidePowerLevelBandFrequency_A41063_HasDiffs
		{
			get
			{
				short num = (short)1075265768;
				short num2 = num;
				num = (short)1859862760;
				switch (num2 == num)
				{
				}
				num = (short)143392768;
				if (num != 0)
				{
				}
				num = (short)961216512;
				short num3 = num;
				num = (short)2070937601;
				if (num != 0)
				{
				}
				return this.radWidePowerLevelBandFrequency_A41063._HasDiffs;
			}
		}

		// Token: 0x1700213F RID: 8511
		// (get) Token: 0x060040EE RID: 16622 RVA: 0x003CD1F4 File Offset: 0x003CB3F4
		// (set) Token: 0x060040EF RID: 16623 RVA: 0x003CD2A8 File Offset: 0x003CB4A8
		public int RadWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41173Value
		{
			get
			{
				short num = (short)145296202;
				short num2 = num;
				num = (short)644942666;
				switch (num2 == num)
				{
				}
				num = (short)1040449537;
				if (num != 0)
				{
				}
				num = (short)1218576384;
				short num3 = num;
				num = (short)1487732736;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41173.Value;
			}
			set
			{
				short num = (short)1663396169;
				short num2 = num;
				num = (short)1555327305;
				switch (num2 == num)
				{
				}
				num = (short)1476853761;
				if (num != 0)
				{
				}
				num = (short)435290112;
				short num3 = num;
				num = (short)1291124736;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41173.Value = value;
			}
		}

		// Token: 0x17002140 RID: 8512
		// (get) Token: 0x060040F0 RID: 16624 RVA: 0x003CD360 File Offset: 0x003CB560
		public global::AcpBusinessLayer.AcpRangeField<int, string> RadWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41173
		{
			get
			{
				short num = (short)607787079;
				short num2 = num;
				num = (short)568203335;
				switch (num2 == num)
				{
				}
				num = (short)738328576;
				if (num != 0)
				{
				}
				num = (short)2140209152;
				short num3 = num;
				num = (short)517668865;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41173;
			}
		}

		// Token: 0x17002141 RID: 8513
		// (get) Token: 0x060040F1 RID: 16625 RVA: 0x003CD410 File Offset: 0x003CB610
		// (set) Token: 0x060040F2 RID: 16626 RVA: 0x003CD4C4 File Offset: 0x003CB6C4
		public string RadWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41173_UIValue
		{
			get
			{
				short num = (short)2145885;
				short num2 = num;
				num = (short)997899869;
				switch (num2 == num)
				{
				}
				num = (short)1079443457;
				if (num != 0)
				{
				}
				num = (short)1953366016;
				short num3 = num;
				num = (short)469303296;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41173.UIValue;
			}
			set
			{
				short num = (short)1540585762;
				short num2 = num;
				num = (short)320829730;
				switch (num2 == num)
				{
				}
				num = (short)1406468096;
				if (num != 0)
				{
				}
				num = (short)1609695232;
				short num3 = num;
				num = (short)270925825;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41173.UIValue = value;
			}
		}

		// Token: 0x17002142 RID: 8514
		// (get) Token: 0x060040F3 RID: 16627 RVA: 0x003CD57C File Offset: 0x003CB77C
		// (set) Token: 0x060040F4 RID: 16628 RVA: 0x003CD630 File Offset: 0x003CB830
		internal int RadWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41173Min
		{
			get
			{
				short num = (short)355860481;
				if (num != 0)
				{
				}
				num = (short)1538618736;
				short num2 = num;
				num = (short)1145337200;
				switch (num2 == num)
				{
				}
				num = (short)1430978560;
				short num3 = num;
				num = (short)620494848;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41173.Min;
			}
			set
			{
				short num = (short)1056807638;
				short num2 = num;
				num = (short)223714006;
				switch (num2 == num)
				{
				}
				num = (short)2098659329;
				if (num != 0)
				{
				}
				num = (short)1099628544;
				short num3 = num;
				num = (short)403963904;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41173.Min = value;
			}
		}

		// Token: 0x17002143 RID: 8515
		// (get) Token: 0x060040F5 RID: 16629 RVA: 0x003CD6E4 File Offset: 0x003CB8E4
		// (set) Token: 0x060040F6 RID: 16630 RVA: 0x003CD798 File Offset: 0x003CB998
		internal int RadWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41173Max
		{
			get
			{
				short num = (short)1920204801;
				if (num != 0)
				{
				}
				num = (short)266438993;
				short num2 = num;
				num = (short)979601745;
				switch (num2 == num)
				{
				}
				num = (short)172228608;
				short num3 = num;
				num = (short)352452608;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41173.Max;
			}
			set
			{
				short num = (short)632135599;
				short num2 = num;
				num = (short)1520410543;
				switch (num2 == num)
				{
				}
				num = (short)1761476609;
				if (num != 0)
				{
				}
				num = (short)1741357056;
				short num3 = num;
				num = (short)978780160;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41173.Max = value;
			}
		}

		// Token: 0x17002144 RID: 8516
		// (get) Token: 0x060040F7 RID: 16631 RVA: 0x003CD84C File Offset: 0x003CBA4C
		// (set) Token: 0x060040F8 RID: 16632 RVA: 0x003CD900 File Offset: 0x003CBB00
		internal int RadWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41173Step
		{
			get
			{
				short num = (short)1161634362;
				short num2 = num;
				num = (short)1648435770;
				switch (num2 == num)
				{
				}
				num = (short)1607729153;
				if (num != 0)
				{
				}
				num = (short)1340080128;
				short num3 = num;
				num = (short)2121924608;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41173.StepSize;
			}
			set
			{
				short num = (short)599145965;
				short num2 = num;
				num = (short)425868781;
				switch (num2 == num)
				{
				}
				num = (short)1538326529;
				if (num != 0)
				{
				}
				num = (short)1446445056;
				short num3 = num;
				num = (short)219742208;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41173.StepSize = value;
			}
		}

		// Token: 0x17002145 RID: 8517
		// (get) Token: 0x060040F9 RID: 16633 RVA: 0x003CD9B4 File Offset: 0x003CBBB4
		// (set) Token: 0x060040FA RID: 16634 RVA: 0x003CDA68 File Offset: 0x003CBC68
		public bool RadWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41173_Applicable
		{
			get
			{
				short num = (short)35061761;
				if (num != 0)
				{
				}
				num = (short)1822355093;
				short num2 = num;
				num = (short)463072917;
				switch (num2 == num)
				{
				}
				num = (short)1521483776;
				short num3 = num;
				num = (short)1568342016;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41173.Applicable;
			}
			set
			{
				short num = (short)1707343873;
				if (num != 0)
				{
				}
				num = (short)1232402594;
				short num2 = num;
				num = (short)479000738;
				switch (num2 == num)
				{
				}
				num = (short)1795162112;
				short num3 = num;
				num = (short)1407123456;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41173.Applicable = value;
			}
		}

		// Token: 0x17002146 RID: 8518
		// (get) Token: 0x060040FB RID: 16635 RVA: 0x003CDB1C File Offset: 0x003CBD1C
		// (set) Token: 0x060040FC RID: 16636 RVA: 0x003CDBD0 File Offset: 0x003CBDD0
		public bool RadWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41173_Valid
		{
			get
			{
				short num = (short)2000898475;
				short num2 = num;
				num = (short)768231851;
				switch (num2 == num)
				{
				}
				num = (short)42729473;
				if (num != 0)
				{
				}
				num = (short)1452212224;
				short num3 = num;
				num = (short)1847656448;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41173.Valid;
			}
			set
			{
				short num = (short)1619963511;
				short num2 = num;
				num = (short)783855223;
				switch (num2 == num)
				{
				}
				num = (short)1234960384;
				if (num != 0)
				{
				}
				num = (short)2099970048;
				short num3 = num;
				num = (short)1144848385;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41173.Valid = value;
			}
		}

		// Token: 0x17002147 RID: 8519
		// (get) Token: 0x060040FD RID: 16637 RVA: 0x003CDC84 File Offset: 0x003CBE84
		// (set) Token: 0x060040FE RID: 16638 RVA: 0x003CDD38 File Offset: 0x003CBF38
		public bool RadWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41173_Visible
		{
			get
			{
				short num = (short)552395195;
				short num2 = num;
				num = (short)1092608443;
				switch (num2 == num)
				{
				}
				num = (short)29097985;
				if (num != 0)
				{
				}
				num = (short)174129152;
				short num3 = num;
				num = (short)121307136;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41173.Visible;
			}
			set
			{
				short num = (short)806486016;
				short num2 = num;
				num = (short)391738609;
				short num3 = num;
				num = (short)748188913;
				switch (num3 == num)
				{
				}
				num = (short)716046337;
				if (num != 0)
				{
				}
				num = (short)630980608;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41173.Visible = value;
			}
		}

		// Token: 0x17002148 RID: 8520
		// (get) Token: 0x060040FF RID: 16639 RVA: 0x003CDDEC File Offset: 0x003CBFEC
		// (set) Token: 0x06004100 RID: 16640 RVA: 0x003CDEA0 File Offset: 0x003CC0A0
		public bool RadWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41173_Editable
		{
			get
			{
				short num = (short)532873216;
				short num2 = num;
				num = (short)162236686;
				short num3 = num;
				num = (short)1542293774;
				switch (num3 == num)
				{
				}
				num = (short)236453889;
				if (num != 0)
				{
				}
				num = (short)36896768;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41173.Editable;
			}
			set
			{
				short num = (short)1559166976;
				short num2 = num;
				num = (short)1082116954;
				short num3 = num;
				num = (short)129485658;
				switch (num3 == num)
				{
				}
				num = (short)954728449;
				if (num != 0)
				{
				}
				num = (short)918290432;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41173.Editable = value;
			}
		}

		// Token: 0x17002149 RID: 8521
		// (get) Token: 0x06004101 RID: 16641 RVA: 0x003CDF54 File Offset: 0x003CC154
		internal string RadWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41173_UILabel
		{
			get
			{
				short num = (short)375586816;
				short num2 = num;
				num = (short)643790898;
				short num3 = num;
				num = (short)2140370994;
				switch (num3 == num)
				{
				}
				num = (short)2144927745;
				if (num != 0)
				{
				}
				num = (short)1662517248;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41173.UIName;
			}
		}

		// Token: 0x1700214A RID: 8522
		// (get) Token: 0x06004102 RID: 16642 RVA: 0x003CE008 File Offset: 0x003CC208
		// (set) Token: 0x06004103 RID: 16643 RVA: 0x003CE0C0 File Offset: 0x003CC2C0
		internal bool RadWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41173_HiddenStatic
		{
			get
			{
				short num = (short)1175715840;
				short num2 = num;
				num = (short)306674640;
				short num3 = num;
				num = (short)835812304;
				switch (num3 == num)
				{
				}
				num = (short)55902209;
				if (num != 0)
				{
				}
				num = (short)520683520;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41173.HiddenStatic;
			}
			set
			{
				short num = (short)2057830400;
				short num2 = num;
				num = (short)1297119628;
				short num3 = num;
				num = (short)1007188364;
				switch (num3 == num)
				{
				}
				num = (short)1599733760;
				if (num != 0)
				{
				}
				num = (short)84410369;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41173.HiddenStatic = value;
			}
		}

		// Token: 0x1700214B RID: 8523
		// (get) Token: 0x06004104 RID: 16644 RVA: 0x003CE174 File Offset: 0x003CC374
		// (set) Token: 0x06004105 RID: 16645 RVA: 0x003CE228 File Offset: 0x003CC428
		internal bool RadWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41173_HiddenDynamic
		{
			get
			{
				short num = (short)357367808;
				short num2 = num;
				num = (short)859564411;
				short num3 = num;
				num = (short)697690491;
				switch (num3 == num)
				{
				}
				num = (short)1932328960;
				if (num != 0)
				{
				}
				num = (short)1566048257;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41173.HiddenDynamic;
			}
			set
			{
				short num = (short)1496711168;
				short num2 = num;
				num = (short)1301666350;
				short num3 = num;
				num = (short)1726994990;
				switch (num3 == num)
				{
				}
				num = (short)89391105;
				if (num != 0)
				{
				}
				num = (short)907673600;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41173.HiddenDynamic = value;
			}
		}

		// Token: 0x1700214C RID: 8524
		// (get) Token: 0x06004106 RID: 16646 RVA: 0x003CE2E0 File Offset: 0x003CC4E0
		public bool RadWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41173_HasDiffs
		{
			get
			{
				short num = (short)542703616;
				short num2 = num;
				num = (short)1986315586;
				short num3 = num;
				num = (short)861914434;
				switch (num3 == num)
				{
				}
				num = (short)328400897;
				if (num != 0)
				{
				}
				num = (short)567541760;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41173._HasDiffs;
			}
		}

		// Token: 0x1700214D RID: 8525
		// (get) Token: 0x06004107 RID: 16647 RVA: 0x003CE394 File Offset: 0x003CC594
		// (set) Token: 0x06004108 RID: 16648 RVA: 0x003CE448 File Offset: 0x003CC648
		public int RadWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41174Value
		{
			get
			{
				short num = (short)1290469376;
				short num2 = num;
				num = (short)357874833;
				short num3 = num;
				num = (short)584039569;
				switch (num3 == num)
				{
				}
				num = (short)1798111233;
				if (num != 0)
				{
				}
				num = (short)1846804480;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41174.Value;
			}
			set
			{
				short num = (short)93323264;
				short num2 = num;
				num = (short)1361280971;
				short num3 = num;
				num = (short)601128907;
				switch (num3 == num)
				{
				}
				num = (short)195035137;
				if (num != 0)
				{
				}
				num = (short)1982267392;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41174.Value = value;
			}
		}

		// Token: 0x1700214E RID: 8526
		// (get) Token: 0x06004109 RID: 16649 RVA: 0x003CE4FC File Offset: 0x003CC6FC
		public global::AcpBusinessLayer.AcpRangeField<int, string> RadWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41174
		{
			get
			{
				short num = (short)159645696;
				short num2 = num;
				num = (short)200212481;
				if (num != 0)
				{
				}
				num = (short)2012852290;
				short num3 = num;
				num = (short)537899074;
				switch (num3 == num)
				{
				}
				num = (short)1020788736;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41174;
			}
		}

		// Token: 0x1700214F RID: 8527
		// (get) Token: 0x0600410A RID: 16650 RVA: 0x003CE5AC File Offset: 0x003CC7AC
		// (set) Token: 0x0600410B RID: 16651 RVA: 0x003CE660 File Offset: 0x003CC860
		public string RadWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41174_UIValue
		{
			get
			{
				short num = (short)1790509056;
				short num2 = num;
				num = (short)1194519424;
				short num3 = num;
				num = (short)1902439296;
				switch (num3 == num)
				{
				}
				num = (short)1150550017;
				if (num != 0)
				{
				}
				num = (short)2081554432;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41174.UIValue;
			}
			set
			{
				short num = (short)999555072;
				short num2 = num;
				num = (short)261810898;
				short num3 = num;
				num = (short)993979090;
				switch (num3 == num)
				{
				}
				num = (short)15007745;
				if (num != 0)
				{
				}
				num = (short)789577728;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41174.UIValue = value;
			}
		}

		// Token: 0x17002150 RID: 8528
		// (get) Token: 0x0600410C RID: 16652 RVA: 0x003CE718 File Offset: 0x003CC918
		// (set) Token: 0x0600410D RID: 16653 RVA: 0x003CE7D0 File Offset: 0x003CC9D0
		internal int RadWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41174Min
		{
			get
			{
				short num = (short)133431296;
				short num2 = num;
				num = (short)636396957;
				short num3 = num;
				num = (short)1461822877;
				switch (num3 == num)
				{
				}
				num = (short)2045706240;
				if (num != 0)
				{
				}
				num = (short)1336999937;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41174.Min;
			}
			set
			{
				short num = (short)1368522752;
				short num2 = num;
				num = (short)182134499;
				short num3 = num;
				num = (short)915941091;
				switch (num3 == num)
				{
				}
				num = (short)1070989312;
				if (num != 0)
				{
				}
				num = (short)529661953;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41174.Min = value;
			}
		}

		// Token: 0x17002151 RID: 8529
		// (get) Token: 0x0600410E RID: 16654 RVA: 0x003CE888 File Offset: 0x003CCA88
		// (set) Token: 0x0600410F RID: 16655 RVA: 0x003CE93C File Offset: 0x003CCB3C
		internal int RadWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41174Max
		{
			get
			{
				short num = (short)515964928;
				short num2 = num;
				num = (short)243531777;
				if (num != 0)
				{
				}
				num = (short)1844995908;
				short num3 = num;
				num = (short)2055432004;
				switch (num3 == num)
				{
				}
				num = (short)2122842112;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41174.Max;
			}
			set
			{
				short num = (short)172032000;
				short num2 = num;
				num = (short)1097588387;
				short num3 = num;
				num = (short)270261923;
				switch (num3 == num)
				{
				}
				num = (short)276234241;
				if (num != 0)
				{
				}
				num = (short)1894383616;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41174.Max = value;
			}
		}

		// Token: 0x17002152 RID: 8530
		// (get) Token: 0x06004110 RID: 16656 RVA: 0x003CE9F4 File Offset: 0x003CCBF4
		// (set) Token: 0x06004111 RID: 16657 RVA: 0x003CEAA8 File Offset: 0x003CCCA8
		internal int RadWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41174Step
		{
			get
			{
				short num = (short)69664768;
				short num2 = num;
				num = (short)2014293762;
				short num3 = num;
				num = (short)1023258370;
				switch (num3 == num)
				{
				}
				num = (short)1088356352;
				if (num != 0)
				{
				}
				num = (short)488701953;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41174.StepSize;
			}
			set
			{
				short num = (short)1735327744;
				short num2 = num;
				num = (short)761534675;
				short num3 = num;
				num = (short)1044977875;
				switch (num3 == num)
				{
				}
				num = (short)1347944449;
				if (num != 0)
				{
				}
				num = (short)489881600;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41174.StepSize = value;
			}
		}

		// Token: 0x17002153 RID: 8531
		// (get) Token: 0x06004112 RID: 16658 RVA: 0x003CEB5C File Offset: 0x003CCD5C
		// (set) Token: 0x06004113 RID: 16659 RVA: 0x003CEC10 File Offset: 0x003CCE10
		public bool RadWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41174_Applicable
		{
			get
			{
				short num = (short)1933246464;
				short num2 = num;
				num = (short)1414580928;
				short num3 = num;
				num = (short)1725024960;
				switch (num3 == num)
				{
				}
				num = (short)1363869697;
				if (num != 0)
				{
				}
				num = (short)1596129280;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41174.Applicable;
			}
			set
			{
				short num = (short)1592786944;
				short num2 = num;
				num = (short)1060007058;
				short num3 = num;
				num = (short)1125215378;
				switch (num3 == num)
				{
				}
				num = (short)1873870849;
				if (num != 0)
				{
				}
				num = (short)278855680;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41174.Applicable = value;
			}
		}

		// Token: 0x17002154 RID: 8532
		// (get) Token: 0x06004114 RID: 16660 RVA: 0x003CECC4 File Offset: 0x003CCEC4
		// (set) Token: 0x06004115 RID: 16661 RVA: 0x003CED78 File Offset: 0x003CCF78
		public bool RadWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41174_Valid
		{
			get
			{
				short num = (short)156499968;
				short num2 = num;
				num = (short)2069326973;
				short num3 = num;
				num = (short)1909484669;
				switch (num3 == num)
				{
				}
				num = (short)1666449409;
				if (num != 0)
				{
				}
				num = (short)1302790144;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41174.Valid;
			}
			set
			{
				short num = (short)186187776;
				short num2 = num;
				num = (short)900857857;
				if (num != 0)
				{
				}
				num = (short)1322576127;
				short num3 = num;
				num = (short)1793190143;
				switch (num3 == num)
				{
				}
				num = (short)1961754624;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41174.Valid = value;
			}
		}

		// Token: 0x17002155 RID: 8533
		// (get) Token: 0x06004116 RID: 16662 RVA: 0x003CEE2C File Offset: 0x003CD02C
		// (set) Token: 0x06004117 RID: 16663 RVA: 0x003CEEE0 File Offset: 0x003CD0E0
		public bool RadWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41174_Visible
		{
			get
			{
				short num = (short)1455620096;
				short num2 = num;
				num = (short)1402601473;
				if (num != 0)
				{
				}
				num = (short)317642752;
				short num3 = num;
				num = (short)252565504;
				switch (num3 == num)
				{
				}
				num = (short)48627712;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41174.Visible;
			}
			set
			{
				short num = (short)199294976;
				short num2 = num;
				num = (short)133856111;
				short num3 = num;
				num = (short)1393785711;
				switch (num3 == num)
				{
				}
				num = (short)914817024;
				if (num != 0)
				{
				}
				num = (short)1051131905;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41174.Visible = value;
			}
		}

		// Token: 0x17002156 RID: 8534
		// (get) Token: 0x06004118 RID: 16664 RVA: 0x003CEF94 File Offset: 0x003CD194
		// (set) Token: 0x06004119 RID: 16665 RVA: 0x003CF048 File Offset: 0x003CD248
		public bool RadWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41174_Editable
		{
			get
			{
				short num = (short)313196544;
				short num2 = num;
				num = (short)974472851;
				short num3 = num;
				num = (short)2111260307;
				switch (num3 == num)
				{
				}
				num = (short)303497217;
				if (num != 0)
				{
				}
				num = (short)928645120;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41174.Editable;
			}
			set
			{
				short num = (short)1570701312;
				short num2 = num;
				num = (short)969878165;
				short num3 = num;
				num = (short)1241918101;
				switch (num3 == num)
				{
				}
				num = (short)852033537;
				if (num != 0)
				{
				}
				num = (short)1397227520;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41174.Editable = value;
			}
		}

		// Token: 0x17002157 RID: 8535
		// (get) Token: 0x0600411A RID: 16666 RVA: 0x003CF0FC File Offset: 0x003CD2FC
		internal string RadWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41174_UILabel
		{
			get
			{
				short num = (short)1002766336;
				short num2 = num;
				num = (short)27189015;
				short num3 = num;
				num = (short)932110103;
				switch (num3 == num)
				{
				}
				num = (short)1493237761;
				if (num != 0)
				{
				}
				num = (short)130940928;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41174.UIName;
			}
		}

		// Token: 0x17002158 RID: 8536
		// (get) Token: 0x0600411B RID: 16667 RVA: 0x003CF1B0 File Offset: 0x003CD3B0
		// (set) Token: 0x0600411C RID: 16668 RVA: 0x003CF264 File Offset: 0x003CD464
		internal bool RadWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41174_HiddenStatic
		{
			get
			{
				short num = (short)154664960;
				short num2 = num;
				num = (short)761721720;
				short num3 = num;
				num = (short)2057827192;
				switch (num3 == num)
				{
				}
				num = (short)656539649;
				if (num != 0)
				{
				}
				num = (short)87228416;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41174.HiddenStatic;
			}
			set
			{
				short num = (short)895025152;
				short num2 = num;
				num = (short)1363136948;
				short num3 = num;
				num = (short)465555892;
				switch (num3 == num)
				{
				}
				num = (short)328859648;
				if (num != 0)
				{
				}
				num = (short)299368449;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41174.HiddenStatic = value;
			}
		}

		// Token: 0x17002159 RID: 8537
		// (get) Token: 0x0600411D RID: 16669 RVA: 0x003CF31C File Offset: 0x003CD51C
		// (set) Token: 0x0600411E RID: 16670 RVA: 0x003CF3D4 File Offset: 0x003CD5D4
		internal bool RadWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41174_HiddenDynamic
		{
			get
			{
				short num = (short)906231808;
				short num2 = num;
				num = (short)153822676;
				short num3 = num;
				num = (short)1317414356;
				switch (num3 == num)
				{
				}
				num = (short)1896349697;
				if (num != 0)
				{
				}
				num = (short)600178688;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41174.HiddenDynamic;
			}
			set
			{
				short num = (short)1626472448;
				short num2 = num;
				num = (short)17714429;
				short num3 = num;
				num = (short)23678205;
				switch (num3 == num)
				{
				}
				num = (short)52428801;
				if (num != 0)
				{
				}
				num = (short)186974208;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41174.HiddenDynamic = value;
			}
		}

		// Token: 0x1700215A RID: 8538
		// (get) Token: 0x0600411F RID: 16671 RVA: 0x003CF48C File Offset: 0x003CD68C
		public bool RadWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41174_HasDiffs
		{
			get
			{
				short num = (short)2083258368;
				short num2 = num;
				num = (short)1657274369;
				if (num != 0)
				{
				}
				num = (short)401008316;
				short num3 = num;
				num = (short)374531772;
				switch (num3 == num)
				{
				}
				num = (short)1914044416;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41174._HasDiffs;
			}
		}

		// Token: 0x1700215B RID: 8539
		// (get) Token: 0x06004120 RID: 16672 RVA: 0x003CF540 File Offset: 0x003CD740
		// (set) Token: 0x06004121 RID: 16673 RVA: 0x003CF5F4 File Offset: 0x003CD7F4
		public int RadWideTransmitPowerLevelsConvTxPowerLevelLowW_A41175Value
		{
			get
			{
				short num = (short)2092302336;
				short num2 = num;
				num = (short)2140940765;
				short num3 = num;
				num = (short)1795828189;
				switch (num3 == num)
				{
				}
				num = (short)2094661633;
				if (num != 0)
				{
				}
				num = (short)1817772032;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41175.Value;
			}
			set
			{
				short num = (short)627494167;
				short num2 = num;
				num = (short)84331799;
				switch (num2 == num)
				{
				}
				num = (short)1857880065;
				if (num != 0)
				{
				}
				num = (short)1943339008;
				if (num != 0)
				{
				}
				num = (short)1641086976;
				short num3 = num;
				this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41175.Value = value;
			}
		}

		// Token: 0x1700215C RID: 8540
		// (get) Token: 0x06004122 RID: 16674 RVA: 0x003CF6A8 File Offset: 0x003CD8A8
		public global::AcpBusinessLayer.AcpRangeField<int, string> RadWideTransmitPowerLevelsConvTxPowerLevelLowW_A41175
		{
			get
			{
				short num = (short)353667802;
				short num2 = num;
				num = (short)1074891482;
				switch (num2 == num)
				{
				}
				num = (short)539820033;
				if (num != 0)
				{
				}
				num = (short)641073152;
				if (num != 0)
				{
				}
				num = (short)1225523200;
				short num3 = num;
				return this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41175;
			}
		}

		// Token: 0x1700215D RID: 8541
		// (get) Token: 0x06004123 RID: 16675 RVA: 0x003CF758 File Offset: 0x003CD958
		// (set) Token: 0x06004124 RID: 16676 RVA: 0x003CF810 File Offset: 0x003CDA10
		public string RadWideTransmitPowerLevelsConvTxPowerLevelLowW_A41175_UIValue
		{
			get
			{
				short num = (short)1834765399;
				short num2 = num;
				num = (short)444419159;
				switch (num2 == num)
				{
				}
				num = (short)328400897;
				if (num != 0)
				{
				}
				num = (short)398983168;
				if (num != 0)
				{
				}
				num = (short)35454976;
				short num3 = num;
				return this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41175.UIValue;
			}
			set
			{
				short num = (short)43631896;
				short num2 = num;
				num = (short)256230680;
				switch (num2 == num)
				{
				}
				num = (short)444727297;
				if (num != 0)
				{
				}
				num = (short)425984000;
				if (num != 0)
				{
				}
				num = (short)1215758336;
				short num3 = num;
				this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41175.UIValue = value;
			}
		}

		// Token: 0x1700215E RID: 8542
		// (get) Token: 0x06004125 RID: 16677 RVA: 0x003CF8C4 File Offset: 0x003CDAC4
		// (set) Token: 0x06004126 RID: 16678 RVA: 0x003CF978 File Offset: 0x003CDB78
		internal int RadWideTransmitPowerLevelsConvTxPowerLevelLowW_A41175Min
		{
			get
			{
				short num = (short)560894398;
				short num2 = num;
				num = (short)1203933630;
				switch (num2 == num)
				{
				}
				num = (short)1511522304;
				if (num != 0)
				{
				}
				num = (short)2029584385;
				if (num != 0)
				{
				}
				num = (short)964165632;
				short num3 = num;
				return this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41175.Min;
			}
			set
			{
				short num = (short)860585934;
				short num2 = num;
				num = (short)831029198;
				switch (num2 == num)
				{
				}
				num = (short)75300864;
				if (num != 0)
				{
				}
				num = (short)1130364929;
				if (num != 0)
				{
				}
				num = (short)487784448;
				short num3 = num;
				this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41175.Min = value;
			}
		}

		// Token: 0x1700215F RID: 8543
		// (get) Token: 0x06004127 RID: 16679 RVA: 0x003CFA2C File Offset: 0x003CDC2C
		// (set) Token: 0x06004128 RID: 16680 RVA: 0x003CFAE0 File Offset: 0x003CDCE0
		internal int RadWideTransmitPowerLevelsConvTxPowerLevelLowW_A41175Max
		{
			get
			{
				short num = (short)643776024;
				short num2 = num;
				num = (short)2095791640;
				switch (num2 == num)
				{
				}
				num = (short)325517313;
				if (num != 0)
				{
				}
				num = (short)1396375552;
				if (num != 0)
				{
				}
				num = (short)1721106432;
				short num3 = num;
				return this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41175.Max;
			}
			set
			{
				short num = (short)2035153178;
				short num2 = num;
				num = (short)1074919706;
				switch (num2 == num)
				{
				}
				num = (short)413728769;
				if (num != 0)
				{
				}
				num = (short)1916862464;
				if (num != 0)
				{
				}
				num = (short)1239285760;
				short num3 = num;
				this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41175.Max = value;
			}
		}

		// Token: 0x17002160 RID: 8544
		// (get) Token: 0x06004129 RID: 16681 RVA: 0x003CFB98 File Offset: 0x003CDD98
		// (set) Token: 0x0600412A RID: 16682 RVA: 0x003CFC50 File Offset: 0x003CDE50
		internal int RadWideTransmitPowerLevelsConvTxPowerLevelLowW_A41175Step
		{
			get
			{
				short num = (short)1902886032;
				short num2 = num;
				num = (short)803847312;
				switch (num2 == num)
				{
				}
				num = (short)1005912065;
				if (num != 0)
				{
				}
				num = (short)1363476480;
				if (num != 0)
				{
				}
				num = (short)263061504;
				short num3 = num;
				return this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41175.StepSize;
			}
			set
			{
				short num = (short)1710814628;
				short num2 = num;
				num = (short)1515517348;
				switch (num2 == num)
				{
				}
				num = (short)991232001;
				if (num != 0)
				{
				}
				num = (short)1431306240;
				if (num != 0)
				{
				}
				num = (short)695599104;
				short num3 = num;
				this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41175.StepSize = value;
			}
		}

		// Token: 0x17002161 RID: 8545
		// (get) Token: 0x0600412B RID: 16683 RVA: 0x003CFD04 File Offset: 0x003CDF04
		// (set) Token: 0x0600412C RID: 16684 RVA: 0x003CFDB8 File Offset: 0x003CDFB8
		public bool RadWideTransmitPowerLevelsConvTxPowerLevelLowW_A41175_Applicable
		{
			get
			{
				short num = (short)1672806401;
				if (num != 0)
				{
				}
				num = (short)560589459;
				short num2 = num;
				num = (short)640281235;
				switch (num2 == num)
				{
				}
				num = (short)499843072;
				if (num != 0)
				{
				}
				num = (short)341573632;
				short num3 = num;
				return this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41175.Applicable;
			}
			set
			{
				short num = (short)94674385;
				short num2 = num;
				num = (short)1319935441;
				switch (num2 == num)
				{
				}
				num = (short)586285057;
				if (num != 0)
				{
				}
				num = (short)851836928;
				if (num != 0)
				{
				}
				num = (short)1985609728;
				short num3 = num;
				this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41175.Applicable = value;
			}
		}

		// Token: 0x17002162 RID: 8546
		// (get) Token: 0x0600412D RID: 16685 RVA: 0x003CFE74 File Offset: 0x003CE074
		// (set) Token: 0x0600412E RID: 16686 RVA: 0x003CFF28 File Offset: 0x003CE128
		public bool RadWideTransmitPowerLevelsConvTxPowerLevelLowW_A41175_Valid
		{
			get
			{
				short num = (short)286785537;
				if (num != 0)
				{
				}
				num = (short)329626845;
				short num2 = num;
				num = (short)921875677;
				switch (num2 == num)
				{
				}
				num = (short)854851584;
				if (num != 0)
				{
				}
				num = (short)1227489280;
				short num3 = num;
				return this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41175.Valid;
			}
			set
			{
				short num = (short)1320647837;
				short num2 = num;
				num = (short)1814396061;
				switch (num2 == num)
				{
				}
				num = (short)1416953857;
				if (num != 0)
				{
				}
				num = (short)1886912512;
				if (num != 0)
				{
				}
				num = (short)1111359488;
				short num3 = num;
				this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41175.Valid = value;
			}
		}

		// Token: 0x17002163 RID: 8547
		// (get) Token: 0x0600412F RID: 16687 RVA: 0x003CFFE0 File Offset: 0x003CE1E0
		// (set) Token: 0x06004130 RID: 16688 RVA: 0x003D0098 File Offset: 0x003CE298
		public bool RadWideTransmitPowerLevelsConvTxPowerLevelLowW_A41175_Visible
		{
			get
			{
				short num = (short)593368841;
				short num2 = num;
				num = (short)1088165641;
				switch (num2 == num)
				{
				}
				num = (short)111542273;
				if (num != 0)
				{
				}
				num = (short)1538260992;
				if (num != 0)
				{
				}
				num = (short)291307520;
				short num3 = num;
				return this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41175.Visible;
			}
			set
			{
				short num = (short)139495249;
				short num2 = num;
				num = (short)734234449;
				switch (num2 == num)
				{
				}
				num = (short)782172160;
				if (num != 0)
				{
				}
				num = (short)2065891329;
				if (num != 0)
				{
				}
				num = (short)392888320;
				short num3 = num;
				this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41175.Visible = value;
			}
		}

		// Token: 0x17002164 RID: 8548
		// (get) Token: 0x06004131 RID: 16689 RVA: 0x003D014C File Offset: 0x003CE34C
		// (set) Token: 0x06004132 RID: 16690 RVA: 0x003D0204 File Offset: 0x003CE404
		public bool RadWideTransmitPowerLevelsConvTxPowerLevelLowW_A41175_Editable
		{
			get
			{
				short num = (short)682433022;
				short num2 = num;
				num = (short)1332484606;
				switch (num2 == num)
				{
				}
				num = (short)1336672257;
				if (num != 0)
				{
				}
				num = (short)1657470976;
				if (num != 0)
				{
				}
				num = (short)703070208;
				short num3 = num;
				return this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41175.Editable;
			}
			set
			{
				short num = (short)749836969;
				short num2 = num;
				num = (short)9214633;
				switch (num2 == num)
				{
				}
				num = (short)231931905;
				if (num != 0)
				{
				}
				num = (short)1894187008;
				if (num != 0)
				{
				}
				num = (short)252313600;
				short num3 = num;
				this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41175.Editable = value;
			}
		}

		// Token: 0x17002165 RID: 8549
		// (get) Token: 0x06004133 RID: 16691 RVA: 0x003D02BC File Offset: 0x003CE4BC
		internal string RadWideTransmitPowerLevelsConvTxPowerLevelLowW_A41175_UILabel
		{
			get
			{
				short num = (short)162174371;
				short num2 = num;
				num = (short)1292146083;
				switch (num2 == num)
				{
				}
				num = (short)1028521985;
				if (num != 0)
				{
				}
				num = (short)226361344;
				if (num != 0)
				{
				}
				num = (short)1922629632;
				short num3 = num;
				return this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41175.UIName;
			}
		}

		// Token: 0x17002166 RID: 8550
		// (get) Token: 0x06004134 RID: 16692 RVA: 0x003D0370 File Offset: 0x003CE570
		// (set) Token: 0x06004135 RID: 16693 RVA: 0x003D0428 File Offset: 0x003CE628
		internal bool RadWideTransmitPowerLevelsConvTxPowerLevelLowW_A41175_HiddenStatic
		{
			get
			{
				short num = (short)419692545;
				if (num != 0)
				{
				}
				num = (short)937039610;
				short num2 = num;
				num = (short)1827870458;
				switch (num2 == num)
				{
				}
				num = (short)1823080448;
				if (num != 0)
				{
				}
				num = (short)1298202624;
				short num3 = num;
				return this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41175.HiddenStatic;
			}
			set
			{
				short num = (short)1758396417;
				if (num != 0)
				{
				}
				num = (short)1131284575;
				short num2 = num;
				num = (short)219154527;
				switch (num2 == num)
				{
				}
				num = (short)83230720;
				if (num != 0)
				{
				}
				num = (short)1803354112;
				short num3 = num;
				this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41175.HiddenStatic = value;
			}
		}

		// Token: 0x17002167 RID: 8551
		// (get) Token: 0x06004136 RID: 16694 RVA: 0x003D04DC File Offset: 0x003CE6DC
		// (set) Token: 0x06004137 RID: 16695 RVA: 0x003D0590 File Offset: 0x003CE790
		internal bool RadWideTransmitPowerLevelsConvTxPowerLevelLowW_A41175_HiddenDynamic
		{
			get
			{
				short num = (short)271326353;
				short num2 = num;
				num = (short)919477393;
				switch (num2 == num)
				{
				}
				num = (short)393478145;
				if (num != 0)
				{
				}
				num = (short)742916096;
				if (num != 0)
				{
				}
				num = (short)1643970560;
				short num3 = num;
				return this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41175.HiddenDynamic;
			}
			set
			{
				short num = (short)331145819;
				short num2 = num;
				num = (short)983360091;
				switch (num2 == num)
				{
				}
				num = (short)1975582721;
				if (num != 0)
				{
				}
				num = (short)291635200;
				if (num != 0)
				{
				}
				num = (short)2084896768;
				short num3 = num;
				this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41175.HiddenDynamic = value;
			}
		}

		// Token: 0x17002168 RID: 8552
		// (get) Token: 0x06004138 RID: 16696 RVA: 0x003D0644 File Offset: 0x003CE844
		public bool RadWideTransmitPowerLevelsConvTxPowerLevelLowW_A41175_HasDiffs
		{
			get
			{
				short num = (short)2146345009;
				short num2 = num;
				num = (short)1117364273;
				switch (num2 == num)
				{
				}
				num = (short)1005912065;
				if (num != 0)
				{
				}
				num = (short)1622671360;
				if (num != 0)
				{
				}
				num = (short)134742016;
				short num3 = num;
				return this.radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41175._HasDiffs;
			}
		}

		// Token: 0x17002169 RID: 8553
		// (get) Token: 0x06004139 RID: 16697 RVA: 0x003D06F8 File Offset: 0x003CE8F8
		// (set) Token: 0x0600413A RID: 16698 RVA: 0x003D07AC File Offset: 0x003CE9AC
		public int RadWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41176Value
		{
			get
			{
				short num = (short)1923285088;
				short num2 = num;
				num = (short)770834528;
				switch (num2 == num)
				{
				}
				num = (short)281542657;
				if (num != 0)
				{
				}
				num = (short)1188102144;
				if (num != 0)
				{
				}
				num = (short)1334116352;
				short num3 = num;
				return this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41176.Value;
			}
			set
			{
				short num = (short)107426552;
				short num2 = num;
				num = (short)2145399544;
				switch (num2 == num)
				{
				}
				num = (short)1766653952;
				if (num != 0)
				{
				}
				num = (short)2083717121;
				if (num != 0)
				{
				}
				num = (short)1629028352;
				short num3 = num;
				this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41176.Value = value;
			}
		}

		// Token: 0x1700216A RID: 8554
		// (get) Token: 0x0600413B RID: 16699 RVA: 0x003D0860 File Offset: 0x003CEA60
		public global::AcpBusinessLayer.AcpRangeField<int, string> RadWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41176
		{
			get
			{
				short num = (short)1740488422;
				short num2 = num;
				num = (short)1455341286;
				switch (num2 == num)
				{
				}
				num = (short)1869283329;
				if (num != 0)
				{
				}
				num = (short)1521352704;
				if (num != 0)
				{
				}
				num = (short)389218304;
				short num3 = num;
				return this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41176;
			}
		}

		// Token: 0x1700216B RID: 8555
		// (get) Token: 0x0600413C RID: 16700 RVA: 0x003D0910 File Offset: 0x003CEB10
		// (set) Token: 0x0600413D RID: 16701 RVA: 0x003D09C8 File Offset: 0x003CEBC8
		public string RadWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41176_UIValue
		{
			get
			{
				short num = (short)1835596567;
				short num2 = num;
				num = (short)514390807;
				switch (num2 == num)
				{
				}
				num = (short)1473576960;
				if (num != 0)
				{
				}
				num = (short)546504705;
				if (num != 0)
				{
				}
				num = (short)2022572032;
				short num3 = num;
				return this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41176.UIValue;
			}
			set
			{
				short num = (short)2132267466;
				short num2 = num;
				num = (short)2030686666;
				switch (num2 == num)
				{
				}
				num = (short)1688338432;
				if (num != 0)
				{
				}
				num = (short)2072182785;
				if (num != 0)
				{
				}
				num = (short)266731520;
				short num3 = num;
				this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41176.UIValue = value;
			}
		}

		// Token: 0x1700216C RID: 8556
		// (get) Token: 0x0600413E RID: 16702 RVA: 0x003D0A80 File Offset: 0x003CEC80
		// (set) Token: 0x0600413F RID: 16703 RVA: 0x003D0B34 File Offset: 0x003CED34
		internal int RadWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41176Min
		{
			get
			{
				short num = (short)427748061;
				short num2 = num;
				num = (short)1829825245;
				switch (num2 == num)
				{
				}
				num = (short)1263403009;
				if (num != 0)
				{
				}
				num = (short)2101673984;
				if (num != 0)
				{
				}
				num = (short)701497344;
				short num3 = num;
				return this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41176.Min;
			}
			set
			{
				short num = (short)1783889921;
				if (num != 0)
				{
				}
				num = (short)789207543;
				short num2 = num;
				num = (short)873814519;
				switch (num2 == num)
				{
				}
				num = (short)1797718016;
				if (num != 0)
				{
				}
				num = (short)1712717824;
				short num3 = num;
				this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41176.Min = value;
			}
		}

		// Token: 0x1700216D RID: 8557
		// (get) Token: 0x06004140 RID: 16704 RVA: 0x003D0BEC File Offset: 0x003CEDEC
		// (set) Token: 0x06004141 RID: 16705 RVA: 0x003D0CA0 File Offset: 0x003CEEA0
		internal int RadWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41176Max
		{
			get
			{
				short num = (short)1957389125;
				short num2 = num;
				num = (short)447636293;
				switch (num2 == num)
				{
				}
				num = (short)799080449;
				if (num != 0)
				{
				}
				num = (short)290783232;
				if (num != 0)
				{
				}
				num = (short)2004353024;
				short num3 = num;
				return this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41176.Max;
			}
			set
			{
				short num = (short)734135492;
				short num2 = num;
				num = (short)828769476;
				switch (num2 == num)
				{
				}
				num = (short)1192099841;
				if (num != 0)
				{
				}
				num = (short)1227751424;
				if (num != 0)
				{
				}
				num = (short)280297472;
				short num3 = num;
				this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41176.Max = value;
			}
		}

		// Token: 0x1700216E RID: 8558
		// (get) Token: 0x06004142 RID: 16706 RVA: 0x003D0D58 File Offset: 0x003CEF58
		// (set) Token: 0x06004143 RID: 16707 RVA: 0x003D0E0C File Offset: 0x003CF00C
		internal int RadWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41176Step
		{
			get
			{
				short num = (short)587988993;
				if (num != 0)
				{
				}
				num = (short)1950204148;
				short num2 = num;
				num = (short)975880436;
				switch (num2 == num)
				{
				}
				num = (short)1756299264;
				if (num != 0)
				{
				}
				num = (short)1178730496;
				short num3 = num;
				return this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41176.StepSize;
			}
			set
			{
				short num = (short)1191827590;
				short num2 = num;
				num = (short)185653382;
				switch (num2 == num)
				{
				}
				num = (short)1042808833;
				if (num != 0)
				{
				}
				num = (short)1590099968;
				if (num != 0)
				{
				}
				num = (short)1549008896;
				short num3 = num;
				this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41176.StepSize = value;
			}
		}

		// Token: 0x1700216F RID: 8559
		// (get) Token: 0x06004144 RID: 16708 RVA: 0x003D0EC0 File Offset: 0x003CF0C0
		// (set) Token: 0x06004145 RID: 16709 RVA: 0x003D0F74 File Offset: 0x003CF174
		public bool RadWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41176_Applicable
		{
			get
			{
				short num = (short)2075761673;
				short num2 = num;
				num = (short)1097964553;
				switch (num2 == num)
				{
				}
				num = (short)1832714241;
				if (num != 0)
				{
				}
				num = (short)122945536;
				if (num != 0)
				{
				}
				num = (short)1823801344;
				short num3 = num;
				return this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41176.Applicable;
			}
			set
			{
				short num = (short)1971919596;
				short num2 = num;
				num = (short)862722796;
				switch (num2 == num)
				{
				}
				num = (short)1839923200;
				if (num != 0)
				{
				}
				num = (short)14876673;
				if (num != 0)
				{
				}
				num = (short)1119682560;
				short num3 = num;
				this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41176.Applicable = value;
			}
		}

		// Token: 0x17002170 RID: 8560
		// (get) Token: 0x06004146 RID: 16710 RVA: 0x003D102C File Offset: 0x003CF22C
		// (set) Token: 0x06004147 RID: 16711 RVA: 0x003D10E0 File Offset: 0x003CF2E0
		public bool RadWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41176_Valid
		{
			get
			{
				short num = (short)587405706;
				short num2 = num;
				num = (short)526719370;
				switch (num2 == num)
				{
				}
				num = (short)2001600512;
				if (num != 0)
				{
				}
				num = (short)1932066817;
				if (num != 0)
				{
				}
				num = (short)1936064512;
				short num3 = num;
				return this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41176.Valid;
			}
			set
			{
				short num = (short)1482555393;
				if (num != 0)
				{
				}
				num = (short)1087446339;
				short num2 = num;
				num = (short)982326595;
				switch (num2 == num)
				{
				}
				num = (short)939851776;
				if (num != 0)
				{
				}
				num = (short)1237975040;
				short num3 = num;
				this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41176.Valid = value;
			}
		}

		// Token: 0x17002171 RID: 8561
		// (get) Token: 0x06004148 RID: 16712 RVA: 0x003D1194 File Offset: 0x003CF394
		// (set) Token: 0x06004149 RID: 16713 RVA: 0x003D1248 File Offset: 0x003CF448
		public bool RadWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41176_Visible
		{
			get
			{
				short num = (short)1169987844;
				short num2 = num;
				num = (short)1316722948;
				switch (num2 == num)
				{
				}
				num = (short)1992294401;
				if (num != 0)
				{
				}
				num = (short)1252851712;
				if (num != 0)
				{
				}
				num = (short)1638400000;
				short num3 = num;
				return this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41176.Visible;
			}
			set
			{
				short num = (short)856788135;
				short num2 = num;
				num = (short)1086753959;
				switch (num2 == num)
				{
				}
				num = (short)2074607617;
				if (num != 0)
				{
				}
				num = (short)987037696;
				if (num != 0)
				{
				}
				num = (short)491520000;
				short num3 = num;
				this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41176.Visible = value;
			}
		}

		// Token: 0x17002172 RID: 8562
		// (get) Token: 0x0600414A RID: 16714 RVA: 0x003D12FC File Offset: 0x003CF4FC
		// (set) Token: 0x0600414B RID: 16715 RVA: 0x003D13B0 File Offset: 0x003CF5B0
		public bool RadWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41176_Editable
		{
			get
			{
				short num = (short)1157169153;
				if (num != 0)
				{
				}
				num = (short)139293559;
				short num2 = num;
				num = (short)1560441719;
				switch (num2 == num)
				{
				}
				num = (short)1745485824;
				if (num != 0)
				{
				}
				num = (short)558759936;
				short num3 = num;
				return this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41176.Editable;
			}
			set
			{
				short num = (short)1716432876;
				short num2 = num;
				num = (short)1509076972;
				switch (num2 == num)
				{
				}
				num = (short)280625152;
				if (num != 0)
				{
				}
				num = (short)290324481;
				if (num != 0)
				{
				}
				num = (short)1451622400;
				short num3 = num;
				this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41176.Editable = value;
			}
		}

		// Token: 0x17002173 RID: 8563
		// (get) Token: 0x0600414C RID: 16716 RVA: 0x003D1464 File Offset: 0x003CF664
		internal string RadWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41176_UILabel
		{
			get
			{
				short num = (short)1097200474;
				short num2 = num;
				num = (short)1293677402;
				switch (num2 == num)
				{
				}
				num = (short)1529741313;
				if (num != 0)
				{
				}
				num = (short)1698693120;
				if (num != 0)
				{
				}
				num = (short)1231814656;
				short num3 = num;
				return this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41176.UIName;
			}
		}

		// Token: 0x17002174 RID: 8564
		// (get) Token: 0x0600414D RID: 16717 RVA: 0x003D1518 File Offset: 0x003CF718
		// (set) Token: 0x0600414E RID: 16718 RVA: 0x003D15CC File Offset: 0x003CF7CC
		internal bool RadWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41176_HiddenStatic
		{
			get
			{
				short num = (short)1799875948;
				short num2 = num;
				num = (short)18017644;
				switch (num2 == num)
				{
				}
				num = (short)315228160;
				if (num != 0)
				{
				}
				num = (short)1186004993;
				if (num != 0)
				{
				}
				num = (short)360448000;
				short num3 = num;
				return this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41176.HiddenStatic;
			}
			set
			{
				short num = (short)1823604736;
				short num2 = num;
				num = (short)1850072478;
				short num3 = num;
				num = (short)1535827358;
				switch (num3 == num)
				{
				}
				num = (short)765460481;
				if (num != 0)
				{
				}
				num = (short)560922624;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41176.HiddenStatic = value;
			}
		}

		// Token: 0x17002175 RID: 8565
		// (get) Token: 0x0600414F RID: 16719 RVA: 0x003D1680 File Offset: 0x003CF880
		// (set) Token: 0x06004150 RID: 16720 RVA: 0x003D1734 File Offset: 0x003CF934
		internal bool RadWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41176_HiddenDynamic
		{
			get
			{
				short num = (short)45613056;
				short num2 = num;
				num = (short)2043936769;
				if (num != 0)
				{
				}
				num = (short)1783599542;
				short num3 = num;
				num = (short)1126666678;
				switch (num3 == num)
				{
				}
				num = (short)842137600;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41176.HiddenDynamic;
			}
			set
			{
				short num = (short)1982726144;
				short num2 = num;
				num = (short)1520938488;
				short num3 = num;
				num = (short)257732088;
				switch (num3 == num)
				{
				}
				num = (short)681246720;
				if (num != 0)
				{
				}
				num = (short)1363804161;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41176.HiddenDynamic = value;
			}
		}

		// Token: 0x17002176 RID: 8566
		// (get) Token: 0x06004151 RID: 16721 RVA: 0x003D17E8 File Offset: 0x003CF9E8
		public bool RadWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41176_HasDiffs
		{
			get
			{
				short num = (short)1742995456;
				short num2 = num;
				num = (short)1568327694;
				short num3 = num;
				num = (short)1890633742;
				switch (num3 == num)
				{
				}
				num = (short)45154305;
				if (num != 0)
				{
				}
				num = (short)1164705792;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41176._HasDiffs;
			}
		}

		// Token: 0x17002177 RID: 8567
		// (get) Token: 0x06004152 RID: 16722 RVA: 0x003D189C File Offset: 0x003CFA9C
		public global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation RefRadioInformation
		{
			get
			{
				short num = (short)1028325376;
				short num2 = num;
				num = (short)1439788070;
				short num3 = num;
				num = (short)237136934;
				switch (num3 == num)
				{
				}
				num = (short)1262288897;
				if (num != 0)
				{
				}
				num = (short)2137718784;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation;
			}
		}

		// Token: 0x06004153 RID: 16723 RVA: 0x003D195C File Offset: 0x003CFB5C
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_70;
			}
			short num;
			int num3;
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_0A:
				num = (short)1825814453;
				short num2 = num;
				num = (short)453359541;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1996947456;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
						num = (short)1919418369;
						if (num != 0)
						{
						}
						if (base.ParentRecset != null)
						{
							goto IL_BA;
						}
						return result;
					case 1:
						if (base.ParentRecset.ContainerDoc != null)
						{
							num = (short)1641742338;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 2:
						result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
						num = (short)271777796;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						num = (short)1276903424;
						short num4 = num;
						num = (short)2029715457;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						return result;
					}
					goto IL_70;
				}
				IL_BA:
				num = (short)1584070659;
				num3 = (int)((global::System.IntPtr)num);
			}
			return result;
			IL_70:
			result = null;
			num = (short)525729792;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x04001A06 RID: 6662
		private global::AcpBusinessLayer.AcpRangeField<int, string> radWideTransmitPowerLevelsTxPowerLevelHighW_A8152;

		// Token: 0x04001A07 RID: 6663
		private global::AcpBusinessLayer.AcpRangeField<int, string> radWideTransmitPowerLevelsTxPowerLevelLowW_A8153;

		// Token: 0x04001A08 RID: 6664
		private global::AcpBusinessLayer.AcpFrequencyField radWideTransmitPowerLevelsFrequencyRangeStartMHz_A19994;

		// Token: 0x04001A09 RID: 6665
		private global::AcpBusinessLayer.AcpFrequencyField radWideTransmitPowerLevelsFrequencyRangeEndMHz_A20037;

		// Token: 0x04001A0A RID: 6666
		private global::AcpBusinessLayer.AcpRangeField<int, string> radWideTransmitPowerLevelsTxPowerLevelMinimumW_A20038;

		// Token: 0x04001A0B RID: 6667
		private global::AcpBusinessLayer.AcpRangeField<int, string> radWideTransmitPowerLevelsTxPowerLevelMaximumW_A20039;

		// Token: 0x04001A0C RID: 6668
		private global::AcpBusinessLayer.AcpField<string> radWidePowerLevelBandFrequency_A41063;

		// Token: 0x04001A0D RID: 6669
		private global::AcpBusinessLayer.AcpRangeField<int, string> radWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41173;

		// Token: 0x04001A0E RID: 6670
		private global::AcpBusinessLayer.AcpRangeField<int, string> radWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41174;

		// Token: 0x04001A0F RID: 6671
		private global::AcpBusinessLayer.AcpRangeField<int, string> radWideTransmitPowerLevelsConvTxPowerLevelLowW_A41175;

		// Token: 0x04001A10 RID: 6672
		private global::AcpBusinessLayer.AcpRangeField<int, string> radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41176;
	}
}
