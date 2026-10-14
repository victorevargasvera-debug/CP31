using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using ConstraintHelper;
using Motorola.MackinawCPS.CoreFeatures.DataProfiles;
using Motorola.MackinawCPS.CoreFeatures.DVRSWide;
using Motorola.MackinawCPS.CoreFeatures.RadioInformation;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;
using Motorola.MackinawCPS.CoreFeatures.SecureWide;
using Motorola.MackinawCPS.CoreFeatures.TrunkingWide;

namespace Motorola.MackinawCPS.CoreFeatures.TrunkingSystem
{
	// Token: 0x02000095 RID: 149
	[global::System.Serializable]
	public class General : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06000EE8 RID: 3816 RVA: 0x000EDA44 File Offset: 0x000EBC44
		public General(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06000EE9 RID: 3817 RVA: 0x000EDA60 File Offset: 0x000EBC60
		protected General(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06000EEA RID: 3818 RVA: 0x000EDA78 File Offset: 0x000EBC78
		public override void Init()
		{
			int a_ = 19;
			short num = (short)1484086549;
			short num2 = num;
			num = (short)1447451925;
			switch (num2 == num)
			{
			}
			num = (short)547028993;
			if (num != 0)
			{
			}
			num = (short)35192832;
			if (num != 0)
			{
			}
			num = (short)656015360;
			short num3 = num;
			this.trkSysGeneralConnectToneHz_A7710 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("胓ꓕ돗觙ꗛ귝꟟蟡諣菥髧诩胫귭鿯鳱髳鏵鯷軹ꣻ釽滿朁䰃簅圇䬉㬋㤍ℏ∑", a_), global::CommonResources.AcgResources.ID_CONNECTTONEHZ, global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.LOVs.TrkSysGeneralConnectToneHz_A7710LovStrs);
			this.trkSysGeneralConnectToneHz_A7710.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkSysGeneralConnectToneHz_A7710.DataTransferOrder = 16;
			this.trkSysGeneralCoverageType_A7782 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.LOVs.indexTrkSysGeneralCoverageType_A7782LovStrs, global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.LOVs.idTrkSysGeneralCoverageType_A7782LovStrs), this, global::AllFeatures.CodeplugGuid.b("胓ꓕ돗觙ꗛ귝꟟蟡諣菥髧诩胫귭鿯蓱釳蓵駷鷹駻꫽秿爁愃夅䤇㴉㬋㘍∏", a_), global::CommonResources.AcgResources.ID_COVERAGETYPE, global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.LOVs.TrkSysGeneralCoverageType_A7782LovStrs);
			this.trkSysGeneralCoverageType_A7782.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.trkSysGeneralCoverageType_A7782.DataTransferOrder = 2;
			this.trkSysGeneralCoverageType_A7782.EvaluateRecRefs = true;
			this.trkSysGeneralFailsoftConnectToneHz_A8007 = new global::AcpBusinessLayer.AcpSparseLOVField(8, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.LOVs.indexTrkSysGeneralFailsoftConnectToneHz_A8007LovStrs, global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.LOVs.idTrkSysGeneralFailsoftConnectToneHz_A8007LovStrs), this, global::AllFeatures.CodeplugGuid.b("胓ꓕ돗觙ꗛ귝꟟蟡諣菥髧诩胫꣭釯鯱飳藵韷鳹裻뷽濿氁樃挅欇縉堋愍縏眑尓氕䜗嬙␛⸝ဟᔡ", a_), global::CommonResources.AcgResources.ID_FAILSOFTCONNECTTONEHZ, global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.LOVs.TrkSysGeneralFailsoftConnectToneHz_A8007LovStrs);
			this.trkSysGeneralFailsoftConnectToneHz_A8007.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkSysGeneralFailsoftConnectToneHz_A8007.DataTransferOrder = 84;
			this.trkSysGeneralHomeWACNID_A8205 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("胓ꓕ돗觙ꗛ귝꟟蟡諣菥髧诩胫ꛭ鿯鿱釳ꇵ맷맹닻럽䓿崁䔃㸅㨇㨉㤋", a_), global::CommonResources.AcgResources.ID_HOMEWACNID, 1, 1048574, null, null, 0, 1);
			this.trkSysGeneralHomeWACNID_A8205.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.trkSysGeneralHomeWACNID_A8205.DataTransferOrder = 3;
			this.trkSysGeneralHomeWACNID_A8205.EvaluateRecRefs = true;
			this.trkSysGeneralHomeWACNID_A8205.ShowHexValue = true;
			this.trkSysGeneralHomeWACNID_A8205.ShowLeadingZeros = true;
			this.trkSysLabtoolNetworkID_A8565 = new global::AcpBusinessLayer.AcpSimpleRangeField(0, this, global::AllFeatures.CodeplugGuid.b("胓ꓕ돗觙ꗛ귝곟菡蛣鋥蟧藩胫ꃭ闯蛱菳駵諷釹뗻뫽忿䌁㰃㌅㸇㼉", a_), global::CommonResources.AcgResources.ID_NETWORKID, 0, 65535, null, null, 0, 1);
			this.trkSysLabtoolNetworkID_A8565.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.trkSysLabtoolNetworkID_A8565.DataTransferOrder = 96;
			this.trkSysLabtoolNetworkID_A8565.ShowHexValue = true;
			this.trkSysGeneralNonAdjacentSiteSearch_A8568 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("胓ꓕ돗觙ꗛ귝꟟蟡諣菥髧诩胫ꃭ鿯鳱뗳鋵鋷鯹鿻鯽滿瘁圃漅簇漉弋欍焏怑眓縕䜗嬙␛⬝ᘟᨡ", a_), global::CommonResources.AcgResources.ID_NONADJACENTSITESEARCH);
			this.trkSysGeneralNonAdjacentSiteSearch_A8568.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.trkSysGeneralNonAdjacentSiteSearch_A8568.DataTransferOrder = 41;
			this.trkSysGeneralRFSSID_A8980 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("胓ꓕ돗觙ꗛ귝꟟蟡諣菥髧诩胫볭뛯ꇱꟳ뿵볷ꗹ뷻웽㧿㨁㐃", a_), global::CommonResources.AcgResources.ID_RFSSID, 1, 254, null, null, 0, 1);
			this.trkSysGeneralRFSSID_A8980.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.trkSysGeneralRFSSID_A8980.DataTransferOrder = 17;
			this.trkSysGeneralRFSSID_A8980.ShowHexValue = true;
			this.trkSysGeneralSiteID_A9150 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("胓ꓕ돗觙ꗛ귝꟟蟡諣菥髧诩胫뷭駯蛱釳뿵볷ꗹ뷻쟽ㇿ㜁㐃", a_), global::CommonResources.AcgResources.ID_SITEID, 1, 254, null, null, 0, 1);
			this.trkSysGeneralSiteID_A9150.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkSysGeneralSiteID_A9150.DataTransferOrder = 92;
			this.trkSysGeneralSiteID_A9150.ShowHexValue = true;
			this.trkSysGeneralSystemID_A9239 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("胓ꓕ돗觙ꗛ귝꟟蟡諣菥髧诩胫뷭觯臱胳鏵闷돹룻ꇽ䇿㬁㘃㔅ㄇ", a_), global::CommonResources.AcgResources.ID_SYSTEMID, 1, 65535, null, null, 0, 1);
			this.trkSysGeneralSystemID_A9239.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.trkSysGeneralSystemID_A9239.DataTransferOrder = 4;
			this.trkSysGeneralSystemID_A9239.EvaluateRecRefs = true;
			this.trkSysGeneralSystemID_A9239.ShowHexValue = true;
			this.trkSysGeneralSystemID_A9239.ShowLeadingZeros = true;
			this.trkSysGeneralTypeIIFrequencyBand_A12491 = new global::AcpBusinessLayer.AcpListField(3, this, global::AllFeatures.CodeplugGuid.b("胓ꓕ돗觙ꗛ귝꟟蟡諣菥髧诩胫뫭觯英釳뿵뇷볹軻鯽燿省愃栅欇猉下漍縏瘑䬓圕⤗⠙⠛✝ᄟ", a_), global::CommonResources.AcgResources.ID_TYPEIIFREQUENCYBAND, global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.LOVs.TrkSysGeneralTypeIIFrequencyBand_A12491LovStrs);
			this.trkSysGeneralTypeIIFrequencyBand_A12491.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.trkSysGeneralTypeIIFrequencyBand_A12491.DataTransferOrder = 11;
			this.trkSysGeneralTypeIIFrequencyBand_A12491.EvaluateRecRefs = true;
			this.trkSysGeneralUnitID_A12651 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("胓ꓕ돗觙ꗛ귝꟟蟡諣菥髧诩胫믭黯鯱胳뿵볷ꗹ뷻쿽㋿㐁㄃㜅", a_), global::CommonResources.AcgResources.ID_UNITID, 1, 16777211, null, null, 0, 1);
			this.trkSysGeneralUnitID_A12651.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.trkSysGeneralUnitID_A12651.DataTransferOrder = 80;
			this.trkSysGeneralUnitID_A12651.ShowHexValue = true;
			this.trkSysGeneralKeyofTrunkingSystem_A12658 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("胓ꓕ돗觙ꗛ귝꟟蟡諣菥髧诩胫ꗭ闯诱鯳郵곷裹觻都毿欁樃愅嬇猉缋稍甏缑䬓圕⤗⠙⨛⬝᠟", a_), global::CommonResources.AcgResources.ID_TRUNKINGSYSTEMNAME, 14);
			this.trkSysGeneralKeyofTrunkingSystem_A12658.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.trkSysGeneralKeyofTrunkingSystem_A12658.DataTransferOrder = 31;
			this.trkSysGeneralDataProfileSelection_A19449 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("胓ꓕ돗觙ꗛ귝꟟蟡諣菥髧诩胫ꫭ釯蛱闳꛵諷闹髻韽泿朁圃挅搇漉漋稍礏紑稓䤕夗⬙┛⨝ᐟᬡ", a_), global::CommonResources.AcgResources.ID_DATAPROFILESELECTION, new string[]
			{
				global::CommonResources.AcgResources.ID_DATADISABLED
			}, new int[1], true, false);
			this.trkSysGeneralDataProfileSelection_A19449.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkSysGeneralDataProfileSelection_A19449.DataTransferOrder = 5;
			this.trkSysGeneralDataProfileSelection_A19449.EvaluateRecRefs = true;
			this.trkSysGeneralAskRequired_A44909 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("胓ꓕ돗觙ꗛ귝꟟蟡諣菥髧诩胫꿭華駱꛳鏵觷迹闻賽旿昁嬃䜅㰇㸉㔋㸍⤏", a_), global::CommonResources.AcgResources.ID_ASKREQUIRED);
			this.trkSysGeneralAskRequired_A44909.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.trkSysGeneralAskRequired_A44909.DataTransferOrder = 7;
			this.trkSysGeneralAskRequired_A44909.Editable = false;
			this.trkSysGeneralSystemKeyPresent_A9241 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("胓ꓕ돗觙ꗛ귝꟟蟡諣菥髧诩胫뷭觯臱胳鏵闷뇹駻蟽僿瀁愃甅洇搉砋儍儏⬑☓∕⤗", a_), global::CommonResources.AcgResources.ID_SYSTEMKEYPRESENT);
			this.trkSysGeneralSystemKeyPresent_A9241.IgnoreOnCompare = true;
			this.trkSysGeneralSystemKeyPresent_A9241.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.trkSysGeneralSystemKeyPresent_A9241.DataTransferOrder = -1;
			this.trkSysGeneralSystemType_A9252 = new global::AcpBusinessLayer.AcpSparseLOVField(2, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.LOVs.indexTrkSysGeneralSystemType_A9252LovStrs, global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.LOVs.idTrkSysGeneralSystemType_A9252LovStrs), this, global::AllFeatures.CodeplugGuid.b("胓ꓕ돗觙ꗛ귝꟟蟡諣菥髧诩胫뷭觯臱胳鏵闷껹藻軽旿崁䔃㼅㨇㼉㸋", a_), global::CommonResources.AcgResources.ID_SYSTEMTYPE, global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.LOVs.TrkSysGeneralSystemType_A9252LovStrs);
			this.trkSysGeneralSystemType_A9252.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.trkSysGeneralSystemType_A9252.DataTransferOrder = 1;
			this.trkSysGeneralSystemType_A9252.EvaluateRecRefs = true;
			this.trkSysGeneralRFSSDebounceTimersec_A8979 = new global::AcpBusinessLayer.AcpSimpleRangeField(5, this, global::AllFeatures.CodeplugGuid.b("胓ꓕ돗觙ꗛ귝꟟蟡諣菥髧诩胫볭뛯ꇱꟳ답鷷飹鏻诽滿愁愃刅愇有椋簍挏眑眓䤕夗∙┛⤝᤟", a_), global::CommonResources.AcgResources.ID_RFSSDEBOUNCETIMERSEC, 1, 10, null, null, 0, 1);
			this.trkSysGeneralRFSSDebounceTimersec_A8979.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkSysGeneralRFSSDebounceTimersec_A8979.DataTransferOrder = 72;
			this.trkSysGeneralRFSSDebounceTimersec_A8979.ShowHexValue = false;
			this.trkSysGeneralRFSSResponseTimems_A8981 = new global::AcpBusinessLayer.AcpSimpleRangeField(30, this, global::AllFeatures.CodeplugGuid.b("胓ꓕ돗觙ꗛ귝꟟蟡諣菥髧诩胫볭뛯ꇱꟳꓵ鷷觹賻釽滿焁愃刅愇有椋挍挏䴑唓⸕℗∙ⴛ", a_), global::CommonResources.AcgResources.ID_RFSSRESPONSETIMEMS, 1, 255, null, null, 0, 25);
			this.trkSysGeneralRFSSResponseTimems_A8981.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkSysGeneralRFSSResponseTimems_A8981.DataTransferOrder = 45;
			this.trkSysGeneralRFSSResponseTimems_A8981.ShowHexValue = false;
			this.trkSysGeneralSystemKeyType_A38853 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("胓ꓕ돗觙ꗛ귝꟟蟡諣菥髧诩胫뷭觯臱胳鏵闷뇹駻蟽哿笁球挅圇䬉㼋㘍⠏✑✓", a_), global::CommonResources.AcgResources.ID_SYSTEMKEYTYPE, global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.LOVs.TrkSysGeneralSystemKeyType_A38853LovStrs);
			this.trkSysGeneralSystemKeyType_A38853.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.trkSysGeneralSystemKeyType_A38853.DataTransferOrder = -1;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鏓돕뛗뿙껛뿝賟", a_);
			base.Id = 10157;
			base.UIName = global::CommonResources.AcgResources.ID_GENERAL;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06000EEB RID: 3819 RVA: 0x000EE114 File Offset: 0x000EC314
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 5;
			short num = (short)1733951496;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_E14;
				case 1:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鋅뫇ꇉ鿋럍ꏏ闑뇓룕뷗꣙뷛닝돟鯡韣鋥跧蟩룫韭胯韱꯳럵쇷죹짻쳽", a_)))
					{
						num = (short)1520828462;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_774;
				case 2:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鋅뫇ꇉ鿋럍ꏏ黑뗓듕곗뗙돛닝껟蟡郣釥蟧飩蟫꟭듯귱뗳컵췷쳹짻", a_)))
					{
						num = (short)757006352;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_727;
				case 3:
					this.trkSysGeneralUnitID_A12651 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("鋅뫇ꇉ鿋럍ꏏ闑뇓룕뷗꣙뷛닝뗟賡跣鋥ꇧ껩돫꿭쇯샱싳쏵짷", a_), global::CommonResources.AcgResources.ID_UNITID, null, null, 0, 1);
					this.trkSysGeneralUnitID_A12651.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.trkSysGeneralUnitID_A12651.DataTransferOrder = 80;
					this.trkSysGeneralUnitID_A12651.ShowHexValue = true;
					num = (short)744292364;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
				{
					num = (short)1217796105;
					short num3 = num;
					num = (short)2085820425;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_143;
					default:
						num = (short)1142358016;
						if (num != 0)
						{
						}
						if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鋅뫇ꇉ鿋럍ꏏ闑뇓룕뷗꣙뷛닝뗟賡跣鋥ꇧ껩돫꿭쇯샱싳쏵짷", a_)))
						{
							num = (short)1864957955;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B45;
					}
					break;
				}
				case 5:
					goto IL_AF8;
				case 6:
					goto IL_143;
				case 7:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鋅뫇ꇉ鿋럍ꏏ闑뇓룕뷗꣙뷛닝꣟跡解菥뿧ꯩ꿫ꃭ맯뛱꯳럵샷죹쳻쯽", a_)))
					{
						num = (short)142999589;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4B2;
				case 8:
					switch (0)
					{
					case 0:
						goto IL_122;
					}
					continue;
				case 9:
					this.trkSysGeneralAskRequired_A44909 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鋅뫇ꇉ鿋럍ꏏ闑뇓룕뷗꣙뷛닝ꇟ釡迣듥跧鯩駫蟭苯韱郳꧵맷컹죻쟽ヿ㬁", a_), global::CommonResources.AcgResources.ID_ASKREQUIRED);
					this.trkSysGeneralAskRequired_A44909.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.trkSysGeneralAskRequired_A44909.DataTransferOrder = 7;
					num = (short)1196687402;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鋅뫇ꇉ鿋럍ꏏ闑뇓룕뷗꣙뷛닝듟鯡铣菥ꇧꏩꫫ鳭闯菱至鏵雷駹藻볽懿氁怃夅䤇㬉㸋㨍⤏⌑", a_)))
					{
						num = (short)143917088;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_195;
				case 11:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鋅뫇ꇉ鿋럍ꏏ闑뇓룕뷗꣙뷛닝ꓟ菡郣蟥룧飩菫裭駯黱釳ꗵ鷷雹駻鷽瓿欁欃栅圇䬉㴋㜍␏☑ⴓ", a_)))
					{
						num = (short)1267925048;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_148;
				case 12:
					goto IL_B45;
				case 13:
					this.trkSysGeneralRFSSResponseTimems_A8981 = new global::AcpBusinessLayer.AcpSimpleRangeField(30, this, global::AllFeatures.CodeplugGuid.b("鋅뫇ꇉ鿋럍ꏏ闑뇓룕뷗꣙뷛닝닟ꓡ럣뗥뫧迩鿫黭鿯鳱蟳鏵곷鏹釻鯽淿焁嬃䜅〇㌉㐋㼍", a_), global::CommonResources.AcgResources.ID_RFSSRESPONSETIMEMS, null, null, 0, 25);
					this.trkSysGeneralRFSSResponseTimems_A8981.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkSysGeneralRFSSResponseTimems_A8981.DataTransferOrder = 45;
					this.trkSysGeneralRFSSResponseTimems_A8981.ShowHexValue = false;
					num = (short)1057095731;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					this.trkSysGeneralFailsoftConnectToneHz_A8007 = new global::AcpBusinessLayer.AcpSparseLOVField(8, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.LOVs.indexTrkSysGeneralFailsoftConnectToneHz_A8007LovStrs, global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.LOVs.idTrkSysGeneralFailsoftConnectToneHz_A8007LovStrs), this, global::AllFeatures.CodeplugGuid.b("鋅뫇ꇉ鿋럍ꏏ闑뇓룕뷗꣙뷛닝ꛟ菡跣諥鯧藩諫髭돯鷱髳飵鷷駹裻꫽濿氁愃丅爇唉䴋㘍‏∑⌓", a_), global::CommonResources.AcgResources.ID_FAILSOFTCONNECTTONEHZ, global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.LOVs.TrkSysGeneralFailsoftConnectToneHz_A8007LovStrs);
					this.trkSysGeneralFailsoftConnectToneHz_A8007.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkSysGeneralFailsoftConnectToneHz_A8007.DataTransferOrder = 84;
					num = (short)789708857;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					goto IL_9D2;
				case 16:
					this.trkSysLabtoolNetworkID_A8565 = new global::AcpBusinessLayer.AcpSimpleRangeField(0, this, global::AllFeatures.CodeplugGuid.b("鋅뫇ꇉ鿋럍ꏏ黑뗓듕곗뗙돛닝껟蟡郣釥蟧飩蟫꟭듯귱뗳컵췷쳹짻", a_), global::CommonResources.AcgResources.ID_NETWORKID, null, null, 0, 1);
					this.trkSysLabtoolNetworkID_A8565.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.trkSysLabtoolNetworkID_A8565.DataTransferOrder = 96;
					this.trkSysLabtoolNetworkID_A8565.ShowHexValue = true;
					num = (short)590413867;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					goto IL_4B2;
				case 18:
					goto IL_774;
				case 19:
					goto IL_195;
				case 20:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鋅뫇ꇉ鿋럍ꏏ闑뇓룕뷗꣙뷛닝닟ꓡ럣뗥뫧迩鿫黭鿯鳱蟳鏵곷鏹釻鯽淿焁嬃䜅〇㌉㐋㼍", a_)))
					{
						num = (short)868352013;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_D70;
				case 21:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鋅뫇ꇉ鿋럍ꏏ闑뇓룕뷗꣙뷛닝닟ꓡ럣뗥곧迩軫臭藯鳱音鏵곷鏹釻鯽狿焁愃攅圇䬉㐋㜍✏⬑", a_)))
					{
						num = (short)1285029932;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_400;
				case 22:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鋅뫇ꇉ鿋럍ꏏ闑뇓룕뷗꣙뷛닝돟鯡韣鋥跧蟩꟫语觯꛱跳蛵鷷ꗹ뷻췽㣿㨁㄃㔅", a_)))
					{
						num = (short)2055012388;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_F6A;
				case 23:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鋅뫇ꇉ鿋럍ꏏ闑뇓룕뷗꣙뷛닝돟鯡韣鋥跧蟩꟫语觯ꋱ蛳鏵请鿹鋻諽忿䌁㴃㐅㰇㬉", a_)))
					{
						num = (short)8847408;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_9D2;
				case 24:
					goto IL_EC9;
				case 25:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鋅뫇ꇉ鿋럍ꏏ闑뇓룕뷗꣙뷛닝ꛟ菡跣諥鯧藩諫髭돯鷱髳飵鷷駹裻꫽濿氁愃丅爇唉䴋㘍‏∑⌓", a_)))
					{
						num = (short)672595982;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_256;
				case 26:
					if (producerFields != null)
					{
						num = (short)125894715;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_F6A;
				case 27:
					goto IL_5BC;
				case 28:
					this.trkSysGeneralKeyofTrunkingSystem_A12658 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("鋅뫇ꇉ鿋럍ꏏ闑뇓룕뷗꣙뷛닝ꯟ蟡鷣觥軧뻩黫鯭黯駱鷳飵鿷꧹藻跽瓿朁椃夅䤇㬉㸋㠍┏⨑", a_), global::CommonResources.AcgResources.ID_TRUNKINGSYSTEMNAME, 14);
					this.trkSysGeneralKeyofTrunkingSystem_A12658.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.trkSysGeneralKeyofTrunkingSystem_A12658.DataTransferOrder = 31;
					num = (short)879034392;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 29:
					goto IL_985;
				case 30:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鋅뫇ꇉ鿋럍ꏏ闑뇓룕뷗꣙뷛닝돟诡郣菥ꇧ껩돫꿭짯쏱쇳웵", a_)))
					{
						num = (short)663879734;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_AF8;
				case 31:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鋅뫇ꇉ鿋럍ꏏ闑뇓룕뷗꣙뷛닝ꯟ蟡鷣觥軧뻩黫鯭黯駱鷳飵鿷꧹藻跽瓿朁椃夅䤇㬉㸋㠍┏⨑", a_)))
					{
						num = (short)535953436;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_EC9;
				case 32:
					this.trkSysGeneralTypeIIFrequencyBand_A12491 = new global::AcpBusinessLayer.AcpListField(3, this, global::AllFeatures.CodeplugGuid.b("鋅뫇ꇉ鿋럍ꏏ闑뇓룕뷗꣙뷛닝듟鯡铣菥ꇧꏩꫫ鳭闯菱至鏵雷駹藻볽懿氁怃夅䤇㬉㸋㨍⤏⌑", a_), global::CommonResources.AcgResources.ID_TYPEIIFREQUENCYBAND, global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.LOVs.TrkSysGeneralTypeIIFrequencyBand_A12491LovStrs);
					this.trkSysGeneralTypeIIFrequencyBand_A12491.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.trkSysGeneralTypeIIFrequencyBand_A12491.DataTransferOrder = 11;
					this.trkSysGeneralTypeIIFrequencyBand_A12491.EvaluateRecRefs = true;
					num = (short)1745158163;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 33:
					this.trkSysGeneralCoverageType_A7782 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.LOVs.indexTrkSysGeneralCoverageType_A7782LovStrs, global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.LOVs.idTrkSysGeneralCoverageType_A7782LovStrs), this, global::AllFeatures.CodeplugGuid.b("鋅뫇ꇉ鿋럍ꏏ闑뇓룕뷗꣙뷛닝ꏟ跡鋣菥髧诩诫语ꓯ诱蓳鏵ꟷ믹쯻짽㣿、", a_), global::CommonResources.AcgResources.ID_COVERAGETYPE, global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.LOVs.TrkSysGeneralCoverageType_A7782LovStrs);
					this.trkSysGeneralCoverageType_A7782.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.trkSysGeneralCoverageType_A7782.DataTransferOrder = 2;
					this.trkSysGeneralCoverageType_A7782.EvaluateRecRefs = true;
					num = (short)1114112029;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 34:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鋅뫇ꇉ鿋럍ꏏ闑뇓룕뷗꣙뷛닝돟鯡韣鋥跧蟩ꗫꫭ꿯돱췳쓵쯷쏹", a_)))
					{
						num = (short)1650196521;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_D23;
				case 35:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鋅뫇ꇉ鿋럍ꏏ闑뇓룕뷗꣙뷛닝닟ꓡ럣뗥ꇧ껩돫꿭죯쯱쳳웵", a_)))
					{
						num = (short)2028404791;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5BC;
				case 36:
					this.trkSysGeneralSystemKeyType_A38853 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鋅뫇ꇉ鿋럍ꏏ闑뇓룕뷗꣙뷛닝돟鯡韣鋥跧蟩꟫语觯꛱跳蛵鷷ꗹ뷻췽㣿㨁㄃㔅", a_), global::CommonResources.AcgResources.ID_SYSTEMKEYTYPE, global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.LOVs.TrkSysGeneralSystemKeyType_A38853LovStrs);
					this.trkSysGeneralSystemKeyType_A38853.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.trkSysGeneralSystemKeyType_A38853.DataTransferOrder = -1;
					num = (short)1962737703;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 37:
					this.trkSysGeneralHomeWACNID_A8205 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("鋅뫇ꇉ鿋럍ꏏ闑뇓룕뷗꣙뷛닝꣟跡解菥뿧ꯩ꿫ꃭ맯뛱꯳럵샷죹쳻쯽", a_), global::CommonResources.AcgResources.ID_HOMEWACNID, null, null, 0, 1);
					this.trkSysGeneralHomeWACNID_A8205.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.trkSysGeneralHomeWACNID_A8205.DataTransferOrder = 3;
					this.trkSysGeneralHomeWACNID_A8205.EvaluateRecRefs = true;
					this.trkSysGeneralHomeWACNID_A8205.ShowHexValue = true;
					this.trkSysGeneralHomeWACNID_A8205.ShowLeadingZeros = true;
					num = (short)1014759441;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 38:
					goto IL_400;
				case 39:
					goto IL_5B7;
				case 40:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鋅뫇ꇉ鿋럍ꏏ闑뇓룕뷗꣙뷛닝껟跡諣꟥賧胩跫跭闯鳱胳ꗵ釷軹駻귽旿持瘃攅怇唉䴋㘍┏␑Ⱃ", a_)))
					{
						num = (short)937295930;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A1F;
				case 41:
					this.trkSysGeneralSystemID_A9239 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("鋅뫇ꇉ鿋럍ꏏ闑뇓룕뷗꣙뷛닝돟鯡韣鋥跧蟩ꗫꫭ꿯돱췳쓵쯷쏹", a_), global::CommonResources.AcgResources.ID_SYSTEMID, null, null, 0, 1);
					this.trkSysGeneralSystemID_A9239.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.trkSysGeneralSystemID_A9239.DataTransferOrder = 4;
					this.trkSysGeneralSystemID_A9239.EvaluateRecRefs = true;
					this.trkSysGeneralSystemID_A9239.ShowHexValue = true;
					this.trkSysGeneralSystemID_A9239.ShowLeadingZeros = true;
					num = (short)591855668;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 42:
					goto IL_7C0;
				case 43:
					goto IL_727;
				case 44:
					this.trkSysGeneralRFSSDebounceTimersec_A8979 = new global::AcpBusinessLayer.AcpSimpleRangeField(5, this, global::AllFeatures.CodeplugGuid.b("鋅뫇ꇉ鿋럍ꏏ闑뇓룕뷗꣙뷛닝닟ꓡ럣뗥곧迩軫臭藯鳱音鏵곷鏹釻鯽狿焁愃攅圇䬉㐋㜍✏⬑", a_), global::CommonResources.AcgResources.ID_RFSSDEBOUNCETIMERSEC, null, null, 0, 1);
					this.trkSysGeneralRFSSDebounceTimersec_A8979.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkSysGeneralRFSSDebounceTimersec_A8979.DataTransferOrder = 72;
					this.trkSysGeneralRFSSDebounceTimersec_A8979.ShowHexValue = false;
					num = (short)999227430;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 45:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鋅뫇ꇉ鿋럍ꏏ闑뇓룕뷗꣙뷛닝ꏟ跡鋣菥髧诩诫语ꓯ诱蓳鏵ꟷ믹쯻짽㣿、", a_)))
					{
						num = (short)774963233;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_985;
				case 46:
					this.trkSysGeneralSystemType_A9252 = new global::AcpBusinessLayer.AcpSparseLOVField(2, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.LOVs.indexTrkSysGeneralSystemType_A9252LovStrs, global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.LOVs.idTrkSysGeneralSystemType_A9252LovStrs), this, global::AllFeatures.CodeplugGuid.b("鋅뫇ꇉ鿋럍ꏏ闑뇓룕뷗꣙뷛닝돟鯡韣鋥跧蟩룫韭胯韱꯳럵쇷죹짻쳽", a_), global::CommonResources.AcgResources.ID_SYSTEMTYPE, global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.LOVs.TrkSysGeneralSystemType_A9252LovStrs);
					this.trkSysGeneralSystemType_A9252.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.trkSysGeneralSystemType_A9252.DataTransferOrder = 1;
					this.trkSysGeneralSystemType_A9252.EvaluateRecRefs = true;
					num = (short)2057371666;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 47:
					goto IL_148;
				case 48:
					this.trkSysGeneralSystemKeyPresent_A9241 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("鋅뫇ꇉ鿋럍ꏏ闑뇓룕뷗꣙뷛닝돟鯡韣鋥跧蟩꟫语觯ꋱ蛳鏵请鿹鋻諽忿䌁㴃㐅㰇㬉", a_), global::CommonResources.AcgResources.ID_SYSTEMKEYPRESENT);
					this.trkSysGeneralSystemKeyPresent_A9241.IgnoreOnCompare = true;
					this.trkSysGeneralSystemKeyPresent_A9241.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.trkSysGeneralSystemKeyPresent_A9241.DataTransferOrder = -1;
					num = (short)387383311;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 49:
					this.trkSysGeneralConnectToneHz_A7710 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鋅뫇ꇉ鿋럍ꏏ闑뇓룕뷗꣙뷛닝ꏟ跡諣裥跧觩飫뫭鿯鳱釳뻵苷ꗹ뷻짽㟿㌁㐃", a_), global::CommonResources.AcgResources.ID_CONNECTTONEHZ, global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.LOVs.TrkSysGeneralConnectToneHz_A7710LovStrs);
					this.trkSysGeneralConnectToneHz_A7710.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkSysGeneralConnectToneHz_A7710.DataTransferOrder = 16;
					num = (short)1922564096;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 50:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鋅뫇ꇉ鿋럍ꏏ闑뇓룕뷗꣙뷛닝ꏟ跡諣裥跧觩飫뫭鿯鳱釳뻵苷ꗹ뷻짽㟿㌁㐃", a_)))
					{
						num = (short)21954609;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_E14;
				case 51:
					goto IL_D70;
				case 52:
					goto IL_D23;
				case 53:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鋅뫇ꇉ鿋럍ꏏ闑뇓룕뷗꣙뷛닝ꇟ釡迣듥跧鯩駫蟭苯韱郳꧵맷컹죻쟽ヿ㬁", a_)))
					{
						num = (short)571932681;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_7C0;
				case 54:
					this.trkSysGeneralSiteID_A9150 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("鋅뫇ꇉ鿋럍ꏏ闑뇓룕뷗꣙뷛닝돟诡郣菥ꇧ껩돫꿭짯쏱쇳웵", a_), global::CommonResources.AcgResources.ID_SITEID, null, null, 0, 1);
					this.trkSysGeneralSiteID_A9150.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkSysGeneralSiteID_A9150.DataTransferOrder = 92;
					this.trkSysGeneralSiteID_A9150.ShowHexValue = true;
					num = (short)1748828165;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 55:
					num = (short)31064065;
					if (num != 0)
					{
					}
					this.trkSysGeneralRFSSID_A8980 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("鋅뫇ꇉ鿋럍ꏏ闑뇓룕뷗꣙뷛닝닟ꓡ럣뗥ꇧ껩돫꿭죯쯱쳳웵", a_), global::CommonResources.AcgResources.ID_RFSSID, null, null, 0, 1);
					this.trkSysGeneralRFSSID_A8980.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.trkSysGeneralRFSSID_A8980.DataTransferOrder = 17;
					this.trkSysGeneralRFSSID_A8980.ShowHexValue = true;
					num = (short)1703477275;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 56:
					this.trkSysGeneralDataProfileSelection_A19449 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("鋅뫇ꇉ鿋럍ꏏ闑뇓룕뷗꣙뷛닝ꓟ菡郣蟥룧飩菫裭駯黱釳ꗵ鷷雹駻鷽瓿欁欃栅圇䬉㴋㜍␏☑ⴓ", a_), global::CommonResources.AcgResources.ID_DATAPROFILESELECTION, new string[]
					{
						global::CommonResources.AcgResources.ID_DATADISABLED
					}, new int[1], true, false);
					this.trkSysGeneralDataProfileSelection_A19449.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkSysGeneralDataProfileSelection_A19449.DataTransferOrder = 5;
					this.trkSysGeneralDataProfileSelection_A19449.EvaluateRecRefs = true;
					num = (short)573505583;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 57:
					goto IL_256;
				case 58:
					this.trkSysGeneralNonAdjacentSiteSearch_A8568 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鋅뫇ꇉ鿋럍ꏏ闑뇓룕뷗꣙뷛닝껟跡諣꟥賧胩跫跭闯鳱胳ꗵ釷軹駻귽旿持瘃攅怇唉䴋㘍┏␑Ⱃ", a_), global::CommonResources.AcgResources.ID_NONADJACENTSITESEARCH);
					this.trkSysGeneralNonAdjacentSiteSearch_A8568.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.trkSysGeneralNonAdjacentSiteSearch_A8568.DataTransferOrder = 41;
					num = (short)960233532;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 59:
					num = (short)285016114;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 60:
					goto IL_A1F;
				}
				IL_122:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1607139334;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_143:
				num = (short)600571930;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_148:
				num = (short)1367212085;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_195:
				num = (short)484769792;
				short num4 = num;
				num = (short)1104609284;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_256:
				num = (short)1147928583;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_400:
				num = (short)638320660;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_4B2:
				num = (short)1451491330;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_5BC:
				num = (short)1691222046;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_727:
				num = (short)880476200;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_774:
				num = (short)1354039317;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_7C0:
				num = (short)1301348375;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_985:
				num = (short)313983001;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_9D2:
				num = (short)1269891073;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_A1F:
				num = (short)175702051;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_AF8:
				num = (short)463536162;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_B45:
				num = (short)1087373343;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_D23:
				num = (short)110362634;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_D70:
				num = (short)1374093334;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_E14:
				num = (short)1938096173;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_EC9:
				num = (short)44498955;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_5B7:
			IL_F6A:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("臅귇꓉꧋볍뇏뻑", a_);
			base.Id = 10157;
			base.UIName = global::CommonResources.AcgResources.ID_GENERAL;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06000EEC RID: 3820 RVA: 0x000EF0BC File Offset: 0x000ED2BC
		public override void PopulateReferences()
		{
			short num = (short)1943184613;
			short num2 = num;
			num = (short)728147173;
			switch (num2 == num)
			{
			}
			num = (short)1238958081;
			if (num != 0)
			{
			}
			num = (short)1360068608;
			if (num != 0)
			{
			}
			num = (short)594608128;
			short num3 = num;
			this.trkSysGeneralDataProfileSelection_A19449.SetRecset(this.a(2054));
		}

		// Token: 0x06000EED RID: 3821 RVA: 0x000EF17C File Offset: 0x000ED37C
		public override void DropReferences()
		{
			short num = (short)1601212766;
			short num2 = num;
			num = (short)1181978974;
			switch (num2 == num)
			{
			}
			num = (short)1959985153;
			if (num != 0)
			{
			}
			num = (short)398065664;
			if (num != 0)
			{
			}
			num = (short)926351360;
			short num3 = num;
		}

		// Token: 0x06000EEE RID: 3822 RVA: 0x000EF224 File Offset: 0x000ED424
		public override void SetConstraints()
		{
			short num = (short)1959095595;
			short num2 = num;
			num = (short)1757965611;
			switch (num2 == num)
			{
			}
			num = (short)137887745;
			if (num != 0)
			{
			}
			num = (short)1763180544;
			if (num != 0)
			{
			}
			num = (short)221577216;
			short num3 = num;
			this.trkSysGeneralConnectToneHz_A7710.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConTrkSysTypeIsNotAstro25);
			this.trkSysGeneralConnectToneHz_A7710.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConTrkSysTypeIsII);
			this.trkSysGeneralConnectToneHz_A7710.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.conSetNetworkIDSiteIDTxFrequencyBasedOnSystemType);
			this.trkSysGeneralCoverageType_A7782.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConValidateIntraWACNCoverageTypeForSysType);
			this.trkSysGeneralCoverageType_A7782.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.conSetRfssAlsNum);
			this.trkSysGeneralCoverageType_A7782.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConFieldNotEditableWhenAskRequiredInSameTrkSysIsOn);
			this.trkSysGeneralFailsoftConnectToneHz_A8007.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConTrkSysTypeIsNotAstro25);
			this.trkSysGeneralFailsoftConnectToneHz_A8007.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConTrkSysTypeIsII);
			this.trkSysGeneralHomeWACNID_A8205.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConTrkSysTypeIsAstro25AndTriggerValidity);
			this.trkSysLabtoolNetworkID_A8565.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConTrkSysTypeIsNotAstro25);
			this.trkSysLabtoolNetworkID_A8565.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.conReturnFalse);
			this.trkSysGeneralNonAdjacentSiteSearch_A8568.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConTrkSysIfAmssIsSmartZone);
			this.trkSysGeneralRFSSID_A8980.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConTrkSysCvgTypeNotSmartZoneOmniLink);
			this.trkSysGeneralRFSSID_A8980.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConTrkSysTypeIsAstro25);
			this.trkSysGeneralRFSSID_A8980.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.conSetRfssAlsNum);
			this.trkSysGeneralSiteID_A9150.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConAmssSelIsDisabled);
			this.trkSysGeneralSiteID_A9150.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.conValidateSiteIDRangeBasedOnSystemType);
			this.trkSysGeneralSiteID_A9150.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConTrkSysTypeIsAstro25);
			this.trkSysGeneralSystemID_A9239.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConTriggerScanChannelOnSystemIDChanged);
			this.trkSysGeneralSystemID_A9239.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.conSetMaxForSystemIDBasedOnSystemType);
			this.trkSysGeneralSystemID_A9239.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.conSetNetworkIDSiteIDTxFrequencyBasedOnSystemType);
			this.trkSysGeneralSystemID_A9239.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConFieldNotEditableWhenAskRequiredInSameTrkSysIsOn);
			this.trkSysGeneralTypeIIFrequencyBand_A12491.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.conValidateTypeIIFreqBandForBlockReport);
			this.trkSysGeneralTypeIIFrequencyBand_A12491.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.conValidateTypeIIFreqBand);
			this.trkSysGeneralTypeIIFrequencyBand_A12491.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConTrkSysTypeIsII);
			this.trkSysGeneralTypeIIFrequencyBand_A12491.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.conSetValueTxFrequencyBasedOnTypeIIFrequencyBand);
			this.trkSysGeneralUnitID_A12651.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.conUnitIDNotEqualASTRO25GroupIDAndRangeCheckBasedOnSystemType);
			this.trkSysGeneralUnitID_A12651.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConInvisibleWhenOpenfromRMC);
			this.trkSysGeneralUnitID_A12651.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.conNonEditableWhenOpenFromRMC);
			this.trkSysGeneralDataProfileSelection_A19449.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConTrkSysTypeIsAstro25);
			this.trkSysGeneralDataProfileSelection_A19449.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.conDataDisabledForTypeII);
			this.trkSysGeneralSystemKeyPresent_A9241.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.trkSysGeneralSystemType_A9252.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConTrkPer8382CallApplicabilityConstraint);
			this.trkSysGeneralSystemType_A9252.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConTrkPer8382CallValidityConstraint);
			this.trkSysGeneralSystemType_A9252.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.conSetNetworkIDSiteIDTxFrequencyBasedOnSystemType);
			this.trkSysGeneralSystemType_A9252.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConFieldNotEditableWhenAskRequiredInSameTrkSysIsOn);
			this.trkSysGeneralRFSSDebounceTimersec_A8979.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConTrkSysCvgTypeIsSmartZoneAndOmniLink);
			this.trkSysGeneralSystemKeyType_A38853.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConSystemKeyTypeNotEditable);
			this.trkSysGeneralAskRequired_A44909.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConChangeApplicabilityOnCoverageTypeChanged);
		}

		// Token: 0x06000EEF RID: 3823 RVA: 0x000EF650 File Offset: 0x000ED850
		public override void SetupDependencies()
		{
			short num = (short)1850001587;
			short num2 = num;
			num = (short)368625843;
			switch (num2 == num)
			{
			}
			num = (short)1631387649;
			if (num != 0)
			{
			}
			num = (short)783155200;
			if (num != 0)
			{
			}
			num = (short)931659776;
			short num3 = num;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem = base.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem;
			this.trkSysGeneralSystemType_A9252.AddDependentObject(this.trkSysGeneralConnectToneHz_A7710);
			this.trkSysGeneralTypeIIFrequencyBand_A12491.AddDependentObject(this.trkSysGeneralConnectToneHz_A7710);
			this.trkSysGeneralRFSSID_A8980.AddDependentObject(this.trkSysGeneralCoverageType_A7782);
			this.trkSysGeneralSystemType_A9252.AddDependentObject(this.trkSysGeneralCoverageType_A7782);
			this.RefDVRSWide.General.RadErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911.AddDependentObject(this.trkSysGeneralCoverageType_A7782);
			this.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.AddDependentObject(this.trkSysGeneralCoverageType_A7782);
			this.RefRadioWide.DualRadio.RadWideDualRadioSecRadioTransmissionCapability_A42238.AddDependentObject(this.trkSysGeneralCoverageType_A7782);
			this.trkSysGeneralSystemType_A9252.AddDependentObject(this.trkSysGeneralFailsoftConnectToneHz_A8007);
			this.trkSysGeneralSystemType_A9252.AddDependentObject(this.trkSysGeneralHomeWACNID_A8205);
			this.trkSysGeneralSystemType_A9252.AddDependentObject(this.trkSysLabtoolNetworkID_A8565);
			this.trkSysGeneralCoverageType_A7782.AddDependentObject(this.trkSysGeneralNonAdjacentSiteSearch_A8568);
			this.trkSysGeneralSystemType_A9252.AddDependentObject(this.trkSysGeneralRFSSID_A8980);
			this.trkSysGeneralCoverageType_A7782.AddDependentObject(this.trkSysGeneralRFSSID_A8980);
			this.trkSysGeneralSystemType_A9252.AddDependentObject(this.trkSysGeneralSiteID_A9150);
			this.trkSysGeneralCoverageType_A7782.AddDependentObject(this.trkSysGeneralSiteID_A9150);
			this.trkSysGeneralSystemType_A9252.AddDependentObject(this.trkSysGeneralSystemID_A9239);
			this.trkSysGeneralTypeIIFrequencyBand_A12491.AddDependentObject(this.trkSysGeneralSystemID_A9239);
			this.trkSysGeneralSystemType_A9252.AddDependentObject(this.trkSysGeneralTypeIIFrequencyBand_A12491);
			this.RefRadioInformation.Labtool.RadInfoLabtoolPrimaryBands_A23987.AddDependentObject(this.trkSysGeneralTypeIIFrequencyBand_A12491);
			this.RefRadioInformation.Labtool.RadInfoLabtoolSecondaryBands_A23988.AddDependentObject(this.trkSysGeneralTypeIIFrequencyBand_A12491);
			this.RefRadioInformation.Labtool.RadInfoLabtoolDualBandEnable_A23986.AddDependentObject(this.trkSysGeneralTypeIIFrequencyBand_A12491);
			this.trkSysGeneralSystemType_A9252.AddDependentObject(this.trkSysGeneralUnitID_A12651);
			this.trkSysGeneralDataProfileSelection_A19449.AddDependentObject(this.trkSysGeneralUnitID_A12651);
			this.trkSysGeneralSystemType_A9252.AddDependentObject(this.trkSysGeneralDataProfileSelection_A19449);
			this.trkSysGeneralCoverageType_A7782.AddDependentObject(this.trkSysGeneralDataProfileSelection_A19449);
			trunkingSystem.SecureMultikey.TrkSysSecureMultikeyASTROOTAR_A7494.AddDependentObject(this.trkSysGeneralDataProfileSelection_A19449);
			trunkingSystem.SecureMultikey.TrkSysSecureMultikeyKMFProfileIndex_A8382.AddDependentObject(this.trkSysGeneralDataProfileSelection_A19449);
			this.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.AddDependentObject(this.trkSysGeneralDataProfileSelection_A19449);
			this.RefRadioWide.DualRadio.RadWideDualRadioSecRadioTransmissionCapability_A42238.AddDependentObject(this.trkSysGeneralDataProfileSelection_A19449);
			this.trkSysGeneralTypeIIFrequencyBand_A12491.AddDependentObject(this.trkSysGeneralSystemType_A9252);
			this.trkSysGeneralCoverageType_A7782.AddDependentObject(this.trkSysGeneralRFSSDebounceTimersec_A8979);
			this.trkSysGeneralSystemType_A9252.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2021)[0][10042] as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.ASTROOTAR).SecWideASTROOTARRadioInhibitviaASTROOTAR_A8834);
			this.trkSysGeneralSystemType_A9252.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2027)[0][10060] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingWide.Labtool).TrkWideLabtoolPhase2ScramblingDisable_A37983);
		}

		// Token: 0x17000750 RID: 1872
		// (get) Token: 0x06000EF0 RID: 3824 RVA: 0x000EF9EC File Offset: 0x000EDBEC
		public global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles DataProfilesForTrkSysGeneralDataProfileSelection_A19449
		{
			get
			{
				short num = (short)1519641288;
				short num2 = num;
				num = (short)2090197704;
				switch (num2 == num)
				{
				}
				num = (short)1754464257;
				if (num != 0)
				{
				}
				num = (short)510984192;
				if (num != 0)
				{
				}
				num = (short)419627008;
				short num3 = num;
				return this.trkSysGeneralDataProfileSelection_A19449.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles;
			}
		}

		// Token: 0x17000751 RID: 1873
		// (get) Token: 0x06000EF1 RID: 3825 RVA: 0x000EFAA4 File Offset: 0x000EDCA4
		public bool HasDiffs
		{
			get
			{
				short num = (short)1317142529;
				if (num != 0)
				{
				}
				num = (short)1112339281;
				short num2 = num;
				num = (short)457372497;
				switch (num2 == num)
				{
				}
				num = (short)871301120;
				if (num != 0)
				{
				}
				num = (short)534315008;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x17000752 RID: 1874
		// (get) Token: 0x06000EF2 RID: 3826 RVA: 0x000EFB54 File Offset: 0x000EDD54
		// (set) Token: 0x06000EF3 RID: 3827 RVA: 0x000EFC08 File Offset: 0x000EDE08
		public int TrkSysGeneralConnectToneHz_A7710Value
		{
			get
			{
				short num = (short)772225397;
				short num2 = num;
				num = (short)1300707701;
				switch (num2 == num)
				{
				}
				num = (short)259719168;
				if (num != 0)
				{
				}
				num = (short)1633353729;
				if (num != 0)
				{
				}
				num = (short)1837760512;
				short num3 = num;
				return this.trkSysGeneralConnectToneHz_A7710.Value;
			}
			set
			{
				short num = (short)1596265937;
				short num2 = num;
				num = (short)1045239249;
				switch (num2 == num)
				{
				}
				num = (short)1828978689;
				if (num != 0)
				{
				}
				num = (short)142671872;
				if (num != 0)
				{
				}
				num = (short)769720320;
				short num3 = num;
				this.trkSysGeneralConnectToneHz_A7710.Value = value;
			}
		}

		// Token: 0x17000753 RID: 1875
		// (get) Token: 0x06000EF4 RID: 3828 RVA: 0x000EFCC0 File Offset: 0x000EDEC0
		// (set) Token: 0x06000EF5 RID: 3829 RVA: 0x000EFD74 File Offset: 0x000EDF74
		public string TrkSysGeneralConnectToneHz_A7710_UIValue
		{
			get
			{
				short num = (short)987075553;
				short num2 = num;
				num = (short)972657633;
				switch (num2 == num)
				{
				}
				num = (short)627834881;
				if (num != 0)
				{
				}
				num = (short)1348927488;
				if (num != 0)
				{
				}
				num = (short)413335552;
				short num3 = num;
				return this.trkSysGeneralConnectToneHz_A7710.UIValue;
			}
			set
			{
				short num = (short)717105805;
				short num2 = num;
				num = (short)650848909;
				switch (num2 == num)
				{
				}
				num = (short)486080513;
				if (num != 0)
				{
				}
				num = (short)1962344448;
				if (num != 0)
				{
				}
				num = (short)531955712;
				short num3 = num;
				this.trkSysGeneralConnectToneHz_A7710.UIValue = value;
			}
		}

		// Token: 0x17000754 RID: 1876
		// (get) Token: 0x06000EF6 RID: 3830 RVA: 0x000EFE2C File Offset: 0x000EE02C
		public global::AcpBusinessLayer.AcpListField TrkSysGeneralConnectToneHz_A7710
		{
			get
			{
				short num = (short)759912690;
				short num2 = num;
				num = (short)402544882;
				switch (num2 == num)
				{
				}
				num = (short)691077121;
				if (num != 0)
				{
				}
				num = (short)678100992;
				if (num != 0)
				{
				}
				num = (short)1773600768;
				short num3 = num;
				return this.trkSysGeneralConnectToneHz_A7710;
			}
		}

		// Token: 0x17000755 RID: 1877
		// (get) Token: 0x06000EF7 RID: 3831 RVA: 0x000EFEDC File Offset: 0x000EE0DC
		// (set) Token: 0x06000EF8 RID: 3832 RVA: 0x000EFF90 File Offset: 0x000EE190
		public bool TrkSysGeneralConnectToneHz_A7710_Applicable
		{
			get
			{
				short num = (short)1394619730;
				short num2 = num;
				num = (short)1466250578;
				switch (num2 == num)
				{
				}
				num = (short)2092498945;
				if (num != 0)
				{
				}
				num = (short)2063990784;
				if (num != 0)
				{
				}
				num = (short)95158272;
				short num3 = num;
				return this.trkSysGeneralConnectToneHz_A7710.Applicable;
			}
			set
			{
				short num = (short)570573419;
				short num2 = num;
				num = (short)1440367211;
				switch (num2 == num)
				{
				}
				num = (short)1793196033;
				if (num != 0)
				{
				}
				num = (short)1103167488;
				if (num != 0)
				{
				}
				num = (short)29491200;
				short num3 = num;
				this.trkSysGeneralConnectToneHz_A7710.Applicable = value;
			}
		}

		// Token: 0x17000756 RID: 1878
		// (get) Token: 0x06000EF9 RID: 3833 RVA: 0x000F0044 File Offset: 0x000EE244
		// (set) Token: 0x06000EFA RID: 3834 RVA: 0x000F00F8 File Offset: 0x000EE2F8
		public bool TrkSysGeneralConnectToneHz_A7710_Valid
		{
			get
			{
				short num = (short)121433565;
				short num2 = num;
				num = (short)729738717;
				switch (num2 == num)
				{
				}
				num = (short)345702400;
				if (num != 0)
				{
				}
				num = (short)213188609;
				if (num != 0)
				{
				}
				num = (short)471138304;
				short num3 = num;
				return this.trkSysGeneralConnectToneHz_A7710.Valid;
			}
			set
			{
				short num = (short)1410925878;
				short num2 = num;
				num = (short)1532036406;
				switch (num2 == num)
				{
				}
				num = (short)881459200;
				if (num != 0)
				{
				}
				num = (short)1118961665;
				if (num != 0)
				{
				}
				num = (short)245170176;
				short num3 = num;
				this.trkSysGeneralConnectToneHz_A7710.Valid = value;
			}
		}

		// Token: 0x17000757 RID: 1879
		// (get) Token: 0x06000EFB RID: 3835 RVA: 0x000F01AC File Offset: 0x000EE3AC
		// (set) Token: 0x06000EFC RID: 3836 RVA: 0x000F0260 File Offset: 0x000EE460
		public bool TrkSysGeneralConnectToneHz_A7710_Visible
		{
			get
			{
				short num = (short)1772360822;
				short num2 = num;
				num = (short)327554166;
				switch (num2 == num)
				{
				}
				num = (short)1610088449;
				if (num != 0)
				{
				}
				num = (short)1734082560;
				if (num != 0)
				{
				}
				num = (short)443940864;
				short num3 = num;
				return this.trkSysGeneralConnectToneHz_A7710.Visible;
			}
			set
			{
				short num = (short)2032730113;
				if (num != 0)
				{
				}
				num = (short)1312888178;
				short num2 = num;
				num = (short)1527453042;
				switch (num2 == num)
				{
				}
				num = (short)54853632;
				if (num != 0)
				{
				}
				num = (short)914882560;
				short num3 = num;
				this.trkSysGeneralConnectToneHz_A7710.Visible = value;
			}
		}

		// Token: 0x17000758 RID: 1880
		// (get) Token: 0x06000EFD RID: 3837 RVA: 0x000F0318 File Offset: 0x000EE518
		// (set) Token: 0x06000EFE RID: 3838 RVA: 0x000F03D0 File Offset: 0x000EE5D0
		public bool TrkSysGeneralConnectToneHz_A7710_Editable
		{
			get
			{
				short num = (short)87320550;
				short num2 = num;
				num = (short)1715693542;
				switch (num2 == num)
				{
				}
				num = (short)941490177;
				if (num != 0)
				{
				}
				num = (short)2011561984;
				if (num != 0)
				{
				}
				num = (short)348192768;
				short num3 = num;
				return this.trkSysGeneralConnectToneHz_A7710.Editable;
			}
			set
			{
				short num = (short)43619923;
				short num2 = num;
				num = (short)1537250899;
				switch (num2 == num)
				{
				}
				num = (short)1871577089;
				if (num != 0)
				{
				}
				num = (short)594083840;
				if (num != 0)
				{
				}
				num = (short)1291452416;
				short num3 = num;
				this.trkSysGeneralConnectToneHz_A7710.Editable = value;
			}
		}

		// Token: 0x17000759 RID: 1881
		// (get) Token: 0x06000EFF RID: 3839 RVA: 0x000F0484 File Offset: 0x000EE684
		internal string TrkSysGeneralConnectToneHz_A7710_UILabel
		{
			get
			{
				short num = (short)398181938;
				short num2 = num;
				num = (short)780191282;
				switch (num2 == num)
				{
				}
				num = (short)448331777;
				if (num != 0)
				{
				}
				num = (short)969867264;
				if (num != 0)
				{
				}
				num = (short)845479936;
				short num3 = num;
				return this.trkSysGeneralConnectToneHz_A7710.UIName;
			}
		}

		// Token: 0x1700075A RID: 1882
		// (get) Token: 0x06000F00 RID: 3840 RVA: 0x000F0538 File Offset: 0x000EE738
		// (set) Token: 0x06000F01 RID: 3841 RVA: 0x000F05F0 File Offset: 0x000EE7F0
		internal bool TrkSysGeneralConnectToneHz_A7710_HiddenStatic
		{
			get
			{
				short num = (short)977338369;
				if (num != 0)
				{
				}
				num = (short)1388363011;
				short num2 = num;
				num = (short)74890499;
				switch (num2 == num)
				{
				}
				num = (short)1716518912;
				if (num != 0)
				{
				}
				num = (short)1317339136;
				short num3 = num;
				return this.trkSysGeneralConnectToneHz_A7710.HiddenStatic;
			}
			set
			{
				short num = (short)631898113;
				if (num != 0)
				{
				}
				num = (short)1312585750;
				short num2 = num;
				num = (short)913274902;
				switch (num2 == num)
				{
				}
				num = (short)1095827456;
				if (num != 0)
				{
				}
				num = (short)327024640;
				short num3 = num;
				this.trkSysGeneralConnectToneHz_A7710.HiddenStatic = value;
			}
		}

		// Token: 0x1700075B RID: 1883
		// (get) Token: 0x06000F02 RID: 3842 RVA: 0x000F06A4 File Offset: 0x000EE8A4
		// (set) Token: 0x06000F03 RID: 3843 RVA: 0x000F075C File Offset: 0x000EE95C
		internal bool TrkSysGeneralConnectToneHz_A7710_HiddenDynamic
		{
			get
			{
				short num = (short)1326902367;
				short num2 = num;
				num = (short)1236855903;
				switch (num2 == num)
				{
				}
				num = (short)99287041;
				if (num != 0)
				{
				}
				num = (short)1447821312;
				if (num != 0)
				{
				}
				num = (short)977207296;
				short num3 = num;
				return this.trkSysGeneralConnectToneHz_A7710.HiddenDynamic;
			}
			set
			{
				short num = (short)1467146766;
				short num2 = num;
				num = (short)556589582;
				switch (num2 == num)
				{
				}
				num = (short)697630721;
				if (num != 0)
				{
				}
				num = (short)518717440;
				if (num != 0)
				{
				}
				num = (short)1167458304;
				short num3 = num;
				this.trkSysGeneralConnectToneHz_A7710.HiddenDynamic = value;
			}
		}

		// Token: 0x1700075C RID: 1884
		// (get) Token: 0x06000F04 RID: 3844 RVA: 0x000F0810 File Offset: 0x000EEA10
		public bool TrkSysGeneralConnectToneHz_A7710_HasDiffs
		{
			get
			{
				short num = (short)51739911;
				short num2 = num;
				num = (short)1826651399;
				switch (num2 == num)
				{
				}
				num = (short)1658257409;
				if (num != 0)
				{
				}
				num = (short)1265106944;
				if (num != 0)
				{
				}
				num = (short)2054488064;
				short num3 = num;
				return this.trkSysGeneralConnectToneHz_A7710._HasDiffs;
			}
		}

		// Token: 0x1700075D RID: 1885
		// (get) Token: 0x06000F05 RID: 3845 RVA: 0x000F08C4 File Offset: 0x000EEAC4
		// (set) Token: 0x06000F06 RID: 3846 RVA: 0x000F0978 File Offset: 0x000EEB78
		public int TrkSysGeneralCoverageType_A7782Value
		{
			get
			{
				short num = (short)29884417;
				if (num != 0)
				{
				}
				num = (short)1401651393;
				short num2 = num;
				num = (short)670597313;
				switch (num2 == num)
				{
				}
				num = (short)1618870272;
				if (num != 0)
				{
				}
				num = (short)943652864;
				short num3 = num;
				return this.trkSysGeneralCoverageType_A7782.Value;
			}
			set
			{
				short num = (short)1325698856;
				short num2 = num;
				num = (short)718180136;
				switch (num2 == num)
				{
				}
				num = (short)1870069761;
				if (num != 0)
				{
				}
				num = (short)2068840448;
				if (num != 0)
				{
				}
				num = (short)161153024;
				short num3 = num;
				this.trkSysGeneralCoverageType_A7782.Value = value;
			}
		}

		// Token: 0x1700075E RID: 1886
		// (get) Token: 0x06000F07 RID: 3847 RVA: 0x000F0A30 File Offset: 0x000EEC30
		// (set) Token: 0x06000F08 RID: 3848 RVA: 0x000F0AE4 File Offset: 0x000EECE4
		public string TrkSysGeneralCoverageType_A7782_UIValue
		{
			get
			{
				short num = (short)2121092237;
				short num2 = num;
				num = (short)937643149;
				switch (num2 == num)
				{
				}
				num = (short)1007222784;
				short num3 = num;
				num = (short)1657798656;
				if (num != 0)
				{
				}
				num = (short)1246691329;
				if (num != 0)
				{
				}
				return this.trkSysGeneralCoverageType_A7782.UIValue;
			}
			set
			{
				short num = (short)368190782;
				short num2 = num;
				num = (short)660743486;
				switch (num2 == num)
				{
				}
				num = (short)649854976;
				short num3 = num;
				num = (short)699400193;
				if (num != 0)
				{
				}
				num = (short)2087976960;
				if (num != 0)
				{
				}
				this.trkSysGeneralCoverageType_A7782.UIValue = value;
			}
		}

		// Token: 0x1700075F RID: 1887
		// (get) Token: 0x06000F09 RID: 3849 RVA: 0x000F0B98 File Offset: 0x000EED98
		public global::AcpBusinessLayer.AcpListField TrkSysGeneralCoverageType_A7782
		{
			get
			{
				short num = (short)354675048;
				short num2 = num;
				num = (short)1616111976;
				switch (num2 == num)
				{
				}
				num = (short)1856241664;
				short num3 = num;
				num = (short)547487745;
				if (num != 0)
				{
				}
				num = (short)579076096;
				if (num != 0)
				{
				}
				return this.trkSysGeneralCoverageType_A7782;
			}
		}

		// Token: 0x17000760 RID: 1888
		// (get) Token: 0x06000F0A RID: 3850 RVA: 0x000F0C48 File Offset: 0x000EEE48
		// (set) Token: 0x06000F0B RID: 3851 RVA: 0x000F0CF8 File Offset: 0x000EEEF8
		public bool TrkSysGeneralCoverageType_A7782_Applicable
		{
			get
			{
				short num = (short)1760413219;
				short num2 = num;
				num = (short)746571299;
				switch (num2 == num)
				{
				}
				num = (short)1613889536;
				short num3 = num;
				num = (short)968818689;
				if (num != 0)
				{
				}
				num = (short)1548550144;
				if (num != 0)
				{
				}
				return this.trkSysGeneralCoverageType_A7782.Applicable;
			}
			set
			{
				short num = (short)1040318465;
				if (num != 0)
				{
				}
				num = (short)1508396511;
				short num2 = num;
				num = (short)1458327007;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1483407360;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1549139968;
				if (num != 0)
				{
				}
				this.trkSysGeneralCoverageType_A7782.Applicable = value;
			}
		}

		// Token: 0x17000761 RID: 1889
		// (get) Token: 0x06000F0C RID: 3852 RVA: 0x000F0DB0 File Offset: 0x000EEFB0
		// (set) Token: 0x06000F0D RID: 3853 RVA: 0x000F0E64 File Offset: 0x000EF064
		public bool TrkSysGeneralCoverageType_A7782_Valid
		{
			get
			{
				short num = (short)1223879224;
				short num2 = num;
				num = (short)229304888;
				switch (num2 == num)
				{
				}
				num = (short)659095552;
				short num3 = num;
				num = (short)568524801;
				if (num != 0)
				{
				}
				num = (short)373489664;
				if (num != 0)
				{
				}
				return this.trkSysGeneralCoverageType_A7782.Valid;
			}
			set
			{
				short num = (short)1129441223;
				short num2 = num;
				num = (short)326625223;
				switch (num2 == num)
				{
				}
				num = (short)1460535296;
				short num3 = num;
				num = (short)1837760513;
				if (num != 0)
				{
				}
				num = (short)2062614528;
				if (num != 0)
				{
				}
				this.trkSysGeneralCoverageType_A7782.Valid = value;
			}
		}

		// Token: 0x17000762 RID: 1890
		// (get) Token: 0x06000F0E RID: 3854 RVA: 0x000F0F18 File Offset: 0x000EF118
		// (set) Token: 0x06000F0F RID: 3855 RVA: 0x000F0FCC File Offset: 0x000EF1CC
		public bool TrkSysGeneralCoverageType_A7782_Visible
		{
			get
			{
				short num = (short)1073723443;
				short num2 = num;
				num = (short)2122299443;
				switch (num2 == num)
				{
				}
				num = (short)464257024;
				short num3 = num;
				num = (short)2119761920;
				if (num != 0)
				{
				}
				num = (short)1536884737;
				if (num != 0)
				{
				}
				return this.trkSysGeneralCoverageType_A7782.Visible;
			}
			set
			{
				short num = (short)344064001;
				if (num != 0)
				{
				}
				num = (short)1009532615;
				short num2 = num;
				num = (short)212680391;
				switch (num2 == num)
				{
				default:
				{
					num = (short)145686528;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)757137408;
				if (num != 0)
				{
				}
				this.trkSysGeneralCoverageType_A7782.Visible = value;
			}
		}

		// Token: 0x17000763 RID: 1891
		// (get) Token: 0x06000F10 RID: 3856 RVA: 0x000F1080 File Offset: 0x000EF280
		// (set) Token: 0x06000F11 RID: 3857 RVA: 0x000F1134 File Offset: 0x000EF334
		public bool TrkSysGeneralCoverageType_A7782_Editable
		{
			get
			{
				short num = (short)1756037121;
				if (num != 0)
				{
				}
				num = (short)742114056;
				short num2 = num;
				num = (short)984728328;
				switch (num2 == num)
				{
				default:
				{
					num = (short)249298944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1041563648;
				if (num != 0)
				{
				}
				return this.trkSysGeneralCoverageType_A7782.Editable;
			}
			set
			{
				short num = (short)2055303790;
				short num2 = num;
				num = (short)231961198;
				switch (num2 == num)
				{
				}
				num = (short)2060386304;
				short num3 = num;
				num = (short)1188036609;
				if (num != 0)
				{
				}
				num = (short)2137718784;
				if (num != 0)
				{
				}
				this.trkSysGeneralCoverageType_A7782.Editable = value;
			}
		}

		// Token: 0x17000764 RID: 1892
		// (get) Token: 0x06000F12 RID: 3858 RVA: 0x000F11EC File Offset: 0x000EF3EC
		internal string TrkSysGeneralCoverageType_A7782_UILabel
		{
			get
			{
				short num = (short)2037701930;
				short num2 = num;
				num = (short)737860906;
				switch (num2 == num)
				{
				}
				num = (short)1724514304;
				short num3 = num;
				num = (short)1473708033;
				if (num != 0)
				{
				}
				num = (short)263323648;
				if (num != 0)
				{
				}
				return this.trkSysGeneralCoverageType_A7782.UIName;
			}
		}

		// Token: 0x17000765 RID: 1893
		// (get) Token: 0x06000F13 RID: 3859 RVA: 0x000F12A0 File Offset: 0x000EF4A0
		// (set) Token: 0x06000F14 RID: 3860 RVA: 0x000F1354 File Offset: 0x000EF554
		internal bool TrkSysGeneralCoverageType_A7782_HiddenStatic
		{
			get
			{
				short num = (short)2067969114;
				short num2 = num;
				num = (short)840479834;
				switch (num2 == num)
				{
				}
				num = (short)1335820288;
				short num3 = num;
				num = (short)2132017153;
				if (num != 0)
				{
				}
				num = (short)102432768;
				if (num != 0)
				{
				}
				return this.trkSysGeneralCoverageType_A7782.HiddenStatic;
			}
			set
			{
				short num = (short)717411800;
				short num2 = num;
				num = (short)238147032;
				switch (num2 == num)
				{
				}
				num = (short)384565248;
				short num3 = num;
				num = (short)893911041;
				if (num != 0)
				{
				}
				num = (short)1347092480;
				if (num != 0)
				{
				}
				this.trkSysGeneralCoverageType_A7782.HiddenStatic = value;
			}
		}

		// Token: 0x17000766 RID: 1894
		// (get) Token: 0x06000F15 RID: 3861 RVA: 0x000F1408 File Offset: 0x000EF608
		// (set) Token: 0x06000F16 RID: 3862 RVA: 0x000F14BC File Offset: 0x000EF6BC
		internal bool TrkSysGeneralCoverageType_A7782_HiddenDynamic
		{
			get
			{
				short num = (short)964054881;
				short num2 = num;
				num = (short)607866721;
				switch (num2 == num)
				{
				}
				num = (short)459669504;
				short num3 = num;
				num = (short)1827536897;
				if (num != 0)
				{
				}
				num = (short)1739063296;
				if (num != 0)
				{
				}
				return this.trkSysGeneralCoverageType_A7782.HiddenDynamic;
			}
			set
			{
				short num = (short)1686533660;
				short num2 = num;
				num = (short)1710323228;
				switch (num2 == num)
				{
				}
				num = (short)29032448;
				short num3 = num;
				num = (short)2092564480;
				if (num != 0)
				{
				}
				num = (short)274595841;
				if (num != 0)
				{
				}
				this.trkSysGeneralCoverageType_A7782.HiddenDynamic = value;
			}
		}

		// Token: 0x17000767 RID: 1895
		// (get) Token: 0x06000F17 RID: 3863 RVA: 0x000F1570 File Offset: 0x000EF770
		public bool TrkSysGeneralCoverageType_A7782_HasDiffs
		{
			get
			{
				short num = (short)1397114412;
				short num2 = num;
				num = (short)1027491372;
				switch (num2 == num)
				{
				}
				num = (short)1512964096;
				short num3 = num;
				num = (short)825425921;
				if (num != 0)
				{
				}
				num = (short)982712320;
				if (num != 0)
				{
				}
				return this.trkSysGeneralCoverageType_A7782._HasDiffs;
			}
		}

		// Token: 0x17000768 RID: 1896
		// (get) Token: 0x06000F18 RID: 3864 RVA: 0x000F1624 File Offset: 0x000EF824
		// (set) Token: 0x06000F19 RID: 3865 RVA: 0x000F16D8 File Offset: 0x000EF8D8
		public int TrkSysGeneralFailsoftConnectToneHz_A8007Value
		{
			get
			{
				short num = (short)512302300;
				short num2 = num;
				num = (short)2003246300;
				switch (num2 == num)
				{
				}
				num = (short)1314848768;
				short num3 = num;
				num = (short)1476198400;
				if (num != 0)
				{
				}
				num = (short)411303937;
				if (num != 0)
				{
				}
				return this.trkSysGeneralFailsoftConnectToneHz_A8007.Value;
			}
			set
			{
				short num = (short)1118699521;
				if (num != 0)
				{
				}
				num = (short)1392402104;
				short num2 = num;
				num = (short)621698744;
				switch (num2 == num)
				{
				default:
				{
					num = (short)387121152;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1547042816;
				if (num != 0)
				{
				}
				this.trkSysGeneralFailsoftConnectToneHz_A8007.Value = value;
			}
		}

		// Token: 0x17000769 RID: 1897
		// (get) Token: 0x06000F1A RID: 3866 RVA: 0x000F1790 File Offset: 0x000EF990
		// (set) Token: 0x06000F1B RID: 3867 RVA: 0x000F1844 File Offset: 0x000EFA44
		public string TrkSysGeneralFailsoftConnectToneHz_A8007_UIValue
		{
			get
			{
				short num = (short)1037426547;
				short num2 = num;
				num = (short)383246195;
				switch (num2 == num)
				{
				}
				num = (short)1858469888;
				short num3 = num;
				num = (short)240648192;
				if (num != 0)
				{
				}
				num = (short)127270913;
				if (num != 0)
				{
				}
				return this.trkSysGeneralFailsoftConnectToneHz_A8007.UIValue;
			}
			set
			{
				short num = (short)12459608;
				short num2 = num;
				num = (short)728833624;
				switch (num2 == num)
				{
				}
				num = (short)450625536;
				short num3 = num;
				num = (short)1940783104;
				if (num != 0)
				{
				}
				num = (short)1103626241;
				if (num != 0)
				{
				}
				this.trkSysGeneralFailsoftConnectToneHz_A8007.UIValue = value;
			}
		}

		// Token: 0x1700076A RID: 1898
		// (get) Token: 0x06000F1C RID: 3868 RVA: 0x000F18F8 File Offset: 0x000EFAF8
		public global::AcpBusinessLayer.AcpListField TrkSysGeneralFailsoftConnectToneHz_A8007
		{
			get
			{
				short num = (short)929300481;
				if (num != 0)
				{
				}
				num = (short)617806824;
				short num2 = num;
				num = (short)55770088;
				switch (num2 == num)
				{
				default:
				{
					num = (short)12845056;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1027538944;
				if (num != 0)
				{
				}
				return this.trkSysGeneralFailsoftConnectToneHz_A8007;
			}
		}

		// Token: 0x1700076B RID: 1899
		// (get) Token: 0x06000F1D RID: 3869 RVA: 0x000F19A8 File Offset: 0x000EFBA8
		// (set) Token: 0x06000F1E RID: 3870 RVA: 0x000F1A60 File Offset: 0x000EFC60
		public bool TrkSysGeneralFailsoftConnectToneHz_A8007_Applicable
		{
			get
			{
				short num = (short)687538177;
				if (num != 0)
				{
				}
				num = (short)638856260;
				short num2 = num;
				num = (short)1204169796;
				switch (num2 == num)
				{
				default:
				{
					num = (short)750452736;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1414856704;
				if (num != 0)
				{
				}
				return this.trkSysGeneralFailsoftConnectToneHz_A8007.Applicable;
			}
			set
			{
				short num = (short)1219819323;
				short num2 = num;
				num = (short)431486779;
				switch (num2 == num)
				{
				}
				num = (short)248119296;
				short num3 = num;
				num = (short)877658113;
				if (num != 0)
				{
				}
				num = (short)1865154560;
				if (num != 0)
				{
				}
				this.trkSysGeneralFailsoftConnectToneHz_A8007.Applicable = value;
			}
		}

		// Token: 0x1700076C RID: 1900
		// (get) Token: 0x06000F1F RID: 3871 RVA: 0x000F1B18 File Offset: 0x000EFD18
		// (set) Token: 0x06000F20 RID: 3872 RVA: 0x000F1BD4 File Offset: 0x000EFDD4
		public bool TrkSysGeneralFailsoftConnectToneHz_A8007_Valid
		{
			get
			{
				short num = (short)1289090019;
				short num2 = num;
				num = (short)547091427;
				switch (num2 == num)
				{
				}
				num = (short)188350464;
				short num3 = num;
				num = (short)1789526017;
				if (num != 0)
				{
				}
				num = (short)1338245120;
				if (num != 0)
				{
				}
				return this.trkSysGeneralFailsoftConnectToneHz_A8007.Valid;
			}
			set
			{
				short num = (short)1925800926;
				short num2 = num;
				num = (short)1096049630;
				switch (num2 == num)
				{
				}
				num = (short)208601088;
				short num3 = num;
				num = (short)1931149313;
				if (num != 0)
				{
				}
				num = (short)40763392;
				if (num != 0)
				{
				}
				this.trkSysGeneralFailsoftConnectToneHz_A8007.Valid = value;
			}
		}

		// Token: 0x1700076D RID: 1901
		// (get) Token: 0x06000F21 RID: 3873 RVA: 0x000F1C8C File Offset: 0x000EFE8C
		// (set) Token: 0x06000F22 RID: 3874 RVA: 0x000F1D44 File Offset: 0x000EFF44
		public bool TrkSysGeneralFailsoftConnectToneHz_A8007_Visible
		{
			get
			{
				short num = (short)342398690;
				short num2 = num;
				num = (short)1790416610;
				switch (num2 == num)
				{
				}
				num = (short)362807296;
				short num3 = num;
				num = (short)280363009;
				if (num != 0)
				{
				}
				num = (short)462356480;
				if (num != 0)
				{
				}
				return this.trkSysGeneralFailsoftConnectToneHz_A8007.Visible;
			}
			set
			{
				short num = (short)1355504389;
				short num2 = num;
				num = (short)1104567045;
				switch (num2 == num)
				{
				}
				num = (short)1581121536;
				short num3 = num;
				num = (short)1413677057;
				if (num != 0)
				{
				}
				num = (short)1441923072;
				if (num != 0)
				{
				}
				this.trkSysGeneralFailsoftConnectToneHz_A8007.Visible = value;
			}
		}

		// Token: 0x1700076E RID: 1902
		// (get) Token: 0x06000F23 RID: 3875 RVA: 0x000F1DF8 File Offset: 0x000EFFF8
		// (set) Token: 0x06000F24 RID: 3876 RVA: 0x000F1EB0 File Offset: 0x000F00B0
		public bool TrkSysGeneralFailsoftConnectToneHz_A8007_Editable
		{
			get
			{
				short num = (short)643902670;
				short num2 = num;
				num = (short)1256654;
				switch (num2 == num)
				{
				}
				num = (short)994574336;
				short num3 = num;
				num = (short)498532353;
				if (num != 0)
				{
				}
				num = (short)1064566784;
				if (num != 0)
				{
				}
				return this.trkSysGeneralFailsoftConnectToneHz_A8007.Editable;
			}
			set
			{
				short num = (short)1037214974;
				short num2 = num;
				num = (short)450340094;
				switch (num2 == num)
				{
				}
				num = (short)461373440;
				short num3 = num;
				num = (short)1635385345;
				if (num != 0)
				{
				}
				num = (short)1971781632;
				if (num != 0)
				{
				}
				this.trkSysGeneralFailsoftConnectToneHz_A8007.Editable = value;
			}
		}

		// Token: 0x1700076F RID: 1903
		// (get) Token: 0x06000F25 RID: 3877 RVA: 0x000F1F64 File Offset: 0x000F0164
		internal string TrkSysGeneralFailsoftConnectToneHz_A8007_UILabel
		{
			get
			{
				short num = (short)271908865;
				if (num != 0)
				{
				}
				num = (short)1766099741;
				short num2 = num;
				num = (short)214338333;
				switch (num2 == num)
				{
				default:
				{
					num = (short)853999616;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1829175296;
				if (num != 0)
				{
				}
				return this.trkSysGeneralFailsoftConnectToneHz_A8007.UIName;
			}
		}

		// Token: 0x17000770 RID: 1904
		// (get) Token: 0x06000F26 RID: 3878 RVA: 0x000F2018 File Offset: 0x000F0218
		// (set) Token: 0x06000F27 RID: 3879 RVA: 0x000F20CC File Offset: 0x000F02CC
		internal bool TrkSysGeneralFailsoftConnectToneHz_A8007_HiddenStatic
		{
			get
			{
				short num = (short)1807436715;
				short num2 = num;
				num = (short)265964459;
				switch (num2 == num)
				{
				}
				num = (short)2106130432;
				short num3 = num;
				num = (short)1866727424;
				if (num != 0)
				{
				}
				num = (short)827523073;
				if (num != 0)
				{
				}
				return this.trkSysGeneralFailsoftConnectToneHz_A8007.HiddenStatic;
			}
			set
			{
				short num = (short)893845505;
				if (num != 0)
				{
				}
				num = (short)97935879;
				short num2 = num;
				num = (short)1716216327;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1623130112;
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
				this.trkSysGeneralFailsoftConnectToneHz_A8007.HiddenStatic = value;
			}
		}

		// Token: 0x17000771 RID: 1905
		// (get) Token: 0x06000F28 RID: 3880 RVA: 0x000F2184 File Offset: 0x000F0384
		// (set) Token: 0x06000F29 RID: 3881 RVA: 0x000F2238 File Offset: 0x000F0438
		internal bool TrkSysGeneralFailsoftConnectToneHz_A8007_HiddenDynamic
		{
			get
			{
				short num = (short)1900241961;
				short num2 = num;
				num = (short)1232954409;
				switch (num2 == num)
				{
				}
				num = (short)494272512;
				short num3 = num;
				num = (short)1177616385;
				if (num != 0)
				{
				}
				num = (short)988020736;
				if (num != 0)
				{
				}
				return this.trkSysGeneralFailsoftConnectToneHz_A8007.HiddenDynamic;
			}
			set
			{
				short num = (short)1186983144;
				short num2 = num;
				num = (short)504491240;
				switch (num2 == num)
				{
				}
				num = (short)1925054464;
				short num3 = num;
				num = (short)1055719424;
				if (num != 0)
				{
				}
				num = (short)1105657857;
				if (num != 0)
				{
				}
				this.trkSysGeneralFailsoftConnectToneHz_A8007.HiddenDynamic = value;
			}
		}

		// Token: 0x17000772 RID: 1906
		// (get) Token: 0x06000F2A RID: 3882 RVA: 0x000F22EC File Offset: 0x000F04EC
		public bool TrkSysGeneralFailsoftConnectToneHz_A8007_HasDiffs
		{
			get
			{
				short num = (short)1915351186;
				short num2 = num;
				num = (short)317714578;
				switch (num2 == num)
				{
				}
				num = (short)116719616;
				short num3 = num;
				num = (short)1382875136;
				if (num != 0)
				{
				}
				num = (short)566427649;
				if (num != 0)
				{
				}
				return this.trkSysGeneralFailsoftConnectToneHz_A8007._HasDiffs;
			}
		}

		// Token: 0x17000773 RID: 1907
		// (get) Token: 0x06000F2B RID: 3883 RVA: 0x000F23A0 File Offset: 0x000F05A0
		// (set) Token: 0x06000F2C RID: 3884 RVA: 0x000F2454 File Offset: 0x000F0654
		public int TrkSysGeneralHomeWACNID_A8205Value
		{
			get
			{
				short num = (short)114010744;
				short num2 = num;
				num = (short)1186572920;
				switch (num2 == num)
				{
				}
				num = (short)1561919488;
				short num3 = num;
				num = (short)363200513;
				if (num != 0)
				{
				}
				num = (short)1743192064;
				if (num != 0)
				{
				}
				return this.trkSysGeneralHomeWACNID_A8205.Value;
			}
			set
			{
				short num = (short)1968832513;
				if (num != 0)
				{
				}
				num = (short)2093442154;
				short num2 = num;
				num = (short)776430698;
				switch (num2 == num)
				{
				default:
				{
					num = (short)491192320;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2021588992;
				if (num != 0)
				{
				}
				this.trkSysGeneralHomeWACNID_A8205.Value = value;
			}
		}

		// Token: 0x17000774 RID: 1908
		// (get) Token: 0x06000F2D RID: 3885 RVA: 0x000F2508 File Offset: 0x000F0708
		public global::AcpBusinessLayer.AcpSimpleRangeField TrkSysGeneralHomeWACNID_A8205
		{
			get
			{
				short num = (short)1251216147;
				short num2 = num;
				num = (short)189664019;
				switch (num2 == num)
				{
				}
				num = (short)89128960;
				short num3 = num;
				num = (short)90963969;
				if (num != 0)
				{
				}
				num = (short)838074368;
				if (num != 0)
				{
				}
				return this.trkSysGeneralHomeWACNID_A8205;
			}
		}

		// Token: 0x17000775 RID: 1909
		// (get) Token: 0x06000F2E RID: 3886 RVA: 0x000F25BC File Offset: 0x000F07BC
		// (set) Token: 0x06000F2F RID: 3887 RVA: 0x000F2674 File Offset: 0x000F0874
		public string TrkSysGeneralHomeWACNID_A8205_UIValue
		{
			get
			{
				short num = (short)136530713;
				short num2 = num;
				num = (short)2088389401;
				switch (num2 == num)
				{
				}
				num = (short)1376714752;
				short num3 = num;
				num = (short)279445505;
				if (num != 0)
				{
				}
				num = (short)827719680;
				if (num != 0)
				{
				}
				return this.trkSysGeneralHomeWACNID_A8205.UIValue;
			}
			set
			{
				short num = (short)174742179;
				short num2 = num;
				num = (short)1035295395;
				switch (num2 == num)
				{
				}
				num = (short)953614336;
				short num3 = num;
				num = (short)38928384;
				if (num != 0)
				{
				}
				num = (short)467206145;
				if (num != 0)
				{
				}
				this.trkSysGeneralHomeWACNID_A8205.UIValue = value;
			}
		}

		// Token: 0x17000776 RID: 1910
		// (get) Token: 0x06000F30 RID: 3888 RVA: 0x000F2728 File Offset: 0x000F0928
		// (set) Token: 0x06000F31 RID: 3889 RVA: 0x000F27D8 File Offset: 0x000F09D8
		public string TrkSysGeneralHomeWACNID_A8205_HexUIValue
		{
			get
			{
				short num = (short)1255552426;
				short num2 = num;
				num = (short)2038838698;
				switch (num2 == num)
				{
				}
				num = (short)486277120;
				short num3 = num;
				num = (short)1537474561;
				if (num != 0)
				{
				}
				num = (short)540999680;
				if (num != 0)
				{
				}
				return this.trkSysGeneralHomeWACNID_A8205.HexUIValue;
			}
			set
			{
				short num = (short)2121582190;
				short num2 = num;
				num = (short)1363592814;
				switch (num2 == num)
				{
				}
				num = (short)968949760;
				short num3 = num;
				num = (short)285212673;
				if (num != 0)
				{
				}
				num = (short)931921920;
				if (num != 0)
				{
				}
				this.trkSysGeneralHomeWACNID_A8205.HexUIValue = value;
			}
		}

		// Token: 0x17000777 RID: 1911
		// (get) Token: 0x06000F32 RID: 3890 RVA: 0x000F288C File Offset: 0x000F0A8C
		// (set) Token: 0x06000F33 RID: 3891 RVA: 0x000F2940 File Offset: 0x000F0B40
		internal int TrkSysGeneralHomeWACNID_A8205Min
		{
			get
			{
				short num = (short)1652773229;
				short num2 = num;
				num = (short)1214402925;
				switch (num2 == num)
				{
				}
				num = (short)846856192;
				short num3 = num;
				num = (short)1628045313;
				if (num != 0)
				{
				}
				num = (short)1623785472;
				if (num != 0)
				{
				}
				return this.trkSysGeneralHomeWACNID_A8205.Min;
			}
			set
			{
				short num = (short)940286723;
				short num2 = num;
				num = (short)725590787;
				switch (num2 == num)
				{
				}
				num = (short)409206784;
				short num3 = num;
				num = (short)1292369920;
				if (num != 0)
				{
				}
				num = (short)2082603009;
				if (num != 0)
				{
				}
				this.trkSysGeneralHomeWACNID_A8205.Min = value;
			}
		}

		// Token: 0x17000778 RID: 1912
		// (get) Token: 0x06000F34 RID: 3892 RVA: 0x000F29F8 File Offset: 0x000F0BF8
		// (set) Token: 0x06000F35 RID: 3893 RVA: 0x000F2AA8 File Offset: 0x000F0CA8
		internal int TrkSysGeneralHomeWACNID_A8205Max
		{
			get
			{
				short num = (short)2008058555;
				short num2 = num;
				num = (short)2022476475;
				switch (num2 == num)
				{
				}
				num = (short)492371968;
				short num3 = num;
				num = (short)348323841;
				if (num != 0)
				{
				}
				num = (short)1445920768;
				if (num != 0)
				{
				}
				return this.trkSysGeneralHomeWACNID_A8205.Max;
			}
			set
			{
				short num = (short)529006593;
				if (num != 0)
				{
				}
				num = (short)1167974904;
				short num2 = num;
				num = (short)1526129144;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1467547648;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)681508864;
				if (num != 0)
				{
				}
				this.trkSysGeneralHomeWACNID_A8205.Max = value;
			}
		}

		// Token: 0x17000779 RID: 1913
		// (get) Token: 0x06000F36 RID: 3894 RVA: 0x000F2B60 File Offset: 0x000F0D60
		// (set) Token: 0x06000F37 RID: 3895 RVA: 0x000F2C14 File Offset: 0x000F0E14
		internal int TrkSysGeneralHomeWACNID_A8205Step
		{
			get
			{
				short num = (short)1615065178;
				short num2 = num;
				num = (short)1742991450;
				switch (num2 == num)
				{
				}
				num = (short)2035744768;
				short num3 = num;
				num = (short)1795883009;
				if (num != 0)
				{
				}
				num = (short)1800273920;
				if (num != 0)
				{
				}
				return this.trkSysGeneralHomeWACNID_A8205.StepSize;
			}
			set
			{
				short num = (short)294743458;
				short num2 = num;
				num = (short)595029410;
				switch (num2 == num)
				{
				}
				num = (short)1754791936;
				short num3 = num;
				num = (short)611975169;
				if (num != 0)
				{
				}
				num = (short)1408368640;
				if (num != 0)
				{
				}
				this.trkSysGeneralHomeWACNID_A8205.StepSize = value;
			}
		}

		// Token: 0x1700077A RID: 1914
		// (get) Token: 0x06000F38 RID: 3896 RVA: 0x000F2CC8 File Offset: 0x000F0EC8
		// (set) Token: 0x06000F39 RID: 3897 RVA: 0x000F2D80 File Offset: 0x000F0F80
		public bool TrkSysGeneralHomeWACNID_A8205_Applicable
		{
			get
			{
				short num = (short)12059130;
				short num2 = num;
				num = (short)1804272122;
				switch (num2 == num)
				{
				}
				num = (short)217186304;
				short num3 = num;
				num = (short)963313665;
				if (num != 0)
				{
				}
				num = (short)1634795520;
				if (num != 0)
				{
				}
				return this.trkSysGeneralHomeWACNID_A8205.Applicable;
			}
			set
			{
				short num = (short)592160307;
				short num2 = num;
				num = (short)1315284531;
				switch (num2 == num)
				{
				}
				num = (short)1306198016;
				short num3 = num;
				num = (short)1886191617;
				if (num != 0)
				{
				}
				num = (short)213057536;
				if (num != 0)
				{
				}
				this.trkSysGeneralHomeWACNID_A8205.Applicable = value;
			}
		}

		// Token: 0x1700077B RID: 1915
		// (get) Token: 0x06000F3A RID: 3898 RVA: 0x000F2E34 File Offset: 0x000F1034
		// (set) Token: 0x06000F3B RID: 3899 RVA: 0x000F2EEC File Offset: 0x000F10EC
		public bool TrkSysGeneralHomeWACNID_A8205_Valid
		{
			get
			{
				short num = (short)958776625;
				short num2 = num;
				num = (short)1946862897;
				switch (num2 == num)
				{
				}
				num = (short)1502085120;
				short num3 = num;
				num = (short)1817968641;
				if (num != 0)
				{
				}
				num = (short)651362304;
				if (num != 0)
				{
				}
				return this.trkSysGeneralHomeWACNID_A8205.Valid;
			}
			set
			{
				short num = (short)1362173519;
				short num2 = num;
				num = (short)1928666703;
				switch (num2 == num)
				{
				}
				num = (short)793772032;
				short num3 = num;
				num = (short)399376385;
				if (num != 0)
				{
				}
				num = (short)191234048;
				if (num != 0)
				{
				}
				this.trkSysGeneralHomeWACNID_A8205.Valid = value;
			}
		}

		// Token: 0x1700077C RID: 1916
		// (get) Token: 0x06000F3C RID: 3900 RVA: 0x000F2FA4 File Offset: 0x000F11A4
		// (set) Token: 0x06000F3D RID: 3901 RVA: 0x000F3058 File Offset: 0x000F1258
		public bool TrkSysGeneralHomeWACNID_A8205_Visible
		{
			get
			{
				short num = (short)2004984141;
				short num2 = num;
				num = (short)930390349;
				switch (num2 == num)
				{
				}
				num = (short)2028142592;
				short num3 = num;
				num = (short)1133576193;
				if (num != 0)
				{
				}
				num = (short)2116026368;
				if (num != 0)
				{
				}
				return this.trkSysGeneralHomeWACNID_A8205.Visible;
			}
			set
			{
				short num = (short)2064150736;
				short num2 = num;
				num = (short)245395664;
				switch (num2 == num)
				{
				}
				num = (short)1206779904;
				short num3 = num;
				num = (short)619118593;
				if (num != 0)
				{
				}
				num = (short)1795096576;
				if (num != 0)
				{
				}
				this.trkSysGeneralHomeWACNID_A8205.Visible = value;
			}
		}

		// Token: 0x1700077D RID: 1917
		// (get) Token: 0x06000F3E RID: 3902 RVA: 0x000F310C File Offset: 0x000F130C
		// (set) Token: 0x06000F3F RID: 3903 RVA: 0x000F31C0 File Offset: 0x000F13C0
		public bool TrkSysGeneralHomeWACNID_A8205_Editable
		{
			get
			{
				short num = (short)1661620388;
				short num2 = num;
				num = (short)297160868;
				switch (num2 == num)
				{
				}
				num = (short)1754333184;
				short num3 = num;
				num = (short)530841600;
				if (num != 0)
				{
				}
				num = (short)1314979841;
				if (num != 0)
				{
				}
				return this.trkSysGeneralHomeWACNID_A8205.Editable;
			}
			set
			{
				short num = (short)1576139002;
				short num2 = num;
				num = (short)1221327098;
				switch (num2 == num)
				{
				}
				num = (short)1688862720;
				short num3 = num;
				num = (short)1683226625;
				if (num != 0)
				{
				}
				num = (short)1504903168;
				if (num != 0)
				{
				}
				this.trkSysGeneralHomeWACNID_A8205.Editable = value;
			}
		}

		// Token: 0x1700077E RID: 1918
		// (get) Token: 0x06000F40 RID: 3904 RVA: 0x000F3278 File Offset: 0x000F1478
		internal string TrkSysGeneralHomeWACNID_A8205_UILabel
		{
			get
			{
				short num = (short)1336803329;
				if (num != 0)
				{
				}
				num = (short)2032202285;
				short num2 = num;
				num = (short)619573805;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1206714368;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1704919040;
				if (num != 0)
				{
				}
				return this.trkSysGeneralHomeWACNID_A8205.UIName;
			}
		}

		// Token: 0x1700077F RID: 1919
		// (get) Token: 0x06000F41 RID: 3905 RVA: 0x000F332C File Offset: 0x000F152C
		// (set) Token: 0x06000F42 RID: 3906 RVA: 0x000F33E0 File Offset: 0x000F15E0
		internal bool TrkSysGeneralHomeWACNID_A8205_HiddenStatic
		{
			get
			{
				short num = (short)104333312;
				short num2 = num;
				num = (short)1414332417;
				if (num != 0)
				{
				}
				num = (short)74175039;
				short num3 = num;
				num = (short)1623773759;
				switch (num3 == num)
				{
				}
				num = (short)539492352;
				if (num != 0)
				{
				}
				return this.trkSysGeneralHomeWACNID_A8205.HiddenStatic;
			}
			set
			{
				short num = (short)1714421760;
				short num2 = num;
				num = (short)1635379713;
				short num3 = num;
				num = (short)1640425985;
				switch (num3 == num)
				{
				}
				num = (short)703135745;
				if (num != 0)
				{
				}
				num = (short)1447559168;
				if (num != 0)
				{
				}
				this.trkSysGeneralHomeWACNID_A8205.HiddenStatic = value;
			}
		}

		// Token: 0x17000780 RID: 1920
		// (get) Token: 0x06000F43 RID: 3907 RVA: 0x000F3494 File Offset: 0x000F1694
		// (set) Token: 0x06000F44 RID: 3908 RVA: 0x000F3548 File Offset: 0x000F1748
		internal bool TrkSysGeneralHomeWACNID_A8205_HiddenDynamic
		{
			get
			{
				short num = (short)1638072320;
				short num2 = num;
				num = (short)468538197;
				short num3 = num;
				num = (short)604590933;
				switch (num3 == num)
				{
				}
				num = (short)865206273;
				if (num != 0)
				{
				}
				num = (short)309198848;
				if (num != 0)
				{
				}
				return this.trkSysGeneralHomeWACNID_A8205.HiddenDynamic;
			}
			set
			{
				short num = (short)830865408;
				short num2 = num;
				num = (short)1312132289;
				short num3 = num;
				num = (short)628853953;
				switch (num3 == num)
				{
				}
				num = (short)1216020480;
				if (num != 0)
				{
				}
				num = (short)525467649;
				if (num != 0)
				{
				}
				this.trkSysGeneralHomeWACNID_A8205.HiddenDynamic = value;
			}
		}

		// Token: 0x17000781 RID: 1921
		// (get) Token: 0x06000F45 RID: 3909 RVA: 0x000F35FC File Offset: 0x000F17FC
		public bool TrkSysGeneralHomeWACNID_A8205_HasDiffs
		{
			get
			{
				short num = (short)1020854272;
				short num2 = num;
				num = (short)2049870692;
				short num3 = num;
				num = (short)1069583204;
				switch (num3 == num)
				{
				}
				num = (short)662437889;
				if (num != 0)
				{
				}
				num = (short)232783872;
				if (num != 0)
				{
				}
				return this.trkSysGeneralHomeWACNID_A8205._HasDiffs;
			}
		}

		// Token: 0x17000782 RID: 1922
		// (get) Token: 0x06000F46 RID: 3910 RVA: 0x000F36B0 File Offset: 0x000F18B0
		// (set) Token: 0x06000F47 RID: 3911 RVA: 0x000F3764 File Offset: 0x000F1964
		public int TrkSysLabtoolNetworkID_A8565Value
		{
			get
			{
				short num = (short)1231093760;
				short num2 = num;
				num = (short)827759048;
				short num3 = num;
				num = (short)1357617608;
				switch (num3 == num)
				{
				}
				num = (short)976355328;
				if (num != 0)
				{
				}
				num = (short)1883045889;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolNetworkID_A8565.Value;
			}
			set
			{
				short num = (short)1851129856;
				short num2 = num;
				num = (short)550057963;
				short num3 = num;
				num = (short)9844715;
				switch (num3 == num)
				{
				}
				num = (short)374734848;
				if (num != 0)
				{
				}
				num = (short)964165633;
				if (num != 0)
				{
				}
				this.trkSysLabtoolNetworkID_A8565.Value = value;
			}
		}

		// Token: 0x17000783 RID: 1923
		// (get) Token: 0x06000F48 RID: 3912 RVA: 0x000F3818 File Offset: 0x000F1A18
		public global::AcpBusinessLayer.AcpSimpleRangeField TrkSysLabtoolNetworkID_A8565
		{
			get
			{
				short num = (short)1349255168;
				short num2 = num;
				num = (short)1241458371;
				short num3 = num;
				num = (short)1133586115;
				switch (num3 == num)
				{
				}
				num = (short)907411457;
				if (num != 0)
				{
				}
				num = (short)95027200;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolNetworkID_A8565;
			}
		}

		// Token: 0x17000784 RID: 1924
		// (get) Token: 0x06000F49 RID: 3913 RVA: 0x000F38C8 File Offset: 0x000F1AC8
		// (set) Token: 0x06000F4A RID: 3914 RVA: 0x000F397C File Offset: 0x000F1B7C
		public string TrkSysLabtoolNetworkID_A8565_UIValue
		{
			get
			{
				short num = (short)1410007040;
				short num2 = num;
				num = (short)1604746018;
				short num3 = num;
				num = (short)2115271458;
				switch (num3 == num)
				{
				}
				num = (short)926482433;
				if (num != 0)
				{
				}
				num = (short)835321856;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolNetworkID_A8565.UIValue;
			}
			set
			{
				short num = (short)379060224;
				short num2 = num;
				num = (short)2127515697;
				short num3 = num;
				num = (short)125194289;
				switch (num3 == num)
				{
				}
				num = (short)1611857920;
				if (num != 0)
				{
				}
				num = (short)1025638401;
				if (num != 0)
				{
				}
				this.trkSysLabtoolNetworkID_A8565.UIValue = value;
			}
		}

		// Token: 0x17000785 RID: 1925
		// (get) Token: 0x06000F4B RID: 3915 RVA: 0x000F3A34 File Offset: 0x000F1C34
		// (set) Token: 0x06000F4C RID: 3916 RVA: 0x000F3AEC File Offset: 0x000F1CEC
		public string TrkSysLabtoolNetworkID_A8565_HexUIValue
		{
			get
			{
				short num = (short)1565917184;
				short num2 = num;
				num = (short)1747446000;
				short num3 = num;
				num = (short)1202120944;
				switch (num3 == num)
				{
				}
				num = (short)1360855041;
				if (num != 0)
				{
				}
				num = (short)544931840;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolNetworkID_A8565.HexUIValue;
			}
			set
			{
				short num = (short)1523974144;
				short num2 = num;
				num = (short)2095341263;
				short num3 = num;
				num = (short)1729715919;
				switch (num3 == num)
				{
				}
				num = (short)2082865153;
				if (num != 0)
				{
				}
				num = (short)194445312;
				if (num != 0)
				{
				}
				this.trkSysLabtoolNetworkID_A8565.HexUIValue = value;
			}
		}

		// Token: 0x17000786 RID: 1926
		// (get) Token: 0x06000F4D RID: 3917 RVA: 0x000F3BA0 File Offset: 0x000F1DA0
		// (set) Token: 0x06000F4E RID: 3918 RVA: 0x000F3C54 File Offset: 0x000F1E54
		internal int TrkSysLabtoolNetworkID_A8565Min
		{
			get
			{
				short num = (short)173342720;
				short num2 = num;
				num = (short)1409928099;
				short num3 = num;
				num = (short)1108528035;
				switch (num3 == num)
				{
				}
				num = (short)1717370881;
				if (num != 0)
				{
				}
				num = (short)273612800;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolNetworkID_A8565.Min;
			}
			set
			{
				short num = (short)705691648;
				short num2 = num;
				num = (short)190898626;
				short num3 = num;
				num = (short)1439687106;
				switch (num3 == num)
				{
				}
				num = (short)1229914113;
				if (num != 0)
				{
				}
				num = (short)2069692416;
				if (num != 0)
				{
				}
				this.trkSysLabtoolNetworkID_A8565.Min = value;
			}
		}

		// Token: 0x17000787 RID: 1927
		// (get) Token: 0x06000F4F RID: 3919 RVA: 0x000F3D08 File Offset: 0x000F1F08
		// (set) Token: 0x06000F50 RID: 3920 RVA: 0x000F3DBC File Offset: 0x000F1FBC
		internal int TrkSysLabtoolNetworkID_A8565Max
		{
			get
			{
				short num = (short)1792671744;
				short num2 = num;
				num = (short)1447825865;
				short num3 = num;
				num = (short)907088329;
				switch (num3 == num)
				{
				}
				num = (short)1889271809;
				if (num != 0)
				{
				}
				num = (short)338362368;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolNetworkID_A8565.Max;
			}
			set
			{
				short num = (short)1565851648;
				short num2 = num;
				num = (short)985404318;
				short num3 = num;
				num = (short)2105742238;
				switch (num3 == num)
				{
				}
				num = (short)1526792192;
				if (num != 0)
				{
				}
				num = (short)1542389761;
				if (num != 0)
				{
				}
				this.trkSysLabtoolNetworkID_A8565.Max = value;
			}
		}

		// Token: 0x17000788 RID: 1928
		// (get) Token: 0x06000F51 RID: 3921 RVA: 0x000F3E74 File Offset: 0x000F2074
		// (set) Token: 0x06000F52 RID: 3922 RVA: 0x000F3F28 File Offset: 0x000F2128
		internal int TrkSysLabtoolNetworkID_A8565Step
		{
			get
			{
				short num = (short)366673920;
				short num2 = num;
				num = (short)727680207;
				short num3 = num;
				num = (short)1434879183;
				switch (num3 == num)
				{
				}
				num = (short)1925775360;
				if (num != 0)
				{
				}
				num = (short)1716649985;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolNetworkID_A8565.StepSize;
			}
			set
			{
				short num = (short)582221824;
				short num2 = num;
				num = (short)1060235438;
				short num3 = num;
				num = (short)728885422;
				switch (num3 == num)
				{
				}
				num = (short)809172993;
				if (num != 0)
				{
				}
				num = (short)606863360;
				if (num != 0)
				{
				}
				this.trkSysLabtoolNetworkID_A8565.StepSize = value;
			}
		}

		// Token: 0x17000789 RID: 1929
		// (get) Token: 0x06000F53 RID: 3923 RVA: 0x000F3FDC File Offset: 0x000F21DC
		// (set) Token: 0x06000F54 RID: 3924 RVA: 0x000F4090 File Offset: 0x000F2290
		public bool TrkSysLabtoolNetworkID_A8565_Applicable
		{
			get
			{
				short num = (short)761856000;
				short num2 = num;
				num = (short)2140812665;
				short num3 = num;
				num = (short)1648178553;
				switch (num3 == num)
				{
				}
				num = (short)1636237313;
				if (num != 0)
				{
				}
				num = (short)1798504448;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolNetworkID_A8565.Applicable;
			}
			set
			{
				short num = (short)571473920;
				short num2 = num;
				num = (short)1020779222;
				short num3 = num;
				num = (short)735763158;
				switch (num3 == num)
				{
				}
				num = (short)1593376768;
				if (num != 0)
				{
				}
				num = (short)298844161;
				if (num != 0)
				{
				}
				this.trkSysLabtoolNetworkID_A8565.Applicable = value;
			}
		}

		// Token: 0x1700078A RID: 1930
		// (get) Token: 0x06000F55 RID: 3925 RVA: 0x000F4148 File Offset: 0x000F2348
		// (set) Token: 0x06000F56 RID: 3926 RVA: 0x000F41FC File Offset: 0x000F23FC
		public bool TrkSysLabtoolNetworkID_A8565_Valid
		{
			get
			{
				short num = (short)1304428544;
				short num2 = num;
				num = (short)86266936;
				short num3 = num;
				num = (short)1779651640;
				switch (num3 == num)
				{
				}
				num = (short)1144717313;
				if (num != 0)
				{
				}
				num = (short)1505951744;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolNetworkID_A8565.Valid;
			}
			set
			{
				short num = (short)527302656;
				short num2 = num;
				num = (short)425852929;
				if (num != 0)
				{
				}
				num = (short)1068591400;
				short num3 = num;
				num = (short)1706191144;
				switch (num3 == num)
				{
				}
				num = (short)1739325440;
				if (num != 0)
				{
				}
				this.trkSysLabtoolNetworkID_A8565.Valid = value;
			}
		}

		// Token: 0x1700078B RID: 1931
		// (get) Token: 0x06000F57 RID: 3927 RVA: 0x000F42B4 File Offset: 0x000F24B4
		// (set) Token: 0x06000F58 RID: 3928 RVA: 0x000F436C File Offset: 0x000F256C
		public bool TrkSysLabtoolNetworkID_A8565_Visible
		{
			get
			{
				short num = (short)69599232;
				short num2 = num;
				num = (short)726106597;
				short num3 = num;
				num = (short)1327792613;
				switch (num3 == num)
				{
				}
				num = (short)908853249;
				if (num != 0)
				{
				}
				num = (short)1454833664;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolNetworkID_A8565.Visible;
			}
			set
			{
				short num = (short)201523200;
				short num2 = num;
				num = (short)138323592;
				short num3 = num;
				num = (short)466069128;
				switch (num3 == num)
				{
				}
				num = (short)331153409;
				if (num != 0)
				{
				}
				num = (short)217055232;
				if (num != 0)
				{
				}
				this.trkSysLabtoolNetworkID_A8565.Visible = value;
			}
		}

		// Token: 0x1700078C RID: 1932
		// (get) Token: 0x06000F59 RID: 3929 RVA: 0x000F4420 File Offset: 0x000F2620
		// (set) Token: 0x06000F5A RID: 3930 RVA: 0x000F44D8 File Offset: 0x000F26D8
		public bool TrkSysLabtoolNetworkID_A8565_Editable
		{
			get
			{
				short num = (short)1853816832;
				short num2 = num;
				num = (short)2024079361;
				if (num != 0)
				{
				}
				num = (short)102690147;
				short num3 = num;
				num = (short)1952836963;
				switch (num3 == num)
				{
				}
				num = (short)1676673024;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolNetworkID_A8565.Editable;
			}
			set
			{
				short num = (short)311623680;
				short num2 = num;
				num = (short)1806576340;
				short num3 = num;
				num = (short)2099587796;
				switch (num3 == num)
				{
				}
				num = (short)1669988353;
				if (num != 0)
				{
				}
				num = (short)1274740736;
				if (num != 0)
				{
				}
				this.trkSysLabtoolNetworkID_A8565.Editable = value;
			}
		}

		// Token: 0x1700078D RID: 1933
		// (get) Token: 0x06000F5B RID: 3931 RVA: 0x000F458C File Offset: 0x000F278C
		internal string TrkSysLabtoolNetworkID_A8565_UILabel
		{
			get
			{
				short num = (short)1524760576;
				short num2 = num;
				num = (short)806551243;
				short num3 = num;
				num = (short)810417867;
				switch (num3 == num)
				{
				}
				num = (short)2128281601;
				if (num != 0)
				{
				}
				num = (short)1230962688;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolNetworkID_A8565.UIName;
			}
		}

		// Token: 0x1700078E RID: 1934
		// (get) Token: 0x06000F5C RID: 3932 RVA: 0x000F4640 File Offset: 0x000F2840
		// (set) Token: 0x06000F5D RID: 3933 RVA: 0x000F46F4 File Offset: 0x000F28F4
		internal bool TrkSysLabtoolNetworkID_A8565_HiddenStatic
		{
			get
			{
				short num = (short)894894080;
				short num2 = num;
				num = (short)1052952043;
				short num3 = num;
				num = (short)1026737643;
				switch (num3 == num)
				{
				}
				num = (short)524222465;
				if (num != 0)
				{
				}
				num = (short)2081030144;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolNetworkID_A8565.HiddenStatic;
			}
			set
			{
				short num = (short)1613627392;
				short num2 = num;
				num = (short)4205916;
				short num3 = num;
				num = (short)709832028;
				switch (num3 == num)
				{
				}
				num = (short)1929445377;
				if (num != 0)
				{
				}
				num = (short)1719795712;
				if (num != 0)
				{
				}
				this.trkSysLabtoolNetworkID_A8565.HiddenStatic = value;
			}
		}

		// Token: 0x1700078F RID: 1935
		// (get) Token: 0x06000F5E RID: 3934 RVA: 0x000F47AC File Offset: 0x000F29AC
		// (set) Token: 0x06000F5F RID: 3935 RVA: 0x000F4860 File Offset: 0x000F2A60
		internal bool TrkSysLabtoolNetworkID_A8565_HiddenDynamic
		{
			get
			{
				short num = (short)971964416;
				short num2 = num;
				num = (short)2121121978;
				short num3 = num;
				num = (short)1318174906;
				switch (num3 == num)
				{
				}
				num = (short)82051072;
				if (num != 0)
				{
				}
				num = (short)1189937153;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolNetworkID_A8565.HiddenDynamic;
			}
			set
			{
				short num = (short)1094189056;
				short num2 = num;
				num = (short)143785985;
				if (num != 0)
				{
				}
				num = (short)1876161368;
				short num3 = num;
				num = (short)2104619864;
				switch (num3 == num)
				{
				}
				num = (short)1219756032;
				if (num != 0)
				{
				}
				this.trkSysLabtoolNetworkID_A8565.HiddenDynamic = value;
			}
		}

		// Token: 0x17000790 RID: 1936
		// (get) Token: 0x06000F60 RID: 3936 RVA: 0x000F4918 File Offset: 0x000F2B18
		public bool TrkSysLabtoolNetworkID_A8565_HasDiffs
		{
			get
			{
				short num = (short)244056064;
				short num2 = num;
				num = (short)1129552964;
				short num3 = num;
				num = (short)33528900;
				switch (num3 == num)
				{
				}
				num = (short)1846149121;
				if (num != 0)
				{
				}
				num = (short)335806464;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolNetworkID_A8565._HasDiffs;
			}
		}

		// Token: 0x17000791 RID: 1937
		// (get) Token: 0x06000F61 RID: 3937 RVA: 0x000F49CC File Offset: 0x000F2BCC
		// (set) Token: 0x06000F62 RID: 3938 RVA: 0x000F4A80 File Offset: 0x000F2C80
		public bool TrkSysGeneralNonAdjacentSiteSearch_A8568Value
		{
			get
			{
				short num = (short)967376896;
				short num2 = num;
				num = (short)1831270295;
				short num3 = num;
				num = (short)1069610903;
				switch (num3 == num)
				{
				}
				num = (short)863174657;
				if (num != 0)
				{
				}
				num = (short)1484193792;
				if (num != 0)
				{
				}
				return this.trkSysGeneralNonAdjacentSiteSearch_A8568.Value;
			}
			set
			{
				short num = (short)272105472;
				short num2 = num;
				num = (short)1395963979;
				short num3 = num;
				num = (short)1466546251;
				switch (num3 == num)
				{
				}
				num = (short)2094006273;
				if (num != 0)
				{
				}
				num = (short)1236992000;
				if (num != 0)
				{
				}
				this.trkSysGeneralNonAdjacentSiteSearch_A8568.Value = value;
			}
		}

		// Token: 0x17000792 RID: 1938
		// (get) Token: 0x06000F63 RID: 3939 RVA: 0x000F4B34 File Offset: 0x000F2D34
		public global::AcpBusinessLayer.AcpField<bool> TrkSysGeneralNonAdjacentSiteSearch_A8568
		{
			get
			{
				short num = (short)268042240;
				short num2 = num;
				num = (short)345374721;
				if (num != 0)
				{
				}
				num = (short)1821872683;
				short num3 = num;
				num = (short)1271042603;
				switch (num3 == num)
				{
				}
				num = (short)448593920;
				if (num != 0)
				{
				}
				return this.trkSysGeneralNonAdjacentSiteSearch_A8568;
			}
		}

		// Token: 0x17000793 RID: 1939
		// (get) Token: 0x06000F64 RID: 3940 RVA: 0x000F4BE8 File Offset: 0x000F2DE8
		// (set) Token: 0x06000F65 RID: 3941 RVA: 0x000F4CA0 File Offset: 0x000F2EA0
		public bool TrkSysGeneralNonAdjacentSiteSearch_A8568_UIValue
		{
			get
			{
				short num = (short)1353056256;
				short num2 = num;
				num = (short)342630673;
				short num3 = num;
				num = (short)701047057;
				switch (num3 == num)
				{
				}
				num = (short)77791233;
				if (num != 0)
				{
				}
				num = (short)338886656;
				if (num != 0)
				{
				}
				return this.trkSysGeneralNonAdjacentSiteSearch_A8568.Value;
			}
			set
			{
				short num = (short)946274304;
				short num2 = num;
				num = (short)342360065;
				if (num != 0)
				{
				}
				num = (short)319944643;
				short num3 = num;
				num = (short)1901983683;
				switch (num3 == num)
				{
				}
				num = (short)493223936;
				if (num != 0)
				{
				}
				this.trkSysGeneralNonAdjacentSiteSearch_A8568.Value = value;
			}
		}

		// Token: 0x17000794 RID: 1940
		// (get) Token: 0x06000F66 RID: 3942 RVA: 0x000F4D54 File Offset: 0x000F2F54
		// (set) Token: 0x06000F67 RID: 3943 RVA: 0x000F4E08 File Offset: 0x000F3008
		public bool TrkSysGeneralNonAdjacentSiteSearch_A8568_Applicable
		{
			get
			{
				short num = (short)978452480;
				short num2 = num;
				num = (short)748342754;
				short num3 = num;
				num = (short)361156066;
				switch (num3 == num)
				{
				}
				num = (short)879230976;
				if (num != 0)
				{
				}
				num = (short)964755457;
				if (num != 0)
				{
				}
				return this.trkSysGeneralNonAdjacentSiteSearch_A8568.Applicable;
			}
			set
			{
				short num = (short)656605184;
				short num2 = num;
				num = (short)842989569;
				if (num != 0)
				{
				}
				num = (short)117156421;
				short num3 = num;
				num = (short)1784261189;
				switch (num3 == num)
				{
				}
				num = (short)1331757056;
				if (num != 0)
				{
				}
				this.trkSysGeneralNonAdjacentSiteSearch_A8568.Applicable = value;
			}
		}

		// Token: 0x17000795 RID: 1941
		// (get) Token: 0x06000F68 RID: 3944 RVA: 0x000F4EC0 File Offset: 0x000F30C0
		// (set) Token: 0x06000F69 RID: 3945 RVA: 0x000F4F78 File Offset: 0x000F3178
		public bool TrkSysGeneralNonAdjacentSiteSearch_A8568_Valid
		{
			get
			{
				short num = (short)273022976;
				short num2 = num;
				num = (short)835529894;
				short num3 = num;
				num = (short)648752294;
				switch (num3 == num)
				{
				}
				num = (short)456261632;
				if (num != 0)
				{
				}
				num = (short)1209008129;
				if (num != 0)
				{
				}
				return this.trkSysGeneralNonAdjacentSiteSearch_A8568.Valid;
			}
			set
			{
				short num = (short)875495424;
				short num2 = num;
				num = (short)2125928833;
				short num3 = num;
				num = (short)1379473793;
				switch (num3 == num)
				{
				}
				num = (short)2005925889;
				if (num != 0)
				{
				}
				num = (short)2085421056;
				if (num != 0)
				{
				}
				this.trkSysGeneralNonAdjacentSiteSearch_A8568.Valid = value;
			}
		}

		// Token: 0x17000796 RID: 1942
		// (get) Token: 0x06000F6A RID: 3946 RVA: 0x000F502C File Offset: 0x000F322C
		// (set) Token: 0x06000F6B RID: 3947 RVA: 0x000F50E0 File Offset: 0x000F32E0
		public bool TrkSysGeneralNonAdjacentSiteSearch_A8568_Visible
		{
			get
			{
				short num = (short)277413888;
				short num2 = num;
				num = (short)1226800192;
				short num3 = num;
				num = (short)2030009408;
				switch (num3 == num)
				{
				}
				num = (short)127533057;
				if (num != 0)
				{
				}
				num = (short)1898971136;
				if (num != 0)
				{
				}
				return this.trkSysGeneralNonAdjacentSiteSearch_A8568.Visible;
			}
			set
			{
				short num = (short)1027932160;
				short num2 = num;
				num = (short)1766657944;
				short num3 = num;
				num = (short)582225816;
				switch (num3 == num)
				{
				}
				num = (short)629276672;
				if (num != 0)
				{
				}
				num = (short)58130433;
				if (num != 0)
				{
				}
				this.trkSysGeneralNonAdjacentSiteSearch_A8568.Visible = value;
			}
		}

		// Token: 0x17000797 RID: 1943
		// (get) Token: 0x06000F6C RID: 3948 RVA: 0x000F5198 File Offset: 0x000F3398
		// (set) Token: 0x06000F6D RID: 3949 RVA: 0x000F524C File Offset: 0x000F344C
		public bool TrkSysGeneralNonAdjacentSiteSearch_A8568_Editable
		{
			get
			{
				short num = (short)1049427968;
				short num2 = num;
				num = (short)1705639937;
				if (num != 0)
				{
				}
				num = (short)1476366790;
				short num3 = num;
				num = (short)435655110;
				switch (num3 == num)
				{
				}
				num = (short)290914304;
				if (num != 0)
				{
				}
				return this.trkSysGeneralNonAdjacentSiteSearch_A8568.Editable;
			}
			set
			{
				short num = (short)1462960128;
				short num2 = num;
				num = (short)1911687018;
				short num3 = num;
				num = (short)1704331114;
				switch (num3 == num)
				{
				}
				num = (short)1388118016;
				if (num != 0)
				{
				}
				num = (short)2041577473;
				if (num != 0)
				{
				}
				this.trkSysGeneralNonAdjacentSiteSearch_A8568.Editable = value;
			}
		}

		// Token: 0x17000798 RID: 1944
		// (get) Token: 0x06000F6E RID: 3950 RVA: 0x000F5304 File Offset: 0x000F3504
		internal string TrkSysGeneralNonAdjacentSiteSearch_A8568_UILabel
		{
			get
			{
				short num = (short)654180352;
				short num2 = num;
				num = (short)1025838802;
				short num3 = num;
				num = (short)924258002;
				switch (num3 == num)
				{
				}
				num = (short)304939009;
				if (num != 0)
				{
				}
				num = (short)1938882560;
				if (num != 0)
				{
				}
				return this.trkSysGeneralNonAdjacentSiteSearch_A8568.UIName;
			}
		}

		// Token: 0x17000799 RID: 1945
		// (get) Token: 0x06000F6F RID: 3951 RVA: 0x000F53B8 File Offset: 0x000F35B8
		// (set) Token: 0x06000F70 RID: 3952 RVA: 0x000F5470 File Offset: 0x000F3670
		internal bool TrkSysGeneralNonAdjacentSiteSearch_A8568_HiddenStatic
		{
			get
			{
				short num = (short)1722613760;
				short num2 = num;
				num = (short)300103254;
				short num3 = num;
				num = (short)984823382;
				switch (num3 == num)
				{
				}
				num = (short)269746177;
				if (num != 0)
				{
				}
				num = (short)1136525312;
				if (num != 0)
				{
				}
				return this.trkSysGeneralNonAdjacentSiteSearch_A8568.HiddenStatic;
			}
			set
			{
				short num = (short)1465188352;
				short num2 = num;
				num = (short)1360920577;
				if (num != 0)
				{
				}
				num = (short)2098381937;
				short num3 = num;
				num = (short)1677509745;
				switch (num3 == num)
				{
				}
				num = (short)1747714048;
				if (num != 0)
				{
				}
				this.trkSysGeneralNonAdjacentSiteSearch_A8568.HiddenStatic = value;
			}
		}

		// Token: 0x1700079A RID: 1946
		// (get) Token: 0x06000F71 RID: 3953 RVA: 0x000F5524 File Offset: 0x000F3724
		// (set) Token: 0x06000F72 RID: 3954 RVA: 0x000F55D8 File Offset: 0x000F37D8
		internal bool TrkSysGeneralNonAdjacentSiteSearch_A8568_HiddenDynamic
		{
			get
			{
				short num = (short)1968308224;
				short num2 = num;
				num = (short)1560982376;
				short num3 = num;
				num = (short)1427944296;
				switch (num3 == num)
				{
				}
				num = (short)2013134848;
				if (num != 0)
				{
				}
				num = (short)1722875905;
				if (num != 0)
				{
				}
				return this.trkSysGeneralNonAdjacentSiteSearch_A8568.HiddenDynamic;
			}
			set
			{
				short num = (short)660144128;
				short num2 = num;
				num = (short)1628637872;
				short num3 = num;
				num = (short)1066863280;
				switch (num3 == num)
				{
				}
				num = (short)1156055040;
				if (num != 0)
				{
				}
				num = (short)1936982017;
				if (num != 0)
				{
				}
				this.trkSysGeneralNonAdjacentSiteSearch_A8568.HiddenDynamic = value;
			}
		}

		// Token: 0x1700079B RID: 1947
		// (get) Token: 0x06000F73 RID: 3955 RVA: 0x000F568C File Offset: 0x000F388C
		public bool TrkSysGeneralNonAdjacentSiteSearch_A8568_HasDiffs
		{
			get
			{
				short num = (short)2133327872;
				short num2 = num;
				num = (short)1147149438;
				short num3 = num;
				num = (short)1172249726;
				switch (num3 == num)
				{
				}
				num = (short)2085879809;
				if (num != 0)
				{
				}
				num = (short)1133969408;
				if (num != 0)
				{
				}
				return this.trkSysGeneralNonAdjacentSiteSearch_A8568._HasDiffs;
			}
		}

		// Token: 0x1700079C RID: 1948
		// (get) Token: 0x06000F74 RID: 3956 RVA: 0x000F5740 File Offset: 0x000F3940
		// (set) Token: 0x06000F75 RID: 3957 RVA: 0x000F57F8 File Offset: 0x000F39F8
		public int TrkSysGeneralRFSSID_A8980Value
		{
			get
			{
				short num = (short)166002688;
				short num2 = num;
				num = (short)131989505;
				if (num != 0)
				{
				}
				num = (short)1893107746;
				short num3 = num;
				num = (short)992380962;
				switch (num3 == num)
				{
				}
				num = (short)1433206784;
				if (num != 0)
				{
				}
				return this.trkSysGeneralRFSSID_A8980.Value;
			}
			set
			{
				short num = (short)1203044352;
				short num2 = num;
				num = (short)1079909162;
				short num3 = num;
				num = (short)478878506;
				switch (num3 == num)
				{
				}
				num = (short)719585281;
				if (num != 0)
				{
				}
				num = (short)1733033984;
				if (num != 0)
				{
				}
				this.trkSysGeneralRFSSID_A8980.Value = value;
			}
		}

		// Token: 0x1700079D RID: 1949
		// (get) Token: 0x06000F76 RID: 3958 RVA: 0x000F58B4 File Offset: 0x000F3AB4
		public global::AcpBusinessLayer.AcpSimpleRangeField TrkSysGeneralRFSSID_A8980
		{
			get
			{
				short num = (short)2002329124;
				short num2 = num;
				num = (short)744955428;
				switch (num2 == num)
				{
				}
				num = (short)2010972161;
				if (num != 0)
				{
				}
				num = (short)1447886848;
				short num3 = num;
				num = (short)1431633920;
				if (num != 0)
				{
				}
				return this.trkSysGeneralRFSSID_A8980;
			}
		}

		// Token: 0x1700079E RID: 1950
		// (get) Token: 0x06000F77 RID: 3959 RVA: 0x000F5960 File Offset: 0x000F3B60
		// (set) Token: 0x06000F78 RID: 3960 RVA: 0x000F5A18 File Offset: 0x000F3C18
		public string TrkSysGeneralRFSSID_A8980_UIValue
		{
			get
			{
				short num = (short)1000119797;
				short num2 = num;
				num = (short)509320693;
				switch (num2 == num)
				{
				}
				num = (short)1682505729;
				if (num != 0)
				{
				}
				num = (short)1105330176;
				short num3 = num;
				num = (short)839385088;
				if (num != 0)
				{
				}
				return this.trkSysGeneralRFSSID_A8980.UIValue;
			}
			set
			{
				short num = (short)440297751;
				short num2 = num;
				num = (short)1256483095;
				switch (num2 == num)
				{
				}
				num = (short)1286864896;
				if (num != 0)
				{
				}
				num = (short)300351488;
				short num3 = num;
				num = (short)1103101953;
				if (num != 0)
				{
				}
				this.trkSysGeneralRFSSID_A8980.UIValue = value;
			}
		}

		// Token: 0x1700079F RID: 1951
		// (get) Token: 0x06000F79 RID: 3961 RVA: 0x000F5ACC File Offset: 0x000F3CCC
		// (set) Token: 0x06000F7A RID: 3962 RVA: 0x000F5B80 File Offset: 0x000F3D80
		public string TrkSysGeneralRFSSID_A8980_HexUIValue
		{
			get
			{
				short num = (short)1768384539;
				short num2 = num;
				num = (short)1644455963;
				switch (num2 == num)
				{
				}
				num = (short)1835204609;
				if (num != 0)
				{
				}
				num = (short)563740672;
				short num3 = num;
				num = (short)516816896;
				if (num != 0)
				{
				}
				return this.trkSysGeneralRFSSID_A8980.HexUIValue;
			}
			set
			{
				short num = (short)345812173;
				short num2 = num;
				num = (short)302296269;
				switch (num2 == num)
				{
				}
				num = (short)2000879617;
				if (num != 0)
				{
				}
				num = (short)1625489408;
				short num3 = num;
				num = (short)1512439808;
				if (num != 0)
				{
				}
				this.trkSysGeneralRFSSID_A8980.HexUIValue = value;
			}
		}

		// Token: 0x170007A0 RID: 1952
		// (get) Token: 0x06000F7B RID: 3963 RVA: 0x000F5C34 File Offset: 0x000F3E34
		// (set) Token: 0x06000F7C RID: 3964 RVA: 0x000F5CE8 File Offset: 0x000F3EE8
		internal int TrkSysGeneralRFSSID_A8980Min
		{
			get
			{
				short num = (short)756457309;
				short num2 = num;
				num = (short)1269145437;
				switch (num2 == num)
				{
				}
				num = (short)1990656000;
				if (num != 0)
				{
				}
				num = (short)173473792;
				short num3 = num;
				num = (short)1355022337;
				if (num != 0)
				{
				}
				return this.trkSysGeneralRFSSID_A8980.Min;
			}
			set
			{
				short num = (short)257712271;
				short num2 = num;
				num = (short)2091737231;
				switch (num2 == num)
				{
				}
				num = (short)1834418176;
				if (num != 0)
				{
				}
				num = (short)685768704;
				short num3 = num;
				num = (short)527171585;
				if (num != 0)
				{
				}
				this.trkSysGeneralRFSSID_A8980.Min = value;
			}
		}

		// Token: 0x170007A1 RID: 1953
		// (get) Token: 0x06000F7D RID: 3965 RVA: 0x000F5D9C File Offset: 0x000F3F9C
		// (set) Token: 0x06000F7E RID: 3966 RVA: 0x000F5E54 File Offset: 0x000F4054
		internal int TrkSysGeneralRFSSID_A8980Max
		{
			get
			{
				short num = (short)451149825;
				if (num != 0)
				{
				}
				num = (short)218209020;
				short num2 = num;
				num = (short)1033739004;
				switch (num2 == num)
				{
				}
				num = (short)970981376;
				short num3 = num;
				num = (short)2136276992;
				if (num != 0)
				{
				}
				return this.trkSysGeneralRFSSID_A8980.Max;
			}
			set
			{
				short num = (short)1846899199;
				short num2 = num;
				num = (short)762737151;
				switch (num2 == num)
				{
				}
				num = (short)598081537;
				if (num != 0)
				{
				}
				num = (short)1448411136;
				short num3 = num;
				num = (short)387186688;
				if (num != 0)
				{
				}
				this.trkSysGeneralRFSSID_A8980.Max = value;
			}
		}

		// Token: 0x170007A2 RID: 1954
		// (get) Token: 0x06000F7F RID: 3967 RVA: 0x000F5F08 File Offset: 0x000F4108
		// (set) Token: 0x06000F80 RID: 3968 RVA: 0x000F5FBC File Offset: 0x000F41BC
		internal int TrkSysGeneralRFSSID_A8980Step
		{
			get
			{
				short num = (short)430242151;
				short num2 = num;
				num = (short)426506599;
				switch (num2 == num)
				{
				}
				num = (short)1991311360;
				if (num != 0)
				{
				}
				num = (short)183369728;
				short num3 = num;
				num = (short)1552220161;
				if (num != 0)
				{
				}
				return this.trkSysGeneralRFSSID_A8980.StepSize;
			}
			set
			{
				short num = (short)423803496;
				short num2 = num;
				num = (short)503888488;
				switch (num2 == num)
				{
				}
				num = (short)622723073;
				if (num != 0)
				{
				}
				num = (short)1748697088;
				short num3 = num;
				num = (short)908263424;
				if (num != 0)
				{
				}
				this.trkSysGeneralRFSSID_A8980.StepSize = value;
			}
		}

		// Token: 0x170007A3 RID: 1955
		// (get) Token: 0x06000F81 RID: 3969 RVA: 0x000F6070 File Offset: 0x000F4270
		// (set) Token: 0x06000F82 RID: 3970 RVA: 0x000F6124 File Offset: 0x000F4324
		public bool TrkSysGeneralRFSSID_A8980_Applicable
		{
			get
			{
				short num = (short)2124307672;
				short num2 = num;
				num = (short)1671847128;
				switch (num2 == num)
				{
				}
				num = (short)132710400;
				if (num != 0)
				{
				}
				num = (short)413270016;
				short num3 = num;
				num = (short)1508835329;
				if (num != 0)
				{
				}
				return this.trkSysGeneralRFSSID_A8980.Applicable;
			}
			set
			{
				short num = (short)387861676;
				short num2 = num;
				num = (short)1518029996;
				switch (num2 == num)
				{
				}
				num = (short)131530753;
				if (num != 0)
				{
				}
				num = (short)276955136;
				short num3 = num;
				num = (short)2076246016;
				if (num != 0)
				{
				}
				this.trkSysGeneralRFSSID_A8980.Applicable = value;
			}
		}

		// Token: 0x170007A4 RID: 1956
		// (get) Token: 0x06000F83 RID: 3971 RVA: 0x000F61DC File Offset: 0x000F43DC
		// (set) Token: 0x06000F84 RID: 3972 RVA: 0x000F6294 File Offset: 0x000F4494
		public bool TrkSysGeneralRFSSID_A8980_Valid
		{
			get
			{
				short num = (short)77162296;
				short num2 = num;
				num = (short)1700882232;
				switch (num2 == num)
				{
				}
				num = (short)1203503104;
				if (num != 0)
				{
				}
				num = (short)1246494720;
				short num3 = num;
				num = (short)893452289;
				if (num != 0)
				{
				}
				return this.trkSysGeneralRFSSID_A8980.Valid;
			}
			set
			{
				short num = (short)670700376;
				short num2 = num;
				num = (short)224793432;
				switch (num2 == num)
				{
				}
				num = (short)707788801;
				if (num != 0)
				{
				}
				num = (short)470089728;
				short num3 = num;
				num = (short)242679808;
				if (num != 0)
				{
				}
				this.trkSysGeneralRFSSID_A8980.Valid = value;
			}
		}

		// Token: 0x170007A5 RID: 1957
		// (get) Token: 0x06000F85 RID: 3973 RVA: 0x000F634C File Offset: 0x000F454C
		// (set) Token: 0x06000F86 RID: 3974 RVA: 0x000F6400 File Offset: 0x000F4600
		public bool TrkSysGeneralRFSSID_A8980_Visible
		{
			get
			{
				short num = (short)612192150;
				short num2 = num;
				num = (short)342183830;
				switch (num2 == num)
				{
				}
				num = (short)1484193793;
				if (num != 0)
				{
				}
				num = (short)1571487744;
				short num3 = num;
				num = (short)514129920;
				if (num != 0)
				{
				}
				return this.trkSysGeneralRFSSID_A8980.Visible;
			}
			set
			{
				short num = (short)1194193079;
				short num2 = num;
				num = (short)297070775;
				switch (num2 == num)
				{
				}
				num = (short)1337065472;
				if (num != 0)
				{
				}
				num = (short)1547304960;
				short num3 = num;
				num = (short)1117454337;
				if (num != 0)
				{
				}
				this.trkSysGeneralRFSSID_A8980.Visible = value;
			}
		}

		// Token: 0x170007A6 RID: 1958
		// (get) Token: 0x06000F87 RID: 3975 RVA: 0x000F64B4 File Offset: 0x000F46B4
		// (set) Token: 0x06000F88 RID: 3976 RVA: 0x000F6568 File Offset: 0x000F4768
		public bool TrkSysGeneralRFSSID_A8980_Editable
		{
			get
			{
				short num = (short)1114840027;
				short num2 = num;
				num = (short)812653531;
				switch (num2 == num)
				{
				}
				num = (short)583663616;
				if (num != 0)
				{
				}
				num = (short)1696071680;
				short num3 = num;
				num = (short)884932609;
				if (num != 0)
				{
				}
				return this.trkSysGeneralRFSSID_A8980.Editable;
			}
			set
			{
				short num = (short)1194786817;
				if (num != 0)
				{
				}
				num = (short)560248557;
				short num2 = num;
				num = (short)1720170221;
				switch (num2 == num)
				{
				}
				num = (short)1640824832;
				short num3 = num;
				num = (short)363593728;
				if (num != 0)
				{
				}
				this.trkSysGeneralRFSSID_A8980.Editable = value;
			}
		}

		// Token: 0x170007A7 RID: 1959
		// (get) Token: 0x06000F89 RID: 3977 RVA: 0x000F661C File Offset: 0x000F481C
		internal string TrkSysGeneralRFSSID_A8980_UILabel
		{
			get
			{
				short num = (short)91700840;
				short num2 = num;
				num = (short)378355304;
				switch (num2 == num)
				{
				}
				num = (short)654901249;
				if (num != 0)
				{
				}
				num = (short)942407680;
				short num3 = num;
				num = (short)848822272;
				if (num != 0)
				{
				}
				return this.trkSysGeneralRFSSID_A8980.UIName;
			}
		}

		// Token: 0x170007A8 RID: 1960
		// (get) Token: 0x06000F8A RID: 3978 RVA: 0x000F66D0 File Offset: 0x000F48D0
		// (set) Token: 0x06000F8B RID: 3979 RVA: 0x000F6784 File Offset: 0x000F4984
		internal bool TrkSysGeneralRFSSID_A8980_HiddenStatic
		{
			get
			{
				short num = (short)1817250003;
				short num2 = num;
				num = (short)2013530323;
				switch (num2 == num)
				{
				}
				num = (short)186580993;
				if (num != 0)
				{
				}
				num = (short)919273472;
				short num3 = num;
				num = (short)670629888;
				if (num != 0)
				{
				}
				return this.trkSysGeneralRFSSID_A8980.HiddenStatic;
			}
			set
			{
				short num = (short)987939157;
				short num2 = num;
				num = (short)1555546453;
				switch (num2 == num)
				{
				}
				num = (short)1869152256;
				if (num != 0)
				{
				}
				num = (short)965541888;
				short num3 = num;
				num = (short)1863516161;
				if (num != 0)
				{
				}
				this.trkSysGeneralRFSSID_A8980.HiddenStatic = value;
			}
		}

		// Token: 0x170007A9 RID: 1961
		// (get) Token: 0x06000F8C RID: 3980 RVA: 0x000F683C File Offset: 0x000F4A3C
		// (set) Token: 0x06000F8D RID: 3981 RVA: 0x000F68F0 File Offset: 0x000F4AF0
		internal bool TrkSysGeneralRFSSID_A8980_HiddenDynamic
		{
			get
			{
				short num = (short)1968439297;
				if (num != 0)
				{
				}
				num = (short)1202116599;
				short num2 = num;
				num = (short)1309661175;
				switch (num2 == num)
				{
				}
				num = (short)1066598400;
				short num3 = num;
				num = (short)604438528;
				if (num != 0)
				{
				}
				return this.trkSysGeneralRFSSID_A8980.HiddenDynamic;
			}
			set
			{
				short num = (short)361978255;
				short num2 = num;
				num = (short)345397647;
				switch (num2 == num)
				{
				}
				num = (short)1166409729;
				if (num != 0)
				{
				}
				num = (short)487260160;
				short num3 = num;
				num = (short)1689452544;
				if (num != 0)
				{
				}
				this.trkSysGeneralRFSSID_A8980.HiddenDynamic = value;
			}
		}

		// Token: 0x170007AA RID: 1962
		// (get) Token: 0x06000F8E RID: 3982 RVA: 0x000F69A4 File Offset: 0x000F4BA4
		public bool TrkSysGeneralRFSSID_A8980_HasDiffs
		{
			get
			{
				short num = (short)2034167839;
				short num2 = num;
				num = (short)1276440607;
				switch (num2 == num)
				{
				}
				num = (short)55705601;
				if (num != 0)
				{
				}
				num = (short)1751384064;
				short num3 = num;
				num = (short)880345088;
				if (num != 0)
				{
				}
				return this.trkSysGeneralRFSSID_A8980._HasDiffs;
			}
		}

		// Token: 0x170007AB RID: 1963
		// (get) Token: 0x06000F8F RID: 3983 RVA: 0x000F6A58 File Offset: 0x000F4C58
		// (set) Token: 0x06000F90 RID: 3984 RVA: 0x000F6B0C File Offset: 0x000F4D0C
		public int TrkSysGeneralSiteID_A9150Value
		{
			get
			{
				short num = (short)1994432286;
				short num2 = num;
				num = (short)2113642270;
				switch (num2 == num)
				{
				}
				num = (short)1219559424;
				if (num != 0)
				{
				}
				num = (short)1327955968;
				short num3 = num;
				num = (short)408682497;
				if (num != 0)
				{
				}
				return this.trkSysGeneralSiteID_A9150.Value;
			}
			set
			{
				short num = (short)1893588625;
				short num2 = num;
				num = (short)2021056145;
				switch (num2 == num)
				{
				}
				num = (short)525598720;
				if (num != 0)
				{
				}
				num = (short)985595904;
				short num3 = num;
				num = (short)1629552641;
				if (num != 0)
				{
				}
				this.trkSysGeneralSiteID_A9150.Value = value;
			}
		}

		// Token: 0x170007AC RID: 1964
		// (get) Token: 0x06000F91 RID: 3985 RVA: 0x000F6BC4 File Offset: 0x000F4DC4
		public global::AcpBusinessLayer.AcpSimpleRangeField TrkSysGeneralSiteID_A9150
		{
			get
			{
				short num = (short)856093821;
				short num2 = num;
				num = (short)1505293437;
				switch (num2 == num)
				{
				}
				num = (short)1245249536;
				if (num != 0)
				{
				}
				num = (short)512622592;
				short num3 = num;
				num = (short)2078146561;
				if (num != 0)
				{
				}
				return this.trkSysGeneralSiteID_A9150;
			}
		}

		// Token: 0x170007AD RID: 1965
		// (get) Token: 0x06000F92 RID: 3986 RVA: 0x000F6C74 File Offset: 0x000F4E74
		// (set) Token: 0x06000F93 RID: 3987 RVA: 0x000F6D28 File Offset: 0x000F4F28
		public string TrkSysGeneralSiteID_A9150_UIValue
		{
			get
			{
				short num = (short)2049194586;
				short num2 = num;
				num = (short)1810905690;
				switch (num2 == num)
				{
				}
				num = (short)1809383425;
				if (num != 0)
				{
				}
				num = (short)140312576;
				short num3 = num;
				num = (short)294649856;
				if (num != 0)
				{
				}
				return this.trkSysGeneralSiteID_A9150.UIValue;
			}
			set
			{
				short num = (short)280629891;
				short num2 = num;
				num = (short)1661866627;
				switch (num2 == num)
				{
				}
				num = (short)778829825;
				if (num != 0)
				{
				}
				num = (short)1962147840;
				short num3 = num;
				num = (short)820379648;
				if (num != 0)
				{
				}
				this.trkSysGeneralSiteID_A9150.UIValue = value;
			}
		}

		// Token: 0x170007AE RID: 1966
		// (get) Token: 0x06000F94 RID: 3988 RVA: 0x000F6DE0 File Offset: 0x000F4FE0
		// (set) Token: 0x06000F95 RID: 3989 RVA: 0x000F6E98 File Offset: 0x000F5098
		public string TrkSysGeneralSiteID_A9150_HexUIValue
		{
			get
			{
				short num = (short)864494252;
				short num2 = num;
				num = (short)386998956;
				switch (num2 == num)
				{
				}
				num = (short)378863617;
				if (num != 0)
				{
				}
				num = (short)2121269248;
				short num3 = num;
				num = (short)572522496;
				if (num != 0)
				{
				}
				return this.trkSysGeneralSiteID_A9150.HexUIValue;
			}
			set
			{
				short num = (short)1754440763;
				short num2 = num;
				num = (short)699638843;
				switch (num2 == num)
				{
				}
				num = (short)1260191745;
				if (num != 0)
				{
				}
				num = (short)147587072;
				short num3 = num;
				num = (short)322895872;
				if (num != 0)
				{
				}
				this.trkSysGeneralSiteID_A9150.HexUIValue = value;
			}
		}

		// Token: 0x170007AF RID: 1967
		// (get) Token: 0x06000F96 RID: 3990 RVA: 0x000F6F4C File Offset: 0x000F514C
		// (set) Token: 0x06000F97 RID: 3991 RVA: 0x000F6FFC File Offset: 0x000F51FC
		internal int TrkSysGeneralSiteID_A9150Min
		{
			get
			{
				short num = (short)604241921;
				if (num != 0)
				{
				}
				num = (short)784689974;
				short num2 = num;
				num = (short)642018102;
				switch (num2 == num)
				{
				}
				num = (short)2069430272;
				short num3 = num;
				num = (short)175308800;
				if (num != 0)
				{
				}
				return this.trkSysGeneralSiteID_A9150.Min;
			}
			set
			{
				short num = (short)975798553;
				short num2 = num;
				num = (short)562397465;
				switch (num2 == num)
				{
				}
				num = (short)2040397824;
				if (num != 0)
				{
				}
				num = (short)649592832;
				short num3 = num;
				num = (short)282853377;
				if (num != 0)
				{
				}
				this.trkSysGeneralSiteID_A9150.Min = value;
			}
		}

		// Token: 0x170007B0 RID: 1968
		// (get) Token: 0x06000F98 RID: 3992 RVA: 0x000F70B0 File Offset: 0x000F52B0
		// (set) Token: 0x06000F99 RID: 3993 RVA: 0x000F7164 File Offset: 0x000F5364
		internal int TrkSysGeneralSiteID_A9150Max
		{
			get
			{
				short num = (short)666950003;
				short num2 = num;
				num = (short)1654839667;
				switch (num2 == num)
				{
				}
				num = (short)940572672;
				if (num != 0)
				{
				}
				num = (short)926875648;
				short num3 = num;
				num = (short)1079705601;
				if (num != 0)
				{
				}
				return this.trkSysGeneralSiteID_A9150.Max;
			}
			set
			{
				short num = (short)1050614358;
				short num2 = num;
				num = (short)1644567126;
				switch (num2 == num)
				{
				}
				num = (short)1562902529;
				if (num != 0)
				{
				}
				num = (short)223543296;
				short num3 = num;
				num = (short)2142568448;
				if (num != 0)
				{
				}
				this.trkSysGeneralSiteID_A9150.Max = value;
			}
		}

		// Token: 0x170007B1 RID: 1969
		// (get) Token: 0x06000F9A RID: 3994 RVA: 0x000F721C File Offset: 0x000F541C
		// (set) Token: 0x06000F9B RID: 3995 RVA: 0x000F72D4 File Offset: 0x000F54D4
		internal int TrkSysGeneralSiteID_A9150Step
		{
			get
			{
				short num = (short)1831403521;
				if (num != 0)
				{
				}
				num = (short)1738156308;
				short num2 = num;
				num = (short)305539348;
				switch (num2 == num)
				{
				}
				num = (short)1953169408;
				short num3 = num;
				num = (short)1196949504;
				if (num != 0)
				{
				}
				return this.trkSysGeneralSiteID_A9150.StepSize;
			}
			set
			{
				short num = (short)1145288950;
				short num2 = num;
				num = (short)52476150;
				switch (num2 == num)
				{
				}
				num = (short)1060962305;
				if (num != 0)
				{
				}
				num = (short)596705280;
				short num3 = num;
				num = (short)1607467008;
				if (num != 0)
				{
				}
				this.trkSysGeneralSiteID_A9150.StepSize = value;
			}
		}

		// Token: 0x170007B2 RID: 1970
		// (get) Token: 0x06000F9C RID: 3996 RVA: 0x000F7388 File Offset: 0x000F5588
		// (set) Token: 0x06000F9D RID: 3997 RVA: 0x000F743C File Offset: 0x000F563C
		public bool TrkSysGeneralSiteID_A9150_Applicable
		{
			get
			{
				short num = (short)500779766;
				short num2 = num;
				num = (short)1562331894;
				switch (num2 == num)
				{
				}
				num = (short)1783824385;
				if (num != 0)
				{
				}
				num = (short)784072704;
				short num3 = num;
				num = (short)440729600;
				if (num != 0)
				{
				}
				return this.trkSysGeneralSiteID_A9150.Applicable;
			}
			set
			{
				short num = (short)1317154436;
				short num2 = num;
				num = (short)1279995524;
				switch (num2 == num)
				{
				}
				num = (short)1762328576;
				if (num != 0)
				{
				}
				num = (short)1058668544;
				short num3 = num;
				num = (short)752353281;
				if (num != 0)
				{
				}
				this.trkSysGeneralSiteID_A9150.Applicable = value;
			}
		}

		// Token: 0x170007B3 RID: 1971
		// (get) Token: 0x06000F9E RID: 3998 RVA: 0x000F74F0 File Offset: 0x000F56F0
		// (set) Token: 0x06000F9F RID: 3999 RVA: 0x000F75A8 File Offset: 0x000F57A8
		public bool TrkSysGeneralSiteID_A9150_Valid
		{
			get
			{
				short num = (short)434372609;
				if (num != 0)
				{
				}
				num = (short)1330465205;
				short num2 = num;
				num = (short)1125730741;
				switch (num2 == num)
				{
				}
				num = (short)1822359552;
				short num3 = num;
				num = (short)98697216;
				if (num != 0)
				{
				}
				return this.trkSysGeneralSiteID_A9150.Valid;
			}
			set
			{
				short num = (short)951620009;
				short num2 = num;
				num = (short)1679266217;
				switch (num2 == num)
				{
				}
				num = (short)944832512;
				if (num != 0)
				{
				}
				num = (short)484769792;
				short num3 = num;
				num = (short)1040711681;
				if (num != 0)
				{
				}
				this.trkSysGeneralSiteID_A9150.Valid = value;
			}
		}

		// Token: 0x170007B4 RID: 1972
		// (get) Token: 0x06000FA0 RID: 4000 RVA: 0x000F7660 File Offset: 0x000F5860
		// (set) Token: 0x06000FA1 RID: 4001 RVA: 0x000F7714 File Offset: 0x000F5914
		public bool TrkSysGeneralSiteID_A9150_Visible
		{
			get
			{
				short num = (short)919644033;
				short num2 = num;
				num = (short)1053730689;
				switch (num2 == num)
				{
				}
				num = (short)10813441;
				if (num != 0)
				{
				}
				num = (short)1859321856;
				short num3 = num;
				num = (short)1926037504;
				if (num != 0)
				{
				}
				return this.trkSysGeneralSiteID_A9150.Visible;
			}
			set
			{
				short num = (short)1821999833;
				short num2 = num;
				num = (short)1548255961;
				switch (num2 == num)
				{
				}
				num = (short)1675427841;
				if (num != 0)
				{
				}
				num = (short)1957232640;
				short num3 = num;
				num = (short)1469186048;
				if (num != 0)
				{
				}
				this.trkSysGeneralSiteID_A9150.Visible = value;
			}
		}

		// Token: 0x170007B5 RID: 1973
		// (get) Token: 0x06000FA2 RID: 4002 RVA: 0x000F77C8 File Offset: 0x000F59C8
		// (set) Token: 0x06000FA3 RID: 4003 RVA: 0x000F787C File Offset: 0x000F5A7C
		public bool TrkSysGeneralSiteID_A9150_Editable
		{
			get
			{
				short num = (short)2028295472;
				short num2 = num;
				num = (short)599217456;
				switch (num2 == num)
				{
				}
				num = (short)102432769;
				if (num != 0)
				{
				}
				num = (short)116588544;
				short num3 = num;
				num = (short)1223294976;
				if (num != 0)
				{
				}
				return this.trkSysGeneralSiteID_A9150.Editable;
			}
			set
			{
				short num = (short)989279470;
				short num2 = num;
				num = (short)996422894;
				switch (num2 == num)
				{
				}
				num = (short)984940545;
				if (num != 0)
				{
				}
				num = (short)1348075520;
				short num3 = num;
				num = (short)1989672960;
				if (num != 0)
				{
				}
				this.trkSysGeneralSiteID_A9150.Editable = value;
			}
		}

		// Token: 0x170007B6 RID: 1974
		// (get) Token: 0x06000FA4 RID: 4004 RVA: 0x000F7934 File Offset: 0x000F5B34
		internal string TrkSysGeneralSiteID_A9150_UILabel
		{
			get
			{
				short num = (short)1364376254;
				short num2 = num;
				num = (short)580369086;
				switch (num2 == num)
				{
				}
				num = (short)1223294977;
				if (num != 0)
				{
				}
				num = (short)620298240;
				short num3 = num;
				num = (short)87818240;
				if (num != 0)
				{
				}
				return this.trkSysGeneralSiteID_A9150.UIName;
			}
		}

		// Token: 0x170007B7 RID: 1975
		// (get) Token: 0x06000FA5 RID: 4005 RVA: 0x000F79E8 File Offset: 0x000F5BE8
		// (set) Token: 0x06000FA6 RID: 4006 RVA: 0x000F7A9C File Offset: 0x000F5C9C
		internal bool TrkSysGeneralSiteID_A9150_HiddenStatic
		{
			get
			{
				short num = (short)1188603802;
				short num2 = num;
				num = (short)751413146;
				switch (num2 == num)
				{
				}
				num = (short)1133051905;
				if (num != 0)
				{
				}
				num = (short)449052672;
				short num3 = num;
				num = (short)1054408704;
				if (num != 0)
				{
				}
				return this.trkSysGeneralSiteID_A9150.HiddenStatic;
			}
			set
			{
				short num = (short)303833854;
				short num2 = num;
				num = (short)1880892158;
				switch (num2 == num)
				{
				}
				num = (short)1704067072;
				if (num != 0)
				{
				}
				num = (short)177012736;
				short num3 = num;
				num = (short)2045771777;
				if (num != 0)
				{
				}
				this.trkSysGeneralSiteID_A9150.HiddenStatic = value;
			}
		}

		// Token: 0x170007B8 RID: 1976
		// (get) Token: 0x06000FA7 RID: 4007 RVA: 0x000F7B54 File Offset: 0x000F5D54
		// (set) Token: 0x06000FA8 RID: 4008 RVA: 0x000F7C0C File Offset: 0x000F5E0C
		internal bool TrkSysGeneralSiteID_A9150_HiddenDynamic
		{
			get
			{
				short num = (short)1561425114;
				short num2 = num;
				num = (short)459764954;
				switch (num2 == num)
				{
				}
				num = (short)176619521;
				if (num != 0)
				{
				}
				num = (short)1598291968;
				short num3 = num;
				num = (short)1929379840;
				if (num != 0)
				{
				}
				return this.trkSysGeneralSiteID_A9150.HiddenDynamic;
			}
			set
			{
				short num = (short)687915696;
				short num2 = num;
				num = (short)768656048;
				switch (num2 == num)
				{
				}
				num = (short)232980480;
				if (num != 0)
				{
				}
				num = (short)649134080;
				short num3 = num;
				num = (short)1378877441;
				if (num != 0)
				{
				}
				this.trkSysGeneralSiteID_A9150.HiddenDynamic = value;
			}
		}

		// Token: 0x170007B9 RID: 1977
		// (get) Token: 0x06000FA9 RID: 4009 RVA: 0x000F7CC0 File Offset: 0x000F5EC0
		public bool TrkSysGeneralSiteID_A9150_HasDiffs
		{
			get
			{
				short num = (short)778497749;
				short num2 = num;
				num = (short)1722347221;
				switch (num2 == num)
				{
				}
				num = (short)631963648;
				if (num != 0)
				{
				}
				num = (short)669319168;
				short num3 = num;
				num = (short)854327297;
				if (num != 0)
				{
				}
				return this.trkSysGeneralSiteID_A9150._HasDiffs;
			}
		}

		// Token: 0x170007BA RID: 1978
		// (get) Token: 0x06000FAA RID: 4010 RVA: 0x000F7D74 File Offset: 0x000F5F74
		// (set) Token: 0x06000FAB RID: 4011 RVA: 0x000F7E2C File Offset: 0x000F602C
		public int TrkSysGeneralSystemID_A9239Value
		{
			get
			{
				short num = (short)1391879568;
				short num2 = num;
				num = (short)1646224784;
				switch (num2 == num)
				{
				}
				num = (short)207749121;
				if (num != 0)
				{
				}
				num = (short)306184192;
				short num3 = num;
				num = (short)1307443200;
				if (num != 0)
				{
				}
				return this.trkSysGeneralSystemID_A9239.Value;
			}
			set
			{
				short num = (short)1969965497;
				short num2 = num;
				num = (short)22104505;
				switch (num2 == num)
				{
				}
				num = (short)1589837825;
				if (num != 0)
				{
				}
				num = (short)651493376;
				short num3 = num;
				num = (short)1303379968;
				if (num != 0)
				{
				}
				this.trkSysGeneralSystemID_A9239.Value = value;
			}
		}

		// Token: 0x170007BB RID: 1979
		// (get) Token: 0x06000FAC RID: 4012 RVA: 0x000F7EE4 File Offset: 0x000F60E4
		public global::AcpBusinessLayer.AcpSimpleRangeField TrkSysGeneralSystemID_A9239
		{
			get
			{
				short num = (short)1503461377;
				if (num != 0)
				{
				}
				num = (short)389419607;
				short num2 = num;
				num = (short)1273303639;
				switch (num2 == num)
				{
				}
				num = (short)1336541184;
				short num3 = num;
				num = (short)546177024;
				if (num != 0)
				{
				}
				return this.trkSysGeneralSystemID_A9239;
			}
		}

		// Token: 0x170007BC RID: 1980
		// (get) Token: 0x06000FAD RID: 4013 RVA: 0x000F7F98 File Offset: 0x000F6198
		// (set) Token: 0x06000FAE RID: 4014 RVA: 0x000F804C File Offset: 0x000F624C
		public string TrkSysGeneralSystemID_A9239_UIValue
		{
			get
			{
				short num = (short)288644302;
				short num2 = num;
				num = (short)390356174;
				switch (num2 == num)
				{
				}
				num = (short)1586495488;
				if (num != 0)
				{
				}
				num = (short)800915456;
				short num3 = num;
				num = (short)1231093761;
				if (num != 0)
				{
				}
				return this.trkSysGeneralSystemID_A9239.UIValue;
			}
			set
			{
				short num = (short)1415497213;
				short num2 = num;
				num = (short)1342752253;
				switch (num2 == num)
				{
				}
				num = (short)1437532161;
				if (num != 0)
				{
				}
				num = (short)1634336768;
				short num3 = num;
				num = (short)2047213568;
				if (num != 0)
				{
				}
				this.trkSysGeneralSystemID_A9239.UIValue = value;
			}
		}

		// Token: 0x170007BD RID: 1981
		// (get) Token: 0x06000FAF RID: 4015 RVA: 0x000F8104 File Offset: 0x000F6304
		// (set) Token: 0x06000FB0 RID: 4016 RVA: 0x000F81B8 File Offset: 0x000F63B8
		public string TrkSysGeneralSystemID_A9239_HexUIValue
		{
			get
			{
				short num = (short)1779830663;
				short num2 = num;
				num = (short)1553338247;
				switch (num2 == num)
				{
				}
				num = (short)1526464513;
				if (num != 0)
				{
				}
				num = (short)833617920;
				short num3 = num;
				num = (short)351928320;
				if (num != 0)
				{
				}
				return this.trkSysGeneralSystemID_A9239.HexUIValue;
			}
			set
			{
				short num = (short)1006008315;
				short num2 = num;
				num = (short)881817595;
				switch (num2 == num)
				{
				}
				num = (short)1302331392;
				if (num != 0)
				{
				}
				num = (short)788987904;
				short num3 = num;
				num = (short)1237057537;
				if (num != 0)
				{
				}
				this.trkSysGeneralSystemID_A9239.HexUIValue = value;
			}
		}

		// Token: 0x170007BE RID: 1982
		// (get) Token: 0x06000FB1 RID: 4017 RVA: 0x000F8270 File Offset: 0x000F6470
		// (set) Token: 0x06000FB2 RID: 4018 RVA: 0x000F8324 File Offset: 0x000F6524
		internal int TrkSysGeneralSystemID_A9239Min
		{
			get
			{
				short num = (short)1128926639;
				short num2 = num;
				num = (short)115150255;
				switch (num2 == num)
				{
				}
				num = (short)1821114368;
				if (num != 0)
				{
				}
				num = (short)1895366656;
				short num3 = num;
				num = (short)115212289;
				if (num != 0)
				{
				}
				return this.trkSysGeneralSystemID_A9239.Min;
			}
			set
			{
				short num = (short)1867563212;
				short num2 = num;
				num = (short)26984652;
				switch (num2 == num)
				{
				}
				num = (short)1494351873;
				if (num != 0)
				{
				}
				num = (short)543752192;
				short num3 = num;
				num = (short)1229848576;
				if (num != 0)
				{
				}
				this.trkSysGeneralSystemID_A9239.Min = value;
			}
		}

		// Token: 0x170007BF RID: 1983
		// (get) Token: 0x06000FB3 RID: 4019 RVA: 0x000F83D8 File Offset: 0x000F65D8
		// (set) Token: 0x06000FB4 RID: 4020 RVA: 0x000F848C File Offset: 0x000F668C
		internal int TrkSysGeneralSystemID_A9239Max
		{
			get
			{
				short num = (short)795017217;
				if (num != 0)
				{
				}
				num = (short)727084050;
				short num2 = num;
				num = (short)1395354642;
				switch (num2 == num)
				{
				}
				num = (short)2107834368;
				short num3 = num;
				num = (short)653918208;
				if (num != 0)
				{
				}
				return this.trkSysGeneralSystemID_A9239.Max;
			}
			set
			{
				short num = (short)967073954;
				short num2 = num;
				num = (short)637558946;
				switch (num2 == num)
				{
				}
				num = (short)22740993;
				if (num != 0)
				{
				}
				num = (short)1497300992;
				short num3 = num;
				num = (short)1849098240;
				if (num != 0)
				{
				}
				this.trkSysGeneralSystemID_A9239.Max = value;
			}
		}

		// Token: 0x170007C0 RID: 1984
		// (get) Token: 0x06000FB5 RID: 4021 RVA: 0x000F8540 File Offset: 0x000F6740
		// (set) Token: 0x06000FB6 RID: 4022 RVA: 0x000F85F4 File Offset: 0x000F67F4
		internal int TrkSysGeneralSystemID_A9239Step
		{
			get
			{
				short num = (short)1877213185;
				if (num != 0)
				{
				}
				num = (short)1667719036;
				short num2 = num;
				num = (short)984833916;
				switch (num2 == num)
				{
				}
				num = (short)1305870336;
				short num3 = num;
				num = (short)1849163776;
				if (num != 0)
				{
				}
				return this.trkSysGeneralSystemID_A9239.StepSize;
			}
			set
			{
				short num = (short)1714149050;
				short num2 = num;
				num = (short)769775290;
				switch (num2 == num)
				{
				}
				num = (short)2063663105;
				if (num != 0)
				{
				}
				num = (short)2011627520;
				short num3 = num;
				num = (short)782499840;
				if (num != 0)
				{
				}
				this.trkSysGeneralSystemID_A9239.StepSize = value;
			}
		}

		// Token: 0x170007C1 RID: 1985
		// (get) Token: 0x06000FB7 RID: 4023 RVA: 0x000F86A8 File Offset: 0x000F68A8
		// (set) Token: 0x06000FB8 RID: 4024 RVA: 0x000F875C File Offset: 0x000F695C
		public bool TrkSysGeneralSystemID_A9239_Applicable
		{
			get
			{
				short num = (short)1869283329;
				if (num != 0)
				{
				}
				num = (short)1910969900;
				short num2 = num;
				num = (short)1661146668;
				switch (num2 == num)
				{
				}
				num = (short)1026097152;
				short num3 = num;
				num = (short)771162112;
				if (num != 0)
				{
				}
				return this.trkSysGeneralSystemID_A9239.Applicable;
			}
			set
			{
				short num = (short)1469051297;
				short num2 = num;
				num = (short)848032161;
				switch (num2 == num)
				{
				}
				num = (short)1767047168;
				if (num != 0)
				{
				}
				num = (short)612630528;
				short num3 = num;
				num = (short)543227905;
				if (num != 0)
				{
				}
				this.trkSysGeneralSystemID_A9239.Applicable = value;
			}
		}

		// Token: 0x170007C2 RID: 1986
		// (get) Token: 0x06000FB9 RID: 4025 RVA: 0x000F8814 File Offset: 0x000F6A14
		// (set) Token: 0x06000FBA RID: 4026 RVA: 0x000F88C8 File Offset: 0x000F6AC8
		public bool TrkSysGeneralSystemID_A9239_Valid
		{
			get
			{
				short num = (short)1731054482;
				short num2 = num;
				num = (short)1903610770;
				switch (num2 == num)
				{
				}
				num = (short)629407745;
				if (num != 0)
				{
				}
				num = (short)1098448896;
				short num3 = num;
				num = (short)1565589504;
				if (num != 0)
				{
				}
				return this.trkSysGeneralSystemID_A9239.Valid;
			}
			set
			{
				short num = (short)1100058052;
				short num2 = num;
				num = (short)185503172;
				switch (num2 == num)
				{
				}
				num = (short)2024734720;
				if (num != 0)
				{
				}
				num = (short)325517312;
				short num3 = num;
				num = (short)504168449;
				if (num != 0)
				{
				}
				this.trkSysGeneralSystemID_A9239.Valid = value;
			}
		}

		// Token: 0x170007C3 RID: 1987
		// (get) Token: 0x06000FBB RID: 4027 RVA: 0x000F8980 File Offset: 0x000F6B80
		// (set) Token: 0x06000FBC RID: 4028 RVA: 0x000F8A34 File Offset: 0x000F6C34
		public bool TrkSysGeneralSystemID_A9239_Visible
		{
			get
			{
				short num = (short)1304819970;
				short num2 = num;
				num = (short)410646786;
				switch (num2 == num)
				{
				}
				num = (short)1172111360;
				if (num != 0)
				{
				}
				num = (short)1599471616;
				short num3 = num;
				num = (short)1105723393;
				if (num != 0)
				{
				}
				return this.trkSysGeneralSystemID_A9239.Visible;
			}
			set
			{
				short num = (short)1387406978;
				short num2 = num;
				num = (short)1955669634;
				switch (num2 == num)
				{
				}
				num = (short)1222246401;
				if (num != 0)
				{
				}
				num = (short)1287258112;
				short num3 = num;
				num = (short)147914752;
				if (num != 0)
				{
				}
				this.trkSysGeneralSystemID_A9239.Visible = value;
			}
		}

		// Token: 0x170007C4 RID: 1988
		// (get) Token: 0x06000FBD RID: 4029 RVA: 0x000F8AEC File Offset: 0x000F6CEC
		// (set) Token: 0x06000FBE RID: 4030 RVA: 0x000F8BA0 File Offset: 0x000F6DA0
		public bool TrkSysGeneralSystemID_A9239_Editable
		{
			get
			{
				short num = (short)1054947264;
				short num2 = num;
				num = (short)297678784;
				switch (num2 == num)
				{
				}
				num = (short)37355521;
				if (num != 0)
				{
				}
				num = (short)286851072;
				short num3 = num;
				num = (short)740229120;
				if (num != 0)
				{
				}
				return this.trkSysGeneralSystemID_A9239.Editable;
			}
			set
			{
				short num = (short)1811730660;
				short num2 = num;
				num = (short)1103810788;
				switch (num2 == num)
				{
				}
				num = (short)1994391553;
				if (num != 0)
				{
				}
				num = (short)1243676672;
				short num3 = num;
				num = (short)1313538048;
				if (num != 0)
				{
				}
				this.trkSysGeneralSystemID_A9239.Editable = value;
			}
		}

		// Token: 0x170007C5 RID: 1989
		// (get) Token: 0x06000FBF RID: 4031 RVA: 0x000F8C58 File Offset: 0x000F6E58
		internal string TrkSysGeneralSystemID_A9239_UILabel
		{
			get
			{
				short num = (short)891748353;
				if (num != 0)
				{
				}
				num = (short)435193960;
				short num2 = num;
				num = (short)1261799528;
				switch (num2 == num)
				{
				}
				num = (short)939393024;
				short num3 = num;
				num = (short)1049952256;
				if (num != 0)
				{
				}
				return this.trkSysGeneralSystemID_A9239.UIName;
			}
		}

		// Token: 0x170007C6 RID: 1990
		// (get) Token: 0x06000FC0 RID: 4032 RVA: 0x000F8D0C File Offset: 0x000F6F0C
		// (set) Token: 0x06000FC1 RID: 4033 RVA: 0x000F8DC0 File Offset: 0x000F6FC0
		internal bool TrkSysGeneralSystemID_A9239_HiddenStatic
		{
			get
			{
				short num = (short)733344946;
				short num2 = num;
				num = (short)1460663474;
				switch (num2 == num)
				{
				}
				num = (short)261947393;
				if (num != 0)
				{
				}
				num = (short)1741881344;
				short num3 = num;
				num = (short)515833856;
				if (num != 0)
				{
				}
				return this.trkSysGeneralSystemID_A9239.HiddenStatic;
			}
			set
			{
				short num = (short)57702185;
				short num2 = num;
				num = (short)1550743337;
				switch (num2 == num)
				{
				}
				num = (short)1683357697;
				if (num != 0)
				{
				}
				num = (short)881262592;
				short num3 = num;
				num = (short)513867776;
				if (num != 0)
				{
				}
				this.trkSysGeneralSystemID_A9239.HiddenStatic = value;
			}
		}

		// Token: 0x170007C7 RID: 1991
		// (get) Token: 0x06000FC2 RID: 4034 RVA: 0x000F8E74 File Offset: 0x000F7074
		// (set) Token: 0x06000FC3 RID: 4035 RVA: 0x000F8F2C File Offset: 0x000F712C
		internal bool TrkSysGeneralSystemID_A9239_HiddenDynamic
		{
			get
			{
				short num = (short)218103809;
				if (num != 0)
				{
				}
				num = (short)1869224403;
				short num2 = num;
				num = (short)662706643;
				switch (num2 == num)
				{
				}
				num = (short)731054080;
				short num3 = num;
				num = (short)1154809856;
				if (num != 0)
				{
				}
				return this.trkSysGeneralSystemID_A9239.HiddenDynamic;
			}
			set
			{
				short num = (short)903173406;
				short num2 = num;
				num = (short)76109086;
				switch (num2 == num)
				{
				}
				num = (short)1821376513;
				if (num != 0)
				{
				}
				num = (short)1543110656;
				short num3 = num;
				num = (short)327090176;
				if (num != 0)
				{
				}
				this.trkSysGeneralSystemID_A9239.HiddenDynamic = value;
			}
		}

		// Token: 0x170007C8 RID: 1992
		// (get) Token: 0x06000FC4 RID: 4036 RVA: 0x000F8FE0 File Offset: 0x000F71E0
		public bool TrkSysGeneralSystemID_A9239_HasDiffs
		{
			get
			{
				short num = (short)1183712351;
				short num2 = num;
				num = (short)649397343;
				switch (num2 == num)
				{
				}
				num = (short)1340538880;
				if (num != 0)
				{
				}
				num = (short)3997696;
				short num3 = num;
				num = (short)1945042945;
				if (num != 0)
				{
				}
				return this.trkSysGeneralSystemID_A9239._HasDiffs;
			}
		}

		// Token: 0x170007C9 RID: 1993
		// (get) Token: 0x06000FC5 RID: 4037 RVA: 0x000F9094 File Offset: 0x000F7294
		// (set) Token: 0x06000FC6 RID: 4038 RVA: 0x000F9148 File Offset: 0x000F7348
		public int TrkSysGeneralTypeIIFrequencyBand_A12491Value
		{
			get
			{
				short num = (short)243859457;
				if (num != 0)
				{
				}
				num = (short)629979953;
				short num2 = num;
				num = (short)1628617521;
				switch (num2 == num)
				{
				}
				num = (short)1204551680;
				short num3 = num;
				num = (short)1836974080;
				if (num != 0)
				{
				}
				return this.trkSysGeneralTypeIIFrequencyBand_A12491.Value;
			}
			set
			{
				short num = (short)993256544;
				short num2 = num;
				num = (short)926803040;
				switch (num2 == num)
				{
				}
				num = (short)1906966529;
				if (num != 0)
				{
				}
				num = (short)166133760;
				short num3 = num;
				num = (short)1489043456;
				if (num != 0)
				{
				}
				this.trkSysGeneralTypeIIFrequencyBand_A12491.Value = value;
			}
		}

		// Token: 0x170007CA RID: 1994
		// (get) Token: 0x06000FC7 RID: 4039 RVA: 0x000F91FC File Offset: 0x000F73FC
		// (set) Token: 0x06000FC8 RID: 4040 RVA: 0x000F92B0 File Offset: 0x000F74B0
		public string TrkSysGeneralTypeIIFrequencyBand_A12491_UIValue
		{
			get
			{
				short num = (short)203437814;
				short num2 = num;
				num = (short)1422669558;
				switch (num2 == num)
				{
				}
				num = (short)651624449;
				if (num != 0)
				{
				}
				num = (short)231931904;
				short num3 = num;
				num = (short)178192384;
				if (num != 0)
				{
				}
				return this.trkSysGeneralTypeIIFrequencyBand_A12491.UIValue;
			}
			set
			{
				short num = (short)1731645823;
				short num2 = num;
				num = (short)1178325375;
				switch (num2 == num)
				{
				}
				num = (short)545259520;
				if (num != 0)
				{
				}
				num = (short)1971978240;
				short num3 = num;
				num = (short)2140798977;
				if (num != 0)
				{
				}
				this.trkSysGeneralTypeIIFrequencyBand_A12491.UIValue = value;
			}
		}

		// Token: 0x170007CB RID: 1995
		// (get) Token: 0x06000FC9 RID: 4041 RVA: 0x000F9364 File Offset: 0x000F7564
		public global::AcpBusinessLayer.AcpListField TrkSysGeneralTypeIIFrequencyBand_A12491
		{
			get
			{
				short num = (short)507052033;
				if (num != 0)
				{
				}
				num = (short)1281344895;
				short num2 = num;
				num = (short)141018495;
				switch (num2 == num)
				{
				}
				num = (short)1712717824;
				short num3 = num;
				num = (short)1767768064;
				if (num != 0)
				{
				}
				return this.trkSysGeneralTypeIIFrequencyBand_A12491;
			}
		}

		// Token: 0x170007CC RID: 1996
		// (get) Token: 0x06000FCA RID: 4042 RVA: 0x000F9414 File Offset: 0x000F7614
		// (set) Token: 0x06000FCB RID: 4043 RVA: 0x000F94C8 File Offset: 0x000F76C8
		public bool TrkSysGeneralTypeIIFrequencyBand_A12491_Applicable
		{
			get
			{
				short num = (short)900222930;
				short num2 = num;
				num = (short)1686654930;
				switch (num2 == num)
				{
				}
				num = (short)476053505;
				if (num != 0)
				{
				}
				num = (short)1428881408;
				short num3 = num;
				num = (short)365756416;
				if (num != 0)
				{
				}
				return this.trkSysGeneralTypeIIFrequencyBand_A12491.Applicable;
			}
			set
			{
				short num = (short)1310798807;
				short num2 = num;
				num = (short)1945711575;
				switch (num2 == num)
				{
				}
				num = (short)151060480;
				if (num != 0)
				{
				}
				num = (short)1326383104;
				short num3 = num;
				num = (short)755105793;
				if (num != 0)
				{
				}
				this.trkSysGeneralTypeIIFrequencyBand_A12491.Applicable = value;
			}
		}

		// Token: 0x170007CD RID: 1997
		// (get) Token: 0x06000FCC RID: 4044 RVA: 0x000F9580 File Offset: 0x000F7780
		// (set) Token: 0x06000FCD RID: 4045 RVA: 0x000F9634 File Offset: 0x000F7834
		public bool TrkSysGeneralTypeIIFrequencyBand_A12491_Valid
		{
			get
			{
				short num = (short)159465131;
				short num2 = num;
				num = (short)1034960555;
				switch (num2 == num)
				{
				}
				num = (short)637468673;
				if (num != 0)
				{
				}
				num = (short)809631744;
				short num3 = num;
				num = (short)1175584768;
				if (num != 0)
				{
				}
				return this.trkSysGeneralTypeIIFrequencyBand_A12491.Valid;
			}
			set
			{
				short num = (short)2020221308;
				short num2 = num;
				num = (short)1839800700;
				switch (num2 == num)
				{
				}
				num = (short)733675521;
				if (num != 0)
				{
				}
				num = (short)2092236800;
				short num3 = num;
				num = (short)542179328;
				if (num != 0)
				{
				}
				this.trkSysGeneralTypeIIFrequencyBand_A12491.Valid = value;
			}
		}

		// Token: 0x170007CE RID: 1998
		// (get) Token: 0x06000FCE RID: 4046 RVA: 0x000F96E8 File Offset: 0x000F78E8
		// (set) Token: 0x06000FCF RID: 4047 RVA: 0x000F97A0 File Offset: 0x000F79A0
		public bool TrkSysGeneralTypeIIFrequencyBand_A12491_Visible
		{
			get
			{
				short num = (short)778006209;
				short num2 = num;
				num = (short)1831628481;
				switch (num2 == num)
				{
				}
				num = (short)1341128704;
				if (num != 0)
				{
				}
				num = (short)1352728576;
				short num3 = num;
				num = (short)1093992449;
				if (num != 0)
				{
				}
				return this.trkSysGeneralTypeIIFrequencyBand_A12491.Visible;
			}
			set
			{
				short num = (short)681213092;
				short num2 = num;
				num = (short)426671268;
				switch (num2 == num)
				{
				}
				num = (short)122093569;
				if (num != 0)
				{
				}
				num = (short)1970339840;
				short num3 = num;
				num = (short)1490419712;
				if (num != 0)
				{
				}
				this.trkSysGeneralTypeIIFrequencyBand_A12491.Visible = value;
			}
		}

		// Token: 0x170007CF RID: 1999
		// (get) Token: 0x06000FD0 RID: 4048 RVA: 0x000F9858 File Offset: 0x000F7A58
		// (set) Token: 0x06000FD1 RID: 4049 RVA: 0x000F9908 File Offset: 0x000F7B08
		public bool TrkSysGeneralTypeIIFrequencyBand_A12491_Editable
		{
			get
			{
				short num = (short)1021269080;
				short num2 = num;
				num = (short)659575896;
				switch (num2 == num)
				{
				}
				num = (short)501415937;
				if (num != 0)
				{
				}
				num = (short)1722482688;
				short num3 = num;
				num = (short)2081947648;
				if (num != 0)
				{
				}
				return this.trkSysGeneralTypeIIFrequencyBand_A12491.Editable;
			}
			set
			{
				short num = (short)1047140748;
				short num2 = num;
				num = (short)1616124300;
				switch (num2 == num)
				{
				}
				num = (short)2883585;
				if (num != 0)
				{
				}
				num = (short)1430913024;
				short num3 = num;
				num = (short)582483968;
				if (num != 0)
				{
				}
				this.trkSysGeneralTypeIIFrequencyBand_A12491.Editable = value;
			}
		}

		// Token: 0x170007D0 RID: 2000
		// (get) Token: 0x06000FD2 RID: 4050 RVA: 0x000F99C0 File Offset: 0x000F7BC0
		internal string TrkSysGeneralTypeIIFrequencyBand_A12491_UILabel
		{
			get
			{
				short num = (short)1868054778;
				short num2 = num;
				num = (short)853098746;
				switch (num2 == num)
				{
				}
				num = (short)591396865;
				if (num != 0)
				{
				}
				num = (short)1255407616;
				short num3 = num;
				num = (short)618463232;
				if (num != 0)
				{
				}
				return this.trkSysGeneralTypeIIFrequencyBand_A12491.UIName;
			}
		}

		// Token: 0x170007D1 RID: 2001
		// (get) Token: 0x06000FD3 RID: 4051 RVA: 0x000F9A74 File Offset: 0x000F7C74
		// (set) Token: 0x06000FD4 RID: 4052 RVA: 0x000F9B2C File Offset: 0x000F7D2C
		internal bool TrkSysGeneralTypeIIFrequencyBand_A12491_HiddenStatic
		{
			get
			{
				short num = (short)1465007431;
				short num2 = num;
				num = (short)896875847;
				switch (num2 == num)
				{
				}
				num = (short)1341128705;
				if (num != 0)
				{
				}
				num = (short)455213056;
				short num3 = num;
				num = (short)74448896;
				if (num != 0)
				{
				}
				return this.trkSysGeneralTypeIIFrequencyBand_A12491.HiddenStatic;
			}
			set
			{
				short num = (short)1159753143;
				short num2 = num;
				num = (short)1459711415;
				switch (num2 == num)
				{
				}
				num = (short)1670643712;
				if (num != 0)
				{
				}
				num = (short)1140195328;
				short num3 = num;
				num = (short)116064257;
				if (num != 0)
				{
				}
				this.trkSysGeneralTypeIIFrequencyBand_A12491.HiddenStatic = value;
			}
		}

		// Token: 0x170007D2 RID: 2002
		// (get) Token: 0x06000FD5 RID: 4053 RVA: 0x000F9BE0 File Offset: 0x000F7DE0
		// (set) Token: 0x06000FD6 RID: 4054 RVA: 0x000F9C98 File Offset: 0x000F7E98
		internal bool TrkSysGeneralTypeIIFrequencyBand_A12491_HiddenDynamic
		{
			get
			{
				short num = (short)2083979265;
				if (num != 0)
				{
				}
				num = (short)623435171;
				short num2 = num;
				num = (short)1422843299;
				switch (num2 == num)
				{
				}
				num = (short)605028352;
				short num3 = num;
				num = (short)104726528;
				if (num != 0)
				{
				}
				return this.trkSysGeneralTypeIIFrequencyBand_A12491.HiddenDynamic;
			}
			set
			{
				short num = (short)906637575;
				short num2 = num;
				num = (short)2071408903;
				switch (num2 == num)
				{
				}
				num = (short)631504897;
				if (num != 0)
				{
				}
				num = (short)783482880;
				short num3 = num;
				num = (short)1979252736;
				if (num != 0)
				{
				}
				this.trkSysGeneralTypeIIFrequencyBand_A12491.HiddenDynamic = value;
			}
		}

		// Token: 0x170007D3 RID: 2003
		// (get) Token: 0x06000FD7 RID: 4055 RVA: 0x000F9D4C File Offset: 0x000F7F4C
		public bool TrkSysGeneralTypeIIFrequencyBand_A12491_HasDiffs
		{
			get
			{
				short num = (short)2126727173;
				short num2 = num;
				num = (short)429672453;
				switch (num2 == num)
				{
				}
				num = (short)961740801;
				if (num != 0)
				{
				}
				num = (short)365821952;
				short num3 = num;
				num = (short)546111488;
				if (num != 0)
				{
				}
				return this.trkSysGeneralTypeIIFrequencyBand_A12491._HasDiffs;
			}
		}

		// Token: 0x170007D4 RID: 2004
		// (get) Token: 0x06000FD8 RID: 4056 RVA: 0x000F9E00 File Offset: 0x000F8000
		// (set) Token: 0x06000FD9 RID: 4057 RVA: 0x000F9EB8 File Offset: 0x000F80B8
		public int TrkSysGeneralUnitID_A12651Value
		{
			get
			{
				short num = (short)884736000;
				short num2 = num;
				num = (short)1069132830;
				short num3 = num;
				num = (short)1253485598;
				switch (num3 == num)
				{
				}
				num = (short)1510866945;
				if (num != 0)
				{
				}
				num = (short)1077608448;
				if (num != 0)
				{
				}
				return this.trkSysGeneralUnitID_A12651.Value;
			}
			set
			{
				short num = (short)1992949760;
				short num2 = num;
				num = (short)1313357571;
				short num3 = num;
				num = (short)570900227;
				switch (num3 == num)
				{
				}
				num = (short)1782054913;
				if (num != 0)
				{
				}
				num = (short)2057175040;
				if (num != 0)
				{
				}
				this.trkSysGeneralUnitID_A12651.Value = value;
			}
		}

		// Token: 0x170007D5 RID: 2005
		// (get) Token: 0x06000FDA RID: 4058 RVA: 0x000F9F6C File Offset: 0x000F816C
		public global::AcpBusinessLayer.AcpSimpleRangeField TrkSysGeneralUnitID_A12651
		{
			get
			{
				short num = (short)1957494784;
				short num2 = num;
				num = (short)39535436;
				short num3 = num;
				num = (short)634209100;
				switch (num3 == num)
				{
				}
				num = (short)70057985;
				if (num != 0)
				{
				}
				num = (short)2137391104;
				if (num != 0)
				{
				}
				return this.trkSysGeneralUnitID_A12651;
			}
		}

		// Token: 0x170007D6 RID: 2006
		// (get) Token: 0x06000FDB RID: 4059 RVA: 0x000FA01C File Offset: 0x000F821C
		// (set) Token: 0x06000FDC RID: 4060 RVA: 0x000FA0D0 File Offset: 0x000F82D0
		public string TrkSysGeneralUnitID_A12651_UIValue
		{
			get
			{
				short num = (short)738197504;
				short num2 = num;
				num = (short)101379883;
				short num3 = num;
				num = (short)363917099;
				switch (num3 == num)
				{
				}
				num = (short)635764736;
				if (num != 0)
				{
				}
				num = (short)1306066945;
				if (num != 0)
				{
				}
				return this.trkSysGeneralUnitID_A12651.UIValue;
			}
			set
			{
				short num = (short)908066816;
				short num2 = num;
				num = (short)450370005;
				short num3 = num;
				num = (short)928717269;
				switch (num3 == num)
				{
				}
				num = (short)521732097;
				if (num != 0)
				{
				}
				num = (short)1421541376;
				if (num != 0)
				{
				}
				this.trkSysGeneralUnitID_A12651.UIValue = value;
			}
		}

		// Token: 0x170007D7 RID: 2007
		// (get) Token: 0x06000FDD RID: 4061 RVA: 0x000FA184 File Offset: 0x000F8384
		// (set) Token: 0x06000FDE RID: 4062 RVA: 0x000FA238 File Offset: 0x000F8438
		public string TrkSysGeneralUnitID_A12651_HexUIValue
		{
			get
			{
				short num = (short)1151664128;
				short num2 = num;
				num = (short)1873947132;
				short num3 = num;
				num = (short)817834492;
				switch (num3 == num)
				{
				}
				num = (short)429260801;
				if (num != 0)
				{
				}
				num = (short)1621360640;
				if (num != 0)
				{
				}
				return this.trkSysGeneralUnitID_A12651.HexUIValue;
			}
			set
			{
				short num = (short)1540161536;
				short num2 = num;
				num = (short)1473445889;
				if (num != 0)
				{
				}
				num = (short)838487639;
				short num3 = num;
				num = (short)1066421847;
				switch (num3 == num)
				{
				}
				num = (short)189792256;
				if (num != 0)
				{
				}
				this.trkSysGeneralUnitID_A12651.HexUIValue = value;
			}
		}

		// Token: 0x170007D8 RID: 2008
		// (get) Token: 0x06000FDF RID: 4063 RVA: 0x000FA2EC File Offset: 0x000F84EC
		// (set) Token: 0x06000FE0 RID: 4064 RVA: 0x000FA3A0 File Offset: 0x000F85A0
		internal int TrkSysGeneralUnitID_A12651Min
		{
			get
			{
				short num = (short)428474368;
				short num2 = num;
				num = (short)1819052783;
				short num3 = num;
				num = (short)552635119;
				switch (num3 == num)
				{
				}
				num = (short)494141441;
				if (num != 0)
				{
				}
				num = (short)171048960;
				if (num != 0)
				{
				}
				return this.trkSysGeneralUnitID_A12651.Min;
			}
			set
			{
				short num = (short)1751384064;
				short num2 = num;
				num = (short)965287408;
				short num3 = num;
				num = (short)119676400;
				switch (num3 == num)
				{
				}
				num = (short)617152513;
				if (num != 0)
				{
				}
				num = (short)1052311552;
				if (num != 0)
				{
				}
				this.trkSysGeneralUnitID_A12651.Min = value;
			}
		}

		// Token: 0x170007D9 RID: 2009
		// (get) Token: 0x06000FE1 RID: 4065 RVA: 0x000FA454 File Offset: 0x000F8654
		// (set) Token: 0x06000FE2 RID: 4066 RVA: 0x000FA50C File Offset: 0x000F870C
		internal int TrkSysGeneralUnitID_A12651Max
		{
			get
			{
				short num = (short)991756288;
				short num2 = num;
				num = (short)1313398055;
				short num3 = num;
				num = (short)473816359;
				switch (num3 == num)
				{
				}
				num = (short)673644545;
				if (num != 0)
				{
				}
				num = (short)625737728;
				if (num != 0)
				{
				}
				return this.trkSysGeneralUnitID_A12651.Max;
			}
			set
			{
				short num = (short)330235904;
				short num2 = num;
				num = (short)592117761;
				if (num != 0)
				{
				}
				num = (short)1883591943;
				short num3 = num;
				num = (short)829052167;
				switch (num3 == num)
				{
				}
				num = (short)1521156096;
				if (num != 0)
				{
				}
				this.trkSysGeneralUnitID_A12651.Max = value;
			}
		}

		// Token: 0x170007DA RID: 2010
		// (get) Token: 0x06000FE3 RID: 4067 RVA: 0x000FA5C4 File Offset: 0x000F87C4
		// (set) Token: 0x06000FE4 RID: 4068 RVA: 0x000FA678 File Offset: 0x000F8878
		internal int TrkSysGeneralUnitID_A12651Step
		{
			get
			{
				short num = (short)993984512;
				short num2 = num;
				num = (short)889821998;
				short num3 = num;
				num = (short)1667603246;
				switch (num3 == num)
				{
				}
				num = (short)993984513;
				if (num != 0)
				{
				}
				num = (short)1216937984;
				if (num != 0)
				{
				}
				return this.trkSysGeneralUnitID_A12651.StepSize;
			}
			set
			{
				short num = (short)1506738176;
				short num2 = num;
				num = (short)408437499;
				short num3 = num;
				num = (short)1942045435;
				switch (num3 == num)
				{
				}
				num = (short)2009464833;
				if (num != 0)
				{
				}
				num = (short)1947729920;
				if (num != 0)
				{
				}
				this.trkSysGeneralUnitID_A12651.StepSize = value;
			}
		}

		// Token: 0x170007DB RID: 2011
		// (get) Token: 0x06000FE5 RID: 4069 RVA: 0x000FA72C File Offset: 0x000F892C
		// (set) Token: 0x06000FE6 RID: 4070 RVA: 0x000FA7E0 File Offset: 0x000F89E0
		public bool TrkSysGeneralUnitID_A12651_Applicable
		{
			get
			{
				short num = (short)951255040;
				short num2 = num;
				num = (short)571015169;
				if (num != 0)
				{
				}
				num = (short)2012246238;
				short num3 = num;
				num = (short)969634014;
				switch (num3 == num)
				{
				}
				num = (short)2141323264;
				if (num != 0)
				{
				}
				return this.trkSysGeneralUnitID_A12651.Applicable;
			}
			set
			{
				short num = (short)902889472;
				short num2 = num;
				num = (short)1337133863;
				short num3 = num;
				num = (short)333974311;
				switch (num3 == num)
				{
				}
				num = (short)1824129025;
				if (num != 0)
				{
				}
				num = (short)892338176;
				if (num != 0)
				{
				}
				this.trkSysGeneralUnitID_A12651.Applicable = value;
			}
		}

		// Token: 0x170007DC RID: 2012
		// (get) Token: 0x06000FE7 RID: 4071 RVA: 0x000FA894 File Offset: 0x000F8A94
		// (set) Token: 0x06000FE8 RID: 4072 RVA: 0x000FA94C File Offset: 0x000F8B4C
		public bool TrkSysGeneralUnitID_A12651_Valid
		{
			get
			{
				short num = (short)1283391488;
				short num2 = num;
				num = (short)349682890;
				short num3 = num;
				num = (short)1129168074;
				switch (num3 == num)
				{
				}
				num = (short)1746731008;
				if (num != 0)
				{
				}
				num = (short)349306881;
				if (num != 0)
				{
				}
				return this.trkSysGeneralUnitID_A12651.Valid;
			}
			set
			{
				short num = (short)1095630848;
				short num2 = num;
				num = (short)814098767;
				short num3 = num;
				num = (short)917121359;
				switch (num3 == num)
				{
				}
				num = (short)1325727745;
				if (num != 0)
				{
				}
				num = (short)1297416192;
				if (num != 0)
				{
				}
				this.trkSysGeneralUnitID_A12651.Valid = value;
			}
		}

		// Token: 0x170007DD RID: 2013
		// (get) Token: 0x06000FE9 RID: 4073 RVA: 0x000FAA00 File Offset: 0x000F8C00
		// (set) Token: 0x06000FEA RID: 4074 RVA: 0x000FAAB4 File Offset: 0x000F8CB4
		public bool TrkSysGeneralUnitID_A12651_Visible
		{
			get
			{
				short num = (short)2016673792;
				short num2 = num;
				num = (short)1343064534;
				short num3 = num;
				num = (short)486050262;
				switch (num3 == num)
				{
				}
				num = (short)1291517952;
				if (num != 0)
				{
				}
				num = (short)150732801;
				if (num != 0)
				{
				}
				return this.trkSysGeneralUnitID_A12651.Visible;
			}
			set
			{
				short num = (short)1511391232;
				short num2 = num;
				num = (short)815635090;
				short num3 = num;
				num = (short)864262802;
				switch (num3 == num)
				{
				}
				num = (short)1324941313;
				if (num != 0)
				{
				}
				num = (short)856686592;
				if (num != 0)
				{
				}
				this.trkSysGeneralUnitID_A12651.Visible = value;
			}
		}

		// Token: 0x170007DE RID: 2014
		// (get) Token: 0x06000FEB RID: 4075 RVA: 0x000FAB68 File Offset: 0x000F8D68
		// (set) Token: 0x06000FEC RID: 4076 RVA: 0x000FAC1C File Offset: 0x000F8E1C
		public bool TrkSysGeneralUnitID_A12651_Editable
		{
			get
			{
				short num = (short)2066153472;
				short num2 = num;
				num = (short)201038626;
				short num3 = num;
				num = (short)1271175970;
				switch (num3 == num)
				{
				}
				num = (short)671678465;
				if (num != 0)
				{
				}
				num = (short)25165824;
				if (num != 0)
				{
				}
				return this.trkSysGeneralUnitID_A12651.Editable;
			}
			set
			{
				short num = (short)1960378368;
				short num2 = num;
				num = (short)775425961;
				short num3 = num;
				num = (short)1418071977;
				switch (num3 == num)
				{
				}
				num = (short)965148673;
				if (num != 0)
				{
				}
				num = (short)1176633344;
				if (num != 0)
				{
				}
				this.trkSysGeneralUnitID_A12651.Editable = value;
			}
		}

		// Token: 0x170007DF RID: 2015
		// (get) Token: 0x06000FED RID: 4077 RVA: 0x000FACD0 File Offset: 0x000F8ED0
		internal string TrkSysGeneralUnitID_A12651_UILabel
		{
			get
			{
				short num = (short)1631518720;
				short num2 = num;
				num = (short)82092771;
				short num3 = num;
				num = (short)1834590947;
				switch (num3 == num)
				{
				}
				num = (short)1086062593;
				if (num != 0)
				{
				}
				num = (short)746979328;
				if (num != 0)
				{
				}
				return this.trkSysGeneralUnitID_A12651.UIName;
			}
		}

		// Token: 0x170007E0 RID: 2016
		// (get) Token: 0x06000FEE RID: 4078 RVA: 0x000FAD84 File Offset: 0x000F8F84
		// (set) Token: 0x06000FEF RID: 4079 RVA: 0x000FAE38 File Offset: 0x000F9038
		internal bool TrkSysGeneralUnitID_A12651_HiddenStatic
		{
			get
			{
				short num = (short)527106048;
				short num2 = num;
				num = (short)429905793;
				short num3 = num;
				num = (short)343660417;
				switch (num3 == num)
				{
				}
				num = (short)1713963008;
				if (num != 0)
				{
				}
				num = (short)1212350465;
				if (num != 0)
				{
				}
				return this.trkSysGeneralUnitID_A12651.HiddenStatic;
			}
			set
			{
				short num = (short)733151232;
				short num2 = num;
				num = (short)1930809381;
				short num3 = num;
				num = (short)1483788325;
				switch (num3 == num)
				{
				}
				num = (short)868548609;
				if (num != 0)
				{
				}
				num = (short)1635188736;
				if (num != 0)
				{
				}
				this.trkSysGeneralUnitID_A12651.HiddenStatic = value;
			}
		}

		// Token: 0x170007E1 RID: 2017
		// (get) Token: 0x06000FF0 RID: 4080 RVA: 0x000FAEF0 File Offset: 0x000F90F0
		// (set) Token: 0x06000FF1 RID: 4081 RVA: 0x000FAFA4 File Offset: 0x000F91A4
		internal bool TrkSysGeneralUnitID_A12651_HiddenDynamic
		{
			get
			{
				short num = (short)1499004928;
				short num2 = num;
				num = (short)1456823505;
				short num3 = num;
				num = (short)326196433;
				switch (num3 == num)
				{
				}
				num = (short)979632128;
				if (num != 0)
				{
				}
				num = (short)1760428033;
				if (num != 0)
				{
				}
				return this.trkSysGeneralUnitID_A12651.HiddenDynamic;
			}
			set
			{
				short num = (short)1199898624;
				short num2 = num;
				num = (short)390074656;
				short num3 = num;
				num = (short)226627872;
				switch (num3 == num)
				{
				}
				num = (short)1009647616;
				if (num != 0)
				{
				}
				num = (short)1444216833;
				if (num != 0)
				{
				}
				this.trkSysGeneralUnitID_A12651.HiddenDynamic = value;
			}
		}

		// Token: 0x170007E2 RID: 2018
		// (get) Token: 0x06000FF2 RID: 4082 RVA: 0x000FB058 File Offset: 0x000F9258
		public bool TrkSysGeneralUnitID_A12651_HasDiffs
		{
			get
			{
				short num = (short)1427767296;
				short num2 = num;
				num = (short)1802806441;
				short num3 = num;
				num = (short)986752169;
				switch (num3 == num)
				{
				}
				num = (short)1799880705;
				if (num != 0)
				{
				}
				num = (short)808976384;
				if (num != 0)
				{
				}
				return this.trkSysGeneralUnitID_A12651._HasDiffs;
			}
		}

		// Token: 0x170007E3 RID: 2019
		// (get) Token: 0x06000FF3 RID: 4083 RVA: 0x000FB10C File Offset: 0x000F930C
		// (set) Token: 0x06000FF4 RID: 4084 RVA: 0x000FB1C0 File Offset: 0x000F93C0
		public string TrkSysGeneralKeyofTrunkingSystem_A12658Value
		{
			get
			{
				short num = (short)1748172800;
				short num2 = num;
				num = (short)1319570678;
				short num3 = num;
				num = (short)974720246;
				switch (num3 == num)
				{
				}
				num = (short)1082523648;
				if (num != 0)
				{
				}
				num = (short)1276444673;
				if (num != 0)
				{
				}
				return this.trkSysGeneralKeyofTrunkingSystem_A12658.Value;
			}
			set
			{
				short num = (short)341573633;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						return;
					case 1:
						goto IL_14;
					case 2:
					{
						num = (short)1992357573;
						short num3 = num;
						num = (short)1971975877;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_14;
						default:
							num = (short)942538752;
							if (num != 0)
							{
							}
							this.trkSysGeneralKeyofTrunkingSystem_A12658.Value = value;
							num = (short)1960902657;
							if (num != 0)
							{
							}
							num = (short)1241186304;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					goto IL_30;
					IL_14:
					switch (0)
					{
					case 0:
					{
						IL_30:
						num = (short)876347392;
						short num4 = num;
						if (string.IsNullOrEmpty(value.Trim()))
						{
							return;
						}
						num = (short)856031234;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					}
				}
			}
		}

		// Token: 0x170007E4 RID: 2020
		// (get) Token: 0x06000FF5 RID: 4085 RVA: 0x000FB2E8 File Offset: 0x000F94E8
		// (set) Token: 0x06000FF6 RID: 4086 RVA: 0x000FB39C File Offset: 0x000F959C
		public string TrkSysGeneralKeyofTrunkingSystem_A12658_UIValue
		{
			get
			{
				short num = (short)210567168;
				short num2 = num;
				num = (short)263492509;
				short num3 = num;
				num = (short)1234932637;
				switch (num3 == num)
				{
				}
				num = (short)268435457;
				if (num != 0)
				{
				}
				num = (short)1345716224;
				if (num != 0)
				{
				}
				return this.trkSysGeneralKeyofTrunkingSystem_A12658.Value;
			}
			set
			{
				short num = (short)1190658048;
				short num2 = num;
				num = (short)455613105;
				short num3 = num;
				num = (short)840899249;
				switch (num3 == num)
				{
				}
				num = (short)2097741825;
				if (num != 0)
				{
				}
				num = (short)650706944;
				if (num != 0)
				{
				}
				this.trkSysGeneralKeyofTrunkingSystem_A12658.Value = value;
			}
		}

		// Token: 0x170007E5 RID: 2021
		// (get) Token: 0x06000FF7 RID: 4087 RVA: 0x000FB454 File Offset: 0x000F9654
		public global::AcpBusinessLayer.AcpKeyField TrkSysGeneralKeyofTrunkingSystem_A12658
		{
			get
			{
				short num = (short)1416691712;
				short num2 = num;
				num = (short)97982222;
				short num3 = num;
				num = (short)862197518;
				switch (num3 == num)
				{
				}
				num = (short)328073217;
				if (num != 0)
				{
				}
				num = (short)606666752;
				if (num != 0)
				{
				}
				return this.trkSysGeneralKeyofTrunkingSystem_A12658;
			}
		}

		// Token: 0x170007E6 RID: 2022
		// (get) Token: 0x06000FF8 RID: 4088 RVA: 0x000FB504 File Offset: 0x000F9704
		// (set) Token: 0x06000FF9 RID: 4089 RVA: 0x000FB5BC File Offset: 0x000F97BC
		public bool TrkSysGeneralKeyofTrunkingSystem_A12658_Applicable
		{
			get
			{
				short num = (short)133496832;
				short num2 = num;
				num = (short)245891073;
				if (num != 0)
				{
				}
				num = (short)1082344993;
				short num3 = num;
				num = (short)1139688993;
				switch (num3 == num)
				{
				}
				num = (short)1216544768;
				if (num != 0)
				{
				}
				return this.trkSysGeneralKeyofTrunkingSystem_A12658.Applicable;
			}
			set
			{
				short num = (short)2138505216;
				short num2 = num;
				num = (short)962449870;
				short num3 = num;
				num = (short)307745230;
				switch (num3 == num)
				{
				}
				num = (short)500891649;
				if (num != 0)
				{
				}
				num = (short)174391296;
				if (num != 0)
				{
				}
				this.trkSysGeneralKeyofTrunkingSystem_A12658.Applicable = value;
			}
		}

		// Token: 0x170007E7 RID: 2023
		// (get) Token: 0x06000FFA RID: 4090 RVA: 0x000FB670 File Offset: 0x000F9870
		// (set) Token: 0x06000FFB RID: 4091 RVA: 0x000FB724 File Offset: 0x000F9924
		public bool TrkSysGeneralKeyofTrunkingSystem_A12658_Valid
		{
			get
			{
				short num = (short)813563904;
				short num2 = num;
				num = (short)1014278400;
				short num3 = num;
				num = (short)1967761664;
				switch (num3 == num)
				{
				}
				num = (short)1200160768;
				if (num != 0)
				{
				}
				num = (short)1281687553;
				if (num != 0)
				{
				}
				return this.trkSysGeneralKeyofTrunkingSystem_A12658.Valid;
			}
			set
			{
				short num = (short)1569652736;
				short num2 = num;
				num = (short)1698612571;
				short num3 = num;
				num = (short)660784475;
				switch (num3 == num)
				{
				}
				num = (short)922025985;
				if (num != 0)
				{
				}
				num = (short)848560128;
				if (num != 0)
				{
				}
				this.trkSysGeneralKeyofTrunkingSystem_A12658.Valid = value;
			}
		}

		// Token: 0x170007E8 RID: 2024
		// (get) Token: 0x06000FFC RID: 4092 RVA: 0x000FB7D8 File Offset: 0x000F99D8
		// (set) Token: 0x06000FFD RID: 4093 RVA: 0x000FB890 File Offset: 0x000F9A90
		public bool TrkSysGeneralKeyofTrunkingSystem_A12658_Visible
		{
			get
			{
				short num = (short)1766981632;
				short num2 = num;
				num = (short)13268965;
				short num3 = num;
				num = (short)1087600613;
				switch (num3 == num)
				{
				}
				num = (short)1219231745;
				if (num != 0)
				{
				}
				num = (short)313589760;
				if (num != 0)
				{
				}
				return this.trkSysGeneralKeyofTrunkingSystem_A12658.Visible;
			}
			set
			{
				short num = (short)344522752;
				short num2 = num;
				num = (short)686748980;
				short num3 = num;
				num = (short)2082927924;
				switch (num3 == num)
				{
				}
				num = (short)776601601;
				if (num != 0)
				{
				}
				num = (short)1385758720;
				if (num != 0)
				{
				}
				this.trkSysGeneralKeyofTrunkingSystem_A12658.Visible = value;
			}
		}

		// Token: 0x170007E9 RID: 2025
		// (get) Token: 0x06000FFE RID: 4094 RVA: 0x000FB944 File Offset: 0x000F9B44
		// (set) Token: 0x06000FFF RID: 4095 RVA: 0x000FB9F8 File Offset: 0x000F9BF8
		public bool TrkSysGeneralKeyofTrunkingSystem_A12658_Editable
		{
			get
			{
				short num = (short)1382285312;
				short num2 = num;
				num = (short)573381921;
				short num3 = num;
				num = (short)1672158497;
				switch (num3 == num)
				{
				}
				num = (short)1357578240;
				if (num != 0)
				{
				}
				num = (short)358088705;
				if (num != 0)
				{
				}
				return this.trkSysGeneralKeyofTrunkingSystem_A12658.Editable;
			}
			set
			{
				short num = (short)1254883328;
				short num2 = num;
				num = (short)2067244931;
				short num3 = num;
				num = (short)122857347;
				switch (num3 == num)
				{
				}
				num = (short)1364852737;
				if (num != 0)
				{
				}
				num = (short)1151270912;
				if (num != 0)
				{
				}
				this.trkSysGeneralKeyofTrunkingSystem_A12658.Editable = value;
			}
		}

		// Token: 0x170007EA RID: 2026
		// (get) Token: 0x06001000 RID: 4096 RVA: 0x000FBAB0 File Offset: 0x000F9CB0
		internal string TrkSysGeneralKeyofTrunkingSystem_A12658_UILabel
		{
			get
			{
				short num = (short)163446784;
				short num2 = num;
				num = (short)874673960;
				short num3 = num;
				num = (short)1876326184;
				switch (num3 == num)
				{
				}
				num = (short)1664614400;
				if (num != 0)
				{
				}
				num = (short)1702625281;
				if (num != 0)
				{
				}
				return this.trkSysGeneralKeyofTrunkingSystem_A12658.UIName;
			}
		}

		// Token: 0x170007EB RID: 2027
		// (get) Token: 0x06001001 RID: 4097 RVA: 0x000FBB68 File Offset: 0x000F9D68
		// (set) Token: 0x06001002 RID: 4098 RVA: 0x000FBC1C File Offset: 0x000F9E1C
		internal bool TrkSysGeneralKeyofTrunkingSystem_A12658_HiddenStatic
		{
			get
			{
				short num = (short)2099576832;
				short num2 = num;
				num = (short)2070740993;
				if (num != 0)
				{
				}
				num = (short)319997155;
				short num3 = num;
				num = (short)1681245411;
				switch (num3 == num)
				{
				}
				num = (short)1990590464;
				if (num != 0)
				{
				}
				return this.trkSysGeneralKeyofTrunkingSystem_A12658.HiddenStatic;
			}
			set
			{
				short num = (short)809369600;
				short num2 = num;
				num = (short)706024934;
				short num3 = num;
				num = (short)257431014;
				switch (num3 == num)
				{
				}
				num = (short)731316225;
				if (num != 0)
				{
				}
				num = (short)1125187584;
				if (num != 0)
				{
				}
				this.trkSysGeneralKeyofTrunkingSystem_A12658.HiddenStatic = value;
			}
		}

		// Token: 0x170007EC RID: 2028
		// (get) Token: 0x06001003 RID: 4099 RVA: 0x000FBCD4 File Offset: 0x000F9ED4
		// (set) Token: 0x06001004 RID: 4100 RVA: 0x000FBD88 File Offset: 0x000F9F88
		internal bool TrkSysGeneralKeyofTrunkingSystem_A12658_HiddenDynamic
		{
			get
			{
				short num = (short)487653376;
				short num2 = num;
				num = (short)397082625;
				if (num != 0)
				{
				}
				num = (short)2036687235;
				short num3 = num;
				num = (short)1752785283;
				switch (num3 == num)
				{
				}
				num = (short)644415488;
				if (num != 0)
				{
				}
				return this.trkSysGeneralKeyofTrunkingSystem_A12658.HiddenDynamic;
			}
			set
			{
				short num = (short)1336410112;
				short num2 = num;
				num = (short)1869663349;
				short num3 = num;
				num = (short)871484533;
				switch (num3 == num)
				{
				}
				num = (short)873201665;
				if (num != 0)
				{
				}
				num = (short)1414660096;
				if (num != 0)
				{
				}
				this.trkSysGeneralKeyofTrunkingSystem_A12658.HiddenDynamic = value;
			}
		}

		// Token: 0x170007ED RID: 2029
		// (get) Token: 0x06001005 RID: 4101 RVA: 0x000FBE3C File Offset: 0x000FA03C
		public bool TrkSysGeneralKeyofTrunkingSystem_A12658_HasDiffs
		{
			get
			{
				short num = (short)526450688;
				short num2 = num;
				num = (short)901895058;
				short num3 = num;
				num = (short)2103235474;
				switch (num3 == num)
				{
				}
				num = (short)247857153;
				if (num != 0)
				{
				}
				num = (short)1777008640;
				if (num != 0)
				{
				}
				return this.trkSysGeneralKeyofTrunkingSystem_A12658._HasDiffs;
			}
		}

		// Token: 0x170007EE RID: 2030
		// (get) Token: 0x06001006 RID: 4102 RVA: 0x000FBEF0 File Offset: 0x000FA0F0
		// (set) Token: 0x06001007 RID: 4103 RVA: 0x000FBFA4 File Offset: 0x000FA1A4
		public int TrkSysGeneralDataProfileSelection_A19449Value
		{
			get
			{
				short num = (short)330170368;
				short num2 = num;
				num = (short)2074491305;
				short num3 = num;
				num = (short)531380649;
				switch (num3 == num)
				{
				}
				num = (short)1617494017;
				if (num != 0)
				{
				}
				num = (short)1127284736;
				if (num != 0)
				{
				}
				return this.trkSysGeneralDataProfileSelection_A19449.Value;
			}
			set
			{
				short num = (short)456851456;
				short num2 = num;
				num = (short)340452217;
				short num3 = num;
				num = (short)1233773433;
				switch (num3 == num)
				{
				}
				num = (short)1611268097;
				if (num != 0)
				{
				}
				num = (short)129105920;
				if (num != 0)
				{
				}
				this.trkSysGeneralDataProfileSelection_A19449.Value = value;
			}
		}

		// Token: 0x170007EF RID: 2031
		// (get) Token: 0x06001008 RID: 4104 RVA: 0x000FC058 File Offset: 0x000FA258
		// (set) Token: 0x06001009 RID: 4105 RVA: 0x000FC110 File Offset: 0x000FA310
		public string TrkSysGeneralDataProfileSelection_A19449_UIValue
		{
			get
			{
				short num = (short)1091043328;
				short num2 = num;
				num = (short)465440356;
				short num3 = num;
				num = (short)1729433188;
				switch (num3 == num)
				{
				}
				num = (short)1789591552;
				if (num != 0)
				{
				}
				num = (short)268238849;
				if (num != 0)
				{
				}
				return this.trkSysGeneralDataProfileSelection_A19449.UIValue;
			}
			set
			{
				short num = (short)1404829696;
				short num2 = num;
				num = (short)1295811632;
				short num3 = num;
				num = (short)1648395312;
				switch (num3 == num)
				{
				}
				num = (short)519110656;
				if (num != 0)
				{
				}
				num = (short)244776961;
				if (num != 0)
				{
				}
				this.trkSysGeneralDataProfileSelection_A19449.UIValue = value;
			}
		}

		// Token: 0x170007F0 RID: 2032
		// (get) Token: 0x0600100A RID: 4106 RVA: 0x000FC1C4 File Offset: 0x000FA3C4
		public global::AcpBusinessLayer.AcpRecRefField TrkSysGeneralDataProfileSelection_A19449
		{
			get
			{
				short num = (short)2113077248;
				short num2 = num;
				num = (short)1332740097;
				if (num != 0)
				{
				}
				num = (short)1270158327;
				short num3 = num;
				num = (short)206509047;
				switch (num3 == num)
				{
				}
				num = (short)1573715968;
				if (num != 0)
				{
				}
				return this.trkSysGeneralDataProfileSelection_A19449;
			}
		}

		// Token: 0x170007F1 RID: 2033
		// (get) Token: 0x0600100B RID: 4107 RVA: 0x000FC274 File Offset: 0x000FA474
		// (set) Token: 0x0600100C RID: 4108 RVA: 0x000FC328 File Offset: 0x000FA528
		public bool TrkSysGeneralDataProfileSelection_A19449_Applicable
		{
			get
			{
				short num = (short)2095710208;
				short num2 = num;
				num = (short)174646241;
				short num3 = num;
				num = (short)1308812257;
				switch (num3 == num)
				{
				}
				num = (short)983695360;
				if (num != 0)
				{
				}
				num = (short)380239873;
				if (num != 0)
				{
				}
				return this.trkSysGeneralDataProfileSelection_A19449.Applicable;
			}
			set
			{
				short num = (short)611909632;
				short num2 = num;
				num = (short)65422097;
				short num3 = num;
				num = (short)830882577;
				switch (num3 == num)
				{
				}
				num = (short)1431306240;
				if (num != 0)
				{
				}
				num = (short)82247681;
				if (num != 0)
				{
				}
				this.trkSysGeneralDataProfileSelection_A19449.Applicable = value;
			}
		}

		// Token: 0x170007F2 RID: 2034
		// (get) Token: 0x0600100D RID: 4109 RVA: 0x000FC3E0 File Offset: 0x000FA5E0
		// (set) Token: 0x0600100E RID: 4110 RVA: 0x000FC494 File Offset: 0x000FA694
		public bool TrkSysGeneralDataProfileSelection_A19449_Valid
		{
			get
			{
				short num = (short)505517541;
				short num2 = num;
				num = (short)121673189;
				switch (num2 == num)
				{
				default:
				{
					num = (short)686292992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1582891008;
				if (num != 0)
				{
				}
				num = (short)893255681;
				if (num != 0)
				{
				}
				return this.trkSysGeneralDataProfileSelection_A19449.Valid;
			}
			set
			{
				short num = (short)1392195675;
				short num2 = num;
				num = (short)953235547;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1715077120;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)545914881;
				if (num != 0)
				{
				}
				num = (short)1117585408;
				if (num != 0)
				{
				}
				this.trkSysGeneralDataProfileSelection_A19449.Valid = value;
			}
		}

		// Token: 0x170007F3 RID: 2035
		// (get) Token: 0x0600100F RID: 4111 RVA: 0x000FC548 File Offset: 0x000FA748
		// (set) Token: 0x06001010 RID: 4112 RVA: 0x000FC600 File Offset: 0x000FA800
		public bool TrkSysGeneralDataProfileSelection_A19449_Visible
		{
			get
			{
				short num = (short)88607034;
				short num2 = num;
				num = (short)2040727866;
				switch (num2 == num)
				{
				default:
				{
					num = (short)232456192;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1188560897;
				if (num != 0)
				{
				}
				num = (short)676397056;
				if (num != 0)
				{
				}
				return this.trkSysGeneralDataProfileSelection_A19449.Visible;
			}
			set
			{
				short num = (short)266037122;
				short num2 = num;
				num = (short)823486338;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2002321408;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1310654465;
				if (num != 0)
				{
				}
				num = (short)319881216;
				if (num != 0)
				{
				}
				this.trkSysGeneralDataProfileSelection_A19449.Visible = value;
			}
		}

		// Token: 0x170007F4 RID: 2036
		// (get) Token: 0x06001011 RID: 4113 RVA: 0x000FC6B4 File Offset: 0x000FA8B4
		// (set) Token: 0x06001012 RID: 4114 RVA: 0x000FC76C File Offset: 0x000FA96C
		public bool TrkSysGeneralDataProfileSelection_A19449_Editable
		{
			get
			{
				short num = (short)1575485441;
				if (num != 0)
				{
				}
				num = (short)1041694720;
				short num2 = num;
				num = (short)1443525415;
				short num3 = num;
				num = (short)1850241831;
				switch (num3 == num)
				{
				}
				num = (short)269156352;
				if (num != 0)
				{
				}
				return this.trkSysGeneralDataProfileSelection_A19449.Editable;
			}
			set
			{
				short num = (short)668570201;
				short num2 = num;
				num = (short)1740345945;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2118320128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)417660928;
				if (num != 0)
				{
				}
				num = (short)694288385;
				if (num != 0)
				{
				}
				this.trkSysGeneralDataProfileSelection_A19449.Editable = value;
			}
		}

		// Token: 0x170007F5 RID: 2037
		// (get) Token: 0x06001013 RID: 4115 RVA: 0x000FC820 File Offset: 0x000FAA20
		internal string TrkSysGeneralDataProfileSelection_A19449_UILabel
		{
			get
			{
				short num = (short)795150517;
				short num2 = num;
				num = (short)1474562229;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1374093312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1643773953;
				if (num != 0)
				{
				}
				num = (short)25952256;
				if (num != 0)
				{
				}
				return this.trkSysGeneralDataProfileSelection_A19449.UIName;
			}
		}

		// Token: 0x170007F6 RID: 2038
		// (get) Token: 0x06001014 RID: 4116 RVA: 0x000FC8D8 File Offset: 0x000FAAD8
		// (set) Token: 0x06001015 RID: 4117 RVA: 0x000FC98C File Offset: 0x000FAB8C
		internal bool TrkSysGeneralDataProfileSelection_A19449_HiddenStatic
		{
			get
			{
				short num = (short)365266258;
				short num2 = num;
				num = (short)1000113490;
				switch (num2 == num)
				{
				default:
				{
					num = (short)526516224;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)529924097;
				if (num != 0)
				{
				}
				num = (short)1403912192;
				if (num != 0)
				{
				}
				return this.trkSysGeneralDataProfileSelection_A19449.HiddenStatic;
			}
			set
			{
				short num = (short)90194273;
				short num2 = num;
				num = (short)1204044129;
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
				num = (short)1793589249;
				if (num != 0)
				{
				}
				num = (short)525336576;
				if (num != 0)
				{
				}
				this.trkSysGeneralDataProfileSelection_A19449.HiddenStatic = value;
			}
		}

		// Token: 0x170007F7 RID: 2039
		// (get) Token: 0x06001016 RID: 4118 RVA: 0x000FCA40 File Offset: 0x000FAC40
		// (set) Token: 0x06001017 RID: 4119 RVA: 0x000FCAF4 File Offset: 0x000FACF4
		internal bool TrkSysGeneralDataProfileSelection_A19449_HiddenDynamic
		{
			get
			{
				short num = (short)925930537;
				short num2 = num;
				num = (short)1677628457;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1427636224;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2087845889;
				if (num != 0)
				{
				}
				num = (short)759824384;
				if (num != 0)
				{
				}
				return this.trkSysGeneralDataProfileSelection_A19449.HiddenDynamic;
			}
			set
			{
				short num = (short)527665746;
				short num2 = num;
				num = (short)771525202;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1047855104;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1027932160;
				if (num != 0)
				{
				}
				num = (short)238223361;
				if (num != 0)
				{
				}
				this.trkSysGeneralDataProfileSelection_A19449.HiddenDynamic = value;
			}
		}

		// Token: 0x170007F8 RID: 2040
		// (get) Token: 0x06001018 RID: 4120 RVA: 0x000FCBAC File Offset: 0x000FADAC
		public bool TrkSysGeneralDataProfileSelection_A19449_HasDiffs
		{
			get
			{
				short num = (short)1301594742;
				short num2 = num;
				num = (short)1172750966;
				switch (num2 == num)
				{
				default:
				{
					num = (short)636747776;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1595211776;
				if (num != 0)
				{
				}
				num = (short)571539457;
				if (num != 0)
				{
				}
				return this.trkSysGeneralDataProfileSelection_A19449._HasDiffs;
			}
		}

		// Token: 0x170007F9 RID: 2041
		// (get) Token: 0x06001019 RID: 4121 RVA: 0x000FCC60 File Offset: 0x000FAE60
		// (set) Token: 0x0600101A RID: 4122 RVA: 0x000FCD14 File Offset: 0x000FAF14
		public bool TrkSysGeneralAskRequired_A44909Value
		{
			get
			{
				short num = (short)2059353592;
				short num2 = num;
				num = (short)687357432;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1122500608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)681377793;
				if (num != 0)
				{
				}
				num = (short)2047541248;
				if (num != 0)
				{
				}
				return this.trkSysGeneralAskRequired_A44909.Value;
			}
			set
			{
				short num = (short)458315021;
				short num2 = num;
				num = (short)1710380301;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1482752000;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1518206977;
				if (num != 0)
				{
				}
				num = (short)475070464;
				if (num != 0)
				{
				}
				this.trkSysGeneralAskRequired_A44909.Value = value;
			}
		}

		// Token: 0x170007FA RID: 2042
		// (get) Token: 0x0600101B RID: 4123 RVA: 0x000FCDC8 File Offset: 0x000FAFC8
		public global::AcpBusinessLayer.AcpField<bool> TrkSysGeneralAskRequired_A44909
		{
			get
			{
				short num = (short)1899393324;
				short num2 = num;
				num = (short)1329033516;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1075576832;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1568997377;
				if (num != 0)
				{
				}
				num = (short)560988160;
				if (num != 0)
				{
				}
				return this.trkSysGeneralAskRequired_A44909;
			}
		}

		// Token: 0x170007FB RID: 2043
		// (get) Token: 0x0600101C RID: 4124 RVA: 0x000FCE74 File Offset: 0x000FB074
		// (set) Token: 0x0600101D RID: 4125 RVA: 0x000FCF28 File Offset: 0x000FB128
		public bool TrkSysGeneralAskRequired_A44909_UIValue
		{
			get
			{
				short num = (short)1514260446;
				short num2 = num;
				num = (short)861587422;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1762066432;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1208942593;
				if (num != 0)
				{
				}
				num = (short)1597767680;
				if (num != 0)
				{
				}
				return this.trkSysGeneralAskRequired_A44909.Value;
			}
			set
			{
				short num = (short)306595276;
				short num2 = num;
				num = (short)2053129676;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1207959552;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1643970560;
				if (num != 0)
				{
				}
				num = (short)1268776961;
				if (num != 0)
				{
				}
				this.trkSysGeneralAskRequired_A44909.Value = value;
			}
		}

		// Token: 0x170007FC RID: 2044
		// (get) Token: 0x0600101E RID: 4126 RVA: 0x000FCFDC File Offset: 0x000FB1DC
		// (set) Token: 0x0600101F RID: 4127 RVA: 0x000FD090 File Offset: 0x000FB290
		public bool TrkSysGeneralAskRequired_A44909_Applicable
		{
			get
			{
				short num = (short)693781733;
				short num2 = num;
				num = (short)1798849765;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1589051392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1135149057;
				if (num != 0)
				{
				}
				num = (short)808058880;
				if (num != 0)
				{
				}
				return this.trkSysGeneralAskRequired_A44909.Applicable;
			}
			set
			{
				short num = (short)514667546;
				short num2 = num;
				num = (short)54080538;
				switch (num2 == num)
				{
				default:
				{
					num = (short)312803328;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)714735617;
				if (num != 0)
				{
				}
				num = (short)1845035008;
				if (num != 0)
				{
				}
				this.trkSysGeneralAskRequired_A44909.Applicable = value;
			}
		}

		// Token: 0x170007FD RID: 2045
		// (get) Token: 0x06001020 RID: 4128 RVA: 0x000FD148 File Offset: 0x000FB348
		// (set) Token: 0x06001021 RID: 4129 RVA: 0x000FD200 File Offset: 0x000FB400
		public bool TrkSysGeneralAskRequired_A44909_Valid
		{
			get
			{
				short num = (short)1538616500;
				short num2 = num;
				num = (short)2074766516;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1641414656;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)397082624;
				if (num != 0)
				{
				}
				num = (short)453902337;
				if (num != 0)
				{
				}
				return this.trkSysGeneralAskRequired_A44909.Valid;
			}
			set
			{
				short num = (short)647754510;
				short num2 = num;
				num = (short)1324610318;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1059782656;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)533069825;
				if (num != 0)
				{
				}
				num = (short)1351352320;
				if (num != 0)
				{
				}
				this.trkSysGeneralAskRequired_A44909.Valid = value;
			}
		}

		// Token: 0x170007FE RID: 2046
		// (get) Token: 0x06001022 RID: 4130 RVA: 0x000FD2B8 File Offset: 0x000FB4B8
		// (set) Token: 0x06001023 RID: 4131 RVA: 0x000FD36C File Offset: 0x000FB56C
		public bool TrkSysGeneralAskRequired_A44909_Visible
		{
			get
			{
				short num = (short)1851597817;
				short num2 = num;
				num = (short)475407353;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2016673792;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)290193409;
				if (num != 0)
				{
				}
				num = (short)1252130816;
				if (num != 0)
				{
				}
				return this.trkSysGeneralAskRequired_A44909.Visible;
			}
			set
			{
				short num = (short)963660486;
				short num2 = num;
				num = (short)1066552006;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1086193664;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1994719233;
				if (num != 0)
				{
				}
				num = (short)816054272;
				if (num != 0)
				{
				}
				this.trkSysGeneralAskRequired_A44909.Visible = value;
			}
		}

		// Token: 0x170007FF RID: 2047
		// (get) Token: 0x06001024 RID: 4132 RVA: 0x000FD420 File Offset: 0x000FB620
		// (set) Token: 0x06001025 RID: 4133 RVA: 0x000FD4D4 File Offset: 0x000FB6D4
		public bool TrkSysGeneralAskRequired_A44909_Editable
		{
			get
			{
				short num = (short)1289981181;
				short num2 = num;
				num = (short)1494322429;
				switch (num2 == num)
				{
				default:
				{
					num = (short)48889856;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)42008577;
				if (num != 0)
				{
				}
				num = (short)250085376;
				if (num != 0)
				{
				}
				return this.trkSysGeneralAskRequired_A44909.Editable;
			}
			set
			{
				short num = (short)861697534;
				short num2 = num;
				num = (short)1084651006;
				switch (num2 == num)
				{
				default:
				{
					num = (short)152567808;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)843972608;
				if (num != 0)
				{
				}
				num = (short)2092957697;
				if (num != 0)
				{
				}
				this.trkSysGeneralAskRequired_A44909.Editable = value;
			}
		}

		// Token: 0x17000800 RID: 2048
		// (get) Token: 0x06001026 RID: 4134 RVA: 0x000FD588 File Offset: 0x000FB788
		internal string TrkSysGeneralAskRequired_A44909_UILabel
		{
			get
			{
				short num = (short)959644591;
				short num2 = num;
				num = (short)73204655;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1883439104;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1770651648;
				if (num != 0)
				{
				}
				num = (short)612237313;
				if (num != 0)
				{
				}
				return this.trkSysGeneralAskRequired_A44909.UIName;
			}
		}

		// Token: 0x17000801 RID: 2049
		// (get) Token: 0x06001027 RID: 4135 RVA: 0x000FD63C File Offset: 0x000FB83C
		// (set) Token: 0x06001028 RID: 4136 RVA: 0x000FD6F4 File Offset: 0x000FB8F4
		internal bool TrkSysGeneralAskRequired_A44909_HiddenStatic
		{
			get
			{
				short num = (short)723355966;
				short num2 = num;
				num = (short)627870014;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1365901312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1342570497;
				if (num != 0)
				{
				}
				num = (short)768147456;
				if (num != 0)
				{
				}
				return this.trkSysGeneralAskRequired_A44909.HiddenStatic;
			}
			set
			{
				short num = (short)272815991;
				short num2 = num;
				num = (short)978638711;
				switch (num2 == num)
				{
				default:
				{
					num = (short)609419264;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1483145217;
				if (num != 0)
				{
				}
				num = (short)940310528;
				if (num != 0)
				{
				}
				this.trkSysGeneralAskRequired_A44909.HiddenStatic = value;
			}
		}

		// Token: 0x17000802 RID: 2050
		// (get) Token: 0x06001029 RID: 4137 RVA: 0x000FD7AC File Offset: 0x000FB9AC
		// (set) Token: 0x0600102A RID: 4138 RVA: 0x000FD85C File Offset: 0x000FBA5C
		internal bool TrkSysGeneralAskRequired_A44909_HiddenDynamic
		{
			get
			{
				short num = (short)329629999;
				short num2 = num;
				num = (short)709148975;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1676345344;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1173618689;
				if (num != 0)
				{
				}
				num = (short)427884544;
				if (num != 0)
				{
				}
				return this.trkSysGeneralAskRequired_A44909.HiddenDynamic;
			}
			set
			{
				short num = (short)238026385;
				short num2 = num;
				num = (short)1275133585;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1055195136;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)885063680;
				if (num != 0)
				{
				}
				num = (short)1013645313;
				if (num != 0)
				{
				}
				this.trkSysGeneralAskRequired_A44909.HiddenDynamic = value;
			}
		}

		// Token: 0x17000803 RID: 2051
		// (get) Token: 0x0600102B RID: 4139 RVA: 0x000FD910 File Offset: 0x000FBB10
		public bool TrkSysGeneralAskRequired_A44909_HasDiffs
		{
			get
			{
				short num = (short)48627713;
				if (num != 0)
				{
				}
				num = (short)1967521792;
				short num2 = num;
				num = (short)631075477;
				short num3 = num;
				num = (short)963605141;
				switch (num3 == num)
				{
				}
				num = (short)161021952;
				if (num != 0)
				{
				}
				return this.trkSysGeneralAskRequired_A44909._HasDiffs;
			}
		}

		// Token: 0x17000804 RID: 2052
		// (get) Token: 0x0600102C RID: 4140 RVA: 0x000FD9C0 File Offset: 0x000FBBC0
		// (set) Token: 0x0600102D RID: 4141 RVA: 0x000FDA74 File Offset: 0x000FBC74
		public bool TrkSysGeneralSystemKeyPresent_A9241Value
		{
			get
			{
				short num = (short)456228773;
				short num2 = num;
				num = (short)1620475813;
				switch (num2 == num)
				{
				default:
				{
					num = (short)430702592;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1721368577;
				if (num != 0)
				{
				}
				num = (short)1687748608;
				if (num != 0)
				{
				}
				return this.trkSysGeneralSystemKeyPresent_A9241.Value;
			}
			set
			{
				short num = (short)1879652048;
				short num2 = num;
				num = (short)598161104;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2097741824;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1042415617;
				if (num != 0)
				{
				}
				num = (short)952958976;
				if (num != 0)
				{
				}
				this.trkSysGeneralSystemKeyPresent_A9241.Value = value;
			}
		}

		// Token: 0x17000805 RID: 2053
		// (get) Token: 0x0600102E RID: 4142 RVA: 0x000FDB28 File Offset: 0x000FBD28
		public global::AcpBusinessLayer.AcpField<bool> TrkSysGeneralSystemKeyPresent_A9241
		{
			get
			{
				short num = (short)1893848061;
				short num2 = num;
				num = (short)90821629;
				switch (num2 == num)
				{
				default:
				{
					num = (short)305922048;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)208470017;
				if (num != 0)
				{
				}
				num = (short)537001984;
				if (num != 0)
				{
				}
				return this.trkSysGeneralSystemKeyPresent_A9241;
			}
		}

		// Token: 0x17000806 RID: 2054
		// (get) Token: 0x0600102F RID: 4143 RVA: 0x000FDBD8 File Offset: 0x000FBDD8
		// (set) Token: 0x06001030 RID: 4144 RVA: 0x000FDC8C File Offset: 0x000FBE8C
		public bool TrkSysGeneralSystemKeyPresent_A9241_UIValue
		{
			get
			{
				short num = (short)872132668;
				short num2 = num;
				num = (short)2107224124;
				switch (num2 == num)
				{
				default:
				{
					num = (short)302383104;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1416757249;
				if (num != 0)
				{
				}
				num = (short)384434176;
				if (num != 0)
				{
				}
				return this.trkSysGeneralSystemKeyPresent_A9241.Value;
			}
			set
			{
				short num = (short)163092851;
				short num2 = num;
				num = (short)1288083827;
				switch (num2 == num)
				{
				default:
				{
					num = (short)157089792;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)783745025;
				if (num != 0)
				{
				}
				num = (short)1775566848;
				if (num != 0)
				{
				}
				this.trkSysGeneralSystemKeyPresent_A9241.Value = value;
			}
		}

		// Token: 0x17000807 RID: 2055
		// (get) Token: 0x06001031 RID: 4145 RVA: 0x000FDD48 File Offset: 0x000FBF48
		// (set) Token: 0x06001032 RID: 4146 RVA: 0x000FDE00 File Offset: 0x000FC000
		public bool TrkSysGeneralSystemKeyPresent_A9241_Applicable
		{
			get
			{
				short num = (short)931307461;
				short num2 = num;
				num = (short)1354342341;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1281425408;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1958805505;
				if (num != 0)
				{
				}
				num = (short)24444928;
				if (num != 0)
				{
				}
				return this.trkSysGeneralSystemKeyPresent_A9241.Applicable;
			}
			set
			{
				short num = (short)60055001;
				short num2 = num;
				num = (short)109010393;
				switch (num2 == num)
				{
				default:
				{
					num = (short)680656896;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1169424385;
				if (num != 0)
				{
				}
				num = (short)330760192;
				if (num != 0)
				{
				}
				this.trkSysGeneralSystemKeyPresent_A9241.Applicable = value;
			}
		}

		// Token: 0x17000808 RID: 2056
		// (get) Token: 0x06001033 RID: 4147 RVA: 0x000FDEB8 File Offset: 0x000FC0B8
		// (set) Token: 0x06001034 RID: 4148 RVA: 0x000FDF6C File Offset: 0x000FC16C
		public bool TrkSysGeneralSystemKeyPresent_A9241_Valid
		{
			get
			{
				short num = (short)293536957;
				short num2 = num;
				num = (short)1673921725;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1065615360;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)563085313;
				if (num != 0)
				{
				}
				num = (short)1938292736;
				if (num != 0)
				{
				}
				return this.trkSysGeneralSystemKeyPresent_A9241.Valid;
			}
			set
			{
				short num = (short)1245602522;
				short num2 = num;
				num = (short)1155162842;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1548615680;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1068105729;
				if (num != 0)
				{
				}
				num = (short)880672768;
				if (num != 0)
				{
				}
				this.trkSysGeneralSystemKeyPresent_A9241.Valid = value;
			}
		}

		// Token: 0x17000809 RID: 2057
		// (get) Token: 0x06001035 RID: 4149 RVA: 0x000FE024 File Offset: 0x000FC224
		// (set) Token: 0x06001036 RID: 4150 RVA: 0x000FE0DC File Offset: 0x000FC2DC
		public bool TrkSysGeneralSystemKeyPresent_A9241_Visible
		{
			get
			{
				short num = (short)108205164;
				short num2 = num;
				num = (short)1098060908;
				switch (num2 == num)
				{
				default:
				{
					num = (short)17235968;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1426587649;
				if (num != 0)
				{
				}
				num = (short)762314752;
				if (num != 0)
				{
				}
				return this.trkSysGeneralSystemKeyPresent_A9241.Visible;
			}
			set
			{
				short num = (short)1476722689;
				if (num != 0)
				{
				}
				num = (short)561709056;
				short num2 = num;
				num = (short)1779704369;
				short num3 = num;
				num = (short)10560049;
				switch (num3 == num)
				{
				}
				num = (short)1405681664;
				if (num != 0)
				{
				}
				this.trkSysGeneralSystemKeyPresent_A9241.Visible = value;
			}
		}

		// Token: 0x1700080A RID: 2058
		// (get) Token: 0x06001037 RID: 4151 RVA: 0x000FE190 File Offset: 0x000FC390
		// (set) Token: 0x06001038 RID: 4152 RVA: 0x000FE244 File Offset: 0x000FC444
		public bool TrkSysGeneralSystemKeyPresent_A9241_Editable
		{
			get
			{
				short num = (short)781530567;
				short num2 = num;
				num = (short)1263941063;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1871249408;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1663434753;
				if (num != 0)
				{
				}
				num = (short)761266176;
				if (num != 0)
				{
				}
				return this.trkSysGeneralSystemKeyPresent_A9241.Editable;
			}
			set
			{
				short num = (short)1462186169;
				short num2 = num;
				num = (short)523710649;
				switch (num2 == num)
				{
				default:
				{
					num = (short)487063552;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1097334785;
				if (num != 0)
				{
				}
				num = (short)1441792;
				if (num != 0)
				{
				}
				this.trkSysGeneralSystemKeyPresent_A9241.Editable = value;
			}
		}

		// Token: 0x1700080B RID: 2059
		// (get) Token: 0x06001039 RID: 4153 RVA: 0x000FE2FC File Offset: 0x000FC4FC
		internal string TrkSysGeneralSystemKeyPresent_A9241_UILabel
		{
			get
			{
				short num = (short)1016957844;
				short num2 = num;
				num = (short)1087605652;
				switch (num2 == num)
				{
				default:
				{
					num = (short)377487360;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)784859137;
				if (num != 0)
				{
				}
				num = (short)1688403968;
				if (num != 0)
				{
				}
				return this.trkSysGeneralSystemKeyPresent_A9241.UIName;
			}
		}

		// Token: 0x1700080C RID: 2060
		// (get) Token: 0x0600103A RID: 4154 RVA: 0x000FE3B0 File Offset: 0x000FC5B0
		// (set) Token: 0x0600103B RID: 4155 RVA: 0x000FE464 File Offset: 0x000FC664
		internal bool TrkSysGeneralSystemKeyPresent_A9241_HiddenStatic
		{
			get
			{
				short num = (short)1564909324;
				short num2 = num;
				num = (short)1987092236;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1281753088;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1814560769;
				if (num != 0)
				{
				}
				num = (short)1240465408;
				if (num != 0)
				{
				}
				return this.trkSysGeneralSystemKeyPresent_A9241.HiddenStatic;
			}
			set
			{
				short num = (short)1386385021;
				short num2 = num;
				num = (short)1859620477;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1065484288;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)18219008;
				if (num != 0)
				{
				}
				num = (short)1075249153;
				if (num != 0)
				{
				}
				this.trkSysGeneralSystemKeyPresent_A9241.HiddenStatic = value;
			}
		}

		// Token: 0x1700080D RID: 2061
		// (get) Token: 0x0600103C RID: 4156 RVA: 0x000FE51C File Offset: 0x000FC71C
		// (set) Token: 0x0600103D RID: 4157 RVA: 0x000FE5D0 File Offset: 0x000FC7D0
		internal bool TrkSysGeneralSystemKeyPresent_A9241_HiddenDynamic
		{
			get
			{
				short num = (short)339967621;
				short num2 = num;
				num = (short)1046969989;
				switch (num2 == num)
				{
				default:
				{
					num = (short)867041280;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1545994240;
				if (num != 0)
				{
				}
				num = (short)886177793;
				if (num != 0)
				{
				}
				return this.trkSysGeneralSystemKeyPresent_A9241.HiddenDynamic;
			}
			set
			{
				short num = (short)1662503036;
				short num2 = num;
				num = (short)1583597692;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1053229056;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)861536257;
				if (num != 0)
				{
				}
				num = (short)798031872;
				if (num != 0)
				{
				}
				this.trkSysGeneralSystemKeyPresent_A9241.HiddenDynamic = value;
			}
		}

		// Token: 0x1700080E RID: 2062
		// (get) Token: 0x0600103E RID: 4158 RVA: 0x000FE688 File Offset: 0x000FC888
		public bool TrkSysGeneralSystemKeyPresent_A9241_HasDiffs
		{
			get
			{
				short num = (short)840113051;
				short num2 = num;
				num = (short)268311451;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1471348736;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)619511808;
				if (num != 0)
				{
				}
				num = (short)486998017;
				if (num != 0)
				{
				}
				return this.trkSysGeneralSystemKeyPresent_A9241._HasDiffs;
			}
		}

		// Token: 0x1700080F RID: 2063
		// (get) Token: 0x0600103F RID: 4159 RVA: 0x000FE73C File Offset: 0x000FC93C
		// (set) Token: 0x06001040 RID: 4160 RVA: 0x000FE7F4 File Offset: 0x000FC9F4
		public int TrkSysGeneralSystemType_A9252Value
		{
			get
			{
				short num = (short)1671954433;
				if (num != 0)
				{
				}
				num = (short)1340145664;
				short num2 = num;
				num = (short)1743636632;
				short num3 = num;
				num = (short)1236125848;
				switch (num3 == num)
				{
				}
				num = (short)76611584;
				if (num != 0)
				{
				}
				return this.trkSysGeneralSystemType_A9252.Value;
			}
			set
			{
				short num = (short)643448650;
				short num2 = num;
				num = (short)844644170;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1002373120;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1717764097;
				if (num != 0)
				{
				}
				num = (short)1132134400;
				if (num != 0)
				{
				}
				this.trkSysGeneralSystemType_A9252.Value = value;
			}
		}

		// Token: 0x17000810 RID: 2064
		// (get) Token: 0x06001041 RID: 4161 RVA: 0x000FE8A8 File Offset: 0x000FCAA8
		// (set) Token: 0x06001042 RID: 4162 RVA: 0x000FE95C File Offset: 0x000FCB5C
		public string TrkSysGeneralSystemType_A9252_UIValue
		{
			get
			{
				short num = (short)855105501;
				short num2 = num;
				num = (short)994172893;
				switch (num2 == num)
				{
				default:
				{
					num = (short)180158464;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)800980992;
				if (num != 0)
				{
				}
				num = (short)957480961;
				if (num != 0)
				{
				}
				return this.trkSysGeneralSystemType_A9252.UIValue;
			}
			set
			{
				short num = (short)2049179649;
				if (num != 0)
				{
				}
				num = (short)1904214016;
				short num2 = num;
				num = (short)2112321324;
				short num3 = num;
				num = (short)376207148;
				switch (num3 == num)
				{
				}
				num = (short)1593638912;
				if (num != 0)
				{
				}
				this.trkSysGeneralSystemType_A9252.UIValue = value;
			}
		}

		// Token: 0x17000811 RID: 2065
		// (get) Token: 0x06001043 RID: 4163 RVA: 0x000FEA14 File Offset: 0x000FCC14
		public global::AcpBusinessLayer.AcpListField TrkSysGeneralSystemType_A9252
		{
			get
			{
				short num = (short)118116354;
				short num2 = num;
				num = (short)1223184386;
				switch (num2 == num)
				{
				default:
				{
					num = (short)382992384;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1847787521;
				if (num != 0)
				{
				}
				num = (short)1519845376;
				if (num != 0)
				{
				}
				return this.trkSysGeneralSystemType_A9252;
			}
		}

		// Token: 0x17000812 RID: 2066
		// (get) Token: 0x06001044 RID: 4164 RVA: 0x000FEAC4 File Offset: 0x000FCCC4
		// (set) Token: 0x06001045 RID: 4165 RVA: 0x000FEB7C File Offset: 0x000FCD7C
		public bool TrkSysGeneralSystemType_A9252_Applicable
		{
			get
			{
				short num = (short)743272939;
				short num2 = num;
				num = (short)1535930859;
				switch (num2 == num)
				{
				default:
				{
					num = (short)539099136;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1170538497;
				if (num != 0)
				{
				}
				num = (short)1072168960;
				if (num != 0)
				{
				}
				return this.trkSysGeneralSystemType_A9252.Applicable;
			}
			set
			{
				short num = (short)718269844;
				short num2 = num;
				num = (short)1568009620;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1900019712;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1720844288;
				if (num != 0)
				{
				}
				num = (short)38207489;
				if (num != 0)
				{
				}
				this.trkSysGeneralSystemType_A9252.Applicable = value;
			}
		}

		// Token: 0x17000813 RID: 2067
		// (get) Token: 0x06001046 RID: 4166 RVA: 0x000FEC30 File Offset: 0x000FCE30
		// (set) Token: 0x06001047 RID: 4167 RVA: 0x000FECE4 File Offset: 0x000FCEE4
		public bool TrkSysGeneralSystemType_A9252_Valid
		{
			get
			{
				short num = (short)2047573053;
				short num2 = num;
				num = (short)2106293309;
				switch (num2 == num)
				{
				default:
				{
					num = (short)774111232;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)613416960;
				if (num != 0)
				{
				}
				num = (short)1706491905;
				if (num != 0)
				{
				}
				return this.trkSysGeneralSystemType_A9252.Valid;
			}
			set
			{
				short num = (short)396292483;
				short num2 = num;
				num = (short)522842499;
				switch (num2 == num)
				{
				default:
				{
					num = (short)239599616;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1343684608;
				if (num != 0)
				{
				}
				num = (short)348979201;
				if (num != 0)
				{
				}
				this.trkSysGeneralSystemType_A9252.Valid = value;
			}
		}

		// Token: 0x17000814 RID: 2068
		// (get) Token: 0x06001048 RID: 4168 RVA: 0x000FED98 File Offset: 0x000FCF98
		// (set) Token: 0x06001049 RID: 4169 RVA: 0x000FEE4C File Offset: 0x000FD04C
		public bool TrkSysGeneralSystemType_A9252_Visible
		{
			get
			{
				short num = (short)1556377463;
				short num2 = num;
				num = (short)803630967;
				switch (num2 == num)
				{
				default:
				{
					num = (short)697958400;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1362558977;
				if (num != 0)
				{
				}
				num = (short)924844032;
				if (num != 0)
				{
				}
				return this.trkSysGeneralSystemType_A9252.Visible;
			}
			set
			{
				short num = (short)169609499;
				short num2 = num;
				num = (short)2123893019;
				switch (num2 == num)
				{
				default:
				{
					num = (short)440401920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1931608065;
				if (num != 0)
				{
				}
				num = (short)1633681408;
				if (num != 0)
				{
				}
				this.trkSysGeneralSystemType_A9252.Visible = value;
			}
		}

		// Token: 0x17000815 RID: 2069
		// (get) Token: 0x0600104A RID: 4170 RVA: 0x000FEF00 File Offset: 0x000FD100
		// (set) Token: 0x0600104B RID: 4171 RVA: 0x000FEFB4 File Offset: 0x000FD1B4
		public bool TrkSysGeneralSystemType_A9252_Editable
		{
			get
			{
				short num = (short)1523069245;
				short num2 = num;
				num = (short)721105213;
				switch (num2 == num)
				{
				}
				num = (short)565641217;
				if (num != 0)
				{
				}
				num = (short)512884736;
				if (num != 0)
				{
				}
				num = (short)1762918400;
				short num3 = num;
				return this.trkSysGeneralSystemType_A9252.Editable;
			}
			set
			{
				short num = (short)1815200802;
				short num2 = num;
				num = (short)1487062050;
				switch (num2 == num)
				{
				}
				num = (short)1229062145;
				if (num != 0)
				{
				}
				num = (short)1701838848;
				if (num != 0)
				{
				}
				num = (short)2063269888;
				short num3 = num;
				this.trkSysGeneralSystemType_A9252.Editable = value;
			}
		}

		// Token: 0x17000816 RID: 2070
		// (get) Token: 0x0600104C RID: 4172 RVA: 0x000FF068 File Offset: 0x000FD268
		internal string TrkSysGeneralSystemType_A9252_UILabel
		{
			get
			{
				short num = (short)80429775;
				short num2 = num;
				num = (short)1771455183;
				switch (num2 == num)
				{
				}
				num = (short)1806434305;
				if (num != 0)
				{
				}
				num = (short)1758134272;
				if (num != 0)
				{
				}
				num = (short)1439563776;
				short num3 = num;
				return this.trkSysGeneralSystemType_A9252.UIName;
			}
		}

		// Token: 0x17000817 RID: 2071
		// (get) Token: 0x0600104D RID: 4173 RVA: 0x000FF120 File Offset: 0x000FD320
		// (set) Token: 0x0600104E RID: 4174 RVA: 0x000FF1D4 File Offset: 0x000FD3D4
		internal bool TrkSysGeneralSystemType_A9252_HiddenStatic
		{
			get
			{
				short num = (short)1231692180;
				short num2 = num;
				num = (short)871768468;
				switch (num2 == num)
				{
				}
				num = (short)1705050113;
				if (num != 0)
				{
				}
				num = (short)1134297088;
				if (num != 0)
				{
				}
				num = (short)1825701888;
				short num3 = num;
				return this.trkSysGeneralSystemType_A9252.HiddenStatic;
			}
			set
			{
				short num = (short)963709612;
				short num2 = num;
				num = (short)1522535084;
				switch (num2 == num)
				{
				}
				num = (short)1181548545;
				if (num != 0)
				{
				}
				num = (short)1847984128;
				if (num != 0)
				{
				}
				num = (short)1671823360;
				short num3 = num;
				this.trkSysGeneralSystemType_A9252.HiddenStatic = value;
			}
		}

		// Token: 0x17000818 RID: 2072
		// (get) Token: 0x0600104F RID: 4175 RVA: 0x000FF28C File Offset: 0x000FD48C
		// (set) Token: 0x06001050 RID: 4176 RVA: 0x000FF340 File Offset: 0x000FD540
		internal bool TrkSysGeneralSystemType_A9252_HiddenDynamic
		{
			get
			{
				short num = (short)605326246;
				short num2 = num;
				num = (short)1525124006;
				switch (num2 == num)
				{
				}
				num = (short)2134507521;
				if (num != 0)
				{
				}
				num = (short)1925316608;
				if (num != 0)
				{
				}
				num = (short)1285554176;
				short num3 = num;
				return this.trkSysGeneralSystemType_A9252.HiddenDynamic;
			}
			set
			{
				short num = (short)1679059450;
				short num2 = num;
				num = (short)779774458;
				switch (num2 == num)
				{
				}
				num = (short)2131361792;
				if (num != 0)
				{
				}
				num = (short)1603928065;
				if (num != 0)
				{
				}
				num = (short)304414720;
				short num3 = num;
				this.trkSysGeneralSystemType_A9252.HiddenDynamic = value;
			}
		}

		// Token: 0x17000819 RID: 2073
		// (get) Token: 0x06001051 RID: 4177 RVA: 0x000FF3F8 File Offset: 0x000FD5F8
		public bool TrkSysGeneralSystemType_A9252_HasDiffs
		{
			get
			{
				short num = (short)504145104;
				short num2 = num;
				num = (short)745252048;
				switch (num2 == num)
				{
				}
				num = (short)419823617;
				if (num != 0)
				{
				}
				num = (short)677707776;
				if (num != 0)
				{
				}
				num = (short)1724252160;
				short num3 = num;
				return this.trkSysGeneralSystemType_A9252._HasDiffs;
			}
		}

		// Token: 0x1700081A RID: 2074
		// (get) Token: 0x06001052 RID: 4178 RVA: 0x000FF4AC File Offset: 0x000FD6AC
		// (set) Token: 0x06001053 RID: 4179 RVA: 0x000FF560 File Offset: 0x000FD760
		public int TrkSysGeneralRFSSDebounceTimersec_A8979Value
		{
			get
			{
				short num = (short)1268711425;
				if (num != 0)
				{
				}
				num = (short)1210111929;
				short num2 = num;
				num = (short)975820729;
				switch (num2 == num)
				{
				}
				num = (short)92078080;
				if (num != 0)
				{
				}
				num = (short)1455751168;
				short num3 = num;
				return this.trkSysGeneralRFSSDebounceTimersec_A8979.Value;
			}
			set
			{
				short num = (short)911157273;
				short num2 = num;
				num = (short)599074841;
				switch (num2 == num)
				{
				}
				num = (short)2037579777;
				if (num != 0)
				{
				}
				num = (short)1008467968;
				if (num != 0)
				{
				}
				num = (short)79101952;
				short num3 = num;
				this.trkSysGeneralRFSSDebounceTimersec_A8979.Value = value;
			}
		}

		// Token: 0x1700081B RID: 2075
		// (get) Token: 0x06001054 RID: 4180 RVA: 0x000FF618 File Offset: 0x000FD818
		public global::AcpBusinessLayer.AcpSimpleRangeField TrkSysGeneralRFSSDebounceTimersec_A8979
		{
			get
			{
				short num = (short)1376446450;
				short num2 = num;
				num = (short)1442637810;
				switch (num2 == num)
				{
				}
				num = (short)1314586624;
				if (num != 0)
				{
				}
				num = (short)1031536641;
				if (num != 0)
				{
				}
				num = (short)1926430720;
				short num3 = num;
				return this.trkSysGeneralRFSSDebounceTimersec_A8979;
			}
		}

		// Token: 0x1700081C RID: 2076
		// (get) Token: 0x06001055 RID: 4181 RVA: 0x000FF6C8 File Offset: 0x000FD8C8
		// (set) Token: 0x06001056 RID: 4182 RVA: 0x000FF780 File Offset: 0x000FD980
		public string TrkSysGeneralRFSSDebounceTimersec_A8979_UIValue
		{
			get
			{
				short num = (short)1238384679;
				short num2 = num;
				num = (short)1682653223;
				switch (num2 == num)
				{
				}
				num = (short)2040922112;
				if (num != 0)
				{
				}
				num = (short)1394999297;
				if (num != 0)
				{
				}
				num = (short)1776418816;
				short num3 = num;
				return this.trkSysGeneralRFSSDebounceTimersec_A8979.UIValue;
			}
			set
			{
				short num = (short)1559875903;
				short num2 = num;
				num = (short)1239011647;
				switch (num2 == num)
				{
				}
				num = (short)1409220609;
				if (num != 0)
				{
				}
				num = (short)86179840;
				if (num != 0)
				{
				}
				num = (short)1984954368;
				short num3 = num;
				this.trkSysGeneralRFSSDebounceTimersec_A8979.UIValue = value;
			}
		}

		// Token: 0x1700081D RID: 2077
		// (get) Token: 0x06001057 RID: 4183 RVA: 0x000FF834 File Offset: 0x000FDA34
		// (set) Token: 0x06001058 RID: 4184 RVA: 0x000FF8E8 File Offset: 0x000FDAE8
		internal int TrkSysGeneralRFSSDebounceTimersec_A8979Min
		{
			get
			{
				short num = (short)68900936;
				short num2 = num;
				num = (short)1403738184;
				switch (num2 == num)
				{
				}
				num = (short)375980033;
				if (num != 0)
				{
				}
				num = (short)815202304;
				if (num != 0)
				{
				}
				num = (short)1945436160;
				short num3 = num;
				return this.trkSysGeneralRFSSDebounceTimersec_A8979.Min;
			}
			set
			{
				short num = (short)1024119005;
				short num2 = num;
				num = (short)1620037853;
				switch (num2 == num)
				{
				}
				num = (short)63045633;
				if (num != 0)
				{
				}
				num = (short)722731008;
				if (num != 0)
				{
				}
				num = (short)2069757952;
				short num3 = num;
				this.trkSysGeneralRFSSDebounceTimersec_A8979.Min = value;
			}
		}

		// Token: 0x1700081E RID: 2078
		// (get) Token: 0x06001059 RID: 4185 RVA: 0x000FF99C File Offset: 0x000FDB9C
		// (set) Token: 0x0600105A RID: 4186 RVA: 0x000FFA4C File Offset: 0x000FDC4C
		internal int TrkSysGeneralRFSSDebounceTimersec_A8979Max
		{
			get
			{
				short num = (short)705359410;
				short num2 = num;
				num = (short)2099506738;
				switch (num2 == num)
				{
				}
				num = (short)1882259456;
				if (num != 0)
				{
				}
				num = (short)948305921;
				if (num != 0)
				{
				}
				num = (short)491257856;
				short num3 = num;
				return this.trkSysGeneralRFSSDebounceTimersec_A8979.Max;
			}
			set
			{
				short num = (short)1211564033;
				if (num != 0)
				{
				}
				num = (short)328473101;
				short num2 = num;
				num = (short)1534401037;
				switch (num2 == num)
				{
				}
				num = (short)1328742400;
				if (num != 0)
				{
				}
				num = (short)1930887168;
				short num3 = num;
				this.trkSysGeneralRFSSDebounceTimersec_A8979.Max = value;
			}
		}

		// Token: 0x1700081F RID: 2079
		// (get) Token: 0x0600105B RID: 4187 RVA: 0x000FFB00 File Offset: 0x000FDD00
		// (set) Token: 0x0600105C RID: 4188 RVA: 0x000FFBB8 File Offset: 0x000FDDB8
		internal int TrkSysGeneralRFSSDebounceTimersec_A8979Step
		{
			get
			{
				short num = (short)603193705;
				short num2 = num;
				num = (short)360055145;
				switch (num2 == num)
				{
				}
				num = (short)1959198720;
				if (num != 0)
				{
				}
				num = (short)132972545;
				if (num != 0)
				{
				}
				num = (short)1751711744;
				short num3 = num;
				return this.trkSysGeneralRFSSDebounceTimersec_A8979.StepSize;
			}
			set
			{
				short num = (short)1966200561;
				short num2 = num;
				num = (short)1035589361;
				switch (num2 == num)
				{
				}
				num = (short)1602355201;
				if (num != 0)
				{
				}
				num = (short)317915136;
				if (num != 0)
				{
				}
				num = (short)795475968;
				short num3 = num;
				this.trkSysGeneralRFSSDebounceTimersec_A8979.StepSize = value;
			}
		}

		// Token: 0x17000820 RID: 2080
		// (get) Token: 0x0600105D RID: 4189 RVA: 0x000FFC6C File Offset: 0x000FDE6C
		// (set) Token: 0x0600105E RID: 4190 RVA: 0x000FFD24 File Offset: 0x000FDF24
		public bool TrkSysGeneralRFSSDebounceTimersec_A8979_Applicable
		{
			get
			{
				short num = (short)1444508978;
				short num2 = num;
				num = (short)721188146;
				switch (num2 == num)
				{
				}
				num = (short)860684288;
				if (num != 0)
				{
				}
				num = (short)1768882177;
				if (num != 0)
				{
				}
				num = (short)502398976;
				short num3 = num;
				return this.trkSysGeneralRFSSDebounceTimersec_A8979.Applicable;
			}
			set
			{
				short num = (short)1154484921;
				short num2 = num;
				num = (short)811862713;
				switch (num2 == num)
				{
				}
				num = (short)2008547328;
				if (num != 0)
				{
				}
				num = (short)1992556545;
				if (num != 0)
				{
				}
				num = (short)1321533440;
				short num3 = num;
				this.trkSysGeneralRFSSDebounceTimersec_A8979.Applicable = value;
			}
		}

		// Token: 0x17000821 RID: 2081
		// (get) Token: 0x0600105F RID: 4191 RVA: 0x000FFDD8 File Offset: 0x000FDFD8
		// (set) Token: 0x06001060 RID: 4192 RVA: 0x000FFE88 File Offset: 0x000FE088
		public bool TrkSysGeneralRFSSDebounceTimersec_A8979_Valid
		{
			get
			{
				short num = (short)1657405441;
				if (num != 0)
				{
				}
				num = (short)1302793978;
				short num2 = num;
				num = (short)696127226;
				switch (num2 == num)
				{
				}
				num = (short)1060044800;
				if (num != 0)
				{
				}
				num = (short)1254162432;
				short num3 = num;
				return this.trkSysGeneralRFSSDebounceTimersec_A8979.Valid;
			}
			set
			{
				short num = (short)1525654932;
				short num2 = num;
				num = (short)268674452;
				switch (num2 == num)
				{
				}
				num = (short)2089156609;
				if (num != 0)
				{
				}
				num = (short)1642135552;
				if (num != 0)
				{
				}
				num = (short)454688768;
				short num3 = num;
				this.trkSysGeneralRFSSDebounceTimersec_A8979.Valid = value;
			}
		}

		// Token: 0x17000822 RID: 2082
		// (get) Token: 0x06001061 RID: 4193 RVA: 0x000FFF40 File Offset: 0x000FE140
		// (set) Token: 0x06001062 RID: 4194 RVA: 0x000FFFF8 File Offset: 0x000FE1F8
		public bool TrkSysGeneralRFSSDebounceTimersec_A8979_Visible
		{
			get
			{
				short num = (short)190330361;
				short num2 = num;
				num = (short)1437873657;
				switch (num2 == num)
				{
				}
				num = (short)2141454336;
				if (num != 0)
				{
				}
				num = (short)273416193;
				if (num != 0)
				{
				}
				num = (short)1446182912;
				short num3 = num;
				return this.trkSysGeneralRFSSDebounceTimersec_A8979.Visible;
			}
			set
			{
				short num = (short)55325514;
				short num2 = num;
				num = (short)160183114;
				switch (num2 == num)
				{
				}
				num = (short)195690497;
				if (num != 0)
				{
				}
				num = (short)1213595648;
				if (num != 0)
				{
				}
				num = (short)85852160;
				short num3 = num;
				this.trkSysGeneralRFSSDebounceTimersec_A8979.Visible = value;
			}
		}

		// Token: 0x17000823 RID: 2083
		// (get) Token: 0x06001063 RID: 4195 RVA: 0x001000AC File Offset: 0x000FE2AC
		// (set) Token: 0x06001064 RID: 4196 RVA: 0x00100160 File Offset: 0x000FE360
		public bool TrkSysGeneralRFSSDebounceTimersec_A8979_Editable
		{
			get
			{
				short num = (short)2117312456;
				short num2 = num;
				num = (short)1479712712;
				switch (num2 == num)
				{
				}
				num = (short)97058816;
				if (num != 0)
				{
				}
				num = (short)868876289;
				if (num != 0)
				{
				}
				num = (short)765394944;
				short num3 = num;
				return this.trkSysGeneralRFSSDebounceTimersec_A8979.Editable;
			}
			set
			{
				short num = (short)486195107;
				short num2 = num;
				num = (short)1263714211;
				switch (num2 == num)
				{
				}
				num = (short)652410881;
				if (num != 0)
				{
				}
				num = (short)52690944;
				if (num != 0)
				{
				}
				num = (short)106954752;
				short num3 = num;
				this.trkSysGeneralRFSSDebounceTimersec_A8979.Editable = value;
			}
		}

		// Token: 0x17000824 RID: 2084
		// (get) Token: 0x06001065 RID: 4197 RVA: 0x00100214 File Offset: 0x000FE414
		internal string TrkSysGeneralRFSSDebounceTimersec_A8979_UILabel
		{
			get
			{
				short num = (short)1267696635;
				short num2 = num;
				num = (short)647791611;
				switch (num2 == num)
				{
				}
				num = (short)444989441;
				if (num != 0)
				{
				}
				num = (short)923860992;
				if (num != 0)
				{
				}
				num = (short)1144651776;
				short num3 = num;
				return this.trkSysGeneralRFSSDebounceTimersec_A8979.UIName;
			}
		}

		// Token: 0x17000825 RID: 2085
		// (get) Token: 0x06001066 RID: 4198 RVA: 0x001002CC File Offset: 0x000FE4CC
		// (set) Token: 0x06001067 RID: 4199 RVA: 0x0010037C File Offset: 0x000FE57C
		internal bool TrkSysGeneralRFSSDebounceTimersec_A8979_HiddenStatic
		{
			get
			{
				short num = (short)89210448;
				short num2 = num;
				num = (short)1177566800;
				switch (num2 == num)
				{
				}
				num = (short)1793130496;
				if (num != 0)
				{
				}
				num = (short)1346437121;
				if (num != 0)
				{
				}
				num = (short)1002569728;
				short num3 = num;
				return this.trkSysGeneralRFSSDebounceTimersec_A8979.HiddenStatic;
			}
			set
			{
				short num = (short)660253662;
				short num2 = num;
				num = (short)307276766;
				switch (num2 == num)
				{
				}
				num = (short)1345650689;
				if (num != 0)
				{
				}
				num = (short)1034682368;
				if (num != 0)
				{
				}
				num = (short)266076160;
				short num3 = num;
				this.trkSysGeneralRFSSDebounceTimersec_A8979.HiddenStatic = value;
			}
		}

		// Token: 0x17000826 RID: 2086
		// (get) Token: 0x06001068 RID: 4200 RVA: 0x00100434 File Offset: 0x000FE634
		// (set) Token: 0x06001069 RID: 4201 RVA: 0x001004E8 File Offset: 0x000FE6E8
		internal bool TrkSysGeneralRFSSDebounceTimersec_A8979_HiddenDynamic
		{
			get
			{
				short num = (short)453714824;
				short num2 = num;
				num = (short)1012671368;
				switch (num2 == num)
				{
				}
				num = (short)812449793;
				if (num != 0)
				{
				}
				num = (short)1885339648;
				if (num != 0)
				{
				}
				num = (short)400883712;
				short num3 = num;
				return this.trkSysGeneralRFSSDebounceTimersec_A8979.HiddenDynamic;
			}
			set
			{
				short num = (short)501312597;
				short num2 = num;
				num = (short)1995140181;
				switch (num2 == num)
				{
				}
				num = (short)1945174017;
				if (num != 0)
				{
				}
				num = (short)865927168;
				if (num != 0)
				{
				}
				num = (short)114294784;
				short num3 = num;
				this.trkSysGeneralRFSSDebounceTimersec_A8979.HiddenDynamic = value;
			}
		}

		// Token: 0x17000827 RID: 2087
		// (get) Token: 0x0600106A RID: 4202 RVA: 0x0010059C File Offset: 0x000FE79C
		public bool TrkSysGeneralRFSSDebounceTimersec_A8979_HasDiffs
		{
			get
			{
				short num = (short)195401030;
				short num2 = num;
				num = (short)1544262982;
				switch (num2 == num)
				{
				}
				num = (short)197459969;
				if (num != 0)
				{
				}
				num = (short)1986330624;
				if (num != 0)
				{
				}
				num = (short)663224320;
				short num3 = num;
				return this.trkSysGeneralRFSSDebounceTimersec_A8979._HasDiffs;
			}
		}

		// Token: 0x17000828 RID: 2088
		// (get) Token: 0x0600106B RID: 4203 RVA: 0x00100650 File Offset: 0x000FE850
		// (set) Token: 0x0600106C RID: 4204 RVA: 0x00100704 File Offset: 0x000FE904
		public int TrkSysGeneralRFSSResponseTimems_A8981Value
		{
			get
			{
				short num = (short)918487041;
				if (num != 0)
				{
				}
				num = (short)1853053375;
				short num2 = num;
				num = (short)804018623;
				switch (num2 == num)
				{
				}
				num = (short)2056192000;
				if (num != 0)
				{
				}
				num = (short)13565952;
				short num3 = num;
				return this.trkSysGeneralRFSSResponseTimems_A8981.Value;
			}
			set
			{
				short num = (short)1638064942;
				short num2 = num;
				num = (short)1031529262;
				switch (num2 == num)
				{
				}
				num = (short)453574656;
				if (num != 0)
				{
				}
				num = (short)798556161;
				if (num != 0)
				{
				}
				num = (short)1442119680;
				short num3 = num;
				this.trkSysGeneralRFSSResponseTimems_A8981.Value = value;
			}
		}

		// Token: 0x17000829 RID: 2089
		// (get) Token: 0x0600106D RID: 4205 RVA: 0x001007BC File Offset: 0x000FE9BC
		public global::AcpBusinessLayer.AcpSimpleRangeField TrkSysGeneralRFSSResponseTimems_A8981
		{
			get
			{
				short num = (short)803560974;
				short num2 = num;
				num = (short)1057054222;
				switch (num2 == num)
				{
				}
				num = (short)1203109888;
				if (num != 0)
				{
				}
				num = (short)1619853313;
				if (num != 0)
				{
				}
				num = (short)5570560;
				short num3 = num;
				return this.trkSysGeneralRFSSResponseTimems_A8981;
			}
		}

		// Token: 0x1700082A RID: 2090
		// (get) Token: 0x0600106E RID: 4206 RVA: 0x00100868 File Offset: 0x000FEA68
		// (set) Token: 0x0600106F RID: 4207 RVA: 0x00100918 File Offset: 0x000FEB18
		public string TrkSysGeneralRFSSResponseTimems_A8981_UIValue
		{
			get
			{
				short num = (short)1450308343;
				short num2 = num;
				num = (short)1240199927;
				switch (num2 == num)
				{
				}
				num = (short)1308164097;
				if (num != 0)
				{
				}
				num = (short)37486592;
				if (num != 0)
				{
				}
				num = (short)1342308352;
				short num3 = num;
				return this.trkSysGeneralRFSSResponseTimems_A8981.UIValue;
			}
			set
			{
				short num = (short)958664484;
				short num2 = num;
				num = (short)1450184484;
				switch (num2 == num)
				{
				}
				num = (short)2555904;
				if (num != 0)
				{
				}
				num = (short)1690370049;
				if (num != 0)
				{
				}
				num = (short)615710720;
				short num3 = num;
				this.trkSysGeneralRFSSResponseTimems_A8981.UIValue = value;
			}
		}

		// Token: 0x1700082B RID: 2091
		// (get) Token: 0x06001070 RID: 4208 RVA: 0x001009CC File Offset: 0x000FEBCC
		// (set) Token: 0x06001071 RID: 4209 RVA: 0x00100A84 File Offset: 0x000FEC84
		internal int TrkSysGeneralRFSSResponseTimems_A8981Min
		{
			get
			{
				short num = (short)99614721;
				if (num != 0)
				{
				}
				num = (short)1499234535;
				short num2 = num;
				num = (short)1232961767;
				switch (num2 == num)
				{
				}
				num = (short)983760896;
				if (num != 0)
				{
				}
				num = (short)1137639424;
				short num3 = num;
				return this.trkSysGeneralRFSSResponseTimems_A8981.Min;
			}
			set
			{
				short num = (short)1702368102;
				short num2 = num;
				num = (short)156767078;
				switch (num2 == num)
				{
				}
				num = (short)1122435073;
				if (num != 0)
				{
				}
				num = (short)1852440576;
				if (num != 0)
				{
				}
				num = (short)700186624;
				short num3 = num;
				this.trkSysGeneralRFSSResponseTimems_A8981.Min = value;
			}
		}

		// Token: 0x1700082C RID: 2092
		// (get) Token: 0x06001072 RID: 4210 RVA: 0x00100B38 File Offset: 0x000FED38
		// (set) Token: 0x06001073 RID: 4211 RVA: 0x00100BEC File Offset: 0x000FEDEC
		internal int TrkSysGeneralRFSSResponseTimems_A8981Max
		{
			get
			{
				short num = (short)551813121;
				if (num != 0)
				{
				}
				num = (short)2006787202;
				short num2 = num;
				num = (short)1245652098;
				switch (num2 == num)
				{
				}
				num = (short)2023161856;
				if (num != 0)
				{
				}
				num = (short)149159936;
				short num3 = num;
				return this.trkSysGeneralRFSSResponseTimems_A8981.Max;
			}
			set
			{
				short num = (short)1987566004;
				short num2 = num;
				num = (short)982636980;
				switch (num2 == num)
				{
				}
				num = (short)498860033;
				if (num != 0)
				{
				}
				num = (short)1219559424;
				if (num != 0)
				{
				}
				num = (short)1067515904;
				short num3 = num;
				this.trkSysGeneralRFSSResponseTimems_A8981.Max = value;
			}
		}

		// Token: 0x1700082D RID: 2093
		// (get) Token: 0x06001074 RID: 4212 RVA: 0x00100CA4 File Offset: 0x000FEEA4
		// (set) Token: 0x06001075 RID: 4213 RVA: 0x00100D58 File Offset: 0x000FEF58
		internal int TrkSysGeneralRFSSResponseTimems_A8981Step
		{
			get
			{
				short num = (short)612106241;
				if (num != 0)
				{
				}
				num = (short)1537208514;
				short num2 = num;
				num = (short)537653442;
				switch (num2 == num)
				{
				}
				num = (short)1150025728;
				if (num != 0)
				{
				}
				num = (short)1644363776;
				short num3 = num;
				return this.trkSysGeneralRFSSResponseTimems_A8981.StepSize;
			}
			set
			{
				short num = (short)1530917762;
				short num2 = num;
				num = (short)876868482;
				switch (num2 == num)
				{
				}
				num = (short)1862664193;
				if (num != 0)
				{
				}
				num = (short)1181220864;
				if (num != 0)
				{
				}
				num = (short)1952120832;
				short num3 = num;
				this.trkSysGeneralRFSSResponseTimems_A8981.StepSize = value;
			}
		}

		// Token: 0x1700082E RID: 2094
		// (get) Token: 0x06001076 RID: 4214 RVA: 0x00100E0C File Offset: 0x000FF00C
		// (set) Token: 0x06001077 RID: 4215 RVA: 0x00100EC0 File Offset: 0x000FF0C0
		public bool TrkSysGeneralRFSSResponseTimems_A8981_Applicable
		{
			get
			{
				short num = (short)2042486950;
				short num2 = num;
				num = (short)1544872102;
				switch (num2 == num)
				{
				}
				num = (short)2061959169;
				if (num != 0)
				{
				}
				num = (short)1693581312;
				if (num != 0)
				{
				}
				num = (short)922877952;
				short num3 = num;
				return this.trkSysGeneralRFSSResponseTimems_A8981.Applicable;
			}
			set
			{
				short num = (short)1254752034;
				short num2 = num;
				num = (short)608698146;
				switch (num2 == num)
				{
				}
				num = (short)1592066048;
				if (num != 0)
				{
				}
				num = (short)1896808449;
				if (num != 0)
				{
				}
				num = (short)664403968;
				short num3 = num;
				this.trkSysGeneralRFSSResponseTimems_A8981.Applicable = value;
			}
		}

		// Token: 0x1700082F RID: 2095
		// (get) Token: 0x06001078 RID: 4216 RVA: 0x00100F78 File Offset: 0x000FF178
		// (set) Token: 0x06001079 RID: 4217 RVA: 0x00101028 File Offset: 0x000FF228
		public bool TrkSysGeneralRFSSResponseTimems_A8981_Valid
		{
			get
			{
				short num = (short)395447965;
				short num2 = num;
				num = (short)1822887581;
				switch (num2 == num)
				{
				}
				num = (short)1969553409;
				if (num != 0)
				{
				}
				num = (short)1721761792;
				if (num != 0)
				{
				}
				num = (short)1129840640;
				short num3 = num;
				return this.trkSysGeneralRFSSResponseTimems_A8981.Valid;
			}
			set
			{
				short num = (short)1632378595;
				short num2 = num;
				num = (short)1200692963;
				switch (num2 == num)
				{
				}
				num = (short)720109569;
				if (num != 0)
				{
				}
				num = (short)135593984;
				short num3 = num;
				num = (short)205389824;
				if (num != 0)
				{
				}
				this.trkSysGeneralRFSSResponseTimems_A8981.Valid = value;
			}
		}

		// Token: 0x17000830 RID: 2096
		// (get) Token: 0x0600107A RID: 4218 RVA: 0x001010E0 File Offset: 0x000FF2E0
		// (set) Token: 0x0600107B RID: 4219 RVA: 0x00101194 File Offset: 0x000FF394
		public bool TrkSysGeneralRFSSResponseTimems_A8981_Visible
		{
			get
			{
				short num = (short)642744100;
				short num2 = num;
				num = (short)875331364;
				switch (num2 == num)
				{
				}
				num = (short)1001127937;
				if (num != 0)
				{
				}
				num = (short)1045102592;
				short num3 = num;
				num = (short)805175296;
				if (num != 0)
				{
				}
				return this.trkSysGeneralRFSSResponseTimems_A8981.Visible;
			}
			set
			{
				short num = (short)1297777592;
				short num2 = num;
				num = (short)2000323512;
				switch (num2 == num)
				{
				}
				num = (short)398393345;
				if (num != 0)
				{
				}
				num = (short)1312686080;
				short num3 = num;
				num = (short)959447040;
				if (num != 0)
				{
				}
				this.trkSysGeneralRFSSResponseTimems_A8981.Visible = value;
			}
		}

		// Token: 0x17000831 RID: 2097
		// (get) Token: 0x0600107C RID: 4220 RVA: 0x00101248 File Offset: 0x000FF448
		// (set) Token: 0x0600107D RID: 4221 RVA: 0x001012FC File Offset: 0x000FF4FC
		public bool TrkSysGeneralRFSSResponseTimems_A8981_Editable
		{
			get
			{
				short num = (short)2071581575;
				short num2 = num;
				num = (short)793891719;
				switch (num2 == num)
				{
				}
				num = (short)932708353;
				if (num != 0)
				{
				}
				num = (short)1560346624;
				short num3 = num;
				num = (short)846397440;
				if (num != 0)
				{
				}
				return this.trkSysGeneralRFSSResponseTimems_A8981.Editable;
			}
			set
			{
				short num = (short)463829716;
				short num2 = num;
				num = (short)338328276;
				switch (num2 == num)
				{
				}
				num = (short)1982332929;
				if (num != 0)
				{
				}
				num = (short)1392246784;
				short num3 = num;
				num = (short)1133903872;
				if (num != 0)
				{
				}
				this.trkSysGeneralRFSSResponseTimems_A8981.Editable = value;
			}
		}

		// Token: 0x17000832 RID: 2098
		// (get) Token: 0x0600107E RID: 4222 RVA: 0x001013B4 File Offset: 0x000FF5B4
		internal string TrkSysGeneralRFSSResponseTimems_A8981_UILabel
		{
			get
			{
				short num = (short)1398800385;
				if (num != 0)
				{
				}
				num = (short)537991826;
				short num2 = num;
				num = (short)999430802;
				switch (num2 == num)
				{
				}
				num = (short)704315392;
				short num3 = num;
				num = (short)1311768576;
				if (num != 0)
				{
				}
				return this.trkSysGeneralRFSSResponseTimems_A8981.UIName;
			}
		}

		// Token: 0x17000833 RID: 2099
		// (get) Token: 0x0600107F RID: 4223 RVA: 0x00101468 File Offset: 0x000FF668
		// (set) Token: 0x06001080 RID: 4224 RVA: 0x0010151C File Offset: 0x000FF71C
		internal bool TrkSysGeneralRFSSResponseTimems_A8981_HiddenStatic
		{
			get
			{
				short num = (short)606796357;
				short num2 = num;
				num = (short)1759115845;
				switch (num2 == num)
				{
				}
				num = (short)1246101505;
				if (num != 0)
				{
				}
				num = (short)288161792;
				short num3 = num;
				num = (short)515112960;
				if (num != 0)
				{
				}
				return this.trkSysGeneralRFSSResponseTimems_A8981.HiddenStatic;
			}
			set
			{
				short num = (short)136117857;
				short num2 = num;
				num = (short)1031863905;
				switch (num2 == num)
				{
				}
				num = (short)789446657;
				if (num != 0)
				{
				}
				num = (short)1013907456;
				short num3 = num;
				num = (short)648937472;
				if (num != 0)
				{
				}
				this.trkSysGeneralRFSSResponseTimems_A8981.HiddenStatic = value;
			}
		}

		// Token: 0x17000834 RID: 2100
		// (get) Token: 0x06001081 RID: 4225 RVA: 0x001015D0 File Offset: 0x000FF7D0
		// (set) Token: 0x06001082 RID: 4226 RVA: 0x00101684 File Offset: 0x000FF884
		internal bool TrkSysGeneralRFSSResponseTimems_A8981_HiddenDynamic
		{
			get
			{
				short num = (short)1552425538;
				short num2 = num;
				num = (short)611852866;
				switch (num2 == num)
				{
				}
				num = (short)1110835201;
				if (num != 0)
				{
				}
				num = (short)2026831872;
				short num3 = num;
				num = (short)167837696;
				if (num != 0)
				{
				}
				return this.trkSysGeneralRFSSResponseTimems_A8981.HiddenDynamic;
			}
			set
			{
				short num = (short)2072977038;
				short num2 = num;
				num = (short)351477390;
				switch (num2 == num)
				{
				}
				num = (short)891748353;
				if (num != 0)
				{
				}
				num = (short)6356992;
				short num3 = num;
				num = (short)389152768;
				if (num != 0)
				{
				}
				this.trkSysGeneralRFSSResponseTimems_A8981.HiddenDynamic = value;
			}
		}

		// Token: 0x17000835 RID: 2101
		// (get) Token: 0x06001083 RID: 4227 RVA: 0x00101738 File Offset: 0x000FF938
		public bool TrkSysGeneralRFSSResponseTimems_A8981_HasDiffs
		{
			get
			{
				short num = (short)846138582;
				short num2 = num;
				num = (short)702942422;
				switch (num2 == num)
				{
				}
				num = (short)1310916609;
				if (num != 0)
				{
				}
				num = (short)1786970112;
				short num3 = num;
				num = (short)1324417024;
				if (num != 0)
				{
				}
				return this.trkSysGeneralRFSSResponseTimems_A8981._HasDiffs;
			}
		}

		// Token: 0x17000836 RID: 2102
		// (get) Token: 0x06001084 RID: 4228 RVA: 0x001017EC File Offset: 0x000FF9EC
		// (set) Token: 0x06001085 RID: 4229 RVA: 0x001018A0 File Offset: 0x000FFAA0
		public int TrkSysGeneralSystemKeyType_A38853Value
		{
			get
			{
				short num = (short)651226697;
				short num2 = num;
				num = (short)41283145;
				switch (num2 == num)
				{
				}
				num = (short)1051983873;
				if (num != 0)
				{
				}
				num = (short)1334902784;
				short num3 = num;
				num = (short)998637568;
				if (num != 0)
				{
				}
				return this.trkSysGeneralSystemKeyType_A38853.Value;
			}
			set
			{
				short num = (short)601647844;
				short num2 = num;
				num = (short)1044409060;
				switch (num2 == num)
				{
				}
				num = (short)783810561;
				if (num != 0)
				{
				}
				num = (short)1634992128;
				short num3 = num;
				num = (short)1373044736;
				if (num != 0)
				{
				}
				this.trkSysGeneralSystemKeyType_A38853.Value = value;
			}
		}

		// Token: 0x17000837 RID: 2103
		// (get) Token: 0x06001086 RID: 4230 RVA: 0x00101958 File Offset: 0x000FFB58
		// (set) Token: 0x06001087 RID: 4231 RVA: 0x00101A0C File Offset: 0x000FFC0C
		public string TrkSysGeneralSystemKeyType_A38853_UIValue
		{
			get
			{
				short num = (short)1269287938;
				short num2 = num;
				num = (short)1300286466;
				switch (num2 == num)
				{
				}
				num = (short)538640385;
				if (num != 0)
				{
				}
				num = (short)658046976;
				short num3 = num;
				num = (short)1414463488;
				if (num != 0)
				{
				}
				return this.trkSysGeneralSystemKeyType_A38853.UIValue;
			}
			set
			{
				short num = (short)776398335;
				short num2 = num;
				num = (short)1330963967;
				switch (num2 == num)
				{
				}
				num = (short)1237581825;
				if (num != 0)
				{
				}
				num = (short)796983296;
				short num3 = num;
				num = (short)1618149376;
				if (num != 0)
				{
				}
				this.trkSysGeneralSystemKeyType_A38853.UIValue = value;
			}
		}

		// Token: 0x17000838 RID: 2104
		// (get) Token: 0x06001088 RID: 4232 RVA: 0x00101AC4 File Offset: 0x000FFCC4
		public global::AcpBusinessLayer.AcpListField TrkSysGeneralSystemKeyType_A38853
		{
			get
			{
				short num = (short)1200580223;
				short num2 = num;
				num = (short)1811506815;
				switch (num2 == num)
				{
				}
				num = (short)700317697;
				if (num != 0)
				{
				}
				num = (short)2130575360;
				short num3 = num;
				num = (short)2083979264;
				if (num != 0)
				{
				}
				return this.trkSysGeneralSystemKeyType_A38853;
			}
		}

		// Token: 0x17000839 RID: 2105
		// (get) Token: 0x06001089 RID: 4233 RVA: 0x00101B70 File Offset: 0x000FFD70
		// (set) Token: 0x0600108A RID: 4234 RVA: 0x00101C24 File Offset: 0x000FFE24
		public bool TrkSysGeneralSystemKeyType_A38853_Applicable
		{
			get
			{
				short num = (short)692595675;
				short num2 = num;
				num = (short)1652435931;
				switch (num2 == num)
				{
				}
				num = (short)1405550593;
				if (num != 0)
				{
				}
				num = (short)2131886080;
				short num3 = num;
				num = (short)1209729024;
				if (num != 0)
				{
				}
				return this.trkSysGeneralSystemKeyType_A38853.Applicable;
			}
			set
			{
				short num = (short)1032193168;
				short num2 = num;
				num = (short)1463616656;
				switch (num2 == num)
				{
				}
				num = (short)1819082752;
				if (num != 0)
				{
				}
				num = (short)2118778880;
				short num3 = num;
				num = (short)1978990593;
				if (num != 0)
				{
				}
				this.trkSysGeneralSystemKeyType_A38853.Applicable = value;
			}
		}

		// Token: 0x1700083A RID: 2106
		// (get) Token: 0x0600108B RID: 4235 RVA: 0x00101CD8 File Offset: 0x000FFED8
		// (set) Token: 0x0600108C RID: 4236 RVA: 0x00101D8C File Offset: 0x000FFF8C
		public bool TrkSysGeneralSystemKeyType_A38853_Valid
		{
			get
			{
				short num = (short)1597012892;
				short num2 = num;
				num = (short)668367772;
				switch (num2 == num)
				{
				}
				num = (short)1003094017;
				if (num != 0)
				{
				}
				num = (short)1098973184;
				short num3 = num;
				num = (short)1979449344;
				if (num != 0)
				{
				}
				return this.trkSysGeneralSystemKeyType_A38853.Valid;
			}
			set
			{
				short num = (short)658090721;
				short num2 = num;
				num = (short)2142087905;
				switch (num2 == num)
				{
				}
				num = (short)1166147585;
				if (num != 0)
				{
				}
				num = (short)93257728;
				short num3 = num;
				num = (short)901513216;
				if (num != 0)
				{
				}
				this.trkSysGeneralSystemKeyType_A38853.Valid = value;
			}
		}

		// Token: 0x1700083B RID: 2107
		// (get) Token: 0x0600108D RID: 4237 RVA: 0x00101E40 File Offset: 0x00100040
		// (set) Token: 0x0600108E RID: 4238 RVA: 0x00101EF8 File Offset: 0x001000F8
		public bool TrkSysGeneralSystemKeyType_A38853_Visible
		{
			get
			{
				short num = (short)842430336;
				short num2 = num;
				num = (short)270759808;
				switch (num2 == num)
				{
				}
				num = (short)602734593;
				if (num != 0)
				{
				}
				num = (short)1648295936;
				short num3 = num;
				num = (short)1369964544;
				if (num != 0)
				{
				}
				return this.trkSysGeneralSystemKeyType_A38853.Visible;
			}
			set
			{
				short num = (short)1146516762;
				short num2 = num;
				num = (short)1219523866;
				switch (num2 == num)
				{
				}
				num = (short)1163395072;
				if (num != 0)
				{
				}
				num = (short)1078591488;
				short num3 = num;
				num = (short)1043267585;
				if (num != 0)
				{
				}
				this.trkSysGeneralSystemKeyType_A38853.Visible = value;
			}
		}

		// Token: 0x1700083C RID: 2108
		// (get) Token: 0x0600108F RID: 4239 RVA: 0x00101FB0 File Offset: 0x001001B0
		// (set) Token: 0x06001090 RID: 4240 RVA: 0x00102064 File Offset: 0x00100264
		public bool TrkSysGeneralSystemKeyType_A38853_Editable
		{
			get
			{
				short num = (short)525955791;
				short num2 = num;
				num = (short)1532261071;
				switch (num2 == num)
				{
				}
				num = (short)910557185;
				if (num != 0)
				{
				}
				num = (short)2125266944;
				short num3 = num;
				num = (short)32833536;
				if (num != 0)
				{
				}
				return this.trkSysGeneralSystemKeyType_A38853.Editable;
			}
			set
			{
				short num = (short)511245114;
				short num2 = num;
				num = (short)64486202;
				switch (num2 == num)
				{
				}
				num = (short)1247805441;
				if (num != 0)
				{
				}
				num = (short)992739328;
				short num3 = num;
				num = (short)320405504;
				if (num != 0)
				{
				}
				this.trkSysGeneralSystemKeyType_A38853.Editable = value;
			}
		}

		// Token: 0x1700083D RID: 2109
		// (get) Token: 0x06001091 RID: 4241 RVA: 0x00102118 File Offset: 0x00100318
		internal string TrkSysGeneralSystemKeyType_A38853_UILabel
		{
			get
			{
				short num = (short)248580840;
				short num2 = num;
				num = (short)1487473384;
				switch (num2 == num)
				{
				}
				num = (short)511442945;
				if (num != 0)
				{
				}
				num = (short)1023737856;
				short num3 = num;
				num = (short)270401536;
				if (num != 0)
				{
				}
				return this.trkSysGeneralSystemKeyType_A38853.UIName;
			}
		}

		// Token: 0x1700083E RID: 2110
		// (get) Token: 0x06001092 RID: 4242 RVA: 0x001021D0 File Offset: 0x001003D0
		// (set) Token: 0x06001093 RID: 4243 RVA: 0x00102288 File Offset: 0x00100488
		internal bool TrkSysGeneralSystemKeyType_A38853_HiddenStatic
		{
			get
			{
				short num = (short)172195969;
				short num2 = num;
				num = (short)52134017;
				switch (num2 == num)
				{
				}
				num = (short)1535639553;
				if (num != 0)
				{
				}
				num = (short)987496448;
				short num3 = num;
				num = (short)248840192;
				if (num != 0)
				{
				}
				return this.trkSysGeneralSystemKeyType_A38853.HiddenStatic;
			}
			set
			{
				short num = (short)348636043;
				short num2 = num;
				num = (short)1516225419;
				switch (num2 == num)
				{
				}
				num = (short)1362034688;
				if (num != 0)
				{
				}
				num = (short)2121138176;
				short num3 = num;
				num = (short)434307073;
				if (num != 0)
				{
				}
				this.trkSysGeneralSystemKeyType_A38853.HiddenStatic = value;
			}
		}

		// Token: 0x1700083F RID: 2111
		// (get) Token: 0x06001094 RID: 4244 RVA: 0x00102340 File Offset: 0x00100540
		// (set) Token: 0x06001095 RID: 4245 RVA: 0x001023F8 File Offset: 0x001005F8
		internal bool TrkSysGeneralSystemKeyType_A38853_HiddenDynamic
		{
			get
			{
				short num = (short)1690325167;
				short num2 = num;
				num = (short)587419823;
				switch (num2 == num)
				{
				}
				num = (short)468910080;
				if (num != 0)
				{
				}
				num = (short)1751842816;
				short num3 = num;
				num = (short)835059713;
				if (num != 0)
				{
				}
				return this.trkSysGeneralSystemKeyType_A38853.HiddenDynamic;
			}
			set
			{
				short num = (short)1609052420;
				short num2 = num;
				num = (short)2064331012;
				switch (num2 == num)
				{
				}
				num = (short)664338433;
				if (num != 0)
				{
				}
				num = (short)1930887168;
				short num3 = num;
				num = (short)1071972352;
				if (num != 0)
				{
				}
				this.trkSysGeneralSystemKeyType_A38853.HiddenDynamic = value;
			}
		}

		// Token: 0x17000840 RID: 2112
		// (get) Token: 0x06001096 RID: 4246 RVA: 0x001024AC File Offset: 0x001006AC
		public bool TrkSysGeneralSystemKeyType_A38853_HasDiffs
		{
			get
			{
				short num = (short)21233665;
				if (num != 0)
				{
				}
				num = (short)1927945784;
				short num2 = num;
				num = (short)1957764664;
				switch (num2 == num)
				{
				}
				num = (short)525860864;
				short num3 = num;
				num = (short)971440128;
				if (num != 0)
				{
				}
				return this.trkSysGeneralSystemKeyType_A38853._HasDiffs;
			}
		}

		// Token: 0x17000841 RID: 2113
		// (get) Token: 0x06001097 RID: 4247 RVA: 0x00102564 File Offset: 0x00100764
		public global::Motorola.MackinawCPS.CoreFeatures.DVRSWide.DVRSWide RefDVRSWide
		{
			get
			{
				short num = (short)1788326418;
				short num2 = num;
				num = (short)763343378;
				switch (num2 == num)
				{
				}
				num = (short)1241645057;
				if (num != 0)
				{
				}
				num = (short)1813774336;
				short num3 = num;
				num = (short)522321920;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(4142)[0] as global::Motorola.MackinawCPS.CoreFeatures.DVRSWide.DVRSWide;
			}
		}

		// Token: 0x17000842 RID: 2114
		// (get) Token: 0x06001098 RID: 4248 RVA: 0x00102620 File Offset: 0x00100820
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide RefRadioWide
		{
			get
			{
				short num = (short)331437395;
				short num2 = num;
				num = (short)119362899;
				switch (num2 == num)
				{
				}
				num = (short)1218117633;
				if (num != 0)
				{
				}
				num = (short)924450816;
				short num3 = num;
				num = (short)757858304;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
			}
		}

		// Token: 0x17000843 RID: 2115
		// (get) Token: 0x06001099 RID: 4249 RVA: 0x001026E0 File Offset: 0x001008E0
		public global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation RefRadioInformation
		{
			get
			{
				short num = (short)1251882023;
				short num2 = num;
				num = (short)1362179111;
				switch (num2 == num)
				{
				}
				num = (short)49414145;
				if (num != 0)
				{
				}
				num = (short)2004221952;
				short num3 = num;
				num = (short)525860864;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation;
			}
		}

		// Token: 0x0600109A RID: 4250 RVA: 0x0010279C File Offset: 0x0010099C
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
				{
					num2 = (short)1850802177;
					if (num2 != 0)
					{
					}
					num2 = (short)1990168875;
					short num3 = num2;
					num2 = (short)40407339;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_5A;
					default:
						num2 = (short)1565851648;
						if (num2 != 0)
						{
						}
						if (base.ParentRecset.ContainerDoc != null)
						{
							num2 = (short)1054408708;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					}
					break;
				}
				case 1:
					return result;
				case 2:
					goto IL_5A;
				case 3:
					if (base.ParentRecset != null)
					{
						num2 = (short)536281090;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 4:
				{
					num2 = (short)581697536;
					short num4 = num2;
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)489226241;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_24;
				IL_5A:
				num2 = (short)1896742912;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)1681326083;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04000422 RID: 1058
		private global::AcpBusinessLayer.AcpListField trkSysGeneralConnectToneHz_A7710;

		// Token: 0x04000423 RID: 1059
		private global::AcpBusinessLayer.AcpListField trkSysGeneralCoverageType_A7782;

		// Token: 0x04000424 RID: 1060
		private global::AcpBusinessLayer.AcpListField trkSysGeneralFailsoftConnectToneHz_A8007;

		// Token: 0x04000425 RID: 1061
		private global::AcpBusinessLayer.AcpSimpleRangeField trkSysGeneralHomeWACNID_A8205;

		// Token: 0x04000426 RID: 1062
		private global::AcpBusinessLayer.AcpSimpleRangeField trkSysLabtoolNetworkID_A8565;

		// Token: 0x04000427 RID: 1063
		private global::AcpBusinessLayer.AcpField<bool> trkSysGeneralNonAdjacentSiteSearch_A8568;

		// Token: 0x04000428 RID: 1064
		private global::AcpBusinessLayer.AcpSimpleRangeField trkSysGeneralRFSSID_A8980;

		// Token: 0x04000429 RID: 1065
		private global::AcpBusinessLayer.AcpSimpleRangeField trkSysGeneralSiteID_A9150;

		// Token: 0x0400042A RID: 1066
		private global::AcpBusinessLayer.AcpSimpleRangeField trkSysGeneralSystemID_A9239;

		// Token: 0x0400042B RID: 1067
		private global::AcpBusinessLayer.AcpListField trkSysGeneralTypeIIFrequencyBand_A12491;

		// Token: 0x0400042C RID: 1068
		private global::AcpBusinessLayer.AcpSimpleRangeField trkSysGeneralUnitID_A12651;

		// Token: 0x0400042D RID: 1069
		private global::AcpBusinessLayer.AcpKeyField trkSysGeneralKeyofTrunkingSystem_A12658;

		// Token: 0x0400042E RID: 1070
		private global::AcpBusinessLayer.AcpRecRefField trkSysGeneralDataProfileSelection_A19449;

		// Token: 0x0400042F RID: 1071
		private global::AcpBusinessLayer.AcpField<bool> trkSysGeneralAskRequired_A44909;

		// Token: 0x04000430 RID: 1072
		private global::AcpBusinessLayer.AcpField<bool> trkSysGeneralSystemKeyPresent_A9241;

		// Token: 0x04000431 RID: 1073
		private global::AcpBusinessLayer.AcpListField trkSysGeneralSystemType_A9252;

		// Token: 0x04000432 RID: 1074
		private global::AcpBusinessLayer.AcpSimpleRangeField trkSysGeneralRFSSDebounceTimersec_A8979;

		// Token: 0x04000433 RID: 1075
		private global::AcpBusinessLayer.AcpSimpleRangeField trkSysGeneralRFSSResponseTimems_A8981;

		// Token: 0x04000434 RID: 1076
		private global::AcpBusinessLayer.AcpListField trkSysGeneralSystemKeyType_A38853;
	}
}
