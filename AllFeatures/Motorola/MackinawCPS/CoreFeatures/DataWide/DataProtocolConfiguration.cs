using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using Motorola.MackinawCPS.CoreFeatures.RadioInformation;

namespace Motorola.MackinawCPS.CoreFeatures.DataWide
{
	// Token: 0x020004CD RID: 1229
	[global::System.Serializable]
	public class DataProtocolConfiguration : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600A24C RID: 41548 RVA: 0x00977948 File Offset: 0x00975B48
		public DataProtocolConfiguration(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x0600A24D RID: 41549 RVA: 0x00977964 File Offset: 0x00975B64
		protected DataProtocolConfiguration(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600A24E RID: 41550 RVA: 0x0097797C File Offset: 0x00975B7C
		public override void Init()
		{
			int a_ = 4;
			short num = (short)1891563097;
			short num2 = num;
			num = (short)888403545;
			switch (num2 == num)
			{
			}
			num = (short)441974785;
			if (num != 0)
			{
			}
			num = (short)1192951808;
			short num3 = num;
			num = (short)210108416;
			if (num != 0)
			{
			}
			this.dataConfigDataWideMaxNumofNonTCPIPHCContexts_A36192 = new global::AcpBusinessLayer.AcpSimpleRangeField(8, this, global::AllFeatures.CodeplugGuid.b("臄ꛆ뷈꫊軌ꃎ뿐뗒볔냖鷘뫚꧜뻞뛠諢臤苦ꓨ諪闬ꇮ蓰黲髴釶럸铺鏼꯾䈀匂䰄圆䄈䠊丌怎缐朒瀔漖洘栚䈜帞ሠᔢᐤḦᬨ", a_), global::CommonResources.AcgResources.ID_MAXPOFNONTCPIPHEADERCOMPRESSIONCONTEXTS, 0, 16, null, null, 0, 1);
			this.dataConfigDataWideMaxNumofNonTCPIPHCContexts_A36192.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.dataConfigDataWideMaxNumofNonTCPIPHCContexts_A36192.DataTransferOrder = 17;
			this.dataConfigDataWideMaxNumofNonTCPIPHCContexts_A36192.ShowHexValue = false;
			this.dataCfgDataWideMaxSetupTimeAllowedforCCA_A36193 = new global::AcpBusinessLayer.AcpSimpleRangeField(1200, this, global::AllFeatures.CodeplugGuid.b("臄ꛆ뷈꫊軌꧎뛐韒듔ꏖ룘賚드믞蓠껢蓤鿦뫨軪駬髮臰ꟲ鳴髶鳸뫺釼鏾渀琂怄挆漈搊缌䰎刐划䨔嘖⨘ⴚⰜ☞ሠ", a_), global::CommonResources.AcgResources.ID_MAXSETUPTIMEFORCONTROLLEDCHANNELACCESSMSEC, 0, 65535, null, null, 0, 1);
			this.dataCfgDataWideMaxSetupTimeAllowedforCCA_A36193.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.dataCfgDataWideMaxSetupTimeAllowedforCCA_A36193.DataTransferOrder = 22;
			this.dataCfgDataWideMaxSetupTimeAllowedforCCA_A36193.ShowHexValue = false;
			this.dataConfigDataWideMaxNumofTCPIPHCContexts_A36194 = new global::AcpBusinessLayer.AcpSimpleRangeField(0, this, global::AllFeatures.CodeplugGuid.b("臄ꛆ뷈꫊軌ꃎ뿐뗒볔냖鷘뫚꧜뻞뛠諢臤苦ꓨ諪闬ꇮ蓰黲髴釶그룺근뛾儀䬂䘄䐆昈攊礌樎椐朒昔䠖堘⠚⬜⸞ᠠᜢ", a_), global::CommonResources.AcgResources.ID_MAXPOFTCPIPHEADERCOMPRESSIONCONTEXTS, 0, 255, null, null, 0, 1);
			this.dataConfigDataWideMaxNumofTCPIPHCContexts_A36194.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.dataConfigDataWideMaxNumofTCPIPHCContexts_A36194.DataTransferOrder = 18;
			this.dataConfigDataWideMaxNumofTCPIPHCContexts_A36194.ShowHexValue = false;
			this.dataCfgDataWideTimeSourceVar_A36196 = new global::AcpBusinessLayer.AcpCustomRangeField(134, this, global::AllFeatures.CodeplugGuid.b("臄ꛆ뷈꫊軌꧎뛐韒듔ꏖ룘賚드믞蓠럢賤諦賨룪苬髮菰郲郴ꇶ飸觺ꋼ뻾㈀㔂㐄㸆㼈", a_), global::CommonResources.AcgResources.ID_TIMESOURCEVARIATIONMICROSLOTS, 0, 268, 2, null, null);
			this.dataCfgDataWideTimeSourceVar_A36196.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.dataCfgDataWideTimeSourceVar_A36196.DataTransferOrder = 23;
			this.dataCfgDataWideTimeSourceVar_A36196.ShowHexValue = false;
			this.dataConfigDataWideMaxTimeBetweenFullHeaders_A36200 = new global::AcpBusinessLayer.AcpCustomRangeField(600, this, global::AllFeatures.CodeplugGuid.b("臄ꛆ뷈꫊軌ꃎ뿐뗒볔냖鷘뫚꧜뻞뛠諢臤苦ꓨ諪闬믮飰黲郴뗶鳸迺諼髾搀洂䌄爆攈朊䔌樎瀐眒瀔攖樘䐚尜Ⱎᜠᄢᔤᜦ", a_), global::CommonResources.AcgResources.ID_MAXTIMEBETWEENFULLHEADERSSEC, 0, 1275, 5, null, null);
			this.dataConfigDataWideMaxTimeBetweenFullHeaders_A36200.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.dataConfigDataWideMaxTimeBetweenFullHeaders_A36200.DataTransferOrder = 21;
			this.dataConfigDataWideMaxTimeBetweenFullHeaders_A36200.ShowHexValue = false;
			this.dataConfigDataWideMaxNumOfCompreHeadersBetweenFullHeaders_A36205 = new global::AcpBusinessLayer.AcpCustomRangeField(16, this, global::AllFeatures.CodeplugGuid.b("臄ꛆ뷈꫊軌ꃎ뿐뗒볔냖鷘뫚꧜뻞뛠諢臤苦ꓨ諪闬ꇮ蓰黲뫴釶뫸铺郼迾猀昂䴄戆栈漊栌紎成儒瀔挖渘縚砜焞朠嘢䤤䬦愨个䰬䬮吰䄲䘴栶砸࠺଼ാ煀療", a_), global::CommonResources.AcgResources.ID_MAXPOFCOMPRESSEDHEADERSBETWEENFULLHEADERS, 0, 4080, 16, null, null);
			this.dataConfigDataWideMaxNumOfCompreHeadersBetweenFullHeaders_A36205.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.dataConfigDataWideMaxNumOfCompreHeadersBetweenFullHeaders_A36205.DataTransferOrder = 19;
			this.dataConfigDataWideMaxNumOfCompreHeadersBetweenFullHeaders_A36205.ShowHexValue = false;
			this.dataConfigDataWideMaxHeaderSizeAllowedForCompression_A36206 = new global::AcpBusinessLayer.AcpSimpleRangeField(60, this, global::AllFeatures.CodeplugGuid.b("臄ꛆ뷈꫊軌ꃎ뿐뗒볔냖鷘뫚꧜뻞뛠諢臤苦ꓨ諪闬꟮铰鋲釴鋶诸꣺铼藾搀䈂椄欆昈簊栌欎圐簒朔吖瘘瘚洜洞䐠倢嘤並䘨䔪爬渮ȰԲܴܶ༸", a_), global::CommonResources.AcgResources.ID_MAXHEADERSIZEALLOWEDFORCOMPRESSIONBYTES, 60, 255, null, null, 0, 1);
			this.dataConfigDataWideMaxHeaderSizeAllowedForCompression_A36206.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.dataConfigDataWideMaxHeaderSizeAllowedForCompression_A36206.DataTransferOrder = 20;
			this.dataConfigDataWideMaxHeaderSizeAllowedForCompression_A36206.ShowHexValue = false;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("臄ꛆ뷈꫊鿎ꏐ볒ꇔ룖뫘듚뇜￞ꋠ賢诤臦胨質飬鷮郰蟲鳴飶韸", a_);
			base.Id = 10503;
			base.UIName = global::CommonResources.AcgResources.ID_DATAPROTOCOLCONFIGURATION;
			base.DataTransferOrder = 7;
		}

		// Token: 0x0600A24F RID: 41551 RVA: 0x00977C94 File Offset: 0x00975E94
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 7;
			short num = (short)1842085904;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_5FF;
				case 1:
					this.dataCfgDataWideTimeSourceVar_A36196 = new global::AcpBusinessLayer.AcpCustomRangeField(134, this, global::AllFeatures.CodeplugGuid.b("資ꯉ룋꿍鏏듑돓鋕맗껙뷛觝觟蛡臣닥臧蟩觫뷭鿯蟱蛳闵鷷곹鷻賽忿䌁㜃々㤇㌉㨋", a_), global::CommonResources.AcgResources.ID_TIMESOURCEVARIATIONMICROSLOTS, null, null);
					this.dataCfgDataWideTimeSourceVar_A36196.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.dataCfgDataWideTimeSourceVar_A36196.DataTransferOrder = 23;
					this.dataCfgDataWideTimeSourceVar_A36196.ShowHexValue = false;
					num = (short)309985303;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("資ꯉ룋꿍鏏뷑뫓냕뇗뷙飛뿝铟菡돣迥賧迩ꇫ迭裯뫱釳韵鳷鿹軻귽槿码愃䜅搇昉挋礍甏瘑刓礕樗夙猛猝借倡䄣唥嬧䌩䌫䀭漯猱ܳ5਷ਹ਻", a_)))
					{
						num = (short)918355977;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_64C;
				case 3:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("資ꯉ룋꿍鏏뷑뫓냕뇗뷙飛뿝铟菡돣迥賧迩ꇫ迭裯볱至鯵韷鳹ꣻ뷽僿䬁吃丅䬇䤉挋怍搏眑氓戕欗䔙崛ⴝᘟጡᴣሥ", a_)))
					{
						num = (short)1125253130;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5FF;
				case 4:
					this.dataCfgDataWideMaxSetupTimeAllowedforCCA_A36193 = new global::AcpBusinessLayer.AcpSimpleRangeField(1200, this, global::AllFeatures.CodeplugGuid.b("資ꯉ룋꿍鏏듑돓鋕맗껙뷛觝觟蛡臣ꯥ觧鋩뿫语蓯蟱蓳ꋵ釷韹駻뿽泿渁欃焅洇渉樋愍戏儑圓圕䜗嬙⼛⠝ᄟᬡᜣ", a_), global::CommonResources.AcgResources.ID_MAXSETUPTIMEFORCONTROLLEDCHANNELACCESSMSEC, null, null, 0, 1);
					this.dataCfgDataWideMaxSetupTimeAllowedforCCA_A36193.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.dataCfgDataWideMaxSetupTimeAllowedforCCA_A36193.DataTransferOrder = 22;
					this.dataCfgDataWideMaxSetupTimeAllowedforCCA_A36193.ShowHexValue = false;
					num = (short)1525874707;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					num = (short)1506410497;
					if (num != 0)
					{
					}
					num = (short)306184206;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("資ꯉ룋꿍鏏듑돓鋕맗껙뷛觝觟蛡臣닥臧蟩觫뷭鿯蟱蛳闵鷷곹鷻賽忿䌁㜃々㤇㌉㨋", a_)))
					{
						num = (short)159055873;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_315;
				case 7:
					this.dataConfigDataWideMaxNumOfCompreHeadersBetweenFullHeaders_A36205 = new global::AcpBusinessLayer.AcpCustomRangeField(16, this, global::AllFeatures.CodeplugGuid.b("資ꯉ룋꿍鏏뷑뫓냕뇗뷙飛뿝铟菡돣迥賧迩ꇫ迭裯볱至鯵럷鳹뿻釽淿爁瘃挅䀇漉洋樍甏怑朓吕紗渙欛笝䔟䰡戣匥䐧䘩搫䬭儯嘱儳䐵䬷改紻ഽ瘿灁瑃獅", a_), global::CommonResources.AcgResources.ID_MAXPOFCOMPRESSEDHEADERSBETWEENFULLHEADERS, null, null);
					this.dataConfigDataWideMaxNumOfCompreHeadersBetweenFullHeaders_A36205.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.dataConfigDataWideMaxNumOfCompreHeadersBetweenFullHeaders_A36205.DataTransferOrder = 19;
					this.dataConfigDataWideMaxNumOfCompreHeadersBetweenFullHeaders_A36205.ShowHexValue = false;
					num = (short)907411467;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("資ꯉ룋꿍鏏뷑뫓냕뇗뷙飛뿝铟菡돣迥賧迩ꇫ迭裯볱至鯵럷鳹뿻釽淿爁瘃挅䀇漉洋樍甏怑朓吕紗渙欛笝䔟䰡戣匥䐧䘩搫䬭儯嘱儳䐵䬷改紻ഽ瘿灁瑃獅", a_)))
					{
						num = (short)1380253703;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_47C;
				case 9:
					this.dataConfigDataWideMaxHeaderSizeAllowedForCompression_A36206 = new global::AcpBusinessLayer.AcpSimpleRangeField(60, this, global::AllFeatures.CodeplugGuid.b("資ꯉ룋꿍鏏뷑뫓냕뇗뷙飛뿝铟菡돣迥賧迩ꇫ迭裯뫱釳韵鳷鿹軻귽槿码愃䜅搇昉挋礍甏瘑刓礕樗夙猛猝借倡䄣唥嬧䌩䌫䀭漯猱ܳ5਷ਹ਻", a_), global::CommonResources.AcgResources.ID_MAXHEADERSIZEALLOWEDFORCOMPRESSIONBYTES, null, null, 0, 1);
					this.dataConfigDataWideMaxHeaderSizeAllowedForCompression_A36206.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.dataConfigDataWideMaxHeaderSizeAllowedForCompression_A36206.DataTransferOrder = 20;
					this.dataConfigDataWideMaxHeaderSizeAllowedForCompression_A36206.ShowHexValue = false;
					num = (short)1316487180;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					goto IL_5FA;
				case 11:
					goto IL_47C;
				case 12:
					goto IL_3C6;
				case 13:
					num = (short)1592852502;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
				{
					num = (short)680681882;
					short num3 = num;
					num = (short)311320986;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_5FA;
					default:
						num = (short)1649868800;
						if (num != 0)
						{
						}
						if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("資ꯉ룋꿍鏏뷑뫓냕뇗뷙飛뿝铟菡돣迥賧迩ꇫ迭裯볱至鯵韷鳹닻釽滿嘁䜃嘅䄇娉䐋䴍匏紑稓戕紗戙栛洝缟挡ᜣဥᤧጩḫ", a_)))
						{
							num = (short)223150100;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_430;
					}
					break;
				}
				case 15:
					goto IL_4C9;
				case 16:
					switch (0)
					{
					case 0:
						goto IL_93;
					}
					continue;
				case 17:
					goto IL_430;
				case 18:
					this.dataConfigDataWideMaxTimeBetweenFullHeaders_A36200 = new global::AcpBusinessLayer.AcpCustomRangeField(600, this, global::AllFeatures.CodeplugGuid.b("資ꯉ룋꿍鏏뷑뫓냕뇗뷙飛뿝铟菡돣迥賧迩ꇫ迭裯꛱鷳鯵鷷룹駻諽矿朁愃栅万缉怋戍堏眑甓爕紗栙漛䄝感ᄡሣᐥᠧᨩ", a_), global::CommonResources.AcgResources.ID_MAXTIMEBETWEENFULLHEADERSSEC, null, null);
					this.dataConfigDataWideMaxTimeBetweenFullHeaders_A36200.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.dataConfigDataWideMaxTimeBetweenFullHeaders_A36200.DataTransferOrder = 21;
					this.dataConfigDataWideMaxTimeBetweenFullHeaders_A36200.ShowHexValue = false;
					num = (short)1027473423;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 19:
					goto IL_5B5;
				case 20:
					this.dataConfigDataWideMaxNumofNonTCPIPHCContexts_A36192 = new global::AcpBusinessLayer.AcpSimpleRangeField(8, this, global::AllFeatures.CodeplugGuid.b("資ꯉ룋꿍鏏뷑뫓냕뇗뷙飛뿝铟菡돣迥賧迩ꇫ迭裯볱至鯵韷鳹닻釽滿嘁䜃嘅䄇娉䐋䴍匏紑稓戕紗戙栛洝缟挡ᜣဥᤧጩḫ", a_), global::CommonResources.AcgResources.ID_MAXPOFNONTCPIPHEADERCOMPRESSIONCONTEXTS, null, null, 0, 1);
					this.dataConfigDataWideMaxNumofNonTCPIPHCContexts_A36192.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.dataConfigDataWideMaxNumofNonTCPIPHCContexts_A36192.DataTransferOrder = 17;
					this.dataConfigDataWideMaxNumofNonTCPIPHCContexts_A36192.ShowHexValue = false;
					num = (short)1205665809;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 21:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("資ꯉ룋꿍鏏듑돓鋕맗껙뷛觝觟蛡臣ꯥ觧鋩뿫语蓯蟱蓳ꋵ釷韹駻뿽泿渁欃焅洇渉樋愍戏儑圓圕䜗嬙⼛⠝ᄟᬡᜣ", a_)))
					{
						num = (short)2014904324;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5B5;
				case 22:
					if (producerFields != null)
					{
						num = (short)825163781;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_64C;
				case 23:
					goto IL_315;
				case 24:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("資ꯉ룋꿍鏏뷑뫓냕뇗뷙飛뿝铟菡돣迥賧迩ꇫ迭裯꛱鷳鯵鷷룹駻諽矿朁愃栅万缉怋戍堏眑甓爕紗栙漛䄝感ᄡሣᐥᠧᨩ", a_)))
					{
						num = (short)1281884178;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4C9;
				}
				IL_93:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)969080845;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_315:
				num = (short)1869152280;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_430:
				num = (short)1540554773;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_47C:
				num = (short)1860501506;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_4C9:
				num = (short)973668360;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_5B5:
				num = (short)9371651;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_5FA:
				this.dataConfigDataWideMaxNumofTCPIPHCContexts_A36194 = new global::AcpBusinessLayer.AcpSimpleRangeField(0, this, global::AllFeatures.CodeplugGuid.b("資ꯉ룋꿍鏏뷑뫓냕뇗뷙飛뿝铟菡돣迥賧迩ꇫ迭裯볱至鯵韷鳹ꣻ뷽僿䬁吃丅䬇䤉挋怍搏眑氓戕欗䔙崛ⴝᘟጡᴣሥ", a_), global::CommonResources.AcgResources.ID_MAXPOFTCPIPHEADERCOMPRESSIONCONTEXTS, null, null, 0, 1);
				this.dataConfigDataWideMaxNumofTCPIPHCContexts_A36194.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
				this.dataConfigDataWideMaxNumofTCPIPHCContexts_A36194.DataTransferOrder = 18;
				this.dataConfigDataWideMaxNumofTCPIPHCContexts_A36194.ShowHexValue = false;
				num = (short)1617428480;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_5FF:
				num = (short)1830748166;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_3C6:
			IL_64C:
			num = (short)331612160;
			short num4 = num;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("資ꯉ룋꿍苑ꛓ맕곗뗙뿛뇝賟싡꟣觥蛧賩藫觭藯胱闳苵釷闹鋻", a_);
			base.Id = 10503;
			base.UIName = global::CommonResources.AcgResources.ID_DATAPROTOCOLCONFIGURATION;
			base.DataTransferOrder = 7;
		}

		// Token: 0x0600A250 RID: 41552 RVA: 0x00978348 File Offset: 0x00976548
		public override void PopulateReferences()
		{
			short num = (short)1978100231;
			short num2 = num;
			num = (short)700148231;
			switch (num2 == num)
			{
			}
			num = (short)1867579393;
			if (num != 0)
			{
			}
			num = (short)489226240;
			short num3 = num;
			num = (short)1631846400;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600A251 RID: 41553 RVA: 0x009783F0 File Offset: 0x009765F0
		public override void DropReferences()
		{
			short num = (short)922322264;
			short num2 = num;
			num = (short)1624278360;
			switch (num2 == num)
			{
			}
			num = (short)691339265;
			if (num != 0)
			{
			}
			num = (short)1148715008;
			short num3 = num;
			num = (short)1108934656;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600A252 RID: 41554 RVA: 0x0097849C File Offset: 0x0097669C
		public override void SetConstraints()
		{
			short num = (short)869512223;
			short num2 = num;
			num = (short)1255912479;
			switch (num2 == num)
			{
			}
			num = (short)1277493248;
			if (num != 0)
			{
			}
			num = (short)401408000;
			short num3 = num;
			num = (short)2088173569;
			if (num != 0)
			{
			}
			this.dataConfigDataWideMaxNumOfCompreHeadersBetweenFullHeaders_A36205.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.ConZeroIsInvalidForNonEnhData);
		}

		// Token: 0x0600A253 RID: 41555 RVA: 0x0097855C File Offset: 0x0097675C
		public override void SetupDependencies()
		{
			short num = (short)1037128024;
			short num2 = num;
			num = (short)104616280;
			switch (num2 == num)
			{
			}
			num = (short)1665662977;
			if (num != 0)
			{
			}
			num = (short)1476919296;
			short num3 = num;
			num = (short)1394081792;
			if (num != 0)
			{
			}
			this.RefRadioInformation.Labtool.EnhancedDataOperation_42024.AddDependentObject(this.dataConfigDataWideMaxNumOfCompreHeadersBetweenFullHeaders_A36205);
		}

		// Token: 0x17005151 RID: 20817
		// (get) Token: 0x0600A254 RID: 41556 RVA: 0x00978620 File Offset: 0x00976820
		public bool HasDiffs
		{
			get
			{
				short num = (short)1503310735;
				short num2 = num;
				num = (short)1992209295;
				switch (num2 == num)
				{
				}
				num = (short)1809252353;
				if (num != 0)
				{
				}
				num = (short)1420689408;
				short num3 = num;
				num = (short)925958144;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17005152 RID: 20818
		// (get) Token: 0x0600A255 RID: 41557 RVA: 0x009786CC File Offset: 0x009768CC
		// (set) Token: 0x0600A256 RID: 41558 RVA: 0x00978784 File Offset: 0x00976984
		public int DataConfigDataWideMaxNumofNonTCPIPHCContexts_A36192Value
		{
			get
			{
				short num = (short)671296284;
				short num2 = num;
				num = (short)1089415964;
				switch (num2 == num)
				{
				}
				num = (short)249167873;
				if (num != 0)
				{
				}
				num = (short)1608056832;
				short num3 = num;
				num = (short)735772672;
				if (num != 0)
				{
				}
				return this.dataConfigDataWideMaxNumofNonTCPIPHCContexts_A36192.Value;
			}
			set
			{
				short num = (short)1660539622;
				short num2 = num;
				num = (short)577229542;
				switch (num2 == num)
				{
				}
				num = (short)1600454656;
				if (num != 0)
				{
				}
				num = (short)803930112;
				short num3 = num;
				num = (short)1299185665;
				if (num != 0)
				{
				}
				this.dataConfigDataWideMaxNumofNonTCPIPHCContexts_A36192.Value = value;
			}
		}

		// Token: 0x17005153 RID: 20819
		// (get) Token: 0x0600A257 RID: 41559 RVA: 0x00978838 File Offset: 0x00976A38
		public global::AcpBusinessLayer.AcpSimpleRangeField DataConfigDataWideMaxNumofNonTCPIPHCContexts_A36192
		{
			get
			{
				short num = (short)1311334237;
				short num2 = num;
				num = (short)1916886877;
				switch (num2 == num)
				{
				}
				num = (short)582811649;
				if (num != 0)
				{
				}
				num = (short)1436811264;
				short num3 = num;
				num = (short)1530658816;
				if (num != 0)
				{
				}
				return this.dataConfigDataWideMaxNumofNonTCPIPHCContexts_A36192;
			}
		}

		// Token: 0x17005154 RID: 20820
		// (get) Token: 0x0600A258 RID: 41560 RVA: 0x009788E8 File Offset: 0x00976AE8
		// (set) Token: 0x0600A259 RID: 41561 RVA: 0x0097899C File Offset: 0x00976B9C
		public string DataConfigDataWideMaxNumofNonTCPIPHCContexts_A36192_UIValue
		{
			get
			{
				short num = (short)1068090741;
				short num2 = num;
				num = (short)285525365;
				switch (num2 == num)
				{
				}
				num = (short)1875181569;
				if (num != 0)
				{
				}
				num = (short)302120960;
				short num3 = num;
				num = (short)852164608;
				if (num != 0)
				{
				}
				return this.dataConfigDataWideMaxNumofNonTCPIPHCContexts_A36192.UIValue;
			}
			set
			{
				short num = (short)837847859;
				short num2 = num;
				num = (short)1955302195;
				switch (num2 == num)
				{
				}
				num = (short)1873805313;
				if (num != 0)
				{
				}
				num = (short)2055471104;
				short num3 = num;
				num = (short)1110704128;
				if (num != 0)
				{
				}
				this.dataConfigDataWideMaxNumofNonTCPIPHCContexts_A36192.UIValue = value;
			}
		}

		// Token: 0x17005155 RID: 20821
		// (get) Token: 0x0600A25A RID: 41562 RVA: 0x00978A50 File Offset: 0x00976C50
		// (set) Token: 0x0600A25B RID: 41563 RVA: 0x00978B04 File Offset: 0x00976D04
		internal int DataConfigDataWideMaxNumofNonTCPIPHCContexts_A36192Min
		{
			get
			{
				short num = (short)1230226060;
				short num2 = num;
				num = (short)1575666316;
				switch (num2 == num)
				{
				}
				num = (short)992083969;
				if (num != 0)
				{
				}
				num = (short)1176174592;
				short num3 = num;
				num = (short)354811904;
				if (num != 0)
				{
				}
				return this.dataConfigDataWideMaxNumofNonTCPIPHCContexts_A36192.Min;
			}
			set
			{
				short num = (short)514996005;
				short num2 = num;
				num = (short)2040477477;
				switch (num2 == num)
				{
				}
				num = (short)17301505;
				if (num != 0)
				{
				}
				num = (short)1252524032;
				short num3 = num;
				num = (short)809107456;
				if (num != 0)
				{
				}
				this.dataConfigDataWideMaxNumofNonTCPIPHCContexts_A36192.Min = value;
			}
		}

		// Token: 0x17005156 RID: 20822
		// (get) Token: 0x0600A25C RID: 41564 RVA: 0x00978BBC File Offset: 0x00976DBC
		// (set) Token: 0x0600A25D RID: 41565 RVA: 0x00978C70 File Offset: 0x00976E70
		internal int DataConfigDataWideMaxNumofNonTCPIPHCContexts_A36192Max
		{
			get
			{
				short num = (short)301040026;
				short num2 = num;
				num = (short)240943514;
				switch (num2 == num)
				{
				}
				num = (short)1758593025;
				if (num != 0)
				{
				}
				num = (short)590872576;
				short num3 = num;
				num = (short)1964572672;
				if (num != 0)
				{
				}
				return this.dataConfigDataWideMaxNumofNonTCPIPHCContexts_A36192.Max;
			}
			set
			{
				short num = (short)1820611118;
				short num2 = num;
				num = (short)1177244206;
				switch (num2 == num)
				{
				}
				num = (short)319029249;
				if (num != 0)
				{
				}
				num = (short)258277376;
				short num3 = num;
				num = (short)1731461120;
				if (num != 0)
				{
				}
				this.dataConfigDataWideMaxNumofNonTCPIPHCContexts_A36192.Max = value;
			}
		}

		// Token: 0x17005157 RID: 20823
		// (get) Token: 0x0600A25E RID: 41566 RVA: 0x00978D28 File Offset: 0x00976F28
		// (set) Token: 0x0600A25F RID: 41567 RVA: 0x00978DDC File Offset: 0x00976FDC
		internal int DataConfigDataWideMaxNumofNonTCPIPHCContexts_A36192Step
		{
			get
			{
				short num = (short)797209052;
				short num2 = num;
				num = (short)241791452;
				switch (num2 == num)
				{
				}
				num = (short)551288832;
				if (num != 0)
				{
				}
				num = (short)5570560;
				short num3 = num;
				num = (short)1216282625;
				if (num != 0)
				{
				}
				return this.dataConfigDataWideMaxNumofNonTCPIPHCContexts_A36192.StepSize;
			}
			set
			{
				short num = (short)65536001;
				if (num != 0)
				{
				}
				num = (short)1505089200;
				short num2 = num;
				num = (short)719247024;
				switch (num2 == num)
				{
				}
				num = (short)795934720;
				short num3 = num;
				num = (short)911933440;
				if (num != 0)
				{
				}
				this.dataConfigDataWideMaxNumofNonTCPIPHCContexts_A36192.StepSize = value;
			}
		}

		// Token: 0x17005158 RID: 20824
		// (get) Token: 0x0600A260 RID: 41568 RVA: 0x00978E94 File Offset: 0x00977094
		// (set) Token: 0x0600A261 RID: 41569 RVA: 0x00978F48 File Offset: 0x00977148
		public bool DataConfigDataWideMaxNumofNonTCPIPHCContexts_A36192_Applicable
		{
			get
			{
				short num = (short)1334644878;
				short num2 = num;
				num = (short)2067140750;
				switch (num2 == num)
				{
				}
				num = (short)654770176;
				if (num != 0)
				{
				}
				num = (short)1056899072;
				short num3 = num;
				num = (short)376045569;
				if (num != 0)
				{
				}
				return this.dataConfigDataWideMaxNumofNonTCPIPHCContexts_A36192.Applicable;
			}
			set
			{
				short num = (short)1551217410;
				short num2 = num;
				num = (short)267432706;
				switch (num2 == num)
				{
				}
				num = (short)1309736960;
				if (num != 0)
				{
				}
				num = (short)1348730880;
				short num3 = num;
				num = (short)769261569;
				if (num != 0)
				{
				}
				this.dataConfigDataWideMaxNumofNonTCPIPHCContexts_A36192.Applicable = value;
			}
		}

		// Token: 0x17005159 RID: 20825
		// (get) Token: 0x0600A262 RID: 41570 RVA: 0x00978FFC File Offset: 0x009771FC
		// (set) Token: 0x0600A263 RID: 41571 RVA: 0x009790B4 File Offset: 0x009772B4
		public bool DataConfigDataWideMaxNumofNonTCPIPHCContexts_A36192_Valid
		{
			get
			{
				short num = (short)1550019138;
				short num2 = num;
				num = (short)1795648066;
				switch (num2 == num)
				{
				}
				num = (short)596639745;
				if (num != 0)
				{
				}
				num = (short)891027456;
				short num3 = num;
				num = (short)1850802176;
				if (num != 0)
				{
				}
				return this.dataConfigDataWideMaxNumofNonTCPIPHCContexts_A36192.Valid;
			}
			set
			{
				short num = (short)936967316;
				short num2 = num;
				num = (short)1017052308;
				switch (num2 == num)
				{
				}
				num = (short)2095120384;
				if (num != 0)
				{
				}
				num = (short)2125004800;
				short num3 = num;
				num = (short)1239285761;
				if (num != 0)
				{
				}
				this.dataConfigDataWideMaxNumofNonTCPIPHCContexts_A36192.Valid = value;
			}
		}

		// Token: 0x1700515A RID: 20826
		// (get) Token: 0x0600A264 RID: 41572 RVA: 0x00979168 File Offset: 0x00977368
		// (set) Token: 0x0600A265 RID: 41573 RVA: 0x0097921C File Offset: 0x0097741C
		public bool DataConfigDataWideMaxNumofNonTCPIPHCContexts_A36192_Visible
		{
			get
			{
				short num = (short)671122256;
				short num2 = num;
				num = (short)571769680;
				switch (num2 == num)
				{
				}
				num = (short)1513422848;
				if (num != 0)
				{
				}
				num = (short)96665600;
				short num3 = num;
				num = (short)1313865729;
				if (num != 0)
				{
				}
				return this.dataConfigDataWideMaxNumofNonTCPIPHCContexts_A36192.Visible;
			}
			set
			{
				short num = (short)976861770;
				short num2 = num;
				num = (short)1227012682;
				switch (num2 == num)
				{
				}
				num = (short)2045968384;
				if (num != 0)
				{
				}
				num = (short)270794752;
				short num3 = num;
				num = (short)1992228865;
				if (num != 0)
				{
				}
				this.dataConfigDataWideMaxNumofNonTCPIPHCContexts_A36192.Visible = value;
			}
		}

		// Token: 0x1700515B RID: 20827
		// (get) Token: 0x0600A266 RID: 41574 RVA: 0x009792D0 File Offset: 0x009774D0
		// (set) Token: 0x0600A267 RID: 41575 RVA: 0x00979384 File Offset: 0x00977584
		public bool DataConfigDataWideMaxNumofNonTCPIPHCContexts_A36192_Editable
		{
			get
			{
				short num = (short)88342529;
				if (num != 0)
				{
				}
				num = (short)748048087;
				short num2 = num;
				num = (short)707415767;
				switch (num2 == num)
				{
				}
				num = (short)93257728;
				short num3 = num;
				num = (short)1479671808;
				if (num != 0)
				{
				}
				return this.dataConfigDataWideMaxNumofNonTCPIPHCContexts_A36192.Editable;
			}
			set
			{
				short num = (short)638779499;
				short num2 = num;
				num = (short)825229419;
				switch (num2 == num)
				{
				}
				num = (short)1298595841;
				if (num != 0)
				{
				}
				num = (short)1993998336;
				short num3 = num;
				num = (short)1069219840;
				if (num != 0)
				{
				}
				this.dataConfigDataWideMaxNumofNonTCPIPHCContexts_A36192.Editable = value;
			}
		}

		// Token: 0x1700515C RID: 20828
		// (get) Token: 0x0600A268 RID: 41576 RVA: 0x0097943C File Offset: 0x0097763C
		internal string DataConfigDataWideMaxNumofNonTCPIPHCContexts_A36192_UILabel
		{
			get
			{
				short num = (short)829357147;
				short num2 = num;
				num = (short)908786779;
				switch (num2 == num)
				{
				}
				num = (short)363855873;
				if (num != 0)
				{
				}
				num = (short)746913792;
				short num3 = num;
				num = (short)2052325376;
				if (num != 0)
				{
				}
				return this.dataConfigDataWideMaxNumofNonTCPIPHCContexts_A36192.UIName;
			}
		}

		// Token: 0x1700515D RID: 20829
		// (get) Token: 0x0600A269 RID: 41577 RVA: 0x009794F4 File Offset: 0x009776F4
		// (set) Token: 0x0600A26A RID: 41578 RVA: 0x009795A8 File Offset: 0x009777A8
		internal bool DataConfigDataWideMaxNumofNonTCPIPHCContexts_A36192_HiddenStatic
		{
			get
			{
				short num = (short)1294389030;
				short num2 = num;
				num = (short)86495014;
				switch (num2 == num)
				{
				}
				num = (short)126222336;
				short num3 = num;
				num = (short)1649213440;
				if (num != 0)
				{
				}
				num = (short)1917976577;
				if (num != 0)
				{
				}
				return this.dataConfigDataWideMaxNumofNonTCPIPHCContexts_A36192.HiddenStatic;
			}
			set
			{
				short num = (short)987519877;
				short num2 = num;
				num = (short)867457925;
				switch (num2 == num)
				{
				}
				num = (short)1607073792;
				short num3 = num;
				num = (short)770637825;
				if (num != 0)
				{
				}
				num = (short)1978990592;
				if (num != 0)
				{
				}
				this.dataConfigDataWideMaxNumofNonTCPIPHCContexts_A36192.HiddenStatic = value;
			}
		}

		// Token: 0x1700515E RID: 20830
		// (get) Token: 0x0600A26B RID: 41579 RVA: 0x00979660 File Offset: 0x00977860
		// (set) Token: 0x0600A26C RID: 41580 RVA: 0x00979714 File Offset: 0x00977914
		internal bool DataConfigDataWideMaxNumofNonTCPIPHCContexts_A36192_HiddenDynamic
		{
			get
			{
				short num = (short)1302835641;
				short num2 = num;
				num = (short)726315449;
				switch (num2 == num)
				{
				}
				num = (short)65798144;
				short num3 = num;
				num = (short)1962606592;
				if (num != 0)
				{
				}
				num = (short)1637220353;
				if (num != 0)
				{
				}
				return this.dataConfigDataWideMaxNumofNonTCPIPHCContexts_A36192.HiddenDynamic;
			}
			set
			{
				short num = (short)475544191;
				short num2 = num;
				num = (short)1998273151;
				switch (num2 == num)
				{
				}
				num = (short)338231296;
				short num3 = num;
				num = (short)850132993;
				if (num != 0)
				{
				}
				num = (short)1261568000;
				if (num != 0)
				{
				}
				this.dataConfigDataWideMaxNumofNonTCPIPHCContexts_A36192.HiddenDynamic = value;
			}
		}

		// Token: 0x1700515F RID: 20831
		// (get) Token: 0x0600A26D RID: 41581 RVA: 0x009797CC File Offset: 0x009779CC
		public bool DataConfigDataWideMaxNumofNonTCPIPHCContexts_A36192_HasDiffs
		{
			get
			{
				short num = (short)905129583;
				short num2 = num;
				num = (short)1341664879;
				switch (num2 == num)
				{
				}
				num = (short)816578560;
				short num3 = num;
				num = (short)398262273;
				if (num != 0)
				{
				}
				num = (short)1207369728;
				if (num != 0)
				{
				}
				return this.dataConfigDataWideMaxNumofNonTCPIPHCContexts_A36192._HasDiffs;
			}
		}

		// Token: 0x17005160 RID: 20832
		// (get) Token: 0x0600A26E RID: 41582 RVA: 0x00979884 File Offset: 0x00977A84
		// (set) Token: 0x0600A26F RID: 41583 RVA: 0x00979938 File Offset: 0x00977B38
		public int DataCfgDataWideMaxSetupTimeAllowedforCCA_A36193Value
		{
			get
			{
				short num = (short)1968048665;
				short num2 = num;
				num = (short)1423968793;
				switch (num2 == num)
				{
				}
				num = (short)1722482688;
				short num3 = num;
				num = (short)103284736;
				if (num != 0)
				{
				}
				num = (short)2073559041;
				if (num != 0)
				{
				}
				return this.dataCfgDataWideMaxSetupTimeAllowedforCCA_A36193.Value;
			}
			set
			{
				short num = (short)1969798373;
				short num2 = num;
				num = (short)333888741;
				switch (num2 == num)
				{
				}
				num = (short)1728970752;
				short num3 = num;
				num = (short)2029453312;
				if (num != 0)
				{
				}
				num = (short)752484353;
				if (num != 0)
				{
				}
				this.dataCfgDataWideMaxSetupTimeAllowedforCCA_A36193.Value = value;
			}
		}

		// Token: 0x17005161 RID: 20833
		// (get) Token: 0x0600A270 RID: 41584 RVA: 0x009799F0 File Offset: 0x00977BF0
		public global::AcpBusinessLayer.AcpSimpleRangeField DataCfgDataWideMaxSetupTimeAllowedforCCA_A36193
		{
			get
			{
				short num = (short)1037009883;
				short num2 = num;
				num = (short)2060092379;
				switch (num2 == num)
				{
				}
				num = (short)13369344;
				short num3 = num;
				num = (short)1749286912;
				if (num != 0)
				{
				}
				num = (short)1398603777;
				if (num != 0)
				{
				}
				return this.dataCfgDataWideMaxSetupTimeAllowedforCCA_A36193;
			}
		}

		// Token: 0x17005162 RID: 20834
		// (get) Token: 0x0600A271 RID: 41585 RVA: 0x00979AA0 File Offset: 0x00977CA0
		// (set) Token: 0x0600A272 RID: 41586 RVA: 0x00979B54 File Offset: 0x00977D54
		public string DataCfgDataWideMaxSetupTimeAllowedforCCA_A36193_UIValue
		{
			get
			{
				short num = (short)1406926849;
				if (num != 0)
				{
				}
				num = (short)76632006;
				short num2 = num;
				num = (short)1204768710;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1936982016;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)814415872;
				if (num != 0)
				{
				}
				return this.dataCfgDataWideMaxSetupTimeAllowedforCCA_A36193.UIValue;
			}
			set
			{
				short num = (short)31916033;
				if (num != 0)
				{
				}
				num = (short)1973354314;
				short num2 = num;
				num = (short)713686858;
				switch (num2 == num)
				{
				default:
				{
					num = (short)652869632;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)610861056;
				if (num != 0)
				{
				}
				this.dataCfgDataWideMaxSetupTimeAllowedforCCA_A36193.UIValue = value;
			}
		}

		// Token: 0x17005163 RID: 20835
		// (get) Token: 0x0600A273 RID: 41587 RVA: 0x00979C08 File Offset: 0x00977E08
		// (set) Token: 0x0600A274 RID: 41588 RVA: 0x00979CBC File Offset: 0x00977EBC
		internal int DataCfgDataWideMaxSetupTimeAllowedforCCA_A36193Min
		{
			get
			{
				short num = (short)2145263799;
				short num2 = num;
				num = (short)2043945143;
				switch (num2 == num)
				{
				}
				num = (short)175702016;
				short num3 = num;
				num = (short)781713409;
				if (num != 0)
				{
				}
				num = (short)336723968;
				if (num != 0)
				{
				}
				return this.dataCfgDataWideMaxSetupTimeAllowedforCCA_A36193.Min;
			}
			set
			{
				short num = (short)1109039875;
				short num2 = num;
				num = (short)1862834947;
				switch (num2 == num)
				{
				}
				num = (short)1396310016;
				short num3 = num;
				num = (short)488243200;
				if (num != 0)
				{
				}
				num = (short)1629159425;
				if (num != 0)
				{
				}
				this.dataCfgDataWideMaxSetupTimeAllowedforCCA_A36193.Min = value;
			}
		}

		// Token: 0x17005164 RID: 20836
		// (get) Token: 0x0600A275 RID: 41589 RVA: 0x00979D70 File Offset: 0x00977F70
		// (set) Token: 0x0600A276 RID: 41590 RVA: 0x00979E28 File Offset: 0x00978028
		internal int DataCfgDataWideMaxSetupTimeAllowedforCCA_A36193Max
		{
			get
			{
				short num = (short)1345670475;
				short num2 = num;
				num = (short)525356363;
				switch (num2 == num)
				{
				}
				num = (short)225443840;
				short num3 = num;
				num = (short)1101135873;
				if (num != 0)
				{
				}
				num = (short)654508032;
				if (num != 0)
				{
				}
				return this.dataCfgDataWideMaxSetupTimeAllowedforCCA_A36193.Max;
			}
			set
			{
				short num = (short)1037264382;
				short num2 = num;
				num = (short)656827902;
				switch (num2 == num)
				{
				}
				num = (short)1561198592;
				short num3 = num;
				num = (short)139919361;
				if (num != 0)
				{
				}
				num = (short)493813760;
				if (num != 0)
				{
				}
				this.dataCfgDataWideMaxSetupTimeAllowedforCCA_A36193.Max = value;
			}
		}

		// Token: 0x17005165 RID: 20837
		// (get) Token: 0x0600A277 RID: 41591 RVA: 0x00979EE0 File Offset: 0x009780E0
		// (set) Token: 0x0600A278 RID: 41592 RVA: 0x00979F94 File Offset: 0x00978194
		internal int DataCfgDataWideMaxSetupTimeAllowedforCCA_A36193Step
		{
			get
			{
				short num = (short)1074968074;
				short num2 = num;
				num = (short)1605809674;
				switch (num2 == num)
				{
				}
				num = (short)1400111104;
				short num3 = num;
				num = (short)879230977;
				if (num != 0)
				{
				}
				num = (short)658309120;
				if (num != 0)
				{
				}
				return this.dataCfgDataWideMaxSetupTimeAllowedforCCA_A36193.StepSize;
			}
			set
			{
				short num = (short)2105942226;
				short num2 = num;
				num = (short)1411195090;
				switch (num2 == num)
				{
				}
				num = (short)192937984;
				short num3 = num;
				num = (short)1481572352;
				if (num != 0)
				{
				}
				num = (short)1198915585;
				if (num != 0)
				{
				}
				this.dataCfgDataWideMaxSetupTimeAllowedforCCA_A36193.StepSize = value;
			}
		}

		// Token: 0x17005166 RID: 20838
		// (get) Token: 0x0600A279 RID: 41593 RVA: 0x0097A048 File Offset: 0x00978248
		// (set) Token: 0x0600A27A RID: 41594 RVA: 0x0097A0FC File Offset: 0x009782FC
		public bool DataCfgDataWideMaxSetupTimeAllowedforCCA_A36193_Applicable
		{
			get
			{
				short num = (short)2075648448;
				short num2 = num;
				num = (short)2138825152;
				switch (num2 == num)
				{
				}
				num = (short)1256259584;
				short num3 = num;
				num = (short)910295041;
				if (num != 0)
				{
				}
				num = (short)1890844672;
				if (num != 0)
				{
				}
				return this.dataCfgDataWideMaxSetupTimeAllowedforCCA_A36193.Applicable;
			}
			set
			{
				short num = (short)1238022067;
				short num2 = num;
				num = (short)2077210547;
				switch (num2 == num)
				{
				}
				num = (short)1378222080;
				short num3 = num;
				num = (short)1777074176;
				if (num != 0)
				{
				}
				num = (short)1585577985;
				if (num != 0)
				{
				}
				this.dataCfgDataWideMaxSetupTimeAllowedforCCA_A36193.Applicable = value;
			}
		}

		// Token: 0x17005167 RID: 20839
		// (get) Token: 0x0600A27B RID: 41595 RVA: 0x0097A1B0 File Offset: 0x009783B0
		// (set) Token: 0x0600A27C RID: 41596 RVA: 0x0097A264 File Offset: 0x00978464
		public bool DataCfgDataWideMaxSetupTimeAllowedforCCA_A36193_Valid
		{
			get
			{
				short num = (short)1093450732;
				short num2 = num;
				num = (short)300071916;
				switch (num2 == num)
				{
				}
				num = (short)93585408;
				short num3 = num;
				num = (short)547815424;
				if (num != 0)
				{
				}
				num = (short)893321217;
				if (num != 0)
				{
				}
				return this.dataCfgDataWideMaxSetupTimeAllowedforCCA_A36193.Valid;
			}
			set
			{
				short num = (short)568068967;
				short num2 = num;
				num = (short)1087114087;
				switch (num2 == num)
				{
				}
				num = (short)288096256;
				short num3 = num;
				num = (short)1126629377;
				if (num != 0)
				{
				}
				num = (short)1133903872;
				if (num != 0)
				{
				}
				this.dataCfgDataWideMaxSetupTimeAllowedforCCA_A36193.Valid = value;
			}
		}

		// Token: 0x17005168 RID: 20840
		// (get) Token: 0x0600A27D RID: 41597 RVA: 0x0097A318 File Offset: 0x00978518
		// (set) Token: 0x0600A27E RID: 41598 RVA: 0x0097A3CC File Offset: 0x009785CC
		public bool DataCfgDataWideMaxSetupTimeAllowedforCCA_A36193_Visible
		{
			get
			{
				short num = (short)2016927356;
				short num2 = num;
				num = (short)199351932;
				switch (num2 == num)
				{
				}
				num = (short)125370368;
				short num3 = num;
				num = (short)454492161;
				if (num != 0)
				{
				}
				num = (short)1308622848;
				if (num != 0)
				{
				}
				return this.dataCfgDataWideMaxSetupTimeAllowedforCCA_A36193.Visible;
			}
			set
			{
				short num = (short)602537985;
				if (num != 0)
				{
				}
				num = (short)607715959;
				short num2 = num;
				num = (short)672203383;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1712586752;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1598357504;
				if (num != 0)
				{
				}
				this.dataCfgDataWideMaxSetupTimeAllowedforCCA_A36193.Visible = value;
			}
		}

		// Token: 0x17005169 RID: 20841
		// (get) Token: 0x0600A27F RID: 41599 RVA: 0x0097A480 File Offset: 0x00978680
		// (set) Token: 0x0600A280 RID: 41600 RVA: 0x0097A538 File Offset: 0x00978738
		public bool DataCfgDataWideMaxSetupTimeAllowedforCCA_A36193_Editable
		{
			get
			{
				short num = (short)650512493;
				short num2 = num;
				num = (short)258541677;
				switch (num2 == num)
				{
				}
				num = (short)200474624;
				short num3 = num;
				num = (short)1359740929;
				if (num != 0)
				{
				}
				num = (short)150470656;
				if (num != 0)
				{
				}
				return this.dataCfgDataWideMaxSetupTimeAllowedforCCA_A36193.Editable;
			}
			set
			{
				short num = (short)1917890173;
				short num2 = num;
				num = (short)677686909;
				switch (num2 == num)
				{
				}
				num = (short)1295581184;
				short num3 = num;
				num = (short)44892161;
				if (num != 0)
				{
				}
				num = (short)1503330304;
				if (num != 0)
				{
				}
				this.dataCfgDataWideMaxSetupTimeAllowedforCCA_A36193.Editable = value;
			}
		}

		// Token: 0x1700516A RID: 20842
		// (get) Token: 0x0600A281 RID: 41601 RVA: 0x0097A5F0 File Offset: 0x009787F0
		internal string DataCfgDataWideMaxSetupTimeAllowedforCCA_A36193_UILabel
		{
			get
			{
				short num = (short)582342429;
				short num2 = num;
				num = (short)1027331869;
				switch (num2 == num)
				{
				}
				num = (short)18219008;
				short num3 = num;
				num = (short)190971905;
				if (num != 0)
				{
				}
				num = (short)1007747072;
				if (num != 0)
				{
				}
				return this.dataCfgDataWideMaxSetupTimeAllowedforCCA_A36193.UIName;
			}
		}

		// Token: 0x1700516B RID: 20843
		// (get) Token: 0x0600A282 RID: 41602 RVA: 0x0097A6A4 File Offset: 0x009788A4
		// (set) Token: 0x0600A283 RID: 41603 RVA: 0x0097A758 File Offset: 0x00978958
		internal bool DataCfgDataWideMaxSetupTimeAllowedforCCA_A36193_HiddenStatic
		{
			get
			{
				short num = (short)1923266306;
				short num2 = num;
				num = (short)171489026;
				switch (num2 == num)
				{
				}
				num = (short)929300480;
				short num3 = num;
				num = (short)734593024;
				if (num != 0)
				{
				}
				num = (short)766902273;
				if (num != 0)
				{
				}
				return this.dataCfgDataWideMaxSetupTimeAllowedforCCA_A36193.HiddenStatic;
			}
			set
			{
				short num = (short)1787229728;
				short num2 = num;
				num = (short)253818400;
				switch (num2 == num)
				{
				}
				num = (short)1656291328;
				short num3 = num;
				num = (short)193003520;
				if (num != 0)
				{
				}
				num = (short)544407553;
				if (num != 0)
				{
				}
				this.dataCfgDataWideMaxSetupTimeAllowedforCCA_A36193.HiddenStatic = value;
			}
		}

		// Token: 0x1700516C RID: 20844
		// (get) Token: 0x0600A284 RID: 41604 RVA: 0x0097A810 File Offset: 0x00978A10
		// (set) Token: 0x0600A285 RID: 41605 RVA: 0x0097A8C8 File Offset: 0x00978AC8
		internal bool DataCfgDataWideMaxSetupTimeAllowedforCCA_A36193_HiddenDynamic
		{
			get
			{
				short num = (short)258456579;
				short num2 = num;
				num = (short)2100083715;
				switch (num2 == num)
				{
				}
				num = (short)1123024896;
				short num3 = num;
				num = (short)916455424;
				if (num != 0)
				{
				}
				num = (short)1424424961;
				if (num != 0)
				{
				}
				return this.dataCfgDataWideMaxSetupTimeAllowedforCCA_A36193.HiddenDynamic;
			}
			set
			{
				short num = (short)978844101;
				short num2 = num;
				num = (short)1142553029;
				switch (num2 == num)
				{
				}
				num = (short)85786624;
				short num3 = num;
				num = (short)1537736705;
				if (num != 0)
				{
				}
				num = (short)1704656896;
				if (num != 0)
				{
				}
				this.dataCfgDataWideMaxSetupTimeAllowedforCCA_A36193.HiddenDynamic = value;
			}
		}

		// Token: 0x1700516D RID: 20845
		// (get) Token: 0x0600A286 RID: 41606 RVA: 0x0097A980 File Offset: 0x00978B80
		public bool DataCfgDataWideMaxSetupTimeAllowedforCCA_A36193_HasDiffs
		{
			get
			{
				short num = (short)1580523081;
				short num2 = num;
				num = (short)1581047369;
				switch (num2 == num)
				{
				}
				num = (short)580845568;
				short num3 = num;
				num = (short)1887830017;
				if (num != 0)
				{
				}
				num = (short)1762000896;
				if (num != 0)
				{
				}
				return this.dataCfgDataWideMaxSetupTimeAllowedforCCA_A36193._HasDiffs;
			}
		}

		// Token: 0x1700516E RID: 20846
		// (get) Token: 0x0600A287 RID: 41607 RVA: 0x0097AA34 File Offset: 0x00978C34
		// (set) Token: 0x0600A288 RID: 41608 RVA: 0x0097AAEC File Offset: 0x00978CEC
		public int DataConfigDataWideMaxNumofTCPIPHCContexts_A36194Value
		{
			get
			{
				short num = (short)1265414077;
				short num2 = num;
				num = (short)781692861;
				switch (num2 == num)
				{
				}
				num = (short)219938816;
				short num3 = num;
				num = (short)635961345;
				if (num != 0)
				{
				}
				num = (short)5439488;
				if (num != 0)
				{
				}
				return this.dataConfigDataWideMaxNumofTCPIPHCContexts_A36194.Value;
			}
			set
			{
				short num = (short)2039887488;
				short num2 = num;
				num = (short)1275868800;
				switch (num2 == num)
				{
				}
				num = (short)1754267648;
				short num3 = num;
				num = (short)160301057;
				if (num != 0)
				{
				}
				num = (short)804192256;
				if (num != 0)
				{
				}
				this.dataConfigDataWideMaxNumofTCPIPHCContexts_A36194.Value = value;
			}
		}

		// Token: 0x1700516F RID: 20847
		// (get) Token: 0x0600A289 RID: 41609 RVA: 0x0097ABA0 File Offset: 0x00978DA0
		public global::AcpBusinessLayer.AcpSimpleRangeField DataConfigDataWideMaxNumofTCPIPHCContexts_A36194
		{
			get
			{
				short num = (short)146191283;
				short num2 = num;
				num = (short)316847027;
				switch (num2 == num)
				{
				}
				num = (short)1277296640;
				short num3 = num;
				num = (short)1379401729;
				if (num != 0)
				{
				}
				num = (short)117243904;
				if (num != 0)
				{
				}
				return this.dataConfigDataWideMaxNumofTCPIPHCContexts_A36194;
			}
		}

		// Token: 0x17005170 RID: 20848
		// (get) Token: 0x0600A28A RID: 41610 RVA: 0x0097AC54 File Offset: 0x00978E54
		// (set) Token: 0x0600A28B RID: 41611 RVA: 0x0097AD08 File Offset: 0x00978F08
		public string DataConfigDataWideMaxNumofTCPIPHCContexts_A36194_UIValue
		{
			get
			{
				short num = (short)323114237;
				short num2 = num;
				num = (short)28005629;
				switch (num2 == num)
				{
				}
				num = (short)1330249728;
				short num3 = num;
				num = (short)1092681729;
				if (num != 0)
				{
				}
				num = (short)1541013504;
				if (num != 0)
				{
				}
				return this.dataConfigDataWideMaxNumofTCPIPHCContexts_A36194.UIValue;
			}
			set
			{
				short num = (short)713679977;
				short num2 = num;
				num = (short)26928233;
				switch (num2 == num)
				{
				}
				num = (short)1379860480;
				short num3 = num;
				num = (short)1470824449;
				if (num != 0)
				{
				}
				num = (short)135593984;
				if (num != 0)
				{
				}
				this.dataConfigDataWideMaxNumofTCPIPHCContexts_A36194.UIValue = value;
			}
		}

		// Token: 0x17005171 RID: 20849
		// (get) Token: 0x0600A28C RID: 41612 RVA: 0x0097ADBC File Offset: 0x00978FBC
		// (set) Token: 0x0600A28D RID: 41613 RVA: 0x0097AE70 File Offset: 0x00979070
		internal int DataConfigDataWideMaxNumofTCPIPHCContexts_A36194Min
		{
			get
			{
				short num = (short)417714071;
				short num2 = num;
				num = (short)1540607895;
				switch (num2 == num)
				{
				}
				num = (short)2034237440;
				short num3 = num;
				num = (short)216072192;
				if (num != 0)
				{
				}
				num = (short)504299521;
				if (num != 0)
				{
				}
				return this.dataConfigDataWideMaxNumofTCPIPHCContexts_A36194.Min;
			}
			set
			{
				short num = (short)125051180;
				short num2 = num;
				num = (short)2080579884;
				switch (num2 == num)
				{
				}
				num = (short)1424228352;
				short num3 = num;
				num = (short)1081868288;
				if (num != 0)
				{
				}
				num = (short)758841345;
				if (num != 0)
				{
				}
				this.dataConfigDataWideMaxNumofTCPIPHCContexts_A36194.Min = value;
			}
		}

		// Token: 0x17005172 RID: 20850
		// (get) Token: 0x0600A28E RID: 41614 RVA: 0x0097AF24 File Offset: 0x00979124
		// (set) Token: 0x0600A28F RID: 41615 RVA: 0x0097AFD8 File Offset: 0x009791D8
		internal int DataConfigDataWideMaxNumofTCPIPHCContexts_A36194Max
		{
			get
			{
				short num = (short)1798710493;
				short num2 = num;
				num = (short)219555037;
				switch (num2 == num)
				{
				}
				num = (short)1305280512;
				short num3 = num;
				num = (short)1429667841;
				if (num != 0)
				{
				}
				num = (short)2000683008;
				if (num != 0)
				{
				}
				return this.dataConfigDataWideMaxNumofTCPIPHCContexts_A36194.Max;
			}
			set
			{
				short num = (short)1778647041;
				if (num != 0)
				{
				}
				num = (short)1256429317;
				short num2 = num;
				num = (short)1323341573;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1343619072;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1352204288;
				if (num != 0)
				{
				}
				this.dataConfigDataWideMaxNumofTCPIPHCContexts_A36194.Max = value;
			}
		}

		// Token: 0x17005173 RID: 20851
		// (get) Token: 0x0600A290 RID: 41616 RVA: 0x0097B08C File Offset: 0x0097928C
		// (set) Token: 0x0600A291 RID: 41617 RVA: 0x0097B144 File Offset: 0x00979344
		internal int DataConfigDataWideMaxNumofTCPIPHCContexts_A36194Step
		{
			get
			{
				short num = (short)391282969;
				short num2 = num;
				num = (short)514425113;
				switch (num2 == num)
				{
				}
				num = (short)2120941568;
				short num3 = num;
				num = (short)1430192128;
				if (num != 0)
				{
				}
				num = (short)471203841;
				if (num != 0)
				{
				}
				return this.dataConfigDataWideMaxNumofTCPIPHCContexts_A36194.StepSize;
			}
			set
			{
				short num = (short)1131152806;
				short num2 = num;
				num = (short)600180134;
				switch (num2 == num)
				{
				}
				num = (short)1894580224;
				short num3 = num;
				num = (short)1701117953;
				if (num != 0)
				{
				}
				num = (short)1617952768;
				if (num != 0)
				{
				}
				this.dataConfigDataWideMaxNumofTCPIPHCContexts_A36194.StepSize = value;
			}
		}

		// Token: 0x17005174 RID: 20852
		// (get) Token: 0x0600A292 RID: 41618 RVA: 0x0097B1FC File Offset: 0x009793FC
		// (set) Token: 0x0600A293 RID: 41619 RVA: 0x0097B2B0 File Offset: 0x009794B0
		public bool DataConfigDataWideMaxNumofTCPIPHCContexts_A36194_Applicable
		{
			get
			{
				short num = (short)2143925066;
				short num2 = num;
				num = (short)1807594314;
				switch (num2 == num)
				{
				}
				num = (short)898170880;
				short num3 = num;
				num = (short)1234763777;
				if (num != 0)
				{
				}
				num = (short)1140850688;
				if (num != 0)
				{
				}
				return this.dataConfigDataWideMaxNumofTCPIPHCContexts_A36194.Applicable;
			}
			set
			{
				short num = (short)569848275;
				short num2 = num;
				num = (short)1696084435;
				switch (num2 == num)
				{
				}
				num = (short)2118320128;
				short num3 = num;
				num = (short)540344321;
				if (num != 0)
				{
				}
				num = (short)1257308160;
				if (num != 0)
				{
				}
				this.dataConfigDataWideMaxNumofTCPIPHCContexts_A36194.Applicable = value;
			}
		}

		// Token: 0x17005175 RID: 20853
		// (get) Token: 0x0600A294 RID: 41620 RVA: 0x0097B368 File Offset: 0x00979568
		// (set) Token: 0x0600A295 RID: 41621 RVA: 0x0097B41C File Offset: 0x0097961C
		public bool DataConfigDataWideMaxNumofTCPIPHCContexts_A36194_Valid
		{
			get
			{
				short num = (short)2089702115;
				short num2 = num;
				num = (short)1053250275;
				switch (num2 == num)
				{
				}
				num = (short)653131776;
				short num3 = num;
				num = (short)1960443905;
				if (num != 0)
				{
				}
				num = (short)1515913216;
				if (num != 0)
				{
				}
				return this.dataConfigDataWideMaxNumofTCPIPHCContexts_A36194.Valid;
			}
			set
			{
				short num = (short)964841764;
				short num2 = num;
				num = (short)796938532;
				switch (num2 == num)
				{
				}
				num = (short)1710161920;
				short num3 = num;
				num = (short)1936785409;
				if (num != 0)
				{
				}
				num = (short)26017792;
				if (num != 0)
				{
				}
				this.dataConfigDataWideMaxNumofTCPIPHCContexts_A36194.Valid = value;
			}
		}

		// Token: 0x17005176 RID: 20854
		// (get) Token: 0x0600A296 RID: 41622 RVA: 0x0097B4D0 File Offset: 0x009796D0
		// (set) Token: 0x0600A297 RID: 41623 RVA: 0x0097B584 File Offset: 0x00979784
		public bool DataConfigDataWideMaxNumofTCPIPHCContexts_A36194_Visible
		{
			get
			{
				short num = (short)362560428;
				short num2 = num;
				num = (short)1044462508;
				switch (num2 == num)
				{
				}
				num = (short)1487208448;
				short num3 = num;
				num = (short)245235713;
				if (num != 0)
				{
				}
				num = (short)1564409856;
				if (num != 0)
				{
				}
				return this.dataConfigDataWideMaxNumofTCPIPHCContexts_A36194.Visible;
			}
			set
			{
				short num = (short)126075715;
				short num2 = num;
				num = (short)1930675011;
				switch (num2 == num)
				{
				}
				num = (short)421199872;
				short num3 = num;
				num = (short)1146486785;
				if (num != 0)
				{
				}
				num = (short)1061748736;
				if (num != 0)
				{
				}
				this.dataConfigDataWideMaxNumofTCPIPHCContexts_A36194.Visible = value;
			}
		}

		// Token: 0x17005177 RID: 20855
		// (get) Token: 0x0600A298 RID: 41624 RVA: 0x0097B638 File Offset: 0x00979838
		// (set) Token: 0x0600A299 RID: 41625 RVA: 0x0097B6EC File Offset: 0x009798EC
		public bool DataConfigDataWideMaxNumofTCPIPHCContexts_A36194_Editable
		{
			get
			{
				short num = (short)921914627;
				short num2 = num;
				num = (short)1459899651;
				switch (num2 == num)
				{
				}
				num = (short)2043215872;
				short num3 = num;
				num = (short)754384897;
				if (num != 0)
				{
				}
				num = (short)861536256;
				if (num != 0)
				{
				}
				return this.dataConfigDataWideMaxNumofTCPIPHCContexts_A36194.Editable;
			}
			set
			{
				short num = (short)453686327;
				short num2 = num;
				num = (short)465155127;
				switch (num2 == num)
				{
				}
				num = (short)60948480;
				short num3 = num;
				num = (short)649461760;
				if (num != 0)
				{
				}
				num = (short)83034113;
				if (num != 0)
				{
				}
				this.dataConfigDataWideMaxNumofTCPIPHCContexts_A36194.Editable = value;
			}
		}

		// Token: 0x17005178 RID: 20856
		// (get) Token: 0x0600A29A RID: 41626 RVA: 0x0097B7A0 File Offset: 0x009799A0
		internal string DataConfigDataWideMaxNumofTCPIPHCContexts_A36194_UILabel
		{
			get
			{
				short num = (short)1582947265;
				short num2 = num;
				num = (short)631626689;
				switch (num2 == num)
				{
				}
				num = (short)1025310720;
				short num3 = num;
				num = (short)1247477760;
				if (num != 0)
				{
				}
				num = (short)204406785;
				if (num != 0)
				{
				}
				return this.dataConfigDataWideMaxNumofTCPIPHCContexts_A36194.UIName;
			}
		}

		// Token: 0x17005179 RID: 20857
		// (get) Token: 0x0600A29B RID: 41627 RVA: 0x0097B858 File Offset: 0x00979A58
		// (set) Token: 0x0600A29C RID: 41628 RVA: 0x0097B90C File Offset: 0x00979B0C
		internal bool DataConfigDataWideMaxNumofTCPIPHCContexts_A36194_HiddenStatic
		{
			get
			{
				short num = (short)1382654352;
				short num2 = num;
				num = (short)1955635600;
				switch (num2 == num)
				{
				}
				num = (short)1015414785;
				if (num != 0)
				{
				}
				num = (short)203685888;
				if (num != 0)
				{
				}
				num = (short)1865154560;
				short num3 = num;
				return this.dataConfigDataWideMaxNumofTCPIPHCContexts_A36194.HiddenStatic;
			}
			set
			{
				short num = (short)347078657;
				if (num != 0)
				{
				}
				num = (short)1459815062;
				short num2 = num;
				num = (short)1841431190;
				switch (num2 == num)
				{
				}
				num = (short)1802567680;
				if (num != 0)
				{
				}
				num = (short)141361152;
				short num3 = num;
				this.dataConfigDataWideMaxNumofTCPIPHCContexts_A36194.HiddenStatic = value;
			}
		}

		// Token: 0x1700517A RID: 20858
		// (get) Token: 0x0600A29D RID: 41629 RVA: 0x0097B9C0 File Offset: 0x00979BC0
		// (set) Token: 0x0600A29E RID: 41630 RVA: 0x0097BA74 File Offset: 0x00979C74
		internal bool DataConfigDataWideMaxNumofTCPIPHCContexts_A36194_HiddenDynamic
		{
			get
			{
				short num = (short)25727723;
				short num2 = num;
				num = (short)282759915;
				switch (num2 == num)
				{
				}
				num = (short)1602486273;
				if (num != 0)
				{
				}
				num = (short)1688207360;
				if (num != 0)
				{
				}
				num = (short)955449344;
				short num3 = num;
				return this.dataConfigDataWideMaxNumofTCPIPHCContexts_A36194.HiddenDynamic;
			}
			set
			{
				short num = (short)1654256900;
				short num2 = num;
				num = (short)1945629956;
				switch (num2 == num)
				{
				}
				num = (short)1942290433;
				if (num != 0)
				{
				}
				num = (short)2031616000;
				if (num != 0)
				{
				}
				num = (short)1896087552;
				short num3 = num;
				this.dataConfigDataWideMaxNumofTCPIPHCContexts_A36194.HiddenDynamic = value;
			}
		}

		// Token: 0x1700517B RID: 20859
		// (get) Token: 0x0600A29F RID: 41631 RVA: 0x0097BB2C File Offset: 0x00979D2C
		public bool DataConfigDataWideMaxNumofTCPIPHCContexts_A36194_HasDiffs
		{
			get
			{
				short num = (short)1328422366;
				short num2 = num;
				num = (short)1228873182;
				switch (num2 == num)
				{
				}
				num = (short)835387393;
				if (num != 0)
				{
				}
				num = (short)845611008;
				if (num != 0)
				{
				}
				num = (short)1721761792;
				short num3 = num;
				return this.dataConfigDataWideMaxNumofTCPIPHCContexts_A36194._HasDiffs;
			}
		}

		// Token: 0x1700517C RID: 20860
		// (get) Token: 0x0600A2A0 RID: 41632 RVA: 0x0097BBE0 File Offset: 0x00979DE0
		// (set) Token: 0x0600A2A1 RID: 41633 RVA: 0x0097BC90 File Offset: 0x00979E90
		public int DataCfgDataWideTimeSourceVar_A36196Value
		{
			get
			{
				short num = (short)1338494126;
				short num2 = num;
				num = (short)1494207662;
				switch (num2 == num)
				{
				}
				num = (short)269352960;
				if (num != 0)
				{
				}
				num = (short)581697537;
				if (num != 0)
				{
				}
				num = (short)1481900032;
				short num3 = num;
				return this.dataCfgDataWideTimeSourceVar_A36196.Value;
			}
			set
			{
				short num = (short)526647297;
				if (num != 0)
				{
				}
				num = (short)399528727;
				short num2 = num;
				num = (short)2136625943;
				switch (num2 == num)
				{
				}
				num = (short)457244672;
				if (num != 0)
				{
				}
				num = (short)619315200;
				short num3 = num;
				this.dataCfgDataWideTimeSourceVar_A36196.Value = value;
			}
		}

		// Token: 0x1700517D RID: 20861
		// (get) Token: 0x0600A2A2 RID: 41634 RVA: 0x0097BD44 File Offset: 0x00979F44
		public global::AcpBusinessLayer.AcpCustomRangeField DataCfgDataWideTimeSourceVar_A36196
		{
			get
			{
				short num = (short)2144207676;
				short num2 = num;
				num = (short)1948255036;
				switch (num2 == num)
				{
				}
				num = (short)1659305985;
				if (num != 0)
				{
				}
				num = (short)914096128;
				if (num != 0)
				{
				}
				num = (short)1041629184;
				short num3 = num;
				return this.dataCfgDataWideTimeSourceVar_A36196;
			}
		}

		// Token: 0x1700517E RID: 20862
		// (get) Token: 0x0600A2A3 RID: 41635 RVA: 0x0097BDF0 File Offset: 0x00979FF0
		// (set) Token: 0x0600A2A4 RID: 41636 RVA: 0x0097BEA4 File Offset: 0x0097A0A4
		public string DataCfgDataWideTimeSourceVar_A36196_UIValue
		{
			get
			{
				short num = (short)1009738594;
				short num2 = num;
				num = (short)1698521954;
				switch (num2 == num)
				{
				}
				num = (short)696516608;
				if (num != 0)
				{
				}
				num = (short)194248705;
				if (num != 0)
				{
				}
				num = (short)105840640;
				short num3 = num;
				return this.dataCfgDataWideTimeSourceVar_A36196.UIValue;
			}
			set
			{
				short num = (short)48985965;
				short num2 = num;
				num = (short)2065921901;
				switch (num2 == num)
				{
				}
				num = (short)129499136;
				if (num != 0)
				{
				}
				num = (short)935788545;
				if (num != 0)
				{
				}
				num = (short)1316683776;
				short num3 = num;
				this.dataCfgDataWideTimeSourceVar_A36196.UIValue = value;
			}
		}

		// Token: 0x1700517F RID: 20863
		// (get) Token: 0x0600A2A5 RID: 41637 RVA: 0x0097BF5C File Offset: 0x0097A15C
		// (set) Token: 0x0600A2A6 RID: 41638 RVA: 0x0097C014 File Offset: 0x0097A214
		internal int DataCfgDataWideTimeSourceVar_A36196Min
		{
			get
			{
				short num = (short)676205561;
				short num2 = num;
				num = (short)1455428601;
				switch (num2 == num)
				{
				}
				num = (short)1421869056;
				if (num != 0)
				{
				}
				num = (short)425197569;
				if (num != 0)
				{
				}
				num = (short)683016192;
				short num3 = num;
				return this.dataCfgDataWideTimeSourceVar_A36196.Min;
			}
			set
			{
				short num = (short)450428929;
				if (num != 0)
				{
				}
				num = (short)2080112866;
				short num2 = num;
				num = (short)1303249122;
				switch (num2 == num)
				{
				}
				num = (short)1670447104;
				if (num != 0)
				{
				}
				num = (short)1094516736;
				short num3 = num;
				this.dataCfgDataWideTimeSourceVar_A36196.Min = value;
			}
		}

		// Token: 0x17005180 RID: 20864
		// (get) Token: 0x0600A2A7 RID: 41639 RVA: 0x0097C0C4 File Offset: 0x0097A2C4
		// (set) Token: 0x0600A2A8 RID: 41640 RVA: 0x0097C17C File Offset: 0x0097A37C
		internal int DataCfgDataWideTimeSourceVar_A36196Max
		{
			get
			{
				short num = (short)1019972117;
				short num2 = num;
				num = (short)1732610581;
				switch (num2 == num)
				{
				}
				num = (short)2005073921;
				if (num != 0)
				{
				}
				num = (short)458752000;
				if (num != 0)
				{
				}
				num = (short)1134493696;
				short num3 = num;
				return this.dataCfgDataWideTimeSourceVar_A36196.Max;
			}
			set
			{
				short num = (short)435450237;
				short num2 = num;
				num = (short)1602056573;
				switch (num2 == num)
				{
				}
				num = (short)758972417;
				if (num != 0)
				{
				}
				num = (short)1401552896;
				if (num != 0)
				{
				}
				num = (short)744947712;
				short num3 = num;
				this.dataCfgDataWideTimeSourceVar_A36196.Max = value;
			}
		}

		// Token: 0x17005181 RID: 20865
		// (get) Token: 0x0600A2A9 RID: 41641 RVA: 0x0097C234 File Offset: 0x0097A434
		// (set) Token: 0x0600A2AA RID: 41642 RVA: 0x0097C2E8 File Offset: 0x0097A4E8
		internal int DataCfgDataWideTimeSourceVar_A36196Step
		{
			get
			{
				short num = (short)2109099916;
				short num2 = num;
				num = (short)888295308;
				switch (num2 == num)
				{
				}
				num = (short)776601601;
				if (num != 0)
				{
				}
				num = (short)2105802752;
				if (num != 0)
				{
				}
				num = (short)1901068288;
				short num3 = num;
				return this.dataCfgDataWideTimeSourceVar_A36196.StepSize;
			}
			set
			{
				short num = (short)388562945;
				if (num != 0)
				{
				}
				num = (short)2053630518;
				short num2 = num;
				num = (short)947120694;
				switch (num2 == num)
				{
				}
				num = (short)1975975936;
				if (num != 0)
				{
				}
				num = (short)1195704320;
				short num3 = num;
				this.dataCfgDataWideTimeSourceVar_A36196.StepSize = value;
			}
		}

		// Token: 0x17005182 RID: 20866
		// (get) Token: 0x0600A2AB RID: 41643 RVA: 0x0097C39C File Offset: 0x0097A59C
		// (set) Token: 0x0600A2AC RID: 41644 RVA: 0x0097C450 File Offset: 0x0097A650
		public bool DataCfgDataWideTimeSourceVar_A36196_Applicable
		{
			get
			{
				short num = (short)1548609359;
				short num2 = num;
				num = (short)1702553423;
				switch (num2 == num)
				{
				}
				num = (short)1478492161;
				if (num != 0)
				{
				}
				num = (short)315555840;
				if (num != 0)
				{
				}
				num = (short)1216282624;
				short num3 = num;
				return this.dataCfgDataWideTimeSourceVar_A36196.Applicable;
			}
			set
			{
				short num = (short)33486926;
				short num2 = num;
				num = (short)637728846;
				switch (num2 == num)
				{
				}
				num = (short)97058816;
				if (num != 0)
				{
				}
				num = (short)2040332289;
				if (num != 0)
				{
				}
				num = (short)1287847936;
				short num3 = num;
				this.dataCfgDataWideTimeSourceVar_A36196.Applicable = value;
			}
		}

		// Token: 0x17005183 RID: 20867
		// (get) Token: 0x0600A2AD RID: 41645 RVA: 0x0097C508 File Offset: 0x0097A708
		// (set) Token: 0x0600A2AE RID: 41646 RVA: 0x0097C5C0 File Offset: 0x0097A7C0
		public bool DataCfgDataWideTimeSourceVar_A36196_Valid
		{
			get
			{
				short num = (short)1172307969;
				if (num != 0)
				{
				}
				num = (short)1939243413;
				short num2 = num;
				num = (short)408781205;
				switch (num2 == num)
				{
				}
				num = (short)2091515904;
				if (num != 0)
				{
				}
				num = (short)260702208;
				short num3 = num;
				return this.dataCfgDataWideTimeSourceVar_A36196.Valid;
			}
			set
			{
				short num = (short)102033010;
				short num2 = num;
				num = (short)611116658;
				switch (num2 == num)
				{
				}
				num = (short)1572536321;
				if (num != 0)
				{
				}
				num = (short)700710912;
				if (num != 0)
				{
				}
				num = (short)1542258688;
				short num3 = num;
				this.dataCfgDataWideTimeSourceVar_A36196.Valid = value;
			}
		}

		// Token: 0x17005184 RID: 20868
		// (get) Token: 0x0600A2AF RID: 41647 RVA: 0x0097C678 File Offset: 0x0097A878
		// (set) Token: 0x0600A2B0 RID: 41648 RVA: 0x0097C72C File Offset: 0x0097A92C
		public bool DataCfgDataWideTimeSourceVar_A36196_Visible
		{
			get
			{
				short num = (short)371261441;
				if (num != 0)
				{
				}
				num = (short)31784869;
				short num2 = num;
				num = (short)1289420709;
				switch (num2 == num)
				{
				}
				num = (short)403439616;
				if (num != 0)
				{
				}
				num = (short)1265631232;
				short num3 = num;
				return this.dataCfgDataWideTimeSourceVar_A36196.Visible;
			}
			set
			{
				short num = (short)1663024354;
				short num2 = num;
				num = (short)1961934050;
				switch (num2 == num)
				{
				}
				num = (short)1581121536;
				if (num != 0)
				{
				}
				num = (short)624623617;
				if (num != 0)
				{
				}
				num = (short)1286733824;
				short num3 = num;
				this.dataCfgDataWideTimeSourceVar_A36196.Visible = value;
			}
		}

		// Token: 0x17005185 RID: 20869
		// (get) Token: 0x0600A2B1 RID: 41649 RVA: 0x0097C7E0 File Offset: 0x0097A9E0
		// (set) Token: 0x0600A2B2 RID: 41650 RVA: 0x0097C894 File Offset: 0x0097AA94
		public bool DataCfgDataWideTimeSourceVar_A36196_Editable
		{
			get
			{
				short num = (short)317268142;
				short num2 = num;
				num = (short)1515397294;
				switch (num2 == num)
				{
				}
				num = (short)1417084928;
				if (num != 0)
				{
				}
				num = (short)1510146049;
				if (num != 0)
				{
				}
				num = (short)288555008;
				short num3 = num;
				return this.dataCfgDataWideTimeSourceVar_A36196.Editable;
			}
			set
			{
				short num = (short)237714130;
				short num2 = num;
				num = (short)1791441618;
				switch (num2 == num)
				{
				}
				num = (short)112132096;
				if (num != 0)
				{
				}
				num = (short)1441071105;
				if (num != 0)
				{
				}
				num = (short)1439301632;
				short num3 = num;
				this.dataCfgDataWideTimeSourceVar_A36196.Editable = value;
			}
		}

		// Token: 0x17005186 RID: 20870
		// (get) Token: 0x0600A2B3 RID: 41651 RVA: 0x0097C948 File Offset: 0x0097AB48
		internal string DataCfgDataWideTimeSourceVar_A36196_UILabel
		{
			get
			{
				short num = (short)768804288;
				short num2 = num;
				num = (short)1135150528;
				switch (num2 == num)
				{
				}
				num = (short)34930688;
				if (num != 0)
				{
				}
				num = (short)993984513;
				if (num != 0)
				{
				}
				num = (short)1593049088;
				short num3 = num;
				return this.dataCfgDataWideTimeSourceVar_A36196.UIName;
			}
		}

		// Token: 0x17005187 RID: 20871
		// (get) Token: 0x0600A2B4 RID: 41652 RVA: 0x0097C9FC File Offset: 0x0097ABFC
		// (set) Token: 0x0600A2B5 RID: 41653 RVA: 0x0097CAB0 File Offset: 0x0097ACB0
		internal bool DataCfgDataWideTimeSourceVar_A36196_HiddenStatic
		{
			get
			{
				short num = (short)1809001266;
				short num2 = num;
				num = (short)772549426;
				switch (num2 == num)
				{
				}
				num = (short)2008940545;
				if (num != 0)
				{
				}
				num = (short)1383202816;
				if (num != 0)
				{
				}
				num = (short)1009385472;
				short num3 = num;
				return this.dataCfgDataWideTimeSourceVar_A36196.HiddenStatic;
			}
			set
			{
				short num = (short)1945292964;
				short num2 = num;
				num = (short)1635831972;
				switch (num2 == num)
				{
				}
				num = (short)273481729;
				if (num != 0)
				{
				}
				num = (short)2020540416;
				if (num != 0)
				{
				}
				num = (short)62914560;
				short num3 = num;
				this.dataCfgDataWideTimeSourceVar_A36196.HiddenStatic = value;
			}
		}

		// Token: 0x17005188 RID: 20872
		// (get) Token: 0x0600A2B6 RID: 41654 RVA: 0x0097CB68 File Offset: 0x0097AD68
		// (set) Token: 0x0600A2B7 RID: 41655 RVA: 0x0097CC20 File Offset: 0x0097AE20
		internal bool DataCfgDataWideTimeSourceVar_A36196_HiddenDynamic
		{
			get
			{
				short num = (short)395640833;
				if (num != 0)
				{
				}
				num = (short)1566750089;
				short num2 = num;
				num = (short)481801609;
				switch (num2 == num)
				{
				}
				num = (short)1481637888;
				if (num != 0)
				{
				}
				num = (short)1399652352;
				short num3 = num;
				return this.dataCfgDataWideTimeSourceVar_A36196.HiddenDynamic;
			}
			set
			{
				short num = (short)1586823169;
				if (num != 0)
				{
				}
				num = (short)1748720984;
				short num2 = num;
				num = (short)1904106840;
				switch (num2 == num)
				{
				}
				num = (short)225509376;
				if (num != 0)
				{
				}
				num = (short)917504000;
				short num3 = num;
				this.dataCfgDataWideTimeSourceVar_A36196.HiddenDynamic = value;
			}
		}

		// Token: 0x17005189 RID: 20873
		// (get) Token: 0x0600A2B8 RID: 41656 RVA: 0x0097CCD4 File Offset: 0x0097AED4
		public bool DataCfgDataWideTimeSourceVar_A36196_HasDiffs
		{
			get
			{
				short num = (short)1902222192;
				short num2 = num;
				num = (short)119970672;
				switch (num2 == num)
				{
				}
				num = (short)1692205057;
				if (num != 0)
				{
				}
				num = (short)1657864192;
				if (num != 0)
				{
				}
				num = (short)807141376;
				short num3 = num;
				return this.dataCfgDataWideTimeSourceVar_A36196._HasDiffs;
			}
		}

		// Token: 0x1700518A RID: 20874
		// (get) Token: 0x0600A2B9 RID: 41657 RVA: 0x0097CD88 File Offset: 0x0097AF88
		// (set) Token: 0x0600A2BA RID: 41658 RVA: 0x0097CE3C File Offset: 0x0097B03C
		public int DataConfigDataWideMaxTimeBetweenFullHeaders_A36200Value
		{
			get
			{
				short num = (short)576913409;
				if (num != 0)
				{
				}
				num = (short)992998335;
				short num2 = num;
				num = (short)677049279;
				switch (num2 == num)
				{
				}
				num = (short)1357578240;
				if (num != 0)
				{
				}
				num = (short)633470976;
				short num3 = num;
				return this.dataConfigDataWideMaxTimeBetweenFullHeaders_A36200.Value;
			}
			set
			{
				short num = (short)1608427804;
				short num2 = num;
				num = (short)306882844;
				switch (num2 == num)
				{
				}
				num = (short)881262593;
				if (num != 0)
				{
				}
				num = (short)753860608;
				if (num != 0)
				{
				}
				num = (short)1435697152;
				short num3 = num;
				this.dataConfigDataWideMaxTimeBetweenFullHeaders_A36200.Value = value;
			}
		}

		// Token: 0x1700518B RID: 20875
		// (get) Token: 0x0600A2BB RID: 41659 RVA: 0x0097CEF0 File Offset: 0x0097B0F0
		public global::AcpBusinessLayer.AcpCustomRangeField DataConfigDataWideMaxTimeBetweenFullHeaders_A36200
		{
			get
			{
				short num = (short)280561611;
				short num2 = num;
				num = (short)1485768651;
				switch (num2 == num)
				{
				}
				num = (short)285278208;
				if (num != 0)
				{
				}
				num = (short)852033537;
				if (num != 0)
				{
				}
				num = (short)487391232;
				short num3 = num;
				return this.dataConfigDataWideMaxTimeBetweenFullHeaders_A36200;
			}
		}

		// Token: 0x1700518C RID: 20876
		// (get) Token: 0x0600A2BC RID: 41660 RVA: 0x0097CFA0 File Offset: 0x0097B1A0
		// (set) Token: 0x0600A2BD RID: 41661 RVA: 0x0097D058 File Offset: 0x0097B258
		public string DataConfigDataWideMaxTimeBetweenFullHeaders_A36200_UIValue
		{
			get
			{
				short num = (short)635969027;
				short num2 = num;
				num = (short)1476861443;
				switch (num2 == num)
				{
				}
				num = (short)198246401;
				if (num != 0)
				{
				}
				num = (short)514981888;
				if (num != 0)
				{
				}
				num = (short)1138950144;
				short num3 = num;
				return this.dataConfigDataWideMaxTimeBetweenFullHeaders_A36200.UIValue;
			}
			set
			{
				short num = (short)118766777;
				short num2 = num;
				num = (short)575487161;
				switch (num2 == num)
				{
				}
				num = (short)1701445633;
				if (num != 0)
				{
				}
				num = (short)972619776;
				if (num != 0)
				{
				}
				num = (short)1057751040;
				short num3 = num;
				this.dataConfigDataWideMaxTimeBetweenFullHeaders_A36200.UIValue = value;
			}
		}

		// Token: 0x1700518D RID: 20877
		// (get) Token: 0x0600A2BE RID: 41662 RVA: 0x0097D10C File Offset: 0x0097B30C
		// (set) Token: 0x0600A2BF RID: 41663 RVA: 0x0097D1C4 File Offset: 0x0097B3C4
		internal int DataConfigDataWideMaxTimeBetweenFullHeaders_A36200Min
		{
			get
			{
				short num = (short)1444130087;
				short num2 = num;
				num = (short)1247915303;
				switch (num2 == num)
				{
				}
				num = (short)1911947265;
				if (num != 0)
				{
				}
				num = (short)232587264;
				if (num != 0)
				{
				}
				num = (short)940310528;
				short num3 = num;
				return this.dataConfigDataWideMaxTimeBetweenFullHeaders_A36200.Min;
			}
			set
			{
				short num = (short)117637120;
				short num2 = num;
				num = (short)2051735553;
				if (num != 0)
				{
				}
				num = (short)1637065620;
				short num3 = num;
				num = (short)43361172;
				switch (num3 == num)
				{
				}
				num = (short)1755774976;
				if (num != 0)
				{
				}
				this.dataConfigDataWideMaxTimeBetweenFullHeaders_A36200.Min = value;
			}
		}

		// Token: 0x1700518E RID: 20878
		// (get) Token: 0x0600A2C0 RID: 41664 RVA: 0x0097D274 File Offset: 0x0097B474
		// (set) Token: 0x0600A2C1 RID: 41665 RVA: 0x0097D328 File Offset: 0x0097B528
		internal int DataConfigDataWideMaxTimeBetweenFullHeaders_A36200Max
		{
			get
			{
				short num = (short)431095808;
				short num2 = num;
				num = (short)1367654063;
				short num3 = num;
				num = (short)387169967;
				switch (num3 == num)
				{
				}
				num = (short)326369281;
				if (num != 0)
				{
				}
				num = (short)1307377664;
				if (num != 0)
				{
				}
				return this.dataConfigDataWideMaxTimeBetweenFullHeaders_A36200.Max;
			}
			set
			{
				short num = (short)171507712;
				short num2 = num;
				num = (short)1254766366;
				short num3 = num;
				num = (short)342701854;
				switch (num3 == num)
				{
				}
				num = (short)646578176;
				if (num != 0)
				{
				}
				num = (short)389021697;
				if (num != 0)
				{
				}
				this.dataConfigDataWideMaxTimeBetweenFullHeaders_A36200.Max = value;
			}
		}

		// Token: 0x1700518F RID: 20879
		// (get) Token: 0x0600A2C2 RID: 41666 RVA: 0x0097D3DC File Offset: 0x0097B5DC
		// (set) Token: 0x0600A2C3 RID: 41667 RVA: 0x0097D490 File Offset: 0x0097B690
		internal int DataConfigDataWideMaxTimeBetweenFullHeaders_A36200Step
		{
			get
			{
				short num = (short)1362558976;
				short num2 = num;
				num = (short)1191647162;
				short num3 = num;
				num = (short)1657280442;
				switch (num3 == num)
				{
				}
				num = (short)1407909888;
				if (num != 0)
				{
				}
				num = (short)38010881;
				if (num != 0)
				{
				}
				return this.dataConfigDataWideMaxTimeBetweenFullHeaders_A36200.StepSize;
			}
			set
			{
				short num = (short)2130771968;
				short num2 = num;
				num = (short)433355904;
				short num3 = num;
				num = (short)2142469248;
				switch (num3 == num)
				{
				}
				num = (short)1252589568;
				if (num != 0)
				{
				}
				num = (short)2010841089;
				if (num != 0)
				{
				}
				this.dataConfigDataWideMaxTimeBetweenFullHeaders_A36200.StepSize = value;
			}
		}

		// Token: 0x17005190 RID: 20880
		// (get) Token: 0x0600A2C4 RID: 41668 RVA: 0x0097D548 File Offset: 0x0097B748
		// (set) Token: 0x0600A2C5 RID: 41669 RVA: 0x0097D5FC File Offset: 0x0097B7FC
		public bool DataConfigDataWideMaxTimeBetweenFullHeaders_A36200_Applicable
		{
			get
			{
				short num = (short)566886400;
				short num2 = num;
				num = (short)862920176;
				short num3 = num;
				num = (short)811539952;
				switch (num3 == num)
				{
				}
				num = (short)81330177;
				if (num != 0)
				{
				}
				num = (short)463339520;
				if (num != 0)
				{
				}
				return this.dataConfigDataWideMaxTimeBetweenFullHeaders_A36200.Applicable;
			}
			set
			{
				short num = (short)1362427904;
				short num2 = num;
				num = (short)1782104443;
				short num3 = num;
				num = (short)632930683;
				switch (num3 == num)
				{
				}
				num = (short)882900993;
				if (num != 0)
				{
				}
				num = (short)403767296;
				if (num != 0)
				{
				}
				this.dataConfigDataWideMaxTimeBetweenFullHeaders_A36200.Applicable = value;
			}
		}

		// Token: 0x17005191 RID: 20881
		// (get) Token: 0x0600A2C6 RID: 41670 RVA: 0x0097D6B0 File Offset: 0x0097B8B0
		// (set) Token: 0x0600A2C7 RID: 41671 RVA: 0x0097D764 File Offset: 0x0097B964
		public bool DataConfigDataWideMaxTimeBetweenFullHeaders_A36200_Valid
		{
			get
			{
				short num = (short)585957376;
				short num2 = num;
				num = (short)1192435607;
				short num3 = num;
				num = (short)1704271767;
				switch (num3 == num)
				{
				}
				num = (short)619970561;
				if (num != 0)
				{
				}
				num = (short)118751232;
				if (num != 0)
				{
				}
				return this.dataConfigDataWideMaxTimeBetweenFullHeaders_A36200.Valid;
			}
			set
			{
				short num = (short)560070656;
				short num2 = num;
				num = (short)1158835487;
				short num3 = num;
				num = (short)665087263;
				switch (num3 == num)
				{
				}
				num = (short)813236224;
				if (num != 0)
				{
				}
				num = (short)2055798785;
				if (num != 0)
				{
				}
				this.dataConfigDataWideMaxTimeBetweenFullHeaders_A36200.Valid = value;
			}
		}

		// Token: 0x17005192 RID: 20882
		// (get) Token: 0x0600A2C8 RID: 41672 RVA: 0x0097D818 File Offset: 0x0097BA18
		// (set) Token: 0x0600A2C9 RID: 41673 RVA: 0x0097D8CC File Offset: 0x0097BACC
		public bool DataConfigDataWideMaxTimeBetweenFullHeaders_A36200_Visible
		{
			get
			{
				short num = (short)241434624;
				short num2 = num;
				num = (short)1760756932;
				short num3 = num;
				num = (short)1910637764;
				switch (num3 == num)
				{
				}
				num = (short)729284609;
				if (num != 0)
				{
				}
				num = (short)1060241408;
				if (num != 0)
				{
				}
				return this.dataConfigDataWideMaxTimeBetweenFullHeaders_A36200.Visible;
			}
			set
			{
				short num = (short)1943076864;
				short num2 = num;
				num = (short)1764436276;
				short num3 = num;
				num = (short)243804468;
				switch (num3 == num)
				{
				}
				num = (short)380829696;
				if (num != 0)
				{
				}
				num = (short)330104833;
				if (num != 0)
				{
				}
				this.dataConfigDataWideMaxTimeBetweenFullHeaders_A36200.Visible = value;
			}
		}

		// Token: 0x17005193 RID: 20883
		// (get) Token: 0x0600A2CA RID: 41674 RVA: 0x0097D980 File Offset: 0x0097BB80
		// (set) Token: 0x0600A2CB RID: 41675 RVA: 0x0097DA38 File Offset: 0x0097BC38
		public bool DataConfigDataWideMaxTimeBetweenFullHeaders_A36200_Editable
		{
			get
			{
				short num = (short)2110717952;
				short num2 = num;
				num = (short)602800129;
				if (num != 0)
				{
				}
				num = (short)1191559254;
				short num3 = num;
				num = (short)1922089046;
				switch (num3 == num)
				{
				}
				num = (short)2038235136;
				if (num != 0)
				{
				}
				return this.dataConfigDataWideMaxTimeBetweenFullHeaders_A36200.Editable;
			}
			set
			{
				short num = (short)1929314304;
				short num2 = num;
				num = (short)1479344982;
				short num3 = num;
				num = (short)425329494;
				switch (num3 == num)
				{
				}
				num = (short)828571649;
				if (num != 0)
				{
				}
				num = (short)1498873856;
				if (num != 0)
				{
				}
				this.dataConfigDataWideMaxTimeBetweenFullHeaders_A36200.Editable = value;
			}
		}

		// Token: 0x17005194 RID: 20884
		// (get) Token: 0x0600A2CC RID: 41676 RVA: 0x0097DAEC File Offset: 0x0097BCEC
		internal string DataConfigDataWideMaxTimeBetweenFullHeaders_A36200_UILabel
		{
			get
			{
				short num = (short)165543936;
				short num2 = num;
				num = (short)1181509358;
				short num3 = num;
				num = (short)820405998;
				switch (num3 == num)
				{
				}
				num = (short)1789526017;
				if (num != 0)
				{
				}
				num = (short)1398865920;
				if (num != 0)
				{
				}
				return this.dataConfigDataWideMaxTimeBetweenFullHeaders_A36200.UIName;
			}
		}

		// Token: 0x17005195 RID: 20885
		// (get) Token: 0x0600A2CD RID: 41677 RVA: 0x0097DBA4 File Offset: 0x0097BDA4
		// (set) Token: 0x0600A2CE RID: 41678 RVA: 0x0097DC5C File Offset: 0x0097BE5C
		internal bool DataConfigDataWideMaxTimeBetweenFullHeaders_A36200_HiddenStatic
		{
			get
			{
				short num = (short)1552154624;
				short num2 = num;
				num = (short)2057983069;
				short num3 = num;
				num = (short)1477596253;
				switch (num3 == num)
				{
				}
				num = (short)1027211264;
				if (num != 0)
				{
				}
				num = (short)2102722561;
				if (num != 0)
				{
				}
				return this.dataConfigDataWideMaxTimeBetweenFullHeaders_A36200.HiddenStatic;
			}
			set
			{
				short num = (short)524615680;
				short num2 = num;
				num = (short)134597364;
				short num3 = num;
				num = (short)1509804788;
				switch (num3 == num)
				{
				}
				num = (short)1025900544;
				if (num != 0)
				{
				}
				num = (short)233635841;
				if (num != 0)
				{
				}
				this.dataConfigDataWideMaxTimeBetweenFullHeaders_A36200.HiddenStatic = value;
			}
		}

		// Token: 0x17005196 RID: 20886
		// (get) Token: 0x0600A2CF RID: 41679 RVA: 0x0097DD10 File Offset: 0x0097BF10
		// (set) Token: 0x0600A2D0 RID: 41680 RVA: 0x0097DDC0 File Offset: 0x0097BFC0
		internal bool DataConfigDataWideMaxTimeBetweenFullHeaders_A36200_HiddenDynamic
		{
			get
			{
				short num = (short)1164378112;
				short num2 = num;
				num = (short)723569518;
				short num3 = num;
				num = (short)1024969582;
				switch (num3 == num)
				{
				}
				num = (short)834600961;
				if (num != 0)
				{
				}
				num = (short)537657344;
				if (num != 0)
				{
				}
				return this.dataConfigDataWideMaxTimeBetweenFullHeaders_A36200.HiddenDynamic;
			}
			set
			{
				short num = (short)570032128;
				short num2 = num;
				num = (short)1321520580;
				short num3 = num;
				num = (short)1685835204;
				switch (num3 == num)
				{
				}
				num = (short)920256513;
				if (num != 0)
				{
				}
				num = (short)1303707648;
				if (num != 0)
				{
				}
				this.dataConfigDataWideMaxTimeBetweenFullHeaders_A36200.HiddenDynamic = value;
			}
		}

		// Token: 0x17005197 RID: 20887
		// (get) Token: 0x0600A2D1 RID: 41681 RVA: 0x0097DE78 File Offset: 0x0097C078
		public bool DataConfigDataWideMaxTimeBetweenFullHeaders_A36200_HasDiffs
		{
			get
			{
				short num = (short)1801977856;
				short num2 = num;
				num = (short)790289436;
				short num3 = num;
				num = (short)800840732;
				switch (num3 == num)
				{
				}
				num = (short)602931200;
				if (num != 0)
				{
				}
				num = (short)180486145;
				if (num != 0)
				{
				}
				return this.dataConfigDataWideMaxTimeBetweenFullHeaders_A36200._HasDiffs;
			}
		}

		// Token: 0x17005198 RID: 20888
		// (get) Token: 0x0600A2D2 RID: 41682 RVA: 0x0097DF30 File Offset: 0x0097C130
		// (set) Token: 0x0600A2D3 RID: 41683 RVA: 0x0097DFE4 File Offset: 0x0097C1E4
		public int DataConfigDataWideMaxNumOfCompreHeadersBetweenFullHeaders_A36205Value
		{
			get
			{
				short num = (short)2132869120;
				short num2 = num;
				num = (short)1886774445;
				short num3 = num;
				num = (short)1546183853;
				switch (num3 == num)
				{
				}
				num = (short)1477443585;
				if (num != 0)
				{
				}
				num = (short)1360723968;
				if (num != 0)
				{
				}
				return this.dataConfigDataWideMaxNumOfCompreHeadersBetweenFullHeaders_A36205.Value;
			}
			set
			{
				short num = (short)613482496;
				short num2 = num;
				num = (short)233431528;
				short num3 = num;
				num = (short)2101797352;
				switch (num3 == num)
				{
				}
				num = (short)270860289;
				if (num != 0)
				{
				}
				num = (short)2137784320;
				if (num != 0)
				{
				}
				this.dataConfigDataWideMaxNumOfCompreHeadersBetweenFullHeaders_A36205.Value = value;
			}
		}

		// Token: 0x17005199 RID: 20889
		// (get) Token: 0x0600A2D4 RID: 41684 RVA: 0x0097E09C File Offset: 0x0097C29C
		public global::AcpBusinessLayer.AcpCustomRangeField DataConfigDataWideMaxNumOfCompreHeadersBetweenFullHeaders_A36205
		{
			get
			{
				short num = (short)1189085184;
				short num2 = num;
				num = (short)1301567513;
				short num3 = num;
				num = (short)1165907993;
				switch (num3 == num)
				{
				}
				num = (short)1152253953;
				if (num != 0)
				{
				}
				num = (short)458752000;
				if (num != 0)
				{
				}
				return this.dataConfigDataWideMaxNumOfCompreHeadersBetweenFullHeaders_A36205;
			}
		}

		// Token: 0x1700519A RID: 20890
		// (get) Token: 0x0600A2D5 RID: 41685 RVA: 0x0097E150 File Offset: 0x0097C350
		// (set) Token: 0x0600A2D6 RID: 41686 RVA: 0x0097E204 File Offset: 0x0097C404
		public string DataConfigDataWideMaxNumOfCompreHeadersBetweenFullHeaders_A36205_UIValue
		{
			get
			{
				short num = (short)1993539584;
				short num2 = num;
				num = (short)1222569795;
				short num3 = num;
				num = (short)2010836803;
				switch (num3 == num)
				{
				}
				num = (short)996737025;
				if (num != 0)
				{
				}
				num = (short)852164608;
				if (num != 0)
				{
				}
				return this.dataConfigDataWideMaxNumOfCompreHeadersBetweenFullHeaders_A36205.UIValue;
			}
			set
			{
				short num = (short)1185087488;
				short num2 = num;
				num = (short)783417345;
				if (num != 0)
				{
				}
				num = (short)2047668908;
				short num3 = num;
				num = (short)504492716;
				switch (num3 == num)
				{
				}
				num = (short)223936512;
				if (num != 0)
				{
				}
				this.dataConfigDataWideMaxNumOfCompreHeadersBetweenFullHeaders_A36205.UIValue = value;
			}
		}

		// Token: 0x1700519B RID: 20891
		// (get) Token: 0x0600A2D7 RID: 41687 RVA: 0x0097E2B8 File Offset: 0x0097C4B8
		// (set) Token: 0x0600A2D8 RID: 41688 RVA: 0x0097E36C File Offset: 0x0097C56C
		internal int DataConfigDataWideMaxNumOfCompreHeadersBetweenFullHeaders_A36205Min
		{
			get
			{
				short num = (short)818741248;
				short num2 = num;
				num = (short)765197322;
				short num3 = num;
				num = (short)1688861706;
				switch (num3 == num)
				{
				}
				num = (short)1452474369;
				if (num != 0)
				{
				}
				num = (short)1992753152;
				if (num != 0)
				{
				}
				return this.dataConfigDataWideMaxNumOfCompreHeadersBetweenFullHeaders_A36205.Min;
			}
			set
			{
				short num = (short)1012072448;
				short num2 = num;
				num = (short)119774606;
				short num3 = num;
				num = (short)114728334;
				switch (num3 == num)
				{
				}
				num = (short)524025856;
				if (num != 0)
				{
				}
				num = (short)719192065;
				if (num != 0)
				{
				}
				this.dataConfigDataWideMaxNumOfCompreHeadersBetweenFullHeaders_A36205.Min = value;
			}
		}

		// Token: 0x1700519C RID: 20892
		// (get) Token: 0x0600A2D9 RID: 41689 RVA: 0x0097E420 File Offset: 0x0097C620
		// (set) Token: 0x0600A2DA RID: 41690 RVA: 0x0097E4D8 File Offset: 0x0097C6D8
		internal int DataConfigDataWideMaxNumOfCompreHeadersBetweenFullHeaders_A36205Max
		{
			get
			{
				short num = (short)630194176;
				short num2 = num;
				num = (short)1598793187;
				short num3 = num;
				num = (short)1273341411;
				switch (num3 == num)
				{
				}
				num = (short)1545535489;
				if (num != 0)
				{
				}
				num = (short)1029636096;
				if (num != 0)
				{
				}
				return this.dataConfigDataWideMaxNumOfCompreHeadersBetweenFullHeaders_A36205.Max;
			}
			set
			{
				short num = (short)153550848;
				short num2 = num;
				num = (short)785565682;
				short num3 = num;
				num = (short)652658674;
				switch (num3 == num)
				{
				}
				num = (short)709820417;
				if (num != 0)
				{
				}
				num = (short)516882432;
				if (num != 0)
				{
				}
				this.dataConfigDataWideMaxNumOfCompreHeadersBetweenFullHeaders_A36205.Max = value;
			}
		}

		// Token: 0x1700519D RID: 20893
		// (get) Token: 0x0600A2DB RID: 41691 RVA: 0x0097E58C File Offset: 0x0097C78C
		// (set) Token: 0x0600A2DC RID: 41692 RVA: 0x0097E640 File Offset: 0x0097C840
		internal int DataConfigDataWideMaxNumOfCompreHeadersBetweenFullHeaders_A36205Step
		{
			get
			{
				short num = (short)1693712384;
				short num2 = num;
				num = (short)988382126;
				short num3 = num;
				num = (short)1530299310;
				switch (num3 == num)
				{
				}
				num = (short)1640890368;
				if (num != 0)
				{
				}
				num = (short)1902313473;
				if (num != 0)
				{
				}
				return this.dataConfigDataWideMaxNumOfCompreHeadersBetweenFullHeaders_A36205.StepSize;
			}
			set
			{
				short num = (short)1043005440;
				short num2 = num;
				num = (short)445672157;
				short num3 = num;
				num = (short)688286429;
				switch (num3 == num)
				{
				}
				num = (short)212336641;
				if (num != 0)
				{
				}
				num = (short)646709248;
				if (num != 0)
				{
				}
				this.dataConfigDataWideMaxNumOfCompreHeadersBetweenFullHeaders_A36205.StepSize = value;
			}
		}

		// Token: 0x1700519E RID: 20894
		// (get) Token: 0x0600A2DD RID: 41693 RVA: 0x0097E6F4 File Offset: 0x0097C8F4
		// (set) Token: 0x0600A2DE RID: 41694 RVA: 0x0097E7A8 File Offset: 0x0097C9A8
		public bool DataConfigDataWideMaxNumOfCompreHeadersBetweenFullHeaders_A36205_Applicable
		{
			get
			{
				short num = (short)1523187712;
				short num2 = num;
				num = (short)1805254657;
				if (num != 0)
				{
				}
				num = (short)1092155670;
				short num3 = num;
				num = (short)313063702;
				switch (num3 == num)
				{
				}
				num = (short)125435904;
				if (num != 0)
				{
				}
				return this.dataConfigDataWideMaxNumOfCompreHeadersBetweenFullHeaders_A36205.Applicable;
			}
			set
			{
				short num = (short)574750720;
				short num2 = num;
				num = (short)1653435410;
				short num3 = num;
				num = (short)1724410898;
				switch (num3 == num)
				{
				}
				num = (short)1826422784;
				if (num != 0)
				{
				}
				num = (short)1495531521;
				if (num != 0)
				{
				}
				this.dataConfigDataWideMaxNumOfCompreHeadersBetweenFullHeaders_A36205.Applicable = value;
			}
		}

		// Token: 0x1700519F RID: 20895
		// (get) Token: 0x0600A2DF RID: 41695 RVA: 0x0097E860 File Offset: 0x0097CA60
		// (set) Token: 0x0600A2E0 RID: 41696 RVA: 0x0097E914 File Offset: 0x0097CB14
		public bool DataConfigDataWideMaxNumOfCompreHeadersBetweenFullHeaders_A36205_Valid
		{
			get
			{
				short num = (short)1813512192;
				short num2 = num;
				num = (short)972895427;
				short num3 = num;
				num = (short)735851715;
				switch (num3 == num)
				{
				}
				num = (short)1884618753;
				if (num != 0)
				{
				}
				num = (short)217907200;
				if (num != 0)
				{
				}
				return this.dataConfigDataWideMaxNumOfCompreHeadersBetweenFullHeaders_A36205.Valid;
			}
			set
			{
				short num = (short)1325203456;
				short num2 = num;
				num = (short)1002676837;
				short num3 = num;
				num = (short)1910612581;
				switch (num3 == num)
				{
				}
				num = (short)411500545;
				if (num != 0)
				{
				}
				num = (short)36634624;
				if (num != 0)
				{
				}
				this.dataConfigDataWideMaxNumOfCompreHeadersBetweenFullHeaders_A36205.Valid = value;
			}
		}

		// Token: 0x170051A0 RID: 20896
		// (get) Token: 0x0600A2E1 RID: 41697 RVA: 0x0097E9C8 File Offset: 0x0097CBC8
		// (set) Token: 0x0600A2E2 RID: 41698 RVA: 0x0097EA7C File Offset: 0x0097CC7C
		public bool DataConfigDataWideMaxNumOfCompreHeadersBetweenFullHeaders_A36205_Visible
		{
			get
			{
				short num = (short)805044224;
				short num2 = num;
				num = (short)282805921;
				short num3 = num;
				num = (short)934364833;
				switch (num3 == num)
				{
				}
				num = (short)1877082112;
				if (num != 0)
				{
				}
				num = (short)984678401;
				if (num != 0)
				{
				}
				return this.dataConfigDataWideMaxNumOfCompreHeadersBetweenFullHeaders_A36205.Visible;
			}
			set
			{
				short num = (short)1227292672;
				short num2 = num;
				num = (short)1222639617;
				if (num != 0)
				{
				}
				num = (short)606218399;
				short num3 = num;
				num = (short)855124127;
				switch (num3 == num)
				{
				}
				num = (short)1279328256;
				if (num != 0)
				{
				}
				this.dataConfigDataWideMaxNumOfCompreHeadersBetweenFullHeaders_A36205.Visible = value;
			}
		}

		// Token: 0x170051A1 RID: 20897
		// (get) Token: 0x0600A2E3 RID: 41699 RVA: 0x0097EB30 File Offset: 0x0097CD30
		// (set) Token: 0x0600A2E4 RID: 41700 RVA: 0x0097EBE4 File Offset: 0x0097CDE4
		public bool DataConfigDataWideMaxNumOfCompreHeadersBetweenFullHeaders_A36205_Editable
		{
			get
			{
				short num = (short)1068630016;
				short num2 = num;
				num = (short)1453113648;
				short num3 = num;
				num = (short)1176486192;
				switch (num3 == num)
				{
				}
				num = (short)454361088;
				if (num != 0)
				{
				}
				num = (short)1848442881;
				if (num != 0)
				{
				}
				return this.dataConfigDataWideMaxNumOfCompreHeadersBetweenFullHeaders_A36205.Editable;
			}
			set
			{
				short num = (short)1459617792;
				short num2 = num;
				num = (short)1778280922;
				short num3 = num;
				num = (short)1785096666;
				switch (num3 == num)
				{
				}
				num = (short)1497497601;
				if (num != 0)
				{
				}
				num = (short)1289224192;
				if (num != 0)
				{
				}
				this.dataConfigDataWideMaxNumOfCompreHeadersBetweenFullHeaders_A36205.Editable = value;
			}
		}

		// Token: 0x170051A2 RID: 20898
		// (get) Token: 0x0600A2E5 RID: 41701 RVA: 0x0097EC98 File Offset: 0x0097CE98
		internal string DataConfigDataWideMaxNumOfCompreHeadersBetweenFullHeaders_A36205_UILabel
		{
			get
			{
				short num = (short)2000551936;
				short num2 = num;
				num = (short)1452960242;
				short num3 = num;
				num = (short)681535986;
				switch (num3 == num)
				{
				}
				num = (short)500367360;
				if (num != 0)
				{
				}
				num = (short)1479606273;
				if (num != 0)
				{
				}
				return this.dataConfigDataWideMaxNumOfCompreHeadersBetweenFullHeaders_A36205.UIName;
			}
		}

		// Token: 0x170051A3 RID: 20899
		// (get) Token: 0x0600A2E6 RID: 41702 RVA: 0x0097ED4C File Offset: 0x0097CF4C
		// (set) Token: 0x0600A2E7 RID: 41703 RVA: 0x0097EDFC File Offset: 0x0097CFFC
		internal bool DataConfigDataWideMaxNumOfCompreHeadersBetweenFullHeaders_A36205_HiddenStatic
		{
			get
			{
				short num = (short)1455357952;
				short num2 = num;
				num = (short)295690676;
				short num3 = num;
				num = (short)2000871860;
				switch (num3 == num)
				{
				}
				num = (short)1516568577;
				if (num != 0)
				{
				}
				num = (short)1058144256;
				if (num != 0)
				{
				}
				return this.dataConfigDataWideMaxNumOfCompreHeadersBetweenFullHeaders_A36205.HiddenStatic;
			}
			set
			{
				short num = (short)1891237888;
				short num2 = num;
				num = (short)1900477287;
				short num3 = num;
				num = (short)1662253927;
				switch (num3 == num)
				{
				}
				num = (short)223870977;
				if (num != 0)
				{
				}
				num = (short)160694272;
				if (num != 0)
				{
				}
				this.dataConfigDataWideMaxNumOfCompreHeadersBetweenFullHeaders_A36205.HiddenStatic = value;
			}
		}

		// Token: 0x170051A4 RID: 20900
		// (get) Token: 0x0600A2E8 RID: 41704 RVA: 0x0097EEB4 File Offset: 0x0097D0B4
		// (set) Token: 0x0600A2E9 RID: 41705 RVA: 0x0097EF68 File Offset: 0x0097D168
		internal bool DataConfigDataWideMaxNumOfCompreHeadersBetweenFullHeaders_A36205_HiddenDynamic
		{
			get
			{
				short num = (short)1614413824;
				short num2 = num;
				num = (short)539230486;
				short num3 = num;
				num = (short)1528824086;
				switch (num3 == num)
				{
				}
				num = (short)1314258945;
				if (num != 0)
				{
				}
				num = (short)5439488;
				if (num != 0)
				{
				}
				return this.dataConfigDataWideMaxNumOfCompreHeadersBetweenFullHeaders_A36205.HiddenDynamic;
			}
			set
			{
				short num = (short)40960000;
				short num2 = num;
				num = (short)1307574273;
				if (num != 0)
				{
				}
				num = (short)1960496562;
				short num3 = num;
				num = (short)997510578;
				switch (num3 == num)
				{
				}
				num = (short)1699807232;
				if (num != 0)
				{
				}
				this.dataConfigDataWideMaxNumOfCompreHeadersBetweenFullHeaders_A36205.HiddenDynamic = value;
			}
		}

		// Token: 0x170051A5 RID: 20901
		// (get) Token: 0x0600A2EA RID: 41706 RVA: 0x0097F01C File Offset: 0x0097D21C
		public bool DataConfigDataWideMaxNumOfCompreHeadersBetweenFullHeaders_A36205_HasDiffs
		{
			get
			{
				short num = (short)393281788;
				short num2 = num;
				num = (short)2017984764;
				switch (num2 == num)
				{
				}
				num = (short)1151860736;
				short num3 = num;
				num = (short)1872101377;
				if (num != 0)
				{
				}
				num = (short)799277056;
				if (num != 0)
				{
				}
				return this.dataConfigDataWideMaxNumOfCompreHeadersBetweenFullHeaders_A36205._HasDiffs;
			}
		}

		// Token: 0x170051A6 RID: 20902
		// (get) Token: 0x0600A2EB RID: 41707 RVA: 0x0097F0D0 File Offset: 0x0097D2D0
		// (set) Token: 0x0600A2EC RID: 41708 RVA: 0x0097F188 File Offset: 0x0097D388
		public int DataConfigDataWideMaxHeaderSizeAllowedForCompression_A36206Value
		{
			get
			{
				short num = (short)2066547197;
				short num2 = num;
				num = (short)912523773;
				switch (num2 == num)
				{
				}
				num = (short)332070912;
				short num3 = num;
				num = (short)695861249;
				if (num != 0)
				{
				}
				num = (short)1999241216;
				if (num != 0)
				{
				}
				return this.dataConfigDataWideMaxHeaderSizeAllowedForCompression_A36206.Value;
			}
			set
			{
				short num = (short)1954025549;
				short num2 = num;
				num = (short)1963462733;
				switch (num2 == num)
				{
				}
				num = (short)1293352960;
				short num3 = num;
				num = (short)808386561;
				if (num != 0)
				{
				}
				num = (short)1148846080;
				if (num != 0)
				{
				}
				this.dataConfigDataWideMaxHeaderSizeAllowedForCompression_A36206.Value = value;
			}
		}

		// Token: 0x170051A7 RID: 20903
		// (get) Token: 0x0600A2ED RID: 41709 RVA: 0x0097F23C File Offset: 0x0097D43C
		public global::AcpBusinessLayer.AcpSimpleRangeField DataConfigDataWideMaxHeaderSizeAllowedForCompression_A36206
		{
			get
			{
				short num = (short)2036970034;
				short num2 = num;
				num = (short)1577366066;
				switch (num2 == num)
				{
				}
				num = (short)770965504;
				short num3 = num;
				num = (short)1021771777;
				if (num != 0)
				{
				}
				num = (short)648675328;
				if (num != 0)
				{
				}
				return this.dataConfigDataWideMaxHeaderSizeAllowedForCompression_A36206;
			}
		}

		// Token: 0x170051A8 RID: 20904
		// (get) Token: 0x0600A2EE RID: 41710 RVA: 0x0097F2F0 File Offset: 0x0097D4F0
		// (set) Token: 0x0600A2EF RID: 41711 RVA: 0x0097F3A4 File Offset: 0x0097D5A4
		public string DataConfigDataWideMaxHeaderSizeAllowedForCompression_A36206_UIValue
		{
			get
			{
				short num = (short)1389819498;
				short num2 = num;
				num = (short)1409807978;
				switch (num2 == num)
				{
				}
				num = (short)1281884160;
				short num3 = num;
				num = (short)1177812992;
				if (num != 0)
				{
				}
				num = (short)1120010241;
				if (num != 0)
				{
				}
				return this.dataConfigDataWideMaxHeaderSizeAllowedForCompression_A36206.UIValue;
			}
			set
			{
				short num = (short)1711359762;
				short num2 = num;
				num = (short)1657947922;
				switch (num2 == num)
				{
				}
				num = (short)479395840;
				short num3 = num;
				num = (short)828571649;
				if (num != 0)
				{
				}
				num = (short)1456144384;
				if (num != 0)
				{
				}
				this.dataConfigDataWideMaxHeaderSizeAllowedForCompression_A36206.UIValue = value;
			}
		}

		// Token: 0x170051A9 RID: 20905
		// (get) Token: 0x0600A2F0 RID: 41712 RVA: 0x0097F458 File Offset: 0x0097D658
		// (set) Token: 0x0600A2F1 RID: 41713 RVA: 0x0097F50C File Offset: 0x0097D70C
		internal int DataConfigDataWideMaxHeaderSizeAllowedForCompression_A36206Min
		{
			get
			{
				short num = (short)647243978;
				short num2 = num;
				num = (short)31795402;
				switch (num2 == num)
				{
				}
				num = (short)1786249216;
				short num3 = num;
				num = (short)28311553;
				if (num != 0)
				{
				}
				num = (short)657326080;
				if (num != 0)
				{
				}
				return this.dataConfigDataWideMaxHeaderSizeAllowedForCompression_A36206.Min;
			}
			set
			{
				short num = (short)464191489;
				if (num != 0)
				{
				}
				num = (short)626515373;
				short num2 = num;
				num = (short)1759108525;
				switch (num2 == num)
				{
				default:
				{
					num = (short)863240192;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1651245056;
				if (num != 0)
				{
				}
				this.dataConfigDataWideMaxHeaderSizeAllowedForCompression_A36206.Min = value;
			}
		}

		// Token: 0x170051AA RID: 20906
		// (get) Token: 0x0600A2F2 RID: 41714 RVA: 0x0097F5C0 File Offset: 0x0097D7C0
		// (set) Token: 0x0600A2F3 RID: 41715 RVA: 0x0097F674 File Offset: 0x0097D874
		internal int DataConfigDataWideMaxHeaderSizeAllowedForCompression_A36206Max
		{
			get
			{
				short num = (short)1148008967;
				short num2 = num;
				num = (short)1521695239;
				switch (num2 == num)
				{
				}
				num = (short)1623851008;
				short num3 = num;
				num = (short)1941700608;
				if (num != 0)
				{
				}
				num = (short)531496961;
				if (num != 0)
				{
				}
				return this.dataConfigDataWideMaxHeaderSizeAllowedForCompression_A36206.Max;
			}
			set
			{
				short num = (short)33440231;
				short num2 = num;
				num = (short)930431463;
				switch (num2 == num)
				{
				}
				num = (short)301662208;
				short num3 = num;
				num = (short)1804009472;
				if (num != 0)
				{
				}
				num = (short)1724514305;
				if (num != 0)
				{
				}
				this.dataConfigDataWideMaxHeaderSizeAllowedForCompression_A36206.Max = value;
			}
		}

		// Token: 0x170051AB RID: 20907
		// (get) Token: 0x0600A2F4 RID: 41716 RVA: 0x0097F728 File Offset: 0x0097D928
		// (set) Token: 0x0600A2F5 RID: 41717 RVA: 0x0097F7DC File Offset: 0x0097D9DC
		internal int DataConfigDataWideMaxHeaderSizeAllowedForCompression_A36206Step
		{
			get
			{
				short num = (short)1088815105;
				if (num != 0)
				{
				}
				num = (short)2056935436;
				short num2 = num;
				num = (short)127031308;
				switch (num2 == num)
				{
				default:
				{
					num = (short)593756160;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1516765184;
				if (num != 0)
				{
				}
				return this.dataConfigDataWideMaxHeaderSizeAllowedForCompression_A36206.StepSize;
			}
			set
			{
				short num = (short)96862209;
				if (num != 0)
				{
				}
				num = (short)1707723582;
				short num2 = num;
				num = (short)1565772606;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1465253888;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1966604288;
				if (num != 0)
				{
				}
				this.dataConfigDataWideMaxHeaderSizeAllowedForCompression_A36206.StepSize = value;
			}
		}

		// Token: 0x170051AC RID: 20908
		// (get) Token: 0x0600A2F6 RID: 41718 RVA: 0x0097F894 File Offset: 0x0097DA94
		// (set) Token: 0x0600A2F7 RID: 41719 RVA: 0x0097F948 File Offset: 0x0097DB48
		public bool DataConfigDataWideMaxHeaderSizeAllowedForCompression_A36206_Applicable
		{
			get
			{
				short num = (short)40323963;
				short num2 = num;
				num = (short)779111291;
				switch (num2 == num)
				{
				}
				num = (short)1066074112;
				short num3 = num;
				num = (short)898367489;
				if (num != 0)
				{
				}
				num = (short)664797184;
				if (num != 0)
				{
				}
				return this.dataConfigDataWideMaxHeaderSizeAllowedForCompression_A36206.Applicable;
			}
			set
			{
				short num = (short)1229180780;
				short num2 = num;
				num = (short)120311660;
				switch (num2 == num)
				{
				}
				num = (short)1069809664;
				short num3 = num;
				num = (short)1839923200;
				if (num != 0)
				{
				}
				num = (short)770375681;
				if (num != 0)
				{
				}
				this.dataConfigDataWideMaxHeaderSizeAllowedForCompression_A36206.Applicable = value;
			}
		}

		// Token: 0x170051AD RID: 20909
		// (get) Token: 0x0600A2F8 RID: 41720 RVA: 0x0097FA00 File Offset: 0x0097DC00
		// (set) Token: 0x0600A2F9 RID: 41721 RVA: 0x0097FAB8 File Offset: 0x0097DCB8
		public bool DataConfigDataWideMaxHeaderSizeAllowedForCompression_A36206_Valid
		{
			get
			{
				short num = (short)724452465;
				short num2 = num;
				num = (short)183649393;
				switch (num2 == num)
				{
				}
				num = (short)1438253056;
				short num3 = num;
				num = (short)1807220736;
				if (num != 0)
				{
				}
				num = (short)1641283585;
				if (num != 0)
				{
				}
				return this.dataConfigDataWideMaxHeaderSizeAllowedForCompression_A36206.Valid;
			}
			set
			{
				short num = (short)1112087471;
				short num2 = num;
				num = (short)1358633903;
				switch (num2 == num)
				{
				}
				num = (short)1322254336;
				short num3 = num;
				num = (short)1852637185;
				if (num != 0)
				{
				}
				num = (short)999358464;
				if (num != 0)
				{
				}
				this.dataConfigDataWideMaxHeaderSizeAllowedForCompression_A36206.Valid = value;
			}
		}

		// Token: 0x170051AE RID: 20910
		// (get) Token: 0x0600A2FA RID: 41722 RVA: 0x0097FB70 File Offset: 0x0097DD70
		// (set) Token: 0x0600A2FB RID: 41723 RVA: 0x0097FC28 File Offset: 0x0097DE28
		public bool DataConfigDataWideMaxHeaderSizeAllowedForCompression_A36206_Visible
		{
			get
			{
				short num = (short)652271345;
				short num2 = num;
				num = (short)1139859185;
				switch (num2 == num)
				{
				}
				num = (short)347209728;
				short num3 = num;
				num = (short)605945856;
				if (num != 0)
				{
				}
				num = (short)226295809;
				if (num != 0)
				{
				}
				return this.dataConfigDataWideMaxHeaderSizeAllowedForCompression_A36206.Visible;
			}
			set
			{
				short num = (short)841482241;
				if (num != 0)
				{
				}
				num = (short)551647245;
				short num2 = num;
				num = (short)88766477;
				switch (num2 == num)
				{
				default:
				{
					num = (short)660733952;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)586153984;
				if (num != 0)
				{
				}
				this.dataConfigDataWideMaxHeaderSizeAllowedForCompression_A36206.Visible = value;
			}
		}

		// Token: 0x170051AF RID: 20911
		// (get) Token: 0x0600A2FC RID: 41724 RVA: 0x0097FCE0 File Offset: 0x0097DEE0
		// (set) Token: 0x0600A2FD RID: 41725 RVA: 0x0097FD98 File Offset: 0x0097DF98
		public bool DataConfigDataWideMaxHeaderSizeAllowedForCompression_A36206_Editable
		{
			get
			{
				short num = (short)1124401153;
				if (num != 0)
				{
				}
				num = (short)331807112;
				short num2 = num;
				num = (short)1653209480;
				switch (num2 == num)
				{
				default:
				{
					num = (short)476184576;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)334168064;
				if (num != 0)
				{
				}
				return this.dataConfigDataWideMaxHeaderSizeAllowedForCompression_A36206.Editable;
			}
			set
			{
				short num = (short)1909300201;
				short num2 = num;
				num = (short)249994217;
				switch (num2 == num)
				{
				}
				num = (short)242155520;
				short num3 = num;
				num = (short)171311105;
				if (num != 0)
				{
				}
				num = (short)562626560;
				if (num != 0)
				{
				}
				this.dataConfigDataWideMaxHeaderSizeAllowedForCompression_A36206.Editable = value;
			}
		}

		// Token: 0x170051B0 RID: 20912
		// (get) Token: 0x0600A2FE RID: 41726 RVA: 0x0097FE4C File Offset: 0x0097E04C
		internal string DataConfigDataWideMaxHeaderSizeAllowedForCompression_A36206_UILabel
		{
			get
			{
				short num = (short)1253638722;
				short num2 = num;
				num = (short)1380713026;
				switch (num2 == num)
				{
				}
				num = (short)1923350528;
				short num3 = num;
				num = (short)1156972545;
				if (num != 0)
				{
				}
				num = (short)1374879744;
				if (num != 0)
				{
				}
				return this.dataConfigDataWideMaxHeaderSizeAllowedForCompression_A36206.UIName;
			}
		}

		// Token: 0x170051B1 RID: 20913
		// (get) Token: 0x0600A2FF RID: 41727 RVA: 0x0097FF00 File Offset: 0x0097E100
		// (set) Token: 0x0600A300 RID: 41728 RVA: 0x0097FFB4 File Offset: 0x0097E1B4
		internal bool DataConfigDataWideMaxHeaderSizeAllowedForCompression_A36206_HiddenStatic
		{
			get
			{
				short num = (short)527302657;
				if (num != 0)
				{
				}
				num = (short)27003821;
				short num2 = num;
				num = (short)694356909;
				switch (num2 == num)
				{
				default:
				{
					num = (short)980877312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1231552512;
				if (num != 0)
				{
				}
				return this.dataConfigDataWideMaxHeaderSizeAllowedForCompression_A36206.HiddenStatic;
			}
			set
			{
				short num = (short)1168555298;
				short num2 = num;
				num = (short)2136390946;
				switch (num2 == num)
				{
				}
				num = (short)1503657984;
				short num3 = num;
				num = (short)1647575041;
				if (num != 0)
				{
				}
				num = (short)929103872;
				if (num != 0)
				{
				}
				this.dataConfigDataWideMaxHeaderSizeAllowedForCompression_A36206.HiddenStatic = value;
			}
		}

		// Token: 0x170051B2 RID: 20914
		// (get) Token: 0x0600A301 RID: 41729 RVA: 0x00980068 File Offset: 0x0097E268
		// (set) Token: 0x0600A302 RID: 41730 RVA: 0x00980118 File Offset: 0x0097E318
		internal bool DataConfigDataWideMaxHeaderSizeAllowedForCompression_A36206_HiddenDynamic
		{
			get
			{
				short num = (short)2460563;
				short num2 = num;
				num = (short)1130531731;
				switch (num2 == num)
				{
				}
				num = (short)2100494336;
				short num3 = num;
				num = (short)109445120;
				if (num != 0)
				{
				}
				num = (short)1065287681;
				if (num != 0)
				{
				}
				return this.dataConfigDataWideMaxHeaderSizeAllowedForCompression_A36206.HiddenDynamic;
			}
			set
			{
				short num = (short)1034838256;
				short num2 = num;
				num = (short)496984304;
				switch (num2 == num)
				{
				}
				num = (short)643825664;
				short num3 = num;
				num = (short)184877057;
				if (num != 0)
				{
				}
				num = (short)1016528896;
				if (num != 0)
				{
				}
				this.dataConfigDataWideMaxHeaderSizeAllowedForCompression_A36206.HiddenDynamic = value;
			}
		}

		// Token: 0x170051B3 RID: 20915
		// (get) Token: 0x0600A303 RID: 41731 RVA: 0x009801CC File Offset: 0x0097E3CC
		public bool DataConfigDataWideMaxHeaderSizeAllowedForCompression_A36206_HasDiffs
		{
			get
			{
				short num = (short)214114381;
				short num2 = num;
				num = (short)969809997;
				switch (num2 == num)
				{
				}
				num = (short)997261312;
				short num3 = num;
				num = (short)1123221505;
				if (num != 0)
				{
				}
				num = (short)1463746560;
				if (num != 0)
				{
				}
				return this.dataConfigDataWideMaxHeaderSizeAllowedForCompression_A36206._HasDiffs;
			}
		}

		// Token: 0x170051B4 RID: 20916
		// (get) Token: 0x0600A304 RID: 41732 RVA: 0x00980280 File Offset: 0x0097E480
		public global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation RefRadioInformation
		{
			get
			{
				short num = (short)460860349;
				short num2 = num;
				num = (short)1744513981;
				switch (num2 == num)
				{
				}
				num = (short)2107899904;
				short num3 = num;
				num = (short)1433665537;
				if (num != 0)
				{
				}
				num = (short)2020605952;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation;
			}
		}

		// Token: 0x0600A305 RID: 41733 RVA: 0x0098033C File Offset: 0x0097E53C
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			int num;
			global::AcpCommonLib.IAcpRecordset result;
			short num2;
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
						return result;
					case 1:
						result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
						num2 = (short)1231093760;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
						if (base.ParentRecset != null)
						{
							num2 = (short)2074083331;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					case 3:
					{
						num2 = (short)1010895300;
						short num3 = num2;
						num2 = (short)688130500;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_4C;
						default:
						{
							num2 = (short)314834944;
							if (num2 != 0)
							{
							}
							num2 = (short)1970405376;
							short num4 = num2;
							num2 = (short)2113339396;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						}
						break;
					}
					case 4:
						if (base.ParentRecset.ContainerDoc != null)
						{
							num2 = (short)1920204801;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					}
					goto IL_24;
				}
				return result;
			}
			IL_24:
			num2 = (short)291962881;
			if (num2 != 0)
			{
			}
			result = null;
			IL_4C:
			num2 = (short)2002780162;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04004E15 RID: 19989
		private global::AcpBusinessLayer.AcpSimpleRangeField dataConfigDataWideMaxNumofNonTCPIPHCContexts_A36192;

		// Token: 0x04004E16 RID: 19990
		private global::AcpBusinessLayer.AcpSimpleRangeField dataCfgDataWideMaxSetupTimeAllowedforCCA_A36193;

		// Token: 0x04004E17 RID: 19991
		private global::AcpBusinessLayer.AcpSimpleRangeField dataConfigDataWideMaxNumofTCPIPHCContexts_A36194;

		// Token: 0x04004E18 RID: 19992
		private global::AcpBusinessLayer.AcpCustomRangeField dataCfgDataWideTimeSourceVar_A36196;

		// Token: 0x04004E19 RID: 19993
		private global::AcpBusinessLayer.AcpCustomRangeField dataConfigDataWideMaxTimeBetweenFullHeaders_A36200;

		// Token: 0x04004E1A RID: 19994
		private global::AcpBusinessLayer.AcpCustomRangeField dataConfigDataWideMaxNumOfCompreHeadersBetweenFullHeaders_A36205;

		// Token: 0x04004E1B RID: 19995
		private global::AcpBusinessLayer.AcpSimpleRangeField dataConfigDataWideMaxHeaderSizeAllowedForCompression_A36206;
	}
}
