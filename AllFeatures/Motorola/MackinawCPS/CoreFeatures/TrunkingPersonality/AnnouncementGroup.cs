using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using Motorola.MackinawCPS.CoreFeatures.RadioInformation;
using Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile;
using Motorola.MackinawCPS.CoreFeatures.SecureWide;
using Motorola.MackinawCPS.CoreFeatures.TrunkingSystem;

namespace Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality
{
	// Token: 0x020000AD RID: 173
	[global::System.Serializable]
	public class AnnouncementGroup : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x060015C7 RID: 5575 RVA: 0x0014B950 File Offset: 0x00149B50
		public AnnouncementGroup(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x060015C8 RID: 5576 RVA: 0x0014B96C File Offset: 0x00149B6C
		protected AnnouncementGroup(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x060015C9 RID: 5577 RVA: 0x0014B984 File Offset: 0x00149B84
		public override void Init()
		{
			int a_ = 1;
			short num = (short)28517792;
			short num2 = num;
			num = (short)1374496160;
			switch (num2 == num)
			{
			default:
			{
				num = (short)697106432;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1116340225;
			if (num != 0)
			{
			}
			num = (short)102563840;
			if (num != 0)
			{
			}
			this.trkPerAnnouncementGroupAGKeySelect_A7414 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("雁뛃귅飇꿉뻋迍뻏병믓ꏕ뛗맙맛돝藟賡郣ꇥ髧藩駫黭뇯뗱뿳鏵臷꧹駻鋽旿愁瀃夅䤇㴉㠋㼍␏", a_), global::CommonResources.AcgResources.ID_AGKEYSELECT, null, null, true, false);
			this.trkPerAnnouncementGroupAGKeySelect_A7414.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkPerAnnouncementGroupAGKeySelect_A7414.DataTransferOrder = 68;
			this.trkPerAnnouncementGroupAnnouncementGroup_A7444 = new global::AcpBusinessLayer.AcpCustomRangeField(0, this, global::AllFeatures.CodeplugGuid.b("雁뛃귅飇꿉뻋迍뻏병믓ꏕ뛗맙맛돝藟賡郣ꇥ髧藩駫黭뇯鳱髳駵跷铹鿻鯽淿朁樃爅伇砉挋笍怏䴑唓ℕⰗ⸙⠛", a_), global::CommonResources.AcgResources.ID_ANNOUNCEMENTGROUP, 0, 65534, 1, null, null);
			this.trkPerAnnouncementGroupAnnouncementGroup_A7444.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkPerAnnouncementGroupAnnouncementGroup_A7444.DataTransferOrder = 5;
			this.trkPerAnnouncementGroupAnnouncementGroup_A7444.EvaluateRecRefs = true;
			this.trkPerAnnouncementGroupAnnouncementGroup_A7444.AddCustomValue(0, global::CommonResources.AcgResources.ID_NONE);
			this.trkPerAnnouncementGroupAnnouncementGroup_A7444.ShowHexValue = true;
			this.trkPerAnnouncementGroupAGVoiceSignalType_A7478 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("雁뛃귅飇꿉뻋迍뻏병믓ꏕ뛗맙맛돝藟賡郣ꇥ髧藩駫黭뇯뗱ꋳ駵釷駹駻귽槿攁樃朅搇帉甋縍甏䴑唓ℕⰗⴙ␛", a_), global::CommonResources.AcgResources.ID_AGVOICESIGNALTYPE, global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.LOVs.TrkPerAnnouncementGroupAGVoiceSignalType_A7478LovStrs);
			this.trkPerAnnouncementGroupAGVoiceSignalType_A7478.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.trkPerAnnouncementGroupAGVoiceSignalType_A7478.DataTransferOrder = 6;
			this.trkPerAnnouncementGroupAnnouncementGroupFailsoft_A8597 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("雁뛃귅飇꿉뻋迍뻏병믓ꏕ뛗맙맛돝藟賡郣ꇥ髧藩駫黭뇯鳱髳駵跷铹鿻鯽淿朁樃爅伇砉挋笍怏向甓缕琗椙猛砝吟紡攣ḥᴧጩᬫ", a_), global::CommonResources.AcgResources.ID_TALKGROUPFAILSOFTANNOUNCEMENTGROUPFAILSOFT);
			this.trkPerAnnouncementGroupAnnouncementGroupFailsoft_A8597.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkPerAnnouncementGroupAnnouncementGroupFailsoft_A8597.DataTransferOrder = 12;
			this.trkPerAnnouncementGroupAGSecureClearStrapping_A9089 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("雁뛃귅飇꿉뻋迍뻏병믓ꏕ뛗맙맛돝藟賡郣ꇥ髧藩駫黭뇯뗱ꟳ鏵鯷迹軻鯽䏿渁愃朅稇変砋簍焏我搓缕瘗紙䌛弝᤟ሡᰣἥ", a_), global::CommonResources.AcgResources.ID_AGSECURECLEARSTRAPPING, global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.LOVs.TrkPerAnnouncementGroupAGSecureClearStrapping_A9089LovStrs);
			this.trkPerAnnouncementGroupAGSecureClearStrapping_A9089.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkPerAnnouncementGroupAGSecureClearStrapping_A9089.DataTransferOrder = 16;
			this.trkPerAnnouncementGroupAGFailsoftRxFrequencyMHz_A9582 = new global::AcpBusinessLayer.AcpFrequencyField(170202500, this, global::AllFeatures.CodeplugGuid.b("雁뛃귅飇꿉뻋迍뻏병믓ꏕ뛗맙맛돝藟賡郣ꇥ髧藩駫黭뇯뗱닳韵釷雹迻釽替瘁嘃縅万砉椋缍攏眑稓甕愗圙君搝缟挡ᴣጥဧᠩ", a_), global::CommonResources.AcgResources.ID_TALKGROUPFAILSOFTAGFAILSOFTRXFREQUENCYMHZ, 0, int.MaxValue, 1);
			this.trkPerAnnouncementGroupAGFailsoftRxFrequencyMHz_A9582.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.trkPerAnnouncementGroupAGFailsoftRxFrequencyMHz_A9582.DataTransferOrder = 62;
			this.trkPerAnnouncementGroupAGFailsoftTxFrequencyMHz_A9583 = new global::AcpBusinessLayer.AcpFrequencyField(161202500, this, global::AllFeatures.CodeplugGuid.b("雁뛃귅飇꿉뻋迍뻏병믓ꏕ뛗맙맛돝藟賡郣ꇥ髧藩駫黭뇯뗱닳韵釷雹迻釽替瘁倃縅万砉椋缍攏眑稓甕愗圙君搝缟挡ᴣጥဧᤩ", a_), global::CommonResources.AcgResources.ID_TALKGROUPFAILSOFTAGFAILSOFTTXFREQUENCYMHZ, 0, int.MaxValue, 1);
			this.trkPerAnnouncementGroupAGFailsoftTxFrequencyMHz_A9583.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.trkPerAnnouncementGroupAGFailsoftTxFrequencyMHz_A9583.DataTransferOrder = 63;
			this.trkPerAnnouncementGroupAGSecondaryFSTxFrequencyMHz_A12903 = new global::AcpBusinessLayer.AcpFrequencyField(161202500, this, global::AllFeatures.CodeplugGuid.b("雁뛃귅飇꿉뻋迍뻏병믓ꏕ뛗맙맛돝藟賡郣ꇥ髧藩駫黭뇯뗱ꟳ鏵鯷闹鋻髽懿瀁紃䀅嬇帉琋䠍戏眑攓挕紗琙缛朝洟模帣礥椧ᬩḫᜭ/ı", a_), global::CommonResources.AcgResources.ID_TALKGROUPFAILSOFTAGSECONDARYFSTXFREQUENCYMHZ, 0, int.MaxValue, 1);
			this.trkPerAnnouncementGroupAGSecondaryFSTxFrequencyMHz_A12903.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.trkPerAnnouncementGroupAGSecondaryFSTxFrequencyMHz_A12903.DataTransferOrder = 49;
			this.trkPerAnnouncementGroupAGSystemID_A19705 = new global::AcpBusinessLayer.AcpSimpleRangeField(0, this, global::AllFeatures.CodeplugGuid.b("雁뛃귅飇꿉뻋迍뻏병믓ꏕ뛗맙맛돝藟賡郣ꇥ髧藩駫黭뇯뗱ꟳ迵请軹駻鏽䧿䘁嬃䜅㤇㌉㬋㸍┏", a_), global::CommonResources.AcgResources.ID_AGSYSTEMID, 0, 65535, null, null, 0, 1);
			this.trkPerAnnouncementGroupAGSystemID_A19705.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.trkPerAnnouncementGroupAGSystemID_A19705.DataTransferOrder = 26;
			this.trkPerAnnouncementGroupAGSystemID_A19705.ShowHexValue = true;
			this.trkPerAnnouncementGroupAGSystemID_A19705.ShowLeadingZeros = true;
			this.trkPerAnnouncementGroupAGWACNID_A19706 = new global::AcpBusinessLayer.AcpSimpleRangeField(0, this, global::AllFeatures.CodeplugGuid.b("雁뛃귅飇꿉뻋迍뻏병믓ꏕ뛗맙맛돝藟賡郣ꇥ髧藩駫黭뇯뗱ꏳ럵믷듹뗻뫽忿䌁㔃㼅㼇㨉㨋", a_), global::CommonResources.AcgResources.ID_AGWACNID, 0, 16777215, null, null, 0, 1);
			this.trkPerAnnouncementGroupAGWACNID_A19706.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.trkPerAnnouncementGroupAGWACNID_A19706.DataTransferOrder = 27;
			this.trkPerAnnouncementGroupAGWACNID_A19706.ShowHexValue = true;
			this.trkPerAnnouncementGroupAGWACNID_A19706.ShowLeadingZeros = true;
			this.trkPerAnnouncementGroupAGSecondaryFailsoft_A19990 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("雁뛃귅飇꿉뻋迍뻏병믓ꏕ뛗맙맛돝藟賡郣ꇥ髧藩駫黭뇯뗱ꟳ鏵鯷闹鋻髽懿瀁紃䀅椇按怋納缏琑怓䤕夗⬙┛✝᤟ሡ", a_), global::CommonResources.AcgResources.ID_TALKGROUPFAILSOFTAGSECONDARYFAILSOFT);
			this.trkPerAnnouncementGroupAGSecondaryFailsoft_A19990.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkPerAnnouncementGroupAGSecondaryFailsoft_A19990.DataTransferOrder = 13;
			this.trkPerAnnouncementGroupAGSecondaryFSRxFrequencyMHz_A8895 = new global::AcpBusinessLayer.AcpFrequencyField(170202500, this, global::AllFeatures.CodeplugGuid.b("雁뛃귅飇꿉뻋迍뻏병믓ꏕ뛗맙맛돝藟賡郣ꇥ髧藩駫黭뇯뗱ꟳ鏵鯷闹鋻髽懿瀁紃䀅嬇堉琋䠍戏眑攓挕紗琙缛朝洟模帣礥椧ሩᐫᜭԯ", a_), global::CommonResources.AcgResources.ID_TALKGROUPFAILSOFTAGSECONDARYFSRXFREQUENCYMHZ, 0, int.MaxValue, 1);
			this.trkPerAnnouncementGroupAGSecondaryFSRxFrequencyMHz_A8895.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.trkPerAnnouncementGroupAGSecondaryFSRxFrequencyMHz_A8895.DataTransferOrder = 47;
			this.trkPerAnnouncementGroupAstroOTARProfileIndex_43686 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("雁뛃귅飇꿉뻋迍뻏병믓ꏕ뛗맙맛돝藟賡郣ꇥ髧藩駫黭뇯臱胳蓵韷뗹ꣻ뿽勿刁瘃椅渇按怋欍夏簑瀓猕怗䔙⠛ⴝᘟᨡሣ", a_), global::CommonResources.AcgResources.ID_ASTROOTARPROFILEINDEX, new string[]
			{
				global::CommonResources.AcgResources.ID_HOME
			}, new int[1], true, false);
			this.trkPerAnnouncementGroupAstroOTARProfileIndex_43686.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkPerAnnouncementGroupAstroOTARProfileIndex_43686.DataTransferOrder = 53;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("菁꫃ꣅꟇ뿉ꋋ귍뗏뿑뇓룕곗龎鯛곝迟韡铣", a_);
			base.Id = 10176;
			base.UIName = global::CommonResources.AcgResources.ID_ANNOUNCEMENTGROUP;
			base.DataTransferOrder = 4;
		}

		// Token: 0x060015CA RID: 5578 RVA: 0x0014BE14 File Offset: 0x0014A014
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 5;
			short num = (short)1998716951;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_6C4;
				case 1:
					this.trkPerAnnouncementGroupAGFailsoftTxFrequencyMHz_A9583 = new global::AcpBusinessLayer.AcpFrequencyField(161202500, this, global::AllFeatures.CodeplugGuid.b("鋅뫇ꇉ鳋ꯍꋏ鏑뫓룕럗꿙닛뷝藟迡臣裥鳧귩黫臭藯英뗳뇵뻷鯹闻鋽珿洁戃爅將爉䨋簍甏挑愓猕瘗礙攛匝栟堡笣朥ᄧἩᐫᴭ", a_), global::CommonResources.AcgResources.ID_TALKGROUPFAILSOFTAGFAILSOFTTXFREQUENCYMHZ);
					this.trkPerAnnouncementGroupAGFailsoftTxFrequencyMHz_A9583.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.trkPerAnnouncementGroupAGFailsoftTxFrequencyMHz_A9583.DataTransferOrder = 63;
					num = (short)1303183370;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鋅뫇ꇉ鳋ꯍꋏ鏑뫓룕럗꿙닛뷝藟迡臣裥鳧귩黫臭藯英뗳뇵꯷菹迻諽旿漁䴃䈅圇䬉㴋㜍✏∑ℓ", a_)))
					{
						num = (short)447741983;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2E3;
				case 3:
					goto IL_A56;
				case 4:
					goto IL_972;
				case 5:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鋅뫇ꇉ鳋ꯍꋏ鏑뫓룕럗꿙닛뷝藟迡臣裥鳧귩黫臭藯英뗳뇵꯷鿹鿻釽滿昁攃琅焇䰉弋娍栏向易猕椗漙礛瀝䌟嬡椣渥刧甩洫Ἥȯ଱гԵ", a_)))
					{
						num = (short)220069894;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A56;
				case 6:
					this.trkPerAnnouncementGroupAGSecondaryFSTxFrequencyMHz_A12903 = new global::AcpBusinessLayer.AcpFrequencyField(161202500, this, global::AllFeatures.CodeplugGuid.b("鋅뫇ꇉ鳋ꯍꋏ鏑뫓룕럗꿙닛뷝藟迡臣裥鳧귩黫臭藯英뗳뇵꯷鿹鿻釽滿昁攃琅焇䰉弋娍栏向易猕椗漙礛瀝䌟嬡椣渥刧甩洫Ἥȯ଱гԵ", a_), global::CommonResources.AcgResources.ID_TALKGROUPFAILSOFTAGSECONDARYFSTXFREQUENCYMHZ);
					this.trkPerAnnouncementGroupAGSecondaryFSTxFrequencyMHz_A12903.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.trkPerAnnouncementGroupAGSecondaryFSTxFrequencyMHz_A12903.DataTransferOrder = 49;
					num = (short)1231355907;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					this.trkPerAnnouncementGroupAGFailsoftRxFrequencyMHz_A9582 = new global::AcpBusinessLayer.AcpFrequencyField(170202500, this, global::AllFeatures.CodeplugGuid.b("鋅뫇ꇉ鳋ꯍꋏ鏑뫓룕럗꿙닛뷝藟迡臣裥鳧귩黫臭藯英뗳뇵뻷鯹闻鋽珿洁戃爅娇爉䨋簍甏挑愓猕瘗礙攛匝栟堡笣朥ᄧἩᐫᰭ", a_), global::CommonResources.AcgResources.ID_TALKGROUPFAILSOFTAGFAILSOFTRXFREQUENCYMHZ);
					this.trkPerAnnouncementGroupAGFailsoftRxFrequencyMHz_A9582.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.trkPerAnnouncementGroupAGFailsoftRxFrequencyMHz_A9582.DataTransferOrder = 62;
					num = (short)1290600466;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					goto IL_1CA;
				case 9:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鋅뫇ꇉ鳋ꯍꋏ鏑뫓룕럗꿙닛뷝藟迡臣裥鳧귩黫臭藯英뗳뇵꯷鿹鿻釽滿昁攃琅焇䰉弋對栏向易猕椗漙礛瀝䌟嬡椣渥刧甩洫ᘭ࠯଱ĳ", a_)))
					{
						num = (short)534839338;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_972;
				case 10:
					goto IL_A0B;
				case 11:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鋅뫇ꇉ鳋ꯍꋏ鏑뫓룕럗꿙닛뷝藟迡臣裥鳧귩黫臭藯英뗳뇵꯷鿹鿻釽滿昁攃琅焇䰉洋服簏愑笓瀕気䔙崛⼝᤟ᬡᴣᘥ", a_)))
					{
						num = (short)1101660198;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_431;
				case 12:
					this.trkPerAnnouncementGroupAGSecureClearStrapping_A9089 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鋅뫇ꇉ鳋ꯍꋏ鏑뫓룕럗꿙닛뷝藟迡臣裥鳧귩黫臭藯英뗳뇵꯷鿹鿻诽狿朁䜃樅洇欉縋崍搏怑甓昕栗猙爛礝缟挡ᴣᘥဧጩ", a_), global::CommonResources.AcgResources.ID_AGSECURECLEARSTRAPPING, global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.LOVs.TrkPerAnnouncementGroupAGSecureClearStrapping_A9089LovStrs);
					this.trkPerAnnouncementGroupAGSecureClearStrapping_A9089.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkPerAnnouncementGroupAGSecureClearStrapping_A9089.DataTransferOrder = 16;
					num = (short)23920679;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					this.trkPerAnnouncementGroupAstroOTARProfileIndex_43686 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("鋅뫇ꇉ鳋ꯍꋏ鏑뫓룕럗꿙닛뷝藟迡臣裥鳧귩黫臭藯英뗳藵賷裹鏻뇽哿䌁嘃嘅稇攉樋服簏眑崓砕簗缙搛䄝ᐟᄡሣḥḧ", a_), global::CommonResources.AcgResources.ID_ASTROOTARPROFILEINDEX, new string[]
					{
						global::CommonResources.AcgResources.ID_HOME
					}, new int[1], true, false);
					this.trkPerAnnouncementGroupAstroOTARProfileIndex_43686.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkPerAnnouncementGroupAstroOTARProfileIndex_43686.DataTransferOrder = 53;
					num = (short)411828259;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鋅뫇ꇉ鳋ꯍꋏ鏑뫓룕럗꿙닛뷝藟迡臣裥鳧귩黫臭藯英뗳뇵꯷鿹鿻诽狿朁䜃樅洇欉縋崍搏怑甓昕栗猙爛礝缟挡ᴣᘥဧጩ", a_)))
					{
						num = (short)1988558860;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_784;
				case 15:
					this.trkPerAnnouncementGroupAGKeySelect_A7414 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("鋅뫇ꇉ鳋ꯍꋏ鏑뫓룕럗꿙닛뷝藟迡臣裥鳧귩黫臭藯英뗳뇵돷鿹藻귽旿渁愃攅簇唉䴋㤍␏⌑–", a_), global::CommonResources.AcgResources.ID_AGKEYSELECT, null, null, true, false);
					this.trkPerAnnouncementGroupAGKeySelect_A7414.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkPerAnnouncementGroupAGKeySelect_A7414.DataTransferOrder = 68;
					num = (short)1777532944;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
					goto IL_296;
				case 17:
					this.trkPerAnnouncementGroupAGWACNID_A19706 = new global::AcpBusinessLayer.AcpSimpleRangeField(0, this, global::AllFeatures.CodeplugGuid.b("鋅뫇ꇉ鳋ꯍꋏ鏑뫓룕럗꿙닛뷝藟迡臣裥鳧귩黫臭藯英뗳뇵꿷믹뿻냽䧿䘁嬃䜅㤇㌉㬋㸍☏", a_), global::CommonResources.AcgResources.ID_AGWACNID, null, null, 0, 1);
					this.trkPerAnnouncementGroupAGWACNID_A19706.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.trkPerAnnouncementGroupAGWACNID_A19706.DataTransferOrder = 27;
					this.trkPerAnnouncementGroupAGWACNID_A19706.ShowHexValue = true;
					this.trkPerAnnouncementGroupAGWACNID_A19706.ShowLeadingZeros = true;
					num = (short)1413021696;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 18:
					goto IL_38A;
				case 19:
					goto IL_926;
				case 20:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鋅뫇ꇉ鳋ꯍꋏ鏑뫓룕럗꿙닛뷝藟迡臣裥鳧귩黫臭藯英뗳뇵뻷鯹闻鋽珿洁戃爅娇爉䨋簍甏挑愓猕瘗礙攛匝栟堡笣朥ᄧἩᐫᰭ", a_)))
					{
						num = (short)143982599;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_38A;
				case 21:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鋅뫇ꇉ鳋ꯍꋏ鏑뫓룕럗꿙닛뷝藟迡臣裥鳧귩黫臭藯英뗳뇵뻷鯹闻鋽珿洁戃爅將爉䨋簍甏挑愓猕瘗礙攛匝栟堡笣朥ᄧἩᐫᴭ", a_)))
					{
						num = (short)1757020161;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A0B;
				case 22:
				{
					num = (short)2132279296;
					short num3 = num;
					this.trkPerAnnouncementGroupAGVoiceSignalType_A7478 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鋅뫇ꇉ鳋ꯍꋏ鏑뫓룕럗꿙닛뷝藟迡臣裥鳧귩黫臭藯英뗳뇵껷闹闻鷽旿儁洃愅昇欉怋娍椏我焓䤕夗ⴙ⠛⤝᠟", a_), global::CommonResources.AcgResources.ID_AGVOICESIGNALTYPE, global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.LOVs.TrkPerAnnouncementGroupAGVoiceSignalType_A7478LovStrs);
					this.trkPerAnnouncementGroupAGVoiceSignalType_A7478.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.trkPerAnnouncementGroupAGVoiceSignalType_A7478.DataTransferOrder = 6;
					num = (short)1033830427;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 23:
					switch (0)
					{
					case 0:
						goto IL_D9;
					}
					continue;
				case 24:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鋅뫇ꇉ鳋ꯍꋏ鏑뫓룕럗꿙닛뷝藟迡臣裥鳧귩黫臭藯英뗳뇵꿷믹뿻냽䧿䘁嬃䜅㤇㌉㬋㸍☏", a_)))
					{
						num = (short)6750225;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_6C4;
				case 25:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鋅뫇ꇉ鳋ꯍꋏ鏑뫓룕럗꿙닛뷝藟迡臣裥鳧귩黫臭藯英뗳飵雷闹觻都揿朁椃挅昇縉䬋簍缏朑搓䤕夗ⴙ⠛⨝ᐟ", a_)))
					{
						num = (short)707461148;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1CA;
				case 26:
					num = (short)706215973;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 27:
					goto IL_5FE;
				case 28:
					this.trkPerAnnouncementGroupAnnouncementGroup_A7444 = new global::AcpBusinessLayer.AcpCustomRangeField(0, this, global::AllFeatures.CodeplugGuid.b("鋅뫇ꇉ鳋ꯍꋏ鏑뫓룕럗꿙닛뷝藟迡臣裥鳧귩黫臭藯英뗳飵雷闹觻都揿朁椃挅昇縉䬋簍缏朑搓䤕夗ⴙ⠛⨝ᐟ", a_), global::CommonResources.AcgResources.ID_ANNOUNCEMENTGROUP, null, null);
					this.trkPerAnnouncementGroupAnnouncementGroup_A7444.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkPerAnnouncementGroupAnnouncementGroup_A7444.DataTransferOrder = 5;
					this.trkPerAnnouncementGroupAnnouncementGroup_A7444.EvaluateRecRefs = true;
					this.trkPerAnnouncementGroupAnnouncementGroup_A7444.AddCustomValue(0, global::CommonResources.AcgResources.ID_NONE);
					this.trkPerAnnouncementGroupAnnouncementGroup_A7444.ShowHexValue = true;
					num = (short)1922760712;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 29:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鋅뫇ꇉ鳋ꯍꋏ鏑뫓룕럗꿙닛뷝藟迡臣裥鳧귩黫臭藯英뗳飵雷闹觻都揿朁椃挅昇縉䬋簍缏朑搓倕礗猙瀛洝伟䐡倣礥椧ሩᤫᜭܯ", a_)))
					{
						num = (short)1343160361;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_926;
				case 30:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鋅뫇ꇉ鳋ꯍꋏ鏑뫓룕럗꿙닛뷝藟迡臣裥鳧귩黫臭藯英뗳뇵껷闹闻鷽旿儁洃愅昇欉怋娍椏我焓䤕夗ⴙ⠛⤝᠟", a_)))
					{
						num = (short)1153302550;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5FE;
				case 31:
					this.trkPerAnnouncementGroupAGSystemID_A19705 = new global::AcpBusinessLayer.AcpSimpleRangeField(0, this, global::AllFeatures.CodeplugGuid.b("鋅뫇ꇉ鳋ꯍꋏ鏑뫓룕럗꿙닛뷝藟迡臣裥鳧귩黫臭藯英뗳뇵꯷菹迻諽旿漁䴃䈅圇䬉㴋㜍✏∑ℓ", a_), global::CommonResources.AcgResources.ID_AGSYSTEMID, null, null, 0, 1);
					this.trkPerAnnouncementGroupAGSystemID_A19705.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.trkPerAnnouncementGroupAGSystemID_A19705.DataTransferOrder = 26;
					this.trkPerAnnouncementGroupAGSystemID_A19705.ShowHexValue = true;
					this.trkPerAnnouncementGroupAGSystemID_A19705.ShowLeadingZeros = true;
					num = (short)1418985504;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 32:
					goto IL_2E3;
				case 33:
					num = (short)419889188;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 34:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鋅뫇ꇉ鳋ꯍꋏ鏑뫓룕럗꿙닛뷝藟迡臣裥鳧귩黫臭藯英뗳藵賷裹鏻뇽哿䌁嘃嘅稇攉樋服簏眑崓砕簗缙搛䄝ᐟᄡሣḥḧ", a_)))
					{
						num = (short)432013325;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_AA2;
				case 35:
					goto IL_4E3;
				case 36:
					if (producerFields != null)
					{
						num = (short)962854938;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_AA2;
				case 37:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鋅뫇ꇉ鳋ꯍꋏ鏑뫓룕럗꿙닛뷝藟迡臣裥鳧귩黫臭藯英뗳뇵돷鿹藻귽旿渁愃攅簇唉䴋㤍␏⌑–", a_)))
					{
						num = (short)352124943;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_296;
				case 38:
					this.trkPerAnnouncementGroupAGSecondaryFailsoft_A19990 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鋅뫇ꇉ鳋ꯍꋏ鏑뫓룕럗꿙닛뷝藟迡臣裥鳧귩黫臭藯英뗳뇵꯷鿹鿻釽滿昁攃琅焇䰉洋服簏愑笓瀕気䔙崛⼝᤟ᬡᴣᘥ", a_), global::CommonResources.AcgResources.ID_TALKGROUPFAILSOFTAGSECONDARYFAILSOFT);
					this.trkPerAnnouncementGroupAGSecondaryFailsoft_A19990.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkPerAnnouncementGroupAGSecondaryFailsoft_A19990.DataTransferOrder = 13;
					num = (short)1822752808;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 39:
					goto IL_784;
				case 40:
					goto IL_431;
				case 41:
					this.trkPerAnnouncementGroupAnnouncementGroupFailsoft_A8597 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鋅뫇ꇉ鳋ꯍꋏ鏑뫓룕럗꿙닛뷝藟迡臣裥鳧귩黫臭藯英뗳飵雷闹觻都揿朁椃挅昇縉䬋簍缏朑搓倕礗猙瀛洝伟䐡倣礥椧ሩᤫᜭܯ", a_), global::CommonResources.AcgResources.ID_TALKGROUPFAILSOFTANNOUNCEMENTGROUPFAILSOFT);
					this.trkPerAnnouncementGroupAnnouncementGroupFailsoft_A8597.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkPerAnnouncementGroupAnnouncementGroupFailsoft_A8597.DataTransferOrder = 12;
					num = (short)569704467;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 42:
					this.trkPerAnnouncementGroupAGSecondaryFSRxFrequencyMHz_A8895 = new global::AcpBusinessLayer.AcpFrequencyField(170202500, this, global::AllFeatures.CodeplugGuid.b("鋅뫇ꇉ鳋ꯍꋏ鏑뫓룕럗꿙닛뷝藟迡臣裥鳧귩黫臭藯英뗳뇵꯷鿹鿻釽滿昁攃琅焇䰉弋對栏向易猕椗漙礛瀝䌟嬡椣渥刧甩洫ᘭ࠯଱ĳ", a_), global::CommonResources.AcgResources.ID_TALKGROUPFAILSOFTAGSECONDARYFSRXFREQUENCYMHZ);
					this.trkPerAnnouncementGroupAGSecondaryFSRxFrequencyMHz_A8895.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.trkPerAnnouncementGroupAGSecondaryFSRxFrequencyMHz_A8895.DataTransferOrder = 47;
					num = (short)243073028;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_D9:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1745223713;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_1CA:
				num = (short)1452212254;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_296:
				num = (short)214958105;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2E3:
				num = (short)913571864;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_38A:
				num = (short)43319317;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_431:
				num = (short)1286209545;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_5FE:
				num = (short)248840193;
				if (num != 0)
				{
				}
				num = (short)531496989;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_6C4:
				num = (short)1743192075;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_784:
				num = (short)264173873;
				short num4 = num;
				num = (short)1867315505;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_AA2;
				default:
					num = (short)251199488;
					if (num != 0)
					{
					}
					num = (short)1755906068;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_926:
				num = (short)547487758;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_972:
				num = (short)741736482;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_A0B:
				num = (short)1320681477;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_A56:
				num = (short)711655426;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_4E3:
			IL_AA2:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("蟅ꛇ꓉ꏋ믍뻏뇑뇓믕뷗듙꣛ﻝ꟟郡诣鏥飧", a_);
			base.Id = 10176;
			base.UIName = global::CommonResources.AcgResources.ID_ANNOUNCEMENTGROUP;
			base.DataTransferOrder = 4;
		}

		// Token: 0x060015CB RID: 5579 RVA: 0x0014C8F4 File Offset: 0x0014AAF4
		public override void PopulateReferences()
		{
			short num = (short)560660481;
			if (num != 0)
			{
			}
			num = (short)1772693221;
			short num2 = num;
			num = (short)1184442085;
			switch (num2 == num)
			{
			}
			num = (short)1124204544;
			if (num != 0)
			{
			}
			num = (short)70189056;
			short num3 = num;
			this.trkPerAnnouncementGroupAstroOTARProfileIndex_43686.SetRecset(this.a(2055));
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.AnnouncementGroupAstroOtarProfileIndexIsEnable(this);
		}

		// Token: 0x060015CC RID: 5580 RVA: 0x0014C9B8 File Offset: 0x0014ABB8
		public override void DropReferences()
		{
			short num = (short)37498591;
			short num2 = num;
			num = (short)538193631;
			switch (num2 == num)
			{
			}
			num = (short)1526464513;
			if (num != 0)
			{
			}
			num = (short)1692467200;
			if (num != 0)
			{
			}
			num = (short)2048458752;
			short num3 = num;
		}

		// Token: 0x060015CD RID: 5581 RVA: 0x0014CA60 File Offset: 0x0014AC60
		public override void SetConstraints()
		{
			short num = (short)22095765;
			short num2 = num;
			num = (short)753018773;
			switch (num2 == num)
			{
			}
			num = (short)1997668353;
			if (num != 0)
			{
			}
			num = (short)927268864;
			if (num != 0)
			{
			}
			num = (short)233897984;
			short num3 = num;
			this.trkPerAnnouncementGroupAGKeySelect_A7414.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.ConGenPageAGKeySelectApplicable);
			this.trkPerAnnouncementGroupAGKeySelect_A7414.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.ConKeySelect7414IsValid);
			this.trkPerAnnouncementGroupAnnouncementGroup_A7444.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.ConAnnouncementGroupApplicable);
			this.trkPerAnnouncementGroupAnnouncementGroup_A7444.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.ConAnnouncementGroupValid);
			this.trkPerAnnouncementGroupAGVoiceSignalType_A7478.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.ConAnnouncementGroupIsNotNoneAndTrkPerTypeII);
			this.trkPerAnnouncementGroupAGVoiceSignalType_A7478.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.ConAGIsNot900MDigital);
			this.trkPerAnnouncementGroupAnnouncementGroupFailsoft_A8597.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.ConFSTypeIsTalkgroupAndAnnGrpIsNotNone);
			this.trkPerAnnouncementGroupAGSecureClearStrapping_A9089.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.ConSecureAndAGNotNoneAndBndWidthNot125);
			this.trkPerAnnouncementGroupAGFailsoftRxFrequencyMHz_A9582.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.ConAnnGrpFsIsEnabledAndAnnounGrpIsNotNoneAndFsTypeIsTlkgrp);
			this.trkPerAnnouncementGroupAGFailsoftRxFrequencyMHz_A9582.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.conAGFailsoftRxFreqIsValid);
			this.trkPerAnnouncementGroupAGFailsoftRxFrequencyMHz_A9582.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.conSetValueAGFailsoftTxFrequency);
			this.trkPerAnnouncementGroupAGFailsoftTxFrequencyMHz_A9583.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.conAGFailsoftTxFreqApplicability);
			this.trkPerAnnouncementGroupAGFailsoftTxFrequencyMHz_A9583.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.conAGFailsoftTxFreqIsValid);
			this.trkPerAnnouncementGroupAGFailsoftTxFrequencyMHz_A9583.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.conAGFailsoftTxFreqApplicabilityEditabl);
			this.trkPerAnnouncementGroupAGSecondaryFSTxFrequencyMHz_A12903.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.conAGSecondaryTxFreqApplicability);
			this.trkPerAnnouncementGroupAGSecondaryFSTxFrequencyMHz_A12903.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.conAGFailsoftSecTxFreqIsValid);
			this.trkPerAnnouncementGroupAGSecondaryFSTxFrequencyMHz_A12903.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.conAGSecondaryTxFreqApplicabilityEditbl);
			this.trkPerAnnouncementGroupAGSystemID_A19705.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.ConIsASTRO25AndNGI);
			this.trkPerAnnouncementGroupAGWACNID_A19706.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.ConIsASTRO25AndNGI);
			this.trkPerAnnouncementGroupAGSecondaryFailsoft_A19990.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.ConAnnGrpFsIsEnabledAndAnnounGrpIsNotNoneAndFsTypeIsTlkgrp);
			this.trkPerAnnouncementGroupAGSecondaryFSRxFrequencyMHz_A8895.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.ConFsTypeTkGrpAndAnnGrpFsEnAndAGSecondFsEnAndAnnGrpNotNone);
			this.trkPerAnnouncementGroupAGSecondaryFSRxFrequencyMHz_A8895.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.conAGFailsoftSecRxFreqIsValid);
			this.trkPerAnnouncementGroupAGSecondaryFSRxFrequencyMHz_A8895.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.conSetValueAGSecondaryTxFrequency);
			this.trkPerAnnouncementGroupAstroOTARProfileIndex_43686.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityConstraints.AnnouncementGroupAstroOtarProfileIndexIsEnable);
		}

		// Token: 0x060015CE RID: 5582 RVA: 0x0014CD34 File Offset: 0x0014AF34
		public override void SetupDependencies()
		{
			short num2;
			for (;;)
			{
				IL_00:
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						if (trunkingSystem != null)
						{
							num2 = (short)729415682;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					case 1:
						goto IL_768;
					case 2:
					{
						num2 = (short)888602624;
						short num3 = num2;
						num2 = (short)857558848;
						short num4 = num2;
						num2 = (short)1393184576;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num2 = (short)2044723200;
							if (num2 != 0)
							{
							}
							this.trkPerAnnouncementGroupAstroOTARProfileIndex_43686.AddDependentObject(trunkingSystem.General.TrkSysGeneralCoverageType_A7782);
							num2 = (short)1960771585;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					}
					break;
				}
				IL_1C:
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality trunkingPersonality = base.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality;
				this.trkPerAnnouncementGroupAGSecureClearStrapping_A9089.AddDependentObject(this.trkPerAnnouncementGroupAGKeySelect_A7414);
				trunkingPersonality.General.TrkPerGeneralSystem_A9237.AddDependentObject(this.trkPerAnnouncementGroupAGKeySelect_A7414);
				this.trkPerAnnouncementGroupAnnouncementGroup_A7444.AddDependentObject(this.trkPerAnnouncementGroupAGKeySelect_A7414);
				this.trkPerAnnouncementGroupAGVoiceSignalType_A7478.AddDependentObject(this.trkPerAnnouncementGroupAGKeySelect_A7414);
				this.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.trkPerAnnouncementGroupAGKeySelect_A7414);
				trunkingPersonality.General.TrkPerGeneralProtocolType_A8767.AddDependentObject(this.trkPerAnnouncementGroupAGKeySelect_A7414);
				this.RefSecureWide.General.SecWideGeneralOTAREnable_A7966.AddDependentObject(this.trkPerAnnouncementGroupAGKeySelect_A7414);
				this.RefSecureWide.ASTROOTAR.SecWideASTROOTARASTROOTAREnable_A7496.AddDependentObject(this.trkPerAnnouncementGroupAGKeySelect_A7414);
				this.RefSecureWide.General.SecureWideAESAlgorithmEnable_43201.AddDependentObject(this.trkPerAnnouncementGroupAGKeySelect_A7414);
				this.RefSecureWide.General.SecureWideDESAlgorithmEnable_43744.AddDependentObject(this.trkPerAnnouncementGroupAGKeySelect_A7414);
				trunkingPersonality.General.TrkPerGeneralProtocolType_A8767.AddDependentObject(this.trkPerAnnouncementGroupAnnouncementGroup_A7444);
				trunkingPersonality.General.TrkPerGeneralSystem_A9237.AddDependentObject(this.trkPerAnnouncementGroupAnnouncementGroup_A7444);
				this.trkPerAnnouncementGroupAnnouncementGroup_A7444.AddDependentObject(this.trkPerAnnouncementGroupAGVoiceSignalType_A7478);
				trunkingPersonality.General.TrkPerGeneralProtocolType_A8767.AddDependentObject(this.trkPerAnnouncementGroupAGVoiceSignalType_A7478);
				trunkingPersonality.General.TrkPerGeneralSystem_A9237.AddDependentObject(this.trkPerAnnouncementGroupAGVoiceSignalType_A7478);
				trunkingPersonality.General.TrkPerGeneralFailsoftType_A8599.AddDependentObject(this.trkPerAnnouncementGroupAnnouncementGroupFailsoft_A8597);
				this.trkPerAnnouncementGroupAnnouncementGroup_A7444.AddDependentObject(this.trkPerAnnouncementGroupAnnouncementGroupFailsoft_A8597);
				trunkingPersonality.General.TrkPerGeneralProtocolType_A8767.AddDependentObject(this.trkPerAnnouncementGroupAnnouncementGroupFailsoft_A8597);
				this.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.trkPerAnnouncementGroupAGSecureClearStrapping_A9089);
				trunkingPersonality.General.TrkPerGeneralSystem_A9237.AddDependentObject(this.trkPerAnnouncementGroupAGSecureClearStrapping_A9089);
				trunkingPersonality.General.TrkPerGeneralProtocolType_A8767.AddDependentObject(this.trkPerAnnouncementGroupAGSecureClearStrapping_A9089);
				this.trkPerAnnouncementGroupAnnouncementGroup_A7444.AddDependentObject(this.trkPerAnnouncementGroupAGSecureClearStrapping_A9089);
				this.trkPerAnnouncementGroupAGVoiceSignalType_A7478.AddDependentObject(this.trkPerAnnouncementGroupAGSecureClearStrapping_A9089);
				this.trkPerAnnouncementGroupAnnouncementGroupFailsoft_A8597.AddDependentObject(this.trkPerAnnouncementGroupAGFailsoftRxFrequencyMHz_A9582);
				trunkingPersonality.General.TrkPerGeneralFailsoftType_A8599.AddDependentObject(this.trkPerAnnouncementGroupAGFailsoftRxFrequencyMHz_A9582);
				this.trkPerAnnouncementGroupAnnouncementGroup_A7444.AddDependentObject(this.trkPerAnnouncementGroupAGFailsoftRxFrequencyMHz_A9582);
				trunkingPersonality.General.TrkPerGeneralProtocolType_A8767.AddDependentObject(this.trkPerAnnouncementGroupAGFailsoftRxFrequencyMHz_A9582);
				this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesOpenFrequency_A22699.AddDependentObject(this.trkPerAnnouncementGroupAGFailsoftRxFrequencyMHz_A9582);
				trunkingPersonality.General.TrkPerGeneralSystem_A9237.AddDependentObject(this.trkPerAnnouncementGroupAGFailsoftRxFrequencyMHz_A9582);
				this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRanges700MHzUsedinCodeplug_A42551.AddDependentObject(this.trkPerAnnouncementGroupAGFailsoftRxFrequencyMHz_A9582);
				this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRanges800MHzUsedinCodeplug_A42552.AddDependentObject(this.trkPerAnnouncementGroupAGFailsoftRxFrequencyMHz_A9582);
				this.trkPerAnnouncementGroupAGFailsoftTxFrequencyMHz_A9583.AddDependentObject(this.trkPerAnnouncementGroupAGFailsoftRxFrequencyMHz_A9582);
				this.trkPerAnnouncementGroupAGFailsoftRxFrequencyMHz_A9582.AddDependentObject(this.trkPerAnnouncementGroupAGFailsoftTxFrequencyMHz_A9583);
				this.trkPerAnnouncementGroupAnnouncementGroupFailsoft_A8597.AddDependentObject(this.trkPerAnnouncementGroupAGFailsoftTxFrequencyMHz_A9583);
				trunkingPersonality.General.TrkPerGeneralFailsoftType_A8599.AddDependentObject(this.trkPerAnnouncementGroupAGFailsoftTxFrequencyMHz_A9583);
				this.trkPerAnnouncementGroupAnnouncementGroup_A7444.AddDependentObject(this.trkPerAnnouncementGroupAGFailsoftTxFrequencyMHz_A9583);
				trunkingPersonality.General.TrkPerGeneralProtocolType_A8767.AddDependentObject(this.trkPerAnnouncementGroupAGFailsoftTxFrequencyMHz_A9583);
				this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesOpenFrequency_A22699.AddDependentObject(this.trkPerAnnouncementGroupAGFailsoftTxFrequencyMHz_A9583);
				trunkingPersonality.General.TrkPerGeneralSystem_A9237.AddDependentObject(this.trkPerAnnouncementGroupAGFailsoftTxFrequencyMHz_A9583);
				this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRanges700MHzUsedinCodeplug_A42551.AddDependentObject(this.trkPerAnnouncementGroupAGFailsoftTxFrequencyMHz_A9583);
				this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRanges800MHzUsedinCodeplug_A42552.AddDependentObject(this.trkPerAnnouncementGroupAGFailsoftTxFrequencyMHz_A9583);
				this.trkPerAnnouncementGroupAGSecondaryFSRxFrequencyMHz_A8895.AddDependentObject(this.trkPerAnnouncementGroupAGSecondaryFSTxFrequencyMHz_A12903);
				this.trkPerAnnouncementGroupAnnouncementGroupFailsoft_A8597.AddDependentObject(this.trkPerAnnouncementGroupAGSecondaryFSTxFrequencyMHz_A12903);
				trunkingPersonality.General.TrkPerGeneralFailsoftType_A8599.AddDependentObject(this.trkPerAnnouncementGroupAGSecondaryFSTxFrequencyMHz_A12903);
				this.trkPerAnnouncementGroupAGSecondaryFailsoft_A19990.AddDependentObject(this.trkPerAnnouncementGroupAGSecondaryFSTxFrequencyMHz_A12903);
				this.trkPerAnnouncementGroupAnnouncementGroup_A7444.AddDependentObject(this.trkPerAnnouncementGroupAGSecondaryFSTxFrequencyMHz_A12903);
				trunkingPersonality.General.TrkPerGeneralProtocolType_A8767.AddDependentObject(this.trkPerAnnouncementGroupAGSecondaryFSTxFrequencyMHz_A12903);
				this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesOpenFrequency_A22699.AddDependentObject(this.trkPerAnnouncementGroupAGSecondaryFSTxFrequencyMHz_A12903);
				trunkingPersonality.General.TrkPerGeneralSystem_A9237.AddDependentObject(this.trkPerAnnouncementGroupAGSecondaryFSTxFrequencyMHz_A12903);
				this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRanges700MHzUsedinCodeplug_A42551.AddDependentObject(this.trkPerAnnouncementGroupAGSecondaryFSTxFrequencyMHz_A12903);
				this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRanges800MHzUsedinCodeplug_A42552.AddDependentObject(this.trkPerAnnouncementGroupAGSecondaryFSTxFrequencyMHz_A12903);
				trunkingPersonality.General.TrkPerGeneralSystem_A9237.AddDependentObject(this.trkPerAnnouncementGroupAGSystemID_A19705);
				trunkingPersonality.General.TrkPerGeneralProtocolType_A8767.AddDependentObject(this.trkPerAnnouncementGroupAGSystemID_A19705);
				trunkingPersonality.General.TrkPerGeneralSystem_A9237.AddDependentObject(this.trkPerAnnouncementGroupAGWACNID_A19706);
				trunkingPersonality.General.TrkPerGeneralProtocolType_A8767.AddDependentObject(this.trkPerAnnouncementGroupAGWACNID_A19706);
				this.trkPerAnnouncementGroupAnnouncementGroupFailsoft_A8597.AddDependentObject(this.trkPerAnnouncementGroupAGSecondaryFailsoft_A19990);
				trunkingPersonality.General.TrkPerGeneralFailsoftType_A8599.AddDependentObject(this.trkPerAnnouncementGroupAGSecondaryFailsoft_A19990);
				this.trkPerAnnouncementGroupAnnouncementGroup_A7444.AddDependentObject(this.trkPerAnnouncementGroupAGSecondaryFailsoft_A19990);
				trunkingPersonality.General.TrkPerGeneralProtocolType_A8767.AddDependentObject(this.trkPerAnnouncementGroupAGSecondaryFailsoft_A19990);
				this.trkPerAnnouncementGroupAnnouncementGroupFailsoft_A8597.AddDependentObject(this.trkPerAnnouncementGroupAGSecondaryFSRxFrequencyMHz_A8895);
				trunkingPersonality.General.TrkPerGeneralFailsoftType_A8599.AddDependentObject(this.trkPerAnnouncementGroupAGSecondaryFSRxFrequencyMHz_A8895);
				this.trkPerAnnouncementGroupAGSecondaryFailsoft_A19990.AddDependentObject(this.trkPerAnnouncementGroupAGSecondaryFSRxFrequencyMHz_A8895);
				this.trkPerAnnouncementGroupAnnouncementGroup_A7444.AddDependentObject(this.trkPerAnnouncementGroupAGSecondaryFSRxFrequencyMHz_A8895);
				trunkingPersonality.General.TrkPerGeneralProtocolType_A8767.AddDependentObject(this.trkPerAnnouncementGroupAGSecondaryFSRxFrequencyMHz_A8895);
				this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesOpenFrequency_A22699.AddDependentObject(this.trkPerAnnouncementGroupAGSecondaryFSRxFrequencyMHz_A8895);
				trunkingPersonality.General.TrkPerGeneralSystem_A9237.AddDependentObject(this.trkPerAnnouncementGroupAGSecondaryFSRxFrequencyMHz_A8895);
				this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRanges700MHzUsedinCodeplug_A42551.AddDependentObject(this.trkPerAnnouncementGroupAGSecondaryFSRxFrequencyMHz_A8895);
				this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRanges800MHzUsedinCodeplug_A42552.AddDependentObject(this.trkPerAnnouncementGroupAGSecondaryFSRxFrequencyMHz_A8895);
				this.trkPerAnnouncementGroupAGSecondaryFSTxFrequencyMHz_A12903.AddDependentObject(this.trkPerAnnouncementGroupAGSecondaryFSRxFrequencyMHz_A8895);
				this.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.trkPerAnnouncementGroupAstroOTARProfileIndex_43686);
				this.trkPerAnnouncementGroupAGSystemID_A19705.AddDependentObject(this.trkPerAnnouncementGroupAstroOTARProfileIndex_43686);
				trunkingSystem = ((base.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality).General.TrkPerGeneralSystem_A9237.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem);
				num2 = (short)543555584;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			IL_768:
			num2 = (short)716767233;
			if (num2 != 0)
			{
			}
		}

		// Token: 0x17000AE7 RID: 2791
		// (get) Token: 0x060015CF RID: 5583 RVA: 0x0014D4D4 File Offset: 0x0014B6D4
		public global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInner EncryptionKeyListInnerSectionForTrkPerAnnouncementGroupAGKeySelect_A7414
		{
			get
			{
				short num = (short)1714357679;
				short num2 = num;
				num = (short)532415919;
				switch (num2 == num)
				{
				}
				num = (short)836042752;
				if (num != 0)
				{
				}
				num = (short)853999617;
				if (num != 0)
				{
				}
				num = (short)883097600;
				short num3 = num;
				return this.trkPerAnnouncementGroupAGKeySelect_A7414.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInner;
			}
		}

		// Token: 0x17000AE8 RID: 2792
		// (get) Token: 0x060015D0 RID: 5584 RVA: 0x0014D58C File Offset: 0x0014B78C
		public global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile SecureKMFProfileForTrkPerAnnouncementGroupAstroOTARProfileIndex_43686
		{
			get
			{
				short num = (short)996767570;
				short num2 = num;
				num = (short)1126594386;
				switch (num2 == num)
				{
				}
				num = (short)1708720128;
				if (num != 0)
				{
				}
				num = (short)1216610305;
				if (num != 0)
				{
				}
				num = (short)2073100288;
				short num3 = num;
				return this.trkPerAnnouncementGroupAstroOTARProfileIndex_43686.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile;
			}
		}

		// Token: 0x17000AE9 RID: 2793
		// (get) Token: 0x060015D1 RID: 5585 RVA: 0x0014D644 File Offset: 0x0014B844
		public bool HasDiffs
		{
			get
			{
				short num = (short)1514242183;
				short num2 = num;
				num = (short)2036891783;
				switch (num2 == num)
				{
				}
				num = (short)609484800;
				if (num != 0)
				{
				}
				num = (short)2142437377;
				if (num != 0)
				{
				}
				num = (short)1241907200;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x17000AEA RID: 2794
		// (get) Token: 0x060015D2 RID: 5586 RVA: 0x0014D6F4 File Offset: 0x0014B8F4
		// (set) Token: 0x060015D3 RID: 5587 RVA: 0x0014D7A8 File Offset: 0x0014B9A8
		public int TrkPerAnnouncementGroupAGKeySelect_A7414Value
		{
			get
			{
				short num = (short)1563797016;
				short num2 = num;
				num = (short)201762328;
				switch (num2 == num)
				{
				}
				num = (short)135725057;
				if (num != 0)
				{
				}
				num = (short)952762368;
				if (num != 0)
				{
				}
				num = (short)735444992;
				short num3 = num;
				return this.trkPerAnnouncementGroupAGKeySelect_A7414.Value;
			}
			set
			{
				short num = (short)1362755585;
				if (num != 0)
				{
				}
				num = (short)521971754;
				short num2 = num;
				num = (short)368551978;
				switch (num2 == num)
				{
				}
				num = (short)74317824;
				if (num != 0)
				{
				}
				num = (short)470351872;
				short num3 = num;
				this.trkPerAnnouncementGroupAGKeySelect_A7414.Value = value;
			}
		}

		// Token: 0x17000AEB RID: 2795
		// (get) Token: 0x060015D4 RID: 5588 RVA: 0x0014D860 File Offset: 0x0014BA60
		// (set) Token: 0x060015D5 RID: 5589 RVA: 0x0014D914 File Offset: 0x0014BB14
		public string TrkPerAnnouncementGroupAGKeySelect_A7414_UIValue
		{
			get
			{
				short num = (short)976025157;
				short num2 = num;
				num = (short)945878597;
				switch (num2 == num)
				{
				}
				num = (short)1548550144;
				if (num != 0)
				{
				}
				num = (short)268697601;
				if (num != 0)
				{
				}
				num = (short)399245312;
				short num3 = num;
				return this.trkPerAnnouncementGroupAGKeySelect_A7414.UIValue;
			}
			set
			{
				short num = (short)1395805716;
				short num2 = num;
				num = (short)1573080596;
				switch (num2 == num)
				{
				}
				num = (short)668860417;
				if (num != 0)
				{
				}
				num = (short)276627456;
				if (num != 0)
				{
				}
				num = (short)1558839296;
				short num3 = num;
				this.trkPerAnnouncementGroupAGKeySelect_A7414.UIValue = value;
			}
		}

		// Token: 0x17000AEC RID: 2796
		// (get) Token: 0x060015D6 RID: 5590 RVA: 0x0014D9C8 File Offset: 0x0014BBC8
		public global::AcpBusinessLayer.AcpRecRefField TrkPerAnnouncementGroupAGKeySelect_A7414
		{
			get
			{
				short num = (short)256256356;
				short num2 = num;
				num = (short)1839606116;
				switch (num2 == num)
				{
				}
				num = (short)1200488449;
				if (num != 0)
				{
				}
				num = (short)2104360960;
				if (num != 0)
				{
				}
				num = (short)1352269824;
				short num3 = num;
				return this.trkPerAnnouncementGroupAGKeySelect_A7414;
			}
		}

		// Token: 0x17000AED RID: 2797
		// (get) Token: 0x060015D7 RID: 5591 RVA: 0x0014DA78 File Offset: 0x0014BC78
		// (set) Token: 0x060015D8 RID: 5592 RVA: 0x0014DB2C File Offset: 0x0014BD2C
		public bool TrkPerAnnouncementGroupAGKeySelect_A7414_Applicable
		{
			get
			{
				short num = (short)1144409724;
				short num2 = num;
				num = (short)1233342076;
				switch (num2 == num)
				{
				}
				num = (short)123469825;
				if (num != 0)
				{
				}
				num = (short)709558272;
				if (num != 0)
				{
				}
				num = (short)1702690816;
				short num3 = num;
				return this.trkPerAnnouncementGroupAGKeySelect_A7414.Applicable;
			}
			set
			{
				short num = (short)1813543048;
				short num2 = num;
				num = (short)1537243272;
				switch (num2 == num)
				{
				}
				num = (short)1497038848;
				if (num != 0)
				{
				}
				num = (short)1513619457;
				if (num != 0)
				{
				}
				num = (short)753139712;
				short num3 = num;
				this.trkPerAnnouncementGroupAGKeySelect_A7414.Applicable = value;
			}
		}

		// Token: 0x17000AEE RID: 2798
		// (get) Token: 0x060015D9 RID: 5593 RVA: 0x0014DBE4 File Offset: 0x0014BDE4
		// (set) Token: 0x060015DA RID: 5594 RVA: 0x0014DC98 File Offset: 0x0014BE98
		public bool TrkPerAnnouncementGroupAGKeySelect_A7414_Valid
		{
			get
			{
				short num = (short)1956821495;
				short num2 = num;
				num = (short)1520548343;
				switch (num2 == num)
				{
				}
				num = (short)1147011073;
				if (num != 0)
				{
				}
				num = (short)794820608;
				if (num != 0)
				{
				}
				num = (short)236126208;
				short num3 = num;
				return this.trkPerAnnouncementGroupAGKeySelect_A7414.Valid;
			}
			set
			{
				short num = (short)1545823778;
				short num2 = num;
				num = (short)755721762;
				switch (num2 == num)
				{
				}
				num = (short)2136408065;
				if (num != 0)
				{
				}
				num = (short)874774528;
				if (num != 0)
				{
				}
				num = (short)1458372608;
				short num3 = num;
				this.trkPerAnnouncementGroupAGKeySelect_A7414.Valid = value;
			}
		}

		// Token: 0x17000AEF RID: 2799
		// (get) Token: 0x060015DB RID: 5595 RVA: 0x0014DD4C File Offset: 0x0014BF4C
		// (set) Token: 0x060015DC RID: 5596 RVA: 0x0014DE04 File Offset: 0x0014C004
		public bool TrkPerAnnouncementGroupAGKeySelect_A7414_Visible
		{
			get
			{
				short num = (short)1939603457;
				if (num != 0)
				{
				}
				num = (short)1869733173;
				short num2 = num;
				num = (short)1861737781;
				switch (num2 == num)
				{
				}
				num = (short)752222208;
				if (num != 0)
				{
				}
				num = (short)135069696;
				short num3 = num;
				return this.trkPerAnnouncementGroupAGKeySelect_A7414.Visible;
			}
			set
			{
				short num = (short)2033753490;
				short num2 = num;
				num = (short)1280613778;
				switch (num2 == num)
				{
				}
				num = (short)886767617;
				if (num != 0)
				{
				}
				num = (short)2126446592;
				if (num != 0)
				{
				}
				num = (short)1119158272;
				short num3 = num;
				this.trkPerAnnouncementGroupAGKeySelect_A7414.Visible = value;
			}
		}

		// Token: 0x17000AF0 RID: 2800
		// (get) Token: 0x060015DD RID: 5597 RVA: 0x0014DEBC File Offset: 0x0014C0BC
		// (set) Token: 0x060015DE RID: 5598 RVA: 0x0014DF70 File Offset: 0x0014C170
		public bool TrkPerAnnouncementGroupAGKeySelect_A7414_Editable
		{
			get
			{
				short num = (short)1749862554;
				short num2 = num;
				num = (short)1350813850;
				switch (num2 == num)
				{
				}
				num = (short)1404174337;
				if (num != 0)
				{
				}
				num = (short)217710592;
				if (num != 0)
				{
				}
				num = (short)934346752;
				short num3 = num;
				return this.trkPerAnnouncementGroupAGKeySelect_A7414.Editable;
			}
			set
			{
				short num = (short)324820765;
				short num2 = num;
				num = (short)1087463197;
				switch (num2 == num)
				{
				}
				num = (short)1617690625;
				if (num != 0)
				{
				}
				num = (short)683540480;
				if (num != 0)
				{
				}
				num = (short)2070544384;
				short num3 = num;
				this.trkPerAnnouncementGroupAGKeySelect_A7414.Editable = value;
			}
		}

		// Token: 0x17000AF1 RID: 2801
		// (get) Token: 0x060015DF RID: 5599 RVA: 0x0014E028 File Offset: 0x0014C228
		internal string TrkPerAnnouncementGroupAGKeySelect_A7414_UILabel
		{
			get
			{
				short num = (short)1362645889;
				short num2 = num;
				num = (short)107959169;
				switch (num2 == num)
				{
				}
				num = (short)142671873;
				if (num != 0)
				{
				}
				num = (short)1497432064;
				if (num != 0)
				{
				}
				num = (short)280297472;
				short num3 = num;
				return this.trkPerAnnouncementGroupAGKeySelect_A7414.UIName;
			}
		}

		// Token: 0x17000AF2 RID: 2802
		// (get) Token: 0x060015E0 RID: 5600 RVA: 0x0014E0DC File Offset: 0x0014C2DC
		// (set) Token: 0x060015E1 RID: 5601 RVA: 0x0014E190 File Offset: 0x0014C390
		internal bool TrkPerAnnouncementGroupAGKeySelect_A7414_HiddenStatic
		{
			get
			{
				short num = (short)1285667215;
				short num2 = num;
				num = (short)381925775;
				switch (num2 == num)
				{
				}
				num = (short)1993211905;
				if (num != 0)
				{
				}
				num = (short)437846016;
				if (num != 0)
				{
				}
				num = (short)832372736;
				short num3 = num;
				return this.trkPerAnnouncementGroupAGKeySelect_A7414.HiddenStatic;
			}
			set
			{
				short num = (short)1285488802;
				short num2 = num;
				num = (short)412942498;
				switch (num2 == num)
				{
				}
				num = (short)1464467457;
				if (num != 0)
				{
				}
				num = (short)1426063360;
				if (num != 0)
				{
				}
				num = (short)52756480;
				short num3 = num;
				this.trkPerAnnouncementGroupAGKeySelect_A7414.HiddenStatic = value;
			}
		}

		// Token: 0x17000AF3 RID: 2803
		// (get) Token: 0x060015E2 RID: 5602 RVA: 0x0014E244 File Offset: 0x0014C444
		// (set) Token: 0x060015E3 RID: 5603 RVA: 0x0014E2FC File Offset: 0x0014C4FC
		internal bool TrkPerAnnouncementGroupAGKeySelect_A7414_HiddenDynamic
		{
			get
			{
				short num = (short)551355503;
				short num2 = num;
				num = (short)1717634159;
				switch (num2 == num)
				{
				}
				num = (short)184287232;
				if (num != 0)
				{
				}
				num = (short)93650945;
				if (num != 0)
				{
				}
				num = (short)2035810304;
				short num3 = num;
				return this.trkPerAnnouncementGroupAGKeySelect_A7414.HiddenDynamic;
			}
			set
			{
				short num = (short)1626669057;
				if (num != 0)
				{
				}
				num = (short)360426946;
				short num2 = num;
				num = (short)1403497922;
				switch (num2 == num)
				{
				}
				num = (short)1931739136;
				if (num != 0)
				{
				}
				num = (short)1019674624;
				short num3 = num;
				this.trkPerAnnouncementGroupAGKeySelect_A7414.HiddenDynamic = value;
			}
		}

		// Token: 0x17000AF4 RID: 2804
		// (get) Token: 0x060015E4 RID: 5604 RVA: 0x0014E3B4 File Offset: 0x0014C5B4
		public bool TrkPerAnnouncementGroupAGKeySelect_A7414_HasDiffs
		{
			get
			{
				short num = (short)1970024783;
				short num2 = num;
				num = (short)672805199;
				switch (num2 == num)
				{
				}
				num = (short)732233729;
				if (num != 0)
				{
				}
				num = (short)417595392;
				if (num != 0)
				{
				}
				num = (short)1710292992;
				short num3 = num;
				return this.trkPerAnnouncementGroupAGKeySelect_A7414._HasDiffs;
			}
		}

		// Token: 0x17000AF5 RID: 2805
		// (get) Token: 0x060015E5 RID: 5605 RVA: 0x0014E468 File Offset: 0x0014C668
		// (set) Token: 0x060015E6 RID: 5606 RVA: 0x0014E51C File Offset: 0x0014C71C
		public int TrkPerAnnouncementGroupAnnouncementGroup_A7444Value
		{
			get
			{
				short num = (short)1440721436;
				short num2 = num;
				num = (short)2020452892;
				switch (num2 == num)
				{
				}
				num = (short)2103246849;
				if (num != 0)
				{
				}
				num = (short)1954742272;
				if (num != 0)
				{
				}
				num = (short)1319370752;
				short num3 = num;
				return this.trkPerAnnouncementGroupAnnouncementGroup_A7444.Value;
			}
			set
			{
				short num = (short)959620489;
				short num2 = num;
				num = (short)341812617;
				switch (num2 == num)
				{
				}
				num = (short)2004811777;
				if (num != 0)
				{
				}
				num = (short)540606464;
				if (num != 0)
				{
				}
				num = (short)2024013824;
				short num3 = num;
				this.trkPerAnnouncementGroupAnnouncementGroup_A7444.Value = value;
			}
		}

		// Token: 0x17000AF6 RID: 2806
		// (get) Token: 0x060015E7 RID: 5607 RVA: 0x0014E5D4 File Offset: 0x0014C7D4
		public global::AcpBusinessLayer.AcpCustomRangeField TrkPerAnnouncementGroupAnnouncementGroup_A7444
		{
			get
			{
				short num = (short)157052895;
				short num2 = num;
				num = (short)503672799;
				switch (num2 == num)
				{
				}
				num = (short)938016769;
				if (num != 0)
				{
				}
				num = (short)893714432;
				if (num != 0)
				{
				}
				num = (short)1102118912;
				short num3 = num;
				return this.trkPerAnnouncementGroupAnnouncementGroup_A7444;
			}
		}

		// Token: 0x17000AF7 RID: 2807
		// (get) Token: 0x060015E8 RID: 5608 RVA: 0x0014E684 File Offset: 0x0014C884
		// (set) Token: 0x060015E9 RID: 5609 RVA: 0x0014E73C File Offset: 0x0014C93C
		public string TrkPerAnnouncementGroupAnnouncementGroup_A7444_UIValue
		{
			get
			{
				short num = (short)488767489;
				if (num != 0)
				{
				}
				num = (short)17605467;
				short num2 = num;
				num = (short)290235227;
				switch (num2 == num)
				{
				}
				num = (short)1685782528;
				if (num != 0)
				{
				}
				num = (short)1609105408;
				short num3 = num;
				return this.trkPerAnnouncementGroupAnnouncementGroup_A7444.UIValue;
			}
			set
			{
				short num = (short)1759140387;
				short num2 = num;
				num = (short)1168792099;
				switch (num2 == num)
				{
				}
				num = (short)1120927745;
				if (num != 0)
				{
				}
				num = (short)2088960000;
				if (num != 0)
				{
				}
				num = (short)341639168;
				short num3 = num;
				this.trkPerAnnouncementGroupAnnouncementGroup_A7444.UIValue = value;
			}
		}

		// Token: 0x17000AF8 RID: 2808
		// (get) Token: 0x060015EA RID: 5610 RVA: 0x0014E7F0 File Offset: 0x0014C9F0
		// (set) Token: 0x060015EB RID: 5611 RVA: 0x0014E8A8 File Offset: 0x0014CAA8
		public string TrkPerAnnouncementGroupAnnouncementGroup_A7444_HexUIValue
		{
			get
			{
				short num = (short)865363743;
				short num2 = num;
				num = (short)1138321183;
				switch (num2 == num)
				{
				}
				num = (short)1306001409;
				if (num != 0)
				{
				}
				num = (short)702349312;
				if (num != 0)
				{
				}
				num = (short)368246784;
				short num3 = num;
				return this.trkPerAnnouncementGroupAnnouncementGroup_A7444.HexUIValue;
			}
			set
			{
				short num = (short)2019624754;
				short num2 = num;
				num = (short)2060322610;
				switch (num2 == num)
				{
				}
				num = (short)1472528384;
				if (num != 0)
				{
				}
				num = (short)1188036609;
				if (num != 0)
				{
				}
				num = (short)858324992;
				short num3 = num;
				this.trkPerAnnouncementGroupAnnouncementGroup_A7444.HexUIValue = value;
			}
		}

		// Token: 0x17000AF9 RID: 2809
		// (get) Token: 0x060015EC RID: 5612 RVA: 0x0014E960 File Offset: 0x0014CB60
		// (set) Token: 0x060015ED RID: 5613 RVA: 0x0014EA14 File Offset: 0x0014CC14
		internal int TrkPerAnnouncementGroupAnnouncementGroup_A7444Min
		{
			get
			{
				short num = (short)1723203584;
				short num2 = num;
				num = (short)1582039041;
				if (num != 0)
				{
				}
				num = (short)917374769;
				short num3 = num;
				num = (short)1981810481;
				switch (num3 == num)
				{
				}
				num = (short)610205696;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAnnouncementGroup_A7444.Min;
			}
			set
			{
				short num = (short)1150812160;
				short num2 = num;
				num = (short)1990656001;
				if (num != 0)
				{
				}
				num = (short)845477844;
				short num3 = num;
				num = (short)1707997140;
				switch (num3 == num)
				{
				}
				num = (short)1189806080;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAnnouncementGroup_A7444.Min = value;
			}
		}

		// Token: 0x17000AFA RID: 2810
		// (get) Token: 0x060015EE RID: 5614 RVA: 0x0014EAC8 File Offset: 0x0014CCC8
		// (set) Token: 0x060015EF RID: 5615 RVA: 0x0014EB7C File Offset: 0x0014CD7C
		internal int TrkPerAnnouncementGroupAnnouncementGroup_A7444Max
		{
			get
			{
				short num = (short)578355200;
				short num2 = num;
				num = (short)1033397442;
				short num3 = num;
				num = (short)1287677122;
				switch (num3 == num)
				{
				}
				num = (short)1768751105;
				if (num != 0)
				{
				}
				num = (short)72679424;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAnnouncementGroup_A7444.Max;
			}
			set
			{
				short num = (short)1107492864;
				short num2 = num;
				num = (short)656250850;
				short num3 = num;
				num = (short)929470434;
				switch (num3 == num)
				{
				}
				num = (short)1124270081;
				if (num != 0)
				{
				}
				num = (short)672661504;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAnnouncementGroup_A7444.Max = value;
			}
		}

		// Token: 0x17000AFB RID: 2811
		// (get) Token: 0x060015F0 RID: 5616 RVA: 0x0014EC30 File Offset: 0x0014CE30
		// (set) Token: 0x060015F1 RID: 5617 RVA: 0x0014ECE8 File Offset: 0x0014CEE8
		internal int TrkPerAnnouncementGroupAnnouncementGroup_A7444Step
		{
			get
			{
				short num = (short)1813250048;
				short num2 = num;
				num = (short)1953364918;
				short num3 = num;
				num = (short)419494838;
				switch (num3 == num)
				{
				}
				num = (short)514523137;
				if (num != 0)
				{
				}
				num = (short)1950679040;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAnnouncementGroup_A7444.StepSize;
			}
			set
			{
				short num = (short)311427072;
				short num2 = num;
				num = (short)1815206246;
				short num3 = num;
				num = (short)448059750;
				switch (num3 == num)
				{
				}
				num = (short)891289601;
				if (num != 0)
				{
				}
				num = (short)1357840384;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAnnouncementGroup_A7444.StepSize = value;
			}
		}

		// Token: 0x17000AFC RID: 2812
		// (get) Token: 0x060015F2 RID: 5618 RVA: 0x0014ED9C File Offset: 0x0014CF9C
		// (set) Token: 0x060015F3 RID: 5619 RVA: 0x0014EE50 File Offset: 0x0014D050
		public bool TrkPerAnnouncementGroupAnnouncementGroup_A7444_Applicable
		{
			get
			{
				short num = (short)477429760;
				short num2 = num;
				num = (short)378382156;
				short num3 = num;
				num = (short)1146333004;
				switch (num3 == num)
				{
				}
				num = (short)458489857;
				if (num != 0)
				{
				}
				num = (short)1140326400;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAnnouncementGroup_A7444.Applicable;
			}
			set
			{
				short num = (short)1060700160;
				short num2 = num;
				num = (short)1236074497;
				if (num != 0)
				{
				}
				num = (short)1482524365;
				short num3 = num;
				num = (short)230131405;
				switch (num3 == num)
				{
				}
				num = (short)42401792;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAnnouncementGroup_A7444.Applicable = value;
			}
		}

		// Token: 0x17000AFD RID: 2813
		// (get) Token: 0x060015F4 RID: 5620 RVA: 0x0014EF04 File Offset: 0x0014D104
		// (set) Token: 0x060015F5 RID: 5621 RVA: 0x0014EFB8 File Offset: 0x0014D1B8
		public bool TrkPerAnnouncementGroupAnnouncementGroup_A7444_Valid
		{
			get
			{
				short num = (short)514392064;
				short num2 = num;
				num = (short)1571293950;
				short num3 = num;
				num = (short)1641155326;
				switch (num3 == num)
				{
				}
				num = (short)1916731393;
				if (num != 0)
				{
				}
				num = (short)1657405440;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAnnouncementGroup_A7444.Valid;
			}
			set
			{
				short num = (short)57212928;
				short num2 = num;
				num = (short)472514561;
				if (num != 0)
				{
				}
				num = (short)1604673056;
				short num3 = num;
				num = (short)498294304;
				switch (num3 == num)
				{
				}
				num = (short)752877568;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAnnouncementGroup_A7444.Valid = value;
			}
		}

		// Token: 0x17000AFE RID: 2814
		// (get) Token: 0x060015F6 RID: 5622 RVA: 0x0014F06C File Offset: 0x0014D26C
		// (set) Token: 0x060015F7 RID: 5623 RVA: 0x0014F120 File Offset: 0x0014D320
		public bool TrkPerAnnouncementGroupAnnouncementGroup_A7444_Visible
		{
			get
			{
				short num = (short)1896022016;
				short num2 = num;
				num = (short)1472921601;
				if (num != 0)
				{
				}
				num = (short)1347054383;
				short num3 = num;
				num = (short)1115450159;
				switch (num3 == num)
				{
				}
				num = (short)1206386688;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAnnouncementGroup_A7444.Visible;
			}
			set
			{
				short num = (short)449576960;
				short num2 = num;
				num = (short)1901918464;
				short num3 = num;
				num = (short)363264256;
				switch (num3 == num)
				{
				}
				num = (short)195362817;
				if (num != 0)
				{
				}
				num = (short)1403912192;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAnnouncementGroup_A7444.Visible = value;
			}
		}

		// Token: 0x17000AFF RID: 2815
		// (get) Token: 0x060015F8 RID: 5624 RVA: 0x0014F1D4 File Offset: 0x0014D3D4
		// (set) Token: 0x060015F9 RID: 5625 RVA: 0x0014F28C File Offset: 0x0014D48C
		public bool TrkPerAnnouncementGroupAnnouncementGroup_A7444_Editable
		{
			get
			{
				short num = (short)1046151168;
				short num2 = num;
				num = (short)404817114;
				short num3 = num;
				num = (short)1486357722;
				switch (num3 == num)
				{
				}
				num = (short)1300627457;
				if (num != 0)
				{
				}
				num = (short)619511808;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAnnouncementGroup_A7444.Editable;
			}
			set
			{
				short num = (short)917110784;
				short num2 = num;
				num = (short)898071169;
				short num3 = num;
				num = (short)2133359233;
				switch (num3 == num)
				{
				}
				num = (short)129236993;
				if (num != 0)
				{
				}
				num = (short)496697344;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAnnouncementGroup_A7444.Editable = value;
			}
		}

		// Token: 0x17000B00 RID: 2816
		// (get) Token: 0x060015FA RID: 5626 RVA: 0x0014F340 File Offset: 0x0014D540
		internal string TrkPerAnnouncementGroupAnnouncementGroup_A7444_UILabel
		{
			get
			{
				short num = (short)309657600;
				short num2 = num;
				num = (short)1448024383;
				short num3 = num;
				num = (short)729749823;
				switch (num3 == num)
				{
				}
				num = (short)1255997441;
				if (num != 0)
				{
				}
				num = (short)1039269888;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAnnouncementGroup_A7444.UIName;
			}
		}

		// Token: 0x17000B01 RID: 2817
		// (get) Token: 0x060015FB RID: 5627 RVA: 0x0014F3F4 File Offset: 0x0014D5F4
		// (set) Token: 0x060015FC RID: 5628 RVA: 0x0014F4A8 File Offset: 0x0014D6A8
		internal bool TrkPerAnnouncementGroupAnnouncementGroup_A7444_HiddenStatic
		{
			get
			{
				short num = (short)1818296320;
				short num2 = num;
				num = (short)1793160061;
				short num3 = num;
				num = (short)947811197;
				switch (num3 == num)
				{
				}
				num = (short)1688535040;
				if (num != 0)
				{
				}
				num = (short)1978531841;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAnnouncementGroup_A7444.HiddenStatic;
			}
			set
			{
				short num = (short)926810112;
				short num2 = num;
				num = (short)1123222904;
				short num3 = num;
				num = (short)1576600952;
				switch (num3 == num)
				{
				}
				num = (short)1828585473;
				if (num != 0)
				{
				}
				num = (short)2102591488;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAnnouncementGroup_A7444.HiddenStatic = value;
			}
		}

		// Token: 0x17000B02 RID: 2818
		// (get) Token: 0x060015FD RID: 5629 RVA: 0x0014F55C File Offset: 0x0014D75C
		// (set) Token: 0x060015FE RID: 5630 RVA: 0x0014F610 File Offset: 0x0014D810
		internal bool TrkPerAnnouncementGroupAnnouncementGroup_A7444_HiddenDynamic
		{
			get
			{
				short num = (short)143261696;
				short num2 = num;
				num = (short)795739380;
				short num3 = num;
				num = (short)1920861428;
				switch (num3 == num)
				{
				}
				num = (short)287965184;
				if (num != 0)
				{
				}
				num = (short)1790771201;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAnnouncementGroup_A7444.HiddenDynamic;
			}
			set
			{
				short num = (short)1281228800;
				short num2 = num;
				num = (short)1079970206;
				short num3 = num;
				num = (short)14289310;
				switch (num3 == num)
				{
				}
				num = (short)785317889;
				if (num != 0)
				{
				}
				num = (short)741736448;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAnnouncementGroup_A7444.HiddenDynamic = value;
			}
		}

		// Token: 0x17000B03 RID: 2819
		// (get) Token: 0x060015FF RID: 5631 RVA: 0x0014F6C8 File Offset: 0x0014D8C8
		public bool TrkPerAnnouncementGroupAnnouncementGroup_A7444_HasDiffs
		{
			get
			{
				short num = (short)1821573120;
				short num2 = num;
				num = (short)1494031709;
				short num3 = num;
				num = (short)312810845;
				switch (num3 == num)
				{
				}
				num = (short)1367015425;
				if (num != 0)
				{
				}
				num = (short)21364736;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAnnouncementGroup_A7444._HasDiffs;
			}
		}

		// Token: 0x17000B04 RID: 2820
		// (get) Token: 0x06001600 RID: 5632 RVA: 0x0014F778 File Offset: 0x0014D978
		// (set) Token: 0x06001601 RID: 5633 RVA: 0x0014F82C File Offset: 0x0014DA2C
		public int TrkPerAnnouncementGroupAGVoiceSignalType_A7478Value
		{
			get
			{
				short num = (short)1993932800;
				short num2 = num;
				num = (short)1233911809;
				if (num != 0)
				{
				}
				num = (short)1431094915;
				short num3 = num;
				num = (short)2084423299;
				switch (num3 == num)
				{
				}
				num = (short)112263168;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGVoiceSignalType_A7478.Value;
			}
			set
			{
				short num = (short)495190016;
				short num2 = num;
				num = (short)490644911;
				short num3 = num;
				num = (short)319792559;
				switch (num3 == num)
				{
				}
				num = (short)998768640;
				if (num != 0)
				{
				}
				num = (short)1970077697;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAGVoiceSignalType_A7478.Value = value;
			}
		}

		// Token: 0x17000B05 RID: 2821
		// (get) Token: 0x06001602 RID: 5634 RVA: 0x0014F8E4 File Offset: 0x0014DAE4
		// (set) Token: 0x06001603 RID: 5635 RVA: 0x0014F998 File Offset: 0x0014DB98
		public string TrkPerAnnouncementGroupAGVoiceSignalType_A7478_UIValue
		{
			get
			{
				short num = (short)1855324160;
				short num2 = num;
				num = (short)385772886;
				short num3 = num;
				num = (short)1850240342;
				switch (num3 == num)
				{
				}
				num = (short)288292865;
				if (num != 0)
				{
				}
				num = (short)1867186176;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGVoiceSignalType_A7478.UIValue;
			}
			set
			{
				short num = (short)1468923904;
				short num2 = num;
				num = (short)2076978748;
				short num3 = num;
				num = (short)835268156;
				switch (num3 == num)
				{
				}
				num = (short)1846935553;
				if (num != 0)
				{
				}
				num = (short)828899328;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAGVoiceSignalType_A7478.UIValue = value;
			}
		}

		// Token: 0x17000B06 RID: 2822
		// (get) Token: 0x06001604 RID: 5636 RVA: 0x0014FA50 File Offset: 0x0014DC50
		public global::AcpBusinessLayer.AcpListField TrkPerAnnouncementGroupAGVoiceSignalType_A7478
		{
			get
			{
				short num = (short)2114060288;
				short num2 = num;
				num = (short)983442214;
				short num3 = num;
				num = (short)1970479910;
				switch (num3 == num)
				{
				}
				num = (short)1882324993;
				if (num != 0)
				{
				}
				num = (short)200540160;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGVoiceSignalType_A7478;
			}
		}

		// Token: 0x17000B07 RID: 2823
		// (get) Token: 0x06001605 RID: 5637 RVA: 0x0014FB00 File Offset: 0x0014DD00
		// (set) Token: 0x06001606 RID: 5638 RVA: 0x0014FBB8 File Offset: 0x0014DDB8
		public bool TrkPerAnnouncementGroupAGVoiceSignalType_A7478_Applicable
		{
			get
			{
				short num = (short)161153024;
				short num2 = num;
				num = (short)1116053886;
				short num3 = num;
				num = (short)1739301246;
				switch (num3 == num)
				{
				}
				num = (short)224395264;
				if (num != 0)
				{
				}
				num = (short)690946049;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGVoiceSignalType_A7478.Applicable;
			}
			set
			{
				short num = (short)1731526656;
				short num2 = num;
				num = (short)372495456;
				short num3 = num;
				num = (short)1936577632;
				switch (num3 == num)
				{
				}
				num = (short)1300496385;
				if (num != 0)
				{
				}
				num = (short)473759744;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAGVoiceSignalType_A7478.Applicable = value;
			}
		}

		// Token: 0x17000B08 RID: 2824
		// (get) Token: 0x06001607 RID: 5639 RVA: 0x0014FC70 File Offset: 0x0014DE70
		// (set) Token: 0x06001608 RID: 5640 RVA: 0x0014FD28 File Offset: 0x0014DF28
		public bool TrkPerAnnouncementGroupAGVoiceSignalType_A7478_Valid
		{
			get
			{
				short num = (short)1191378944;
				short num2 = num;
				num = (short)846712117;
				short num3 = num;
				num = (short)480103733;
				switch (num3 == num)
				{
				}
				num = (short)53411840;
				if (num != 0)
				{
				}
				num = (short)1712062465;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGVoiceSignalType_A7478.Valid;
			}
			set
			{
				short num = (short)237436928;
				short num2 = num;
				num = (short)2004802301;
				short num3 = num;
				num = (short)902748925;
				switch (num3 == num)
				{
				}
				num = (short)1476722689;
				if (num != 0)
				{
				}
				num = (short)663027712;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAGVoiceSignalType_A7478.Valid = value;
			}
		}

		// Token: 0x17000B09 RID: 2825
		// (get) Token: 0x06001609 RID: 5641 RVA: 0x0014FDDC File Offset: 0x0014DFDC
		// (set) Token: 0x0600160A RID: 5642 RVA: 0x0014FE94 File Offset: 0x0014E094
		public bool TrkPerAnnouncementGroupAGVoiceSignalType_A7478_Visible
		{
			get
			{
				short num = (short)1397686272;
				short num2 = num;
				num = (short)180041272;
				short num3 = num;
				num = (short)1334064696;
				switch (num3 == num)
				{
				}
				num = (short)1131085825;
				if (num != 0)
				{
				}
				num = (short)2110980096;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGVoiceSignalType_A7478.Visible;
			}
			set
			{
				short num = (short)1982595072;
				short num2 = num;
				num = (short)85458945;
				if (num != 0)
				{
				}
				num = (short)1888421071;
				short num3 = num;
				num = (short)249496783;
				switch (num3 == num)
				{
				}
				num = (short)1464926208;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAGVoiceSignalType_A7478.Visible = value;
			}
		}

		// Token: 0x17000B0A RID: 2826
		// (get) Token: 0x0600160B RID: 5643 RVA: 0x0014FF48 File Offset: 0x0014E148
		// (set) Token: 0x0600160C RID: 5644 RVA: 0x00150000 File Offset: 0x0014E200
		public bool TrkPerAnnouncementGroupAGVoiceSignalType_A7478_Editable
		{
			get
			{
				short num = (short)2048917504;
				short num2 = num;
				num = (short)2013371425;
				short num3 = num;
				num = (short)1553243169;
				switch (num3 == num)
				{
				}
				num = (short)12320769;
				if (num != 0)
				{
				}
				num = (short)1864695808;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGVoiceSignalType_A7478.Editable;
			}
			set
			{
				short num = (short)1729363968;
				short num2 = num;
				num = (short)601351924;
				short num3 = num;
				num = (short)2045110004;
				switch (num3 == num)
				{
				}
				num = (short)1045233664;
				if (num != 0)
				{
				}
				num = (short)628555777;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAGVoiceSignalType_A7478.Editable = value;
			}
		}

		// Token: 0x17000B0B RID: 2827
		// (get) Token: 0x0600160D RID: 5645 RVA: 0x001500B4 File Offset: 0x0014E2B4
		internal string TrkPerAnnouncementGroupAGVoiceSignalType_A7478_UILabel
		{
			get
			{
				short num = (short)1282736128;
				short num2 = num;
				num = (short)104800818;
				short num3 = num;
				num = (short)1380459058;
				switch (num3 == num)
				{
				}
				num = (short)1436024833;
				if (num != 0)
				{
				}
				num = (short)1715863552;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGVoiceSignalType_A7478.UIName;
			}
		}

		// Token: 0x17000B0C RID: 2828
		// (get) Token: 0x0600160E RID: 5646 RVA: 0x00150168 File Offset: 0x0014E368
		// (set) Token: 0x0600160F RID: 5647 RVA: 0x0015021C File Offset: 0x0014E41C
		internal bool TrkPerAnnouncementGroupAGVoiceSignalType_A7478_HiddenStatic
		{
			get
			{
				short num = (short)382337024;
				short num2 = num;
				num = (short)713312075;
				short num3 = num;
				num = (short)504776523;
				switch (num3 == num)
				{
				}
				num = (short)35520513;
				if (num != 0)
				{
				}
				num = (short)1078525952;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGVoiceSignalType_A7478.HiddenStatic;
			}
			set
			{
				short num = (short)365821952;
				short num2 = num;
				num = (short)2065531059;
				short num3 = num;
				num = (short)752124083;
				switch (num3 == num)
				{
				}
				num = (short)1939865600;
				if (num != 0)
				{
				}
				num = (short)1744699393;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAGVoiceSignalType_A7478.HiddenStatic = value;
			}
		}

		// Token: 0x17000B0D RID: 2829
		// (get) Token: 0x06001610 RID: 5648 RVA: 0x001502D0 File Offset: 0x0014E4D0
		// (set) Token: 0x06001611 RID: 5649 RVA: 0x00150384 File Offset: 0x0014E584
		internal bool TrkPerAnnouncementGroupAGVoiceSignalType_A7478_HiddenDynamic
		{
			get
			{
				short num = (short)367722496;
				short num2 = num;
				num = (short)1646810420;
				short num3 = num;
				num = (short)192173364;
				switch (num3 == num)
				{
				}
				num = (short)2111569920;
				if (num != 0)
				{
				}
				num = (short)685637633;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGVoiceSignalType_A7478.HiddenDynamic;
			}
			set
			{
				short num = (short)870055936;
				short num2 = num;
				num = (short)146394688;
				short num3 = num;
				num = (short)834457152;
				switch (num3 == num)
				{
				}
				num = (short)1676476416;
				if (num != 0)
				{
				}
				num = (short)329383937;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAGVoiceSignalType_A7478.HiddenDynamic = value;
			}
		}

		// Token: 0x17000B0E RID: 2830
		// (get) Token: 0x06001612 RID: 5650 RVA: 0x00150438 File Offset: 0x0014E638
		public bool TrkPerAnnouncementGroupAGVoiceSignalType_A7478_HasDiffs
		{
			get
			{
				short num = (short)955514880;
				short num2 = num;
				num = (short)759423359;
				short num3 = num;
				num = (short)1360126335;
				switch (num3 == num)
				{
				}
				num = (short)301400064;
				if (num != 0)
				{
				}
				num = (short)849018881;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGVoiceSignalType_A7478._HasDiffs;
			}
		}

		// Token: 0x17000B0F RID: 2831
		// (get) Token: 0x06001613 RID: 5651 RVA: 0x001504EC File Offset: 0x0014E6EC
		// (set) Token: 0x06001614 RID: 5652 RVA: 0x001505A4 File Offset: 0x0014E7A4
		public bool TrkPerAnnouncementGroupAnnouncementGroupFailsoft_A8597Value
		{
			get
			{
				short num = (short)1288306688;
				short num2 = num;
				num = (short)1645805569;
				if (num != 0)
				{
				}
				num = (short)1959052331;
				short num3 = num;
				num = (short)823051307;
				switch (num3 == num)
				{
				}
				num = (short)840499200;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAnnouncementGroupFailsoft_A8597.Value;
			}
			set
			{
				short num = (short)390266880;
				short num2 = num;
				num = (short)1900749133;
				short num3 = num;
				num = (short)446701901;
				switch (num3 == num)
				{
				}
				num = (short)1657929729;
				if (num != 0)
				{
				}
				num = (short)1909981184;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAnnouncementGroupFailsoft_A8597.Value = value;
			}
		}

		// Token: 0x17000B10 RID: 2832
		// (get) Token: 0x06001615 RID: 5653 RVA: 0x00150658 File Offset: 0x0014E858
		public global::AcpBusinessLayer.AcpField<bool> TrkPerAnnouncementGroupAnnouncementGroupFailsoft_A8597
		{
			get
			{
				short num = (short)225247232;
				short num2 = num;
				num = (short)133093455;
				short num3 = num;
				num = (short)604756047;
				switch (num3 == num)
				{
				}
				num = (short)1859846145;
				if (num != 0)
				{
				}
				num = (short)1892876288;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAnnouncementGroupFailsoft_A8597;
			}
		}

		// Token: 0x17000B11 RID: 2833
		// (get) Token: 0x06001616 RID: 5654 RVA: 0x00150704 File Offset: 0x0014E904
		// (set) Token: 0x06001617 RID: 5655 RVA: 0x001507B8 File Offset: 0x0014E9B8
		public bool TrkPerAnnouncementGroupAnnouncementGroupFailsoft_A8597_UIValue
		{
			get
			{
				short num = (short)446431232;
				short num2 = num;
				num = (short)1940605058;
				short num3 = num;
				num = (short)558188674;
				switch (num3 == num)
				{
				}
				num = (short)1627193345;
				if (num != 0)
				{
				}
				num = (short)1092091904;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAnnouncementGroupFailsoft_A8597.Value;
			}
			set
			{
				short num = (short)1116209152;
				short num2 = num;
				num = (short)1523800942;
				short num3 = num;
				num = (short)1660377966;
				switch (num3 == num)
				{
				}
				num = (short)39256065;
				if (num != 0)
				{
				}
				num = (short)530382848;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAnnouncementGroupFailsoft_A8597.Value = value;
			}
		}

		// Token: 0x17000B12 RID: 2834
		// (get) Token: 0x06001618 RID: 5656 RVA: 0x00150870 File Offset: 0x0014EA70
		// (set) Token: 0x06001619 RID: 5657 RVA: 0x00150924 File Offset: 0x0014EB24
		public bool TrkPerAnnouncementGroupAnnouncementGroupFailsoft_A8597_Applicable
		{
			get
			{
				short num = (short)163446784;
				short num2 = num;
				num = (short)2058524018;
				short num3 = num;
				num = (short)229348722;
				switch (num3 == num)
				{
				}
				num = (short)1669070849;
				if (num != 0)
				{
				}
				num = (short)492830720;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAnnouncementGroupFailsoft_A8597.Applicable;
			}
			set
			{
				short num = (short)1027670016;
				short num2 = num;
				num = (short)1988430702;
				short num3 = num;
				num = (short)1015221102;
				switch (num3 == num)
				{
				}
				num = (short)1186004993;
				if (num != 0)
				{
				}
				num = (short)2072182784;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAnnouncementGroupFailsoft_A8597.Applicable = value;
			}
		}

		// Token: 0x17000B13 RID: 2835
		// (get) Token: 0x0600161A RID: 5658 RVA: 0x001509D8 File Offset: 0x0014EBD8
		// (set) Token: 0x0600161B RID: 5659 RVA: 0x00150A8C File Offset: 0x0014EC8C
		public bool TrkPerAnnouncementGroupAnnouncementGroupFailsoft_A8597_Valid
		{
			get
			{
				short num = (short)504168448;
				short num2 = num;
				num = (short)436456;
				short num3 = num;
				num = (short)487762152;
				switch (num3 == num)
				{
				}
				num = (short)949878784;
				if (num != 0)
				{
				}
				num = (short)2083520513;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAnnouncementGroupFailsoft_A8597.Valid;
			}
			set
			{
				short num = (short)249561089;
				if (num != 0)
				{
				}
				num = (short)77201408;
				short num2 = num;
				num = (short)315471565;
				short num3 = num;
				num = (short)1021556429;
				switch (num3 == num)
				{
				}
				num = (short)260046848;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAnnouncementGroupFailsoft_A8597.Valid = value;
			}
		}

		// Token: 0x17000B14 RID: 2836
		// (get) Token: 0x0600161C RID: 5660 RVA: 0x00150B40 File Offset: 0x0014ED40
		// (set) Token: 0x0600161D RID: 5661 RVA: 0x00150BF4 File Offset: 0x0014EDF4
		public bool TrkPerAnnouncementGroupAnnouncementGroupFailsoft_A8597_Visible
		{
			get
			{
				short num = (short)1217237212;
				short num2 = num;
				num = (short)1685950684;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1312817152;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)282329089;
				if (num != 0)
				{
				}
				num = (short)1327235072;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAnnouncementGroupFailsoft_A8597.Visible;
			}
			set
			{
				short num = (short)2068591116;
				short num2 = num;
				num = (short)614216204;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1706819584;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)281739264;
				if (num != 0)
				{
				}
				num = (short)365887489;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAnnouncementGroupFailsoft_A8597.Visible = value;
			}
		}

		// Token: 0x17000B15 RID: 2837
		// (get) Token: 0x0600161E RID: 5662 RVA: 0x00150CA8 File Offset: 0x0014EEA8
		// (set) Token: 0x0600161F RID: 5663 RVA: 0x00150D5C File Offset: 0x0014EF5C
		public bool TrkPerAnnouncementGroupAnnouncementGroupFailsoft_A8597_Editable
		{
			get
			{
				short num = (short)782893057;
				if (num != 0)
				{
				}
				num = (short)22020096;
				short num2 = num;
				num = (short)1600103;
				short num3 = num;
				num = (short)1939106407;
				switch (num3 == num)
				{
				}
				num = (short)829620224;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAnnouncementGroupFailsoft_A8597.Editable;
			}
			set
			{
				short num = (short)1956446209;
				if (num != 0)
				{
				}
				num = (short)462159872;
				short num2 = num;
				num = (short)1294179942;
				short num3 = num;
				num = (short)848535142;
				switch (num3 == num)
				{
				}
				num = (short)777388032;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAnnouncementGroupFailsoft_A8597.Editable = value;
			}
		}

		// Token: 0x17000B16 RID: 2838
		// (get) Token: 0x06001620 RID: 5664 RVA: 0x00150E10 File Offset: 0x0014F010
		internal string TrkPerAnnouncementGroupAnnouncementGroupFailsoft_A8597_UILabel
		{
			get
			{
				short num = (short)715804804;
				short num2 = num;
				num = (short)622547076;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2065039360;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2103443457;
				if (num != 0)
				{
				}
				num = (short)746717184;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAnnouncementGroupFailsoft_A8597.UIName;
			}
		}

		// Token: 0x17000B17 RID: 2839
		// (get) Token: 0x06001621 RID: 5665 RVA: 0x00150EC4 File Offset: 0x0014F0C4
		// (set) Token: 0x06001622 RID: 5666 RVA: 0x00150F7C File Offset: 0x0014F17C
		internal bool TrkPerAnnouncementGroupAnnouncementGroupFailsoft_A8597_HiddenStatic
		{
			get
			{
				short num = (short)873548226;
				short num2 = num;
				num = (short)334776770;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1452015616;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)492634113;
				if (num != 0)
				{
				}
				num = (short)645988352;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAnnouncementGroupFailsoft_A8597.HiddenStatic;
			}
			set
			{
				short num = (short)1342783662;
				short num2 = num;
				num = (short)175456430;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1217069056;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)185139200;
				if (num != 0)
				{
				}
				num = (short)1621229569;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAnnouncementGroupFailsoft_A8597.HiddenStatic = value;
			}
		}

		// Token: 0x17000B18 RID: 2840
		// (get) Token: 0x06001623 RID: 5667 RVA: 0x00151030 File Offset: 0x0014F230
		// (set) Token: 0x06001624 RID: 5668 RVA: 0x001510E4 File Offset: 0x0014F2E4
		internal bool TrkPerAnnouncementGroupAnnouncementGroupFailsoft_A8597_HiddenDynamic
		{
			get
			{
				short num = (short)205520897;
				if (num != 0)
				{
				}
				num = (short)580059136;
				short num2 = num;
				num = (short)472342914;
				short num3 = num;
				num = (short)612393346;
				switch (num3 == num)
				{
				}
				num = (short)135069696;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAnnouncementGroupFailsoft_A8597.HiddenDynamic;
			}
			set
			{
				short num = (short)573672062;
				short num2 = num;
				num = (short)309365374;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1916141568;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1553006593;
				if (num != 0)
				{
				}
				num = (short)2130444288;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAnnouncementGroupFailsoft_A8597.HiddenDynamic = value;
			}
		}

		// Token: 0x17000B19 RID: 2841
		// (get) Token: 0x06001625 RID: 5669 RVA: 0x00151198 File Offset: 0x0014F398
		public bool TrkPerAnnouncementGroupAnnouncementGroupFailsoft_A8597_HasDiffs
		{
			get
			{
				short num = (short)1355101829;
				short num2 = num;
				num = (short)332871301;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1457455104;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)353697792;
				if (num != 0)
				{
				}
				num = (short)2053898241;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAnnouncementGroupFailsoft_A8597._HasDiffs;
			}
		}

		// Token: 0x17000B1A RID: 2842
		// (get) Token: 0x06001626 RID: 5670 RVA: 0x0015124C File Offset: 0x0014F44C
		// (set) Token: 0x06001627 RID: 5671 RVA: 0x00151300 File Offset: 0x0014F500
		public int TrkPerAnnouncementGroupAGSecureClearStrapping_A9089Value
		{
			get
			{
				short num = (short)1276409019;
				short num2 = num;
				num = (short)560100539;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1774190592;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)111214592;
				if (num != 0)
				{
				}
				num = (short)1725235201;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGSecureClearStrapping_A9089.Value;
			}
			set
			{
				short num = (short)1319524920;
				short num2 = num;
				num = (short)844782136;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1323827200;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1576271873;
				if (num != 0)
				{
				}
				num = (short)1318322176;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAGSecureClearStrapping_A9089.Value = value;
			}
		}

		// Token: 0x17000B1B RID: 2843
		// (get) Token: 0x06001628 RID: 5672 RVA: 0x001513B4 File Offset: 0x0014F5B4
		// (set) Token: 0x06001629 RID: 5673 RVA: 0x0015146C File Offset: 0x0014F66C
		public string TrkPerAnnouncementGroupAGSecureClearStrapping_A9089_UIValue
		{
			get
			{
				short num = (short)553780486;
				short num2 = num;
				num = (short)35587334;
				switch (num2 == num)
				{
				default:
				{
					num = (short)303890432;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)216006656;
				if (num != 0)
				{
				}
				num = (short)1081147393;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGSecureClearStrapping_A9089.UIValue;
			}
			set
			{
				short num = (short)965859863;
				short num2 = num;
				num = (short)436722199;
				switch (num2 == num)
				{
				default:
				{
					num = (short)482279424;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1539112961;
				if (num != 0)
				{
				}
				num = (short)1250164736;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAGSecureClearStrapping_A9089.UIValue = value;
			}
		}

		// Token: 0x17000B1C RID: 2844
		// (get) Token: 0x0600162A RID: 5674 RVA: 0x00151520 File Offset: 0x0014F720
		public global::AcpBusinessLayer.AcpListField TrkPerAnnouncementGroupAGSecureClearStrapping_A9089
		{
			get
			{
				short num = (short)1839508431;
				short num2 = num;
				num = (short)793619407;
				switch (num2 == num)
				{
				default:
				{
					num = (short)878706688;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)883425280;
				if (num != 0)
				{
				}
				num = (short)1813970945;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGSecureClearStrapping_A9089;
			}
		}

		// Token: 0x17000B1D RID: 2845
		// (get) Token: 0x0600162B RID: 5675 RVA: 0x001515D0 File Offset: 0x0014F7D0
		// (set) Token: 0x0600162C RID: 5676 RVA: 0x00151684 File Offset: 0x0014F884
		public bool TrkPerAnnouncementGroupAGSecureClearStrapping_A9089_Applicable
		{
			get
			{
				short num = (short)725472454;
				short num2 = num;
				num = (short)962450630;
				switch (num2 == num)
				{
				default:
				{
					num = (short)342622208;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1142554624;
				if (num != 0)
				{
				}
				num = (short)1674969089;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGSecureClearStrapping_A9089.Applicable;
			}
			set
			{
				short num = (short)1961908561;
				short num2 = num;
				num = (short)1977047377;
				switch (num2 == num)
				{
				default:
				{
					num = (short)253558784;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1857159168;
				if (num != 0)
				{
				}
				num = (short)1097007105;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAGSecureClearStrapping_A9089.Applicable = value;
			}
		}

		// Token: 0x17000B1E RID: 2846
		// (get) Token: 0x0600162D RID: 5677 RVA: 0x00151738 File Offset: 0x0014F938
		// (set) Token: 0x0600162E RID: 5678 RVA: 0x001517EC File Offset: 0x0014F9EC
		public bool TrkPerAnnouncementGroupAGSecureClearStrapping_A9089_Valid
		{
			get
			{
				short num = (short)387305229;
				short num2 = num;
				num = (short)279039757;
				switch (num2 == num)
				{
				default:
				{
					num = (short)161611776;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)440336384;
				if (num != 0)
				{
				}
				num = (short)1115029505;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGSecureClearStrapping_A9089.Valid;
			}
			set
			{
				short num = (short)1539183115;
				short num2 = num;
				num = (short)1745031691;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1672609792;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)51314689;
				if (num != 0)
				{
				}
				num = (short)1271660544;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAGSecureClearStrapping_A9089.Valid = value;
			}
		}

		// Token: 0x17000B1F RID: 2847
		// (get) Token: 0x0600162F RID: 5679 RVA: 0x001518A0 File Offset: 0x0014FAA0
		// (set) Token: 0x06001630 RID: 5680 RVA: 0x00151954 File Offset: 0x0014FB54
		public bool TrkPerAnnouncementGroupAGSecureClearStrapping_A9089_Visible
		{
			get
			{
				short num = (short)811721384;
				short num2 = num;
				num = (short)2096685736;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1639776256;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1389494272;
				if (num != 0)
				{
				}
				num = (short)452657153;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGSecureClearStrapping_A9089.Visible;
			}
			set
			{
				short num = (short)1059861302;
				short num2 = num;
				num = (short)657339190;
				switch (num2 == num)
				{
				default:
				{
					num = (short)643235840;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)174129152;
				if (num != 0)
				{
				}
				num = (short)1517486081;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAGSecureClearStrapping_A9089.Visible = value;
			}
		}

		// Token: 0x17000B20 RID: 2848
		// (get) Token: 0x06001631 RID: 5681 RVA: 0x00151A08 File Offset: 0x0014FC08
		// (set) Token: 0x06001632 RID: 5682 RVA: 0x00151ABC File Offset: 0x0014FCBC
		public bool TrkPerAnnouncementGroupAGSecureClearStrapping_A9089_Editable
		{
			get
			{
				short num = (short)1194104972;
				short num2 = num;
				num = (short)1835440268;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1496711168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)173932544;
				if (num != 0)
				{
				}
				num = (short)867696641;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGSecureClearStrapping_A9089.Editable;
			}
			set
			{
				short num = (short)867573320;
				short num2 = num;
				num = (short)1477058120;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1839005696;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)300154881;
				if (num != 0)
				{
				}
				num = (short)714801152;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAGSecureClearStrapping_A9089.Editable = value;
			}
		}

		// Token: 0x17000B21 RID: 2849
		// (get) Token: 0x06001633 RID: 5683 RVA: 0x00151B74 File Offset: 0x0014FD74
		internal string TrkPerAnnouncementGroupAGSecureClearStrapping_A9089_UILabel
		{
			get
			{
				short num = (short)37238583;
				short num2 = num;
				num = (short)1081620279;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1632108544;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1933312001;
				if (num != 0)
				{
				}
				num = (short)224788480;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGSecureClearStrapping_A9089.UIName;
			}
		}

		// Token: 0x17000B22 RID: 2850
		// (get) Token: 0x06001634 RID: 5684 RVA: 0x00151C28 File Offset: 0x0014FE28
		// (set) Token: 0x06001635 RID: 5685 RVA: 0x00151CDC File Offset: 0x0014FEDC
		internal bool TrkPerAnnouncementGroupAGSecureClearStrapping_A9089_HiddenStatic
		{
			get
			{
				short num = (short)960242549;
				short num2 = num;
				num = (short)1065821045;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1203175424;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1693188096;
				if (num != 0)
				{
				}
				num = (short)1133379585;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGSecureClearStrapping_A9089.HiddenStatic;
			}
			set
			{
				short num = (short)321912833;
				if (num != 0)
				{
				}
				num = (short)213712896;
				short num2 = num;
				num = (short)1821263219;
				short num3 = num;
				num = (short)1919108467;
				switch (num3 == num)
				{
				}
				num = (short)646250496;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAGSecureClearStrapping_A9089.HiddenStatic = value;
			}
		}

		// Token: 0x17000B23 RID: 2851
		// (get) Token: 0x06001636 RID: 5686 RVA: 0x00151D94 File Offset: 0x0014FF94
		// (set) Token: 0x06001637 RID: 5687 RVA: 0x00151E48 File Offset: 0x00150048
		internal bool TrkPerAnnouncementGroupAGSecureClearStrapping_A9089_HiddenDynamic
		{
			get
			{
				short num = (short)725154831;
				short num2 = num;
				num = (short)1558248463;
				switch (num2 == num)
				{
				default:
				{
					num = (short)962920448;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)465436673;
				if (num != 0)
				{
				}
				num = (short)1548156928;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGSecureClearStrapping_A9089.HiddenDynamic;
			}
			set
			{
				short num = (short)1208610355;
				short num2 = num;
				num = (short)411889203;
				switch (num2 == num)
				{
				default:
				{
					num = (short)618528768;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)945422336;
				if (num != 0)
				{
				}
				num = (short)308412417;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAGSecureClearStrapping_A9089.HiddenDynamic = value;
			}
		}

		// Token: 0x17000B24 RID: 2852
		// (get) Token: 0x06001638 RID: 5688 RVA: 0x00151EFC File Offset: 0x001500FC
		public bool TrkPerAnnouncementGroupAGSecureClearStrapping_A9089_HasDiffs
		{
			get
			{
				short num = (short)851008812;
				short num2 = num;
				num = (short)313417004;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1427308544;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1737293825;
				if (num != 0)
				{
				}
				num = (short)2127167488;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGSecureClearStrapping_A9089._HasDiffs;
			}
		}

		// Token: 0x17000B25 RID: 2853
		// (get) Token: 0x06001639 RID: 5689 RVA: 0x00151FB0 File Offset: 0x001501B0
		// (set) Token: 0x0600163A RID: 5690 RVA: 0x00152064 File Offset: 0x00150264
		public int TrkPerAnnouncementGroupAGFailsoftRxFrequencyMHz_A9582Value
		{
			get
			{
				short num = (short)154997224;
				short num2 = num;
				num = (short)746131944;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1837629440;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1691549696;
				if (num != 0)
				{
				}
				num = (short)1610153985;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGFailsoftRxFrequencyMHz_A9582.Value;
			}
			set
			{
				short num = (short)1328087041;
				if (num != 0)
				{
				}
				num = (short)1760559104;
				short num2 = num;
				num = (short)1006016714;
				short num3 = num;
				num = (short)735615178;
				switch (num3 == num)
				{
				}
				num = (short)2128412672;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAGFailsoftRxFrequencyMHz_A9582.Value = value;
			}
		}

		// Token: 0x17000B26 RID: 2854
		// (get) Token: 0x0600163B RID: 5691 RVA: 0x0015211C File Offset: 0x0015031C
		// (set) Token: 0x0600163C RID: 5692 RVA: 0x001521D0 File Offset: 0x001503D0
		public string TrkPerAnnouncementGroupAGFailsoftRxFrequencyMHz_A9582_UIValue
		{
			get
			{
				short num = (short)154474423;
				short num2 = num;
				num = (short)1467946935;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1496121344;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)236847104;
				if (num != 0)
				{
				}
				num = (short)370606081;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGFailsoftRxFrequencyMHz_A9582.UIValue;
			}
			set
			{
				short num = (short)1608974337;
				if (num != 0)
				{
				}
				num = (short)606732288;
				short num2 = num;
				num = (short)757201045;
				short num3 = num;
				num = (short)1894381717;
				switch (num3 == num)
				{
				}
				num = (short)705232896;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAGFailsoftRxFrequencyMHz_A9582.UIValue = value;
			}
		}

		// Token: 0x17000B27 RID: 2855
		// (get) Token: 0x0600163D RID: 5693 RVA: 0x00152284 File Offset: 0x00150484
		public global::AcpBusinessLayer.AcpFrequencyField TrkPerAnnouncementGroupAGFailsoftRxFrequencyMHz_A9582
		{
			get
			{
				short num = (short)1041636755;
				short num2 = num;
				num = (short)264773011;
				switch (num2 == num)
				{
				default:
				{
					num = (short)664338432;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)741474305;
				if (num != 0)
				{
				}
				num = (short)852099072;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGFailsoftRxFrequencyMHz_A9582;
			}
		}

		// Token: 0x17000B28 RID: 2856
		// (get) Token: 0x0600163E RID: 5694 RVA: 0x00152330 File Offset: 0x00150530
		// (set) Token: 0x0600163F RID: 5695 RVA: 0x001523E4 File Offset: 0x001505E4
		internal int TrkPerAnnouncementGroupAGFailsoftRxFrequencyMHz_A9582Min
		{
			get
			{
				short num = (short)22282241;
				if (num != 0)
				{
				}
				num = (short)47775744;
				short num2 = num;
				num = (short)2084125784;
				short num3 = num;
				num = (short)864828504;
				switch (num3 == num)
				{
				}
				num = (short)1010368512;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGFailsoftRxFrequencyMHz_A9582.Min;
			}
			set
			{
				short num = (short)940746993;
				short num2 = num;
				num = (short)906012913;
				switch (num2 == num)
				{
				default:
				{
					num = (short)469499904;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)39780353;
				if (num != 0)
				{
				}
				num = (short)1545928704;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAGFailsoftRxFrequencyMHz_A9582.Min = value;
			}
		}

		// Token: 0x17000B29 RID: 2857
		// (get) Token: 0x06001640 RID: 5696 RVA: 0x0015249C File Offset: 0x0015069C
		// (set) Token: 0x06001641 RID: 5697 RVA: 0x00152550 File Offset: 0x00150750
		internal int TrkPerAnnouncementGroupAGFailsoftRxFrequencyMHz_A9582Max
		{
			get
			{
				short num = (short)473038849;
				if (num != 0)
				{
				}
				num = (short)480641024;
				short num2 = num;
				num = (short)71617489;
				short num3 = num;
				num = (short)290769873;
				switch (num3 == num)
				{
				}
				num = (short)1118240768;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGFailsoftRxFrequencyMHz_A9582.Max;
			}
			set
			{
				short num = (short)1025179649;
				if (num != 0)
				{
				}
				num = (short)701693952;
				short num2 = num;
				num = (short)573138536;
				short num3 = num;
				num = (short)388327016;
				switch (num3 == num)
				{
				}
				num = (short)1108738048;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAGFailsoftRxFrequencyMHz_A9582.Max = value;
			}
		}

		// Token: 0x17000B2A RID: 2858
		// (get) Token: 0x06001642 RID: 5698 RVA: 0x00152608 File Offset: 0x00150808
		// (set) Token: 0x06001643 RID: 5699 RVA: 0x001526C0 File Offset: 0x001508C0
		internal int TrkPerAnnouncementGroupAGFailsoftRxFrequencyMHz_A9582Step
		{
			get
			{
				short num = (short)2017282973;
				short num2 = num;
				num = (short)1330138013;
				switch (num2 == num)
				{
				default:
				{
					num = (short)979435520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2145320961;
				if (num != 0)
				{
				}
				num = (short)466550784;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGFailsoftRxFrequencyMHz_A9582.StepSize;
			}
			set
			{
				short num = (short)356359474;
				short num2 = num;
				num = (short)1227136306;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1299775488;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1037238273;
				if (num != 0)
				{
				}
				num = (short)2145124352;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAGFailsoftRxFrequencyMHz_A9582.StepSize = value;
			}
		}

		// Token: 0x17000B2B RID: 2859
		// (get) Token: 0x06001644 RID: 5700 RVA: 0x00152778 File Offset: 0x00150978
		// (set) Token: 0x06001645 RID: 5701 RVA: 0x0015282C File Offset: 0x00150A2C
		public bool TrkPerAnnouncementGroupAGFailsoftRxFrequencyMHz_A9582_Applicable
		{
			get
			{
				short num = (short)6545795;
				short num2 = num;
				num = (short)1792008579;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1114439680;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)171573249;
				if (num != 0)
				{
				}
				num = (short)1495859200;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGFailsoftRxFrequencyMHz_A9582.Applicable;
			}
			set
			{
				short num = (short)1605756360;
				short num2 = num;
				num = (short)954983880;
				switch (num2 == num)
				{
				default:
				{
					num = (short)90636288;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1315962881;
				if (num != 0)
				{
				}
				num = (short)1064173568;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAGFailsoftRxFrequencyMHz_A9582.Applicable = value;
			}
		}

		// Token: 0x17000B2C RID: 2860
		// (get) Token: 0x06001646 RID: 5702 RVA: 0x001528E0 File Offset: 0x00150AE0
		// (set) Token: 0x06001647 RID: 5703 RVA: 0x00152998 File Offset: 0x00150B98
		public bool TrkPerAnnouncementGroupAGFailsoftRxFrequencyMHz_A9582_Valid
		{
			get
			{
				short num = (short)1973616641;
				if (num != 0)
				{
				}
				num = (short)1506541568;
				short num2 = num;
				num = (short)1273427509;
				short num3 = num;
				num = (short)2033514037;
				switch (num3 == num)
				{
				}
				num = (short)43319296;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGFailsoftRxFrequencyMHz_A9582.Valid;
			}
			set
			{
				short num = (short)1516314286;
				short num2 = num;
				num = (short)731389614;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1479147520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1245052928;
				if (num != 0)
				{
				}
				num = (short)1577123841;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAGFailsoftRxFrequencyMHz_A9582.Valid = value;
			}
		}

		// Token: 0x17000B2D RID: 2861
		// (get) Token: 0x06001648 RID: 5704 RVA: 0x00152A50 File Offset: 0x00150C50
		// (set) Token: 0x06001649 RID: 5705 RVA: 0x00152B04 File Offset: 0x00150D04
		public bool TrkPerAnnouncementGroupAGFailsoftRxFrequencyMHz_A9582_Visible
		{
			get
			{
				short num = (short)1327890433;
				if (num != 0)
				{
				}
				num = (short)2130925957;
				short num2 = num;
				num = (short)1147689349;
				switch (num2 == num)
				{
				}
				num = (short)2107179008;
				short num3 = num;
				num = (short)1150681088;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGFailsoftRxFrequencyMHz_A9582.Visible;
			}
			set
			{
				short num = (short)1282770759;
				short num2 = num;
				num = (short)982550343;
				switch (num2 == num)
				{
				}
				num = (short)1795883009;
				if (num != 0)
				{
				}
				num = (short)1008074752;
				short num3 = num;
				num = (short)993394688;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAGFailsoftRxFrequencyMHz_A9582.Visible = value;
			}
		}

		// Token: 0x17000B2E RID: 2862
		// (get) Token: 0x0600164A RID: 5706 RVA: 0x00152BBC File Offset: 0x00150DBC
		// (set) Token: 0x0600164B RID: 5707 RVA: 0x00152C70 File Offset: 0x00150E70
		public bool TrkPerAnnouncementGroupAGFailsoftRxFrequencyMHz_A9582_Editable
		{
			get
			{
				short num = (short)319209253;
				short num2 = num;
				num = (short)1503313701;
				switch (num2 == num)
				{
				}
				num = (short)414842881;
				if (num != 0)
				{
				}
				num = (short)980615168;
				short num3 = num;
				num = (short)2114846720;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGFailsoftRxFrequencyMHz_A9582.Editable;
			}
			set
			{
				short num = (short)284837686;
				short num2 = num;
				num = (short)1843873590;
				switch (num2 == num)
				{
				}
				num = (short)1956642817;
				if (num != 0)
				{
				}
				num = (short)1437532160;
				short num3 = num;
				num = (short)1585840128;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAGFailsoftRxFrequencyMHz_A9582.Editable = value;
			}
		}

		// Token: 0x17000B2F RID: 2863
		// (get) Token: 0x0600164C RID: 5708 RVA: 0x00152D28 File Offset: 0x00150F28
		internal string TrkPerAnnouncementGroupAGFailsoftRxFrequencyMHz_A9582_UILabel
		{
			get
			{
				short num = (short)1704406144;
				short num2 = num;
				num = (short)825437312;
				switch (num2 == num)
				{
				}
				num = (short)1199308801;
				if (num != 0)
				{
				}
				num = (short)435683328;
				short num3 = num;
				num = (short)1979842560;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGFailsoftRxFrequencyMHz_A9582.UIName;
			}
		}

		// Token: 0x17000B30 RID: 2864
		// (get) Token: 0x0600164D RID: 5709 RVA: 0x00152DD8 File Offset: 0x00150FD8
		// (set) Token: 0x0600164E RID: 5710 RVA: 0x00152E8C File Offset: 0x0015108C
		internal bool TrkPerAnnouncementGroupAGFailsoftRxFrequencyMHz_A9582_HiddenStatic
		{
			get
			{
				short num = (short)892957628;
				short num2 = num;
				num = (short)2041213884;
				switch (num2 == num)
				{
				}
				num = (short)879886337;
				if (num != 0)
				{
				}
				num = (short)674234368;
				short num3 = num;
				num = (short)1653342208;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGFailsoftRxFrequencyMHz_A9582.HiddenStatic;
			}
			set
			{
				short num = (short)971047452;
				short num2 = num;
				num = (short)294060572;
				switch (num2 == num)
				{
				}
				num = (short)1116733441;
				if (num != 0)
				{
				}
				num = (short)1052966912;
				short num3 = num;
				num = (short)1269891072;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAGFailsoftRxFrequencyMHz_A9582.HiddenStatic = value;
			}
		}

		// Token: 0x17000B31 RID: 2865
		// (get) Token: 0x0600164F RID: 5711 RVA: 0x00152F40 File Offset: 0x00151140
		// (set) Token: 0x06001650 RID: 5712 RVA: 0x00152FF4 File Offset: 0x001511F4
		internal bool TrkPerAnnouncementGroupAGFailsoftRxFrequencyMHz_A9582_HiddenDynamic
		{
			get
			{
				short num = (short)673236580;
				short num2 = num;
				num = (short)859686500;
				switch (num2 == num)
				{
				}
				num = (short)1689583617;
				if (num != 0)
				{
				}
				num = (short)1629814784;
				short num3 = num;
				num = (short)315097088;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGFailsoftRxFrequencyMHz_A9582.HiddenDynamic;
			}
			set
			{
				short num = (short)1634793826;
				short num2 = num;
				num = (short)1362360674;
				switch (num2 == num)
				{
				}
				num = (short)1814495233;
				if (num != 0)
				{
				}
				num = (short)1945370624;
				short num3 = num;
				num = (short)1933967360;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAGFailsoftRxFrequencyMHz_A9582.HiddenDynamic = value;
			}
		}

		// Token: 0x17000B32 RID: 2866
		// (get) Token: 0x06001651 RID: 5713 RVA: 0x001530A8 File Offset: 0x001512A8
		public bool TrkPerAnnouncementGroupAGFailsoftRxFrequencyMHz_A9582_HasDiffs
		{
			get
			{
				short num = (short)1718863423;
				short num2 = num;
				num = (short)201180735;
				switch (num2 == num)
				{
				}
				num = (short)1548222464;
				if (num != 0)
				{
				}
				num = (short)1087111168;
				short num3 = num;
				num = (short)1539309569;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGFailsoftRxFrequencyMHz_A9582._HasDiffs;
			}
		}

		// Token: 0x17000B33 RID: 2867
		// (get) Token: 0x06001652 RID: 5714 RVA: 0x0015315C File Offset: 0x0015135C
		// (set) Token: 0x06001653 RID: 5715 RVA: 0x00153210 File Offset: 0x00151410
		public int TrkPerAnnouncementGroupAGFailsoftTxFrequencyMHz_A9583Value
		{
			get
			{
				short num = (short)437683094;
				short num2 = num;
				num = (short)112755606;
				switch (num2 == num)
				{
				}
				num = (short)251658241;
				if (num != 0)
				{
				}
				num = (short)1363542016;
				short num3 = num;
				num = (short)1071972352;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGFailsoftTxFrequencyMHz_A9583.Value;
			}
			set
			{
				short num = (short)15202384;
				short num2 = num;
				num = (short)1666316368;
				switch (num2 == num)
				{
				}
				num = (short)1406926848;
				if (num != 0)
				{
				}
				num = (short)983564288;
				short num3 = num;
				num = (short)1024000001;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAGFailsoftTxFrequencyMHz_A9583.Value = value;
			}
		}

		// Token: 0x17000B34 RID: 2868
		// (get) Token: 0x06001654 RID: 5716 RVA: 0x001532C4 File Offset: 0x001514C4
		// (set) Token: 0x06001655 RID: 5717 RVA: 0x00153378 File Offset: 0x00151578
		public string TrkPerAnnouncementGroupAGFailsoftTxFrequencyMHz_A9583_UIValue
		{
			get
			{
				short num = (short)1821053891;
				short num2 = num;
				num = (short)940839875;
				switch (num2 == num)
				{
				}
				num = (short)2068185089;
				if (num != 0)
				{
				}
				num = (short)1905000448;
				short num3 = num;
				num = (short)392560640;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGFailsoftTxFrequencyMHz_A9583.UIValue;
			}
			set
			{
				short num = (short)283915055;
				short num2 = num;
				num = (short)136000303;
				switch (num2 == num)
				{
				}
				num = (short)208404481;
				if (num != 0)
				{
				}
				num = (short)1567883264;
				short num3 = num;
				num = (short)637861888;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAGFailsoftTxFrequencyMHz_A9583.UIValue = value;
			}
		}

		// Token: 0x17000B35 RID: 2869
		// (get) Token: 0x06001656 RID: 5718 RVA: 0x0015342C File Offset: 0x0015162C
		public global::AcpBusinessLayer.AcpFrequencyField TrkPerAnnouncementGroupAGFailsoftTxFrequencyMHz_A9583
		{
			get
			{
				short num = (short)218824705;
				if (num != 0)
				{
				}
				num = (short)1878948593;
				short num2 = num;
				num = (short)624327409;
				switch (num2 == num)
				{
				}
				num = (short)433324032;
				short num3 = num;
				num = (short)739704832;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGFailsoftTxFrequencyMHz_A9583;
			}
		}

		// Token: 0x17000B36 RID: 2870
		// (get) Token: 0x06001657 RID: 5719 RVA: 0x001534DC File Offset: 0x001516DC
		// (set) Token: 0x06001658 RID: 5720 RVA: 0x00153590 File Offset: 0x00151790
		internal int TrkPerAnnouncementGroupAGFailsoftTxFrequencyMHz_A9583Min
		{
			get
			{
				short num = (short)295373585;
				short num2 = num;
				num = (short)1402211089;
				switch (num2 == num)
				{
				}
				num = (short)1018953729;
				if (num != 0)
				{
				}
				num = (short)1008795648;
				short num3 = num;
				num = (short)501874688;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGFailsoftTxFrequencyMHz_A9583.Min;
			}
			set
			{
				short num = (short)1443561473;
				if (num != 0)
				{
				}
				num = (short)1272270258;
				short num2 = num;
				num = (short)1048333746;
				switch (num2 == num)
				{
				}
				num = (short)1958346752;
				short num3 = num;
				num = (short)1555693568;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAGFailsoftTxFrequencyMHz_A9583.Min = value;
			}
		}

		// Token: 0x17000B37 RID: 2871
		// (get) Token: 0x06001659 RID: 5721 RVA: 0x00153648 File Offset: 0x00151848
		// (set) Token: 0x0600165A RID: 5722 RVA: 0x001536FC File Offset: 0x001518FC
		internal int TrkPerAnnouncementGroupAGFailsoftTxFrequencyMHz_A9583Max
		{
			get
			{
				short num = (short)1400722043;
				short num2 = num;
				num = (short)1167544955;
				switch (num2 == num)
				{
				}
				num = (short)869072896;
				if (num != 0)
				{
				}
				num = (short)813563904;
				short num3 = num;
				num = (short)1179385857;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGFailsoftTxFrequencyMHz_A9583.Max;
			}
			set
			{
				short num = (short)38536278;
				short num2 = num;
				num = (short)1505690710;
				switch (num2 == num)
				{
				}
				num = (short)1687355393;
				if (num != 0)
				{
				}
				num = (short)2006319104;
				short num3 = num;
				num = (short)1516961792;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAGFailsoftTxFrequencyMHz_A9583.Max = value;
			}
		}

		// Token: 0x17000B38 RID: 2872
		// (get) Token: 0x0600165B RID: 5723 RVA: 0x001537B0 File Offset: 0x001519B0
		// (set) Token: 0x0600165C RID: 5724 RVA: 0x00153868 File Offset: 0x00151A68
		internal int TrkPerAnnouncementGroupAGFailsoftTxFrequencyMHz_A9583Step
		{
			get
			{
				short num = (short)1563850902;
				short num2 = num;
				num = (short)564295830;
				switch (num2 == num)
				{
				}
				num = (short)77004800;
				if (num != 0)
				{
				}
				num = (short)28966912;
				short num3 = num;
				num = (short)515178497;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGFailsoftTxFrequencyMHz_A9583.StepSize;
			}
			set
			{
				short num = (short)2107022779;
				short num2 = num;
				num = (short)671260091;
				switch (num2 == num)
				{
				}
				num = (short)1362100224;
				if (num != 0)
				{
				}
				num = (short)119013376;
				short num3 = num;
				num = (short)1545863169;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAGFailsoftTxFrequencyMHz_A9583.StepSize = value;
			}
		}

		// Token: 0x17000B39 RID: 2873
		// (get) Token: 0x0600165D RID: 5725 RVA: 0x0015391C File Offset: 0x00151B1C
		// (set) Token: 0x0600165E RID: 5726 RVA: 0x001539D4 File Offset: 0x00151BD4
		public bool TrkPerAnnouncementGroupAGFailsoftTxFrequencyMHz_A9583_Applicable
		{
			get
			{
				short num = (short)1804492036;
				short num2 = num;
				num = (short)1748524292;
				switch (num2 == num)
				{
				}
				num = (short)731512832;
				if (num != 0)
				{
				}
				num = (short)1714749440;
				short num3 = num;
				num = (short)1318060033;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGFailsoftTxFrequencyMHz_A9583.Applicable;
			}
			set
			{
				short num = (short)1466720674;
				short num2 = num;
				num = (short)314335650;
				switch (num2 == num)
				{
				}
				num = (short)1624244225;
				if (num != 0)
				{
				}
				num = (short)1571225600;
				short num3 = num;
				num = (short)869662720;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAGFailsoftTxFrequencyMHz_A9583.Applicable = value;
			}
		}

		// Token: 0x17000B3A RID: 2874
		// (get) Token: 0x0600165F RID: 5727 RVA: 0x00153A88 File Offset: 0x00151C88
		// (set) Token: 0x06001660 RID: 5728 RVA: 0x00153B3C File Offset: 0x00151D3C
		public bool TrkPerAnnouncementGroupAGFailsoftTxFrequencyMHz_A9583_Valid
		{
			get
			{
				short num = (short)510584690;
				short num2 = num;
				num = (short)1732503410;
				switch (num2 == num)
				{
				}
				num = (short)1226899457;
				if (num != 0)
				{
				}
				num = (short)1865351168;
				short num3 = num;
				num = (short)2136539136;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGFailsoftTxFrequencyMHz_A9583.Valid;
			}
			set
			{
				short num = (short)2105253310;
				short num2 = num;
				num = (short)1935449534;
				switch (num2 == num)
				{
				}
				num = (short)26738689;
				if (num != 0)
				{
				}
				num = (short)1186136064;
				short num3 = num;
				num = (short)2100756480;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAGFailsoftTxFrequencyMHz_A9583.Valid = value;
			}
		}

		// Token: 0x17000B3B RID: 2875
		// (get) Token: 0x06001661 RID: 5729 RVA: 0x00153BF0 File Offset: 0x00151DF0
		// (set) Token: 0x06001662 RID: 5730 RVA: 0x00153CA4 File Offset: 0x00151EA4
		public bool TrkPerAnnouncementGroupAGFailsoftTxFrequencyMHz_A9583_Visible
		{
			get
			{
				short num = (short)1111622366;
				short num2 = num;
				num = (short)33489630;
				switch (num2 == num)
				{
				}
				num = (short)1157824513;
				if (num != 0)
				{
				}
				num = (short)1326186496;
				short num3 = num;
				num = (short)90636288;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGFailsoftTxFrequencyMHz_A9583.Visible;
			}
			set
			{
				short num = (short)111937780;
				short num2 = num;
				num = (short)1848314100;
				switch (num2 == num)
				{
				}
				num = (short)1400635392;
				if (num != 0)
				{
				}
				num = (short)1758199808;
				short num3 = num;
				num = (short)910884865;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAGFailsoftTxFrequencyMHz_A9583.Visible = value;
			}
		}

		// Token: 0x17000B3C RID: 2876
		// (get) Token: 0x06001663 RID: 5731 RVA: 0x00153D5C File Offset: 0x00151F5C
		// (set) Token: 0x06001664 RID: 5732 RVA: 0x00153E10 File Offset: 0x00152010
		public bool TrkPerAnnouncementGroupAGFailsoftTxFrequencyMHz_A9583_Editable
		{
			get
			{
				short num = (short)482669289;
				short num2 = num;
				num = (short)2105406185;
				switch (num2 == num)
				{
				}
				num = (short)5767168;
				if (num != 0)
				{
				}
				num = (short)1034354688;
				short num3 = num;
				num = (short)1152974849;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGFailsoftTxFrequencyMHz_A9583.Editable;
			}
			set
			{
				short num = (short)1309180784;
				short num2 = num;
				num = (short)234324848;
				switch (num2 == num)
				{
				}
				num = (short)1785987073;
				if (num != 0)
				{
				}
				num = (short)2138636288;
				short num3 = num;
				num = (short)336003072;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAGFailsoftTxFrequencyMHz_A9583.Editable = value;
			}
		}

		// Token: 0x17000B3D RID: 2877
		// (get) Token: 0x06001665 RID: 5733 RVA: 0x00153EC4 File Offset: 0x001520C4
		internal string TrkPerAnnouncementGroupAGFailsoftTxFrequencyMHz_A9583_UILabel
		{
			get
			{
				short num = (short)1329296601;
				short num2 = num;
				num = (short)1410168025;
				switch (num2 == num)
				{
				}
				num = (short)1360527360;
				if (num != 0)
				{
				}
				num = (short)162856960;
				short num3 = num;
				num = (short)1355546625;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGFailsoftTxFrequencyMHz_A9583.UIName;
			}
		}

		// Token: 0x17000B3E RID: 2878
		// (get) Token: 0x06001666 RID: 5734 RVA: 0x00153F78 File Offset: 0x00152178
		// (set) Token: 0x06001667 RID: 5735 RVA: 0x0015402C File Offset: 0x0015222C
		internal bool TrkPerAnnouncementGroupAGFailsoftTxFrequencyMHz_A9583_HiddenStatic
		{
			get
			{
				short num = (short)1241710884;
				short num2 = num;
				num = (short)1421476132;
				switch (num2 == num)
				{
				}
				num = (short)441319425;
				if (num != 0)
				{
				}
				num = (short)15466496;
				short num3 = num;
				num = (short)253755392;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGFailsoftTxFrequencyMHz_A9583.HiddenStatic;
			}
			set
			{
				short num = (short)1810386286;
				short num2 = num;
				num = (short)1221152110;
				switch (num2 == num)
				{
				}
				num = (short)1572274177;
				if (num != 0)
				{
				}
				num = (short)1259339776;
				short num3 = num;
				num = (short)1494876160;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAGFailsoftTxFrequencyMHz_A9583.HiddenStatic = value;
			}
		}

		// Token: 0x17000B3F RID: 2879
		// (get) Token: 0x06001668 RID: 5736 RVA: 0x001540E0 File Offset: 0x001522E0
		// (set) Token: 0x06001669 RID: 5737 RVA: 0x00154194 File Offset: 0x00152394
		internal bool TrkPerAnnouncementGroupAGFailsoftTxFrequencyMHz_A9583_HiddenDynamic
		{
			get
			{
				short num = (short)1098949206;
				short num2 = num;
				num = (short)793879126;
				switch (num2 == num)
				{
				}
				num = (short)1514930176;
				if (num != 0)
				{
				}
				num = (short)1244069888;
				short num3 = num;
				num = (short)2079653889;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGFailsoftTxFrequencyMHz_A9583.HiddenDynamic;
			}
			set
			{
				short num = (short)1829502874;
				short num2 = num;
				num = (short)383451034;
				switch (num2 == num)
				{
				}
				num = (short)841482241;
				if (num != 0)
				{
				}
				num = (short)60948480;
				short num3 = num;
				num = (short)612630528;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAGFailsoftTxFrequencyMHz_A9583.HiddenDynamic = value;
			}
		}

		// Token: 0x17000B40 RID: 2880
		// (get) Token: 0x0600166A RID: 5738 RVA: 0x0015424C File Offset: 0x0015244C
		public bool TrkPerAnnouncementGroupAGFailsoftTxFrequencyMHz_A9583_HasDiffs
		{
			get
			{
				short num = (short)201711026;
				short num2 = num;
				num = (short)974314930;
				switch (num2 == num)
				{
				}
				num = (short)314769409;
				if (num != 0)
				{
				}
				num = (short)2140930048;
				short num3 = num;
				num = (short)728170496;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGFailsoftTxFrequencyMHz_A9583._HasDiffs;
			}
		}

		// Token: 0x17000B41 RID: 2881
		// (get) Token: 0x0600166B RID: 5739 RVA: 0x00154300 File Offset: 0x00152500
		// (set) Token: 0x0600166C RID: 5740 RVA: 0x001543B8 File Offset: 0x001525B8
		public int TrkPerAnnouncementGroupAGSecondaryFSTxFrequencyMHz_A12903Value
		{
			get
			{
				short num = (short)170433582;
				short num2 = num;
				num = (short)1198431278;
				switch (num2 == num)
				{
				}
				num = (short)265093121;
				if (num != 0)
				{
				}
				num = (short)187301888;
				short num3 = num;
				num = (short)1808662528;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGSecondaryFSTxFrequencyMHz_A12903.Value;
			}
			set
			{
				short num = (short)255624781;
				short num2 = num;
				num = (short)1389069901;
				switch (num2 == num)
				{
				}
				num = (short)1893269504;
				if (num != 0)
				{
				}
				num = (short)1241186304;
				short num3 = num;
				num = (short)322437121;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAGSecondaryFSTxFrequencyMHz_A12903.Value = value;
			}
		}

		// Token: 0x17000B42 RID: 2882
		// (get) Token: 0x0600166D RID: 5741 RVA: 0x0015446C File Offset: 0x0015266C
		// (set) Token: 0x0600166E RID: 5742 RVA: 0x00154520 File Offset: 0x00152720
		public string TrkPerAnnouncementGroupAGSecondaryFSTxFrequencyMHz_A12903_UIValue
		{
			get
			{
				short num = (short)627881177;
				short num2 = num;
				num = (short)1556067545;
				switch (num2 == num)
				{
				}
				num = (short)382140416;
				if (num != 0)
				{
				}
				num = (short)196608;
				short num3 = num;
				num = (short)510459905;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGSecondaryFSTxFrequencyMHz_A12903.UIValue;
			}
			set
			{
				short num = (short)1877852595;
				short num2 = num;
				num = (short)55951795;
				switch (num2 == num)
				{
				}
				num = (short)1566244865;
				if (num != 0)
				{
				}
				num = (short)2001272832;
				short num3 = num;
				num = (short)587923456;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAGSecondaryFSTxFrequencyMHz_A12903.UIValue = value;
			}
		}

		// Token: 0x17000B43 RID: 2883
		// (get) Token: 0x0600166F RID: 5743 RVA: 0x001545D4 File Offset: 0x001527D4
		public global::AcpBusinessLayer.AcpFrequencyField TrkPerAnnouncementGroupAGSecondaryFSTxFrequencyMHz_A12903
		{
			get
			{
				short num = (short)1035528559;
				short num2 = num;
				num = (short)1421601135;
				switch (num2 == num)
				{
				}
				num = (short)2125070337;
				if (num != 0)
				{
				}
				num = (short)473235456;
				short num3 = num;
				num = (short)1989869568;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGSecondaryFSTxFrequencyMHz_A12903;
			}
		}

		// Token: 0x17000B44 RID: 2884
		// (get) Token: 0x06001670 RID: 5744 RVA: 0x00154684 File Offset: 0x00152884
		// (set) Token: 0x06001671 RID: 5745 RVA: 0x0015473C File Offset: 0x0015293C
		internal int TrkPerAnnouncementGroupAGSecondaryFSTxFrequencyMHz_A12903Min
		{
			get
			{
				short num = (short)1197867009;
				if (num != 0)
				{
				}
				num = (short)1320882123;
				short num2 = num;
				num = (short)1396641739;
				switch (num2 == num)
				{
				}
				num = (short)2125070336;
				short num3 = num;
				num = (short)1315962880;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGSecondaryFSTxFrequencyMHz_A12903.Min;
			}
			set
			{
				short num = (short)1735447141;
				short num2 = num;
				num = (short)2108543589;
				switch (num2 == num)
				{
				}
				num = (short)1075970049;
				if (num != 0)
				{
				}
				num = (short)900005888;
				short num3 = num;
				num = (short)1112473600;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAGSecondaryFSTxFrequencyMHz_A12903.Min = value;
			}
		}

		// Token: 0x17000B45 RID: 2885
		// (get) Token: 0x06001672 RID: 5746 RVA: 0x001547F4 File Offset: 0x001529F4
		// (set) Token: 0x06001673 RID: 5747 RVA: 0x001548A8 File Offset: 0x00152AA8
		internal int TrkPerAnnouncementGroupAGSecondaryFSTxFrequencyMHz_A12903Max
		{
			get
			{
				short num = (short)451747412;
				short num2 = num;
				num = (short)1024597588;
				switch (num2 == num)
				{
				}
				num = (short)968622080;
				if (num != 0)
				{
				}
				num = (short)238419968;
				short num3 = num;
				num = (short)640417793;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGSecondaryFSTxFrequencyMHz_A12903.Max;
			}
			set
			{
				short num = (short)72692310;
				short num2 = num;
				num = (short)678113878;
				switch (num2 == num)
				{
				}
				num = (short)1208483841;
				if (num != 0)
				{
				}
				num = (short)1137770496;
				short num3 = num;
				num = (short)577568768;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAGSecondaryFSTxFrequencyMHz_A12903.Max = value;
			}
		}

		// Token: 0x17000B46 RID: 2886
		// (get) Token: 0x06001674 RID: 5748 RVA: 0x00154960 File Offset: 0x00152B60
		// (set) Token: 0x06001675 RID: 5749 RVA: 0x00154A14 File Offset: 0x00152C14
		internal int TrkPerAnnouncementGroupAGSecondaryFSTxFrequencyMHz_A12903Step
		{
			get
			{
				short num = (short)1249155581;
				short num2 = num;
				num = (short)1524472317;
				switch (num2 == num)
				{
				}
				num = (short)753205248;
				if (num != 0)
				{
				}
				num = (short)649396224;
				short num3 = num;
				num = (short)124321793;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGSecondaryFSTxFrequencyMHz_A12903.StepSize;
			}
			set
			{
				short num = (short)1356153864;
				short num2 = num;
				num = (short)824722440;
				switch (num2 == num)
				{
				}
				num = (short)560332801;
				if (num != 0)
				{
				}
				num = (short)1505951744;
				short num3 = num;
				num = (short)645136384;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAGSecondaryFSTxFrequencyMHz_A12903.StepSize = value;
			}
		}

		// Token: 0x17000B47 RID: 2887
		// (get) Token: 0x06001676 RID: 5750 RVA: 0x00154AC8 File Offset: 0x00152CC8
		// (set) Token: 0x06001677 RID: 5751 RVA: 0x00154B7C File Offset: 0x00152D7C
		public bool TrkPerAnnouncementGroupAGSecondaryFSTxFrequencyMHz_A12903_Applicable
		{
			get
			{
				short num = (short)518848513;
				if (num != 0)
				{
				}
				num = (short)1556452653;
				short num2 = num;
				num = (short)867472685;
				switch (num2 == num)
				{
				}
				num = (short)42860544;
				short num3 = num;
				num = (short)773783552;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGSecondaryFSTxFrequencyMHz_A12903.Applicable;
			}
			set
			{
				short num = (short)1492883617;
				short num2 = num;
				num = (short)2105120929;
				switch (num2 == num)
				{
				}
				num = (short)291897345;
				if (num != 0)
				{
				}
				num = (short)1169293312;
				short num3 = num;
				num = (short)832569344;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAGSecondaryFSTxFrequencyMHz_A12903.Applicable = value;
			}
		}

		// Token: 0x17000B48 RID: 2888
		// (get) Token: 0x06001678 RID: 5752 RVA: 0x00154C30 File Offset: 0x00152E30
		// (set) Token: 0x06001679 RID: 5753 RVA: 0x00154CE8 File Offset: 0x00152EE8
		public bool TrkPerAnnouncementGroupAGSecondaryFSTxFrequencyMHz_A12903_Valid
		{
			get
			{
				short num = (short)1181936503;
				short num2 = num;
				num = (short)636087159;
				switch (num2 == num)
				{
				}
				num = (short)288686080;
				if (num != 0)
				{
				}
				num = (short)2035023872;
				short num3 = num;
				num = (short)1729363969;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGSecondaryFSTxFrequencyMHz_A12903.Valid;
			}
			set
			{
				short num = (short)761282700;
				short num2 = num;
				num = (short)2084323468;
				switch (num2 == num)
				{
				}
				num = (short)1194590209;
				if (num != 0)
				{
				}
				num = (short)339673088;
				short num3 = num;
				num = (short)1381367808;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAGSecondaryFSTxFrequencyMHz_A12903.Valid = value;
			}
		}

		// Token: 0x17000B49 RID: 2889
		// (get) Token: 0x0600167A RID: 5754 RVA: 0x00154D9C File Offset: 0x00152F9C
		// (set) Token: 0x0600167B RID: 5755 RVA: 0x00154E50 File Offset: 0x00153050
		public bool TrkPerAnnouncementGroupAGSecondaryFSTxFrequencyMHz_A12903_Visible
		{
			get
			{
				short num = (short)515460991;
				short num2 = num;
				num = (short)621825919;
				switch (num2 == num)
				{
				}
				num = (short)1693188097;
				if (num != 0)
				{
				}
				num = (short)1597767680;
				short num3 = num;
				num = (short)1267204096;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGSecondaryFSTxFrequencyMHz_A12903.Visible;
			}
			set
			{
				short num = (short)1255444232;
				short num2 = num;
				num = (short)1747422984;
				switch (num2 == num)
				{
				}
				num = (short)1289617408;
				if (num != 0)
				{
				}
				num = (short)1586364416;
				short num3 = num;
				num = (short)1043988481;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAGSecondaryFSTxFrequencyMHz_A12903.Visible = value;
			}
		}

		// Token: 0x17000B4A RID: 2890
		// (get) Token: 0x0600167C RID: 5756 RVA: 0x00154F04 File Offset: 0x00153104
		// (set) Token: 0x0600167D RID: 5757 RVA: 0x00154FB8 File Offset: 0x001531B8
		public bool TrkPerAnnouncementGroupAGSecondaryFSTxFrequencyMHz_A12903_Editable
		{
			get
			{
				short num = (short)956293489;
				short num2 = num;
				num = (short)470344049;
				switch (num2 == num)
				{
				}
				num = (short)680722432;
				if (num != 0)
				{
				}
				num = (short)704315392;
				short num3 = num;
				num = (short)1812922369;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGSecondaryFSTxFrequencyMHz_A12903.Editable;
			}
			set
			{
				short num = (short)477888513;
				if (num != 0)
				{
				}
				num = (short)426212767;
				short num2 = num;
				num = (short)1463516575;
				switch (num2 == num)
				{
				}
				num = (short)1575616512;
				short num3 = num;
				num = (short)1629421568;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAGSecondaryFSTxFrequencyMHz_A12903.Editable = value;
			}
		}

		// Token: 0x17000B4B RID: 2891
		// (get) Token: 0x0600167E RID: 5758 RVA: 0x0015506C File Offset: 0x0015326C
		internal string TrkPerAnnouncementGroupAGSecondaryFSTxFrequencyMHz_A12903_UILabel
		{
			get
			{
				short num = (short)1118044161;
				if (num != 0)
				{
				}
				num = (short)736592115;
				short num2 = num;
				num = (short)180519155;
				switch (num2 == num)
				{
				}
				num = (short)149749760;
				short num3 = num;
				num = (short)601948160;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGSecondaryFSTxFrequencyMHz_A12903.UIName;
			}
		}

		// Token: 0x17000B4C RID: 2892
		// (get) Token: 0x0600167F RID: 5759 RVA: 0x00155124 File Offset: 0x00153324
		// (set) Token: 0x06001680 RID: 5760 RVA: 0x001551D8 File Offset: 0x001533D8
		internal bool TrkPerAnnouncementGroupAGSecondaryFSTxFrequencyMHz_A12903_HiddenStatic
		{
			get
			{
				short num = (short)1739193473;
				short num2 = num;
				num = (short)616037505;
				switch (num2 == num)
				{
				}
				num = (short)1225064449;
				if (num != 0)
				{
				}
				num = (short)2096889856;
				short num3 = num;
				num = (short)1814757376;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGSecondaryFSTxFrequencyMHz_A12903.HiddenStatic;
			}
			set
			{
				short num = (short)1292641700;
				short num2 = num;
				num = (short)413803940;
				switch (num2 == num)
				{
				}
				num = (short)370868225;
				if (num != 0)
				{
				}
				num = (short)816644096;
				short num3 = num;
				num = (short)1141637120;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAGSecondaryFSTxFrequencyMHz_A12903.HiddenStatic = value;
			}
		}

		// Token: 0x17000B4D RID: 2893
		// (get) Token: 0x06001681 RID: 5761 RVA: 0x00155290 File Offset: 0x00153490
		// (set) Token: 0x06001682 RID: 5762 RVA: 0x00155344 File Offset: 0x00153544
		internal bool TrkPerAnnouncementGroupAGSecondaryFSTxFrequencyMHz_A12903_HiddenDynamic
		{
			get
			{
				short num = (short)677304243;
				short num2 = num;
				num = (short)760141747;
				switch (num2 == num)
				{
				}
				num = (short)2094465024;
				if (num != 0)
				{
				}
				num = (short)609091584;
				short num3 = num;
				num = (short)1876033537;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGSecondaryFSTxFrequencyMHz_A12903.HiddenDynamic;
			}
			set
			{
				short num = (short)1643315201;
				if (num != 0)
				{
				}
				num = (short)1421650296;
				short num2 = num;
				num = (short)1113368952;
				switch (num2 == num)
				{
				}
				num = (short)1271529472;
				short num3 = num;
				num = (short)1702428672;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAGSecondaryFSTxFrequencyMHz_A12903.HiddenDynamic = value;
			}
		}

		// Token: 0x17000B4E RID: 2894
		// (get) Token: 0x06001683 RID: 5763 RVA: 0x001553F8 File Offset: 0x001535F8
		public bool TrkPerAnnouncementGroupAGSecondaryFSTxFrequencyMHz_A12903_HasDiffs
		{
			get
			{
				short num = (short)1641807872;
				short num2 = num;
				num = (short)1288962049;
				if (num != 0)
				{
				}
				num = (short)560212385;
				short num3 = num;
				num = (short)1472539041;
				switch (num3 == num)
				{
				}
				num = (short)837091328;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGSecondaryFSTxFrequencyMHz_A12903._HasDiffs;
			}
		}

		// Token: 0x17000B4F RID: 2895
		// (get) Token: 0x06001684 RID: 5764 RVA: 0x001554B0 File Offset: 0x001536B0
		// (set) Token: 0x06001685 RID: 5765 RVA: 0x00155564 File Offset: 0x00153764
		public int TrkPerAnnouncementGroupAGSystemID_A19705Value
		{
			get
			{
				short num = (short)353959936;
				short num2 = num;
				num = (short)1362193095;
				short num3 = num;
				num = (short)569469639;
				switch (num3 == num)
				{
				}
				num = (short)293470209;
				if (num != 0)
				{
				}
				num = (short)1489043456;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGSystemID_A19705.Value;
			}
			set
			{
				short num = (short)1616183296;
				short num2 = num;
				num = (short)629215027;
				short num3 = num;
				num = (short)1253576499;
				switch (num3 == num)
				{
				}
				num = (short)1524498433;
				if (num != 0)
				{
				}
				num = (short)994770944;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAGSystemID_A19705.Value = value;
			}
		}

		// Token: 0x17000B50 RID: 2896
		// (get) Token: 0x06001686 RID: 5766 RVA: 0x00155618 File Offset: 0x00153818
		public global::AcpBusinessLayer.AcpSimpleRangeField TrkPerAnnouncementGroupAGSystemID_A19705
		{
			get
			{
				short num = (short)762904576;
				short num2 = num;
				num = (short)935281396;
				short num3 = num;
				num = (short)444941044;
				switch (num3 == num)
				{
				}
				num = (short)292159489;
				if (num != 0)
				{
				}
				num = (short)1632370688;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGSystemID_A19705;
			}
		}

		// Token: 0x17000B51 RID: 2897
		// (get) Token: 0x06001687 RID: 5767 RVA: 0x001556CC File Offset: 0x001538CC
		// (set) Token: 0x06001688 RID: 5768 RVA: 0x00155780 File Offset: 0x00153980
		public string TrkPerAnnouncementGroupAGSystemID_A19705_UIValue
		{
			get
			{
				short num = (short)498270208;
				short num2 = num;
				num = (short)240485512;
				short num3 = num;
				num = (short)1748337800;
				switch (num3 == num)
				{
				}
				num = (short)521469953;
				if (num != 0)
				{
				}
				num = (short)130940928;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGSystemID_A19705.UIValue;
			}
			set
			{
				short num = (short)1342767104;
				short num2 = num;
				num = (short)1630717210;
				short num3 = num;
				num = (short)1072481562;
				switch (num3 == num)
				{
				}
				num = (short)2000420865;
				if (num != 0)
				{
				}
				num = (short)718995456;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAGSystemID_A19705.UIValue = value;
			}
		}

		// Token: 0x17000B52 RID: 2898
		// (get) Token: 0x06001689 RID: 5769 RVA: 0x00155838 File Offset: 0x00153A38
		// (set) Token: 0x0600168A RID: 5770 RVA: 0x001558EC File Offset: 0x00153AEC
		public string TrkPerAnnouncementGroupAGSystemID_A19705_HexUIValue
		{
			get
			{
				short num = (short)74186752;
				short num2 = num;
				num = (short)1507000321;
				if (num != 0)
				{
				}
				num = (short)1886336551;
				short num3 = num;
				num = (short)355939879;
				switch (num3 == num)
				{
				}
				num = (short)830537728;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGSystemID_A19705.HexUIValue;
			}
			set
			{
				short num = (short)1902575616;
				short num2 = num;
				num = (short)451805185;
				if (num != 0)
				{
				}
				num = (short)439965178;
				short num3 = num;
				num = (short)2015385082;
				switch (num3 == num)
				{
				}
				num = (short)395771904;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAGSystemID_A19705.HexUIValue = value;
			}
		}

		// Token: 0x17000B53 RID: 2899
		// (get) Token: 0x0600168B RID: 5771 RVA: 0x001559A4 File Offset: 0x00153BA4
		// (set) Token: 0x0600168C RID: 5772 RVA: 0x00155A58 File Offset: 0x00153C58
		internal int TrkPerAnnouncementGroupAGSystemID_A19705Min
		{
			get
			{
				short num = (short)179109888;
				short num2 = num;
				num = (short)1944649729;
				if (num != 0)
				{
				}
				num = (short)147199017;
				short num3 = num;
				num = (short)542905385;
				switch (num3 == num)
				{
				}
				num = (short)1902575616;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGSystemID_A19705.Min;
			}
			set
			{
				short num = (short)842203136;
				short num2 = num;
				num = (short)1752388989;
				short num3 = num;
				num = (short)1617384829;
				switch (num3 == num)
				{
				}
				num = (short)945160193;
				if (num != 0)
				{
				}
				num = (short)1516568576;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAGSystemID_A19705.Min = value;
			}
		}

		// Token: 0x17000B54 RID: 2900
		// (get) Token: 0x0600168D RID: 5773 RVA: 0x00155B0C File Offset: 0x00153D0C
		// (set) Token: 0x0600168E RID: 5774 RVA: 0x00155BC0 File Offset: 0x00153DC0
		internal int TrkPerAnnouncementGroupAGSystemID_A19705Max
		{
			get
			{
				short num = (short)1369243648;
				short num2 = num;
				num = (short)1798889154;
				short num3 = num;
				num = (short)1343217346;
				switch (num3 == num)
				{
				}
				num = (short)1186398208;
				if (num != 0)
				{
				}
				num = (short)661258241;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGSystemID_A19705.Max;
			}
			set
			{
				short num = (short)1395326976;
				short num2 = num;
				num = (short)1841005763;
				short num3 = num;
				num = (short)1790936259;
				switch (num3 == num)
				{
				}
				num = (short)248643585;
				if (num != 0)
				{
				}
				num = (short)2014445568;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAGSystemID_A19705.Max = value;
			}
		}

		// Token: 0x17000B55 RID: 2901
		// (get) Token: 0x0600168F RID: 5775 RVA: 0x00155C74 File Offset: 0x00153E74
		// (set) Token: 0x06001690 RID: 5776 RVA: 0x00155D28 File Offset: 0x00153F28
		internal int TrkPerAnnouncementGroupAGSystemID_A19705Step
		{
			get
			{
				short num = (short)509607936;
				short num2 = num;
				num = (short)381065433;
				short num3 = num;
				num = (short)2022545625;
				switch (num3 == num)
				{
				}
				num = (short)133300225;
				if (num != 0)
				{
				}
				num = (short)134807552;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGSystemID_A19705.StepSize;
			}
			set
			{
				short num = (short)741539840;
				short num2 = num;
				num = (short)638685383;
				short num3 = num;
				num = (short)1226346695;
				switch (num3 == num)
				{
				}
				num = (short)1744568321;
				if (num != 0)
				{
				}
				num = (short)622526464;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAGSystemID_A19705.StepSize = value;
			}
		}

		// Token: 0x17000B56 RID: 2902
		// (get) Token: 0x06001691 RID: 5777 RVA: 0x00155DDC File Offset: 0x00153FDC
		// (set) Token: 0x06001692 RID: 5778 RVA: 0x00155E94 File Offset: 0x00154094
		public bool TrkPerAnnouncementGroupAGSystemID_A19705_Applicable
		{
			get
			{
				short num = (short)1549991936;
				short num2 = num;
				num = (short)707861223;
				short num3 = num;
				num = (short)1584339687;
				switch (num3 == num)
				{
				}
				num = (short)436076545;
				if (num != 0)
				{
				}
				num = (short)1177878528;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGSystemID_A19705.Applicable;
			}
			set
			{
				short num = (short)92667904;
				short num2 = num;
				num = (short)1738107082;
				short num3 = num;
				num = (short)981362890;
				switch (num3 == num)
				{
				}
				num = (short)1879048192;
				if (num != 0)
				{
				}
				num = (short)1993408513;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAGSystemID_A19705.Applicable = value;
			}
		}

		// Token: 0x17000B57 RID: 2903
		// (get) Token: 0x06001693 RID: 5779 RVA: 0x00155F4C File Offset: 0x0015414C
		// (set) Token: 0x06001694 RID: 5780 RVA: 0x00156000 File Offset: 0x00154200
		public bool TrkPerAnnouncementGroupAGSystemID_A19705_Valid
		{
			get
			{
				short num = (short)862584832;
				short num2 = num;
				num = (short)752929622;
				short num3 = num;
				num = (short)184929110;
				switch (num3 == num)
				{
				}
				num = (short)945160193;
				if (num != 0)
				{
				}
				num = (short)309919744;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGSystemID_A19705.Valid;
			}
			set
			{
				short num = (short)96206848;
				short num2 = num;
				num = (short)1192034305;
				if (num != 0)
				{
				}
				num = (short)306003631;
				short num3 = num;
				num = (short)1522220719;
				switch (num3 == num)
				{
				}
				num = (short)116260864;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAGSystemID_A19705.Valid = value;
			}
		}

		// Token: 0x17000B58 RID: 2904
		// (get) Token: 0x06001695 RID: 5781 RVA: 0x001560B8 File Offset: 0x001542B8
		// (set) Token: 0x06001696 RID: 5782 RVA: 0x0015616C File Offset: 0x0015436C
		public bool TrkPerAnnouncementGroupAGSystemID_A19705_Visible
		{
			get
			{
				short num = (short)585760768;
				short num2 = num;
				num = (short)138030924;
				short num3 = num;
				num = (short)751578956;
				switch (num3 == num)
				{
				}
				num = (short)638582784;
				if (num != 0)
				{
				}
				num = (short)1283784705;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGSystemID_A19705.Visible;
			}
			set
			{
				short num = (short)1991704576;
				short num2 = num;
				num = (short)842878325;
				short num3 = num;
				num = (short)277892469;
				switch (num3 == num)
				{
				}
				num = (short)1613037569;
				if (num != 0)
				{
				}
				num = (short)1642528768;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAGSystemID_A19705.Visible = value;
			}
		}

		// Token: 0x17000B59 RID: 2905
		// (get) Token: 0x06001697 RID: 5783 RVA: 0x00156224 File Offset: 0x00154424
		// (set) Token: 0x06001698 RID: 5784 RVA: 0x001562DC File Offset: 0x001544DC
		public bool TrkPerAnnouncementGroupAGSystemID_A19705_Editable
		{
			get
			{
				short num = (short)1262616576;
				short num2 = num;
				num = (short)1369463221;
				short num3 = num;
				num = (short)1071667637;
				switch (num3 == num)
				{
				}
				num = (short)389480449;
				if (num != 0)
				{
				}
				num = (short)849149952;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGSystemID_A19705.Editable;
			}
			set
			{
				short num = (short)1229651968;
				short num2 = num;
				num = (short)2118086065;
				short num3 = num;
				num = (short)2094755249;
				switch (num3 == num)
				{
				}
				num = (short)236453889;
				if (num != 0)
				{
				}
				num = (short)1231028224;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAGSystemID_A19705.Editable = value;
			}
		}

		// Token: 0x17000B5A RID: 2906
		// (get) Token: 0x06001699 RID: 5785 RVA: 0x00156390 File Offset: 0x00154590
		internal string TrkPerAnnouncementGroupAGSystemID_A19705_UILabel
		{
			get
			{
				short num = (short)21299200;
				short num2 = num;
				num = (short)384790611;
				short num3 = num;
				num = (short)592212051;
				switch (num3 == num)
				{
				}
				num = (short)8323073;
				if (num != 0)
				{
				}
				num = (short)1433272320;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGSystemID_A19705.UIName;
			}
		}

		// Token: 0x17000B5B RID: 2907
		// (get) Token: 0x0600169A RID: 5786 RVA: 0x00156448 File Offset: 0x00154648
		// (set) Token: 0x0600169B RID: 5787 RVA: 0x001564FC File Offset: 0x001546FC
		internal bool TrkPerAnnouncementGroupAGSystemID_A19705_HiddenStatic
		{
			get
			{
				short num = (short)1532100608;
				short num2 = num;
				num = (short)914292737;
				if (num != 0)
				{
				}
				num = (short)1718355825;
				short num3 = num;
				num = (short)132188017;
				switch (num3 == num)
				{
				}
				num = (short)228392960;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGSystemID_A19705.HiddenStatic;
			}
			set
			{
				short num = (short)1738735616;
				short num2 = num;
				num = (short)796869347;
				short num3 = num;
				num = (short)97927907;
				switch (num3 == num)
				{
				}
				num = (short)679870464;
				if (num != 0)
				{
				}
				num = (short)1630142465;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAGSystemID_A19705.HiddenStatic = value;
			}
		}

		// Token: 0x17000B5C RID: 2908
		// (get) Token: 0x0600169C RID: 5788 RVA: 0x001565B4 File Offset: 0x001547B4
		// (set) Token: 0x0600169D RID: 5789 RVA: 0x00156668 File Offset: 0x00154868
		internal bool TrkPerAnnouncementGroupAGSystemID_A19705_HiddenDynamic
		{
			get
			{
				short num = (short)960692224;
				short num2 = num;
				num = (short)604710234;
				short num3 = num;
				num = (short)1896883546;
				switch (num3 == num)
				{
				}
				num = (short)1293680641;
				if (num != 0)
				{
				}
				num = (short)853278720;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGSystemID_A19705.HiddenDynamic;
			}
			set
			{
				short num = (short)556269568;
				short num2 = num;
				num = (short)400585244;
				short num3 = num;
				num = (short)1968009756;
				switch (num3 == num)
				{
				}
				num = (short)71499777;
				if (num != 0)
				{
				}
				num = (short)27328512;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAGSystemID_A19705.HiddenDynamic = value;
			}
		}

		// Token: 0x17000B5D RID: 2909
		// (get) Token: 0x0600169E RID: 5790 RVA: 0x0015671C File Offset: 0x0015491C
		public bool TrkPerAnnouncementGroupAGSystemID_A19705_HasDiffs
		{
			get
			{
				short num = (short)1055260672;
				short num2 = num;
				num = (short)781085692;
				short num3 = num;
				num = (short)2084203516;
				switch (num3 == num)
				{
				}
				num = (short)1891827713;
				if (num != 0)
				{
				}
				num = (short)566034432;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGSystemID_A19705._HasDiffs;
			}
		}

		// Token: 0x17000B5E RID: 2910
		// (get) Token: 0x0600169F RID: 5791 RVA: 0x001567D0 File Offset: 0x001549D0
		// (set) Token: 0x060016A0 RID: 5792 RVA: 0x00156888 File Offset: 0x00154A88
		public int TrkPerAnnouncementGroupAGWACNID_A19706Value
		{
			get
			{
				short num = (short)872415232;
				short num2 = num;
				num = (short)1909942;
				short num3 = num;
				num = (short)2012751030;
				switch (num3 == num)
				{
				}
				num = (short)1721958401;
				if (num != 0)
				{
				}
				num = (short)867827712;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGWACNID_A19706.Value;
			}
			set
			{
				short num = (short)1030029312;
				short num2 = num;
				num = (short)802389670;
				short num3 = num;
				num = (short)894795430;
				switch (num3 == num)
				{
				}
				num = (short)673251329;
				if (num != 0)
				{
				}
				num = (short)1474560000;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAGWACNID_A19706.Value = value;
			}
		}

		// Token: 0x17000B5F RID: 2911
		// (get) Token: 0x060016A1 RID: 5793 RVA: 0x0015693C File Offset: 0x00154B3C
		public global::AcpBusinessLayer.AcpSimpleRangeField TrkPerAnnouncementGroupAGWACNID_A19706
		{
			get
			{
				short num = (short)1115029504;
				short num2 = num;
				num = (short)3670017;
				if (num != 0)
				{
				}
				num = (short)497738033;
				short num3 = num;
				num = (short)946659633;
				switch (num3 == num)
				{
				}
				num = (short)1827340288;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGWACNID_A19706;
			}
		}

		// Token: 0x17000B60 RID: 2912
		// (get) Token: 0x060016A2 RID: 5794 RVA: 0x001569E8 File Offset: 0x00154BE8
		// (set) Token: 0x060016A3 RID: 5795 RVA: 0x00156AA0 File Offset: 0x00154CA0
		public string TrkPerAnnouncementGroupAGWACNID_A19706_UIValue
		{
			get
			{
				short num = (short)742129664;
				short num2 = num;
				num = (short)469071497;
				short num3 = num;
				num = (short)1055684233;
				switch (num3 == num)
				{
				}
				num = (short)1157890048;
				if (num != 0)
				{
				}
				num = (short)278003713;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGWACNID_A19706.UIValue;
			}
			set
			{
				short num = (short)1481113600;
				short num2 = num;
				num = (short)580845569;
				if (num != 0)
				{
				}
				num = (short)1061531290;
				short num3 = num;
				num = (short)2094902938;
				switch (num3 == num)
				{
				}
				num = (short)2051145728;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAGWACNID_A19706.UIValue = value;
			}
		}

		// Token: 0x17000B61 RID: 2913
		// (get) Token: 0x060016A4 RID: 5796 RVA: 0x00156B58 File Offset: 0x00154D58
		// (set) Token: 0x060016A5 RID: 5797 RVA: 0x00156C0C File Offset: 0x00154E0C
		public string TrkPerAnnouncementGroupAGWACNID_A19706_HexUIValue
		{
			get
			{
				short num = (short)1682374656;
				short num2 = num;
				num = (short)1795885921;
				short num3 = num;
				num = (short)684264289;
				switch (num3 == num)
				{
				}
				num = (short)1482686465;
				if (num != 0)
				{
				}
				num = (short)193069056;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGWACNID_A19706.HexUIValue;
			}
			set
			{
				short num = (short)1970995200;
				short num2 = num;
				num = (short)1649776658;
				short num3 = num;
				num = (short)636393490;
				switch (num3 == num)
				{
				}
				num = (short)1423769601;
				if (num != 0)
				{
				}
				num = (short)1598160896;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAGWACNID_A19706.HexUIValue = value;
			}
		}

		// Token: 0x17000B62 RID: 2914
		// (get) Token: 0x060016A6 RID: 5798 RVA: 0x00156CC0 File Offset: 0x00154EC0
		// (set) Token: 0x060016A7 RID: 5799 RVA: 0x00156D78 File Offset: 0x00154F78
		internal int TrkPerAnnouncementGroupAGWACNID_A19706Min
		{
			get
			{
				short num = (short)1085145088;
				short num2 = num;
				num = (short)1329626791;
				short num3 = num;
				num = (short)457801383;
				switch (num3 == num)
				{
				}
				num = (short)1889468417;
				if (num != 0)
				{
				}
				num = (short)1063583744;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGWACNID_A19706.Min;
			}
			set
			{
				short num = (short)591331328;
				short num2 = num;
				num = (short)1341849752;
				short num3 = num;
				num = (short)1672151192;
				switch (num3 == num)
				{
				}
				num = (short)1856045057;
				if (num != 0)
				{
				}
				num = (short)585826304;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAGWACNID_A19706.Min = value;
			}
		}

		// Token: 0x17000B63 RID: 2915
		// (get) Token: 0x060016A8 RID: 5800 RVA: 0x00156E2C File Offset: 0x0015502C
		// (set) Token: 0x060016A9 RID: 5801 RVA: 0x00156EDC File Offset: 0x001550DC
		internal int TrkPerAnnouncementGroupAGWACNID_A19706Max
		{
			get
			{
				short num = (short)1502674944;
				short num2 = num;
				num = (short)1545113456;
				short num3 = num;
				num = (short)668503920;
				switch (num3 == num)
				{
				}
				num = (short)1377107969;
				if (num != 0)
				{
				}
				num = (short)2096955392;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGWACNID_A19706.Max;
			}
			set
			{
				short num = (short)1296433152;
				short num2 = num;
				num = (short)1272158667;
				short num3 = num;
				num = (short)635673035;
				switch (num3 == num)
				{
				}
				num = (short)1481310209;
				if (num != 0)
				{
				}
				num = (short)101515264;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAGWACNID_A19706.Max = value;
			}
		}

		// Token: 0x17000B64 RID: 2916
		// (get) Token: 0x060016AA RID: 5802 RVA: 0x00156F90 File Offset: 0x00155190
		// (set) Token: 0x060016AB RID: 5803 RVA: 0x00157044 File Offset: 0x00155244
		internal int TrkPerAnnouncementGroupAGWACNID_A19706Step
		{
			get
			{
				short num = (short)92733440;
				short num2 = num;
				num = (short)1912040763;
				short num3 = num;
				num = (short)527002939;
				switch (num3 == num)
				{
				}
				num = (short)1785921536;
				if (num != 0)
				{
				}
				num = (short)168689665;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGWACNID_A19706.StepSize;
			}
			set
			{
				short num = (short)1783627776;
				short num2 = num;
				num = (short)922248149;
				short num3 = num;
				num = (short)1098343381;
				switch (num3 == num)
				{
				}
				num = (short)2013069312;
				if (num != 0)
				{
				}
				num = (short)200278017;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAGWACNID_A19706.StepSize = value;
			}
		}

		// Token: 0x17000B65 RID: 2917
		// (get) Token: 0x060016AC RID: 5804 RVA: 0x001570F8 File Offset: 0x001552F8
		// (set) Token: 0x060016AD RID: 5805 RVA: 0x001571AC File Offset: 0x001553AC
		public bool TrkPerAnnouncementGroupAGWACNID_A19706_Applicable
		{
			get
			{
				short num = (short)340525056;
				short num2 = num;
				num = (short)1398140430;
				short num3 = num;
				num = (short)1836969486;
				switch (num3 == num)
				{
				}
				num = (short)865861633;
				if (num != 0)
				{
				}
				num = (short)1973157888;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGWACNID_A19706.Applicable;
			}
			set
			{
				short num = (short)336527360;
				short num2 = num;
				num = (short)1572307203;
				short num3 = num;
				num = (short)16417027;
				switch (num3 == num)
				{
				}
				num = (short)1852833792;
				if (num != 0)
				{
				}
				num = (short)244973569;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAGWACNID_A19706.Applicable = value;
			}
		}

		// Token: 0x17000B66 RID: 2918
		// (get) Token: 0x060016AE RID: 5806 RVA: 0x00157260 File Offset: 0x00155460
		// (set) Token: 0x060016AF RID: 5807 RVA: 0x00157314 File Offset: 0x00155514
		public bool TrkPerAnnouncementGroupAGWACNID_A19706_Valid
		{
			get
			{
				short num = (short)999161856;
				short num2 = num;
				num = (short)237060900;
				short num3 = num;
				num = (short)1545290532;
				switch (num3 == num)
				{
				}
				num = (short)346292225;
				if (num != 0)
				{
				}
				num = (short)1432616960;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGWACNID_A19706.Valid;
			}
			set
			{
				short num = (short)605356032;
				short num2 = num;
				num = (short)274595841;
				if (num != 0)
				{
				}
				num = (short)964627636;
				short num3 = num;
				num = (short)1946619060;
				switch (num3 == num)
				{
				}
				num = (short)260440064;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAGWACNID_A19706.Valid = value;
			}
		}

		// Token: 0x17000B67 RID: 2919
		// (get) Token: 0x060016B0 RID: 5808 RVA: 0x001573CC File Offset: 0x001555CC
		// (set) Token: 0x060016B1 RID: 5809 RVA: 0x00157480 File Offset: 0x00155680
		public bool TrkPerAnnouncementGroupAGWACNID_A19706_Visible
		{
			get
			{
				short num = (short)2106785792;
				short num2 = num;
				num = (short)1227340744;
				short num3 = num;
				num = (short)328514504;
				switch (num3 == num)
				{
				}
				num = (short)1751384064;
				if (num != 0)
				{
				}
				num = (short)309329921;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGWACNID_A19706.Visible;
			}
			set
			{
				short num = (short)773062656;
				short num2 = num;
				num = (short)780973733;
				short num3 = num;
				num = (short)1014806181;
				switch (num3 == num)
				{
				}
				num = (short)1708064768;
				if (num != 0)
				{
				}
				num = (short)265945089;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAGWACNID_A19706.Visible = value;
			}
		}

		// Token: 0x17000B68 RID: 2920
		// (get) Token: 0x060016B2 RID: 5810 RVA: 0x00157538 File Offset: 0x00155738
		// (set) Token: 0x060016B3 RID: 5811 RVA: 0x001575EC File Offset: 0x001557EC
		public bool TrkPerAnnouncementGroupAGWACNID_A19706_Editable
		{
			get
			{
				short num = (short)2026110976;
				short num2 = num;
				num = (short)882507329;
				short num3 = num;
				num = (short)1204354625;
				switch (num3 == num)
				{
				}
				num = (short)1382678529;
				if (num != 0)
				{
				}
				num = (short)1068498944;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGWACNID_A19706.Editable;
			}
			set
			{
				short num = (short)1186463744;
				short num2 = num;
				num = (short)394970762;
				short num3 = num;
				num = (short)571328138;
				switch (num3 == num)
				{
				}
				num = (short)2001993729;
				if (num != 0)
				{
				}
				num = (short)33947648;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAGWACNID_A19706.Editable = value;
			}
		}

		// Token: 0x17000B69 RID: 2921
		// (get) Token: 0x060016B4 RID: 5812 RVA: 0x001576A4 File Offset: 0x001558A4
		internal string TrkPerAnnouncementGroupAGWACNID_A19706_UILabel
		{
			get
			{
				short num = (short)873201664;
				short num2 = num;
				num = (short)2144867541;
				short num3 = num;
				num = (short)112596181;
				switch (num3 == num)
				{
				}
				num = (short)1285029889;
				if (num != 0)
				{
				}
				num = (short)793116672;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGWACNID_A19706.UIName;
			}
		}

		// Token: 0x17000B6A RID: 2922
		// (get) Token: 0x060016B5 RID: 5813 RVA: 0x00157758 File Offset: 0x00155958
		// (set) Token: 0x060016B6 RID: 5814 RVA: 0x0015780C File Offset: 0x00155A0C
		internal bool TrkPerAnnouncementGroupAGWACNID_A19706_HiddenStatic
		{
			get
			{
				short num = (short)1581842432;
				short num2 = num;
				num = (short)1530312092;
				short num3 = num;
				num = (short)39105948;
				switch (num3 == num)
				{
				}
				num = (short)526254080;
				if (num != 0)
				{
				}
				num = (short)1220345857;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGWACNID_A19706.HiddenStatic;
			}
			set
			{
				short num = (short)282263552;
				short num2 = num;
				num = (short)1322040785;
				short num3 = num;
				num = (short)745127377;
				switch (num3 == num)
				{
				}
				num = (short)2111307777;
				if (num != 0)
				{
				}
				num = (short)541261824;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAGWACNID_A19706.HiddenStatic = value;
			}
		}

		// Token: 0x17000B6B RID: 2923
		// (get) Token: 0x060016B7 RID: 5815 RVA: 0x001578C0 File Offset: 0x00155AC0
		// (set) Token: 0x060016B8 RID: 5816 RVA: 0x00157974 File Offset: 0x00155B74
		internal bool TrkPerAnnouncementGroupAGWACNID_A19706_HiddenDynamic
		{
			get
			{
				short num = (short)1357444696;
				short num2 = num;
				num = (short)1058600536;
				switch (num2 == num)
				{
				}
				num = (short)743047169;
				if (num != 0)
				{
				}
				num = (short)20643840;
				short num3 = num;
				num = (short)115605504;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGWACNID_A19706.HiddenDynamic;
			}
			set
			{
				short num = (short)899648061;
				short num2 = num;
				num = (short)864520765;
				switch (num2 == num)
				{
				}
				num = (short)1140129793;
				if (num != 0)
				{
				}
				num = (short)1011417088;
				short num3 = num;
				num = (short)1333133312;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAGWACNID_A19706.HiddenDynamic = value;
			}
		}

		// Token: 0x17000B6C RID: 2924
		// (get) Token: 0x060016B9 RID: 5817 RVA: 0x00157A28 File Offset: 0x00155C28
		public bool TrkPerAnnouncementGroupAGWACNID_A19706_HasDiffs
		{
			get
			{
				short num = (short)699486146;
				short num2 = num;
				num = (short)1019039682;
				switch (num2 == num)
				{
				}
				num = (short)1242431488;
				if (num != 0)
				{
				}
				num = (short)781582336;
				short num3 = num;
				num = (short)814022657;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGWACNID_A19706._HasDiffs;
			}
		}

		// Token: 0x17000B6D RID: 2925
		// (get) Token: 0x060016BA RID: 5818 RVA: 0x00157AE0 File Offset: 0x00155CE0
		// (set) Token: 0x060016BB RID: 5819 RVA: 0x00157B9C File Offset: 0x00155D9C
		public bool TrkPerAnnouncementGroupAGSecondaryFailsoft_A19990Value
		{
			get
			{
				short num = (short)217693168;
				short num2 = num;
				num = (short)250002416;
				switch (num2 == num)
				{
				}
				num = (short)47120384;
				if (num != 0)
				{
				}
				num = (short)2046099456;
				short num3 = num;
				num = (short)423821313;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGSecondaryFailsoft_A19990.Value;
			}
			set
			{
				short num = (short)878901876;
				short num2 = num;
				num = (short)2134833780;
				switch (num2 == num)
				{
				}
				num = (short)498139137;
				if (num != 0)
				{
				}
				num = (short)80084992;
				short num3 = num;
				num = (short)1080164352;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAGSecondaryFailsoft_A19990.Value = value;
			}
		}

		// Token: 0x17000B6E RID: 2926
		// (get) Token: 0x060016BC RID: 5820 RVA: 0x00157C54 File Offset: 0x00155E54
		public global::AcpBusinessLayer.AcpField<bool> TrkPerAnnouncementGroupAGSecondaryFailsoft_A19990
		{
			get
			{
				short num = (short)1625163713;
				short num2 = num;
				num = (short)6293441;
				switch (num2 == num)
				{
				}
				num = (short)1627652097;
				if (num != 0)
				{
				}
				num = (short)556859392;
				short num3 = num;
				num = (short)18153472;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGSecondaryFailsoft_A19990;
			}
		}

		// Token: 0x17000B6F RID: 2927
		// (get) Token: 0x060016BD RID: 5821 RVA: 0x00157D04 File Offset: 0x00155F04
		// (set) Token: 0x060016BE RID: 5822 RVA: 0x00157DB8 File Offset: 0x00155FB8
		public bool TrkPerAnnouncementGroupAGSecondaryFailsoft_A19990_UIValue
		{
			get
			{
				short num = (short)1202126864;
				short num2 = num;
				num = (short)1332871184;
				switch (num2 == num)
				{
				}
				num = (short)1653407745;
				if (num != 0)
				{
				}
				num = (short)789905408;
				short num3 = num;
				num = (short)714080256;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGSecondaryFailsoft_A19990.Value;
			}
			set
			{
				short num = (short)1948737326;
				short num2 = num;
				num = (short)138108718;
				switch (num2 == num)
				{
				}
				num = (short)1922957313;
				if (num != 0)
				{
				}
				num = (short)1320222720;
				short num3 = num;
				num = (short)1676279808;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAGSecondaryFailsoft_A19990.Value = value;
			}
		}

		// Token: 0x17000B70 RID: 2928
		// (get) Token: 0x060016BF RID: 5823 RVA: 0x00157E6C File Offset: 0x0015606C
		// (set) Token: 0x060016C0 RID: 5824 RVA: 0x00157F20 File Offset: 0x00156120
		public bool TrkPerAnnouncementGroupAGSecondaryFailsoft_A19990_Applicable
		{
			get
			{
				short num = (short)895046398;
				short num2 = num;
				num = (short)1646744318;
				switch (num2 == num)
				{
				}
				num = (short)432668672;
				if (num != 0)
				{
				}
				num = (short)440074240;
				short num3 = num;
				num = (short)285671425;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGSecondaryFailsoft_A19990.Applicable;
			}
			set
			{
				short num = (short)2087111210;
				short num2 = num;
				num = (short)594201130;
				switch (num2 == num)
				{
				}
				num = (short)132579329;
				if (num != 0)
				{
				}
				num = (short)2087714816;
				short num3 = num;
				num = (short)124715008;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAGSecondaryFailsoft_A19990.Applicable = value;
			}
		}

		// Token: 0x17000B71 RID: 2929
		// (get) Token: 0x060016C1 RID: 5825 RVA: 0x00157FD8 File Offset: 0x001561D8
		// (set) Token: 0x060016C2 RID: 5826 RVA: 0x0015808C File Offset: 0x0015628C
		public bool TrkPerAnnouncementGroupAGSecondaryFailsoft_A19990_Valid
		{
			get
			{
				short num = (short)277688643;
				short num2 = num;
				num = (short)470167875;
				switch (num2 == num)
				{
				}
				num = (short)1960968193;
				if (num != 0)
				{
				}
				num = (short)1130823680;
				short num3 = num;
				num = (short)1801388032;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGSecondaryFailsoft_A19990.Valid;
			}
			set
			{
				short num = (short)868128130;
				short num2 = num;
				num = (short)2067961218;
				switch (num2 == num)
				{
				}
				num = (short)761266176;
				if (num != 0)
				{
				}
				num = (short)71237632;
				short num3 = num;
				num = (short)1970601985;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAGSecondaryFailsoft_A19990.Valid = value;
			}
		}

		// Token: 0x17000B72 RID: 2930
		// (get) Token: 0x060016C3 RID: 5827 RVA: 0x00158148 File Offset: 0x00156348
		// (set) Token: 0x060016C4 RID: 5828 RVA: 0x00158200 File Offset: 0x00156400
		public bool TrkPerAnnouncementGroupAGSecondaryFailsoft_A19990_Visible
		{
			get
			{
				short num = (short)1844606028;
				short num2 = num;
				num = (short)872838220;
				switch (num2 == num)
				{
				}
				num = (short)1486290945;
				if (num != 0)
				{
				}
				num = (short)1748303872;
				short num3 = num;
				num = (short)50724864;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGSecondaryFailsoft_A19990.Visible;
			}
			set
			{
				short num = (short)1670250497;
				if (num != 0)
				{
				}
				num = (short)1837918265;
				short num2 = num;
				num = (short)364996665;
				switch (num2 == num)
				{
				}
				num = (short)853737472;
				short num3 = num;
				num = (short)1311440896;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAGSecondaryFailsoft_A19990.Visible = value;
			}
		}

		// Token: 0x17000B73 RID: 2931
		// (get) Token: 0x060016C5 RID: 5829 RVA: 0x001582B8 File Offset: 0x001564B8
		// (set) Token: 0x060016C6 RID: 5830 RVA: 0x0015836C File Offset: 0x0015656C
		public bool TrkPerAnnouncementGroupAGSecondaryFailsoft_A19990_Editable
		{
			get
			{
				short num = (short)746313257;
				short num2 = num;
				num = (short)622450217;
				switch (num2 == num)
				{
				}
				num = (short)2088632321;
				if (num != 0)
				{
				}
				num = (short)1147863040;
				short num3 = num;
				num = (short)1433862144;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGSecondaryFailsoft_A19990.Editable;
			}
			set
			{
				short num = (short)1473482104;
				short num2 = num;
				num = (short)852462968;
				switch (num2 == num)
				{
				}
				num = (short)472973313;
				if (num != 0)
				{
				}
				num = (short)1089929216;
				short num3 = num;
				num = (short)1577713664;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAGSecondaryFailsoft_A19990.Editable = value;
			}
		}

		// Token: 0x17000B74 RID: 2932
		// (get) Token: 0x060016C7 RID: 5831 RVA: 0x00158424 File Offset: 0x00156624
		internal string TrkPerAnnouncementGroupAGSecondaryFailsoft_A19990_UILabel
		{
			get
			{
				short num = (short)242153652;
				short num2 = num;
				num = (short)2089416884;
				switch (num2 == num)
				{
				}
				num = (short)1800273921;
				if (num != 0)
				{
				}
				num = (short)540803072;
				short num3 = num;
				num = (short)340262912;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGSecondaryFailsoft_A19990.UIName;
			}
		}

		// Token: 0x17000B75 RID: 2933
		// (get) Token: 0x060016C8 RID: 5832 RVA: 0x001584D8 File Offset: 0x001566D8
		// (set) Token: 0x060016C9 RID: 5833 RVA: 0x00158590 File Offset: 0x00156790
		internal bool TrkPerAnnouncementGroupAGSecondaryFailsoft_A19990_HiddenStatic
		{
			get
			{
				short num = (short)754555967;
				short num2 = num;
				num = (short)1893768255;
				switch (num2 == num)
				{
				}
				num = (short)1745551360;
				if (num != 0)
				{
				}
				num = (short)1651179520;
				short num3 = num;
				num = (short)1316945921;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGSecondaryFailsoft_A19990.HiddenStatic;
			}
			set
			{
				short num = (short)1745250353;
				short num2 = num;
				num = (short)231696433;
				switch (num2 == num)
				{
				}
				num = (short)245628929;
				if (num != 0)
				{
				}
				num = (short)530317312;
				short num3 = num;
				num = (short)1010565120;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAGSecondaryFailsoft_A19990.HiddenStatic = value;
			}
		}

		// Token: 0x17000B76 RID: 2934
		// (get) Token: 0x060016CA RID: 5834 RVA: 0x00158648 File Offset: 0x00156848
		// (set) Token: 0x060016CB RID: 5835 RVA: 0x001586FC File Offset: 0x001568FC
		internal bool TrkPerAnnouncementGroupAGSecondaryFailsoft_A19990_HiddenDynamic
		{
			get
			{
				short num = (short)293404673;
				if (num != 0)
				{
				}
				num = (short)1096039397;
				short num2 = num;
				num = (short)37632997;
				switch (num2 == num)
				{
				}
				num = (short)1787953152;
				short num3 = num;
				num = (short)621150208;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGSecondaryFailsoft_A19990.HiddenDynamic;
			}
			set
			{
				short num = (short)565945571;
				short num2 = num;
				num = (short)1890034915;
				switch (num2 == num)
				{
				}
				num = (short)88670209;
				if (num != 0)
				{
				}
				num = (short)784400384;
				short num3 = num;
				num = (short)905707520;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAGSecondaryFailsoft_A19990.HiddenDynamic = value;
			}
		}

		// Token: 0x17000B77 RID: 2935
		// (get) Token: 0x060016CC RID: 5836 RVA: 0x001587B4 File Offset: 0x001569B4
		public bool TrkPerAnnouncementGroupAGSecondaryFailsoft_A19990_HasDiffs
		{
			get
			{
				short num = (short)264552977;
				short num2 = num;
				num = (short)497336849;
				switch (num2 == num)
				{
				}
				num = (short)817823745;
				if (num != 0)
				{
				}
				num = (short)1776680960;
				short num3 = num;
				num = (short)1162477568;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGSecondaryFailsoft_A19990._HasDiffs;
			}
		}

		// Token: 0x17000B78 RID: 2936
		// (get) Token: 0x060016CD RID: 5837 RVA: 0x00158868 File Offset: 0x00156A68
		// (set) Token: 0x060016CE RID: 5838 RVA: 0x00158920 File Offset: 0x00156B20
		public int TrkPerAnnouncementGroupAGSecondaryFSRxFrequencyMHz_A8895Value
		{
			get
			{
				short num = (short)1646848415;
				short num2 = num;
				num = (short)520808863;
				switch (num2 == num)
				{
				}
				num = (short)829751297;
				if (num != 0)
				{
				}
				num = (short)609943552;
				short num3 = num;
				num = (short)1067253760;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGSecondaryFSRxFrequencyMHz_A8895.Value;
			}
			set
			{
				short num = (short)850132993;
				if (num != 0)
				{
				}
				num = (short)1185246119;
				short num2 = num;
				num = (short)918121383;
				switch (num2 == num)
				{
				}
				num = (short)1939603456;
				short num3 = num;
				num = (short)869400576;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAGSecondaryFSRxFrequencyMHz_A8895.Value = value;
			}
		}

		// Token: 0x17000B79 RID: 2937
		// (get) Token: 0x060016CF RID: 5839 RVA: 0x001589D8 File Offset: 0x00156BD8
		// (set) Token: 0x060016D0 RID: 5840 RVA: 0x00158A8C File Offset: 0x00156C8C
		public string TrkPerAnnouncementGroupAGSecondaryFSRxFrequencyMHz_A8895_UIValue
		{
			get
			{
				short num = (short)758049965;
				short num2 = num;
				num = (short)1214704813;
				switch (num2 == num)
				{
				}
				num = (short)1948385281;
				if (num != 0)
				{
				}
				num = (short)588447744;
				short num3 = num;
				num = (short)614793216;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGSecondaryFSRxFrequencyMHz_A8895.UIValue;
			}
			set
			{
				short num = (short)500116782;
				short num2 = num;
				num = (short)2117152046;
				switch (num2 == num)
				{
				}
				num = (short)952565761;
				if (num != 0)
				{
				}
				num = (short)1401552896;
				short num3 = num;
				num = (short)1330184192;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAGSecondaryFSRxFrequencyMHz_A8895.UIValue = value;
			}
		}

		// Token: 0x17000B7A RID: 2938
		// (get) Token: 0x060016D1 RID: 5841 RVA: 0x00158B40 File Offset: 0x00156D40
		public global::AcpBusinessLayer.AcpFrequencyField TrkPerAnnouncementGroupAGSecondaryFSRxFrequencyMHz_A8895
		{
			get
			{
				short num = (short)700383233;
				if (num != 0)
				{
				}
				num = (short)1071839932;
				short num2 = num;
				num = (short)637270716;
				switch (num2 == num)
				{
				}
				num = (short)175702016;
				short num3 = num;
				num = (short)1317601280;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGSecondaryFSRxFrequencyMHz_A8895;
			}
		}

		// Token: 0x17000B7B RID: 2939
		// (get) Token: 0x060016D2 RID: 5842 RVA: 0x00158BEC File Offset: 0x00156DEC
		// (set) Token: 0x060016D3 RID: 5843 RVA: 0x00158CA0 File Offset: 0x00156EA0
		internal int TrkPerAnnouncementGroupAGSecondaryFSRxFrequencyMHz_A8895Min
		{
			get
			{
				short num = (short)1889927169;
				if (num != 0)
				{
				}
				num = (short)580486939;
				short num2 = num;
				num = (short)184125211;
				switch (num2 == num)
				{
				}
				num = (short)645398528;
				short num3 = num;
				num = (short)704577536;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGSecondaryFSRxFrequencyMHz_A8895.Min;
			}
			set
			{
				short num = (short)1326608052;
				short num2 = num;
				num = (short)1892511412;
				switch (num2 == num)
				{
				}
				num = (short)516554752;
				if (num != 0)
				{
				}
				num = (short)1507000320;
				short num3 = num;
				num = (short)1086849025;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAGSecondaryFSRxFrequencyMHz_A8895.Min = value;
			}
		}

		// Token: 0x17000B7C RID: 2940
		// (get) Token: 0x060016D4 RID: 5844 RVA: 0x00158D58 File Offset: 0x00156F58
		// (set) Token: 0x060016D5 RID: 5845 RVA: 0x00158E0C File Offset: 0x0015700C
		internal int TrkPerAnnouncementGroupAGSecondaryFSRxFrequencyMHz_A8895Max
		{
			get
			{
				short num = (short)398917633;
				if (num != 0)
				{
				}
				num = (short)1634431963;
				short num2 = num;
				num = (short)613184475;
				switch (num2 == num)
				{
				}
				num = (short)1228210176;
				short num3 = num;
				num = (short)804061184;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGSecondaryFSRxFrequencyMHz_A8895.Max;
			}
			set
			{
				short num = (short)337225074;
				short num2 = num;
				num = (short)588686706;
				switch (num2 == num)
				{
				}
				num = (short)1288896512;
				if (num != 0)
				{
				}
				num = (short)1977090048;
				short num3 = num;
				num = (short)1906507777;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAGSecondaryFSRxFrequencyMHz_A8895.Max = value;
			}
		}

		// Token: 0x17000B7D RID: 2941
		// (get) Token: 0x060016D6 RID: 5846 RVA: 0x00158EC0 File Offset: 0x001570C0
		// (set) Token: 0x060016D7 RID: 5847 RVA: 0x00158F74 File Offset: 0x00157174
		internal int TrkPerAnnouncementGroupAGSecondaryFSRxFrequencyMHz_A8895Step
		{
			get
			{
				short num = (short)201854945;
				short num2 = num;
				num = (short)1797328865;
				switch (num2 == num)
				{
				}
				num = (short)549257217;
				if (num != 0)
				{
				}
				num = (short)1222115328;
				short num3 = num;
				num = (short)614531072;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGSecondaryFSRxFrequencyMHz_A8895.StepSize;
			}
			set
			{
				short num = (short)1318897929;
				short num2 = num;
				num = (short)164415753;
				switch (num2 == num)
				{
				}
				num = (short)871301121;
				if (num != 0)
				{
				}
				num = (short)1576992768;
				short num3 = num;
				num = (short)1778057216;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAGSecondaryFSRxFrequencyMHz_A8895.StepSize = value;
			}
		}

		// Token: 0x17000B7E RID: 2942
		// (get) Token: 0x060016D8 RID: 5848 RVA: 0x00159028 File Offset: 0x00157228
		// (set) Token: 0x060016D9 RID: 5849 RVA: 0x001590DC File Offset: 0x001572DC
		public bool TrkPerAnnouncementGroupAGSecondaryFSRxFrequencyMHz_A8895_Applicable
		{
			get
			{
				short num = (short)978199391;
				short num2 = num;
				num = (short)1991189343;
				switch (num2 == num)
				{
				}
				num = (short)544735232;
				if (num != 0)
				{
				}
				num = (short)354222080;
				short num3 = num;
				num = (short)192217089;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGSecondaryFSRxFrequencyMHz_A8895.Applicable;
			}
			set
			{
				short num = (short)331841585;
				short num2 = num;
				num = (short)1079476273;
				switch (num2 == num)
				{
				}
				num = (short)759955457;
				if (num != 0)
				{
				}
				num = (short)1127809024;
				short num3 = num;
				num = (short)293076992;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAGSecondaryFSRxFrequencyMHz_A8895.Applicable = value;
			}
		}

		// Token: 0x17000B7F RID: 2943
		// (get) Token: 0x060016DA RID: 5850 RVA: 0x00159190 File Offset: 0x00157390
		// (set) Token: 0x060016DB RID: 5851 RVA: 0x00159244 File Offset: 0x00157444
		public bool TrkPerAnnouncementGroupAGSecondaryFSRxFrequencyMHz_A8895_Valid
		{
			get
			{
				short num = (short)1315382364;
				short num2 = num;
				num = (short)989799516;
				switch (num2 == num)
				{
				}
				num = (short)1571749889;
				if (num != 0)
				{
				}
				num = (short)1425801216;
				short num3 = num;
				num = (short)782434304;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGSecondaryFSRxFrequencyMHz_A8895.Valid;
			}
			set
			{
				short num = (short)1482144670;
				short num2 = num;
				num = (short)706591646;
				switch (num2 == num)
				{
				}
				num = (short)498925568;
				if (num != 0)
				{
				}
				num = (short)512360448;
				short num3 = num;
				num = (short)1022427137;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAGSecondaryFSRxFrequencyMHz_A8895.Valid = value;
			}
		}

		// Token: 0x17000B80 RID: 2944
		// (get) Token: 0x060016DC RID: 5852 RVA: 0x001592F8 File Offset: 0x001574F8
		// (set) Token: 0x060016DD RID: 5853 RVA: 0x001593AC File Offset: 0x001575AC
		public bool TrkPerAnnouncementGroupAGSecondaryFSRxFrequencyMHz_A8895_Visible
		{
			get
			{
				short num = (short)2137447457;
				short num2 = num;
				num = (short)1234623521;
				switch (num2 == num)
				{
				}
				num = (short)1125384192;
				if (num != 0)
				{
				}
				num = (short)950665216;
				short num3 = num;
				num = (short)1287389185;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGSecondaryFSRxFrequencyMHz_A8895.Visible;
			}
			set
			{
				short num = (short)696878130;
				short num2 = num;
				num = (short)184517682;
				switch (num2 == num)
				{
				}
				num = (short)2100166657;
				if (num != 0)
				{
				}
				num = (short)838205440;
				short num3 = num;
				num = (short)895811584;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAGSecondaryFSRxFrequencyMHz_A8895.Visible = value;
			}
		}

		// Token: 0x17000B81 RID: 2945
		// (get) Token: 0x060016DE RID: 5854 RVA: 0x00159464 File Offset: 0x00157664
		// (set) Token: 0x060016DF RID: 5855 RVA: 0x0015951C File Offset: 0x0015771C
		public bool TrkPerAnnouncementGroupAGSecondaryFSRxFrequencyMHz_A8895_Editable
		{
			get
			{
				short num = (short)801437911;
				short num2 = num;
				num = (short)1161165015;
				switch (num2 == num)
				{
				}
				num = (short)790888448;
				if (num != 0)
				{
				}
				num = (short)493879296;
				short num3 = num;
				num = (short)1908146177;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGSecondaryFSRxFrequencyMHz_A8895.Editable;
			}
			set
			{
				short num = (short)2042007391;
				short num2 = num;
				num = (short)1698795359;
				switch (num2 == num)
				{
				}
				num = (short)1536425984;
				if (num != 0)
				{
				}
				num = (short)1284505600;
				short num3 = num;
				num = (short)1671626753;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAGSecondaryFSRxFrequencyMHz_A8895.Editable = value;
			}
		}

		// Token: 0x17000B82 RID: 2946
		// (get) Token: 0x060016E0 RID: 5856 RVA: 0x001595D4 File Offset: 0x001577D4
		internal string TrkPerAnnouncementGroupAGSecondaryFSRxFrequencyMHz_A8895_UILabel
		{
			get
			{
				short num = (short)1741830813;
				short num2 = num;
				num = (short)829897373;
				switch (num2 == num)
				{
				}
				num = (short)167116800;
				if (num != 0)
				{
				}
				num = (short)1970798592;
				short num3 = num;
				num = (short)283312129;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGSecondaryFSRxFrequencyMHz_A8895.UIName;
			}
		}

		// Token: 0x17000B83 RID: 2947
		// (get) Token: 0x060016E1 RID: 5857 RVA: 0x00159688 File Offset: 0x00157888
		// (set) Token: 0x060016E2 RID: 5858 RVA: 0x0015973C File Offset: 0x0015793C
		internal bool TrkPerAnnouncementGroupAGSecondaryFSRxFrequencyMHz_A8895_HiddenStatic
		{
			get
			{
				short num = (short)568203836;
				short num2 = num;
				num = (short)1209997884;
				switch (num2 == num)
				{
				}
				num = (short)1963982848;
				if (num != 0)
				{
				}
				num = (short)621805568;
				short num3 = num;
				num = (short)255262721;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGSecondaryFSRxFrequencyMHz_A8895.HiddenStatic;
			}
			set
			{
				short num = (short)1915918762;
				short num2 = num;
				num = (short)1713150378;
				switch (num2 == num)
				{
				}
				num = (short)2097414145;
				if (num != 0)
				{
				}
				num = (short)705757184;
				short num3 = num;
				num = (short)1302331392;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAGSecondaryFSRxFrequencyMHz_A8895.HiddenStatic = value;
			}
		}

		// Token: 0x17000B84 RID: 2948
		// (get) Token: 0x060016E3 RID: 5859 RVA: 0x001597F0 File Offset: 0x001579F0
		// (set) Token: 0x060016E4 RID: 5860 RVA: 0x001598A4 File Offset: 0x00157AA4
		internal bool TrkPerAnnouncementGroupAGSecondaryFSRxFrequencyMHz_A8895_HiddenDynamic
		{
			get
			{
				short num = (short)691780811;
				short num2 = num;
				num = (short)1936309451;
				switch (num2 == num)
				{
				}
				num = (short)558563328;
				if (num != 0)
				{
				}
				num = (short)895549440;
				short num3 = num;
				num = (short)1631387649;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGSecondaryFSRxFrequencyMHz_A8895.HiddenDynamic;
			}
			set
			{
				short num = (short)2018175873;
				short num2 = num;
				num = (short)616819585;
				switch (num2 == num)
				{
				}
				num = (short)2139881473;
				if (num != 0)
				{
				}
				num = (short)363266048;
				short num3 = num;
				num = (short)506331136;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAGSecondaryFSRxFrequencyMHz_A8895.HiddenDynamic = value;
			}
		}

		// Token: 0x17000B85 RID: 2949
		// (get) Token: 0x060016E5 RID: 5861 RVA: 0x0015995C File Offset: 0x00157B5C
		public bool TrkPerAnnouncementGroupAGSecondaryFSRxFrequencyMHz_A8895_HasDiffs
		{
			get
			{
				short num = (short)996396760;
				short num2 = num;
				num = (short)1026739928;
				switch (num2 == num)
				{
				}
				num = (short)2056126464;
				if (num != 0)
				{
				}
				num = (short)1217200128;
				short num3 = num;
				num = (short)1545797633;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAGSecondaryFSRxFrequencyMHz_A8895._HasDiffs;
			}
		}

		// Token: 0x17000B86 RID: 2950
		// (get) Token: 0x060016E6 RID: 5862 RVA: 0x00159A10 File Offset: 0x00157C10
		// (set) Token: 0x060016E7 RID: 5863 RVA: 0x00159AC4 File Offset: 0x00157CC4
		public int TrkPerAnnouncementGroupAstroOTARProfileIndex_43686Value
		{
			get
			{
				short num = (short)1133749371;
				short num2 = num;
				num = (short)1944888443;
				switch (num2 == num)
				{
				}
				num = (short)751501312;
				if (num != 0)
				{
				}
				num = (short)1045692416;
				short num3 = num;
				num = (short)1780023297;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAstroOTARProfileIndex_43686.Value;
			}
			set
			{
				short num = (short)918021534;
				short num2 = num;
				num = (short)1079764382;
				switch (num2 == num)
				{
				}
				num = (short)145096705;
				if (num != 0)
				{
				}
				num = (short)347865088;
				short num3 = num;
				num = (short)2037579776;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAstroOTARProfileIndex_43686.Value = value;
			}
		}

		// Token: 0x17000B87 RID: 2951
		// (get) Token: 0x060016E8 RID: 5864 RVA: 0x00159B78 File Offset: 0x00157D78
		// (set) Token: 0x060016E9 RID: 5865 RVA: 0x00159C2C File Offset: 0x00157E2C
		public string TrkPerAnnouncementGroupAstroOTARProfileIndex_43686_UIValue
		{
			get
			{
				short num = (short)680732973;
				short num2 = num;
				num = (short)286927149;
				switch (num2 == num)
				{
				}
				num = (short)2044723201;
				if (num != 0)
				{
				}
				num = (short)2065498112;
				short num3 = num;
				num = (short)1930493952;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAstroOTARProfileIndex_43686.UIValue;
			}
			set
			{
				short num = (short)979633548;
				short num2 = num;
				num = (short)943785356;
				switch (num2 == num)
				{
				}
				num = (short)2034106368;
				if (num != 0)
				{
				}
				num = (short)1370161152;
				short num3 = num;
				num = (short)329908225;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAstroOTARProfileIndex_43686.UIValue = value;
			}
		}

		// Token: 0x17000B88 RID: 2952
		// (get) Token: 0x060016EA RID: 5866 RVA: 0x00159CE0 File Offset: 0x00157EE0
		public global::AcpBusinessLayer.AcpRecRefField TrkPerAnnouncementGroupAstroOTARProfileIndex_43686
		{
			get
			{
				short num = (short)1089088075;
				short num2 = num;
				num = (short)1144990283;
				switch (num2 == num)
				{
				}
				num = (short)1434976256;
				if (num != 0)
				{
				}
				num = (short)1050738688;
				short num3 = num;
				num = (short)663814145;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAstroOTARProfileIndex_43686;
			}
		}

		// Token: 0x17000B89 RID: 2953
		// (get) Token: 0x060016EB RID: 5867 RVA: 0x00159D90 File Offset: 0x00157F90
		// (set) Token: 0x060016EC RID: 5868 RVA: 0x00159E44 File Offset: 0x00158044
		public bool TrkPerAnnouncementGroupAstroOTARProfileIndex_43686_Applicable
		{
			get
			{
				short num = (short)631483555;
				short num2 = num;
				num = (short)670411939;
				switch (num2 == num)
				{
				}
				num = (short)497549312;
				if (num != 0)
				{
				}
				num = (short)1673789440;
				short num3 = num;
				num = (short)428015617;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAstroOTARProfileIndex_43686.Applicable;
			}
			set
			{
				short num = (short)419920311;
				short num2 = num;
				num = (short)522090935;
				switch (num2 == num)
				{
				}
				num = (short)416022528;
				if (num != 0)
				{
				}
				num = (short)611385344;
				short num3 = num;
				num = (short)1251934209;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAstroOTARProfileIndex_43686.Applicable = value;
			}
		}

		// Token: 0x17000B8A RID: 2954
		// (get) Token: 0x060016ED RID: 5869 RVA: 0x00159EF8 File Offset: 0x001580F8
		// (set) Token: 0x060016EE RID: 5870 RVA: 0x00159FAC File Offset: 0x001581AC
		public bool TrkPerAnnouncementGroupAstroOTARProfileIndex_43686_Valid
		{
			get
			{
				short num = (short)538777838;
				short num2 = num;
				num = (short)692197614;
				switch (num2 == num)
				{
				}
				num = (short)1681326081;
				if (num != 0)
				{
				}
				num = (short)950075392;
				short num3 = num;
				num = (short)454754304;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAstroOTARProfileIndex_43686.Valid;
			}
			set
			{
				short num = (short)1579758662;
				short num2 = num;
				num = (short)1791308870;
				switch (num2 == num)
				{
				}
				num = (short)1818165249;
				if (num != 0)
				{
				}
				num = (short)1618739200;
				short num3 = num;
				num = (short)1022492672;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAstroOTARProfileIndex_43686.Valid = value;
			}
		}

		// Token: 0x17000B8B RID: 2955
		// (get) Token: 0x060016EF RID: 5871 RVA: 0x0015A064 File Offset: 0x00158264
		// (set) Token: 0x060016F0 RID: 5872 RVA: 0x0015A118 File Offset: 0x00158318
		public bool TrkPerAnnouncementGroupAstroOTARProfileIndex_43686_Visible
		{
			get
			{
				short num = (short)497918109;
				short num2 = num;
				num = (short)1035116701;
				switch (num2 == num)
				{
				}
				num = (short)418840576;
				if (num != 0)
				{
				}
				num = (short)1127350272;
				short num3 = num;
				num = (short)2112487425;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAstroOTARProfileIndex_43686.Visible;
			}
			set
			{
				short num = (short)1258349594;
				short num2 = num;
				num = (short)786293786;
				switch (num2 == num)
				{
				}
				num = (short)834928640;
				if (num != 0)
				{
				}
				num = (short)948109312;
				short num3 = num;
				num = (short)1650589697;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAstroOTARProfileIndex_43686.Visible = value;
			}
		}

		// Token: 0x17000B8C RID: 2956
		// (get) Token: 0x060016F1 RID: 5873 RVA: 0x0015A1D0 File Offset: 0x001583D0
		// (set) Token: 0x060016F2 RID: 5874 RVA: 0x0015A284 File Offset: 0x00158484
		public bool TrkPerAnnouncementGroupAstroOTARProfileIndex_43686_Editable
		{
			get
			{
				short num = (short)1451085635;
				short num2 = num;
				num = (short)17420099;
				switch (num2 == num)
				{
				}
				num = (short)989855745;
				if (num != 0)
				{
				}
				num = (short)1639251968;
				short num3 = num;
				num = (short)227016704;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAstroOTARProfileIndex_43686.Editable;
			}
			set
			{
				short num = (short)1591410689;
				if (num != 0)
				{
				}
				num = (short)207605061;
				short num2 = num;
				num = (short)918474053;
				switch (num2 == num)
				{
				}
				num = (short)741408768;
				short num3 = num;
				num = (short)615710720;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAstroOTARProfileIndex_43686.Editable = value;
			}
		}

		// Token: 0x17000B8D RID: 2957
		// (get) Token: 0x060016F3 RID: 5875 RVA: 0x0015A33C File Offset: 0x0015853C
		internal string TrkPerAnnouncementGroupAstroOTARProfileIndex_43686_UILabel
		{
			get
			{
				short num = (short)1520766212;
				short num2 = num;
				num = (short)1319767300;
				switch (num2 == num)
				{
				}
				num = (short)1517551617;
				if (num != 0)
				{
				}
				num = (short)1743454208;
				short num3 = num;
				num = (short)1930297344;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAstroOTARProfileIndex_43686.UIName;
			}
		}

		// Token: 0x17000B8E RID: 2958
		// (get) Token: 0x060016F4 RID: 5876 RVA: 0x0015A3F0 File Offset: 0x001585F0
		// (set) Token: 0x060016F5 RID: 5877 RVA: 0x0015A4A8 File Offset: 0x001586A8
		internal bool TrkPerAnnouncementGroupAstroOTARProfileIndex_43686_HiddenStatic
		{
			get
			{
				short num = (short)957708533;
				short num2 = num;
				num = (short)644249845;
				switch (num2 == num)
				{
				}
				num = (short)1735262209;
				if (num != 0)
				{
				}
				num = (short)423690240;
				short num3 = num;
				num = (short)424738816;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAstroOTARProfileIndex_43686.HiddenStatic;
			}
			set
			{
				short num = (short)1533079673;
				short num2 = num;
				num = (short)516157561;
				switch (num2 == num)
				{
				}
				num = (short)515571712;
				if (num != 0)
				{
				}
				num = (short)1868234752;
				short num3 = num;
				num = (short)476839937;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAstroOTARProfileIndex_43686.HiddenStatic = value;
			}
		}

		// Token: 0x17000B8F RID: 2959
		// (get) Token: 0x060016F6 RID: 5878 RVA: 0x0015A55C File Offset: 0x0015875C
		// (set) Token: 0x060016F7 RID: 5879 RVA: 0x0015A60C File Offset: 0x0015880C
		internal bool TrkPerAnnouncementGroupAstroOTARProfileIndex_43686_HiddenDynamic
		{
			get
			{
				short num = (short)1155850019;
				short num2 = num;
				num = (short)1616240419;
				switch (num2 == num)
				{
				}
				num = (short)2097938432;
				if (num != 0)
				{
				}
				num = (short)630652928;
				short num3 = num;
				num = (short)1970470913;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAstroOTARProfileIndex_43686.HiddenDynamic;
			}
			set
			{
				short num = (short)208610488;
				short num2 = num;
				num = (short)191440056;
				switch (num2 == num)
				{
				}
				num = (short)1989279744;
				if (num != 0)
				{
				}
				num = (short)1716191232;
				short num3 = num;
				num = (short)782499841;
				if (num != 0)
				{
				}
				this.trkPerAnnouncementGroupAstroOTARProfileIndex_43686.HiddenDynamic = value;
			}
		}

		// Token: 0x17000B90 RID: 2960
		// (get) Token: 0x060016F8 RID: 5880 RVA: 0x0015A6C0 File Offset: 0x001588C0
		public bool TrkPerAnnouncementGroupAstroOTARProfileIndex_43686_HasDiffs
		{
			get
			{
				short num = (short)1617240417;
				short num2 = num;
				num = (short)547758433;
				switch (num2 == num)
				{
				}
				num = (short)737804288;
				if (num != 0)
				{
				}
				num = (short)1920991232;
				short num3 = num;
				num = (short)1592590337;
				if (num != 0)
				{
				}
				return this.trkPerAnnouncementGroupAstroOTARProfileIndex_43686._HasDiffs;
			}
		}

		// Token: 0x17000B91 RID: 2961
		// (get) Token: 0x060016F9 RID: 5881 RVA: 0x0015A774 File Offset: 0x00158974
		public global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide RefSecureWide
		{
			get
			{
				short num = (short)1513881601;
				if (num != 0)
				{
				}
				num = (short)1676528760;
				short num2 = num;
				num = (short)204721272;
				switch (num2 == num)
				{
				}
				num = (short)2096693248;
				short num3 = num;
				num = (short)86310912;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2021)[0] as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide;
			}
		}

		// Token: 0x17000B92 RID: 2962
		// (get) Token: 0x060016FA RID: 5882 RVA: 0x0015A834 File Offset: 0x00158A34
		public global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation RefRadioInformation
		{
			get
			{
				short num = (short)1383551212;
				short num2 = num;
				num = (short)171331820;
				switch (num2 == num)
				{
				}
				num = (short)608501761;
				if (num != 0)
				{
				}
				num = (short)982253568;
				short num3 = num;
				num = (short)334823424;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation;
			}
		}

		// Token: 0x060016FB RID: 5883 RVA: 0x0015A8F0 File Offset: 0x00158AF0
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			global::AcpCommonLib.IAcpRecordset result;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					if (base.ParentRecset.ContainerDoc == null)
					{
						return result;
					}
					num2 = (short)2057431048;
					short num3 = num2;
					num2 = (short)1752360968;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return result;
					default:
						num2 = (short)1265565696;
						if (num2 != 0)
						{
						}
						num2 = (short)719060993;
						if (num2 != 0)
						{
						}
						num2 = (short)1218838530;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
					num2 = (short)977797120;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
				{
					num2 = (short)88539136;
					short num4 = num2;
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)1239351300;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
					if (base.ParentRecset != null)
					{
						num2 = (short)48627713;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 4:
					return result;
				}
				goto IL_24;
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)1573126147;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0400085E RID: 2142
		private global::AcpBusinessLayer.AcpRecRefField trkPerAnnouncementGroupAGKeySelect_A7414;

		// Token: 0x0400085F RID: 2143
		private global::AcpBusinessLayer.AcpCustomRangeField trkPerAnnouncementGroupAnnouncementGroup_A7444;

		// Token: 0x04000860 RID: 2144
		private global::AcpBusinessLayer.AcpListField trkPerAnnouncementGroupAGVoiceSignalType_A7478;

		// Token: 0x04000861 RID: 2145
		private global::AcpBusinessLayer.AcpField<bool> trkPerAnnouncementGroupAnnouncementGroupFailsoft_A8597;

		// Token: 0x04000862 RID: 2146
		private global::AcpBusinessLayer.AcpListField trkPerAnnouncementGroupAGSecureClearStrapping_A9089;

		// Token: 0x04000863 RID: 2147
		private global::AcpBusinessLayer.AcpFrequencyField trkPerAnnouncementGroupAGFailsoftRxFrequencyMHz_A9582;

		// Token: 0x04000864 RID: 2148
		private global::AcpBusinessLayer.AcpFrequencyField trkPerAnnouncementGroupAGFailsoftTxFrequencyMHz_A9583;

		// Token: 0x04000865 RID: 2149
		private global::AcpBusinessLayer.AcpFrequencyField trkPerAnnouncementGroupAGSecondaryFSTxFrequencyMHz_A12903;

		// Token: 0x04000866 RID: 2150
		private global::AcpBusinessLayer.AcpSimpleRangeField trkPerAnnouncementGroupAGSystemID_A19705;

		// Token: 0x04000867 RID: 2151
		private global::AcpBusinessLayer.AcpSimpleRangeField trkPerAnnouncementGroupAGWACNID_A19706;

		// Token: 0x04000868 RID: 2152
		private global::AcpBusinessLayer.AcpField<bool> trkPerAnnouncementGroupAGSecondaryFailsoft_A19990;

		// Token: 0x04000869 RID: 2153
		private global::AcpBusinessLayer.AcpFrequencyField trkPerAnnouncementGroupAGSecondaryFSRxFrequencyMHz_A8895;

		// Token: 0x0400086A RID: 2154
		private global::AcpBusinessLayer.AcpRecRefField trkPerAnnouncementGroupAstroOTARProfileIndex_43686;
	}
}
