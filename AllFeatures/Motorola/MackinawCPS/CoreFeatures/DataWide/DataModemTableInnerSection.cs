using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.DataWide
{
	// Token: 0x020004CC RID: 1228
	[global::System.Serializable]
	public class DataModemTableInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600A107 RID: 41223 RVA: 0x00968174 File Offset: 0x00966374
		public DataModemTableInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x0600A108 RID: 41224 RVA: 0x00968190 File Offset: 0x00966390
		protected DataModemTableInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600A109 RID: 41225 RVA: 0x009681A8 File Offset: 0x009663A8
		public override void Init()
		{
			int a_ = 13;
			short num = (short)1139024050;
			short num2 = num;
			num = (short)1396318386;
			switch (num2 == num)
			{
			}
			num = (short)1942618112;
			short num3 = num;
			num = (short)217120768;
			if (num != 0)
			{
			}
			num = (short)1182990337;
			if (num != 0)
			{
			}
			this.dataWideExternalDataModemNetworkPriority_43358 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("諍뇏ꛑ뗓臕뇗뻙맛鯝食雡臣铥蛧诩胫ꫭ釯蛱闳믵韷黹駻鏽仿朁瀃焅朇砉朋帍戏笑笓搕焗渙攛䄝ᐟᄡᜣጥဧ", a_), global::CommonResources.AcgResources.ID_NETWORKPRIORITY, 1, 255, null, null, 0, 1);
			this.dataWideExternalDataModemNetworkPriority_43358.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.dataWideExternalDataModemNetworkPriority_43358.DataTransferOrder = 80;
			this.dataWideExternalDataModemNetworkPriority_43358.ShowHexValue = false;
			this.dataWideExternalDataModemNetworkSsid_43358 = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::AllFeatures.CodeplugGuid.b("諍뇏ꛑ뗓臕뇗뻙맛鯝食雡臣铥蛧诩胫ꫭ釯蛱闳믵韷黹駻鏽仿朁瀃焅朇砉朋崍挏笑瀓䤕Ⱇ⤙⼛⬝᠟", a_), global::CommonResources.AcgResources.ID_NETWORKSSID_1, 32);
			this.dataWideExternalDataModemNetworkSsid_43358.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.dataWideExternalDataModemNetworkSsid_43358.DataTransferOrder = 81;
			this.dataWideExternalDataModemNetworkSsid_43358.ValidateAcrossRecset = true;
			this.dataWideExternalDataModemSecurityType_43360 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("諍뇏ꛑ뗓臕뇗뻙맛鯝食雡臣铥蛧诩胫ꫭ釯蛱闳믵韷黹駻鏽叿朁會猅稇按砋眍䐏欑搓猕䜗⸙⼛ⴝᘟሡ", a_), global::CommonResources.AcgResources.ID_SECURITYTYPE, global::Motorola.MackinawCPS.CoreFeatures.DataWide.LOVs.DataWideExternalDataModemSecurityType_43360LovStrs);
			this.dataWideExternalDataModemSecurityType_43360.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.dataWideExternalDataModemSecurityType_43360.DataTransferOrder = 82;
			this.dataWideEncryptedNetworkPassword_43361 = new global::AcpBusinessLayer.AcpFieldX<string, string>(global::AllFeatures.CodeplugGuid.b("ﳍ鋏韕ꇟ\udae1탣탥\udde7\udae9\udbebꫭ짯쯱쟳쟵죷쯹룻쯽㏿㘁㄃䔅䴇伉㼋伍刏儑刓匕ⴗⰙ⠛☝戟挡ᴣဥᴧ氩ᐫ漭įб申Ե紷簹缻紽爿сɃ畅硇祉ੋ్楏ᝑᅓᕕ浗桙湛楝⑟婡≣剥內卩孫⽭㕯㝱䑳䕵㥷乹䥻䵽땿늁늃쎅캇즉릋뢍ꎏ톑킓ꖕ겗ꎙꦛ\udd9d颟鞡隣麫鲭讱膳薵醴誹ﶻ覽菁難韛迋", a_), new global::Motorola.MackinawCPS.CoreFeatures.DataWide.WiFiPasswordEncryptDecryptConverter(), this, global::AllFeatures.CodeplugGuid.b("諍뇏ꛑ뗓臕뇗뻙맛鯝軟臡難鿥飧黩觫諭뻯韱胳臵韷裹韻껽懿焁眃焅朇砉栋儍␏ℑ✓―⤗", a_), global::CommonResources.AcgResources.ID_ENCRYPTEDNETWORKPASSWORD);
			this.dataWideEncryptedNetworkPassword_43361.IgnoreOnCompare = true;
			this.dataWideEncryptedNetworkPassword_43361.IsMasked = true;
			this.dataWideEncryptedNetworkPassword_43361.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.dataWideEncryptedNetworkPassword_43361.DataTransferOrder = -1;
			this.dataWideExternalDataModemType_43362 = new global::AcpBusinessLayer.AcpListField(1, this, global::AllFeatures.CodeplugGuid.b("諍뇏ꛑ뗓臕뇗뻙맛鯝食雡臣铥蛧诩胫ꫭ釯蛱闳믵韷黹駻鏽哿笁球挅圇㸉㼋㴍☏‑", a_), global::CommonResources.AcgResources.ID_MODEMTYPE, true, global::Motorola.MackinawCPS.CoreFeatures.DataWide.LOVs.DataWideExternalDataModemType_43362LovStrs);
			this.dataWideExternalDataModemType_43362.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.dataWideExternalDataModemType_43362.DataTransferOrder = 84;
			this.dataWideEncryptedModemPassword_43361 = new global::AcpBusinessLayer.AcpFieldX<string, string>(global::AllFeatures.CodeplugGuid.b("ￍ量ꛟ\udae1탣탥\udde7\udae9\udbebꫭ짯쯱쟳쟵죷쯹룻쯽㏿㘁㄃䔅䴇伉㼋伍刏儑刓匕ⴗⰙ⠛☝戟挡ᴣဥᴧ氩ᐫ漭įб申Ե紷簹缻紽爿сɃ畅硇祉ੋ్楏", a_), new global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataModemPasswordEncryptDecryptConverter(), this, global::AllFeatures.CodeplugGuid.b("諍뇏ꛑ뗓臕뇗뻙맛鯝軟臡難鿥飧黩觫諭뷯鷱郳鏵闷꫹鷻跽珿甁欃琅氇唉㠋㴍⌏␑┓", a_), global::CommonResources.AcgResources.ID_MODEMPASSWORD);
			this.dataWideEncryptedModemPassword_43361.IgnoreOnCompare = true;
			this.dataWideEncryptedModemPassword_43361.IsMasked = false;
			this.dataWideEncryptedModemPassword_43361.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.dataWideEncryptedModemPassword_43361.DataTransferOrder = -1;
			this.dataWideExternalDataModemPort = new global::AcpBusinessLayer.AcpSimpleRangeField(0, this, global::AllFeatures.CodeplugGuid.b("諍뇏ꛑ뗓臕뇗뻙맛鯝食雡臣铥蛧诩胫ꫭ釯蛱闳믵韷黹駻鏽僿洁瘃爅", a_), global::CommonResources.AcgResources.ID_MODEMPORT, 0, 65535, null, null, 0, 1);
			this.dataWideExternalDataModemPort.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.dataWideExternalDataModemPort.DataTransferOrder = 85;
			this.dataWideExternalDataModemPort.ShowHexValue = false;
			this.dataWideExternalDataVpnTunnel_43365 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("諍뇏ꛑ뗓臕뇗뻙맛鯝食雡臣铥蛧诩胫ꫭ釯蛱闳ꃵ裷铹ꣻ诽滿氁愃樅圇㸉㼋㴍☏✑", a_), global::CommonResources.AcgResources.ID_VPNTUNNEL, 1, 5, null, null, 0, 1);
			this.dataWideExternalDataVpnTunnel_43365.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.dataWideExternalDataVpnTunnel_43365.DataTransferOrder = 86;
			this.dataWideExternalDataVpnTunnel_43365.ShowHexValue = false;
			this.dataWideExternalDataOORTime_43366 = new global::AcpBusinessLayer.AcpSimpleRangeField(60, this, global::AllFeatures.CodeplugGuid.b("諍뇏ꛑ뗓臕뇗뻙맛鯝食雡臣铥蛧诩胫ꫭ釯蛱闳맵럷꣹ꣻ韽淿朁嬃㈅㬇㤉㨋㠍", a_), global::CommonResources.AcgResources.ID_MODEMOUTOFRANGETHRESHOLDSEC, 30, 3600, null, null, 0, 1);
			this.dataWideExternalDataOORTime_43366.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.dataWideExternalDataOORTime_43366.DataTransferOrder = 87;
			this.dataWideExternalDataOORTime_43366.ShowHexValue = false;
			this.dataWideExternalDataModemOpenTime_43367 = new global::AcpBusinessLayer.AcpSimpleRangeField(60, this, global::AllFeatures.CodeplugGuid.b("諍뇏ꛑ뗓臕뇗뻙맛鯝食雡臣铥蛧诩胫ꫭ釯蛱闳믵韷黹駻鏽俿爁愃栅將按愋欍伏☑✓┕⸗ⴙ", a_), global::CommonResources.AcgResources.ID_MODEMOPENMAXGUARDTIMESEC, 1, 100, null, null, 0, 1);
			this.dataWideExternalDataModemOpenTime_43367.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.dataWideExternalDataModemOpenTime_43367.DataTransferOrder = 88;
			this.dataWideExternalDataModemOpenTime_43367.ShowHexValue = false;
			this.dataWideMG90WirelessVPNFriendlyName_43785 = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::AllFeatures.CodeplugGuid.b("諍뇏ꛑ뗓臕뇗뻙맛鏝꟟\udbe1퓣뇥臧飩觫苭闯臱蟳ꃵꣷ듹뫻賽槿朁樃戅搇猉䈋漍紏眑䬓∕⬗ⴙ␛⬝", a_), global::CommonResources.AcgResources.ID_MG90MODEMVPNFRIENDLYNAME, 128);
			this.dataWideMG90WirelessVPNFriendlyName_43785.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.dataWideMG90WirelessVPNFriendlyName_43785.DataTransferOrder = 89;
			this.dataWideMG90WirelessLTEFriendlyName_43786 = new global::AcpBusinessLayer.AcpStringField(global::AllFeatures.CodeplugGuid.b("苍蓏韑", a_), this, global::AllFeatures.CodeplugGuid.b("諍뇏ꛑ뗓臕뇗뻙맛鏝꟟\udbe1퓣뇥臧飩觫苭闯臱蟳뫵곷뿹뫻賽槿朁樃戅搇猉䈋漍紏眑䬓∕⬗ⴙ␛⠝", a_), global::CommonResources.AcgResources.ID_MG90LTEFRIENDLYNAME, 128);
			this.dataWideMG90WirelessLTEFriendlyName_43786.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.dataWideMG90WirelessLTEFriendlyName_43786.DataTransferOrder = 90;
			this.dataWideMG90WirelessSatelliteFriendlyName_43787 = new global::AcpBusinessLayer.AcpStringField(global::AllFeatures.CodeplugGuid.b("鷍量蛑", a_), this, global::AllFeatures.CodeplugGuid.b("諍뇏ꛑ뗓臕뇗뻙맛鏝꟟\udbe1퓣뇥臧飩觫苭闯臱蟳ꗵ駷軹駻鋽泿欁瀃挅万砉攋欍縏瘑砓漕嘗笙焛笝缟ᘡᜣᄥဧᴩ", a_), global::CommonResources.AcgResources.ID_MG90SATELLITEFRIENDLYNAME, 128);
			this.dataWideMG90WirelessSatelliteFriendlyName_43787.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.dataWideMG90WirelessSatelliteFriendlyName_43787.DataTransferOrder = 92;
			this.dataWideMG90WirelessSatelliteEnable_43788 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("諍뇏ꛑ뗓臕뇗뻙맛鏝꟟\udbe1퓣뇥臧飩觫苭闯臱蟳ꗵ駷軹駻鋽泿欁瀃挅䴇搉洋氍簏眑䬓∕⬗ⴙ␛☝", a_), global::CommonResources.AcgResources.ID_MG90SATELLITEENABLED);
			this.dataWideMG90WirelessSatelliteEnable_43788.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.dataWideMG90WirelessSatelliteEnable_43788.DataTransferOrder = 91;
			this.dataWideExternalDataModemHiddenNetwork_44814 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("諍뇏ꛑ뗓臕뇗뻙맛鯝食雡臣铥蛧诩胫ꫭ釯蛱闳믵韷黹駻鏽䣿欁怃戅洇搉䈋欍搏攑笓搕猗䔙⠛⨝᠟ጡဣ", a_), global::CommonResources.AcgResources.ID_HIDDENNETWORK);
			this.dataWideExternalDataModemHiddenNetwork_44814.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.dataWideExternalDataModemHiddenNetwork_44814.DataTransferOrder = 93;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("諍뇏ꛑ뗓闗뗙룛믝跟싡냣蟥諧蛩觫", a_);
			base.Id = 10851;
			base.UIName = global::CommonResources.AcgResources.ID_DATAMODEMTABLE;
			base.DataTransferOrder = 4;
		}

		// Token: 0x0600A10A RID: 41226 RVA: 0x009686E4 File Offset: 0x009668E4
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 11;
			short num = (short)974585868;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("裋꿍꓏돑菓뿕볗뿙釛駝\ud9df틡돣迥髧迩胫语華臱ꟳ韵賷鿹郻鋽槿瘁愃䌅昇欉渋戍甏䴑–┕⼗∙␛", a_)))
					{
						num = (short)721158181;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_C18;
				case 1:
					if (producerFields != null)
					{
						num = (short)1256849421;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_C61;
				case 2:
					goto IL_25D;
				case 3:
					this.dataWideExternalDataModemPort = new global::AcpBusinessLayer.AcpSimpleRangeField(0, this, global::AllFeatures.CodeplugGuid.b("裋꿍꓏돑菓뿕볗뿙駛ꛝ铟蟡難裥觧蛩꣫迭蓯鏱맳駵鳷鿹釻껽濿瀁瀃", a_), global::CommonResources.AcgResources.ID_MODEMPORT, null, null, 0, 1);
					this.dataWideExternalDataModemPort.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.dataWideExternalDataModemPort.DataTransferOrder = 85;
					this.dataWideExternalDataModemPort.ShowHexValue = false;
					num = (short)1412759593;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
				{
					num = (short)1255470238;
					short num3 = num;
					num = (short)49018014;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_51E;
					default:
						num = (short)916258816;
						if (num != 0)
						{
						}
						goto IL_574;
					}
					break;
				}
				case 5:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("裋꿍꓏돑菓뿕볗뿙駛ꛝ铟蟡難裥觧蛩꣫迭蓯鏱맳駵鳷鿹釻냽旿瘁猃椅稇愉尋簍礏紑易缕気挙䌛⨝ጟᄡᄣḥ", a_)))
					{
						num = (short)81920019;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_25D;
				case 6:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("裋꿍꓏돑菓뿕볗뿙駛냝菟郡鷣雥鳧迩裫ꏭ鿯雱釳鯵ꣷ鯹迻跽矿洁瘃戅圇㸉㼋㴍☏⌑", a_)))
					{
						num = (short)907870256;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_774;
				case 7:
					goto IL_7C2;
				case 8:
					this.dataWideMG90WirelessLTEFriendlyName_43786 = new global::AcpBusinessLayer.AcpStringField(global::AllFeatures.CodeplugGuid.b("胋髍闏", a_), this, global::AllFeatures.CodeplugGuid.b("裋꿍꓏돑菓뿕볗뿙釛駝\ud9df틡돣迥髧迩胫语華臱룳ꋵ뷷볹軻韽旿氁怃樅焇䐉洋挍甏䴑–┕⼗∙⨛", a_), global::CommonResources.AcgResources.ID_MG90LTEFRIENDLYNAME, 128);
					this.dataWideMG90WirelessLTEFriendlyName_43786.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.dataWideMG90WirelessLTEFriendlyName_43786.DataTransferOrder = 90;
					num = (short)1261371436;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("裋꿍꓏돑菓뿕볗뿙駛ꛝ铟蟡難裥觧蛩꣫迭蓯鏱맳駵鳷鿹釻뇽烿朁樃刅愇有椋儍␏ℑ✓―⼗", a_)))
					{
						num = (short)563019793;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_119;
				case 10:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("裋꿍꓏돑菓뿕볗뿙駛ꛝ铟蟡難裥觧蛩꣫迭蓯鏱맳駵鳷鿹釻뛽槿昁怃挅昇䐉椋稍朏紑易紕䜗⸙⠛☝ᄟᘡ", a_)))
					{
						num = (short)1566638109;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_C61;
				case 11:
					this.dataWideEncryptedNetworkPassword_43361 = new global::AcpBusinessLayer.AcpFieldX<string, string>(global::AllFeatures.CodeplugGuid.b("ﻋ賍闓鿝\ud8df훡틣폥\ud8e7\udde9꣫ퟭ짯쇱엳웵짷뻹짻췽㓿㜁䜃䌅䴇㤉䴋䰍匏向儓⌕⸗⸙␛尝感ᬡሣጥ渧ሩ洫Ἥد猱ܳ猵縷礹缻ఽؿс睃癅筇౉๋睍ᕏᝑᝓ捕橗桙歛ᩝ塟②偣彥內嵩⵫⭭㕯䉱䝳㝵䱷佹佻䭽끿뒁솃삅쮇뾉몋붍펏횑ꞓꊕꆗ꾙\udf9bꚝ閟邡颩麫覯螱螳袷﮹讻貽膿觉", a_), new global::Motorola.MackinawCPS.CoreFeatures.DataWide.WiFiPasswordEncryptDecryptConverter(), this, global::AllFeatures.CodeplugGuid.b("裋꿍꓏돑菓뿕볗뿙駛냝菟郡鷣雥鳧迩裫ꃭ闯蛱菳駵諷釹곻鿽珿焁猃椅稇渉匋㨍⌏ℑ∓✕", a_), global::CommonResources.AcgResources.ID_ENCRYPTEDNETWORKPASSWORD);
					this.dataWideEncryptedNetworkPassword_43361.IgnoreOnCompare = true;
					this.dataWideEncryptedNetworkPassword_43361.IsMasked = true;
					this.dataWideEncryptedNetworkPassword_43361.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.dataWideEncryptedNetworkPassword_43361.DataTransferOrder = -1;
					num = (short)1285357613;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					switch (0)
					{
					case 0:
						goto IL_F3;
					}
					continue;
				case 13:
					num = (short)1714552837;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("裋꿍꓏돑菓뿕볗뿙釛駝\ud9df틡돣迥髧迩胫语華臱ꋳ꛵뛷볹軻韽旿氁怃樅焇䐉洋挍甏䴑–┕⼗∙⤛", a_)))
					{
						num = (short)862650407;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_727;
				case 15:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("裋꿍꓏돑菓뿕볗뿙駛ꛝ铟蟡難裥觧蛩꣫迭蓯鏱맳駵鳷鿹釻껽濿瀁瀃", a_)))
					{
						num = (short)154337283;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A8C;
				case 16:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("裋꿍꓏돑菓뿕볗뿙駛ꛝ铟蟡難裥觧蛩꣫迭蓯鏱믳맵꫷껹闻鏽旿崁〃㔅㬇㰉㨋", a_)))
					{
						num = (short)982974492;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_80B;
				case 17:
					this.dataWideExternalDataModemOpenTime_43367 = new global::AcpBusinessLayer.AcpSimpleRangeField(60, this, global::AllFeatures.CodeplugGuid.b("裋꿍꓏돑菓뿕볗뿙駛ꛝ铟蟡難裥觧蛩꣫迭蓯鏱맳駵鳷鿹釻뇽烿朁樃刅愇有椋儍␏ℑ✓―⼗", a_), global::CommonResources.AcgResources.ID_MODEMOPENMAXGUARDTIMESEC, null, null, 0, 1);
					this.dataWideExternalDataModemOpenTime_43367.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.dataWideExternalDataModemOpenTime_43367.DataTransferOrder = 88;
					this.dataWideExternalDataModemOpenTime_43367.ShowHexValue = false;
					num = (short)389546031;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 18:
					goto IL_4B7;
				case 19:
					this.dataWideExternalDataModemNetworkPriority_43358 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("裋꿍꓏돑菓뿕볗뿙駛ꛝ铟蟡難裥觧蛩꣫迭蓯鏱맳駵鳷鿹釻냽旿瘁猃椅稇愉尋簍礏紑易缕気挙䌛⨝ጟᄡᄣḥ", a_), global::CommonResources.AcgResources.ID_NETWORKPRIORITY, null, null, 0, 1);
					this.dataWideExternalDataModemNetworkPriority_43358.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.dataWideExternalDataModemNetworkPriority_43358.DataTransferOrder = 80;
					this.dataWideExternalDataModemNetworkPriority_43358.ShowHexValue = false;
					num = (short)592052226;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 20:
					goto IL_C18;
				case 21:
					goto IL_3CA;
				case 22:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("裋꿍꓏돑菓뿕볗뿙駛ꛝ铟蟡難裥觧蛩꣫迭蓯鏱맳駵鳷鿹釻꫽秿爁愃夅㰇㤉㼋㠍∏", a_)))
					{
						num = (short)264437798;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_7C2;
				case 23:
					goto IL_80B;
				case 24:
					this.dataWideExternalDataVpnTunnel_43365 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("裋꿍꓏돑菓뿕볗뿙駛ꛝ铟蟡難裥觧蛩꣫迭蓯鏱ꋳ蛵雷껹觻都滿朁栃夅㰇㤉㼋㠍┏", a_), global::CommonResources.AcgResources.ID_VPNTUNNEL, null, null, 0, 1);
					this.dataWideExternalDataVpnTunnel_43365.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.dataWideExternalDataVpnTunnel_43365.DataTransferOrder = 86;
					this.dataWideExternalDataVpnTunnel_43365.ShowHexValue = false;
					num = (short)2140340251;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 25:
					goto IL_727;
				case 26:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("裋꿍꓏돑菓뿕볗뿙駛ꛝ铟蟡難裥觧蛩꣫迭蓯鏱맳駵鳷鿹釻냽旿瘁猃椅稇愉弋納礏瘑䬓∕⬗⤙⤛☝", a_)))
					{
						num = (short)1041891361;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_574;
				case 27:
					goto IL_166;
				case 28:
					this.dataWideExternalDataOORTime_43366 = new global::AcpBusinessLayer.AcpSimpleRangeField(60, this, global::AllFeatures.CodeplugGuid.b("裋꿍꓏돑菓뿕볗뿙駛ꛝ铟蟡難裥觧蛩꣫迭蓯鏱믳맵꫷껹闻鏽旿崁〃㔅㬇㰉㨋", a_), global::CommonResources.AcgResources.ID_MODEMOUTOFRANGETHRESHOLDSEC, null, null, 0, 1);
					this.dataWideExternalDataOORTime_43366.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.dataWideExternalDataOORTime_43366.DataTransferOrder = 87;
					this.dataWideExternalDataOORTime_43366.ShowHexValue = false;
					num = (short)2115567639;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 29:
					this.dataWideExternalDataModemHiddenNetwork_44814 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("裋꿍꓏돑菓뿕볗뿙駛ꛝ铟蟡難裥觧蛩꣫迭蓯鏱맳駵鳷鿹釻뛽槿昁怃挅昇䐉椋稍朏紑易紕䜗⸙⠛☝ᄟᘡ", a_), global::CommonResources.AcgResources.ID_HIDDENNETWORK);
					this.dataWideExternalDataModemHiddenNetwork_44814.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.dataWideExternalDataModemHiddenNetwork_44814.DataTransferOrder = 93;
					num = (short)976683026;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 30:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("裋꿍꓏돑菓뿕볗뿙釛駝\ud9df틡돣迥髧迩胫语華臱ꟳ韵賷鿹郻鋽槿瘁愃䀅稇按椋怍琏縑洓堕礗眙礛䄝ᐟᄡጣḥἧ", a_)))
					{
						num = (short)498335790;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_419;
				case 31:
					this.dataWideExternalDataModemSecurityType_43360 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("裋꿍꓏돑菓뿕볗뿙駛ꛝ铟蟡難裥觧蛩꣫迭蓯鏱맳駵鳷鿹釻귽旿愁焃琅愇縉甋娍椏我焓䤕Ⱇ⤙⼛⠝ဟ", a_), global::CommonResources.AcgResources.ID_SECURITYTYPE, global::Motorola.MackinawCPS.CoreFeatures.DataWide.LOVs.DataWideExternalDataModemSecurityType_43360LovStrs);
					this.dataWideExternalDataModemSecurityType_43360.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.dataWideExternalDataModemSecurityType_43360.DataTransferOrder = 82;
					num = (short)1216675861;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 32:
					goto IL_774;
				case 33:
					this.dataWideExternalDataModemNetworkSsid_43358 = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::AllFeatures.CodeplugGuid.b("裋꿍꓏돑菓뿕볗뿙駛ꛝ铟蟡難裥觧蛩꣫迭蓯鏱맳駵鳷鿹釻냽旿瘁猃椅稇愉弋納礏瘑䬓∕⬗⤙⤛☝", a_), global::CommonResources.AcgResources.ID_NETWORKSSID_1, 32);
					this.dataWideExternalDataModemNetworkSsid_43358.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.dataWideExternalDataModemNetworkSsid_43358.DataTransferOrder = 81;
					this.dataWideExternalDataModemNetworkSsid_43358.ValidateAcrossRecset = true;
					num = (short)498008068;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 34:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("裋꿍꓏돑菓뿕볗뿙釛駝\ud9df틡돣迥髧迩胫语華臱룳ꋵ뷷볹軻韽旿氁怃樅焇䐉洋挍甏䴑–┕⼗∙⨛", a_)))
					{
						num = (short)1692991496;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_20F;
				case 35:
					goto IL_419;
				case 36:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("裋꿍꓏돑菓뿕볗뿙駛냝菟郡鷣雥鳧迩裫ꃭ闯蛱菳駵諷釹곻鿽珿焁猃椅稇渉匋㨍⌏ℑ∓✕", a_)))
					{
						num = (short)1691090955;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_673;
				case 37:
					this.dataWideMG90WirelessSatelliteEnable_43788 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("裋꿍꓏돑菓뿕볗뿙釛駝\ud9df틡돣迥髧迩胫语華臱ꟳ韵賷鿹郻鋽槿瘁愃䌅昇欉渋戍甏䴑–┕⼗∙␛", a_), global::CommonResources.AcgResources.ID_MG90SATELLITEENABLED);
					this.dataWideMG90WirelessSatelliteEnable_43788.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.dataWideMG90WirelessSatelliteEnable_43788.DataTransferOrder = 91;
					num = (short)50003988;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 38:
					num = (short)228327425;
					if (num != 0)
					{
					}
					this.dataWideExternalDataModemType_43362 = new global::AcpBusinessLayer.AcpListField(1, this, global::AllFeatures.CodeplugGuid.b("裋꿍꓏돑菓뿕볗뿙駛ꛝ铟蟡難裥觧蛩꣫迭蓯鏱맳駵鳷鿹釻꫽秿爁愃夅㰇㤉㼋㠍∏", a_), global::CommonResources.AcgResources.ID_MODEMTYPE, true, global::Motorola.MackinawCPS.CoreFeatures.DataWide.LOVs.DataWideExternalDataModemType_43362LovStrs);
					this.dataWideExternalDataModemType_43362.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.dataWideExternalDataModemType_43362.DataTransferOrder = 84;
					num = (short)211746823;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 39:
				{
					this.dataWideMG90WirelessVPNFriendlyName_43785 = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::AllFeatures.CodeplugGuid.b("裋꿍꓏돑菓뿕볗뿙釛駝\ud9df틡돣迥髧迩胫语華臱ꋳ꛵뛷볹軻韽旿氁怃樅焇䐉洋挍甏䴑–┕⼗∙⤛", a_), global::CommonResources.AcgResources.ID_MG90MODEMVPNFRIENDLYNAME, 128);
					this.dataWideMG90WirelessVPNFriendlyName_43785.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.dataWideMG90WirelessVPNFriendlyName_43785.DataTransferOrder = 89;
					num = (short)504758272;
					short num4 = num;
					num = (short)220987417;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 40:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("裋꿍꓏돑菓뿕볗뿙駛ꛝ铟蟡難裥觧蛩꣫迭蓯鏱ꋳ蛵雷껹觻都滿朁栃夅㰇㤉㼋㠍┏", a_)))
					{
						num = (short)1818558488;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_166;
				case 41:
					goto IL_A8C;
				case 42:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("裋꿍꓏돑菓뿕볗뿙駛ꛝ铟蟡難裥觧蛩꣫迭蓯鏱맳駵鳷鿹釻귽旿愁焃琅愇縉甋娍椏我焓䤕Ⱇ⤙⼛⠝ဟ", a_)))
					{
						num = (short)49086495;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3CA;
				case 43:
					num = (short)471728129;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 44:
					goto IL_20F;
				case 45:
					goto IL_673;
				case 46:
					this.dataWideMG90WirelessSatelliteFriendlyName_43787 = new global::AcpBusinessLayer.AcpStringField(global::AllFeatures.CodeplugGuid.b("鿋迍蓏", a_), this, global::AllFeatures.CodeplugGuid.b("裋꿍꓏돑菓뿕볗뿙釛駝\ud9df틡돣迥髧迩胫语華臱ꟳ韵賷鿹郻鋽槿瘁愃䀅稇按椋怍琏縑洓堕礗眙礛䄝ᐟᄡጣḥἧ", a_), global::CommonResources.AcgResources.ID_MG90SATELLITEFRIENDLYNAME, 128);
					this.dataWideMG90WirelessSatelliteFriendlyName_43787.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.dataWideMG90WirelessSatelliteFriendlyName_43787.DataTransferOrder = 92;
					num = (short)998703139;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 47:
					goto IL_119;
				case 48:
					this.dataWideEncryptedModemPassword_43361 = new global::AcpBusinessLayer.AcpFieldX<string, string>(global::AllFeatures.CodeplugGuid.b("﷋迍飝\ud8df훡틣폥\ud8e7\udde9꣫ퟭ짯쇱엳웵짷뻹짻췽㓿㜁䜃䌅䴇㤉䴋䰍匏向儓⌕⸗⸙␛尝感ᬡሣጥ渧ሩ洫Ἥد猱ܳ猵縷礹缻ఽؿс睃癅筇౉๋睍", a_), new global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataModemPasswordEncryptDecryptConverter(), this, global::AllFeatures.CodeplugGuid.b("裋꿍꓏돑菓뿕볗뿙駛냝菟郡鷣雥鳧迩裫ꏭ鿯雱釳鯵ꣷ鯹迻跽矿洁瘃戅圇㸉㼋㴍☏⌑", a_), global::CommonResources.AcgResources.ID_MODEMPASSWORD);
					this.dataWideEncryptedModemPassword_43361.IgnoreOnCompare = true;
					this.dataWideEncryptedModemPassword_43361.IsMasked = false;
					this.dataWideEncryptedModemPassword_43361.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.dataWideEncryptedModemPassword_43361.DataTransferOrder = -1;
					goto IL_51E;
				}
				IL_F3:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1996750891;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_119:
				num = (short)725811214;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_166:
				num = (short)1495990288;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_20F:
				num = (short)1541275678;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_25D:
				num = (short)1818886170;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3CA:
				num = (short)1804337188;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_419:
				num = (short)1520435200;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_51E:
				num = (short)792264736;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_574:
				num = (short)1816264746;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_673:
				num = (short)792068118;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_727:
				num = (short)2133327906;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_774:
				num = (short)992608271;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_7C2:
				num = (short)474873862;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_80B:
				num = (short)1165623305;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_A8C:
				num = (short)55181352;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_C18:
				num = (short)1995898890;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_4B7:
			IL_C61:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("裋꿍꓏돑鯕럗뻙맛돝샟뛡藣蓥蓧迩", a_);
			base.Id = 10851;
			base.UIName = global::CommonResources.AcgResources.ID_DATAMODEMTABLE;
			base.DataTransferOrder = 4;
		}

		// Token: 0x0600A10B RID: 41227 RVA: 0x00969384 File Offset: 0x00967584
		public override void PopulateReferences()
		{
			short num = (short)1204880422;
			short num2 = num;
			num = (short)162399270;
			switch (num2 == num)
			{
			default:
			{
				num = (short)965935104;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1889402881;
			if (num != 0)
			{
			}
			num = (short)140443648;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600A10C RID: 41228 RVA: 0x00969430 File Offset: 0x00967630
		public override void DropReferences()
		{
			short num = (short)1151402443;
			short num2 = num;
			num = (short)766181835;
			switch (num2 == num)
			{
			default:
			{
				num = (short)310771712;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1539440641;
			if (num != 0)
			{
			}
			num = (short)1790771200;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600A10D RID: 41229 RVA: 0x009694D8 File Offset: 0x009676D8
		public override void SetConstraints()
		{
			short num = (short)1499732593;
			short num2 = num;
			num = (short)2078349937;
			switch (num2 == num)
			{
			default:
			{
				num = (short)811073536;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1786380289;
			if (num != 0)
			{
			}
			num = (short)533004288;
			if (num != 0)
			{
			}
			this.dataWideExternalDataModemNetworkPriority_43358.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.ConActionExternalDataModemType);
			this.dataWideExternalDataModemNetworkSsid_43358.ValidateAcrossRecset = true;
			this.dataWideExternalDataModemNetworkSsid_43358.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.ConActionExternalDataModemType);
			this.dataWideExternalDataModemNetworkSsid_43358.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.ConExternalDataModemWiFiSSIDIsValid);
			this.dataWideExternalDataModemNetworkSsid_43358.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.ConExternalDataModemClearWiFiPwdWhenSsidChange);
			this.dataWideExternalDataModemSecurityType_43360.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.ConActionExternalDataModemType);
			this.dataWideExternalDataModemSecurityType_43360.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.ConExternalDataModemClearWiFiPwd);
			this.dataWideEncryptedNetworkPassword_43361.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.WifiDataModemPasswordApplicability);
			this.dataWideEncryptedNetworkPassword_43361.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.ConExternalDataModemWiFiPasswordIsValid);
			this.dataWideExternalDataModemType_43362.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.ConActionExternalDataModemType);
			this.dataWideEncryptedModemPassword_43361.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.ConIsSierraWirlessModemSelected);
			this.dataWideEncryptedModemPassword_43361.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.ConExternalDataModemPasswordIsValid);
			this.dataWideEncryptedModemPassword_43361.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.ConActionExternalDataModemType);
			this.dataWideExternalDataModemPort.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.ConActionExternalDataModemType);
			this.dataWideExternalDataModemPort.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.ConActionIsWifiDataModemPortValid);
			this.dataWideExternalDataVpnTunnel_43365.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.ConIsSierraWirlessModemSelected);
			this.dataWideExternalDataOORTime_43366.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.ConActionExternalDataModemType);
			this.dataWideExternalDataModemOpenTime_43367.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.ConActionExternalDataModemType);
			this.dataWideMG90WirelessVPNFriendlyName_43785.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.ConWirelessModeAndModemTypeIsSierraWirelessMG90);
			this.dataWideMG90WirelessVPNFriendlyName_43785.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.ConModemWirelessVPNFriendlyNameIsValid);
			this.dataWideMG90WirelessLTEFriendlyName_43786.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.ConWirelessModeAndModemTypeIsSierraWirelessMG90);
			this.dataWideMG90WirelessLTEFriendlyName_43786.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.ConModemWirelessLTEFriendlyNameIsValid);
			this.dataWideMG90WirelessSatelliteEnable_43788.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.ConWirelessModeAndModemTypeIsSierraWirelessMG90);
			this.dataWideMG90WirelessSatelliteFriendlyName_43787.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.ConMG90SatelliteEnabledAndWirelessModeAndModemTypeIsSierraWirelessMG90);
			this.dataWideMG90WirelessSatelliteFriendlyName_43787.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.ConWirelessMG90SatelliteFriendlyNameIsValid);
			this.dataWideExternalDataModemHiddenNetwork_44814.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.ConActionExternalDataModemType);
		}

		// Token: 0x0600A10E RID: 41230 RVA: 0x009697CC File Offset: 0x009679CC
		public override void SetupDependencies()
		{
			short num = (short)1405930880;
			short num2 = num;
			num = (short)2124991872;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1248133120;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1274740737;
			if (num != 0)
			{
			}
			num = (short)920256512;
			if (num != 0)
			{
			}
		}

		// Token: 0x1700509C RID: 20636
		// (get) Token: 0x0600A10F RID: 41231 RVA: 0x00969874 File Offset: 0x00967A74
		public bool HasDiffs
		{
			get
			{
				short num = (short)1849313036;
				short num2 = num;
				num = (short)1913800460;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1359085568;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1146421249;
				if (num != 0)
				{
				}
				num = (short)246087680;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x1700509D RID: 20637
		// (get) Token: 0x0600A110 RID: 41232 RVA: 0x00969920 File Offset: 0x00967B20
		// (set) Token: 0x0600A111 RID: 41233 RVA: 0x009699D4 File Offset: 0x00967BD4
		public int DataWideExternalDataModemNetworkPriority_43358Value
		{
			get
			{
				short num = (short)357844577;
				short num2 = num;
				num = (short)1727874657;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1174208512;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)55574529;
				if (num != 0)
				{
				}
				num = (short)1494941696;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemNetworkPriority_43358.Value;
			}
			set
			{
				short num = (short)1596967047;
				short num2 = num;
				num = (short)505661575;
				switch (num2 == num)
				{
				default:
				{
					num = (short)164102144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1494286337;
				if (num != 0)
				{
				}
				num = (short)1324744704;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemNetworkPriority_43358.Value = value;
			}
		}

		// Token: 0x1700509E RID: 20638
		// (get) Token: 0x0600A112 RID: 41234 RVA: 0x00969A88 File Offset: 0x00967C88
		public global::AcpBusinessLayer.AcpSimpleRangeField DataWideExternalDataModemNetworkPriority_43358
		{
			get
			{
				short num = (short)2146743906;
				short num2 = num;
				num = (short)1489548898;
				switch (num2 == num)
				{
				default:
				{
					num = (short)861011968;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)417267713;
				if (num != 0)
				{
				}
				num = (short)1436352512;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemNetworkPriority_43358;
			}
		}

		// Token: 0x1700509F RID: 20639
		// (get) Token: 0x0600A113 RID: 41235 RVA: 0x00969B38 File Offset: 0x00967D38
		// (set) Token: 0x0600A114 RID: 41236 RVA: 0x00969BEC File Offset: 0x00967DEC
		public string DataWideExternalDataModemNetworkPriority_43358_UIValue
		{
			get
			{
				short num = (short)454950913;
				if (num != 0)
				{
				}
				num = (short)1745879040;
				short num2 = num;
				num = (short)1225695440;
				short num3 = num;
				num = (short)1630183632;
				switch (num3 == num)
				{
				}
				num = (short)905379840;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemNetworkPriority_43358.UIValue;
			}
			set
			{
				short num = (short)846899601;
				short num2 = num;
				num = (short)1946593681;
				switch (num2 == num)
				{
				default:
				{
					num = (short)650182656;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)433651713;
				if (num != 0)
				{
				}
				num = (short)1655635968;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemNetworkPriority_43358.UIValue = value;
			}
		}

		// Token: 0x170050A0 RID: 20640
		// (get) Token: 0x0600A115 RID: 41237 RVA: 0x00969CA0 File Offset: 0x00967EA0
		// (set) Token: 0x0600A116 RID: 41238 RVA: 0x00969D54 File Offset: 0x00967F54
		internal int DataWideExternalDataModemNetworkPriority_43358Min
		{
			get
			{
				short num = (short)1897819051;
				short num2 = num;
				num = (short)33254315;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1830617088;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1138688001;
				if (num != 0)
				{
				}
				num = (short)836108288;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemNetworkPriority_43358.Min;
			}
			set
			{
				short num = (short)231805313;
				short num2 = num;
				num = (short)348000641;
				switch (num2 == num)
				{
				default:
				{
					num = (short)3276800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1249247232;
				if (num != 0)
				{
				}
				num = (short)384761857;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemNetworkPriority_43358.Min = value;
			}
		}

		// Token: 0x170050A1 RID: 20641
		// (get) Token: 0x0600A117 RID: 41239 RVA: 0x00969E0C File Offset: 0x0096800C
		// (set) Token: 0x0600A118 RID: 41240 RVA: 0x00969EC0 File Offset: 0x009680C0
		internal int DataWideExternalDataModemNetworkPriority_43358Max
		{
			get
			{
				short num = (short)54482068;
				short num2 = num;
				num = (short)110384276;
				switch (num2 == num)
				{
				default:
				{
					num = (short)851050496;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)488898561;
				if (num != 0)
				{
				}
				num = (short)366084096;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemNetworkPriority_43358.Max;
			}
			set
			{
				short num = (short)662646524;
				short num2 = num;
				num = (short)766848764;
				switch (num2 == num)
				{
				default:
				{
					num = (short)123142144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)551157761;
				if (num != 0)
				{
				}
				num = (short)1035796480;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemNetworkPriority_43358.Max = value;
			}
		}

		// Token: 0x170050A2 RID: 20642
		// (get) Token: 0x0600A119 RID: 41241 RVA: 0x00969F74 File Offset: 0x00968174
		// (set) Token: 0x0600A11A RID: 41242 RVA: 0x0096A028 File Offset: 0x00968228
		internal int DataWideExternalDataModemNetworkPriority_43358Step
		{
			get
			{
				short num = (short)280970571;
				short num2 = num;
				num = (short)744899915;
				switch (num2 == num)
				{
				default:
				{
					num = (short)777912320;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)57606145;
				if (num != 0)
				{
				}
				num = (short)1870462976;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemNetworkPriority_43358.StepSize;
			}
			set
			{
				short num = (short)328949779;
				short num2 = num;
				num = (short)1625120787;
				switch (num2 == num)
				{
				default:
				{
					num = (short)525271040;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)541786113;
				if (num != 0)
				{
				}
				num = (short)847642624;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemNetworkPriority_43358.StepSize = value;
			}
		}

		// Token: 0x170050A3 RID: 20643
		// (get) Token: 0x0600A11B RID: 41243 RVA: 0x0096A0DC File Offset: 0x009682DC
		// (set) Token: 0x0600A11C RID: 41244 RVA: 0x0096A190 File Offset: 0x00968390
		public bool DataWideExternalDataModemNetworkPriority_43358_Applicable
		{
			get
			{
				short num = (short)1194810252;
				short num2 = num;
				num = (short)81288076;
				switch (num2 == num)
				{
				default:
				{
					num = (short)570359808;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)382861313;
				if (num != 0)
				{
				}
				num = (short)1071972352;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemNetworkPriority_43358.Applicable;
			}
			set
			{
				short num = (short)1001322497;
				short num2 = num;
				num = (short)416217089;
				switch (num2 == num)
				{
				default:
				{
					num = (short)118161408;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1058996224;
				if (num != 0)
				{
				}
				num = (short)1821376513;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemNetworkPriority_43358.Applicable = value;
			}
		}

		// Token: 0x170050A4 RID: 20644
		// (get) Token: 0x0600A11D RID: 41245 RVA: 0x0096A248 File Offset: 0x00968448
		// (set) Token: 0x0600A11E RID: 41246 RVA: 0x0096A2FC File Offset: 0x009684FC
		public bool DataWideExternalDataModemNetworkPriority_43358_Valid
		{
			get
			{
				short num = (short)50571887;
				short num2 = num;
				num = (short)496609903;
				switch (num2 == num)
				{
				default:
				{
					num = (short)158728192;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)718012416;
				if (num != 0)
				{
				}
				num = (short)928055297;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemNetworkPriority_43358.Valid;
			}
			set
			{
				short num = (short)1688296070;
				short num2 = num;
				num = (short)168974982;
				switch (num2 == num)
				{
				default:
				{
					num = (short)384172032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)635699200;
				if (num != 0)
				{
				}
				num = (short)1431699457;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemNetworkPriority_43358.Valid = value;
			}
		}

		// Token: 0x170050A5 RID: 20645
		// (get) Token: 0x0600A11F RID: 41247 RVA: 0x0096A3B4 File Offset: 0x009685B4
		// (set) Token: 0x0600A120 RID: 41248 RVA: 0x0096A468 File Offset: 0x00968668
		public bool DataWideExternalDataModemNetworkPriority_43358_Visible
		{
			get
			{
				short num = (short)1381646157;
				short num2 = num;
				num = (short)1739734861;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1072168960;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1795227649;
				if (num != 0)
				{
				}
				num = (short)125042688;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemNetworkPriority_43358.Visible;
			}
			set
			{
				short num = (short)375048346;
				short num2 = num;
				num = (short)1863305370;
				switch (num2 == num)
				{
				default:
				{
					num = (short)462225408;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1417150465;
				if (num != 0)
				{
				}
				num = (short)160563200;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemNetworkPriority_43358.Visible = value;
			}
		}

		// Token: 0x170050A6 RID: 20646
		// (get) Token: 0x0600A121 RID: 41249 RVA: 0x0096A51C File Offset: 0x0096871C
		// (set) Token: 0x0600A122 RID: 41250 RVA: 0x0096A5D4 File Offset: 0x009687D4
		public bool DataWideExternalDataModemNetworkPriority_43358_Editable
		{
			get
			{
				short num = (short)75020539;
				short num2 = num;
				num = (short)631814395;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1089208320;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1634467840;
				if (num != 0)
				{
				}
				num = (short)1554513921;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemNetworkPriority_43358.Editable;
			}
			set
			{
				short num = (short)1429561639;
				short num2 = num;
				num = (short)1728209191;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1867841536;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1224278017;
				if (num != 0)
				{
				}
				num = (short)1919025152;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemNetworkPriority_43358.Editable = value;
			}
		}

		// Token: 0x170050A7 RID: 20647
		// (get) Token: 0x0600A123 RID: 41251 RVA: 0x0096A688 File Offset: 0x00968888
		internal string DataWideExternalDataModemNetworkPriority_43358_UILabel
		{
			get
			{
				short num = (short)623254193;
				short num2 = num;
				num = (short)51387057;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1519190016;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1103429633;
				if (num != 0)
				{
				}
				num = (short)1347092480;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemNetworkPriority_43358.UIName;
			}
		}

		// Token: 0x170050A8 RID: 20648
		// (get) Token: 0x0600A124 RID: 41252 RVA: 0x0096A73C File Offset: 0x0096893C
		// (set) Token: 0x0600A125 RID: 41253 RVA: 0x0096A7EC File Offset: 0x009689EC
		internal bool DataWideExternalDataModemNetworkPriority_43358_HiddenStatic
		{
			get
			{
				short num = (short)366877932;
				short num2 = num;
				num = (short)1111039212;
				switch (num2 == num)
				{
				default:
				{
					num = (short)669253632;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1687814144;
				if (num != 0)
				{
				}
				num = (short)1754791937;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemNetworkPriority_43358.HiddenStatic;
			}
			set
			{
				short num = (short)1778484387;
				short num2 = num;
				num = (short)1858897059;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1820459008;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)826605569;
				if (num != 0)
				{
				}
				num = (short)88014848;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemNetworkPriority_43358.HiddenStatic = value;
			}
		}

		// Token: 0x170050A9 RID: 20649
		// (get) Token: 0x0600A126 RID: 41254 RVA: 0x0096A8A4 File Offset: 0x00968AA4
		// (set) Token: 0x0600A127 RID: 41255 RVA: 0x0096A958 File Offset: 0x00968B58
		internal bool DataWideExternalDataModemNetworkPriority_43358_HiddenDynamic
		{
			get
			{
				short num = (short)1881872109;
				short num2 = num;
				num = (short)1794643693;
				switch (num2 == num)
				{
				default:
				{
					num = (short)643694592;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)387973120;
				if (num != 0)
				{
				}
				num = (short)1112145921;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemNetworkPriority_43358.HiddenDynamic;
			}
			set
			{
				short num = (short)678317634;
				short num2 = num;
				num = (short)1603227202;
				switch (num2 == num)
				{
				default:
				{
					num = (short)96206848;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1438777344;
				if (num != 0)
				{
				}
				num = (short)1140195329;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemNetworkPriority_43358.HiddenDynamic = value;
			}
		}

		// Token: 0x170050AA RID: 20650
		// (get) Token: 0x0600A128 RID: 41256 RVA: 0x0096AA10 File Offset: 0x00968C10
		public bool DataWideExternalDataModemNetworkPriority_43358_HasDiffs
		{
			get
			{
				short num = (short)698391241;
				short num2 = num;
				num = (short)12360393;
				switch (num2 == num)
				{
				default:
				{
					num = (short)39911424;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)172490753;
				if (num != 0)
				{
				}
				num = (short)1601568768;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemNetworkPriority_43358._HasDiffs;
			}
		}

		// Token: 0x170050AB RID: 20651
		// (get) Token: 0x0600A129 RID: 41257 RVA: 0x0096AAC4 File Offset: 0x00968CC4
		// (set) Token: 0x0600A12A RID: 41258 RVA: 0x0096AB78 File Offset: 0x00968D78
		public string DataWideExternalDataModemNetworkSsid_43358Value
		{
			get
			{
				short num = (short)753402871;
				short num2 = num;
				num = (short)1648624631;
				switch (num2 == num)
				{
				default:
				{
					num = (short)879755264;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)937623552;
				if (num != 0)
				{
				}
				num = (short)1222967297;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemNetworkSsid_43358.Value;
			}
			set
			{
				short num = (short)275018204;
				short num2 = num;
				num = (short)247165404;
				switch (num2 == num)
				{
				default:
				{
					num = (short)291831808;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1582825473;
				if (num != 0)
				{
				}
				num = (short)1743978496;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemNetworkSsid_43358.Value = value;
			}
		}

		// Token: 0x170050AC RID: 20652
		// (get) Token: 0x0600A12B RID: 41259 RVA: 0x0096AC30 File Offset: 0x00968E30
		public global::AcpBusinessLayer.AcpField<string> DataWideExternalDataModemNetworkSsid_43358
		{
			get
			{
				short num = (short)1190283777;
				short num2 = num;
				num = (short)1863469569;
				switch (num2 == num)
				{
				default:
				{
					num = (short)90046464;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)544276481;
				if (num != 0)
				{
				}
				num = (short)1482096640;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemNetworkSsid_43358;
			}
		}

		// Token: 0x170050AD RID: 20653
		// (get) Token: 0x0600A12C RID: 41260 RVA: 0x0096ACE0 File Offset: 0x00968EE0
		// (set) Token: 0x0600A12D RID: 41261 RVA: 0x0096AD98 File Offset: 0x00968F98
		public string DataWideExternalDataModemNetworkSsid_43358_UIValue
		{
			get
			{
				short num = (short)927765198;
				short num2 = num;
				num = (short)1214878414;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1774845952;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1133707265;
				if (num != 0)
				{
				}
				num = (short)255918080;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemNetworkSsid_43358.Value;
			}
			set
			{
				short num = (short)449953011;
				short num2 = num;
				num = (short)383565043;
				switch (num2 == num)
				{
				default:
				{
					num = (short)384761856;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1561395201;
				if (num != 0)
				{
				}
				num = (short)1188233216;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemNetworkSsid_43358.Value = value;
			}
		}

		// Token: 0x170050AE RID: 20654
		// (get) Token: 0x0600A12E RID: 41262 RVA: 0x0096AE50 File Offset: 0x00969050
		// (set) Token: 0x0600A12F RID: 41263 RVA: 0x0096AF04 File Offset: 0x00969104
		public bool DataWideExternalDataModemNetworkSsid_43358_Applicable
		{
			get
			{
				short num = (short)1902235566;
				short num2 = num;
				num = (short)617074606;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1754202112;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)836108289;
				if (num != 0)
				{
				}
				num = (short)2064384000;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemNetworkSsid_43358.Applicable;
			}
			set
			{
				short num = (short)1878628487;
				short num2 = num;
				num = (short)827758727;
				switch (num2 == num)
				{
				}
				num = (short)1339686913;
				if (num != 0)
				{
				}
				num = (short)1838809088;
				short num3 = num;
				num = (short)2118451200;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemNetworkSsid_43358.Applicable = value;
			}
		}

		// Token: 0x170050AF RID: 20655
		// (get) Token: 0x0600A130 RID: 41264 RVA: 0x0096AFB8 File Offset: 0x009691B8
		// (set) Token: 0x0600A131 RID: 41265 RVA: 0x0096B06C File Offset: 0x0096926C
		public bool DataWideExternalDataModemNetworkSsid_43358_Valid
		{
			get
			{
				short num = (short)462458992;
				short num2 = num;
				num = (short)491819120;
				switch (num2 == num)
				{
				}
				num = (short)2025717761;
				if (num != 0)
				{
				}
				num = (short)1726808064;
				short num3 = num;
				num = (short)1533476864;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemNetworkSsid_43358.Valid;
			}
			set
			{
				short num = (short)1081596417;
				short num2 = num;
				num = (short)869194241;
				switch (num2 == num)
				{
				}
				num = (short)1636499457;
				if (num != 0)
				{
				}
				num = (short)185729024;
				short num3 = num;
				num = (short)885325824;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemNetworkSsid_43358.Valid = value;
			}
		}

		// Token: 0x170050B0 RID: 20656
		// (get) Token: 0x0600A132 RID: 41266 RVA: 0x0096B124 File Offset: 0x00969324
		// (set) Token: 0x0600A133 RID: 41267 RVA: 0x0096B1D8 File Offset: 0x009693D8
		public bool DataWideExternalDataModemNetworkSsid_43358_Visible
		{
			get
			{
				short num = (short)1801831666;
				short num2 = num;
				num = (short)721536242;
				switch (num2 == num)
				{
				}
				num = (short)367984641;
				if (num != 0)
				{
				}
				num = (short)1661992960;
				short num3 = num;
				num = (short)17235968;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemNetworkSsid_43358.Visible;
			}
			set
			{
				short num = (short)2073121331;
				short num2 = num;
				num = (short)891245107;
				switch (num2 == num)
				{
				}
				num = (short)693370880;
				if (num != 0)
				{
				}
				num = (short)966524928;
				short num3 = num;
				num = (short)1875378177;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemNetworkSsid_43358.Visible = value;
			}
		}

		// Token: 0x170050B1 RID: 20657
		// (get) Token: 0x0600A134 RID: 41268 RVA: 0x0096B28C File Offset: 0x0096948C
		// (set) Token: 0x0600A135 RID: 41269 RVA: 0x0096B344 File Offset: 0x00969544
		public bool DataWideExternalDataModemNetworkSsid_43358_Editable
		{
			get
			{
				short num = (short)1942574136;
				short num2 = num;
				num = (short)466310200;
				switch (num2 == num)
				{
				}
				num = (short)147652609;
				if (num != 0)
				{
				}
				num = (short)1086717952;
				short num3 = num;
				num = (short)1149108224;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemNetworkSsid_43358.Editable;
			}
			set
			{
				short num = (short)896792431;
				short num2 = num;
				num = (short)565704559;
				switch (num2 == num)
				{
				}
				num = (short)892010496;
				if (num != 0)
				{
				}
				num = (short)1438121984;
				short num3 = num;
				num = (short)717094913;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemNetworkSsid_43358.Editable = value;
			}
		}

		// Token: 0x170050B2 RID: 20658
		// (get) Token: 0x0600A136 RID: 41270 RVA: 0x0096B3FC File Offset: 0x009695FC
		internal string DataWideExternalDataModemNetworkSsid_43358_UILabel
		{
			get
			{
				short num = (short)1930297345;
				if (num != 0)
				{
				}
				num = (short)646633787;
				short num2 = num;
				num = (short)1621940539;
				switch (num2 == num)
				{
				}
				num = (short)11468800;
				short num3 = num;
				num = (short)1950613504;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemNetworkSsid_43358.UIName;
			}
		}

		// Token: 0x170050B3 RID: 20659
		// (get) Token: 0x0600A137 RID: 41271 RVA: 0x0096B4B0 File Offset: 0x009696B0
		// (set) Token: 0x0600A138 RID: 41272 RVA: 0x0096B564 File Offset: 0x00969764
		internal bool DataWideExternalDataModemNetworkSsid_43358_HiddenStatic
		{
			get
			{
				short num = (short)388474687;
				short num2 = num;
				num = (short)1632020287;
				switch (num2 == num)
				{
				}
				num = (short)2063204353;
				if (num != 0)
				{
				}
				num = (short)743702528;
				short num3 = num;
				num = (short)258867200;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemNetworkSsid_43358.HiddenStatic;
			}
			set
			{
				short num = (short)2131757141;
				short num2 = num;
				num = (short)352454741;
				switch (num2 == num)
				{
				}
				num = (short)1608974336;
				if (num != 0)
				{
				}
				num = (short)2050686976;
				short num3 = num;
				num = (short)94502913;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemNetworkSsid_43358.HiddenStatic = value;
			}
		}

		// Token: 0x170050B4 RID: 20660
		// (get) Token: 0x0600A139 RID: 41273 RVA: 0x0096B620 File Offset: 0x00969820
		// (set) Token: 0x0600A13A RID: 41274 RVA: 0x0096B6D4 File Offset: 0x009698D4
		internal bool DataWideExternalDataModemNetworkSsid_43358_HiddenDynamic
		{
			get
			{
				short num = (short)838985407;
				short num2 = num;
				num = (short)1915938495;
				switch (num2 == num)
				{
				}
				num = (short)1027538945;
				if (num != 0)
				{
				}
				num = (short)144637952;
				short num3 = num;
				num = (short)1793785856;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemNetworkSsid_43358.HiddenDynamic;
			}
			set
			{
				short num = (short)774549389;
				short num2 = num;
				num = (short)376811405;
				switch (num2 == num)
				{
				}
				num = (short)1022820352;
				if (num != 0)
				{
				}
				num = (short)1037565952;
				short num3 = num;
				num = (short)285999105;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemNetworkSsid_43358.HiddenDynamic = value;
			}
		}

		// Token: 0x170050B5 RID: 20661
		// (get) Token: 0x0600A13B RID: 41275 RVA: 0x0096B788 File Offset: 0x00969988
		public bool DataWideExternalDataModemNetworkSsid_43358_HasDiffs
		{
			get
			{
				short num = (short)51660503;
				short num2 = num;
				num = (short)23217879;
				switch (num2 == num)
				{
				}
				num = (short)995819521;
				if (num != 0)
				{
				}
				num = (short)888209408;
				short num3 = num;
				num = (short)1853489152;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemNetworkSsid_43358._HasDiffs;
			}
		}

		// Token: 0x170050B6 RID: 20662
		// (get) Token: 0x0600A13C RID: 41276 RVA: 0x0096B83C File Offset: 0x00969A3C
		// (set) Token: 0x0600A13D RID: 41277 RVA: 0x0096B8F4 File Offset: 0x00969AF4
		public int DataWideExternalDataModemSecurityType_43360Value
		{
			get
			{
				short num = (short)798551846;
				short num2 = num;
				num = (short)910618406;
				switch (num2 == num)
				{
				}
				num = (short)1764491265;
				if (num != 0)
				{
				}
				num = (short)396492800;
				short num3 = num;
				num = (short)435224576;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemSecurityType_43360.Value;
			}
			set
			{
				short num = (short)751644014;
				short num2 = num;
				num = (short)1724198254;
				switch (num2 == num)
				{
				}
				num = (short)1287847936;
				if (num != 0)
				{
				}
				num = (short)506920960;
				short num3 = num;
				num = (short)1431633921;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemSecurityType_43360.Value = value;
			}
		}

		// Token: 0x170050B7 RID: 20663
		// (get) Token: 0x0600A13E RID: 41278 RVA: 0x0096B9AC File Offset: 0x00969BAC
		// (set) Token: 0x0600A13F RID: 41279 RVA: 0x0096BA60 File Offset: 0x00969C60
		public string DataWideExternalDataModemSecurityType_43360_UIValue
		{
			get
			{
				short num = (short)17726105;
				short num2 = num;
				num = (short)1560705689;
				switch (num2 == num)
				{
				}
				num = (short)2010120193;
				if (num != 0)
				{
				}
				num = (short)2141388800;
				short num3 = num;
				num = (short)1457455104;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemSecurityType_43360.UIValue;
			}
			set
			{
				short num = (short)461874322;
				short num2 = num;
				num = (short)379036818;
				switch (num2 == num)
				{
				}
				num = (short)285409281;
				if (num != 0)
				{
				}
				num = (short)186122240;
				short num3 = num;
				num = (short)1062731776;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemSecurityType_43360.UIValue = value;
			}
		}

		// Token: 0x170050B8 RID: 20664
		// (get) Token: 0x0600A140 RID: 41280 RVA: 0x0096BB18 File Offset: 0x00969D18
		public global::AcpBusinessLayer.AcpListField DataWideExternalDataModemSecurityType_43360
		{
			get
			{
				short num = (short)1600243244;
				short num2 = num;
				num = (short)1071629868;
				switch (num2 == num)
				{
				}
				num = (short)19595264;
				if (num != 0)
				{
				}
				num = (short)982843392;
				short num3 = num;
				num = (short)221315073;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemSecurityType_43360;
			}
		}

		// Token: 0x170050B9 RID: 20665
		// (get) Token: 0x0600A141 RID: 41281 RVA: 0x0096BBC8 File Offset: 0x00969DC8
		// (set) Token: 0x0600A142 RID: 41282 RVA: 0x0096BC80 File Offset: 0x00969E80
		public bool DataWideExternalDataModemSecurityType_43360_Applicable
		{
			get
			{
				short num = (short)1250342224;
				short num2 = num;
				num = (short)187938128;
				switch (num2 == num)
				{
				}
				num = (short)295239681;
				if (num != 0)
				{
				}
				num = (short)700448768;
				short num3 = num;
				num = (short)2050621440;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemSecurityType_43360.Applicable;
			}
			set
			{
				short num = (short)1987918732;
				short num2 = num;
				num = (short)122895244;
				switch (num2 == num)
				{
				}
				num = (short)1389887489;
				if (num != 0)
				{
				}
				num = (short)1725497344;
				short num3 = num;
				num = (short)919535616;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemSecurityType_43360.Applicable = value;
			}
		}

		// Token: 0x170050BA RID: 20666
		// (get) Token: 0x0600A143 RID: 41283 RVA: 0x0096BD34 File Offset: 0x00969F34
		// (set) Token: 0x0600A144 RID: 41284 RVA: 0x0096BDE8 File Offset: 0x00969FE8
		public bool DataWideExternalDataModemSecurityType_43360_Valid
		{
			get
			{
				short num = (short)260524240;
				short num2 = num;
				num = (short)190728400;
				switch (num2 == num)
				{
				}
				num = (short)102760449;
				if (num != 0)
				{
				}
				num = (short)1174667264;
				short num3 = num;
				num = (short)1150681088;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemSecurityType_43360.Valid;
			}
			set
			{
				short num = (short)320911690;
				short num2 = num;
				num = (short)2130032970;
				switch (num2 == num)
				{
				}
				num = (short)1363673088;
				if (num != 0)
				{
				}
				num = (short)1584201728;
				short num3 = num;
				num = (short)1451622401;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemSecurityType_43360.Valid = value;
			}
		}

		// Token: 0x170050BB RID: 20667
		// (get) Token: 0x0600A145 RID: 41285 RVA: 0x0096BE9C File Offset: 0x0096A09C
		// (set) Token: 0x0600A146 RID: 41286 RVA: 0x0096BF50 File Offset: 0x0096A150
		public bool DataWideExternalDataModemSecurityType_43360_Visible
		{
			get
			{
				short num = (short)39301839;
				short num2 = num;
				num = (short)89764559;
				switch (num2 == num)
				{
				}
				num = (short)374538240;
				if (num != 0)
				{
				}
				num = (short)1388969984;
				short num3 = num;
				num = (short)1240530945;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemSecurityType_43360.Visible;
			}
			set
			{
				short num = (short)2027694623;
				short num2 = num;
				num = (short)2089298463;
				switch (num2 == num)
				{
				}
				num = (short)1971519489;
				if (num != 0)
				{
				}
				num = (short)755957760;
				short num3 = num;
				num = (short)1164902400;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemSecurityType_43360.Visible = value;
			}
		}

		// Token: 0x170050BC RID: 20668
		// (get) Token: 0x0600A147 RID: 41287 RVA: 0x0096C004 File Offset: 0x0096A204
		// (set) Token: 0x0600A148 RID: 41288 RVA: 0x0096C0B8 File Offset: 0x0096A2B8
		public bool DataWideExternalDataModemSecurityType_43360_Editable
		{
			get
			{
				short num = (short)942735361;
				if (num != 0)
				{
				}
				num = (short)803914174;
				short num2 = num;
				num = (short)226804158;
				switch (num2 == num)
				{
				}
				num = (short)1965031424;
				short num3 = num;
				num = (short)1572339712;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemSecurityType_43360.Editable;
			}
			set
			{
				short num = (short)1070707098;
				short num2 = num;
				num = (short)1206563226;
				switch (num2 == num)
				{
				}
				num = (short)145817601;
				if (num != 0)
				{
				}
				num = (short)241631232;
				short num3 = num;
				num = (short)2133655552;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemSecurityType_43360.Editable = value;
			}
		}

		// Token: 0x170050BD RID: 20669
		// (get) Token: 0x0600A149 RID: 41289 RVA: 0x0096C170 File Offset: 0x0096A370
		internal string DataWideExternalDataModemSecurityType_43360_UILabel
		{
			get
			{
				short num = (short)1230399520;
				short num2 = num;
				num = (short)88762400;
				switch (num2 == num)
				{
				}
				num = (short)803012609;
				if (num != 0)
				{
				}
				num = (short)648019968;
				short num3 = num;
				num = (short)424869888;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemSecurityType_43360.UIName;
			}
		}

		// Token: 0x170050BE RID: 20670
		// (get) Token: 0x0600A14A RID: 41290 RVA: 0x0096C224 File Offset: 0x0096A424
		// (set) Token: 0x0600A14B RID: 41291 RVA: 0x0096C2DC File Offset: 0x0096A4DC
		internal bool DataWideExternalDataModemSecurityType_43360_HiddenStatic
		{
			get
			{
				short num = (short)434832902;
				short num2 = num;
				num = (short)428541446;
				switch (num2 == num)
				{
				}
				num = (short)384303105;
				if (num != 0)
				{
				}
				num = (short)354287616;
				short num3 = num;
				num = (short)1572864000;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemSecurityType_43360.HiddenStatic;
			}
			set
			{
				short num = (short)851813785;
				short num2 = num;
				num = (short)1426761113;
				switch (num2 == num)
				{
				}
				num = (short)994312192;
				if (num != 0)
				{
				}
				num = (short)1899167744;
				short num3 = num;
				num = (short)453312513;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemSecurityType_43360.HiddenStatic = value;
			}
		}

		// Token: 0x170050BF RID: 20671
		// (get) Token: 0x0600A14C RID: 41292 RVA: 0x0096C390 File Offset: 0x0096A590
		// (set) Token: 0x0600A14D RID: 41293 RVA: 0x0096C444 File Offset: 0x0096A644
		internal bool DataWideExternalDataModemSecurityType_43360_HiddenDynamic
		{
			get
			{
				short num = (short)1923086798;
				short num2 = num;
				num = (short)583006670;
				switch (num2 == num)
				{
				}
				num = (short)897581056;
				if (num != 0)
				{
				}
				num = (short)1802633216;
				short num3 = num;
				num = (short)1475543041;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemSecurityType_43360.HiddenDynamic;
			}
			set
			{
				short num = (short)77594625;
				if (num != 0)
				{
				}
				num = (short)652068735;
				short num2 = num;
				num = (short)567396223;
				switch (num2 == num)
				{
				}
				num = (short)1926889472;
				short num3 = num;
				num = (short)1271660544;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemSecurityType_43360.HiddenDynamic = value;
			}
		}

		// Token: 0x170050C0 RID: 20672
		// (get) Token: 0x0600A14E RID: 41294 RVA: 0x0096C4FC File Offset: 0x0096A6FC
		public bool DataWideExternalDataModemSecurityType_43360_HasDiffs
		{
			get
			{
				short num = (short)1204142534;
				short num2 = num;
				num = (short)1228652998;
				switch (num2 == num)
				{
				}
				num = (short)1339293697;
				if (num != 0)
				{
				}
				num = (short)1747648512;
				short num3 = num;
				num = (short)316997632;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemSecurityType_43360._HasDiffs;
			}
		}

		// Token: 0x170050C1 RID: 20673
		// (get) Token: 0x0600A14F RID: 41295 RVA: 0x0096C5B0 File Offset: 0x0096A7B0
		// (set) Token: 0x0600A150 RID: 41296 RVA: 0x0096C664 File Offset: 0x0096A864
		public string DataWideEncryptedNetworkPassword_43361Value
		{
			get
			{
				short num = (short)9502721;
				if (num != 0)
				{
				}
				num = (short)1519874568;
				short num2 = num;
				num = (short)457142792;
				switch (num2 == num)
				{
				}
				num = (short)39387136;
				short num3 = num;
				num = (short)302055424;
				if (num != 0)
				{
				}
				return this.dataWideEncryptedNetworkPassword_43361.Value;
			}
			set
			{
				short num = (short)351535105;
				if (num != 0)
				{
				}
				num = (short)1025602972;
				short num2 = num;
				num = (short)841905564;
				switch (num2 == num)
				{
				}
				num = (short)1902575616;
				short num3 = num;
				num = (short)2133852160;
				if (num != 0)
				{
				}
				this.dataWideEncryptedNetworkPassword_43361.Value = value;
			}
		}

		// Token: 0x170050C2 RID: 20674
		// (get) Token: 0x0600A151 RID: 41297 RVA: 0x0096C718 File Offset: 0x0096A918
		public global::AcpBusinessLayer.AcpFieldX<string, string> DataWideEncryptedNetworkPassword_43361
		{
			get
			{
				short num = (short)1674037131;
				short num2 = num;
				num = (short)644859787;
				switch (num2 == num)
				{
				}
				num = (short)961740801;
				if (num != 0)
				{
				}
				num = (short)1849950208;
				short num3 = num;
				num = (short)490668032;
				if (num != 0)
				{
				}
				return this.dataWideEncryptedNetworkPassword_43361;
			}
		}

		// Token: 0x170050C3 RID: 20675
		// (get) Token: 0x0600A152 RID: 41298 RVA: 0x0096C7C8 File Offset: 0x0096A9C8
		// (set) Token: 0x0600A153 RID: 41299 RVA: 0x0096C87C File Offset: 0x0096AA7C
		public string DataWideEncryptedNetworkPassword_43361_UIValue
		{
			get
			{
				short num = (short)1521221633;
				if (num != 0)
				{
				}
				num = (short)308792091;
				short num2 = num;
				num = (short)1842531099;
				switch (num2 == num)
				{
				}
				num = (short)572719104;
				short num3 = num;
				num = (short)262995968;
				if (num != 0)
				{
				}
				return this.dataWideEncryptedNetworkPassword_43361.UIValue;
			}
			set
			{
				short num = (short)67509759;
				short num2 = num;
				num = (short)1721572863;
				switch (num2 == num)
				{
				}
				num = (short)1577582593;
				if (num != 0)
				{
				}
				num = (short)1885929472;
				short num3 = num;
				num = (short)151781376;
				if (num != 0)
				{
				}
				this.dataWideEncryptedNetworkPassword_43361.UIValue = value;
			}
		}

		// Token: 0x170050C4 RID: 20676
		// (get) Token: 0x0600A154 RID: 41300 RVA: 0x0096C930 File Offset: 0x0096AB30
		// (set) Token: 0x0600A155 RID: 41301 RVA: 0x0096C9E4 File Offset: 0x0096ABE4
		public bool DataWideEncryptedNetworkPassword_43361_Applicable
		{
			get
			{
				short num = (short)958136321;
				if (num != 0)
				{
				}
				num = (short)1435004;
				short num2 = num;
				num = (short)1928586620;
				switch (num2 == num)
				{
				}
				num = (short)811859968;
				short num3 = num;
				num = (short)1190133760;
				if (num != 0)
				{
				}
				return this.dataWideEncryptedNetworkPassword_43361.Applicable;
			}
			set
			{
				short num = (short)1519061075;
				short num2 = num;
				num = (short)510462035;
				switch (num2 == num)
				{
				}
				num = (short)1798766592;
				if (num != 0)
				{
				}
				num = (short)1700331520;
				short num3 = num;
				num = (short)2026897409;
				if (num != 0)
				{
				}
				this.dataWideEncryptedNetworkPassword_43361.Applicable = value;
			}
		}

		// Token: 0x170050C5 RID: 20677
		// (get) Token: 0x0600A156 RID: 41302 RVA: 0x0096CA98 File Offset: 0x0096AC98
		// (set) Token: 0x0600A157 RID: 41303 RVA: 0x0096CB50 File Offset: 0x0096AD50
		public bool DataWideEncryptedNetworkPassword_43361_Valid
		{
			get
			{
				short num = (short)765061909;
				short num2 = num;
				num = (short)1430842133;
				switch (num2 == num)
				{
				}
				num = (short)1569849344;
				if (num != 0)
				{
				}
				num = (short)1186398208;
				short num3 = num;
				num = (short)1636958209;
				if (num != 0)
				{
				}
				return this.dataWideEncryptedNetworkPassword_43361.Valid;
			}
			set
			{
				short num = (short)850710826;
				short num2 = num;
				num = (short)664785194;
				switch (num2 == num)
				{
				}
				num = (short)544866305;
				if (num != 0)
				{
				}
				num = (short)504037376;
				short num3 = num;
				num = (short)1331429376;
				if (num != 0)
				{
				}
				this.dataWideEncryptedNetworkPassword_43361.Valid = value;
			}
		}

		// Token: 0x170050C6 RID: 20678
		// (get) Token: 0x0600A158 RID: 41304 RVA: 0x0096CC08 File Offset: 0x0096AE08
		// (set) Token: 0x0600A159 RID: 41305 RVA: 0x0096CCBC File Offset: 0x0096AEBC
		public bool DataWideEncryptedNetworkPassword_43361_Visible
		{
			get
			{
				short num = (short)299622335;
				short num2 = num;
				num = (short)2123227071;
				switch (num2 == num)
				{
				}
				num = (short)1730543616;
				if (num != 0)
				{
				}
				num = (short)1229127680;
				short num3 = num;
				num = (short)1889206273;
				if (num != 0)
				{
				}
				return this.dataWideEncryptedNetworkPassword_43361.Visible;
			}
			set
			{
				short num = (short)924450817;
				if (num != 0)
				{
				}
				num = (short)1179630055;
				short num2 = num;
				num = (short)7453159;
				switch (num2 == num)
				{
				}
				num = (short)452001792;
				short num3 = num;
				num = (short)1104084992;
				if (num != 0)
				{
				}
				this.dataWideEncryptedNetworkPassword_43361.Visible = value;
			}
		}

		// Token: 0x170050C7 RID: 20679
		// (get) Token: 0x0600A15A RID: 41306 RVA: 0x0096CD74 File Offset: 0x0096AF74
		// (set) Token: 0x0600A15B RID: 41307 RVA: 0x0096CE28 File Offset: 0x0096B028
		public bool DataWideEncryptedNetworkPassword_43361_Editable
		{
			get
			{
				short num = (short)1663111771;
				short num2 = num;
				num = (short)1449136731;
				switch (num2 == num)
				{
				}
				num = (short)160497665;
				if (num != 0)
				{
				}
				num = (short)110821376;
				short num3 = num;
				num = (short)608043008;
				if (num != 0)
				{
				}
				return this.dataWideEncryptedNetworkPassword_43361.Editable;
			}
			set
			{
				short num = (short)1331181101;
				short num2 = num;
				num = (short)731330093;
				switch (num2 == num)
				{
				}
				num = (short)340525057;
				if (num != 0)
				{
				}
				num = (short)1721434112;
				short num3 = num;
				num = (short)970260480;
				if (num != 0)
				{
				}
				this.dataWideEncryptedNetworkPassword_43361.Editable = value;
			}
		}

		// Token: 0x170050C8 RID: 20680
		// (get) Token: 0x0600A15C RID: 41308 RVA: 0x0096CEDC File Offset: 0x0096B0DC
		internal string DataWideEncryptedNetworkPassword_43361_UILabel
		{
			get
			{
				short num = (short)1358746902;
				short num2 = num;
				num = (short)1818875158;
				switch (num2 == num)
				{
				}
				num = (short)2102919169;
				if (num != 0)
				{
				}
				num = (short)597229568;
				short num3 = num;
				num = (short)805306368;
				if (num != 0)
				{
				}
				return this.dataWideEncryptedNetworkPassword_43361.UIName;
			}
		}

		// Token: 0x170050C9 RID: 20681
		// (get) Token: 0x0600A15D RID: 41309 RVA: 0x0096CF90 File Offset: 0x0096B190
		// (set) Token: 0x0600A15E RID: 41310 RVA: 0x0096D044 File Offset: 0x0096B244
		internal bool DataWideEncryptedNetworkPassword_43361_HiddenStatic
		{
			get
			{
				short num = (short)154587157;
				short num2 = num;
				num = (short)392417301;
				switch (num2 == num)
				{
				}
				num = (short)2143879169;
				if (num != 0)
				{
				}
				num = (short)583991296;
				short num3 = num;
				num = (short)456065024;
				if (num != 0)
				{
				}
				return this.dataWideEncryptedNetworkPassword_43361.HiddenStatic;
			}
			set
			{
				short num = (short)1766088476;
				short num2 = num;
				num = (short)187064092;
				switch (num2 == num)
				{
				}
				num = (short)1958150145;
				if (num != 0)
				{
				}
				num = (short)1978073088;
				if (num != 0)
				{
				}
				num = (short)1256390656;
				short num3 = num;
				this.dataWideEncryptedNetworkPassword_43361.HiddenStatic = value;
			}
		}

		// Token: 0x170050CA RID: 20682
		// (get) Token: 0x0600A15F RID: 41311 RVA: 0x0096D0F8 File Offset: 0x0096B2F8
		// (set) Token: 0x0600A160 RID: 41312 RVA: 0x0096D1AC File Offset: 0x0096B3AC
		internal bool DataWideEncryptedNetworkPassword_43361_HiddenDynamic
		{
			get
			{
				short num = (short)234777946;
				short num2 = num;
				num = (short)2131127642;
				switch (num2 == num)
				{
				}
				num = (short)77201408;
				if (num != 0)
				{
				}
				num = (short)2069102593;
				if (num != 0)
				{
				}
				num = (short)210370560;
				short num3 = num;
				return this.dataWideEncryptedNetworkPassword_43361.HiddenDynamic;
			}
			set
			{
				short num = (short)1140754782;
				short num2 = num;
				num = (short)1102547294;
				switch (num2 == num)
				{
				}
				num = (short)942211073;
				if (num != 0)
				{
				}
				num = (short)1938685952;
				if (num != 0)
				{
				}
				num = (short)1299382272;
				short num3 = num;
				this.dataWideEncryptedNetworkPassword_43361.HiddenDynamic = value;
			}
		}

		// Token: 0x170050CB RID: 20683
		// (get) Token: 0x0600A161 RID: 41313 RVA: 0x0096D260 File Offset: 0x0096B460
		public bool DataWideEncryptedNetworkPassword_43361_HasDiffs
		{
			get
			{
				short num = (short)1563938122;
				short num2 = num;
				num = (short)1665256778;
				switch (num2 == num)
				{
				}
				num = (short)500891648;
				if (num != 0)
				{
				}
				num = (short)1476132865;
				if (num != 0)
				{
				}
				num = (short)262995968;
				short num3 = num;
				return this.dataWideEncryptedNetworkPassword_43361._HasDiffs;
			}
		}

		// Token: 0x170050CC RID: 20684
		// (get) Token: 0x0600A162 RID: 41314 RVA: 0x0096D314 File Offset: 0x0096B514
		// (set) Token: 0x0600A163 RID: 41315 RVA: 0x0096D3CC File Offset: 0x0096B5CC
		public int DataWideExternalDataModemType_43362Value
		{
			get
			{
				short num = (short)49251285;
				short num2 = num;
				num = (short)2041086933;
				switch (num2 == num)
				{
				}
				num = (short)1162412032;
				if (num != 0)
				{
				}
				num = (short)105381889;
				if (num != 0)
				{
				}
				num = (short)852492288;
				short num3 = num;
				return this.dataWideExternalDataModemType_43362.Value;
			}
			set
			{
				short num = (short)1296686461;
				short num2 = num;
				num = (short)1439489405;
				switch (num2 == num)
				{
				}
				num = (short)1304231937;
				if (num != 0)
				{
				}
				num = (short)232914944;
				if (num != 0)
				{
				}
				num = (short)1209925632;
				short num3 = num;
				this.dataWideExternalDataModemType_43362.Value = value;
			}
		}

		// Token: 0x170050CD RID: 20685
		// (get) Token: 0x0600A164 RID: 41316 RVA: 0x0096D480 File Offset: 0x0096B680
		// (set) Token: 0x0600A165 RID: 41317 RVA: 0x0096D538 File Offset: 0x0096B738
		public string DataWideExternalDataModemType_43362_UIValue
		{
			get
			{
				short num = (short)845185382;
				short num2 = num;
				num = (short)1383104870;
				switch (num2 == num)
				{
				}
				num = (short)624951296;
				if (num != 0)
				{
				}
				num = (short)1586167809;
				if (num != 0)
				{
				}
				num = (short)651558912;
				short num3 = num;
				return this.dataWideExternalDataModemType_43362.UIValue;
			}
			set
			{
				short num = (short)889751262;
				short num2 = num;
				num = (short)2140309214;
				switch (num2 == num)
				{
				}
				num = (short)643694592;
				if (num != 0)
				{
				}
				num = (short)1980301313;
				if (num != 0)
				{
				}
				num = (short)966393856;
				short num3 = num;
				this.dataWideExternalDataModemType_43362.UIValue = value;
			}
		}

		// Token: 0x170050CE RID: 20686
		// (get) Token: 0x0600A166 RID: 41318 RVA: 0x0096D5F0 File Offset: 0x0096B7F0
		public global::AcpBusinessLayer.AcpListField DataWideExternalDataModemType_43362
		{
			get
			{
				short num = (short)1285021500;
				short num2 = num;
				num = (short)57728828;
				switch (num2 == num)
				{
				}
				num = (short)652017665;
				if (num != 0)
				{
				}
				num = (short)535429120;
				if (num != 0)
				{
				}
				num = (short)169279488;
				short num3 = num;
				return this.dataWideExternalDataModemType_43362;
			}
		}

		// Token: 0x170050CF RID: 20687
		// (get) Token: 0x0600A167 RID: 41319 RVA: 0x0096D69C File Offset: 0x0096B89C
		// (set) Token: 0x0600A168 RID: 41320 RVA: 0x0096D750 File Offset: 0x0096B950
		public bool DataWideExternalDataModemType_43362_Applicable
		{
			get
			{
				short num = (short)496950689;
				short num2 = num;
				num = (short)761257377;
				switch (num2 == num)
				{
				}
				num = (short)894566401;
				if (num != 0)
				{
				}
				num = (short)1544552448;
				if (num != 0)
				{
				}
				num = (short)316866560;
				short num3 = num;
				return this.dataWideExternalDataModemType_43362.Applicable;
			}
			set
			{
				short num = (short)1365356514;
				short num2 = num;
				num = (short)845131746;
				switch (num2 == num)
				{
				}
				num = (short)275775489;
				if (num != 0)
				{
				}
				num = (short)107544576;
				if (num != 0)
				{
				}
				num = (short)939065344;
				short num3 = num;
				this.dataWideExternalDataModemType_43362.Applicable = value;
			}
		}

		// Token: 0x170050D0 RID: 20688
		// (get) Token: 0x0600A169 RID: 41321 RVA: 0x0096D804 File Offset: 0x0096BA04
		// (set) Token: 0x0600A16A RID: 41322 RVA: 0x0096D8B8 File Offset: 0x0096BAB8
		public bool DataWideExternalDataModemType_43362_Valid
		{
			get
			{
				short num = (short)815268660;
				short num2 = num;
				num = (short)2017526580;
				switch (num2 == num)
				{
				}
				num = (short)856096769;
				if (num != 0)
				{
				}
				num = (short)1138163712;
				if (num != 0)
				{
				}
				num = (short)1155858432;
				short num3 = num;
				return this.dataWideExternalDataModemType_43362.Valid;
			}
			set
			{
				short num = (short)1481613465;
				short num2 = num;
				num = (short)1368105113;
				switch (num2 == num)
				{
				}
				num = (short)967966721;
				if (num != 0)
				{
				}
				num = (short)934412288;
				if (num != 0)
				{
				}
				num = (short)500039680;
				short num3 = num;
				this.dataWideExternalDataModemType_43362.Valid = value;
			}
		}

		// Token: 0x170050D1 RID: 20689
		// (get) Token: 0x0600A16B RID: 41323 RVA: 0x0096D96C File Offset: 0x0096BB6C
		// (set) Token: 0x0600A16C RID: 41324 RVA: 0x0096DA24 File Offset: 0x0096BC24
		public bool DataWideExternalDataModemType_43362_Visible
		{
			get
			{
				short num = (short)577825815;
				short num2 = num;
				num = (short)1540090903;
				switch (num2 == num)
				{
				}
				num = (short)151912448;
				if (num != 0)
				{
				}
				num = (short)782761985;
				if (num != 0)
				{
				}
				num = (short)1752498176;
				short num3 = num;
				return this.dataWideExternalDataModemType_43362.Visible;
			}
			set
			{
				short num = (short)587657576;
				short num2 = num;
				num = (short)951906664;
				switch (num2 == num)
				{
				}
				num = (short)789577729;
				if (num != 0)
				{
				}
				num = (short)2105606144;
				if (num != 0)
				{
				}
				num = (short)1232994304;
				short num3 = num;
				this.dataWideExternalDataModemType_43362.Visible = value;
			}
		}

		// Token: 0x170050D2 RID: 20690
		// (get) Token: 0x0600A16D RID: 41325 RVA: 0x0096DAD8 File Offset: 0x0096BCD8
		// (set) Token: 0x0600A16E RID: 41326 RVA: 0x0096DB8C File Offset: 0x0096BD8C
		public bool DataWideExternalDataModemType_43362_Editable
		{
			get
			{
				short num = (short)15020961;
				short num2 = num;
				num = (short)596456353;
				switch (num2 == num)
				{
				}
				num = (short)1750728705;
				if (num != 0)
				{
				}
				num = (short)1471217664;
				if (num != 0)
				{
				}
				num = (short)953876480;
				short num3 = num;
				return this.dataWideExternalDataModemType_43362.Editable;
			}
			set
			{
				short num = (short)746696048;
				short num2 = num;
				num = (short)604876144;
				switch (num2 == num)
				{
				}
				num = (short)61276161;
				if (num != 0)
				{
				}
				num = (short)1672806400;
				if (num != 0)
				{
				}
				num = (short)1465384960;
				short num3 = num;
				this.dataWideExternalDataModemType_43362.Editable = value;
			}
		}

		// Token: 0x170050D3 RID: 20691
		// (get) Token: 0x0600A16F RID: 41327 RVA: 0x0096DC40 File Offset: 0x0096BE40
		internal string DataWideExternalDataModemType_43362_UILabel
		{
			get
			{
				short num = (short)1457799381;
				short num2 = num;
				num = (short)1668432085;
				switch (num2 == num)
				{
				}
				num = (short)1214775296;
				if (num != 0)
				{
				}
				num = (short)539623425;
				if (num != 0)
				{
				}
				num = (short)1834811392;
				short num3 = num;
				return this.dataWideExternalDataModemType_43362.UIName;
			}
		}

		// Token: 0x170050D4 RID: 20692
		// (get) Token: 0x0600A170 RID: 41328 RVA: 0x0096DCF4 File Offset: 0x0096BEF4
		// (set) Token: 0x0600A171 RID: 41329 RVA: 0x0096DDA8 File Offset: 0x0096BFA8
		internal bool DataWideExternalDataModemType_43362_HiddenStatic
		{
			get
			{
				short num = (short)749806840;
				short num2 = num;
				num = (short)1091118328;
				switch (num2 == num)
				{
				}
				num = (short)1682505728;
				if (num != 0)
				{
				}
				num = (short)258867201;
				if (num != 0)
				{
				}
				num = (short)2228224;
				short num3 = num;
				return this.dataWideExternalDataModemType_43362.HiddenStatic;
			}
			set
			{
				short num = (short)1266892164;
				short num2 = num;
				num = (short)558644612;
				switch (num2 == num)
				{
				}
				num = (short)60096513;
				if (num != 0)
				{
				}
				num = (short)1336999936;
				if (num != 0)
				{
				}
				num = (short)1460404224;
				short num3 = num;
				this.dataWideExternalDataModemType_43362.HiddenStatic = value;
			}
		}

		// Token: 0x170050D5 RID: 20693
		// (get) Token: 0x0600A172 RID: 41330 RVA: 0x0096DE5C File Offset: 0x0096C05C
		// (set) Token: 0x0600A173 RID: 41331 RVA: 0x0096DF10 File Offset: 0x0096C110
		internal bool DataWideExternalDataModemType_43362_HiddenDynamic
		{
			get
			{
				short num = (short)104976699;
				short num2 = num;
				num = (short)676778299;
				switch (num2 == num)
				{
				}
				num = (short)1401749505;
				if (num != 0)
				{
				}
				num = (short)501153792;
				if (num != 0)
				{
				}
				num = (short)2044657664;
				short num3 = num;
				return this.dataWideExternalDataModemType_43362.HiddenDynamic;
			}
			set
			{
				short num = (short)86058906;
				short num2 = num;
				num = (short)473442202;
				switch (num2 == num)
				{
				}
				num = (short)1910571009;
				if (num != 0)
				{
				}
				num = (short)453705728;
				if (num != 0)
				{
				}
				num = (short)85983232;
				short num3 = num;
				this.dataWideExternalDataModemType_43362.HiddenDynamic = value;
			}
		}

		// Token: 0x170050D6 RID: 20694
		// (get) Token: 0x0600A174 RID: 41332 RVA: 0x0096DFC8 File Offset: 0x0096C1C8
		public bool DataWideExternalDataModemType_43362_HasDiffs
		{
			get
			{
				short num = (short)1390174803;
				short num2 = num;
				num = (short)928277075;
				switch (num2 == num)
				{
				}
				num = (short)791740416;
				if (num != 0)
				{
				}
				num = (short)1930821633;
				if (num != 0)
				{
				}
				num = (short)1668481024;
				short num3 = num;
				return this.dataWideExternalDataModemType_43362._HasDiffs;
			}
		}

		// Token: 0x170050D7 RID: 20695
		// (get) Token: 0x0600A175 RID: 41333 RVA: 0x0096E080 File Offset: 0x0096C280
		// (set) Token: 0x0600A176 RID: 41334 RVA: 0x0096E134 File Offset: 0x0096C334
		public string DataWideEncryptedModemPassword_43361Value
		{
			get
			{
				short num = (short)1778867353;
				short num2 = num;
				num = (short)1716280473;
				switch (num2 == num)
				{
				}
				num = (short)1216675840;
				if (num != 0)
				{
				}
				num = (short)123535361;
				if (num != 0)
				{
				}
				num = (short)1927806976;
				short num3 = num;
				return this.dataWideEncryptedModemPassword_43361.Value;
			}
			set
			{
				short num = (short)225951509;
				short num2 = num;
				num = (short)261668629;
				switch (num2 == num)
				{
				}
				num = (short)1348468737;
				if (num != 0)
				{
				}
				num = (short)85852160;
				if (num != 0)
				{
				}
				num = (short)2066939904;
				short num3 = num;
				this.dataWideEncryptedModemPassword_43361.Value = value;
			}
		}

		// Token: 0x170050D8 RID: 20696
		// (get) Token: 0x0600A177 RID: 41335 RVA: 0x0096E1E8 File Offset: 0x0096C3E8
		public global::AcpBusinessLayer.AcpFieldX<string, string> DataWideEncryptedModemPassword_43361
		{
			get
			{
				short num = (short)1398259160;
				short num2 = num;
				num = (short)1212726744;
				switch (num2 == num)
				{
				}
				num = (short)1914961920;
				if (num != 0)
				{
				}
				num = (short)1026424833;
				if (num != 0)
				{
				}
				num = (short)1794310144;
				short num3 = num;
				return this.dataWideEncryptedModemPassword_43361;
			}
		}

		// Token: 0x170050D9 RID: 20697
		// (get) Token: 0x0600A178 RID: 41336 RVA: 0x0096E298 File Offset: 0x0096C498
		// (set) Token: 0x0600A179 RID: 41337 RVA: 0x0096E350 File Offset: 0x0096C550
		public string DataWideEncryptedModemPassword_43361_UIValue
		{
			get
			{
				short num = (short)1464060474;
				short num2 = num;
				num = (short)1326369338;
				switch (num2 == num)
				{
				}
				num = (short)25886721;
				if (num != 0)
				{
				}
				num = (short)310050816;
				if (num != 0)
				{
				}
				num = (short)1176043520;
				short num3 = num;
				return this.dataWideEncryptedModemPassword_43361.UIValue;
			}
			set
			{
				short num = (short)489553921;
				if (num != 0)
				{
				}
				num = (short)526608994;
				short num2 = num;
				num = (short)646867554;
				switch (num2 == num)
				{
				}
				num = (short)697565184;
				if (num != 0)
				{
				}
				num = (short)687996928;
				short num3 = num;
				this.dataWideEncryptedModemPassword_43361.UIValue = value;
			}
		}

		// Token: 0x170050DA RID: 20698
		// (get) Token: 0x0600A17A RID: 41338 RVA: 0x0096E404 File Offset: 0x0096C604
		// (set) Token: 0x0600A17B RID: 41339 RVA: 0x0096E4B8 File Offset: 0x0096C6B8
		public bool DataWideEncryptedModemPassword_43361_Applicable
		{
			get
			{
				short num = (short)1463838992;
				short num2 = num;
				num = (short)1112107280;
				switch (num2 == num)
				{
				}
				num = (short)1576534017;
				if (num != 0)
				{
				}
				num = (short)149159936;
				if (num != 0)
				{
				}
				num = (short)1175322624;
				short num3 = num;
				return this.dataWideEncryptedModemPassword_43361.Applicable;
			}
			set
			{
				short num = (short)1871708002;
				short num2 = num;
				num = (short)1031995234;
				switch (num2 == num)
				{
				}
				num = (short)1867251712;
				if (num != 0)
				{
				}
				num = (short)1257570305;
				if (num != 0)
				{
				}
				num = (short)383385600;
				short num3 = num;
				this.dataWideEncryptedModemPassword_43361.Applicable = value;
			}
		}

		// Token: 0x170050DB RID: 20699
		// (get) Token: 0x0600A17C RID: 41340 RVA: 0x0096E570 File Offset: 0x0096C770
		// (set) Token: 0x0600A17D RID: 41341 RVA: 0x0096E624 File Offset: 0x0096C824
		public bool DataWideEncryptedModemPassword_43361_Valid
		{
			get
			{
				short num = (short)833265779;
				short num2 = num;
				num = (short)1302831219;
				switch (num2 == num)
				{
				}
				num = (short)245432321;
				if (num != 0)
				{
				}
				num = (short)1724055552;
				if (num != 0)
				{
				}
				num = (short)613482496;
				short num3 = num;
				return this.dataWideEncryptedModemPassword_43361.Valid;
			}
			set
			{
				short num = (short)2014639089;
				short num2 = num;
				num = (short)1223488497;
				switch (num2 == num)
				{
				}
				num = (short)182648833;
				if (num != 0)
				{
				}
				num = (short)1437532160;
				if (num != 0)
				{
				}
				num = (short)1225392128;
				short num3 = num;
				this.dataWideEncryptedModemPassword_43361.Valid = value;
			}
		}

		// Token: 0x170050DC RID: 20700
		// (get) Token: 0x0600A17E RID: 41342 RVA: 0x0096E6D8 File Offset: 0x0096C8D8
		// (set) Token: 0x0600A17F RID: 41343 RVA: 0x0096E790 File Offset: 0x0096C990
		public bool DataWideEncryptedModemPassword_43361_Visible
		{
			get
			{
				short num = (short)1073081512;
				short num2 = num;
				num = (short)1886448808;
				switch (num2 == num)
				{
				}
				num = (short)171900929;
				if (num != 0)
				{
				}
				num = (short)1185677312;
				if (num != 0)
				{
				}
				num = (short)1565851648;
				short num3 = num;
				return this.dataWideEncryptedModemPassword_43361.Visible;
			}
			set
			{
				short num = (short)593289604;
				short num2 = num;
				num = (short)347136388;
				switch (num2 == num)
				{
				}
				num = (short)1472724993;
				if (num != 0)
				{
				}
				num = (short)523436032;
				if (num != 0)
				{
				}
				num = (short)495386624;
				short num3 = num;
				this.dataWideEncryptedModemPassword_43361.Visible = value;
			}
		}

		// Token: 0x170050DD RID: 20701
		// (get) Token: 0x0600A180 RID: 41344 RVA: 0x0096E844 File Offset: 0x0096CA44
		// (set) Token: 0x0600A181 RID: 41345 RVA: 0x0096E8F8 File Offset: 0x0096CAF8
		public bool DataWideEncryptedModemPassword_43361_Editable
		{
			get
			{
				short num = (short)534710532;
				short num2 = num;
				num = (short)1096354052;
				switch (num2 == num)
				{
				}
				num = (short)576323585;
				if (num != 0)
				{
				}
				num = (short)1385758720;
				if (num != 0)
				{
				}
				num = (short)1565065216;
				short num3 = num;
				return this.dataWideEncryptedModemPassword_43361.Editable;
			}
			set
			{
				short num = (short)1042585772;
				short num2 = num;
				num = (short)2109642924;
				switch (num2 == num)
				{
				}
				num = (short)582025217;
				if (num != 0)
				{
				}
				num = (short)311689216;
				if (num != 0)
				{
				}
				num = (short)2110652416;
				short num3 = num;
				this.dataWideEncryptedModemPassword_43361.Editable = value;
			}
		}

		// Token: 0x170050DE RID: 20702
		// (get) Token: 0x0600A182 RID: 41346 RVA: 0x0096E9B0 File Offset: 0x0096CBB0
		internal string DataWideEncryptedModemPassword_43361_UILabel
		{
			get
			{
				short num = (short)1544224769;
				if (num != 0)
				{
				}
				num = (short)1075387450;
				short num2 = num;
				num = (short)1086135354;
				switch (num2 == num)
				{
				}
				num = (short)1785462784;
				if (num != 0)
				{
				}
				num = (short)997130240;
				short num3 = num;
				return this.dataWideEncryptedModemPassword_43361.UIName;
			}
		}

		// Token: 0x170050DF RID: 20703
		// (get) Token: 0x0600A183 RID: 41347 RVA: 0x0096EA64 File Offset: 0x0096CC64
		// (set) Token: 0x0600A184 RID: 41348 RVA: 0x0096EB18 File Offset: 0x0096CD18
		internal bool DataWideEncryptedModemPassword_43361_HiddenStatic
		{
			get
			{
				short num = (short)1577593988;
				short num2 = num;
				num = (short)1688874116;
				switch (num2 == num)
				{
				}
				num = (short)964624384;
				if (num != 0)
				{
				}
				num = (short)954793985;
				if (num != 0)
				{
				}
				num = (short)1349648384;
				short num3 = num;
				return this.dataWideEncryptedModemPassword_43361.HiddenStatic;
			}
			set
			{
				short num = (short)1994343338;
				short num2 = num;
				num = (short)975782826;
				switch (num2 == num)
				{
				}
				num = (short)2006253569;
				if (num != 0)
				{
				}
				num = (short)1605369856;
				if (num != 0)
				{
				}
				num = (short)881459200;
				short num3 = num;
				this.dataWideEncryptedModemPassword_43361.HiddenStatic = value;
			}
		}

		// Token: 0x170050E0 RID: 20704
		// (get) Token: 0x0600A185 RID: 41349 RVA: 0x0096EBCC File Offset: 0x0096CDCC
		// (set) Token: 0x0600A186 RID: 41350 RVA: 0x0096EC80 File Offset: 0x0096CE80
		internal bool DataWideEncryptedModemPassword_43361_HiddenDynamic
		{
			get
			{
				short num = (short)1397417033;
				short num2 = num;
				num = (short)767353929;
				switch (num2 == num)
				{
				}
				num = (short)711196673;
				if (num != 0)
				{
				}
				num = (short)1509883904;
				if (num != 0)
				{
				}
				num = (short)2077687808;
				short num3 = num;
				return this.dataWideEncryptedModemPassword_43361.HiddenDynamic;
			}
			set
			{
				short num = (short)861925538;
				short num2 = num;
				num = (short)1982394530;
				switch (num2 == num)
				{
				}
				num = (short)1780547585;
				if (num != 0)
				{
				}
				num = (short)292814848;
				if (num != 0)
				{
				}
				num = (short)1381105664;
				short num3 = num;
				this.dataWideEncryptedModemPassword_43361.HiddenDynamic = value;
			}
		}

		// Token: 0x170050E1 RID: 20705
		// (get) Token: 0x0600A187 RID: 41351 RVA: 0x0096ED34 File Offset: 0x0096CF34
		public bool DataWideEncryptedModemPassword_43361_HasDiffs
		{
			get
			{
				short num = (short)142344193;
				if (num != 0)
				{
				}
				num = (short)1006104253;
				short num2 = num;
				num = (short)135130813;
				switch (num2 == num)
				{
				}
				num = (short)1641742336;
				if (num != 0)
				{
				}
				num = (short)1112473600;
				short num3 = num;
				return this.dataWideEncryptedModemPassword_43361._HasDiffs;
			}
		}

		// Token: 0x170050E2 RID: 20706
		// (get) Token: 0x0600A188 RID: 41352 RVA: 0x0096EDE8 File Offset: 0x0096CFE8
		// (set) Token: 0x0600A189 RID: 41353 RVA: 0x0096EE9C File Offset: 0x0096D09C
		public int DataWideExternalDataModemPortValue
		{
			get
			{
				short num = (short)256829518;
				short num2 = num;
				num = (short)166258766;
				switch (num2 == num)
				{
				}
				num = (short)6619137;
				if (num != 0)
				{
				}
				num = (short)1316290560;
				if (num != 0)
				{
				}
				num = (short)640876544;
				short num3 = num;
				return this.dataWideExternalDataModemPort.Value;
			}
			set
			{
				short num = (short)1450306938;
				short num2 = num;
				num = (short)1210445178;
				switch (num2 == num)
				{
				}
				num = (short)1663893505;
				if (num != 0)
				{
				}
				num = (short)1729822720;
				if (num != 0)
				{
				}
				num = (short)1449525248;
				short num3 = num;
				this.dataWideExternalDataModemPort.Value = value;
			}
		}

		// Token: 0x170050E3 RID: 20707
		// (get) Token: 0x0600A18A RID: 41354 RVA: 0x0096EF54 File Offset: 0x0096D154
		public global::AcpBusinessLayer.AcpSimpleRangeField DataWideExternalDataModemPort
		{
			get
			{
				short num = (short)1529114141;
				short num2 = num;
				num = (short)1745907229;
				switch (num2 == num)
				{
				}
				num = (short)1197146113;
				if (num != 0)
				{
				}
				num = (short)2135818240;
				if (num != 0)
				{
				}
				num = (short)1501888512;
				short num3 = num;
				return this.dataWideExternalDataModemPort;
			}
		}

		// Token: 0x170050E4 RID: 20708
		// (get) Token: 0x0600A18B RID: 41355 RVA: 0x0096F000 File Offset: 0x0096D200
		// (set) Token: 0x0600A18C RID: 41356 RVA: 0x0096F0B4 File Offset: 0x0096D2B4
		public string DataWideExternalDataModemPort_UIValue
		{
			get
			{
				short num = (short)296673864;
				short num2 = num;
				num = (short)1655104072;
				switch (num2 == num)
				{
				}
				num = (short)1470758913;
				if (num != 0)
				{
				}
				num = (short)1116012544;
				if (num != 0)
				{
				}
				num = (short)532086784;
				short num3 = num;
				return this.dataWideExternalDataModemPort.UIValue;
			}
			set
			{
				short num = (short)2024892346;
				short num2 = num;
				num = (short)719087546;
				switch (num2 == num)
				{
				}
				num = (short)290652161;
				if (num != 0)
				{
				}
				num = (short)2074869760;
				if (num != 0)
				{
				}
				num = (short)151584768;
				short num3 = num;
				this.dataWideExternalDataModemPort.UIValue = value;
			}
		}

		// Token: 0x170050E5 RID: 20709
		// (get) Token: 0x0600A18D RID: 41357 RVA: 0x0096F168 File Offset: 0x0096D368
		// (set) Token: 0x0600A18E RID: 41358 RVA: 0x0096F220 File Offset: 0x0096D420
		internal int DataWideExternalDataModemPortMin
		{
			get
			{
				short num = (short)810090237;
				short num2 = num;
				num = (short)97517309;
				switch (num2 == num)
				{
				}
				num = (short)895680512;
				if (num != 0)
				{
				}
				num = (short)1886257153;
				if (num != 0)
				{
				}
				num = (short)2080571392;
				short num3 = num;
				return this.dataWideExternalDataModemPort.Min;
			}
			set
			{
				short num = (short)782229442;
				short num2 = num;
				num = (short)378789826;
				switch (num2 == num)
				{
				}
				num = (short)2002059265;
				if (num != 0)
				{
				}
				num = (short)633929728;
				if (num != 0)
				{
				}
				num = (short)1235156992;
				short num3 = num;
				this.dataWideExternalDataModemPort.Min = value;
			}
		}

		// Token: 0x170050E6 RID: 20710
		// (get) Token: 0x0600A18F RID: 41359 RVA: 0x0096F2D4 File Offset: 0x0096D4D4
		// (set) Token: 0x0600A190 RID: 41360 RVA: 0x0096F38C File Offset: 0x0096D58C
		internal int DataWideExternalDataModemPortMax
		{
			get
			{
				short num = (short)1368894493;
				short num2 = num;
				num = (short)1852222493;
				switch (num2 == num)
				{
				}
				num = (short)1704984577;
				if (num != 0)
				{
				}
				num = (short)854523904;
				if (num != 0)
				{
				}
				num = (short)1869611008;
				short num3 = num;
				return this.dataWideExternalDataModemPort.Max;
			}
			set
			{
				short num = (short)695274615;
				short num2 = num;
				num = (short)810355831;
				switch (num2 == num)
				{
				}
				num = (short)1337589761;
				if (num != 0)
				{
				}
				num = (short)371392512;
				if (num != 0)
				{
				}
				num = (short)1079902208;
				short num3 = num;
				this.dataWideExternalDataModemPort.Max = value;
			}
		}

		// Token: 0x170050E7 RID: 20711
		// (get) Token: 0x0600A191 RID: 41361 RVA: 0x0096F444 File Offset: 0x0096D644
		// (set) Token: 0x0600A192 RID: 41362 RVA: 0x0096F4F8 File Offset: 0x0096D6F8
		internal int DataWideExternalDataModemPortStep
		{
			get
			{
				short num = (short)71487877;
				short num2 = num;
				num = (short)798740869;
				switch (num2 == num)
				{
				}
				num = (short)919666689;
				if (num != 0)
				{
				}
				num = (short)967245824;
				if (num != 0)
				{
				}
				num = (short)87687168;
				short num3 = num;
				return this.dataWideExternalDataModemPort.StepSize;
			}
			set
			{
				short num = (short)130683188;
				short num2 = num;
				num = (short)1494290740;
				switch (num2 == num)
				{
				}
				num = (short)1410007041;
				if (num != 0)
				{
				}
				num = (short)512491520;
				if (num != 0)
				{
				}
				num = (short)743047168;
				short num3 = num;
				this.dataWideExternalDataModemPort.StepSize = value;
			}
		}

		// Token: 0x170050E8 RID: 20712
		// (get) Token: 0x0600A193 RID: 41363 RVA: 0x0096F5AC File Offset: 0x0096D7AC
		// (set) Token: 0x0600A194 RID: 41364 RVA: 0x0096F664 File Offset: 0x0096D864
		public bool DataWideExternalDataModemPort_Applicable
		{
			get
			{
				short num = (short)991008657;
				short num2 = num;
				num = (short)547592081;
				switch (num2 == num)
				{
				}
				num = (short)113246208;
				if (num != 0)
				{
				}
				num = (short)1260912641;
				if (num != 0)
				{
				}
				num = (short)1187905536;
				short num3 = num;
				return this.dataWideExternalDataModemPort.Applicable;
			}
			set
			{
				short num = (short)1769078490;
				short num2 = num;
				num = (short)1005649626;
				switch (num2 == num)
				{
				}
				num = (short)613810177;
				if (num != 0)
				{
				}
				num = (short)2089156608;
				if (num != 0)
				{
				}
				num = (short)240582656;
				short num3 = num;
				this.dataWideExternalDataModemPort.Applicable = value;
			}
		}

		// Token: 0x170050E9 RID: 20713
		// (get) Token: 0x0600A195 RID: 41365 RVA: 0x0096F718 File Offset: 0x0096D918
		// (set) Token: 0x0600A196 RID: 41366 RVA: 0x0096F7CC File Offset: 0x0096D9CC
		public bool DataWideExternalDataModemPort_Valid
		{
			get
			{
				short num = (short)568539009;
				short num2 = num;
				num = (short)1809790849;
				switch (num2 == num)
				{
				}
				num = (short)940572672;
				if (num != 0)
				{
				}
				num = (short)573702145;
				if (num != 0)
				{
				}
				num = (short)1138032640;
				short num3 = num;
				return this.dataWideExternalDataModemPort.Valid;
			}
			set
			{
				short num = (short)1970339841;
				if (num != 0)
				{
				}
				num = (short)139332359;
				short num2 = num;
				num = (short)1450904327;
				switch (num2 == num)
				{
				}
				num = (short)262995968;
				if (num != 0)
				{
				}
				num = (short)533528576;
				short num3 = num;
				this.dataWideExternalDataModemPort.Valid = value;
			}
		}

		// Token: 0x170050EA RID: 20714
		// (get) Token: 0x0600A197 RID: 41367 RVA: 0x0096F884 File Offset: 0x0096DA84
		// (set) Token: 0x0600A198 RID: 41368 RVA: 0x0096F938 File Offset: 0x0096DB38
		public bool DataWideExternalDataModemPort_Visible
		{
			get
			{
				short num = (short)1607478469;
				short num2 = num;
				num = (short)2077633733;
				switch (num2 == num)
				{
				}
				num = (short)1241317376;
				if (num != 0)
				{
				}
				num = (short)693698561;
				if (num != 0)
				{
				}
				num = (short)1307770880;
				short num3 = num;
				return this.dataWideExternalDataModemPort.Visible;
			}
			set
			{
				short num = (short)266800692;
				short num2 = num;
				num = (short)958074420;
				switch (num2 == num)
				{
				}
				num = (short)330956801;
				if (num != 0)
				{
				}
				num = (short)162332672;
				if (num != 0)
				{
				}
				num = (short)249823232;
				short num3 = num;
				this.dataWideExternalDataModemPort.Visible = value;
			}
		}

		// Token: 0x170050EB RID: 20715
		// (get) Token: 0x0600A199 RID: 41369 RVA: 0x0096F9F4 File Offset: 0x0096DBF4
		// (set) Token: 0x0600A19A RID: 41370 RVA: 0x0096FAA4 File Offset: 0x0096DCA4
		public bool DataWideExternalDataModemPort_Editable
		{
			get
			{
				short num = (short)2130953724;
				short num2 = num;
				num = (short)1144899068;
				switch (num2 == num)
				{
				}
				num = (short)1645084672;
				if (num != 0)
				{
				}
				num = (short)1200685057;
				if (num != 0)
				{
				}
				num = (short)727580672;
				short num3 = num;
				return this.dataWideExternalDataModemPort.Editable;
			}
			set
			{
				short num = (short)550966082;
				short num2 = num;
				num = (short)484250434;
				switch (num2 == num)
				{
				}
				num = (short)507510784;
				if (num != 0)
				{
				}
				num = (short)736821249;
				if (num != 0)
				{
				}
				num = (short)774897664;
				short num3 = num;
				this.dataWideExternalDataModemPort.Editable = value;
			}
		}

		// Token: 0x170050EC RID: 20716
		// (get) Token: 0x0600A19B RID: 41371 RVA: 0x0096FB5C File Offset: 0x0096DD5C
		internal string DataWideExternalDataModemPort_UILabel
		{
			get
			{
				short num = (short)2122061572;
				short num2 = num;
				num = (short)2086737668;
				switch (num2 == num)
				{
				}
				num = (short)1031012353;
				if (num != 0)
				{
				}
				num = (short)428736512;
				if (num != 0)
				{
				}
				num = (short)1055916032;
				short num3 = num;
				return this.dataWideExternalDataModemPort.UIName;
			}
		}

		// Token: 0x170050ED RID: 20717
		// (get) Token: 0x0600A19C RID: 41372 RVA: 0x0096FC10 File Offset: 0x0096DE10
		// (set) Token: 0x0600A19D RID: 41373 RVA: 0x0096FCC8 File Offset: 0x0096DEC8
		internal bool DataWideExternalDataModemPort_HiddenStatic
		{
			get
			{
				short num = (short)1048714702;
				short num2 = num;
				num = (short)1265638862;
				switch (num2 == num)
				{
				}
				num = (short)1390739457;
				if (num != 0)
				{
				}
				num = (short)1654390784;
				if (num != 0)
				{
				}
				num = (short)1844510720;
				short num3 = num;
				return this.dataWideExternalDataModemPort.HiddenStatic;
			}
			set
			{
				short num = (short)707452889;
				short num2 = num;
				num = (short)549773273;
				switch (num2 == num)
				{
				}
				num = (short)1293877249;
				if (num != 0)
				{
				}
				num = (short)107675648;
				if (num != 0)
				{
				}
				num = (short)924778496;
				short num3 = num;
				this.dataWideExternalDataModemPort.HiddenStatic = value;
			}
		}

		// Token: 0x170050EE RID: 20718
		// (get) Token: 0x0600A19E RID: 41374 RVA: 0x0096FD80 File Offset: 0x0096DF80
		// (set) Token: 0x0600A19F RID: 41375 RVA: 0x0096FE38 File Offset: 0x0096E038
		internal bool DataWideExternalDataModemPort_HiddenDynamic
		{
			get
			{
				short num = (short)177225005;
				short num2 = num;
				num = (short)1836072237;
				switch (num2 == num)
				{
				}
				num = (short)449183744;
				if (num != 0)
				{
				}
				num = (short)155451393;
				if (num != 0)
				{
				}
				num = (short)879624192;
				short num3 = num;
				return this.dataWideExternalDataModemPort.HiddenDynamic;
			}
			set
			{
				short num = (short)584367088;
				short num2 = num;
				num = (short)1846721520;
				switch (num2 == num)
				{
				}
				num = (short)976879617;
				if (num != 0)
				{
				}
				num = (short)1708720128;
				if (num != 0)
				{
				}
				num = (short)1202323456;
				short num3 = num;
				this.dataWideExternalDataModemPort.HiddenDynamic = value;
			}
		}

		// Token: 0x170050EF RID: 20719
		// (get) Token: 0x0600A1A0 RID: 41376 RVA: 0x0096FEEC File Offset: 0x0096E0EC
		public bool DataWideExternalDataModemPort_HasDiffs
		{
			get
			{
				short num = (short)919142401;
				if (num != 0)
				{
				}
				num = (short)1193416332;
				short num2 = num;
				num = (short)932058764;
				switch (num2 == num)
				{
				}
				num = (short)1392181248;
				if (num != 0)
				{
				}
				num = (short)1530265600;
				short num3 = num;
				return this.dataWideExternalDataModemPort._HasDiffs;
			}
		}

		// Token: 0x170050F0 RID: 20720
		// (get) Token: 0x0600A1A1 RID: 41377 RVA: 0x0096FFA0 File Offset: 0x0096E1A0
		// (set) Token: 0x0600A1A2 RID: 41378 RVA: 0x00970054 File Offset: 0x0096E254
		public int DataWideExternalDataVpnTunnel_43365Value
		{
			get
			{
				short num = (short)1096351745;
				if (num != 0)
				{
				}
				num = (short)49921812;
				short num2 = num;
				num = (short)37601044;
				switch (num2 == num)
				{
				}
				num = (short)801505280;
				if (num != 0)
				{
				}
				num = (short)1605894144;
				short num3 = num;
				return this.dataWideExternalDataVpnTunnel_43365.Value;
			}
			set
			{
				short num = (short)1945428755;
				short num2 = num;
				num = (short)192078611;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1588985856;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)714801153;
				if (num != 0)
				{
				}
				num = (short)1795751936;
				if (num != 0)
				{
				}
				this.dataWideExternalDataVpnTunnel_43365.Value = value;
			}
		}

		// Token: 0x170050F1 RID: 20721
		// (get) Token: 0x0600A1A3 RID: 41379 RVA: 0x00970108 File Offset: 0x0096E308
		public global::AcpBusinessLayer.AcpSimpleRangeField DataWideExternalDataVpnTunnel_43365
		{
			get
			{
				short num = (short)1730894012;
				short num2 = num;
				num = (short)267344060;
				switch (num2 == num)
				{
				default:
				{
					num = (short)615383040;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1909719041;
				if (num != 0)
				{
				}
				num = (short)886702080;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataVpnTunnel_43365;
			}
		}

		// Token: 0x170050F2 RID: 20722
		// (get) Token: 0x0600A1A4 RID: 41380 RVA: 0x009701B4 File Offset: 0x0096E3B4
		// (set) Token: 0x0600A1A5 RID: 41381 RVA: 0x0097026C File Offset: 0x0096E46C
		public string DataWideExternalDataVpnTunnel_43365_UIValue
		{
			get
			{
				short num = (short)2133989223;
				short num2 = num;
				num = (short)1045895015;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2141388800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1901723649;
				if (num != 0)
				{
				}
				num = (short)533528576;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataVpnTunnel_43365.UIValue;
			}
			set
			{
				short num = (short)811630827;
				short num2 = num;
				num = (short)1144684779;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1953234944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1235353601;
				if (num != 0)
				{
				}
				num = (short)1971781632;
				if (num != 0)
				{
				}
				this.dataWideExternalDataVpnTunnel_43365.UIValue = value;
			}
		}

		// Token: 0x170050F3 RID: 20723
		// (get) Token: 0x0600A1A6 RID: 41382 RVA: 0x00970320 File Offset: 0x0096E520
		// (set) Token: 0x0600A1A7 RID: 41383 RVA: 0x009703D4 File Offset: 0x0096E5D4
		internal int DataWideExternalDataVpnTunnel_43365Min
		{
			get
			{
				short num = (short)2084240683;
				short num2 = num;
				num = (short)460193067;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2009137152;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1215823873;
				if (num != 0)
				{
				}
				num = (short)139395072;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataVpnTunnel_43365.Min;
			}
			set
			{
				short num = (short)1762869423;
				short num2 = num;
				num = (short)1695826095;
				switch (num2 == num)
				{
				default:
				{
					num = (short)411959296;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1501626369;
				if (num != 0)
				{
				}
				num = (short)1628962816;
				if (num != 0)
				{
				}
				this.dataWideExternalDataVpnTunnel_43365.Min = value;
			}
		}

		// Token: 0x170050F4 RID: 20724
		// (get) Token: 0x0600A1A8 RID: 41384 RVA: 0x00970488 File Offset: 0x0096E688
		// (set) Token: 0x0600A1A9 RID: 41385 RVA: 0x0097053C File Offset: 0x0096E73C
		internal int DataWideExternalDataVpnTunnel_43365Max
		{
			get
			{
				short num = (short)1009667298;
				short num2 = num;
				num = (short)968838370;
				switch (num2 == num)
				{
				default:
				{
					num = (short)469958656;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)7798785;
				if (num != 0)
				{
				}
				num = (short)1846673408;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataVpnTunnel_43365.Max;
			}
			set
			{
				short num = (short)168624129;
				if (num != 0)
				{
				}
				num = (short)39321600;
				short num2 = num;
				num = (short)1336599165;
				short num3 = num;
				num = (short)1836704381;
				switch (num3 == num)
				{
				}
				num = (short)1176567808;
				if (num != 0)
				{
				}
				this.dataWideExternalDataVpnTunnel_43365.Max = value;
			}
		}

		// Token: 0x170050F5 RID: 20725
		// (get) Token: 0x0600A1AA RID: 41386 RVA: 0x009705F4 File Offset: 0x0096E7F4
		// (set) Token: 0x0600A1AB RID: 41387 RVA: 0x009706AC File Offset: 0x0096E8AC
		internal int DataWideExternalDataVpnTunnel_43365Step
		{
			get
			{
				short num = (short)1940668235;
				short num2 = num;
				num = (short)1151876939;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2067791872;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)19202048;
				if (num != 0)
				{
				}
				num = (short)225443841;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataVpnTunnel_43365.StepSize;
			}
			set
			{
				short num = (short)15299800;
				short num2 = num;
				num = (short)1380938968;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1972699136;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)768278529;
				if (num != 0)
				{
				}
				num = (short)1940258816;
				if (num != 0)
				{
				}
				this.dataWideExternalDataVpnTunnel_43365.StepSize = value;
			}
		}

		// Token: 0x170050F6 RID: 20726
		// (get) Token: 0x0600A1AC RID: 41388 RVA: 0x00970760 File Offset: 0x0096E960
		// (set) Token: 0x0600A1AD RID: 41389 RVA: 0x00970818 File Offset: 0x0096EA18
		public bool DataWideExternalDataVpnTunnel_43365_Applicable
		{
			get
			{
				short num = (short)377286268;
				short num2 = num;
				num = (short)1233579644;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1840513024;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1344012289;
				if (num != 0)
				{
				}
				num = (short)137560064;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataVpnTunnel_43365.Applicable;
			}
			set
			{
				short num = (short)573308929;
				if (num != 0)
				{
				}
				num = (short)1522270208;
				short num2 = num;
				num = (short)925686988;
				short num3 = num;
				num = (short)1710152908;
				switch (num3 == num)
				{
				}
				num = (short)1487863808;
				if (num != 0)
				{
				}
				this.dataWideExternalDataVpnTunnel_43365.Applicable = value;
			}
		}

		// Token: 0x170050F7 RID: 20727
		// (get) Token: 0x0600A1AE RID: 41390 RVA: 0x009708CC File Offset: 0x0096EACC
		// (set) Token: 0x0600A1AF RID: 41391 RVA: 0x00970984 File Offset: 0x0096EB84
		public bool DataWideExternalDataVpnTunnel_43365_Valid
		{
			get
			{
				short num = (short)303126046;
				short num2 = num;
				num = (short)2077906462;
				switch (num2 == num)
				{
				default:
				{
					num = (short)928186368;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)361758721;
				if (num != 0)
				{
				}
				num = (short)1940586496;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataVpnTunnel_43365.Valid;
			}
			set
			{
				short num = (short)118344508;
				short num2 = num;
				num = (short)937282364;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1630732288;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2010251265;
				if (num != 0)
				{
				}
				num = (short)349437952;
				if (num != 0)
				{
				}
				this.dataWideExternalDataVpnTunnel_43365.Valid = value;
			}
		}

		// Token: 0x170050F8 RID: 20728
		// (get) Token: 0x0600A1B0 RID: 41392 RVA: 0x00970A3C File Offset: 0x0096EC3C
		// (set) Token: 0x0600A1B1 RID: 41393 RVA: 0x00970AF0 File Offset: 0x0096ECF0
		public bool DataWideExternalDataVpnTunnel_43365_Visible
		{
			get
			{
				short num = (short)1636076192;
				short num2 = num;
				num = (short)2109049504;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1939013632;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)444465153;
				if (num != 0)
				{
				}
				num = (short)1055064064;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataVpnTunnel_43365.Visible;
			}
			set
			{
				short num = (short)1316207858;
				short num2 = num;
				num = (short)2122956018;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1591934976;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1131216897;
				if (num != 0)
				{
				}
				num = (short)41287680;
				if (num != 0)
				{
				}
				this.dataWideExternalDataVpnTunnel_43365.Visible = value;
			}
		}

		// Token: 0x170050F9 RID: 20729
		// (get) Token: 0x0600A1B2 RID: 41394 RVA: 0x00970BA4 File Offset: 0x0096EDA4
		// (set) Token: 0x0600A1B3 RID: 41395 RVA: 0x00970C58 File Offset: 0x0096EE58
		public bool DataWideExternalDataVpnTunnel_43365_Editable
		{
			get
			{
				short num = (short)362279659;
				short num2 = num;
				num = (short)761524971;
				switch (num2 == num)
				{
				default:
				{
					num = (short)367919104;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)875560961;
				if (num != 0)
				{
				}
				num = (short)367788032;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataVpnTunnel_43365.Editable;
			}
			set
			{
				short num = (short)183029485;
				short num2 = num;
				num = (short)43044589;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1629683712;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)267583488;
				if (num != 0)
				{
				}
				num = (short)937295873;
				if (num != 0)
				{
				}
				this.dataWideExternalDataVpnTunnel_43365.Editable = value;
			}
		}

		// Token: 0x170050FA RID: 20730
		// (get) Token: 0x0600A1B4 RID: 41396 RVA: 0x00970D0C File Offset: 0x0096EF0C
		internal string DataWideExternalDataVpnTunnel_43365_UILabel
		{
			get
			{
				short num = (short)419823617;
				if (num != 0)
				{
				}
				num = (short)2058944512;
				short num2 = num;
				num = (short)460710588;
				short num3 = num;
				num = (short)330031804;
				switch (num3 == num)
				{
				}
				num = (short)915734528;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataVpnTunnel_43365.UIName;
			}
		}

		// Token: 0x170050FB RID: 20731
		// (get) Token: 0x0600A1B5 RID: 41397 RVA: 0x00970DC4 File Offset: 0x0096EFC4
		// (set) Token: 0x0600A1B6 RID: 41398 RVA: 0x00970E78 File Offset: 0x0096F078
		internal bool DataWideExternalDataVpnTunnel_43365_HiddenStatic
		{
			get
			{
				short num = (short)287134998;
				short num2 = num;
				num = (short)870077718;
				switch (num2 == num)
				{
				default:
				{
					num = (short)497156096;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1041956865;
				if (num != 0)
				{
				}
				num = (short)1018101760;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataVpnTunnel_43365.HiddenStatic;
			}
			set
			{
				short num = (short)2046033921;
				if (num != 0)
				{
				}
				num = (short)712048640;
				short num2 = num;
				num = (short)1517347498;
				short num3 = num;
				num = (short)977789610;
				switch (num3 == num)
				{
				}
				num = (short)440074240;
				if (num != 0)
				{
				}
				this.dataWideExternalDataVpnTunnel_43365.HiddenStatic = value;
			}
		}

		// Token: 0x170050FC RID: 20732
		// (get) Token: 0x0600A1B7 RID: 41399 RVA: 0x00970F2C File Offset: 0x0096F12C
		// (set) Token: 0x0600A1B8 RID: 41400 RVA: 0x00970FE0 File Offset: 0x0096F1E0
		internal bool DataWideExternalDataVpnTunnel_43365_HiddenDynamic
		{
			get
			{
				short num = (short)1255788930;
				short num2 = num;
				num = (short)1651298690;
				switch (num2 == num)
				{
				default:
				{
					num = (short)310640640;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)713293825;
				if (num != 0)
				{
				}
				num = (short)58851328;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataVpnTunnel_43365.HiddenDynamic;
			}
			set
			{
				short num = (short)366251428;
				short num2 = num;
				num = (short)331779492;
				switch (num2 == num)
				{
				default:
				{
					num = (short)555220992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)789577729;
				if (num != 0)
				{
				}
				num = (short)329187328;
				if (num != 0)
				{
				}
				this.dataWideExternalDataVpnTunnel_43365.HiddenDynamic = value;
			}
		}

		// Token: 0x170050FD RID: 20733
		// (get) Token: 0x0600A1B9 RID: 41401 RVA: 0x00971094 File Offset: 0x0096F294
		public bool DataWideExternalDataVpnTunnel_43365_HasDiffs
		{
			get
			{
				short num = (short)2006511477;
				short num2 = num;
				num = (short)1288695669;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1706229760;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)284164097;
				if (num != 0)
				{
				}
				num = (short)815267840;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataVpnTunnel_43365._HasDiffs;
			}
		}

		// Token: 0x170050FE RID: 20734
		// (get) Token: 0x0600A1BA RID: 41402 RVA: 0x0097114C File Offset: 0x0096F34C
		// (set) Token: 0x0600A1BB RID: 41403 RVA: 0x00971200 File Offset: 0x0096F400
		public int DataWideExternalDataOORTime_43366Value
		{
			get
			{
				short num = (short)2114330191;
				short num2 = num;
				num = (short)1731796559;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1838809088;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)378667009;
				if (num != 0)
				{
				}
				num = (short)1269563392;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataOORTime_43366.Value;
			}
			set
			{
				short num = (short)1138458029;
				short num2 = num;
				num = (short)1811250605;
				switch (num2 == num)
				{
				default:
				{
					num = (short)350617600;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1398407169;
				if (num != 0)
				{
				}
				num = (short)385155072;
				if (num != 0)
				{
				}
				this.dataWideExternalDataOORTime_43366.Value = value;
			}
		}

		// Token: 0x170050FF RID: 20735
		// (get) Token: 0x0600A1BC RID: 41404 RVA: 0x009712B4 File Offset: 0x0096F4B4
		public global::AcpBusinessLayer.AcpSimpleRangeField DataWideExternalDataOORTime_43366
		{
			get
			{
				short num = (short)1268699398;
				short num2 = num;
				num = (short)1849217286;
				switch (num2 == num)
				{
				default:
				{
					num = (short)59244544;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1414201345;
				if (num != 0)
				{
				}
				num = (short)808517632;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataOORTime_43366;
			}
		}

		// Token: 0x17005100 RID: 20736
		// (get) Token: 0x0600A1BD RID: 41405 RVA: 0x00971364 File Offset: 0x0096F564
		// (set) Token: 0x0600A1BE RID: 41406 RVA: 0x00971418 File Offset: 0x0096F618
		public string DataWideExternalDataOORTime_43366_UIValue
		{
			get
			{
				short num = (short)1139399070;
				short num2 = num;
				num = (short)1193859486;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1233190912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)455213056;
				if (num != 0)
				{
				}
				num = (short)962396161;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataOORTime_43366.UIValue;
			}
			set
			{
				short num = (short)1624166639;
				short num2 = num;
				num = (short)1977012463;
				switch (num2 == num)
				{
				default:
				{
					num = (short)675741696;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1602945024;
				if (num != 0)
				{
				}
				num = (short)2070675457;
				if (num != 0)
				{
				}
				this.dataWideExternalDataOORTime_43366.UIValue = value;
			}
		}

		// Token: 0x17005101 RID: 20737
		// (get) Token: 0x0600A1BF RID: 41407 RVA: 0x009714D0 File Offset: 0x0096F6D0
		// (set) Token: 0x0600A1C0 RID: 41408 RVA: 0x00971588 File Offset: 0x0096F788
		internal int DataWideExternalDataOORTime_43366Min
		{
			get
			{
				short num = (short)434110465;
				if (num != 0)
				{
				}
				num = (short)1507131392;
				short num2 = num;
				num = (short)345573492;
				short num3 = num;
				num = (short)20580468;
				switch (num3 == num)
				{
				}
				num = (short)2115567616;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataOORTime_43366.Min;
			}
			set
			{
				short num = (short)1496428620;
				short num2 = num;
				num = (short)2041163852;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1301807104;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)586809345;
				if (num != 0)
				{
				}
				num = (short)1054736384;
				if (num != 0)
				{
				}
				this.dataWideExternalDataOORTime_43366.Min = value;
			}
		}

		// Token: 0x17005102 RID: 20738
		// (get) Token: 0x0600A1C1 RID: 41409 RVA: 0x00971640 File Offset: 0x0096F840
		// (set) Token: 0x0600A1C2 RID: 41410 RVA: 0x009716F4 File Offset: 0x0096F8F4
		internal int DataWideExternalDataOORTime_43366Max
		{
			get
			{
				short num = (short)1150923309;
				short num2 = num;
				num = (short)193835565;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1792606208;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)845283329;
				if (num != 0)
				{
				}
				num = (short)1414004736;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataOORTime_43366.Max;
			}
			set
			{
				short num = (short)1459997628;
				short num2 = num;
				num = (short)529779644;
				switch (num2 == num)
				{
				default:
				{
					num = (short)270467072;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)149356545;
				if (num != 0)
				{
				}
				num = (short)1949696000;
				if (num != 0)
				{
				}
				this.dataWideExternalDataOORTime_43366.Max = value;
			}
		}

		// Token: 0x17005103 RID: 20739
		// (get) Token: 0x0600A1C3 RID: 41411 RVA: 0x009717AC File Offset: 0x0096F9AC
		// (set) Token: 0x0600A1C4 RID: 41412 RVA: 0x00971864 File Offset: 0x0096FA64
		internal int DataWideExternalDataOORTime_43366Step
		{
			get
			{
				short num = (short)679280640;
				short num2 = num;
				num = (short)34056357;
				short num3 = num;
				num = (short)1808836773;
				switch (num3 == num)
				{
				}
				num = (short)1779564545;
				if (num != 0)
				{
				}
				num = (short)465371136;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataOORTime_43366.StepSize;
			}
			set
			{
				short num = (short)2132213760;
				short num2 = num;
				num = (short)1400577002;
				short num3 = num;
				num = (short)1536170986;
				switch (num3 == num)
				{
				}
				num = (short)1798373377;
				if (num != 0)
				{
				}
				num = (short)188088320;
				if (num != 0)
				{
				}
				this.dataWideExternalDataOORTime_43366.StepSize = value;
			}
		}

		// Token: 0x17005104 RID: 20740
		// (get) Token: 0x0600A1C5 RID: 41413 RVA: 0x00971918 File Offset: 0x0096FB18
		// (set) Token: 0x0600A1C6 RID: 41414 RVA: 0x009719CC File Offset: 0x0096FBCC
		public bool DataWideExternalDataOORTime_43366_Applicable
		{
			get
			{
				short num = (short)17301504;
				short num2 = num;
				num = (short)1793033989;
				short num3 = num;
				num = (short)467764997;
				switch (num3 == num)
				{
				}
				num = (short)1669660673;
				if (num != 0)
				{
				}
				num = (short)1341259776;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataOORTime_43366.Applicable;
			}
			set
			{
				short num = (short)473104384;
				short num2 = num;
				num = (short)933663926;
				short num3 = num;
				num = (short)1018860726;
				switch (num3 == num)
				{
				}
				num = (short)1859256321;
				if (num != 0)
				{
				}
				num = (short)1808531456;
				if (num != 0)
				{
				}
				this.dataWideExternalDataOORTime_43366.Applicable = value;
			}
		}

		// Token: 0x17005105 RID: 20741
		// (get) Token: 0x0600A1C7 RID: 41415 RVA: 0x00971A80 File Offset: 0x0096FC80
		// (set) Token: 0x0600A1C8 RID: 41416 RVA: 0x00971B34 File Offset: 0x0096FD34
		public bool DataWideExternalDataOORTime_43366_Valid
		{
			get
			{
				short num = (short)1432354816;
				short num2 = num;
				num = (short)1695547393;
				if (num != 0)
				{
				}
				num = (short)676563851;
				short num3 = num;
				num = (short)1034062731;
				switch (num3 == num)
				{
				}
				num = (short)282460160;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataOORTime_43366.Valid;
			}
			set
			{
				short num = (short)1190723584;
				short num2 = num;
				num = (short)965792858;
				short num3 = num;
				num = (short)972936282;
				switch (num3 == num)
				{
				}
				num = (short)196018176;
				if (num != 0)
				{
				}
				num = (short)393281537;
				if (num != 0)
				{
				}
				this.dataWideExternalDataOORTime_43366.Valid = value;
			}
		}

		// Token: 0x17005106 RID: 20742
		// (get) Token: 0x0600A1C9 RID: 41417 RVA: 0x00971BE8 File Offset: 0x0096FDE8
		// (set) Token: 0x0600A1CA RID: 41418 RVA: 0x00971CA0 File Offset: 0x0096FEA0
		public bool DataWideExternalDataOORTime_43366_Visible
		{
			get
			{
				short num = (short)378535936;
				short num2 = num;
				num = (short)654037125;
				short num3 = num;
				num = (short)74371205;
				switch (num3 == num)
				{
				}
				num = (short)290586624;
				if (num != 0)
				{
				}
				num = (short)781254657;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataOORTime_43366.Visible;
			}
			set
			{
				short num = (short)994377728;
				short num2 = num;
				num = (short)166808239;
				short num3 = num;
				num = (short)956517039;
				switch (num3 == num)
				{
				}
				num = (short)2140798977;
				if (num != 0)
				{
				}
				num = (short)1620443136;
				if (num != 0)
				{
				}
				this.dataWideExternalDataOORTime_43366.Visible = value;
			}
		}

		// Token: 0x17005107 RID: 20743
		// (get) Token: 0x0600A1CB RID: 41419 RVA: 0x00971D54 File Offset: 0x0096FF54
		// (set) Token: 0x0600A1CC RID: 41420 RVA: 0x00971E08 File Offset: 0x00970008
		public bool DataWideExternalDataOORTime_43366_Editable
		{
			get
			{
				short num = (short)1974468608;
				short num2 = num;
				num = (short)1090919516;
				short num3 = num;
				num = (short)1001659484;
				switch (num3 == num)
				{
				}
				num = (short)338100225;
				if (num != 0)
				{
				}
				num = (short)373620736;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataOORTime_43366.Editable;
			}
			set
			{
				short num = (short)805175296;
				short num2 = num;
				num = (short)908261430;
				short num3 = num;
				num = (short)730593334;
				switch (num3 == num)
				{
				}
				num = (short)1018232832;
				if (num != 0)
				{
				}
				num = (short)138608641;
				if (num != 0)
				{
				}
				this.dataWideExternalDataOORTime_43366.Editable = value;
			}
		}

		// Token: 0x17005108 RID: 20744
		// (get) Token: 0x0600A1CD RID: 41421 RVA: 0x00971EC0 File Offset: 0x009700C0
		internal string DataWideExternalDataOORTime_43366_UILabel
		{
			get
			{
				short num = (short)1680867328;
				short num2 = num;
				num = (short)1570281006;
				short num3 = num;
				num = (short)2047383086;
				switch (num3 == num)
				{
				}
				num = (short)1520631808;
				if (num != 0)
				{
				}
				num = (short)2120286209;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataOORTime_43366.UIName;
			}
		}

		// Token: 0x17005109 RID: 20745
		// (get) Token: 0x0600A1CE RID: 41422 RVA: 0x00971F78 File Offset: 0x00970178
		// (set) Token: 0x0600A1CF RID: 41423 RVA: 0x00972030 File Offset: 0x00970230
		internal bool DataWideExternalDataOORTime_43366_HiddenStatic
		{
			get
			{
				short num = (short)166330368;
				short num2 = num;
				num = (short)1914584648;
				short num3 = num;
				num = (short)948584008;
				switch (num3 == num)
				{
				}
				num = (short)1861550081;
				if (num != 0)
				{
				}
				num = (short)434438144;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataOORTime_43366.HiddenStatic;
			}
			set
			{
				short num = (short)1026818048;
				short num2 = num;
				num = (short)896938343;
				short num3 = num;
				num = (short)1405497703;
				switch (num3 == num)
				{
				}
				num = (short)294322177;
				if (num != 0)
				{
				}
				num = (short)1634009088;
				if (num != 0)
				{
				}
				this.dataWideExternalDataOORTime_43366.HiddenStatic = value;
			}
		}

		// Token: 0x1700510A RID: 20746
		// (get) Token: 0x0600A1D0 RID: 41424 RVA: 0x009720E8 File Offset: 0x009702E8
		// (set) Token: 0x0600A1D1 RID: 41425 RVA: 0x0097219C File Offset: 0x0097039C
		internal bool DataWideExternalDataOORTime_43366_HiddenDynamic
		{
			get
			{
				short num = (short)1522663424;
				short num2 = num;
				num = (short)2030858206;
				short num3 = num;
				num = (short)1714581470;
				switch (num3 == num)
				{
				}
				num = (short)1800667137;
				if (num != 0)
				{
				}
				num = (short)1557790720;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataOORTime_43366.HiddenDynamic;
			}
			set
			{
				short num = (short)953548800;
				short num2 = num;
				num = (short)1921992709;
				short num3 = num;
				num = (short)1443186693;
				switch (num3 == num)
				{
				}
				num = (short)924647425;
				if (num != 0)
				{
				}
				num = (short)200278016;
				if (num != 0)
				{
				}
				this.dataWideExternalDataOORTime_43366.HiddenDynamic = value;
			}
		}

		// Token: 0x1700510B RID: 20747
		// (get) Token: 0x0600A1D2 RID: 41426 RVA: 0x00972250 File Offset: 0x00970450
		public bool DataWideExternalDataOORTime_43366_HasDiffs
		{
			get
			{
				short num = (short)1002831872;
				short num2 = num;
				num = (short)2083979265;
				if (num != 0)
				{
				}
				num = (short)243108964;
				short num3 = num;
				num = (short)1768524900;
				switch (num3 == num)
				{
				}
				num = (short)326696960;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataOORTime_43366._HasDiffs;
			}
		}

		// Token: 0x1700510C RID: 20748
		// (get) Token: 0x0600A1D3 RID: 41427 RVA: 0x00972304 File Offset: 0x00970504
		// (set) Token: 0x0600A1D4 RID: 41428 RVA: 0x009723B8 File Offset: 0x009705B8
		public int DataWideExternalDataModemOpenTime_43367Value
		{
			get
			{
				short num = (short)989790208;
				short num2 = num;
				num = (short)599285979;
				short num3 = num;
				num = (short)1729913051;
				switch (num3 == num)
				{
				}
				num = (short)1881997313;
				if (num != 0)
				{
				}
				num = (short)2022309888;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemOpenTime_43367.Value;
			}
			set
			{
				short num = (short)691732480;
				short num2 = num;
				num = (short)1145761006;
				short num3 = num;
				num = (short)734588142;
				switch (num3 == num)
				{
				}
				num = (short)355401729;
				if (num != 0)
				{
				}
				num = (short)424148992;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemOpenTime_43367.Value = value;
			}
		}

		// Token: 0x1700510D RID: 20749
		// (get) Token: 0x0600A1D5 RID: 41429 RVA: 0x0097246C File Offset: 0x0097066C
		public global::AcpBusinessLayer.AcpSimpleRangeField DataWideExternalDataModemOpenTime_43367
		{
			get
			{
				short num = (short)2037514240;
				short num2 = num;
				num = (short)1809935936;
				short num3 = num;
				num = (short)465071680;
				switch (num3 == num)
				{
				}
				num = (short)1909260288;
				if (num != 0)
				{
				}
				num = (short)793247745;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemOpenTime_43367;
			}
		}

		// Token: 0x1700510E RID: 20750
		// (get) Token: 0x0600A1D6 RID: 41430 RVA: 0x0097251C File Offset: 0x0097071C
		// (set) Token: 0x0600A1D7 RID: 41431 RVA: 0x009725D0 File Offset: 0x009707D0
		public string DataWideExternalDataModemOpenTime_43367_UIValue
		{
			get
			{
				short num = (short)77791232;
				short num2 = num;
				num = (short)2011617587;
				short num3 = num;
				num = (short)154720563;
				switch (num3 == num)
				{
				}
				num = (short)1190330369;
				if (num != 0)
				{
				}
				num = (short)1438646272;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemOpenTime_43367.UIValue;
			}
			set
			{
				short num = (short)798490624;
				short num2 = num;
				num = (short)297124213;
				short num3 = num;
				num = (short)157663605;
				switch (num3 == num)
				{
				}
				num = (short)724434945;
				if (num != 0)
				{
				}
				num = (short)1109065728;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemOpenTime_43367.UIValue = value;
			}
		}

		// Token: 0x1700510F RID: 20751
		// (get) Token: 0x0600A1D8 RID: 41432 RVA: 0x00972688 File Offset: 0x00970888
		// (set) Token: 0x0600A1D9 RID: 41433 RVA: 0x00972740 File Offset: 0x00970940
		internal int DataWideExternalDataModemOpenTime_43367Min
		{
			get
			{
				short num = (short)824049664;
				short num2 = num;
				num = (short)325770345;
				short num3 = num;
				num = (short)86170729;
				switch (num3 == num)
				{
				}
				num = (short)1368915968;
				if (num != 0)
				{
				}
				num = (short)638779393;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemOpenTime_43367.Min;
			}
			set
			{
				short num = (short)235995136;
				short num2 = num;
				num = (short)1746014609;
				short num3 = num;
				num = (short)402264465;
				switch (num3 == num)
				{
				}
				num = (short)1124532225;
				if (num != 0)
				{
				}
				num = (short)2081161216;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemOpenTime_43367.Min = value;
			}
		}

		// Token: 0x17005110 RID: 20752
		// (get) Token: 0x0600A1DA RID: 41434 RVA: 0x009727F4 File Offset: 0x009709F4
		// (set) Token: 0x0600A1DB RID: 41435 RVA: 0x009728A8 File Offset: 0x00970AA8
		internal int DataWideExternalDataModemOpenTime_43367Max
		{
			get
			{
				short num = (short)411435008;
				short num2 = num;
				num = (short)228444951;
				short num3 = num;
				num = (short)146524951;
				switch (num3 == num)
				{
				}
				num = (short)1027407872;
				if (num != 0)
				{
				}
				num = (short)1146159105;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemOpenTime_43367.Max;
			}
			set
			{
				short num = (short)1268645888;
				short num2 = num;
				num = (short)611188737;
				if (num != 0)
				{
				}
				num = (short)155265009;
				short num3 = num;
				num = (short)1475291121;
				switch (num3 == num)
				{
				}
				num = (short)1720778752;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemOpenTime_43367.Max = value;
			}
		}

		// Token: 0x17005111 RID: 20753
		// (get) Token: 0x0600A1DC RID: 41436 RVA: 0x00972960 File Offset: 0x00970B60
		// (set) Token: 0x0600A1DD RID: 41437 RVA: 0x00972A18 File Offset: 0x00970C18
		internal int DataWideExternalDataModemOpenTime_43367Step
		{
			get
			{
				short num = (short)870711296;
				short num2 = num;
				num = (short)1020813979;
				short num3 = num;
				num = (short)219964059;
				switch (num3 == num)
				{
				}
				num = (short)1619460096;
				if (num != 0)
				{
				}
				num = (short)632881153;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemOpenTime_43367.StepSize;
			}
			set
			{
				short num = (short)790953984;
				short num2 = num;
				num = (short)1155956606;
				short num3 = num;
				num = (short)264535934;
				switch (num3 == num)
				{
				}
				num = (short)1161822209;
				if (num != 0)
				{
				}
				num = (short)632487936;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemOpenTime_43367.StepSize = value;
			}
		}

		// Token: 0x17005112 RID: 20754
		// (get) Token: 0x0600A1DE RID: 41438 RVA: 0x00972ACC File Offset: 0x00970CCC
		// (set) Token: 0x0600A1DF RID: 41439 RVA: 0x00972B7C File Offset: 0x00970D7C
		public bool DataWideExternalDataModemOpenTime_43367_Applicable
		{
			get
			{
				short num = (short)1442054144;
				short num2 = num;
				num = (short)132513793;
				if (num != 0)
				{
				}
				num = (short)1678798760;
				short num3 = num;
				num = (short)1861644200;
				switch (num3 == num)
				{
				}
				num = (short)993853440;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemOpenTime_43367.Applicable;
			}
			set
			{
				short num = (short)439418880;
				short num2 = num;
				num = (short)1890939715;
				short num3 = num;
				num = (short)591033155;
				switch (num3 == num)
				{
				}
				num = (short)1357185025;
				if (num != 0)
				{
				}
				num = (short)733544448;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemOpenTime_43367.Applicable = value;
			}
		}

		// Token: 0x17005113 RID: 20755
		// (get) Token: 0x0600A1E0 RID: 41440 RVA: 0x00972C30 File Offset: 0x00970E30
		// (set) Token: 0x0600A1E1 RID: 41441 RVA: 0x00972CE4 File Offset: 0x00970EE4
		public bool DataWideExternalDataModemOpenTime_43367_Valid
		{
			get
			{
				short num = (short)1340604416;
				short num2 = num;
				num = (short)355406222;
				short num3 = num;
				num = (short)742658446;
				switch (num3 == num)
				{
				}
				num = (short)1523056641;
				if (num != 0)
				{
				}
				num = (short)3080192;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemOpenTime_43367.Valid;
			}
			set
			{
				short num = (short)1087766528;
				short num2 = num;
				num = (short)843921110;
				short num3 = num;
				num = (short)1666070230;
				switch (num3 == num)
				{
				}
				num = (short)564330497;
				if (num != 0)
				{
				}
				num = (short)348585984;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemOpenTime_43367.Valid = value;
			}
		}

		// Token: 0x17005114 RID: 20756
		// (get) Token: 0x0600A1E2 RID: 41442 RVA: 0x00972D98 File Offset: 0x00970F98
		// (set) Token: 0x0600A1E3 RID: 41443 RVA: 0x00972E4C File Offset: 0x0097104C
		public bool DataWideExternalDataModemOpenTime_43367_Visible
		{
			get
			{
				short num = (short)238813184;
				short num2 = num;
				num = (short)523682956;
				short num3 = num;
				num = (short)369542284;
				switch (num3 == num)
				{
				}
				num = (short)618659841;
				if (num != 0)
				{
				}
				num = (short)1952448512;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemOpenTime_43367.Visible;
			}
			set
			{
				short num = (short)603864143;
				short num2 = num;
				num = (short)1975860303;
				switch (num2 == num)
				{
				}
				num = (short)420216832;
				short num3 = num;
				num = (short)8126464;
				if (num != 0)
				{
				}
				num = (short)1750335489;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemOpenTime_43367.Visible = value;
			}
		}

		// Token: 0x17005115 RID: 20757
		// (get) Token: 0x0600A1E4 RID: 41444 RVA: 0x00972F00 File Offset: 0x00971100
		// (set) Token: 0x0600A1E5 RID: 41445 RVA: 0x00972FB4 File Offset: 0x009711B4
		public bool DataWideExternalDataModemOpenTime_43367_Editable
		{
			get
			{
				short num = (short)421335312;
				short num2 = num;
				num = (short)870846736;
				switch (num2 == num)
				{
				}
				num = (short)1430650880;
				short num3 = num;
				num = (short)683868161;
				if (num != 0)
				{
				}
				num = (short)1234501632;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemOpenTime_43367.Editable;
			}
			set
			{
				short num = (short)1488629113;
				short num2 = num;
				num = (short)2079042937;
				switch (num2 == num)
				{
				}
				num = (short)1291583488;
				short num3 = num;
				num = (short)1887043585;
				if (num != 0)
				{
				}
				num = (short)1440612352;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemOpenTime_43367.Editable = value;
			}
		}

		// Token: 0x17005116 RID: 20758
		// (get) Token: 0x0600A1E6 RID: 41446 RVA: 0x00973068 File Offset: 0x00971268
		internal string DataWideExternalDataModemOpenTime_43367_UILabel
		{
			get
			{
				short num = (short)342273874;
				short num2 = num;
				num = (short)1141026642;
				switch (num2 == num)
				{
				}
				num = (short)522125312;
				short num3 = num;
				num = (short)1183383553;
				if (num != 0)
				{
				}
				num = (short)186646528;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemOpenTime_43367.UIName;
			}
		}

		// Token: 0x17005117 RID: 20759
		// (get) Token: 0x0600A1E7 RID: 41447 RVA: 0x0097311C File Offset: 0x0097131C
		// (set) Token: 0x0600A1E8 RID: 41448 RVA: 0x009731D0 File Offset: 0x009713D0
		internal bool DataWideExternalDataModemOpenTime_43367_HiddenStatic
		{
			get
			{
				short num = (short)735969281;
				if (num != 0)
				{
				}
				num = (short)494994330;
				short num2 = num;
				num = (short)1744503706;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2077753344;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2121531392;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemOpenTime_43367.HiddenStatic;
			}
			set
			{
				short num = (short)166209596;
				short num2 = num;
				num = (short)1370695740;
				switch (num2 == num)
				{
				}
				num = (short)1488584704;
				short num3 = num;
				num = (short)894631936;
				if (num != 0)
				{
				}
				num = (short)1048051713;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemOpenTime_43367.HiddenStatic = value;
			}
		}

		// Token: 0x17005118 RID: 20760
		// (get) Token: 0x0600A1E9 RID: 41449 RVA: 0x00973284 File Offset: 0x00971484
		// (set) Token: 0x0600A1EA RID: 41450 RVA: 0x00973338 File Offset: 0x00971538
		internal bool DataWideExternalDataModemOpenTime_43367_HiddenDynamic
		{
			get
			{
				short num = (short)241106945;
				if (num != 0)
				{
				}
				num = (short)116680543;
				short num2 = num;
				num = (short)453666655;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1127415808;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1736114176;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemOpenTime_43367.HiddenDynamic;
			}
			set
			{
				short num = (short)1697120257;
				if (num != 0)
				{
				}
				num = (short)1956444819;
				short num2 = num;
				num = (short)854194835;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1217462272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1012858880;
				if (num != 0)
				{
				}
				this.dataWideExternalDataModemOpenTime_43367.HiddenDynamic = value;
			}
		}

		// Token: 0x17005119 RID: 20761
		// (get) Token: 0x0600A1EB RID: 41451 RVA: 0x009733EC File Offset: 0x009715EC
		public bool DataWideExternalDataModemOpenTime_43367_HasDiffs
		{
			get
			{
				short num = (short)1059459639;
				short num2 = num;
				num = (short)476910135;
				switch (num2 == num)
				{
				}
				num = (short)800980992;
				short num3 = num;
				num = (short)666173441;
				if (num != 0)
				{
				}
				num = (short)1127481344;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemOpenTime_43367._HasDiffs;
			}
		}

		// Token: 0x1700511A RID: 20762
		// (get) Token: 0x0600A1EC RID: 41452 RVA: 0x009734A0 File Offset: 0x009716A0
		// (set) Token: 0x0600A1ED RID: 41453 RVA: 0x00973558 File Offset: 0x00971758
		public string DataWideMG90WirelessVPNFriendlyName_43785Value
		{
			get
			{
				short num = (short)1035143783;
				short num2 = num;
				num = (short)1465780839;
				switch (num2 == num)
				{
				}
				num = (short)712245248;
				short num3 = num;
				num = (short)1666777088;
				if (num != 0)
				{
				}
				num = (short)1634336769;
				if (num != 0)
				{
				}
				return this.dataWideMG90WirelessVPNFriendlyName_43785.Value;
			}
			set
			{
				short num = (short)1190250062;
				short num2 = num;
				num = (short)524797518;
				switch (num2 == num)
				{
				}
				num = (short)1803223040;
				short num3 = num;
				num = (short)2086010880;
				if (num != 0)
				{
				}
				num = (short)1316880385;
				if (num != 0)
				{
				}
				this.dataWideMG90WirelessVPNFriendlyName_43785.Value = value;
			}
		}

		// Token: 0x1700511B RID: 20763
		// (get) Token: 0x0600A1EE RID: 41454 RVA: 0x0097360C File Offset: 0x0097180C
		public global::AcpBusinessLayer.AcpField<string> DataWideMG90WirelessVPNFriendlyName_43785
		{
			get
			{
				short num = (short)811325771;
				short num2 = num;
				num = (short)714725707;
				switch (num2 == num)
				{
				}
				num = (short)1730805760;
				short num3 = num;
				num = (short)1144127489;
				if (num != 0)
				{
				}
				num = (short)729612288;
				if (num != 0)
				{
				}
				return this.dataWideMG90WirelessVPNFriendlyName_43785;
			}
		}

		// Token: 0x1700511C RID: 20764
		// (get) Token: 0x0600A1EF RID: 41455 RVA: 0x009736C0 File Offset: 0x009718C0
		// (set) Token: 0x0600A1F0 RID: 41456 RVA: 0x00973770 File Offset: 0x00971970
		public string DataWideMG90WirelessVPNFriendlyName_43785_UIValue
		{
			get
			{
				short num = (short)1260255094;
				short num2 = num;
				num = (short)1433335670;
				switch (num2 == num)
				{
				}
				num = (short)452919296;
				short num3 = num;
				num = (short)1848049665;
				if (num != 0)
				{
				}
				num = (short)1341325312;
				if (num != 0)
				{
				}
				return this.dataWideMG90WirelessVPNFriendlyName_43785.Value;
			}
			set
			{
				short num = (short)2050142508;
				short num2 = num;
				num = (short)1702408492;
				switch (num2 == num)
				{
				}
				num = (short)202899456;
				short num3 = num;
				num = (short)2080636928;
				if (num != 0)
				{
				}
				num = (short)1063780353;
				if (num != 0)
				{
				}
				this.dataWideMG90WirelessVPNFriendlyName_43785.Value = value;
			}
		}

		// Token: 0x1700511D RID: 20765
		// (get) Token: 0x0600A1F1 RID: 41457 RVA: 0x00973828 File Offset: 0x00971A28
		// (set) Token: 0x0600A1F2 RID: 41458 RVA: 0x009738D8 File Offset: 0x00971AD8
		public bool DataWideMG90WirelessVPNFriendlyName_43785_Applicable
		{
			get
			{
				short num = (short)557378792;
				short num2 = num;
				num = (short)426896616;
				switch (num2 == num)
				{
				}
				num = (short)1045757952;
				short num3 = num;
				num = (short)780599297;
				if (num != 0)
				{
				}
				num = (short)499974144;
				if (num != 0)
				{
				}
				return this.dataWideMG90WirelessVPNFriendlyName_43785.Applicable;
			}
			set
			{
				short num = (short)245435854;
				short num2 = num;
				num = (short)1269566926;
				switch (num2 == num)
				{
				}
				num = (short)766443520;
				short num3 = num;
				num = (short)1334181888;
				if (num != 0)
				{
				}
				num = (short)1434189825;
				if (num != 0)
				{
				}
				this.dataWideMG90WirelessVPNFriendlyName_43785.Applicable = value;
			}
		}

		// Token: 0x1700511E RID: 20766
		// (get) Token: 0x0600A1F3 RID: 41459 RVA: 0x00973990 File Offset: 0x00971B90
		// (set) Token: 0x0600A1F4 RID: 41460 RVA: 0x00973A44 File Offset: 0x00971C44
		public bool DataWideMG90WirelessVPNFriendlyName_43785_Valid
		{
			get
			{
				short num = (short)109611264;
				short num2 = num;
				num = (short)753830144;
				switch (num2 == num)
				{
				}
				num = (short)929169408;
				short num3 = num;
				num = (short)996016129;
				if (num != 0)
				{
				}
				num = (short)1363673088;
				if (num != 0)
				{
				}
				return this.dataWideMG90WirelessVPNFriendlyName_43785.Valid;
			}
			set
			{
				short num = (short)1276923193;
				short num2 = num;
				num = (short)1287736633;
				switch (num2 == num)
				{
				}
				num = (short)684916736;
				short num3 = num;
				num = (short)477757441;
				if (num != 0)
				{
				}
				num = (short)439156736;
				if (num != 0)
				{
				}
				this.dataWideMG90WirelessVPNFriendlyName_43785.Valid = value;
			}
		}

		// Token: 0x1700511F RID: 20767
		// (get) Token: 0x0600A1F5 RID: 41461 RVA: 0x00973AFC File Offset: 0x00971CFC
		// (set) Token: 0x0600A1F6 RID: 41462 RVA: 0x00973BB0 File Offset: 0x00971DB0
		public bool DataWideMG90WirelessVPNFriendlyName_43785_Visible
		{
			get
			{
				short num = (short)640512019;
				short num2 = num;
				num = (short)618491923;
				switch (num2 == num)
				{
				}
				num = (short)1485570048;
				short num3 = num;
				num = (short)1866858497;
				if (num != 0)
				{
				}
				num = (short)1418395648;
				if (num != 0)
				{
				}
				return this.dataWideMG90WirelessVPNFriendlyName_43785.Visible;
			}
			set
			{
				short num = (short)1000020870;
				short num2 = num;
				num = (short)520166278;
				switch (num2 == num)
				{
				}
				num = (short)700710912;
				short num3 = num;
				num = (short)2077818881;
				if (num != 0)
				{
				}
				num = (short)514195456;
				if (num != 0)
				{
				}
				this.dataWideMG90WirelessVPNFriendlyName_43785.Visible = value;
			}
		}

		// Token: 0x17005120 RID: 20768
		// (get) Token: 0x0600A1F7 RID: 41463 RVA: 0x00973C6C File Offset: 0x00971E6C
		// (set) Token: 0x0600A1F8 RID: 41464 RVA: 0x00973D20 File Offset: 0x00971F20
		public bool DataWideMG90WirelessVPNFriendlyName_43785_Editable
		{
			get
			{
				short num = (short)205341196;
				short num2 = num;
				num = (short)262291980;
				switch (num2 == num)
				{
				}
				num = (short)930938880;
				short num3 = num;
				num = (short)1000013824;
				if (num != 0)
				{
				}
				num = (short)1954086913;
				if (num != 0)
				{
				}
				return this.dataWideMG90WirelessVPNFriendlyName_43785.Editable;
			}
			set
			{
				short num = (short)1401542905;
				short num2 = num;
				num = (short)165468409;
				switch (num2 == num)
				{
				}
				num = (short)543358976;
				short num3 = num;
				num = (short)637403137;
				if (num != 0)
				{
				}
				num = (short)23461888;
				if (num != 0)
				{
				}
				this.dataWideMG90WirelessVPNFriendlyName_43785.Editable = value;
			}
		}

		// Token: 0x17005121 RID: 20769
		// (get) Token: 0x0600A1F9 RID: 41465 RVA: 0x00973DD4 File Offset: 0x00971FD4
		internal string DataWideMG90WirelessVPNFriendlyName_43785_UILabel
		{
			get
			{
				short num = (short)1412696647;
				short num2 = num;
				num = (short)1914440263;
				switch (num2 == num)
				{
				}
				num = (short)1039007744;
				short num3 = num;
				num = (short)848232448;
				if (num != 0)
				{
				}
				num = (short)1699282945;
				if (num != 0)
				{
				}
				return this.dataWideMG90WirelessVPNFriendlyName_43785.UIName;
			}
		}

		// Token: 0x17005122 RID: 20770
		// (get) Token: 0x0600A1FA RID: 41466 RVA: 0x00973E8C File Offset: 0x0097208C
		// (set) Token: 0x0600A1FB RID: 41467 RVA: 0x00973F40 File Offset: 0x00972140
		internal bool DataWideMG90WirelessVPNFriendlyName_43785_HiddenStatic
		{
			get
			{
				short num = (short)86232123;
				short num2 = num;
				num = (short)765054011;
				switch (num2 == num)
				{
				}
				num = (short)609746944;
				short num3 = num;
				num = (short)1479868417;
				if (num != 0)
				{
				}
				num = (short)1102643200;
				if (num != 0)
				{
				}
				return this.dataWideMG90WirelessVPNFriendlyName_43785.HiddenStatic;
			}
			set
			{
				short num = (short)682819585;
				if (num != 0)
				{
				}
				num = (short)221710936;
				short num2 = num;
				num = (short)2095123032;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1284702208;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)71565312;
				if (num != 0)
				{
				}
				this.dataWideMG90WirelessVPNFriendlyName_43785.HiddenStatic = value;
			}
		}

		// Token: 0x17005123 RID: 20771
		// (get) Token: 0x0600A1FC RID: 41468 RVA: 0x00973FF8 File Offset: 0x009721F8
		// (set) Token: 0x0600A1FD RID: 41469 RVA: 0x009740AC File Offset: 0x009722AC
		internal bool DataWideMG90WirelessVPNFriendlyName_43785_HiddenDynamic
		{
			get
			{
				short num = (short)215727086;
				short num2 = num;
				num = (short)1472576494;
				switch (num2 == num)
				{
				}
				num = (short)1818230784;
				short num3 = num;
				num = (short)1492058113;
				if (num != 0)
				{
				}
				num = (short)1699807232;
				if (num != 0)
				{
				}
				return this.dataWideMG90WirelessVPNFriendlyName_43785.HiddenDynamic;
			}
			set
			{
				short num = (short)2119396549;
				short num2 = num;
				num = (short)1842572485;
				switch (num2 == num)
				{
				}
				num = (short)1198391296;
				short num3 = num;
				num = (short)217317377;
				if (num != 0)
				{
				}
				num = (short)1786970112;
				if (num != 0)
				{
				}
				this.dataWideMG90WirelessVPNFriendlyName_43785.HiddenDynamic = value;
			}
		}

		// Token: 0x17005124 RID: 20772
		// (get) Token: 0x0600A1FE RID: 41470 RVA: 0x00974164 File Offset: 0x00972364
		public bool DataWideMG90WirelessVPNFriendlyName_43785_HasDiffs
		{
			get
			{
				short num = (short)1184301057;
				if (num != 0)
				{
				}
				num = (short)205072623;
				short num2 = num;
				num = (short)1820469487;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1688010752;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1732378624;
				if (num != 0)
				{
				}
				return this.dataWideMG90WirelessVPNFriendlyName_43785._HasDiffs;
			}
		}

		// Token: 0x17005125 RID: 20773
		// (get) Token: 0x0600A1FF RID: 41471 RVA: 0x00974218 File Offset: 0x00972418
		// (set) Token: 0x0600A200 RID: 41472 RVA: 0x009742D0 File Offset: 0x009724D0
		public string DataWideMG90WirelessLTEFriendlyName_43786Value
		{
			get
			{
				short num = (short)2068534491;
				short num2 = num;
				num = (short)1213289691;
				switch (num2 == num)
				{
				}
				num = (short)243269632;
				short num3 = num;
				num = (short)367853569;
				if (num != 0)
				{
				}
				num = (short)1050279936;
				if (num != 0)
				{
				}
				return this.dataWideMG90WirelessLTEFriendlyName_43786.Value;
			}
			set
			{
				short num = (short)2143379676;
				short num2 = num;
				num = (short)1134780636;
				switch (num2 == num)
				{
				}
				num = (short)839057408;
				short num3 = num;
				num = (short)412942336;
				if (num != 0)
				{
				}
				num = (short)128843777;
				if (num != 0)
				{
				}
				this.dataWideMG90WirelessLTEFriendlyName_43786.Value = value;
			}
		}

		// Token: 0x17005126 RID: 20774
		// (get) Token: 0x0600A201 RID: 41473 RVA: 0x00974384 File Offset: 0x00972584
		public global::AcpBusinessLayer.AcpField<string> DataWideMG90WirelessLTEFriendlyName_43786
		{
			get
			{
				short num = (short)339214337;
				if (num != 0)
				{
				}
				num = (short)294836075;
				short num2 = num;
				num = (short)729601899;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1822818304;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1987641344;
				if (num != 0)
				{
				}
				return this.dataWideMG90WirelessLTEFriendlyName_43786;
			}
		}

		// Token: 0x17005127 RID: 20775
		// (get) Token: 0x0600A202 RID: 41474 RVA: 0x00974434 File Offset: 0x00972634
		// (set) Token: 0x0600A203 RID: 41475 RVA: 0x009744E8 File Offset: 0x009726E8
		public string DataWideMG90WirelessLTEFriendlyName_43786_UIValue
		{
			get
			{
				short num = (short)872611841;
				if (num != 0)
				{
				}
				num = (short)1716980429;
				short num2 = num;
				num = (short)688655053;
				switch (num2 == num)
				{
				default:
				{
					num = (short)429326336;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)820969472;
				if (num != 0)
				{
				}
				return this.dataWideMG90WirelessLTEFriendlyName_43786.Value;
			}
			set
			{
				short num = (short)1182777695;
				short num2 = num;
				num = (short)757973343;
				switch (num2 == num)
				{
				}
				num = (short)379191296;
				short num3 = num;
				num = (short)566755329;
				if (num != 0)
				{
				}
				num = (short)336920576;
				if (num != 0)
				{
				}
				this.dataWideMG90WirelessLTEFriendlyName_43786.Value = value;
			}
		}

		// Token: 0x17005128 RID: 20776
		// (get) Token: 0x0600A204 RID: 41476 RVA: 0x009745A0 File Offset: 0x009727A0
		// (set) Token: 0x0600A205 RID: 41477 RVA: 0x00974654 File Offset: 0x00972854
		public bool DataWideMG90WirelessLTEFriendlyName_43786_Applicable
		{
			get
			{
				short num = (short)502059426;
				short num2 = num;
				num = (short)319803810;
				switch (num2 == num)
				{
				}
				num = (short)1346830336;
				short num3 = num;
				num = (short)783613953;
				if (num != 0)
				{
				}
				num = (short)2064056320;
				if (num != 0)
				{
				}
				return this.dataWideMG90WirelessLTEFriendlyName_43786.Applicable;
			}
			set
			{
				short num = (short)77136377;
				short num2 = num;
				num = (short)1585054201;
				switch (num2 == num)
				{
				}
				num = (short)1007419392;
				short num3 = num;
				num = (short)1118896129;
				if (num != 0)
				{
				}
				num = (short)702676992;
				if (num != 0)
				{
				}
				this.dataWideMG90WirelessLTEFriendlyName_43786.Applicable = value;
			}
		}

		// Token: 0x17005129 RID: 20777
		// (get) Token: 0x0600A206 RID: 41478 RVA: 0x00974708 File Offset: 0x00972908
		// (set) Token: 0x0600A207 RID: 41479 RVA: 0x009747BC File Offset: 0x009729BC
		public bool DataWideMG90WirelessLTEFriendlyName_43786_Valid
		{
			get
			{
				short num = (short)834150487;
				short num2 = num;
				num = (short)773464151;
				switch (num2 == num)
				{
				}
				num = (short)1061748736;
				short num3 = num;
				num = (short)641662977;
				if (num != 0)
				{
				}
				num = (short)832503808;
				if (num != 0)
				{
				}
				return this.dataWideMG90WirelessLTEFriendlyName_43786.Valid;
			}
			set
			{
				short num = (short)2034549348;
				short num2 = num;
				num = (short)325632612;
				switch (num2 == num)
				{
				}
				num = (short)661061632;
				short num3 = num;
				num = (short)1581711360;
				if (num != 0)
				{
				}
				num = (short)1732837377;
				if (num != 0)
				{
				}
				this.dataWideMG90WirelessLTEFriendlyName_43786.Valid = value;
			}
		}

		// Token: 0x1700512A RID: 20778
		// (get) Token: 0x0600A208 RID: 41480 RVA: 0x00974870 File Offset: 0x00972A70
		// (set) Token: 0x0600A209 RID: 41481 RVA: 0x00974928 File Offset: 0x00972B28
		public bool DataWideMG90WirelessLTEFriendlyName_43786_Visible
		{
			get
			{
				short num = (short)1638439091;
				short num2 = num;
				num = (short)372938931;
				switch (num2 == num)
				{
				}
				num = (short)954400768;
				short num3 = num;
				num = (short)692322304;
				if (num != 0)
				{
				}
				num = (short)1621622785;
				if (num != 0)
				{
				}
				return this.dataWideMG90WirelessLTEFriendlyName_43786.Visible;
			}
			set
			{
				short num = (short)1352007681;
				if (num != 0)
				{
				}
				num = (short)547588298;
				short num2 = num;
				num = (short)1543145674;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1913847808;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)399835136;
				if (num != 0)
				{
				}
				this.dataWideMG90WirelessLTEFriendlyName_43786.Visible = value;
			}
		}

		// Token: 0x1700512B RID: 20779
		// (get) Token: 0x0600A20A RID: 41482 RVA: 0x009749E0 File Offset: 0x00972BE0
		// (set) Token: 0x0600A20B RID: 41483 RVA: 0x00974A94 File Offset: 0x00972C94
		public bool DataWideMG90WirelessLTEFriendlyName_43786_Editable
		{
			get
			{
				short num = (short)583678111;
				short num2 = num;
				num = (short)877934751;
				switch (num2 == num)
				{
				}
				num = (short)2125135872;
				short num3 = num;
				num = (short)1295319041;
				if (num != 0)
				{
				}
				num = (short)1177878528;
				if (num != 0)
				{
				}
				return this.dataWideMG90WirelessLTEFriendlyName_43786.Editable;
			}
			set
			{
				short num = (short)1987806607;
				short num2 = num;
				num = (short)903316879;
				switch (num2 == num)
				{
				}
				num = (short)357433344;
				short num3 = num;
				num = (short)634978305;
				if (num != 0)
				{
				}
				num = (short)887291904;
				if (num != 0)
				{
				}
				this.dataWideMG90WirelessLTEFriendlyName_43786.Editable = value;
			}
		}

		// Token: 0x1700512C RID: 20780
		// (get) Token: 0x0600A20C RID: 41484 RVA: 0x00974B4C File Offset: 0x00972D4C
		internal string DataWideMG90WirelessLTEFriendlyName_43786_UILabel
		{
			get
			{
				short num = (short)350385068;
				short num2 = num;
				num = (short)923431852;
				switch (num2 == num)
				{
				}
				num = (short)1040121856;
				short num3 = num;
				num = (short)1575682048;
				if (num != 0)
				{
				}
				num = (short)102170625;
				if (num != 0)
				{
				}
				return this.dataWideMG90WirelessLTEFriendlyName_43786.UIName;
			}
		}

		// Token: 0x1700512D RID: 20781
		// (get) Token: 0x0600A20D RID: 41485 RVA: 0x00974C00 File Offset: 0x00972E00
		// (set) Token: 0x0600A20E RID: 41486 RVA: 0x00974CB4 File Offset: 0x00972EB4
		internal bool DataWideMG90WirelessLTEFriendlyName_43786_HiddenStatic
		{
			get
			{
				short num = (short)1306904316;
				short num2 = num;
				num = (short)332711676;
				switch (num2 == num)
				{
				}
				num = (short)675086336;
				short num3 = num;
				num = (short)1826684929;
				if (num != 0)
				{
				}
				num = (short)108134400;
				if (num != 0)
				{
				}
				return this.dataWideMG90WirelessLTEFriendlyName_43786.HiddenStatic;
			}
			set
			{
				short num = (short)1474344718;
				short num2 = num;
				num = (short)446674702;
				switch (num2 == num)
				{
				}
				num = (short)1675624448;
				short num3 = num;
				num = (short)848101377;
				if (num != 0)
				{
				}
				num = (short)273940480;
				if (num != 0)
				{
				}
				this.dataWideMG90WirelessLTEFriendlyName_43786.HiddenStatic = value;
			}
		}

		// Token: 0x1700512E RID: 20782
		// (get) Token: 0x0600A20F RID: 41487 RVA: 0x00974D68 File Offset: 0x00972F68
		// (set) Token: 0x0600A210 RID: 41488 RVA: 0x00974E1C File Offset: 0x0097301C
		internal bool DataWideMG90WirelessLTEFriendlyName_43786_HiddenDynamic
		{
			get
			{
				short num = (short)221910555;
				short num2 = num;
				num = (short)303765019;
				switch (num2 == num)
				{
				}
				num = (short)288489472;
				short num3 = num;
				num = (short)1039925249;
				if (num != 0)
				{
				}
				num = (short)1153368064;
				if (num != 0)
				{
				}
				return this.dataWideMG90WirelessLTEFriendlyName_43786.HiddenDynamic;
			}
			set
			{
				short num = (short)1228814405;
				short num2 = num;
				num = (short)1439905861;
				switch (num2 == num)
				{
				}
				num = (short)1779105792;
				short num3 = num;
				num = (short)458948609;
				if (num != 0)
				{
				}
				num = (short)870776832;
				if (num != 0)
				{
				}
				this.dataWideMG90WirelessLTEFriendlyName_43786.HiddenDynamic = value;
			}
		}

		// Token: 0x1700512F RID: 20783
		// (get) Token: 0x0600A211 RID: 41489 RVA: 0x00974ED0 File Offset: 0x009730D0
		public bool DataWideMG90WirelessLTEFriendlyName_43786_HasDiffs
		{
			get
			{
				short num = (short)512929;
				short num2 = num;
				num = (short)786617249;
				switch (num2 == num)
				{
				}
				num = (short)1182072832;
				short num3 = num;
				num = (short)1891368961;
				if (num != 0)
				{
				}
				num = (short)907411456;
				if (num != 0)
				{
				}
				return this.dataWideMG90WirelessLTEFriendlyName_43786._HasDiffs;
			}
		}

		// Token: 0x17005130 RID: 20784
		// (get) Token: 0x0600A212 RID: 41490 RVA: 0x00974F84 File Offset: 0x00973184
		// (set) Token: 0x0600A213 RID: 41491 RVA: 0x0097503C File Offset: 0x0097323C
		public string DataWideMG90WirelessSatelliteFriendlyName_43787Value
		{
			get
			{
				short num = (short)412090369;
				if (num != 0)
				{
				}
				num = (short)871331524;
				short num2 = num;
				num = (short)1716090564;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1585250304;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)862126080;
				if (num != 0)
				{
				}
				return this.dataWideMG90WirelessSatelliteFriendlyName_43787.Value;
			}
			set
			{
				short num = (short)1288730035;
				short num2 = num;
				num = (short)674657715;
				switch (num2 == num)
				{
				}
				num = (short)1477967872;
				short num3 = num;
				num = (short)456982529;
				if (num != 0)
				{
				}
				num = (short)1558315008;
				if (num != 0)
				{
				}
				this.dataWideMG90WirelessSatelliteFriendlyName_43787.Value = value;
			}
		}

		// Token: 0x17005131 RID: 20785
		// (get) Token: 0x0600A214 RID: 41492 RVA: 0x009750F0 File Offset: 0x009732F0
		public global::AcpBusinessLayer.AcpField<string> DataWideMG90WirelessSatelliteFriendlyName_43787
		{
			get
			{
				short num = (short)659386799;
				short num2 = num;
				num = (short)93352367;
				switch (num2 == num)
				{
				}
				num = (short)2038497280;
				short num3 = num;
				num = (short)1247870977;
				if (num != 0)
				{
				}
				num = (short)211091456;
				if (num != 0)
				{
				}
				return this.dataWideMG90WirelessSatelliteFriendlyName_43787;
			}
		}

		// Token: 0x17005132 RID: 20786
		// (get) Token: 0x0600A215 RID: 41493 RVA: 0x009751A4 File Offset: 0x009733A4
		// (set) Token: 0x0600A216 RID: 41494 RVA: 0x00975258 File Offset: 0x00973458
		public string DataWideMG90WirelessSatelliteFriendlyName_43787_UIValue
		{
			get
			{
				short num = (short)1206380199;
				short num2 = num;
				num = (short)467003047;
				switch (num2 == num)
				{
				}
				num = (short)1206845440;
				short num3 = num;
				num = (short)926154752;
				if (num != 0)
				{
				}
				num = (short)1384120321;
				if (num != 0)
				{
				}
				return this.dataWideMG90WirelessSatelliteFriendlyName_43787.Value;
			}
			set
			{
				short num = (short)630072842;
				short num2 = num;
				num = (short)1409558026;
				switch (num2 == num)
				{
				}
				num = (short)728760320;
				short num3 = num;
				num = (short)913440768;
				if (num != 0)
				{
				}
				num = (short)1165426689;
				if (num != 0)
				{
				}
				this.dataWideMG90WirelessSatelliteFriendlyName_43787.Value = value;
			}
		}

		// Token: 0x17005133 RID: 20787
		// (get) Token: 0x0600A217 RID: 41495 RVA: 0x0097530C File Offset: 0x0097350C
		// (set) Token: 0x0600A218 RID: 41496 RVA: 0x009753C4 File Offset: 0x009735C4
		public bool DataWideMG90WirelessSatelliteFriendlyName_43787_Applicable
		{
			get
			{
				short num = (short)1648927099;
				short num2 = num;
				num = (short)989766011;
				switch (num2 == num)
				{
				}
				num = (short)1155530752;
				short num3 = num;
				num = (short)2135293952;
				if (num != 0)
				{
				}
				num = (short)1621032961;
				if (num != 0)
				{
				}
				return this.dataWideMG90WirelessSatelliteFriendlyName_43787.Applicable;
			}
			set
			{
				short num = (short)1339424769;
				if (num != 0)
				{
				}
				num = (short)1373379408;
				short num2 = num;
				num = (short)1232345936;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1876361216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1864368128;
				if (num != 0)
				{
				}
				this.dataWideMG90WirelessSatelliteFriendlyName_43787.Applicable = value;
			}
		}

		// Token: 0x17005134 RID: 20788
		// (get) Token: 0x0600A219 RID: 41497 RVA: 0x0097547C File Offset: 0x0097367C
		// (set) Token: 0x0600A21A RID: 41498 RVA: 0x00975530 File Offset: 0x00973730
		public bool DataWideMG90WirelessSatelliteFriendlyName_43787_Valid
		{
			get
			{
				short num = (short)7766655;
				short num2 = num;
				num = (short)837386879;
				switch (num2 == num)
				{
				}
				num = (short)981139456;
				short num3 = num;
				num = (short)1727594496;
				if (num != 0)
				{
				}
				num = (short)1929707521;
				if (num != 0)
				{
				}
				return this.dataWideMG90WirelessSatelliteFriendlyName_43787.Valid;
			}
			set
			{
				short num = (short)2132501333;
				short num2 = num;
				num = (short)1677484885;
				switch (num2 == num)
				{
				}
				num = (short)2072510464;
				short num3 = num;
				num = (short)1596063745;
				if (num != 0)
				{
				}
				num = (short)1618280448;
				if (num != 0)
				{
				}
				this.dataWideMG90WirelessSatelliteFriendlyName_43787.Valid = value;
			}
		}

		// Token: 0x17005135 RID: 20789
		// (get) Token: 0x0600A21B RID: 41499 RVA: 0x009755E4 File Offset: 0x009737E4
		// (set) Token: 0x0600A21C RID: 41500 RVA: 0x00975698 File Offset: 0x00973898
		public bool DataWideMG90WirelessSatelliteFriendlyName_43787_Visible
		{
			get
			{
				short num = (short)333645512;
				short num2 = num;
				num = (short)98240200;
				switch (num2 == num)
				{
				}
				num = (short)1607270400;
				short num3 = num;
				num = (short)1700790272;
				if (num != 0)
				{
				}
				num = (short)1012727809;
				if (num != 0)
				{
				}
				return this.dataWideMG90WirelessSatelliteFriendlyName_43787.Visible;
			}
			set
			{
				short num = (short)1571086653;
				short num2 = num;
				num = (short)1508499773;
				switch (num2 == num)
				{
				}
				num = (short)628097024;
				short num3 = num;
				num = (short)468254721;
				if (num != 0)
				{
				}
				num = (short)1924661248;
				if (num != 0)
				{
				}
				this.dataWideMG90WirelessSatelliteFriendlyName_43787.Visible = value;
			}
		}

		// Token: 0x17005136 RID: 20790
		// (get) Token: 0x0600A21D RID: 41501 RVA: 0x00975750 File Offset: 0x00973950
		// (set) Token: 0x0600A21E RID: 41502 RVA: 0x00975804 File Offset: 0x00973A04
		public bool DataWideMG90WirelessSatelliteFriendlyName_43787_Editable
		{
			get
			{
				short num = (short)423273721;
				short num2 = num;
				num = (short)1901634809;
				switch (num2 == num)
				{
				}
				num = (short)847642624;
				short num3 = num;
				num = (short)178716673;
				if (num != 0)
				{
				}
				num = (short)1407647744;
				if (num != 0)
				{
				}
				return this.dataWideMG90WirelessSatelliteFriendlyName_43787.Editable;
			}
			set
			{
				short num = (short)1390954411;
				short num2 = num;
				num = (short)1689077675;
				switch (num2 == num)
				{
				}
				num = (short)1869938688;
				short num3 = num;
				num = (short)1522139137;
				if (num != 0)
				{
				}
				num = (short)1247870976;
				if (num != 0)
				{
				}
				this.dataWideMG90WirelessSatelliteFriendlyName_43787.Editable = value;
			}
		}

		// Token: 0x17005137 RID: 20791
		// (get) Token: 0x0600A21F RID: 41503 RVA: 0x009758BC File Offset: 0x00973ABC
		internal string DataWideMG90WirelessSatelliteFriendlyName_43787_UILabel
		{
			get
			{
				short num = (short)1778039670;
				short num2 = num;
				num = (short)581745526;
				switch (num2 == num)
				{
				}
				num = (short)1909653504;
				short num3 = num;
				num = (short)1013383168;
				if (num != 0)
				{
				}
				num = (short)281673729;
				if (num != 0)
				{
				}
				return this.dataWideMG90WirelessSatelliteFriendlyName_43787.UIName;
			}
		}

		// Token: 0x17005138 RID: 20792
		// (get) Token: 0x0600A220 RID: 41504 RVA: 0x00975970 File Offset: 0x00973B70
		// (set) Token: 0x0600A221 RID: 41505 RVA: 0x00975A28 File Offset: 0x00973C28
		internal bool DataWideMG90WirelessSatelliteFriendlyName_43787_HiddenStatic
		{
			get
			{
				short num = (short)132841473;
				if (num != 0)
				{
				}
				num = (short)506871407;
				short num2 = num;
				num = (short)35405423;
				switch (num2 == num)
				{
				default:
				{
					num = (short)706805760;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1629028352;
				if (num != 0)
				{
				}
				return this.dataWideMG90WirelessSatelliteFriendlyName_43787.HiddenStatic;
			}
			set
			{
				short num = (short)2015012280;
				short num2 = num;
				num = (short)655402424;
				switch (num2 == num)
				{
				}
				num = (short)114622464;
				short num3 = num;
				num = (short)1795686401;
				if (num != 0)
				{
				}
				num = (short)1314652160;
				if (num != 0)
				{
				}
				this.dataWideMG90WirelessSatelliteFriendlyName_43787.HiddenStatic = value;
			}
		}

		// Token: 0x17005139 RID: 20793
		// (get) Token: 0x0600A222 RID: 41506 RVA: 0x00975ADC File Offset: 0x00973CDC
		// (set) Token: 0x0600A223 RID: 41507 RVA: 0x00975B90 File Offset: 0x00973D90
		internal bool DataWideMG90WirelessSatelliteFriendlyName_43787_HiddenDynamic
		{
			get
			{
				short num = (short)1072083290;
				short num2 = num;
				num = (short)544256346;
				switch (num2 == num)
				{
				}
				num = (short)1089929216;
				short num3 = num;
				num = (short)1973092353;
				if (num != 0)
				{
				}
				num = (short)1924792320;
				if (num != 0)
				{
				}
				return this.dataWideMG90WirelessSatelliteFriendlyName_43787.HiddenDynamic;
			}
			set
			{
				short num = (short)1701393147;
				short num2 = num;
				num = (short)1479422715;
				switch (num2 == num)
				{
				}
				num = (short)1994784768;
				short num3 = num;
				num = (short)590151680;
				if (num != 0)
				{
				}
				num = (short)1864040449;
				if (num != 0)
				{
				}
				this.dataWideMG90WirelessSatelliteFriendlyName_43787.HiddenDynamic = value;
			}
		}

		// Token: 0x1700513A RID: 20794
		// (get) Token: 0x0600A224 RID: 41508 RVA: 0x00975C48 File Offset: 0x00973E48
		public bool DataWideMG90WirelessSatelliteFriendlyName_43787_HasDiffs
		{
			get
			{
				short num = (short)2050931584;
				short num2 = num;
				num = (short)913161088;
				switch (num2 == num)
				{
				}
				num = (short)1955921920;
				short num3 = num;
				num = (short)455081985;
				if (num != 0)
				{
				}
				num = (short)236060672;
				if (num != 0)
				{
				}
				return this.dataWideMG90WirelessSatelliteFriendlyName_43787._HasDiffs;
			}
		}

		// Token: 0x1700513B RID: 20795
		// (get) Token: 0x0600A225 RID: 41509 RVA: 0x00975CFC File Offset: 0x00973EFC
		// (set) Token: 0x0600A226 RID: 41510 RVA: 0x00975DB0 File Offset: 0x00973FB0
		public bool DataWideMG90WirelessSatelliteEnable_43788Value
		{
			get
			{
				short num = (short)65935339;
				short num2 = num;
				num = (short)1834424299;
				switch (num2 == num)
				{
				}
				num = (short)660406272;
				short num3 = num;
				num = (short)597688321;
				if (num != 0)
				{
				}
				num = (short)2083913728;
				if (num != 0)
				{
				}
				return this.dataWideMG90WirelessSatelliteEnable_43788.Value;
			}
			set
			{
				short num = (short)1227433427;
				short num2 = num;
				num = (short)945825235;
				switch (num2 == num)
				{
				}
				num = (short)272039936;
				short num3 = num;
				num = (short)1094057984;
				if (num != 0)
				{
				}
				num = (short)1246035969;
				if (num != 0)
				{
				}
				this.dataWideMG90WirelessSatelliteEnable_43788.Value = value;
			}
		}

		// Token: 0x1700513C RID: 20796
		// (get) Token: 0x0600A227 RID: 41511 RVA: 0x00975E64 File Offset: 0x00974064
		public global::AcpBusinessLayer.AcpField<bool> DataWideMG90WirelessSatelliteEnable_43788
		{
			get
			{
				short num = (short)1775546163;
				short num2 = num;
				num = (short)1880207155;
				switch (num2 == num)
				{
				}
				num = (short)423886848;
				short num3 = num;
				num = (short)1081016321;
				if (num != 0)
				{
				}
				num = (short)43253760;
				if (num != 0)
				{
				}
				return this.dataWideMG90WirelessSatelliteEnable_43788;
			}
		}

		// Token: 0x1700513D RID: 20797
		// (get) Token: 0x0600A228 RID: 41512 RVA: 0x00975F14 File Offset: 0x00974114
		// (set) Token: 0x0600A229 RID: 41513 RVA: 0x00975FC8 File Offset: 0x009741C8
		public bool DataWideMG90WirelessSatelliteEnable_43788_UIValue
		{
			get
			{
				short num = (short)109628560;
				short num2 = num;
				num = (short)207473808;
				switch (num2 == num)
				{
				}
				num = (short)1489895424;
				short num3 = num;
				num = (short)114294784;
				if (num != 0)
				{
				}
				num = (short)1925120001;
				if (num != 0)
				{
				}
				return this.dataWideMG90WirelessSatelliteEnable_43788.Value;
			}
			set
			{
				short num = (short)1515782145;
				if (num != 0)
				{
				}
				num = (short)399854442;
				short num2 = num;
				num = (short)1566460778;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1892220928;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)379191296;
				if (num != 0)
				{
				}
				this.dataWideMG90WirelessSatelliteEnable_43788.Value = value;
			}
		}

		// Token: 0x1700513E RID: 20798
		// (get) Token: 0x0600A22A RID: 41514 RVA: 0x0097607C File Offset: 0x0097427C
		// (set) Token: 0x0600A22B RID: 41515 RVA: 0x00976130 File Offset: 0x00974330
		public bool DataWideMG90WirelessSatelliteEnable_43788_Applicable
		{
			get
			{
				short num = (short)1856827469;
				short num2 = num;
				num = (short)1230237773;
				switch (num2 == num)
				{
				}
				num = (short)965279744;
				short num3 = num;
				num = (short)435814401;
				if (num != 0)
				{
				}
				num = (short)1327628288;
				if (num != 0)
				{
				}
				return this.dataWideMG90WirelessSatelliteEnable_43788.Applicable;
			}
			set
			{
				short num = (short)1459471471;
				short num2 = num;
				num = (short)1481163887;
				switch (num2 == num)
				{
				}
				num = (short)955383808;
				short num3 = num;
				num = (short)1131479041;
				if (num != 0)
				{
				}
				num = (short)1961820160;
				if (num != 0)
				{
				}
				this.dataWideMG90WirelessSatelliteEnable_43788.Applicable = value;
			}
		}

		// Token: 0x1700513F RID: 20799
		// (get) Token: 0x0600A22C RID: 41516 RVA: 0x009761E4 File Offset: 0x009743E4
		// (set) Token: 0x0600A22D RID: 41517 RVA: 0x0097629C File Offset: 0x0097449C
		public bool DataWideMG90WirelessSatelliteEnable_43788_Valid
		{
			get
			{
				short num = (short)1858746227;
				short num2 = num;
				num = (short)120338291;
				switch (num2 == num)
				{
				}
				num = (short)1816526848;
				short num3 = num;
				num = (short)227344385;
				if (num != 0)
				{
				}
				num = (short)2079653888;
				if (num != 0)
				{
				}
				return this.dataWideMG90WirelessSatelliteEnable_43788.Valid;
			}
			set
			{
				short num = (short)530879991;
				short num2 = num;
				num = (short)667784695;
				switch (num2 == num)
				{
				}
				num = (short)37552128;
				short num3 = num;
				num = (short)413466625;
				if (num != 0)
				{
				}
				num = (short)1920598016;
				if (num != 0)
				{
				}
				this.dataWideMG90WirelessSatelliteEnable_43788.Valid = value;
			}
		}

		// Token: 0x17005140 RID: 20800
		// (get) Token: 0x0600A22E RID: 41518 RVA: 0x00976354 File Offset: 0x00974554
		// (set) Token: 0x0600A22F RID: 41519 RVA: 0x00976404 File Offset: 0x00974604
		public bool DataWideMG90WirelessSatelliteEnable_43788_Visible
		{
			get
			{
				short num = (short)835112544;
				short num2 = num;
				num = (short)1741540960;
				switch (num2 == num)
				{
				}
				num = (short)1345257472;
				short num3 = num;
				num = (short)1817378816;
				if (num != 0)
				{
				}
				num = (short)1340866561;
				if (num != 0)
				{
				}
				return this.dataWideMG90WirelessSatelliteEnable_43788.Visible;
			}
			set
			{
				short num = (short)2010710017;
				if (num != 0)
				{
				}
				num = (short)1223168509;
				short num2 = num;
				num = (short)874910205;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1203372032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1504575488;
				if (num != 0)
				{
				}
				this.dataWideMG90WirelessSatelliteEnable_43788.Visible = value;
			}
		}

		// Token: 0x17005141 RID: 20801
		// (get) Token: 0x0600A230 RID: 41520 RVA: 0x009764BC File Offset: 0x009746BC
		// (set) Token: 0x0600A231 RID: 41521 RVA: 0x00976570 File Offset: 0x00974770
		public bool DataWideMG90WirelessSatelliteEnable_43788_Editable
		{
			get
			{
				short num = (short)1647399737;
				short num2 = num;
				num = (short)1410945849;
				switch (num2 == num)
				{
				}
				num = (short)265158656;
				short num3 = num;
				num = (short)1562443777;
				if (num != 0)
				{
				}
				num = (short)1386086400;
				if (num != 0)
				{
				}
				return this.dataWideMG90WirelessSatelliteEnable_43788.Editable;
			}
			set
			{
				short num = (short)1676935169;
				if (num != 0)
				{
				}
				num = (short)525710880;
				short num2 = num;
				num = (short)1760146976;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1205796864;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1350172672;
				if (num != 0)
				{
				}
				this.dataWideMG90WirelessSatelliteEnable_43788.Editable = value;
			}
		}

		// Token: 0x17005142 RID: 20802
		// (get) Token: 0x0600A232 RID: 41522 RVA: 0x00976628 File Offset: 0x00974828
		internal string DataWideMG90WirelessSatelliteEnable_43788_UILabel
		{
			get
			{
				short num = (short)1439486483;
				short num2 = num;
				num = (short)1484575251;
				switch (num2 == num)
				{
				}
				num = (short)588120064;
				short num3 = num;
				num = (short)36765697;
				if (num != 0)
				{
				}
				num = (short)1905328128;
				if (num != 0)
				{
				}
				return this.dataWideMG90WirelessSatelliteEnable_43788.UIName;
			}
		}

		// Token: 0x17005143 RID: 20803
		// (get) Token: 0x0600A233 RID: 41523 RVA: 0x009766DC File Offset: 0x009748DC
		// (set) Token: 0x0600A234 RID: 41524 RVA: 0x0097678C File Offset: 0x0097498C
		internal bool DataWideMG90WirelessSatelliteEnable_43788_HiddenStatic
		{
			get
			{
				short num = (short)1772087373;
				short num2 = num;
				num = (short)1248913485;
				switch (num2 == num)
				{
				}
				num = (short)1524498432;
				short num3 = num;
				num = (short)1407516673;
				if (num != 0)
				{
				}
				num = (short)1944256512;
				if (num != 0)
				{
				}
				return this.dataWideMG90WirelessSatelliteEnable_43788.HiddenStatic;
			}
			set
			{
				short num = (short)1154875393;
				if (num != 0)
				{
				}
				num = (short)1577973249;
				short num2 = num;
				num = (short)1494873601;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1291255808;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1423376384;
				if (num != 0)
				{
				}
				this.dataWideMG90WirelessSatelliteEnable_43788.HiddenStatic = value;
			}
		}

		// Token: 0x17005144 RID: 20804
		// (get) Token: 0x0600A235 RID: 41525 RVA: 0x00976840 File Offset: 0x00974A40
		// (set) Token: 0x0600A236 RID: 41526 RVA: 0x009768F4 File Offset: 0x00974AF4
		internal bool DataWideMG90WirelessSatelliteEnable_43788_HiddenDynamic
		{
			get
			{
				short num = (short)1851110204;
				short num2 = num;
				num = (short)2131342140;
				switch (num2 == num)
				{
				}
				num = (short)676462592;
				short num3 = num;
				num = (short)1373110273;
				if (num != 0)
				{
				}
				num = (short)825819136;
				if (num != 0)
				{
				}
				return this.dataWideMG90WirelessSatelliteEnable_43788.HiddenDynamic;
			}
			set
			{
				short num = (short)1996546859;
				short num2 = num;
				num = (short)2117198635;
				switch (num2 == num)
				{
				}
				num = (short)1205600256;
				short num3 = num;
				num = (short)717422593;
				if (num != 0)
				{
				}
				num = (short)2114322432;
				if (num != 0)
				{
				}
				this.dataWideMG90WirelessSatelliteEnable_43788.HiddenDynamic = value;
			}
		}

		// Token: 0x17005145 RID: 20805
		// (get) Token: 0x0600A237 RID: 41527 RVA: 0x009769AC File Offset: 0x00974BAC
		public bool DataWideMG90WirelessSatelliteEnable_43788_HasDiffs
		{
			get
			{
				short num = (short)1817116673;
				if (num != 0)
				{
				}
				num = (short)541817397;
				short num2 = num;
				num = (short)179862069;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1280180224;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)765526016;
				if (num != 0)
				{
				}
				return this.dataWideMG90WirelessSatelliteEnable_43788._HasDiffs;
			}
		}

		// Token: 0x17005146 RID: 20806
		// (get) Token: 0x0600A238 RID: 41528 RVA: 0x00976A64 File Offset: 0x00974C64
		// (set) Token: 0x0600A239 RID: 41529 RVA: 0x00976B14 File Offset: 0x00974D14
		public bool DataWideExternalDataModemHiddenNetwork_44814Value
		{
			get
			{
				short num = (short)1399173473;
				short num2 = num;
				num = (short)1680912737;
				switch (num2 == num)
				{
				}
				num = (short)1466302464;
				short num3 = num;
				num = (short)1138032641;
				if (num != 0)
				{
				}
				num = (short)806879232;
				if (num != 0)
				{
				}
				return this.DataWideExternalDataModemHiddenNetwork_44814.Value;
			}
			set
			{
				short num = (short)403925330;
				short num2 = num;
				num = (short)943417682;
				switch (num2 == num)
				{
				}
				num = (short)1282342912;
				short num3 = num;
				num = (short)554237953;
				if (num != 0)
				{
				}
				num = (short)1248526336;
				if (num != 0)
				{
				}
				this.DataWideExternalDataModemHiddenNetwork_44814.Value = value;
			}
		}

		// Token: 0x17005147 RID: 20807
		// (get) Token: 0x0600A23A RID: 41530 RVA: 0x00976BC8 File Offset: 0x00974DC8
		public global::AcpBusinessLayer.AcpField<bool> DataWideExternalDataModemHiddenNetwork_44814
		{
			get
			{
				short num = (short)581477903;
				short num2 = num;
				num = (short)787850767;
				switch (num2 == num)
				{
				}
				num = (short)575864832;
				short num3 = num;
				num = (short)1404174337;
				if (num != 0)
				{
				}
				num = (short)1288044544;
				if (num != 0)
				{
				}
				return this.dataWideExternalDataModemHiddenNetwork_44814;
			}
		}

		// Token: 0x17005148 RID: 20808
		// (get) Token: 0x0600A23B RID: 41531 RVA: 0x00976C78 File Offset: 0x00974E78
		// (set) Token: 0x0600A23C RID: 41532 RVA: 0x00976D30 File Offset: 0x00974F30
		public bool DataWideExternalDataModemHiddenNetwork_44814_UIValue
		{
			get
			{
				short num = (short)768429859;
				short num2 = num;
				num = (short)510414627;
				switch (num2 == num)
				{
				}
				num = (short)371916800;
				short num3 = num;
				num = (short)1596129280;
				if (num != 0)
				{
				}
				num = (short)433389569;
				if (num != 0)
				{
				}
				return this.DataWideExternalDataModemHiddenNetwork_44814.Value;
			}
			set
			{
				short num = (short)330931876;
				short num2 = num;
				num = (short)1104060068;
				switch (num2 == num)
				{
				}
				num = (short)1918697472;
				short num3 = num;
				num = (short)1182924800;
				if (num != 0)
				{
				}
				num = (short)38928385;
				if (num != 0)
				{
				}
				this.DataWideExternalDataModemHiddenNetwork_44814.Value = value;
			}
		}

		// Token: 0x17005149 RID: 20809
		// (get) Token: 0x0600A23D RID: 41533 RVA: 0x00976DE8 File Offset: 0x00974FE8
		// (set) Token: 0x0600A23E RID: 41534 RVA: 0x00976E9C File Offset: 0x0097509C
		public bool DataWideExternalDataModemHiddenNetwork_44814_Applicable
		{
			get
			{
				short num = (short)664738190;
				short num2 = num;
				num = (short)293149070;
				switch (num2 == num)
				{
				}
				num = (short)157614080;
				short num3 = num;
				num = (short)1105264640;
				if (num != 0)
				{
				}
				num = (short)1153826817;
				if (num != 0)
				{
				}
				return this.DataWideExternalDataModemHiddenNetwork_44814.Applicable;
			}
			set
			{
				short num = (short)504029479;
				short num2 = num;
				num = (short)1409212711;
				switch (num2 == num)
				{
				}
				num = (short)1253441536;
				short num3 = num;
				num = (short)1161691137;
				if (num != 0)
				{
				}
				num = (short)1428226048;
				if (num != 0)
				{
				}
				this.DataWideExternalDataModemHiddenNetwork_44814.Applicable = value;
			}
		}

		// Token: 0x1700514A RID: 20810
		// (get) Token: 0x0600A23F RID: 41535 RVA: 0x00976F50 File Offset: 0x00975150
		// (set) Token: 0x0600A240 RID: 41536 RVA: 0x00977004 File Offset: 0x00975204
		public bool DataWideExternalDataModemHiddenNetwork_44814_Valid
		{
			get
			{
				short num = (short)1429402553;
				short num2 = num;
				num = (short)373355449;
				switch (num2 == num)
				{
				}
				num = (short)1933312000;
				short num3 = num;
				num = (short)1098645504;
				if (num != 0)
				{
				}
				num = (short)2074869761;
				if (num != 0)
				{
				}
				return this.DataWideExternalDataModemHiddenNetwork_44814.Valid;
			}
			set
			{
				short num = (short)1054556446;
				short num2 = num;
				num = (short)750797086;
				switch (num2 == num)
				{
				}
				num = (short)225378304;
				short num3 = num;
				num = (short)1125580800;
				if (num != 0)
				{
				}
				num = (short)1712848897;
				if (num != 0)
				{
				}
				this.DataWideExternalDataModemHiddenNetwork_44814.Valid = value;
			}
		}

		// Token: 0x1700514B RID: 20811
		// (get) Token: 0x0600A241 RID: 41537 RVA: 0x009770BC File Offset: 0x009752BC
		// (set) Token: 0x0600A242 RID: 41538 RVA: 0x00977170 File Offset: 0x00975370
		public bool DataWideExternalDataModemHiddenNetwork_44814_Visible
		{
			get
			{
				short num = (short)901545257;
				short num2 = num;
				num = (short)850689321;
				switch (num2 == num)
				{
				}
				num = (short)1917124608;
				short num3 = num;
				num = (short)1831272449;
				if (num != 0)
				{
				}
				num = (short)753270784;
				if (num != 0)
				{
				}
				return this.DataWideExternalDataModemHiddenNetwork_44814.Visible;
			}
			set
			{
				short num = (short)1180124959;
				short num2 = num;
				num = (short)1339377439;
				switch (num2 == num)
				{
				}
				num = (short)904724480;
				short num3 = num;
				num = (short)335478785;
				if (num != 0)
				{
				}
				num = (short)796721152;
				if (num != 0)
				{
				}
				this.DataWideExternalDataModemHiddenNetwork_44814.Visible = value;
			}
		}

		// Token: 0x1700514C RID: 20812
		// (get) Token: 0x0600A243 RID: 41539 RVA: 0x00977228 File Offset: 0x00975428
		// (set) Token: 0x0600A244 RID: 41540 RVA: 0x009772E0 File Offset: 0x009754E0
		public bool DataWideExternalDataModemHiddenNetwork_44814_Editable
		{
			get
			{
				short num = (short)705744372;
				short num2 = num;
				num = (short)303418868;
				switch (num2 == num)
				{
				}
				num = (short)493420544;
				short num3 = num;
				num = (short)1707540481;
				if (num != 0)
				{
				}
				num = (short)527630336;
				if (num != 0)
				{
				}
				return this.DataWideExternalDataModemHiddenNetwork_44814.Editable;
			}
			set
			{
				short num = (short)584521121;
				short num2 = num;
				num = (short)1032263073;
				switch (num2 == num)
				{
				}
				num = (short)1239416832;
				short num3 = num;
				num = (short)305004544;
				if (num != 0)
				{
				}
				num = (short)589955073;
				if (num != 0)
				{
				}
				this.DataWideExternalDataModemHiddenNetwork_44814.Editable = value;
			}
		}

		// Token: 0x1700514D RID: 20813
		// (get) Token: 0x0600A245 RID: 41541 RVA: 0x00977398 File Offset: 0x00975598
		internal string DataWideExternalDataModemHiddenNetwork_44814_UILabel
		{
			get
			{
				short num = (short)1870496786;
				short num2 = num;
				num = (short)938902546;
				switch (num2 == num)
				{
				}
				num = (short)861536256;
				short num3 = num;
				num = (short)1180106753;
				if (num != 0)
				{
				}
				num = (short)394592256;
				if (num != 0)
				{
				}
				return this.DataWideExternalDataModemHiddenNetwork_44814.UIName;
			}
		}

		// Token: 0x1700514E RID: 20814
		// (get) Token: 0x0600A246 RID: 41542 RVA: 0x00977448 File Offset: 0x00975648
		// (set) Token: 0x0600A247 RID: 41543 RVA: 0x00977500 File Offset: 0x00975700
		internal bool DataWideExternalDataModemHiddenNetwork_44814_HiddenStatic
		{
			get
			{
				short num = (short)257972891;
				short num2 = num;
				num = (short)1003510427;
				switch (num2 == num)
				{
				}
				num = (short)218169345;
				if (num != 0)
				{
				}
				num = (short)982253568;
				short num3 = num;
				num = (short)1209335808;
				if (num != 0)
				{
				}
				return this.DataWideExternalDataModemHiddenNetwork_44814.HiddenStatic;
			}
			set
			{
				short num = (short)1004216409;
				short num2 = num;
				num = (short)1804279897;
				switch (num2 == num)
				{
				}
				num = (short)1850867713;
				if (num != 0)
				{
				}
				num = (short)943587328;
				short num3 = num;
				num = (short)1008271360;
				if (num != 0)
				{
				}
				this.DataWideExternalDataModemHiddenNetwork_44814.HiddenStatic = value;
			}
		}

		// Token: 0x1700514F RID: 20815
		// (get) Token: 0x0600A248 RID: 41544 RVA: 0x009775B4 File Offset: 0x009757B4
		// (set) Token: 0x0600A249 RID: 41545 RVA: 0x00977668 File Offset: 0x00975868
		internal bool DataWideExternalDataModemHiddenNetwork_44814_HiddenDynamic
		{
			get
			{
				short num = (short)1833020877;
				short num2 = num;
				num = (short)1545973197;
				switch (num2 == num)
				{
				}
				num = (short)296026113;
				if (num != 0)
				{
				}
				num = (short)1473773568;
				short num3 = num;
				num = (short)514457600;
				if (num != 0)
				{
				}
				return this.DataWideExternalDataModemHiddenNetwork_44814.HiddenDynamic;
			}
			set
			{
				short num = (short)2093467537;
				short num2 = num;
				num = (short)5490577;
				switch (num2 == num)
				{
				}
				num = (short)550174721;
				if (num != 0)
				{
				}
				num = (short)1302659072;
				short num3 = num;
				num = (short)1224212480;
				if (num != 0)
				{
				}
				this.DataWideExternalDataModemHiddenNetwork_44814.HiddenDynamic = value;
			}
		}

		// Token: 0x17005150 RID: 20816
		// (get) Token: 0x0600A24A RID: 41546 RVA: 0x00977720 File Offset: 0x00975920
		public bool DataWideExternalDataModemHiddenNetwork_44814_HasDiffs
		{
			get
			{
				short num = (short)1594796322;
				short num2 = num;
				num = (short)1405004066;
				switch (num2 == num)
				{
				}
				num = (short)1581580288;
				if (num != 0)
				{
				}
				num = (short)2087190528;
				short num3 = num;
				num = (short)1394737153;
				if (num != 0)
				{
				}
				return this.DataWideExternalDataModemHiddenNetwork_44814._HasDiffs;
			}
		}

		// Token: 0x0600A24B RID: 41547 RVA: 0x009777D4 File Offset: 0x009759D4
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
							num2 = (short)183173121;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					case 1:
					{
						num2 = (short)2051679813;
						short num3 = num2;
						num2 = (short)1184572997;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_26;
						default:
							num2 = (short)386465792;
							if (num2 != 0)
							{
							}
							result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
							num2 = (short)422772738;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 2:
						goto IL_F9;
					case 3:
						if (base.ParentRecset != null)
						{
							num2 = (short)766115841;
							if (num2 != 0)
							{
							}
							num2 = (short)157745156;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					case 4:
						num2 = (short)1603928064;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_24;
				}
				IL_F9:
				num2 = (short)717488128;
				short num4 = num2;
				return result;
			}
			}
			IL_24:
			result = null;
			IL_26:
			num2 = (short)746782723;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04004E06 RID: 19974
		private global::AcpBusinessLayer.AcpSimpleRangeField dataWideExternalDataModemNetworkPriority_43358;

		// Token: 0x04004E07 RID: 19975
		private global::AcpBusinessLayer.AcpField<string> dataWideExternalDataModemNetworkSsid_43358;

		// Token: 0x04004E08 RID: 19976
		private global::AcpBusinessLayer.AcpListField dataWideExternalDataModemSecurityType_43360;

		// Token: 0x04004E09 RID: 19977
		private global::AcpBusinessLayer.AcpFieldX<string, string> dataWideEncryptedNetworkPassword_43361;

		// Token: 0x04004E0A RID: 19978
		private global::AcpBusinessLayer.AcpListField dataWideExternalDataModemType_43362;

		// Token: 0x04004E0B RID: 19979
		private global::AcpBusinessLayer.AcpFieldX<string, string> dataWideEncryptedModemPassword_43361;

		// Token: 0x04004E0C RID: 19980
		private global::AcpBusinessLayer.AcpSimpleRangeField dataWideExternalDataModemPort;

		// Token: 0x04004E0D RID: 19981
		private global::AcpBusinessLayer.AcpSimpleRangeField dataWideExternalDataVpnTunnel_43365;

		// Token: 0x04004E0E RID: 19982
		private global::AcpBusinessLayer.AcpSimpleRangeField dataWideExternalDataOORTime_43366;

		// Token: 0x04004E0F RID: 19983
		private global::AcpBusinessLayer.AcpSimpleRangeField dataWideExternalDataModemOpenTime_43367;

		// Token: 0x04004E10 RID: 19984
		private global::AcpBusinessLayer.AcpField<string> dataWideMG90WirelessVPNFriendlyName_43785;

		// Token: 0x04004E11 RID: 19985
		private global::AcpBusinessLayer.AcpField<string> dataWideMG90WirelessLTEFriendlyName_43786;

		// Token: 0x04004E12 RID: 19986
		private global::AcpBusinessLayer.AcpField<string> dataWideMG90WirelessSatelliteFriendlyName_43787;

		// Token: 0x04004E13 RID: 19987
		private global::AcpBusinessLayer.AcpField<bool> dataWideMG90WirelessSatelliteEnable_43788;

		// Token: 0x04004E14 RID: 19988
		private global::AcpBusinessLayer.AcpField<bool> dataWideExternalDataModemHiddenNetwork_44814;
	}
}
