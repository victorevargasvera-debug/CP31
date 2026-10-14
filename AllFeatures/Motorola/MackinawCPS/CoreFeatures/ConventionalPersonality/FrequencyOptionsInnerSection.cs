using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using ConstraintHelper;
using Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList;
using Motorola.MackinawCPS.CoreFeatures.ConventionalWide;
using Motorola.MackinawCPS.CoreFeatures.RadioInformation;
using Motorola.MackinawCPS.CoreFeatures.SecureWide;

namespace Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality
{
	// Token: 0x020005C1 RID: 1473
	[global::System.Serializable]
	public class FrequencyOptionsInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600C4C1 RID: 50369 RVA: 0x00B87848 File Offset: 0x00B85A48
		public FrequencyOptionsInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x0600C4C2 RID: 50370 RVA: 0x00B87864 File Offset: 0x00B85A64
		protected FrequencyOptionsInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600C4C3 RID: 50371 RVA: 0x00B8787C File Offset: 0x00B85A7C
		public override void Init()
		{
			int a_ = 19;
			short num = (short)1873084416;
			short num2 = num;
			num = (short)1664290050;
			short num3 = num;
			num = (short)964037890;
			switch (num3 == num)
			{
			}
			num = (short)1747517440;
			if (num != 0)
			{
			}
			num = (short)262078465;
			if (num != 0)
			{
			}
			this.cnvPerConventionalChannelOptionsTANetworkID_A7863 = new global::AcpBusinessLayer.AcpSimpleRangeField(659, this, global::AllFeatures.CodeplugGuid.b("韓룕껗諙맛곝ꏟ跡諣郥跧蓩飫蟭鿯鳱闳髵믷鋹鷻都滿朁栃䤅砇縉攋愍縏愑䀓圕嘗缙栛椝伟倡伣漥氧甩洫᤭࠯бܳ", a_), global::CommonResources.AcgResources.ID_DIRECTNETWORKID, 0, 4095, null, null, 0, 1);
			this.cnvPerConventionalChannelOptionsTANetworkID_A7863.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvPerConventionalChannelOptionsTANetworkID_A7863.DataTransferOrder = 114;
			this.cnvPerConventionalChannelOptionsTANetworkID_A7863.ShowHexValue = true;
			this.cnvPerConventionalChannelOptionsItinerantChannelFrequency_A8359 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("韓룕껗諙맛곝ꏟ跡諣郥跧蓩飫蟭鿯鳱闳髵믷鋹鷻都滿朁栃䤅砇縉攋愍縏愑崓戕焗琙礛氝䄟䰡倣攥䀧䬩䈫䀭唯帱爳䐵崷䬹䤻嬽⸿⅁㵃᥅े牉罋筍楏", a_), global::CommonResources.AcgResources.ID_ITINERANTCHANNELFREQUENCY);
			this.cnvPerConventionalChannelOptionsItinerantChannelFrequency_A8359.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.cnvPerConventionalChannelOptionsItinerantChannelFrequency_A8359.DataTransferOrder = -1;
			this.cnvPerConventionalChannelOptionsPLDeviation_A8708 = new global::AcpBusinessLayer.AcpSparseLOVField(2, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.indexCnvPerConventionalChannelOptionsPLDeviation_A8708LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.idCnvPerConventionalChannelOptionsPLDeviation_A8708LovStrs), this, global::AllFeatures.CodeplugGuid.b("韓룕껗諙맛곝ꏟ跡諣郥跧蓩飫蟭鿯鳱闳髵믷鋹鷻都滿朁栃䤅砇縉攋愍縏愑䐓娕尗缙樛眝䄟嘡䴣䤥䘧甩洫ᘭܯȱళ", a_), global::CommonResources.AcgResources.ID_PLDEVIATION, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerConventionalChannelOptionsPLDeviation_A8708LovStrs);
			this.cnvPerConventionalChannelOptionsPLDeviation_A8708.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.cnvPerConventionalChannelOptionsPLDeviation_A8708.DataTransferOrder = 87;
			this.cnvPerConventionalChannelOptionsRxDPLCode_A8908 = new global::AcpBusinessLayer.AcpSparseLOVField(1, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.indexCnvPerConventionalChannelOptionsRxDPLCode_A8908LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.idCnvPerConventionalChannelOptionsRxDPLCode_A8908LovStrs), this, global::AllFeatures.CodeplugGuid.b("韓룕껗諙맛곝ꏟ跡諣郥跧蓩飫蟭鿯鳱闳髵믷鋹鷻都滿朁栃䤅砇縉攋愍縏愑䘓渕尗䨙倛崝伟䘡䄣礥椧ሩᔫḭ࠯", a_), global::CommonResources.AcgResources.ID_RXTADPLCODE, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerConventionalChannelOptionsRxDPLCode_A8908LovStrs);
			this.cnvPerConventionalChannelOptionsRxDPLCode_A8908.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.cnvPerConventionalChannelOptionsRxDPLCode_A8908.DataTransferOrder = 28;
			this.cnvPerConventionalChannelOptionsRxDPLCode_A8908.ValidateAcrossRecset = true;
			this.cnvPerConventionalChannelOptionsRxDPLInvert_A8909 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("韓룕껗諙맛곝ꏟ跡諣郥跧蓩飫蟭鿯鳱闳髵믷鋹鷻都滿朁栃䤅砇縉攋愍縏愑䘓渕尗䨙倛圝丟吡䄣吥尧甩洫ᘭयȱള", a_), global::CommonResources.AcgResources.ID_RXTADPLINVERT);
			this.cnvPerConventionalChannelOptionsRxDPLInvert_A8909.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.cnvPerConventionalChannelOptionsRxDPLInvert_A8909.DataTransferOrder = 29;
			this.cnvPerConventionalChannelOptionsRxDPLInvert_A8909.ValidateAcrossRecset = true;
			this.cnvPerConventionalChannelOptionsRxFrequency_A8911 = new global::AcpBusinessLayer.AcpFrequencyField(170212500, this, global::AllFeatures.CodeplugGuid.b("韓룕껗諙맛곝ꏟ跡諣郥跧蓩飫蟭鿯鳱闳髵믷鋹鷻都滿朁栃䤅砇縉攋愍縏愑䘓渕帗栙礛漝唟䜡䨣䔥儧甩洫ᘭय̱Գ", a_), global::CommonResources.AcgResources.ID_RXTAFREQUENCYMHZ, 0, int.MaxValue, 1);
			this.cnvPerConventionalChannelOptionsRxFrequency_A8911.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.cnvPerConventionalChannelOptionsRxFrequency_A8911.DataTransferOrder = 12;
			this.cnvPerConventionalChannelOptionsRxPLCode_A8917 = new global::AcpBusinessLayer.AcpSparseLOVField(1, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.indexCnvPerConventionalChannelOptionsRxPLCode_A8917LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.idCnvPerConventionalChannelOptionsRxPLCode_A8917LovStrs), this, global::AllFeatures.CodeplugGuid.b("韓룕껗諙맛곝ꏟ跡諣郥跧蓩飫蟭鿯鳱闳髵믷鋹鷻都滿朁栃䤅砇縉攋愍縏愑䘓渕䠗嘙弛焝䐟䜡笣朥ဧጩᴫ᤭", a_), global::CommonResources.AcgResources.ID_RXTAPLCODE_1, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerConventionalChannelOptionsRxPLCode_A8917LovStrs);
			this.cnvPerConventionalChannelOptionsRxPLCode_A8917.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.cnvPerConventionalChannelOptionsRxPLCode_A8917.DataTransferOrder = 26;
			this.cnvPerConventionalChannelOptionsRxPLCode_A8917.ValidateAcrossRecset = true;
			this.cnvPerConventionalChannelOptionsRxPLFreq_A8918 = new global::AcpBusinessLayer.AcpSparseLOVField(1, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.indexCnvPerConventionalChannelOptionsRxPLFreq_A8918LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.idCnvPerConventionalChannelOptionsRxPLFreq_A8918LovStrs), this, global::AllFeatures.CodeplugGuid.b("韓룕껗諙맛곝ꏟ跡諣郥跧蓩飫蟭鿯鳱闳髵믷鋹鷻都滿朁栃䤅砇縉攋愍縏愑䘓渕䠗嘙娛氝䔟匡笣朥ဧጩᴫᘭ", a_), global::CommonResources.AcgResources.ID_RXTAPLFREQ, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerConventionalChannelOptionsRxPLFreq_A8918LovStrs);
			this.cnvPerConventionalChannelOptionsRxPLFreq_A8918.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.cnvPerConventionalChannelOptionsRxPLFreq_A8918.DataTransferOrder = 27;
			this.cnvPerConventionalChannelOptionsRxPLFreq_A8918.ValidateAcrossRecset = true;
			this.cnvPerConventionalChannelOptionsRxSquelchType_A8919 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.indexCnvPerConventionalChannelOptionsRxSquelchType_A8919LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.idCnvPerConventionalChannelOptionsRxSquelchType_A8919LovStrs), this, global::AllFeatures.CodeplugGuid.b("韓룕껗諙맛곝ꏟ跡諣郥跧蓩飫蟭鿯鳱闳髵믷鋹鷻都滿朁栃䤅砇縉攋愍縏愑䘓渕䬗欙椛笝䰟䄡䰣爥儧娩䤫焭焯਱ളܵķ", a_), global::CommonResources.AcgResources.ID_RXTASQUELCHTYPE, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerConventionalChannelOptionsRxSquelchType_A8919LovStrs);
			this.cnvPerConventionalChannelOptionsRxSquelchType_A8919.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.cnvPerConventionalChannelOptionsRxSquelchType_A8919.DataTransferOrder = 17;
			this.cnvPerConventionalChannelOptionsRxSquelchType_A8919.ValidateAcrossRecset = true;
			this.cnvPerConventionalChannelOptionsRxNetworkID_A9023 = new global::AcpBusinessLayer.AcpSimpleRangeField(659, this, global::AllFeatures.CodeplugGuid.b("韓룕껗諙맛곝ꏟ跡諣郥跧蓩飫蟭鿯鳱闳髵믷鋹鷻都滿朁栃䤅砇縉攋愍縏愑䘓渕嘗缙栛椝伟倡伣漥氧甩洫ᜭ/1ܳ", a_), global::CommonResources.AcgResources.ID_RXTANETWORKID, 0, 4095, null, null, 0, 1);
			this.cnvPerConventionalChannelOptionsRxNetworkID_A9023.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.cnvPerConventionalChannelOptionsRxNetworkID_A9023.DataTransferOrder = 35;
			this.cnvPerConventionalChannelOptionsRxNetworkID_A9023.ValidateAcrossRecset = true;
			this.cnvPerConventionalChannelOptionsRxNetworkID_A9023.ShowHexValue = true;
			this.cnvPerConventionalChannelOptionsDirectTalkaround_A9255 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("韓룕껗諙맛곝ꏟ跡諣郥跧蓩飫蟭鿯鳱闳髵믷鋹鷻都滿朁栃䤅砇縉攋愍縏愑倓缕樗缙缛樝琟䌡䠣䴥䤧堩䌫嬭帯嘱欳眵ķ࠹ऻଽ", a_), global::CommonResources.AcgResources.ID_DIRECTTALKAROUND);
			this.cnvPerConventionalChannelOptionsDirectTalkaround_A9255.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvPerConventionalChannelOptionsDirectTalkaround_A9255.DataTransferOrder = 36;
			this.cnvPerConventionalChannelOptionsTADPLCode_A9256 = new global::AcpBusinessLayer.AcpSparseLOVField(1, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.indexCnvPerConventionalChannelOptionsTADPLCode_A9256LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.idCnvPerConventionalChannelOptionsTADPLCode_A9256LovStrs), this, global::AllFeatures.CodeplugGuid.b("韓룕껗諙맛곝ꏟ跡諣郥跧蓩飫蟭鿯鳱闳髵믷鋹鷻都滿朁栃䤅砇縉攋愍縏愑䀓圕尗䨙倛崝伟䘡䄣礥椧ጩḫᬭد", a_), global::CommonResources.AcgResources.ID_DIRECTDPLCODE, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerConventionalChannelOptionsTADPLCode_A9256LovStrs);
			this.cnvPerConventionalChannelOptionsTADPLCode_A9256.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvPerConventionalChannelOptionsTADPLCode_A9256.DataTransferOrder = 124;
			this.cnvPerConventionalChannelOptionsTADPLInvert_A9259 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("韓룕껗諙맛곝ꏟ跡諣郥跧蓩飫蟭鿯鳱闳髵믷鋹鷻都滿朁栃䤅砇縉攋愍縏愑䀓圕尗䨙倛圝丟吡䄣吥尧甩洫ᜭȯܱള", a_), global::CommonResources.AcgResources.ID_DIRECTDPLINVERT);
			this.cnvPerConventionalChannelOptionsTADPLInvert_A9259.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvPerConventionalChannelOptionsTADPLInvert_A9259.DataTransferOrder = 125;
			this.cnvPerConventionalChannelOptionsTAFrequency_A9260 = new global::AcpBusinessLayer.AcpFrequencyField(170212500, this, global::AllFeatures.CodeplugGuid.b("韓룕껗諙맛곝ꏟ跡諣郥跧蓩飫蟭鿯鳱闳髵믷鋹鷻都滿朁栃䤅砇縉攋愍縏愑䀓圕帗栙礛漝唟䜡䨣䔥儧甩洫ᜭȯбг", a_), global::CommonResources.AcgResources.ID_DIRECTFREQUENCYMHZ, 0, int.MaxValue, 1);
			this.cnvPerConventionalChannelOptionsTAFrequency_A9260.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvPerConventionalChannelOptionsTAFrequency_A9260.DataTransferOrder = 123;
			this.cnvPerConventionalChannelOptionsTAPLCode_A9261 = new global::AcpBusinessLayer.AcpSparseLOVField(1, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.indexCnvPerConventionalChannelOptionsTAPLCode_A9261LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.idCnvPerConventionalChannelOptionsTAPLCode_A9261LovStrs), this, global::AllFeatures.CodeplugGuid.b("韓룕껗諙맛곝ꏟ跡諣郥跧蓩飫蟭鿯鳱闳髵믷鋹鷻都滿朁栃䤅砇縉攋愍縏愑䀓圕䠗嘙弛焝䐟䜡笣朥ᄧᠩᨫἭ", a_), global::CommonResources.AcgResources.ID_DIRECTPLCODE, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerConventionalChannelOptionsTAPLCode_A9261LovStrs);
			this.cnvPerConventionalChannelOptionsTAPLCode_A9261.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvPerConventionalChannelOptionsTAPLCode_A9261.DataTransferOrder = 40;
			this.cnvPerConventionalChannelOptionsTAPLFreq_A9264 = new global::AcpBusinessLayer.AcpSparseLOVField(1, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.indexCnvPerConventionalChannelOptionsTAPLFreq_A9264LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.idCnvPerConventionalChannelOptionsTAPLFreq_A9264LovStrs), this, global::AllFeatures.CodeplugGuid.b("韓룕껗諙맛곝ꏟ跡諣郥跧蓩飫蟭鿯鳱闳髵믷鋹鷻都滿朁栃䤅砇縉攋愍縏愑䀓圕䠗嘙娛氝䔟匡笣朥ᄧᠩᨫᨭ", a_), global::CommonResources.AcgResources.ID_DIRECTPLFREQ, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerConventionalChannelOptionsTAPLFreq_A9264LovStrs);
			this.cnvPerConventionalChannelOptionsTAPLFreq_A9264.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvPerConventionalChannelOptionsTAPLFreq_A9264.DataTransferOrder = 39;
			this.cnvPerConventionalChannelOptionsTASquelchType_A9265 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.indexCnvPerConventionalChannelOptionsTASquelchType_A9265LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.idCnvPerConventionalChannelOptionsTASquelchType_A9265LovStrs), this, global::AllFeatures.CodeplugGuid.b("韓룕껗諙맛곝ꏟ跡諣郥跧蓩飫蟭鿯鳱闳髵믷鋹鷻都滿朁栃䤅砇縉攋愍縏愑䀓圕䬗欙椛笝䰟䄡䰣爥儧娩䤫焭焯଱س5ഷ", a_), global::CommonResources.AcgResources.ID_DIRECTSQUELCHTYPE, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerConventionalChannelOptionsTASquelchType_A9265LovStrs);
			this.cnvPerConventionalChannelOptionsTASquelchType_A9265.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvPerConventionalChannelOptionsTASquelchType_A9265.DataTransferOrder = 38;
			this.cnvPerConventionalChannelOptionsASTROTalkgroupID_A9281 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("韓룕껗諙맛곝ꏟ跡諣郥跧蓩飫蟭鿯鳱闳髵믷鋹鷻都滿朁栃䤅砇縉攋愍縏愑唓䔕䰗䠙匛䨝䄟両伣䄥娧䔩夫席礯瘱欳眵ķ࠹л༽", a_), global::CommonResources.AcgResources.ID_ASTROTALKGROUPID, new string[]
			{
				global::CommonResources.AcgResources.ID_DYN,
				global::CommonResources.AcgResources.ID_ATG
			}, new int[]
			{
				65535,
				65534
			}, false, true);
			this.cnvPerConventionalChannelOptionsASTROTalkgroupID_A9281.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvPerConventionalChannelOptionsASTROTalkgroupID_A9281.DataTransferOrder = 55;
			this.cnvPerConventionalChannelOptionsASTROTalkgroupID_A9281.EvaluateRecRefs = true;
			this.cnvPerConventionalChannelOptionsTxDPLCode_A9409 = new global::AcpBusinessLayer.AcpSparseLOVField(1, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.indexCnvPerConventionalChannelOptionsTxDPLCode_A9409LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.idCnvPerConventionalChannelOptionsTxDPLCode_A9409LovStrs), this, global::AllFeatures.CodeplugGuid.b("韓룕껗諙맛곝ꏟ跡諣郥跧蓩飫蟭鿯鳱闳髵믷鋹鷻都滿朁栃䤅砇縉攋愍縏愑䀓渕尗䨙倛崝伟䘡䄣礥椧ጩᠫḭय", a_), global::CommonResources.AcgResources.ID_TXDPLCODE, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerConventionalChannelOptionsTxDPLCode_A9409LovStrs);
			this.cnvPerConventionalChannelOptionsTxDPLCode_A9409.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.cnvPerConventionalChannelOptionsTxDPLCode_A9409.DataTransferOrder = 15;
			this.cnvPerConventionalChannelOptionsTxDPLCode_A9409.ValidateAcrossRecset = true;
			this.cnvPerConventionalChannelOptionsTxDPLInvert_A9410 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("韓룕껗諙맛곝ꏟ跡諣郥跧蓩飫蟭鿯鳱闳髵믷鋹鷻都滿朁栃䤅砇縉攋愍縏愑䀓渕尗䨙倛圝丟吡䄣吥尧甩洫ᜭЯ̱г", a_), global::CommonResources.AcgResources.ID_TXDPLINVERT);
			this.cnvPerConventionalChannelOptionsTxDPLInvert_A9410.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.cnvPerConventionalChannelOptionsTxDPLInvert_A9410.DataTransferOrder = 16;
			this.cnvPerConventionalChannelOptionsTxDPLInvert_A9410.ValidateAcrossRecset = true;
			this.cnvPerConventionalChannelOptionsTxFrequency_A9414 = new global::AcpBusinessLayer.AcpFrequencyField(161202500, this, global::AllFeatures.CodeplugGuid.b("韓룕껗諙맛곝ꏟ跡諣郥跧蓩飫蟭鿯鳱闳髵믷鋹鷻都滿朁栃䤅砇縉攋愍縏愑䀓渕帗栙礛漝唟䜡䨣䔥儧甩洫ᜭЯ̱3", a_), global::CommonResources.AcgResources.ID_TXFREQUENCYMHZ, 0, int.MaxValue, 1);
			this.cnvPerConventionalChannelOptionsTxFrequency_A9414.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.cnvPerConventionalChannelOptionsTxFrequency_A9414.DataTransferOrder = 22;
			this.cnvPerConventionalChannelOptionsTxFrequency_A9414.ValidateAcrossRecset = true;
			this.cnvPerConventionalChannelOptionsTxPLCode_A9418 = new global::AcpBusinessLayer.AcpSparseLOVField(1, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.indexCnvPerConventionalChannelOptionsTxPLCode_A9418LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.idCnvPerConventionalChannelOptionsTxPLCode_A9418LovStrs), this, global::AllFeatures.CodeplugGuid.b("韓룕껗諙맛곝ꏟ跡諣郥跧蓩飫蟭鿯鳱闳髵믷鋹鷻都滿朁栃䤅砇縉攋愍縏愑䀓渕䠗嘙弛焝䐟䜡笣朥ᄧḩᴫᘭ", a_), global::CommonResources.AcgResources.ID_TXPLCODE, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerConventionalChannelOptionsTxPLCode_A9418LovStrs);
			this.cnvPerConventionalChannelOptionsTxPLCode_A9418.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.cnvPerConventionalChannelOptionsTxPLCode_A9418.DataTransferOrder = 24;
			this.cnvPerConventionalChannelOptionsTxPLCode_A9418.ValidateAcrossRecset = true;
			this.cnvPerConventionalChannelOptionsTxPLFreq_A9419 = new global::AcpBusinessLayer.AcpSparseLOVField(1, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.indexCnvPerConventionalChannelOptionsTxPLFreq_A9419LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.idCnvPerConventionalChannelOptionsTxPLFreq_A9419LovStrs), this, global::AllFeatures.CodeplugGuid.b("韓룕껗諙맛곝ꏟ跡諣郥跧蓩飫蟭鿯鳱闳髵믷鋹鷻都滿朁栃䤅砇縉攋愍縏愑䀓渕䠗嘙娛氝䔟匡笣朥ᄧḩᴫᜭ", a_), global::CommonResources.AcgResources.ID_TXPLFREQ, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerConventionalChannelOptionsTxPLFreq_A9419LovStrs);
			this.cnvPerConventionalChannelOptionsTxPLFreq_A9419.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.cnvPerConventionalChannelOptionsTxPLFreq_A9419.DataTransferOrder = 25;
			this.cnvPerConventionalChannelOptionsTxPLFreq_A9419.ValidateAcrossRecset = true;
			this.cnvPerConventionalChannelOptionsTxSquelchType_A9426 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.indexCnvPerConventionalChannelOptionsTxSquelchType_A9426LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.idCnvPerConventionalChannelOptionsTxSquelchType_A9426LovStrs), this, global::AllFeatures.CodeplugGuid.b("韓룕껗諙맛곝ꏟ跡諣郥跧蓩飫蟭鿯鳱闳髵믷鋹鷻都滿朁栃䤅砇縉攋愍縏愑䀓渕䬗欙椛笝䰟䄡䰣爥儧娩䤫焭焯଱3еื", a_), global::CommonResources.AcgResources.ID_TXSQUELCHTYPE, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerConventionalChannelOptionsTxSquelchType_A9426LovStrs);
			this.cnvPerConventionalChannelOptionsTxSquelchType_A9426.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.cnvPerConventionalChannelOptionsTxSquelchType_A9426.DataTransferOrder = 14;
			this.cnvPerConventionalChannelOptionsTxSquelchType_A9426.ValidateAcrossRecset = true;
			this.cnvPerConventionalChannelOptionsTxNetworkID_A9550 = new global::AcpBusinessLayer.AcpSimpleRangeField(659, this, global::AllFeatures.CodeplugGuid.b("韓룕껗諙맛곝ꏟ跡諣郥跧蓩飫蟭鿯鳱闳髵믷鋹鷻都滿朁栃䤅砇縉攋愍縏愑䀓渕嘗缙栛椝伟倡伣漥氧甩洫ᜭԯܱг", a_), global::CommonResources.AcgResources.ID_TXNETWORKID, 0, 4095, null, null, 0, 1);
			this.cnvPerConventionalChannelOptionsTxNetworkID_A9550.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.cnvPerConventionalChannelOptionsTxNetworkID_A9550.DataTransferOrder = 23;
			this.cnvPerConventionalChannelOptionsTxNetworkID_A9550.ValidateAcrossRecset = true;
			this.cnvPerConventionalChannelOptionsTxNetworkID_A9550.ShowHexValue = true;
			this.cnvPerConventionalChannelOptionsUserSelectablePLMPL_A9606 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("韓룕껗諙맛곝ꏟ跡諣郥跧蓩飫蟭鿯鳱闳髵믷鋹鷻都滿朁栃䤅砇縉攋愍縏愑䄓攕紗栙伛笝䰟䜡䜣別䤧䠩䀫䬭怯縱礳昵琷改紻ܽ瘿牁牃", a_), global::CommonResources.AcgResources.ID_USERSELECTABLEPLMPL);
			this.cnvPerConventionalChannelOptionsUserSelectablePLMPL_A9606.IgnoreOnCompare = true;
			this.cnvPerConventionalChannelOptionsUserSelectablePLMPL_A9606.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvPerConventionalChannelOptionsUserSelectablePLMPL_A9606.DataTransferOrder = 13;
			this.cnvPerConventionalChannelOptionsTalkaround_A19837 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("韓룕껗諙맛곝ꏟ跡諣郥跧蓩飫蟭鿯鳱闳髵믷鋹鷻都滿朁栃䤅砇縉攋愍縏愑䀓眕琗焙紛氝伟圡䨣䈥眧欩ᴫᜭ࠯ı̳", a_), global::CommonResources.AcgResources.ID_TALKAROUND);
			this.cnvPerConventionalChannelOptionsTalkaround_A19837.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.cnvPerConventionalChannelOptionsTalkaround_A19837.DataTransferOrder = -1;
			this.cnvPerConventionalChannelOptionsKeyofConventionalChannelOptions_A20745 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("韓룕껗諙맛곝ꏟ跡諣郥跧蓩飫蟭鿯鳱闳髵믷鋹鷻都滿朁栃䤅砇縉攋愍縏愑弓猕愗甙稛崝伟䰡刣䌥䘧帩䔫䄭帯匱堳电倷嬹刻倽┿⹁ୃ㙅㱇⍉⍋⁍⍏൑ᕓ摕桗浙桛歝", a_), global::CommonResources.AcgResources.ID_NAME, 14);
			this.cnvPerConventionalChannelOptionsKeyofConventionalChannelOptions_A20745.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.cnvPerConventionalChannelOptionsKeyofConventionalChannelOptions_A20745.DataTransferOrder = 70;
			this.cnvPerConventionalChannelOptionsTxDevChanSpacing_A23192 = new global::AcpBusinessLayer.AcpSparseLOVField(25634, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.indexCnvPerConventionalChannelOptionsTxDevChanSpacing_A23192LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.idCnvPerConventionalChannelOptionsTxDevChanSpacing_A23192LovStrs), this, global::AllFeatures.CodeplugGuid.b("韓룕껗諙맛곝ꏟ跡諣郥跧蓩飫蟭鿯鳱闳髵믷鋹鷻都滿朁栃䤅砇縉攋愍縏愑䀓渕尗缙樛崝䠟䌡䨣甥堧䬩伫䜭帯唱欳眵਷ह഻ܽ爿", a_), global::CommonResources.AcgResources.ID_TXDEVIATIONCHANNELSPACING, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerConventionalChannelOptionsTxDevChanSpacing_A23192LovStrs);
			this.cnvPerConventionalChannelOptionsTxDevChanSpacing_A23192.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.cnvPerConventionalChannelOptionsTxDevChanSpacing_A23192.DataTransferOrder = 58;
			this.cnvPerConventionalChannelOptionsTxDevChanSpacing_A23192.ValidateAcrossRecset = true;
			this.cnvPerConventionalFrqncyOptnsMixVSPersistentMember_A38726 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("韓룕껗諙맛곝ꏟ跡諣郥跧蓩飫蟭鿯鳱闳髵뻷裹跻都揿笁䬃瘅簇搉缋䌍礏樑䈓䔕䠗缙減洝䤟儡倣䌥䘧帩愫䬭崯倱儳䐵朷笹༻ؽ眿灁牃", a_), global::CommonResources.AcgResources.ID_MIXEDVOTESCANPERSISTENTMEMBER);
			this.cnvPerConventionalFrqncyOptnsMixVSPersistentMember_A38726.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.cnvPerConventionalFrqncyOptnsMixVSPersistentMember_A38726.DataTransferOrder = 161;
			this.cnvPerConventionalChannelOptionsUserSelectablePLMPLEnhance_43029 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.indexCnvPerConventionalChannelOptionsUserSelectablePLMPLEnhance_43029LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.idCnvPerConventionalChannelOptionsUserSelectablePLMPLEnhance_43029LovStrs), this, global::AllFeatures.CodeplugGuid.b("韓룕껗諙맛곝ꏟ跡諣郥跧蓩飫蟭鿯鳱闳髵믷鋹鷻都滿朁栃䤅砇縉攋愍縏愑䄓攕紗栙伛笝䰟䜡䜣別䤧䠩䀫䬭怯縱礳昵琷缹刻嘽ℿⱁ❃⍅ᝇ繉罋繍扏歑", a_), global::CommonResources.AcgResources.ID_USERSELECTABLEPLMPL_1, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerConventionalChannelOptionsUserSelectablePLMPLEnhance_43029LovStrs);
			this.cnvPerConventionalChannelOptionsUserSelectablePLMPLEnhance_43029.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvPerConventionalChannelOptionsUserSelectablePLMPLEnhance_43029.DataTransferOrder = 118;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鋓ꓕ뷗ꯙ꧛믝軟臡鷣웥꟧髩飫蟭鿯鳱蟳", a_);
			base.Id = 10149;
			base.UIName = global::CommonResources.AcgResources.ID_FREQUENCYOPTIONS;
			base.DataTransferOrder = 1;
		}

		// Token: 0x0600C4C4 RID: 50372 RVA: 0x00B882D4 File Offset: 0x00B864D4
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 11;
			short num = (short)802816033;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("迋ꃍꛏ苑뇓ꓕ鯗뗙닛꣝藟賡郣迥蟧蓩跫苭돯髱闳飵雷鿹郻뇽烿瘁洃椅昇礉帋瘍䌏挑愓猕琗礙琛䨝够刡䄣礥椧ሩᔫἭय", a_)))
					{
						num = (short)124977170;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A7F;
				case 1:
					this.cnvPerConventionalChannelOptionsTAFrequency_A9260 = new global::AcpBusinessLayer.AcpFrequencyField(170212500, this, global::AllFeatures.CodeplugGuid.b("迋ꃍꛏ苑뇓ꓕ鯗뗙닛꣝藟賡郣迥蟧蓩跫苭돯髱闳飵雷鿹郻뇽烿瘁洃椅昇礉堋伍嘏怑焓朕洗缙爛紝够紡攣ἥᨧᰩᰫ", a_), global::CommonResources.AcgResources.ID_DIRECTFREQUENCYMHZ);
					this.cnvPerConventionalChannelOptionsTAFrequency_A9260.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvPerConventionalChannelOptionsTAFrequency_A9260.DataTransferOrder = 123;
					num = (short)142868543;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("迋ꃍꛏ苑뇓ꓕ鯗뗙닛꣝藟賡郣迥蟧蓩跫苭돯髱闳飵雷鿹郻뇽烿瘁洃椅昇礉帋瘍䀏帑刓搕紗欙䌛弝᠟ᬡᔣḥ", a_)))
					{
						num = (short)2088960073;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_ACB;
				case 3:
					this.cnvPerConventionalChannelOptionsTASquelchType_A9265 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.indexCnvPerConventionalChannelOptionsTASquelchType_A9265LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.idCnvPerConventionalChannelOptionsTASquelchType_A9265LovStrs), this, global::AllFeatures.CodeplugGuid.b("迋ꃍꛏ苑뇓ꓕ鯗뗙닛꣝藟賡郣迥蟧蓩跫苭돯髱闳飵雷鿹郻뇽烿瘁洃椅昇礉堋伍䌏挑愓猕琗礙琛䨝够刡䄣礥椧ጩḫᠭԯ", a_), global::CommonResources.AcgResources.ID_DIRECTSQUELCHTYPE, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerConventionalChannelOptionsTASquelchType_A9265LovStrs);
					this.cnvPerConventionalChannelOptionsTASquelchType_A9265.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvPerConventionalChannelOptionsTASquelchType_A9265.DataTransferOrder = 38;
					num = (short)1193017404;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
				{
					num = (short)708436596;
					short num3 = num;
					num = (short)399827572;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_D56;
					default:
						num = (short)745603072;
						if (num != 0)
						{
						}
						if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("迋ꃍꛏ苑뇓ꓕ鯗뗙닛꣝藟賡郣迥蟧蓩跫苭돯髱闳飵雷鿹郻뇽烿瘁洃椅昇礉堋瘍䀏帑圓礕簗缙䌛弝᤟ᘡᔣḥ", a_)))
						{
							num = (short)996933684;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_14EF;
					}
					break;
				}
				case 5:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("迋ꃍꛏ苑뇓ꓕ鯗뗙닛꣝藟賡郣迥蟧蓩跫苭돯髱闳飵雷鿹郻뇽烿瘁洃椅昇礉堋瘍吏䈑堓唕眗縙礛䄝感ᬡဣᘥᄧ", a_)))
					{
						num = (short)1939669034;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_8C6;
				case 6:
					goto IL_3E9;
				case 7:
					goto IL_1818;
				case 8:
					goto IL_4C4;
				case 9:
					goto IL_C89;
				case 10:
					goto IL_C3B;
				case 11:
					if (producerFields != null)
					{
						num = (short)1535770698;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_18BE;
				case 12:
					this.cnvPerConventionalChannelOptionsDirectTalkaround_A9255 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("迋ꃍꛏ苑뇓ꓕ鯗뗙닛꣝藟賡郣迥蟧蓩跫苭돯髱闳飵雷鿹郻뇽烿瘁洃椅昇礉䠋服戏眑眓戕䰗笙瀛甝䄟倡䬣匥䘧丩猫漭य1ĳ̵", a_), global::CommonResources.AcgResources.ID_DIRECTTALKAROUND);
					this.cnvPerConventionalChannelOptionsDirectTalkaround_A9255.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvPerConventionalChannelOptionsDirectTalkaround_A9255.DataTransferOrder = 36;
					num = (short)626262025;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("迋ꃍꛏ苑뇓ꓕ鯗뗙닛꣝藟賡郣迥蟧蓩跫苭돯髱闳飵雷鿹郻뇽烿瘁洃椅昇礉堋瘍吏眑戓唕瀗笙爛䴝借䌡䜣伥䘧䴩猫漭ȯıԳ༵਷", a_)))
					{
						num = (short)347406365;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_E7F;
				case 14:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("迋ꃍꛏ苑뇓ꓕ鯗뗙닛꣝藟賡郣迥蟧蓩跫苭돯髱闳飵雷鿹郻뇽烿瘁洃椅昇礉夋納甏怑䜓猕琗缙缛樝䄟䀡䠣䌥砧昩愫縭簯眱娳帵夷吹弻嬽Ἷ癁睃癅穇獉", a_)))
					{
						num = (short)280166492;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_18BE;
				case 15:
					goto IL_335;
				case 16:
					goto IL_CD7;
				case 17:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("迋ꃍꛏ苑뇓ꓕ鯗뗙닛꣝藟賡郣迥蟧蓩跫苭돯髱闳飵雷鿹郻뇽烿瘁洃椅昇礉堋伍嘏怑焓朕洗缙爛紝够紡攣ἥᨧᰩᰫ", a_)))
					{
						goto IL_D56;
					}
					goto IL_1608;
				case 18:
					this.cnvPerConventionalChannelOptionsRxSquelchType_A8919 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.indexCnvPerConventionalChannelOptionsRxSquelchType_A8919LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.idCnvPerConventionalChannelOptionsRxSquelchType_A8919LovStrs), this, global::AllFeatures.CodeplugGuid.b("迋ꃍꛏ苑뇓ꓕ鯗뗙닛꣝藟賡郣迥蟧蓩跫苭돯髱闳飵雷鿹郻뇽烿瘁洃椅昇礉帋瘍䌏挑愓猕琗礙琛䨝够刡䄣礥椧ሩᔫἭय", a_), global::CommonResources.AcgResources.ID_RXTASQUELCHTYPE, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerConventionalChannelOptionsRxSquelchType_A8919LovStrs);
					this.cnvPerConventionalChannelOptionsRxSquelchType_A8919.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.cnvPerConventionalChannelOptionsRxSquelchType_A8919.DataTransferOrder = 17;
					this.cnvPerConventionalChannelOptionsRxSquelchType_A8919.ValidateAcrossRecset = true;
					num = (short)1149960279;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 19:
					this.cnvPerConventionalChannelOptionsTADPLInvert_A9259 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("迋ꃍꛏ苑뇓ꓕ鯗뗙닛꣝藟賡郣迥蟧蓩跫苭돯髱闳飵雷鿹郻뇽烿瘁洃椅昇礉堋伍吏䈑堓引瘗氙礛氝吟紡攣ἥᨧἩᔫ", a_), global::CommonResources.AcgResources.ID_DIRECTDPLINVERT);
					this.cnvPerConventionalChannelOptionsTADPLInvert_A9259.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvPerConventionalChannelOptionsTADPLInvert_A9259.DataTransferOrder = 125;
					num = (short)447873090;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 20:
					this.cnvPerConventionalChannelOptionsTxNetworkID_A9550 = new global::AcpBusinessLayer.AcpSimpleRangeField(659, this, global::AllFeatures.CodeplugGuid.b("迋ꃍꛏ苑뇓ꓕ鯗뗙닛꣝藟賡郣迥蟧蓩跫苭돯髱闳飵雷鿹郻뇽烿瘁洃椅昇礉堋瘍帏眑怓愕眗栙眛圝搟紡攣ἥᴧἩᰫ", a_), global::CommonResources.AcgResources.ID_TXNETWORKID, null, null, 0, 1);
					this.cnvPerConventionalChannelOptionsTxNetworkID_A9550.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.cnvPerConventionalChannelOptionsTxNetworkID_A9550.DataTransferOrder = 23;
					this.cnvPerConventionalChannelOptionsTxNetworkID_A9550.ValidateAcrossRecset = true;
					this.cnvPerConventionalChannelOptionsTxNetworkID_A9550.ShowHexValue = true;
					num = (short)455933977;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 21:
					goto IL_1455;
				case 22:
					this.cnvPerConventionalChannelOptionsTADPLCode_A9256 = new global::AcpBusinessLayer.AcpSparseLOVField(1, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.indexCnvPerConventionalChannelOptionsTADPLCode_A9256LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.idCnvPerConventionalChannelOptionsTADPLCode_A9256LovStrs), this, global::AllFeatures.CodeplugGuid.b("迋ꃍꛏ苑뇓ꓕ鯗뗙닛꣝藟賡郣迥蟧蓩跫苭돯髱闳飵雷鿹郻뇽烿瘁洃椅昇礉堋伍吏䈑堓唕眗縙礛䄝感ᬡᘣጥḧ", a_), global::CommonResources.AcgResources.ID_DIRECTDPLCODE, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerConventionalChannelOptionsTADPLCode_A9256LovStrs);
					this.cnvPerConventionalChannelOptionsTADPLCode_A9256.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvPerConventionalChannelOptionsTADPLCode_A9256.DataTransferOrder = 124;
					num = (short)553975904;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 23:
					goto IL_638;
				case 24:
					goto IL_16BF;
				case 25:
					goto IL_2E8;
				case 26:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("迋ꃍꛏ苑뇓ꓕ鯗뗙닛꣝藟賡郣迥蟧蓩跫苭돯髱闳飵雷鿹郻뇽烿瘁洃椅昇礉堋伍䀏帑刓搕紗欙䌛弝᤟အሣሥ", a_)))
					{
						num = (short)1133051968;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_B86;
				case 27:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("迋ꃍꛏ苑뇓ꓕ鯗뗙닛꣝藟賡郣迥蟧蓩跫苭돯髱闳飵雷鿹郻뇽烿瘁洃椅昇礉堋瘍帏眑怓愕眗栙眛圝搟紡攣ἥᴧἩᰫ", a_)))
					{
						num = (short)862126100;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2E8;
				case 28:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("迋ꃍꛏ苑뇓ꓕ鯗뗙닛꣝藟賡郣迥蟧蓩跫苭돯髱闳飵雷鿹郻뇽烿瘁洃椅昇礉帋瘍吏䈑堓唕眗縙礛䄝感ᨡᴣᘥဧ", a_)))
					{
						num = (short)658440223;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_684;
				case 29:
					this.cnvPerConventionalChannelOptionsTxDevChanSpacing_A23192 = new global::AcpBusinessLayer.AcpSparseLOVField(25634, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.indexCnvPerConventionalChannelOptionsTxDevChanSpacing_A23192LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.idCnvPerConventionalChannelOptionsTxDevChanSpacing_A23192LovStrs), this, global::AllFeatures.CodeplugGuid.b("迋ꃍꛏ苑뇓ꓕ鯗뗙닛꣝藟賡郣迥蟧蓩跫苭돯髱闳飵雷鿹郻뇽烿瘁洃椅昇礉堋瘍吏眑戓唕瀗笙爛䴝借䌡䜣伥䘧䴩猫漭ȯıԳ༵਷", a_), global::CommonResources.AcgResources.ID_TXDEVIATIONCHANNELSPACING, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerConventionalChannelOptionsTxDevChanSpacing_A23192LovStrs);
					this.cnvPerConventionalChannelOptionsTxDevChanSpacing_A23192.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.cnvPerConventionalChannelOptionsTxDevChanSpacing_A23192.DataTransferOrder = 58;
					this.cnvPerConventionalChannelOptionsTxDevChanSpacing_A23192.ValidateAcrossRecset = true;
					num = (short)1685913689;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 30:
					this.cnvPerConventionalChannelOptionsTxSquelchType_A9426 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.indexCnvPerConventionalChannelOptionsTxSquelchType_A9426LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.idCnvPerConventionalChannelOptionsTxSquelchType_A9426LovStrs), this, global::AllFeatures.CodeplugGuid.b("迋ꃍꛏ苑뇓ꓕ鯗뗙닛꣝藟賡郣迥蟧蓩跫苭돯髱闳飵雷鿹郻뇽烿瘁洃椅昇礉堋瘍䌏挑愓猕琗礙琛䨝够刡䄣礥椧ጩᠫᰭد", a_), global::CommonResources.AcgResources.ID_TXSQUELCHTYPE, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerConventionalChannelOptionsTxSquelchType_A9426LovStrs);
					this.cnvPerConventionalChannelOptionsTxSquelchType_A9426.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.cnvPerConventionalChannelOptionsTxSquelchType_A9426.DataTransferOrder = 14;
					this.cnvPerConventionalChannelOptionsTxSquelchType_A9426.ValidateAcrossRecset = true;
					num = (short)1320091732;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 31:
					this.cnvPerConventionalChannelOptionsRxDPLCode_A8908 = new global::AcpBusinessLayer.AcpSparseLOVField(1, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.indexCnvPerConventionalChannelOptionsRxDPLCode_A8908LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.idCnvPerConventionalChannelOptionsRxDPLCode_A8908LovStrs), this, global::AllFeatures.CodeplugGuid.b("迋ꃍꛏ苑뇓ꓕ鯗뗙닛꣝藟賡郣迥蟧蓩跫苭돯髱闳飵雷鿹郻뇽烿瘁洃椅昇礉帋瘍吏䈑堓唕眗縙礛䄝感ᨡᴣᘥဧ", a_), global::CommonResources.AcgResources.ID_RXTADPLCODE, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerConventionalChannelOptionsRxDPLCode_A8908LovStrs);
					this.cnvPerConventionalChannelOptionsRxDPLCode_A8908.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.cnvPerConventionalChannelOptionsRxDPLCode_A8908.DataTransferOrder = 28;
					this.cnvPerConventionalChannelOptionsRxDPLCode_A8908.ValidateAcrossRecset = true;
					num = (short)1299644493;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 32:
					this.cnvPerConventionalChannelOptionsPLDeviation_A8708 = new global::AcpBusinessLayer.AcpSparseLOVField(2, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.indexCnvPerConventionalChannelOptionsPLDeviation_A8708LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.idCnvPerConventionalChannelOptionsPLDeviation_A8708LovStrs), this, global::AllFeatures.CodeplugGuid.b("迋ꃍꛏ苑뇓ꓕ鯗뗙닛꣝藟賡郣迥蟧蓩跫苭돯髱闳飵雷鿹郻뇽烿瘁洃椅昇礉尋䈍吏眑戓缕礗渙甛焝丟紡攣ḥἧᨩᐫ", a_), global::CommonResources.AcgResources.ID_PLDEVIATION, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerConventionalChannelOptionsPLDeviation_A8708LovStrs);
					this.cnvPerConventionalChannelOptionsPLDeviation_A8708.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.cnvPerConventionalChannelOptionsPLDeviation_A8708.DataTransferOrder = 87;
					num = (short)434438159;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 33:
					switch (0)
					{
					case 0:
						goto IL_1B1;
					}
					continue;
				case 34:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("迋ꃍꛏ苑뇓ꓕ鯗뗙닛꣝藟賡郣迥蟧蓩跫苭돯髱闳飵雷鿹郻뇽烿瘁洃椅昇礉堋伍䌏挑愓猕琗礙琛䨝够刡䄣礥椧ጩḫᠭԯ", a_)))
					{
						num = (short)1597308931;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_24E;
				case 35:
					this.cnvPerConventionalChannelOptionsItinerantChannelFrequency_A8359 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("迋ꃍꛏ苑뇓ꓕ鯗뗙닛꣝藟賡郣迥蟧蓩跫苭돯髱闳飵雷鿹郻뇽烿瘁洃椅昇礉䔋稍礏簑焓搕礗琙栛崝䠟䌡䨣䠥䴧䘩樫尭唯䌱䄳匵嘷夹䔻愽Ŀ穁睃獅煇", a_), global::CommonResources.AcgResources.ID_ITINERANTCHANNELFREQUENCY);
					this.cnvPerConventionalChannelOptionsItinerantChannelFrequency_A8359.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.cnvPerConventionalChannelOptionsItinerantChannelFrequency_A8359.DataTransferOrder = -1;
					num = (short)1262223438;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 36:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("迋ꃍꛏ苑뇓ꓕ鯗뗙닛꣝藟賡郣迥蟧蓩跫苭돯髱闳飵雷鿹郻뇽烿瘁洃椅昇礉堋伍帏眑怓愕眗栙眛圝搟紡攣ᄥဧᰩἫ", a_)))
					{
						num = (short)931528741;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1818;
				case 37:
					this.cnvPerConventionalChannelOptionsTANetworkID_A7863 = new global::AcpBusinessLayer.AcpSimpleRangeField(659, this, global::AllFeatures.CodeplugGuid.b("迋ꃍꛏ苑뇓ꓕ鯗뗙닛꣝藟賡郣迥蟧蓩跫苭돯髱闳飵雷鿹郻뇽烿瘁洃椅昇礉堋伍帏眑怓愕眗栙眛圝搟紡攣ᄥဧᰩἫ", a_), global::CommonResources.AcgResources.ID_DIRECTNETWORKID, null, null, 0, 1);
					this.cnvPerConventionalChannelOptionsTANetworkID_A7863.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvPerConventionalChannelOptionsTANetworkID_A7863.DataTransferOrder = 114;
					this.cnvPerConventionalChannelOptionsTANetworkID_A7863.ShowHexValue = true;
					num = (short)60620807;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 38:
					this.cnvPerConventionalChannelOptionsTxFrequency_A9414 = new global::AcpBusinessLayer.AcpFrequencyField(161202500, this, global::AllFeatures.CodeplugGuid.b("迋ꃍꛏ苑뇓ꓕ鯗뗙닛꣝藟賡郣迥蟧蓩跫苭돯髱闳飵雷鿹郻뇽烿瘁洃椅昇礉堋瘍嘏怑焓朕洗缙爛紝够紡攣ἥᰧᬩᠫ", a_), global::CommonResources.AcgResources.ID_TXFREQUENCYMHZ);
					this.cnvPerConventionalChannelOptionsTxFrequency_A9414.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.cnvPerConventionalChannelOptionsTxFrequency_A9414.DataTransferOrder = 22;
					this.cnvPerConventionalChannelOptionsTxFrequency_A9414.ValidateAcrossRecset = true;
					num = (short)1517813784;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 39:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("迋ꃍꛏ苑뇓ꓕ鯗뗙닛꣝藟賡郣迥蟧蓩跫苭돯髱闳飵雷鿹郻뇽烿瘁洃椅昇礉䜋欍椏紑爓唕眗琙樛笝丟嘡䴣䤥䘧䬩䀫洭堯匱娳堵崷嘹猻丽㐿⭁⭃⡅㭇ᕉോ籍恏救恓捕", a_)))
					{
						num = (short)302776399;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3E9;
				case 40:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("迋ꃍꛏ苑뇓ꓕ鯗뗙닛꣝藟賡郣迥蟧蓩跫苭돯髱闳飵雷鿹郻뇽烿瘁洃椅昇礉帋瘍䀏帑圓礕簗缙䌛弝᠟ᬡᔣᄥ", a_)))
					{
						num = (short)986447952;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4C4;
				case 41:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("迋ꃍꛏ苑뇓ꓕ鯗뗙닛꣝藟賡郣迥蟧蓩跫苭돯髱闳飵雷鿹郻뇽烿瘁洃椅昇礉䔋稍礏簑焓搕礗琙栛崝䠟䌡䨣䠥䴧䘩樫尭唯䌱䄳匵嘷夹䔻愽Ŀ穁睃獅煇", a_)))
					{
						num = (short)2039349283;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_14A1;
				case 42:
					this.cnvPerConventionalChannelOptionsTxDPLCode_A9409 = new global::AcpBusinessLayer.AcpSparseLOVField(1, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.indexCnvPerConventionalChannelOptionsTxDPLCode_A9409LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.idCnvPerConventionalChannelOptionsTxDPLCode_A9409LovStrs), this, global::AllFeatures.CodeplugGuid.b("迋ꃍꛏ苑뇓ꓕ鯗뗙닛꣝藟賡郣迥蟧蓩跫苭돯髱闳飵雷鿹郻뇽烿瘁洃椅昇礉堋瘍吏䈑堓唕眗縙礛䄝感ᬡဣᘥᄧ", a_), global::CommonResources.AcgResources.ID_TXDPLCODE, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerConventionalChannelOptionsTxDPLCode_A9409LovStrs);
					this.cnvPerConventionalChannelOptionsTxDPLCode_A9409.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.cnvPerConventionalChannelOptionsTxDPLCode_A9409.DataTransferOrder = 15;
					this.cnvPerConventionalChannelOptionsTxDPLCode_A9409.ValidateAcrossRecset = true;
					num = (short)1302134845;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 43:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("迋ꃍꛏ苑뇓ꓕ鯗뗙닛꣝藟賡郣迥蟧蓩跫苭돯髱闳飵雷鿹郻뇽烿瘁洃椅昇礉帋瘍嘏怑焓朕洗缙爛紝够紡攣ḥᄧᬩᴫ", a_)))
					{
						num = (short)465829947;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_29B;
				case 44:
					goto IL_14EF;
				case 45:
					goto IL_B86;
				case 46:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("迋ꃍꛏ苑뇓ꓕ鯗뗙닛꣝藟賡郣迥蟧蓩跫苭돯髱闳飵雷鿹郻뇽烿瘁洃椅昇礉堋瘍吏䈑堓引瘗氙礛氝吟紡攣ἥᰧᬩᰫ", a_)))
					{
						num = (short)1432027229;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_10CF;
				case 47:
					this.cnvPerConventionalChannelOptionsUserSelectablePLMPL_A9606 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("迋ꃍꛏ苑뇓ꓕ鯗뗙닛꣝藟賡郣迥蟧蓩跫苭돯髱闳飵雷鿹郻뇽烿瘁洃椅昇礉夋納甏怑䜓猕琗缙缛樝䄟䀡䠣䌥砧昩愫縭簯洱申༵ืਹ਻", a_), global::CommonResources.AcgResources.ID_USERSELECTABLEPLMPL);
					this.cnvPerConventionalChannelOptionsUserSelectablePLMPL_A9606.IgnoreOnCompare = true;
					this.cnvPerConventionalChannelOptionsUserSelectablePLMPL_A9606.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvPerConventionalChannelOptionsUserSelectablePLMPL_A9606.DataTransferOrder = 13;
					num = (short)1639841877;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 48:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("迋ꃍꛏ苑뇓ꓕ鯗뗙닛꣝藟賡郣迥蟧蓩跫苭돯髱闳飵雷鿹郻뇽烿瘁洃椅昇礉堋瘍嘏怑焓朕洗缙爛紝够紡攣ἥᰧᬩᠫ", a_)))
					{
						num = (short)180682790;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_16BF;
				case 49:
					this.cnvPerConventionalChannelOptionsTalkaround_A19837 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("迋ꃍꛏ苑뇓ꓕ鯗뗙닛꣝藟賡郣迥蟧蓩跫苭돯髱闳飵雷鿹郻뇽烿瘁洃椅昇礉堋漍簏礑甓搕眗漙爛稝缟挡ᔣἥဧᤩᬫ", a_), global::CommonResources.AcgResources.ID_TALKAROUND);
					this.cnvPerConventionalChannelOptionsTalkaround_A19837.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.cnvPerConventionalChannelOptionsTalkaround_A19837.DataTransferOrder = -1;
					num = (short)38076467;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 50:
					goto IL_ACB;
				case 51:
					goto IL_510;
				case 52:
					this.cnvPerConventionalChannelOptionsTxPLCode_A9418 = new global::AcpBusinessLayer.AcpSparseLOVField(1, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.indexCnvPerConventionalChannelOptionsTxPLCode_A9418LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.idCnvPerConventionalChannelOptionsTxPLCode_A9418LovStrs), this, global::AllFeatures.CodeplugGuid.b("迋ꃍꛏ苑뇓ꓕ鯗뗙닛꣝藟賡郣迥蟧蓩跫苭돯髱闳飵雷鿹郻뇽烿瘁洃椅昇礉堋瘍䀏帑圓礕簗缙䌛弝᤟ᘡᔣḥ", a_), global::CommonResources.AcgResources.ID_TXPLCODE, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerConventionalChannelOptionsTxPLCode_A9418LovStrs);
					this.cnvPerConventionalChannelOptionsTxPLCode_A9418.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.cnvPerConventionalChannelOptionsTxPLCode_A9418.DataTransferOrder = 24;
					this.cnvPerConventionalChannelOptionsTxPLCode_A9418.ValidateAcrossRecset = true;
					num = (short)826540076;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 53:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("迋ꃍꛏ苑뇓ꓕ鯗뗙닛꣝藟賡郣迥蟧蓩跫苭돯髱闳飵雷鿹郻뇽烿瘁洃椅昇礉䴋崍䐏䀑嬓䈕礗瘙眛礝刟䴡儣嘥愧温猫漭य1ళܵ", a_)))
					{
						num = (short)1397293124;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1455;
				case 54:
					num = (short)676200459;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 55:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("迋ꃍꛏ苑뇓ꓕ鯗뗙닛꣝藟賡郣迥蟧蓩跫苭돯髱闳飵雷鿹郻뇽烿瘁洃椅昇礉夋納甏怑䜓猕琗缙缛樝䄟䀡䠣䌥砧昩愫縭簯洱申༵ืਹ਻", a_)))
					{
						num = (short)548470831;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1178;
				case 56:
					this.cnvPerConventionalChannelOptionsTxPLFreq_A9419 = new global::AcpBusinessLayer.AcpSparseLOVField(1, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.indexCnvPerConventionalChannelOptionsTxPLFreq_A9419LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.idCnvPerConventionalChannelOptionsTxPLFreq_A9419LovStrs), this, global::AllFeatures.CodeplugGuid.b("迋ꃍꛏ苑뇓ꓕ鯗뗙닛꣝藟賡郣迥蟧蓩跫苭돯髱闳飵雷鿹郻뇽烿瘁洃椅昇礉堋瘍䀏帑刓搕紗欙䌛弝᤟ᘡᔣἥ", a_), global::CommonResources.AcgResources.ID_TXPLFREQ, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerConventionalChannelOptionsTxPLFreq_A9419LovStrs);
					this.cnvPerConventionalChannelOptionsTxPLFreq_A9419.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.cnvPerConventionalChannelOptionsTxPLFreq_A9419.DataTransferOrder = 25;
					this.cnvPerConventionalChannelOptionsTxPLFreq_A9419.ValidateAcrossRecset = true;
					num = (short)526254096;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 57:
					this.cnvPerConventionalChannelOptionsTAPLCode_A9261 = new global::AcpBusinessLayer.AcpSparseLOVField(1, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.indexCnvPerConventionalChannelOptionsTAPLCode_A9261LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.idCnvPerConventionalChannelOptionsTAPLCode_A9261LovStrs), this, global::AllFeatures.CodeplugGuid.b("迋ꃍꛏ苑뇓ꓕ鯗뗙닛꣝藟賡郣迥蟧蓩跫苭돯髱闳飵雷鿹郻뇽烿瘁洃椅昇礉堋伍䀏帑圓礕簗缙䌛弝᤟အሣᜥ", a_), global::CommonResources.AcgResources.ID_DIRECTPLCODE, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerConventionalChannelOptionsTAPLCode_A9261LovStrs);
					this.cnvPerConventionalChannelOptionsTAPLCode_A9261.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvPerConventionalChannelOptionsTAPLCode_A9261.DataTransferOrder = 40;
					num = (short)110755850;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 58:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("迋ꃍꛏ苑뇓ꓕ鯗뗙닛꣝藟賡郣迥蟧蓩跫苭돯髱闳飵雷鿹郻뇽烿瘁洃椅昇礉尋䈍吏眑戓缕礗渙甛焝丟紡攣ḥἧᨩᐫ", a_)))
					{
						num = (short)1794768928;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_335;
				case 59:
					this.cnvPerConventionalChannelOptionsRxFrequency_A8911 = new global::AcpBusinessLayer.AcpFrequencyField(170212500, this, global::AllFeatures.CodeplugGuid.b("迋ꃍꛏ苑뇓ꓕ鯗뗙닛꣝藟賡郣迥蟧蓩跫苭돯髱闳飵雷鿹郻뇽烿瘁洃椅昇礉帋瘍嘏怑焓朕洗缙爛紝够紡攣ḥᄧᬩᴫ", a_), global::CommonResources.AcgResources.ID_RXTAFREQUENCYMHZ);
					this.cnvPerConventionalChannelOptionsRxFrequency_A8911.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.cnvPerConventionalChannelOptionsRxFrequency_A8911.DataTransferOrder = 12;
					num = (short)1643642881;
					if (num != 0)
					{
					}
					num = (short)480444487;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 60:
					goto IL_24E;
				case 61:
					goto IL_8C6;
				case 62:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("迋ꃍꛏ苑뇓ꓕ鯗뗙닛꣝藟賡郣迥蟧蓩跫苭돯髱闳飵雷鿹郻뇽烿瘁洃椅昇礉䠋服戏眑眓戕䰗笙瀛甝䄟倡䬣匥䘧丩猫漭य1ĳ̵", a_)))
					{
						num = (short)1107820556;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_C89;
				case 63:
					goto IL_1608;
				case 64:
					this.cnvPerConventionalChannelOptionsTAPLFreq_A9264 = new global::AcpBusinessLayer.AcpSparseLOVField(1, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.indexCnvPerConventionalChannelOptionsTAPLFreq_A9264LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.idCnvPerConventionalChannelOptionsTAPLFreq_A9264LovStrs), this, global::AllFeatures.CodeplugGuid.b("迋ꃍꛏ苑뇓ꓕ鯗뗙닛꣝藟賡郣迥蟧蓩跫苭돯髱闳飵雷鿹郻뇽烿瘁洃椅昇礉堋伍䀏帑刓搕紗欙䌛弝᤟အሣሥ", a_), global::CommonResources.AcgResources.ID_DIRECTPLFREQ, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerConventionalChannelOptionsTAPLFreq_A9264LovStrs);
					this.cnvPerConventionalChannelOptionsTAPLFreq_A9264.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvPerConventionalChannelOptionsTAPLFreq_A9264.DataTransferOrder = 39;
					num = (short)1065746477;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 65:
					goto IL_55D;
				case 66:
					goto IL_D26;
				case 67:
					goto IL_ECC;
				case 68:
					this.cnvPerConventionalChannelOptionsASTROTalkgroupID_A9281 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("迋ꃍꛏ苑뇓ꓕ鯗뗙닛꣝藟賡郣迥蟧蓩跫苭돯髱闳飵雷鿹郻뇽烿瘁洃椅昇礉䴋崍䐏䀑嬓䈕礗瘙眛礝刟䴡儣嘥愧温猫漭य1ళܵ", a_), global::CommonResources.AcgResources.ID_ASTROTALKGROUPID, new string[]
					{
						global::CommonResources.AcgResources.ID_DYN,
						global::CommonResources.AcgResources.ID_ATG
					}, new int[]
					{
						65535,
						65534
					}, false, true);
					this.cnvPerConventionalChannelOptionsASTROTalkgroupID_A9281.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvPerConventionalChannelOptionsASTROTalkgroupID_A9281.DataTransferOrder = 55;
					this.cnvPerConventionalChannelOptionsASTROTalkgroupID_A9281.EvaluateRecRefs = true;
					num = (short)101384213;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 69:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("迋ꃍꛏ苑뇓ꓕ鯗뗙닛꣝藟賡郣迥蟧蓩跫苭돯髱闳飵雷鿹郻뇽烿瘁洃椅昇礉堋瘍䀏帑刓搕紗欙䌛弝᤟ᘡᔣἥ", a_)))
					{
						num = (short)2137915448;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_CD7;
				case 70:
					goto IL_17BC;
				case 71:
					goto IL_29B;
				case 72:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("迋ꃍꛏ苑뇓ꓕ鯗뗙닛꣝藟賡郣迥蟧蓩跫苭돯髱闳飵雷鿹郻뇽烿瘁洃椅昇礉堋瘍䌏挑愓猕琗礙琛䨝够刡䄣礥椧ጩᠫᰭد", a_)))
					{
						num = (short)1245773854;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_7C5;
				case 73:
					this.cnvPerConventionalChannelOptionsRxPLFreq_A8918 = new global::AcpBusinessLayer.AcpSparseLOVField(1, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.indexCnvPerConventionalChannelOptionsRxPLFreq_A8918LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.idCnvPerConventionalChannelOptionsRxPLFreq_A8918LovStrs), this, global::AllFeatures.CodeplugGuid.b("迋ꃍꛏ苑뇓ꓕ鯗뗙닛꣝藟賡郣迥蟧蓩跫苭돯髱闳飵雷鿹郻뇽烿瘁洃椅昇礉帋瘍䀏帑刓搕紗欙䌛弝᠟ᬡᔣḥ", a_), global::CommonResources.AcgResources.ID_RXTAPLFREQ, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerConventionalChannelOptionsRxPLFreq_A8918LovStrs);
					this.cnvPerConventionalChannelOptionsRxPLFreq_A8918.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.cnvPerConventionalChannelOptionsRxPLFreq_A8918.DataTransferOrder = 27;
					this.cnvPerConventionalChannelOptionsRxPLFreq_A8918.ValidateAcrossRecset = true;
					num = (short)648871986;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 74:
					num = (short)1174208548;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 75:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("迋ꃍꛏ苑뇓ꓕ鯗뗙닛꣝藟賡郣迥蟧蓩跫苭돯髱闳飵雷鿹郻뇽烿瘁洃椅昇礉帋瘍帏眑怓愕眗栙眛圝搟紡攣ἥᠧᠩἫ", a_)))
					{
						num = (short)2011562079;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_ECC;
				case 76:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("迋ꃍꛏ苑뇓ꓕ鯗뗙닛꣝藟賡郣迥蟧蓩跫苭뛯胱藳飵鯷菹돻軽瓿氁眃䬅愇爉娋崍䀏眑易攕焗椙栛笝丟嘡椣䌥䔧䠩䤫尭漯猱ܳี༷࠹਻", a_)))
					{
						num = (short)1797390430;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_55D;
				case 77:
					goto IL_684;
				case 78:
					goto IL_14A1;
				case 79:
					this.cnvPerConventionalChannelOptionsKeyofConventionalChannelOptions_A20745 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("迋ꃍꛏ苑뇓ꓕ鯗뗙닛꣝藟賡郣迥蟧蓩跫苭돯髱闳飵雷鿹郻뇽烿瘁洃椅昇礉䜋欍椏紑爓唕眗琙樛笝丟嘡䴣䤥䘧䬩䀫洭堯匱娳堵崷嘹猻丽㐿⭁⭃⡅㭇ᕉോ籍恏救恓捕", a_), global::CommonResources.AcgResources.ID_NAME, 14);
					this.cnvPerConventionalChannelOptionsKeyofConventionalChannelOptions_A20745.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.cnvPerConventionalChannelOptionsKeyofConventionalChannelOptions_A20745.DataTransferOrder = 70;
					num = (short)1924792326;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 80:
					this.cnvPerConventionalChannelOptionsRxPLCode_A8917 = new global::AcpBusinessLayer.AcpSparseLOVField(1, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.indexCnvPerConventionalChannelOptionsRxPLCode_A8917LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.idCnvPerConventionalChannelOptionsRxPLCode_A8917LovStrs), this, global::AllFeatures.CodeplugGuid.b("迋ꃍꛏ苑뇓ꓕ鯗뗙닛꣝藟賡郣迥蟧蓩跫苭돯髱闳飵雷鿹郻뇽烿瘁洃椅昇礉帋瘍䀏帑圓礕簗缙䌛弝᠟ᬡᔣᄥ", a_), global::CommonResources.AcgResources.ID_RXTAPLCODE_1, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerConventionalChannelOptionsRxPLCode_A8917LovStrs);
					this.cnvPerConventionalChannelOptionsRxPLCode_A8917.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.cnvPerConventionalChannelOptionsRxPLCode_A8917.DataTransferOrder = 26;
					this.cnvPerConventionalChannelOptionsRxPLCode_A8917.ValidateAcrossRecset = true;
					num = (short)811008008;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 81:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("迋ꃍꛏ苑뇓ꓕ鯗뗙닛꣝藟賡郣迥蟧蓩跫苭돯髱闳飵雷鿹郻뇽烿瘁洃椅昇礉堋伍䀏帑圓礕簗缙䌛弝᤟အሣᜥ", a_)))
					{
						num = (short)1327824953;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_C3B;
				case 82:
					goto IL_10CF;
				case 83:
				{
					num = (short)1009254400;
					short num4 = num;
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("迋ꃍꛏ苑뇓ꓕ鯗뗙닛꣝藟賡郣迥蟧蓩跫苭돯髱闳飵雷鿹郻뇽烿瘁洃椅昇礉帋瘍吏䈑堓引瘗氙礛氝吟紡攣ḥᄧᨩᔫ", a_)))
					{
						num = (short)1024852058;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_638;
				}
				case 84:
					goto IL_7C5;
				case 85:
					goto IL_1178;
				case 86:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("迋ꃍꛏ苑뇓ꓕ鯗뗙닛꣝藟賡郣迥蟧蓩跫苭돯髱闳飵雷鿹郻뇽烿瘁洃椅昇礉堋漍簏礑甓搕眗漙爛稝缟挡ᔣἥဧᤩᬫ", a_)))
					{
						num = (short)53739569;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_510;
				case 87:
					goto IL_A7F;
				case 88:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("迋ꃍꛏ苑뇓ꓕ鯗뗙닛꣝藟賡郣迥蟧蓩跫苭돯髱闳飵雷鿹郻뇽烿瘁洃椅昇礉堋伍吏䈑堓唕眗縙礛䄝感ᬡᘣጥḧ", a_)))
					{
						num = (short)1078788118;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_879;
				case 89:
					goto IL_E7F;
				case 90:
					this.cnvPerConventionalChannelOptionsRxDPLInvert_A8909 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("迋ꃍꛏ苑뇓ꓕ鯗뗙닛꣝藟賡郣迥蟧蓩跫苭돯髱闳飵雷鿹郻뇽烿瘁洃椅昇礉帋瘍吏䈑堓引瘗氙礛氝吟紡攣ḥᄧᨩᔫ", a_), global::CommonResources.AcgResources.ID_RXTADPLINVERT);
					this.cnvPerConventionalChannelOptionsRxDPLInvert_A8909.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.cnvPerConventionalChannelOptionsRxDPLInvert_A8909.DataTransferOrder = 29;
					this.cnvPerConventionalChannelOptionsRxDPLInvert_A8909.ValidateAcrossRecset = true;
					num = (short)800915479;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 91:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("迋ꃍꛏ苑뇓ꓕ鯗뗙닛꣝藟賡郣迥蟧蓩跫苭돯髱闳飵雷鿹郻뇽烿瘁洃椅昇礉堋伍吏䈑堓引瘗氙礛氝吟紡攣ἥᨧἩᔫ", a_)))
					{
						num = (short)108134419;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_D26;
				case 92:
					this.cnvPerConventionalChannelOptionsUserSelectablePLMPLEnhance_43029 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.indexCnvPerConventionalChannelOptionsUserSelectablePLMPLEnhance_43029LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.idCnvPerConventionalChannelOptionsUserSelectablePLMPLEnhance_43029LovStrs), this, global::AllFeatures.CodeplugGuid.b("迋ꃍꛏ苑뇓ꓕ鯗뗙닛꣝藟賡郣迥蟧蓩跫苭돯髱闳飵雷鿹郻뇽烿瘁洃椅昇礉夋納甏怑䜓猕琗缙缛樝䄟䀡䠣䌥砧昩愫縭簯眱娳帵夷吹弻嬽Ἷ癁睃癅穇獉", a_), global::CommonResources.AcgResources.ID_USERSELECTABLEPLMPL_1, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerConventionalChannelOptionsUserSelectablePLMPLEnhance_43029LovStrs);
					this.cnvPerConventionalChannelOptionsUserSelectablePLMPLEnhance_43029.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvPerConventionalChannelOptionsUserSelectablePLMPLEnhance_43029.DataTransferOrder = 118;
					num = (short)2108620870;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 93:
					this.cnvPerConventionalChannelOptionsTxDPLInvert_A9410 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("迋ꃍꛏ苑뇓ꓕ鯗뗙닛꣝藟賡郣迥蟧蓩跫苭돯髱闳飵雷鿹郻뇽烿瘁洃椅昇礉堋瘍吏䈑堓引瘗氙礛氝吟紡攣ἥᰧᬩᰫ", a_), global::CommonResources.AcgResources.ID_TXDPLINVERT);
					this.cnvPerConventionalChannelOptionsTxDPLInvert_A9410.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.cnvPerConventionalChannelOptionsTxDPLInvert_A9410.DataTransferOrder = 16;
					this.cnvPerConventionalChannelOptionsTxDPLInvert_A9410.ValidateAcrossRecset = true;
					num = (short)1576796242;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 94:
					this.cnvPerConventionalFrqncyOptnsMixVSPersistentMember_A38726 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("迋ꃍꛏ苑뇓ꓕ鯗뗙닛꣝藟賡郣迥蟧蓩跫苭뛯胱藳飵鯷菹돻軽瓿氁眃䬅愇爉娋崍䀏眑易攕焗椙栛笝丟嘡椣䌥䔧䠩䤫尭漯猱ܳี༷࠹਻", a_), global::CommonResources.AcgResources.ID_MIXEDVOTESCANPERSISTENTMEMBER);
					this.cnvPerConventionalFrqncyOptnsMixVSPersistentMember_A38726.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.cnvPerConventionalFrqncyOptnsMixVSPersistentMember_A38726.DataTransferOrder = 161;
					num = (short)515571777;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 95:
					this.cnvPerConventionalChannelOptionsRxNetworkID_A9023 = new global::AcpBusinessLayer.AcpSimpleRangeField(659, this, global::AllFeatures.CodeplugGuid.b("迋ꃍꛏ苑뇓ꓕ鯗뗙닛꣝藟賡郣迥蟧蓩跫苭돯髱闳飵雷鿹郻뇽烿瘁洃椅昇礉帋瘍帏眑怓愕眗栙眛圝搟紡攣ἥᠧᠩἫ", a_), global::CommonResources.AcgResources.ID_RXTANETWORKID, null, null, 0, 1);
					this.cnvPerConventionalChannelOptionsRxNetworkID_A9023.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.cnvPerConventionalChannelOptionsRxNetworkID_A9023.DataTransferOrder = 35;
					this.cnvPerConventionalChannelOptionsRxNetworkID_A9023.ValidateAcrossRecset = true;
					this.cnvPerConventionalChannelOptionsRxNetworkID_A9023.ShowHexValue = true;
					num = (short)1116340291;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 96:
					goto IL_879;
				}
				IL_1B1:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)226754614;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_24E:
				num = (short)414711861;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_29B:
				num = (short)505282600;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2E8:
				num = (short)669646903;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_335:
				num = (short)1983447068;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3E9:
				num = (short)1016332301;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_4C4:
				num = (short)1523777538;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_510:
				num = (short)733085735;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_55D:
				num = (short)1618214926;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_638:
				num = (short)1038876715;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_684:
				num = (short)631570515;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_7C5:
				num = (short)452001819;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_879:
				num = (short)239206491;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_8C6:
				num = (short)743637038;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_A7F:
				num = (short)2113994827;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_ACB:
				num = (short)842334208;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_B86:
				num = (short)1105788962;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_C3B:
				num = (short)1430323226;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_C89:
				num = (short)1843986520;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_CD7:
				num = (short)1454309448;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_D26:
				num = (short)697761809;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_D56:
				num = (short)904331265;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_E7F:
				num = (short)1366949964;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_ECC:
				num = (short)929431614;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_10CF:
				num = (short)1226440752;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1178:
				num = (short)231014486;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1455:
				num = (short)174784517;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_14A1:
				num = (short)622329914;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_14EF:
				num = (short)508821573;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1608:
				num = (short)1032192081;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_16BF:
				num = (short)246284292;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1818:
				num = (short)1355284521;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_17BC:
			IL_18BE:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("請볍뗏ꏑꇓ돕뛗맙ꗛﻝ꿟鋡郣迥蟧蓩鿫", a_);
			base.Id = 10149;
			base.UIName = global::CommonResources.AcgResources.ID_FREQUENCYOPTIONS;
			base.DataTransferOrder = 1;
		}

		// Token: 0x0600C4C5 RID: 50373 RVA: 0x00B89BD0 File Offset: 0x00B87DD0
		public override void PopulateReferences()
		{
			short num = (short)1098025853;
			short num2 = num;
			num = (short)1820953469;
			switch (num2 == num)
			{
			}
			num = (short)318570496;
			short num3 = num;
			num = (short)1183252481;
			if (num != 0)
			{
			}
			num = (short)2110652416;
			if (num != 0)
			{
			}
			((global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality)base.ParentRecset.ParentSection.Parent).ASTROTalkgroup.CnvPerASTROTalkgroupOptionsTalkgroupList_A9283.AddSlaveField(this.cnvPerConventionalChannelOptionsASTROTalkgroupID_A9281, 10152);
		}

		// Token: 0x0600C4C6 RID: 50374 RVA: 0x00B89CA8 File Offset: 0x00B87EA8
		public override void DropReferences()
		{
			short num = (short)272005100;
			short num2 = num;
			num = (short)768309228;
			switch (num2 == num)
			{
			}
			num = (short)1603731456;
			short num3 = num;
			num = (short)523501568;
			if (num != 0)
			{
			}
			num = (short)142016513;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600C4C7 RID: 50375 RVA: 0x00B89D50 File Offset: 0x00B87F50
		public override void SetConstraints()
		{
			short num = (short)1515578930;
			short num2 = num;
			num = (short)393078322;
			switch (num2 == num)
			{
			}
			num = (short)916848640;
			short num3 = num;
			num = (short)1317339136;
			if (num != 0)
			{
			}
			num = (short)1376714753;
			if (num != 0)
			{
			}
			this.cnvPerConventionalChannelOptionsTANetworkID_A7863.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.conDirectFrequencyEnabledAndDirectTalkaroundEnabledAndIsNotNonAstro);
			this.cnvPerConventionalChannelOptionsTANetworkID_A7863.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConDirectNetworkIDNotEqual0xF7E);
			this.cnvPerConventionalChannelOptionsTANetworkID_A7863.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.conIsDirectFreqEn);
			this.cnvPerConventionalChannelOptionsItinerantChannelFrequency_A8359.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.visconIs700800MHzEnAndAllowInvFreqEn);
			this.cnvPerConventionalChannelOptionsItinerantChannelFrequency_A8359.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.cnvPerConventionalChannelOptionsPLDeviation_A8708.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.conReceiveOnlyIsDisabledAndTxSquelchTypeNotDisabled);
			this.cnvPerConventionalChannelOptionsRxDPLCode_A8908.ValidateAcrossRecset = true;
			this.cnvPerConventionalChannelOptionsRxDPLCode_A8908.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConRxTASquelchTypeIsDPLAndUsrSelPlDisable);
			this.cnvPerConventionalChannelOptionsRxDPLCode_A8908.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConIsRxTADPLCodeValid);
			this.cnvPerConventionalChannelOptionsRxDPLInvert_A8909.ValidateAcrossRecset = true;
			this.cnvPerConventionalChannelOptionsRxDPLInvert_A8909.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConRxTASquelchTypeIsDPLAndUsrSelPlDisable);
			this.cnvPerConventionalChannelOptionsRxDPLInvert_A8909.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConIsRxTADPLInvertValid);
			this.cnvPerConventionalChannelOptionsRxFrequency_A8911.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.conCnvRxFreqIsValid);
			this.cnvPerConventionalChannelOptionsRxPLCode_A8917.ValidateAcrossRecset = true;
			this.cnvPerConventionalChannelOptionsRxPLCode_A8917.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConRxTASquelchTypeIsPLAndZnChanAssignUsrSelPlIsDisable);
			this.cnvPerConventionalChannelOptionsRxPLCode_A8917.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConIsRxTAPLCodeValid);
			this.cnvPerConventionalChannelOptionsRxPLCode_A8917.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConRxTASquelchTypeIsPLAndZnChanAssignUsrSelPlIsDisableEdit);
			this.cnvPerConventionalChannelOptionsRxPLCode_A8917.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConSyncPlFreqAndPlCodeForCnvRxPlFreq);
			this.cnvPerConventionalChannelOptionsRxPLFreq_A8918.ValidateAcrossRecset = true;
			this.cnvPerConventionalChannelOptionsRxPLFreq_A8918.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConRxTASquelchTypeIsPLAndZnChanAssignUsrSelPlIsDisable);
			this.cnvPerConventionalChannelOptionsRxPLFreq_A8918.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConIsRxTAPLFreqValid);
			this.cnvPerConventionalChannelOptionsRxPLFreq_A8918.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConRxTASquelchTypeIsPLAndZnChanAssignUsrSelPlIsDisableEdit);
			this.cnvPerConventionalChannelOptionsRxPLFreq_A8918.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConSyncPlFreqAndPlCodeForCnvRxTAPlCode);
			this.cnvPerConventionalChannelOptionsRxSquelchType_A8919.ValidateAcrossRecset = true;
			this.cnvPerConventionalChannelOptionsRxSquelchType_A8919.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConZnChanAssignUsrSelPlIsDisableAndRxSigTypeIsNotAstro);
			this.cnvPerConventionalChannelOptionsRxSquelchType_A8919.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConIsRxTASquelchTypeValid);
			this.cnvPerConventionalChannelOptionsRxNetworkID_A9023.ValidateAcrossRecset = true;
			this.cnvPerConventionalChannelOptionsRxNetworkID_A9023.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConCnvPerRxSigTypeNonASTRO);
			this.cnvPerConventionalChannelOptionsRxNetworkID_A9023.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.conIsRxTANetworkIDValid);
			this.cnvPerConventionalChannelOptionsDirectTalkaround_A9255.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConConvUserSelectableDefDirCheckAndZnChanPersTypeCnv);
			this.cnvPerConventionalChannelOptionsDirectTalkaround_A9255.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConConvUserSelectableDefDirCheckAndZnChanPersTypeCnvEditbl);
			this.cnvPerConventionalChannelOptionsTADPLCode_A9256.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.conDirectFrequencyEnabledAndDirectTalkaroundEnabledAndIsNotAstroAndDirectSquelchTypeIsDPL);
			this.cnvPerConventionalChannelOptionsTADPLCode_A9256.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.conIsDirectFreqEn);
			this.cnvPerConventionalChannelOptionsTADPLInvert_A9259.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.conDirectFrequencyEnabledAndDirectTalkaroundEnabledAndIsNotAstroAndDirectSquelchTypeIsDPL);
			this.cnvPerConventionalChannelOptionsTADPLInvert_A9259.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.conIsDirectFreqEn);
			this.cnvPerConventionalChannelOptionsTAFrequency_A9260.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.conDirectFrequencyEnabledAndDirectTalkaroundEnabled);
			this.cnvPerConventionalChannelOptionsTAFrequency_A9260.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConCnvTATxFreqIsValid);
			this.cnvPerConventionalChannelOptionsTAFrequency_A9260.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.conIsDirectFreqEnAndMPLDisabled);
			this.cnvPerConventionalChannelOptionsTAPLCode_A9261.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.conDirectFrequencyEnabledAndDirectTalkaroundEnabledAndIsNotAstroAndDirectSquelchTypeIsPL);
			this.cnvPerConventionalChannelOptionsTAPLCode_A9261.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.conIsDirectFreqEn);
			this.cnvPerConventionalChannelOptionsTAPLCode_A9261.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.conDirectFrequencyEnabledAndDirectTalkaroundEnabledAndIsNotAstroAndDirectSquelchTypeIsPLEditbl);
			this.cnvPerConventionalChannelOptionsTAPLCode_A9261.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.conSetDirectPlFreqBasedOnDirectPlCode);
			this.cnvPerConventionalChannelOptionsTAPLFreq_A9264.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.conDirectFrequencyEnabledAndDirectTalkaroundEnabledAndIsNotAstroAndDirectSquelchTypeIsPL);
			this.cnvPerConventionalChannelOptionsTAPLFreq_A9264.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.conIsDirectFreqEn);
			this.cnvPerConventionalChannelOptionsTAPLFreq_A9264.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.conDirectFrequencyEnabledAndDirectTalkaroundEnabledAndIsNotAstroAndDirectSquelchTypeIsPLEditbl);
			this.cnvPerConventionalChannelOptionsTAPLFreq_A9264.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.conSetDirectPlCodeBasedOnDirectPlFreq);
			this.cnvPerConventionalChannelOptionsTASquelchType_A9265.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.conDirectFrequencyEnabledAndDirectTalkaroundEnabledAndIsNotAstro);
			this.cnvPerConventionalChannelOptionsTASquelchType_A9265.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.conIsDirectFreqEn);
			this.cnvPerConventionalChannelOptionsASTROTalkgroupID_A9281.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConAstroRxSigEnabledAndCnvTlkGrpEnIsEnabled);
			this.cnvPerConventionalChannelOptionsASTROTalkgroupID_A9281.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConIsAstroTalkgrpIdValid);
			this.cnvPerConventionalChannelOptionsASTROTalkgroupID_A9281.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConCnvPerFreqOptionEditabilityByZoneClone);
			this.cnvPerConventionalChannelOptionsTxDPLCode_A9409.ValidateAcrossRecset = true;
			this.cnvPerConventionalChannelOptionsTxDPLCode_A9409.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConReceiveOnlyIsDisabledAndTxSquelchTypeIsDPLAndUseSelPlDisabled);
			this.cnvPerConventionalChannelOptionsTxDPLCode_A9409.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConTxDPLCodeValidity);
			this.cnvPerConventionalChannelOptionsTxDPLInvert_A9410.ValidateAcrossRecset = true;
			this.cnvPerConventionalChannelOptionsTxDPLInvert_A9410.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConReceiveOnlyIsDisabledAndTxSquelchTypeIsDPLAndUseSelPlDisabled);
			this.cnvPerConventionalChannelOptionsTxDPLInvert_A9410.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConTxDPLInvertValidity);
			this.cnvPerConventionalChannelOptionsTxFrequency_A9414.ValidateAcrossRecset = true;
			this.cnvPerConventionalChannelOptionsTxFrequency_A9414.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.conReceiveOnlyIsDisabled);
			this.cnvPerConventionalChannelOptionsTxFrequency_A9414.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConCnvTxFreqIsValid);
			this.cnvPerConventionalChannelOptionsTxPLCode_A9418.ValidateAcrossRecset = true;
			this.cnvPerConventionalChannelOptionsTxPLCode_A9418.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConTxSqueTypeIsPLAndRxOnlyPerDisabledAndUseSelPLDisabled);
			this.cnvPerConventionalChannelOptionsTxPLCode_A9418.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConTxPLCodeValidity);
			this.cnvPerConventionalChannelOptionsTxPLCode_A9418.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConTxSqueTypeIsPLAndRxOnlyPerDisabledAndUseSelPLDisabledEditbl);
			this.cnvPerConventionalChannelOptionsTxPLCode_A9418.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConSyncPlFreqAndPlCodeForCnvTxFreq);
			this.cnvPerConventionalChannelOptionsTxPLFreq_A9419.ValidateAcrossRecset = true;
			this.cnvPerConventionalChannelOptionsTxPLFreq_A9419.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConTxSqueTypeIsPLAndRxOnlyPerDisabledAndUseSelPLDisabled);
			this.cnvPerConventionalChannelOptionsTxPLFreq_A9419.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConTxPLFreqValidity);
			this.cnvPerConventionalChannelOptionsTxPLFreq_A9419.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConTxSqueTypeIsPLAndRxOnlyPerDisabledAndUseSelPLDisabledEditbl);
			this.cnvPerConventionalChannelOptionsTxPLFreq_A9419.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConSyncPlFreqAndPlCodeForCnvTxPLCode);
			this.cnvPerConventionalChannelOptionsTxSquelchType_A9426.ValidateAcrossRecset = true;
			this.cnvPerConventionalChannelOptionsTxSquelchType_A9426.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConConvRxOnlyDisabledAndUsrSelPlIsDisableAndRxSigTypeIsNotAstro);
			this.cnvPerConventionalChannelOptionsTxSquelchType_A9426.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConTxSquelchTypeValidity);
			this.cnvPerConventionalChannelOptionsTxNetworkID_A9550.ValidateAcrossRecset = true;
			this.cnvPerConventionalChannelOptionsTxNetworkID_A9550.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConCnvPerRxSigTypeNonASTRO);
			this.cnvPerConventionalChannelOptionsTxNetworkID_A9550.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConTxNetworkIDNotEqual0xF7E);
			this.cnvPerConventionalChannelOptionsUserSelectablePLMPL_A9606.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.conRxSigTypeIsNotAstro);
			this.cnvPerConventionalChannelOptionsUserSelectablePLMPL_A9606.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.conReturnFalse);
			this.cnvPerConventionalChannelOptionsTalkaround_A19837.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.cnvPerConventionalChannelOptionsTxDevChanSpacing_A23192.ValidateAcrossRecset = true;
			this.cnvPerConventionalChannelOptionsTxDevChanSpacing_A23192.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.conReceiveOnlyIsDisabled);
			this.cnvPerConventionalChannelOptionsTxDevChanSpacing_A23192.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConIsTxDeviationChannelSpacingValid);
			this.cnvPerConventionalChannelOptionsTxDevChanSpacing_A23192.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConIsTxDeviationChannelSpacingEditible);
			this.cnvPerConventionalFrqncyOptnsMixVSPersistentMember_A38726.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConMixedVoteScanEnabled);
			this.cnvPerConventionalChannelOptionsUserSelectablePLMPLEnhance_43029.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.conRxSigTypeIsNotAstro);
			this.cnvPerConventionalChannelOptionsUserSelectablePLMPLEnhance_43029.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.conIsNewUserSelectablePLMPLValid);
			this.cnvPerConventionalChannelOptionsUserSelectablePLMPLEnhance_43029.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConSynNewUserSelectablePLToOld);
		}

		// Token: 0x0600C4C8 RID: 50376 RVA: 0x00B8A530 File Offset: 0x00B88730
		public override void SetupDependencies()
		{
			short num = (short)1532451522;
			short num2 = num;
			num = (short)356997826;
			switch (num2 == num)
			{
			}
			num = (short)1485766656;
			short num3 = num;
			num = (short)1862008833;
			if (num != 0)
			{
			}
			num = (short)1849819136;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality = base.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality;
			this.RefConventionalWide.General.CnvWideGeneralDirectFrequency_A7860.AddDependentObject(this.cnvPerConventionalChannelOptionsTANetworkID_A7863);
			this.cnvPerConventionalChannelOptionsDirectTalkaround_A9255.AddDependentObject(this.cnvPerConventionalChannelOptionsTANetworkID_A7863);
			conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.AddDependentObject(this.cnvPerConventionalChannelOptionsTANetworkID_A7863);
			conventionalPersonality.RxOptions.CnvPerRxOptionsReceiveOnlyPersonality_A8916.AddDependentObject(this.cnvPerConventionalChannelOptionsTANetworkID_A7863);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesAllowInvalidFrequencies_A12493.AddDependentObject(this.cnvPerConventionalChannelOptionsItinerantChannelFrequency_A8359);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRanges7800MHzUsedinCodeplug_A8512.AddDependentObject(this.cnvPerConventionalChannelOptionsItinerantChannelFrequency_A8359);
			this.RefRadioInformation.Labtool.RadInfoLabtoolPrimaryBands_A23987.AddDependentObject(this.cnvPerConventionalChannelOptionsItinerantChannelFrequency_A8359);
			this.RefRadioInformation.Labtool.RadInfoLabtoolSecondaryBands_A23988.AddDependentObject(this.cnvPerConventionalChannelOptionsItinerantChannelFrequency_A8359);
			this.RefRadioInformation.Labtool.RadInfoLabtoolDualBandEnable_A23986.AddDependentObject(this.cnvPerConventionalChannelOptionsItinerantChannelFrequency_A8359);
			this.RefRadioInformation.General.RadInfoGeneralPrimaryFrequencyBand700_A42543.AddDependentObject(this.cnvPerConventionalChannelOptionsItinerantChannelFrequency_A8359);
			this.RefRadioInformation.General.RadInfoGeneralPrimaryFrequencyBand800_A42544.AddDependentObject(this.cnvPerConventionalChannelOptionsItinerantChannelFrequency_A8359);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRanges700MHzUsedinCodeplug_A42551.AddDependentObject(this.cnvPerConventionalChannelOptionsItinerantChannelFrequency_A8359);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRanges800MHzUsedinCodeplug_A42552.AddDependentObject(this.cnvPerConventionalChannelOptionsItinerantChannelFrequency_A8359);
			this.cnvPerConventionalChannelOptionsTxSquelchType_A9426.AddDependentObject(this.cnvPerConventionalChannelOptionsPLDeviation_A8708);
			conventionalPersonality.RxOptions.CnvPerRxOptionsReceiveOnlyPersonality_A8916.AddDependentObject(this.cnvPerConventionalChannelOptionsPLDeviation_A8708);
			this.cnvPerConventionalChannelOptionsRxSquelchType_A8919.AddDependentObject(this.cnvPerConventionalChannelOptionsRxDPLCode_A8908);
			this.cnvPerConventionalChannelOptionsUserSelectablePLMPLEnhance_43029.AddDependentObject(this.cnvPerConventionalChannelOptionsRxDPLCode_A8908);
			this.cnvPerConventionalChannelOptionsRxSquelchType_A8919.AddDependentObject(this.cnvPerConventionalChannelOptionsRxDPLInvert_A8909);
			this.cnvPerConventionalChannelOptionsUserSelectablePLMPLEnhance_43029.AddDependentObject(this.cnvPerConventionalChannelOptionsRxDPLInvert_A8909);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesOpenFrequency_A22699.AddDependentObject(this.cnvPerConventionalChannelOptionsRxFrequency_A8911);
			this.cnvPerConventionalChannelOptionsTxDevChanSpacing_A23192.AddDependentObject(this.cnvPerConventionalChannelOptionsRxFrequency_A8911);
			this.cnvPerConventionalChannelOptionsRxPLFreq_A8918.AddDependentObject(this.cnvPerConventionalChannelOptionsRxPLCode_A8917);
			this.cnvPerConventionalChannelOptionsRxSquelchType_A8919.AddDependentObject(this.cnvPerConventionalChannelOptionsRxPLCode_A8917);
			this.cnvPerConventionalChannelOptionsUserSelectablePLMPLEnhance_43029.AddDependentObject(this.cnvPerConventionalChannelOptionsRxPLCode_A8917);
			conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.AddDependentObject(this.cnvPerConventionalChannelOptionsRxPLCode_A8917);
			this.cnvPerConventionalChannelOptionsRxSquelchType_A8919.AddDependentObject(this.cnvPerConventionalChannelOptionsRxPLFreq_A8918);
			this.cnvPerConventionalChannelOptionsUserSelectablePLMPLEnhance_43029.AddDependentObject(this.cnvPerConventionalChannelOptionsRxPLFreq_A8918);
			conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.AddDependentObject(this.cnvPerConventionalChannelOptionsRxPLFreq_A8918);
			this.cnvPerConventionalChannelOptionsRxPLCode_A8917.AddDependentObject(this.cnvPerConventionalChannelOptionsRxPLFreq_A8918);
			this.cnvPerConventionalChannelOptionsUserSelectablePLMPLEnhance_43029.AddDependentObject(this.cnvPerConventionalChannelOptionsRxSquelchType_A8919);
			conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.AddDependentObject(this.cnvPerConventionalChannelOptionsRxSquelchType_A8919);
			conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.AddDependentObject(this.cnvPerConventionalChannelOptionsRxNetworkID_A9023);
			conventionalPersonality.RxOptions.CnvPerRxOptionsReceiveOnlyPersonality_A8916.AddDependentObject(this.cnvPerConventionalChannelOptionsDirectTalkaround_A9255);
			conventionalPersonality.TxOptions.CnvPerTxOptionsTxVoiceSignalType_A9574.AddDependentObject(this.cnvPerConventionalChannelOptionsDirectTalkaround_A9255);
			this.cnvPerConventionalChannelOptionsRxFrequency_A8911.AddDependentObject(this.cnvPerConventionalChannelOptionsDirectTalkaround_A9255);
			this.cnvPerConventionalChannelOptionsTxFrequency_A9414.AddDependentObject(this.cnvPerConventionalChannelOptionsDirectTalkaround_A9255);
			this.cnvPerConventionalChannelOptionsRxSquelchType_A8919.AddDependentObject(this.cnvPerConventionalChannelOptionsDirectTalkaround_A9255);
			this.cnvPerConventionalChannelOptionsTxSquelchType_A9426.AddDependentObject(this.cnvPerConventionalChannelOptionsDirectTalkaround_A9255);
			this.cnvPerConventionalChannelOptionsRxPLFreq_A8918.AddDependentObject(this.cnvPerConventionalChannelOptionsDirectTalkaround_A9255);
			this.cnvPerConventionalChannelOptionsTxPLFreq_A9419.AddDependentObject(this.cnvPerConventionalChannelOptionsDirectTalkaround_A9255);
			this.cnvPerConventionalChannelOptionsRxDPLCode_A8908.AddDependentObject(this.cnvPerConventionalChannelOptionsDirectTalkaround_A9255);
			this.cnvPerConventionalChannelOptionsTxDPLCode_A9409.AddDependentObject(this.cnvPerConventionalChannelOptionsDirectTalkaround_A9255);
			this.cnvPerConventionalChannelOptionsRxDPLInvert_A8909.AddDependentObject(this.cnvPerConventionalChannelOptionsDirectTalkaround_A9255);
			this.cnvPerConventionalChannelOptionsTxDPLInvert_A9410.AddDependentObject(this.cnvPerConventionalChannelOptionsDirectTalkaround_A9255);
			this.cnvPerConventionalChannelOptionsRxNetworkID_A9023.AddDependentObject(this.cnvPerConventionalChannelOptionsDirectTalkaround_A9255);
			this.cnvPerConventionalChannelOptionsTxNetworkID_A9550.AddDependentObject(this.cnvPerConventionalChannelOptionsDirectTalkaround_A9255);
			conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.AddDependentObject(this.cnvPerConventionalChannelOptionsDirectTalkaround_A9255);
			this.RefConventionalWide.General.CnvWideGeneralDirectFrequency_A7860.AddDependentObject(this.cnvPerConventionalChannelOptionsTADPLCode_A9256);
			this.cnvPerConventionalChannelOptionsDirectTalkaround_A9255.AddDependentObject(this.cnvPerConventionalChannelOptionsTADPLCode_A9256);
			conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.AddDependentObject(this.cnvPerConventionalChannelOptionsTADPLCode_A9256);
			this.cnvPerConventionalChannelOptionsTASquelchType_A9265.AddDependentObject(this.cnvPerConventionalChannelOptionsTADPLCode_A9256);
			this.cnvPerConventionalChannelOptionsUserSelectablePLMPLEnhance_43029.AddDependentObject(this.cnvPerConventionalChannelOptionsTADPLCode_A9256);
			conventionalPersonality.RxOptions.CnvPerRxOptionsReceiveOnlyPersonality_A8916.AddDependentObject(this.cnvPerConventionalChannelOptionsTADPLCode_A9256);
			this.RefConventionalWide.General.CnvWideGeneralDirectFrequency_A7860.AddDependentObject(this.cnvPerConventionalChannelOptionsTADPLInvert_A9259);
			this.cnvPerConventionalChannelOptionsDirectTalkaround_A9255.AddDependentObject(this.cnvPerConventionalChannelOptionsTADPLInvert_A9259);
			conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.AddDependentObject(this.cnvPerConventionalChannelOptionsTADPLInvert_A9259);
			this.cnvPerConventionalChannelOptionsTASquelchType_A9265.AddDependentObject(this.cnvPerConventionalChannelOptionsTADPLInvert_A9259);
			this.cnvPerConventionalChannelOptionsUserSelectablePLMPLEnhance_43029.AddDependentObject(this.cnvPerConventionalChannelOptionsTADPLInvert_A9259);
			conventionalPersonality.RxOptions.CnvPerRxOptionsReceiveOnlyPersonality_A8916.AddDependentObject(this.cnvPerConventionalChannelOptionsTADPLInvert_A9259);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesOpenFrequency_A22699.AddDependentObject(this.cnvPerConventionalChannelOptionsTAFrequency_A9260);
			this.cnvPerConventionalChannelOptionsTxDevChanSpacing_A23192.AddDependentObject(this.cnvPerConventionalChannelOptionsTAFrequency_A9260);
			this.RefConventionalWide.General.CnvWideGeneralDirectFrequency_A7860.AddDependentObject(this.cnvPerConventionalChannelOptionsTAFrequency_A9260);
			this.cnvPerConventionalChannelOptionsDirectTalkaround_A9255.AddDependentObject(this.cnvPerConventionalChannelOptionsTAFrequency_A9260);
			conventionalPersonality.RxOptions.CnvPerRxOptionsReceiveOnlyPersonality_A8916.AddDependentObject(this.cnvPerConventionalChannelOptionsTAFrequency_A9260);
			this.cnvPerConventionalChannelOptionsUserSelectablePLMPLEnhance_43029.AddDependentObject(this.cnvPerConventionalChannelOptionsTAFrequency_A9260);
			this.RefConventionalWide.General.CnvWideGeneralDirectFrequency_A7860.AddDependentObject(this.cnvPerConventionalChannelOptionsTAPLCode_A9261);
			this.cnvPerConventionalChannelOptionsDirectTalkaround_A9255.AddDependentObject(this.cnvPerConventionalChannelOptionsTAPLCode_A9261);
			conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.AddDependentObject(this.cnvPerConventionalChannelOptionsTAPLCode_A9261);
			this.cnvPerConventionalChannelOptionsTASquelchType_A9265.AddDependentObject(this.cnvPerConventionalChannelOptionsTAPLCode_A9261);
			this.cnvPerConventionalChannelOptionsUserSelectablePLMPLEnhance_43029.AddDependentObject(this.cnvPerConventionalChannelOptionsTAPLCode_A9261);
			conventionalPersonality.RxOptions.CnvPerRxOptionsReceiveOnlyPersonality_A8916.AddDependentObject(this.cnvPerConventionalChannelOptionsTAPLCode_A9261);
			this.cnvPerConventionalChannelOptionsTAPLFreq_A9264.AddDependentObject(this.cnvPerConventionalChannelOptionsTAPLCode_A9261);
			this.RefConventionalWide.General.CnvWideGeneralDirectFrequency_A7860.AddDependentObject(this.cnvPerConventionalChannelOptionsTAPLFreq_A9264);
			this.cnvPerConventionalChannelOptionsDirectTalkaround_A9255.AddDependentObject(this.cnvPerConventionalChannelOptionsTAPLFreq_A9264);
			conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.AddDependentObject(this.cnvPerConventionalChannelOptionsTAPLFreq_A9264);
			this.cnvPerConventionalChannelOptionsTASquelchType_A9265.AddDependentObject(this.cnvPerConventionalChannelOptionsTAPLFreq_A9264);
			this.cnvPerConventionalChannelOptionsUserSelectablePLMPLEnhance_43029.AddDependentObject(this.cnvPerConventionalChannelOptionsTAPLFreq_A9264);
			conventionalPersonality.RxOptions.CnvPerRxOptionsReceiveOnlyPersonality_A8916.AddDependentObject(this.cnvPerConventionalChannelOptionsTAPLFreq_A9264);
			this.cnvPerConventionalChannelOptionsTAPLCode_A9261.AddDependentObject(this.cnvPerConventionalChannelOptionsTAPLFreq_A9264);
			this.RefConventionalWide.General.CnvWideGeneralDirectFrequency_A7860.AddDependentObject(this.cnvPerConventionalChannelOptionsTASquelchType_A9265);
			this.cnvPerConventionalChannelOptionsDirectTalkaround_A9255.AddDependentObject(this.cnvPerConventionalChannelOptionsTASquelchType_A9265);
			conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.AddDependentObject(this.cnvPerConventionalChannelOptionsTASquelchType_A9265);
			this.cnvPerConventionalChannelOptionsUserSelectablePLMPLEnhance_43029.AddDependentObject(this.cnvPerConventionalChannelOptionsTASquelchType_A9265);
			conventionalPersonality.RxOptions.CnvPerRxOptionsReceiveOnlyPersonality_A8916.AddDependentObject(this.cnvPerConventionalChannelOptionsTASquelchType_A9265);
			conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.AddDependentObject(this.cnvPerConventionalChannelOptionsASTROTalkgroupID_A9281);
			conventionalPersonality.ASTROTalkgroup.CnvPerASTROTalkgroupOptionsTalkGroupEnable_A9272.AddDependentObject(this.cnvPerConventionalChannelOptionsASTROTalkgroupID_A9281);
			conventionalPersonality.ASTROTalkgroup.CnvPerASTROTalkgroupOptionsSelectionType_A9112.AddDependentObject(this.cnvPerConventionalChannelOptionsASTROTalkgroupID_A9281);
			conventionalPersonality.Signaling.CnvPerSignalingASTRORxUnmuteRule_A9042.AddDependentObject(this.cnvPerConventionalChannelOptionsASTROTalkgroupID_A9281);
			conventionalPersonality.ASTROTalkgroup.CnvPerASTROTalkgroupOptionsTalkgroupList_A9283.AddDependentObject(this.cnvPerConventionalChannelOptionsASTROTalkgroupID_A9281);
			conventionalPersonality.Signaling.CnvPerSignalingASTROSystem_A7498.AddDependentObject(this.cnvPerConventionalChannelOptionsASTROTalkgroupID_A9281);
			conventionalPersonality.DVRS.CnvPerAGAGTalkgroupID_A40157.AddDependentObject(this.cnvPerConventionalChannelOptionsASTROTalkgroupID_A9281);
			conventionalPersonality.RxOptions.CnvPerRxOptionsReceiveOnlyPersonality_A8916.AddDependentObject(this.cnvPerConventionalChannelOptionsTxDPLCode_A9409);
			this.cnvPerConventionalChannelOptionsTxSquelchType_A9426.AddDependentObject(this.cnvPerConventionalChannelOptionsTxDPLCode_A9409);
			this.cnvPerConventionalChannelOptionsUserSelectablePLMPLEnhance_43029.AddDependentObject(this.cnvPerConventionalChannelOptionsTxDPLCode_A9409);
			conventionalPersonality.RxOptions.CnvPerRxOptionsReceiveOnlyPersonality_A8916.AddDependentObject(this.cnvPerConventionalChannelOptionsTxDPLInvert_A9410);
			this.cnvPerConventionalChannelOptionsTxSquelchType_A9426.AddDependentObject(this.cnvPerConventionalChannelOptionsTxDPLInvert_A9410);
			this.cnvPerConventionalChannelOptionsUserSelectablePLMPLEnhance_43029.AddDependentObject(this.cnvPerConventionalChannelOptionsTxDPLInvert_A9410);
			conventionalPersonality.RxOptions.CnvPerRxOptionsReceiveOnlyPersonality_A8916.AddDependentObject(this.cnvPerConventionalChannelOptionsTxFrequency_A9414);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesOpenFrequency_A22699.AddDependentObject(this.cnvPerConventionalChannelOptionsTxFrequency_A9414);
			this.cnvPerConventionalChannelOptionsTxDevChanSpacing_A23192.AddDependentObject(this.cnvPerConventionalChannelOptionsTxFrequency_A9414);
			this.cnvPerConventionalChannelOptionsTxPLFreq_A9419.AddDependentObject(this.cnvPerConventionalChannelOptionsTxPLCode_A9418);
			this.cnvPerConventionalChannelOptionsTxSquelchType_A9426.AddDependentObject(this.cnvPerConventionalChannelOptionsTxPLCode_A9418);
			conventionalPersonality.RxOptions.CnvPerRxOptionsReceiveOnlyPersonality_A8916.AddDependentObject(this.cnvPerConventionalChannelOptionsTxPLCode_A9418);
			this.cnvPerConventionalChannelOptionsUserSelectablePLMPLEnhance_43029.AddDependentObject(this.cnvPerConventionalChannelOptionsTxPLCode_A9418);
			conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.AddDependentObject(this.cnvPerConventionalChannelOptionsTxPLCode_A9418);
			this.cnvPerConventionalChannelOptionsTxSquelchType_A9426.AddDependentObject(this.cnvPerConventionalChannelOptionsTxPLFreq_A9419);
			conventionalPersonality.RxOptions.CnvPerRxOptionsReceiveOnlyPersonality_A8916.AddDependentObject(this.cnvPerConventionalChannelOptionsTxPLFreq_A9419);
			this.cnvPerConventionalChannelOptionsUserSelectablePLMPLEnhance_43029.AddDependentObject(this.cnvPerConventionalChannelOptionsTxPLFreq_A9419);
			conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.AddDependentObject(this.cnvPerConventionalChannelOptionsTxPLFreq_A9419);
			this.cnvPerConventionalChannelOptionsTxPLCode_A9418.AddDependentObject(this.cnvPerConventionalChannelOptionsTxPLFreq_A9419);
			conventionalPersonality.RxOptions.CnvPerRxOptionsReceiveOnlyPersonality_A8916.AddDependentObject(this.cnvPerConventionalChannelOptionsTxSquelchType_A9426);
			this.cnvPerConventionalChannelOptionsUserSelectablePLMPLEnhance_43029.AddDependentObject(this.cnvPerConventionalChannelOptionsTxSquelchType_A9426);
			conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.AddDependentObject(this.cnvPerConventionalChannelOptionsTxSquelchType_A9426);
			conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.AddDependentObject(this.cnvPerConventionalChannelOptionsTxNetworkID_A9550);
			conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.AddDependentObject(this.cnvPerConventionalChannelOptionsUserSelectablePLMPL_A9606);
			conventionalPersonality.RxOptions.CnvPerRxOptionsReceiveOnlyPersonality_A8916.AddDependentObject(this.cnvPerConventionalChannelOptionsTxDevChanSpacing_A23192);
			this.RefRadioInformation.General.RadInfoGeneralPrimaryFrequencyBandUHF2_A42547.AddDependentObject(this.cnvPerConventionalChannelOptionsTxDevChanSpacing_A23192);
			this.RefRadioInformation.Labtool.RadInfoLabtoolQ507G507FCCMANDATE_A38198.AddDependentObject(this.cnvPerConventionalChannelOptionsTxDevChanSpacing_A23192);
			this.cnvPerConventionalChannelOptionsRxFrequency_A8911.AddDependentObject(this.cnvPerConventionalChannelOptionsTxDevChanSpacing_A23192);
			this.cnvPerConventionalChannelOptionsTxFrequency_A9414.AddDependentObject(this.cnvPerConventionalChannelOptionsTxDevChanSpacing_A23192);
			this.cnvPerConventionalChannelOptionsTAFrequency_A9260.AddDependentObject(this.cnvPerConventionalChannelOptionsTxDevChanSpacing_A23192);
			conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.AddDependentObject(this.cnvPerConventionalChannelOptionsTxDevChanSpacing_A23192);
			this.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.cnvPerConventionalChannelOptionsTxDevChanSpacing_A23192);
			conventionalPersonality.Secure.CnvPerSecureSecureClearStrapping1_A9090.AddDependentObject(this.cnvPerConventionalChannelOptionsTxDevChanSpacing_A23192);
			conventionalPersonality.Signaling.CnvPerSignalingDigitalModulatorType_A7857.AddDependentObject(this.cnvPerConventionalChannelOptionsTxDevChanSpacing_A23192);
			this.RefRadioInformation.Labtool.RadInfoLabtoolPrimaryBands_A23987.AddDependentObject(this.cnvPerConventionalChannelOptionsTxDevChanSpacing_A23192);
			this.RefRadioInformation.Labtool.RadInfoLabtoolSecondaryBands_A23988.AddDependentObject(this.cnvPerConventionalChannelOptionsTxDevChanSpacing_A23192);
			this.RefRadioInformation.Labtool.RadInfoLabtoolDualBandEnable_A23986.AddDependentObject(this.cnvPerConventionalChannelOptionsTxDevChanSpacing_A23192);
			this.RefConventionalWide.General.CnvWideGeneralDirectFrequency_A7860.AddDependentObject(this.cnvPerConventionalChannelOptionsTxDevChanSpacing_A23192);
			conventionalPersonality.Features.CnvPerFeaturesMixedVoteScanEnable_A38723.AddDependentObject(this.cnvPerConventionalFrqncyOptnsMixVSPersistentMember_A38726);
			conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.AddDependentObject(this.cnvPerConventionalChannelOptionsUserSelectablePLMPLEnhance_43029);
			this.cnvPerConventionalChannelOptionsDirectTalkaround_A9255.AddDependentObject((base.ParentRecset.ParentSection.Parent[10144] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.Signaling).CnvPerSignalingASTROSystem_A7498);
			this.cnvPerConventionalChannelOptionsDirectTalkaround_A9255.AddDependentObject((base.ParentRecset.ParentSection.Parent[10136] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.RxOptions).CnvPerRxOptionsReceiveOnlyPersonality_A8916);
			this.cnvPerConventionalChannelOptionsDirectTalkaround_A9255.AddDependentObject((base.ParentRecset.ParentSection.Parent[10136] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.RxOptions).CnvPerRxOptionsRxVoiceSignalType_A9044);
		}

		// Token: 0x1700627D RID: 25213
		// (get) Token: 0x0600C4C9 RID: 50377 RVA: 0x00B8B198 File Offset: 0x00B89398
		public global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.TalkgroupTableInner TalkgroupTableInnerSectionForCnvPerConventionalChannelOptionsASTROTalkgroupID_A9281
		{
			get
			{
				short num = (short)329841185;
				short num2 = num;
				num = (short)813693473;
				switch (num2 == num)
				{
				}
				num = (short)1876623360;
				short num3 = num;
				num = (short)829816833;
				if (num != 0)
				{
				}
				num = (short)267190272;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsASTROTalkgroupID_A9281.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.TalkgroupTableInner;
			}
		}

		// Token: 0x1700627E RID: 25214
		// (get) Token: 0x0600C4CA RID: 50378 RVA: 0x00B8B250 File Offset: 0x00B89450
		public bool HasDiffs
		{
			get
			{
				short num = (short)1589723895;
				short num2 = num;
				num = (short)244466423;
				switch (num2 == num)
				{
				}
				num = (short)259194880;
				short num3 = num;
				num = (short)39583744;
				if (num != 0)
				{
				}
				num = (short)84606977;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x1700627F RID: 25215
		// (get) Token: 0x0600C4CB RID: 50379 RVA: 0x00B8B300 File Offset: 0x00B89500
		// (set) Token: 0x0600C4CC RID: 50380 RVA: 0x00B8B3B8 File Offset: 0x00B895B8
		public int CnvPerConventionalChannelOptionsTANetworkID_A7863Value
		{
			get
			{
				short num = (short)613613569;
				if (num != 0)
				{
				}
				num = (short)1745854924;
				short num2 = num;
				num = (short)240361932;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1032716288;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1188233216;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTANetworkID_A7863.Value;
			}
			set
			{
				short num = (short)419889153;
				if (num != 0)
				{
				}
				num = (short)2127018419;
				short num2 = num;
				num = (short)276085171;
				switch (num2 == num)
				{
				default:
				{
					num = (short)256638976;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)300285952;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTANetworkID_A7863.Value = value;
			}
		}

		// Token: 0x17006280 RID: 25216
		// (get) Token: 0x0600C4CD RID: 50381 RVA: 0x00B8B46C File Offset: 0x00B8966C
		public global::AcpBusinessLayer.AcpSimpleRangeField CnvPerConventionalChannelOptionsTANetworkID_A7863
		{
			get
			{
				short num = (short)2074371883;
				short num2 = num;
				num = (short)111765291;
				switch (num2 == num)
				{
				}
				num = (short)173342720;
				short num3 = num;
				num = (short)559218688;
				if (num != 0)
				{
				}
				num = (short)742260737;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTANetworkID_A7863;
			}
		}

		// Token: 0x17006281 RID: 25217
		// (get) Token: 0x0600C4CE RID: 50382 RVA: 0x00B8B51C File Offset: 0x00B8971C
		// (set) Token: 0x0600C4CF RID: 50383 RVA: 0x00B8B5D0 File Offset: 0x00B897D0
		public string CnvPerConventionalChannelOptionsTANetworkID_A7863_UIValue
		{
			get
			{
				short num = (short)1317012748;
				short num2 = num;
				num = (short)2059273484;
				switch (num2 == num)
				{
				}
				num = (short)1977155584;
				short num3 = num;
				num = (short)1887830017;
				if (num != 0)
				{
				}
				num = (short)270336000;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTANetworkID_A7863.UIValue;
			}
			set
			{
				short num = (short)251667890;
				short num2 = num;
				num = (short)815146418;
				switch (num2 == num)
				{
				}
				num = (short)46727168;
				short num3 = num;
				num = (short)620429313;
				if (num != 0)
				{
				}
				num = (short)827457536;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTANetworkID_A7863.UIValue = value;
			}
		}

		// Token: 0x17006282 RID: 25218
		// (get) Token: 0x0600C4D0 RID: 50384 RVA: 0x00B8B684 File Offset: 0x00B89884
		// (set) Token: 0x0600C4D1 RID: 50385 RVA: 0x00B8B73C File Offset: 0x00B8993C
		public string CnvPerConventionalChannelOptionsTANetworkID_A7863_HexUIValue
		{
			get
			{
				short num = (short)714044771;
				short num2 = num;
				num = (short)1226208611;
				switch (num2 == num)
				{
				}
				num = (short)28442624;
				short num3 = num;
				num = (short)633274368;
				if (num != 0)
				{
				}
				num = (short)297664513;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTANetworkID_A7863.HexUIValue;
			}
			set
			{
				short num = (short)1912406017;
				if (num != 0)
				{
				}
				num = (short)2125106361;
				short num2 = num;
				num = (short)921013433;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1848180736;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1112276992;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTANetworkID_A7863.HexUIValue = value;
			}
		}

		// Token: 0x17006283 RID: 25219
		// (get) Token: 0x0600C4D2 RID: 50386 RVA: 0x00B8B7F4 File Offset: 0x00B899F4
		// (set) Token: 0x0600C4D3 RID: 50387 RVA: 0x00B8B8A8 File Offset: 0x00B89AA8
		internal int CnvPerConventionalChannelOptionsTANetworkID_A7863Min
		{
			get
			{
				short num = (short)150668788;
				short num2 = num;
				num = (short)1245709812;
				switch (num2 == num)
				{
				}
				num = (short)959709184;
				short num3 = num;
				num = (short)1136132096;
				if (num != 0)
				{
				}
				num = (short)1586364417;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTANetworkID_A7863.Min;
			}
			set
			{
				short num = (short)1412072196;
				short num2 = num;
				num = (short)626033412;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1807482880;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1814953985;
				if (num != 0)
				{
				}
				num = (short)1282605056;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTANetworkID_A7863.Min = value;
			}
		}

		// Token: 0x17006284 RID: 25220
		// (get) Token: 0x0600C4D4 RID: 50388 RVA: 0x00B8B95C File Offset: 0x00B89B5C
		// (set) Token: 0x0600C4D5 RID: 50389 RVA: 0x00B8BA10 File Offset: 0x00B89C10
		internal int CnvPerConventionalChannelOptionsTANetworkID_A7863Max
		{
			get
			{
				short num = (short)1057118521;
				short num2 = num;
				num = (short)347035961;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1586626560;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1347420161;
				if (num != 0)
				{
				}
				num = (short)235143168;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTANetworkID_A7863.Max;
			}
			set
			{
				short num = (short)392229051;
				short num2 = num;
				num = (short)1826222267;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1458700288;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1754071040;
				if (num != 0)
				{
				}
				num = (short)219807745;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTANetworkID_A7863.Max = value;
			}
		}

		// Token: 0x17006285 RID: 25221
		// (get) Token: 0x0600C4D6 RID: 50390 RVA: 0x00B8BAC4 File Offset: 0x00B89CC4
		// (set) Token: 0x0600C4D7 RID: 50391 RVA: 0x00B8BB78 File Offset: 0x00B89D78
		internal int CnvPerConventionalChannelOptionsTANetworkID_A7863Step
		{
			get
			{
				short num = (short)444978233;
				short num2 = num;
				num = (short)406639673;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1181548544;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2053505024;
				if (num != 0)
				{
				}
				num = (short)1140523009;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTANetworkID_A7863.StepSize;
			}
			set
			{
				short num = (short)913822404;
				short num2 = num;
				num = (short)2022167236;
				switch (num2 == num)
				{
				default:
				{
					num = (short)965476352;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1283719169;
				if (num != 0)
				{
				}
				num = (short)1519321088;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTANetworkID_A7863.StepSize = value;
			}
		}

		// Token: 0x17006286 RID: 25222
		// (get) Token: 0x0600C4D8 RID: 50392 RVA: 0x00B8BC30 File Offset: 0x00B89E30
		// (set) Token: 0x0600C4D9 RID: 50393 RVA: 0x00B8BCE0 File Offset: 0x00B89EE0
		public bool CnvPerConventionalChannelOptionsTANetworkID_A7863_Applicable
		{
			get
			{
				short num = (short)1603202911;
				short num2 = num;
				num = (short)604106591;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1029963776;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)158662657;
				if (num != 0)
				{
				}
				num = (short)1043202048;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTANetworkID_A7863.Applicable;
			}
			set
			{
				short num = (short)2045963286;
				short num2 = num;
				num = (short)628288534;
				switch (num2 == num)
				{
				default:
				{
					num = (short)753729536;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1271005185;
				if (num != 0)
				{
				}
				num = (short)1539964928;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTANetworkID_A7863.Applicable = value;
			}
		}

		// Token: 0x17006287 RID: 25223
		// (get) Token: 0x0600C4DA RID: 50394 RVA: 0x00B8BD94 File Offset: 0x00B89F94
		// (set) Token: 0x0600C4DB RID: 50395 RVA: 0x00B8BE4C File Offset: 0x00B8A04C
		public bool CnvPerConventionalChannelOptionsTANetworkID_A7863_Valid
		{
			get
			{
				short num = (short)1582765341;
				short num2 = num;
				num = (short)523048221;
				switch (num2 == num)
				{
				default:
				{
					num = (short)364773376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1058078721;
				if (num != 0)
				{
				}
				num = (short)287244288;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTANetworkID_A7863.Valid;
			}
			set
			{
				short num = (short)340399275;
				short num2 = num;
				num = (short)127407275;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1168048128;
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
				num = (short)1974337537;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTANetworkID_A7863.Valid = value;
			}
		}

		// Token: 0x17006288 RID: 25224
		// (get) Token: 0x0600C4DC RID: 50396 RVA: 0x00B8BF04 File Offset: 0x00B8A104
		// (set) Token: 0x0600C4DD RID: 50397 RVA: 0x00B8BFB8 File Offset: 0x00B8A1B8
		public bool CnvPerConventionalChannelOptionsTANetworkID_A7863_Visible
		{
			get
			{
				short num = (short)1496711169;
				if (num != 0)
				{
				}
				num = (short)1927282688;
				short num2 = num;
				num = (short)591965449;
				short num3 = num;
				num = (short)1070181641;
				switch (num3 == num)
				{
				}
				num = (short)2071986176;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTANetworkID_A7863.Visible;
			}
			set
			{
				short num = (short)167381633;
				short num2 = num;
				num = (short)1726286465;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1285685248;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1319501825;
				if (num != 0)
				{
				}
				num = (short)521601024;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTANetworkID_A7863.Visible = value;
			}
		}

		// Token: 0x17006289 RID: 25225
		// (get) Token: 0x0600C4DE RID: 50398 RVA: 0x00B8C070 File Offset: 0x00B8A270
		// (set) Token: 0x0600C4DF RID: 50399 RVA: 0x00B8C124 File Offset: 0x00B8A324
		public bool CnvPerConventionalChannelOptionsTANetworkID_A7863_Editable
		{
			get
			{
				short num = (short)1258977020;
				short num2 = num;
				num = (short)1439987452;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1041629184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1839726592;
				if (num != 0)
				{
				}
				num = (short)1246887937;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTANetworkID_A7863.Editable;
			}
			set
			{
				short num = (short)963313665;
				if (num != 0)
				{
				}
				num = (short)1929707520;
				short num2 = num;
				num = (short)1266822834;
				short num3 = num;
				num = (short)1905274546;
				switch (num3 == num)
				{
				}
				num = (short)1987837952;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTANetworkID_A7863.Editable = value;
			}
		}

		// Token: 0x1700628A RID: 25226
		// (get) Token: 0x0600C4E0 RID: 50400 RVA: 0x00B8C1D8 File Offset: 0x00B8A3D8
		internal string CnvPerConventionalChannelOptionsTANetworkID_A7863_UILabel
		{
			get
			{
				short num = (short)333855741;
				short num2 = num;
				num = (short)1512193021;
				switch (num2 == num)
				{
				default:
				{
					num = (short)758906880;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)413204481;
				if (num != 0)
				{
				}
				num = (short)245891072;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTANetworkID_A7863.UIName;
			}
		}

		// Token: 0x1700628B RID: 25227
		// (get) Token: 0x0600C4E1 RID: 50401 RVA: 0x00B8C28C File Offset: 0x00B8A48C
		// (set) Token: 0x0600C4E2 RID: 50402 RVA: 0x00B8C340 File Offset: 0x00B8A540
		internal bool CnvPerConventionalChannelOptionsTANetworkID_A7863_HiddenStatic
		{
			get
			{
				short num = (short)2000226399;
				short num2 = num;
				num = (short)1891502175;
				switch (num2 == num)
				{
				default:
				{
					num = (short)70189056;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1871446016;
				if (num != 0)
				{
				}
				num = (short)645726209;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTANetworkID_A7863.HiddenStatic;
			}
			set
			{
				short num = (short)1988919727;
				short num2 = num;
				num = (short)1891795375;
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
				num = (short)400424961;
				if (num != 0)
				{
				}
				num = (short)987627520;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTANetworkID_A7863.HiddenStatic = value;
			}
		}

		// Token: 0x1700628C RID: 25228
		// (get) Token: 0x0600C4E3 RID: 50403 RVA: 0x00B8C3F4 File Offset: 0x00B8A5F4
		// (set) Token: 0x0600C4E4 RID: 50404 RVA: 0x00B8C4A8 File Offset: 0x00B8A6A8
		internal bool CnvPerConventionalChannelOptionsTANetworkID_A7863_HiddenDynamic
		{
			get
			{
				short num = (short)699033940;
				short num2 = num;
				num = (short)386754900;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1770258432;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)780075008;
				if (num != 0)
				{
				}
				num = (short)179240961;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTANetworkID_A7863.HiddenDynamic;
			}
			set
			{
				short num = (short)387990622;
				short num2 = num;
				num = (short)227624030;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1485045760;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1630535681;
				if (num != 0)
				{
				}
				num = (short)1642397696;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTANetworkID_A7863.HiddenDynamic = value;
			}
		}

		// Token: 0x1700628D RID: 25229
		// (get) Token: 0x0600C4E5 RID: 50405 RVA: 0x00B8C55C File Offset: 0x00B8A75C
		public bool CnvPerConventionalChannelOptionsTANetworkID_A7863_HasDiffs
		{
			get
			{
				short num = (short)1067858559;
				short num2 = num;
				num = (short)1406024319;
				switch (num2 == num)
				{
				default:
				{
					num = (short)191692800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)716505089;
				if (num != 0)
				{
				}
				num = (short)100401152;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTANetworkID_A7863._HasDiffs;
			}
		}

		// Token: 0x1700628E RID: 25230
		// (get) Token: 0x0600C4E6 RID: 50406 RVA: 0x00B8C610 File Offset: 0x00B8A810
		// (set) Token: 0x0600C4E7 RID: 50407 RVA: 0x00B8C6C4 File Offset: 0x00B8A8C4
		public bool CnvPerConventionalChannelOptionsItinerantChannelFrequency_A8359Value
		{
			get
			{
				short num = (short)569613529;
				short num2 = num;
				num = (short)1312070873;
				switch (num2 == num)
				{
				default:
				{
					num = (short)706936832;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1668349953;
				if (num != 0)
				{
				}
				num = (short)870318080;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsItinerantChannelFrequency_A8359.Value;
			}
			set
			{
				short num = (short)1654296742;
				short num2 = num;
				num = (short)627806374;
				switch (num2 == num)
				{
				default:
				{
					num = (short)431226880;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1496842241;
				if (num != 0)
				{
				}
				num = (short)260440064;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsItinerantChannelFrequency_A8359.Value = value;
			}
		}

		// Token: 0x1700628F RID: 25231
		// (get) Token: 0x0600C4E8 RID: 50408 RVA: 0x00B8C778 File Offset: 0x00B8A978
		public global::AcpBusinessLayer.AcpField<bool> CnvPerConventionalChannelOptionsItinerantChannelFrequency_A8359
		{
			get
			{
				short num = (short)695770234;
				short num2 = num;
				num = (short)141925498;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1291321344;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1217724416;
				if (num != 0)
				{
				}
				num = (short)641400833;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsItinerantChannelFrequency_A8359;
			}
		}

		// Token: 0x17006290 RID: 25232
		// (get) Token: 0x0600C4E9 RID: 50409 RVA: 0x00B8C828 File Offset: 0x00B8AA28
		// (set) Token: 0x0600C4EA RID: 50410 RVA: 0x00B8C8DC File Offset: 0x00B8AADC
		public bool CnvPerConventionalChannelOptionsItinerantChannelFrequency_A8359_UIValue
		{
			get
			{
				short num = (short)645443789;
				short num2 = num;
				num = (short)662941901;
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
				num = (short)1693974529;
				if (num != 0)
				{
				}
				num = (short)1665925120;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsItinerantChannelFrequency_A8359.Value;
			}
			set
			{
				short num = (short)1590910878;
				short num2 = num;
				num = (short)2144427934;
				switch (num2 == num)
				{
				default:
				{
					num = (short)909639680;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1364525056;
				if (num != 0)
				{
				}
				num = (short)247988225;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsItinerantChannelFrequency_A8359.Value = value;
			}
		}

		// Token: 0x17006291 RID: 25233
		// (get) Token: 0x0600C4EB RID: 50411 RVA: 0x00B8C994 File Offset: 0x00B8AB94
		// (set) Token: 0x0600C4EC RID: 50412 RVA: 0x00B8CA48 File Offset: 0x00B8AC48
		public bool CnvPerConventionalChannelOptionsItinerantChannelFrequency_A8359_Applicable
		{
			get
			{
				short num = (short)1101398017;
				if (num != 0)
				{
				}
				num = (short)297271296;
				short num2 = num;
				num = (short)1079361654;
				short num3 = num;
				num = (short)41402486;
				switch (num3 == num)
				{
				}
				num = (short)139788288;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsItinerantChannelFrequency_A8359.Applicable;
			}
			set
			{
				short num = (short)1045413693;
				short num2 = num;
				num = (short)321240893;
				switch (num2 == num)
				{
				default:
				{
					num = (short)547684352;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)886505472;
				if (num != 0)
				{
				}
				num = (short)651821057;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsItinerantChannelFrequency_A8359.Applicable = value;
			}
		}

		// Token: 0x17006292 RID: 25234
		// (get) Token: 0x0600C4ED RID: 50413 RVA: 0x00B8CAFC File Offset: 0x00B8ACFC
		// (set) Token: 0x0600C4EE RID: 50414 RVA: 0x00B8CBB0 File Offset: 0x00B8ADB0
		public bool CnvPerConventionalChannelOptionsItinerantChannelFrequency_A8359_Valid
		{
			get
			{
				short num = (short)1957454135;
				short num2 = num;
				num = (short)2110939447;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1600978944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1326514176;
				if (num != 0)
				{
				}
				num = (short)930086913;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsItinerantChannelFrequency_A8359.Valid;
			}
			set
			{
				short num = (short)616431617;
				if (num != 0)
				{
				}
				num = (short)990838784;
				short num2 = num;
				num = (short)737168213;
				short num3 = num;
				num = (short)488721237;
				switch (num3 == num)
				{
				}
				num = (short)64356352;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsItinerantChannelFrequency_A8359.Valid = value;
			}
		}

		// Token: 0x17006293 RID: 25235
		// (get) Token: 0x0600C4EF RID: 50415 RVA: 0x00B8CC68 File Offset: 0x00B8AE68
		// (set) Token: 0x0600C4F0 RID: 50416 RVA: 0x00B8CD1C File Offset: 0x00B8AF1C
		public bool CnvPerConventionalChannelOptionsItinerantChannelFrequency_A8359_Visible
		{
			get
			{
				short num = (short)1349455096;
				short num2 = num;
				num = (short)1980042488;
				switch (num2 == num)
				{
				default:
				{
					num = (short)190644224;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)770244609;
				if (num != 0)
				{
				}
				num = (short)208797696;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsItinerantChannelFrequency_A8359.Visible;
			}
			set
			{
				short num = (short)1148126066;
				short num2 = num;
				num = (short)1212351346;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1689845760;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1821638657;
				if (num != 0)
				{
				}
				num = (short)428670976;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsItinerantChannelFrequency_A8359.Visible = value;
			}
		}

		// Token: 0x17006294 RID: 25236
		// (get) Token: 0x0600C4F1 RID: 50417 RVA: 0x00B8CDD4 File Offset: 0x00B8AFD4
		// (set) Token: 0x0600C4F2 RID: 50418 RVA: 0x00B8CE8C File Offset: 0x00B8B08C
		public bool CnvPerConventionalChannelOptionsItinerantChannelFrequency_A8359_Editable
		{
			get
			{
				short num = (short)494082348;
				short num2 = num;
				num = (short)525736236;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1605042176;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1738670080;
				if (num != 0)
				{
				}
				num = (short)1960902657;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsItinerantChannelFrequency_A8359.Editable;
			}
			set
			{
				short num = (short)1671886973;
				short num2 = num;
				num = (short)1915746429;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1523515392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)151126017;
				if (num != 0)
				{
				}
				num = (short)1992622080;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsItinerantChannelFrequency_A8359.Editable = value;
			}
		}

		// Token: 0x17006295 RID: 25237
		// (get) Token: 0x0600C4F3 RID: 50419 RVA: 0x00B8CF44 File Offset: 0x00B8B144
		internal string CnvPerConventionalChannelOptionsItinerantChannelFrequency_A8359_UILabel
		{
			get
			{
				short num = (short)2015577703;
				short num2 = num;
				num = (short)1980647015;
				switch (num2 == num)
				{
				default:
				{
					num = (short)56033280;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1612709889;
				if (num != 0)
				{
				}
				num = (short)1909850112;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsItinerantChannelFrequency_A8359.UIName;
			}
		}

		// Token: 0x17006296 RID: 25238
		// (get) Token: 0x0600C4F4 RID: 50420 RVA: 0x00B8CFFC File Offset: 0x00B8B1FC
		// (set) Token: 0x0600C4F5 RID: 50421 RVA: 0x00B8D0B4 File Offset: 0x00B8B2B4
		internal bool CnvPerConventionalChannelOptionsItinerantChannelFrequency_A8359_HiddenStatic
		{
			get
			{
				short num = (short)1781674384;
				short num2 = num;
				num = (short)1506554256;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1023344640;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2069889025;
				if (num != 0)
				{
				}
				num = (short)1613758464;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsItinerantChannelFrequency_A8359.HiddenStatic;
			}
			set
			{
				short num = (short)1251153155;
				short num2 = num;
				num = (short)1514214659;
				switch (num2 == num)
				{
				default:
				{
					num = (short)203030528;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)225968129;
				if (num != 0)
				{
				}
				num = (short)1600847872;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsItinerantChannelFrequency_A8359.HiddenStatic = value;
			}
		}

		// Token: 0x17006297 RID: 25239
		// (get) Token: 0x0600C4F6 RID: 50422 RVA: 0x00B8D16C File Offset: 0x00B8B36C
		// (set) Token: 0x0600C4F7 RID: 50423 RVA: 0x00B8D224 File Offset: 0x00B8B424
		internal bool CnvPerConventionalChannelOptionsItinerantChannelFrequency_A8359_HiddenDynamic
		{
			get
			{
				short num = (short)1049712490;
				short num2 = num;
				num = (short)845305706;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2100690944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1093468161;
				if (num != 0)
				{
				}
				num = (short)959315968;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsItinerantChannelFrequency_A8359.HiddenDynamic;
			}
			set
			{
				short num = (short)1257177089;
				if (num != 0)
				{
				}
				num = (short)2051080192;
				short num2 = num;
				num = (short)1327455834;
				short num3 = num;
				num = (short)2075418202;
				switch (num3 == num)
				{
				}
				num = (short)1445068800;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsItinerantChannelFrequency_A8359.HiddenDynamic = value;
			}
		}

		// Token: 0x17006298 RID: 25240
		// (get) Token: 0x0600C4F8 RID: 50424 RVA: 0x00B8D2D8 File Offset: 0x00B8B4D8
		public bool CnvPerConventionalChannelOptionsItinerantChannelFrequency_A8359_HasDiffs
		{
			get
			{
				short num = (short)1117005164;
				short num2 = num;
				num = (short)1104487788;
				switch (num2 == num)
				{
				default:
				{
					num = (short)497025024;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1282211840;
				if (num != 0)
				{
				}
				num = (short)1412431873;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsItinerantChannelFrequency_A8359._HasDiffs;
			}
		}

		// Token: 0x17006299 RID: 25241
		// (get) Token: 0x0600C4F9 RID: 50425 RVA: 0x00B8D38C File Offset: 0x00B8B58C
		// (set) Token: 0x0600C4FA RID: 50426 RVA: 0x00B8D440 File Offset: 0x00B8B640
		public int CnvPerConventionalChannelOptionsPLDeviation_A8708Value
		{
			get
			{
				short num = (short)1867086935;
				short num2 = num;
				num = (short)820477015;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1167982592;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1428422657;
				if (num != 0)
				{
				}
				num = (short)213647360;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsPLDeviation_A8708.Value;
			}
			set
			{
				short num = (short)1359224226;
				short num2 = num;
				num = (short)1105993122;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1821638656;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)988086273;
				if (num != 0)
				{
				}
				num = (short)117768192;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsPLDeviation_A8708.Value = value;
			}
		}

		// Token: 0x1700629A RID: 25242
		// (get) Token: 0x0600C4FB RID: 50427 RVA: 0x00B8D4F8 File Offset: 0x00B8B6F8
		// (set) Token: 0x0600C4FC RID: 50428 RVA: 0x00B8D5AC File Offset: 0x00B8B7AC
		public string CnvPerConventionalChannelOptionsPLDeviation_A8708_UIValue
		{
			get
			{
				short num = (short)1897264734;
				short num2 = num;
				num = (short)387380830;
				switch (num2 == num)
				{
				default:
				{
					num = (short)550764544;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)279511040;
				if (num != 0)
				{
				}
				num = (short)136577025;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsPLDeviation_A8708.UIValue;
			}
			set
			{
				short num = (short)2072082015;
				short num2 = num;
				num = (short)1132164703;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1409482752;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)401735681;
				if (num != 0)
				{
				}
				num = (short)1289158656;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsPLDeviation_A8708.UIValue = value;
			}
		}

		// Token: 0x1700629B RID: 25243
		// (get) Token: 0x0600C4FD RID: 50429 RVA: 0x00B8D664 File Offset: 0x00B8B864
		public global::AcpBusinessLayer.AcpListField CnvPerConventionalChannelOptionsPLDeviation_A8708
		{
			get
			{
				short num = (short)1868169217;
				if (num != 0)
				{
				}
				num = (short)773849088;
				short num2 = num;
				num = (short)113599297;
				short num3 = num;
				num = (short)1766482753;
				switch (num3 == num)
				{
				}
				num = (short)186253312;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsPLDeviation_A8708;
			}
		}

		// Token: 0x1700629C RID: 25244
		// (get) Token: 0x0600C4FE RID: 50430 RVA: 0x00B8D714 File Offset: 0x00B8B914
		// (set) Token: 0x0600C4FF RID: 50431 RVA: 0x00B8D7C8 File Offset: 0x00B8B9C8
		public bool CnvPerConventionalChannelOptionsPLDeviation_A8708_Applicable
		{
			get
			{
				short num = (short)2128558376;
				short num2 = num;
				num = (short)1376008488;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1109458944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1779499008;
				if (num != 0)
				{
				}
				num = (short)377225217;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsPLDeviation_A8708.Applicable;
			}
			set
			{
				short num = (short)1933856833;
				short num2 = num;
				num = (short)2017153089;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1861222400;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)474873857;
				if (num != 0)
				{
				}
				num = (short)811532288;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsPLDeviation_A8708.Applicable = value;
			}
		}

		// Token: 0x1700629D RID: 25245
		// (get) Token: 0x0600C500 RID: 50432 RVA: 0x00B8D880 File Offset: 0x00B8BA80
		// (set) Token: 0x0600C501 RID: 50433 RVA: 0x00B8D934 File Offset: 0x00B8BB34
		public bool CnvPerConventionalChannelOptionsPLDeviation_A8708_Valid
		{
			get
			{
				short num = (short)1429701413;
				short num2 = num;
				num = (short)531006245;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1531510784;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1274085376;
				if (num != 0)
				{
				}
				num = (short)806223873;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsPLDeviation_A8708.Valid;
			}
			set
			{
				short num = (short)724767813;
				short num2 = num;
				num = (short)726340677;
				switch (num2 == num)
				{
				default:
				{
					num = (short)678625280;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)864550912;
				if (num != 0)
				{
				}
				num = (short)1414463489;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsPLDeviation_A8708.Valid = value;
			}
		}

		// Token: 0x1700629E RID: 25246
		// (get) Token: 0x0600C502 RID: 50434 RVA: 0x00B8D9EC File Offset: 0x00B8BBEC
		// (set) Token: 0x0600C503 RID: 50435 RVA: 0x00B8DAA4 File Offset: 0x00B8BCA4
		public bool CnvPerConventionalChannelOptionsPLDeviation_A8708_Visible
		{
			get
			{
				short num = (short)1255302607;
				short num2 = num;
				num = (short)1259759055;
				switch (num2 == num)
				{
				default:
				{
					num = (short)30474240;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)71172096;
				if (num != 0)
				{
				}
				num = (short)2068774913;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsPLDeviation_A8708.Visible;
			}
			set
			{
				short num = (short)1199767553;
				if (num != 0)
				{
				}
				num = (short)2113667072;
				short num2 = num;
				num = (short)159101268;
				short num3 = num;
				num = (short)2102636884;
				switch (num3 == num)
				{
				}
				num = (short)1613103104;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsPLDeviation_A8708.Visible = value;
			}
		}

		// Token: 0x1700629F RID: 25247
		// (get) Token: 0x0600C504 RID: 50436 RVA: 0x00B8DB5C File Offset: 0x00B8BD5C
		// (set) Token: 0x0600C505 RID: 50437 RVA: 0x00B8DC14 File Offset: 0x00B8BE14
		public bool CnvPerConventionalChannelOptionsPLDeviation_A8708_Editable
		{
			get
			{
				short num = (short)1825367420;
				short num2 = num;
				num = (short)875750780;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1403584512;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1526726657;
				if (num != 0)
				{
				}
				num = (short)1805189120;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsPLDeviation_A8708.Editable;
			}
			set
			{
				short num = (short)1241160632;
				short num2 = num;
				num = (short)599563192;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1043660800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1394540545;
				if (num != 0)
				{
				}
				num = (short)1146159104;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsPLDeviation_A8708.Editable = value;
			}
		}

		// Token: 0x170062A0 RID: 25248
		// (get) Token: 0x0600C506 RID: 50438 RVA: 0x00B8DCC8 File Offset: 0x00B8BEC8
		internal string CnvPerConventionalChannelOptionsPLDeviation_A8708_UILabel
		{
			get
			{
				short num = (short)1008787796;
				short num2 = num;
				num = (short)282583380;
				switch (num2 == num)
				{
				default:
				{
					num = (short)349372416;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1459093505;
				if (num != 0)
				{
				}
				num = (short)284688384;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsPLDeviation_A8708.UIName;
			}
		}

		// Token: 0x170062A1 RID: 25249
		// (get) Token: 0x0600C507 RID: 50439 RVA: 0x00B8DD80 File Offset: 0x00B8BF80
		// (set) Token: 0x0600C508 RID: 50440 RVA: 0x00B8DE34 File Offset: 0x00B8C034
		internal bool CnvPerConventionalChannelOptionsPLDeviation_A8708_HiddenStatic
		{
			get
			{
				short num = (short)1479162596;
				short num2 = num;
				num = (short)1390885604;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2131427328;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1175453697;
				if (num != 0)
				{
				}
				num = (short)469237760;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsPLDeviation_A8708.HiddenStatic;
			}
			set
			{
				short num = (short)1709764575;
				short num2 = num;
				num = (short)2019946463;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1578696704;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1872887808;
				if (num != 0)
				{
				}
				num = (short)1960181761;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsPLDeviation_A8708.HiddenStatic = value;
			}
		}

		// Token: 0x170062A2 RID: 25250
		// (get) Token: 0x0600C509 RID: 50441 RVA: 0x00B8DEE8 File Offset: 0x00B8C0E8
		// (set) Token: 0x0600C50A RID: 50442 RVA: 0x00B8DFA0 File Offset: 0x00B8C1A0
		internal bool CnvPerConventionalChannelOptionsPLDeviation_A8708_HiddenDynamic
		{
			get
			{
				short num = (short)571635022;
				short num2 = num;
				num = (short)1310225742;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1758593024;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)814612481;
				if (num != 0)
				{
				}
				num = (short)1378091008;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsPLDeviation_A8708.HiddenDynamic;
			}
			set
			{
				short num = (short)1039001226;
				short num2 = num;
				num = (short)319415946;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1374420992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1932132353;
				if (num != 0)
				{
				}
				num = (short)391315456;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsPLDeviation_A8708.HiddenDynamic = value;
			}
		}

		// Token: 0x170062A3 RID: 25251
		// (get) Token: 0x0600C50B RID: 50443 RVA: 0x00B8E054 File Offset: 0x00B8C254
		public bool CnvPerConventionalChannelOptionsPLDeviation_A8708_HasDiffs
		{
			get
			{
				short num = (short)1174644843;
				short num2 = num;
				num = (short)1389930603;
				switch (num2 == num)
				{
				default:
				{
					num = (short)50003968;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1880227841;
				if (num != 0)
				{
				}
				num = (short)1767571456;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsPLDeviation_A8708._HasDiffs;
			}
		}

		// Token: 0x170062A4 RID: 25252
		// (get) Token: 0x0600C50C RID: 50444 RVA: 0x00B8E108 File Offset: 0x00B8C308
		// (set) Token: 0x0600C50D RID: 50445 RVA: 0x00B8E1BC File Offset: 0x00B8C3BC
		public int CnvPerConventionalChannelOptionsRxDPLCode_A8908Value
		{
			get
			{
				short num = (short)340693277;
				short num2 = num;
				num = (short)1427149085;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1414004736;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)452329472;
				if (num != 0)
				{
				}
				num = (short)2143682561;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsRxDPLCode_A8908.Value;
			}
			set
			{
				short num = (short)2125272003;
				short num2 = num;
				num = (short)1464800195;
				switch (num2 == num)
				{
				default:
				{
					num = (short)298582016;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)545456128;
				if (num != 0)
				{
				}
				num = (short)1237057537;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsRxDPLCode_A8908.Value = value;
			}
		}

		// Token: 0x170062A5 RID: 25253
		// (get) Token: 0x0600C50E RID: 50446 RVA: 0x00B8E270 File Offset: 0x00B8C470
		// (set) Token: 0x0600C50F RID: 50447 RVA: 0x00B8E328 File Offset: 0x00B8C528
		public string CnvPerConventionalChannelOptionsRxDPLCode_A8908_UIValue
		{
			get
			{
				short num = (short)413995911;
				short num2 = num;
				num = (short)1169298311;
				switch (num2 == num)
				{
				}
				num = (short)1301348352;
				short num3 = num;
				num = (short)1851129857;
				if (num != 0)
				{
				}
				num = (short)1945829376;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsRxDPLCode_A8908.UIValue;
			}
			set
			{
				short num = (short)254971431;
				short num2 = num;
				num = (short)2121371175;
				switch (num2 == num)
				{
				}
				num = (short)2127233024;
				short num3 = num;
				num = (short)793575424;
				if (num != 0)
				{
				}
				num = (short)719912961;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsRxDPLCode_A8908.UIValue = value;
			}
		}

		// Token: 0x170062A6 RID: 25254
		// (get) Token: 0x0600C510 RID: 50448 RVA: 0x00B8E3DC File Offset: 0x00B8C5DC
		public global::AcpBusinessLayer.AcpListField CnvPerConventionalChannelOptionsRxDPLCode_A8908
		{
			get
			{
				short num = (short)1088397505;
				short num2 = num;
				num = (short)173121729;
				switch (num2 == num)
				{
				}
				num = (short)1276968960;
				short num3 = num;
				num = (short)1307508737;
				if (num != 0)
				{
				}
				num = (short)1559429120;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsRxDPLCode_A8908;
			}
		}

		// Token: 0x170062A7 RID: 25255
		// (get) Token: 0x0600C511 RID: 50449 RVA: 0x00B8E490 File Offset: 0x00B8C690
		// (set) Token: 0x0600C512 RID: 50450 RVA: 0x00B8E544 File Offset: 0x00B8C744
		public bool CnvPerConventionalChannelOptionsRxDPLCode_A8908_Applicable
		{
			get
			{
				short num = (short)271714341;
				short num2 = num;
				num = (short)276695077;
				switch (num2 == num)
				{
				}
				num = (short)838795264;
				short num3 = num;
				num = (short)2007105536;
				if (num != 0)
				{
				}
				num = (short)1013121025;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsRxDPLCode_A8908.Applicable;
			}
			set
			{
				short num = (short)255856953;
				short num2 = num;
				num = (short)439816505;
				switch (num2 == num)
				{
				}
				num = (short)284491776;
				short num3 = num;
				num = (short)905183233;
				if (num != 0)
				{
				}
				num = (short)1237843968;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsRxDPLCode_A8908.Applicable = value;
			}
		}

		// Token: 0x170062A8 RID: 25256
		// (get) Token: 0x0600C513 RID: 50451 RVA: 0x00B8E5F8 File Offset: 0x00B8C7F8
		// (set) Token: 0x0600C514 RID: 50452 RVA: 0x00B8E6AC File Offset: 0x00B8C8AC
		public bool CnvPerConventionalChannelOptionsRxDPLCode_A8908_Valid
		{
			get
			{
				short num = (short)1093571549;
				short num2 = num;
				num = (short)1602065373;
				switch (num2 == num)
				{
				}
				num = (short)684195840;
				short num3 = num;
				num = (short)638713857;
				if (num != 0)
				{
				}
				num = (short)53346304;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsRxDPLCode_A8908.Valid;
			}
			set
			{
				short num = (short)276304387;
				short num2 = num;
				num = (short)1251021315;
				switch (num2 == num)
				{
				}
				num = (short)1836253184;
				short num3 = num;
				num = (short)138674177;
				if (num != 0)
				{
				}
				num = (short)1057816576;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsRxDPLCode_A8908.Valid = value;
			}
		}

		// Token: 0x170062A9 RID: 25257
		// (get) Token: 0x0600C515 RID: 50453 RVA: 0x00B8E760 File Offset: 0x00B8C960
		// (set) Token: 0x0600C516 RID: 50454 RVA: 0x00B8E814 File Offset: 0x00B8CA14
		public bool CnvPerConventionalChannelOptionsRxDPLCode_A8908_Visible
		{
			get
			{
				short num = (short)727134356;
				short num2 = num;
				num = (short)670773396;
				switch (num2 == num)
				{
				}
				num = (short)989200384;
				short num3 = num;
				num = (short)41156609;
				if (num != 0)
				{
				}
				num = (short)1953300480;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsRxDPLCode_A8908.Visible;
			}
			set
			{
				short num = (short)949419298;
				short num2 = num;
				num = (short)2022505762;
				switch (num2 == num)
				{
				}
				num = (short)1493696512;
				short num3 = num;
				num = (short)1099497472;
				if (num != 0)
				{
				}
				num = (short)467402753;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsRxDPLCode_A8908.Visible = value;
			}
		}

		// Token: 0x170062AA RID: 25258
		// (get) Token: 0x0600C517 RID: 50455 RVA: 0x00B8E8C8 File Offset: 0x00B8CAC8
		// (set) Token: 0x0600C518 RID: 50456 RVA: 0x00B8E97C File Offset: 0x00B8CB7C
		public bool CnvPerConventionalChannelOptionsRxDPLCode_A8908_Editable
		{
			get
			{
				short num = (short)20260602;
				short num2 = num;
				num = (short)1744054010;
				switch (num2 == num)
				{
				}
				num = (short)884277248;
				short num3 = num;
				num = (short)354156545;
				if (num != 0)
				{
				}
				num = (short)1727791104;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsRxDPLCode_A8908.Editable;
			}
			set
			{
				short num = (short)1153806580;
				short num2 = num;
				num = (short)2732276;
				switch (num2 == num)
				{
				}
				num = (short)1030815744;
				short num3 = num;
				num = (short)136708097;
				if (num != 0)
				{
				}
				num = (short)533463040;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsRxDPLCode_A8908.Editable = value;
			}
		}

		// Token: 0x170062AB RID: 25259
		// (get) Token: 0x0600C519 RID: 50457 RVA: 0x00B8EA34 File Offset: 0x00B8CC34
		internal string CnvPerConventionalChannelOptionsRxDPLCode_A8908_UILabel
		{
			get
			{
				short num = (short)2026120021;
				short num2 = num;
				num = (short)1769677653;
				switch (num2 == num)
				{
				}
				num = (short)255852544;
				short num3 = num;
				num = (short)1271529473;
				if (num != 0)
				{
				}
				num = (short)1004994560;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsRxDPLCode_A8908.UIName;
			}
		}

		// Token: 0x170062AC RID: 25260
		// (get) Token: 0x0600C51A RID: 50458 RVA: 0x00B8EAEC File Offset: 0x00B8CCEC
		// (set) Token: 0x0600C51B RID: 50459 RVA: 0x00B8EBA0 File Offset: 0x00B8CDA0
		internal bool CnvPerConventionalChannelOptionsRxDPLCode_A8908_HiddenStatic
		{
			get
			{
				short num = (short)900923393;
				if (num != 0)
				{
				}
				num = (short)1658864616;
				short num2 = num;
				num = (short)1865303016;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1117323264;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2096824320;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsRxDPLCode_A8908.HiddenStatic;
			}
			set
			{
				short num = (short)1515323393;
				if (num != 0)
				{
				}
				num = (short)1015597062;
				short num2 = num;
				num = (short)1554171910;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1094975488;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)585236480;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsRxDPLCode_A8908.HiddenStatic = value;
			}
		}

		// Token: 0x170062AD RID: 25261
		// (get) Token: 0x0600C51C RID: 50460 RVA: 0x00B8EC54 File Offset: 0x00B8CE54
		// (set) Token: 0x0600C51D RID: 50461 RVA: 0x00B8ED08 File Offset: 0x00B8CF08
		internal bool CnvPerConventionalChannelOptionsRxDPLCode_A8908_HiddenDynamic
		{
			get
			{
				short num = (short)946871516;
				short num2 = num;
				num = (short)1684282588;
				switch (num2 == num)
				{
				}
				num = (short)1133445120;
				short num3 = num;
				num = (short)151846913;
				if (num != 0)
				{
				}
				num = (short)1909522432;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsRxDPLCode_A8908.HiddenDynamic;
			}
			set
			{
				short num = (short)2127210107;
				short num2 = num;
				num = (short)1971889787;
				switch (num2 == num)
				{
				}
				num = (short)2042036224;
				short num3 = num;
				num = (short)1208680449;
				if (num != 0)
				{
				}
				num = (short)2127822848;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsRxDPLCode_A8908.HiddenDynamic = value;
			}
		}

		// Token: 0x170062AE RID: 25262
		// (get) Token: 0x0600C51E RID: 50462 RVA: 0x00B8EDBC File Offset: 0x00B8CFBC
		public bool CnvPerConventionalChannelOptionsRxDPLCode_A8908_HasDiffs
		{
			get
			{
				short num = (short)713628230;
				short num2 = num;
				num = (short)1505630790;
				switch (num2 == num)
				{
				}
				num = (short)236519424;
				short num3 = num;
				num = (short)1329659905;
				if (num != 0)
				{
				}
				num = (short)749338624;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsRxDPLCode_A8908._HasDiffs;
			}
		}

		// Token: 0x170062AF RID: 25263
		// (get) Token: 0x0600C51F RID: 50463 RVA: 0x00B8EE74 File Offset: 0x00B8D074
		// (set) Token: 0x0600C520 RID: 50464 RVA: 0x00B8EF28 File Offset: 0x00B8D128
		public bool CnvPerConventionalChannelOptionsRxDPLInvert_A8909Value
		{
			get
			{
				short num = (short)1205418297;
				short num2 = num;
				num = (short)705837369;
				switch (num2 == num)
				{
				}
				num = (short)810287104;
				short num3 = num;
				num = (short)1207435265;
				if (num != 0)
				{
				}
				num = (short)701038592;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsRxDPLInvert_A8909.Value;
			}
			set
			{
				short num = (short)2017294245;
				short num2 = num;
				num = (short)193427365;
				switch (num2 == num)
				{
				}
				num = (short)1886519296;
				short num3 = num;
				num = (short)783548416;
				if (num != 0)
				{
				}
				num = (short)1637941249;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsRxDPLInvert_A8909.Value = value;
			}
		}

		// Token: 0x170062B0 RID: 25264
		// (get) Token: 0x0600C521 RID: 50465 RVA: 0x00B8EFDC File Offset: 0x00B8D1DC
		public global::AcpBusinessLayer.AcpField<bool> CnvPerConventionalChannelOptionsRxDPLInvert_A8909
		{
			get
			{
				short num = (short)350162780;
				short num2 = num;
				num = (short)1531187036;
				switch (num2 == num)
				{
				}
				num = (short)1557790720;
				short num3 = num;
				num = (short)1599930369;
				if (num != 0)
				{
				}
				num = (short)1297809408;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsRxDPLInvert_A8909;
			}
		}

		// Token: 0x170062B1 RID: 25265
		// (get) Token: 0x0600C522 RID: 50466 RVA: 0x00B8F088 File Offset: 0x00B8D288
		// (set) Token: 0x0600C523 RID: 50467 RVA: 0x00B8F13C File Offset: 0x00B8D33C
		public bool CnvPerConventionalChannelOptionsRxDPLInvert_A8909_UIValue
		{
			get
			{
				short num = (short)656162128;
				short num2 = num;
				num = (short)993410384;
				switch (num2 == num)
				{
				}
				num = (short)1404698624;
				short num3 = num;
				num = (short)444596225;
				if (num != 0)
				{
				}
				num = (short)2014707712;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsRxDPLInvert_A8909.Value;
			}
			set
			{
				short num = (short)1967390721;
				if (num != 0)
				{
				}
				num = (short)1989192440;
				short num2 = num;
				num = (short)839691000;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1231552512;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)83361792;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsRxDPLInvert_A8909.Value = value;
			}
		}

		// Token: 0x170062B2 RID: 25266
		// (get) Token: 0x0600C524 RID: 50468 RVA: 0x00B8F1F4 File Offset: 0x00B8D3F4
		// (set) Token: 0x0600C525 RID: 50469 RVA: 0x00B8F2A4 File Offset: 0x00B8D4A4
		public bool CnvPerConventionalChannelOptionsRxDPLInvert_A8909_Applicable
		{
			get
			{
				short num = (short)660929384;
				short num2 = num;
				num = (short)919599976;
				switch (num2 == num)
				{
				}
				num = (short)1259012096;
				short num3 = num;
				num = (short)1383923712;
				if (num != 0)
				{
				}
				num = (short)1329659905;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsRxDPLInvert_A8909.Applicable;
			}
			set
			{
				short num = (short)1955921921;
				if (num != 0)
				{
				}
				num = (short)1238276608;
				short num2 = num;
				num = (short)1061460480;
				switch (num2 == num)
				{
				default:
				{
					num = (short)875954176;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1606418432;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsRxDPLInvert_A8909.Applicable = value;
			}
		}

		// Token: 0x170062B3 RID: 25267
		// (get) Token: 0x0600C526 RID: 50470 RVA: 0x00B8F358 File Offset: 0x00B8D558
		// (set) Token: 0x0600C527 RID: 50471 RVA: 0x00B8F40C File Offset: 0x00B8D60C
		public bool CnvPerConventionalChannelOptionsRxDPLInvert_A8909_Valid
		{
			get
			{
				short num = (short)1944725372;
				short num2 = num;
				num = (short)1411852156;
				switch (num2 == num)
				{
				}
				num = (short)584974336;
				short num3 = num;
				num = (short)363003904;
				if (num != 0)
				{
				}
				num = (short)285999105;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsRxDPLInvert_A8909.Valid;
			}
			set
			{
				short num = (short)1004169146;
				short num2 = num;
				num = (short)759326650;
				switch (num2 == num)
				{
				}
				num = (short)1251737600;
				short num3 = num;
				num = (short)1454505984;
				if (num != 0)
				{
				}
				num = (short)10289153;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsRxDPLInvert_A8909.Valid = value;
			}
		}

		// Token: 0x170062B4 RID: 25268
		// (get) Token: 0x0600C528 RID: 50472 RVA: 0x00B8F4C0 File Offset: 0x00B8D6C0
		// (set) Token: 0x0600C529 RID: 50473 RVA: 0x00B8F574 File Offset: 0x00B8D774
		public bool CnvPerConventionalChannelOptionsRxDPLInvert_A8909_Visible
		{
			get
			{
				short num = (short)1704853505;
				if (num != 0)
				{
				}
				num = (short)1618425816;
				short num2 = num;
				num = (short)194787288;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2128674816;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)211025920;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsRxDPLInvert_A8909.Visible;
			}
			set
			{
				short num = (short)1138998680;
				short num2 = num;
				num = (short)1943256472;
				switch (num2 == num)
				{
				}
				num = (short)779943936;
				short num3 = num;
				num = (short)2056650752;
				if (num != 0)
				{
				}
				num = (short)541392897;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsRxDPLInvert_A8909.Visible = value;
			}
		}

		// Token: 0x170062B5 RID: 25269
		// (get) Token: 0x0600C52A RID: 50474 RVA: 0x00B8F62C File Offset: 0x00B8D82C
		// (set) Token: 0x0600C52B RID: 50475 RVA: 0x00B8F6E4 File Offset: 0x00B8D8E4
		public bool CnvPerConventionalChannelOptionsRxDPLInvert_A8909_Editable
		{
			get
			{
				short num = (short)1627018887;
				short num2 = num;
				num = (short)625104519;
				switch (num2 == num)
				{
				}
				num = (short)1435500544;
				short num3 = num;
				num = (short)1735720961;
				if (num != 0)
				{
				}
				num = (short)1041039360;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsRxDPLInvert_A8909.Editable;
			}
			set
			{
				short num = (short)1361493057;
				short num2 = num;
				num = (short)1733147713;
				switch (num2 == num)
				{
				}
				num = (short)2130051072;
				short num3 = num;
				num = (short)291241984;
				if (num != 0)
				{
				}
				num = (short)1783562241;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsRxDPLInvert_A8909.Editable = value;
			}
		}

		// Token: 0x170062B6 RID: 25270
		// (get) Token: 0x0600C52C RID: 50476 RVA: 0x00B8F798 File Offset: 0x00B8D998
		internal string CnvPerConventionalChannelOptionsRxDPLInvert_A8909_UILabel
		{
			get
			{
				short num = (short)791948920;
				short num2 = num;
				num = (short)152972920;
				switch (num2 == num)
				{
				}
				num = (short)1340997632;
				short num3 = num;
				num = (short)1989279744;
				if (num != 0)
				{
				}
				num = (short)1052901377;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsRxDPLInvert_A8909.UIName;
			}
		}

		// Token: 0x170062B7 RID: 25271
		// (get) Token: 0x0600C52D RID: 50477 RVA: 0x00B8F84C File Offset: 0x00B8DA4C
		// (set) Token: 0x0600C52E RID: 50478 RVA: 0x00B8F904 File Offset: 0x00B8DB04
		internal bool CnvPerConventionalChannelOptionsRxDPLInvert_A8909_HiddenStatic
		{
			get
			{
				short num = (short)652521214;
				short num2 = num;
				num = (short)1795075838;
				switch (num2 == num)
				{
				}
				num = (short)1968308224;
				short num3 = num;
				num = (short)195493888;
				if (num != 0)
				{
				}
				num = (short)2028077057;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsRxDPLInvert_A8909.HiddenStatic;
			}
			set
			{
				short num = (short)2114191361;
				if (num != 0)
				{
				}
				num = (short)1568984380;
				short num2 = num;
				num = (short)780979516;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1592000512;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)526188544;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsRxDPLInvert_A8909.HiddenStatic = value;
			}
		}

		// Token: 0x170062B8 RID: 25272
		// (get) Token: 0x0600C52F RID: 50479 RVA: 0x00B8F9B8 File Offset: 0x00B8DBB8
		// (set) Token: 0x0600C530 RID: 50480 RVA: 0x00B8FA70 File Offset: 0x00B8DC70
		internal bool CnvPerConventionalChannelOptionsRxDPLInvert_A8909_HiddenDynamic
		{
			get
			{
				short num = (short)1107169704;
				short num2 = num;
				num = (short)1223627176;
				switch (num2 == num)
				{
				}
				num = (short)1303379968;
				short num3 = num;
				num = (short)603652096;
				if (num != 0)
				{
				}
				num = (short)1330905089;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsRxDPLInvert_A8909.HiddenDynamic;
			}
			set
			{
				short num = (short)852191440;
				short num2 = num;
				num = (short)1446406352;
				switch (num2 == num)
				{
				}
				num = (short)1250754560;
				short num3 = num;
				num = (short)1220018176;
				if (num != 0)
				{
				}
				num = (short)457965569;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsRxDPLInvert_A8909.HiddenDynamic = value;
			}
		}

		// Token: 0x170062B9 RID: 25273
		// (get) Token: 0x0600C531 RID: 50481 RVA: 0x00B8FB24 File Offset: 0x00B8DD24
		public bool CnvPerConventionalChannelOptionsRxDPLInvert_A8909_HasDiffs
		{
			get
			{
				short num = (short)720605051;
				short num2 = num;
				num = (short)1169133435;
				switch (num2 == num)
				{
				}
				num = (short)1884356608;
				short num3 = num;
				num = (short)1212481537;
				if (num != 0)
				{
				}
				num = (short)2060648448;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsRxDPLInvert_A8909._HasDiffs;
			}
		}

		// Token: 0x170062BA RID: 25274
		// (get) Token: 0x0600C532 RID: 50482 RVA: 0x00B8FBD8 File Offset: 0x00B8DDD8
		// (set) Token: 0x0600C533 RID: 50483 RVA: 0x00B8FC8C File Offset: 0x00B8DE8C
		public int CnvPerConventionalChannelOptionsRxFrequency_A8911Value
		{
			get
			{
				short num = (short)88954268;
				short num2 = num;
				num = (short)951408028;
				switch (num2 == num)
				{
				}
				num = (short)1794703360;
				short num3 = num;
				num = (short)1399914497;
				if (num != 0)
				{
				}
				num = (short)1576140800;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsRxFrequency_A8911.Value;
			}
			set
			{
				short num = (short)1874488890;
				short num2 = num;
				num = (short)372928058;
				switch (num2 == num)
				{
				}
				num = (short)12517376;
				short num3 = num;
				num = (short)918683649;
				if (num != 0)
				{
				}
				num = (short)1194262528;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsRxFrequency_A8911.Value = value;
			}
		}

		// Token: 0x170062BB RID: 25275
		// (get) Token: 0x0600C534 RID: 50484 RVA: 0x00B8FD44 File Offset: 0x00B8DF44
		// (set) Token: 0x0600C535 RID: 50485 RVA: 0x00B8FDF4 File Offset: 0x00B8DFF4
		public string CnvPerConventionalChannelOptionsRxFrequency_A8911_UIValue
		{
			get
			{
				short num = (short)986403336;
				short num2 = num;
				num = (short)1204572680;
				switch (num2 == num)
				{
				}
				num = (short)1462697984;
				short num3 = num;
				num = (short)1866530817;
				if (num != 0)
				{
				}
				num = (short)743571456;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsRxFrequency_A8911.UIValue;
			}
			set
			{
				short num = (short)1775478090;
				short num2 = num;
				num = (short)1208657226;
				switch (num2 == num)
				{
				}
				num = (short)1801977856;
				short num3 = num;
				num = (short)1758527489;
				if (num != 0)
				{
				}
				num = (short)1521352704;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsRxFrequency_A8911.UIValue = value;
			}
		}

		// Token: 0x170062BC RID: 25276
		// (get) Token: 0x0600C536 RID: 50486 RVA: 0x00B8FEA8 File Offset: 0x00B8E0A8
		public global::AcpBusinessLayer.AcpFrequencyField CnvPerConventionalChannelOptionsRxFrequency_A8911
		{
			get
			{
				short num = (short)164380221;
				short num2 = num;
				num = (short)867909181;
				switch (num2 == num)
				{
				}
				num = (short)550633472;
				short num3 = num;
				num = (short)1832517633;
				if (num != 0)
				{
				}
				num = (short)544997376;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsRxFrequency_A8911;
			}
		}

		// Token: 0x170062BD RID: 25277
		// (get) Token: 0x0600C537 RID: 50487 RVA: 0x00B8FF58 File Offset: 0x00B8E158
		// (set) Token: 0x0600C538 RID: 50488 RVA: 0x00B9000C File Offset: 0x00B8E20C
		internal int CnvPerConventionalChannelOptionsRxFrequency_A8911Min
		{
			get
			{
				short num = (short)1231966865;
				short num2 = num;
				num = (short)33641105;
				switch (num2 == num)
				{
				}
				num = (short)1947729920;
				short num3 = num;
				num = (short)1532362753;
				if (num != 0)
				{
				}
				num = (short)1198129152;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsRxFrequency_A8911.Min;
			}
			set
			{
				short num = (short)400824098;
				short num2 = num;
				num = (short)62986018;
				switch (num2 == num)
				{
				}
				num = (short)1418985472;
				short num3 = num;
				num = (short)1651572736;
				if (num != 0)
				{
				}
				num = (short)1466368001;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsRxFrequency_A8911.Min = value;
			}
		}

		// Token: 0x170062BE RID: 25278
		// (get) Token: 0x0600C539 RID: 50489 RVA: 0x00B900C0 File Offset: 0x00B8E2C0
		// (set) Token: 0x0600C53A RID: 50490 RVA: 0x00B90174 File Offset: 0x00B8E374
		internal int CnvPerConventionalChannelOptionsRxFrequency_A8911Max
		{
			get
			{
				short num = (short)1496727252;
				short num2 = num;
				num = (short)418725588;
				switch (num2 == num)
				{
				}
				num = (short)801832960;
				short num3 = num;
				num = (short)527171585;
				if (num != 0)
				{
				}
				num = (short)2071003136;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsRxFrequency_A8911.Max;
			}
			set
			{
				short num = (short)1780285536;
				short num2 = num;
				num = (short)1557594208;
				switch (num2 == num)
				{
				}
				num = (short)309395456;
				short num3 = num;
				num = (short)151715841;
				if (num != 0)
				{
				}
				num = (short)849543168;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsRxFrequency_A8911.Max = value;
			}
		}

		// Token: 0x170062BF RID: 25279
		// (get) Token: 0x0600C53B RID: 50491 RVA: 0x00B9022C File Offset: 0x00B8E42C
		// (set) Token: 0x0600C53C RID: 50492 RVA: 0x00B902E0 File Offset: 0x00B8E4E0
		internal int CnvPerConventionalChannelOptionsRxFrequency_A8911Step
		{
			get
			{
				short num = (short)754958886;
				short num2 = num;
				num = (short)1751826982;
				switch (num2 == num)
				{
				}
				num = (short)1156186112;
				short num3 = num;
				num = (short)652541953;
				if (num != 0)
				{
				}
				num = (short)599916544;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsRxFrequency_A8911.StepSize;
			}
			set
			{
				short num = (short)2088130511;
				short num2 = num;
				num = (short)622680015;
				switch (num2 == num)
				{
				}
				num = (short)1647771648;
				short num3 = num;
				num = (short)146145281;
				if (num != 0)
				{
				}
				num = (short)1803288576;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsRxFrequency_A8911.StepSize = value;
			}
		}

		// Token: 0x170062C0 RID: 25280
		// (get) Token: 0x0600C53D RID: 50493 RVA: 0x00B90394 File Offset: 0x00B8E594
		// (set) Token: 0x0600C53E RID: 50494 RVA: 0x00B90444 File Offset: 0x00B8E644
		public bool CnvPerConventionalChannelOptionsRxFrequency_A8911_Applicable
		{
			get
			{
				short num = (short)1266686285;
				short num2 = num;
				num = (short)307435853;
				switch (num2 == num)
				{
				}
				num = (short)747241472;
				short num3 = num;
				num = (short)1443627009;
				if (num != 0)
				{
				}
				num = (short)658702336;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsRxFrequency_A8911.Applicable;
			}
			set
			{
				short num = (short)1204297224;
				short num2 = num;
				num = (short)1954684424;
				switch (num2 == num)
				{
				}
				num = (short)618004480;
				short num3 = num;
				num = (short)1942945792;
				if (num != 0)
				{
				}
				num = (short)1565655041;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsRxFrequency_A8911.Applicable = value;
			}
		}

		// Token: 0x170062C1 RID: 25281
		// (get) Token: 0x0600C53F RID: 50495 RVA: 0x00B904F8 File Offset: 0x00B8E6F8
		// (set) Token: 0x0600C540 RID: 50496 RVA: 0x00B905AC File Offset: 0x00B8E7AC
		public bool CnvPerConventionalChannelOptionsRxFrequency_A8911_Valid
		{
			get
			{
				short num = (short)598605824;
				short num2 = num;
				num = (short)1323977060;
				short num3 = num;
				num = (short)607144292;
				switch (num3 == num)
				{
				}
				num = (short)1270611969;
				if (num != 0)
				{
				}
				num = (short)593100800;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsRxFrequency_A8911.Valid;
			}
			set
			{
				short num = (short)783941632;
				short num2 = num;
				num = (short)272194312;
				short num3 = num;
				num = (short)1723554568;
				switch (num3 == num)
				{
				}
				num = (short)2096037889;
				if (num != 0)
				{
				}
				num = (short)1743192064;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsRxFrequency_A8911.Valid = value;
			}
		}

		// Token: 0x170062C2 RID: 25282
		// (get) Token: 0x0600C541 RID: 50497 RVA: 0x00B90664 File Offset: 0x00B8E864
		// (set) Token: 0x0600C542 RID: 50498 RVA: 0x00B90718 File Offset: 0x00B8E918
		public bool CnvPerConventionalChannelOptionsRxFrequency_A8911_Visible
		{
			get
			{
				short num = (short)1179516928;
				short num2 = num;
				num = (short)1223601489;
				short num3 = num;
				num = (short)1179233617;
				switch (num3 == num)
				{
				}
				num = (short)1273757696;
				if (num != 0)
				{
				}
				num = (short)1482686465;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsRxFrequency_A8911.Visible;
			}
			set
			{
				short num = (short)653524992;
				short num2 = num;
				num = (short)1238642886;
				short num3 = num;
				num = (short)1598304454;
				switch (num3 == num)
				{
				}
				num = (short)1339883521;
				if (num != 0)
				{
				}
				num = (short)823001088;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsRxFrequency_A8911.Visible = value;
			}
		}

		// Token: 0x170062C3 RID: 25283
		// (get) Token: 0x0600C543 RID: 50499 RVA: 0x00B907D0 File Offset: 0x00B8E9D0
		// (set) Token: 0x0600C544 RID: 50500 RVA: 0x00B90884 File Offset: 0x00B8EA84
		public bool CnvPerConventionalChannelOptionsRxFrequency_A8911_Editable
		{
			get
			{
				short num = (short)233439232;
				short num2 = num;
				num = (short)288129473;
				short num3 = num;
				num = (short)34111937;
				switch (num3 == num)
				{
				}
				num = (short)1425670144;
				if (num != 0)
				{
				}
				num = (short)233111553;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsRxFrequency_A8911.Editable;
			}
			set
			{
				short num = (short)1462763520;
				short num2 = num;
				num = (short)1722734195;
				short num3 = num;
				num = (short)290248307;
				switch (num3 == num)
				{
				}
				num = (short)916193281;
				if (num != 0)
				{
				}
				num = (short)953483264;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsRxFrequency_A8911.Editable = value;
			}
		}

		// Token: 0x170062C4 RID: 25284
		// (get) Token: 0x0600C545 RID: 50501 RVA: 0x00B90938 File Offset: 0x00B8EB38
		internal string CnvPerConventionalChannelOptionsRxFrequency_A8911_UILabel
		{
			get
			{
				short num = (short)942407680;
				short num2 = num;
				num = (short)619997326;
				short num3 = num;
				num = (short)1866557582;
				switch (num3 == num)
				{
				}
				num = (short)2052259841;
				if (num != 0)
				{
				}
				num = (short)202637312;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsRxFrequency_A8911.UIName;
			}
		}

		// Token: 0x170062C5 RID: 25285
		// (get) Token: 0x0600C546 RID: 50502 RVA: 0x00B909EC File Offset: 0x00B8EBEC
		// (set) Token: 0x0600C547 RID: 50503 RVA: 0x00B90AA0 File Offset: 0x00B8ECA0
		internal bool CnvPerConventionalChannelOptionsRxFrequency_A8911_HiddenStatic
		{
			get
			{
				short num = (short)1755381760;
				short num2 = num;
				num = (short)771658431;
				short num3 = num;
				num = (short)1357550271;
				switch (num3 == num)
				{
				}
				num = (short)127664128;
				if (num != 0)
				{
				}
				num = (short)1434255361;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsRxFrequency_A8911.HiddenStatic;
			}
			set
			{
				short num = (short)303824896;
				short num2 = num;
				num = (short)13698752;
				short num3 = num;
				num = (short)1803421376;
				switch (num3 == num)
				{
				}
				num = (short)96010241;
				if (num != 0)
				{
				}
				num = (short)757923840;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsRxFrequency_A8911.HiddenStatic = value;
			}
		}

		// Token: 0x170062C6 RID: 25286
		// (get) Token: 0x0600C548 RID: 50504 RVA: 0x00B90B54 File Offset: 0x00B8ED54
		// (set) Token: 0x0600C549 RID: 50505 RVA: 0x00B90C0C File Offset: 0x00B8EE0C
		internal bool CnvPerConventionalChannelOptionsRxFrequency_A8911_HiddenDynamic
		{
			get
			{
				short num = (short)1940324352;
				short num2 = num;
				num = (short)1415241896;
				short num3 = num;
				num = (short)1610473640;
				switch (num3 == num)
				{
				}
				num = (short)1463549952;
				if (num != 0)
				{
				}
				num = (short)1383071745;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsRxFrequency_A8911.HiddenDynamic;
			}
			set
			{
				short num = (short)1866596352;
				short num2 = num;
				num = (short)584558975;
				short num3 = num;
				num = (short)876915071;
				switch (num3 == num)
				{
				}
				num = (short)768671744;
				if (num != 0)
				{
				}
				num = (short)809893889;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsRxFrequency_A8911.HiddenDynamic = value;
			}
		}

		// Token: 0x170062C7 RID: 25287
		// (get) Token: 0x0600C54A RID: 50506 RVA: 0x00B90CC0 File Offset: 0x00B8EEC0
		public bool CnvPerConventionalChannelOptionsRxFrequency_A8911_HasDiffs
		{
			get
			{
				short num = (short)1686110208;
				short num2 = num;
				num = (short)1651727365;
				short num3 = num;
				num = (short)445144069;
				switch (num3 == num)
				{
				}
				num = (short)917766145;
				if (num != 0)
				{
				}
				num = (short)1018757120;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsRxFrequency_A8911._HasDiffs;
			}
		}

		// Token: 0x170062C8 RID: 25288
		// (get) Token: 0x0600C54B RID: 50507 RVA: 0x00B90D74 File Offset: 0x00B8EF74
		// (set) Token: 0x0600C54C RID: 50508 RVA: 0x00B90E24 File Offset: 0x00B8F024
		public int CnvPerConventionalChannelOptionsRxPLCode_A8917Value
		{
			get
			{
				short num = (short)1317666816;
				short num2 = num;
				num = (short)1230853227;
				short num3 = num;
				num = (short)178607211;
				switch (num3 == num)
				{
				}
				num = (short)835911681;
				if (num != 0)
				{
				}
				num = (short)1543962624;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsRxPLCode_A8917.Value;
			}
			set
			{
				short num = (short)725549056;
				short num2 = num;
				num = (short)1395130369;
				if (num != 0)
				{
				}
				num = (short)1621809676;
				short num3 = num;
				num = (short)1186847244;
				switch (num3 == num)
				{
				}
				num = (short)1634533376;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsRxPLCode_A8917.Value = value;
			}
		}

		// Token: 0x170062C9 RID: 25289
		// (get) Token: 0x0600C54D RID: 50509 RVA: 0x00B90ED8 File Offset: 0x00B8F0D8
		// (set) Token: 0x0600C54E RID: 50510 RVA: 0x00B90F90 File Offset: 0x00B8F190
		public string CnvPerConventionalChannelOptionsRxPLCode_A8917_UIValue
		{
			get
			{
				short num = (short)71303168;
				short num2 = num;
				num = (short)1395474656;
				short num3 = num;
				num = (short)1878671584;
				switch (num3 == num)
				{
				}
				num = (short)1894318080;
				if (num != 0)
				{
				}
				num = (short)1057751041;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsRxPLCode_A8917.UIValue;
			}
			set
			{
				short num = (short)1207107584;
				short num2 = num;
				num = (short)67172481;
				short num3 = num;
				num = (short)974911617;
				switch (num3 == num)
				{
				}
				num = (short)774111233;
				if (num != 0)
				{
				}
				num = (short)1899167744;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsRxPLCode_A8917.UIValue = value;
			}
		}

		// Token: 0x170062CA RID: 25290
		// (get) Token: 0x0600C54F RID: 50511 RVA: 0x00B91048 File Offset: 0x00B8F248
		public global::AcpBusinessLayer.AcpListField CnvPerConventionalChannelOptionsRxPLCode_A8917
		{
			get
			{
				short num = (short)1877803008;
				short num2 = num;
				num = (short)1734869493;
				short num3 = num;
				num = (short)651624949;
				switch (num3 == num)
				{
				}
				num = (short)996081664;
				if (num != 0)
				{
				}
				num = (short)350289921;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsRxPLCode_A8917;
			}
		}

		// Token: 0x170062CB RID: 25291
		// (get) Token: 0x0600C550 RID: 50512 RVA: 0x00B910F8 File Offset: 0x00B8F2F8
		// (set) Token: 0x0600C551 RID: 50513 RVA: 0x00B911AC File Offset: 0x00B8F3AC
		public bool CnvPerConventionalChannelOptionsRxPLCode_A8917_Applicable
		{
			get
			{
				short num = (short)1191706624;
				short num2 = num;
				num = (short)1994479129;
				short num3 = num;
				num = (short)1796757017;
				switch (num3 == num)
				{
				}
				num = (short)2035941377;
				if (num != 0)
				{
				}
				num = (short)2122645504;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsRxPLCode_A8917.Applicable;
			}
			set
			{
				short num = (short)950009856;
				short num2 = num;
				num = (short)1309343745;
				if (num != 0)
				{
				}
				num = (short)1236546111;
				short num3 = num;
				num = (short)1284321855;
				switch (num3 == num)
				{
				}
				num = (short)1376190464;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsRxPLCode_A8917.Applicable = value;
			}
		}

		// Token: 0x170062CC RID: 25292
		// (get) Token: 0x0600C552 RID: 50514 RVA: 0x00B91264 File Offset: 0x00B8F464
		// (set) Token: 0x0600C553 RID: 50515 RVA: 0x00B91318 File Offset: 0x00B8F518
		public bool CnvPerConventionalChannelOptionsRxPLCode_A8917_Valid
		{
			get
			{
				short num = (short)223805440;
				short num2 = num;
				num = (short)77946678;
				short num3 = num;
				num = (short)1820679990;
				switch (num3 == num)
				{
				}
				num = (short)377749505;
				if (num != 0)
				{
				}
				num = (short)395575296;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsRxPLCode_A8917.Valid;
			}
			set
			{
				short num = (short)262275072;
				short num2 = num;
				num = (short)1583874049;
				if (num != 0)
				{
				}
				num = (short)585796961;
				short num3 = num;
				num = (short)300191073;
				switch (num3 == num)
				{
				}
				num = (short)692977664;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsRxPLCode_A8917.Valid = value;
			}
		}

		// Token: 0x170062CD RID: 25293
		// (get) Token: 0x0600C554 RID: 50516 RVA: 0x00B913CC File Offset: 0x00B8F5CC
		// (set) Token: 0x0600C555 RID: 50517 RVA: 0x00B91480 File Offset: 0x00B8F680
		public bool CnvPerConventionalChannelOptionsRxPLCode_A8917_Visible
		{
			get
			{
				short num = (short)779616256;
				short num2 = num;
				num = (short)5460190;
				short num3 = num;
				num = (short)804081886;
				switch (num3 == num)
				{
				}
				num = (short)1107230721;
				if (num != 0)
				{
				}
				num = (short)338231296;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsRxPLCode_A8917.Visible;
			}
			set
			{
				short num = (short)150011904;
				short num2 = num;
				num = (short)1885187083;
				short num3 = num;
				num = (short)54045707;
				switch (num3 == num)
				{
				}
				num = (short)871956480;
				if (num != 0)
				{
				}
				num = (short)869466113;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsRxPLCode_A8917.Visible = value;
			}
		}

		// Token: 0x170062CE RID: 25294
		// (get) Token: 0x0600C556 RID: 50518 RVA: 0x00B91534 File Offset: 0x00B8F734
		// (set) Token: 0x0600C557 RID: 50519 RVA: 0x00B915E8 File Offset: 0x00B8F7E8
		public bool CnvPerConventionalChannelOptionsRxPLCode_A8917_Editable
		{
			get
			{
				short num = (short)398000128;
				short num2 = num;
				num = (short)2069227312;
				short num3 = num;
				num = (short)1950213936;
				switch (num3 == num)
				{
				}
				num = (short)1133838337;
				if (num != 0)
				{
				}
				num = (short)1294270464;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsRxPLCode_A8917.Editable;
			}
			set
			{
				short num = (short)1658650624;
				short num2 = num;
				num = (short)899600986;
				short num3 = num;
				num = (short)1238291034;
				switch (num3 == num)
				{
				}
				num = (short)811270145;
				if (num != 0)
				{
				}
				num = (short)691339264;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsRxPLCode_A8917.Editable = value;
			}
		}

		// Token: 0x170062CF RID: 25295
		// (get) Token: 0x0600C558 RID: 50520 RVA: 0x00B916A0 File Offset: 0x00B8F8A0
		internal string CnvPerConventionalChannelOptionsRxPLCode_A8917_UILabel
		{
			get
			{
				short num = (short)1488912384;
				short num2 = num;
				num = (short)2128269599;
				short num3 = num;
				num = (short)1536872735;
				switch (num3 == num)
				{
				}
				num = (short)1698496512;
				if (num != 0)
				{
				}
				num = (short)1848377345;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsRxPLCode_A8917.UIName;
			}
		}

		// Token: 0x170062D0 RID: 25296
		// (get) Token: 0x0600C559 RID: 50521 RVA: 0x00B91754 File Offset: 0x00B8F954
		// (set) Token: 0x0600C55A RID: 50522 RVA: 0x00B91808 File Offset: 0x00B8FA08
		internal bool CnvPerConventionalChannelOptionsRxPLCode_A8917_HiddenStatic
		{
			get
			{
				short num = (short)63242240;
				short num2 = num;
				num = (short)146795199;
				short num3 = num;
				num = (short)719841983;
				switch (num3 == num)
				{
				}
				num = (short)2076639232;
				if (num != 0)
				{
				}
				num = (short)1808531457;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsRxPLCode_A8917.HiddenStatic;
			}
			set
			{
				short num = (short)1606615040;
				short num2 = num;
				num = (short)1441267713;
				if (num != 0)
				{
				}
				num = (short)154768341;
				short num3 = num;
				num = (short)173773781;
				switch (num3 == num)
				{
				}
				num = (short)461635584;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsRxPLCode_A8917.HiddenStatic = value;
			}
		}

		// Token: 0x170062D1 RID: 25297
		// (get) Token: 0x0600C55B RID: 50523 RVA: 0x00B918BC File Offset: 0x00B8FABC
		// (set) Token: 0x0600C55C RID: 50524 RVA: 0x00B91970 File Offset: 0x00B8FB70
		internal bool CnvPerConventionalChannelOptionsRxPLCode_A8917_HiddenDynamic
		{
			get
			{
				short num = (short)1167654912;
				short num2 = num;
				num = (short)314948756;
				short num3 = num;
				num = (short)1786166420;
				switch (num3 == num)
				{
				}
				num = (short)1552482305;
				if (num != 0)
				{
				}
				num = (short)2069168128;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsRxPLCode_A8917.HiddenDynamic;
			}
			set
			{
				short num = (short)1289093120;
				short num2 = num;
				num = (short)224237984;
				short num3 = num;
				num = (short)1448188320;
				switch (num3 == num)
				{
				}
				num = (short)1872691201;
				if (num != 0)
				{
				}
				num = (short)1911488512;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsRxPLCode_A8917.HiddenDynamic = value;
			}
		}

		// Token: 0x170062D2 RID: 25298
		// (get) Token: 0x0600C55D RID: 50525 RVA: 0x00B91A28 File Offset: 0x00B8FC28
		public bool CnvPerConventionalChannelOptionsRxPLCode_A8917_HasDiffs
		{
			get
			{
				short num = (short)877723648;
				short num2 = num;
				num = (short)1178559829;
				short num3 = num;
				num = (short)83387733;
				switch (num3 == num)
				{
				}
				num = (short)832897025;
				if (num != 0)
				{
				}
				num = (short)381419520;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsRxPLCode_A8917._HasDiffs;
			}
		}

		// Token: 0x170062D3 RID: 25299
		// (get) Token: 0x0600C55E RID: 50526 RVA: 0x00B91ADC File Offset: 0x00B8FCDC
		// (set) Token: 0x0600C55F RID: 50527 RVA: 0x00B91B90 File Offset: 0x00B8FD90
		public int CnvPerConventionalChannelOptionsRxPLFreq_A8918Value
		{
			get
			{
				short num = (short)132841472;
				short num2 = num;
				num = (short)47779818;
				short num3 = num;
				num = (short)1654067178;
				switch (num3 == num)
				{
				}
				num = (short)2111700993;
				if (num != 0)
				{
				}
				num = (short)928448512;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsRxPLFreq_A8918.Value;
			}
			set
			{
				short num = (short)1812070400;
				short num2 = num;
				num = (short)659431050;
				short num3 = num;
				num = (short)114040458;
				switch (num3 == num)
				{
				}
				num = (short)910557185;
				if (num != 0)
				{
				}
				num = (short)1252786176;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsRxPLFreq_A8918.Value = value;
			}
		}

		// Token: 0x170062D4 RID: 25300
		// (get) Token: 0x0600C560 RID: 50528 RVA: 0x00B91C48 File Offset: 0x00B8FE48
		// (set) Token: 0x0600C561 RID: 50529 RVA: 0x00B91CFC File Offset: 0x00B8FEFC
		public string CnvPerConventionalChannelOptionsRxPLFreq_A8918_UIValue
		{
			get
			{
				short num = (short)245694464;
				short num2 = num;
				num = (short)1089511312;
				short num3 = num;
				num = (short)150183824;
				switch (num3 == num)
				{
				}
				num = (short)378077185;
				if (num != 0)
				{
				}
				num = (short)1348796416;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsRxPLFreq_A8918.UIValue;
			}
			set
			{
				short num = (short)1937440768;
				short num2 = num;
				num = (short)1703677219;
				short num3 = num;
				num = (short)728173859;
				switch (num3 == num)
				{
				}
				num = (short)850919424;
				if (num != 0)
				{
				}
				num = (short)242417665;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsRxPLFreq_A8918.UIValue = value;
			}
		}

		// Token: 0x170062D5 RID: 25301
		// (get) Token: 0x0600C562 RID: 50530 RVA: 0x00B91DB0 File Offset: 0x00B8FFB0
		public global::AcpBusinessLayer.AcpListField CnvPerConventionalChannelOptionsRxPLFreq_A8918
		{
			get
			{
				short num = (short)1832083769;
				short num2 = num;
				num = (short)612720953;
				switch (num2 == num)
				{
				}
				num = (short)1418723329;
				if (num != 0)
				{
				}
				num = (short)1756233728;
				short num3 = num;
				num = (short)1751449600;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsRxPLFreq_A8918;
			}
		}

		// Token: 0x170062D6 RID: 25302
		// (get) Token: 0x0600C563 RID: 50531 RVA: 0x00B91E5C File Offset: 0x00B9005C
		// (set) Token: 0x0600C564 RID: 50532 RVA: 0x00B91F14 File Offset: 0x00B90114
		public bool CnvPerConventionalChannelOptionsRxPLFreq_A8918_Applicable
		{
			get
			{
				short num = (short)605258023;
				short num2 = num;
				num = (short)1244692775;
				switch (num2 == num)
				{
				}
				num = (short)1905459200;
				if (num != 0)
				{
				}
				num = (short)1424031744;
				short num3 = num;
				num = (short)1749876737;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsRxPLFreq_A8918.Applicable;
			}
			set
			{
				short num = (short)1570242561;
				if (num != 0)
				{
				}
				num = (short)1910079032;
				short num2 = num;
				num = (short)1188003384;
				switch (num2 == num)
				{
				}
				num = (short)1022623744;
				short num3 = num;
				num = (short)85917696;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsRxPLFreq_A8918.Applicable = value;
			}
		}

		// Token: 0x170062D7 RID: 25303
		// (get) Token: 0x0600C565 RID: 50533 RVA: 0x00B91FCC File Offset: 0x00B901CC
		// (set) Token: 0x0600C566 RID: 50534 RVA: 0x00B92084 File Offset: 0x00B90284
		public bool CnvPerConventionalChannelOptionsRxPLFreq_A8918_Valid
		{
			get
			{
				short num = (short)706956154;
				short num2 = num;
				num = (short)529943418;
				switch (num2 == num)
				{
				}
				num = (short)926810113;
				if (num != 0)
				{
				}
				num = (short)1253179392;
				short num3 = num;
				num = (short)1218969600;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsRxPLFreq_A8918.Valid;
			}
			set
			{
				short num = (short)409942837;
				short num2 = num;
				num = (short)388840245;
				switch (num2 == num)
				{
				}
				num = (short)192806913;
				if (num != 0)
				{
				}
				num = (short)2076114944;
				short num3 = num;
				num = (short)1804599296;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsRxPLFreq_A8918.Valid = value;
			}
		}

		// Token: 0x170062D8 RID: 25304
		// (get) Token: 0x0600C567 RID: 50535 RVA: 0x00B92138 File Offset: 0x00B90338
		// (set) Token: 0x0600C568 RID: 50536 RVA: 0x00B921EC File Offset: 0x00B903EC
		public bool CnvPerConventionalChannelOptionsRxPLFreq_A8918_Visible
		{
			get
			{
				short num = (short)1501364289;
				short num2 = num;
				num = (short)604110913;
				switch (num2 == num)
				{
				}
				num = (short)1361969153;
				if (num != 0)
				{
				}
				num = (short)1363804160;
				short num3 = num;
				num = (short)1233649664;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsRxPLFreq_A8918.Visible;
			}
			set
			{
				short num = (short)1762720956;
				short num2 = num;
				num = (short)708377788;
				switch (num2 == num)
				{
				}
				num = (short)325058561;
				if (num != 0)
				{
				}
				num = (short)958791680;
				short num3 = num;
				num = (short)450363392;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsRxPLFreq_A8918.Visible = value;
			}
		}

		// Token: 0x170062D9 RID: 25305
		// (get) Token: 0x0600C569 RID: 50537 RVA: 0x00B922A0 File Offset: 0x00B904A0
		// (set) Token: 0x0600C56A RID: 50538 RVA: 0x00B92358 File Offset: 0x00B90558
		public bool CnvPerConventionalChannelOptionsRxPLFreq_A8918_Editable
		{
			get
			{
				short num = (short)1391611612;
				short num2 = num;
				num = (short)461197020;
				switch (num2 == num)
				{
				}
				num = (short)1558839297;
				if (num != 0)
				{
				}
				num = (short)2018574336;
				short num3 = num;
				num = (short)220004352;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsRxPLFreq_A8918.Editable;
			}
			set
			{
				short num = (short)1184927121;
				short num2 = num;
				num = (short)667323793;
				switch (num2 == num)
				{
				}
				num = (short)940572673;
				if (num != 0)
				{
				}
				num = (short)2062614528;
				short num3 = num;
				num = (short)1099759616;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsRxPLFreq_A8918.Editable = value;
			}
		}

		// Token: 0x170062DA RID: 25306
		// (get) Token: 0x0600C56B RID: 50539 RVA: 0x00B92410 File Offset: 0x00B90610
		internal string CnvPerConventionalChannelOptionsRxPLFreq_A8918_UILabel
		{
			get
			{
				short num = (short)189966473;
				short num2 = num;
				num = (short)1454876809;
				switch (num2 == num)
				{
				}
				num = (short)614072321;
				if (num != 0)
				{
				}
				num = (short)1737687040;
				short num3 = num;
				num = (short)1919287296;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsRxPLFreq_A8918.UIName;
			}
		}

		// Token: 0x170062DB RID: 25307
		// (get) Token: 0x0600C56C RID: 50540 RVA: 0x00B924C4 File Offset: 0x00B906C4
		// (set) Token: 0x0600C56D RID: 50541 RVA: 0x00B9257C File Offset: 0x00B9077C
		internal bool CnvPerConventionalChannelOptionsRxPLFreq_A8918_HiddenStatic
		{
			get
			{
				short num = (short)491080004;
				short num2 = num;
				num = (short)1412450628;
				switch (num2 == num)
				{
				}
				num = (short)787546113;
				if (num != 0)
				{
				}
				num = (short)1341980672;
				short num3 = num;
				num = (short)1828782080;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsRxPLFreq_A8918.HiddenStatic;
			}
			set
			{
				short num = (short)543943122;
				short num2 = num;
				num = (short)2091510226;
				switch (num2 == num)
				{
				}
				num = (short)272433153;
				if (num != 0)
				{
				}
				num = (short)701038592;
				short num3 = num;
				num = (short)1893335040;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsRxPLFreq_A8918.HiddenStatic = value;
			}
		}

		// Token: 0x170062DC RID: 25308
		// (get) Token: 0x0600C56E RID: 50542 RVA: 0x00B92634 File Offset: 0x00B90834
		// (set) Token: 0x0600C56F RID: 50543 RVA: 0x00B926E8 File Offset: 0x00B908E8
		internal bool CnvPerConventionalChannelOptionsRxPLFreq_A8918_HiddenDynamic
		{
			get
			{
				short num = (short)478574724;
				short num2 = num;
				num = (short)1909684356;
				switch (num2 == num)
				{
				}
				num = (short)843513857;
				if (num != 0)
				{
				}
				num = (short)1939537920;
				short num3 = num;
				num = (short)264568832;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsRxPLFreq_A8918.HiddenDynamic;
			}
			set
			{
				short num = (short)1564737537;
				if (num != 0)
				{
				}
				num = (short)1988548162;
				short num2 = num;
				num = (short)1960498754;
				switch (num2 == num)
				{
				}
				num = (short)401539072;
				short num3 = num;
				num = (short)436076544;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsRxPLFreq_A8918.HiddenDynamic = value;
			}
		}

		// Token: 0x170062DD RID: 25309
		// (get) Token: 0x0600C570 RID: 50544 RVA: 0x00B927A0 File Offset: 0x00B909A0
		public bool CnvPerConventionalChannelOptionsRxPLFreq_A8918_HasDiffs
		{
			get
			{
				short num = (short)1356547666;
				short num2 = num;
				num = (short)1533363794;
				switch (num2 == num)
				{
				}
				num = (short)1735655424;
				if (num != 0)
				{
				}
				num = (short)1541603328;
				short num3 = num;
				num = (short)776077313;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsRxPLFreq_A8918._HasDiffs;
			}
		}

		// Token: 0x170062DE RID: 25310
		// (get) Token: 0x0600C571 RID: 50545 RVA: 0x00B92854 File Offset: 0x00B90A54
		// (set) Token: 0x0600C572 RID: 50546 RVA: 0x00B92908 File Offset: 0x00B90B08
		public int CnvPerConventionalChannelOptionsRxSquelchType_A8919Value
		{
			get
			{
				short num = (short)1227161194;
				short num2 = num;
				num = (short)1073348202;
				switch (num2 == num)
				{
				}
				num = (short)1073283073;
				if (num != 0)
				{
				}
				num = (short)1374158848;
				short num3 = num;
				num = (short)1147994112;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsRxSquelchType_A8919.Value;
			}
			set
			{
				short num = (short)567738369;
				if (num != 0)
				{
				}
				num = (short)1522428941;
				short num2 = num;
				num = (short)2116709389;
				switch (num2 == num)
				{
				}
				num = (short)181075968;
				short num3 = num;
				num = (short)1694695424;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsRxSquelchType_A8919.Value = value;
			}
		}

		// Token: 0x170062DF RID: 25311
		// (get) Token: 0x0600C573 RID: 50547 RVA: 0x00B929BC File Offset: 0x00B90BBC
		// (set) Token: 0x0600C574 RID: 50548 RVA: 0x00B92A74 File Offset: 0x00B90C74
		public string CnvPerConventionalChannelOptionsRxSquelchType_A8919_UIValue
		{
			get
			{
				short num = (short)863774096;
				short num2 = num;
				num = (short)1022698896;
				switch (num2 == num)
				{
				}
				num = (short)98107393;
				if (num != 0)
				{
				}
				num = (short)2093219840;
				short num3 = num;
				num = (short)1657274368;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsRxSquelchType_A8919.UIValue;
			}
			set
			{
				short num = (short)1676392983;
				short num2 = num;
				num = (short)1126873623;
				switch (num2 == num)
				{
				}
				num = (short)1132527617;
				if (num != 0)
				{
				}
				num = (short)887750656;
				short num3 = num;
				num = (short)571408384;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsRxSquelchType_A8919.UIValue = value;
			}
		}

		// Token: 0x170062E0 RID: 25312
		// (get) Token: 0x0600C575 RID: 50549 RVA: 0x00B92B28 File Offset: 0x00B90D28
		public global::AcpBusinessLayer.AcpListField CnvPerConventionalChannelOptionsRxSquelchType_A8919
		{
			get
			{
				short num = (short)1075220647;
				short num2 = num;
				num = (short)1636012199;
				switch (num2 == num)
				{
				}
				num = (short)167116800;
				if (num != 0)
				{
				}
				num = (short)1178140672;
				short num3 = num;
				num = (short)1121452033;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsRxSquelchType_A8919;
			}
		}

		// Token: 0x170062E1 RID: 25313
		// (get) Token: 0x0600C576 RID: 50550 RVA: 0x00B92BD8 File Offset: 0x00B90DD8
		// (set) Token: 0x0600C577 RID: 50551 RVA: 0x00B92C8C File Offset: 0x00B90E8C
		public bool CnvPerConventionalChannelOptionsRxSquelchType_A8919_Applicable
		{
			get
			{
				short num = (short)2049505413;
				short num2 = num;
				num = (short)532805765;
				switch (num2 == num)
				{
				}
				num = (short)1554972673;
				if (num != 0)
				{
				}
				num = (short)238682112;
				short num3 = num;
				num = (short)1810628608;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsRxSquelchType_A8919.Applicable;
			}
			set
			{
				short num = (short)366128892;
				short num2 = num;
				num = (short)263565052;
				switch (num2 == num)
				{
				}
				num = (short)1688535041;
				if (num != 0)
				{
				}
				num = (short)1810759680;
				short num3 = num;
				num = (short)747831296;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsRxSquelchType_A8919.Applicable = value;
			}
		}

		// Token: 0x170062E2 RID: 25314
		// (get) Token: 0x0600C578 RID: 50552 RVA: 0x00B92D40 File Offset: 0x00B90F40
		// (set) Token: 0x0600C579 RID: 50553 RVA: 0x00B92DF4 File Offset: 0x00B90FF4
		public bool CnvPerConventionalChannelOptionsRxSquelchType_A8919_Valid
		{
			get
			{
				short num = (short)148293152;
				short num2 = num;
				num = (short)111986208;
				switch (num2 == num)
				{
				}
				num = (short)1090912256;
				if (num != 0)
				{
				}
				num = (short)747962368;
				short num3 = num;
				num = (short)136118273;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsRxSquelchType_A8919.Valid;
			}
			set
			{
				short num = (short)1631805035;
				short num2 = num;
				num = (short)304701035;
				switch (num2 == num)
				{
				}
				num = (short)1502019585;
				if (num != 0)
				{
				}
				num = (short)1484783616;
				short num3 = num;
				num = (short)205258752;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsRxSquelchType_A8919.Valid = value;
			}
		}

		// Token: 0x170062E3 RID: 25315
		// (get) Token: 0x0600C57A RID: 50554 RVA: 0x00B92EAC File Offset: 0x00B910AC
		// (set) Token: 0x0600C57B RID: 50555 RVA: 0x00B92F60 File Offset: 0x00B91160
		public bool CnvPerConventionalChannelOptionsRxSquelchType_A8919_Visible
		{
			get
			{
				short num = (short)1407758498;
				short num2 = num;
				num = (short)579317922;
				switch (num2 == num)
				{
				}
				num = (short)818216960;
				if (num != 0)
				{
				}
				num = (short)698548224;
				short num3 = num;
				num = (short)1582432257;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsRxSquelchType_A8919.Visible;
			}
			set
			{
				short num = (short)670034867;
				short num2 = num;
				num = (short)480504755;
				switch (num2 == num)
				{
				}
				num = (short)55181312;
				if (num != 0)
				{
				}
				num = (short)36372480;
				short num3 = num;
				num = (short)1123876865;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsRxSquelchType_A8919.Visible = value;
			}
		}

		// Token: 0x170062E4 RID: 25316
		// (get) Token: 0x0600C57C RID: 50556 RVA: 0x00B93018 File Offset: 0x00B91218
		// (set) Token: 0x0600C57D RID: 50557 RVA: 0x00B930D0 File Offset: 0x00B912D0
		public bool CnvPerConventionalChannelOptionsRxSquelchType_A8919_Editable
		{
			get
			{
				short num = (short)568775865;
				short num2 = num;
				num = (short)1867699385;
				switch (num2 == num)
				{
				}
				num = (short)1668349953;
				if (num != 0)
				{
				}
				num = (short)1680670720;
				short num3 = num;
				num = (short)1359151104;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsRxSquelchType_A8919.Editable;
			}
			set
			{
				short num = (short)2057754154;
				short num2 = num;
				num = (short)1551947306;
				switch (num2 == num)
				{
				}
				num = (short)1153171457;
				if (num != 0)
				{
				}
				num = (short)33488896;
				short num3 = num;
				num = (short)1934295040;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsRxSquelchType_A8919.Editable = value;
			}
		}

		// Token: 0x170062E5 RID: 25317
		// (get) Token: 0x0600C57E RID: 50558 RVA: 0x00B93188 File Offset: 0x00B91388
		internal string CnvPerConventionalChannelOptionsRxSquelchType_A8919_UILabel
		{
			get
			{
				short num = (short)937782559;
				short num2 = num;
				num = (short)175336735;
				switch (num2 == num)
				{
				}
				num = (short)1054408704;
				if (num != 0)
				{
				}
				num = (short)1719861248;
				short num3 = num;
				num = (short)1794506753;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsRxSquelchType_A8919.UIName;
			}
		}

		// Token: 0x170062E6 RID: 25318
		// (get) Token: 0x0600C57F RID: 50559 RVA: 0x00B9323C File Offset: 0x00B9143C
		// (set) Token: 0x0600C580 RID: 50560 RVA: 0x00B932F0 File Offset: 0x00B914F0
		internal bool CnvPerConventionalChannelOptionsRxSquelchType_A8919_HiddenStatic
		{
			get
			{
				short num = (short)1844804435;
				short num2 = num;
				num = (short)1433697107;
				switch (num2 == num)
				{
				}
				num = (short)1340669953;
				if (num != 0)
				{
				}
				num = (short)2088697856;
				short num3 = num;
				num = (short)1149960192;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsRxSquelchType_A8919.HiddenStatic;
			}
			set
			{
				short num = (short)916494740;
				short num2 = num;
				num = (short)1339267476;
				switch (num2 == num)
				{
				}
				num = (short)102891521;
				if (num != 0)
				{
				}
				num = (short)899547136;
				short num3 = num;
				num = (short)1452015616;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsRxSquelchType_A8919.HiddenStatic = value;
			}
		}

		// Token: 0x170062E7 RID: 25319
		// (get) Token: 0x0600C581 RID: 50561 RVA: 0x00B933A4 File Offset: 0x00B915A4
		// (set) Token: 0x0600C582 RID: 50562 RVA: 0x00B9345C File Offset: 0x00B9165C
		internal bool CnvPerConventionalChannelOptionsRxSquelchType_A8919_HiddenDynamic
		{
			get
			{
				short num = (short)965754235;
				short num2 = num;
				num = (short)1168653691;
				switch (num2 == num)
				{
				}
				num = (short)2049179649;
				if (num != 0)
				{
				}
				num = (short)645201920;
				short num3 = num;
				num = (short)97255424;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsRxSquelchType_A8919.HiddenDynamic;
			}
			set
			{
				short num = (short)1168422106;
				short num2 = num;
				num = (short)1718531290;
				switch (num2 == num)
				{
				}
				num = (short)1313013761;
				if (num != 0)
				{
				}
				num = (short)412549120;
				short num3 = num;
				num = (short)546111488;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsRxSquelchType_A8919.HiddenDynamic = value;
			}
		}

		// Token: 0x170062E8 RID: 25320
		// (get) Token: 0x0600C583 RID: 50563 RVA: 0x00B93514 File Offset: 0x00B91714
		public bool CnvPerConventionalChannelOptionsRxSquelchType_A8919_HasDiffs
		{
			get
			{
				short num = (short)374538241;
				if (num != 0)
				{
				}
				num = (short)2057817321;
				short num2 = num;
				num = (short)1115933929;
				switch (num2 == num)
				{
				}
				num = (short)68812800;
				short num3 = num;
				num = (short)427032576;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsRxSquelchType_A8919._HasDiffs;
			}
		}

		// Token: 0x170062E9 RID: 25321
		// (get) Token: 0x0600C584 RID: 50564 RVA: 0x00B935C8 File Offset: 0x00B917C8
		// (set) Token: 0x0600C585 RID: 50565 RVA: 0x00B93678 File Offset: 0x00B91878
		public int CnvPerConventionalChannelOptionsRxNetworkID_A9023Value
		{
			get
			{
				short num = (short)1642454950;
				short num2 = num;
				num = (short)1144840102;
				switch (num2 == num)
				{
				}
				num = (short)1649541121;
				if (num != 0)
				{
				}
				num = (short)962461696;
				short num3 = num;
				num = (short)178061312;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsRxNetworkID_A9023.Value;
			}
			set
			{
				short num = (short)959084378;
				short num2 = num;
				num = (short)521566042;
				switch (num2 == num)
				{
				}
				num = (short)477364225;
				if (num != 0)
				{
				}
				num = (short)1872887808;
				short num3 = num;
				num = (short)813105152;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsRxNetworkID_A9023.Value = value;
			}
		}

		// Token: 0x170062EA RID: 25322
		// (get) Token: 0x0600C586 RID: 50566 RVA: 0x00B93730 File Offset: 0x00B91930
		public global::AcpBusinessLayer.AcpSimpleRangeField CnvPerConventionalChannelOptionsRxNetworkID_A9023
		{
			get
			{
				short num = (short)1258128317;
				short num2 = num;
				num = (short)597722045;
				switch (num2 == num)
				{
				}
				num = (short)1650524160;
				if (num != 0)
				{
				}
				num = (short)229900288;
				short num3 = num;
				num = (short)189202433;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsRxNetworkID_A9023;
			}
		}

		// Token: 0x170062EB RID: 25323
		// (get) Token: 0x0600C587 RID: 50567 RVA: 0x00B937E0 File Offset: 0x00B919E0
		// (set) Token: 0x0600C588 RID: 50568 RVA: 0x00B93898 File Offset: 0x00B91A98
		public string CnvPerConventionalChannelOptionsRxNetworkID_A9023_UIValue
		{
			get
			{
				short num = (short)1762263041;
				if (num != 0)
				{
				}
				num = (short)89459358;
				short num2 = num;
				num = (short)496241310;
				switch (num2 == num)
				{
				}
				num = (short)992149504;
				short num3 = num;
				num = (short)1520500736;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsRxNetworkID_A9023.UIValue;
			}
			set
			{
				short num = (short)1478162185;
				short num2 = num;
				num = (short)254211849;
				switch (num2 == num)
				{
				}
				num = (short)1157758976;
				if (num != 0)
				{
				}
				num = (short)1284308992;
				short num3 = num;
				num = (short)2047737857;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsRxNetworkID_A9023.UIValue = value;
			}
		}

		// Token: 0x170062EC RID: 25324
		// (get) Token: 0x0600C589 RID: 50569 RVA: 0x00B9394C File Offset: 0x00B91B4C
		// (set) Token: 0x0600C58A RID: 50570 RVA: 0x00B93A04 File Offset: 0x00B91C04
		public string CnvPerConventionalChannelOptionsRxNetworkID_A9023_HexUIValue
		{
			get
			{
				short num = (short)1396399861;
				short num2 = num;
				num = (short)364994293;
				switch (num2 == num)
				{
				}
				num = (short)2032795649;
				if (num != 0)
				{
				}
				num = (short)1043726336;
				short num3 = num;
				num = (short)574947328;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsRxNetworkID_A9023.HexUIValue;
			}
			set
			{
				short num = (short)583766181;
				short num2 = num;
				num = (short)455184549;
				switch (num2 == num)
				{
				}
				num = (short)1728184321;
				if (num != 0)
				{
				}
				num = (short)710934528;
				short num3 = num;
				num = (short)733872128;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsRxNetworkID_A9023.HexUIValue = value;
			}
		}

		// Token: 0x170062ED RID: 25325
		// (get) Token: 0x0600C58B RID: 50571 RVA: 0x00B93ABC File Offset: 0x00B91CBC
		// (set) Token: 0x0600C58C RID: 50572 RVA: 0x00B93B70 File Offset: 0x00B91D70
		internal int CnvPerConventionalChannelOptionsRxNetworkID_A9023Min
		{
			get
			{
				short num = (short)1225916929;
				short num2 = num;
				num = (short)82313729;
				switch (num2 == num)
				{
				}
				num = (short)1512636417;
				if (num != 0)
				{
				}
				num = (short)176488448;
				short num3 = num;
				num = (short)362872832;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsRxNetworkID_A9023.Min;
			}
			set
			{
				short num = (short)855580282;
				short num2 = num;
				num = (short)515317370;
				switch (num2 == num)
				{
				}
				num = (short)1387069441;
				if (num != 0)
				{
				}
				num = (short)262668288;
				short num3 = num;
				num = (short)2137194496;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsRxNetworkID_A9023.Min = value;
			}
		}

		// Token: 0x170062EE RID: 25326
		// (get) Token: 0x0600C58D RID: 50573 RVA: 0x00B93C28 File Offset: 0x00B91E28
		// (set) Token: 0x0600C58E RID: 50574 RVA: 0x00B93CE0 File Offset: 0x00B91EE0
		internal int CnvPerConventionalChannelOptionsRxNetworkID_A9023Max
		{
			get
			{
				short num = (short)478494375;
				short num2 = num;
				num = (short)1011433127;
				switch (num2 == num)
				{
				}
				num = (short)1615921153;
				if (num != 0)
				{
				}
				num = (short)946798592;
				short num3 = num;
				num = (short)981860352;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsRxNetworkID_A9023.Max;
			}
			set
			{
				short num = (short)1819279361;
				if (num != 0)
				{
				}
				num = (short)118655254;
				short num2 = num;
				num = (short)1612810518;
				switch (num2 == num)
				{
				}
				num = (short)2143354880;
				short num3 = num;
				num = (short)1344274432;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsRxNetworkID_A9023.Max = value;
			}
		}

		// Token: 0x170062EF RID: 25327
		// (get) Token: 0x0600C58F RID: 50575 RVA: 0x00B93D98 File Offset: 0x00B91F98
		// (set) Token: 0x0600C590 RID: 50576 RVA: 0x00B93E50 File Offset: 0x00B92050
		internal int CnvPerConventionalChannelOptionsRxNetworkID_A9023Step
		{
			get
			{
				short num = (short)775612236;
				short num2 = num;
				num = (short)1264707404;
				switch (num2 == num)
				{
				}
				num = (short)770834433;
				if (num != 0)
				{
				}
				num = (short)1830748160;
				short num3 = num;
				num = (short)886046720;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsRxNetworkID_A9023.StepSize;
			}
			set
			{
				short num = (short)1723888187;
				short num2 = num;
				num = (short)80769595;
				switch (num2 == num)
				{
				}
				num = (short)1447559169;
				if (num != 0)
				{
				}
				num = (short)523042816;
				short num3 = num;
				num = (short)2099314688;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsRxNetworkID_A9023.StepSize = value;
			}
		}

		// Token: 0x170062F0 RID: 25328
		// (get) Token: 0x0600C591 RID: 50577 RVA: 0x00B93F08 File Offset: 0x00B92108
		// (set) Token: 0x0600C592 RID: 50578 RVA: 0x00B93FC0 File Offset: 0x00B921C0
		public bool CnvPerConventionalChannelOptionsRxNetworkID_A9023_Applicable
		{
			get
			{
				short num = (short)774242305;
				if (num != 0)
				{
				}
				num = (short)479706514;
				short num2 = num;
				num = (short)1723973010;
				switch (num2 == num)
				{
				}
				num = (short)314900480;
				short num3 = num;
				num = (short)723648512;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsRxNetworkID_A9023.Applicable;
			}
			set
			{
				short num = (short)934639169;
				short num2 = num;
				num = (short)639858241;
				switch (num2 == num)
				{
				}
				num = (short)1875378176;
				if (num != 0)
				{
				}
				num = (short)2065170432;
				short num3 = num;
				num = (short)1559822337;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsRxNetworkID_A9023.Applicable = value;
			}
		}

		// Token: 0x170062F1 RID: 25329
		// (get) Token: 0x0600C593 RID: 50579 RVA: 0x00B94074 File Offset: 0x00B92274
		// (set) Token: 0x0600C594 RID: 50580 RVA: 0x00B94128 File Offset: 0x00B92328
		public bool CnvPerConventionalChannelOptionsRxNetworkID_A9023_Valid
		{
			get
			{
				short num = (short)2132777782;
				short num2 = num;
				num = (short)1075682102;
				switch (num2 == num)
				{
				}
				num = (short)646905857;
				if (num != 0)
				{
				}
				num = (short)1095499776;
				short num3 = num;
				num = (short)730267648;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsRxNetworkID_A9023.Valid;
			}
			set
			{
				short num = (short)1220671815;
				short num2 = num;
				num = (short)795212103;
				switch (num2 == num)
				{
				}
				num = (short)582746113;
				if (num != 0)
				{
				}
				num = (short)565575680;
				short num3 = num;
				num = (short)482017280;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsRxNetworkID_A9023.Valid = value;
			}
		}

		// Token: 0x170062F2 RID: 25330
		// (get) Token: 0x0600C595 RID: 50581 RVA: 0x00B941E0 File Offset: 0x00B923E0
		// (set) Token: 0x0600C596 RID: 50582 RVA: 0x00B94298 File Offset: 0x00B92498
		public bool CnvPerConventionalChannelOptionsRxNetworkID_A9023_Visible
		{
			get
			{
				short num = (short)1856831489;
				if (num != 0)
				{
				}
				num = (short)1261627993;
				short num2 = num;
				num = (short)1655761497;
				switch (num2 == num)
				{
				}
				num = (short)163643392;
				short num3 = num;
				num = (short)1828126720;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsRxNetworkID_A9023.Visible;
			}
			set
			{
				short num = (short)1385168897;
				if (num != 0)
				{
				}
				num = (short)289694835;
				short num2 = num;
				num = (short)907961459;
				switch (num2 == num)
				{
				}
				num = (short)8060928;
				short num3 = num;
				num = (short)634716160;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsRxNetworkID_A9023.Visible = value;
			}
		}

		// Token: 0x170062F3 RID: 25331
		// (get) Token: 0x0600C597 RID: 50583 RVA: 0x00B94350 File Offset: 0x00B92550
		// (set) Token: 0x0600C598 RID: 50584 RVA: 0x00B94404 File Offset: 0x00B92604
		public bool CnvPerConventionalChannelOptionsRxNetworkID_A9023_Editable
		{
			get
			{
				short num = (short)64360169;
				short num2 = num;
				num = (short)207490793;
				switch (num2 == num)
				{
				}
				num = (short)2128936961;
				if (num != 0)
				{
				}
				num = (short)1146159104;
				short num3 = num;
				num = (short)2077556736;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsRxNetworkID_A9023.Editable;
			}
			set
			{
				short num = (short)156308637;
				short num2 = num;
				num = (short)1162679453;
				switch (num2 == num)
				{
				}
				num = (short)1210646529;
				if (num != 0)
				{
				}
				num = (short)1911554048;
				short num3 = num;
				num = (short)1119748096;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsRxNetworkID_A9023.Editable = value;
			}
		}

		// Token: 0x170062F4 RID: 25332
		// (get) Token: 0x0600C599 RID: 50585 RVA: 0x00B944BC File Offset: 0x00B926BC
		internal string CnvPerConventionalChannelOptionsRxNetworkID_A9023_UILabel
		{
			get
			{
				short num = (short)1890366013;
				short num2 = num;
				num = (short)1717875261;
				switch (num2 == num)
				{
				}
				num = (short)2049114113;
				if (num != 0)
				{
				}
				num = (short)502267904;
				short num3 = num;
				num = (short)1321598976;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsRxNetworkID_A9023.UIName;
			}
		}

		// Token: 0x170062F5 RID: 25333
		// (get) Token: 0x0600C59A RID: 50586 RVA: 0x00B94570 File Offset: 0x00B92770
		// (set) Token: 0x0600C59B RID: 50587 RVA: 0x00B94624 File Offset: 0x00B92824
		internal bool CnvPerConventionalChannelOptionsRxNetworkID_A9023_HiddenStatic
		{
			get
			{
				short num = (short)1177860870;
				short num2 = num;
				num = (short)1291369222;
				switch (num2 == num)
				{
				}
				num = (short)710737921;
				if (num != 0)
				{
				}
				num = (short)499056640;
				short num3 = num;
				num = (short)1814495232;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsRxNetworkID_A9023.HiddenStatic;
			}
			set
			{
				short num = (short)442441677;
				short num2 = num;
				num = (short)1095180237;
				switch (num2 == num)
				{
				}
				num = (short)1600520192;
				if (num != 0)
				{
				}
				num = (short)1125974016;
				short num3 = num;
				num = (short)1963917313;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsRxNetworkID_A9023.HiddenStatic = value;
			}
		}

		// Token: 0x170062F6 RID: 25334
		// (get) Token: 0x0600C59C RID: 50588 RVA: 0x00B946D4 File Offset: 0x00B928D4
		// (set) Token: 0x0600C59D RID: 50589 RVA: 0x00B94788 File Offset: 0x00B92988
		internal bool CnvPerConventionalChannelOptionsRxNetworkID_A9023_HiddenDynamic
		{
			get
			{
				short num = (short)876452568;
				short num2 = num;
				num = (short)1011325656;
				switch (num2 == num)
				{
				}
				num = (short)1830289409;
				if (num != 0)
				{
				}
				num = (short)682098688;
				short num3 = num;
				num = (short)775880704;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsRxNetworkID_A9023.HiddenDynamic;
			}
			set
			{
				short num = (short)2080198530;
				short num2 = num;
				num = (short)781078402;
				switch (num2 == num)
				{
				}
				num = (short)647036929;
				if (num != 0)
				{
				}
				num = (short)157679616;
				short num3 = num;
				num = (short)1288437760;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsRxNetworkID_A9023.HiddenDynamic = value;
			}
		}

		// Token: 0x170062F7 RID: 25335
		// (get) Token: 0x0600C59E RID: 50590 RVA: 0x00B9483C File Offset: 0x00B92A3C
		public bool CnvPerConventionalChannelOptionsRxNetworkID_A9023_HasDiffs
		{
			get
			{
				short num = (short)360131463;
				short num2 = num;
				num = (short)1459760007;
				switch (num2 == num)
				{
				}
				num = (short)1125253121;
				if (num != 0)
				{
				}
				num = (short)1112866816;
				short num3 = num;
				num = (short)1158610944;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsRxNetworkID_A9023._HasDiffs;
			}
		}

		// Token: 0x170062F8 RID: 25336
		// (get) Token: 0x0600C59F RID: 50591 RVA: 0x00B948F4 File Offset: 0x00B92AF4
		// (set) Token: 0x0600C5A0 RID: 50592 RVA: 0x00B949A8 File Offset: 0x00B92BA8
		public bool CnvPerConventionalChannelOptionsDirectTalkaround_A9255Value
		{
			get
			{
				short num = (short)864429713;
				short num2 = num;
				num = (short)1002251921;
				switch (num2 == num)
				{
				}
				num = (short)339345409;
				if (num != 0)
				{
				}
				num = (short)1759248384;
				short num3 = num;
				num = (short)1911750656;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsDirectTalkaround_A9255.Value;
			}
			set
			{
				short num = (short)1080615356;
				short num2 = num;
				num = (short)1233183164;
				switch (num2 == num)
				{
				}
				num = (short)1623457792;
				if (num != 0)
				{
				}
				num = (short)1027276800;
				short num3 = num;
				num = (short)1111556097;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsDirectTalkaround_A9255.Value = value;
			}
		}

		// Token: 0x170062F9 RID: 25337
		// (get) Token: 0x0600C5A1 RID: 50593 RVA: 0x00B94A60 File Offset: 0x00B92C60
		public global::AcpBusinessLayer.AcpField<bool> CnvPerConventionalChannelOptionsDirectTalkaround_A9255
		{
			get
			{
				short num = (short)234033725;
				short num2 = num;
				num = (short)17633853;
				switch (num2 == num)
				{
				}
				num = (short)28246017;
				if (num != 0)
				{
				}
				num = (short)1759182848;
				short num3 = num;
				num = (short)546504704;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsDirectTalkaround_A9255;
			}
		}

		// Token: 0x170062FA RID: 25338
		// (get) Token: 0x0600C5A2 RID: 50594 RVA: 0x00B94B10 File Offset: 0x00B92D10
		// (set) Token: 0x0600C5A3 RID: 50595 RVA: 0x00B94BC8 File Offset: 0x00B92DC8
		public bool CnvPerConventionalChannelOptionsDirectTalkaround_A9255_UIValue
		{
			get
			{
				short num = (short)736034817;
				if (num != 0)
				{
				}
				num = (short)812650228;
				short num2 = num;
				num = (short)1881804532;
				switch (num2 == num)
				{
				}
				num = (short)1779957760;
				short num3 = num;
				num = (short)457900032;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsDirectTalkaround_A9255.Value;
			}
			set
			{
				short num = (short)908725193;
				short num2 = num;
				num = (short)4590537;
				switch (num2 == num)
				{
				}
				num = (short)1446969345;
				if (num != 0)
				{
				}
				num = (short)1349058560;
				if (num != 0)
				{
				}
				num = (short)554893312;
				short num3 = num;
				this.cnvPerConventionalChannelOptionsDirectTalkaround_A9255.Value = value;
			}
		}

		// Token: 0x170062FB RID: 25339
		// (get) Token: 0x0600C5A4 RID: 50596 RVA: 0x00B94C80 File Offset: 0x00B92E80
		// (set) Token: 0x0600C5A5 RID: 50597 RVA: 0x00B94D34 File Offset: 0x00B92F34
		public bool CnvPerConventionalChannelOptionsDirectTalkaround_A9255_Applicable
		{
			get
			{
				short num = (short)1664234743;
				short num2 = num;
				num = (short)1895183607;
				switch (num2 == num)
				{
				}
				num = (short)1957363713;
				if (num != 0)
				{
				}
				num = (short)1000407040;
				if (num != 0)
				{
				}
				num = (short)297861120;
				short num3 = num;
				return this.cnvPerConventionalChannelOptionsDirectTalkaround_A9255.Applicable;
			}
			set
			{
				short num = (short)218540955;
				short num2 = num;
				num = (short)1217702811;
				switch (num2 == num)
				{
				}
				num = (short)1244790785;
				if (num != 0)
				{
				}
				num = (short)309854208;
				if (num != 0)
				{
				}
				num = (short)1013186560;
				short num3 = num;
				this.cnvPerConventionalChannelOptionsDirectTalkaround_A9255.Applicable = value;
			}
		}

		// Token: 0x170062FC RID: 25340
		// (get) Token: 0x0600C5A6 RID: 50598 RVA: 0x00B94DE8 File Offset: 0x00B92FE8
		// (set) Token: 0x0600C5A7 RID: 50599 RVA: 0x00B94EA0 File Offset: 0x00B930A0
		public bool CnvPerConventionalChannelOptionsDirectTalkaround_A9255_Valid
		{
			get
			{
				short num = (short)1573975707;
				short num2 = num;
				num = (short)794031771;
				switch (num2 == num)
				{
				}
				num = (short)2136014848;
				if (num != 0)
				{
				}
				num = (short)1178402817;
				if (num != 0)
				{
				}
				num = (short)1725628416;
				short num3 = num;
				return this.cnvPerConventionalChannelOptionsDirectTalkaround_A9255.Valid;
			}
			set
			{
				short num = (short)1259917048;
				short num2 = num;
				num = (short)788582136;
				switch (num2 == num)
				{
				}
				num = (short)1635516417;
				if (num != 0)
				{
				}
				num = (short)1261240320;
				if (num != 0)
				{
				}
				num = (short)1648033792;
				short num3 = num;
				this.cnvPerConventionalChannelOptionsDirectTalkaround_A9255.Valid = value;
			}
		}

		// Token: 0x170062FD RID: 25341
		// (get) Token: 0x0600C5A8 RID: 50600 RVA: 0x00B94F54 File Offset: 0x00B93154
		// (set) Token: 0x0600C5A9 RID: 50601 RVA: 0x00B9500C File Offset: 0x00B9320C
		public bool CnvPerConventionalChannelOptionsDirectTalkaround_A9255_Visible
		{
			get
			{
				short num = (short)599292589;
				short num2 = num;
				num = (short)1269463725;
				switch (num2 == num)
				{
				}
				num = (short)878116865;
				if (num != 0)
				{
				}
				num = (short)1672478720;
				if (num != 0)
				{
				}
				num = (short)837746688;
				short num3 = num;
				return this.cnvPerConventionalChannelOptionsDirectTalkaround_A9255.Visible;
			}
			set
			{
				short num = (short)204275713;
				if (num != 0)
				{
				}
				num = (short)1893622127;
				short num2 = num;
				num = (short)1234985327;
				switch (num2 == num)
				{
				}
				num = (short)383778816;
				if (num != 0)
				{
				}
				num = (short)841547776;
				short num3 = num;
				this.cnvPerConventionalChannelOptionsDirectTalkaround_A9255.Visible = value;
			}
		}

		// Token: 0x170062FE RID: 25342
		// (get) Token: 0x0600C5AA RID: 50602 RVA: 0x00B950C0 File Offset: 0x00B932C0
		// (set) Token: 0x0600C5AB RID: 50603 RVA: 0x00B95174 File Offset: 0x00B93374
		public bool CnvPerConventionalChannelOptionsDirectTalkaround_A9255_Editable
		{
			get
			{
				short num = (short)108670598;
				short num2 = num;
				num = (short)1851469446;
				switch (num2 == num)
				{
				}
				num = (short)1641349121;
				if (num != 0)
				{
				}
				num = (short)63832064;
				if (num != 0)
				{
				}
				num = (short)420675584;
				short num3 = num;
				return this.cnvPerConventionalChannelOptionsDirectTalkaround_A9255.Editable;
			}
			set
			{
				short num = (short)1674992417;
				short num2 = num;
				num = (short)473389857;
				switch (num2 == num)
				{
				}
				num = (short)915210240;
				if (num != 0)
				{
				}
				num = (short)810483713;
				if (num != 0)
				{
				}
				num = (short)1300299776;
				short num3 = num;
				this.cnvPerConventionalChannelOptionsDirectTalkaround_A9255.Editable = value;
			}
		}

		// Token: 0x170062FF RID: 25343
		// (get) Token: 0x0600C5AC RID: 50604 RVA: 0x00B9522C File Offset: 0x00B9342C
		internal string CnvPerConventionalChannelOptionsDirectTalkaround_A9255_UILabel
		{
			get
			{
				short num = (short)634781698;
				short num2 = num;
				num = (short)319619074;
				switch (num2 == num)
				{
				}
				num = (short)1589903361;
				if (num != 0)
				{
				}
				num = (short)997982208;
				if (num != 0)
				{
				}
				num = (short)2041118720;
				short num3 = num;
				return this.cnvPerConventionalChannelOptionsDirectTalkaround_A9255.UIName;
			}
		}

		// Token: 0x17006300 RID: 25344
		// (get) Token: 0x0600C5AD RID: 50605 RVA: 0x00B952E0 File Offset: 0x00B934E0
		// (set) Token: 0x0600C5AE RID: 50606 RVA: 0x00B95394 File Offset: 0x00B93594
		internal bool CnvPerConventionalChannelOptionsDirectTalkaround_A9255_HiddenStatic
		{
			get
			{
				short num = (short)457569923;
				short num2 = num;
				num = (short)2122774147;
				switch (num2 == num)
				{
				}
				num = (short)425066496;
				if (num != 0)
				{
				}
				num = (short)941228033;
				if (num != 0)
				{
				}
				num = (short)1220214784;
				short num3 = num;
				return this.cnvPerConventionalChannelOptionsDirectTalkaround_A9255.HiddenStatic;
			}
			set
			{
				short num = (short)1671991426;
				short num2 = num;
				num = (short)1619431554;
				switch (num2 == num)
				{
				}
				num = (short)1661730817;
				if (num != 0)
				{
				}
				num = (short)782106624;
				if (num != 0)
				{
				}
				num = (short)1679949824;
				short num3 = num;
				this.cnvPerConventionalChannelOptionsDirectTalkaround_A9255.HiddenStatic = value;
			}
		}

		// Token: 0x17006301 RID: 25345
		// (get) Token: 0x0600C5AF RID: 50607 RVA: 0x00B95448 File Offset: 0x00B93648
		// (set) Token: 0x0600C5B0 RID: 50608 RVA: 0x00B954FC File Offset: 0x00B936FC
		internal bool CnvPerConventionalChannelOptionsDirectTalkaround_A9255_HiddenDynamic
		{
			get
			{
				short num = (short)637110136;
				short num2 = num;
				num = (short)67929976;
				switch (num2 == num)
				{
				}
				num = (short)648151041;
				if (num != 0)
				{
				}
				num = (short)965410816;
				if (num != 0)
				{
				}
				num = (short)1926037504;
				short num3 = num;
				return this.cnvPerConventionalChannelOptionsDirectTalkaround_A9255.HiddenDynamic;
			}
			set
			{
				short num = (short)1791939925;
				short num2 = num;
				num = (short)2063062357;
				switch (num2 == num)
				{
				}
				num = (short)1283588097;
				if (num != 0)
				{
				}
				num = (short)614465536;
				if (num != 0)
				{
				}
				num = (short)435748864;
				short num3 = num;
				this.cnvPerConventionalChannelOptionsDirectTalkaround_A9255.HiddenDynamic = value;
			}
		}

		// Token: 0x17006302 RID: 25346
		// (get) Token: 0x0600C5B1 RID: 50609 RVA: 0x00B955B4 File Offset: 0x00B937B4
		public bool CnvPerConventionalChannelOptionsDirectTalkaround_A9255_HasDiffs
		{
			get
			{
				short num = (short)230869333;
				short num2 = num;
				num = (short)504940885;
				switch (num2 == num)
				{
				}
				num = (short)112001025;
				if (num != 0)
				{
				}
				num = (short)695730176;
				if (num != 0)
				{
				}
				num = (short)189071360;
				short num3 = num;
				return this.cnvPerConventionalChannelOptionsDirectTalkaround_A9255._HasDiffs;
			}
		}

		// Token: 0x17006303 RID: 25347
		// (get) Token: 0x0600C5B2 RID: 50610 RVA: 0x00B95668 File Offset: 0x00B93868
		// (set) Token: 0x0600C5B3 RID: 50611 RVA: 0x00B9571C File Offset: 0x00B9391C
		public int CnvPerConventionalChannelOptionsTADPLCode_A9256Value
		{
			get
			{
				short num = (short)798783864;
				short num2 = num;
				num = (short)1473411448;
				switch (num2 == num)
				{
				}
				num = (short)1947467777;
				if (num != 0)
				{
				}
				num = (short)355860480;
				if (num != 0)
				{
				}
				num = (short)1590427648;
				short num3 = num;
				return this.cnvPerConventionalChannelOptionsTADPLCode_A9256.Value;
			}
			set
			{
				short num = (short)523638566;
				short num2 = num;
				num = (short)1707939622;
				switch (num2 == num)
				{
				}
				num = (short)2101673985;
				if (num != 0)
				{
				}
				num = (short)2131951616;
				if (num != 0)
				{
				}
				num = (short)1494614016;
				short num3 = num;
				this.cnvPerConventionalChannelOptionsTADPLCode_A9256.Value = value;
			}
		}

		// Token: 0x17006304 RID: 25348
		// (get) Token: 0x0600C5B4 RID: 50612 RVA: 0x00B957D0 File Offset: 0x00B939D0
		// (set) Token: 0x0600C5B5 RID: 50613 RVA: 0x00B95884 File Offset: 0x00B93A84
		public string CnvPerConventionalChannelOptionsTADPLCode_A9256_UIValue
		{
			get
			{
				short num = (short)283795433;
				short num2 = num;
				num = (short)154951657;
				switch (num2 == num)
				{
				}
				num = (short)1020067841;
				if (num != 0)
				{
				}
				num = (short)1047724032;
				if (num != 0)
				{
				}
				num = (short)1672609792;
				short num3 = num;
				return this.cnvPerConventionalChannelOptionsTADPLCode_A9256.UIValue;
			}
			set
			{
				short num = (short)1691603433;
				short num2 = num;
				num = (short)2112934377;
				switch (num2 == num)
				{
				}
				num = (short)1028390912;
				if (num != 0)
				{
				}
				num = (short)2021851137;
				if (num != 0)
				{
				}
				num = (short)2002518016;
				short num3 = num;
				this.cnvPerConventionalChannelOptionsTADPLCode_A9256.UIValue = value;
			}
		}

		// Token: 0x17006305 RID: 25349
		// (get) Token: 0x0600C5B6 RID: 50614 RVA: 0x00B95938 File Offset: 0x00B93B38
		public global::AcpBusinessLayer.AcpListField CnvPerConventionalChannelOptionsTADPLCode_A9256
		{
			get
			{
				short num = (short)470254092;
				short num2 = num;
				num = (short)297763340;
				switch (num2 == num)
				{
				}
				num = (short)2035417089;
				if (num != 0)
				{
				}
				num = (short)371720192;
				if (num != 0)
				{
				}
				num = (short)830996480;
				short num3 = num;
				return this.cnvPerConventionalChannelOptionsTADPLCode_A9256;
			}
		}

		// Token: 0x17006306 RID: 25350
		// (get) Token: 0x0600C5B7 RID: 50615 RVA: 0x00B959E8 File Offset: 0x00B93BE8
		// (set) Token: 0x0600C5B8 RID: 50616 RVA: 0x00B95AA0 File Offset: 0x00B93CA0
		public bool CnvPerConventionalChannelOptionsTADPLCode_A9256_Applicable
		{
			get
			{
				short num = (short)629059387;
				short num2 = num;
				num = (short)782217019;
				switch (num2 == num)
				{
				}
				num = (short)1909129217;
				if (num != 0)
				{
				}
				num = (short)447217664;
				if (num != 0)
				{
				}
				num = (short)1403453440;
				short num3 = num;
				return this.cnvPerConventionalChannelOptionsTADPLCode_A9256.Applicable;
			}
			set
			{
				short num = (short)1035852039;
				short num2 = num;
				num = (short)1755437319;
				switch (num2 == num)
				{
				}
				num = (short)507183105;
				if (num != 0)
				{
				}
				num = (short)649986048;
				if (num != 0)
				{
				}
				num = (short)1747582976;
				short num3 = num;
				this.cnvPerConventionalChannelOptionsTADPLCode_A9256.Applicable = value;
			}
		}

		// Token: 0x17006307 RID: 25351
		// (get) Token: 0x0600C5B9 RID: 50617 RVA: 0x00B95B54 File Offset: 0x00B93D54
		// (set) Token: 0x0600C5BA RID: 50618 RVA: 0x00B95C04 File Offset: 0x00B93E04
		public bool CnvPerConventionalChannelOptionsTADPLCode_A9256_Valid
		{
			get
			{
				short num = (short)1524344305;
				short num2 = num;
				num = (short)151365105;
				switch (num2 == num)
				{
				}
				num = (short)134086656;
				if (num != 0)
				{
				}
				num = (short)1195114497;
				if (num != 0)
				{
				}
				num = (short)484442112;
				short num3 = num;
				return this.cnvPerConventionalChannelOptionsTADPLCode_A9256.Valid;
			}
			set
			{
				short num = (short)1211021387;
				short num2 = num;
				num = (short)801486923;
				switch (num2 == num)
				{
				}
				num = (short)1252392961;
				if (num != 0)
				{
				}
				num = (short)722796544;
				if (num != 0)
				{
				}
				num = (short)1069547520;
				short num3 = num;
				this.cnvPerConventionalChannelOptionsTADPLCode_A9256.Valid = value;
			}
		}

		// Token: 0x17006308 RID: 25352
		// (get) Token: 0x0600C5BB RID: 50619 RVA: 0x00B95CBC File Offset: 0x00B93EBC
		// (set) Token: 0x0600C5BC RID: 50620 RVA: 0x00B95D70 File Offset: 0x00B93F70
		public bool CnvPerConventionalChannelOptionsTADPLCode_A9256_Visible
		{
			get
			{
				short num = (short)682098689;
				if (num != 0)
				{
				}
				num = (short)2084973929;
				short num2 = num;
				num = (short)1294937449;
				switch (num2 == num)
				{
				}
				num = (short)222756864;
				if (num != 0)
				{
				}
				num = (short)915210240;
				short num3 = num;
				return this.cnvPerConventionalChannelOptionsTADPLCode_A9256.Visible;
			}
			set
			{
				short num = (short)1057340499;
				short num2 = num;
				num = (short)774945875;
				switch (num2 == num)
				{
				}
				num = (short)2052849665;
				if (num != 0)
				{
				}
				num = (short)1245511680;
				if (num != 0)
				{
				}
				num = (short)1711079424;
				short num3 = num;
				this.cnvPerConventionalChannelOptionsTADPLCode_A9256.Visible = value;
			}
		}

		// Token: 0x17006309 RID: 25353
		// (get) Token: 0x0600C5BD RID: 50621 RVA: 0x00B95E24 File Offset: 0x00B94024
		// (set) Token: 0x0600C5BE RID: 50622 RVA: 0x00B95ED8 File Offset: 0x00B940D8
		public bool CnvPerConventionalChannelOptionsTADPLCode_A9256_Editable
		{
			get
			{
				short num = (short)1822228481;
				if (num != 0)
				{
				}
				num = (short)429941743;
				short num2 = num;
				num = (short)2051367919;
				switch (num2 == num)
				{
				}
				num = (short)926744576;
				if (num != 0)
				{
				}
				num = (short)1773076480;
				short num3 = num;
				return this.cnvPerConventionalChannelOptionsTADPLCode_A9256.Editable;
			}
			set
			{
				short num = (short)596537285;
				short num2 = num;
				num = (short)1750298565;
				switch (num2 == num)
				{
				}
				num = (short)2064973824;
				if (num != 0)
				{
				}
				num = (short)1576730625;
				if (num != 0)
				{
				}
				num = (short)289603584;
				short num3 = num;
				this.cnvPerConventionalChannelOptionsTADPLCode_A9256.Editable = value;
			}
		}

		// Token: 0x1700630A RID: 25354
		// (get) Token: 0x0600C5BF RID: 50623 RVA: 0x00B95F8C File Offset: 0x00B9418C
		internal string CnvPerConventionalChannelOptionsTADPLCode_A9256_UILabel
		{
			get
			{
				short num = (short)429827975;
				short num2 = num;
				num = (short)650815367;
				switch (num2 == num)
				{
				}
				num = (short)1543438337;
				if (num != 0)
				{
				}
				num = (short)872742912;
				if (num != 0)
				{
				}
				num = (short)1699282944;
				short num3 = num;
				return this.cnvPerConventionalChannelOptionsTADPLCode_A9256.UIName;
			}
		}

		// Token: 0x1700630B RID: 25355
		// (get) Token: 0x0600C5C0 RID: 50624 RVA: 0x00B96044 File Offset: 0x00B94244
		// (set) Token: 0x0600C5C1 RID: 50625 RVA: 0x00B960F8 File Offset: 0x00B942F8
		internal bool CnvPerConventionalChannelOptionsTADPLCode_A9256_HiddenStatic
		{
			get
			{
				short num = (short)924123137;
				if (num != 0)
				{
				}
				num = (short)1256272749;
				short num2 = num;
				num = (short)1696412525;
				switch (num2 == num)
				{
				}
				num = (short)338755584;
				if (num != 0)
				{
				}
				num = (short)1284440064;
				short num3 = num;
				return this.cnvPerConventionalChannelOptionsTADPLCode_A9256.HiddenStatic;
			}
			set
			{
				short num = (short)409534465;
				if (num != 0)
				{
				}
				num = (short)1086679571;
				short num2 = num;
				num = (short)1773627923;
				switch (num2 == num)
				{
				}
				num = (short)916258816;
				if (num != 0)
				{
				}
				num = (short)915996672;
				short num3 = num;
				this.cnvPerConventionalChannelOptionsTADPLCode_A9256.HiddenStatic = value;
			}
		}

		// Token: 0x1700630C RID: 25356
		// (get) Token: 0x0600C5C2 RID: 50626 RVA: 0x00B961AC File Offset: 0x00B943AC
		// (set) Token: 0x0600C5C3 RID: 50627 RVA: 0x00B96260 File Offset: 0x00B94460
		internal bool CnvPerConventionalChannelOptionsTADPLCode_A9256_HiddenDynamic
		{
			get
			{
				short num = (short)1105469508;
				short num2 = num;
				num = (short)1179656260;
				switch (num2 == num)
				{
				}
				num = (short)185204737;
				if (num != 0)
				{
				}
				num = (short)1065418752;
				if (num != 0)
				{
				}
				num = (short)1298006016;
				short num3 = num;
				return this.cnvPerConventionalChannelOptionsTADPLCode_A9256.HiddenDynamic;
			}
			set
			{
				short num = (short)686492732;
				short num2 = num;
				num = (short)1703021628;
				switch (num2 == num)
				{
				}
				num = (short)1115422720;
				if (num != 0)
				{
				}
				num = (short)1390215169;
				if (num != 0)
				{
				}
				num = (short)102039552;
				short num3 = num;
				this.cnvPerConventionalChannelOptionsTADPLCode_A9256.HiddenDynamic = value;
			}
		}

		// Token: 0x1700630D RID: 25357
		// (get) Token: 0x0600C5C4 RID: 50628 RVA: 0x00B96314 File Offset: 0x00B94514
		public bool CnvPerConventionalChannelOptionsTADPLCode_A9256_HasDiffs
		{
			get
			{
				short num = (short)1392586675;
				short num2 = num;
				num = (short)880619443;
				switch (num2 == num)
				{
				}
				num = (short)1755512833;
				if (num != 0)
				{
				}
				num = (short)1885470720;
				if (num != 0)
				{
				}
				num = (short)1926692864;
				short num3 = num;
				return this.cnvPerConventionalChannelOptionsTADPLCode_A9256._HasDiffs;
			}
		}

		// Token: 0x1700630E RID: 25358
		// (get) Token: 0x0600C5C5 RID: 50629 RVA: 0x00B963C8 File Offset: 0x00B945C8
		// (set) Token: 0x0600C5C6 RID: 50630 RVA: 0x00B9647C File Offset: 0x00B9467C
		public bool CnvPerConventionalChannelOptionsTADPLInvert_A9259Value
		{
			get
			{
				short num = (short)1299610956;
				short num2 = num;
				num = (short)983661900;
				switch (num2 == num)
				{
				}
				num = (short)585236481;
				if (num != 0)
				{
				}
				num = (short)1003225088;
				if (num != 0)
				{
				}
				num = (short)1164443648;
				short num3 = num;
				return this.cnvPerConventionalChannelOptionsTADPLInvert_A9259.Value;
			}
			set
			{
				short num = (short)552055380;
				short num2 = num;
				num = (short)1707520596;
				switch (num2 == num)
				{
				}
				num = (short)718995456;
				if (num != 0)
				{
				}
				num = (short)592248833;
				if (num != 0)
				{
				}
				num = (short)528285696;
				short num3 = num;
				this.cnvPerConventionalChannelOptionsTADPLInvert_A9259.Value = value;
			}
		}

		// Token: 0x1700630F RID: 25359
		// (get) Token: 0x0600C5C7 RID: 50631 RVA: 0x00B96534 File Offset: 0x00B94734
		public global::AcpBusinessLayer.AcpField<bool> CnvPerConventionalChannelOptionsTADPLInvert_A9259
		{
			get
			{
				short num = (short)1213726721;
				if (num != 0)
				{
				}
				num = (short)1582089888;
				short num2 = num;
				num = (short)1525204640;
				switch (num2 == num)
				{
				}
				num = (short)492961792;
				if (num != 0)
				{
				}
				num = (short)1635844096;
				short num3 = num;
				return this.cnvPerConventionalChannelOptionsTADPLInvert_A9259;
			}
		}

		// Token: 0x17006310 RID: 25360
		// (get) Token: 0x0600C5C8 RID: 50632 RVA: 0x00B965E4 File Offset: 0x00B947E4
		// (set) Token: 0x0600C5C9 RID: 50633 RVA: 0x00B9669C File Offset: 0x00B9489C
		public bool CnvPerConventionalChannelOptionsTADPLInvert_A9259_UIValue
		{
			get
			{
				short num = (short)45074166;
				short num2 = num;
				num = (short)1190315766;
				switch (num2 == num)
				{
				}
				num = (short)50266113;
				if (num != 0)
				{
				}
				num = (short)1492779008;
				if (num != 0)
				{
				}
				num = (short)1804664832;
				short num3 = num;
				return this.cnvPerConventionalChannelOptionsTADPLInvert_A9259.Value;
			}
			set
			{
				short num = (short)1323411272;
				short num2 = num;
				num = (short)778741576;
				switch (num2 == num)
				{
				}
				num = (short)1464074241;
				if (num != 0)
				{
				}
				num = (short)483000320;
				if (num != 0)
				{
				}
				num = (short)690880512;
				short num3 = num;
				this.cnvPerConventionalChannelOptionsTADPLInvert_A9259.Value = value;
			}
		}

		// Token: 0x17006311 RID: 25361
		// (get) Token: 0x0600C5CA RID: 50634 RVA: 0x00B96754 File Offset: 0x00B94954
		// (set) Token: 0x0600C5CB RID: 50635 RVA: 0x00B96808 File Offset: 0x00B94A08
		public bool CnvPerConventionalChannelOptionsTADPLInvert_A9259_Applicable
		{
			get
			{
				short num = (short)1214324873;
				short num2 = num;
				num = (short)923345033;
				switch (num2 == num)
				{
				}
				num = (short)547291137;
				if (num != 0)
				{
				}
				num = (short)1084293120;
				if (num != 0)
				{
				}
				num = (short)1545863168;
				short num3 = num;
				return this.cnvPerConventionalChannelOptionsTADPLInvert_A9259.Applicable;
			}
			set
			{
				short num = (short)661755863;
				short num2 = num;
				num = (short)2049611735;
				switch (num2 == num)
				{
				}
				num = (short)60751873;
				if (num != 0)
				{
				}
				num = (short)1871773696;
				if (num != 0)
				{
				}
				num = (short)986120192;
				short num3 = num;
				this.cnvPerConventionalChannelOptionsTADPLInvert_A9259.Applicable = value;
			}
		}

		// Token: 0x17006312 RID: 25362
		// (get) Token: 0x0600C5CC RID: 50636 RVA: 0x00B968C0 File Offset: 0x00B94AC0
		// (set) Token: 0x0600C5CD RID: 50637 RVA: 0x00B96970 File Offset: 0x00B94B70
		public bool CnvPerConventionalChannelOptionsTADPLInvert_A9259_Valid
		{
			get
			{
				short num = (short)417905618;
				short num2 = num;
				num = (short)1977465810;
				switch (num2 == num)
				{
				}
				num = (short)1129054209;
				if (num != 0)
				{
				}
				num = (short)117374976;
				if (num != 0)
				{
				}
				num = (short)966918144;
				short num3 = num;
				return this.cnvPerConventionalChannelOptionsTADPLInvert_A9259.Valid;
			}
			set
			{
				short num = (short)479070545;
				short num2 = num;
				num = (short)1772554577;
				switch (num2 == num)
				{
				}
				num = (short)680591361;
				if (num != 0)
				{
				}
				num = (short)1012727808;
				if (num != 0)
				{
				}
				num = (short)216530944;
				short num3 = num;
				this.cnvPerConventionalChannelOptionsTADPLInvert_A9259.Valid = value;
			}
		}

		// Token: 0x17006313 RID: 25363
		// (get) Token: 0x0600C5CE RID: 50638 RVA: 0x00B96A24 File Offset: 0x00B94C24
		// (set) Token: 0x0600C5CF RID: 50639 RVA: 0x00B96AD8 File Offset: 0x00B94CD8
		public bool CnvPerConventionalChannelOptionsTADPLInvert_A9259_Visible
		{
			get
			{
				short num = (short)956235777;
				if (num != 0)
				{
				}
				num = (short)411045606;
				short num2 = num;
				num = (short)1256984294;
				switch (num2 == num)
				{
				}
				num = (short)132644864;
				if (num != 0)
				{
				}
				num = (short)1683226624;
				short num3 = num;
				return this.cnvPerConventionalChannelOptionsTADPLInvert_A9259.Visible;
			}
			set
			{
				short num = (short)491396633;
				short num2 = num;
				num = (short)1075650073;
				switch (num2 == num)
				{
				}
				num = (short)1663696897;
				if (num != 0)
				{
				}
				num = (short)1054212096;
				if (num != 0)
				{
				}
				num = (short)154140672;
				short num3 = num;
				this.cnvPerConventionalChannelOptionsTADPLInvert_A9259.Visible = value;
			}
		}

		// Token: 0x17006314 RID: 25364
		// (get) Token: 0x0600C5D0 RID: 50640 RVA: 0x00B96B90 File Offset: 0x00B94D90
		// (set) Token: 0x0600C5D1 RID: 50641 RVA: 0x00B96C44 File Offset: 0x00B94E44
		public bool CnvPerConventionalChannelOptionsTADPLInvert_A9259_Editable
		{
			get
			{
				short num = (short)1604788667;
				short num2 = num;
				num = (short)1210786235;
				switch (num2 == num)
				{
				}
				num = (short)813629440;
				if (num != 0)
				{
				}
				num = (short)1236205569;
				if (num != 0)
				{
				}
				num = (short)925564928;
				short num3 = num;
				return this.cnvPerConventionalChannelOptionsTADPLInvert_A9259.Editable;
			}
			set
			{
				short num = (short)48771982;
				short num2 = num;
				num = (short)1166291854;
				switch (num2 == num)
				{
				}
				num = (short)86179840;
				if (num != 0)
				{
				}
				num = (short)1848442881;
				if (num != 0)
				{
				}
				num = (short)1751056384;
				short num3 = num;
				this.cnvPerConventionalChannelOptionsTADPLInvert_A9259.Editable = value;
			}
		}

		// Token: 0x17006315 RID: 25365
		// (get) Token: 0x0600C5D2 RID: 50642 RVA: 0x00B96CF8 File Offset: 0x00B94EF8
		internal string CnvPerConventionalChannelOptionsTADPLInvert_A9259_UILabel
		{
			get
			{
				short num = (short)1611876984;
				short num2 = num;
				num = (short)1385581176;
				switch (num2 == num)
				{
				}
				num = (short)1670316033;
				if (num != 0)
				{
				}
				num = (short)1674248192;
				if (num != 0)
				{
				}
				num = (short)691535872;
				short num3 = num;
				return this.cnvPerConventionalChannelOptionsTADPLInvert_A9259.UIName;
			}
		}

		// Token: 0x17006316 RID: 25366
		// (get) Token: 0x0600C5D3 RID: 50643 RVA: 0x00B96DAC File Offset: 0x00B94FAC
		// (set) Token: 0x0600C5D4 RID: 50644 RVA: 0x00B96E60 File Offset: 0x00B95060
		internal bool CnvPerConventionalChannelOptionsTADPLInvert_A9259_HiddenStatic
		{
			get
			{
				short num = (short)2015089027;
				short num2 = num;
				num = (short)1227870595;
				switch (num2 == num)
				{
				}
				num = (short)1394999297;
				if (num != 0)
				{
				}
				num = (short)222429184;
				if (num != 0)
				{
				}
				num = (short)825950208;
				short num3 = num;
				return this.cnvPerConventionalChannelOptionsTADPLInvert_A9259.HiddenStatic;
			}
			set
			{
				short num = (short)1463681025;
				if (num != 0)
				{
				}
				num = (short)564975114;
				short num2 = num;
				num = (short)886494730;
				switch (num2 == num)
				{
				}
				num = (short)812253184;
				if (num != 0)
				{
				}
				num = (short)48693248;
				short num3 = num;
				this.cnvPerConventionalChannelOptionsTADPLInvert_A9259.HiddenStatic = value;
			}
		}

		// Token: 0x17006317 RID: 25367
		// (get) Token: 0x0600C5D5 RID: 50645 RVA: 0x00B96F18 File Offset: 0x00B95118
		// (set) Token: 0x0600C5D6 RID: 50646 RVA: 0x00B96FCC File Offset: 0x00B951CC
		internal bool CnvPerConventionalChannelOptionsTADPLInvert_A9259_HiddenDynamic
		{
			get
			{
				short num = (short)1843663968;
				short num2 = num;
				num = (short)1608193120;
				switch (num2 == num)
				{
				}
				num = (short)833945601;
				if (num != 0)
				{
				}
				num = (short)279183360;
				if (num != 0)
				{
				}
				num = (short)886374400;
				short num3 = num;
				return this.cnvPerConventionalChannelOptionsTADPLInvert_A9259.HiddenDynamic;
			}
			set
			{
				short num = (short)1256587265;
				if (num != 0)
				{
				}
				num = (short)1540540071;
				short num2 = num;
				num = (short)1655490215;
				switch (num2 == num)
				{
				}
				num = (short)389349376;
				if (num != 0)
				{
				}
				num = (short)670629888;
				short num3 = num;
				this.cnvPerConventionalChannelOptionsTADPLInvert_A9259.HiddenDynamic = value;
			}
		}

		// Token: 0x17006318 RID: 25368
		// (get) Token: 0x0600C5D7 RID: 50647 RVA: 0x00B97084 File Offset: 0x00B95284
		public bool CnvPerConventionalChannelOptionsTADPLInvert_A9259_HasDiffs
		{
			get
			{
				short num = (short)1352859649;
				if (num != 0)
				{
				}
				num = (short)1096617939;
				short num2 = num;
				num = (short)1708068819;
				switch (num2 == num)
				{
				}
				num = (short)990511104;
				if (num != 0)
				{
				}
				num = (short)633077760;
				short num3 = num;
				return this.cnvPerConventionalChannelOptionsTADPLInvert_A9259._HasDiffs;
			}
		}

		// Token: 0x17006319 RID: 25369
		// (get) Token: 0x0600C5D8 RID: 50648 RVA: 0x00B97138 File Offset: 0x00B95338
		// (set) Token: 0x0600C5D9 RID: 50649 RVA: 0x00B971EC File Offset: 0x00B953EC
		public int CnvPerConventionalChannelOptionsTAFrequency_A9260Value
		{
			get
			{
				short num = (short)1784451121;
				short num2 = num;
				num = (short)826511409;
				switch (num2 == num)
				{
				}
				num = (short)1733492737;
				if (num != 0)
				{
				}
				num = (short)997261312;
				if (num != 0)
				{
				}
				num = (short)535953408;
				short num3 = num;
				return this.cnvPerConventionalChannelOptionsTAFrequency_A9260.Value;
			}
			set
			{
				short num = (short)2101805056;
				short num2 = num;
				num = (short)1596809144;
				short num3 = num;
				num = (short)311320504;
				switch (num3 == num)
				{
				}
				num = (short)84279297;
				if (num != 0)
				{
				}
				num = (short)327155712;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTAFrequency_A9260.Value = value;
			}
		}

		// Token: 0x1700631A RID: 25370
		// (get) Token: 0x0600C5DA RID: 50650 RVA: 0x00B972A4 File Offset: 0x00B954A4
		// (set) Token: 0x0600C5DB RID: 50651 RVA: 0x00B97358 File Offset: 0x00B95558
		public string CnvPerConventionalChannelOptionsTAFrequency_A9260_UIValue
		{
			get
			{
				short num = (short)234356736;
				short num2 = num;
				num = (short)43778049;
				if (num != 0)
				{
				}
				num = (short)939668161;
				short num3 = num;
				num = (short)1500132033;
				switch (num3 == num)
				{
				}
				num = (short)2111897600;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTAFrequency_A9260.UIValue;
			}
			set
			{
				short num = (short)1631911936;
				short num2 = num;
				num = (short)1554550534;
				short num3 = num;
				num = (short)587501318;
				switch (num3 == num)
				{
				}
				num = (short)828112897;
				if (num != 0)
				{
				}
				num = (short)1030356992;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTAFrequency_A9260.UIValue = value;
			}
		}

		// Token: 0x1700631B RID: 25371
		// (get) Token: 0x0600C5DC RID: 50652 RVA: 0x00B9740C File Offset: 0x00B9560C
		public global::AcpBusinessLayer.AcpFrequencyField CnvPerConventionalChannelOptionsTAFrequency_A9260
		{
			get
			{
				short num = (short)219152384;
				short num2 = num;
				num = (short)1664283471;
				short num3 = num;
				num = (short)1369699151;
				switch (num3 == num)
				{
				}
				num = (short)1776877568;
				if (num != 0)
				{
				}
				num = (short)1444020225;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTAFrequency_A9260;
			}
		}

		// Token: 0x1700631C RID: 25372
		// (get) Token: 0x0600C5DD RID: 50653 RVA: 0x00B974C0 File Offset: 0x00B956C0
		// (set) Token: 0x0600C5DE RID: 50654 RVA: 0x00B97578 File Offset: 0x00B95778
		internal int CnvPerConventionalChannelOptionsTAFrequency_A9260Min
		{
			get
			{
				short num = (short)650575872;
				short num2 = num;
				num = (short)858376498;
				short num3 = num;
				num = (short)1093650738;
				switch (num3 == num)
				{
				}
				num = (short)787218433;
				if (num != 0)
				{
				}
				num = (short)557645824;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTAFrequency_A9260.Min;
			}
			set
			{
				short num = (short)1912864768;
				short num2 = num;
				num = (short)1784025765;
				short num3 = num;
				num = (short)432214693;
				switch (num3 == num)
				{
				}
				num = (short)1043529728;
				if (num != 0)
				{
				}
				num = (short)1746010113;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTAFrequency_A9260.Min = value;
			}
		}

		// Token: 0x1700631D RID: 25373
		// (get) Token: 0x0600C5DF RID: 50655 RVA: 0x00B9762C File Offset: 0x00B9582C
		// (set) Token: 0x0600C5E0 RID: 50656 RVA: 0x00B976E0 File Offset: 0x00B958E0
		internal int CnvPerConventionalChannelOptionsTAFrequency_A9260Max
		{
			get
			{
				short num = (short)1084293120;
				short num2 = num;
				num = (short)1158616765;
				short num3 = num;
				num = (short)1264981693;
				switch (num3 == num)
				{
				}
				num = (short)1232928769;
				if (num != 0)
				{
				}
				num = (short)41746432;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTAFrequency_A9260.Max;
			}
			set
			{
				short num = (short)646905856;
				short num2 = num;
				num = (short)2046751146;
				short num3 = num;
				num = (short)80867754;
				switch (num3 == num)
				{
				}
				num = (short)1992294401;
				if (num != 0)
				{
				}
				num = (short)2003632128;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTAFrequency_A9260.Max = value;
			}
		}

		// Token: 0x1700631E RID: 25374
		// (get) Token: 0x0600C5E1 RID: 50657 RVA: 0x00B97794 File Offset: 0x00B95994
		// (set) Token: 0x0600C5E2 RID: 50658 RVA: 0x00B97848 File Offset: 0x00B95A48
		internal int CnvPerConventionalChannelOptionsTAFrequency_A9260Step
		{
			get
			{
				short num = (short)993787904;
				short num2 = num;
				num = (short)1022920447;
				short num3 = num;
				num = (short)1233749759;
				switch (num3 == num)
				{
				}
				num = (short)630718465;
				if (num != 0)
				{
				}
				num = (short)1282080768;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTAFrequency_A9260.StepSize;
			}
			set
			{
				short num = (short)1827536896;
				short num2 = num;
				num = (short)2084120500;
				short num3 = num;
				num = (short)1448814516;
				switch (num3 == num)
				{
				}
				num = (short)1345257472;
				if (num != 0)
				{
				}
				num = (short)1794703361;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTAFrequency_A9260.StepSize = value;
			}
		}

		// Token: 0x1700631F RID: 25375
		// (get) Token: 0x0600C5E3 RID: 50659 RVA: 0x00B97900 File Offset: 0x00B95B00
		// (set) Token: 0x0600C5E4 RID: 50660 RVA: 0x00B979B4 File Offset: 0x00B95BB4
		public bool CnvPerConventionalChannelOptionsTAFrequency_A9260_Applicable
		{
			get
			{
				short num = (short)265093120;
				short num2 = num;
				num = (short)1406178798;
				short num3 = num;
				num = (short)1677039086;
				switch (num3 == num)
				{
				}
				num = (short)227606529;
				if (num != 0)
				{
				}
				num = (short)794165248;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTAFrequency_A9260.Applicable;
			}
			set
			{
				short num = (short)39124992;
				short num2 = num;
				num = (short)782030398;
				short num3 = num;
				num = (short)107009598;
				switch (num3 == num)
				{
				}
				num = (short)2034499585;
				if (num != 0)
				{
				}
				num = (short)1433468928;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTAFrequency_A9260.Applicable = value;
			}
		}

		// Token: 0x17006320 RID: 25376
		// (get) Token: 0x0600C5E5 RID: 50661 RVA: 0x00B97A68 File Offset: 0x00B95C68
		// (set) Token: 0x0600C5E6 RID: 50662 RVA: 0x00B97B1C File Offset: 0x00B95D1C
		public bool CnvPerConventionalChannelOptionsTAFrequency_A9260_Valid
		{
			get
			{
				short num = (short)742785024;
				short num2 = num;
				num = (short)1907983429;
				short num3 = num;
				num = (short)1599767621;
				switch (num3 == num)
				{
				}
				num = (short)1759707137;
				if (num != 0)
				{
				}
				num = (short)2126381056;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTAFrequency_A9260.Valid;
			}
			set
			{
				short num = (short)1425670144;
				short num2 = num;
				num = (short)26236869;
				short num3 = num;
				num = (short)157439941;
				switch (num3 == num)
				{
				}
				num = (short)1005125632;
				if (num != 0)
				{
				}
				num = (short)870645761;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTAFrequency_A9260.Valid = value;
			}
		}

		// Token: 0x17006321 RID: 25377
		// (get) Token: 0x0600C5E7 RID: 50663 RVA: 0x00B97BD0 File Offset: 0x00B95DD0
		// (set) Token: 0x0600C5E8 RID: 50664 RVA: 0x00B97C84 File Offset: 0x00B95E84
		public bool CnvPerConventionalChannelOptionsTAFrequency_A9260_Visible
		{
			get
			{
				short num = (short)1020919808;
				short num2 = num;
				num = (short)1031624712;
				short num3 = num;
				num = (short)972445704;
				switch (num3 == num)
				{
				}
				num = (short)1390608385;
				if (num != 0)
				{
				}
				num = (short)163381248;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTAFrequency_A9260.Visible;
			}
			set
			{
				short num = (short)1595670528;
				short num2 = num;
				num = (short)843585280;
				short num3 = num;
				num = (short)534714112;
				switch (num3 == num)
				{
				}
				num = (short)836698112;
				if (num != 0)
				{
				}
				num = (short)315686913;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTAFrequency_A9260.Visible = value;
			}
		}

		// Token: 0x17006322 RID: 25378
		// (get) Token: 0x0600C5E9 RID: 50665 RVA: 0x00B97D40 File Offset: 0x00B95F40
		// (set) Token: 0x0600C5EA RID: 50666 RVA: 0x00B97DF8 File Offset: 0x00B95FF8
		public bool CnvPerConventionalChannelOptionsTAFrequency_A9260_Editable
		{
			get
			{
				short num = (short)1058996224;
				short num2 = num;
				num = (short)1782821592;
				short num3 = num;
				num = (short)1039708888;
				switch (num3 == num)
				{
				}
				num = (short)45809665;
				if (num != 0)
				{
				}
				num = (short)1019346944;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTAFrequency_A9260.Editable;
			}
			set
			{
				short num = (short)700514304;
				short num2 = num;
				num = (short)1008357424;
				short num3 = num;
				num = (short)1297240112;
				switch (num3 == num)
				{
				}
				num = (short)2119761920;
				if (num != 0)
				{
				}
				num = (short)586219521;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTAFrequency_A9260.Editable = value;
			}
		}

		// Token: 0x17006323 RID: 25379
		// (get) Token: 0x0600C5EB RID: 50667 RVA: 0x00B97EAC File Offset: 0x00B960AC
		internal string CnvPerConventionalChannelOptionsTAFrequency_A9260_UILabel
		{
			get
			{
				short num = (short)1940193280;
				short num2 = num;
				num = (short)1695398049;
				short num3 = num;
				num = (short)1543485601;
				switch (num3 == num)
				{
				}
				num = (short)1468399617;
				if (num != 0)
				{
				}
				num = (short)1918500864;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTAFrequency_A9260.UIName;
			}
		}

		// Token: 0x17006324 RID: 25380
		// (get) Token: 0x0600C5EC RID: 50668 RVA: 0x00B97F60 File Offset: 0x00B96160
		// (set) Token: 0x0600C5ED RID: 50669 RVA: 0x00B98014 File Offset: 0x00B96214
		internal bool CnvPerConventionalChannelOptionsTAFrequency_A9260_HiddenStatic
		{
			get
			{
				short num = (short)2142633984;
				short num2 = num;
				num = (short)1152909313;
				if (num != 0)
				{
				}
				num = (short)1355526496;
				short num3 = num;
				num = (short)417509728;
				switch (num3 == num)
				{
				}
				num = (short)1019478016;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTAFrequency_A9260.HiddenStatic;
			}
			set
			{
				short num = (short)1756037120;
				short num2 = num;
				num = (short)2061953589;
				short num3 = num;
				num = (short)937421365;
				switch (num3 == num)
				{
				}
				num = (short)706019328;
				if (num != 0)
				{
				}
				num = (short)124321793;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTAFrequency_A9260.HiddenStatic = value;
			}
		}

		// Token: 0x17006325 RID: 25381
		// (get) Token: 0x0600C5EE RID: 50670 RVA: 0x00B980C8 File Offset: 0x00B962C8
		// (set) Token: 0x0600C5EF RID: 50671 RVA: 0x00B9817C File Offset: 0x00B9637C
		internal bool CnvPerConventionalChannelOptionsTAFrequency_A9260_HiddenDynamic
		{
			get
			{
				short num = (short)75956224;
				short num2 = num;
				num = (short)898433025;
				if (num != 0)
				{
				}
				num = (short)834270057;
				short num3 = num;
				num = (short)628683625;
				switch (num3 == num)
				{
				}
				num = (short)546177024;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTAFrequency_A9260.HiddenDynamic;
			}
			set
			{
				short num = (short)1941831680;
				short num2 = num;
				num = (short)1142083510;
				short num3 = num;
				num = (short)1703792566;
				switch (num3 == num)
				{
				}
				num = (short)204668929;
				if (num != 0)
				{
				}
				num = (short)2048000000;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTAFrequency_A9260.HiddenDynamic = value;
			}
		}

		// Token: 0x17006326 RID: 25382
		// (get) Token: 0x0600C5F0 RID: 50672 RVA: 0x00B98234 File Offset: 0x00B96434
		public bool CnvPerConventionalChannelOptionsTAFrequency_A9260_HasDiffs
		{
			get
			{
				short num = (short)1706885120;
				short num2 = num;
				num = (short)780572426;
				short num3 = num;
				num = (short)548509450;
				switch (num3 == num)
				{
				}
				num = (short)480182272;
				if (num != 0)
				{
				}
				num = (short)1181483009;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTAFrequency_A9260._HasDiffs;
			}
		}

		// Token: 0x17006327 RID: 25383
		// (get) Token: 0x0600C5F1 RID: 50673 RVA: 0x00B982E8 File Offset: 0x00B964E8
		// (set) Token: 0x0600C5F2 RID: 50674 RVA: 0x00B983A0 File Offset: 0x00B965A0
		public int CnvPerConventionalChannelOptionsTAPLCode_A9261Value
		{
			get
			{
				short num = (short)1147731968;
				short num2 = num;
				num = (short)1652333106;
				short num3 = num;
				num = (short)2052692530;
				switch (num3 == num)
				{
				}
				num = (short)1669398528;
				if (num != 0)
				{
				}
				num = (short)1464008705;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTAPLCode_A9261.Value;
			}
			set
			{
				short num = (short)1431830528;
				short num2 = num;
				num = (short)1831668653;
				short num3 = num;
				num = (short)2076642221;
				switch (num3 == num)
				{
				}
				num = (short)1129185281;
				if (num != 0)
				{
				}
				num = (short)595918848;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTAPLCode_A9261.Value = value;
			}
		}

		// Token: 0x17006328 RID: 25384
		// (get) Token: 0x0600C5F3 RID: 50675 RVA: 0x00B98458 File Offset: 0x00B96658
		// (set) Token: 0x0600C5F4 RID: 50676 RVA: 0x00B98510 File Offset: 0x00B96710
		public string CnvPerConventionalChannelOptionsTAPLCode_A9261_UIValue
		{
			get
			{
				short num = (short)1076035584;
				short num2 = num;
				num = (short)216893637;
				short num3 = num;
				num = (short)1491962053;
				switch (num3 == num)
				{
				}
				num = (short)774111233;
				if (num != 0)
				{
				}
				num = (short)1468792832;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTAPLCode_A9261.UIValue;
			}
			set
			{
				short num = (short)749797376;
				short num2 = num;
				num = (short)171317623;
				short num3 = num;
				num = (short)1237260663;
				switch (num3 == num)
				{
				}
				num = (short)1891303425;
				if (num != 0)
				{
				}
				num = (short)723386368;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTAPLCode_A9261.UIValue = value;
			}
		}

		// Token: 0x17006329 RID: 25385
		// (get) Token: 0x0600C5F5 RID: 50677 RVA: 0x00B985C8 File Offset: 0x00B967C8
		public global::AcpBusinessLayer.AcpListField CnvPerConventionalChannelOptionsTAPLCode_A9261
		{
			get
			{
				short num = (short)258736128;
				short num2 = num;
				num = (short)866516993;
				if (num != 0)
				{
				}
				num = (short)1315413570;
				short num3 = num;
				num = (short)20946498;
				switch (num3 == num)
				{
				}
				num = (short)1759641600;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTAPLCode_A9261;
			}
		}

		// Token: 0x1700632A RID: 25386
		// (get) Token: 0x0600C5F6 RID: 50678 RVA: 0x00B98678 File Offset: 0x00B96878
		// (set) Token: 0x0600C5F7 RID: 50679 RVA: 0x00B98730 File Offset: 0x00B96930
		public bool CnvPerConventionalChannelOptionsTAPLCode_A9261_Applicable
		{
			get
			{
				short num = (short)161611776;
				short num2 = num;
				num = (short)1660998013;
				short num3 = num;
				num = (short)1867436413;
				switch (num3 == num)
				{
				}
				num = (short)1474428929;
				if (num != 0)
				{
				}
				num = (short)1965228032;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTAPLCode_A9261.Applicable;
			}
			set
			{
				short num = (short)756023296;
				short num2 = num;
				num = (short)487792396;
				short num3 = num;
				num = (short)1836130060;
				switch (num3 == num)
				{
				}
				num = (short)858128384;
				if (num != 0)
				{
				}
				num = (short)921370625;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTAPLCode_A9261.Applicable = value;
			}
		}

		// Token: 0x1700632B RID: 25387
		// (get) Token: 0x0600C5F8 RID: 50680 RVA: 0x00B987E4 File Offset: 0x00B969E4
		// (set) Token: 0x0600C5F9 RID: 50681 RVA: 0x00B98898 File Offset: 0x00B96A98
		public bool CnvPerConventionalChannelOptionsTAPLCode_A9261_Valid
		{
			get
			{
				short num = (short)261029888;
				short num2 = num;
				num = (short)1242407788;
				short num3 = num;
				num = (short)285254508;
				switch (num3 == num)
				{
				}
				num = (short)1399259136;
				if (num != 0)
				{
				}
				num = (short)1022230529;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTAPLCode_A9261.Valid;
			}
			set
			{
				short num = (short)1969094656;
				short num2 = num;
				num = (short)1125519473;
				short num3 = num;
				num = (short)406327409;
				switch (num3 == num)
				{
				}
				num = (short)531693569;
				if (num != 0)
				{
				}
				num = (short)1389232128;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTAPLCode_A9261.Valid = value;
			}
		}

		// Token: 0x1700632C RID: 25388
		// (get) Token: 0x0600C5FA RID: 50682 RVA: 0x00B9894C File Offset: 0x00B96B4C
		// (set) Token: 0x0600C5FB RID: 50683 RVA: 0x00B98A00 File Offset: 0x00B96C00
		public bool CnvPerConventionalChannelOptionsTAPLCode_A9261_Visible
		{
			get
			{
				short num = (short)611844096;
				short num2 = num;
				num = (short)394361867;
				short num3 = num;
				num = (short)1214938123;
				switch (num3 == num)
				{
				}
				num = (short)131661825;
				if (num != 0)
				{
				}
				num = (short)1690763264;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTAPLCode_A9261.Visible;
			}
			set
			{
				short num = (short)455540736;
				short num2 = num;
				num = (short)164810747;
				short num3 = num;
				num = (short)984862715;
				switch (num3 == num)
				{
				}
				num = (short)941621248;
				if (num != 0)
				{
				}
				num = (short)1334116353;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTAPLCode_A9261.Visible = value;
			}
		}

		// Token: 0x1700632D RID: 25389
		// (get) Token: 0x0600C5FC RID: 50684 RVA: 0x00B98ABC File Offset: 0x00B96CBC
		// (set) Token: 0x0600C5FD RID: 50685 RVA: 0x00B98B70 File Offset: 0x00B96D70
		public bool CnvPerConventionalChannelOptionsTAPLCode_A9261_Editable
		{
			get
			{
				short num = (short)87031808;
				short num2 = num;
				num = (short)829049482;
				short num3 = num;
				num = (short)1809402506;
				switch (num3 == num)
				{
				}
				num = (short)486735873;
				if (num != 0)
				{
				}
				num = (short)1858404352;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTAPLCode_A9261.Editable;
			}
			set
			{
				short num = (short)1984757760;
				short num2 = num;
				num = (short)285811534;
				short num3 = num;
				num = (short)1744446286;
				switch (num3 == num)
				{
				}
				num = (short)1122500609;
				if (num != 0)
				{
				}
				num = (short)2074345472;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTAPLCode_A9261.Editable = value;
			}
		}

		// Token: 0x1700632E RID: 25390
		// (get) Token: 0x0600C5FE RID: 50686 RVA: 0x00B98C28 File Offset: 0x00B96E28
		internal string CnvPerConventionalChannelOptionsTAPLCode_A9261_UILabel
		{
			get
			{
				short num = (short)1866006528;
				short num2 = num;
				num = (short)1848759120;
				short num3 = num;
				num = (short)34263888;
				switch (num3 == num)
				{
				}
				num = (short)592183297;
				if (num != 0)
				{
				}
				num = (short)228589568;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTAPLCode_A9261.UIName;
			}
		}

		// Token: 0x1700632F RID: 25391
		// (get) Token: 0x0600C5FF RID: 50687 RVA: 0x00B98CDC File Offset: 0x00B96EDC
		// (set) Token: 0x0600C600 RID: 50688 RVA: 0x00B98D90 File Offset: 0x00B96F90
		internal bool CnvPerConventionalChannelOptionsTAPLCode_A9261_HiddenStatic
		{
			get
			{
				short num = (short)1351680000;
				short num2 = num;
				num = (short)1040842180;
				short num3 = num;
				num = (short)1136000452;
				switch (num3 == num)
				{
				}
				num = (short)1279918081;
				if (num != 0)
				{
				}
				num = (short)398786560;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTAPLCode_A9261.HiddenStatic;
			}
			set
			{
				short num = (short)2162688;
				short num2 = num;
				num = (short)1662424226;
				short num3 = num;
				num = (short)1552651426;
				switch (num3 == num)
				{
				}
				num = (short)1865547776;
				if (num != 0)
				{
				}
				num = (short)1076559873;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTAPLCode_A9261.HiddenStatic = value;
			}
		}

		// Token: 0x17006330 RID: 25392
		// (get) Token: 0x0600C601 RID: 50689 RVA: 0x00B98E48 File Offset: 0x00B97048
		// (set) Token: 0x0600C602 RID: 50690 RVA: 0x00B98EFC File Offset: 0x00B970FC
		internal bool CnvPerConventionalChannelOptionsTAPLCode_A9261_HiddenDynamic
		{
			get
			{
				short num = (short)2018508800;
				short num2 = num;
				num = (short)303892939;
				short num3 = num;
				num = (short)324798923;
				switch (num3 == num)
				{
				}
				num = (short)1200685057;
				if (num != 0)
				{
				}
				num = (short)834142208;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTAPLCode_A9261.HiddenDynamic;
			}
			set
			{
				short num = (short)1255014400;
				short num2 = num;
				num = (short)2038474285;
				short num3 = num;
				num = (short)1351263789;
				switch (num3 == num)
				{
				}
				num = (short)1925644289;
				if (num != 0)
				{
				}
				num = (short)1176895488;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTAPLCode_A9261.HiddenDynamic = value;
			}
		}

		// Token: 0x17006331 RID: 25393
		// (get) Token: 0x0600C603 RID: 50691 RVA: 0x00B98FB0 File Offset: 0x00B971B0
		public bool CnvPerConventionalChannelOptionsTAPLCode_A9261_HasDiffs
		{
			get
			{
				short num = (short)411172864;
				short num2 = num;
				num = (short)1865875457;
				if (num != 0)
				{
				}
				num = (short)1672426706;
				short num3 = num;
				num = (short)999830738;
				switch (num3 == num)
				{
				}
				num = (short)608960512;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTAPLCode_A9261._HasDiffs;
			}
		}

		// Token: 0x17006332 RID: 25394
		// (get) Token: 0x0600C604 RID: 50692 RVA: 0x00B99064 File Offset: 0x00B97264
		// (set) Token: 0x0600C605 RID: 50693 RVA: 0x00B9911C File Offset: 0x00B9731C
		public int CnvPerConventionalChannelOptionsTAPLFreq_A9264Value
		{
			get
			{
				short num = (short)1012924416;
				short num2 = num;
				num = (short)650633629;
				short num3 = num;
				num = (short)1682301341;
				switch (num3 == num)
				{
				}
				num = (short)876740609;
				if (num != 0)
				{
				}
				num = (short)847183872;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTAPLFreq_A9264.Value;
			}
			set
			{
				short num = (short)649854976;
				short num2 = num;
				num = (short)909539576;
				short num3 = num;
				num = (short)510621944;
				switch (num3 == num)
				{
				}
				num = (short)1472856065;
				if (num != 0)
				{
				}
				num = (short)640090112;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTAPLFreq_A9264.Value = value;
			}
		}

		// Token: 0x17006333 RID: 25395
		// (get) Token: 0x0600C606 RID: 50694 RVA: 0x00B991D0 File Offset: 0x00B973D0
		// (set) Token: 0x0600C607 RID: 50695 RVA: 0x00B99288 File Offset: 0x00B97488
		public string CnvPerConventionalChannelOptionsTAPLFreq_A9264_UIValue
		{
			get
			{
				short num = (short)572850176;
				short num2 = num;
				num = (short)407128026;
				short num3 = num;
				num = (short)1756317658;
				switch (num3 == num)
				{
				}
				num = (short)1377304577;
				if (num != 0)
				{
				}
				num = (short)1061879808;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTAPLFreq_A9264.UIValue;
			}
			set
			{
				short num = (short)1916665856;
				short num2 = num;
				num = (short)428449141;
				short num3 = num;
				num = (short)908107125;
				switch (num3 == num)
				{
				}
				num = (short)1949302785;
				if (num != 0)
				{
				}
				num = (short)269680640;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTAPLFreq_A9264.UIValue = value;
			}
		}

		// Token: 0x17006334 RID: 25396
		// (get) Token: 0x0600C608 RID: 50696 RVA: 0x00B9933C File Offset: 0x00B9753C
		public global::AcpBusinessLayer.AcpListField CnvPerConventionalChannelOptionsTAPLFreq_A9264
		{
			get
			{
				short num = (short)1694892032;
				short num2 = num;
				num = (short)23714761;
				short num3 = num;
				num = (short)682286025;
				switch (num3 == num)
				{
				}
				num = (short)1281753089;
				if (num != 0)
				{
				}
				num = (short)805896192;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTAPLFreq_A9264;
			}
		}

		// Token: 0x17006335 RID: 25397
		// (get) Token: 0x0600C609 RID: 50697 RVA: 0x00B993F0 File Offset: 0x00B975F0
		// (set) Token: 0x0600C60A RID: 50698 RVA: 0x00B994A0 File Offset: 0x00B976A0
		public bool CnvPerConventionalChannelOptionsTAPLFreq_A9264_Applicable
		{
			get
			{
				short num = (short)378863616;
				short num2 = num;
				num = (short)287306351;
				short num3 = num;
				num = (short)766177903;
				switch (num3 == num)
				{
				}
				num = (short)1182597120;
				if (num != 0)
				{
				}
				num = (short)50855937;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTAPLFreq_A9264.Applicable;
			}
			set
			{
				short num = (short)187432960;
				short num2 = num;
				num = (short)826391170;
				short num3 = num;
				num = (short)922401410;
				switch (num3 == num)
				{
				}
				num = (short)96206848;
				if (num != 0)
				{
				}
				num = (short)1525022721;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTAPLFreq_A9264.Applicable = value;
			}
		}

		// Token: 0x17006336 RID: 25398
		// (get) Token: 0x0600C60B RID: 50699 RVA: 0x00B99558 File Offset: 0x00B97758
		// (set) Token: 0x0600C60C RID: 50700 RVA: 0x00B9960C File Offset: 0x00B9780C
		public bool CnvPerConventionalChannelOptionsTAPLFreq_A9264_Valid
		{
			get
			{
				short num = (short)2031616;
				short num2 = num;
				num = (short)1435837233;
				short num3 = num;
				num = (short)669459249;
				switch (num3 == num)
				{
				}
				num = (short)403898369;
				if (num != 0)
				{
				}
				num = (short)1147994112;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTAPLFreq_A9264.Valid;
			}
			set
			{
				short num = (short)182976512;
				short num2 = num;
				num = (short)384418864;
				short num3 = num;
				num = (short)1440203824;
				switch (num3 == num)
				{
				}
				num = (short)1840447489;
				if (num != 0)
				{
				}
				num = (short)347275264;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTAPLFreq_A9264.Valid = value;
			}
		}

		// Token: 0x17006337 RID: 25399
		// (get) Token: 0x0600C60D RID: 50701 RVA: 0x00B996C4 File Offset: 0x00B978C4
		// (set) Token: 0x0600C60E RID: 50702 RVA: 0x00B99778 File Offset: 0x00B97978
		public bool CnvPerConventionalChannelOptionsTAPLFreq_A9264_Visible
		{
			get
			{
				short num = (short)1867841536;
				short num2 = num;
				num = (short)1123356165;
				short num3 = num;
				num = (short)1240534533;
				switch (num3 == num)
				{
				}
				num = (short)571211777;
				if (num != 0)
				{
				}
				num = (short)2131558400;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTAPLFreq_A9264.Visible;
			}
			set
			{
				short num = (short)276955136;
				short num2 = num;
				num = (short)1484152435;
				short num3 = num;
				num = (short)715480691;
				switch (num3 == num)
				{
				}
				num = (short)413073408;
				if (num != 0)
				{
				}
				num = (short)2101018625;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTAPLFreq_A9264.Visible = value;
			}
		}

		// Token: 0x17006338 RID: 25400
		// (get) Token: 0x0600C60F RID: 50703 RVA: 0x00B9982C File Offset: 0x00B97A2C
		// (set) Token: 0x0600C610 RID: 50704 RVA: 0x00B998E0 File Offset: 0x00B97AE0
		public bool CnvPerConventionalChannelOptionsTAPLFreq_A9264_Editable
		{
			get
			{
				short num = (short)1022230528;
				short num2 = num;
				num = (short)971351547;
				short num3 = num;
				num = (short)768845307;
				switch (num3 == num)
				{
				}
				num = (short)1547042817;
				if (num != 0)
				{
				}
				num = (short)1395130368;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTAPLFreq_A9264.Editable;
			}
			set
			{
				short num = (short)1493396559;
				short num2 = num;
				num = (short)870149199;
				switch (num2 == num)
				{
				default:
				{
					num = (short)133890048;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)356450305;
				if (num != 0)
				{
				}
				num = (short)1935474688;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTAPLFreq_A9264.Editable = value;
			}
		}

		// Token: 0x17006339 RID: 25401
		// (get) Token: 0x0600C611 RID: 50705 RVA: 0x00B99998 File Offset: 0x00B97B98
		internal string CnvPerConventionalChannelOptionsTAPLFreq_A9264_UILabel
		{
			get
			{
				short num = (short)1181901579;
				short num2 = num;
				num = (short)2057397003;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1437138944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1592983552;
				if (num != 0)
				{
				}
				num = (short)253820929;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTAPLFreq_A9264.UIName;
			}
		}

		// Token: 0x1700633A RID: 25402
		// (get) Token: 0x0600C612 RID: 50706 RVA: 0x00B99A4C File Offset: 0x00B97C4C
		// (set) Token: 0x0600C613 RID: 50707 RVA: 0x00B99B00 File Offset: 0x00B97D00
		internal bool CnvPerConventionalChannelOptionsTAPLFreq_A9264_HiddenStatic
		{
			get
			{
				short num = (short)676132859;
				short num2 = num;
				num = (short)1819736059;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1785135104;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2120941569;
				if (num != 0)
				{
				}
				num = (short)183435264;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTAPLFreq_A9264.HiddenStatic;
			}
			set
			{
				short num = (short)1468291357;
				short num2 = num;
				num = (short)805263645;
				switch (num2 == num)
				{
				default:
				{
					num = (short)843251712;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)3735552;
				if (num != 0)
				{
				}
				num = (short)194772993;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTAPLFreq_A9264.HiddenStatic = value;
			}
		}

		// Token: 0x1700633B RID: 25403
		// (get) Token: 0x0600C614 RID: 50708 RVA: 0x00B99BB4 File Offset: 0x00B97DB4
		// (set) Token: 0x0600C615 RID: 50709 RVA: 0x00B99C6C File Offset: 0x00B97E6C
		internal bool CnvPerConventionalChannelOptionsTAPLFreq_A9264_HiddenDynamic
		{
			get
			{
				short num = (short)1622457732;
				short num2 = num;
				num = (short)1770831236;
				switch (num2 == num)
				{
				default:
				{
					num = (short)59047936;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1527775233;
				if (num != 0)
				{
				}
				num = (short)92078080;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTAPLFreq_A9264.HiddenDynamic;
			}
			set
			{
				short num = (short)474647008;
				short num2 = num;
				num = (short)418875872;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1562509312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)406519809;
				if (num != 0)
				{
				}
				num = (short)304414720;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTAPLFreq_A9264.HiddenDynamic = value;
			}
		}

		// Token: 0x1700633C RID: 25404
		// (get) Token: 0x0600C616 RID: 50710 RVA: 0x00B99D24 File Offset: 0x00B97F24
		public bool CnvPerConventionalChannelOptionsTAPLFreq_A9264_HasDiffs
		{
			get
			{
				short num = (short)1653669190;
				short num2 = num;
				num = (short)1047002438;
				switch (num2 == num)
				{
				default:
				{
					num = (short)678952960;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1746468864;
				if (num != 0)
				{
				}
				num = (short)2144206849;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTAPLFreq_A9264._HasDiffs;
			}
		}

		// Token: 0x1700633D RID: 25405
		// (get) Token: 0x0600C617 RID: 50711 RVA: 0x00B99DD8 File Offset: 0x00B97FD8
		// (set) Token: 0x0600C618 RID: 50712 RVA: 0x00B99E8C File Offset: 0x00B9808C
		public int CnvPerConventionalChannelOptionsTASquelchType_A9265Value
		{
			get
			{
				short num = (short)834556776;
				short num2 = num;
				num = (short)1394496360;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1329594368;
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
				num = (short)854917120;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTASquelchType_A9265.Value;
			}
			set
			{
				short num = (short)650772481;
				if (num != 0)
				{
				}
				num = (short)676003840;
				short num2 = num;
				num = (short)684176770;
				short num3 = num;
				num = (short)104904066;
				switch (num3 == num)
				{
				}
				num = (short)65667072;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTASquelchType_A9265.Value = value;
			}
		}

		// Token: 0x1700633E RID: 25406
		// (get) Token: 0x0600C619 RID: 50713 RVA: 0x00B99F44 File Offset: 0x00B98144
		// (set) Token: 0x0600C61A RID: 50714 RVA: 0x00B99FF8 File Offset: 0x00B981F8
		public string CnvPerConventionalChannelOptionsTASquelchType_A9265_UIValue
		{
			get
			{
				short num = (short)168560807;
				short num2 = num;
				num = (short)2001340583;
				switch (num2 == num)
				{
				default:
				{
					num = (short)979763200;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1590165504;
				if (num != 0)
				{
				}
				num = (short)660733953;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTASquelchType_A9265.UIValue;
			}
			set
			{
				short num = (short)909374081;
				short num2 = num;
				num = (short)225112705;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1613037568;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1588461569;
				if (num != 0)
				{
				}
				num = (short)550305792;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTASquelchType_A9265.UIValue = value;
			}
		}

		// Token: 0x1700633F RID: 25407
		// (get) Token: 0x0600C61B RID: 50715 RVA: 0x00B9A0AC File Offset: 0x00B982AC
		public global::AcpBusinessLayer.AcpListField CnvPerConventionalChannelOptionsTASquelchType_A9265
		{
			get
			{
				short num = (short)1632421325;
				short num2 = num;
				num = (short)263308749;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1012727808;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1005322241;
				if (num != 0)
				{
				}
				num = (short)1656684544;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTASquelchType_A9265;
			}
		}

		// Token: 0x17006340 RID: 25408
		// (get) Token: 0x0600C61C RID: 50716 RVA: 0x00B9A158 File Offset: 0x00B98358
		// (set) Token: 0x0600C61D RID: 50717 RVA: 0x00B9A20C File Offset: 0x00B9840C
		public bool CnvPerConventionalChannelOptionsTASquelchType_A9265_Applicable
		{
			get
			{
				short num = (short)1269956609;
				if (num != 0)
				{
				}
				num = (short)624885760;
				short num2 = num;
				num = (short)1275267130;
				short num3 = num;
				num = (short)1601964090;
				switch (num3 == num)
				{
				}
				num = (short)1114112;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTASquelchType_A9265.Applicable;
			}
			set
			{
				short num = (short)755533769;
				short num2 = num;
				num = (short)1528465353;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1285947392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)414580736;
				if (num != 0)
				{
				}
				num = (short)1746337793;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTASquelchType_A9265.Applicable = value;
			}
		}

		// Token: 0x17006341 RID: 25409
		// (get) Token: 0x0600C61E RID: 50718 RVA: 0x00B9A2C0 File Offset: 0x00B984C0
		// (set) Token: 0x0600C61F RID: 50719 RVA: 0x00B9A374 File Offset: 0x00B98574
		public bool CnvPerConventionalChannelOptionsTASquelchType_A9265_Valid
		{
			get
			{
				short num = (short)41487742;
				short num2 = num;
				num = (short)1739787646;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1795817472;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1378418689;
				if (num != 0)
				{
				}
				num = (short)1945829376;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTASquelchType_A9265.Valid;
			}
			set
			{
				short num = (short)496038834;
				short num2 = num;
				num = (short)1642525618;
				switch (num2 == num)
				{
				default:
				{
					num = (short)933560320;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1670774785;
				if (num != 0)
				{
				}
				num = (short)963772416;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTASquelchType_A9265.Valid = value;
			}
		}

		// Token: 0x17006342 RID: 25410
		// (get) Token: 0x0600C620 RID: 50720 RVA: 0x00B9A428 File Offset: 0x00B98628
		// (set) Token: 0x0600C621 RID: 50721 RVA: 0x00B9A4E0 File Offset: 0x00B986E0
		public bool CnvPerConventionalChannelOptionsTASquelchType_A9265_Visible
		{
			get
			{
				short num = (short)1840897927;
				short num2 = num;
				num = (short)2140266375;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1429078016;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1163984896;
				if (num != 0)
				{
				}
				num = (short)1036976129;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTASquelchType_A9265.Visible;
			}
			set
			{
				short num = (short)905269867;
				short num2 = num;
				num = (short)758403691;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2134048768;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1171914753;
				if (num != 0)
				{
				}
				num = (short)869138432;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTASquelchType_A9265.Visible = value;
			}
		}

		// Token: 0x17006343 RID: 25411
		// (get) Token: 0x0600C622 RID: 50722 RVA: 0x00B9A598 File Offset: 0x00B98798
		// (set) Token: 0x0600C623 RID: 50723 RVA: 0x00B9A64C File Offset: 0x00B9884C
		public bool CnvPerConventionalChannelOptionsTASquelchType_A9265_Editable
		{
			get
			{
				short num = (short)705897470;
				short num2 = num;
				num = (short)934028286;
				switch (num2 == num)
				{
				default:
				{
					num = (short)321847296;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)677576705;
				if (num != 0)
				{
				}
				num = (short)2037448704;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTASquelchType_A9265.Editable;
			}
			set
			{
				short num = (short)806332308;
				short num2 = num;
				num = (short)444770196;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1024262144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1968177152;
				if (num != 0)
				{
				}
				num = (short)1114505217;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTASquelchType_A9265.Editable = value;
			}
		}

		// Token: 0x17006344 RID: 25412
		// (get) Token: 0x0600C624 RID: 50724 RVA: 0x00B9A704 File Offset: 0x00B98904
		internal string CnvPerConventionalChannelOptionsTASquelchType_A9265_UILabel
		{
			get
			{
				short num = (short)651314184;
				short num2 = num;
				num = (short)1519272968;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1218314240;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1219756033;
				if (num != 0)
				{
				}
				num = (short)1591934976;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTASquelchType_A9265.UIName;
			}
		}

		// Token: 0x17006345 RID: 25413
		// (get) Token: 0x0600C625 RID: 50725 RVA: 0x00B9A7B4 File Offset: 0x00B989B4
		// (set) Token: 0x0600C626 RID: 50726 RVA: 0x00B9A868 File Offset: 0x00B98A68
		internal bool CnvPerConventionalChannelOptionsTASquelchType_A9265_HiddenStatic
		{
			get
			{
				short num = (short)1763966977;
				if (num != 0)
				{
				}
				num = (short)1712455680;
				short num2 = num;
				num = (short)1188675222;
				short num3 = num;
				num = (short)2044247702;
				switch (num3 == num)
				{
				}
				num = (short)1381629952;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTASquelchType_A9265.HiddenStatic;
			}
			set
			{
				short num = (short)290123289;
				short num2 = num;
				num = (short)464776729;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1886912512;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)461701121;
				if (num != 0)
				{
				}
				num = (short)1368784896;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTASquelchType_A9265.HiddenStatic = value;
			}
		}

		// Token: 0x17006346 RID: 25414
		// (get) Token: 0x0600C627 RID: 50727 RVA: 0x00B9A91C File Offset: 0x00B98B1C
		// (set) Token: 0x0600C628 RID: 50728 RVA: 0x00B9A9D0 File Offset: 0x00B98BD0
		internal bool CnvPerConventionalChannelOptionsTASquelchType_A9265_HiddenDynamic
		{
			get
			{
				short num = (short)875961873;
				short num2 = num;
				num = (short)631447057;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1427046400;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1230503937;
				if (num != 0)
				{
				}
				num = (short)1841037312;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTASquelchType_A9265.HiddenDynamic;
			}
			set
			{
				short num = (short)1104695895;
				short num2 = num;
				num = (short)1766740567;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1600913408;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1424228353;
				if (num != 0)
				{
				}
				num = (short)1568210944;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTASquelchType_A9265.HiddenDynamic = value;
			}
		}

		// Token: 0x17006347 RID: 25415
		// (get) Token: 0x0600C629 RID: 50729 RVA: 0x00B9AA88 File Offset: 0x00B98C88
		public bool CnvPerConventionalChannelOptionsTASquelchType_A9265_HasDiffs
		{
			get
			{
				short num = (short)237530680;
				short num2 = num;
				num = (short)926314040;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1510277120;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)338100225;
				if (num != 0)
				{
				}
				num = (short)1943535616;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTASquelchType_A9265._HasDiffs;
			}
		}

		// Token: 0x17006348 RID: 25416
		// (get) Token: 0x0600C62A RID: 50730 RVA: 0x00B9AB40 File Offset: 0x00B98D40
		// (set) Token: 0x0600C62B RID: 50731 RVA: 0x00B9ABF8 File Offset: 0x00B98DF8
		public int CnvPerConventionalChannelOptionsASTROTalkgroupID_A9281Value
		{
			get
			{
				short num = (short)1173007611;
				short num2 = num;
				num = (short)1985785083;
				switch (num2 == num)
				{
				default:
				{
					num = (short)361758720;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)175439873;
				if (num != 0)
				{
				}
				num = (short)32964608;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsASTROTalkgroupID_A9281.Value;
			}
			set
			{
				short num = (short)1143088903;
				short num2 = num;
				num = (short)654714631;
				switch (num2 == num)
				{
				default:
				{
					num = (short)532152320;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)333053953;
				if (num != 0)
				{
				}
				num = (short)1995374592;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsASTROTalkgroupID_A9281.Value = value;
			}
		}

		// Token: 0x17006349 RID: 25417
		// (get) Token: 0x0600C62C RID: 50732 RVA: 0x00B9ACAC File Offset: 0x00B98EAC
		// (set) Token: 0x0600C62D RID: 50733 RVA: 0x00B9AD60 File Offset: 0x00B98F60
		public string CnvPerConventionalChannelOptionsASTROTalkgroupID_A9281_UIValue
		{
			get
			{
				short num = (short)1077076928;
				short num2 = num;
				num = (short)691266496;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1149435904;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1124007937;
				if (num != 0)
				{
				}
				num = (short)483852288;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsASTROTalkgroupID_A9281.UIValue;
			}
			set
			{
				short num = (short)474918475;
				short num2 = num;
				num = (short)394178123;
				switch (num2 == num)
				{
				default:
				{
					num = (short)434241536;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)944832513;
				if (num != 0)
				{
				}
				num = (short)438566912;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsASTROTalkgroupID_A9281.UIValue = value;
			}
		}

		// Token: 0x1700634A RID: 25418
		// (get) Token: 0x0600C62E RID: 50734 RVA: 0x00B9AE18 File Offset: 0x00B99018
		public global::AcpBusinessLayer.AcpRecRefField CnvPerConventionalChannelOptionsASTROTalkgroupID_A9281
		{
			get
			{
				short num = (short)490625756;
				short num2 = num;
				num = (short)1321229020;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1652228096;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)575143937;
				if (num != 0)
				{
				}
				num = (short)1777598464;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsASTROTalkgroupID_A9281;
			}
		}

		// Token: 0x1700634B RID: 25419
		// (get) Token: 0x0600C62F RID: 50735 RVA: 0x00B9AEC8 File Offset: 0x00B990C8
		// (set) Token: 0x0600C630 RID: 50736 RVA: 0x00B9AF80 File Offset: 0x00B99180
		public bool CnvPerConventionalChannelOptionsASTROTalkgroupID_A9281_Applicable
		{
			get
			{
				short num = (short)2031785319;
				short num2 = num;
				num = (short)414946663;
				switch (num2 == num)
				{
				default:
				{
					num = (short)441843712;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1443430401;
				if (num != 0)
				{
				}
				num = (short)1852768256;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsASTROTalkgroupID_A9281.Applicable;
			}
			set
			{
				short num = (short)1912254973;
				short num2 = num;
				num = (short)1216655869;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1060831232;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1917845505;
				if (num != 0)
				{
				}
				num = (short)1488322560;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsASTROTalkgroupID_A9281.Applicable = value;
			}
		}

		// Token: 0x1700634C RID: 25420
		// (get) Token: 0x0600C631 RID: 50737 RVA: 0x00B9B034 File Offset: 0x00B99234
		// (set) Token: 0x0600C632 RID: 50738 RVA: 0x00B9B0E8 File Offset: 0x00B992E8
		public bool CnvPerConventionalChannelOptionsASTROTalkgroupID_A9281_Valid
		{
			get
			{
				short num = (short)124179983;
				short num2 = num;
				num = (short)1103025679;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1281359872;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)209125377;
				if (num != 0)
				{
				}
				num = (short)1900609536;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsASTROTalkgroupID_A9281.Valid;
			}
			set
			{
				short num = (short)399467435;
				short num2 = num;
				num = (short)1578001323;
				switch (num2 == num)
				{
				default:
				{
					num = (short)645070848;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1751842817;
				if (num != 0)
				{
				}
				num = (short)684851200;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsASTROTalkgroupID_A9281.Valid = value;
			}
		}

		// Token: 0x1700634D RID: 25421
		// (get) Token: 0x0600C633 RID: 50739 RVA: 0x00B9B19C File Offset: 0x00B9939C
		// (set) Token: 0x0600C634 RID: 50740 RVA: 0x00B9B250 File Offset: 0x00B99450
		public bool CnvPerConventionalChannelOptionsASTROTalkgroupID_A9281_Visible
		{
			get
			{
				short num = (short)733734782;
				short num2 = num;
				num = (short)1701570430;
				switch (num2 == num)
				{
				default:
				{
					num = (short)149225472;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)101515265;
				if (num != 0)
				{
				}
				num = (short)889454592;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsASTROTalkgroupID_A9281.Visible;
			}
			set
			{
				short num = (short)364456786;
				short num2 = num;
				num = (short)1727474514;
				switch (num2 == num)
				{
				default:
				{
					num = (short)741539840;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)693370881;
				if (num != 0)
				{
				}
				num = (short)583204864;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsASTROTalkgroupID_A9281.Visible = value;
			}
		}

		// Token: 0x1700634E RID: 25422
		// (get) Token: 0x0600C635 RID: 50741 RVA: 0x00B9B308 File Offset: 0x00B99508
		// (set) Token: 0x0600C636 RID: 50742 RVA: 0x00B9B3BC File Offset: 0x00B995BC
		public bool CnvPerConventionalChannelOptionsASTROTalkgroupID_A9281_Editable
		{
			get
			{
				short num = (short)2090564147;
				short num2 = num;
				num = (short)1004501555;
				switch (num2 == num)
				{
				default:
				{
					num = (short)119013376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)437649409;
				if (num != 0)
				{
				}
				num = (short)1892614144;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsASTROTalkgroupID_A9281.Editable;
			}
			set
			{
				short num = (short)1523777537;
				if (num != 0)
				{
				}
				num = (short)2045575168;
				short num2 = num;
				num = (short)1121665087;
				short num3 = num;
				num = (short)965361727;
				switch (num3 == num)
				{
				}
				num = (short)546897920;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsASTROTalkgroupID_A9281.Editable = value;
			}
		}

		// Token: 0x1700634F RID: 25423
		// (get) Token: 0x0600C637 RID: 50743 RVA: 0x00B9B470 File Offset: 0x00B99670
		internal string CnvPerConventionalChannelOptionsASTROTalkgroupID_A9281_UILabel
		{
			get
			{
				short num = (short)776145602;
				short num2 = num;
				num = (short)838863554;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1973944320;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1304952832;
				if (num != 0)
				{
				}
				num = (short)1877737473;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsASTROTalkgroupID_A9281.UIName;
			}
		}

		// Token: 0x17006350 RID: 25424
		// (get) Token: 0x0600C638 RID: 50744 RVA: 0x00B9B524 File Offset: 0x00B99724
		// (set) Token: 0x0600C639 RID: 50745 RVA: 0x00B9B5DC File Offset: 0x00B997DC
		internal bool CnvPerConventionalChannelOptionsASTROTalkgroupID_A9281_HiddenStatic
		{
			get
			{
				short num = (short)1905200261;
				short num2 = num;
				num = (short)302910597;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1784348672;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1975517185;
				if (num != 0)
				{
				}
				num = (short)1690107904;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsASTROTalkgroupID_A9281.HiddenStatic;
			}
			set
			{
				short num = (short)109182977;
				if (num != 0)
				{
				}
				num = (short)1674117120;
				short num2 = num;
				num = (short)1038373573;
				short num3 = num;
				num = (short)1914786501;
				switch (num3 == num)
				{
				}
				num = (short)991887360;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsASTROTalkgroupID_A9281.HiddenStatic = value;
			}
		}

		// Token: 0x17006351 RID: 25425
		// (get) Token: 0x0600C63A RID: 50746 RVA: 0x00B9B694 File Offset: 0x00B99894
		// (set) Token: 0x0600C63B RID: 50747 RVA: 0x00B9B744 File Offset: 0x00B99944
		internal bool CnvPerConventionalChannelOptionsASTROTalkgroupID_A9281_HiddenDynamic
		{
			get
			{
				short num = (short)1117290320;
				short num2 = num;
				num = (short)346259280;
				switch (num2 == num)
				{
				default:
				{
					num = (short)432144384;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1244069888;
				if (num != 0)
				{
				}
				num = (short)389545985;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsASTROTalkgroupID_A9281.HiddenDynamic;
			}
			set
			{
				short num = (short)875550965;
				short num2 = num;
				num = (short)752933109;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2138636288;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1332543489;
				if (num != 0)
				{
				}
				num = (short)432406528;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsASTROTalkgroupID_A9281.HiddenDynamic = value;
			}
		}

		// Token: 0x17006352 RID: 25426
		// (get) Token: 0x0600C63C RID: 50748 RVA: 0x00B9B7F8 File Offset: 0x00B999F8
		public bool CnvPerConventionalChannelOptionsASTROTalkgroupID_A9281_HasDiffs
		{
			get
			{
				short num = (short)469599863;
				short num2 = num;
				num = (short)2130871927;
				switch (num2 == num)
				{
				default:
				{
					num = (short)458817536;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)939130881;
				if (num != 0)
				{
				}
				num = (short)955711488;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsASTROTalkgroupID_A9281._HasDiffs;
			}
		}

		// Token: 0x17006353 RID: 25427
		// (get) Token: 0x0600C63D RID: 50749 RVA: 0x00B9B8AC File Offset: 0x00B99AAC
		// (set) Token: 0x0600C63E RID: 50750 RVA: 0x00B9B960 File Offset: 0x00B99B60
		public int CnvPerConventionalChannelOptionsTxDPLCode_A9409Value
		{
			get
			{
				short num = (short)1874493964;
				short num2 = num;
				num = (short)1985643020;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1543766016;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)262275072;
				if (num != 0)
				{
				}
				num = (short)389152769;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTxDPLCode_A9409.Value;
			}
			set
			{
				short num = (short)1943770427;
				short num2 = num;
				num = (short)1569559867;
				switch (num2 == num)
				{
				default:
				{
					num = (short)359596032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)661979137;
				if (num != 0)
				{
				}
				num = (short)180158464;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTxDPLCode_A9409.Value = value;
			}
		}

		// Token: 0x17006354 RID: 25428
		// (get) Token: 0x0600C63F RID: 50751 RVA: 0x00B9BA14 File Offset: 0x00B99C14
		// (set) Token: 0x0600C640 RID: 50752 RVA: 0x00B9BAC8 File Offset: 0x00B99CC8
		public string CnvPerConventionalChannelOptionsTxDPLCode_A9409_UIValue
		{
			get
			{
				short num = (short)1575572479;
				short num2 = num;
				num = (short)1242059775;
				switch (num2 == num)
				{
				}
				num = (short)288096257;
				if (num != 0)
				{
				}
				num = (short)178978816;
				short num3 = num;
				num = (short)1020919808;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTxDPLCode_A9409.UIValue;
			}
			set
			{
				short num = (short)2097538289;
				short num2 = num;
				num = (short)134866161;
				switch (num2 == num)
				{
				}
				num = (short)718536704;
				if (num != 0)
				{
				}
				num = (short)293666816;
				short num3 = num;
				num = (short)1744961537;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTxDPLCode_A9409.UIValue = value;
			}
		}

		// Token: 0x17006355 RID: 25429
		// (get) Token: 0x0600C641 RID: 50753 RVA: 0x00B9BB80 File Offset: 0x00B99D80
		public global::AcpBusinessLayer.AcpListField CnvPerConventionalChannelOptionsTxDPLCode_A9409
		{
			get
			{
				short num = (short)1419036367;
				short num2 = num;
				num = (short)1733215951;
				switch (num2 == num)
				{
				}
				num = (short)393936897;
				if (num != 0)
				{
				}
				num = (short)1402929152;
				short num3 = num;
				num = (short)2102525952;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTxDPLCode_A9409;
			}
		}

		// Token: 0x17006356 RID: 25430
		// (get) Token: 0x0600C642 RID: 50754 RVA: 0x00B9BC34 File Offset: 0x00B99E34
		// (set) Token: 0x0600C643 RID: 50755 RVA: 0x00B9BCE8 File Offset: 0x00B99EE8
		public bool CnvPerConventionalChannelOptionsTxDPLCode_A9409_Applicable
		{
			get
			{
				short num = (short)1863599018;
				short num2 = num;
				num = (short)2141209514;
				switch (num2 == num)
				{
				}
				num = (short)173604865;
				if (num != 0)
				{
				}
				num = (short)1957625856;
				short num3 = num;
				num = (short)1005125632;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTxDPLCode_A9409.Applicable;
			}
			set
			{
				short num = (short)239628740;
				short num2 = num;
				num = (short)1756656068;
				switch (num2 == num)
				{
				}
				num = (short)1421541376;
				if (num != 0)
				{
				}
				num = (short)1120206848;
				short num3 = num;
				num = (short)964165633;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTxDPLCode_A9409.Applicable = value;
			}
		}

		// Token: 0x17006357 RID: 25431
		// (get) Token: 0x0600C644 RID: 50756 RVA: 0x00B9BD9C File Offset: 0x00B99F9C
		// (set) Token: 0x0600C645 RID: 50757 RVA: 0x00B9BE50 File Offset: 0x00B9A050
		public bool CnvPerConventionalChannelOptionsTxDPLCode_A9409_Valid
		{
			get
			{
				short num = (short)1507060230;
				short num2 = num;
				num = (short)1240525318;
				switch (num2 == num)
				{
				}
				num = (short)636157952;
				if (num != 0)
				{
				}
				num = (short)2135556096;
				short num3 = num;
				num = (short)1937768449;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTxDPLCode_A9409.Valid;
			}
			set
			{
				short num = (short)422182913;
				if (num != 0)
				{
				}
				num = (short)1290843870;
				short num2 = num;
				num = (short)467646174;
				switch (num2 == num)
				{
				}
				num = (short)1073020928;
				short num3 = num;
				num = (short)2020016128;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTxDPLCode_A9409.Valid = value;
			}
		}

		// Token: 0x17006358 RID: 25432
		// (get) Token: 0x0600C646 RID: 50758 RVA: 0x00B9BF08 File Offset: 0x00B9A108
		// (set) Token: 0x0600C647 RID: 50759 RVA: 0x00B9BFBC File Offset: 0x00B9A1BC
		public bool CnvPerConventionalChannelOptionsTxDPLCode_A9409_Visible
		{
			get
			{
				short num = (short)1891696641;
				if (num != 0)
				{
				}
				num = (short)743268851;
				short num2 = num;
				num = (short)116089331;
				switch (num2 == num)
				{
				}
				num = (short)1255866368;
				short num3 = num;
				num = (short)2017787904;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTxDPLCode_A9409.Visible;
			}
			set
			{
				short num = (short)1035972025;
				short num2 = num;
				num = (short)1556852153;
				switch (num2 == num)
				{
				}
				num = (short)78577665;
				if (num != 0)
				{
				}
				num = (short)1253048320;
				short num3 = num;
				num = (short)115474432;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTxDPLCode_A9409.Visible = value;
			}
		}

		// Token: 0x17006359 RID: 25433
		// (get) Token: 0x0600C648 RID: 50760 RVA: 0x00B9C070 File Offset: 0x00B9A270
		// (set) Token: 0x0600C649 RID: 50761 RVA: 0x00B9C128 File Offset: 0x00B9A328
		public bool CnvPerConventionalChannelOptionsTxDPLCode_A9409_Editable
		{
			get
			{
				short num = (short)335574258;
				short num2 = num;
				num = (short)1221031154;
				switch (num2 == num)
				{
				}
				num = (short)1596260353;
				if (num != 0)
				{
				}
				num = (short)1150353408;
				short num3 = num;
				num = (short)195100672;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTxDPLCode_A9409.Editable;
			}
			set
			{
				short num = (short)232053225;
				short num2 = num;
				num = (short)553966057;
				switch (num2 == num)
				{
				}
				num = (short)1076822017;
				if (num != 0)
				{
				}
				num = (short)2065301504;
				short num3 = num;
				num = (short)300548096;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTxDPLCode_A9409.Editable = value;
			}
		}

		// Token: 0x1700635A RID: 25434
		// (get) Token: 0x0600C64A RID: 50762 RVA: 0x00B9C1DC File Offset: 0x00B9A3DC
		internal string CnvPerConventionalChannelOptionsTxDPLCode_A9409_UILabel
		{
			get
			{
				short num = (short)1545799365;
				short num2 = num;
				num = (short)2014906053;
				switch (num2 == num)
				{
				}
				num = (short)659423233;
				if (num != 0)
				{
				}
				num = (short)1218707456;
				short num3 = num;
				num = (short)386859008;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTxDPLCode_A9409.UIName;
			}
		}

		// Token: 0x1700635B RID: 25435
		// (get) Token: 0x0600C64B RID: 50763 RVA: 0x00B9C290 File Offset: 0x00B9A490
		// (set) Token: 0x0600C64C RID: 50764 RVA: 0x00B9C348 File Offset: 0x00B9A548
		internal bool CnvPerConventionalChannelOptionsTxDPLCode_A9409_HiddenStatic
		{
			get
			{
				short num = (short)253775692;
				short num2 = num;
				num = (short)964251468;
				switch (num2 == num)
				{
				}
				num = (short)908918784;
				if (num != 0)
				{
				}
				num = (short)982319104;
				short num3 = num;
				num = (short)2060648449;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTxDPLCode_A9409.HiddenStatic;
			}
			set
			{
				short num = (short)1176952036;
				short num2 = num;
				num = (short)1691147492;
				switch (num2 == num)
				{
				}
				num = (short)1909522432;
				if (num != 0)
				{
				}
				num = (short)919207936;
				short num3 = num;
				num = (short)48300033;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTxDPLCode_A9409.HiddenStatic = value;
			}
		}

		// Token: 0x1700635C RID: 25436
		// (get) Token: 0x0600C64D RID: 50765 RVA: 0x00B9C404 File Offset: 0x00B9A604
		// (set) Token: 0x0600C64E RID: 50766 RVA: 0x00B9C4B8 File Offset: 0x00B9A6B8
		internal bool CnvPerConventionalChannelOptionsTxDPLCode_A9409_HiddenDynamic
		{
			get
			{
				short num = (short)24958526;
				short num2 = num;
				num = (short)385930814;
				switch (num2 == num)
				{
				}
				num = (short)2094727169;
				if (num != 0)
				{
				}
				num = (short)2007302144;
				short num3 = num;
				num = (short)674234368;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTxDPLCode_A9409.HiddenDynamic;
			}
			set
			{
				short num = (short)1077149697;
				if (num != 0)
				{
				}
				num = (short)1820749735;
				short num2 = num;
				num = (short)2017488807;
				switch (num2 == num)
				{
				}
				num = (short)1841954816;
				short num3 = num;
				num = (short)563544064;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTxDPLCode_A9409.HiddenDynamic = value;
			}
		}

		// Token: 0x1700635D RID: 25437
		// (get) Token: 0x0600C64F RID: 50767 RVA: 0x00B9C56C File Offset: 0x00B9A76C
		public bool CnvPerConventionalChannelOptionsTxDPLCode_A9409_HasDiffs
		{
			get
			{
				short num = (short)1660946230;
				short num2 = num;
				num = (short)1853490998;
				switch (num2 == num)
				{
				}
				num = (short)887947265;
				if (num != 0)
				{
				}
				num = (short)169869312;
				short num3 = num;
				num = (short)1787756544;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTxDPLCode_A9409._HasDiffs;
			}
		}

		// Token: 0x1700635E RID: 25438
		// (get) Token: 0x0600C650 RID: 50768 RVA: 0x00B9C620 File Offset: 0x00B9A820
		// (set) Token: 0x0600C651 RID: 50769 RVA: 0x00B9C6D4 File Offset: 0x00B9A8D4
		public bool CnvPerConventionalChannelOptionsTxDPLInvert_A9410Value
		{
			get
			{
				short num = (short)1996795339;
				short num2 = num;
				num = (short)867020235;
				switch (num2 == num)
				{
				}
				num = (short)1249378305;
				if (num != 0)
				{
				}
				num = (short)899612672;
				short num3 = num;
				num = (short)1840513024;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTxDPLInvert_A9410.Value;
			}
			set
			{
				short num = (short)1474256154;
				short num2 = num;
				num = (short)1550474522;
				switch (num2 == num)
				{
				}
				num = (short)95092736;
				if (num != 0)
				{
				}
				num = (short)1712455680;
				short num3 = num;
				num = (short)194445313;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTxDPLInvert_A9410.Value = value;
			}
		}

		// Token: 0x1700635F RID: 25439
		// (get) Token: 0x0600C652 RID: 50770 RVA: 0x00B9C788 File Offset: 0x00B9A988
		public global::AcpBusinessLayer.AcpField<bool> CnvPerConventionalChannelOptionsTxDPLInvert_A9410
		{
			get
			{
				short num = (short)363074511;
				short num2 = num;
				num = (short)689443791;
				switch (num2 == num)
				{
				}
				num = (short)1655439360;
				if (num != 0)
				{
				}
				num = (short)34340864;
				short num3 = num;
				num = (short)884473857;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTxDPLInvert_A9410;
			}
		}

		// Token: 0x17006360 RID: 25440
		// (get) Token: 0x0600C653 RID: 50771 RVA: 0x00B9C838 File Offset: 0x00B9AA38
		// (set) Token: 0x0600C654 RID: 50772 RVA: 0x00B9C8EC File Offset: 0x00B9AAEC
		public bool CnvPerConventionalChannelOptionsTxDPLInvert_A9410_UIValue
		{
			get
			{
				short num = (short)839135787;
				short num2 = num;
				num = (short)423047723;
				switch (num2 == num)
				{
				}
				num = (short)853934081;
				if (num != 0)
				{
				}
				num = (short)1349386240;
				short num3 = num;
				num = (short)1154940928;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTxDPLInvert_A9410.Value;
			}
			set
			{
				short num = (short)798565406;
				short num2 = num;
				num = (short)53748766;
				switch (num2 == num)
				{
				}
				num = (short)780664833;
				if (num != 0)
				{
				}
				num = (short)1938358272;
				short num3 = num;
				num = (short)1613627392;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTxDPLInvert_A9410.Value = value;
			}
		}

		// Token: 0x17006361 RID: 25441
		// (get) Token: 0x0600C655 RID: 50773 RVA: 0x00B9C9A0 File Offset: 0x00B9ABA0
		// (set) Token: 0x0600C656 RID: 50774 RVA: 0x00B9CA58 File Offset: 0x00B9AC58
		public bool CnvPerConventionalChannelOptionsTxDPLInvert_A9410_Applicable
		{
			get
			{
				short num = (short)35726847;
				short num2 = num;
				num = (short)234759679;
				switch (num2 == num)
				{
				}
				num = (short)1252327425;
				if (num != 0)
				{
				}
				num = (short)217645056;
				short num3 = num;
				num = (short)1740636160;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTxDPLInvert_A9410.Applicable;
			}
			set
			{
				short num = (short)698599520;
				short num2 = num;
				num = (short)1427884128;
				switch (num2 == num)
				{
				}
				num = (short)1674313728;
				if (num != 0)
				{
				}
				num = (short)444465152;
				short num3 = num;
				num = (short)322633729;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTxDPLInvert_A9410.Applicable = value;
			}
		}

		// Token: 0x17006362 RID: 25442
		// (get) Token: 0x0600C657 RID: 50775 RVA: 0x00B9CB10 File Offset: 0x00B9AD10
		// (set) Token: 0x0600C658 RID: 50776 RVA: 0x00B9CBC4 File Offset: 0x00B9ADC4
		public bool CnvPerConventionalChannelOptionsTxDPLInvert_A9410_Valid
		{
			get
			{
				short num = (short)1494246740;
				short num2 = num;
				num = (short)1450272084;
				switch (num2 == num)
				{
				}
				num = (short)499253249;
				if (num != 0)
				{
				}
				num = (short)2064842752;
				short num3 = num;
				num = (short)1122238464;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTxDPLInvert_A9410.Valid;
			}
			set
			{
				short num = (short)123802156;
				short num2 = num;
				num = (short)982848044;
				switch (num2 == num)
				{
				}
				num = (short)896925697;
				if (num != 0)
				{
				}
				num = (short)492240896;
				short num3 = num;
				num = (short)1285816320;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTxDPLInvert_A9410.Valid = value;
			}
		}

		// Token: 0x17006363 RID: 25443
		// (get) Token: 0x0600C659 RID: 50777 RVA: 0x00B9CC78 File Offset: 0x00B9AE78
		// (set) Token: 0x0600C65A RID: 50778 RVA: 0x00B9CD2C File Offset: 0x00B9AF2C
		public bool CnvPerConventionalChannelOptionsTxDPLInvert_A9410_Visible
		{
			get
			{
				short num = (short)344660284;
				short num2 = num;
				num = (short)896538940;
				switch (num2 == num)
				{
				}
				num = (short)87556096;
				if (num != 0)
				{
				}
				num = (short)80019456;
				short num3 = num;
				num = (short)329187329;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTxDPLInvert_A9410.Visible;
			}
			set
			{
				short num = (short)1874107151;
				short num2 = num;
				num = (short)71801615;
				switch (num2 == num)
				{
				}
				num = (short)416743425;
				if (num != 0)
				{
				}
				num = (short)1068630016;
				short num3 = num;
				num = (short)675348480;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTxDPLInvert_A9410.Visible = value;
			}
		}

		// Token: 0x17006364 RID: 25444
		// (get) Token: 0x0600C65B RID: 50779 RVA: 0x00B9CDE4 File Offset: 0x00B9AFE4
		// (set) Token: 0x0600C65C RID: 50780 RVA: 0x00B9CE9C File Offset: 0x00B9B09C
		public bool CnvPerConventionalChannelOptionsTxDPLInvert_A9410_Editable
		{
			get
			{
				short num = (short)1803022658;
				short num2 = num;
				num = (short)47444290;
				switch (num2 == num)
				{
				}
				num = (short)226557953;
				if (num != 0)
				{
				}
				num = (short)1628241920;
				short num3 = num;
				num = (short)98959360;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTxDPLInvert_A9410.Editable;
			}
			set
			{
				short num = (short)1483931649;
				if (num != 0)
				{
				}
				num = (short)186662725;
				short num2 = num;
				num = (short)2041855813;
				switch (num2 == num)
				{
				}
				num = (short)145293312;
				short num3 = num;
				num = (short)1082654720;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTxDPLInvert_A9410.Editable = value;
			}
		}

		// Token: 0x17006365 RID: 25445
		// (get) Token: 0x0600C65D RID: 50781 RVA: 0x00B9CF50 File Offset: 0x00B9B150
		internal string CnvPerConventionalChannelOptionsTxDPLInvert_A9410_UILabel
		{
			get
			{
				short num = (short)1900675073;
				if (num != 0)
				{
				}
				num = (short)1376654627;
				short num2 = num;
				num = (short)1172313379;
				switch (num2 == num)
				{
				}
				num = (short)526450688;
				short num3 = num;
				num = (short)708444160;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTxDPLInvert_A9410.UIName;
			}
		}

		// Token: 0x17006366 RID: 25446
		// (get) Token: 0x0600C65E RID: 50782 RVA: 0x00B9D004 File Offset: 0x00B9B204
		// (set) Token: 0x0600C65F RID: 50783 RVA: 0x00B9D0BC File Offset: 0x00B9B2BC
		internal bool CnvPerConventionalChannelOptionsTxDPLInvert_A9410_HiddenStatic
		{
			get
			{
				short num = (short)1538850817;
				if (num != 0)
				{
				}
				num = (short)814323610;
				short num2 = num;
				num = (short)417896346;
				switch (num2 == num)
				{
				}
				num = (short)417464320;
				short num3 = num;
				num = (short)1811218432;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTxDPLInvert_A9410.HiddenStatic;
			}
			set
			{
				short num = (short)1969016906;
				short num2 = num;
				num = (short)1655165002;
				switch (num2 == num)
				{
				}
				num = (short)519766017;
				if (num != 0)
				{
				}
				num = (short)1844117504;
				short num3 = num;
				num = (short)85655552;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTxDPLInvert_A9410.HiddenStatic = value;
			}
		}

		// Token: 0x17006367 RID: 25447
		// (get) Token: 0x0600C660 RID: 50784 RVA: 0x00B9D174 File Offset: 0x00B9B374
		// (set) Token: 0x0600C661 RID: 50785 RVA: 0x00B9D228 File Offset: 0x00B9B428
		internal bool CnvPerConventionalChannelOptionsTxDPLInvert_A9410_HiddenDynamic
		{
			get
			{
				short num = (short)704895229;
				short num2 = num;
				num = (short)581097725;
				switch (num2 == num)
				{
				}
				num = (short)1946025985;
				if (num != 0)
				{
				}
				num = (short)668467200;
				short num3 = num;
				num = (short)1533280256;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTxDPLInvert_A9410.HiddenDynamic;
			}
			set
			{
				short num = (short)252074236;
				short num2 = num;
				num = (short)610687228;
				switch (num2 == num)
				{
				}
				num = (short)102236160;
				if (num != 0)
				{
				}
				num = (short)1306198016;
				short num3 = num;
				num = (short)832503809;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTxDPLInvert_A9410.HiddenDynamic = value;
			}
		}

		// Token: 0x17006368 RID: 25448
		// (get) Token: 0x0600C662 RID: 50786 RVA: 0x00B9D2DC File Offset: 0x00B9B4DC
		public bool CnvPerConventionalChannelOptionsTxDPLInvert_A9410_HasDiffs
		{
			get
			{
				short num = (short)908149270;
				short num2 = num;
				num = (short)697778710;
				switch (num2 == num)
				{
				}
				num = (short)1809842176;
				if (num != 0)
				{
				}
				num = (short)257294336;
				short num3 = num;
				num = (short)1745944577;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTxDPLInvert_A9410._HasDiffs;
			}
		}

		// Token: 0x17006369 RID: 25449
		// (get) Token: 0x0600C663 RID: 50787 RVA: 0x00B9D390 File Offset: 0x00B9B590
		// (set) Token: 0x0600C664 RID: 50788 RVA: 0x00B9D444 File Offset: 0x00B9B644
		public int CnvPerConventionalChannelOptionsTxFrequency_A9414Value
		{
			get
			{
				short num = (short)534125808;
				short num2 = num;
				num = (short)1731927280;
				switch (num2 == num)
				{
				}
				num = (short)500301824;
				if (num != 0)
				{
				}
				num = (short)1619984384;
				short num3 = num;
				num = (short)93323265;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTxFrequency_A9414.Value;
			}
			set
			{
				short num = (short)877816481;
				short num2 = num;
				num = (short)427059873;
				switch (num2 == num)
				{
				}
				num = (short)1250689024;
				if (num != 0)
				{
				}
				num = (short)278134784;
				short num3 = num;
				num = (short)633929729;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTxFrequency_A9414.Value = value;
			}
		}

		// Token: 0x1700636A RID: 25450
		// (get) Token: 0x0600C665 RID: 50789 RVA: 0x00B9D4FC File Offset: 0x00B9B6FC
		// (set) Token: 0x0600C666 RID: 50790 RVA: 0x00B9D5B4 File Offset: 0x00B9B7B4
		public string CnvPerConventionalChannelOptionsTxFrequency_A9414_UIValue
		{
			get
			{
				short num = (short)708634903;
				short num2 = num;
				num = (short)280946967;
				switch (num2 == num)
				{
				}
				num = (short)820314113;
				if (num != 0)
				{
				}
				num = (short)229834752;
				short num3 = num;
				num = (short)292159488;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTxFrequency_A9414.UIValue;
			}
			set
			{
				short num = (short)154053472;
				short num2 = num;
				num = (short)1953016672;
				switch (num2 == num)
				{
				}
				num = (short)1503592448;
				if (num != 0)
				{
				}
				num = (short)600571904;
				short num3 = num;
				num = (short)1000079361;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTxFrequency_A9414.UIValue = value;
			}
		}

		// Token: 0x1700636B RID: 25451
		// (get) Token: 0x0600C667 RID: 50791 RVA: 0x00B9D66C File Offset: 0x00B9B86C
		public global::AcpBusinessLayer.AcpFrequencyField CnvPerConventionalChannelOptionsTxFrequency_A9414
		{
			get
			{
				short num = (short)1127611167;
				short num2 = num;
				num = (short)1009974047;
				switch (num2 == num)
				{
				}
				num = (short)315359233;
				if (num != 0)
				{
				}
				num = (short)402391040;
				short num3 = num;
				num = (short)833880064;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTxFrequency_A9414;
			}
		}

		// Token: 0x1700636C RID: 25452
		// (get) Token: 0x0600C668 RID: 50792 RVA: 0x00B9D71C File Offset: 0x00B9B91C
		// (set) Token: 0x0600C669 RID: 50793 RVA: 0x00B9D7D0 File Offset: 0x00B9B9D0
		internal int CnvPerConventionalChannelOptionsTxFrequency_A9414Min
		{
			get
			{
				short num = (short)1968206875;
				short num2 = num;
				num = (short)1455780891;
				switch (num2 == num)
				{
				}
				num = (short)449118209;
				if (num != 0)
				{
				}
				num = (short)1016987648;
				short num3 = num;
				num = (short)1826750464;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTxFrequency_A9414.Min;
			}
			set
			{
				short num = (short)1003945985;
				if (num != 0)
				{
				}
				num = (short)976598514;
				short num2 = num;
				num = (short)658486770;
				switch (num2 == num)
				{
				}
				num = (short)980942848;
				short num3 = num;
				num = (short)1839005696;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTxFrequency_A9414.Min = value;
			}
		}

		// Token: 0x1700636D RID: 25453
		// (get) Token: 0x0600C66A RID: 50794 RVA: 0x00B9D884 File Offset: 0x00B9BA84
		// (set) Token: 0x0600C66B RID: 50795 RVA: 0x00B9D938 File Offset: 0x00B9BB38
		internal int CnvPerConventionalChannelOptionsTxFrequency_A9414Max
		{
			get
			{
				short num = (short)1656451724;
				short num2 = num;
				num = (short)965702284;
				switch (num2 == num)
				{
				}
				num = (short)1219231745;
				if (num != 0)
				{
				}
				num = (short)454295552;
				short num3 = num;
				num = (short)606535680;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTxFrequency_A9414.Max;
			}
			set
			{
				short num = (short)637358440;
				short num2 = num;
				num = (short)1144934760;
				switch (num2 == num)
				{
				}
				num = (short)1328742401;
				if (num != 0)
				{
				}
				num = (short)1858928640;
				short num3 = num;
				num = (short)1904672768;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTxFrequency_A9414.Max = value;
			}
		}

		// Token: 0x1700636E RID: 25454
		// (get) Token: 0x0600C66C RID: 50796 RVA: 0x00B9D9EC File Offset: 0x00B9BBEC
		// (set) Token: 0x0600C66D RID: 50797 RVA: 0x00B9DAA4 File Offset: 0x00B9BCA4
		internal int CnvPerConventionalChannelOptionsTxFrequency_A9414Step
		{
			get
			{
				short num = (short)1217033069;
				short num2 = num;
				num = (short)1191277421;
				switch (num2 == num)
				{
				}
				num = (short)388038656;
				if (num != 0)
				{
				}
				num = (short)908328960;
				short num3 = num;
				num = (short)1498611713;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTxFrequency_A9414.StepSize;
			}
			set
			{
				short num = (short)2136862963;
				short num2 = num;
				num = (short)687468787;
				switch (num2 == num)
				{
				}
				num = (short)521535489;
				if (num != 0)
				{
				}
				num = (short)600309760;
				short num3 = num;
				num = (short)1898840064;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTxFrequency_A9414.StepSize = value;
			}
		}

		// Token: 0x1700636F RID: 25455
		// (get) Token: 0x0600C66E RID: 50798 RVA: 0x00B9DB58 File Offset: 0x00B9BD58
		// (set) Token: 0x0600C66F RID: 50799 RVA: 0x00B9DC10 File Offset: 0x00B9BE10
		public bool CnvPerConventionalChannelOptionsTxFrequency_A9414_Applicable
		{
			get
			{
				short num = (short)678571485;
				short num2 = num;
				num = (short)1829383645;
				switch (num2 == num)
				{
				}
				num = (short)1079967744;
				if (num != 0)
				{
				}
				num = (short)487981056;
				short num3 = num;
				num = (short)1981677569;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTxFrequency_A9414.Applicable;
			}
			set
			{
				short num = (short)1543976519;
				short num2 = num;
				num = (short)1401304647;
				switch (num2 == num)
				{
				}
				num = (short)1344798720;
				if (num != 0)
				{
				}
				num = (short)1510735872;
				short num3 = num;
				num = (short)563085313;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTxFrequency_A9414.Applicable = value;
			}
		}

		// Token: 0x17006370 RID: 25456
		// (get) Token: 0x0600C670 RID: 50800 RVA: 0x00B9DCC4 File Offset: 0x00B9BEC4
		// (set) Token: 0x0600C671 RID: 50801 RVA: 0x00B9DD78 File Offset: 0x00B9BF78
		public bool CnvPerConventionalChannelOptionsTxFrequency_A9414_Valid
		{
			get
			{
				short num = (short)1421992733;
				short num2 = num;
				num = (short)600236829;
				switch (num2 == num)
				{
				}
				num = (short)36044800;
				if (num != 0)
				{
				}
				num = (short)169607168;
				short num3 = num;
				num = (short)417333249;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTxFrequency_A9414.Valid;
			}
			set
			{
				short num = (short)1682143258;
				short num2 = num;
				num = (short)2038790170;
				switch (num2 == num)
				{
				}
				num = (short)925171713;
				if (num != 0)
				{
				}
				num = (short)78118912;
				short num3 = num;
				num = (short)10944512;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTxFrequency_A9414.Valid = value;
			}
		}

		// Token: 0x17006371 RID: 25457
		// (get) Token: 0x0600C672 RID: 50802 RVA: 0x00B9DE30 File Offset: 0x00B9C030
		// (set) Token: 0x0600C673 RID: 50803 RVA: 0x00B9DEE8 File Offset: 0x00B9C0E8
		public bool CnvPerConventionalChannelOptionsTxFrequency_A9414_Visible
		{
			get
			{
				short num = (short)1155017514;
				short num2 = num;
				num = (short)1587358506;
				switch (num2 == num)
				{
				}
				num = (short)539820033;
				if (num != 0)
				{
				}
				num = (short)780140544;
				short num3 = num;
				num = (short)969211904;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTxFrequency_A9414.Visible;
			}
			set
			{
				short num = (short)1031612764;
				short num2 = num;
				num = (short)1969629532;
				switch (num2 == num)
				{
				}
				num = (short)239796225;
				if (num != 0)
				{
				}
				num = (short)1348730880;
				short num3 = num;
				num = (short)958398464;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTxFrequency_A9414.Visible = value;
			}
		}

		// Token: 0x17006372 RID: 25458
		// (get) Token: 0x0600C674 RID: 50804 RVA: 0x00B9DF9C File Offset: 0x00B9C19C
		// (set) Token: 0x0600C675 RID: 50805 RVA: 0x00B9E050 File Offset: 0x00B9C250
		public bool CnvPerConventionalChannelOptionsTxFrequency_A9414_Editable
		{
			get
			{
				short num = (short)1823764029;
				short num2 = num;
				num = (short)318598717;
				switch (num2 == num)
				{
				}
				num = (short)1682243585;
				if (num != 0)
				{
				}
				num = (short)414121984;
				short num3 = num;
				num = (short)1928855552;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTxFrequency_A9414.Editable;
			}
			set
			{
				short num = (short)1324351489;
				if (num != 0)
				{
				}
				num = (short)1287152399;
				short num2 = num;
				num = (short)1492345615;
				switch (num2 == num)
				{
				}
				num = (short)346947584;
				short num3 = num;
				num = (short)1410727936;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTxFrequency_A9414.Editable = value;
			}
		}

		// Token: 0x17006373 RID: 25459
		// (get) Token: 0x0600C676 RID: 50806 RVA: 0x00B9E104 File Offset: 0x00B9C304
		internal string CnvPerConventionalChannelOptionsTxFrequency_A9414_UILabel
		{
			get
			{
				short num = (short)619065312;
				short num2 = num;
				num = (short)1471033312;
				switch (num2 == num)
				{
				}
				num = (short)2141192193;
				if (num != 0)
				{
				}
				num = (short)1735131136;
				short num3 = num;
				num = (short)2041118720;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTxFrequency_A9414.UIName;
			}
		}

		// Token: 0x17006374 RID: 25460
		// (get) Token: 0x0600C677 RID: 50807 RVA: 0x00B9E1B8 File Offset: 0x00B9C3B8
		// (set) Token: 0x0600C678 RID: 50808 RVA: 0x00B9E270 File Offset: 0x00B9C470
		internal bool CnvPerConventionalChannelOptionsTxFrequency_A9414_HiddenStatic
		{
			get
			{
				short num = (short)551944193;
				if (num != 0)
				{
				}
				num = (short)2012987121;
				short num2 = num;
				num = (short)1860746993;
				switch (num2 == num)
				{
				}
				num = (short)993591296;
				short num3 = num;
				num = (short)944373760;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTxFrequency_A9414.HiddenStatic;
			}
			set
			{
				short num = (short)1565589103;
				short num2 = num;
				num = (short)355532399;
				switch (num2 == num)
				{
				}
				num = (short)857079809;
				if (num != 0)
				{
				}
				num = (short)616431616;
				short num3 = num;
				num = (short)1582497792;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTxFrequency_A9414.HiddenStatic = value;
			}
		}

		// Token: 0x17006375 RID: 25461
		// (get) Token: 0x0600C679 RID: 50809 RVA: 0x00B9E328 File Offset: 0x00B9C528
		// (set) Token: 0x0600C67A RID: 50810 RVA: 0x00B9E3E0 File Offset: 0x00B9C5E0
		internal bool CnvPerConventionalChannelOptionsTxFrequency_A9414_HiddenDynamic
		{
			get
			{
				short num = (short)1086905942;
				short num2 = num;
				num = (short)558227030;
				switch (num2 == num)
				{
				}
				num = (short)268697601;
				if (num != 0)
				{
				}
				num = (short)1645477888;
				short num3 = num;
				num = (short)1438777344;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTxFrequency_A9414.HiddenDynamic;
			}
			set
			{
				short num = (short)1903845272;
				short num2 = num;
				num = (short)458186648;
				switch (num2 == num)
				{
				}
				num = (short)1675493376;
				if (num != 0)
				{
				}
				num = (short)2054881280;
				short num3 = num;
				num = (short)229244929;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTxFrequency_A9414.HiddenDynamic = value;
			}
		}

		// Token: 0x17006376 RID: 25462
		// (get) Token: 0x0600C67B RID: 50811 RVA: 0x00B9E498 File Offset: 0x00B9C698
		public bool CnvPerConventionalChannelOptionsTxFrequency_A9414_HasDiffs
		{
			get
			{
				short num = (short)1952305354;
				short num2 = num;
				num = (short)514511050;
				switch (num2 == num)
				{
				}
				num = (short)2036924416;
				if (num != 0)
				{
				}
				num = (short)132579328;
				short num3 = num;
				num = (short)2045050881;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTxFrequency_A9414._HasDiffs;
			}
		}

		// Token: 0x17006377 RID: 25463
		// (get) Token: 0x0600C67C RID: 50812 RVA: 0x00B9E54C File Offset: 0x00B9C74C
		// (set) Token: 0x0600C67D RID: 50813 RVA: 0x00B9E604 File Offset: 0x00B9C804
		public int CnvPerConventionalChannelOptionsTxPLCode_A9418Value
		{
			get
			{
				short num = (short)1880103887;
				short num2 = num;
				num = (short)1022827471;
				switch (num2 == num)
				{
				}
				num = (short)626851841;
				if (num != 0)
				{
				}
				num = (short)967901184;
				short num3 = num;
				num = (short)1272971264;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTxPLCode_A9418.Value;
			}
			set
			{
				short num = (short)786788529;
				short num2 = num;
				num = (short)161378481;
				switch (num2 == num)
				{
				}
				num = (short)1328939009;
				if (num != 0)
				{
				}
				num = (short)1917452288;
				short num3 = num;
				num = (short)1007419392;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTxPLCode_A9418.Value = value;
			}
		}

		// Token: 0x17006378 RID: 25464
		// (get) Token: 0x0600C67E RID: 50814 RVA: 0x00B9E6B8 File Offset: 0x00B9C8B8
		// (set) Token: 0x0600C67F RID: 50815 RVA: 0x00B9E76C File Offset: 0x00B9C96C
		public string CnvPerConventionalChannelOptionsTxPLCode_A9418_UIValue
		{
			get
			{
				short num = (short)236678772;
				short num2 = num;
				num = (short)1516465780;
				switch (num2 == num)
				{
				}
				num = (short)573046785;
				if (num != 0)
				{
				}
				num = (short)213843968;
				short num3 = num;
				num = (short)2051866624;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTxPLCode_A9418.UIValue;
			}
			set
			{
				short num = (short)160432129;
				if (num != 0)
				{
				}
				num = (short)884236239;
				short num2 = num;
				num = (short)513957839;
				switch (num2 == num)
				{
				}
				num = (short)1964376064;
				short num3 = num;
				num = (short)425721856;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTxPLCode_A9418.UIValue = value;
			}
		}

		// Token: 0x17006379 RID: 25465
		// (get) Token: 0x0600C680 RID: 50816 RVA: 0x00B9E824 File Offset: 0x00B9CA24
		public global::AcpBusinessLayer.AcpListField CnvPerConventionalChannelOptionsTxPLCode_A9418
		{
			get
			{
				short num = (short)1038238287;
				short num2 = num;
				num = (short)862798415;
				switch (num2 == num)
				{
				}
				num = (short)367394817;
				if (num != 0)
				{
				}
				num = (short)566427648;
				short num3 = num;
				num = (short)588775424;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTxPLCode_A9418;
			}
		}

		// Token: 0x1700637A RID: 25466
		// (get) Token: 0x0600C681 RID: 50817 RVA: 0x00B9E8D4 File Offset: 0x00B9CAD4
		// (set) Token: 0x0600C682 RID: 50818 RVA: 0x00B9E988 File Offset: 0x00B9CB88
		public bool CnvPerConventionalChannelOptionsTxPLCode_A9418_Applicable
		{
			get
			{
				short num = (short)480196219;
				short num2 = num;
				num = (short)1560491643;
				switch (num2 == num)
				{
				}
				num = (short)2047082497;
				if (num != 0)
				{
				}
				num = (short)896466944;
				short num3 = num;
				num = (short)272891904;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTxPLCode_A9418.Applicable;
			}
			set
			{
				short num = (short)1131247182;
				short num2 = num;
				num = (short)2109306446;
				switch (num2 == num)
				{
				}
				num = (short)1592918017;
				if (num != 0)
				{
				}
				num = (short)1376387072;
				short num3 = num;
				num = (short)36175872;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTxPLCode_A9418.Applicable = value;
			}
		}

		// Token: 0x1700637B RID: 25467
		// (get) Token: 0x0600C683 RID: 50819 RVA: 0x00B9EA40 File Offset: 0x00B9CC40
		// (set) Token: 0x0600C684 RID: 50820 RVA: 0x00B9EAF4 File Offset: 0x00B9CCF4
		public bool CnvPerConventionalChannelOptionsTxPLCode_A9418_Valid
		{
			get
			{
				short num = (short)1319404519;
				short num2 = num;
				num = (short)1054442471;
				switch (num2 == num)
				{
				}
				num = (short)833880064;
				if (num != 0)
				{
				}
				num = (short)144113664;
				short num3 = num;
				num = (short)426049537;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTxPLCode_A9418.Valid;
			}
			set
			{
				short num = (short)218862631;
				short num2 = num;
				num = (short)1882756135;
				switch (num2 == num)
				{
				}
				num = (short)1238237185;
				if (num != 0)
				{
				}
				num = (short)200015872;
				short num3 = num;
				num = (short)203554816;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTxPLCode_A9418.Valid = value;
			}
		}

		// Token: 0x1700637C RID: 25468
		// (get) Token: 0x0600C685 RID: 50821 RVA: 0x00B9EBAC File Offset: 0x00B9CDAC
		// (set) Token: 0x0600C686 RID: 50822 RVA: 0x00B9EC60 File Offset: 0x00B9CE60
		public bool CnvPerConventionalChannelOptionsTxPLCode_A9418_Visible
		{
			get
			{
				short num = (short)1056002743;
				short num2 = num;
				num = (short)2029277879;
				switch (num2 == num)
				{
				}
				num = (short)1070137345;
				if (num != 0)
				{
				}
				num = (short)871104512;
				short num3 = num;
				num = (short)263061504;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTxPLCode_A9418.Visible;
			}
			set
			{
				short num = (short)2136120469;
				short num2 = num;
				num = (short)1328913557;
				switch (num2 == num)
				{
				}
				num = (short)874643457;
				if (num != 0)
				{
				}
				num = (short)1674117120;
				short num3 = num;
				num = (short)1161756672;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTxPLCode_A9418.Visible = value;
			}
		}

		// Token: 0x1700637D RID: 25469
		// (get) Token: 0x0600C687 RID: 50823 RVA: 0x00B9ED14 File Offset: 0x00B9CF14
		// (set) Token: 0x0600C688 RID: 50824 RVA: 0x00B9EDCC File Offset: 0x00B9CFCC
		public bool CnvPerConventionalChannelOptionsTxPLCode_A9418_Editable
		{
			get
			{
				short num = (short)1949353139;
				short num2 = num;
				num = (short)960939187;
				switch (num2 == num)
				{
				}
				num = (short)1267269632;
				if (num != 0)
				{
				}
				num = (short)1068564480;
				short num3 = num;
				num = (short)586350593;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTxPLCode_A9418.Editable;
			}
			set
			{
				short num = (short)1561788417;
				if (num != 0)
				{
				}
				num = (short)544387514;
				short num2 = num;
				num = (short)1350283706;
				switch (num2 == num)
				{
				}
				num = (short)1216282624;
				short num3 = num;
				num = (short)1760296960;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTxPLCode_A9418.Editable = value;
			}
		}

		// Token: 0x1700637E RID: 25470
		// (get) Token: 0x0600C689 RID: 50825 RVA: 0x00B9EE84 File Offset: 0x00B9D084
		internal string CnvPerConventionalChannelOptionsTxPLCode_A9418_UILabel
		{
			get
			{
				short num = (short)1040324784;
				short num2 = num;
				num = (short)675223728;
				switch (num2 == num)
				{
				}
				num = (short)875626497;
				if (num != 0)
				{
				}
				num = (short)1792212992;
				short num3 = num;
				num = (short)920846336;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTxPLCode_A9418.UIName;
			}
		}

		// Token: 0x1700637F RID: 25471
		// (get) Token: 0x0600C68A RID: 50826 RVA: 0x00B9EF38 File Offset: 0x00B9D138
		// (set) Token: 0x0600C68B RID: 50827 RVA: 0x00B9EFF0 File Offset: 0x00B9D1F0
		internal bool CnvPerConventionalChannelOptionsTxPLCode_A9418_HiddenStatic
		{
			get
			{
				short num = (short)2067447311;
				short num2 = num;
				num = (short)118078991;
				switch (num2 == num)
				{
				}
				num = (short)985137152;
				if (num != 0)
				{
				}
				num = (short)1444741120;
				short num3 = num;
				num = (short)649461761;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTxPLCode_A9418.HiddenStatic;
			}
			set
			{
				short num = (short)840920620;
				short num2 = num;
				num = (short)308964908;
				switch (num2 == num)
				{
				}
				num = (short)1908277249;
				if (num != 0)
				{
				}
				num = (short)1352335360;
				short num3 = num;
				num = (short)962985984;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTxPLCode_A9418.HiddenStatic = value;
			}
		}

		// Token: 0x17006380 RID: 25472
		// (get) Token: 0x0600C68C RID: 50828 RVA: 0x00B9F0A8 File Offset: 0x00B9D2A8
		// (set) Token: 0x0600C68D RID: 50829 RVA: 0x00B9F15C File Offset: 0x00B9D35C
		internal bool CnvPerConventionalChannelOptionsTxPLCode_A9418_HiddenDynamic
		{
			get
			{
				short num = (short)523481971;
				short num2 = num;
				num = (short)1288811379;
				switch (num2 == num)
				{
				}
				num = (short)163708929;
				if (num != 0)
				{
				}
				num = (short)1262157824;
				short num3 = num;
				num = (short)392429568;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTxPLCode_A9418.HiddenDynamic;
			}
			set
			{
				short num = (short)724727543;
				short num2 = num;
				num = (short)884045559;
				switch (num2 == num)
				{
				}
				num = (short)829947905;
				if (num != 0)
				{
				}
				num = (short)1581514752;
				short num3 = num;
				num = (short)1291452416;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTxPLCode_A9418.HiddenDynamic = value;
			}
		}

		// Token: 0x17006381 RID: 25473
		// (get) Token: 0x0600C68E RID: 50830 RVA: 0x00B9F214 File Offset: 0x00B9D414
		public bool CnvPerConventionalChannelOptionsTxPLCode_A9418_HasDiffs
		{
			get
			{
				short num = (short)70840806;
				short num2 = num;
				num = (short)1831137766;
				switch (num2 == num)
				{
				}
				num = (short)1626013697;
				if (num != 0)
				{
				}
				num = (short)1383071744;
				short num3 = num;
				num = (short)2818048;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTxPLCode_A9418._HasDiffs;
			}
		}

		// Token: 0x17006382 RID: 25474
		// (get) Token: 0x0600C68F RID: 50831 RVA: 0x00B9F2C8 File Offset: 0x00B9D4C8
		// (set) Token: 0x0600C690 RID: 50832 RVA: 0x00B9F37C File Offset: 0x00B9D57C
		public int CnvPerConventionalChannelOptionsTxPLFreq_A9419Value
		{
			get
			{
				short num = (short)719528249;
				short num2 = num;
				num = (short)245047609;
				switch (num2 == num)
				{
				}
				num = (short)1988689920;
				if (num != 0)
				{
				}
				num = (short)834994176;
				short num3 = num;
				num = (short)2110980097;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTxPLFreq_A9419.Value;
			}
			set
			{
				short num = (short)1817051137;
				if (num != 0)
				{
				}
				num = (short)1021897566;
				short num2 = num;
				num = (short)1522527070;
				switch (num2 == num)
				{
				}
				num = (short)855244800;
				short num3 = num;
				num = (short)1580793856;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTxPLFreq_A9419.Value = value;
			}
		}

		// Token: 0x17006383 RID: 25475
		// (get) Token: 0x0600C691 RID: 50833 RVA: 0x00B9F430 File Offset: 0x00B9D630
		// (set) Token: 0x0600C692 RID: 50834 RVA: 0x00B9F4E8 File Offset: 0x00B9D6E8
		public string CnvPerConventionalChannelOptionsTxPLFreq_A9419_UIValue
		{
			get
			{
				short num = (short)637887688;
				short num2 = num;
				num = (short)343041224;
				switch (num2 == num)
				{
				}
				num = (short)1642987521;
				if (num != 0)
				{
				}
				num = (short)1983578112;
				short num3 = num;
				num = (short)470024192;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTxPLFreq_A9419.UIValue;
			}
			set
			{
				short num = (short)1124929061;
				short num2 = num;
				num = (short)1107299877;
				switch (num2 == num)
				{
				}
				num = (short)452853761;
				if (num != 0)
				{
				}
				num = (short)521076736;
				short num3 = num;
				num = (short)100794368;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTxPLFreq_A9419.UIValue = value;
			}
		}

		// Token: 0x17006384 RID: 25476
		// (get) Token: 0x0600C693 RID: 50835 RVA: 0x00B9F59C File Offset: 0x00B9D79C
		public global::AcpBusinessLayer.AcpListField CnvPerConventionalChannelOptionsTxPLFreq_A9419
		{
			get
			{
				short num = (short)524404523;
				short num2 = num;
				num = (short)465487659;
				switch (num2 == num)
				{
				}
				num = (short)75104257;
				if (num != 0)
				{
				}
				num = (short)1419640832;
				short num3 = num;
				num = (short)1110179840;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTxPLFreq_A9419;
			}
		}

		// Token: 0x17006385 RID: 25477
		// (get) Token: 0x0600C694 RID: 50836 RVA: 0x00B9F64C File Offset: 0x00B9D84C
		// (set) Token: 0x0600C695 RID: 50837 RVA: 0x00B9F700 File Offset: 0x00B9D900
		public bool CnvPerConventionalChannelOptionsTxPLFreq_A9419_Applicable
		{
			get
			{
				short num = (short)1394010616;
				short num2 = num;
				num = (short)2126047736;
				switch (num2 == num)
				{
				}
				num = (short)1039532032;
				if (num != 0)
				{
				}
				num = (short)573177856;
				short num3 = num;
				num = (short)1864105985;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTxPLFreq_A9419.Applicable;
			}
			set
			{
				short num = (short)236482110;
				short num2 = num;
				num = (short)107966014;
				switch (num2 == num)
				{
				}
				num = (short)2008547329;
				if (num != 0)
				{
				}
				num = (short)5308416;
				short num3 = num;
				num = (short)407240704;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTxPLFreq_A9419.Applicable = value;
			}
		}

		// Token: 0x17006386 RID: 25478
		// (get) Token: 0x0600C696 RID: 50838 RVA: 0x00B9F7B4 File Offset: 0x00B9D9B4
		// (set) Token: 0x0600C697 RID: 50839 RVA: 0x00B9F868 File Offset: 0x00B9DA68
		public bool CnvPerConventionalChannelOptionsTxPLFreq_A9419_Valid
		{
			get
			{
				short num = (short)1010721293;
				short num2 = num;
				num = (short)72245773;
				switch (num2 == num)
				{
				}
				num = (short)1297022977;
				if (num != 0)
				{
				}
				num = (short)858521600;
				short num3 = num;
				num = (short)1450180608;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTxPLFreq_A9419.Valid;
			}
			set
			{
				short num = (short)1431961601;
				if (num != 0)
				{
				}
				num = (short)1991341549;
				short num2 = num;
				num = (short)950695405;
				switch (num2 == num)
				{
				}
				num = (short)1986854912;
				short num3 = num;
				num = (short)522780672;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTxPLFreq_A9419.Valid = value;
			}
		}

		// Token: 0x17006387 RID: 25479
		// (get) Token: 0x0600C698 RID: 50840 RVA: 0x00B9F91C File Offset: 0x00B9DB1C
		// (set) Token: 0x0600C699 RID: 50841 RVA: 0x00B9F9D0 File Offset: 0x00B9DBD0
		public bool CnvPerConventionalChannelOptionsTxPLFreq_A9419_Visible
		{
			get
			{
				short num = (short)1335306524;
				short num2 = num;
				num = (short)838871324;
				switch (num2 == num)
				{
				}
				num = (short)2037776384;
				if (num != 0)
				{
				}
				num = (short)2098003968;
				short num3 = num;
				num = (short)1368981505;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTxPLFreq_A9419.Visible;
			}
			set
			{
				short num = (short)385909541;
				short num2 = num;
				num = (short)1196917541;
				switch (num2 == num)
				{
				}
				num = (short)1666580481;
				if (num != 0)
				{
				}
				num = (short)921960448;
				short num3 = num;
				num = (short)1581318144;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTxPLFreq_A9419.Visible = value;
			}
		}

		// Token: 0x17006388 RID: 25480
		// (get) Token: 0x0600C69A RID: 50842 RVA: 0x00B9FA88 File Offset: 0x00B9DC88
		// (set) Token: 0x0600C69B RID: 50843 RVA: 0x00B9FB3C File Offset: 0x00B9DD3C
		public bool CnvPerConventionalChannelOptionsTxPLFreq_A9419_Editable
		{
			get
			{
				short num = (short)1784815233;
				short num2 = num;
				num = (short)1323572865;
				switch (num2 == num)
				{
				}
				num = (short)894173185;
				if (num != 0)
				{
				}
				num = (short)1614479360;
				short num3 = num;
				num = (short)1986134016;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTxPLFreq_A9419.Editable;
			}
			set
			{
				short num = (short)1052413002;
				short num2 = num;
				num = (short)1399032906;
				switch (num2 == num)
				{
				}
				num = (short)34930689;
				if (num != 0)
				{
				}
				num = (short)934871040;
				short num3 = num;
				num = (short)537657344;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTxPLFreq_A9419.Editable = value;
			}
		}

		// Token: 0x17006389 RID: 25481
		// (get) Token: 0x0600C69C RID: 50844 RVA: 0x00B9FBEC File Offset: 0x00B9DDEC
		internal string CnvPerConventionalChannelOptionsTxPLFreq_A9419_UILabel
		{
			get
			{
				short num = (short)405899647;
				short num2 = num;
				num = (short)1554352511;
				switch (num2 == num)
				{
				}
				num = (short)620822528;
				if (num != 0)
				{
				}
				num = (short)1979842560;
				short num3 = num;
				num = (short)1038221313;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTxPLFreq_A9419.UIName;
			}
		}

		// Token: 0x1700638A RID: 25482
		// (get) Token: 0x0600C69D RID: 50845 RVA: 0x00B9FCA0 File Offset: 0x00B9DEA0
		// (set) Token: 0x0600C69E RID: 50846 RVA: 0x00B9FD54 File Offset: 0x00B9DF54
		internal bool CnvPerConventionalChannelOptionsTxPLFreq_A9419_HiddenStatic
		{
			get
			{
				short num = (short)2101598870;
				short num2 = num;
				num = (short)1349507734;
				switch (num2 == num)
				{
				}
				num = (short)513081344;
				if (num != 0)
				{
				}
				num = (short)2014969856;
				short num3 = num;
				num = (short)163446785;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTxPLFreq_A9419.HiddenStatic;
			}
			set
			{
				short num = (short)2117001039;
				short num2 = num;
				num = (short)150134607;
				switch (num2 == num)
				{
				}
				num = (short)299237377;
				if (num != 0)
				{
				}
				num = (short)1456209920;
				short num3 = num;
				num = (short)1007288320;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTxPLFreq_A9419.HiddenStatic = value;
			}
		}

		// Token: 0x1700638B RID: 25483
		// (get) Token: 0x0600C69F RID: 50847 RVA: 0x00B9FE0C File Offset: 0x00B9E00C
		// (set) Token: 0x0600C6A0 RID: 50848 RVA: 0x00B9FEC4 File Offset: 0x00B9E0C4
		internal bool CnvPerConventionalChannelOptionsTxPLFreq_A9419_HiddenDynamic
		{
			get
			{
				short num = (short)2071068673;
				if (num != 0)
				{
				}
				num = (short)1501037418;
				short num2 = num;
				num = (short)1380320106;
				switch (num2 == num)
				{
				}
				num = (short)1146159104;
				short num3 = num;
				num = (short)1350565888;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTxPLFreq_A9419.HiddenDynamic;
			}
			set
			{
				short num = (short)1489520510;
				short num2 = num;
				num = (short)1123305342;
				switch (num2 == num)
				{
				}
				num = (short)1915092992;
				if (num != 0)
				{
				}
				num = (short)1223032832;
				short num3 = num;
				num = (short)1975189505;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTxPLFreq_A9419.HiddenDynamic = value;
			}
		}

		// Token: 0x1700638C RID: 25484
		// (get) Token: 0x0600C6A1 RID: 50849 RVA: 0x00B9FF78 File Offset: 0x00B9E178
		public bool CnvPerConventionalChannelOptionsTxPLFreq_A9419_HasDiffs
		{
			get
			{
				short num = (short)11866812;
				short num2 = num;
				num = (short)1770918588;
				switch (num2 == num)
				{
				}
				num = (short)1217462273;
				if (num != 0)
				{
				}
				num = (short)1038745600;
				short num3 = num;
				num = (short)1617952768;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTxPLFreq_A9419._HasDiffs;
			}
		}

		// Token: 0x1700638D RID: 25485
		// (get) Token: 0x0600C6A2 RID: 50850 RVA: 0x00BA002C File Offset: 0x00B9E22C
		// (set) Token: 0x0600C6A3 RID: 50851 RVA: 0x00BA00E4 File Offset: 0x00B9E2E4
		public int CnvPerConventionalChannelOptionsTxSquelchType_A9426Value
		{
			get
			{
				short num = (short)1732906777;
				short num2 = num;
				num = (short)2134249241;
				switch (num2 == num)
				{
				}
				num = (short)1919746048;
				if (num != 0)
				{
				}
				num = (short)1661730816;
				short num3 = num;
				num = (short)2062745601;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTxSquelchType_A9426.Value;
			}
			set
			{
				short num = (short)1761557746;
				short num2 = num;
				num = (short)273169650;
				switch (num2 == num)
				{
				}
				num = (short)830472193;
				if (num != 0)
				{
				}
				num = (short)765853696;
				short num3 = num;
				num = (short)1581121536;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTxSquelchType_A9426.Value = value;
			}
		}

		// Token: 0x1700638E RID: 25486
		// (get) Token: 0x0600C6A4 RID: 50852 RVA: 0x00BA0198 File Offset: 0x00B9E398
		// (set) Token: 0x0600C6A5 RID: 50853 RVA: 0x00BA024C File Offset: 0x00B9E44C
		public string CnvPerConventionalChannelOptionsTxSquelchType_A9426_UIValue
		{
			get
			{
				short num = (short)1321368228;
				short num2 = num;
				num = (short)73497252;
				switch (num2 == num)
				{
				}
				num = (short)1965621248;
				if (num != 0)
				{
				}
				num = (short)1634271232;
				short num3 = num;
				num = (short)1373831169;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTxSquelchType_A9426.UIValue;
			}
			set
			{
				short num = (short)1168026102;
				short num2 = num;
				num = (short)1973987830;
				switch (num2 == num)
				{
				}
				num = (short)1313144832;
				if (num != 0)
				{
				}
				num = (short)376111104;
				short num3 = num;
				num = (short)125173761;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTxSquelchType_A9426.UIValue = value;
			}
		}

		// Token: 0x1700638F RID: 25487
		// (get) Token: 0x0600C6A6 RID: 50854 RVA: 0x00BA0304 File Offset: 0x00B9E504
		public global::AcpBusinessLayer.AcpListField CnvPerConventionalChannelOptionsTxSquelchType_A9426
		{
			get
			{
				short num = (short)1862115871;
				short num2 = num;
				num = (short)1219469855;
				switch (num2 == num)
				{
				}
				num = (short)1181220865;
				if (num != 0)
				{
				}
				num = (short)1785331712;
				short num3 = num;
				num = (short)2119303168;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTxSquelchType_A9426;
			}
		}

		// Token: 0x17006390 RID: 25488
		// (get) Token: 0x0600C6A7 RID: 50855 RVA: 0x00BA03B4 File Offset: 0x00B9E5B4
		// (set) Token: 0x0600C6A8 RID: 50856 RVA: 0x00BA046C File Offset: 0x00B9E66C
		public bool CnvPerConventionalChannelOptionsTxSquelchType_A9426_Applicable
		{
			get
			{
				short num = (short)858689638;
				short num2 = num;
				num = (short)1785761894;
				switch (num2 == num)
				{
				}
				num = (short)2101346305;
				if (num != 0)
				{
				}
				num = (short)636813312;
				short num3 = num;
				num = (short)1182203904;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTxSquelchType_A9426.Applicable;
			}
			set
			{
				short num = (short)2032655236;
				short num2 = num;
				num = (short)1263721348;
				switch (num2 == num)
				{
				}
				num = (short)719650817;
				if (num != 0)
				{
				}
				num = (short)1592524800;
				short num3 = num;
				num = (short)804323328;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTxSquelchType_A9426.Applicable = value;
			}
		}

		// Token: 0x17006391 RID: 25489
		// (get) Token: 0x0600C6A9 RID: 50857 RVA: 0x00BA0520 File Offset: 0x00B9E720
		// (set) Token: 0x0600C6AA RID: 50858 RVA: 0x00BA05D4 File Offset: 0x00B9E7D4
		public bool CnvPerConventionalChannelOptionsTxSquelchType_A9426_Valid
		{
			get
			{
				short num = (short)1994352246;
				short num2 = num;
				num = (short)944334454;
				switch (num2 == num)
				{
				}
				num = (short)899219457;
				if (num != 0)
				{
				}
				num = (short)1226113024;
				short num3 = num;
				num = (short)973012992;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTxSquelchType_A9426.Valid;
			}
			set
			{
				short num = (short)1930000290;
				short num2 = num;
				num = (short)1671329698;
				switch (num2 == num)
				{
				}
				num = (short)882180097;
				if (num != 0)
				{
				}
				num = (short)418316288;
				short num3 = num;
				num = (short)1757151232;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTxSquelchType_A9426.Valid = value;
			}
		}

		// Token: 0x17006392 RID: 25490
		// (get) Token: 0x0600C6AB RID: 50859 RVA: 0x00BA0688 File Offset: 0x00B9E888
		// (set) Token: 0x0600C6AC RID: 50860 RVA: 0x00BA073C File Offset: 0x00B9E93C
		public bool CnvPerConventionalChannelOptionsTxSquelchType_A9426_Visible
		{
			get
			{
				short num = (short)969299340;
				short num2 = num;
				num = (short)115234188;
				switch (num2 == num)
				{
				}
				num = (short)103546880;
				if (num != 0)
				{
				}
				num = (short)1990590464;
				short num3 = num;
				num = (short)166068225;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTxSquelchType_A9426.Visible;
			}
			set
			{
				short num = (short)1998824704;
				short num2 = num;
				num = (short)1436198144;
				switch (num2 == num)
				{
				}
				num = (short)1082654721;
				if (num != 0)
				{
				}
				num = (short)162856960;
				short num3 = num;
				num = (short)1023541248;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTxSquelchType_A9426.Visible = value;
			}
		}

		// Token: 0x17006393 RID: 25491
		// (get) Token: 0x0600C6AD RID: 50861 RVA: 0x00BA07F0 File Offset: 0x00B9E9F0
		// (set) Token: 0x0600C6AE RID: 50862 RVA: 0x00BA08A4 File Offset: 0x00B9EAA4
		public bool CnvPerConventionalChannelOptionsTxSquelchType_A9426_Editable
		{
			get
			{
				short num = (short)1426964916;
				short num2 = num;
				num = (short)1207353780;
				switch (num2 == num)
				{
				}
				num = (short)1629421568;
				if (num != 0)
				{
				}
				num = (short)1174929408;
				short num3 = num;
				num = (short)925892609;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTxSquelchType_A9426.Editable;
			}
			set
			{
				short num = (short)711723902;
				short num2 = num;
				num = (short)906955646;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1508114432;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)485818368;
				if (num != 0)
				{
				}
				num = (short)1728053249;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTxSquelchType_A9426.Editable = value;
			}
		}

		// Token: 0x17006394 RID: 25492
		// (get) Token: 0x0600C6AF RID: 50863 RVA: 0x00BA095C File Offset: 0x00B9EB5C
		internal string CnvPerConventionalChannelOptionsTxSquelchType_A9426_UILabel
		{
			get
			{
				short num = (short)494075905;
				if (num != 0)
				{
				}
				num = (short)288555008;
				short num2 = num;
				num = (short)1518110583;
				short num3 = num;
				num = (short)1859094391;
				switch (num3 == num)
				{
				}
				num = (short)1302069248;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTxSquelchType_A9426.UIName;
			}
		}

		// Token: 0x17006395 RID: 25493
		// (get) Token: 0x0600C6B0 RID: 50864 RVA: 0x00BA0A14 File Offset: 0x00B9EC14
		// (set) Token: 0x0600C6B1 RID: 50865 RVA: 0x00BA0ACC File Offset: 0x00B9ECCC
		internal bool CnvPerConventionalChannelOptionsTxSquelchType_A9426_HiddenStatic
		{
			get
			{
				short num = (short)494529647;
				short num2 = num;
				num = (short)450948207;
				switch (num2 == num)
				{
				default:
				{
					num = (short)859832320;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)295174144;
				if (num != 0)
				{
				}
				num = (short)1463156737;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTxSquelchType_A9426.HiddenStatic;
			}
			set
			{
				short num = (short)1175928415;
				short num2 = num;
				num = (short)999046751;
				switch (num2 == num)
				{
				default:
				{
					num = (short)509673472;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1382678528;
				if (num != 0)
				{
				}
				num = (short)140640257;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTxSquelchType_A9426.HiddenStatic = value;
			}
		}

		// Token: 0x17006396 RID: 25494
		// (get) Token: 0x0600C6B2 RID: 50866 RVA: 0x00BA0B84 File Offset: 0x00B9ED84
		// (set) Token: 0x0600C6B3 RID: 50867 RVA: 0x00BA0C38 File Offset: 0x00B9EE38
		internal bool CnvPerConventionalChannelOptionsTxSquelchType_A9426_HiddenDynamic
		{
			get
			{
				short num = (short)934077803;
				short num2 = num;
				num = (short)1203037547;
				switch (num2 == num)
				{
				default:
				{
					num = (short)223805440;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2035679233;
				if (num != 0)
				{
				}
				num = (short)2145976320;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTxSquelchType_A9426.HiddenDynamic;
			}
			set
			{
				short num = (short)1466218247;
				short num2 = num;
				num = (short)754628359;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1998389248;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)824442880;
				if (num != 0)
				{
				}
				num = (short)70385665;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTxSquelchType_A9426.HiddenDynamic = value;
			}
		}

		// Token: 0x17006397 RID: 25495
		// (get) Token: 0x0600C6B4 RID: 50868 RVA: 0x00BA0CEC File Offset: 0x00B9EEEC
		public bool CnvPerConventionalChannelOptionsTxSquelchType_A9426_HasDiffs
		{
			get
			{
				short num = (short)1285448331;
				short num2 = num;
				num = (short)1519805067;
				switch (num2 == num)
				{
				default:
				{
					num = (short)26935296;
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
				num = (short)326762497;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTxSquelchType_A9426._HasDiffs;
			}
		}

		// Token: 0x17006398 RID: 25496
		// (get) Token: 0x0600C6B5 RID: 50869 RVA: 0x00BA0DA0 File Offset: 0x00B9EFA0
		// (set) Token: 0x0600C6B6 RID: 50870 RVA: 0x00BA0E54 File Offset: 0x00B9F054
		public int CnvPerConventionalChannelOptionsTxNetworkID_A9550Value
		{
			get
			{
				short num = (short)1347856200;
				short num2 = num;
				num = (short)1387702088;
				switch (num2 == num)
				{
				default:
				{
					num = (short)298516480;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)929890305;
				if (num != 0)
				{
				}
				num = (short)253886464;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTxNetworkID_A9550.Value;
			}
			set
			{
				short num = (short)365065686;
				short num2 = num;
				num = (short)1026913750;
				switch (num2 == num)
				{
				default:
				{
					num = (short)527302656;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1205796865;
				if (num != 0)
				{
				}
				num = (short)1588068352;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTxNetworkID_A9550.Value = value;
			}
		}

		// Token: 0x17006399 RID: 25497
		// (get) Token: 0x0600C6B7 RID: 50871 RVA: 0x00BA0F08 File Offset: 0x00B9F108
		public global::AcpBusinessLayer.AcpSimpleRangeField CnvPerConventionalChannelOptionsTxNetworkID_A9550
		{
			get
			{
				short num = (short)700044305;
				short num2 = num;
				num = (short)1412092945;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1119682560;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)142147584;
				if (num != 0)
				{
				}
				num = (short)242024449;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTxNetworkID_A9550;
			}
		}

		// Token: 0x1700639A RID: 25498
		// (get) Token: 0x0600C6B8 RID: 50872 RVA: 0x00BA0FB8 File Offset: 0x00B9F1B8
		// (set) Token: 0x0600C6B9 RID: 50873 RVA: 0x00BA106C File Offset: 0x00B9F26C
		public string CnvPerConventionalChannelOptionsTxNetworkID_A9550_UIValue
		{
			get
			{
				short num = (short)1110310913;
				if (num != 0)
				{
				}
				num = (short)1931345920;
				short num2 = num;
				num = (short)494523501;
				short num3 = num;
				num = (short)1913312365;
				switch (num3 == num)
				{
				}
				num = (short)1118633984;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTxNetworkID_A9550.UIValue;
			}
			set
			{
				short num = (short)1908342881;
				short num2 = num;
				num = (short)1325727841;
				switch (num2 == num)
				{
				default:
				{
					num = (short)969605120;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)701628417;
				if (num != 0)
				{
				}
				num = (short)1231486976;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTxNetworkID_A9550.UIValue = value;
			}
		}

		// Token: 0x1700639B RID: 25499
		// (get) Token: 0x0600C6BA RID: 50874 RVA: 0x00BA1124 File Offset: 0x00B9F324
		// (set) Token: 0x0600C6BB RID: 50875 RVA: 0x00BA11D8 File Offset: 0x00B9F3D8
		public string CnvPerConventionalChannelOptionsTxNetworkID_A9550_HexUIValue
		{
			get
			{
				short num = (short)2146762753;
				if (num != 0)
				{
				}
				num = (short)1738473472;
				short num2 = num;
				num = (short)166353611;
				short num3 = num;
				num = (short)1399937739;
				switch (num3 == num)
				{
				}
				num = (short)2088960000;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTxNetworkID_A9550.HexUIValue;
			}
			set
			{
				short num = (short)1581322498;
				short num2 = num;
				num = (short)1297158402;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1329332224;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)767033344;
				if (num != 0)
				{
				}
				num = (short)643301377;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTxNetworkID_A9550.HexUIValue = value;
			}
		}

		// Token: 0x1700639C RID: 25500
		// (get) Token: 0x0600C6BC RID: 50876 RVA: 0x00BA128C File Offset: 0x00B9F48C
		// (set) Token: 0x0600C6BD RID: 50877 RVA: 0x00BA1340 File Offset: 0x00B9F540
		internal int CnvPerConventionalChannelOptionsTxNetworkID_A9550Min
		{
			get
			{
				short num = (short)1649541121;
				if (num != 0)
				{
				}
				num = (short)1790312448;
				short num2 = num;
				num = (short)764032053;
				short num3 = num;
				num = (short)1611215925;
				switch (num3 == num)
				{
				}
				num = (short)670105600;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTxNetworkID_A9550.Min;
			}
			set
			{
				short num = (short)1232076801;
				if (num != 0)
				{
				}
				num = (short)1290797056;
				short num2 = num;
				num = (short)1817841738;
				short num3 = num;
				num = (short)1150029898;
				switch (num3 == num)
				{
				}
				num = (short)2085421056;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTxNetworkID_A9550.Min = value;
			}
		}

		// Token: 0x1700639D RID: 25501
		// (get) Token: 0x0600C6BE RID: 50878 RVA: 0x00BA13F8 File Offset: 0x00B9F5F8
		// (set) Token: 0x0600C6BF RID: 50879 RVA: 0x00BA14AC File Offset: 0x00B9F6AC
		internal int CnvPerConventionalChannelOptionsTxNetworkID_A9550Max
		{
			get
			{
				short num = (short)1445935924;
				short num2 = num;
				num = (short)1848261428;
				switch (num2 == num)
				{
				default:
				{
					num = (short)247070720;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)430702593;
				if (num != 0)
				{
				}
				num = (short)7077888;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTxNetworkID_A9550.Max;
			}
			set
			{
				short num = (short)687734785;
				if (num != 0)
				{
				}
				num = (short)1981087744;
				short num2 = num;
				num = (short)890230564;
				short num3 = num;
				num = (short)1722537764;
				switch (num3 == num)
				{
				}
				num = (short)370999296;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTxNetworkID_A9550.Max = value;
			}
		}

		// Token: 0x1700639E RID: 25502
		// (get) Token: 0x0600C6C0 RID: 50880 RVA: 0x00BA1560 File Offset: 0x00B9F760
		// (set) Token: 0x0600C6C1 RID: 50881 RVA: 0x00BA1618 File Offset: 0x00B9F818
		internal int CnvPerConventionalChannelOptionsTxNetworkID_A9550Step
		{
			get
			{
				short num = (short)907149313;
				if (num != 0)
				{
				}
				num = (short)934871040;
				short num2 = num;
				num = (short)1196833121;
				short num3 = num;
				num = (short)964442465;
				switch (num3 == num)
				{
				}
				num = (short)7405568;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTxNetworkID_A9550.StepSize;
			}
			set
			{
				short num = (short)1281604261;
				short num2 = num;
				num = (short)1122876069;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1791229952;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1690959872;
				if (num != 0)
				{
				}
				num = (short)251985921;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTxNetworkID_A9550.StepSize = value;
			}
		}

		// Token: 0x1700639F RID: 25503
		// (get) Token: 0x0600C6C2 RID: 50882 RVA: 0x00BA16D0 File Offset: 0x00B9F8D0
		// (set) Token: 0x0600C6C3 RID: 50883 RVA: 0x00BA1784 File Offset: 0x00B9F984
		public bool CnvPerConventionalChannelOptionsTxNetworkID_A9550_Applicable
		{
			get
			{
				short num = (short)747185838;
				short num2 = num;
				num = (short)463677102;
				switch (num2 == num)
				{
				default:
				{
					num = (short)957808640;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1211564033;
				if (num != 0)
				{
				}
				num = (short)276758528;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTxNetworkID_A9550.Applicable;
			}
			set
			{
				short num = (short)606601217;
				if (num != 0)
				{
				}
				num = (short)1731985408;
				short num2 = num;
				num = (short)1665048758;
				short num3 = num;
				num = (short)1275699382;
				switch (num3 == num)
				{
				}
				num = (short)1131675648;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTxNetworkID_A9550.Applicable = value;
			}
		}

		// Token: 0x170063A0 RID: 25504
		// (get) Token: 0x0600C6C4 RID: 50884 RVA: 0x00BA183C File Offset: 0x00B9FA3C
		// (set) Token: 0x0600C6C5 RID: 50885 RVA: 0x00BA18F0 File Offset: 0x00B9FAF0
		public bool CnvPerConventionalChannelOptionsTxNetworkID_A9550_Valid
		{
			get
			{
				short num = (short)788948958;
				short num2 = num;
				num = (short)1176266718;
				switch (num2 == num)
				{
				default:
				{
					num = (short)465174528;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1948909568;
				if (num != 0)
				{
				}
				num = (short)1780219905;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTxNetworkID_A9550.Valid;
			}
			set
			{
				short num = (short)496415988;
				short num2 = num;
				num = (short)288666868;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1662910464;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)530120704;
				if (num != 0)
				{
				}
				num = (short)156958721;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTxNetworkID_A9550.Valid = value;
			}
		}

		// Token: 0x170063A1 RID: 25505
		// (get) Token: 0x0600C6C6 RID: 50886 RVA: 0x00BA19A8 File Offset: 0x00B9FBA8
		// (set) Token: 0x0600C6C7 RID: 50887 RVA: 0x00BA1A5C File Offset: 0x00B9FC5C
		public bool CnvPerConventionalChannelOptionsTxNetworkID_A9550_Visible
		{
			get
			{
				short num = (short)532938753;
				if (num != 0)
				{
				}
				num = (short)1269301248;
				short num2 = num;
				num = (short)1391502996;
				short num3 = num;
				num = (short)348956308;
				switch (num3 == num)
				{
				}
				num = (short)1298399232;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTxNetworkID_A9550.Visible;
			}
			set
			{
				short num = (short)2081833320;
				short num2 = num;
				num = (short)1554727272;
				switch (num2 == num)
				{
				default:
				{
					num = (short)291962880;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)671219713;
				if (num != 0)
				{
				}
				num = (short)699138048;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTxNetworkID_A9550.Visible = value;
			}
		}

		// Token: 0x170063A2 RID: 25506
		// (get) Token: 0x0600C6C8 RID: 50888 RVA: 0x00BA1B10 File Offset: 0x00B9FD10
		// (set) Token: 0x0600C6C9 RID: 50889 RVA: 0x00BA1BC4 File Offset: 0x00B9FDC4
		public bool CnvPerConventionalChannelOptionsTxNetworkID_A9550_Editable
		{
			get
			{
				short num = (short)783991464;
				short num2 = num;
				num = (short)147243688;
				switch (num2 == num)
				{
				default:
				{
					num = (short)124125184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)816709633;
				if (num != 0)
				{
				}
				num = (short)670760960;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTxNetworkID_A9550.Editable;
			}
			set
			{
				short num = (short)1329298879;
				short num2 = num;
				num = (short)180846015;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1284177920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)600244224;
				if (num != 0)
				{
				}
				num = (short)834273281;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTxNetworkID_A9550.Editable = value;
			}
		}

		// Token: 0x170063A3 RID: 25507
		// (get) Token: 0x0600C6CA RID: 50890 RVA: 0x00BA1C78 File Offset: 0x00B9FE78
		internal string CnvPerConventionalChannelOptionsTxNetworkID_A9550_UILabel
		{
			get
			{
				short num = (short)1101856769;
				if (num != 0)
				{
				}
				num = (short)1074855936;
				short num2 = num;
				num = (short)952232870;
				short num3 = num;
				num = (short)1197796262;
				switch (num3 == num)
				{
				}
				num = (short)483590144;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTxNetworkID_A9550.UIName;
			}
		}

		// Token: 0x170063A4 RID: 25508
		// (get) Token: 0x0600C6CB RID: 50891 RVA: 0x00BA1D2C File Offset: 0x00B9FF2C
		// (set) Token: 0x0600C6CC RID: 50892 RVA: 0x00BA1DE0 File Offset: 0x00B9FFE0
		internal bool CnvPerConventionalChannelOptionsTxNetworkID_A9550_HiddenStatic
		{
			get
			{
				short num = (short)694977409;
				short num2 = num;
				num = (short)1717142401;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1775960064;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)880869377;
				if (num != 0)
				{
				}
				num = (short)1073414144;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTxNetworkID_A9550.HiddenStatic;
			}
			set
			{
				short num = (short)1542190747;
				short num2 = num;
				num = (short)778040987;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1484193792;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)708902913;
				if (num != 0)
				{
				}
				num = (short)1753219072;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTxNetworkID_A9550.HiddenStatic = value;
			}
		}

		// Token: 0x170063A5 RID: 25509
		// (get) Token: 0x0600C6CD RID: 50893 RVA: 0x00BA1E98 File Offset: 0x00BA0098
		// (set) Token: 0x0600C6CE RID: 50894 RVA: 0x00BA1F4C File Offset: 0x00BA014C
		internal bool CnvPerConventionalChannelOptionsTxNetworkID_A9550_HiddenDynamic
		{
			get
			{
				short num = (short)1962216577;
				short num2 = num;
				num = (short)1911622785;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1955528704;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1181286401;
				if (num != 0)
				{
				}
				num = (short)900857856;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTxNetworkID_A9550.HiddenDynamic;
			}
			set
			{
				short num = (short)1843056877;
				short num2 = num;
				num = (short)1971179757;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1868038144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)379781120;
				if (num != 0)
				{
				}
				num = (short)1339752449;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTxNetworkID_A9550.HiddenDynamic = value;
			}
		}

		// Token: 0x170063A6 RID: 25510
		// (get) Token: 0x0600C6CF RID: 50895 RVA: 0x00BA2004 File Offset: 0x00BA0204
		public bool CnvPerConventionalChannelOptionsTxNetworkID_A9550_HasDiffs
		{
			get
			{
				short num = (short)2095998823;
				short num2 = num;
				num = (short)1018914663;
				switch (num2 == num)
				{
				default:
				{
					num = (short)664600576;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2041380864;
				if (num != 0)
				{
				}
				num = (short)741146625;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTxNetworkID_A9550._HasDiffs;
			}
		}

		// Token: 0x170063A7 RID: 25511
		// (get) Token: 0x0600C6D0 RID: 50896 RVA: 0x00BA20BC File Offset: 0x00BA02BC
		// (set) Token: 0x0600C6D1 RID: 50897 RVA: 0x00BA2170 File Offset: 0x00BA0370
		public bool CnvPerConventionalChannelOptionsUserSelectablePLMPL_A9606Value
		{
			get
			{
				short num = (short)1389328295;
				short num2 = num;
				num = (short)2130212775;
				switch (num2 == num)
				{
				default:
				{
					num = (short)23396352;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1272971264;
				if (num != 0)
				{
				}
				num = (short)442761217;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsUserSelectablePLMPL_A9606.Value;
			}
			set
			{
				short num = (short)1654822665;
				short num2 = num;
				num = (short)1733007113;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1984495616;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1534853121;
				if (num != 0)
				{
				}
				num = (short)749273088;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsUserSelectablePLMPL_A9606.Value = value;
			}
		}

		// Token: 0x170063A8 RID: 25512
		// (get) Token: 0x0600C6D2 RID: 50898 RVA: 0x00BA2228 File Offset: 0x00BA0428
		public global::AcpBusinessLayer.AcpField<bool> CnvPerConventionalChannelOptionsUserSelectablePLMPL_A9606
		{
			get
			{
				short num = (short)1166778330;
				short num2 = num;
				num = (short)1143381978;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1995964416;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)45350912;
				if (num != 0)
				{
				}
				num = (short)1334771713;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsUserSelectablePLMPL_A9606;
			}
		}

		// Token: 0x170063A9 RID: 25513
		// (get) Token: 0x0600C6D3 RID: 50899 RVA: 0x00BA22D8 File Offset: 0x00BA04D8
		// (set) Token: 0x0600C6D4 RID: 50900 RVA: 0x00BA238C File Offset: 0x00BA058C
		public bool CnvPerConventionalChannelOptionsUserSelectablePLMPL_A9606_UIValue
		{
			get
			{
				short num = (short)63589151;
				short num2 = num;
				num = (short)29248287;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1585184768;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)292683776;
				if (num != 0)
				{
				}
				num = (short)1419444225;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsUserSelectablePLMPL_A9606.Value;
			}
			set
			{
				short num = (short)376304938;
				short num2 = num;
				num = (short)1653929258;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1602355200;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1213136897;
				if (num != 0)
				{
				}
				num = (short)2008678400;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsUserSelectablePLMPL_A9606.Value = value;
			}
		}

		// Token: 0x170063AA RID: 25514
		// (get) Token: 0x0600C6D5 RID: 50901 RVA: 0x00BA2444 File Offset: 0x00BA0644
		// (set) Token: 0x0600C6D6 RID: 50902 RVA: 0x00BA24F8 File Offset: 0x00BA06F8
		public bool CnvPerConventionalChannelOptionsUserSelectablePLMPL_A9606_Applicable
		{
			get
			{
				short num = (short)363276359;
				short num2 = num;
				num = (short)577251399;
				switch (num2 == num)
				{
				default:
				{
					num = (short)348258304;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1036779521;
				if (num != 0)
				{
				}
				num = (short)504365056;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsUserSelectablePLMPL_A9606.Applicable;
			}
			set
			{
				short num = (short)335913182;
				short num2 = num;
				num = (short)1348182238;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2030108672;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)536281089;
				if (num != 0)
				{
				}
				num = (short)337772544;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsUserSelectablePLMPL_A9606.Applicable = value;
			}
		}

		// Token: 0x170063AB RID: 25515
		// (get) Token: 0x0600C6D7 RID: 50903 RVA: 0x00BA25B0 File Offset: 0x00BA07B0
		// (set) Token: 0x0600C6D8 RID: 50904 RVA: 0x00BA2660 File Offset: 0x00BA0860
		public bool CnvPerConventionalChannelOptionsUserSelectablePLMPL_A9606_Valid
		{
			get
			{
				short num = (short)816095285;
				short num2 = num;
				num = (short)90415157;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1123090432;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1760034817;
				if (num != 0)
				{
				}
				num = (short)184811520;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsUserSelectablePLMPL_A9606.Valid;
			}
			set
			{
				short num = (short)1327890433;
				if (num != 0)
				{
				}
				num = (short)708771840;
				short num2 = num;
				num = (short)33791206;
				short num3 = num;
				num = (short)1117560038;
				switch (num3 == num)
				{
				}
				num = (short)1750138880;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsUserSelectablePLMPL_A9606.Valid = value;
			}
		}

		// Token: 0x170063AC RID: 25516
		// (get) Token: 0x0600C6D9 RID: 50905 RVA: 0x00BA2714 File Offset: 0x00BA0914
		// (set) Token: 0x0600C6DA RID: 50906 RVA: 0x00BA27C8 File Offset: 0x00BA09C8
		public bool CnvPerConventionalChannelOptionsUserSelectablePLMPL_A9606_Visible
		{
			get
			{
				short num = (short)718733313;
				if (num != 0)
				{
				}
				num = (short)947519488;
				short num2 = num;
				num = (short)1836071688;
				short num3 = num;
				num = (short)595606280;
				switch (num3 == num)
				{
				}
				num = (short)2060976128;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsUserSelectablePLMPL_A9606.Visible;
			}
			set
			{
				short num = (short)1575118980;
				short num2 = num;
				num = (short)1660708996;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1599995904;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1006567425;
				if (num != 0)
				{
				}
				num = (short)234946560;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsUserSelectablePLMPL_A9606.Visible = value;
			}
		}

		// Token: 0x170063AD RID: 25517
		// (get) Token: 0x0600C6DB RID: 50907 RVA: 0x00BA287C File Offset: 0x00BA0A7C
		// (set) Token: 0x0600C6DC RID: 50908 RVA: 0x00BA2934 File Offset: 0x00BA0B34
		public bool CnvPerConventionalChannelOptionsUserSelectablePLMPL_A9606_Editable
		{
			get
			{
				short num = (short)432765506;
				short num2 = num;
				num = (short)367557186;
				switch (num2 == num)
				{
				default:
				{
					num = (short)719060992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1588985857;
				if (num != 0)
				{
				}
				num = (short)1202716672;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsUserSelectablePLMPL_A9606.Editable;
			}
			set
			{
				short num = (short)253710122;
				short num2 = num;
				num = (short)1053708074;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1638924288;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)986316800;
				if (num != 0)
				{
				}
				num = (short)993525761;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsUserSelectablePLMPL_A9606.Editable = value;
			}
		}

		// Token: 0x170063AE RID: 25518
		// (get) Token: 0x0600C6DD RID: 50909 RVA: 0x00BA29EC File Offset: 0x00BA0BEC
		internal string CnvPerConventionalChannelOptionsUserSelectablePLMPL_A9606_UILabel
		{
			get
			{
				short num = (short)1552716060;
				short num2 = num;
				num = (short)279613724;
				switch (num2 == num)
				{
				default:
				{
					num = (short)312344576;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)619249665;
				if (num != 0)
				{
				}
				num = (short)585760768;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsUserSelectablePLMPL_A9606.UIName;
			}
		}

		// Token: 0x170063AF RID: 25519
		// (get) Token: 0x0600C6DE RID: 50910 RVA: 0x00BA2AA0 File Offset: 0x00BA0CA0
		// (set) Token: 0x0600C6DF RID: 50911 RVA: 0x00BA2B54 File Offset: 0x00BA0D54
		internal bool CnvPerConventionalChannelOptionsUserSelectablePLMPL_A9606_HiddenStatic
		{
			get
			{
				short num = (short)985750576;
				short num2 = num;
				num = (short)254434352;
				switch (num2 == num)
				{
				default:
				{
					num = (short)533856256;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1496514561;
				if (num != 0)
				{
				}
				num = (short)1020657664;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsUserSelectablePLMPL_A9606.HiddenStatic;
			}
			set
			{
				short num = (short)1422510905;
				short num2 = num;
				num = (short)232639289;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1812660224;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)434503681;
				if (num != 0)
				{
				}
				num = (short)1683292160;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsUserSelectablePLMPL_A9606.HiddenStatic = value;
			}
		}

		// Token: 0x170063B0 RID: 25520
		// (get) Token: 0x0600C6E0 RID: 50912 RVA: 0x00BA2C08 File Offset: 0x00BA0E08
		// (set) Token: 0x0600C6E1 RID: 50913 RVA: 0x00BA2CBC File Offset: 0x00BA0EBC
		internal bool CnvPerConventionalChannelOptionsUserSelectablePLMPL_A9606_HiddenDynamic
		{
			get
			{
				short num = (short)1011428162;
				short num2 = num;
				num = (short)1063856962;
				switch (num2 == num)
				{
				default:
				{
					num = (short)963313664;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1040842752;
				if (num != 0)
				{
				}
				num = (short)1493630977;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsUserSelectablePLMPL_A9606.HiddenDynamic;
			}
			set
			{
				short num = (short)2134769665;
				if (num != 0)
				{
				}
				num = (short)609157120;
				short num2 = num;
				num = (short)290824318;
				short num3 = num;
				num = (short)401186942;
				switch (num3 == num)
				{
				}
				num = (short)872873984;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsUserSelectablePLMPL_A9606.HiddenDynamic = value;
			}
		}

		// Token: 0x170063B1 RID: 25521
		// (get) Token: 0x0600C6E2 RID: 50914 RVA: 0x00BA2D74 File Offset: 0x00BA0F74
		public bool CnvPerConventionalChannelOptionsUserSelectablePLMPL_A9606_HasDiffs
		{
			get
			{
				short num = (short)540351530;
				short num2 = num;
				num = (short)696261674;
				switch (num2 == num)
				{
				default:
				{
					num = (short)86704128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)746520576;
				if (num != 0)
				{
				}
				num = (short)715587585;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsUserSelectablePLMPL_A9606._HasDiffs;
			}
		}

		// Token: 0x170063B2 RID: 25522
		// (get) Token: 0x0600C6E3 RID: 50915 RVA: 0x00BA2E28 File Offset: 0x00BA1028
		// (set) Token: 0x0600C6E4 RID: 50916 RVA: 0x00BA2EE4 File Offset: 0x00BA10E4
		public bool CnvPerConventionalChannelOptionsTalkaround_A19837Value
		{
			get
			{
				short num = (short)1077602906;
				short num2 = num;
				num = (short)911993434;
				switch (num2 == num)
				{
				}
				num = (short)270336000;
				short num3 = num;
				num = (short)1589051393;
				if (num != 0)
				{
				}
				num = (short)1001521152;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTalkaround_A19837.Value;
			}
			set
			{
				short num = (short)463379205;
				short num2 = num;
				num = (short)1894619909;
				switch (num2 == num)
				{
				}
				num = (short)340590592;
				short num3 = num;
				num = (short)1323630593;
				if (num != 0)
				{
				}
				num = (short)846594048;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTalkaround_A19837.Value = value;
			}
		}

		// Token: 0x170063B3 RID: 25523
		// (get) Token: 0x0600C6E5 RID: 50917 RVA: 0x00BA2F98 File Offset: 0x00BA1198
		public global::AcpBusinessLayer.AcpField<bool> CnvPerConventionalChannelOptionsTalkaround_A19837
		{
			get
			{
				short num = (short)1417046727;
				short num2 = num;
				num = (short)1361144519;
				switch (num2 == num)
				{
				}
				num = (short)969211904;
				short num3 = num;
				num = (short)1289224193;
				if (num != 0)
				{
				}
				num = (short)1485766656;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTalkaround_A19837;
			}
		}

		// Token: 0x170063B4 RID: 25524
		// (get) Token: 0x0600C6E6 RID: 50918 RVA: 0x00BA3048 File Offset: 0x00BA1248
		// (set) Token: 0x0600C6E7 RID: 50919 RVA: 0x00BA30FC File Offset: 0x00BA12FC
		public bool CnvPerConventionalChannelOptionsTalkaround_A19837_UIValue
		{
			get
			{
				short num = (short)1055465369;
				short num2 = num;
				num = (short)1229528985;
				switch (num2 == num)
				{
				}
				num = (short)1997471744;
				short num3 = num;
				num = (short)1580007425;
				if (num != 0)
				{
				}
				num = (short)444792832;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTalkaround_A19837.Value;
			}
			set
			{
				short num = (short)1200488449;
				if (num != 0)
				{
				}
				num = (short)28653435;
				short num2 = num;
				num = (short)27867003;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1525153792;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1909784576;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTalkaround_A19837.Value = value;
			}
		}

		// Token: 0x170063B5 RID: 25525
		// (get) Token: 0x0600C6E8 RID: 50920 RVA: 0x00BA31B0 File Offset: 0x00BA13B0
		// (set) Token: 0x0600C6E9 RID: 50921 RVA: 0x00BA3264 File Offset: 0x00BA1464
		public bool CnvPerConventionalChannelOptionsTalkaround_A19837_Applicable
		{
			get
			{
				short num = (short)1962710986;
				short num2 = num;
				num = (short)314152906;
				switch (num2 == num)
				{
				}
				num = (short)644415488;
				short num3 = num;
				num = (short)2052456449;
				if (num != 0)
				{
				}
				num = (short)342294528;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTalkaround_A19837.Applicable;
			}
			set
			{
				short num = (short)1458807810;
				short num2 = num;
				num = (short)738632706;
				switch (num2 == num)
				{
				}
				num = (short)1166802944;
				short num3 = num;
				num = (short)390201345;
				if (num != 0)
				{
				}
				num = (short)1522270208;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTalkaround_A19837.Applicable = value;
			}
		}

		// Token: 0x170063B6 RID: 25526
		// (get) Token: 0x0600C6EA RID: 50922 RVA: 0x00BA3318 File Offset: 0x00BA1518
		// (set) Token: 0x0600C6EB RID: 50923 RVA: 0x00BA33CC File Offset: 0x00BA15CC
		public bool CnvPerConventionalChannelOptionsTalkaround_A19837_Valid
		{
			get
			{
				short num = (short)1235940446;
				short num2 = num;
				num = (short)1685648478;
				switch (num2 == num)
				{
				}
				num = (short)1398669312;
				short num3 = num;
				num = (short)1326776320;
				if (num != 0)
				{
				}
				num = (short)1629356033;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTalkaround_A19837.Valid;
			}
			set
			{
				short num = (short)1175971020;
				short num2 = num;
				num = (short)751559884;
				switch (num2 == num)
				{
				}
				num = (short)377552896;
				short num3 = num;
				num = (short)674627584;
				if (num != 0)
				{
				}
				num = (short)575733761;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTalkaround_A19837.Valid = value;
			}
		}

		// Token: 0x170063B7 RID: 25527
		// (get) Token: 0x0600C6EC RID: 50924 RVA: 0x00BA3480 File Offset: 0x00BA1680
		// (set) Token: 0x0600C6ED RID: 50925 RVA: 0x00BA3538 File Offset: 0x00BA1738
		public bool CnvPerConventionalChannelOptionsTalkaround_A19837_Visible
		{
			get
			{
				short num = (short)1165343650;
				short num2 = num;
				num = (short)1724758946;
				switch (num2 == num)
				{
				}
				num = (short)1558708224;
				short num3 = num;
				num = (short)33947649;
				if (num != 0)
				{
				}
				num = (short)197918720;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTalkaround_A19837.Visible;
			}
			set
			{
				short num = (short)50262612;
				short num2 = num;
				num = (short)1444278868;
				switch (num2 == num)
				{
				}
				num = (short)504299520;
				short num3 = num;
				num = (short)1523777537;
				if (num != 0)
				{
				}
				num = (short)777322496;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTalkaround_A19837.Visible = value;
			}
		}

		// Token: 0x170063B8 RID: 25528
		// (get) Token: 0x0600C6EE RID: 50926 RVA: 0x00BA35EC File Offset: 0x00BA17EC
		// (set) Token: 0x0600C6EF RID: 50927 RVA: 0x00BA36A0 File Offset: 0x00BA18A0
		public bool CnvPerConventionalChannelOptionsTalkaround_A19837_Editable
		{
			get
			{
				short num = (short)790879605;
				short num2 = num;
				num = (short)1061084533;
				switch (num2 == num)
				{
				}
				num = (short)1644691456;
				short num3 = num;
				num = (short)2129985537;
				if (num != 0)
				{
				}
				num = (short)1137639424;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTalkaround_A19837.Editable;
			}
			set
			{
				short num = (short)1151911916;
				short num2 = num;
				num = (short)555730924;
				switch (num2 == num)
				{
				}
				num = (short)414842880;
				short num3 = num;
				num = (short)240582656;
				if (num != 0)
				{
				}
				num = (short)1388904449;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTalkaround_A19837.Editable = value;
			}
		}

		// Token: 0x170063B9 RID: 25529
		// (get) Token: 0x0600C6F0 RID: 50928 RVA: 0x00BA3758 File Offset: 0x00BA1958
		internal string CnvPerConventionalChannelOptionsTalkaround_A19837_UILabel
		{
			get
			{
				short num = (short)49557364;
				short num2 = num;
				num = (short)451686260;
				switch (num2 == num)
				{
				}
				num = (short)1489698816;
				short num3 = num;
				num = (short)129564673;
				if (num != 0)
				{
				}
				num = (short)1626472448;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTalkaround_A19837.UIName;
			}
		}

		// Token: 0x170063BA RID: 25530
		// (get) Token: 0x0600C6F1 RID: 50929 RVA: 0x00BA380C File Offset: 0x00BA1A0C
		// (set) Token: 0x0600C6F2 RID: 50930 RVA: 0x00BA38C0 File Offset: 0x00BA1AC0
		internal bool CnvPerConventionalChannelOptionsTalkaround_A19837_HiddenStatic
		{
			get
			{
				short num = (short)944108387;
				short num2 = num;
				num = (short)25228131;
				switch (num2 == num)
				{
				}
				num = (short)572325888;
				short num3 = num;
				num = (short)1417805825;
				if (num != 0)
				{
				}
				num = (short)1041235968;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTalkaround_A19837.HiddenStatic;
			}
			set
			{
				short num = (short)1869545473;
				if (num != 0)
				{
				}
				num = (short)1721342299;
				short num2 = num;
				num = (short)473799003;
				switch (num2 == num)
				{
				default:
				{
					num = (short)405209088;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1600323584;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTalkaround_A19837.HiddenStatic = value;
			}
		}

		// Token: 0x170063BB RID: 25531
		// (get) Token: 0x0600C6F3 RID: 50931 RVA: 0x00BA3974 File Offset: 0x00BA1B74
		// (set) Token: 0x0600C6F4 RID: 50932 RVA: 0x00BA3A28 File Offset: 0x00BA1C28
		internal bool CnvPerConventionalChannelOptionsTalkaround_A19837_HiddenDynamic
		{
			get
			{
				short num = (short)196189484;
				short num2 = num;
				num = (short)683384108;
				switch (num2 == num)
				{
				}
				num = (short)418971648;
				short num3 = num;
				num = (short)1475674112;
				if (num != 0)
				{
				}
				num = (short)277217281;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTalkaround_A19837.HiddenDynamic;
			}
			set
			{
				short num = (short)969764975;
				short num2 = num;
				num = (short)2125361263;
				switch (num2 == num)
				{
				}
				num = (short)1341194240;
				short num3 = num;
				num = (short)1287716865;
				if (num != 0)
				{
				}
				num = (short)1861484544;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTalkaround_A19837.HiddenDynamic = value;
			}
		}

		// Token: 0x170063BC RID: 25532
		// (get) Token: 0x0600C6F5 RID: 50933 RVA: 0x00BA3ADC File Offset: 0x00BA1CDC
		public bool CnvPerConventionalChannelOptionsTalkaround_A19837_HasDiffs
		{
			get
			{
				short num = (short)202960916;
				short num2 = num;
				num = (short)99807252;
				switch (num2 == num)
				{
				}
				num = (short)370540544;
				short num3 = num;
				num = (short)1034223617;
				if (num != 0)
				{
				}
				num = (short)397737984;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTalkaround_A19837._HasDiffs;
			}
		}

		// Token: 0x170063BD RID: 25533
		// (get) Token: 0x0600C6F6 RID: 50934 RVA: 0x00BA3B94 File Offset: 0x00BA1D94
		// (set) Token: 0x0600C6F7 RID: 50935 RVA: 0x00BA3C48 File Offset: 0x00BA1E48
		public string CnvPerConventionalChannelOptionsKeyofConventionalChannelOptions_A20745Value
		{
			get
			{
				short num = (short)2076238329;
				short num2 = num;
				num = (short)1367400953;
				switch (num2 == num)
				{
				}
				num = (short)1338703872;
				short num3 = num;
				num = (short)1449132032;
				if (num != 0)
				{
				}
				num = (short)1673658369;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsKeyofConventionalChannelOptions_A20745.Value;
			}
			set
			{
				short num = (short)306577410;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_D2;
					case 1:
						return;
					case 2:
					{
						num = (short)7208960;
						short num3 = num;
						switch (0)
						{
						case 0:
							goto IL_5A;
						}
						continue;
					}
					}
					IL_5A:
					if (string.IsNullOrEmpty(value.Trim()))
					{
						break;
					}
					num = (short)648352025;
					short num4 = num;
					num = (short)800264473;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1212678144;
						if (num != 0)
						{
						}
						num = (short)1957101568;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_D2:
					this.cnvPerConventionalChannelOptionsKeyofConventionalChannelOptions_A20745.Value = value;
					num = (short)1774518273;
					if (num != 0)
					{
					}
					num = (short)1794899969;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x170063BE RID: 25534
		// (get) Token: 0x0600C6F8 RID: 50936 RVA: 0x00BA3D74 File Offset: 0x00BA1F74
		// (set) Token: 0x0600C6F9 RID: 50937 RVA: 0x00BA3E28 File Offset: 0x00BA2028
		public string CnvPerConventionalChannelOptionsKeyofConventionalChannelOptions_A20745_UIValue
		{
			get
			{
				short num = (short)306452934;
				short num2 = num;
				num = (short)183507398;
				switch (num2 == num)
				{
				}
				num = (short)748290048;
				short num3 = num;
				num = (short)1816330241;
				if (num != 0)
				{
				}
				num = (short)707330048;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsKeyofConventionalChannelOptions_A20745.Value;
			}
			set
			{
				short num = (short)1870431865;
				short num2 = num;
				num = (short)1101432441;
				switch (num2 == num)
				{
				}
				num = (short)1837629440;
				short num3 = num;
				num = (short)2061238273;
				if (num != 0)
				{
				}
				num = (short)104857600;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsKeyofConventionalChannelOptions_A20745.Value = value;
			}
		}

		// Token: 0x170063BF RID: 25535
		// (get) Token: 0x0600C6FA RID: 50938 RVA: 0x00BA3EDC File Offset: 0x00BA20DC
		public global::AcpBusinessLayer.AcpKeyField CnvPerConventionalChannelOptionsKeyofConventionalChannelOptions_A20745
		{
			get
			{
				short num = (short)317325313;
				if (num != 0)
				{
				}
				num = (short)524747727;
				short num2 = num;
				num = (short)959120335;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1061421056;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)741539840;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsKeyofConventionalChannelOptions_A20745;
			}
		}

		// Token: 0x170063C0 RID: 25536
		// (get) Token: 0x0600C6FB RID: 50939 RVA: 0x00BA3F8C File Offset: 0x00BA218C
		// (set) Token: 0x0600C6FC RID: 50940 RVA: 0x00BA4044 File Offset: 0x00BA2244
		public bool CnvPerConventionalChannelOptionsKeyofConventionalChannelOptions_A20745_Applicable
		{
			get
			{
				short num = (short)95825110;
				short num2 = num;
				num = (short)1193290966;
				switch (num2 == num)
				{
				}
				num = (short)1877016576;
				short num3 = num;
				num = (short)249298945;
				if (num != 0)
				{
				}
				num = (short)201392128;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsKeyofConventionalChannelOptions_A20745.Applicable;
			}
			set
			{
				short num = (short)1821835265;
				if (num != 0)
				{
				}
				num = (short)790514799;
				short num2 = num;
				num = (short)1477201007;
				switch (num2 == num)
				{
				default:
				{
					num = (short)625672192;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)40894464;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsKeyofConventionalChannelOptions_A20745.Applicable = value;
			}
		}

		// Token: 0x170063C1 RID: 25537
		// (get) Token: 0x0600C6FD RID: 50941 RVA: 0x00BA40FC File Offset: 0x00BA22FC
		// (set) Token: 0x0600C6FE RID: 50942 RVA: 0x00BA41B0 File Offset: 0x00BA23B0
		public bool CnvPerConventionalChannelOptionsKeyofConventionalChannelOptions_A20745_Valid
		{
			get
			{
				short num = (short)1921330258;
				short num2 = num;
				num = (short)585444434;
				switch (num2 == num)
				{
				}
				num = (short)1205731328;
				short num3 = num;
				num = (short)2090401792;
				if (num != 0)
				{
				}
				num = (short)879493121;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsKeyofConventionalChannelOptions_A20745.Valid;
			}
			set
			{
				short num = (short)1093005886;
				short num2 = num;
				num = (short)238350910;
				switch (num2 == num)
				{
				}
				num = (short)1093599232;
				short num3 = num;
				num = (short)66846721;
				if (num != 0)
				{
				}
				num = (short)773062656;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsKeyofConventionalChannelOptions_A20745.Valid = value;
			}
		}

		// Token: 0x170063C2 RID: 25538
		// (get) Token: 0x0600C6FF RID: 50943 RVA: 0x00BA4268 File Offset: 0x00BA2468
		// (set) Token: 0x0600C700 RID: 50944 RVA: 0x00BA431C File Offset: 0x00BA251C
		public bool CnvPerConventionalChannelOptionsKeyofConventionalChannelOptions_A20745_Visible
		{
			get
			{
				short num = (short)215232907;
				short num2 = num;
				num = (short)383332747;
				switch (num2 == num)
				{
				}
				num = (short)1508507648;
				short num3 = num;
				num = (short)1550450689;
				if (num != 0)
				{
				}
				num = (short)1019281408;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsKeyofConventionalChannelOptions_A20745.Visible;
			}
			set
			{
				short num = (short)1057759630;
				short num2 = num;
				num = (short)973218190;
				switch (num2 == num)
				{
				}
				num = (short)1847132160;
				short num3 = num;
				num = (short)613416961;
				if (num != 0)
				{
				}
				num = (short)1352794112;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsKeyofConventionalChannelOptions_A20745.Visible = value;
			}
		}

		// Token: 0x170063C3 RID: 25539
		// (get) Token: 0x0600C701 RID: 50945 RVA: 0x00BA43D4 File Offset: 0x00BA25D4
		// (set) Token: 0x0600C702 RID: 50946 RVA: 0x00BA4488 File Offset: 0x00BA2688
		public bool CnvPerConventionalChannelOptionsKeyofConventionalChannelOptions_A20745_Editable
		{
			get
			{
				short num = (short)966991980;
				short num2 = num;
				num = (short)1800806508;
				switch (num2 == num)
				{
				}
				num = (short)1976172544;
				short num3 = num;
				num = (short)1603600385;
				if (num != 0)
				{
				}
				num = (short)812646400;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsKeyofConventionalChannelOptions_A20745.Editable;
			}
			set
			{
				short num = (short)2106808383;
				short num2 = num;
				num = (short)875911231;
				switch (num2 == num)
				{
				}
				num = (short)675610624;
				short num3 = num;
				num = (short)112918528;
				if (num != 0)
				{
				}
				num = (short)608632833;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsKeyofConventionalChannelOptions_A20745.Editable = value;
			}
		}

		// Token: 0x170063C4 RID: 25540
		// (get) Token: 0x0600C703 RID: 50947 RVA: 0x00BA4540 File Offset: 0x00BA2740
		internal string CnvPerConventionalChannelOptionsKeyofConventionalChannelOptions_A20745_UILabel
		{
			get
			{
				short num = (short)323966493;
				short num2 = num;
				num = (short)1284789789;
				switch (num2 == num)
				{
				}
				num = (short)426901504;
				short num3 = num;
				num = (short)184090625;
				if (num != 0)
				{
				}
				num = (short)775815168;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsKeyofConventionalChannelOptions_A20745.UIName;
			}
		}

		// Token: 0x170063C5 RID: 25541
		// (get) Token: 0x0600C704 RID: 50948 RVA: 0x00BA45F0 File Offset: 0x00BA27F0
		// (set) Token: 0x0600C705 RID: 50949 RVA: 0x00BA46A0 File Offset: 0x00BA28A0
		internal bool CnvPerConventionalChannelOptionsKeyofConventionalChannelOptions_A20745_HiddenStatic
		{
			get
			{
				short num = (short)182382678;
				short num2 = num;
				num = (short)1679487062;
				switch (num2 == num)
				{
				}
				num = (short)1587085312;
				short num3 = num;
				num = (short)1880752129;
				if (num != 0)
				{
				}
				num = (short)542965760;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsKeyofConventionalChannelOptions_A20745.HiddenStatic;
			}
			set
			{
				short num = (short)1625482898;
				short num2 = num;
				num = (short)2144265874;
				switch (num2 == num)
				{
				}
				num = (short)921698304;
				short num3 = num;
				num = (short)1665859585;
				if (num != 0)
				{
				}
				num = (short)2019229696;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsKeyofConventionalChannelOptions_A20745.HiddenStatic = value;
			}
		}

		// Token: 0x170063C6 RID: 25542
		// (get) Token: 0x0600C706 RID: 50950 RVA: 0x00BA4758 File Offset: 0x00BA2958
		// (set) Token: 0x0600C707 RID: 50951 RVA: 0x00BA480C File Offset: 0x00BA2A0C
		internal bool CnvPerConventionalChannelOptionsKeyofConventionalChannelOptions_A20745_HiddenDynamic
		{
			get
			{
				short num = (short)17681505;
				short num2 = num;
				num = (short)2012466273;
				switch (num2 == num)
				{
				}
				num = (short)1274413056;
				short num3 = num;
				num = (short)881721345;
				if (num != 0)
				{
				}
				num = (short)703332352;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsKeyofConventionalChannelOptions_A20745.HiddenDynamic;
			}
			set
			{
				short num = (short)572591327;
				short num2 = num;
				num = (short)2137722079;
				switch (num2 == num)
				{
				}
				num = (short)1379401728;
				short num3 = num;
				num = (short)893517825;
				if (num != 0)
				{
				}
				num = (short)612433920;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsKeyofConventionalChannelOptions_A20745.HiddenDynamic = value;
			}
		}

		// Token: 0x170063C7 RID: 25543
		// (get) Token: 0x0600C708 RID: 50952 RVA: 0x00BA48C0 File Offset: 0x00BA2AC0
		public bool CnvPerConventionalChannelOptionsKeyofConventionalChannelOptions_A20745_HasDiffs
		{
			get
			{
				short num = (short)429225840;
				short num2 = num;
				num = (short)1512404848;
				switch (num2 == num)
				{
				}
				num = (short)1445003264;
				short num3 = num;
				num = (short)1428291584;
				if (num != 0)
				{
				}
				num = (short)985792513;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsKeyofConventionalChannelOptions_A20745._HasDiffs;
			}
		}

		// Token: 0x170063C8 RID: 25544
		// (get) Token: 0x0600C709 RID: 50953 RVA: 0x00BA4974 File Offset: 0x00BA2B74
		// (set) Token: 0x0600C70A RID: 50954 RVA: 0x00BA4A28 File Offset: 0x00BA2C28
		public int CnvPerConventionalChannelOptionsTxDevChanSpacing_A23192Value
		{
			get
			{
				short num = (short)125134943;
				short num2 = num;
				num = (short)1126656095;
				switch (num2 == num)
				{
				}
				num = (short)130351104;
				short num3 = num;
				num = (short)1995767808;
				if (num != 0)
				{
				}
				num = (short)1588199425;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTxDevChanSpacing_A23192.Value;
			}
			set
			{
				short num = (short)363246421;
				short num2 = num;
				num = (short)1355789141;
				switch (num2 == num)
				{
				}
				num = (short)2109931520;
				short num3 = num;
				num = (short)1525743617;
				if (num != 0)
				{
				}
				num = (short)1714225152;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTxDevChanSpacing_A23192.Value = value;
			}
		}

		// Token: 0x170063C9 RID: 25545
		// (get) Token: 0x0600C70B RID: 50955 RVA: 0x00BA4AE0 File Offset: 0x00BA2CE0
		// (set) Token: 0x0600C70C RID: 50956 RVA: 0x00BA4B94 File Offset: 0x00BA2D94
		public string CnvPerConventionalChannelOptionsTxDevChanSpacing_A23192_UIValue
		{
			get
			{
				short num = (short)323506471;
				short num2 = num;
				num = (short)1991594279;
				switch (num2 == num)
				{
				}
				num = (short)1760165888;
				short num3 = num;
				num = (short)584515584;
				if (num != 0)
				{
				}
				num = (short)2139095041;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTxDevChanSpacing_A23192.UIValue;
			}
			set
			{
				short num = (short)1135752169;
				short num2 = num;
				num = (short)1493840873;
				switch (num2 == num)
				{
				}
				num = (short)1898708992;
				short num3 = num;
				num = (short)1992622081;
				if (num != 0)
				{
				}
				num = (short)1286668288;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTxDevChanSpacing_A23192.UIValue = value;
			}
		}

		// Token: 0x170063CA RID: 25546
		// (get) Token: 0x0600C70D RID: 50957 RVA: 0x00BA4C4C File Offset: 0x00BA2E4C
		public global::AcpBusinessLayer.AcpListField CnvPerConventionalChannelOptionsTxDevChanSpacing_A23192
		{
			get
			{
				short num = (short)1980152850;
				short num2 = num;
				num = (short)1058323474;
				switch (num2 == num)
				{
				}
				num = (short)190906368;
				short num3 = num;
				num = (short)728563713;
				if (num != 0)
				{
				}
				num = (short)997785600;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTxDevChanSpacing_A23192;
			}
		}

		// Token: 0x170063CB RID: 25547
		// (get) Token: 0x0600C70E RID: 50958 RVA: 0x00BA4CFC File Offset: 0x00BA2EFC
		// (set) Token: 0x0600C70F RID: 50959 RVA: 0x00BA4DB0 File Offset: 0x00BA2FB0
		public bool CnvPerConventionalChannelOptionsTxDevChanSpacing_A23192_Applicable
		{
			get
			{
				short num = (short)1186456722;
				short num2 = num;
				num = (short)1943921810;
				switch (num2 == num)
				{
				}
				num = (short)781647872;
				short num3 = num;
				num = (short)387907585;
				if (num != 0)
				{
				}
				num = (short)454688768;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTxDevChanSpacing_A23192.Applicable;
			}
			set
			{
				short num = (short)577088146;
				short num2 = num;
				num = (short)712944274;
				switch (num2 == num)
				{
				}
				num = (short)1488715776;
				short num3 = num;
				num = (short)1955266561;
				if (num != 0)
				{
				}
				num = (short)2036793344;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTxDevChanSpacing_A23192.Applicable = value;
			}
		}

		// Token: 0x170063CC RID: 25548
		// (get) Token: 0x0600C710 RID: 50960 RVA: 0x00BA4E64 File Offset: 0x00BA3064
		// (set) Token: 0x0600C711 RID: 50961 RVA: 0x00BA4F18 File Offset: 0x00BA3118
		public bool CnvPerConventionalChannelOptionsTxDevChanSpacing_A23192_Valid
		{
			get
			{
				short num = (short)2139577747;
				short num2 = num;
				num = (short)1216109971;
				switch (num2 == num)
				{
				}
				num = (short)881000448;
				short num3 = num;
				num = (short)1999110144;
				if (num != 0)
				{
				}
				num = (short)1510670337;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTxDevChanSpacing_A23192.Valid;
			}
			set
			{
				short num = (short)773693591;
				short num2 = num;
				num = (short)455843991;
				switch (num2 == num)
				{
				}
				num = (short)52887552;
				short num3 = num;
				num = (short)1342242817;
				if (num != 0)
				{
				}
				num = (short)1625817088;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTxDevChanSpacing_A23192.Valid = value;
			}
		}

		// Token: 0x170063CD RID: 25549
		// (get) Token: 0x0600C712 RID: 50962 RVA: 0x00BA4FD0 File Offset: 0x00BA31D0
		// (set) Token: 0x0600C713 RID: 50963 RVA: 0x00BA5088 File Offset: 0x00BA3288
		public bool CnvPerConventionalChannelOptionsTxDevChanSpacing_A23192_Visible
		{
			get
			{
				short num = (short)899107534;
				short num2 = num;
				num = (short)72960718;
				switch (num2 == num)
				{
				}
				num = (short)973275136;
				short num3 = num;
				num = (short)1412694017;
				if (num != 0)
				{
				}
				num = (short)1688469504;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTxDevChanSpacing_A23192.Visible;
			}
			set
			{
				short num = (short)1084447686;
				short num2 = num;
				num = (short)166026182;
				switch (num2 == num)
				{
				}
				num = (short)1105526784;
				short num3 = num;
				num = (short)825425921;
				if (num != 0)
				{
				}
				num = (short)32112640;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTxDevChanSpacing_A23192.Visible = value;
			}
		}

		// Token: 0x170063CE RID: 25550
		// (get) Token: 0x0600C714 RID: 50964 RVA: 0x00BA513C File Offset: 0x00BA333C
		// (set) Token: 0x0600C715 RID: 50965 RVA: 0x00BA51F0 File Offset: 0x00BA33F0
		public bool CnvPerConventionalChannelOptionsTxDevChanSpacing_A23192_Editable
		{
			get
			{
				short num = (short)182646721;
				short num2 = num;
				num = (short)284948417;
				switch (num2 == num)
				{
				}
				num = (short)996016128;
				short num3 = num;
				num = (short)1521745921;
				if (num != 0)
				{
				}
				num = (short)1586036736;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTxDevChanSpacing_A23192.Editable;
			}
			set
			{
				short num = (short)2030878468;
				short num2 = num;
				num = (short)989118212;
				switch (num2 == num)
				{
				}
				num = (short)1089142784;
				short num3 = num;
				num = (short)2022375425;
				if (num != 0)
				{
				}
				num = (short)594870272;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTxDevChanSpacing_A23192.Editable = value;
			}
		}

		// Token: 0x170063CF RID: 25551
		// (get) Token: 0x0600C716 RID: 50966 RVA: 0x00BA52A8 File Offset: 0x00BA34A8
		internal string CnvPerConventionalChannelOptionsTxDevChanSpacing_A23192_UILabel
		{
			get
			{
				short num = (short)425745097;
				short num2 = num;
				num = (short)1531271881;
				switch (num2 == num)
				{
				}
				num = (short)328990720;
				short num3 = num;
				num = (short)2056912897;
				if (num != 0)
				{
				}
				num = (short)1580531712;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTxDevChanSpacing_A23192.UIName;
			}
		}

		// Token: 0x170063D0 RID: 25552
		// (get) Token: 0x0600C717 RID: 50967 RVA: 0x00BA535C File Offset: 0x00BA355C
		// (set) Token: 0x0600C718 RID: 50968 RVA: 0x00BA5410 File Offset: 0x00BA3610
		internal bool CnvPerConventionalChannelOptionsTxDevChanSpacing_A23192_HiddenStatic
		{
			get
			{
				short num = (short)394869549;
				short num2 = num;
				num = (short)1602829101;
				switch (num2 == num)
				{
				}
				num = (short)1181614080;
				short num3 = num;
				num = (short)1629159425;
				if (num != 0)
				{
				}
				num = (short)95485952;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTxDevChanSpacing_A23192.HiddenStatic;
			}
			set
			{
				short num = (short)1946205829;
				short num2 = num;
				num = (short)2060238469;
				switch (num2 == num)
				{
				}
				num = (short)1699872768;
				short num3 = num;
				num = (short)392101889;
				if (num != 0)
				{
				}
				num = (short)52035584;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTxDevChanSpacing_A23192.HiddenStatic = value;
			}
		}

		// Token: 0x170063D1 RID: 25553
		// (get) Token: 0x0600C719 RID: 50969 RVA: 0x00BA54C8 File Offset: 0x00BA36C8
		// (set) Token: 0x0600C71A RID: 50970 RVA: 0x00BA557C File Offset: 0x00BA377C
		internal bool CnvPerConventionalChannelOptionsTxDevChanSpacing_A23192_HiddenDynamic
		{
			get
			{
				short num = (short)21233665;
				if (num != 0)
				{
				}
				num = (short)2128612113;
				short num2 = num;
				num = (short)1291193105;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1013972992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1486028800;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTxDevChanSpacing_A23192.HiddenDynamic;
			}
			set
			{
				short num = (short)1662308500;
				short num2 = num;
				num = (short)311742612;
				switch (num2 == num)
				{
				}
				num = (short)1170604032;
				short num3 = num;
				num = (short)2091712512;
				if (num != 0)
				{
				}
				num = (short)2116419585;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsTxDevChanSpacing_A23192.HiddenDynamic = value;
			}
		}

		// Token: 0x170063D2 RID: 25554
		// (get) Token: 0x0600C71B RID: 50971 RVA: 0x00BA5630 File Offset: 0x00BA3830
		public bool CnvPerConventionalChannelOptionsTxDevChanSpacing_A23192_HasDiffs
		{
			get
			{
				short num = (short)1373770892;
				short num2 = num;
				num = (short)1364137100;
				switch (num2 == num)
				{
				}
				num = (short)160759808;
				short num3 = num;
				num = (short)1344405505;
				if (num != 0)
				{
				}
				num = (short)338034688;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsTxDevChanSpacing_A23192._HasDiffs;
			}
		}

		// Token: 0x170063D3 RID: 25555
		// (get) Token: 0x0600C71C RID: 50972 RVA: 0x00BA56E4 File Offset: 0x00BA38E4
		// (set) Token: 0x0600C71D RID: 50973 RVA: 0x00BA5798 File Offset: 0x00BA3998
		public bool CnvPerConventionalFrqncyOptnsMixVSPersistentMember_A38726Value
		{
			get
			{
				short num = (short)370671616;
				short num2 = num;
				num = (short)832857847;
				short num3 = num;
				num = (short)688088823;
				switch (num3 == num)
				{
				}
				num = (short)1791950849;
				if (num != 0)
				{
				}
				num = (short)1951596544;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalFrqncyOptnsMixVSPersistentMember_A38726.Value;
			}
			set
			{
				short num = (short)344522752;
				short num2 = num;
				num = (short)971633347;
				short num3 = num;
				num = (short)1493037763;
				switch (num3 == num)
				{
				}
				num = (short)1386020865;
				if (num != 0)
				{
				}
				num = (short)25296896;
				if (num != 0)
				{
				}
				this.cnvPerConventionalFrqncyOptnsMixVSPersistentMember_A38726.Value = value;
			}
		}

		// Token: 0x170063D4 RID: 25556
		// (get) Token: 0x0600C71E RID: 50974 RVA: 0x00BA5850 File Offset: 0x00BA3A50
		public global::AcpBusinessLayer.AcpField<bool> CnvPerConventionalFrqncyOptnsMixVSPersistentMember_A38726
		{
			get
			{
				short num = (short)762314752;
				short num2 = num;
				num = (short)996666124;
				short num3 = num;
				num = (short)1473637132;
				switch (num3 == num)
				{
				}
				num = (short)1487208448;
				if (num != 0)
				{
				}
				num = (short)399179777;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalFrqncyOptnsMixVSPersistentMember_A38726;
			}
		}

		// Token: 0x170063D5 RID: 25557
		// (get) Token: 0x0600C71F RID: 50975 RVA: 0x00BA58FC File Offset: 0x00BA3AFC
		// (set) Token: 0x0600C720 RID: 50976 RVA: 0x00BA59B0 File Offset: 0x00BA3BB0
		public bool CnvPerConventionalFrqncyOptnsMixVSPersistentMember_A38726_UIValue
		{
			get
			{
				short num = (short)905773056;
				short num2 = num;
				num = (short)137259896;
				short num3 = num;
				num = (short)1015442296;
				switch (num3 == num)
				{
				}
				num = (short)1154285568;
				if (num != 0)
				{
				}
				num = (short)989003777;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalFrqncyOptnsMixVSPersistentMember_A38726.Value;
			}
			set
			{
				short num = (short)1633484800;
				short num2 = num;
				num = (short)295612868;
				short num3 = num;
				num = (short)324579780;
				switch (num3 == num)
				{
				}
				num = (short)410910721;
				if (num != 0)
				{
				}
				num = (short)722468864;
				if (num != 0)
				{
				}
				this.cnvPerConventionalFrqncyOptnsMixVSPersistentMember_A38726.Value = value;
			}
		}

		// Token: 0x170063D6 RID: 25558
		// (get) Token: 0x0600C721 RID: 50977 RVA: 0x00BA5A68 File Offset: 0x00BA3C68
		// (set) Token: 0x0600C722 RID: 50978 RVA: 0x00BA5B1C File Offset: 0x00BA3D1C
		public bool CnvPerConventionalFrqncyOptnsMixVSPersistentMember_A38726_Applicable
		{
			get
			{
				short num = (short)525991936;
				short num2 = num;
				num = (short)1339949057;
				if (num != 0)
				{
				}
				num = (short)1599455954;
				short num3 = num;
				num = (short)1656406738;
				switch (num3 == num)
				{
				}
				num = (short)1296564224;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalFrqncyOptnsMixVSPersistentMember_A38726.Applicable;
			}
			set
			{
				short num = (short)1871577088;
				short num2 = num;
				num = (short)15385405;
				short num3 = num;
				num = (short)1289274173;
				switch (num3 == num)
				{
				}
				num = (short)659750913;
				if (num != 0)
				{
				}
				num = (short)864550912;
				if (num != 0)
				{
				}
				this.cnvPerConventionalFrqncyOptnsMixVSPersistentMember_A38726.Applicable = value;
			}
		}

		// Token: 0x170063D7 RID: 25559
		// (get) Token: 0x0600C723 RID: 50979 RVA: 0x00BA5BD0 File Offset: 0x00BA3DD0
		// (set) Token: 0x0600C724 RID: 50980 RVA: 0x00BA5C88 File Offset: 0x00BA3E88
		public bool CnvPerConventionalFrqncyOptnsMixVSPersistentMember_A38726_Valid
		{
			get
			{
				short num = (short)1058144256;
				short num2 = num;
				num = (short)1257544501;
				short num3 = num;
				num = (short)1582078773;
				switch (num3 == num)
				{
				}
				num = (short)1282277377;
				if (num != 0)
				{
				}
				num = (short)464912384;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalFrqncyOptnsMixVSPersistentMember_A38726.Valid;
			}
			set
			{
				short num = (short)71041024;
				short num2 = num;
				num = (short)1086822932;
				short num3 = num;
				num = (short)984914452;
				switch (num3 == num)
				{
				}
				num = (short)2087845888;
				if (num != 0)
				{
				}
				num = (short)1967390721;
				if (num != 0)
				{
				}
				this.cnvPerConventionalFrqncyOptnsMixVSPersistentMember_A38726.Valid = value;
			}
		}

		// Token: 0x170063D8 RID: 25560
		// (get) Token: 0x0600C725 RID: 50981 RVA: 0x00BA5D40 File Offset: 0x00BA3F40
		// (set) Token: 0x0600C726 RID: 50982 RVA: 0x00BA5DFC File Offset: 0x00BA3FFC
		public bool CnvPerConventionalFrqncyOptnsMixVSPersistentMember_A38726_Visible
		{
			get
			{
				short num = (short)1410072576;
				short num2 = num;
				num = (short)1121683287;
				short num3 = num;
				num = (short)565675863;
				switch (num3 == num)
				{
				}
				num = (short)1272315904;
				if (num != 0)
				{
				}
				num = (short)393478145;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalFrqncyOptnsMixVSPersistentMember_A38726.Visible;
			}
			set
			{
				short num = (short)435879936;
				short num2 = num;
				num = (short)1155651478;
				short num3 = num;
				num = (short)1954535318;
				switch (num3 == num)
				{
				}
				num = (short)943783937;
				if (num != 0)
				{
				}
				num = (short)992083968;
				if (num != 0)
				{
				}
				this.cnvPerConventionalFrqncyOptnsMixVSPersistentMember_A38726.Visible = value;
			}
		}

		// Token: 0x170063D9 RID: 25561
		// (get) Token: 0x0600C727 RID: 50983 RVA: 0x00BA5EB0 File Offset: 0x00BA40B0
		// (set) Token: 0x0600C728 RID: 50984 RVA: 0x00BA5F64 File Offset: 0x00BA4164
		public bool CnvPerConventionalFrqncyOptnsMixVSPersistentMember_A38726_Editable
		{
			get
			{
				short num = (short)1376124928;
				short num2 = num;
				num = (short)1418348769;
				short num3 = num;
				num = (short)488196321;
				switch (num3 == num)
				{
				}
				num = (short)1557725185;
				if (num != 0)
				{
				}
				num = (short)1756299264;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalFrqncyOptnsMixVSPersistentMember_A38726.Editable;
			}
			set
			{
				short num = (short)1108017152;
				short num2 = num;
				num = (short)35389441;
				if (num != 0)
				{
				}
				num = (short)127411970;
				short num3 = num;
				num = (short)706815746;
				switch (num3 == num)
				{
				}
				num = (short)2062483456;
				if (num != 0)
				{
				}
				this.cnvPerConventionalFrqncyOptnsMixVSPersistentMember_A38726.Editable = value;
			}
		}

		// Token: 0x170063DA RID: 25562
		// (get) Token: 0x0600C729 RID: 50985 RVA: 0x00BA6018 File Offset: 0x00BA4218
		internal string CnvPerConventionalFrqncyOptnsMixVSPersistentMember_A38726_UILabel
		{
			get
			{
				short num = (short)1488846848;
				short num2 = num;
				num = (short)817859708;
				short num3 = num;
				num = (short)862424188;
				switch (num3 == num)
				{
				}
				num = (short)599392256;
				if (num != 0)
				{
				}
				num = (short)1261240321;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalFrqncyOptnsMixVSPersistentMember_A38726.UIName;
			}
		}

		// Token: 0x170063DB RID: 25563
		// (get) Token: 0x0600C72A RID: 50986 RVA: 0x00BA60CC File Offset: 0x00BA42CC
		// (set) Token: 0x0600C72B RID: 50987 RVA: 0x00BA6180 File Offset: 0x00BA4380
		internal bool CnvPerConventionalFrqncyOptnsMixVSPersistentMember_A38726_HiddenStatic
		{
			get
			{
				short num = (short)2097741824;
				short num2 = num;
				num = (short)1107886081;
				if (num != 0)
				{
				}
				num = (short)235349435;
				short num3 = num;
				num = (short)1136141755;
				switch (num3 == num)
				{
				}
				num = (short)755630080;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalFrqncyOptnsMixVSPersistentMember_A38726.HiddenStatic;
			}
			set
			{
				short num = (short)925564928;
				short num2 = num;
				num = (short)840239120;
				short num3 = num;
				num = (short)690489360;
				switch (num3 == num)
				{
				}
				num = (short)487653377;
				if (num != 0)
				{
				}
				num = (short)1178533888;
				if (num != 0)
				{
				}
				this.cnvPerConventionalFrqncyOptnsMixVSPersistentMember_A38726.HiddenStatic = value;
			}
		}

		// Token: 0x170063DC RID: 25564
		// (get) Token: 0x0600C72C RID: 50988 RVA: 0x00BA6234 File Offset: 0x00BA4434
		// (set) Token: 0x0600C72D RID: 50989 RVA: 0x00BA62E8 File Offset: 0x00BA44E8
		internal bool CnvPerConventionalFrqncyOptnsMixVSPersistentMember_A38726_HiddenDynamic
		{
			get
			{
				short num = (short)1885339648;
				short num2 = num;
				num = (short)813891585;
				if (num != 0)
				{
				}
				num = (short)474889407;
				short num3 = num;
				num = (short)292764863;
				switch (num3 == num)
				{
				}
				num = (short)1434648576;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalFrqncyOptnsMixVSPersistentMember_A38726.HiddenDynamic;
			}
			set
			{
				short num = (short)369229824;
				short num2 = num;
				num = (short)1955463169;
				if (num != 0)
				{
				}
				num = (short)1736347857;
				short num3 = num;
				num = (short)304255185;
				switch (num3 == num)
				{
				}
				num = (short)1726349312;
				if (num != 0)
				{
				}
				this.cnvPerConventionalFrqncyOptnsMixVSPersistentMember_A38726.HiddenDynamic = value;
			}
		}

		// Token: 0x170063DD RID: 25565
		// (get) Token: 0x0600C72E RID: 50990 RVA: 0x00BA63A0 File Offset: 0x00BA45A0
		public bool CnvPerConventionalFrqncyOptnsMixVSPersistentMember_A38726_HasDiffs
		{
			get
			{
				short num = (short)131006464;
				short num2 = num;
				num = (short)1162403120;
				short num3 = num;
				num = (short)425450800;
				switch (num3 == num)
				{
				}
				num = (short)2028339201;
				if (num != 0)
				{
				}
				num = (short)231276544;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalFrqncyOptnsMixVSPersistentMember_A38726._HasDiffs;
			}
		}

		// Token: 0x170063DE RID: 25566
		// (get) Token: 0x0600C72F RID: 50991 RVA: 0x00BA6458 File Offset: 0x00BA4658
		// (set) Token: 0x0600C730 RID: 50992 RVA: 0x00BA6510 File Offset: 0x00BA4710
		public int CnvPerConventionalChannelOptionsUserSelectablePLMPLEnhance_43029Value
		{
			get
			{
				short num = (short)2136932352;
				short num2 = num;
				num = (short)1182293427;
				short num3 = num;
				num = (short)1287216563;
				switch (num3 == num)
				{
				}
				num = (short)951910401;
				if (num != 0)
				{
				}
				num = (short)1823408128;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsUserSelectablePLMPLEnhance_43029.Value;
			}
			set
			{
				short num = (short)2085486592;
				short num2 = num;
				num = (short)185377254;
				short num3 = num;
				num = (short)1197646310;
				switch (num3 == num)
				{
				}
				num = (short)933429249;
				if (num != 0)
				{
				}
				num = (short)1818951680;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsUserSelectablePLMPLEnhance_43029.Value = value;
			}
		}

		// Token: 0x170063DF RID: 25567
		// (get) Token: 0x0600C731 RID: 50993 RVA: 0x00BA65C4 File Offset: 0x00BA47C4
		// (set) Token: 0x0600C732 RID: 50994 RVA: 0x00BA667C File Offset: 0x00BA487C
		public string CnvPerConventionalChannelOptionsUserSelectablePLMPLEnhance_43029_UIValue
		{
			get
			{
				short num = (short)94175232;
				short num2 = num;
				num = (short)1199266109;
				short num3 = num;
				num = (short)452745533;
				switch (num3 == num)
				{
				}
				num = (short)36175873;
				if (num != 0)
				{
				}
				num = (short)1685651456;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsUserSelectablePLMPLEnhance_43029.UIValue;
			}
			set
			{
				short num = (short)637140992;
				short num2 = num;
				num = (short)807980867;
				short num3 = num;
				num = (short)228314947;
				switch (num3 == num)
				{
				}
				num = (short)61734912;
				if (num != 0)
				{
				}
				num = (short)1466040321;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsUserSelectablePLMPLEnhance_43029.UIValue = value;
			}
		}

		// Token: 0x170063E0 RID: 25568
		// (get) Token: 0x0600C733 RID: 50995 RVA: 0x00BA6734 File Offset: 0x00BA4934
		public global::AcpBusinessLayer.AcpListField CnvPerConventionalChannelOptionsUserSelectablePLMPLEnhance_43029
		{
			get
			{
				short num = (short)1579352064;
				short num2 = num;
				num = (short)1271573463;
				short num3 = num;
				num = (short)1051438039;
				switch (num3 == num)
				{
				}
				num = (short)1558511617;
				if (num != 0)
				{
				}
				num = (short)928382976;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsUserSelectablePLMPLEnhance_43029;
			}
		}

		// Token: 0x170063E1 RID: 25569
		// (get) Token: 0x0600C734 RID: 50996 RVA: 0x00BA67E4 File Offset: 0x00BA49E4
		// (set) Token: 0x0600C735 RID: 50997 RVA: 0x00BA6898 File Offset: 0x00BA4A98
		public bool CnvPerConventionalChannelOptionsUserSelectablePLMPLEnhance_43029_Applicable
		{
			get
			{
				short num = (short)1078263808;
				short num2 = num;
				num = (short)1525473667;
				short num3 = num;
				num = (short)302899587;
				switch (num3 == num)
				{
				}
				num = (short)898629633;
				if (num != 0)
				{
				}
				num = (short)1343815680;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsUserSelectablePLMPLEnhance_43029.Applicable;
			}
			set
			{
				short num = (short)14155776;
				short num2 = num;
				num = (short)1256756855;
				short num3 = num;
				num = (short)1426757239;
				switch (num3 == num)
				{
				}
				num = (short)1800339456;
				if (num != 0)
				{
				}
				num = (short)452919297;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsUserSelectablePLMPLEnhance_43029.Applicable = value;
			}
		}

		// Token: 0x170063E2 RID: 25570
		// (get) Token: 0x0600C736 RID: 50998 RVA: 0x00BA694C File Offset: 0x00BA4B4C
		// (set) Token: 0x0600C737 RID: 50999 RVA: 0x00BA6A00 File Offset: 0x00BA4C00
		public bool CnvPerConventionalChannelOptionsUserSelectablePLMPLEnhance_43029_Valid
		{
			get
			{
				short num = (short)2066612224;
				short num2 = num;
				num = (short)953432522;
				short num3 = num;
				num = (short)1931491786;
				switch (num3 == num)
				{
				}
				num = (short)173277185;
				if (num != 0)
				{
				}
				num = (short)1192558592;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsUserSelectablePLMPLEnhance_43029.Valid;
			}
			set
			{
				short num = (short)1739653120;
				short num2 = num;
				num = (short)2095145610;
				short num3 = num;
				num = (short)414081674;
				switch (num3 == num)
				{
				}
				num = (short)728891392;
				if (num != 0)
				{
				}
				num = (short)676397057;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsUserSelectablePLMPLEnhance_43029.Valid = value;
			}
		}

		// Token: 0x170063E3 RID: 25571
		// (get) Token: 0x0600C738 RID: 51000 RVA: 0x00BA6AB8 File Offset: 0x00BA4CB8
		// (set) Token: 0x0600C739 RID: 51001 RVA: 0x00BA6B6C File Offset: 0x00BA4D6C
		public bool CnvPerConventionalChannelOptionsUserSelectablePLMPLEnhance_43029_Visible
		{
			get
			{
				short num = (short)833683456;
				short num2 = num;
				num = (short)1216020481;
				if (num != 0)
				{
				}
				num = (short)1846396322;
				short num3 = num;
				num = (short)1182451106;
				switch (num3 == num)
				{
				}
				num = (short)1639448576;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsUserSelectablePLMPLEnhance_43029.Visible;
			}
			set
			{
				short num = (short)1430126592;
				short num2 = num;
				num = (short)1777860609;
				if (num != 0)
				{
				}
				num = (short)1110449425;
				short num3 = num;
				num = (short)396434705;
				switch (num3 == num)
				{
				}
				num = (short)2059075584;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsUserSelectablePLMPLEnhance_43029.Visible = value;
			}
		}

		// Token: 0x170063E4 RID: 25572
		// (get) Token: 0x0600C73A RID: 51002 RVA: 0x00BA6C20 File Offset: 0x00BA4E20
		// (set) Token: 0x0600C73B RID: 51003 RVA: 0x00BA6CD4 File Offset: 0x00BA4ED4
		public bool CnvPerConventionalChannelOptionsUserSelectablePLMPLEnhance_43029_Editable
		{
			get
			{
				short num = (short)583139328;
				short num2 = num;
				num = (short)1863385089;
				if (num != 0)
				{
				}
				num = (short)792762264;
				short num3 = num;
				num = (short)1443993496;
				switch (num3 == num)
				{
				}
				num = (short)932577280;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsUserSelectablePLMPLEnhance_43029.Editable;
			}
			set
			{
				short num = (short)1409875968;
				short num2 = num;
				num = (short)1629545796;
				short num3 = num;
				num = (short)919921988;
				switch (num3 == num)
				{
				}
				num = (short)1693974529;
				if (num != 0)
				{
				}
				num = (short)1768685568;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsUserSelectablePLMPLEnhance_43029.Editable = value;
			}
		}

		// Token: 0x170063E5 RID: 25573
		// (get) Token: 0x0600C73C RID: 51004 RVA: 0x00BA6D84 File Offset: 0x00BA4F84
		internal string CnvPerConventionalChannelOptionsUserSelectablePLMPLEnhance_43029_UILabel
		{
			get
			{
				short num = (short)1749352448;
				short num2 = num;
				num = (short)363271678;
				short num3 = num;
				num = (short)413472254;
				switch (num3 == num)
				{
				}
				num = (short)519176193;
				if (num != 0)
				{
				}
				num = (short)1426063360;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsUserSelectablePLMPLEnhance_43029.UIName;
			}
		}

		// Token: 0x170063E6 RID: 25574
		// (get) Token: 0x0600C73D RID: 51005 RVA: 0x00BA6E38 File Offset: 0x00BA5038
		// (set) Token: 0x0600C73E RID: 51006 RVA: 0x00BA6EEC File Offset: 0x00BA50EC
		internal bool CnvPerConventionalChannelOptionsUserSelectablePLMPLEnhance_43029_HiddenStatic
		{
			get
			{
				short num = (short)1824784384;
				short num2 = num;
				num = (short)2011674581;
				short num3 = num;
				num = (short)762689493;
				switch (num3 == num)
				{
				}
				num = (short)2115371008;
				if (num != 0)
				{
				}
				num = (short)763559937;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsUserSelectablePLMPLEnhance_43029.HiddenStatic;
			}
			set
			{
				short num = (short)1014169600;
				short num2 = num;
				num = (short)425895399;
				short num3 = num;
				num = (short)756655591;
				switch (num3 == num)
				{
				}
				num = (short)1422196737;
				if (num != 0)
				{
				}
				num = (short)1776615424;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsUserSelectablePLMPLEnhance_43029.HiddenStatic = value;
			}
		}

		// Token: 0x170063E7 RID: 25575
		// (get) Token: 0x0600C73F RID: 51007 RVA: 0x00BA6FA0 File Offset: 0x00BA51A0
		// (set) Token: 0x0600C740 RID: 51008 RVA: 0x00BA7054 File Offset: 0x00BA5254
		internal bool CnvPerConventionalChannelOptionsUserSelectablePLMPLEnhance_43029_HiddenDynamic
		{
			get
			{
				short num = (short)800718848;
				short num2 = num;
				num = (short)173245612;
				short num3 = num;
				num = (short)1731429548;
				switch (num3 == num)
				{
				}
				num = (short)1229520897;
				if (num != 0)
				{
				}
				num = (short)830472192;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsUserSelectablePLMPLEnhance_43029.HiddenDynamic;
			}
			set
			{
				short num = (short)50987008;
				short num2 = num;
				num = (short)851344722;
				short num3 = num;
				num = (short)1407679826;
				switch (num3 == num)
				{
				}
				num = (short)1639317504;
				if (num != 0)
				{
				}
				num = (short)1463287809;
				if (num != 0)
				{
				}
				this.cnvPerConventionalChannelOptionsUserSelectablePLMPLEnhance_43029.HiddenDynamic = value;
			}
		}

		// Token: 0x170063E8 RID: 25576
		// (get) Token: 0x0600C741 RID: 51009 RVA: 0x00BA710C File Offset: 0x00BA530C
		public bool CnvPerConventionalChannelOptionsUserSelectablePLMPLEnhance_43029_HasDiffs
		{
			get
			{
				short num = (short)1764163584;
				short num2 = num;
				num = (short)1225869277;
				short num3 = num;
				num = (short)1256605661;
				switch (num3 == num)
				{
				}
				num = (short)1993211905;
				if (num != 0)
				{
				}
				num = (short)1632960512;
				if (num != 0)
				{
				}
				return this.cnvPerConventionalChannelOptionsUserSelectablePLMPLEnhance_43029._HasDiffs;
			}
		}

		// Token: 0x170063E9 RID: 25577
		// (get) Token: 0x0600C742 RID: 51010 RVA: 0x00BA71C0 File Offset: 0x00BA53C0
		public global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.ConventionalWide RefConventionalWide
		{
			get
			{
				short num = (short)904396800;
				short num2 = num;
				num = (short)1376427874;
				short num3 = num;
				num = (short)998678370;
				switch (num3 == num)
				{
				}
				num = (short)438304769;
				if (num != 0)
				{
				}
				num = (short)1797783552;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2024)[0] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.ConventionalWide;
			}
		}

		// Token: 0x170063EA RID: 25578
		// (get) Token: 0x0600C743 RID: 51011 RVA: 0x00BA7280 File Offset: 0x00BA5480
		public global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation RefRadioInformation
		{
			get
			{
				short num = (short)22675456;
				short num2 = num;
				num = (short)598569238;
				short num3 = num;
				num = (short)1781821718;
				switch (num3 == num)
				{
				}
				num = (short)1606352897;
				if (num != 0)
				{
				}
				num = (short)1641807872;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation;
			}
		}

		// Token: 0x170063EB RID: 25579
		// (get) Token: 0x0600C744 RID: 51012 RVA: 0x00BA7340 File Offset: 0x00BA5540
		public global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide RefSecureWide
		{
			get
			{
				short num = (short)906821632;
				short num2 = num;
				num = (short)469891285;
				short num3 = num;
				num = (short)659749077;
				switch (num3 == num)
				{
				}
				num = (short)186843136;
				if (num != 0)
				{
				}
				num = (short)1193803777;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2021)[0] as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide;
			}
		}

		// Token: 0x0600C745 RID: 51013 RVA: 0x00BA7400 File Offset: 0x00BA5600
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
					num2 = (short)802422785;
					if (num2 != 0)
					{
					}
					num2 = (short)1064828932;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (base.ParentRecset != null)
					{
						num2 = (short)2048983040;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 2:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)1896415235;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					return result;
				case 4:
				{
					if (base.ParentRecset.ContainerDoc == null)
					{
						return result;
					}
					num2 = (short)325470556;
					short num3 = num2;
					num2 = (short)1867860316;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)1227620352;
						if (num2 != 0)
						{
						}
						num2 = (short)1920598018;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_24;
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)448659456;
			short num4 = num2;
			num2 = (short)196345857;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0400648F RID: 25743
		private global::AcpBusinessLayer.AcpSimpleRangeField cnvPerConventionalChannelOptionsTANetworkID_A7863;

		// Token: 0x04006490 RID: 25744
		private global::AcpBusinessLayer.AcpField<bool> cnvPerConventionalChannelOptionsItinerantChannelFrequency_A8359;

		// Token: 0x04006491 RID: 25745
		private global::AcpBusinessLayer.AcpListField cnvPerConventionalChannelOptionsPLDeviation_A8708;

		// Token: 0x04006492 RID: 25746
		private global::AcpBusinessLayer.AcpListField cnvPerConventionalChannelOptionsRxDPLCode_A8908;

		// Token: 0x04006493 RID: 25747
		private global::AcpBusinessLayer.AcpField<bool> cnvPerConventionalChannelOptionsRxDPLInvert_A8909;

		// Token: 0x04006494 RID: 25748
		private global::AcpBusinessLayer.AcpFrequencyField cnvPerConventionalChannelOptionsRxFrequency_A8911;

		// Token: 0x04006495 RID: 25749
		private global::AcpBusinessLayer.AcpListField cnvPerConventionalChannelOptionsRxPLCode_A8917;

		// Token: 0x04006496 RID: 25750
		private global::AcpBusinessLayer.AcpListField cnvPerConventionalChannelOptionsRxPLFreq_A8918;

		// Token: 0x04006497 RID: 25751
		private global::AcpBusinessLayer.AcpListField cnvPerConventionalChannelOptionsRxSquelchType_A8919;

		// Token: 0x04006498 RID: 25752
		private global::AcpBusinessLayer.AcpSimpleRangeField cnvPerConventionalChannelOptionsRxNetworkID_A9023;

		// Token: 0x04006499 RID: 25753
		private global::AcpBusinessLayer.AcpField<bool> cnvPerConventionalChannelOptionsDirectTalkaround_A9255;

		// Token: 0x0400649A RID: 25754
		private global::AcpBusinessLayer.AcpListField cnvPerConventionalChannelOptionsTADPLCode_A9256;

		// Token: 0x0400649B RID: 25755
		private global::AcpBusinessLayer.AcpField<bool> cnvPerConventionalChannelOptionsTADPLInvert_A9259;

		// Token: 0x0400649C RID: 25756
		private global::AcpBusinessLayer.AcpFrequencyField cnvPerConventionalChannelOptionsTAFrequency_A9260;

		// Token: 0x0400649D RID: 25757
		private global::AcpBusinessLayer.AcpListField cnvPerConventionalChannelOptionsTAPLCode_A9261;

		// Token: 0x0400649E RID: 25758
		private global::AcpBusinessLayer.AcpListField cnvPerConventionalChannelOptionsTAPLFreq_A9264;

		// Token: 0x0400649F RID: 25759
		private global::AcpBusinessLayer.AcpListField cnvPerConventionalChannelOptionsTASquelchType_A9265;

		// Token: 0x040064A0 RID: 25760
		private global::AcpBusinessLayer.AcpRecRefField cnvPerConventionalChannelOptionsASTROTalkgroupID_A9281;

		// Token: 0x040064A1 RID: 25761
		private global::AcpBusinessLayer.AcpListField cnvPerConventionalChannelOptionsTxDPLCode_A9409;

		// Token: 0x040064A2 RID: 25762
		private global::AcpBusinessLayer.AcpField<bool> cnvPerConventionalChannelOptionsTxDPLInvert_A9410;

		// Token: 0x040064A3 RID: 25763
		private global::AcpBusinessLayer.AcpFrequencyField cnvPerConventionalChannelOptionsTxFrequency_A9414;

		// Token: 0x040064A4 RID: 25764
		private global::AcpBusinessLayer.AcpListField cnvPerConventionalChannelOptionsTxPLCode_A9418;

		// Token: 0x040064A5 RID: 25765
		private global::AcpBusinessLayer.AcpListField cnvPerConventionalChannelOptionsTxPLFreq_A9419;

		// Token: 0x040064A6 RID: 25766
		private global::AcpBusinessLayer.AcpListField cnvPerConventionalChannelOptionsTxSquelchType_A9426;

		// Token: 0x040064A7 RID: 25767
		private global::AcpBusinessLayer.AcpSimpleRangeField cnvPerConventionalChannelOptionsTxNetworkID_A9550;

		// Token: 0x040064A8 RID: 25768
		private global::AcpBusinessLayer.AcpField<bool> cnvPerConventionalChannelOptionsUserSelectablePLMPL_A9606;

		// Token: 0x040064A9 RID: 25769
		private global::AcpBusinessLayer.AcpField<bool> cnvPerConventionalChannelOptionsTalkaround_A19837;

		// Token: 0x040064AA RID: 25770
		private global::AcpBusinessLayer.AcpKeyField cnvPerConventionalChannelOptionsKeyofConventionalChannelOptions_A20745;

		// Token: 0x040064AB RID: 25771
		private global::AcpBusinessLayer.AcpListField cnvPerConventionalChannelOptionsTxDevChanSpacing_A23192;

		// Token: 0x040064AC RID: 25772
		private global::AcpBusinessLayer.AcpField<bool> cnvPerConventionalFrqncyOptnsMixVSPersistentMember_A38726;

		// Token: 0x040064AD RID: 25773
		private global::AcpBusinessLayer.AcpListField cnvPerConventionalChannelOptionsUserSelectablePLMPLEnhance_43029;
	}
}
