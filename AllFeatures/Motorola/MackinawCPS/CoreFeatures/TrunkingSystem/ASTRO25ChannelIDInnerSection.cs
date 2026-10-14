using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using ConstraintHelper;
using Features.Converters;

namespace Motorola.MackinawCPS.CoreFeatures.TrunkingSystem
{
	// Token: 0x02000066 RID: 102
	[global::System.Serializable]
	public class ASTRO25ChannelIDInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06000865 RID: 2149 RVA: 0x00081B28 File Offset: 0x0007FD28
		public ASTRO25ChannelIDInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06000866 RID: 2150 RVA: 0x00081B44 File Offset: 0x0007FD44
		protected ASTRO25ChannelIDInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06000867 RID: 2151 RVA: 0x00081B5C File Offset: 0x0007FD5C
		public override void Init()
		{
			int a_ = 13;
			short num = (short)436532999;
			short num2 = num;
			num = (short)1606743815;
			switch (num2 == num)
			{
			}
			num = (short)1706098688;
			if (num != 0)
			{
			}
			num = (short)1205731328;
			short num3 = num;
			num = (short)1462960129;
			if (num != 0)
			{
			}
			this.trkSysASTRO25ChannelIDChannelType_A1390 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("髍ꋏ맑蟓꿕ꯗ鯙进諝닟귡훣폥ꯧ苩跫胭黯韱飳뿵볷맹铻鿽滿氁愃樅將猉簋欍伏匑┓┕℗⨙", a_), global::CommonResources.AcgResources.ID_CHANNELTYPE, global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.LOVs.TrkSysASTRO25ChannelIDChannelType_A1390LovStrs);
			this.trkSysASTRO25ChannelIDChannelType_A1390.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.trkSysASTRO25ChannelIDChannelType_A1390.DataTransferOrder = 49;
			this.trkSysASTRO25ChannelIDBaseFrequencyMHz_A7546 = new global::AcpBusinessLayer.AcpFrequencyField(170201250, this, global::AllFeatures.CodeplugGuid.b("髍ꋏ맑蟓꿕ꯗ鯙进諝닟귡훣폥ꯧ苩跫胭黯韱飳뿵볷룹鷻跽旿䐁瘃挅礇缉椋怍猏欑夓帕戗䔙崛⤝ᔟᘡሣ", a_), global::CommonResources.AcgResources.ID_BASEFREQUENCYMHZ, 27200000, 188000000, 1);
			this.trkSysASTRO25ChannelIDBaseFrequencyMHz_A7546.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.trkSysASTRO25ChannelIDBaseFrequencyMHz_A7546.DataTransferOrder = 13;
			this.trkSysASTRO25ChannelIDChannelSpacingkHz_A7660 = new global::AcpBusinessLayer.AcpFrequencyField(1250, this, global::AllFeatures.CodeplugGuid.b("髍ꋏ맑蟓꿕ꯗ鯙进諝닟귡훣폥ꯧ苩跫胭黯韱飳뿵볷맹铻鿽滿氁愃樅嬇稉洋洍礏簑猓紕倗怙䌛弝ᜟᐡሣᘥ", a_), global::CommonResources.AcgResources.ID_CHANNELSPACINGKHZ, 500, 25500, 1, true);
			this.trkSysASTRO25ChannelIDChannelSpacingkHz_A7660.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.trkSysASTRO25ChannelIDChannelSpacingkHz_A7660.DataTransferOrder = 20;
			this.trkSysASTRO25ChannelIDIdentifierEnable_A8222 = new global::AcpBusinessLayer.AcpFieldX<bool, bool>(true, new global::Features.Converters.UnpackAndPackAndInvertBooleanField(), this, global::AllFeatures.CodeplugGuid.b("髍ꋏ맑蟓꿕ꯗ鯙进諝닟귡훣폥ꯧ苩跫胭黯韱飳뿵볷돹飻鯽滿瘁洃怅愇漉縋䬍縏猑瘓稕紗䔙崛☝ሟအᘣ", a_), global::CommonResources.AcgResources.ID_IDENTIFIERENABLE);
			this.trkSysASTRO25ChannelIDIdentifierEnable_A8222.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.trkSysASTRO25ChannelIDIdentifierEnable_A8222.DataTransferOrder = 3;
			this.trkSysASTRO25ChannelIDTransmitOffsetMHz_A9416 = new global::AcpBusinessLayer.AcpFrequencyField(9000000, this, global::AllFeatures.CodeplugGuid.b("髍ꋏ맑蟓꿕ꯗ鯙进諝닟귡훣폥ꯧ苩跫胭黯韱飳뿵볷껹軻鿽滿焁椃漅簇䔉樋栍挏眑怓嬕倗怙䌛弝᤟ᘡᔣဥ", a_), global::CommonResources.AcgResources.ID_TRANSMITOFFSETMHZ, 0, 28000000, 1);
			this.trkSysASTRO25ChannelIDTransmitOffsetMHz_A9416.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.trkSysASTRO25ChannelIDTransmitOffsetMHz_A9416.DataTransferOrder = 76;
			this.trkSysASTRO25ChannelIDTransmitOffsetSign_A9417 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.LOVs.indexTrkSysASTRO25ChannelIDTransmitOffsetSign_A9417LovStrs, global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.LOVs.idTrkSysASTRO25ChannelIDTransmitOffsetSign_A9417LovStrs), this, global::AllFeatures.CodeplugGuid.b("髍ꋏ맑蟓꿕ꯗ鯙进諝닟귡훣폥ꯧ苩跫胭黯韱飳뿵볷껹軻鿽滿焁椃漅簇䔉樋栍挏眑怓䔕焗紙爛䄝感ᬡဣᜥἧ", a_), global::CommonResources.AcgResources.ID_TRANSMITOFFSETSIGN, global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.LOVs.TrkSysASTRO25ChannelIDTransmitOffsetSign_A9417LovStrs);
			this.trkSysASTRO25ChannelIDTransmitOffsetSign_A9417.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.trkSysASTRO25ChannelIDTransmitOffsetSign_A9417.DataTransferOrder = 77;
			this.trkSysAstro25ChannelID_A24066 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("髍ꋏ맑蟓꿕ꯗ鯙꿛ꫝ鋟跡훣폥ꯧ苩跫胭黯韱飳뿵볷ꗹ뷻쳽㓿㈁㈃々", a_), global::CommonResources.AcgResources.ID_POSITION, 100);
			this.trkSysAstro25ChannelID_A24066.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.trkSysAstro25ChannelID_A24066.DataTransferOrder = -1;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("迍菏蛑蛓駕ﻝꏟ諡藣裥蛧迩胫컭맯뛱", a_);
			base.Id = 10161;
			base.UIName = global::CommonResources.AcgResources.ID_ASTRO25CHANNELID;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06000868 RID: 2152 RVA: 0x00081E14 File Offset: 0x00080014
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 17;
			short num = (short)1300693013;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_318;
				case 1:
					this.trkSysASTRO25ChannelIDTransmitOffsetMHz_A9416 = new global::AcpBusinessLayer.AcpFrequencyField(9000000, this, global::AllFeatures.CodeplugGuid.b("蛑ꛓ뷕诗ꏙ꿛鿝돟뛡뛣ꧥ\udae7\udfe9꿫蛭釯鳱髳鏵铷돹룻꫽狿持樃甅攇按砋䄍瘏琑朓猕気圙君搝缟挡ᴣሥᤧᰩ", a_), global::CommonResources.AcgResources.ID_TRANSMITOFFSETMHZ);
					this.trkSysASTRO25ChannelIDTransmitOffsetMHz_A9416.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.trkSysASTRO25ChannelIDTransmitOffsetMHz_A9416.DataTransferOrder = 76;
					num = (short)2093809675;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蛑ꛓ뷕诗ꏙ꿛鿝돟뛡뛣ꧥ\udae7\udfe9꿫蛭釯鳱髳鏵铷돹룻볽懿焁愃䀅稇漉紋笍甏簑眓漕唗则昛䄝感ᔡᄣሥḧ", a_)))
					{
						num = (short)1128595461;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_589;
				case 3:
					if (producerFields != null)
					{
						num = (short)1601175552;
						short num3 = num;
						num = (short)2128740366;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_621;
				case 4:
					this.trkSysASTRO25ChannelIDChannelType_A1390 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("蛑ꛓ뷕诗ꏙ꿛鿝돟뛡뛣ꧥ\udae7\udfe9꿫蛭釯鳱髳鏵铷돹룻뷽棿持樃栅洇昉堋眍怏眑䬓圕⤗⤙┛⸝", a_), global::CommonResources.AcgResources.ID_CHANNELTYPE, global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.LOVs.TrkSysASTRO25ChannelIDChannelType_A1390LovStrs);
					this.trkSysASTRO25ChannelIDChannelType_A1390.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.trkSysASTRO25ChannelIDChannelType_A1390.DataTransferOrder = 49;
					num = (short)1651769350;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					this.trkSysASTRO25ChannelIDBaseFrequencyMHz_A7546 = new global::AcpBusinessLayer.AcpFrequencyField(170201250, this, global::AllFeatures.CodeplugGuid.b("蛑ꛓ뷕诗ꏙ꿛鿝돟뛡뛣ꧥ\udae7\udfe9꿫蛭釯鳱髳鏵铷돹룻볽懿焁愃䀅稇漉紋笍甏簑眓漕唗则昛䄝感ᔡᄣሥḧ", a_), global::CommonResources.AcgResources.ID_BASEFREQUENCYMHZ);
					this.trkSysASTRO25ChannelIDBaseFrequencyMHz_A7546.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.trkSysASTRO25ChannelIDBaseFrequencyMHz_A7546.DataTransferOrder = 13;
					num = (short)155648018;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					goto IL_39E;
				case 7:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蛑ꛓ뷕诗ꏙ꿛鿝鏟雡難觥\udae7\udfe9꿫蛭釯鳱髳鏵铷돹룻ꇽ䇿、〃㘅㸇㰉", a_)))
					{
						num = (short)33030156;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_621;
				case 8:
					num = (short)53739523;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					IL_61C:
					this.trkSysASTRO25ChannelIDIdentifierEnable_A8222 = new global::AcpBusinessLayer.AcpFieldX<bool, bool>(true, new global::Features.Converters.UnpackAndPackAndInvertBooleanField(), this, global::AllFeatures.CodeplugGuid.b("蛑ꛓ뷕诗ꏙ꿛鿝돟뛡뛣ꧥ\udae7\udfe9꿫蛭釯鳱髳鏵铷돹룻럽擿朁樃爅愇氉攋欍戏圑稓眕稗瘙礛䄝感ᨡᘣᐥᨧ", a_), global::CommonResources.AcgResources.ID_IDENTIFIERENABLE);
					this.trkSysASTRO25ChannelIDIdentifierEnable_A8222.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.trkSysASTRO25ChannelIDIdentifierEnable_A8222.DataTransferOrder = 3;
					num = (short)1099956248;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					num = (short)1042350081;
					if (num != 0)
					{
					}
					this.trkSysASTRO25ChannelIDChannelSpacingkHz_A7660 = new global::AcpBusinessLayer.AcpFrequencyField(1250, this, global::AllFeatures.CodeplugGuid.b("蛑ꛓ뷕诗ꏙ꿛鿝돟뛡뛣ꧥ\udae7\udfe9꿫蛭釯鳱髳鏵铷돹룻뷽棿持樃栅洇昉弋縍焏焑紓砕缗焙君搝缟挡ጣဥḧᨩ", a_), global::CommonResources.AcgResources.ID_CHANNELSPACINGKHZ, true);
					this.trkSysASTRO25ChannelIDChannelSpacingkHz_A7660.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.trkSysASTRO25ChannelIDChannelSpacingkHz_A7660.DataTransferOrder = 20;
					num = (short)473235473;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					goto IL_437;
				case 12:
					this.trkSysAstro25ChannelID_A24066 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("蛑ꛓ뷕诗ꏙ꿛鿝鏟雡難觥\udae7\udfe9꿫蛭釯鳱髳鏵铷돹룻ꇽ䇿、〃㘅㸇㰉", a_), global::CommonResources.AcgResources.ID_POSITION, 100);
					this.trkSysAstro25ChannelID_A24066.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.trkSysAstro25ChannelID_A24066.DataTransferOrder = -1;
					num = (short)493813760;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蛑ꛓ뷕诗ꏙ꿛鿝돟뛡뛣ꧥ\udae7\udfe9꿫蛭釯鳱髳鏵铷돹룻꫽狿持樃甅攇按砋䄍瘏琑朓猕気䤙甛礝丟紡攣ἥᰧᬩᬫ", a_)))
					{
						num = (short)2013593620;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3EA;
				case 14:
					num = (short)2001797142;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蛑ꛓ뷕诗ꏙ꿛鿝돟뛡뛣ꧥ\udae7\udfe9꿫蛭釯鳱髳鏵铷돹룻럽擿朁樃爅愇氉攋欍戏圑稓眕稗瘙礛䄝感ᨡᘣᐥᨧ", a_)))
					{
						num = (short)352714761;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_27B;
				case 16:
					goto IL_3EA;
				case 17:
					goto IL_5D4;
				case 18:
					goto IL_589;
				case 19:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蛑ꛓ뷕诗ꏙ꿛鿝돟뛡뛣ꧥ\udae7\udfe9꿫蛭釯鳱髳鏵铷돹룻뷽棿持樃栅洇昉弋縍焏焑紓砕缗焙君搝缟挡ጣဥḧᨩ", a_)))
					{
						num = (short)2082275338;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5D4;
				case 20:
					this.trkSysASTRO25ChannelIDTransmitOffsetSign_A9417 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.LOVs.indexTrkSysASTRO25ChannelIDTransmitOffsetSign_A9417LovStrs, global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.LOVs.idTrkSysASTRO25ChannelIDTransmitOffsetSign_A9417LovStrs), this, global::AllFeatures.CodeplugGuid.b("蛑ꛓ뷕诗ꏙ꿛鿝돟뛡뛣ꧥ\udae7\udfe9꿫蛭釯鳱髳鏵铷돹룻꫽狿持樃甅攇按砋䄍瘏琑朓猕気䤙甛礝丟紡攣ἥᰧᬩᬫ", a_), global::CommonResources.AcgResources.ID_TRANSMITOFFSETSIGN, global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.LOVs.TrkSysASTRO25ChannelIDTransmitOffsetSign_A9417LovStrs);
					this.trkSysASTRO25ChannelIDTransmitOffsetSign_A9417.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.trkSysASTRO25ChannelIDTransmitOffsetSign_A9417.DataTransferOrder = 77;
					num = (short)1721892880;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 21:
					switch (0)
					{
					case 0:
						goto IL_91;
					}
					continue;
				case 22:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蛑ꛓ뷕诗ꏙ꿛鿝돟뛡뛣ꧥ\udae7\udfe9꿫蛭釯鳱髳鏵铷돹룻뷽棿持樃栅洇昉堋眍怏眑䬓圕⤗⤙┛⸝", a_)))
					{
						num = (short)1444282372;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_39E;
				case 23:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蛑ꛓ뷕诗ꏙ꿛鿝돟뛡뛣ꧥ\udae7\udfe9꿫蛭釯鳱髳鏵铷돹룻꫽狿持樃甅攇按砋䄍瘏琑朓猕気圙君搝缟挡ᴣሥᤧᰩ", a_)))
					{
						num = (short)5111809;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_437;
				case 24:
					goto IL_27B;
				}
				IL_91:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)631570440;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_27B:
				num = (short)858718231;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_39E:
				num = (short)75300866;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3EA:
				num = (short)1036779527;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_437:
				num = (short)114340023;
				short num4 = num;
				num = (short)339194039;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_61C;
				default:
					num = (short)702152704;
					if (num != 0)
					{
					}
					num = (short)887947277;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_589:
				num = (short)884277267;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_5D4:
				num = (short)1038417935;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_318:
			IL_621:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鏑蟓苕諗闙ﳛ헟싡꟣軥觧蓩苫语鳯틱뷳답", a_);
			base.Id = 10161;
			base.UIName = global::CommonResources.AcgResources.ID_ASTRO25CHANNELID;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06000869 RID: 2153 RVA: 0x00082474 File Offset: 0x00080674
		public override void PopulateReferences()
		{
			short num = (short)872104731;
			short num2 = num;
			num = (short)1048396571;
			switch (num2 == num)
			{
			}
			num = (short)1584201728;
			if (num != 0)
			{
			}
			num = (short)116195328;
			short num3 = num;
			num = (short)1015480321;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600086A RID: 2154 RVA: 0x00082520 File Offset: 0x00080720
		public override void DropReferences()
		{
			short num = (short)1040678468;
			short num2 = num;
			num = (short)657358404;
			switch (num2 == num)
			{
			}
			num = (short)1625489408;
			if (num != 0)
			{
			}
			num = (short)1849753600;
			short num3 = num;
			num = (short)985661441;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600086B RID: 2155 RVA: 0x000825CC File Offset: 0x000807CC
		public override void SetConstraints()
		{
			short num = (short)342425936;
			short num2 = num;
			num = (short)47382864;
			switch (num2 == num)
			{
			}
			num = (short)908001281;
			if (num != 0)
			{
			}
			num = (short)1830289408;
			short num3 = num;
			num = (short)1378025472;
			if (num != 0)
			{
			}
			this.trkSysASTRO25ChannelIDChannelType_A1390.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.conAstro25andChannelIDEnableIsEnabled);
			this.trkSysASTRO25ChannelIDBaseFrequencyMHz_A7546.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.conAstro25andChannelIDEnableIsEnabled);
			this.trkSysASTRO25ChannelIDBaseFrequencyMHz_A7546.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.conBaseFrequencyValidity);
			this.trkSysASTRO25ChannelIDBaseFrequencyMHz_A7546.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConSetTrkLTEInterferenceFreqAllow);
			this.trkSysASTRO25ChannelIDChannelSpacingkHz_A7660.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.conAstro25andChannelIDEnableIsEnabled);
			this.trkSysASTRO25ChannelIDChannelSpacingkHz_A7660.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConChannelSpacingValidity);
			this.trkSysASTRO25ChannelIDChannelSpacingkHz_A7660.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConSetTrkLTEInterferenceFreqAllow);
			this.trkSysASTRO25ChannelIDIdentifierEnable_A8222.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConGrayIfTrkSysTypeIsTypeII);
			this.trkSysASTRO25ChannelIDIdentifierEnable_A8222.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConIdentifierEnableOnFirstRowMustBeEnabled);
			this.trkSysASTRO25ChannelIDIdentifierEnable_A8222.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConSetTrkLTEInterferenceFreqAllow);
			this.trkSysASTRO25ChannelIDTransmitOffsetMHz_A9416.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.conAstro25andChannelIDEnableIsEnabled);
			this.trkSysASTRO25ChannelIDTransmitOffsetMHz_A9416.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.conTransmitOffsetValidity);
			this.trkSysASTRO25ChannelIDTransmitOffsetSign_A9417.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.conAstro25andChannelIDEnableIsEnabled);
			this.trkSysAstro25ChannelID_A24066.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConGrayIfTrkSysTypeIsTypeII);
			this.trkSysAstro25ChannelID_A24066.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
		}

		// Token: 0x0600086C RID: 2156 RVA: 0x000827D4 File Offset: 0x000809D4
		public override void SetupDependencies()
		{
			short num = (short)347216473;
			short num2 = num;
			num = (short)1876630105;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2013659136;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)619773953;
			if (num != 0)
			{
			}
			num = (short)183107584;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem = base.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem;
			this.trkSysASTRO25ChannelIDIdentifierEnable_A8222.AddDependentObject(this.trkSysASTRO25ChannelIDChannelType_A1390);
			trunkingSystem.General.TrkSysGeneralSystemType_A9252.AddDependentObject(this.trkSysASTRO25ChannelIDChannelType_A1390);
			this.trkSysASTRO25ChannelIDIdentifierEnable_A8222.AddDependentObject(this.trkSysASTRO25ChannelIDBaseFrequencyMHz_A7546);
			trunkingSystem.General.TrkSysGeneralSystemType_A9252.AddDependentObject(this.trkSysASTRO25ChannelIDBaseFrequencyMHz_A7546);
			this.trkSysASTRO25ChannelIDChannelSpacingkHz_A7660.AddDependentObject(this.trkSysASTRO25ChannelIDBaseFrequencyMHz_A7546);
			this.trkSysASTRO25ChannelIDIdentifierEnable_A8222.AddDependentObject(this.trkSysASTRO25ChannelIDChannelSpacingkHz_A7660);
			trunkingSystem.General.TrkSysGeneralSystemType_A9252.AddDependentObject(this.trkSysASTRO25ChannelIDChannelSpacingkHz_A7660);
			this.trkSysASTRO25ChannelIDBaseFrequencyMHz_A7546.AddDependentObject(this.trkSysASTRO25ChannelIDChannelSpacingkHz_A7660);
			trunkingSystem.General.TrkSysGeneralSystemType_A9252.AddDependentObject(this.trkSysASTRO25ChannelIDIdentifierEnable_A8222);
			this.trkSysASTRO25ChannelIDIdentifierEnable_A8222.AddDependentObject(this.trkSysASTRO25ChannelIDTransmitOffsetMHz_A9416);
			trunkingSystem.General.TrkSysGeneralSystemType_A9252.AddDependentObject(this.trkSysASTRO25ChannelIDTransmitOffsetMHz_A9416);
			this.trkSysASTRO25ChannelIDBaseFrequencyMHz_A7546.AddDependentObject(this.trkSysASTRO25ChannelIDTransmitOffsetMHz_A9416);
			this.trkSysASTRO25ChannelIDChannelSpacingkHz_A7660.AddDependentObject(this.trkSysASTRO25ChannelIDTransmitOffsetMHz_A9416);
			this.trkSysASTRO25ChannelIDIdentifierEnable_A8222.AddDependentObject(this.trkSysASTRO25ChannelIDTransmitOffsetSign_A9417);
			trunkingSystem.General.TrkSysGeneralSystemType_A9252.AddDependentObject(this.trkSysASTRO25ChannelIDTransmitOffsetSign_A9417);
			trunkingSystem.General.TrkSysGeneralSystemType_A9252.AddDependentObject(this.trkSysAstro25ChannelID_A24066);
		}

		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x0600086D RID: 2157 RVA: 0x000829D4 File Offset: 0x00080BD4
		public bool HasDiffs
		{
			get
			{
				short num = (short)1449733572;
				short num2 = num;
				num = (short)176172484;
				switch (num2 == num)
				{
				default:
				{
					num = (short)142671872;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)373620737;
				if (num != 0)
				{
				}
				num = (short)189399040;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x0600086E RID: 2158 RVA: 0x00082A80 File Offset: 0x00080C80
		// (set) Token: 0x0600086F RID: 2159 RVA: 0x00082B38 File Offset: 0x00080D38
		public int TrkSysASTRO25ChannelIDChannelType_A1390Value
		{
			get
			{
				short num = (short)1185520016;
				short num2 = num;
				num = (short)118725008;
				switch (num2 == num)
				{
				default:
				{
					num = (short)182517760;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1641021441;
				if (num != 0)
				{
				}
				num = (short)580255744;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ChannelIDChannelType_A1390.Value;
			}
			set
			{
				short num = (short)1155887362;
				short num2 = num;
				num = (short)1799581954;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1151008768;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1237778433;
				if (num != 0)
				{
				}
				num = (short)1713111040;
				if (num != 0)
				{
				}
				this.trkSysASTRO25ChannelIDChannelType_A1390.Value = value;
			}
		}

		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x06000870 RID: 2160 RVA: 0x00082BF0 File Offset: 0x00080DF0
		// (set) Token: 0x06000871 RID: 2161 RVA: 0x00082CA8 File Offset: 0x00080EA8
		public string TrkSysASTRO25ChannelIDChannelType_A1390_UIValue
		{
			get
			{
				short num = (short)106825780;
				short num2 = num;
				num = (short)29296692;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1642004480;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1427177473;
				if (num != 0)
				{
				}
				num = (short)230096896;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ChannelIDChannelType_A1390.UIValue;
			}
			set
			{
				short num = (short)2106662648;
				short num2 = num;
				num = (short)2029199096;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1655111680;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)5701633;
				if (num != 0)
				{
				}
				num = (short)1843789824;
				if (num != 0)
				{
				}
				this.trkSysASTRO25ChannelIDChannelType_A1390.UIValue = value;
			}
		}

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x06000872 RID: 2162 RVA: 0x00082D5C File Offset: 0x00080F5C
		public global::AcpBusinessLayer.AcpListField TrkSysASTRO25ChannelIDChannelType_A1390
		{
			get
			{
				short num = (short)163133083;
				short num2 = num;
				num = (short)423376539;
				switch (num2 == num)
				{
				default:
				{
					num = (short)8585216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1599995905;
				if (num != 0)
				{
				}
				num = (short)61931520;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ChannelIDChannelType_A1390;
			}
		}

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x06000873 RID: 2163 RVA: 0x00082E10 File Offset: 0x00081010
		// (set) Token: 0x06000874 RID: 2164 RVA: 0x00082EC4 File Offset: 0x000810C4
		public bool TrkSysASTRO25ChannelIDChannelType_A1390_Applicable
		{
			get
			{
				short num = (short)1523723058;
				short num2 = num;
				num = (short)994098;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1610874880;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2140733441;
				if (num != 0)
				{
				}
				num = (short)2075852800;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ChannelIDChannelType_A1390.Applicable;
			}
			set
			{
				short num = (short)1466876113;
				short num2 = num;
				num = (short)2066202833;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1412366336;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1936261120;
				if (num != 0)
				{
				}
				num = (short)2113011713;
				if (num != 0)
				{
				}
				this.trkSysASTRO25ChannelIDChannelType_A1390.Applicable = value;
			}
		}

		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x06000875 RID: 2165 RVA: 0x00082F78 File Offset: 0x00081178
		// (set) Token: 0x06000876 RID: 2166 RVA: 0x0008302C File Offset: 0x0008122C
		public bool TrkSysASTRO25ChannelIDChannelType_A1390_Valid
		{
			get
			{
				short num = (short)1016951680;
				short num2 = num;
				num = (short)779580288;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1911357440;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1429995521;
				if (num != 0)
				{
				}
				num = (short)993722368;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ChannelIDChannelType_A1390.Valid;
			}
			set
			{
				short num = (short)1680660857;
				short num2 = num;
				num = (short)756210041;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1663959040;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1034944512;
				if (num != 0)
				{
				}
				num = (short)1774125057;
				if (num != 0)
				{
				}
				this.trkSysASTRO25ChannelIDChannelType_A1390.Valid = value;
			}
		}

		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x06000877 RID: 2167 RVA: 0x000830E4 File Offset: 0x000812E4
		// (set) Token: 0x06000878 RID: 2168 RVA: 0x0008319C File Offset: 0x0008139C
		public bool TrkSysASTRO25ChannelIDChannelType_A1390_Visible
		{
			get
			{
				short num = (short)219110970;
				short num2 = num;
				num = (short)2088132154;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1095434240;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)769064960;
				if (num != 0)
				{
				}
				num = (short)769982465;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ChannelIDChannelType_A1390.Visible;
			}
			set
			{
				short num = (short)1741887189;
				short num2 = num;
				num = (short)1585059541;
				switch (num2 == num)
				{
				default:
				{
					num = (short)474021888;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)957612032;
				if (num != 0)
				{
				}
				num = (short)1798242305;
				if (num != 0)
				{
				}
				this.trkSysASTRO25ChannelIDChannelType_A1390.Visible = value;
			}
		}

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x06000879 RID: 2169 RVA: 0x00083254 File Offset: 0x00081454
		// (set) Token: 0x0600087A RID: 2170 RVA: 0x00083304 File Offset: 0x00081504
		public bool TrkSysASTRO25ChannelIDChannelType_A1390_Editable
		{
			get
			{
				short num = (short)1978151092;
				short num2 = num;
				num = (short)1096495284;
				switch (num2 == num)
				{
				default:
				{
					num = (short)654311424;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)684720129;
				if (num != 0)
				{
				}
				num = (short)1545338880;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ChannelIDChannelType_A1390.Editable;
			}
			set
			{
				short num = (short)735574660;
				short num2 = num;
				num = (short)837417604;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1567162368;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)298254337;
				if (num != 0)
				{
				}
				num = (short)1390084096;
				if (num != 0)
				{
				}
				this.trkSysASTRO25ChannelIDChannelType_A1390.Editable = value;
			}
		}

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x0600087B RID: 2171 RVA: 0x000833B8 File Offset: 0x000815B8
		internal string TrkSysASTRO25ChannelIDChannelType_A1390_UILabel
		{
			get
			{
				short num = (short)666763265;
				if (num != 0)
				{
				}
				num = (short)1388314624;
				short num2 = num;
				num = (short)1061141133;
				short num3 = num;
				num = (short)830978701;
				switch (num3 == num)
				{
				}
				num = (short)436994048;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ChannelIDChannelType_A1390.UIName;
			}
		}

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x0600087C RID: 2172 RVA: 0x0008346C File Offset: 0x0008166C
		// (set) Token: 0x0600087D RID: 2173 RVA: 0x00083520 File Offset: 0x00081720
		internal bool TrkSysASTRO25ChannelIDChannelType_A1390_HiddenStatic
		{
			get
			{
				short num = (short)490054687;
				short num2 = num;
				num = (short)1325114399;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1081737216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2050686977;
				if (num != 0)
				{
				}
				num = (short)741277696;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ChannelIDChannelType_A1390.HiddenStatic;
			}
			set
			{
				short num = (short)761423239;
				short num2 = num;
				num = (short)1133274503;
				switch (num2 == num)
				{
				default:
				{
					num = (short)894566400;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)720502784;
				if (num != 0)
				{
				}
				num = (short)1950810113;
				if (num != 0)
				{
				}
				this.trkSysASTRO25ChannelIDChannelType_A1390.HiddenStatic = value;
			}
		}

		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x0600087E RID: 2174 RVA: 0x000835D4 File Offset: 0x000817D4
		// (set) Token: 0x0600087F RID: 2175 RVA: 0x00083688 File Offset: 0x00081888
		internal bool TrkSysASTRO25ChannelIDChannelType_A1390_HiddenDynamic
		{
			get
			{
				short num = (short)2083529774;
				short num2 = num;
				num = (short)323494958;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1516240896;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1627455488;
				if (num != 0)
				{
				}
				num = (short)1886257153;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ChannelIDChannelType_A1390.HiddenDynamic;
			}
			set
			{
				short num = (short)1812790373;
				short num2 = num;
				num = (short)1433992293;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1337065472;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1432682496;
				if (num != 0)
				{
				}
				num = (short)1727332353;
				if (num != 0)
				{
				}
				this.trkSysASTRO25ChannelIDChannelType_A1390.HiddenDynamic = value;
			}
		}

		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x06000880 RID: 2176 RVA: 0x00083740 File Offset: 0x00081940
		public bool TrkSysASTRO25ChannelIDChannelType_A1390_HasDiffs
		{
			get
			{
				short num = (short)1467958861;
				short num2 = num;
				num = (short)1704543821;
				switch (num2 == num)
				{
				default:
				{
					num = (short)651886592;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1743912960;
				if (num != 0)
				{
				}
				num = (short)1768685569;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ChannelIDChannelType_A1390._HasDiffs;
			}
		}

		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x06000881 RID: 2177 RVA: 0x000837F4 File Offset: 0x000819F4
		// (set) Token: 0x06000882 RID: 2178 RVA: 0x000838AC File Offset: 0x00081AAC
		public int TrkSysASTRO25ChannelIDBaseFrequencyMHz_A7546Value
		{
			get
			{
				short num = (short)63023582;
				short num2 = num;
				num = (short)925477342;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2023751680;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)507314177;
				if (num != 0)
				{
				}
				num = (short)660733952;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ChannelIDBaseFrequencyMHz_A7546.Value;
			}
			set
			{
				short num = (short)1738309487;
				short num2 = num;
				num = (short)1536327535;
				switch (num2 == num)
				{
				default:
				{
					num = (short)247267328;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1684340737;
				if (num != 0)
				{
				}
				num = (short)783417344;
				if (num != 0)
				{
				}
				this.trkSysASTRO25ChannelIDBaseFrequencyMHz_A7546.Value = value;
			}
		}

		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x06000883 RID: 2179 RVA: 0x00083960 File Offset: 0x00081B60
		// (set) Token: 0x06000884 RID: 2180 RVA: 0x00083A18 File Offset: 0x00081C18
		public string TrkSysASTRO25ChannelIDBaseFrequencyMHz_A7546_UIValue
		{
			get
			{
				short num = (short)1392412326;
				short num2 = num;
				num = (short)1498252966;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1970601984;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)369623041;
				if (num != 0)
				{
				}
				num = (short)937558016;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ChannelIDBaseFrequencyMHz_A7546.UIValue;
			}
			set
			{
				short num = (short)667482676;
				short num2 = num;
				num = (short)1394997812;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1279590400;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1523384321;
				if (num != 0)
				{
				}
				num = (short)782303232;
				if (num != 0)
				{
				}
				this.trkSysASTRO25ChannelIDBaseFrequencyMHz_A7546.UIValue = value;
			}
		}

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x06000885 RID: 2181 RVA: 0x00083AD0 File Offset: 0x00081CD0
		public global::AcpBusinessLayer.AcpFrequencyField TrkSysASTRO25ChannelIDBaseFrequencyMHz_A7546
		{
			get
			{
				short num = (short)812697894;
				short num2 = num;
				num = (short)1411238182;
				switch (num2 == num)
				{
				default:
				{
					num = (short)40697856;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)289865729;
				if (num != 0)
				{
				}
				num = (short)300679168;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ChannelIDBaseFrequencyMHz_A7546;
			}
		}

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x06000886 RID: 2182 RVA: 0x00083B80 File Offset: 0x00081D80
		// (set) Token: 0x06000887 RID: 2183 RVA: 0x00083C34 File Offset: 0x00081E34
		internal int TrkSysASTRO25ChannelIDBaseFrequencyMHz_A7546Min
		{
			get
			{
				short num = (short)656205066;
				short num2 = num;
				num = (short)1195631882;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1625227264;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1618149376;
				if (num != 0)
				{
				}
				num = (short)1414791169;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ChannelIDBaseFrequencyMHz_A7546.Min;
			}
			set
			{
				short num = (short)245894214;
				short num2 = num;
				num = (short)938675270;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1221263360;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)751501312;
				if (num != 0)
				{
				}
				num = (short)1527054337;
				if (num != 0)
				{
				}
				this.trkSysASTRO25ChannelIDBaseFrequencyMHz_A7546.Min = value;
			}
		}

		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x06000888 RID: 2184 RVA: 0x00083CE8 File Offset: 0x00081EE8
		// (set) Token: 0x06000889 RID: 2185 RVA: 0x00083DA0 File Offset: 0x00081FA0
		internal int TrkSysASTRO25ChannelIDBaseFrequencyMHz_A7546Max
		{
			get
			{
				short num = (short)1081802753;
				if (num != 0)
				{
				}
				num = (short)1262616576;
				short num2 = num;
				num = (short)498197648;
				short num3 = num;
				num = (short)945677456;
				switch (num3 == num)
				{
				}
				num = (short)1929445376;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ChannelIDBaseFrequencyMHz_A7546.Max;
			}
			set
			{
				short num = (short)945326021;
				short num2 = num;
				num = (short)2020771781;
				switch (num2 == num)
				{
				default:
				{
					num = (short)231604224;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)856162305;
				if (num != 0)
				{
				}
				num = (short)949288960;
				if (num != 0)
				{
				}
				this.trkSysASTRO25ChannelIDBaseFrequencyMHz_A7546.Max = value;
			}
		}

		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x0600088A RID: 2186 RVA: 0x00083E54 File Offset: 0x00082054
		// (set) Token: 0x0600088B RID: 2187 RVA: 0x00083F08 File Offset: 0x00082108
		internal int TrkSysASTRO25ChannelIDBaseFrequencyMHz_A7546Step
		{
			get
			{
				short num = (short)2109072872;
				short num2 = num;
				num = (short)1601299944;
				switch (num2 == num)
				{
				default:
				{
					num = (short)71172096;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1445527553;
				if (num != 0)
				{
				}
				num = (short)339410944;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ChannelIDBaseFrequencyMHz_A7546.StepSize;
			}
			set
			{
				short num = (short)1769604458;
				short num2 = num;
				num = (short)97846634;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1098645504;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1291976705;
				if (num != 0)
				{
				}
				num = (short)992280576;
				if (num != 0)
				{
				}
				this.trkSysASTRO25ChannelIDBaseFrequencyMHz_A7546.StepSize = value;
			}
		}

		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x0600088C RID: 2188 RVA: 0x00083FC0 File Offset: 0x000821C0
		// (set) Token: 0x0600088D RID: 2189 RVA: 0x00084074 File Offset: 0x00082274
		public bool TrkSysASTRO25ChannelIDBaseFrequencyMHz_A7546_Applicable
		{
			get
			{
				short num = (short)808714241;
				if (num != 0)
				{
				}
				num = (short)908918784;
				short num2 = num;
				num = (short)502311904;
				short num3 = num;
				num = (short)1979034592;
				switch (num3 == num)
				{
				}
				num = (short)999555072;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ChannelIDBaseFrequencyMHz_A7546.Applicable;
			}
			set
			{
				short num = (short)1788626801;
				short num2 = num;
				num = (short)1531922289;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1930166272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2009858048;
				if (num != 0)
				{
				}
				num = (short)2089156609;
				if (num != 0)
				{
				}
				this.trkSysASTRO25ChannelIDBaseFrequencyMHz_A7546.Applicable = value;
			}
		}

		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x0600088E RID: 2190 RVA: 0x0008412C File Offset: 0x0008232C
		// (set) Token: 0x0600088F RID: 2191 RVA: 0x000841E4 File Offset: 0x000823E4
		public bool TrkSysASTRO25ChannelIDBaseFrequencyMHz_A7546_Valid
		{
			get
			{
				short num = (short)1589457910;
				short num2 = num;
				num = (short)691745782;
				switch (num2 == num)
				{
				default:
				{
					num = (short)332660736;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1803681793;
				if (num != 0)
				{
				}
				num = (short)1114963968;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ChannelIDBaseFrequencyMHz_A7546.Valid;
			}
			set
			{
				short num = (short)1914647138;
				short num2 = num;
				num = (short)1546531426;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1189150720;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1592918017;
				if (num != 0)
				{
				}
				num = (short)1936326656;
				if (num != 0)
				{
				}
				this.trkSysASTRO25ChannelIDBaseFrequencyMHz_A7546.Valid = value;
			}
		}

		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x06000890 RID: 2192 RVA: 0x00084298 File Offset: 0x00082498
		// (set) Token: 0x06000891 RID: 2193 RVA: 0x00084350 File Offset: 0x00082550
		public bool TrkSysASTRO25ChannelIDBaseFrequencyMHz_A7546_Visible
		{
			get
			{
				short num = (short)1047711857;
				short num2 = num;
				num = (short)1749012593;
				switch (num2 == num)
				{
				default:
				{
					num = (short)736362496;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1660485633;
				if (num != 0)
				{
				}
				num = (short)1111228416;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ChannelIDBaseFrequencyMHz_A7546.Visible;
			}
			set
			{
				short num = (short)741705192;
				short num2 = num;
				num = (short)11306472;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1544224768;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1352531969;
				if (num != 0)
				{
				}
				num = (short)1386151936;
				if (num != 0)
				{
				}
				this.trkSysASTRO25ChannelIDBaseFrequencyMHz_A7546.Visible = value;
			}
		}

		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x06000892 RID: 2194 RVA: 0x00084408 File Offset: 0x00082608
		// (set) Token: 0x06000893 RID: 2195 RVA: 0x000844BC File Offset: 0x000826BC
		public bool TrkSysASTRO25ChannelIDBaseFrequencyMHz_A7546_Editable
		{
			get
			{
				short num = (short)949323189;
				short num2 = num;
				num = (short)303138229;
				switch (num2 == num)
				{
				default:
				{
					num = (short)604831744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2049310720;
				if (num != 0)
				{
				}
				num = (short)1212547073;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ChannelIDBaseFrequencyMHz_A7546.Editable;
			}
			set
			{
				short num = (short)1445527552;
				short num2 = num;
				num = (short)894473559;
				short num3 = num;
				num = (short)657626455;
				switch (num3 == num)
				{
				}
				num = (short)1429929985;
				if (num != 0)
				{
				}
				num = (short)341442560;
				if (num != 0)
				{
				}
				this.trkSysASTRO25ChannelIDBaseFrequencyMHz_A7546.Editable = value;
			}
		}

		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x06000894 RID: 2196 RVA: 0x00084574 File Offset: 0x00082774
		internal string TrkSysASTRO25ChannelIDBaseFrequencyMHz_A7546_UILabel
		{
			get
			{
				short num = (short)2088894464;
				short num2 = num;
				num = (short)768625625;
				short num3 = num;
				num = (short)958942169;
				switch (num3 == num)
				{
				}
				num = (short)1163264001;
				if (num != 0)
				{
				}
				num = (short)413007872;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ChannelIDBaseFrequencyMHz_A7546.UIName;
			}
		}

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x06000895 RID: 2197 RVA: 0x0008462C File Offset: 0x0008282C
		// (set) Token: 0x06000896 RID: 2198 RVA: 0x000846DC File Offset: 0x000828DC
		internal bool TrkSysASTRO25ChannelIDBaseFrequencyMHz_A7546_HiddenStatic
		{
			get
			{
				short num = (short)168230912;
				short num2 = num;
				num = (short)1898779278;
				short num3 = num;
				num = (short)1938231950;
				switch (num3 == num)
				{
				}
				num = (short)497811457;
				if (num != 0)
				{
				}
				num = (short)1084358656;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ChannelIDBaseFrequencyMHz_A7546.HiddenStatic;
			}
			set
			{
				short num = (short)1362362368;
				short num2 = num;
				num = (short)115812277;
				short num3 = num;
				num = (short)638724021;
				switch (num3 == num)
				{
				}
				num = (short)1149435904;
				if (num != 0)
				{
				}
				num = (short)2001207297;
				if (num != 0)
				{
				}
				this.trkSysASTRO25ChannelIDBaseFrequencyMHz_A7546.HiddenStatic = value;
			}
		}

		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x06000897 RID: 2199 RVA: 0x00084794 File Offset: 0x00082994
		// (set) Token: 0x06000898 RID: 2200 RVA: 0x00084848 File Offset: 0x00082A48
		internal bool TrkSysASTRO25ChannelIDBaseFrequencyMHz_A7546_HiddenDynamic
		{
			get
			{
				short num = (short)1424818176;
				short num2 = num;
				num = (short)1156925208;
				short num3 = num;
				num = (short)695224088;
				switch (num3 == num)
				{
				}
				num = (short)1198129152;
				if (num != 0)
				{
				}
				num = (short)1937506305;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ChannelIDBaseFrequencyMHz_A7546.HiddenDynamic;
			}
			set
			{
				short num = (short)516227072;
				short num2 = num;
				num = (short)1655222862;
				short num3 = num;
				num = (short)614576718;
				switch (num3 == num)
				{
				}
				num = (short)132317185;
				if (num != 0)
				{
				}
				num = (short)83689472;
				if (num != 0)
				{
				}
				this.trkSysASTRO25ChannelIDBaseFrequencyMHz_A7546.HiddenDynamic = value;
			}
		}

		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x06000899 RID: 2201 RVA: 0x000848FC File Offset: 0x00082AFC
		public bool TrkSysASTRO25ChannelIDBaseFrequencyMHz_A7546_HasDiffs
		{
			get
			{
				short num = (short)156499968;
				short num2 = num;
				num = (short)275828527;
				short num3 = num;
				num = (short)1196937007;
				switch (num3 == num)
				{
				}
				num = (short)1225654272;
				if (num != 0)
				{
				}
				num = (short)597295105;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ChannelIDBaseFrequencyMHz_A7546._HasDiffs;
			}
		}

		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x0600089A RID: 2202 RVA: 0x000849B0 File Offset: 0x00082BB0
		// (set) Token: 0x0600089B RID: 2203 RVA: 0x00084A64 File Offset: 0x00082C64
		public int TrkSysASTRO25ChannelIDChannelSpacingkHz_A7660Value
		{
			get
			{
				short num = (short)639500288;
				short num2 = num;
				num = (short)549204322;
				short num3 = num;
				num = (short)1448882530;
				switch (num3 == num)
				{
				}
				num = (short)106037248;
				if (num != 0)
				{
				}
				num = (short)1991442433;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ChannelIDChannelSpacingkHz_A7660.Value;
			}
			set
			{
				short num = (short)651821056;
				short num2 = num;
				num = (short)164267654;
				short num3 = num;
				num = (short)974292614;
				switch (num3 == num)
				{
				}
				num = (short)53608448;
				if (num != 0)
				{
				}
				num = (short)83558401;
				if (num != 0)
				{
				}
				this.trkSysASTRO25ChannelIDChannelSpacingkHz_A7660.Value = value;
			}
		}

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x0600089C RID: 2204 RVA: 0x00084B18 File Offset: 0x00082D18
		// (set) Token: 0x0600089D RID: 2205 RVA: 0x00084BD0 File Offset: 0x00082DD0
		public string TrkSysASTRO25ChannelIDChannelSpacingkHz_A7660_UIValue
		{
			get
			{
				short num = (short)952893440;
				short num2 = num;
				num = (short)1827233307;
				short num3 = num;
				num = (short)1843944987;
				switch (num3 == num)
				{
				}
				num = (short)523239425;
				if (num != 0)
				{
				}
				num = (short)1052639232;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ChannelIDChannelSpacingkHz_A7660.UIValue;
			}
			set
			{
				short num = (short)1958084608;
				short num2 = num;
				num = (short)202435787;
				short num3 = num;
				num = (short)833285323;
				switch (num3 == num)
				{
				}
				num = (short)1333329920;
				if (num != 0)
				{
				}
				num = (short)2424833;
				if (num != 0)
				{
				}
				this.trkSysASTRO25ChannelIDChannelSpacingkHz_A7660.UIValue = value;
			}
		}

		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x0600089E RID: 2206 RVA: 0x00084C84 File Offset: 0x00082E84
		public global::AcpBusinessLayer.AcpFrequencyField TrkSysASTRO25ChannelIDChannelSpacingkHz_A7660
		{
			get
			{
				short num = (short)24772608;
				short num2 = num;
				num = (short)1765364456;
				short num3 = num;
				num = (short)1635078888;
				switch (num3 == num)
				{
				}
				num = (short)1969291265;
				if (num != 0)
				{
				}
				num = (short)67174400;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ChannelIDChannelSpacingkHz_A7660;
			}
		}

		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x0600089F RID: 2207 RVA: 0x00084D34 File Offset: 0x00082F34
		// (set) Token: 0x060008A0 RID: 2208 RVA: 0x00084DE4 File Offset: 0x00082FE4
		internal int TrkSysASTRO25ChannelIDChannelSpacingkHz_A7660Min
		{
			get
			{
				short num = (short)1472593920;
				short num2 = num;
				num = (short)473975599;
				short num3 = num;
				num = (short)1435781935;
				switch (num3 == num)
				{
				}
				num = (short)814219265;
				if (num != 0)
				{
				}
				num = (short)351141888;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ChannelIDChannelSpacingkHz_A7660.Min;
			}
			set
			{
				short num = (short)1052508160;
				short num2 = num;
				num = (short)1097932524;
				short num3 = num;
				num = (short)2059804396;
				switch (num3 == num)
				{
				}
				num = (short)67567616;
				if (num != 0)
				{
				}
				num = (short)1531117569;
				if (num != 0)
				{
				}
				this.trkSysASTRO25ChannelIDChannelSpacingkHz_A7660.Min = value;
			}
		}

		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x060008A1 RID: 2209 RVA: 0x00084E9C File Offset: 0x0008309C
		// (set) Token: 0x060008A2 RID: 2210 RVA: 0x00084F50 File Offset: 0x00083150
		internal int TrkSysASTRO25ChannelIDChannelSpacingkHz_A7660Max
		{
			get
			{
				short num = (short)1189085184;
				short num2 = num;
				num = (short)1826456031;
				short num3 = num;
				num = (short)1498317279;
				switch (num3 == num)
				{
				}
				num = (short)1337393152;
				if (num != 0)
				{
				}
				num = (short)390594561;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ChannelIDChannelSpacingkHz_A7660.Max;
			}
			set
			{
				short num = (short)381943808;
				short num2 = num;
				num = (short)862305026;
				short num3 = num;
				num = (short)1586215682;
				switch (num3 == num)
				{
				}
				num = (short)364773377;
				if (num != 0)
				{
				}
				num = (short)1600913408;
				if (num != 0)
				{
				}
				this.trkSysASTRO25ChannelIDChannelSpacingkHz_A7660.Max = value;
			}
		}

		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x060008A3 RID: 2211 RVA: 0x00085004 File Offset: 0x00083204
		// (set) Token: 0x060008A4 RID: 2212 RVA: 0x000850BC File Offset: 0x000832BC
		internal int TrkSysASTRO25ChannelIDChannelSpacingkHz_A7660Step
		{
			get
			{
				short num = (short)2045181952;
				short num2 = num;
				num = (short)1104441466;
				short num3 = num;
				num = (short)1137275002;
				switch (num3 == num)
				{
				}
				num = (short)1964179457;
				if (num != 0)
				{
				}
				num = (short)121110528;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ChannelIDChannelSpacingkHz_A7660.StepSize;
			}
			set
			{
				short num = (short)1176895488;
				short num2 = num;
				num = (short)140160596;
				short num3 = num;
				num = (short)1939582548;
				switch (num3 == num)
				{
				}
				num = (short)291241985;
				if (num != 0)
				{
				}
				num = (short)638779392;
				if (num != 0)
				{
				}
				this.trkSysASTRO25ChannelIDChannelSpacingkHz_A7660.StepSize = value;
			}
		}

		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x060008A5 RID: 2213 RVA: 0x00085170 File Offset: 0x00083370
		// (set) Token: 0x060008A6 RID: 2214 RVA: 0x00085224 File Offset: 0x00083424
		public bool TrkSysASTRO25ChannelIDChannelSpacingkHz_A7660_Applicable
		{
			get
			{
				short num = (short)326893568;
				short num2 = num;
				num = (short)221446145;
				if (num != 0)
				{
				}
				num = (short)574821098;
				short num3 = num;
				num = (short)2065175274;
				switch (num3 == num)
				{
				}
				num = (short)1732968448;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ChannelIDChannelSpacingkHz_A7660.Applicable;
			}
			set
			{
				short num = (short)368312320;
				short num2 = num;
				num = (short)776732673;
				if (num != 0)
				{
				}
				num = (short)1819965133;
				short num3 = num;
				num = (short)1325233869;
				switch (num3 == num)
				{
				}
				num = (short)1823145984;
				if (num != 0)
				{
				}
				this.trkSysASTRO25ChannelIDChannelSpacingkHz_A7660.Applicable = value;
			}
		}

		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x060008A7 RID: 2215 RVA: 0x000852D8 File Offset: 0x000834D8
		// (set) Token: 0x060008A8 RID: 2216 RVA: 0x00085390 File Offset: 0x00083590
		public bool TrkSysASTRO25ChannelIDChannelSpacingkHz_A7660_Valid
		{
			get
			{
				short num = (short)790822912;
				short num2 = num;
				num = (short)283524877;
				short num3 = num;
				num = (short)1610563341;
				switch (num3 == num)
				{
				}
				num = (short)752943104;
				if (num != 0)
				{
				}
				num = (short)1518862337;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ChannelIDChannelSpacingkHz_A7660.Valid;
			}
			set
			{
				short num = (short)616169472;
				short num2 = num;
				num = (short)1201289710;
				short num3 = num;
				num = (short)234895854;
				switch (num3 == num)
				{
				}
				num = (short)712638465;
				if (num != 0)
				{
				}
				num = (short)2113863680;
				if (num != 0)
				{
				}
				this.trkSysASTRO25ChannelIDChannelSpacingkHz_A7660.Valid = value;
			}
		}

		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x060008A9 RID: 2217 RVA: 0x0008544C File Offset: 0x0008364C
		// (set) Token: 0x060008AA RID: 2218 RVA: 0x00085500 File Offset: 0x00083700
		public bool TrkSysASTRO25ChannelIDChannelSpacingkHz_A7660_Visible
		{
			get
			{
				short num = (short)1442840576;
				short num2 = num;
				num = (short)1511729749;
				short num3 = num;
				num = (short)1038756437;
				switch (num3 == num)
				{
				}
				num = (short)1774649345;
				if (num != 0)
				{
				}
				num = (short)1667039232;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ChannelIDChannelSpacingkHz_A7660.Visible;
			}
			set
			{
				short num = (short)2034302976;
				short num2 = num;
				num = (short)735463073;
				short num3 = num;
				num = (short)1683441313;
				switch (num3 == num)
				{
				}
				num = (short)1634271233;
				if (num != 0)
				{
				}
				num = (short)2053832704;
				if (num != 0)
				{
				}
				this.trkSysASTRO25ChannelIDChannelSpacingkHz_A7660.Visible = value;
			}
		}

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x060008AB RID: 2219 RVA: 0x000855B8 File Offset: 0x000837B8
		// (set) Token: 0x060008AC RID: 2220 RVA: 0x0008566C File Offset: 0x0008386C
		public bool TrkSysASTRO25ChannelIDChannelSpacingkHz_A7660_Editable
		{
			get
			{
				short num = (short)1603862528;
				short num2 = num;
				num = (short)1434597644;
				short num3 = num;
				num = (short)668350732;
				switch (num3 == num)
				{
				}
				num = (short)1126301697;
				if (num != 0)
				{
				}
				num = (short)1413742592;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ChannelIDChannelSpacingkHz_A7660.Editable;
			}
			set
			{
				short num = (short)854523904;
				short num2 = num;
				num = (short)1939508631;
				short num3 = num;
				num = (short)352619927;
				switch (num3 == num)
				{
				}
				num = (short)1657995264;
				if (num != 0)
				{
				}
				num = (short)1314324481;
				if (num != 0)
				{
				}
				this.trkSysASTRO25ChannelIDChannelSpacingkHz_A7660.Editable = value;
			}
		}

		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x060008AD RID: 2221 RVA: 0x00085724 File Offset: 0x00083924
		internal string TrkSysASTRO25ChannelIDChannelSpacingkHz_A7660_UILabel
		{
			get
			{
				short num = (short)439615488;
				short num2 = num;
				num = (short)467391503;
				short num3 = num;
				num = (short)447599631;
				switch (num3 == num)
				{
				}
				num = (short)294191105;
				if (num != 0)
				{
				}
				num = (short)490340352;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ChannelIDChannelSpacingkHz_A7660.UIName;
			}
		}

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x060008AE RID: 2222 RVA: 0x000857D8 File Offset: 0x000839D8
		// (set) Token: 0x060008AF RID: 2223 RVA: 0x0008588C File Offset: 0x00083A8C
		internal bool TrkSysASTRO25ChannelIDChannelSpacingkHz_A7660_HiddenStatic
		{
			get
			{
				short num = (short)1121845248;
				short num2 = num;
				num = (short)468365914;
				short num3 = num;
				num = (short)101298778;
				switch (num3 == num)
				{
				}
				num = (short)202178560;
				if (num != 0)
				{
				}
				num = (short)1809645569;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ChannelIDChannelSpacingkHz_A7660.HiddenStatic;
			}
			set
			{
				short num = (short)1972109312;
				short num2 = num;
				num = (short)1222246401;
				if (num != 0)
				{
				}
				num = (short)1670238052;
				short num3 = num;
				num = (short)383438692;
				switch (num3 == num)
				{
				}
				num = (short)1302134784;
				if (num != 0)
				{
				}
				this.trkSysASTRO25ChannelIDChannelSpacingkHz_A7660.HiddenStatic = value;
			}
		}

		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x060008B0 RID: 2224 RVA: 0x00085940 File Offset: 0x00083B40
		// (set) Token: 0x060008B1 RID: 2225 RVA: 0x000859F4 File Offset: 0x00083BF4
		internal bool TrkSysASTRO25ChannelIDChannelSpacingkHz_A7660_HiddenDynamic
		{
			get
			{
				short num = (short)1944256512;
				short num2 = num;
				num = (short)636550334;
				short num3 = num;
				num = (short)1201798334;
				switch (num3 == num)
				{
				}
				num = (short)2087124992;
				if (num != 0)
				{
				}
				num = (short)792002561;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ChannelIDChannelSpacingkHz_A7660.HiddenDynamic;
			}
			set
			{
				short num = (short)2049703936;
				short num2 = num;
				num = (short)110151713;
				short num3 = num;
				num = (short)1577961505;
				switch (num3 == num)
				{
				}
				num = (short)1293352960;
				if (num != 0)
				{
				}
				num = (short)2009006081;
				if (num != 0)
				{
				}
				this.trkSysASTRO25ChannelIDChannelSpacingkHz_A7660.HiddenDynamic = value;
			}
		}

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x060008B2 RID: 2226 RVA: 0x00085AA8 File Offset: 0x00083CA8
		public bool TrkSysASTRO25ChannelIDChannelSpacingkHz_A7660_HasDiffs
		{
			get
			{
				short num = (short)806944768;
				short num2 = num;
				num = (short)46787100;
				short num3 = num;
				num = (short)555936284;
				switch (num3 == num)
				{
				}
				num = (short)976748545;
				if (num != 0)
				{
				}
				num = (short)1346437120;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ChannelIDChannelSpacingkHz_A7660._HasDiffs;
			}
		}

		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x060008B3 RID: 2227 RVA: 0x00085B5C File Offset: 0x00083D5C
		// (set) Token: 0x060008B4 RID: 2228 RVA: 0x00085C10 File Offset: 0x00083E10
		public bool TrkSysASTRO25ChannelIDIdentifierEnable_A8222Value
		{
			get
			{
				short num = (short)664928256;
				short num2 = num;
				num = (short)303373878;
				short num3 = num;
				num = (short)469507638;
				switch (num3 == num)
				{
				}
				num = (short)652345344;
				if (num != 0)
				{
				}
				num = (short)1035993089;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ChannelIDIdentifierEnable_A8222.Value;
			}
			set
			{
				short num = (short)60162048;
				short num2 = num;
				num = (short)654827473;
				short num3 = num;
				num = (short)65265617;
				switch (num3 == num)
				{
				}
				num = (short)510197760;
				if (num != 0)
				{
				}
				num = (short)1822556161;
				if (num != 0)
				{
				}
				this.trkSysASTRO25ChannelIDIdentifierEnable_A8222.Value = value;
			}
		}

		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x060008B5 RID: 2229 RVA: 0x00085CC4 File Offset: 0x00083EC4
		public global::AcpBusinessLayer.AcpFieldX<bool, bool> TrkSysASTRO25ChannelIDIdentifierEnable_A8222
		{
			get
			{
				short num = (short)167051264;
				short num2 = num;
				num = (short)1794084567;
				short num3 = num;
				num = (short)629247703;
				switch (num3 == num)
				{
				}
				num = (short)1482817537;
				if (num != 0)
				{
				}
				num = (short)603652096;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ChannelIDIdentifierEnable_A8222;
			}
		}

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x060008B6 RID: 2230 RVA: 0x00085D74 File Offset: 0x00083F74
		// (set) Token: 0x060008B7 RID: 2231 RVA: 0x00085E28 File Offset: 0x00084028
		public bool TrkSysASTRO25ChannelIDIdentifierEnable_A8222_UIValue
		{
			get
			{
				short num = (short)1076953088;
				short num2 = num;
				num = (short)719696011;
				short num3 = num;
				num = (short)573223051;
				switch (num3 == num)
				{
				}
				num = (short)764280833;
				if (num != 0)
				{
				}
				num = (short)1260847104;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ChannelIDIdentifierEnable_A8222.UIValue;
			}
			set
			{
				short num = (short)196476928;
				short num2 = num;
				num = (short)722875326;
				short num3 = num;
				num = (short)444281790;
				switch (num3 == num)
				{
				}
				num = (short)1614479361;
				if (num != 0)
				{
				}
				num = (short)289472512;
				if (num != 0)
				{
				}
				this.trkSysASTRO25ChannelIDIdentifierEnable_A8222.UIValue = value;
			}
		}

		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x060008B8 RID: 2232 RVA: 0x00085EDC File Offset: 0x000840DC
		// (set) Token: 0x060008B9 RID: 2233 RVA: 0x00085F90 File Offset: 0x00084190
		public bool TrkSysASTRO25ChannelIDIdentifierEnable_A8222_Applicable
		{
			get
			{
				short num = (short)1068302336;
				short num2 = num;
				num = (short)302154281;
				short num3 = num;
				num = (short)283476521;
				switch (num3 == num)
				{
				}
				num = (short)359530496;
				if (num != 0)
				{
				}
				num = (short)1032912897;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ChannelIDIdentifierEnable_A8222.Applicable;
			}
			set
			{
				short num = (short)129695744;
				short num2 = num;
				num = (short)1010120791;
				short num3 = num;
				num = (short)1277376599;
				switch (num3 == num)
				{
				}
				num = (short)665387009;
				if (num != 0)
				{
				}
				num = (short)2079260672;
				if (num != 0)
				{
				}
				this.trkSysASTRO25ChannelIDIdentifierEnable_A8222.Applicable = value;
			}
		}

		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x060008BA RID: 2234 RVA: 0x00086044 File Offset: 0x00084244
		// (set) Token: 0x060008BB RID: 2235 RVA: 0x000860FC File Offset: 0x000842FC
		public bool TrkSysASTRO25ChannelIDIdentifierEnable_A8222_Valid
		{
			get
			{
				short num = (short)1524826112;
				short num2 = num;
				num = (short)1215747159;
				short num3 = num;
				num = (short)1659556951;
				switch (num3 == num)
				{
				}
				num = (short)1664352256;
				if (num != 0)
				{
				}
				num = (short)935329793;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ChannelIDIdentifierEnable_A8222.Valid;
			}
			set
			{
				short num = (short)1477443584;
				short num2 = num;
				num = (short)848702213;
				short num3 = num;
				num = (short)726412037;
				switch (num3 == num)
				{
				}
				num = (short)884801537;
				if (num != 0)
				{
				}
				num = (short)115277824;
				if (num != 0)
				{
				}
				this.trkSysASTRO25ChannelIDIdentifierEnable_A8222.Valid = value;
			}
		}

		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x060008BC RID: 2236 RVA: 0x000861B4 File Offset: 0x000843B4
		// (set) Token: 0x060008BD RID: 2237 RVA: 0x0008626C File Offset: 0x0008446C
		public bool TrkSysASTRO25ChannelIDIdentifierEnable_A8222_Visible
		{
			get
			{
				short num = (short)60358656;
				short num2 = num;
				num = (short)1108645828;
				short num3 = num;
				num = (short)447715268;
				switch (num3 == num)
				{
				}
				num = (short)760807425;
				if (num != 0)
				{
				}
				num = (short)837681152;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ChannelIDIdentifierEnable_A8222.Visible;
			}
			set
			{
				short num = (short)1640955904;
				short num2 = num;
				num = (short)847577089;
				if (num != 0)
				{
				}
				num = (short)2130599555;
				short num3 = num;
				num = (short)1298882179;
				switch (num3 == num)
				{
				}
				num = (short)217907200;
				if (num != 0)
				{
				}
				this.trkSysASTRO25ChannelIDIdentifierEnable_A8222.Visible = value;
			}
		}

		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x060008BE RID: 2238 RVA: 0x00086324 File Offset: 0x00084524
		// (set) Token: 0x060008BF RID: 2239 RVA: 0x000863D4 File Offset: 0x000845D4
		public bool TrkSysASTRO25ChannelIDIdentifierEnable_A8222_Editable
		{
			get
			{
				short num = (short)1233911808;
				short num2 = num;
				num = (short)1598533162;
				short num3 = num;
				num = (short)447131178;
				switch (num3 == num)
				{
				}
				num = (short)670695425;
				if (num != 0)
				{
				}
				num = (short)91750400;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ChannelIDIdentifierEnable_A8222.Editable;
			}
			set
			{
				short num = (short)916324352;
				short num2 = num;
				num = (short)1378091009;
				if (num != 0)
				{
				}
				num = (short)1750136773;
				short num3 = num;
				num = (short)468973509;
				switch (num3 == num)
				{
				}
				num = (short)603848704;
				if (num != 0)
				{
				}
				this.trkSysASTRO25ChannelIDIdentifierEnable_A8222.Editable = value;
			}
		}

		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x060008C0 RID: 2240 RVA: 0x00086488 File Offset: 0x00084688
		internal string TrkSysASTRO25ChannelIDIdentifierEnable_A8222_UILabel
		{
			get
			{
				short num = (short)1367867392;
				short num2 = num;
				num = (short)1127691484;
				short num3 = num;
				num = (short)1908946140;
				switch (num3 == num)
				{
				}
				num = (short)524288000;
				if (num != 0)
				{
				}
				num = (short)1332084737;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ChannelIDIdentifierEnable_A8222.UIName;
			}
		}

		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x060008C1 RID: 2241 RVA: 0x0008653C File Offset: 0x0008473C
		// (set) Token: 0x060008C2 RID: 2242 RVA: 0x000865EC File Offset: 0x000847EC
		internal bool TrkSysASTRO25ChannelIDIdentifierEnable_A8222_HiddenStatic
		{
			get
			{
				short num = (short)1311703040;
				short num2 = num;
				num = (short)2119801529;
				short num3 = num;
				num = (short)343448249;
				switch (num3 == num)
				{
				}
				num = (short)581435392;
				if (num != 0)
				{
				}
				num = (short)231538689;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ChannelIDIdentifierEnable_A8222.HiddenStatic;
			}
			set
			{
				short num = (short)384892928;
				short num2 = num;
				num = (short)1514137213;
				short num3 = num;
				num = (short)182445693;
				switch (num3 == num)
				{
				}
				num = (short)2055143425;
				if (num != 0)
				{
				}
				num = (short)1019740160;
				if (num != 0)
				{
				}
				this.trkSysASTRO25ChannelIDIdentifierEnable_A8222.HiddenStatic = value;
			}
		}

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x060008C3 RID: 2243 RVA: 0x000866A0 File Offset: 0x000848A0
		// (set) Token: 0x060008C4 RID: 2244 RVA: 0x00086758 File Offset: 0x00084958
		internal bool TrkSysASTRO25ChannelIDIdentifierEnable_A8222_HiddenDynamic
		{
			get
			{
				short num = (short)1337917440;
				short num2 = num;
				num = (short)217524736;
				short num3 = num;
				num = (short)1233005056;
				switch (num3 == num)
				{
				}
				num = (short)1413021697;
				if (num != 0)
				{
				}
				num = (short)1161232384;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ChannelIDIdentifierEnable_A8222.HiddenDynamic;
			}
			set
			{
				short num = (short)1333329920;
				short num2 = num;
				num = (short)128027758;
				short num3 = num;
				num = (short)1176800366;
				switch (num3 == num)
				{
				}
				num = (short)583794689;
				if (num != 0)
				{
				}
				num = (short)130154496;
				if (num != 0)
				{
				}
				this.trkSysASTRO25ChannelIDIdentifierEnable_A8222.HiddenDynamic = value;
			}
		}

		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x060008C5 RID: 2245 RVA: 0x0008680C File Offset: 0x00084A0C
		public bool TrkSysASTRO25ChannelIDIdentifierEnable_A8222_HasDiffs
		{
			get
			{
				short num = (short)2129133568;
				short num2 = num;
				num = (short)225624955;
				short num3 = num;
				num = (short)726713211;
				switch (num3 == num)
				{
				}
				num = (short)1239023616;
				if (num != 0)
				{
				}
				num = (short)1069088769;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ChannelIDIdentifierEnable_A8222._HasDiffs;
			}
		}

		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x060008C6 RID: 2246 RVA: 0x000868C0 File Offset: 0x00084AC0
		// (set) Token: 0x060008C7 RID: 2247 RVA: 0x00086974 File Offset: 0x00084B74
		public int TrkSysASTRO25ChannelIDTransmitOffsetMHz_A9416Value
		{
			get
			{
				short num = (short)547946496;
				short num2 = num;
				num = (short)61538305;
				if (num != 0)
				{
				}
				num = (short)999195662;
				short num3 = num;
				num = (short)1549239310;
				switch (num3 == num)
				{
				}
				num = (short)1740963840;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ChannelIDTransmitOffsetMHz_A9416.Value;
			}
			set
			{
				short num = (short)550109184;
				short num2 = num;
				num = (short)1372372359;
				short num3 = num;
				num = (short)1051508103;
				switch (num3 == num)
				{
				}
				num = (short)187695105;
				if (num != 0)
				{
				}
				num = (short)1259667456;
				if (num != 0)
				{
				}
				this.trkSysASTRO25ChannelIDTransmitOffsetMHz_A9416.Value = value;
			}
		}

		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x060008C8 RID: 2248 RVA: 0x00086A28 File Offset: 0x00084C28
		// (set) Token: 0x060008C9 RID: 2249 RVA: 0x00086ADC File Offset: 0x00084CDC
		public string TrkSysASTRO25ChannelIDTransmitOffsetMHz_A9416_UIValue
		{
			get
			{
				short num = (short)404750336;
				short num2 = num;
				num = (short)1604194074;
				short num3 = num;
				num = (short)1296174874;
				switch (num3 == num)
				{
				}
				num = (short)642187265;
				if (num != 0)
				{
				}
				num = (short)1392705536;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ChannelIDTransmitOffsetMHz_A9416.UIValue;
			}
			set
			{
				short num = (short)1647575040;
				short num2 = num;
				num = (short)852444839;
				short num3 = num;
				num = (short)1437681319;
				switch (num3 == num)
				{
				}
				num = (short)331022336;
				if (num != 0)
				{
				}
				num = (short)526581761;
				if (num != 0)
				{
				}
				this.trkSysASTRO25ChannelIDTransmitOffsetMHz_A9416.UIValue = value;
			}
		}

		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x060008CA RID: 2250 RVA: 0x00086B90 File Offset: 0x00084D90
		public global::AcpBusinessLayer.AcpFrequencyField TrkSysASTRO25ChannelIDTransmitOffsetMHz_A9416
		{
			get
			{
				short num = (short)1338245120;
				short num2 = num;
				num = (short)1629117288;
				short num3 = num;
				num = (short)1924488040;
				switch (num3 == num)
				{
				}
				num = (short)1326579712;
				if (num != 0)
				{
				}
				num = (short)342556673;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ChannelIDTransmitOffsetMHz_A9416;
			}
		}

		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x060008CB RID: 2251 RVA: 0x00086C40 File Offset: 0x00084E40
		// (set) Token: 0x060008CC RID: 2252 RVA: 0x00086CF4 File Offset: 0x00084EF4
		internal int TrkSysASTRO25ChannelIDTransmitOffsetMHz_A9416Min
		{
			get
			{
				short num = (short)1106116608;
				short num2 = num;
				num = (short)324542851;
				short num3 = num;
				num = (short)599925123;
				switch (num3 == num)
				{
				}
				num = (short)847970305;
				if (num != 0)
				{
				}
				num = (short)258539520;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ChannelIDTransmitOffsetMHz_A9416.Min;
			}
			set
			{
				short num = (short)1803354112;
				short num2 = num;
				num = (short)36293612;
				short num3 = num;
				num = (short)961334252;
				switch (num3 == num)
				{
				}
				num = (short)1632370688;
				if (num != 0)
				{
				}
				num = (short)1927217153;
				if (num != 0)
				{
				}
				this.trkSysASTRO25ChannelIDTransmitOffsetMHz_A9416.Min = value;
			}
		}

		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x060008CD RID: 2253 RVA: 0x00086DA8 File Offset: 0x00084FA8
		// (set) Token: 0x060008CE RID: 2254 RVA: 0x00086E60 File Offset: 0x00085060
		internal int TrkSysASTRO25ChannelIDTransmitOffsetMHz_A9416Max
		{
			get
			{
				short num = (short)78970880;
				short num2 = num;
				num = (short)897445544;
				short num3 = num;
				num = (short)672067240;
				switch (num3 == num)
				{
				}
				num = (short)323092481;
				if (num != 0)
				{
				}
				num = (short)66060288;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ChannelIDTransmitOffsetMHz_A9416.Max;
			}
			set
			{
				short num = (short)1215823873;
				if (num != 0)
				{
				}
				num = (short)1320812544;
				short num2 = num;
				num = (short)2033105281;
				short num3 = num;
				num = (short)670022017;
				switch (num3 == num)
				{
				}
				num = (short)291241984;
				if (num != 0)
				{
				}
				this.trkSysASTRO25ChannelIDTransmitOffsetMHz_A9416.Max = value;
			}
		}

		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x060008CF RID: 2255 RVA: 0x00086F18 File Offset: 0x00085118
		// (set) Token: 0x060008D0 RID: 2256 RVA: 0x00086FCC File Offset: 0x000851CC
		internal int TrkSysASTRO25ChannelIDTransmitOffsetMHz_A9416Step
		{
			get
			{
				short num = (short)1629421569;
				if (num != 0)
				{
				}
				num = (short)324927488;
				short num2 = num;
				num = (short)1063181887;
				short num3 = num;
				num = (short)325770815;
				switch (num3 == num)
				{
				}
				num = (short)48824320;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ChannelIDTransmitOffsetMHz_A9416.StepSize;
			}
			set
			{
				short num = (short)471924737;
				if (num != 0)
				{
				}
				num = (short)55377920;
				short num2 = num;
				num = (short)968760533;
				short num3 = num;
				num = (short)2047417557;
				switch (num3 == num)
				{
				}
				num = (short)1847394304;
				if (num != 0)
				{
				}
				this.trkSysASTRO25ChannelIDTransmitOffsetMHz_A9416.StepSize = value;
			}
		}

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x060008D1 RID: 2257 RVA: 0x00087080 File Offset: 0x00085280
		// (set) Token: 0x060008D2 RID: 2258 RVA: 0x00087134 File Offset: 0x00085334
		public bool TrkSysASTRO25ChannelIDTransmitOffsetMHz_A9416_Applicable
		{
			get
			{
				short num = (short)339370494;
				short num2 = num;
				num = (short)914252286;
				switch (num2 == num)
				{
				default:
				{
					num = (short)909115392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1690238976;
				if (num != 0)
				{
				}
				num = (short)974651393;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ChannelIDTransmitOffsetMHz_A9416.Applicable;
			}
			set
			{
				short num = (short)527337928;
				short num2 = num;
				num = (short)1015777736;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1254293504;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)128516096;
				if (num != 0)
				{
				}
				num = (short)694091777;
				if (num != 0)
				{
				}
				this.trkSysASTRO25ChannelIDTransmitOffsetMHz_A9416.Applicable = value;
			}
		}

		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x060008D3 RID: 2259 RVA: 0x000871E8 File Offset: 0x000853E8
		// (set) Token: 0x060008D4 RID: 2260 RVA: 0x000872A0 File Offset: 0x000854A0
		public bool TrkSysASTRO25ChannelIDTransmitOffsetMHz_A9416_Valid
		{
			get
			{
				short num = (short)164140537;
				short num2 = num;
				num = (short)1055888889;
				switch (num2 == num)
				{
				default:
				{
					num = (short)495386624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1357512704;
				if (num != 0)
				{
				}
				num = (short)1287454721;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ChannelIDTransmitOffsetMHz_A9416.Valid;
			}
			set
			{
				short num = (short)1236140718;
				short num2 = num;
				num = (short)1762132654;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1068498944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1878458369;
				if (num != 0)
				{
				}
				num = (short)812646400;
				if (num != 0)
				{
				}
				this.trkSysASTRO25ChannelIDTransmitOffsetMHz_A9416.Valid = value;
			}
		}

		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x060008D5 RID: 2261 RVA: 0x00087358 File Offset: 0x00085558
		// (set) Token: 0x060008D6 RID: 2262 RVA: 0x0008740C File Offset: 0x0008560C
		public bool TrkSysASTRO25ChannelIDTransmitOffsetMHz_A9416_Visible
		{
			get
			{
				short num = (short)1518286001;
				short num2 = num;
				num = (short)1075721393;
				switch (num2 == num)
				{
				default:
				{
					num = (short)858128384;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1918500865;
				if (num != 0)
				{
				}
				num = (short)612433920;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ChannelIDTransmitOffsetMHz_A9416.Visible;
			}
			set
			{
				short num = (short)215640925;
				short num2 = num;
				num = (short)1456565085;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1872297984;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1869742080;
				if (num != 0)
				{
				}
				num = (short)1355415553;
				if (num != 0)
				{
				}
				this.trkSysASTRO25ChannelIDTransmitOffsetMHz_A9416.Visible = value;
			}
		}

		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x060008D7 RID: 2263 RVA: 0x000874C0 File Offset: 0x000856C0
		// (set) Token: 0x060008D8 RID: 2264 RVA: 0x00087574 File Offset: 0x00085774
		public bool TrkSysASTRO25ChannelIDTransmitOffsetMHz_A9416_Editable
		{
			get
			{
				short num = (short)448790529;
				if (num != 0)
				{
				}
				num = (short)1914109952;
				short num2 = num;
				num = (short)1002016789;
				short num3 = num;
				num = (short)1096192021;
				switch (num3 == num)
				{
				}
				num = (short)1156579328;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ChannelIDTransmitOffsetMHz_A9416.Editable;
			}
			set
			{
				short num = (short)149737811;
				short num2 = num;
				num = (short)961532243;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1977810944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1377894401;
				if (num != 0)
				{
				}
				num = (short)971833344;
				if (num != 0)
				{
				}
				this.trkSysASTRO25ChannelIDTransmitOffsetMHz_A9416.Editable = value;
			}
		}

		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x060008D9 RID: 2265 RVA: 0x0008762C File Offset: 0x0008582C
		internal string TrkSysASTRO25ChannelIDTransmitOffsetMHz_A9416_UILabel
		{
			get
			{
				short num = (short)793610052;
				short num2 = num;
				num = (short)93226820;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1925120000;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1178533889;
				if (num != 0)
				{
				}
				num = (short)87097344;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ChannelIDTransmitOffsetMHz_A9416.UIName;
			}
		}

		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x060008DA RID: 2266 RVA: 0x000876E0 File Offset: 0x000858E0
		// (set) Token: 0x060008DB RID: 2267 RVA: 0x00087798 File Offset: 0x00085998
		internal bool TrkSysASTRO25ChannelIDTransmitOffsetMHz_A9416_HiddenStatic
		{
			get
			{
				short num = (short)1765994064;
				short num2 = num;
				num = (short)881258064;
				switch (num2 == num)
				{
				default:
				{
					num = (short)447545344;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)448135168;
				if (num != 0)
				{
				}
				num = (short)6029313;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ChannelIDTransmitOffsetMHz_A9416.HiddenStatic;
			}
			set
			{
				short num = (short)995980797;
				short num2 = num;
				num = (short)350975485;
				switch (num2 == num)
				{
				default:
				{
					num = (short)712900608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)153288705;
				if (num != 0)
				{
				}
				num = (short)208994304;
				if (num != 0)
				{
				}
				this.trkSysASTRO25ChannelIDTransmitOffsetMHz_A9416.HiddenStatic = value;
			}
		}

		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x060008DC RID: 2268 RVA: 0x0008784C File Offset: 0x00085A4C
		// (set) Token: 0x060008DD RID: 2269 RVA: 0x00087900 File Offset: 0x00085B00
		internal bool TrkSysASTRO25ChannelIDTransmitOffsetMHz_A9416_HiddenDynamic
		{
			get
			{
				short num = (short)858668690;
				short num2 = num;
				num = (short)114966162;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1535574016;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1741029377;
				if (num != 0)
				{
				}
				num = (short)894894080;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ChannelIDTransmitOffsetMHz_A9416.HiddenDynamic;
			}
			set
			{
				short num = (short)1591430088;
				short num2 = num;
				num = (short)2050313160;
				switch (num2 == num)
				{
				default:
				{
					num = (short)571736064;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2072510465;
				if (num != 0)
				{
				}
				num = (short)1884160000;
				if (num != 0)
				{
				}
				this.trkSysASTRO25ChannelIDTransmitOffsetMHz_A9416.HiddenDynamic = value;
			}
		}

		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x060008DE RID: 2270 RVA: 0x000879BC File Offset: 0x00085BBC
		public bool TrkSysASTRO25ChannelIDTransmitOffsetMHz_A9416_HasDiffs
		{
			get
			{
				short num = (short)213624649;
				short num2 = num;
				num = (short)1036822345;
				switch (num2 == num)
				{
				default:
				{
					num = (short)225771520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1486815233;
				if (num != 0)
				{
				}
				num = (short)1229455360;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ChannelIDTransmitOffsetMHz_A9416._HasDiffs;
			}
		}

		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x060008DF RID: 2271 RVA: 0x00087A74 File Offset: 0x00085C74
		// (set) Token: 0x060008E0 RID: 2272 RVA: 0x00087B28 File Offset: 0x00085D28
		public int TrkSysASTRO25ChannelIDTransmitOffsetSign_A9417Value
		{
			get
			{
				short num = (short)1180293995;
				short num2 = num;
				num = (short)1556601707;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1575878656;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2020671489;
				if (num != 0)
				{
				}
				num = (short)2136145920;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ChannelIDTransmitOffsetSign_A9417.Value;
			}
			set
			{
				short num = (short)772276225;
				if (num != 0)
				{
				}
				num = (short)198377472;
				short num2 = num;
				num = (short)1487895594;
				short num3 = num;
				num = (short)1827765290;
				switch (num3 == num)
				{
				}
				num = (short)964100096;
				if (num != 0)
				{
				}
				this.trkSysASTRO25ChannelIDTransmitOffsetSign_A9417.Value = value;
			}
		}

		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x060008E1 RID: 2273 RVA: 0x00087BE0 File Offset: 0x00085DE0
		// (set) Token: 0x060008E2 RID: 2274 RVA: 0x00087C98 File Offset: 0x00085E98
		public string TrkSysASTRO25ChannelIDTransmitOffsetSign_A9417_UIValue
		{
			get
			{
				short num = (short)735334108;
				short num2 = num;
				num = (short)714165980;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1275854848;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1510014977;
				if (num != 0)
				{
				}
				num = (short)1576468480;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ChannelIDTransmitOffsetSign_A9417.UIValue;
			}
			set
			{
				short num = (short)975963183;
				short num2 = num;
				num = (short)491848751;
				switch (num2 == num)
				{
				default:
				{
					num = (short)818937856;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1893269505;
				if (num != 0)
				{
				}
				num = (short)1473773568;
				if (num != 0)
				{
				}
				this.trkSysASTRO25ChannelIDTransmitOffsetSign_A9417.UIValue = value;
			}
		}

		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x060008E3 RID: 2275 RVA: 0x00087D50 File Offset: 0x00085F50
		public global::AcpBusinessLayer.AcpListField TrkSysASTRO25ChannelIDTransmitOffsetSign_A9417
		{
			get
			{
				short num = (short)1350172673;
				if (num != 0)
				{
				}
				num = (short)1374552064;
				short num2 = num;
				num = (short)1392374494;
				short num3 = num;
				num = (short)2146628318;
				switch (num3 == num)
				{
				}
				num = (short)1357971456;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ChannelIDTransmitOffsetSign_A9417;
			}
		}

		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x060008E4 RID: 2276 RVA: 0x00087E00 File Offset: 0x00086000
		// (set) Token: 0x060008E5 RID: 2277 RVA: 0x00087EB8 File Offset: 0x000860B8
		public bool TrkSysASTRO25ChannelIDTransmitOffsetSign_A9417_Applicable
		{
			get
			{
				short num = (short)1112539137;
				if (num != 0)
				{
				}
				num = (short)187564032;
				short num2 = num;
				num = (short)1540353425;
				short num3 = num;
				num = (short)907734417;
				switch (num3 == num)
				{
				}
				num = (short)340197376;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ChannelIDTransmitOffsetSign_A9417.Applicable;
			}
			set
			{
				short num = (short)1936558169;
				short num2 = num;
				num = (short)790857817;
				switch (num2 == num)
				{
				default:
				{
					num = (short)577110016;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1300496385;
				if (num != 0)
				{
				}
				num = (short)2069168128;
				if (num != 0)
				{
				}
				this.trkSysASTRO25ChannelIDTransmitOffsetSign_A9417.Applicable = value;
			}
		}

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x060008E6 RID: 2278 RVA: 0x00087F6C File Offset: 0x0008616C
		// (set) Token: 0x060008E7 RID: 2279 RVA: 0x00088024 File Offset: 0x00086224
		public bool TrkSysASTRO25ChannelIDTransmitOffsetSign_A9417_Valid
		{
			get
			{
				short num = (short)847856373;
				short num2 = num;
				num = (short)293880565;
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
				num = (short)2016477184;
				if (num != 0)
				{
				}
				num = (short)2005139457;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ChannelIDTransmitOffsetSign_A9417.Valid;
			}
			set
			{
				short num = (short)260177921;
				if (num != 0)
				{
				}
				num = (short)1788608512;
				short num2 = num;
				num = (short)708720962;
				short num3 = num;
				num = (short)1634220354;
				switch (num3 == num)
				{
				}
				num = (short)682491904;
				if (num != 0)
				{
				}
				this.trkSysASTRO25ChannelIDTransmitOffsetSign_A9417.Valid = value;
			}
		}

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x060008E8 RID: 2280 RVA: 0x000880E0 File Offset: 0x000862E0
		// (set) Token: 0x060008E9 RID: 2281 RVA: 0x00088194 File Offset: 0x00086394
		public bool TrkSysASTRO25ChannelIDTransmitOffsetSign_A9417_Visible
		{
			get
			{
				short num = (short)1987724307;
				short num2 = num;
				num = (short)2080982035;
				switch (num2 == num)
				{
				default:
				{
					num = (short)335806464;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1007943681;
				if (num != 0)
				{
				}
				num = (short)579207168;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ChannelIDTransmitOffsetSign_A9417.Visible;
			}
			set
			{
				short num = (short)1124478101;
				short num2 = num;
				num = (short)268840085;
				switch (num2 == num)
				{
				default:
				{
					num = (short)545062912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2059927552;
				if (num != 0)
				{
				}
				num = (short)1772879873;
				if (num != 0)
				{
				}
				this.trkSysASTRO25ChannelIDTransmitOffsetSign_A9417.Visible = value;
			}
		}

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x060008EA RID: 2282 RVA: 0x0008824C File Offset: 0x0008644C
		// (set) Token: 0x060008EB RID: 2283 RVA: 0x00088300 File Offset: 0x00086500
		public bool TrkSysASTRO25ChannelIDTransmitOffsetSign_A9417_Editable
		{
			get
			{
				short num = (short)175705884;
				short num2 = num;
				num = (short)1588596508;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1503526912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1211236353;
				if (num != 0)
				{
				}
				num = (short)1006501888;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ChannelIDTransmitOffsetSign_A9417.Editable;
			}
			set
			{
				short num = (short)1095014698;
				short num2 = num;
				num = (short)683710762;
				switch (num2 == num)
				{
				default:
				{
					num = (short)431423488;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)988479488;
				if (num != 0)
				{
				}
				num = (short)23855105;
				if (num != 0)
				{
				}
				this.trkSysASTRO25ChannelIDTransmitOffsetSign_A9417.Editable = value;
			}
		}

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x060008EC RID: 2284 RVA: 0x000883B4 File Offset: 0x000865B4
		internal string TrkSysASTRO25ChannelIDTransmitOffsetSign_A9417_UILabel
		{
			get
			{
				short num = (short)1201550190;
				short num2 = num;
				num = (short)2066625390;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1837039616;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1847984128;
				if (num != 0)
				{
				}
				num = (short)456261633;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ChannelIDTransmitOffsetSign_A9417.UIName;
			}
		}

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x060008ED RID: 2285 RVA: 0x00088468 File Offset: 0x00086668
		// (set) Token: 0x060008EE RID: 2286 RVA: 0x0008851C File Offset: 0x0008671C
		internal bool TrkSysASTRO25ChannelIDTransmitOffsetSign_A9417_HiddenStatic
		{
			get
			{
				short num = (short)137465608;
				short num2 = num;
				num = (short)1926074120;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1040908288;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)815333377;
				if (num != 0)
				{
				}
				num = (short)1417936896;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ChannelIDTransmitOffsetSign_A9417.HiddenStatic;
			}
			set
			{
				short num = (short)1430808529;
				short num2 = num;
				num = (short)1805281233;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1695023104;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2050752513;
				if (num != 0)
				{
				}
				num = (short)19660800;
				if (num != 0)
				{
				}
				this.trkSysASTRO25ChannelIDTransmitOffsetSign_A9417.HiddenStatic = value;
			}
		}

		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x060008EF RID: 2287 RVA: 0x000885D0 File Offset: 0x000867D0
		// (set) Token: 0x060008F0 RID: 2288 RVA: 0x00088684 File Offset: 0x00086884
		internal bool TrkSysASTRO25ChannelIDTransmitOffsetSign_A9417_HiddenDynamic
		{
			get
			{
				short num = (short)1378063233;
				short num2 = num;
				num = (short)1338807169;
				switch (num2 == num)
				{
				default:
				{
					num = (short)780992512;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1160052737;
				if (num != 0)
				{
				}
				num = (short)663289856;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ChannelIDTransmitOffsetSign_A9417.HiddenDynamic;
			}
			set
			{
				short num = (short)1954643669;
				short num2 = num;
				num = (short)2033876693;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2068119552;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1529479169;
				if (num != 0)
				{
				}
				num = (short)330956800;
				if (num != 0)
				{
				}
				this.trkSysASTRO25ChannelIDTransmitOffsetSign_A9417.HiddenDynamic = value;
			}
		}

		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x060008F1 RID: 2289 RVA: 0x0008873C File Offset: 0x0008693C
		public bool TrkSysASTRO25ChannelIDTransmitOffsetSign_A9417_HasDiffs
		{
			get
			{
				short num = (short)1247344152;
				short num2 = num;
				num = (short)2035873304;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1921449984;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2012610561;
				if (num != 0)
				{
				}
				num = (short)734920704;
				if (num != 0)
				{
				}
				return this.trkSysASTRO25ChannelIDTransmitOffsetSign_A9417._HasDiffs;
			}
		}

		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x060008F2 RID: 2290 RVA: 0x000887F0 File Offset: 0x000869F0
		// (set) Token: 0x060008F3 RID: 2291 RVA: 0x000888A8 File Offset: 0x00086AA8
		public string TrkSysAstro25ChannelID_A24066Value
		{
			get
			{
				short num = (short)461639216;
				short num2 = num;
				num = (short)1015352880;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1960968192;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1390018561;
				if (num != 0)
				{
				}
				num = (short)695795712;
				if (num != 0)
				{
				}
				return this.trkSysAstro25ChannelID_A24066.Value;
			}
			set
			{
				short num = (short)1316421633;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						this.trkSysAstro25ChannelID_A24066.Value = value;
						num = (short)1404908997;
						short num3 = num;
						num = (short)21771717;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							num = (short)1401618432;
							if (num != 0)
							{
							}
							num = (short)1330446338;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
						switch (0)
						{
						case 0:
							goto IL_30;
						}
						continue;
					case 2:
						goto IL_C5;
					}
					IL_30:
					if (string.IsNullOrEmpty(value.Trim()))
					{
						return;
					}
					num = (short)131727360;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_C5:
				num = (short)1325400065;
				if (num != 0)
				{
				}
				num = (short)2078408704;
				short num4 = num;
			}
		}

		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x060008F4 RID: 2292 RVA: 0x000889D0 File Offset: 0x00086BD0
		// (set) Token: 0x060008F5 RID: 2293 RVA: 0x00088A88 File Offset: 0x00086C88
		public string TrkSysAstro25ChannelID_A24066_UIValue
		{
			get
			{
				short num = (short)247649467;
				short num2 = num;
				num = (short)806016187;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1514471424;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1303904257;
				if (num != 0)
				{
				}
				num = (short)1184759808;
				if (num != 0)
				{
				}
				return this.trkSysAstro25ChannelID_A24066.Value;
			}
			set
			{
				short num = (short)590485552;
				short num2 = num;
				num = (short)1185814576;
				switch (num2 == num)
				{
				default:
				{
					num = (short)987496448;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1588396033;
				if (num != 0)
				{
				}
				num = (short)1536557056;
				if (num != 0)
				{
				}
				this.trkSysAstro25ChannelID_A24066.Value = value;
			}
		}

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x060008F6 RID: 2294 RVA: 0x00088B40 File Offset: 0x00086D40
		public global::AcpBusinessLayer.AcpKeyField TrkSysAstro25ChannelID_A24066
		{
			get
			{
				short num = (short)657716502;
				short num2 = num;
				num = (short)2140927254;
				switch (num2 == num)
				{
				}
				num = (short)1460797441;
				if (num != 0)
				{
				}
				num = (short)463863808;
				short num3 = num;
				num = (short)1206517760;
				if (num != 0)
				{
				}
				return this.trkSysAstro25ChannelID_A24066;
			}
		}

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x060008F7 RID: 2295 RVA: 0x00088BF0 File Offset: 0x00086DF0
		// (set) Token: 0x060008F8 RID: 2296 RVA: 0x00088CA4 File Offset: 0x00086EA4
		public bool TrkSysAstro25ChannelID_A24066_Applicable
		{
			get
			{
				short num = (short)664666154;
				short num2 = num;
				num = (short)1741946922;
				switch (num2 == num)
				{
				}
				num = (short)1688141825;
				if (num != 0)
				{
				}
				num = (short)183042048;
				short num3 = num;
				num = (short)1938292736;
				if (num != 0)
				{
				}
				return this.trkSysAstro25ChannelID_A24066.Applicable;
			}
			set
			{
				short num = (short)572981249;
				if (num != 0)
				{
				}
				num = (short)1919430491;
				short num2 = num;
				num = (short)948580187;
				switch (num2 == num)
				{
				}
				num = (short)621608960;
				short num3 = num;
				num = (short)483196928;
				if (num != 0)
				{
				}
				this.trkSysAstro25ChannelID_A24066.Applicable = value;
			}
		}

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x060008F9 RID: 2297 RVA: 0x00088D58 File Offset: 0x00086F58
		// (set) Token: 0x060008FA RID: 2298 RVA: 0x00088E0C File Offset: 0x0008700C
		public bool TrkSysAstro25ChannelID_A24066_Valid
		{
			get
			{
				short num = (short)998004328;
				short num2 = num;
				num = (short)403330664;
				switch (num2 == num)
				{
				}
				num = (short)1402404865;
				if (num != 0)
				{
				}
				num = (short)554172416;
				short num3 = num;
				num = (short)468582400;
				if (num != 0)
				{
				}
				return this.trkSysAstro25ChannelID_A24066.Valid;
			}
			set
			{
				short num = (short)940333229;
				short num2 = num;
				num = (short)60315821;
				switch (num2 == num)
				{
				}
				num = (short)289996800;
				if (num != 0)
				{
				}
				num = (short)614072320;
				short num3 = num;
				num = (short)1989345281;
				if (num != 0)
				{
				}
				this.trkSysAstro25ChannelID_A24066.Valid = value;
			}
		}

		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x060008FB RID: 2299 RVA: 0x00088EC4 File Offset: 0x000870C4
		// (set) Token: 0x060008FC RID: 2300 RVA: 0x00088F78 File Offset: 0x00087178
		public bool TrkSysAstro25ChannelID_A24066_Visible
		{
			get
			{
				short num = (short)372770090;
				short num2 = num;
				num = (short)720831786;
				switch (num2 == num)
				{
				}
				num = (short)1133772800;
				if (num != 0)
				{
				}
				num = (short)426901504;
				short num3 = num;
				num = (short)1450639361;
				if (num != 0)
				{
				}
				return this.trkSysAstro25ChannelID_A24066.Visible;
			}
			set
			{
				short num = (short)1480447274;
				short num2 = num;
				num = (short)1000199466;
				switch (num2 == num)
				{
				}
				num = (short)198508544;
				if (num != 0)
				{
				}
				num = (short)758317056;
				short num3 = num;
				num = (short)974192641;
				if (num != 0)
				{
				}
				this.trkSysAstro25ChannelID_A24066.Visible = value;
			}
		}

		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x060008FD RID: 2301 RVA: 0x0008902C File Offset: 0x0008722C
		// (set) Token: 0x060008FE RID: 2302 RVA: 0x000890E0 File Offset: 0x000872E0
		public bool TrkSysAstro25ChannelID_A24066_Editable
		{
			get
			{
				short num = (short)1174867473;
				short num2 = num;
				num = (short)1397493265;
				switch (num2 == num)
				{
				}
				num = (short)1089929217;
				if (num != 0)
				{
				}
				num = (short)542375936;
				short num3 = num;
				num = (short)596574208;
				if (num != 0)
				{
				}
				return this.trkSysAstro25ChannelID_A24066.Editable;
			}
			set
			{
				short num = (short)966885108;
				short num2 = num;
				num = (short)608272116;
				switch (num2 == num)
				{
				}
				num = (short)1789788161;
				if (num != 0)
				{
				}
				num = (short)1437138944;
				short num3 = num;
				num = (short)1446445056;
				if (num != 0)
				{
				}
				this.trkSysAstro25ChannelID_A24066.Editable = value;
			}
		}

		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x060008FF RID: 2303 RVA: 0x00089198 File Offset: 0x00087398
		internal string TrkSysAstro25ChannelID_A24066_UILabel
		{
			get
			{
				short num = (short)1023984466;
				short num2 = num;
				num = (short)1094828882;
				switch (num2 == num)
				{
				}
				num = (short)974192640;
				if (num != 0)
				{
				}
				num = (short)566951936;
				short num3 = num;
				num = (short)968491009;
				if (num != 0)
				{
				}
				return this.trkSysAstro25ChannelID_A24066.UIName;
			}
		}

		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x06000900 RID: 2304 RVA: 0x0008924C File Offset: 0x0008744C
		// (set) Token: 0x06000901 RID: 2305 RVA: 0x00089300 File Offset: 0x00087500
		internal bool TrkSysAstro25ChannelID_A24066_HiddenStatic
		{
			get
			{
				short num = (short)2143199069;
				short num2 = num;
				num = (short)978689885;
				switch (num2 == num)
				{
				}
				num = (short)1909063681;
				if (num != 0)
				{
				}
				num = (short)1814691840;
				short num3 = num;
				num = (short)1618477056;
				if (num != 0)
				{
				}
				return this.trkSysAstro25ChannelID_A24066.HiddenStatic;
			}
			set
			{
				short num = (short)2076213245;
				short num2 = num;
				num = (short)1494974461;
				switch (num2 == num)
				{
				}
				num = (short)1536753665;
				if (num != 0)
				{
				}
				num = (short)1728643072;
				short num3 = num;
				num = (short)1448869888;
				if (num != 0)
				{
				}
				this.trkSysAstro25ChannelID_A24066.HiddenStatic = value;
			}
		}

		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x06000902 RID: 2306 RVA: 0x000893B4 File Offset: 0x000875B4
		// (set) Token: 0x06000903 RID: 2307 RVA: 0x00089464 File Offset: 0x00087664
		internal bool TrkSysAstro25ChannelID_A24066_HiddenDynamic
		{
			get
			{
				short num = (short)1622605825;
				if (num != 0)
				{
				}
				num = (short)1849730392;
				short num2 = num;
				num = (short)576103768;
				switch (num2 == num)
				{
				}
				num = (short)1278148608;
				short num3 = num;
				num = (short)738066432;
				if (num != 0)
				{
				}
				return this.trkSysAstro25ChannelID_A24066.HiddenDynamic;
			}
			set
			{
				short num = (short)949583120;
				short num2 = num;
				num = (short)1574075664;
				switch (num2 == num)
				{
				}
				num = (short)857145344;
				if (num != 0)
				{
				}
				num = (short)2120876032;
				short num3 = num;
				num = (short)255066113;
				if (num != 0)
				{
				}
				this.trkSysAstro25ChannelID_A24066.HiddenDynamic = value;
			}
		}

		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x06000904 RID: 2308 RVA: 0x00089518 File Offset: 0x00087718
		public bool TrkSysAstro25ChannelID_A24066_HasDiffs
		{
			get
			{
				short num = (short)536537721;
				short num2 = num;
				num = (short)969599609;
				switch (num2 == num)
				{
				}
				num = (short)1766850561;
				if (num != 0)
				{
				}
				num = (short)1849425920;
				short num3 = num;
				num = (short)1230897152;
				if (num != 0)
				{
				}
				return this.trkSysAstro25ChannelID_A24066._HasDiffs;
			}
		}

		// Token: 0x06000905 RID: 2309 RVA: 0x000895CC File Offset: 0x000877CC
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
						num2 = (short)1476329475;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 1:
					goto IL_3A;
				case 2:
					num2 = (short)395247616;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					num2 = (short)1565458433;
					if (num2 != 0)
					{
					}
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)636944388;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
				{
					num2 = (short)871089827;
					short num3 = num2;
					num2 = (short)776849059;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_3A;
					default:
						goto IL_E3;
					}
					break;
				}
				}
				goto IL_24;
				IL_3A:
				if (base.ParentRecset == null)
				{
					return result;
				}
				num2 = (short)1813381120;
				short num4 = num2;
				num2 = (short)2116878338;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_E3:
			num2 = (short)1705377792;
			if (num2 != 0)
			{
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)1009254401;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0400032B RID: 811
		private global::AcpBusinessLayer.AcpListField trkSysASTRO25ChannelIDChannelType_A1390;

		// Token: 0x0400032C RID: 812
		private global::AcpBusinessLayer.AcpFrequencyField trkSysASTRO25ChannelIDBaseFrequencyMHz_A7546;

		// Token: 0x0400032D RID: 813
		private global::AcpBusinessLayer.AcpFrequencyField trkSysASTRO25ChannelIDChannelSpacingkHz_A7660;

		// Token: 0x0400032E RID: 814
		private global::AcpBusinessLayer.AcpFieldX<bool, bool> trkSysASTRO25ChannelIDIdentifierEnable_A8222;

		// Token: 0x0400032F RID: 815
		private global::AcpBusinessLayer.AcpFrequencyField trkSysASTRO25ChannelIDTransmitOffsetMHz_A9416;

		// Token: 0x04000330 RID: 816
		private global::AcpBusinessLayer.AcpListField trkSysASTRO25ChannelIDTransmitOffsetSign_A9417;

		// Token: 0x04000331 RID: 817
		private global::AcpBusinessLayer.AcpKeyField trkSysAstro25ChannelID_A24066;
	}
}
